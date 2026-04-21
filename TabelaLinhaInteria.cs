using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x02000050 RID: 80
	public class TabelaLinhaInteria
	{
		// Token: 0x06001219 RID: 4633 RVA: 0x00251FE4 File Offset: 0x002503E4
		public TabelaLinhaInteria(Rectangle Margin, Graphics Graph, FontesTabela Fonte, CoresTabela Cores, int LinhaInicial, int NumeroLinhas, string Titulo, string TitlePos, bool Grid)
		{
			this.Construtora(Margin, Graph, Fonte, Cores, LinhaInicial, NumeroLinhas, Titulo, TitlePos, Grid);
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0025200C File Offset: 0x0025040C
		public TabelaLinhaInteria(Rectangle Margin, Graphics Graph, FontesTabela Fonte, CoresTabela Cores, int LinhaInicial, int NumeroLinhas, string Titulo, bool Grid)
		{
			this.Construtora(Margin, Graph, Fonte, Cores, LinhaInicial, NumeroLinhas, Titulo, "C", Grid);
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x00252038 File Offset: 0x00250438
		private void Construtora(Rectangle Margin, Graphics Graph, FontesTabela Fonte, CoresTabela Cores, int LinhaInicial, int NumeroLinhas, string Titulo, string TitlePos, bool Grid)
		{
			StringFormat stringFormat = new StringFormat();
			Pen pen = new Pen(Cores.Tabela, 1f);
			SolidBrush solidBrush = new SolidBrush(Cores.TituloBG);
			stringFormat.LineAlignment = (System.Drawing.StringAlignment)1;
			if (Operators.CompareString(TitlePos, "L", false) == 0)
			{
				stringFormat.Alignment = (System.Drawing.StringAlignment)0;
			}
			else if (Operators.CompareString(TitlePos, "R", false) == 0)
			{
				stringFormat.Alignment = (System.Drawing.StringAlignment)2;
			}
			else if (Operators.CompareString(TitlePos, "C", false) == 0)
			{
				stringFormat.Alignment = (System.Drawing.StringAlignment)1;
			}
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
			this.CTAB = Cores.Tabela;
			this.G = Graph;
			this.G.FillRectangle(solidBrush, this.MargemEsquerda, (float)(checked(LinhaInicial * this.AlturaFonte)), this.MargemDireita - this.MargemEsquerda, (float)this.AlturaFonte);
			this.G.DrawRectangle(pen, this.MargemEsquerda, (float)(checked(LinhaInicial * this.AlturaFonte)), this.MargemDireita - this.MargemEsquerda, (float)this.AlturaFonte);
			if (Operators.CompareString(TitlePos, "L", false) == 0)
			{
				this.G.DrawString(Titulo, this.FT, this.CT, this.MargemEsquerda + 5f, (float)((double)(checked(LinhaInicial * this.AlturaFonte)) + 0.5 * (double)this.AlturaFonte), stringFormat);
			}
			else if (Operators.CompareString(TitlePos, "R", false) == 0)
			{
				SizeF sizeF = default(SizeF);
				sizeF = this.G.MeasureString(Titulo, this.FVAR);
				this.G.DrawString(Titulo, this.FT, this.CT, this.MargemDireita - 5f - sizeF.Width, (float)((double)(checked(LinhaInicial * this.AlturaFonte)) + 0.5 * (double)this.AlturaFonte), stringFormat);
			}
			else if (Operators.CompareString(TitlePos, "C", false) == 0)
			{
				this.G.DrawString(Titulo, this.FT, this.CT, this.CentroLinha, (float)((double)(checked(LinhaInicial * this.AlturaFonte)) + 0.5 * (double)this.AlturaFonte), stringFormat);
			}
			checked
			{
				if (Grid)
				{
					for (int i = 1; i <= NumeroLinhas; i++)
					{
						this.G.DrawRectangle(pen, this.MargemEsquerda, (float)(LinhaInicial * this.AlturaFonte + i * this.AlturaFonte), unchecked(this.MargemDireita - this.MargemEsquerda), (float)this.AlturaFonte);
					}
				}
				else
				{
					this.G.DrawRectangle(pen, this.MargemEsquerda, (float)(LinhaInicial * this.AlturaFonte), unchecked(this.MargemDireita - this.MargemEsquerda), (float)((NumeroLinhas + 1) * this.AlturaFonte));
				}
			}
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x002523B4 File Offset: 0x002507B4
		public void EscreveTodosTitulos(ref int linha, string[] titulos, int[] posicoes)
		{
			this.Pos = posicoes;
			int num = 0;
			checked
			{
				int num2 = this.Pos.Length - 1;
				for (int i = num; i <= num2; i++)
				{
					this.EscreveTituloLinha(linha, titulos[i], this.Pos[i]);
				}
			}
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x002523F4 File Offset: 0x002507F4
		public void EscreveTituloLinha(int linha, string Titulo, int offset_titulo)
		{
			if (linha >= 0 & linha <= this.pNumeroLinhas)
			{
				this.G.DrawString(Titulo + ":", this.FVAR, this.CVAR, this.MargemEsquerda + 5f + (float)offset_titulo, (float)(checked((this.pLinhaInical + linha) * this.AlturaFonte)));
			}
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00252458 File Offset: 0x00250858
		public void EscreveValorLinha(int linha, string Valor, int offset_valor)
		{
			if (linha >= 0 & linha <= this.pNumeroLinhas)
			{
				this.G.DrawString(Valor, this.FVAL, this.CVAL, this.MargemEsquerda + (float)offset_valor, (float)(checked((this.pLinhaInical + linha) * this.AlturaFonte)));
			}
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x002524AC File Offset: 0x002508AC
		public void EscreveTituloValorLinha(int linha, string Titulo, string Valor, int offset_titulo, int offset_valor)
		{
			SizeF sizeF = default(SizeF);
			string text = Titulo + ":";
			sizeF = this.G.MeasureString(text + ":", this.FVAR);
			if (linha >= 0 & linha <= this.pNumeroLinhas)
			{
				this.G.DrawString(text, this.FVAR, this.CVAR, this.MargemEsquerda + (float)offset_titulo, (float)(checked((this.pLinhaInical + linha) * this.AlturaFonte)));
				this.G.DrawString(Valor, this.FVAL, this.CVAL, this.MargemEsquerda + (float)offset_titulo + sizeF.Width, (float)(checked((this.pLinhaInical + linha) * this.AlturaFonte)));
			}
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0025256C File Offset: 0x0025096C
		public void AdicionaLinha()
		{
			Pen pen = new Pen(this.CTAB, 1f);
			checked
			{
				this.pNumeroLinhas++;
				this.G.DrawRectangle(pen, this.MargemEsquerda, (float)(this.pLinhaInical * this.AlturaFonte + this.pNumeroLinhas * this.AlturaFonte), unchecked(this.MargemDireita - this.MargemEsquerda), (float)this.AlturaFonte);
			}
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x002525DC File Offset: 0x002509DC
		public int GetNextLineAvailable()
		{
			return checked(this.pLinhaInical + this.pNumeroLinhas + 2);
		}

		// Token: 0x04000A31 RID: 2609
		private int AlturaFonte;

		// Token: 0x04000A32 RID: 2610
		private int pLinhaInical;

		// Token: 0x04000A33 RID: 2611
		private int pNumeroLinhas;

		// Token: 0x04000A34 RID: 2612
		private float MargemEsquerda;

		// Token: 0x04000A35 RID: 2613
		private float MargemDireita;

		// Token: 0x04000A36 RID: 2614
		private float MargemInferior;

		// Token: 0x04000A37 RID: 2615
		private float MargemSuperior;

		// Token: 0x04000A38 RID: 2616
		private float CentroLinha;

		// Token: 0x04000A39 RID: 2617
		private Font FT;

		// Token: 0x04000A3A RID: 2618
		private Font FVAR;

		// Token: 0x04000A3B RID: 2619
		private Font FVAL;

		// Token: 0x04000A3C RID: 2620
		private Brush CT;

		// Token: 0x04000A3D RID: 2621
		private Brush CVAR;

		// Token: 0x04000A3E RID: 2622
		private Brush CVAL;

		// Token: 0x04000A3F RID: 2623
		private Color CTAB;

		// Token: 0x04000A40 RID: 2624
		private Graphics G;

		// Token: 0x04000A41 RID: 2625
		private int[] Pos;
	}
}
