using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using iS800.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x0200000A RID: 10
	[StandardModule]
	internal sealed class Comunicacao
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00221478 File Offset: 0x0021F878
		public static bool Init_porta_serial()
		{
			int num;
			bool flag;
			int num2;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
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
					flag = true;
					goto IL_2E4;
				}
				if (Comunicacao.Config_sistema.tipo_interface == 2)
				{
					goto IL_2E4;
				}
				goto IL_2E4;
				IL_275:
				string text = "Erro na escolha da porta de comunicação serial";
				MsgBoxStyle msgBoxStyle = 272;
				string text2 = "Atenção - verifique configuração";
				Interaction.MsgBox(text, msgBoxStyle, text2);
				Geral.Config_geral.Porta_serial_Ok = false;
				flag = false;
				goto IL_2E4;
				IL_29F:
				num2 = -1;
								IL_2B5:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num2 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_29F;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2E4:
			bool result = flag;
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00221790 File Offset: 0x0021FB90
		public static bool Init_buffer_serial()
		{
			checked
			{
				int num;
				bool flag;
				int num3;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					if (Comunicacao.Config_sistema.tipo_interface == 1)
					{
						MyProject.Forms.Plataforma.SerialPort1.DiscardOutBuffer();
						MyProject.Forms.Plataforma.SerialPort1.DiscardInBuffer();
					}
					int num2 = 0;
					do
					{
						Comunicacao.Buffer_resp[num2] = 0;
						Comunicacao.Buffer_cmd[num2] = 0;
						num2++;
					}
					while (num2 <= 512);
					Comunicacao.Ctrl_Com.Tipo_funcao = 0;
					Comunicacao.Ctrl_Com.Cont_rx = 0;
					Comunicacao.Ctrl_Com.Frame = 255;
					flag = true;
					goto IL_DA;
					IL_83:
					Interaction.MsgBox("Erro na localização da porta serial!", 32, "Atenção - Porta Serial");
					flag = false;
					goto IL_DA;
					IL_99:
					num3 = -1;
										IL_AD:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num3 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_99;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_DA:
				bool result = flag;
				if (num3 != 0)
				{
					ProjectData.ClearProjectError();
				}
				return result;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00221890 File Offset: 0x0021FC90
		public static bool VerificaPortaSerialExiste()
		{
			bool isOpen = MyProject.Forms.Plataforma.SerialPort1.IsOpen;
			Geral.Config_geral.Porta_serial_Ok = isOpen;
			return isOpen;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x002218C0 File Offset: 0x0021FCC0
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

		// Token: 0x06000080 RID: 128 RVA: 0x00221928 File Offset: 0x0021FD28
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
			return (((-((((int)Comunicacao.Buffer_resp[Num_dados] == (num & 255)) > false) ? 1 : 0)) ? 1 : 0) & (((-((((int)Comunicacao.Buffer_resp[checked(Num_dados + 1)] == num / 256) > false) ? 1 : 0)) ? 1 : 0) & 255)) != 0;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x002219D0 File Offset: 0x0021FDD0
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

		// Token: 0x06000082 RID: 130 RVA: 0x00221AC8 File Offset: 0x0021FEC8
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

		// Token: 0x06000083 RID: 131 RVA: 0x00221BC0 File Offset: 0x0021FFC0
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

		// Token: 0x06000084 RID: 132 RVA: 0x00221CBC File Offset: 0x002200BC
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

		// Token: 0x06000085 RID: 133 RVA: 0x00221DB8 File Offset: 0x002201B8
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

		// Token: 0x06000086 RID: 134 RVA: 0x00221EBC File Offset: 0x002202BC
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

		// Token: 0x06000087 RID: 135 RVA: 0x00221EF4 File Offset: 0x002202F4
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

		// Token: 0x06000088 RID: 136 RVA: 0x00221F38 File Offset: 0x00220338
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

		// Token: 0x06000089 RID: 137 RVA: 0x00221F8C File Offset: 0x0022038C
		public static void Escreve_dados_buffer_ouvidor(int tipo, string msg)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00221F90 File Offset: 0x00220390
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

		// Token: 0x0600008B RID: 139 RVA: 0x00221FE8 File Offset: 0x002203E8
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

		// Token: 0x0600008C RID: 140 RVA: 0x00222104 File Offset: 0x00220504
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

		// Token: 0x04000037 RID: 55
		public const int MIN_END_EST = 0;

		// Token: 0x04000038 RID: 56
		public const int MAX_END_EST = 200;

		// Token: 0x04000039 RID: 57
		public const int MIN_END_MESTRE = 0;

		// Token: 0x0400003A RID: 58
		public const int MAX_END_MESTRE = 200;

		// Token: 0x0400003B RID: 59
		public const int MIN_INT_TX = 1;

		// Token: 0x0400003C RID: 60
		public const int MAX_INT_TX = 590;

		// Token: 0x0400003D RID: 61
		public const int MIN_PTT = 10;

		// Token: 0x0400003E RID: 62
		public const int MAX_PTT = 1000;

		// Token: 0x0400003F RID: 63
		public const int MIN_SENSOR_RANGE = 0;

		// Token: 0x04000040 RID: 64
		public const int MAX_SENSOR_RANGE = 5000;

		// Token: 0x04000041 RID: 65
		public const int MIN_SENSOR_OFFSET = -500;

		// Token: 0x04000042 RID: 66
		public const int MAX_SENSOR_OFFSET = 500;

		// Token: 0x04000043 RID: 67
		public const int MIN_RES_ALTURA = 0;

		// Token: 0x04000044 RID: 68
		public const int MAX_RES_ALTURA = 5000;

		// Token: 0x04000045 RID: 69
		public const int MIN_INT_FILTRO = 1;

		// Token: 0x04000046 RID: 70
		public const int MAX_INT_FILTRO = 1000;

		// Token: 0x04000047 RID: 71
		public const int MIN_TAM_FILTRO = 1;

		// Token: 0x04000048 RID: 72
		public const int MAX_TAM_FILTRO = 5;

		// Token: 0x04000049 RID: 73
		public const int MIN_END_EST_REP = 0;

		// Token: 0x0400004A RID: 74
		public const int MAX_END_EST_REP = 200;

		// Token: 0x0400004B RID: 75
		public const int MIN_NUM_EST_REP = 0;

		// Token: 0x0400004C RID: 76
		public const int MAX_NUM_EST_REP = 50;

		// Token: 0x0400004D RID: 77
		public const int MAX_BUFFER = 512;

		// Token: 0x0400004E RID: 78
		public const int TEMPO_TIME_OUT = 2000;

		// Token: 0x0400004F RID: 79
		public const int MAX_BUFFER_LOG = 20000;

		// Token: 0x04000050 RID: 80
		public const int NIVEL_MIN_PARTIDA = 0;

		// Token: 0x04000051 RID: 81
		public const int NIVEL_MAX_PARTIDA = 99;

		// Token: 0x04000052 RID: 82
		public const int NIVEL_MIN_PARADA = 1;

		// Token: 0x04000053 RID: 83
		public const int NIVEL_MAX_PARADA = 100;

		// Token: 0x04000054 RID: 84
		public const int TEMPO_MIN_PARTIDA = 0;

		// Token: 0x04000055 RID: 85
		public const int TEMPO_MAX_PARTIDA = 32000;

		// Token: 0x04000056 RID: 86
		public const int TEMPO_MIN_PARADA = 0;

		// Token: 0x04000057 RID: 87
		public const int TEMPO_MAX_PARADA = 32000;

		// Token: 0x04000058 RID: 88
		public const int TEMPO_MIN_ENTRE_ACIONAMENTOS = 0;

		// Token: 0x04000059 RID: 89
		public const int TEMPO_MAX_ENTRE_ACIONAMENTOS = 32000;

		// Token: 0x0400005A RID: 90
		public const int PROTOCOLO_MODBUS = 1;

		// Token: 0x0400005B RID: 91
		public const int PROTOCOLO_CONDAX = 2;

		// Token: 0x0400005C RID: 92
		public const int PROTOCOLO_AEROCOMM = 3;

		// Token: 0x0400005D RID: 93
		public const int PROTOCOLO_OUVIDOR = 4;

		// Token: 0x0400005E RID: 94
		public const int CONST_TIPO_INTERFACE_SERIAL = 1;

		// Token: 0x0400005F RID: 95
		public const int CONST_TIPO_INTERFACE_TCPIP = 2;

		// Token: 0x04000060 RID: 96
		public const int COR_OK = 0;

		// Token: 0x04000061 RID: 97
		public const int COR_ERRO = 1;

		// Token: 0x04000062 RID: 98
		public const int COR_ESPERA = 2;

		// Token: 0x04000063 RID: 99
		public const int FRAME_SEM = 255;

		// Token: 0x04000064 RID: 100
		public const int FRAME_OK = 0;

		// Token: 0x04000065 RID: 101
		public const int FRAME_ERRO = 1;

		// Token: 0x04000066 RID: 102
		public const int FRAME_ERRO_CHK = 2;

		// Token: 0x04000067 RID: 103
		public const int FRAME_ERRO_TIMEOUT = 3;

		// Token: 0x04000068 RID: 104
		public const int FRAME_AGUARDE = 10;

		// Token: 0x04000069 RID: 105
		public const int FRAME_NOT_CONNECTED = 20;

		// Token: 0x0400006A RID: 106
		public const int FRAME_TCP_MODBUS_NOT_RESPOND = 30;

		// Token: 0x0400006B RID: 107
		public const int FRAME_ERRO_ESCINICIO = 50;

		// Token: 0x0400006C RID: 108
		public const int FRAME_ERRO_ESCFIM = 51;

		// Token: 0x0400006D RID: 109
		public const int FRAME_ERRO_ESCP1 = 52;

		// Token: 0x0400006E RID: 110
		public const int FRAME_ERRO_ESCP2 = 53;

		// Token: 0x0400006F RID: 111
		public const int FUNCAO_SEM = 0;

		// Token: 0x04000070 RID: 112
		public const int FUNCAO_3 = 3;

		// Token: 0x04000071 RID: 113
		public const int FUNCAO_10 = 16;

		// Token: 0x04000072 RID: 114
		public const int OUVIDOR_AGUARDA_RX = 0;

		// Token: 0x04000073 RID: 115
		public const int OUVIDOR_CONTINUA_RX = 1;

		// Token: 0x04000074 RID: 116
		public const int OUVIDOR_OCORREU_TIMEOUT = 2;

		// Token: 0x04000075 RID: 117
		public const int PAGINA_H0 = 0;

		// Token: 0x04000076 RID: 118
		public const int PAGINA_RELEASESOFTWARE_RT820_360 = 0;

		// Token: 0x04000077 RID: 119
		public const int TAMANHO_PAGINA_RELEASESOFTWARE_RT820_360 = 4;

		// Token: 0x04000078 RID: 120
		public const int PAGINA_CFG_GERAL_PART1_RT820_360 = 2048;

		// Token: 0x04000079 RID: 121
		public const int TAMANHO_PAGINA_CFG_GERAL_PART1_RT820_360 = 115;

		// Token: 0x0400007A RID: 122
		public const int PAGINA_CFG_GERAL_PART2_RT820_360 = 2163;

		// Token: 0x0400007B RID: 123
		public const int TAMANHO_PAGINA_CFG_GERAL_PART2_RT820_360 = 116;

		// Token: 0x0400007C RID: 124
		public const int PAGINA_CFG_GERAL_PART3_RT820_360 = 2279;

		// Token: 0x0400007D RID: 125
		public const int TAMANHO_PAGINA_CFG_GERAL_PART3_RT820_360 = 12;

		// Token: 0x0400007E RID: 126
		public const int PAGINA_SETPOINT_HORARIO_PART1_RT820_360 = 22528;

		// Token: 0x0400007F RID: 127
		public const int TAMANHO_PAGINA_SETPOINT_HORARIO_PART1_RT820_360 = 120;

		// Token: 0x04000080 RID: 128
		public const int PAGINA_SETPOINT_HORARIO_PART2_RT820_360 = 22648;

		// Token: 0x04000081 RID: 129
		public const int TAMANHO_PAGINA_SETPOINT_HORARIO_PART2_RT820_360 = 120;

		// Token: 0x04000082 RID: 130
		public const int PAGINA_PERIFERICO_MODBUS_GENERICO_RT820_360 = 28672;

		// Token: 0x04000083 RID: 131
		public const int TAMANHO_PAGINA_PERIFERICO_MODBUS_GENERICO_RT820_360 = 50;

		// Token: 0x04000084 RID: 132
		public const int GT2010_STATUS_CAL_PEDIDO = 1;

		// Token: 0x04000085 RID: 133
		public const int GT2010_STATUS_CAL_PARTIDA = 2;

		// Token: 0x04000086 RID: 134
		public const int GT2010_STATUS_CAL_INICIO_EA = 3;

		// Token: 0x04000087 RID: 135
		public const int GT2010_STATUS_CAL_EA = 4;

		// Token: 0x04000088 RID: 136
		public const int GT2010_STATUS_CAL_INICIO_ED = 5;

		// Token: 0x04000089 RID: 137
		public const int GT2010_STATUS_CAL_ED = 6;

		// Token: 0x0400008A RID: 138
		public const int GT2010_STATUS_CAL_INICIO_SD = 7;

		// Token: 0x0400008B RID: 139
		public const int GT2010_STATUS_CAL_SD = 8;

		// Token: 0x0400008C RID: 140
		public const int GT2010_STATUS_CAL_INICIO_SA = 9;

		// Token: 0x0400008D RID: 141
		public const int GT2010_STATUS_CAL_SA = 10;

		// Token: 0x0400008E RID: 142
		public const int GT2010_STATUS_CAL_FIM = 11;

		// Token: 0x0400008F RID: 143
		public const int PAGINA_GT2010_INICIA_CALIBRACAO = 256;

		// Token: 0x04000090 RID: 144
		public const int PAGINA_GT2010_RESULT_CALIBRACAO = 512;

		// Token: 0x04000091 RID: 145
		public const int PAGINA_GT2010_STATUS_CALIBRACAO = 768;

		// Token: 0x04000092 RID: 146
		public const int TAMANHO_PAG_INICIA_CALIBRACAO = 1;

		// Token: 0x04000093 RID: 147
		public const int TAMANHO_PAG_STATUS_CALIBRACAO = 1;

		// Token: 0x04000094 RID: 148
		public const int TAMANHO_PAG_RESULT_CALIBRACAO = 80;

		// Token: 0x04000095 RID: 149
		public const int GT2010 = 2010;

		// Token: 0x04000096 RID: 150
		public const int PAGINA_GC82x_H000 = 0;

		// Token: 0x04000097 RID: 151
		public const int PAGINA_GC82x_H800 = 2048;

		// Token: 0x04000098 RID: 152
		public const int PAGINA_GC82x_H1800 = 6144;

		// Token: 0x04000099 RID: 153
		public const int PAGINA_GC82x_H5000 = 20480;

		// Token: 0x0400009A RID: 154
		public const int TAMANHO_PAG_H000_GC8x = 4;

		// Token: 0x0400009B RID: 155
		public const int TAMANHO_PAG_H800_GC8x = 22;

		// Token: 0x0400009C RID: 156
		public const int TAMANHO_PAG_H800_GC8x_END_EST = 1;

		// Token: 0x0400009D RID: 157
		public const int TAMANHO_PAG_H1800_GC8x = 8;

		// Token: 0x0400009E RID: 158
		public const int TAMANHO_PAG_H5300_GC8x = 3;

		// Token: 0x0400009F RID: 159
		public const int CONST_ZERO_SA = 0;

		// Token: 0x040000A0 RID: 160
		public const int CONST_GANHO_SA = 1;

		// Token: 0x040000A1 RID: 161
		public const string CONST_TIPO_CONTAGENS = "CONTAGEM";

		// Token: 0x040000A2 RID: 162
		public const string CONST_TIPO_mA = "mA";

		// Token: 0x040000A3 RID: 163
		public const int PAGINA_ID_IEC_855 = 0;

		// Token: 0x040000A4 RID: 164
		public const int PAGINA_CFG_GERAL_IEC_855 = 512;

		// Token: 0x040000A5 RID: 165
		public const int PAGINA_CFG_ETHERNET_IEC_855 = 1024;

		// Token: 0x040000A6 RID: 166
		public const int PAGINA_TABELA_IP_PARTE1_IEC_855 = 1536;

		// Token: 0x040000A7 RID: 167
		public const int PAGINA_TABELA_IP_PARTE2_IEC_855 = 2048;

		// Token: 0x040000A8 RID: 168
		public const int PAGINA_TABELA_IP_PARTE3_IEC_855 = 2560;

		// Token: 0x040000A9 RID: 169
		public const int PAGINA_TABELA_IP_PARTE4_IEC_855 = 3072;

		// Token: 0x040000AA RID: 170
		public const int TAMANHO_PAGINA_ID_IEC_855 = 7;

		// Token: 0x040000AB RID: 171
		public const int TAMANHO_PAGINA_CFG_GERAL_IEC_855 = 2;

		// Token: 0x040000AC RID: 172
		public const int TAMANHO_PAGINA_CFG_ETHERNET_IEC_855 = 12;

		// Token: 0x040000AD RID: 173
		public const int TAMANHO_PAGINA_TABELA_IP_IEC_855 = 100;

		// Token: 0x040000AE RID: 174
		public const int PAGINA_ID_IER_856 = 0;

		// Token: 0x040000AF RID: 175
		public const int PAGINA_CFG_GERAL_IER_856 = 512;

		// Token: 0x040000B0 RID: 176
		public const int PAGINA_CFG_ETHERNET_IER_856 = 1024;

		// Token: 0x040000B1 RID: 177
		public const int TAMANHO_PAGINA_ID_IER_856 = 7;

		// Token: 0x040000B2 RID: 178
		public const int TAMANHO_PAGINA_CFG_GERAL_IER_856 = 2;

		// Token: 0x040000B3 RID: 179
		public const int TAMANHO_PAGINA_CFG_ETHERNET_IER_856 = 12;

		// Token: 0x040000B4 RID: 180
		public const int PAGINA_RT810_H800 = 2048;

		// Token: 0x040000B5 RID: 181
		public const int PAGINA_RT810_H1000 = 4096;

		// Token: 0x040000B6 RID: 182
		public const int PAGINA_RT810_H2000 = 8192;

		// Token: 0x040000B7 RID: 183
		public const int PAGINA_RT810_H2800 = 10240;

		// Token: 0x040000B8 RID: 184
		public const int TAMANHO_PAG_H0_RT810 = 12;

		// Token: 0x040000B9 RID: 185
		public const int TAMANHO_PAG_H800_RT810 = 39;

		// Token: 0x040000BA RID: 186
		public const int TAMANHO_PAG_H1000_RT810 = 52;

		// Token: 0x040000BB RID: 187
		public const int TAMANHO_PAG_H2000_RT810 = 1;

		// Token: 0x040000BC RID: 188
		public const int TAMANHO_PAG_H2800_RT810 = 2;

		// Token: 0x040000BD RID: 189
		public const int TAMANHO_PAGINA_RT810_200 = 256;

		// Token: 0x040000BE RID: 190
		public const int PAGINA_FIRMWARE_RT_810_200 = 0;

		// Token: 0x040000BF RID: 191
		public const int PAGINA_CFG_GERAIS_RT_810_200 = 256;

		// Token: 0x040000C0 RID: 192
		public const int PAGINA_REPETIDORA_RT_810_200 = 512;

		// Token: 0x040000C1 RID: 193
		public const int TAMANHO_PAG_FIRMWARE_RT810_200 = 8;

		// Token: 0x040000C2 RID: 194
		public const int TAMANHO_PAG_CFG_GERAIS_RT810_200 = 12;

		// Token: 0x040000C3 RID: 195
		public const int TAMANHO_PAG_REPETIDORA_RT810_200 = 52;

		// Token: 0x040000C4 RID: 196
		public const int PAGINA_RT820_H800_P1 = 2048;

		// Token: 0x040000C5 RID: 197
		public const int PAGINA_RT820_H800_P2 = 2161;

		// Token: 0x040000C6 RID: 198
		public const int PAGINA_RT_820_H800_Habilita_Expansao_IO = 2056;

		// Token: 0x040000C7 RID: 199
		public const int PAGINA_RT_820_360_H800_Habilita_Expansao_IO = 2058;

		// Token: 0x040000C8 RID: 200
		public const int PAGINA_RT820_H1000_P1 = 4096;

		// Token: 0x040000C9 RID: 201
		public const int PAGINA_RT820_H2000_P1 = 8192;

		// Token: 0x040000CA RID: 202
		public const int PAGINA_RT820_H2800_P1 = 10240;

		// Token: 0x040000CB RID: 203
		public const int PAGINA_RT820_H3000_P1 = 12288;

		// Token: 0x040000CC RID: 204
		public const int PAGINA_RT820_H7800_P1 = 30720;

		// Token: 0x040000CD RID: 205
		public const int PAGINA_RT820_300_SETPOINT_HORARIO = 22528;

		// Token: 0x040000CE RID: 206
		public const int PAGINA_RT820_300_REFERENCIA_PERIFERICO = 24576;

		// Token: 0x040000CF RID: 207
		public const int PAGINA_RT820_300_ATUADORES_PERIFERICO_P1 = 26624;

		// Token: 0x040000D0 RID: 208
		public const int PAGINA_RT820_300_ATUADORES_PERIFERICO_P2 = 26711;

		// Token: 0x040000D1 RID: 209
		public const int PAGINA_RT820_300_ATUADORES_PERIFERICO_P3 = 26798;

		// Token: 0x040000D2 RID: 210
		public const int PAGINA_RT820_300_ATUADORES_PERIFERICO_P4 = 26885;

		// Token: 0x040000D3 RID: 211
		public const int TAMANHO_PAG_H0_RT820 = 4;

		// Token: 0x040000D4 RID: 212
		public const int TAMANHO_PAG_H800_RT820_P1 = 113;

		// Token: 0x040000D5 RID: 213
		public const int TAMANHO_PAG_H800_RT820_P2 = 94;

		// Token: 0x040000D6 RID: 214
		public const int TAMANHO_PAG_H1000_RT820_P1 = 52;

		// Token: 0x040000D7 RID: 215
		public const int TAMANHO_PAG_H2000_RT820_P1 = 16;

		// Token: 0x040000D8 RID: 216
		public const int TAMANHO_PAG_H2800_RT820_P1 = 16;

		// Token: 0x040000D9 RID: 217
		public const int TAMANHO_PAG_H3000_RT820_P1 = 16;

		// Token: 0x040000DA RID: 218
		public const int TAMANHO_PAG_H7800_RT820_P1 = 96;

		// Token: 0x040000DB RID: 219
		public const int TAMANHO_PAG_SETPOINT_HORARIO_RT820 = 48;

		// Token: 0x040000DC RID: 220
		public const int TAMANHO_PAG_REFERENCIA_PERIFERICO_RT820 = 60;

		// Token: 0x040000DD RID: 221
		public const int TAMANHO_PAG_ATUADORES_PERIFERICO_RT820 = 87;

		// Token: 0x040000DE RID: 222
		public const int PAGINA_FIRMWARE_RT = 0;

		// Token: 0x040000DF RID: 223
		public const int TAMANHO_PAGIGINA_FIRMWARE_RT = 4;

		// Token: 0x040000E0 RID: 224
		public const int TAMANHO_PAGINA_RT820_200 = 256;

		// Token: 0x040000E1 RID: 225
		public const int PAGINA_FIRMWARE_RT_820_200 = 0;

		// Token: 0x040000E2 RID: 226
		public const int PAGINA_CFG_GERAIS_RT_820_200 = 256;

		// Token: 0x040000E3 RID: 227
		public const int PAGINA_REPETIDORA_RT_820_200 = 512;

		// Token: 0x040000E4 RID: 228
		public const int PAGINA_SETPOINT_HORARIO_RT_820_200 = 2816;

		// Token: 0x040000E5 RID: 229
		public const int TAMANHO_PAG_FIRMWARE_RT820_200 = 4;

		// Token: 0x040000E6 RID: 230
		public const int TAMANHO_PAG_CFG_GERAIS_RT820_200 = 58;

		// Token: 0x040000E7 RID: 231
		public const int TAMANHO_PAG_REPETIDORA_RT820_200 = 52;

		// Token: 0x040000E8 RID: 232
		public const int TAMANHO_PAG_SETPOINT_HORARIO_RT820_200 = 24;

		// Token: 0x040000E9 RID: 233
		public const int PAGINA_RT821_H800_P1 = 2048;

		// Token: 0x040000EA RID: 234
		public const int PAGINA_RT821_H1000_P1 = 4096;

		// Token: 0x040000EB RID: 235
		public const int PAGINA_RT821_H2000_P1 = 8192;

		// Token: 0x040000EC RID: 236
		public const int PAGINA_RT821_H2800_P1 = 10240;

		// Token: 0x040000ED RID: 237
		public const int TAMANHO_PAG_H0_RT821 = 4;

		// Token: 0x040000EE RID: 238
		public const int TAMANHO_PAG_H800_RT821_P1 = 94;

		// Token: 0x040000EF RID: 239
		public const int TAMANHO_PAG_H1000_RT821_P1 = 52;

		// Token: 0x040000F0 RID: 240
		public const int TAMANHO_PAG_H2000_RT821_P1 = 3;

		// Token: 0x040000F1 RID: 241
		public const int TAMANHO_PAG_H2800_RT821_P1 = 6;

		// Token: 0x040000F2 RID: 242
		public const int TAMANHO_PAGINA_RT821_200 = 256;

		// Token: 0x040000F3 RID: 243
		public const int PAGINA_FIRMWARE_RT_821_200 = 0;

		// Token: 0x040000F4 RID: 244
		public const int PAGINA_CFG_GERAIS_RT_821_200 = 256;

		// Token: 0x040000F5 RID: 245
		public const int PAGINA_REPETIDORA_RT_821_200 = 512;

		// Token: 0x040000F6 RID: 246
		public const int TAMANHO_PAG_FIRMWARE_RT821_200 = 4;

		// Token: 0x040000F7 RID: 247
		public const int TAMANHO_PAG_CFG_GERAIS_RT821_200 = 30;

		// Token: 0x040000F8 RID: 248
		public const int TAMANHO_PAG_REPETIDORA_RT821_200 = 52;

		// Token: 0x040000F9 RID: 249
		public const int PAGINA_RT850_H800_P1 = 2048;

		// Token: 0x040000FA RID: 250
		public const int PAGINA_RT850_H1000_P1 = 4096;

		// Token: 0x040000FB RID: 251
		public const int PAGINA_RT850_H1800_P1 = 6144;

		// Token: 0x040000FC RID: 252
		public const int PAGINA_RT850_H3000_P1 = 12288;

		// Token: 0x040000FD RID: 253
		public const int PAGINA_RT850_H3000_P2 = 12388;

		// Token: 0x040000FE RID: 254
		public const int PAGINA_RT850_H5800_P1 = 22528;

		// Token: 0x040000FF RID: 255
		public const int PAGINA_RT850_H6000_P1 = 24576;

		// Token: 0x04000100 RID: 256
		public const int PAGINA_RT850_H6800_P1 = 26624;

		// Token: 0x04000101 RID: 257
		public const int PAGINA_RT850_H7000_P1 = 28672;

		// Token: 0x04000102 RID: 258
		public const int TAMANHO_PAG_H0_RT850 = 4;

		// Token: 0x04000103 RID: 259
		public const int TAMANHO_PAG_H800_RT850_P1 = 60;

		// Token: 0x04000104 RID: 260
		public const int TAMANHO_PAG_H1000_RT850_P1 = 110;

		// Token: 0x04000105 RID: 261
		public const int NUMERO_BLOCOS_PAG_H1000_RT850_P1 = 15;

		// Token: 0x04000106 RID: 262
		public const int TAMANHO_PAG_H1800_RT850_P1 = 110;

		// Token: 0x04000107 RID: 263
		public const int NUMERO_BLOCOS_PAG_H1800_RT850_P1 = 15;

		// Token: 0x04000108 RID: 264
		public const int TAMANHO_PAG_H3000_RT850 = 100;

		// Token: 0x04000109 RID: 265
		public const int TAMANHO_PAG_H5800_RT850_P1 = 120;

		// Token: 0x0400010A RID: 266
		public const int NUMERO_BLOCOS_PAG_H5800_RT850_P1 = 10;

		// Token: 0x0400010B RID: 267
		public const int TAMANHO_PAG_H6000_RT850_P1 = 115;

		// Token: 0x0400010C RID: 268
		public const int NUMERO_BLOCOS_PAG_H6000_RT850_P1 = 10;

		// Token: 0x0400010D RID: 269
		public const int TAMANHO_PAG_H6800_RT850_P1 = 78;

		// Token: 0x0400010E RID: 270
		public const int NUMERO_BLOCOS_PAG_H6800_RT850_P1 = 10;

		// Token: 0x0400010F RID: 271
		public const int TAMANHO_PAG_H7000_RT850_P1 = 57;

		// Token: 0x04000110 RID: 272
		public const int NUMERO_BLOCOS_PAG_H7000_RT850_P1 = 5;

		// Token: 0x04000111 RID: 273
		public const int PAGINA_0 = 0;

		// Token: 0x04000112 RID: 274
		public const int PAGINA_1 = 100;

		// Token: 0x04000113 RID: 275
		public const int PAGINA_2 = 512;

		// Token: 0x04000114 RID: 276
		public const int PAGINA_2A = 512;

		// Token: 0x04000115 RID: 277
		public const int PAGINA_2B = 592;

		// Token: 0x04000116 RID: 278
		public const int PAGINA_3 = 768;

		// Token: 0x04000117 RID: 279
		public const int PAGINA_3A = 768;

		// Token: 0x04000118 RID: 280
		public const int PAGINA_3B = 888;

		// Token: 0x04000119 RID: 281
		public const int PAGINA_4 = 1024;

		// Token: 0x0400011A RID: 282
		public const int PAGINA_4A = 1024;

		// Token: 0x0400011B RID: 283
		public const int PAGINA_4B = 1144;

		// Token: 0x0400011C RID: 284
		public const int PAGINA_5 = 1280;

		// Token: 0x0400011D RID: 285
		public const int PAGINA_5A = 1280;

		// Token: 0x0400011E RID: 286
		public const int PAGINA_5B = 1400;

		// Token: 0x0400011F RID: 287
		public const int PAGINA_6 = 1536;

		// Token: 0x04000120 RID: 288
		public const int PAGINA_6A = 1536;

		// Token: 0x04000121 RID: 289
		public const int PAGINA_6B = 1656;

		// Token: 0x04000122 RID: 290
		public const int PAGINA_7 = 1792;

		// Token: 0x04000123 RID: 291
		public const int PAGINA_7A = 1792;

		// Token: 0x04000124 RID: 292
		public const int PAGINA_7B = 1878;

		// Token: 0x04000125 RID: 293
		public const int PAGINA_7C = 1964;

		// Token: 0x04000126 RID: 294
		public const int PAGINA_3B_303 = 844;

		// Token: 0x04000127 RID: 295
		public const int PAGINA_4B_303 = 1100;

		// Token: 0x04000128 RID: 296
		public const int PAGINA_5B_303 = 1356;

		// Token: 0x04000129 RID: 297
		public const int PAGINA_6B_303 = 1612;

		// Token: 0x0400012A RID: 298
		public const int PAGINA_9 = 1424;

		// Token: 0x0400012B RID: 299
		public const int CODIGO_INICIO = 21845;

		// Token: 0x0400012C RID: 300
		public const int CODIGO_FIM = 21930;

		// Token: 0x0400012D RID: 301
		public const int CODIGO_INICIO2 = 21840;

		// Token: 0x0400012E RID: 302
		public const int CODIGO_FIM2 = 21920;

		// Token: 0x0400012F RID: 303
		public const int EQUIP_INDIVIDUAL = 1;

		// Token: 0x04000130 RID: 304
		public const int TAMANHO_PAG_1_MD101 = 12;

		// Token: 0x04000131 RID: 305
		public const int TAMANHO_PAG_2_MD101 = 52;

		// Token: 0x04000132 RID: 306
		public const int TAMANHO_PAG_3_MD101 = 8;

		// Token: 0x04000133 RID: 307
		public const int TAMANHO_PAG_4_MD101 = 9;

		// Token: 0x04000134 RID: 308
		public const int TAMANHO_PAG_5_MD101 = 2;

		// Token: 0x04000135 RID: 309
		public const int TAMANHO_PAG_1_MD201 = 21;

		// Token: 0x04000136 RID: 310
		public const int TAMANHO_PAG_2_MD201 = 52;

		// Token: 0x04000137 RID: 311
		public const int TAMANHO_PAG_1_MD202 = 52;

		// Token: 0x04000138 RID: 312
		public const int TAMANHO_PAG_1_MD202_820 = 56;

		// Token: 0x04000139 RID: 313
		public const int TAMANHO_PAG_2_MD202 = 52;

		// Token: 0x0400013A RID: 314
		public const int TAMANHO_PAG_3_MD202 = 32;

		// Token: 0x0400013B RID: 315
		public const int TAMANHO_PAG_4_MD202 = 33;

		// Token: 0x0400013C RID: 316
		public const int TAMANHO_PAG_5_MD202 = 39;

		// Token: 0x0400013D RID: 317
		public const int TAMANHO_PAG_1_MD302 = 14;

		// Token: 0x0400013E RID: 318
		public const int TAMANHO_PAG_2A_MD302 = 80;

		// Token: 0x0400013F RID: 319
		public const int TAMANHO_PAG_2B_MD302 = 80;

		// Token: 0x04000140 RID: 320
		public const int TAMANHO_PAG_3A_MD302 = 120;

		// Token: 0x04000141 RID: 321
		public const int TAMANHO_PAG_3B_MD302 = 90;

		// Token: 0x04000142 RID: 322
		public const int TAMANHO_PAG_4A_MD302 = 120;

		// Token: 0x04000143 RID: 323
		public const int TAMANHO_PAG_4B_MD302 = 90;

		// Token: 0x04000144 RID: 324
		public const int TAMANHO_PAG_5A_MD302 = 120;

		// Token: 0x04000145 RID: 325
		public const int TAMANHO_PAG_5B_MD302 = 90;

		// Token: 0x04000146 RID: 326
		public const int TAMANHO_PAG_6A_MD302 = 120;

		// Token: 0x04000147 RID: 327
		public const int TAMANHO_PAG_6B_MD302 = 90;

		// Token: 0x04000148 RID: 328
		public const int TAMANHO_PAG_7A_MD302 = 86;

		// Token: 0x04000149 RID: 329
		public const int TAMANHO_PAG_7B_MD302 = 86;

		// Token: 0x0400014A RID: 330
		public const int TAMANHO_PAG_7C_MD302 = 43;

		// Token: 0x0400014B RID: 331
		public const int TAMANHO_PAG_9_MD302 = 1;

		// Token: 0x0400014C RID: 332
		public const int TAMANHO_PAG_9_MD303 = 1;

		// Token: 0x0400014D RID: 333
		public const int TAMANHO_PAG_1_MD303 = 6;

		// Token: 0x0400014E RID: 334
		public const int TAMANHO_PAG_2_MD303 = 40;

		// Token: 0x0400014F RID: 335
		public const int TAMANHO_PAG_3A_MD303 = 76;

		// Token: 0x04000150 RID: 336
		public const int TAMANHO_PAG_3B_MD303 = 57;

		// Token: 0x04000151 RID: 337
		public const int TAMANHO_PAG_4A_MD303 = 76;

		// Token: 0x04000152 RID: 338
		public const int TAMANHO_PAG_4B_MD303 = 57;

		// Token: 0x04000153 RID: 339
		public const int TAMANHO_PAG_5A_MD303 = 76;

		// Token: 0x04000154 RID: 340
		public const int TAMANHO_PAG_5B_MD303 = 57;

		// Token: 0x04000155 RID: 341
		public const int TAMANHO_PAG_6A_MD303 = 76;

		// Token: 0x04000156 RID: 342
		public const int TAMANHO_PAG_6B_MD303 = 57;

		// Token: 0x04000157 RID: 343
		public const int PAGINA_1_MD303 = 256;

		// Token: 0x04000158 RID: 344
		public const int PAGINA_2_MD303 = 512;

		// Token: 0x04000159 RID: 345
		public const int PAGINA_3A_MD303 = 768;

		// Token: 0x0400015A RID: 346
		public const int PAGINA_3B_MD303 = 844;

		// Token: 0x0400015B RID: 347
		public const int PAGINA_4A_MD303 = 1024;

		// Token: 0x0400015C RID: 348
		public const int PAGINA_4B_MD303 = 1100;

		// Token: 0x0400015D RID: 349
		public const int PAGINA_5A_MD303 = 1280;

		// Token: 0x0400015E RID: 350
		public const int PAGINA_5B_MD303 = 1356;

		// Token: 0x0400015F RID: 351
		public const int PAGINA_6A_MD303 = 1536;

		// Token: 0x04000160 RID: 352
		public const int PAGINA_6B_MD303 = 1612;

		// Token: 0x04000161 RID: 353
		public const int PAGINA_9_MD303 = 2304;

		// Token: 0x04000162 RID: 354
		public const int ENDERECO_GERAL = 255;

		// Token: 0x04000163 RID: 355
		public const int MODBUS_ERROR_INDICATION = 128;

		// Token: 0x04000164 RID: 356
		public const int FRAME_RX_OUVIDOR = 1;

		// Token: 0x04000165 RID: 357
		public const int FRAME_TX_OUVIDOR = 2;

		// Token: 0x04000166 RID: 358
		public const int SOH = 1;

		// Token: 0x04000167 RID: 359
		public const int STX = 2;

		// Token: 0x04000168 RID: 360
		public const int ETX = 3;

		// Token: 0x04000169 RID: 361
		public const int ACK = 6;

		// Token: 0x0400016A RID: 362
		public const int NAC = 15;

		// Token: 0x0400016B RID: 363
		public const int FUNCAO_CHK = 100;

		// Token: 0x0400016C RID: 364
		public const int FUNCAO_SOH = 1;

		// Token: 0x0400016D RID: 365
		public const int CMD_CONF_GERAL = 100;

		// Token: 0x0400016E RID: 366
		public const int CMD_CONF_IO = 100;

		// Token: 0x0400016F RID: 367
		public const int CMD_CONF_HAB_CONF = 104;

		// Token: 0x04000170 RID: 368
		public const int CMD_CONF_TERMINA_CONF = 103;

		// Token: 0x04000171 RID: 369
		public const int CMD_CONF_ESC_CONF_GERAL = 96;

		// Token: 0x04000172 RID: 370
		public const int CMD_CONF_ESC_CONF_IO = 105;

		// Token: 0x04000173 RID: 371
		public const int CMD_LE_RESERVATORIO = 49;

		// Token: 0x04000174 RID: 372
		public const int CMD_LE_RECALQUE = 50;

		// Token: 0x04000175 RID: 373
		public const int CMD_LE_SETPOINT = 51;

		// Token: 0x04000176 RID: 374
		public const int CMD_LE_TIMER = 53;

		// Token: 0x04000177 RID: 375
		public const int CMD_LE_PONTA = 54;

		// Token: 0x04000178 RID: 376
		public const int CMD_LE_ALARMES = 55;

		// Token: 0x04000179 RID: 377
		public const int CMD_LE_TEMP = 56;

		// Token: 0x0400017A RID: 378
		public const int CMD_LE_ESC_RECALQUE = 57;

		// Token: 0x0400017B RID: 379
		public const int CMD_LE_RELOGIO = 85;

		// Token: 0x0400017C RID: 380
		public const int CMD_OPE_LIGA_BOMBA = 67;

		// Token: 0x0400017D RID: 381
		public const int CMD_OPE_DESL_BOMBA = 68;

		// Token: 0x0400017E RID: 382
		public const int CMD_OPE_MAN_BOMBA = 69;

		// Token: 0x0400017F RID: 383
		public const int CMD_OPE_AUTO_BOMBA = 70;

		// Token: 0x04000180 RID: 384
		public const int CMD_OPE_FALHA_BOMBA = 71;

		// Token: 0x04000181 RID: 385
		public const int CMD_ESC_SETPOINT = 66;

		// Token: 0x04000182 RID: 386
		public const int CMD_ESC_ALARMES = 76;

		// Token: 0x04000183 RID: 387
		public const int CMD_ESC_PONTA = 75;

		// Token: 0x04000184 RID: 388
		public const int CMD_ESC_RELOGIO = 84;

		// Token: 0x04000185 RID: 389
		public const int CMD_ESC_SA = 86;

		// Token: 0x04000186 RID: 390
		public const int CMD_ESC_TIMER = 74;

		// Token: 0x04000187 RID: 391
		public const int CMD_ESC_TEMP = 77;

		// Token: 0x04000188 RID: 392
		public const int CONST_HAB_AT = 1;

		// Token: 0x04000189 RID: 393
		public const int CONST_DESA_AT = 2;

		// Token: 0x0400018A RID: 394
		public const int IDENTIFICA_INICIO_590 = 1;

		// Token: 0x0400018B RID: 395
		public const int RECEBE_DADOS_590 = 2;

		// Token: 0x0400018C RID: 396
		public static Comunicacao.CONFIGURACAO_GERAL Config_sistema;

		// Token: 0x0400018D RID: 397
		public static Comunicacao.CTLR_COMUNICACAO Ctrl_Com;

		// Token: 0x0400018E RID: 398
		public static Comunicacao.CTRL_LOGCOMUNICACAO Ctrl_Log;

		// Token: 0x0400018F RID: 399
		public static byte[] Buffer_cmd = new byte[513];

		// Token: 0x04000190 RID: 400
		public static byte[] Buffer_resp = new byte[513];

		// Token: 0x04000191 RID: 401
		public static byte[] Buffer_Log = new byte[20001];

		// Token: 0x04000192 RID: 402
		public static string[] linhas = new string[51];

		// Token: 0x04000193 RID: 403
		public static int ctrl_linha;

		// Token: 0x0200000B RID: 11
		public struct CONFIGURACAO_SERIAL
		{
			// Token: 0x04000194 RID: 404
			public string Porta_serial;

			// Token: 0x04000195 RID: 405
			public int Baudrate;

			// Token: 0x04000196 RID: 406
			public int DataBits;

			// Token: 0x04000197 RID: 407
			public int Parity;

			// Token: 0x04000198 RID: 408
			public int StopBits;

			// Token: 0x04000199 RID: 409
			public bool PortaSerialAtiva;
		}

		// Token: 0x0200000C RID: 12
		public struct CONFIGURACAO_TCPIP
		{
			// Token: 0x0400019A RID: 410
			public string IP;

			// Token: 0x0400019B RID: 411
			public int Porta;
		}

		// Token: 0x0200000D RID: 13
		public struct CONFIGURACAO_WIFI
		{
			// Token: 0x0400019C RID: 412
			public string IP;

			// Token: 0x0400019D RID: 413
			public int Porta;

			// Token: 0x0400019E RID: 414
			public string SSID;

			// Token: 0x0400019F RID: 415
			public string PassWord;
		}

		// Token: 0x0200000E RID: 14
		public struct CONFIGURACAO_GERAL
		{
			// Token: 0x040001A0 RID: 416
			public int tipo_interface;

			// Token: 0x040001A1 RID: 417
			public Comunicacao.CONFIGURACAO_SERIAL Serial;

			// Token: 0x040001A2 RID: 418
			public Comunicacao.CONFIGURACAO_TCPIP Tcpip;

			// Token: 0x040001A3 RID: 419
			public Comunicacao.CONFIGURACAO_WIFI Wifi;

			// Token: 0x040001A4 RID: 420
			public string Dir_dados;

			// Token: 0x040001A5 RID: 421
			public string Retry;

			// Token: 0x040001A6 RID: 422
			public int endereco_modbus;

			// Token: 0x040001A7 RID: 423
			public bool endereco_encontrado;
		}

		// Token: 0x0200000F RID: 15
		public struct CTLR_COMUNICACAO
		{
			// Token: 0x040001A8 RID: 424
			public int Cont_rx;

			// Token: 0x040001A9 RID: 425
			public int Cont_tx;

			// Token: 0x040001AA RID: 426
			public int Tipo_funcao;

			// Token: 0x040001AB RID: 427
			public int Num_bytes;

			// Token: 0x040001AC RID: 428
			public int Frame;

			// Token: 0x040001AD RID: 429
			public int Tipo_protocolo;

			// Token: 0x040001AE RID: 430
			public int Numero_bytes_rx;
		}

		// Token: 0x02000010 RID: 16
		public struct CTRL_LOGCOMUNICACAO
		{
			// Token: 0x040001AF RID: 431
			public bool flag;

			// Token: 0x040001B0 RID: 432
			public string diretorio;

			// Token: 0x040001B1 RID: 433
			public string arquivo;

			// Token: 0x040001B2 RID: 434
			public int bytes_recv;

			// Token: 0x040001B3 RID: 435
			public DateTime inicio;

			// Token: 0x040001B4 RID: 436
			public int timeouts;
		}
	}
}
