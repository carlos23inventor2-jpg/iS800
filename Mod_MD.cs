using System;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using iS800.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x0200008A RID: 138
	[StandardModule]
	internal sealed class Mod_MD
	{
		// Token: 0x060023E6 RID: 9190 RVA: 0x00254650 File Offset: 0x00252A50
		// Note: this type is marked as 'beforefieldinit'.
		static Mod_MD()
		{
			checked
			{
				Mod_MD.Reservatorio = new Mod_MD.DADOS_EQUIP_MD_101_CONFIG[Mod_MD.NUM_MAX_RE + 1];
				Mod_MD.Recalque_201 = new Mod_MD.DADOS_EQUIP_MD_201_CONFIG[Mod_MD.NUM_MAX_RQ + 1];
				Mod_MD.Recalque_202 = new Mod_MD.DADOS_EQUIP_MD_202_CONFIG[Mod_MD.NUM_MAX_RQ + 1];
				Mod_MD.Central_302_res = new Mod_MD.DADOS_EQUIP_MD_302_CONFIG_RES[Mod_MD.NUM_MAX_RE + 1];
				Mod_MD.Central_302_rq = new Mod_MD.DADOS_EQUIP_MD_302_CONFIG_RQ[Mod_MD.NUM_MAX_RQ + 1];
				Mod_MD.Central_302_centrais = new Mod_MD.DADOS_EQUIP_MD_302_CONFIG_CENTRAIS[Mod_MD.NUM_MAX_VISTA + 1];
				Mod_MD.Central_302_indices = new int[6, 151];
				Mod_MD.Central_303_res = new Mod_MD.DADOS_EQUIP_MD_303_CONFIG_RES[Mod_MD.NUM_MAX_RE + 1];
				Mod_MD.Central_303_rq = new Mod_MD.DADOS_EQUIP_MD_303_CONFIG_RQ[Mod_MD.NUM_MAX_RQ + 1];
				Mod_MD.Tabela_302 = new int[6, 81];
				Mod_MD.Tabela_590 = new int[257];
			}
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x00254738 File Offset: 0x00252B38
		public static void Init_equipamento_MD101()
		{
			Mod_MD.Controle.Estacao = 1;
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x00254748 File Offset: 0x00252B48
		public static void Init_equipamento_MD201()
		{
			Mod_MD.Controle.Estacao = 1;
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x00254758 File Offset: 0x00252B58
		public static bool CMD_Esc_MD101_pagina_1(int endereco, int indice)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 1;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 12;
				Comunicacao.Buffer_cmd[6] = 24;
				Comunicacao.Buffer_cmd[7] = 0;
				Comunicacao.Buffer_cmd[8] = (byte)Mod_MD.Reservatorio[indice].End_estacao;
				Comunicacao.Buffer_cmd[9] = 0;
				Comunicacao.Buffer_cmd[10] = (byte)Mod_MD.Reservatorio[indice].End_mestre;
				Comunicacao.Buffer_cmd[11] = (byte)(Mod_MD.Reservatorio[indice].Hab_repetidora / 256);
				Comunicacao.Buffer_cmd[12] = (byte)(Mod_MD.Reservatorio[indice].Hab_repetidora % 256);
				Comunicacao.Buffer_cmd[13] = (byte)(Mod_MD.Reservatorio[indice].Tempo_tx_ponto / 256);
				Comunicacao.Buffer_cmd[14] = (byte)(Mod_MD.Reservatorio[indice].Tempo_tx_ponto % 256);
				Comunicacao.Buffer_cmd[15] = (byte)(Mod_MD.Reservatorio[indice].Tempo_ptt / 256);
				Comunicacao.Buffer_cmd[16] = (byte)(Mod_MD.Reservatorio[indice].Tempo_ptt % 256);
				Comunicacao.Buffer_cmd[17] = (byte)(Mod_MD.Reservatorio[indice].Tipo_medida / 256);
				Comunicacao.Buffer_cmd[18] = (byte)(Mod_MD.Reservatorio[indice].Tipo_medida % 256);
				Comunicacao.Buffer_cmd[19] = (byte)(Mod_MD.Reservatorio[indice].Modo_operacao / 256);
				Comunicacao.Buffer_cmd[20] = (byte)(Mod_MD.Reservatorio[indice].Modo_operacao % 256);
				Comunicacao.Buffer_cmd[21] = (byte)(Mod_MD.Reservatorio[indice].Range_sensor / 256);
				Comunicacao.Buffer_cmd[22] = (byte)(Mod_MD.Reservatorio[indice].Range_sensor % 256);
				Comunicacao.Buffer_cmd[23] = (byte)(Mod_MD.Reservatorio[indice].Altura_sensor / 256);
				Comunicacao.Buffer_cmd[24] = (byte)(Mod_MD.Reservatorio[indice].Altura_sensor % 256);
				Comunicacao.Buffer_cmd[25] = (byte)(Mod_MD.Reservatorio[indice].Offset_sensor / 256);
				Comunicacao.Buffer_cmd[26] = (byte)(Mod_MD.Reservatorio[indice].Offset_sensor % 256);
				Comunicacao.Buffer_cmd[27] = (byte)(Mod_MD.Reservatorio[indice].Intervalo_filtro / 256);
				Comunicacao.Buffer_cmd[28] = (byte)(Mod_MD.Reservatorio[indice].Intervalo_filtro % 256);
				Comunicacao.Buffer_cmd[29] = (byte)(Mod_MD.Reservatorio[indice].Tamanho_filtro / 256);
				Comunicacao.Buffer_cmd[30] = (byte)(Mod_MD.Reservatorio[indice].Tamanho_filtro % 256);
				int num = 31;
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[31] = (byte)(num2 % 256);
				Comunicacao.Buffer_cmd[32] = (byte)(num2 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, 33);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x00254AB4 File Offset: 0x00252EB4
		public static bool CMD_Esc_MD101_pagina_2(int endereco, int indice)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 2;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 52;
				Comunicacao.Buffer_cmd[6] = 104;
				Comunicacao.Buffer_cmd[7] = 0;
				Comunicacao.Buffer_cmd[8] = (byte)Mod_MD.Reservatorio[indice].End_repetidora;
				Comunicacao.Buffer_cmd[9] = 0;
				Comunicacao.Buffer_cmd[10] = (byte)Mod_MD.Reservatorio[indice].Num_repetidoras;
				int num = 1;
				do
				{
					Comunicacao.Buffer_cmd[9 + num * 2] = (byte)(Mod_MD.Reservatorio[indice].Repetidoras[num] / 256);
					Comunicacao.Buffer_cmd[10 + num * 2] = (byte)(Mod_MD.Reservatorio[indice].Repetidoras[num] % 256);
					num++;
				}
				while (num <= 50);
				int num2 = 111;
				int num3 = Comunicacao.Crc16_TX(ref num2);
				Comunicacao.Buffer_cmd[111] = (byte)(num3 % 256);
				Comunicacao.Buffer_cmd[112] = (byte)(num3 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, 114);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x00254BFC File Offset: 0x00252FFC
		public static void Atualiza_dados_MD101(int indice, int pag)
		{
			checked
			{
				if (pag == 100)
				{
					Mod_MD.Reservatorio[indice].End_estacao = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					Mod_MD.Reservatorio[indice].End_mestre = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					Mod_MD.Reservatorio[indice].Hab_repetidora = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					Mod_MD.Reservatorio[indice].Tempo_tx_ponto = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
					Mod_MD.Reservatorio[indice].Tempo_ptt = (int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12];
					Mod_MD.Reservatorio[indice].Tipo_medida = (int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14];
					Mod_MD.Reservatorio[indice].Modo_operacao = (int)Comunicacao.Buffer_resp[15] * 256 + (int)Comunicacao.Buffer_resp[16];
					Mod_MD.Reservatorio[indice].Range_sensor = (int)Comunicacao.Buffer_resp[17] * 256 + (int)Comunicacao.Buffer_resp[18];
					Mod_MD.Reservatorio[indice].Altura_sensor = (int)Comunicacao.Buffer_resp[19] * 256 + (int)Comunicacao.Buffer_resp[20];
					Mod_MD.Reservatorio[indice].Offset_sensor = (int)Comunicacao.Buffer_resp[21] * 256 + (int)Comunicacao.Buffer_resp[22];
					Mod_MD.Reservatorio[indice].Intervalo_filtro = (int)Comunicacao.Buffer_resp[23] * 256 + (int)Comunicacao.Buffer_resp[24];
					Mod_MD.Reservatorio[indice].Tamanho_filtro = (int)Comunicacao.Buffer_resp[25] * 256 + (int)Comunicacao.Buffer_resp[26];
				}
				else if (pag == 512)
				{
					Mod_MD.Reservatorio[indice].End_repetidora = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					Mod_MD.Reservatorio[indice].Num_repetidoras = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					int num = 1;
					do
					{
						Mod_MD.Reservatorio[indice].Repetidoras[num] = (int)Comunicacao.Buffer_resp[5 + num * 2] * 256 + (int)Comunicacao.Buffer_resp[6 + num * 2];
						num++;
					}
					while (num <= 50);
				}
			}
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x00254E78 File Offset: 0x00253278
		public static void Atualiza_dados_MD201(int indice, int pag)
		{
			checked
			{
				if (pag == 100)
				{
					string versao = Geral.Config_geral.Versao;
					if (Operators.CompareString(versao, "21", false) == 0)
					{
						Mod_MD.Recalque_201[indice].End_estacao = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
						Mod_MD.Recalque_201[indice].End_mestre = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
						Mod_MD.Recalque_201[indice].Hab_repetidora = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
						Mod_MD.Recalque_201[indice].Tempo_ptt = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
						Mod_MD.Recalque_201[indice].Quantidade_motores = (int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12];
						Mod_MD.Recalque_201[indice].Modo_partida[1] = (int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14];
						Mod_MD.Recalque_201[indice].Modo_partida[2] = (int)Comunicacao.Buffer_resp[15] * 256 + (int)Comunicacao.Buffer_resp[16];
						Mod_MD.Recalque_201[indice].Modo_partida[3] = (int)Comunicacao.Buffer_resp[17] * 256 + (int)Comunicacao.Buffer_resp[18];
						Mod_MD.Recalque_201[indice].Nivel_acionamento[1] = (int)Math.Round((double)((int)Comunicacao.Buffer_resp[19] * 256 + (int)Comunicacao.Buffer_resp[20]) / 2.0);
						Mod_MD.Recalque_201[indice].Nivel_acionamento[2] = (int)Math.Round((double)((int)Comunicacao.Buffer_resp[21] * 256 + (int)Comunicacao.Buffer_resp[22]) / 2.0);
						Mod_MD.Recalque_201[indice].Nivel_acionamento[3] = (int)Math.Round((double)((int)Comunicacao.Buffer_resp[23] * 256 + (int)Comunicacao.Buffer_resp[24]) / 2.0);
						Mod_MD.Recalque_201[indice].Nivel_parada[1] = (int)Math.Round((double)((int)Comunicacao.Buffer_resp[25] * 256 + (int)Comunicacao.Buffer_resp[26]) / 2.0);
						Mod_MD.Recalque_201[indice].Nivel_parada[2] = (int)Math.Round((double)((int)Comunicacao.Buffer_resp[27] * 256 + (int)Comunicacao.Buffer_resp[28]) / 2.0);
						Mod_MD.Recalque_201[indice].Nivel_parada[3] = (int)Math.Round((double)((int)Comunicacao.Buffer_resp[29] * 256 + (int)Comunicacao.Buffer_resp[30]) / 2.0);
						Mod_MD.Recalque_201[indice].Tempo_partida[1] = (int)Comunicacao.Buffer_resp[31] * 256 + (int)Comunicacao.Buffer_resp[32];
						Mod_MD.Recalque_201[indice].Tempo_partida[2] = (int)Comunicacao.Buffer_resp[33] * 256 + (int)Comunicacao.Buffer_resp[34];
						Mod_MD.Recalque_201[indice].Tempo_partida[3] = (int)Comunicacao.Buffer_resp[35] * 256 + (int)Comunicacao.Buffer_resp[36];
						Mod_MD.Recalque_201[indice].Tempo_parada[1] = (int)Comunicacao.Buffer_resp[37] * 256 + (int)Comunicacao.Buffer_resp[38];
						Mod_MD.Recalque_201[indice].Tempo_parada[2] = (int)Comunicacao.Buffer_resp[39] * 256 + (int)Comunicacao.Buffer_resp[40];
						Mod_MD.Recalque_201[indice].Tempo_parada[3] = (int)Comunicacao.Buffer_resp[41] * 256 + (int)Comunicacao.Buffer_resp[42];
						Mod_MD.Recalque_201[indice].Tempo_entre_acionamento = (int)Comunicacao.Buffer_resp[43] * 256 + (int)Comunicacao.Buffer_resp[44];
					}
					else if (Operators.CompareString(versao, "821_10", false) == 0)
					{
						Mod_MD.Recalque_201[indice].End_estacao = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
						Mod_MD.Recalque_201[indice].End_mestre = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
						Mod_MD.Recalque_201[indice].Hab_repetidora = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
						Mod_MD.Recalque_201[indice].Tempo_ptt = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
						Mod_MD.Recalque_201[indice].Quantidade_motores = (int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12];
						Mod_MD.Recalque_201[indice].Modo_partida[1] = (int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14];
						Mod_MD.Recalque_201[indice].Modo_partida[2] = (int)Comunicacao.Buffer_resp[15] * 256 + (int)Comunicacao.Buffer_resp[16];
						Mod_MD.Recalque_201[indice].Modo_partida[3] = (int)Comunicacao.Buffer_resp[17] * 256 + (int)Comunicacao.Buffer_resp[18];
						Mod_MD.Recalque_201[indice].Nivel_acionamento[1] = (int)Comunicacao.Buffer_resp[19] * 256 + (int)Comunicacao.Buffer_resp[20];
						Mod_MD.Recalque_201[indice].Nivel_acionamento[2] = (int)Comunicacao.Buffer_resp[21] * 256 + (int)Comunicacao.Buffer_resp[22];
						Mod_MD.Recalque_201[indice].Nivel_acionamento[3] = (int)Comunicacao.Buffer_resp[23] * 256 + (int)Comunicacao.Buffer_resp[24];
						Mod_MD.Recalque_201[indice].Nivel_parada[1] = (int)Comunicacao.Buffer_resp[25] * 256 + (int)Comunicacao.Buffer_resp[26];
						Mod_MD.Recalque_201[indice].Nivel_parada[2] = (int)Comunicacao.Buffer_resp[27] * 256 + (int)Comunicacao.Buffer_resp[28];
						Mod_MD.Recalque_201[indice].Nivel_parada[3] = (int)Comunicacao.Buffer_resp[29] * 256 + (int)Comunicacao.Buffer_resp[30];
						Mod_MD.Recalque_201[indice].Tempo_partida[1] = (int)Comunicacao.Buffer_resp[31] * 256 + (int)Comunicacao.Buffer_resp[32];
						Mod_MD.Recalque_201[indice].Tempo_partida[2] = (int)Comunicacao.Buffer_resp[33] * 256 + (int)Comunicacao.Buffer_resp[34];
						Mod_MD.Recalque_201[indice].Tempo_partida[3] = (int)Comunicacao.Buffer_resp[35] * 256 + (int)Comunicacao.Buffer_resp[36];
						Mod_MD.Recalque_201[indice].Tempo_parada[1] = (int)Comunicacao.Buffer_resp[37] * 256 + (int)Comunicacao.Buffer_resp[38];
						Mod_MD.Recalque_201[indice].Tempo_parada[2] = (int)Comunicacao.Buffer_resp[39] * 256 + (int)Comunicacao.Buffer_resp[40];
						Mod_MD.Recalque_201[indice].Tempo_parada[3] = (int)Comunicacao.Buffer_resp[41] * 256 + (int)Comunicacao.Buffer_resp[42];
						Mod_MD.Recalque_201[indice].Tempo_entre_acionamento = (int)Comunicacao.Buffer_resp[43] * 256 + (int)Comunicacao.Buffer_resp[44];
					}
				}
				else if (pag == 512)
				{
					Mod_MD.Recalque_201[indice].End_repetidora = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					Mod_MD.Recalque_201[indice].Num_repetidoras = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					int num = 1;
					do
					{
						Mod_MD.Recalque_201[indice].Repetidoras[num] = (int)Comunicacao.Buffer_resp[5 + num * 2] * 256 + (int)Comunicacao.Buffer_resp[6 + num * 2];
						num++;
					}
					while (num <= 50);
				}
			}
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x00255654 File Offset: 0x00253A54
		public static void Atualiza_dados_MD202(int indice, int pag)
		{
			checked
			{
				if (pag == 100)
				{
					string versao = Geral.Config_geral.Versao;
					int num = 0;
					if (Operators.CompareString(versao, "820_10", false) == 0)
					{
						num = 1;
						Mod_MD.Recalque_202[indice].Periferico_End_1 = (int)Comunicacao.Buffer_resp[107];
						if (Comunicacao.Buffer_resp[108] < 51)
						{
							Mod_MD.Recalque_202[indice].Periferico_Tipo_1 = 0;
						}
						else
						{
							Mod_MD.Recalque_202[indice].Periferico_Tipo_1 = (int)(Comunicacao.Buffer_resp[108] - 50);
						}
						Mod_MD.Recalque_202[indice].Periferico_End_2 = (int)Comunicacao.Buffer_resp[109];
						if (Comunicacao.Buffer_resp[110] < 52)
						{
							Mod_MD.Recalque_202[indice].Periferico_Tipo_2 = 0;
						}
						else
						{
							Mod_MD.Recalque_202[indice].Periferico_Tipo_2 = (int)(Comunicacao.Buffer_resp[110] - 51);
						}
						Mod_MD.Recalque_202[indice].Periferico_End_3 = (int)Comunicacao.Buffer_resp[111];
						if (Comunicacao.Buffer_resp[112] < 51)
						{
							Mod_MD.Recalque_202[indice].Periferico_Tipo_3 = 0;
						}
						else
						{
							Mod_MD.Recalque_202[indice].Periferico_Tipo_3 = (int)(Comunicacao.Buffer_resp[112] - 51);
						}
						Mod_MD.Recalque_202[indice].Periferico_End_4 = (int)Comunicacao.Buffer_resp[113];
						if (Comunicacao.Buffer_resp[114] < 52)
						{
							Mod_MD.Recalque_202[indice].Periferico_Tipo_4 = 0;
						}
						else
						{
							Mod_MD.Recalque_202[indice].Periferico_Tipo_4 = (int)(Comunicacao.Buffer_resp[114] - 51);
						}
					}
					else
					{
						num = 2;
					}
					Mod_MD.Recalque_202[indice].End_estacao = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					Mod_MD.Recalque_202[indice].End_mestre = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					Mod_MD.Recalque_202[indice].Hab_repetidora = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					Mod_MD.Recalque_202[indice].Tempo_ptt = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
					Mod_MD.Recalque_202[indice].BaudRate = (int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12];
					Mod_MD.Recalque_202[indice].Intervalo_filtroAD = (int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14];
					Mod_MD.Recalque_202[indice].Tamanho_filtroAD = (int)Comunicacao.Buffer_resp[15] * 256 + (int)Comunicacao.Buffer_resp[16];
					Mod_MD.Recalque_202[indice].Modo_operacao = (int)Comunicacao.Buffer_resp[17] * 256 + (int)Comunicacao.Buffer_resp[18];
					Mod_MD.Recalque_202[indice].Numero_motores = (int)Comunicacao.Buffer_resp[19] * 256 + (int)Comunicacao.Buffer_resp[20];
					Mod_MD.Recalque_202[indice].Numero_valvulas = (int)Comunicacao.Buffer_resp[21] * 256 + (int)Comunicacao.Buffer_resp[22];
					Mod_MD.Recalque_202[indice].Modo_partida[1] = (int)Comunicacao.Buffer_resp[23] * 256 + (int)Comunicacao.Buffer_resp[24];
					Mod_MD.Recalque_202[indice].Modo_partida[2] = (int)Comunicacao.Buffer_resp[25] * 256 + (int)Comunicacao.Buffer_resp[26];
					Mod_MD.Recalque_202[indice].Modo_partida[3] = (int)Comunicacao.Buffer_resp[27] * 256 + (int)Comunicacao.Buffer_resp[28];
					Mod_MD.Recalque_202[indice].Modo_partida[4] = (int)Comunicacao.Buffer_resp[29] * 256 + (int)Comunicacao.Buffer_resp[30];
					Mod_MD.Recalque_202[indice].Entrada_digital[1] = (int)Comunicacao.Buffer_resp[31] * 256 + (int)Comunicacao.Buffer_resp[32];
					Mod_MD.Recalque_202[indice].Entrada_digital[2] = (int)Comunicacao.Buffer_resp[33] * 256 + (int)Comunicacao.Buffer_resp[34];
					Mod_MD.Recalque_202[indice].Entrada_digital[3] = (int)Comunicacao.Buffer_resp[35] * 256 + (int)Comunicacao.Buffer_resp[36];
					Mod_MD.Recalque_202[indice].Entrada_digital[4] = (int)Comunicacao.Buffer_resp[37] * 256 + (int)Comunicacao.Buffer_resp[38];
					Mod_MD.Recalque_202[indice].Entrada_digital[5] = (int)Comunicacao.Buffer_resp[39] * 256 + (int)Comunicacao.Buffer_resp[40];
					Mod_MD.Recalque_202[indice].Entrada_digital[6] = (int)Comunicacao.Buffer_resp[41] * 256 + (int)Comunicacao.Buffer_resp[42];
					Mod_MD.Recalque_202[indice].Entrada_digital[7] = (int)Comunicacao.Buffer_resp[43] * 256 + (int)Comunicacao.Buffer_resp[44];
					Mod_MD.Recalque_202[indice].Entrada_digital[8] = (int)Comunicacao.Buffer_resp[45] * 256 + (int)Comunicacao.Buffer_resp[46];
					Mod_MD.Recalque_202[indice].Set_nivel_desejado = (int)Math.Round((double)((int)Comunicacao.Buffer_resp[47] * 256 + (int)Comunicacao.Buffer_resp[48]) / (double)num);
					Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba1 = (int)Math.Round((double)((int)Comunicacao.Buffer_resp[49] * 256 + (int)Comunicacao.Buffer_resp[50]) / (double)num);
					Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba2 = (int)Math.Round((double)((int)Comunicacao.Buffer_resp[51] * 256 + (int)Comunicacao.Buffer_resp[52]) / (double)num);
					Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba3 = (int)Math.Round((double)((int)Comunicacao.Buffer_resp[53] * 256 + (int)Comunicacao.Buffer_resp[54]) / (double)num);
					Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba4 = (int)Math.Round((double)((int)Comunicacao.Buffer_resp[55] * 256 + (int)Comunicacao.Buffer_resp[56]) / (double)num);
					Mod_MD.Recalque_202[indice].Tempo_mais_bomba = (int)Comunicacao.Buffer_resp[57] * 256 + (int)Comunicacao.Buffer_resp[58];
					Mod_MD.Recalque_202[indice].Pressao_min_succao = (int)Math.Round((double)((int)Comunicacao.Buffer_resp[59] * 256 + (int)Comunicacao.Buffer_resp[60]) / (double)num);
					Mod_MD.Recalque_202[indice].Pressao_min_recalque = (int)Math.Round((double)((int)Comunicacao.Buffer_resp[61] * 256 + (int)Comunicacao.Buffer_resp[62]) / (double)num);
					Mod_MD.Recalque_202[indice].Nivel_protecao_desliga = (int)Math.Round((double)((int)Comunicacao.Buffer_resp[63] * 256 + (int)Comunicacao.Buffer_resp[64]) / (double)num);
					Mod_MD.Recalque_202[indice].Nivel_protecao_liga = (int)Math.Round((double)((int)Comunicacao.Buffer_resp[65] * 256 + (int)Comunicacao.Buffer_resp[66]) / (double)num);
					Mod_MD.Recalque_202[indice].Tempo_partida[1] = (int)Comunicacao.Buffer_resp[67] * 256 + (int)Comunicacao.Buffer_resp[68];
					Mod_MD.Recalque_202[indice].Tempo_partida[2] = (int)Comunicacao.Buffer_resp[69] * 256 + (int)Comunicacao.Buffer_resp[70];
					Mod_MD.Recalque_202[indice].Tempo_partida[3] = (int)Comunicacao.Buffer_resp[71] * 256 + (int)Comunicacao.Buffer_resp[72];
					Mod_MD.Recalque_202[indice].Tempo_partida[4] = (int)Comunicacao.Buffer_resp[73] * 256 + (int)Comunicacao.Buffer_resp[74];
					Mod_MD.Recalque_202[indice].Tempo_parada[1] = (int)Comunicacao.Buffer_resp[75] * 256 + (int)Comunicacao.Buffer_resp[76];
					Mod_MD.Recalque_202[indice].Tempo_parada[2] = (int)Comunicacao.Buffer_resp[77] * 256 + (int)Comunicacao.Buffer_resp[78];
					Mod_MD.Recalque_202[indice].Tempo_parada[3] = (int)Comunicacao.Buffer_resp[79] * 256 + (int)Comunicacao.Buffer_resp[80];
					Mod_MD.Recalque_202[indice].Tempo_parada[4] = (int)Comunicacao.Buffer_resp[81] * 256 + (int)Comunicacao.Buffer_resp[82];
					Mod_MD.Recalque_202[indice].Tempo_abertura_val[1] = (int)Comunicacao.Buffer_resp[83] * 256 + (int)Comunicacao.Buffer_resp[84];
					Mod_MD.Recalque_202[indice].Tempo_abertura_val[2] = (int)Comunicacao.Buffer_resp[85] * 256 + (int)Comunicacao.Buffer_resp[86];
					Mod_MD.Recalque_202[indice].Tempo_abertura_val[3] = (int)Comunicacao.Buffer_resp[87] * 256 + (int)Comunicacao.Buffer_resp[88];
					Mod_MD.Recalque_202[indice].Tempo_abertura_val[4] = (int)Comunicacao.Buffer_resp[89] * 256 + (int)Comunicacao.Buffer_resp[90];
					Mod_MD.Recalque_202[indice].Tempo_fechamento_val[1] = (int)Comunicacao.Buffer_resp[91] * 256 + (int)Comunicacao.Buffer_resp[92];
					Mod_MD.Recalque_202[indice].Tempo_fechamento_val[2] = (int)Comunicacao.Buffer_resp[93] * 256 + (int)Comunicacao.Buffer_resp[94];
					Mod_MD.Recalque_202[indice].Tempo_fechamento_val[3] = (int)Comunicacao.Buffer_resp[95] * 256 + (int)Comunicacao.Buffer_resp[96];
					Mod_MD.Recalque_202[indice].Tempo_fechamento_val[4] = (int)Comunicacao.Buffer_resp[97] * 256 + (int)Comunicacao.Buffer_resp[98];
					Mod_MD.Recalque_202[indice].Tempo_entre_acionamento = (int)Comunicacao.Buffer_resp[99] * 256 + (int)Comunicacao.Buffer_resp[100];
					Mod_MD.Recalque_202[indice].Num_bombas_simultaneas = (int)Comunicacao.Buffer_resp[101] * 256 + (int)Comunicacao.Buffer_resp[102];
					Mod_MD.Recalque_202[indice].Controle_nivel_fonte = (int)Comunicacao.Buffer_resp[103] * 256 + (int)Comunicacao.Buffer_resp[104];
					Mod_MD.Recalque_202[indice].Num_totalizacoes = (int)Comunicacao.Buffer_resp[105] * 256 + (int)Comunicacao.Buffer_resp[106];
				}
				else if (pag == 512)
				{
					Mod_MD.Recalque_202[indice].End_repetidora = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					Mod_MD.Recalque_202[indice].Num_repetidoras = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					int num2 = 1;
					do
					{
						Mod_MD.Recalque_202[indice].Repetidoras[num2] = (int)Comunicacao.Buffer_resp[5 + num2 * 2] * 256 + (int)Comunicacao.Buffer_resp[6 + num2 * 2];
						num2++;
					}
					while (num2 <= 50);
				}
			}
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x002560E8 File Offset: 0x002544E8
		public static void Atualiza_dados_MD302(int pag)
		{
			checked
			{
				if (pag == 100)
				{
					Mod_MD.Central_302_geral.Endereco = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					Mod_MD.Central_302_geral.Retray = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					Mod_MD.Central_302_geral.Timeout = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					Mod_MD.Central_302_geral.Tempo_ptt = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
					Mod_MD.Central_302_geral.Baud_rate_com2 = (int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12];
					Mod_MD.Central_302_geral.Erros_falha = (int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14];
					Mod_MD.Central_302_geral.Intervalo_polling = (int)Comunicacao.Buffer_resp[15] * 256 + (int)Comunicacao.Buffer_resp[16];
					Mod_MD.Central_302_geral.Qtd_res = (int)Comunicacao.Buffer_resp[17] * 256 + (int)Comunicacao.Buffer_resp[18];
					Mod_MD.Central_302_geral.Qtd_equip_res = (int)Comunicacao.Buffer_resp[19] * 256 + (int)Comunicacao.Buffer_resp[20];
					Mod_MD.Central_302_geral.Qdt_equip_rq = (int)Comunicacao.Buffer_resp[21] * 256 + (int)Comunicacao.Buffer_resp[22];
					Mod_MD.Central_302_geral.Qtd_equip_vista = (int)Comunicacao.Buffer_resp[23] * 256 + (int)Comunicacao.Buffer_resp[24];
					Mod_MD.Central_302_geral.End_ini_equip_res = (int)Comunicacao.Buffer_resp[25] * 256 + (int)Comunicacao.Buffer_resp[26];
					Mod_MD.Central_302_geral.End_ini_equip_rq = (int)Comunicacao.Buffer_resp[27] * 256 + (int)Comunicacao.Buffer_resp[28];
					Mod_MD.Central_302_geral.End_ini_equip_vista = (int)Comunicacao.Buffer_resp[29] * 256 + (int)Comunicacao.Buffer_resp[30];
				}
				else if (pag == 512)
				{
					int num = 1;
					do
					{
						Mod_MD.Salva_dados_MD302_RE(num, 0);
						num++;
					}
					while (num <= 20);
				}
				else if (pag == 592)
				{
					int num = 1;
					do
					{
						Mod_MD.Salva_dados_MD302_RE(num, 20);
						num++;
					}
					while (num <= 20);
				}
				else if (pag == 768)
				{
					Mod_MD.Salva_dados_MD302_RQ(1, 0);
					Mod_MD.Salva_dados_MD302_RQ(2, 0);
					Mod_MD.Salva_dados_MD302_RQ(3, 0);
					Mod_MD.Salva_dados_MD302_RQ(4, 0);
				}
				else if (pag == 888)
				{
					Mod_MD.Salva_dados_MD302_RQ(1, 4);
					Mod_MD.Salva_dados_MD302_RQ(2, 4);
					Mod_MD.Salva_dados_MD302_RQ(3, 4);
				}
				else if (pag == 1024)
				{
					Mod_MD.Salva_dados_MD302_RQ(1, 7);
					Mod_MD.Salva_dados_MD302_RQ(2, 7);
					Mod_MD.Salva_dados_MD302_RQ(3, 7);
					Mod_MD.Salva_dados_MD302_RQ(4, 7);
				}
				else if (pag == 1144)
				{
					Mod_MD.Salva_dados_MD302_RQ(1, 11);
					Mod_MD.Salva_dados_MD302_RQ(2, 11);
					Mod_MD.Salva_dados_MD302_RQ(3, 11);
				}
				else if (pag == 1280)
				{
					Mod_MD.Salva_dados_MD302_RQ(1, 14);
					Mod_MD.Salva_dados_MD302_RQ(2, 14);
					Mod_MD.Salva_dados_MD302_RQ(3, 14);
					Mod_MD.Salva_dados_MD302_RQ(4, 14);
				}
				else if (pag == 1400)
				{
					Mod_MD.Salva_dados_MD302_RQ(1, 18);
					Mod_MD.Salva_dados_MD302_RQ(2, 18);
					Mod_MD.Salva_dados_MD302_RQ(3, 18);
				}
				else if (pag == 1536)
				{
					Mod_MD.Salva_dados_MD302_RQ(1, 21);
					Mod_MD.Salva_dados_MD302_RQ(2, 21);
					Mod_MD.Salva_dados_MD302_RQ(3, 21);
					Mod_MD.Salva_dados_MD302_RQ(4, 21);
				}
				else if (pag == 1656)
				{
					Mod_MD.Salva_dados_MD302_RQ(1, 25);
					Mod_MD.Salva_dados_MD302_RQ(2, 25);
					Mod_MD.Salva_dados_MD302_RQ(3, 25);
				}
				else if (pag == 1792)
				{
					Mod_MD.Salva_dados_MD302_VISTA(1, 0);
					Mod_MD.Salva_dados_MD302_VISTA(2, 0);
				}
				else if (pag == 1878)
				{
					Mod_MD.Salva_dados_MD302_VISTA(1, 2);
					Mod_MD.Salva_dados_MD302_VISTA(2, 2);
				}
				else if (pag == 1964)
				{
					Mod_MD.Salva_dados_MD302_VISTA(1, 4);
				}
			}
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x00256484 File Offset: 0x00254884
		public static void Salva_dados_MD302_RE(int indice, int offset_equip)
		{
			checked
			{
				int num = (indice - 1) * 8;
				Mod_MD.Central_302_res[indice + offset_equip].Res_relativo = (int)Comunicacao.Buffer_resp[3 + num] * 256 + (int)Comunicacao.Buffer_resp[4 + num];
				Mod_MD.Central_302_res[indice + offset_equip].Prioridade = (int)Comunicacao.Buffer_resp[5 + num] * 256 + (int)Comunicacao.Buffer_resp[6 + num];
				Mod_MD.Central_302_res[indice + offset_equip].Altura = (int)Comunicacao.Buffer_resp[7 + num] * 256 + (int)Comunicacao.Buffer_resp[8 + num];
				Mod_MD.Central_302_res[indice + offset_equip].Msg = (int)Comunicacao.Buffer_resp[9 + num] * 256 + (int)Comunicacao.Buffer_resp[10 + num];
			}
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x00256548 File Offset: 0x00254948
		public static void Salva_dados_MD302_RQ(int indice, int offset_equip)
		{
			checked
			{
				int num = (indice - 1) * 60;
				Mod_MD.Central_302_rq[indice + offset_equip].Res_origem = (int)Comunicacao.Buffer_resp[3 + num] * 256 + (int)Comunicacao.Buffer_resp[4 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].Res_destino = (int)Comunicacao.Buffer_resp[5 + num] * 256 + (int)Comunicacao.Buffer_resp[6 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].Res_relativo_R1 = (int)Comunicacao.Buffer_resp[7 + num] * 256 + (int)Comunicacao.Buffer_resp[8 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].Res_relativo_R2 = (int)Comunicacao.Buffer_resp[9 + num] * 256 + (int)Comunicacao.Buffer_resp[10 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].Res_relativo_R3 = (int)Comunicacao.Buffer_resp[11 + num] * 256 + (int)Comunicacao.Buffer_resp[12 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].Res_relativo_R4 = (int)Comunicacao.Buffer_resp[13 + num] * 256 + (int)Comunicacao.Buffer_resp[14 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].Msg_res_R1 = (int)Comunicacao.Buffer_resp[15 + num] * 256 + (int)Comunicacao.Buffer_resp[16 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].Msg_res_R2 = (int)Comunicacao.Buffer_resp[17 + num] * 256 + (int)Comunicacao.Buffer_resp[18 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].Msg_res_R3 = (int)Comunicacao.Buffer_resp[19 + num] * 256 + (int)Comunicacao.Buffer_resp[20 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].Msg_res_R4 = (int)Comunicacao.Buffer_resp[21 + num] * 256 + (int)Comunicacao.Buffer_resp[22 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].modelo = (int)Comunicacao.Buffer_resp[23 + num] * 256 + (int)Comunicacao.Buffer_resp[24 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].Prioridade = (int)Comunicacao.Buffer_resp[25 + num] * 256 + (int)Comunicacao.Buffer_resp[26 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].Msg = (int)Comunicacao.Buffer_resp[27 + num] * 256 + (int)Comunicacao.Buffer_resp[28 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].Hab_cmd = (int)Comunicacao.Buffer_resp[29 + num] * 256 + (int)Comunicacao.Buffer_resp[30 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].escala_1 = (int)Comunicacao.Buffer_resp[31 + num] * 256 + (int)Comunicacao.Buffer_resp[32 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].escala_2 = (int)Comunicacao.Buffer_resp[33 + num] * 256 + (int)Comunicacao.Buffer_resp[34 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].escala_3 = (int)Comunicacao.Buffer_resp[35 + num] * 256 + (int)Comunicacao.Buffer_resp[36 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].escala_4 = (int)Comunicacao.Buffer_resp[37 + num] * 256 + (int)Comunicacao.Buffer_resp[38 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].escala_5 = (int)Comunicacao.Buffer_resp[39 + num] * 256 + (int)Comunicacao.Buffer_resp[40 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].escala_6 = (int)Comunicacao.Buffer_resp[41 + num] * 256 + (int)Comunicacao.Buffer_resp[42 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].escala_7 = (int)Comunicacao.Buffer_resp[43 + num] * 256 + (int)Comunicacao.Buffer_resp[44 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].escala_8 = (int)Comunicacao.Buffer_resp[45 + num] * 256 + (int)Comunicacao.Buffer_resp[46 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].escala_9 = (int)Comunicacao.Buffer_resp[47 + num] * 256 + (int)Comunicacao.Buffer_resp[48 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].escala_10 = (int)Comunicacao.Buffer_resp[49 + num] * 256 + (int)Comunicacao.Buffer_resp[50 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].escala_11 = (int)Comunicacao.Buffer_resp[51 + num] * 256 + (int)Comunicacao.Buffer_resp[52 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].escala_12 = (int)Comunicacao.Buffer_resp[53 + num] * 256 + (int)Comunicacao.Buffer_resp[54 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].escala_13 = (int)Comunicacao.Buffer_resp[55 + num] * 256 + (int)Comunicacao.Buffer_resp[56 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].escala_14 = (int)Comunicacao.Buffer_resp[57 + num] * 256 + (int)Comunicacao.Buffer_resp[58 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].escala_15 = (int)Comunicacao.Buffer_resp[59 + num] * 256 + (int)Comunicacao.Buffer_resp[60 + num];
				Mod_MD.Central_302_rq[indice + offset_equip].escala_16 = (int)Comunicacao.Buffer_resp[61 + num] * 256 + (int)Comunicacao.Buffer_resp[62 + num];
			}
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x00256A9C File Offset: 0x00254E9C
		public static void Salva_dados_MD302_VISTA(int indice, int offset_equip)
		{
			checked
			{
				int num = (indice - 1) * 86;
				Mod_MD.Central_302_centrais[indice + offset_equip].num_res = (int)Comunicacao.Buffer_resp[3 + num] * 256 + (int)Comunicacao.Buffer_resp[4 + num];
				Mod_MD.Central_302_centrais[indice + offset_equip].num_rq = (int)Comunicacao.Buffer_resp[5 + num] * 256 + (int)Comunicacao.Buffer_resp[6 + num];
				Mod_MD.Central_302_centrais[indice + offset_equip].prioridade = (int)Comunicacao.Buffer_resp[7 + num] * 256 + (int)Comunicacao.Buffer_resp[8 + num];
				int num2 = 0;
				do
				{
					int num3 = num + num2 * 2;
					Mod_MD.Central_302_indices[indice + offset_equip, num2 + 1] = (int)Comunicacao.Buffer_resp[9 + num3] * 256 + (int)Comunicacao.Buffer_resp[10 + num3];
					num2++;
				}
				while (num2 <= 39);
			}
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x00256B70 File Offset: 0x00254F70
		public static bool CMD_Esc_MD201_pagina_1(int endereco, int indice)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 1;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 21;
				Comunicacao.Buffer_cmd[6] = 42;
				Comunicacao.Buffer_cmd[7] = 0;
				Comunicacao.Buffer_cmd[8] = (byte)Mod_MD.Recalque_201[indice].End_estacao;
				Comunicacao.Buffer_cmd[9] = 0;
				Comunicacao.Buffer_cmd[10] = (byte)Mod_MD.Recalque_201[indice].End_mestre;
				Comunicacao.Buffer_cmd[11] = (byte)(Mod_MD.Recalque_201[indice].Hab_repetidora / 256);
				Comunicacao.Buffer_cmd[12] = (byte)(Mod_MD.Recalque_201[indice].Hab_repetidora % 256);
				Comunicacao.Buffer_cmd[13] = (byte)(Mod_MD.Recalque_201[indice].Tempo_ptt / 256);
				Comunicacao.Buffer_cmd[14] = (byte)(Mod_MD.Recalque_201[indice].Tempo_ptt % 256);
				Comunicacao.Buffer_cmd[15] = 0;
				Comunicacao.Buffer_cmd[16] = (byte)Mod_MD.Recalque_201[indice].Quantidade_motores;
				Comunicacao.Buffer_cmd[17] = (byte)(Mod_MD.Recalque_201[indice].Modo_partida[1] / 256);
				Comunicacao.Buffer_cmd[18] = (byte)(Mod_MD.Recalque_201[indice].Modo_partida[1] % 256);
				Comunicacao.Buffer_cmd[19] = (byte)(Mod_MD.Recalque_201[indice].Modo_partida[2] / 256);
				Comunicacao.Buffer_cmd[20] = (byte)(Mod_MD.Recalque_201[indice].Modo_partida[2] % 256);
				Comunicacao.Buffer_cmd[21] = (byte)(Mod_MD.Recalque_201[indice].Modo_partida[3] / 256);
				Comunicacao.Buffer_cmd[22] = (byte)(Mod_MD.Recalque_201[indice].Modo_partida[3] % 256);
				string versao = Geral.Config_geral.Versao;
				if (Operators.CompareString(versao, "21", false) == 0)
				{
					Comunicacao.Buffer_cmd[23] = (byte)(Mod_MD.Recalque_201[indice].Nivel_acionamento[1] * 2 / 256);
					Comunicacao.Buffer_cmd[24] = (byte)(Mod_MD.Recalque_201[indice].Nivel_acionamento[1] * 2 % 256);
					Comunicacao.Buffer_cmd[25] = (byte)(Mod_MD.Recalque_201[indice].Nivel_acionamento[2] * 2 / 256);
					Comunicacao.Buffer_cmd[26] = (byte)(Mod_MD.Recalque_201[indice].Nivel_acionamento[2] * 2 % 256);
					Comunicacao.Buffer_cmd[27] = (byte)(Mod_MD.Recalque_201[indice].Nivel_acionamento[3] * 2 / 256);
					Comunicacao.Buffer_cmd[28] = (byte)(Mod_MD.Recalque_201[indice].Nivel_acionamento[3] * 2 % 256);
					Comunicacao.Buffer_cmd[29] = (byte)(Mod_MD.Recalque_201[indice].Nivel_parada[1] * 2 / 256);
					Comunicacao.Buffer_cmd[30] = (byte)(Mod_MD.Recalque_201[indice].Nivel_parada[1] * 2 % 256);
					Comunicacao.Buffer_cmd[31] = (byte)(Mod_MD.Recalque_201[indice].Nivel_parada[2] * 2 / 256);
					Comunicacao.Buffer_cmd[32] = (byte)(Mod_MD.Recalque_201[indice].Nivel_parada[2] * 2 % 256);
					Comunicacao.Buffer_cmd[33] = (byte)(Mod_MD.Recalque_201[indice].Nivel_parada[3] * 2 / 256);
					Comunicacao.Buffer_cmd[34] = (byte)(Mod_MD.Recalque_201[indice].Nivel_parada[3] * 2 % 256);
				}
				else if (Operators.CompareString(versao, "821_10", false) == 0)
				{
					Comunicacao.Buffer_cmd[23] = (byte)(Mod_MD.Recalque_201[indice].Nivel_acionamento[1] / 256);
					Comunicacao.Buffer_cmd[24] = (byte)(Mod_MD.Recalque_201[indice].Nivel_acionamento[1] % 256);
					Comunicacao.Buffer_cmd[25] = (byte)(Mod_MD.Recalque_201[indice].Nivel_acionamento[2] / 256);
					Comunicacao.Buffer_cmd[26] = (byte)(Mod_MD.Recalque_201[indice].Nivel_acionamento[2] % 256);
					Comunicacao.Buffer_cmd[27] = (byte)(Mod_MD.Recalque_201[indice].Nivel_acionamento[3] / 256);
					Comunicacao.Buffer_cmd[28] = (byte)(Mod_MD.Recalque_201[indice].Nivel_acionamento[3] % 256);
					Comunicacao.Buffer_cmd[29] = (byte)(Mod_MD.Recalque_201[indice].Nivel_parada[1] / 256);
					Comunicacao.Buffer_cmd[30] = (byte)(Mod_MD.Recalque_201[indice].Nivel_parada[1] % 256);
					Comunicacao.Buffer_cmd[31] = (byte)(Mod_MD.Recalque_201[indice].Nivel_parada[2] / 256);
					Comunicacao.Buffer_cmd[32] = (byte)(Mod_MD.Recalque_201[indice].Nivel_parada[2] % 256);
					Comunicacao.Buffer_cmd[33] = (byte)(Mod_MD.Recalque_201[indice].Nivel_parada[3] / 256);
					Comunicacao.Buffer_cmd[34] = (byte)(Mod_MD.Recalque_201[indice].Nivel_parada[3] % 256);
				}
				Comunicacao.Buffer_cmd[35] = (byte)(Mod_MD.Recalque_201[indice].Tempo_partida[1] / 256);
				Comunicacao.Buffer_cmd[36] = (byte)(Mod_MD.Recalque_201[indice].Tempo_partida[1] % 256);
				Comunicacao.Buffer_cmd[37] = (byte)(Mod_MD.Recalque_201[indice].Tempo_partida[2] / 256);
				Comunicacao.Buffer_cmd[38] = (byte)(Mod_MD.Recalque_201[indice].Tempo_partida[2] % 256);
				Comunicacao.Buffer_cmd[39] = (byte)(Mod_MD.Recalque_201[indice].Tempo_partida[3] / 256);
				Comunicacao.Buffer_cmd[40] = (byte)(Mod_MD.Recalque_201[indice].Tempo_partida[3] % 256);
				Comunicacao.Buffer_cmd[41] = (byte)(Mod_MD.Recalque_201[indice].Tempo_parada[1] / 256);
				Comunicacao.Buffer_cmd[42] = (byte)(Mod_MD.Recalque_201[indice].Tempo_parada[1] % 256);
				Comunicacao.Buffer_cmd[43] = (byte)(Mod_MD.Recalque_201[indice].Tempo_parada[2] / 256);
				Comunicacao.Buffer_cmd[44] = (byte)(Mod_MD.Recalque_201[indice].Tempo_parada[2] % 256);
				Comunicacao.Buffer_cmd[45] = (byte)(Mod_MD.Recalque_201[indice].Tempo_parada[3] / 256);
				Comunicacao.Buffer_cmd[46] = (byte)(Mod_MD.Recalque_201[indice].Tempo_parada[3] % 256);
				Comunicacao.Buffer_cmd[47] = (byte)(Mod_MD.Recalque_201[indice].Tempo_entre_acionamento / 256);
				Comunicacao.Buffer_cmd[48] = (byte)(Mod_MD.Recalque_201[indice].Tempo_entre_acionamento % 256);
				int num = 49;
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[49] = (byte)(num2 % 256);
				Comunicacao.Buffer_cmd[50] = (byte)(num2 / 256);
				Comunicacao.Ctrl_Com.Cont_tx = 51;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, " Comando de escrita da página 1 ");
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x00257314 File Offset: 0x00255714
		public static bool CMD_Esc_MD201_pagina_2(int endereco, int indice)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 2;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 52;
				Comunicacao.Buffer_cmd[6] = 104;
				Comunicacao.Buffer_cmd[7] = 0;
				Comunicacao.Buffer_cmd[8] = (byte)Mod_MD.Recalque_201[indice].End_repetidora;
				Comunicacao.Buffer_cmd[9] = 0;
				Comunicacao.Buffer_cmd[10] = (byte)Mod_MD.Recalque_201[indice].Num_repetidoras;
				int num = 1;
				do
				{
					Comunicacao.Buffer_cmd[9 + num * 2] = (byte)(Mod_MD.Recalque_201[indice].Repetidoras[num] / 256);
					Comunicacao.Buffer_cmd[10 + num * 2] = (byte)(Mod_MD.Recalque_201[indice].Repetidoras[num] % 256);
					num++;
				}
				while (num <= 50);
				int num2 = 111;
				int num3 = Comunicacao.Crc16_TX(ref num2);
				Comunicacao.Buffer_cmd[111] = (byte)(num3 % 256);
				Comunicacao.Buffer_cmd[112] = (byte)(num3 / 256);
				Comunicacao.Ctrl_Com.Cont_tx = 113;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, " Comando de escrita da página 2 ");
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x00257478 File Offset: 0x00255878
		public static bool CMD_Esc_MD202_pagina_1(int endereco, int indice)
		{
			string versao = Geral.Config_geral.Versao;
			int num = 0;
			int num2 = 0;
			if (Operators.CompareString(versao, "820_10", false) == 0)
			{
				num = 1;
				num2 = 56;
			}
			else
			{
				num = 2;
				num2 = 52;
			}
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 1;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = (byte)num2;
				Comunicacao.Buffer_cmd[6] = (byte)(num2 * 2);
				Comunicacao.Buffer_cmd[7] = 0;
				Comunicacao.Buffer_cmd[8] = (byte)Mod_MD.Recalque_202[indice].End_estacao;
				Comunicacao.Buffer_cmd[9] = 0;
				Comunicacao.Buffer_cmd[10] = (byte)Mod_MD.Recalque_202[indice].End_mestre;
				Comunicacao.Buffer_cmd[11] = (byte)(Mod_MD.Recalque_202[indice].Hab_repetidora / 256);
				Comunicacao.Buffer_cmd[12] = (byte)(Mod_MD.Recalque_202[indice].Hab_repetidora % 256);
				Comunicacao.Buffer_cmd[13] = (byte)(Mod_MD.Recalque_202[indice].Tempo_ptt / 256);
				Comunicacao.Buffer_cmd[14] = (byte)(Mod_MD.Recalque_202[indice].Tempo_ptt % 256);
				Comunicacao.Buffer_cmd[15] = (byte)(Mod_MD.Recalque_202[indice].BaudRate / 256);
				Comunicacao.Buffer_cmd[16] = (byte)(Mod_MD.Recalque_202[indice].BaudRate % 256);
				Comunicacao.Buffer_cmd[17] = (byte)(Mod_MD.Recalque_202[indice].Intervalo_filtroAD / 256);
				Comunicacao.Buffer_cmd[18] = (byte)(Mod_MD.Recalque_202[indice].Intervalo_filtroAD % 256);
				Comunicacao.Buffer_cmd[19] = 0;
				Comunicacao.Buffer_cmd[20] = (byte)Mod_MD.Recalque_202[indice].Tamanho_filtroAD;
				Comunicacao.Buffer_cmd[21] = Conversions.ToByte(Operators.IntDivideObject(Mod_MD.Recalque_202[indice].Modo_operacao, 256));
				Comunicacao.Buffer_cmd[22] = Conversions.ToByte(Operators.ModObject(Mod_MD.Recalque_202[indice].Modo_operacao, 256));
				Comunicacao.Buffer_cmd[23] = 0;
				Comunicacao.Buffer_cmd[24] = (byte)Mod_MD.Recalque_202[indice].Numero_motores;
				Comunicacao.Buffer_cmd[25] = 0;
				Comunicacao.Buffer_cmd[26] = (byte)Mod_MD.Recalque_202[indice].Numero_valvulas;
				Comunicacao.Buffer_cmd[27] = (byte)(Mod_MD.Recalque_202[indice].Modo_partida[1] / 256);
				Comunicacao.Buffer_cmd[28] = (byte)(Mod_MD.Recalque_202[indice].Modo_partida[1] % 256);
				Comunicacao.Buffer_cmd[29] = (byte)(Mod_MD.Recalque_202[indice].Modo_partida[2] / 256);
				Comunicacao.Buffer_cmd[30] = (byte)(Mod_MD.Recalque_202[indice].Modo_partida[2] % 256);
				Comunicacao.Buffer_cmd[31] = (byte)(Mod_MD.Recalque_202[indice].Modo_partida[3] / 256);
				Comunicacao.Buffer_cmd[32] = (byte)(Mod_MD.Recalque_202[indice].Modo_partida[3] % 256);
				Comunicacao.Buffer_cmd[33] = (byte)(Mod_MD.Recalque_202[indice].Modo_partida[4] / 256);
				Comunicacao.Buffer_cmd[34] = (byte)(Mod_MD.Recalque_202[indice].Modo_partida[4] % 256);
				Comunicacao.Buffer_cmd[35] = (byte)(Mod_MD.Recalque_202[indice].Entrada_digital[1] / 256);
				Comunicacao.Buffer_cmd[36] = (byte)(Mod_MD.Recalque_202[indice].Entrada_digital[1] % 256);
				Comunicacao.Buffer_cmd[37] = (byte)(Mod_MD.Recalque_202[indice].Entrada_digital[2] / 256);
				Comunicacao.Buffer_cmd[38] = (byte)(Mod_MD.Recalque_202[indice].Entrada_digital[2] % 256);
				Comunicacao.Buffer_cmd[39] = (byte)(Mod_MD.Recalque_202[indice].Entrada_digital[3] / 256);
				Comunicacao.Buffer_cmd[40] = (byte)(Mod_MD.Recalque_202[indice].Entrada_digital[3] % 256);
				Comunicacao.Buffer_cmd[41] = (byte)(Mod_MD.Recalque_202[indice].Entrada_digital[4] / 256);
				Comunicacao.Buffer_cmd[42] = (byte)(Mod_MD.Recalque_202[indice].Entrada_digital[4] % 256);
				Comunicacao.Buffer_cmd[43] = (byte)(Mod_MD.Recalque_202[indice].Entrada_digital[5] / 256);
				Comunicacao.Buffer_cmd[44] = (byte)(Mod_MD.Recalque_202[indice].Entrada_digital[5] % 256);
				Comunicacao.Buffer_cmd[45] = (byte)(Mod_MD.Recalque_202[indice].Entrada_digital[6] / 256);
				Comunicacao.Buffer_cmd[46] = (byte)(Mod_MD.Recalque_202[indice].Entrada_digital[6] % 256);
				Comunicacao.Buffer_cmd[47] = (byte)(Mod_MD.Recalque_202[indice].Entrada_digital[7] / 256);
				Comunicacao.Buffer_cmd[48] = (byte)(Mod_MD.Recalque_202[indice].Entrada_digital[7] % 256);
				Comunicacao.Buffer_cmd[49] = (byte)(Mod_MD.Recalque_202[indice].Entrada_digital[8] / 256);
				Comunicacao.Buffer_cmd[50] = (byte)(Mod_MD.Recalque_202[indice].Entrada_digital[8] % 256);
				Comunicacao.Buffer_cmd[51] = (byte)(Mod_MD.Recalque_202[indice].Set_nivel_desejado * num / 256);
				Comunicacao.Buffer_cmd[52] = (byte)(Mod_MD.Recalque_202[indice].Set_nivel_desejado * num % 256);
				Comunicacao.Buffer_cmd[53] = (byte)(Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba1 * num / 256);
				Comunicacao.Buffer_cmd[54] = (byte)(Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba1 * num % 256);
				Comunicacao.Buffer_cmd[55] = (byte)(Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba2 * num / 256);
				Comunicacao.Buffer_cmd[56] = (byte)(Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba2 * num % 256);
				Comunicacao.Buffer_cmd[57] = (byte)(Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba3 * num / 256);
				Comunicacao.Buffer_cmd[58] = (byte)(Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba3 * num % 256);
				Comunicacao.Buffer_cmd[59] = (byte)(Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba4 * num / 256);
				Comunicacao.Buffer_cmd[60] = (byte)(Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba4 * num % 256);
				Comunicacao.Buffer_cmd[61] = (byte)(Mod_MD.Recalque_202[indice].Tempo_mais_bomba / 256);
				Comunicacao.Buffer_cmd[62] = (byte)(Mod_MD.Recalque_202[indice].Tempo_mais_bomba % 256);
				Comunicacao.Buffer_cmd[63] = (byte)(Mod_MD.Recalque_202[indice].Pressao_min_succao * num / 256);
				Comunicacao.Buffer_cmd[64] = (byte)(Mod_MD.Recalque_202[indice].Pressao_min_succao * num % 256);
				Comunicacao.Buffer_cmd[65] = (byte)(Mod_MD.Recalque_202[indice].Pressao_min_recalque * num / 256);
				Comunicacao.Buffer_cmd[66] = (byte)(Mod_MD.Recalque_202[indice].Pressao_min_recalque * num % 256);
				Comunicacao.Buffer_cmd[67] = (byte)(Mod_MD.Recalque_202[indice].Nivel_protecao_desliga * num / 256);
				Comunicacao.Buffer_cmd[68] = (byte)(Mod_MD.Recalque_202[indice].Nivel_protecao_desliga * num % 256);
				Comunicacao.Buffer_cmd[69] = (byte)(Mod_MD.Recalque_202[indice].Nivel_protecao_liga * num / 256);
				Comunicacao.Buffer_cmd[70] = (byte)(Mod_MD.Recalque_202[indice].Nivel_protecao_liga * num % 256);
				Comunicacao.Buffer_cmd[71] = (byte)(Mod_MD.Recalque_202[indice].Tempo_partida[1] / 256);
				Comunicacao.Buffer_cmd[72] = (byte)(Mod_MD.Recalque_202[indice].Tempo_partida[1] % 256);
				Comunicacao.Buffer_cmd[73] = (byte)(Mod_MD.Recalque_202[indice].Tempo_partida[2] / 256);
				Comunicacao.Buffer_cmd[74] = (byte)(Mod_MD.Recalque_202[indice].Tempo_partida[2] % 256);
				Comunicacao.Buffer_cmd[75] = (byte)(Mod_MD.Recalque_202[indice].Tempo_partida[3] / 256);
				Comunicacao.Buffer_cmd[76] = (byte)(Mod_MD.Recalque_202[indice].Tempo_partida[3] % 256);
				Comunicacao.Buffer_cmd[77] = (byte)(Mod_MD.Recalque_202[indice].Tempo_partida[4] / 256);
				Comunicacao.Buffer_cmd[78] = (byte)(Mod_MD.Recalque_202[indice].Tempo_partida[4] % 256);
				Comunicacao.Buffer_cmd[79] = (byte)(Mod_MD.Recalque_202[indice].Tempo_parada[1] / 256);
				Comunicacao.Buffer_cmd[80] = (byte)(Mod_MD.Recalque_202[indice].Tempo_parada[1] % 256);
				Comunicacao.Buffer_cmd[81] = (byte)(Mod_MD.Recalque_202[indice].Tempo_parada[2] / 256);
				Comunicacao.Buffer_cmd[82] = (byte)(Mod_MD.Recalque_202[indice].Tempo_parada[2] % 256);
				Comunicacao.Buffer_cmd[83] = (byte)(Mod_MD.Recalque_202[indice].Tempo_parada[3] / 256);
				Comunicacao.Buffer_cmd[84] = (byte)(Mod_MD.Recalque_202[indice].Tempo_parada[3] % 256);
				Comunicacao.Buffer_cmd[85] = (byte)(Mod_MD.Recalque_202[indice].Tempo_parada[4] / 256);
				Comunicacao.Buffer_cmd[86] = (byte)(Mod_MD.Recalque_202[indice].Tempo_parada[4] % 256);
				Comunicacao.Buffer_cmd[87] = (byte)(Mod_MD.Recalque_202[indice].Tempo_abertura_val[1] / 256);
				Comunicacao.Buffer_cmd[88] = (byte)(Mod_MD.Recalque_202[indice].Tempo_abertura_val[1] % 256);
				Comunicacao.Buffer_cmd[89] = (byte)(Mod_MD.Recalque_202[indice].Tempo_abertura_val[2] / 256);
				Comunicacao.Buffer_cmd[90] = (byte)(Mod_MD.Recalque_202[indice].Tempo_abertura_val[2] % 256);
				Comunicacao.Buffer_cmd[91] = (byte)(Mod_MD.Recalque_202[indice].Tempo_abertura_val[3] / 256);
				Comunicacao.Buffer_cmd[92] = (byte)(Mod_MD.Recalque_202[indice].Tempo_abertura_val[3] % 256);
				Comunicacao.Buffer_cmd[93] = (byte)(Mod_MD.Recalque_202[indice].Tempo_abertura_val[4] / 256);
				Comunicacao.Buffer_cmd[94] = (byte)(Mod_MD.Recalque_202[indice].Tempo_abertura_val[4] % 256);
				Comunicacao.Buffer_cmd[95] = (byte)(Mod_MD.Recalque_202[indice].Tempo_fechamento_val[1] / 256);
				Comunicacao.Buffer_cmd[96] = (byte)(Mod_MD.Recalque_202[indice].Tempo_fechamento_val[1] % 256);
				Comunicacao.Buffer_cmd[97] = (byte)(Mod_MD.Recalque_202[indice].Tempo_fechamento_val[2] / 256);
				Comunicacao.Buffer_cmd[98] = (byte)(Mod_MD.Recalque_202[indice].Tempo_fechamento_val[2] % 256);
				Comunicacao.Buffer_cmd[99] = (byte)(Mod_MD.Recalque_202[indice].Tempo_fechamento_val[3] / 256);
				Comunicacao.Buffer_cmd[100] = (byte)(Mod_MD.Recalque_202[indice].Tempo_fechamento_val[3] % 256);
				Comunicacao.Buffer_cmd[101] = (byte)(Mod_MD.Recalque_202[indice].Tempo_fechamento_val[4] / 256);
				Comunicacao.Buffer_cmd[102] = (byte)(Mod_MD.Recalque_202[indice].Tempo_fechamento_val[4] % 256);
				Comunicacao.Buffer_cmd[103] = (byte)(Mod_MD.Recalque_202[indice].Tempo_entre_acionamento / 256);
				Comunicacao.Buffer_cmd[104] = (byte)(Mod_MD.Recalque_202[indice].Tempo_entre_acionamento % 256);
				Comunicacao.Buffer_cmd[105] = (byte)(Mod_MD.Recalque_202[indice].Num_bombas_simultaneas / 256);
				Comunicacao.Buffer_cmd[106] = (byte)(Mod_MD.Recalque_202[indice].Num_bombas_simultaneas % 256);
				Comunicacao.Buffer_cmd[107] = (byte)(Mod_MD.Recalque_202[indice].Controle_nivel_fonte / 256);
				Comunicacao.Buffer_cmd[108] = (byte)(Mod_MD.Recalque_202[indice].Controle_nivel_fonte % 256);
				Comunicacao.Buffer_cmd[109] = (byte)(Mod_MD.Recalque_202[indice].Num_totalizacoes / 256);
				Comunicacao.Buffer_cmd[110] = (byte)(Mod_MD.Recalque_202[indice].Num_totalizacoes % 256);
				string versao2 = Geral.Config_geral.Versao;
				if (Operators.CompareString(versao2, "820_10", false) == 0)
				{
					Comunicacao.Buffer_cmd[111] = (byte)Mod_MD.Recalque_202[indice].Periferico_End_1;
					Comunicacao.Buffer_cmd[112] = (byte)Mod_MD.Recalque_202[indice].Periferico_Tipo_1;
					int num3 = 0;
					if (Comunicacao.Buffer_cmd[112] != 0)
					{
						byte[] buffer_cmd = Comunicacao.Buffer_cmd;
						byte[] array = buffer_cmd;
						num3 = 112;
						array[num3] = buffer_cmd[num3] + 50;
					}
					Comunicacao.Buffer_cmd[113] = (byte)Mod_MD.Recalque_202[indice].Periferico_End_2;
					Comunicacao.Buffer_cmd[114] = (byte)Mod_MD.Recalque_202[indice].Periferico_Tipo_2;
					if (Comunicacao.Buffer_cmd[114] != 0)
					{
						byte[] buffer_cmd = Comunicacao.Buffer_cmd;
						byte[] array2 = buffer_cmd;
						num3 = 114;
						array2[num3] = buffer_cmd[num3] + 51;
					}
					Comunicacao.Buffer_cmd[115] = (byte)Mod_MD.Recalque_202[indice].Periferico_End_3;
					Comunicacao.Buffer_cmd[116] = (byte)Mod_MD.Recalque_202[indice].Periferico_Tipo_3;
					if (Comunicacao.Buffer_cmd[116] != 0)
					{
						byte[] buffer_cmd = Comunicacao.Buffer_cmd;
						byte[] array3 = buffer_cmd;
						num3 = 116;
						array3[num3] = buffer_cmd[num3] + 51;
					}
					Comunicacao.Buffer_cmd[117] = (byte)Mod_MD.Recalque_202[indice].Periferico_End_4;
					Comunicacao.Buffer_cmd[118] = (byte)Mod_MD.Recalque_202[indice].Periferico_Tipo_4;
					if (Comunicacao.Buffer_cmd[118] != 0)
					{
						byte[] buffer_cmd = Comunicacao.Buffer_cmd;
						byte[] array4 = buffer_cmd;
						num3 = 118;
						array4[num3] = buffer_cmd[num3] + 51;
					}
					num3 = 119;
					int num4 = Comunicacao.Crc16_TX(ref num3);
					Comunicacao.Buffer_cmd[119] = (byte)(num4 % 256);
					Comunicacao.Buffer_cmd[120] = (byte)(num4 / 256);
					Comunicacao.Ctrl_Com.Cont_tx = 121;
				}
				else
				{
					int num3 = 111;
					int num4 = Comunicacao.Crc16_TX(ref num3);
					Comunicacao.Buffer_cmd[111] = (byte)(num4 % 256);
					Comunicacao.Buffer_cmd[112] = (byte)(num4 / 256);
					Comunicacao.Ctrl_Com.Cont_tx = 113;
				}
				Comunicacao.Escreve_dados_buffer_ouvidor(2, " Comando de escrita da página 1 ");
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x002583DC File Offset: 0x002567DC
		public static bool CMD_Esc_MD202_pagina_2(int endereco, int indice)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 2;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 52;
				Comunicacao.Buffer_cmd[6] = 104;
				Comunicacao.Buffer_cmd[7] = 0;
				Comunicacao.Buffer_cmd[8] = (byte)Mod_MD.Recalque_202[indice].End_repetidora;
				Comunicacao.Buffer_cmd[9] = 0;
				Comunicacao.Buffer_cmd[10] = (byte)Mod_MD.Recalque_202[indice].Num_repetidoras;
				int num = 1;
				do
				{
					Comunicacao.Buffer_cmd[9 + num * 2] = (byte)(Mod_MD.Recalque_202[indice].Repetidoras[num] / 256);
					Comunicacao.Buffer_cmd[10 + num * 2] = (byte)(Mod_MD.Recalque_202[indice].Repetidoras[num] % 256);
					num++;
				}
				while (num <= 50);
				int num2 = 111;
				int num3 = Comunicacao.Crc16_TX(ref num2);
				Comunicacao.Buffer_cmd[111] = (byte)(num3 % 256);
				Comunicacao.Buffer_cmd[112] = (byte)(num3 / 256);
				Comunicacao.Ctrl_Com.Cont_tx = 113;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, " Comando de escrita da página 2 ");
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x00258540 File Offset: 0x00256940
		public static bool CMD_Esc_MD202_pagina_3(int endereco_equip, int endereco_memoria, int dado)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco_equip;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(endereco_memoria / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(endereco_memoria % 256);
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 1;
				Comunicacao.Buffer_cmd[6] = 2;
				Comunicacao.Buffer_cmd[7] = (byte)(dado / 256);
				Comunicacao.Buffer_cmd[8] = (byte)(dado % 256);
				int num = 9;
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[9] = (byte)(num2 % 256);
				Comunicacao.Buffer_cmd[10] = (byte)(num2 / 256);
				Comunicacao.Ctrl_Com.Cont_tx = 11;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, " Comando de escrita da página 3 - calibração ");
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x00258638 File Offset: 0x00256A38
		public static bool CMD_Esc_MD302_pagina_1(int endereco, int indice)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 1;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 14;
				Comunicacao.Buffer_cmd[6] = 28;
				Comunicacao.Buffer_cmd[7] = 0;
				Comunicacao.Buffer_cmd[8] = (byte)Mod_MD.Central_302_geral.Endereco;
				Comunicacao.Buffer_cmd[9] = 0;
				Comunicacao.Buffer_cmd[10] = (byte)Mod_MD.Central_302_geral.Retray;
				Comunicacao.Buffer_cmd[11] = (byte)(Mod_MD.Central_302_geral.Timeout / 256);
				Comunicacao.Buffer_cmd[12] = (byte)(Mod_MD.Central_302_geral.Timeout % 256);
				Comunicacao.Buffer_cmd[13] = (byte)(Mod_MD.Central_302_geral.Tempo_ptt / 256);
				Comunicacao.Buffer_cmd[14] = (byte)(Mod_MD.Central_302_geral.Tempo_ptt % 256);
				Comunicacao.Buffer_cmd[15] = (byte)(Mod_MD.Central_302_geral.Baud_rate_com2 / 256);
				Comunicacao.Buffer_cmd[16] = (byte)(Mod_MD.Central_302_geral.Baud_rate_com2 % 256);
				Comunicacao.Buffer_cmd[17] = 0;
				Comunicacao.Buffer_cmd[18] = (byte)Mod_MD.Central_302_geral.Erros_falha;
				Comunicacao.Buffer_cmd[19] = 0;
				Comunicacao.Buffer_cmd[20] = (byte)Mod_MD.Central_302_geral.Intervalo_polling;
				Comunicacao.Buffer_cmd[21] = 0;
				Comunicacao.Buffer_cmd[22] = (byte)Mod_MD.Central_302_geral.Qtd_res;
				Comunicacao.Buffer_cmd[23] = 0;
				Comunicacao.Buffer_cmd[24] = (byte)Mod_MD.Central_302_geral.Qtd_equip_res;
				Comunicacao.Buffer_cmd[25] = 0;
				Comunicacao.Buffer_cmd[26] = (byte)Mod_MD.Central_302_geral.Qdt_equip_rq;
				Comunicacao.Buffer_cmd[27] = 0;
				Comunicacao.Buffer_cmd[28] = (byte)Mod_MD.Central_302_geral.Qtd_equip_vista;
				Comunicacao.Buffer_cmd[29] = 0;
				Comunicacao.Buffer_cmd[30] = (byte)Mod_MD.Central_302_geral.End_ini_equip_res;
				Comunicacao.Buffer_cmd[31] = 0;
				Comunicacao.Buffer_cmd[32] = (byte)Mod_MD.Central_302_geral.End_ini_equip_rq;
				Comunicacao.Buffer_cmd[33] = 0;
				Comunicacao.Buffer_cmd[34] = (byte)Mod_MD.Central_302_geral.End_ini_equip_vista;
				int num = 35;
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[35] = (byte)(num2 % 256);
				Comunicacao.Buffer_cmd[36] = (byte)(num2 / 256);
				Comunicacao.Ctrl_Com.Cont_tx = 37;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, " Comando de escrita da página 1 ");
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x002588D0 File Offset: 0x00256CD0
		public static bool CMD_Esc_MD302_pagina_2X(int endereco, string indice)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (Operators.CompareString(indice, "2A", false) == 0)
			{
				num = 512;
				num2 = 80;
				num3 = 0;
			}
			else if (Operators.CompareString(indice, "2B", false) == 0)
			{
				num = 592;
				num2 = 80;
				num3 = 20;
			}
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(num / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(num % 256);
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = (byte)num2;
				Comunicacao.Buffer_cmd[6] = (byte)(num2 * 2);
				int num4 = 1;
				do
				{
					int num5 = (num4 - 1) * 8;
					Comunicacao.Buffer_cmd[7 + num5] = 0;
					Comunicacao.Buffer_cmd[8 + num5] = (byte)Mod_MD.Central_302_res[num4 + num3].Res_relativo;
					Comunicacao.Buffer_cmd[9 + num5] = 0;
					Comunicacao.Buffer_cmd[10 + num5] = (byte)Mod_MD.Central_302_res[num4 + num3].Prioridade;
					Comunicacao.Buffer_cmd[11 + num5] = (byte)(Mod_MD.Central_302_res[num4 + num3].Altura / 256);
					Comunicacao.Buffer_cmd[12 + num5] = (byte)(Mod_MD.Central_302_res[num4 + num3].Altura % 256);
					Comunicacao.Buffer_cmd[13 + num5] = (byte)(Mod_MD.Central_302_res[num4 + num3].Msg / 256);
					Comunicacao.Buffer_cmd[14 + num5] = (byte)(Mod_MD.Central_302_res[num4 + num3].Msg % 256);
					num4++;
				}
				while (num4 <= 20);
				int num6 = 167;
				int num7 = Comunicacao.Crc16_TX(ref num6);
				Comunicacao.Buffer_cmd[167] = (byte)(num7 % 256);
				Comunicacao.Buffer_cmd[168] = (byte)(num7 / 256);
				Comunicacao.Ctrl_Com.Cont_tx = 169;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, " Comando de escrita da página 2 ");
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x00258AF4 File Offset: 0x00256EF4
		public static bool CMD_Esc_MD302_pagina_3_4_5_6X(int endereco, string indice)
		{
			string text = "";
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4;
			if (Operators.CompareString(indice, "3A", false) == 0)
			{
				num = 768;
				num2 = 120;
				num3 = 0;
				num4 = 4;
				text = "3A";
			}
			else if (Operators.CompareString(indice, "3B", false) == 0)
			{
				num = 888;
				num2 = 90;
				num3 = 4;
				num4 = 3;
				text = "3B";
			}
			else if (Operators.CompareString(indice, "4A", false) == 0)
			{
				num = 1024;
				num2 = 120;
				num3 = 7;
				num4 = 4;
				text = "4A";
			}
			else if (Operators.CompareString(indice, "4B", false) == 0)
			{
				num = 1144;
				num2 = 90;
				num3 = 11;
				num4 = 3;
				text = "4B";
			}
			else if (Operators.CompareString(indice, "5A", false) == 0)
			{
				num = 1280;
				num2 = 120;
				num3 = 14;
				num4 = 4;
				text = "5A";
			}
			else if (Operators.CompareString(indice, "5B", false) == 0)
			{
				num = 1400;
				num2 = 90;
				num3 = 18;
				num4 = 3;
				text = "5B";
			}
			else if (Operators.CompareString(indice, "6A", false) == 0)
			{
				num = 1536;
				num2 = 120;
				num3 = 21;
				num4 = 4;
				text = "6A";
			}
			else if (Operators.CompareString(indice, "6B", false) == 0)
			{
				num = 1656;
				num2 = 90;
				num3 = 25;
				num4 = 3;
				text = "6B";
			}
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(num / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(num % 256);
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = (byte)num2;
				Comunicacao.Buffer_cmd[6] = (byte)(num2 * 2);
				int num5 = 1;
				int num6 = num4;
				int num7;
				for (int i = num5; i <= num6; i++)
				{
					num7 = (i - 1) * 60;
					Comunicacao.Buffer_cmd[7 + num7] = 0;
					Comunicacao.Buffer_cmd[8 + num7] = (byte)Mod_MD.Central_302_rq[i + num3].Res_origem;
					Comunicacao.Buffer_cmd[9 + num7] = 0;
					Comunicacao.Buffer_cmd[10 + num7] = (byte)Mod_MD.Central_302_rq[i + num3].Res_destino;
					Comunicacao.Buffer_cmd[11 + num7] = 0;
					Comunicacao.Buffer_cmd[12 + num7] = (byte)Mod_MD.Central_302_rq[i + num3].Res_relativo_R1;
					Comunicacao.Buffer_cmd[13 + num7] = 0;
					Comunicacao.Buffer_cmd[14 + num7] = (byte)Mod_MD.Central_302_rq[i + num3].Res_relativo_R2;
					Comunicacao.Buffer_cmd[15 + num7] = 0;
					Comunicacao.Buffer_cmd[16 + num7] = (byte)Mod_MD.Central_302_rq[i + num3].Res_relativo_R3;
					Comunicacao.Buffer_cmd[17 + num7] = 0;
					Comunicacao.Buffer_cmd[18 + num7] = (byte)Mod_MD.Central_302_rq[i + num3].Res_relativo_R4;
					Comunicacao.Buffer_cmd[19 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].Msg_res_R1 / 256);
					Comunicacao.Buffer_cmd[20 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].Msg_res_R1 % 256);
					Comunicacao.Buffer_cmd[21 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].Msg_res_R2 / 256);
					Comunicacao.Buffer_cmd[22 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].Msg_res_R2 % 256);
					Comunicacao.Buffer_cmd[23 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].Msg_res_R3 / 256);
					Comunicacao.Buffer_cmd[24 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].Msg_res_R3 % 256);
					Comunicacao.Buffer_cmd[25 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].Msg_res_R4 / 256);
					Comunicacao.Buffer_cmd[26 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].Msg_res_R4 % 256);
					Comunicacao.Buffer_cmd[27 + num7] = 0;
					Comunicacao.Buffer_cmd[28 + num7] = (byte)Mod_MD.Central_302_rq[i + num3].modelo;
					Comunicacao.Buffer_cmd[29 + num7] = 0;
					Comunicacao.Buffer_cmd[30 + num7] = (byte)Mod_MD.Central_302_rq[i + num3].Prioridade;
					Comunicacao.Buffer_cmd[31 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].Msg / 256);
					Comunicacao.Buffer_cmd[32 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].Msg % 256);
					Comunicacao.Buffer_cmd[33 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].Hab_cmd / 256);
					Comunicacao.Buffer_cmd[34 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].Hab_cmd % 256);
					Comunicacao.Buffer_cmd[35 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_1 / 256);
					Comunicacao.Buffer_cmd[36 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_1 % 256);
					Comunicacao.Buffer_cmd[37 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_2 / 256);
					Comunicacao.Buffer_cmd[38 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_2 % 256);
					Comunicacao.Buffer_cmd[39 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_3 / 256);
					Comunicacao.Buffer_cmd[40 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_3 % 256);
					Comunicacao.Buffer_cmd[41 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_4 / 256);
					Comunicacao.Buffer_cmd[42 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_4 % 256);
					Comunicacao.Buffer_cmd[43 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_5 / 256);
					Comunicacao.Buffer_cmd[44 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_5 % 256);
					Comunicacao.Buffer_cmd[45 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_6 / 256);
					Comunicacao.Buffer_cmd[46 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_6 % 256);
					Comunicacao.Buffer_cmd[47 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_7 / 256);
					Comunicacao.Buffer_cmd[48 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_7 % 256);
					Comunicacao.Buffer_cmd[49 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_8 / 256);
					Comunicacao.Buffer_cmd[50 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_8 % 256);
					Comunicacao.Buffer_cmd[51 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_9 / 256);
					Comunicacao.Buffer_cmd[52 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_9 % 256);
					Comunicacao.Buffer_cmd[53 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_10 / 256);
					Comunicacao.Buffer_cmd[54 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_10 % 256);
					Comunicacao.Buffer_cmd[55 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_11 / 256);
					Comunicacao.Buffer_cmd[56 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_11 % 256);
					Comunicacao.Buffer_cmd[57 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_12 / 256);
					Comunicacao.Buffer_cmd[58 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_12 % 256);
					Comunicacao.Buffer_cmd[59 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_13 / 256);
					Comunicacao.Buffer_cmd[60 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_13 % 256);
					Comunicacao.Buffer_cmd[61 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_14 / 256);
					Comunicacao.Buffer_cmd[62 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_14 % 256);
					Comunicacao.Buffer_cmd[63 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_15 / 256);
					Comunicacao.Buffer_cmd[64 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_15 % 256);
					Comunicacao.Buffer_cmd[65 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_16 / 256);
					Comunicacao.Buffer_cmd[66 + num7] = (byte)(Mod_MD.Central_302_rq[i + num3].escala_16 % 256);
				}
				num7 = num2 * 2 + 7;
				int num8 = Comunicacao.Crc16_TX(ref num7);
				Comunicacao.Buffer_cmd[num7] = (byte)(num8 % 256);
				Comunicacao.Buffer_cmd[num7 + 1] = (byte)(num8 / 256);
				Comunicacao.Ctrl_Com.Cont_tx = num7 + 2;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, " Comando de escrita da página " + text);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x00259510 File Offset: 0x00257910
		public static bool CMD_Esc_MD302_pagina_7X(int endereco, string indice)
		{
			string text = "";
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4;
			if (Operators.CompareString(indice, "7A", false) == 0)
			{
				num = 1792;
				num2 = 86;
				num3 = 0;
				num4 = 2;
				text = "7A";
			}
			else if (Operators.CompareString(indice, "7B", false) == 0)
			{
				num = 1878;
				num2 = 86;
				num3 = 2;
				num4 = 2;
				text = "7B";
			}
			else if (Operators.CompareString(indice, "7C", false) == 0)
			{
				num = 1964;
				num2 = 43;
				num3 = 4;
				num4 = 1;
				text = "7C";
			}
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(num / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(num % 256);
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = (byte)num2;
				Comunicacao.Buffer_cmd[6] = (byte)(num2 * 2);
				int num5 = 1;
				int num6 = num4;
				int num7;
				for (int i = num5; i <= num6; i++)
				{
					num7 = (i - 1) * 86;
					Comunicacao.Buffer_cmd[7 + num7] = 0;
					Comunicacao.Buffer_cmd[8 + num7] = (byte)Mod_MD.Central_302_centrais[i + num3].num_res;
					Comunicacao.Buffer_cmd[9 + num7] = 0;
					Comunicacao.Buffer_cmd[10 + num7] = (byte)Mod_MD.Central_302_centrais[i + num3].num_rq;
					Comunicacao.Buffer_cmd[11 + num7] = 0;
					Comunicacao.Buffer_cmd[12 + num7] = (byte)Mod_MD.Central_302_centrais[i + num3].prioridade;
					int num8 = 0;
					do
					{
						endereco = num7 + num8 * 2;
						Comunicacao.Buffer_cmd[13 + endereco] = 0;
						Comunicacao.Buffer_cmd[14 + endereco] = (byte)Mod_MD.Central_302_indices[i + num3, num8 + 1];
						num8++;
					}
					while (num8 <= 39);
				}
				num7 = num2 * 2 + 7;
				int num9 = Comunicacao.Crc16_TX(ref num7);
				Comunicacao.Buffer_cmd[num7] = (byte)(num9 % 256);
				Comunicacao.Buffer_cmd[num7 + 1] = (byte)(num9 / 256);
				Comunicacao.Ctrl_Com.Cont_tx = num7 + 2;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, " Comando de escrita da página " + text);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x00259760 File Offset: 0x00257B60
		public static bool CMD_Esc_MD303_pagina_1(int endereco, int indice)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 1;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 6;
				Comunicacao.Buffer_cmd[6] = 12;
				Comunicacao.Buffer_cmd[7] = 0;
				Comunicacao.Buffer_cmd[8] = (byte)Mod_MD.Central_303_geral.Endereco_mestre;
				Comunicacao.Buffer_cmd[9] = 0;
				Comunicacao.Buffer_cmd[10] = (byte)Mod_MD.Central_303_geral.Endereco_estacao;
				Comunicacao.Buffer_cmd[11] = (byte)(Mod_MD.Central_303_geral.Tempo_ptt / 256);
				Comunicacao.Buffer_cmd[12] = (byte)(Mod_MD.Central_303_geral.Tempo_ptt % 256);
				Comunicacao.Buffer_cmd[13] = (byte)(Mod_MD.Central_303_geral.Baud_rate_com2 / 256);
				Comunicacao.Buffer_cmd[14] = (byte)(Mod_MD.Central_303_geral.Baud_rate_com2 % 256);
				Comunicacao.Buffer_cmd[15] = 0;
				Comunicacao.Buffer_cmd[16] = (byte)Mod_MD.Central_303_geral.Qtd_equip_res;
				Comunicacao.Buffer_cmd[17] = 0;
				Comunicacao.Buffer_cmd[18] = (byte)Mod_MD.Central_303_geral.Qdt_equip_rq;
				int num = 19;
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[19] = (byte)(num2 % 256);
				Comunicacao.Buffer_cmd[20] = (byte)(num2 / 256);
				Comunicacao.Ctrl_Com.Cont_tx = 21;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, " Comando de escrita da página 1 ");
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x00259900 File Offset: 0x00257D00
		public static bool CMD_Esc_MD303_pagina_2(int endereco)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 2;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 40;
				Comunicacao.Buffer_cmd[6] = 80;
				int num = 1;
				do
				{
					int num2 = (num - 1) * 2;
					Comunicacao.Buffer_cmd[7 + num2] = 0;
					Comunicacao.Buffer_cmd[8 + num2] = (byte)Mod_MD.Central_303_res[num].Msg;
					num++;
				}
				while (num <= 40);
				int num3 = 87;
				int num4 = Comunicacao.Crc16_TX(ref num3);
				Comunicacao.Buffer_cmd[87] = (byte)(num4 % 256);
				Comunicacao.Buffer_cmd[88] = (byte)(num4 / 256);
				Comunicacao.Ctrl_Com.Cont_tx = 89;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, " Comando de escrita da página 2 ");
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x00259A04 File Offset: 0x00257E04
		public static bool CMD_Esc_MD303_pagina_3_4_5_6X(int endereco, string indice)
		{
			string text = "";
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4;
			if (Operators.CompareString(indice, "3A", false) == 0)
			{
				num = 768;
				num2 = 76;
				num3 = 0;
				num4 = 4;
				text = "3A";
			}
			else if (Operators.CompareString(indice, "3B", false) == 0)
			{
				num = 844;
				num2 = 57;
				num3 = 4;
				num4 = 3;
				text = "3B";
			}
			else if (Operators.CompareString(indice, "4A", false) == 0)
			{
				num = 1024;
				num2 = 76;
				num3 = 0;
				num4 = 4;
				text = "4A";
			}
			else if (Operators.CompareString(indice, "4B", false) == 0)
			{
				num = 1100;
				num2 = 57;
				num3 = 4;
				num4 = 3;
				text = "4B";
			}
			else if (Operators.CompareString(indice, "5A", false) == 0)
			{
				num = 1280;
				num2 = 76;
				num3 = 0;
				num4 = 4;
				text = "5A";
			}
			else if (Operators.CompareString(indice, "5B", false) == 0)
			{
				num = 1356;
				num2 = 57;
				num3 = 4;
				num4 = 3;
				text = "5B";
			}
			else if (Operators.CompareString(indice, "6A", false) == 0)
			{
				num = 1536;
				num2 = 76;
				num3 = 0;
				num4 = 4;
				text = "6A";
			}
			else if (Operators.CompareString(indice, "6B", false) == 0)
			{
				num = 1612;
				num2 = 57;
				num3 = 4;
				num4 = 3;
				text = "6B";
			}
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(num / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(num % 256);
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = (byte)num2;
				Comunicacao.Buffer_cmd[6] = (byte)(num2 * 2);
				int num5 = 1;
				int num6 = num4;
				int num7;
				for (int i = num5; i <= num6; i++)
				{
					num7 = (i - 1) * 38;
					Comunicacao.Buffer_cmd[7 + num7] = 0;
					Comunicacao.Buffer_cmd[8 + num7] = (byte)Mod_MD.Central_303_rq[i + num3].modelo;
					Comunicacao.Buffer_cmd[9 + num7] = 0;
					Comunicacao.Buffer_cmd[10 + num7] = (byte)Mod_MD.Central_303_rq[i + num3].Msg;
					Comunicacao.Buffer_cmd[11 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].Hab_cmd / 256);
					Comunicacao.Buffer_cmd[12 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].Hab_cmd % 256);
					Comunicacao.Buffer_cmd[13 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_1 / 256);
					Comunicacao.Buffer_cmd[14 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_1 % 256);
					Comunicacao.Buffer_cmd[15 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_2 / 256);
					Comunicacao.Buffer_cmd[16 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_2 % 256);
					Comunicacao.Buffer_cmd[17 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_3 / 256);
					Comunicacao.Buffer_cmd[18 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_3 % 256);
					Comunicacao.Buffer_cmd[19 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_4 / 256);
					Comunicacao.Buffer_cmd[20 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_4 % 256);
					Comunicacao.Buffer_cmd[21 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_5 / 256);
					Comunicacao.Buffer_cmd[22 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_5 % 256);
					Comunicacao.Buffer_cmd[23 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_6 / 256);
					Comunicacao.Buffer_cmd[24 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_6 % 256);
					Comunicacao.Buffer_cmd[25 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_7 / 256);
					Comunicacao.Buffer_cmd[26 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_7 % 256);
					Comunicacao.Buffer_cmd[27 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_8 / 256);
					Comunicacao.Buffer_cmd[28 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_8 % 256);
					Comunicacao.Buffer_cmd[29 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_9 / 256);
					Comunicacao.Buffer_cmd[30 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_9 % 256);
					Comunicacao.Buffer_cmd[31 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_10 / 256);
					Comunicacao.Buffer_cmd[32 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_10 % 256);
					Comunicacao.Buffer_cmd[33 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_11 / 256);
					Comunicacao.Buffer_cmd[34 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_11 % 256);
					Comunicacao.Buffer_cmd[35 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_12 / 256);
					Comunicacao.Buffer_cmd[36 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_12 % 256);
					Comunicacao.Buffer_cmd[37 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_13 / 256);
					Comunicacao.Buffer_cmd[38 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_13 % 256);
					Comunicacao.Buffer_cmd[39 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_14 / 256);
					Comunicacao.Buffer_cmd[40 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_14 % 256);
					Comunicacao.Buffer_cmd[41 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_15 / 256);
					Comunicacao.Buffer_cmd[42 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_15 % 256);
					Comunicacao.Buffer_cmd[43 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_16 / 256);
					Comunicacao.Buffer_cmd[44 + num7] = (byte)(Mod_MD.Central_303_rq[i + num3].escala_16 % 256);
				}
				num7 = num2 * 2 + 7;
				int num8 = Comunicacao.Crc16_TX(ref num7);
				Comunicacao.Buffer_cmd[num7] = (byte)(num8 % 256);
				Comunicacao.Buffer_cmd[num7 + 1] = (byte)(num8 / 256);
				Comunicacao.Ctrl_Com.Cont_tx = num7 + 2;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, " Comando de escrita da página " + text);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x0025A1A8 File Offset: 0x002585A8
		public static bool CMD_Esc_MD303_pagina_9(int endereco, string indice)
		{
			string text = "";
			int num = 0;
			int num2 = 0;
			if (Operators.CompareString(indice, "9", false) == 0)
			{
				num = 1424;
				num2 = 1;
				text = "9";
			}
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(num / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(num % 256);
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = (byte)num2;
				Comunicacao.Buffer_cmd[6] = (byte)(num2 * 2);
				Comunicacao.Buffer_cmd[7] = (byte)(Mod_MD.Central_303_geral.Senha / 256);
				Comunicacao.Buffer_cmd[8] = (byte)(Mod_MD.Central_303_geral.Senha % 256);
				int num3 = num2 * 2 + 7;
				int num4 = Comunicacao.Crc16_TX(ref num3);
				Comunicacao.Buffer_cmd[num3] = (byte)(num4 % 256);
				Comunicacao.Buffer_cmd[num3 + 1] = (byte)(num4 / 256);
				Comunicacao.Ctrl_Com.Cont_tx = num3 + 2;
				Comunicacao.Escreve_dados_buffer_ouvidor(2, " Comando de escrita da página " + text);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, Comunicacao.Ctrl_Com.Cont_tx);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x0025A2F0 File Offset: 0x002586F0
		public static Mod_MD.CTRL_RESP_1 Controle_escrita(int tipo)
		{
			string text = "???";
			if (tipo == 21845 || tipo == 21840)
			{
				text = "Habilitação";
			}
			else if (tipo == 21930 || tipo == 21920)
			{
				text = "Gravação";
			}
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			Mod_MD.CTRL_RESP_1 result;
			result.Msg = "";
			result.Status = false;
			result.Cor = 1;
			checked
			{
				while (i > 0)
				{
					i--;
					Comunicacao.CMD_Esc_habilitacao(tipo, 255);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						result.Msg = text + " concluída";
						result.Cor = 0;
						result.Status = true;
						goto IL_15F;
					case 1:
						goto IL_12A;
					case 2:
						if (i == 0)
						{
							result.Msg = "Erro - Chksum na " + text;
							result.Cor = 1;
							result.Status = false;
						}
						break;
					case 3:
						if (i == 0)
						{
							result.Msg = "Erro - Timeout na " + text;
							result.Cor = 1;
							result.Status = false;
						}
						break;
					default:
											}
					IL_150:
					Comunicacao.Rotina_Delay(50L);
					continue;
					IL_12A:
					if (i == 0)
					{
						result.Msg = "Erro - não determinado na " + text;
						result.Cor = 1;
						result.Status = false;
											}
									}
				IL_15F:
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
				return result;
			}
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x0025A478 File Offset: 0x00258878
		public static Mod_MD.CTRL_RESP_1 Controle_escrita_multi_interface(int tipo)
		{
			string text = "???";
			if (tipo == 21845 || tipo == 21840)
			{
				text = "Habilitação";
			}
			else if (tipo == 21930 || tipo == 21920)
			{
				text = "Gravação";
			}
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			Mod_MD.CTRL_RESP_1 result;
			result.Msg = "";
			result.Status = false;
			result.Cor = 1;
			checked
			{
				while (i > 0)
				{
					i--;
					TcpClient tcpClient = new TcpClient();
					NetworkStream stream;
					if (Comunicacao.Config_sistema.tipo_interface != 1)
					{
						if (Comunicacao.Config_sistema.tipo_interface == 2)
						{
							try
							{
								tcpClient.Connect(Comunicacao.Config_sistema.Tcpip.IP, Comunicacao.Config_sistema.Tcpip.Porta);
								tcpClient.SendTimeout = 1000;
								tcpClient.ReceiveTimeout = 1000;
								stream = tcpClient.GetStream();
							}
							catch (Exception ex)
							{
								result.Msg = string.Concat(new string[]
								{
									"Sem Conexão com o servidor TCP/IP:   ",
									Comunicacao.Config_sistema.Tcpip.IP,
									":",
									Comunicacao.Config_sistema.Tcpip.Porta.ToString(),
									"   Erro Timeout - ao ler página "
								});
								result.Cor = 1;
								result.Status = false;
								return result;
							}
							Comunicacao.CMD_Esc_habilitacao_TCP(tipo, 255, stream);
													}
						result.Msg = "Não existe definição de tipo de interface de comunicação!";
						result.Cor = 1;
						result.Status = false;
						return result;
					}
					Comunicacao.CMD_Esc_habilitacao(tipo, 255);
					IL_1A3:
					if (Comunicacao.Config_sistema.tipo_interface == 1)
					{
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
					}
					else
					{
						Thread.Sleep(500);
					}
					if (Comunicacao.Config_sistema.tipo_interface == 2)
					{
						try
						{
							if (stream.CanRead)
							{
								byte[] array = new byte[4097];
								int num = stream.Read(array, 0, 4096);
								stream.Close();
								tcpClient.Close();
								if (num > 0)
								{
									Comunicacao.Ctrl_Com.Frame = 0;
									int num2 = (int)array[5];
									int num3 = 0;
									int num4 = num2 - 1;
									for (int j = num3; j <= num4; j++)
									{
										int num5 = 6 + j;
										Comunicacao.Buffer_resp[j] = array[num5];
									}
									if (num2 == 3 & (int)Comunicacao.Buffer_resp[0] == Comunicacao.Config_sistema.endereco_modbus & Comunicacao.Buffer_resp[1] > 128)
									{
										Comunicacao.Ctrl_Com.Frame = 30;
									}
									else
									{
										Comunicacao.Ctrl_Com.Frame = 0;
									}
								}
								else
								{
									Comunicacao.Config_sistema.endereco_modbus = 0;
									Comunicacao.Config_sistema.endereco_encontrado = false;
									Comunicacao.Ctrl_Com.Frame = 3;
								}
							}
						}
						catch (Exception ex2)
						{
							stream.Close();
							tcpClient.Close();
							Comunicacao.Ctrl_Com.Frame = 3;
						}
					}
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						result.Msg = text + " concluída";
						result.Cor = 0;
						result.Status = true;
						goto IL_3B9;
					case 1:
						goto IL_384;
					case 2:
						if (i == 0)
						{
							result.Msg = "Erro - Chksum na " + text;
							result.Cor = 1;
							result.Status = false;
						}
						break;
					case 3:
						if (i == 0)
						{
							result.Msg = "Erro - Timeout na " + text;
							result.Cor = 1;
							result.Status = false;
						}
						break;
					default:
											}
					IL_3AA:
					Comunicacao.Rotina_Delay(50L);
					continue;
					IL_384:
					if (i == 0)
					{
						result.Msg = "Erro - não determinado na " + text;
						result.Cor = 1;
						result.Status = false;
											}
									}
				IL_3B9:
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
				return result;
			}
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x0025A878 File Offset: 0x00258C78
		public static Mod_MD.CTRL_RESP_1 Escrita_pagina(int numero_pagina, int equipamento)
		{
			string text = "";
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			Mod_MD.CTRL_RESP_1 result;
			result.Msg = "";
			result.Status = false;
			result.Cor = 1;
			checked
			{
				while (i > 0)
				{
					i--;
					if (numero_pagina == 100)
					{
						text = "1";
						switch (equipamento)
						{
						case 1:
							Mod_MD.CMD_Esc_MD101_pagina_1(255, 1);
							break;
						case 2:
							Mod_MD.CMD_Esc_MD201_pagina_1(255, 1);
							break;
						case 3:
							Mod_MD.CMD_Esc_MD202_pagina_1(255, 1);
							break;
						case 4:
							Mod_MD.CMD_Esc_MD302_pagina_1(255, 1);
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_1(255, 1);
							break;
						}
					}
					else if (numero_pagina == 512)
					{
						text = "2";
						switch (equipamento)
						{
						case 1:
							Mod_MD.CMD_Esc_MD101_pagina_2(Mod_MD.Reservatorio[1].End_estacao, 1);
							break;
						case 2:
							Mod_MD.CMD_Esc_MD201_pagina_2(Mod_MD.Recalque_201[1].End_estacao, 1);
							break;
						case 3:
							Mod_MD.CMD_Esc_MD202_pagina_2(Mod_MD.Recalque_202[1].End_estacao, 1);
							break;
						case 4:
							text = "2-A";
							Mod_MD.CMD_Esc_MD302_pagina_2X(Mod_MD.Central_302_geral.Endereco, "2A");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_2(Mod_MD.Central_303_geral.Endereco_estacao);
							break;
						}
					}
					else if (numero_pagina == 592)
					{
						text = "2-B";
						if (equipamento == 4)
						{
							Mod_MD.CMD_Esc_MD302_pagina_2X(Mod_MD.Central_302_geral.Endereco, "2B");
						}
					}
					else if (numero_pagina == 768)
					{
						text = "3";
						switch (equipamento)
						{
						case 1:
							Mod_MD.CMD_Esc_MD202_pagina_3(Mod_MD.Ctrl_cal.End_equip, Mod_MD.Ctrl_cal.End_memoria, Mod_MD.Ctrl_cal.Dado);
							break;
						case 3:
							Mod_MD.CMD_Esc_MD202_pagina_3(Mod_MD.Ctrl_cal.End_equip, Mod_MD.Ctrl_cal.End_memoria, Mod_MD.Ctrl_cal.Dado);
							break;
						case 4:
							text = "3-A";
							Mod_MD.CMD_Esc_MD302_pagina_3_4_5_6X(Mod_MD.Central_302_geral.Endereco, "3A");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_3_4_5_6X(Mod_MD.Central_303_geral.Endereco_estacao, "3A");
							break;
						}
					}
					else if (numero_pagina == 888)
					{
						text = "3-B";
						switch (equipamento)
						{
						case 4:
							Mod_MD.CMD_Esc_MD302_pagina_3_4_5_6X(Mod_MD.Central_302_geral.Endereco, "3B");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_3_4_5_6X(Mod_MD.Central_303_geral.Endereco_estacao, "3B");
							break;
						}
					}
					else if (numero_pagina == 1024)
					{
						text = "4-A";
						switch (equipamento)
						{
						case 4:
							Mod_MD.CMD_Esc_MD302_pagina_3_4_5_6X(Mod_MD.Central_302_geral.Endereco, "4A");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_3_4_5_6X(Mod_MD.Central_303_geral.Endereco_estacao, "4A");
							break;
						}
					}
					else if (numero_pagina == 1144)
					{
						text = "4-B";
						switch (equipamento)
						{
						case 4:
							Mod_MD.CMD_Esc_MD302_pagina_3_4_5_6X(Mod_MD.Central_302_geral.Endereco, "4B");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_3_4_5_6X(Mod_MD.Central_303_geral.Endereco_estacao, "4B");
							break;
						}
					}
					else if (numero_pagina == 1280)
					{
						text = "5-A";
						switch (equipamento)
						{
						case 4:
							Mod_MD.CMD_Esc_MD302_pagina_3_4_5_6X(Mod_MD.Central_302_geral.Endereco, "5A");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_3_4_5_6X(Mod_MD.Central_303_geral.Endereco_estacao, "5A");
							break;
						}
					}
					else if (numero_pagina == 1400)
					{
						text = "5-B";
						switch (equipamento)
						{
						case 4:
							Mod_MD.CMD_Esc_MD302_pagina_3_4_5_6X(Mod_MD.Central_302_geral.Endereco, "5B");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_3_4_5_6X(Mod_MD.Central_303_geral.Endereco_estacao, "5B");
							break;
						}
					}
					else if (numero_pagina == 1536)
					{
						text = "6-A";
						switch (equipamento)
						{
						case 4:
							Mod_MD.CMD_Esc_MD302_pagina_3_4_5_6X(Mod_MD.Central_302_geral.Endereco, "6A");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_3_4_5_6X(Mod_MD.Central_303_geral.Endereco_estacao, "6A");
							break;
						}
					}
					else if (numero_pagina == 1656)
					{
						text = "6-B";
						switch (equipamento)
						{
						case 4:
							Mod_MD.CMD_Esc_MD302_pagina_3_4_5_6X(Mod_MD.Central_302_geral.Endereco, "6B");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_3_4_5_6X(Mod_MD.Central_303_geral.Endereco_estacao, "6B");
							break;
						}
					}
					else if (numero_pagina == 1792)
					{
						text = "7";
						if (equipamento == 4)
						{
							text = "7-A";
							Mod_MD.CMD_Esc_MD302_pagina_7X(Mod_MD.Central_302_geral.Endereco, "7A");
						}
					}
					else if (numero_pagina == 1878)
					{
						text = "7";
						if (equipamento == 4)
						{
							text = "7-B";
							Mod_MD.CMD_Esc_MD302_pagina_7X(Mod_MD.Central_302_geral.Endereco, "7B");
						}
					}
					else if (numero_pagina == 1964)
					{
						text = "7";
						if (equipamento == 4)
						{
							text = "7-C";
							Mod_MD.CMD_Esc_MD302_pagina_7X(Mod_MD.Central_302_geral.Endereco, "7C");
						}
					}
					else if (numero_pagina == 1424)
					{
						text = "9";
						if (equipamento == 5)
						{
							text = "9";
							Mod_MD.CMD_Esc_MD303_pagina_9(Mod_MD.Central_303_geral.Endereco_estacao, "9");
						}
					}
					else if (numero_pagina == 2048)
					{
						if (equipamento == 0)
						{
							Linha_RT.CMD_Esc_RT_810_H800(255);
						}
					}
					else if (numero_pagina == 4096)
					{
						if (equipamento == 0)
						{
							Linha_RT.CMD_Esc_RT_810_H1000(RT_geral.RT_810_BD.End_estacao.Valor);
						}
					}
					else if (numero_pagina == 8192)
					{
						if (equipamento == 0)
						{
							Linha_RT.CMD_Esc_RT_810_H2000(RT_geral.RT_810_BD.End_estacao.Valor);
						}
					}
					else if (numero_pagina == 10240 && equipamento == 0)
					{
						Linha_RT.CMD_Esc_RT_810_H2800(RT_geral.RT_810_BD.End_estacao.Valor);
					}
					if (equipamento == 70)
					{
						if (numero_pagina == 2048)
						{
							Linha_RT.CMD_Esc_GC_825x_DadosGerais(255);
						}
						else if (numero_pagina == 6144)
						{
							Linha_RT.CMD_Esc_GC_825x_Calibracao_SA(RT_geral.GC_82x_BD.End_estacao.Valor, RT_geral.GC_82x_BD.calib_canal, RT_geral.GC_82x_BD.calib_funcao);
						}
						else if (numero_pagina == 20480)
						{
							if (Operators.CompareString(RT_geral.GC_82x_BD.tipo_tipo_envio, "CONTAGEM", false) == 0)
							{
								Linha_RT.CMD_Esc_GC_825x_DADOS_DE_RX_CONTAGENS(RT_geral.GC_82x_BD.End_estacao.Valor);
							}
							else if (Operators.CompareString(RT_geral.GC_82x_BD.tipo_tipo_envio, "mA", false) == 0)
							{
								Linha_RT.CMD_Esc_GC_825x_DADOS_DE_RX_mA(RT_geral.GC_82x_BD.End_estacao.Valor, RT_geral.GC_82x_BD.corrente_canal1, RT_geral.GC_82x_BD.corrente_canal2);
							}
						}
					}
					if (equipamento == 20)
					{
						if (numero_pagina == 256)
						{
							Linha_RT.CMD_Esc_RT_810_200_CFG_GERAIS(255);
						}
						else if (numero_pagina == 512)
						{
							Linha_RT.CMD_Esc_RT_810_200_CFG_REPETIDORA(RT_geral.RT_810_200_BD.End_estacao.Valor);
						}
					}
					else if (equipamento == 30)
					{
						if (numero_pagina == 256)
						{
							Linha_RT.CMD_Esc_RT_820_200_CFG_GERAIS(255);
						}
						else if (numero_pagina == 512)
						{
							Linha_RT.CMD_Esc_RT_820_200_CFG_REPETIDORA(RT_geral.RT_820_200_BD.cfg_geral.End_estacao.Valor);
						}
						else if (numero_pagina == 2816)
						{
							Linha_RT.CMD_Esc_RT_820_200_CFG_SETPOINT_HORARIO(RT_geral.RT_820_200_BD.cfg_geral.End_estacao.Valor);
						}
					}
					else if (equipamento == 40)
					{
						if (numero_pagina == 256)
						{
							Linha_RT.CMD_Esc_RT_821_200_CFG_GERAIS(255);
						}
						else if (numero_pagina == 512)
						{
							Linha_RT.CMD_Esc_RT_821_200_CFG_REPETIDORA(RT_geral.RT_821_200_BD.cfg_geral.End_estacao.Valor);
						}
					}
					else if (equipamento == 50)
					{
						if (numero_pagina == 256)
						{
							Linha_RT.CMD_Esc_RT_830_200_CFG_GERAIS(255);
						}
						else if (numero_pagina == 512 || numero_pagina == 612)
						{
							Linha_RT.CMD_Esc_RT_830_200_RESERVATORIO(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor);
						}
						else if (numero_pagina != 768 && numero_pagina != 1024 && numero_pagina != 1280 && numero_pagina != 1536 && numero_pagina == 1792)
						{
						}
					}
					else if (equipamento == 60)
					{
						if (numero_pagina == 256)
						{
							Linha_RT.CMD_Esc_RT_831_200_CFG_GERAIS(255);
						}
						else if (numero_pagina == 512)
						{
							Linha_RT.CMD_Esc_RT_831_200_RESERVATORIO(RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor);
						}
						else if (numero_pagina == 2304)
						{
							Linha_RT.CMD_Esc_RT_831_200_SENHA(RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor);
						}
					}
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						result.Msg = "Programação página " + text;
						result.Cor = 0;
						result.Status = true;
						goto IL_A00;
					case 1:
						goto IL_9CB;
					case 2:
						if (i == 0)
						{
							result.Msg = "Erro chksum - ao programar página " + text;
							result.Cor = 1;
							result.Status = false;
						}
						break;
					case 3:
						if (i == 0)
						{
							result.Msg = "Erro Timeout - ao programar página " + text;
							result.Cor = 1;
							result.Status = false;
						}
						break;
					default:
											}
					IL_9F1:
					Comunicacao.Rotina_Delay(50L);
					continue;
					IL_9CB:
					if (i == 0)
					{
						result.Msg = "Erro indeterminado - ao programar página " + text;
						result.Cor = 1;
						result.Status = false;
											}
									}
				IL_A00:
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
				return result;
			}
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x0025B2A4 File Offset: 0x002596A4
		public static Mod_MD.CTRL_RESP_1 Escrita_pagina_multi_interface(int numero_pagina, int equipamento)
		{
			string text = "";
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			Mod_MD.CTRL_RESP_1 result;
			result.Msg = "";
			result.Status = false;
			result.Cor = 1;
			checked
			{
				while (i > 0)
				{
					i--;
					TcpClient tcpClient = new TcpClient();
					NetworkStream stream;
					if (Comunicacao.Config_sistema.tipo_interface == 2)
					{
						try
						{
							tcpClient.Connect(Comunicacao.Config_sistema.Tcpip.IP, Comunicacao.Config_sistema.Tcpip.Porta);
							tcpClient.SendTimeout = 1000;
							tcpClient.ReceiveTimeout = 1000;
							stream = tcpClient.GetStream();
						}
						catch (Exception ex)
						{
							result.Msg = string.Concat(new string[]
							{
								"Sem Conexão com o servidor TCP/IP:   ",
								Comunicacao.Config_sistema.Tcpip.IP,
								":",
								Comunicacao.Config_sistema.Tcpip.Porta.ToString(),
								"   Erro Timeout - ao ler página ",
								Conversion.Str(numero_pagina / 256)
							});
							result.Cor = 1;
							result.Status = false;
							return result;
						}
					}
					if (numero_pagina == 100)
					{
						text = "1";
						switch (equipamento)
						{
						case 1:
							Mod_MD.CMD_Esc_MD101_pagina_1(255, 1);
							break;
						case 2:
							Mod_MD.CMD_Esc_MD201_pagina_1(255, 1);
							break;
						case 3:
							Mod_MD.CMD_Esc_MD202_pagina_1(255, 1);
							break;
						case 4:
							Mod_MD.CMD_Esc_MD302_pagina_1(255, 1);
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_1(255, 1);
							break;
						}
					}
					else if (numero_pagina == 512)
					{
						text = "2";
						switch (equipamento)
						{
						case 1:
							Mod_MD.CMD_Esc_MD101_pagina_2(Mod_MD.Reservatorio[1].End_estacao, 1);
							break;
						case 2:
							Mod_MD.CMD_Esc_MD201_pagina_2(Mod_MD.Recalque_201[1].End_estacao, 1);
							break;
						case 3:
							Mod_MD.CMD_Esc_MD202_pagina_2(Mod_MD.Recalque_202[1].End_estacao, 1);
							break;
						case 4:
							text = "2-A";
							Mod_MD.CMD_Esc_MD302_pagina_2X(Mod_MD.Central_302_geral.Endereco, "2A");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_2(Mod_MD.Central_303_geral.Endereco_estacao);
							break;
						}
					}
					else if (numero_pagina == 592)
					{
						text = "2-B";
						if (equipamento == 4)
						{
							Mod_MD.CMD_Esc_MD302_pagina_2X(Mod_MD.Central_302_geral.Endereco, "2B");
						}
					}
					else if (numero_pagina == 768)
					{
						text = "3";
						switch (equipamento)
						{
						case 1:
							Mod_MD.CMD_Esc_MD202_pagina_3(Mod_MD.Ctrl_cal.End_equip, Mod_MD.Ctrl_cal.End_memoria, Mod_MD.Ctrl_cal.Dado);
							break;
						case 3:
							Mod_MD.CMD_Esc_MD202_pagina_3(Mod_MD.Ctrl_cal.End_equip, Mod_MD.Ctrl_cal.End_memoria, Mod_MD.Ctrl_cal.Dado);
							break;
						case 4:
							text = "3-A";
							Mod_MD.CMD_Esc_MD302_pagina_3_4_5_6X(Mod_MD.Central_302_geral.Endereco, "3A");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_3_4_5_6X(Mod_MD.Central_303_geral.Endereco_estacao, "3A");
							break;
						}
					}
					else if (numero_pagina == 888)
					{
						text = "3-B";
						switch (equipamento)
						{
						case 4:
							Mod_MD.CMD_Esc_MD302_pagina_3_4_5_6X(Mod_MD.Central_302_geral.Endereco, "3B");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_3_4_5_6X(Mod_MD.Central_303_geral.Endereco_estacao, "3B");
							break;
						}
					}
					else if (numero_pagina == 1024)
					{
						text = "4-A";
						switch (equipamento)
						{
						case 4:
							Mod_MD.CMD_Esc_MD302_pagina_3_4_5_6X(Mod_MD.Central_302_geral.Endereco, "4A");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_3_4_5_6X(Mod_MD.Central_303_geral.Endereco_estacao, "4A");
							break;
						}
					}
					else if (numero_pagina == 1144)
					{
						text = "4-B";
						switch (equipamento)
						{
						case 4:
							Mod_MD.CMD_Esc_MD302_pagina_3_4_5_6X(Mod_MD.Central_302_geral.Endereco, "4B");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_3_4_5_6X(Mod_MD.Central_303_geral.Endereco_estacao, "4B");
							break;
						}
					}
					else if (numero_pagina == 1280)
					{
						text = "5-A";
						switch (equipamento)
						{
						case 4:
							Mod_MD.CMD_Esc_MD302_pagina_3_4_5_6X(Mod_MD.Central_302_geral.Endereco, "5A");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_3_4_5_6X(Mod_MD.Central_303_geral.Endereco_estacao, "5A");
							break;
						}
					}
					else if (numero_pagina == 1400)
					{
						text = "5-B";
						switch (equipamento)
						{
						case 4:
							Mod_MD.CMD_Esc_MD302_pagina_3_4_5_6X(Mod_MD.Central_302_geral.Endereco, "5B");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_3_4_5_6X(Mod_MD.Central_303_geral.Endereco_estacao, "5B");
							break;
						}
					}
					else if (numero_pagina == 1536)
					{
						text = "6-A";
						switch (equipamento)
						{
						case 4:
							Mod_MD.CMD_Esc_MD302_pagina_3_4_5_6X(Mod_MD.Central_302_geral.Endereco, "6A");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_3_4_5_6X(Mod_MD.Central_303_geral.Endereco_estacao, "6A");
							break;
						}
					}
					else if (numero_pagina == 1656)
					{
						text = "6-B";
						switch (equipamento)
						{
						case 4:
							Mod_MD.CMD_Esc_MD302_pagina_3_4_5_6X(Mod_MD.Central_302_geral.Endereco, "6B");
							break;
						case 5:
							Mod_MD.CMD_Esc_MD303_pagina_3_4_5_6X(Mod_MD.Central_303_geral.Endereco_estacao, "6B");
							break;
						}
					}
					else if (numero_pagina == 1792)
					{
						text = "7";
						if (equipamento == 4)
						{
							text = "7-A";
							Mod_MD.CMD_Esc_MD302_pagina_7X(Mod_MD.Central_302_geral.Endereco, "7A");
						}
					}
					else if (numero_pagina == 1878)
					{
						text = "7";
						if (equipamento == 4)
						{
							text = "7-B";
							Mod_MD.CMD_Esc_MD302_pagina_7X(Mod_MD.Central_302_geral.Endereco, "7B");
						}
					}
					else if (numero_pagina == 1964)
					{
						text = "7";
						if (equipamento == 4)
						{
							text = "7-C";
							Mod_MD.CMD_Esc_MD302_pagina_7X(Mod_MD.Central_302_geral.Endereco, "7C");
						}
					}
					else if (numero_pagina == 1424)
					{
						text = "9";
						if (equipamento == 5)
						{
							text = "9";
							Mod_MD.CMD_Esc_MD303_pagina_9(Mod_MD.Central_303_geral.Endereco_estacao, "9");
						}
					}
					else if (numero_pagina == 2048)
					{
						if (equipamento == 0)
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT_810_H800(255);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
						}
					}
					else if (numero_pagina == 4096)
					{
						if (equipamento == 0)
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT_810_H1000(RT_geral.RT_810_BD.End_estacao.Valor);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
						}
					}
					else if (numero_pagina == 8192)
					{
						if (equipamento == 0)
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT_810_H2000(RT_geral.RT_810_BD.End_estacao.Valor);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
						}
					}
					else if (numero_pagina == 10240 && equipamento == 0)
					{
						int quantos_tx = Linha_RT.CMD_Esc_RT_810_H2800(RT_geral.RT_810_BD.End_estacao.Valor);
						Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
					}
					if (equipamento == 70)
					{
						if (numero_pagina == 2048)
						{
							Linha_RT.CMD_Esc_GC_825x_DadosGerais(255);
						}
						else if (numero_pagina == 6144)
						{
							Linha_RT.CMD_Esc_GC_825x_Calibracao_SA(RT_geral.GC_82x_BD.End_estacao.Valor, RT_geral.GC_82x_BD.calib_canal, RT_geral.GC_82x_BD.calib_funcao);
						}
						else if (numero_pagina == 20480)
						{
							if (Operators.CompareString(RT_geral.GC_82x_BD.tipo_tipo_envio, "CONTAGEM", false) == 0)
							{
								Linha_RT.CMD_Esc_GC_825x_DADOS_DE_RX_CONTAGENS(RT_geral.GC_82x_BD.End_estacao.Valor);
							}
							else if (Operators.CompareString(RT_geral.GC_82x_BD.tipo_tipo_envio, "mA", false) == 0)
							{
								Linha_RT.CMD_Esc_GC_825x_DADOS_DE_RX_mA(RT_geral.GC_82x_BD.End_estacao.Valor, RT_geral.GC_82x_BD.corrente_canal1, RT_geral.GC_82x_BD.corrente_canal2);
							}
						}
					}
					if (equipamento == 90)
					{
						if (numero_pagina == 512)
						{
							Linha_RT.CMD_Esc_IEC_855_CFG_GERAL(255);
						}
						else if (numero_pagina == 1024)
						{
							Linha_RT.CMD_Esc_IEC_855_CFG_ETHERNET(255);
						}
					}
					else if (equipamento == 80)
					{
						if (numero_pagina == 512)
						{
							Linha_RT.CMD_Esc_IEC_855_CFG_GERAL(255);
						}
						else if (numero_pagina == 1024)
						{
							Linha_RT.CMD_Esc_IEC_855_CFG_ETHERNET(255);
						}
						else if (numero_pagina == 1536)
						{
							Linha_RT.CMD_Esc_IEC_855_TABELA_IP(255, 1536, 0);
						}
						else if (numero_pagina == 2048)
						{
							Linha_RT.CMD_Esc_IEC_855_TABELA_IP(255, 2048, 50);
						}
						else if (numero_pagina == 2560)
						{
							Linha_RT.CMD_Esc_IEC_855_TABELA_IP(255, 2560, 100);
						}
						else if (numero_pagina == 3072)
						{
							Linha_RT.CMD_Esc_IEC_855_TABELA_IP(255, 3072, 150);
						}
					}
					if (equipamento == 20)
					{
						if (numero_pagina == 256)
						{
							Linha_RT.CMD_Esc_RT_810_200_CFG_GERAIS(255);
						}
						else if (numero_pagina == 512)
						{
							Linha_RT.CMD_Esc_RT_810_200_CFG_REPETIDORA(RT_geral.RT_810_200_BD.End_estacao.Valor);
						}
					}
					else if (equipamento == 30)
					{
						if (numero_pagina == 256)
						{
							Linha_RT.CMD_Esc_RT_820_200_CFG_GERAIS(255);
						}
						else if (numero_pagina == 512)
						{
							Linha_RT.CMD_Esc_RT_820_200_CFG_REPETIDORA(RT_geral.RT_820_200_BD.cfg_geral.End_estacao.Valor);
						}
						else if (numero_pagina == 2816)
						{
							Linha_RT.CMD_Esc_RT_820_200_CFG_SETPOINT_HORARIO(RT_geral.RT_820_200_BD.cfg_geral.End_estacao.Valor);
						}
					}
					else if (equipamento == 40)
					{
						if (numero_pagina == 256)
						{
							Linha_RT.CMD_Esc_RT_821_200_CFG_GERAIS(255);
						}
						else if (numero_pagina == 512)
						{
							Linha_RT.CMD_Esc_RT_821_200_CFG_REPETIDORA(RT_geral.RT_821_200_BD.cfg_geral.End_estacao.Valor);
						}
					}
					else if (equipamento == 50)
					{
						if (numero_pagina == 256)
						{
							Linha_RT.CMD_Esc_RT_830_200_CFG_GERAIS(255);
						}
						else if (numero_pagina == 512 || numero_pagina == 612)
						{
							Linha_RT.CMD_Esc_RT_830_200_RESERVATORIO(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor);
						}
						else if (numero_pagina != 768 && numero_pagina != 1024 && numero_pagina != 1280 && numero_pagina != 1536 && numero_pagina == 1792)
						{
						}
					}
					else if (equipamento == 60)
					{
						if (numero_pagina == 256)
						{
							Linha_RT.CMD_Esc_RT_831_200_CFG_GERAIS(255);
						}
						else if (numero_pagina == 512)
						{
							Linha_RT.CMD_Esc_RT_831_200_RESERVATORIO(RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor);
						}
						else if (numero_pagina == 2304)
						{
							Linha_RT.CMD_Esc_RT_831_200_SENHA(RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor);
						}
					}
					if (Comunicacao.Config_sistema.tipo_interface == 1)
					{
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
					}
					else
					{
						Thread.Sleep(500);
					}
					if (Comunicacao.Config_sistema.tipo_interface == 2)
					{
						try
						{
							if (stream.CanRead)
							{
								byte[] array = new byte[4097];
								int num = stream.Read(array, 0, 4096);
								stream.Close();
								tcpClient.Close();
								if (num > 0)
								{
									Comunicacao.Ctrl_Com.Frame = 0;
									int num2 = (int)array[5];
									int num3 = 0;
									int num4 = num2 - 1;
									for (int j = num3; j <= num4; j++)
									{
										int num5 = 6 + j;
										Comunicacao.Buffer_resp[j] = array[num5];
									}
									if (num2 == 3 & (int)Comunicacao.Buffer_resp[0] == Comunicacao.Config_sistema.endereco_modbus & Comunicacao.Buffer_resp[1] > 128)
									{
										Comunicacao.Ctrl_Com.Frame = 30;
									}
									else
									{
										Comunicacao.Ctrl_Com.Frame = 0;
									}
								}
								else
								{
									Comunicacao.Config_sistema.endereco_modbus = 0;
									Comunicacao.Config_sistema.endereco_encontrado = false;
									Comunicacao.Ctrl_Com.Frame = 3;
								}
							}
						}
						catch (Exception ex2)
						{
							stream.Close();
							tcpClient.Close();
							Comunicacao.Ctrl_Com.Frame = 3;
						}
					}
					int frame = Comunicacao.Ctrl_Com.Frame;
					if (frame == 0)
					{
						result.Msg = "Programação página " + text;
						result.Cor = 0;
						result.Status = true;
						break;
					}
					if (frame == 30)
					{
						if (i == 0)
						{
							result.Msg = "Erro - Equipamento ligado ao GateWai não responde ao ler página " + Conversion.Str(numero_pagina / 256);
							result.Cor = 1;
							result.Status = false;
							break;
						}
					}
					else if (frame == 3)
					{
						if (i == 0)
						{
							result.Msg = "Erro Timeout - ao programar página " + text;
							result.Cor = 1;
							result.Status = false;
						}
					}
					else if (frame == 2)
					{
						if (i == 0)
						{
							result.Msg = "Erro chksum - ao programar página " + text;
							result.Cor = 1;
							result.Status = false;
						}
					}
					else if (i == 0)
					{
						result.Msg = "Erro indeterminado - ao programar página " + text;
						result.Cor = 1;
						result.Status = false;
					}
					Comunicacao.Rotina_Delay(50L);
				}
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
				return result;
			}
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x0025C074 File Offset: 0x0025A474
		public static Mod_MD.CTRL_RESP_1 Escrita_pagina_RT(int numero_pagina, int equipamento, int bloco = 0)
		{
			string text = "";
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			Mod_MD.CTRL_RESP_1 result;
			result.Msg = "";
			result.Status = false;
			result.Cor = 1;
			checked
			{
				while (i > 0)
				{
					i--;
					if (numero_pagina == 256)
					{
						if (equipamento == 2010)
						{
							Linha_RT.CMD_Esc_GT2010(1, bloco);
						}
					}
					else if (numero_pagina == 2048 || numero_pagina == 2048 || numero_pagina == 2048 || numero_pagina == 2048)
					{
						switch (equipamento)
						{
						case 1:
							text = "1 - Parte 1";
							Linha_RT.CMD_Esc_RT820_H800_Parte_1(255, equipamento);
							break;
						case 2:
							text = "1 - Parte 1";
							Linha_RT.CMD_Esc_RT821_H800_Parte_1(255, equipamento);
							break;
						case 3:
							text = "1";
							Linha_RT.CMD_Esc_RT850_H800(255, equipamento);
							break;
						case 4:
							text = "1 - Parte 1";
							Linha_RT.CMD_Esc_RT820_360_H800_Parte_1(255, equipamento);
							break;
						}
					}
					else if (numero_pagina == 2161 || numero_pagina == 2163)
					{
						text = "1 - Parte 2";
						switch (equipamento)
						{
						case 1:
							Linha_RT.CMD_Esc_RT820_H800_Parte_2(255, equipamento);
							break;
						case 4:
							Linha_RT.CMD_Esc_RT820_360_H800_Parte_2(255, equipamento);
							break;
						}
					}
					else if (numero_pagina == 4096 || numero_pagina == 4096 || numero_pagina == 4096)
					{
						text = "2";
						switch (equipamento)
						{
						case 1:
							Linha_RT.CMD_Esc_RT820_H1000_Parte_1(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							break;
						case 2:
							Linha_RT.CMD_Esc_RT821_H1000_Parte_1(RT_geral.RT_821_BD.End_estacao.Valor, equipamento);
							break;
						case 3:
							Linha_RT.CMD_Esc_RT850_H1000_BLOCOS(RT_geral.RT_850_BD.End_mestre_canal_1.Valor, bloco);
							break;
						case 4:
							Linha_RT.CMD_Esc_RT820_360_H1000_Parte_1(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							break;
						}
					}
					else if (numero_pagina == 6144)
					{
						text = "3";
						if (equipamento == 3)
						{
							Linha_RT.CMD_Esc_RT850_H1800_BLOCOS(RT_geral.RT_850_BD.End_mestre_canal_1.Valor, bloco);
						}
					}
					else if (numero_pagina == 8192 || numero_pagina == 8192)
					{
						text = "4";
						switch (equipamento)
						{
						case 1:
							Linha_RT.CMD_Esc_RT820_H2000_Parte_1(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							break;
						case 2:
							Linha_RT.CMD_Esc_RT821_H2000_Parte_1(RT_geral.RT_821_BD.End_estacao.Valor, equipamento);
							break;
						case 4:
							Linha_RT.CMD_Esc_RT820_360_H2000_Parte_1(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							break;
						}
					}
					else if (numero_pagina == 10240 || numero_pagina == 10240)
					{
						text = "5";
						switch (equipamento)
						{
						case 1:
							Linha_RT.CMD_Esc_RT820_H2800_Parte_1(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							break;
						case 2:
							Linha_RT.CMD_Esc_RT821_H2800_Parte_1(RT_geral.RT_821_BD.End_estacao.Valor, equipamento);
							break;
						case 4:
							Linha_RT.CMD_Esc_RT820_360_H2800_Parte_1(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							break;
						}
					}
					else if (numero_pagina == 12288)
					{
						text = "6";
						switch (equipamento)
						{
						case 1:
							Linha_RT.CMD_Esc_RT820_H3000_Parte_1(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							break;
						case 3:
							Linha_RT.CMD_Esc_RT850_H3000_Parte_1(RT_geral.RT_850_BD.End_mestre_canal_1.Valor, equipamento);
							break;
						case 4:
							Linha_RT.CMD_Esc_RT820_360_H3000_Parte_1(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							break;
						}
					}
					else if (numero_pagina == 12388)
					{
						text = "3";
						if (equipamento == 3)
						{
							Linha_RT.CMD_Esc_RT850_H3000_Parte_2(RT_geral.RT_850_BD.End_mestre_canal_1.Valor, equipamento);
						}
					}
					else if (numero_pagina == 22528 || numero_pagina == 22528)
					{
						text = "11";
						switch (equipamento)
						{
						case 1:
							text = "11";
							Linha_RT.CMD_Esc_RT820_SETPOINT_HORARIO(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							break;
						case 3:
							Linha_RT.CMD_Esc_RT850_H5800_BLOCOS(RT_geral.RT_850_BD.End_mestre_canal_1.Valor, bloco);
							break;
						case 4:
							Linha_RT.CMD_Esc_RT820_360_PART1_SETPOINT_HORARIO(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							break;
						}
					}
					else if (numero_pagina == 22648)
					{
						if (equipamento == 4)
						{
							Linha_RT.CMD_Esc_RT820_360_PART2_SETPOINT_HORARIO(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
						}
					}
					else if (numero_pagina == 24576 || numero_pagina == 24576)
					{
						text = "12";
						switch (equipamento)
						{
						case 1:
							Linha_RT.CMD_Esc_RT820_REFERENCIA_PERIFERICO(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							break;
						case 3:
							Linha_RT.CMD_Esc_RT850_H6000_BLOCOS(RT_geral.RT_850_BD.End_mestre_canal_1.Valor, bloco);
							break;
						case 4:
							Linha_RT.CMD_Esc_RT820_360_REFERENCIA_PERIFERICO(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							break;
						}
					}
					else if (numero_pagina == 26624 || numero_pagina == 26624)
					{
						text = "13";
						switch (equipamento)
						{
						case 1:
							Linha_RT.CMD_Esc_RT820_ATUADOR_PERIFERICO_P1(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							break;
						case 3:
							Linha_RT.CMD_Esc_RT850_H6800_BLOCOS(RT_geral.RT_850_BD.End_mestre_canal_1.Valor, bloco);
							break;
						case 4:
							Linha_RT.CMD_Esc_RT820_360_ATUADOR_PERIFERICO_P1(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							break;
						}
					}
					else if (numero_pagina == 26711)
					{
						text = Conversions.ToString(13);
						switch (equipamento)
						{
						case 1:
							Linha_RT.CMD_Esc_RT820_ATUADOR_PERIFERICO_P2(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							break;
						case 4:
							Linha_RT.CMD_Esc_RT820_360_ATUADOR_PERIFERICO_P2(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							break;
						}
					}
					else if (numero_pagina == 26798)
					{
						text = Conversions.ToString(13);
						switch (equipamento)
						{
						case 1:
							Linha_RT.CMD_Esc_RT820_ATUADOR_PERIFERICO_P3(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							break;
						case 4:
							Linha_RT.CMD_Esc_RT820_360_ATUADOR_PERIFERICO_P3(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							break;
						}
					}
					else if (numero_pagina == 26885)
					{
						text = Conversions.ToString(13);
						switch (equipamento)
						{
						case 1:
							Linha_RT.CMD_Esc_RT820_ATUADOR_PERIFERICO_P4(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							break;
						case 4:
							Linha_RT.CMD_Esc_RT820_360_ATUADOR_PERIFERICO_P4(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							break;
						}
					}
					else if (numero_pagina == 28672 || numero_pagina == 28672)
					{
						text = "14";
						switch (equipamento)
						{
						case 3:
							Linha_RT.CMD_Esc_RT850_H7000_BLOCOS(RT_geral.RT_850_BD.End_mestre_canal_1.Valor, bloco);
							break;
						case 4:
							Linha_RT.CMD_Esc_RT820_360_PERIFERICO_MODBUS_GENERICO(RT_geral.RT_820_360_BD.End_estacao1.Valor);
							break;
						}
					}
					else if (numero_pagina == 30720)
					{
						text = "15";
						switch (equipamento)
						{
						case 1:
							Linha_RT.CMD_Esc_RT820_H7800_Parte_1(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							break;
						case 4:
							Linha_RT.CMD_Esc_RT820_360_H7800_Parte_1(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							break;
						}
					}
					if (equipamento == 50)
					{
						if (numero_pagina == 768)
						{
							Linha_RT.CMD_Esc_RT_830_200_RECALQUE(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 4);
						}
						else if (numero_pagina == 888)
						{
							Linha_RT.CMD_Esc_RT_830_200_RECALQUE(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 3);
						}
						else if (numero_pagina == 1024)
						{
							Linha_RT.CMD_Esc_RT_830_200_RECALQUE(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 4);
						}
						else if (numero_pagina == 1144)
						{
							Linha_RT.CMD_Esc_RT_830_200_RECALQUE(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 3);
						}
						else if (numero_pagina == 1280)
						{
							Linha_RT.CMD_Esc_RT_830_200_RECALQUE(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 4);
						}
						else if (numero_pagina == 1400)
						{
							Linha_RT.CMD_Esc_RT_830_200_RECALQUE(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 3);
						}
						else if (numero_pagina == 1536)
						{
							Linha_RT.CMD_Esc_RT_830_200_RECALQUE(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 4);
						}
						else if (numero_pagina == 1656)
						{
							Linha_RT.CMD_Esc_RT_830_200_RECALQUE(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 3);
						}
						else if (numero_pagina == 1792 || numero_pagina == 1878 || numero_pagina == 1964)
						{
							Linha_RT.CMD_Esc_RT_830_200_VISTA(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, bloco);
						}
					}
					else if (equipamento == 60)
					{
						if (numero_pagina == 768 || numero_pagina == 844 || numero_pagina == 1024 || numero_pagina == 1100 || numero_pagina == 1280 || numero_pagina == 1356 || numero_pagina == 1536 || numero_pagina == 1612)
						{
							Linha_RT.CMD_Esc_RT_831_200_RECALQUE(numero_pagina, RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor, bloco);
						}
					}
					else if (equipamento == 4)
					{
						switch (numero_pagina)
						{
						case 6176:
						case 6177:
						case 6178:
						case 6179:
						case 6180:
						case 6181:
							Linha_RT.CMD_Esc_RT_820_360_Cal_SA(numero_pagina, RT_geral.RT_820_360_BD.End_estacao1.Valor, RT_geral.RT_820_360_BD.calibracao_const);
							break;
						}
					}
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						result.Msg = "Programação página " + text;
						result.Cor = 0;
						result.Status = true;
						goto IL_AC3;
					case 2:
						if (i == 0)
						{
							result.Msg = "Erro chksum - ao programar página " + text;
							result.Cor = 1;
							result.Status = false;
							continue;
						}
						continue;
					case 3:
						if (i == 0)
						{
							result.Msg = "Erro Timeout - ao programar página " + text;
							result.Cor = 1;
							result.Status = false;
							continue;
						}
						continue;
					}
					if (i == 0)
					{
						result.Msg = "Erro indeterminado - ao programar página " + text;
						result.Cor = 1;
						result.Status = false;
					}
				}
				IL_AC3:
				Comunicacao.Rotina_Delay(50L);
				return result;
			}
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x0025CB50 File Offset: 0x0025AF50
		public static Mod_MD.CTRL_RESP_1 Escrita_pagina_RT_multi_interface(int numero_pagina, int equipamento, int bloco = 0)
		{
			string text = "";
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			Mod_MD.CTRL_RESP_1 result;
			result.Msg = "";
			result.Status = false;
			result.Cor = 1;
			checked
			{
				while (i > 0)
				{
					i--;
					TcpClient tcpClient = new TcpClient();
					NetworkStream stream;
					if (Comunicacao.Config_sistema.tipo_interface == 2)
					{
						try
						{
							tcpClient.Connect(Comunicacao.Config_sistema.Tcpip.IP, Comunicacao.Config_sistema.Tcpip.Porta);
							tcpClient.SendTimeout = 1000;
							tcpClient.ReceiveTimeout = 1000;
							stream = tcpClient.GetStream();
						}
						catch (Exception ex)
						{
							result.Msg = string.Concat(new string[]
							{
								"Sem Conexão com o servidor TCP/IP:   ",
								Comunicacao.Config_sistema.Tcpip.IP,
								":",
								Comunicacao.Config_sistema.Tcpip.Porta.ToString(),
								"   Erro Timeout - ao ler página ",
								Conversion.Str(numero_pagina / 256)
							});
							result.Cor = 1;
							result.Status = false;
							return result;
						}
					}
					if (numero_pagina == 256)
					{
						if (equipamento == 2010)
						{
							Linha_RT.CMD_Esc_GT2010(1, bloco);
						}
					}
					else if (numero_pagina == 2048 || numero_pagina == 2048 || numero_pagina == 2048 || numero_pagina == 2048)
					{
						switch (equipamento)
						{
						case 1:
						{
							text = "1 - Parte 1";
							int quantos_tx = Linha_RT.CMD_Esc_RT820_H800_Parte_1(255, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 2:
						{
							text = "1 - Parte 1";
							int quantos_tx = Linha_RT.CMD_Esc_RT821_H800_Parte_1(255, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 3:
						{
							text = "1";
							int quantos_tx = Linha_RT.CMD_Esc_RT850_H800(255, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 4:
						{
							text = "1 - Parte 1";
							int quantos_tx = Linha_RT.CMD_Esc_RT820_360_H800_Parte_1(255, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						}
					}
					else if (numero_pagina == 2161 || numero_pagina == 2163)
					{
						text = "1 - Parte 2";
						switch (equipamento)
						{
						case 1:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_H800_Parte_2(255, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 4:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_360_H800_Parte_2(255, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						}
					}
					else if (numero_pagina == 2279)
					{
						if (equipamento == 4)
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_360_H800_Parte_3(255, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
						}
					}
					else if (numero_pagina == 4096 || numero_pagina == 4096 || numero_pagina == 4096)
					{
						text = "2";
						switch (equipamento)
						{
						case 1:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_H1000_Parte_1(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 2:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT821_H1000_Parte_1(RT_geral.RT_821_BD.End_estacao.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 3:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT850_H1000_BLOCOS(RT_geral.RT_850_BD.End_mestre_canal_1.Valor, bloco);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 4:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_360_H1000_Parte_1(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						}
					}
					else if (numero_pagina == 6144)
					{
						text = "3";
						if (equipamento == 3)
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT850_H1800_BLOCOS(RT_geral.RT_850_BD.End_mestre_canal_1.Valor, bloco);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
						}
					}
					else if (numero_pagina == 8192 || numero_pagina == 8192)
					{
						text = "4";
						switch (equipamento)
						{
						case 1:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_H2000_Parte_1(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 2:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT821_H2000_Parte_1(RT_geral.RT_821_BD.End_estacao.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 4:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_360_H2000_Parte_1(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						}
					}
					else if (numero_pagina == 10240 || numero_pagina == 10240)
					{
						text = "5";
						switch (equipamento)
						{
						case 1:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_H2800_Parte_1(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 2:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT821_H2800_Parte_1(RT_geral.RT_821_BD.End_estacao.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 4:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_360_H2800_Parte_1(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						}
					}
					else if (numero_pagina == 12288)
					{
						text = "6";
						switch (equipamento)
						{
						case 1:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_H3000_Parte_1(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 3:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT850_H3000_Parte_1(RT_geral.RT_850_BD.End_mestre_canal_1.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 4:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_360_H3000_Parte_1(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						}
					}
					else if (numero_pagina == 12388)
					{
						text = "3";
						if (equipamento == 3)
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT850_H3000_Parte_2(RT_geral.RT_850_BD.End_mestre_canal_1.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
						}
					}
					else if (numero_pagina == 22528 || numero_pagina == 22528)
					{
						text = "11";
						switch (equipamento)
						{
						case 1:
						{
							text = "11";
							int quantos_tx = Linha_RT.CMD_Esc_RT820_SETPOINT_HORARIO(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 3:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT850_H5800_BLOCOS(RT_geral.RT_850_BD.End_mestre_canal_1.Valor, bloco);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 4:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_360_PART1_SETPOINT_HORARIO(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						}
					}
					else if (numero_pagina == 22648)
					{
						if (equipamento == 4)
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_360_PART2_SETPOINT_HORARIO(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
						}
					}
					else if (numero_pagina == 24576 || numero_pagina == 24576)
					{
						text = "12";
						switch (equipamento)
						{
						case 1:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_REFERENCIA_PERIFERICO(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 3:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT850_H6000_BLOCOS(RT_geral.RT_850_BD.End_mestre_canal_1.Valor, bloco);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 4:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_360_REFERENCIA_PERIFERICO(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						}
					}
					else if (numero_pagina == 26624 || numero_pagina == 26624)
					{
						text = "13";
						switch (equipamento)
						{
						case 1:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_ATUADOR_PERIFERICO_P1(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 3:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT850_H6800_BLOCOS(RT_geral.RT_850_BD.End_mestre_canal_1.Valor, bloco);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 4:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_360_ATUADOR_PERIFERICO_P1(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						}
					}
					else if (numero_pagina == 26711)
					{
						text = Conversions.ToString(13);
						switch (equipamento)
						{
						case 1:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_ATUADOR_PERIFERICO_P2(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 4:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_360_ATUADOR_PERIFERICO_P2(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						}
					}
					else if (numero_pagina == 26798)
					{
						text = Conversions.ToString(13);
						switch (equipamento)
						{
						case 1:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_ATUADOR_PERIFERICO_P3(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 4:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_360_ATUADOR_PERIFERICO_P3(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						}
					}
					else if (numero_pagina == 26885)
					{
						text = Conversions.ToString(13);
						switch (equipamento)
						{
						case 1:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_ATUADOR_PERIFERICO_P4(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 4:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_360_ATUADOR_PERIFERICO_P4(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						}
					}
					else if (numero_pagina == 28672 || numero_pagina == 28672)
					{
						text = "14";
						switch (equipamento)
						{
						case 3:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT850_H7000_BLOCOS(RT_geral.RT_850_BD.End_mestre_canal_1.Valor, bloco);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 4:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_360_PERIFERICO_MODBUS_GENERICO(RT_geral.RT_820_360_BD.End_estacao1.Valor);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						}
					}
					else if (numero_pagina == 30720)
					{
						text = "15";
						switch (equipamento)
						{
						case 1:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_H7800_Parte_1(RT_geral.RT_820_BD.End_estacao.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						case 4:
						{
							int quantos_tx = Linha_RT.CMD_Esc_RT820_360_H7800_Parte_1(RT_geral.RT_820_360_BD.End_estacao1.Valor, equipamento);
							Linha_RT.CMD_Esc_TCP(quantos_tx, stream);
							break;
						}
						}
					}
					if (equipamento == 50)
					{
						if (numero_pagina == 768)
						{
							Linha_RT.CMD_Esc_RT_830_200_RECALQUE(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 4);
						}
						else if (numero_pagina == 888)
						{
							Linha_RT.CMD_Esc_RT_830_200_RECALQUE(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 3);
						}
						else if (numero_pagina == 1024)
						{
							Linha_RT.CMD_Esc_RT_830_200_RECALQUE(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 4);
						}
						else if (numero_pagina == 1144)
						{
							Linha_RT.CMD_Esc_RT_830_200_RECALQUE(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 3);
						}
						else if (numero_pagina == 1280)
						{
							Linha_RT.CMD_Esc_RT_830_200_RECALQUE(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 4);
						}
						else if (numero_pagina == 1400)
						{
							Linha_RT.CMD_Esc_RT_830_200_RECALQUE(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 3);
						}
						else if (numero_pagina == 1536)
						{
							Linha_RT.CMD_Esc_RT_830_200_RECALQUE(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 4);
						}
						else if (numero_pagina == 1656)
						{
							Linha_RT.CMD_Esc_RT_830_200_RECALQUE(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 3);
						}
						else if (numero_pagina == 1792 || numero_pagina == 1878 || numero_pagina == 1964)
						{
							Linha_RT.CMD_Esc_RT_830_200_VISTA(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, bloco);
						}
					}
					else if (equipamento == 60 && (numero_pagina == 768 || numero_pagina == 844 || numero_pagina == 1024 || numero_pagina == 1100 || numero_pagina == 1280 || numero_pagina == 1356 || numero_pagina == 1536 || numero_pagina == 1612))
					{
						Linha_RT.CMD_Esc_RT_831_200_RECALQUE(numero_pagina, RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor, bloco);
					}
					if (Comunicacao.Config_sistema.tipo_interface == 1)
					{
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
					}
					else
					{
						Thread.Sleep(500);
					}
					if (Comunicacao.Config_sistema.tipo_interface == 2)
					{
						try
						{
							if (stream.CanRead)
							{
								byte[] array = new byte[4097];
								int num = stream.Read(array, 0, 4096);
								stream.Close();
								tcpClient.Close();
								if (num > 0)
								{
									Comunicacao.Ctrl_Com.Frame = 0;
									int num2 = (int)array[5];
									int num3 = 0;
									int num4 = num2 - 1;
									for (int j = num3; j <= num4; j++)
									{
										int num5 = 6 + j;
										Comunicacao.Buffer_resp[j] = array[num5];
									}
									if (num2 == 3 & (int)Comunicacao.Buffer_resp[0] == Comunicacao.Config_sistema.endereco_modbus & Comunicacao.Buffer_resp[1] > 128)
									{
										Comunicacao.Ctrl_Com.Frame = 30;
									}
									else
									{
										Comunicacao.Ctrl_Com.Frame = 0;
									}
								}
								else
								{
									Comunicacao.Config_sistema.endereco_modbus = 0;
									Comunicacao.Config_sistema.endereco_encontrado = false;
									Comunicacao.Ctrl_Com.Frame = 3;
								}
							}
						}
						catch (Exception ex2)
						{
							stream.Close();
							tcpClient.Close();
							Comunicacao.Ctrl_Com.Frame = 3;
						}
					}
					int frame = Comunicacao.Ctrl_Com.Frame;
					if (frame == 0)
					{
						result.Msg = "Programação página " + text;
						result.Cor = 0;
						result.Status = true;
						break;
					}
					if (frame == 30)
					{
						if (i == 0)
						{
							result.Msg = "Erro - Equipamento ligado ao GateWai não responde ao ler página " + Conversion.Str(numero_pagina / 256);
							result.Cor = 1;
							result.Status = false;
							break;
						}
					}
					else if (frame == 3)
					{
						if (i == 0)
						{
							result.Msg = "Erro Timeout - ao programar página " + text;
							result.Cor = 1;
							result.Status = false;
						}
					}
					else if (frame == 2)
					{
						if (i == 0)
						{
							result.Msg = "Erro chksum - ao programar página " + text;
							result.Cor = 1;
							result.Status = false;
						}
					}
					else if (i == 0)
					{
						result.Msg = "Erro indeterminado - ao programar página " + text;
						result.Cor = 1;
						result.Status = false;
					}
				}
				Comunicacao.Rotina_Delay(50L);
				return result;
			}
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x0025DA24 File Offset: 0x0025BE24
		public static bool Parse_Modbus_Frame_Response(int quantos, byte[] buffer)
		{
			string text = "";
			text = text + "Tamanho Total Frame =" + string.Format("{0} bytes", quantos) + "\r\n";
			MessageBox.Show(text);
			return true;
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x0025DA64 File Offset: 0x0025BE64
		public static bool Leitura_pagina_TCPIP_Busca_Endereco_Modbus()
		{
			Comunicacao.Config_sistema.endereco_encontrado = false;
			checked
			{
				if (Comunicacao.Config_sistema.tipo_interface == 2)
				{
					int num = 0;
					while (!Mod_MD.Leitura_pagina_TCPIP(0, num, 1).Status)
					{
						num++;
						if (num > 254)
						{
													}
					}
					Comunicacao.Config_sistema.endereco_modbus = num;
					Comunicacao.Config_sistema.endereco_encontrado = true;
				}
				IL_50:
				return Comunicacao.Config_sistema.endereco_encontrado;
			}
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0025DAD0 File Offset: 0x0025BED0
		public static Mod_MD.CTRL_RESP_1 Leitura_pagina_TCPIP(int numero_pagina, int endereco, int tamanho)
		{
			TcpClient tcpClient = new TcpClient();
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			Mod_MD.CTRL_RESP_1 result;
			result.Msg = "";
			result.Status = false;
			result.Cor = 1;
			checked
			{
				while (i > 0)
				{
					if (Comunicacao.Config_sistema.tipo_interface == 1)
					{
						Comunicacao.Init_buffer_serial();
					}
					i--;
					NetworkStream stream;
					if (Comunicacao.Config_sistema.tipo_interface == 2)
					{
						tcpClient.Connect(Comunicacao.Config_sistema.Tcpip.IP, Comunicacao.Config_sistema.Tcpip.Porta);
						tcpClient.SendTimeout = 100;
						tcpClient.ReceiveTimeout = 100;
						stream = tcpClient.GetStream();
						Comunicacao.CMD_Le_Pagina_TCPIP(numero_pagina, endereco, tamanho, ref stream);
					}
					else
					{
						Comunicacao.CMD_Le_Pagina(numero_pagina, endereco, tamanho);
					}
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					if (Comunicacao.Config_sistema.tipo_interface == 2)
					{
						try
						{
							if (stream.CanRead)
							{
								byte[] array = new byte[4097];
								int num = stream.Read(array, 0, 4096);
								stream.Close();
								tcpClient.Close();
								if (num > 0)
								{
									Comunicacao.Ctrl_Com.Frame = 0;
									int num2 = (int)array[5];
									int num3 = 0;
									int num4 = num2 - 1;
									for (int j = num3; j <= num4; j++)
									{
										int num5 = 6 + j;
										Comunicacao.Buffer_resp[j] = array[num5];
									}
								}
							}
						}
						catch (Exception ex)
						{
							stream.Close();
							tcpClient.Close();
							Comunicacao.Ctrl_Com.Frame = 3;
						}
					}
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						result.Msg = "Leitura página " + Conversion.Str(numero_pagina / 256) + " - OK";
						result.Cor = 0;
						result.Status = true;
						goto IL_283;
					case 2:
						if (i == 0)
						{
							result.Msg = "Erro chksum - ao ler página " + Conversion.Str(numero_pagina / 256);
							result.Cor = 1;
							result.Status = false;
													}
						continue;
					case 3:
						if (i == 0)
						{
							result.Msg = "Erro Timeout - ao ler página " + Conversion.Str(numero_pagina / 256);
							result.Cor = 1;
							result.Status = false;
													}
						continue;
					}
					if (i == 0)
					{
						result.Msg = "Erro indeterminado - ao ler página " + Conversion.Str(numero_pagina / 256);
						result.Cor = 1;
						result.Status = false;
						break;
					}
				}
				IL_283:
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
				Comunicacao.Rotina_Delay(5L);
				return result;
			}
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x0025DD94 File Offset: 0x0025C194
		public static Mod_MD.CTRL_RESP_1 Leitura_pagina_multi_interface(int numero_pagina, int endereco, int tamanho)
		{
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			Mod_MD.CTRL_RESP_1 result;
			result.Msg = "";
			result.Status = false;
			result.Cor = 1;
			checked
			{
				while (i > 0)
				{
					Comunicacao.Init_buffer_serial();
					i--;
					TcpClient tcpClient = new TcpClient();
					NetworkStream stream;
					if (Comunicacao.Config_sistema.tipo_interface != 1)
					{
						if (Comunicacao.Config_sistema.tipo_interface == 2)
						{
							try
							{
								tcpClient.Connect(Comunicacao.Config_sistema.Tcpip.IP, Comunicacao.Config_sistema.Tcpip.Porta);
								tcpClient.SendTimeout = 1000;
								tcpClient.ReceiveTimeout = 1000;
								stream = tcpClient.GetStream();
							}
							catch (Exception ex)
							{
								result.Msg = string.Concat(new string[]
								{
									"Sem Conexão com o servidor TCP/IP:   ",
									Comunicacao.Config_sistema.Tcpip.IP,
									":",
									Comunicacao.Config_sistema.Tcpip.Porta.ToString(),
									"   Erro Timeout - ao ler página ",
									Conversion.Str(numero_pagina / 256)
								});
								result.Cor = 1;
								result.Status = false;
								return result;
							}
							Comunicacao.CMD_Le_Pagina_TCPIP(numero_pagina, endereco, tamanho, ref stream);
													}
						result.Msg = "Não existe definição de tipo de interface de comunicação!";
						result.Cor = 1;
						result.Status = false;
						return result;
					}
					Comunicacao.CMD_Le_Pagina(numero_pagina, endereco, tamanho);
					IL_17D:
					if (Comunicacao.Config_sistema.tipo_interface == 1)
					{
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
					}
					else
					{
						Thread.Sleep(500);
					}
					if (Comunicacao.Config_sistema.tipo_interface == 2)
					{
						try
						{
							if (stream.CanRead)
							{
								byte[] array = new byte[4097];
								int num = stream.Read(array, 0, 4096);
								stream.Close();
								tcpClient.Close();
								if (num > 0)
								{
									Comunicacao.Ctrl_Com.Frame = 0;
									int num2 = (int)array[5];
									int num3 = 0;
									int num4 = num2 - 1;
									for (int j = num3; j <= num4; j++)
									{
										int num5 = 6 + j;
										Comunicacao.Buffer_resp[j] = array[num5];
									}
									if (num2 == 3 & (int)Comunicacao.Buffer_resp[0] == endereco & Comunicacao.Buffer_resp[1] > 128)
									{
										Comunicacao.Ctrl_Com.Frame = 30;
									}
									else
									{
										Comunicacao.Ctrl_Com.Frame = 0;
									}
								}
								else
								{
									Comunicacao.Config_sistema.endereco_modbus = 0;
									Comunicacao.Config_sistema.endereco_encontrado = false;
									Comunicacao.Ctrl_Com.Frame = 3;
								}
							}
						}
						catch (Exception ex2)
						{
							stream.Close();
							tcpClient.Close();
							Comunicacao.Ctrl_Com.Frame = 3;
						}
					}
					int frame = Comunicacao.Ctrl_Com.Frame;
					if (frame == 0)
					{
						result.Msg = "Leitura página " + Conversion.Str(numero_pagina / 256) + " - OK";
						result.Cor = 0;
						result.Status = true;
						break;
					}
					if (frame == 30)
					{
						if (i == 0)
						{
							result.Msg = "Erro - Equipamento ligado ao GateWai não responde ao ler página " + Conversion.Str(numero_pagina / 256);
							result.Cor = 1;
							result.Status = false;
							break;
						}
					}
					else if (frame == 3)
					{
						if (i == 0)
						{
							result.Msg = "Erro Timeout - ao ler página " + Conversion.Str(numero_pagina / 256);
							result.Cor = 1;
							result.Status = false;
							break;
						}
					}
					else if (frame == 2)
					{
						if (i == 0)
						{
							result.Msg = "Erro chksum - ao ler página " + Conversion.Str(numero_pagina / 256);
							result.Cor = 1;
							result.Status = false;
							break;
						}
					}
					else if (i == 0)
					{
						result.Msg = "Erro indeterminado - ao ler página " + Conversion.Str(numero_pagina / 256);
						result.Cor = 1;
						result.Status = false;
						break;
					}
				}
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
				Comunicacao.Rotina_Delay(5L);
				return result;
			}
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x0025E1E8 File Offset: 0x0025C5E8
		public static Mod_MD.CTRL_RESP_1 Leitura_pagina(int numero_pagina, int endereco, int tamanho)
		{
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			Mod_MD.CTRL_RESP_1 result;
			result.Msg = "";
			result.Status = false;
			result.Cor = 1;
			checked
			{
				while (i > 0)
				{
					Comunicacao.Init_buffer_serial();
					i--;
					Comunicacao.CMD_Le_Pagina(numero_pagina, endereco, tamanho);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						result.Msg = "Leitura página " + Conversion.Str(numero_pagina / 256) + " - OK";
						result.Cor = 0;
						result.Status = true;
						goto IL_16C;
					case 2:
						if (i == 0)
						{
							result.Msg = "Erro chksum - ao ler página " + Conversion.Str(numero_pagina / 256);
							result.Cor = 1;
							result.Status = false;
													}
						continue;
					case 3:
						if (i == 0)
						{
							result.Msg = "Erro Timeout - ao ler página " + Conversion.Str(numero_pagina / 256);
							result.Cor = 1;
							result.Status = false;
													}
						continue;
					}
					if (i == 0)
					{
						result.Msg = "Erro indeterminado - ao ler página " + Conversion.Str(numero_pagina / 256);
						result.Cor = 1;
						result.Status = false;
						break;
					}
				}
				IL_16C:
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
				Comunicacao.Rotina_Delay(5L);
				return result;
			}
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x0025E384 File Offset: 0x0025C784
		public static string Mensagem_status_bomba_201(int dado)
		{
			string result;
			switch (dado & -33)
			{
			case 0:
				result = "Não Instalado";
				break;
			case 1:
				result = "Parado";
				break;
			case 2:
				result = "Partindo";
				break;
			case 3:
				result = "Operando";
				break;
			case 4:
				result = "Parando";
				break;
			case 5:
				result = "Parado Anormal";
				break;
			case 6:
				result = "Ligado Anormal";
				break;
			default:
				result = "";
				break;
			}
			return result;
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x0025E400 File Offset: 0x0025C800
		public static string Mensagem_modo_bomba_201(int dado)
		{
			string result;
			if ((dado & 32) > 0)
			{
				result = "Manual";
			}
			else
			{
				result = "Automático";
			}
			return result;
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x0025E42C File Offset: 0x0025C82C
		public static bool Alarme_recalque_201(int dado, int mascara)
		{
			bool result = false;
			if ((dado & mascara) > 0)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x0025E448 File Offset: 0x0025C848
		public static Mod_MD.CTRL_RESP_1 Verifica_resposta_Linha300()
		{
			string[] array = new string[]
			{
				"Comando Executado com sucesso",
				"Erro - Controle operando",
				"Erro - Tempo entre acionamentos",
				"Erro - Excede número bombas simultâneas",
				"Erro - Esta em falha",
				"Erro - Já está operando",
				"Erro - Já está parada",
				"Erro - Tempo mínimo controle parado",
				"Erro - Tempo mínimo controle operando",
				"Erro - Já está aberta",
				"Erro - Já está fechada",
				"Erro - Indefinido",
				"Erro - Está em bateria",
				"Erro - Em horário de ponta",
				"Erro - Falta de fase",
				"Erro - Comando não reconhecido",
				"Erro - Controle não habilitado",
				"Erro - Está em automático",
				"Erro - Está em manual",
				"Erro - Controle não está em falha",
				"Erro - Está em local",
				"Erro - Somente manual",
				"Erro - Falta liberação digital",
				"Erro - Existe bloqueio digital",
				"Erro - Existe bloqueio analógico"
			};
			Mod_MD.CTRL_RESP_1 result;
			result.Msg = "";
			result.Cor = 0;
			if (Comunicacao.Buffer_resp[3] == 6)
			{
				result.Msg = array[0];
			}
			else
			{
				result.Cor = 1;
				int num = (int)(checked(Comunicacao.Buffer_resp[4] - 48));
				if (num <= 24)
				{
					result.Msg = array[num];
				}
				else
				{
					result.Msg = array[11];
				}
			}
			return result;
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x0025E5B0 File Offset: 0x0025C9B0
		public static Mod_MD.CTRL_RESP_1 Verifica_resposta()
		{
			Mod_MD.CTRL_RESP_1 result;
			result.Msg = "";
			result.Cor = 0;
			if (Comunicacao.Buffer_resp[3] == 6)
			{
				result.Msg = "Comando executado com sucesso";
			}
			else
			{
				result.Cor = 1;
				switch (Comunicacao.Buffer_resp[4])
				{
				case 49:
					result.Msg = "Erro - Controle operando";
					break;
				case 50:
					result.Msg = "Erro - Tempo entre acionamentos";
					break;
				case 51:
					result.Msg = "Erro - Excede número bombas simultâneas";
					break;
				case 52:
					result.Msg = "Erro - Esta em falha";
					break;
				case 53:
					result.Msg = "Erro - Já está operando";
					break;
				case 54:
					result.Msg = "Erro - Já está parada";
					break;
				case 55:
					result.Msg = "Erro - Tempo motor parado";
					break;
				case 56:
					result.Msg = "Erro - Tempo motor operando";
					break;
				case 57:
					result.Msg = "Erro - Já está aberta";
					break;
				case 58:
					result.Msg = "Erro - Já está fechada";
					break;
				case 59:
					result.Msg = "Erro - Motor está parado";
					break;
				case 60:
					result.Msg = "Erro - Está em bateria";
					break;
				case 80:
					result.Msg = "Erro - Comando não reconhecido";
					break;
				case 81:
					result.Msg = "Erro - Bomba não instalada";
					break;
				case 82:
					result.Msg = "Erro - Bomba já em automatico";
					break;
				case 83:
					result.Msg = "Erro - Bomba já em manual";
					break;
				case 84:
					result.Msg = "Erro - Bomba não está em falha";
					break;
				}
			}
			return result;
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x0025E79C File Offset: 0x0025CB9C
		public static Mod_MD.CTRL_RESP_1 Valida_celula(DataGridViewCellValidatingEventArgs ee, int limite_sup, int limite_inf)
		{
			string text = Strings.LTrim(string.Format(ee.FormattedValue.ToString(), new object[0]));
			string text2 = Conversions.ToString(Conversion.Val(ee.FormattedValue.ToString()));
			int num = checked((int)Math.Round(Conversion.Val(ee.FormattedValue.ToString())));
			Mod_MD.CTRL_RESP_1 result;
			if (string.IsNullOrEmpty(ee.FormattedValue.ToString()))
			{
				result.Status = false;
				result.Msg = "";
			}
			else if (Operators.CompareString(text2, text, false) != 0)
			{
				result.Status = false;
				result.Msg = Conversion.Str(num);
			}
			else if (num < limite_inf | num > limite_sup)
			{
				result.Status = false;
				result.Msg = "";
			}
			else
			{
				result.Status = true;
				result.Msg = Conversion.Str(num);
			}
			return result;
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x0025E880 File Offset: 0x0025CC80
		public static void Atualiza_tabela_equipamentos_vista()
		{
			int qtd_equip_vista = Mod_MD.Central_302_geral.Qtd_equip_vista;
			int i = 1;
			checked
			{
				do
				{
					int j = 1;
					do
					{
						Mod_MD.Tabela_302[i, j] = 0;
						j++;
					}
					while (j <= 40);
					i++;
				}
				while (i <= 5);
				int num = 1;
				int num2 = qtd_equip_vista;
				for (i = num; i <= num2; i++)
				{
					int num_res = Mod_MD.Central_302_centrais[i].num_res;
					int num_rq = Mod_MD.Central_302_centrais[i].num_rq;
					int num3 = 1;
					int num4 = num_res;
					int j;
					for (j = num3; j <= num4; j++)
					{
						Mod_MD.Tabela_302[i, j] = 1;
					}
					int num5 = j;
					int num6 = num_rq + num_res;
					for (int k = num5; k <= num6; k++)
					{
						Mod_MD.Tabela_302[i, k] = 2;
					}
				}
			}
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x0025E92C File Offset: 0x0025CD2C
		public static void Atualiza_dados_MD303(int pag)
		{
			checked
			{
				if (pag == 256)
				{
					Mod_MD.Central_303_geral.Endereco_mestre = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					Mod_MD.Central_303_geral.Endereco_estacao = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					Mod_MD.Central_303_geral.Tempo_ptt = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					Mod_MD.Central_303_geral.Baud_rate_com2 = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
					Mod_MD.Central_303_geral.Qtd_equip_res = (int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12];
					Mod_MD.Central_303_geral.Qdt_equip_rq = (int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14];
				}
				else if (pag == 512)
				{
					int num = 1;
					do
					{
						int num2 = (num - 1) * 2;
						Mod_MD.Central_303_res[num].Msg = (int)Comunicacao.Buffer_resp[3 + num2] * 256 + (int)Comunicacao.Buffer_resp[4 + num2];
						num++;
					}
					while (num <= 40);
				}
				else if (pag == 768)
				{
					Mod_MD.Salva_dados_MD303_RQ(1, 0);
					Mod_MD.Salva_dados_MD303_RQ(2, 0);
					Mod_MD.Salva_dados_MD303_RQ(3, 0);
					Mod_MD.Salva_dados_MD303_RQ(4, 0);
				}
				else if (pag == 844)
				{
					Mod_MD.Salva_dados_MD303_RQ(1, 4);
					Mod_MD.Salva_dados_MD303_RQ(2, 4);
					Mod_MD.Salva_dados_MD303_RQ(3, 4);
				}
				else if (pag == 1024)
				{
					Mod_MD.Salva_dados_MD303_RQ(1, 7);
					Mod_MD.Salva_dados_MD303_RQ(2, 7);
					Mod_MD.Salva_dados_MD303_RQ(3, 7);
					Mod_MD.Salva_dados_MD303_RQ(4, 7);
				}
				else if (pag == 1100)
				{
					Mod_MD.Salva_dados_MD303_RQ(1, 11);
					Mod_MD.Salva_dados_MD303_RQ(2, 11);
					Mod_MD.Salva_dados_MD303_RQ(3, 11);
				}
				else if (pag == 1280)
				{
					Mod_MD.Salva_dados_MD303_RQ(1, 14);
					Mod_MD.Salva_dados_MD303_RQ(2, 14);
					Mod_MD.Salva_dados_MD303_RQ(3, 14);
					Mod_MD.Salva_dados_MD303_RQ(4, 14);
				}
				else if (pag == 1356)
				{
					Mod_MD.Salva_dados_MD303_RQ(1, 18);
					Mod_MD.Salva_dados_MD303_RQ(2, 18);
					Mod_MD.Salva_dados_MD303_RQ(3, 18);
				}
				else if (pag == 1536)
				{
					Mod_MD.Salva_dados_MD303_RQ(1, 21);
					Mod_MD.Salva_dados_MD303_RQ(2, 21);
					Mod_MD.Salva_dados_MD303_RQ(3, 21);
					Mod_MD.Salva_dados_MD303_RQ(4, 21);
				}
				else if (pag == 1612)
				{
					Mod_MD.Salva_dados_MD303_RQ(1, 25);
					Mod_MD.Salva_dados_MD303_RQ(2, 25);
					Mod_MD.Salva_dados_MD303_RQ(3, 25);
				}
				else if (pag == 2304)
				{
					Mod_MD.Central_303_geral.Senha = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
				}
			}
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x0025EBB0 File Offset: 0x0025CFB0
		public static void Salva_dados_MD303_RQ(int indice, int offset_equip)
		{
			checked
			{
				int num = (indice - 1) * 38;
				Mod_MD.Central_303_rq[indice + offset_equip].modelo = (int)Comunicacao.Buffer_resp[3 + num] * 256 + (int)Comunicacao.Buffer_resp[4 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].Msg = (int)Comunicacao.Buffer_resp[5 + num] * 256 + (int)Comunicacao.Buffer_resp[6 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].Hab_cmd = (int)Comunicacao.Buffer_resp[7 + num] * 256 + (int)Comunicacao.Buffer_resp[8 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].escala_1 = (int)Comunicacao.Buffer_resp[9 + num] * 256 + (int)Comunicacao.Buffer_resp[10 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].escala_2 = (int)Comunicacao.Buffer_resp[11 + num] * 256 + (int)Comunicacao.Buffer_resp[12 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].escala_3 = (int)Comunicacao.Buffer_resp[13 + num] * 256 + (int)Comunicacao.Buffer_resp[14 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].escala_4 = (int)Comunicacao.Buffer_resp[15 + num] * 256 + (int)Comunicacao.Buffer_resp[16 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].escala_5 = (int)Comunicacao.Buffer_resp[17 + num] * 256 + (int)Comunicacao.Buffer_resp[18 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].escala_6 = (int)Comunicacao.Buffer_resp[19 + num] * 256 + (int)Comunicacao.Buffer_resp[20 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].escala_7 = (int)Comunicacao.Buffer_resp[21 + num] * 256 + (int)Comunicacao.Buffer_resp[22 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].escala_8 = (int)Comunicacao.Buffer_resp[23 + num] * 256 + (int)Comunicacao.Buffer_resp[24 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].escala_9 = (int)Comunicacao.Buffer_resp[25 + num] * 256 + (int)Comunicacao.Buffer_resp[26 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].escala_10 = (int)Comunicacao.Buffer_resp[27 + num] * 256 + (int)Comunicacao.Buffer_resp[28 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].escala_11 = (int)Comunicacao.Buffer_resp[29 + num] * 256 + (int)Comunicacao.Buffer_resp[30 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].escala_12 = (int)Comunicacao.Buffer_resp[31 + num] * 256 + (int)Comunicacao.Buffer_resp[32 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].escala_13 = (int)Comunicacao.Buffer_resp[33 + num] * 256 + (int)Comunicacao.Buffer_resp[34 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].escala_14 = (int)Comunicacao.Buffer_resp[35 + num] * 256 + (int)Comunicacao.Buffer_resp[36 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].escala_15 = (int)Comunicacao.Buffer_resp[37 + num] * 256 + (int)Comunicacao.Buffer_resp[38 + num];
				Mod_MD.Central_303_rq[indice + offset_equip].escala_16 = (int)Comunicacao.Buffer_resp[39 + num] * 256 + (int)Comunicacao.Buffer_resp[40 + num];
			}
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x0025EF18 File Offset: 0x0025D318
		public static Mod_MD.CTRL_RESP_1 Comandos_gerais_590(int tipo)
		{
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			Mod_MD.CTRL_RESP_1 result;
			result.Msg = "";
			result.Status = false;
			result.Cor = 1;
			checked
			{
				while (i > 0)
				{
					i--;
					Comunicacao.CMD_Esc(tipo);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						result.Msg = "Leitura de bloco OK";
						result.Cor = 0;
						result.Status = true;
						goto IL_E1;
					case 3:
						if (i == 0)
						{
							result.Msg = "Erro Timeout ao ler bloco";
							result.Cor = 1;
							result.Status = false;
													}
						continue;
					}
					if (i == 0)
					{
						result.Msg = "Erro indeterminado";
						result.Cor = 1;
						result.Status = false;
						break;
					}
				}
				IL_E1:
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
				Comunicacao.Rotina_Delay(300L);
				return result;
			}
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x0025F030 File Offset: 0x0025D430
		public static Mod_MD.CTRL_RESP_1 Leitura_eeprom_590(int endereco, int tamanho)
		{
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			Mod_MD.CTRL_RESP_1 result;
			result.Msg = "";
			result.Status = false;
			result.Cor = 1;
			checked
			{
				while (i > 0)
				{
					i--;
					Comunicacao.CMD_Le_eeprom(endereco, tamanho);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						result.Msg = "Leitura de bloco OK";
						result.Cor = 0;
						result.Status = true;
						goto IL_DD;
					case 3:
						if (i == 0)
						{
							result.Msg = "Erro Timeout ao ler bloco";
							result.Cor = 1;
							result.Status = false;
													}
						continue;
					}
					if (i == 0)
					{
						result.Msg = "Erro indeterminado";
						result.Cor = 1;
						result.Status = false;
						break;
					}
				}
				IL_DD:
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
				Comunicacao.Rotina_Delay(300L);
				return result;
			}
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x0025F144 File Offset: 0x0025D544
		public static bool Bit_on(int Dado, int mascara)
		{
			return (Dado & mascara) > 0;
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x0025F160 File Offset: 0x0025D560
		public static Mod_MD.CTRL_PESQ_1 Retira_texto(int end_inicial, ref int[] buffer, int caracter, int max_proc)
		{
			string text = "";
			checked
			{
				int num = max_proc + end_inicial;
				Mod_MD.CTRL_PESQ_1 result;
				for (int i = end_inicial; i <= num; i++)
				{
					if (buffer[i] == caracter)
					{
						result.Msg = text;
						result.Pxm_end = i + 1;
						return result;
					}
					text += Conversions.ToString(Strings.Chr(buffer[i]));
				}
				result.Msg = "";
				result.Pxm_end = -1;
				return result;
			}
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x0025F1C8 File Offset: 0x0025D5C8
		public static void CarregaConfiguracaoDefault_MD101(int indice)
		{
			Mod_MD.Reservatorio[indice].Altura_sensor = 1000;
			Mod_MD.Reservatorio[indice].End_estacao = 1;
			Mod_MD.Reservatorio[indice].End_mestre = 200;
			Mod_MD.Reservatorio[indice].End_repetidora = 100;
			Mod_MD.Reservatorio[indice].Intervalo_filtro = 500;
			Mod_MD.Reservatorio[indice].Tamanho_filtro = 5;
			Mod_MD.Reservatorio[indice].Num_repetidoras = 0;
			Mod_MD.Reservatorio[indice].Offset_sensor = 0;
			Mod_MD.Reservatorio[indice].Range_sensor = 1000;
			Mod_MD.Reservatorio[indice].Tempo_ptt = 20;
			Mod_MD.Reservatorio[indice].Tempo_tx_ponto = 30;
			int num = 0;
			checked
			{
				do
				{
					Mod_MD.Reservatorio[indice].Repetidoras[num] = 0;
					num++;
				}
				while (num <= 50);
			}
		}

		// Token: 0x0400188E RID: 6286
		public const int CONST_201_NINST = 0;

		// Token: 0x0400188F RID: 6287
		public const int CONST_201_PARADO = 1;

		// Token: 0x04001890 RID: 6288
		public const int CONST_201_PARTINDO = 2;

		// Token: 0x04001891 RID: 6289
		public const int CONST_201_OPERANDO = 3;

		// Token: 0x04001892 RID: 6290
		public const int CONST_201_PARANDO = 4;

		// Token: 0x04001893 RID: 6291
		public const int CONST_201_PARADO_ANORMAL = 5;

		// Token: 0x04001894 RID: 6292
		public const int CONST_201_LIGADO_ANORMAL = 6;

		// Token: 0x04001895 RID: 6293
		public const int CONST_BAUDRATE_1200 = 21849;

		// Token: 0x04001896 RID: 6294
		public const int CONST_BAUDRATE_9600 = 21850;

		// Token: 0x04001897 RID: 6295
		public const int CONST_RETORNO_MOTOR1 = 21904;

		// Token: 0x04001898 RID: 6296
		public const int CONST_RETORNO_MOTOR2 = 21905;

		// Token: 0x04001899 RID: 6297
		public const int CONST_RETORNO_MOTOR3 = 21906;

		// Token: 0x0400189A RID: 6298
		public const int CONST_RETORNO_MOTOR4 = 21907;

		// Token: 0x0400189B RID: 6299
		public const int CONST_MONITORAMENTO_ARROMBAMENTO = 21908;

		// Token: 0x0400189C RID: 6300
		public const int CONST_MONITORAMENTO_FALTA_FASE = 21909;

		// Token: 0x0400189D RID: 6301
		public const int CONST_MONITORAMENTO_ALAGAMENTO = 21910;

		// Token: 0x0400189E RID: 6302
		public const int CONST_RETORNO_FECHAMENTO_VALVULA1 = 21911;

		// Token: 0x0400189F RID: 6303
		public const int CONST_RETORNO_FECHAMENTO_VALVULA2 = 21912;

		// Token: 0x040018A0 RID: 6304
		public const int CONST_RETORNO_FECHAMENTO_VALVULA3 = 21913;

		// Token: 0x040018A1 RID: 6305
		public const int CONST_RETORNO_FECHAMENTO_VALVULA4 = 21914;

		// Token: 0x040018A2 RID: 6306
		public const int CONST_RETORNO_ABERTURA_VALVULA1 = 21915;

		// Token: 0x040018A3 RID: 6307
		public const int CONST_RETORNO_ABERTURA_VALVULA2 = 21916;

		// Token: 0x040018A4 RID: 6308
		public const int CONST_RETORNO_ABERTURA_VALVULA3 = 21917;

		// Token: 0x040018A5 RID: 6309
		public const int CONST_RETORNO_ABERTURA_VALVULA4 = 21918;

		// Token: 0x040018A6 RID: 6310
		public const int CONST_OPERACAO_MANUAL = 21888;

		// Token: 0x040018A7 RID: 6311
		public const int CONST_OPERACAO_AUTOMATICA = 21889;

		// Token: 0x040018A8 RID: 6312
		public const int CONST_OPERACAO_TIMER = 21890;

		// Token: 0x040018A9 RID: 6313
		public const int CONST_HABILITA_CMD = 21882;

		// Token: 0x040018AA RID: 6314
		public const int CONST_BLOQUEIO_CMD = 0;

		// Token: 0x040018AB RID: 6315
		public const int CONST_VALOR_INI_TEMPO_PARTIDA = 180;

		// Token: 0x040018AC RID: 6316
		public const int CONST_VALOR_INI_TEMPO_PARADA = 180;

		// Token: 0x040018AD RID: 6317
		public const int CONST_VALOR_INI_TEMPO_ABERTURA_VAL = 180;

		// Token: 0x040018AE RID: 6318
		public const int CONST_VALOR_INI_TEMPO_FECHAMENTO_VAL = 180;

		// Token: 0x040018AF RID: 6319
		public const int CONST_VALOR_INI_NIVEL_DESEJADO = 100;

		// Token: 0x040018B0 RID: 6320
		public const int CONST_VALOR_INI_LIGA_B1 = 1;

		// Token: 0x040018B1 RID: 6321
		public const int CONST_VALOR_INI_LIGA_B2 = 1;

		// Token: 0x040018B2 RID: 6322
		public const int CONST_VALOR_INI_LIGA_B3 = 1;

		// Token: 0x040018B3 RID: 6323
		public const int CONST_VALOR_INI_LIGA_B4 = 1;

		// Token: 0x040018B4 RID: 6324
		public const int CONST_VALOR_INI_TEMPO_MAIS_BOMBA = 0;

		// Token: 0x040018B5 RID: 6325
		public const int CONST_VALOR_INI_PRESSAO_SUCCAO = 5;

		// Token: 0x040018B6 RID: 6326
		public const int CONST_VALOR_INI_PRESSAO_RECALQUE = 5;

		// Token: 0x040018B7 RID: 6327
		public const int CONST_VALOR_INI_PROTECAO_LIGA = 40;

		// Token: 0x040018B8 RID: 6328
		public const int CONST_VALOR_INI_PROTECAO_DESLIGA = 20;

		// Token: 0x040018B9 RID: 6329
		public const int CONST_VALOR_INI_BOMBAS_SIMULTANEAS = 0;

		// Token: 0x040018BA RID: 6330
		public const int CONST_VALOR_INI_TEMPO_ENTRE_ACIONAMENTOS = 0;

		// Token: 0x040018BB RID: 6331
		public const int CONST_VALOR_INI_NUM_TOTALIZACOES = 1;

		// Token: 0x040018BC RID: 6332
		public const int CONST_VALOR_INI_CONTROLE_NIVEL_FONTE = 21921;

		// Token: 0x040018BD RID: 6333
		public const int CONST_LIBERAR_TECLAS = 1;

		// Token: 0x040018BE RID: 6334
		public const int CONST_BLOQUEAR_TECLAS = 2;

		// Token: 0x040018BF RID: 6335
		public const int CONST_LIBERAR_3_5 = 3;

		// Token: 0x040018C0 RID: 6336
		public const int CONST_LIBERAR_20_5 = 4;

		// Token: 0x040018C1 RID: 6337
		public const int MASCARA_ALM_ARROMBAMENTO_201 = 8;

		// Token: 0x040018C2 RID: 6338
		public const int MASCARA_ALM_ENERGIA_201 = 1;

		// Token: 0x040018C3 RID: 6339
		public const int MASCARA_ALM_ALAGAMENTO_201 = 16;

		// Token: 0x040018C4 RID: 6340
		public const int LIMPA_STATUS = 1;

		// Token: 0x040018C5 RID: 6341
		public const int LIMPA_SETPOINTS = 2;

		// Token: 0x040018C6 RID: 6342
		public const int CONST_END_INI_RES = 1;

		// Token: 0x040018C7 RID: 6343
		public const int CONST_END_INI_RQ = 11;

		// Token: 0x040018C8 RID: 6344
		public const int CONST_END_INI_VISTA = 21;

		// Token: 0x040018C9 RID: 6345
		public const int CONST_END_CENTRAL = 200;

		// Token: 0x040018CA RID: 6346
		public const int CONST_ERROS_FALHA = 3;

		// Token: 0x040018CB RID: 6347
		public const int CONST_INTERVALO_POLLING = 3;

		// Token: 0x040018CC RID: 6348
		public const int CONST_QTD_EQUIP_RQ = 0;

		// Token: 0x040018CD RID: 6349
		public const int CONST_QTD_EQUIP_RES = 0;

		// Token: 0x040018CE RID: 6350
		public const int CONST_QTD_EQUIP_VISTA = 0;

		// Token: 0x040018CF RID: 6351
		public const int CONST_QTD_RES = 0;

		// Token: 0x040018D0 RID: 6352
		public const int CONST_RETRAY = 3;

		// Token: 0x040018D1 RID: 6353
		public const int CONST_TEMPO_PTT = 200;

		// Token: 0x040018D2 RID: 6354
		public const int CONST_TIMEOUT = 5;

		// Token: 0x040018D3 RID: 6355
		public const int CONST_RES_INI_ALTURA = 0;

		// Token: 0x040018D4 RID: 6356
		public const int CONST_RES_INI_MSG = 0;

		// Token: 0x040018D5 RID: 6357
		public const int CONST_RES_INI_PRIORIDADE = 1;

		// Token: 0x040018D6 RID: 6358
		public const int CONST_RES_INI_ENDREL = 0;

		// Token: 0x040018D7 RID: 6359
		public const int CONST_ESC_INI = 100;

		// Token: 0x040018D8 RID: 6360
		public const int CONST_MSG_RES_INI = 0;

		// Token: 0x040018D9 RID: 6361
		public const int CONST_RQ_RES_REL_INI = 0;

		// Token: 0x040018DA RID: 6362
		public const int CONST_RQ_MODELO_202 = 2;

		// Token: 0x040018DB RID: 6363
		public const int CONST_RQ_MODELO_201 = 1;

		// Token: 0x040018DC RID: 6364
		public const int CONST_RQ_MSG_INI = 0;

		// Token: 0x040018DD RID: 6365
		public const int CONST_RQ_INI_PRIORIDADE = 1;

		// Token: 0x040018DE RID: 6366
		public const int CONST_RQ_RES_DESTINO = 0;

		// Token: 0x040018DF RID: 6367
		public const int CONST_RQ_RES_ORIGEM = 0;

		// Token: 0x040018E0 RID: 6368
		public const int CONST_HAB_CMD_MAXIMO = 1;

		// Token: 0x040018E1 RID: 6369
		public const int CONST_HAB_CMD_MINIMO = 0;

		// Token: 0x040018E2 RID: 6370
		public const int CONST_NOME_RES_MINIMO = 0;

		// Token: 0x040018E3 RID: 6371
		public const int CONST_NOME_RES_MAXIMO = 9999;

		// Token: 0x040018E4 RID: 6372
		public const int CONST_ALTURA_RES_MINIMO = 0;

		// Token: 0x040018E5 RID: 6373
		public const int CONST_ALTURA_RES_MAXIMO = 20000;

		// Token: 0x040018E6 RID: 6374
		public const int CONST_PRIORIDADE_RES_MINIMO = 0;

		// Token: 0x040018E7 RID: 6375
		public const int CONST_PRIORIDADE_RES_MAXIMO = 13;

		// Token: 0x040018E8 RID: 6376
		public const int CONST_POSICAO_RES_MINIMO = 0;

		// Token: 0x040018E9 RID: 6377
		public const int CONST_POSICAO_RES_MAXIMO = 60;

		// Token: 0x040018EA RID: 6378
		public const int CONST_RQ_RES_MSG_INI = 0;

		// Token: 0x040018EB RID: 6379
		public const int CONST_RQ_ESCALA_INI = 100;

		// Token: 0x040018EC RID: 6380
		public const int CONST_NOME_RQ_MINIMO = 0;

		// Token: 0x040018ED RID: 6381
		public const int CONST_NOME_RQ_MAXIMO = 9999;

		// Token: 0x040018EE RID: 6382
		public const int CONST_MOD_MAXIMO = 1;

		// Token: 0x040018EF RID: 6383
		public const int CONST_MOD_MINIMO = 0;

		// Token: 0x040018F0 RID: 6384
		public const int CONST_ESC_RQ_MAXIMO = 32000;

		// Token: 0x040018F1 RID: 6385
		public const int CONST_ESC_RQ_MINIMO = 1;

		// Token: 0x040018F2 RID: 6386
		public const int CONST_VISTA_RES_MINIMO = 0;

		// Token: 0x040018F3 RID: 6387
		public const int CONST_VISTA_RES_MAXIMO = 40;

		// Token: 0x040018F4 RID: 6388
		public const int CONST_VISTA_RQ_MINIMO = 0;

		// Token: 0x040018F5 RID: 6389
		public const int CONST_VISTA_RQ_MAXIMO = 30;

		// Token: 0x040018F6 RID: 6390
		public const int CONST_TIPO_SEM = 0;

		// Token: 0x040018F7 RID: 6391
		public const int CONST_TIPO_RES = 1;

		// Token: 0x040018F8 RID: 6392
		public const int CONST_TIPO_RQ = 2;

		// Token: 0x040018F9 RID: 6393
		public const int CONST_BLOCO_590_1 = 1;

		// Token: 0x040018FA RID: 6394
		public const int CONST_BLOCO_590_2 = 2;

		// Token: 0x040018FB RID: 6395
		public const int CONST_BLOCO_590_3 = 3;

		// Token: 0x040018FC RID: 6396
		public const int CONST_BLOCO_590_4 = 4;

		// Token: 0x040018FD RID: 6397
		public const int CONST_END_PRODUCT_ID = 0;

		// Token: 0x040018FE RID: 6398
		public const int CONST_END_RANGE_REFRESH = 61;

		// Token: 0x040018FF RID: 6399
		public const int CONST_END_STOP_BIT_DELAY = 63;

		// Token: 0x04001900 RID: 6400
		public const int CONST_END_CHANNEL_NUMBER = 64;

		// Token: 0x04001901 RID: 6401
		public const int CONST_END_SERVER_MODE = 65;

		// Token: 0x04001902 RID: 6402
		public const int CONST_END_BAUDRATE = 66;

		// Token: 0x04001903 RID: 6403
		public const int CONST_END_CONTROL_0 = 69;

		// Token: 0x04001904 RID: 6404
		public const int CONST_END_TRANSMIT_RETRIES = 76;

		// Token: 0x04001905 RID: 6405
		public const int CONST_END_BROADCAST_ATTEMPTS = 77;

		// Token: 0x04001906 RID: 6406
		public const int CONST_END_API_CONTROL = 86;

		// Token: 0x04001907 RID: 6407
		public const int CONST_END_INTERFACE_TIMEOUT = 88;

		// Token: 0x04001908 RID: 6408
		public const int CONST_END_SYNC_CHANNEL = 90;

		// Token: 0x04001909 RID: 6409
		public const int CONST_END_PACKET_SIZE = 91;

		// Token: 0x0400190A RID: 6410
		public const int CONST_END_CTS_ON = 92;

		// Token: 0x0400190B RID: 6411
		public const int CONST_END_CTS_ON_HYSTERESIS = 93;

		// Token: 0x0400190C RID: 6412
		public const int CONST_END_MAX_POWER = 99;

		// Token: 0x0400190D RID: 6413
		public const int CONST_END_MODEM_MODE = 110;

		// Token: 0x0400190E RID: 6414
		public const int CONST_END_PARITY_MODE = 111;

		// Token: 0x0400190F RID: 6415
		public const int CONST_END_485_DE = 127;

		// Token: 0x04001910 RID: 6416
		public const int CONST_END_DESTINATION_ID = 112;

		// Token: 0x04001911 RID: 6417
		public const int CONST_END_SYSTEM_ID = 118;

		// Token: 0x04001912 RID: 6418
		public const int CONST_END_PROTOCOL_STATUS = 192;

		// Token: 0x04001913 RID: 6419
		public const int CONST_END_RECEIVE_API = 193;

		// Token: 0x04001914 RID: 6420
		public const int CONST_END_ENHANCED_API_CONTROL = 198;

		// Token: 0x04001915 RID: 6421
		public const int CONST_END_MAC_ID = 128;

		// Token: 0x04001916 RID: 6422
		public const int CONST_END_DES_KEY = 208;

		// Token: 0x04001917 RID: 6423
		public const int CONST_DEFAULT_ALTURA_SENSOR = 1000;

		// Token: 0x04001918 RID: 6424
		public const int CONST_DEFAULT_END_ESTACAO = 1;

		// Token: 0x04001919 RID: 6425
		public const int CONST_DEFAULT_END_MESTRE = 200;

		// Token: 0x0400191A RID: 6426
		public const int CONST_DEFAULT_END_REPETIDORA = 100;

		// Token: 0x0400191B RID: 6427
		public const int CONST_DEFAULT_INTERVALO_FILTRO = 500;

		// Token: 0x0400191C RID: 6428
		public const int CONST_DEFAULT_TAMANHO_FILTRO = 5;

		// Token: 0x0400191D RID: 6429
		public const int CONST_DEFAULT_NUM_REPETIDORAS = 0;

		// Token: 0x0400191E RID: 6430
		public const int CONST_DEFAULT_OFFSET_SENSOR = 0;

		// Token: 0x0400191F RID: 6431
		public const int CONST_DEFAULT_RANGE_SENSOR = 1000;

		// Token: 0x04001920 RID: 6432
		public const int CONST_DEFAULT_TEMPO_PTT = 20;

		// Token: 0x04001921 RID: 6433
		public const int CONST_DEFAULT_TEMPO_TX_PONTO = 30;

		// Token: 0x04001922 RID: 6434
		public const int CONST_DEFAULT_END_ESTACAO_PARA_REPETIR = 0;

		// Token: 0x04001923 RID: 6435
		public static int NUM_MAX_RE = 40;

		// Token: 0x04001924 RID: 6436
		public static int NUM_MAX_RQ = 28;

		// Token: 0x04001925 RID: 6437
		public static int NUM_MAX_VISTA = 5;

		// Token: 0x04001926 RID: 6438
		public static int END_ESTACAO_MAXIMO = 200;

		// Token: 0x04001927 RID: 6439
		public static int END_ESTACAO_MINIMO = 0;

		// Token: 0x04001928 RID: 6440
		public static Mod_MD.DADOS_EQUIP_MD_101_CONFIG[] Reservatorio;

		// Token: 0x04001929 RID: 6441
		public static Mod_MD.CTRL_MONITORACAO Monitoracao_MD_RE;

		// Token: 0x0400192A RID: 6442
		public static Mod_MD.CTRL_MONITORACAO Monitoracao_MD_RQ;

		// Token: 0x0400192B RID: 6443
		public static Mod_MD.DADOS_EQUIP_MD_201_CONFIG[] Recalque_201;

		// Token: 0x0400192C RID: 6444
		public static Mod_MD.DADOS_EQUIP_MD_202_CONFIG[] Recalque_202;

		// Token: 0x0400192D RID: 6445
		public static Mod_MD.DADOS_EQUIP_MD_302_CONFIG_GERAL Central_302_geral;

		// Token: 0x0400192E RID: 6446
		public static Mod_MD.DADOS_EQUIP_MD_302_CONFIG_RES[] Central_302_res;

		// Token: 0x0400192F RID: 6447
		public static Mod_MD.DADOS_EQUIP_MD_302_CONFIG_RQ[] Central_302_rq;

		// Token: 0x04001930 RID: 6448
		public static Mod_MD.DADOS_EQUIP_MD_302_CONFIG_CENTRAIS[] Central_302_centrais;

		// Token: 0x04001931 RID: 6449
		public static int[,] Central_302_indices;

		// Token: 0x04001932 RID: 6450
		public static Mod_MD.DADOS_EQUIP_MD_303_CONFIG_GERAL Central_303_geral;

		// Token: 0x04001933 RID: 6451
		public static Mod_MD.DADOS_EQUIP_MD_303_CONFIG_RES[] Central_303_res;

		// Token: 0x04001934 RID: 6452
		public static Mod_MD.DADOS_EQUIP_MD_303_CONFIG_RQ[] Central_303_rq;

		// Token: 0x04001935 RID: 6453
		public static Mod_MD.CTRL_RADIO_590 Parametros_590;

		// Token: 0x04001936 RID: 6454
		public static Mod_MD.CTRL_CONFIG Controle;

		// Token: 0x04001937 RID: 6455
		public static Mod_MD.DADOS_CAL Ctrl_cal;

		// Token: 0x04001938 RID: 6456
		public static int[,] Tabela_302;

		// Token: 0x04001939 RID: 6457
		public static int[] Tabela_590;

		// Token: 0x0200008B RID: 139
		public struct CTRL_CONFIG
		{
			// Token: 0x0400193A RID: 6458
			public int Estacao;

			// Token: 0x0400193B RID: 6459
			public int Ctrl_rep;
		}

		// Token: 0x0200008C RID: 140
		public struct DADOS_EQUIP_MD_101_CONFIG
		{
			// Token: 0x0400193C RID: 6460
			public string Versao;

			// Token: 0x0400193D RID: 6461
			public int End_estacao;

			// Token: 0x0400193E RID: 6462
			public int End_mestre;

			// Token: 0x0400193F RID: 6463
			public int Hab_repetidora;

			// Token: 0x04001940 RID: 6464
			public int Tempo_tx_ponto;

			// Token: 0x04001941 RID: 6465
			public int Tempo_ptt;

			// Token: 0x04001942 RID: 6466
			public int Tipo_medida;

			// Token: 0x04001943 RID: 6467
			public int Modo_operacao;

			// Token: 0x04001944 RID: 6468
			public int Range_sensor;

			// Token: 0x04001945 RID: 6469
			public int Altura_sensor;

			// Token: 0x04001946 RID: 6470
			public int Offset_sensor;

			// Token: 0x04001947 RID: 6471
			public int Intervalo_filtro;

			// Token: 0x04001948 RID: 6472
			public int Tamanho_filtro;

			// Token: 0x04001949 RID: 6473
			public int End_repetidora;

			// Token: 0x0400194A RID: 6474
			public int Num_repetidoras;

			// Token: 0x0400194B RID: 6475
			public int[] Repetidoras;
		}

		// Token: 0x0200008D RID: 141
		public struct CTRL_MONITORACAO
		{
			// Token: 0x0400194C RID: 6476
			public int Estacao;

			// Token: 0x0400194D RID: 6477
			public int Mestre;

			// Token: 0x0400194E RID: 6478
			public int Controle_mon;

			// Token: 0x0400194F RID: 6479
			public bool Partir_mon;

			// Token: 0x04001950 RID: 6480
			public int Nivel_dest;

			// Token: 0x04001951 RID: 6481
			public int Nivel_origem;

			// Token: 0x04001952 RID: 6482
			public int alarmes;

			// Token: 0x04001953 RID: 6483
			public long Num_Tx;

			// Token: 0x04001954 RID: 6484
			public long Num_Rx;

			// Token: 0x04001955 RID: 6485
			public long Num_Retry;

			// Token: 0x04001956 RID: 6486
			public int Eficiencia_com;

			// Token: 0x04001957 RID: 6487
			public int Comando;

			// Token: 0x04001958 RID: 6488
			public int Numero_motor;
		}

		// Token: 0x0200008E RID: 142
		public struct DADOS_EQUIP_MD_201_CONFIG
		{
			// Token: 0x04001959 RID: 6489
			public string Versao;

			// Token: 0x0400195A RID: 6490
			public int End_estacao;

			// Token: 0x0400195B RID: 6491
			public int End_mestre;

			// Token: 0x0400195C RID: 6492
			public int Hab_repetidora;

			// Token: 0x0400195D RID: 6493
			public int Tempo_ptt;

			// Token: 0x0400195E RID: 6494
			public int Quantidade_motores;

			// Token: 0x0400195F RID: 6495
			public int[] Modo_partida;

			// Token: 0x04001960 RID: 6496
			public int[] Nivel_acionamento;

			// Token: 0x04001961 RID: 6497
			public int[] Nivel_parada;

			// Token: 0x04001962 RID: 6498
			public int[] Tempo_partida;

			// Token: 0x04001963 RID: 6499
			public int[] Tempo_parada;

			// Token: 0x04001964 RID: 6500
			public int Tempo_entre_acionamento;

			// Token: 0x04001965 RID: 6501
			public int End_repetidora;

			// Token: 0x04001966 RID: 6502
			public int Num_repetidoras;

			// Token: 0x04001967 RID: 6503
			public int[] Repetidoras;
		}

		// Token: 0x0200008F RID: 143
		public struct DADOS_EQUIP_MD_202_CONFIG
		{
			// Token: 0x04001968 RID: 6504
			public string Versao;

			// Token: 0x04001969 RID: 6505
			public int End_estacao;

			// Token: 0x0400196A RID: 6506
			public int End_mestre;

			// Token: 0x0400196B RID: 6507
			public int Hab_repetidora;

			// Token: 0x0400196C RID: 6508
			public int Tempo_ptt;

			// Token: 0x0400196D RID: 6509
			public int BaudRate;

			// Token: 0x0400196E RID: 6510
			public int Intervalo_filtroAD;

			// Token: 0x0400196F RID: 6511
			public int Tamanho_filtroAD;

			// Token: 0x04001970 RID: 6512
			public object Modo_operacao;

			// Token: 0x04001971 RID: 6513
			public int Numero_motores;

			// Token: 0x04001972 RID: 6514
			public int Numero_valvulas;

			// Token: 0x04001973 RID: 6515
			public int[] Modo_partida;

			// Token: 0x04001974 RID: 6516
			public int[] Entrada_digital;

			// Token: 0x04001975 RID: 6517
			public int Set_nivel_desejado;

			// Token: 0x04001976 RID: 6518
			public int Set_nivel_liga_bomba1;

			// Token: 0x04001977 RID: 6519
			public int Set_nivel_liga_bomba2;

			// Token: 0x04001978 RID: 6520
			public int Set_nivel_liga_bomba3;

			// Token: 0x04001979 RID: 6521
			public int Set_nivel_liga_bomba4;

			// Token: 0x0400197A RID: 6522
			public int Tempo_mais_bomba;

			// Token: 0x0400197B RID: 6523
			public int Pressao_min_succao;

			// Token: 0x0400197C RID: 6524
			public int Pressao_min_recalque;

			// Token: 0x0400197D RID: 6525
			public int Nivel_protecao_desliga;

			// Token: 0x0400197E RID: 6526
			public int Nivel_protecao_liga;

			// Token: 0x0400197F RID: 6527
			public int[] Tempo_partida;

			// Token: 0x04001980 RID: 6528
			public int[] Tempo_parada;

			// Token: 0x04001981 RID: 6529
			public int[] Tempo_abertura_val;

			// Token: 0x04001982 RID: 6530
			public int[] Tempo_fechamento_val;

			// Token: 0x04001983 RID: 6531
			public int Num_bombas_simultaneas;

			// Token: 0x04001984 RID: 6532
			public int Tempo_entre_acionamento;

			// Token: 0x04001985 RID: 6533
			public int Controle_nivel_fonte;

			// Token: 0x04001986 RID: 6534
			public int Num_totalizacoes;

			// Token: 0x04001987 RID: 6535
			public int End_repetidora;

			// Token: 0x04001988 RID: 6536
			public int Num_repetidoras;

			// Token: 0x04001989 RID: 6537
			public int[] Repetidoras;

			// Token: 0x0400198A RID: 6538
			public int Periferico_Tipo_1;

			// Token: 0x0400198B RID: 6539
			public int Periferico_End_1;

			// Token: 0x0400198C RID: 6540
			public int Periferico_Tipo_2;

			// Token: 0x0400198D RID: 6541
			public int Periferico_End_2;

			// Token: 0x0400198E RID: 6542
			public int Periferico_Tipo_3;

			// Token: 0x0400198F RID: 6543
			public int Periferico_End_3;

			// Token: 0x04001990 RID: 6544
			public int Periferico_Tipo_4;

			// Token: 0x04001991 RID: 6545
			public int Periferico_End_4;
		}

		// Token: 0x02000090 RID: 144
		public struct DADOS_EQUIP_MD_302_CONFIG_GERAL
		{
			// Token: 0x04001992 RID: 6546
			public string Versao;

			// Token: 0x04001993 RID: 6547
			public int Endereco;

			// Token: 0x04001994 RID: 6548
			public int Retray;

			// Token: 0x04001995 RID: 6549
			public int Timeout;

			// Token: 0x04001996 RID: 6550
			public int Tempo_ptt;

			// Token: 0x04001997 RID: 6551
			public int Baud_rate_com2;

			// Token: 0x04001998 RID: 6552
			public int Erros_falha;

			// Token: 0x04001999 RID: 6553
			public int Intervalo_polling;

			// Token: 0x0400199A RID: 6554
			public int Qtd_res;

			// Token: 0x0400199B RID: 6555
			public int Qtd_equip_res;

			// Token: 0x0400199C RID: 6556
			public int Qdt_equip_rq;

			// Token: 0x0400199D RID: 6557
			public int Qtd_equip_vista;

			// Token: 0x0400199E RID: 6558
			public int End_ini_equip_res;

			// Token: 0x0400199F RID: 6559
			public int End_ini_equip_rq;

			// Token: 0x040019A0 RID: 6560
			public int End_ini_equip_vista;
		}

		// Token: 0x02000091 RID: 145
		public struct DADOS_EQUIP_MD_302_CONFIG_RES
		{
			// Token: 0x040019A1 RID: 6561
			public int Res_relativo;

			// Token: 0x040019A2 RID: 6562
			public int Prioridade;

			// Token: 0x040019A3 RID: 6563
			public int Altura;

			// Token: 0x040019A4 RID: 6564
			public int Msg;
		}

		// Token: 0x02000092 RID: 146
		public struct DADOS_EQUIP_MD_302_CONFIG_RQ
		{
			// Token: 0x040019A5 RID: 6565
			public int Res_origem;

			// Token: 0x040019A6 RID: 6566
			public int Res_destino;

			// Token: 0x040019A7 RID: 6567
			public int Res_relativo_R1;

			// Token: 0x040019A8 RID: 6568
			public int Res_relativo_R2;

			// Token: 0x040019A9 RID: 6569
			public int Res_relativo_R3;

			// Token: 0x040019AA RID: 6570
			public int Res_relativo_R4;

			// Token: 0x040019AB RID: 6571
			public int Msg_res_R1;

			// Token: 0x040019AC RID: 6572
			public int Msg_res_R2;

			// Token: 0x040019AD RID: 6573
			public int Msg_res_R3;

			// Token: 0x040019AE RID: 6574
			public int Msg_res_R4;

			// Token: 0x040019AF RID: 6575
			public int modelo;

			// Token: 0x040019B0 RID: 6576
			public int Prioridade;

			// Token: 0x040019B1 RID: 6577
			public int Msg;

			// Token: 0x040019B2 RID: 6578
			public int Hab_cmd;

			// Token: 0x040019B3 RID: 6579
			public int escala_1;

			// Token: 0x040019B4 RID: 6580
			public int escala_2;

			// Token: 0x040019B5 RID: 6581
			public int escala_3;

			// Token: 0x040019B6 RID: 6582
			public int escala_4;

			// Token: 0x040019B7 RID: 6583
			public int escala_5;

			// Token: 0x040019B8 RID: 6584
			public int escala_6;

			// Token: 0x040019B9 RID: 6585
			public int escala_7;

			// Token: 0x040019BA RID: 6586
			public int escala_8;

			// Token: 0x040019BB RID: 6587
			public int escala_9;

			// Token: 0x040019BC RID: 6588
			public int escala_10;

			// Token: 0x040019BD RID: 6589
			public int escala_11;

			// Token: 0x040019BE RID: 6590
			public int escala_12;

			// Token: 0x040019BF RID: 6591
			public int escala_13;

			// Token: 0x040019C0 RID: 6592
			public int escala_14;

			// Token: 0x040019C1 RID: 6593
			public int escala_15;

			// Token: 0x040019C2 RID: 6594
			public int escala_16;
		}

		// Token: 0x02000093 RID: 147
		public struct DADOS_EQUIP_MD_302_CONFIG_CENTRAIS
		{
			// Token: 0x040019C3 RID: 6595
			public int num_res;

			// Token: 0x040019C4 RID: 6596
			public int num_rq;

			// Token: 0x040019C5 RID: 6597
			public int prioridade;
		}

		// Token: 0x02000094 RID: 148
		public struct DADOS_EQUIP_MD_303_CONFIG_GERAL
		{
			// Token: 0x040019C6 RID: 6598
			public string Versao;

			// Token: 0x040019C7 RID: 6599
			public int Endereco_mestre;

			// Token: 0x040019C8 RID: 6600
			public int Endereco_estacao;

			// Token: 0x040019C9 RID: 6601
			public int Tempo_ptt;

			// Token: 0x040019CA RID: 6602
			public int Baud_rate_com2;

			// Token: 0x040019CB RID: 6603
			public int Qtd_equip_res;

			// Token: 0x040019CC RID: 6604
			public int Qdt_equip_rq;

			// Token: 0x040019CD RID: 6605
			public int Senha;
		}

		// Token: 0x02000095 RID: 149
		public struct DADOS_EQUIP_MD_303_CONFIG_RES
		{
			// Token: 0x040019CE RID: 6606
			public int Msg;
		}

		// Token: 0x02000096 RID: 150
		public struct DADOS_EQUIP_MD_303_CONFIG_RQ
		{
			// Token: 0x040019CF RID: 6607
			public int modelo;

			// Token: 0x040019D0 RID: 6608
			public int Msg;

			// Token: 0x040019D1 RID: 6609
			public int Hab_cmd;

			// Token: 0x040019D2 RID: 6610
			public int escala_1;

			// Token: 0x040019D3 RID: 6611
			public int escala_2;

			// Token: 0x040019D4 RID: 6612
			public int escala_3;

			// Token: 0x040019D5 RID: 6613
			public int escala_4;

			// Token: 0x040019D6 RID: 6614
			public int escala_5;

			// Token: 0x040019D7 RID: 6615
			public int escala_6;

			// Token: 0x040019D8 RID: 6616
			public int escala_7;

			// Token: 0x040019D9 RID: 6617
			public int escala_8;

			// Token: 0x040019DA RID: 6618
			public int escala_9;

			// Token: 0x040019DB RID: 6619
			public int escala_10;

			// Token: 0x040019DC RID: 6620
			public int escala_11;

			// Token: 0x040019DD RID: 6621
			public int escala_12;

			// Token: 0x040019DE RID: 6622
			public int escala_13;

			// Token: 0x040019DF RID: 6623
			public int escala_14;

			// Token: 0x040019E0 RID: 6624
			public int escala_15;

			// Token: 0x040019E1 RID: 6625
			public int escala_16;
		}

		// Token: 0x02000097 RID: 151
		public struct DADOS_CAL
		{
			// Token: 0x040019E2 RID: 6626
			public int End_memoria;

			// Token: 0x040019E3 RID: 6627
			public int Dado;

			// Token: 0x040019E4 RID: 6628
			public int End_equip;

			// Token: 0x040019E5 RID: 6629
			public int Canal;
		}

		// Token: 0x02000098 RID: 152
		public struct CTRL_RESP_1
		{
			// Token: 0x040019E6 RID: 6630
			public bool Status;

			// Token: 0x040019E7 RID: 6631
			public string Msg;

			// Token: 0x040019E8 RID: 6632
			public int Cor;
		}

		// Token: 0x02000099 RID: 153
		public struct CTRL_PESQ_1
		{
			// Token: 0x040019E9 RID: 6633
			public string Msg;

			// Token: 0x040019EA RID: 6634
			public int Pxm_end;
		}

		// Token: 0x0200009A RID: 154
		public struct CTRL_RADIO_590
		{
			// Token: 0x040019EB RID: 6635
			public int RangeRefresh;

			// Token: 0x040019EC RID: 6636
			public int StopBitDelay;

			// Token: 0x040019ED RID: 6637
			public int RFChannelNumber;

			// Token: 0x040019EE RID: 6638
			public int Mode;

			// Token: 0x040019EF RID: 6639
			public int InterfaceBaud;

			// Token: 0x040019F0 RID: 6640
			public int Control_0;

			// Token: 0x040019F1 RID: 6641
			public int TransmitRetries;

			// Token: 0x040019F2 RID: 6642
			public int BroadcastAttempts;

			// Token: 0x040019F3 RID: 6643
			public int APIControl;

			// Token: 0x040019F4 RID: 6644
			public int InterfaceTimeout;

			// Token: 0x040019F5 RID: 6645
			public int SyncToChannel;

			// Token: 0x040019F6 RID: 6646
			public int RFPacketSize;

			// Token: 0x040019F7 RID: 6647
			public int CTSOn;

			// Token: 0x040019F8 RID: 6648
			public int CTSOnHysteresis;

			// Token: 0x040019F9 RID: 6649
			public int MaxPower;

			// Token: 0x040019FA RID: 6650
			public int Destination_1;

			// Token: 0x040019FB RID: 6651
			public int Destination_2;

			// Token: 0x040019FC RID: 6652
			public int Destination_3;

			// Token: 0x040019FD RID: 6653
			public int Destination_4;

			// Token: 0x040019FE RID: 6654
			public int Destination_5;

			// Token: 0x040019FF RID: 6655
			public int Destination_6;

			// Token: 0x04001A00 RID: 6656
			public int ModemMode;

			// Token: 0x04001A01 RID: 6657
			public int RS485DERE;

			// Token: 0x04001A02 RID: 6658
			public int ParityMode;

			// Token: 0x04001A03 RID: 6659
			public int SystemID;

			// Token: 0x04001A04 RID: 6660
			public string MacAddress;

			// Token: 0x04001A05 RID: 6661
			public int ProtocolStatus;

			// Token: 0x04001A06 RID: 6662
			public int ReceiveAPI;

			// Token: 0x04001A07 RID: 6663
			public int EnhancedAPIControl;

			// Token: 0x04001A08 RID: 6664
			public int DesKey_1;

			// Token: 0x04001A09 RID: 6665
			public int DesKey_2;

			// Token: 0x04001A0A RID: 6666
			public int DesKey_3;

			// Token: 0x04001A0B RID: 6667
			public int DesKey_4;

			// Token: 0x04001A0C RID: 6668
			public int DesKey_5;

			// Token: 0x04001A0D RID: 6669
			public int DesKey_6;

			// Token: 0x04001A0E RID: 6670
			public int DesKey_7;

			// Token: 0x04001A0F RID: 6671
			public string FirmwareVersion;
		}
	}
}
