using System;
using System.Drawing;
using System.Drawing.Printing;
using iS800.My;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x02000027 RID: 39
	[StandardModule]
	internal sealed class RT_831_200_impressao_X
	{
		// Token: 0x06000406 RID: 1030 RVA: 0x00227E84 File Offset: 0x00226284
		public static void Impressao_BeginPrint_RT831()
		{
			RT_831_200_impressao_X.pagina_impressao = 1;
			RT_831_200_impressao_X.grupo_impressao = 1;
			RT_831_200_impressao_X.quantos_imprimiu = 0;
			RT_831_200_impressao_X.quantos_imprimiu2 = 0;
			RT_831_200_impressao_X.quantos_imprimiu3 = 0;
			RT_831_200_impressao_X.quantos_imprimiu4 = 0;
			RT_831_200_impressao_X.inicio = 5;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00227EB0 File Offset: 0x002262B0
		public static bool DesenhaRelatorio_RT831(PrintPageEventArgs z)
		{
			bool result;
			switch (RT_831_200_impressao_X.grupo_impressao)
			{
			case 1:
				result = RT_831_200_impressao_X.DesenhaRelatorioRT831Grupo1(z);
				break;
			case 2:
				result = RT_831_200_impressao_X.DesenhaRelatorioRT831Grupo2(z);
				break;
			case 3:
				result = RT_831_200_impressao_X.DesenhaRelatorioRT831Grupo3(z);
				break;
			}
			return result;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00227EF4 File Offset: 0x002262F4
		public static bool DesenhaRelatorioRT831Grupo1(PrintPageEventArgs z)
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.Valor, RT_831_200_variaveis_X.RT_831_200_BD.firmware.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 3, "Dados da Estação", true);
			tabelaLinhaInteria.EscreveTituloValorLinha(1, "Local de Instalação", MyProject.Forms.RT_831_200_configurador.TextBox_nome_RT850.Text, 0, 160);
			tabelaLinhaInteria.EscreveTituloValorLinha(1, "Data", string.Concat(new string[]
			{
				DateTime.Today.Day.ToString(),
				"/",
				DateTime.Today.Month.ToString(),
				"/",
				DateTime.Today.Year.ToString()
			}), 450, 530);
			tabelaLinhaInteria.EscreveTituloValorLinha(2, "Endereço", MyProject.Forms.RT_831_200_configurador.TextBox_endereco_RT850.Text, 0, 90);
			string valor = string.Concat(new string[]
			{
				"RT",
				RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.Valor.ToString(),
				"_",
				RT_831_200_variaveis_X.RT_831_200_BD.firmware.Versao.Valor.ToString(),
				string.Format("{0:D2}", RT_831_200_variaveis_X.RT_831_200_BD.firmware.Build.Valor),
				"  R",
				RT_831_200_variaveis_X.RT_831_200_BD.firmware.Release.Valor.ToString()
			});
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Firmware", valor, 350, 430);
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Configurador", "iS800", 0, 160);
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 15, 5, "Dados de Instalação", true);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(1, "Tipo de antena", MyProject.Forms.RT_831_200_configurador.CB_TipoAntena1.Text, 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(1, "Azimute", MyProject.Forms.RT_831_200_configurador.T_Azimute1.Text + " °", 280, 500);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(2, "Polarização", MyProject.Forms.RT_831_200_configurador.CB_PolarizacaoAntena1.Text, 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(2, "Longitude", MyProject.Forms.RT_831_200_configurador.T_Longitude1.Text, 280, 500);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(3, "Potência do Rádio", MyProject.Forms.RT_831_200_configurador.T_PotRadio1.Text + " W", 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(3, "Latidude", MyProject.Forms.RT_831_200_configurador.T_Latitude1.Text, 280, 500);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(4, "Modelo do Rádio", MyProject.Forms.RT_831_200_configurador.CB_ModeloRadio1.Text, 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(4, "Altura", MyProject.Forms.RT_831_200_configurador.T_AlturaAntena1.Text + " m", 280, 500);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(5, "Frequência do Rádio", MyProject.Forms.RT_831_200_configurador.T_FreqRadio1.Text + " MHz", 0, 150);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, 15, 4, "Canal de Rádio", true);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(1, "Endereço Mestre", RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre.Valor.ToString(), 0, 0);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(2, "Endereço EStação", RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor.ToString(), 0, 0);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(3, "Baud Rate", RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.GetItem(), 0, 0);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(4, "Tempo de PTT (ms)", RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT.Valor.ToString(), 0, 0);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita2 = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, 25, 1, "Senha", true);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(1, "Senha", RT_831_200_variaveis_X.RT_831_200_BD.senha.senha.Valor.ToString(), 0, 0);
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 25, 2, "Lista de Equipamentos", true);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(1, "Número de Reservatórios", RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor.ToString(), 0, 0);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(2, "Número de Recalques", RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor.ToString(), 0, 0);
			RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, RT_831_200_impressao_X.pagina_impressao);
			checked
			{
				RT_831_200_impressao_X.grupo_impressao++;
				RT_831_200_impressao_X.pagina_impressao++;
				return true;
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00228538 File Offset: 0x00226938
		public static bool DesenhaRelatorioRT831Grupo2(PrintPageEventArgs z)
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.Valor, RT_831_200_variaveis_X.RT_831_200_BD.firmware.Versao.Valor);
			string text = "Posição";
			string text2 = "Nome";
			int[] array = new int[]
			{
				0,
				80
			};
			string[] titulos = new string[]
			{
				text,
				text2
			};
			int num = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor;
			if (num > 30)
			{
				num = 30;
			}
			checked
			{
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 5, num + 1, "Variáveis", true);
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = tabelaMeiaLinhaEsquerda;
				int num2 = 1;
				tabelaMeiaLinhaEsquerda2.EscreveTodosTitulos(ref num2, titulos, array);
				int num3 = 0;
				int num4 = num - 1;
				for (int i = num3; i <= num4; i++)
				{
					string valor = string.Format("{0:D2}", 1 + i);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(i + 2, valor, array[0] + 5);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(i + 2, RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[i].Nome.Valor.ToString(), array[1] + 10);
				}
				num = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor - 30;
				if (num > 0)
				{
					TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, 5, num + 1, "Variáveis Continuação", true);
					TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita2 = tabelaMeiaLinhaDireita;
					num2 = 1;
					tabelaMeiaLinhaDireita2.EscreveTodosTitulos(ref num2, titulos, array);
					int num5 = 0;
					int num6 = num - 1;
					for (int i = num5; i <= num6; i++)
					{
						string valor = string.Format("{0:D2}", 1 + i + 30);
						tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, valor, array[0]);
						tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[i + 30].Nome.Valor.ToString(), array[1] + 5);
					}
				}
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, RT_831_200_impressao_X.pagina_impressao);
				RT_831_200_impressao_X.grupo_impressao++;
				RT_831_200_impressao_X.pagina_impressao++;
				return true;
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00228848 File Offset: 0x00226C48
		public static bool DesenhaRelatorioRT831Grupo30(PrintPageEventArgs z)
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.Valor, RT_831_200_variaveis_X.RT_831_200_BD.firmware.Versao.Valor);
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
			int valor = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor;
			checked
			{
				TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, valor + 1, "Remotas de Controle", true);
				TabelaLinhaInteria tabelaLinhaInteria2 = tabelaLinhaInteria;
				int num = 1;
				tabelaLinhaInteria2.EscreveTodosTitulos(ref num, titulos, array);
				int num2 = 0;
				int num3 = valor - 1;
				for (int i = num2; i <= num3; i++)
				{
					string valor2 = string.Format("{0:D2}", 1 + i);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, valor2, array[0] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Nome.Valor.ToString(), array[1] + 10);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Modelo.GetItem(), array[4] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Habilita.GetItem(), array[14] + 10);
				}
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, RT_831_200_impressao_X.pagina_impressao);
				RT_831_200_impressao_X.grupo_impressao++;
				RT_831_200_impressao_X.pagina_impressao++;
				return true;
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00228C1C File Offset: 0x0022701C
		public static bool DesenhaRelatorioRT831Grupo3(PrintPageEventArgs z)
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.Valor, RT_831_200_variaveis_X.RT_831_200_BD.firmware.Versao.Valor);
			string text = "Posi\r\nção";
			string text2 = "\r\nNome";
			string text3 = "\r\nModelo";
			string text4 = "Habi\r\nlitado";
			string text5 = "Escala\r\n1";
			string text6 = "Escala\r\n2";
			string text7 = "Escala\r\n3";
			string text8 = "Escala\r\n4";
			string text9 = "Escala\r\n5";
			string text10 = "Escala\r\n6";
			string text11 = "Escala\r\n7";
			string text12 = "Escala\r\n8";
			string text13 = "Escala\r\n9";
			string text14 = "Escala\r\n10";
			string text15 = "Escala\r\n11";
			string text16 = "Escala\r\n12";
			string text17 = "Escala\r\n13";
			string text18 = "Escala\r\n14";
			string text19 = "Escala\r\n15";
			string text20 = "Escala\r\n16";
			int[] array = new int[]
			{
				0,
				30,
				65,
				130,
				170,
				220,
				270,
				320,
				370,
				420,
				470,
				520,
				570,
				620,
				670,
				720,
				770,
				820,
				870,
				920
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
				text18,
				text19,
				text20
			};
			int valor = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor;
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 2, "Remotas de Controle", false);
			TabelaLinhaInteria tabelaLinhaInteria2 = tabelaLinhaInteria;
			int num = 1;
			tabelaLinhaInteria2.EscreveTodosTitulos(ref num, titulos, array);
			int num2 = 0;
			checked
			{
				int num3 = valor - 1;
				for (int i = num2; i <= num3; i++)
				{
					tabelaLinhaInteria.AdicionaLinha();
					string valor2 = string.Format("{0:D2}", 1 + i);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, valor2, array[0] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Nome.Valor.ToString(), array[1]);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Modelo.GetItem(), array[2]);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Habilita.GetItem().Substring(0, 5), array[3] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala1.Valor.ToString(), array[4] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala2.Valor.ToString(), array[5] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala3.Valor.ToString(), array[6] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala4.Valor.ToString(), array[7] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala5.Valor.ToString(), array[8] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala6.Valor.ToString(), array[9] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala7.Valor.ToString(), array[10] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala8.Valor.ToString(), array[11] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala9.Valor.ToString(), array[12] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala10.Valor.ToString(), array[13] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala11.Valor.ToString(), array[14] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala12.Valor.ToString(), array[15] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala13.Valor.ToString(), array[16] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala14.Valor.ToString(), array[17] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala15.Valor.ToString(), array[18] + 5);
					tabelaLinhaInteria.EscreveValorLinha(i + 3, RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala16.Valor.ToString(), array[19] + 5);
				}
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, RT_831_200_impressao_X.pagina_impressao);
				RT_831_200_impressao_X.grupo_impressao++;
				RT_831_200_impressao_X.pagina_impressao++;
				return false;
			}
		}

		// Token: 0x0400045D RID: 1117
		public static int pagina_impressao;

		// Token: 0x0400045E RID: 1118
		public static int grupo_impressao;

		// Token: 0x0400045F RID: 1119
		public static int quantos_imprimiu;

		// Token: 0x04000460 RID: 1120
		public static int quantos_imprimiu2;

		// Token: 0x04000461 RID: 1121
		public static int quantos_imprimiu3;

		// Token: 0x04000462 RID: 1122
		public static int quantos_imprimiu4;

		// Token: 0x04000463 RID: 1123
		public static int inicio;
	}
}
