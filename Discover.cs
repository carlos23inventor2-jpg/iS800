using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iS800.My;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x02000013 RID: 19
	[DesignerGenerated]
	public partial class Discover : Form
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x002657F4 File Offset: 0x00263BF4
		public Discover()
		{
			base.Load += new EventHandler(this.Discover_Load);
			this.InitializeComponent();
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00265FF4 File Offset: 0x002643F4
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00266008 File Offset: 0x00264408
		internal virtual GroupBox GroupBox_informacoes
		{
			get
			{
				return this._GroupBox_informacoes;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_informacoes = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00266014 File Offset: 0x00264414
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00266028 File Offset: 0x00264428
		internal virtual Label Label26
		{
			get
			{
				return this._Label26;
			}
			[MethodImpl(32)]
			set
			{
				this._Label26 = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00266034 File Offset: 0x00264434
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00266048 File Offset: 0x00264448
		internal virtual TextBox TextBox_equipamento
		{
			get
			{
				return this._TextBox_equipamento;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_equipamento = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00266054 File Offset: 0x00264454
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00266068 File Offset: 0x00264468
		internal virtual Label Label_equipamento
		{
			get
			{
				return this._Label_equipamento;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_equipamento = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00266074 File Offset: 0x00264474
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00266088 File Offset: 0x00264488
		internal virtual TextBox TextBox_release
		{
			get
			{
				return this._TextBox_release;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_release = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00266094 File Offset: 0x00264494
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x002660A8 File Offset: 0x002644A8
		internal virtual Label Label_release
		{
			get
			{
				return this._Label_release;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_release = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x002660B4 File Offset: 0x002644B4
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x002660C8 File Offset: 0x002644C8
		internal virtual TextBox TextBox_build
		{
			get
			{
				return this._TextBox_build;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_build = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000EA RID: 234 RVA: 0x002660D4 File Offset: 0x002644D4
		// (set) Token: 0x060000EB RID: 235 RVA: 0x002660E8 File Offset: 0x002644E8
		internal virtual Label Label_build
		{
			get
			{
				return this._Label_build;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_build = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000EC RID: 236 RVA: 0x002660F4 File Offset: 0x002644F4
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00266108 File Offset: 0x00264508
		internal virtual TextBox TextBox_versao
		{
			get
			{
				return this._TextBox_versao;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_versao = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00266114 File Offset: 0x00264514
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00266128 File Offset: 0x00264528
		internal virtual Label Label_versao
		{
			get
			{
				return this._Label_versao;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_versao = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00266134 File Offset: 0x00264534
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00266148 File Offset: 0x00264548
		internal virtual Button bt_Configuracao
		{
			get
			{
				return this._bt_Configuracao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bt_Configuracao_Click);
				if (this._bt_Configuracao != null)
				{
					this._bt_Configuracao.Click -= eventHandler;
				}
				this._bt_Configuracao = value;
				if (this._bt_Configuracao != null)
				{
					this._bt_Configuracao.Click += eventHandler;
				}
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00266194 File Offset: 0x00264594
		private void Discover_Load(object sender, EventArgs e)
		{
			this.GroupBox_informacoes.Enabled = true;
			this.TextBox_equipamento.Text = this.equipamento.ToString();
			this.TextBox_versao.Text = this.versao.ToString();
			this.TextBox_build.Text = this.build.ToString();
			this.TextBox_release.Text = this.release.ToString();
			switch (this.equipamento)
			{
			case 810:
			case 820:
			case 821:
				this.Label26.Text = "RT";
				break;
			case 830:
			case 831:
			case 850:
				this.Label26.Text = "CT";
				break;
			case 855:
				this.Label26.Text = "IEC";
				break;
			case 856:
				this.Label26.Text = "IER";
				break;
			}
			string text = ".\\\\Fontes\\\\Ictel Extendida Italic.ttf";
			if (MyProject.Computer.FileSystem.FileExists(text))
			{
				PrivateFontCollection privateFontCollection = new PrivateFontCollection();
				privateFontCollection.AddFontFile(text);
				Font font = new Font(privateFontCollection.Families[0], 8f, 2);
				Font font2 = new Font(privateFontCollection.Families[0], 18f, 2);
				this.Label26.Font = font;
				this.TextBox_equipamento.Font = font;
				this.TextBox_versao.Font = font;
				this.TextBox_build.Font = font;
				this.TextBox_release.Font = font;
			}
			else
			{
				MessageBox.Show("Removido fonte Ictel Extendida Italic da pasta da aplicação!");
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x002663B0 File Offset: 0x002647B0
		private void bt_Configuracao_Click(object sender, EventArgs e)
		{
			int num = this.equipamento;
			if (num == (DialogResult)810)
			{
				switch (this.versao)
				{
				case 2:
					Geral.Ctrl_equipamento = (HorizontalAlignment)1000;
					Geral.Ctrl_versao = (HorizontalAlignment)20;
					Geral.Ctrl_operacao = (HorizontalAlignment)100000;
					Geral.Equipamento_selecionado = (HorizontalAlignment)810;
					Geral.Equipamento_versao = (HorizontalAlignment)2;
					Geral.Equipamento_build = (HorizontalAlignment)0;
					RT_geral.Lmte_Init_ok = false;
					MyProject.Forms.Plataforma.Seleciona_tela(true);
					break;
				case 3:
					Geral.Ctrl_equipamento = (HorizontalAlignment)1000;
					Geral.Ctrl_versao = (HorizontalAlignment)30;
					Geral.Ctrl_operacao = (HorizontalAlignment)100000;
					Geral.Equipamento_selecionado = (HorizontalAlignment)810;
					Geral.Equipamento_versao = (HorizontalAlignment)3;
					Geral.Equipamento_build = (HorizontalAlignment)0;
					RT_geral.Lmte_Init_ok = false;
					MyProject.Forms.Plataforma.Seleciona_tela(true);
					break;
				}
			}
			else if (num == (DialogResult)820)
			{
				switch (this.versao)
				{
				case 2:
					Geral.Ctrl_equipamento = (HorizontalAlignment)2000;
					Geral.Ctrl_versao = (HorizontalAlignment)20;
					Geral.Ctrl_operacao = (HorizontalAlignment)100000;
					Geral.Equipamento_selecionado = (HorizontalAlignment)820;
					Geral.Equipamento_versao = (HorizontalAlignment)2;
					Geral.Equipamento_build = (HorizontalAlignment)0;
					RT_geral.Lmte_Init_ok = false;
					MyProject.Forms.Plataforma.Seleciona_tela(true);
					break;
				case 3:
					Geral.Ctrl_equipamento = (HorizontalAlignment)2000;
					Geral.Ctrl_versao = (HorizontalAlignment)30;
					Geral.Ctrl_operacao = (HorizontalAlignment)100000;
					Geral.Equipamento_build = (HorizontalAlignment)0;
					Geral.Equipamento_selecionado = (HorizontalAlignment)820;
					Geral.Equipamento_versao = (HorizontalAlignment)3;
					RT_geral.Lmte_Init_ok = false;
					MyProject.Forms.Plataforma.Seleciona_tela(true);
					break;
				case 4:
					Geral.Ctrl_equipamento = (HorizontalAlignment)2000;
					Geral.Ctrl_versao = (HorizontalAlignment)40;
					Geral.Ctrl_operacao = (HorizontalAlignment)100000;
					Geral.Equipamento_build = (HorizontalAlignment)0;
					Geral.Equipamento_selecionado = (HorizontalAlignment)820;
					Geral.Equipamento_versao = (HorizontalAlignment)4;
					RT_geral.Lmte_Init_ok = false;
					MyProject.Forms.Plataforma.Seleciona_tela(true);
					break;
				}
			}
			else if (num == (DialogResult)821)
			{
				switch (this.versao)
				{
				case 2:
					Geral.Ctrl_equipamento = (HorizontalAlignment)3000;
					Geral.Ctrl_versao = (HorizontalAlignment)20;
					Geral.Ctrl_operacao = (HorizontalAlignment)100000;
					Geral.Equipamento_selecionado = (HorizontalAlignment)821;
					Geral.Equipamento_versao = (HorizontalAlignment)2;
					Geral.Equipamento_build = (HorizontalAlignment)0;
					RT_geral.Lmte_Init_ok = false;
					MyProject.Forms.Plataforma.Seleciona_tela(true);
					break;
				case 3:
					Geral.Ctrl_equipamento = (HorizontalAlignment)3000;
					Geral.Ctrl_versao = (HorizontalAlignment)30;
					Geral.Ctrl_operacao = (HorizontalAlignment)100000;
					Geral.Equipamento_selecionado = (HorizontalAlignment)821;
					Geral.Equipamento_versao = (HorizontalAlignment)3;
					Geral.Equipamento_build = (HorizontalAlignment)0;
					RT_geral.Lmte_Init_ok = false;
					MyProject.Forms.Plataforma.Seleciona_tela(true);
					break;
				}
			}
			else if (num == (DialogResult)830)
			{
				Geral.Ctrl_equipamento = (HorizontalAlignment)5000;
				Geral.Ctrl_versao = (HorizontalAlignment)20;
				Geral.Ctrl_operacao = (HorizontalAlignment)100000;
				Geral.Equipamento_selecionado = (HorizontalAlignment)830;
				Geral.Equipamento_versao = (HorizontalAlignment)2;
				Geral.Equipamento_build = (HorizontalAlignment)0;
				RT_geral.Lmte_Init_ok = false;
				MyProject.Forms.Plataforma.Seleciona_tela(true);
			}
			else if (num == (DialogResult)831)
			{
				Geral.Ctrl_equipamento = (HorizontalAlignment)6000;
				Geral.Ctrl_versao = (HorizontalAlignment)20;
				Geral.Ctrl_operacao = (HorizontalAlignment)100000;
				Geral.Equipamento_selecionado = (HorizontalAlignment)831;
				Geral.Equipamento_versao = (HorizontalAlignment)2;
				Geral.Equipamento_build = (HorizontalAlignment)0;
				RT_geral.Lmte_Init_ok = false;
				MyProject.Forms.Plataforma.Seleciona_tela(true);
			}
			else if (num == (DialogResult)850)
			{
				Geral.Ctrl_equipamento = (HorizontalAlignment)4000;
				Geral.Ctrl_versao = (HorizontalAlignment)30;
				Geral.Ctrl_operacao = (HorizontalAlignment)100000;
				Geral.Equipamento_selecionado = (HorizontalAlignment)850;
				Geral.Equipamento_versao = (HorizontalAlignment)3;
				Geral.Equipamento_build = (HorizontalAlignment)0;
				RT_geral.Lmte_Init_ok = false;
				MyProject.Forms.Plataforma.Seleciona_tela(true);
			}
			else if (num == (DialogResult)855)
			{
				Geral.Ctrl_equipamento = (HorizontalAlignment)8000;
				Geral.Ctrl_versao = (HorizontalAlignment)30;
				Geral.Ctrl_operacao = (HorizontalAlignment)100000;
				Geral.Equipamento_selecionado = (HorizontalAlignment)855;
				Geral.Equipamento_versao = (HorizontalAlignment)3;
				Geral.Equipamento_build = (HorizontalAlignment)0;
				RT_geral.Lmte_Init_ok = false;
				MyProject.Forms.Plataforma.Seleciona_tela(true);
			}
			else if (num == (DialogResult)856)
			{
				Geral.Ctrl_equipamento = (HorizontalAlignment)9000;
				Geral.Ctrl_versao = (HorizontalAlignment)30;
				Geral.Ctrl_operacao = (HorizontalAlignment)100000;
				Geral.Equipamento_selecionado = (HorizontalAlignment)856;
				Geral.Equipamento_versao = (HorizontalAlignment)3;
				Geral.Equipamento_build = (HorizontalAlignment)0;
				RT_geral.Lmte_Init_ok = false;
				MyProject.Forms.Plataforma.Seleciona_tela(true);
			}
			else if ((num == (DialogResult)824 || num == (DialogResult)828 || num == (DialogResult)920) && this.versao == (DialogResult)3)
			{
				Geral.Ctrl_equipamento = (HorizontalAlignment)7000;
				Geral.Ctrl_versao = (HorizontalAlignment)30;
				Geral.Ctrl_operacao = (HorizontalAlignment)100000;
				Geral.Equipamento_selecionado = this.equipamento;
				Geral.Equipamento_versao = (HorizontalAlignment)3;
				Geral.Equipamento_build = (HorizontalAlignment)0;
				RT_geral.Lmte_Init_ok = false;
				MyProject.Forms.Plataforma.Seleciona_tela(true);
			}
		}

		// Token: 0x040001D4 RID: 468
		[AccessedThroughProperty("GroupBox_informacoes")]
		private GroupBox _GroupBox_informacoes;

		// Token: 0x040001D5 RID: 469
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		// Token: 0x040001D6 RID: 470
		[AccessedThroughProperty("TextBox_equipamento")]
		private TextBox _TextBox_equipamento;

		// Token: 0x040001D7 RID: 471
		[AccessedThroughProperty("Label_equipamento")]
		private Label _Label_equipamento;

		// Token: 0x040001D8 RID: 472
		[AccessedThroughProperty("TextBox_release")]
		private TextBox _TextBox_release;

		// Token: 0x040001D9 RID: 473
		[AccessedThroughProperty("Label_release")]
		private Label _Label_release;

		// Token: 0x040001DA RID: 474
		[AccessedThroughProperty("TextBox_build")]
		private TextBox _TextBox_build;

		// Token: 0x040001DB RID: 475
		[AccessedThroughProperty("Label_build")]
		private Label _Label_build;

		// Token: 0x040001DC RID: 476
		[AccessedThroughProperty("TextBox_versao")]
		private TextBox _TextBox_versao;

		// Token: 0x040001DD RID: 477
		[AccessedThroughProperty("Label_versao")]
		private Label _Label_versao;

		// Token: 0x040001DE RID: 478
		[AccessedThroughProperty("bt_Configuracao")]
		private Button _bt_Configuracao;

		// Token: 0x040001DF RID: 479
		public int equipamento;

		// Token: 0x040001E0 RID: 480
		public int versao;

		// Token: 0x040001E1 RID: 481
		public int build;

		// Token: 0x040001E2 RID: 482
		public int release;
	}
}
