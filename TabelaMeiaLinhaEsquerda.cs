using System;
using System.Drawing;

namespace iS800
{
	// Token: 0x0200004F RID: 79
	public class TabelaMeiaLinhaEsquerda
	{
		// Token: 0x06001213 RID: 4627 RVA: 0x00251B98 File Offset: 0x0024FF98
		public TabelaMeiaLinhaEsquerda(Rectangle Margin, Graphics Graph, FontesTabela Fonte, CoresTabela Cores, int LinhaInicial, int NumeroLinhas, string Titulo, bool Grid)
		{
			Pen pen = new Pen(Cores.Tabela, 1f);
			SolidBrush solidBrush = new SolidBrush(Cores.TituloBG);
			StringFormat stringFormat = new StringFormat();
			stringFormat.LineAlignment = (System.Drawing.StringAlignment)1;
			stringFormat.Alignment = (System.Drawing.StringAlignment)1;
			checked
			{
				this.AlturaFonte = (int)Math.Round((double)(unchecked(Fonte.Titulo.GetHeight() + 2f)));
				this.pLinhaInical = LinhaInicial;
				this.pNumeroLinhas = NumeroLinhas;
				this.MargemEsquerda = (float)Margin.Left;
				this.MargemSuperior = (float)(Margin.Top + 100);
				this.MargemDireita = (float)Margin.Right;
				this.MargemInferior = (float)Margin.Bottom;
			}
			this.CentroLinha = this.MargemEsquerda + (this.MargemDireita - this.MargemEsquerda) / 2f;
			this.FT = Fonte.Titulo;
			this.FVAR = Fonte.Variavel;
			this.FVAL = Fonte.Valor;
			this.CT = Cores.Titulo;
			this.CVAR = Cores.Variavel;
			this.CVAL = Cores.Valor;
			this.G = Graph;
			this.G.FillRectangle(solidBrush, this.MargemEsquerda, (float)(checked(LinhaInicial * this.AlturaFonte)), this.CentroLinha - this.MargemEsquerda - 20f, (float)this.AlturaFonte);
			this.G.DrawRectangle(pen, this.MargemEsquerda, (float)(checked(LinhaInicial * this.AlturaFonte)), this.CentroLinha - this.MargemEsquerda - 20f, (float)this.AlturaFonte);
			this.G.DrawString(Titulo, this.FT, this.CT, this.MargemEsquerda + (this.CentroLinha - this.MargemEsquerda - 20f) / 2f, (float)((double)(checked(LinhaInicial * this.AlturaFonte)) + 0.5 * (double)this.AlturaFonte), stringFormat);
			checked
			{
				if (Grid)
				{
					for (int i = 1; i <= NumeroLinhas; i++)
					{
						this.G.DrawRectangle(pen, this.MargemEsquerda, (float)(LinhaInicial * this.AlturaFonte + i * this.AlturaFonte), unchecked(this.CentroLinha - this.MargemEsquerda - 20f), (float)this.AlturaFonte);
					}
				}
				else
				{
					this.G.DrawRectangle(pen, this.MargemEsquerda, (float)(LinhaInicial * this.AlturaFonte), unchecked(this.CentroLinha - this.MargemEsquerda - 20f), (float)((NumeroLinhas + 1) * this.AlturaFonte));
				}
			}
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00251E14 File Offset: 0x00250214
		public void EscreveTituloLinha(int linha, string Titulo, int offset_titulo)
		{
			if (linha >= 1 & linha <= this.pNumeroLinhas)
			{
				this.G.DrawString(Titulo + ":", this.FVAR, this.CVAR, this.MargemEsquerda + 5f + (float)offset_titulo, (float)(checked((this.pLinhaInical + linha) * this.AlturaFonte)));
			}
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x00251E78 File Offset: 0x00250278
		public void EscreveValorLinha(int linha, string Valor, int offset_valor)
		{
			if (linha >= 1 & linha <= this.pNumeroLinhas)
			{
				this.G.DrawString(Valor, this.FVAL, this.CVAL, this.MargemEsquerda + (float)offset_valor, (float)(checked((this.pLinhaInical + linha) * this.AlturaFonte)));
			}
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00251ECC File Offset: 0x002502CC
		public void EscreveTituloValorLinha(int linha, string Titulo, string Valor, int offset_titulo, int offset_valor)
		{
			SizeF sizeF = default(SizeF);
			string text = Titulo + ":";
			sizeF = this.G.MeasureString(text + ":", this.FVAR);
			if (linha >= 1 & linha <= this.pNumeroLinhas)
			{
				this.G.DrawString(text, this.FVAR, this.CVAR, this.MargemEsquerda + (float)offset_titulo, (float)(checked((this.pLinhaInical + linha) * this.AlturaFonte)));
				this.G.DrawString(" " + Valor, this.FVAL, this.CVAL, this.MargemEsquerda + (float)offset_titulo + sizeF.Width, (float)(checked((this.pLinhaInical + linha) * this.AlturaFonte)));
			}
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00251F98 File Offset: 0x00250398
		public int GetNextLineAvailable()
		{
			return checked(this.pLinhaInical + this.pNumeroLinhas + 2);
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00251FB4 File Offset: 0x002503B4
		public void EscreveTodosTitulos(ref int linha, string[] titulos, int[] posicoes)
		{
			int num = 0;
			checked
			{
				int num2 = posicoes.Length - 1;
				for (int i = num; i <= num2; i++)
				{
					this.EscreveTituloLinha(linha, titulos[i], posicoes[i]);
				}
			}
		}

		// Token: 0x04000A22 RID: 2594
		private int AlturaFonte;

		// Token: 0x04000A23 RID: 2595
		private int pLinhaInical;

		// Token: 0x04000A24 RID: 2596
		private int pNumeroLinhas;

		// Token: 0x04000A25 RID: 2597
		private float MargemEsquerda;

		// Token: 0x04000A26 RID: 2598
		private float MargemDireita;

		// Token: 0x04000A27 RID: 2599
		private float MargemInferior;

		// Token: 0x04000A28 RID: 2600
		private float MargemSuperior;

		// Token: 0x04000A29 RID: 2601
		private float CentroLinha;

		// Token: 0x04000A2A RID: 2602
		private Font FT;

		// Token: 0x04000A2B RID: 2603
		private Font FVAR;

		// Token: 0x04000A2C RID: 2604
		private Font FVAL;

		// Token: 0x04000A2D RID: 2605
		private Brush CT;

		// Token: 0x04000A2E RID: 2606
		private Brush CVAR;

		// Token: 0x04000A2F RID: 2607
		private Brush CVAL;

		// Token: 0x04000A30 RID: 2608
		private Graphics G;
	}
}
