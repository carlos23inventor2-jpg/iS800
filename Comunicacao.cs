using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using iS800.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	[StandardModule]
	internal sealed class Comunicacao
	{
		public static bool Init_porta_serial()
		{
			try
			{
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					if (MyProject.Forms.Plataforma.SerialPort1.IsOpen)
					{
						MyProject.Forms.Plataforma.SerialPort1.Close();
					}
					MyProject.Forms.Plataforma.SerialPort1.Encoding = Encoding.GetEncoding(28591);
					MyProject.Forms.Plataforma.SerialPort1.PortName = Comunicacao.Config_sistema.Serial.Porta_serial;
					switch (Comunicacao.Config_sistema.Serial.Baudrate)
					{
					case 0:
						MyProject.Forms.Plataforma.SerialPort1.BaudRate = 1200;
						break;
					case 1:
						MyProject.Forms.Plataforma.SerialPort1.BaudRate = 2400;
						break;
					case 2:
						MyProject.Forms.Plataforma.SerialPort1.BaudRate = 4800;
						break;
					case 3:
						MyProject.Forms.Plataforma.SerialPort1.BaudRate = 9600;
						break;
					case 4:
						MyProject.Forms.Plataforma.SerialPort1.BaudRate = 19200;
						break;
					case 5:
						MyProject.Forms.Plataforma.SerialPort1.BaudRate = 38400;
						break;
					}
					MyProject.Forms.Plataforma.SerialPort1.Parity = Comunicacao.Config_sistema.Serial.Parity;
					MyProject.Forms.Plataforma.SerialPort1.StopBits = Comunicacao.Config_sistema.Serial.StopBits;
					switch (Comunicacao.Config_sistema.Serial.DataBits)
					{
					case 0:
						MyProject.Forms.Plataforma.SerialPort1.DataBits = 4;
						break;
					case 1:
						MyProject.Forms.Plataforma.SerialPort1.DataBits = 5;
						break;
					case 2:
						MyProject.Forms.Plataforma.SerialPort1.DataBits = 6;
						break;
					case 3:
						MyProject.Forms.Plataforma.SerialPort1.DataBits = 7;
						break;
					case 4:
						MyProject.Forms.Plataforma.SerialPort1.DataBits = 8;
						break;
					}
					MyProject.Forms.Plataforma.SerialPort1.Open();
					Comunicacao.Init_buffer_serial();
					Geral.Config_geral.Porta_serial_Ok = true;
				}
				else
				{
					Geral.Config_geral.Porta_serial_Ok = Comunicacao.Config_sistema.tipo_interface == 2;
				}
				return Geral.Config_geral.Porta_serial_Ok;
			}
			catch (Exception)
			{
				Interaction.MsgBox("Erro na escolha da porta de comunicação serial", MsgBoxStyle.AbortRetryIgnore, "Atenção - verifique configuração");
				Geral.Config_geral.Porta_serial_Ok = false;
				return false;
			}
		}


		public static bool Init_buffer_serial()
		{
			try
			{
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.DiscardOutBuffer();
					MyProject.Forms.Plataforma.SerialPort1.DiscardInBuffer();
				}
				for (int i = 0; i <= 512; i++)
				{
					Comunicacao.Buffer_resp[i] = 0;
					Comunicacao.Buffer_cmd[i] = 0;
				}
				Comunicacao.Ctrl_Com.Tipo_funcao = 0;
				Comunicacao.Ctrl_Com.Cont_rx = 0;
				Comunicacao.Ctrl_Com.Frame = 255;
				return true;
			}
			catch (Exception)
			{
				Interaction.MsgBox("Erro na localização da porta serial!", MsgBoxStyle.YesNoCancel, "Atenção - Porta Serial");
				return false;
			}
		}


		public static bool VerificaPortaSerialExiste()
		{
			bool isOpen = MyProject.Forms.Plataforma.SerialPort1.IsOpen;
			Geral.Config_geral.Porta_serial_Ok = isOpen;
			return isOpen;
		}

		public static int Crc16_TX(ref int Num_dados)
		{
			int num = 65535;
			int num2 = 0;
			checked
			{
				int num3 = Num_dados - 1;
				for (int i = num2; i <= num3; i++)
				{
					num ^= (int)Comunicacao.Buffer_cmd[i];
					num &= 65535;
					int num4 = 1;
					do
					{
						if ((num & 1) != 0)
						{
							num /= 2;
							num ^= 40961;
							num &= 65535;
						}
						else
						{
							num /= 2;
						}
						num4++;
					}
					while (num4 <= 8);
				}
				return num;
			}
		}

		public static bool Crc16_RX(ref int Num_dados)
		{
			int num = 65535;
			short num2 = 0;
			short num3 = checked((short)(Num_dados - 1));
			for (short num4 = num2; num4 <= num3; num4 += 1)
			{
				num ^= (int)Comunicacao.Buffer_resp[(int)num4];
				num &= 65535;
				short num5 = 1;
				do
				{
					if ((num & 1) != 0)
					{
						num /= 2;
						num ^= 40961;
						num &= 65535;
					}
					else
					{
						num /= 2;
					}
					num5 += 1;
				}
				while (num5 <= 8);
			}
			return Comunicacao.Buffer_resp[Num_dados] == (byte)(num & 255) && Comunicacao.Buffer_resp[checked(Num_dados + 1)] == (byte)(num / 256);
		}

		public static bool CMD_Le_Pagina_TCPIP(int pagina, int endereco, int tamanho, ref NetworkStream ns)
		{
			string msg = " Comando leitura página " + Conversion.Str(pagina / 256);
			Comunicacao.Init_buffer_serial();
			Comunicacao.Buffer_cmd[0] = 0;
			Comunicacao.Buffer_cmd[1] = 0;
			Comunicacao.Buffer_cmd[2] = 0;
			Comunicacao.Buffer_cmd[3] = 0;
			Comunicacao.Buffer_cmd[4] = 0;
			Comunicacao.Buffer_cmd[5] = 6;
			checked
			{
				Comunicacao.Buffer_cmd[6] = (byte)(endereco % 256);
				Comunicacao.Buffer_cmd[7] = 3;
				Comunicacao.Buffer_cmd[8] = (byte)(pagina / 256);
				Comunicacao.Buffer_cmd[9] = (byte)(pagina % 256);
				Comunicacao.Buffer_cmd[10] = (byte)(tamanho / 256);
				Comunicacao.Buffer_cmd[11] = (byte)(tamanho % 256);
				Comunicacao.Ctrl_Com.Cont_tx = 12;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, msg);
				ns.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		public static bool CMD_Le_Pagina(int pagina, int endereco, int tamanho)
		{
			string msg = " Comando leitura página " + Conversion.Str(pagina / 256);
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)(endereco % 256);
				Comunicacao.Buffer_cmd[1] = 3;
				Comunicacao.Buffer_cmd[2] = (byte)(pagina / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(pagina % 256);
				Comunicacao.Buffer_cmd[4] = (byte)(tamanho / 256);
				Comunicacao.Buffer_cmd[5] = (byte)(tamanho % 256);
				int num = 6;
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[6] = (byte)(num2 % 256);
				Comunicacao.Buffer_cmd[7] = (byte)(num2 / 256);
				Comunicacao.Ctrl_Com.Cont_tx = 8;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, msg);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		public static bool CMD_Esc_habilitacao(int codigo, int endereco)
		{
			string msg;
			if (codigo == 21845)
			{
				msg = " Comando para habilitar escrita de bloco";
			}
			else
			{
				msg = " Comando para finalizar escrita de bloco";
			}
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 0;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 1;
				Comunicacao.Buffer_cmd[6] = 2;
				Comunicacao.Buffer_cmd[7] = (byte)(codigo / 256);
				Comunicacao.Buffer_cmd[8] = (byte)(codigo % 256);
				int num = 9;
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[9] = (byte)(num2 % 256);
				Comunicacao.Buffer_cmd[10] = (byte)(num2 / 256);
				Comunicacao.Ctrl_Com.Cont_tx = 11;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, msg);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		public static bool CMD_Esc_habilitacao_TCP(int codigo, int endereco, NetworkStream ns)
		{
			string msg;
			if (codigo == 21845)
			{
				msg = " Comando para habilitar escrita de bloco";
			}
			else
			{
				msg = " Comando para finalizar escrita de bloco";
			}
			Comunicacao.Init_buffer_serial();
			Comunicacao.Buffer_cmd[0] = 0;
			Comunicacao.Buffer_cmd[1] = 0;
			Comunicacao.Buffer_cmd[2] = 0;
			Comunicacao.Buffer_cmd[3] = 0;
			Comunicacao.Buffer_cmd[4] = 0;
			Comunicacao.Buffer_cmd[5] = 9;
			checked
			{
				Comunicacao.Buffer_cmd[6] = (byte)endereco;
				Comunicacao.Buffer_cmd[7] = 16;
				Comunicacao.Buffer_cmd[8] = 0;
				Comunicacao.Buffer_cmd[9] = 0;
				Comunicacao.Buffer_cmd[10] = 0;
				Comunicacao.Buffer_cmd[11] = 1;
				Comunicacao.Buffer_cmd[12] = 2;
				Comunicacao.Buffer_cmd[13] = (byte)(codigo / 256);
				Comunicacao.Buffer_cmd[14] = (byte)(codigo % 256);
				Comunicacao.Ctrl_Com.Cont_tx = 15;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, msg);
				ns.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		public static bool CMD_Tx_condax(int destino, int origem, int cmd, int tamanho, int[] dados)
		{
			string msg = " Comando : " + Comunicacao.Converte_Hexa(cmd);
			Comunicacao.Init_buffer_serial();
			Comunicacao.Buffer_cmd[0] = 2;
			checked
			{
				Comunicacao.Buffer_cmd[1] = (byte)(destino + 48);
				Comunicacao.Buffer_cmd[2] = (byte)(origem + 48);
				Comunicacao.Buffer_cmd[3] = (byte)cmd;
				if (tamanho != 0)
				{
					for (int i = 0; i <= tamanho; i++)
					{
						Comunicacao.Buffer_cmd[4 + i] = (byte)(dados[i] + 48);
					}
					Comunicacao.Buffer_cmd[4 + tamanho] = 3;
					Comunicacao.Ctrl_Com.Cont_tx = tamanho + 5;
				}
				else
				{
					Comunicacao.Buffer_cmd[4] = 3;
					Comunicacao.Ctrl_Com.Cont_tx = 5;
				}
				Comunicacao.Calcula_tx_chksum(Comunicacao.Ctrl_Com.Cont_tx);
				Comunicacao.Ctrl_Com.Cont_tx = Comunicacao.Ctrl_Com.Cont_tx + 1;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, msg);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		public static void Calcula_tx_chksum(int tamanho)
		{
			int num = 0;
			int num2 = 0;
			checked
			{
				int num3 = tamanho - 1;
				int i;
				for (i = num2; i <= num3; i++)
				{
					num += (int)Comunicacao.Buffer_cmd[i];
				}
				Comunicacao.Buffer_cmd[i] = (byte)(num % 256);
			}
		}

		public static bool Calcula_rx_chksum(int tamanho)
		{
			int num = 0;
			int num2 = 0;
			checked
			{
				int num3 = tamanho - 1;
				for (int i = num2; i <= num3; i++)
				{
					num += (int)Comunicacao.Buffer_resp[i];
				}
				num %= 256;
				return (int)Comunicacao.Buffer_resp[tamanho] == num;
			}
		}

		public static void Rotina_Delay(long tempo)
		{
			MyProject.Forms.Plataforma.Timer_espera.Interval = checked((int)tempo);
			MyProject.Forms.Plataforma.Timer_espera.Enabled = true;
			do
			{
				Application.DoEvents();
			}
			while (MyProject.Forms.Plataforma.Timer_espera.Enabled);
		}

		public static void Escreve_dados_buffer_ouvidor(int tipo, string msg)
		{
		}

		public static string Converte_Hexa(int valor)
		{
			string text = "";
			if (valor < 16)
			{
				text = text + " 0" + Strings.Format(valor, "X");
			}
			else
			{
				text = text + " " + Strings.Format(valor, "X");
			}
			return text;
		}

		public static bool CMD_Esc(object tipo)
		{
			string msg = "";
			Comunicacao.Init_buffer_serial();
			if (Operators.ConditionalCompareObjectEqual(tipo, 1, false))
			{
				Comunicacao.Buffer_cmd[0] = 65;
				Comunicacao.Buffer_cmd[1] = 84;
				Comunicacao.Buffer_cmd[2] = 43;
				Comunicacao.Buffer_cmd[3] = 43;
				Comunicacao.Buffer_cmd[4] = 43;
				Comunicacao.Buffer_cmd[5] = 13;
				Comunicacao.Ctrl_Com.Cont_tx = 6;
				Comunicacao.Ctrl_Com.Numero_bytes_rx = 4;
				msg = " Habilitando comandos AT ";
			}
			else if (Operators.ConditionalCompareObjectEqual(tipo, 2, false))
			{
				Comunicacao.Buffer_cmd[0] = 204;
				Comunicacao.Buffer_cmd[1] = 65;
				Comunicacao.Buffer_cmd[2] = 84;
				Comunicacao.Buffer_cmd[3] = 79;
				Comunicacao.Buffer_cmd[4] = 13;
				Comunicacao.Ctrl_Com.Cont_tx = 5;
				Comunicacao.Ctrl_Com.Numero_bytes_rx = 4;
				msg = " Desabilitando comandos AT ";
			}
			Comunicacao.Escreve_dados_buffer_ouvidor(2, msg);
			MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
			MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			return true;
		}

		public static bool CMD_Le_eeprom(int endereco, int tamanho)
		{
			string msg = " Comando leitura eeprom -> End: " + Conversions.ToString(endereco) + "  Bytes: " + Conversions.ToString(tamanho);
			Comunicacao.Init_buffer_serial();
			Comunicacao.Buffer_cmd[0] = 204;
			Comunicacao.Buffer_cmd[1] = 192;
			checked
			{
				Comunicacao.Buffer_cmd[2] = (byte)endereco;
				Comunicacao.Buffer_cmd[3] = (byte)tamanho;
				Comunicacao.Ctrl_Com.Cont_tx = 4;
				Comunicacao.Ctrl_Com.Numero_bytes_rx = tamanho + 3;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, msg);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		public const int MIN_END_EST = 0;
		public const int MAX_END_EST = 200;
		public const int MIN_END_MESTRE = 0;
		public const int MAX_END_MESTRE = 200;
		public const int MIN_INT_TX = 1;
		public const int MAX_INT_TX = 590;
		public const int MIN_PTT = 10;
		public const int MAX_PTT = 1000;
		public const int MIN_SENSOR_RANGE = 0;
		public const int MAX_SENSOR_RANGE = 5000;
		public const int MIN_SENSOR_OFFSET = -500;
		public const int MAX_SENSOR_OFFSET = 500;
		public const int MIN_RES_ALTURA = 0;
		public const int MAX_RES_ALTURA = 5000;
		public const int MIN_INT_FILTRO = 1;
		public const int MAX_INT_FILTRO = 1000;
		public const int MIN_TAM_FILTRO = 1;
		public const int MAX_TAM_FILTRO = 5;
		public const int MIN_END_EST_REP = 0;
		public const int MAX_END_EST_REP = 200;
		public const int MIN_NUM_EST_REP = 0;
		public const int MAX_NUM_EST_REP = 50;
		public const int MAX_BUFFER = 512;
		public const int TEMPO_TIME_OUT = 2000;
		public const int MAX_BUFFER_LOG = 20000;
		public const int NIVEL_MIN_PARTIDA = 0;
		public const int NIVEL_MAX_PARTIDA = 99;
		public const int NIVEL_MIN_PARADA = 1;
		public const int NIVEL_MAX_PARADA = 100;
		public const int TEMPO_MIN_PARTIDA = 0;
		public const int TEMPO_MAX_PARTIDA = 32000;
		public const int TEMPO_MIN_PARADA = 0;
		public const int TEMPO_MAX_PARADA = 32000;
		public const int TEMPO_MIN_ENTRE_ACIONAMENTOS = 0;
		public const int TEMPO_MAX_ENTRE_ACIONAMENTOS = 32000;
		public const int PROTOCOLO_MODBUS = 1;
		public const int PROTOCOLO_CONDAX = 2;
		public const int PROTOCOLO_AEROCOMM = 3;
		public const int PROTOCOLO_OUVIDOR = 4;
		public const int CONST_TIPO_INTERFACE_SERIAL = 1;
		public const int CONST_TIPO_INTERFACE_TCPIP = 2;
		public const int COR_OK = 0;
		public const int COR_ERRO = 1;
		public const int COR_ESPERA = 2;
		public const int FRAME_SEM = 255;
		public const int FRAME_OK = 0;
		public const int FRAME_ERRO = 1;
		public const int FRAME_ERRO_CHK = 2;
		public const int FRAME_ERRO_TIMEOUT = 3;
		public const int FRAME_AGUARDE = 10;
		public const int FRAME_NOT_CONNECTED = 20;
		public const int FRAME_TCP_MODBUS_NOT_RESPOND = 30;
		public const int FRAME_ERRO_ESCINICIO = 50;
		public const int FRAME_ERRO_ESCFIM = 51;
		public const int FRAME_ERRO_ESCP1 = 52;
		public const int FRAME_ERRO_ESCP2 = 53;
		public const int FUNCAO_SEM = 0;
		public const int FUNCAO_3 = 3;
		public const int FUNCAO_10 = 16;
		public const int OUVIDOR_AGUARDA_RX = 0;
		public const int OUVIDOR_CONTINUA_RX = 1;
		public const int OUVIDOR_OCORREU_TIMEOUT = 2;
		public const int PAGINA_H0 = 0;
		public const int PAGINA_RELEASESOFTWARE_RT820_360 = 0;
		public const int TAMANHO_PAGINA_RELEASESOFTWARE_RT820_360 = 4;
		public const int PAGINA_CFG_GERAL_PART1_RT820_360 = 2048;
		public const int TAMANHO_PAGINA_CFG_GERAL_PART1_RT820_360 = 115;
		public const int PAGINA_CFG_GERAL_PART2_RT820_360 = 2163;
		public const int TAMANHO_PAGINA_CFG_GERAL_PART2_RT820_360 = 116;
		public const int PAGINA_CFG_GERAL_PART3_RT820_360 = 2279;
		public const int TAMANHO_PAGINA_CFG_GERAL_PART3_RT820_360 = 12;
		public const int PAGINA_SETPOINT_HORARIO_PART1_RT820_360 = 22528;
		public const int TAMANHO_PAGINA_SETPOINT_HORARIO_PART1_RT820_360 = 120;
		public const int PAGINA_SETPOINT_HORARIO_PART2_RT820_360 = 22648;
		public const int TAMANHO_PAGINA_SETPOINT_HORARIO_PART2_RT820_360 = 120;
		public const int PAGINA_PERIFERICO_MODBUS_GENERICO_RT820_360 = 28672;
		public const int TAMANHO_PAGINA_PERIFERICO_MODBUS_GENERICO_RT820_360 = 50;
		public const int GT2010_STATUS_CAL_PEDIDO = 1;
		public const int GT2010_STATUS_CAL_PARTIDA = 2;
		public const int GT2010_STATUS_CAL_INICIO_EA = 3;
		public const int GT2010_STATUS_CAL_EA = 4;
		public const int GT2010_STATUS_CAL_INICIO_ED = 5;
		public const int GT2010_STATUS_CAL_ED = 6;
		public const int GT2010_STATUS_CAL_INICIO_SD = 7;
		public const int GT2010_STATUS_CAL_SD = 8;
		public const int GT2010_STATUS_CAL_INICIO_SA = 9;
		public const int GT2010_STATUS_CAL_SA = 10;
		public const int GT2010_STATUS_CAL_FIM = 11;
		public const int PAGINA_GT2010_INICIA_CALIBRACAO = 256;
		public const int PAGINA_GT2010_RESULT_CALIBRACAO = 512;
		public const int PAGINA_GT2010_STATUS_CALIBRACAO = 768;
		public const int TAMANHO_PAG_INICIA_CALIBRACAO = 1;
		public const int TAMANHO_PAG_STATUS_CALIBRACAO = 1;
		public const int TAMANHO_PAG_RESULT_CALIBRACAO = 80;
		public const int GT2010 = 2010;
		public const int PAGINA_GC82x_H000 = 0;
		public const int PAGINA_GC82x_H800 = 2048;
		public const int PAGINA_GC82x_H1800 = 6144;
		public const int PAGINA_GC82x_H5000 = 20480;
		public const int TAMANHO_PAG_H000_GC8x = 4;
		public const int TAMANHO_PAG_H800_GC8x = 22;
		public const int TAMANHO_PAG_H800_GC8x_END_EST = 1;
		public const int TAMANHO_PAG_H1800_GC8x = 8;
		public const int TAMANHO_PAG_H5300_GC8x = 3;
		public const int CONST_ZERO_SA = 0;
		public const int CONST_GANHO_SA = 1;
		public const string CONST_TIPO_CONTAGENS = "CONTAGEM";
		public const string CONST_TIPO_mA = "mA";
		public const int PAGINA_ID_IEC_855 = 0;
		public const int PAGINA_CFG_GERAL_IEC_855 = 512;
		public const int PAGINA_CFG_ETHERNET_IEC_855 = 1024;
		public const int PAGINA_TABELA_IP_PARTE1_IEC_855 = 1536;
		public const int PAGINA_TABELA_IP_PARTE2_IEC_855 = 2048;
		public const int PAGINA_TABELA_IP_PARTE3_IEC_855 = 2560;
		public const int PAGINA_TABELA_IP_PARTE4_IEC_855 = 3072;
		public const int TAMANHO_PAGINA_ID_IEC_855 = 7;
		public const int TAMANHO_PAGINA_CFG_GERAL_IEC_855 = 2;
		public const int TAMANHO_PAGINA_CFG_ETHERNET_IEC_855 = 12;
		public const int TAMANHO_PAGINA_TABELA_IP_IEC_855 = 100;
		public const int PAGINA_ID_IER_856 = 0;
		public const int PAGINA_CFG_GERAL_IER_856 = 512;
		public const int PAGINA_CFG_ETHERNET_IER_856 = 1024;
		public const int TAMANHO_PAGINA_ID_IER_856 = 7;
		public const int TAMANHO_PAGINA_CFG_GERAL_IER_856 = 2;
		public const int TAMANHO_PAGINA_CFG_ETHERNET_IER_856 = 12;
		public const int PAGINA_RT810_H800 = 2048;
		public const int PAGINA_RT810_H1000 = 4096;
		public const int PAGINA_RT810_H2000 = 8192;
		public const int PAGINA_RT810_H2800 = 10240;
		public const int TAMANHO_PAG_H0_RT810 = 12;
		public const int TAMANHO_PAG_H800_RT810 = 39;
		public const int TAMANHO_PAG_H1000_RT810 = 52;
		public const int TAMANHO_PAG_H2000_RT810 = 1;
		public const int TAMANHO_PAG_H2800_RT810 = 2;
		public const int TAMANHO_PAGINA_RT810_200 = 256;
		public const int PAGINA_FIRMWARE_RT_810_200 = 0;
		public const int PAGINA_CFG_GERAIS_RT_810_200 = 256;
		public const int PAGINA_REPETIDORA_RT_810_200 = 512;
		public const int TAMANHO_PAG_FIRMWARE_RT810_200 = 8;
		public const int TAMANHO_PAG_CFG_GERAIS_RT810_200 = 12;
		public const int TAMANHO_PAG_REPETIDORA_RT810_200 = 52;
		public const int PAGINA_RT820_H800_P1 = 2048;
		public const int PAGINA_RT820_H800_P2 = 2161;
		public const int PAGINA_RT_820_H800_Habilita_Expansao_IO = 2056;
		public const int PAGINA_RT_820_360_H800_Habilita_Expansao_IO = 2058;
		public const int PAGINA_RT820_H1000_P1 = 4096;
		public const int PAGINA_RT820_H2000_P1 = 8192;
		public const int PAGINA_RT820_H2800_P1 = 10240;
		public const int PAGINA_RT820_H3000_P1 = 12288;
		public const int PAGINA_RT820_H7800_P1 = 30720;
		public const int PAGINA_RT820_300_SETPOINT_HORARIO = 22528;
		public const int PAGINA_RT820_300_REFERENCIA_PERIFERICO = 24576;
		public const int PAGINA_RT820_300_ATUADORES_PERIFERICO_P1 = 26624;
		public const int PAGINA_RT820_300_ATUADORES_PERIFERICO_P2 = 26711;
		public const int PAGINA_RT820_300_ATUADORES_PERIFERICO_P3 = 26798;
		public const int PAGINA_RT820_300_ATUADORES_PERIFERICO_P4 = 26885;
		public const int TAMANHO_PAG_H0_RT820 = 4;
		public const int TAMANHO_PAG_H800_RT820_P1 = 113;
		public const int TAMANHO_PAG_H800_RT820_P2 = 94;
		public const int TAMANHO_PAG_H1000_RT820_P1 = 52;
		public const int TAMANHO_PAG_H2000_RT820_P1 = 16;
		public const int TAMANHO_PAG_H2800_RT820_P1 = 16;
		public const int TAMANHO_PAG_H3000_RT820_P1 = 16;
		public const int TAMANHO_PAG_H7800_RT820_P1 = 96;
		public const int TAMANHO_PAG_SETPOINT_HORARIO_RT820 = 48;
		public const int TAMANHO_PAG_REFERENCIA_PERIFERICO_RT820 = 60;
		public const int TAMANHO_PAG_ATUADORES_PERIFERICO_RT820 = 87;
		public const int PAGINA_FIRMWARE_RT = 0;
		public const int TAMANHO_PAGIGINA_FIRMWARE_RT = 4;
		public const int TAMANHO_PAGINA_RT820_200 = 256;
		public const int PAGINA_FIRMWARE_RT_820_200 = 0;
		public const int PAGINA_CFG_GERAIS_RT_820_200 = 256;
		public const int PAGINA_REPETIDORA_RT_820_200 = 512;
		public const int PAGINA_SETPOINT_HORARIO_RT_820_200 = 2816;
		public const int TAMANHO_PAG_FIRMWARE_RT820_200 = 4;
		public const int TAMANHO_PAG_CFG_GERAIS_RT820_200 = 58;
		public const int TAMANHO_PAG_REPETIDORA_RT820_200 = 52;
		public const int TAMANHO_PAG_SETPOINT_HORARIO_RT820_200 = 24;
		public const int PAGINA_RT821_H800_P1 = 2048;
		public const int PAGINA_RT821_H1000_P1 = 4096;
		public const int PAGINA_RT821_H2000_P1 = 8192;
		public const int PAGINA_RT821_H2800_P1 = 10240;
		public const int TAMANHO_PAG_H0_RT821 = 4;
		public const int TAMANHO_PAG_H800_RT821_P1 = 94;
		public const int TAMANHO_PAG_H1000_RT821_P1 = 52;
		public const int TAMANHO_PAG_H2000_RT821_P1 = 3;
		public const int TAMANHO_PAG_H2800_RT821_P1 = 6;
		public const int TAMANHO_PAGINA_RT821_200 = 256;
		public const int PAGINA_FIRMWARE_RT_821_200 = 0;
		public const int PAGINA_CFG_GERAIS_RT_821_200 = 256;
		public const int PAGINA_REPETIDORA_RT_821_200 = 512;
		public const int TAMANHO_PAG_FIRMWARE_RT821_200 = 4;
		public const int TAMANHO_PAG_CFG_GERAIS_RT821_200 = 30;
		public const int TAMANHO_PAG_REPETIDORA_RT821_200 = 52;
		public const int PAGINA_RT850_H800_P1 = 2048;
		public const int PAGINA_RT850_H1000_P1 = 4096;
		public const int PAGINA_RT850_H1800_P1 = 6144;
		public const int PAGINA_RT850_H3000_P1 = 12288;
		public const int PAGINA_RT850_H3000_P2 = 12388;
		public const int PAGINA_RT850_H5800_P1 = 22528;
		public const int PAGINA_RT850_H6000_P1 = 24576;
		public const int PAGINA_RT850_H6800_P1 = 26624;
		public const int PAGINA_RT850_H7000_P1 = 28672;
		public const int TAMANHO_PAG_H0_RT850 = 4;
		public const int TAMANHO_PAG_H800_RT850_P1 = 60;
		public const int TAMANHO_PAG_H1000_RT850_P1 = 110;
		public const int NUMERO_BLOCOS_PAG_H1000_RT850_P1 = 15;
		public const int TAMANHO_PAG_H1800_RT850_P1 = 110;
		public const int NUMERO_BLOCOS_PAG_H1800_RT850_P1 = 15;
		public const int TAMANHO_PAG_H3000_RT850 = 100;
		public const int TAMANHO_PAG_H5800_RT850_P1 = 120;
		public const int NUMERO_BLOCOS_PAG_H5800_RT850_P1 = 10;
		public const int TAMANHO_PAG_H6000_RT850_P1 = 115;
		public const int NUMERO_BLOCOS_PAG_H6000_RT850_P1 = 10;
		public const int TAMANHO_PAG_H6800_RT850_P1 = 78;
		public const int NUMERO_BLOCOS_PAG_H6800_RT850_P1 = 10;
		public const int TAMANHO_PAG_H7000_RT850_P1 = 57;
		public const int NUMERO_BLOCOS_PAG_H7000_RT850_P1 = 5;
		public const int PAGINA_0 = 0;
		public const int PAGINA_1 = 100;
		public const int PAGINA_2 = 512;
		public const int PAGINA_2A = 512;
		public const int PAGINA_2B = 592;
		public const int PAGINA_3 = 768;
		public const int PAGINA_3A = 768;
		public const int PAGINA_3B = 888;
		public const int PAGINA_4 = 1024;
		public const int PAGINA_4A = 1024;
		public const int PAGINA_4B = 1144;
		public const int PAGINA_5 = 1280;
		public const int PAGINA_5A = 1280;
		public const int PAGINA_5B = 1400;
		public const int PAGINA_6 = 1536;
		public const int PAGINA_6A = 1536;
		public const int PAGINA_6B = 1656;
		public const int PAGINA_7 = 1792;
		public const int PAGINA_7A = 1792;
		public const int PAGINA_7B = 1878;
		public const int PAGINA_7C = 1964;
		public const int PAGINA_3B_303 = 844;
		public const int PAGINA_4B_303 = 1100;
		public const int PAGINA_5B_303 = 1356;
		public const int PAGINA_6B_303 = 1612;
		public const int PAGINA_9 = 1424;
		public const int CODIGO_INICIO = 21845;
		public const int CODIGO_FIM = 21930;
		public const int CODIGO_INICIO2 = 21840;
		public const int CODIGO_FIM2 = 21920;
		public const int EQUIP_INDIVIDUAL = 1;
		public const int TAMANHO_PAG_1_MD101 = 12;
		public const int TAMANHO_PAG_2_MD101 = 52;
		public const int TAMANHO_PAG_3_MD101 = 8;
		public const int TAMANHO_PAG_4_MD101 = 9;
		public const int TAMANHO_PAG_5_MD101 = 2;
		public const int TAMANHO_PAG_1_MD201 = 21;
		public const int TAMANHO_PAG_2_MD201 = 52;
		public const int TAMANHO_PAG_1_MD202 = 52;
		public const int TAMANHO_PAG_1_MD202_820 = 56;
		public const int TAMANHO_PAG_2_MD202 = 52;
		public const int TAMANHO_PAG_3_MD202 = 32;
		public const int TAMANHO_PAG_4_MD202 = 33;
		public const int TAMANHO_PAG_5_MD202 = 39;
		public const int TAMANHO_PAG_1_MD302 = 14;
		public const int TAMANHO_PAG_2A_MD302 = 80;
		public const int TAMANHO_PAG_2B_MD302 = 80;
		public const int TAMANHO_PAG_3A_MD302 = 120;
		public const int TAMANHO_PAG_3B_MD302 = 90;
		public const int TAMANHO_PAG_4A_MD302 = 120;
		public const int TAMANHO_PAG_4B_MD302 = 90;
		public const int TAMANHO_PAG_5A_MD302 = 120;
		public const int TAMANHO_PAG_5B_MD302 = 90;
		public const int TAMANHO_PAG_6A_MD302 = 120;
		public const int TAMANHO_PAG_6B_MD302 = 90;
		public const int TAMANHO_PAG_7A_MD302 = 86;
		public const int TAMANHO_PAG_7B_MD302 = 86;
		public const int TAMANHO_PAG_7C_MD302 = 43;
		public const int TAMANHO_PAG_9_MD302 = 1;
		public const int TAMANHO_PAG_9_MD303 = 1;
		public const int TAMANHO_PAG_1_MD303 = 6;
		public const int TAMANHO_PAG_2_MD303 = 40;
		public const int TAMANHO_PAG_3A_MD303 = 76;
		public const int TAMANHO_PAG_3B_MD303 = 57;
		public const int TAMANHO_PAG_4A_MD303 = 76;
		public const int TAMANHO_PAG_4B_MD303 = 57;
		public const int TAMANHO_PAG_5A_MD303 = 76;
		public const int TAMANHO_PAG_5B_MD303 = 57;
		public const int TAMANHO_PAG_6A_MD303 = 76;
		public const int TAMANHO_PAG_6B_MD303 = 57;
		public const int PAGINA_1_MD303 = 256;
		public const int PAGINA_2_MD303 = 512;
		public const int PAGINA_3A_MD303 = 768;
		public const int PAGINA_3B_MD303 = 844;
		public const int PAGINA_4A_MD303 = 1024;
		public const int PAGINA_4B_MD303 = 1100;
		public const int PAGINA_5A_MD303 = 1280;
		public const int PAGINA_5B_MD303 = 1356;
		public const int PAGINA_6A_MD303 = 1536;
		public const int PAGINA_6B_MD303 = 1612;
		public const int PAGINA_9_MD303 = 2304;
		public const int ENDERECO_GERAL = 255;
		public const int MODBUS_ERROR_INDICATION = 128;
		public const int FRAME_RX_OUVIDOR = 1;
		public const int FRAME_TX_OUVIDOR = 2;
		public const int SOH = 1;
		public const int STX = 2;
		public const int ETX = 3;
		public const int ACK = 6;
		public const int NAC = 15;
		public const int FUNCAO_CHK = 100;
		public const int FUNCAO_SOH = 1;
		public const int CMD_CONF_GERAL = 100;
		public const int CMD_CONF_IO = 100;
		public const int CMD_CONF_HAB_CONF = 104;
		public const int CMD_CONF_TERMINA_CONF = 103;
		public const int CMD_CONF_ESC_CONF_GERAL = 96;
		public const int CMD_CONF_ESC_CONF_IO = 105;
		public const int CMD_LE_RESERVATORIO = 49;
		public const int CMD_LE_RECALQUE = 50;
		public const int CMD_LE_SETPOINT = 51;
		public const int CMD_LE_TIMER = 53;
		public const int CMD_LE_PONTA = 54;
		public const int CMD_LE_ALARMES = 55;
		public const int CMD_LE_TEMP = 56;
		public const int CMD_LE_ESC_RECALQUE = 57;
		public const int CMD_LE_RELOGIO = 85;
		public const int CMD_OPE_LIGA_BOMBA = 67;
		public const int CMD_OPE_DESL_BOMBA = 68;
		public const int CMD_OPE_MAN_BOMBA = 69;
		public const int CMD_OPE_AUTO_BOMBA = 70;
		public const int CMD_OPE_FALHA_BOMBA = 71;
		public const int CMD_ESC_SETPOINT = 66;
		public const int CMD_ESC_ALARMES = 76;
		public const int CMD_ESC_PONTA = 75;
		public const int CMD_ESC_RELOGIO = 84;
		public const int CMD_ESC_SA = 86;
		public const int CMD_ESC_TIMER = 74;
		public const int CMD_ESC_TEMP = 77;
		public const int CONST_HAB_AT = 1;
		public const int CONST_DESA_AT = 2;
		public const int IDENTIFICA_INICIO_590 = 1;
		public const int RECEBE_DADOS_590 = 2;
		public static Comunicacao.CONFIGURACAO_GERAL Config_sistema;
		public static Comunicacao.CTLR_COMUNICACAO Ctrl_Com;
		public static Comunicacao.CTRL_LOGCOMUNICACAO Ctrl_Log;
		public static byte[] Buffer_cmd = new byte[513];
		public static byte[] Buffer_resp = new byte[513];
		public static byte[] Buffer_Log = new byte[20001];
		public static string[] linhas = new string[51];
		public static int ctrl_linha;

		public struct CONFIGURACAO_SERIAL
		{
			public string Porta_serial;
			public int Baudrate;
			public int DataBits;
			public int Parity;
			public int StopBits;
			public bool PortaSerialAtiva;
		}

		public struct CONFIGURACAO_TCPIP
		{
			public string IP;
			public int Porta;
		}

		public struct CONFIGURACAO_WIFI
		{
			public string IP;
			public int Porta;
			public string SSID;
			public string PassWord;
		}

		public struct CONFIGURACAO_GERAL
		{
			public int tipo_interface;
			public Comunicacao.CONFIGURACAO_SERIAL Serial;
			public Comunicacao.CONFIGURACAO_TCPIP Tcpip;
			public Comunicacao.CONFIGURACAO_WIFI Wifi;
			public string Dir_dados;
			public string Retry;
			public int endereco_modbus;
			public bool endereco_encontrado;
		}

		public struct CTLR_COMUNICACAO
		{
			public int Cont_rx;
			public int Cont_tx;
			public int Tipo_funcao;
			public int Num_bytes;
			public int Frame;
			public int Tipo_protocolo;
			public int Numero_bytes_rx;
		}

		public struct CTRL_LOGCOMUNICACAO
		{
			public bool flag;
			public string diretorio;
			public string arquivo;
			public int bytes_recv;
			public DateTime inicio;
			public int timeouts;
		}
	}
}