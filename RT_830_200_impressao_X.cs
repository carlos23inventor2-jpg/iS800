using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iS800.My;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x02000018 RID: 24
	[StandardModule]
	internal sealed class RT_830_200_impressao_X
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x00222204 File Offset: 0x00220604
		public static void Impressao_BeginPrint_RT830()
		{
			RT_830_200_impressao_X.pagina_impressao = (HorizontalAlignment)1;
			RT_830_200_impressao_X.grupo_impressao = (HorizontalAlignment)1;
			RT_830_200_impressao_X.quantos_imprimiu = (HorizontalAlignment)0;
			RT_830_200_impressao_X.quantos_imprimiu2 = (HorizontalAlignment)0;
			RT_830_200_impressao_X.quantos_imprimiu3 = (HorizontalAlignment)0;
			RT_830_200_impressao_X.quantos_imprimiu4 = (HorizontalAlignment)0;
			RT_830_200_impressao_X.inicio = (HorizontalAlignment)5;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00222230 File Offset: 0x00220630
		public static bool DesenhaRelatorio_RT830(PrintPageEventArgs z, Form frm)
		{
			bool result;
			switch (RT_830_200_impressao_X.grupo_impressao)
			{
			case 1:
				result = RT_830_200_impressao_X.DesenhaRelatorioRT830Grupo1(z, (RT_830_200_configurador)frm);
				break;
			case 2:
				result = RT_830_200_impressao_X.DesenhaRelatorioRT830Grupo2(z);
				break;
			case 3:
				result = RT_830_200_impressao_X.DesenhaRelatorioRT830Grupo3(z);
				break;
			case 4:
				result = RT_830_200_impressao_X.DesenhaRelatorioRT830Grupo4(z);
				break;
			case 5:
				result = RT_830_200_impressao_X.DesenhaRelatorioRT830Grupo5(z);
				break;
			}
			return result;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00222294 File Offset: 0x00220694
		[MethodImpl(72)]
		public static bool DesenhaRelatorioRT830Grupo1(PrintPageEventArgs z, RT_830_200_configurador frm)
		{
			Font font = new Font("Calibri", 10f, 3);
			Font font2 = new Font("Calibri", 10f, 3, (FontStyle)3);
			Font font3 = new Font("Calibri", 10f, 0, (FontStyle)3);
			Font fonte = new Font("Calibri", 20f, 1, (FontStyle)3);
			Font font4 = new Font("Times New Roman", 14f, 0, (FontStyle)3);
			Font font5 = new Font("Times New Roman", 14f, 0, (FontStyle)3);
			Pen pen = new Pen(Color.Black, 2f);
			FontesTabela fonte2;
			fonte2.Titulo = font2;
			fonte2.Variavel = font3;
			fonte2.Valor = font3;
			CoresTabela cores;
			cores.Titulo = Brushes.Black;
			cores.Variavel = Brushes.Blue;
			cores.Valor = Brushes.DarkBlue;
			cores.Tabela = Color.Black;
			cores.TituloBG = Color.AliceBlue;
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_830_200_variaveis_X.RT_830_200_BD.firmware.Equip.Valor, RT_830_200_variaveis_X.RT_830_200_BD.firmware.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 4, "Dados da Estação", true);
			tabelaLinhaInteria.EscreveTituloValorLinha(1, "Local de Instalação", frm.TextBox_nome_RT850.Text, 0, 160);
			tabelaLinhaInteria.EscreveTituloValorLinha(2, "Endereço", frm.TextBox_endereco_RT850.Text, 0, 90);
			string valor = "iS800 (" + MyProject.Application.Info.Version.ToString() + ")";
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Configurador", valor, 0, 160);
			string valor2 = string.Concat(new string[]
			{
				"CT",
				RT_830_200_variaveis_X.RT_830_200_BD.firmware.Equip.Valor.ToString(),
				"_",
				RT_830_200_variaveis_X.RT_830_200_BD.firmware.Versao.Valor.ToString(),
				string.Format("{0:D2}", RT_830_200_variaveis_X.RT_830_200_BD.firmware.Build.Valor),
				"  R",
				RT_830_200_variaveis_X.RT_830_200_BD.firmware.Release.Valor.ToString()
			});
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Firmware", valor2, 350, 430);
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Data", string.Concat(new string[]
			{
				DateTime.Today.Day.ToString(),
				"/",
				DateTime.Today.Month.ToString(),
				"/",
				DateTime.Today.Year.ToString()
			}), 850, 530);
			tabelaLinhaInteria.EscreveTituloValorLinha(4, "Arquivo", Path.GetFileName(RT_830_200_variaveis_X.RT_830_200_BD.filename), 0, 160);
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 15, 5, "Dados de Instalação", true);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(1, "Tipo de antena", frm.CB_TipoAntena1.Text, 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(1, "Azimute", frm.T_Azimute1.Text + " °", 280, 500);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(2, "Polarização", frm.CB_PolarizacaoAntena1.Text, 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(2, "Longitude", frm.T_Longitude1.Text, 280, 500);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(3, "Potência do Rádio", frm.T_PotRadio1.Text + " W", 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(3, "Latidude", frm.T_Latitude1.Text, 280, 500);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(4, "Modelo do Rádio", frm.CB_ModeloRadio1.Text, 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(4, "Altura", frm.T_AlturaAntena1.Text + " m", 280, 500);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(5, "Frequência do Rádio", frm.T_FreqRadio1.Text + " MHz", 0, 150);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, 15, 7, "Canal de Rádio", true);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(1, "Endereço Mestre", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor.ToString(), 0, 0);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(2, "Baud Rate", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.GetItem(), 0, 0);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(3, "Intervalo de Leitura", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.intervalo_polling.Valor.ToString(), 0, 0);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(4, "Tempo de Espera Resposta", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.timeout.Valor.ToString(), 0, 0);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(5, "Tempo de PTT (ms)", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.PTT.Valor.ToString(), 0, 0);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(6, "Número de Tentativas", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.retrys.Valor.ToString(), 0, 0);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(7, "Número de Erros para Falha", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.erros_falha.Valor.ToString(), 0, 0);
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 25, 5, "Lista de Equipamentos", true);
			tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "Tipo", 0);
			tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "Quantidade", 150);
			tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "End Inicial", 300);
			string[] array = new string[]
			{
				"Nº Reservatórios",
				"Nº Eq. Reservatório",
				"Nº Eq. Recalque",
				"Nº Eq. Vista"
			};
			RT_geral.Integer_ictel[] array2 = new RT_geral.Integer_ictel[]
			{
				RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_reservatorios,
				RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios,
				RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques,
				RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas
			};
			RT_geral.Integer_ictel[] array3 = new RT_geral.Integer_ictel[]
			{
				RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_reservatorio,
				RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_recalque,
				RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista
			};
			int num = (HorizontalAlignment)0;
			checked
			{
				do
				{
					tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(num + 2, array[num], 0);
					tabelaMeiaLinhaEsquerda2.EscreveValorLinha(num + 2, array2[num].Valor.ToString(), 155);
					num++;
				}
				while (num <= 3);
				num = (HorizontalAlignment)0;
				do
				{
					tabelaMeiaLinhaEsquerda2.EscreveValorLinha(num + 3, array3[num].Valor.ToString(), 305);
					num++;
				}
				while (num <= 2);
				TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 33, 4, "Observação", true);
				tabelaLinhaInteria2.EscreveValorLinha(1, frm.TextBox_comentarios_RT850.Text, 0);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, RT_830_200_impressao_X.pagina_impressao);
				RT_830_200_impressao_X.grupo_impressao++;
				RT_830_200_impressao_X.pagina_impressao++;
				return true;
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00222A84 File Offset: 0x00220E84
		public static bool DesenhaRelatorioRT830Grupo2(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, 3);
			Font font2 = new Font("Calibri", 10f, 3, (FontStyle)3);
			Font font3 = new Font("Calibri", 10f, 0, (FontStyle)3);
			Font fonte = new Font("Calibri", 20f, 1, (FontStyle)3);
			Font font4 = new Font("Times New Roman", 14f, 0, (FontStyle)3);
			Font font5 = new Font("Times New Roman", 14f, 0, (FontStyle)3);
			Pen pen = new Pen(Color.Black, 2f);
			FontesTabela fonte2;
			fonte2.Titulo = font2;
			fonte2.Variavel = font3;
			fonte2.Valor = font3;
			CoresTabela cores;
			cores.Titulo = Brushes.Black;
			cores.Variavel = Brushes.Blue;
			cores.Valor = Brushes.DarkBlue;
			cores.Tabela = Color.Black;
			cores.TituloBG = Color.AliceBlue;
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_830_200_variaveis_X.RT_830_200_BD.firmware.Equip.Valor, RT_830_200_variaveis_X.RT_830_200_BD.firmware.Versao.Valor);
			string text = "Endereço";
			string text2 = "Nome";
			string text3 = "Altura";
			string text4 = "Prioridade";
			string text5 = "Nº Reservatótio";
			int[] array = new int[]
			{
				0,
				80,
				150,
				250,
				350
			};
			string[] titulos = new string[]
			{
				text,
				text2,
				text3,
				text4,
				text5
			};
			int num = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios.Valor;
			if (num > 30)
			{
				num = (HorizontalAlignment)30;
			}
			checked
			{
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 5, num + 1, "Variáveis", true);
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = tabelaMeiaLinhaEsquerda;
				int num2 = (HorizontalAlignment)1;
				tabelaMeiaLinhaEsquerda2.EscreveTodosTitulos(ref num2, titulos, array);
				int num3 = (HorizontalAlignment)0;
				int num4 = num - 1;
				for (int i = num3; i <= num4; i++)
				{
					string valor = string.Format("{0:D2}", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_reservatorio.Valor + i);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(i + 2, valor, array[0] + 5);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i].Nome.Valor.ToString(), array[1] + 10);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i].Altura.Valor.ToString(), array[2] + 5);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i].Prioridade.Valor.ToString(), array[3] + 10);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i].NumeroVariavel.Valor.ToString(), array[4] + 10);
				}
				num = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios.Valor - 30;
				if (num > 0)
				{
					TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, 5, num + 1, "Variáveis Continuação", true);
					TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita2 = tabelaMeiaLinhaDireita;
					num2 = (HorizontalAlignment)1;
					tabelaMeiaLinhaDireita2.EscreveTodosTitulos(ref num2, titulos, array);
					int num5 = (HorizontalAlignment)0;
					int num6 = num - 1;
					for (int i = num5; i <= num6; i++)
					{
						string valor = string.Format("{0:D2}", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_reservatorio.Valor + i + 30);
						tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, valor, array[0]);
						tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i + 30].Nome.Valor.ToString(), array[1] + 5);
						tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i + 30].Altura.Valor.ToString(), array[2] + 5);
						tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i + 30].Prioridade.Valor.ToString(), array[3] + 10);
						tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i + 30].NumeroVariavel.Valor.ToString(), array[4] + 10);
					}
				}
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, RT_830_200_impressao_X.pagina_impressao);
				RT_830_200_impressao_X.grupo_impressao++;
				RT_830_200_impressao_X.pagina_impressao++;
				return true;
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00222F28 File Offset: 0x00221328
		public static bool DesenhaRelatorioRT830Grupo3(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, 3);
			Font font2 = new Font("Calibri", 10f, 3, (FontStyle)3);
			Font font3 = new Font("Calibri", 10f, 0, (FontStyle)3);
			Font fonte = new Font("Calibri", 20f, 1, (FontStyle)3);
			Font font4 = new Font("Times New Roman", 14f, 0, (FontStyle)3);
			Font font5 = new Font("Times New Roman", 14f, 0, (FontStyle)3);
			Pen pen = new Pen(Color.Black, 2f);
			FontesTabela fonte2;
			fonte2.Titulo = font2;
			fonte2.Variavel = font3;
			fonte2.Valor = font3;
			CoresTabela cores;
			cores.Titulo = Brushes.Black;
			cores.Variavel = Brushes.Blue;
			cores.Valor = Brushes.DarkBlue;
			cores.Tabela = Color.Black;
			cores.TituloBG = Color.AliceBlue;
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_830_200_variaveis_X.RT_830_200_BD.firmware.Equip.Valor, RT_830_200_variaveis_X.RT_830_200_BD.firmware.Versao.Valor);
			string text = "End.";
			string text2 = "Nome";
			string text3 = "Origem";
			string text4 = "Destino";
			string text5 = "Modelo";
			string text6 = "Prioridade";
			string text7 = "Var1";
			string text8 = "Var2";
			string text9 = "Var3";
			string text10 = "Var4";
			string text11 = "Nome1";
			string text12 = "Nome2";
			string text13 = "Nome3";
			string text14 = "Nome4";
			string text15 = "Hab.Cmd";
			int[] array = new int[]
			{
				0,
				35,
				80,
				130,
				190,
				250,
				330,
				370,
				410,
				450,
				490,
				550,
				610,
				670,
				730
			};
			string[] titulos = new string[]
			{
				text,
				text2,
				text3,
				text4,
				text5,
				text6,
				text7,
				text8,
				text9,
				text10,
				text11,
				text12,
				text13,
				text14,
				text15
			};
			int valor = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques.Valor;
			checked
			{
				TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, valor + 1, "Remotas de Controle", true);
				TabelaLinhaInteria tabelaLinhaInteria2 = tabelaLinhaInteria;
				int num = (HorizontalAlignment)1;
				tabelaLinhaInteria2.EscreveTodosTitulos(ref num, titulos, array);
				int num2 = (HorizontalAlignment)0;
				int num3 = valor - 1;
				for (int i = num2; i <= num3; i++)
				{
					string valor2 = string.Format("{0:D2}", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_recalque.Valor + i);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, valor2, array[0] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome.Valor.ToString(), array[1] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].origem.Valor.ToString(), array[2] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].destino.Valor.ToString(), array[3] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Modelo.GetItem(), array[4] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Prioridade.Valor.ToString(), array[5] + 20);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Var1.Valor.ToString(), array[6] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Var2.Valor.ToString(), array[7] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Var3.Valor.ToString(), array[8] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Var4.Valor.ToString(), array[9] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome_Var1.Valor.ToString(), array[10] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome_Var2.Valor.ToString(), array[11] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome_Var3.Valor.ToString(), array[12] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome_Var4.Valor.ToString(), array[13] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Habilita.GetItem(), array[14] + 10);
				}
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, RT_830_200_impressao_X.pagina_impressao);
				RT_830_200_impressao_X.grupo_impressao++;
				RT_830_200_impressao_X.pagina_impressao++;
				return true;
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00223518 File Offset: 0x00221918
		public static bool DesenhaRelatorioRT830Grupo4(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, 3);
			Font font2 = new Font("Calibri", 10f, 3, (FontStyle)3);
			Font font3 = new Font("Calibri", 10f, 0, (FontStyle)3);
			Font fonte = new Font("Calibri", 20f, 1, (FontStyle)3);
			Font font4 = new Font("Times New Roman", 14f, 0, (FontStyle)3);
			Font font5 = new Font("Times New Roman", 14f, 0, (FontStyle)3);
			Pen pen = new Pen(Color.Black, 2f);
			FontesTabela fonte2;
			fonte2.Titulo = font2;
			fonte2.Variavel = font3;
			fonte2.Valor = font3;
			CoresTabela cores;
			cores.Titulo = Brushes.Black;
			cores.Variavel = Brushes.Blue;
			cores.Valor = Brushes.DarkBlue;
			cores.Tabela = Color.Black;
			cores.TituloBG = Color.AliceBlue;
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_830_200_variaveis_X.RT_830_200_BD.firmware.Equip.Valor, RT_830_200_variaveis_X.RT_830_200_BD.firmware.Versao.Valor);
			string text = "End.";
			string text2 = "Nome";
			string text3 = "Escala1";
			string text4 = "Escala2";
			string text5 = "Escala3";
			string text6 = "Escala4";
			string text7 = "Escala5";
			string text8 = "Escala6";
			string text9 = "Escala7";
			string text10 = "Escala8";
			string text11 = "Escala9";
			string text12 = "Escala10";
			string text13 = "Escala11";
			string text14 = "Escala12";
			string text15 = "Escala13";
			string text16 = "Escala14";
			string text17 = "Escala15";
			string text18 = "Escala16";
			int[] array = new int[]
			{
				0,
				35,
				80,
				130,
				180,
				230,
				280,
				330,
				380,
				430,
				480,
				530,
				590,
				650,
				710,
				770,
				830,
				890
			};
			string[] titulos = new string[]
			{
				text,
				text2,
				text3,
				text4,
				text5,
				text6,
				text7,
				text8,
				text9,
				text10,
				text11,
				text12,
				text13,
				text14,
				text15,
				text16,
				text17,
				text18
			};
			int valor = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques.Valor;
			checked
			{
				TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, valor + 1, "Remotas de Controle - Continuação", true);
				TabelaLinhaInteria tabelaLinhaInteria2 = tabelaLinhaInteria;
				int num = (HorizontalAlignment)1;
				tabelaLinhaInteria2.EscreveTodosTitulos(ref num, titulos, array);
				int num2 = (HorizontalAlignment)0;
				int num3 = valor - 1;
				for (int i = num2; i <= num3; i++)
				{
					string valor2 = string.Format("{0:D2}", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_recalque.Valor + i);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, valor2, array[0] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome.Valor.ToString(), array[1] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala1.Valor.ToString(), array[2] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala2.Valor.ToString(), array[3] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala3.Valor.ToString(), array[4] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala4.Valor.ToString(), array[5] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala5.Valor.ToString(), array[6] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala6.Valor.ToString(), array[7] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala7.Valor.ToString(), array[8] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala8.Valor.ToString(), array[9] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala9.Valor.ToString(), array[10] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala10.Valor.ToString(), array[11] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala11.Valor.ToString(), array[12] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala12.Valor.ToString(), array[13] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala13.Valor.ToString(), array[14] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala14.Valor.ToString(), array[15] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala15.Valor.ToString(), array[16] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala16.Valor.ToString(), array[17] + 10);
				}
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, RT_830_200_impressao_X.pagina_impressao);
				RT_830_200_impressao_X.grupo_impressao++;
				RT_830_200_impressao_X.pagina_impressao++;
				return true;
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00223BEC File Offset: 0x00221FEC
		public static bool DesenhaRelatorioRT830Grupo5(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, 3);
			Font font2 = new Font("Calibri", 10f, 3, (FontStyle)3);
			Font font3 = new Font("Calibri", 10f, 0, (FontStyle)3);
			Font fonte = new Font("Calibri", 20f, 1, (FontStyle)3);
			Font font4 = new Font("Times New Roman", 14f, 0, (FontStyle)3);
			Font font5 = new Font("Times New Roman", 14f, 0, (FontStyle)3);
			Pen pen = new Pen(Color.Black, 2f);
			FontesTabela fonte2;
			fonte2.Titulo = font2;
			fonte2.Variavel = font3;
			fonte2.Valor = font3;
			CoresTabela cores;
			cores.Titulo = Brushes.Black;
			cores.Variavel = Brushes.Blue;
			cores.Valor = Brushes.DarkBlue;
			cores.Tabela = Color.Black;
			cores.TituloBG = Color.AliceBlue;
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_830_200_variaveis_X.RT_830_200_BD.firmware.Equip.Valor, RT_830_200_variaveis_X.RT_830_200_BD.firmware.Versao.Valor);
			string text = "End.";
			string text2 = "Nº Reservatórios";
			string text3 = "Nº Recalques";
			string text4 = "Prioridade";
			string text5 = "Relação de Reservatórios";
			string text6 = "Relação de Recalques";
			int[] array = new int[]
			{
				0,
				35,
				150,
				250
			};
			string[] titulos = new string[]
			{
				text,
				text2,
				text3,
				text4
			};
			int valor = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor;
			checked
			{
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 5, valor + 1, "Equipamento Vista", true);
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = tabelaMeiaLinhaEsquerda;
				int num = (HorizontalAlignment)1;
				tabelaMeiaLinhaEsquerda2.EscreveTodosTitulos(ref num, titulos, array);
				int num2 = (HorizontalAlignment)0;
				int num3 = valor - 1;
				for (int i = num2; i <= num3; i++)
				{
					string text7 = string.Format("{0:D2}", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista.Valor + i);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(i + 2, text7, array[0] + 5);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_Variaveis.Valor.ToString(), array[1] + 5);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_RemotasControles.Valor.ToString(), array[2] + 5);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(i + 2, RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Prioridade.Valor.ToString(), array[3] + 5);
				}
				int nextLineAvailable = tabelaMeiaLinhaEsquerda.GetNextLineAvailable();
				int[] posicoes = new int[]
				{
					0,
					35
				};
				string[] titulos2 = new string[]
				{
					text,
					text5
				};
				valor = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor;
				TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, valor + 1, "Equipamentos de Reservatório", true);
				TabelaLinhaInteria tabelaLinhaInteria2 = tabelaLinhaInteria;
				num = (HorizontalAlignment)1;
				tabelaLinhaInteria2.EscreveTodosTitulos(ref num, titulos2, posicoes);
				int num4 = (HorizontalAlignment)0;
				int num5 = valor - 1;
				for (int i = num4; i <= num5; i++)
				{
					string text7 = string.Format("{0:D2}", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista.Valor + i);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, text7, array[0] + 5);
					text7 = "";
					int num6 = (HorizontalAlignment)0;
					int num7 = RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_Variaveis.Valor - 1;
					for (int j = num6; j <= num7; j++)
					{
						text7 = text7 + RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Variaveis[j].Valor.ToString() + ", ";
					}
					text7 = text7.Substring(0, text7.Length - 2);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, text7, array[1] + 5);
				}
				nextLineAvailable = tabelaLinhaInteria.GetNextLineAvailable();
				int[] posicoes2 = new int[]
				{
					0,
					35
				};
				string[] titulos3 = new string[]
				{
					text,
					text6
				};
				valor = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor;
				TabelaLinhaInteria tabelaLinhaInteria3 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, valor + 1, "Equipamentos de Recalque", true);
				TabelaLinhaInteria tabelaLinhaInteria4 = tabelaLinhaInteria3;
				num = (HorizontalAlignment)1;
				tabelaLinhaInteria4.EscreveTodosTitulos(ref num, titulos3, posicoes2);
				int num8 = (HorizontalAlignment)0;
				int num9 = valor - 1;
				for (int i = num8; i <= num9; i++)
				{
					string text7 = string.Format("{0:D2}", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista.Valor + i);
					tabelaLinhaInteria3.EscreveValorLinha(i + 2, text7, array[0] + 5);
					text7 = "";
					int num10 = (HorizontalAlignment)0;
					int num11 = RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_RemotasControles.Valor - 1;
					for (int j = num10; j <= num11; j++)
					{
						text7 = text7 + RT_830_200_variaveis_X.RT_830_200_BD.vista[i].RemotasControles[j].Valor.ToString() + ", ";
					}
					text7 = text7.Substring(0, text7.Length - 2);
					tabelaLinhaInteria3.EscreveValorLinha(i + 2, text7, array[1] + 5);
				}
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, RT_830_200_impressao_X.pagina_impressao);
				RT_830_200_impressao_X.grupo_impressao++;
				RT_830_200_impressao_X.pagina_impressao++;
				return false;
			}
		}

		// Token: 0x04000366 RID: 870
		public static int pagina_impressao;

		// Token: 0x04000367 RID: 871
		public static int grupo_impressao;

		// Token: 0x04000368 RID: 872
		public static int quantos_imprimiu;

		// Token: 0x04000369 RID: 873
		public static int quantos_imprimiu2;

		// Token: 0x0400036A RID: 874
		public static int quantos_imprimiu3;

		// Token: 0x0400036B RID: 875
		public static int quantos_imprimiu4;

		// Token: 0x0400036C RID: 876
		public static int inicio;
	}
}
