using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x020000A0 RID: 160
	[StandardModule]
	internal sealed class Mod_VA
	{
		// Token: 0x06002763 RID: 10083 RVA: 0x0025F2C8 File Offset: 0x0025D6C8
		public static void Atualiza_dados_VA220_configuracao_geral()
		{
			Mod_VA.Config_VA220.End_mestre = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[4], (int)Comunicacao.Buffer_resp[38], 64);
			Mod_VA.Config_VA220.End_estacao = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[5], (int)Comunicacao.Buffer_resp[38], 32);
			Mod_VA.Config_VA220.Tempo_ptt = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[6], (int)Comunicacao.Buffer_resp[38], 16);
			Mod_VA.Config_VA220.Numero_max_bombas = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[7], (int)Comunicacao.Buffer_resp[38], 8);
			Mod_VA.Config_VA220.Tempo_falha_partida = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[8], (int)Comunicacao.Buffer_resp[38], 4);
			Mod_VA.Config_VA220.Tempo_falha_parada = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[9], (int)Comunicacao.Buffer_resp[38], 2);
			Mod_VA.Config_VA220.Tempo_minimo_operando = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[10], (int)Comunicacao.Buffer_resp[38], 1);
			Mod_VA.Config_VA220.Tempo_minimo_parado = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[11], (int)Comunicacao.Buffer_resp[39], 64);
			Mod_VA.Config_VA220.Tempo_entre_acionamentos = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[12], (int)Comunicacao.Buffer_resp[39], 32);
			Mod_VA.Config_VA220.Modo_operacao = checked(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[13], (int)Comunicacao.Buffer_resp[39], 16) - 1);
			Mod_VA.Config_VA220.Ctrl_nivel_fonte = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[14], (int)Comunicacao.Buffer_resp[39], 8);
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x0025F438 File Offset: 0x0025D838
		public static void Atualiza_dados_VA220_configuracao_IO()
		{
			Mod_VA.Config_VA220.Saidas_digitais[1] = Mod_VA.Identifica_funcao_IO(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[4], (int)Comunicacao.Buffer_resp[38], 64), 1);
			Mod_VA.Config_VA220.Saidas_digitais[2] = Mod_VA.Identifica_funcao_IO(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[5], (int)Comunicacao.Buffer_resp[38], 32), 1);
			Mod_VA.Config_VA220.Saidas_digitais[3] = Mod_VA.Identifica_funcao_IO(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[6], (int)Comunicacao.Buffer_resp[38], 16), 1);
			Mod_VA.Config_VA220.Saidas_digitais[4] = Mod_VA.Identifica_funcao_IO(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[7], (int)Comunicacao.Buffer_resp[38], 8), 1);
			Mod_VA.Config_VA220.Saidas_digitais[5] = Mod_VA.Identifica_funcao_IO(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[8], (int)Comunicacao.Buffer_resp[38], 4), 1);
			Mod_VA.Config_VA220.Saidas_digitais[6] = Mod_VA.Identifica_funcao_IO(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[9], (int)Comunicacao.Buffer_resp[38], 2), 1);
			Mod_VA.Config_VA220.Saidas_digitais[7] = Mod_VA.Identifica_funcao_IO(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[10], (int)Comunicacao.Buffer_resp[38], 1), 1);
			Mod_VA.Config_VA220.Saidas_digitais[8] = Mod_VA.Identifica_funcao_IO(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[11], (int)Comunicacao.Buffer_resp[39], 64), 1);
			Mod_VA.Config_VA220.Entradas_digitais[1] = Mod_VA.Identifica_funcao_IO(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[12], (int)Comunicacao.Buffer_resp[39], 32), 0);
			Mod_VA.Config_VA220.Entradas_digitais[2] = Mod_VA.Identifica_funcao_IO(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[13], (int)Comunicacao.Buffer_resp[39], 16), 0);
			Mod_VA.Config_VA220.Entradas_digitais[3] = Mod_VA.Identifica_funcao_IO(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[14], (int)Comunicacao.Buffer_resp[39], 8), 0);
			Mod_VA.Config_VA220.Entradas_digitais[4] = Mod_VA.Identifica_funcao_IO(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[15], (int)Comunicacao.Buffer_resp[39], 4), 0);
			Mod_VA.Config_VA220.Entradas_digitais[5] = Mod_VA.Identifica_funcao_IO(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[16], (int)Comunicacao.Buffer_resp[39], 2), 0);
			Mod_VA.Config_VA220.Entradas_digitais[6] = Mod_VA.Identifica_funcao_IO(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[17], (int)Comunicacao.Buffer_resp[39], 1), 0);
			Mod_VA.Config_VA220.Entradas_digitais[7] = Mod_VA.Identifica_funcao_IO(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[18], (int)Comunicacao.Buffer_resp[40], 64), 0);
			Mod_VA.Config_VA220.Entradas_digitais[8] = Mod_VA.Identifica_funcao_IO(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[19], (int)Comunicacao.Buffer_resp[40], 32), 0);
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x0025F6C8 File Offset: 0x0025DAC8
		public static void Atualiza_setpoints_VA220()
		{
			checked
			{
				Mod_VA.Operacao_VA220.Nivel_desejado = (int)Math.Round((double)(Comunicacao.Buffer_resp[4] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Nivel_ligar_B1 = (int)Math.Round((double)(Comunicacao.Buffer_resp[5] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Nivel_ligar_B2 = (int)Math.Round((double)(Comunicacao.Buffer_resp[6] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Nivel_ligar_B3 = (int)Math.Round((double)(Comunicacao.Buffer_resp[7] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Nivel_ligar_B4 = (int)Math.Round((double)(Comunicacao.Buffer_resp[8] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Tempo_para_mais_bomba = (int)Math.Round((double)(Comunicacao.Buffer_resp[9] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Pressao_succao = (int)Math.Round((double)(Comunicacao.Buffer_resp[10] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Pressao_recalque = (int)Math.Round((double)(Comunicacao.Buffer_resp[11] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Nivel_desligamento = (int)Math.Round((double)(Comunicacao.Buffer_resp[12] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Nivel_ligamento = (int)Math.Round((double)(Comunicacao.Buffer_resp[13] - 48) / 2.0);
			}
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x0025F84C File Offset: 0x0025DC4C
		public static void Atualiza_alarmes_VA220()
		{
			checked
			{
				if (Comunicacao.Buffer_resp[4] - 48 != 0)
				{
					Mod_VA.Operacao_VA220.hab_verificacao_alarmes = true;
				}
				else
				{
					Mod_VA.Operacao_VA220.hab_verificacao_alarmes = false;
				}
				Mod_VA.Operacao_VA220.Alarmes[1, 2] = (int)Math.Round((double)(Comunicacao.Buffer_resp[5] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Alarmes[2, 2] = (int)Math.Round((double)(Comunicacao.Buffer_resp[6] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Alarmes[3, 2] = (int)Math.Round((double)(Comunicacao.Buffer_resp[7] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Alarmes[4, 2] = (int)Math.Round((double)(Comunicacao.Buffer_resp[8] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Alarmes[1, 1] = (int)Math.Round((double)(Comunicacao.Buffer_resp[9] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Alarmes[2, 1] = (int)Math.Round((double)(Comunicacao.Buffer_resp[10] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Alarmes[3, 1] = (int)Math.Round((double)(Comunicacao.Buffer_resp[11] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Alarmes[4, 1] = (int)Math.Round((double)(Comunicacao.Buffer_resp[12] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Alarmes[5, 2] = (int)Math.Round((double)(Comunicacao.Buffer_resp[13] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Alarmes[5, 1] = (int)Math.Round((double)(Comunicacao.Buffer_resp[14] - 48) / 2.0);
			}
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x0025FA3C File Offset: 0x0025DE3C
		public static void Atualiza_ponta_VA220()
		{
			checked
			{
				if (Comunicacao.Buffer_resp[4] - 48 != 0)
				{
					Mod_VA.Operacao_VA220.hab_verificacao_ponta = true;
				}
				else
				{
					Mod_VA.Operacao_VA220.hab_verificacao_ponta = false;
				}
				Mod_VA.Operacao_VA220.Ponta_liga = Strings.Format((double)(Comunicacao.Buffer_resp[5] - 48) / 2.0, "00") + ":" + Strings.Format((double)(Comunicacao.Buffer_resp[6] - 48) / 2.0, "00");
				Mod_VA.Operacao_VA220.Ponta_Desliga = Strings.Format((double)(Comunicacao.Buffer_resp[7] - 48) / 2.0, "00") + ":" + Strings.Format((double)(Comunicacao.Buffer_resp[8] - 48) / 2.0, "00");
			}
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x0025FB28 File Offset: 0x0025DF28
		public static void Atualiza_relogio_VA220()
		{
			checked
			{
				Mod_VA.Operacao_VA220.relogio = Conversions.ToDate(string.Concat(new string[]
				{
					Strings.Format((int)(Comunicacao.Buffer_resp[6] - 48), "00"),
					"/",
					Strings.Format((int)(Comunicacao.Buffer_resp[5] - 48), "00"),
					"/",
					Strings.Format((int)(Comunicacao.Buffer_resp[4] - 48), "00")
				}));
				Mod_VA.Operacao_VA220.relogio = Conversions.ToDate(string.Concat(new string[]
				{
					Conversions.ToString(Mod_VA.Operacao_VA220.relogio),
					" ",
					Strings.Format((int)(Comunicacao.Buffer_resp[8] - 48), "00"),
					":",
					Strings.Format((int)(Comunicacao.Buffer_resp[9] - 48), "00"),
					":",
					Strings.Format((int)(Comunicacao.Buffer_resp[10] - 48), "00")
				}));
			}
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x0025FC54 File Offset: 0x0025E054
		public static void Atualiza_temp_VA220()
		{
			checked
			{
				if (Comunicacao.Buffer_resp[4] - 48 != 0)
				{
					Mod_VA.Operacao_VA220.hab_verificacao_temp = true;
				}
				else
				{
					Mod_VA.Operacao_VA220.hab_verificacao_temp = false;
				}
				Mod_VA.Operacao_VA220.Temperaturas[1] = (int)Math.Round((double)(Comunicacao.Buffer_resp[5] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Temperaturas[2] = (int)Math.Round((double)(Comunicacao.Buffer_resp[6] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Temperaturas[3] = (int)Math.Round((double)(Comunicacao.Buffer_resp[7] - 48) / 2.0);
				Mod_VA.Operacao_VA220.Temperaturas[4] = (int)Math.Round((double)(Comunicacao.Buffer_resp[8] - 48) / 2.0);
			}
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x0025FD24 File Offset: 0x0025E124
		public static void Atualiza_timer_VA220(int bomba)
		{
			checked
			{
				Mod_VA.Operacao_VA220.Timer_liga[bomba, 1] = Strings.Format((double)(Comunicacao.Buffer_resp[5] - 48) / 2.0, "00") + ":" + Strings.Format((double)(Comunicacao.Buffer_resp[6] - 48) / 2.0, "00");
				Mod_VA.Operacao_VA220.Timer_desliga[bomba, 1] = Strings.Format((double)(Comunicacao.Buffer_resp[7] - 48) / 2.0, "00") + ":" + Strings.Format((double)(Comunicacao.Buffer_resp[8] - 48) / 2.0, "00");
				Mod_VA.Operacao_VA220.Timer_liga[bomba, 2] = Strings.Format((double)(Comunicacao.Buffer_resp[9] - 48) / 2.0, "00") + ":" + Strings.Format((double)(Comunicacao.Buffer_resp[10] - 48) / 2.0, "00");
				Mod_VA.Operacao_VA220.Timer_desliga[bomba, 2] = Strings.Format((double)(Comunicacao.Buffer_resp[11] - 48) / 2.0, "00") + ":" + Strings.Format((double)(Comunicacao.Buffer_resp[12] - 48) / 2.0, "00");
				Mod_VA.Operacao_VA220.Timer_liga[bomba, 3] = Strings.Format((double)(Comunicacao.Buffer_resp[13] - 48) / 2.0, "00") + ":" + Strings.Format((double)(Comunicacao.Buffer_resp[14] - 48) / 2.0, "00");
				Mod_VA.Operacao_VA220.Timer_desliga[bomba, 3] = Strings.Format((double)(Comunicacao.Buffer_resp[15] - 48) / 2.0, "00") + ":" + Strings.Format((double)(Comunicacao.Buffer_resp[16] - 48) / 2.0, "00");
				Mod_VA.Operacao_VA220.Timer_liga[bomba, 4] = Strings.Format((double)(Comunicacao.Buffer_resp[17] - 48) / 2.0, "00") + ":" + Strings.Format((double)(Comunicacao.Buffer_resp[18] - 48) / 2.0, "00");
				Mod_VA.Operacao_VA220.Timer_desliga[bomba, 4] = Strings.Format((double)(Comunicacao.Buffer_resp[19] - 48) / 2.0, "00") + ":" + Strings.Format((double)(Comunicacao.Buffer_resp[20] - 48) / 2.0, "00");
			}
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00260058 File Offset: 0x0025E458
		public static void Atualiza_dados_VA220_leitura_recalque(int versao)
		{
			Mod_VA.Recalque_VA220.Corrente_B1 = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[4], (int)Comunicacao.Buffer_resp[38], 64);
			Mod_VA.Config_VA220.End_estacao = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[5], (int)Comunicacao.Buffer_resp[38], 32);
			Mod_VA.Config_VA220.Tempo_ptt = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[6], (int)Comunicacao.Buffer_resp[38], 16);
			Mod_VA.Config_VA220.Numero_max_bombas = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[7], (int)Comunicacao.Buffer_resp[38], 8);
			Mod_VA.Config_VA220.Tempo_falha_partida = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[8], (int)Comunicacao.Buffer_resp[38], 4);
			Mod_VA.Config_VA220.Tempo_falha_parada = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[9], (int)Comunicacao.Buffer_resp[38], 2);
			Mod_VA.Config_VA220.Tempo_minimo_operando = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[10], (int)Comunicacao.Buffer_resp[38], 1);
			Mod_VA.Config_VA220.Tempo_minimo_parado = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[11], (int)Comunicacao.Buffer_resp[39], 64);
			Mod_VA.Config_VA220.Tempo_entre_acionamentos = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[12], (int)Comunicacao.Buffer_resp[39], 32);
			Mod_VA.Config_VA220.Modo_operacao = checked(Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[13], (int)Comunicacao.Buffer_resp[39], 16) - 1);
			Mod_VA.Config_VA220.Ctrl_nivel_fonte = Mod_VA.Retira_BASE((int)Comunicacao.Buffer_resp[14], (int)Comunicacao.Buffer_resp[39], 8);
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x002601C8 File Offset: 0x0025E5C8
		public static int Retira_BASE(int dado, int ctrl, int posicao)
		{
			checked
			{
				int result;
				if ((ctrl - 48 & posicao) != 0)
				{
					result = dado - 48;
				}
				else
				{
					result = dado;
				}
				return result;
			}
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x002601E8 File Offset: 0x0025E5E8
		public static int Identifica_funcao_IO(int valor, int tipo)
		{
			checked
			{
				if (tipo == 0)
				{
					int num = valor;
					if (num != 0)
					{
						if (num >= 17 && num <= 20)
						{
							valor -= 16;
						}
						else if (num >= 33 && num <= 36)
						{
							valor -= 28;
						}
						else if (num >= 49 && num <= 52)
						{
							valor -= 40;
						}
						else if (num >= 113 && num <= 116)
						{
							valor -= 92;
						}
						else if (num == 64)
						{
							valor -= 39;
						}
						else if (num == 80)
						{
							valor -= 54;
						}
						else if (num == 96)
						{
							valor -= 69;
						}
						else if (num == 128)
						{
							valor -= 100;
						}
						else if (num == 144)
						{
							valor -= 115;
						}
					}
				}
				else
				{
					int num2 = valor;
					if (num2 != 0)
					{
						if (num2 >= 17 && num2 <= 20)
						{
							valor -= 16;
						}
						else if (num2 >= 33 && num2 <= 36)
						{
							valor -= 28;
						}
						else if (num2 >= 49 && num2 <= 52)
						{
							valor -= 40;
						}
						else if (num2 >= 113 && num2 <= 116)
						{
							valor -= 92;
						}
					}
				}
				return valor;
			}
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x002602F4 File Offset: 0x0025E6F4
		public static int Monta_funcao_IO(int valor, int tipo)
		{
			checked
			{
				if (tipo == 0)
				{
					switch (valor)
					{
					case 1:
					case 2:
					case 3:
					case 4:
						valor += 16;
						break;
					case 5:
					case 6:
					case 7:
					case 8:
						valor += 28;
						break;
					case 9:
					case 10:
					case 11:
					case 12:
						valor += 40;
						break;
					case 13:
					case 14:
					case 15:
					case 16:
						valor += 92;
						break;
					case 25:
						valor += 39;
						break;
					case 26:
						valor += 54;
						break;
					case 27:
						valor += 69;
						break;
					case 28:
						valor += 100;
						break;
					case 29:
						valor += 115;
						break;
					}
				}
				else
				{
					switch (valor)
					{
					case 1:
					case 2:
					case 3:
					case 4:
						valor += 16;
						break;
					case 5:
					case 6:
					case 7:
					case 8:
						valor += 28;
						break;
					case 9:
					case 10:
					case 11:
					case 12:
						valor += 40;
						break;
					case 13:
					case 14:
					case 15:
					case 16:
						valor += 92;
						break;
					}
				}
				return valor;
			}
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x0026045C File Offset: 0x0025E85C
		public static void Monta_buffer_conf_geral(int[] dados)
		{
			dados[0] = Mod_VA.Config_VA220.End_mestre;
			dados[1] = Mod_VA.Config_VA220.End_estacao;
			dados[2] = Mod_VA.Config_VA220.Tempo_ptt;
			dados[3] = Mod_VA.Config_VA220.Numero_max_bombas;
			dados[4] = Mod_VA.Config_VA220.Tempo_falha_partida;
			dados[5] = Mod_VA.Config_VA220.Tempo_falha_parada;
			dados[6] = Mod_VA.Config_VA220.Tempo_minimo_operando;
			dados[7] = Mod_VA.Config_VA220.Tempo_minimo_parado;
			dados[8] = Mod_VA.Config_VA220.Tempo_entre_acionamentos;
			dados[9] = checked(Mod_VA.Config_VA220.Modo_operacao + 1);
			dados[10] = Mod_VA.Config_VA220.Ctrl_nivel_fonte;
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x002604FC File Offset: 0x0025E8FC
		public static void Monta_buffer_conf_IO(int[] dados)
		{
			dados[0] = Mod_VA.Monta_funcao_IO(Mod_VA.Config_VA220.Saidas_digitais[1], 1);
			dados[1] = Mod_VA.Monta_funcao_IO(Mod_VA.Config_VA220.Saidas_digitais[2], 1);
			dados[2] = Mod_VA.Monta_funcao_IO(Mod_VA.Config_VA220.Saidas_digitais[3], 1);
			dados[3] = Mod_VA.Monta_funcao_IO(Mod_VA.Config_VA220.Saidas_digitais[4], 1);
			dados[4] = Mod_VA.Monta_funcao_IO(Mod_VA.Config_VA220.Saidas_digitais[5], 1);
			dados[5] = Mod_VA.Monta_funcao_IO(Mod_VA.Config_VA220.Saidas_digitais[6], 1);
			dados[6] = Mod_VA.Monta_funcao_IO(Mod_VA.Config_VA220.Saidas_digitais[7], 1);
			dados[7] = Mod_VA.Monta_funcao_IO(Mod_VA.Config_VA220.Saidas_digitais[8], 1);
			dados[8] = Mod_VA.Monta_funcao_IO(Mod_VA.Config_VA220.Entradas_digitais[1], 0);
			dados[9] = Mod_VA.Monta_funcao_IO(Mod_VA.Config_VA220.Entradas_digitais[2], 0);
			dados[10] = Mod_VA.Monta_funcao_IO(Mod_VA.Config_VA220.Entradas_digitais[3], 0);
			dados[11] = Mod_VA.Monta_funcao_IO(Mod_VA.Config_VA220.Entradas_digitais[4], 0);
			dados[12] = Mod_VA.Monta_funcao_IO(Mod_VA.Config_VA220.Entradas_digitais[5], 0);
			dados[13] = Mod_VA.Monta_funcao_IO(Mod_VA.Config_VA220.Entradas_digitais[6], 0);
			dados[14] = Mod_VA.Monta_funcao_IO(Mod_VA.Config_VA220.Entradas_digitais[7], 0);
			dados[15] = Mod_VA.Monta_funcao_IO(Mod_VA.Config_VA220.Entradas_digitais[8], 0);
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00260660 File Offset: 0x0025EA60
		public static void Monta_buffer_setpoint(int[] dados)
		{
			checked
			{
				dados[0] = Mod_VA.Operacao_VA220.Nivel_desejado * 2;
				dados[1] = Mod_VA.Operacao_VA220.Nivel_ligar_B1 * 2;
				dados[2] = Mod_VA.Operacao_VA220.Nivel_ligar_B2 * 2;
				dados[3] = Mod_VA.Operacao_VA220.Nivel_ligar_B3 * 2;
				dados[4] = Mod_VA.Operacao_VA220.Nivel_ligar_B4 * 2;
				dados[5] = Mod_VA.Operacao_VA220.Tempo_para_mais_bomba * 2;
				dados[6] = Mod_VA.Operacao_VA220.Pressao_succao * 2;
				dados[7] = Mod_VA.Operacao_VA220.Pressao_recalque * 2;
				dados[8] = Mod_VA.Operacao_VA220.Nivel_desligamento * 2;
				dados[9] = Mod_VA.Operacao_VA220.Nivel_ligamento * 2;
			}
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00260704 File Offset: 0x0025EB04
		public static void Monta_buffer_alarmes(int[] dados)
		{
			if (Mod_VA.Operacao_VA220.hab_verificacao_alarmes)
			{
				dados[0] = 1;
			}
			else
			{
				dados[0] = 0;
			}
			checked
			{
				dados[1] = Mod_VA.Operacao_VA220.Alarmes[1, 2] * 2;
				dados[2] = Mod_VA.Operacao_VA220.Alarmes[2, 2] * 2;
				dados[3] = Mod_VA.Operacao_VA220.Alarmes[3, 2] * 2;
				dados[4] = Mod_VA.Operacao_VA220.Alarmes[4, 2] * 2;
				dados[5] = Mod_VA.Operacao_VA220.Alarmes[1, 1] * 2;
				dados[6] = Mod_VA.Operacao_VA220.Alarmes[2, 1] * 2;
				dados[7] = Mod_VA.Operacao_VA220.Alarmes[3, 1] * 2;
				dados[8] = Mod_VA.Operacao_VA220.Alarmes[4, 1] * 2;
				dados[9] = Mod_VA.Operacao_VA220.Alarmes[5, 2] * 2;
				dados[10] = Mod_VA.Operacao_VA220.Alarmes[5, 1] * 2;
			}
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x00260808 File Offset: 0x0025EC08
		public static void Monta_buffer_ponta(int[] dados)
		{
			if (Mod_VA.Operacao_VA220.hab_verificacao_ponta)
			{
				dados[0] = 1;
			}
			else
			{
				dados[0] = 0;
			}
			checked
			{
				dados[1] = DateAndTime.Hour(Conversions.ToDate(Mod_VA.Operacao_VA220.Ponta_liga)) * 2;
				dados[2] = DateAndTime.Minute(Conversions.ToDate(Mod_VA.Operacao_VA220.Ponta_liga)) * 2;
				dados[3] = DateAndTime.Hour(Conversions.ToDate(Mod_VA.Operacao_VA220.Ponta_Desliga)) * 2;
				dados[4] = DateAndTime.Minute(Conversions.ToDate(Mod_VA.Operacao_VA220.Ponta_Desliga)) * 2;
			}
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x00260890 File Offset: 0x0025EC90
		public static void Monta_buffer_temperatura(int[] dados)
		{
			if (Mod_VA.Operacao_VA220.hab_verificacao_temp)
			{
				dados[0] = 1;
			}
			else
			{
				dados[0] = 0;
			}
			checked
			{
				dados[1] = Mod_VA.Operacao_VA220.Temperaturas[1] * 2;
				dados[2] = Mod_VA.Operacao_VA220.Temperaturas[2] * 2;
				dados[3] = Mod_VA.Operacao_VA220.Temperaturas[3] * 2;
				dados[4] = Mod_VA.Operacao_VA220.Temperaturas[4] * 2;
			}
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x002608F8 File Offset: 0x0025ECF8
		public static void Monta_buffer_timer(int[] dados, int bomba)
		{
			dados[0] = bomba;
			checked
			{
				dados[1] = DateAndTime.Hour(Conversions.ToDate(Mod_VA.Operacao_VA220.Timer_liga[bomba, 1])) * 2;
				dados[2] = DateAndTime.Minute(Conversions.ToDate(Mod_VA.Operacao_VA220.Timer_liga[bomba, 1])) * 2;
				dados[3] = DateAndTime.Hour(Conversions.ToDate(Mod_VA.Operacao_VA220.Timer_desliga[bomba, 1])) * 2;
				dados[4] = DateAndTime.Minute(Conversions.ToDate(Mod_VA.Operacao_VA220.Timer_desliga[bomba, 1])) * 2;
				dados[5] = DateAndTime.Hour(Conversions.ToDate(Mod_VA.Operacao_VA220.Timer_liga[bomba, 2])) * 2;
				dados[6] = DateAndTime.Minute(Conversions.ToDate(Mod_VA.Operacao_VA220.Timer_liga[bomba, 2])) * 2;
				dados[7] = DateAndTime.Hour(Conversions.ToDate(Mod_VA.Operacao_VA220.Timer_desliga[bomba, 2])) * 2;
				dados[8] = DateAndTime.Minute(Conversions.ToDate(Mod_VA.Operacao_VA220.Timer_desliga[bomba, 2])) * 2;
				dados[9] = DateAndTime.Hour(Conversions.ToDate(Mod_VA.Operacao_VA220.Timer_liga[bomba, 3])) * 2;
				dados[10] = DateAndTime.Minute(Conversions.ToDate(Mod_VA.Operacao_VA220.Timer_liga[bomba, 3])) * 2;
				dados[11] = DateAndTime.Hour(Conversions.ToDate(Mod_VA.Operacao_VA220.Timer_desliga[bomba, 3])) * 2;
				dados[12] = DateAndTime.Minute(Conversions.ToDate(Mod_VA.Operacao_VA220.Timer_desliga[bomba, 3])) * 2;
				dados[13] = DateAndTime.Hour(Conversions.ToDate(Mod_VA.Operacao_VA220.Timer_liga[bomba, 4])) * 2;
				dados[14] = DateAndTime.Minute(Conversions.ToDate(Mod_VA.Operacao_VA220.Timer_liga[bomba, 4])) * 2;
				dados[15] = DateAndTime.Hour(Conversions.ToDate(Mod_VA.Operacao_VA220.Timer_desliga[bomba, 4])) * 2;
				dados[16] = DateAndTime.Minute(Conversions.ToDate(Mod_VA.Operacao_VA220.Timer_desliga[bomba, 4])) * 2;
			}
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x00260B14 File Offset: 0x0025EF14
		public static void Monta_buffer_relogio(int[] dados)
		{
			dados[0] = checked(DateAndTime.Year(Mod_VA.Operacao_VA220.relogio) - 2000);
			dados[1] = DateAndTime.Month(Mod_VA.Operacao_VA220.relogio);
			dados[2] = DateAndTime.Day(Mod_VA.Operacao_VA220.relogio);
			dados[3] = DateAndTime.Weekday(Mod_VA.Operacao_VA220.relogio, 1);
			dados[4] = DateAndTime.Hour(Mod_VA.Operacao_VA220.relogio);
			dados[5] = DateAndTime.Minute(Mod_VA.Operacao_VA220.relogio);
			dados[6] = 0;
		}

		// Token: 0x04001B57 RID: 6999
		public const int END_ESTACAO_VA_MAXIMO = 200;

		// Token: 0x04001B58 RID: 7000
		public const int END_ESTACAO_VA_MINIMO = 0;

		// Token: 0x04001B59 RID: 7001
		public const int END_MESTRE_VA_MAXIMO = 200;

		// Token: 0x04001B5A RID: 7002
		public const int END_MESTRE_VA_MINIMO = 0;

		// Token: 0x04001B5B RID: 7003
		public const int MAX_PTT_VA = 100;

		// Token: 0x04001B5C RID: 7004
		public const int MIN_PTT_VA = 0;

		// Token: 0x04001B5D RID: 7005
		public const int MIN_MAX_BOMBAS_VA = 0;

		// Token: 0x04001B5E RID: 7006
		public const int MAX_MAX_BOMBAS_VA = 4;

		// Token: 0x04001B5F RID: 7007
		public const int MIN_TEMPO_ACIONAMENTOS_VA = 0;

		// Token: 0x04001B60 RID: 7008
		public const int MAX_TEMPO_ACIONAMENTOS_VA = 200;

		// Token: 0x04001B61 RID: 7009
		public const int MIN_TEMPO_FALHA_DESLIGAR_VA = 0;

		// Token: 0x04001B62 RID: 7010
		public const int MAX_TEMPO_FALHA_DESLIGAR_VA = 200;

		// Token: 0x04001B63 RID: 7011
		public const int MIN_TEMPO_FALHA_LIGAR_VA = 0;

		// Token: 0x04001B64 RID: 7012
		public const int MAX_TEMPO_FALHA_LIGAR_VA = 200;

		// Token: 0x04001B65 RID: 7013
		public const int MIN_TEMPO_OPERANDO_VA = 0;

		// Token: 0x04001B66 RID: 7014
		public const int MAX_TEMPO_OPERANDO_VA = 200;

		// Token: 0x04001B67 RID: 7015
		public const int MIN_TEMPO_PARADO_VA = 0;

		// Token: 0x04001B68 RID: 7016
		public const int MAX_TEMPO_PARADO_VA = 200;

		// Token: 0x04001B69 RID: 7017
		public const int MIN_NIVEL = 0;

		// Token: 0x04001B6A RID: 7018
		public const int MAX_NIVEL = 100;

		// Token: 0x04001B6B RID: 7019
		public const int MIN_TEMPO_MAIS_BOMBA = 0;

		// Token: 0x04001B6C RID: 7020
		public const int MAX_TEMPO_MAIS_BOMBA = 180;

		// Token: 0x04001B6D RID: 7021
		public const int MIN_PRESSAO = 5;

		// Token: 0x04001B6E RID: 7022
		public const int MAX_PRESSAO = 30;

		// Token: 0x04001B6F RID: 7023
		public const int MIN_TEMP = 0;

		// Token: 0x04001B70 RID: 7024
		public const int MAX_TEMP = 100;

		// Token: 0x04001B71 RID: 7025
		public const int MIN_ALM = 0;

		// Token: 0x04001B72 RID: 7026
		public const int MAX_ALM = 100;

		// Token: 0x04001B73 RID: 7027
		public const int MASCARA_BIT_8 = 128;

		// Token: 0x04001B74 RID: 7028
		public const int MASCARA_BIT_7 = 64;

		// Token: 0x04001B75 RID: 7029
		public const int MASCARA_BIT_6 = 32;

		// Token: 0x04001B76 RID: 7030
		public const int MASCARA_BIT_5 = 16;

		// Token: 0x04001B77 RID: 7031
		public const int MASCARA_BIT_4 = 8;

		// Token: 0x04001B78 RID: 7032
		public const int MASCARA_BIT_3 = 4;

		// Token: 0x04001B79 RID: 7033
		public const int MASCARA_BIT_2 = 2;

		// Token: 0x04001B7A RID: 7034
		public const int MASCARA_BIT_1 = 1;

		// Token: 0x04001B7B RID: 7035
		public const int ENTRADA_DIGITAL = 0;

		// Token: 0x04001B7C RID: 7036
		public const int SAIDA_DIGITAL = 1;

		// Token: 0x04001B7D RID: 7037
		public const int TAMANHO_ESC_CONF_GERAL = 11;

		// Token: 0x04001B7E RID: 7038
		public const int TAMANHO_ESC_CONF_IO = 16;

		// Token: 0x04001B7F RID: 7039
		public const int END_ORIGEM_VA_MAXIMO = 200;

		// Token: 0x04001B80 RID: 7040
		public const int END_ORIGEM_VA_MINIMO = 0;

		// Token: 0x04001B81 RID: 7041
		public const int NUMERO_MAX_RECALQUE_VA_MAXIMO = 40;

		// Token: 0x04001B82 RID: 7042
		public const int NUMERO_MAX_RECALQUE_VA_MINIMO = 0;

		// Token: 0x04001B83 RID: 7043
		public const int TEMPO_VARREDURA_VA_MAXIMO = 200;

		// Token: 0x04001B84 RID: 7044
		public const int TEMPO_VARREDURA_VA_MINIMO = 3;

		// Token: 0x04001B85 RID: 7045
		public const int VALOR_ESCALA_VA_MAXIMO = 9999;

		// Token: 0x04001B86 RID: 7046
		public const int VALOR_ESCALA_VA_MINIMO = 0;

		// Token: 0x04001B87 RID: 7047
		public const int VALOR_INIT_ESCALA = 100;

		// Token: 0x04001B88 RID: 7048
		public const int VALOR_PRESSIOSTATO_VA_MAXIMO = 9999;

		// Token: 0x04001B89 RID: 7049
		public const int VALOR_PRESSIOSTATO_VA_MINIMO = 0;

		// Token: 0x04001B8A RID: 7050
		public const int VALOR_PRESSIOSTATO_VA_PADRAO = 1000;

		// Token: 0x04001B8B RID: 7051
		public const int TEMPO_SEM_COMUNICACAO_VA_MAXIMO = 200;

		// Token: 0x04001B8C RID: 7052
		public const int TEMPO_SEM_COMUNICACAO_VA_MINIMO = 0;

		// Token: 0x04001B8D RID: 7053
		public const int NUM_GRUPOS_VA_MAXIMO = 16;

		// Token: 0x04001B8E RID: 7054
		public const int NUM_GRUPOS_VA_MINIMO = 0;

		// Token: 0x04001B8F RID: 7055
		public static Mod_VA.DADOS_EQUIP_VA_220_CONFIG Config_VA220;

		// Token: 0x04001B90 RID: 7056
		public static Mod_VA.DADOS_EQUIP_VA_220_OPERACAO Operacao_VA220;

		// Token: 0x04001B91 RID: 7057
		public static Mod_VA.DADOS_EQUIP_VA_230_CONFIG Config_VA230;

		// Token: 0x04001B92 RID: 7058
		public static Mod_VA.DADOS_EQUIP_VA_210_CONFIG Config_VA210;

		// Token: 0x04001B93 RID: 7059
		public static Mod_VA.DADOS_EQUIP_VA_220_RECALQUE Recalque_VA220;

		// Token: 0x020000A1 RID: 161
		public struct DADOS_EQUIP_VA_220_CONFIG
		{
			// Token: 0x04001B94 RID: 7060
			public int End_estacao;

			// Token: 0x04001B95 RID: 7061
			public int End_mestre;

			// Token: 0x04001B96 RID: 7062
			public int Tempo_ptt;

			// Token: 0x04001B97 RID: 7063
			public int Numero_max_bombas;

			// Token: 0x04001B98 RID: 7064
			public int Tempo_falha_partida;

			// Token: 0x04001B99 RID: 7065
			public int Tempo_falha_parada;

			// Token: 0x04001B9A RID: 7066
			public int Tempo_minimo_operando;

			// Token: 0x04001B9B RID: 7067
			public int Tempo_minimo_parado;

			// Token: 0x04001B9C RID: 7068
			public int Tempo_entre_acionamentos;

			// Token: 0x04001B9D RID: 7069
			public int Modo_operacao;

			// Token: 0x04001B9E RID: 7070
			public int Ctrl_nivel_fonte;

			// Token: 0x04001B9F RID: 7071
			public int[] Entradas_digitais;

			// Token: 0x04001BA0 RID: 7072
			public int[] Saidas_digitais;
		}

		// Token: 0x020000A2 RID: 162
		public struct DADOS_EQUIP_VA_220_OPERACAO
		{
			// Token: 0x04001BA1 RID: 7073
			public int End_estacao;

			// Token: 0x04001BA2 RID: 7074
			public int End_mestre;

			// Token: 0x04001BA3 RID: 7075
			public bool Hab_setpoint;

			// Token: 0x04001BA4 RID: 7076
			public bool Hab_timer;

			// Token: 0x04001BA5 RID: 7077
			public bool Hab_ponta;

			// Token: 0x04001BA6 RID: 7078
			public bool Hab_alarmes;

			// Token: 0x04001BA7 RID: 7079
			public bool Hab_temp;

			// Token: 0x04001BA8 RID: 7080
			public int Nivel_desejado;

			// Token: 0x04001BA9 RID: 7081
			public int Nivel_ligar_B1;

			// Token: 0x04001BAA RID: 7082
			public int Nivel_ligar_B2;

			// Token: 0x04001BAB RID: 7083
			public int Nivel_ligar_B3;

			// Token: 0x04001BAC RID: 7084
			public int Nivel_ligar_B4;

			// Token: 0x04001BAD RID: 7085
			public int Nivel_desligamento;

			// Token: 0x04001BAE RID: 7086
			public int Nivel_ligamento;

			// Token: 0x04001BAF RID: 7087
			public int Tempo_para_mais_bomba;

			// Token: 0x04001BB0 RID: 7088
			public int Pressao_succao;

			// Token: 0x04001BB1 RID: 7089
			public int Pressao_recalque;

			// Token: 0x04001BB2 RID: 7090
			public string[,] Timer_liga;

			// Token: 0x04001BB3 RID: 7091
			public string[,] Timer_desliga;

			// Token: 0x04001BB4 RID: 7092
			public bool hab_verificacao_alarmes;

			// Token: 0x04001BB5 RID: 7093
			public int[,] Alarmes;

			// Token: 0x04001BB6 RID: 7094
			public bool hab_verificacao_ponta;

			// Token: 0x04001BB7 RID: 7095
			public string Ponta_liga;

			// Token: 0x04001BB8 RID: 7096
			public string Ponta_Desliga;

			// Token: 0x04001BB9 RID: 7097
			public bool hab_verificacao_temp;

			// Token: 0x04001BBA RID: 7098
			public int[] Temperaturas;

			// Token: 0x04001BBB RID: 7099
			public DateTime relogio;

			// Token: 0x04001BBC RID: 7100
			public int bomba;
		}

		// Token: 0x020000A3 RID: 163
		public struct DADOS_EQUIP_VA_220_RECALQUE
		{
			// Token: 0x04001BBD RID: 7101
			public int Corrente_B1;

			// Token: 0x04001BBE RID: 7102
			public int Corrente_B2;

			// Token: 0x04001BBF RID: 7103
			public int Corrente_B3;

			// Token: 0x04001BC0 RID: 7104
			public int Corrente_B4;

			// Token: 0x04001BC1 RID: 7105
			public int Tensao;

			// Token: 0x04001BC2 RID: 7106
			public int Vazao;

			// Token: 0x04001BC3 RID: 7107
			public int Pressao_suc;

			// Token: 0x04001BC4 RID: 7108
			public int Pressao_rec;

			// Token: 0x04001BC5 RID: 7109
			public int analogica_13;

			// Token: 0x04001BC6 RID: 7110
			public int analogica_14;

			// Token: 0x04001BC7 RID: 7111
			public int analogica_15;

			// Token: 0x04001BC8 RID: 7112
			public int analogica_16;

			// Token: 0x04001BC9 RID: 7113
			public int Status_Inst_1;

			// Token: 0x04001BCA RID: 7114
			public int Status_Inst_2;

			// Token: 0x04001BCB RID: 7115
			public int Status_B1;

			// Token: 0x04001BCC RID: 7116
			public int Status_B2;

			// Token: 0x04001BCD RID: 7117
			public int Status_B3;

			// Token: 0x04001BCE RID: 7118
			public int Status_B4;

			// Token: 0x04001BCF RID: 7119
			public int Status_V12;

			// Token: 0x04001BD0 RID: 7120
			public int Status_V34;

			// Token: 0x04001BD1 RID: 7121
			public int Saida_DA_1;

			// Token: 0x04001BD2 RID: 7122
			public int Saida_DA_2;

			// Token: 0x04001BD3 RID: 7123
			public int Saida_DA_3;

			// Token: 0x04001BD4 RID: 7124
			public int Saida_DA_4;
		}

		// Token: 0x020000A4 RID: 164
		public struct DADOS_EQUIP_VA_230_CONFIG
		{
			// Token: 0x04001BD5 RID: 7125
			public int End_origem;

			// Token: 0x04001BD6 RID: 7126
			public int Numero_recalques;

			// Token: 0x04001BD7 RID: 7127
			public int Tempo_varredura;

			// Token: 0x04001BD8 RID: 7128
			public int[,] Escalas;

			// Token: 0x04001BD9 RID: 7129
			public int Indice;
		}

		// Token: 0x020000A5 RID: 165
		public struct DADOS_EQUIP_VA_210_CONFIG
		{
			// Token: 0x04001BDA RID: 7130
			public int End_mestre;

			// Token: 0x04001BDB RID: 7131
			public int Tipo_leitura;

			// Token: 0x04001BDC RID: 7132
			public int Altura_pressiostato;

			// Token: 0x04001BDD RID: 7133
			public int Altura_nivel_baixo;

			// Token: 0x04001BDE RID: 7134
			public int Altura_nivel_alto;

			// Token: 0x04001BDF RID: 7135
			public int Tempo_max_sem_comunicacao;

			// Token: 0x04001BE0 RID: 7136
			public int Num_grupos;

			// Token: 0x04001BE1 RID: 7137
			public int[] grupos;
		}
	}
}
