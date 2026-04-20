using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x02000053 RID: 83
	[DesignerGenerated]
	public partial class RT_820_400_SA_CALIB : Form
	{
		// Token: 0x06001680 RID: 5760 RVA: 0x0037342C File Offset: 0x0037182C
		public RT_820_400_SA_CALIB()
		{
			base.Load += new EventHandler(this.RT_820_400_SA_CALIB_Load);
			this.InitializeComponent();
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001683 RID: 5763 RVA: 0x003741D4 File Offset: 0x003725D4
		// (set) Token: 0x06001684 RID: 5764 RVA: 0x003741E8 File Offset: 0x003725E8
		internal virtual GroupBox GroupBox1
		{
			get
			{
				return this._GroupBox1;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001685 RID: 5765 RVA: 0x003741F4 File Offset: 0x003725F4
		// (set) Token: 0x06001686 RID: 5766 RVA: 0x00374208 File Offset: 0x00372608
		internal virtual Button bt_busca
		{
			get
			{
				return this._bt_busca;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bt_busca_Click);
				if (this._bt_busca != null)
				{
					this._bt_busca.Click -= eventHandler;
				}
				this._bt_busca = value;
				if (this._bt_busca != null)
				{
					this._bt_busca.Click += eventHandler;
				}
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x00374254 File Offset: 0x00372654
		// (set) Token: 0x06001688 RID: 5768 RVA: 0x00374268 File Offset: 0x00372668
		internal virtual NumericUpDown nud_estacao
		{
			get
			{
				return this._nud_estacao;
			}
			[MethodImpl(32)]
			set
			{
				this._nud_estacao = value;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x00374274 File Offset: 0x00372674
		// (set) Token: 0x0600168A RID: 5770 RVA: 0x00374288 File Offset: 0x00372688
		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x0600168B RID: 5771 RVA: 0x00374294 File Offset: 0x00372694
		// (set) Token: 0x0600168C RID: 5772 RVA: 0x003742A8 File Offset: 0x003726A8
		internal virtual GroupBox GroupBox2
		{
			get
			{
				return this._GroupBox2;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x0600168D RID: 5773 RVA: 0x003742B4 File Offset: 0x003726B4
		// (set) Token: 0x0600168E RID: 5774 RVA: 0x003742C8 File Offset: 0x003726C8
		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x003742D4 File Offset: 0x003726D4
		// (set) Token: 0x06001690 RID: 5776 RVA: 0x003742E8 File Offset: 0x003726E8
		internal virtual Button Button9
		{
			get
			{
				return this._Button9;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button9_Click);
				if (this._Button9 != null)
				{
					this._Button9.Click -= eventHandler;
				}
				this._Button9 = value;
				if (this._Button9 != null)
				{
					this._Button9.Click += eventHandler;
				}
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x00374334 File Offset: 0x00372734
		// (set) Token: 0x06001692 RID: 5778 RVA: 0x00374348 File Offset: 0x00372748
		internal virtual Button Button3
		{
			get
			{
				return this._Button3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button3_Click);
				if (this._Button3 != null)
				{
					this._Button3.Click -= eventHandler;
				}
				this._Button3 = value;
				if (this._Button3 != null)
				{
					this._Button3.Click += eventHandler;
				}
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x00374394 File Offset: 0x00372794
		// (set) Token: 0x06001694 RID: 5780 RVA: 0x003743A8 File Offset: 0x003727A8
		internal virtual Button Button2
		{
			get
			{
				return this._Button2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button2_Click);
				if (this._Button2 != null)
				{
					this._Button2.Click -= eventHandler;
				}
				this._Button2 = value;
				if (this._Button2 != null)
				{
					this._Button2.Click += eventHandler;
				}
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x003743F4 File Offset: 0x003727F4
		// (set) Token: 0x06001696 RID: 5782 RVA: 0x00374408 File Offset: 0x00372808
		internal virtual NumericUpDown nud_contagens
		{
			get
			{
				return this._nud_contagens;
			}
			[MethodImpl(32)]
			set
			{
				this._nud_contagens = value;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x00374414 File Offset: 0x00372814
		// (set) Token: 0x06001698 RID: 5784 RVA: 0x00374428 File Offset: 0x00372828
		internal virtual Button Button1
		{
			get
			{
				return this._Button1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= eventHandler;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += eventHandler;
				}
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001699 RID: 5785 RVA: 0x00374474 File Offset: 0x00372874
		// (set) Token: 0x0600169A RID: 5786 RVA: 0x00374488 File Offset: 0x00372888
		internal virtual Button Button10
		{
			get
			{
				return this._Button10;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button10_Click);
				if (this._Button10 != null)
				{
					this._Button10.Click -= eventHandler;
				}
				this._Button10 = value;
				if (this._Button10 != null)
				{
					this._Button10.Click += eventHandler;
				}
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x003744D4 File Offset: 0x003728D4
		// (set) Token: 0x0600169C RID: 5788 RVA: 0x003744E8 File Offset: 0x003728E8
		internal virtual GroupBox GroupBox3
		{
			get
			{
				return this._GroupBox3;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox3 = value;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x0600169D RID: 5789 RVA: 0x003744F4 File Offset: 0x003728F4
		// (set) Token: 0x0600169E RID: 5790 RVA: 0x00374508 File Offset: 0x00372908
		internal virtual TextBox mensagens
		{
			get
			{
				return this._mensagens;
			}
			[MethodImpl(32)]
			set
			{
				this._mensagens = value;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x00374514 File Offset: 0x00372914
		// (set) Token: 0x060016A0 RID: 5792 RVA: 0x00374528 File Offset: 0x00372928
		internal virtual GroupBox GroupBox5
		{
			get
			{
				return this._GroupBox5;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox5 = value;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060016A1 RID: 5793 RVA: 0x00374534 File Offset: 0x00372934
		// (set) Token: 0x060016A2 RID: 5794 RVA: 0x00374548 File Offset: 0x00372948
		internal virtual RadioButton rb_20mA
		{
			get
			{
				return this._rb_20mA;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.rb_20mA_CheckedChanged);
				if (this._rb_20mA != null)
				{
					this._rb_20mA.CheckedChanged -= eventHandler;
				}
				this._rb_20mA = value;
				if (this._rb_20mA != null)
				{
					this._rb_20mA.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060016A3 RID: 5795 RVA: 0x00374594 File Offset: 0x00372994
		// (set) Token: 0x060016A4 RID: 5796 RVA: 0x003745A8 File Offset: 0x003729A8
		internal virtual RadioButton rb_4mA
		{
			get
			{
				return this._rb_4mA;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.rb_4mA_CheckedChanged);
				if (this._rb_4mA != null)
				{
					this._rb_4mA.CheckedChanged -= eventHandler;
				}
				this._rb_4mA = value;
				if (this._rb_4mA != null)
				{
					this._rb_4mA.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x003745F4 File Offset: 0x003729F4
		// (set) Token: 0x060016A6 RID: 5798 RVA: 0x00374608 File Offset: 0x00372A08
		internal virtual GroupBox GroupBox4
		{
			get
			{
				return this._GroupBox4;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox4 = value;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x00374614 File Offset: 0x00372A14
		// (set) Token: 0x060016A8 RID: 5800 RVA: 0x00374628 File Offset: 0x00372A28
		internal virtual RadioButton rb_channel2
		{
			get
			{
				return this._rb_channel2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.rb_channel2_CheckedChanged);
				if (this._rb_channel2 != null)
				{
					this._rb_channel2.CheckedChanged -= eventHandler;
				}
				this._rb_channel2 = value;
				if (this._rb_channel2 != null)
				{
					this._rb_channel2.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x00374674 File Offset: 0x00372A74
		// (set) Token: 0x060016AA RID: 5802 RVA: 0x00374688 File Offset: 0x00372A88
		internal virtual RadioButton rb_channel1
		{
			get
			{
				return this._rb_channel1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.rb_channel1_CheckedChanged);
				if (this._rb_channel1 != null)
				{
					this._rb_channel1.CheckedChanged -= eventHandler;
				}
				this._rb_channel1 = value;
				if (this._rb_channel1 != null)
				{
					this._rb_channel1.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x003746D4 File Offset: 0x00372AD4
		// (set) Token: 0x060016AC RID: 5804 RVA: 0x003746E8 File Offset: 0x00372AE8
		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x003746F4 File Offset: 0x00372AF4
		private void Button1_Click(object sender, EventArgs e)
		{
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.AtualizaMsgTela_SA_820("Iniciando Calibração", 2);
				Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
				this.AtualizaMsgTela_SA_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", 16, "Atenção");
			}
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00374748 File Offset: 0x00372B48
		public void AtualizaMsgTela_SA_820(string texto, int cor)
		{
			this.mensagens.Text = texto;
			if (cor == 0)
			{
				this.mensagens.ForeColor = Color.Blue;
			}
			else if (cor == 1)
			{
				this.mensagens.ForeColor = Color.Red;
			}
			else
			{
				this.mensagens.ForeColor = Color.Black;
			}
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x003747A0 File Offset: 0x00372BA0
		private void bt_busca_Click(object sender, EventArgs e)
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				if (!Mod_MD.Leitura_pagina(0, 255, 4).Status)
				{
					this.AtualizaMsgTela_SA_820("Equipamento não responde", 1);
					return;
				}
				if (!Linha_RT.VerificaSeEquipamento_SA_820_400_MAIOR_IGUAL_R19(2, 0, 0, ""))
				{
					return;
				}
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", 16, "Atenção");
			}
			this.nud_estacao.Value = new decimal(this.Leitura_EnderecoEstacao());
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x0037481C File Offset: 0x00372C1C
		private int Leitura_ContanteCalibracao(int pagina, int endereco, int tamanho)
		{
			this.AtualizaMsgTela_SA_820("Buscando Constante", 2);
			int result;
			if (!Mod_MD.Leitura_pagina(pagina, endereco, tamanho).Status)
			{
				this.AtualizaMsgTela_SA_820("Equipamento não responde", 1);
				result = 0;
			}
			else
			{
				Comunicacao.Rotina_Delay(5L);
				this.AtualizaMsgTela_SA_820("Busca Constante OK", 0);
				result = Linha_RT.Retorna_End_Est_GC_82x();
			}
			return result;
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00374874 File Offset: 0x00372C74
		private int Leitura_EnderecoEstacao()
		{
			this.AtualizaMsgTela_SA_820("Buscando Endereço", 2);
			int result;
			if (!Mod_MD.Leitura_pagina(2048, 255, 1).Status)
			{
				this.AtualizaMsgTela_SA_820("Equipamento não responde", 1);
				result = 0;
			}
			else
			{
				Comunicacao.Rotina_Delay(5L);
				this.AtualizaMsgTela_SA_820("Busca Endereço OK", 0);
				result = Linha_RT.Retorna_End_Est_GC_82x();
			}
			return result;
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x003748D4 File Offset: 0x00372CD4
		private void Button10_Click(object sender, EventArgs e)
		{
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.AtualizaMsgTela_SA_820("Finalizando Calibração", 2);
				Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_SA_820("Equipamento não responde", 1);
					return;
				}
				this.AtualizaMsgTela_SA_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", 16, "Atenção");
			}
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00374940 File Offset: 0x00372D40
		private void Button2_Click(object sender, EventArgs e)
		{
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.AtualizaMsgTela_SA_820("Finalizando Calibração", 2);
				int pagina;
				if (RT_geral.RT_820_360_BD.calibracao_canal == 1)
				{
					if (RT_geral.RT_820_360_BD.calibracao_range == 4)
					{
						pagina = 6176;
					}
					else if (RT_geral.RT_820_360_BD.calibracao_range == 20)
					{
						pagina = 6178;
					}
				}
				else if (RT_geral.RT_820_360_BD.calibracao_canal == 2)
				{
					if (RT_geral.RT_820_360_BD.calibracao_range == 4)
					{
						pagina = 6177;
					}
					else if (RT_geral.RT_820_360_BD.calibracao_range == 20)
					{
						pagina = 6179;
					}
				}
				int num = this.Leitura_ContanteCalibracao(pagina, Convert.ToInt32(this.nud_estacao.Value), 1);
				this.nud_contagens.Value = new decimal(num);
			}
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x003749FC File Offset: 0x00372DFC
		private void Button3_Click(object sender, EventArgs e)
		{
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.AtualizaMsgTela_SA_820("Escrevendo Contagens", 2);
				int numero_pagina;
				if (RT_geral.RT_820_360_BD.calibracao_canal == 1)
				{
					numero_pagina = 6180;
				}
				else if (RT_geral.RT_820_360_BD.calibracao_canal == 2)
				{
					numero_pagina = 6181;
				}
				RT_geral.RT_820_360_BD.calibracao_tipo = 0;
				RT_geral.RT_820_360_BD.calibracao_const = Convert.ToInt32(this.nud_contagens.Value);
				if (!Mod_MD.Escrita_pagina_RT(numero_pagina, 4, 0).Status)
				{
					this.AtualizaMsgTela_SA_820("Erro na escrita de contagens", 1);
					return;
				}
			}
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00374A88 File Offset: 0x00372E88
		private void Button5_Click(object sender, EventArgs e)
		{
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.AtualizaMsgTela_SA_820("Finalizando Calibração", 2);
				int num = this.Leitura_ContanteCalibracao(6177, Convert.ToInt32(this.nud_estacao.Value), 1);
				this.nud_contagens.Value = new decimal(num);
			}
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00374AD8 File Offset: 0x00372ED8
		private void Button4_Click(object sender, EventArgs e)
		{
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.AtualizaMsgTela_SA_820("Finalizando Calibração", 2);
				int num = this.Leitura_ContanteCalibracao(6179, Convert.ToInt32(this.nud_estacao.Value), 1);
				this.nud_contagens.Value = new decimal(num);
			}
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00374B28 File Offset: 0x00372F28
		private void RT_820_400_SA_CALIB_Load(object sender, EventArgs e)
		{
			this.rb_channel2.Checked = true;
			this.rb_channel1.Checked = true;
			this.rb_20mA.Checked = true;
			this.rb_4mA.Checked = true;
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00374B5C File Offset: 0x00372F5C
		private void rb_channel1_CheckedChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.calibracao_canal = 1;
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00374B6C File Offset: 0x00372F6C
		private void rb_channel2_CheckedChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.calibracao_canal = 2;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00374B7C File Offset: 0x00372F7C
		private void rb_4mA_CheckedChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.calibracao_range = 4;
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00374B8C File Offset: 0x00372F8C
		private void rb_20mA_CheckedChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.calibracao_range = 20;
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00374B9C File Offset: 0x00372F9C
		private void Button9_Click(object sender, EventArgs e)
		{
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.AtualizaMsgTela_SA_820("Escrevendo Contagens", 2);
				int numero_pagina;
				if (RT_geral.RT_820_360_BD.calibracao_canal == 1)
				{
					if (RT_geral.RT_820_360_BD.calibracao_range == 4)
					{
						numero_pagina = 6176;
					}
					else if (RT_geral.RT_820_360_BD.calibracao_range == 20)
					{
						numero_pagina = 6178;
					}
				}
				else if (RT_geral.RT_820_360_BD.calibracao_canal == 2)
				{
					if (RT_geral.RT_820_360_BD.calibracao_range == 4)
					{
						numero_pagina = 6177;
					}
					else if (RT_geral.RT_820_360_BD.calibracao_range == 20)
					{
						numero_pagina = 6179;
					}
				}
				RT_geral.RT_820_360_BD.calibracao_tipo = 0;
				RT_geral.RT_820_360_BD.calibracao_const = Convert.ToInt32(this.nud_contagens.Value);
				if (!Mod_MD.Escrita_pagina_RT(numero_pagina, 4, 0).Status)
				{
					this.AtualizaMsgTela_SA_820("Erro na escrita de contagens", 1);
					return;
				}
			}
		}

		// Token: 0x04000BE9 RID: 3049
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000BEA RID: 3050
		[AccessedThroughProperty("bt_busca")]
		private Button _bt_busca;

		// Token: 0x04000BEB RID: 3051
		[AccessedThroughProperty("nud_estacao")]
		private NumericUpDown _nud_estacao;

		// Token: 0x04000BEC RID: 3052
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000BED RID: 3053
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000BEE RID: 3054
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000BEF RID: 3055
		[AccessedThroughProperty("Button9")]
		private Button _Button9;

		// Token: 0x04000BF0 RID: 3056
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x04000BF1 RID: 3057
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x04000BF2 RID: 3058
		[AccessedThroughProperty("nud_contagens")]
		private NumericUpDown _nud_contagens;

		// Token: 0x04000BF3 RID: 3059
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000BF4 RID: 3060
		[AccessedThroughProperty("Button10")]
		private Button _Button10;

		// Token: 0x04000BF5 RID: 3061
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x04000BF6 RID: 3062
		[AccessedThroughProperty("mensagens")]
		private TextBox _mensagens;

		// Token: 0x04000BF7 RID: 3063
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x04000BF8 RID: 3064
		[AccessedThroughProperty("rb_20mA")]
		private RadioButton _rb_20mA;

		// Token: 0x04000BF9 RID: 3065
		[AccessedThroughProperty("rb_4mA")]
		private RadioButton _rb_4mA;

		// Token: 0x04000BFA RID: 3066
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x04000BFB RID: 3067
		[AccessedThroughProperty("rb_channel2")]
		private RadioButton _rb_channel2;

		// Token: 0x04000BFC RID: 3068
		[AccessedThroughProperty("rb_channel1")]
		private RadioButton _rb_channel1;

		// Token: 0x04000BFD RID: 3069
		[AccessedThroughProperty("Label3")]
		private Label _Label3;
	}
}
