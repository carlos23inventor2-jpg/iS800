using System;
using System.Drawing;
using System.Windows.Forms;
using iS800.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x02000056 RID: 86
	[StandardModule]
	public sealed class RT_geral
	{
		// Token: 0x06001A42 RID: 6722 RVA: 0x00252914 File Offset: 0x00250D14
		public static RT_geral.Ctrl_erro Limite_ok_text_box(ref TextBox obj, ref RT_geral.Integer_ictel dado, bool mostra)
		{
			RT_geral.Ctrl_erro result = new RT_geral.Ctrl_erro();
			if (!RT_geral.Lmte_Init_ok)
			{
				result.resultado = false;
				result.msg = "";
				result.color = Color.Black;
			}
			else
			{
				if (dado.Valor >= dado.Lmte_inf & dado.Valor <= dado.Lmte_sup)
				{
					obj.ForeColor = Color.Black;
					result.resultado = true;
					result.msg = "";
					result.color = Color.Black;
					dado.erro = false;
				}
				else
				{
					obj.ForeColor = Color.Red;
					result.resultado = false;
					result.msg = string.Concat(new string[]
					{
						"Parâmetro: ",
						dado.nome,
						" fora dos limites!\r\nmínimo: ",
						Conversions.ToString(dado.Lmte_inf),
						"    máximo: ",
						Conversions.ToString(dado.Lmte_sup)
					});
					result.color = Color.Red;
					dado.erro = true;
				}
				if (mostra)
				{
					Interaction.MsgBox(result.msg, (MsgBoxStyle)16, "Atenção - Erro de configuração: ");
				}
			}
			return result;
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x00252A38 File Offset: 0x00250E38
		public static RT_geral.Ctrl_erro Limite_ok_NumericUpDown(ref NumericUpDown obj, ref RT_geral.Integer_ictel dado, bool mostra)
		{
			RT_geral.Ctrl_erro result = new RT_geral.Ctrl_erro();
			if (!RT_geral.Lmte_Init_ok)
			{
				result.resultado = false;
				result.msg = "";
				result.color = Color.Black;
			}
			else
			{
				if (dado.Valor >= dado.Lmte_inf & dado.Valor <= dado.Lmte_sup)
				{
					obj.ForeColor = Color.Black;
					result.resultado = true;
					result.msg = "";
					result.color = Color.Black;
					dado.erro = false;
				}
				else
				{
					obj.ForeColor = Color.Red;
					result.resultado = false;
					result.msg = string.Concat(new string[]
					{
						"Parâmetro: ",
						dado.nome,
						" fora dos limites!\r\nmínimo: ",
						Conversions.ToString(dado.Lmte_inf),
						"    máximo: ",
						Conversions.ToString(dado.Lmte_sup)
					});
					result.color = Color.Red;
					dado.erro = true;
				}
				if (mostra & !result.resultado)
				{
					Interaction.MsgBox(result.msg, (MsgBoxStyle)16, "Atenção - Erro de configuração");
				}
			}
			return result;
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x00252B68 File Offset: 0x00250F68
		public static RT_geral.Ctrl_erro Limite_ok_Combo_valor(ref ComboBox obj, ref RT_geral.Combo_ictel dado, bool mostra, int novo)
		{
			RT_geral.Ctrl_erro result = new RT_geral.Ctrl_erro();
			result.msg = "";
			int num = 0;
			checked
			{
				int num2 = dado.Numero_itens - 1;
				for (int i = num; i <= num2; i++)
				{
					if (novo == dado.valores[i])
					{
						dado.Indice = i;
						dado.Valor = dado.valores[i];
						obj.ForeColor = Color.Black;
						result.resultado = true;
						result.msg = "";
						result.color = Color.Black;
						dado.erro = false;
					}
					else if (i <= dado.Numero_itens - 1)
					{
						obj.ForeColor = Color.Red;
						result.resultado = false;
						result.msg = "Parâmetro: " + dado.nome + " fora dos limites!";
						result.color = Color.Red;
						dado.erro = true;
					}
				}
				if (mostra & !result.resultado)
				{
					Interaction.MsgBox(result.msg, (MsgBoxStyle)16, "Atenção - Erro de configuração");
				}
				return result;
			}
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00252C64 File Offset: 0x00251064
		public static RT_geral.Ctrl_erro Limite_ok_celula(ref DataGridView obj, ref RT_geral.Integer_ictel dado, DataGridViewCellValidatingEventArgs e, bool mostra)
		{
			RT_geral.Ctrl_erro result = new RT_geral.Ctrl_erro();
			if (!RT_geral.Lmte_Init_ok)
			{
				result.resultado = false;
				result.msg = "";
				result.color = Color.Black;
			}
			else
			{
				if (dado.Valor >= dado.Lmte_inf & dado.Valor <= dado.Lmte_sup)
				{
					obj.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
					result.resultado = true;
					result.msg = "";
					result.color = Color.Black;
					dado.erro = false;
				}
				else
				{
					obj.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
					result.resultado = false;
					result.msg = string.Concat(new string[]
					{
						"Parâmetro: ",
						dado.nome,
						" fora dos limites!\r\nmínimo: ",
						Conversions.ToString(dado.Lmte_inf),
						"    máximo: ",
						Conversions.ToString(dado.Lmte_sup)
					});
					result.color = Color.Red;
					dado.erro = true;
				}
				if (mostra & !result.resultado)
				{
					Interaction.MsgBox(result.msg, (MsgBoxStyle)16, "Atenção - Erro de configuração");
				}
			}
			return result;
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00252DE0 File Offset: 0x002511E0
		public static RT_geral.Ctrl_erro Limite_ok_Combo_text(ref ComboBox obj, ref RT_geral.Combo_ictel dado, bool mostra, int novo)
		{
			RT_geral.Ctrl_erro result = new RT_geral.Ctrl_erro();
			result.msg = "";
			int num = 0;
			checked
			{
				int num2 = dado.Numero_itens - 1;
				for (int i = num; i <= num2; i++)
				{
					if (novo == dado.valores[i])
					{
						dado.Indice = i;
						dado.Valor = dado.valores[i];
						obj.ForeColor = Color.Black;
						result.resultado = true;
						result.msg = "";
						result.color = Color.Black;
						dado.erro = false;
					}
					else if (i <= dado.Numero_itens - 1)
					{
						obj.ForeColor = Color.Red;
						result.resultado = false;
						result.msg = "Parâmetro: " + dado.nome + " fora dos limites!";
						result.color = Color.Red;
						dado.erro = true;
					}
				}
				if (mostra & !result.resultado)
				{
					Interaction.MsgBox(result.msg, (MsgBoxStyle)16, "Atenção - Erro de configuração");
				}
				return result;
			}
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00252EDC File Offset: 0x002512DC
		public static RT_geral.Ctrl_erro Testa_nome_dsp_3DIG(ref DataGridView obj, ref RT_geral.String_ictel dado, DataGridViewCellValidatingEventArgs e, bool mostra)
		{
			RT_geral.Ctrl_erro result = new RT_geral.Ctrl_erro();
			if (!RT_geral.Lmte_Init_ok)
			{
				result.resultado = false;
				result.msg = "";
				result.color = Color.Black;
			}
			else
			{
				if (Strings.Len(dado.Valor) == 3)
				{
					obj.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
					result.resultado = true;
					result.msg = "";
					result.color = Color.Black;
					dado.erro = false;
				}
				else
				{
					obj.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
					result.resultado = false;
					result.msg = "Parâmetro: " + dado.nome + " tem que possuir 3 caracteres\r\nCaracteres aceitos: 0 à 9; A à Z; espaço; _ ";
					result.color = Color.Red;
					dado.erro = true;
				}
				if (mostra & !result.resultado)
				{
					Interaction.MsgBox(result.msg, (MsgBoxStyle)16, "Atenção - Erro de configuração");
				}
			}
			return result;
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00253008 File Offset: 0x00251408
		public static RT_geral.Ctrl_erro Limite_comprimento_string(ref DataGridView obj, ref RT_geral.String_ictel dado, DataGridViewCellValidatingEventArgs e, bool mostra)
		{
			RT_geral.Ctrl_erro result = new RT_geral.Ctrl_erro();
			if (!RT_geral.Lmte_Init_ok)
			{
				result.resultado = false;
				result.msg = "";
				result.color = Color.Black;
			}
			else
			{
				if (Strings.Len(dado.Valor) <= 10)
				{
					obj.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
					result.resultado = true;
					result.msg = "";
					result.color = Color.Black;
					dado.erro = false;
				}
				else
				{
					obj.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
					result.resultado = false;
					result.msg = "Parâmetro: " + dado.nome + " possui mais que 10 caracteres! \r\nReduzir tamanho do nome.";
					result.color = Color.Red;
					dado.erro = true;
				}
				if (mostra & !result.resultado)
				{
					Interaction.MsgBox(result.msg, (MsgBoxStyle)16, "Atenção - Erro de configuração");
				}
			}
			return result;
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00253138 File Offset: 0x00251538
		public static MsgBoxResult VerificaDadoInt(ref RT_geral.Integer_ictel dado)
		{
			MsgBoxResult result = (MsgBoxResult)1;
			if (dado.Valor < dado.Lmte_inf | dado.Valor > dado.Lmte_sup)
			{
				dado.erro = true;
				string text = "Parâmento: " + dado.nome + "\r\n";
				text = text + "   Valor atual = " + Conversion.Str(dado.Valor) + "\r\n";
				text = text + "   Limite Superior = " + Conversion.Str(dado.Lmte_sup) + "\r\n";
				text = text + "   Limite Inferior = " + Conversion.Str(dado.Lmte_inf) + "\r\n\r\n";
				text += "   Deseja continuar verificação dos parâmetros?";
				result = Interaction.MsgBox(text, (MsgBoxStyle)20, "Atenção - Valor fora das especificações");
			}
			return result;
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00253204 File Offset: 0x00251604
		public static MsgBoxResult ContadorErro(ref RT_geral.Integer_ictel dado, ref int cont)
		{
			MsgBoxResult result = RT_geral.VerificaDadoInt(ref dado);
			checked
			{
				switch (result)
				{
				case (MsgBoxResult)6:
					cont++;
					break;
				case (MsgBoxResult)7:
					cont++;
					break;
				}
				return result;
			}
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0025323C File Offset: 0x0025163C
		public static bool VerificaExistenciaErroDados_RT810_200()
		{
			Linha_RT.Contador_Erros = 0;
			bool result = true;
			checked
			{
				if (RT_geral.ContadorErro(ref RT_geral.RT_810_200_BD.End_estacao, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_200_BD.End_mestre, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_200_BD.Tempo_ptt, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_200_BD.Intervalo_tx_pto_pto, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_200_BD.AD_Tamanho_filtro, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_200_BD.AD_Intervalo, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7)
				{
					int num = 0;
					while (RT_geral.ContadorErro(ref RT_geral.RT_810_200_BD.EA_Range[num], ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_200_BD.EA_Inicio[num], ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_200_BD.EA_Fim[num], ref Linha_RT.Contador_Erros) != (MsgBoxResult)7)
					{
						num++;
						if (num > 0)
						{
							if (RT_geral.ContadorErro(ref RT_geral.RT_810_200_BD.End_repetidora, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_200_BD.Num_repetidoras, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_200_BD.AlturaReservatorio, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_200_BD.ErroOffSet, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7)
							{
								num = 0;
								while (RT_geral.ContadorErro(ref RT_geral.RT_810_200_BD.Repetidoras[num], ref Linha_RT.Contador_Erros) != (MsgBoxResult)7)
								{
									num++;
									if (num > 49)
									{
										result = (Linha_RT.Contador_Erros != 0);
										break;
									}
								}
								break;
							}
							break;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x002533EC File Offset: 0x002517EC
		public static bool VerificaExistenciaErroDados_GC_82x()
		{
			return false;
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x002533FC File Offset: 0x002517FC
		public static bool VerificaExixtenciaErroDados_IEC855()
		{
			return false;
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0025340C File Offset: 0x0025180C
		public static bool VerificaExistenciaErroDados_RT810()
		{
			Linha_RT.Contador_Erros = 0;
			bool result = true;
			checked
			{
				if (RT_geral.ContadorErro(ref RT_geral.RT_810_BD.End_estacao, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_BD.End_mestre, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_BD.Tempo_ptt, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_BD.Intervalo_tx_pto_pto, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_BD.AD_Tamanho_filtro, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_BD.AD_Intervalo, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7)
				{
					int num = 0;
					while (RT_geral.ContadorErro(ref RT_geral.RT_810_BD.EA_Range[num], ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_BD.EA_Inicio[num], ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_BD.EA_Fim[num], ref Linha_RT.Contador_Erros) != (MsgBoxResult)7)
					{
						num++;
						if (num > 3)
						{
							if (RT_geral.ContadorErro(ref RT_geral.RT_810_BD.ctrl_tempo_max_parada[0], ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_BD.ctrl_tempo_max_partida[0], ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_BD.Hab_eletrodos, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_BD.End_repetidora, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_BD.Num_repetidoras, ref Linha_RT.Contador_Erros) != (MsgBoxResult)7)
							{
								num = 0;
								while (RT_geral.ContadorErro(ref RT_geral.RT_810_BD.Repetidoras[num], ref Linha_RT.Contador_Erros) != (MsgBoxResult)7)
								{
									num++;
									if (num > 49)
									{
										if (RT_geral.ContadorErro(ref RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[0], ref Linha_RT.Contador_Erros) != (MsgBoxResult)7 && RT_geral.ContadorErro(ref RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[0], ref Linha_RT.Contador_Erros) != (MsgBoxResult)7)
										{
											result = (Linha_RT.Contador_Erros != 0);
											break;
										}
										break;
									}
								}
								break;
							}
							break;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00253624 File Offset: 0x00251A24
		public static int LocalizaIndiceVetor_str_indice(ref RT_geral.Combo_ictel dados, string texto)
		{
			int num = 0;
			int numero_itens = dados.Numero_itens;
			checked
			{
				for (int i = num; i <= numero_itens; i++)
				{
					if (Operators.CompareString(texto, dados.itens[i], false) == 0)
					{
						return i;
					}
				}
				return -1;
			}
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00253660 File Offset: 0x00251A60
		public static int LocalizaIndiceVetor_valor_indice(ref RT_geral.Combo_ictel dados, int valor)
		{
			int num = 0;
			int numero_itens = dados.Numero_itens;
			checked
			{
				for (int i = num; i <= numero_itens; i++)
				{
					if (valor == dados.valores[i])
					{
						return i;
					}
				}
				return -1;
			}
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00253694 File Offset: 0x00251A94
		public static void AcertaIndexCombo_Ctrl(ref RT_geral.Combo_ictel_ctrl dado, RT_geral.DADOS_DATAGRIDVIEW_RT_820 dataview, string opcao, int mudou_para)
		{
			checked
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if (Operators.CompareString(opcao, "ED", false) == 0)
				{
					num = 21864;
					num2 = 21873;
					num3 = 8;
				}
				else if (Operators.CompareString(opcao, "SD", false) == 0)
				{
					num = 21864;
					num2 = 21873;
					num3 = 4;
				}
				else if (Operators.CompareString(opcao, "VZ", false) == 0)
				{
					num = 21880;
					num2 = num + 8 + 1;
					num3 = 0;
				}
				if (dado.Valor > num & dado.Valor < num2)
				{
					dado.Indice = dado.Indice_padrao;
					dado.Valor = dataview.LinhasValor[dado.Indice];
				}
				else if (num3 > 0)
				{
					if (mudou_para == 21856)
					{
						if (dado.Indice > 8)
						{
							dado.Indice -= num3;
						}
					}
					else if (dado.Indice > 8)
					{
						dado.Indice += num3;
					}
				}
			}
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00253774 File Offset: 0x00251B74
		public static void AcertaIndexCombo(ref RT_geral.Combo_ictel dado, string opcao, int mudou_para)
		{
			checked
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if (Operators.CompareString(opcao, "ED", false) == 0)
				{
					num = 21864;
					num2 = 21873;
					num3 = 8;
				}
				else if (Operators.CompareString(opcao, "SD", false) == 0)
				{
					num = 21864;
					num2 = 21873;
					num3 = 4;
				}
				else if (Operators.CompareString(opcao, "VZ", false) == 0)
				{
					num = 21888;
					num2 = num + 8 + 8 + 1;
					num3 = 0;
				}
				if (dado.Valor > num & dado.Valor < num2)
				{
					dado.Indice = dado.Indice_padrao;
					dado.Valor = dado.valores[dado.Indice];
				}
				else if (num3 > 0)
				{
					if (mudou_para == 21856)
					{
						if (dado.Indice > 8)
						{
							dado.Indice -= num3;
						}
					}
					else if (dado.Indice > 8)
					{
						dado.Indice += num3;
					}
				}
			}
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00253854 File Offset: 0x00251C54
		public static bool VerificaEDJaUtilizada_MesmaColuna(int num_linhas_ctrl, int indice_pesquisa, int num_ctrl, ref RT_geral.Combo_ictel_ctrl[] BD_dado, ref RT_geral.DADOS_DATAGRIDVIEW_RT_820 BD_ConfigColuna, string txt = "")
		{
			bool result = false;
			checked
			{
				if (indice_pesquisa != BD_dado[0].Indice_padrao)
				{
					int num = 0;
					int num2 = num_linhas_ctrl - 1;
					for (int i = num; i <= num2; i++)
					{
						if (i != num_ctrl && (indice_pesquisa == BD_dado[i].Indice_padrao | BD_dado[i].Indice == indice_pesquisa) && BD_dado[i].Indice == indice_pesquisa)
						{
							string text;
							if (txt.Equals(""))
							{
								text = "Já utilizada nessa coluna " + BD_ConfigColuna.TagColuna + "! \r\nLocal: " + BD_dado[i].nome;
							}
							else
							{
								text = txt + " já utilizado em " + BD_ConfigColuna.TagColuna + "! ";
							}
							DialogResult dialogResult = MessageBox.Show("Confirma a utilização ?", text, (System.Windows.Forms.MessageBoxButtons)4);
							result = (dialogResult != (DialogResult)6);
							break;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00253930 File Offset: 0x00251D30
		public static bool VerificaEDJaUtilizada_DiferenteColuna(int indice_pesquisa, ref RT_geral.Combo_ictel_ctrl BD_dados_coluna, ref RT_geral.DADOS_DATAGRIDVIEW_RT_820 BD_ConfigColuna, int num_linhas_ctrl_pesquisa, ref RT_geral.Combo_ictel_ctrl[] BD_dados_pesquisa, string txt = "", string col1 = "", string col2 = "")
		{
			bool result = false;
			checked
			{
				if (indice_pesquisa != BD_dados_coluna.Indice_padrao)
				{
					int num = BD_ConfigColuna.LinhasValor[indice_pesquisa];
					int num2 = 0;
					int num3 = num_linhas_ctrl_pesquisa - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (BD_dados_pesquisa[i].Valor == num)
						{
							string text;
							if (txt.Equals(""))
							{
								text = "Já utilizada! \r\nLocal: " + BD_dados_pesquisa[i].nome;
							}
							else
							{
								text = string.Concat(new string[]
								{
									txt,
									" já é utilizada em ",
									col1,
									" e ",
									col2
								});
							}
							DialogResult dialogResult = MessageBox.Show("Confirma a utilização ?", text, (System.Windows.Forms.MessageBoxButtons)4);
							result = (dialogResult != (DialogResult)6);
							break;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x002539F8 File Offset: 0x00251DF8
		public static bool VerificaEDJaUtilizada_FuncoesEspeciais(int entrada_digital, RT_geral.Combo_ictel_ctrl[] dado, string txt = "")
		{
			bool result = false;
			checked
			{
				if (entrada_digital != 0)
				{
					if (entrada_digital > 16)
					{
						result = false;
					}
					else
					{
						int indice = dado[entrada_digital - 1].Indice;
						if (indice != dado[entrada_digital - 1].Indice_padrao && dado[entrada_digital - 1].Indice != dado[entrada_digital - 1].Indice_padrao)
						{
							string text;
							if (txt.Equals(""))
							{
								text = "Já utilizada! \r\nLocal: Configuração Entrada Digital - ED " + Strings.Format(entrada_digital, "#0");
							}
							else
							{
								text = txt + " já utilizada! \r\nLocal: Configuração Entrada Digital - ED " + Strings.Format(entrada_digital, "#0");
							}
							Interaction.MsgBox(text, (MsgBoxStyle)16, "Atenção - Erro de configuração: ");
							result = true;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x00253AB0 File Offset: 0x00251EB0
		public static bool VerificaFuncaoJaUtilizada(int indice, int numero_ED, RT_geral.Combo_ictel_ctrl[] dado, int habexpansao)
		{
			checked
			{
				bool result = false;
				if (indice == dado[numero_ED].Indice_padrao)
				{
					result = false;
				}
				else
				{
					int num = 0;
					switch (habexpansao)
					{
					case 21856:
						num = 8;
						break;
					case 21857:
						num = 16;
						break;
					default:
						num = 1;
						break;
					}
					int num2 = 0;
					int num3 = num - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (i != numero_ED && indice == dado[i].Indice)
						{
							string text = "Função já utilizada! \r\nEntrada digital ED " + Strings.Format(i + 1, "");
							Interaction.MsgBox(text, (MsgBoxStyle)16, "Atenção - Erro de configuração: ");
							return true;
						}
					}
					result = false;
				}
				return result;
			}
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x00253B48 File Offset: 0x00251F48
		public static bool VerificaEDdaFuncaoJaUtilizada(int entrada_digital, int indice, int num_ctrl, ref RT_geral.Combo_ictel_ctrl[] dado)
		{
			bool result = false;
			checked
			{
				if (indice != 0)
				{
					int num = 21856 + entrada_digital;
					int num2 = 0;
					int num3 = num_ctrl - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (num == dado[i].Valor)
						{
							string text = "ED já utilizada! \r\nEm " + dado[i].nome;
							Interaction.MsgBox(text, (MsgBoxStyle)16, "Atenção - Erro de configuração: ");
							return true;
						}
					}
					result = false;
				}
				return result;
			}
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00253BB4 File Offset: 0x00251FB4
		public static void Tela_limpa_Ctrl(RT_geral.CTRL_TELA tela)
		{
			tela.Calibracao = false;
			tela.Configuracao = false;
			tela.Monitoracao = false;
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00253BD0 File Offset: 0x00251FD0
		public static void Inicializa_Estrutura_Equip_Tipo_1(int numero)
		{
			checked
			{
				for (int i = numero; i <= 79; i++)
				{
					RT_geral.RT_850_Ctrl_1[i].Nome.Valor = RT_geral.RT_850_Ctrl_1[i].Nome.Padrao;
					RT_geral.RT_850_Ctrl_1[i].Canal.Indice = RT_geral.RT_850_Ctrl_1[i].Canal.Indice_padrao;
					RT_geral.RT_850_Ctrl_1[i].Comando.Indice = RT_geral.RT_850_Ctrl_1[i].Comando.Indice_padrao;
					RT_geral.RT_850_Ctrl_1[i].Prioridade.Indice = RT_geral.RT_850_Ctrl_1[i].Prioridade.Indice_padrao;
					RT_geral.RT_850_Ctrl_1[i].Modelo.Indice = RT_geral.RT_850_Ctrl_1[i].Modelo.Indice_padrao;
					int num = 0;
					do
					{
						RT_geral.RT_850_Ctrl_1[i].Var[num].Indice = RT_geral.RT_850_Ctrl_1[i].Var[num].Indice_padrao;
						num++;
					}
					while (num <= 3);
					num = 0;
					do
					{
						RT_geral.RT_850_Ctrl_1[i].Ref[num].Indice = RT_geral.RT_850_Ctrl_1[i].Ref[num].Indice_padrao;
						num++;
					}
					while (num <= 3);
				}
			}
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00253D44 File Offset: 0x00252144
		public static void Inicializa_Estrutura_Equip_Tipo_2(int numero)
		{
			checked
			{
				for (int i = numero; i <= 49; i++)
				{
					RT_geral.RT_850_Ctrl_4[i].Nome.Valor = RT_geral.RT_850_Ctrl_4[i].Nome.Padrao;
					RT_geral.RT_850_Ctrl_4[i].Canal.Indice = RT_geral.RT_850_Ctrl_4[i].Canal.Indice_padrao;
					RT_geral.RT_850_Ctrl_4[i].Comando.Indice = RT_geral.RT_850_Ctrl_4[i].Comando.Indice_padrao;
					RT_geral.RT_850_Ctrl_4[i].Prioridade.Indice = RT_geral.RT_850_Ctrl_4[i].Prioridade.Indice_padrao;
					RT_geral.RT_850_Ctrl_4[i].Modelo.Indice = RT_geral.RT_850_Ctrl_4[i].Modelo.Indice_padrao;
					int num = 0;
					do
					{
						RT_geral.RT_850_Ctrl_4[i].Var[num].Indice = RT_geral.RT_850_Ctrl_4[i].Var[num].Indice_padrao;
						num++;
					}
					while (num <= 3);
					num = 0;
					do
					{
						RT_geral.RT_850_Ctrl_4[i].Ref[num].Indice = RT_geral.RT_850_Ctrl_4[i].Ref[num].Indice_padrao;
						num++;
					}
					while (num <= 3);
				}
			}
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x00253EB8 File Offset: 0x002522B8
		public static void Inicializa_Estrutura_Equip_Tipo_3(int numero)
		{
			checked
			{
				for (int i = numero; i <= 19; i++)
				{
					RT_geral.RT_850_Ctrl_8[i].Nome.Valor = RT_geral.RT_850_Ctrl_8[i].Nome.Padrao;
					RT_geral.RT_850_Ctrl_8[i].Canal.Indice = RT_geral.RT_850_Ctrl_8[i].Canal.Indice_padrao;
					RT_geral.RT_850_Ctrl_8[i].Comando.Indice = RT_geral.RT_850_Ctrl_8[i].Comando.Indice_padrao;
					RT_geral.RT_850_Ctrl_8[i].Prioridade.Indice = RT_geral.RT_850_Ctrl_8[i].Prioridade.Indice_padrao;
					RT_geral.RT_850_Ctrl_8[i].Modelo.Indice = RT_geral.RT_850_Ctrl_8[i].Modelo.Indice_padrao;
					int num = 0;
					do
					{
						RT_geral.RT_850_Ctrl_8[i].Var[num].Indice = RT_geral.RT_850_Ctrl_8[i].Var[num].Indice_padrao;
						num++;
					}
					while (num <= 15);
					num = 0;
					do
					{
						RT_geral.RT_850_Ctrl_8[i].Ref[num].Indice = RT_geral.RT_850_Ctrl_8[i].Ref[num].Indice_padrao;
						num++;
					}
					while (num <= 3);
				}
			}
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x0025402C File Offset: 0x0025242C
		public static void Inicializa_Estrutura_Equip_Tipo_Vista(int numero)
		{
			checked
			{
				for (int i = numero; i <= 4; i++)
				{
					RT_geral.RT_850_Vista[i].Nome.Valor = RT_geral.RT_850_Vista[i].Nome.Padrao;
					RT_geral.RT_850_Vista[i].Canal.Indice = RT_geral.RT_850_Vista[i].Canal.Indice_padrao;
					RT_geral.RT_850_Vista[i].Prioridade.Indice = RT_geral.RT_850_Vista[i].Prioridade.Indice_padrao;
					RT_geral.RT_850_Vista[i].Timeout.Indice = RT_geral.RT_850_Vista[i].Timeout.Indice_padrao;
					RT_geral.RT_850_Vista[i].Modelo.Indice = RT_geral.RT_850_Vista[i].Modelo.Indice_padrao;
					RT_geral.RT_850_Vista[i].Num_var.Valor = RT_geral.RT_850_Vista[i].Num_var.Padrao;
					RT_geral.RT_850_Vista[i].Num_equip.Valor = RT_geral.RT_850_Vista[i].Num_equip.Padrao;
					int num = 0;
					do
					{
						RT_geral.RT_850_Vista[i].Variaveis[num].Indice = RT_geral.RT_850_Vista[i].Variaveis[num].Indice_padrao;
						num++;
					}
					while (num <= 39);
					num = 0;
					do
					{
						RT_geral.RT_850_Vista[i].Equipamentos[num].Indice = RT_geral.RT_850_Vista[i].Equipamentos[num].Indice_padrao;
						num++;
					}
					while (num <= 19);
				}
			}
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x002541F4 File Offset: 0x002525F4
		public static void Limpa_Variavel_BD_RT850(int indice)
		{
			int num = 0;
			checked
			{
				do
				{
					int num2 = 0;
					do
					{
						if (RT_geral.RT_850_Ctrl_1[num].Var[num2].Indice == indice)
						{
							RT_geral.RT_850_Ctrl_1[num].Var[num2].Indice = RT_geral.RT_850_Ctrl_1[num].Var[num2].Indice_padrao;
						}
						num2++;
					}
					while (num2 <= 3);
					num2 = 0;
					do
					{
						if (RT_geral.RT_850_Ctrl_1[num].Ref[num2].Indice == indice)
						{
							RT_geral.RT_850_Ctrl_1[num].Ref[num2].Indice = RT_geral.RT_850_Ctrl_1[num].Ref[num2].Indice_padrao;
						}
						num2++;
					}
					while (num2 <= 3);
					num++;
				}
				while (num <= 79);
				num = 0;
				do
				{
					int num2 = 0;
					do
					{
						if (RT_geral.RT_850_Ctrl_4[num].Var[num2].Indice == indice)
						{
							RT_geral.RT_850_Ctrl_4[num].Var[num2].Indice = RT_geral.RT_850_Ctrl_4[num].Var[num2].Indice_padrao;
						}
						num2++;
					}
					while (num2 <= 3);
					num2 = 0;
					do
					{
						if (RT_geral.RT_850_Ctrl_4[num].Ref[num2].Indice == indice)
						{
							RT_geral.RT_850_Ctrl_4[num].Ref[num2].Indice = RT_geral.RT_850_Ctrl_4[num].Ref[num2].Indice_padrao;
						}
						num2++;
					}
					while (num2 <= 3);
					num++;
				}
				while (num <= 49);
			}
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00254398 File Offset: 0x00252798
		public static int Localiza_indice_combo(ref RT_geral.DADOS_DATAGRIDVIEW_RT_820 dado, int dado_a_localizar)
		{
			int num = 0;
			int numeroLinhaMenu = dado.NumeroLinhaMenu;
			checked
			{
				for (int i = num; i <= numeroLinhaMenu; i++)
				{
					if (dado.LinhasValor[i] == dado_a_localizar)
					{
						return i;
					}
				}
				return 0;
			}
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x002543CC File Offset: 0x002527CC
		public static string MontaNomePlacaPeloFabricante(int Equipamento, int Versao)
		{
			Image logo_vortice_pp = Resources.logo_vortice_pp;
			string text = "MD";
			int num = Equipamento;
			if (num == 810)
			{
				Equipamento = 101;
			}
			else if (num == 820)
			{
				Equipamento = 202;
			}
			else if (num == 821)
			{
				Equipamento = 201;
			}
			else if (num == 830)
			{
				Equipamento = 302;
			}
			else if (num == 831)
			{
				Equipamento = 301;
			}
			else if (num == 850)
			{
				Equipamento = 305;
			}
			return text + Equipamento.ToString() + "/" + (checked(100 * Versao)).ToString();
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0025446C File Offset: 0x0025286C
		public static string MontaNomePlacaPeloFabricante2(int Equipamento, int Versao, int Build)
		{
			Image logo_vortice_pp = Resources.logo_vortice_pp;
			string text = "MD";
			int num = Equipamento;
			if (num == 810)
			{
				Equipamento = 101;
			}
			else if (num == 820)
			{
				Equipamento = 202;
			}
			else if (num == 821)
			{
				Equipamento = 201;
			}
			else if (num == 830)
			{
				Equipamento = 302;
			}
			else if (num == 831)
			{
				Equipamento = 301;
			}
			else if (num == 850)
			{
				Equipamento = 305;
			}
			return string.Concat(new string[]
			{
				text,
				Equipamento.ToString(),
				"/",
				Versao.ToString(),
				(checked(Build * 10)).ToString()
			});
		}

		// Token: 0x04000D4C RID: 3404
		public static bool Lmte_Init_ok;

		// Token: 0x04000D4D RID: 3405
		public static string arquivo_extensao;

		// Token: 0x04000D4E RID: 3406
		public const bool CONST_TROCA_TELA = true;

		// Token: 0x04000D4F RID: 3407
		public const bool CONST_NAO_TROCA_TELA = false;

		// Token: 0x04000D50 RID: 3408
		public const int CONST_RT_810_SD = 1;

		// Token: 0x04000D51 RID: 3409
		public const int CONST_RT_810_MOTORES = 1;

		// Token: 0x04000D52 RID: 3410
		public const int CONST_RT_810_ED = 8;

		// Token: 0x04000D53 RID: 3411
		public const int CONST_RT_810_EA = 4;

		// Token: 0x04000D54 RID: 3412
		public const int CONST_RT_810_200_EA = 1;

		// Token: 0x04000D55 RID: 3413
		public const int CONST_RT_810_NUM_MAX_REPETIDORAS = 50;

		// Token: 0x04000D56 RID: 3414
		public const int CONST_RT_810_SETPOINTS = 1;

		// Token: 0x04000D57 RID: 3415
		public const int CONST_RT_810 = 0;

		// Token: 0x04000D58 RID: 3416
		public const int CONST_RT_810_CTRL = 1;

		// Token: 0x04000D59 RID: 3417
		public const int CONST_RT_810_MOD_RT810 = 0;

		// Token: 0x04000D5A RID: 3418
		public const int CONST_RT_810_MOD_VA310 = 1;

		// Token: 0x04000D5B RID: 3419
		public const int CONST_RT_810_MOD_MD101 = 2;

		// Token: 0x04000D5C RID: 3420
		public const int CONST_RT_810_MODELO_EMULADO_DEFAULT_INDICE = 0;

		// Token: 0x04000D5D RID: 3421
		public const int CONST_RT_810_DEFAULT_EQUIP = 0;

		// Token: 0x04000D5E RID: 3422
		public const int CONST_RT_810_DEFAULT_VERSAO = 0;

		// Token: 0x04000D5F RID: 3423
		public const int CONST_RT_810_DEFAULT_BUILD = 0;

		// Token: 0x04000D60 RID: 3424
		public const int CONST_RT_810_DEFAULT_RELEASE = 0;

		// Token: 0x04000D61 RID: 3425
		public const int CONST_RT_810_DEFAULT_EMULACAO = 0;

		// Token: 0x04000D62 RID: 3426
		public const int CONST_RT_810_DEFAULT_MODO_OPERACAO = 0;

		// Token: 0x04000D63 RID: 3427
		public const int CONST_RT_810_DEFAULT_HAB_ELETRODOS = 0;

		// Token: 0x04000D64 RID: 3428
		public const int CONST_RT_810_DEFAULT_HAB_REPETIDORAS = 0;

		// Token: 0x04000D65 RID: 3429
		public const int CONST_RT_810_DEFAULT_TEMPO_PARADA = 180;

		// Token: 0x04000D66 RID: 3430
		public const int CONST_RT_810_LMTE_SUP_TEMPO_PARADA = 1200;

		// Token: 0x04000D67 RID: 3431
		public const int CONST_RT_810_LMTE_INF_TEMPO_PARADA = 0;

		// Token: 0x04000D68 RID: 3432
		public const int CONST_RT_810_DEFAULT_TEMPO_PARTIDA = 180;

		// Token: 0x04000D69 RID: 3433
		public const int CONST_RT_810_LMTE_SUP_TEMPO_PARTIDA = 1200;

		// Token: 0x04000D6A RID: 3434
		public const int CONST_RT_810_LMTE_INF_TEMPO_PARTIDA = 0;

		// Token: 0x04000D6B RID: 3435
		public const int CONST_RT_810_DEFAULT_SD_CONTROLE = 0;

		// Token: 0x04000D6C RID: 3436
		public const int CONST_RT_810_DEFAULT_SD_FUNCAO = 0;

		// Token: 0x04000D6D RID: 3437
		public const int CONST_RT_810_DEFAULT_END_ESTACAO = 1;

		// Token: 0x04000D6E RID: 3438
		public const int CONST_RT_810_LMTE_SUP_END_ESTACAO = 200;

		// Token: 0x04000D6F RID: 3439
		public const int CONST_RT_810_LMTE_INF_END_ESTACAO = 0;

		// Token: 0x04000D70 RID: 3440
		public const int CONST_RT_810_DEFAULT_END_MESTRE = 100;

		// Token: 0x04000D71 RID: 3441
		public const int CONST_RT_810_LMTE_SUP_END_MESTRE = 200;

		// Token: 0x04000D72 RID: 3442
		public const int CONST_RT_810_LMTE_INF_END_MESTRE = 1;

		// Token: 0x04000D73 RID: 3443
		public const int CONST_RT_810_DEFAULT_HAB_REP = 21856;

		// Token: 0x04000D74 RID: 3444
		public const int CONST_RT_810_HAB_REP_DESABILITADOS = 21856;

		// Token: 0x04000D75 RID: 3445
		public const int CONST_RT_810_HAB_REP_HABILITADOS = 21857;

		// Token: 0x04000D76 RID: 3446
		public const int CONST_RT_810_HAB_REP_DEFAULT_INDICE = 0;

		// Token: 0x04000D77 RID: 3447
		public const int CONST_RT_810_DEFAULT_TEMPO_PTT = 200;

		// Token: 0x04000D78 RID: 3448
		public const int CONST_RT_810_LMTE_SUP_TEMPO_PTT = 2000;

		// Token: 0x04000D79 RID: 3449
		public const int CONST_RT_810_LMTE_INF_TEMPO_PTT = 1;

		// Token: 0x04000D7A RID: 3450
		public const int CONST_RT_810_300_DEFAULT_RANGE_SENSOR = 1000;

		// Token: 0x04000D7B RID: 3451
		public const int CONST_RT_810_300_LMTE_SUP_RANGE_SENSOR = 5000;

		// Token: 0x04000D7C RID: 3452
		public const int CONST_RT_810_300_LMTE_INF_RANGE_SENSOR = 0;

		// Token: 0x04000D7D RID: 3453
		public const int CONST_RT_810_300_DEFAULT_ALTURA_RESERVATIORIO = 1000;

		// Token: 0x04000D7E RID: 3454
		public const int CONST_RT_810_300_LMTE_SUP_ALTURA_RESERVATIORIO = 5000;

		// Token: 0x04000D7F RID: 3455
		public const int CONST_RT_810_300_LMTE_INF_ALTURA_RESERVATIORIO = 0;

		// Token: 0x04000D80 RID: 3456
		public const int CONST_RT_810_300_DEFAULT_ERRO_OFFSET_SENSOR = 0;

		// Token: 0x04000D81 RID: 3457
		public const int CONST_RT_810_300_LMTE_SUP_DEFAULT_ERRO_OFFSET_SENSOR = 1000;

		// Token: 0x04000D82 RID: 3458
		public const int CONST_RT_810_300_LMTE_INF_DEFAULT_ERRO_OFFSET_SENSOR = 0;

		// Token: 0x04000D83 RID: 3459
		public const int CONST_RT_810_200_DEFAULT_ERRO_OFFSET_SENSOR = 0;

		// Token: 0x04000D84 RID: 3460
		public const int CONST_RT_810_200_LMTE_SUP_DEFAULT_ERRO_OFFSET_SENSOR = 4000;

		// Token: 0x04000D85 RID: 3461
		public const int CONST_RT_810_200_LMTE_INF_DEFAULT_ERRO_OFFSET_SENSOR = -4000;

		// Token: 0x04000D86 RID: 3462
		public const int CONST_RT_810_MODO_OPERACAO_INDICE_REDE = 0;

		// Token: 0x04000D87 RID: 3463
		public const int CONST_RT_810_MODO_OPERACAO_INDICE_PTO_A_PTO = 1;

		// Token: 0x04000D88 RID: 3464
		public const int CONST_RT_810_MODO_OPERACAO_REDE = 21856;

		// Token: 0x04000D89 RID: 3465
		public const int CONST_RT_810_MODO_OPERACAO_PTO_A_PTO = 21857;

		// Token: 0x04000D8A RID: 3466
		public const int CONST_RT_810_DEFAULT_INTERVALO_TX_PTO = 3;

		// Token: 0x04000D8B RID: 3467
		public const int CONST_RT_810_LMTE_SUP_INTERVALO_TX_PTO = 43200;

		// Token: 0x04000D8C RID: 3468
		public const int CONST_RT_810_LMTE_INF_INTERVALO_TX_PTO = 1;

		// Token: 0x04000D8D RID: 3469
		public const int CONST_RT_810_DEFAULT_AD_INTERVALO = 500;

		// Token: 0x04000D8E RID: 3470
		public const int CONST_RT_810_LMTE_SUP_AD_INTERVALO = 20000;

		// Token: 0x04000D8F RID: 3471
		public const int CONST_RT_810_LMTE_INF_AD_INTERVALO = 100;

		// Token: 0x04000D90 RID: 3472
		public const int CONST_RT_810_DEFAULT_AD_TAMANHO_FILTRO = 3;

		// Token: 0x04000D91 RID: 3473
		public const int CONST_RT_810_LMTE_SUP_AD_TAMANHO_FILTRO = 10;

		// Token: 0x04000D92 RID: 3474
		public const int CONST_RT_810_LMTE_INF_AD_TAMANHO_FILTRO = 1;

		// Token: 0x04000D93 RID: 3475
		public const int CONST_RT_810_DEFAULT_EA_RANGE = 4000;

		// Token: 0x04000D94 RID: 3476
		public const int CONST_RT_810_LMTE_INF_EA_Range = 1;

		// Token: 0x04000D95 RID: 3477
		public const int CONST_RT_810_LMTE_SUP_EA_Range = 65535;

		// Token: 0x04000D96 RID: 3478
		public const int CONST_RT_810_DEFAULT_EA_INICIO = 0;

		// Token: 0x04000D97 RID: 3479
		public const int CONST_RT_810_LMTE_INF_EA_INICIO = 0;

		// Token: 0x04000D98 RID: 3480
		public const int CONST_RT_810_LMTE_SUP_EA_INICIO = 65536;

		// Token: 0x04000D99 RID: 3481
		public const int CONST_RT_810_DEFAULT_EA_FIM = 4000;

		// Token: 0x04000D9A RID: 3482
		public const int CONST_RT_810_LMTE_INF_EA_FIM = 1;

		// Token: 0x04000D9B RID: 3483
		public const int CONST_RT_810_LMTE_SUP_EA_FIM = 65535;

		// Token: 0x04000D9C RID: 3484
		public const int CONST_RT_810_CTRL_ACIONAMENTO_SAIDA_DEFAULT_INDICE = 0;

		// Token: 0x04000D9D RID: 3485
		public const int CONST_RT_810_CTRL_ACIONAMENTO_ENTRADA_DEFAULT_INDICE = 0;

		// Token: 0x04000D9E RID: 3486
		public const int CONST_RT_810_SELECAO_DEFAULT_INDICE = 0;

		// Token: 0x04000D9F RID: 3487
		public const int CONST_RT_810_REVERSO_DEFAULT_INDICE = 0;

		// Token: 0x04000DA0 RID: 3488
		public const int CONST_RT_810_MODO_DEFAULT_INDICE = 0;

		// Token: 0x04000DA1 RID: 3489
		public const int CONST_RT_810_CTRL_DEFAULT_TEMPO_MAX_PARTIDA = 180;

		// Token: 0x04000DA2 RID: 3490
		public const int CONST_RT_810_CTRL_LMTE_SUP_TEMPO_MAX_PARTIDA = 1200;

		// Token: 0x04000DA3 RID: 3491
		public const int CONST_RT_810_CTRL_LMTE_INF_TEMPO_MAX_PARTIDA = 0;

		// Token: 0x04000DA4 RID: 3492
		public const int CONST_RT_810_CTRL_DEFAULT_TEMPO_MAX_PARADA = 180;

		// Token: 0x04000DA5 RID: 3493
		public const int CONST_RT_810_CTRL_LMTE_SUP_TEMPO_MAX_PARADA = 1200;

		// Token: 0x04000DA6 RID: 3494
		public const int CONST_RT_810_CTRL_LMTE_INF_TEMPO_MAX_PARADA = 0;

		// Token: 0x04000DA7 RID: 3495
		public const int CONST_RT_810_CONFIG_ED_DEFAULT_INDICE = 0;

		// Token: 0x04000DA8 RID: 3496
		public const int CONST_RT_810_ELETRODOS_DESABILITADOS = 21856;

		// Token: 0x04000DA9 RID: 3497
		public const int CONST_RT_810_ELETRODOS_HABILITADOS = 21857;

		// Token: 0x04000DAA RID: 3498
		public const int CONST_RT_810_DEFAULT_END_REPETIDORAS = 1;

		// Token: 0x04000DAB RID: 3499
		public const int CONST_RT_810_LMTE_SUP_END_REPETIDORAS = 200;

		// Token: 0x04000DAC RID: 3500
		public const int CONST_RT_810_LMTE_INF_END_REPETIDORAS = 1;

		// Token: 0x04000DAD RID: 3501
		public const int CONST_RT_810_DEFAULT_NUM_REPETIDORAS = 0;

		// Token: 0x04000DAE RID: 3502
		public const int CONST_RT_810_LMTE_SUP_NUM_REPETIDORAS = 50;

		// Token: 0x04000DAF RID: 3503
		public const int CONST_RT_810_LMTE_INF_NUM_REPETIDORAS = 0;

		// Token: 0x04000DB0 RID: 3504
		public const int CONST_RT_810_DEFAULT_REP_ENDERECOS = 0;

		// Token: 0x04000DB1 RID: 3505
		public const int CONST_RT_810_LMTE_SUP_REP_ENDERECOS = 200;

		// Token: 0x04000DB2 RID: 3506
		public const int CONST_RT_810_LMTE_INF_REP_ENDERECOS = 0;

		// Token: 0x04000DB3 RID: 3507
		public const int CONST_RT_810_DEFAULT_SETPOINT_ALTO = 4000;

		// Token: 0x04000DB4 RID: 3508
		public const int CONST_RT_810_DEFAULT_SETPOINT_BAIXO = 0;

		// Token: 0x04000DB5 RID: 3509
		public const int CONST_RT_810_LMTE_INF_SETPOINT = 0;

		// Token: 0x04000DB6 RID: 3510
		public const int CONST_RT_810_LMTE_SUP_SETPOINT = 4000;

		// Token: 0x04000DB7 RID: 3511
		public const int CONST_RT_810_DEFAULT_SETPOINT_NIVEL_BLOQUEIO = 400;

		// Token: 0x04000DB8 RID: 3512
		public const int CONST_RT_810_DEFAULT_SETPOINT_NIVEL_LIBERACAO = 800;

		// Token: 0x04000DB9 RID: 3513
		public const int CONST_RT_810_ED_FUNCAO_DEFAULT_INDICE = 0;

		// Token: 0x04000DBA RID: 3514
		public const int CONST_RT_810_CTRL_VARIAVEL_DEFAULT_INDICE = 0;

		// Token: 0x04000DBB RID: 3515
		public const int CONST_COLUNA_PROCESSO_SD_ACIONAMENTO_RT_810 = 0;

		// Token: 0x04000DBC RID: 3516
		public const int CONST_COLUNA_PROCESSO_ED_ACIONAMENTO_RT_810 = 1;

		// Token: 0x04000DBD RID: 3517
		public const int CONST_COLUNA_PROCESSO_ED_REMOTO_RT_810 = 2;

		// Token: 0x04000DBE RID: 3518
		public const int CONST_COLUNA_PROCESSO_REVERSO_RT_810 = 3;

		// Token: 0x04000DBF RID: 3519
		public const int CONST_COLUNA_PROCESSO_MODO_RT_810 = 4;

		// Token: 0x04000DC0 RID: 3520
		public const int CONST_COLUNA_PROCESSO_TEMPO_MAX_PARTIDA_RT_810 = 5;

		// Token: 0x04000DC1 RID: 3521
		public const int CONST_COLUNA_PROCESSO_TEMPO_MAX_PARADA_RT_810 = 6;

		// Token: 0x04000DC2 RID: 3522
		public const int CONST_COLUNA_EA_RANGE_RT_810 = 0;

		// Token: 0x04000DC3 RID: 3523
		public const int CONST_COLUNA_EA_INICIO_RT_810 = 1;

		// Token: 0x04000DC4 RID: 3524
		public const int CONST_COLUNA_EA_FIM_RT_810 = 2;

		// Token: 0x04000DC5 RID: 3525
		public const int CONST_COLUNA_SETPOINT_CONTROLE_RT_810 = 0;

		// Token: 0x04000DC6 RID: 3526
		public const int CONST_COLUNA_SETPOINT_NIVEL_BAIXO_RT_810 = 1;

		// Token: 0x04000DC7 RID: 3527
		public const int CONST_COLUNA_SETPOINT_NIVEL_ALTO_RT_810 = 2;

		// Token: 0x04000DC8 RID: 3528
		public const int CONST_COLUNA_ENTRADA_DIGITAL_RT_810 = 0;

		// Token: 0x04000DC9 RID: 3529
		public const int CONST_TESTE_ED_FUNCAO_RT_810 = 0;

		// Token: 0x04000DCA RID: 3530
		public const int CONST_TESTE_ED_CTRL_RETORNO_RT_810 = 1;

		// Token: 0x04000DCB RID: 3531
		public const int CONST_TESTE_ED_CTRL_REMOTO_RT_810 = 2;

		// Token: 0x04000DCC RID: 3532
		public const int CONST_TESTE_ED_FUNCAO_RT_820 = 0;

		// Token: 0x04000DCD RID: 3533
		public const int CONST_TESTE_ED_CTRL_RETORNO_RT_820 = 1;

		// Token: 0x04000DCE RID: 3534
		public const int CONST_TESTE_ED_CTRL_REMOTO_RT_820 = 2;

		// Token: 0x04000DCF RID: 3535
		public const int CONST_RT_820 = 1;

		// Token: 0x04000DD0 RID: 3536
		public const int CONST_RT_820_360 = 4;

		// Token: 0x04000DD1 RID: 3537
		public const int CONST_RT_820_SD = 12;

		// Token: 0x04000DD2 RID: 3538
		public const int CONST_RT_820_MOTORES = 4;

		// Token: 0x04000DD3 RID: 3539
		public const int CONST_RT_820_ED = 16;

		// Token: 0x04000DD4 RID: 3540
		public const int CONST_RT_820_200_ED = 8;

		// Token: 0x04000DD5 RID: 3541
		public const int CONST_RT_820_EA = 16;

		// Token: 0x04000DD6 RID: 3542
		public const int CONST_RT_820_VAZAO = 8;

		// Token: 0x04000DD7 RID: 3543
		public const int CONST_RT_820_PERIFERICOS = 5;

		// Token: 0x04000DD8 RID: 3544
		public const int CONST_RT_820_360_MODBUS_GENERICO = 5;

		// Token: 0x04000DD9 RID: 3545
		public const int CONST_RT_820_400_CALHAS = 2;

		// Token: 0x04000DDA RID: 3546
		public const int CONST_RT_820_200_PERIFERICOS = 4;

		// Token: 0x04000DDB RID: 3547
		public const int CONST_RT_820_REFERENCIA_PERIFERICOS = 10;

		// Token: 0x04000DDC RID: 3548
		public const int CONST_RT_820_ATUADOR1 = 1;

		// Token: 0x04000DDD RID: 3549
		public const int CONST_RT_820_ATUADOR2 = 1;

		// Token: 0x04000DDE RID: 3550
		public const int CONST_RT_820_ATUADOR_SETPOINT1 = 3;

		// Token: 0x04000DDF RID: 3551
		public const int CONST_RT_820_ATUADOR_SETPOINT2 = 3;

		// Token: 0x04000DE0 RID: 3552
		public const int CONST_RT_820_CALHA = 2;

		// Token: 0x04000DE1 RID: 3553
		public const int CONST_RT_820_CTRL = 7;

		// Token: 0x04000DE2 RID: 3554
		public const int CONST_RT_820_GRUPOS_SIMULTANEOS = 4;

		// Token: 0x04000DE3 RID: 3555
		public const int CONST_RT_820_ENTRADA_VAZOES = 8;

		// Token: 0x04000DE4 RID: 3556
		public const int CONST_RT_820_CALHAS = 2;

		// Token: 0x04000DE5 RID: 3557
		public const int CONST_RT_820_NUM_MAX_REPETIDORAS = 50;

		// Token: 0x04000DE6 RID: 3558
		public const int CONST_RT_820_SETPOINTS = 8;

		// Token: 0x04000DE7 RID: 3559
		public const int CONST_RT_820_END_INICIAL_GERAL = 0;

		// Token: 0x04000DE8 RID: 3560
		public const int CONST_RT_820_MODELO_EMULADO_DEFAULT_INDICE = 0;

		// Token: 0x04000DE9 RID: 3561
		public const int CONST_RT_820_MOD_RT820 = 0;

		// Token: 0x04000DEA RID: 3562
		public const int CONST_RT_820_MOD_VA220 = 1;

		// Token: 0x04000DEB RID: 3563
		public const int CONST_RT_820_MOD_MD202 = 2;

		// Token: 0x04000DEC RID: 3564
		public const int CONST_RT_820_DEFAULT_EQUIP = 0;

		// Token: 0x04000DED RID: 3565
		public const int CONST_RT_820_DEFAULT_VERSAO = 0;

		// Token: 0x04000DEE RID: 3566
		public const int CONST_RT_820_DEFAULT_BUILD = 0;

		// Token: 0x04000DEF RID: 3567
		public const int CONST_RT_820_DEFAULT_RELEASE = 0;

		// Token: 0x04000DF0 RID: 3568
		public const int CONST_RT_820_DEFAULT_END_ESTACAO = 1;

		// Token: 0x04000DF1 RID: 3569
		public const int CONST_RT_820_DEFAULT_END_ESTACAO2 = 0;

		// Token: 0x04000DF2 RID: 3570
		public const int CONST_RT_820_LMTE_SUP_END_ESTACAO = 200;

		// Token: 0x04000DF3 RID: 3571
		public const int CONST_RT_820_LMTE_INF_END_ESTACAO = 0;

		// Token: 0x04000DF4 RID: 3572
		public const int CONST_RT_820_DEFAULT_END_MESTRE = 100;

		// Token: 0x04000DF5 RID: 3573
		public const int CONST_RT_820_LMTE_SUP_END_MESTRE = 200;

		// Token: 0x04000DF6 RID: 3574
		public const int CONST_RT_820_LMTE_INF_END_MESTRE = 1;

		// Token: 0x04000DF7 RID: 3575
		public const int CONST_RT_820_DEFAULT_EMULACAO = 0;

		// Token: 0x04000DF8 RID: 3576
		public const int CONST_RT_820_EMULACAO_INDICE = 0;

		// Token: 0x04000DF9 RID: 3577
		public const int CONST_RT_820_MODO_REPETIDORA_DEFAULT_INDICE = 0;

		// Token: 0x04000DFA RID: 3578
		public const int CONST_RT_820_DEFAULT_END_REPETIDORAS = 1;

		// Token: 0x04000DFB RID: 3579
		public const int CONST_RT_820_LMTE_SUP_END_REPETIDORAS = 200;

		// Token: 0x04000DFC RID: 3580
		public const int CONST_RT_820_LMTE_INF_END_REPETIDORAS = 1;

		// Token: 0x04000DFD RID: 3581
		public const int CONST_RT_820_DEFAULT_NUM_REPETIDORAS = 0;

		// Token: 0x04000DFE RID: 3582
		public const int CONST_RT_820_LMTE_SUP_NUM_REPETIDORAS = 50;

		// Token: 0x04000DFF RID: 3583
		public const int CONST_RT_820_LMTE_INF_NUM_REPETIDORAS = 0;

		// Token: 0x04000E00 RID: 3584
		public const int CONST_RT_820_DEFAULT_REP_ENDERECOS = 0;

		// Token: 0x04000E01 RID: 3585
		public const int CONST_RT_820_LMTE_SUP_REP_ENDERECOS = 200;

		// Token: 0x04000E02 RID: 3586
		public const int CONST_RT_820_LMTE_INF_REP_ENDERECOS = 0;

		// Token: 0x04000E03 RID: 3587
		public const int CONST_RT_820_DEFAULT_TEMPO_PTT = 200;

		// Token: 0x04000E04 RID: 3588
		public const int CONST_RT_820_LMTE_SUP_TEMPO_PTT = 2000;

		// Token: 0x04000E05 RID: 3589
		public const int CONST_RT_820_LMTE_INF_TEMPO_PTT = 100;

		// Token: 0x04000E06 RID: 3590
		public const int CONST_RT_820_DEFAULT_COM2 = 21856;

		// Token: 0x04000E07 RID: 3591
		public const int CONST_RT_820_DEFAULT_INDICE_COM2 = 0;

		// Token: 0x04000E08 RID: 3592
		public const int CONST_RT_820_BAUDRATE_COM2_1200 = 21856;

		// Token: 0x04000E09 RID: 3593
		public const int CONST_RT_820_BAUDRATE_COM2_9600 = 21857;

		// Token: 0x04000E0A RID: 3594
		public const int CONST_RT_820_HAB_IO_DESABILITADO = 21856;

		// Token: 0x04000E0B RID: 3595
		public const int CONST_RT_820_HAB_IO_HABILITADO = 21857;

		// Token: 0x04000E0C RID: 3596
		public const int CONST_RT_820_HAB_IO_DEFAULT = 21856;

		// Token: 0x04000E0D RID: 3597
		public const int CONST_RT_820_DEFAULT_AD_INTERVALO = 2000;

		// Token: 0x04000E0E RID: 3598
		public const int CONST_RT_820_LMTE_SUP_AD_INTERVALO = 20000;

		// Token: 0x04000E0F RID: 3599
		public const int CONST_RT_820_LMTE_INF_AD_INTERVALO = 500;

		// Token: 0x04000E10 RID: 3600
		public const int CONST_RT_820_200_LMTE_INF_AD_INTERVALO = 10;

		// Token: 0x04000E11 RID: 3601
		public const int CONST_RT_820_DEFAULT_AD_TAMANHO_FILTRO = 3;

		// Token: 0x04000E12 RID: 3602
		public const int CONST_RT_820_LMTE_SUP_AD_TAMANHO_FILTRO = 10;

		// Token: 0x04000E13 RID: 3603
		public const int CONST_RT_820_LMTE_INF_AD_TAMANHO_FILTRO = 1;

		// Token: 0x04000E14 RID: 3604
		public const int CONST_RT_820_DEFAULT_HAB_IO = 0;

		// Token: 0x04000E15 RID: 3605
		public const int CONST_RT_820_DEFAULT_EA_RANGE = 4000;

		// Token: 0x04000E16 RID: 3606
		public const int CONST_RT_820_LMTE_INF_EA_Range = 0;

		// Token: 0x04000E17 RID: 3607
		public const int CONST_RT_820_LMTE_SUP_EA_Range = 4000;

		// Token: 0x04000E18 RID: 3608
		public const int CONST_RT_820_DEFAULT_EA_INICIO = 0;

		// Token: 0x04000E19 RID: 3609
		public const int CONST_RT_820_LMTE_INF_EA_INICIO = 0;

		// Token: 0x04000E1A RID: 3610
		public const int CONST_RT_820_LMTE_SUP_EA_INICIO = 20000;

		// Token: 0x04000E1B RID: 3611
		public const int CONST_RT_820_DEFAULT_EA_FIM = 4000;

		// Token: 0x04000E1C RID: 3612
		public const int CONST_RT_820_LMTE_INF_EA_FIM = 0;

		// Token: 0x04000E1D RID: 3613
		public const int CONST_RT_820_LMTE_SUP_EA_FIM = 50000;

		// Token: 0x04000E1E RID: 3614
		public const int CONST_RT_820_CTRL_ACIONAMENTO_SAIDA_DEFAULT_INDICE = 0;

		// Token: 0x04000E1F RID: 3615
		public const int CONST_RT_820_CTRL_DESACIONAMENTO_SAIDA_DEFAULT_INDICE = 0;

		// Token: 0x04000E20 RID: 3616
		public const int CONST_RT_820_CTRL_ACIONAMENTO_ENTRADA_DEFAULT_INDICE = 0;

		// Token: 0x04000E21 RID: 3617
		public const int CONST_RT_820_CTRL_DESACIONAMENTO_ENTRADA_DEFAULT_INDICE = 0;

		// Token: 0x04000E22 RID: 3618
		public const int CONST_RT_820_CTRL_REMOTO_ENTRADA_DEFAULT_INDICE = 0;

		// Token: 0x04000E23 RID: 3619
		public const int CONST_RT_820_BLOQUEIO_ENTRADA_DEFAULT_INDICE = 0;

		// Token: 0x04000E24 RID: 3620
		public const int CONST_RT_820_LIBERACAO_ENTRADA_DEFAULT_INDICE = 0;

		// Token: 0x04000E25 RID: 3621
		public const int CONST_RT_820_MODO_DEFAULT_INDICE = 0;

		// Token: 0x04000E26 RID: 3622
		public const int CONST_RT_820_AGRUPAMENTO_DEFAULT_INDICE = 0;

		// Token: 0x04000E27 RID: 3623
		public const int CONST_RT_820_PARTIDAS_DEFAULT_INDICE = 0;

		// Token: 0x04000E28 RID: 3624
		public const int CONST_RT_820_REVERSO_DEFAULT_INDICE = 0;

		// Token: 0x04000E29 RID: 3625
		public const int CONST_RT_820_SIMULTANEOS_DEFAULT_INDICE = 1;

		// Token: 0x04000E2A RID: 3626
		public const int CONST_RT_820_ROTATIVO_MOTORES_DEFAULT_INDICE = 0;

		// Token: 0x04000E2B RID: 3627
		public const int CONST_RT_820_CTRL_DESLIGAMENTO_SAIDA_DEFAULT_INDICE = 0;

		// Token: 0x04000E2C RID: 3628
		public const int CONST_RT_820_CTRL_ACIONAMENTO_RETORNO_DEFAULT_INDICE = 0;

		// Token: 0x04000E2D RID: 3629
		public const int CONST_RT_820_CTRL_DESLIGAMENTO_RETORNO_DEFAULT_INDICE = 0;

		// Token: 0x04000E2E RID: 3630
		public const int CONST_RT_820_CTRL_SELECAO_REMOTO_DEFAULT_INDICE = 0;

		// Token: 0x04000E2F RID: 3631
		public const int CONST_RT_820_CTRL_EA_VARIAVEL_DEFAULT_INDICE = 0;

		// Token: 0x04000E30 RID: 3632
		public const int CONST_RT_820_CTRL_EA_BLOQUEIO_DEFAULT_INDICE = 0;

		// Token: 0x04000E31 RID: 3633
		public const int CONST_RT_820_CTRL_ED_BLOQUEIO_DEFAULT_INDICE = 0;

		// Token: 0x04000E32 RID: 3634
		public const int CONST_RT_820_CTRL_ED_LIBERACAO_DEFAULT_INDICE = 0;

		// Token: 0x04000E33 RID: 3635
		public const int CONST_RT_820_CTRL_RESERSO_DEFAULT_INDICE = 0;

		// Token: 0x04000E34 RID: 3636
		public const int CONST_RT_820_CTRL_MODO_DEFAULT_INDICE = 0;

		// Token: 0x04000E35 RID: 3637
		public const int CONST_RT_820_CTRL_GRUPO_DEFAULT_INDICE = 0;

		// Token: 0x04000E36 RID: 3638
		public const int CONST_RT_820_DEFAULT_SIMULTANEOS = 0;

		// Token: 0x04000E37 RID: 3639
		public const int CONST_RT_820_LMTE_INF_SIMULTANEOS = 0;

		// Token: 0x04000E38 RID: 3640
		public const int CONST_RT_820_LMTE_SUP_SIMULTANEOS = 4;

		// Token: 0x04000E39 RID: 3641
		public const int CONST_RT_820_NUMERO_SETPOINTS_HORARIO = 16;

		// Token: 0x04000E3A RID: 3642
		public const int CONST_RT_820_360_NUMERO_SETPOINTS_HORARIO = 80;

		// Token: 0x04000E3B RID: 3643
		public const int CONST_RT_820_360_NUMERO_FAIXAS_SETPOINTS_HORARIO = 10;

		// Token: 0x04000E3C RID: 3644
		public const int CONST_RT_820_NUMERO_REFERENCIA_PERIFERICO = 10;

		// Token: 0x04000E3D RID: 3645
		public const int CONST_RT_820_NUMERO_ATUADORES_PERIFERICO = 2;

		// Token: 0x04000E3E RID: 3646
		public const int CONST_RT_820_NUMERO_ATUADORES_SETPOINT_PERIFERICO = 3;

		// Token: 0x04000E3F RID: 3647
		public const int CONST_RT_820_CTRL_DEFAULT_TEMPO_MAX_PARTIDA = 180;

		// Token: 0x04000E40 RID: 3648
		public const int CONST_RT_820_CTRL_LMTE_SUP_TEMPO_MAX_PARTIDA = 1200;

		// Token: 0x04000E41 RID: 3649
		public const int CONST_RT_820_CTRL_LMTE_INF_TEMPO_MAX_PARTIDA = 0;

		// Token: 0x04000E42 RID: 3650
		public const int CONST_RT_820_CTRL_DEFAULT_TEMPO_MAX_PARADA = 180;

		// Token: 0x04000E43 RID: 3651
		public const int CONST_RT_820_CTRL_LMTE_SUP_TEMPO_MAX_PARADA = 1200;

		// Token: 0x04000E44 RID: 3652
		public const int CONST_RT_820_CTRL_LMTE_INF_TEMPO_MAX_PARADA = 0;

		// Token: 0x04000E45 RID: 3653
		public const int CONST_RT_820_CTRL_DEFAULT_TEMPO_MIN_OPERANDO = 180;

		// Token: 0x04000E46 RID: 3654
		public const int CONST_RT_820_CTRL_LMTE_SUP_TEMPO_MIN_OPERANDO = 1200;

		// Token: 0x04000E47 RID: 3655
		public const int CONST_RT_820_CTRL_LMTE_INF_TEMPO_MIN_OPERANDO = 0;

		// Token: 0x04000E48 RID: 3656
		public const int CONST_RT_820_CTRL_DEFAULT_TEMPO_MIN_PARADO = 180;

		// Token: 0x04000E49 RID: 3657
		public const int CONST_RT_820_CTRL_LMTE_SUP_TEMPO_MIN_PARADO = 1200;

		// Token: 0x04000E4A RID: 3658
		public const int CONST_RT_820_CTRL_LMTE_INF_TEMPO_MIN_PARADO = 0;

		// Token: 0x04000E4B RID: 3659
		public const int CONST_RT_820_GRUPO_DEFAULT_TEMPO_ENTRE_ACIONAMENTOS = 120;

		// Token: 0x04000E4C RID: 3660
		public const int CONST_RT_820_GRUPO_LMTE_SUP_TEMPO_ENTRE_ACIONAMENTOS = 1200;

		// Token: 0x04000E4D RID: 3661
		public const int CONST_RT_820_GRUPO_LMTE_INF_TEMPO_ENTRE_ACIONAMENTOS = 0;

		// Token: 0x04000E4E RID: 3662
		public const int CONST_RT_820_DEFAULT_TIMER = 0;

		// Token: 0x04000E4F RID: 3663
		public const int CONST_RT_820_LMTE_INF_TIMER = 0;

		// Token: 0x04000E50 RID: 3664
		public const int CONST_RT_820_LMTE_SUP_TIMER = 1439;

		// Token: 0x04000E51 RID: 3665
		public const int CONST_RT_820_ED_FUNCAO_DEFAULT_INDICE = 0;

		// Token: 0x04000E52 RID: 3666
		public const int CONST_RT_820_DEFAULT_ED = 0;

		// Token: 0x04000E53 RID: 3667
		public const int CONST_RT_820_LEITURA_VAZAO_DEFAULT_INDICE = 0;

		// Token: 0x04000E54 RID: 3668
		public const int CONST_RT_820_EQUIPAMENTO_PERIFERICO_DEFAULT_INDICE = 0;

		// Token: 0x04000E55 RID: 3669
		public const int CONST_RT_820_REP_HAB_DESABILITADOS = 21856;

		// Token: 0x04000E56 RID: 3670
		public const int CONST_RT_820_REP_HAB_HABILITADOS = 21857;

		// Token: 0x04000E57 RID: 3671
		public const int CONST_RT_820_REP_HAB_DEFAULT = 21856;

		// Token: 0x04000E58 RID: 3672
		public const int CONST_RT_820_REP_DEFAULT_END_REPETIDORA = 0;

		// Token: 0x04000E59 RID: 3673
		public const int CONST_RT_820_REP_LMTE_SUP_END_REPETIDORA = 200;

		// Token: 0x04000E5A RID: 3674
		public const int CONST_RT_820_REP_LMTE_INF_END_REPETIDORA = 0;

		// Token: 0x04000E5B RID: 3675
		public const int CONST_RT_820_REP_DEFAULT_NUM_ESTACOES = 0;

		// Token: 0x04000E5C RID: 3676
		public const int CONST_RT_820_REP_LMTE_SUP_NUM_ESTACOES = 200;

		// Token: 0x04000E5D RID: 3677
		public const int CONST_RT_820_REP_LMTE_INF_NUM_ESTACOES = 0;

		// Token: 0x04000E5E RID: 3678
		public const int CONST_RT_820_REP_DEFAULT_ENDERECOS = 0;

		// Token: 0x04000E5F RID: 3679
		public const int CONST_RT_820_REP_LMTE_SUP_ENDERECOS = 200;

		// Token: 0x04000E60 RID: 3680
		public const int CONST_RT_820_REP_LMTE_INF_ENDERECOS = 0;

		// Token: 0x04000E61 RID: 3681
		public const int CONST_RT_820_DEFAULT_SETPOINT_ALTO = 4000;

		// Token: 0x04000E62 RID: 3682
		public const int CONST_RT_820_DEFAULT_SETPOINT_BAIXO = 0;

		// Token: 0x04000E63 RID: 3683
		public const int CONST_RT_820_LMTE_INF_SETPOINT = 0;

		// Token: 0x04000E64 RID: 3684
		public const int CONST_RT_820_LMTE_SUP_SETPOINT = 4000;

		// Token: 0x04000E65 RID: 3685
		public const int CONST_RT_820_DEFAULT_SETPOINT_NIVEL_BLOQUEIO = 400;

		// Token: 0x04000E66 RID: 3686
		public const int CONST_RT_820_DEFAULT_SETPOINT_NIVEL_LIBERACAO = 800;

		// Token: 0x04000E67 RID: 3687
		public const int CONST_RT_820_CTRL_VARIAVEL_DEFAULT_INDICE = 0;

		// Token: 0x04000E68 RID: 3688
		public const int CONST_RT_820_CTRL_BLOQUEIO_DEFAULT_INDICE = 0;

		// Token: 0x04000E69 RID: 3689
		public const int CONST_COLUNA_PROCESSO_SD_ACIONAMENTO_820_400 = 0;

		// Token: 0x04000E6A RID: 3690
		public const int CONST_COLUNA_PROCESSO_ED_ACIONAMENTO_820_400 = 1;

		// Token: 0x04000E6B RID: 3691
		public const int CONST_COLUNA_PROCESSO_SD_DESACIONAMENTO_820_400 = 2;

		// Token: 0x04000E6C RID: 3692
		public const int CONST_COLUNA_PROCESSO_ED_DESACIONAMENTO_820_400 = 3;

		// Token: 0x04000E6D RID: 3693
		public const int CONST_COLUNA_PROCESSO_ED_REMOTO_820_400 = 4;

		// Token: 0x04000E6E RID: 3694
		public const int CONST_COLUNA_PROCESSO_ED_BLOQUEIO_820_400 = 5;

		// Token: 0x04000E6F RID: 3695
		public const int CONST_COLUNA_PROCESSO_ED_LIBERACAO_820_400 = 6;

		// Token: 0x04000E70 RID: 3696
		public const int CONST_COLUNA_PROCESSO_REVERSO_820_400 = 7;

		// Token: 0x04000E71 RID: 3697
		public const int CONST_COLUNA_PROCESSO_MODO_820_400 = 8;

		// Token: 0x04000E72 RID: 3698
		public const int CONST_COLUNA_PROCESSO_GRUPO_820_400 = 9;

		// Token: 0x04000E73 RID: 3699
		public const int CONST_COLUNA_PROCESSO_GRUPO_PARTIDA_820_400 = 10;

		// Token: 0x04000E74 RID: 3700
		public const int CONST_COLUNA_PROCESSO_TEMPO_MAX_PARTIDA_820_400 = 11;

		// Token: 0x04000E75 RID: 3701
		public const int CONST_COLUNA_PROCESSO_TEMPO_MAX_PARADA_820_400 = 12;

		// Token: 0x04000E76 RID: 3702
		public const int CONST_COLUNA_PROCESSO_TEMPO_MAX_PARADO_820_400 = 13;

		// Token: 0x04000E77 RID: 3703
		public const int CONST_COLUNA_PROCESSO_TEMPO_MAX_OPERANDO_820_400 = 14;

		// Token: 0x04000E78 RID: 3704
		public const int CONST_COLUNA_GRUPO_ACIONAMENTO_SIMULTANEOS = 0;

		// Token: 0x04000E79 RID: 3705
		public const int CONST_COLUNA_GRUPO_TEMPO_ENTRE_ACIONAMENTOS = 1;

		// Token: 0x04000E7A RID: 3706
		public const int CONST_COLUNA_GRUPO_ROTACAO_MOTORES = 2;

		// Token: 0x04000E7B RID: 3707
		public const int CONST_COLUNA_PROCESSO_SD_ACIONAMENTO = 0;

		// Token: 0x04000E7C RID: 3708
		public const int CONST_COLUNA_PROCESSO_ED_ACIONAMENTO = 1;

		// Token: 0x04000E7D RID: 3709
		public const int CONST_COLUNA_PROCESSO_SD_DESACIONAMENTO = 2;

		// Token: 0x04000E7E RID: 3710
		public const int CONST_COLUNA_PROCESSO_ED_DESACIONAMENTO = 3;

		// Token: 0x04000E7F RID: 3711
		public const int CONST_COLUNA_PROCESSO_ED_REMOTO = 4;

		// Token: 0x04000E80 RID: 3712
		public const int CONST_COLUNA_PROCESSO_ED_BLOQUEIO = 5;

		// Token: 0x04000E81 RID: 3713
		public const int CONST_COLUNA_PROCESSO_ED_LIBERACAO = 6;

		// Token: 0x04000E82 RID: 3714
		public const int CONST_COLUNA_PROCESSO_REVERSO = 7;

		// Token: 0x04000E83 RID: 3715
		public const int CONST_COLUNA_PROCESSO_MODO = 8;

		// Token: 0x04000E84 RID: 3716
		public const int CONST_COLUNA_PROCESSO_GRUPO = 9;

		// Token: 0x04000E85 RID: 3717
		public const int CONST_COLUNA_PROCESSO_TEMPO_MAX_PARTIDA = 10;

		// Token: 0x04000E86 RID: 3718
		public const int CONST_COLUNA_PROCESSO_TEMPO_MAX_PARADA = 11;

		// Token: 0x04000E87 RID: 3719
		public const int CONST_COLUNA_PROCESSO_TEMPO_MAX_PARADO = 12;

		// Token: 0x04000E88 RID: 3720
		public const int CONST_COLUNA_PROCESSO_TEMPO_MAX_OPERANDO = 13;

		// Token: 0x04000E89 RID: 3721
		public const int CONST_COLUNA_EA_RANGE = 0;

		// Token: 0x04000E8A RID: 3722
		public const int CONST_COLUNA_EA_INICIO = 1;

		// Token: 0x04000E8B RID: 3723
		public const int CONST_COLUNA_EA_FIM = 2;

		// Token: 0x04000E8C RID: 3724
		public const int CONST_COLUNA_SETPOINT_CONTROLE_RT_820 = 0;

		// Token: 0x04000E8D RID: 3725
		public const int CONST_COLUNA_SETPOINT_NIVEL_BAIXO_RT_820 = 1;

		// Token: 0x04000E8E RID: 3726
		public const int CONST_COLUNA_SETPOINT_NIVEL_ALTO_RT_820 = 2;

		// Token: 0x04000E8F RID: 3727
		public const int CONST_COLUNA_SETPOINT_BLOQUEIO_RT_820 = 3;

		// Token: 0x04000E90 RID: 3728
		public const int CONST_COLUNA_SETPOINT_NIVEL_BLOQUEIO_RT_820 = 4;

		// Token: 0x04000E91 RID: 3729
		public const int CONST_COLUNA_SETPOINT_NIVEL_LIBERACAO_RT_820 = 5;

		// Token: 0x04000E92 RID: 3730
		public const int CONST_COLUNA_PERIFERICOS_MODELO = 0;

		// Token: 0x04000E93 RID: 3731
		public const int CONST_COLUNA_PERIFERICOS_ENDERECO = 1;

		// Token: 0x04000E94 RID: 3732
		public const int CONST_COLUNNA_PERFIFERICOS_MODBUSGENERICO_ENDMEM = 0;

		// Token: 0x04000E95 RID: 3733
		public const int CONST_COLUNNA_PERFIFERICOS_MODBUSGENERICO_FUNC = 1;

		// Token: 0x04000E96 RID: 3734
		public const int CONST_COLUNNA_PERFIFERICOS_MODBUSGENERICO_MEM1 = 2;

		// Token: 0x04000E97 RID: 3735
		public const int CONST_COLUNNA_PERFIFERICOS_MODBUSGENERICO_VAR1 = 3;

		// Token: 0x04000E98 RID: 3736
		public const int CONST_COLUNNA_PERFIFERICOS_MODBUSGENERICO_MEM2 = 4;

		// Token: 0x04000E99 RID: 3737
		public const int CONST_COLUNNA_PERFIFERICOS_MODBUSGENERICO_VAR2 = 5;

		// Token: 0x04000E9A RID: 3738
		public const int CONST_COLUNNA_PERFIFERICOS_MODBUSGENERICO_MEM3 = 6;

		// Token: 0x04000E9B RID: 3739
		public const int CONST_COLUNNA_PERFIFERICOS_MODBUSGENERICO_VAR3 = 7;

		// Token: 0x04000E9C RID: 3740
		public const int CONST_COLUNNA_PERFIFERICOS_MODBUSGENERICO_MEM4 = 8;

		// Token: 0x04000E9D RID: 3741
		public const int CONST_COLUNNA_PERFIFERICOS_MODBUSGENERICO_VAR4 = 9;

		// Token: 0x04000E9E RID: 3742
		public const int CONST_COLUNA_REFERENCIAPERIFERICOS_PERIFERICO = 0;

		// Token: 0x04000E9F RID: 3743
		public const int CONST_COLUNA_REFERENCIAPERIFERICOS_MEMORIA = 1;

		// Token: 0x04000EA0 RID: 3744
		public const int CONST_COLUNA_REFERENCIAPERIFERICOS_VARIAVEL1 = 2;

		// Token: 0x04000EA1 RID: 3745
		public const int CONST_COLUNA_REFERENCIAPERIFERICOS_VARIAVEL2 = 3;

		// Token: 0x04000EA2 RID: 3746
		public const int CONST_COLUNA_REFERENCIAPERIFERICOS_ESCALA = 4;

		// Token: 0x04000EA3 RID: 3747
		public const int CONST_COLUNA_REFERENCIAPERIFERICOS_FORMATO = 5;

		// Token: 0x04000EA4 RID: 3748
		public const int CONST_COLUNA_REFERENCIAPERIFERICOS_BASE10 = 6;

		// Token: 0x04000EA5 RID: 3749
		public const int CONST_NUMERO_COLUNAS_ATUADOR = 13;

		// Token: 0x04000EA6 RID: 3750
		public const int CONST_COLUNA_ATUADOR_PERIFERICO = 0;

		// Token: 0x04000EA7 RID: 3751
		public const int CONST_COLUNA_ATUADOR_MEMORIA = 1;

		// Token: 0x04000EA8 RID: 3752
		public const int CONST_COLUNA_ATUADOR_VARIAVEL1 = 2;

		// Token: 0x04000EA9 RID: 3753
		public const int CONST_COLUNA_ATUADOR_ESCALA1 = 3;

		// Token: 0x04000EAA RID: 3754
		public const int CONST_COLUNA_ATUADOR_VARIAVEL2 = 4;

		// Token: 0x04000EAB RID: 3755
		public const int CONST_COLUNA_ATUADOR_ESCALA2 = 5;

		// Token: 0x04000EAC RID: 3756
		public const int CONST_COLUNA_ATUADOR_HISTERESE = 6;

		// Token: 0x04000EAD RID: 3757
		public const int CONST_COLUNA_ATUADOR_FORMATO = 7;

		// Token: 0x04000EAE RID: 3758
		public const int CONST_COLUNA_ATUADOR_BASE10 = 8;

		// Token: 0x04000EAF RID: 3759
		public const int CONST_COLUNA_ATUADOR_V1BAIXO = 9;

		// Token: 0x04000EB0 RID: 3760
		public const int CONST_COLUNA_ATUADOR_V1ALTO = 10;

		// Token: 0x04000EB1 RID: 3761
		public const int CONST_COLUNA_ATUADOR_V2BAIXO = 11;

		// Token: 0x04000EB2 RID: 3762
		public const int CONST_COLUNA_ATUADOR_V2ALTO = 12;

		// Token: 0x04000EB3 RID: 3763
		public const int CONST_NUMERO_COLUNAS_ATUADOR_SP = 14;

		// Token: 0x04000EB4 RID: 3764
		public const int COSNT_COLUNA_ATUADOR_SP_HORA = 0;

		// Token: 0x04000EB5 RID: 3765
		public const int COSNT_COLUNA_ATUADOR_SP_MINUTO = 1;

		// Token: 0x04000EB6 RID: 3766
		public const int COSNT_COLUNA_ATUADOR_SP_REF1 = 2;

		// Token: 0x04000EB7 RID: 3767
		public const int COSNT_COLUNA_ATUADOR_SP_SETPONT1 = 3;

		// Token: 0x04000EB8 RID: 3768
		public const int COSNT_COLUNA_ATUADOR_SP_REF2 = 4;

		// Token: 0x04000EB9 RID: 3769
		public const int COSNT_COLUNA_ATUADOR_SP_SETPONT2 = 5;

		// Token: 0x04000EBA RID: 3770
		public const int COSNT_COLUNA_ATUADOR_SP_REF3 = 6;

		// Token: 0x04000EBB RID: 3771
		public const int COSNT_COLUNA_ATUADOR_SP_SETPONT3 = 7;

		// Token: 0x04000EBC RID: 3772
		public const int COSNT_COLUNA_ATUADOR_SP_REF4 = 8;

		// Token: 0x04000EBD RID: 3773
		public const int COSNT_COLUNA_ATUADOR_SP_SETPONT4 = 9;

		// Token: 0x04000EBE RID: 3774
		public const int COSNT_COLUNA_ATUADOR_SP_REF5 = 10;

		// Token: 0x04000EBF RID: 3775
		public const int COSNT_COLUNA_ATUADOR_SP_SETPONT5 = 11;

		// Token: 0x04000EC0 RID: 3776
		public const int COSNT_COLUNA_ATUADOR_SP_REF6 = 12;

		// Token: 0x04000EC1 RID: 3777
		public const int COSNT_COLUNA_ATUADOR_SP_SETPONT6 = 13;

		// Token: 0x04000EC2 RID: 3778
		public const int CONST_NUMERO_COLUNAS_ATUADOR_SP2 = 12;

		// Token: 0x04000EC3 RID: 3779
		public const int COSNT_COLUNA_ATUADOR_SP2_REF1 = 0;

		// Token: 0x04000EC4 RID: 3780
		public const int COSNT_COLUNA_ATUADOR_SP2_SETPONT1 = 1;

		// Token: 0x04000EC5 RID: 3781
		public const int COSNT_COLUNA_ATUADOR_SP2_REF2 = 2;

		// Token: 0x04000EC6 RID: 3782
		public const int COSNT_COLUNA_ATUADOR_SP2_SETPONT2 = 3;

		// Token: 0x04000EC7 RID: 3783
		public const int COSNT_COLUNA_ATUADOR_SP2_REF3 = 4;

		// Token: 0x04000EC8 RID: 3784
		public const int COSNT_COLUNA_ATUADOR_SP2_SETPONT3 = 5;

		// Token: 0x04000EC9 RID: 3785
		public const int COSNT_COLUNA_ATUADOR_SP2_REF4 = 6;

		// Token: 0x04000ECA RID: 3786
		public const int COSNT_COLUNA_ATUADOR_SP2_SETPONT4 = 7;

		// Token: 0x04000ECB RID: 3787
		public const int COSNT_COLUNA_ATUADOR_SP2_REF5 = 8;

		// Token: 0x04000ECC RID: 3788
		public const int COSNT_COLUNA_ATUADOR_SP2_SETPONT5 = 9;

		// Token: 0x04000ECD RID: 3789
		public const int COSNT_COLUNA_ATUADOR_SP2_REF6 = 10;

		// Token: 0x04000ECE RID: 3790
		public const int COSNT_COLUNA_ATUADOR_SP2_SETPONT6 = 11;

		// Token: 0x04000ECF RID: 3791
		public const int CONST_RT_820_DEFAULT_REFERENCIAPERIFERICOS_PERIFERICO = 0;

		// Token: 0x04000ED0 RID: 3792
		public const int CONST_RT_820_DEFAULT_REFERENCIAPERIFERICOS_ENDERECO = 0;

		// Token: 0x04000ED1 RID: 3793
		public const int CONST_RT_820_DEFAULT_REFERENCIAPERIFERICOS_VARIAVEL = 0;

		// Token: 0x04000ED2 RID: 3794
		public const int CONST_RT_820_DEFAULT_REFERENCIAPERIFERICOS_INICIO = 0;

		// Token: 0x04000ED3 RID: 3795
		public const int CONST_RT_820_DEFAULT_REFERENCIAPERIFERICOS_FIM = 0;

		// Token: 0x04000ED4 RID: 3796
		public const int CONST_RT_820_DEFAULT_REFERENCIAPERIFERICOS_FORMATO = 0;

		// Token: 0x04000ED5 RID: 3797
		public const int CONST_COLUNA_VAZOES_ENTRADA = 0;

		// Token: 0x04000ED6 RID: 3798
		public const int CONST_COLUNA_ENTRADA_DIGITAL = 0;

		// Token: 0x04000ED7 RID: 3799
		public const int CONST_RT_820_DEFAULT_END_PERIFERICOS = 0;

		// Token: 0x04000ED8 RID: 3800
		public const int CONST_RT_820_LMTE_SUP_END_PERIFERICOS = 255;

		// Token: 0x04000ED9 RID: 3801
		public const int CONST_RT_820_LMTE_INF_END_PERIFERICOS = 0;

		// Token: 0x04000EDA RID: 3802
		public const int CONST_RT_820_360_DEFAULT_END_MEMORIA = 0;

		// Token: 0x04000EDB RID: 3803
		public const int CONST_RT_820_360_LMTE_SUP_END_MEMORIA = 65535;

		// Token: 0x04000EDC RID: 3804
		public const int CONST_RT_820_360_LMTE_INF_END_MEMORIA = 0;

		// Token: 0x04000EDD RID: 3805
		public const int CONST_RT_820_360_DEFAULT_VARS_MEMORIA = 0;

		// Token: 0x04000EDE RID: 3806
		public const int CONST_RT_820_360_LMTE_SUP_VARS_MEMORIA = 10;

		// Token: 0x04000EDF RID: 3807
		public const int CONST_RT_820_360_LMTE_INF_VARS_MEMORIA = 0;

		// Token: 0x04000EE0 RID: 3808
		public const int CONST_COLUNA_CALHA_EA = 0;

		// Token: 0x04000EE1 RID: 3809
		public const int CONST_COLUNA_CALHA_TIPO_CALHA = 1;

		// Token: 0x04000EE2 RID: 3810
		public const int CONST_COLUNA_CALHA_FUNDO_CM = 2;

		// Token: 0x04000EE3 RID: 3811
		public const int CONST_COLUNA_CALHA_P1 = 3;

		// Token: 0x04000EE4 RID: 3812
		public const int CONST_COLUNA_CALHA_P2 = 4;

		// Token: 0x04000EE5 RID: 3813
		public const int CONST_COLUNA_CALHA_P3 = 5;

		// Token: 0x04000EE6 RID: 3814
		public const int NUMERO_COLUNAS_CALHA = 6;

		// Token: 0x04000EE7 RID: 3815
		public const int CONST_COLUNA_REPETIDORA_ENDERECO_1 = 1;

		// Token: 0x04000EE8 RID: 3816
		public const int CONST_COLUNA_REPETIDORA_ENDERECO_2 = 3;

		// Token: 0x04000EE9 RID: 3817
		public const int CONST_COLUNA_REPETIDORA_ENDERECO_3 = 5;

		// Token: 0x04000EEA RID: 3818
		public const int CONST_COLUNA_REPETIDORA_ENDERECO_4 = 7;

		// Token: 0x04000EEB RID: 3819
		public const int CONST_COLUNA_REPETIDORA_ENDERECO_5 = 9;

		// Token: 0x04000EEC RID: 3820
		public const int CONST_COLUNA_TIMER_F1_ON_RT_820 = 0;

		// Token: 0x04000EED RID: 3821
		public const int CONST_COLUNA_TIMER_F1_OFF_RT_820 = 1;

		// Token: 0x04000EEE RID: 3822
		public const int CONST_COLUNA_TIMER_F2_ON_RT_820 = 2;

		// Token: 0x04000EEF RID: 3823
		public const int CONST_COLUNA_TIMER_F2_OFF_RT_820 = 3;

		// Token: 0x04000EF0 RID: 3824
		public const int CONST_COLUNA_TIMER_F3_ON_RT_820 = 4;

		// Token: 0x04000EF1 RID: 3825
		public const int CONST_COLUNA_TIMER_F3_OFF_RT_820 = 5;

		// Token: 0x04000EF2 RID: 3826
		public const int CONST_COLUNA_TIMER_F4_ON_RT_820 = 6;

		// Token: 0x04000EF3 RID: 3827
		public const int CONST_COLUNA_TIMER_F4_OFF_RT_820 = 7;

		// Token: 0x04000EF4 RID: 3828
		public const int CONST_COLUNA_TIMER_F5_ON_RT_820 = 8;

		// Token: 0x04000EF5 RID: 3829
		public const int CONST_COLUNA_TIMER_F5_OFF_RT_820 = 9;

		// Token: 0x04000EF6 RID: 3830
		public const int CONST_COLUNA_TIMER_F6_ON_RT_820 = 10;

		// Token: 0x04000EF7 RID: 3831
		public const int CONST_COLUNA_TIMER_F6_OFF_RT_820 = 11;

		// Token: 0x04000EF8 RID: 3832
		public const int CONST_RT_820_EXPANCAO_IO_DESABILITADA = 21856;

		// Token: 0x04000EF9 RID: 3833
		public const int CONST_RT_820_EXPANCAO_IO_HABILITADA = 21857;

		// Token: 0x04000EFA RID: 3834
		public const int CONST_RT_821 = 2;

		// Token: 0x04000EFB RID: 3835
		public const int CONST_RT_821_SD = 3;

		// Token: 0x04000EFC RID: 3836
		public const int CONST_RT_821_MOTORES = 3;

		// Token: 0x04000EFD RID: 3837
		public const int CONST_RT_821_ED = 8;

		// Token: 0x04000EFE RID: 3838
		public const int CONST_RT_821_EA = 4;

		// Token: 0x04000EFF RID: 3839
		public const int CONST_RT_821_CTRL = 3;

		// Token: 0x04000F00 RID: 3840
		public const int CONST_RT_821_NUM_MAX_REPETIDORAS = 50;

		// Token: 0x04000F01 RID: 3841
		public const int CONST_RT_821_SETPOINTS = 3;

		// Token: 0x04000F02 RID: 3842
		public const int CONST_RT_821_MODELO_EMULADO_DEFAULT_INDICE = 0;

		// Token: 0x04000F03 RID: 3843
		public const int CONST_RT_821_DEFAULT_EQUIP = 0;

		// Token: 0x04000F04 RID: 3844
		public const int CONST_RT_821_DEFAULT_VERSAO = 0;

		// Token: 0x04000F05 RID: 3845
		public const int CONST_RT_821_DEFAULT_BUILD = 0;

		// Token: 0x04000F06 RID: 3846
		public const int CONST_RT_821_DEFAULT_RELEASE = 0;

		// Token: 0x04000F07 RID: 3847
		public const int CONST_RT_821_DEFAULT_END_ESTACAO = 1;

		// Token: 0x04000F08 RID: 3848
		public const int CONST_RT_821_LMTE_SUP_END_ESTACAO = 200;

		// Token: 0x04000F09 RID: 3849
		public const int CONST_RT_821_LMTE_INF_END_ESTACAO = 1;

		// Token: 0x04000F0A RID: 3850
		public const int CONST_RT_821_DEFAULT_END_MESTRE = 100;

		// Token: 0x04000F0B RID: 3851
		public const int CONST_RT_821_LMTE_SUP_END_MESTRE = 200;

		// Token: 0x04000F0C RID: 3852
		public const int CONST_RT_821_LMTE_INF_END_MESTRE = 1;

		// Token: 0x04000F0D RID: 3853
		public const int CONST_RT_821_DEFAULT_EMULACAO = 0;

		// Token: 0x04000F0E RID: 3854
		public const int CONST_RT_821_EMULACAO_INDICE = 0;

		// Token: 0x04000F0F RID: 3855
		public const int CONST_RT_821_HAB_REP_DESABILITADOS = 21856;

		// Token: 0x04000F10 RID: 3856
		public const int CONST_RT_821_HAB_REP_HABILITADOS = 21857;

		// Token: 0x04000F11 RID: 3857
		public const int CONST_RT_821_MODO_REPETIDORA_DEFAULT_INDICE = 0;

		// Token: 0x04000F12 RID: 3858
		public const int CONST_RT_821_DEFAULT_END_REPETIDORAS = 1;

		// Token: 0x04000F13 RID: 3859
		public const int CONST_RT_821_LMTE_SUP_END_REPETIDORAS = 200;

		// Token: 0x04000F14 RID: 3860
		public const int CONST_RT_821_LMTE_INF_END_REPETIDORAS = 1;

		// Token: 0x04000F15 RID: 3861
		public const int CONST_RT_821_DEFAULT_NUM_REPETIDORAS = 0;

		// Token: 0x04000F16 RID: 3862
		public const int CONST_RT_821_LMTE_SUP_NUM_REPETIDORAS = 50;

		// Token: 0x04000F17 RID: 3863
		public const int CONST_RT_821_LMTE_INF_NUM_REPETIDORAS = 0;

		// Token: 0x04000F18 RID: 3864
		public const int CONST_RT_821_DEFAULT_REP_ENDERECOS = 0;

		// Token: 0x04000F19 RID: 3865
		public const int CONST_RT_821_LMTE_SUP_REP_ENDERECOS = 200;

		// Token: 0x04000F1A RID: 3866
		public const int CONST_RT_821_LMTE_INF_REP_ENDERECOS = 0;

		// Token: 0x04000F1B RID: 3867
		public const int CONST_RT_821_DEFAULT_TEMPO_PTT = 200;

		// Token: 0x04000F1C RID: 3868
		public const int CONST_RT_821_LMTE_SUP_TEMPO_PTT = 2000;

		// Token: 0x04000F1D RID: 3869
		public const int CONST_RT_821_LMTE_INF_TEMPO_PTT = 100;

		// Token: 0x04000F1E RID: 3870
		public const int CONST_RT_821_DEFAULT_AD_INTERVALO = 1000;

		// Token: 0x04000F1F RID: 3871
		public const int CONST_RT_821_LMTE_SUP_AD_INTERVALO = 20000;

		// Token: 0x04000F20 RID: 3872
		public const int CONST_RT_821_LMTE_INF_AD_INTERVALO = 500;

		// Token: 0x04000F21 RID: 3873
		public const int CONST_RT_821_DEFAULT_AD_TAMANHO_FILTRO = 3;

		// Token: 0x04000F22 RID: 3874
		public const int CONST_RT_821_LMTE_SUP_AD_TAMANHO_FILTRO = 10;

		// Token: 0x04000F23 RID: 3875
		public const int CONST_RT_821_LMTE_INF_AD_TAMANHO_FILTRO = 1;

		// Token: 0x04000F24 RID: 3876
		public const int CONST_RT_821_DEFAULT_EA_RANGE = 4000;

		// Token: 0x04000F25 RID: 3877
		public const int CONST_RT_821_LMTE_INF_EA_Range = 0;

		// Token: 0x04000F26 RID: 3878
		public const int CONST_RT_821_LMTE_SUP_EA_Range = 50000;

		// Token: 0x04000F27 RID: 3879
		public const int CONST_RT_821_DEFAULT_EA_INICIO = 0;

		// Token: 0x04000F28 RID: 3880
		public const int CONST_RT_821_LMTE_INF_EA_INICIO = 0;

		// Token: 0x04000F29 RID: 3881
		public const int CONST_RT_821_LMTE_SUP_EA_INICIO = 20000;

		// Token: 0x04000F2A RID: 3882
		public const int CONST_RT_821_DEFAULT_EA_FIM = 4000;

		// Token: 0x04000F2B RID: 3883
		public const int CONST_RT_821_LMTE_INF_EA_FIM = 0;

		// Token: 0x04000F2C RID: 3884
		public const int CONST_RT_821_LMTE_SUP_EA_FIM = 50000;

		// Token: 0x04000F2D RID: 3885
		public const int CONST_RT_821_CTRL_ACIONAMENTO_SAIDA_DEFAULT_INDICE = 0;

		// Token: 0x04000F2E RID: 3886
		public const int CONST_RT_821_CTRL_ACIONAMENTO_ENTRADA_DEFAULT_INDICE = 0;

		// Token: 0x04000F2F RID: 3887
		public const int CONST_RT_821_CTRL_REMOTO_ENTRADA_DEFAULT_INDICE = 0;

		// Token: 0x04000F30 RID: 3888
		public const int CONST_RT_821_CTRL_MODO_DEFAULT_INDICE = 0;

		// Token: 0x04000F31 RID: 3889
		public const int CONST_RT_821_REVERSO_DEFAULT_INDICE = 0;

		// Token: 0x04000F32 RID: 3890
		public const int CONST_RT_821_MODO_DEFAULT_INDICE = 0;

		// Token: 0x04000F33 RID: 3891
		public const int CONST_RT_821_CTRL_EA_VARIAVEL_DEFAULT_INDICE = 0;

		// Token: 0x04000F34 RID: 3892
		public const int CONST_RT_821_VISOR_PTO_DECIMAL_INDICE = 0;

		// Token: 0x04000F35 RID: 3893
		public const int CONST_RT_821_DEFAULT_SIMULTANEOS = 0;

		// Token: 0x04000F36 RID: 3894
		public const int CONST_RT_821_LMTE_INF_SIMULTANEOS = 0;

		// Token: 0x04000F37 RID: 3895
		public const int CONST_RT_821_LMTE_SUP_SIMULTANEOS = 3;

		// Token: 0x04000F38 RID: 3896
		public const int CONST_RT_821_CTRL_DEFAULT_TEMPO_MAX_PARTIDA = 180;

		// Token: 0x04000F39 RID: 3897
		public const int CONST_RT_821_CTRL_LMTE_SUP_TEMPO_MAX_PARTIDA = 1200;

		// Token: 0x04000F3A RID: 3898
		public const int CONST_RT_821_CTRL_LMTE_INF_TEMPO_MAX_PARTIDA = 0;

		// Token: 0x04000F3B RID: 3899
		public const int CONST_RT_821_CTRL_DEFAULT_TEMPO_MAX_PARADA = 180;

		// Token: 0x04000F3C RID: 3900
		public const int CONST_RT_821_CTRL_LMTE_SUP_TEMPO_MAX_PARADA = 1200;

		// Token: 0x04000F3D RID: 3901
		public const int CONST_RT_821_CTRL_LMTE_INF_TEMPO_MAX_PARADA = 0;

		// Token: 0x04000F3E RID: 3902
		public const int CONST_RT_821_SIMULTANEOS = 1;

		// Token: 0x04000F3F RID: 3903
		public const int CONST_RT_821_SIMULTANEOS_DEFAULT_INDICE = 2;

		// Token: 0x04000F40 RID: 3904
		public const int CONST_RT_821_DEFAULT_TEMPO_ENTRE_ACIONAMENTOS = 0;

		// Token: 0x04000F41 RID: 3905
		public const int CONST_RT_821_LMTE_INF_TEMPO_ENTRE_ACIONAMENTOS = 0;

		// Token: 0x04000F42 RID: 3906
		public const int CONST_RT_821_LMTE_SUP_TEMPO_ENTRE_ACIONAMENTOS = 1200;

		// Token: 0x04000F43 RID: 3907
		public const int CONST_RT_821_ED_FUNCAO_DEFAULT_INDICE = 0;

		// Token: 0x04000F44 RID: 3908
		public const int CONST_RT_821_DEFAULT_ED = 0;

		// Token: 0x04000F45 RID: 3909
		public const int CONST_RT_821_REP_HAB_DESABILITADOS = 21856;

		// Token: 0x04000F46 RID: 3910
		public const int CONST_RT_821_REP_HAB_HABILITADOS = 21857;

		// Token: 0x04000F47 RID: 3911
		public const int CONST_RT_821_REP_HAB_DEFAULT = 21856;

		// Token: 0x04000F48 RID: 3912
		public const int CONST_RT_821_REP_DEFAULT_END_REPETIDORA = 0;

		// Token: 0x04000F49 RID: 3913
		public const int CONST_RT_821_REP_LMTE_SUP_END_REPETIDORA = 200;

		// Token: 0x04000F4A RID: 3914
		public const int CONST_RT_821_REP_LMTE_INF_END_REPETIDORA = 0;

		// Token: 0x04000F4B RID: 3915
		public const int CONST_RT_821_REP_DEFAULT_NUM_ESTACOES = 0;

		// Token: 0x04000F4C RID: 3916
		public const int CONST_RT_821_REP_LMTE_SUP_NUM_ESTACOES = 200;

		// Token: 0x04000F4D RID: 3917
		public const int CONST_RT_821_REP_LMTE_INF_NUM_ESTACOES = 0;

		// Token: 0x04000F4E RID: 3918
		public const int CONST_RT_821_REP_DEFAULT_ENDERECOS = 0;

		// Token: 0x04000F4F RID: 3919
		public const int CONST_RT_821_REP_LMTE_SUP_ENDERECOS = 200;

		// Token: 0x04000F50 RID: 3920
		public const int CONST_RT_821_REP_LMTE_INF_ENDERECOS = 0;

		// Token: 0x04000F51 RID: 3921
		public const int CONST_RT_821_DEFAULT_SETPOINT_ALTO = 4000;

		// Token: 0x04000F52 RID: 3922
		public const int CONST_RT_821_DEFAULT_SETPOINT_BAIXO = 0;

		// Token: 0x04000F53 RID: 3923
		public const int CONST_RT_821_LMTE_INF_SETPOINT = 0;

		// Token: 0x04000F54 RID: 3924
		public const int CONST_RT_821_LMTE_SUP_SETPOINT = 4000;

		// Token: 0x04000F55 RID: 3925
		public const int CONST_RT_821_CTRL_VARIAVEL_DEFAULT_INDICE = 0;

		// Token: 0x04000F56 RID: 3926
		public const int CONST_RT_821_CTRL_BLOQUEIO_DEFAULT_INDICE = 0;

		// Token: 0x04000F57 RID: 3927
		public const int CONST_COLUNA_PROCESSO_SD_ACIONAMENTO_RT_821 = 0;

		// Token: 0x04000F58 RID: 3928
		public const int CONST_COLUNA_PROCESSO_ED_ACIONAMENTO_RT_821 = 1;

		// Token: 0x04000F59 RID: 3929
		public const int CONST_COLUNA_PROCESSO_ED_REMOTO_RT_821 = 2;

		// Token: 0x04000F5A RID: 3930
		public const int CONST_COLUNA_PROCESSO_REVERSO_RT_821 = 3;

		// Token: 0x04000F5B RID: 3931
		public const int CONST_COLUNA_PROCESSO_MODO_RT_821 = 4;

		// Token: 0x04000F5C RID: 3932
		public const int CONST_COLUNA_PROCESSO_TEMPO_MAX_PARTIDA_RT_821 = 5;

		// Token: 0x04000F5D RID: 3933
		public const int CONST_COLUNA_PROCESSO_TEMPO_MAX_PARADA_RT_821 = 6;

		// Token: 0x04000F5E RID: 3934
		public const int CONST_COLUNA_PROCESSO_NUMERO_RT_821 = 7;

		// Token: 0x04000F5F RID: 3935
		public const int CONST_COLUNA_MOTORES_SIMULTANEOS_RT_821 = 0;

		// Token: 0x04000F60 RID: 3936
		public const int CONST_COLUNA_MOTORES_TEMPO_ENTRE_ACIONAMENTOS_RT_821 = 1;

		// Token: 0x04000F61 RID: 3937
		public const int CONST_COLUNA_MOTORES_SIMULTANEOS_NUMERO_RT_821 = 2;

		// Token: 0x04000F62 RID: 3938
		public const int CONST_COLUNA_EA_RANGE_RT_821 = 0;

		// Token: 0x04000F63 RID: 3939
		public const int CONST_COLUNA_EA_INICIO_RT_821 = 1;

		// Token: 0x04000F64 RID: 3940
		public const int CONST_COLUNA_EA_FIM_RT_821 = 2;

		// Token: 0x04000F65 RID: 3941
		public const int CONST_COLUNA_EA_NUMERO_RT_821 = 3;

		// Token: 0x04000F66 RID: 3942
		public const int CONST_COLUNA_SETPOINT_CONTROLE_RT_821 = 0;

		// Token: 0x04000F67 RID: 3943
		public const int CONST_COLUNA_SETPOINT_NIVEL_BAIXO_RT_821 = 1;

		// Token: 0x04000F68 RID: 3944
		public const int CONST_COLUNA_SETPOINT_NIVEL_ALTO_RT_821 = 2;

		// Token: 0x04000F69 RID: 3945
		public const int CONST_COLUNA_SETPOINT_NUMERO_RT_821 = 3;

		// Token: 0x04000F6A RID: 3946
		public const int CONST_COLUNA_ENTRADA_DIGITAL_RT_821 = 0;

		// Token: 0x04000F6B RID: 3947
		public const int CONST_COLUNA_ENTRADA_DIGITAL_NUMERO_RT_821 = 1;

		// Token: 0x04000F6C RID: 3948
		public const int CONST_COLUNA_VISOR_CONTROLE_RT_821 = 0;

		// Token: 0x04000F6D RID: 3949
		public const int CONST_COLUNA_VISOR_NOME_RT_821 = 1;

		// Token: 0x04000F6E RID: 3950
		public const int CONST_COLUNA_VISOR_ESCALA_RT_821 = 2;

		// Token: 0x04000F6F RID: 3951
		public const int CONST_COLUNA_VISOR_PTO_DEC_RT_821 = 3;

		// Token: 0x04000F70 RID: 3952
		public const int CONST_COLUNA_VISOR_NUMERO_RT_821 = 4;

		// Token: 0x04000F71 RID: 3953
		public const int CONST_RT_821_NUM_MSG_DISPLAY = 8;

		// Token: 0x04000F72 RID: 3954
		public const int CONST_RT_821_DEFAULT_ESCALA_DSP = 100;

		// Token: 0x04000F73 RID: 3955
		public const int CONST_RT_821_LMTE_INF_ESCALA_DSP = 0;

		// Token: 0x04000F74 RID: 3956
		public const int CONST_RT_821_LMTE_SUP_ESCALA_DSP = 999;

		// Token: 0x04000F75 RID: 3957
		public const int CONST_RT_821_DEFAULT_PTO_DSP = 0;

		// Token: 0x04000F76 RID: 3958
		public const int CONST_RT_821_LMTE_INF_PTO_DSP = 0;

		// Token: 0x04000F77 RID: 3959
		public const int CONST_RT_821_LMTE_SUP_PTO_DSP = 2;

		// Token: 0x04000F78 RID: 3960
		public const string CONST_RT_821_DEFAULT_MSG_DSP = "   ";

		// Token: 0x04000F79 RID: 3961
		public const int CONST_RT_821_MOD_RT821 = 0;

		// Token: 0x04000F7A RID: 3962
		public const int CONST_RT_821_MOD_VA320 = 1;

		// Token: 0x04000F7B RID: 3963
		public const int CONST_RT_821_MOD_MD201 = 2;

		// Token: 0x04000F7C RID: 3964
		public const int CONST_RT_850 = 3;

		// Token: 0x04000F7D RID: 3965
		public const int CONST_RT_850_MODO_NOVO = 0;

		// Token: 0x04000F7E RID: 3966
		public const int CONST_RT_850_MODO_ABRIR = 1;

		// Token: 0x04000F7F RID: 3967
		public const int CONST_RT_850_MODO_SALVAR = 2;

		// Token: 0x04000F80 RID: 3968
		public const int CONST_RT_850_LIBERAR = 3;

		// Token: 0x04000F81 RID: 3969
		public const int CONST_RT_850_MODO_BLOQUEIO = 4;

		// Token: 0x04000F82 RID: 3970
		public const int CONST_RT_850_DEFAULT_VERSAO = 0;

		// Token: 0x04000F83 RID: 3971
		public const int CONST_RT_850_DEFAULT_BUILD = 0;

		// Token: 0x04000F84 RID: 3972
		public const int CONST_RT_850_DEFAULT_RELEASE = 0;

		// Token: 0x04000F85 RID: 3973
		public const int CONST_RT_850_DEFAULT_EQUIP = 0;

		// Token: 0x04000F86 RID: 3974
		public const int CONST_RT_850_DEFAULT_END_MESTRE_CANAL_1 = 200;

		// Token: 0x04000F87 RID: 3975
		public const int CONST_RT_850_LMTE_INF_END_MESTRE_CANAL_1 = 1;

		// Token: 0x04000F88 RID: 3976
		public const int CONST_RT_850_LMTE_SUP_END_MESTRE_CANAL_1 = 200;

		// Token: 0x04000F89 RID: 3977
		public const int CONST_RT_850_DEFAULT_END_MESTRE_CANAL_2 = 180;

		// Token: 0x04000F8A RID: 3978
		public const int CONST_RT_850_LMTE_INF_END_MESTRE_CANAL_2 = 1;

		// Token: 0x04000F8B RID: 3979
		public const int CONST_RT_850_LMTE_SUP_END_MESTRE_CANAL_2 = 200;

		// Token: 0x04000F8C RID: 3980
		public const int CONST_RT_850_DEFAULT_INTERVALO_LEITURA_CANAL_1 = 3;

		// Token: 0x04000F8D RID: 3981
		public const int CONST_RT_850_LMTE_INF_INTERVALO_LEITURA_CANAL_1 = 1;

		// Token: 0x04000F8E RID: 3982
		public const int CONST_RT_850_LMTE_SUP_INTERVALO_LEITURA_CANAL_1 = 200;

		// Token: 0x04000F8F RID: 3983
		public const int CONST_RT_850_DEFAULT_INTERVALO_LEITURA_CANAL_2 = 3;

		// Token: 0x04000F90 RID: 3984
		public const int CONST_RT_850_LMTE_INF_INTERVALO_LEITURA_CANAL_2 = 1;

		// Token: 0x04000F91 RID: 3985
		public const int CONST_RT_850_LMTE_SUP_INTERVALO_LEITURA_CANAL_2 = 200;

		// Token: 0x04000F92 RID: 3986
		public const int CONST_RT_850_DEFAULT_BAUDRATE_INDICE_CANAL_1 = 0;

		// Token: 0x04000F93 RID: 3987
		public const int CONST_RT_850_DEFAULT_BAUDRATE_INDICE_CANAL_2 = 0;

		// Token: 0x04000F94 RID: 3988
		public const int CONST_RT_850_DEFAULT_TIMEOUT_CANAL_1 = 5;

		// Token: 0x04000F95 RID: 3989
		public const int CONST_RT_850_LMTE_INF_TIMEOUT_CANAL_1 = 1;

		// Token: 0x04000F96 RID: 3990
		public const int CONST_RT_850_LMTE_SUP_TIMEOUT_CANAL_1 = 200;

		// Token: 0x04000F97 RID: 3991
		public const int CONST_RT_850_DEFAULT_TIMEOUT_CANAL_2 = 5;

		// Token: 0x04000F98 RID: 3992
		public const int CONST_RT_850_LMTE_INF_TIMEOUT_CANAL_2 = 1;

		// Token: 0x04000F99 RID: 3993
		public const int CONST_RT_850_LMTE_SUP_TIMEOUT_CANAL_2 = 200;

		// Token: 0x04000F9A RID: 3994
		public const int CONST_RT_850_DEFAULT_TEMPO_PTT_CANAL_1 = 200;

		// Token: 0x04000F9B RID: 3995
		public const int CONST_RT_850_LMTE_INF_TEMPO_PTT_CANAL_1 = 10;

		// Token: 0x04000F9C RID: 3996
		public const int CONST_RT_850_LMTE_SUP_TEMPO_PTT_CANAL_1 = 2000;

		// Token: 0x04000F9D RID: 3997
		public const int CONST_RT_850_DEFAULT_TEMPO_PTT_CANAL_2 = 200;

		// Token: 0x04000F9E RID: 3998
		public const int CONST_RT_850_LMTE_INF_TEMPO_PTT_CANAL_2 = 10;

		// Token: 0x04000F9F RID: 3999
		public const int CONST_RT_850_LMTE_SUP_TEMPO_PTT_CANAL_2 = 2000;

		// Token: 0x04000FA0 RID: 4000
		public const int CONST_RT_850_DEFAULT_NUMERO_TENTATIVAS_CANAL_1 = 3;

		// Token: 0x04000FA1 RID: 4001
		public const int CONST_RT_850_LMTE_INF_NUMERO_TENTATIVAS_CANAL_1 = 0;

		// Token: 0x04000FA2 RID: 4002
		public const int CONST_RT_850_LMTE_SUP_NUMERO_TENTATIVAS_CANAL_1 = 20;

		// Token: 0x04000FA3 RID: 4003
		public const int CONST_RT_850_DEFAULT_NUMERO_TENTATIVAS_CANAL_2 = 3;

		// Token: 0x04000FA4 RID: 4004
		public const int CONST_RT_850_LMTE_INF_NUMERO_TENTATIVAS_CANAL_2 = 0;

		// Token: 0x04000FA5 RID: 4005
		public const int CONST_RT_850_LMTE_SUP_NUMERO_TENTATIVAS_CANAL_2 = 20;

		// Token: 0x04000FA6 RID: 4006
		public const int CONST_RT_850_DEFAULT_NUMERO_ERROS_FALHA_CANAL_1 = 3;

		// Token: 0x04000FA7 RID: 4007
		public const int CONST_RT_850_LMTE_INF_NUMERO_ERROS_FALHA_CANAL_1 = 1;

		// Token: 0x04000FA8 RID: 4008
		public const int CONST_RT_850_LMTE_SUP_NUMERO_ERROS_FALHA_CANAL_1 = 20;

		// Token: 0x04000FA9 RID: 4009
		public const int CONST_RT_850_DEFAULT_NUMERO_ERROS_FALHA_CANAL_2 = 3;

		// Token: 0x04000FAA RID: 4010
		public const int CONST_RT_850_LMTE_INF_NUMERO_ERROS_FALHA_CANAL_2 = 1;

		// Token: 0x04000FAB RID: 4011
		public const int CONST_RT_850_LMTE_SUP_NUMERO_ERROS_FALHA_CANAL_2 = 20;

		// Token: 0x04000FAC RID: 4012
		public const int CONST_RT_850_DEFAULT_CMD_ESTATISTICA = 100;

		// Token: 0x04000FAD RID: 4013
		public const int CONST_RT_850_LMTE_INF_CMD_ESTATISTICA = 10;

		// Token: 0x04000FAE RID: 4014
		public const int CONST_RT_850_LMTE_SUP_CMD_ESTATISTICA = 1000;

		// Token: 0x04000FAF RID: 4015
		public const int CONST_RT_850_DEFAULT_NUMERO_EQUIP_TIPO1_CANAL_1 = 0;

		// Token: 0x04000FB0 RID: 4016
		public const int CONST_RT_850_LMTE_INF_NUMERO_EQUIP_TIPO1_CANAL_1 = 0;

		// Token: 0x04000FB1 RID: 4017
		public const int CONST_RT_850_LMTE_SUP_NUMERO_EQUIP_TIPO1_CANAL_1 = 80;

		// Token: 0x04000FB2 RID: 4018
		public const int CONST_RT_850_DEFAULT_NUMERO_EQUIP_TIPO1_CANAL_2 = 0;

		// Token: 0x04000FB3 RID: 4019
		public const int CONST_RT_850_LMTE_INF_NUMERO_EQUIP_TIPO1_CANAL_2 = 0;

		// Token: 0x04000FB4 RID: 4020
		public const int CONST_RT_850_LMTE_SUP_NUMERO_EQUIP_TIPO1_CANAL_2 = 80;

		// Token: 0x04000FB5 RID: 4021
		public const int CONST_RT_850_DEFAULT_NUMERO_EQUIP_TIPO2_CANAL_1 = 0;

		// Token: 0x04000FB6 RID: 4022
		public const int CONST_RT_850_LMTE_INF_NUMERO_EQUIP_TIPO2_CANAL_1 = 0;

		// Token: 0x04000FB7 RID: 4023
		public const int CONST_RT_850_LMTE_SUP_NUMERO_EQUIP_TIPO2_CANAL_1 = 50;

		// Token: 0x04000FB8 RID: 4024
		public const int CONST_RT_850_DEFAULT_NUMERO_EQUIP_TIPO2_CANAL_2 = 0;

		// Token: 0x04000FB9 RID: 4025
		public const int CONST_RT_850_LMTE_INF_NUMERO_EQUIP_TIPO2_CANAL_2 = 0;

		// Token: 0x04000FBA RID: 4026
		public const int CONST_RT_850_LMTE_SUP_NUMERO_EQUIP_TIPO2_CANAL_2 = 50;

		// Token: 0x04000FBB RID: 4027
		public const int CONST_RT_850_DEFAULT_NUMERO_EQUIP_TIPO3_CANAL_1 = 0;

		// Token: 0x04000FBC RID: 4028
		public const int CONST_RT_850_LMTE_INF_NUMERO_EQUIP_TIPO3_CANAL_1 = 0;

		// Token: 0x04000FBD RID: 4029
		public const int CONST_RT_850_LMTE_SUP_NUMERO_EQUIP_TIPO3_CANAL_1 = 20;

		// Token: 0x04000FBE RID: 4030
		public const int CONST_RT_850_DEFAULT_NUMERO_EQUIP_TIPO3_CANAL_2 = 0;

		// Token: 0x04000FBF RID: 4031
		public const int CONST_RT_850_LMTE_INF_NUMERO_EQUIP_TIPO3_CANAL_2 = 0;

		// Token: 0x04000FC0 RID: 4032
		public const int CONST_RT_850_LMTE_SUP_NUMERO_EQUIP_TIPO3_CANAL_2 = 20;

		// Token: 0x04000FC1 RID: 4033
		public const int CONST_RT_850_DEFAULT_NUMERO_VISTA_CANAL_1 = 0;

		// Token: 0x04000FC2 RID: 4034
		public const int CONST_RT_850_LMTE_INF_NUMERO_VISTA_CANAL_1 = 0;

		// Token: 0x04000FC3 RID: 4035
		public const int CONST_RT_850_LMTE_SUP_NUMERO_VISTA_CANAL_1 = 5;

		// Token: 0x04000FC4 RID: 4036
		public const int CONST_RT_850_DEFAULT_NUMERO_VISTA_CANAL_2 = 0;

		// Token: 0x04000FC5 RID: 4037
		public const int CONST_RT_850_LMTE_INF_NUMERO_VISTA_CANAL_2 = 0;

		// Token: 0x04000FC6 RID: 4038
		public const int CONST_RT_850_LMTE_SUP_NUMERO_VISTA_CANAL_2 = 5;

		// Token: 0x04000FC7 RID: 4039
		public const int CONST_RT_850_DEFAULT_END_INI_EQUIP_TIPO1_CANAL_1 = 1;

		// Token: 0x04000FC8 RID: 4040
		public const int CONST_RT_850_LMTE_INF_END_INI_EQUIP_TIPO1_CANAL_1 = 1;

		// Token: 0x04000FC9 RID: 4041
		public const int CONST_RT_850_LMTE_SUP_END_INI_EQUIP_TIPO1_CANAL_1 = 200;

		// Token: 0x04000FCA RID: 4042
		public const int CONST_RT_850_DEFAULT_END_INI_EQUIP_TIPO1_CANAL_2 = 1;

		// Token: 0x04000FCB RID: 4043
		public const int CONST_RT_850_LMTE_INF_END_INI_EQUIP_TIPO1_CANAL_2 = 1;

		// Token: 0x04000FCC RID: 4044
		public const int CONST_RT_850_LMTE_SUP_END_INI_EQUIP_TIPO1_CANAL_2 = 200;

		// Token: 0x04000FCD RID: 4045
		public const int CONST_RT_850_DEFAULT_END_INI_EQUIP_TIPO2_CANAL_1 = 50;

		// Token: 0x04000FCE RID: 4046
		public const int CONST_RT_850_LMTE_INF_END_INI_EQUIP_TIPO2_CANAL_1 = 1;

		// Token: 0x04000FCF RID: 4047
		public const int CONST_RT_850_LMTE_SUP_END_INI_EQUIP_TIPO2_CANAL_1 = 200;

		// Token: 0x04000FD0 RID: 4048
		public const int CONST_RT_850_DEFAULT_END_INI_EQUIP_TIPO2_CANAL_2 = 50;

		// Token: 0x04000FD1 RID: 4049
		public const int CONST_RT_850_LMTE_INF_END_INI_EQUIP_TIPO2_CANAL_2 = 1;

		// Token: 0x04000FD2 RID: 4050
		public const int CONST_RT_850_LMTE_SUP_END_INI_EQUIP_TIPO2_CANAL_2 = 200;

		// Token: 0x04000FD3 RID: 4051
		public const int CONST_RT_850_DEFAULT_END_INI_EQUIP_TIPO3_CANAL_1 = 80;

		// Token: 0x04000FD4 RID: 4052
		public const int CONST_RT_850_LMTE_INF_END_INI_EQUIP_TIPO3_CANAL_1 = 1;

		// Token: 0x04000FD5 RID: 4053
		public const int CONST_RT_850_LMTE_SUP_END_INI_EQUIP_TIPO3_CANAL_1 = 200;

		// Token: 0x04000FD6 RID: 4054
		public const int CONST_RT_850_DEFAULT_END_INI_EQUIP_TIPO3_CANAL_2 = 80;

		// Token: 0x04000FD7 RID: 4055
		public const int CONST_RT_850_LMTE_INF_END_INI_EQUIP_TIPO3_CANAL_2 = 1;

		// Token: 0x04000FD8 RID: 4056
		public const int CONST_RT_850_LMTE_SUP_END_INI_EQUIP_TIPO3_CANAL_2 = 200;

		// Token: 0x04000FD9 RID: 4057
		public const int CONST_RT_850_DEFAULT_END_INI_EQUIP_VISTA_CANAL_1 = 100;

		// Token: 0x04000FDA RID: 4058
		public const int CONST_RT_850_LMTE_INF_END_INI_EQUIP_VISTA_CANAL_1 = 1;

		// Token: 0x04000FDB RID: 4059
		public const int CONST_RT_850_LMTE_SUP_END_INI_EQUIP_VISTA_CANAL_1 = 200;

		// Token: 0x04000FDC RID: 4060
		public const int CONST_RT_850_DEFAULT_END_INI_EQUIP_VISTA_CANAL_2 = 100;

		// Token: 0x04000FDD RID: 4061
		public const int CONST_RT_850_LMTE_INF_END_INI_EQUIP_VISTA_CANAL_2 = 1;

		// Token: 0x04000FDE RID: 4062
		public const int CONST_RT_850_LMTE_SUP_END_INI_EQUIP_VISTA_CANAL_2 = 200;

		// Token: 0x04000FDF RID: 4063
		public const int CONST_COLUNA_EQUIP_CANAL_QUANT_RT_850 = 0;

		// Token: 0x04000FE0 RID: 4064
		public const int CONST_COLUNA_EQUIP_CANAL_END_RT_850 = 1;

		// Token: 0x04000FE1 RID: 4065
		public const int CONST_RT_850_HAB_SINCRONISMO_DEFAULT = 21856;

		// Token: 0x04000FE2 RID: 4066
		public const int CONST_RT_850_HAB_SINCRONISMO = 21857;

		// Token: 0x04000FE3 RID: 4067
		public const int CONST_RT_850_DESABILITA_SINCRONISMO = 21856;

		// Token: 0x04000FE4 RID: 4068
		public const int CONST_RT_850_DEFAULT_TECLADO = 0;

		// Token: 0x04000FE5 RID: 4069
		public const int CONST_RT_850_HAB_TECLADO = 1;

		// Token: 0x04000FE6 RID: 4070
		public const int CONST_RT_850_DESABILITA_TECLADO = 0;

		// Token: 0x04000FE7 RID: 4071
		public const int CONST_RT_850_CONFERE_RESPOSTA_DEFAULT = 0;

		// Token: 0x04000FE8 RID: 4072
		public const int CONST_RT_850_HAB_CONFERE_RESPOSTA = 1;

		// Token: 0x04000FE9 RID: 4073
		public const int CONST_RT_850_DESABILITA_CONFERE_RESPOSTA = 0;

		// Token: 0x04000FEA RID: 4074
		public const int CONST_RT_850_MODO_ESTATISTICA_DEFAULT = 0;

		// Token: 0x04000FEB RID: 4075
		public const int CONST_RT_850_HAB_MODO_ESTATISTICA = 1;

		// Token: 0x04000FEC RID: 4076
		public const int CONST_RT_850_DESABILITA_MODO_ESTATISTICA = 0;

		// Token: 0x04000FED RID: 4077
		public const int CONST_RT_850_DEFAULT_FLAG_REMOTA_INDICE = 0;

		// Token: 0x04000FEE RID: 4078
		public const int CONST_RT_850_DEFAULT_FLAG_SUPERVISORIO_INDICE = 0;

		// Token: 0x04000FEF RID: 4079
		public const int CONST_RT_810_200 = 20;

		// Token: 0x04000FF0 RID: 4080
		public const int CONST_RT_820_200 = 30;

		// Token: 0x04000FF1 RID: 4081
		public const int CONST_RT_821_200 = 40;

		// Token: 0x04000FF2 RID: 4082
		public const int CONST_RT_830_200 = 50;

		// Token: 0x04000FF3 RID: 4083
		public const int CONST_RT_831_200 = 60;

		// Token: 0x04000FF4 RID: 4084
		public const int CONST_GC_82x_300 = 70;

		// Token: 0x04000FF5 RID: 4085
		public const int CONST_IEC_855_300 = 80;

		// Token: 0x04000FF6 RID: 4086
		public const int CONST_IER_856_300 = 90;

		// Token: 0x04000FF7 RID: 4087
		public const int CONST_RT_850_DEFAULT_VARIAVEL_NUMERO = 0;

		// Token: 0x04000FF8 RID: 4088
		public const int CONST_RT_850_LMTE_INF_VARIAVEL_NUMERO = 0;

		// Token: 0x04000FF9 RID: 4089
		public const int CONST_RT_850_LMTE_SUP_VARIAVEL_NUMERO = 300;

		// Token: 0x04000FFA RID: 4090
		public const int CONST_ALM_NIVEL_BAIXO = 0;

		// Token: 0x04000FFB RID: 4091
		public const int CONST_ALM_BAIXO_RT_850 = 0;

		// Token: 0x04000FFC RID: 4092
		public const int CONST_ALM_MSG_SEM = 0;

		// Token: 0x04000FFD RID: 4093
		public const int CONST_ALM_NIVEL_ALTO = 100;

		// Token: 0x04000FFE RID: 4094
		public const int CONST_ALM_ALTO_RT_850 = 1;

		// Token: 0x04000FFF RID: 4095
		public const int CONST_COLUNA_VARIAVEL_NOME_RT_850 = 0;

		// Token: 0x04001000 RID: 4096
		public const int CONST_COLUNA_VARIAVEL_ESC_INI_RT_850 = 1;

		// Token: 0x04001001 RID: 4097
		public const int CONST_COLUNA_VARIAVEL_ESC_FIM_RT_850 = 2;

		// Token: 0x04001002 RID: 4098
		public const int CONST_COLUNA_VARIACEL_ESC_TRAT_RT_850 = 3;

		// Token: 0x04001003 RID: 4099
		public const int CONST_COLUNA_VARIAVEL_ESC_FIM_PTO_RT_850 = 4;

		// Token: 0x04001004 RID: 4100
		public const int CONST_COLUNA_VARIAVEL_ALARME1_VALOR_RT_850 = 5;

		// Token: 0x04001005 RID: 4101
		public const int CONST_COLUNA_VARIAVEL_ALARME1_TIPO_RT_850 = 6;

		// Token: 0x04001006 RID: 4102
		public const int CONST_COLUNA_VARIAVEL_ALARME1_MSG_RT_850 = 7;

		// Token: 0x04001007 RID: 4103
		public const int CONST_COLUNA_VARIAVEL_ALARME2_VALOR_RT_850 = 8;

		// Token: 0x04001008 RID: 4104
		public const int CONST_COLUNA_VARIAVEL_ALARME2_TIPO_RT_850 = 9;

		// Token: 0x04001009 RID: 4105
		public const int CONST_COLUNA_VARIAVEL_ALARME2_MSG_RT_850 = 10;

		// Token: 0x0400100A RID: 4106
		public const int CONST_COLUNA_VARIAVEL_TELA_RT_850 = 11;

		// Token: 0x0400100B RID: 4107
		public const int CONST_COLUNA_VARIAVEL_POSICAO_DSP_RT_850 = 12;

		// Token: 0x0400100C RID: 4108
		public const int CONST_VARIAVEL_NIVEL_LMTE_INFERIOR = -999;

		// Token: 0x0400100D RID: 4109
		public const int CONST_VARIAVEL_NIVEL_LMTE_SUPERIOR = 20000;

		// Token: 0x0400100E RID: 4110
		public const int CONST_RT_850_LMTE_INF_VARIAVEL_TELA = 0;

		// Token: 0x0400100F RID: 4111
		public const int CONST_RT_850_LMTE_SUP_VARIAVEL_TELA = 75;

		// Token: 0x04001010 RID: 4112
		public const int CONST_RT_850_LMTE_INF_INDICE_CTRL = 0;

		// Token: 0x04001011 RID: 4113
		public const int CONST_RT_850_LMTE_SUP_INDICE_CTRL = 200;

		// Token: 0x04001012 RID: 4114
		public const int CONST_RT_850_DATAGRIDVIEW_VARIAVEIS_HEIGHT_INICIAL = 22;

		// Token: 0x04001013 RID: 4115
		public const int CONST_RT_850_DATAGRIDVIEW_VARIAVEIS_WIDTH_SEM_BARRA = 1130;

		// Token: 0x04001014 RID: 4116
		public const int CONST_RT_850_DATAGRIDVIEW_VARIAVEIS_WIDTH_COM_BARRA = 1147;

		// Token: 0x04001015 RID: 4117
		public const int CONST_COLUNA_CTRL_1_NOME_RT_850 = 0;

		// Token: 0x04001016 RID: 4118
		public const int CONST_COLUNA_CTRL_1_PORTA_RT_850 = 1;

		// Token: 0x04001017 RID: 4119
		public const int CONST_COLUNA_CTRL_1_TIMEOUT_RT_850 = 2;

		// Token: 0x04001018 RID: 4120
		public const int CONST_COLUNA_CTRL_1_HAB_COMANDO_RT_850 = 3;

		// Token: 0x04001019 RID: 4121
		public const int CONST_COLUNA_CTRL_1_PRIORIDADE_RT_850 = 4;

		// Token: 0x0400101A RID: 4122
		public const int CONST_COLUNA_CTRL_1_MODELO_RT_850 = 5;

		// Token: 0x0400101B RID: 4123
		public const int CONST_COLUNA_CTRL_1_NOME_CTRL_01_RT_850 = 6;

		// Token: 0x0400101C RID: 4124
		public const int CONST_COLUNA_CTRL_1_INDICE_CTRL_01_RT_850 = 7;

		// Token: 0x0400101D RID: 4125
		public const int CONST_COLUNA_CTRL_1_VAR_INDICE_1_RT_850 = 8;

		// Token: 0x0400101E RID: 4126
		public const int CONST_COLUNA_CTRL_1_VAR_INDICE_2_RT_850 = 9;

		// Token: 0x0400101F RID: 4127
		public const int CONST_COLUNA_CTRL_1_VAR_INDICE_3_RT_850 = 10;

		// Token: 0x04001020 RID: 4128
		public const int CONST_COLUNA_CTRL_1_VAR_INDICE_4_RT_850 = 11;

		// Token: 0x04001021 RID: 4129
		public const int CONST_COLUNA_CTRL_1_VAR_REF_1_RT_850 = 12;

		// Token: 0x04001022 RID: 4130
		public const int CONST_COLUNA_CTRL_1_VAR_REF_2_RT_850 = 13;

		// Token: 0x04001023 RID: 4131
		public const int CONST_COLUNA_CTRL_1_VAR_REF_3_RT_850 = 14;

		// Token: 0x04001024 RID: 4132
		public const int CONST_COLUNA_CTRL_1_VAR_REF_4_RT_850 = 15;

		// Token: 0x04001025 RID: 4133
		public const int CONST_RT_850_CTRL_1_NUMERO_CTRL = 1;

		// Token: 0x04001026 RID: 4134
		public const int CONST_RT_850_NUMERO_LINHAS_DATAGRIDVIEW_CTRL_1 = 15;

		// Token: 0x04001027 RID: 4135
		public const int CONST_RT_850_NUMERO_VAR_CTRL_1 = 4;

		// Token: 0x04001028 RID: 4136
		public const int CONST_RT_850_NUMERO_REF_CTRL_1 = 4;

		// Token: 0x04001029 RID: 4137
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_1_CANAL = 0;

		// Token: 0x0400102A RID: 4138
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_1_TIMEOUT = 0;

		// Token: 0x0400102B RID: 4139
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_1_COMANDO = 0;

		// Token: 0x0400102C RID: 4140
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_1_PRIORIDADE = 1;

		// Token: 0x0400102D RID: 4141
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_1_MODELO = 0;

		// Token: 0x0400102E RID: 4142
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_1_VARIAVEL = 0;

		// Token: 0x0400102F RID: 4143
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_1_REFERENCIA = 0;

		// Token: 0x04001030 RID: 4144
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_NOME = 0;

		// Token: 0x04001031 RID: 4145
		public const int CONST_RT_850_DEFAULT_CTRL_INDICE = 0;

		// Token: 0x04001032 RID: 4146
		public const int CONST_RT_850_LMTE_INF_CTRL_INDICE = 0;

		// Token: 0x04001033 RID: 4147
		public const int CONST_RT_850_LMTE_SUP_CTRL_INDICE = 200;

		// Token: 0x04001034 RID: 4148
		public const int CONST_COLUNA_CTRL_4_NOME_RT_850 = 0;

		// Token: 0x04001035 RID: 4149
		public const int CONST_COLUNA_CTRL_4_PORTA_RT_850 = 1;

		// Token: 0x04001036 RID: 4150
		public const int CONST_COLUNA_CTRL_4_TIMEOUT_RT_850 = 2;

		// Token: 0x04001037 RID: 4151
		public const int CONST_COLUNA_CTRL_4_HAB_COMANDO_RT_850 = 3;

		// Token: 0x04001038 RID: 4152
		public const int CONST_COLUNA_CTRL_4_PRIORIDADE_RT_850 = 4;

		// Token: 0x04001039 RID: 4153
		public const int CONST_COLUNA_CTRL_4_MODELO_RT_850 = 5;

		// Token: 0x0400103A RID: 4154
		public const int CONST_COLUNA_CTRL_4_NOME_CTRL_01_RT_850 = 6;

		// Token: 0x0400103B RID: 4155
		public const int CONST_COLUNA_CTRL_4_INDICE_CTRL_01_RT_850 = 7;

		// Token: 0x0400103C RID: 4156
		public const int CONST_COLUNA_CTRL_4_NOME_CTRL_02_RT_850 = 8;

		// Token: 0x0400103D RID: 4157
		public const int CONST_COLUNA_CTRL_4_INDICE_CTRL_02_RT_850 = 9;

		// Token: 0x0400103E RID: 4158
		public const int CONST_COLUNA_CTRL_4_NOME_CTRL_03_RT_850 = 10;

		// Token: 0x0400103F RID: 4159
		public const int CONST_COLUNA_CTRL_4_INDICE_CTRL_03_RT_850 = 11;

		// Token: 0x04001040 RID: 4160
		public const int CONST_COLUNA_CTRL_4_NOME_CTRL_04_RT_850 = 12;

		// Token: 0x04001041 RID: 4161
		public const int CONST_COLUNA_CTRL_4_INDICE_CTRL_04_RT_850 = 13;

		// Token: 0x04001042 RID: 4162
		public const int CONST_COLUNA_CTRL_4_VAR_INDICE_1_RT_850 = 14;

		// Token: 0x04001043 RID: 4163
		public const int CONST_COLUNA_CTRL_4_VAR_INDICE_2_RT_850 = 15;

		// Token: 0x04001044 RID: 4164
		public const int CONST_COLUNA_CTRL_4_VAR_INDICE_3_RT_850 = 16;

		// Token: 0x04001045 RID: 4165
		public const int CONST_COLUNA_CTRL_4_VAR_INDICE_4_RT_850 = 17;

		// Token: 0x04001046 RID: 4166
		public const int CONST_COLUNA_CTRL_4_VAR_REF_1_RT_850 = 18;

		// Token: 0x04001047 RID: 4167
		public const int CONST_COLUNA_CTRL_4_VAR_REF_2_RT_850 = 19;

		// Token: 0x04001048 RID: 4168
		public const int CONST_COLUNA_CTRL_4_VAR_REF_3_RT_850 = 20;

		// Token: 0x04001049 RID: 4169
		public const int CONST_COLUNA_CTRL_4_VAR_REF_4_RT_850 = 21;

		// Token: 0x0400104A RID: 4170
		public const int CONST_COLUNA_CTRL_4_PERIFERICO_MODELO_1_RT_850 = 22;

		// Token: 0x0400104B RID: 4171
		public const int CONST_COLUNA_CTRL_4_PERIFERICO_INDICE_1_RT_850 = 23;

		// Token: 0x0400104C RID: 4172
		public const int CONST_COLUNA_CTRL_4_PERIFERICO_MODELO_2_RT_850 = 24;

		// Token: 0x0400104D RID: 4173
		public const int CONST_COLUNA_CTRL_4_PERIFERICO_INDICE_2_RT_850 = 25;

		// Token: 0x0400104E RID: 4174
		public const int CONST_COLUNA_CTRL_4_PERIFERICO_MODELO_3_RT_850 = 26;

		// Token: 0x0400104F RID: 4175
		public const int CONST_COLUNA_CTRL_4_PERIFERICO_INDICE_3_RT_850 = 27;

		// Token: 0x04001050 RID: 4176
		public const int CONST_COLUNA_CTRL_4_PERIFERICO_MODELO_4_RT_850 = 28;

		// Token: 0x04001051 RID: 4177
		public const int CONST_COLUNA_CTRL_4_PERIFERICO_INDICE_4_RT_850 = 29;

		// Token: 0x04001052 RID: 4178
		public const int CONST_COLUNA_CTRL_4_PERIFERICO_MODELO_5_RT_850 = 30;

		// Token: 0x04001053 RID: 4179
		public const int CONST_COLUNA_CTRL_4_PERIFERICO_INDICE_5_RT_850 = 31;

		// Token: 0x04001054 RID: 4180
		public const int CONST_RT_850_CTRL_4_NUMERO_CTRL = 4;

		// Token: 0x04001055 RID: 4181
		public const int CONST_RT_850_NUMERO_LINHAS_DATAGRIDVIEW_CTRL_4 = 15;

		// Token: 0x04001056 RID: 4182
		public const int CONST_RT_850_NUMERO_VAR_CTRL_4 = 4;

		// Token: 0x04001057 RID: 4183
		public const int CONST_RT_850_NUMERO_REF_CTRL_4 = 4;

		// Token: 0x04001058 RID: 4184
		public const int CONST_RT_850_NUMERO_PERFERICO_CTRL_4 = 5;

		// Token: 0x04001059 RID: 4185
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_4_CANAL = 0;

		// Token: 0x0400105A RID: 4186
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_4_TIMEOUT = 0;

		// Token: 0x0400105B RID: 4187
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_4_COMANDO = 0;

		// Token: 0x0400105C RID: 4188
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_4_PRIORIDADE = 1;

		// Token: 0x0400105D RID: 4189
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_4_MODELO = 0;

		// Token: 0x0400105E RID: 4190
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_4_VARIAVEL = 0;

		// Token: 0x0400105F RID: 4191
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_4_REFERENCIA = 0;

		// Token: 0x04001060 RID: 4192
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_4_PERIFERICO_INDICE = 0;

		// Token: 0x04001061 RID: 4193
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_4_PERIFERICO_MODELO = 0;

		// Token: 0x04001062 RID: 4194
		public const int CONST_COLUNA_CTRL_8_NOME_RT_850 = 0;

		// Token: 0x04001063 RID: 4195
		public const int CONST_COLUNA_CTRL_8_PORTA_RT_850 = 1;

		// Token: 0x04001064 RID: 4196
		public const int CONST_COLUNA_CTRL_8_TIMEOUT_RT_850 = 2;

		// Token: 0x04001065 RID: 4197
		public const int CONST_COLUNA_CTRL_8_HAB_COMANDO_RT_850 = 3;

		// Token: 0x04001066 RID: 4198
		public const int CONST_COLUNA_CTRL_8_PRIORIDADE_RT_850 = 4;

		// Token: 0x04001067 RID: 4199
		public const int CONST_COLUNA_CTRL_8_MODELO_RT_850 = 5;

		// Token: 0x04001068 RID: 4200
		public const int CONST_COLUNA_CTRL_8_NOME_CTRL_01_RT_850 = 6;

		// Token: 0x04001069 RID: 4201
		public const int CONST_COLUNA_CTRL_8_INDICE_CTRL_01_RT_850 = 7;

		// Token: 0x0400106A RID: 4202
		public const int CONST_COLUNA_CTRL_8_NOME_CTRL_02_RT_850 = 8;

		// Token: 0x0400106B RID: 4203
		public const int CONST_COLUNA_CTRL_8_INDICE_CTRL_02_RT_850 = 9;

		// Token: 0x0400106C RID: 4204
		public const int CONST_COLUNA_CTRL_8_NOME_CTRL_03_RT_850 = 10;

		// Token: 0x0400106D RID: 4205
		public const int CONST_COLUNA_CTRL_8_INDICE_CTRL_03_RT_850 = 11;

		// Token: 0x0400106E RID: 4206
		public const int CONST_COLUNA_CTRL_8_NOME_CTRL_04_RT_850 = 12;

		// Token: 0x0400106F RID: 4207
		public const int CONST_COLUNA_CTRL_8_INDICE_CTRL_04_RT_850 = 13;

		// Token: 0x04001070 RID: 4208
		public const int CONST_COLUNA_CTRL_8_NOME_CTRL_05_RT_850 = 14;

		// Token: 0x04001071 RID: 4209
		public const int CONST_COLUNA_CTRL_8_INDICE_CTRL_05_RT_850 = 15;

		// Token: 0x04001072 RID: 4210
		public const int CONST_COLUNA_CTRL_8_NOME_CTRL_06_RT_850 = 16;

		// Token: 0x04001073 RID: 4211
		public const int CONST_COLUNA_CTRL_8_INDICE_CTRL_06_RT_850 = 17;

		// Token: 0x04001074 RID: 4212
		public const int CONST_COLUNA_CTRL_8_NOME_CTRL_07_RT_850 = 18;

		// Token: 0x04001075 RID: 4213
		public const int CONST_COLUNA_CTRL_8_INDICE_CTRL_07_RT_850 = 19;

		// Token: 0x04001076 RID: 4214
		public const int CONST_COLUNA_CTRL_8_NOME_CTRL_08_RT_850 = 20;

		// Token: 0x04001077 RID: 4215
		public const int CONST_COLUNA_CTRL_8_INDICE_CTRL_08_RT_850 = 21;

		// Token: 0x04001078 RID: 4216
		public const int CONST_COLUNA_CTRL_8_VAR_INDICE_1_RT_850 = 22;

		// Token: 0x04001079 RID: 4217
		public const int CONST_COLUNA_CTRL_8_VAR_INDICE_2_RT_850 = 23;

		// Token: 0x0400107A RID: 4218
		public const int CONST_COLUNA_CTRL_8_VAR_INDICE_3_RT_850 = 24;

		// Token: 0x0400107B RID: 4219
		public const int CONST_COLUNA_CTRL_8_VAR_INDICE_4_RT_850 = 25;

		// Token: 0x0400107C RID: 4220
		public const int CONST_COLUNA_CTRL_8_VAR_INDICE_5_RT_850 = 26;

		// Token: 0x0400107D RID: 4221
		public const int CONST_COLUNA_CTRL_8_VAR_INDICE_6_RT_850 = 27;

		// Token: 0x0400107E RID: 4222
		public const int CONST_COLUNA_CTRL_8_VAR_INDICE_7_RT_850 = 28;

		// Token: 0x0400107F RID: 4223
		public const int CONST_COLUNA_CTRL_8_VAR_INDICE_8_RT_850 = 29;

		// Token: 0x04001080 RID: 4224
		public const int CONST_COLUNA_CTRL_8_VAR_INDICE_9_RT_850 = 30;

		// Token: 0x04001081 RID: 4225
		public const int CONST_COLUNA_CTRL_8_VAR_INDICE_10_RT_850 = 31;

		// Token: 0x04001082 RID: 4226
		public const int CONST_COLUNA_CTRL_8_VAR_INDICE_11_RT_850 = 32;

		// Token: 0x04001083 RID: 4227
		public const int CONST_COLUNA_CTRL_8_VAR_INDICE_12_RT_850 = 33;

		// Token: 0x04001084 RID: 4228
		public const int CONST_COLUNA_CTRL_8_VAR_INDICE_13_RT_850 = 34;

		// Token: 0x04001085 RID: 4229
		public const int CONST_COLUNA_CTRL_8_VAR_INDICE_14_RT_850 = 35;

		// Token: 0x04001086 RID: 4230
		public const int CONST_COLUNA_CTRL_8_VAR_INDICE_15_RT_850 = 36;

		// Token: 0x04001087 RID: 4231
		public const int CONST_COLUNA_CTRL_8_VAR_INDICE_16_RT_850 = 37;

		// Token: 0x04001088 RID: 4232
		public const int CONST_COLUNA_CTRL_8_VAR_REF_1_RT_850 = 38;

		// Token: 0x04001089 RID: 4233
		public const int CONST_COLUNA_CTRL_8_VAR_REF_2_RT_850 = 39;

		// Token: 0x0400108A RID: 4234
		public const int CONST_COLUNA_CTRL_8_VAR_REF_3_RT_850 = 40;

		// Token: 0x0400108B RID: 4235
		public const int CONST_COLUNA_CTRL_8_VAR_REF_4_RT_850 = 41;

		// Token: 0x0400108C RID: 4236
		public const int CONST_COLUNA_CTRL_8_PERIFERICO_MODELO_1_RT_850 = 42;

		// Token: 0x0400108D RID: 4237
		public const int CONST_COLUNA_CTRL_8_PERIFERICO_INDICE_1_RT_850 = 43;

		// Token: 0x0400108E RID: 4238
		public const int CONST_COLUNA_CTRL_8_PERIFERICO_MODELO_2_RT_850 = 44;

		// Token: 0x0400108F RID: 4239
		public const int CONST_COLUNA_CTRL_8_PERIFERICO_INDICE_2_RT_850 = 45;

		// Token: 0x04001090 RID: 4240
		public const int CONST_COLUNA_CTRL_8_PERIFERICO_MODELO_3_RT_850 = 46;

		// Token: 0x04001091 RID: 4241
		public const int CONST_COLUNA_CTRL_8_PERIFERICO_INDICE_3_RT_850 = 47;

		// Token: 0x04001092 RID: 4242
		public const int CONST_COLUNA_CTRL_8_PERIFERICO_MODELO_4_RT_850 = 48;

		// Token: 0x04001093 RID: 4243
		public const int CONST_COLUNA_CTRL_8_PERIFERICO_INDICE_4_RT_850 = 49;

		// Token: 0x04001094 RID: 4244
		public const int CONST_COLUNA_CTRL_8_PERIFERICO_MODELO_5_RT_850 = 50;

		// Token: 0x04001095 RID: 4245
		public const int CONST_COLUNA_CTRL_8_PERIFERICO_INDICE_5_RT_850 = 51;

		// Token: 0x04001096 RID: 4246
		public const int CONST_RT_850_CTRL_8_NUMERO_CTRL = 8;

		// Token: 0x04001097 RID: 4247
		public const int CONST_RT_850_NUMERO_LINHAS_DATAGRIDVIEW_CTRL_8 = 15;

		// Token: 0x04001098 RID: 4248
		public const int CONST_RT_850_NUMERO_VAR_CTRL_8 = 16;

		// Token: 0x04001099 RID: 4249
		public const int CONST_RT_850_NUMERO_REF_CTRL_8 = 4;

		// Token: 0x0400109A RID: 4250
		public const int CONST_RT_850_NUMERO_PERFERICO_CTRL_8 = 5;

		// Token: 0x0400109B RID: 4251
		public const int CONST_RT_850_DEFAULT_PRIORIDADE = 1;

		// Token: 0x0400109C RID: 4252
		public const int CONST_RT_850_LMTE_INF_PRIORIDADE = 0;

		// Token: 0x0400109D RID: 4253
		public const int CONST_RT_850_LMTE_SUP_PRIORIDADE = 7;

		// Token: 0x0400109E RID: 4254
		public const int CONST_RT_850_NUMERO_LINHAS_DATAGRIDVIEW_VARIAVEIS = 15;

		// Token: 0x0400109F RID: 4255
		public const int CONST_RT_850_NUMERO_MAXIMO_VARIAVEIS = 300;

		// Token: 0x040010A0 RID: 4256
		public const int CONST_RT_850_NUMERO_MAXIMO_PERIFERICO = 65;

		// Token: 0x040010A1 RID: 4257
		public const int CONST_RT_850_NUMERO_MODELO_PERIFERICO = 29;

		// Token: 0x040010A2 RID: 4258
		public const int CONST_RT_850_NUMERO_MAXIMO_CTRL_NOMES = 3;

		// Token: 0x040010A3 RID: 4259
		public const int CONST_RT_850_NUMERO_MAXIMO_MODELOS = 60;

		// Token: 0x040010A4 RID: 4260
		public const int CONST_RT_850_NUMERO_MSG_ALARMES = 6;

		// Token: 0x040010A5 RID: 4261
		public const int CONST_RT_850_NUMERO_MSG_ALARMES_CONFIGURAVEIS = 20;

		// Token: 0x040010A6 RID: 4262
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_8_CANAL = 0;

		// Token: 0x040010A7 RID: 4263
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_8_TIMEOUT = 0;

		// Token: 0x040010A8 RID: 4264
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_8_COMANDO = 0;

		// Token: 0x040010A9 RID: 4265
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_8_PRIORIDADE = 1;

		// Token: 0x040010AA RID: 4266
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_8_MODELO = 0;

		// Token: 0x040010AB RID: 4267
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_8_VARIAVEL = 0;

		// Token: 0x040010AC RID: 4268
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_8_REFERENCIA = 0;

		// Token: 0x040010AD RID: 4269
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_8_PERIFERICO_INDICE = 0;

		// Token: 0x040010AE RID: 4270
		public const int CONST_RT_850_DEFAULT_INDICE_CTRL_8_PERIFERICO_MODELO = 0;

		// Token: 0x040010AF RID: 4271
		public const int CONST_RT_850_LMTE_INF_NUM_VARIAVEIS_VISTA = 0;

		// Token: 0x040010B0 RID: 4272
		public const int CONST_RT_850_LMTE_SUP_NUM_VARIAVEIS_VISTA = 40;

		// Token: 0x040010B1 RID: 4273
		public const int CONST_RT_850_DEFAULT_NUM_VARIAVEIS_VISTA = 0;

		// Token: 0x040010B2 RID: 4274
		public const int CONST_RT_850_LMTE_INF_NUM_EQUIPAMENTOS_VISTA = 0;

		// Token: 0x040010B3 RID: 4275
		public const int CONST_RT_850_LMTE_SUP_NUM_EQUIPAMENTOS_VISTA = 20;

		// Token: 0x040010B4 RID: 4276
		public const int CONST_RT_850_DEFAULT_NUM_EQUIPAMENTOS_VISTA = 0;

		// Token: 0x040010B5 RID: 4277
		public const int CONST_RT_850_DEFAULT_INDICE_VISTA_CANAL = 0;

		// Token: 0x040010B6 RID: 4278
		public const int CONST_RT_850_DEFAULT_INDICE_VISTA_TIMEOUT = 0;

		// Token: 0x040010B7 RID: 4279
		public const int CONST_RT_850_DEFAULT_INDICE_VISTA_COMANDO = 0;

		// Token: 0x040010B8 RID: 4280
		public const int CONST_RT_850_DEFAULT_PRIORIDADE_VISTA = 0;

		// Token: 0x040010B9 RID: 4281
		public const int CONST_RT_850_DEFAULT_INDICE_VARIAVEIS_VISTA = 0;

		// Token: 0x040010BA RID: 4282
		public const int CONST_RT_850_DEFAULT_INDICE_EQUIPAMENTOS_VISTA = 0;

		// Token: 0x040010BB RID: 4283
		public const int CONST_RT_850_DEFAULT_VISTA_SELECIONADO = 0;

		// Token: 0x040010BC RID: 4284
		public const int CONST_COLUNA_VARIAVEIS_VISTA_RT_850 = 0;

		// Token: 0x040010BD RID: 4285
		public const int CONST_RT_850_NUMERO_LINHAS_DATAGRIDVIEW_VARIAVEIS_VISTA = 14;

		// Token: 0x040010BE RID: 4286
		public const int CONST_RT_850_DATAGRIDVIEW_VARIAVEIS_VISTA_HEIGHT_INICIAL = 22;

		// Token: 0x040010BF RID: 4287
		public const int CONST_RT_850_DATAGRIDVIEW_VARIAVEIS_VISTA_WIDTH_SEM_BARRA = 212;

		// Token: 0x040010C0 RID: 4288
		public const int CONST_RT_850_DATAGRIDVIEW_VARIAVEIS_VISTA_WIDTH_COM_BARRA = 229;

		// Token: 0x040010C1 RID: 4289
		public const int CONST_RT_850_NUMERO_LINHAS_DATAGRIDVIEW_EQUIPAMENTOS_VISTA = 14;

		// Token: 0x040010C2 RID: 4290
		public const int CONST_RT_850_DATAGRIDVIEW_EQUIPAMENTOS_VISTA_HEIGHT_INICIAL = 22;

		// Token: 0x040010C3 RID: 4291
		public const int CONST_RT_850_DATAGRIDVIEW_EQUIPAMENTOS_VISTA_WIDTH_SEM_BARRA = 212;

		// Token: 0x040010C4 RID: 4292
		public const int CONST_RT_850_DATAGRIDVIEW_EQUIPAMENTOS_VISTA_WIDTH_COM_BARRA = 229;

		// Token: 0x040010C5 RID: 4293
		public const int CONST_COLUNA_EQUIPAMENTOS_VISTA_RT_850 = 0;

		// Token: 0x040010C6 RID: 4294
		public const int OFFSET_TIPO_EQUIPAMENTO_TIPO_1 = 0;

		// Token: 0x040010C7 RID: 4295
		public const int OFFSET_TIPO_EQUIPAMENTO_TIPO_4 = 80;

		// Token: 0x040010C8 RID: 4296
		public const int OFFSET_TIPO_EQUIPAMENTO_TIPO_8 = 130;

		// Token: 0x040010C9 RID: 4297
		public const int CONST_RT_850_MODELO_VISTA_DEFAULT_INDICE = 0;

		// Token: 0x040010CA RID: 4298
		public static string[] Nome_ctrl = new string[]
		{
			"Controle",
			"Motor",
			"Válvula"
		};

		// Token: 0x040010CB RID: 4299
		public const bool CONST_MOSTRA_ERRO = true;

		// Token: 0x040010CC RID: 4300
		public const bool CONST_NAO_MOSTRA_ERRO = false;

		// Token: 0x040010CD RID: 4301
		public const int CONST_RT_810_RELATORIO = 1;

		// Token: 0x040010CE RID: 4302
		public const int CONST_RT_820_RELATORIO = 2;

		// Token: 0x040010CF RID: 4303
		public const int CONST_RT_821_RELATORIO = 3;

		// Token: 0x040010D0 RID: 4304
		public const int CONST_RT_850_RELATORIO = 4;

		// Token: 0x040010D1 RID: 4305
		public static RT_geral.CTRL_TELA Telas_RT_810;

		// Token: 0x040010D2 RID: 4306
		public static RT_geral.CTRL_TELA Telas_RT_820;

		// Token: 0x040010D3 RID: 4307
		public static RT_geral.CTRL_TELA Telas_GC_82x;

		// Token: 0x040010D4 RID: 4308
		public static RT_geral.CTRL_TELA Telas_RT_820_360;

		// Token: 0x040010D5 RID: 4309
		public static RT_geral.CTRL_TELA Telas_RT_821;

		// Token: 0x040010D6 RID: 4310
		public static RT_geral.CTRL_TELA Telas_RT_850;

		// Token: 0x040010D7 RID: 4311
		public static RT_geral.CTRL_TELA Telas_RT_810_200;

		// Token: 0x040010D8 RID: 4312
		public static RT_geral.CTRL_TELA Telas_RT_820_200;

		// Token: 0x040010D9 RID: 4313
		public static RT_geral.CTRL_TELA Telas_RT_821_200;

		// Token: 0x040010DA RID: 4314
		public static RT_geral.CTRL_TELA Telas_RT_830_200;

		// Token: 0x040010DB RID: 4315
		public static RT_geral.CTRL_TELA Telas_RT_831_200;

		// Token: 0x040010DC RID: 4316
		public static RT_geral.DADOS_GC_82x_CONFIG GC_82x_BD;

		// Token: 0x040010DD RID: 4317
		public static RT_geral.DADOS_IEC_855_CONFIG IEC_855_BD;

		// Token: 0x040010DE RID: 4318
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_810_DataGrigViewProcessosColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[9];

		// Token: 0x040010DF RID: 4319
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_810_DataGrigViewEAColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[5];

		// Token: 0x040010E0 RID: 4320
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_810_DataGrigViewRepetidoraColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[11];

		// Token: 0x040010E1 RID: 4321
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_810_DataGrigViewSetpointsColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[7];

		// Token: 0x040010E2 RID: 4322
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_810_DataGrigViewEDColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[2];

		// Token: 0x040010E3 RID: 4323
		public static RT_geral.DADOS_RT_810_CONFIG RT_810_BD;

		// Token: 0x040010E4 RID: 4324
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_810_200_DataGrigViewEAColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[5];

		// Token: 0x040010E5 RID: 4325
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_810_200_DataGrigViewRepetidoraColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[11];

		// Token: 0x040010E6 RID: 4326
		public static RT_geral.DADOS_RT_810_200_CONFIG RT_810_200_BD;

		// Token: 0x040010E7 RID: 4327
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewProcessosColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[18];

		// Token: 0x040010E8 RID: 4328
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewGruposColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[5];

		// Token: 0x040010E9 RID: 4329
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewEAColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[5];

		// Token: 0x040010EA RID: 4330
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewPerifericosColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[4];

		// Token: 0x040010EB RID: 4331
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_360_DataGrigViewPerifericos1Colunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[4];

		// Token: 0x040010EC RID: 4332
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_360_DataGrigViewPerifericos2Colunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[4];

		// Token: 0x040010ED RID: 4333
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_360_DatagridViewPerifericoModbusGenericoColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[11];

		// Token: 0x040010EE RID: 4334
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewReferenciaPerifericosColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[7];

		// Token: 0x040010EF RID: 4335
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewAtuador1Colunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[14];

		// Token: 0x040010F0 RID: 4336
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewAtuador1SetPoint1Colunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[15];

		// Token: 0x040010F1 RID: 4337
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewAtuador1SetPoint2Colunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[13];

		// Token: 0x040010F2 RID: 4338
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewAtuador2Colunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[14];

		// Token: 0x040010F3 RID: 4339
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewAtuador2SetPoint1Colunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[15];

		// Token: 0x040010F4 RID: 4340
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewAtuador2SetPoint2Colunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[13];

		// Token: 0x040010F5 RID: 4341
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewAtuador3Colunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[14];

		// Token: 0x040010F6 RID: 4342
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewAtuador3SetPoint1Colunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[15];

		// Token: 0x040010F7 RID: 4343
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewAtuador3SetPoint2Colunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[13];

		// Token: 0x040010F8 RID: 4344
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewAtuador4Colunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[14];

		// Token: 0x040010F9 RID: 4345
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewAtuador4SetPoint1Colunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[15];

		// Token: 0x040010FA RID: 4346
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewAtuador4SetPoint2Colunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[13];

		// Token: 0x040010FB RID: 4347
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewRepetidoraColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[11];

		// Token: 0x040010FC RID: 4348
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewSetpointsColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[8];

		// Token: 0x040010FD RID: 4349
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewTimerColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[14];

		// Token: 0x040010FE RID: 4350
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewVazoesColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[2];

		// Token: 0x040010FF RID: 4351
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DatagridViewCalhasColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[8];

        // ── RT_821/380 — Novas abas de Vazão & Calhas + Periféricos ────────
        public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_821_380_DatagridViewVazoesColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[6];
        public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_821_380_DatagridViewPerifericosColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[5];
        public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_821_380_DataGridViewReferenciaPerifericosColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[3];

		// Token: 0x04001100 RID: 4352
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_DataGrigViewEDColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[2];

		// Token: 0x04001101 RID: 4353
		public static RT_geral.DADOS_RT_820_CONFIG RT_820_BD;

		// Token: 0x04001102 RID: 4354
		public static RT_geral.DADOS_RT_820_360_CONFIG RT_820_360_BD;

		// Token: 0x04001103 RID: 4355
		public static bool RT_820_300_flag_setpoint_horario;

		// Token: 0x04001104 RID: 4356
		public static bool RT_820_360_flag_setpoint_horario;

		// Token: 0x04001105 RID: 4357
		public static bool RT_820_350_flag_referenciaperiferico;

		// Token: 0x04001106 RID: 4358
		public static bool RT_820_360_flag_referenciaperiferico;

		// Token: 0x04001107 RID: 4359
		public static bool RT_820_350_flag_atuadoresperiferico;

		// Token: 0x04001108 RID: 4360
		public static bool RT_820_360_flag_atuadoresperiferico;

		// Token: 0x04001109 RID: 4361
		public static bool RT_820_360_flag_calha_vazao;

		// Token: 0x0400110A RID: 4362
		public static bool RT_820_360_flag_saida_analogicoAs;

		// Token: 0x0400110B RID: 4363
		public static bool RT_820_360_flag_rotativo_motor;

		// Token: 0x0400110C RID: 4364
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_200_DataGrigViewProcessosColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[18];

		// Token: 0x0400110D RID: 4365
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_200_DataGrigViewGruposColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[5];

		// Token: 0x0400110E RID: 4366
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_200_DataGrigViewEAColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[5];

		// Token: 0x0400110F RID: 4367
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_200_DataGrigViewPerifericosColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[4];

		// Token: 0x04001110 RID: 4368
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_200_DataGrigViewRepetidoraColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[11];

		// Token: 0x04001111 RID: 4369
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_200_DataGrigViewSetpointsColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[8];

		// Token: 0x04001112 RID: 4370
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_200_DataGrigViewTimerColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[14];

		// Token: 0x04001113 RID: 4371
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_200_DataGrigViewVazoesColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[2];

		// Token: 0x04001114 RID: 4372
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_820_200_DataGrigViewEDColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[2];

		// Token: 0x04001115 RID: 4373
		public static RT_geral.DADOS_RT_820_200_CONFIG RT_820_200_BD;

		// Token: 0x04001116 RID: 4374
		public static bool RT_820_200_flag_setpoint_horario;

		// Token: 0x04001117 RID: 4375
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_821_DataGrigViewProcessosColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[9];

		// Token: 0x04001118 RID: 4376
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_821_DataGrigMotoresSimultaneosColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[2];

		// Token: 0x04001119 RID: 4377
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_821_DataGrigViewEAColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[5];

		// Token: 0x0400111A RID: 4378
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_821_DataGrigViewRepetidoraColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[11];

		// Token: 0x0400111B RID: 4379
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_821_DataGrigViewSetpointsColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[7];

		// Token: 0x0400111C RID: 4380
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_821_DataGrigViewEDColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[2];

		// Token: 0x0400111D RID: 4381
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_821_DataGrigViewVisorColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[5];

		// Token: 0x0400111E RID: 4382
		public static RT_geral.DADOS_RT_821_CONFIG RT_821_BD;

		// Token: 0x0400111F RID: 4383
		public static RT_geral.DADOS_RT_821_200_CONFIG RT_821_200_BD;

		// Token: 0x04001120 RID: 4384
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_850_DataGrigViewEquipCanal_1Colunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[3];

		// Token: 0x04001121 RID: 4385
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_850_DataGrigViewEquipCanal_2Colunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[3];

		// Token: 0x04001122 RID: 4386
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_850_DataGridView_variaveis = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[15];

		// Token: 0x04001123 RID: 4387
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_850_DataGridView_ctrl_1 = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[16];

		// Token: 0x04001124 RID: 4388
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_850_DataGridView_ctrl_4 = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[32];

		// Token: 0x04001125 RID: 4389
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_850_DataGridView_ctrl_8 = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[53];

		// Token: 0x04001126 RID: 4390
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_850_DataGridView_Variaveis_Vista = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[2];

		// Token: 0x04001127 RID: 4391
		public static RT_geral.DADOS_DATAGRIDVIEW_RT_820[] RT_850_DataGridView_Equipamentos_Vista = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[2];

		// Token: 0x04001128 RID: 4392
		public static RT_geral.DADOS_RT_850_CONFIG RT_850_BD;

		// Token: 0x04001129 RID: 4393
		public static string[] RT_850_MSG_ALARME = new string[7];

		// Token: 0x0400112A RID: 4394
		public static string[] RT_850_MSG_ALARME_CONFIG = new string[21];

		// Token: 0x0400112B RID: 4395
		public static bool RT_850_flag_msg_alarme_config;

		// Token: 0x0400112C RID: 4396
		public static RT_geral.DADO_VARIAVEL[] Variaveis_RT_850 = new RT_geral.DADO_VARIAVEL[301];

		// Token: 0x0400112D RID: 4397
		public static RT_geral.Dados_Ctrl[] RT_850_Ctrl_1 = new RT_geral.Dados_Ctrl[81];

		// Token: 0x0400112E RID: 4398
		public static RT_geral.Dados_Ctrl_3[] RT_850_Ctrl_4 = new RT_geral.Dados_Ctrl_3[51];

		// Token: 0x0400112F RID: 4399
		public static RT_geral.Dados_Ctrl_3[] RT_850_Ctrl_8 = new RT_geral.Dados_Ctrl_3[21];

		// Token: 0x04001130 RID: 4400
		public static RT_geral.Dados_Ctrl_Vista[] RT_850_Vista = new RT_geral.Dados_Ctrl_Vista[6];

		// Token: 0x04001131 RID: 4401
		public static RT_geral.Dados_Controle RT_850_Controle;

		// Token: 0x04001132 RID: 4402
		public static RT_geral.Combo_ictel RT_850_Modelo;

		// Token: 0x04001133 RID: 4403
		public const int DNA_NAO_RECONHECIDO = 0;

		// Token: 0x04001134 RID: 4404
		public const int DNA_RT810_3_0 = 1;

		// Token: 0x04001135 RID: 4405
		public const int DNA_RT820_3_0 = 100;

		// Token: 0x04001136 RID: 4406
		public const int DNA_RT821_3_0 = 200;

		// Token: 0x04001137 RID: 4407
		public const int DNA_RT850_3_0 = 300;

		// Token: 0x04001138 RID: 4408
		public static int Equip_DNA = 0;

		// Token: 0x02000057 RID: 87
		public struct Ctrl_erro
		{
			// Token: 0x04001139 RID: 4409
			public bool resultado;

			// Token: 0x0400113A RID: 4410
			public string msg;

			// Token: 0x0400113B RID: 4411
			public Color color;
		}

		// Token: 0x02000058 RID: 88
		public struct Integer_ictel
		{
			// Token: 0x06001A61 RID: 6753 RVA: 0x00254530 File Offset: 0x00252930
			public void ValorPadrao()
			{
				this.Valor = this.Padrao;
			}

			// Token: 0x0400113C RID: 4412
			public string nome;

			// Token: 0x0400113D RID: 4413
			public int Valor;

			// Token: 0x0400113E RID: 4414
			public int Padrao;

			// Token: 0x0400113F RID: 4415
			public int Lmte_inf;

			// Token: 0x04001140 RID: 4416
			public int Lmte_sup;

			// Token: 0x04001141 RID: 4417
			public bool erro;
		}

		// Token: 0x02000059 RID: 89
		public struct String_ictel
		{
			// Token: 0x06001A62 RID: 6754 RVA: 0x00254540 File Offset: 0x00252940
			public void ValorPadrao()
			{
				this.Valor = this.Padrao;
			}

			// Token: 0x04001142 RID: 4418
			public string nome;

			// Token: 0x04001143 RID: 4419
			public string Valor;

			// Token: 0x04001144 RID: 4420
			public string Padrao;

			// Token: 0x04001145 RID: 4421
			public bool erro;
		}

		// Token: 0x0200005A RID: 90
		public struct Combo_ictel
		{
			// Token: 0x06001A63 RID: 6755 RVA: 0x00254550 File Offset: 0x00252950
			public void IndicePadrao()
			{
				this.Indice = this.Indice_padrao;
				this.Valor = this.valores[this.Indice];
			}

			// Token: 0x06001A64 RID: 6756 RVA: 0x00254574 File Offset: 0x00252974
			public void AtualizaValorPeloIndice()
			{
				this.Valor = this.valores[this.Indice];
			}

			// Token: 0x06001A65 RID: 6757 RVA: 0x0025458C File Offset: 0x0025298C
			public void AtualizaIndicePeloValor()
			{
				bool flag = false;
				int num = 0;
				checked
				{
					int num2 = this.Numero_itens - 1;
					for (int i = num; i <= num2; i++)
					{
						if (this.Valor == this.valores[i])
						{
							this.Indice = i;
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						this.IndicePadrao();
					}
				}
			}

			// Token: 0x06001A66 RID: 6758 RVA: 0x002545D4 File Offset: 0x002529D4
			public void AtualizaIndiceValorPeloItem(string item)
			{
				bool flag = false;
				int num = 0;
				checked
				{
					int num2 = this.Numero_itens - 1;
					for (int i = num; i <= num2; i++)
					{
						if (Operators.CompareString(item, this.itens[i], false) == 0)
						{
							flag = true;
							this.Indice = i;
							this.Valor = this.valores[this.Indice];
							break;
						}
					}
					if (!flag)
					{
						this.IndicePadrao();
					}
				}
			}

			// Token: 0x06001A67 RID: 6759 RVA: 0x00254634 File Offset: 0x00252A34
			public string GetItem()
			{
				return this.itens[this.Indice];
			}

			// Token: 0x04001146 RID: 4422
			public string nome;

			// Token: 0x04001147 RID: 4423
			public int Valor;

			// Token: 0x04001148 RID: 4424
			public int Indice;

			// Token: 0x04001149 RID: 4425
			public int Indice_padrao;

			// Token: 0x0400114A RID: 4426
			public int Numero_itens;

			// Token: 0x0400114B RID: 4427
			public string[] itens;

			// Token: 0x0400114C RID: 4428
			public int[] valores;

			// Token: 0x0400114D RID: 4429
			public bool erro;
		}

		// Token: 0x0200005B RID: 91
		public struct Combo_ictel_ctrl
		{
			// Token: 0x0400114E RID: 4430
			public string nome;

			// Token: 0x0400114F RID: 4431
			public int Valor;

			// Token: 0x04001150 RID: 4432
			public int Indice;

			// Token: 0x04001151 RID: 4433
			public int Indice_padrao;

			// Token: 0x04001152 RID: 4434
			public bool erro;
		}

		// Token: 0x0200005C RID: 92
		public struct CTRL_TELA
		{
			// Token: 0x04001153 RID: 4435
			public bool Configuracao;

			// Token: 0x04001154 RID: 4436
			public bool Monitoracao;

			// Token: 0x04001155 RID: 4437
			public bool Calibracao;
		}

		// Token: 0x0200005D RID: 93
		public struct DADOS_GC_82x_CONFIG
		{
			// Token: 0x04001156 RID: 4438
			public RT_geral.Integer_ictel Equip;

			// Token: 0x04001157 RID: 4439
			public RT_geral.Integer_ictel Versao;

			// Token: 0x04001158 RID: 4440
			public RT_geral.Integer_ictel Build;

			// Token: 0x04001159 RID: 4441
			public RT_geral.Integer_ictel Release;

			// Token: 0x0400115A RID: 4442
			public RT_geral.Integer_ictel End_estacao;

			// Token: 0x0400115B RID: 4443
			public RT_geral.Integer_ictel End_mestre;

			// Token: 0x0400115C RID: 4444
			public RT_geral.Integer_ictel modo_SD1;

			// Token: 0x0400115D RID: 4445
			public RT_geral.Integer_ictel modo_SD2;

			// Token: 0x0400115E RID: 4446
			public RT_geral.Integer_ictel modo_SD3;

			// Token: 0x0400115F RID: 4447
			public RT_geral.Integer_ictel liga_SD1;

			// Token: 0x04001160 RID: 4448
			public RT_geral.Integer_ictel liga_SD2;

			// Token: 0x04001161 RID: 4449
			public RT_geral.Integer_ictel liga_SD3;

			// Token: 0x04001162 RID: 4450
			public RT_geral.Integer_ictel desliga_SD1;

			// Token: 0x04001163 RID: 4451
			public RT_geral.Integer_ictel desliga_SD2;

			// Token: 0x04001164 RID: 4452
			public RT_geral.Integer_ictel desliga_SD3;

			// Token: 0x04001165 RID: 4453
			public RT_geral.Integer_ictel sentido_SD1;

			// Token: 0x04001166 RID: 4454
			public RT_geral.Integer_ictel sentido_SD2;

			// Token: 0x04001167 RID: 4455
			public RT_geral.Integer_ictel sentido_SD3;

			// Token: 0x04001168 RID: 4456
			public RT_geral.Integer_ictel modo_SA1;

			// Token: 0x04001169 RID: 4457
			public RT_geral.Integer_ictel modo_SA2;

			// Token: 0x0400116A RID: 4458
			public RT_geral.Integer_ictel limt_inferior1;

			// Token: 0x0400116B RID: 4459
			public RT_geral.Integer_ictel limt_inferior2;

			// Token: 0x0400116C RID: 4460
			public RT_geral.Integer_ictel limt_superior1;

			// Token: 0x0400116D RID: 4461
			public RT_geral.Integer_ictel limt_superior2;

			// Token: 0x0400116E RID: 4462
			public RT_geral.Integer_ictel AD_Intervalo;

			// Token: 0x0400116F RID: 4463
			public RT_geral.Integer_ictel AD_Tamanho_filtro;

			// Token: 0x04001170 RID: 4464
			public string filename;

			// Token: 0x04001171 RID: 4465
			public int calib_contagens;

			// Token: 0x04001172 RID: 4466
			public int calib_canal;

			// Token: 0x04001173 RID: 4467
			public int calib_funcao;

			// Token: 0x04001174 RID: 4468
			public string tipo_tipo_envio;

			// Token: 0x04001175 RID: 4469
			public int corrente_canal1;

			// Token: 0x04001176 RID: 4470
			public int corrente_canal2;
		}

		// Token: 0x0200005E RID: 94
		public struct DADOS_IEC_855_CONFIG
		{
			// Token: 0x04001177 RID: 4471
			public RT_geral.Integer_ictel Equip;

			// Token: 0x04001178 RID: 4472
			public RT_geral.Integer_ictel Versao;

			// Token: 0x04001179 RID: 4473
			public RT_geral.Integer_ictel Build;

			// Token: 0x0400117A RID: 4474
			public RT_geral.Integer_ictel Release;

			// Token: 0x0400117B RID: 4475
			public RT_geral.Combo_ictel BaudRateCOM1;

			// Token: 0x0400117C RID: 4476
			public RT_geral.Combo_ictel AtribuicaoIP;

			// Token: 0x0400117D RID: 4477
			public string[] tab_ips;

			// Token: 0x0400117E RID: 4478
			public byte[] MAC;

			// Token: 0x0400117F RID: 4479
			public string DHCP_IP;

			// Token: 0x04001180 RID: 4480
			public string DHCP_GW;

			// Token: 0x04001181 RID: 4481
			public string DHCP_SM;

			// Token: 0x04001182 RID: 4482
			public string STATIC_IP;

			// Token: 0x04001183 RID: 4483
			public string STATIC_GW;

			// Token: 0x04001184 RID: 4484
			public string STATIC_SM;

			// Token: 0x04001185 RID: 4485
			public RT_geral.Integer_ictel End_estacao;

			// Token: 0x04001186 RID: 4486
			public RT_geral.Integer_ictel End_mestre;

			// Token: 0x04001187 RID: 4487
			public RT_geral.Integer_ictel Tempo_ptt;

			// Token: 0x04001188 RID: 4488
			public RT_geral.Integer_ictel Intervalo_tx_pto_pto;

			// Token: 0x04001189 RID: 4489
			public RT_geral.Integer_ictel AD_Intervalo;

			// Token: 0x0400118A RID: 4490
			public RT_geral.Integer_ictel AD_Tamanho_filtro;

			// Token: 0x0400118B RID: 4491
			public RT_geral.Integer_ictel[] EA_Range;

			// Token: 0x0400118C RID: 4492
			public RT_geral.Integer_ictel[] EA_Inicio;

			// Token: 0x0400118D RID: 4493
			public RT_geral.Integer_ictel[] EA_Fim;

			// Token: 0x0400118E RID: 4494
			public RT_geral.Combo_ictel_ctrl[] ctrl_acionamento;

			// Token: 0x0400118F RID: 4495
			public RT_geral.Combo_ictel_ctrl[] ctrl_ret_acionamento;

			// Token: 0x04001190 RID: 4496
			public RT_geral.Combo_ictel_ctrl[] ctrl_ED_selecao;

			// Token: 0x04001191 RID: 4497
			public RT_geral.Combo_ictel_ctrl[] ctrl_reverso;

			// Token: 0x04001192 RID: 4498
			public RT_geral.Combo_ictel_ctrl[] ctrl_modo;

			// Token: 0x04001193 RID: 4499
			public RT_geral.Integer_ictel[] ctrl_tempo_max_partida;

			// Token: 0x04001194 RID: 4500
			public RT_geral.Integer_ictel[] ctrl_tempo_max_parada;

			// Token: 0x04001195 RID: 4501
			public RT_geral.Integer_ictel[] Setpoints_ctrl_nivel_alto;

			// Token: 0x04001196 RID: 4502
			public RT_geral.Integer_ictel[] Setpoints_ctrl_nivel_baixo;

			// Token: 0x04001197 RID: 4503
			public RT_geral.Combo_ictel_ctrl[] Setpoints_ctrl_variavel;

			// Token: 0x04001198 RID: 4504
			public string filename;
		}

		// Token: 0x0200005F RID: 95
		public struct DADOS_RT_810_CONFIG
		{
			// Token: 0x04001199 RID: 4505
			public RT_geral.Combo_ictel Modelo;

			// Token: 0x0400119A RID: 4506
			public RT_geral.Integer_ictel Equip;

			// Token: 0x0400119B RID: 4507
			public RT_geral.Integer_ictel Versao;

			// Token: 0x0400119C RID: 4508
			public RT_geral.Integer_ictel Build;

			// Token: 0x0400119D RID: 4509
			public RT_geral.Integer_ictel Release;

			// Token: 0x0400119E RID: 4510
			public RT_geral.Integer_ictel End_estacao;

			// Token: 0x0400119F RID: 4511
			public RT_geral.Integer_ictel End_mestre;

			// Token: 0x040011A0 RID: 4512
			public RT_geral.Integer_ictel Tempo_ptt;

			// Token: 0x040011A1 RID: 4513
			public RT_geral.Combo_ictel Modo_de_operacao;

			// Token: 0x040011A2 RID: 4514
			public RT_geral.Integer_ictel Intervalo_tx_pto_pto;

			// Token: 0x040011A3 RID: 4515
			public RT_geral.Integer_ictel AD_Intervalo;

			// Token: 0x040011A4 RID: 4516
			public RT_geral.Integer_ictel AD_Tamanho_filtro;

			// Token: 0x040011A5 RID: 4517
			public RT_geral.Integer_ictel[] EA_Range;

			// Token: 0x040011A6 RID: 4518
			public RT_geral.Integer_ictel[] EA_Inicio;

			// Token: 0x040011A7 RID: 4519
			public RT_geral.Integer_ictel[] EA_Fim;

			// Token: 0x040011A8 RID: 4520
			public RT_geral.Combo_ictel BaudRateCOM1;

			// Token: 0x040011A9 RID: 4521
			public RT_geral.Combo_ictel BaudRateCOM2;

			// Token: 0x040011AA RID: 4522
			public RT_geral.Combo_ictel_ctrl[] ctrl_acionamento;

			// Token: 0x040011AB RID: 4523
			public RT_geral.Combo_ictel_ctrl[] ctrl_ret_acionamento;

			// Token: 0x040011AC RID: 4524
			public RT_geral.Combo_ictel_ctrl[] ctrl_ED_selecao;

			// Token: 0x040011AD RID: 4525
			public RT_geral.Combo_ictel_ctrl[] ctrl_reverso;

			// Token: 0x040011AE RID: 4526
			public RT_geral.Combo_ictel_ctrl[] ctrl_modo;

			// Token: 0x040011AF RID: 4527
			public RT_geral.Integer_ictel[] ctrl_tempo_max_partida;

			// Token: 0x040011B0 RID: 4528
			public RT_geral.Integer_ictel[] ctrl_tempo_max_parada;

			// Token: 0x040011B1 RID: 4529
			public RT_geral.Combo_ictel_ctrl[] config_ED;

			// Token: 0x040011B2 RID: 4530
			public RT_geral.Integer_ictel Hab_eletrodos;

			// Token: 0x040011B3 RID: 4531
			public RT_geral.Combo_ictel Hab_repetidora;

			// Token: 0x040011B4 RID: 4532
			public RT_geral.Integer_ictel End_repetidora;

			// Token: 0x040011B5 RID: 4533
			public RT_geral.Integer_ictel Num_repetidoras;

			// Token: 0x040011B6 RID: 4534
			public RT_geral.Integer_ictel[] Repetidoras;

			// Token: 0x040011B7 RID: 4535
			public RT_geral.Integer_ictel[] Setpoints_ctrl_nivel_alto;

			// Token: 0x040011B8 RID: 4536
			public RT_geral.Integer_ictel[] Setpoints_ctrl_nivel_baixo;

			// Token: 0x040011B9 RID: 4537
			public RT_geral.Combo_ictel_ctrl[] Setpoints_ctrl_variavel;

			// Token: 0x040011BA RID: 4538
			public string filename;
		}

		// Token: 0x02000060 RID: 96
		public struct DADOS_RT_810_200_CONFIG
		{
			// Token: 0x040011BB RID: 4539
			public RT_geral.Integer_ictel Equip;

			// Token: 0x040011BC RID: 4540
			public RT_geral.Integer_ictel Versao;

			// Token: 0x040011BD RID: 4541
			public RT_geral.Integer_ictel Build;

			// Token: 0x040011BE RID: 4542
			public RT_geral.Integer_ictel Release;

			// Token: 0x040011BF RID: 4543
			public RT_geral.Integer_ictel End_estacao;

			// Token: 0x040011C0 RID: 4544
			public RT_geral.Integer_ictel End_mestre;

			// Token: 0x040011C1 RID: 4545
			public RT_geral.Integer_ictel Tempo_ptt;

			// Token: 0x040011C2 RID: 4546
			public RT_geral.Combo_ictel Modo_de_operacao;

			// Token: 0x040011C3 RID: 4547
			public RT_geral.Integer_ictel Intervalo_tx_pto_pto;

			// Token: 0x040011C4 RID: 4548
			public RT_geral.Combo_ictel Tipo_nivel;

			// Token: 0x040011C5 RID: 4549
			public RT_geral.Integer_ictel AD_Intervalo;

			// Token: 0x040011C6 RID: 4550
			public RT_geral.Integer_ictel AD_Tamanho_filtro;

			// Token: 0x040011C7 RID: 4551
			public RT_geral.Integer_ictel RangeSensor;

			// Token: 0x040011C8 RID: 4552
			public RT_geral.Integer_ictel AlturaReservatorio;

			// Token: 0x040011C9 RID: 4553
			public RT_geral.Integer_ictel ErroOffSet;

			// Token: 0x040011CA RID: 4554
			public RT_geral.Integer_ictel[] EA_Range;

			// Token: 0x040011CB RID: 4555
			public RT_geral.Integer_ictel[] EA_Inicio;

			// Token: 0x040011CC RID: 4556
			public RT_geral.Integer_ictel[] EA_Fim;

			// Token: 0x040011CD RID: 4557
			public RT_geral.Combo_ictel Hab_repetidora;

			// Token: 0x040011CE RID: 4558
			public RT_geral.Integer_ictel End_repetidora;

			// Token: 0x040011CF RID: 4559
			public RT_geral.Integer_ictel Num_repetidoras;

			// Token: 0x040011D0 RID: 4560
			public RT_geral.Integer_ictel[] Repetidoras;

			// Token: 0x040011D1 RID: 4561
			public string filename;
		}

		// Token: 0x02000061 RID: 97
		public struct DADOS_DATAGRIDVIEW_RT_820
		{
			// Token: 0x040011D2 RID: 4562
			public string NomeColuna;

			// Token: 0x040011D3 RID: 4563
			public string TagColuna;

			// Token: 0x040011D4 RID: 4564
			public DataGridViewContentAlignment AlingColuna;

			// Token: 0x040011D5 RID: 4565
			public int LarguraColuna;

			// Token: 0x040011D6 RID: 4566
			public int NumeroLinhaMenu;

			// Token: 0x040011D7 RID: 4567
			public string[] LinhasMenu;

			// Token: 0x040011D8 RID: 4568
			public int[] LinhasValor;
		}

		// Token: 0x02000062 RID: 98
		public struct SETPOINT_HORARIO_RT_820_300
		{
			// Token: 0x040011D9 RID: 4569
			public RT_geral.Integer_ictel Hora;

			// Token: 0x040011DA RID: 4570
			public RT_geral.Integer_ictel Minuto;

			// Token: 0x040011DB RID: 4571
			public RT_geral.Integer_ictel Alto;

			// Token: 0x040011DC RID: 4572
			public RT_geral.Integer_ictel Baixo;
		}

		// Token: 0x02000063 RID: 99
		public struct DADOS_RT_820_CONFIG
		{
			// Token: 0x040011DD RID: 4573
			public RT_geral.Integer_ictel Equip;

			// Token: 0x040011DE RID: 4574
			public RT_geral.Integer_ictel Versao;

			// Token: 0x040011DF RID: 4575
			public RT_geral.Integer_ictel Build;

			// Token: 0x040011E0 RID: 4576
			public RT_geral.Integer_ictel Release;

			// Token: 0x040011E1 RID: 4577
			public RT_geral.Integer_ictel End_estacao;

			// Token: 0x040011E2 RID: 4578
			public RT_geral.Integer_ictel End_mestre;

			// Token: 0x040011E3 RID: 4579
			public RT_geral.Integer_ictel TempoForaAr;

			// Token: 0x040011E4 RID: 4580
			public RT_geral.Combo_ictel modo_repetidora;

			// Token: 0x040011E5 RID: 4581
			public RT_geral.Integer_ictel Tempo_ptt;

			// Token: 0x040011E6 RID: 4582
			public RT_geral.Combo_ictel BaudRateCOM2;

			// Token: 0x040011E7 RID: 4583
			public RT_geral.Combo_ictel BaudRateCOM1;

			// Token: 0x040011E8 RID: 4584
			public RT_geral.Integer_ictel AD_Intervalo;

			// Token: 0x040011E9 RID: 4585
			public RT_geral.Integer_ictel AD_Tamanho_filtro;

			// Token: 0x040011EA RID: 4586
			public RT_geral.Integer_ictel HabExpIO;

			// Token: 0x040011EB RID: 4587
			public RT_geral.Integer_ictel[] EA_Range;

			// Token: 0x040011EC RID: 4588
			public RT_geral.Integer_ictel[] EA_Inicio;

			// Token: 0x040011ED RID: 4589
			public RT_geral.Integer_ictel[] EA_Fim;

			// Token: 0x040011EE RID: 4590
			public RT_geral.Combo_ictel_ctrl[] ctrl_acionamento;

			// Token: 0x040011EF RID: 4591
			public RT_geral.Combo_ictel_ctrl[] ctrl_desligamento;

			// Token: 0x040011F0 RID: 4592
			public RT_geral.Combo_ictel_ctrl[] ctrl_ret_acionamento;

			// Token: 0x040011F1 RID: 4593
			public RT_geral.Combo_ictel_ctrl[] ctrl_ret_desligamento;

			// Token: 0x040011F2 RID: 4594
			public RT_geral.Combo_ictel_ctrl[] ctrl_ED_selecao;

			// Token: 0x040011F3 RID: 4595
			public RT_geral.Combo_ictel_ctrl[] ctrl_ED_bloqueio;

			// Token: 0x040011F4 RID: 4596
			public RT_geral.Combo_ictel_ctrl[] ctrl_ED_liberacao;

			// Token: 0x040011F5 RID: 4597
			public RT_geral.Combo_ictel_ctrl[] ctrl_reverso;

			// Token: 0x040011F6 RID: 4598
			public RT_geral.Combo_ictel_ctrl[] ctrl_modo;

			// Token: 0x040011F7 RID: 4599
			public RT_geral.Combo_ictel_ctrl[] ctrl_agrupamento;

			// Token: 0x040011F8 RID: 4600
			public RT_geral.Combo_ictel_ctrl[] grupo_simultaneos;

			// Token: 0x040011F9 RID: 4601
			public RT_geral.Integer_ictel[] grupo_tempo_entre_acionamentos;

			// Token: 0x040011FA RID: 4602
			public RT_geral.Integer_ictel[] ctrl_tempo_max_partida;

			// Token: 0x040011FB RID: 4603
			public RT_geral.Integer_ictel[] ctrl_tempo_max_parada;

			// Token: 0x040011FC RID: 4604
			public RT_geral.Integer_ictel[] ctrl_tempo_min_parado;

			// Token: 0x040011FD RID: 4605
			public RT_geral.Integer_ictel[] ctrl_tempo_min_operando;

			// Token: 0x040011FE RID: 4606
			public RT_geral.Combo_ictel_ctrl[] config_ED;

			// Token: 0x040011FF RID: 4607
			public RT_geral.Combo_ictel_ctrl[] config_vazao;

			// Token: 0x04001200 RID: 4608
			public RT_geral.Combo_ictel_ctrl[] config_perifericos_mod;

			// Token: 0x04001201 RID: 4609
			public RT_geral.Integer_ictel[] config_perifericos_end;

			// Token: 0x04001202 RID: 4610
			public RT_geral.Combo_ictel_ctrl[] config_referencia_perif_periferico;

			// Token: 0x04001203 RID: 4611
			public RT_geral.Integer_ictel[] config_referencia_perif_memoria;

			// Token: 0x04001204 RID: 4612
			public RT_geral.Combo_ictel_ctrl[] config_referencia_perif_variavel1;

			// Token: 0x04001205 RID: 4613
			public RT_geral.Combo_ictel_ctrl[] config_referencia_perif_variavel2;

			// Token: 0x04001206 RID: 4614
			public RT_geral.Integer_ictel[] config_referencia_perif_escala;

			// Token: 0x04001207 RID: 4615
			public RT_geral.Combo_ictel_ctrl[] config_referencia_perif_formato;

			// Token: 0x04001208 RID: 4616
			public RT_geral.Combo_ictel_ctrl[] config_referencia_perif_base10;

			// Token: 0x04001209 RID: 4617
			public RT_geral.Combo_ictel_ctrl[] config_atuador1_perif;

			// Token: 0x0400120A RID: 4618
			public RT_geral.Integer_ictel[] config_atuador1_mem;

			// Token: 0x0400120B RID: 4619
			public RT_geral.Combo_ictel_ctrl[] config_atuador1_var1;

			// Token: 0x0400120C RID: 4620
			public RT_geral.Integer_ictel[] config_atuador1_escala1;

			// Token: 0x0400120D RID: 4621
			public RT_geral.Combo_ictel_ctrl[] config_atuador1_var2;

			// Token: 0x0400120E RID: 4622
			public RT_geral.Integer_ictel[] config_atuador1_escala2;

			// Token: 0x0400120F RID: 4623
			public RT_geral.Integer_ictel[] config_atuador1_histerese;

			// Token: 0x04001210 RID: 4624
			public RT_geral.Combo_ictel_ctrl[] config_atuador1_formato;

			// Token: 0x04001211 RID: 4625
			public RT_geral.Combo_ictel_ctrl[] config_atuador1_base10;

			// Token: 0x04001212 RID: 4626
			public RT_geral.Integer_ictel[] config_atuador1_v1baixo;

			// Token: 0x04001213 RID: 4627
			public RT_geral.Integer_ictel[] config_atuador1_v1alto;

			// Token: 0x04001214 RID: 4628
			public RT_geral.Integer_ictel[] config_atuador1_v2baixo;

			// Token: 0x04001215 RID: 4629
			public RT_geral.Integer_ictel[] config_atuador1_v2alto;

			// Token: 0x04001216 RID: 4630
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_hora;

			// Token: 0x04001217 RID: 4631
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_minuto;

			// Token: 0x04001218 RID: 4632
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_ref1;

			// Token: 0x04001219 RID: 4633
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_setp1;

			// Token: 0x0400121A RID: 4634
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_ref2;

			// Token: 0x0400121B RID: 4635
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_setp2;

			// Token: 0x0400121C RID: 4636
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_ref3;

			// Token: 0x0400121D RID: 4637
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_setp3;

			// Token: 0x0400121E RID: 4638
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_ref4;

			// Token: 0x0400121F RID: 4639
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_setp4;

			// Token: 0x04001220 RID: 4640
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_ref5;

			// Token: 0x04001221 RID: 4641
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_setp5;

			// Token: 0x04001222 RID: 4642
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_ref6;

			// Token: 0x04001223 RID: 4643
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_setp6;

			// Token: 0x04001224 RID: 4644
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_ref1;

			// Token: 0x04001225 RID: 4645
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_setp1;

			// Token: 0x04001226 RID: 4646
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_ref2;

			// Token: 0x04001227 RID: 4647
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_setp2;

			// Token: 0x04001228 RID: 4648
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_ref3;

			// Token: 0x04001229 RID: 4649
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_setp3;

			// Token: 0x0400122A RID: 4650
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_ref4;

			// Token: 0x0400122B RID: 4651
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_setp4;

			// Token: 0x0400122C RID: 4652
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_ref5;

			// Token: 0x0400122D RID: 4653
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_setp5;

			// Token: 0x0400122E RID: 4654
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_ref6;

			// Token: 0x0400122F RID: 4655
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_setp6;

			// Token: 0x04001230 RID: 4656
			public RT_geral.Combo_ictel_ctrl[] config_atuador2_perif;

			// Token: 0x04001231 RID: 4657
			public RT_geral.Integer_ictel[] config_atuador2_mem;

			// Token: 0x04001232 RID: 4658
			public RT_geral.Combo_ictel_ctrl[] config_atuador2_var1;

			// Token: 0x04001233 RID: 4659
			public RT_geral.Integer_ictel[] config_atuador2_escala1;

			// Token: 0x04001234 RID: 4660
			public RT_geral.Combo_ictel_ctrl[] config_atuador2_var2;

			// Token: 0x04001235 RID: 4661
			public RT_geral.Integer_ictel[] config_atuador2_escala2;

			// Token: 0x04001236 RID: 4662
			public RT_geral.Integer_ictel[] config_atuador2_histerese;

			// Token: 0x04001237 RID: 4663
			public RT_geral.Combo_ictel_ctrl[] config_atuador2_formato;

			// Token: 0x04001238 RID: 4664
			public RT_geral.Combo_ictel_ctrl[] config_atuador2_base10;

			// Token: 0x04001239 RID: 4665
			public RT_geral.Integer_ictel[] config_atuador2_v1baixo;

			// Token: 0x0400123A RID: 4666
			public RT_geral.Integer_ictel[] config_atuador2_v1alto;

			// Token: 0x0400123B RID: 4667
			public RT_geral.Integer_ictel[] config_atuador2_v2baixo;

			// Token: 0x0400123C RID: 4668
			public RT_geral.Integer_ictel[] config_atuador2_v2alto;

			// Token: 0x0400123D RID: 4669
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_hora;

			// Token: 0x0400123E RID: 4670
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_minuto;

			// Token: 0x0400123F RID: 4671
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_ref1;

			// Token: 0x04001240 RID: 4672
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_setp1;

			// Token: 0x04001241 RID: 4673
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_ref2;

			// Token: 0x04001242 RID: 4674
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_setp2;

			// Token: 0x04001243 RID: 4675
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_ref3;

			// Token: 0x04001244 RID: 4676
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_setp3;

			// Token: 0x04001245 RID: 4677
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_ref4;

			// Token: 0x04001246 RID: 4678
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_setp4;

			// Token: 0x04001247 RID: 4679
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_ref5;

			// Token: 0x04001248 RID: 4680
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_setp5;

			// Token: 0x04001249 RID: 4681
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_ref6;

			// Token: 0x0400124A RID: 4682
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_setp6;

			// Token: 0x0400124B RID: 4683
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_ref1;

			// Token: 0x0400124C RID: 4684
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_setp1;

			// Token: 0x0400124D RID: 4685
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_ref2;

			// Token: 0x0400124E RID: 4686
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_setp2;

			// Token: 0x0400124F RID: 4687
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_ref3;

			// Token: 0x04001250 RID: 4688
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_setp3;

			// Token: 0x04001251 RID: 4689
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_ref4;

			// Token: 0x04001252 RID: 4690
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_setp4;

			// Token: 0x04001253 RID: 4691
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_ref5;

			// Token: 0x04001254 RID: 4692
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_setp5;

			// Token: 0x04001255 RID: 4693
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_ref6;

			// Token: 0x04001256 RID: 4694
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_setp6;

			// Token: 0x04001257 RID: 4695
			public RT_geral.Combo_ictel_ctrl[] config_atuador3_perif;

			// Token: 0x04001258 RID: 4696
			public RT_geral.Integer_ictel[] config_atuador3_mem;

			// Token: 0x04001259 RID: 4697
			public RT_geral.Combo_ictel_ctrl[] config_atuador3_var1;

			// Token: 0x0400125A RID: 4698
			public RT_geral.Integer_ictel[] config_atuador3_escala1;

			// Token: 0x0400125B RID: 4699
			public RT_geral.Combo_ictel_ctrl[] config_atuador3_var2;

			// Token: 0x0400125C RID: 4700
			public RT_geral.Integer_ictel[] config_atuador3_escala2;

			// Token: 0x0400125D RID: 4701
			public RT_geral.Integer_ictel[] config_atuador3_histerese;

			// Token: 0x0400125E RID: 4702
			public RT_geral.Combo_ictel_ctrl[] config_atuador3_formato;

			// Token: 0x0400125F RID: 4703
			public RT_geral.Combo_ictel_ctrl[] config_atuador3_base10;

			// Token: 0x04001260 RID: 4704
			public RT_geral.Integer_ictel[] config_atuador3_v1baixo;

			// Token: 0x04001261 RID: 4705
			public RT_geral.Integer_ictel[] config_atuador3_v1alto;

			// Token: 0x04001262 RID: 4706
			public RT_geral.Integer_ictel[] config_atuador3_v2baixo;

			// Token: 0x04001263 RID: 4707
			public RT_geral.Integer_ictel[] config_atuador3_v2alto;

			// Token: 0x04001264 RID: 4708
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_hora;

			// Token: 0x04001265 RID: 4709
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_minuto;

			// Token: 0x04001266 RID: 4710
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_ref1;

			// Token: 0x04001267 RID: 4711
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_setp1;

			// Token: 0x04001268 RID: 4712
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_ref2;

			// Token: 0x04001269 RID: 4713
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_setp2;

			// Token: 0x0400126A RID: 4714
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_ref3;

			// Token: 0x0400126B RID: 4715
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_setp3;

			// Token: 0x0400126C RID: 4716
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_ref4;

			// Token: 0x0400126D RID: 4717
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_setp4;

			// Token: 0x0400126E RID: 4718
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_ref5;

			// Token: 0x0400126F RID: 4719
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_setp5;

			// Token: 0x04001270 RID: 4720
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_ref6;

			// Token: 0x04001271 RID: 4721
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_setp6;

			// Token: 0x04001272 RID: 4722
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_ref1;

			// Token: 0x04001273 RID: 4723
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_setp1;

			// Token: 0x04001274 RID: 4724
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_ref2;

			// Token: 0x04001275 RID: 4725
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_setp2;

			// Token: 0x04001276 RID: 4726
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_ref3;

			// Token: 0x04001277 RID: 4727
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_setp3;

			// Token: 0x04001278 RID: 4728
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_ref4;

			// Token: 0x04001279 RID: 4729
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_setp4;

			// Token: 0x0400127A RID: 4730
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_ref5;

			// Token: 0x0400127B RID: 4731
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_setp5;

			// Token: 0x0400127C RID: 4732
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_ref6;

			// Token: 0x0400127D RID: 4733
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_setp6;

			// Token: 0x0400127E RID: 4734
			public RT_geral.Combo_ictel_ctrl[] config_atuador4_perif;

			// Token: 0x0400127F RID: 4735
			public RT_geral.Integer_ictel[] config_atuador4_mem;

			// Token: 0x04001280 RID: 4736
			public RT_geral.Combo_ictel_ctrl[] config_atuador4_var1;

			// Token: 0x04001281 RID: 4737
			public RT_geral.Integer_ictel[] config_atuador4_escala1;

			// Token: 0x04001282 RID: 4738
			public RT_geral.Combo_ictel_ctrl[] config_atuador4_var2;

			// Token: 0x04001283 RID: 4739
			public RT_geral.Integer_ictel[] config_atuador4_escala2;

			// Token: 0x04001284 RID: 4740
			public RT_geral.Integer_ictel[] config_atuador4_histerese;

			// Token: 0x04001285 RID: 4741
			public RT_geral.Combo_ictel_ctrl[] config_atuador4_formato;

			// Token: 0x04001286 RID: 4742
			public RT_geral.Combo_ictel_ctrl[] config_atuador4_base10;

			// Token: 0x04001287 RID: 4743
			public RT_geral.Integer_ictel[] config_atuador4_v1baixo;

			// Token: 0x04001288 RID: 4744
			public RT_geral.Integer_ictel[] config_atuador4_v1alto;

			// Token: 0x04001289 RID: 4745
			public RT_geral.Integer_ictel[] config_atuador4_v2baixo;

			// Token: 0x0400128A RID: 4746
			public RT_geral.Integer_ictel[] config_atuador4_v2alto;

			// Token: 0x0400128B RID: 4747
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_hora;

			// Token: 0x0400128C RID: 4748
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_minuto;

			// Token: 0x0400128D RID: 4749
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_ref1;

			// Token: 0x0400128E RID: 4750
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_setp1;

			// Token: 0x0400128F RID: 4751
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_ref2;

			// Token: 0x04001290 RID: 4752
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_setp2;

			// Token: 0x04001291 RID: 4753
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_ref3;

			// Token: 0x04001292 RID: 4754
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_setp3;

			// Token: 0x04001293 RID: 4755
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_ref4;

			// Token: 0x04001294 RID: 4756
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_setp4;

			// Token: 0x04001295 RID: 4757
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_ref5;

			// Token: 0x04001296 RID: 4758
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_setp5;

			// Token: 0x04001297 RID: 4759
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_ref6;

			// Token: 0x04001298 RID: 4760
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_setp6;

			// Token: 0x04001299 RID: 4761
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_ref1;

			// Token: 0x0400129A RID: 4762
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_setp1;

			// Token: 0x0400129B RID: 4763
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_ref2;

			// Token: 0x0400129C RID: 4764
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_setp2;

			// Token: 0x0400129D RID: 4765
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_ref3;

			// Token: 0x0400129E RID: 4766
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_setp3;

			// Token: 0x0400129F RID: 4767
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_ref4;

			// Token: 0x040012A0 RID: 4768
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_setp4;

			// Token: 0x040012A1 RID: 4769
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_ref5;

			// Token: 0x040012A2 RID: 4770
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_setp5;

			// Token: 0x040012A3 RID: 4771
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_ref6;

			// Token: 0x040012A4 RID: 4772
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_setp6;

			// Token: 0x040012A5 RID: 4773
			public RT_geral.Integer_ictel End_repetidora;

			// Token: 0x040012A6 RID: 4774
			public RT_geral.Integer_ictel Num_repetidoras;

			// Token: 0x040012A7 RID: 4775
			public RT_geral.Integer_ictel[] Repetidoras;

			// Token: 0x040012A8 RID: 4776
			public RT_geral.Integer_ictel Setpoint_ctrl_tratamento_percentual;

			// Token: 0x040012A9 RID: 4777
			public RT_geral.Combo_ictel_ctrl[] Setpoints_ctrl_variavel;

			// Token: 0x040012AA RID: 4778
			public RT_geral.Combo_ictel_ctrl[] Setpoints_ctrl_bloqueio;

			// Token: 0x040012AB RID: 4779
			public RT_geral.Integer_ictel[] Setpoints_ctrl_nivel_alto;

			// Token: 0x040012AC RID: 4780
			public RT_geral.Integer_ictel[] Setpoints_ctrl_nivel_baixo;

			// Token: 0x040012AD RID: 4781
			public RT_geral.Integer_ictel[] Setpoints_ctrl_nivel_liberacao;

			// Token: 0x040012AE RID: 4782
			public RT_geral.Integer_ictel[] Setpoints_ctrl_nivel_bloqueio;

			// Token: 0x040012AF RID: 4783
			public RT_geral.Integer_ictel[][] Timer_Horario;

			// Token: 0x040012B0 RID: 4784
			public RT_geral.SETPOINT_HORARIO_RT_820_300[] setpoint_horario;

			// Token: 0x040012B1 RID: 4785
			public string filename;
		}

		// Token: 0x02000064 RID: 100
		public struct DADOS_RT_820_360_CONFIG
		{
			// Token: 0x040012B2 RID: 4786
			public RT_geral.Integer_ictel Equip;

			// Token: 0x040012B3 RID: 4787
			public RT_geral.Integer_ictel Versao;

			// Token: 0x040012B4 RID: 4788
			public RT_geral.Integer_ictel Build;

			// Token: 0x040012B5 RID: 4789
			public RT_geral.Integer_ictel Release;

			// Token: 0x040012B6 RID: 4790
			public RT_geral.Integer_ictel End_estacao1;

			// Token: 0x040012B7 RID: 4791
			public RT_geral.Integer_ictel End_estacao2;

			// Token: 0x040012B8 RID: 4792
			public RT_geral.Integer_ictel End_mestre;

			// Token: 0x040012B9 RID: 4793
			public RT_geral.Integer_ictel TempoForaAr;

			// Token: 0x040012BA RID: 4794
			public RT_geral.Combo_ictel modo_repetidora;

			// Token: 0x040012BB RID: 4795
			public RT_geral.Integer_ictel Tempo_ptt;

			// Token: 0x040012BC RID: 4796
			public RT_geral.Combo_ictel BaudRateCOM1;

			// Token: 0x040012BD RID: 4797
			public RT_geral.Combo_ictel BaudRateCOM2;

			// Token: 0x040012BE RID: 4798
			public RT_geral.Integer_ictel AD_Intervalo;

			// Token: 0x040012BF RID: 4799
			public RT_geral.Integer_ictel AD_Tamanho_filtro;

			// Token: 0x040012C0 RID: 4800
			public RT_geral.Integer_ictel HabExpIO;

			// Token: 0x040012C1 RID: 4801
			public RT_geral.Integer_ictel[] EA_Range;

			// Token: 0x040012C2 RID: 4802
			public RT_geral.Integer_ictel[] EA_Inicio;

			// Token: 0x040012C3 RID: 4803
			public RT_geral.Integer_ictel[] EA_Fim;

			// Token: 0x040012C4 RID: 4804
			public RT_geral.Combo_ictel_ctrl[] ctrl_acionamento;

			// Token: 0x040012C5 RID: 4805
			public RT_geral.Combo_ictel_ctrl[] ctrl_desligamento;

			// Token: 0x040012C6 RID: 4806
			public RT_geral.Combo_ictel_ctrl[] ctrl_ret_acionamento;

			// Token: 0x040012C7 RID: 4807
			public RT_geral.Combo_ictel_ctrl[] ctrl_ret_desligamento;

			// Token: 0x040012C8 RID: 4808
			public RT_geral.Combo_ictel_ctrl[] ctrl_ED_selecao;

			// Token: 0x040012C9 RID: 4809
			public RT_geral.Combo_ictel_ctrl[] ctrl_ED_bloqueio;

			// Token: 0x040012CA RID: 4810
			public RT_geral.Combo_ictel_ctrl[] ctrl_ED_liberacao;

			// Token: 0x040012CB RID: 4811
			public RT_geral.Combo_ictel_ctrl[] ctrl_reverso;

			// Token: 0x040012CC RID: 4812
			public RT_geral.Combo_ictel_ctrl[] ctrl_modo;

			// Token: 0x040012CD RID: 4813
			public RT_geral.Combo_ictel_ctrl[] ctrl_agrupamento;

			// Token: 0x040012CE RID: 4814
			public RT_geral.Combo_ictel_ctrl[] ctrl_partidas;

			// Token: 0x040012CF RID: 4815
			public RT_geral.Combo_ictel_ctrl[] grupo_simultaneos;

			// Token: 0x040012D0 RID: 4816
			public RT_geral.Integer_ictel[] grupo_tempo_entre_acionamentos;

			// Token: 0x040012D1 RID: 4817
			public RT_geral.Combo_ictel_ctrl[] grupo_rotativo_motores;

			// Token: 0x040012D2 RID: 4818
			public RT_geral.Integer_ictel[] ctrl_tempo_max_partida;

			// Token: 0x040012D3 RID: 4819
			public RT_geral.Integer_ictel[] ctrl_tempo_max_parada;

			// Token: 0x040012D4 RID: 4820
			public RT_geral.Integer_ictel[] ctrl_tempo_min_parado;

			// Token: 0x040012D5 RID: 4821
			public RT_geral.Integer_ictel[] ctrl_tempo_min_operando;

			// Token: 0x040012D6 RID: 4822
			public RT_geral.Combo_ictel_ctrl[] config_ED;

			// Token: 0x040012D7 RID: 4823
			public RT_geral.Combo_ictel[] saida_SA_origem;

			// Token: 0x040012D8 RID: 4824
			public RT_geral.Integer_ictel[] saida_SA_contagem_4mA;

			// Token: 0x040012D9 RID: 4825
			public RT_geral.Integer_ictel[] saida_SA_contagem_20mA;

			// Token: 0x040012DA RID: 4826
			public RT_geral.Combo_ictel_ctrl[] config_vazao;

			// Token: 0x040012DB RID: 4827
			public RT_geral.Combo_ictel_ctrl[] config_perifericos1_mod;

			// Token: 0x040012DC RID: 4828
			public RT_geral.Integer_ictel[] config_perifericos1_end;

			// Token: 0x040012DD RID: 4829
			public RT_geral.Combo_ictel_ctrl[] config_perifericos2_mod;

			// Token: 0x040012DE RID: 4830
			public RT_geral.Integer_ictel[] config_perifericos2_end;

			// Token: 0x040012DF RID: 4831
			public RT_geral.Combo_ictel_ctrl[] calha_EA;

			// Token: 0x040012E0 RID: 4832
			public RT_geral.Combo_ictel_ctrl[] calha_modelo;

			// Token: 0x040012E1 RID: 4833
			public RT_geral.Integer_ictel[] calha_fundo;

			// Token: 0x040012E2 RID: 4834
			public RT_geral.Integer_ictel[] calha_p1;

			// Token: 0x040012E3 RID: 4835
			public RT_geral.Integer_ictel[] calha_p2;

			// Token: 0x040012E4 RID: 4836
			public RT_geral.Integer_ictel[] calha_p3;

			// Token: 0x040012E5 RID: 4837
			public RT_geral.Integer_ictel[] config_periferico_modbus_generico_endcom;

			// Token: 0x040012E6 RID: 4838
			public RT_geral.Combo_ictel_ctrl[] config_periferico_modbus_generico_funcao;

			// Token: 0x040012E7 RID: 4839
			public RT_geral.Integer_ictel[] config_periferico_modbus_generico_mem1;

			// Token: 0x040012E8 RID: 4840
			public RT_geral.Integer_ictel[] config_periferico_modbus_generico_var1;

			// Token: 0x040012E9 RID: 4841
			public RT_geral.Integer_ictel[] config_periferico_modbus_generico_mem2;

			// Token: 0x040012EA RID: 4842
			public RT_geral.Integer_ictel[] config_periferico_modbus_generico_var2;

			// Token: 0x040012EB RID: 4843
			public RT_geral.Integer_ictel[] config_periferico_modbus_generico_mem3;

			// Token: 0x040012EC RID: 4844
			public RT_geral.Integer_ictel[] config_periferico_modbus_generico_var3;

			// Token: 0x040012ED RID: 4845
			public RT_geral.Integer_ictel[] config_periferico_modbus_generico_mem4;

			// Token: 0x040012EE RID: 4846
			public RT_geral.Integer_ictel[] config_periferico_modbus_generico_var4;

			// Token: 0x040012EF RID: 4847
			public RT_geral.Combo_ictel_ctrl[] config_referencia_perif_periferico;

			// Token: 0x040012F0 RID: 4848
			public RT_geral.Integer_ictel[] config_referencia_perif_memoria;

			// Token: 0x040012F1 RID: 4849
			public RT_geral.Combo_ictel_ctrl[] config_referencia_perif_variavel1;

			// Token: 0x040012F2 RID: 4850
			public RT_geral.Combo_ictel_ctrl[] config_referencia_perif_variavel2;

			// Token: 0x040012F3 RID: 4851
			public RT_geral.Integer_ictel[] config_referencia_perif_escala;

			// Token: 0x040012F4 RID: 4852
			public RT_geral.Combo_ictel_ctrl[] config_referencia_perif_formato;

			// Token: 0x040012F5 RID: 4853
			public RT_geral.Combo_ictel_ctrl[] config_referencia_perif_base10;

			// Token: 0x040012F6 RID: 4854
			public RT_geral.Combo_ictel_ctrl[] config_atuador1_perif;

			// Token: 0x040012F7 RID: 4855
			public RT_geral.Integer_ictel[] config_atuador1_mem;

			// Token: 0x040012F8 RID: 4856
			public RT_geral.Combo_ictel_ctrl[] config_atuador1_var1;

			// Token: 0x040012F9 RID: 4857
			public RT_geral.Integer_ictel[] config_atuador1_escala1;

			// Token: 0x040012FA RID: 4858
			public RT_geral.Combo_ictel_ctrl[] config_atuador1_var2;

			// Token: 0x040012FB RID: 4859
			public RT_geral.Integer_ictel[] config_atuador1_escala2;

			// Token: 0x040012FC RID: 4860
			public RT_geral.Integer_ictel[] config_atuador1_histerese;

			// Token: 0x040012FD RID: 4861
			public RT_geral.Combo_ictel_ctrl[] config_atuador1_formato;

			// Token: 0x040012FE RID: 4862
			public RT_geral.Combo_ictel_ctrl[] config_atuador1_base10;

			// Token: 0x040012FF RID: 4863
			public RT_geral.Integer_ictel[] config_atuador1_v1baixo;

			// Token: 0x04001300 RID: 4864
			public RT_geral.Integer_ictel[] config_atuador1_v1alto;

			// Token: 0x04001301 RID: 4865
			public RT_geral.Integer_ictel[] config_atuador1_v2baixo;

			// Token: 0x04001302 RID: 4866
			public RT_geral.Integer_ictel[] config_atuador1_v2alto;

			// Token: 0x04001303 RID: 4867
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_hora;

			// Token: 0x04001304 RID: 4868
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_minuto;

			// Token: 0x04001305 RID: 4869
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_ref1;

			// Token: 0x04001306 RID: 4870
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_setp1;

			// Token: 0x04001307 RID: 4871
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_ref2;

			// Token: 0x04001308 RID: 4872
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_setp2;

			// Token: 0x04001309 RID: 4873
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_ref3;

			// Token: 0x0400130A RID: 4874
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_setp3;

			// Token: 0x0400130B RID: 4875
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_ref4;

			// Token: 0x0400130C RID: 4876
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_setp4;

			// Token: 0x0400130D RID: 4877
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_ref5;

			// Token: 0x0400130E RID: 4878
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_setp5;

			// Token: 0x0400130F RID: 4879
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_ref6;

			// Token: 0x04001310 RID: 4880
			public RT_geral.Integer_ictel[] config_atuador1_setpoint1_setp6;

			// Token: 0x04001311 RID: 4881
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_ref1;

			// Token: 0x04001312 RID: 4882
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_setp1;

			// Token: 0x04001313 RID: 4883
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_ref2;

			// Token: 0x04001314 RID: 4884
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_setp2;

			// Token: 0x04001315 RID: 4885
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_ref3;

			// Token: 0x04001316 RID: 4886
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_setp3;

			// Token: 0x04001317 RID: 4887
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_ref4;

			// Token: 0x04001318 RID: 4888
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_setp4;

			// Token: 0x04001319 RID: 4889
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_ref5;

			// Token: 0x0400131A RID: 4890
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_setp5;

			// Token: 0x0400131B RID: 4891
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_ref6;

			// Token: 0x0400131C RID: 4892
			public RT_geral.Integer_ictel[] config_atuador1_setpoint2_setp6;

			// Token: 0x0400131D RID: 4893
			public RT_geral.Combo_ictel_ctrl[] config_atuador2_perif;

			// Token: 0x0400131E RID: 4894
			public RT_geral.Integer_ictel[] config_atuador2_mem;

			// Token: 0x0400131F RID: 4895
			public RT_geral.Combo_ictel_ctrl[] config_atuador2_var1;

			// Token: 0x04001320 RID: 4896
			public RT_geral.Integer_ictel[] config_atuador2_escala1;

			// Token: 0x04001321 RID: 4897
			public RT_geral.Combo_ictel_ctrl[] config_atuador2_var2;

			// Token: 0x04001322 RID: 4898
			public RT_geral.Integer_ictel[] config_atuador2_escala2;

			// Token: 0x04001323 RID: 4899
			public RT_geral.Integer_ictel[] config_atuador2_histerese;

			// Token: 0x04001324 RID: 4900
			public RT_geral.Combo_ictel_ctrl[] config_atuador2_formato;

			// Token: 0x04001325 RID: 4901
			public RT_geral.Combo_ictel_ctrl[] config_atuador2_base10;

			// Token: 0x04001326 RID: 4902
			public RT_geral.Integer_ictel[] config_atuador2_v1baixo;

			// Token: 0x04001327 RID: 4903
			public RT_geral.Integer_ictel[] config_atuador2_v1alto;

			// Token: 0x04001328 RID: 4904
			public RT_geral.Integer_ictel[] config_atuador2_v2baixo;

			// Token: 0x04001329 RID: 4905
			public RT_geral.Integer_ictel[] config_atuador2_v2alto;

			// Token: 0x0400132A RID: 4906
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_hora;

			// Token: 0x0400132B RID: 4907
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_minuto;

			// Token: 0x0400132C RID: 4908
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_ref1;

			// Token: 0x0400132D RID: 4909
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_setp1;

			// Token: 0x0400132E RID: 4910
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_ref2;

			// Token: 0x0400132F RID: 4911
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_setp2;

			// Token: 0x04001330 RID: 4912
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_ref3;

			// Token: 0x04001331 RID: 4913
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_setp3;

			// Token: 0x04001332 RID: 4914
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_ref4;

			// Token: 0x04001333 RID: 4915
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_setp4;

			// Token: 0x04001334 RID: 4916
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_ref5;

			// Token: 0x04001335 RID: 4917
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_setp5;

			// Token: 0x04001336 RID: 4918
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_ref6;

			// Token: 0x04001337 RID: 4919
			public RT_geral.Integer_ictel[] config_atuador2_setpoint1_setp6;

			// Token: 0x04001338 RID: 4920
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_ref1;

			// Token: 0x04001339 RID: 4921
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_setp1;

			// Token: 0x0400133A RID: 4922
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_ref2;

			// Token: 0x0400133B RID: 4923
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_setp2;

			// Token: 0x0400133C RID: 4924
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_ref3;

			// Token: 0x0400133D RID: 4925
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_setp3;

			// Token: 0x0400133E RID: 4926
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_ref4;

			// Token: 0x0400133F RID: 4927
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_setp4;

			// Token: 0x04001340 RID: 4928
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_ref5;

			// Token: 0x04001341 RID: 4929
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_setp5;

			// Token: 0x04001342 RID: 4930
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_ref6;

			// Token: 0x04001343 RID: 4931
			public RT_geral.Integer_ictel[] config_atuador2_setpoint2_setp6;

			// Token: 0x04001344 RID: 4932
			public RT_geral.Combo_ictel_ctrl[] config_atuador3_perif;

			// Token: 0x04001345 RID: 4933
			public RT_geral.Integer_ictel[] config_atuador3_mem;

			// Token: 0x04001346 RID: 4934
			public RT_geral.Combo_ictel_ctrl[] config_atuador3_var1;

			// Token: 0x04001347 RID: 4935
			public RT_geral.Integer_ictel[] config_atuador3_escala1;

			// Token: 0x04001348 RID: 4936
			public RT_geral.Combo_ictel_ctrl[] config_atuador3_var2;

			// Token: 0x04001349 RID: 4937
			public RT_geral.Integer_ictel[] config_atuador3_escala2;

			// Token: 0x0400134A RID: 4938
			public RT_geral.Integer_ictel[] config_atuador3_histerese;

			// Token: 0x0400134B RID: 4939
			public RT_geral.Combo_ictel_ctrl[] config_atuador3_formato;

			// Token: 0x0400134C RID: 4940
			public RT_geral.Combo_ictel_ctrl[] config_atuador3_base10;

			// Token: 0x0400134D RID: 4941
			public RT_geral.Integer_ictel[] config_atuador3_v1baixo;

			// Token: 0x0400134E RID: 4942
			public RT_geral.Integer_ictel[] config_atuador3_v1alto;

			// Token: 0x0400134F RID: 4943
			public RT_geral.Integer_ictel[] config_atuador3_v2baixo;

			// Token: 0x04001350 RID: 4944
			public RT_geral.Integer_ictel[] config_atuador3_v2alto;

			// Token: 0x04001351 RID: 4945
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_hora;

			// Token: 0x04001352 RID: 4946
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_minuto;

			// Token: 0x04001353 RID: 4947
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_ref1;

			// Token: 0x04001354 RID: 4948
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_setp1;

			// Token: 0x04001355 RID: 4949
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_ref2;

			// Token: 0x04001356 RID: 4950
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_setp2;

			// Token: 0x04001357 RID: 4951
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_ref3;

			// Token: 0x04001358 RID: 4952
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_setp3;

			// Token: 0x04001359 RID: 4953
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_ref4;

			// Token: 0x0400135A RID: 4954
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_setp4;

			// Token: 0x0400135B RID: 4955
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_ref5;

			// Token: 0x0400135C RID: 4956
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_setp5;

			// Token: 0x0400135D RID: 4957
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_ref6;

			// Token: 0x0400135E RID: 4958
			public RT_geral.Integer_ictel[] config_atuador3_setpoint1_setp6;

			// Token: 0x0400135F RID: 4959
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_ref1;

			// Token: 0x04001360 RID: 4960
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_setp1;

			// Token: 0x04001361 RID: 4961
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_ref2;

			// Token: 0x04001362 RID: 4962
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_setp2;

			// Token: 0x04001363 RID: 4963
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_ref3;

			// Token: 0x04001364 RID: 4964
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_setp3;

			// Token: 0x04001365 RID: 4965
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_ref4;

			// Token: 0x04001366 RID: 4966
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_setp4;

			// Token: 0x04001367 RID: 4967
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_ref5;

			// Token: 0x04001368 RID: 4968
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_setp5;

			// Token: 0x04001369 RID: 4969
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_ref6;

			// Token: 0x0400136A RID: 4970
			public RT_geral.Integer_ictel[] config_atuador3_setpoint2_setp6;

			// Token: 0x0400136B RID: 4971
			public RT_geral.Combo_ictel_ctrl[] config_atuador4_perif;

			// Token: 0x0400136C RID: 4972
			public RT_geral.Integer_ictel[] config_atuador4_mem;

			// Token: 0x0400136D RID: 4973
			public RT_geral.Combo_ictel_ctrl[] config_atuador4_var1;

			// Token: 0x0400136E RID: 4974
			public RT_geral.Integer_ictel[] config_atuador4_escala1;

			// Token: 0x0400136F RID: 4975
			public RT_geral.Combo_ictel_ctrl[] config_atuador4_var2;

			// Token: 0x04001370 RID: 4976
			public RT_geral.Integer_ictel[] config_atuador4_escala2;

			// Token: 0x04001371 RID: 4977
			public RT_geral.Integer_ictel[] config_atuador4_histerese;

			// Token: 0x04001372 RID: 4978
			public RT_geral.Combo_ictel_ctrl[] config_atuador4_formato;

			// Token: 0x04001373 RID: 4979
			public RT_geral.Combo_ictel_ctrl[] config_atuador4_base10;

			// Token: 0x04001374 RID: 4980
			public RT_geral.Integer_ictel[] config_atuador4_v1baixo;

			// Token: 0x04001375 RID: 4981
			public RT_geral.Integer_ictel[] config_atuador4_v1alto;

			// Token: 0x04001376 RID: 4982
			public RT_geral.Integer_ictel[] config_atuador4_v2baixo;

			// Token: 0x04001377 RID: 4983
			public RT_geral.Integer_ictel[] config_atuador4_v2alto;

			// Token: 0x04001378 RID: 4984
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_hora;

			// Token: 0x04001379 RID: 4985
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_minuto;

			// Token: 0x0400137A RID: 4986
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_ref1;

			// Token: 0x0400137B RID: 4987
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_setp1;

			// Token: 0x0400137C RID: 4988
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_ref2;

			// Token: 0x0400137D RID: 4989
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_setp2;

			// Token: 0x0400137E RID: 4990
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_ref3;

			// Token: 0x0400137F RID: 4991
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_setp3;

			// Token: 0x04001380 RID: 4992
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_ref4;

			// Token: 0x04001381 RID: 4993
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_setp4;

			// Token: 0x04001382 RID: 4994
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_ref5;

			// Token: 0x04001383 RID: 4995
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_setp5;

			// Token: 0x04001384 RID: 4996
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_ref6;

			// Token: 0x04001385 RID: 4997
			public RT_geral.Integer_ictel[] config_atuador4_setpoint1_setp6;

			// Token: 0x04001386 RID: 4998
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_ref1;

			// Token: 0x04001387 RID: 4999
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_setp1;

			// Token: 0x04001388 RID: 5000
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_ref2;

			// Token: 0x04001389 RID: 5001
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_setp2;

			// Token: 0x0400138A RID: 5002
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_ref3;

			// Token: 0x0400138B RID: 5003
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_setp3;

			// Token: 0x0400138C RID: 5004
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_ref4;

			// Token: 0x0400138D RID: 5005
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_setp4;

			// Token: 0x0400138E RID: 5006
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_ref5;

			// Token: 0x0400138F RID: 5007
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_setp5;

			// Token: 0x04001390 RID: 5008
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_ref6;

			// Token: 0x04001391 RID: 5009
			public RT_geral.Integer_ictel[] config_atuador4_setpoint2_setp6;

			// Token: 0x04001392 RID: 5010
			public RT_geral.Integer_ictel End_repetidora;

			// Token: 0x04001393 RID: 5011
			public RT_geral.Integer_ictel Num_repetidoras;

			// Token: 0x04001394 RID: 5012
			public RT_geral.Integer_ictel[] Repetidoras;

			// Token: 0x04001395 RID: 5013
			public RT_geral.Integer_ictel Setpoint_ctrl_tratamento_percentual;

			// Token: 0x04001396 RID: 5014
			public RT_geral.Combo_ictel_ctrl[] Setpoints_ctrl_variavel;

			// Token: 0x04001397 RID: 5015
			public RT_geral.Combo_ictel_ctrl[] Setpoints_ctrl_bloqueio;

			// Token: 0x04001398 RID: 5016
			public RT_geral.Integer_ictel[] Setpoints_ctrl_nivel_alto;

			// Token: 0x04001399 RID: 5017
			public RT_geral.Integer_ictel[] Setpoints_ctrl_nivel_baixo;

			// Token: 0x0400139A RID: 5018
			public RT_geral.Integer_ictel[] Setpoints_ctrl_nivel_liberacao;

			// Token: 0x0400139B RID: 5019
			public RT_geral.Integer_ictel[] Setpoints_ctrl_nivel_bloqueio;

			// Token: 0x0400139C RID: 5020
			public RT_geral.Integer_ictel[][] Timer_Horario;

			// Token: 0x0400139D RID: 5021
			public RT_geral.SETPOINT_HORARIO_RT_820_300[] setpoint_horario;

			// Token: 0x0400139E RID: 5022
			public string filename;

			// Token: 0x0400139F RID: 5023
			public int calibracao_canal;

			// Token: 0x040013A0 RID: 5024
			public int calibracao_range;

			// Token: 0x040013A1 RID: 5025
			public int calibracao_tipo;

			// Token: 0x040013A2 RID: 5026
			public int calibracao_const;
		}

		// Token: 0x02000065 RID: 101
		public struct FIRMWARE_RT_820_200
		{
			// Token: 0x040013A3 RID: 5027
			public RT_geral.Integer_ictel Equip;

			// Token: 0x040013A4 RID: 5028
			public RT_geral.Integer_ictel Versao;

			// Token: 0x040013A5 RID: 5029
			public RT_geral.Integer_ictel Build;

			// Token: 0x040013A6 RID: 5030
			public RT_geral.Integer_ictel Release;
		}

		// Token: 0x02000066 RID: 102
		public struct MOTORES_4_CB
		{
			// Token: 0x040013A7 RID: 5031
			public RT_geral.Combo_ictel Motor1;

			// Token: 0x040013A8 RID: 5032
			public RT_geral.Combo_ictel Motor2;

			// Token: 0x040013A9 RID: 5033
			public RT_geral.Combo_ictel Motor3;

			// Token: 0x040013AA RID: 5034
			public RT_geral.Combo_ictel Motor4;
		}

		// Token: 0x02000067 RID: 103
		public struct MOTORES_4_NUD
		{
			// Token: 0x040013AB RID: 5035
			public RT_geral.Integer_ictel Motor1;

			// Token: 0x040013AC RID: 5036
			public RT_geral.Integer_ictel Motor2;

			// Token: 0x040013AD RID: 5037
			public RT_geral.Integer_ictel Motor3;

			// Token: 0x040013AE RID: 5038
			public RT_geral.Integer_ictel Motor4;
		}

		// Token: 0x02000068 RID: 104
		public struct VALVULAS_4_NUD
		{
			// Token: 0x040013AF RID: 5039
			public RT_geral.Integer_ictel Valvula1;

			// Token: 0x040013B0 RID: 5040
			public RT_geral.Integer_ictel Valvula2;

			// Token: 0x040013B1 RID: 5041
			public RT_geral.Integer_ictel Valvula3;

			// Token: 0x040013B2 RID: 5042
			public RT_geral.Integer_ictel Valvula4;
		}

		// Token: 0x02000069 RID: 105
		public struct SETPOINT_RT820_200
		{
			// Token: 0x040013B3 RID: 5043
			public RT_geral.Integer_ictel M1_Alto;

			// Token: 0x040013B4 RID: 5044
			public RT_geral.Integer_ictel M1_Baixo;

			// Token: 0x040013B5 RID: 5045
			public RT_geral.Integer_ictel M2_Alto;

			// Token: 0x040013B6 RID: 5046
			public RT_geral.Integer_ictel M2_Baixo;

			// Token: 0x040013B7 RID: 5047
			public RT_geral.Integer_ictel M3_Alto;

			// Token: 0x040013B8 RID: 5048
			public RT_geral.Integer_ictel M3_Baixo;

			// Token: 0x040013B9 RID: 5049
			public RT_geral.Integer_ictel M4_Alto;

			// Token: 0x040013BA RID: 5050
			public RT_geral.Integer_ictel M4_Baixo;

			// Token: 0x040013BB RID: 5051
			public RT_geral.Integer_ictel Protecao_Desliga;

			// Token: 0x040013BC RID: 5052
			public RT_geral.Integer_ictel Protecao_Liga;
		}

		// Token: 0x0200006A RID: 106
		public struct PERIFERICO
		{
			// Token: 0x040013BD RID: 5053
			public RT_geral.Combo_ictel Equipamento;

			// Token: 0x040013BE RID: 5054
			public RT_geral.Integer_ictel End_Quant;
		}

		// Token: 0x0200006B RID: 107
		public struct PERFIRICO_4
		{
			// Token: 0x040013BF RID: 5055
			public RT_geral.PERIFERICO Perif1;

			// Token: 0x040013C0 RID: 5056
			public RT_geral.PERIFERICO Perif2;

			// Token: 0x040013C1 RID: 5057
			public RT_geral.PERIFERICO Perif3;

			// Token: 0x040013C2 RID: 5058
			public RT_geral.PERIFERICO Perif4;
		}

		// Token: 0x0200006C RID: 108
		public struct CFG_GERAL_RT_820_200
		{
			// Token: 0x040013C3 RID: 5059
			public RT_geral.Integer_ictel End_estacao;

			// Token: 0x040013C4 RID: 5060
			public RT_geral.Integer_ictel End_mestre;

			// Token: 0x040013C5 RID: 5061
			public RT_geral.Combo_ictel modo_repetidora;

			// Token: 0x040013C6 RID: 5062
			public RT_geral.Integer_ictel Tempo_ptt;

			// Token: 0x040013C7 RID: 5063
			public RT_geral.Combo_ictel BaudRateCOM2;

			// Token: 0x040013C8 RID: 5064
			public RT_geral.Integer_ictel AD_Intervalo;

			// Token: 0x040013C9 RID: 5065
			public RT_geral.Integer_ictel AD_Tamanho_filtro;

			// Token: 0x040013CA RID: 5066
			public RT_geral.Combo_ictel modo_operacao;

			// Token: 0x040013CB RID: 5067
			public RT_geral.Integer_ictel quantidade_motores;

			// Token: 0x040013CC RID: 5068
			public RT_geral.Integer_ictel quantidade_valvulas;

			// Token: 0x040013CD RID: 5069
			public RT_geral.Combo_ictel[] modo_partida;

			// Token: 0x040013CE RID: 5070
			public RT_geral.Combo_ictel[] entradas;

			// Token: 0x040013CF RID: 5071
			public RT_geral.SETPOINT_RT820_200 setpoints;

			// Token: 0x040013D0 RID: 5072
			public RT_geral.MOTORES_4_NUD partida;

			// Token: 0x040013D1 RID: 5073
			public RT_geral.MOTORES_4_NUD parada;

			// Token: 0x040013D2 RID: 5074
			public RT_geral.VALVULAS_4_NUD abertura;

			// Token: 0x040013D3 RID: 5075
			public RT_geral.VALVULAS_4_NUD fechamento;

			// Token: 0x040013D4 RID: 5076
			public RT_geral.Integer_ictel tempo_acionamentos;

			// Token: 0x040013D5 RID: 5077
			public RT_geral.Integer_ictel bombas_simultaneas;

			// Token: 0x040013D6 RID: 5078
			public RT_geral.Integer_ictel nivel_fonte;

			// Token: 0x040013D7 RID: 5079
			public RT_geral.Integer_ictel numero_vazoes;

			// Token: 0x040013D8 RID: 5080
			public RT_geral.PERIFERICO[] perifericos;

			// Token: 0x040013D9 RID: 5081
			public RT_geral.Combo_ictel origem_controle;

			// Token: 0x040013DA RID: 5082
			public RT_geral.Combo_ictel origem_protecao;
		}

		// Token: 0x0200006D RID: 109
		public struct REPETIDORA_RT_820_200
		{
			// Token: 0x040013DB RID: 5083
			public RT_geral.Integer_ictel End_repetidora;

			// Token: 0x040013DC RID: 5084
			public RT_geral.Integer_ictel Num_repetidoras;

			// Token: 0x040013DD RID: 5085
			public RT_geral.Integer_ictel[] Repetidoras;
		}

		// Token: 0x0200006E RID: 110
		public struct SETPOINT_HORARIO_RT_820_200
		{
			// Token: 0x040013DE RID: 5086
			public RT_geral.Integer_ictel Hora;

			// Token: 0x040013DF RID: 5087
			public RT_geral.Integer_ictel Minuto;

			// Token: 0x040013E0 RID: 5088
			public RT_geral.Integer_ictel Alto;

			// Token: 0x040013E1 RID: 5089
			public RT_geral.Integer_ictel Baixo;
		}

		// Token: 0x0200006F RID: 111
		public struct DADOS_RT_820_200_CONFIG
		{
			// Token: 0x040013E2 RID: 5090
			public RT_geral.FIRMWARE_RT_820_200 firmware;

			// Token: 0x040013E3 RID: 5091
			public RT_geral.CFG_GERAL_RT_820_200 cfg_geral;

			// Token: 0x040013E4 RID: 5092
			public RT_geral.REPETIDORA_RT_820_200 repetidora;

			// Token: 0x040013E5 RID: 5093
			public RT_geral.SETPOINT_HORARIO_RT_820_200[] setpoint_horario;

			// Token: 0x040013E6 RID: 5094
			public string filename;
		}

		// Token: 0x02000070 RID: 112
		public struct DADOS_RT_821_CONFIG
		{
			// Token: 0x040013E7 RID: 5095
			public RT_geral.Integer_ictel Equip;

			// Token: 0x040013E8 RID: 5096
			public RT_geral.Integer_ictel Versao;

			// Token: 0x040013E9 RID: 5097
			public RT_geral.Integer_ictel Build;

			// Token: 0x040013EA RID: 5098
			public RT_geral.Integer_ictel Release;

			// Token: 0x040013EB RID: 5099
			public RT_geral.Integer_ictel End_estacao;

			// Token: 0x040013EC RID: 5100
			public RT_geral.Integer_ictel End_mestre;

			// Token: 0x040013ED RID: 5101
			public RT_geral.Combo_ictel Modelo;

			// Token: 0x040013EE RID: 5102
			public RT_geral.Combo_ictel modo_repetidora;

			// Token: 0x040013EF RID: 5103
			public RT_geral.Integer_ictel Tempo_ptt;

			// Token: 0x040013F0 RID: 5104
			public RT_geral.Combo_ictel modo_operacao;

			// Token: 0x040013F1 RID: 5105
			public RT_geral.Integer_ictel intervalo_tx;

			// Token: 0x040013F2 RID: 5106
			public RT_geral.Combo_ictel baudrate_com1;

			// Token: 0x040013F3 RID: 5107
			public RT_geral.Combo_ictel baudrate_com2;

			// Token: 0x040013F4 RID: 5108
			public RT_geral.Integer_ictel AD_Intervalo;

			// Token: 0x040013F5 RID: 5109
			public RT_geral.Integer_ictel AD_Tamanho_filtro;

			// Token: 0x040013F6 RID: 5110
			public RT_geral.Integer_ictel[] EA_Range;

			// Token: 0x040013F7 RID: 5111
			public RT_geral.Integer_ictel[] EA_Inicio;

			// Token: 0x040013F8 RID: 5112
			public RT_geral.Integer_ictel[] EA_Fim;

			// Token: 0x040013F9 RID: 5113
			public RT_geral.Combo_ictel_ctrl[] ctrl_acionamento;

			// Token: 0x040013FA RID: 5114
			public RT_geral.Combo_ictel_ctrl[] ctrl_ret_acionamento;

			// Token: 0x040013FB RID: 5115
			public RT_geral.Combo_ictel_ctrl[] ctrl_ED_selecao;

			// Token: 0x040013FC RID: 5116
			public RT_geral.Combo_ictel_ctrl[] ctrl_reverso;

			// Token: 0x040013FD RID: 5117
			public RT_geral.Combo_ictel_ctrl[] ctrl_modo;

			// Token: 0x040013FE RID: 5118
			public RT_geral.Integer_ictel[] ctrl_tempo_max_partida;

			// Token: 0x040013FF RID: 5119
			public RT_geral.Integer_ictel[] ctrl_tempo_max_parada;

			// Token: 0x04001400 RID: 5120
			public RT_geral.Combo_ictel_ctrl[] motores_simultaneos;

			// Token: 0x04001401 RID: 5121
			public RT_geral.Integer_ictel[] motores_tempo_entre_acionamentos;

			// Token: 0x04001402 RID: 5122
			public RT_geral.Combo_ictel_ctrl[] config_ED;

			// Token: 0x04001403 RID: 5123
			public RT_geral.Integer_ictel[] dsp_escalas;

			// Token: 0x04001404 RID: 5124
			public RT_geral.Combo_ictel_ctrl[] dsp_pto_decimal;

			// Token: 0x04001405 RID: 5125
			public RT_geral.String_ictel[] dsp_nome;

			// Token: 0x04001406 RID: 5126
			public RT_geral.Integer_ictel[] dsp_hab;

			// Token: 0x04001407 RID: 5127
			public RT_geral.Integer_ictel End_repetidora;

			// Token: 0x04001408 RID: 5128
			public RT_geral.Integer_ictel Num_repetidoras;

			// Token: 0x04001409 RID: 5129
			public RT_geral.Integer_ictel[] Repetidoras;

			// Token: 0x0400140A RID: 5130
			public RT_geral.Combo_ictel_ctrl[] Setpoints_ctrl_variavel;

			// Token: 0x0400140B RID: 5131
			public RT_geral.Integer_ictel[] Setpoints_ctrl_nivel_alto;

			// Token: 0x0400140C RID: 5132
			public RT_geral.Integer_ictel[] Setpoints_ctrl_nivel_baixo;

			// Token: 0x0400140D RID: 5133
			public string filename;
		}

		// Token: 0x02000071 RID: 113
		public struct MOTORES_3_CB
		{
			// Token: 0x0400140E RID: 5134
			public RT_geral.Combo_ictel Motor1;

			// Token: 0x0400140F RID: 5135
			public RT_geral.Combo_ictel Motor2;

			// Token: 0x04001410 RID: 5136
			public RT_geral.Combo_ictel Motor3;
		}

		// Token: 0x02000072 RID: 114
		public struct MOTORES_3_NUD
		{
			// Token: 0x04001411 RID: 5137
			public RT_geral.Integer_ictel Motor1;

			// Token: 0x04001412 RID: 5138
			public RT_geral.Integer_ictel Motor2;

			// Token: 0x04001413 RID: 5139
			public RT_geral.Integer_ictel Motor3;
		}

		// Token: 0x02000073 RID: 115
		public struct FIRMWARE_RT_821_200
		{
			// Token: 0x04001414 RID: 5140
			public RT_geral.Integer_ictel Equip;

			// Token: 0x04001415 RID: 5141
			public RT_geral.Integer_ictel Versao;

			// Token: 0x04001416 RID: 5142
			public RT_geral.Integer_ictel Build;

			// Token: 0x04001417 RID: 5143
			public RT_geral.Integer_ictel Release;
		}

		// Token: 0x02000074 RID: 116
		public struct SETPOINT_RT821_200
		{
			// Token: 0x04001418 RID: 5144
			public RT_geral.Integer_ictel M1_Alto;

			// Token: 0x04001419 RID: 5145
			public RT_geral.Integer_ictel M1_Baixo;

			// Token: 0x0400141A RID: 5146
			public RT_geral.Integer_ictel M2_Alto;

			// Token: 0x0400141B RID: 5147
			public RT_geral.Integer_ictel M2_Baixo;

			// Token: 0x0400141C RID: 5148
			public RT_geral.Integer_ictel M3_Alto;

			// Token: 0x0400141D RID: 5149
			public RT_geral.Integer_ictel M3_Baixo;
		}

		// Token: 0x02000075 RID: 117
		public struct CFG_GERAL_RT_821_200
		{
			// Token: 0x0400141E RID: 5150
			public RT_geral.Integer_ictel End_estacao;

			// Token: 0x0400141F RID: 5151
			public RT_geral.Integer_ictel End_mestre;

			// Token: 0x04001420 RID: 5152
			public RT_geral.Combo_ictel modo_repetidora;

			// Token: 0x04001421 RID: 5153
			public RT_geral.Integer_ictel Tempo_ptt;

			// Token: 0x04001422 RID: 5154
			public RT_geral.Integer_ictel quantidade_motores;

			// Token: 0x04001423 RID: 5155
			public RT_geral.Combo_ictel[] modo_partida;

			// Token: 0x04001424 RID: 5156
			public RT_geral.SETPOINT_RT821_200 setpoints;

			// Token: 0x04001425 RID: 5157
			public RT_geral.MOTORES_3_NUD partida;

			// Token: 0x04001426 RID: 5158
			public RT_geral.MOTORES_3_NUD parada;

			// Token: 0x04001427 RID: 5159
			public RT_geral.Integer_ictel tempo_acionamentos;

			// Token: 0x04001428 RID: 5160
			public RT_geral.Integer_ictel motores_simultaneos;

			// Token: 0x04001429 RID: 5161
			public RT_geral.Combo_ictel[] entradas;
		}

		// Token: 0x02000076 RID: 118
		public struct REPETIDORA_RT_821_200
		{
			// Token: 0x0400142A RID: 5162
			public RT_geral.Integer_ictel End_repetidora;

			// Token: 0x0400142B RID: 5163
			public RT_geral.Integer_ictel Num_repetidoras;

			// Token: 0x0400142C RID: 5164
			public RT_geral.Integer_ictel[] Repetidoras;
		}

		// Token: 0x02000077 RID: 119
		public struct DADOS_RT_821_200_CONFIG
		{
			// Token: 0x0400142D RID: 5165
			public RT_geral.FIRMWARE_RT_821_200 firmware;

			// Token: 0x0400142E RID: 5166
			public RT_geral.CFG_GERAL_RT_821_200 cfg_geral;

			// Token: 0x0400142F RID: 5167
			public RT_geral.REPETIDORA_RT_821_200 repetidora;

			// Token: 0x04001430 RID: 5168
			public string filename;
		}

		// Token: 0x02000078 RID: 120
		public struct DADOS_RT_850_CONFIG
		{
			// Token: 0x04001431 RID: 5169
			public RT_geral.Integer_ictel Equip;

			// Token: 0x04001432 RID: 5170
			public RT_geral.Integer_ictel Versao;

			// Token: 0x04001433 RID: 5171
			public RT_geral.Integer_ictel Build;

			// Token: 0x04001434 RID: 5172
			public RT_geral.Integer_ictel Release;

			// Token: 0x04001435 RID: 5173
			public RT_geral.String_ictel Msg_linha_1;

			// Token: 0x04001436 RID: 5174
			public RT_geral.String_ictel Msg_linha_2;

			// Token: 0x04001437 RID: 5175
			public RT_geral.String_ictel Msg_linha_3;

			// Token: 0x04001438 RID: 5176
			public RT_geral.String_ictel Msg_linha_4;

			// Token: 0x04001439 RID: 5177
			public RT_geral.Integer_ictel End_mestre_canal_1;

			// Token: 0x0400143A RID: 5178
			public RT_geral.Integer_ictel Intervalo_leitura_canal_1;

			// Token: 0x0400143B RID: 5179
			public RT_geral.Combo_ictel BaudRate_canal_1;

			// Token: 0x0400143C RID: 5180
			public RT_geral.Integer_ictel Timeout_canal_1;

			// Token: 0x0400143D RID: 5181
			public RT_geral.Integer_ictel Tempo_ptt_canal_1;

			// Token: 0x0400143E RID: 5182
			public RT_geral.Integer_ictel Numero_tentativas_canal_1;

			// Token: 0x0400143F RID: 5183
			public RT_geral.Integer_ictel Numero_erros_falha_canal_1;

			// Token: 0x04001440 RID: 5184
			public RT_geral.Integer_ictel Numero_cmd_estatistica_canal1;

			// Token: 0x04001441 RID: 5185
			public RT_geral.Integer_ictel Numero_equip_tipo_1;

			// Token: 0x04001442 RID: 5186
			public RT_geral.Integer_ictel Numero_equip_tipo_2;

			// Token: 0x04001443 RID: 5187
			public RT_geral.Integer_ictel Numero_equip_tipo_3;

			// Token: 0x04001444 RID: 5188
			public RT_geral.Integer_ictel Numero_equip_tipo_vista;

			// Token: 0x04001445 RID: 5189
			public RT_geral.Integer_ictel End_inicial_equip_tipo_1;

			// Token: 0x04001446 RID: 5190
			public RT_geral.Integer_ictel End_inicial_equip_tipo_2;

			// Token: 0x04001447 RID: 5191
			public RT_geral.Integer_ictel End_inicial_equip_tipo_3;

			// Token: 0x04001448 RID: 5192
			public RT_geral.Integer_ictel End_inicial_equip_tipo_vista;

			// Token: 0x04001449 RID: 5193
			public RT_geral.Integer_ictel End_mestre_canal_2;

			// Token: 0x0400144A RID: 5194
			public RT_geral.Integer_ictel Intervalo_leitura_canal_2;

			// Token: 0x0400144B RID: 5195
			public RT_geral.Combo_ictel BaudRate_canal_2;

			// Token: 0x0400144C RID: 5196
			public RT_geral.Integer_ictel Timeout_canal_2;

			// Token: 0x0400144D RID: 5197
			public RT_geral.Integer_ictel Tempo_ptt_canal_2;

			// Token: 0x0400144E RID: 5198
			public RT_geral.Integer_ictel Numero_tentativas_canal_2;

			// Token: 0x0400144F RID: 5199
			public RT_geral.Integer_ictel Numero_erros_falha_canal_2;

			// Token: 0x04001450 RID: 5200
			public RT_geral.Integer_ictel Numero_cmd_estatistica_canal2;

			// Token: 0x04001451 RID: 5201
			public RT_geral.Integer_ictel Sincronismo;

			// Token: 0x04001452 RID: 5202
			public RT_geral.Integer_ictel ConfereResposta;

			// Token: 0x04001453 RID: 5203
			public RT_geral.Integer_ictel Modo_Estatistica;

			// Token: 0x04001454 RID: 5204
			public RT_geral.Integer_ictel Variaveis_Numero;

			// Token: 0x04001455 RID: 5205
			public RT_geral.Integer_ictel LiberaTeclado;

			// Token: 0x04001456 RID: 5206
			public RT_geral.Combo_ictel Flag_Remota;

			// Token: 0x04001457 RID: 5207
			public RT_geral.Combo_ictel Flag_Supervisorio;

			// Token: 0x04001458 RID: 5208
			public string Nome_Arquivo;

			// Token: 0x04001459 RID: 5209
			public RT_geral.Combo_ictel Vista_selecionado;
		}

		// Token: 0x02000079 RID: 121
		public struct Dados_Ctrl
		{
			// Token: 0x0400145A RID: 5210
			public RT_geral.String_ictel Nome;

			// Token: 0x0400145B RID: 5211
			public RT_geral.Combo_ictel_ctrl Canal;

			// Token: 0x0400145C RID: 5212
			public RT_geral.Combo_ictel_ctrl Comando;

			// Token: 0x0400145D RID: 5213
			public RT_geral.Combo_ictel_ctrl Prioridade;

			// Token: 0x0400145E RID: 5214
			public RT_geral.Combo_ictel_ctrl Timeout;

			// Token: 0x0400145F RID: 5215
			public RT_geral.Combo_ictel_ctrl Modelo;

			// Token: 0x04001460 RID: 5216
			public RT_geral.Combo_ictel_ctrl[] Var;

			// Token: 0x04001461 RID: 5217
			public RT_geral.Combo_ictel_ctrl[] Ref;

			// Token: 0x04001462 RID: 5218
			public RT_geral.Combo_ictel_ctrl[] Crtl_nome;

			// Token: 0x04001463 RID: 5219
			public RT_geral.Integer_ictel[] Crtl_indice;
		}

		// Token: 0x0200007A RID: 122
		public struct Dados_Ctrl_3
		{
			// Token: 0x04001464 RID: 5220
			public RT_geral.String_ictel Nome;

			// Token: 0x04001465 RID: 5221
			public RT_geral.Combo_ictel_ctrl Canal;

			// Token: 0x04001466 RID: 5222
			public RT_geral.Combo_ictel_ctrl Comando;

			// Token: 0x04001467 RID: 5223
			public RT_geral.Combo_ictel_ctrl Prioridade;

			// Token: 0x04001468 RID: 5224
			public RT_geral.Combo_ictel_ctrl Timeout;

			// Token: 0x04001469 RID: 5225
			public RT_geral.Combo_ictel_ctrl Modelo;

			// Token: 0x0400146A RID: 5226
			public RT_geral.Combo_ictel_ctrl[] Var;

			// Token: 0x0400146B RID: 5227
			public RT_geral.Combo_ictel_ctrl[] Ref;

			// Token: 0x0400146C RID: 5228
			public RT_geral.Combo_ictel_ctrl[] Crtl_nome;

			// Token: 0x0400146D RID: 5229
			public RT_geral.Integer_ictel[] Crtl_indice;

			// Token: 0x0400146E RID: 5230
			public RT_geral.Combo_ictel_ctrl[] Periferico_Modelo;

			// Token: 0x0400146F RID: 5231
			public RT_geral.Combo_ictel_ctrl[] Periferico_Indice;
		}

		// Token: 0x0200007B RID: 123
		public struct Dados_Ctrl_Vista
		{
			// Token: 0x04001470 RID: 5232
			public RT_geral.String_ictel Nome;

			// Token: 0x04001471 RID: 5233
			public RT_geral.Combo_ictel_ctrl Canal;

			// Token: 0x04001472 RID: 5234
			public RT_geral.Combo_ictel_ctrl Prioridade;

			// Token: 0x04001473 RID: 5235
			public RT_geral.Combo_ictel_ctrl Timeout;

			// Token: 0x04001474 RID: 5236
			public RT_geral.Combo_ictel_ctrl Modelo;

			// Token: 0x04001475 RID: 5237
			public RT_geral.Integer_ictel Num_var;

			// Token: 0x04001476 RID: 5238
			public RT_geral.Integer_ictel Num_equip;

			// Token: 0x04001477 RID: 5239
			public RT_geral.Combo_ictel_ctrl[] Variaveis;

			// Token: 0x04001478 RID: 5240
			public RT_geral.Combo_ictel_ctrl[] Equipamentos;
		}

		// Token: 0x0200007C RID: 124
		public struct Dados_Controle
		{
			// Token: 0x04001479 RID: 5241
			public bool LiberaEventos_Variaveis;
		}

		// Token: 0x0200007D RID: 125
		public struct DADO_VARIAVEL
		{
			// Token: 0x0400147A RID: 5242
			public RT_geral.String_ictel Nome;

			// Token: 0x0400147B RID: 5243
			public RT_geral.Integer_ictel Escala_ini;

			// Token: 0x0400147C RID: 5244
			public RT_geral.Combo_ictel_ctrl Pto_dec_ini;

			// Token: 0x0400147D RID: 5245
			public RT_geral.Integer_ictel Escala_fim;

			// Token: 0x0400147E RID: 5246
			public RT_geral.Combo_ictel_ctrl Escala_tratamento;

			// Token: 0x0400147F RID: 5247
			public RT_geral.Combo_ictel_ctrl Pto_dec_fim;

			// Token: 0x04001480 RID: 5248
			public RT_geral.Integer_ictel Nivel_alm_1;

			// Token: 0x04001481 RID: 5249
			public RT_geral.Combo_ictel_ctrl Tipo_alm_1;

			// Token: 0x04001482 RID: 5250
			public RT_geral.Combo_ictel_ctrl Msg_alm_1;

			// Token: 0x04001483 RID: 5251
			public RT_geral.Integer_ictel Nivel_alm_2;

			// Token: 0x04001484 RID: 5252
			public RT_geral.Combo_ictel_ctrl Tipo_alm_2;

			// Token: 0x04001485 RID: 5253
			public RT_geral.Combo_ictel_ctrl Msg_alm_2;

			// Token: 0x04001486 RID: 5254
			public RT_geral.Integer_ictel Dsp_tela;

			// Token: 0x04001487 RID: 5255
			public RT_geral.Combo_ictel_ctrl Dsp_pos;
		}

		// ── RT_821/380 — DataGridView generation methods ─────────────────────
		public static void GeraDataGridView_Vazoes(DataGridView dgv)
		{
			dgv.AllowUserToAddRows = false;
			dgv.AllowUserToDeleteRows = false;
			dgv.AllowUserToResizeColumns = false;
			dgv.AllowUserToResizeRows = false;
			dgv.AllowUserToOrderColumns = false;
			dgv.RowHeadersVisible = true;
			dgv.RowHeadersWidth = 100;
			dgv.ScrollBars = ScrollBars.None;
			dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
			dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			dgv.Columns.Clear();

			var cols = RT_geral.RT_821_380_DatagridViewVazoesColunas;
			int[] larguras = new int[] { 50, 130, 80, 65, 65, 70 };

			for (int ci = 0; ci < 6; ci++)
			{
				DataGridViewColumn col;
				if (cols[ci].NumeroLinhaMenu > 0)
					col = Linha_RT.CreateComboBoxColumn(ci.ToString(), ref cols);
				else
					col = Linha_RT.CreateTextColumn(ci.ToString(), ref cols);
				col.Width = larguras[ci];
				dgv.Columns.Add(col);
			}

			dgv.RowCount = 8;
			int idx = 1;
			foreach (DataGridViewRow row in dgv.Rows)
				if (!row.IsNewRow) row.HeaderCell.Value = "Vazão " + idx++;
		}

		public static void GeraDataGridView_Perifericos(DataGridView dgv)
		{
			dgv.AllowUserToAddRows = false;
			dgv.AllowUserToDeleteRows = false;
			dgv.AllowUserToResizeColumns = false;
			dgv.AllowUserToResizeRows = false;
			dgv.AllowUserToOrderColumns = false;
			dgv.RowHeadersVisible = true;
			dgv.RowHeadersWidth = 110;
			dgv.ScrollBars = ScrollBars.None;
			dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
			dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			dgv.Columns.Clear();

			var cols = RT_geral.RT_821_380_DatagridViewPerifericosColunas;
			int[] larguras = new int[] { 75, 120, 80, 90, 75 };

			for (int ci = 0; ci < 5; ci++)
			{
				DataGridViewColumn col;
				if (cols[ci].NumeroLinhaMenu > 0)
					col = Linha_RT.CreateComboBoxColumn(ci.ToString(), ref cols);
				else
					col = Linha_RT.CreateTextColumn(ci.ToString(), ref cols);
				col.Width = larguras[ci];
				dgv.Columns.Add(col);
			}

			dgv.RowCount = 5;
			int idx = 1;
			foreach (DataGridViewRow row in dgv.Rows)
				if (!row.IsNewRow) row.HeaderCell.Value = "Periférico " + idx++;
		}

		public static void GeraDataGridView_Referencia_Periferico(DataGridView dgv)
		{
			dgv.AllowUserToAddRows = false;
			dgv.AllowUserToDeleteRows = false;
			dgv.AllowUserToResizeColumns = false;
			dgv.AllowUserToResizeRows = false;
			dgv.AllowUserToOrderColumns = false;
			dgv.RowHeadersVisible = true;
			dgv.RowHeadersWidth = 80;
			dgv.ScrollBars = ScrollBars.None;
			dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
			dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			dgv.Columns.Clear();

			var cols = RT_geral.RT_821_380_DataGridViewReferenciaPerifericosColunas;
			int[] larguras = new int[] { 100, 100, 80 };

			for (int ci = 0; ci < 3; ci++)
			{
				DataGridViewColumn col;
				if (cols[ci].NumeroLinhaMenu > 0)
					col = Linha_RT.CreateComboBoxColumn(ci.ToString(), ref cols);
				else
					col = Linha_RT.CreateTextColumn(ci.ToString(), ref cols);
				col.Width = larguras[ci];
				dgv.Columns.Add(col);
			}

			dgv.RowCount = 5;
		}

		public static void PreencheHeadersReferencias(DataGridView dgv, int inicio)
		{
			dgv.RowCount = 5;
			for (int i = 0; i < dgv.Rows.Count; i++)
			{
				if (!dgv.Rows[i].IsNewRow)
					dgv.Rows[i].HeaderCell.Value = (inicio + i).ToString();
			}
		}
	}
}
