using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iS800.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x0200009D RID: 157
	[DesignerGenerated]
	public partial class Equip_VA220_mon : Form
	{
		// Token: 0x06002538 RID: 9528 RVA: 0x00413CA4 File Offset: 0x004120A4
		public Equip_VA220_mon()
		{
			base.Load += new EventHandler(this.Equip_VA220_mon_Load);
			this.InitializeComponent();
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x0600253B RID: 9531 RVA: 0x00414710 File Offset: 0x00412B10
		// (set) Token: 0x0600253C RID: 9532 RVA: 0x00414724 File Offset: 0x00412B24
		internal virtual GroupBox Grupo_endereco
		{
			get
			{
				return this._Grupo_endereco;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_endereco = value;
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x0600253D RID: 9533 RVA: 0x00414730 File Offset: 0x00412B30
		// (set) Token: 0x0600253E RID: 9534 RVA: 0x00414744 File Offset: 0x00412B44
		internal virtual TextBox Box_Msg
		{
			get
			{
				return this._Box_Msg;
			}
			[MethodImpl(32)]
			set
			{
				this._Box_Msg = value;
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x0600253F RID: 9535 RVA: 0x00414750 File Offset: 0x00412B50
		// (set) Token: 0x06002540 RID: 9536 RVA: 0x00414764 File Offset: 0x00412B64
		internal virtual Button Button_escrever
		{
			get
			{
				return this._Button_escrever;
			}
			[MethodImpl(32)]
			set
			{
				this._Button_escrever = value;
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x00414770 File Offset: 0x00412B70
		// (set) Token: 0x06002542 RID: 9538 RVA: 0x00414784 File Offset: 0x00412B84
		internal virtual Button Button_ler
		{
			get
			{
				return this._Button_ler;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_ler_Click);
				if (this._Button_ler != null)
				{
					this._Button_ler.Click -= eventHandler;
				}
				this._Button_ler = value;
				if (this._Button_ler != null)
				{
					this._Button_ler.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x004147D0 File Offset: 0x00412BD0
		// (set) Token: 0x06002544 RID: 9540 RVA: 0x004147E4 File Offset: 0x00412BE4
		internal virtual Label Label_end_mestre
		{
			get
			{
				return this._Label_end_mestre;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_mestre = value;
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x004147F0 File Offset: 0x00412BF0
		// (set) Token: 0x06002546 RID: 9542 RVA: 0x00414804 File Offset: 0x00412C04
		internal virtual Label Label_end_estacao
		{
			get
			{
				return this._Label_end_estacao;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_estacao = value;
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x00414810 File Offset: 0x00412C10
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x00414824 File Offset: 0x00412C24
		internal virtual VScrollBar VScroll_end_mestre
		{
			get
			{
				return this._VScroll_end_mestre;
			}
			[MethodImpl(32)]
			set
			{
				this._VScroll_end_mestre = value;
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x00414830 File Offset: 0x00412C30
		// (set) Token: 0x0600254A RID: 9546 RVA: 0x00414844 File Offset: 0x00412C44
		internal virtual VScrollBar VScroll_end_estacao
		{
			get
			{
				return this._VScroll_end_estacao;
			}
			[MethodImpl(32)]
			set
			{
				this._VScroll_end_estacao = value;
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x0600254B RID: 9547 RVA: 0x00414850 File Offset: 0x00412C50
		// (set) Token: 0x0600254C RID: 9548 RVA: 0x00414864 File Offset: 0x00412C64
		internal virtual TextBox Valor_end_mestre
		{
			get
			{
				return this._Valor_end_mestre;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_end_mestre_TextChanged);
				if (this._Valor_end_mestre != null)
				{
					this._Valor_end_mestre.TextChanged -= eventHandler;
				}
				this._Valor_end_mestre = value;
				if (this._Valor_end_mestre != null)
				{
					this._Valor_end_mestre.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x0600254D RID: 9549 RVA: 0x004148B0 File Offset: 0x00412CB0
		// (set) Token: 0x0600254E RID: 9550 RVA: 0x004148C4 File Offset: 0x00412CC4
		internal virtual TextBox Valor_end_estacao
		{
			get
			{
				return this._Valor_end_estacao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_end_estacao_TextChanged);
				if (this._Valor_end_estacao != null)
				{
					this._Valor_end_estacao.TextChanged -= eventHandler;
				}
				this._Valor_end_estacao = value;
				if (this._Valor_end_estacao != null)
				{
					this._Valor_end_estacao.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x0600254F RID: 9551 RVA: 0x00414910 File Offset: 0x00412D10
		// (set) Token: 0x06002550 RID: 9552 RVA: 0x00414924 File Offset: 0x00412D24
		internal virtual Label Label_bomba
		{
			get
			{
				return this._Label_bomba;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_bomba = value;
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x00414930 File Offset: 0x00412D30
		// (set) Token: 0x06002552 RID: 9554 RVA: 0x00414944 File Offset: 0x00412D44
		internal virtual VScrollBar VScroll_bomba
		{
			get
			{
				return this._VScroll_bomba;
			}
			[MethodImpl(32)]
			set
			{
				this._VScroll_bomba = value;
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06002553 RID: 9555 RVA: 0x00414950 File Offset: 0x00412D50
		// (set) Token: 0x06002554 RID: 9556 RVA: 0x00414964 File Offset: 0x00412D64
		internal virtual TextBox Valor_bomba
		{
			get
			{
				return this._Valor_bomba;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_bomba_TextChanged);
				if (this._Valor_bomba != null)
				{
					this._Valor_bomba.TextChanged -= eventHandler;
				}
				this._Valor_bomba = value;
				if (this._Valor_bomba != null)
				{
					this._Valor_bomba.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06002555 RID: 9557 RVA: 0x004149B0 File Offset: 0x00412DB0
		// (set) Token: 0x06002556 RID: 9558 RVA: 0x004149C4 File Offset: 0x00412DC4
		internal virtual Button Button_desliga
		{
			get
			{
				return this._Button_desliga;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_desliga_Click);
				if (this._Button_desliga != null)
				{
					this._Button_desliga.Click -= eventHandler;
				}
				this._Button_desliga = value;
				if (this._Button_desliga != null)
				{
					this._Button_desliga.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06002557 RID: 9559 RVA: 0x00414A10 File Offset: 0x00412E10
		// (set) Token: 0x06002558 RID: 9560 RVA: 0x00414A24 File Offset: 0x00412E24
		internal virtual Button Button_manual
		{
			get
			{
				return this._Button_manual;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_manual_Click);
				if (this._Button_manual != null)
				{
					this._Button_manual.Click -= eventHandler;
				}
				this._Button_manual = value;
				if (this._Button_manual != null)
				{
					this._Button_manual.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x00414A70 File Offset: 0x00412E70
		// (set) Token: 0x0600255A RID: 9562 RVA: 0x00414A84 File Offset: 0x00412E84
		internal virtual Button Button_auto
		{
			get
			{
				return this._Button_auto;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_auto_Click);
				if (this._Button_auto != null)
				{
					this._Button_auto.Click -= eventHandler;
				}
				this._Button_auto = value;
				if (this._Button_auto != null)
				{
					this._Button_auto.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x0600255B RID: 9563 RVA: 0x00414AD0 File Offset: 0x00412ED0
		// (set) Token: 0x0600255C RID: 9564 RVA: 0x00414AE4 File Offset: 0x00412EE4
		internal virtual Button Button_liga
		{
			get
			{
				return this._Button_liga;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_liga_Click);
				if (this._Button_liga != null)
				{
					this._Button_liga.Click -= eventHandler;
				}
				this._Button_liga = value;
				if (this._Button_liga != null)
				{
					this._Button_liga.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x0600255D RID: 9565 RVA: 0x00414B30 File Offset: 0x00412F30
		// (set) Token: 0x0600255E RID: 9566 RVA: 0x00414B44 File Offset: 0x00412F44
		internal virtual Button Button_falha
		{
			get
			{
				return this._Button_falha;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_falha_Click);
				if (this._Button_falha != null)
				{
					this._Button_falha.Click -= eventHandler;
				}
				this._Button_falha = value;
				if (this._Button_falha != null)
				{
					this._Button_falha.Click += eventHandler;
				}
			}
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x00414B90 File Offset: 0x00412F90
		private void Valor_end_estacao_TextChanged(object sender, EventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null)))));
			if (num >= 0 & num <= 200)
			{
				Mod_VA.Operacao_VA220.End_estacao = num;
				this.VScroll_end_estacao.Value = num;
			}
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x00414BF0 File Offset: 0x00412FF0
		private void Valor_end_mestre_TextChanged(object sender, EventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null)))));
			if (num >= 0 & num <= 200)
			{
				Mod_VA.Operacao_VA220.End_mestre = num;
				this.VScroll_end_mestre.Value = num;
			}
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x00414C50 File Offset: 0x00413050
		private void Button_ler_Click(object sender, EventArgs e)
		{
			int[] dados = new int[41];
			if (Conversion.Val(this.Valor_end_mestre.Text) == (DialogResult)0.0 | Conversion.Val(this.Valor_end_estacao.Text) == (DialogResult)0.0)
			{
				Interaction.MsgBox(" Existe um endereço não válido ", (MsgBoxStyle)0, null);
				return;
			}
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			checked
			{
				while (i > 0)
				{
					i--;
					Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 50, 0, dados);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == (DialogResult)255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						goto IL_CF;
					case 2:
						if (i == (DialogResult)0)
						{
							return;
						}
						continue;
					case 3:
						if (i == (DialogResult)0)
						{
							return;
						}
						continue;
					}
					if (i == (DialogResult)0)
					{
						return;
					}
				}
				IL_CF:
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
			}
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x00414D48 File Offset: 0x00413148
		private void Valor_bomba_TextChanged(object sender, EventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null)))));
			if (num >= 1 & num <= 4)
			{
				Mod_VA.Operacao_VA220.bomba = num;
				this.VScroll_bomba.Value = num;
			}
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x00414DA4 File Offset: 0x004131A4
		private void Button_manual_Click(object sender, EventArgs e)
		{
			int[] array = new int[41];
			if (Conversion.Val(this.Valor_end_mestre.Text) == (DialogResult)0.0 | Conversion.Val(this.Valor_end_estacao.Text) == (DialogResult)0.0 | Conversion.Val(this.Valor_bomba.Text) == (DialogResult)0.0)
			{
				Interaction.MsgBox(" Existe um dado não válido ", (MsgBoxStyle)0, null);
				return;
			}
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			checked
			{
				while (i > 0)
				{
					i--;
					array[0] = Mod_VA.Operacao_VA220.bomba;
					Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 69, 1, array);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == (DialogResult)255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						goto IL_F8;
					case 2:
						if (i == (DialogResult)0)
						{
							return;
						}
						continue;
					case 3:
						if (i == (DialogResult)0)
						{
							return;
						}
						continue;
					}
					if (i == (DialogResult)0)
					{
						return;
					}
				}
				IL_F8:
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
			}
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x00414EC4 File Offset: 0x004132C4
		private void Button_auto_Click(object sender, EventArgs e)
		{
			int[] array = new int[41];
			if (Conversion.Val(this.Valor_end_mestre.Text) == (DialogResult)0.0 | Conversion.Val(this.Valor_end_estacao.Text) == (DialogResult)0.0 | Conversion.Val(this.Valor_bomba.Text) == (DialogResult)0.0)
			{
				Interaction.MsgBox(" Existe um dado não válido ", (MsgBoxStyle)0, null);
				return;
			}
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			checked
			{
				while (i > 0)
				{
					i--;
					array[0] = Mod_VA.Operacao_VA220.bomba;
					Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 70, 1, array);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == (DialogResult)255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						goto IL_F8;
					case 2:
						if (i == (DialogResult)0)
						{
							return;
						}
						continue;
					case 3:
						if (i == (DialogResult)0)
						{
							return;
						}
						continue;
					}
					if (i == (DialogResult)0)
					{
						return;
					}
				}
				IL_F8:
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
			}
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x00414FE4 File Offset: 0x004133E4
		private void Button_liga_Click(object sender, EventArgs e)
		{
			int[] array = new int[41];
			if (Conversion.Val(this.Valor_end_mestre.Text) == (DialogResult)0.0 | Conversion.Val(this.Valor_end_estacao.Text) == (DialogResult)0.0 | Conversion.Val(this.Valor_bomba.Text) == (DialogResult)0.0)
			{
				Interaction.MsgBox(" Existe um dado não válido ", (MsgBoxStyle)0, null);
				return;
			}
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			checked
			{
				while (i > 0)
				{
					i--;
					array[0] = Mod_VA.Operacao_VA220.bomba;
					Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 67, 1, array);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == (DialogResult)255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						goto IL_F8;
					case 2:
						if (i == (DialogResult)0)
						{
							return;
						}
						continue;
					case 3:
						if (i == (DialogResult)0)
						{
							return;
						}
						continue;
					}
					if (i == (DialogResult)0)
					{
						return;
					}
				}
				IL_F8:
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
			}
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x00415104 File Offset: 0x00413504
		private void Button_desliga_Click(object sender, EventArgs e)
		{
			int[] array = new int[41];
			if (Conversion.Val(this.Valor_end_mestre.Text) == (DialogResult)0.0 | Conversion.Val(this.Valor_end_estacao.Text) == (DialogResult)0.0 | Conversion.Val(this.Valor_bomba.Text) == (DialogResult)0.0)
			{
				Interaction.MsgBox(" Existe um dado não válido ", (MsgBoxStyle)0, null);
				return;
			}
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			checked
			{
				while (i > 0)
				{
					i--;
					array[0] = Mod_VA.Operacao_VA220.bomba;
					Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 68, 1, array);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == (DialogResult)255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						goto IL_F8;
					case 2:
						if (i == (DialogResult)0)
						{
							return;
						}
						continue;
					case 3:
						if (i == (DialogResult)0)
						{
							return;
						}
						continue;
					}
					if (i == (DialogResult)0)
					{
						return;
					}
				}
				IL_F8:
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
			}
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x00415224 File Offset: 0x00413624
		private void Button_falha_Click(object sender, EventArgs e)
		{
			int[] array = new int[41];
			if (Conversion.Val(this.Valor_end_mestre.Text) == (DialogResult)0.0 | Conversion.Val(this.Valor_end_estacao.Text) == (DialogResult)0.0 | Conversion.Val(this.Valor_bomba.Text) == (DialogResult)0.0)
			{
				Interaction.MsgBox(" Existe um dado não válido ", (MsgBoxStyle)0, null);
				return;
			}
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			checked
			{
				while (i > 0)
				{
					i--;
					array[0] = Mod_VA.Operacao_VA220.bomba;
					Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 71, 1, array);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == (DialogResult)255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						goto IL_F8;
					case 2:
						if (i == (DialogResult)0)
						{
							return;
						}
						continue;
					case 3:
						if (i == (DialogResult)0)
						{
							return;
						}
						continue;
					}
					if (i == (DialogResult)0)
					{
						return;
					}
				}
				IL_F8:
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
			}
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x00415344 File Offset: 0x00413744
		private void Equip_VA220_mon_Load(object sender, EventArgs e)
		{
			Geral.Config_geral.Largura_tela_trabalho = this.Width;
		}

		// Token: 0x04001A81 RID: 6785
		[AccessedThroughProperty("Grupo_endereco")]
		private GroupBox _Grupo_endereco;

		// Token: 0x04001A82 RID: 6786
		[AccessedThroughProperty("Box_Msg")]
		private TextBox _Box_Msg;

		// Token: 0x04001A83 RID: 6787
		[AccessedThroughProperty("Button_escrever")]
		private Button _Button_escrever;

		// Token: 0x04001A84 RID: 6788
		[AccessedThroughProperty("Button_ler")]
		private Button _Button_ler;

		// Token: 0x04001A85 RID: 6789
		[AccessedThroughProperty("Label_end_mestre")]
		private Label _Label_end_mestre;

		// Token: 0x04001A86 RID: 6790
		[AccessedThroughProperty("Label_end_estacao")]
		private Label _Label_end_estacao;

		// Token: 0x04001A87 RID: 6791
		[AccessedThroughProperty("VScroll_end_mestre")]
		private VScrollBar _VScroll_end_mestre;

		// Token: 0x04001A88 RID: 6792
		[AccessedThroughProperty("VScroll_end_estacao")]
		private VScrollBar _VScroll_end_estacao;

		// Token: 0x04001A89 RID: 6793
		[AccessedThroughProperty("Valor_end_mestre")]
		private TextBox _Valor_end_mestre;

		// Token: 0x04001A8A RID: 6794
		[AccessedThroughProperty("Valor_end_estacao")]
		private TextBox _Valor_end_estacao;

		// Token: 0x04001A8B RID: 6795
		[AccessedThroughProperty("Label_bomba")]
		private Label _Label_bomba;

		// Token: 0x04001A8C RID: 6796
		[AccessedThroughProperty("VScroll_bomba")]
		private VScrollBar _VScroll_bomba;

		// Token: 0x04001A8D RID: 6797
		[AccessedThroughProperty("Valor_bomba")]
		private TextBox _Valor_bomba;

		// Token: 0x04001A8E RID: 6798
		[AccessedThroughProperty("Button_desliga")]
		private Button _Button_desliga;

		// Token: 0x04001A8F RID: 6799
		[AccessedThroughProperty("Button_manual")]
		private Button _Button_manual;

		// Token: 0x04001A90 RID: 6800
		[AccessedThroughProperty("Button_auto")]
		private Button _Button_auto;

		// Token: 0x04001A91 RID: 6801
		[AccessedThroughProperty("Button_liga")]
		private Button _Button_liga;

		// Token: 0x04001A92 RID: 6802
		[AccessedThroughProperty("Button_falha")]
		private Button _Button_falha;
	}
}
