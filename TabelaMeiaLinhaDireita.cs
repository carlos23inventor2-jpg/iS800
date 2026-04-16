using System;
using System.Drawing;

namespace iS800
{
	// Token: 0x0200004E RID: 78
	public class TabelaMeiaLinhaDireita
	{
		// Token: 0x0600120D RID: 4621 RVA: 0x00251704 File Offset: 0x0024FB04
		public TabelaMeiaLinhaDireita(Rectangle Margin, Graphics Graph, FontesTabela Fonte, CoresTabela Cores, int LinhaInicial, int NumeroLinhas, string Titulo, bool Grid)
		{
			Pen pen = new Pen(Cores.Tabela, 1f);
			SolidBrush solidBrush = new SolidBrush(Cores.TituloBG);
			StringFormat stringFormat = new StringFormat();
			stringFormat.LineAlignment = StringAlignment.Center;
			stringFormat.Alignment = StringAlignment.Center;
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
			this.G.FillRectangle(solidBrush, this.CentroLinha + 20f, (float)(checked(LinhaInicial * this.AlturaFonte)), this.MargemDireita - this.CentroLinha - 20f, (float)this.AlturaFonte);
			this.G.DrawRectangle(pen, this.CentroLinha + 20f, (float)(checked(LinhaInicial * this.AlturaFonte)), this.MargemDireita - this.CentroLinha - 20f, (float)this.AlturaFonte);
			this.G.DrawString(Titulo, this.FT, this.CT, this.MargemDireita - (this.MargemDireita - this.CentroLinha - 20f) / 2f, (float)((double)(checked(LinhaInicial * this.AlturaFonte)) + 0.5 * (double)this.AlturaFonte), stringFormat);
			checked
			{
				if (Grid)
				{
					for (int i = 1; i <= NumeroLinhas; i++)
					{
						this.G.DrawRectangle(pen, unchecked(this.CentroLinha + 20f), (float)(LinhaInicial * this.AlturaFonte + i * this.AlturaFonte), unchecked(this.MargemDireita - this.CentroLinha - 20f), (float)this.AlturaFonte);
					}
				}
				else
				{
					this.G.DrawRectangle(pen, unchecked(this.CentroLinha + 20f), (float)(LinhaInicial * this.AlturaFonte), unchecked(this.MargemDireita - this.CentroLinha - 20f), (float)((NumeroLinhas + 1) * this.AlturaFonte));
				}
			}
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x00251998 File Offset: 0x0024FD98
		public void EscreveTituloLinha(int linha, string Titulo, int offset_titulo)
		{
			if (linha >= 1 & linha <= this.pNumeroLinhas)
			{
				this.G.DrawString(Titulo + ":", this.FVAR, this.CVAR, this.CentroLinha + 20f + 5f + (float)offset_titulo, (float)(checked((this.pLinhaInical + linha) * this.AlturaFonte)));
			}
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x00251A04 File Offset: 0x0024FE04
		public void EscreveValorLinha(int linha, string Valor, int offset_valor)
		{
			if (linha >= 1 & linha <= this.pNumeroLinhas)
			{
				this.G.DrawString(Valor, this.FVAL, this.CVAL, this.CentroLinha + 20f + 5f + (float)offset_valor, (float)(checked((this.pLinhaInical + linha) * this.AlturaFonte)));
			}
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x00251A64 File Offset: 0x0024FE64
		public void EscreveTituloValorLinha(int linha, string Titulo, string Valor, int offset_titulo, int offset_valor)
		{
			SizeF sizeF = default(SizeF);
			string text = Titulo + ":";
			sizeF = this.G.MeasureString(text + ":", this.FVAR);
			if (linha >= 1 & linha <= this.pNumeroLinhas)
			{
				this.G.DrawString(text, this.FVAR, this.CVAR, this.CentroLinha + 20f + 5f + (float)offset_titulo, (float)(checked((this.pLinhaInical + linha) * this.AlturaFonte)));
				this.G.DrawString(" " + Valor, this.FVAL, this.CVAL, this.CentroLinha + 20f + 5f + (float)offset_titulo + sizeF.Width, (float)(checked((this.pLinhaInical + linha) * this.AlturaFonte)));
			}
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x00251B4C File Offset: 0x0024FF4C
		public int GetNextLineAvailable()
		{
			return checked(this.pLinhaInical + this.pNumeroLinhas + 2);
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00251B68 File Offset: 0x0024FF68
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

		// Token: 0x04000A13 RID: 2579
		private int AlturaFonte;

		// Token: 0x04000A14 RID: 2580
		private int pLinhaInical;

		// Token: 0x04000A15 RID: 2581
		private int pNumeroLinhas;

		// Token: 0x04000A16 RID: 2582
		private float MargemEsquerda;

		// Token: 0x04000A17 RID: 2583
		private float MargemDireita;

		// Token: 0x04000A18 RID: 2584
		private float MargemInferior;

		// Token: 0x04000A19 RID: 2585
		private float MargemSuperior;

		// Token: 0x04000A1A RID: 2586
		private float CentroLinha;

		// Token: 0x04000A1B RID: 2587
		private Font FT;

		// Token: 0x04000A1C RID: 2588
		private Font FVAR;

		// Token: 0x04000A1D RID: 2589
		private Font FVAL;

		// Token: 0x04000A1E RID: 2590
		private Brush CT;

		// Token: 0x04000A1F RID: 2591
		private Brush CVAR;

		// Token: 0x04000A20 RID: 2592
		private Brush CVAL;

		// Token: 0x04000A21 RID: 2593
		private Graphics G;
	}
}
