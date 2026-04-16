using System;
using System.Drawing;

namespace iS800
{
	// Token: 0x0200004D RID: 77
	public class RodapeICTEL
	{
		// Token: 0x0600120C RID: 4620 RVA: 0x002515F0 File Offset: 0x0024F9F0
		public RodapeICTEL(Rectangle Margin, Graphics Graph, Font Fonte, Brush Cor, int pagina)
		{
			Pen pen = new Pen(Color.Black, 2f);
			StringFormat stringFormat = new StringFormat();
			SizeF sizeF = default(SizeF);
			string text = "Página " + pagina.ToString();
			Graph.DrawLine(pen, Margin.Left, Margin.Bottom, Margin.Right, Margin.Bottom);
			checked
			{
				Graph.DrawString("VÓRTICE - Sistemas de Automação LTDA. ", Fonte, Cor, (float)Margin.Left, (float)(Margin.Bottom + Fonte.Height + 2));
				sizeF = Graph.MeasureString(text, Fonte);
				Graph.DrawString(text, Fonte, Cor, unchecked((float)Margin.Right - sizeF.Width), (float)(Margin.Bottom + Fonte.Height + 2));
				Graph.DrawString("Av General Flores da Cunha 1891, cj 308. Cachoeirinha - RS - CEP 94910-003", Fonte, Cor, (float)Margin.Left, (float)(Margin.Bottom + 2 * Fonte.Height + 4));
				Graph.DrawString("Fone: (0xx 51) 3041-1600 3041-1700     www.vortice.ind.br", Fonte, Cor, (float)Margin.Left, (float)(Margin.Bottom + 3 * Fonte.Height + 6));
			}
		}
	}
}
