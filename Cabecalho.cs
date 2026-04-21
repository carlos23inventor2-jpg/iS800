using System.Windows.Forms;
using System;
using System.Drawing;
using iS800.My.Resources;

namespace iS800
{
	// Token: 0x0200004C RID: 76
	public class Cabecalho
	{
		// Token: 0x0600120B RID: 4619 RVA: 0x00251488 File Offset: 0x0024F888
		public Cabecalho(Rectangle Margin, Graphics Graph, Font Fonte, Brush Cor, int Equipamento, int Versao)
		{
			Pen pen = new Pen(Color.Black, 2f);
			StringFormat stringFormat = new StringFormat();
			SizeF sizeF = default(SizeF);
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
			else if (num == 824 || num == 828 || num == 920)
			{
				Equipamento = 800;
			}
			string text2 = string.Concat(new string[]
			{
				"Ficha de Configuração ",
				text,
				Equipamento.ToString(),
				" ",
				(checked(100 * Versao)).ToString()
			});
			sizeF = Graph.MeasureString(text2, Fonte);
			Graph.DrawImage(logo_vortice_pp, Margin.Left, 20);
			Graph.DrawString(text2, Fonte, Cor, (float)Margin.Right - sizeF.Width, 30f);
			Graph.DrawLine(pen, Margin.Left, 70, Margin.Right, 70);
		}
	}
}
