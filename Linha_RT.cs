using System.Drawing;
using System.Windows.Forms;
﻿using System;
using System.Net.Sockets;
using System.Text;
using iS800.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x0200003F RID: 63
	[StandardModule]
	internal sealed class Linha_RT
	{
		// Token: 0x06000EDB RID: 3803 RVA: 0x0022B9D4 File Offset: 0x00229DD4
		public static void Atualiza_dados_RT_810_200(int pag)
		{
			checked
			{
				if (pag == 0)
				{
					RT_geral.RT_810_200_BD.Equip.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_810_200_BD.Versao.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_geral.RT_810_200_BD.Build.Valor = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					RT_geral.RT_810_200_BD.Release.Valor = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
				}
				else if (pag == 256)
				{
					RT_geral.RT_810_200_BD.End_estacao.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_810_200_BD.End_mestre.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_810_200_BD.Hab_repetidora, (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8]);
					RT_geral.RT_810_200_BD.Intervalo_tx_pto_pto.Valor = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
					RT_geral.RT_810_200_BD.Tempo_ptt.Valor = (int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12];
					RT_geral.RT_810_200_BD.Tempo_ptt.Valor = RT_geral.RT_810_200_BD.Tempo_ptt.Valor * 10;
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_810_200_BD.Tipo_nivel, (int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_810_200_BD.Modo_de_operacao, (int)Comunicacao.Buffer_resp[15] * 256 + (int)Comunicacao.Buffer_resp[16]);
					RT_geral.RT_810_200_BD.RangeSensor.Valor = (int)Comunicacao.Buffer_resp[17] * 256 + (int)Comunicacao.Buffer_resp[18];
					RT_geral.RT_810_200_BD.AlturaReservatorio.Valor = (int)Comunicacao.Buffer_resp[19] * 256 + (int)Comunicacao.Buffer_resp[20];
					decimal num = new decimal((int)Comunicacao.Buffer_resp[21] * 256 + (int)Comunicacao.Buffer_resp[22]);
					if (decimal.Compare(num, 4000m) > 0)
					{
						num = decimal.Add(decimal.Multiply(num, -1m), 4000m);
					}
					num = decimal.Multiply(num, new decimal(RT_geral.RT_810_200_BD.RangeSensor.Valor));
					num = decimal.Divide(num, 4000m);
					RT_geral.RT_810_200_BD.ErroOffSet.Valor = Convert.ToInt32(num);
					RT_geral.RT_810_200_BD.AD_Intervalo.Valor = (int)Comunicacao.Buffer_resp[23] * 256 + (int)Comunicacao.Buffer_resp[24];
					RT_geral.RT_810_200_BD.AD_Intervalo.Valor = RT_geral.RT_810_200_BD.AD_Intervalo.Valor * 10;
					RT_geral.RT_810_200_BD.AD_Tamanho_filtro.Valor = (int)Comunicacao.Buffer_resp[25] * 256 + (int)Comunicacao.Buffer_resp[26];
				}
				else if (pag == 512)
				{
					RT_geral.RT_810_200_BD.End_repetidora.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_810_200_BD.Num_repetidoras.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					int num2 = 0;
					do
					{
						RT_geral.RT_810_200_BD.Repetidoras[num2].Valor = (int)Comunicacao.Buffer_resp[2 * num2 + 7] * 256 + (int)Comunicacao.Buffer_resp[2 * num2 + 8];
						num2++;
					}
					while (num2 <= 49);
				}
			}
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0022BD90 File Offset: 0x0022A190
		public static int Retorna_End_Est_GC_82x()
		{
			return checked((int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4]);
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0022BDB4 File Offset: 0x0022A1B4
		public static object AtualizaContagens_GC_82x(int canal, int corrente)
		{
			int num = 0;
			int num2 = 0;
			if (corrente == 4)
			{
				num2 = 8;
			}
			else if (corrente == 20)
			{
				num2 = 12;
			}
			checked
			{
				switch (canal)
				{
				case 1:
					num = (int)Comunicacao.Buffer_resp[3 + num2] * 256 + (int)Comunicacao.Buffer_resp[4 + num2];
					break;
				case 2:
					num = (int)Comunicacao.Buffer_resp[5 + num2] * 256 + (int)Comunicacao.Buffer_resp[6 + num2];
					break;
				}
				return num;
			}
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0022BE28 File Offset: 0x0022A228
		public static void Atualiza_dados_GC_82x(int pag)
		{
			checked
			{
				if (pag == 0)
				{
					RT_geral.GC_82x_BD.Equip.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.GC_82x_BD.Versao.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_geral.GC_82x_BD.Build.Valor = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					RT_geral.GC_82x_BD.Release.Valor = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
				}
				else if (pag == 2048)
				{
					RT_geral.GC_82x_BD.End_estacao.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.GC_82x_BD.End_mestre.Valor = 0;
					RT_geral.GC_82x_BD.modo_SD1.Valor = 0;
					RT_geral.GC_82x_BD.modo_SD2.Valor = 0;
					RT_geral.GC_82x_BD.modo_SD3.Valor = 0;
					RT_geral.GC_82x_BD.liga_SD1.Valor = 0;
					RT_geral.GC_82x_BD.liga_SD2.Valor = 0;
					RT_geral.GC_82x_BD.liga_SD3.Valor = 0;
					RT_geral.GC_82x_BD.desliga_SD1.Valor = 0;
					RT_geral.GC_82x_BD.desliga_SD2.Valor = 0;
					RT_geral.GC_82x_BD.desliga_SD3.Valor = 0;
					RT_geral.GC_82x_BD.sentido_SD1.Valor = 0;
					RT_geral.GC_82x_BD.sentido_SD2.Valor = 0;
					RT_geral.GC_82x_BD.sentido_SD3.Valor = 0;
					RT_geral.GC_82x_BD.modo_SA1.Valor = 21937;
					RT_geral.GC_82x_BD.modo_SA2.Valor = 21938;
					RT_geral.GC_82x_BD.limt_inferior1.Valor = (int)Comunicacao.Buffer_resp[35] * 256 + (int)Comunicacao.Buffer_resp[36];
					RT_geral.GC_82x_BD.limt_inferior2.Valor = (int)Comunicacao.Buffer_resp[37] * 256 + (int)Comunicacao.Buffer_resp[38];
					RT_geral.GC_82x_BD.limt_superior1.Valor = (int)Comunicacao.Buffer_resp[39] * 256 + (int)Comunicacao.Buffer_resp[40];
					RT_geral.GC_82x_BD.limt_superior2.Valor = (int)Comunicacao.Buffer_resp[41] * 256 + (int)Comunicacao.Buffer_resp[42];
					RT_geral.GC_82x_BD.AD_Intervalo.Valor = 100;
					RT_geral.GC_82x_BD.AD_Tamanho_filtro.Valor = 1;
				}
			}
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0022C0B8 File Offset: 0x0022A4B8
		public static void Atualiza_dados_IER_856(int pag)
		{
			checked
			{
				if (pag == 0)
				{
					RT_geral.IEC_855_BD.Equip.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.IEC_855_BD.Versao.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_geral.IEC_855_BD.Build.Valor = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					RT_geral.IEC_855_BD.Release.Valor = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
					RT_geral.IEC_855_BD.MAC[0] = Comunicacao.Buffer_resp[12];
					RT_geral.IEC_855_BD.MAC[1] = Comunicacao.Buffer_resp[11];
					RT_geral.IEC_855_BD.MAC[2] = Comunicacao.Buffer_resp[14];
					RT_geral.IEC_855_BD.MAC[3] = Comunicacao.Buffer_resp[13];
					RT_geral.IEC_855_BD.MAC[4] = Comunicacao.Buffer_resp[16];
					RT_geral.IEC_855_BD.MAC[5] = Comunicacao.Buffer_resp[15];
				}
				else if (pag == 512)
				{
					RT_geral.IEC_855_BD.BaudRateCOM1.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.IEC_855_BD.BaudRateCOM1.AtualizaIndicePeloValor();
					RT_geral.IEC_855_BD.AtribuicaoIP.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_geral.IEC_855_BD.AtribuicaoIP.AtualizaIndicePeloValor();
				}
				else if (pag == 1024)
				{
					byte b = Comunicacao.Buffer_resp[4];
					byte b2 = Comunicacao.Buffer_resp[3];
					byte b3 = Comunicacao.Buffer_resp[6];
					byte b4 = Comunicacao.Buffer_resp[5];
					RT_geral.IEC_855_BD.STATIC_IP = string.Concat(new string[]
					{
						b.ToString(),
						".",
						b2.ToString(),
						".",
						b3.ToString(),
						".",
						b4.ToString()
					});
					b = Comunicacao.Buffer_resp[8];
					b2 = Comunicacao.Buffer_resp[7];
					b3 = Comunicacao.Buffer_resp[10];
					b4 = Comunicacao.Buffer_resp[9];
					RT_geral.IEC_855_BD.STATIC_GW = string.Concat(new string[]
					{
						b.ToString(),
						".",
						b2.ToString(),
						".",
						b3.ToString(),
						".",
						b4.ToString()
					});
					b = Comunicacao.Buffer_resp[12];
					b2 = Comunicacao.Buffer_resp[11];
					b3 = Comunicacao.Buffer_resp[14];
					b4 = Comunicacao.Buffer_resp[13];
					RT_geral.IEC_855_BD.STATIC_SM = string.Concat(new string[]
					{
						b.ToString(),
						".",
						b2.ToString(),
						".",
						b3.ToString(),
						".",
						b4.ToString()
					});
					b = Comunicacao.Buffer_resp[16];
					b2 = Comunicacao.Buffer_resp[15];
					b3 = Comunicacao.Buffer_resp[18];
					b4 = Comunicacao.Buffer_resp[17];
					RT_geral.IEC_855_BD.DHCP_IP = string.Concat(new string[]
					{
						b.ToString(),
						".",
						b2.ToString(),
						".",
						b3.ToString(),
						".",
						b4.ToString()
					});
					b = Comunicacao.Buffer_resp[20];
					b2 = Comunicacao.Buffer_resp[19];
					b3 = Comunicacao.Buffer_resp[22];
					b4 = Comunicacao.Buffer_resp[21];
					RT_geral.IEC_855_BD.DHCP_GW = string.Concat(new string[]
					{
						b.ToString(),
						".",
						b2.ToString(),
						".",
						b3.ToString(),
						".",
						b4.ToString()
					});
					b = Comunicacao.Buffer_resp[24];
					b2 = Comunicacao.Buffer_resp[23];
					b3 = Comunicacao.Buffer_resp[26];
					b4 = Comunicacao.Buffer_resp[25];
					RT_geral.IEC_855_BD.DHCP_SM = string.Concat(new string[]
					{
						b.ToString(),
						".",
						b2.ToString(),
						".",
						b3.ToString(),
						".",
						b4.ToString()
					});
				}
			}
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0022C58C File Offset: 0x0022A98C
		public static void Atualiza_dados_IEC_855(int pag)
		{
			checked
			{
				if (pag == 0)
				{
					RT_geral.IEC_855_BD.Equip.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.IEC_855_BD.Versao.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_geral.IEC_855_BD.Build.Valor = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					RT_geral.IEC_855_BD.Release.Valor = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
					RT_geral.IEC_855_BD.MAC[0] = Comunicacao.Buffer_resp[12];
					RT_geral.IEC_855_BD.MAC[1] = Comunicacao.Buffer_resp[11];
					RT_geral.IEC_855_BD.MAC[2] = Comunicacao.Buffer_resp[14];
					RT_geral.IEC_855_BD.MAC[3] = Comunicacao.Buffer_resp[13];
					RT_geral.IEC_855_BD.MAC[4] = Comunicacao.Buffer_resp[16];
					RT_geral.IEC_855_BD.MAC[5] = Comunicacao.Buffer_resp[15];
				}
				else if (pag == 512)
				{
					RT_geral.IEC_855_BD.BaudRateCOM1.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.IEC_855_BD.BaudRateCOM1.AtualizaIndicePeloValor();
					RT_geral.IEC_855_BD.AtribuicaoIP.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_geral.IEC_855_BD.AtribuicaoIP.AtualizaIndicePeloValor();
				}
				else if (pag == 1024)
				{
					byte b = Comunicacao.Buffer_resp[4];
					byte b2 = Comunicacao.Buffer_resp[3];
					byte b3 = Comunicacao.Buffer_resp[6];
					byte b4 = Comunicacao.Buffer_resp[5];
					RT_geral.IEC_855_BD.STATIC_IP = string.Concat(new string[]
					{
						b.ToString(),
						".",
						b2.ToString(),
						".",
						b3.ToString(),
						".",
						b4.ToString()
					});
					b = Comunicacao.Buffer_resp[8];
					b2 = Comunicacao.Buffer_resp[7];
					b3 = Comunicacao.Buffer_resp[10];
					b4 = Comunicacao.Buffer_resp[9];
					RT_geral.IEC_855_BD.STATIC_GW = string.Concat(new string[]
					{
						b.ToString(),
						".",
						b2.ToString(),
						".",
						b3.ToString(),
						".",
						b4.ToString()
					});
					b = Comunicacao.Buffer_resp[12];
					b2 = Comunicacao.Buffer_resp[11];
					b3 = Comunicacao.Buffer_resp[14];
					b4 = Comunicacao.Buffer_resp[13];
					RT_geral.IEC_855_BD.STATIC_SM = string.Concat(new string[]
					{
						b.ToString(),
						".",
						b2.ToString(),
						".",
						b3.ToString(),
						".",
						b4.ToString()
					});
					b = Comunicacao.Buffer_resp[16];
					b2 = Comunicacao.Buffer_resp[15];
					b3 = Comunicacao.Buffer_resp[18];
					b4 = Comunicacao.Buffer_resp[17];
					RT_geral.IEC_855_BD.DHCP_IP = string.Concat(new string[]
					{
						b.ToString(),
						".",
						b2.ToString(),
						".",
						b3.ToString(),
						".",
						b4.ToString()
					});
					b = Comunicacao.Buffer_resp[20];
					b2 = Comunicacao.Buffer_resp[19];
					b3 = Comunicacao.Buffer_resp[22];
					b4 = Comunicacao.Buffer_resp[21];
					RT_geral.IEC_855_BD.DHCP_GW = string.Concat(new string[]
					{
						b.ToString(),
						".",
						b2.ToString(),
						".",
						b3.ToString(),
						".",
						b4.ToString()
					});
					b = Comunicacao.Buffer_resp[24];
					b2 = Comunicacao.Buffer_resp[23];
					b3 = Comunicacao.Buffer_resp[26];
					b4 = Comunicacao.Buffer_resp[25];
					RT_geral.IEC_855_BD.DHCP_SM = string.Concat(new string[]
					{
						b.ToString(),
						".",
						b2.ToString(),
						".",
						b3.ToString(),
						".",
						b4.ToString()
					});
				}
				else if (pag == 1536)
				{
					int num = 0;
					int num2 = 0;
					int num3 = 0;
					do
					{
						byte b = Comunicacao.Buffer_resp[4 + num];
						byte b2 = Comunicacao.Buffer_resp[3 + num];
						byte b3 = Comunicacao.Buffer_resp[6 + num];
						byte b4 = Comunicacao.Buffer_resp[5 + num];
						string text = string.Concat(new string[]
						{
							b.ToString(),
							".",
							b2.ToString(),
							".",
							b3.ToString(),
							".",
							b4.ToString()
						});
						RT_geral.IEC_855_BD.tab_ips[num2] = text;
						num2++;
						num += 4;
						num3++;
					}
					while (num3 <= 49);
				}
				else if (pag == 2048)
				{
					int num = 0;
					int num2 = 50;
					int num3 = 0;
					do
					{
						byte b = Comunicacao.Buffer_resp[4 + num];
						byte b2 = Comunicacao.Buffer_resp[3 + num];
						byte b3 = Comunicacao.Buffer_resp[6 + num];
						byte b4 = Comunicacao.Buffer_resp[5 + num];
						string text = string.Concat(new string[]
						{
							b.ToString(),
							".",
							b2.ToString(),
							".",
							b3.ToString(),
							".",
							b4.ToString()
						});
						RT_geral.IEC_855_BD.tab_ips[num2] = text;
						num2++;
						num += 4;
						num3++;
					}
					while (num3 <= 49);
				}
				else if (pag == 2560)
				{
					int num = 0;
					int num2 = 100;
					int num3 = 0;
					do
					{
						byte b = Comunicacao.Buffer_resp[4 + num];
						byte b2 = Comunicacao.Buffer_resp[3 + num];
						byte b3 = Comunicacao.Buffer_resp[6 + num];
						byte b4 = Comunicacao.Buffer_resp[5 + num];
						string text = string.Concat(new string[]
						{
							b.ToString(),
							".",
							b2.ToString(),
							".",
							b3.ToString(),
							".",
							b4.ToString()
						});
						RT_geral.IEC_855_BD.tab_ips[num2] = text;
						num2++;
						num += 4;
						num3++;
					}
					while (num3 <= 49);
				}
				else if (pag == 3072)
				{
					int num = 0;
					int num2 = 150;
					int num3 = 0;
					do
					{
						byte b = Comunicacao.Buffer_resp[4 + num];
						byte b2 = Comunicacao.Buffer_resp[3 + num];
						byte b3 = Comunicacao.Buffer_resp[6 + num];
						byte b4 = Comunicacao.Buffer_resp[5 + num];
						string text = string.Concat(new string[]
						{
							b.ToString(),
							".",
							b2.ToString(),
							".",
							b3.ToString(),
							".",
							b4.ToString()
						});
						RT_geral.IEC_855_BD.tab_ips[num2] = text;
						num2++;
						num += 4;
						num3++;
					}
					while (num3 <= 49);
				}
			}
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0022CD5C File Offset: 0x0022B15C
		public static void Atualiza_dados_RT_810(int pag)
		{
			checked
			{
				if (pag == 0)
				{
					RT_geral.RT_810_BD.Equip.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_810_BD.Versao.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_geral.RT_810_BD.Build.Valor = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					RT_geral.RT_810_BD.Release.Valor = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
				}
				else if (pag == 2048)
				{
					RT_geral.RT_810_BD.End_estacao.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_810_BD.End_mestre.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_810_BD.Modelo, (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_810_BD.Hab_repetidora, (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10]);
					RT_geral.RT_810_BD.Tempo_ptt.Valor = (int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_810_BD.Modo_de_operacao, (int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14]);
					RT_geral.RT_810_BD.Intervalo_tx_pto_pto.Valor = (int)Comunicacao.Buffer_resp[15] * 256 + (int)Comunicacao.Buffer_resp[16];
					RT_geral.RT_810_BD.AD_Intervalo.Valor = (int)Comunicacao.Buffer_resp[17] * 256 + (int)Comunicacao.Buffer_resp[18];
					RT_geral.RT_810_BD.AD_Tamanho_filtro.Valor = (int)Comunicacao.Buffer_resp[19] * 256 + (int)Comunicacao.Buffer_resp[20];
					RT_geral.RT_810_BD.EA_Range[0].Valor = (int)Comunicacao.Buffer_resp[21] * 256 + (int)Comunicacao.Buffer_resp[22];
					RT_geral.RT_810_BD.EA_Range[1].Valor = (int)Comunicacao.Buffer_resp[23] * 256 + (int)Comunicacao.Buffer_resp[24];
					RT_geral.RT_810_BD.EA_Range[2].Valor = (int)Comunicacao.Buffer_resp[25] * 256 + (int)Comunicacao.Buffer_resp[26];
					RT_geral.RT_810_BD.EA_Range[3].Valor = (int)Comunicacao.Buffer_resp[27] * 256 + (int)Comunicacao.Buffer_resp[28];
					RT_geral.RT_810_BD.EA_Inicio[0].Valor = (int)Comunicacao.Buffer_resp[29] * 256 + (int)Comunicacao.Buffer_resp[30];
					RT_geral.RT_810_BD.EA_Inicio[1].Valor = (int)Comunicacao.Buffer_resp[31] * 256 + (int)Comunicacao.Buffer_resp[32];
					RT_geral.RT_810_BD.EA_Inicio[2].Valor = (int)Comunicacao.Buffer_resp[33] * 256 + (int)Comunicacao.Buffer_resp[34];
					RT_geral.RT_810_BD.EA_Inicio[3].Valor = (int)Comunicacao.Buffer_resp[35] * 256 + (int)Comunicacao.Buffer_resp[36];
					RT_geral.RT_810_BD.EA_Fim[0].Valor = (int)Comunicacao.Buffer_resp[37] * 256 + (int)Comunicacao.Buffer_resp[38];
					RT_geral.RT_810_BD.EA_Fim[1].Valor = (int)Comunicacao.Buffer_resp[39] * 256 + (int)Comunicacao.Buffer_resp[40];
					RT_geral.RT_810_BD.EA_Fim[2].Valor = (int)Comunicacao.Buffer_resp[41] * 256 + (int)Comunicacao.Buffer_resp[42];
					RT_geral.RT_810_BD.EA_Fim[3].Valor = (int)Comunicacao.Buffer_resp[43] * 256 + (int)Comunicacao.Buffer_resp[44];
					Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_810_BD.ctrl_acionamento[0], RT_geral.RT_810_DataGrigViewProcessosColunas[0], (int)Comunicacao.Buffer_resp[45] * 256 + (int)Comunicacao.Buffer_resp[46]);
					Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_810_BD.ctrl_ret_acionamento[0], RT_geral.RT_810_DataGrigViewProcessosColunas[1], (int)Comunicacao.Buffer_resp[47] * 256 + (int)Comunicacao.Buffer_resp[48]);
					Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_810_BD.ctrl_ED_selecao[0], RT_geral.RT_810_DataGrigViewProcessosColunas[2], (int)Comunicacao.Buffer_resp[49] * 256 + (int)Comunicacao.Buffer_resp[50]);
					Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_810_BD.ctrl_reverso[0], RT_geral.RT_810_DataGrigViewProcessosColunas[3], (int)Comunicacao.Buffer_resp[51] * 256 + (int)Comunicacao.Buffer_resp[52]);
					Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_810_BD.ctrl_modo[0], RT_geral.RT_810_DataGrigViewProcessosColunas[4], (int)Comunicacao.Buffer_resp[53] * 256 + (int)Comunicacao.Buffer_resp[54]);
					RT_geral.RT_810_BD.ctrl_tempo_max_partida[0].Valor = (int)Comunicacao.Buffer_resp[55] * 256 + (int)Comunicacao.Buffer_resp[56];
					RT_geral.RT_810_BD.ctrl_tempo_max_parada[0].Valor = (int)Comunicacao.Buffer_resp[57] * 256 + (int)Comunicacao.Buffer_resp[58];
					int num = 0;
					do
					{
						int num2 = num * 2;
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_810_BD.config_ED[num], RT_geral.RT_810_DataGrigViewEDColunas[0], (int)Comunicacao.Buffer_resp[59 + num2] * 256 + (int)Comunicacao.Buffer_resp[60 + num2]);
						num++;
					}
					while (num <= 7);
					RT_geral.RT_810_BD.Hab_eletrodos.Valor = (int)Comunicacao.Buffer_resp[75] * 256 + (int)Comunicacao.Buffer_resp[76];
					RT_geral.RT_810_BD.BaudRateCOM1.Valor = (int)Comunicacao.Buffer_resp[77] * 256 + (int)Comunicacao.Buffer_resp[78];
					RT_geral.RT_810_BD.BaudRateCOM2.Valor = (int)Comunicacao.Buffer_resp[79] * 256 + (int)Comunicacao.Buffer_resp[80];
					if (!perifericos.Lista_ValorPermitido(RT_geral.RT_810_BD.BaudRateCOM1.Valor, perifericos.ListaBaudRate))
					{
						RT_geral.RT_810_BD.BaudRateCOM1.Valor = 21857;
					}
					RT_geral.RT_810_BD.BaudRateCOM1.Indice = perifericos.Get_Indice_Pelo_Valor(RT_geral.RT_810_BD.BaudRateCOM1.Valor, perifericos.ListaBaudRate);
					if (!perifericos.Lista_ValorPermitido(RT_geral.RT_810_BD.BaudRateCOM2.Valor, perifericos.ListaBaudRate))
					{
						RT_geral.RT_810_BD.BaudRateCOM2.Valor = 21856;
					}
					RT_geral.RT_810_BD.BaudRateCOM2.Indice = perifericos.Get_Indice_Pelo_Valor(RT_geral.RT_810_BD.BaudRateCOM2.Valor, perifericos.ListaBaudRate);
				}
				else if (pag == 4096)
				{
					RT_geral.RT_810_BD.End_repetidora.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_810_BD.Num_repetidoras.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					int num3 = 0;
					do
					{
						RT_geral.RT_810_BD.Repetidoras[num3].Valor = (int)Comunicacao.Buffer_resp[2 * num3 + 7] * 256 + (int)Comunicacao.Buffer_resp[2 * num3 + 8];
						num3++;
					}
					while (num3 <= 49);
				}
				else if (pag == 8192)
				{
					Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_810_BD.Setpoints_ctrl_variavel[0], RT_geral.RT_810_DataGrigViewSetpointsColunas[0], (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4]);
				}
				else if (pag == 10240)
				{
					RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[0].Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[0].Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
				}
			}
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0022D5A0 File Offset: 0x0022B9A0
		public static void Atualiza_estrutura_combo_dataview(ref RT_geral.Combo_ictel_ctrl combo, RT_geral.DADOS_DATAGRIDVIEW_RT_820 dataview, int dado)
		{
			bool flag = false;
			int num = 0;
			checked
			{
				int num2 = dataview.NumeroLinhaMenu - 1;
				int i;
				for (i = num; i <= num2; i++)
				{
					if (dataview.LinhasValor[i] == dado)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					combo.Valor = dado;
					combo.Indice = i;
				}
				else
				{
					combo.Indice = combo.Indice_padrao;
					combo.Valor = dataview.LinhasValor[combo.Indice];
				}
			}
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0022D608 File Offset: 0x0022BA08
		public static void Atualiza_estrutura_combo(ref RT_geral.Combo_ictel combo, int dado)
		{
			bool flag = false;
			int num = 0;
			checked
			{
				int num2 = combo.Numero_itens - 1;
				int i;
				for (i = num; i <= num2; i++)
				{
					if (combo.valores[i] == dado)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					combo.Valor = dado;
					combo.Indice = i;
				}
				else
				{
					combo.Indice = combo.Indice_padrao;
					combo.Valor = combo.valores[combo.Indice];
				}
			}
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0022D670 File Offset: 0x0022BA70
		public static bool VerificaSeEquipamento_SA_820_400_MAIOR_IGUAL_R19(int tipo, int equip = 0, int versao = 0, string extensao = "")
		{
			checked
			{
				switch (tipo)
				{
				case 2:
				{
					equip = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					versao = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					int num = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					int num2 = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
					if (equip == 820 & versao == 4 & num2 >= 19)
					{
						return true;
					}
					string text = string.Concat(new string[]
					{
						"Equipamento lido não é compatível!\r\n\r\nInformações obtidas : \r\nEquipamento : ",
						Conversion.Str(equip),
						"\r\nVersão : ",
						Conversion.Str(versao),
						"\r\nBuild : ",
						Conversion.Str(num),
						"\r\nRelease : ",
						Conversion.Str(num2)
					});
					MessageBox.Show(text);
					break;
				}
				}
				return false;
			}
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0022D784 File Offset: 0x0022BB84
		public static bool VerificaSeEquipamento_GC_82x(int tipo, int equip = 0, int versao = 0, string extensao = "")
		{
			checked
			{
				switch (tipo)
				{
				case 1:
				{
					int num = equip;
					if (num == 824 || num == 828 || num == 920)
					{
						int num2 = versao;
						if ((num2 == 3 || num2 == 300) && string.Compare(extensao, ".CfgGC82x", true) == 0)
						{
							return true;
						}
					}
					break;
				}
				case 2:
					equip = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					versao = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					if (equip == 920 | equip == 824 | equip == 828)
					{
						if (versao == 300 | versao == 3)
						{
							return true;
						}
					}
					else
					{
						string text = string.Concat(new string[]
						{
							"Equipamento lido não é compatível!\r\n\r\nInformações obtidas : \r\nEquipamento : ",
							Conversion.Str(equip),
							"\r\nVersão : ",
							Conversion.Str(versao),
							"\r\n"
						});
						MessageBox.Show(text);
					}
					break;
				}
				return false;
			}
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0022D89C File Offset: 0x0022BC9C
		public static Mod_MD.CTRL_RESP_1 VerificaSeEquipamentoEValido(int tipo, int equip = 0, int versao = 0, int build = 0, int release = 0, string extensao = "")
		{
			Mod_MD.CTRL_RESP_1 result;
			result.Msg = "Equipamento não compatível";
			result.Cor = 1;
			result.Status = false;
			checked
			{
				switch (tipo)
				{
				case 1:
				{
					bool flag = false;
					int equipamento_selecionado = Geral.Equipamento_selecionado;
					if (equipamento_selecionado == 810)
					{
						switch (versao)
						{
						case 2:
							if (string.Compare(extensao, ".Cfg810_200", true) == 0)
							{
								flag = true;
							}
							break;
						case 3:
							if (string.Compare(extensao, ".Cfg810", true) == 0)
							{
								flag = true;
							}
							break;
						}
					}
					else if (equipamento_selecionado == 820)
					{
						switch (versao)
						{
						case 2:
							if (string.Compare(extensao, ".Cfg820_200", true) == 0)
							{
								flag = true;
							}
							break;
						case 3:
							if (string.Compare(extensao, ".Cfg820", true) == 0)
							{
								flag = true;
							}
							break;
						case 4:
							if (string.Compare(extensao, ".Cfg820_400", true) == 0)
							{
								flag = true;
							}
							break;
						}
					}
					else if (equipamento_selecionado == 821)
					{
						switch (versao)
						{
						case 2:
							if (string.Compare(extensao, ".Cfg821_200", true) == 0)
							{
								flag = true;
							}
							break;
						case 3:
							if (string.Compare(extensao, ".Cfg821", true) == 0)
							{
								flag = true;
							}
							break;
						}
					}
					else if (equipamento_selecionado == 830)
					{
						int num = versao;
						if (num == 2)
						{
							if (string.Compare(extensao, ".Cfg830", true) == 0)
							{
								flag = true;
							}
						}
					}
					else if (equipamento_selecionado == 831)
					{
						int num2 = versao;
						if (num2 == 2)
						{
							if (string.Compare(extensao, ".Cfg831", true) == 0)
							{
								flag = true;
							}
						}
					}
					else if (equipamento_selecionado == 850 && string.Compare(extensao, ".Cfg850", true) == 0)
					{
						flag = true;
					}
					if (!flag)
					{
						string text = "Tipo do arquivo selecionado não é compatível com o Equipamento!";
						MessageBox.Show(text, " Atenção ", 0, 16);
						return result;
					}
					break;
				}
				case 2:
					equip = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					versao = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					build = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					release = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
					if (Geral.Equipamento_selecionado != equip)
					{
						string text = string.Concat(new string[]
						{
							"Equipamento lido não é o selecionado!\r\n\r\nInformações obtidas : \r\nEquipamento : ",
							Conversion.Str(equip),
							"\r\nVersão : ",
							Conversion.Str(versao),
							"\r\nBuild : ",
							Conversion.Str(build),
							"\r\nRelease : ",
							Conversion.Str(release)
						});
						MessageBox.Show(text, " Atenção ", 0, 16);
						return result;
					}
					if (equip == 920 & versao == 300)
					{
						versao = 3;
					}
					if (Geral.Equipamento_selecionado == equip & Geral.Equipamento_versao != versao)
					{
						string text = string.Concat(new string[]
						{
							"Equipamento lido não é o selecionado!\r\n\r\nInformações obtidas : \r\nEquipamento : ",
							Conversion.Str(equip),
							"\r\nVersão : ",
							Conversion.Str(versao),
							"\r\nBuild : ",
							Conversion.Str(build),
							"\r\nRelease : ",
							Conversion.Str(release)
						});
						MessageBox.Show(text, " Atenção ", 0, 16);
						return result;
					}
					break;
				}
				int num3 = Geral.Equipamento_versao * 1000;
				int num4 = versao * 1000;
				if (num4 == num3 | num4 == Geral.Equipamento_versao * 1000 + 10 | num4 == Geral.Equipamento_versao * 1000 + 20)
				{
					result.Msg = "Equipamento compatível";
					result.Cor = 0;
					result.Status = true;
				}
				else
				{
					switch (tipo)
					{
					case 1:
					{
						string text = string.Concat(new string[]
						{
							"Arquivo lido possui uma versão de sotfware diferente da selecionada! \r\n\r\n   Informações obtidas : \r\n\r\n           Equipamento : ",
							Conversion.Str(equip),
							"\r\n           Versão : ",
							Conversion.Str(versao),
							"\r\n           Build : ",
							Conversion.Str(build),
							"\r\n           Release : ",
							Conversion.Str(release),
							"\r\n\r\n   A utilização destes dados poderá implicar em interpretações erradas.\r\n   Todos os parâmetros deverão ser conferidos, caso sejam utilizados.\r\n\r\n   Deseja continuar?"
						});
						if (MessageBox.Show(text, " Atenção ", 4, 16) != 7)
						{
						}
						break;
					}
					case 2:
					{
						string text = string.Concat(new string[]
						{
							"Equipamento lido possui uma versão de sotfware diferente da selecionada! \r\n\r\nInformações obtidas : \r\nEquipamento : ",
							Conversion.Str(equip),
							"\r\nVersão : ",
							Conversion.Str(versao),
							"\r\nBuild : ",
							Conversion.Str(build),
							"\r\nRelease : ",
							Conversion.Str(release)
						});
						MessageBox.Show(text, " Atenção ", 0, 16);
						break;
					}
					}
				}
				return result;
			}
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0022DD94 File Offset: 0x0022C194
		public static int CMD_Esc_TCP(int quantos_tx, NetworkStream ns)
		{
			byte[] array = new byte[4097];
			checked
			{
				if (Comunicacao.Config_sistema.tipo_interface == 2)
				{
					int num = quantos_tx - 2;
					array[0] = 0;
					array[1] = 0;
					array[2] = 0;
					array[3] = 0;
					array[4] = (byte)(num / 256);
					array[5] = (byte)(num % 256);
					int num2 = 0;
					int num3 = num - 1;
					for (int i = num2; i <= num3; i++)
					{
						array[6 + i] = Comunicacao.Buffer_cmd[i];
					}
					num += 6;
					ns.Write(array, 0, num);
				}
				return 0;
			}
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0022DE14 File Offset: 0x0022C214
		public static int CMD_Esc_RT_810_H800(int endereco)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 8;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 39;
				Comunicacao.Buffer_cmd[6] = 78;
				Comunicacao.Buffer_cmd[7] = (byte)(RT_geral.RT_810_BD.End_estacao.Valor / 256);
				Comunicacao.Buffer_cmd[8] = (byte)(RT_geral.RT_810_BD.End_estacao.Valor % 256);
				Comunicacao.Buffer_cmd[9] = (byte)(RT_geral.RT_810_BD.End_mestre.Valor / 256);
				Comunicacao.Buffer_cmd[10] = (byte)(RT_geral.RT_810_BD.End_mestre.Valor % 256);
				Comunicacao.Buffer_cmd[11] = (byte)(RT_geral.RT_810_BD.Modelo.Valor / 256);
				Comunicacao.Buffer_cmd[12] = (byte)(RT_geral.RT_810_BD.Modelo.Valor % 256);
				Comunicacao.Buffer_cmd[13] = (byte)(RT_geral.RT_810_BD.Hab_repetidora.Valor / 256);
				Comunicacao.Buffer_cmd[14] = (byte)(RT_geral.RT_810_BD.Hab_repetidora.Valor % 256);
				Comunicacao.Buffer_cmd[15] = (byte)(RT_geral.RT_810_BD.Tempo_ptt.Valor / 256);
				Comunicacao.Buffer_cmd[16] = (byte)(RT_geral.RT_810_BD.Tempo_ptt.Valor % 256);
				Comunicacao.Buffer_cmd[17] = (byte)(RT_geral.RT_810_BD.Modo_de_operacao.Valor / 256);
				Comunicacao.Buffer_cmd[18] = (byte)(RT_geral.RT_810_BD.Modo_de_operacao.Valor % 256);
				Comunicacao.Buffer_cmd[19] = (byte)(RT_geral.RT_810_BD.Intervalo_tx_pto_pto.Valor / 256);
				Comunicacao.Buffer_cmd[20] = (byte)(RT_geral.RT_810_BD.Intervalo_tx_pto_pto.Valor % 256);
				Comunicacao.Buffer_cmd[21] = (byte)(RT_geral.RT_810_BD.AD_Intervalo.Valor / 256);
				Comunicacao.Buffer_cmd[22] = (byte)(RT_geral.RT_810_BD.AD_Intervalo.Valor % 256);
				Comunicacao.Buffer_cmd[23] = (byte)(RT_geral.RT_810_BD.AD_Tamanho_filtro.Valor / 256);
				Comunicacao.Buffer_cmd[24] = (byte)(RT_geral.RT_810_BD.AD_Tamanho_filtro.Valor % 256);
				int num = 0;
				do
				{
					int num2 = num * 2;
					Comunicacao.Buffer_cmd[25 + num2] = (byte)(RT_geral.RT_810_BD.EA_Range[num].Valor / 256);
					Comunicacao.Buffer_cmd[26 + num2] = (byte)(RT_geral.RT_810_BD.EA_Range[num].Valor % 256);
					Comunicacao.Buffer_cmd[33 + num2] = (byte)(RT_geral.RT_810_BD.EA_Inicio[num].Valor / 256);
					Comunicacao.Buffer_cmd[34 + num2] = (byte)(RT_geral.RT_810_BD.EA_Inicio[num].Valor % 256);
					Comunicacao.Buffer_cmd[41 + num2] = (byte)(RT_geral.RT_810_BD.EA_Fim[num].Valor / 256);
					Comunicacao.Buffer_cmd[42 + num2] = (byte)(RT_geral.RT_810_BD.EA_Fim[num].Valor % 256);
					num++;
				}
				while (num <= 3);
				Comunicacao.Buffer_cmd[49] = (byte)(RT_geral.RT_810_BD.ctrl_acionamento[0].Valor / 256);
				Comunicacao.Buffer_cmd[50] = (byte)(RT_geral.RT_810_BD.ctrl_acionamento[0].Valor % 256);
				Comunicacao.Buffer_cmd[51] = (byte)(RT_geral.RT_810_BD.ctrl_ret_acionamento[0].Valor / 256);
				Comunicacao.Buffer_cmd[52] = (byte)(RT_geral.RT_810_BD.ctrl_ret_acionamento[0].Valor % 256);
				Comunicacao.Buffer_cmd[53] = (byte)(RT_geral.RT_810_BD.ctrl_ED_selecao[0].Valor / 256);
				Comunicacao.Buffer_cmd[54] = (byte)(RT_geral.RT_810_BD.ctrl_ED_selecao[0].Valor % 256);
				Comunicacao.Buffer_cmd[55] = (byte)(RT_geral.RT_810_BD.ctrl_reverso[0].Valor / 256);
				Comunicacao.Buffer_cmd[56] = (byte)(RT_geral.RT_810_BD.ctrl_reverso[0].Valor % 256);
				Comunicacao.Buffer_cmd[57] = (byte)(RT_geral.RT_810_BD.ctrl_modo[0].Valor / 256);
				Comunicacao.Buffer_cmd[58] = (byte)(RT_geral.RT_810_BD.ctrl_modo[0].Valor % 256);
				Comunicacao.Buffer_cmd[59] = (byte)(RT_geral.RT_810_BD.ctrl_tempo_max_partida[0].Valor / 256);
				Comunicacao.Buffer_cmd[60] = (byte)(RT_geral.RT_810_BD.ctrl_tempo_max_partida[0].Valor % 256);
				Comunicacao.Buffer_cmd[61] = (byte)(RT_geral.RT_810_BD.ctrl_tempo_max_parada[0].Valor / 256);
				Comunicacao.Buffer_cmd[62] = (byte)(RT_geral.RT_810_BD.ctrl_tempo_max_parada[0].Valor % 256);
				num = 0;
				do
				{
					int num2 = num * 2;
					Comunicacao.Buffer_cmd[63 + num2] = (byte)(RT_geral.RT_810_BD.config_ED[num].Valor / 256);
					Comunicacao.Buffer_cmd[64 + num2] = (byte)(RT_geral.RT_810_BD.config_ED[num].Valor % 256);
					num++;
				}
				while (num <= 7);
				Comunicacao.Buffer_cmd[79] = (byte)(RT_geral.RT_810_BD.Hab_eletrodos.Valor / 256);
				Comunicacao.Buffer_cmd[80] = (byte)(RT_geral.RT_810_BD.Hab_eletrodos.Valor % 256);
				Comunicacao.Buffer_cmd[81] = (byte)(RT_geral.RT_810_BD.BaudRateCOM1.Valor / 256);
				Comunicacao.Buffer_cmd[82] = (byte)(RT_geral.RT_810_BD.BaudRateCOM1.Valor % 256);
				Comunicacao.Buffer_cmd[83] = (byte)(RT_geral.RT_810_BD.BaudRateCOM2.Valor / 256);
				Comunicacao.Buffer_cmd[84] = (byte)(RT_geral.RT_810_BD.BaudRateCOM2.Valor % 256);
				int num3 = 85;
				int num4 = Comunicacao.Crc16_TX(ref num3);
				Comunicacao.Buffer_cmd[85] = (byte)(num4 % 256);
				Comunicacao.Buffer_cmd[86] = (byte)(num4 / 256);
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, 87);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return 87;
			}
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0022E4E8 File Offset: 0x0022C8E8
		public static int CMD_Esc_RT_810_H1000(int endereco)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 16;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 52;
				Comunicacao.Buffer_cmd[6] = 104;
				Comunicacao.Buffer_cmd[7] = (byte)(RT_geral.RT_810_BD.End_repetidora.Valor / 256);
				Comunicacao.Buffer_cmd[8] = (byte)(RT_geral.RT_810_BD.End_repetidora.Valor % 256);
				Comunicacao.Buffer_cmd[9] = (byte)(RT_geral.RT_810_BD.Num_repetidoras.Valor / 256);
				Comunicacao.Buffer_cmd[10] = (byte)(RT_geral.RT_810_BD.Num_repetidoras.Valor % 256);
				int num = 0;
				do
				{
					Comunicacao.Buffer_cmd[num * 2 + 11] = (byte)(RT_geral.RT_810_BD.Repetidoras[num].Valor / 256);
					Comunicacao.Buffer_cmd[num * 2 + 12] = (byte)(RT_geral.RT_810_BD.Repetidoras[num].Valor % 256);
					num++;
				}
				while (num <= 49);
				int num2 = 111;
				int num3 = Comunicacao.Crc16_TX(ref num2);
				Comunicacao.Buffer_cmd[111] = (byte)(num3 % 256);
				Comunicacao.Buffer_cmd[112] = (byte)(num3 / 256);
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, 113);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return 113;
			}
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0022E678 File Offset: 0x0022CA78
		public static int CMD_Esc_RT_810_H2000(int endereco)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 32;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 1;
				Comunicacao.Buffer_cmd[6] = 2;
				Comunicacao.Buffer_cmd[7] = (byte)(RT_geral.RT_810_BD.Setpoints_ctrl_variavel[0].Valor / 256);
				Comunicacao.Buffer_cmd[8] = (byte)(RT_geral.RT_810_BD.Setpoints_ctrl_variavel[0].Valor % 256);
				int num = 9;
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[9] = (byte)(num2 % 256);
				Comunicacao.Buffer_cmd[10] = (byte)(num2 / 256);
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, 11);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return 11;
			}
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0022E77C File Offset: 0x0022CB7C
		public static void Split16(int valor, ref byte @int, ref byte rest)
		{
			checked
			{
				@int = (byte)(valor / 256);
				rest = (byte)(valor % 256);
			}
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0022E794 File Offset: 0x0022CB94
		public static void INC(ref int i)
		{
			checked
			{
				i++;
			}
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0022E79C File Offset: 0x0022CB9C
		public static void CMD_Esc_RT_810_200_CFG_GERAIS(int endereco)
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
				int valor = RT_geral.RT_810_200_BD.End_estacao.Valor;
				int num = 0;
				byte b = (byte)num;
				int num2 = 0;
				byte b2 = (byte)num2;
				Linha_RT.Split16(valor, ref b, ref b2);
				num2 = (int)b2;
				num = (int)b;
				Comunicacao.Buffer_cmd[7] = (byte)num;
				Comunicacao.Buffer_cmd[8] = (byte)num2;
				int valor2 = RT_geral.RT_810_200_BD.End_mestre.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor2, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[9] = (byte)num;
				Comunicacao.Buffer_cmd[10] = (byte)num2;
				int valor3 = RT_geral.RT_810_200_BD.Hab_repetidora.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor3, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[11] = (byte)num;
				Comunicacao.Buffer_cmd[12] = (byte)num2;
				int valor4 = RT_geral.RT_810_200_BD.Intervalo_tx_pto_pto.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor4, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[13] = (byte)num;
				Comunicacao.Buffer_cmd[14] = (byte)num2;
				int valor5 = (int)Math.Round((double)RT_geral.RT_810_200_BD.Tempo_ptt.Valor / 10.0);
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor5, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[15] = (byte)num;
				Comunicacao.Buffer_cmd[16] = (byte)num2;
				int valor6 = RT_geral.RT_810_200_BD.Tipo_nivel.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor6, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[17] = (byte)num;
				Comunicacao.Buffer_cmd[18] = (byte)num2;
				int valor7 = RT_geral.RT_810_200_BD.Modo_de_operacao.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor7, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[19] = (byte)num;
				Comunicacao.Buffer_cmd[20] = (byte)num2;
				int valor8 = RT_geral.RT_810_200_BD.RangeSensor.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor8, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[21] = (byte)num;
				Comunicacao.Buffer_cmd[22] = (byte)num2;
				int valor9 = RT_geral.RT_810_200_BD.AlturaReservatorio.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor9, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[23] = (byte)num;
				Comunicacao.Buffer_cmd[24] = (byte)num2;
				decimal num3 = new decimal((double)RT_geral.RT_810_200_BD.ErroOffSet.Valor / (double)RT_geral.RT_810_200_BD.RangeSensor.Valor);
				num3 = decimal.Multiply(num3, 4000m);
				if (decimal.Compare(num3, 0m) < 0)
				{
					num3 = decimal.Multiply(num3, -1m);
					num3 = decimal.Add(num3, 4000m);
				}
				int valor10 = Convert.ToInt32(num3);
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor10, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[25] = (byte)num;
				Comunicacao.Buffer_cmd[26] = (byte)num2;
				int valor11 = (int)Math.Round((double)RT_geral.RT_810_200_BD.AD_Intervalo.Valor / 10.0);
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor11, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[27] = (byte)num;
				Comunicacao.Buffer_cmd[28] = (byte)num2;
				int valor12 = RT_geral.RT_810_200_BD.AD_Tamanho_filtro.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor12, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[29] = (byte)num;
				Comunicacao.Buffer_cmd[30] = (byte)num2;
				int num4 = 31;
				num3 = new decimal(Comunicacao.Crc16_TX(ref num4));
				Comunicacao.Buffer_cmd[31] = Convert.ToByte(decimal.Remainder(num3, 256m));
				Comunicacao.Buffer_cmd[32] = (byte)(Convert.ToInt64(num3) / 256L);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, 33);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0022EB80 File Offset: 0x0022CF80
		public static void CMD_Esc_RT_820_200_CFG_REPETIDORA(int endereco)
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
				int valor = RT_geral.RT_820_200_BD.repetidora.End_repetidora.Valor;
				int num = 0;
				byte b = (byte)num;
				int num2 = 0;
				byte b2 = (byte)num2;
				Linha_RT.Split16(valor, ref b, ref b2);
				num2 = (int)b2;
				num = (int)b;
				Comunicacao.Buffer_cmd[7] = (byte)num;
				Comunicacao.Buffer_cmd[8] = (byte)num2;
				int valor2 = RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor2, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[9] = (byte)num;
				Comunicacao.Buffer_cmd[10] = (byte)num2;
				int num3 = 11;
				int num4 = 0;
				do
				{
					int valor3 = RT_geral.RT_820_200_BD.repetidora.Repetidoras[num4].Valor;
					b2 = (byte)num;
					b = (byte)num2;
					Linha_RT.Split16(valor3, ref b2, ref b);
					num2 = (int)b;
					num = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num;
					Linha_RT.INC(ref num3);
					Comunicacao.Buffer_cmd[num3] = (byte)num2;
					Linha_RT.INC(ref num3);
					num4++;
				}
				while (num4 <= 49);
				int num5 = Comunicacao.Crc16_TX(ref num3);
				Comunicacao.Buffer_cmd[num3] = (byte)(num5 % 256);
				Linha_RT.INC(ref num3);
				Comunicacao.Buffer_cmd[num3] = (byte)(num5 / 256);
				Linha_RT.INC(ref num3);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num3);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0022ED14 File Offset: 0x0022D114
		public static void CMD_Esc_RT_820_200_CFG_SETPOINT_HORARIO(int endereco)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 11;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 24;
				Comunicacao.Buffer_cmd[6] = 48;
				Comunicacao.Buffer_cmd[7] = (byte)RT_geral.RT_820_200_BD.setpoint_horario[0].Hora.Valor;
				Comunicacao.Buffer_cmd[8] = (byte)RT_geral.RT_820_200_BD.setpoint_horario[0].Minuto.Valor;
				int valor = RT_geral.RT_820_200_BD.setpoint_horario[0].Alto.Valor;
				int num = 0;
				byte b = (byte)num;
				int num2 = 0;
				byte b2 = (byte)num2;
				Linha_RT.Split16(valor, ref b, ref b2);
				num2 = (int)b2;
				num = (int)b;
				Comunicacao.Buffer_cmd[9] = (byte)num;
				Comunicacao.Buffer_cmd[10] = (byte)num2;
				int valor2 = RT_geral.RT_820_200_BD.setpoint_horario[0].Baixo.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor2, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[11] = (byte)num;
				Comunicacao.Buffer_cmd[12] = (byte)num2;
				Comunicacao.Buffer_cmd[13] = (byte)RT_geral.RT_820_200_BD.setpoint_horario[1].Hora.Valor;
				Comunicacao.Buffer_cmd[14] = (byte)RT_geral.RT_820_200_BD.setpoint_horario[1].Minuto.Valor;
				int valor3 = RT_geral.RT_820_200_BD.setpoint_horario[1].Alto.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor3, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[15] = (byte)num;
				Comunicacao.Buffer_cmd[16] = (byte)num2;
				int valor4 = RT_geral.RT_820_200_BD.setpoint_horario[1].Baixo.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor4, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[17] = (byte)num;
				Comunicacao.Buffer_cmd[18] = (byte)num2;
				Comunicacao.Buffer_cmd[19] = (byte)RT_geral.RT_820_200_BD.setpoint_horario[2].Hora.Valor;
				Comunicacao.Buffer_cmd[20] = (byte)RT_geral.RT_820_200_BD.setpoint_horario[2].Minuto.Valor;
				int valor5 = RT_geral.RT_820_200_BD.setpoint_horario[2].Alto.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor5, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[21] = (byte)num;
				Comunicacao.Buffer_cmd[22] = (byte)num2;
				int valor6 = RT_geral.RT_820_200_BD.setpoint_horario[2].Baixo.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor6, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[23] = (byte)num;
				Comunicacao.Buffer_cmd[24] = (byte)num2;
				Comunicacao.Buffer_cmd[25] = (byte)RT_geral.RT_820_200_BD.setpoint_horario[3].Hora.Valor;
				Comunicacao.Buffer_cmd[26] = (byte)RT_geral.RT_820_200_BD.setpoint_horario[3].Minuto.Valor;
				int valor7 = RT_geral.RT_820_200_BD.setpoint_horario[3].Alto.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor7, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[27] = (byte)num;
				Comunicacao.Buffer_cmd[28] = (byte)num2;
				int valor8 = RT_geral.RT_820_200_BD.setpoint_horario[3].Baixo.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor8, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[29] = (byte)num;
				Comunicacao.Buffer_cmd[30] = (byte)num2;
				Comunicacao.Buffer_cmd[31] = (byte)RT_geral.RT_820_200_BD.setpoint_horario[4].Hora.Valor;
				Comunicacao.Buffer_cmd[32] = (byte)RT_geral.RT_820_200_BD.setpoint_horario[4].Minuto.Valor;
				int valor9 = RT_geral.RT_820_200_BD.setpoint_horario[4].Alto.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor9, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[33] = (byte)num;
				Comunicacao.Buffer_cmd[34] = (byte)num2;
				int valor10 = RT_geral.RT_820_200_BD.setpoint_horario[4].Baixo.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor10, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[35] = (byte)num;
				Comunicacao.Buffer_cmd[36] = (byte)num2;
				Comunicacao.Buffer_cmd[37] = (byte)RT_geral.RT_820_200_BD.setpoint_horario[5].Hora.Valor;
				Comunicacao.Buffer_cmd[38] = (byte)RT_geral.RT_820_200_BD.setpoint_horario[5].Minuto.Valor;
				int valor11 = RT_geral.RT_820_200_BD.setpoint_horario[5].Alto.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor11, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[39] = (byte)num;
				Comunicacao.Buffer_cmd[40] = (byte)num2;
				int valor12 = RT_geral.RT_820_200_BD.setpoint_horario[5].Baixo.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor12, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[41] = (byte)num;
				Comunicacao.Buffer_cmd[42] = (byte)num2;
				Comunicacao.Buffer_cmd[43] = (byte)RT_geral.RT_820_200_BD.setpoint_horario[6].Hora.Valor;
				Comunicacao.Buffer_cmd[44] = (byte)RT_geral.RT_820_200_BD.setpoint_horario[6].Minuto.Valor;
				int valor13 = RT_geral.RT_820_200_BD.setpoint_horario[6].Alto.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor13, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[45] = (byte)num;
				Comunicacao.Buffer_cmd[46] = (byte)num2;
				int valor14 = RT_geral.RT_820_200_BD.setpoint_horario[6].Baixo.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor14, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[47] = (byte)num;
				Comunicacao.Buffer_cmd[48] = (byte)num2;
				Comunicacao.Buffer_cmd[49] = (byte)RT_geral.RT_820_200_BD.setpoint_horario[7].Hora.Valor;
				Comunicacao.Buffer_cmd[50] = (byte)RT_geral.RT_820_200_BD.setpoint_horario[7].Minuto.Valor;
				int valor15 = RT_geral.RT_820_200_BD.setpoint_horario[7].Alto.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor15, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[51] = (byte)num;
				Comunicacao.Buffer_cmd[52] = (byte)num2;
				int valor16 = RT_geral.RT_820_200_BD.setpoint_horario[7].Baixo.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor16, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[53] = (byte)num;
				Comunicacao.Buffer_cmd[54] = (byte)num2;
				int num3 = 55;
				int num4 = Comunicacao.Crc16_TX(ref num3);
				Comunicacao.Buffer_cmd[num3] = (byte)(num4 % 256);
				Linha_RT.INC(ref num3);
				Comunicacao.Buffer_cmd[num3] = (byte)(num4 / 256);
				Linha_RT.INC(ref num3);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num3);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0022F44C File Offset: 0x0022D84C
		public static void CMD_Esc_RT_821_200_CFG_REPETIDORA(int endereco)
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
				int valor = RT_geral.RT_821_200_BD.repetidora.End_repetidora.Valor;
				int num = 0;
				byte b = (byte)num;
				int num2 = 0;
				byte b2 = (byte)num2;
				Linha_RT.Split16(valor, ref b, ref b2);
				num2 = (int)b2;
				num = (int)b;
				Comunicacao.Buffer_cmd[7] = (byte)num;
				Comunicacao.Buffer_cmd[8] = (byte)num2;
				int valor2 = RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor2, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[9] = (byte)num;
				Comunicacao.Buffer_cmd[10] = (byte)num2;
				int num3 = 11;
				int num4 = 0;
				do
				{
					int valor3 = RT_geral.RT_821_200_BD.repetidora.Repetidoras[num4].Valor;
					b2 = (byte)num;
					b = (byte)num2;
					Linha_RT.Split16(valor3, ref b2, ref b);
					num2 = (int)b;
					num = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num;
					Linha_RT.INC(ref num3);
					Comunicacao.Buffer_cmd[num3] = (byte)num2;
					Linha_RT.INC(ref num3);
					num4++;
				}
				while (num4 <= 49);
				int num5 = Comunicacao.Crc16_TX(ref num3);
				Comunicacao.Buffer_cmd[num3] = (byte)(num5 % 256);
				Linha_RT.INC(ref num3);
				Comunicacao.Buffer_cmd[num3] = (byte)(num5 / 256);
				Linha_RT.INC(ref num3);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num3);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x0022F5E0 File Offset: 0x0022D9E0
		public static void CMD_Esc_RT_820_200_CFG_GERAIS(int endereco)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 1;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 58;
				Comunicacao.Buffer_cmd[6] = 116;
				int valor = RT_geral.RT_820_200_BD.cfg_geral.End_estacao.Valor;
				int num = 0;
				byte b = (byte)num;
				int num2 = 0;
				byte b2 = (byte)num2;
				Linha_RT.Split16(valor, ref b, ref b2);
				num2 = (int)b2;
				num = (int)b;
				Comunicacao.Buffer_cmd[7] = (byte)num;
				Comunicacao.Buffer_cmd[8] = (byte)num2;
				int valor2 = RT_geral.RT_820_200_BD.cfg_geral.End_mestre.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor2, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[9] = (byte)num;
				Comunicacao.Buffer_cmd[10] = (byte)num2;
				int valor3 = RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor3, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[11] = (byte)num;
				Comunicacao.Buffer_cmd[12] = (byte)num2;
				int valor4 = (int)Math.Round((double)RT_geral.RT_820_200_BD.cfg_geral.Tempo_ptt.Valor / 10.0);
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor4, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[13] = (byte)num;
				Comunicacao.Buffer_cmd[14] = (byte)num2;
				int valor5 = RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor5, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[15] = (byte)num;
				Comunicacao.Buffer_cmd[16] = (byte)num2;
				int valor6 = (int)Math.Round((double)RT_geral.RT_820_200_BD.cfg_geral.AD_Intervalo.Valor / 10.0);
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor6, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[17] = (byte)num;
				Comunicacao.Buffer_cmd[18] = (byte)num2;
				int valor7 = RT_geral.RT_820_200_BD.cfg_geral.AD_Tamanho_filtro.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor7, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[19] = (byte)num;
				Comunicacao.Buffer_cmd[20] = (byte)num2;
				int valor8 = RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor8, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[21] = (byte)num;
				Comunicacao.Buffer_cmd[22] = (byte)num2;
				int valor9 = RT_geral.RT_820_200_BD.cfg_geral.quantidade_motores.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor9, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[23] = (byte)num;
				Comunicacao.Buffer_cmd[24] = (byte)num2;
				int valor10 = RT_geral.RT_820_200_BD.cfg_geral.quantidade_valvulas.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor10, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[25] = (byte)num;
				Comunicacao.Buffer_cmd[26] = (byte)num2;
				int valor11 = RT_geral.RT_820_200_BD.cfg_geral.modo_partida[0].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor11, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[27] = (byte)num;
				Comunicacao.Buffer_cmd[28] = (byte)num2;
				int valor12 = RT_geral.RT_820_200_BD.cfg_geral.modo_partida[1].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor12, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[29] = (byte)num;
				Comunicacao.Buffer_cmd[30] = (byte)num2;
				int valor13 = RT_geral.RT_820_200_BD.cfg_geral.modo_partida[2].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor13, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[31] = (byte)num;
				Comunicacao.Buffer_cmd[32] = (byte)num2;
				int valor14 = RT_geral.RT_820_200_BD.cfg_geral.modo_partida[3].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor14, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[33] = (byte)num;
				Comunicacao.Buffer_cmd[34] = (byte)num2;
				int valor15 = RT_geral.RT_820_200_BD.cfg_geral.entradas[0].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor15, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[35] = (byte)num;
				Comunicacao.Buffer_cmd[36] = (byte)num2;
				int valor16 = RT_geral.RT_820_200_BD.cfg_geral.entradas[1].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor16, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[37] = (byte)num;
				Comunicacao.Buffer_cmd[38] = (byte)num2;
				int valor17 = RT_geral.RT_820_200_BD.cfg_geral.entradas[2].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor17, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[39] = (byte)num;
				Comunicacao.Buffer_cmd[40] = (byte)num2;
				int valor18 = RT_geral.RT_820_200_BD.cfg_geral.entradas[3].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor18, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[41] = (byte)num;
				Comunicacao.Buffer_cmd[42] = (byte)num2;
				int valor19 = RT_geral.RT_820_200_BD.cfg_geral.entradas[4].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor19, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[43] = (byte)num;
				Comunicacao.Buffer_cmd[44] = (byte)num2;
				int valor20 = RT_geral.RT_820_200_BD.cfg_geral.entradas[5].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor20, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[45] = (byte)num;
				Comunicacao.Buffer_cmd[46] = (byte)num2;
				int valor21 = RT_geral.RT_820_200_BD.cfg_geral.entradas[6].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor21, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[47] = (byte)num;
				Comunicacao.Buffer_cmd[48] = (byte)num2;
				int valor22 = RT_geral.RT_820_200_BD.cfg_geral.entradas[7].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor22, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[49] = (byte)num;
				Comunicacao.Buffer_cmd[50] = (byte)num2;
				int valor23 = RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Alto.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor23, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[51] = (byte)num;
				Comunicacao.Buffer_cmd[52] = (byte)num2;
				int valor24 = RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Baixo.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor24, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[53] = (byte)num;
				Comunicacao.Buffer_cmd[54] = (byte)num2;
				int valor25 = RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Alto.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor25, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[55] = (byte)num;
				Comunicacao.Buffer_cmd[56] = (byte)num2;
				int valor26 = RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Baixo.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor26, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[57] = (byte)num;
				Comunicacao.Buffer_cmd[58] = (byte)num2;
				int valor27 = RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Alto.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor27, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[59] = (byte)num;
				Comunicacao.Buffer_cmd[60] = (byte)num2;
				int valor28 = RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Baixo.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor28, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[61] = (byte)num;
				Comunicacao.Buffer_cmd[62] = (byte)num2;
				int valor29 = RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Alto.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor29, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[63] = (byte)num;
				Comunicacao.Buffer_cmd[64] = (byte)num2;
				int valor30 = RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Baixo.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor30, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[65] = (byte)num;
				Comunicacao.Buffer_cmd[66] = (byte)num2;
				int valor31 = RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Desliga.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor31, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[67] = (byte)num;
				Comunicacao.Buffer_cmd[68] = (byte)num2;
				int valor32 = RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Liga.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor32, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[69] = (byte)num;
				Comunicacao.Buffer_cmd[70] = (byte)num2;
				int valor33 = RT_geral.RT_820_200_BD.cfg_geral.partida.Motor1.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor33, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[71] = (byte)num;
				Comunicacao.Buffer_cmd[72] = (byte)num2;
				int valor34 = RT_geral.RT_820_200_BD.cfg_geral.partida.Motor2.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor34, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[73] = (byte)num;
				Comunicacao.Buffer_cmd[74] = (byte)num2;
				int valor35 = RT_geral.RT_820_200_BD.cfg_geral.partida.Motor3.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor35, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[75] = (byte)num;
				Comunicacao.Buffer_cmd[76] = (byte)num2;
				int valor36 = RT_geral.RT_820_200_BD.cfg_geral.partida.Motor4.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor36, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[77] = (byte)num;
				Comunicacao.Buffer_cmd[78] = (byte)num2;
				int valor37 = RT_geral.RT_820_200_BD.cfg_geral.parada.Motor1.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor37, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[79] = (byte)num;
				Comunicacao.Buffer_cmd[80] = (byte)num2;
				int valor38 = RT_geral.RT_820_200_BD.cfg_geral.parada.Motor2.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor38, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[81] = (byte)num;
				Comunicacao.Buffer_cmd[82] = (byte)num2;
				int valor39 = RT_geral.RT_820_200_BD.cfg_geral.parada.Motor3.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor39, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[83] = (byte)num;
				Comunicacao.Buffer_cmd[84] = (byte)num2;
				int valor40 = RT_geral.RT_820_200_BD.cfg_geral.parada.Motor4.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor40, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[85] = (byte)num;
				Comunicacao.Buffer_cmd[86] = (byte)num2;
				int valor41 = RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula1.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor41, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[87] = (byte)num;
				Comunicacao.Buffer_cmd[88] = (byte)num2;
				int valor42 = RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula2.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor42, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[89] = (byte)num;
				Comunicacao.Buffer_cmd[90] = (byte)num2;
				int valor43 = RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula3.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor43, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[91] = (byte)num;
				Comunicacao.Buffer_cmd[92] = (byte)num2;
				int valor44 = RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula4.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor44, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[93] = (byte)num;
				Comunicacao.Buffer_cmd[94] = (byte)num2;
				int valor45 = RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula1.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor45, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[95] = (byte)num;
				Comunicacao.Buffer_cmd[96] = (byte)num2;
				int valor46 = RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula2.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor46, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[97] = (byte)num;
				Comunicacao.Buffer_cmd[98] = (byte)num2;
				int valor47 = RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula3.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor47, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[99] = (byte)num;
				Comunicacao.Buffer_cmd[100] = (byte)num2;
				int valor48 = RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula4.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor48, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[101] = (byte)num;
				Comunicacao.Buffer_cmd[102] = (byte)num2;
				int valor49 = RT_geral.RT_820_200_BD.cfg_geral.tempo_acionamentos.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor49, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[103] = (byte)num;
				Comunicacao.Buffer_cmd[104] = (byte)num2;
				int valor50 = RT_geral.RT_820_200_BD.cfg_geral.bombas_simultaneas.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor50, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[105] = (byte)num;
				Comunicacao.Buffer_cmd[106] = (byte)num2;
				int valor51 = RT_geral.RT_820_200_BD.cfg_geral.nivel_fonte.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor51, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[107] = (byte)num;
				Comunicacao.Buffer_cmd[108] = (byte)num2;
				RT_geral.RT_820_200_BD.cfg_geral.numero_vazoes.Valor = 1;
				int valor52 = RT_geral.RT_820_200_BD.cfg_geral.numero_vazoes.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor52, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[109] = (byte)num;
				Comunicacao.Buffer_cmd[110] = (byte)num2;
				Comunicacao.Buffer_cmd[111] = (byte)RT_geral.RT_820_200_BD.cfg_geral.perifericos[0].End_Quant.Valor;
				Comunicacao.Buffer_cmd[112] = (byte)RT_geral.RT_820_200_BD.cfg_geral.perifericos[0].Equipamento.Valor;
				Comunicacao.Buffer_cmd[113] = (byte)RT_geral.RT_820_200_BD.cfg_geral.perifericos[1].End_Quant.Valor;
				Comunicacao.Buffer_cmd[114] = (byte)RT_geral.RT_820_200_BD.cfg_geral.perifericos[1].Equipamento.Valor;
				Comunicacao.Buffer_cmd[115] = (byte)RT_geral.RT_820_200_BD.cfg_geral.perifericos[2].End_Quant.Valor;
				Comunicacao.Buffer_cmd[116] = (byte)RT_geral.RT_820_200_BD.cfg_geral.perifericos[2].Equipamento.Valor;
				Comunicacao.Buffer_cmd[117] = (byte)RT_geral.RT_820_200_BD.cfg_geral.perifericos[3].End_Quant.Valor;
				Comunicacao.Buffer_cmd[118] = (byte)RT_geral.RT_820_200_BD.cfg_geral.perifericos[3].Equipamento.Valor;
				int valor53 = RT_geral.RT_820_200_BD.cfg_geral.origem_controle.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor53, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[119] = (byte)num;
				Comunicacao.Buffer_cmd[120] = (byte)num2;
				int valor54 = RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor54, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[121] = (byte)num;
				Comunicacao.Buffer_cmd[122] = (byte)num2;
				int num3 = 123;
				int num4 = Comunicacao.Crc16_TX(ref num3);
				Comunicacao.Buffer_cmd[123] = (byte)(num4 % 256);
				Comunicacao.Buffer_cmd[124] = (byte)(num4 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, 125);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x002305AC File Offset: 0x0022E9AC
		public static void CMD_Esc_RT_821_200_CFG_GERAIS(int endereco)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 1;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 30;
				Comunicacao.Buffer_cmd[6] = 60;
				int valor = RT_geral.RT_821_200_BD.cfg_geral.End_estacao.Valor;
				int num = 0;
				byte b = (byte)num;
				int num2 = 0;
				byte b2 = (byte)num2;
				Linha_RT.Split16(valor, ref b, ref b2);
				num2 = (int)b2;
				num = (int)b;
				Comunicacao.Buffer_cmd[7] = (byte)num;
				Comunicacao.Buffer_cmd[8] = (byte)num2;
				int valor2 = RT_geral.RT_821_200_BD.cfg_geral.End_mestre.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor2, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[9] = (byte)num;
				Comunicacao.Buffer_cmd[10] = (byte)num2;
				int valor3 = RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor3, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[11] = (byte)num;
				Comunicacao.Buffer_cmd[12] = (byte)num2;
				int valor4 = (int)Math.Round((double)RT_geral.RT_821_200_BD.cfg_geral.Tempo_ptt.Valor / 10.0);
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor4, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[13] = (byte)num;
				Comunicacao.Buffer_cmd[14] = (byte)num2;
				int valor5 = RT_geral.RT_821_200_BD.cfg_geral.quantidade_motores.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor5, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[15] = (byte)num;
				Comunicacao.Buffer_cmd[16] = (byte)num2;
				int valor6 = RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor6, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[17] = (byte)num;
				Comunicacao.Buffer_cmd[18] = (byte)num2;
				int valor7 = RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor7, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[19] = (byte)num;
				Comunicacao.Buffer_cmd[20] = (byte)num2;
				int valor8 = RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor8, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[21] = (byte)num;
				Comunicacao.Buffer_cmd[22] = (byte)num2;
				int valor9 = RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Alto.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor9, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[23] = (byte)num;
				Comunicacao.Buffer_cmd[24] = (byte)num2;
				int valor10 = RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Baixo.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor10, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[25] = (byte)num;
				Comunicacao.Buffer_cmd[26] = (byte)num2;
				int valor11 = RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Alto.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor11, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[27] = (byte)num;
				Comunicacao.Buffer_cmd[28] = (byte)num2;
				int valor12 = RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Baixo.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor12, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[29] = (byte)num;
				Comunicacao.Buffer_cmd[30] = (byte)num2;
				int valor13 = RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Alto.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor13, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[31] = (byte)num;
				Comunicacao.Buffer_cmd[32] = (byte)num2;
				int valor14 = RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Baixo.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor14, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[33] = (byte)num;
				Comunicacao.Buffer_cmd[34] = (byte)num2;
				int valor15 = RT_geral.RT_821_200_BD.cfg_geral.partida.Motor1.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor15, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[35] = (byte)num;
				Comunicacao.Buffer_cmd[36] = (byte)num2;
				int valor16 = RT_geral.RT_821_200_BD.cfg_geral.partida.Motor2.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor16, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[37] = (byte)num;
				Comunicacao.Buffer_cmd[38] = (byte)num2;
				int valor17 = RT_geral.RT_821_200_BD.cfg_geral.partida.Motor3.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor17, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[39] = (byte)num;
				Comunicacao.Buffer_cmd[40] = (byte)num2;
				int valor18 = RT_geral.RT_821_200_BD.cfg_geral.parada.Motor1.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor18, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[41] = (byte)num;
				Comunicacao.Buffer_cmd[42] = (byte)num2;
				int valor19 = RT_geral.RT_821_200_BD.cfg_geral.parada.Motor1.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor19, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[43] = (byte)num;
				Comunicacao.Buffer_cmd[44] = (byte)num2;
				int valor20 = RT_geral.RT_821_200_BD.cfg_geral.parada.Motor1.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor20, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[45] = (byte)num;
				Comunicacao.Buffer_cmd[46] = (byte)num2;
				int valor21 = RT_geral.RT_821_200_BD.cfg_geral.tempo_acionamentos.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor21, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[47] = (byte)num;
				Comunicacao.Buffer_cmd[48] = (byte)num2;
				int valor22 = RT_geral.RT_821_200_BD.cfg_geral.motores_simultaneos.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor22, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[49] = (byte)num;
				Comunicacao.Buffer_cmd[50] = (byte)num2;
				int valor23 = RT_geral.RT_821_200_BD.cfg_geral.entradas[0].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor23, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[51] = (byte)num;
				Comunicacao.Buffer_cmd[52] = (byte)num2;
				int valor24 = RT_geral.RT_821_200_BD.cfg_geral.entradas[1].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor24, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[53] = (byte)num;
				Comunicacao.Buffer_cmd[54] = (byte)num2;
				int valor25 = RT_geral.RT_821_200_BD.cfg_geral.entradas[2].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor25, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[55] = (byte)num;
				Comunicacao.Buffer_cmd[56] = (byte)num2;
				int valor26 = RT_geral.RT_821_200_BD.cfg_geral.entradas[3].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor26, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[57] = (byte)num;
				Comunicacao.Buffer_cmd[58] = (byte)num2;
				int valor27 = RT_geral.RT_821_200_BD.cfg_geral.entradas[4].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor27, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[59] = (byte)num;
				Comunicacao.Buffer_cmd[60] = (byte)num2;
				int valor28 = RT_geral.RT_821_200_BD.cfg_geral.entradas[5].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor28, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[61] = (byte)num;
				Comunicacao.Buffer_cmd[62] = (byte)num2;
				int valor29 = RT_geral.RT_821_200_BD.cfg_geral.entradas[6].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor29, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[63] = (byte)num;
				Comunicacao.Buffer_cmd[64] = (byte)num2;
				int valor30 = RT_geral.RT_821_200_BD.cfg_geral.entradas[7].Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor30, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[65] = (byte)num;
				Comunicacao.Buffer_cmd[66] = (byte)num2;
				int num3 = 67;
				int num4 = Comunicacao.Crc16_TX(ref num3);
				Comunicacao.Buffer_cmd[67] = (byte)(num4 % 256);
				Comunicacao.Buffer_cmd[68] = (byte)(num4 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, 69);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00230E0C File Offset: 0x0022F20C
		public static void CMD_Esc_RT_810_200_CFG_REPETIDORA(int endereco)
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
				int valor = RT_geral.RT_810_200_BD.End_repetidora.Valor;
				int num = 0;
				byte b = (byte)num;
				int num2 = 0;
				byte b2 = (byte)num2;
				Linha_RT.Split16(valor, ref b, ref b2);
				num2 = (int)b2;
				num = (int)b;
				Comunicacao.Buffer_cmd[7] = (byte)num;
				Comunicacao.Buffer_cmd[8] = (byte)num2;
				int valor2 = RT_geral.RT_810_200_BD.Num_repetidoras.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor2, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[9] = (byte)num;
				Comunicacao.Buffer_cmd[10] = (byte)num2;
				int num3 = 11;
				int num4 = 0;
				do
				{
					int valor3 = RT_geral.RT_810_200_BD.Repetidoras[num4].Valor;
					b2 = (byte)num;
					b = (byte)num2;
					Linha_RT.Split16(valor3, ref b2, ref b);
					num2 = (int)b;
					num = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num;
					Linha_RT.INC(ref num3);
					Comunicacao.Buffer_cmd[num3] = (byte)num2;
					Linha_RT.INC(ref num3);
					num4++;
				}
				while (num4 <= 49);
				int num5 = Comunicacao.Crc16_TX(ref num3);
				Comunicacao.Buffer_cmd[num3] = (byte)(num5 % 256);
				Linha_RT.INC(ref num3);
				Comunicacao.Buffer_cmd[num3] = (byte)(num5 / 256);
				Linha_RT.INC(ref num3);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num3);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00230F90 File Offset: 0x0022F390
		public static byte IP_String_Parts(string ip, int index)
		{
			string[] array = ip.Split(new char[]
			{
				'.'
			});
			if (index > 4)
			{
				index = 0;
			}
			byte result;
			if (array.Length == 4)
			{
				string text = array[index];
				result = checked((byte)Convert.ToInt16(text));
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00230FD0 File Offset: 0x0022F3D0
		public static int CMD_Esc_IEC_855_TABELA_IP(int endereco_estacao, int memoria, int part)
		{
			int num = 100;
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco_estacao;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(memoria / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(memoria % 256);
				Comunicacao.Buffer_cmd[4] = (byte)(num / 256);
				Comunicacao.Buffer_cmd[5] = (byte)(num % 256);
				Comunicacao.Buffer_cmd[6] = (byte)(num * 2);
				int num2 = 7;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				Comunicacao.Buffer_cmd[num2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 1);
				Comunicacao.Buffer_cmd[num2 + 1] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 0);
				Comunicacao.Buffer_cmd[num2 + 2] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 3);
				Comunicacao.Buffer_cmd[num2 + 3] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.tab_ips[part], 2);
				part++;
				num2 += 4;
				int num3 = Comunicacao.Crc16_TX(ref num2);
				Comunicacao.Buffer_cmd[num2] = (byte)(num3 % 256);
				Comunicacao.Buffer_cmd[num2 + 1] = (byte)(num3 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num2 + 2);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				int result = 0;
				return result;
			}
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00232848 File Offset: 0x00230C48
		public static int CMD_Esc_IEC_855_CFG_ETHERNET(int endereco_estacao)
		{
			int num = 6;
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco_estacao;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 4;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = (byte)(num / 256);
				Comunicacao.Buffer_cmd[5] = (byte)(num % 256);
				Comunicacao.Buffer_cmd[6] = (byte)(num * 2);
				Comunicacao.Buffer_cmd[7] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.STATIC_IP, 1);
				Comunicacao.Buffer_cmd[8] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.STATIC_IP, 0);
				Comunicacao.Buffer_cmd[9] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.STATIC_IP, 3);
				Comunicacao.Buffer_cmd[10] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.STATIC_IP, 2);
				Comunicacao.Buffer_cmd[11] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.STATIC_GW, 0);
				Comunicacao.Buffer_cmd[12] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.STATIC_GW, 1);
				Comunicacao.Buffer_cmd[13] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.STATIC_GW, 2);
				Comunicacao.Buffer_cmd[14] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.STATIC_GW, 3);
				Comunicacao.Buffer_cmd[15] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.STATIC_SM, 0);
				Comunicacao.Buffer_cmd[16] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.STATIC_SM, 1);
				Comunicacao.Buffer_cmd[17] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.STATIC_SM, 2);
				Comunicacao.Buffer_cmd[18] = Linha_RT.IP_String_Parts(RT_geral.IEC_855_BD.STATIC_SM, 3);
				int num2 = 19;
				int num3 = Comunicacao.Crc16_TX(ref num2);
				Comunicacao.Buffer_cmd[19] = (byte)(num3 % 256);
				Comunicacao.Buffer_cmd[20] = (byte)(num3 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, 21);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				int result = 0;
				return result;
			}
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00232A24 File Offset: 0x00230E24
		public static int CMD_Esc_IEC_855_CFG_GERAL(int endereco_estacao)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco_estacao;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 2;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 2;
				Comunicacao.Buffer_cmd[6] = 4;
				Comunicacao.Buffer_cmd[7] = (byte)(RT_geral.IEC_855_BD.BaudRateCOM1.Valor / 256);
				Comunicacao.Buffer_cmd[8] = (byte)(RT_geral.IEC_855_BD.BaudRateCOM1.Valor % 256);
				Comunicacao.Buffer_cmd[9] = (byte)(RT_geral.IEC_855_BD.AtribuicaoIP.Valor / 256);
				Comunicacao.Buffer_cmd[10] = (byte)(RT_geral.IEC_855_BD.AtribuicaoIP.Valor % 256);
				int num = 11;
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[11] = (byte)(num2 % 256);
				Comunicacao.Buffer_cmd[12] = (byte)(num2 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, 13);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				int result = 0;
				return result;
			}
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00232B44 File Offset: 0x00230F44
		public static int CMD_Esc_GC_825x_DadosGerais(int endereco_estacao)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco_estacao;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 8;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 22;
				Comunicacao.Buffer_cmd[6] = 44;
				Comunicacao.Buffer_cmd[7] = (byte)(RT_geral.GC_82x_BD.End_estacao.Valor / 256);
				Comunicacao.Buffer_cmd[8] = (byte)(RT_geral.GC_82x_BD.End_estacao.Valor % 256);
				Comunicacao.Buffer_cmd[9] = (byte)(RT_geral.GC_82x_BD.End_mestre.Valor / 256);
				Comunicacao.Buffer_cmd[10] = (byte)(RT_geral.GC_82x_BD.End_mestre.Valor % 256);
				Comunicacao.Buffer_cmd[11] = (byte)(RT_geral.GC_82x_BD.modo_SD1.Valor / 256);
				Comunicacao.Buffer_cmd[12] = (byte)(RT_geral.GC_82x_BD.modo_SD1.Valor % 256);
				Comunicacao.Buffer_cmd[13] = (byte)(RT_geral.GC_82x_BD.modo_SD2.Valor / 256);
				Comunicacao.Buffer_cmd[14] = (byte)(RT_geral.GC_82x_BD.modo_SD2.Valor % 256);
				Comunicacao.Buffer_cmd[15] = (byte)(RT_geral.GC_82x_BD.modo_SD3.Valor / 256);
				Comunicacao.Buffer_cmd[16] = (byte)(RT_geral.GC_82x_BD.modo_SD3.Valor % 256);
				Comunicacao.Buffer_cmd[17] = (byte)(RT_geral.GC_82x_BD.liga_SD1.Valor / 256);
				Comunicacao.Buffer_cmd[18] = (byte)(RT_geral.GC_82x_BD.liga_SD1.Valor % 256);
				Comunicacao.Buffer_cmd[19] = (byte)(RT_geral.GC_82x_BD.liga_SD2.Valor / 256);
				Comunicacao.Buffer_cmd[20] = (byte)(RT_geral.GC_82x_BD.liga_SD2.Valor % 256);
				Comunicacao.Buffer_cmd[21] = (byte)(RT_geral.GC_82x_BD.liga_SD3.Valor / 256);
				Comunicacao.Buffer_cmd[22] = (byte)(RT_geral.GC_82x_BD.liga_SD3.Valor % 256);
				Comunicacao.Buffer_cmd[23] = (byte)(RT_geral.GC_82x_BD.desliga_SD1.Valor / 256);
				Comunicacao.Buffer_cmd[24] = (byte)(RT_geral.GC_82x_BD.desliga_SD1.Valor % 256);
				Comunicacao.Buffer_cmd[25] = (byte)(RT_geral.GC_82x_BD.desliga_SD2.Valor / 256);
				Comunicacao.Buffer_cmd[26] = (byte)(RT_geral.GC_82x_BD.desliga_SD2.Valor % 256);
				Comunicacao.Buffer_cmd[27] = (byte)(RT_geral.GC_82x_BD.desliga_SD3.Valor / 256);
				Comunicacao.Buffer_cmd[28] = (byte)(RT_geral.GC_82x_BD.desliga_SD3.Valor % 256);
				Comunicacao.Buffer_cmd[29] = (byte)(RT_geral.GC_82x_BD.sentido_SD1.Valor / 256);
				Comunicacao.Buffer_cmd[30] = (byte)(RT_geral.GC_82x_BD.sentido_SD1.Valor % 256);
				Comunicacao.Buffer_cmd[31] = (byte)(RT_geral.GC_82x_BD.sentido_SD2.Valor / 256);
				Comunicacao.Buffer_cmd[32] = (byte)(RT_geral.GC_82x_BD.sentido_SD2.Valor % 256);
				Comunicacao.Buffer_cmd[33] = (byte)(RT_geral.GC_82x_BD.sentido_SD3.Valor / 256);
				Comunicacao.Buffer_cmd[34] = (byte)(RT_geral.GC_82x_BD.sentido_SD3.Valor % 256);
				RT_geral.GC_82x_BD.modo_SA1.Valor = 21937;
				RT_geral.GC_82x_BD.modo_SA2.Valor = 21938;
				Comunicacao.Buffer_cmd[35] = (byte)(RT_geral.GC_82x_BD.modo_SA1.Valor / 256);
				Comunicacao.Buffer_cmd[36] = (byte)(RT_geral.GC_82x_BD.modo_SA1.Valor % 256);
				Comunicacao.Buffer_cmd[37] = (byte)(RT_geral.GC_82x_BD.modo_SA2.Valor / 256);
				Comunicacao.Buffer_cmd[38] = (byte)(RT_geral.GC_82x_BD.modo_SA2.Valor % 256);
				Comunicacao.Buffer_cmd[39] = (byte)(RT_geral.GC_82x_BD.limt_inferior1.Valor / 256);
				Comunicacao.Buffer_cmd[40] = (byte)(RT_geral.GC_82x_BD.limt_inferior1.Valor % 256);
				Comunicacao.Buffer_cmd[41] = (byte)(RT_geral.GC_82x_BD.limt_inferior2.Valor / 256);
				Comunicacao.Buffer_cmd[42] = (byte)(RT_geral.GC_82x_BD.limt_inferior2.Valor % 256);
				Comunicacao.Buffer_cmd[43] = (byte)(RT_geral.GC_82x_BD.limt_superior1.Valor / 256);
				Comunicacao.Buffer_cmd[44] = (byte)(RT_geral.GC_82x_BD.limt_superior1.Valor % 256);
				Comunicacao.Buffer_cmd[45] = (byte)(RT_geral.GC_82x_BD.limt_superior2.Valor / 256);
				Comunicacao.Buffer_cmd[46] = (byte)(RT_geral.GC_82x_BD.limt_superior2.Valor % 256);
				Comunicacao.Buffer_cmd[47] = (byte)(RT_geral.GC_82x_BD.AD_Intervalo.Valor / 256);
				Comunicacao.Buffer_cmd[48] = (byte)(RT_geral.GC_82x_BD.AD_Intervalo.Valor % 256);
				Comunicacao.Buffer_cmd[49] = (byte)(RT_geral.GC_82x_BD.AD_Tamanho_filtro.Valor / 256);
				Comunicacao.Buffer_cmd[50] = (byte)(RT_geral.GC_82x_BD.AD_Tamanho_filtro.Valor % 256);
				int num = 51;
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[51] = (byte)(num2 % 256);
				Comunicacao.Buffer_cmd[52] = (byte)(num2 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, 53);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				int result = 0;
				return result;
			}
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00233140 File Offset: 0x00231540
		public static int CMD_Esc_GC_825x_Calibracao_SA(int endereco_estacao, int canal, int funcao_sa)
		{
			int num = 0;
			if (funcao_sa == 0)
			{
				num = 6175;
			}
			else
			{
				num = 6191;
			}
			checked
			{
				int num2 = num + canal;
				Comunicacao.Init_buffer_serial();
				Comunicacao.Buffer_cmd[0] = (byte)endereco_estacao;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(num2 / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(num2 % 256);
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 1;
				Comunicacao.Buffer_cmd[6] = 2;
				Comunicacao.Buffer_cmd[7] = 85;
				Comunicacao.Buffer_cmd[8] = 85;
				int num3 = 9;
				num2 = Comunicacao.Crc16_TX(ref num3);
				Comunicacao.Buffer_cmd[9] = (byte)(num2 % 256);
				Comunicacao.Buffer_cmd[10] = (byte)(num2 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, 11);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				int result = 0;
				return result;
			}
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00233224 File Offset: 0x00231624
		public static void CMD_Esc_GC_825x_DADOS_DE_RX_mA(int endereco, int corrente1, int corrente2)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 80;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 3;
				Comunicacao.Buffer_cmd[6] = 6;
				Comunicacao.Buffer_cmd[7] = 0;
				Comunicacao.Buffer_cmd[8] = 0;
				Comunicacao.Buffer_cmd[9] = (byte)(corrente1 / 256);
				Comunicacao.Buffer_cmd[10] = (byte)(corrente1 % 256);
				Comunicacao.Buffer_cmd[11] = (byte)(corrente2 / 256);
				Comunicacao.Buffer_cmd[12] = (byte)(corrente2 % 256);
				int num = 13;
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[13] = (byte)(num2 % 256);
				Comunicacao.Buffer_cmd[14] = (byte)(num2 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, 15);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00233320 File Offset: 0x00231720
		public static void CMD_Esc_GC_825x_DADOS_DE_RX_CONTAGENS(int endereco)
		{
			int num = 0;
			int num2 = 0;
			if (RT_geral.GC_82x_BD.calib_canal == 1)
			{
				num = RT_geral.GC_82x_BD.calib_contagens;
				num2 = 0;
			}
			else
			{
				num = 0;
				num2 = RT_geral.GC_82x_BD.calib_contagens;
			}
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 80;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 3;
				Comunicacao.Buffer_cmd[6] = 6;
				Comunicacao.Buffer_cmd[7] = 0;
				Comunicacao.Buffer_cmd[8] = 0;
				Comunicacao.Buffer_cmd[9] = (byte)(num / 256);
				Comunicacao.Buffer_cmd[10] = (byte)(num % 256);
				Comunicacao.Buffer_cmd[11] = (byte)(num2 / 256);
				Comunicacao.Buffer_cmd[12] = (byte)(num2 % 256);
				int num3 = 13;
				int num4 = Comunicacao.Crc16_TX(ref num3);
				Comunicacao.Buffer_cmd[13] = (byte)(num4 % 256);
				Comunicacao.Buffer_cmd[14] = (byte)(num4 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, 15);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00233444 File Offset: 0x00231844
		public static int CMD_Esc_RT_810_H2800(int endereco)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 40;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 2;
				Comunicacao.Buffer_cmd[6] = 4;
				Comunicacao.Buffer_cmd[7] = (byte)(RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[0].Valor / 256);
				Comunicacao.Buffer_cmd[8] = (byte)(RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[0].Valor % 256);
				Comunicacao.Buffer_cmd[9] = (byte)(RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[0].Valor / 256);
				Comunicacao.Buffer_cmd[10] = (byte)(RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[0].Valor % 256);
				int num = 11;
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[11] = (byte)(num2 % 256);
				Comunicacao.Buffer_cmd[12] = (byte)(num2 / 256);
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, 13);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return 13;
			}
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00233590 File Offset: 0x00231990
		public static void Atualiza_dados_RT_820_200(int pag)
		{
			checked
			{
				if (pag == 0)
				{
					RT_geral.RT_820_200_BD.firmware.Equip.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_820_200_BD.firmware.Versao.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_geral.RT_820_200_BD.firmware.Build.Valor = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					RT_geral.RT_820_200_BD.firmware.Release.Valor = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
				}
				else if (pag == 256)
				{
					RT_geral.RT_820_200_BD.cfg_geral.End_estacao.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_820_200_BD.cfg_geral.End_mestre.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora, (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8]);
					RT_geral.RT_820_200_BD.cfg_geral.Tempo_ptt.Valor = ((int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10]) * 10;
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2, (int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12]);
					RT_geral.RT_820_200_BD.cfg_geral.AD_Intervalo.Valor = ((int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14]) * 10;
					RT_geral.RT_820_200_BD.cfg_geral.AD_Tamanho_filtro.Valor = (int)Comunicacao.Buffer_resp[15] * 256 + (int)Comunicacao.Buffer_resp[16];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.modo_operacao, (int)Comunicacao.Buffer_resp[17] * 256 + (int)Comunicacao.Buffer_resp[18]);
					RT_geral.RT_820_200_BD.cfg_geral.quantidade_motores.Valor = (int)Comunicacao.Buffer_resp[19] * 256 + (int)Comunicacao.Buffer_resp[20];
					RT_geral.RT_820_200_BD.cfg_geral.quantidade_valvulas.Valor = (int)Comunicacao.Buffer_resp[21] * 256 + (int)Comunicacao.Buffer_resp[22];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.modo_partida[0], (int)Comunicacao.Buffer_resp[23] * 256 + (int)Comunicacao.Buffer_resp[24]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.modo_partida[1], (int)Comunicacao.Buffer_resp[25] * 256 + (int)Comunicacao.Buffer_resp[26]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.modo_partida[2], (int)Comunicacao.Buffer_resp[27] * 256 + (int)Comunicacao.Buffer_resp[28]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.modo_partida[3], (int)Comunicacao.Buffer_resp[29] * 256 + (int)Comunicacao.Buffer_resp[30]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.entradas[0], (int)Comunicacao.Buffer_resp[31] * 256 + (int)Comunicacao.Buffer_resp[32]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.entradas[1], (int)Comunicacao.Buffer_resp[33] * 256 + (int)Comunicacao.Buffer_resp[34]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.entradas[2], (int)Comunicacao.Buffer_resp[35] * 256 + (int)Comunicacao.Buffer_resp[36]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.entradas[3], (int)Comunicacao.Buffer_resp[37] * 256 + (int)Comunicacao.Buffer_resp[38]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.entradas[4], (int)Comunicacao.Buffer_resp[39] * 256 + (int)Comunicacao.Buffer_resp[40]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.entradas[5], (int)Comunicacao.Buffer_resp[41] * 256 + (int)Comunicacao.Buffer_resp[42]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.entradas[6], (int)Comunicacao.Buffer_resp[43] * 256 + (int)Comunicacao.Buffer_resp[44]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.entradas[7], (int)Comunicacao.Buffer_resp[45] * 256 + (int)Comunicacao.Buffer_resp[46]);
					RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Alto.Valor = (int)Comunicacao.Buffer_resp[47] * 256 + (int)Comunicacao.Buffer_resp[48];
					RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Baixo.Valor = (int)Comunicacao.Buffer_resp[49] * 256 + (int)Comunicacao.Buffer_resp[50];
					RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Alto.Valor = (int)Comunicacao.Buffer_resp[51] * 256 + (int)Comunicacao.Buffer_resp[52];
					RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Baixo.Valor = (int)Comunicacao.Buffer_resp[53] * 256 + (int)Comunicacao.Buffer_resp[54];
					RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Alto.Valor = (int)Comunicacao.Buffer_resp[55] * 256 + (int)Comunicacao.Buffer_resp[56];
					RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Baixo.Valor = (int)Comunicacao.Buffer_resp[57] * 256 + (int)Comunicacao.Buffer_resp[58];
					RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Alto.Valor = (int)Comunicacao.Buffer_resp[59] * 256 + (int)Comunicacao.Buffer_resp[60];
					RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Baixo.Valor = (int)Comunicacao.Buffer_resp[61] * 256 + (int)Comunicacao.Buffer_resp[62];
					RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Desliga.Valor = (int)Comunicacao.Buffer_resp[63] * 256 + (int)Comunicacao.Buffer_resp[64];
					RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Liga.Valor = (int)Comunicacao.Buffer_resp[65] * 256 + (int)Comunicacao.Buffer_resp[66];
					RT_geral.RT_820_200_BD.cfg_geral.partida.Motor1.Valor = (int)Comunicacao.Buffer_resp[67] * 256 + (int)Comunicacao.Buffer_resp[68];
					RT_geral.RT_820_200_BD.cfg_geral.partida.Motor2.Valor = (int)Comunicacao.Buffer_resp[69] * 256 + (int)Comunicacao.Buffer_resp[70];
					RT_geral.RT_820_200_BD.cfg_geral.partida.Motor3.Valor = (int)Comunicacao.Buffer_resp[71] * 256 + (int)Comunicacao.Buffer_resp[72];
					RT_geral.RT_820_200_BD.cfg_geral.partida.Motor4.Valor = (int)Comunicacao.Buffer_resp[73] * 256 + (int)Comunicacao.Buffer_resp[74];
					RT_geral.RT_820_200_BD.cfg_geral.parada.Motor1.Valor = (int)Comunicacao.Buffer_resp[75] * 256 + (int)Comunicacao.Buffer_resp[76];
					RT_geral.RT_820_200_BD.cfg_geral.parada.Motor2.Valor = (int)Comunicacao.Buffer_resp[77] * 256 + (int)Comunicacao.Buffer_resp[78];
					RT_geral.RT_820_200_BD.cfg_geral.parada.Motor3.Valor = (int)Comunicacao.Buffer_resp[79] * 256 + (int)Comunicacao.Buffer_resp[80];
					RT_geral.RT_820_200_BD.cfg_geral.parada.Motor4.Valor = (int)Comunicacao.Buffer_resp[81] * 256 + (int)Comunicacao.Buffer_resp[82];
					RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula1.Valor = (int)Comunicacao.Buffer_resp[83] * 256 + (int)Comunicacao.Buffer_resp[84];
					RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula2.Valor = (int)Comunicacao.Buffer_resp[85] * 256 + (int)Comunicacao.Buffer_resp[86];
					RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula3.Valor = (int)Comunicacao.Buffer_resp[87] * 256 + (int)Comunicacao.Buffer_resp[88];
					RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula4.Valor = (int)Comunicacao.Buffer_resp[89] * 256 + (int)Comunicacao.Buffer_resp[90];
					RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula1.Valor = (int)Comunicacao.Buffer_resp[91] * 256 + (int)Comunicacao.Buffer_resp[92];
					RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula2.Valor = (int)Comunicacao.Buffer_resp[93] * 256 + (int)Comunicacao.Buffer_resp[94];
					RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula3.Valor = (int)Comunicacao.Buffer_resp[95] * 256 + (int)Comunicacao.Buffer_resp[96];
					RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula4.Valor = (int)Comunicacao.Buffer_resp[97] * 256 + (int)Comunicacao.Buffer_resp[98];
					RT_geral.RT_820_200_BD.cfg_geral.tempo_acionamentos.Valor = (int)Comunicacao.Buffer_resp[99] * 256 + (int)Comunicacao.Buffer_resp[100];
					RT_geral.RT_820_200_BD.cfg_geral.bombas_simultaneas.Valor = (int)Comunicacao.Buffer_resp[101] * 256 + (int)Comunicacao.Buffer_resp[102];
					RT_geral.RT_820_200_BD.cfg_geral.nivel_fonte.Valor = (int)Comunicacao.Buffer_resp[103] * 256 + (int)Comunicacao.Buffer_resp[104];
					RT_geral.RT_820_200_BD.cfg_geral.numero_vazoes.Valor = (int)Comunicacao.Buffer_resp[105] * 256 + (int)Comunicacao.Buffer_resp[106];
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[0].End_Quant.Valor = (int)Comunicacao.Buffer_resp[107];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.perifericos[0].Equipamento, (int)Comunicacao.Buffer_resp[108]);
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[1].End_Quant.Valor = (int)Comunicacao.Buffer_resp[109];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.perifericos[1].Equipamento, (int)Comunicacao.Buffer_resp[110]);
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[2].End_Quant.Valor = (int)Comunicacao.Buffer_resp[111];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.perifericos[2].Equipamento, (int)Comunicacao.Buffer_resp[112]);
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[3].End_Quant.Valor = (int)Comunicacao.Buffer_resp[113];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.perifericos[3].Equipamento, (int)Comunicacao.Buffer_resp[114]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.origem_controle, (int)Comunicacao.Buffer_resp[115] * 256 + (int)Comunicacao.Buffer_resp[116]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.origem_protecao, (int)Comunicacao.Buffer_resp[117] * 256 + (int)Comunicacao.Buffer_resp[118]);
				}
				else if (pag == 512)
				{
					RT_geral.RT_820_200_BD.repetidora.End_repetidora.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					int num = 0;
					do
					{
						RT_geral.RT_820_200_BD.repetidora.Repetidoras[num].Valor = (int)Comunicacao.Buffer_resp[2 * num + 7] * 256 + (int)Comunicacao.Buffer_resp[2 * num + 8];
						num++;
					}
					while (num <= 49);
				}
				else if (pag == 2816)
				{
					RT_geral.RT_820_200_BD.setpoint_horario[0].Hora.Valor = (int)Comunicacao.Buffer_resp[3];
					RT_geral.RT_820_200_BD.setpoint_horario[0].Minuto.Valor = (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_820_200_BD.setpoint_horario[0].Alto.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_geral.RT_820_200_BD.setpoint_horario[0].Baixo.Valor = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					RT_geral.RT_820_200_BD.setpoint_horario[1].Hora.Valor = (int)Comunicacao.Buffer_resp[9];
					RT_geral.RT_820_200_BD.setpoint_horario[1].Minuto.Valor = (int)Comunicacao.Buffer_resp[10];
					RT_geral.RT_820_200_BD.setpoint_horario[1].Alto.Valor = (int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12];
					RT_geral.RT_820_200_BD.setpoint_horario[1].Baixo.Valor = (int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14];
					RT_geral.RT_820_200_BD.setpoint_horario[2].Hora.Valor = (int)Comunicacao.Buffer_resp[15];
					RT_geral.RT_820_200_BD.setpoint_horario[2].Minuto.Valor = (int)Comunicacao.Buffer_resp[16];
					RT_geral.RT_820_200_BD.setpoint_horario[2].Alto.Valor = (int)Comunicacao.Buffer_resp[17] * 256 + (int)Comunicacao.Buffer_resp[18];
					RT_geral.RT_820_200_BD.setpoint_horario[2].Baixo.Valor = (int)Comunicacao.Buffer_resp[19] * 256 + (int)Comunicacao.Buffer_resp[20];
					RT_geral.RT_820_200_BD.setpoint_horario[3].Hora.Valor = (int)Comunicacao.Buffer_resp[21];
					RT_geral.RT_820_200_BD.setpoint_horario[3].Minuto.Valor = (int)Comunicacao.Buffer_resp[22];
					RT_geral.RT_820_200_BD.setpoint_horario[3].Alto.Valor = (int)Comunicacao.Buffer_resp[23] * 256 + (int)Comunicacao.Buffer_resp[24];
					RT_geral.RT_820_200_BD.setpoint_horario[3].Baixo.Valor = (int)Comunicacao.Buffer_resp[25] * 256 + (int)Comunicacao.Buffer_resp[26];
					RT_geral.RT_820_200_BD.setpoint_horario[4].Hora.Valor = (int)Comunicacao.Buffer_resp[27];
					RT_geral.RT_820_200_BD.setpoint_horario[4].Minuto.Valor = (int)Comunicacao.Buffer_resp[28];
					RT_geral.RT_820_200_BD.setpoint_horario[4].Alto.Valor = (int)Comunicacao.Buffer_resp[29] * 256 + (int)Comunicacao.Buffer_resp[30];
					RT_geral.RT_820_200_BD.setpoint_horario[4].Baixo.Valor = (int)Comunicacao.Buffer_resp[31] * 256 + (int)Comunicacao.Buffer_resp[32];
					RT_geral.RT_820_200_BD.setpoint_horario[5].Hora.Valor = (int)Comunicacao.Buffer_resp[33];
					RT_geral.RT_820_200_BD.setpoint_horario[5].Minuto.Valor = (int)Comunicacao.Buffer_resp[34];
					RT_geral.RT_820_200_BD.setpoint_horario[5].Alto.Valor = (int)Comunicacao.Buffer_resp[35] * 256 + (int)Comunicacao.Buffer_resp[36];
					RT_geral.RT_820_200_BD.setpoint_horario[5].Baixo.Valor = (int)Comunicacao.Buffer_resp[37] * 256 + (int)Comunicacao.Buffer_resp[38];
					RT_geral.RT_820_200_BD.setpoint_horario[6].Hora.Valor = (int)Comunicacao.Buffer_resp[39];
					RT_geral.RT_820_200_BD.setpoint_horario[6].Minuto.Valor = (int)Comunicacao.Buffer_resp[40];
					RT_geral.RT_820_200_BD.setpoint_horario[6].Alto.Valor = (int)Comunicacao.Buffer_resp[41] * 256 + (int)Comunicacao.Buffer_resp[42];
					RT_geral.RT_820_200_BD.setpoint_horario[6].Baixo.Valor = (int)Comunicacao.Buffer_resp[43] * 256 + (int)Comunicacao.Buffer_resp[44];
					RT_geral.RT_820_200_BD.setpoint_horario[7].Hora.Valor = (int)Comunicacao.Buffer_resp[45];
					RT_geral.RT_820_200_BD.setpoint_horario[7].Minuto.Valor = (int)Comunicacao.Buffer_resp[46];
					RT_geral.RT_820_200_BD.setpoint_horario[7].Alto.Valor = (int)Comunicacao.Buffer_resp[47] * 256 + (int)Comunicacao.Buffer_resp[48];
					RT_geral.RT_820_200_BD.setpoint_horario[7].Baixo.Valor = (int)Comunicacao.Buffer_resp[49] * 256 + (int)Comunicacao.Buffer_resp[50];
				}
			}
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00234750 File Offset: 0x00232B50
		public static void Atualiza_dados_RT_821_200(int pag)
		{
			checked
			{
				if (pag == 0)
				{
					RT_geral.RT_821_200_BD.firmware.Equip.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_821_200_BD.firmware.Versao.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_geral.RT_821_200_BD.firmware.Build.Valor = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					RT_geral.RT_821_200_BD.firmware.Release.Valor = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
				}
				else if (pag == 256)
				{
					RT_geral.RT_821_200_BD.cfg_geral.End_estacao.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_821_200_BD.cfg_geral.End_mestre.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora, (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8]);
					RT_geral.RT_821_200_BD.cfg_geral.Tempo_ptt.Valor = ((int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10]) * 10;
					RT_geral.RT_821_200_BD.cfg_geral.quantidade_motores.Valor = (int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12];
					RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].Valor = (int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14];
					RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].Valor = (int)Comunicacao.Buffer_resp[15] * 256 + (int)Comunicacao.Buffer_resp[16];
					RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].Valor = (int)Comunicacao.Buffer_resp[17] * 256 + (int)Comunicacao.Buffer_resp[18];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0], RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].Valor);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1], RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].Valor);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2], RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].Valor);
					RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Alto.Valor = (int)Comunicacao.Buffer_resp[19] * 256 + (int)Comunicacao.Buffer_resp[20];
					RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Baixo.Valor = (int)Comunicacao.Buffer_resp[21] * 256 + (int)Comunicacao.Buffer_resp[22];
					RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Alto.Valor = (int)Comunicacao.Buffer_resp[23] * 256 + (int)Comunicacao.Buffer_resp[24];
					RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Baixo.Valor = (int)Comunicacao.Buffer_resp[25] * 256 + (int)Comunicacao.Buffer_resp[26];
					RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Alto.Valor = (int)Comunicacao.Buffer_resp[27] * 256 + (int)Comunicacao.Buffer_resp[28];
					RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Baixo.Valor = (int)Comunicacao.Buffer_resp[29] * 256 + (int)Comunicacao.Buffer_resp[30];
					RT_geral.RT_821_200_BD.cfg_geral.partida.Motor1.Valor = (int)Comunicacao.Buffer_resp[31] * 256 + (int)Comunicacao.Buffer_resp[32];
					RT_geral.RT_821_200_BD.cfg_geral.partida.Motor2.Valor = (int)Comunicacao.Buffer_resp[33] * 256 + (int)Comunicacao.Buffer_resp[34];
					RT_geral.RT_821_200_BD.cfg_geral.partida.Motor3.Valor = (int)Comunicacao.Buffer_resp[35] * 256 + (int)Comunicacao.Buffer_resp[36];
					RT_geral.RT_821_200_BD.cfg_geral.parada.Motor1.Valor = (int)Comunicacao.Buffer_resp[37] * 256 + (int)Comunicacao.Buffer_resp[38];
					RT_geral.RT_821_200_BD.cfg_geral.parada.Motor2.Valor = (int)Comunicacao.Buffer_resp[39] * 256 + (int)Comunicacao.Buffer_resp[40];
					RT_geral.RT_821_200_BD.cfg_geral.parada.Motor3.Valor = (int)Comunicacao.Buffer_resp[41] * 256 + (int)Comunicacao.Buffer_resp[42];
					RT_geral.RT_821_200_BD.cfg_geral.tempo_acionamentos.Valor = (int)Comunicacao.Buffer_resp[43] * 256 + (int)Comunicacao.Buffer_resp[44];
					RT_geral.RT_821_200_BD.cfg_geral.motores_simultaneos.Valor = (int)Comunicacao.Buffer_resp[45] * 256 + (int)Comunicacao.Buffer_resp[46];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.entradas[0], (int)Comunicacao.Buffer_resp[47] * 256 + (int)Comunicacao.Buffer_resp[48]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.entradas[1], (int)Comunicacao.Buffer_resp[49] * 256 + (int)Comunicacao.Buffer_resp[50]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.entradas[2], (int)Comunicacao.Buffer_resp[51] * 256 + (int)Comunicacao.Buffer_resp[52]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.entradas[3], (int)Comunicacao.Buffer_resp[53] * 256 + (int)Comunicacao.Buffer_resp[54]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.entradas[4], (int)Comunicacao.Buffer_resp[55] * 256 + (int)Comunicacao.Buffer_resp[56]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.entradas[5], (int)Comunicacao.Buffer_resp[57] * 256 + (int)Comunicacao.Buffer_resp[58]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.entradas[6], (int)Comunicacao.Buffer_resp[59] * 256 + (int)Comunicacao.Buffer_resp[60]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.entradas[7], (int)Comunicacao.Buffer_resp[61] * 256 + (int)Comunicacao.Buffer_resp[62]);
				}
				else if (pag == 512)
				{
					RT_geral.RT_821_200_BD.repetidora.End_repetidora.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					int num = 0;
					do
					{
						RT_geral.RT_821_200_BD.repetidora.Repetidoras[num].Valor = (int)Comunicacao.Buffer_resp[2 * num + 7] * 256 + (int)Comunicacao.Buffer_resp[2 * num + 8];
						num++;
					}
					while (num <= 49);
				}
			}
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00234EE4 File Offset: 0x002332E4
		public static int Atualiza_GT2010(int pag)
		{
			int result = 0;
			if (pag == 768)
			{
				int num = checked((int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4]);
				result = num;
			}
			else if (pag == 512)
			{
			}
			return result;
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00234F20 File Offset: 0x00233320
		public static int GetInteger(byte[] buffer, ref int index)
		{
			checked
			{
				int num = (int)buffer[index] * 256;
				index++;
				num += (int)buffer[index];
				index++;
				return num;
			}
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00234F50 File Offset: 0x00233350
		public static byte GetByte(byte[] buffer, ref int index)
		{
			byte result = buffer[index];
			checked
			{
				index++;
				return result;
			}
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00234F6C File Offset: 0x0023336C
		public static void SetInteger(ref byte[] buffer, ref int index, int valor)
		{
			checked
			{
				buffer[index] = (byte)(valor / 256);
				index++;
				buffer[index] = (byte)(valor % 256);
				index++;
			}
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00234F94 File Offset: 0x00233394
		public static void SetByte(ref byte[] buffer, ref int index, int valor)
		{
			checked
			{
				buffer[index] = (byte)valor;
				index++;
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00234FA4 File Offset: 0x002333A4
		public static void Atualiza_dados_RT_820_HabilitaExpansao()
		{
			RT_geral.RT_820_BD.HabExpIO.Valor = checked((int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4]);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00234FCC File Offset: 0x002333CC
		public static void Atualiza_dados_RT_820_360_HabilitaExpansao()
		{
			RT_geral.RT_820_360_BD.HabExpIO.Valor = checked((int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4]);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00234FF4 File Offset: 0x002333F4
		public static void Atualiza_dados_RT_820(int pag)
		{
			checked
			{
				if (pag == 0)
				{
					RT_geral.RT_820_BD.Equip.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_820_BD.Versao.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_geral.RT_820_BD.Build.Valor = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					RT_geral.RT_820_BD.Release.Valor = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
				}
				else if (pag == 2048)
				{
					RT_geral.RT_820_BD.End_estacao.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_820_BD.End_mestre.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_geral.RT_820_BD.TempoForaAr.Valor = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					if (RT_geral.RT_820_BD.TempoForaAr.Valor > RT_geral.RT_820_BD.TempoForaAr.Lmte_sup)
					{
						RT_geral.RT_820_BD.TempoForaAr.Valor = 0;
					}
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_BD.modo_repetidora, (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10]);
					RT_geral.RT_820_BD.Tempo_ptt.Valor = (int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_BD.BaudRateCOM2, (int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14]);
					RT_geral.RT_820_BD.AD_Intervalo.Valor = (int)Comunicacao.Buffer_resp[15] * 256 + (int)Comunicacao.Buffer_resp[16];
					RT_geral.RT_820_BD.AD_Tamanho_filtro.Valor = (int)Comunicacao.Buffer_resp[17] * 256 + (int)Comunicacao.Buffer_resp[18];
					RT_geral.RT_820_BD.HabExpIO.Valor = (int)Comunicacao.Buffer_resp[19] * 256 + (int)Comunicacao.Buffer_resp[20];
					int num = 0;
					do
					{
						int num2 = num * 2;
						RT_geral.RT_820_BD.EA_Range[num].Valor = (int)Comunicacao.Buffer_resp[21 + num2] * 256 + (int)Comunicacao.Buffer_resp[22 + num2];
						RT_geral.RT_820_BD.EA_Inicio[num].Valor = (int)Comunicacao.Buffer_resp[53 + num2] * 256 + (int)Comunicacao.Buffer_resp[54 + num2];
						RT_geral.RT_820_BD.EA_Fim[num].Valor = (int)Comunicacao.Buffer_resp[85 + num2] * 256 + (int)Comunicacao.Buffer_resp[86 + num2];
						num++;
					}
					while (num <= 15);
					num = 0;
					do
					{
						int num2 = num * 2;
						int dado = (int)Comunicacao.Buffer_resp[117 + num2] * 256 + (int)Comunicacao.Buffer_resp[118 + num2];
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_acionamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[0], dado);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_desligamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[2], (int)Comunicacao.Buffer_resp[133 + num2] * 256 + (int)Comunicacao.Buffer_resp[134 + num2]);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_ret_acionamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[1], (int)Comunicacao.Buffer_resp[149 + num2] * 256 + (int)Comunicacao.Buffer_resp[150 + num2]);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_ret_desligamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[3], (int)Comunicacao.Buffer_resp[165 + num2] * 256 + (int)Comunicacao.Buffer_resp[166 + num2]);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_ED_selecao[num], RT_geral.RT_820_DataGrigViewProcessosColunas[4], (int)Comunicacao.Buffer_resp[181 + num2] * 256 + (int)Comunicacao.Buffer_resp[182 + num2]);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_ED_bloqueio[num], RT_geral.RT_820_DataGrigViewProcessosColunas[5], (int)Comunicacao.Buffer_resp[197 + num2] * 256 + (int)Comunicacao.Buffer_resp[198 + num2]);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_ED_liberacao[num], RT_geral.RT_820_DataGrigViewProcessosColunas[6], (int)Comunicacao.Buffer_resp[213 + num2] * 256 + (int)Comunicacao.Buffer_resp[214 + num2]);
						num++;
					}
					while (num <= 7);
				}
				else if (pag == 2161)
				{
					int num = 0;
					do
					{
						int num2 = num * 2;
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_reverso[num], RT_geral.RT_820_DataGrigViewProcessosColunas[7], (int)Comunicacao.Buffer_resp[3 + num2] * 256 + (int)Comunicacao.Buffer_resp[4 + num2]);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_modo[num], RT_geral.RT_820_DataGrigViewProcessosColunas[8], (int)Comunicacao.Buffer_resp[19 + num2] * 256 + (int)Comunicacao.Buffer_resp[20 + num2]);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_agrupamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[9], (int)Comunicacao.Buffer_resp[35 + num2] * 256 + (int)Comunicacao.Buffer_resp[36 + num2]);
						num++;
					}
					while (num <= 7);
					num = 0;
					do
					{
						int num2 = num * 2;
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.grupo_simultaneos[num], RT_geral.RT_820_DataGrigViewGruposColunas[0], (int)Comunicacao.Buffer_resp[51 + num2] * 256 + (int)Comunicacao.Buffer_resp[52 + num2]);
						RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos[num].Valor = (int)Comunicacao.Buffer_resp[59 + num2] * 256 + (int)Comunicacao.Buffer_resp[60 + num2];
						num++;
					}
					while (num <= 3);
					num = 0;
					do
					{
						int num2 = num * 2;
						RT_geral.RT_820_BD.ctrl_tempo_max_partida[num].Valor = (int)Comunicacao.Buffer_resp[67 + num2] * 256 + (int)Comunicacao.Buffer_resp[68 + num2];
						RT_geral.RT_820_BD.ctrl_tempo_max_parada[num].Valor = (int)Comunicacao.Buffer_resp[83 + num2] * 256 + (int)Comunicacao.Buffer_resp[84 + num2];
						RT_geral.RT_820_BD.ctrl_tempo_min_parado[num].Valor = (int)Comunicacao.Buffer_resp[99 + num2] * 256 + (int)Comunicacao.Buffer_resp[100 + num2];
						RT_geral.RT_820_BD.ctrl_tempo_min_operando[num].Valor = (int)Comunicacao.Buffer_resp[115 + num2] * 256 + (int)Comunicacao.Buffer_resp[116 + num2];
						num++;
					}
					while (num <= 7);
					num = 0;
					do
					{
						int num2 = num * 2;
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.config_ED[num], RT_geral.RT_820_DataGrigViewEDColunas[0], (int)Comunicacao.Buffer_resp[131 + num2] * 256 + (int)Comunicacao.Buffer_resp[132 + num2]);
						num++;
					}
					while (num <= 15);
					num = 0;
					do
					{
						int num2 = num * 2;
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.config_vazao[num], RT_geral.RT_820_DataGrigViewVazoesColunas[0], (int)Comunicacao.Buffer_resp[163 + num2] * 256 + (int)Comunicacao.Buffer_resp[164 + num2]);
						num++;
					}
					while (num <= 7);
					num = 0;
					do
					{
						int num2 = num * 2;
						RT_geral.RT_820_BD.config_perifericos_end[num].Valor = (int)Comunicacao.Buffer_resp[179 + num2];
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.config_perifericos_mod[num], RT_geral.RT_820_DataGrigViewPerifericosColunas[0], (int)Comunicacao.Buffer_resp[180 + num2]);
						num++;
					}
					while (num <= 4);
					RT_geral.RT_820_BD.BaudRateCOM1.Valor = (int)Comunicacao.Buffer_resp[189] * 256 + (int)Comunicacao.Buffer_resp[190];
					if (!perifericos.Lista_ValorPermitido(RT_geral.RT_820_BD.BaudRateCOM1.Valor, perifericos.ListaBaudRate))
					{
						RT_geral.RT_820_BD.BaudRateCOM1.Valor = Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate));
					}
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_BD.BaudRateCOM1, RT_geral.RT_820_BD.BaudRateCOM1.Valor);
				}
				else if (pag == 4096)
				{
					RT_geral.RT_820_BD.End_repetidora.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_820_BD.Num_repetidoras.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					int num = 0;
					do
					{
						RT_geral.RT_820_BD.Repetidoras[num].Valor = (int)Comunicacao.Buffer_resp[2 * num + 7] * 256 + (int)Comunicacao.Buffer_resp[2 * num + 8];
						num++;
					}
					while (num <= 49);
				}
				else if (pag == 8192)
				{
					int num = 0;
					do
					{
						int num2 = num * 4;
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.Setpoints_ctrl_variavel[num], RT_geral.RT_820_DataGrigViewSetpointsColunas[0], (int)Comunicacao.Buffer_resp[3 + num2] * 256 + (int)Comunicacao.Buffer_resp[4 + num2]);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.Setpoints_ctrl_bloqueio[num], RT_geral.RT_820_DataGrigViewSetpointsColunas[3], (int)Comunicacao.Buffer_resp[5 + num2] * 256 + (int)Comunicacao.Buffer_resp[6 + num2]);
						num++;
					}
					while (num <= 7);
				}
				else if (pag == 10240)
				{
					int num = 0;
					do
					{
						int num2 = num * 4;
						RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[num].Valor = (int)Comunicacao.Buffer_resp[3 + num2] * 256 + (int)Comunicacao.Buffer_resp[4 + num2];
						RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[num].Valor = (int)Comunicacao.Buffer_resp[5 + num2] * 256 + (int)Comunicacao.Buffer_resp[6 + num2];
						num++;
					}
					while (num <= 7);
				}
				else if (pag == 12288)
				{
					int num = 0;
					do
					{
						int num2 = num * 4;
						RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[num].Valor = (int)Comunicacao.Buffer_resp[3 + num2] * 256 + (int)Comunicacao.Buffer_resp[4 + num2];
						RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[num].Valor = (int)Comunicacao.Buffer_resp[5 + num2] * 256 + (int)Comunicacao.Buffer_resp[6 + num2];
						num++;
					}
					while (num <= 7);
				}
				else if (pag == 22528)
				{
					int num = 0;
					do
					{
						int num2 = num * 6;
						RT_geral.RT_820_BD.setpoint_horario[num].Hora.Valor = (int)Comunicacao.Buffer_resp[3 + num2];
						RT_geral.RT_820_BD.setpoint_horario[num].Minuto.Valor = (int)Comunicacao.Buffer_resp[4 + num2];
						RT_geral.RT_820_BD.setpoint_horario[num].Alto.Valor = (int)Comunicacao.Buffer_resp[5 + num2] * 256 + (int)Comunicacao.Buffer_resp[6 + num2];
						RT_geral.RT_820_BD.setpoint_horario[num].Baixo.Valor = (int)Comunicacao.Buffer_resp[7 + num2] * 256 + (int)Comunicacao.Buffer_resp[8 + num2];
						num++;
					}
					while (num <= 15);
				}
				else if (pag == 24576)
				{
					int num = 0;
					do
					{
						int num2 = num * 12;
						RT_geral.RT_820_BD.config_referencia_perif_periferico[num].Valor = (int)Comunicacao.Buffer_resp[3 + num2] * 256 + (int)Comunicacao.Buffer_resp[4 + num2];
						RT_geral.RT_820_BD.config_referencia_perif_formato[num].Valor = (int)Comunicacao.Buffer_resp[5 + num2];
						RT_geral.RT_820_BD.config_referencia_perif_base10[num].Valor = (int)Comunicacao.Buffer_resp[6 + num2];
						RT_geral.RT_820_BD.config_referencia_perif_memoria[num].Valor = (int)Comunicacao.Buffer_resp[7 + num2] * 256 + (int)Comunicacao.Buffer_resp[8 + num2];
						RT_geral.RT_820_BD.config_referencia_perif_variavel1[num].Valor = (int)Comunicacao.Buffer_resp[9 + num2] * 256 + (int)Comunicacao.Buffer_resp[10 + num2];
						RT_geral.RT_820_BD.config_referencia_perif_variavel2[num].Valor = (int)Comunicacao.Buffer_resp[11 + num2] * 256 + (int)Comunicacao.Buffer_resp[12 + num2];
						RT_geral.RT_820_BD.config_referencia_perif_escala[num].Valor = (int)Comunicacao.Buffer_resp[13 + num2] * 256 + (int)Comunicacao.Buffer_resp[14 + num2];
						num++;
					}
					while (num <= 9);
				}
				else if (pag == 26624)
				{
					int num3 = 3;
					RT_geral.RT_820_BD.config_atuador1_perif[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_formato[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_base10[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_mem[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_var1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_var2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_escala1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_escala2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_histerese[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[1].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[1].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[2].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[2].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_v1baixo[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_v1alto[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_v2baixo[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
					RT_geral.RT_820_BD.config_atuador1_v2alto[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num3);
				}
				else if (pag == 26711)
				{
					int num4 = 3;
					RT_geral.RT_820_BD.config_atuador2_perif[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_formato[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_base10[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_mem[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_var1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_var2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_escala1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_escala2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_histerese[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[1].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[1].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[2].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[2].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_v1baixo[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_v1alto[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_v2baixo[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_BD.config_atuador2_v2alto[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
				}
				else if (pag == 26798)
				{
					int num5 = 3;
					RT_geral.RT_820_BD.config_atuador3_perif[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_formato[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_base10[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_mem[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_var1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_var2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_escala1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_escala2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_histerese[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[1].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[1].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[2].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[2].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_v1baixo[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_v1alto[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_v2baixo[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_BD.config_atuador3_v2alto[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
				}
				else if (pag == 26885)
				{
					int num6 = 3;
					RT_geral.RT_820_BD.config_atuador4_perif[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_formato[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_base10[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_mem[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_var1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_var2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_escala1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_escala2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_histerese[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[1].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[1].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[2].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[2].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_v1baixo[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_v1alto[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_v2baixo[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_BD.config_atuador4_v2alto[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
				}
				else if (pag == 30720)
				{
					int num7 = 0;
					do
					{
						int num2 = num7 * 24;
						RT_geral.RT_820_BD.Timer_Horario[num7][0].Valor = (int)Comunicacao.Buffer_resp[3 + num2] * 256 + (int)Comunicacao.Buffer_resp[4 + num2];
						RT_geral.RT_820_BD.Timer_Horario[num7][2].Valor = (int)Comunicacao.Buffer_resp[5 + num2] * 256 + (int)Comunicacao.Buffer_resp[6 + num2];
						RT_geral.RT_820_BD.Timer_Horario[num7][4].Valor = (int)Comunicacao.Buffer_resp[7 + num2] * 256 + (int)Comunicacao.Buffer_resp[8 + num2];
						RT_geral.RT_820_BD.Timer_Horario[num7][6].Valor = (int)Comunicacao.Buffer_resp[9 + num2] * 256 + (int)Comunicacao.Buffer_resp[10 + num2];
						RT_geral.RT_820_BD.Timer_Horario[num7][8].Valor = (int)Comunicacao.Buffer_resp[11 + num2] * 256 + (int)Comunicacao.Buffer_resp[12 + num2];
						RT_geral.RT_820_BD.Timer_Horario[num7][10].Valor = (int)Comunicacao.Buffer_resp[13 + num2] * 256 + (int)Comunicacao.Buffer_resp[14 + num2];
						RT_geral.RT_820_BD.Timer_Horario[num7][1].Valor = (int)Comunicacao.Buffer_resp[15 + num2] * 256 + (int)Comunicacao.Buffer_resp[16 + num2];
						RT_geral.RT_820_BD.Timer_Horario[num7][3].Valor = (int)Comunicacao.Buffer_resp[17 + num2] * 256 + (int)Comunicacao.Buffer_resp[18 + num2];
						RT_geral.RT_820_BD.Timer_Horario[num7][5].Valor = (int)Comunicacao.Buffer_resp[19 + num2] * 256 + (int)Comunicacao.Buffer_resp[20 + num2];
						RT_geral.RT_820_BD.Timer_Horario[num7][7].Valor = (int)Comunicacao.Buffer_resp[21 + num2] * 256 + (int)Comunicacao.Buffer_resp[22 + num2];
						RT_geral.RT_820_BD.Timer_Horario[num7][9].Valor = (int)Comunicacao.Buffer_resp[23 + num2] * 256 + (int)Comunicacao.Buffer_resp[24 + num2];
						RT_geral.RT_820_BD.Timer_Horario[num7][11].Valor = (int)Comunicacao.Buffer_resp[25 + num2] * 256 + (int)Comunicacao.Buffer_resp[26 + num2];
						num7++;
					}
					while (num7 <= 7);
				}
			}
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00238E7C File Offset: 0x0023727C
		public static void Atualiza_dados_RT820_360(int pag)
		{
			checked
			{
				if (pag == 0)
				{
					RT_geral.RT_820_360_BD.Equip.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_820_360_BD.Versao.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_geral.RT_820_360_BD.Build.Valor = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					RT_geral.RT_820_360_BD.Release.Valor = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
				}
				else if (pag == 2048)
				{
					int num = 3;
					RT_geral.RT_820_360_BD.End_estacao1.Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
					RT_geral.RT_820_360_BD.End_estacao2.Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
					RT_geral.RT_820_360_BD.End_mestre.Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
					RT_geral.RT_820_360_BD.TempoForaAr.Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
					if (RT_geral.RT_820_360_BD.TempoForaAr.Valor > RT_geral.RT_820_360_BD.TempoForaAr.Lmte_sup)
					{
						RT_geral.RT_820_360_BD.TempoForaAr.Valor = 0;
					}
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_360_BD.modo_repetidora, Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num));
					RT_geral.RT_820_360_BD.Tempo_ptt.Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
					RT_geral.RT_820_360_BD.BaudRateCOM1.Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
					if (!perifericos.Lista_ValorPermitido(RT_geral.RT_820_360_BD.BaudRateCOM1.Valor, perifericos.ListaBaudRate))
					{
						RT_geral.RT_820_360_BD.BaudRateCOM1.Valor = Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate));
					}
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_360_BD.BaudRateCOM1, RT_geral.RT_820_360_BD.BaudRateCOM1.Valor);
					RT_geral.RT_820_360_BD.BaudRateCOM2.Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
					if (!perifericos.Lista_ValorPermitido(RT_geral.RT_820_360_BD.BaudRateCOM2.Valor, perifericos.ListaBaudRate))
					{
						RT_geral.RT_820_360_BD.BaudRateCOM2.Valor = Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate));
					}
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_360_BD.BaudRateCOM2, RT_geral.RT_820_360_BD.BaudRateCOM2.Valor);
					RT_geral.RT_820_360_BD.AD_Intervalo.Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
					RT_geral.RT_820_360_BD.AD_Tamanho_filtro.Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
					RT_geral.RT_820_360_BD.HabExpIO.Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
					num = 25;
					int num2 = 0;
					do
					{
						RT_geral.RT_820_360_BD.EA_Range[num2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						num2++;
					}
					while (num2 <= 15);
					num2 = 0;
					do
					{
						RT_geral.RT_820_360_BD.EA_Inicio[num2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						num2++;
					}
					while (num2 <= 15);
					num2 = 0;
					do
					{
						RT_geral.RT_820_360_BD.EA_Fim[num2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						num2++;
					}
					while (num2 <= 15);
					num = 121;
					num2 = 0;
					do
					{
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_acionamento[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[0], Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num));
						num2++;
					}
					while (num2 <= 7);
					num2 = 0;
					do
					{
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_desligamento[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[2], Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num));
						num2++;
					}
					while (num2 <= 7);
					num2 = 0;
					do
					{
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_ret_acionamento[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[1], Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num));
						num2++;
					}
					while (num2 <= 7);
					num2 = 0;
					do
					{
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_ret_desligamento[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[3], Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num));
						num2++;
					}
					while (num2 <= 7);
					num2 = 0;
					do
					{
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_ED_selecao[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[4], Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num));
						num2++;
					}
					while (num2 <= 7);
					num2 = 0;
					do
					{
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_ED_bloqueio[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[5], Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num));
						num2++;
					}
					while (num2 <= 7);
					num2 = 0;
					do
					{
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_ED_liberacao[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[6], Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num));
						num2++;
					}
					while (num2 <= 7);
				}
				else if (pag == 2163)
				{
					int num2 = 0;
					do
					{
						int num3 = num2 * 2;
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_reverso[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[7], (int)Comunicacao.Buffer_resp[3 + num3] * 256 + (int)Comunicacao.Buffer_resp[4 + num3]);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_modo[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[8], (int)Comunicacao.Buffer_resp[19 + num3] * 256 + (int)Comunicacao.Buffer_resp[20 + num3]);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_agrupamento[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[9], (int)Comunicacao.Buffer_resp[35 + num3] * 256 + (int)Comunicacao.Buffer_resp[36 + num3]);
						num2++;
					}
					while (num2 <= 7);
					num2 = 0;
					do
					{
						int num3 = num2 * 2;
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.grupo_simultaneos[num2], RT_geral.RT_820_DataGrigViewGruposColunas[0], (int)Comunicacao.Buffer_resp[51 + num3] * 256 + (int)Comunicacao.Buffer_resp[52 + num3]);
						RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos[num2].Valor = (int)Comunicacao.Buffer_resp[59 + num3] * 256 + (int)Comunicacao.Buffer_resp[60 + num3];
						num2++;
					}
					while (num2 <= 3);
					num2 = 0;
					do
					{
						int num3 = num2 * 2;
						RT_geral.RT_820_360_BD.ctrl_tempo_max_partida[num2].Valor = (int)Comunicacao.Buffer_resp[67 + num3] * 256 + (int)Comunicacao.Buffer_resp[68 + num3];
						RT_geral.RT_820_360_BD.ctrl_tempo_max_parada[num2].Valor = (int)Comunicacao.Buffer_resp[83 + num3] * 256 + (int)Comunicacao.Buffer_resp[84 + num3];
						RT_geral.RT_820_360_BD.ctrl_tempo_min_parado[num2].Valor = (int)Comunicacao.Buffer_resp[99 + num3] * 256 + (int)Comunicacao.Buffer_resp[100 + num3];
						RT_geral.RT_820_360_BD.ctrl_tempo_min_operando[num2].Valor = (int)Comunicacao.Buffer_resp[115 + num3] * 256 + (int)Comunicacao.Buffer_resp[116 + num3];
						num2++;
					}
					while (num2 <= 7);
					num2 = 0;
					do
					{
						int num3 = num2 * 2;
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.config_ED[num2], RT_geral.RT_820_DataGrigViewEDColunas[0], (int)Comunicacao.Buffer_resp[131 + num3] * 256 + (int)Comunicacao.Buffer_resp[132 + num3]);
						num2++;
					}
					while (num2 <= 15);
					num2 = 0;
					do
					{
						int num3 = num2 * 2;
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.config_vazao[num2], RT_geral.RT_820_DataGrigViewVazoesColunas[0], (int)Comunicacao.Buffer_resp[163 + num3] * 256 + (int)Comunicacao.Buffer_resp[164 + num3]);
						num2++;
					}
					while (num2 <= 7);
					num2 = 0;
					do
					{
						int num3 = num2 * 2;
						RT_geral.RT_820_360_BD.config_perifericos1_end[num2].Valor = (int)Comunicacao.Buffer_resp[179 + num3];
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.config_perifericos1_mod[num2], RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[0], (int)Comunicacao.Buffer_resp[180 + num3]);
						num2++;
					}
					while (num2 <= 4);
					num2 = 0;
					do
					{
						int num3 = num2 * 2;
						RT_geral.RT_820_360_BD.config_perifericos2_end[num2].Valor = (int)Comunicacao.Buffer_resp[189 + num3];
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.config_perifericos2_mod[num2], RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[0], (int)Comunicacao.Buffer_resp[190 + num3]);
						num2++;
					}
					while (num2 <= 4);
					if (RT_geral.RT_820_360_flag_calha_vazao)
					{
						RT_geral.RT_820_360_flag_calha_vazao = true;
						int num3 = (int)Comunicacao.Buffer_resp[199] * 256 + (int)Comunicacao.Buffer_resp[200];
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.calha_EA[0], RT_geral.RT_820_DatagridViewCalhasColunas[0], num3);
						num3 = (int)Comunicacao.Buffer_resp[201] * 256 + (int)Comunicacao.Buffer_resp[202];
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.calha_EA[1], RT_geral.RT_820_DatagridViewCalhasColunas[0], num3);
						num3 = (int)Comunicacao.Buffer_resp[203] * 256 + (int)Comunicacao.Buffer_resp[204];
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.calha_modelo[0], RT_geral.RT_820_DatagridViewCalhasColunas[1], num3);
						num3 = (int)Comunicacao.Buffer_resp[205] * 256 + (int)Comunicacao.Buffer_resp[206];
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.calha_modelo[1], RT_geral.RT_820_DatagridViewCalhasColunas[1], num3);
						RT_geral.RT_820_360_BD.calha_fundo[0].Valor = (int)Comunicacao.Buffer_resp[207] * 256 + (int)Comunicacao.Buffer_resp[208];
						RT_geral.RT_820_360_BD.calha_fundo[1].Valor = (int)Comunicacao.Buffer_resp[209] * 256 + (int)Comunicacao.Buffer_resp[210];
						RT_geral.RT_820_360_BD.calha_p1[0].Valor = (int)Comunicacao.Buffer_resp[211] * 256 + (int)Comunicacao.Buffer_resp[212];
						RT_geral.RT_820_360_BD.calha_p1[1].Valor = (int)Comunicacao.Buffer_resp[213] * 256 + (int)Comunicacao.Buffer_resp[214];
						RT_geral.RT_820_360_BD.calha_p2[0].Valor = (int)Comunicacao.Buffer_resp[215] * 256 + (int)Comunicacao.Buffer_resp[216];
						RT_geral.RT_820_360_BD.calha_p2[1].Valor = (int)Comunicacao.Buffer_resp[217] * 256 + (int)Comunicacao.Buffer_resp[218];
						RT_geral.RT_820_360_BD.calha_p3[0].Valor = (int)Comunicacao.Buffer_resp[219] * 256 + (int)Comunicacao.Buffer_resp[220];
						RT_geral.RT_820_360_BD.calha_p3[1].Valor = (int)Comunicacao.Buffer_resp[221] * 256 + (int)Comunicacao.Buffer_resp[222];
					}
					else
					{
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.calha_EA[0], RT_geral.RT_820_DatagridViewCalhasColunas[0], 21856);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.calha_EA[1], RT_geral.RT_820_DatagridViewCalhasColunas[0], 21856);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.calha_modelo[0], RT_geral.RT_820_DatagridViewCalhasColunas[1], 0);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.calha_modelo[1], RT_geral.RT_820_DatagridViewCalhasColunas[1], 0);
						RT_geral.RT_820_360_BD.calha_fundo[0].Valor = 0;
						RT_geral.RT_820_360_BD.calha_fundo[1].Valor = 0;
						RT_geral.RT_820_360_BD.calha_p1[0].Valor = 0;
						RT_geral.RT_820_360_BD.calha_p1[1].Valor = 0;
						RT_geral.RT_820_360_BD.calha_p2[0].Valor = 0;
						RT_geral.RT_820_360_BD.calha_p2[1].Valor = 0;
						RT_geral.RT_820_360_BD.calha_p3[0].Valor = 0;
						RT_geral.RT_820_360_BD.calha_p3[1].Valor = 0;
					}
					if (RT_geral.RT_820_360_flag_saida_analogicoAs)
					{
						RT_geral.RT_820_360_BD.saida_SA_origem[0].Valor = (int)Comunicacao.Buffer_resp[223] * 256 + (int)Comunicacao.Buffer_resp[224];
						RT_geral.RT_820_360_BD.saida_SA_origem[0].AtualizaIndicePeloValor();
						RT_geral.RT_820_360_BD.saida_SA_origem[1].Valor = (int)Comunicacao.Buffer_resp[225] * 256 + (int)Comunicacao.Buffer_resp[226];
						RT_geral.RT_820_360_BD.saida_SA_origem[1].AtualizaIndicePeloValor();
						RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0].Valor = (int)Comunicacao.Buffer_resp[227] * 256 + (int)Comunicacao.Buffer_resp[228];
						RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[1].Valor = (int)Comunicacao.Buffer_resp[229] * 256 + (int)Comunicacao.Buffer_resp[230];
						RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[0].Valor = (int)Comunicacao.Buffer_resp[231] * 256 + (int)Comunicacao.Buffer_resp[232];
						RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[1].Valor = (int)Comunicacao.Buffer_resp[233] * 256 + (int)Comunicacao.Buffer_resp[234];
					}
				}
				else if (pag == 2279)
				{
					int num = 3;
					if (RT_geral.RT_820_360_flag_rotativo_motor)
					{
						RT_geral.RT_820_360_BD.grupo_rotativo_motores[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.grupo_rotativo_motores[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.grupo_rotativo_motores[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.grupo_rotativo_motores[3].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.grupo_rotativo_motores[0], RT_geral.RT_820_DataGrigViewGruposColunas[2], RT_geral.RT_820_360_BD.grupo_rotativo_motores[0].Valor);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.grupo_rotativo_motores[1], RT_geral.RT_820_DataGrigViewGruposColunas[2], RT_geral.RT_820_360_BD.grupo_rotativo_motores[1].Valor);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.grupo_rotativo_motores[2], RT_geral.RT_820_DataGrigViewGruposColunas[2], RT_geral.RT_820_360_BD.grupo_rotativo_motores[2].Valor);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.grupo_rotativo_motores[3], RT_geral.RT_820_DataGrigViewGruposColunas[2], RT_geral.RT_820_360_BD.grupo_rotativo_motores[3].Valor);
					}
					else
					{
						RT_geral.RT_820_360_BD.grupo_rotativo_motores[0].Valor = 21856;
						RT_geral.RT_820_360_BD.grupo_rotativo_motores[0].Indice = RT_geral.RT_820_360_BD.grupo_rotativo_motores[0].Indice_padrao;
						RT_geral.RT_820_360_BD.grupo_rotativo_motores[1].Valor = 21856;
						RT_geral.RT_820_360_BD.grupo_rotativo_motores[1].Indice = RT_geral.RT_820_360_BD.grupo_rotativo_motores[1].Indice_padrao;
						RT_geral.RT_820_360_BD.grupo_rotativo_motores[2].Valor = 21856;
						RT_geral.RT_820_360_BD.grupo_rotativo_motores[2].Indice = RT_geral.RT_820_360_BD.grupo_rotativo_motores[2].Indice_padrao;
						RT_geral.RT_820_360_BD.grupo_rotativo_motores[3].Valor = 21856;
						RT_geral.RT_820_360_BD.grupo_rotativo_motores[3].Indice = RT_geral.RT_820_360_BD.grupo_rotativo_motores[3].Indice_padrao;
					}
					num = 11;
					if (RT_geral.RT_820_360_flag_rotativo_motor)
					{
						RT_geral.RT_820_360_BD.ctrl_partidas[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.ctrl_partidas[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.ctrl_partidas[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.ctrl_partidas[3].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.ctrl_partidas[4].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.ctrl_partidas[5].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.ctrl_partidas[6].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.ctrl_partidas[7].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_partidas[0], RT_geral.RT_820_DataGrigViewProcessosColunas[10], RT_geral.RT_820_360_BD.ctrl_partidas[0].Valor);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_partidas[1], RT_geral.RT_820_DataGrigViewProcessosColunas[10], RT_geral.RT_820_360_BD.ctrl_partidas[1].Valor);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_partidas[2], RT_geral.RT_820_DataGrigViewProcessosColunas[10], RT_geral.RT_820_360_BD.ctrl_partidas[2].Valor);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_partidas[3], RT_geral.RT_820_DataGrigViewProcessosColunas[10], RT_geral.RT_820_360_BD.ctrl_partidas[3].Valor);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_partidas[4], RT_geral.RT_820_DataGrigViewProcessosColunas[10], RT_geral.RT_820_360_BD.ctrl_partidas[4].Valor);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_partidas[5], RT_geral.RT_820_DataGrigViewProcessosColunas[10], RT_geral.RT_820_360_BD.ctrl_partidas[5].Valor);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_partidas[6], RT_geral.RT_820_DataGrigViewProcessosColunas[10], RT_geral.RT_820_360_BD.ctrl_partidas[6].Valor);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_partidas[7], RT_geral.RT_820_DataGrigViewProcessosColunas[10], RT_geral.RT_820_360_BD.ctrl_partidas[7].Valor);
					}
					else
					{
						RT_geral.RT_820_360_BD.ctrl_partidas[0].Valor = 21856;
						RT_geral.RT_820_360_BD.ctrl_partidas[0].Indice = RT_geral.RT_820_360_BD.ctrl_partidas[0].Indice_padrao;
						RT_geral.RT_820_360_BD.ctrl_partidas[1].Valor = 21856;
						RT_geral.RT_820_360_BD.ctrl_partidas[1].Indice = RT_geral.RT_820_360_BD.ctrl_partidas[1].Indice_padrao;
						RT_geral.RT_820_360_BD.ctrl_partidas[2].Valor = 21856;
						RT_geral.RT_820_360_BD.ctrl_partidas[2].Indice = RT_geral.RT_820_360_BD.ctrl_partidas[2].Indice_padrao;
						RT_geral.RT_820_360_BD.ctrl_partidas[3].Valor = 21856;
						RT_geral.RT_820_360_BD.ctrl_partidas[3].Indice = RT_geral.RT_820_360_BD.ctrl_partidas[3].Indice_padrao;
						RT_geral.RT_820_360_BD.ctrl_partidas[4].Valor = 21856;
						RT_geral.RT_820_360_BD.ctrl_partidas[4].Indice = RT_geral.RT_820_360_BD.ctrl_partidas[4].Indice_padrao;
						RT_geral.RT_820_360_BD.ctrl_partidas[5].Valor = 21856;
						RT_geral.RT_820_360_BD.ctrl_partidas[5].Indice = RT_geral.RT_820_360_BD.ctrl_partidas[5].Indice_padrao;
						RT_geral.RT_820_360_BD.ctrl_partidas[6].Valor = 21856;
						RT_geral.RT_820_360_BD.ctrl_partidas[6].Indice = RT_geral.RT_820_360_BD.ctrl_partidas[6].Indice_padrao;
						RT_geral.RT_820_360_BD.ctrl_partidas[7].Valor = 21856;
						RT_geral.RT_820_360_BD.ctrl_partidas[7].Indice = RT_geral.RT_820_360_BD.ctrl_partidas[7].Indice_padrao;
					}
				}
				else if (pag == 4096)
				{
					RT_geral.RT_820_360_BD.End_repetidora.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_820_360_BD.Num_repetidoras.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					int num2 = 0;
					do
					{
						RT_geral.RT_820_360_BD.Repetidoras[num2].Valor = (int)Comunicacao.Buffer_resp[2 * num2 + 7] * 256 + (int)Comunicacao.Buffer_resp[2 * num2 + 8];
						num2++;
					}
					while (num2 <= 49);
				}
				else if (pag == 8192)
				{
					int num2 = 0;
					do
					{
						int num3 = num2 * 4;
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.Setpoints_ctrl_variavel[num2], RT_geral.RT_820_DataGrigViewSetpointsColunas[0], (int)Comunicacao.Buffer_resp[3 + num3] * 256 + (int)Comunicacao.Buffer_resp[4 + num3]);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.Setpoints_ctrl_bloqueio[num2], RT_geral.RT_820_DataGrigViewSetpointsColunas[3], (int)Comunicacao.Buffer_resp[5 + num3] * 256 + (int)Comunicacao.Buffer_resp[6 + num3]);
						num2++;
					}
					while (num2 <= 7);
				}
				else if (pag == 10240)
				{
					int num2 = 0;
					do
					{
						int num3 = num2 * 4;
						RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[num2].Valor = (int)Comunicacao.Buffer_resp[3 + num3] * 256 + (int)Comunicacao.Buffer_resp[4 + num3];
						RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[num2].Valor = (int)Comunicacao.Buffer_resp[5 + num3] * 256 + (int)Comunicacao.Buffer_resp[6 + num3];
						num2++;
					}
					while (num2 <= 7);
				}
				else if (pag == 12288)
				{
					int num2 = 0;
					do
					{
						int num3 = num2 * 4;
						RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[num2].Valor = (int)Comunicacao.Buffer_resp[3 + num3] * 256 + (int)Comunicacao.Buffer_resp[4 + num3];
						RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[num2].Valor = (int)Comunicacao.Buffer_resp[5 + num3] * 256 + (int)Comunicacao.Buffer_resp[6 + num3];
						num2++;
					}
					while (num2 <= 7);
				}
				else if (pag == 22528)
				{
					int num = 3;
					int num2 = 0;
					do
					{
						RT_geral.RT_820_360_BD.setpoint_horario[num2].Hora.Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.setpoint_horario[num2].Minuto.Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.setpoint_horario[num2].Alto.Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.setpoint_horario[num2].Baixo.Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						num2++;
					}
					while (num2 <= 39);
				}
				else if (pag == 22648)
				{
					int num = 3;
					int num2 = 40;
					do
					{
						RT_geral.RT_820_360_BD.setpoint_horario[num2].Hora.Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.setpoint_horario[num2].Minuto.Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.setpoint_horario[num2].Alto.Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.setpoint_horario[num2].Baixo.Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						num2++;
					}
					while (num2 <= 79);
				}
				else if (pag == 24576)
				{
					int num2 = 0;
					do
					{
						int num3 = num2 * 12;
						RT_geral.RT_820_360_BD.config_referencia_perif_periferico[num2].Valor = (int)Comunicacao.Buffer_resp[3 + num3] * 256 + (int)Comunicacao.Buffer_resp[4 + num3];
						RT_geral.RT_820_360_BD.config_referencia_perif_formato[num2].Valor = (int)Comunicacao.Buffer_resp[5 + num3];
						RT_geral.RT_820_360_BD.config_referencia_perif_base10[num2].Valor = (int)Comunicacao.Buffer_resp[6 + num3];
						RT_geral.RT_820_360_BD.config_referencia_perif_memoria[num2].Valor = (int)Comunicacao.Buffer_resp[7 + num3] * 256 + (int)Comunicacao.Buffer_resp[8 + num3];
						RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[num2].Valor = (int)Comunicacao.Buffer_resp[9 + num3] * 256 + (int)Comunicacao.Buffer_resp[10 + num3];
						RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[num2].Valor = (int)Comunicacao.Buffer_resp[11 + num3] * 256 + (int)Comunicacao.Buffer_resp[12 + num3];
						RT_geral.RT_820_360_BD.config_referencia_perif_escala[num2].Valor = (int)Comunicacao.Buffer_resp[13 + num3] * 256 + (int)Comunicacao.Buffer_resp[14 + num3];
						num2++;
					}
					while (num2 <= 9);
				}
				else if (pag == 26624)
				{
					int num4 = 3;
					RT_geral.RT_820_360_BD.config_atuador1_perif[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_formato[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_base10[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_mem[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_var1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_var2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_escala1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_escala2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_histerese[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[1].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[1].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[2].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[2].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_v1baixo[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_v1alto[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_v2baixo[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
					RT_geral.RT_820_360_BD.config_atuador1_v2alto[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num4);
				}
				else if (pag == 26711)
				{
					int num5 = 3;
					RT_geral.RT_820_360_BD.config_atuador2_perif[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_formato[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_base10[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_mem[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_var1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_var2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_escala1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_escala2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_histerese[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[1].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[1].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[2].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[2].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_v1baixo[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_v1alto[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_v2baixo[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
					RT_geral.RT_820_360_BD.config_atuador2_v2alto[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num5);
				}
				else if (pag == 26798)
				{
					int num6 = 3;
					RT_geral.RT_820_360_BD.config_atuador3_perif[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_formato[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_base10[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_mem[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_var1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_var2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_escala1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_escala2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_histerese[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[1].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[1].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[2].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[2].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_v1baixo[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_v1alto[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_v2baixo[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
					RT_geral.RT_820_360_BD.config_atuador3_v2alto[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num6);
				}
				else if (pag == 26885)
				{
					int num7 = 3;
					RT_geral.RT_820_360_BD.config_atuador4_perif[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_formato[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_base10[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_mem[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_var1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_var2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_escala1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_escala2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_histerese[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[0].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[1].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[1].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[2].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[2].Valor = (int)Linha_RT.GetByte(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[1].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[2].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_v1baixo[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_v1alto[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_v2baixo[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
					RT_geral.RT_820_360_BD.config_atuador4_v2alto[0].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num7);
				}
				else if (pag == 30720)
				{
					int num8 = 0;
					do
					{
						int num3 = num8 * 24;
						RT_geral.RT_820_360_BD.Timer_Horario[num8][0].Valor = (int)Comunicacao.Buffer_resp[3 + num3] * 256 + (int)Comunicacao.Buffer_resp[4 + num3];
						RT_geral.RT_820_360_BD.Timer_Horario[num8][2].Valor = (int)Comunicacao.Buffer_resp[5 + num3] * 256 + (int)Comunicacao.Buffer_resp[6 + num3];
						RT_geral.RT_820_360_BD.Timer_Horario[num8][4].Valor = (int)Comunicacao.Buffer_resp[7 + num3] * 256 + (int)Comunicacao.Buffer_resp[8 + num3];
						RT_geral.RT_820_360_BD.Timer_Horario[num8][6].Valor = (int)Comunicacao.Buffer_resp[9 + num3] * 256 + (int)Comunicacao.Buffer_resp[10 + num3];
						RT_geral.RT_820_360_BD.Timer_Horario[num8][8].Valor = (int)Comunicacao.Buffer_resp[11 + num3] * 256 + (int)Comunicacao.Buffer_resp[12 + num3];
						RT_geral.RT_820_360_BD.Timer_Horario[num8][10].Valor = (int)Comunicacao.Buffer_resp[13 + num3] * 256 + (int)Comunicacao.Buffer_resp[14 + num3];
						RT_geral.RT_820_360_BD.Timer_Horario[num8][1].Valor = (int)Comunicacao.Buffer_resp[15 + num3] * 256 + (int)Comunicacao.Buffer_resp[16 + num3];
						RT_geral.RT_820_360_BD.Timer_Horario[num8][3].Valor = (int)Comunicacao.Buffer_resp[17 + num3] * 256 + (int)Comunicacao.Buffer_resp[18 + num3];
						RT_geral.RT_820_360_BD.Timer_Horario[num8][5].Valor = (int)Comunicacao.Buffer_resp[19 + num3] * 256 + (int)Comunicacao.Buffer_resp[20 + num3];
						RT_geral.RT_820_360_BD.Timer_Horario[num8][7].Valor = (int)Comunicacao.Buffer_resp[21 + num3] * 256 + (int)Comunicacao.Buffer_resp[22 + num3];
						RT_geral.RT_820_360_BD.Timer_Horario[num8][9].Valor = (int)Comunicacao.Buffer_resp[23 + num3] * 256 + (int)Comunicacao.Buffer_resp[24 + num3];
						RT_geral.RT_820_360_BD.Timer_Horario[num8][11].Valor = (int)Comunicacao.Buffer_resp[25 + num3] * 256 + (int)Comunicacao.Buffer_resp[26 + num3];
						num8++;
					}
					while (num8 <= 7);
				}
				else if (pag == 28672)
				{
					int num = 3;
					int num8 = 0;
					do
					{
						RT_geral.RT_820_360_BD.config_periferico_modbus_generico_endcom[num8].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num8].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num8].Indice = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num8].Indice_padrao;
						int num9 = 0;
						int num10 = RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].NumeroLinhaMenu - 1;
						for (int i = num9; i <= num10; i++)
						{
							if (RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num8].Valor == RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].LinhasValor[i])
							{
								RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num8].Indice = i;
								break;
							}
						}
						RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem1[num8].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem2[num8].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem3[num8].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem4[num8].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var1[num8].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var2[num8].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var3[num8].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var4[num8].Valor = Linha_RT.GetInteger(Comunicacao.Buffer_resp, ref num);
						num8++;
					}
					while (num8 <= 4);
				}
			}
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0023DCAC File Offset: 0x0023C0AC
		public static int CMD_Esc_RT820_360_H800_Parte_1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 8;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 115;
				Comunicacao.Buffer_cmd[6] = 230;
				Comunicacao.Buffer_cmd[7] = (byte)(RT_geral.RT_820_360_BD.End_estacao1.Valor / 256);
				Comunicacao.Buffer_cmd[8] = (byte)(RT_geral.RT_820_360_BD.End_estacao1.Valor % 256);
				Comunicacao.Buffer_cmd[9] = (byte)(RT_geral.RT_820_360_BD.End_estacao2.Valor / 256);
				Comunicacao.Buffer_cmd[10] = (byte)(RT_geral.RT_820_360_BD.End_estacao2.Valor % 256);
				Comunicacao.Buffer_cmd[11] = (byte)(RT_geral.RT_820_360_BD.End_mestre.Valor / 256);
				Comunicacao.Buffer_cmd[12] = (byte)(RT_geral.RT_820_360_BD.End_mestre.Valor % 256);
				Comunicacao.Buffer_cmd[13] = (byte)(RT_geral.RT_820_360_BD.TempoForaAr.Valor / 256);
				Comunicacao.Buffer_cmd[14] = (byte)(RT_geral.RT_820_360_BD.TempoForaAr.Valor % 256);
				Comunicacao.Buffer_cmd[15] = (byte)(RT_geral.RT_820_360_BD.modo_repetidora.Valor / 256);
				Comunicacao.Buffer_cmd[16] = (byte)(RT_geral.RT_820_360_BD.modo_repetidora.Valor % 256);
				Comunicacao.Buffer_cmd[17] = (byte)(RT_geral.RT_820_360_BD.Tempo_ptt.Valor / 256);
				Comunicacao.Buffer_cmd[18] = (byte)(RT_geral.RT_820_360_BD.Tempo_ptt.Valor % 256);
				Comunicacao.Buffer_cmd[19] = (byte)(RT_geral.RT_820_360_BD.BaudRateCOM1.Valor / 256);
				Comunicacao.Buffer_cmd[20] = (byte)(RT_geral.RT_820_360_BD.BaudRateCOM1.Valor % 256);
				Comunicacao.Buffer_cmd[21] = (byte)(RT_geral.RT_820_360_BD.BaudRateCOM2.Valor / 256);
				Comunicacao.Buffer_cmd[22] = (byte)(RT_geral.RT_820_360_BD.BaudRateCOM2.Valor % 256);
				Comunicacao.Buffer_cmd[23] = (byte)(RT_geral.RT_820_360_BD.AD_Intervalo.Valor / 256);
				Comunicacao.Buffer_cmd[24] = (byte)(RT_geral.RT_820_360_BD.AD_Intervalo.Valor % 256);
				Comunicacao.Buffer_cmd[25] = (byte)(RT_geral.RT_820_360_BD.AD_Tamanho_filtro.Valor / 256);
				Comunicacao.Buffer_cmd[26] = (byte)(RT_geral.RT_820_360_BD.AD_Tamanho_filtro.Valor % 256);
				Comunicacao.Buffer_cmd[27] = (byte)(RT_geral.RT_820_360_BD.HabExpIO.Valor / 256);
				Comunicacao.Buffer_cmd[28] = (byte)(RT_geral.RT_820_360_BD.HabExpIO.Valor % 256);
				int num = 28;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.EA_Range[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.EA_Range[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 15);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.EA_Inicio[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.EA_Inicio[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 15);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.EA_Fim[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.EA_Fim[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 15);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_acionamento[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_acionamento[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_desligamento[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_desligamento[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_ret_acionamento[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_ret_acionamento[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_ret_desligamento[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_ret_desligamento[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_ED_selecao[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_ED_selecao[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_ED_bloqueio[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_ED_bloqueio[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_ED_liberacao[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_ED_liberacao[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num++;
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0023E378 File Offset: 0x0023C778
		public static int CMD_Esc_RT820_H800_Parte_1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 8;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 113;
				Comunicacao.Buffer_cmd[6] = 226;
				Comunicacao.Buffer_cmd[7] = (byte)(RT_geral.RT_820_BD.End_estacao.Valor / 256);
				Comunicacao.Buffer_cmd[8] = (byte)(RT_geral.RT_820_BD.End_estacao.Valor % 256);
				Comunicacao.Buffer_cmd[9] = (byte)(RT_geral.RT_820_BD.End_mestre.Valor / 256);
				Comunicacao.Buffer_cmd[10] = (byte)(RT_geral.RT_820_BD.End_mestre.Valor % 256);
				Comunicacao.Buffer_cmd[11] = (byte)(RT_geral.RT_820_BD.TempoForaAr.Valor / 256);
				Comunicacao.Buffer_cmd[12] = (byte)(RT_geral.RT_820_BD.TempoForaAr.Valor % 256);
				Comunicacao.Buffer_cmd[13] = (byte)(RT_geral.RT_820_BD.modo_repetidora.Valor / 256);
				Comunicacao.Buffer_cmd[14] = (byte)(RT_geral.RT_820_BD.modo_repetidora.Valor % 256);
				Comunicacao.Buffer_cmd[15] = (byte)(RT_geral.RT_820_BD.Tempo_ptt.Valor / 256);
				Comunicacao.Buffer_cmd[16] = (byte)(RT_geral.RT_820_BD.Tempo_ptt.Valor % 256);
				Comunicacao.Buffer_cmd[17] = (byte)(RT_geral.RT_820_BD.BaudRateCOM2.Valor / 256);
				Comunicacao.Buffer_cmd[18] = (byte)(RT_geral.RT_820_BD.BaudRateCOM2.Valor % 256);
				Comunicacao.Buffer_cmd[19] = (byte)(RT_geral.RT_820_BD.AD_Intervalo.Valor / 256);
				Comunicacao.Buffer_cmd[20] = (byte)(RT_geral.RT_820_BD.AD_Intervalo.Valor % 256);
				Comunicacao.Buffer_cmd[21] = (byte)(RT_geral.RT_820_BD.AD_Tamanho_filtro.Valor / 256);
				Comunicacao.Buffer_cmd[22] = (byte)(RT_geral.RT_820_BD.AD_Tamanho_filtro.Valor % 256);
				Comunicacao.Buffer_cmd[23] = (byte)(RT_geral.RT_820_BD.HabExpIO.Valor / 256);
				Comunicacao.Buffer_cmd[24] = (byte)(RT_geral.RT_820_BD.HabExpIO.Valor % 256);
				int num = 24;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.EA_Range[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.EA_Range[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 15);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.EA_Inicio[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.EA_Inicio[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 15);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.EA_Fim[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.EA_Fim[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 15);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_acionamento[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_acionamento[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_desligamento[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_desligamento[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_ret_acionamento[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_ret_acionamento[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_ret_desligamento[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_ret_desligamento[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_ED_selecao[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_ED_selecao[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_ED_bloqueio[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_ED_bloqueio[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_ED_liberacao[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_ED_liberacao[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num++;
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0023E9CC File Offset: 0x0023CDCC
		public static int CMD_Esc_RT820_360_H800_Parte_2(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 8;
				Comunicacao.Buffer_cmd[3] = 115;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 116;
				Comunicacao.Buffer_cmd[6] = 232;
				int num = 6;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_reverso[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_reverso[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_modo[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_modo[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_agrupamento[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_agrupamento[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.grupo_simultaneos[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.grupo_simultaneos[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 3);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 3);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_tempo_max_partida[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_tempo_max_partida[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_tempo_max_parada[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_tempo_max_parada[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_tempo_min_parado[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_tempo_min_parado[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_tempo_min_operando[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.ctrl_tempo_min_operando[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_ED[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_ED[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 15);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_vazao[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_vazao[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				int num3 = 0;
				do
				{
					num3 = RT_geral.RT_820_360_BD.config_perifericos1_end[num2].Valor * 256 + RT_geral.RT_820_360_BD.config_perifericos1_mod[num2].Valor;
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
					num2++;
				}
				while (num2 <= 4);
				num2 = 0;
				do
				{
					num3 = RT_geral.RT_820_360_BD.config_perifericos2_end[num2].Valor * 256 + RT_geral.RT_820_360_BD.config_perifericos2_mod[num2].Valor;
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
					num2++;
				}
				while (num2 <= 4);
				num3 = RT_geral.RT_820_360_BD.calha_EA[0].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.calha_EA[1].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.calha_modelo[0].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.calha_modelo[1].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.calha_fundo[0].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.calha_fundo[1].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.calha_p1[0].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.calha_p1[1].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.calha_p2[0].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.calha_p2[1].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.calha_p3[0].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.calha_p3[1].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.saida_SA_origem[0].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.saida_SA_origem[1].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[1].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[0].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num3 = RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[1].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0023F358 File Offset: 0x0023D758
		public static int CMD_Esc_RT820_360_H800_Parte_3(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 8;
				Comunicacao.Buffer_cmd[3] = 231;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 12;
				Comunicacao.Buffer_cmd[6] = 24;
				int num = 6;
				int num2 = RT_geral.RT_820_360_BD.grupo_rotativo_motores[0].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num2 = RT_geral.RT_820_360_BD.grupo_rotativo_motores[1].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num2 = RT_geral.RT_820_360_BD.grupo_rotativo_motores[2].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num2 = RT_geral.RT_820_360_BD.grupo_rotativo_motores[3].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num2 = RT_geral.RT_820_360_BD.ctrl_partidas[0].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num2 = RT_geral.RT_820_360_BD.ctrl_partidas[1].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num2 = RT_geral.RT_820_360_BD.ctrl_partidas[2].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num2 = RT_geral.RT_820_360_BD.ctrl_partidas[3].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num2 = RT_geral.RT_820_360_BD.ctrl_partidas[4].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num2 = RT_geral.RT_820_360_BD.ctrl_partidas[5].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num2 = RT_geral.RT_820_360_BD.ctrl_partidas[6].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num2 = RT_geral.RT_820_360_BD.ctrl_partidas[7].Valor;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num++;
				num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x0023F6F0 File Offset: 0x0023DAF0
		public static int CMD_Esc_RT820_H800_Parte_2(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 8;
				Comunicacao.Buffer_cmd[3] = 113;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 94;
				Comunicacao.Buffer_cmd[6] = 188;
				int num = 6;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_reverso[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_reverso[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_modo[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_modo[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_agrupamento[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_agrupamento[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.grupo_simultaneos[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.grupo_simultaneos[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 3);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 3);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_tempo_max_partida[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_tempo_max_partida[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_tempo_max_parada[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_tempo_max_parada[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_tempo_min_parado[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_tempo_min_parado[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_tempo_min_operando[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.ctrl_tempo_min_operando[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.config_ED[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.config_ED[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 15);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.config_vazao[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.config_vazao[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				int num3 = 0;
				do
				{
					num3 = RT_geral.RT_820_BD.config_perifericos_end[num2].Valor * 256 + RT_geral.RT_820_BD.config_perifericos_mod[num2].Valor;
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
					num2++;
				}
				while (num2 <= 4);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.BaudRateCOM1.Valor / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.BaudRateCOM1.Valor % 256);
				num++;
				num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0023FC24 File Offset: 0x0023E024
		public static int CMD_Esc_RT820_360_PART1_SETPOINT_HORARIO(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 88;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 120;
				Comunicacao.Buffer_cmd[6] = 240;
				int num = 7;
				int num2 = 0;
				do
				{
					Comunicacao.Buffer_cmd[num] = (byte)RT_geral.RT_820_360_BD.setpoint_horario[num2].Hora.Valor;
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)RT_geral.RT_820_360_BD.setpoint_horario[num2].Minuto.Valor;
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.setpoint_horario[num2].Alto.Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.setpoint_horario[num2].Alto.Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.setpoint_horario[num2].Baixo.Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.setpoint_horario[num2].Baixo.Valor % 256);
					num++;
					num2++;
				}
				while (num2 <= 39);
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0023FDF4 File Offset: 0x0023E1F4
		public static int CMD_Esc_RT820_360_PART2_SETPOINT_HORARIO(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 88;
				Comunicacao.Buffer_cmd[3] = 120;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 120;
				Comunicacao.Buffer_cmd[6] = 240;
				int num = 7;
				int num2 = 40;
				do
				{
					Comunicacao.Buffer_cmd[num] = (byte)RT_geral.RT_820_360_BD.setpoint_horario[num2].Hora.Valor;
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)RT_geral.RT_820_360_BD.setpoint_horario[num2].Minuto.Valor;
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.setpoint_horario[num2].Alto.Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.setpoint_horario[num2].Alto.Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.setpoint_horario[num2].Baixo.Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.setpoint_horario[num2].Baixo.Valor % 256);
					num++;
					num2++;
				}
				while (num2 <= 79);
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0023FFC4 File Offset: 0x0023E3C4
		public static int CMD_Esc_RT820_SETPOINT_HORARIO(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 88;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 48;
				Comunicacao.Buffer_cmd[6] = 96;
				int num = 7;
				int num2 = 0;
				do
				{
					Comunicacao.Buffer_cmd[num] = (byte)RT_geral.RT_820_BD.setpoint_horario[num2].Hora.Valor;
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)RT_geral.RT_820_BD.setpoint_horario[num2].Minuto.Valor;
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.setpoint_horario[num2].Alto.Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.setpoint_horario[num2].Alto.Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.setpoint_horario[num2].Baixo.Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.setpoint_horario[num2].Baixo.Valor % 256);
					num++;
					num2++;
				}
				while (num2 <= 15);
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00240190 File Offset: 0x0023E590
		public static int CMD_Esc_RT820_360_REFERENCIA_PERIFERICO(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 96;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 60;
				Comunicacao.Buffer_cmd[6] = 120;
				int num = 7;
				int num2 = 0;
				do
				{
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_referencia_perif_periferico[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_referencia_perif_periferico[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_referencia_perif_formato[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_referencia_perif_base10[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_referencia_perif_memoria[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_referencia_perif_memoria[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_referencia_perif_escala[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_referencia_perif_escala[num2].Valor % 256);
					num++;
					num2++;
				}
				while (num2 <= 9);
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00240434 File Offset: 0x0023E834
		public static object CMD_Esc_RT_820_360_Cal_SA(int pagina, int endereco, int contagens)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(pagina / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(pagina % 256);
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 2;
				Comunicacao.Buffer_cmd[6] = 4;
				int num = 7;
				Comunicacao.Buffer_cmd[num] = 85;
				num++;
				Comunicacao.Buffer_cmd[num] = 85;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(contagens / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(contagens % 256);
				num++;
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00240544 File Offset: 0x0023E944
		public static int CMD_Esc_RT820_360_PERIFERICO_MODBUS_GENERICO(int endereco)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 112;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 50;
				Comunicacao.Buffer_cmd[6] = 100;
				int num = 7;
				int num2 = 0;
				do
				{
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_endcom[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_endcom[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem1[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem1[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem2[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem2[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem3[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem3[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem4[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem4[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var1[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var1[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var2[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var2[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var3[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var3[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var4[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var4[num2].Valor % 256);
					num++;
					num2++;
				}
				while (num2 <= 4);
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00240920 File Offset: 0x0023ED20
		public static int CMD_Esc_RT820_REFERENCIA_PERIFERICO(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 96;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 60;
				Comunicacao.Buffer_cmd[6] = 120;
				int num = 7;
				int num2 = 0;
				do
				{
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.config_referencia_perif_periferico[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.config_referencia_perif_periferico[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.config_referencia_perif_formato[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.config_referencia_perif_base10[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.config_referencia_perif_memoria[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.config_referencia_perif_memoria[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.config_referencia_perif_variavel1[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.config_referencia_perif_variavel1[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.config_referencia_perif_variavel2[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.config_referencia_perif_variavel2[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.config_referencia_perif_escala[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.config_referencia_perif_escala[num2].Valor % 256);
					num++;
					num2++;
				}
				while (num2 <= 9);
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00240BC4 File Offset: 0x0023EFC4
		public static int CMD_Esc_RT820_360_ATUADOR_PERIFERICO_P1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 104;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 87;
				Comunicacao.Buffer_cmd[6] = 174;
				int num = 7;
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_perif[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_formato[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_base10[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_mem[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_var1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_var2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_escala1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_escala2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_histerese[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[1].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[1].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[2].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_v1baixo[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_v1alto[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_v2baixo[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador1_v2alto[0].Valor);
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00241844 File Offset: 0x0023FC44
		public static int CMD_Esc_RT820_ATUADOR_PERIFERICO_P1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 104;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 87;
				Comunicacao.Buffer_cmd[6] = 174;
				int num = 7;
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_perif[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_formato[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_base10[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_mem[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_var1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_var2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_escala1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_escala2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_histerese[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[1].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[1].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[2].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_v1baixo[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_v1alto[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_v2baixo[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador1_v2alto[0].Valor);
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x002424C4 File Offset: 0x002408C4
		public static int CMD_Esc_RT820_ATUADOR_PERIFERICO_P2(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 104;
				Comunicacao.Buffer_cmd[3] = 87;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 87;
				Comunicacao.Buffer_cmd[6] = 174;
				int num = 7;
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_perif[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_formato[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_base10[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_mem[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_var1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_var2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_escala1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_escala2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_histerese[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[1].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[1].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[2].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_v1baixo[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_v1alto[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_v2baixo[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador2_v2alto[0].Valor);
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00243144 File Offset: 0x00241544
		public static int CMD_Esc_RT820_360_ATUADOR_PERIFERICO_P2(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 104;
				Comunicacao.Buffer_cmd[3] = 87;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 87;
				Comunicacao.Buffer_cmd[6] = 174;
				int num = 7;
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_perif[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_formato[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_base10[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_mem[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_var1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_var2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_escala1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_escala2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_histerese[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[1].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[1].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[2].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_v1baixo[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_v1alto[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_v2baixo[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador2_v2alto[0].Valor);
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x00243DC4 File Offset: 0x002421C4
		public static int CMD_Esc_RT820_360_ATUADOR_PERIFERICO_P3(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 104;
				Comunicacao.Buffer_cmd[3] = 174;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 87;
				Comunicacao.Buffer_cmd[6] = 174;
				int num = 7;
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_perif[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_formato[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_base10[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_mem[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_var1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_var2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_escala1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_escala2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_histerese[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[1].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[1].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[2].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_v1baixo[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_v1alto[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_v2baixo[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador3_v2alto[0].Valor);
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00244A48 File Offset: 0x00242E48
		public static int CMD_Esc_RT820_ATUADOR_PERIFERICO_P3(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 104;
				Comunicacao.Buffer_cmd[3] = 174;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 87;
				Comunicacao.Buffer_cmd[6] = 174;
				int num = 7;
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_perif[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_formato[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_base10[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_mem[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_var1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_var2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_escala1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_escala2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_histerese[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[1].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[1].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[2].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_v1baixo[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_v1alto[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_v2baixo[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador3_v2alto[0].Valor);
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x002456CC File Offset: 0x00243ACC
		public static int CMD_Esc_RT820_ATUADOR_PERIFERICO_P4(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 105;
				Comunicacao.Buffer_cmd[3] = 5;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 87;
				Comunicacao.Buffer_cmd[6] = 174;
				int num = 7;
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_perif[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_formato[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_base10[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_mem[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_var1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_var2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_escala1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_escala2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_histerese[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[1].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[1].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[2].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_v1baixo[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_v1alto[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_v2baixo[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_BD.config_atuador4_v2alto[0].Valor);
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0024634C File Offset: 0x0024474C
		public static int CMD_Esc_RT820_360_ATUADOR_PERIFERICO_P4(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 105;
				Comunicacao.Buffer_cmd[3] = 5;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 87;
				Comunicacao.Buffer_cmd[6] = 174;
				int num = 7;
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_perif[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_formato[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_base10[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_mem[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_var1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_var2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_escala1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_escala2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_histerese[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[0].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[1].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[1].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[2].Valor);
				Linha_RT.SetByte(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[1].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[2].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_v1baixo[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_v1alto[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_v2baixo[0].Valor);
				Linha_RT.SetInteger(ref Comunicacao.Buffer_cmd, ref num, RT_geral.RT_820_360_BD.config_atuador4_v2alto[0].Valor);
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num2 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num2 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00246FCC File Offset: 0x002453CC
		public static int CMD_Esc_RT820_360_H1000_Parte_1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 16;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 52;
				Comunicacao.Buffer_cmd[6] = 104;
				Comunicacao.Buffer_cmd[7] = (byte)(RT_geral.RT_820_360_BD.End_repetidora.Valor / 256);
				Comunicacao.Buffer_cmd[8] = (byte)(RT_geral.RT_820_360_BD.End_repetidora.Valor % 256);
				Comunicacao.Buffer_cmd[9] = (byte)(RT_geral.RT_820_360_BD.Num_repetidoras.Valor / 256);
				Comunicacao.Buffer_cmd[10] = (byte)(RT_geral.RT_820_360_BD.Num_repetidoras.Valor % 256);
				int num = 10;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Repetidoras[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Repetidoras[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 49);
				num++;
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00247160 File Offset: 0x00245560
		public static int CMD_Esc_RT820_H1000_Parte_1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 16;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 52;
				Comunicacao.Buffer_cmd[6] = 104;
				Comunicacao.Buffer_cmd[7] = (byte)(RT_geral.RT_820_BD.End_repetidora.Valor / 256);
				Comunicacao.Buffer_cmd[8] = (byte)(RT_geral.RT_820_BD.End_repetidora.Valor % 256);
				Comunicacao.Buffer_cmd[9] = (byte)(RT_geral.RT_820_BD.Num_repetidoras.Valor / 256);
				Comunicacao.Buffer_cmd[10] = (byte)(RT_geral.RT_820_BD.Num_repetidoras.Valor % 256);
				int num = 10;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Repetidoras[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Repetidoras[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 49);
				num++;
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x002472F4 File Offset: 0x002456F4
		public static int CMD_Esc_RT820_360_H2000_Parte_1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 32;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 16;
				Comunicacao.Buffer_cmd[6] = 32;
				int num = 6;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Setpoints_ctrl_variavel[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Setpoints_ctrl_variavel[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Setpoints_ctrl_bloqueio[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Setpoints_ctrl_bloqueio[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num++;
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00247464 File Offset: 0x00245864
		public static int CMD_Esc_RT820_H2000_Parte_1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 32;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 16;
				Comunicacao.Buffer_cmd[6] = 32;
				int num = 6;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Setpoints_ctrl_variavel[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Setpoints_ctrl_variavel[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Setpoints_ctrl_bloqueio[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Setpoints_ctrl_bloqueio[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num++;
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x002475D4 File Offset: 0x002459D4
		public static int CMD_Esc_RT820_360_H2800_Parte_1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 40;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 16;
				Comunicacao.Buffer_cmd[6] = 32;
				int num = 6;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num++;
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00247744 File Offset: 0x00245B44
		public static int CMD_Esc_RT820_H2800_Parte_1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 40;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 16;
				Comunicacao.Buffer_cmd[6] = 32;
				int num = 6;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num++;
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x002478B4 File Offset: 0x00245CB4
		public static int CMD_Esc_RT820_360_H3000_Parte_1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 48;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 16;
				Comunicacao.Buffer_cmd[6] = 32;
				int num = 6;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num++;
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00247A24 File Offset: 0x00245E24
		public static int CMD_Esc_RT820_H3000_Parte_1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 48;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 16;
				Comunicacao.Buffer_cmd[6] = 32;
				int num = 6;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num++;
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00247B94 File Offset: 0x00245F94
		public static int CMD_Esc_RT820_360_H7800_Parte_1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 120;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 96;
				Comunicacao.Buffer_cmd[6] = 192;
				int num = 6;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][0].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][0].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][4].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][4].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][6].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][6].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][8].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][8].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][10].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][10].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][1].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][1].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][3].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][3].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][5].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][5].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][7].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][7].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][9].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][9].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][11].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_360_BD.Timer_Horario[num2][11].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num++;
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00248048 File Offset: 0x00246448
		public static int CMD_Esc_RT820_H7800_Parte_1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 120;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 96;
				Comunicacao.Buffer_cmd[6] = 192;
				int num = 6;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][0].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][0].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][4].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][4].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][6].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][6].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][8].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][8].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][10].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][10].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][1].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][1].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][3].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][3].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][5].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][5].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][7].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][7].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][9].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][9].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][11].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_820_BD.Timer_Horario[num2][11].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num++;
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x002484FC File Offset: 0x002468FC
		public static bool CMD_Esc_GT2010(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 1;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 1;
				Comunicacao.Buffer_cmd[6] = 2;
				Comunicacao.Buffer_cmd[7] = (byte)(equipamento / 256);
				Comunicacao.Buffer_cmd[8] = (byte)(equipamento % 256);
				int num = 9;
				int num2 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[9] = (byte)(num2 % 256);
				Comunicacao.Buffer_cmd[10] = (byte)(num2 / 256);
				int num3 = 0;
				num3++;
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, 11);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return true;
			}
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x002485CC File Offset: 0x002469CC
		public static void Atualiza_dados_RT821(int pag)
		{
			int[] array = new int[41];
			checked
			{
				if (pag == 0)
				{
					RT_geral.RT_821_BD.Equip.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_821_BD.Versao.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_geral.RT_821_BD.Build.Valor = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					RT_geral.RT_821_BD.Release.Valor = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
				}
				else if (pag == 2048)
				{
					RT_geral.RT_821_BD.End_estacao.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_821_BD.End_mestre.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_BD.Modelo, (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8] - 2);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_BD.modo_repetidora, (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10]);
					RT_geral.RT_821_BD.Tempo_ptt.Valor = (int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12];
					RT_geral.RT_821_BD.AD_Intervalo.Valor = (int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14];
					RT_geral.RT_821_BD.AD_Tamanho_filtro.Valor = (int)Comunicacao.Buffer_resp[15] * 256 + (int)Comunicacao.Buffer_resp[16];
					int num = 0;
					do
					{
						int num2 = num * 2;
						RT_geral.RT_821_BD.EA_Range[num].Valor = (int)Comunicacao.Buffer_resp[17 + num2] * 256 + (int)Comunicacao.Buffer_resp[18 + num2];
						RT_geral.RT_821_BD.EA_Inicio[num].Valor = (int)Comunicacao.Buffer_resp[25 + num2] * 256 + (int)Comunicacao.Buffer_resp[26 + num2];
						RT_geral.RT_821_BD.EA_Fim[num].Valor = (int)Comunicacao.Buffer_resp[33 + num2] * 256 + (int)Comunicacao.Buffer_resp[34 + num2];
						num++;
					}
					while (num <= 3);
					num = 0;
					do
					{
						int num2 = num * 2;
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.ctrl_acionamento[num], RT_geral.RT_821_DataGrigViewProcessosColunas[0], (int)Comunicacao.Buffer_resp[41 + num2] * 256 + (int)Comunicacao.Buffer_resp[42 + num2]);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.ctrl_ret_acionamento[num], RT_geral.RT_821_DataGrigViewProcessosColunas[1], (int)Comunicacao.Buffer_resp[47 + num2] * 256 + (int)Comunicacao.Buffer_resp[48 + num2]);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.ctrl_ED_selecao[num], RT_geral.RT_821_DataGrigViewProcessosColunas[2], (int)Comunicacao.Buffer_resp[53 + num2] * 256 + (int)Comunicacao.Buffer_resp[54 + num2]);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.ctrl_reverso[num], RT_geral.RT_821_DataGrigViewProcessosColunas[3], (int)Comunicacao.Buffer_resp[59 + num2] * 256 + (int)Comunicacao.Buffer_resp[60 + num2]);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.ctrl_modo[num], RT_geral.RT_821_DataGrigViewProcessosColunas[4], (int)Comunicacao.Buffer_resp[65 + num2] * 256 + (int)Comunicacao.Buffer_resp[66 + num2]);
						num++;
					}
					while (num <= 2);
					Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.motores_simultaneos[0], RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[0], (int)Comunicacao.Buffer_resp[71] * 256 + (int)Comunicacao.Buffer_resp[72]);
					RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[0].Valor = (int)Comunicacao.Buffer_resp[73] * 256 + (int)Comunicacao.Buffer_resp[74];
					num = 0;
					do
					{
						int num2 = num * 2;
						RT_geral.RT_821_BD.ctrl_tempo_max_partida[num].Valor = (int)Comunicacao.Buffer_resp[75 + num2] * 256 + (int)Comunicacao.Buffer_resp[76 + num2];
						RT_geral.RT_821_BD.ctrl_tempo_max_parada[num].Valor = (int)Comunicacao.Buffer_resp[81 + num2] * 256 + (int)Comunicacao.Buffer_resp[82 + num2];
						num++;
					}
					while (num <= 2);
					num = 0;
					do
					{
						int num2 = num * 2;
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.config_ED[num], RT_geral.RT_821_DataGrigViewEDColunas[0], (int)Comunicacao.Buffer_resp[87 + num2] * 256 + (int)Comunicacao.Buffer_resp[88 + num2]);
						num++;
					}
					while (num <= 7);
					num = 0;
					do
					{
						int num2 = num * 2;
						int num3 = (int)Comunicacao.Buffer_resp[103 + num2] * 256 + (int)Comunicacao.Buffer_resp[104 + num2];
						RT_geral.RT_821_BD.dsp_escalas[num].Valor = num3;
						num3 = (int)Comunicacao.Buffer_resp[119 + num2] * 256 + (int)Comunicacao.Buffer_resp[120 + num2];
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.dsp_pto_decimal[num], RT_geral.RT_821_DataGrigViewVisorColunas[3], num3);
						num++;
					}
					while (num <= 7);
					num = 0;
					do
					{
						int num4 = 135 + num * 6;
						int num3 = 0;
						do
						{
							int num2 = num3 * 2;
							array[num3] = (int)Comunicacao.Buffer_resp[num4 + num2] * 256 + (int)Comunicacao.Buffer_resp[num4 + 1 + num2];
							num3++;
						}
						while (num3 <= 2);
						int num5 = 0;
						string valor = Linha_RT.ConverterIntegerArrayToString_II(ref array, ref num5, 3);
						RT_geral.RT_821_BD.dsp_nome[num].Valor = valor;
						Linha_RT.VerificaSeVariavelValida(RT_geral.RT_821_BD.dsp_nome[num].Valor);
						bool flag = !(array[0] == 0 | array[0] == 32);
						bool flag2 = !(array[1] == 0 | array[1] == 32);
						bool flag3 = !(array[2] == 0 | array[2] == 32);
						if (flag || flag2 || flag3)
						{
							RT_geral.RT_821_BD.dsp_hab[num].Valor = -1;
						}
						else
						{
							RT_geral.RT_821_BD.dsp_hab[num].Valor = 0;
						}
						num++;
					}
					while (num <= 7);
					RT_geral.RT_821_BD.modo_operacao.Valor = (int)Comunicacao.Buffer_resp[183] * 256 + (int)Comunicacao.Buffer_resp[184];
					RT_geral.RT_821_BD.intervalo_tx.Valor = (int)Comunicacao.Buffer_resp[185] * 256 + (int)Comunicacao.Buffer_resp[186];
					RT_geral.RT_821_BD.baudrate_com1.Valor = (int)Comunicacao.Buffer_resp[187] * 256 + (int)Comunicacao.Buffer_resp[188];
					RT_geral.RT_821_BD.baudrate_com2.Valor = (int)Comunicacao.Buffer_resp[189] * 256 + (int)Comunicacao.Buffer_resp[190];
					if (!perifericos.Lista_ValorPermitido(RT_geral.RT_821_BD.baudrate_com1.Valor, perifericos.ListaBaudRate))
					{
						RT_geral.RT_821_BD.baudrate_com1.Valor = Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate));
						Interaction.MsgBox("É possível qua a sua placa RT821_300 não dê suporte a configuração da porta COM1. Será utilizado um valor padrão.", MsgBoxStyle.Exclamation, null);
					}
					if (!perifericos.Lista_ValorPermitido(RT_geral.RT_821_BD.baudrate_com2.Valor, perifericos.ListaBaudRate))
					{
						RT_geral.RT_821_BD.baudrate_com2.Valor = Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate));
						Interaction.MsgBox("É possível qua a sua placa RT821_300 não dê suporte a configuração da porta COM2. Será utilizado um valor padrão.", MsgBoxStyle.Exclamation, null);
					}
					RT_geral.RT_821_BD.baudrate_com1.AtualizaIndicePeloValor();
					RT_geral.RT_821_BD.baudrate_com2.AtualizaIndicePeloValor();
				}
				else if (pag == 4096)
				{
					RT_geral.RT_821_BD.End_repetidora.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_821_BD.Num_repetidoras.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					int num = 0;
					do
					{
						RT_geral.RT_821_BD.Repetidoras[num].Valor = (int)Comunicacao.Buffer_resp[2 * num + 7] * 256 + (int)Comunicacao.Buffer_resp[2 * num + 8];
						num++;
					}
					while (num <= 49);
				}
				else if (pag == 8192)
				{
					int num = 0;
					do
					{
						int num2 = num * 2;
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.Setpoints_ctrl_variavel[num], RT_geral.RT_821_DataGrigViewSetpointsColunas[0], (int)Comunicacao.Buffer_resp[3 + num2] * 256 + (int)Comunicacao.Buffer_resp[4 + num2]);
						num++;
					}
					while (num <= 2);
				}
				else if (pag == 10240)
				{
					int num = 0;
					do
					{
						int num2 = num * 4;
						RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[num].Valor = (int)Comunicacao.Buffer_resp[3 + num2] * 256 + (int)Comunicacao.Buffer_resp[4 + num2];
						RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[num].Valor = (int)Comunicacao.Buffer_resp[5 + num2] * 256 + (int)Comunicacao.Buffer_resp[6 + num2];
						num++;
					}
					while (num <= 2);
				}
			}
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00248F64 File Offset: 0x00247364
		public static int CMD_Esc_RT821_H800_Parte_1(int endereco, int equipamento)
		{
			int[] array = new int[3];
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 8;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 94;
				Comunicacao.Buffer_cmd[6] = 188;
				Comunicacao.Buffer_cmd[7] = (byte)(RT_geral.RT_821_BD.End_estacao.Valor / 256);
				Comunicacao.Buffer_cmd[8] = (byte)(RT_geral.RT_821_BD.End_estacao.Valor % 256);
				Comunicacao.Buffer_cmd[9] = (byte)(RT_geral.RT_821_BD.End_mestre.Valor / 256);
				Comunicacao.Buffer_cmd[10] = (byte)(RT_geral.RT_821_BD.End_mestre.Valor % 256);
				Comunicacao.Buffer_cmd[11] = (byte)(RT_geral.RT_821_BD.Modelo.Valor / 256);
				Comunicacao.Buffer_cmd[12] = (byte)(RT_geral.RT_821_BD.Modelo.Valor % 256);
				Comunicacao.Buffer_cmd[13] = (byte)(RT_geral.RT_821_BD.modo_repetidora.Valor / 256);
				Comunicacao.Buffer_cmd[14] = (byte)(RT_geral.RT_821_BD.modo_repetidora.Valor % 256);
				Comunicacao.Buffer_cmd[15] = (byte)(RT_geral.RT_821_BD.Tempo_ptt.Valor / 256);
				Comunicacao.Buffer_cmd[16] = (byte)(RT_geral.RT_821_BD.Tempo_ptt.Valor % 256);
				Comunicacao.Buffer_cmd[17] = (byte)(RT_geral.RT_821_BD.AD_Intervalo.Valor / 256);
				Comunicacao.Buffer_cmd[18] = (byte)(RT_geral.RT_821_BD.AD_Intervalo.Valor % 256);
				Comunicacao.Buffer_cmd[19] = (byte)(RT_geral.RT_821_BD.AD_Tamanho_filtro.Valor / 256);
				Comunicacao.Buffer_cmd[20] = (byte)(RT_geral.RT_821_BD.AD_Tamanho_filtro.Valor % 256);
				int num = 20;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.EA_Range[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.EA_Range[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 3);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.EA_Inicio[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.EA_Inicio[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 3);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.EA_Fim[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.EA_Fim[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 3);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.ctrl_acionamento[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.ctrl_acionamento[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 2);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.ctrl_ret_acionamento[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.ctrl_ret_acionamento[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 2);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.ctrl_ED_selecao[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.ctrl_ED_selecao[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 2);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.ctrl_reverso[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.ctrl_reverso[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 2);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.ctrl_modo[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.ctrl_modo[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 2);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.motores_simultaneos[0].Valor / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.motores_simultaneos[0].Valor % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[0].Valor / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[0].Valor % 256);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.ctrl_tempo_max_partida[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.ctrl_tempo_max_partida[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 2);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.ctrl_tempo_max_parada[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.ctrl_tempo_max_parada[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 2);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.config_ED[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.config_ED[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.dsp_escalas[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.dsp_escalas[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.dsp_pto_decimal[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.dsp_pto_decimal[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 7);
				num2 = 0;
				do
				{
					string valor = RT_geral.RT_821_BD.dsp_nome[num2].Valor;
					int num3 = 0;
					Linha_RT.ConverterStringToIntegerArray_II(valor, ref array, ref num3, 3);
					int num4 = 0;
					do
					{
						num++;
						Comunicacao.Buffer_cmd[num] = (byte)(array[num4] / 256);
						num++;
						Comunicacao.Buffer_cmd[num] = (byte)(array[num4] % 256);
						num4++;
					}
					while (num4 <= 2);
					num2++;
				}
				while (num2 <= 7);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.modo_operacao.Valor / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.modo_operacao.Valor % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.intervalo_tx.Valor / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.intervalo_tx.Valor % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.baudrate_com1.Valor / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.baudrate_com1.Valor % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.baudrate_com2.Valor / 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.baudrate_com2.Valor % 256);
				num++;
				int num5 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num5 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num5 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x002498D8 File Offset: 0x00247CD8
		public static int CMD_Esc_RT821_H1000_Parte_1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 16;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 52;
				Comunicacao.Buffer_cmd[6] = 104;
				Comunicacao.Buffer_cmd[7] = (byte)(RT_geral.RT_821_BD.End_repetidora.Valor / 256);
				Comunicacao.Buffer_cmd[8] = (byte)(RT_geral.RT_821_BD.End_repetidora.Valor % 256);
				Comunicacao.Buffer_cmd[9] = (byte)(RT_geral.RT_821_BD.Num_repetidoras.Valor / 256);
				Comunicacao.Buffer_cmd[10] = (byte)(RT_geral.RT_821_BD.Num_repetidoras.Valor % 256);
				int num = 10;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.Repetidoras[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.Repetidoras[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 49);
				num++;
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00249A6C File Offset: 0x00247E6C
		public static int CMD_Esc_RT821_H2000_Parte_1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 32;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 3;
				Comunicacao.Buffer_cmd[6] = 6;
				int num = 6;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.Setpoints_ctrl_variavel[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.Setpoints_ctrl_variavel[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 2);
				num++;
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00249B88 File Offset: 0x00247F88
		public static int CMD_Esc_RT821_H2800_Parte_1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 40;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 6;
				Comunicacao.Buffer_cmd[6] = 12;
				int num = 6;
				int num2 = 0;
				do
				{
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[num2].Valor % 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[num2].Valor / 256);
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)(RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[num2].Valor % 256);
					num2++;
				}
				while (num2 <= 2);
				num++;
				int num3 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num3 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num3 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00249CF4 File Offset: 0x002480F4
		public static int CMD_Esc_RT850_H800(int endereco, int equipamento)
		{
			int[] array = new int[41];
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 8;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 60;
				Comunicacao.Buffer_cmd[6] = 120;
				Comunicacao.Buffer_cmd[7] = (byte)RT_geral.RT_850_BD.End_mestre_canal_1.Valor;
				Comunicacao.Buffer_cmd[8] = (byte)RT_geral.RT_850_BD.End_mestre_canal_2.Valor;
				Comunicacao.Buffer_cmd[9] = (byte)RT_geral.RT_850_BD.Intervalo_leitura_canal_1.Valor;
				Comunicacao.Buffer_cmd[10] = (byte)RT_geral.RT_850_BD.Intervalo_leitura_canal_2.Valor;
				Comunicacao.Buffer_cmd[11] = (byte)(RT_geral.RT_850_BD.BaudRate_canal_1.Valor / 256);
				Comunicacao.Buffer_cmd[12] = (byte)(RT_geral.RT_850_BD.BaudRate_canal_1.Valor % 256);
				Comunicacao.Buffer_cmd[13] = (byte)(RT_geral.RT_850_BD.BaudRate_canal_2.Valor / 256);
				Comunicacao.Buffer_cmd[14] = (byte)(RT_geral.RT_850_BD.BaudRate_canal_2.Valor % 256);
				Comunicacao.Buffer_cmd[15] = (byte)RT_geral.RT_850_BD.Timeout_canal_1.Valor;
				Comunicacao.Buffer_cmd[16] = (byte)RT_geral.RT_850_BD.Timeout_canal_2.Valor;
				Comunicacao.Buffer_cmd[17] = (byte)RT_geral.RT_850_BD.Tempo_ptt_canal_1.Valor;
				Comunicacao.Buffer_cmd[18] = (byte)RT_geral.RT_850_BD.Tempo_ptt_canal_2.Valor;
				Comunicacao.Buffer_cmd[19] = (byte)RT_geral.RT_850_BD.Numero_tentativas_canal_1.Valor;
				Comunicacao.Buffer_cmd[20] = (byte)RT_geral.RT_850_BD.Numero_tentativas_canal_2.Valor;
				Comunicacao.Buffer_cmd[21] = (byte)RT_geral.RT_850_BD.Numero_erros_falha_canal_1.Valor;
				Comunicacao.Buffer_cmd[22] = (byte)RT_geral.RT_850_BD.Numero_erros_falha_canal_2.Valor;
				Comunicacao.Buffer_cmd[23] = (byte)RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor;
				Comunicacao.Buffer_cmd[24] = (byte)RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor;
				Comunicacao.Buffer_cmd[25] = (byte)RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor;
				Comunicacao.Buffer_cmd[26] = (byte)RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor;
				Comunicacao.Buffer_cmd[27] = (byte)RT_geral.RT_850_BD.End_inicial_equip_tipo_1.Valor;
				Comunicacao.Buffer_cmd[28] = (byte)RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Valor;
				Comunicacao.Buffer_cmd[29] = (byte)RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Valor;
				Comunicacao.Buffer_cmd[30] = (byte)RT_geral.RT_850_BD.End_inicial_equip_tipo_vista.Valor;
				Comunicacao.Buffer_cmd[31] = (byte)(RT_geral.RT_850_BD.Sincronismo.Valor / 256);
				Comunicacao.Buffer_cmd[32] = (byte)(RT_geral.RT_850_BD.Sincronismo.Valor % 256);
				string valor = RT_geral.RT_850_BD.Msg_linha_1.Valor;
				int num = 0;
				Linha_RT.ConverterStringToIntegerArray(valor, ref array, ref num, 10);
				string valor2 = RT_geral.RT_850_BD.Msg_linha_2.Valor;
				num = 10;
				Linha_RT.ConverterStringToIntegerArray(valor2, ref array, ref num, 10);
				string valor3 = RT_geral.RT_850_BD.Msg_linha_3.Valor;
				num = 20;
				Linha_RT.ConverterStringToIntegerArray(valor3, ref array, ref num, 10);
				string valor4 = RT_geral.RT_850_BD.Msg_linha_4.Valor;
				num = 30;
				Linha_RT.ConverterStringToIntegerArray(valor4, ref array, ref num, 10);
				int num2 = 0;
				do
				{
					int num3 = num2 * 2;
					Comunicacao.Buffer_cmd[33 + num3] = (byte)(array[num2] / 256);
					Comunicacao.Buffer_cmd[34 + num3] = (byte)(array[num2] % 256);
					num2++;
				}
				while (num2 <= 39);
				Comunicacao.Buffer_cmd[113] = (byte)RT_geral.RT_850_BD.ConfereResposta.Valor;
				Comunicacao.Buffer_cmd[114] = (byte)RT_geral.RT_850_BD.Modo_Estatistica.Valor;
				Comunicacao.Buffer_cmd[115] = (byte)RT_geral.RT_850_BD.Flag_Remota.Valor;
				Comunicacao.Buffer_cmd[116] = (byte)RT_geral.RT_850_BD.Flag_Supervisorio.Valor;
				Comunicacao.Buffer_cmd[117] = (byte)RT_geral.RT_850_BD.LiberaTeclado.Valor;
				Comunicacao.Buffer_cmd[118] = 0;
				Comunicacao.Buffer_cmd[119] = 0;
				Comunicacao.Buffer_cmd[120] = 0;
				Comunicacao.Buffer_cmd[121] = 0;
				Comunicacao.Buffer_cmd[122] = 0;
				Comunicacao.Buffer_cmd[123] = (byte)(RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Valor / 256);
				Comunicacao.Buffer_cmd[124] = (byte)(RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Valor % 256);
				Comunicacao.Buffer_cmd[125] = (byte)(RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Valor / 256);
				Comunicacao.Buffer_cmd[126] = (byte)(RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Valor % 256);
				int num4 = 127;
				int num5 = Comunicacao.Crc16_TX(ref num4);
				Comunicacao.Buffer_cmd[num4] = (byte)(num5 % 256);
				num4++;
				Comunicacao.Buffer_cmd[num4] = (byte)(num5 / 256);
				num4++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num4);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num4;
			}
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x0024A228 File Offset: 0x00248628
		public static int CMD_Esc_RT850_H1000_BLOCOS(int endereco, int bloco)
		{
			int[] array = new int[6];
			checked
			{
				int num = 4096 + bloco * 110;
				Comunicacao.Init_buffer_serial();
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(num / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(num % 256);
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 110;
				Comunicacao.Buffer_cmd[6] = 220;
				int num2 = bloco * 10;
				int num3 = 7;
				int num4 = 0;
				do
				{
					string valor = RT_geral.Variaveis_RT_850[num2 + num4].Nome.Valor;
					int num5 = 0;
					Linha_RT.ConverterStringToIntegerArray(valor, ref array, ref num5, 5);
					int num6 = 0;
					do
					{
						Comunicacao.Buffer_cmd[num3] = (byte)(array[num6] / 256);
						num3++;
						Comunicacao.Buffer_cmd[num3] = (byte)(array[num6] % 256);
						num3++;
						num6++;
					}
					while (num6 <= 4);
					Comunicacao.Buffer_cmd[num3] = (byte)RT_geral.Variaveis_RT_850[num2 + num4].Dsp_tela.Valor;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)RT_geral.Variaveis_RT_850[num2 + num4].Dsp_pos.Indice;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.Variaveis_RT_850[num2 + num4].Escala_ini.Valor / 256);
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.Variaveis_RT_850[num2 + num4].Escala_ini.Valor % 256);
					num3++;
					int num7 = 0;
					switch (RT_geral.Variaveis_RT_850[num2 + num4].Escala_tratamento.Valor)
					{
					case 0:
						num7 = RT_geral.Variaveis_RT_850[num2 + num4].Escala_fim.Valor;
						break;
					case 1:
						num7 = RT_geral.Variaveis_RT_850[num2 + num4].Escala_fim.Valor + 10000;
						break;
					default:
						num7 = 0;
						break;
					}
					int num8 = (RT_geral.Variaveis_RT_850[num2 + num4].Pto_dec_fim.Indice * 64 & 192) + (num7 / 256 & 63);
					Comunicacao.Buffer_cmd[num3] = (byte)num8;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)(num7 % 256);
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.Variaveis_RT_850[num2 + num4].Nivel_alm_1.Valor / 256);
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.Variaveis_RT_850[num2 + num4].Nivel_alm_1.Valor % 256);
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.Variaveis_RT_850[num2 + num4].Nivel_alm_2.Valor / 256);
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.Variaveis_RT_850[num2 + num4].Nivel_alm_2.Valor % 256);
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.Variaveis_RT_850[num2 + num4].Tipo_alm_1.Indice * 128 + RT_geral.Variaveis_RT_850[num2 + num4].Msg_alm_1.Valor);
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.Variaveis_RT_850[num2 + num4].Tipo_alm_2.Indice * 128 + RT_geral.Variaveis_RT_850[num2 + num4].Msg_alm_2.Valor);
					num3++;
					num4++;
				}
				while (num4 <= 9);
				int num9 = Comunicacao.Crc16_TX(ref num3);
				Comunicacao.Buffer_cmd[num3] = (byte)(num9 % 256);
				num3++;
				Comunicacao.Buffer_cmd[num3] = (byte)(num9 / 256);
				num3++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num3);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num3;
			}
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0024A648 File Offset: 0x00248A48
		public static int CMD_Esc_RT850_H1800_BLOCOS(int endereco, int bloco)
		{
			int[] array = new int[6];
			checked
			{
				int num = 6144 + bloco * 110;
				Comunicacao.Init_buffer_serial();
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(num / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(num % 256);
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 110;
				Comunicacao.Buffer_cmd[6] = 220;
				int num2 = 150 + bloco * 10;
				int num3 = 7;
				int num4 = 0;
				do
				{
					string valor = RT_geral.Variaveis_RT_850[num2 + num4].Nome.Valor;
					int num5 = 0;
					Linha_RT.ConverterStringToIntegerArray(valor, ref array, ref num5, 5);
					int num6 = 0;
					do
					{
						Comunicacao.Buffer_cmd[num3] = (byte)(array[num6] / 256);
						num3++;
						Comunicacao.Buffer_cmd[num3] = (byte)(array[num6] % 256);
						num3++;
						num6++;
					}
					while (num6 <= 4);
					Comunicacao.Buffer_cmd[num3] = (byte)RT_geral.Variaveis_RT_850[num2 + num4].Dsp_tela.Valor;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)RT_geral.Variaveis_RT_850[num2 + num4].Dsp_pos.Indice;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.Variaveis_RT_850[num2 + num4].Escala_ini.Valor / 256);
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.Variaveis_RT_850[num2 + num4].Escala_ini.Valor % 256);
					num3++;
					int num7 = (RT_geral.Variaveis_RT_850[num2 + num4].Pto_dec_fim.Indice * 64 & 192) + (RT_geral.Variaveis_RT_850[num2 + num4].Escala_fim.Valor / 256 & 63);
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.Variaveis_RT_850[num2 + num4].Escala_fim.Valor % 256);
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.Variaveis_RT_850[num2 + num4].Nivel_alm_1.Valor / 256);
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.Variaveis_RT_850[num2 + num4].Nivel_alm_1.Valor % 256);
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.Variaveis_RT_850[num2 + num4].Nivel_alm_2.Valor / 256);
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.Variaveis_RT_850[num2 + num4].Nivel_alm_2.Valor % 256);
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)((RT_geral.Variaveis_RT_850[num2 + num4].Tipo_alm_1.Indice * 128 & 128) + RT_geral.Variaveis_RT_850[num2 + num4].Msg_alm_1.Valor);
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)((RT_geral.Variaveis_RT_850[num2 + num4].Tipo_alm_2.Indice * 128 & 128) + RT_geral.Variaveis_RT_850[num2 + num4].Msg_alm_2.Valor);
					num3++;
					num4++;
				}
				while (num4 <= 9);
				int num8 = Comunicacao.Crc16_TX(ref num3);
				Comunicacao.Buffer_cmd[num3] = (byte)(num8 % 256);
				num3++;
				Comunicacao.Buffer_cmd[num3] = (byte)(num8 / 256);
				num3++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num3);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num3;
			}
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x0024AA3C File Offset: 0x00248E3C
		public static int CMD_Esc_RT850_H5800_BLOCOS(int endereco, int bloco)
		{
			int[] array = new int[6];
			checked
			{
				int num = 22528 + bloco * 120;
				Comunicacao.Init_buffer_serial();
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(num / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(num % 256);
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 120;
				Comunicacao.Buffer_cmd[6] = 240;
				int num2 = 0 + bloco * 8;
				int num3 = 7;
				int num4 = 0;
				do
				{
					string valor = RT_geral.RT_850_Ctrl_1[num2 + num4].Nome.Valor;
					int num5 = 0;
					Linha_RT.ConverterStringToIntegerArray(valor, ref array, ref num5, 5);
					int num6 = 0;
					do
					{
						Comunicacao.Buffer_cmd[num3] = (byte)(array[num6] / 256);
						num3++;
						Comunicacao.Buffer_cmd[num3] = (byte)(array[num6] % 256);
						num3++;
						num6++;
					}
					while (num6 <= 4);
					int num7 = RT_geral.RT_850_Ctrl_1[num2 + num4].Canal.Indice * 64 & 192;
					num7 += (RT_geral.RT_850_Ctrl_1[num2 + num4].Timeout.Indice * 8 & 56);
					num7 += (RT_geral.RT_850_Ctrl_1[num2 + num4].Prioridade.Indice & 7);
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					num7 = (RT_geral.RT_850_Ctrl_1[num2 + num4].Comando.Indice * 64 & 192);
					num7 += (RT_geral.RT_850_Ctrl_1[num2 + num4].Modelo.Indice & 63);
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					num6 = 0;
					do
					{
						Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.RT_850_Ctrl_1[num2 + num4].Var[num6].Indice / 256);
						num3++;
						Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.RT_850_Ctrl_1[num2 + num4].Var[num6].Indice % 256);
						num3++;
						num6++;
					}
					while (num6 <= 3);
					num6 = 0;
					do
					{
						Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.RT_850_Ctrl_1[num2 + num4].Ref[num6].Indice / 256);
						num3++;
						Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.RT_850_Ctrl_1[num2 + num4].Ref[num6].Indice % 256);
						num3++;
						num6++;
					}
					while (num6 <= 3);
					num6 = 0;
					do
					{
						Comunicacao.Buffer_cmd[num3] = (byte)RT_geral.RT_850_Ctrl_1[num2 + num4].Crtl_nome[num6].Indice;
						num3++;
						Comunicacao.Buffer_cmd[num3] = (byte)RT_geral.RT_850_Ctrl_1[num2 + num4].Crtl_indice[num6].Valor;
						num3++;
						num6++;
					}
					while (num6 <= 0);
					num4++;
				}
				while (num4 <= 7);
				int num8 = Comunicacao.Crc16_TX(ref num3);
				Comunicacao.Buffer_cmd[num3] = (byte)(num8 % 256);
				num3++;
				Comunicacao.Buffer_cmd[num3] = (byte)(num8 / 256);
				num3++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num3);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num3;
			}
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0024ADB4 File Offset: 0x002491B4
		public static int CMD_Esc_RT850_H3000_Parte_1(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 48;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 100;
				Comunicacao.Buffer_cmd[6] = 200;
				int num = 7;
				int num2 = 0;
				do
				{
					string text = RT_geral.RT_850_MSG_ALARME_CONFIG[num2];
					int length = text.Length;
					int num3 = 0;
					int num4 = length - 1;
					for (int i = num3; i <= num4; i++)
					{
						string text2 = text.Substring(i, 1);
						Comunicacao.Buffer_cmd[num] = (byte)Strings.Asc(text2);
						num++;
					}
					for (int i = length; i <= 19; i++)
					{
						Comunicacao.Buffer_cmd[num] = 32;
						num++;
					}
					num2++;
				}
				while (num2 <= 9);
				int num5 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num5 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num5 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x0024AEF0 File Offset: 0x002492F0
		public static int CMD_Esc_RT850_H3000_Parte_2(int endereco, int equipamento)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 48;
				Comunicacao.Buffer_cmd[3] = 100;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 100;
				Comunicacao.Buffer_cmd[6] = 200;
				int num = 7;
				int num2 = 10;
				do
				{
					string text = RT_geral.RT_850_MSG_ALARME_CONFIG[num2];
					int length = text.Length;
					int num3 = 0;
					int num4 = length - 1;
					for (int i = num3; i <= num4; i++)
					{
						string text2 = text.Substring(i, 1);
						Comunicacao.Buffer_cmd[num] = (byte)Strings.Asc(text2);
						num++;
					}
					for (int i = length; i <= 19; i++)
					{
						Comunicacao.Buffer_cmd[num] = 32;
						num++;
					}
					num2++;
				}
				while (num2 <= 19);
				int num5 = Comunicacao.Crc16_TX(ref num);
				Comunicacao.Buffer_cmd[num] = (byte)(num5 % 256);
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)(num5 / 256);
				num++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num;
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0024B030 File Offset: 0x00249430
		public static int CMD_Esc_RT850_H6000_BLOCOS(int endereco, int bloco)
		{
			int[] array = new int[6];
			checked
			{
				int num = 24576 + bloco * 115;
				Comunicacao.Init_buffer_serial();
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(num / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(num % 256);
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 115;
				Comunicacao.Buffer_cmd[6] = 230;
				int num2 = 0 + bloco * 5;
				int num3 = 7;
				int num4 = 0;
				do
				{
					string valor = RT_geral.RT_850_Ctrl_4[num2 + num4].Nome.Valor;
					int num5 = 0;
					Linha_RT.ConverterStringToIntegerArray(valor, ref array, ref num5, 5);
					int num6 = 0;
					do
					{
						Comunicacao.Buffer_cmd[num3] = (byte)(array[num6] / 256);
						num3++;
						Comunicacao.Buffer_cmd[num3] = (byte)(array[num6] % 256);
						num3++;
						num6++;
					}
					while (num6 <= 4);
					int num7 = RT_geral.RT_850_Ctrl_4[num2 + num4].Canal.Indice * 64 & 192;
					num7 += (RT_geral.RT_850_Ctrl_4[num2 + num4].Timeout.Indice * 8 & 56);
					num7 += (RT_geral.RT_850_Ctrl_4[num2 + num4].Prioridade.Indice & 7);
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					num7 = (RT_geral.RT_850_Ctrl_4[num2 + num4].Comando.Indice * 64 & 192);
					num7 += (RT_geral.RT_850_Ctrl_4[num2 + num4].Modelo.Indice & 63);
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					num6 = 0;
					do
					{
						Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.RT_850_Ctrl_4[num2 + num4].Var[num6].Indice / 256);
						num3++;
						Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.RT_850_Ctrl_4[num2 + num4].Var[num6].Indice % 256);
						num3++;
						num6++;
					}
					while (num6 <= 3);
					num6 = 0;
					do
					{
						Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.RT_850_Ctrl_4[num2 + num4].Ref[num6].Indice / 256);
						num3++;
						Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.RT_850_Ctrl_4[num2 + num4].Ref[num6].Indice % 256);
						num3++;
						num6++;
					}
					while (num6 <= 3);
					num6 = 0;
					do
					{
						Comunicacao.Buffer_cmd[num3] = (byte)RT_geral.RT_850_Ctrl_4[num2 + num4].Periferico_Indice[num6].Indice;
						num3++;
						Comunicacao.Buffer_cmd[num3] = (byte)RT_geral.RT_850_Ctrl_4[num2 + num4].Periferico_Modelo[num6].Indice;
						num3++;
						num6++;
					}
					while (num6 <= 4);
					num6 = 0;
					do
					{
						Comunicacao.Buffer_cmd[num3] = (byte)RT_geral.RT_850_Ctrl_4[num2 + num4].Crtl_nome[num6].Indice;
						num3++;
						Comunicacao.Buffer_cmd[num3] = (byte)RT_geral.RT_850_Ctrl_4[num2 + num4].Crtl_indice[num6].Valor;
						num3++;
						num6++;
					}
					while (num6 <= 3);
					num4++;
				}
				while (num4 <= 4);
				int num8 = Comunicacao.Crc16_TX(ref num3);
				Comunicacao.Buffer_cmd[num3] = (byte)(num8 % 256);
				num3++;
				Comunicacao.Buffer_cmd[num3] = (byte)(num8 / 256);
				num3++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num3);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num3;
			}
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x0024B410 File Offset: 0x00249810
		public static int CMD_Esc_RT850_H6800_BLOCOS(int endereco, int bloco)
		{
			int[] array = new int[6];
			checked
			{
				int num = 26624 + bloco * 78;
				Comunicacao.Init_buffer_serial();
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(num / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(num % 256);
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 78;
				Comunicacao.Buffer_cmd[6] = 156;
				int num2 = 0 + bloco * 2;
				int num3 = 7;
				int num4 = 0;
				do
				{
					string valor = RT_geral.RT_850_Ctrl_8[num2 + num4].Nome.Valor;
					int num5 = 0;
					Linha_RT.ConverterStringToIntegerArray(valor, ref array, ref num5, 5);
					int num6 = 0;
					do
					{
						Comunicacao.Buffer_cmd[num3] = (byte)(array[num6] / 256);
						num3++;
						Comunicacao.Buffer_cmd[num3] = (byte)(array[num6] % 256);
						num3++;
						num6++;
					}
					while (num6 <= 4);
					int num7 = RT_geral.RT_850_Ctrl_8[num2 + num4].Canal.Indice * 64 & 192;
					num7 += (RT_geral.RT_850_Ctrl_8[num2 + num4].Timeout.Indice * 8 & 56);
					num7 += (RT_geral.RT_850_Ctrl_8[num2 + num4].Prioridade.Indice & 7);
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					num7 = (RT_geral.RT_850_Ctrl_8[num2 + num4].Comando.Indice * 64 & 192);
					num7 += (RT_geral.RT_850_Ctrl_8[num2 + num4].Modelo.Indice & 63);
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					num6 = 0;
					do
					{
						Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.RT_850_Ctrl_8[num2 + num4].Var[num6].Indice / 256);
						num3++;
						Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.RT_850_Ctrl_8[num2 + num4].Var[num6].Indice % 256);
						num3++;
						num6++;
					}
					while (num6 <= 15);
					num6 = 0;
					do
					{
						Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.RT_850_Ctrl_8[num2 + num4].Ref[num6].Indice / 256);
						num3++;
						Comunicacao.Buffer_cmd[num3] = (byte)(RT_geral.RT_850_Ctrl_8[num2 + num4].Ref[num6].Indice % 256);
						num3++;
						num6++;
					}
					while (num6 <= 3);
					num6 = 0;
					do
					{
						Comunicacao.Buffer_cmd[num3] = (byte)RT_geral.RT_850_Ctrl_8[num2 + num4].Periferico_Indice[num6].Indice;
						num3++;
						Comunicacao.Buffer_cmd[num3] = (byte)RT_geral.RT_850_Ctrl_8[num2 + num4].Periferico_Modelo[num6].Indice;
						num3++;
						num6++;
					}
					while (num6 <= 4);
					num6 = 0;
					do
					{
						Comunicacao.Buffer_cmd[num3] = (byte)RT_geral.RT_850_Ctrl_8[num2 + num4].Crtl_nome[num6].Indice;
						num3++;
						Comunicacao.Buffer_cmd[num3] = (byte)RT_geral.RT_850_Ctrl_8[num2 + num4].Crtl_indice[num6].Valor;
						num3++;
						num6++;
					}
					while (num6 <= 7);
					num4++;
				}
				while (num4 <= 1);
				int num8 = Comunicacao.Crc16_TX(ref num3);
				Comunicacao.Buffer_cmd[num3] = (byte)(num8 % 256);
				num3++;
				Comunicacao.Buffer_cmd[num3] = (byte)(num8 / 256);
				num3++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num3);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num3;
			}
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0024B7F0 File Offset: 0x00249BF0
		public static int CMD_Esc_RT850_H7000_BLOCOS(int endereco, int bloco)
		{
			int[] array = new int[6];
			checked
			{
				int num = 28672 + bloco * 57;
				Comunicacao.Init_buffer_serial();
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(num / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(num % 256);
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 57;
				Comunicacao.Buffer_cmd[6] = 114;
				int num2 = 7;
				string valor = RT_geral.RT_850_Vista[bloco + 1].Nome.Valor;
				int num3 = 0;
				Linha_RT.ConverterStringToIntegerArray(valor, ref array, ref num3, 5);
				int num4 = 0;
				do
				{
					Comunicacao.Buffer_cmd[num2] = (byte)(array[num4] / 256);
					num2++;
					Comunicacao.Buffer_cmd[num2] = (byte)(array[num4] % 256);
					num2++;
					num4++;
				}
				while (num4 <= 4);
				int num5 = RT_geral.RT_850_Vista[bloco + 1].Canal.Indice * 64 & 192;
				num5 += (RT_geral.RT_850_Vista[bloco + 1].Timeout.Indice * 8 & 56);
				num5 += (RT_geral.RT_850_Vista[bloco + 1].Prioridade.Indice & 7);
				Comunicacao.Buffer_cmd[num2] = (byte)num5;
				num2++;
				Comunicacao.Buffer_cmd[num2] = (byte)(RT_geral.RT_850_Vista[bloco + 1].Modelo.Indice & 255);
				num2++;
				Comunicacao.Buffer_cmd[num2] = (byte)(RT_geral.RT_850_Vista[bloco + 1].Num_var.Valor & 255);
				num2++;
				Comunicacao.Buffer_cmd[num2] = (byte)(RT_geral.RT_850_Vista[bloco + 1].Num_equip.Valor & 255);
				num2++;
				num4 = 0;
				do
				{
					Comunicacao.Buffer_cmd[num2] = (byte)(RT_geral.RT_850_Vista[bloco + 1].Variaveis[num4].Indice / 256);
					num2++;
					Comunicacao.Buffer_cmd[num2] = (byte)(RT_geral.RT_850_Vista[bloco + 1].Variaveis[num4].Indice % 256);
					num2++;
					num4++;
				}
				while (num4 <= 39);
				num4 = 0;
				do
				{
					Comunicacao.Buffer_cmd[num2] = (byte)(RT_geral.RT_850_Vista[bloco + 1].Equipamentos[num4].Indice & 255);
					num2++;
					num4++;
				}
				while (num4 <= 19);
				int num6 = Comunicacao.Crc16_TX(ref num2);
				Comunicacao.Buffer_cmd[num2] = (byte)(num6 % 256);
				num2++;
				Comunicacao.Buffer_cmd[num2] = (byte)(num6 / 256);
				num2++;
				if (Comunicacao.Config_sistema.tipo_interface == 1)
				{
					MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num2);
				}
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
				return num2;
			}
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0024BAD8 File Offset: 0x00249ED8
		public static void Atualiza_dados_RT830_200(int pagina, int num_bloco)
		{
			checked
			{
				if (pagina == 0)
				{
					RT_830_200_variaveis_X.RT_830_200_BD.firmware.Equip.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_830_200_variaveis_X.RT_830_200_BD.firmware.Versao.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_830_200_variaveis_X.RT_830_200_BD.firmware.Build.Valor = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					RT_830_200_variaveis_X.RT_830_200_BD.firmware.Release.Valor = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
				}
				else if (pagina == 256)
				{
					RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.retrys.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.timeout.Valor = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.PTT.Valor = ((int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10]) * 10;
					RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.Valor = (int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12];
					RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.AtualizaIndicePeloValor();
					RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.erros_falha.Valor = (int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14];
					RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.intervalo_polling.Valor = (int)Comunicacao.Buffer_resp[15] * 256 + (int)Comunicacao.Buffer_resp[16];
					RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_reservatorios.Valor = (int)Comunicacao.Buffer_resp[17] * 256 + (int)Comunicacao.Buffer_resp[18];
					RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios.Valor = (int)Comunicacao.Buffer_resp[19] * 256 + (int)Comunicacao.Buffer_resp[20];
					RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques.Valor = (int)Comunicacao.Buffer_resp[21] * 256 + (int)Comunicacao.Buffer_resp[22];
					RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor = (int)Comunicacao.Buffer_resp[23] * 256 + (int)Comunicacao.Buffer_resp[24];
					RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_reservatorio.Valor = (int)Comunicacao.Buffer_resp[25] * 256 + (int)Comunicacao.Buffer_resp[26];
					RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_recalque.Valor = (int)Comunicacao.Buffer_resp[27] * 256 + (int)Comunicacao.Buffer_resp[28];
					RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista.Valor = (int)Comunicacao.Buffer_resp[29] * 256 + (int)Comunicacao.Buffer_resp[30];
				}
				else if (pagina == 512)
				{
					int num = 0;
					do
					{
						int num2 = num * 8;
						RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].NumeroVariavel.Valor = (int)Comunicacao.Buffer_resp[3 + num2] * 256 + (int)Comunicacao.Buffer_resp[4 + num2];
						RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Prioridade.Valor = (int)Comunicacao.Buffer_resp[5 + num2] * 256 + (int)Comunicacao.Buffer_resp[6 + num2];
						RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Altura.Valor = (int)Comunicacao.Buffer_resp[7 + num2] * 256 + (int)Comunicacao.Buffer_resp[8 + num2];
						RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Nome.Valor = (int)Comunicacao.Buffer_resp[9 + num2] * 256 + (int)Comunicacao.Buffer_resp[10 + num2];
						num++;
					}
					while (num <= 24);
				}
				else if (pagina == 612)
				{
					int num = 25;
					do
					{
						int num2 = num * 8;
						int num3 = (num - 25) * 8;
						RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].NumeroVariavel.Valor = (int)Comunicacao.Buffer_resp[3 + num3] * 256 + (int)Comunicacao.Buffer_resp[4 + num3];
						RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Prioridade.Valor = (int)Comunicacao.Buffer_resp[5 + num3] * 256 + (int)Comunicacao.Buffer_resp[6 + num3];
						RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Altura.Valor = (int)Comunicacao.Buffer_resp[7 + num3] * 256 + (int)Comunicacao.Buffer_resp[8 + num3];
						RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Nome.Valor = (int)Comunicacao.Buffer_resp[9 + num3] * 256 + (int)Comunicacao.Buffer_resp[10 + num3];
						num++;
					}
					while (num <= 49);
				}
				else if (pagina == 768 || pagina == 1024 || pagina == 1280 || pagina == 1536)
				{
					int num4 = pagina / 256 - 3;
					int num5 = num4 * 7;
					int num6 = 0;
					if (num_bloco == 0)
					{
						num6 = 240;
					}
					else if (num_bloco == 1)
					{
						num6 = 180;
						num5 += 4;
					}
					int num7 = 0;
					int num8 = num6 - 1;
					for (int i = num7; i <= num8; i += 60)
					{
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].origem.Valor = (int)Comunicacao.Buffer_resp[i + 3] * 256 + (int)Comunicacao.Buffer_resp[i + 4];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].destino.Valor = (int)Comunicacao.Buffer_resp[i + 5] * 256 + (int)Comunicacao.Buffer_resp[i + 6];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Var1.Valor = (int)Comunicacao.Buffer_resp[i + 7] * 256 + (int)Comunicacao.Buffer_resp[i + 8];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Var2.Valor = (int)Comunicacao.Buffer_resp[i + 9] * 256 + (int)Comunicacao.Buffer_resp[i + 10];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Var3.Valor = (int)Comunicacao.Buffer_resp[i + 11] * 256 + (int)Comunicacao.Buffer_resp[i + 12];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Var4.Valor = (int)Comunicacao.Buffer_resp[i + 13] * 256 + (int)Comunicacao.Buffer_resp[i + 14];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Nome_Var1.Valor = (int)Comunicacao.Buffer_resp[i + 15] * 256 + (int)Comunicacao.Buffer_resp[i + 16];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Nome_Var2.Valor = (int)Comunicacao.Buffer_resp[i + 17] * 256 + (int)Comunicacao.Buffer_resp[i + 18];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Nome_Var3.Valor = (int)Comunicacao.Buffer_resp[i + 19] * 256 + (int)Comunicacao.Buffer_resp[i + 20];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Nome_Var4.Valor = (int)Comunicacao.Buffer_resp[i + 21] * 256 + (int)Comunicacao.Buffer_resp[i + 22];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Modelo.Valor = (int)Comunicacao.Buffer_resp[i + 23] * 256 + (int)Comunicacao.Buffer_resp[i + 24];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Prioridade.Valor = (int)Comunicacao.Buffer_resp[i + 25] * 256 + (int)Comunicacao.Buffer_resp[i + 26];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Nome.Valor = (int)Comunicacao.Buffer_resp[i + 27] * 256 + (int)Comunicacao.Buffer_resp[i + 28];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Habilita.Valor = (int)Comunicacao.Buffer_resp[i + 29] * 256 + (int)Comunicacao.Buffer_resp[i + 30];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Escala1.Valor = (int)Comunicacao.Buffer_resp[i + 31] * 256 + (int)Comunicacao.Buffer_resp[i + 32];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Escala2.Valor = (int)Comunicacao.Buffer_resp[i + 33] * 256 + (int)Comunicacao.Buffer_resp[i + 34];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Escala3.Valor = (int)Comunicacao.Buffer_resp[i + 35] * 256 + (int)Comunicacao.Buffer_resp[i + 36];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Escala4.Valor = (int)Comunicacao.Buffer_resp[i + 37] * 256 + (int)Comunicacao.Buffer_resp[i + 38];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Escala5.Valor = (int)Comunicacao.Buffer_resp[i + 39] * 256 + (int)Comunicacao.Buffer_resp[i + 40];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Escala6.Valor = (int)Comunicacao.Buffer_resp[i + 41] * 256 + (int)Comunicacao.Buffer_resp[i + 42];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Escala7.Valor = (int)Comunicacao.Buffer_resp[i + 43] * 256 + (int)Comunicacao.Buffer_resp[i + 44];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Escala8.Valor = (int)Comunicacao.Buffer_resp[i + 45] * 256 + (int)Comunicacao.Buffer_resp[i + 46];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Escala9.Valor = (int)Comunicacao.Buffer_resp[i + 47] * 256 + (int)Comunicacao.Buffer_resp[i + 48];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Escala10.Valor = (int)Comunicacao.Buffer_resp[i + 49] * 256 + (int)Comunicacao.Buffer_resp[i + 50];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Escala11.Valor = (int)Comunicacao.Buffer_resp[i + 51] * 256 + (int)Comunicacao.Buffer_resp[i + 52];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Escala12.Valor = (int)Comunicacao.Buffer_resp[i + 53] * 256 + (int)Comunicacao.Buffer_resp[i + 54];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Escala13.Valor = (int)Comunicacao.Buffer_resp[i + 55] * 256 + (int)Comunicacao.Buffer_resp[i + 56];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Escala14.Valor = (int)Comunicacao.Buffer_resp[i + 57] * 256 + (int)Comunicacao.Buffer_resp[i + 58];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Escala15.Valor = (int)Comunicacao.Buffer_resp[i + 59] * 256 + (int)Comunicacao.Buffer_resp[i + 60];
						RT_830_200_variaveis_X.RT_830_200_BD.recalque[num5].Escala16.Valor = (int)Comunicacao.Buffer_resp[i + 61] * 256 + (int)Comunicacao.Buffer_resp[i + 62];
						num5++;
					}
				}
				else if (pagina == 1792)
				{
					int num5 = 0;
					int num6 = 0;
					switch (num_bloco)
					{
					case 0:
						num6 = 172;
						num5 = 0;
						break;
					case 1:
						num6 = 172;
						num5 = 2;
						break;
					case 2:
						num6 = 86;
						num5 = 4;
						break;
					}
					int num9 = 0;
					int num10 = num6 - 1;
					for (int i = num9; i <= num10; i += 86)
					{
						RT_830_200_variaveis_X.RT_830_200_BD.vista[num5].Numero_Variaveis.Valor = (int)Comunicacao.Buffer_resp[i + 3] * 256 + (int)Comunicacao.Buffer_resp[i + 4];
						RT_830_200_variaveis_X.RT_830_200_BD.vista[num5].Numero_RemotasControles.Valor = (int)Comunicacao.Buffer_resp[i + 5] * 256 + (int)Comunicacao.Buffer_resp[i + 6];
						RT_830_200_variaveis_X.RT_830_200_BD.vista[num5].Prioridade.Valor = (int)Comunicacao.Buffer_resp[i + 7] * 256 + (int)Comunicacao.Buffer_resp[i + 8];
						int num11 = i + 9;
						int num12 = 0;
						int num13 = RT_830_200_variaveis_X.RT_830_200_BD.vista[num5].Numero_Variaveis.Valor - 1;
						for (int j = num12; j <= num13; j++)
						{
							int valor = (int)Comunicacao.Buffer_resp[num11] * 256 + (int)Comunicacao.Buffer_resp[num11 + 1];
							num11 += 2;
							RT_830_200_variaveis_X.RT_830_200_BD.vista[num5].Variaveis[j].Valor = valor;
						}
						int num14 = 0;
						int num15 = RT_830_200_variaveis_X.RT_830_200_BD.vista[num5].Numero_RemotasControles.Valor - 1;
						for (int k = num14; k <= num15; k++)
						{
							int valor = (int)Comunicacao.Buffer_resp[num11] * 256 + (int)Comunicacao.Buffer_resp[num11 + 1];
							num11 += 2;
							RT_830_200_variaveis_X.RT_830_200_BD.vista[num5].RemotasControles[k].Valor = valor;
						}
						num5++;
					}
				}
			}
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0024C918 File Offset: 0x0024AD18
		public static void Atualiza_dados_RT831_200(int pagina, int num_bloco)
		{
			checked
			{
				if (pagina == 0)
				{
					RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_831_200_variaveis_X.RT_831_200_BD.firmware.Versao.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_831_200_variaveis_X.RT_831_200_BD.firmware.Build.Valor = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					RT_831_200_variaveis_X.RT_831_200_BD.firmware.Release.Valor = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
				}
				else if (pagina == 256)
				{
					RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT.Valor = ((int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8]) * 10;
					RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.Valor = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
					RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.AtualizaIndicePeloValor();
					RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor = (int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12];
					RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor = (int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14];
				}
				else if (pagina == 512)
				{
					int num = 0;
					int num2 = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor - 1;
					for (int i = Convert.ToInt32(num); i <= num2; i++)
					{
						int num3 = i * 2;
						RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[i].Nome.Valor = (int)Comunicacao.Buffer_resp[3 + num3] * 256 + (int)Comunicacao.Buffer_resp[4 + num3];
					}
				}
				else if (pagina == 768 || pagina == 844 || pagina == 1024 || pagina == 1100 || pagina == 1280 || pagina == 1356 || pagina == 1536 || pagina == 1612)
				{
					int num4 = pagina / 256 - 3;
					int num5 = num4 * 7;
					int num6 = 0;
					if (num_bloco == 0)
					{
						int j = 0;
						num6 = 152;
					}
					else if (num_bloco == 1)
					{
						int j = 0;
						num6 = 114;
						num5 += 4;
					}
					int num7 = 0;
					int num8 = num6 - 1;
					for (int j = num7; j <= num8; j += 38)
					{
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Modelo.Valor = (int)Comunicacao.Buffer_resp[j + 3] * 256 + (int)Comunicacao.Buffer_resp[j + 4];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Modelo.AtualizaIndicePeloValor();
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Nome.Valor = (int)Comunicacao.Buffer_resp[j + 5] * 256 + (int)Comunicacao.Buffer_resp[j + 6];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Habilita.Valor = (int)Comunicacao.Buffer_resp[j + 7] * 256 + (int)Comunicacao.Buffer_resp[j + 8];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Habilita.AtualizaIndicePeloValor();
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Escala1.Valor = (int)Comunicacao.Buffer_resp[j + 9] * 256 + (int)Comunicacao.Buffer_resp[j + 10];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Escala2.Valor = (int)Comunicacao.Buffer_resp[j + 11] * 256 + (int)Comunicacao.Buffer_resp[j + 12];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Escala3.Valor = (int)Comunicacao.Buffer_resp[j + 13] * 256 + (int)Comunicacao.Buffer_resp[j + 14];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Escala4.Valor = (int)Comunicacao.Buffer_resp[j + 15] * 256 + (int)Comunicacao.Buffer_resp[j + 16];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Escala5.Valor = (int)Comunicacao.Buffer_resp[j + 17] * 256 + (int)Comunicacao.Buffer_resp[j + 18];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Escala6.Valor = (int)Comunicacao.Buffer_resp[j + 19] * 256 + (int)Comunicacao.Buffer_resp[j + 20];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Escala7.Valor = (int)Comunicacao.Buffer_resp[j + 21] * 256 + (int)Comunicacao.Buffer_resp[j + 22];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Escala8.Valor = (int)Comunicacao.Buffer_resp[j + 23] * 256 + (int)Comunicacao.Buffer_resp[j + 24];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Escala9.Valor = (int)Comunicacao.Buffer_resp[j + 25] * 256 + (int)Comunicacao.Buffer_resp[j + 26];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Escala10.Valor = (int)Comunicacao.Buffer_resp[j + 27] * 256 + (int)Comunicacao.Buffer_resp[j + 28];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Escala11.Valor = (int)Comunicacao.Buffer_resp[j + 29] * 256 + (int)Comunicacao.Buffer_resp[j + 30];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Escala12.Valor = (int)Comunicacao.Buffer_resp[j + 31] * 256 + (int)Comunicacao.Buffer_resp[j + 32];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Escala13.Valor = (int)Comunicacao.Buffer_resp[j + 33] * 256 + (int)Comunicacao.Buffer_resp[j + 34];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Escala14.Valor = (int)Comunicacao.Buffer_resp[j + 35] * 256 + (int)Comunicacao.Buffer_resp[j + 36];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Escala15.Valor = (int)Comunicacao.Buffer_resp[j + 37] * 256 + (int)Comunicacao.Buffer_resp[j + 38];
						RT_831_200_variaveis_X.RT_831_200_BD.recalque[num5].Escala16.Valor = (int)Comunicacao.Buffer_resp[j + 39] * 256 + (int)Comunicacao.Buffer_resp[j + 40];
						num5++;
					}
				}
				else if (pagina == 2304)
				{
					int j;
					RT_831_200_variaveis_X.RT_831_200_BD.senha.senha.Valor = (int)Comunicacao.Buffer_resp[j + 3] * 256 + (int)Comunicacao.Buffer_resp[j + 4];
				}
			}
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0024D098 File Offset: 0x0024B498
		public static void CMD_Esc_RT_830_200_CFG_GERAIS(int endereco)
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
				int valor = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor;
				int num = 0;
				byte b = (byte)num;
				int num2 = 0;
				byte b2 = (byte)num2;
				Linha_RT.Split16(valor, ref b, ref b2);
				num2 = (int)b2;
				num = (int)b;
				Comunicacao.Buffer_cmd[7] = (byte)num;
				Comunicacao.Buffer_cmd[8] = (byte)num2;
				int valor2 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.retrys.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor2, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[9] = (byte)num;
				Comunicacao.Buffer_cmd[10] = (byte)num2;
				int valor3 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.timeout.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor3, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[11] = (byte)num;
				Comunicacao.Buffer_cmd[12] = (byte)num2;
				int valor4 = (int)Math.Round((double)RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.PTT.Valor / 10.0);
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor4, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[13] = (byte)num;
				Comunicacao.Buffer_cmd[14] = (byte)num2;
				int valor5 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor5, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[15] = (byte)num;
				Comunicacao.Buffer_cmd[16] = (byte)num2;
				int valor6 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.erros_falha.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor6, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[17] = (byte)num;
				Comunicacao.Buffer_cmd[18] = (byte)num2;
				int valor7 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.intervalo_polling.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor7, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[19] = (byte)num;
				Comunicacao.Buffer_cmd[20] = (byte)num2;
				int valor8 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_reservatorios.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor8, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[21] = (byte)num;
				Comunicacao.Buffer_cmd[22] = (byte)num2;
				int valor9 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor9, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[23] = (byte)num;
				Comunicacao.Buffer_cmd[24] = (byte)num2;
				int valor10 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor10, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[25] = (byte)num;
				Comunicacao.Buffer_cmd[26] = (byte)num2;
				int valor11 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor11, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[27] = (byte)num;
				Comunicacao.Buffer_cmd[28] = (byte)num2;
				int valor12 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_reservatorio.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor12, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[29] = (byte)num;
				Comunicacao.Buffer_cmd[30] = (byte)num2;
				int valor13 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_recalque.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor13, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[31] = (byte)num;
				Comunicacao.Buffer_cmd[32] = (byte)num2;
				int valor14 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor14, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[33] = (byte)num;
				Comunicacao.Buffer_cmd[34] = (byte)num2;
				int num3 = 34;
				int num4 = num3 + 1;
				int num5 = Comunicacao.Crc16_TX(ref num4);
				Comunicacao.Buffer_cmd[num3 + 1] = (byte)(num5 % 256);
				Comunicacao.Buffer_cmd[num3 + 2] = (byte)(num5 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num3 + 3);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0024D4CC File Offset: 0x0024B8CC
		public static void CMD_Esc_RT_830_200_RESERVATORIO(int pagina, int endereco)
		{
			int num = 25;
			checked
			{
				int num2 = 4 * num;
				int num3 = 0;
				int num4 = 0;
				if (pagina == 512)
				{
					num3 = 0;
					num4 = num - 1;
				}
				else if (pagina == 612)
				{
					num3 = 25;
					num4 = 49;
				}
				Comunicacao.Init_buffer_serial();
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(pagina / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(pagina % 256);
				Comunicacao.Buffer_cmd[4] = (byte)(num2 / 256);
				Comunicacao.Buffer_cmd[5] = (byte)(num2 % 256);
				Comunicacao.Buffer_cmd[6] = (byte)(num2 * 2);
				int num5 = 7;
				int num6 = num3;
				int num7 = num4;
				for (int i = num6; i <= num7; i++)
				{
					int valor = RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i].NumeroVariavel.Valor;
					int num8 = 0;
					byte b = (byte)num8;
					int num9;
					byte b2 = (byte)num9;
					Linha_RT.Split16(valor, ref b, ref b2);
					num9 = (int)b2;
					num8 = (int)b;
					Comunicacao.Buffer_cmd[num5] = (byte)num8;
					num5++;
					Comunicacao.Buffer_cmd[num5] = (byte)num9;
					num5++;
					int valor2 = RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i].Prioridade.Valor;
					b2 = (byte)num8;
					b = (byte)num9;
					Linha_RT.Split16(valor2, ref b2, ref b);
					num9 = (int)b;
					num8 = (int)b2;
					Comunicacao.Buffer_cmd[num5] = (byte)num8;
					num5++;
					Comunicacao.Buffer_cmd[num5] = (byte)num9;
					num5++;
					int valor3 = RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i].Altura.Valor;
					b2 = (byte)num8;
					b = (byte)num9;
					Linha_RT.Split16(valor3, ref b2, ref b);
					num9 = (int)b;
					num8 = (int)b2;
					Comunicacao.Buffer_cmd[num5] = (byte)num8;
					num5++;
					Comunicacao.Buffer_cmd[num5] = (byte)num9;
					num5++;
					int valor4 = RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i].Nome.Valor;
					b2 = (byte)num8;
					b = (byte)num9;
					Linha_RT.Split16(valor4, ref b2, ref b);
					num9 = (int)b;
					num8 = (int)b2;
					Comunicacao.Buffer_cmd[num5] = (byte)num8;
					num5++;
					Comunicacao.Buffer_cmd[num5] = (byte)num9;
					num5++;
				}
				int num10 = num5 + 0;
				int num11 = Comunicacao.Crc16_TX(ref num10);
				Comunicacao.Buffer_cmd[num5 + 0] = (byte)(num11 % 256);
				Comunicacao.Buffer_cmd[num5 + 1] = (byte)(num11 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num5 + 2);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0024D73C File Offset: 0x0024BB3C
		public static void CMD_Esc_RT_830_200_RECALQUE(int pagina, int endereco, int quantos)
		{
			Comunicacao.Init_buffer_serial();
			int num = 0;
			if (pagina == 768)
			{
				num = 0;
			}
			else if (pagina == 888)
			{
				num = 4;
			}
			else if (pagina == 1024)
			{
				num = 7;
			}
			else if (pagina == 1144)
			{
				num = 11;
			}
			else if (pagina == 1280)
			{
				num = 14;
			}
			else if (pagina == 1400)
			{
				num = 18;
			}
			else if (pagina == 1536)
			{
				num = 21;
			}
			else if (pagina == 1656)
			{
				num = 25;
			}
			checked
			{
				int num2 = num + quantos;
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(pagina / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(pagina % 256);
				Comunicacao.Buffer_cmd[4] = (byte)(quantos * 30 / 256);
				Comunicacao.Buffer_cmd[5] = (byte)(quantos * 30 % 256);
				Comunicacao.Buffer_cmd[6] = (byte)(quantos * 30 * 2);
				int num3 = 7;
				int num4 = Convert.ToInt32(num);
				int num5 = num2 - 1;
				for (int i = num4; i <= num5; i++)
				{
					int valor = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].origem.Valor;
					int num6 = 0;
					byte b = (byte)num6;
					int num7 = 0;
					byte b2 = (byte)num7;
					Linha_RT.Split16(valor, ref b, ref b2);
					num7 = (int)b2;
					num6 = (int)b;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor2 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].destino.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor2, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor3 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Var1.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor3, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor4 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Var2.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor4, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor5 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Var3.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor5, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor6 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Var4.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor6, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor7 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome_Var1.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor7, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor8 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome_Var2.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor8, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor9 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome_Var3.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor9, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor10 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome_Var4.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor10, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor11 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Modelo.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor11, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor12 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Prioridade.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor12, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor13 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor13, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor14 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Habilita.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor14, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor15 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala1.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor15, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor16 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala2.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor16, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor17 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala3.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor17, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor18 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala4.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor18, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor19 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala5.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor19, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor20 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala6.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor20, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor21 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala7.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor21, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor22 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala8.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor22, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor23 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala9.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor23, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor24 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala10.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor24, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor25 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala11.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor25, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor26 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala12.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor26, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor27 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala13.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor27, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor28 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala14.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor28, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor29 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala15.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor29, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor30 = RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala16.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor30, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
				}
				int num8 = num3 + 0;
				int num9 = Comunicacao.Crc16_TX(ref num8);
				Comunicacao.Buffer_cmd[num3 + 0] = (byte)(num9 % 256);
				Comunicacao.Buffer_cmd[num3 + 1] = (byte)(num9 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num3 + 2);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0024E280 File Offset: 0x0024C680
		public static void CMD_Esc_RT_830_200_VISTA(int pagina, int endereco, int quantos)
		{
			Comunicacao.Init_buffer_serial();
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (pagina == 1792)
			{
				num = 0;
				num2 = 1;
				num3 = 2;
			}
			else if (pagina == 1878)
			{
				num = 2;
				num2 = 3;
				num3 = 2;
			}
			else if (pagina == 1964)
			{
				num = 4;
				num2 = 4;
				num3 = 1;
			}
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(pagina / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(pagina % 256);
				Comunicacao.Buffer_cmd[4] = (byte)(num3 * 43 / 256);
				Comunicacao.Buffer_cmd[5] = (byte)(num3 * 43 % 256);
				Comunicacao.Buffer_cmd[6] = (byte)(num3 * 43 * 2);
				int num4 = 7;
				int num5 = Convert.ToInt32(num);
				int num6 = num2;
				for (int i = num5; i <= num6; i++)
				{
					int valor = RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_Variaveis.Valor;
					int num7 = 0;
					byte b = (byte)num7;
					int num8 = 0;
					byte b2 = (byte)num8;
					Linha_RT.Split16(valor, ref b, ref b2);
					num8 = (int)b2;
					num7 = (int)b;
					Comunicacao.Buffer_cmd[num4] = (byte)num7;
					num4++;
					Comunicacao.Buffer_cmd[num4] = (byte)num8;
					num4++;
					int valor2 = RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_RemotasControles.Valor;
					b2 = (byte)num7;
					b = (byte)num8;
					Linha_RT.Split16(valor2, ref b2, ref b);
					num8 = (int)b;
					num7 = (int)b2;
					Comunicacao.Buffer_cmd[num4] = (byte)num7;
					num4++;
					Comunicacao.Buffer_cmd[num4] = (byte)num8;
					num4++;
					int valor3 = RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Prioridade.Valor;
					b2 = (byte)num7;
					b = (byte)num8;
					Linha_RT.Split16(valor3, ref b2, ref b);
					num8 = (int)b;
					num7 = (int)b2;
					Comunicacao.Buffer_cmd[num4] = (byte)num7;
					num4++;
					Comunicacao.Buffer_cmd[num4] = (byte)num8;
					num4++;
					int num9 = 0;
					int num10 = 0;
					int num11 = RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_Variaveis.Valor - 1;
					num3 = num10;
					while (num3 <= num11 && num9 != 40)
					{
						int valor4 = RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Variaveis[num3].Valor;
						b2 = (byte)num7;
						b = (byte)num8;
						Linha_RT.Split16(valor4, ref b2, ref b);
						num8 = (int)b;
						num7 = (int)b2;
						Comunicacao.Buffer_cmd[num4] = (byte)num7;
						num4++;
						Comunicacao.Buffer_cmd[num4] = (byte)num8;
						num4++;
						num9++;
						num3++;
					}
					int num12 = 0;
					int num13 = RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_RemotasControles.Valor - 1;
					int num14 = num12;
					while (num14 <= num13 && num9 != 40)
					{
						int valor5 = RT_830_200_variaveis_X.RT_830_200_BD.vista[i].RemotasControles[num14].Valor;
						b2 = (byte)num7;
						b = (byte)num8;
						Linha_RT.Split16(valor5, ref b2, ref b);
						num8 = (int)b;
						num7 = (int)b2;
						Comunicacao.Buffer_cmd[num4] = (byte)num7;
						num4++;
						Comunicacao.Buffer_cmd[num4] = (byte)num8;
						num4++;
						num9++;
						num14++;
					}
					int num15 = 0;
					int num16 = 40 - (RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_Variaveis.Valor + RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_RemotasControles.Valor) - 1;
					int num17 = num15;
					while (num17 <= num16 && num9 != 40)
					{
						Comunicacao.Buffer_cmd[num4] = 0;
						num4++;
						Comunicacao.Buffer_cmd[num4] = 0;
						num4++;
						num9++;
						num17++;
					}
				}
				int num18 = num4 + 0;
				int num19 = Comunicacao.Crc16_TX(ref num18);
				Comunicacao.Buffer_cmd[num4 + 0] = (byte)(num19 % 256);
				Comunicacao.Buffer_cmd[num4 + 1] = (byte)(num19 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num4 + 2);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x0024E654 File Offset: 0x0024CA54
		public static void CMD_Esc_RT_831_200_CFG_GERAIS(int endereco)
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
				int valor = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre.Valor;
				int num = 0;
				byte b = (byte)num;
				int num2 = 0;
				byte b2 = (byte)num2;
				Linha_RT.Split16(valor, ref b, ref b2);
				num2 = (int)b2;
				num = (int)b;
				Comunicacao.Buffer_cmd[7] = (byte)num;
				Comunicacao.Buffer_cmd[8] = (byte)num2;
				int valor2 = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor2, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[9] = (byte)num;
				Comunicacao.Buffer_cmd[10] = (byte)num2;
				int valor3 = (int)Math.Round((double)RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT.Valor / 10.0);
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor3, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[11] = (byte)num;
				Comunicacao.Buffer_cmd[12] = (byte)num2;
				int valor4 = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor4, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[13] = (byte)num;
				Comunicacao.Buffer_cmd[14] = (byte)num2;
				int valor5 = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor5, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[15] = (byte)num;
				Comunicacao.Buffer_cmd[16] = (byte)num2;
				int valor6 = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor;
				b2 = (byte)num;
				b = (byte)num2;
				Linha_RT.Split16(valor6, ref b2, ref b);
				num2 = (int)b;
				num = (int)b2;
				Comunicacao.Buffer_cmd[17] = (byte)num;
				Comunicacao.Buffer_cmd[18] = (byte)num2;
				int num3 = 18;
				int num4 = num3 + 1;
				int num5 = Comunicacao.Crc16_TX(ref num4);
				Comunicacao.Buffer_cmd[num3 + 1] = (byte)(num5 % 256);
				Comunicacao.Buffer_cmd[num3 + 2] = (byte)(num5 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num3 + 3);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0024E890 File Offset: 0x0024CC90
		public static void CMD_Esc_RT_831_200_RESERVATORIO(int endereco)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 2;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = (byte)(RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor * 1 / 256);
				Comunicacao.Buffer_cmd[5] = (byte)(RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor * 1 % 256);
				Comunicacao.Buffer_cmd[6] = (byte)(RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor * 1 * 2);
				int num = 7;
				int num2 = 0;
				int num3 = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor - 1;
				for (int i = num2; i <= num3; i++)
				{
					int valor = RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[i].Nome.Valor;
					int num4 = 0;
					byte b = (byte)num4;
					int num5 = 0;
					byte b2 = (byte)num5;
					Linha_RT.Split16(valor, ref b, ref b2);
					num5 = (int)b2;
					num4 = (int)b;
					Comunicacao.Buffer_cmd[num] = (byte)num4;
					num++;
					Comunicacao.Buffer_cmd[num] = (byte)num5;
					num++;
				}
				int num6 = num + 0;
				int num7 = Comunicacao.Crc16_TX(ref num6);
				Comunicacao.Buffer_cmd[num + 0] = (byte)(num7 % 256);
				Comunicacao.Buffer_cmd[num + 1] = (byte)(num7 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num + 2);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x0024EA04 File Offset: 0x0024CE04
		public static void CMD_Esc_RT_831_200_RECALQUE(int pagina, int endereco, int quantos)
		{
			Comunicacao.Init_buffer_serial();
			int num = 0;
			if (pagina == 768)
			{
				num = 0;
			}
			else if (pagina == 844)
			{
				num = 4;
			}
			else if (pagina == 1024)
			{
				num = 7;
			}
			else if (pagina == 1100)
			{
				num = 11;
			}
			else if (pagina == 1280)
			{
				num = 14;
			}
			else if (pagina == 1356)
			{
				num = 18;
			}
			else if (pagina == 1536)
			{
				num = 21;
			}
			else if (pagina == 1612)
			{
				num = 25;
			}
			checked
			{
				int num2 = num + quantos;
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = (byte)(pagina / 256);
				Comunicacao.Buffer_cmd[3] = (byte)(pagina % 256);
				Comunicacao.Buffer_cmd[4] = (byte)(quantos * 19 / 256);
				Comunicacao.Buffer_cmd[5] = (byte)(quantos * 19 % 256);
				Comunicacao.Buffer_cmd[6] = (byte)(quantos * 19 * 2);
				int num3 = 7;
				int num4 = Convert.ToInt32(num);
				int num5 = num2 - 1;
				for (int i = num4; i <= num5; i++)
				{
					int valor = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Modelo.Valor;
					int num6 = 0;
					byte b = (byte)num6;
					int num7 = 0;
					byte b2 = (byte)num7;
					Linha_RT.Split16(valor, ref b, ref b2);
					num7 = (int)b2;
					num6 = (int)b;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor2 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Nome.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor2, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor3 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Habilita.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor3, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor4 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala1.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor4, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor5 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala2.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor5, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor6 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala3.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor6, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor7 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala4.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor7, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor8 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala5.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor8, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor9 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala6.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor9, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor10 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala7.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor10, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor11 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala8.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor11, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor12 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala9.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor12, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor13 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala10.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor13, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor14 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala11.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor14, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor15 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala12.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor15, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor16 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala13.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor16, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor17 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala14.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor17, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor18 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala15.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor18, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
					int valor19 = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala16.Valor;
					b2 = (byte)num6;
					b = (byte)num7;
					Linha_RT.Split16(valor19, ref b2, ref b);
					num7 = (int)b;
					num6 = (int)b2;
					Comunicacao.Buffer_cmd[num3] = (byte)num6;
					num3++;
					Comunicacao.Buffer_cmd[num3] = (byte)num7;
					num3++;
				}
				int num8 = num3 + 0;
				int num9 = Comunicacao.Crc16_TX(ref num8);
				Comunicacao.Buffer_cmd[num3 + 0] = (byte)(num9 % 256);
				Comunicacao.Buffer_cmd[num3 + 1] = (byte)(num9 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num3 + 2);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x0024F1AC File Offset: 0x0024D5AC
		public static void CMD_Esc_RT_831_200_SENHA(int endereco)
		{
			Comunicacao.Init_buffer_serial();
			checked
			{
				Comunicacao.Buffer_cmd[0] = (byte)endereco;
				Comunicacao.Buffer_cmd[1] = 16;
				Comunicacao.Buffer_cmd[2] = 9;
				Comunicacao.Buffer_cmd[3] = 0;
				Comunicacao.Buffer_cmd[4] = 0;
				Comunicacao.Buffer_cmd[5] = 1;
				Comunicacao.Buffer_cmd[6] = 2;
				int num = 7;
				int valor = RT_831_200_variaveis_X.RT_831_200_BD.senha.senha.Valor;
				int num2 = 0;
				byte b = (byte)num2;
				int num3 = 0;
				byte b2 = (byte)num3;
				Linha_RT.Split16(valor, ref b, ref b2);
				num3 = (int)b2;
				num2 = (int)b;
				Comunicacao.Buffer_cmd[num] = (byte)num2;
				num++;
				Comunicacao.Buffer_cmd[num] = (byte)num3;
				num++;
				int num4 = num + 0;
				int num5 = Comunicacao.Crc16_TX(ref num4);
				Comunicacao.Buffer_cmd[num + 0] = (byte)(num5 % 256);
				Comunicacao.Buffer_cmd[num + 1] = (byte)(num5 / 256);
				MyProject.Forms.Plataforma.SerialPort1.Write(Comunicacao.Buffer_cmd, 0, num + 2);
				MyProject.Forms.Plataforma.Timer_timeout.Enabled = true;
			}
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x0024F2A4 File Offset: 0x0024D6A4
		public static void Tratamento_Variaveis_Escala_Fim(int indice, int value)
		{
			int num = Convert.ToInt32(value);
			checked
			{
				if (num >= 10000 & num <= 11000)
				{
					num -= 10000;
					RT_geral.Variaveis_RT_850[indice].Escala_tratamento.Indice = 1;
					RT_geral.Variaveis_RT_850[indice].Escala_tratamento.Valor = 1;
				}
				else
				{
					RT_geral.Variaveis_RT_850[indice].Escala_tratamento.Indice = 0;
					RT_geral.Variaveis_RT_850[indice].Escala_tratamento.Valor = 0;
				}
				RT_geral.Variaveis_RT_850[indice].Escala_fim.Valor = num;
			}
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x0024F344 File Offset: 0x0024D744
		public static void Atualiza_dados_RT850(int pag, int num_bloco)
		{
			int[] array = new int[251];
			checked
			{
				if (pag == 0)
				{
					RT_geral.RT_850_BD.Equip.Valor = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_850_BD.Versao.Valor = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					RT_geral.RT_850_BD.Build.Valor = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
					RT_geral.RT_850_BD.Release.Valor = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
				}
				else if (pag == 2048)
				{
					RT_geral.RT_850_BD.End_mestre_canal_1.Valor = (int)Comunicacao.Buffer_resp[3];
					RT_geral.RT_850_BD.End_mestre_canal_2.Valor = (int)Comunicacao.Buffer_resp[4];
					RT_geral.RT_850_BD.Intervalo_leitura_canal_1.Valor = (int)Comunicacao.Buffer_resp[5];
					RT_geral.RT_850_BD.Intervalo_leitura_canal_2.Valor = (int)Comunicacao.Buffer_resp[6];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_850_BD.BaudRate_canal_1, (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_850_BD.BaudRate_canal_2, (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10]);
					RT_geral.RT_850_BD.Timeout_canal_1.Valor = (int)Comunicacao.Buffer_resp[11];
					RT_geral.RT_850_BD.Timeout_canal_2.Valor = (int)Comunicacao.Buffer_resp[12];
					RT_geral.RT_850_BD.Tempo_ptt_canal_1.Valor = (int)Comunicacao.Buffer_resp[13];
					RT_geral.RT_850_BD.Tempo_ptt_canal_2.Valor = (int)Comunicacao.Buffer_resp[14];
					RT_geral.RT_850_BD.Numero_tentativas_canal_1.Valor = (int)Comunicacao.Buffer_resp[15];
					RT_geral.RT_850_BD.Numero_tentativas_canal_2.Valor = (int)Comunicacao.Buffer_resp[16];
					RT_geral.RT_850_BD.Numero_erros_falha_canal_1.Valor = (int)Comunicacao.Buffer_resp[17];
					RT_geral.RT_850_BD.Numero_erros_falha_canal_2.Valor = (int)Comunicacao.Buffer_resp[18];
					RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor = (int)Comunicacao.Buffer_resp[19];
					RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor = (int)Comunicacao.Buffer_resp[20];
					RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor = (int)Comunicacao.Buffer_resp[21];
					RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor = (int)Comunicacao.Buffer_resp[22];
					RT_geral.RT_850_BD.End_inicial_equip_tipo_1.Valor = (int)Comunicacao.Buffer_resp[23];
					RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Valor = (int)Comunicacao.Buffer_resp[24];
					RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Valor = (int)Comunicacao.Buffer_resp[25];
					RT_geral.RT_850_BD.End_inicial_equip_tipo_vista.Valor = (int)Comunicacao.Buffer_resp[26];
					RT_geral.RT_850_BD.Sincronismo.Valor = (int)Comunicacao.Buffer_resp[27] * 256 + (int)Comunicacao.Buffer_resp[28];
					int num = 0;
					do
					{
						int num2 = num * 2;
						array[num] = (int)Comunicacao.Buffer_resp[29 + num2] * 256 + (int)Comunicacao.Buffer_resp[30 + num2];
						num++;
					}
					while (num <= 39);
					int num3 = 0;
					RT_geral.RT_850_BD.Msg_linha_1.Valor = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					num3 = 10;
					RT_geral.RT_850_BD.Msg_linha_2.Valor = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					num3 = 20;
					RT_geral.RT_850_BD.Msg_linha_3.Valor = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					num3 = 30;
					RT_geral.RT_850_BD.Msg_linha_4.Valor = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					RT_geral.RT_850_BD.Variaveis_Numero.Valor = 0;
					RT_geral.RT_850_BD.ConfereResposta.Valor = (int)Comunicacao.Buffer_resp[109];
					RT_geral.RT_850_BD.Modo_Estatistica.Valor = (int)Comunicacao.Buffer_resp[110];
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_850_BD.Flag_Remota, (int)Comunicacao.Buffer_resp[111]);
					Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_850_BD.Flag_Supervisorio, (int)Comunicacao.Buffer_resp[112]);
					RT_geral.RT_850_BD.LiberaTeclado.Valor = (int)Comunicacao.Buffer_resp[113];
					RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Valor = (int)Comunicacao.Buffer_resp[119] * 256 + (int)Comunicacao.Buffer_resp[120];
					RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Valor = (int)Comunicacao.Buffer_resp[121] * 256 + (int)Comunicacao.Buffer_resp[122];
				}
				else if (pag == 4096)
				{
					int num4 = num_bloco * 10;
					int num5 = 0;
					do
					{
						int num6 = 3 + num5 * 22;
						int num = 0;
						do
						{
							int num2 = num * 2;
							array[num] = (int)Comunicacao.Buffer_resp[num6 + num2] * 256 + (int)Comunicacao.Buffer_resp[num6 + 1 + num2];
							num++;
						}
						while (num <= 4);
						RT_geral.DADO_VARIAVEL[] variaveis_RT_ = RT_geral.Variaveis_RT_850;
						int num7 = num4 + num5;
						int num3 = 0;
						variaveis_RT_[num7].Nome.Valor = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 5);
						Linha_RT.VerificaSeVariavelValida(RT_geral.Variaveis_RT_850[num4 + num5].Nome.Valor);
						RT_geral.Variaveis_RT_850[num4 + num5].Dsp_tela.Valor = (int)Comunicacao.Buffer_resp[num6 + 10];
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.Variaveis_RT_850[num4 + num5].Dsp_pos, RT_geral.RT_850_DataGridView_variaveis[12], (int)Comunicacao.Buffer_resp[num6 + 11]);
						RT_geral.Variaveis_RT_850[num4 + num5].Escala_ini.Valor = (int)(Comunicacao.Buffer_resp[num6 + 12] & 63) * 256 + (int)Comunicacao.Buffer_resp[num6 + 13];
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.Variaveis_RT_850[num4 + num5].Pto_dec_fim, RT_geral.RT_850_DataGridView_variaveis[4], (int)(Comunicacao.Buffer_resp[num6 + 14] / 64));
						Linha_RT.Tratamento_Variaveis_Escala_Fim(num4 + num5, (int)(Comunicacao.Buffer_resp[num6 + 14] & 63) * 256 + (int)Comunicacao.Buffer_resp[num6 + 15]);
						RT_geral.Variaveis_RT_850[num4 + num5].Nivel_alm_1.Valor = (int)Comunicacao.Buffer_resp[num6 + 16] * 256 + (int)Comunicacao.Buffer_resp[num6 + 17];
						RT_geral.Variaveis_RT_850[num4 + num5].Nivel_alm_2.Valor = (int)Comunicacao.Buffer_resp[num6 + 18] * 256 + (int)Comunicacao.Buffer_resp[num6 + 19];
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.Variaveis_RT_850[num4 + num5].Tipo_alm_1, RT_geral.RT_850_DataGridView_variaveis[6], (int)(Comunicacao.Buffer_resp[num6 + 20] / 128));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.Variaveis_RT_850[num4 + num5].Msg_alm_1, RT_geral.RT_850_DataGridView_variaveis[7], (int)(Comunicacao.Buffer_resp[num6 + 20] & 127));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.Variaveis_RT_850[num4 + num5].Tipo_alm_2, RT_geral.RT_850_DataGridView_variaveis[9], (int)(Comunicacao.Buffer_resp[num6 + 21] / 128));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.Variaveis_RT_850[num4 + num5].Msg_alm_2, RT_geral.RT_850_DataGridView_variaveis[10], (int)(Comunicacao.Buffer_resp[num6 + 21] & 127));
						num5++;
					}
					while (num5 <= 9);
				}
				else if (pag == 6144)
				{
					int num4 = 150 + num_bloco * 10;
					int num5 = 0;
					do
					{
						int num6 = 3 + num5 * 22;
						int num = 0;
						do
						{
							int num2 = num * 2;
							array[num] = (int)Comunicacao.Buffer_resp[num6 + num2] * 256 + (int)Comunicacao.Buffer_resp[num6 + 1 + num2];
							num++;
						}
						while (num <= 4);
						RT_geral.DADO_VARIAVEL[] variaveis_RT_2 = RT_geral.Variaveis_RT_850;
						int num8 = num4 + num5;
						int num3 = 0;
						variaveis_RT_2[num8].Nome.Valor = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 5);
						Linha_RT.VerificaSeVariavelValida(RT_geral.Variaveis_RT_850[num4 + num5].Nome.Valor);
						RT_geral.Variaveis_RT_850[num4 + num5].Dsp_tela.Valor = (int)Comunicacao.Buffer_resp[num6 + 10];
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.Variaveis_RT_850[num4 + num5].Dsp_pos, RT_geral.RT_850_DataGridView_variaveis[12], (int)Comunicacao.Buffer_resp[num6 + 11]);
						RT_geral.Variaveis_RT_850[num4 + num5].Escala_ini.Valor = (int)(Comunicacao.Buffer_resp[num6 + 12] & 63) * 256 + (int)Comunicacao.Buffer_resp[num6 + 13];
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.Variaveis_RT_850[num4 + num5].Pto_dec_fim, RT_geral.RT_850_DataGridView_variaveis[4], (int)(Comunicacao.Buffer_resp[num6 + 14] / 64));
						RT_geral.Variaveis_RT_850[num4 + num5].Escala_fim.Valor = (int)(Comunicacao.Buffer_resp[num6 + 14] & 63) * 256 + (int)Comunicacao.Buffer_resp[num6 + 15];
						RT_geral.Variaveis_RT_850[num4 + num5].Nivel_alm_1.Valor = (int)Comunicacao.Buffer_resp[num6 + 16] * 256 + (int)Comunicacao.Buffer_resp[num6 + 17];
						RT_geral.Variaveis_RT_850[num4 + num5].Nivel_alm_2.Valor = (int)Comunicacao.Buffer_resp[num6 + 18] * 256 + (int)Comunicacao.Buffer_resp[num6 + 19];
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.Variaveis_RT_850[num4 + num5].Tipo_alm_1, RT_geral.RT_850_DataGridView_variaveis[6], (int)(Comunicacao.Buffer_resp[num6 + 20] / 64));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.Variaveis_RT_850[num4 + num5].Msg_alm_1, RT_geral.RT_850_DataGridView_variaveis[7], (int)(Comunicacao.Buffer_resp[num6 + 20] & 63));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.Variaveis_RT_850[num4 + num5].Tipo_alm_2, RT_geral.RT_850_DataGridView_variaveis[9], (int)(Comunicacao.Buffer_resp[num6 + 21] / 64));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.Variaveis_RT_850[num4 + num5].Msg_alm_2, RT_geral.RT_850_DataGridView_variaveis[10], (int)(Comunicacao.Buffer_resp[num6 + 21] & 63));
						num5++;
					}
					while (num5 <= 9);
				}
				else if (pag == 12288)
				{
					int num = 0;
					do
					{
						int num2 = num * 2;
						array[num] = (int)Comunicacao.Buffer_resp[3 + num2] * 256 + (int)Comunicacao.Buffer_resp[4 + num2];
						num++;
					}
					while (num <= 199);
					string[] rt_850_MSG_ALARME_CONFIG = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num9 = 0;
					int num3 = 0;
					rt_850_MSG_ALARME_CONFIG[num9] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG2 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num10 = 1;
					num3 = 10;
					rt_850_MSG_ALARME_CONFIG2[num10] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG3 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num11 = 2;
					num3 = 20;
					rt_850_MSG_ALARME_CONFIG3[num11] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG4 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num12 = 3;
					num3 = 30;
					rt_850_MSG_ALARME_CONFIG4[num12] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG5 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num13 = 4;
					num3 = 40;
					rt_850_MSG_ALARME_CONFIG5[num13] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG6 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num14 = 5;
					num3 = 50;
					rt_850_MSG_ALARME_CONFIG6[num14] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG7 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num15 = 6;
					num3 = 60;
					rt_850_MSG_ALARME_CONFIG7[num15] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG8 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num16 = 7;
					num3 = 70;
					rt_850_MSG_ALARME_CONFIG8[num16] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG9 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num17 = 8;
					num3 = 80;
					rt_850_MSG_ALARME_CONFIG9[num17] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG10 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num18 = 9;
					num3 = 90;
					rt_850_MSG_ALARME_CONFIG10[num18] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
				}
				else if (pag == 12388)
				{
					int num = 0;
					do
					{
						int num2 = num * 2;
						array[num] = (int)Comunicacao.Buffer_resp[3 + num2] * 256 + (int)Comunicacao.Buffer_resp[4 + num2];
						num++;
					}
					while (num <= 199);
					string[] rt_850_MSG_ALARME_CONFIG11 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num19 = 10;
					int num3 = 0;
					rt_850_MSG_ALARME_CONFIG11[num19] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG12 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num20 = 11;
					num3 = 10;
					rt_850_MSG_ALARME_CONFIG12[num20] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG13 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num21 = 12;
					num3 = 20;
					rt_850_MSG_ALARME_CONFIG13[num21] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG14 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num22 = 13;
					num3 = 30;
					rt_850_MSG_ALARME_CONFIG14[num22] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG15 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num23 = 14;
					num3 = 40;
					rt_850_MSG_ALARME_CONFIG15[num23] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG16 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num24 = 15;
					num3 = 50;
					rt_850_MSG_ALARME_CONFIG16[num24] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG17 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num25 = 16;
					num3 = 60;
					rt_850_MSG_ALARME_CONFIG17[num25] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG18 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num26 = 17;
					num3 = 70;
					rt_850_MSG_ALARME_CONFIG18[num26] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG19 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num27 = 18;
					num3 = 80;
					rt_850_MSG_ALARME_CONFIG19[num27] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
					string[] rt_850_MSG_ALARME_CONFIG20 = RT_geral.RT_850_MSG_ALARME_CONFIG;
					int num28 = 19;
					num3 = 90;
					rt_850_MSG_ALARME_CONFIG20[num28] = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 10);
				}
				else if (pag == 22528)
				{
					int num4 = 0 + num_bloco * 8;
					int num5 = 0;
					do
					{
						int num6 = 3 + num5 * 30;
						int num = 0;
						do
						{
							int num2 = num * 2;
							array[num] = (int)Comunicacao.Buffer_resp[num6 + num2] * 256 + (int)Comunicacao.Buffer_resp[num6 + 1 + num2];
							num++;
						}
						while (num <= 4);
						RT_geral.Dados_Ctrl[] rt_850_Ctrl_ = RT_geral.RT_850_Ctrl_1;
						int num29 = num4 + num5;
						int num3 = 0;
						rt_850_Ctrl_[num29].Nome.Valor = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 5);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_1[num4 + num5].Canal, RT_geral.RT_850_DataGridView_ctrl_1[1], (int)(Comunicacao.Buffer_resp[num6 + 10] / 64));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_1[num4 + num5].Timeout, RT_geral.RT_850_DataGridView_ctrl_1[2], (int)((Comunicacao.Buffer_resp[num6 + 10] & 63) / 8));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_1[num4 + num5].Prioridade, RT_geral.RT_850_DataGridView_ctrl_1[4], (int)(Comunicacao.Buffer_resp[num6 + 10] & 7));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_1[num4 + num5].Comando, RT_geral.RT_850_DataGridView_ctrl_1[3], (int)(Comunicacao.Buffer_resp[num6 + 11] / 64));
						RT_geral.RT_850_Ctrl_1[num4 + num5].Modelo.Indice = (int)(Comunicacao.Buffer_resp[num6 + 11] & 63);
						num = 0;
						do
						{
							int num2 = num * 2;
							array[0] = (int)Comunicacao.Buffer_resp[num6 + 12 + num2] * 256 + (int)Comunicacao.Buffer_resp[num6 + 13 + num2];
							Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_1[num4 + num5].Var[num], RT_geral.RT_850_DataGridView_ctrl_1[8 + num], array[0]);
							num++;
						}
						while (num <= 3);
						num = 0;
						do
						{
							int num2 = num * 2;
							array[0] = (int)Comunicacao.Buffer_resp[num6 + 20 + num2] * 256 + (int)Comunicacao.Buffer_resp[num6 + 21 + num2];
							Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_1[num4 + num5].Ref[num], RT_geral.RT_850_DataGridView_ctrl_1[12 + num], array[0]);
							num++;
						}
						while (num <= 3);
						num = 0;
						do
						{
							int num2 = num * 2;
							array[0] = (int)Comunicacao.Buffer_resp[num6 + 28 + num2];
							Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_1[num4 + num5].Crtl_nome[num], RT_geral.RT_850_DataGridView_ctrl_1[6 + num2], array[0]);
							RT_geral.RT_850_Ctrl_1[num4 + num5].Crtl_indice[num].Valor = (int)Comunicacao.Buffer_resp[num6 + 29 + num2];
							num++;
						}
						while (num <= 0);
						num5++;
					}
					while (num5 <= 7);
				}
				else if (pag == 24576)
				{
					int num4 = 0 + num_bloco * 5;
					int num5 = 0;
					do
					{
						int num6 = 3 + num5 * 46;
						int num = 0;
						do
						{
							int num2 = num * 2;
							array[num] = (int)Comunicacao.Buffer_resp[num6 + num2] * 256 + (int)Comunicacao.Buffer_resp[num6 + 1 + num2];
							num++;
						}
						while (num <= 4);
						RT_geral.Dados_Ctrl_3[] rt_850_Ctrl_2 = RT_geral.RT_850_Ctrl_4;
						int num30 = num4 + num5;
						int num3 = 0;
						rt_850_Ctrl_2[num30].Nome.Valor = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 5);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_4[num4 + num5].Canal, RT_geral.RT_850_DataGridView_ctrl_4[1], (int)(Comunicacao.Buffer_resp[num6 + 10] / 64));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_4[num4 + num5].Timeout, RT_geral.RT_850_DataGridView_ctrl_4[2], (int)((Comunicacao.Buffer_resp[num6 + 10] & 63) / 8));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_4[num4 + num5].Prioridade, RT_geral.RT_850_DataGridView_ctrl_4[4], (int)(Comunicacao.Buffer_resp[num6 + 10] & 7));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_4[num4 + num5].Comando, RT_geral.RT_850_DataGridView_ctrl_4[3], (int)(Comunicacao.Buffer_resp[num6 + 11] / 64));
						RT_geral.RT_850_Ctrl_4[num4 + num5].Modelo.Indice = (int)(Comunicacao.Buffer_resp[num6 + 11] & 63);
						num = 0;
						do
						{
							int num2 = num * 2;
							array[0] = (int)Comunicacao.Buffer_resp[num6 + 12 + num2] * 256 + (int)Comunicacao.Buffer_resp[num6 + 13 + num2];
							Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_4[num4 + num5].Var[num], RT_geral.RT_850_DataGridView_ctrl_4[14 + num], array[0]);
							num++;
						}
						while (num <= 3);
						num = 0;
						do
						{
							int num2 = num * 2;
							array[0] = (int)Comunicacao.Buffer_resp[num6 + 20 + num2] * 256 + (int)Comunicacao.Buffer_resp[num6 + 21 + num2];
							Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_4[num4 + num5].Ref[num], RT_geral.RT_850_DataGridView_ctrl_4[18 + num], array[0]);
							num++;
						}
						while (num <= 3);
						num = 0;
						do
						{
							int num2 = num * 2;
							Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_4[num4 + num5].Periferico_Indice[num], RT_geral.RT_850_DataGridView_ctrl_4[23 + num2], (int)Comunicacao.Buffer_resp[num6 + 28 + num2]);
							Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_4[num4 + num5].Periferico_Modelo[num], RT_geral.RT_850_DataGridView_ctrl_4[22 + num2], (int)Comunicacao.Buffer_resp[num6 + 29 + num2]);
							num++;
						}
						while (num <= 4);
						num = 0;
						do
						{
							int num2 = num * 2;
							array[0] = (int)Comunicacao.Buffer_resp[num6 + 38 + num2];
							Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_4[num4 + num5].Crtl_nome[num], RT_geral.RT_850_DataGridView_ctrl_4[6 + num2], array[0]);
							RT_geral.RT_850_Ctrl_4[num4 + num5].Crtl_indice[num].Valor = (int)Comunicacao.Buffer_resp[num6 + 39 + num2];
							num++;
						}
						while (num <= 3);
						num5++;
					}
					while (num5 <= 4);
				}
				else if (pag == 26624)
				{
					int num4 = 0 + num_bloco * 2;
					int num5 = 0;
					do
					{
						int num6 = 3 + num5 * 78;
						int num = 0;
						do
						{
							int num2 = num * 2;
							array[num] = (int)Comunicacao.Buffer_resp[num6 + num2] * 256 + (int)Comunicacao.Buffer_resp[num6 + 1 + num2];
							num++;
						}
						while (num <= 4);
						RT_geral.Dados_Ctrl_3[] rt_850_Ctrl_3 = RT_geral.RT_850_Ctrl_8;
						int num31 = num4 + num5;
						int num3 = 0;
						rt_850_Ctrl_3[num31].Nome.Valor = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 5);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_8[num4 + num5].Canal, RT_geral.RT_850_DataGridView_ctrl_8[1], (int)(Comunicacao.Buffer_resp[num6 + 10] / 64));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_8[num4 + num5].Timeout, RT_geral.RT_850_DataGridView_ctrl_8[2], (int)((Comunicacao.Buffer_resp[num6 + 10] & 63) / 8));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_8[num4 + num5].Prioridade, RT_geral.RT_850_DataGridView_ctrl_8[4], (int)(Comunicacao.Buffer_resp[num6 + 10] & 7));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_8[num4 + num5].Comando, RT_geral.RT_850_DataGridView_ctrl_8[3], (int)(Comunicacao.Buffer_resp[num6 + 11] / 64));
						RT_geral.RT_850_Ctrl_8[num4 + num5].Modelo.Indice = (int)(Comunicacao.Buffer_resp[num6 + 11] & 63);
						num = 0;
						do
						{
							int num2 = num * 2;
							array[0] = (int)Comunicacao.Buffer_resp[num6 + 12 + num2] * 256 + (int)Comunicacao.Buffer_resp[num6 + 13 + num2];
							Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_8[num4 + num5].Var[num], RT_geral.RT_850_DataGridView_ctrl_8[22 + num], array[0]);
							num++;
						}
						while (num <= 15);
						num = 0;
						do
						{
							int num2 = num * 2;
							array[0] = (int)Comunicacao.Buffer_resp[num6 + 44 + num2] * 256 + (int)Comunicacao.Buffer_resp[num6 + 45 + num2];
							Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_8[num4 + num5].Ref[num], RT_geral.RT_850_DataGridView_ctrl_8[38 + num], array[0]);
							num++;
						}
						while (num <= 3);
						num = 0;
						do
						{
							int num2 = num * 2;
							Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_8[num4 + num5].Periferico_Indice[num], RT_geral.RT_850_DataGridView_ctrl_8[43 + num2], (int)Comunicacao.Buffer_resp[num6 + 52 + num2]);
							Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_8[num4 + num5].Periferico_Modelo[num], RT_geral.RT_850_DataGridView_ctrl_8[42 + num2], (int)Comunicacao.Buffer_resp[num6 + 53 + num2]);
							num++;
						}
						while (num <= 4);
						num = 0;
						do
						{
							int num2 = num * 2;
							array[0] = (int)Comunicacao.Buffer_resp[num6 + 62 + num2];
							Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_850_Ctrl_8[num4 + num5].Crtl_nome[num], RT_geral.RT_850_DataGridView_ctrl_8[6 + num2], array[0]);
							RT_geral.RT_850_Ctrl_8[num4 + num5].Crtl_indice[num].Valor = (int)Comunicacao.Buffer_resp[num6 + 63 + num2];
							num++;
						}
						while (num <= 7);
						num5++;
					}
					while (num5 <= 1);
				}
				else if (pag == 28672)
				{
					int num6 = 3;
					int num = 0;
					do
					{
						int num2 = num * 2;
						array[num] = (int)Comunicacao.Buffer_resp[num6 + num2] * 256 + (int)Comunicacao.Buffer_resp[num6 + 1 + num2];
						num++;
					}
					while (num <= 4);
					RT_geral.Dados_Ctrl_Vista[] rt_850_Vista = RT_geral.RT_850_Vista;
					int num32 = num_bloco + 1;
					int num3 = 0;
					rt_850_Vista[num32].Nome.Valor = Linha_RT.ConverterIntegerArrayToString(ref array, ref num3, 5);
					num6 += 10;
					RT_geral.RT_850_Vista[num_bloco + 1].Canal.Indice = (int)((Comunicacao.Buffer_resp[num6] & 192) / 64);
					RT_geral.RT_850_Vista[num_bloco + 1].Timeout.Indice = (int)((Comunicacao.Buffer_resp[num6] & 56) / 8);
					RT_geral.RT_850_Vista[num_bloco + 1].Prioridade.Indice = (int)(Comunicacao.Buffer_resp[num6] & 7);
					num6++;
					RT_geral.RT_850_Vista[num_bloco + 1].Modelo.Indice = (int)Comunicacao.Buffer_resp[num6];
					num6++;
					RT_geral.RT_850_Vista[num_bloco + 1].Num_var.Valor = (int)Comunicacao.Buffer_resp[num6];
					num6++;
					RT_geral.RT_850_Vista[num_bloco + 1].Num_equip.Valor = (int)Comunicacao.Buffer_resp[num6];
					num6++;
					num = 0;
					do
					{
						int num2 = (int)Comunicacao.Buffer_resp[num6];
						num6++;
						num2 = num2 * 256 + (int)Comunicacao.Buffer_resp[num6];
						RT_geral.RT_850_Vista[num_bloco + 1].Variaveis[num].Indice = num2;
						num6++;
						num++;
					}
					while (num <= 39);
					num = 0;
					do
					{
						RT_geral.RT_850_Vista[num_bloco + 1].Equipamentos[num].Indice = (int)Comunicacao.Buffer_resp[num6];
						num6++;
						num++;
					}
					while (num <= 19);
				}
			}
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00250AD8 File Offset: 0x0024EED8
		public static void CreateComboBoxColumn3(RT_geral.Combo_ictel combo, DataGridViewComboBoxColumn cell)
		{
			cell.Items.Clear();
			int num = 0;
			checked
			{
				int num2 = combo.Numero_itens - 1;
				for (int i = Convert.ToInt32(num); i <= num2; i++)
				{
					cell.Items.Add(combo.itens[i]);
				}
			}
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00250B1C File Offset: 0x0024EF1C
		public static DataGridViewComboBoxColumn CreateComboBoxColumn2(RT_geral.Combo_ictel combo)
		{
			DataGridViewComboBoxColumn dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
			dataGridViewComboBoxColumn.Items.Clear();
			int num = 0;
			checked
			{
				int num2 = combo.Numero_itens - 1;
				for (int i = Convert.ToInt32(num); i <= num2; i++)
				{
					dataGridViewComboBoxColumn.Items.Add(combo.itens[i]);
				}
				return dataGridViewComboBoxColumn;
			}
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00250B68 File Offset: 0x0024EF68
		public static DataGridViewComboBoxColumn CreateComboBoxColumn(string Num, ref RT_geral.DADOS_DATAGRIDVIEW_RT_820[] dados)
		{
			DataGridViewComboBoxColumn dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
			int num = (int)Convert.ToInt16(Num);
			DataGridViewComboBoxColumn dataGridViewComboBoxColumn2 = dataGridViewComboBoxColumn;
			dataGridViewComboBoxColumn2.DataPropertyName = "Col_" + dados[num].NomeColuna;
			dataGridViewComboBoxColumn2.HeaderText = dados[num].TagColuna;
			dataGridViewComboBoxColumn2.Width = dados[num].LarguraColuna;
			dataGridViewComboBoxColumn2.MaxDropDownItems = 6;
			dataGridViewComboBoxColumn2.FlatStyle = FlatStyle.Flat;
			dataGridViewComboBoxColumn2.DefaultCellStyle.Alignment =(System.Windows.Forms.HorizontalAlignment) (System.Windows.Forms.HorizontalAlignment)dados[num].AlingColuna;
			dataGridViewComboBoxColumn2.ReadOnly = false;
			dataGridViewComboBoxColumn2.Items.Clear();
			int numeroLinhaMenu = dados[num].NumeroLinhaMenu;
			checked
			{
				if (numeroLinhaMenu > 0)
				{
					int num2 = 0;
					int num3 = numeroLinhaMenu - 1;
					for (int i = num2; i <= num3; i++)
					{
						string text = dados[num].LinhasMenu[i];
						dataGridViewComboBoxColumn2.Items.Add(text);
					}
				}
				return dataGridViewComboBoxColumn;
			}
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00250C58 File Offset: 0x0024F058
		public static DataGridViewTextBoxColumn CreateTextColumn(string Num, ref RT_geral.DADOS_DATAGRIDVIEW_RT_820[] dados)
		{
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			int num = (int)Convert.ToInt16(Num);
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = dataGridViewTextBoxColumn;
			dataGridViewTextBoxColumn2.DataPropertyName = "Col_" + dados[num].NomeColuna;
			dataGridViewTextBoxColumn2.HeaderText = dados[num].TagColuna;
			dataGridViewTextBoxColumn2.Width = dados[num].LarguraColuna;
			dataGridViewTextBoxColumn2.DefaultCellStyle.Alignment =(System.Windows.Forms.HorizontalAlignment) (System.Windows.Forms.HorizontalAlignment)dados[num].AlingColuna;
			return dataGridViewTextBoxColumn;
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00250CD4 File Offset: 0x0024F0D4
		public static DataGridViewCheckBoxColumn CreateCheckColumn(string Num, ref RT_geral.DADOS_DATAGRIDVIEW_RT_820[] dados)
		{
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2 = dataGridViewCheckBoxColumn;
			dataGridViewCheckBoxColumn2.DataPropertyName = "Col_" + dados[Conversions.ToInteger(Num)].NomeColuna;
			dataGridViewCheckBoxColumn2.HeaderText = dados[Conversions.ToInteger(Num)].TagColuna;
			dataGridViewCheckBoxColumn2.Width = dados[Conversions.ToInteger(Num)].LarguraColuna;
			dataGridViewCheckBoxColumn2.FlatStyle = FlatStyle.Flat;
			dataGridViewCheckBoxColumn2.DefaultCellStyle.Alignment =(System.Windows.Forms.HorizontalAlignment) (System.Windows.Forms.HorizontalAlignment)dados[Conversions.ToInteger(Num)].AlingColuna;
			return dataGridViewCheckBoxColumn;
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00250D64 File Offset: 0x0024F164
		public static void CarregaCombo(ref ComboBox dado, RT_geral.Combo_ictel BD)
		{
			dado.Items.Clear();
			int num = 0;
			checked
			{
				int num2 = BD.Numero_itens - 1;
				for (int i = Convert.ToInt32(num); i <= num2; i++)
				{
					dado.Items.Add(BD.itens[i]);
				}
			}
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00250DAC File Offset: 0x0024F1AC
		public static void CarregaComboBoxED(ref ComboBox destino, RT_geral.Combo_ictel dados)
		{
			destino.Items.Clear();
			int num = 0;
			checked
			{
				int num2 = dados.Numero_itens - 1;
				for (int i = Convert.ToInt32(num); i <= num2; i++)
				{
					destino.Items.Add(dados.itens[i]);
				}
			}
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00250DF4 File Offset: 0x0024F1F4
		public static void ConverterStringToIntegerArray(string texto, ref int[] dados, ref int posicao, int tamanho)
		{
			checked
			{
				int[] array = new int[tamanho - 1 + 1];
				byte[] bytes = Encoding.UTF8.GetBytes(texto);
				int num = bytes.Length;
				int num2 = 0;
				int num3 = 0;
				int num4 = tamanho - 1;
				for (int i = num3; i <= num4; i++)
				{
					int num5 = 0;
					if (num2 < num)
					{
						num5 = (int)bytes[num2];
						num2++;
					}
					else
					{
						num5 = 32;
					}
					if (num2 < num)
					{
						num5 = num5 * 256 + (int)bytes[num2];
						num2++;
					}
					else
					{
						num5 = num5 * 256 + 32;
					}
					dados[posicao] = num5;
					posicao++;
				}
			}
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00250E78 File Offset: 0x0024F278
		public static void ConverterStringToIntegerArray_II(string texto, ref int[] dados, ref int posicao, int tamanho)
		{
			checked
			{
				int[] array = new int[tamanho - 1 + 1];
				byte[] bytes = Encoding.UTF8.GetBytes(texto);
				int num = bytes.Length;
				int num2 = 0;
				int num3 = 0;
				int num4 = tamanho - 1;
				for (int i = num3; i <= num4; i++)
				{
					int num5 = 0;
					if (num2 < num)
					{
						num5 = (int)bytes[num2];
						num2++;
					}
					else
					{
						num5 = 32;
					}
					dados[posicao] = num5;
					posicao++;
				}
			}
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00250ED8 File Offset: 0x0024F2D8
		public static string ConverterIntegerArrayToString(ref int[] dado, ref int posicao, int tamanho)
		{
			checked
			{
				byte[] array = new byte[tamanho * 2 - 1 + 1];
				UTF8Encoding utf8Encoding = new UTF8Encoding();
				int num = 0;
				int num2 = tamanho - 1;
				for (int i = Convert.ToInt32(num); i <= num2; i++)
				{
					array[i * 2] = (byte)(dado[posicao + i] / 256);
					array[i * 2 + 1] = (byte)(dado[posicao + i] % 256);
				}
				int num3 = 0;
				int num4 = tamanho * 2 - 1;
				for (int i = num3; i <= num4; i++)
				{
					if (array[i] < 48 | array[i] > 123 | (array[i] > 58 & array[i] < 65))
					{
						array[i] = 32;
					}
				}
				string @string = Encoding.UTF8.GetString(array);
				posicao += tamanho;
				return @string;
			}
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00250F84 File Offset: 0x0024F384
		public static string ConverterIntegerArrayToString_II(ref int[] dado, ref int posicao, int tamanho)
		{
			checked
			{
				byte[] array = new byte[tamanho - 1 + 1];
				UTF8Encoding utf8Encoding = new UTF8Encoding();
				int num = 0;
				int num2 = tamanho - 1;
				for (int i = Convert.ToInt32(num); i <= num2; i++)
				{
					array[i] = (byte)(dado[i] % 256);
				}
				string @string = Encoding.UTF8.GetString(array);
				posicao = tamanho;
				return @string;
			}
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00250FD8 File Offset: 0x0024F3D8
		public static void AddDadoArrayInteger(ref int[] dado, int item, ref int posicao)
		{
			dado[posicao] = item;
			checked
			{
				posicao++;
			}
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00250FE8 File Offset: 0x0024F3E8
		public static void ExtraiDadoArrayInteger(int dado, ref int item, ref int posicao)
		{
			item = dado;
			checked
			{
				posicao++;
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00250FF4 File Offset: 0x0024F3F4
		public static int Atualiza_Numero_Variaveis_RT850()
		{
			int num = 0;
			bool flag = false;
			int num2 = 0;
			checked
			{
				while (!flag)
				{
					flag = true;
					string valor = RT_geral.Variaveis_RT_850[num2].Nome.Valor;
					byte[] bytes = Encoding.UTF8.GetBytes(valor);
					int num3 = 0;
					int num4 = Strings.Len(valor) - 1;
					for (int i = num3; i <= num4; i++)
					{
						if ((bytes[i] > 64 & bytes[i] < 123) | (bytes[i] > 48 & bytes[i] < 59))
						{
							num++;
							flag = false;
							break;
						}
					}
					num2++;
					if (num2 > 299)
					{
						return num;
					}
				}
				return num;
			}
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0025108C File Offset: 0x0024F48C
		public static void VerificaSeVariavelValida(string texto)
		{
			string text = Strings.Trim(texto);
			if (Strings.Len(text) > 0)
			{
				RT_geral.RT_850_BD.Variaveis_Numero.Valor = checked(RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1);
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x002510CC File Offset: 0x0024F4CC
		public static void Atualiza_Tipo_equipamento(int tipo, int versao)
		{
			if (tipo == 9000)
			{
				RT_geral.IEC_855_BD.Equip.Valor = 856;
				if (versao == 30)
				{
					RT_geral.IEC_855_BD.Versao.Valor = 3;
					RT_geral.IEC_855_BD.Build.Valor = 0;
				}
			}
			else if (tipo == 8000)
			{
				RT_geral.IEC_855_BD.Equip.Valor = 855;
				if (versao == 30)
				{
					RT_geral.IEC_855_BD.Versao.Valor = 3;
					RT_geral.IEC_855_BD.Build.Valor = 0;
				}
			}
			else if (tipo == 1000)
			{
				RT_geral.RT_810_BD.Equip.Valor = 810;
				if (versao == 30)
				{
					RT_geral.RT_810_BD.Versao.Valor = 3;
					RT_geral.RT_810_BD.Build.Valor = 0;
				}
				else
				{
					if (versao != 20)
					{
						RT_geral.RT_810_BD.Equip.Valor = 0;
						RT_geral.RT_810_BD.Versao.Valor = 0;
						RT_geral.RT_810_BD.Build.Valor = 0;
						return;
					}
					RT_geral.RT_810_200_BD.Versao.Valor = 2;
					RT_geral.RT_810_200_BD.Build.Valor = 0;
				}
			}
			else
			{
				if (tipo == 2000)
				{
					RT_geral.RT_820_BD.Equip.Valor = 820;
					switch (versao)
					{
					case 30:
						RT_geral.RT_820_BD.Versao.Valor = 3;
						RT_geral.RT_820_BD.Build.Valor = 0;
						return;
					case 36:
						RT_geral.RT_820_360_BD.Equip.Valor = 820;
						RT_geral.RT_820_360_BD.Versao.Valor = 3;
						RT_geral.RT_820_360_BD.Build.Valor = 6;
						return;
					case 40:
						RT_geral.RT_820_360_BD.Equip.Valor = 820;
						RT_geral.RT_820_360_BD.Versao.Valor = 4;
						RT_geral.RT_820_360_BD.Build.Valor = 0;
						return;
					}
					RT_geral.RT_820_BD.Equip.Valor = 0;
					RT_geral.RT_820_BD.Versao.Valor = 0;
					RT_geral.RT_820_BD.Build.Valor = 0;
					return;
				}
				if (tipo == 3000)
				{
					RT_geral.RT_821_BD.Equip.Valor = 821;
					if (versao != 30)
					{
						RT_geral.RT_821_BD.Equip.Valor = 0;
						RT_geral.RT_821_BD.Versao.Valor = 0;
						RT_geral.RT_821_BD.Build.Valor = 0;
						return;
					}
					RT_geral.RT_821_BD.Versao.Valor = 3;
					RT_geral.RT_821_BD.Build.Valor = 0;
				}
				else if (tipo == 4000)
				{
					RT_geral.RT_850_BD.Equip.Valor = 850;
					if (versao != 30)
					{
						RT_geral.RT_850_BD.Equip.Valor = 0;
						RT_geral.RT_850_BD.Versao.Valor = 0;
						RT_geral.RT_850_BD.Build.Valor = 0;
						return;
					}
					RT_geral.RT_850_BD.Versao.Valor = 3;
					RT_geral.RT_850_BD.Build.Valor = 0;
				}
				else if (tipo == 7000 && versao == 30)
				{
					RT_geral.GC_82x_BD.Equip.Valor = Geral.Equipamento_selecionado;
					RT_geral.GC_82x_BD.Versao.Valor = Geral.Equipamento_versao;
					RT_geral.GC_82x_BD.Build.Valor = 0;
					RT_geral.GC_82x_BD.Release.Valor = 0;
				}
			}
		}

		// Token: 0x04000860 RID: 2144
		public static Linha_RT.Info_equipamento Informacoes_Equipamento;

		// Token: 0x04000861 RID: 2145
		public static int Contador_Erros;

		// Token: 0x04000862 RID: 2146
		public static string diretorio;

		// Token: 0x04000863 RID: 2147
		public static string relatorio_solicitado;

		// Token: 0x02000040 RID: 64
		public struct Info_equipamento
		{
			// Token: 0x04000864 RID: 2148
			public int Equipamento;

			// Token: 0x04000865 RID: 2149
			public int Versao_pri;

			// Token: 0x04000866 RID: 2150
			public int Versao_sec;

			// Token: 0x04000867 RID: 2151
			public int Revisao;

			// Token: 0x04000868 RID: 2152
			public bool Status;

			// Token: 0x04000869 RID: 2153
			public string Versao_texto;
		}
	}
}
