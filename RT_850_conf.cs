using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iS800.My;
using iS800.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using VR.PrintPreview;

namespace iS800
{
	// Token: 0x02000037 RID: 55
	[DesignerGenerated]
	public partial class RT_850_conf : Form
	{
		// Token: 0x060009BA RID: 2490 RVA: 0x002C7BD8 File Offset: 0x002C5FD8
		public RT_850_conf()
		{
			base.FormClosed += new FormClosedEventHandler(this.RT_850_conf_FormClosed);
			base.FormClosing += new FormClosingEventHandler(this.RT_850_conf_FormClosing);
			base.Load += new EventHandler(this.RT_850_conf_Load);
			base.Activated += new EventHandler(this.RT_850_conf_Activated);
			this.InitializeComponent();
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x002CFE70 File Offset: 0x002CE270
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x002CFE84 File Offset: 0x002CE284
		internal virtual ToolStrip ToolStri_RT850
		{
			get
			{
				return this._ToolStri_RT850;
			}
			[MethodImpl(32)]
			set
			{
				ToolStripItemClickedEventHandler toolStripItemClickedEventHandler = new ToolStripItemClickedEventHandler(this.ToolStri_RT850_ItemClicked);
				if (this._ToolStri_RT850 != null)
				{
					this._ToolStri_RT850.ItemClicked -= toolStripItemClickedEventHandler;
				}
				this._ToolStri_RT850 = value;
				if (this._ToolStri_RT850 != null)
				{
					this._ToolStri_RT850.ItemClicked += toolStripItemClickedEventHandler;
				}
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x002CFED0 File Offset: 0x002CE2D0
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x002CFEE4 File Offset: 0x002CE2E4
		internal virtual ToolStripButton ToolStripButton_RT850_novo
		{
			get
			{
				return this._ToolStripButton_RT850_novo;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT850_novo_Click);
				if (this._ToolStripButton_RT850_novo != null)
				{
					this._ToolStripButton_RT850_novo.Click -= eventHandler;
				}
				this._ToolStripButton_RT850_novo = value;
				if (this._ToolStripButton_RT850_novo != null)
				{
					this._ToolStripButton_RT850_novo.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x002CFF30 File Offset: 0x002CE330
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x002CFF44 File Offset: 0x002CE344
		internal virtual ToolStripButton ToolStripButton_RT850_Abrir
		{
			get
			{
				return this._ToolStripButton_RT850_Abrir;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT850_Abrir_Click);
				if (this._ToolStripButton_RT850_Abrir != null)
				{
					this._ToolStripButton_RT850_Abrir.Click -= eventHandler;
				}
				this._ToolStripButton_RT850_Abrir = value;
				if (this._ToolStripButton_RT850_Abrir != null)
				{
					this._ToolStripButton_RT850_Abrir.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x002CFF90 File Offset: 0x002CE390
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x002CFFA4 File Offset: 0x002CE3A4
		internal virtual ToolStripButton ToolStripButton_RT850_Salvar
		{
			get
			{
				return this._ToolStripButton_RT850_Salvar;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT850_Salvar_Click);
				if (this._ToolStripButton_RT850_Salvar != null)
				{
					this._ToolStripButton_RT850_Salvar.Click -= eventHandler;
				}
				this._ToolStripButton_RT850_Salvar = value;
				if (this._ToolStripButton_RT850_Salvar != null)
				{
					this._ToolStripButton_RT850_Salvar.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x002CFFF0 File Offset: 0x002CE3F0
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x002D0004 File Offset: 0x002CE404
		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			get
			{
				return this._ToolStripSeparator1;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripSeparator1 = value;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x002D0010 File Offset: 0x002CE410
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x002D0024 File Offset: 0x002CE424
		internal virtual ToolStripButton ToolStripButton_RT850_Download
		{
			get
			{
				return this._ToolStripButton_RT850_Download;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT850_Download_Click);
				if (this._ToolStripButton_RT850_Download != null)
				{
					this._ToolStripButton_RT850_Download.Click -= eventHandler;
				}
				this._ToolStripButton_RT850_Download = value;
				if (this._ToolStripButton_RT850_Download != null)
				{
					this._ToolStripButton_RT850_Download.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x002D0070 File Offset: 0x002CE470
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x002D0084 File Offset: 0x002CE484
		internal virtual ToolStripButton ToolStripButton_RT850_Upload
		{
			get
			{
				return this._ToolStripButton_RT850_Upload;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT850_Upload_Click);
				if (this._ToolStripButton_RT850_Upload != null)
				{
					this._ToolStripButton_RT850_Upload.Click -= eventHandler;
				}
				this._ToolStripButton_RT850_Upload = value;
				if (this._ToolStripButton_RT850_Upload != null)
				{
					this._ToolStripButton_RT850_Upload.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x002D00D0 File Offset: 0x002CE4D0
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x002D00E4 File Offset: 0x002CE4E4
		internal virtual ToolStripSeparator ToolStripSeparator2
		{
			get
			{
				return this._ToolStripSeparator2;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripSeparator2 = value;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x002D00F0 File Offset: 0x002CE4F0
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x002D0104 File Offset: 0x002CE504
		internal virtual ToolStripTextBox ToolStripTextBox_RT850_Msg
		{
			get
			{
				return this._ToolStripTextBox_RT850_Msg;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripTextBox_RT850_Msg = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x002D0110 File Offset: 0x002CE510
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x002D0124 File Offset: 0x002CE524
		internal virtual ToolStripProgressBar ToolStripProgressBar_RT850
		{
			get
			{
				return this._ToolStripProgressBar_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripProgressBar_RT850 = value;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x002D0130 File Offset: 0x002CE530
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x002D0144 File Offset: 0x002CE544
		internal virtual TabControl TabControl_850
		{
			get
			{
				return this._TabControl_850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TabControl_850_SelectedIndexChanged);
				if (this._TabControl_850 != null)
				{
					this._TabControl_850.SelectedIndexChanged -= eventHandler;
				}
				this._TabControl_850 = value;
				if (this._TabControl_850 != null)
				{
					this._TabControl_850.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x002D0190 File Offset: 0x002CE590
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x002D01A4 File Offset: 0x002CE5A4
		internal virtual TabPage TabPage_geral
		{
			get
			{
				return this._TabPage_geral;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_geral = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x002D01B0 File Offset: 0x002CE5B0
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x002D01C4 File Offset: 0x002CE5C4
		internal virtual GroupBox GroupBox_descricao_RT850
		{
			get
			{
				return this._GroupBox_descricao_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_descricao_RT850 = value;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x002D01D0 File Offset: 0x002CE5D0
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x002D01E4 File Offset: 0x002CE5E4
		internal virtual TextBox TextBox_comentarios_RT850
		{
			get
			{
				return this._TextBox_comentarios_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_comentarios_RT850 = value;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x002D01F0 File Offset: 0x002CE5F0
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x002D0204 File Offset: 0x002CE604
		internal virtual TextBox TextBox_endereco_RT850
		{
			get
			{
				return this._TextBox_endereco_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_endereco_RT850 = value;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x002D0210 File Offset: 0x002CE610
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x002D0224 File Offset: 0x002CE624
		internal virtual TextBox TextBox_nome_RT850
		{
			get
			{
				return this._TextBox_nome_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_nome_RT850 = value;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x002D0230 File Offset: 0x002CE630
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x002D0244 File Offset: 0x002CE644
		internal virtual Label Label_comentarios_RT850
		{
			get
			{
				return this._Label_comentarios_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_comentarios_RT850 = value;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x002D0250 File Offset: 0x002CE650
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x002D0264 File Offset: 0x002CE664
		internal virtual Label Label_endereco_RT850
		{
			get
			{
				return this._Label_endereco_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_endereco_RT850 = value;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x002D0270 File Offset: 0x002CE670
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x002D0284 File Offset: 0x002CE684
		internal virtual Label Label_nome_RT850
		{
			get
			{
				return this._Label_nome_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nome_RT850 = value;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x002D0290 File Offset: 0x002CE690
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x002D02A4 File Offset: 0x002CE6A4
		internal virtual GroupBox GroupBox_informacoes_RT850
		{
			get
			{
				return this._GroupBox_informacoes_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_informacoes_RT850 = value;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x002D02B0 File Offset: 0x002CE6B0
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x002D02C4 File Offset: 0x002CE6C4
		internal virtual GroupBox GroupBox_resumo_RT850
		{
			get
			{
				return this._GroupBox_resumo_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_resumo_RT850 = value;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x002D02D0 File Offset: 0x002CE6D0
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x002D02E4 File Offset: 0x002CE6E4
		internal virtual TabPage TabPage_controles
		{
			get
			{
				return this._TabPage_controles;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_controles = value;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x002D02F0 File Offset: 0x002CE6F0
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x002D0304 File Offset: 0x002CE704
		internal virtual TabPage TabPage_variaveis_RT850
		{
			get
			{
				return this._TabPage_variaveis_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_variaveis_RT850 = value;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x002D0310 File Offset: 0x002CE710
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x002D0324 File Offset: 0x002CE724
		internal virtual TabPage TabPage_Ctrl_1_controle
		{
			get
			{
				return this._TabPage_Ctrl_1_controle;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_Ctrl_1_controle = value;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x002D0330 File Offset: 0x002CE730
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x002D0344 File Offset: 0x002CE744
		internal virtual GroupBox GroupBox_Ctrl_1_RT850
		{
			get
			{
				return this._GroupBox_Ctrl_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_Ctrl_1_RT850 = value;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x002D0350 File Offset: 0x002CE750
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x002D0364 File Offset: 0x002CE764
		internal virtual DataGridView DataGridView_Ctrl_1_RT850
		{
			get
			{
				return this._DataGridView_Ctrl_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_Ctrl_1_RT850_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_Ctrl_1_RT850_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_Ctrl_1_RT850_CellValidating);
				if (this._DataGridView_Ctrl_1_RT850 != null)
				{
					this._DataGridView_Ctrl_1_RT850.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_Ctrl_1_RT850.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_Ctrl_1_RT850.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_Ctrl_1_RT850 = value;
				if (this._DataGridView_Ctrl_1_RT850 != null)
				{
					this._DataGridView_Ctrl_1_RT850.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_Ctrl_1_RT850.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_Ctrl_1_RT850.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x002D03FC File Offset: 0x002CE7FC
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x002D0410 File Offset: 0x002CE810
		internal virtual TabPage TabPage_Ctrl_4_controle
		{
			get
			{
				return this._TabPage_Ctrl_4_controle;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_Ctrl_4_controle = value;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x002D041C File Offset: 0x002CE81C
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x002D0430 File Offset: 0x002CE830
		internal virtual TabPage TabPage_Ctrl_8_controle
		{
			get
			{
				return this._TabPage_Ctrl_8_controle;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_Ctrl_8_controle = value;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x002D043C File Offset: 0x002CE83C
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x002D0450 File Offset: 0x002CE850
		internal virtual TabPage TabPage_Vista
		{
			get
			{
				return this._TabPage_Vista;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_Vista = value;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x002D045C File Offset: 0x002CE85C
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x002D0470 File Offset: 0x002CE870
		internal virtual GroupBox GroupBox_canal_1_RT850
		{
			get
			{
				return this._GroupBox_canal_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_canal_1_RT850 = value;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x002D047C File Offset: 0x002CE87C
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x002D0490 File Offset: 0x002CE890
		internal virtual GroupBox GroupBox_variaveis_RT850
		{
			get
			{
				return this._GroupBox_variaveis_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_variaveis_RT850 = value;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x002D049C File Offset: 0x002CE89C
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x002D04B0 File Offset: 0x002CE8B0
		internal virtual DataGridView DataGridView_variaveis_RT850
		{
			get
			{
				return this._DataGridView_variaveis_RT850;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_variaveis_RT850_CellContentClick);
				EventHandler eventHandler = new EventHandler(this.DataGridView_variaveis_RT850_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler2 = new DataGridViewCellEventHandler(this.DataGridView_variaveis_RT850_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_variaveis_RT850_CellValidating);
				if (this._DataGridView_variaveis_RT850 != null)
				{
					this._DataGridView_variaveis_RT850.CellContentClick -= dataGridViewCellEventHandler;
					this._DataGridView_variaveis_RT850.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_variaveis_RT850.CellValueChanged -= dataGridViewCellEventHandler2;
					this._DataGridView_variaveis_RT850.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_variaveis_RT850 = value;
				if (this._DataGridView_variaveis_RT850 != null)
				{
					this._DataGridView_variaveis_RT850.CellContentClick += dataGridViewCellEventHandler;
					this._DataGridView_variaveis_RT850.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_variaveis_RT850.CellValueChanged += dataGridViewCellEventHandler2;
					this._DataGridView_variaveis_RT850.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x002D056C File Offset: 0x002CE96C
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x002D0580 File Offset: 0x002CE980
		internal virtual Label Label_end_canal_1_RT850
		{
			get
			{
				return this._Label_end_canal_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_canal_1_RT850 = value;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x002D058C File Offset: 0x002CE98C
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x002D05A0 File Offset: 0x002CE9A0
		internal virtual Label Label_intervalo_leitura_1_RT850
		{
			get
			{
				return this._Label_intervalo_leitura_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_intervalo_leitura_1_RT850 = value;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x002D05AC File Offset: 0x002CE9AC
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x002D05C0 File Offset: 0x002CE9C0
		internal virtual ComboBox ComboBox_baudrate_1_RT850
		{
			get
			{
				return this._ComboBox_baudrate_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_baudrate_1_RT850_SelectedIndexChanged);
				if (this._ComboBox_baudrate_1_RT850 != null)
				{
					this._ComboBox_baudrate_1_RT850.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_baudrate_1_RT850 = value;
				if (this._ComboBox_baudrate_1_RT850 != null)
				{
					this._ComboBox_baudrate_1_RT850.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x002D060C File Offset: 0x002CEA0C
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x002D0620 File Offset: 0x002CEA20
		internal virtual Label Label_baudrate_1_RT850
		{
			get
			{
				return this._Label_baudrate_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_baudrate_1_RT850 = value;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x002D062C File Offset: 0x002CEA2C
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x002D0640 File Offset: 0x002CEA40
		internal virtual NumericUpDown NumericUpDown_timeout_1_RT850
		{
			get
			{
				return this._NumericUpDown_timeout_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_timeout_1_RT850_ValueChanged);
				if (this._NumericUpDown_timeout_1_RT850 != null)
				{
					this._NumericUpDown_timeout_1_RT850.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_timeout_1_RT850 = value;
				if (this._NumericUpDown_timeout_1_RT850 != null)
				{
					this._NumericUpDown_timeout_1_RT850.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x002D068C File Offset: 0x002CEA8C
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x002D06A0 File Offset: 0x002CEAA0
		internal virtual Label Label_timeout_1_RT850
		{
			get
			{
				return this._Label_timeout_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_timeout_1_RT850 = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x002D06AC File Offset: 0x002CEAAC
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x002D06C0 File Offset: 0x002CEAC0
		internal virtual NumericUpDown NumericUpDown_num_tentativas_1_RT850
		{
			get
			{
				return this._NumericUpDown_num_tentativas_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_num_tentativas_1_RT850_ValueChanged);
				if (this._NumericUpDown_num_tentativas_1_RT850 != null)
				{
					this._NumericUpDown_num_tentativas_1_RT850.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_num_tentativas_1_RT850 = value;
				if (this._NumericUpDown_num_tentativas_1_RT850 != null)
				{
					this._NumericUpDown_num_tentativas_1_RT850.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x002D070C File Offset: 0x002CEB0C
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x002D0720 File Offset: 0x002CEB20
		internal virtual Label Label_num_tentativas_1_RT850
		{
			get
			{
				return this._Label_num_tentativas_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_num_tentativas_1_RT850 = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x002D072C File Offset: 0x002CEB2C
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x002D0740 File Offset: 0x002CEB40
		internal virtual NumericUpDown NumericUpDown_temp_ptt_1_RT850
		{
			get
			{
				return this._NumericUpDown_temp_ptt_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_temp_ptt_1_RT850_ValueChanged);
				if (this._NumericUpDown_temp_ptt_1_RT850 != null)
				{
					this._NumericUpDown_temp_ptt_1_RT850.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_temp_ptt_1_RT850 = value;
				if (this._NumericUpDown_temp_ptt_1_RT850 != null)
				{
					this._NumericUpDown_temp_ptt_1_RT850.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x002D078C File Offset: 0x002CEB8C
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x002D07A0 File Offset: 0x002CEBA0
		internal virtual Label Label_tempo_ptt_1_RT850
		{
			get
			{
				return this._Label_tempo_ptt_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_ptt_1_RT850 = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x002D07AC File Offset: 0x002CEBAC
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x002D07C0 File Offset: 0x002CEBC0
		internal virtual NumericUpDown NumericUpDown_num_erro_falha_1_RT850
		{
			get
			{
				return this._NumericUpDown_num_erro_falha_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_num_erro_falha_1_RT850_ValueChanged);
				if (this._NumericUpDown_num_erro_falha_1_RT850 != null)
				{
					this._NumericUpDown_num_erro_falha_1_RT850.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_num_erro_falha_1_RT850 = value;
				if (this._NumericUpDown_num_erro_falha_1_RT850 != null)
				{
					this._NumericUpDown_num_erro_falha_1_RT850.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x002D080C File Offset: 0x002CEC0C
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x002D0820 File Offset: 0x002CEC20
		internal virtual Label Label_num_erro_falha_1_RT850
		{
			get
			{
				return this._Label_num_erro_falha_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_num_erro_falha_1_RT850 = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x002D082C File Offset: 0x002CEC2C
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x002D0840 File Offset: 0x002CEC40
		internal virtual NumericUpDown NumericUpDown_intervalo_leitura_1_RT850
		{
			get
			{
				return this._NumericUpDown_intervalo_leitura_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_intervalo_leitura_1_RT850_ValueChanged);
				if (this._NumericUpDown_intervalo_leitura_1_RT850 != null)
				{
					this._NumericUpDown_intervalo_leitura_1_RT850.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_intervalo_leitura_1_RT850 = value;
				if (this._NumericUpDown_intervalo_leitura_1_RT850 != null)
				{
					this._NumericUpDown_intervalo_leitura_1_RT850.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x002D088C File Offset: 0x002CEC8C
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x002D08A0 File Offset: 0x002CECA0
		internal virtual NumericUpDown NumericUpDown_end_1_RT850
		{
			get
			{
				return this._NumericUpDown_end_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_1_RT850_ValueChanged);
				if (this._NumericUpDown_end_1_RT850 != null)
				{
					this._NumericUpDown_end_1_RT850.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_1_RT850 = value;
				if (this._NumericUpDown_end_1_RT850 != null)
				{
					this._NumericUpDown_end_1_RT850.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x002D08EC File Offset: 0x002CECEC
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x002D0900 File Offset: 0x002CED00
		internal virtual GroupBox GroupBox_canal_2_RT850
		{
			get
			{
				return this._GroupBox_canal_2_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_canal_2_RT850 = value;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x002D090C File Offset: 0x002CED0C
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x002D0920 File Offset: 0x002CED20
		internal virtual NumericUpDown NumericUpDown_intervalo_leitura_2_RT850
		{
			get
			{
				return this._NumericUpDown_intervalo_leitura_2_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_intervalo_leitura_2_RT850_ValueChanged);
				if (this._NumericUpDown_intervalo_leitura_2_RT850 != null)
				{
					this._NumericUpDown_intervalo_leitura_2_RT850.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_intervalo_leitura_2_RT850 = value;
				if (this._NumericUpDown_intervalo_leitura_2_RT850 != null)
				{
					this._NumericUpDown_intervalo_leitura_2_RT850.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x002D096C File Offset: 0x002CED6C
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x002D0980 File Offset: 0x002CED80
		internal virtual NumericUpDown NumericUpDown_end_2_RT850
		{
			get
			{
				return this._NumericUpDown_end_2_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_2_RT850_ValueChanged);
				if (this._NumericUpDown_end_2_RT850 != null)
				{
					this._NumericUpDown_end_2_RT850.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_2_RT850 = value;
				if (this._NumericUpDown_end_2_RT850 != null)
				{
					this._NumericUpDown_end_2_RT850.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x002D09CC File Offset: 0x002CEDCC
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x002D09E0 File Offset: 0x002CEDE0
		internal virtual NumericUpDown NumericUpDown_num_erro_falha_2_RT850
		{
			get
			{
				return this._NumericUpDown_num_erro_falha_2_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_num_erro_falha_2_RT850_ValueChanged);
				if (this._NumericUpDown_num_erro_falha_2_RT850 != null)
				{
					this._NumericUpDown_num_erro_falha_2_RT850.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_num_erro_falha_2_RT850 = value;
				if (this._NumericUpDown_num_erro_falha_2_RT850 != null)
				{
					this._NumericUpDown_num_erro_falha_2_RT850.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x002D0A2C File Offset: 0x002CEE2C
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x002D0A40 File Offset: 0x002CEE40
		internal virtual Label Label_num_erro_falha_2_RT850
		{
			get
			{
				return this._Label_num_erro_falha_2_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_num_erro_falha_2_RT850 = value;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x002D0A4C File Offset: 0x002CEE4C
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x002D0A60 File Offset: 0x002CEE60
		internal virtual NumericUpDown NumericUpDown_num_tentativas_2_RT850
		{
			get
			{
				return this._NumericUpDown_num_tentativas_2_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_num_tentativas_2_RT850_ValueChanged);
				if (this._NumericUpDown_num_tentativas_2_RT850 != null)
				{
					this._NumericUpDown_num_tentativas_2_RT850.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_num_tentativas_2_RT850 = value;
				if (this._NumericUpDown_num_tentativas_2_RT850 != null)
				{
					this._NumericUpDown_num_tentativas_2_RT850.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x002D0AAC File Offset: 0x002CEEAC
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x002D0AC0 File Offset: 0x002CEEC0
		internal virtual Label Label_num_tentativas_2_RT850
		{
			get
			{
				return this._Label_num_tentativas_2_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_num_tentativas_2_RT850 = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x002D0ACC File Offset: 0x002CEECC
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x002D0AE0 File Offset: 0x002CEEE0
		internal virtual NumericUpDown NumericUpDown_temp_ptt_2_RT850
		{
			get
			{
				return this._NumericUpDown_temp_ptt_2_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_temp_ptt_2_RT850_ValueChanged);
				if (this._NumericUpDown_temp_ptt_2_RT850 != null)
				{
					this._NumericUpDown_temp_ptt_2_RT850.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_temp_ptt_2_RT850 = value;
				if (this._NumericUpDown_temp_ptt_2_RT850 != null)
				{
					this._NumericUpDown_temp_ptt_2_RT850.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x002D0B2C File Offset: 0x002CEF2C
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x002D0B40 File Offset: 0x002CEF40
		internal virtual Label Label_tempo_ptt_2_RT850
		{
			get
			{
				return this._Label_tempo_ptt_2_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_ptt_2_RT850 = value;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x002D0B4C File Offset: 0x002CEF4C
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x002D0B60 File Offset: 0x002CEF60
		internal virtual NumericUpDown NumericUpDown_timeout_2_RT850
		{
			get
			{
				return this._NumericUpDown_timeout_2_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_timeout_2_RT850_ValueChanged);
				if (this._NumericUpDown_timeout_2_RT850 != null)
				{
					this._NumericUpDown_timeout_2_RT850.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_timeout_2_RT850 = value;
				if (this._NumericUpDown_timeout_2_RT850 != null)
				{
					this._NumericUpDown_timeout_2_RT850.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x002D0BAC File Offset: 0x002CEFAC
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x002D0BC0 File Offset: 0x002CEFC0
		internal virtual Label Label_timeout_2_RT850
		{
			get
			{
				return this._Label_timeout_2_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_timeout_2_RT850 = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x002D0BCC File Offset: 0x002CEFCC
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x002D0BE0 File Offset: 0x002CEFE0
		internal virtual ComboBox ComboBox_baudrate_2_RT850
		{
			get
			{
				return this._ComboBox_baudrate_2_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_baudrate_2_RT850_SelectedIndexChanged);
				if (this._ComboBox_baudrate_2_RT850 != null)
				{
					this._ComboBox_baudrate_2_RT850.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_baudrate_2_RT850 = value;
				if (this._ComboBox_baudrate_2_RT850 != null)
				{
					this._ComboBox_baudrate_2_RT850.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x002D0C2C File Offset: 0x002CF02C
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x002D0C40 File Offset: 0x002CF040
		internal virtual Label Label_baudrate_2_RT850
		{
			get
			{
				return this._Label_baudrate_2_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_baudrate_2_RT850 = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x002D0C4C File Offset: 0x002CF04C
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x002D0C60 File Offset: 0x002CF060
		internal virtual Label Label_intervalo_leitura_2_RT850
		{
			get
			{
				return this._Label_intervalo_leitura_2_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_intervalo_leitura_2_RT850 = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x002D0C6C File Offset: 0x002CF06C
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x002D0C80 File Offset: 0x002CF080
		internal virtual Label Label_end_canal_2_RT850
		{
			get
			{
				return this._Label_end_canal_2_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_canal_2_RT850 = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x002D0C8C File Offset: 0x002CF08C
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x002D0CA0 File Offset: 0x002CF0A0
		internal virtual GroupBox GroupBox_msg_inicial_RT850
		{
			get
			{
				return this._GroupBox_msg_inicial_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_msg_inicial_RT850 = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x002D0CAC File Offset: 0x002CF0AC
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x002D0CC0 File Offset: 0x002CF0C0
		internal virtual GroupBox GroupBox_sincronismo_RT_850
		{
			get
			{
				return this._GroupBox_sincronismo_RT_850;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_sincronismo_RT_850 = value;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x002D0CCC File Offset: 0x002CF0CC
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x002D0CE0 File Offset: 0x002CF0E0
		internal virtual CheckBox CheckBox_sincronismo_RT850
		{
			get
			{
				return this._CheckBox_sincronismo_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_sincronismo_RT850_CheckedChanged);
				if (this._CheckBox_sincronismo_RT850 != null)
				{
					this._CheckBox_sincronismo_RT850.CheckedChanged -= eventHandler;
				}
				this._CheckBox_sincronismo_RT850 = value;
				if (this._CheckBox_sincronismo_RT850 != null)
				{
					this._CheckBox_sincronismo_RT850.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x002D0D2C File Offset: 0x002CF12C
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x002D0D40 File Offset: 0x002CF140
		internal virtual TextBox TextBox_msg_inicial_RT850
		{
			get
			{
				return this._TextBox_msg_inicial_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox_msg_inicial_RT850_TextChanged);
				if (this._TextBox_msg_inicial_RT850 != null)
				{
					this._TextBox_msg_inicial_RT850.TextChanged -= eventHandler;
				}
				this._TextBox_msg_inicial_RT850 = value;
				if (this._TextBox_msg_inicial_RT850 != null)
				{
					this._TextBox_msg_inicial_RT850.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x002D0D8C File Offset: 0x002CF18C
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x002D0DA0 File Offset: 0x002CF1A0
		internal virtual Button Button_ins_var_RT850
		{
			get
			{
				return this._Button_ins_var_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_ins_var_RT850_Click);
				if (this._Button_ins_var_RT850 != null)
				{
					this._Button_ins_var_RT850.Click -= eventHandler;
				}
				this._Button_ins_var_RT850 = value;
				if (this._Button_ins_var_RT850 != null)
				{
					this._Button_ins_var_RT850.Click += eventHandler;
				}
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x002D0DEC File Offset: 0x002CF1EC
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x002D0E00 File Offset: 0x002CF200
		internal virtual Button Button_del_var_RT850
		{
			get
			{
				return this._Button_del_var_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_del_var_RT850_Click);
				if (this._Button_del_var_RT850 != null)
				{
					this._Button_del_var_RT850.Click -= eventHandler;
				}
				this._Button_del_var_RT850 = value;
				if (this._Button_del_var_RT850 != null)
				{
					this._Button_del_var_RT850.Click += eventHandler;
				}
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x002D0E4C File Offset: 0x002CF24C
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x002D0E60 File Offset: 0x002CF260
		internal virtual GroupBox GroupBox_Ctrl_4_RT850
		{
			get
			{
				return this._GroupBox_Ctrl_4_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_Ctrl_4_RT850 = value;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x002D0E6C File Offset: 0x002CF26C
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x002D0E80 File Offset: 0x002CF280
		internal virtual DataGridView DataGridView_Ctrl_4_RT850
		{
			get
			{
				return this._DataGridView_Ctrl_4_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_Ctrl_4_RT850_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_Ctrl_4_RT850_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_Ctrl_4_RT850_CellValidating);
				if (this._DataGridView_Ctrl_4_RT850 != null)
				{
					this._DataGridView_Ctrl_4_RT850.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_Ctrl_4_RT850.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_Ctrl_4_RT850.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_Ctrl_4_RT850 = value;
				if (this._DataGridView_Ctrl_4_RT850 != null)
				{
					this._DataGridView_Ctrl_4_RT850.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_Ctrl_4_RT850.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_Ctrl_4_RT850.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x002D0F18 File Offset: 0x002CF318
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x002D0F2C File Offset: 0x002CF32C
		internal virtual GroupBox GroupBox_Ctrl_8_RT850
		{
			get
			{
				return this._GroupBox_Ctrl_8_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_Ctrl_8_RT850 = value;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x002D0F38 File Offset: 0x002CF338
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x002D0F4C File Offset: 0x002CF34C
		internal virtual DataGridView DataGridView_Ctrl_8_RT850
		{
			get
			{
				return this._DataGridView_Ctrl_8_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_Ctrl_8_RT850_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_Ctrl_8_RT850_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_Ctrl_8_RT850_CellValidating);
				if (this._DataGridView_Ctrl_8_RT850 != null)
				{
					this._DataGridView_Ctrl_8_RT850.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_Ctrl_8_RT850.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_Ctrl_8_RT850.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_Ctrl_8_RT850 = value;
				if (this._DataGridView_Ctrl_8_RT850 != null)
				{
					this._DataGridView_Ctrl_8_RT850.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_Ctrl_8_RT850.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_Ctrl_8_RT850.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x002D0FE4 File Offset: 0x002CF3E4
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x002D0FF8 File Offset: 0x002CF3F8
		internal virtual OpenFileDialog OpenFileDialog_RT850
		{
			get
			{
				return this._OpenFileDialog_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._OpenFileDialog_RT850 = value;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x002D1004 File Offset: 0x002CF404
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x002D1018 File Offset: 0x002CF418
		internal virtual SaveFileDialog SaveFileDialog_RT850
		{
			get
			{
				return this._SaveFileDialog_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._SaveFileDialog_RT850 = value;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x002D1024 File Offset: 0x002CF424
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x002D1038 File Offset: 0x002CF438
		internal virtual Timer Timer_limpa_MSG_RT850
		{
			get
			{
				return this._Timer_limpa_MSG_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer_limpa_MSG_RT850_Tick);
				if (this._Timer_limpa_MSG_RT850 != null)
				{
					this._Timer_limpa_MSG_RT850.Tick -= eventHandler;
				}
				this._Timer_limpa_MSG_RT850 = value;
				if (this._Timer_limpa_MSG_RT850 != null)
				{
					this._Timer_limpa_MSG_RT850.Tick += eventHandler;
				}
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x002D1084 File Offset: 0x002CF484
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x002D1098 File Offset: 0x002CF498
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

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x002D10E4 File Offset: 0x002CF4E4
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x002D10F8 File Offset: 0x002CF4F8
		internal virtual GroupBox GroupBox_Vista_RT850
		{
			get
			{
				return this._GroupBox_Vista_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_Vista_RT850 = value;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x002D1104 File Offset: 0x002CF504
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x002D1118 File Offset: 0x002CF518
		internal virtual DataGridView DataGridView_vista_variaveis_RT_850
		{
			get
			{
				return this._DataGridView_vista_variaveis_RT_850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_vista_variaveis_RT_850_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_vista_variaveis_RT_850_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_vista_variaveis_RT_850_CellValidating);
				if (this._DataGridView_vista_variaveis_RT_850 != null)
				{
					this._DataGridView_vista_variaveis_RT_850.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_vista_variaveis_RT_850.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_vista_variaveis_RT_850.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_vista_variaveis_RT_850 = value;
				if (this._DataGridView_vista_variaveis_RT_850 != null)
				{
					this._DataGridView_vista_variaveis_RT_850.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_vista_variaveis_RT_850.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_vista_variaveis_RT_850.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x002D11B0 File Offset: 0x002CF5B0
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x002D11C4 File Offset: 0x002CF5C4
		internal virtual GroupBox GroupBox_parametros_vista
		{
			get
			{
				return this._GroupBox_parametros_vista;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_parametros_vista = value;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x002D11D0 File Offset: 0x002CF5D0
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x002D11E4 File Offset: 0x002CF5E4
		internal virtual ComboBox ComboBox_Seleciona_Vista_RT_850
		{
			get
			{
				return this._ComboBox_Seleciona_Vista_RT_850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_Seleciona_Vista_RT_850_SelectedIndexChanged);
				if (this._ComboBox_Seleciona_Vista_RT_850 != null)
				{
					this._ComboBox_Seleciona_Vista_RT_850.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_Seleciona_Vista_RT_850 = value;
				if (this._ComboBox_Seleciona_Vista_RT_850 != null)
				{
					this._ComboBox_Seleciona_Vista_RT_850.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x002D1230 File Offset: 0x002CF630
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x002D1244 File Offset: 0x002CF644
		internal virtual GroupBox GroupBox_variaveis
		{
			get
			{
				return this._GroupBox_variaveis;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_variaveis = value;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x002D1250 File Offset: 0x002CF650
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x002D1264 File Offset: 0x002CF664
		internal virtual GroupBox GroupBox_equipamentos_vista
		{
			get
			{
				return this._GroupBox_equipamentos_vista;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_equipamentos_vista = value;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x002D1270 File Offset: 0x002CF670
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x002D1284 File Offset: 0x002CF684
		internal virtual DataGridView DataGridView_vista_equipamentos_RT_850
		{
			get
			{
				return this._DataGridView_vista_equipamentos_RT_850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_vista_equipamentos_RT_850_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_vista_equipamentos_RT_850_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_vista_equipamentos_RT_850_CellValidating);
				if (this._DataGridView_vista_equipamentos_RT_850 != null)
				{
					this._DataGridView_vista_equipamentos_RT_850.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_vista_equipamentos_RT_850.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_vista_equipamentos_RT_850.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_vista_equipamentos_RT_850 = value;
				if (this._DataGridView_vista_equipamentos_RT_850 != null)
				{
					this._DataGridView_vista_equipamentos_RT_850.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_vista_equipamentos_RT_850.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_vista_equipamentos_RT_850.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x002D131C File Offset: 0x002CF71C
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x002D1330 File Offset: 0x002CF730
		internal virtual Label Label_nome_vista
		{
			get
			{
				return this._Label_nome_vista;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nome_vista = value;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x002D133C File Offset: 0x002CF73C
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x002D1350 File Offset: 0x002CF750
		internal virtual TextBox TextBox_nome_vista
		{
			get
			{
				return this._TextBox_nome_vista;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox_nome_vista_TextChanged);
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.TextBox_nome_vista_Validating);
				if (this._TextBox_nome_vista != null)
				{
					this._TextBox_nome_vista.TextChanged -= eventHandler;
					this._TextBox_nome_vista.Validating -= cancelEventHandler;
				}
				this._TextBox_nome_vista = value;
				if (this._TextBox_nome_vista != null)
				{
					this._TextBox_nome_vista.TextChanged += eventHandler;
					this._TextBox_nome_vista.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x002D13C0 File Offset: 0x002CF7C0
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x002D13D4 File Offset: 0x002CF7D4
		internal virtual ComboBox ComboBox_porta_vista_RT_850
		{
			get
			{
				return this._ComboBox_porta_vista_RT_850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_porta_vista_RT_850_SelectedIndexChanged);
				if (this._ComboBox_porta_vista_RT_850 != null)
				{
					this._ComboBox_porta_vista_RT_850.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_porta_vista_RT_850 = value;
				if (this._ComboBox_porta_vista_RT_850 != null)
				{
					this._ComboBox_porta_vista_RT_850.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x002D1420 File Offset: 0x002CF820
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x002D1434 File Offset: 0x002CF834
		internal virtual Label Label_porta_vista
		{
			get
			{
				return this._Label_porta_vista;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_porta_vista = value;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x002D1440 File Offset: 0x002CF840
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x002D1454 File Offset: 0x002CF854
		internal virtual ComboBox ComboBox_prioridade_vista_RT_850
		{
			get
			{
				return this._ComboBox_prioridade_vista_RT_850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_prioridade_vista_RT_850_SelectedIndexChanged);
				if (this._ComboBox_prioridade_vista_RT_850 != null)
				{
					this._ComboBox_prioridade_vista_RT_850.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_prioridade_vista_RT_850 = value;
				if (this._ComboBox_prioridade_vista_RT_850 != null)
				{
					this._ComboBox_prioridade_vista_RT_850.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x002D14A0 File Offset: 0x002CF8A0
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x002D14B4 File Offset: 0x002CF8B4
		internal virtual Label Label_prioridade_vista
		{
			get
			{
				return this._Label_prioridade_vista;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_prioridade_vista = value;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x002D14C0 File Offset: 0x002CF8C0
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x002D14D4 File Offset: 0x002CF8D4
		internal virtual ComboBox ComboBox_timeout_vista_RT_850
		{
			get
			{
				return this._ComboBox_timeout_vista_RT_850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_timeout_vista_RT_850_SelectedIndexChanged);
				if (this._ComboBox_timeout_vista_RT_850 != null)
				{
					this._ComboBox_timeout_vista_RT_850.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_timeout_vista_RT_850 = value;
				if (this._ComboBox_timeout_vista_RT_850 != null)
				{
					this._ComboBox_timeout_vista_RT_850.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x002D1520 File Offset: 0x002CF920
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x002D1534 File Offset: 0x002CF934
		internal virtual Label Label_timeout_vista
		{
			get
			{
				return this._Label_timeout_vista;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_timeout_vista = value;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x002D1540 File Offset: 0x002CF940
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x002D1554 File Offset: 0x002CF954
		internal virtual NumericUpDown NumericUpDown_num_equip_vista
		{
			get
			{
				return this._NumericUpDown_num_equip_vista;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_num_equip_vista_ValueChanged);
				if (this._NumericUpDown_num_equip_vista != null)
				{
					this._NumericUpDown_num_equip_vista.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_num_equip_vista = value;
				if (this._NumericUpDown_num_equip_vista != null)
				{
					this._NumericUpDown_num_equip_vista.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x002D15A0 File Offset: 0x002CF9A0
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x002D15B4 File Offset: 0x002CF9B4
		internal virtual Label Label_num_equip_vista
		{
			get
			{
				return this._Label_num_equip_vista;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_num_equip_vista = value;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x002D15C0 File Offset: 0x002CF9C0
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x002D15D4 File Offset: 0x002CF9D4
		internal virtual NumericUpDown NumericUpDown_num_var_vista
		{
			get
			{
				return this._NumericUpDown_num_var_vista;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_num_var_vista_ValueChanged);
				if (this._NumericUpDown_num_var_vista != null)
				{
					this._NumericUpDown_num_var_vista.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_num_var_vista = value;
				if (this._NumericUpDown_num_var_vista != null)
				{
					this._NumericUpDown_num_var_vista.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x002D1620 File Offset: 0x002CFA20
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x002D1634 File Offset: 0x002CFA34
		internal virtual Label Label_num_var_vista
		{
			get
			{
				return this._Label_num_var_vista;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_num_var_vista = value;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x002D1640 File Offset: 0x002CFA40
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x002D1654 File Offset: 0x002CFA54
		internal virtual ComboBox ComboBox_modelo_vista_RT_850
		{
			get
			{
				return this._ComboBox_modelo_vista_RT_850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_modelo_vista_RT_850_SelectedIndexChanged);
				if (this._ComboBox_modelo_vista_RT_850 != null)
				{
					this._ComboBox_modelo_vista_RT_850.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_modelo_vista_RT_850 = value;
				if (this._ComboBox_modelo_vista_RT_850 != null)
				{
					this._ComboBox_modelo_vista_RT_850.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x002D16A0 File Offset: 0x002CFAA0
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x002D16B4 File Offset: 0x002CFAB4
		internal virtual Label Label_modelo_vista
		{
			get
			{
				return this._Label_modelo_vista;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_modelo_vista = value;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x002D16C0 File Offset: 0x002CFAC0
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x002D16D4 File Offset: 0x002CFAD4
		internal virtual ToolStripButton ToolStripButton_RT850_Imprimir
		{
			get
			{
				return this._ToolStripButton_RT850_Imprimir;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT850_Imprimir_Click);
				if (this._ToolStripButton_RT850_Imprimir != null)
				{
					this._ToolStripButton_RT850_Imprimir.Click -= eventHandler;
				}
				this._ToolStripButton_RT850_Imprimir = value;
				if (this._ToolStripButton_RT850_Imprimir != null)
				{
					this._ToolStripButton_RT850_Imprimir.Click += eventHandler;
				}
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x002D1720 File Offset: 0x002CFB20
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x002D1734 File Offset: 0x002CFB34
		internal virtual ToolStripSeparator ToolStripSeparator3
		{
			get
			{
				return this._ToolStripSeparator3;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripSeparator3 = value;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x002D1740 File Offset: 0x002CFB40
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x002D1754 File Offset: 0x002CFB54
		internal virtual PrintDocument PrintDocument1
		{
			get
			{
				return this._PrintDocument1;
			}
			[MethodImpl(32)]
			set
			{
				PrintPageEventHandler printPageEventHandler = new PrintPageEventHandler(this.PrintDocument1_PrintPage);
				QueryPageSettingsEventHandler queryPageSettingsEventHandler = new QueryPageSettingsEventHandler(this.PrintDocument1_QueryPageSettings);
				PrintEventHandler printEventHandler = new PrintEventHandler(this.PrintDocument1_BeginPrint);
				if (this._PrintDocument1 != null)
				{
					this._PrintDocument1.PrintPage -= printPageEventHandler;
					this._PrintDocument1.QueryPageSettings -= queryPageSettingsEventHandler;
					this._PrintDocument1.BeginPrint -= printEventHandler;
				}
				this._PrintDocument1 = value;
				if (this._PrintDocument1 != null)
				{
					this._PrintDocument1.PrintPage += printPageEventHandler;
					this._PrintDocument1.QueryPageSettings += queryPageSettingsEventHandler;
					this._PrintDocument1.BeginPrint += printEventHandler;
				}
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x002D17EC File Offset: 0x002CFBEC
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x002D1800 File Offset: 0x002CFC00
		internal virtual PrintPreviewDialog PrintPreviewDialog1
		{
			get
			{
				return this._PrintPreviewDialog1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PrintPreviewDialog1_Load);
				if (this._PrintPreviewDialog1 != null)
				{
					this._PrintPreviewDialog1.Load -= eventHandler;
				}
				this._PrintPreviewDialog1 = value;
				if (this._PrintPreviewDialog1 != null)
				{
					this._PrintPreviewDialog1.Load += eventHandler;
				}
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x002D184C File Offset: 0x002CFC4C
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x002D1860 File Offset: 0x002CFC60
		internal virtual TabPage TabPage1
		{
			get
			{
				return this._TabPage1;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage1 = value;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x002D186C File Offset: 0x002CFC6C
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x002D1880 File Offset: 0x002CFC80
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

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x002D188C File Offset: 0x002CFC8C
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x002D18A0 File Offset: 0x002CFCA0
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

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x002D18AC File Offset: 0x002CFCAC
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x002D18C0 File Offset: 0x002CFCC0
		internal virtual Label Label16
		{
			get
			{
				return this._Label16;
			}
			[MethodImpl(32)]
			set
			{
				this._Label16 = value;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x002D18CC File Offset: 0x002CFCCC
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x002D18E0 File Offset: 0x002CFCE0
		internal virtual Label Label15
		{
			get
			{
				return this._Label15;
			}
			[MethodImpl(32)]
			set
			{
				this._Label15 = value;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x002D18EC File Offset: 0x002CFCEC
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x002D1900 File Offset: 0x002CFD00
		internal virtual TextBox T_AlturaAntena1
		{
			get
			{
				return this._T_AlturaAntena1;
			}
			[MethodImpl(32)]
			set
			{
				this._T_AlturaAntena1 = value;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x002D190C File Offset: 0x002CFD0C
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x002D1920 File Offset: 0x002CFD20
		internal virtual TextBox T_Latitude1
		{
			get
			{
				return this._T_Latitude1;
			}
			[MethodImpl(32)]
			set
			{
				this._T_Latitude1 = value;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x002D192C File Offset: 0x002CFD2C
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x002D1940 File Offset: 0x002CFD40
		internal virtual TextBox T_Longitude1
		{
			get
			{
				return this._T_Longitude1;
			}
			[MethodImpl(32)]
			set
			{
				this._T_Longitude1 = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x002D194C File Offset: 0x002CFD4C
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x002D1960 File Offset: 0x002CFD60
		internal virtual TextBox T_Azimute1
		{
			get
			{
				return this._T_Azimute1;
			}
			[MethodImpl(32)]
			set
			{
				this._T_Azimute1 = value;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x002D196C File Offset: 0x002CFD6C
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x002D1980 File Offset: 0x002CFD80
		internal virtual Label Label14
		{
			get
			{
				return this._Label14;
			}
			[MethodImpl(32)]
			set
			{
				this._Label14 = value;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x002D198C File Offset: 0x002CFD8C
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x002D19A0 File Offset: 0x002CFDA0
		internal virtual Label Label13
		{
			get
			{
				return this._Label13;
			}
			[MethodImpl(32)]
			set
			{
				this._Label13 = value;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x002D19AC File Offset: 0x002CFDAC
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x002D19C0 File Offset: 0x002CFDC0
		internal virtual TextBox T_FreqRadio1
		{
			get
			{
				return this._T_FreqRadio1;
			}
			[MethodImpl(32)]
			set
			{
				this._T_FreqRadio1 = value;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x002D19CC File Offset: 0x002CFDCC
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x002D19E0 File Offset: 0x002CFDE0
		internal virtual TextBox T_PotRadio1
		{
			get
			{
				return this._T_PotRadio1;
			}
			[MethodImpl(32)]
			set
			{
				this._T_PotRadio1 = value;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x002D19EC File Offset: 0x002CFDEC
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x002D1A00 File Offset: 0x002CFE00
		internal virtual ComboBox CB_ModeloRadio1
		{
			get
			{
				return this._CB_ModeloRadio1;
			}
			[MethodImpl(32)]
			set
			{
				this._CB_ModeloRadio1 = value;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x002D1A0C File Offset: 0x002CFE0C
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x002D1A20 File Offset: 0x002CFE20
		internal virtual ComboBox CB_PolarizacaoAntena1
		{
			get
			{
				return this._CB_PolarizacaoAntena1;
			}
			[MethodImpl(32)]
			set
			{
				this._CB_PolarizacaoAntena1 = value;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x002D1A2C File Offset: 0x002CFE2C
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x002D1A40 File Offset: 0x002CFE40
		internal virtual ComboBox CB_TipoAntena1
		{
			get
			{
				return this._CB_TipoAntena1;
			}
			[MethodImpl(32)]
			set
			{
				this._CB_TipoAntena1 = value;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x002D1A4C File Offset: 0x002CFE4C
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x002D1A60 File Offset: 0x002CFE60
		internal virtual Label Label10
		{
			get
			{
				return this._Label10;
			}
			[MethodImpl(32)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x002D1A6C File Offset: 0x002CFE6C
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x002D1A80 File Offset: 0x002CFE80
		internal virtual Label Label9
		{
			get
			{
				return this._Label9;
			}
			[MethodImpl(32)]
			set
			{
				this._Label9 = value;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x002D1A8C File Offset: 0x002CFE8C
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x002D1AA0 File Offset: 0x002CFEA0
		internal virtual Label Label8
		{
			get
			{
				return this._Label8;
			}
			[MethodImpl(32)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x002D1AAC File Offset: 0x002CFEAC
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x002D1AC0 File Offset: 0x002CFEC0
		internal virtual Label Label7
		{
			get
			{
				return this._Label7;
			}
			[MethodImpl(32)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x002D1ACC File Offset: 0x002CFECC
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x002D1AE0 File Offset: 0x002CFEE0
		internal virtual Label Label6
		{
			get
			{
				return this._Label6;
			}
			[MethodImpl(32)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x002D1AEC File Offset: 0x002CFEEC
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x002D1B00 File Offset: 0x002CFF00
		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x002D1B0C File Offset: 0x002CFF0C
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x002D1B20 File Offset: 0x002CFF20
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

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x002D1B2C File Offset: 0x002CFF2C
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x002D1B40 File Offset: 0x002CFF40
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

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x002D1B4C File Offset: 0x002CFF4C
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x002D1B60 File Offset: 0x002CFF60
		internal virtual Label Label17
		{
			get
			{
				return this._Label17;
			}
			[MethodImpl(32)]
			set
			{
				this._Label17 = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x002D1B6C File Offset: 0x002CFF6C
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x002D1B80 File Offset: 0x002CFF80
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

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x002D1B8C File Offset: 0x002CFF8C
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x002D1BA0 File Offset: 0x002CFFA0
		internal virtual Label Label5
		{
			get
			{
				return this._Label5;
			}
			[MethodImpl(32)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x002D1BAC File Offset: 0x002CFFAC
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x002D1BC0 File Offset: 0x002CFFC0
		internal virtual TextBox T_AlturaAntena2
		{
			get
			{
				return this._T_AlturaAntena2;
			}
			[MethodImpl(32)]
			set
			{
				this._T_AlturaAntena2 = value;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x002D1BCC File Offset: 0x002CFFCC
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x002D1BE0 File Offset: 0x002CFFE0
		internal virtual TextBox T_Latitude2
		{
			get
			{
				return this._T_Latitude2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.T_Latitude2_TextChanged);
				if (this._T_Latitude2 != null)
				{
					this._T_Latitude2.TextChanged -= eventHandler;
				}
				this._T_Latitude2 = value;
				if (this._T_Latitude2 != null)
				{
					this._T_Latitude2.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x002D1C2C File Offset: 0x002D002C
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x002D1C40 File Offset: 0x002D0040
		internal virtual TextBox T_Longitude2
		{
			get
			{
				return this._T_Longitude2;
			}
			[MethodImpl(32)]
			set
			{
				this._T_Longitude2 = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x002D1C4C File Offset: 0x002D004C
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x002D1C60 File Offset: 0x002D0060
		internal virtual TextBox T_Azimute2
		{
			get
			{
				return this._T_Azimute2;
			}
			[MethodImpl(32)]
			set
			{
				this._T_Azimute2 = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x002D1C6C File Offset: 0x002D006C
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x002D1C80 File Offset: 0x002D0080
		internal virtual Label Label12
		{
			get
			{
				return this._Label12;
			}
			[MethodImpl(32)]
			set
			{
				this._Label12 = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x002D1C8C File Offset: 0x002D008C
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x002D1CA0 File Offset: 0x002D00A0
		internal virtual Label Label18
		{
			get
			{
				return this._Label18;
			}
			[MethodImpl(32)]
			set
			{
				this._Label18 = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x002D1CAC File Offset: 0x002D00AC
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x002D1CC0 File Offset: 0x002D00C0
		internal virtual TextBox T_FreqRadio2
		{
			get
			{
				return this._T_FreqRadio2;
			}
			[MethodImpl(32)]
			set
			{
				this._T_FreqRadio2 = value;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x002D1CCC File Offset: 0x002D00CC
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x002D1CE0 File Offset: 0x002D00E0
		internal virtual TextBox T_PotRadio2
		{
			get
			{
				return this._T_PotRadio2;
			}
			[MethodImpl(32)]
			set
			{
				this._T_PotRadio2 = value;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x002D1CEC File Offset: 0x002D00EC
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x002D1D00 File Offset: 0x002D0100
		internal virtual ComboBox CB_ModeloRadio2
		{
			get
			{
				return this._CB_ModeloRadio2;
			}
			[MethodImpl(32)]
			set
			{
				this._CB_ModeloRadio2 = value;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x002D1D0C File Offset: 0x002D010C
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x002D1D20 File Offset: 0x002D0120
		internal virtual ComboBox CB_PolarizacaoAntena2
		{
			get
			{
				return this._CB_PolarizacaoAntena2;
			}
			[MethodImpl(32)]
			set
			{
				this._CB_PolarizacaoAntena2 = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x002D1D2C File Offset: 0x002D012C
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x002D1D40 File Offset: 0x002D0140
		internal virtual ComboBox CB_TipoAntena2
		{
			get
			{
				return this._CB_TipoAntena2;
			}
			[MethodImpl(32)]
			set
			{
				this._CB_TipoAntena2 = value;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x002D1D4C File Offset: 0x002D014C
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x002D1D60 File Offset: 0x002D0160
		internal virtual Label Label20
		{
			get
			{
				return this._Label20;
			}
			[MethodImpl(32)]
			set
			{
				this._Label20 = value;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x002D1D6C File Offset: 0x002D016C
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x002D1D80 File Offset: 0x002D0180
		internal virtual Label Label21
		{
			get
			{
				return this._Label21;
			}
			[MethodImpl(32)]
			set
			{
				this._Label21 = value;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x002D1D8C File Offset: 0x002D018C
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x002D1DA0 File Offset: 0x002D01A0
		internal virtual Label Label22
		{
			get
			{
				return this._Label22;
			}
			[MethodImpl(32)]
			set
			{
				this._Label22 = value;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x002D1DAC File Offset: 0x002D01AC
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x002D1DC0 File Offset: 0x002D01C0
		internal virtual Label Label23
		{
			get
			{
				return this._Label23;
			}
			[MethodImpl(32)]
			set
			{
				this._Label23 = value;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x002D1DCC File Offset: 0x002D01CC
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x002D1DE0 File Offset: 0x002D01E0
		internal virtual Label Label24
		{
			get
			{
				return this._Label24;
			}
			[MethodImpl(32)]
			set
			{
				this._Label24 = value;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x002D1DEC File Offset: 0x002D01EC
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x002D1E00 File Offset: 0x002D0200
		internal virtual Label Label25
		{
			get
			{
				return this._Label25;
			}
			[MethodImpl(32)]
			set
			{
				this._Label25 = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x002D1E0C File Offset: 0x002D020C
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x002D1E20 File Offset: 0x002D0220
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

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x002D1E2C File Offset: 0x002D022C
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x002D1E40 File Offset: 0x002D0240
		internal virtual Label Label27
		{
			get
			{
				return this._Label27;
			}
			[MethodImpl(32)]
			set
			{
				this._Label27 = value;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x002D1E4C File Offset: 0x002D024C
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x002D1E60 File Offset: 0x002D0260
		internal virtual Label Label28
		{
			get
			{
				return this._Label28;
			}
			[MethodImpl(32)]
			set
			{
				this._Label28 = value;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x002D1E6C File Offset: 0x002D026C
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x002D1E80 File Offset: 0x002D0280
		internal virtual ToolStripSeparator ToolStripSeparator4
		{
			get
			{
				return this._ToolStripSeparator4;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripSeparator4 = value;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x002D1E8C File Offset: 0x002D028C
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x002D1EA0 File Offset: 0x002D02A0
		internal virtual ToolStripLabel ToolStripLabel1
		{
			get
			{
				return this._ToolStripLabel1;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripLabel1 = value;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x002D1EAC File Offset: 0x002D02AC
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x002D1EC0 File Offset: 0x002D02C0
		internal virtual Label Label11
		{
			get
			{
				return this._Label11;
			}
			[MethodImpl(32)]
			set
			{
				this._Label11 = value;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x002D1ECC File Offset: 0x002D02CC
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x002D1EE0 File Offset: 0x002D02E0
		internal virtual TextBox TextBox_equipamento_RT850
		{
			get
			{
				return this._TextBox_equipamento_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_equipamento_RT850 = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x002D1EEC File Offset: 0x002D02EC
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x002D1F00 File Offset: 0x002D0300
		internal virtual Label Label19
		{
			get
			{
				return this._Label19;
			}
			[MethodImpl(32)]
			set
			{
				this._Label19 = value;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x002D1F0C File Offset: 0x002D030C
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x002D1F20 File Offset: 0x002D0320
		internal virtual TextBox TextBox_release_RT850
		{
			get
			{
				return this._TextBox_release_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_release_RT850 = value;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x002D1F2C File Offset: 0x002D032C
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x002D1F40 File Offset: 0x002D0340
		internal virtual Label Label29
		{
			get
			{
				return this._Label29;
			}
			[MethodImpl(32)]
			set
			{
				this._Label29 = value;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x002D1F4C File Offset: 0x002D034C
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x002D1F60 File Offset: 0x002D0360
		internal virtual TextBox TextBox_build_RT850
		{
			get
			{
				return this._TextBox_build_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_build_RT850 = value;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x002D1F6C File Offset: 0x002D036C
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x002D1F80 File Offset: 0x002D0380
		internal virtual Label Label30
		{
			get
			{
				return this._Label30;
			}
			[MethodImpl(32)]
			set
			{
				this._Label30 = value;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x002D1F8C File Offset: 0x002D038C
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x002D1FA0 File Offset: 0x002D03A0
		internal virtual TextBox TextBox_versao_RT850
		{
			get
			{
				return this._TextBox_versao_RT850;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_versao_RT850 = value;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x002D1FAC File Offset: 0x002D03AC
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x002D1FC0 File Offset: 0x002D03C0
		internal virtual Label Label31
		{
			get
			{
				return this._Label31;
			}
			[MethodImpl(32)]
			set
			{
				this._Label31 = value;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x002D1FCC File Offset: 0x002D03CC
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x002D1FE0 File Offset: 0x002D03E0
		internal virtual TextBox tb_lixo1
		{
			get
			{
				return this._tb_lixo1;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_lixo1 = value;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x002D1FEC File Offset: 0x002D03EC
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x002D2000 File Offset: 0x002D0400
		internal virtual TextBox tb_lixo2
		{
			get
			{
				return this._tb_lixo2;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_lixo2 = value;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x002D200C File Offset: 0x002D040C
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x002D2020 File Offset: 0x002D0420
		internal virtual TextBox tb_lixo4
		{
			get
			{
				return this._tb_lixo4;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_lixo4 = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x002D202C File Offset: 0x002D042C
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x002D2040 File Offset: 0x002D0440
		internal virtual TextBox tb_lixo5
		{
			get
			{
				return this._tb_lixo5;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_lixo5 = value;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x002D204C File Offset: 0x002D044C
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x002D2060 File Offset: 0x002D0460
		internal virtual TextBox tb_lixo6
		{
			get
			{
				return this._tb_lixo6;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_lixo6 = value;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x002D206C File Offset: 0x002D046C
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x002D2080 File Offset: 0x002D0480
		internal virtual TextBox tb_lixo7
		{
			get
			{
				return this._tb_lixo7;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_lixo7 = value;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x002D208C File Offset: 0x002D048C
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x002D20A0 File Offset: 0x002D04A0
		internal virtual TextBox tb_lixo8
		{
			get
			{
				return this._tb_lixo8;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_lixo8 = value;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x002D20AC File Offset: 0x002D04AC
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x002D20C0 File Offset: 0x002D04C0
		internal virtual TextBox tb_lixo9
		{
			get
			{
				return this._tb_lixo9;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_lixo9 = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x002D20CC File Offset: 0x002D04CC
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x002D20E0 File Offset: 0x002D04E0
		internal virtual TabPage TabPage_cfg_msg_alarme
		{
			get
			{
				return this._TabPage_cfg_msg_alarme;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_cfg_msg_alarme = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x002D20EC File Offset: 0x002D04EC
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x002D2100 File Offset: 0x002D0500
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

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x002D210C File Offset: 0x002D050C
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x002D2120 File Offset: 0x002D0520
		internal virtual DataGridView dgv_Msg_Alarmes
		{
			get
			{
				return this._dgv_Msg_Alarmes;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.dgv_Msg_Alarmes_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_Msg_Alarmes_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgv_Msg_Alarmes_CellValidating);
				if (this._dgv_Msg_Alarmes != null)
				{
					this._dgv_Msg_Alarmes.CurrentCellDirtyStateChanged -= eventHandler;
					this._dgv_Msg_Alarmes.CellValueChanged -= dataGridViewCellEventHandler;
					this._dgv_Msg_Alarmes.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._dgv_Msg_Alarmes = value;
				if (this._dgv_Msg_Alarmes != null)
				{
					this._dgv_Msg_Alarmes.CurrentCellDirtyStateChanged += eventHandler;
					this._dgv_Msg_Alarmes.CellValueChanged += dataGridViewCellEventHandler;
					this._dgv_Msg_Alarmes.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x002D21B8 File Offset: 0x002D05B8
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x002D21CC File Offset: 0x002D05CC
		internal virtual Label Label32
		{
			get
			{
				return this._Label32;
			}
			[MethodImpl(32)]
			set
			{
				this._Label32 = value;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x002D21D8 File Offset: 0x002D05D8
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x002D21EC File Offset: 0x002D05EC
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

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x002D21F8 File Offset: 0x002D05F8
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x002D220C File Offset: 0x002D060C
		internal virtual DataGridView DataGridView_equip_1_RT850
		{
			get
			{
				return this._DataGridView_equip_1_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_equip_1_RT850_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_equip_1_RT850_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_equip_1_RT850_CellValidating);
				if (this._DataGridView_equip_1_RT850 != null)
				{
					this._DataGridView_equip_1_RT850.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_equip_1_RT850.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_equip_1_RT850.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_equip_1_RT850 = value;
				if (this._DataGridView_equip_1_RT850 != null)
				{
					this._DataGridView_equip_1_RT850.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_equip_1_RT850.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_equip_1_RT850.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x002D22A4 File Offset: 0x002D06A4
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x002D22B8 File Offset: 0x002D06B8
		internal virtual DataGridViewTextBoxColumn Col_Quantidade
		{
			get
			{
				return this._Col_Quantidade;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Quantidade = value;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x002D22C4 File Offset: 0x002D06C4
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x002D22D8 File Offset: 0x002D06D8
		internal virtual DataGridViewTextBoxColumn Col_Endereco
		{
			get
			{
				return this._Col_Endereco;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Endereco = value;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x002D22E4 File Offset: 0x002D06E4
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x002D22F8 File Offset: 0x002D06F8
		internal virtual TextBox tb_lixo3
		{
			get
			{
				return this._tb_lixo3;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_lixo3 = value;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x002D2304 File Offset: 0x002D0704
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x002D2318 File Offset: 0x002D0718
		internal virtual DataGridViewTextBoxColumn Alm_col_mensagem
		{
			get
			{
				return this._Alm_col_mensagem;
			}
			[MethodImpl(32)]
			set
			{
				this._Alm_col_mensagem = value;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x002D2324 File Offset: 0x002D0724
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x002D2338 File Offset: 0x002D0738
		internal virtual CheckBox CheckBox_conf_resp
		{
			get
			{
				return this._CheckBox_conf_resp;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_conf_resp_CheckedChanged);
				if (this._CheckBox_conf_resp != null)
				{
					this._CheckBox_conf_resp.CheckedChanged -= eventHandler;
				}
				this._CheckBox_conf_resp = value;
				if (this._CheckBox_conf_resp != null)
				{
					this._CheckBox_conf_resp.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x002D2384 File Offset: 0x002D0784
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x002D2398 File Offset: 0x002D0798
		internal virtual NumericUpDown nud_estatistica_ch2
		{
			get
			{
				return this._nud_estatistica_ch2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_estatistica_ch2_ValueChanged);
				if (this._nud_estatistica_ch2 != null)
				{
					this._nud_estatistica_ch2.ValueChanged -= eventHandler;
				}
				this._nud_estatistica_ch2 = value;
				if (this._nud_estatistica_ch2 != null)
				{
					this._nud_estatistica_ch2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x002D23E4 File Offset: 0x002D07E4
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x002D23F8 File Offset: 0x002D07F8
		internal virtual Label Label34
		{
			get
			{
				return this._Label34;
			}
			[MethodImpl(32)]
			set
			{
				this._Label34 = value;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x002D2404 File Offset: 0x002D0804
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x002D2418 File Offset: 0x002D0818
		internal virtual NumericUpDown nud_estatistica_ch1
		{
			get
			{
				return this._nud_estatistica_ch1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_estatistica_ch1_ValueChanged);
				if (this._nud_estatistica_ch1 != null)
				{
					this._nud_estatistica_ch1.ValueChanged -= eventHandler;
				}
				this._nud_estatistica_ch1 = value;
				if (this._nud_estatistica_ch1 != null)
				{
					this._nud_estatistica_ch1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x002D2464 File Offset: 0x002D0864
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x002D2478 File Offset: 0x002D0878
		internal virtual Label Label33
		{
			get
			{
				return this._Label33;
			}
			[MethodImpl(32)]
			set
			{
				this._Label33 = value;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x002D2484 File Offset: 0x002D0884
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x002D2498 File Offset: 0x002D0898
		internal virtual CheckBox ckb_modo_estatistica
		{
			get
			{
				return this._ckb_modo_estatistica;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ckb_modo_estatistica_CheckedChanged);
				if (this._ckb_modo_estatistica != null)
				{
					this._ckb_modo_estatistica.CheckedChanged -= eventHandler;
				}
				this._ckb_modo_estatistica = value;
				if (this._ckb_modo_estatistica != null)
				{
					this._ckb_modo_estatistica.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x002D24E4 File Offset: 0x002D08E4
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x002D24F8 File Offset: 0x002D08F8
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

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x002D2504 File Offset: 0x002D0904
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x002D2518 File Offset: 0x002D0918
		internal virtual TextBox T_ModeloFonte
		{
			get
			{
				return this._T_ModeloFonte;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.T_ModeloFonte_TextChanged);
				if (this._T_ModeloFonte != null)
				{
					this._T_ModeloFonte.TextChanged -= eventHandler;
				}
				this._T_ModeloFonte = value;
				if (this._T_ModeloFonte != null)
				{
					this._T_ModeloFonte.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x002D2564 File Offset: 0x002D0964
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x002D2578 File Offset: 0x002D0978
		internal virtual Label Label35
		{
			get
			{
				return this._Label35;
			}
			[MethodImpl(32)]
			set
			{
				this._Label35 = value;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x002D2584 File Offset: 0x002D0984
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x002D2598 File Offset: 0x002D0998
		internal virtual GroupBox GroupBox6
		{
			get
			{
				return this._GroupBox6;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox6 = value;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x002D25A4 File Offset: 0x002D09A4
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x002D25B8 File Offset: 0x002D09B8
		internal virtual ComboBox cb_remota
		{
			get
			{
				return this._cb_remota;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_remota_SelectedIndexChanged);
				if (this._cb_remota != null)
				{
					this._cb_remota.SelectedIndexChanged -= eventHandler;
				}
				this._cb_remota = value;
				if (this._cb_remota != null)
				{
					this._cb_remota.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x002D2604 File Offset: 0x002D0A04
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x002D2618 File Offset: 0x002D0A18
		internal virtual ComboBox cb_supervisorio
		{
			get
			{
				return this._cb_supervisorio;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_supervisorio_SelectedIndexChanged);
				if (this._cb_supervisorio != null)
				{
					this._cb_supervisorio.SelectedIndexChanged -= eventHandler;
				}
				this._cb_supervisorio = value;
				if (this._cb_supervisorio != null)
				{
					this._cb_supervisorio.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x002D2664 File Offset: 0x002D0A64
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x002D2678 File Offset: 0x002D0A78
		internal virtual Label Label37
		{
			get
			{
				return this._Label37;
			}
			[MethodImpl(32)]
			set
			{
				this._Label37 = value;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x002D2684 File Offset: 0x002D0A84
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x002D2698 File Offset: 0x002D0A98
		internal virtual Label Label36
		{
			get
			{
				return this._Label36;
			}
			[MethodImpl(32)]
			set
			{
				this._Label36 = value;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x002D26A4 File Offset: 0x002D0AA4
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x002D26B8 File Offset: 0x002D0AB8
		internal virtual GroupBox GroupBox7
		{
			get
			{
				return this._GroupBox7;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox7 = value;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x002D26C4 File Offset: 0x002D0AC4
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x002D26D8 File Offset: 0x002D0AD8
		internal virtual Label Label39
		{
			get
			{
				return this._Label39;
			}
			[MethodImpl(32)]
			set
			{
				this._Label39 = value;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x002D26E4 File Offset: 0x002D0AE4
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x002D26F8 File Offset: 0x002D0AF8
		internal virtual Label Label38
		{
			get
			{
				return this._Label38;
			}
			[MethodImpl(32)]
			set
			{
				this._Label38 = value;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x002D2704 File Offset: 0x002D0B04
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x002D2718 File Offset: 0x002D0B18
		internal virtual CheckBox cb_teclado_RT850
		{
			get
			{
				return this._cb_teclado_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_teclado_RT850_CheckedChanged);
				if (this._cb_teclado_RT850 != null)
				{
					this._cb_teclado_RT850.CheckedChanged -= eventHandler;
				}
				this._cb_teclado_RT850 = value;
				if (this._cb_teclado_RT850 != null)
				{
					this._cb_teclado_RT850.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x002D2764 File Offset: 0x002D0B64
		private void AtivaEfeitoOnChangeValue()
		{
			this.ToolStri_RT850.Enabled = false;
			this.tb_lixo1.Focus();
			this.tb_lixo2.Focus();
			this.tb_lixo3.Focus();
			this.tb_lixo4.Focus();
			this.tb_lixo5.Focus();
			this.tb_lixo6.Focus();
			this.tb_lixo7.Focus();
			this.tb_lixo8.Focus();
			this.tb_lixo9.Focus();
			this.ToolStri_RT850.Enabled = true;
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x002D27F8 File Offset: 0x002D0BF8
		private void RT_850_conf_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.DataGridView_variaveis_RT850.Rows.Add(1);
			this.DataGridView_Ctrl_1_RT850.Rows.Add(1);
			this.DataGridView_Ctrl_4_RT850.Rows.Add(1);
			this.DataGridView_Ctrl_8_RT850.Rows.Add(1);
			this.DataGridView_vista_variaveis_RT_850.Rows.Add(1);
			this.DataGridView_vista_equipamentos_RT_850.Rows.Add(1);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x002D2874 File Offset: 0x002D0C74
		private void RT_850_conf_Load(object sender, EventArgs e)
		{
			RT_geral.Lmte_Init_ok = false;
			perifericos.Cria_ListaBaudRate();
			checked
			{
				RT_geral.RT_850_BD.BaudRate_canal_1.valores = new int[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_850_BD.BaudRate_canal_1.itens = new string[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_850_BD.BaudRate_canal_2.valores = new int[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_850_BD.BaudRate_canal_2.itens = new string[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_850_BD.Vista_selecionado.valores = new int[2];
				RT_geral.RT_850_BD.Vista_selecionado.itens = new string[2];
				RT_geral.RT_850_Modelo.valores = new int[6];
				RT_geral.RT_850_Modelo.itens = new string[6];
				int num = 0;
				do
				{
					RT_geral.RT_850_Ctrl_1[num].Var = new RT_geral.Combo_ictel_ctrl[5];
					RT_geral.RT_850_Ctrl_1[num].Ref = new RT_geral.Combo_ictel_ctrl[5];
					RT_geral.RT_850_Ctrl_1[num].Crtl_nome = new RT_geral.Combo_ictel_ctrl[2];
					RT_geral.RT_850_Ctrl_1[num].Crtl_indice = new RT_geral.Integer_ictel[2];
					num++;
				}
				while (num <= 80);
				num = 0;
				do
				{
					RT_geral.RT_850_Ctrl_4[num].Var = new RT_geral.Combo_ictel_ctrl[5];
					RT_geral.RT_850_Ctrl_4[num].Ref = new RT_geral.Combo_ictel_ctrl[5];
					RT_geral.RT_850_Ctrl_4[num].Crtl_nome = new RT_geral.Combo_ictel_ctrl[5];
					RT_geral.RT_850_Ctrl_4[num].Crtl_indice = new RT_geral.Integer_ictel[5];
					RT_geral.RT_850_Ctrl_4[num].Periferico_Indice = new RT_geral.Combo_ictel_ctrl[6];
					RT_geral.RT_850_Ctrl_4[num].Periferico_Modelo = new RT_geral.Combo_ictel_ctrl[6];
					num++;
				}
				while (num <= 50);
				num = 0;
				do
				{
					RT_geral.RT_850_Ctrl_8[num].Var = new RT_geral.Combo_ictel_ctrl[17];
					RT_geral.RT_850_Ctrl_8[num].Ref = new RT_geral.Combo_ictel_ctrl[5];
					RT_geral.RT_850_Ctrl_8[num].Crtl_nome = new RT_geral.Combo_ictel_ctrl[9];
					RT_geral.RT_850_Ctrl_8[num].Crtl_indice = new RT_geral.Integer_ictel[9];
					RT_geral.RT_850_Ctrl_8[num].Periferico_Indice = new RT_geral.Combo_ictel_ctrl[6];
					RT_geral.RT_850_Ctrl_8[num].Periferico_Modelo = new RT_geral.Combo_ictel_ctrl[6];
					num++;
				}
				while (num <= 20);
				num = 0;
				do
				{
					RT_geral.RT_850_Vista[num].Variaveis = new RT_geral.Combo_ictel_ctrl[41];
					RT_geral.RT_850_Vista[num].Equipamentos = new RT_geral.Combo_ictel_ctrl[21];
					num++;
				}
				while (num <= 5);
				RT_geral.RT_850_BD.Flag_Remota.valores = new int[7];
				RT_geral.RT_850_BD.Flag_Remota.itens = new string[7];
				RT_geral.RT_850_BD.Flag_Supervisorio.valores = new int[7];
				RT_geral.RT_850_BD.Flag_Supervisorio.itens = new string[7];
				RT_geral.RT_850_BD.Nome_Arquivo = "";
				ComboBox comboBox = this.ComboBox_baudrate_1_RT850;
				this.CarregaComboBoxBaudRate(ref comboBox);
				this.ComboBox_baudrate_1_RT850 = comboBox;
				comboBox = this.ComboBox_baudrate_2_RT850;
				this.CarregaComboBoxBaudRate(ref comboBox);
				this.ComboBox_baudrate_2_RT850 = comboBox;
				comboBox = this.ComboBox_porta_vista_RT_850;
				this.CarregaComboBoxVista_Canal(ref comboBox);
				this.ComboBox_porta_vista_RT_850 = comboBox;
				comboBox = this.ComboBox_prioridade_vista_RT_850;
				this.CarregaComboBoxVista_Prioridade(ref comboBox);
				this.ComboBox_prioridade_vista_RT_850 = comboBox;
				comboBox = this.ComboBox_timeout_vista_RT_850;
				this.CarregaComboBoxVista_Timeout(ref comboBox);
				this.ComboBox_timeout_vista_RT_850 = comboBox;
				comboBox = this.ComboBox_modelo_vista_RT_850;
				this.CarregaComboBoxVista_Modelo(ref comboBox);
				this.ComboBox_modelo_vista_RT_850 = comboBox;
				this.Inicializa_DadosEStruturaRT850_Padrao();
				this.CarregaComboBoxFlagRemota();
				this.CarregaComboBoxFlagSupervisorio();
				this.Inicializa_DadosEStruturaRT850_Default();
				this.Carrega_Msg_Alarme_RT_850();
				this.Carrega_Msg_Alarme_Configuravel_RT_850();
				this.InicializaEstrutura_DataGridView_Equip_Canal_1();
				this.GeraDataGridView_Equip_Canal_1();
				this.InicializaEstrutura_DataGridView_variaveis_RT_850();
				this.GeraDataGridView_variaveis_RT_850();
				perifericos.Cria_ListaPeriferico_CT850_300();
				this.InicializaEstrutura_DataGridView_Equipamentos_CTLR_1_RT_850();
				this.GeraDataGridView_Equipamentos_CTLR_1_RT_850();
				this.InicializaEstrutura_DataGridView_Equipamentos_CTLR_4_RT_850();
				this.GeraDataGridView_Equipamentos_CTLR_4_RT_850();
				this.InicializaEstrutura_DataGridView_Equipamentos_CTLR_8_RT_850();
				this.GeraDataGridView_Equipamentos_CTLR_8_RT_850();
				this.InicializaEstrutura_DataGridView_Variaveis_Vista_RT_850();
				this.GeraDataGridView_Variaveis_Vista_RT_850();
				this.InicializaEstrutura_DataGridView_Equipamentos_Vista_RT_850();
				this.GeraDataGridView_Equipamentos_Vista_RT_850();
				Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
				this.dgv_Msg_Alarmes.RowCount = 20;
				this.TabPage_geral.BackColor = Color.FromKnownColor(8);
				this.TabPage_geral.ForeColor = Color.FromKnownColor(10);
				this.TabPage1.BackColor = Color.FromKnownColor(8);
				this.TabPage1.ForeColor = Color.FromKnownColor(10);
				this.TabPage_controles.BackColor = Color.FromKnownColor(8);
				this.TabPage_controles.ForeColor = Color.FromKnownColor(10);
				this.TabPage_variaveis_RT850.BackColor = Color.FromKnownColor(8);
				this.TabPage_variaveis_RT850.ForeColor = Color.FromKnownColor(10);
				this.TabPage_Ctrl_1_controle.BackColor = Color.FromKnownColor(8);
				this.TabPage_Ctrl_1_controle.ForeColor = Color.FromKnownColor(10);
				this.TabPage_Ctrl_4_controle.BackColor = Color.FromKnownColor(8);
				this.TabPage_Ctrl_4_controle.ForeColor = Color.FromKnownColor(10);
				this.TabPage_Ctrl_8_controle.BackColor = Color.FromKnownColor(8);
				this.TabPage_Ctrl_8_controle.ForeColor = Color.FromKnownColor(10);
				this.TabPage_cfg_msg_alarme.BackColor = Color.FromKnownColor(8);
				this.TabPage_cfg_msg_alarme.ForeColor = Color.FromKnownColor(10);
				this.TabPage_Vista.BackColor = Color.FromKnownColor(8);
				this.TabPage_Vista.ForeColor = Color.FromKnownColor(10);
				string text = ".\\\\Fontes\\\\5x8_LCD_HD44780U_A02_Regular.ttf";
				if (MyProject.Computer.FileSystem.FileExists(text))
				{
					PrivateFontCollection privateFontCollection = new PrivateFontCollection();
					privateFontCollection.AddFontFile(text);
					Font font = new Font(privateFontCollection.Families[0], 12f);
					this.TextBox_msg_inicial_RT850.Font = font;
				}
				else
				{
					MessageBox.Show("Removido fonte LCD da pasta da aplicação!");
				}
				string text2 = ".\\\\Fontes\\\\Ictel Extendida Italic.ttf";
				if (MyProject.Computer.FileSystem.FileExists(text2))
				{
					PrivateFontCollection privateFontCollection2 = new PrivateFontCollection();
					privateFontCollection2.AddFontFile(text2);
					Font font2 = new Font(privateFontCollection2.Families[0], 8f, 2);
					Font font3 = new Font(privateFontCollection2.Families[0], 18f, 2);
					this.Label11.Font = font2;
					this.TextBox_equipamento_RT850.Font = font2;
					this.TextBox_versao_RT850.Font = font2;
					this.TextBox_build_RT850.Font = font2;
					this.TextBox_release_RT850.Font = font2;
					this.ToolStripLabel1.Font = font3;
				}
				else
				{
					MessageBox.Show("Removido fonte Ictel Extendida Italic da pasta da aplicação!");
				}
				RT_geral.RT_850_flag_msg_alarme_config = false;
				this.Atualiza_TelaRT850();
				this.ToolStripLabel1.Text = RT_geral.MontaNomePlacaPeloFabricante(RT_geral.RT_850_BD.Equip.Valor, RT_geral.RT_850_BD.Versao.Valor);
				RT_geral.Lmte_Init_ok = true;
			}
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x002D2F24 File Offset: 0x002D1324
		private void RT_850_conf_Activated(object sender, EventArgs e)
		{
			Geral.Equipamento_selecionado = 850;
			Geral.Equipamento_versao = 3;
			Geral.Equipamento_build = 0;
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x002D2F3C File Offset: 0x002D133C
		private void GeraDataGridView_Equip_Canal_1()
		{
			this.DataGridView_equip_1_RT850.Columns.Clear();
			this.DataGridView_equip_1_RT850.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			this.DataGridView_equip_1_RT850.DefaultCellStyle.Alignment = (System.Windows.Forms.HorizontalAlignment)64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas);
						this.DataGridView_equip_1_RT850.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas);
						this.DataGridView_equip_1_RT850.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					this.DataGridView_equip_1_RT850.Columns[num].SortMode = 0;
					num++;
				}
				while (num <= 1);
				this.DataGridView_equip_1_RT850.RowCount = 4;
				this.DataGridView_equip_1_RT850.RowHeadersWidth = 90;
				int num2 = 1;
				try
				{
					foreach (object obj = null in this.DataGridView_equip_1_RT850.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							switch (num2)
							{
							case 1:
								dataGridViewRow.HeaderCell.Value = "Ctrl 1";
								break;
							case 2:
								dataGridViewRow.HeaderCell.Value = "Ctrl 4";
								break;
							case 3:
								dataGridViewRow.HeaderCell.Value = "Ctrl 8";
								break;
							case 4:
								dataGridViewRow.HeaderCell.Value = "Vista";
								break;
							}
							num2++;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x002D30DC File Offset: 0x002D14DC
		private void InicializaEstrutura_DataGridView_Equip_Canal_1()
		{
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[0].TagColuna = "Quantidade";
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[1].TagColuna = "End Inicial";
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[0].NomeColuna = "Quantidade";
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[1].NomeColuna = "Endereco";
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[0].LarguraColuna = Conversions.ToInteger("80");
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[1].LarguraColuna = Conversions.ToInteger("90");
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[0].AlingColuna = 32;
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[1].AlingColuna = 32;
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[0].NumeroLinhaMenu = 0;
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[1].NumeroLinhaMenu = 0;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x002D31B8 File Offset: 0x002D15B8
		private void Atualiza_canais_comunicacao()
		{
			this.NumericUpDown_end_1_RT850.Value = new decimal(RT_geral.RT_850_BD.End_mestre_canal_1.Valor);
			this.NumericUpDown_end_2_RT850.Value = new decimal(RT_geral.RT_850_BD.End_mestre_canal_2.Valor);
			this.NumericUpDown_intervalo_leitura_1_RT850.Value = new decimal(RT_geral.RT_850_BD.Intervalo_leitura_canal_1.Valor);
			this.NumericUpDown_intervalo_leitura_2_RT850.Value = new decimal(RT_geral.RT_850_BD.Intervalo_leitura_canal_2.Valor);
			Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_850_BD.BaudRate_canal_1, RT_geral.RT_850_BD.BaudRate_canal_1.Valor);
			Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_850_BD.BaudRate_canal_2, RT_geral.RT_850_BD.BaudRate_canal_2.Valor);
			this.ComboBox_baudrate_1_RT850.SelectedIndex = RT_geral.RT_850_BD.BaudRate_canal_1.Indice;
			this.ComboBox_baudrate_2_RT850.SelectedIndex = RT_geral.RT_850_BD.BaudRate_canal_2.Indice;
			this.NumericUpDown_timeout_1_RT850.Value = new decimal(RT_geral.RT_850_BD.Timeout_canal_1.Valor);
			this.NumericUpDown_timeout_2_RT850.Value = new decimal(RT_geral.RT_850_BD.Timeout_canal_2.Valor);
			this.NumericUpDown_temp_ptt_1_RT850.Value = new decimal(RT_geral.RT_850_BD.Tempo_ptt_canal_1.Valor);
			this.NumericUpDown_temp_ptt_2_RT850.Value = new decimal(RT_geral.RT_850_BD.Tempo_ptt_canal_2.Valor);
			this.NumericUpDown_num_tentativas_1_RT850.Value = new decimal(RT_geral.RT_850_BD.Numero_tentativas_canal_1.Valor);
			this.NumericUpDown_num_tentativas_2_RT850.Value = new decimal(RT_geral.RT_850_BD.Numero_tentativas_canal_2.Valor);
			this.NumericUpDown_num_erro_falha_1_RT850.Value = new decimal(RT_geral.RT_850_BD.Numero_erros_falha_canal_1.Valor);
			this.NumericUpDown_num_erro_falha_2_RT850.Value = new decimal(RT_geral.RT_850_BD.Numero_erros_falha_canal_2.Valor);
			if (RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Valor < RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Lmte_inf)
			{
				RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Valor = RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Lmte_inf;
			}
			if (RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Valor > RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Lmte_sup)
			{
				RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Valor = RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Lmte_sup;
			}
			this.nud_estatistica_ch1.Value = new decimal(RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Valor);
			if (RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Valor < RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Lmte_inf)
			{
				RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Valor = RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Lmte_inf;
			}
			if (RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Valor > RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Lmte_sup)
			{
				RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Valor = RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Lmte_sup;
			}
			this.nud_estatistica_ch2.Value = new decimal(RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Valor);
			this.DataGridView_equip_1_RT850.Rows[0].Cells[0].Value = RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor;
			this.DataGridView_equip_1_RT850.Rows[0].Cells[1].Value = RT_geral.RT_850_BD.End_inicial_equip_tipo_1.Valor;
			this.DataGridView_equip_1_RT850.Rows[1].Cells[0].Value = RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor;
			this.DataGridView_equip_1_RT850.Rows[1].Cells[1].Value = RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Valor;
			this.DataGridView_equip_1_RT850.Rows[2].Cells[0].Value = RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor;
			this.DataGridView_equip_1_RT850.Rows[2].Cells[1].Value = RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Valor;
			this.DataGridView_equip_1_RT850.Rows[3].Cells[0].Value = RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor;
			this.DataGridView_equip_1_RT850.Rows[3].Cells[1].Value = RT_geral.RT_850_BD.End_inicial_equip_tipo_vista.Valor;
			if (RT_geral.RT_850_BD.Sincronismo.Valor == 21857)
			{
				this.CheckBox_sincronismo_RT850.Checked = true;
			}
			else
			{
				this.CheckBox_sincronismo_RT850.Checked = false;
			}
			if (RT_geral.RT_850_BD.ConfereResposta.Valor == 1)
			{
				this.CheckBox_conf_resp.Checked = true;
			}
			else
			{
				this.CheckBox_conf_resp.Checked = false;
			}
			if (RT_geral.RT_850_BD.Modo_Estatistica.Valor == 1)
			{
				this.ckb_modo_estatistica.Checked = true;
			}
			else
			{
				this.ckb_modo_estatistica.Checked = false;
			}
			Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_850_BD.Flag_Remota, RT_geral.RT_850_BD.Flag_Remota.Valor);
			Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_850_BD.Flag_Supervisorio, RT_geral.RT_850_BD.Flag_Supervisorio.Valor);
			this.cb_remota.SelectedIndex = RT_geral.RT_850_BD.Flag_Remota.Indice;
			this.cb_supervisorio.SelectedIndex = RT_geral.RT_850_BD.Flag_Supervisorio.Indice;
			if (RT_geral.RT_850_BD.LiberaTeclado.Valor == 1)
			{
				this.cb_teclado_RT850.Checked = true;
			}
			else
			{
				this.cb_teclado_RT850.Checked = false;
			}
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x002D37AC File Offset: 0x002D1BAC
		private void GeraDataGridView_variaveis_RT_850()
		{
			RT_geral.RT_850_Controle.LiberaEventos_Variaveis = false;
			if (this.DataGridView_variaveis_RT850.ColumnCount > 0)
			{
				this.DataGridView_variaveis_RT850.RowCount = 1;
				this.DataGridView_variaveis_RT850.Columns.Clear();
			}
			this.DataGridView_variaveis_RT850.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			this.DataGridView_variaveis_RT850.DefaultCellStyle.Alignment = (System.Windows.Forms.HorizontalAlignment)32;
			int num = 0;
			checked
			{
				do
				{
					int numeroLinhaMenu = RT_geral.RT_850_DataGridView_variaveis[num].NumeroLinhaMenu;
					if (numeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(num.ToString(), ref RT_geral.RT_850_DataGridView_variaveis);
						this.DataGridView_variaveis_RT850.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(num.ToString(), ref RT_geral.RT_850_DataGridView_variaveis);
						this.DataGridView_variaveis_RT850.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					this.DataGridView_variaveis_RT850.Columns[num].SortMode = 0;
					num++;
				}
				while (num <= 12);
				this.DataGridView_variaveis_RT850.RowCount = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				this.DataGridView_variaveis_RT850.RowHeadersWidth = 110;
				int num2 = 1;
				try
				{
					foreach (object obj = null in this.DataGridView_variaveis_RT850.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "Variável " + Conversions.ToString(num2);
							num2++;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				RT_geral.RT_850_Controle.LiberaEventos_Variaveis = true;
			}
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x002D3944 File Offset: 0x002D1D44
		private void InicializaEstrutura_DataGridView_variaveis_RT_850()
		{
			RT_geral.RT_850_DataGridView_variaveis[3].LinhasMenu = new string[3];
			RT_geral.RT_850_DataGridView_variaveis[3].LinhasValor = new int[3];
			RT_geral.RT_850_DataGridView_variaveis[4].LinhasMenu = new string[5];
			RT_geral.RT_850_DataGridView_variaveis[4].LinhasValor = new int[5];
			RT_geral.RT_850_DataGridView_variaveis[12].LinhasMenu = new string[6];
			RT_geral.RT_850_DataGridView_variaveis[12].LinhasValor = new int[6];
			RT_geral.RT_850_DataGridView_variaveis[6].LinhasMenu = new string[3];
			RT_geral.RT_850_DataGridView_variaveis[6].LinhasValor = new int[3];
			RT_geral.RT_850_DataGridView_variaveis[9].LinhasMenu = new string[3];
			RT_geral.RT_850_DataGridView_variaveis[9].LinhasValor = new int[3];
			RT_geral.RT_850_DataGridView_variaveis[7].LinhasMenu = new string[27];
			RT_geral.RT_850_DataGridView_variaveis[7].LinhasValor = new int[27];
			RT_geral.RT_850_DataGridView_variaveis[10].LinhasMenu = new string[27];
			RT_geral.RT_850_DataGridView_variaveis[10].LinhasValor = new int[27];
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_850_DataGridView_variaveis[7].LinhasMenu[num] = RT_geral.RT_850_MSG_ALARME[num];
					RT_geral.RT_850_DataGridView_variaveis[7].LinhasValor[num] = num;
					RT_geral.RT_850_DataGridView_variaveis[10].LinhasMenu[num] = RT_geral.RT_850_MSG_ALARME[num];
					RT_geral.RT_850_DataGridView_variaveis[10].LinhasValor[num] = num;
					num++;
				}
				while (num <= 5);
				int num2 = 101;
				num = 6;
				do
				{
					RT_geral.RT_850_DataGridView_variaveis[7].LinhasMenu[num] = RT_geral.RT_850_MSG_ALARME_CONFIG[num - 6];
					RT_geral.RT_850_DataGridView_variaveis[7].LinhasValor[num] = num2;
					RT_geral.RT_850_DataGridView_variaveis[10].LinhasMenu[num] = RT_geral.RT_850_MSG_ALARME_CONFIG[num - 6];
					RT_geral.RT_850_DataGridView_variaveis[10].LinhasValor[num] = num2;
					num2++;
					num++;
				}
				while (num <= 25);
				RT_geral.RT_850_DataGridView_variaveis[3].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_variaveis[3].LinhasValor[1] = 1;
				RT_geral.RT_850_DataGridView_variaveis[3].LinhasMenu[0] = "Nenhum";
				RT_geral.RT_850_DataGridView_variaveis[3].LinhasMenu[1] = "Nível";
				RT_geral.RT_850_DataGridView_variaveis[4].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_variaveis[4].LinhasValor[1] = 1;
				RT_geral.RT_850_DataGridView_variaveis[4].LinhasValor[2] = 2;
				RT_geral.RT_850_DataGridView_variaveis[4].LinhasValor[3] = 3;
				RT_geral.RT_850_DataGridView_variaveis[4].LinhasMenu[0] = "0";
				RT_geral.RT_850_DataGridView_variaveis[4].LinhasMenu[1] = "0,0";
				RT_geral.RT_850_DataGridView_variaveis[4].LinhasMenu[2] = "0,00";
				RT_geral.RT_850_DataGridView_variaveis[4].LinhasMenu[3] = "0,000";
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasValor[1] = 1;
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasValor[2] = 2;
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasValor[3] = 3;
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasValor[4] = 4;
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasMenu[0] = "-------";
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasMenu[1] = "Linha 1";
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasMenu[2] = "Linha 2";
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasMenu[3] = "Linha 3";
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasMenu[4] = "Linha 4";
				RT_geral.RT_850_DataGridView_variaveis[6].LinhasMenu[0] = "Baixo";
				RT_geral.RT_850_DataGridView_variaveis[6].LinhasMenu[1] = "Alto";
				RT_geral.RT_850_DataGridView_variaveis[6].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_variaveis[6].LinhasValor[1] = 1;
				RT_geral.RT_850_DataGridView_variaveis[9].LinhasMenu[0] = "Baixo";
				RT_geral.RT_850_DataGridView_variaveis[9].LinhasMenu[1] = "Alto";
				RT_geral.RT_850_DataGridView_variaveis[9].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_variaveis[9].LinhasValor[1] = 1;
				RT_geral.RT_850_DataGridView_variaveis[0].TagColuna = "Nome";
				RT_geral.RT_850_DataGridView_variaveis[1].TagColuna = "Escala Início";
				RT_geral.RT_850_DataGridView_variaveis[2].TagColuna = "Escala Fim";
				RT_geral.RT_850_DataGridView_variaveis[3].TagColuna = "Escala Tratamento";
				RT_geral.RT_850_DataGridView_variaveis[4].TagColuna = "Ponto Decimal";
				RT_geral.RT_850_DataGridView_variaveis[5].TagColuna = "Alarme 1";
				RT_geral.RT_850_DataGridView_variaveis[6].TagColuna = "Tipo Alarme 1";
				RT_geral.RT_850_DataGridView_variaveis[7].TagColuna = "Msg Alarme 1";
				RT_geral.RT_850_DataGridView_variaveis[8].TagColuna = "Alarme 2";
				RT_geral.RT_850_DataGridView_variaveis[9].TagColuna = "Tipo Alarme 2";
				RT_geral.RT_850_DataGridView_variaveis[10].TagColuna = "Msg Alarme 2";
				RT_geral.RT_850_DataGridView_variaveis[11].TagColuna = "Tela Display";
				RT_geral.RT_850_DataGridView_variaveis[12].TagColuna = "Linha Display";
				RT_geral.RT_850_DataGridView_variaveis[0].NomeColuna = "Nome";
				RT_geral.RT_850_DataGridView_variaveis[1].NomeColuna = "Escala_ini";
				RT_geral.RT_850_DataGridView_variaveis[2].NomeColuna = "Escala_fim";
				RT_geral.RT_850_DataGridView_variaveis[3].NomeColuna = "Escala_trat";
				RT_geral.RT_850_DataGridView_variaveis[4].NomeColuna = "Pto_fim";
				RT_geral.RT_850_DataGridView_variaveis[5].NomeColuna = "Alarme_1";
				RT_geral.RT_850_DataGridView_variaveis[6].NomeColuna = "Tipo_Alarme_1";
				RT_geral.RT_850_DataGridView_variaveis[7].NomeColuna = "Msg_Alarme_1";
				RT_geral.RT_850_DataGridView_variaveis[8].NomeColuna = "Alarme_2";
				RT_geral.RT_850_DataGridView_variaveis[9].NomeColuna = "Tipo_Alarme_2";
				RT_geral.RT_850_DataGridView_variaveis[10].NomeColuna = "Msg_Alarme_2";
				RT_geral.RT_850_DataGridView_variaveis[11].NomeColuna = "Num_tela";
				RT_geral.RT_850_DataGridView_variaveis[12].NomeColuna = "Pos_dsp";
				RT_geral.RT_850_DataGridView_variaveis[0].LarguraColuna = Conversions.ToInteger("100");
				RT_geral.RT_850_DataGridView_variaveis[1].LarguraColuna = Conversions.ToInteger("60");
				RT_geral.RT_850_DataGridView_variaveis[2].LarguraColuna = Conversions.ToInteger("60");
				RT_geral.RT_850_DataGridView_variaveis[3].LarguraColuna = Conversions.ToInteger("100");
				RT_geral.RT_850_DataGridView_variaveis[4].LarguraColuna = Conversions.ToInteger("60");
				RT_geral.RT_850_DataGridView_variaveis[5].LarguraColuna = Conversions.ToInteger("60");
				RT_geral.RT_850_DataGridView_variaveis[6].LarguraColuna = Conversions.ToInteger("60");
				RT_geral.RT_850_DataGridView_variaveis[7].LarguraColuna = Conversions.ToInteger("120");
				RT_geral.RT_850_DataGridView_variaveis[8].LarguraColuna = Conversions.ToInteger("60");
				RT_geral.RT_850_DataGridView_variaveis[9].LarguraColuna = Conversions.ToInteger("60");
				RT_geral.RT_850_DataGridView_variaveis[10].LarguraColuna = Conversions.ToInteger("120");
				RT_geral.RT_850_DataGridView_variaveis[11].LarguraColuna = Conversions.ToInteger("60");
				RT_geral.RT_850_DataGridView_variaveis[12].LarguraColuna = Conversions.ToInteger("98");
				RT_geral.RT_850_DataGridView_variaveis[0].AlingColuna = 256;
				RT_geral.RT_850_DataGridView_variaveis[1].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_variaveis[2].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_variaveis[3].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_variaveis[4].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_variaveis[5].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_variaveis[6].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_variaveis[7].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_variaveis[8].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_variaveis[9].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_variaveis[10].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_variaveis[11].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_variaveis[12].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_variaveis[0].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_variaveis[1].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_variaveis[2].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_variaveis[3].NumeroLinhaMenu = 2;
				RT_geral.RT_850_DataGridView_variaveis[4].NumeroLinhaMenu = 4;
				RT_geral.RT_850_DataGridView_variaveis[5].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_variaveis[6].NumeroLinhaMenu = 2;
				RT_geral.RT_850_DataGridView_variaveis[7].NumeroLinhaMenu = 26;
				RT_geral.RT_850_DataGridView_variaveis[8].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_variaveis[9].NumeroLinhaMenu = 2;
				RT_geral.RT_850_DataGridView_variaveis[10].NumeroLinhaMenu = 26;
				RT_geral.RT_850_DataGridView_variaveis[11].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_variaveis[12].NumeroLinhaMenu = 5;
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x002D433C File Offset: 0x002D273C
		private void Atualiza_DatagridView_Mensagem_Alarme_RT850()
		{
			this.dgv_Msg_Alarmes.RowHeadersWidthSizeMode = 2;
			int num = 0;
			checked
			{
				do
				{
					this.dgv_Msg_Alarmes.Rows[num].HeaderCell.Value = "Msg" + (num + 1).ToString();
					this.dgv_Msg_Alarmes.Rows[num].Cells[0].Value = RT_geral.RT_850_MSG_ALARME_CONFIG[num];
					num++;
				}
				while (num <= 19);
			}
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x002D43B8 File Offset: 0x002D27B8
		private void Atualiza_DataGridView_Variaveis_RT850()
		{
			bool flag = false;
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_850_BD.Variaveis_Numero.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string value = RT_geral.Variaveis_RT_850[i].Nome.Valor;
					this.DataGridView_variaveis_RT850.Rows[i].Cells[0].Value = value;
					this.DataGridView_variaveis_RT850.Rows[i].Cells[1].Value = RT_geral.Variaveis_RT_850[i].Escala_ini.Valor;
					this.DataGridView_variaveis_RT850.Rows[i].Cells[2].Value = RT_geral.Variaveis_RT_850[i].Escala_fim.Valor;
					value = RT_geral.RT_850_DataGridView_variaveis[3].LinhasMenu[RT_geral.Variaveis_RT_850[i].Escala_tratamento.Indice];
					this.DataGridView_variaveis_RT850.Rows[i].Cells[3].Value = value;
					value = RT_geral.RT_850_DataGridView_variaveis[4].LinhasMenu[RT_geral.Variaveis_RT_850[i].Pto_dec_fim.Indice];
					this.DataGridView_variaveis_RT850.Rows[i].Cells[4].Value = value;
					this.DataGridView_variaveis_RT850.Rows[i].Cells[5].Value = RT_geral.Variaveis_RT_850[i].Nivel_alm_1.Valor;
					value = RT_geral.RT_850_DataGridView_variaveis[6].LinhasMenu[RT_geral.Variaveis_RT_850[i].Tipo_alm_1.Indice];
					this.DataGridView_variaveis_RT850.Rows[i].Cells[6].Value = value;
					int valor = RT_geral.Variaveis_RT_850[i].Msg_alm_1.Valor;
					int num3 = 0;
					int num4 = RT_geral.RT_850_DataGridView_variaveis[7].NumeroLinhaMenu - 1;
					for (int j = num3; j <= num4; j++)
					{
						if (valor == RT_geral.RT_850_DataGridView_variaveis[7].LinhasValor[j])
						{
							flag = true;
							value = RT_geral.RT_850_DataGridView_variaveis[7].LinhasMenu[j];
							break;
						}
					}
					if (!flag)
					{
						value = RT_geral.RT_850_DataGridView_variaveis[7].LinhasMenu[0];
					}
					this.DataGridView_variaveis_RT850.Rows[i].Cells[7].Value = value;
					this.DataGridView_variaveis_RT850.Rows[i].Cells[8].Value = RT_geral.Variaveis_RT_850[i].Nivel_alm_2.Valor;
					value = RT_geral.RT_850_DataGridView_variaveis[9].LinhasMenu[RT_geral.Variaveis_RT_850[i].Tipo_alm_2.Indice];
					this.DataGridView_variaveis_RT850.Rows[i].Cells[9].Value = value;
					valor = RT_geral.Variaveis_RT_850[i].Msg_alm_2.Valor;
					int num5 = 0;
					int num6 = RT_geral.RT_850_DataGridView_variaveis[10].NumeroLinhaMenu - 1;
					for (int j = num5; j <= num6; j++)
					{
						if (valor == RT_geral.RT_850_DataGridView_variaveis[10].LinhasValor[j])
						{
							flag = true;
							value = RT_geral.RT_850_DataGridView_variaveis[10].LinhasMenu[j];
							break;
						}
					}
					if (!flag)
					{
						value = RT_geral.RT_850_DataGridView_variaveis[10].LinhasMenu[0];
					}
					this.DataGridView_variaveis_RT850.Rows[i].Cells[10].Value = value;
					this.DataGridView_variaveis_RT850.Rows[i].Cells[11].Value = RT_geral.Variaveis_RT_850[i].Dsp_tela.Valor;
					value = RT_geral.RT_850_DataGridView_variaveis[12].LinhasMenu[RT_geral.Variaveis_RT_850[i].Dsp_pos.Indice];
					this.DataGridView_variaveis_RT850.Rows[i].Cells[12].Value = value;
				}
			}
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x002D4800 File Offset: 0x002D2C00
		private void GeraDataGridView_Equipamentos_CTLR_1_RT_850()
		{
			RT_geral.RT_850_Controle.LiberaEventos_Variaveis = false;
			if (this.DataGridView_Ctrl_1_RT850.ColumnCount > 0)
			{
				this.DataGridView_Ctrl_1_RT850.RowCount = 1;
				this.DataGridView_Ctrl_1_RT850.Columns.Clear();
			}
			this.DataGridView_Ctrl_1_RT850.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			this.DataGridView_Ctrl_1_RT850.DefaultCellStyle.Alignment = (System.Windows.Forms.HorizontalAlignment)32;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_850_DataGridView_ctrl_1[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_850_DataGridView_ctrl_1);
						this.DataGridView_Ctrl_1_RT850.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_850_DataGridView_ctrl_1);
						if (num >= 8)
						{
							dataGridViewTextBoxColumn.ReadOnly = true;
						}
						this.DataGridView_Ctrl_1_RT850.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					this.DataGridView_Ctrl_1_RT850.Columns[num].SortMode = 0;
					num++;
				}
				while (num <= 15);
				this.DataGridView_Ctrl_1_RT850.RowCount = RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor;
				this.DataGridView_Ctrl_1_RT850.RowHeadersWidth = 90;
				int num2 = 0;
				try
				{
					foreach (object obj = null in this.DataGridView_Ctrl_1_RT850.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "End: " + Conversion.Str(num2 + RT_geral.RT_850_BD.End_inicial_equip_tipo_1.Valor);
							num2++;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				RT_geral.RT_850_Controle.LiberaEventos_Variaveis = true;
			}
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x002D49B4 File Offset: 0x002D2DB4
		public void InicializaEstrutura_DataGridView_Equipamentos_CTLR_1_RT_850()
		{
			RT_geral.RT_850_DataGridView_ctrl_1[1].LinhasMenu = new string[3];
			RT_geral.RT_850_DataGridView_ctrl_1[1].LinhasValor = new int[3];
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasMenu = new string[9];
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasValor = new int[9];
			RT_geral.RT_850_DataGridView_ctrl_1[3].LinhasMenu = new string[4];
			RT_geral.RT_850_DataGridView_ctrl_1[3].LinhasValor = new int[4];
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu = new string[31];
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor = new int[31];
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasMenu = new string[9];
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasValor = new int[9];
			RT_geral.RT_850_DataGridView_ctrl_1[6].LinhasMenu = new string[4];
			RT_geral.RT_850_DataGridView_ctrl_1[6].LinhasValor = new int[4];
			RT_geral.RT_850_DataGridView_ctrl_1[8].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_1[8].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_1[9].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_1[9].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_1[10].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_1[10].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_1[11].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_1[11].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_1[12].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_1[12].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_1[13].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_1[13].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_1[14].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_1[14].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_1[15].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_1[15].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_1[1].LinhasValor[0] = 0;
			RT_geral.RT_850_DataGridView_ctrl_1[1].LinhasValor[1] = 1;
			RT_geral.RT_850_DataGridView_ctrl_1[1].LinhasMenu[0] = "Canal 1";
			RT_geral.RT_850_DataGridView_ctrl_1[1].LinhasMenu[1] = "Canal 2";
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasValor[0] = 0;
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasValor[1] = 1;
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasValor[2] = 2;
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasValor[3] = 3;
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasValor[4] = 4;
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasValor[5] = 5;
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasValor[6] = 6;
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasValor[7] = 7;
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasMenu[0] = "1";
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasMenu[1] = "2";
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasMenu[2] = "3";
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasMenu[3] = "4";
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasMenu[4] = "5";
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasMenu[5] = "6";
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasMenu[6] = "7";
			RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasMenu[7] = "8";
			RT_geral.RT_850_DataGridView_ctrl_1[3].LinhasValor[0] = 0;
			RT_geral.RT_850_DataGridView_ctrl_1[3].LinhasValor[1] = 1;
			RT_geral.RT_850_DataGridView_ctrl_1[3].LinhasValor[2] = 2;
			RT_geral.RT_850_DataGridView_ctrl_1[3].LinhasMenu[0] = "Desabilitado";
			RT_geral.RT_850_DataGridView_ctrl_1[3].LinhasMenu[1] = "Liberado";
			RT_geral.RT_850_DataGridView_ctrl_1[3].LinhasMenu[2] = "Bloqueado";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[0] = 0;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[1] = 1;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[2] = 2;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[3] = 3;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[4] = 6;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[5] = 7;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[6] = 8;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[7] = 11;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[8] = 12;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[9] = 13;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[10] = 16;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[11] = 17;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[12] = 18;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[13] = 19;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[14] = 20;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[15] = 21;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[16] = 23;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[17] = 24;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[18] = 28;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[19] = 9;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasValor[20] = 14;
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[0] = "Não Definido";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[1] = "RT810 010";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[2] = "RT810 200";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[3] = "RT810 300";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[4] = "RT820 010";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[5] = "RT820 200";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[6] = "RT820 300";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[7] = "RT821 010";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[8] = "RT821 200";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[9] = "RT821 300";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[10] = "VA310 42";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[11] = "VA310 50";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[12] = "VA320 35";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[13] = "VA320 50";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[14] = "VA220 42";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[15] = "VA220 50";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[16] = "MD101 43";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[17] = "MD101 4000";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[18] = "MD202 520";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[19] = "RT820 350";
			RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[20] = "RT821 400";
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasValor[0] = 0;
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasValor[1] = 1;
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasValor[2] = 2;
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasValor[3] = 3;
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasValor[4] = 4;
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasValor[5] = 5;
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasValor[6] = 6;
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasValor[7] = 7;
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasMenu[0] = "Desabilitada";
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasMenu[1] = "1";
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasMenu[2] = "2";
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasMenu[3] = "3";
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasMenu[4] = "4";
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasMenu[5] = "5";
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasMenu[6] = "6";
			RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasMenu[7] = "7";
			int i = 0;
			checked
			{
				do
				{
					RT_geral.RT_850_DataGridView_ctrl_1[6].LinhasMenu[i] = RT_geral.Nome_ctrl[i];
					RT_geral.RT_850_DataGridView_ctrl_1[6].LinhasValor[i] = i;
					i++;
				}
				while (i <= 2);
				RT_geral.RT_850_DataGridView_ctrl_1[8].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_1[9].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_1[10].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_1[11].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_1[12].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_1[13].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_1[14].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_1[15].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_1[8].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_1[8].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_1[9].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_1[9].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_1[10].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_1[10].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_1[11].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_1[11].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_1[12].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_1[12].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_1[13].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_1[13].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_1[14].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_1[14].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_1[15].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_1[15].LinhasValor[0] = 0;
				if (RT_geral.RT_850_BD.Variaveis_Numero.Valor > 0)
				{
					int num = 1;
					int valor = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
					for (i = num; i <= valor; i++)
					{
						RT_geral.RT_850_DataGridView_ctrl_1[8].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_1[8].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_1[9].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_1[9].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_1[10].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_1[10].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_1[11].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_1[11].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_1[12].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_1[12].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_1[13].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_1[13].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_1[14].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_1[14].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_1[15].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_1[15].LinhasValor[i] = i;
					}
				}
				RT_geral.RT_850_DataGridView_ctrl_1[0].TagColuna = "Nome";
				RT_geral.RT_850_DataGridView_ctrl_1[1].TagColuna = "Canal";
				RT_geral.RT_850_DataGridView_ctrl_1[2].TagColuna = "Timeout";
				RT_geral.RT_850_DataGridView_ctrl_1[3].TagColuna = "Comando";
				RT_geral.RT_850_DataGridView_ctrl_1[4].TagColuna = "Prioridade";
				RT_geral.RT_850_DataGridView_ctrl_1[5].TagColuna = "Modelo";
				RT_geral.RT_850_DataGridView_ctrl_1[6].TagColuna = "Ctrl Msg";
				RT_geral.RT_850_DataGridView_ctrl_1[7].TagColuna = "Ctrl N°";
				RT_geral.RT_850_DataGridView_ctrl_1[8].TagColuna = "Var 1";
				RT_geral.RT_850_DataGridView_ctrl_1[9].TagColuna = "Var 2";
				RT_geral.RT_850_DataGridView_ctrl_1[10].TagColuna = "Var 3";
				RT_geral.RT_850_DataGridView_ctrl_1[11].TagColuna = "Var 4";
				RT_geral.RT_850_DataGridView_ctrl_1[12].TagColuna = "Ref 1";
				RT_geral.RT_850_DataGridView_ctrl_1[13].TagColuna = "Ref 2";
				RT_geral.RT_850_DataGridView_ctrl_1[14].TagColuna = "Ref 3";
				RT_geral.RT_850_DataGridView_ctrl_1[15].TagColuna = "Ref 4";
				RT_geral.RT_850_DataGridView_ctrl_1[0].NomeColuna = "Nome";
				RT_geral.RT_850_DataGridView_ctrl_1[1].NomeColuna = "Canal";
				RT_geral.RT_850_DataGridView_ctrl_1[2].NomeColuna = "Timeout";
				RT_geral.RT_850_DataGridView_ctrl_1[3].NomeColuna = "Comando";
				RT_geral.RT_850_DataGridView_ctrl_1[4].NomeColuna = "Prioridade";
				RT_geral.RT_850_DataGridView_ctrl_1[5].NomeColuna = "Modelo";
				RT_geral.RT_850_DataGridView_ctrl_1[6].NomeColuna = "Ctr1_msg";
				RT_geral.RT_850_DataGridView_ctrl_1[7].NomeColuna = "Ctrl1_num";
				RT_geral.RT_850_DataGridView_ctrl_1[8].NomeColuna = "Var_1";
				RT_geral.RT_850_DataGridView_ctrl_1[9].NomeColuna = "Var_2";
				RT_geral.RT_850_DataGridView_ctrl_1[10].NomeColuna = "Var_3";
				RT_geral.RT_850_DataGridView_ctrl_1[11].NomeColuna = "Var_4";
				RT_geral.RT_850_DataGridView_ctrl_1[12].NomeColuna = "Ref_1";
				RT_geral.RT_850_DataGridView_ctrl_1[13].NomeColuna = "Ref_2";
				RT_geral.RT_850_DataGridView_ctrl_1[14].NomeColuna = "Ref_3";
				RT_geral.RT_850_DataGridView_ctrl_1[15].NomeColuna = "Ref_4";
				RT_geral.RT_850_DataGridView_ctrl_1[0].LarguraColuna = Conversions.ToInteger("80");
				RT_geral.RT_850_DataGridView_ctrl_1[1].LarguraColuna = Conversions.ToInteger("75");
				RT_geral.RT_850_DataGridView_ctrl_1[2].LarguraColuna = Conversions.ToInteger("80");
				RT_geral.RT_850_DataGridView_ctrl_1[3].LarguraColuna = Conversions.ToInteger("95");
				RT_geral.RT_850_DataGridView_ctrl_1[4].LarguraColuna = Conversions.ToInteger("90");
				RT_geral.RT_850_DataGridView_ctrl_1[5].LarguraColuna = Conversions.ToInteger("95");
				RT_geral.RT_850_DataGridView_ctrl_1[6].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_1[7].LarguraColuna = Conversions.ToInteger("70");
				RT_geral.RT_850_DataGridView_ctrl_1[8].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_1[9].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_1[10].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_1[11].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_1[12].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_1[13].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_1[14].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_1[15].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_1[0].AlingColuna = 16;
				RT_geral.RT_850_DataGridView_ctrl_1[1].AlingColuna = 16;
				RT_geral.RT_850_DataGridView_ctrl_1[2].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_1[3].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_1[4].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_1[5].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_1[6].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_1[7].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_1[8].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_1[9].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_1[10].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_1[11].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_1[12].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_1[13].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_1[14].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_1[15].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_1[0].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_ctrl_1[1].NumeroLinhaMenu = 2;
				RT_geral.RT_850_DataGridView_ctrl_1[2].NumeroLinhaMenu = 8;
				RT_geral.RT_850_DataGridView_ctrl_1[3].NumeroLinhaMenu = 3;
				RT_geral.RT_850_DataGridView_ctrl_1[4].NumeroLinhaMenu = 8;
				RT_geral.RT_850_DataGridView_ctrl_1[5].NumeroLinhaMenu = 21;
				RT_geral.RT_850_DataGridView_ctrl_1[6].NumeroLinhaMenu = 3;
				RT_geral.RT_850_DataGridView_ctrl_1[7].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_ctrl_1[8].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_1[9].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_1[10].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_1[11].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_1[12].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_1[13].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_1[14].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_1[15].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
			}
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x002D5F54 File Offset: 0x002D4354
		private void Atualiza_DataGridView_Ctrl_1()
		{
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					this.DataGridView_Ctrl_1_RT850.Rows[i].Cells[0].Value = RT_geral.RT_850_Ctrl_1[i].Nome.Valor;
					string value = RT_geral.RT_850_DataGridView_ctrl_1[1].LinhasMenu[RT_geral.RT_850_Ctrl_1[i].Canal.Indice];
					this.DataGridView_Ctrl_1_RT850.Rows[i].Cells[1].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_1[2].LinhasMenu[RT_geral.RT_850_Ctrl_1[i].Timeout.Indice];
					this.DataGridView_Ctrl_1_RT850.Rows[i].Cells[2].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_1[3].LinhasMenu[RT_geral.RT_850_Ctrl_1[i].Comando.Indice];
					this.DataGridView_Ctrl_1_RT850.Rows[i].Cells[3].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_1[4].LinhasMenu[RT_geral.RT_850_Ctrl_1[i].Prioridade.Indice];
					this.DataGridView_Ctrl_1_RT850.Rows[i].Cells[4].Value = value;
					int num3 = RT_geral.Localiza_indice_combo(ref RT_geral.RT_850_DataGridView_ctrl_1[5], RT_geral.RT_850_Ctrl_1[i].Modelo.Indice);
					value = RT_geral.RT_850_DataGridView_ctrl_1[5].LinhasMenu[num3];
					this.DataGridView_Ctrl_1_RT850.Rows[i].Cells[5].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_1[6].LinhasMenu[RT_geral.RT_850_Ctrl_1[i].Crtl_nome[0].Indice];
					this.DataGridView_Ctrl_1_RT850.Rows[i].Cells[6].Value = value;
					this.DataGridView_Ctrl_1_RT850.Rows[i].Cells[7].Value = RT_geral.RT_850_Ctrl_1[i].Crtl_indice[0].Valor;
					value = RT_geral.RT_850_DataGridView_ctrl_1[8].LinhasMenu[RT_geral.RT_850_Ctrl_1[i].Var[0].Indice];
					this.DataGridView_Ctrl_1_RT850.Rows[i].Cells[8].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_1[9].LinhasMenu[RT_geral.RT_850_Ctrl_1[i].Var[1].Indice];
					this.DataGridView_Ctrl_1_RT850.Rows[i].Cells[9].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_1[10].LinhasMenu[RT_geral.RT_850_Ctrl_1[i].Var[2].Indice];
					this.DataGridView_Ctrl_1_RT850.Rows[i].Cells[10].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_1[11].LinhasMenu[RT_geral.RT_850_Ctrl_1[i].Var[3].Indice];
					this.DataGridView_Ctrl_1_RT850.Rows[i].Cells[11].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_1[12].LinhasMenu[RT_geral.RT_850_Ctrl_1[i].Ref[0].Indice];
					this.DataGridView_Ctrl_1_RT850.Rows[i].Cells[12].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_1[13].LinhasMenu[RT_geral.RT_850_Ctrl_1[i].Ref[1].Indice];
					this.DataGridView_Ctrl_1_RT850.Rows[i].Cells[13].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_1[14].LinhasMenu[RT_geral.RT_850_Ctrl_1[i].Ref[2].Indice];
					this.DataGridView_Ctrl_1_RT850.Rows[i].Cells[14].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_1[15].LinhasMenu[RT_geral.RT_850_Ctrl_1[i].Ref[3].Indice];
					this.DataGridView_Ctrl_1_RT850.Rows[i].Cells[15].Value = value;
					Application.DoEvents();
				}
				if (RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor < 15)
				{
					this.DataGridView_Ctrl_1_RT850.Height = 41 + RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor * this.DataGridView_Ctrl_1_RT850.RowTemplate.Height;
				}
				else
				{
					this.DataGridView_Ctrl_1_RT850.Height = 41 + 15 * this.DataGridView_Ctrl_1_RT850.RowTemplate.Height;
				}
			}
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x002D64BC File Offset: 0x002D48BC
		private void GeraDataGridView_Equipamentos_CTLR_4_RT_850()
		{
			RT_geral.RT_850_Controle.LiberaEventos_Variaveis = false;
			if (this.DataGridView_Ctrl_4_RT850.ColumnCount > 0)
			{
				this.DataGridView_Ctrl_4_RT850.RowCount = 1;
				this.DataGridView_Ctrl_4_RT850.Columns.Clear();
			}
			this.DataGridView_Ctrl_4_RT850.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			this.DataGridView_Ctrl_4_RT850.DefaultCellStyle.Alignment = (System.Windows.Forms.HorizontalAlignment)32;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_850_DataGridView_ctrl_4[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_850_DataGridView_ctrl_4);
						this.DataGridView_Ctrl_4_RT850.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_850_DataGridView_ctrl_4);
						if (num >= 14)
						{
							dataGridViewTextBoxColumn.ReadOnly = true;
						}
						this.DataGridView_Ctrl_4_RT850.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					this.DataGridView_Ctrl_4_RT850.Columns[num].SortMode = 0;
					num++;
				}
				while (num <= 31);
				this.DataGridView_Ctrl_4_RT850.RowCount = RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor;
				this.DataGridView_Ctrl_4_RT850.RowHeadersWidth = 90;
				int num2 = 0;
				try
				{
					foreach (object obj = null in this.DataGridView_Ctrl_4_RT850.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "End: " + Conversion.Str(num2 + RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Valor);
							num2++;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				RT_geral.RT_850_Controle.LiberaEventos_Variaveis = true;
			}
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x002D6670 File Offset: 0x002D4A70
		public void InicializaEstrutura_DataGridView_Equipamentos_CTLR_4_RT_850()
		{
			RT_geral.RT_850_DataGridView_ctrl_4[1].LinhasMenu = new string[3];
			RT_geral.RT_850_DataGridView_ctrl_4[1].LinhasValor = new int[3];
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu = new string[9];
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor = new int[9];
			RT_geral.RT_850_DataGridView_ctrl_4[3].LinhasMenu = new string[4];
			RT_geral.RT_850_DataGridView_ctrl_4[3].LinhasValor = new int[4];
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu = new string[9];
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor = new int[9];
			RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu = new string[22];
			RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor = new int[22];
			RT_geral.RT_850_DataGridView_ctrl_4[6].LinhasMenu = new string[4];
			RT_geral.RT_850_DataGridView_ctrl_4[6].LinhasValor = new int[4];
			RT_geral.RT_850_DataGridView_ctrl_4[8].LinhasMenu = new string[4];
			RT_geral.RT_850_DataGridView_ctrl_4[8].LinhasValor = new int[4];
			RT_geral.RT_850_DataGridView_ctrl_4[10].LinhasMenu = new string[4];
			RT_geral.RT_850_DataGridView_ctrl_4[10].LinhasValor = new int[4];
			RT_geral.RT_850_DataGridView_ctrl_4[12].LinhasMenu = new string[4];
			RT_geral.RT_850_DataGridView_ctrl_4[12].LinhasValor = new int[4];
			RT_geral.RT_850_DataGridView_ctrl_4[14].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_4[14].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_4[15].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_4[15].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_4[16].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_4[16].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_4[17].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_4[17].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_4[18].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_4[18].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_4[19].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_4[19].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_4[20].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_4[20].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_4[21].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_4[21].LinhasValor = new int[301];
			checked
			{
				RT_geral.RT_850_DataGridView_ctrl_4[22].LinhasMenu = new string[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_4[22].LinhasValor = new int[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_4[24].LinhasMenu = new string[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_4[24].LinhasValor = new int[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_4[26].LinhasMenu = new string[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_4[26].LinhasValor = new int[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_4[28].LinhasMenu = new string[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_4[28].LinhasValor = new int[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_4[30].LinhasMenu = new string[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_4[30].LinhasValor = new int[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_4[23].LinhasMenu = new string[66];
				RT_geral.RT_850_DataGridView_ctrl_4[23].LinhasValor = new int[66];
				RT_geral.RT_850_DataGridView_ctrl_4[25].LinhasMenu = new string[66];
				RT_geral.RT_850_DataGridView_ctrl_4[25].LinhasValor = new int[66];
				RT_geral.RT_850_DataGridView_ctrl_4[27].LinhasMenu = new string[66];
				RT_geral.RT_850_DataGridView_ctrl_4[27].LinhasValor = new int[66];
				RT_geral.RT_850_DataGridView_ctrl_4[29].LinhasMenu = new string[66];
				RT_geral.RT_850_DataGridView_ctrl_4[29].LinhasValor = new int[66];
				RT_geral.RT_850_DataGridView_ctrl_4[31].LinhasMenu = new string[66];
				RT_geral.RT_850_DataGridView_ctrl_4[31].LinhasValor = new int[66];
				RT_geral.RT_850_DataGridView_ctrl_4[1].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[1].LinhasValor[1] = 1;
				RT_geral.RT_850_DataGridView_ctrl_4[1].LinhasMenu[0] = "Canal 1";
				RT_geral.RT_850_DataGridView_ctrl_4[1].LinhasMenu[1] = "Canal 2";
				RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor[1] = 1;
				RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor[2] = 2;
				RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor[3] = 3;
				RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor[4] = 4;
				RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor[5] = 5;
				RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor[6] = 6;
				RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor[7] = 7;
				RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[0] = "1";
				RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[1] = "2";
				RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[2] = "3";
				RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[3] = "4";
				RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[4] = "5";
				RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[5] = "6";
				RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[6] = "7";
				RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[7] = "8";
				RT_geral.RT_850_DataGridView_ctrl_4[3].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[3].LinhasValor[1] = 1;
				RT_geral.RT_850_DataGridView_ctrl_4[3].LinhasValor[2] = 2;
				RT_geral.RT_850_DataGridView_ctrl_4[3].LinhasMenu[0] = "Desabilitado";
				RT_geral.RT_850_DataGridView_ctrl_4[3].LinhasMenu[1] = "Liberado";
				RT_geral.RT_850_DataGridView_ctrl_4[3].LinhasMenu[2] = "Bloqueado";
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[1] = 1;
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[2] = 2;
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[3] = 3;
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[4] = 6;
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[5] = 7;
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[6] = 8;
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[7] = 11;
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[8] = 12;
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[9] = 13;
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[10] = 14;
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[11] = 19;
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[12] = 4;
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[13] = 9;
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[14] = 5;
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu[0] = "Não Definido";
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu[1] = "RT820 010";
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu[2] = "RT820 200";
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu[3] = "RT820 300";
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu[4] = "RT821 010";
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu[5] = "RT821 200";
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu[6] = "RT821 300";
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu[7] = "VA320 35";
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu[8] = "VA320 50";
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu[9] = "VA220 42";
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu[10] = "VA220 50";
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu[11] = "MD202 520";
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu[12] = "RT820 350";
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu[13] = "RT821 400";
				RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu[14] = "RT820 400";
				RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor[1] = 1;
				RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor[2] = 2;
				RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor[3] = 3;
				RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor[4] = 4;
				RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor[5] = 5;
				RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor[6] = 6;
				RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor[7] = 7;
				RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[0] = "Desabilitada";
				RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[1] = "1";
				RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[2] = "2";
				RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[3] = "3";
				RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[4] = "4";
				RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[5] = "5";
				RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[6] = "6";
				RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[7] = "7";
				int i = 0;
				do
				{
					RT_geral.RT_850_DataGridView_ctrl_4[6].LinhasMenu[i] = RT_geral.Nome_ctrl[i];
					RT_geral.RT_850_DataGridView_ctrl_4[6].LinhasValor[i] = i;
					RT_geral.RT_850_DataGridView_ctrl_4[8].LinhasMenu[i] = RT_geral.Nome_ctrl[i];
					RT_geral.RT_850_DataGridView_ctrl_4[8].LinhasValor[i] = i;
					RT_geral.RT_850_DataGridView_ctrl_4[10].LinhasMenu[i] = RT_geral.Nome_ctrl[i];
					RT_geral.RT_850_DataGridView_ctrl_4[10].LinhasValor[i] = i;
					RT_geral.RT_850_DataGridView_ctrl_4[12].LinhasMenu[i] = RT_geral.Nome_ctrl[i];
					RT_geral.RT_850_DataGridView_ctrl_4[12].LinhasValor[i] = i;
					i++;
				}
				while (i <= 2);
				RT_geral.RT_850_DataGridView_ctrl_4[14].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_4[15].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_4[16].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_4[17].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_4[18].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_4[19].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_4[20].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_4[21].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_4[14].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_4[14].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[15].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_4[15].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[16].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_4[16].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[17].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_4[17].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[18].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_4[18].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[19].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_4[19].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[20].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_4[20].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[21].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_4[21].LinhasValor[0] = 0;
				i = 0;
				do
				{
					int num = 0;
					try
					{
						foreach (perifericos.Periferico periferico in perifericos.perif_CT850_300)
						{
							RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[num] = periferico.nome;
							RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[num] = num;
							num++;
						}
					}
					finally
					{
						List<perifericos.Periferico>.Enumerator enumerator;
						enumerator.Dispose();
					}
					RT_geral.RT_850_DataGridView_ctrl_4[23 + i].LinhasMenu[0] = "----";
					RT_geral.RT_850_DataGridView_ctrl_4[23 + i].LinhasValor[0] = 0;
					int num2 = 1;
					do
					{
						RT_geral.RT_850_DataGridView_ctrl_4[23 + i].LinhasMenu[num2] = Conversion.Str(num2);
						RT_geral.RT_850_DataGridView_ctrl_4[23 + i].LinhasValor[num2] = num2;
						num2++;
					}
					while (num2 <= 65);
					i += 2;
				}
				while (i <= 8);
				if (RT_geral.RT_850_BD.Variaveis_Numero.Valor > 0)
				{
					int num3 = 1;
					int valor = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
					for (i = num3; i <= valor; i++)
					{
						RT_geral.RT_850_DataGridView_ctrl_4[14].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_4[14].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_4[15].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_4[15].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_4[16].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_4[16].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_4[17].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_4[17].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_4[18].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_4[18].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_4[19].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_4[19].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_4[20].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_4[20].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_4[21].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_4[21].LinhasValor[i] = i;
					}
				}
				RT_geral.RT_850_DataGridView_ctrl_4[0].TagColuna = "Nome";
				RT_geral.RT_850_DataGridView_ctrl_4[1].TagColuna = "Canal";
				RT_geral.RT_850_DataGridView_ctrl_4[2].TagColuna = "Timeout";
				RT_geral.RT_850_DataGridView_ctrl_4[3].TagColuna = "Comando";
				RT_geral.RT_850_DataGridView_ctrl_4[4].TagColuna = "Prioridade";
				RT_geral.RT_850_DataGridView_ctrl_4[5].TagColuna = "Modelo";
				RT_geral.RT_850_DataGridView_ctrl_4[6].TagColuna = "Ctrl 1 Msg";
				RT_geral.RT_850_DataGridView_ctrl_4[7].TagColuna = "Ctrl 1 N°";
				RT_geral.RT_850_DataGridView_ctrl_4[8].TagColuna = "Ctrl 2 Msg";
				RT_geral.RT_850_DataGridView_ctrl_4[9].TagColuna = "Ctrl 2 N°";
				RT_geral.RT_850_DataGridView_ctrl_4[10].TagColuna = "Ctrl 3 Msg";
				RT_geral.RT_850_DataGridView_ctrl_4[11].TagColuna = "Ctrl 3 N°";
				RT_geral.RT_850_DataGridView_ctrl_4[12].TagColuna = "Ctrl 4 Msg";
				RT_geral.RT_850_DataGridView_ctrl_4[13].TagColuna = "Ctrl 4 N°";
				RT_geral.RT_850_DataGridView_ctrl_4[14].TagColuna = "Var 1";
				RT_geral.RT_850_DataGridView_ctrl_4[15].TagColuna = "Var 2";
				RT_geral.RT_850_DataGridView_ctrl_4[16].TagColuna = "Var 3";
				RT_geral.RT_850_DataGridView_ctrl_4[17].TagColuna = "Var 4";
				RT_geral.RT_850_DataGridView_ctrl_4[18].TagColuna = "Ref 1";
				RT_geral.RT_850_DataGridView_ctrl_4[19].TagColuna = "Ref 2";
				RT_geral.RT_850_DataGridView_ctrl_4[20].TagColuna = "Ref 3";
				RT_geral.RT_850_DataGridView_ctrl_4[21].TagColuna = "Ref 4";
				RT_geral.RT_850_DataGridView_ctrl_4[22].TagColuna = "Periférico 1 - Modelo";
				RT_geral.RT_850_DataGridView_ctrl_4[23].TagColuna = "Índice 1";
				RT_geral.RT_850_DataGridView_ctrl_4[24].TagColuna = "Periférico 2 - Modelo";
				RT_geral.RT_850_DataGridView_ctrl_4[25].TagColuna = "Índice 2";
				RT_geral.RT_850_DataGridView_ctrl_4[26].TagColuna = "Periférico 3 - Modelo";
				RT_geral.RT_850_DataGridView_ctrl_4[27].TagColuna = "Índice 3";
				RT_geral.RT_850_DataGridView_ctrl_4[28].TagColuna = "Periférico 4 - Modelo";
				RT_geral.RT_850_DataGridView_ctrl_4[29].TagColuna = "Índice 4";
				RT_geral.RT_850_DataGridView_ctrl_4[30].TagColuna = "Periférico 5 - Modelo";
				RT_geral.RT_850_DataGridView_ctrl_4[31].TagColuna = "Índice 5";
				RT_geral.RT_850_DataGridView_ctrl_4[0].NomeColuna = "Nome";
				RT_geral.RT_850_DataGridView_ctrl_4[1].NomeColuna = "Canal";
				RT_geral.RT_850_DataGridView_ctrl_4[2].NomeColuna = "Timeout";
				RT_geral.RT_850_DataGridView_ctrl_4[3].NomeColuna = "Comando";
				RT_geral.RT_850_DataGridView_ctrl_4[4].NomeColuna = "Prioridade";
				RT_geral.RT_850_DataGridView_ctrl_4[5].NomeColuna = "Modelo";
				RT_geral.RT_850_DataGridView_ctrl_4[6].NomeColuna = "Ctr1_msg";
				RT_geral.RT_850_DataGridView_ctrl_4[7].NomeColuna = "Ctrl1_num";
				RT_geral.RT_850_DataGridView_ctrl_4[8].NomeColuna = "Ctr2_msg";
				RT_geral.RT_850_DataGridView_ctrl_4[9].NomeColuna = "Ctrl2_num";
				RT_geral.RT_850_DataGridView_ctrl_4[10].NomeColuna = "Ctr3_msg";
				RT_geral.RT_850_DataGridView_ctrl_4[11].NomeColuna = "Ctrl3_num";
				RT_geral.RT_850_DataGridView_ctrl_4[12].NomeColuna = "Ctr4_msg";
				RT_geral.RT_850_DataGridView_ctrl_4[13].NomeColuna = "Ctrl4_num";
				RT_geral.RT_850_DataGridView_ctrl_4[14].NomeColuna = "Var_1";
				RT_geral.RT_850_DataGridView_ctrl_4[15].NomeColuna = "Var_2";
				RT_geral.RT_850_DataGridView_ctrl_4[16].NomeColuna = "Var_3";
				RT_geral.RT_850_DataGridView_ctrl_4[17].NomeColuna = "Var_4";
				RT_geral.RT_850_DataGridView_ctrl_4[18].NomeColuna = "Ref_1";
				RT_geral.RT_850_DataGridView_ctrl_4[19].NomeColuna = "Ref_2";
				RT_geral.RT_850_DataGridView_ctrl_4[20].NomeColuna = "Ref_3";
				RT_geral.RT_850_DataGridView_ctrl_4[21].NomeColuna = "Ref_4";
				RT_geral.RT_850_DataGridView_ctrl_4[22].NomeColuna = "Per_1";
				RT_geral.RT_850_DataGridView_ctrl_4[23].NomeColuna = "Loc_1";
				RT_geral.RT_850_DataGridView_ctrl_4[24].NomeColuna = "Per_2";
				RT_geral.RT_850_DataGridView_ctrl_4[25].NomeColuna = "Loc_2";
				RT_geral.RT_850_DataGridView_ctrl_4[26].NomeColuna = "Per_3";
				RT_geral.RT_850_DataGridView_ctrl_4[27].NomeColuna = "Loc_3";
				RT_geral.RT_850_DataGridView_ctrl_4[28].NomeColuna = "Per_4";
				RT_geral.RT_850_DataGridView_ctrl_4[29].NomeColuna = "Loc_4";
				RT_geral.RT_850_DataGridView_ctrl_4[30].NomeColuna = "Per_5";
				RT_geral.RT_850_DataGridView_ctrl_4[31].NomeColuna = "Loc_5";
				RT_geral.RT_850_DataGridView_ctrl_4[0].LarguraColuna = Conversions.ToInteger("80");
				RT_geral.RT_850_DataGridView_ctrl_4[1].LarguraColuna = Conversions.ToInteger("75");
				RT_geral.RT_850_DataGridView_ctrl_4[2].LarguraColuna = Conversions.ToInteger("80");
				RT_geral.RT_850_DataGridView_ctrl_4[3].LarguraColuna = Conversions.ToInteger("95");
				RT_geral.RT_850_DataGridView_ctrl_4[4].LarguraColuna = Conversions.ToInteger("90");
				RT_geral.RT_850_DataGridView_ctrl_4[5].LarguraColuna = Conversions.ToInteger("95");
				RT_geral.RT_850_DataGridView_ctrl_4[6].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_4[7].LarguraColuna = Conversions.ToInteger("70");
				RT_geral.RT_850_DataGridView_ctrl_4[8].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_4[9].LarguraColuna = Conversions.ToInteger("70");
				RT_geral.RT_850_DataGridView_ctrl_4[10].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_4[11].LarguraColuna = Conversions.ToInteger("70");
				RT_geral.RT_850_DataGridView_ctrl_4[12].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_4[13].LarguraColuna = Conversions.ToInteger("70");
				RT_geral.RT_850_DataGridView_ctrl_4[14].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_4[15].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_4[16].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_4[17].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_4[18].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_4[19].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_4[20].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_4[21].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_4[22].LarguraColuna = Conversions.ToInteger("180");
				RT_geral.RT_850_DataGridView_ctrl_4[23].LarguraColuna = Conversions.ToInteger("75");
				RT_geral.RT_850_DataGridView_ctrl_4[24].LarguraColuna = Conversions.ToInteger("180");
				RT_geral.RT_850_DataGridView_ctrl_4[25].LarguraColuna = Conversions.ToInteger("75");
				RT_geral.RT_850_DataGridView_ctrl_4[26].LarguraColuna = Conversions.ToInteger("180");
				RT_geral.RT_850_DataGridView_ctrl_4[27].LarguraColuna = Conversions.ToInteger("75");
				RT_geral.RT_850_DataGridView_ctrl_4[28].LarguraColuna = Conversions.ToInteger("180");
				RT_geral.RT_850_DataGridView_ctrl_4[29].LarguraColuna = Conversions.ToInteger("75");
				RT_geral.RT_850_DataGridView_ctrl_4[30].LarguraColuna = Conversions.ToInteger("180");
				RT_geral.RT_850_DataGridView_ctrl_4[31].LarguraColuna = Conversions.ToInteger("75");
				RT_geral.RT_850_DataGridView_ctrl_4[0].AlingColuna = 16;
				RT_geral.RT_850_DataGridView_ctrl_4[1].AlingColuna = 256;
				RT_geral.RT_850_DataGridView_ctrl_4[2].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[3].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[4].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[5].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[6].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[7].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[8].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[9].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[10].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[11].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[12].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[13].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[14].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[15].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[16].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[17].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[18].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[19].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[20].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[21].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[22].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[23].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[24].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[25].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[26].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[27].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[28].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[29].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[30].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[31].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_4[0].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[1].NumeroLinhaMenu = 2;
				RT_geral.RT_850_DataGridView_ctrl_4[2].NumeroLinhaMenu = 8;
				RT_geral.RT_850_DataGridView_ctrl_4[3].NumeroLinhaMenu = 3;
				RT_geral.RT_850_DataGridView_ctrl_4[4].NumeroLinhaMenu = 8;
				RT_geral.RT_850_DataGridView_ctrl_4[5].NumeroLinhaMenu = 15;
				RT_geral.RT_850_DataGridView_ctrl_4[6].NumeroLinhaMenu = 3;
				RT_geral.RT_850_DataGridView_ctrl_4[7].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[8].NumeroLinhaMenu = 3;
				RT_geral.RT_850_DataGridView_ctrl_4[9].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[10].NumeroLinhaMenu = 3;
				RT_geral.RT_850_DataGridView_ctrl_4[11].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[12].NumeroLinhaMenu = 3;
				RT_geral.RT_850_DataGridView_ctrl_4[13].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_ctrl_4[14].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_4[15].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_4[16].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_4[17].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_4[18].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_4[19].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_4[20].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_4[21].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_4[22].NumeroLinhaMenu = perifericos.perif_CT850_300.Count;
				RT_geral.RT_850_DataGridView_ctrl_4[23].NumeroLinhaMenu = 66;
				RT_geral.RT_850_DataGridView_ctrl_4[24].NumeroLinhaMenu = perifericos.perif_CT850_300.Count;
				RT_geral.RT_850_DataGridView_ctrl_4[25].NumeroLinhaMenu = 66;
				RT_geral.RT_850_DataGridView_ctrl_4[26].NumeroLinhaMenu = perifericos.perif_CT850_300.Count;
				RT_geral.RT_850_DataGridView_ctrl_4[27].NumeroLinhaMenu = 66;
				RT_geral.RT_850_DataGridView_ctrl_4[28].NumeroLinhaMenu = perifericos.perif_CT850_300.Count;
				RT_geral.RT_850_DataGridView_ctrl_4[29].NumeroLinhaMenu = 66;
				RT_geral.RT_850_DataGridView_ctrl_4[30].NumeroLinhaMenu = perifericos.perif_CT850_300.Count;
				RT_geral.RT_850_DataGridView_ctrl_4[31].NumeroLinhaMenu = 66;
			}
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x002D8648 File Offset: 0x002D6A48
		private void Atualiza_DataGridView_Ctrl_4()
		{
			checked
			{
				int num = 0;
				int num5;
				object obj = null;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					int num2 = 0;
					int num3 = RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (i == 25 | i == 26)
						{
						}
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[0].Value = RT_geral.RT_850_Ctrl_4[i].Nome.Valor;
						string value = RT_geral.RT_850_DataGridView_ctrl_4[1].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Canal.Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[1].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Timeout.Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[2].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[3].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Comando.Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[3].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Prioridade.Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[4].Value = value;
						int num4 = RT_geral.Localiza_indice_combo(ref RT_geral.RT_850_DataGridView_ctrl_4[5], RT_geral.RT_850_Ctrl_4[i].Modelo.Indice);
						value = RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasMenu[num4];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[5].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[6].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Crtl_nome[0].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[6].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[8].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Crtl_nome[1].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[8].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[10].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Crtl_nome[2].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[10].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[12].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Crtl_nome[3].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[12].Value = value;
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[7].Value = RT_geral.RT_850_Ctrl_4[i].Crtl_indice[0].Valor;
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[9].Value = RT_geral.RT_850_Ctrl_4[i].Crtl_indice[1].Valor;
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[11].Value = RT_geral.RT_850_Ctrl_4[i].Crtl_indice[2].Valor;
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[13].Value = RT_geral.RT_850_Ctrl_4[i].Crtl_indice[3].Valor;
						value = RT_geral.RT_850_DataGridView_ctrl_4[14].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Var[0].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[14].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[15].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Var[1].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[15].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[16].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Var[2].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[16].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[17].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Var[3].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[17].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[18].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Ref[0].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[18].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[19].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Ref[1].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[19].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[20].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Ref[2].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[20].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[21].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Ref[3].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[21].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[22].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Periferico_Modelo[0].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[22].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[24].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Periferico_Modelo[1].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[24].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[26].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Periferico_Modelo[2].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[26].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[28].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Periferico_Modelo[3].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[28].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[30].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Periferico_Modelo[4].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[30].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[23].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Periferico_Indice[0].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[23].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[25].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Periferico_Indice[1].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[25].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[27].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Periferico_Indice[2].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[27].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[29].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Periferico_Indice[3].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[29].Value = value;
						value = RT_geral.RT_850_DataGridView_ctrl_4[31].LinhasMenu[RT_geral.RT_850_Ctrl_4[i].Periferico_Indice[4].Indice];
						this.DataGridView_Ctrl_4_RT850.Rows[i].Cells[31].Value = value;
					}
					IL_9EF:
					goto IL_A3C;
					IL_9F7:
					num5 = -1;
										IL_A0D:;
				}
				catch (Exception) { }
				throw ProjectData.CreateProjectError(-2146828237);
				IL_A3C:
				if (num5 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x002D90B8 File Offset: 0x002D74B8
		private void GeraDataGridView_Equipamentos_CTLR_8_RT_850()
		{
			RT_geral.RT_850_Controle.LiberaEventos_Variaveis = false;
			if (this.DataGridView_Ctrl_8_RT850.ColumnCount > 0)
			{
				this.DataGridView_Ctrl_8_RT850.RowCount = 1;
				this.DataGridView_Ctrl_8_RT850.Columns.Clear();
			}
			this.DataGridView_Ctrl_8_RT850.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			this.DataGridView_Ctrl_8_RT850.DefaultCellStyle.Alignment = (System.Windows.Forms.HorizontalAlignment)32;
			int num = 0;
			checked
			{
				do
				{
					if (num == 42)
					{
						string text = num.ToString();
					}
					if (RT_geral.RT_850_DataGridView_ctrl_8[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_850_DataGridView_ctrl_8);
						this.DataGridView_Ctrl_8_RT850.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_850_DataGridView_ctrl_8);
						if (num >= 22)
						{
							dataGridViewTextBoxColumn.ReadOnly = true;
						}
						this.DataGridView_Ctrl_8_RT850.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					this.DataGridView_Ctrl_8_RT850.Columns[num].SortMode = 0;
					num++;
				}
				while (num <= 51);
				this.DataGridView_Ctrl_8_RT850.RowCount = RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor;
				this.DataGridView_Ctrl_8_RT850.RowHeadersWidth = 90;
				int num2 = 0;
				try
				{
					foreach (object obj = null in this.DataGridView_Ctrl_8_RT850.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "End: " + Conversion.Str(num2 + RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Valor);
							num2++;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				RT_geral.RT_850_Controle.LiberaEventos_Variaveis = true;
			}
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x002D927C File Offset: 0x002D767C
		public void InicializaEstrutura_DataGridView_Equipamentos_CTLR_8_RT_850()
		{
			RT_geral.RT_850_DataGridView_ctrl_8[1].LinhasMenu = new string[3];
			RT_geral.RT_850_DataGridView_ctrl_8[1].LinhasValor = new int[3];
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu = new string[9];
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor = new int[9];
			RT_geral.RT_850_DataGridView_ctrl_8[3].LinhasMenu = new string[4];
			RT_geral.RT_850_DataGridView_ctrl_8[3].LinhasValor = new int[4];
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu = new string[9];
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor = new int[9];
			RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasMenu = new string[6];
			RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasValor = new int[6];
			RT_geral.RT_850_DataGridView_ctrl_8[6].LinhasMenu = new string[4];
			RT_geral.RT_850_DataGridView_ctrl_8[6].LinhasValor = new int[4];
			RT_geral.RT_850_DataGridView_ctrl_8[8].LinhasMenu = new string[4];
			RT_geral.RT_850_DataGridView_ctrl_8[8].LinhasValor = new int[4];
			RT_geral.RT_850_DataGridView_ctrl_8[10].LinhasMenu = new string[4];
			RT_geral.RT_850_DataGridView_ctrl_8[10].LinhasValor = new int[4];
			RT_geral.RT_850_DataGridView_ctrl_8[12].LinhasMenu = new string[4];
			RT_geral.RT_850_DataGridView_ctrl_8[12].LinhasValor = new int[4];
			RT_geral.RT_850_DataGridView_ctrl_8[14].LinhasMenu = new string[4];
			RT_geral.RT_850_DataGridView_ctrl_8[14].LinhasValor = new int[4];
			RT_geral.RT_850_DataGridView_ctrl_8[16].LinhasMenu = new string[4];
			RT_geral.RT_850_DataGridView_ctrl_8[16].LinhasValor = new int[4];
			RT_geral.RT_850_DataGridView_ctrl_8[18].LinhasMenu = new string[4];
			RT_geral.RT_850_DataGridView_ctrl_8[18].LinhasValor = new int[4];
			RT_geral.RT_850_DataGridView_ctrl_8[20].LinhasMenu = new string[4];
			RT_geral.RT_850_DataGridView_ctrl_8[20].LinhasValor = new int[4];
			RT_geral.RT_850_DataGridView_ctrl_8[22].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[22].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[23].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[23].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[24].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[24].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[25].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[25].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[26].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[26].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[27].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[27].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[28].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[28].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[29].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[29].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[30].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[30].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[31].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[31].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[32].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[32].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[33].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[33].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[34].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[34].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[35].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[35].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[36].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[36].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[37].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[37].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[38].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[38].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[39].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[39].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[40].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[40].LinhasValor = new int[301];
			RT_geral.RT_850_DataGridView_ctrl_8[41].LinhasMenu = new string[301];
			RT_geral.RT_850_DataGridView_ctrl_8[41].LinhasValor = new int[301];
			checked
			{
				RT_geral.RT_850_DataGridView_ctrl_8[42].LinhasMenu = new string[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_8[42].LinhasValor = new int[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_8[44].LinhasMenu = new string[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_8[44].LinhasValor = new int[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_8[46].LinhasMenu = new string[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_8[46].LinhasValor = new int[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_8[48].LinhasMenu = new string[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_8[48].LinhasValor = new int[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_8[50].LinhasMenu = new string[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_8[50].LinhasValor = new int[perifericos.perif_CT850_300.Count + 1];
				RT_geral.RT_850_DataGridView_ctrl_8[43].LinhasMenu = new string[66];
				RT_geral.RT_850_DataGridView_ctrl_8[43].LinhasValor = new int[66];
				RT_geral.RT_850_DataGridView_ctrl_8[45].LinhasMenu = new string[66];
				RT_geral.RT_850_DataGridView_ctrl_8[45].LinhasValor = new int[66];
				RT_geral.RT_850_DataGridView_ctrl_8[47].LinhasMenu = new string[66];
				RT_geral.RT_850_DataGridView_ctrl_8[47].LinhasValor = new int[66];
				RT_geral.RT_850_DataGridView_ctrl_8[49].LinhasMenu = new string[66];
				RT_geral.RT_850_DataGridView_ctrl_8[49].LinhasValor = new int[66];
				RT_geral.RT_850_DataGridView_ctrl_8[51].LinhasMenu = new string[66];
				RT_geral.RT_850_DataGridView_ctrl_8[51].LinhasValor = new int[66];
				RT_geral.RT_850_DataGridView_ctrl_8[1].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[1].LinhasValor[1] = 1;
				RT_geral.RT_850_DataGridView_ctrl_8[1].LinhasMenu[0] = "Canal 1";
				RT_geral.RT_850_DataGridView_ctrl_8[1].LinhasMenu[1] = "Canal 2";
				RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor[1] = 1;
				RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor[2] = 2;
				RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor[3] = 3;
				RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor[4] = 4;
				RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor[5] = 5;
				RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor[6] = 6;
				RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor[7] = 7;
				RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[0] = "1";
				RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[1] = "2";
				RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[2] = "3";
				RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[3] = "4";
				RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[4] = "5";
				RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[5] = "6";
				RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[6] = "7";
				RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[7] = "8";
				RT_geral.RT_850_DataGridView_ctrl_8[3].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[3].LinhasValor[1] = 1;
				RT_geral.RT_850_DataGridView_ctrl_8[3].LinhasValor[2] = 2;
				RT_geral.RT_850_DataGridView_ctrl_8[3].LinhasMenu[0] = "Desabilitado";
				RT_geral.RT_850_DataGridView_ctrl_8[3].LinhasMenu[1] = "Liberado";
				RT_geral.RT_850_DataGridView_ctrl_8[3].LinhasMenu[2] = "Bloqueado";
				RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasValor[1] = 1;
				RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasValor[2] = 2;
				RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasValor[3] = 4;
				RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasValor[4] = 3;
				RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasMenu[0] = "Não Definido";
				RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasMenu[1] = "RT820 300";
				RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasMenu[2] = "RT820 350";
				RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasMenu[3] = "VA220_42";
				RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasMenu[4] = "RT820 400";
				RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor[1] = 1;
				RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor[2] = 2;
				RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor[3] = 3;
				RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor[4] = 4;
				RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor[5] = 5;
				RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor[6] = 6;
				RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor[7] = 7;
				RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[0] = "Desabilitada";
				RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[1] = "1";
				RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[2] = "2";
				RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[3] = "3";
				RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[4] = "4";
				RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[5] = "5";
				RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[6] = "6";
				RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[7] = "7";
				int i = 0;
				do
				{
					RT_geral.RT_850_DataGridView_ctrl_8[6].LinhasMenu[i] = RT_geral.Nome_ctrl[i];
					RT_geral.RT_850_DataGridView_ctrl_8[6].LinhasValor[i] = i;
					RT_geral.RT_850_DataGridView_ctrl_8[8].LinhasMenu[i] = RT_geral.Nome_ctrl[i];
					RT_geral.RT_850_DataGridView_ctrl_8[8].LinhasValor[i] = i;
					RT_geral.RT_850_DataGridView_ctrl_8[10].LinhasMenu[i] = RT_geral.Nome_ctrl[i];
					RT_geral.RT_850_DataGridView_ctrl_8[10].LinhasValor[i] = i;
					RT_geral.RT_850_DataGridView_ctrl_8[12].LinhasMenu[i] = RT_geral.Nome_ctrl[i];
					RT_geral.RT_850_DataGridView_ctrl_8[12].LinhasValor[i] = i;
					RT_geral.RT_850_DataGridView_ctrl_8[14].LinhasMenu[i] = RT_geral.Nome_ctrl[i];
					RT_geral.RT_850_DataGridView_ctrl_8[14].LinhasValor[i] = i;
					RT_geral.RT_850_DataGridView_ctrl_8[16].LinhasMenu[i] = RT_geral.Nome_ctrl[i];
					RT_geral.RT_850_DataGridView_ctrl_8[16].LinhasValor[i] = i;
					RT_geral.RT_850_DataGridView_ctrl_8[18].LinhasMenu[i] = RT_geral.Nome_ctrl[i];
					RT_geral.RT_850_DataGridView_ctrl_8[18].LinhasValor[i] = i;
					RT_geral.RT_850_DataGridView_ctrl_8[20].LinhasMenu[i] = RT_geral.Nome_ctrl[i];
					RT_geral.RT_850_DataGridView_ctrl_8[20].LinhasValor[i] = i;
					i++;
				}
				while (i <= 2);
				RT_geral.RT_850_DataGridView_ctrl_8[22].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[23].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[24].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[25].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[26].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[27].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[28].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[29].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[30].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[31].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[32].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[33].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[34].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[35].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[36].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[37].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[38].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[39].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[40].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[41].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
				RT_geral.RT_850_DataGridView_ctrl_8[22].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[22].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[23].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[23].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[24].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[24].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[25].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[25].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[26].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[26].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[27].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[27].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[28].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[28].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[29].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[29].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[30].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[30].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[31].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[31].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[32].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[32].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[33].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[33].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[34].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[34].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[35].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[35].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[36].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[36].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[37].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[37].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[38].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[38].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[39].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[39].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[40].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[40].LinhasValor[0] = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[41].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[41].LinhasValor[0] = 0;
				i = 0;
				do
				{
					int num = 0;
					try
					{
						foreach (perifericos.Periferico periferico in perifericos.perif_CT850_300)
						{
							RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[num] = periferico.nome;
							RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[num] = num;
							num++;
						}
					}
					finally
					{
						List<perifericos.Periferico>.Enumerator enumerator;
						enumerator.Dispose();
					}
					RT_geral.RT_850_DataGridView_ctrl_8[43 + i].LinhasMenu[0] = "----";
					RT_geral.RT_850_DataGridView_ctrl_8[43 + i].LinhasValor[0] = 0;
					int num2 = 1;
					do
					{
						RT_geral.RT_850_DataGridView_ctrl_8[43 + i].LinhasMenu[num2] = Conversion.Str(num2);
						RT_geral.RT_850_DataGridView_ctrl_8[43 + i].LinhasValor[num2] = num2;
						num2++;
					}
					while (num2 <= 65);
					i += 2;
				}
				while (i <= 8);
				if (RT_geral.RT_850_BD.Variaveis_Numero.Valor > 0)
				{
					int num3 = 1;
					int valor = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
					for (i = num3; i <= valor; i++)
					{
						RT_geral.RT_850_DataGridView_ctrl_8[22].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[22].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[23].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[23].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[24].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[24].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[25].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[25].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[25].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[25].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[26].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[26].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[27].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[27].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[28].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[28].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[29].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[29].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[30].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[30].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[31].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[31].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[32].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[32].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[33].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[33].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[34].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[34].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[35].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[35].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[36].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[36].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[37].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[37].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[38].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[38].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[39].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[39].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[40].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[40].LinhasValor[i] = i;
						RT_geral.RT_850_DataGridView_ctrl_8[41].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_ctrl_8[41].LinhasValor[i] = i;
					}
				}
				RT_geral.RT_850_DataGridView_ctrl_8[0].TagColuna = "Nome";
				RT_geral.RT_850_DataGridView_ctrl_8[1].TagColuna = "Canal";
				RT_geral.RT_850_DataGridView_ctrl_8[2].TagColuna = "Timeout";
				RT_geral.RT_850_DataGridView_ctrl_8[3].TagColuna = "Comando";
				RT_geral.RT_850_DataGridView_ctrl_8[4].TagColuna = "Prioridade";
				RT_geral.RT_850_DataGridView_ctrl_8[5].TagColuna = "Modelo";
				RT_geral.RT_850_DataGridView_ctrl_8[6].TagColuna = "Ctrl 1 Msg";
				RT_geral.RT_850_DataGridView_ctrl_8[7].TagColuna = "Ctrl 1 N°";
				RT_geral.RT_850_DataGridView_ctrl_8[8].TagColuna = "Ctrl 2 Msg";
				RT_geral.RT_850_DataGridView_ctrl_8[9].TagColuna = "Ctrl 2 N°";
				RT_geral.RT_850_DataGridView_ctrl_8[10].TagColuna = "Ctrl 3 Msg";
				RT_geral.RT_850_DataGridView_ctrl_8[11].TagColuna = "Ctrl 3 N°";
				RT_geral.RT_850_DataGridView_ctrl_8[12].TagColuna = "Ctrl 4 Msg";
				RT_geral.RT_850_DataGridView_ctrl_8[13].TagColuna = "Ctrl 4 N°";
				RT_geral.RT_850_DataGridView_ctrl_8[14].TagColuna = "Ctrl 5 Msg";
				RT_geral.RT_850_DataGridView_ctrl_8[15].TagColuna = "Ctrl 5 N°";
				RT_geral.RT_850_DataGridView_ctrl_8[16].TagColuna = "Ctrl 6 Msg";
				RT_geral.RT_850_DataGridView_ctrl_8[17].TagColuna = "Ctrl 6 N°";
				RT_geral.RT_850_DataGridView_ctrl_8[18].TagColuna = "Ctrl 7 Msg";
				RT_geral.RT_850_DataGridView_ctrl_8[19].TagColuna = "Ctrl 7 N°";
				RT_geral.RT_850_DataGridView_ctrl_8[20].TagColuna = "Ctrl 8 Msg";
				RT_geral.RT_850_DataGridView_ctrl_8[21].TagColuna = "Ctrl 8 N°";
				RT_geral.RT_850_DataGridView_ctrl_8[22].TagColuna = "Var 1";
				RT_geral.RT_850_DataGridView_ctrl_8[23].TagColuna = "Var 2";
				RT_geral.RT_850_DataGridView_ctrl_8[24].TagColuna = "Var 3";
				RT_geral.RT_850_DataGridView_ctrl_8[25].TagColuna = "Var 4";
				RT_geral.RT_850_DataGridView_ctrl_8[26].TagColuna = "Var 5";
				RT_geral.RT_850_DataGridView_ctrl_8[27].TagColuna = "Var 6";
				RT_geral.RT_850_DataGridView_ctrl_8[28].TagColuna = "Var 7";
				RT_geral.RT_850_DataGridView_ctrl_8[29].TagColuna = "Var 8";
				RT_geral.RT_850_DataGridView_ctrl_8[30].TagColuna = "Var 9";
				RT_geral.RT_850_DataGridView_ctrl_8[31].TagColuna = "Var 10";
				RT_geral.RT_850_DataGridView_ctrl_8[32].TagColuna = "Var 11";
				RT_geral.RT_850_DataGridView_ctrl_8[33].TagColuna = "Var 12";
				RT_geral.RT_850_DataGridView_ctrl_8[34].TagColuna = "Var 13";
				RT_geral.RT_850_DataGridView_ctrl_8[35].TagColuna = "Var 14";
				RT_geral.RT_850_DataGridView_ctrl_8[36].TagColuna = "Var 15";
				RT_geral.RT_850_DataGridView_ctrl_8[37].TagColuna = "Var 16";
				RT_geral.RT_850_DataGridView_ctrl_8[38].TagColuna = "Ref 1";
				RT_geral.RT_850_DataGridView_ctrl_8[39].TagColuna = "Ref 2";
				RT_geral.RT_850_DataGridView_ctrl_8[40].TagColuna = "Ref 3";
				RT_geral.RT_850_DataGridView_ctrl_8[41].TagColuna = "Ref 4";
				RT_geral.RT_850_DataGridView_ctrl_8[42].TagColuna = "Periférico 1 - Modelo";
				RT_geral.RT_850_DataGridView_ctrl_8[43].TagColuna = "Índice 1";
				RT_geral.RT_850_DataGridView_ctrl_8[44].TagColuna = "Periférico 2 - Modelo";
				RT_geral.RT_850_DataGridView_ctrl_8[45].TagColuna = "Índice 2";
				RT_geral.RT_850_DataGridView_ctrl_8[46].TagColuna = "Periférico 3 - Modelo";
				RT_geral.RT_850_DataGridView_ctrl_8[47].TagColuna = "Índice 3";
				RT_geral.RT_850_DataGridView_ctrl_8[48].TagColuna = "Periférico 4 - Modelo";
				RT_geral.RT_850_DataGridView_ctrl_8[49].TagColuna = "Índice 4";
				RT_geral.RT_850_DataGridView_ctrl_8[50].TagColuna = "Periférico 5 - Modelo";
				RT_geral.RT_850_DataGridView_ctrl_8[51].TagColuna = "Índice 5";
				RT_geral.RT_850_DataGridView_ctrl_8[0].NomeColuna = "Nome";
				RT_geral.RT_850_DataGridView_ctrl_8[1].NomeColuna = "Canal";
				RT_geral.RT_850_DataGridView_ctrl_8[2].NomeColuna = "Timeout";
				RT_geral.RT_850_DataGridView_ctrl_8[3].NomeColuna = "Comando";
				RT_geral.RT_850_DataGridView_ctrl_8[4].NomeColuna = "Prioridade";
				RT_geral.RT_850_DataGridView_ctrl_8[5].NomeColuna = "Modelo";
				RT_geral.RT_850_DataGridView_ctrl_8[6].NomeColuna = "Ctr1_msg";
				RT_geral.RT_850_DataGridView_ctrl_8[7].NomeColuna = "Ctrl1_num";
				RT_geral.RT_850_DataGridView_ctrl_8[8].NomeColuna = "Ctr2_msg";
				RT_geral.RT_850_DataGridView_ctrl_8[9].NomeColuna = "Ctrl2_num";
				RT_geral.RT_850_DataGridView_ctrl_8[10].NomeColuna = "Ctr3_msg";
				RT_geral.RT_850_DataGridView_ctrl_8[11].NomeColuna = "Ctrl3_num";
				RT_geral.RT_850_DataGridView_ctrl_8[12].NomeColuna = "Ctr4_msg";
				RT_geral.RT_850_DataGridView_ctrl_8[13].NomeColuna = "Ctrl4_num";
				RT_geral.RT_850_DataGridView_ctrl_8[14].NomeColuna = "Ctr5_msg";
				RT_geral.RT_850_DataGridView_ctrl_8[15].NomeColuna = "Ctrl5_num";
				RT_geral.RT_850_DataGridView_ctrl_8[16].NomeColuna = "Ctr6_msg";
				RT_geral.RT_850_DataGridView_ctrl_8[17].NomeColuna = "Ctrl6_num";
				RT_geral.RT_850_DataGridView_ctrl_8[18].NomeColuna = "Ctr7_msg";
				RT_geral.RT_850_DataGridView_ctrl_8[19].NomeColuna = "Ctrl7_num";
				RT_geral.RT_850_DataGridView_ctrl_8[20].NomeColuna = "Ctr8_msg";
				RT_geral.RT_850_DataGridView_ctrl_8[21].NomeColuna = "Ctrl8_num";
				RT_geral.RT_850_DataGridView_ctrl_8[22].NomeColuna = "Var_1";
				RT_geral.RT_850_DataGridView_ctrl_8[23].NomeColuna = "Var_2";
				RT_geral.RT_850_DataGridView_ctrl_8[24].NomeColuna = "Var_3";
				RT_geral.RT_850_DataGridView_ctrl_8[25].NomeColuna = "Var_4";
				RT_geral.RT_850_DataGridView_ctrl_8[26].NomeColuna = "Var_5";
				RT_geral.RT_850_DataGridView_ctrl_8[27].NomeColuna = "Var_6";
				RT_geral.RT_850_DataGridView_ctrl_8[28].NomeColuna = "Var_7";
				RT_geral.RT_850_DataGridView_ctrl_8[29].NomeColuna = "Var_8";
				RT_geral.RT_850_DataGridView_ctrl_8[30].NomeColuna = "Var_9";
				RT_geral.RT_850_DataGridView_ctrl_8[31].NomeColuna = "Var_10";
				RT_geral.RT_850_DataGridView_ctrl_8[32].NomeColuna = "Var_11";
				RT_geral.RT_850_DataGridView_ctrl_8[33].NomeColuna = "Var_12";
				RT_geral.RT_850_DataGridView_ctrl_8[34].NomeColuna = "Var_13";
				RT_geral.RT_850_DataGridView_ctrl_8[35].NomeColuna = "Var_14";
				RT_geral.RT_850_DataGridView_ctrl_8[36].NomeColuna = "Var_15";
				RT_geral.RT_850_DataGridView_ctrl_8[37].NomeColuna = "Var_16";
				RT_geral.RT_850_DataGridView_ctrl_8[38].NomeColuna = "Ref_1";
				RT_geral.RT_850_DataGridView_ctrl_8[39].NomeColuna = "Ref_2";
				RT_geral.RT_850_DataGridView_ctrl_8[40].NomeColuna = "Ref_3";
				RT_geral.RT_850_DataGridView_ctrl_8[41].NomeColuna = "Ref_4";
				RT_geral.RT_850_DataGridView_ctrl_8[42].NomeColuna = "Per_1";
				RT_geral.RT_850_DataGridView_ctrl_8[43].NomeColuna = "Loc_1";
				RT_geral.RT_850_DataGridView_ctrl_8[44].NomeColuna = "Per_2";
				RT_geral.RT_850_DataGridView_ctrl_8[45].NomeColuna = "Loc_2";
				RT_geral.RT_850_DataGridView_ctrl_8[46].NomeColuna = "Per_3";
				RT_geral.RT_850_DataGridView_ctrl_8[47].NomeColuna = "Loc_3";
				RT_geral.RT_850_DataGridView_ctrl_8[48].NomeColuna = "Per_4";
				RT_geral.RT_850_DataGridView_ctrl_8[49].NomeColuna = "Loc_4";
				RT_geral.RT_850_DataGridView_ctrl_8[50].NomeColuna = "Per_5";
				RT_geral.RT_850_DataGridView_ctrl_8[51].NomeColuna = "Loc_5";
				RT_geral.RT_850_DataGridView_ctrl_8[0].LarguraColuna = Conversions.ToInteger("80");
				RT_geral.RT_850_DataGridView_ctrl_8[1].LarguraColuna = Conversions.ToInteger("75");
				RT_geral.RT_850_DataGridView_ctrl_8[2].LarguraColuna = Conversions.ToInteger("80");
				RT_geral.RT_850_DataGridView_ctrl_8[3].LarguraColuna = Conversions.ToInteger("95");
				RT_geral.RT_850_DataGridView_ctrl_8[4].LarguraColuna = Conversions.ToInteger("90");
				RT_geral.RT_850_DataGridView_ctrl_8[5].LarguraColuna = Conversions.ToInteger("95");
				RT_geral.RT_850_DataGridView_ctrl_8[6].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[7].LarguraColuna = Conversions.ToInteger("70");
				RT_geral.RT_850_DataGridView_ctrl_8[8].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[9].LarguraColuna = Conversions.ToInteger("70");
				RT_geral.RT_850_DataGridView_ctrl_8[10].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[11].LarguraColuna = Conversions.ToInteger("70");
				RT_geral.RT_850_DataGridView_ctrl_8[12].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[13].LarguraColuna = Conversions.ToInteger("70");
				RT_geral.RT_850_DataGridView_ctrl_8[14].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[15].LarguraColuna = Conversions.ToInteger("70");
				RT_geral.RT_850_DataGridView_ctrl_8[16].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[17].LarguraColuna = Conversions.ToInteger("70");
				RT_geral.RT_850_DataGridView_ctrl_8[18].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[19].LarguraColuna = Conversions.ToInteger("70");
				RT_geral.RT_850_DataGridView_ctrl_8[20].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[21].LarguraColuna = Conversions.ToInteger("70");
				RT_geral.RT_850_DataGridView_ctrl_8[22].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[23].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[24].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[25].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[26].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[27].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[28].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[29].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[30].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[31].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[32].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[33].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[34].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[35].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[36].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[37].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[38].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[39].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[40].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[41].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[42].LarguraColuna = Conversions.ToInteger("180");
				RT_geral.RT_850_DataGridView_ctrl_8[43].LarguraColuna = Conversions.ToInteger("75");
				RT_geral.RT_850_DataGridView_ctrl_8[44].LarguraColuna = Conversions.ToInteger("180");
				RT_geral.RT_850_DataGridView_ctrl_8[45].LarguraColuna = Conversions.ToInteger("75");
				RT_geral.RT_850_DataGridView_ctrl_8[46].LarguraColuna = Conversions.ToInteger("180");
				RT_geral.RT_850_DataGridView_ctrl_8[47].LarguraColuna = Conversions.ToInteger("75");
				RT_geral.RT_850_DataGridView_ctrl_8[48].LarguraColuna = Conversions.ToInteger("180");
				RT_geral.RT_850_DataGridView_ctrl_8[49].LarguraColuna = Conversions.ToInteger("75");
				RT_geral.RT_850_DataGridView_ctrl_8[50].LarguraColuna = Conversions.ToInteger("180");
				RT_geral.RT_850_DataGridView_ctrl_8[51].LarguraColuna = Conversions.ToInteger("75");
				RT_geral.RT_850_DataGridView_ctrl_8[0].AlingColuna = 16;
				RT_geral.RT_850_DataGridView_ctrl_8[1].AlingColuna = 256;
				RT_geral.RT_850_DataGridView_ctrl_8[2].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[3].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[4].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[5].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[6].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[7].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[8].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[9].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[10].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[11].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[12].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[13].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[14].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[15].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[16].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[17].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[18].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[19].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[20].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[21].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[22].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[23].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[24].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[25].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[26].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[27].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[28].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[29].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[30].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[31].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[32].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[33].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[34].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[35].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[36].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[37].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[38].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[39].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[40].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[41].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[42].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[43].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[44].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[45].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[46].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[47].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[48].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[49].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[50].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[51].AlingColuna = 64;
				RT_geral.RT_850_DataGridView_ctrl_8[0].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[1].NumeroLinhaMenu = 2;
				RT_geral.RT_850_DataGridView_ctrl_8[2].NumeroLinhaMenu = 8;
				RT_geral.RT_850_DataGridView_ctrl_8[3].NumeroLinhaMenu = 3;
				RT_geral.RT_850_DataGridView_ctrl_8[4].NumeroLinhaMenu = 8;
				RT_geral.RT_850_DataGridView_ctrl_8[5].NumeroLinhaMenu = 5;
				RT_geral.RT_850_DataGridView_ctrl_8[6].NumeroLinhaMenu = 3;
				RT_geral.RT_850_DataGridView_ctrl_8[7].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[8].NumeroLinhaMenu = 3;
				RT_geral.RT_850_DataGridView_ctrl_8[9].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[10].NumeroLinhaMenu = 3;
				RT_geral.RT_850_DataGridView_ctrl_8[11].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[12].NumeroLinhaMenu = 3;
				RT_geral.RT_850_DataGridView_ctrl_8[13].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[14].NumeroLinhaMenu = 3;
				RT_geral.RT_850_DataGridView_ctrl_8[15].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[16].NumeroLinhaMenu = 3;
				RT_geral.RT_850_DataGridView_ctrl_8[17].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[18].NumeroLinhaMenu = 3;
				RT_geral.RT_850_DataGridView_ctrl_8[19].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[20].NumeroLinhaMenu = 3;
				RT_geral.RT_850_DataGridView_ctrl_8[21].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_ctrl_8[22].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[23].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[24].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[25].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[26].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[27].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[28].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[29].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[30].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[31].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[32].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[33].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[34].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[35].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[36].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[37].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[38].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[39].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[40].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[41].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_8[42].NumeroLinhaMenu = perifericos.perif_CT850_300.Count;
				RT_geral.RT_850_DataGridView_ctrl_8[43].NumeroLinhaMenu = 66;
				RT_geral.RT_850_DataGridView_ctrl_8[44].NumeroLinhaMenu = perifericos.perif_CT850_300.Count;
				RT_geral.RT_850_DataGridView_ctrl_8[45].NumeroLinhaMenu = 66;
				RT_geral.RT_850_DataGridView_ctrl_8[46].NumeroLinhaMenu = perifericos.perif_CT850_300.Count;
				RT_geral.RT_850_DataGridView_ctrl_8[47].NumeroLinhaMenu = 66;
				RT_geral.RT_850_DataGridView_ctrl_8[48].NumeroLinhaMenu = perifericos.perif_CT850_300.Count;
				RT_geral.RT_850_DataGridView_ctrl_8[49].NumeroLinhaMenu = 66;
				RT_geral.RT_850_DataGridView_ctrl_8[50].NumeroLinhaMenu = perifericos.perif_CT850_300.Count;
				RT_geral.RT_850_DataGridView_ctrl_8[51].NumeroLinhaMenu = 66;
			}
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x002DC47C File Offset: 0x002DA87C
		private void Atualiza_DataGridView_Ctrl_8()
		{
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[0].Value = RT_geral.RT_850_Ctrl_8[i].Nome.Valor;
					string value = RT_geral.RT_850_DataGridView_ctrl_8[1].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Canal.Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[1].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Timeout.Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[2].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[3].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Comando.Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[3].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Prioridade.Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[4].Value = value;
					int num3 = RT_geral.Localiza_indice_combo(ref RT_geral.RT_850_DataGridView_ctrl_8[5], RT_geral.RT_850_Ctrl_8[i].Modelo.Indice);
					value = RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasMenu[num3];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[5].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[6].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Crtl_nome[0].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[6].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[8].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Crtl_nome[1].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[8].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[10].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Crtl_nome[2].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[10].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[12].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Crtl_nome[3].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[12].Value = value;
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[7].Value = RT_geral.RT_850_Ctrl_8[i].Crtl_indice[0].Valor;
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[9].Value = RT_geral.RT_850_Ctrl_8[i].Crtl_indice[1].Valor;
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[11].Value = RT_geral.RT_850_Ctrl_8[i].Crtl_indice[2].Valor;
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[13].Value = RT_geral.RT_850_Ctrl_8[i].Crtl_indice[3].Valor;
					value = RT_geral.RT_850_DataGridView_ctrl_8[14].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Crtl_nome[4].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[14].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[16].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Crtl_nome[5].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[16].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[18].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Crtl_nome[6].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[18].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[20].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Crtl_nome[7].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[20].Value = value;
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[15].Value = RT_geral.RT_850_Ctrl_8[i].Crtl_indice[4].Valor;
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[17].Value = RT_geral.RT_850_Ctrl_8[i].Crtl_indice[5].Valor;
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[19].Value = RT_geral.RT_850_Ctrl_8[i].Crtl_indice[6].Valor;
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[21].Value = RT_geral.RT_850_Ctrl_8[i].Crtl_indice[7].Valor;
					value = RT_geral.RT_850_DataGridView_ctrl_8[22].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Var[0].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[22].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[23].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Var[1].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[23].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[24].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Var[2].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[24].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[25].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Var[3].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[25].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[26].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Var[4].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[26].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[27].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Var[5].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[27].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[28].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Var[6].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[28].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[29].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Var[7].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[29].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[30].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Var[8].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[30].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[31].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Var[9].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[31].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[32].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Var[10].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[32].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[33].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Var[11].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[33].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[34].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Var[12].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[34].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[35].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Var[13].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[35].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[36].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Var[14].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[36].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[37].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Var[15].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[37].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[38].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Ref[0].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[38].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[39].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Ref[1].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[39].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[40].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Ref[2].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[40].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[41].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Ref[3].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[41].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[42].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Periferico_Modelo[0].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[42].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[44].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Periferico_Modelo[1].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[44].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[46].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Periferico_Modelo[2].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[46].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[48].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Periferico_Modelo[3].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[48].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[50].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Periferico_Modelo[4].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[50].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[43].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Periferico_Indice[0].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[43].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[45].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Periferico_Indice[1].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[45].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[47].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Periferico_Indice[2].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[47].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[49].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Periferico_Indice[3].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[49].Value = value;
					value = RT_geral.RT_850_DataGridView_ctrl_8[51].LinhasMenu[RT_geral.RT_850_Ctrl_8[i].Periferico_Indice[4].Indice];
					this.DataGridView_Ctrl_8_RT850.Rows[i].Cells[51].Value = value;
				}
			}
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x002DD47C File Offset: 0x002DB87C
		private void GeraDataGridView_Variaveis_Vista_RT_850()
		{
			RT_geral.RT_850_Controle.LiberaEventos_Variaveis = false;
			if (this.DataGridView_vista_variaveis_RT_850.ColumnCount > 0)
			{
				this.DataGridView_vista_variaveis_RT_850.RowCount = 1;
				this.DataGridView_vista_variaveis_RT_850.Columns.Clear();
			}
			this.DataGridView_vista_variaveis_RT_850.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			this.DataGridView_vista_variaveis_RT_850.DefaultCellStyle.Alignment = (System.Windows.Forms.HorizontalAlignment)32;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_850_DataGridView_Variaveis_Vista[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_850_DataGridView_Variaveis_Vista);
						this.DataGridView_vista_variaveis_RT_850.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_850_DataGridView_Variaveis_Vista);
						if (num >= 0)
						{
							dataGridViewTextBoxColumn.ReadOnly = true;
						}
						this.DataGridView_vista_variaveis_RT_850.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					this.DataGridView_vista_variaveis_RT_850.Columns[num].SortMode = 0;
					num++;
				}
				while (num <= 0);
				if (RT_geral.RT_850_BD.Vista_selecionado.Indice > 0)
				{
					this.DataGridView_vista_variaveis_RT_850.RowCount = RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Num_var.Valor;
				}
				else
				{
					this.DataGridView_vista_variaveis_RT_850.RowCount = 0;
				}
				this.DataGridView_vista_variaveis_RT_850.RowHeadersWidth = 90;
				int num2 = 0;
				try
				{
					foreach (object obj = null in this.DataGridView_vista_variaveis_RT_850.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "Var : " + Conversion.Str(num2 + 1);
							num2++;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				RT_geral.RT_850_Controle.LiberaEventos_Variaveis = true;
			}
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x002DD654 File Offset: 0x002DBA54
		public void InicializaEstrutura_DataGridView_Variaveis_Vista_RT_850()
		{
			checked
			{
				RT_geral.RT_850_DataGridView_Variaveis_Vista[0].LinhasMenu = new string[RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1];
				RT_geral.RT_850_DataGridView_Variaveis_Vista[0].LinhasValor = new int[RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1];
				RT_geral.RT_850_DataGridView_Variaveis_Vista[0].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_Variaveis_Vista[0].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_Variaveis_Vista[0].LinhasValor[0] = 0;
				if (RT_geral.RT_850_BD.Variaveis_Numero.Valor > 0)
				{
					int num = 1;
					int valor = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
					for (int i = num; i <= valor; i++)
					{
						RT_geral.RT_850_DataGridView_Variaveis_Vista[0].LinhasMenu[i] = RT_geral.Variaveis_RT_850[i - 1].Nome.Valor;
						RT_geral.RT_850_DataGridView_Variaveis_Vista[0].LinhasValor[i] = i;
					}
				}
				RT_geral.RT_850_DataGridView_Variaveis_Vista[0].TagColuna = "    Variável";
				RT_geral.RT_850_DataGridView_Variaveis_Vista[0].NomeColuna = "Var";
				RT_geral.RT_850_DataGridView_Variaveis_Vista[0].LarguraColuna = Conversions.ToInteger("120");
				RT_geral.RT_850_DataGridView_Variaveis_Vista[0].AlingColuna = 16;
			}
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x002DD7B8 File Offset: 0x002DBBB8
		private void Atualiza_DataGridView_Variaveis_Vista_RT_850()
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice == 0)
			{
				return;
			}
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Num_var.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string value = RT_geral.RT_850_DataGridView_Variaveis_Vista[0].LinhasMenu[RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Variaveis[i].Indice];
					this.DataGridView_vista_variaveis_RT_850.Rows[i].Cells[0].Value = value;
				}
			}
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x002DD868 File Offset: 0x002DBC68
		private void GeraDataGridView_Equipamentos_Vista_RT_850()
		{
			RT_geral.RT_850_Controle.LiberaEventos_Variaveis = false;
			if (this.DataGridView_vista_equipamentos_RT_850.ColumnCount > 0)
			{
				this.DataGridView_vista_equipamentos_RT_850.RowCount = 1;
				this.DataGridView_vista_equipamentos_RT_850.Columns.Clear();
			}
			this.DataGridView_vista_equipamentos_RT_850.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			this.DataGridView_vista_equipamentos_RT_850.DefaultCellStyle.Alignment = (System.Windows.Forms.HorizontalAlignment)32;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_850_DataGridView_Equipamentos_Vista[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_850_DataGridView_Equipamentos_Vista);
						this.DataGridView_vista_equipamentos_RT_850.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_850_DataGridView_Equipamentos_Vista);
						if (num >= 0)
						{
							dataGridViewTextBoxColumn.ReadOnly = true;
						}
						this.DataGridView_vista_equipamentos_RT_850.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					this.DataGridView_vista_equipamentos_RT_850.Columns[num].SortMode = 0;
					num++;
				}
				while (num <= 0);
				if (RT_geral.RT_850_BD.Vista_selecionado.Indice > 0)
				{
					this.DataGridView_vista_equipamentos_RT_850.RowCount = RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Num_equip.Valor;
				}
				else
				{
					this.DataGridView_vista_equipamentos_RT_850.RowCount = 0;
				}
				this.DataGridView_vista_equipamentos_RT_850.RowHeadersWidth = 90;
				int num2 = 0;
				try
				{
					foreach (object obj = null in this.DataGridView_vista_equipamentos_RT_850.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "Equip : " + Conversion.Str(num2 + 1);
							num2++;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				RT_geral.RT_850_Controle.LiberaEventos_Variaveis = true;
			}
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x002DDA40 File Offset: 0x002DBE40
		public void InicializaEstrutura_DataGridView_Equipamentos_Vista_RT_850()
		{
			checked
			{
				RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].LinhasMenu = new string[RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor + RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor + RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor + 1];
				RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].LinhasValor = new int[RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor + RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor + RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor + 1];
				int num = RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor + RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor + RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor;
				RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].NumeroLinhaMenu = num + 1;
				RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].LinhasValor[0] = 0;
				if (num > 0)
				{
					int num2 = 1;
					if (RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor > 0)
					{
						int num3 = 1;
						int valor = RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor;
						for (int i = num3; i <= valor; i++)
						{
							RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].LinhasMenu[num2] = RT_geral.RT_850_Ctrl_1[i - 1].Nome.Valor;
							RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].LinhasValor[num2] = i + 0;
							num2++;
						}
					}
					if (RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor > 0)
					{
						int num4 = 1;
						int valor2 = RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor;
						for (int i = num4; i <= valor2; i++)
						{
							RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].LinhasMenu[num2] = RT_geral.RT_850_Ctrl_4[i - 1].Nome.Valor;
							RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].LinhasValor[num2] = i + 80;
							num2++;
						}
					}
					if (RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor > 0)
					{
						int num5 = 1;
						int valor3 = RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor;
						for (int i = num5; i <= valor3; i++)
						{
							RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].LinhasMenu[num2] = RT_geral.RT_850_Ctrl_8[i - 1].Nome.Valor;
							RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].LinhasValor[num2] = i + 130;
							num2++;
						}
					}
				}
				RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].TagColuna = "    Equipamento";
				RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].NomeColuna = "Equip";
				RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].LarguraColuna = Conversions.ToInteger("120");
				RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].AlingColuna = 16;
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x002DDD00 File Offset: 0x002DC100
		private void Atualiza_DataGridView_Equipamentos_Vista_RT_850()
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice == 0)
			{
				return;
			}
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Num_equip.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					int indice = RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Equipamentos[i].Indice;
					int num3 = RT_geral.Localiza_indice_combo(ref RT_geral.RT_850_DataGridView_Equipamentos_Vista[0], indice);
					string value = RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].LinhasMenu[num3];
					this.DataGridView_vista_equipamentos_RT_850.Rows[i].Cells[0].Value = value;
				}
			}
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x002DDDC8 File Offset: 0x002DC1C8
		public void Inicializa_DadosEStruturaRT850_Padrao()
		{
			RT_geral.RT_850_BD.Versao.nome = "Versão";
			RT_geral.RT_850_BD.Versao.Padrao = 0;
			RT_geral.RT_850_BD.Build.nome = "Build";
			RT_geral.RT_850_BD.Build.Padrao = 0;
			RT_geral.RT_850_BD.Release.nome = "Release";
			RT_geral.RT_850_BD.Release.Padrao = 0;
			RT_geral.RT_850_BD.Equip.nome = "Tipo equipamento";
			RT_geral.RT_850_BD.Equip.Padrao = 0;
			RT_geral.RT_850_BD.Msg_linha_1.Padrao = "";
			RT_geral.RT_850_BD.Msg_linha_2.Padrao = "";
			RT_geral.RT_850_BD.Msg_linha_3.Padrao = "";
			RT_geral.RT_850_BD.Msg_linha_4.Padrao = "";
			RT_geral.RT_850_BD.End_mestre_canal_1.nome = "Endereço Mestre Canal 1";
			RT_geral.RT_850_BD.End_mestre_canal_1.Padrao = 200;
			RT_geral.RT_850_BD.End_mestre_canal_1.Lmte_inf = 1;
			RT_geral.RT_850_BD.End_mestre_canal_1.Lmte_sup = 200;
			RT_geral.RT_850_BD.Intervalo_leitura_canal_1.nome = "Intervalo de Leitura Canal 1";
			RT_geral.RT_850_BD.Intervalo_leitura_canal_1.Padrao = 3;
			RT_geral.RT_850_BD.Intervalo_leitura_canal_1.Lmte_inf = 1;
			RT_geral.RT_850_BD.Intervalo_leitura_canal_1.Lmte_sup = 200;
			RT_geral.RT_850_BD.BaudRate_canal_1.nome = "Baudrate Canal 1";
			RT_geral.RT_850_BD.BaudRate_canal_1.Indice_padrao = 0;
			RT_geral.RT_850_BD.BaudRate_canal_1.Numero_itens = perifericos.ListaBaudRate.Count;
			int num = 0;
			checked
			{
				int num2 = perifericos.ListaBaudRate.Count - 1;
				int i;
				for (i = num; i <= num2; i++)
				{
					RT_geral.RT_850_BD.BaudRate_canal_1.valores[i] = perifericos.ListaBaudRate[i].valor;
					RT_geral.RT_850_BD.BaudRate_canal_1.itens[i] = perifericos.ListaBaudRate[i].nome;
					if (perifericos.ListaBaudRate[i].is_default)
					{
						RT_geral.RT_850_BD.BaudRate_canal_1.Indice_padrao = i;
					}
				}
				RT_geral.RT_850_BD.Timeout_canal_1.nome = "Tempo de Espera Canal 1";
				RT_geral.RT_850_BD.Timeout_canal_1.Padrao = 5;
				RT_geral.RT_850_BD.Timeout_canal_1.Lmte_inf = 1;
				RT_geral.RT_850_BD.Timeout_canal_1.Lmte_sup = 200;
				RT_geral.RT_850_BD.Tempo_ptt_canal_1.nome = "Tempo PTT Canal 1";
				RT_geral.RT_850_BD.Tempo_ptt_canal_1.Padrao = 200;
				RT_geral.RT_850_BD.Tempo_ptt_canal_1.Lmte_inf = 10;
				RT_geral.RT_850_BD.Tempo_ptt_canal_1.Lmte_sup = 2000;
				RT_geral.RT_850_BD.Numero_tentativas_canal_1.nome = "Número Tentativas do Canal 1";
				RT_geral.RT_850_BD.Numero_tentativas_canal_1.Padrao = 3;
				RT_geral.RT_850_BD.Numero_tentativas_canal_1.Lmte_inf = 0;
				RT_geral.RT_850_BD.Numero_tentativas_canal_1.Lmte_sup = 20;
				RT_geral.RT_850_BD.Numero_erros_falha_canal_1.nome = "Número Erros para Falha do Canal 1";
				RT_geral.RT_850_BD.Numero_erros_falha_canal_1.Padrao = 3;
				RT_geral.RT_850_BD.Numero_erros_falha_canal_1.Lmte_inf = 1;
				RT_geral.RT_850_BD.Numero_erros_falha_canal_1.Lmte_sup = 20;
				RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.nome = "Número de comando para geração de estatística do canal 1";
				RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Padrao = 100;
				RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Lmte_inf = 10;
				RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Lmte_sup = 1000;
				RT_geral.RT_850_BD.Numero_equip_tipo_1.nome = "Número Equipamentos de 1 Ctrl do Canal 1";
				RT_geral.RT_850_BD.Numero_equip_tipo_1.Padrao = 0;
				RT_geral.RT_850_BD.Numero_equip_tipo_1.Lmte_inf = 0;
				RT_geral.RT_850_BD.Numero_equip_tipo_1.Lmte_sup = 80;
				RT_geral.RT_850_BD.Numero_equip_tipo_2.nome = "Número Equipamentos de 2 Ctrl do Canal 1";
				RT_geral.RT_850_BD.Numero_equip_tipo_2.Padrao = 0;
				RT_geral.RT_850_BD.Numero_equip_tipo_2.Lmte_inf = 0;
				RT_geral.RT_850_BD.Numero_equip_tipo_2.Lmte_sup = 50;
				RT_geral.RT_850_BD.Numero_equip_tipo_3.nome = "Número Equipamentos de 3 Ctrl do Canal 1";
				RT_geral.RT_850_BD.Numero_equip_tipo_3.Padrao = 0;
				RT_geral.RT_850_BD.Numero_equip_tipo_3.Lmte_inf = 0;
				RT_geral.RT_850_BD.Numero_equip_tipo_3.Lmte_sup = 20;
				RT_geral.RT_850_BD.Numero_equip_tipo_vista.nome = "Número Equipamentos Vista do Canal 1";
				RT_geral.RT_850_BD.Numero_equip_tipo_vista.Padrao = 0;
				RT_geral.RT_850_BD.Numero_equip_tipo_vista.Lmte_inf = 0;
				RT_geral.RT_850_BD.Numero_equip_tipo_vista.Lmte_sup = 5;
				RT_geral.RT_850_BD.End_inicial_equip_tipo_1.nome = "Endereço Inicial Equipamentos de 1 Ctrl do Canal 1";
				RT_geral.RT_850_BD.End_inicial_equip_tipo_1.Padrao = 1;
				RT_geral.RT_850_BD.End_inicial_equip_tipo_1.Lmte_inf = 1;
				RT_geral.RT_850_BD.End_inicial_equip_tipo_1.Lmte_sup = 200;
				RT_geral.RT_850_BD.End_inicial_equip_tipo_2.nome = "Endereço Inicial Equipamentos de 3 Ctrl do Canal 1";
				RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Padrao = 50;
				RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Lmte_inf = 1;
				RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Lmte_sup = 200;
				RT_geral.RT_850_BD.End_inicial_equip_tipo_3.nome = "Endereço Inicial Equipamentos de 8 Ctrl do Canal 1";
				RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Padrao = 80;
				RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Lmte_inf = 1;
				RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Lmte_sup = 200;
				RT_geral.RT_850_BD.End_inicial_equip_tipo_vista.nome = "Endereço Inicial Equipamentos de Vista do Canal 1";
				RT_geral.RT_850_BD.End_inicial_equip_tipo_vista.Padrao = 100;
				RT_geral.RT_850_BD.End_inicial_equip_tipo_vista.Lmte_inf = 1;
				RT_geral.RT_850_BD.End_inicial_equip_tipo_vista.Lmte_sup = 200;
				RT_geral.RT_850_BD.End_mestre_canal_2.nome = "Endereço Mestre Canal 2";
				RT_geral.RT_850_BD.End_mestre_canal_2.Padrao = 180;
				RT_geral.RT_850_BD.End_mestre_canal_2.Lmte_inf = 1;
				RT_geral.RT_850_BD.End_mestre_canal_2.Lmte_sup = 200;
				RT_geral.RT_850_BD.Intervalo_leitura_canal_2.nome = "Intervalo de Leitura Canal 2";
				RT_geral.RT_850_BD.Intervalo_leitura_canal_2.Padrao = 3;
				RT_geral.RT_850_BD.Intervalo_leitura_canal_2.Lmte_inf = 1;
				RT_geral.RT_850_BD.Intervalo_leitura_canal_2.Lmte_sup = 200;
				RT_geral.RT_850_BD.BaudRate_canal_2.nome = "Baudrate Canal 2";
				RT_geral.RT_850_BD.BaudRate_canal_2.Indice_padrao = 0;
				RT_geral.RT_850_BD.BaudRate_canal_2.Numero_itens = perifericos.ListaBaudRate.Count;
				int num3 = 0;
				int num4 = perifericos.ListaBaudRate.Count - 1;
				for (i = num3; i <= num4; i++)
				{
					RT_geral.RT_850_BD.BaudRate_canal_2.valores[i] = perifericos.ListaBaudRate[i].valor;
					RT_geral.RT_850_BD.BaudRate_canal_2.itens[i] = perifericos.ListaBaudRate[i].nome;
					if (perifericos.ListaBaudRate[i].is_default)
					{
						RT_geral.RT_850_BD.BaudRate_canal_2.Indice_padrao = i;
					}
				}
				RT_geral.RT_850_BD.Timeout_canal_2.nome = "Tempo de Espera Canal 2";
				RT_geral.RT_850_BD.Timeout_canal_2.Padrao = 5;
				RT_geral.RT_850_BD.Timeout_canal_2.Lmte_inf = 1;
				RT_geral.RT_850_BD.Timeout_canal_2.Lmte_sup = 200;
				RT_geral.RT_850_BD.Tempo_ptt_canal_2.nome = "Tempo PTT Canal 2";
				RT_geral.RT_850_BD.Tempo_ptt_canal_2.Padrao = 200;
				RT_geral.RT_850_BD.Tempo_ptt_canal_2.Lmte_inf = 10;
				RT_geral.RT_850_BD.Tempo_ptt_canal_2.Lmte_sup = 2000;
				RT_geral.RT_850_BD.Numero_tentativas_canal_2.nome = "Número Tentativas do Canal 2";
				RT_geral.RT_850_BD.Numero_tentativas_canal_2.Padrao = 3;
				RT_geral.RT_850_BD.Numero_tentativas_canal_2.Lmte_inf = 0;
				RT_geral.RT_850_BD.Numero_tentativas_canal_2.Lmte_sup = 20;
				RT_geral.RT_850_BD.Numero_erros_falha_canal_2.nome = "Número Erros para Falha do Canal 2";
				RT_geral.RT_850_BD.Numero_erros_falha_canal_2.Padrao = 3;
				RT_geral.RT_850_BD.Numero_erros_falha_canal_2.Lmte_inf = 1;
				RT_geral.RT_850_BD.Numero_erros_falha_canal_2.Lmte_sup = 20;
				RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.nome = "Número de comando para geração de estatística do canal 2";
				RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Padrao = 100;
				RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Lmte_inf = 10;
				RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Lmte_sup = 1000;
				RT_geral.RT_850_BD.Sincronismo.nome = "Habilita Sincronismo entre canais";
				RT_geral.RT_850_BD.Sincronismo.Padrao = 21856;
				RT_geral.RT_850_BD.Sincronismo.Lmte_inf = 21856;
				RT_geral.RT_850_BD.Sincronismo.Lmte_sup = 21857;
				RT_geral.RT_850_BD.ConfereResposta.nome = "Confere Resposta (tamanho)";
				RT_geral.RT_850_BD.ConfereResposta.Padrao = 0;
				RT_geral.RT_850_BD.ConfereResposta.Lmte_inf = 0;
				RT_geral.RT_850_BD.ConfereResposta.Lmte_sup = 1;
				RT_geral.RT_850_BD.Modo_Estatistica.nome = "Modo Estatistica CORSAN";
				RT_geral.RT_850_BD.Modo_Estatistica.Padrao = 0;
				RT_geral.RT_850_BD.Modo_Estatistica.Lmte_inf = 0;
				RT_geral.RT_850_BD.Modo_Estatistica.Lmte_sup = 1;
				RT_geral.RT_850_BD.LiberaTeclado.nome = "Operação do Teclado com Supervisório";
				RT_geral.RT_850_BD.LiberaTeclado.Padrao = 0;
				RT_geral.RT_850_BD.Modo_Estatistica.Lmte_inf = 0;
				RT_geral.RT_850_BD.Modo_Estatistica.Lmte_sup = 1;
				RT_geral.RT_850_BD.Flag_Remota.nome = "Flag Remota";
				RT_geral.RT_850_BD.Flag_Remota.Indice_padrao = 0;
				RT_geral.RT_850_BD.Flag_Remota.Numero_itens = 6;
				RT_geral.RT_850_BD.Flag_Remota.valores[0] = 0;
				RT_geral.RT_850_BD.Flag_Remota.valores[1] = 1;
				RT_geral.RT_850_BD.Flag_Remota.valores[2] = 2;
				RT_geral.RT_850_BD.Flag_Remota.valores[3] = 3;
				RT_geral.RT_850_BD.Flag_Remota.valores[4] = 4;
				RT_geral.RT_850_BD.Flag_Remota.valores[5] = 5;
				RT_geral.RT_850_BD.Flag_Remota.itens[0] = "Valor Leitura sem Falha";
				RT_geral.RT_850_BD.Flag_Remota.itens[1] = "Valor Leitura com Falha";
				RT_geral.RT_850_BD.Flag_Remota.itens[2] = "Valor Baixo sem Falha";
				RT_geral.RT_850_BD.Flag_Remota.itens[3] = "Valor Baixo com Falha";
				RT_geral.RT_850_BD.Flag_Remota.itens[4] = "Valor Alto sem Falha";
				RT_geral.RT_850_BD.Flag_Remota.itens[5] = "Valor Alto com Falha";
				RT_geral.RT_850_BD.Flag_Supervisorio.nome = "Flag Supervisorio";
				RT_geral.RT_850_BD.Flag_Supervisorio.Indice_padrao = 0;
				RT_geral.RT_850_BD.Flag_Supervisorio.Numero_itens = 6;
				RT_geral.RT_850_BD.Flag_Supervisorio.valores[0] = 0;
				RT_geral.RT_850_BD.Flag_Supervisorio.valores[1] = 1;
				RT_geral.RT_850_BD.Flag_Supervisorio.valores[2] = 2;
				RT_geral.RT_850_BD.Flag_Supervisorio.valores[3] = 3;
				RT_geral.RT_850_BD.Flag_Supervisorio.valores[4] = 4;
				RT_geral.RT_850_BD.Flag_Supervisorio.valores[5] = 5;
				RT_geral.RT_850_BD.Flag_Supervisorio.itens[0] = "Valor Leitura sem Falha";
				RT_geral.RT_850_BD.Flag_Supervisorio.itens[1] = "Valor Leitura com Falha";
				RT_geral.RT_850_BD.Flag_Supervisorio.itens[2] = "Valor Baixo sem Falha";
				RT_geral.RT_850_BD.Flag_Supervisorio.itens[3] = "Valor Baixo com Falha";
				RT_geral.RT_850_BD.Flag_Supervisorio.itens[4] = "Valor Alto sem Falha";
				RT_geral.RT_850_BD.Flag_Supervisorio.itens[5] = "Valor Alto com Falha";
				RT_geral.RT_850_BD.Variaveis_Numero.nome = "Número de variáveis do sistema";
				RT_geral.RT_850_BD.Variaveis_Numero.Padrao = 0;
				RT_geral.RT_850_BD.Variaveis_Numero.Lmte_inf = 0;
				RT_geral.RT_850_BD.Variaveis_Numero.Lmte_sup = 300;
				i = 0;
				do
				{
					RT_geral.Variaveis_RT_850[i].Nome.Padrao = "";
					RT_geral.Variaveis_RT_850[i].Nome.nome = "Variável " + Conversions.ToString(i + 1);
					RT_geral.Variaveis_RT_850[i].Escala_ini.Lmte_sup = 0;
					RT_geral.Variaveis_RT_850[i].Escala_ini.Padrao = 0;
					RT_geral.Variaveis_RT_850[i].Escala_ini.Lmte_inf = -999;
					RT_geral.Variaveis_RT_850[i].Escala_ini.Lmte_sup = 20000;
					RT_geral.Variaveis_RT_850[i].Escala_ini.nome = "Variável " + Conversions.ToString(i + 1) + " - Escala inicial";
					RT_geral.Variaveis_RT_850[i].Escala_fim.Padrao = 100;
					RT_geral.Variaveis_RT_850[i].Escala_fim.Lmte_inf = -999;
					RT_geral.Variaveis_RT_850[i].Escala_fim.Lmte_sup = 20000;
					RT_geral.Variaveis_RT_850[i].Escala_fim.nome = "Variável " + Conversions.ToString(i + 1) + " - Escala final";
					RT_geral.Variaveis_RT_850[i].Escala_tratamento.Indice_padrao = 0;
					RT_geral.Variaveis_RT_850[i].Escala_tratamento.nome = "Variável " + Conversions.ToString(i + 1) + " - Tratamento";
					RT_geral.Variaveis_RT_850[i].Pto_dec_ini.Indice_padrao = 0;
					RT_geral.Variaveis_RT_850[i].Pto_dec_ini.nome = "Variável " + Conversions.ToString(i + 1) + " - Ponto decimal inicial";
					RT_geral.Variaveis_RT_850[i].Pto_dec_fim.Indice_padrao = 0;
					RT_geral.Variaveis_RT_850[i].Pto_dec_fim.nome = "Variável " + Conversions.ToString(i + 1) + " - Ponto decimal final";
					RT_geral.Variaveis_RT_850[i].Nivel_alm_1.Padrao = 0;
					RT_geral.Variaveis_RT_850[i].Nivel_alm_1.nome = "Variável " + Conversions.ToString(i + 1) + " - Nível alarme 1";
					RT_geral.Variaveis_RT_850[i].Tipo_alm_1.Indice_padrao = 0;
					RT_geral.Variaveis_RT_850[i].Tipo_alm_1.nome = "Variável " + Conversions.ToString(i + 1) + " - Tipo alarme 1";
					RT_geral.Variaveis_RT_850[i].Msg_alm_1.Indice_padrao = 0;
					RT_geral.Variaveis_RT_850[i].Msg_alm_1.nome = "Variável " + Conversions.ToString(i + 1) + " - Mensagem alarme 1";
					RT_geral.Variaveis_RT_850[i].Nivel_alm_2.Padrao = 0;
					RT_geral.Variaveis_RT_850[i].Nivel_alm_1.nome = "Variável " + Conversions.ToString(i + 1) + " - Nível alarme 2";
					RT_geral.Variaveis_RT_850[i].Tipo_alm_2.Indice_padrao = 0;
					RT_geral.Variaveis_RT_850[i].Tipo_alm_1.nome = "Variável " + Conversions.ToString(i + 1) + " - Tipo alarme 2";
					RT_geral.Variaveis_RT_850[i].Msg_alm_2.Indice_padrao = 0;
					RT_geral.Variaveis_RT_850[i].Msg_alm_1.nome = "Variável " + Conversions.ToString(i + 1) + " - Mensagem alarme 2";
					RT_geral.Variaveis_RT_850[i].Dsp_tela.Padrao = 0;
					RT_geral.Variaveis_RT_850[i].Dsp_tela.nome = "Variável " + Conversions.ToString(i + 1) + " - Número tela";
					RT_geral.Variaveis_RT_850[i].Dsp_tela.Lmte_inf = 0;
					RT_geral.Variaveis_RT_850[i].Dsp_tela.Lmte_sup = 75;
					RT_geral.Variaveis_RT_850[i].Dsp_pos.Indice_padrao = 0;
					RT_geral.Variaveis_RT_850[i].Dsp_pos.nome = "Variável " + Conversions.ToString(i + 1) + " - Posicao display";
					i++;
				}
				while (i <= 299);
				i = 0;
				do
				{
					RT_geral.RT_850_Ctrl_1[i].Nome.nome = "Nome do equipamento";
					RT_geral.RT_850_Ctrl_1[i].Nome.Padrao = "";
					RT_geral.RT_850_Ctrl_1[i].Canal.nome = "Canal de comunicação";
					RT_geral.RT_850_Ctrl_1[i].Canal.Indice_padrao = 0;
					RT_geral.RT_850_Ctrl_1[i].Timeout.nome = "Timeout";
					RT_geral.RT_850_Ctrl_1[i].Timeout.Indice_padrao = 0;
					RT_geral.RT_850_Ctrl_1[i].Comando.nome = "Habilitação de Comando";
					RT_geral.RT_850_Ctrl_1[i].Comando.Indice_padrao = 0;
					RT_geral.RT_850_Ctrl_1[i].Prioridade.nome = "Prioridade";
					RT_geral.RT_850_Ctrl_1[i].Prioridade.Indice_padrao = 1;
					RT_geral.RT_850_Ctrl_1[i].Modelo.nome = "Modêlo Equipamento";
					RT_geral.RT_850_Ctrl_1[i].Modelo.Indice_padrao = 0;
					int num5 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_1[i].Var[num5].nome = "Variável analógica - EA " + Conversions.ToString(num5 + 1);
						RT_geral.RT_850_Ctrl_1[i].Var[num5].Indice_padrao = 0;
						RT_geral.RT_850_Ctrl_1[i].Ref[num5].nome = "Referência analógica - EA " + Conversions.ToString(num5 + 1);
						RT_geral.RT_850_Ctrl_1[i].Ref[num5].Indice_padrao = 0;
						num5++;
					}
					while (num5 <= 3);
					num5 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_1[i].Crtl_nome[num5].nome = RT_geral.Nome_ctrl[0];
						RT_geral.RT_850_Ctrl_1[i].Crtl_nome[num5].Indice_padrao = 0;
						RT_geral.RT_850_Ctrl_1[i].Crtl_indice[num5].Valor = 0;
						RT_geral.RT_850_Ctrl_1[i].Crtl_indice[num5].Lmte_inf = 0;
						RT_geral.RT_850_Ctrl_1[i].Crtl_indice[num5].Lmte_sup = 200;
						num5++;
					}
					while (num5 <= 0);
					i++;
				}
				while (i <= 80);
				i = 0;
				do
				{
					RT_geral.RT_850_Ctrl_4[i].Nome.nome = "Nome do equipamento";
					RT_geral.RT_850_Ctrl_4[i].Nome.Padrao = "";
					RT_geral.RT_850_Ctrl_4[i].Canal.nome = "Canal de comunicação";
					RT_geral.RT_850_Ctrl_4[i].Canal.Indice_padrao = 0;
					RT_geral.RT_850_Ctrl_4[i].Timeout.nome = "Timeout";
					RT_geral.RT_850_Ctrl_4[i].Timeout.Indice_padrao = 0;
					RT_geral.RT_850_Ctrl_4[i].Comando.nome = "Habilitação de Comando";
					RT_geral.RT_850_Ctrl_4[i].Comando.Indice_padrao = 0;
					RT_geral.RT_850_Ctrl_4[i].Prioridade.nome = "Prioridade";
					RT_geral.RT_850_Ctrl_4[i].Prioridade.Indice_padrao = 1;
					RT_geral.RT_850_Ctrl_4[i].Modelo.nome = "Modêlo Equipamento";
					RT_geral.RT_850_Ctrl_4[i].Modelo.Indice_padrao = 0;
					int num5 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_4[i].Var[num5].nome = "Variável analógica - EA " + Conversions.ToString(num5 + 1);
						RT_geral.RT_850_Ctrl_4[i].Var[num5].Indice_padrao = 0;
						RT_geral.RT_850_Ctrl_4[i].Ref[num5].nome = "Referência analógica - EA " + Conversions.ToString(num5 + 1);
						RT_geral.RT_850_Ctrl_4[i].Ref[num5].Indice_padrao = 0;
						num5++;
					}
					while (num5 <= 3);
					num5 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_4[i].Periferico_Indice[num5].nome = "Periferico " + Conversions.ToString(num5 + 1);
						RT_geral.RT_850_Ctrl_4[i].Periferico_Indice[num5].Indice_padrao = 0;
						RT_geral.RT_850_Ctrl_4[i].Periferico_Modelo[num5].nome = "Periferico Modelo" + Conversions.ToString(num5 + 1);
						RT_geral.RT_850_Ctrl_4[i].Periferico_Modelo[num5].Indice_padrao = 0;
						num5++;
					}
					while (num5 <= 4);
					num5 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_4[i].Crtl_nome[num5].nome = RT_geral.Nome_ctrl[0];
						RT_geral.RT_850_Ctrl_4[i].Crtl_nome[num5].Indice_padrao = 0;
						RT_geral.RT_850_Ctrl_4[i].Crtl_indice[num5].Valor = 0;
						RT_geral.RT_850_Ctrl_4[i].Crtl_indice[num5].Lmte_inf = 0;
						RT_geral.RT_850_Ctrl_4[i].Crtl_indice[num5].Lmte_sup = 200;
						num5++;
					}
					while (num5 <= 3);
					i++;
				}
				while (i <= 50);
				i = 0;
				do
				{
					RT_geral.RT_850_Ctrl_8[i].Nome.nome = "Nome do equipamento";
					RT_geral.RT_850_Ctrl_8[i].Nome.Padrao = "";
					RT_geral.RT_850_Ctrl_8[i].Canal.nome = "Canal de comunicação";
					RT_geral.RT_850_Ctrl_8[i].Canal.Indice_padrao = 0;
					RT_geral.RT_850_Ctrl_8[i].Timeout.nome = "Timeout";
					RT_geral.RT_850_Ctrl_8[i].Timeout.Indice_padrao = 0;
					RT_geral.RT_850_Ctrl_8[i].Comando.nome = "Habilitação de Comando";
					RT_geral.RT_850_Ctrl_8[i].Comando.Indice_padrao = 0;
					RT_geral.RT_850_Ctrl_8[i].Prioridade.nome = "Prioridade";
					RT_geral.RT_850_Ctrl_8[i].Prioridade.Indice_padrao = 1;
					RT_geral.RT_850_Ctrl_8[i].Modelo.nome = "Modêlo Equipamento";
					RT_geral.RT_850_Ctrl_8[i].Modelo.Indice_padrao = 0;
					int num5 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_8[i].Var[num5].nome = "Variável analógica - EA " + Conversions.ToString(num5 + 1);
						RT_geral.RT_850_Ctrl_8[i].Var[num5].Indice_padrao = 0;
						num5++;
					}
					while (num5 <= 15);
					num5 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_8[i].Ref[num5].nome = "Referência analógica - EA " + Conversions.ToString(num5 + 1);
						RT_geral.RT_850_Ctrl_8[i].Ref[num5].Indice_padrao = 0;
						num5++;
					}
					while (num5 <= 3);
					num5 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_8[i].Periferico_Indice[num5].nome = "Periferico " + Conversions.ToString(num5 + 1);
						RT_geral.RT_850_Ctrl_8[i].Periferico_Indice[num5].Indice_padrao = 0;
						RT_geral.RT_850_Ctrl_8[i].Periferico_Modelo[num5].nome = "Periferico Modelo" + Conversions.ToString(num5 + 1);
						RT_geral.RT_850_Ctrl_8[i].Periferico_Modelo[num5].Indice_padrao = 0;
						num5++;
					}
					while (num5 <= 4);
					num5 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_8[i].Crtl_nome[num5].nome = RT_geral.Nome_ctrl[0];
						RT_geral.RT_850_Ctrl_8[i].Crtl_nome[num5].Indice_padrao = 0;
						RT_geral.RT_850_Ctrl_8[i].Crtl_indice[num5].Valor = 0;
						RT_geral.RT_850_Ctrl_8[i].Crtl_indice[num5].Lmte_inf = 0;
						RT_geral.RT_850_Ctrl_8[i].Crtl_indice[num5].Lmte_sup = 200;
						num5++;
					}
					while (num5 <= 7);
					i++;
				}
				while (i <= 20);
				RT_geral.RT_850_BD.Vista_selecionado.nome = "Seleção Vista";
				RT_geral.RT_850_BD.Vista_selecionado.Indice_padrao = 0;
				RT_geral.RT_850_BD.Vista_selecionado.Numero_itens = 1;
				RT_geral.RT_850_BD.Vista_selecionado.valores[0] = 0;
				RT_geral.RT_850_BD.Vista_selecionado.itens[0] = "Nenhum Vista Habilitado";
				RT_geral.RT_850_Vista[0].Nome.nome = "Nome do equipamento";
				RT_geral.RT_850_Vista[0].Nome.Padrao = "Nenhum Vista Habilitado";
				i = 1;
				do
				{
					RT_geral.RT_850_Vista[i].Nome.nome = "Nome do equipamento";
					RT_geral.RT_850_Vista[i].Nome.Padrao = "Vista " + Conversion.Str(i);
					RT_geral.RT_850_Vista[i].Canal.nome = "Canal de comunicação";
					RT_geral.RT_850_Vista[i].Canal.Indice_padrao = 0;
					RT_geral.RT_850_Vista[i].Timeout.nome = "Timeout";
					RT_geral.RT_850_Vista[i].Timeout.Indice_padrao = 0;
					RT_geral.RT_850_Vista[i].Modelo.nome = "Modelo Equip.";
					RT_geral.RT_850_Vista[i].Modelo.Indice_padrao = 0;
					RT_geral.RT_850_Vista[i].Prioridade.nome = "Prioridade";
					RT_geral.RT_850_Vista[i].Prioridade.Indice_padrao = 0;
					RT_geral.RT_850_Vista[i].Num_var.nome = "Número de variáveis da Vista " + Conversion.Str(i + 1);
					RT_geral.RT_850_Vista[i].Num_var.Lmte_inf = 0;
					RT_geral.RT_850_Vista[i].Num_var.Lmte_sup = 40;
					RT_geral.RT_850_Vista[i].Num_var.Padrao = 0;
					RT_geral.RT_850_Vista[i].Num_equip.nome = "Número de Equipamentos da Vista " + Conversion.Str(i + 1);
					RT_geral.RT_850_Vista[i].Num_equip.Lmte_inf = 0;
					RT_geral.RT_850_Vista[i].Num_equip.Lmte_sup = 20;
					RT_geral.RT_850_Vista[i].Num_equip.Padrao = 0;
					int num5 = 0;
					do
					{
						RT_geral.RT_850_Vista[i].Variaveis[num5].nome = "Variável " + Conversion.Str(num5 + 1) + " da Vista " + Conversion.Str(i + 1);
						RT_geral.RT_850_Vista[i].Variaveis[num5].Indice_padrao = 0;
						num5++;
					}
					while (num5 <= 39);
					num5 = 0;
					do
					{
						RT_geral.RT_850_Vista[i].Equipamentos[num5].nome = "Equipamento " + Conversion.Str(num5 + 1) + " da Vista " + Conversion.Str(i + 1);
						RT_geral.RT_850_Vista[i].Equipamentos[num5].Indice_padrao = 0;
						num5++;
					}
					while (num5 <= 19);
					i++;
				}
				while (i <= 5);
			}
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x002DFA54 File Offset: 0x002DDE54
		public void Inicializa_DadosEStruturaRT850_Default()
		{
			RT_geral.RT_850_BD.Versao.Valor = RT_geral.RT_850_BD.Equip.Padrao;
			RT_geral.RT_850_BD.Build.Valor = RT_geral.RT_850_BD.Build.Padrao;
			RT_geral.RT_850_BD.Release.Valor = RT_geral.RT_850_BD.Release.Padrao;
			RT_geral.RT_850_BD.Equip.Valor = RT_geral.RT_850_BD.Equip.Padrao;
			RT_geral.RT_850_BD.Msg_linha_1.Valor = RT_geral.RT_850_BD.Msg_linha_1.Padrao;
			RT_geral.RT_850_BD.Msg_linha_2.Valor = RT_geral.RT_850_BD.Msg_linha_2.Padrao;
			RT_geral.RT_850_BD.Msg_linha_3.Valor = RT_geral.RT_850_BD.Msg_linha_3.Padrao;
			RT_geral.RT_850_BD.Msg_linha_4.Valor = RT_geral.RT_850_BD.Msg_linha_4.Padrao;
			RT_geral.RT_850_BD.End_mestre_canal_1.Valor = RT_geral.RT_850_BD.End_mestre_canal_1.Padrao;
			RT_geral.RT_850_BD.End_mestre_canal_2.Valor = RT_geral.RT_850_BD.End_mestre_canal_2.Padrao;
			RT_geral.RT_850_BD.Intervalo_leitura_canal_1.Valor = RT_geral.RT_850_BD.Intervalo_leitura_canal_1.Padrao;
			RT_geral.RT_850_BD.Intervalo_leitura_canal_2.Valor = RT_geral.RT_850_BD.Intervalo_leitura_canal_2.Padrao;
			RT_geral.RT_850_BD.BaudRate_canal_1.Indice = RT_geral.RT_850_BD.BaudRate_canal_1.Indice_padrao;
			RT_geral.RT_850_BD.BaudRate_canal_1.Valor = RT_geral.RT_850_BD.BaudRate_canal_1.valores[RT_geral.RT_850_BD.BaudRate_canal_1.Indice];
			RT_geral.RT_850_BD.BaudRate_canal_2.Indice = RT_geral.RT_850_BD.BaudRate_canal_2.Indice_padrao;
			RT_geral.RT_850_BD.BaudRate_canal_2.Valor = RT_geral.RT_850_BD.BaudRate_canal_2.valores[RT_geral.RT_850_BD.BaudRate_canal_2.Indice];
			RT_geral.RT_850_BD.BaudRate_canal_1.Indice = RT_geral.RT_850_BD.BaudRate_canal_1.Indice_padrao;
			RT_geral.RT_850_BD.BaudRate_canal_2.Indice = RT_geral.RT_850_BD.BaudRate_canal_2.Indice_padrao;
			RT_geral.RT_850_BD.Timeout_canal_1.Valor = RT_geral.RT_850_BD.Timeout_canal_1.Padrao;
			RT_geral.RT_850_BD.Timeout_canal_2.Valor = RT_geral.RT_850_BD.Timeout_canal_2.Padrao;
			RT_geral.RT_850_BD.Tempo_ptt_canal_1.Valor = RT_geral.RT_850_BD.Tempo_ptt_canal_1.Padrao;
			RT_geral.RT_850_BD.Tempo_ptt_canal_2.Valor = RT_geral.RT_850_BD.Tempo_ptt_canal_2.Padrao;
			RT_geral.RT_850_BD.Numero_tentativas_canal_1.Valor = RT_geral.RT_850_BD.Numero_tentativas_canal_1.Padrao;
			RT_geral.RT_850_BD.Numero_tentativas_canal_2.Valor = RT_geral.RT_850_BD.Numero_tentativas_canal_2.Padrao;
			RT_geral.RT_850_BD.Numero_erros_falha_canal_1.Valor = RT_geral.RT_850_BD.Numero_erros_falha_canal_1.Padrao;
			RT_geral.RT_850_BD.Numero_erros_falha_canal_2.Valor = RT_geral.RT_850_BD.Numero_erros_falha_canal_2.Padrao;
			RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.ValorPadrao();
			RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.ValorPadrao();
			RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor = RT_geral.RT_850_BD.Numero_equip_tipo_1.Padrao;
			RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor = RT_geral.RT_850_BD.Numero_equip_tipo_2.Padrao;
			RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor = RT_geral.RT_850_BD.Numero_equip_tipo_3.Padrao;
			RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor = RT_geral.RT_850_BD.Numero_equip_tipo_vista.Padrao;
			RT_geral.RT_850_BD.End_inicial_equip_tipo_1.Valor = RT_geral.RT_850_BD.End_inicial_equip_tipo_1.Padrao;
			RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Valor = RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Padrao;
			RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Valor = RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Padrao;
			RT_geral.RT_850_BD.End_inicial_equip_tipo_vista.Valor = RT_geral.RT_850_BD.End_inicial_equip_tipo_vista.Padrao;
			RT_geral.RT_850_BD.Sincronismo.Valor = RT_geral.RT_850_BD.Sincronismo.Padrao;
			RT_geral.RT_850_BD.ConfereResposta.Valor = RT_geral.RT_850_BD.ConfereResposta.Padrao;
			RT_geral.RT_850_BD.Modo_Estatistica.Valor = RT_geral.RT_850_BD.Modo_Estatistica.Padrao;
			RT_geral.RT_850_BD.LiberaTeclado.ValorPadrao();
			RT_geral.RT_850_BD.Flag_Remota.IndicePadrao();
			RT_geral.RT_850_BD.Flag_Supervisorio.IndicePadrao();
			RT_geral.RT_850_BD.Variaveis_Numero.Valor = RT_geral.RT_850_BD.Variaveis_Numero.Padrao;
			int num = 0;
			checked
			{
				do
				{
					RT_geral.Variaveis_RT_850[num].Nome.Valor = RT_geral.Variaveis_RT_850[num].Nome.Padrao;
					RT_geral.Variaveis_RT_850[num].Escala_ini.Valor = RT_geral.Variaveis_RT_850[num].Escala_ini.Padrao;
					RT_geral.Variaveis_RT_850[num].Escala_fim.Valor = RT_geral.Variaveis_RT_850[num].Escala_fim.Padrao;
					RT_geral.Variaveis_RT_850[num].Pto_dec_ini.Indice = RT_geral.Variaveis_RT_850[num].Pto_dec_ini.Indice_padrao;
					RT_geral.Variaveis_RT_850[num].Pto_dec_fim.Indice = RT_geral.Variaveis_RT_850[num].Pto_dec_fim.Indice_padrao;
					RT_geral.Variaveis_RT_850[num].Nivel_alm_1.Valor = RT_geral.Variaveis_RT_850[num].Nivel_alm_1.Padrao;
					RT_geral.Variaveis_RT_850[num].Tipo_alm_1.Indice = RT_geral.Variaveis_RT_850[num].Tipo_alm_1.Indice_padrao;
					RT_geral.Variaveis_RT_850[num].Msg_alm_1.Indice = RT_geral.Variaveis_RT_850[num].Msg_alm_1.Indice_padrao;
					RT_geral.Variaveis_RT_850[num].Nivel_alm_2.Valor = RT_geral.Variaveis_RT_850[num].Nivel_alm_2.Padrao;
					RT_geral.Variaveis_RT_850[num].Tipo_alm_2.Indice = RT_geral.Variaveis_RT_850[num].Tipo_alm_2.Indice_padrao;
					RT_geral.Variaveis_RT_850[num].Msg_alm_2.Indice = RT_geral.Variaveis_RT_850[num].Msg_alm_2.Indice_padrao;
					RT_geral.Variaveis_RT_850[num].Dsp_pos.Indice = RT_geral.Variaveis_RT_850[num].Dsp_pos.Indice_padrao;
					RT_geral.Variaveis_RT_850[num].Dsp_tela.Valor = RT_geral.Variaveis_RT_850[num].Dsp_tela.Padrao;
					num++;
				}
				while (num <= 299);
				num = 0;
				do
				{
					RT_geral.RT_850_Ctrl_1[num].Nome.Valor = RT_geral.RT_850_Ctrl_1[num].Nome.Padrao;
					RT_geral.RT_850_Ctrl_1[num].Canal.Indice = RT_geral.RT_850_Ctrl_1[num].Canal.Indice_padrao;
					RT_geral.RT_850_Ctrl_1[num].Timeout.Indice = RT_geral.RT_850_Ctrl_1[num].Timeout.Indice_padrao;
					RT_geral.RT_850_Ctrl_1[num].Comando.Indice = RT_geral.RT_850_Ctrl_1[num].Comando.Indice_padrao;
					RT_geral.RT_850_Ctrl_1[num].Prioridade.Indice = RT_geral.RT_850_Ctrl_1[num].Prioridade.Indice_padrao;
					RT_geral.RT_850_Ctrl_1[num].Modelo.Indice = RT_geral.RT_850_Ctrl_1[num].Modelo.Indice_padrao;
					int num2 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_1[num].Var[num2].Indice = RT_geral.RT_850_Ctrl_1[num].Var[num2].Indice_padrao;
						RT_geral.RT_850_Ctrl_1[num].Ref[num2].Indice = RT_geral.RT_850_Ctrl_1[num].Ref[num2].Indice_padrao;
						num2++;
					}
					while (num2 <= 3);
					num2 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_1[num].Crtl_nome[num2].Indice = RT_geral.RT_850_Ctrl_1[num].Crtl_nome[num2].Indice_padrao;
						RT_geral.RT_850_Ctrl_1[num].Crtl_indice[num2].Valor = RT_geral.RT_850_Ctrl_1[num].Crtl_indice[num2].Padrao;
						num2++;
					}
					while (num2 <= 0);
					num++;
				}
				while (num <= 80);
				num = 0;
				do
				{
					RT_geral.RT_850_Ctrl_4[num].Nome.Valor = RT_geral.RT_850_Ctrl_4[num].Nome.Padrao;
					RT_geral.RT_850_Ctrl_4[num].Canal.Indice = RT_geral.RT_850_Ctrl_4[num].Canal.Indice_padrao;
					RT_geral.RT_850_Ctrl_4[num].Timeout.Indice = RT_geral.RT_850_Ctrl_4[num].Timeout.Indice_padrao;
					RT_geral.RT_850_Ctrl_4[num].Comando.Indice = RT_geral.RT_850_Ctrl_4[num].Comando.Indice_padrao;
					RT_geral.RT_850_Ctrl_4[num].Prioridade.Indice = RT_geral.RT_850_Ctrl_4[num].Prioridade.Indice_padrao;
					RT_geral.RT_850_Ctrl_4[num].Modelo.Indice = RT_geral.RT_850_Ctrl_4[num].Modelo.Indice_padrao;
					int num2 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_4[num].Var[num2].Indice = RT_geral.RT_850_Ctrl_4[num].Var[num2].Indice_padrao;
						RT_geral.RT_850_Ctrl_4[num].Ref[num2].Indice = RT_geral.RT_850_Ctrl_4[num].Ref[num2].Indice_padrao;
						num2++;
					}
					while (num2 <= 3);
					num2 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_4[num].Periferico_Indice[num2].Indice = RT_geral.RT_850_Ctrl_4[num].Periferico_Indice[num2].Indice_padrao;
						RT_geral.RT_850_Ctrl_4[num].Periferico_Modelo[num2].Indice = RT_geral.RT_850_Ctrl_4[num].Periferico_Modelo[num2].Indice_padrao;
						num2++;
					}
					while (num2 <= 4);
					num2 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_4[num].Crtl_nome[num2].Indice = RT_geral.RT_850_Ctrl_4[num].Crtl_nome[num2].Indice_padrao;
						RT_geral.RT_850_Ctrl_4[num].Crtl_indice[num2].Valor = RT_geral.RT_850_Ctrl_4[num].Crtl_indice[num2].Padrao;
						num2++;
					}
					while (num2 <= 3);
					num++;
				}
				while (num <= 50);
				num = 0;
				do
				{
					RT_geral.RT_850_Ctrl_8[num].Nome.Valor = RT_geral.RT_850_Ctrl_8[num].Nome.Padrao;
					RT_geral.RT_850_Ctrl_8[num].Canal.Indice = RT_geral.RT_850_Ctrl_8[num].Canal.Indice_padrao;
					RT_geral.RT_850_Ctrl_8[num].Timeout.Indice = RT_geral.RT_850_Ctrl_8[num].Timeout.Indice_padrao;
					RT_geral.RT_850_Ctrl_8[num].Comando.Indice = RT_geral.RT_850_Ctrl_8[num].Comando.Indice_padrao;
					RT_geral.RT_850_Ctrl_8[num].Prioridade.Indice = RT_geral.RT_850_Ctrl_8[num].Prioridade.Indice_padrao;
					RT_geral.RT_850_Ctrl_8[num].Modelo.Indice = RT_geral.RT_850_Ctrl_8[num].Modelo.Indice_padrao;
					int num2 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_8[num].Var[num2].Indice = RT_geral.RT_850_Ctrl_8[num].Var[num2].Indice_padrao;
						num2++;
					}
					while (num2 <= 15);
					num2 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_8[num].Ref[num2].Indice = RT_geral.RT_850_Ctrl_8[num].Ref[num2].Indice_padrao;
						num2++;
					}
					while (num2 <= 3);
					num2 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_8[num].Periferico_Indice[num2].Indice = RT_geral.RT_850_Ctrl_8[num].Periferico_Indice[num2].Indice_padrao;
						RT_geral.RT_850_Ctrl_8[num].Periferico_Modelo[num2].Indice = RT_geral.RT_850_Ctrl_8[num].Periferico_Modelo[num2].Indice_padrao;
						num2++;
					}
					while (num2 <= 4);
					num2 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_8[num].Crtl_nome[num2].Indice = RT_geral.RT_850_Ctrl_8[num].Crtl_nome[num2].Indice_padrao;
						RT_geral.RT_850_Ctrl_8[num].Crtl_indice[num2].Valor = RT_geral.RT_850_Ctrl_8[num].Crtl_indice[num2].Padrao;
						num2++;
					}
					while (num2 <= 7);
					num++;
				}
				while (num <= 20);
				num = 0;
				do
				{
					RT_geral.RT_850_Vista[num].Nome.Valor = RT_geral.RT_850_Vista[num].Nome.Padrao;
					num++;
				}
				while (num <= 5);
				RT_geral.RT_850_BD.Vista_selecionado.Indice = RT_geral.RT_850_BD.Vista_selecionado.Indice_padrao;
				num = 0;
				do
				{
					RT_geral.RT_850_Vista[num].Nome.Valor = RT_geral.RT_850_Vista[num].Nome.Padrao;
					RT_geral.RT_850_Vista[num].Canal.Indice = RT_geral.RT_850_Vista[num].Canal.Indice_padrao;
					RT_geral.RT_850_Vista[num].Timeout.Indice = RT_geral.RT_850_Vista[num].Timeout.Indice_padrao;
					RT_geral.RT_850_Vista[num].Prioridade.Indice = RT_geral.RT_850_Vista[num].Prioridade.Indice_padrao;
					RT_geral.RT_850_Vista[num].Modelo.Indice = RT_geral.RT_850_Vista[num].Modelo.Indice_padrao;
					RT_geral.RT_850_Vista[num].Num_equip.Valor = RT_geral.RT_850_Vista[num].Num_equip.Padrao;
					RT_geral.RT_850_Vista[num].Num_var.Valor = RT_geral.RT_850_Vista[num].Num_var.Padrao;
					int num2 = 0;
					do
					{
						RT_geral.RT_850_Vista[num].Variaveis[num2].Indice = RT_geral.RT_850_Vista[num].Variaveis[num2].Indice_padrao;
						num2++;
					}
					while (num2 <= 39);
					num2 = 0;
					do
					{
						RT_geral.RT_850_Vista[num].Equipamentos[num2].Indice = RT_geral.RT_850_Vista[num].Equipamentos[num2].Indice_padrao;
						num2++;
					}
					while (num2 <= 19);
					num++;
				}
				while (num <= 5);
				ComboBox comboBox_Seleciona_Vista_RT_ = this.ComboBox_Seleciona_Vista_RT_850;
				this.CarregaComboBoxVista_Selecao_Habilitados(ref comboBox_Seleciona_Vista_RT_, RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor, RT_geral.RT_850_BD.Vista_selecionado.Indice);
				this.ComboBox_Seleciona_Vista_RT_850 = comboBox_Seleciona_Vista_RT_;
			}
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x002E0A88 File Offset: 0x002DEE88
		public void Carrega_Msg_Alarme_RT_850()
		{
			RT_geral.RT_850_MSG_ALARME[0] = "Nível Baixo";
			RT_geral.RT_850_MSG_ALARME[1] = "Nível Alto";
			RT_geral.RT_850_MSG_ALARME[2] = "Pressão Baixa";
			RT_geral.RT_850_MSG_ALARME[3] = "Pressão Alta";
			RT_geral.RT_850_MSG_ALARME[4] = "Vazio";
			RT_geral.RT_850_MSG_ALARME[5] = "Cheio";
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x002E0AE0 File Offset: 0x002DEEE0
		public void Carrega_Msg_Alarme_Configuravel_RT_850()
		{
			int num = 0;
			checked
			{
				do
				{
					string text = "msg Alarme " + Conversion.Str(num + 1);
					RT_geral.RT_850_MSG_ALARME_CONFIG[num] = text;
					num++;
				}
				while (num <= 19);
			}
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x002E0B18 File Offset: 0x002DEF18
		public void Inicializa_Linha_Variaveis_RT_850(int linha)
		{
			checked
			{
				RT_geral.Variaveis_RT_850[linha - 1].Nome.Padrao = "";
				RT_geral.Variaveis_RT_850[linha - 1].Escala_ini.Padrao = 0;
				RT_geral.Variaveis_RT_850[linha - 1].Escala_ini.Lmte_inf = -999;
				RT_geral.Variaveis_RT_850[linha - 1].Escala_ini.Lmte_sup = 20000;
				RT_geral.Variaveis_RT_850[linha - 1].Escala_fim.Padrao = 100;
				RT_geral.Variaveis_RT_850[linha - 1].Escala_fim.Lmte_inf = -999;
				RT_geral.Variaveis_RT_850[linha - 1].Escala_fim.Lmte_sup = 20000;
				RT_geral.Variaveis_RT_850[linha - 1].Pto_dec_ini.Indice_padrao = 0;
				RT_geral.Variaveis_RT_850[linha - 1].Pto_dec_fim.Indice_padrao = 0;
				RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_1.Padrao = 0;
				RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_1.Lmte_inf = -999;
				RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_1.Lmte_sup = 20000;
				RT_geral.Variaveis_RT_850[linha - 1].Tipo_alm_1.Indice_padrao = 0;
				RT_geral.Variaveis_RT_850[linha - 1].Msg_alm_1.Indice_padrao = 0;
				RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_2.Padrao = 0;
				RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_2.Lmte_inf = -999;
				RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_2.Lmte_sup = 20000;
				RT_geral.Variaveis_RT_850[linha - 1].Tipo_alm_2.Indice_padrao = 0;
				RT_geral.Variaveis_RT_850[linha - 1].Msg_alm_2.Indice_padrao = 0;
				RT_geral.Variaveis_RT_850[linha - 1].Nome.Valor = RT_geral.Variaveis_RT_850[linha - 1].Nome.Padrao;
				RT_geral.Variaveis_RT_850[linha - 1].Escala_ini.Valor = RT_geral.Variaveis_RT_850[linha - 1].Escala_ini.Padrao;
				RT_geral.Variaveis_RT_850[linha - 1].Escala_fim.Valor = RT_geral.Variaveis_RT_850[linha - 1].Escala_fim.Padrao;
				RT_geral.Variaveis_RT_850[linha - 1].Pto_dec_ini.Indice = RT_geral.Variaveis_RT_850[linha - 1].Pto_dec_ini.Indice_padrao;
				RT_geral.Variaveis_RT_850[linha - 1].Pto_dec_fim.Indice = RT_geral.Variaveis_RT_850[linha - 1].Pto_dec_fim.Indice_padrao;
				RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_1.Valor = RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_1.Padrao;
				RT_geral.Variaveis_RT_850[linha - 1].Tipo_alm_1.Indice = RT_geral.Variaveis_RT_850[linha - 1].Tipo_alm_1.Indice_padrao;
				RT_geral.Variaveis_RT_850[linha - 1].Msg_alm_1.Indice = RT_geral.Variaveis_RT_850[linha - 1].Msg_alm_1.Indice_padrao;
				RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_2.Valor = RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_2.Padrao;
				RT_geral.Variaveis_RT_850[linha - 1].Tipo_alm_2.Indice = RT_geral.Variaveis_RT_850[linha - 1].Tipo_alm_2.Indice_padrao;
				RT_geral.Variaveis_RT_850[linha - 1].Msg_alm_2.Indice = RT_geral.Variaveis_RT_850[linha - 1].Msg_alm_2.Indice_padrao;
				RT_geral.Variaveis_RT_850[linha - 1].Dsp_tela.Valor = RT_geral.Variaveis_RT_850[linha - 1].Dsp_tela.Padrao;
				RT_geral.Variaveis_RT_850[linha - 1].Dsp_tela.Lmte_inf = 0;
				RT_geral.Variaveis_RT_850[linha - 1].Dsp_tela.Lmte_sup = 100;
				RT_geral.Variaveis_RT_850[linha - 1].Dsp_pos.Valor = RT_geral.Variaveis_RT_850[linha - 1].Dsp_pos.Indice_padrao;
			}
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x002E0F9C File Offset: 0x002DF39C
		public bool Verifica_linha_variaveis_RT_850(int linha)
		{
			bool result = false;
			if (linha == 0)
			{
				result = true;
			}
			else if (Operators.CompareString(Strings.Trim(RT_geral.Variaveis_RT_850[checked(linha - 1)].Nome.Valor), "", false) == 0)
			{
				Interaction.MsgBox("Variável: " + Conversion.Str(linha) + "\r\nParâmetro: Nome -> não válido", (MsgBoxStyle)32, "Atenção - Erro de Configuração");
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x002E100C File Offset: 0x002DF40C
		public void Atualiza_TelaRT850()
		{
			int num = 0;
			int num2 = 0;
			object obj = null;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				if (Operators.CompareString(RT_geral.RT_850_BD.Nome_Arquivo, "", false) == 0)
				{
					this.Text = "Configuração - CT 850";
				}
				else
				{
					this.Text = "Configuração - CT 850  -> Arquivo : " + RT_geral.RT_850_BD.Nome_Arquivo;
				}
				string text = "Identificação";
				this.TextBox_versao_RT850.Text = Conversions.ToString(RT_geral.RT_850_BD.Versao.Valor);
				this.TextBox_build_RT850.Text = Conversions.ToString(RT_geral.RT_850_BD.Build.Valor);
				this.TextBox_release_RT850.Text = Conversions.ToString(RT_geral.RT_850_BD.Release.Valor);
				this.TextBox_equipamento_RT850.Text = Conversions.ToString(RT_geral.RT_850_BD.Equip.Valor);
				string text2 = string.Concat(new string[]
				{
					Strings.Trim(RT_geral.RT_850_BD.Msg_linha_1.Valor),
					"\r\n",
					Strings.Trim(RT_geral.RT_850_BD.Msg_linha_2.Valor),
					"\r\n",
					Strings.Trim(RT_geral.RT_850_BD.Msg_linha_3.Valor),
					"\r\n",
					Strings.Trim(RT_geral.RT_850_BD.Msg_linha_4.Valor)
				});
				this.TextBox_msg_inicial_RT850.Text = text2;
				text = "canais de comunicação";
				this.Atualiza_canais_comunicacao();
				text = "variáveis";
				this.GeraDataGridView_variaveis_RT_850();
				this.Atualiza_DataGridView_Variaveis_RT850();
				text = "msg de alarme";
				this.Atualiza_DatagridView_Mensagem_Alarme_RT850();
				text = "Ctrl 1";
				this.GeraDataGridView_Equipamentos_CTLR_1_RT_850();
				this.Atualiza_DataGridView_Ctrl_1();
				text = "Ctrl 4";
				this.GeraDataGridView_Equipamentos_CTLR_4_RT_850();
				this.Atualiza_DataGridView_Ctrl_4();
				text = "Ctrl 8";
				this.GeraDataGridView_Equipamentos_CTLR_8_RT_850();
				this.Atualiza_DataGridView_Ctrl_8();
				text = "vista";
				ComboBox comboBox_Seleciona_Vista_RT_ = this.ComboBox_Seleciona_Vista_RT_850;
				this.CarregaComboBoxVista_Selecao_Habilitados(ref comboBox_Seleciona_Vista_RT_, RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor, RT_geral.RT_850_BD.Vista_selecionado.Indice);
				this.ComboBox_Seleciona_Vista_RT_850 = comboBox_Seleciona_Vista_RT_;
				if (RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor > 0)
				{
					if (RT_geral.RT_850_BD.Vista_selecionado.Indice == -1)
					{
						RT_geral.RT_850_BD.Vista_selecionado.Indice = 0;
					}
					this.Atualiza_TelaRT850_DadosVista(RT_geral.RT_850_BD.Vista_selecionado.Indice);
				}
				goto IL_294;
				IL_23C:
				MessageBox.Show("ERRO: Atualiza_TelaRT850():" + text);
				goto IL_294;
				IL_24F:
				num2 = -1;
								IL_265:;
			}
			catch (Exception) { }
			throw ProjectData.CreateProjectError(-2146828237);
			IL_294:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x002E12D4 File Offset: 0x002DF6D4
		public void Atualiza_TelaRT850_DadosVista(int vista)
		{
			this.GroupBox_parametros_vista.Enabled = true;
			checked
			{
				if (vista == 0)
				{
					this.ComboBox_Seleciona_Vista_RT_850.SelectedIndex = RT_geral.RT_850_BD.Vista_selecionado.Indice_padrao;
					this.TextBox_nome_vista.Text = "";
					this.ComboBox_porta_vista_RT_850.SelectedIndex = RT_geral.RT_850_Vista[vista].Canal.Indice_padrao;
					this.ComboBox_timeout_vista_RT_850.SelectedIndex = RT_geral.RT_850_Vista[vista].Timeout.Indice_padrao;
					this.ComboBox_prioridade_vista_RT_850.SelectedIndex = RT_geral.RT_850_Vista[vista].Prioridade.Indice_padrao;
					this.ComboBox_modelo_vista_RT_850.SelectedIndex = RT_geral.RT_850_Vista[vista].Modelo.Indice_padrao;
					this.NumericUpDown_num_var_vista.Value = new decimal(RT_geral.RT_850_Vista[vista].Num_var.Padrao);
					this.NumericUpDown_num_equip_vista.Value = new decimal(RT_geral.RT_850_Vista[vista].Num_equip.Padrao);
					this.GroupBox_parametros_vista.Enabled = false;
				}
				else
				{
					this.TextBox_nome_vista.Text = RT_geral.RT_850_Vista[vista].Nome.Valor;
					this.ComboBox_porta_vista_RT_850.SelectedIndex = RT_geral.RT_850_Vista[vista].Canal.Indice;
					this.ComboBox_timeout_vista_RT_850.SelectedIndex = RT_geral.RT_850_Vista[vista].Timeout.Indice;
					this.ComboBox_prioridade_vista_RT_850.SelectedIndex = RT_geral.RT_850_Vista[vista].Prioridade.Indice;
					this.ComboBox_modelo_vista_RT_850.SelectedIndex = RT_geral.LocalizaIndiceVetor_valor_indice(ref RT_geral.RT_850_Modelo, RT_geral.RT_850_Vista[vista].Modelo.Indice);
					this.NumericUpDown_num_var_vista.Value = new decimal(RT_geral.RT_850_Vista[vista].Num_var.Valor);
					this.NumericUpDown_num_equip_vista.Value = new decimal(RT_geral.RT_850_Vista[vista].Num_equip.Valor);
					if (RT_geral.RT_850_Vista[vista].Num_var.Valor < 14)
					{
						this.DataGridView_vista_variaveis_RT_850.Height = 22 + this.DataGridView_vista_variaveis_RT_850.RowTemplate.Height * RT_geral.RT_850_Vista[vista].Num_var.Valor;
						this.DataGridView_vista_variaveis_RT_850.Width = 212;
						this.DataGridView_vista_variaveis_RT_850.ScrollBars = (System.Windows.Forms.ScrollBars)0;
					}
					else
					{
						this.DataGridView_vista_variaveis_RT_850.Width = 229;
						this.DataGridView_vista_variaveis_RT_850.ScrollBars = (System.Windows.Forms.ScrollBars)2;
					}
					if (RT_geral.RT_850_Vista[vista].Num_equip.Valor < 14)
					{
						this.DataGridView_vista_equipamentos_RT_850.Height = 22 + this.DataGridView_vista_equipamentos_RT_850.RowTemplate.Height * RT_geral.RT_850_Vista[vista].Num_equip.Valor;
						this.DataGridView_vista_equipamentos_RT_850.Width = 212;
						this.DataGridView_vista_equipamentos_RT_850.ScrollBars = (System.Windows.Forms.ScrollBars)0;
					}
					else
					{
						this.DataGridView_vista_equipamentos_RT_850.Width = 229;
						this.DataGridView_vista_equipamentos_RT_850.ScrollBars = (System.Windows.Forms.ScrollBars)2;
					}
					this.GeraDataGridView_Variaveis_Vista_RT_850();
					this.Atualiza_DataGridView_Variaveis_Vista_RT_850();
					this.GeraDataGridView_Equipamentos_Vista_RT_850();
					this.Atualiza_DataGridView_Equipamentos_Vista_RT_850();
				}
			}
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x002E1614 File Offset: 0x002DFA14
		public void Atualiza_Linha_Variaveis(int linha)
		{
			checked
			{
				this.DataGridView_variaveis_RT850.Rows[linha - 1].Cells[0].Value = "";
				this.DataGridView_variaveis_RT850.Rows[linha - 1].Cells[1].Value = RT_geral.Variaveis_RT_850[linha - 1].Escala_ini.Valor;
				this.DataGridView_variaveis_RT850.Rows[linha - 1].Cells[2].Value = RT_geral.Variaveis_RT_850[linha - 1].Escala_fim.Valor;
				string value = RT_geral.RT_850_DataGridView_variaveis[3].LinhasMenu[RT_geral.Variaveis_RT_850[linha - 1].Escala_tratamento.Indice];
				this.DataGridView_variaveis_RT850.Rows[linha - 1].Cells[3].Value = value;
				value = RT_geral.RT_850_DataGridView_variaveis[4].LinhasMenu[RT_geral.Variaveis_RT_850[linha - 1].Pto_dec_fim.Indice];
				this.DataGridView_variaveis_RT850.Rows[linha - 1].Cells[4].Value = value;
				this.DataGridView_variaveis_RT850.Rows[linha - 1].Cells[5].Value = RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_1.Valor;
				value = RT_geral.RT_850_DataGridView_variaveis[6].LinhasMenu[RT_geral.Variaveis_RT_850[linha - 1].Tipo_alm_1.Indice];
				this.DataGridView_variaveis_RT850.Rows[linha - 1].Cells[6].Value = value;
				value = RT_geral.RT_850_DataGridView_variaveis[7].LinhasMenu[RT_geral.Variaveis_RT_850[linha - 1].Msg_alm_1.Indice];
				this.DataGridView_variaveis_RT850.Rows[linha - 1].Cells[7].Value = value;
				this.DataGridView_variaveis_RT850.Rows[linha - 1].Cells[8].Value = RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_2.Valor;
				value = RT_geral.RT_850_DataGridView_variaveis[9].LinhasMenu[RT_geral.Variaveis_RT_850[linha - 1].Tipo_alm_2.Indice];
				this.DataGridView_variaveis_RT850.Rows[linha - 1].Cells[9].Value = value;
				value = RT_geral.RT_850_DataGridView_variaveis[10].LinhasMenu[RT_geral.Variaveis_RT_850[linha - 1].Msg_alm_2.Indice];
				this.DataGridView_variaveis_RT850.Rows[linha - 1].Cells[10].Value = value;
				this.DataGridView_variaveis_RT850.Rows[linha - 1].Cells[11].Value = RT_geral.Variaveis_RT_850[linha - 1].Dsp_tela.Valor;
				value = RT_geral.RT_850_DataGridView_variaveis[12].LinhasMenu[RT_geral.Variaveis_RT_850[linha - 1].Dsp_pos.Indice];
				this.DataGridView_variaveis_RT850.Rows[linha - 1].Cells[12].Value = value;
			}
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x002E19A8 File Offset: 0x002DFDA8
		public void AtualizaMsgTela_RT850(string texto, int cor)
		{
			this.ToolStripTextBox_RT850_Msg.Text = texto;
			if (cor == 0)
			{
				this.ToolStripTextBox_RT850_Msg.ForeColor = Color.Blue;
			}
			else if (cor == 1)
			{
				this.ToolStripProgressBar_RT850.Value = 0;
				this.ToolStripTextBox_RT850_Msg.ForeColor = Color.Red;
			}
			else
			{
				this.ToolStripTextBox_RT850_Msg.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x002E1A0C File Offset: 0x002DFE0C
		private void CarregaComboBoxBaudRate(ref ComboBox dado)
		{
			dado.Items.Clear();
			try
			{
				foreach (perifericos.Valores_ComboBox valores_ComboBox in perifericos.ListaBaudRate)
				{
					dado.Items.Add(valores_ComboBox.nome);
				}
			}
			finally
			{
				List<perifericos.Valores_ComboBox>.Enumerator enumerator;
				enumerator.Dispose();
			}
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x002E1A78 File Offset: 0x002DFE78
		private void CarregaComboBoxFlagRemota()
		{
			this.cb_remota.Items.Clear();
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_850_BD.Flag_Remota.Numero_itens - 1;
				for (int i = num; i <= num2; i++)
				{
					this.cb_remota.Items.Add(RT_geral.RT_850_BD.Flag_Remota.itens[i]);
				}
			}
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x002E1AD8 File Offset: 0x002DFED8
		private void CarregaComboBoxFlagSupervisorio()
		{
			this.cb_supervisorio.Items.Clear();
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_850_BD.Flag_Supervisorio.Numero_itens - 1;
				for (int i = num; i <= num2; i++)
				{
					this.cb_supervisorio.Items.Add(RT_geral.RT_850_BD.Flag_Supervisorio.itens[i]);
				}
			}
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x002E1B38 File Offset: 0x002DFF38
		private void CarregaComboBoxVista_Selecao(ref ComboBox dado)
		{
			dado.Items.Clear();
			dado.Items.Add("Vista não definido");
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x002E1B58 File Offset: 0x002DFF58
		private void CarregaComboBoxVista_Selecao_Habilitados(ref ComboBox dado, int num_vista, int vista_selecionado)
		{
			dado.Items.Clear();
			checked
			{
				for (int i = 0; i <= num_vista; i++)
				{
					dado.Items.Add(RT_geral.RT_850_Vista[i].Nome.Valor);
				}
				dado.Refresh();
				dado.SelectedIndex = vista_selecionado;
			}
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x002E1BB0 File Offset: 0x002DFFB0
		private void CarregaComboBoxVista_Canal(ref ComboBox dado)
		{
			dado.Items.Clear();
			dado.Items.Add("Canal 1");
			dado.Items.Add("Canal 2");
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x002E1BE4 File Offset: 0x002DFFE4
		private void CarregaComboBoxVista_Timeout(ref ComboBox dado)
		{
			dado.Items.Clear();
			int num = 1;
			checked
			{
				do
				{
					dado.Items.Add(Conversion.Str(num));
					num++;
				}
				while (num <= 8);
			}
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x002E1C20 File Offset: 0x002E0020
		private void CarregaComboBoxVista_Prioridade(ref ComboBox dado)
		{
			dado.Items.Clear();
			dado.Items.Add("Desabilitada");
			int num = 1;
			checked
			{
				do
				{
					dado.Items.Add(Conversion.Str(num));
					num++;
				}
				while (num <= 7);
			}
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x002E1C70 File Offset: 0x002E0070
		private void CarregaComboBoxVista_Modelo(ref ComboBox dado)
		{
			RT_geral.RT_850_Modelo.nome = "Modelo do Vista Emulado";
			RT_geral.RT_850_Modelo.Indice_padrao = 0;
			RT_geral.RT_850_Modelo.Numero_itens = 3;
			RT_geral.RT_850_Modelo.valores[0] = 0;
			RT_geral.RT_850_Modelo.valores[1] = 2;
			RT_geral.RT_850_Modelo.valores[2] = 7;
			RT_geral.RT_850_Modelo.itens[0] = "Não definido";
			RT_geral.RT_850_Modelo.itens[1] = "CT 831-200";
			RT_geral.RT_850_Modelo.itens[2] = "VA 241-70";
			dado.Items.Clear();
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_850_Modelo.Numero_itens - 1;
				for (int i = num; i <= num2; i++)
				{
					dado.Items.Add(RT_geral.RT_850_Modelo.itens[i]);
				}
			}
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x002E1D3C File Offset: 0x002E013C
		private void Button_ins_var_RT850_Click(object sender, EventArgs e)
		{
			if (RT_geral.RT_850_BD.Variaveis_Numero.Valor >= 300)
			{
				return;
			}
			checked
			{
				if (this.Verifica_linha_variaveis_RT_850(RT_geral.RT_850_BD.Variaveis_Numero.Valor))
				{
					RT_geral.RT_850_BD.Variaveis_Numero.Valor = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
					this.Inicializa_Linha_Variaveis_RT_850(RT_geral.RT_850_BD.Variaveis_Numero.Valor);
					this.DataGridView_variaveis_RT850.Rows.Insert(this.DataGridView_variaveis_RT850.RowCount, new object[0]);
					this.DataGridView_variaveis_RT850.Rows[RT_geral.RT_850_BD.Variaveis_Numero.Valor - 1].HeaderCell.Value = "Variável " + Conversions.ToString(RT_geral.RT_850_BD.Variaveis_Numero.Valor);
					this.Atualiza_Linha_Variaveis(RT_geral.RT_850_BD.Variaveis_Numero.Valor);
					if (RT_geral.RT_850_BD.Variaveis_Numero.Valor < 15)
					{
						this.DataGridView_variaveis_RT850.Height = 36 + this.DataGridView_variaveis_RT850.RowTemplate.Height * RT_geral.RT_850_BD.Variaveis_Numero.Valor;
						this.DataGridView_variaveis_RT850.Width = 1130;
						this.DataGridView_variaveis_RT850.ScrollBars = (System.Windows.Forms.ScrollBars)0;
					}
					else
					{
						this.DataGridView_variaveis_RT850.Width = 1147;
						this.DataGridView_variaveis_RT850.ScrollBars = (System.Windows.Forms.ScrollBars)2;
					}
					this.DataGridView_variaveis_RT850.CurrentCell = this.DataGridView_variaveis_RT850[0, RT_geral.RT_850_BD.Variaveis_Numero.Valor - 1];
					this.DataGridView_variaveis_RT850.BeginEdit(true);
				}
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x002E1EE0 File Offset: 0x002E02E0
		private void Button_del_var_RT850_Click(object sender, EventArgs e)
		{
			checked
			{
				if (RT_geral.RT_850_BD.Variaveis_Numero.Valor > 0)
				{
					this.Inicializa_Linha_Variaveis_RT_850(RT_geral.RT_850_BD.Variaveis_Numero.Valor);
					RT_geral.Limpa_Variavel_BD_RT850(RT_geral.RT_850_BD.Variaveis_Numero.Valor);
					RT_geral.RT_850_BD.Variaveis_Numero.Valor = RT_geral.RT_850_BD.Variaveis_Numero.Valor - 1;
					this.DataGridView_variaveis_RT850.Rows.RemoveAt(this.DataGridView_variaveis_RT850.RowCount - 1);
					if (RT_geral.RT_850_BD.Variaveis_Numero.Valor < 15)
					{
						this.DataGridView_variaveis_RT850.Height = 36 + this.DataGridView_variaveis_RT850.RowTemplate.Height * RT_geral.RT_850_BD.Variaveis_Numero.Valor;
						this.DataGridView_variaveis_RT850.Width = 1130;
						this.DataGridView_variaveis_RT850.ScrollBars = (System.Windows.Forms.ScrollBars)0;
					}
					else
					{
						this.DataGridView_variaveis_RT850.Width = 1147;
						this.DataGridView_variaveis_RT850.ScrollBars = (System.Windows.Forms.ScrollBars)2;
					}
				}
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x002E1FE4 File Offset: 0x002E03E4
		private void RT_850_conf_FormClosed(object sender, FormClosedEventArgs e)
		{
			int num = 0;
			int num2 = 0;
			object obj = null;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				RT_geral.RT_850_BD.Nome_Arquivo = "";
				ComboBox comboBox = this.ComboBox_baudrate_1_RT850;
				this.CarregaComboBoxBaudRate(ref comboBox);
				this.ComboBox_baudrate_1_RT850 = comboBox;
				comboBox = this.ComboBox_baudrate_2_RT850;
				this.CarregaComboBoxBaudRate(ref comboBox);
				this.ComboBox_baudrate_2_RT850 = comboBox;
				comboBox = this.ComboBox_porta_vista_RT_850;
				this.CarregaComboBoxVista_Canal(ref comboBox);
				this.ComboBox_porta_vista_RT_850 = comboBox;
				comboBox = this.ComboBox_prioridade_vista_RT_850;
				this.CarregaComboBoxVista_Prioridade(ref comboBox);
				this.ComboBox_prioridade_vista_RT_850 = comboBox;
				comboBox = this.ComboBox_timeout_vista_RT_850;
				this.CarregaComboBoxVista_Timeout(ref comboBox);
				this.ComboBox_timeout_vista_RT_850 = comboBox;
				comboBox = this.ComboBox_modelo_vista_RT_850;
				this.CarregaComboBoxVista_Modelo(ref comboBox);
				this.ComboBox_modelo_vista_RT_850 = comboBox;
				this.Inicializa_DadosEStruturaRT850_Padrao();
				this.Inicializa_DadosEStruturaRT850_Default();
				RT_geral.Telas_RT_850.Configuracao = false;
				IL_B3:
				goto IL_F6;
				IL_B5:
				num2 = -1;
								IL_C9:;
			}
			catch (Exception) { }
			throw ProjectData.CreateProjectError(-2146828237);
			IL_F6:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x002E2100 File Offset: 0x002E0500
		private void CarregaComboBoxVariaveis(ref ComboBox dado)
		{
			dado.Items.Clear();
			dado.Items.Add("1200 bauds");
			dado.Items.Add("9600 bauds");
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x002E2134 File Offset: 0x002E0534
		private void DataGridView_variaveis_RT850_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_variaveis_RT850.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_Nome", false) == 0)
			{
				string valor = Conversions.ToString(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				RT_geral.Variaveis_RT_850[e.RowIndex].Nome.Valor = valor;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Escala_ini", false) == 0)
			{
				RT_geral.Variaveis_RT_850[e.RowIndex].Escala_ini.Valor = Conversions.ToInteger(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.Variaveis_RT_850[e.RowIndex].Escala_ini, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Escala_fim", false) == 0)
			{
				RT_geral.Variaveis_RT_850[e.RowIndex].Escala_fim.Valor = Conversions.ToInteger(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.Variaveis_RT_850[e.RowIndex].Escala_fim, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Alarme_1", false) == 0)
			{
				RT_geral.Variaveis_RT_850[e.RowIndex].Nivel_alm_1.Valor = Conversions.ToInteger(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				RT_geral.Integer_ictel integer_ictel;
				integer_ictel.nome = "Alarme 1";
				integer_ictel.Lmte_inf = RT_geral.Variaveis_RT_850[e.RowIndex].Escala_ini.Valor;
				integer_ictel.Lmte_sup = RT_geral.Variaveis_RT_850[e.RowIndex].Escala_fim.Valor;
				integer_ictel.Valor = RT_geral.Variaveis_RT_850[e.RowIndex].Nivel_alm_1.Valor;
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref integer_ictel, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Alarme_2", false) == 0)
			{
				RT_geral.Variaveis_RT_850[e.RowIndex].Nivel_alm_2.Valor = Conversions.ToInteger(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				RT_geral.Integer_ictel integer_ictel;
				integer_ictel.nome = "Alarme 2";
				integer_ictel.Lmte_inf = RT_geral.Variaveis_RT_850[e.RowIndex].Escala_ini.Valor;
				integer_ictel.Lmte_sup = RT_geral.Variaveis_RT_850[e.RowIndex].Escala_fim.Valor;
				integer_ictel.Valor = RT_geral.Variaveis_RT_850[e.RowIndex].Nivel_alm_2.Valor;
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref integer_ictel, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Num_tela", false) == 0)
			{
				RT_geral.Variaveis_RT_850[e.RowIndex].Dsp_tela.Valor = Conversions.ToInteger(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.Variaveis_RT_850[e.RowIndex].Dsp_tela, e, true);
				sender = dataGridView;
			}
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x002E2528 File Offset: 0x002E0928
		private void DataGridView_variaveis_RT850_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_variaveis_RT850.Columns[e.ColumnIndex].DataPropertyName;
			string text;
			if (Operators.CompareString(dataPropertyName, "Col_Pto_ini", false) != 0)
			{
				if (Operators.CompareString(dataPropertyName, "Col_Pto_fim", false) != 0)
				{
					if (Operators.CompareString(dataPropertyName, "Col_Tipo_Alarme_1", false) != 0)
					{
						if (Operators.CompareString(dataPropertyName, "Col_Msg_Alarme_1", false) != 0)
						{
							if (Operators.CompareString(dataPropertyName, "Col_Tipo_Alarme_2", false) != 0)
							{
								if (Operators.CompareString(dataPropertyName, "Col_Msg_Alarme_2", false) != 0)
								{
									if (Operators.CompareString(dataPropertyName, "Col_Pos_dsp", false) != 0)
									{
										if (Operators.CompareString(dataPropertyName, "Col_Escala_trat", false) != 0)
										{
											if (Operators.CompareString(dataPropertyName, "Col_Nome", false) == 0)
											{
												text = Conversions.ToString(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
												RT_geral.Variaveis_RT_850[e.RowIndex].Nome.Valor = text;
												return;
											}
											if (Operators.CompareString(dataPropertyName, "Col_Escala_ini", false) == 0)
											{
												this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
												RT_geral.Variaveis_RT_850[e.RowIndex].Escala_ini.Valor = Conversions.ToInteger(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
												return;
											}
											if (Operators.CompareString(dataPropertyName, "Col_Escala_fim", false) == 0)
											{
												this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
												RT_geral.Variaveis_RT_850[e.RowIndex].Escala_fim.Valor = Conversions.ToInteger(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
												return;
											}
											if (Operators.CompareString(dataPropertyName, "Col_Alarme_1", false) == 0)
											{
												this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
												RT_geral.Variaveis_RT_850[e.RowIndex].Nivel_alm_1.Valor = Conversions.ToInteger(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
												return;
											}
											if (Operators.CompareString(dataPropertyName, "Col_Alarme_2", false) == 0)
											{
												this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
												RT_geral.Variaveis_RT_850[e.RowIndex].Nivel_alm_2.Valor = Conversions.ToInteger(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
												return;
											}
											if (Operators.CompareString(dataPropertyName, "Col_Num_tela", false) == 0)
											{
												this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
												RT_geral.Variaveis_RT_850[e.RowIndex].Dsp_tela.Valor = Conversions.ToInteger(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
												return;
											}
											return;
										}
									}
								}
							}
						}
					}
				}
			}
			text = Conversions.ToString(this.DataGridView_variaveis_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_850_DataGridView_variaveis[e.ColumnIndex].NumeroLinhaMenu - 1;
				int i = num;
				while (i <= num2)
				{
					if (Operators.CompareString(RT_geral.RT_850_DataGridView_variaveis[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
					{
						string dataPropertyName2 = this.DataGridView_variaveis_RT850.Columns[e.ColumnIndex].DataPropertyName;
						if (Operators.CompareString(dataPropertyName2, "Col_Escala_trat", false) == 0)
						{
							RT_geral.Variaveis_RT_850[e.RowIndex].Escala_tratamento.Valor = RT_geral.RT_850_DataGridView_variaveis[e.ColumnIndex].LinhasValor[i];
							RT_geral.Variaveis_RT_850[e.RowIndex].Escala_tratamento.Indice = i;
							RT_geral.Variaveis_RT_850[e.RowIndex].Escala_tratamento.Valor = i;
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Pto_fim", false) == 0)
						{
							RT_geral.Variaveis_RT_850[e.RowIndex].Pto_dec_fim.Valor = RT_geral.RT_850_DataGridView_variaveis[e.ColumnIndex].LinhasValor[i];
							RT_geral.Variaveis_RT_850[e.RowIndex].Pto_dec_fim.Indice = i;
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Tipo_Alarme_1", false) == 0)
						{
							RT_geral.Variaveis_RT_850[e.RowIndex].Tipo_alm_1.Valor = RT_geral.RT_850_DataGridView_variaveis[e.ColumnIndex].LinhasValor[i];
							RT_geral.Variaveis_RT_850[e.RowIndex].Tipo_alm_1.Indice = i;
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Msg_Alarme_1", false) == 0)
						{
							RT_geral.Variaveis_RT_850[e.RowIndex].Msg_alm_1.Valor = RT_geral.RT_850_DataGridView_variaveis[e.ColumnIndex].LinhasValor[i];
							RT_geral.Variaveis_RT_850[e.RowIndex].Msg_alm_1.Indice = i;
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Tipo_Alarme_1", false) == 0)
						{
							RT_geral.Variaveis_RT_850[e.RowIndex].Tipo_alm_1.Valor = RT_geral.RT_850_DataGridView_variaveis[e.ColumnIndex].LinhasValor[i];
							RT_geral.Variaveis_RT_850[e.RowIndex].Tipo_alm_1.Indice = i;
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Tipo_Alarme_2", false) == 0)
						{
							RT_geral.Variaveis_RT_850[e.RowIndex].Tipo_alm_2.Valor = RT_geral.RT_850_DataGridView_variaveis[e.ColumnIndex].LinhasValor[i];
							RT_geral.Variaveis_RT_850[e.RowIndex].Tipo_alm_2.Indice = i;
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Msg_Alarme_2", false) == 0)
						{
							RT_geral.Variaveis_RT_850[e.RowIndex].Msg_alm_2.Valor = RT_geral.RT_850_DataGridView_variaveis[e.ColumnIndex].LinhasValor[i];
							RT_geral.Variaveis_RT_850[e.RowIndex].Msg_alm_2.Indice = i;
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Pos_dsp", false) == 0)
						{
							RT_geral.Variaveis_RT_850[e.RowIndex].Dsp_pos.Valor = RT_geral.RT_850_DataGridView_variaveis[e.ColumnIndex].LinhasValor[i];
							RT_geral.Variaveis_RT_850[e.RowIndex].Dsp_pos.Indice = i;
							break;
						}
						break;
					}
					else
					{
						i++;
					}
				}
			}
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x002E2DF0 File Offset: 0x002E11F0
		private void DataGridView_variaveis_RT850_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			if (this.DataGridView_variaveis_RT850.IsCurrentCellDirty)
			{
				this.DataGridView_variaveis_RT850.CommitEdit(512);
			}
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x002E2E20 File Offset: 0x002E1220
		private void DataGridView_equip_1_RT850_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_equip_1_RT850.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_Quantidade", false) == 0)
			{
				switch (e.RowIndex)
				{
				case 0:
				{
					RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor = Conversions.ToInteger(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_BD.Numero_equip_tipo_1, e, true);
					sender = dataGridView;
					if (!RT_geral.RT_850_BD.Numero_equip_tipo_1.erro)
					{
						RT_geral.Inicializa_Estrutura_Equip_Tipo_1(RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor);
					}
					break;
				}
				case 1:
				{
					RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor = Conversions.ToInteger(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_BD.Numero_equip_tipo_2, e, true);
					sender = dataGridView;
					if (!RT_geral.RT_850_BD.Numero_equip_tipo_2.erro)
					{
						RT_geral.Inicializa_Estrutura_Equip_Tipo_2(RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor);
					}
					break;
				}
				case 2:
				{
					RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor = Conversions.ToInteger(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_BD.Numero_equip_tipo_3, e, true);
					sender = dataGridView;
					if (!RT_geral.RT_850_BD.Numero_equip_tipo_3.erro)
					{
						RT_geral.Inicializa_Estrutura_Equip_Tipo_3(RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor);
					}
					break;
				}
				case 3:
				{
					RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor = Conversions.ToInteger(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_BD.Numero_equip_tipo_vista, e, true);
					sender = dataGridView;
					if (RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor != 0)
					{
						RT_geral.RT_850_BD.Vista_selecionado.Indice = 1;
					}
					else
					{
						RT_geral.RT_850_BD.Vista_selecionado.Indice = 0;
					}
					break;
				}
				}
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Endereco", false) == 0)
			{
				switch (e.RowIndex)
				{
				case 0:
				{
					RT_geral.RT_850_BD.End_inicial_equip_tipo_1.Valor = Conversions.ToInteger(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_BD.End_inicial_equip_tipo_1, e, true);
					sender = dataGridView;
					break;
				}
				case 1:
				{
					RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Valor = Conversions.ToInteger(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_BD.End_inicial_equip_tipo_2, e, true);
					sender = dataGridView;
					break;
				}
				case 2:
				{
					RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Valor = Conversions.ToInteger(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_BD.End_inicial_equip_tipo_3, e, true);
					sender = dataGridView;
					break;
				}
				case 3:
				{
					RT_geral.RT_850_BD.End_inicial_equip_tipo_vista.Valor = Conversions.ToInteger(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_BD.End_inicial_equip_tipo_vista, e, true);
					sender = dataGridView;
					break;
				}
				}
			}
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x002E3264 File Offset: 0x002E1664
		private void DataGridView_equip_1_RT850_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_equip_1_RT850.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_Quantidade", false) == 0)
			{
				switch (e.RowIndex)
				{
				case 0:
					this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
					RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor = Conversions.ToInteger(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					break;
				case 1:
					this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
					RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor = Conversions.ToInteger(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					break;
				case 2:
					this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
					RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor = Conversions.ToInteger(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					break;
				case 3:
					this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
					RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor = Conversions.ToInteger(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					break;
				}
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Endereco", false) == 0)
			{
				switch (e.RowIndex)
				{
				case 0:
					this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
					RT_geral.RT_850_BD.End_inicial_equip_tipo_1.Valor = Conversions.ToInteger(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					break;
				case 1:
					this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
					RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Valor = Conversions.ToInteger(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					break;
				case 2:
					this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
					RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Valor = Conversions.ToInteger(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					break;
				case 3:
					this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
					RT_geral.RT_850_BD.End_inicial_equip_tipo_vista.Valor = Conversions.ToInteger(this.DataGridView_equip_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					break;
				}
			}
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x002E3840 File Offset: 0x002E1C40
		private void DataGridView_equip_1_RT850_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_equip_1_RT850.IsCurrentCellDirty)
			{
				this.DataGridView_equip_1_RT850.CommitEdit(512);
			}
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x002E3860 File Offset: 0x002E1C60
		private void DataGridView_Ctrl_1_RT850_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_Ctrl_1_RT850.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_Nome", false) == 0)
			{
				RT_geral.RT_850_Ctrl_1[e.RowIndex].Nome.Valor = Conversions.ToString(this.DataGridView_Ctrl_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_comprimento_string(ref dataGridView, ref RT_geral.RT_850_Ctrl_1[e.RowIndex].Nome, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Ctrl1_num", false) == 0)
			{
				RT_geral.RT_850_Ctrl_1[e.RowIndex].Crtl_indice[0].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_Ctrl_1[e.RowIndex].Crtl_indice[0], e, true);
				sender = dataGridView;
			}
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x002E39AC File Offset: 0x002E1DAC
		private void DataGridView_Ctrl_1_RT850_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_Ctrl_1_RT850.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_Canal", false) != 0)
			{
				if (Operators.CompareString(dataPropertyName, "Col_Timeout", false) != 0)
				{
					if (Operators.CompareString(dataPropertyName, "Col_Comando", false) != 0)
					{
						if (Operators.CompareString(dataPropertyName, "Col_Prioridade", false) != 0)
						{
							if (Operators.CompareString(dataPropertyName, "Col_Modelo", false) != 0)
							{
								if (Operators.CompareString(dataPropertyName, "Col_Var_1", false) != 0)
								{
									if (Operators.CompareString(dataPropertyName, "Col_Var_2", false) != 0)
									{
										if (Operators.CompareString(dataPropertyName, "Col_Var_3", false) != 0)
										{
											if (Operators.CompareString(dataPropertyName, "Col_Var_4", false) != 0)
											{
												if (Operators.CompareString(dataPropertyName, "Col_Ref_1", false) != 0)
												{
													if (Operators.CompareString(dataPropertyName, "Col_Ref_2", false) != 0)
													{
														if (Operators.CompareString(dataPropertyName, "Col_Ref_3", false) != 0)
														{
															if (Operators.CompareString(dataPropertyName, "Col_Ref_4", false) != 0)
															{
																if (Operators.CompareString(dataPropertyName, "Col_Ctr1_msg", false) != 0)
																{
																	if (Operators.CompareString(dataPropertyName, "Col_Ctrl1_num", false) != 0)
																	{
																		if (Operators.CompareString(dataPropertyName, "Col_Nome", false) == 0)
																		{
																			RT_geral.RT_850_Ctrl_1[e.RowIndex].Nome.Valor = Conversions.ToString(this.DataGridView_Ctrl_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
																			return;
																		}
																		if (Operators.CompareString(dataPropertyName, "Col_Ctrl1_num", false) == 0)
																		{
																			RT_geral.RT_850_Ctrl_1[e.RowIndex].Crtl_indice[0].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
																			return;
																		}
																		return;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			string text = Conversions.ToString(this.DataGridView_Ctrl_1_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_850_DataGridView_ctrl_1[e.ColumnIndex].NumeroLinhaMenu - 1;
				int i = num;
				while (i <= num2)
				{
					if (Operators.CompareString(RT_geral.RT_850_DataGridView_ctrl_1[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
					{
						string dataPropertyName2 = this.DataGridView_Ctrl_1_RT850.Columns[e.ColumnIndex].DataPropertyName;
						if (Operators.CompareString(dataPropertyName2, "Col_Canal", false) == 0)
						{
							RT_geral.RT_850_Ctrl_1[e.RowIndex].Canal.Indice = RT_geral.RT_850_DataGridView_ctrl_1[e.ColumnIndex].LinhasValor[i];
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Timeout", false) == 0)
						{
							RT_geral.RT_850_Ctrl_1[e.RowIndex].Timeout.Indice = RT_geral.RT_850_DataGridView_ctrl_1[e.ColumnIndex].LinhasValor[i];
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Comando", false) == 0)
						{
							RT_geral.RT_850_Ctrl_1[e.RowIndex].Comando.Indice = RT_geral.RT_850_DataGridView_ctrl_1[e.ColumnIndex].LinhasValor[i];
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Prioridade", false) == 0)
						{
							RT_geral.RT_850_Ctrl_1[e.RowIndex].Prioridade.Indice = RT_geral.RT_850_DataGridView_ctrl_1[e.ColumnIndex].LinhasValor[i];
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Modelo", false) == 0)
						{
							RT_geral.RT_850_Ctrl_1[e.RowIndex].Modelo.Indice = RT_geral.RT_850_DataGridView_ctrl_1[e.ColumnIndex].LinhasValor[i];
							break;
						}
						int num3 = 0;
						if (Operators.CompareString(dataPropertyName2, "Col_Var_1", false) != 0)
						{
							if (Operators.CompareString(dataPropertyName2, "Col_Var_2", false) != 0)
							{
								if (Operators.CompareString(dataPropertyName2, "Col_Var_3", false) != 0)
								{
									if (Operators.CompareString(dataPropertyName2, "Col_Var_4", false) != 0)
									{
										if (Operators.CompareString(dataPropertyName2, "Col_Ref_1", false) != 0)
										{
											if (Operators.CompareString(dataPropertyName2, "Col_Ref_2", false) != 0)
											{
												if (Operators.CompareString(dataPropertyName2, "Col_Ref_3", false) != 0)
												{
													if (Operators.CompareString(dataPropertyName2, "Col_Ref_4", false) != 0)
													{
														if (Operators.CompareString(dataPropertyName2, "Col_Ctr1_msg", false) == 0)
														{
															RT_geral.RT_850_Ctrl_1[e.RowIndex].Crtl_nome[0].Indice = RT_geral.RT_850_DataGridView_ctrl_1[e.ColumnIndex].LinhasValor[i];
															break;
														}
														break;
													}
												}
											}
										}
										text = Strings.Right(this.DataGridView_Ctrl_1_RT850.Columns[e.ColumnIndex].DataPropertyName, 1);
										num3 = (int)Math.Round(unchecked(Conversion.Val(text) - 1.0));
										RT_geral.RT_850_Ctrl_1[e.RowIndex].Ref[num3].Indice = RT_geral.RT_850_DataGridView_ctrl_1[e.ColumnIndex].LinhasValor[i];
										break;
									}
								}
							}
						}
						text = Strings.Right(this.DataGridView_Ctrl_1_RT850.Columns[e.ColumnIndex].DataPropertyName, 1);
						num3 = (int)Math.Round(unchecked(Conversion.Val(text) - 1.0));
						RT_geral.RT_850_Ctrl_1[e.RowIndex].Var[num3].Indice = RT_geral.RT_850_DataGridView_ctrl_1[e.ColumnIndex].LinhasValor[i];
						break;
					}
					else
					{
						i++;
					}
				}
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x002E3F7C File Offset: 0x002E237C
		private void DataGridView_Ctrl_1_RT850_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			if (this.DataGridView_Ctrl_1_RT850.IsCurrentCellDirty)
			{
				this.DataGridView_Ctrl_1_RT850.CommitEdit(512);
			}
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x002E3FAC File Offset: 0x002E23AC
		private void DataGridView_Ctrl_4_RT850_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_Ctrl_4_RT850.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_Nome", false) == 0)
			{
				RT_geral.RT_850_Ctrl_4[e.RowIndex].Nome.Valor = Conversions.ToString(this.DataGridView_Ctrl_4_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_comprimento_string(ref dataGridView, ref RT_geral.RT_850_Ctrl_4[e.RowIndex].Nome, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Ctrl1_num", false) == 0)
			{
				RT_geral.RT_850_Ctrl_4[e.RowIndex].Crtl_indice[0].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_4_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_Ctrl_4[e.RowIndex].Crtl_indice[0], e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Ctrl2_num", false) == 0)
			{
				RT_geral.RT_850_Ctrl_4[e.RowIndex].Crtl_indice[1].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_4_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_Ctrl_4[e.RowIndex].Crtl_indice[1], e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Ctrl3_num", false) == 0)
			{
				RT_geral.RT_850_Ctrl_4[e.RowIndex].Crtl_indice[2].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_4_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_Ctrl_4[e.RowIndex].Crtl_indice[2], e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Ctrl4_num", false) == 0)
			{
				RT_geral.RT_850_Ctrl_4[e.RowIndex].Crtl_indice[3].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_4_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_Ctrl_4[e.RowIndex].Crtl_indice[3], e, true);
				sender = dataGridView;
			}
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x002E42BC File Offset: 0x002E26BC
		private void DataGridView_Ctrl_4_RT850_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_Ctrl_4_RT850.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_Canal", false) != 0)
			{
				if (Operators.CompareString(dataPropertyName, "Col_Timeout", false) != 0)
				{
					if (Operators.CompareString(dataPropertyName, "Col_Comando", false) != 0)
					{
						if (Operators.CompareString(dataPropertyName, "Col_Prioridade", false) != 0)
						{
							if (Operators.CompareString(dataPropertyName, "Col_Modelo", false) != 0)
							{
								if (Operators.CompareString(dataPropertyName, "Col_Var_1", false) != 0)
								{
									if (Operators.CompareString(dataPropertyName, "Col_Var_2", false) != 0)
									{
										if (Operators.CompareString(dataPropertyName, "Col_Var_3", false) != 0)
										{
											if (Operators.CompareString(dataPropertyName, "Col_Var_4", false) != 0)
											{
												if (Operators.CompareString(dataPropertyName, "Col_Ref_1", false) != 0)
												{
													if (Operators.CompareString(dataPropertyName, "Col_Ref_2", false) != 0)
													{
														if (Operators.CompareString(dataPropertyName, "Col_Ref_3", false) != 0)
														{
															if (Operators.CompareString(dataPropertyName, "Col_Ref_4", false) != 0)
															{
																if (Operators.CompareString(dataPropertyName, "Col_Ctr1_msg", false) != 0)
																{
																	if (Operators.CompareString(dataPropertyName, "Col_Ctrl1_num", false) != 0)
																	{
																		if (Operators.CompareString(dataPropertyName, "Col_Ctr2_msg", false) != 0)
																		{
																			if (Operators.CompareString(dataPropertyName, "Col_Ctrl2_num", false) != 0)
																			{
																				if (Operators.CompareString(dataPropertyName, "Col_Ctr3_msg", false) != 0)
																				{
																					if (Operators.CompareString(dataPropertyName, "Col_Ctrl3_num", false) != 0)
																					{
																						if (Operators.CompareString(dataPropertyName, "Col_Ctr4_msg", false) != 0)
																						{
																							if (Operators.CompareString(dataPropertyName, "Col_Ctrl4_num", false) != 0)
																							{
																								if (Operators.CompareString(dataPropertyName, "Col_Per_1", false) != 0)
																								{
																									if (Operators.CompareString(dataPropertyName, "Col_Per_2", false) != 0)
																									{
																										if (Operators.CompareString(dataPropertyName, "Col_Per_3", false) != 0)
																										{
																											if (Operators.CompareString(dataPropertyName, "Col_Per_4", false) != 0)
																											{
																												if (Operators.CompareString(dataPropertyName, "Col_Per_5", false) != 0)
																												{
																													if (Operators.CompareString(dataPropertyName, "Col_Loc_1", false) != 0)
																													{
																														if (Operators.CompareString(dataPropertyName, "Col_Loc_2", false) != 0)
																														{
																															if (Operators.CompareString(dataPropertyName, "Col_Loc_3", false) != 0)
																															{
																																if (Operators.CompareString(dataPropertyName, "Col_Loc_4", false) != 0)
																																{
																																	if (Operators.CompareString(dataPropertyName, "Col_Loc_5", false) != 0)
																																	{
																																		if (Operators.CompareString(dataPropertyName, "Col_Nome", false) == 0)
																																		{
																																			RT_geral.RT_850_Ctrl_4[e.RowIndex].Nome.Valor = Conversions.ToString(this.DataGridView_Ctrl_4_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
																																			return;
																																		}
																																		if (Operators.CompareString(dataPropertyName, "Col_Ctrl1_num", false) == 0)
																																		{
																																			RT_geral.RT_850_Ctrl_4[e.RowIndex].Crtl_indice[0].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_4_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
																																			return;
																																		}
																																		if (Operators.CompareString(dataPropertyName, "Col_Ctrl2_num", false) == 0)
																																		{
																																			RT_geral.RT_850_Ctrl_4[e.RowIndex].Crtl_indice[1].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_4_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
																																			return;
																																		}
																																		if (Operators.CompareString(dataPropertyName, "Col_Ctrl3_num", false) == 0)
																																		{
																																			RT_geral.RT_850_Ctrl_4[e.RowIndex].Crtl_indice[2].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_4_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
																																			return;
																																		}
																																		if (Operators.CompareString(dataPropertyName, "Col_Ctrl4_num", false) == 0)
																																		{
																																			RT_geral.RT_850_Ctrl_4[e.RowIndex].Crtl_indice[3].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_4_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
																																			return;
																																		}
																																		return;
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			string text = Conversions.ToString(this.DataGridView_Ctrl_4_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_850_DataGridView_ctrl_4[e.ColumnIndex].NumeroLinhaMenu - 1;
				int i = num;
				while (i <= num2)
				{
					if (Operators.CompareString(RT_geral.RT_850_DataGridView_ctrl_4[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
					{
						string dataPropertyName2 = this.DataGridView_Ctrl_4_RT850.Columns[e.ColumnIndex].DataPropertyName;
						if (Operators.CompareString(dataPropertyName2, "Col_Canal", false) == 0)
						{
							RT_geral.RT_850_Ctrl_4[e.RowIndex].Canal.Indice = RT_geral.RT_850_DataGridView_ctrl_4[e.ColumnIndex].LinhasValor[i];
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Timeout", false) == 0)
						{
							RT_geral.RT_850_Ctrl_4[e.RowIndex].Timeout.Indice = RT_geral.RT_850_DataGridView_ctrl_4[e.ColumnIndex].LinhasValor[i];
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Comando", false) == 0)
						{
							RT_geral.RT_850_Ctrl_4[e.RowIndex].Comando.Indice = RT_geral.RT_850_DataGridView_ctrl_4[e.ColumnIndex].LinhasValor[i];
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Prioridade", false) == 0)
						{
							RT_geral.RT_850_Ctrl_4[e.RowIndex].Prioridade.Indice = RT_geral.RT_850_DataGridView_ctrl_4[e.ColumnIndex].LinhasValor[i];
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Modelo", false) == 0)
						{
							RT_geral.RT_850_Ctrl_4[e.RowIndex].Modelo.Indice = RT_geral.RT_850_DataGridView_ctrl_4[e.ColumnIndex].LinhasValor[i];
							break;
						}
						int num3 = 0;
						if (Operators.CompareString(dataPropertyName2, "Col_Var_1", false) != 0)
						{
							if (Operators.CompareString(dataPropertyName2, "Col_Var_2", false) != 0)
							{
								if (Operators.CompareString(dataPropertyName2, "Col_Var_3", false) != 0)
								{
									if (Operators.CompareString(dataPropertyName2, "Col_Var_4", false) != 0)
									{
										if (Operators.CompareString(dataPropertyName2, "Col_Ref_1", false) != 0)
										{
											if (Operators.CompareString(dataPropertyName2, "Col_Ref_2", false) != 0)
											{
												if (Operators.CompareString(dataPropertyName2, "Col_Ref_3", false) != 0)
												{
													if (Operators.CompareString(dataPropertyName2, "Col_Ref_4", false) != 0)
													{
														if (Operators.CompareString(dataPropertyName2, "Col_Per_1", false) != 0)
														{
															if (Operators.CompareString(dataPropertyName2, "Col_Per_2", false) != 0)
															{
																if (Operators.CompareString(dataPropertyName2, "Col_Per_3", false) != 0)
																{
																	if (Operators.CompareString(dataPropertyName2, "Col_Per_4", false) != 0)
																	{
																		if (Operators.CompareString(dataPropertyName2, "Col_Per_5", false) != 0)
																		{
																			if (Operators.CompareString(dataPropertyName2, "Col_Loc_1", false) != 0)
																			{
																				if (Operators.CompareString(dataPropertyName2, "Col_Loc_2", false) != 0)
																				{
																					if (Operators.CompareString(dataPropertyName2, "Col_Loc_3", false) != 0)
																					{
																						if (Operators.CompareString(dataPropertyName2, "Col_Loc_4", false) != 0)
																						{
																							if (Operators.CompareString(dataPropertyName2, "Col_Loc_5", false) != 0)
																							{
																								if (Operators.CompareString(dataPropertyName2, "Col_Ctr1_msg", false) == 0)
																								{
																									RT_geral.RT_850_Ctrl_4[e.RowIndex].Crtl_nome[0].Indice = RT_geral.RT_850_DataGridView_ctrl_4[e.ColumnIndex].LinhasValor[i];
																									break;
																								}
																								if (Operators.CompareString(dataPropertyName2, "Col_Ctr2_msg", false) == 0)
																								{
																									RT_geral.RT_850_Ctrl_4[e.RowIndex].Crtl_nome[1].Indice = RT_geral.RT_850_DataGridView_ctrl_4[e.ColumnIndex].LinhasValor[i];
																									break;
																								}
																								if (Operators.CompareString(dataPropertyName2, "Col_Ctr3_msg", false) == 0)
																								{
																									RT_geral.RT_850_Ctrl_4[e.RowIndex].Crtl_nome[2].Indice = RT_geral.RT_850_DataGridView_ctrl_4[e.ColumnIndex].LinhasValor[i];
																									break;
																								}
																								if (Operators.CompareString(dataPropertyName2, "Col_Ctr4_msg", false) == 0)
																								{
																									RT_geral.RT_850_Ctrl_4[e.RowIndex].Crtl_nome[3].Indice = RT_geral.RT_850_DataGridView_ctrl_4[e.ColumnIndex].LinhasValor[i];
																									break;
																								}
																								break;
																							}
																						}
																					}
																				}
																			}
																			text = Strings.Right(this.DataGridView_Ctrl_4_RT850.Columns[e.ColumnIndex].DataPropertyName, 1);
																			num3 = (int)Math.Round(unchecked(Conversion.Val(text) - 1.0));
																			RT_geral.RT_850_Ctrl_4[e.RowIndex].Periferico_Indice[num3].Indice = RT_geral.RT_850_DataGridView_ctrl_4[e.ColumnIndex].LinhasValor[i];
																			break;
																		}
																	}
																}
															}
														}
														text = Strings.Right(this.DataGridView_Ctrl_4_RT850.Columns[e.ColumnIndex].DataPropertyName, 1);
														num3 = (int)Math.Round(unchecked(Conversion.Val(text) - 1.0));
														RT_geral.RT_850_Ctrl_4[e.RowIndex].Periferico_Modelo[num3].Indice = RT_geral.RT_850_DataGridView_ctrl_4[e.ColumnIndex].LinhasValor[i];
														break;
													}
												}
											}
										}
										text = Strings.Right(this.DataGridView_Ctrl_4_RT850.Columns[e.ColumnIndex].DataPropertyName, 1);
										num3 = (int)Math.Round(unchecked(Conversion.Val(text) - 1.0));
										RT_geral.RT_850_Ctrl_4[e.RowIndex].Ref[num3].Indice = RT_geral.RT_850_DataGridView_ctrl_4[e.ColumnIndex].LinhasValor[i];
										break;
									}
								}
							}
						}
						text = Strings.Right(this.DataGridView_Ctrl_4_RT850.Columns[e.ColumnIndex].DataPropertyName, 1);
						num3 = (int)Math.Round(unchecked(Conversion.Val(text) - 1.0));
						RT_geral.RT_850_Ctrl_4[e.RowIndex].Var[num3].Indice = RT_geral.RT_850_DataGridView_ctrl_4[e.ColumnIndex].LinhasValor[i];
						break;
					}
					else
					{
						i++;
					}
				}
			}
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x002E4D74 File Offset: 0x002E3174
		private void DataGridView_Ctrl_4_RT850_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			if (this.DataGridView_Ctrl_4_RT850.IsCurrentCellDirty)
			{
				this.DataGridView_Ctrl_4_RT850.CommitEdit(512);
			}
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x002E4DA4 File Offset: 0x002E31A4
		private void DataGridView_Ctrl_8_RT850_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_Ctrl_8_RT850.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_Nome", false) == 0)
			{
				RT_geral.RT_850_Ctrl_8[e.RowIndex].Nome.Valor = Conversions.ToString(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_comprimento_string(ref dataGridView, ref RT_geral.RT_850_Ctrl_8[e.RowIndex].Nome, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Ctrl1_num", false) == 0)
			{
				RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[0].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[0], e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Ctrl2_num", false) == 0)
			{
				RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[1].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[1], e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Ctrl3_num", false) == 0)
			{
				RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[2].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[2], e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Ctrl4_num", false) == 0)
			{
				RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[3].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[3], e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Ctrl5_num", false) == 0)
			{
				RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[4].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[4], e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Ctrl6_num", false) == 0)
			{
				RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[5].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[5], e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Ctrl7_num", false) == 0)
			{
				RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[6].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[6], e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Ctrl8_num", false) == 0)
			{
				RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[7].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[7], e, true);
				sender = dataGridView;
			}
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x002E530C File Offset: 0x002E370C
		private void DataGridView_Ctrl_8_RT850_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_Ctrl_8_RT850.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_Canal", false) != 0)
			{
				if (Operators.CompareString(dataPropertyName, "Col_Timeout", false) != 0)
				{
					if (Operators.CompareString(dataPropertyName, "Col_Comando", false) != 0)
					{
						if (Operators.CompareString(dataPropertyName, "Col_Prioridade", false) != 0)
						{
							if (Operators.CompareString(dataPropertyName, "Col_Modelo", false) != 0)
							{
								if (Operators.CompareString(dataPropertyName, "Col_Var_1", false) != 0)
								{
									if (Operators.CompareString(dataPropertyName, "Col_Var_2", false) != 0)
									{
										if (Operators.CompareString(dataPropertyName, "Col_Var_3", false) != 0)
										{
											if (Operators.CompareString(dataPropertyName, "Col_Var_4", false) != 0)
											{
												if (Operators.CompareString(dataPropertyName, "Col_Var_5", false) != 0)
												{
													if (Operators.CompareString(dataPropertyName, "Col_Var_6", false) != 0)
													{
														if (Operators.CompareString(dataPropertyName, "Col_Var_7", false) != 0)
														{
															if (Operators.CompareString(dataPropertyName, "Col_Var_8", false) != 0)
															{
																if (Operators.CompareString(dataPropertyName, "Col_Var_9", false) != 0)
																{
																	if (Operators.CompareString(dataPropertyName, "Col_Var_10", false) != 0)
																	{
																		if (Operators.CompareString(dataPropertyName, "Col_Var_11", false) != 0)
																		{
																			if (Operators.CompareString(dataPropertyName, "Col_Var_12", false) != 0)
																			{
																				if (Operators.CompareString(dataPropertyName, "Col_Var_13", false) != 0)
																				{
																					if (Operators.CompareString(dataPropertyName, "Col_Var_14", false) != 0)
																					{
																						if (Operators.CompareString(dataPropertyName, "Col_Var_15", false) != 0)
																						{
																							if (Operators.CompareString(dataPropertyName, "Col_Var_16", false) != 0)
																							{
																								if (Operators.CompareString(dataPropertyName, "Col_Ref_1", false) != 0)
																								{
																									if (Operators.CompareString(dataPropertyName, "Col_Ref_2", false) != 0)
																									{
																										if (Operators.CompareString(dataPropertyName, "Col_Ref_3", false) != 0)
																										{
																											if (Operators.CompareString(dataPropertyName, "Col_Ref_4", false) != 0)
																											{
																												if (Operators.CompareString(dataPropertyName, "Col_Ctr1_msg", false) != 0)
																												{
																													if (Operators.CompareString(dataPropertyName, "Col_Ctrl1_num", false) != 0)
																													{
																														if (Operators.CompareString(dataPropertyName, "Col_Ctr2_msg", false) != 0)
																														{
																															if (Operators.CompareString(dataPropertyName, "Col_Ctrl2_num", false) != 0)
																															{
																																if (Operators.CompareString(dataPropertyName, "Col_Ctr3_msg", false) != 0)
																																{
																																	if (Operators.CompareString(dataPropertyName, "Col_Ctrl3_num", false) != 0)
																																	{
																																		if (Operators.CompareString(dataPropertyName, "Col_Ctr4_msg", false) != 0)
																																		{
																																			if (Operators.CompareString(dataPropertyName, "Col_Ctrl4_num", false) != 0)
																																			{
																																				if (Operators.CompareString(dataPropertyName, "Col_Ctr5_msg", false) != 0)
																																				{
																																					if (Operators.CompareString(dataPropertyName, "Col_Ctrl5_num", false) != 0)
																																					{
																																						if (Operators.CompareString(dataPropertyName, "Col_Ctr6_msg", false) != 0)
																																						{
																																							if (Operators.CompareString(dataPropertyName, "Col_Ctrl6_num", false) != 0)
																																							{
																																								if (Operators.CompareString(dataPropertyName, "Col_Ctr7_msg", false) != 0)
																																								{
																																									if (Operators.CompareString(dataPropertyName, "Col_Ctrl7_num", false) != 0)
																																									{
																																										if (Operators.CompareString(dataPropertyName, "Col_Ctr8_msg", false) != 0)
																																										{
																																											if (Operators.CompareString(dataPropertyName, "Col_Ctrl8_num", false) != 0)
																																											{
																																												if (Operators.CompareString(dataPropertyName, "Col_Per_1", false) != 0)
																																												{
																																													if (Operators.CompareString(dataPropertyName, "Col_Per_2", false) != 0)
																																													{
																																														if (Operators.CompareString(dataPropertyName, "Col_Per_3", false) != 0)
																																														{
																																															if (Operators.CompareString(dataPropertyName, "Col_Per_4", false) != 0)
																																															{
																																																if (Operators.CompareString(dataPropertyName, "Col_Per_5", false) != 0)
																																																{
																																																	if (Operators.CompareString(dataPropertyName, "Col_Loc_1", false) != 0)
																																																	{
																																																		if (Operators.CompareString(dataPropertyName, "Col_Loc_2", false) != 0)
																																																		{
																																																			if (Operators.CompareString(dataPropertyName, "Col_Loc_3", false) != 0)
																																																			{
																																																				if (Operators.CompareString(dataPropertyName, "Col_Loc_4", false) != 0)
																																																				{
																																																					if (Operators.CompareString(dataPropertyName, "Col_Loc_5", false) != 0)
																																																					{
																																																						if (Operators.CompareString(dataPropertyName, "Col_Nome", false) == 0)
																																																						{
																																																							RT_geral.RT_850_Ctrl_8[e.RowIndex].Nome.Valor = Conversions.ToString(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
																																																							return;
																																																						}
																																																						if (Operators.CompareString(dataPropertyName, "Col_Ctrl1_num", false) == 0)
																																																						{
																																																							RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[0].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
																																																							return;
																																																						}
																																																						if (Operators.CompareString(dataPropertyName, "Col_Ctrl2_num", false) == 0)
																																																						{
																																																							RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[1].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
																																																							return;
																																																						}
																																																						if (Operators.CompareString(dataPropertyName, "Col_Ctrl3_num", false) == 0)
																																																						{
																																																							RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[2].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
																																																							return;
																																																						}
																																																						if (Operators.CompareString(dataPropertyName, "Col_Ctrl4_num", false) == 0)
																																																						{
																																																							RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[3].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
																																																							return;
																																																						}
																																																						if (Operators.CompareString(dataPropertyName, "Col_Ctrl1_num", false) == 0)
																																																						{
																																																							RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[4].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
																																																							return;
																																																						}
																																																						if (Operators.CompareString(dataPropertyName, "Col_Ctrl2_num", false) == 0)
																																																						{
																																																							RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[5].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
																																																							return;
																																																						}
																																																						if (Operators.CompareString(dataPropertyName, "Col_Ctrl3_num", false) == 0)
																																																						{
																																																							RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[6].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
																																																							return;
																																																						}
																																																						if (Operators.CompareString(dataPropertyName, "Col_Ctrl4_num", false) == 0)
																																																						{
																																																							RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_indice[7].Valor = Conversions.ToInteger(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
																																																							return;
																																																						}
																																																						return;
																																																					}
																																																				}
																																																			}
																																																		}
																																																	}
																																																}
																																															}
																																														}
																																													}
																																												}
																																											}
																																										}
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			string text = Conversions.ToString(this.DataGridView_Ctrl_8_RT850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].NumeroLinhaMenu - 1;
				int i = num;
				while (i <= num2)
				{
					if (Operators.CompareString(RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
					{
						string dataPropertyName2 = this.DataGridView_Ctrl_8_RT850.Columns[e.ColumnIndex].DataPropertyName;
						if (Operators.CompareString(dataPropertyName2, "Col_Canal", false) == 0)
						{
							RT_geral.RT_850_Ctrl_8[e.RowIndex].Canal.Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Timeout", false) == 0)
						{
							RT_geral.RT_850_Ctrl_8[e.RowIndex].Timeout.Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Comando", false) == 0)
						{
							RT_geral.RT_850_Ctrl_8[e.RowIndex].Comando.Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Prioridade", false) == 0)
						{
							RT_geral.RT_850_Ctrl_8[e.RowIndex].Prioridade.Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_Modelo", false) == 0)
						{
							RT_geral.RT_850_Ctrl_8[e.RowIndex].Modelo.Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
							break;
						}
						int num3 = 0;
						if (Operators.CompareString(dataPropertyName2, "Col_Var_1", false) != 0)
						{
							if (Operators.CompareString(dataPropertyName2, "Col_Var_2", false) != 0)
							{
								if (Operators.CompareString(dataPropertyName2, "Col_Var_3", false) != 0)
								{
									if (Operators.CompareString(dataPropertyName2, "Col_Var_4", false) != 0)
									{
										if (Operators.CompareString(dataPropertyName2, "Col_Var_5", false) != 0)
										{
											if (Operators.CompareString(dataPropertyName2, "Col_Var_6", false) != 0)
											{
												if (Operators.CompareString(dataPropertyName2, "Col_Var_7", false) != 0)
												{
													if (Operators.CompareString(dataPropertyName2, "Col_Var_8", false) != 0)
													{
														if (Operators.CompareString(dataPropertyName2, "Col_Var_9", false) != 0)
														{
															if (Operators.CompareString(dataPropertyName2, "Col_Var_10", false) != 0)
															{
																if (Operators.CompareString(dataPropertyName2, "Col_Var_11", false) != 0)
																{
																	if (Operators.CompareString(dataPropertyName2, "Col_Var_12", false) != 0)
																	{
																		if (Operators.CompareString(dataPropertyName2, "Col_Var_13", false) != 0)
																		{
																			if (Operators.CompareString(dataPropertyName2, "Col_Var_14", false) != 0)
																			{
																				if (Operators.CompareString(dataPropertyName2, "Col_Var_15", false) != 0)
																				{
																					if (Operators.CompareString(dataPropertyName2, "Col_Var_16", false) != 0)
																					{
																						if (Operators.CompareString(dataPropertyName2, "Col_Ref_1", false) != 0)
																						{
																							if (Operators.CompareString(dataPropertyName2, "Col_Ref_2", false) != 0)
																							{
																								if (Operators.CompareString(dataPropertyName2, "Col_Ref_3", false) != 0)
																								{
																									if (Operators.CompareString(dataPropertyName2, "Col_Ref_4", false) != 0)
																									{
																										if (Operators.CompareString(dataPropertyName2, "Col_Per_1", false) != 0)
																										{
																											if (Operators.CompareString(dataPropertyName2, "Col_Per_2", false) != 0)
																											{
																												if (Operators.CompareString(dataPropertyName2, "Col_Per_3", false) != 0)
																												{
																													if (Operators.CompareString(dataPropertyName2, "Col_Per_4", false) != 0)
																													{
																														if (Operators.CompareString(dataPropertyName2, "Col_Per_5", false) != 0)
																														{
																															if (Operators.CompareString(dataPropertyName2, "Col_Loc_1", false) != 0)
																															{
																																if (Operators.CompareString(dataPropertyName2, "Col_Loc_2", false) != 0)
																																{
																																	if (Operators.CompareString(dataPropertyName2, "Col_Loc_3", false) != 0)
																																	{
																																		if (Operators.CompareString(dataPropertyName2, "Col_Loc_4", false) != 0)
																																		{
																																			if (Operators.CompareString(dataPropertyName2, "Col_Loc_5", false) != 0)
																																			{
																																				if (Operators.CompareString(dataPropertyName2, "Col_Ctr1_msg", false) == 0)
																																				{
																																					RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_nome[0].Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
																																					break;
																																				}
																																				if (Operators.CompareString(dataPropertyName2, "Col_Ctr2_msg", false) == 0)
																																				{
																																					RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_nome[1].Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
																																					break;
																																				}
																																				if (Operators.CompareString(dataPropertyName2, "Col_Ctr3_msg", false) == 0)
																																				{
																																					RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_nome[2].Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
																																					break;
																																				}
																																				if (Operators.CompareString(dataPropertyName2, "Col_Ctr4_msg", false) == 0)
																																				{
																																					RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_nome[3].Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
																																					break;
																																				}
																																				if (Operators.CompareString(dataPropertyName2, "Col_Ctr5_msg", false) == 0)
																																				{
																																					RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_nome[4].Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
																																					break;
																																				}
																																				if (Operators.CompareString(dataPropertyName2, "Col_Ctr6_msg", false) == 0)
																																				{
																																					RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_nome[5].Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
																																					break;
																																				}
																																				if (Operators.CompareString(dataPropertyName2, "Col_Ctr7_msg", false) == 0)
																																				{
																																					RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_nome[6].Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
																																					break;
																																				}
																																				if (Operators.CompareString(dataPropertyName2, "Col_Ctr8_msg", false) == 0)
																																				{
																																					RT_geral.RT_850_Ctrl_8[e.RowIndex].Crtl_nome[7].Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
																																					break;
																																				}
																																				break;
																																			}
																																		}
																																	}
																																}
																															}
																															text = Strings.Right(this.DataGridView_Ctrl_8_RT850.Columns[e.ColumnIndex].DataPropertyName, 1);
																															num3 = (int)Math.Round(unchecked(Conversion.Val(text) - 1.0));
																															RT_geral.RT_850_Ctrl_8[e.RowIndex].Periferico_Indice[num3].Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
																															break;
																														}
																													}
																												}
																											}
																										}
																										text = Strings.Right(this.DataGridView_Ctrl_8_RT850.Columns[e.ColumnIndex].DataPropertyName, 1);
																										num3 = (int)Math.Round(unchecked(Conversion.Val(text) - 1.0));
																										RT_geral.RT_850_Ctrl_8[e.RowIndex].Periferico_Modelo[num3].Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
																										break;
																									}
																								}
																							}
																						}
																						text = Strings.Right(this.DataGridView_Ctrl_8_RT850.Columns[e.ColumnIndex].DataPropertyName, 1);
																						num3 = (int)Math.Round(unchecked(Conversion.Val(text) - 1.0));
																						RT_geral.RT_850_Ctrl_8[e.RowIndex].Ref[num3].Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
																						break;
																					}
																				}
																			}
																		}
																	}
																}
															}
															text = Strings.Right(this.DataGridView_Ctrl_8_RT850.Columns[e.ColumnIndex].DataPropertyName, 2);
															num3 = (int)Math.Round(unchecked(Conversion.Val(text) - 1.0));
															RT_geral.RT_850_Ctrl_8[e.RowIndex].Var[num3].Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
															break;
														}
													}
												}
											}
										}
									}
								}
							}
						}
						text = Strings.Right(this.DataGridView_Ctrl_8_RT850.Columns[e.ColumnIndex].DataPropertyName, 1);
						num3 = (int)Math.Round(unchecked(Conversion.Val(text) - 1.0));
						RT_geral.RT_850_Ctrl_8[e.RowIndex].Var[num3].Indice = RT_geral.RT_850_DataGridView_ctrl_8[e.ColumnIndex].LinhasValor[i];
						break;
					}
					else
					{
						i++;
					}
				}
			}
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x002E6360 File Offset: 0x002E4760
		private void DataGridView_Ctrl_8_RT850_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			if (this.DataGridView_Ctrl_8_RT850.IsCurrentCellDirty)
			{
				this.DataGridView_Ctrl_8_RT850.CommitEdit(512);
			}
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x002E6390 File Offset: 0x002E4790
		private void TextBox_nome_vista_TextChanged(object sender, EventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Nome.Valor = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
				ComboBox comboBox_Seleciona_Vista_RT_ = this.ComboBox_Seleciona_Vista_RT_850;
				this.CarregaComboBoxVista_Selecao_Habilitados(ref comboBox_Seleciona_Vista_RT_, RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor, RT_geral.RT_850_BD.Vista_selecionado.Indice);
				this.ComboBox_Seleciona_Vista_RT_850 = comboBox_Seleciona_Vista_RT_;
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x002E6420 File Offset: 0x002E4820
		private void TextBox_nome_vista_Validating(object sender, CancelEventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Nome.Valor = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
			}
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x002E647C File Offset: 0x002E487C
		private void ComboBox_porta_vista_RT_850_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Canal.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x002E64D8 File Offset: 0x002E48D8
		private void ComboBox_prioridade_vista_RT_850_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Prioridade.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x002E6534 File Offset: 0x002E4934
		private void ComboBox_timeout_vista_RT_850_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Timeout.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x002E6590 File Offset: 0x002E4990
		private void ComboBox_modelo_vista_RT_850_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				int num = RT_geral.LocalizaIndiceVetor_str_indice(ref RT_geral.RT_850_Modelo, Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
				RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Modelo.Indice = RT_geral.RT_850_Modelo.valores[num];
			}
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x002E6604 File Offset: 0x002E4A04
		private void NumericUpDown_num_var_vista_ValueChanged(object sender, EventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Num_var.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
				this.InicializaEstrutura_DataGridView_Variaveis_Vista_RT_850();
				this.GeraDataGridView_Variaveis_Vista_RT_850();
				this.Atualiza_TelaRT850_DadosVista(RT_geral.RT_850_BD.Vista_selecionado.Indice);
			}
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x002E6684 File Offset: 0x002E4A84
		private void NumericUpDown_num_equip_vista_ValueChanged(object sender, EventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Num_equip.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
				this.InicializaEstrutura_DataGridView_Equipamentos_Vista_RT_850();
				this.GeraDataGridView_Equipamentos_Vista_RT_850();
				this.Atualiza_TelaRT850_DadosVista(RT_geral.RT_850_BD.Vista_selecionado.Indice);
			}
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x002E6704 File Offset: 0x002E4B04
		private void ComboBox_Seleciona_Vista_RT_850_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 0, false) && RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor > 0)
			{
				NewLateBinding.LateSet(sender, null, "SelectedIndex", new object[]
				{
					1
				}, null, null);
			}
			RT_geral.RT_850_BD.Vista_selecionado.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice == 0)
			{
				this.GroupBox_parametros_vista.Visible = false;
				this.GroupBox_variaveis.Visible = false;
				this.GroupBox_equipamentos_vista.Visible = false;
			}
			else
			{
				this.GroupBox_parametros_vista.Visible = true;
				this.GroupBox_variaveis.Visible = true;
				this.GroupBox_equipamentos_vista.Visible = true;
			}
			this.Atualiza_TelaRT850_DadosVista(RT_geral.RT_850_BD.Vista_selecionado.Indice);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x002E6800 File Offset: 0x002E4C00
		private void DataGridView_vista_variaveis_RT_850_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x002E6804 File Offset: 0x002E4C04
		private void DataGridView_vista_variaveis_RT_850_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_vista_variaveis_RT_850.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_Var", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_vista_variaveis_RT_850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_850_DataGridView_Variaveis_Vista[e.ColumnIndex].NumeroLinhaMenu - 1;
					int i = num;
					while (i <= num2)
					{
						if (Operators.CompareString(RT_geral.RT_850_DataGridView_Variaveis_Vista[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							string dataPropertyName2 = this.DataGridView_vista_variaveis_RT_850.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName2, "Col_Var", false) == 0)
							{
								if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
								{
									RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Variaveis[e.RowIndex].Indice = RT_geral.RT_850_DataGridView_Variaveis_Vista[e.ColumnIndex].LinhasValor[i];
								}
								break;
							}
							break;
						}
						else
						{
							i++;
						}
					}
				}
			}
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x002E695C File Offset: 0x002E4D5C
		private void DataGridView_vista_variaveis_RT_850_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			if (this.DataGridView_vista_variaveis_RT_850.IsCurrentCellDirty)
			{
				this.DataGridView_vista_variaveis_RT_850.CommitEdit(512);
			}
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x002E698C File Offset: 0x002E4D8C
		private void DataGridView_vista_equipamentos_RT_850_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x002E6990 File Offset: 0x002E4D90
		private void DataGridView_vista_equipamentos_RT_850_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_vista_equipamentos_RT_850.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_Equip", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_vista_equipamentos_RT_850.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_850_DataGridView_Equipamentos_Vista[e.ColumnIndex].NumeroLinhaMenu - 1;
					int i = num;
					while (i <= num2)
					{
						if (Operators.CompareString(RT_geral.RT_850_DataGridView_Equipamentos_Vista[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							string dataPropertyName2 = this.DataGridView_vista_equipamentos_RT_850.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName2, "Col_Equip", false) == 0)
							{
								if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
								{
									RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Equipamentos[e.RowIndex].Indice = RT_geral.RT_850_DataGridView_Equipamentos_Vista[e.ColumnIndex].LinhasValor[i];
								}
								break;
							}
							break;
						}
						else
						{
							i++;
						}
					}
				}
			}
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x002E6AE8 File Offset: 0x002E4EE8
		private void DataGridView_vista_equipamentos_RT_850_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			if (this.DataGridView_vista_equipamentos_RT_850.IsCurrentCellDirty)
			{
				this.DataGridView_vista_equipamentos_RT_850.CommitEdit(512);
			}
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x002E6B18 File Offset: 0x002E4F18
		private void TabControl_850_SelectedIndexChanged(object sender, EventArgs e)
		{
			string name = ((TabControl)sender).SelectedTab.Name;
			string text = name;
			checked
			{
				if (Operators.CompareString(text, "TabPage_controles", false) == 0)
				{
					this.Atualiza_canais_comunicacao();
				}
				else if (Operators.CompareString(text, "TabPage_variaveis_RT850", false) == 0)
				{
					if (RT_geral.RT_850_BD.Variaveis_Numero.Valor >= 0)
					{
						this.InicializaEstrutura_DataGridView_variaveis_RT_850();
						this.GeraDataGridView_variaveis_RT_850();
						this.Atualiza_DataGridView_Variaveis_RT850();
						if (RT_geral.RT_850_BD.Variaveis_Numero.Valor < 15)
						{
							this.DataGridView_variaveis_RT850.Height = 36 + this.DataGridView_variaveis_RT850.RowTemplate.Height * RT_geral.RT_850_BD.Variaveis_Numero.Valor;
							this.DataGridView_variaveis_RT850.Width = 1130;
							this.DataGridView_variaveis_RT850.ScrollBars = (System.Windows.Forms.ScrollBars)0;
						}
						else
						{
							this.DataGridView_variaveis_RT850.Height = 36 + 15 * this.DataGridView_variaveis_RT850.RowTemplate.Height;
							this.DataGridView_variaveis_RT850.Width = 1147;
							this.DataGridView_variaveis_RT850.ScrollBars = (System.Windows.Forms.ScrollBars)2;
						}
					}
				}
				else if (Operators.CompareString(text, "TabPage_Ctrl_1_controle", false) == 0)
				{
					if (RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor >= 0)
					{
						this.InicializaEstrutura_DataGridView_Equipamentos_CTLR_1_RT_850();
						this.GeraDataGridView_Equipamentos_CTLR_1_RT_850();
						this.Atualiza_DataGridView_Ctrl_1();
						if (RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor < 15)
						{
							this.DataGridView_Ctrl_1_RT850.Height = 41 + RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor * this.DataGridView_Ctrl_1_RT850.RowTemplate.Height;
						}
						else
						{
							this.DataGridView_Ctrl_1_RT850.Height = 41 + 15 * this.DataGridView_Ctrl_1_RT850.RowTemplate.Height;
						}
					}
				}
				else if (Operators.CompareString(text, "TabPage_Ctrl_4_controle", false) == 0)
				{
					if (RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor >= 0)
					{
						this.InicializaEstrutura_DataGridView_Equipamentos_CTLR_4_RT_850();
						this.GeraDataGridView_Equipamentos_CTLR_4_RT_850();
						this.Atualiza_DataGridView_Ctrl_4();
						if (RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor < 15)
						{
							this.DataGridView_Ctrl_4_RT850.Height = 41 + RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor * this.DataGridView_Ctrl_4_RT850.RowTemplate.Height;
						}
						else
						{
							this.DataGridView_Ctrl_4_RT850.Height = 41 + 15 * this.DataGridView_Ctrl_4_RT850.RowTemplate.Height;
						}
					}
				}
				else if (Operators.CompareString(text, "TabPage_Ctrl_8_controle", false) == 0)
				{
					if (RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor >= 0)
					{
						this.InicializaEstrutura_DataGridView_Equipamentos_CTLR_8_RT_850();
						this.GeraDataGridView_Equipamentos_CTLR_8_RT_850();
						this.Atualiza_DataGridView_Ctrl_8();
						if (RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor < 15)
						{
							this.DataGridView_Ctrl_8_RT850.Height = 41 + RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor * this.DataGridView_Ctrl_8_RT850.RowTemplate.Height;
						}
						else
						{
							this.DataGridView_Ctrl_8_RT850.Height = 41 + 15 * this.DataGridView_Ctrl_8_RT850.RowTemplate.Height;
						}
					}
				}
				else if (Operators.CompareString(text, "TabPage_Vista", false) == 0)
				{
					ComboBox comboBox_Seleciona_Vista_RT_ = this.ComboBox_Seleciona_Vista_RT_850;
					this.CarregaComboBoxVista_Selecao_Habilitados(ref comboBox_Seleciona_Vista_RT_, RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor, RT_geral.RT_850_BD.Vista_selecionado.Indice);
					this.ComboBox_Seleciona_Vista_RT_850 = comboBox_Seleciona_Vista_RT_;
					this.InicializaEstrutura_DataGridView_Variaveis_Vista_RT_850();
					this.GeraDataGridView_Variaveis_Vista_RT_850();
					this.InicializaEstrutura_DataGridView_Equipamentos_Vista_RT_850();
					this.GeraDataGridView_Equipamentos_Vista_RT_850();
					this.Atualiza_TelaRT850_DadosVista(RT_geral.RT_850_BD.Vista_selecionado.Indice);
				}
			}
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x002E6E80 File Offset: 0x002E5280
		public void ControleAtivacaoTeclas(int modo)
		{
			switch (modo)
			{
			case 1:
			case 2:
			case 4:
				this.ToolStripButton_RT850_Abrir.Enabled = false;
				this.ToolStripButton_RT850_novo.Enabled = false;
				this.ToolStripButton_RT850_Salvar.Enabled = false;
				this.ToolStripButton_RT850_Download.Enabled = false;
				this.ToolStripButton_RT850_Upload.Enabled = false;
				break;
			case 3:
				this.ToolStripButton_RT850_Abrir.Enabled = true;
				this.ToolStripButton_RT850_novo.Enabled = true;
				this.ToolStripButton_RT850_Salvar.Enabled = true;
				this.ToolStripButton_RT850_Download.Enabled = true;
				this.ToolStripButton_RT850_Upload.Enabled = true;
				break;
			}
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x002E6F24 File Offset: 0x002E5324
		public void CriaImagem_RT850(ref int[] dados)
		{
			int num = 0;
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Versao.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Build.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Release.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Equip.Valor, ref num);
			Linha_RT.ConverterStringToIntegerArray(RT_geral.RT_850_BD.Msg_linha_1.Valor, ref dados, ref num, 10);
			Linha_RT.ConverterStringToIntegerArray(RT_geral.RT_850_BD.Msg_linha_2.Valor, ref dados, ref num, 10);
			Linha_RT.ConverterStringToIntegerArray(RT_geral.RT_850_BD.Msg_linha_3.Valor, ref dados, ref num, 10);
			Linha_RT.ConverterStringToIntegerArray(RT_geral.RT_850_BD.Msg_linha_4.Valor, ref dados, ref num, 10);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.End_mestre_canal_1.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Intervalo_leitura_canal_1.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.BaudRate_canal_1.Indice, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Timeout_canal_1.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Tempo_ptt_canal_1.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Numero_tentativas_canal_1.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Numero_erros_falha_canal_1.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.End_mestre_canal_2.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Intervalo_leitura_canal_2.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.BaudRate_canal_2.Indice, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Timeout_canal_2.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Tempo_ptt_canal_2.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Numero_tentativas_canal_2.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Numero_erros_falha_canal_2.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Sincronismo.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.End_inicial_equip_tipo_1.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.End_inicial_equip_tipo_vista.Valor, ref num);
			Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_BD.Variaveis_Numero.Valor, ref num);
			int num2 = 0;
			checked
			{
				do
				{
					Linha_RT.ConverterStringToIntegerArray(RT_geral.Variaveis_RT_850[num2].Nome.Valor, ref dados, ref num, 5);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.Variaveis_RT_850[num2].Escala_ini.Valor, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.Variaveis_RT_850[num2].Escala_fim.Valor, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.Variaveis_RT_850[num2].Pto_dec_ini.Valor, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.Variaveis_RT_850[num2].Pto_dec_fim.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.Variaveis_RT_850[num2].Nivel_alm_1.Valor, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.Variaveis_RT_850[num2].Tipo_alm_1.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.Variaveis_RT_850[num2].Msg_alm_1.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.Variaveis_RT_850[num2].Nivel_alm_2.Valor, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.Variaveis_RT_850[num2].Tipo_alm_2.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.Variaveis_RT_850[num2].Msg_alm_2.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.Variaveis_RT_850[num2].Dsp_pos.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.Variaveis_RT_850[num2].Dsp_tela.Valor, ref num);
					num2++;
				}
				while (num2 <= 299);
				num2 = 0;
				do
				{
					Linha_RT.ConverterStringToIntegerArray(RT_geral.RT_850_Ctrl_1[num2].Nome.Valor, ref dados, ref num, 5);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_1[num2].Canal.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_1[num2].Timeout.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_1[num2].Comando.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_1[num2].Prioridade.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_1[num2].Modelo.Indice, ref num);
					int num3 = 0;
					do
					{
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_1[num2].Var[num3].Indice, ref num);
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_1[num2].Ref[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 3);
					num3 = 0;
					do
					{
						int item = RT_geral.RT_850_Ctrl_1[num2].Crtl_nome[num3].Indice * 256 + RT_geral.RT_850_Ctrl_1[num2].Crtl_indice[num3].Valor;
						Linha_RT.AddDadoArrayInteger(ref dados, item, ref num);
						num3++;
					}
					while (num3 <= 0);
					num2++;
				}
				while (num2 <= 79);
				num2 = 0;
				do
				{
					Linha_RT.ConverterStringToIntegerArray(RT_geral.RT_850_Ctrl_4[num2].Nome.Valor, ref dados, ref num, 5);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Canal.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Timeout.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Comando.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Prioridade.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Modelo.Indice, ref num);
					int num3 = 0;
					do
					{
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Var[num3].Indice, ref num);
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Ref[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 3);
					num3 = 0;
					do
					{
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Periferico_Indice[num3].Indice, ref num);
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Periferico_Modelo[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 4);
					num3 = 0;
					do
					{
						int item = RT_geral.RT_850_Ctrl_4[num2].Crtl_nome[num3].Indice * 256 + RT_geral.RT_850_Ctrl_4[num2].Crtl_indice[num3].Valor;
						Linha_RT.AddDadoArrayInteger(ref dados, item, ref num);
						num3++;
					}
					while (num3 <= 3);
					num2++;
				}
				while (num2 <= 49);
				num2 = 0;
				do
				{
					Linha_RT.ConverterStringToIntegerArray(RT_geral.RT_850_Ctrl_8[num2].Nome.Valor, ref dados, ref num, 5);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Canal.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Timeout.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Comando.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Prioridade.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Modelo.Indice, ref num);
					int num3 = 0;
					do
					{
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Var[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 15);
					num3 = 0;
					do
					{
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Ref[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 3);
					num3 = 0;
					do
					{
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Periferico_Indice[num3].Indice, ref num);
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Periferico_Modelo[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 4);
					num3 = 0;
					do
					{
						int item = RT_geral.RT_850_Ctrl_8[num2].Crtl_nome[num3].Indice * 256 + RT_geral.RT_850_Ctrl_8[num2].Crtl_indice[num3].Valor;
						Linha_RT.AddDadoArrayInteger(ref dados, item, ref num);
						num3++;
					}
					while (num3 <= 7);
					num2++;
				}
				while (num2 <= 19);
				num2 = 0;
				do
				{
					Linha_RT.ConverterStringToIntegerArray(RT_geral.RT_850_Vista[num2].Nome.Valor, ref dados, ref num, 5);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Vista[num2].Canal.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Vista[num2].Prioridade.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Vista[num2].Timeout.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Vista[num2].Modelo.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Vista[num2].Num_var.Valor, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Vista[num2].Num_equip.Valor, ref num);
					int num3 = 0;
					do
					{
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Vista[num2].Variaveis[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 39);
					num3 = 0;
					do
					{
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Vista[num2].Equipamentos[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 19);
					num2++;
				}
				while (num2 <= 4);
			}
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x002E79A0 File Offset: 0x002E5DA0
		public void EstrairImagem_RT850(ref int[] dados)
		{
			int num = 0;
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Versao.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Build.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Release.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Equip.Valor, ref num);
			RT_geral.RT_850_BD.Msg_linha_1.Valor = Linha_RT.ConverterIntegerArrayToString(ref dados, ref num, 10);
			RT_geral.RT_850_BD.Msg_linha_2.Valor = Linha_RT.ConverterIntegerArrayToString(ref dados, ref num, 10);
			RT_geral.RT_850_BD.Msg_linha_3.Valor = Linha_RT.ConverterIntegerArrayToString(ref dados, ref num, 10);
			RT_geral.RT_850_BD.Msg_linha_4.Valor = Linha_RT.ConverterIntegerArrayToString(ref dados, ref num, 10);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.End_mestre_canal_1.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Intervalo_leitura_canal_1.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.BaudRate_canal_1.Indice, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Timeout_canal_1.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Tempo_ptt_canal_1.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Numero_tentativas_canal_1.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Numero_erros_falha_canal_1.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.End_mestre_canal_2.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Intervalo_leitura_canal_2.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.BaudRate_canal_2.Indice, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Timeout_canal_2.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Tempo_ptt_canal_2.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Numero_tentativas_canal_2.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Numero_erros_falha_canal_2.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Sincronismo.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.End_inicial_equip_tipo_1.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.End_inicial_equip_tipo_vista.Valor, ref num);
			Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_BD.Variaveis_Numero.Valor, ref num);
			int num2 = 0;
			checked
			{
				do
				{
					RT_geral.Variaveis_RT_850[num2].Nome.Valor = Linha_RT.ConverterIntegerArrayToString(ref dados, ref num, 5);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.Variaveis_RT_850[num2].Escala_ini.Valor, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.Variaveis_RT_850[num2].Escala_fim.Valor, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.Variaveis_RT_850[num2].Pto_dec_ini.Valor, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.Variaveis_RT_850[num2].Pto_dec_fim.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.Variaveis_RT_850[num2].Nivel_alm_1.Valor, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.Variaveis_RT_850[num2].Tipo_alm_1.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.Variaveis_RT_850[num2].Msg_alm_1.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.Variaveis_RT_850[num2].Nivel_alm_2.Valor, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.Variaveis_RT_850[num2].Tipo_alm_2.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.Variaveis_RT_850[num2].Msg_alm_2.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.Variaveis_RT_850[num2].Dsp_pos.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.Variaveis_RT_850[num2].Dsp_tela.Valor, ref num);
					num2++;
				}
				while (num2 <= 299);
				num2 = 0;
				do
				{
					RT_geral.RT_850_Ctrl_1[num2].Nome.Valor = Linha_RT.ConverterIntegerArrayToString(ref dados, ref num, 5);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_1[num2].Canal.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_1[num2].Timeout.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_1[num2].Comando.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_1[num2].Prioridade.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_1[num2].Modelo.Indice, ref num);
					int num3 = 0;
					do
					{
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_1[num2].Var[num3].Indice, ref num);
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_1[num2].Ref[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 3);
					num3 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_1[num2].Crtl_nome[num3].Indice = dados[num] / 256;
						RT_geral.RT_850_Ctrl_1[num2].Crtl_indice[num3].Valor = dados[num] % 256;
						num++;
						num3++;
					}
					while (num3 <= 0);
					num2++;
				}
				while (num2 <= 79);
				num2 = 0;
				do
				{
					RT_geral.RT_850_Ctrl_4[num2].Nome.Valor = Linha_RT.ConverterIntegerArrayToString(ref dados, ref num, 5);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Canal.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Timeout.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Comando.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Prioridade.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Modelo.Indice, ref num);
					int num3 = 0;
					do
					{
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Var[num3].Indice, ref num);
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Ref[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 3);
					num3 = 0;
					do
					{
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Periferico_Indice[num3].Indice, ref num);
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Periferico_Modelo[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 4);
					num3 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_4[num2].Crtl_nome[num3].Indice = dados[num] / 256;
						RT_geral.RT_850_Ctrl_4[num2].Crtl_indice[num3].Valor = dados[num] % 256;
						num++;
						num3++;
					}
					while (num3 <= 3);
					num2++;
				}
				while (num2 <= 49);
				num2 = 0;
				do
				{
					RT_geral.RT_850_Ctrl_8[num2].Nome.Valor = Linha_RT.ConverterIntegerArrayToString(ref dados, ref num, 5);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Canal.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Timeout.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Comando.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Prioridade.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Modelo.Indice, ref num);
					int num3 = 0;
					do
					{
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Var[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 15);
					num3 = 0;
					do
					{
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Ref[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 3);
					num3 = 0;
					do
					{
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Periferico_Indice[num3].Indice, ref num);
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Periferico_Modelo[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 4);
					num3 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_8[num2].Crtl_nome[num3].Indice = dados[num] / 256;
						RT_geral.RT_850_Ctrl_8[num2].Crtl_indice[num3].Valor = dados[num] % 256;
						num++;
						num3++;
					}
					while (num3 <= 7);
					num2++;
				}
				while (num2 <= 19);
				num2 = 0;
				do
				{
					RT_geral.RT_850_Vista[num2].Nome.Valor = Linha_RT.ConverterIntegerArrayToString(ref dados, ref num, 5);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Vista[num2].Canal.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Vista[num2].Prioridade.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Vista[num2].Timeout.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Vista[num2].Modelo.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Vista[num2].Num_var.Valor, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Vista[num2].Num_equip.Valor, ref num);
					int num3 = 0;
					do
					{
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Vista[num2].Variaveis[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 39);
					num3 = 0;
					do
					{
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Vista[num2].Equipamentos[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 19);
					num2++;
				}
				while (num2 <= 4);
			}
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x002E850C File Offset: 0x002E690C
		public void GeraArquivoIni(string nome_arquivo_ini)
		{
			nome_arquivo_ini += "T";
			string text = "Geral";
			string text2 = "Versao";
			string text3 = Conversion.Str(RT_geral.RT_850_BD.Versao.Valor);
			Geral.WritePrivateProfileString(ref text, ref text2, ref text3, ref nome_arquivo_ini);
			text3 = "Geral";
			text2 = "Build";
			text = Conversion.Str(RT_geral.RT_850_BD.Build.Valor);
			Geral.WritePrivateProfileString(ref text3, ref text2, ref text, ref nome_arquivo_ini);
			text3 = "Geral";
			text2 = "Release";
			text = Conversion.Str(RT_geral.RT_850_BD.Release.Valor);
			Geral.WritePrivateProfileString(ref text3, ref text2, ref text, ref nome_arquivo_ini);
			text3 = "Geral";
			text2 = "Equip";
			text = Conversion.Str(RT_geral.RT_850_BD.Equip.Valor);
			Geral.WritePrivateProfileString(ref text3, ref text2, ref text, ref nome_arquivo_ini);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x002E85F8 File Offset: 0x002E69F8
		private void Timer_limpa_MSG_RT850_Tick(object sender, EventArgs e)
		{
			this.Timer_limpa_MSG_RT850.Enabled = false;
			this.AtualizaMsgTela_RT850("", 0);
			this.ToolStripProgressBar_RT850.Value = 0;
			this.ControleAtivacaoTeclas(3);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x002E8628 File Offset: 0x002E6A28
		private void ToolStripButton_RT850_novo_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			RT_geral.Lmte_Init_ok = false;
			RT_geral.RT_850_BD.Nome_Arquivo = "";
			this.Inicializa_DadosEStruturaRT850_Padrao();
			this.Inicializa_DadosEStruturaRT850_Default();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			this.Atualiza_TelaRT850();
			RT_geral.Lmte_Init_ok = true;
			this.AtualizaMsgTela_RT850("Valores Default carregados", 0);
			this.Timer_limpa_MSG_RT850.Enabled = true;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x002E8690 File Offset: 0x002E6A90
		private void ToolStripButton_RT850_Abrir_Click(object sender, EventArgs e)
		{
			int num = 0;
			int num2 = 0;
			object obj = null;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				int[] array = new int[10001];
				this.AtivaEfeitoOnChangeValue();
				this.ControleAtivacaoTeclas(1);
				this.OpenFileDialog_RT850.Filter = "Arquivo de configuração de equipamento|*.Cfg850";
				this.OpenFileDialog_RT850.InitialDirectory = Linha_RT.diretorio;
				if (this.OpenFileDialog_RT850.ShowDialog() == 1)
				{
					if (Operators.CompareString(this.OpenFileDialog_RT850.FileName, "", false) != 0)
					{
						Linha_RT.diretorio = Path.GetDirectoryName(this.OpenFileDialog_RT850.FileName) + "\\";
						RT_geral.arquivo_extensao = Path.GetExtension(this.OpenFileDialog_RT850.FileName);
						string fileName = Path.GetFileName(this.OpenFileDialog_RT850.FileName);
						IniFile iniFile = new IniFile(this.OpenFileDialog_RT850.FileName);
						this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						this.Carrega_Geral_Informacao(this.OpenFileDialog_RT850.FileName);
						if (RT_geral.RT_850_BD.Build.Valor >= 30)
						{
							RT_geral.RT_850_flag_msg_alarme_config = true;
						}
						else
						{
							RT_geral.RT_850_flag_msg_alarme_config = false;
						}
						if (!Linha_RT.VerificaSeEquipamentoEValido(1, RT_geral.RT_850_BD.Equip.Valor, RT_geral.RT_850_BD.Versao.Valor, RT_geral.RT_850_BD.Build.Valor, RT_geral.RT_850_BD.Release.Valor, RT_geral.arquivo_extensao).Status)
						{
							RT_geral.Lmte_Init_ok = false;
							RT_geral.RT_850_BD.Nome_Arquivo = "";
							this.Inicializa_DadosEStruturaRT850_Padrao();
							this.Inicializa_DadosEStruturaRT850_Default();
							Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
							this.Atualiza_TelaRT850();
							RT_geral.Lmte_Init_ok = true;
							this.AtualizaMsgTela_RT850("Valores Default carregados", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
						}
						else
						{
							RT_geral.RT_850_BD.Nome_Arquivo = this.OpenFileDialog_RT850.FileName;
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							this.Carrega_Geral_Msg_Display(this.OpenFileDialog_RT850.FileName);
							this.Carrega_Geral_Descricao(this.OpenFileDialog_RT850.FileName);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							this.Carrega_Canal_Radio1(this.OpenFileDialog_RT850.FileName);
							this.Carrega_Canal_Radio2(this.OpenFileDialog_RT850.FileName);
							this.Carrega_Sincronismo_Radio(this.OpenFileDialog_RT850.FileName);
							this.Carrega_ConfereResposta_Radio(this.OpenFileDialog_RT850.FileName);
							this.Carrega_ModoEstatistica_Radio(this.OpenFileDialog_RT850.FileName);
							this.Carrega_Falha_Comunicacao(this.OpenFileDialog_RT850.FileName);
							this.Carrega_LiberaTeclado(this.OpenFileDialog_RT850.FileName);
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							this.Carrega_Equipamentos(this.OpenFileDialog_RT850.FileName);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							this.Carrega_Variaveis(this.OpenFileDialog_RT850.FileName);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							this.Carrega_Msg_Alarme_Configuraveis(this.OpenFileDialog_RT850.FileName);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							this.Carrega_Controle1(this.OpenFileDialog_RT850.FileName);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							this.Carrega_Controle4(this.OpenFileDialog_RT850.FileName);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							this.Carrega_Controle8(this.OpenFileDialog_RT850.FileName);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							this.Carrega_Vista(this.OpenFileDialog_RT850.FileName);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							this.Carrega_Instalacao(this.OpenFileDialog_RT850.FileName);
							Application.DoEvents();
							RT_geral.RT_850_BD.Nome_Arquivo = fileName;
							this.Atualiza_TelaRT850();
							this.AtualizaMsgTela_RT850("Arquivo carregado com sucesso!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
						}
					}
				}
				else
				{
					this.AtualizaMsgTela_RT850("Operação Cancelada", 0);
					this.Timer_limpa_MSG_RT850.Enabled = true;
				}
				goto IL_4B7;
				IL_452:
				Interaction.MsgBox("Não foi possível carregar os dados", (MsgBoxStyle)32, "Atenção - Erro I/0");
				this.Timer_limpa_MSG_RT850.Enabled = true;
				goto IL_4B7;
				IL_472:
				num2 = -1;
								IL_488:;
			}
			catch (Exception) { }
			throw ProjectData.CreateProjectError(-2146828237);
			IL_4B7:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x002E8B7C File Offset: 0x002E6F7C
		private void Carrega_Geral_Informacao(string filename)
		{
			IniFile iniFile = new IniFile(filename);
			RT_geral.RT_850_BD.Equip.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "EQUIPAMENTO", -1);
			RT_geral.RT_850_BD.Versao.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "VERSAO", -1);
			RT_geral.RT_850_BD.Build.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "BUILD", -1);
			RT_geral.RT_850_BD.Release.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "RELEASE", -1);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x002E8C10 File Offset: 0x002E7010
		private void Salva_Geral_Informacao(IniFileWriteFast ini)
		{
			ini.WriteSection("GERAL_INFORMACAO");
			ini.WriteKey("EQUIPAMENTO", RT_geral.RT_850_BD.Equip.Valor);
			ini.WriteKey("VERSAO", RT_geral.RT_850_BD.Versao.Valor);
			ini.WriteKey("BUILD", RT_geral.RT_850_BD.Build.Valor);
			ini.WriteKey("RELEASE", RT_geral.RT_850_BD.Release.Valor);
			ini.LineSpace();
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x002E8C98 File Offset: 0x002E7098
		private void Carrega_Geral_Msg_Display(string filename)
		{
			IniFile iniFile = new IniFile(filename);
			RT_geral.RT_850_BD.Msg_linha_1.Valor = iniFile.ReadText("GERAL_MSG_DISPLAY", "LINHA1", "");
			RT_geral.RT_850_BD.Msg_linha_2.Valor = iniFile.ReadText("GERAL_MSG_DISPLAY", "LINHA2", "");
			RT_geral.RT_850_BD.Msg_linha_3.Valor = iniFile.ReadText("GERAL_MSG_DISPLAY", "LINHA3", "");
			RT_geral.RT_850_BD.Msg_linha_4.Valor = iniFile.ReadText("GERAL_MSG_DISPLAY", "LINHA4", "");
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x002E8D3C File Offset: 0x002E713C
		private void Salva_Geral_Msg_Display(IniFileWriteFast ini)
		{
			ini.WriteSection("GERAL_MSG_DISPLAY");
			ini.WriteKey("LINHA1", RT_geral.RT_850_BD.Msg_linha_1.Valor);
			ini.WriteKey("LINHA2", RT_geral.RT_850_BD.Msg_linha_2.Valor);
			ini.WriteKey("LINHA3", RT_geral.RT_850_BD.Msg_linha_3.Valor);
			ini.WriteKey("LINHA4", RT_geral.RT_850_BD.Msg_linha_4.Valor);
			ini.LineSpace();
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x002E8DC4 File Offset: 0x002E71C4
		private void Carrega_Geral_Descricao(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			this.TextBox_nome_RT850.Text = iniFile.ReadText("GERAL_DESCRICAO", "NOME", "");
			this.TextBox_endereco_RT850.Text = iniFile.ReadText("GERAL_DESCRICAO", "ENDERECO", "");
			this.TextBox_comentarios_RT850.Text = iniFile.ReadText("GERAL_DESCRICAO", "COMENTARIO", "");
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x002E8E40 File Offset: 0x002E7240
		private void Salva_Geral_Descricao(IniFileWriteFast ini)
		{
			ini.WriteSection("GERAL_DESCRICAO");
			ini.WriteKey("NOME", this.TextBox_nome_RT850.Text);
			ini.WriteKey("ENDERECO", this.TextBox_endereco_RT850.Text);
			ini.WriteKey("COMENTARIO", this.TextBox_comentarios_RT850.Text);
			ini.LineSpace();
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x002E8EA0 File Offset: 0x002E72A0
		private void Carrega_Canal_Radio1(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			RT_geral.RT_850_BD.End_mestre_canal_1.Valor = iniFile.ReadInteger("CANAL_RADIO1", "MESTRE", 0);
			RT_geral.RT_850_BD.Intervalo_leitura_canal_1.Valor = iniFile.ReadInteger("CANAL_RADIO1", "INTERVALO_LEITURA", 3);
			RT_geral.RT_850_BD.BaudRate_canal_1.Valor = iniFile.ReadInteger("CANAL_RADIO1", "BAUDRATE", 0);
			RT_geral.RT_850_BD.Timeout_canal_1.Valor = iniFile.ReadInteger("CANAL_RADIO1", "TIMEOUT", 5);
			RT_geral.RT_850_BD.Tempo_ptt_canal_1.Valor = iniFile.ReadInteger("CANAL_RADIO1", "TEMPO_PTT", 200);
			RT_geral.RT_850_BD.Numero_tentativas_canal_1.Valor = iniFile.ReadInteger("CANAL_RADIO1", "NUMERO_TENTATIVAS", 3);
			RT_geral.RT_850_BD.Numero_erros_falha_canal_1.Valor = iniFile.ReadInteger("CANAL_RADIO1", "NUMERO_ERROS_FALHA", 3);
			RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Valor = iniFile.ReadInteger("CANAL_RADIO1", "NUMERO_CMD_ESTATISTICA", 100);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x002E8FC0 File Offset: 0x002E73C0
		private void Salva_Canal_Radio1(IniFileWriteFast ini)
		{
			ini.WriteSection("CANAL_RADIO1");
			ini.WriteKey("MESTRE", RT_geral.RT_850_BD.End_mestre_canal_1.Valor);
			ini.WriteKey("INTERVALO_LEITURA", RT_geral.RT_850_BD.Intervalo_leitura_canal_1.Valor);
			ini.WriteKey("BAUDRATE", RT_geral.RT_850_BD.BaudRate_canal_1.Valor);
			ini.WriteKey("TIMEOUT", RT_geral.RT_850_BD.Timeout_canal_1.Valor);
			ini.WriteKey("TEMPO_PTT", RT_geral.RT_850_BD.Tempo_ptt_canal_1.Valor);
			ini.WriteKey("NUMERO_TENTATIVAS", RT_geral.RT_850_BD.Numero_tentativas_canal_1.Valor);
			ini.WriteKey("NUMERO_ERROS_FALHA", RT_geral.RT_850_BD.Numero_erros_falha_canal_1.Valor);
			ini.WriteKey("NUMERO_CMD_ESTATISTICA", RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Valor);
			ini.LineSpace();
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x002E90B0 File Offset: 0x002E74B0
		private void Carrega_Canal_Radio2(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			RT_geral.RT_850_BD.End_mestre_canal_2.Valor = iniFile.ReadInteger("CANAL_RADIO2", "MESTRE", 0);
			RT_geral.RT_850_BD.Intervalo_leitura_canal_2.Valor = iniFile.ReadInteger("CANAL_RADIO2", "INTERVALO_LEITURA", 3);
			RT_geral.RT_850_BD.BaudRate_canal_2.Valor = iniFile.ReadInteger("CANAL_RADIO2", "BAUDRATE", 0);
			RT_geral.RT_850_BD.Timeout_canal_2.Valor = iniFile.ReadInteger("CANAL_RADIO2", "TIMEOUT", 5);
			RT_geral.RT_850_BD.Tempo_ptt_canal_2.Valor = iniFile.ReadInteger("CANAL_RADIO2", "TEMPO_PTT", 200);
			RT_geral.RT_850_BD.Numero_tentativas_canal_2.Valor = iniFile.ReadInteger("CANAL_RADIO2", "NUMERO_TENTATIVAS", 3);
			RT_geral.RT_850_BD.Numero_erros_falha_canal_2.Valor = iniFile.ReadInteger("CANAL_RADIO2", "NUMERO_ERROS_FALHA", 3);
			RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Valor = iniFile.ReadInteger("CANAL_RADIO2", "NUMERO_CMD_ESTATISTICA", 100);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x002E91D0 File Offset: 0x002E75D0
		private void Salva_Canal_Radio2(IniFileWriteFast ini)
		{
			ini.WriteSection("CANAL_RADIO2");
			ini.WriteKey("MESTRE", RT_geral.RT_850_BD.End_mestre_canal_2.Valor);
			ini.WriteKey("INTERVALO_LEITURA", RT_geral.RT_850_BD.Intervalo_leitura_canal_2.Valor);
			ini.WriteKey("BAUDRATE", RT_geral.RT_850_BD.BaudRate_canal_2.Valor);
			ini.WriteKey("TIMEOUT", RT_geral.RT_850_BD.Timeout_canal_2.Valor);
			ini.WriteKey("TEMPO_PTT", RT_geral.RT_850_BD.Tempo_ptt_canal_2.Valor);
			ini.WriteKey("NUMERO_TENTATIVAS", RT_geral.RT_850_BD.Numero_tentativas_canal_2.Valor);
			ini.WriteKey("NUMERO_ERROS_FALHA", RT_geral.RT_850_BD.Numero_erros_falha_canal_2.Valor);
			ini.WriteKey("NUMERO_CMD_ESTATISTICA", RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Valor);
			ini.LineSpace();
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x002E92C0 File Offset: 0x002E76C0
		private void Carrega_Sincronismo_Radio(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			RT_geral.RT_850_BD.Sincronismo.Valor = iniFile.ReadInteger("CANAL_RADIO", "SINCRONISMO", 0);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x002E92FC File Offset: 0x002E76FC
		private void Salva_Sincronismo_Radio(IniFileWriteFast ini)
		{
			ini.WriteSection("CANAL_RADIO");
			ini.WriteKey("SINCRONISMO", RT_geral.RT_850_BD.Sincronismo.Valor);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x002E9324 File Offset: 0x002E7724
		private void Carrega_ConfereResposta_Radio(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			RT_geral.RT_850_BD.ConfereResposta.Valor = iniFile.ReadInteger("CANAL_RADIO", "CONFERE_RESPOSTA", 0);
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x002E9360 File Offset: 0x002E7760
		private void Salva_ConfereResposta_Radio(IniFileWriteFast ini)
		{
			ini.WriteKey("CONFERE_RESPOSTA", RT_geral.RT_850_BD.ConfereResposta.Valor);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x002E937C File Offset: 0x002E777C
		private void Carrega_ModoEstatistica_Radio(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			RT_geral.RT_850_BD.Modo_Estatistica.Valor = iniFile.ReadInteger("CANAL_RADIO", "MODO_ESTATISTICA", 0);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x002E93B8 File Offset: 0x002E77B8
		private void Salva_ModoEstatistica_Radio(IniFileWriteFast ini)
		{
			ini.WriteKey("MODO_ESTATISTICA", RT_geral.RT_850_BD.Modo_Estatistica.Valor);
			ini.LineSpace();
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x002E93DC File Offset: 0x002E77DC
		private void Salva_FalhaComunicacao(IniFileWriteFast ini)
		{
			ini.WriteSection("FALHA_COMUNICACAO");
			ini.WriteKey("REMOTA", RT_geral.RT_850_BD.Flag_Remota.Valor);
			ini.WriteKey("SUPERVISORIO", RT_geral.RT_850_BD.Flag_Supervisorio.Valor);
			ini.LineSpace();
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x002E9430 File Offset: 0x002E7830
		private void Salva_LiberaTeclado(IniFileWriteFast ini)
		{
			ini.WriteSection("TECLADO");
			ini.WriteKey("LIBERA", RT_geral.RT_850_BD.LiberaTeclado.Valor);
			ini.LineSpace();
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x002E9460 File Offset: 0x002E7860
		private void Carrega_Falha_Comunicacao(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			RT_geral.RT_850_BD.Flag_Remota.Valor = iniFile.ReadInteger("FALHA_COMUNICACAO", "REMOTA", 0);
			RT_geral.RT_850_BD.Flag_Supervisorio.Valor = iniFile.ReadInteger("FALHA_COMUNICACAO", "SUPERVISORIO", 0);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x002E94BC File Offset: 0x002E78BC
		private void Carrega_LiberaTeclado(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			RT_geral.RT_850_BD.LiberaTeclado.Valor = iniFile.ReadInteger("TECLADO", "LIBERA", RT_geral.RT_850_BD.LiberaTeclado.Padrao);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x002E9504 File Offset: 0x002E7904
		private void Carrega_Equipamentos(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor = iniFile.ReadInteger("EQUIPAMENTO_TIPO1", "NUMERO", 0);
			RT_geral.RT_850_BD.End_inicial_equip_tipo_1.Valor = iniFile.ReadInteger("EQUIPAMENTO_TIPO1", "ENDERECO_INICIAL", 0);
			RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor = iniFile.ReadInteger("EQUIPAMENTO_TIPO2", "NUMERO", 0);
			RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Valor = iniFile.ReadInteger("EQUIPAMENTO_TIPO2", "ENDERECO_INICIAL", 0);
			RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor = iniFile.ReadInteger("EQUIPAMENTO_TIPO3", "NUMERO", 0);
			RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Valor = iniFile.ReadInteger("EQUIPAMENTO_TIPO3", "ENDERECO_INICIAL", 0);
			RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor = iniFile.ReadInteger("EQUIPAMENTO_TIPOVISTA", "NUMERO", 0);
			RT_geral.RT_850_BD.End_inicial_equip_tipo_vista.Valor = iniFile.ReadInteger("EQUIPAMENTO_TIPOVISTA", "ENDERECO_INICIAL", 0);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x002E9620 File Offset: 0x002E7A20
		private void Salva_Equipamentos(IniFileWriteFast ini)
		{
			ini.WriteSection("EQUIPAMENTO_TIPO1");
			ini.WriteKey("NUMERO", RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor);
			ini.WriteKey("ENDERECO_INICIAL", RT_geral.RT_850_BD.End_inicial_equip_tipo_1.Valor);
			ini.LineSpace();
			ini.WriteSection("EQUIPAMENTO_TIPO2");
			ini.WriteKey("NUMERO", RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor);
			ini.WriteKey("ENDERECO_INICIAL", RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Valor);
			ini.LineSpace();
			ini.WriteSection("EQUIPAMENTO_TIPO3");
			ini.WriteKey("NUMERO", RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor);
			ini.WriteKey("ENDERECO_INICIAL", RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Valor);
			ini.LineSpace();
			ini.WriteSection("EQUIPAMENTO_TIPOVISTA");
			ini.WriteKey("NUMERO", RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor);
			ini.WriteKey("ENDERECO_INICIAL", RT_geral.RT_850_BD.End_inicial_equip_tipo_vista.Valor);
			ini.LineSpace();
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x002E9744 File Offset: 0x002E7B44
		private void Carrega_Variaveis(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			RT_geral.RT_850_BD.Variaveis_Numero.Valor = iniFile.ReadInteger("VARIAVEIS", "NUMERO", 0);
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_850_BD.Variaveis_Numero.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string section = string.Format("VARIAVEIS_{0}", i + 1);
					RT_geral.Variaveis_RT_850[i].Nome.Valor = iniFile.ReadText(section, "NOME", string.Format("? {0}", i + 1));
					RT_geral.Variaveis_RT_850[i].Escala_ini.Valor = iniFile.ReadInteger(section, "ESCALA_INICIAL", 0);
					Linha_RT.Tratamento_Variaveis_Escala_Fim(i, iniFile.ReadInteger(section, "ESCALA_FINAL", 0));
					RT_geral.Variaveis_RT_850[i].Pto_dec_ini.Valor = iniFile.ReadInteger(section, "PTO_DEC_INICIAL", 0);
					RT_geral.Variaveis_RT_850[i].Pto_dec_fim.Indice = iniFile.ReadInteger(section, "PTO_DEC_FINAL", 0);
					Application.DoEvents();
					RT_geral.Variaveis_RT_850[i].Nivel_alm_1.Valor = iniFile.ReadInteger(section, "NIVEL_ALARME1", 0);
					RT_geral.Variaveis_RT_850[i].Tipo_alm_1.Indice = iniFile.ReadInteger(section, "TIPO_ALARME1", 0);
					RT_geral.Variaveis_RT_850[i].Msg_alm_1.Valor = iniFile.ReadInteger(section, "MENSAGEM_ALARME1", 0);
					RT_geral.Variaveis_RT_850[i].Nivel_alm_2.Valor = iniFile.ReadInteger(section, "NIVEL_ALARME2", 0);
					RT_geral.Variaveis_RT_850[i].Tipo_alm_2.Indice = iniFile.ReadInteger(section, "TIPO_ALARME2", 0);
					RT_geral.Variaveis_RT_850[i].Msg_alm_2.Valor = iniFile.ReadInteger(section, "MENSAGEM_ALARME2", 0);
					RT_geral.Variaveis_RT_850[i].Dsp_tela.Valor = iniFile.ReadInteger(section, "NUMERO_TELA", 0);
					RT_geral.Variaveis_RT_850[i].Dsp_pos.Indice = iniFile.ReadInteger(section, "DSP_POSICAO", 0);
					Application.DoEvents();
					this.ToolStripProgressBar_RT850.Value = (int)Math.Round(unchecked((double)i / 299.0 * 100.0));
				}
			}
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x002E99A4 File Offset: 0x002E7DA4
		private void Salva_Variaveis(IniFileWriteFast ini)
		{
			ini.WriteSection("VARIAVEIS");
			ini.WriteKey("NUMERO", RT_geral.RT_850_BD.Variaveis_Numero.Valor);
			ini.LineSpace();
			int valor = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
			int num = 0;
			checked
			{
				int num2 = valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string section = string.Format("VARIAVEIS_{0}", i + 1);
					ini.WriteSection(section);
					ini.WriteKey("NOME", RT_geral.Variaveis_RT_850[i].Nome.Valor);
					ini.WriteKey("ESCALA_INICIAL", RT_geral.Variaveis_RT_850[i].Escala_ini.Valor);
					int value;
					switch (RT_geral.Variaveis_RT_850[i].Escala_tratamento.Valor)
					{
					case 0:
						value = RT_geral.Variaveis_RT_850[i].Escala_fim.Valor;
						break;
					case 1:
						value = RT_geral.Variaveis_RT_850[i].Escala_fim.Valor + 10000;
						break;
					default:
						value = 0;
						break;
					}
					ini.WriteKey("ESCALA_FINAL", value);
					ini.WriteKey("PTO_DEC_INICIAL", RT_geral.Variaveis_RT_850[i].Pto_dec_ini.Valor);
					ini.WriteKey("PTO_DEC_FINAL", RT_geral.Variaveis_RT_850[i].Pto_dec_fim.Indice);
					ini.WriteKey("NIVEL_ALARME1", RT_geral.Variaveis_RT_850[i].Nivel_alm_1.Valor);
					ini.WriteKey("TIPO_ALARME1", RT_geral.Variaveis_RT_850[i].Tipo_alm_1.Indice);
					ini.WriteKey("MENSAGEM_ALARME1", RT_geral.Variaveis_RT_850[i].Msg_alm_1.Valor);
					ini.WriteKey("NIVEL_ALARME2", RT_geral.Variaveis_RT_850[i].Nivel_alm_2.Valor);
					ini.WriteKey("TIPO_ALARME2", RT_geral.Variaveis_RT_850[i].Tipo_alm_2.Indice);
					ini.WriteKey("MENSAGEM_ALARME2", RT_geral.Variaveis_RT_850[i].Msg_alm_2.Valor);
					ini.WriteKey("NUMERO_TELA", RT_geral.Variaveis_RT_850[i].Dsp_tela.Valor);
					ini.WriteKey("DSP_POSICAO", RT_geral.Variaveis_RT_850[i].Dsp_pos.Indice);
					ini.LineSpace();
				}
			}
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x002E9C0C File Offset: 0x002E800C
		private void Carrega_Msg_Alarme_Configuraveis(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			int num = 0;
			checked
			{
				do
				{
					string key = string.Format("MSG_ALARME_CFG_{0}", num + 1);
					RT_geral.RT_850_MSG_ALARME_CONFIG[num] = iniFile.ReadText("MSG_ALARME_CFG", key, "msg alarme cfg #" + Conversion.Str(num + 1));
					num++;
				}
				while (num <= 19);
			}
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x002E9C70 File Offset: 0x002E8070
		private void Salva_Msg_Alarme_Cfg(IniFileWriteFast ini)
		{
			ini.WriteSection("MSG_ALARME_CFG");
			int num = 0;
			checked
			{
				do
				{
					string key = string.Format("MSG_ALARME_CFG_{0}", num + 1);
					ini.WriteKey(key, RT_geral.RT_850_MSG_ALARME_CONFIG[num]);
					num++;
				}
				while (num <= 19);
				ini.LineSpace();
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x002E9CBC File Offset: 0x002E80BC
		private void Carrega_Controle1(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string section = string.Format("CONTROLE_TIPO1_{0}", i + 1);
					RT_geral.RT_850_Ctrl_1[i].Nome.Valor = iniFile.ReadText(section, "NOME", string.Format("? {0}", i + 1));
					RT_geral.RT_850_Ctrl_1[i].Canal.Indice = iniFile.ReadInteger(section, "CANAL", 0);
					RT_geral.RT_850_Ctrl_1[i].Timeout.Indice = iniFile.ReadInteger(section, "TIMEOUT", 0);
					RT_geral.RT_850_Ctrl_1[i].Comando.Indice = iniFile.ReadInteger(section, "COMANDO", 0);
					RT_geral.RT_850_Ctrl_1[i].Prioridade.Indice = iniFile.ReadInteger(section, "PRIORIDADE", 0);
					RT_geral.RT_850_Ctrl_1[i].Modelo.Indice = iniFile.ReadInteger(section, "MODELO", 0);
					Application.DoEvents();
					int num3 = 0;
					do
					{
						string key = string.Format("VAR{0}", num3);
						RT_geral.RT_850_Ctrl_1[i].Var[num3].Indice = iniFile.ReadInteger(section, key, 0);
						key = string.Format("REF{0}", num3);
						RT_geral.RT_850_Ctrl_1[i].Ref[num3].Indice = iniFile.ReadInteger(section, key, 0);
						Application.DoEvents();
						num3++;
					}
					while (num3 <= 3);
					num3 = 0;
					do
					{
						string key = string.Format("CNTL_NOME_{0}", num3 + 1);
						int num4 = iniFile.ReadInteger(section, key, 0);
						RT_geral.RT_850_Ctrl_1[i].Crtl_nome[num3].Indice = num4 / 256;
						RT_geral.RT_850_Ctrl_1[i].Crtl_indice[num3].Valor = num4 % 256;
						Application.DoEvents();
						num3++;
					}
					while (num3 <= 0);
					this.ToolStripProgressBar_RT850.Value = (int)Math.Round(unchecked((double)i / 79.0 * 100.0));
				}
			}
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x002E9F10 File Offset: 0x002E8310
		private void Salva_Controle1(IniFileWriteFast ini)
		{
			int valor = RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor;
			int num = 0;
			checked
			{
				int num2 = valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string section = string.Format("CONTROLE_TIPO1_{0}", i + 1);
					ini.WriteSection(section);
					ini.WriteKey("NOME", RT_geral.RT_850_Ctrl_1[i].Nome.Valor);
					ini.WriteKey("CANAL", RT_geral.RT_850_Ctrl_1[i].Canal.Indice);
					ini.WriteKey("TIMEOUT", RT_geral.RT_850_Ctrl_1[i].Timeout.Indice);
					ini.WriteKey("COMANDO", RT_geral.RT_850_Ctrl_1[i].Comando.Indice);
					ini.WriteKey("PRIORIDADE", RT_geral.RT_850_Ctrl_1[i].Prioridade.Indice);
					ini.WriteKey("MODELO", RT_geral.RT_850_Ctrl_1[i].Modelo.Indice);
					int num3 = 0;
					do
					{
						string key = string.Format("VAR{0}", num3);
						ini.WriteKey(key, RT_geral.RT_850_Ctrl_1[i].Var[num3].Indice);
						key = string.Format("REF{0}", num3);
						ini.WriteKey(key, RT_geral.RT_850_Ctrl_1[i].Ref[num3].Indice);
						num3++;
					}
					while (num3 <= 3);
					num3 = 0;
					do
					{
						int value = RT_geral.RT_850_Ctrl_1[i].Crtl_nome[num3].Indice * 256 + RT_geral.RT_850_Ctrl_1[i].Crtl_indice[num3].Valor;
						string key = string.Format("CNTL_NOME_{0}", num3 + 1);
						ini.WriteKey(key, value);
						Application.DoEvents();
						num3++;
					}
					while (num3 <= 0);
					ini.LineSpace();
				}
			}
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x002EA108 File Offset: 0x002E8508
		private void Carrega_Controle4(string filename)
		{
			IniFile iniFile = new IniFile(filename);
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					object obj = string.Format("CONTROLE_TIPO2_{0}", i + 1);
					RT_geral.RT_850_Ctrl_4[i].Nome.Valor = iniFile.ReadText(Conversions.ToString(obj), "NOME", string.Format("? {0}", i + 1));
					RT_geral.RT_850_Ctrl_4[i].Canal.Indice = iniFile.ReadInteger(Conversions.ToString(obj), "CANAL", 0);
					RT_geral.RT_850_Ctrl_4[i].Timeout.Indice = iniFile.ReadInteger(Conversions.ToString(obj), "TIMEOUT", 0);
					RT_geral.RT_850_Ctrl_4[i].Comando.Indice = iniFile.ReadInteger(Conversions.ToString(obj), "COMANDO", 0);
					RT_geral.RT_850_Ctrl_4[i].Prioridade.Indice = iniFile.ReadInteger(Conversions.ToString(obj), "PRIORIDADE", 0);
					RT_geral.RT_850_Ctrl_4[i].Modelo.Indice = iniFile.ReadInteger(Conversions.ToString(obj), "MODELO", 0);
					Application.DoEvents();
					int num3 = 0;
					do
					{
						string key = string.Format("VAR{0}", num3);
						RT_geral.RT_850_Ctrl_4[i].Var[num3].Indice = iniFile.ReadInteger(Conversions.ToString(obj), key, 0);
						key = string.Format("REF{0}", num3);
						RT_geral.RT_850_Ctrl_4[i].Ref[num3].Indice = iniFile.ReadInteger(Conversions.ToString(obj), key, 0);
						Application.DoEvents();
						num3++;
					}
					while (num3 <= 3);
					num3 = 0;
					do
					{
						string key = string.Format("PERIFERICO_INDICE{0}", num3 + 1);
						RT_geral.RT_850_Ctrl_4[i].Periferico_Indice[num3].Indice = iniFile.ReadInteger(Conversions.ToString(obj), key, -1);
						key = string.Format("PERIFERICO_MODELO{0}", num3 + 1);
						RT_geral.RT_850_Ctrl_4[i].Periferico_Modelo[num3].Indice = iniFile.ReadInteger(Conversions.ToString(obj), key, -1);
						Application.DoEvents();
						num3++;
					}
					while (num3 <= 4);
					num3 = 0;
					do
					{
						string key = string.Format("CNTL_NOME_{0}", num3 + 1);
						int num4 = iniFile.ReadInteger(Conversions.ToString(obj), key, 0);
						RT_geral.RT_850_Ctrl_4[i].Crtl_nome[num3].Indice = num4 / 256;
						RT_geral.RT_850_Ctrl_4[i].Crtl_indice[num3].Valor = num4 % 256;
						Application.DoEvents();
						num3++;
					}
					while (num3 <= 3);
				}
			}
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x002EA3F8 File Offset: 0x002E87F8
		private void Salva_Controle4(IniFileWriteFast ini)
		{
			int valor = RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor;
			int num = 0;
			checked
			{
				int num2 = valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string section = string.Format("CONTROLE_TIPO2_{0}", i + 1);
					ini.WriteSection(section);
					ini.WriteKey("NOME", RT_geral.RT_850_Ctrl_4[i].Nome.Valor);
					ini.WriteKey("CANAL", RT_geral.RT_850_Ctrl_4[i].Canal.Indice);
					ini.WriteKey("TIMEOUT", RT_geral.RT_850_Ctrl_4[i].Timeout.Indice);
					ini.WriteKey("COMANDO", RT_geral.RT_850_Ctrl_4[i].Comando.Indice);
					ini.WriteKey("PRIORIDADE", RT_geral.RT_850_Ctrl_4[i].Prioridade.Indice);
					ini.WriteKey("MODELO", RT_geral.RT_850_Ctrl_4[i].Modelo.Indice);
					int num3 = 0;
					do
					{
						string key = string.Format("VAR{0}", num3);
						ini.WriteKey(key, RT_geral.RT_850_Ctrl_4[i].Var[num3].Indice);
						key = string.Format("REF{0}", num3);
						ini.WriteKey(key, RT_geral.RT_850_Ctrl_4[i].Ref[num3].Indice);
						num3++;
					}
					while (num3 <= 3);
					num3 = 0;
					do
					{
						string key = string.Format("PERIFERICO_INDICE{0}", num3 + 1);
						ini.WriteKey(key, RT_geral.RT_850_Ctrl_4[i].Periferico_Indice[num3].Indice);
						key = string.Format("PERIFERICO_MODELO{0}", num3 + 1);
						ini.WriteKey(key, RT_geral.RT_850_Ctrl_4[i].Periferico_Modelo[num3].Indice);
						num3++;
					}
					while (num3 <= 4);
					num3 = 0;
					do
					{
						int value = RT_geral.RT_850_Ctrl_4[i].Crtl_nome[num3].Indice * 256 + RT_geral.RT_850_Ctrl_4[i].Crtl_indice[num3].Valor;
						string key = string.Format("CNTL_NOME_{0}", num3 + 1);
						ini.WriteKey(key, value);
						num3++;
					}
					while (num3 <= 3);
					ini.LineSpace();
				}
			}
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x002EA660 File Offset: 0x002E8A60
		private void Carrega_Controle8(string filename)
		{
			IniFile iniFile = new IniFile(filename);
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string section = string.Format("CONTROLE_TIPO3_{0}", i + 1);
					RT_geral.RT_850_Ctrl_8[i].Nome.Valor = iniFile.ReadText(section, "NOME", string.Format("? {0}", i + 1));
					RT_geral.RT_850_Ctrl_8[i].Canal.Indice = iniFile.ReadInteger(section, "CANAL", 0);
					RT_geral.RT_850_Ctrl_8[i].Timeout.Indice = iniFile.ReadInteger(section, "TIMEOUT", 0);
					RT_geral.RT_850_Ctrl_8[i].Comando.Indice = iniFile.ReadInteger(section, "COMANDO", 0);
					RT_geral.RT_850_Ctrl_8[i].Prioridade.Indice = iniFile.ReadInteger(section, "PRIORIDADE", 0);
					RT_geral.RT_850_Ctrl_8[i].Modelo.Indice = iniFile.ReadInteger(section, "MODELO", 0);
					Application.DoEvents();
					int num3 = 0;
					do
					{
						string key = string.Format("VAR{0}", num3);
						RT_geral.RT_850_Ctrl_8[i].Var[num3].Indice = iniFile.ReadInteger(section, key, 0);
						Application.DoEvents();
						num3++;
					}
					while (num3 <= 15);
					num3 = 0;
					do
					{
						string key = string.Format("REF{0}", num3);
						RT_geral.RT_850_Ctrl_8[i].Ref[num3].Indice = iniFile.ReadInteger(section, key, 0);
						Application.DoEvents();
						num3++;
					}
					while (num3 <= 3);
					num3 = 0;
					do
					{
						string key = string.Format("PERIFERICO_INDICE{0}", num3 + 1);
						RT_geral.RT_850_Ctrl_8[i].Periferico_Indice[num3].Indice = iniFile.ReadInteger(section, key, 0);
						key = string.Format("PERIFERICO_MODELO{0}", num3 + 1);
						RT_geral.RT_850_Ctrl_8[i].Periferico_Modelo[num3].Indice = iniFile.ReadInteger(section, key, 0);
						Application.DoEvents();
						num3++;
					}
					while (num3 <= 4);
					num3 = 0;
					do
					{
						string key = string.Format("CNTL_NOME_{0}", num3 + 1);
						int num4 = iniFile.ReadInteger(section, key, 0);
						RT_geral.RT_850_Ctrl_8[i].Crtl_nome[num3].Indice = num4 / 256;
						RT_geral.RT_850_Ctrl_8[i].Crtl_indice[num3].Valor = num4 % 256;
						Application.DoEvents();
						num3++;
					}
					while (num3 <= 7);
					this.ToolStripProgressBar_RT850.Value = (int)Math.Round(unchecked((double)i / 19.0 * 100.0));
				}
			}
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x002EA948 File Offset: 0x002E8D48
		private void Salva_Controle8(IniFileWriteFast ini)
		{
			int valor = RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor;
			int num = 0;
			checked
			{
				int num2 = valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string section = string.Format("CONTROLE_TIPO3_{0}", i + 1);
					ini.WriteSection(section);
					ini.WriteKey("NOME", RT_geral.RT_850_Ctrl_8[i].Nome.Valor);
					ini.WriteKey("CANAL", RT_geral.RT_850_Ctrl_8[i].Canal.Indice);
					ini.WriteKey("TIMEOUT", RT_geral.RT_850_Ctrl_8[i].Timeout.Indice);
					ini.WriteKey("COMANDO", RT_geral.RT_850_Ctrl_8[i].Comando.Indice);
					ini.WriteKey("PRIORIDADE", RT_geral.RT_850_Ctrl_8[i].Prioridade.Indice);
					ini.WriteKey("MODELO", RT_geral.RT_850_Ctrl_8[i].Modelo.Indice);
					int num3 = 0;
					do
					{
						string key = string.Format("VAR{0}", num3);
						ini.WriteKey(key, RT_geral.RT_850_Ctrl_8[i].Var[num3].Indice);
						num3++;
					}
					while (num3 <= 15);
					num3 = 0;
					do
					{
						string key = string.Format("REF{0}", num3);
						ini.WriteKey(key, RT_geral.RT_850_Ctrl_8[i].Ref[num3].Indice);
						num3++;
					}
					while (num3 <= 3);
					num3 = 0;
					do
					{
						string key = string.Format("PERIFERICO_INDICE{0}", num3 + 1);
						ini.WriteKey(key, RT_geral.RT_850_Ctrl_8[i].Periferico_Indice[num3].Indice);
						key = string.Format("PERIFERICO_MODELO{0}", num3 + 1);
						ini.WriteKey(key, RT_geral.RT_850_Ctrl_8[i].Periferico_Modelo[num3].Indice);
						num3++;
					}
					while (num3 <= 4);
					num3 = 0;
					do
					{
						int value = RT_geral.RT_850_Ctrl_8[i].Crtl_nome[num3].Indice * 256 + RT_geral.RT_850_Ctrl_8[i].Crtl_indice[num3].Valor;
						string key = string.Format("CNTL_NOME_{0}", num3 + 1);
						ini.WriteKey(key, value);
						num3++;
					}
					while (num3 <= 7);
					ini.LineSpace();
				}
			}
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x002EABBC File Offset: 0x002E8FBC
		private void Carrega_Vista(string filename)
		{
			IniFile iniFile = new IniFile(filename);
			int num = 0;
			int valor = RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor;
			checked
			{
				for (int i = num; i <= valor; i++)
				{
					string section = string.Format("CONTROLE_TIPO_VISTA_{0}", i + 1);
					RT_geral.RT_850_Vista[i].Nome.Valor = iniFile.ReadText(section, "NOME", string.Format("Vista???{0}", i + 1));
					RT_geral.RT_850_Vista[i].Canal.Indice = iniFile.ReadInteger(section, "CANAL", 0);
					RT_geral.RT_850_Vista[i].Timeout.Indice = iniFile.ReadInteger(section, "TIMEOUT", 0);
					RT_geral.RT_850_Vista[i].Prioridade.Indice = iniFile.ReadInteger(section, "PRIORIDADE", 0);
					RT_geral.RT_850_Vista[i].Modelo.Indice = iniFile.ReadInteger(section, "MODELO", 0);
					RT_geral.RT_850_Vista[i].Num_var.Valor = iniFile.ReadInteger(section, "NUMERO_VARIAVEIS", 0);
					RT_geral.RT_850_Vista[i].Num_equip.Valor = iniFile.ReadInteger(section, "NUMERO_EQUIPAMENTO", 0);
					Application.DoEvents();
					int num2 = 0;
					do
					{
						string key = string.Format("VARIAVEIS{0}", num2 + 1);
						RT_geral.RT_850_Vista[i].Variaveis[num2].Indice = iniFile.ReadInteger(section, key, 0);
						Application.DoEvents();
						num2++;
					}
					while (num2 <= 39);
					num2 = 0;
					do
					{
						string key = string.Format("EQUIPAMENTOS{0}", num2 + 1);
						RT_geral.RT_850_Vista[i].Equipamentos[num2].Indice = iniFile.ReadInteger(section, key, 0);
						Application.DoEvents();
						num2++;
					}
					while (num2 <= 19);
					this.ToolStripProgressBar_RT850.Value = (int)Math.Round(unchecked((double)i / 4.0 * 100.0));
				}
			}
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x002EADC4 File Offset: 0x002E91C4
		private void Salva_Vista(IniFileWriteFast ini)
		{
			int valor = RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor;
			int num = 0;
			int num2 = valor;
			checked
			{
				for (int i = num; i <= num2; i++)
				{
					string section = string.Format("CONTROLE_TIPO_VISTA_{0}", i + 1);
					ini.WriteSection(section);
					ini.WriteKey("NOME", RT_geral.RT_850_Vista[i].Nome.Valor);
					ini.WriteKey("CANAL", RT_geral.RT_850_Vista[i].Canal.Indice);
					ini.WriteKey("TIMEOUT", RT_geral.RT_850_Vista[i].Timeout.Indice);
					ini.WriteKey("PRIORIDADE", RT_geral.RT_850_Vista[i].Prioridade.Indice);
					ini.WriteKey("MODELO", RT_geral.RT_850_Vista[i].Modelo.Indice);
					ini.WriteKey("NUMERO_VARIAVEIS", RT_geral.RT_850_Vista[i].Num_var.Valor);
					ini.WriteKey("NUMERO_EQUIPAMENTO", RT_geral.RT_850_Vista[i].Num_equip.Valor);
					int num3 = 0;
					do
					{
						string key = string.Format("VARIAVEIS{0}", num3 + 1);
						ini.WriteKey(key, RT_geral.RT_850_Vista[i].Variaveis[num3].Indice);
						num3++;
					}
					while (num3 <= 39);
					num3 = 0;
					do
					{
						string key = string.Format("EQUIPAMENTOS{0}", num3 + 1);
						ini.WriteKey(key, RT_geral.RT_850_Vista[i].Equipamentos[num3].Indice);
						num3++;
					}
					while (num3 <= 19);
					ini.LineSpace();
				}
			}
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x002EAF7C File Offset: 0x002E937C
		private void Carrega_Instalacao(string filename)
		{
			IniFile iniFile = new IniFile(filename);
			this.CB_TipoAntena1.SelectedIndex = iniFile.ReadInteger("DADOS_INSTALACAO_1", "TIPO_ANTENA", -1);
			this.CB_PolarizacaoAntena1.SelectedIndex = iniFile.ReadInteger("DADOS_INSTALACAO_1", "POLARIZACAO_ANTENA", -1);
			this.T_PotRadio1.Text = iniFile.ReadText("DADOS_INSTALACAO_1", "POTENCIA_RADIO", "");
			this.CB_ModeloRadio1.SelectedIndex = iniFile.ReadInteger("DADOS_INSTALACAO_1", "MODELO_RADIO", -1);
			this.T_FreqRadio1.Text = iniFile.ReadText("DADOS_INSTALACAO_1", "FREQUENCIA_RADIO", "?");
			this.T_Azimute1.Text = iniFile.ReadText("DADOS_INSTALACAO_1", "AZIMUTE", "?");
			this.T_Longitude1.Text = iniFile.ReadText("DADOS_INSTALACAO_1", "LONGITUDE", "?");
			this.T_Latitude1.Text = iniFile.ReadText("DADOS_INSTALACAO_1", "LATITUDE", "?");
			this.T_AlturaAntena1.Text = iniFile.ReadText("DADOS_INSTALACAO_1", "ALTURA_ANTENA", "?");
			this.CB_TipoAntena2.SelectedIndex = iniFile.ReadInteger("DADOS_INSTALACAO_2", "TIPO_ANTENA", -1);
			this.CB_PolarizacaoAntena2.SelectedIndex = iniFile.ReadInteger("DADOS_INSTALACAO_2", "POLARIZACAO_ANTENA", -1);
			this.T_PotRadio2.Text = iniFile.ReadText("DADOS_INSTALACAO_2", "POTENCIA_RADIO", "?");
			this.CB_ModeloRadio2.SelectedIndex = iniFile.ReadInteger("DADOS_INSTALACAO_2", "MODELO_RADIO", -1);
			this.T_FreqRadio2.Text = iniFile.ReadText("DADOS_INSTALACAO_2", "FREQUENCIA_RADIO", "?");
			this.T_Azimute2.Text = iniFile.ReadText("DADOS_INSTALACAO_2", "AZIMUTE", "?");
			this.T_Longitude2.Text = iniFile.ReadText("DADOS_INSTALACAO_2", "LONGITUDE", "?");
			this.T_Latitude2.Text = iniFile.ReadText("DADOS_INSTALACAO_2", "LATITUDE", "?");
			this.T_AlturaAntena2.Text = iniFile.ReadText("DADOS_INSTALACAO_2", "ALTURA_ANTENA", "?");
			this.T_ModeloFonte.Text = iniFile.ReadText("DADOS_INSTALACAO_3", "MODELO_FONTE", "?");
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x002EB1D8 File Offset: 0x002E95D8
		private void Salva_Instalacao(IniFileWriteFast ini)
		{
			ini.WriteSection("DADOS_INSTALACAO_1");
			ini.WriteKey("TIPO_ANTENA", this.CB_TipoAntena1.SelectedIndex);
			ini.WriteKey("POLARIZACAO_ANTENA", this.CB_PolarizacaoAntena1.SelectedIndex);
			ini.WriteKey("POTENCIA_RADIO", this.T_PotRadio1.Text);
			ini.WriteKey("MODELO_RADIO", this.CB_ModeloRadio1.SelectedIndex);
			ini.WriteKey("FREQUENCIA_RADIO", this.T_FreqRadio1.Text);
			ini.WriteKey("AZIMUTE", this.T_Azimute1.Text);
			ini.WriteKey("LONGITUDE", this.T_Longitude1.Text);
			ini.WriteKey("LATITUDE", this.T_Latitude1.Text);
			ini.WriteKey("ALTURA_ANTENA", this.T_AlturaAntena1.Text);
			ini.LineSpace();
			ini.WriteSection("DADOS_INSTALACAO_2");
			ini.WriteKey("TIPO_ANTENA", this.CB_TipoAntena2.SelectedIndex);
			ini.WriteKey("POLARIZACAO_ANTENA", this.CB_PolarizacaoAntena2.SelectedIndex);
			ini.WriteKey("POTENCIA_RADIO", this.T_PotRadio2.Text);
			ini.WriteKey("MODELO_RADIO", this.CB_ModeloRadio2.SelectedIndex);
			ini.WriteKey("FREQUENCIA_RADIO", this.T_FreqRadio2.Text);
			ini.WriteKey("AZIMUTE", this.T_Azimute2.Text);
			ini.WriteKey("LONGITUDE", this.T_Longitude2.Text);
			ini.WriteKey("LATITUDE", this.T_Latitude2.Text);
			ini.WriteKey("ALTURA_ANTENA", this.T_AlturaAntena2.Text);
			ini.LineSpace();
			ini.WriteSection("DADOS_INSTALACAO_3");
			ini.WriteKey("MODELO_FONTE", this.T_ModeloFonte.Text);
			ini.LineSpace();
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x002EB3BC File Offset: 0x002E97BC
		private void ToolStripButton_RT850_Salvar_Click(object sender, EventArgs e)
		{
			int num = 0;
			int num2 = 0;
			object obj = null;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				int[] array = new int[10001];
				this.AtivaEfeitoOnChangeValue();
				this.ControleAtivacaoTeclas(2);
				this.InicializaBarraProgressoTela_RT850(15);
				this.SaveFileDialog_RT850.Filter = "Arquivo de configuração de equipamento|*.Cfg850";
				this.SaveFileDialog_RT850.InitialDirectory = Linha_RT.diretorio;
				if (this.SaveFileDialog_RT850.ShowDialog() == 1)
				{
					if (Operators.CompareString(this.SaveFileDialog_RT850.FileName, "", false) != 0)
					{
						Linha_RT.diretorio = Path.GetDirectoryName(this.SaveFileDialog_RT850.FileName) + "\\";
						string fileName = Path.GetFileName(this.SaveFileDialog_RT850.FileName);
						if (File.Exists(this.SaveFileDialog_RT850.FileName))
						{
							if (File.Exists(this.SaveFileDialog_RT850.FileName + ".old"))
							{
								File.Delete(this.SaveFileDialog_RT850.FileName + ".old");
							}
							File.Move(this.SaveFileDialog_RT850.FileName, this.SaveFileDialog_RT850.FileName + ".old");
						}
						IniFileWriteFast iniFileWriteFast = new IniFileWriteFast(this.SaveFileDialog_RT850.FileName);
						RT_geral.RT_850_BD.Nome_Arquivo = this.SaveFileDialog_RT850.FileName;
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						Application.DoEvents();
						this.Salva_Geral_Informacao(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.Salva_Geral_Msg_Display(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.Salva_Geral_Descricao(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						Application.DoEvents();
						this.Salva_Canal_Radio1(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						Application.DoEvents();
						this.Salva_Canal_Radio2(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						Application.DoEvents();
						this.Salva_Sincronismo_Radio(iniFileWriteFast);
						this.Salva_ConfereResposta_Radio(iniFileWriteFast);
						this.Salva_ModoEstatistica_Radio(iniFileWriteFast);
						this.Salva_FalhaComunicacao(iniFileWriteFast);
						this.Salva_LiberaTeclado(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						Application.DoEvents();
						this.Salva_Equipamentos(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						Application.DoEvents();
						this.Salva_Variaveis(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						Application.DoEvents();
						this.Salva_Msg_Alarme_Cfg(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						Application.DoEvents();
						this.Salva_Controle1(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						this.Salva_Controle4(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						this.Salva_Controle8(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						this.Salva_Vista(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						this.Salva_Instalacao(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						RT_geral.RT_850_BD.Nome_Arquivo = fileName;
						this.Text = "Configuração - CT 850  -> Arquivo : " + RT_geral.RT_850_BD.Nome_Arquivo;
						this.ToolStripProgressBar_RT850.Value = 0;
						this.AtualizaMsgTela_RT850("Arquivo gerado com sucesso!", 0);
						iniFileWriteFast.CloseIniFileWriteFast();
						this.Timer_limpa_MSG_RT850.Enabled = true;
					}
				}
				else
				{
					this.AtualizaMsgTela_RT850("Operação Cancelada", 0);
					this.Timer_limpa_MSG_RT850.Enabled = true;
				}
				goto IL_4D3;
				IL_46E:
				Interaction.MsgBox("Não foi possível gravar os dados", (MsgBoxStyle)32, "Atenção - Erro I/0");
				this.Timer_limpa_MSG_RT850.Enabled = true;
				goto IL_4D3;
				IL_48E:
				num2 = -1;
								IL_4A4:;
			}
			catch (Exception) { }
			throw ProjectData.CreateProjectError(-2146828237);
			IL_4D3:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x002EB8C4 File Offset: 0x002E9CC4
		private void ToolStripButton_RT850_Download_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.Config_sistema.tipo_interface == 1)
			{
				if (Comunicacao.VerificaPortaSerialExiste())
				{
					this.ControleAtivacaoTeclas(4);
					this.EncerraEdicaoDeCampos_RT850();
					this.Leitura_RT850_conf();
				}
				else
				{
					Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
				}
			}
			else if (Comunicacao.Config_sistema.tipo_interface == 2)
			{
				this.ControleAtivacaoTeclas(4);
				this.EncerraEdicaoDeCampos_RT850();
				this.Leitura_RT850_conf();
			}
			else
			{
				Interaction.MsgBox("Não existe definição de tipo de interface de comunicação!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
			}
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x002EB948 File Offset: 0x002E9D48
		private void ToolStripButton_RT850_Upload_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.Config_sistema.tipo_interface == 1)
			{
				if (Comunicacao.VerificaPortaSerialExiste())
				{
					this.ControleAtivacaoTeclas(4);
					this.EncerraEdicaoDeCampos_RT850();
					this.Escrita_RT850_conf();
				}
				else
				{
					Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
				}
			}
			else if (Comunicacao.Config_sistema.tipo_interface == 2)
			{
				this.ControleAtivacaoTeclas(4);
				this.EncerraEdicaoDeCampos_RT850();
				this.Escrita_RT850_conf();
			}
			else
			{
				Interaction.MsgBox("Não existe definição de tipo de interface de comunicação!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
			}
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x002EB9CC File Offset: 0x002E9DCC
		public void Leitura_RT850_conf()
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
			this.InicializaBarraProgressoTela_RT850(72);
			this.AtualizaMsgTela_RT850("Identificação de equipamento - Etapa 1", 2);
			this.ToolStripProgressBar_RT850.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(0, 255, 4).Status)
			{
				this.AtualizaMsgTela_RT850("Equipamento não responde", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Linha_RT.VerificaSeEquipamentoEValido(2, 0, 0, 0, 0, "");
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT850(0, 0);
			if (RT_geral.RT_850_BD.Build.Valor >= 30)
			{
				RT_geral.RT_850_flag_msg_alarme_config = true;
			}
			else
			{
				RT_geral.RT_850_flag_msg_alarme_config = false;
			}
			this.AtualizaMsgTela_RT850("Leitura de configuração - Página 1 - Etapa 2", 2);
			this.ToolStripProgressBar_RT850.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(2048, 255, 60).Status)
			{
				this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT850(2048, 0);
			if (RT_geral.RT_850_flag_msg_alarme_config)
			{
				if (!Mod_MD.Leitura_pagina_multi_interface(12288, RT_geral.RT_850_BD.End_mestre_canal_1.Valor, 100).Status)
				{
					this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT850(12288, 0);
				if (!Mod_MD.Leitura_pagina_multi_interface(12388, RT_geral.RT_850_BD.End_mestre_canal_1.Valor, 100).Status)
				{
					this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT850(12388, 0);
			}
			int num = 0;
			checked
			{
				for (;;)
				{
					this.AtualizaMsgTela_RT850("Leitura de configuração - Página 2 - Etapa " + Conversions.ToString(3 + num), 2);
					this.ToolStripProgressBar_RT850.PerformStep();
					if (!Mod_MD.Leitura_pagina_multi_interface(4096 + num * 110, RT_geral.RT_850_BD.End_mestre_canal_1.Valor, 110).Status)
					{
						break;
					}
					Linha_RT.Atualiza_dados_RT850(4096, num);
					num++;
					if (num > 14)
					{
						goto Block_9;
					}
				}
				this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_9:
				num = 0;
				for (;;)
				{
					this.AtualizaMsgTela_RT850("Leitura de configuração - Página 3 - Etapa " + Conversions.ToString(18 + num), 2);
					this.ToolStripProgressBar_RT850.PerformStep();
					if (!Mod_MD.Leitura_pagina_multi_interface(6144 + num * 110, RT_geral.RT_850_BD.End_mestre_canal_1.Valor, 110).Status)
					{
						break;
					}
					Linha_RT.Atualiza_dados_RT850(6144, num);
					num++;
					if (num > 14)
					{
						goto Block_11;
					}
				}
				this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_11:
				this.InicializaEstrutura_DataGridView_Equipamentos_CTLR_1_RT_850();
				this.InicializaEstrutura_DataGridView_Equipamentos_CTLR_4_RT_850();
				this.InicializaEstrutura_DataGridView_Equipamentos_CTLR_8_RT_850();
				num = 0;
				for (;;)
				{
					this.AtualizaMsgTela_RT850("Leitura de configuração - Página 4 - Etapa " + Conversions.ToString(33 + num), 2);
					this.ToolStripProgressBar_RT850.PerformStep();
					if (!Mod_MD.Leitura_pagina_multi_interface(22528 + num * 120, RT_geral.RT_850_BD.End_mestre_canal_1.Valor, 120).Status)
					{
						break;
					}
					Linha_RT.Atualiza_dados_RT850(22528, num);
					num++;
					if (num > 9)
					{
						goto Block_13;
					}
				}
				this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_13:
				num = 0;
				for (;;)
				{
					this.AtualizaMsgTela_RT850("Leitura de configuração - Página 5 - Etapa " + Conversions.ToString(43 + num), 2);
					this.ToolStripProgressBar_RT850.PerformStep();
					if (!Mod_MD.Leitura_pagina_multi_interface(24576 + num * 115, RT_geral.RT_850_BD.End_mestre_canal_1.Valor, 115).Status)
					{
						break;
					}
					Linha_RT.Atualiza_dados_RT850(24576, num);
					num++;
					if (num > 9)
					{
						goto Block_15;
					}
				}
				this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_15:
				num = 0;
				for (;;)
				{
					this.AtualizaMsgTela_RT850("Leitura de configuração - Página 6 - Etapa " + Conversions.ToString(53 + num), 2);
					this.ToolStripProgressBar_RT850.PerformStep();
					if (!Mod_MD.Leitura_pagina_multi_interface(26624 + num * 78, RT_geral.RT_850_BD.End_mestre_canal_1.Valor, 78).Status)
					{
						break;
					}
					Linha_RT.Atualiza_dados_RT850(26624, num);
					num++;
					if (num > 9)
					{
						goto Block_17;
					}
				}
				this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_17:
				num = 0;
				for (;;)
				{
					this.AtualizaMsgTela_RT850("Leitura de configuração - Página 7 - Etapa " + Conversions.ToString(63 + num), 2);
					this.ToolStripProgressBar_RT850.PerformStep();
					if (!Mod_MD.Leitura_pagina_multi_interface(28672 + num * 57, RT_geral.RT_850_BD.End_mestre_canal_1.Valor, 57).Status)
					{
						break;
					}
					Linha_RT.Atualiza_dados_RT850(28672, num);
					num++;
					if (num > 4)
					{
						goto Block_19;
					}
				}
				this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_19:
				RT_geral.RT_850_BD.Variaveis_Numero.Valor = Linha_RT.Atualiza_Numero_Variaveis_RT850();
				if (RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor > 0)
				{
					RT_geral.RT_850_BD.Vista_selecionado.Indice = 1;
				}
				else
				{
					RT_geral.RT_850_BD.Vista_selecionado.Indice = 0;
				}
				this.Atualiza_TelaRT850();
				this.AtualizaMsgTela_RT850("Configuração lida com sucesso", 0);
				this.ToolStripProgressBar_RT850.PerformStep();
				this.Timer_limpa_MSG_RT850.Enabled = true;
			}
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x002EBEFC File Offset: 0x002EA2FC
		public void InicializaBarraProgressoTela_RT850(int num_passos)
		{
			this.ToolStripProgressBar_RT850.Minimum = 0;
			this.ToolStripProgressBar_RT850.Maximum = 1000;
			this.ToolStripProgressBar_RT850.Step = checked((int)Math.Round(unchecked(1000.0 / (double)num_passos + 1.0)));
			this.ToolStripProgressBar_RT850.Value = 0;
			this.ToolStripProgressBar_RT850.BackColor = Color.LightGray;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x002EBF68 File Offset: 0x002EA368
		public void EncerraEdicaoDeCampos_RT850()
		{
			this.DataGridView_equip_1_RT850.EndEdit();
			this.DataGridView_variaveis_RT850.EndEdit();
			this.DataGridView_Ctrl_1_RT850.EndEdit();
			this.DataGridView_Ctrl_4_RT850.EndEdit();
			this.DataGridView_Ctrl_8_RT850.EndEdit();
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x002EBFA8 File Offset: 0x002EA3A8
		public void Escrita_RT850_conf()
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
			this.InicializaBarraProgressoTela_RT850(85);
			this.AtualizaMsgTela_RT850("Identificação de equipamento - Etapa 1", 0);
			this.ToolStripProgressBar_RT850.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(0, 255, 4).Status)
			{
				this.AtualizaMsgTela_RT850("Equipamento não responde", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Linha_RT.VerificaSeEquipamentoEValido(2, 0, 0, 0, 0, "");
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT850(0, 0);
			if (RT_geral.RT_850_BD.Build.Valor >= 30)
			{
				RT_geral.RT_850_flag_msg_alarme_config = true;
			}
			else
			{
				RT_geral.RT_850_flag_msg_alarme_config = false;
			}
			this.AtualizaMsgTela_RT850("Escrita da configuração - Página 1 - Etapa 2", 2);
			this.ToolStripProgressBar_RT850.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21840);
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			this.ToolStripProgressBar_RT850.PerformStep();
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(2048, 3, 0).Status)
			{
				this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			this.ToolStripProgressBar_RT850.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			if (RT_geral.RT_850_flag_msg_alarme_config)
			{
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				this.ToolStripProgressBar_RT850.PerformStep();
				if (!Mod_MD.Escrita_pagina_RT_multi_interface(12288, 3, 0).Status)
				{
					this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				this.ToolStripProgressBar_RT850.PerformStep();
				if (!Mod_MD.Escrita_pagina_RT_multi_interface(12388, 3, 0).Status)
				{
					this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				this.ToolStripProgressBar_RT850.PerformStep();
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
			}
			this.AtualizaMsgTela_RT850("Escrita da configuração - Página 2 - Etapa 3", 2);
			this.ToolStripProgressBar_RT850.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			int num = 0;
			checked
			{
				for (;;)
				{
					this.AtualizaMsgTela_RT850("Escrita de configuração - Página 2 - Etapa " + Conversions.ToString(4 + num), 2);
					this.ToolStripProgressBar_RT850.PerformStep();
					if (!Mod_MD.Escrita_pagina_RT_multi_interface(4096, 3, num).Status)
					{
						break;
					}
					num++;
					if (num > 14)
					{
						goto Block_14;
					}
				}
				this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_14:
				this.ToolStripProgressBar_RT850.PerformStep();
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				this.AtualizaMsgTela_RT850("Escrita da configuração - Página 3 - Etapa 19", 2);
				this.ToolStripProgressBar_RT850.PerformStep();
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				num = 0;
				for (;;)
				{
					this.AtualizaMsgTela_RT850("Escrita de configuração - Página 3 - Etapa " + Conversions.ToString(20 + num), 2);
					this.ToolStripProgressBar_RT850.PerformStep();
					if (!Mod_MD.Escrita_pagina_RT_multi_interface(6144, 3, num).Status)
					{
						break;
					}
					num++;
					if (num > 14)
					{
						goto Block_18;
					}
				}
				this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_18:
				this.ToolStripProgressBar_RT850.PerformStep();
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				this.AtualizaMsgTela_RT850("Escrita da configuração - Página 11 - Etapa 35", 2);
				this.ToolStripProgressBar_RT850.PerformStep();
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				num = 0;
				for (;;)
				{
					this.AtualizaMsgTela_RT850("Escrita de configuração - Página 11 - Etapa " + Conversions.ToString(36 + num), 2);
					this.ToolStripProgressBar_RT850.PerformStep();
					if (!Mod_MD.Escrita_pagina_RT_multi_interface(22528, 3, num).Status)
					{
						break;
					}
					num++;
					if (num > 9)
					{
						goto Block_22;
					}
				}
				this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_22:
				this.ToolStripProgressBar_RT850.PerformStep();
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				this.AtualizaMsgTela_RT850("Escrita da configuração - Página 12 - Etapa 46", 2);
				this.ToolStripProgressBar_RT850.PerformStep();
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				num = 0;
				for (;;)
				{
					this.AtualizaMsgTela_RT850("Escrita de configuração - Página 12 - Etapa " + Conversions.ToString(47 + num), 2);
					this.ToolStripProgressBar_RT850.PerformStep();
					if (!Mod_MD.Escrita_pagina_RT_multi_interface(24576, 3, num).Status)
					{
						break;
					}
					num++;
					if (num > 9)
					{
						goto Block_26;
					}
				}
				this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_26:
				this.ToolStripProgressBar_RT850.PerformStep();
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				this.AtualizaMsgTela_RT850("Escrita da configuração - Página 13 - Etapa 57", 2);
				this.ToolStripProgressBar_RT850.PerformStep();
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				num = 0;
				for (;;)
				{
					this.AtualizaMsgTela_RT850("Escrita de configuração - Página 13 - Etapa " + Conversions.ToString(58 + num), 2);
					this.ToolStripProgressBar_RT850.PerformStep();
					if (!Mod_MD.Escrita_pagina_RT_multi_interface(26624, 3, num).Status)
					{
						break;
					}
					num++;
					if (num > 9)
					{
						goto Block_30;
					}
				}
				this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_30:
				this.ToolStripProgressBar_RT850.PerformStep();
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				this.AtualizaMsgTela_RT850("Escrita da configuração - Página 14 - Etapa 67", 2);
				this.ToolStripProgressBar_RT850.PerformStep();
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				num = 0;
				for (;;)
				{
					this.AtualizaMsgTela_RT850("Escrita de configuração - Página 14 - Etapa " + Conversions.ToString(68 + num), 2);
					this.ToolStripProgressBar_RT850.PerformStep();
					if (!Mod_MD.Escrita_pagina_RT_multi_interface(28672, 3, num).Status)
					{
						break;
					}
					num++;
					if (num > 4)
					{
						goto Block_34;
					}
				}
				this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_34:
				this.ToolStripProgressBar_RT850.PerformStep();
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21920);
				this.AtualizaMsgTela_RT850("Escrita realizada com sucesso", 0);
				this.ToolStripProgressBar_RT850.PerformStep();
				this.Timer_limpa_MSG_RT850.Enabled = true;
			}
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x002EC7E4 File Offset: 0x002EABE4
		private void TextBox_msg_inicial_RT850_TextChanged(object sender, EventArgs e)
		{
			int num = 0;
			int num2 = 0;
			object obj = null;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				RT_geral.RT_850_BD.Msg_linha_1.Valor = Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(sender, null, "lines", new object[]
				{
					0
				}, null, null, null)));
				RT_geral.RT_850_BD.Msg_linha_2.Valor = Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(sender, null, "lines", new object[]
				{
					1
				}, null, null, null)));
				RT_geral.RT_850_BD.Msg_linha_3.Valor = Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(sender, null, "lines", new object[]
				{
					2
				}, null, null, null)));
				RT_geral.RT_850_BD.Msg_linha_4.Valor = Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(sender, null, "lines", new object[]
				{
					3
				}, null, null, null)));
				IL_EB:
				goto IL_12E;
				IL_ED:
				num2 = -1;
								IL_101:;
			}
			catch (Exception) { }
			throw ProjectData.CreateProjectError(-2146828237);
			IL_12E:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x002EC944 File Offset: 0x002EAD44
		private void Button1_Click(object sender, EventArgs e)
		{
			int num = 0;
			int num2 = 0;
			checked
			{
				do
				{
					RT_geral.Variaveis_RT_850[num2].Nome.Valor = "Var " + Conversions.ToString(num2 + 1);
					RT_geral.Variaveis_RT_850[num2].Dsp_pos.Indice = num % 5;
					RT_geral.Variaveis_RT_850[num2].Dsp_tela.Valor = num / 4;
					RT_geral.Variaveis_RT_850[num2].Escala_fim.Valor = 3000 + num2;
					RT_geral.Variaveis_RT_850[num2].Escala_ini.Valor = num2;
					RT_geral.Variaveis_RT_850[num2].Msg_alm_1.Indice = num % 2;
					RT_geral.Variaveis_RT_850[num2].Msg_alm_2.Indice = num % 4;
					RT_geral.Variaveis_RT_850[num2].Nivel_alm_1.Valor = 1000 + num2;
					RT_geral.Variaveis_RT_850[num2].Nivel_alm_2.Valor = 2000 + num2;
					RT_geral.Variaveis_RT_850[num2].Pto_dec_fim.Indice = num % 3;
					RT_geral.Variaveis_RT_850[num2].Pto_dec_ini.Indice = 0;
					RT_geral.Variaveis_RT_850[num2].Tipo_alm_1.Indice = 0;
					RT_geral.Variaveis_RT_850[num2].Tipo_alm_2.Indice = 1;
					num++;
					num2++;
				}
				while (num2 <= 299);
				RT_geral.RT_850_BD.Variaveis_Numero.Valor = 300;
				RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor = 80;
				num2 = 0;
				do
				{
					RT_geral.RT_850_Ctrl_1[num2].Nome.Valor = "RT810 " + Conversions.ToString(num2 + 1);
					RT_geral.RT_850_Ctrl_1[num2].Canal.Indice = num2 % 2;
					RT_geral.RT_850_Ctrl_1[num2].Comando.Valor = num2 % 2;
					RT_geral.RT_850_Ctrl_1[num2].Modelo.Indice = num2 % 18;
					RT_geral.RT_850_Ctrl_1[num2].Prioridade.Valor = num2 % 7;
					int num3 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_1[num2].Ref[num3].Indice = (num2 + num3) % 100 + 1;
						num3++;
					}
					while (num3 <= 3);
					num3 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_1[num2].Var[num3].Indice = (num2 + num3) % 100 + 1;
						num3++;
					}
					while (num3 <= 3);
					num2++;
				}
				while (num2 <= 79);
				RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor = 50;
				num2 = 0;
				do
				{
					RT_geral.RT_850_Ctrl_4[num2].Nome.Valor = "RT820 " + Conversions.ToString(num2 + 1);
					RT_geral.RT_850_Ctrl_4[num2].Canal.Indice = num2 % 2;
					RT_geral.RT_850_Ctrl_4[num2].Comando.Valor = num2 % 2;
					RT_geral.RT_850_Ctrl_4[num2].Modelo.Indice = num2 % 14;
					RT_geral.RT_850_Ctrl_4[num2].Prioridade.Valor = num2 % 7;
					int num3 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_4[num2].Ref[num3].Indice = (num2 + num3) % 100 + 1;
						num3++;
					}
					while (num3 <= 3);
					num3 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_4[num2].Var[num3].Indice = (num2 + num3) % 100 + 1;
						num3++;
					}
					while (num3 <= 3);
					num2++;
				}
				while (num2 <= 49);
				RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor = 20;
				num2 = 0;
				do
				{
					RT_geral.RT_850_Ctrl_8[num2].Nome.Valor = "RT821 " + Conversions.ToString(num2 + 1);
					RT_geral.RT_850_Ctrl_8[num2].Canal.Indice = num2 % 2;
					RT_geral.RT_850_Ctrl_8[num2].Comando.Valor = num2 % 2;
					RT_geral.RT_850_Ctrl_8[num2].Modelo.Indice = num2 % 7;
					RT_geral.RT_850_Ctrl_8[num2].Prioridade.Valor = num2 % 7;
					int num3 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_8[num2].Ref[num3].Indice = (num2 + num3) % 100 + 1;
						num3++;
					}
					while (num3 <= 3);
					num3 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_8[num2].Var[num3].Indice = (num2 + num3) % 100 + 1;
						num3++;
					}
					while (num3 <= 15);
					num3 = 0;
					do
					{
						RT_geral.RT_850_Ctrl_8[num2].Periferico_Modelo[num3].Indice = num3 % 5;
						RT_geral.RT_850_Ctrl_8[num2].Periferico_Indice[num3].Indice = num3 % 5;
						num3++;
					}
					while (num3 <= 4);
					num2++;
				}
				while (num2 <= 19);
			}
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x002ECE10 File Offset: 0x002EB210
		private void NumericUpDown_end_1_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.End_mestre_canal_1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_850_BD.End_mestre_canal_1, true);
			sender = numericUpDown;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x002ECE64 File Offset: 0x002EB264
		private void NumericUpDown_end_2_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.End_mestre_canal_2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_850_BD.End_mestre_canal_2, true);
			sender = numericUpDown;
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x002ECEB8 File Offset: 0x002EB2B8
		private void NumericUpDown_intervalo_leitura_1_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.Intervalo_leitura_canal_1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_850_BD.Intervalo_leitura_canal_1, true);
			sender = numericUpDown;
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x002ECF0C File Offset: 0x002EB30C
		private void NumericUpDown_intervalo_leitura_2_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.Intervalo_leitura_canal_2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_850_BD.Intervalo_leitura_canal_2, true);
			sender = numericUpDown;
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x002ECF60 File Offset: 0x002EB360
		private void NumericUpDown_timeout_1_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.Timeout_canal_1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_850_BD.Timeout_canal_1, true);
			sender = numericUpDown;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x002ECFB4 File Offset: 0x002EB3B4
		private void NumericUpDown_timeout_2_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.Timeout_canal_2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_850_BD.Timeout_canal_2, true);
			sender = numericUpDown;
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x002ED008 File Offset: 0x002EB408
		private void NumericUpDown_temp_ptt_1_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.Tempo_ptt_canal_1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_850_BD.Tempo_ptt_canal_1, true);
			sender = numericUpDown;
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x002ED05C File Offset: 0x002EB45C
		private void NumericUpDown_temp_ptt_2_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.Tempo_ptt_canal_2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_850_BD.Tempo_ptt_canal_2, true);
			sender = numericUpDown;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x002ED0B0 File Offset: 0x002EB4B0
		private void NumericUpDown_num_tentativas_1_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.Numero_tentativas_canal_1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_850_BD.Numero_tentativas_canal_1, true);
			sender = numericUpDown;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x002ED104 File Offset: 0x002EB504
		private void NumericUpDown_num_tentativas_2_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.Numero_tentativas_canal_2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_850_BD.Numero_tentativas_canal_2, true);
			sender = numericUpDown;
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x002ED158 File Offset: 0x002EB558
		private void NumericUpDown_num_erro_falha_1_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.Numero_erros_falha_canal_1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_850_BD.Numero_erros_falha_canal_1, true);
			sender = numericUpDown;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x002ED1AC File Offset: 0x002EB5AC
		private void NumericUpDown_num_erro_falha_2_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.Numero_erros_falha_canal_2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_850_BD.Numero_erros_falha_canal_2, true);
			sender = numericUpDown;
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x002ED200 File Offset: 0x002EB600
		private void ComboBox_baudrate_1_RT850_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.BaudRate_canal_1.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_850_BD.BaudRate_canal_1.Valor = RT_geral.RT_850_BD.BaudRate_canal_1.valores[RT_geral.RT_850_BD.BaudRate_canal_1.Indice];
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x002ED264 File Offset: 0x002EB664
		private void ComboBox_baudrate_2_RT850_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.BaudRate_canal_2.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_850_BD.BaudRate_canal_2.Valor = RT_geral.RT_850_BD.BaudRate_canal_2.valores[RT_geral.RT_850_BD.BaudRate_canal_2.Indice];
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x002ED2C8 File Offset: 0x002EB6C8
		private void CheckBox_sincronismo_RT850_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null), true, false))
			{
				RT_geral.RT_850_BD.Sincronismo.Valor = 21857;
			}
			else
			{
				RT_geral.RT_850_BD.Sincronismo.Valor = 21856;
			}
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x002ED324 File Offset: 0x002EB724
		private void Button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x002ED328 File Offset: 0x002EB728
		private void ToolStri_RT850_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x002ED32C File Offset: 0x002EB72C
		private void ToolStripButton_RT850_Imprimir_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			using (EnhancedPrintPreviewDialog enhancedPrintPreviewDialog = new EnhancedPrintPreviewDialog())
			{
				enhancedPrintPreviewDialog.Document = this.PrintDocument1;
				enhancedPrintPreviewDialog.ShowDialog();
			}
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x002ED374 File Offset: 0x002EB774
		private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
		{
			this.pagina_impressao = 1;
			this.grupo_impressao = 1;
			this.quantos_imprimiu = 0;
			this.quantos_imprimiu2 = 0;
			this.quantos_imprimiu3 = 0;
			this.quantos_imprimiu4 = 0;
			this.inicio = 5;
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x002ED3A8 File Offset: 0x002EB7A8
		private void PrintDocument1_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
		{
			e.PageSettings.Landscape = true;
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x002ED3B8 File Offset: 0x002EB7B8
		[MethodImpl(72)]
		private bool DesenhaRelatorioRT821Grupo1(PrintPageEventArgs z)
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_850_BD.Equip.Valor, RT_geral.RT_850_BD.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 4, "Dados da Estação", true);
			tabelaLinhaInteria.EscreveTituloValorLinha(1, "Local de Instalação", this.TextBox_nome_RT850.Text, 0, 160);
			tabelaLinhaInteria.EscreveTituloValorLinha(2, "Endereço", this.TextBox_endereco_RT850.Text, 0, 90);
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Modelo Simulado", "CT850", 0, 0);
			string valor = "iS800 (" + MyProject.Application.Info.Version.ToString() + ")";
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Configurador", valor, 250, 0);
			string valor2 = string.Concat(new string[]
			{
				"CT",
				RT_geral.RT_850_BD.Equip.Valor.ToString(),
				"_",
				RT_geral.RT_850_BD.Versao.Valor.ToString(),
				string.Format("{0:D2}", RT_geral.RT_850_BD.Build.Valor),
				"  R",
				RT_geral.RT_850_BD.Release.Valor.ToString()
			});
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Firmware", valor2, 500, 0);
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Data", string.Concat(new string[]
			{
				DateTime.Today.Day.ToString(),
				"/",
				DateTime.Today.Month.ToString(),
				"/",
				DateTime.Today.Year.ToString()
			}), 850, 0);
			tabelaLinhaInteria.EscreveTituloValorLinha(4, "Arquivo", Path.GetFileName(RT_geral.RT_850_BD.Nome_Arquivo), 0, 0);
			int nextLineAvailable = tabelaLinhaInteria.GetNextLineAvailable();
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 5, "Dados de Instalação Antena 1", true);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(1, "Tipo de antena", this.CB_TipoAntena1.Text, 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(1, "Azimute", this.T_Azimute1.Text + " °", 280, 500);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(2, "Polarização", this.CB_PolarizacaoAntena1.Text, 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(2, "Longitude", this.T_Longitude1.Text, 280, 500);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(3, "Potência do Rádio", this.T_PotRadio1.Text + " W", 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(3, "Latidude", this.T_Latitude1.Text, 280, 500);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(4, "Modelo do Rádio", this.CB_ModeloRadio1.Text, 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(4, "Altura", this.T_AlturaAntena1.Text + " m", 280, 500);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(5, "Frequência do Rádio", this.T_FreqRadio1.Text + " MHz", 0, 150);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 5, "Dados de Instalação Antena 2", true);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(1, "Tipo de antena", this.CB_TipoAntena2.Text, 0, 150);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(1, "Azimute", this.T_Azimute2.Text + " °", 280, 500);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(2, "Polarização", this.CB_PolarizacaoAntena2.Text, 0, 150);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(2, "Longitude", this.T_Longitude2.Text, 280, 500);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(3, "Potência do Rádio", this.T_PotRadio2.Text + " W", 0, 150);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(3, "Latidude", this.T_Latitude2.Text, 280, 500);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(4, "Modelo do Rádio", this.CB_ModeloRadio2.Text, 0, 150);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(4, "Altura", this.T_AlturaAntena2.Text + " m", 280, 500);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(5, "Frequência do Rádio", this.T_FreqRadio2.Text + " MHz", 0, 150);
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda.GetNextLineAvailable(), 7, "Canal de Rádio 1", true);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(1, "Endereço Mestre", RT_geral.RT_850_BD.End_mestre_canal_1.Valor.ToString(), 0, 0);
			string valor3 = perifericos.ListaBaudRate[RT_geral.RT_850_BD.BaudRate_canal_1.Indice].nome_impressao;
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(2, "Baud Rate", valor3, 0, 0);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(3, "Intervalo de Leitura", RT_geral.RT_850_BD.Intervalo_leitura_canal_1.Valor.ToString(), 0, 0);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(4, "Tempo de Espera Resposta", RT_geral.RT_850_BD.Timeout_canal_1.Valor.ToString(), 0, 0);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(5, "Tempo de PTT (ms)", RT_geral.RT_850_BD.Tempo_ptt_canal_1.Valor.ToString(), 0, 0);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(6, "Número de Tentativas", RT_geral.RT_850_BD.Numero_tentativas_canal_1.Valor.ToString(), 0, 0);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(7, "Número de Erros para Falha", RT_geral.RT_850_BD.Numero_erros_falha_canal_1.Valor.ToString(), 0, 0);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita2 = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda.GetNextLineAvailable(), 7, "Canal de Rádio 2", true);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(1, "Endereço Mestre", RT_geral.RT_850_BD.End_mestre_canal_2.Valor.ToString(), 0, 0);
			valor3 = perifericos.ListaBaudRate[RT_geral.RT_850_BD.BaudRate_canal_2.Indice].nome_impressao;
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(2, "Baud Rate", valor3, 0, 0);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(3, "Intervalo de Leitura", RT_geral.RT_850_BD.Intervalo_leitura_canal_2.Valor.ToString(), 0, 0);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(4, "Tempo de Espera Resposta", RT_geral.RT_850_BD.Timeout_canal_2.Valor.ToString(), 0, 0);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(5, "Tempo de PTT (ms)", RT_geral.RT_850_BD.Tempo_ptt_canal_2.Valor.ToString(), 0, 0);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(6, "Número de Tentativas", RT_geral.RT_850_BD.Numero_tentativas_canal_2.Valor.ToString(), 0, 0);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(7, "Número de Erros para Falha", RT_geral.RT_850_BD.Numero_erros_falha_canal_2.Valor.ToString(), 0, 0);
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda3 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda2.GetNextLineAvailable(), 3, "Modo de operção dos canais", true);
			valor3 = "???";
			switch (RT_geral.RT_850_BD.Sincronismo.Valor)
			{
			case 21856:
				valor3 = "Não";
				break;
			case 21857:
				valor3 = "Sim";
				break;
			}
			tabelaMeiaLinhaEsquerda3.EscreveTituloValorLinha(1, "Sincronizar", valor3, 0, 0);
			if (RT_geral.RT_850_BD.ConfereResposta.Valor == 1)
			{
				valor3 = "Sim";
			}
			else
			{
				valor3 = "Não";
			}
			tabelaMeiaLinhaEsquerda3.EscreveTituloValorLinha(2, "Confere resposta (tamanho)", valor3, 0, 0);
			if (RT_geral.RT_850_BD.Modo_Estatistica.Valor == 1)
			{
				valor3 = "Sim";
			}
			else
			{
				valor3 = "Não";
			}
			tabelaMeiaLinhaEsquerda3.EscreveTituloValorLinha(3, "Estatística CORSAN", valor3, 0, 0);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita3 = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaDireita2.GetNextLineAvailable(), 2, "Envio para Falha de Comunicação", true);
			tabelaMeiaLinhaDireita3.EscreveTituloValorLinha(1, "Remota", this.cb_remota.Text, 0, 0);
			tabelaMeiaLinhaDireita3.EscreveTituloValorLinha(2, "Supervisório", this.cb_supervisorio.Text, 0, 0);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita4 = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaDireita3.GetNextLineAvailable(), 1, "Operação de Teclado com Supervisório", false);
			if (RT_geral.RT_850_BD.LiberaTeclado.Valor == 1)
			{
				valor3 = "Sim";
			}
			else
			{
				valor3 = "Não";
			}
			tabelaMeiaLinhaDireita4.EscreveTituloValorLinha(1, "Permite", valor3, 0, 0);
			FontesTabela fonte3;
			fonte3.Titulo = font2;
			fonte3.Variavel = font2;
			fonte3.Valor = font2;
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita5 = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte3, cores, tabelaMeiaLinhaDireita4.GetNextLineAvailable(), 5, "Mensagem Inical Display", false);
			tabelaMeiaLinhaDireita5.EscreveValorLinha(2, RT_geral.RT_850_BD.Msg_linha_1.Valor, 50);
			tabelaMeiaLinhaDireita5.EscreveValorLinha(3, RT_geral.RT_850_BD.Msg_linha_2.Valor, 50);
			tabelaMeiaLinhaDireita5.EscreveValorLinha(4, RT_geral.RT_850_BD.Msg_linha_3.Valor, 50);
			tabelaMeiaLinhaDireita5.EscreveValorLinha(5, RT_geral.RT_850_BD.Msg_linha_4.Valor, 50);
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda4 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda3.GetNextLineAvailable(), 5, "Lista de Equipamentos", true);
			tabelaMeiaLinhaEsquerda4.EscreveTituloLinha(1, "Equip.", 0);
			tabelaMeiaLinhaEsquerda4.EscreveTituloLinha(1, "Quantidade", 150);
			tabelaMeiaLinhaEsquerda4.EscreveTituloLinha(1, "End Inicial", 300);
			string[] array = new string[]
			{
				"Ctrl 1",
				"Ctrl 4",
				"Ctrl 8",
				"Vista"
			};
			RT_geral.Integer_ictel[] array2 = new RT_geral.Integer_ictel[]
			{
				RT_geral.RT_850_BD.Numero_equip_tipo_1,
				RT_geral.RT_850_BD.Numero_equip_tipo_2,
				RT_geral.RT_850_BD.Numero_equip_tipo_3,
				RT_geral.RT_850_BD.Numero_equip_tipo_vista
			};
			RT_geral.Integer_ictel[] array3 = new RT_geral.Integer_ictel[]
			{
				RT_geral.RT_850_BD.End_inicial_equip_tipo_1,
				RT_geral.RT_850_BD.End_inicial_equip_tipo_2,
				RT_geral.RT_850_BD.End_inicial_equip_tipo_3,
				RT_geral.RT_850_BD.End_inicial_equip_tipo_vista
			};
			int num = 0;
			checked
			{
				do
				{
					tabelaMeiaLinhaEsquerda4.EscreveTituloLinha(num + 2, array[num], 0);
					tabelaMeiaLinhaEsquerda4.EscreveValorLinha(num + 2, array2[num].Valor.ToString(), 155);
					tabelaMeiaLinhaEsquerda4.EscreveValorLinha(num + 2, array3[num].Valor.ToString(), 305);
					num++;
				}
				while (num <= 3);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
				this.grupo_impressao++;
				this.pagina_impressao++;
				return true;
			}
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x002EE014 File Offset: 0x002EC414
		private bool DesenhaRelatorioRT821Grupo2e3(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, 3);
			Font font2 = new Font("Calibri", 10f, 3, (FontStyle)3);
			Font font3 = new Font("Calibri", 10f, 0, (FontStyle)3);
			Font fonte = new Font("Calibri", 20f, 1, (FontStyle)3);
			Font valor = new Font("Calibri", 8f, 0, (FontStyle)3);
			Font font4 = new Font("5x8 LCD HD44780U A02", 14f, 0, (FontStyle)3);
			Pen pen = new Pen(Color.Black, 2f);
			bool flag = false;
			int num = 5;
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_850_BD.Equip.Valor, RT_geral.RT_850_BD.Versao.Valor);
			checked
			{
				int num2 = (z.MarginBounds.Bottom - z.MarginBounds.Top) / fonte2.Variavel.Height - 5;
				if (this.grupo_impressao == 2)
				{
					int valor2 = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
					if (valor2 >= 0)
					{
						TabelaLinhaInteria tabelaLinhaInteria;
						if (this.quantos_imprimiu == 0)
						{
							tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 2, "Variáveis", false);
						}
						else
						{
							tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 2, "Variáveis - Continuação", false);
						}
						string text = "\r\nVar.";
						string text2 = "\r\nNome";
						string text3 = "Escala\r\nInício";
						string text4 = "Escala\r\nFim";
						string text5 = "Escala\r\nTratamento";
						string text6 = "Ponto\r\nDecimal";
						string text7 = "Nível\r\nAlarme1";
						string text8 = "Tipo\r\nAlarme1";
						string text9 = "Mensagem\r\nAlarme1";
						string text10 = "Nível\r\nAlarme2";
						string text11 = "Tipo\r\nAlarme2";
						string text12 = "Mensagem\r\nAlarme2";
						string text13 = "Número\r\nTela";
						string text14 = "Posição\r\nDisplay";
						int[] array = new int[]
						{
							0,
							30,
							110,
							150,
							190,
							270,
							350,
							420,
							500,
							600,
							670,
							730,
							840,
							900
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
							text14
						};
						TabelaLinhaInteria tabelaLinhaInteria2 = tabelaLinhaInteria;
						int num3 = 1;
						tabelaLinhaInteria2.EscreveTodosTitulos(ref num3, titulos, array);
						int num4 = this.quantos_imprimiu + num2;
						if (num4 > valor2)
						{
							num4 = valor2;
						}
						int num5 = this.quantos_imprimiu;
						int num6 = num4 - 1;
						for (int i = num5; i <= num6; i++)
						{
							tabelaLinhaInteria.AdicionaLinha();
							int num7 = i - this.quantos_imprimiu;
							string text15 = string.Format("{0:D3}", i + 1);
							tabelaLinhaInteria.EscreveTituloLinha(num7 + 3, text15, array[0]);
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, RT_geral.Variaveis_RT_850[i].Nome.Valor, array[1] + 5);
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, Conversions.ToString(RT_geral.Variaveis_RT_850[i].Escala_ini.Valor), array[2] + 10);
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, Conversions.ToString(RT_geral.Variaveis_RT_850[i].Escala_fim.Valor), array[3] + 5);
							text15 = "???";
							switch (RT_geral.Variaveis_RT_850[i].Escala_tratamento.Valor)
							{
							case 0:
								text15 = "Nenhum";
								break;
							case 1:
								text15 = "Nível";
								break;
							}
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text15, array[4] + 5);
							text15 = "???";
							if (RT_geral.Variaveis_RT_850[i].Pto_dec_ini.Valor == 0 & RT_geral.Variaveis_RT_850[i].Pto_dec_fim.Valor == 0)
							{
								text15 = "    0";
							}
							else if (RT_geral.Variaveis_RT_850[i].Pto_dec_ini.Valor == 0 & RT_geral.Variaveis_RT_850[i].Pto_dec_fim.Valor == 1)
							{
								text15 = "  0.0";
							}
							else if (RT_geral.Variaveis_RT_850[i].Pto_dec_ini.Valor == 0 & RT_geral.Variaveis_RT_850[i].Pto_dec_fim.Valor == 2)
							{
								text15 = " 0.00";
							}
							else if (RT_geral.Variaveis_RT_850[i].Pto_dec_ini.Valor == 0 & RT_geral.Variaveis_RT_850[i].Pto_dec_fim.Valor == 3)
							{
								text15 = "0.000";
							}
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text15, array[5] + 5);
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, Conversions.ToString(RT_geral.Variaveis_RT_850[i].Nivel_alm_1.Valor), array[6] + 5);
							text15 = "???";
							switch (RT_geral.Variaveis_RT_850[i].Tipo_alm_1.Valor)
							{
							case 0:
								text15 = "Baixo";
								break;
							case 1:
								text15 = "Alto";
								break;
							}
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text15, array[7] + 5);
							text15 = "???";
							switch (RT_geral.Variaveis_RT_850[i].Msg_alm_1.Valor)
							{
							case 0:
								text15 = "Arrombamento";
								break;
							case 1:
								text15 = "Falta de Fase";
								break;
							case 2:
								text15 = "Alagamento";
								break;
							case 3:
								text15 = "Fora do Ar";
								break;
							case 4:
								text15 = "TESTE";
								break;
							}
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text15, array[8] + 5);
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, Conversions.ToString(RT_geral.Variaveis_RT_850[i].Nivel_alm_2.Valor), array[9] + 5);
							text15 = "???";
							switch (RT_geral.Variaveis_RT_850[i].Tipo_alm_2.Valor)
							{
							case 0:
								text15 = "Baixo";
								break;
							case 1:
								text15 = "Alto";
								break;
							}
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text15, array[10] + 5);
							text15 = "???";
							switch (RT_geral.Variaveis_RT_850[i].Msg_alm_2.Valor)
							{
							case 0:
								text15 = "Arrombamento";
								break;
							case 1:
								text15 = "Falta de Fase";
								break;
							case 2:
								text15 = "Alagamento";
								break;
							case 3:
								text15 = "Fora do Ar";
								break;
							case 4:
								text15 = "TESTE";
								break;
							}
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text15, array[11] + 5);
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, RT_geral.Variaveis_RT_850[i].Dsp_tela.Valor.ToString(), array[12] + 10);
							text15 = "???";
							switch (RT_geral.Variaveis_RT_850[i].Dsp_pos.Valor)
							{
							case 0:
								text15 = "-----";
								break;
							case 1:
							case 2:
							case 3:
							case 4:
								text15 = string.Format("Linha {0}", RT_geral.Variaveis_RT_850[i].Dsp_pos.Valor);
								break;
							}
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text15, array[13] + 5);
						}
						this.quantos_imprimiu += num2;
						if (this.quantos_imprimiu >= valor2)
						{
							this.quantos_imprimiu = 0;
							this.grupo_impressao++;
							flag = false;
							num = tabelaLinhaInteria.GetNextLineAvailable();
							if (num >= 25)
							{
								flag = true;
							}
						}
						else
						{
							flag = true;
						}
					}
				}
				if (this.grupo_impressao == 3 & !flag)
				{
					int valor2 = RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor;
					if (valor2 >= 0)
					{
						fonte2.Valor = valor;
						TabelaLinhaInteria tabelaLinhaInteria3;
						if (this.quantos_imprimiu == 0)
						{
							tabelaLinhaInteria3 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, num, 2, "Ctrl 01", false);
						}
						else
						{
							tabelaLinhaInteria3 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, num, 2, "Ctrl 01 - Continuação", false);
						}
						string text16 = "\r\nEnd.";
						string text17 = "\r\nNome";
						string text18 = "Ca-\r\nnal";
						string text19 = "Time\r\nOut";
						string text20 = "\r\nCmd";
						string text21 = "Priori-\r\ndade";
						string text22 = "\r\nModelo";
						string text23 = "CTRL1\r\nMsg";
						string text24 = "\r\nNº";
						string text25 = "\r\nVar 1";
						string text26 = "\r\nVar 2";
						string text27 = "\r\nVar 3";
						string text28 = "\r\nVar 4";
						string text29 = "\r\nRef 1";
						string text30 = "\r\nRef 2";
						string text31 = "\r\nRef 3";
						string text32 = "\r\nRef 4";
						int[] array2 = new int[]
						{
							0,
							40,
							110,
							145,
							180,
							230,
							275,
							355,
							415,
							440,
							505,
							570,
							635,
							700,
							765,
							830,
							900
						};
						string[] titulos2 = new string[]
						{
							text16,
							text17,
							text18,
							text19,
							text20,
							text21,
							text22,
							text23,
							text24,
							text25,
							text26,
							text27,
							text28,
							text29,
							text30,
							text31,
							text32
						};
						TabelaLinhaInteria tabelaLinhaInteria4 = tabelaLinhaInteria3;
						int num3 = 1;
						tabelaLinhaInteria4.EscreveTodosTitulos(ref num3, titulos2, array2);
						if (num != 5)
						{
							num2 -= num;
						}
						int num4 = this.quantos_imprimiu + num2;
						if (num4 > valor2)
						{
							num4 = valor2;
						}
						int num8 = this.quantos_imprimiu;
						int num9 = num4 - 1;
						for (int i = num8; i <= num9; i++)
						{
							tabelaLinhaInteria3.AdicionaLinha();
							int num7 = i - this.quantos_imprimiu;
							string text15 = string.Format("{0:D3}", RT_geral.RT_850_BD.End_inicial_equip_tipo_1.Valor + i);
							tabelaLinhaInteria3.EscreveTituloLinha(num7 + 3, text15, array2[0]);
							tabelaLinhaInteria3.EscreveValorLinha(num7 + 3, RT_geral.RT_850_Ctrl_1[i].Nome.Valor, array2[1] + 5);
							text15 = string.Format("{0}", RT_geral.RT_850_Ctrl_1[i].Canal.Indice + 1);
							tabelaLinhaInteria3.EscreveValorLinha(num7 + 3, text15, array2[2] + 10);
							text15 = string.Format("{0}", RT_geral.RT_850_Ctrl_1[i].Timeout.Indice + 1);
							tabelaLinhaInteria3.EscreveValorLinha(num7 + 3, text15, array2[3] + 10);
							text15 = "???";
							switch (RT_geral.RT_850_Ctrl_1[i].Comando.Indice)
							{
							case 0:
								text15 = "Desab.";
								break;
							case 1:
								text15 = "Lib.";
								break;
							case 2:
								text15 = "Bloq.";
								break;
							}
							tabelaLinhaInteria3.EscreveValorLinha(num7 + 3, text15, array2[4] + 10);
							text15 = "???";
							switch (RT_geral.RT_850_Ctrl_1[i].Prioridade.Indice)
							{
							case 0:
								text15 = "Desab.";
								break;
							case 1:
							case 2:
							case 3:
							case 4:
							case 5:
							case 6:
							case 7:
								text15 = string.Format("{0}", RT_geral.RT_850_Ctrl_1[i].Prioridade.Indice);
								break;
							}
							tabelaLinhaInteria3.EscreveValorLinha(num7 + 3, text15, array2[5] + 10);
							text15 = "???";
							switch (RT_geral.RT_850_Ctrl_1[i].Modelo.Indice)
							{
							case 0:
								text15 = "N.Def";
								break;
							case 1:
								text15 = "RT810 010";
								break;
							case 2:
								text15 = "RT810 200";
								break;
							case 3:
								text15 = "RT810 300";
								break;
							case 6:
								text15 = "RT820 010";
								break;
							case 7:
								text15 = "RT820 200";
								break;
							case 8:
								text15 = "RT820 300";
								break;
							case 9:
								text15 = "RT820 350";
								break;
							case 11:
								text15 = "RT821 010";
								break;
							case 12:
								text15 = "RT821 200";
								break;
							case 13:
								text15 = "RT821 300";
								break;
							case 14:
								text15 = "RT821 400";
								break;
							case 16:
								text15 = "VA310 42";
								break;
							case 17:
								text15 = "VA310 50";
								break;
							case 18:
								text15 = "VA320 35";
								break;
							case 19:
								text15 = "VA320 50";
								break;
							case 20:
								text15 = "VA220 42";
								break;
							case 21:
								text15 = "VA220 50";
								break;
							case 23:
								text15 = "MD101 43";
								break;
							case 24:
								text15 = "MD101 4000";
								break;
							case 28:
								text15 = "MD202 520";
								break;
							}
							tabelaLinhaInteria3.EscreveValorLinha(num7 + 3, text15, array2[6] + 5);
							text15 = "???";
							switch (RT_geral.RT_850_Ctrl_1[i].Crtl_nome[0].Indice)
							{
							case 0:
								text15 = "Controle";
								break;
							case 1:
								text15 = "Motor";
								break;
							case 2:
								text15 = "Válvula";
								break;
							}
							tabelaLinhaInteria3.EscreveValorLinha(num7 + 3, text15, array2[7] + 5);
							tabelaLinhaInteria3.EscreveValorLinha(num7 + 3, RT_geral.RT_850_Ctrl_1[i].Crtl_indice[0].Valor.ToString(), array2[8] + 5);
							int num10 = 0;
							do
							{
								int indice = RT_geral.RT_850_Ctrl_1[i].Var[num10].Indice;
								if (indice == 0)
								{
									tabelaLinhaInteria3.EscreveValorLinha(num7 + 3, "---", array2[9 + num10] + 5);
								}
								else
								{
									tabelaLinhaInteria3.EscreveValorLinha(num7 + 3, RT_geral.Variaveis_RT_850[indice - 1].Nome.Valor, array2[9 + num10] + 5);
								}
								indice = RT_geral.RT_850_Ctrl_1[i].Ref[num10].Indice;
								if (indice == 0)
								{
									tabelaLinhaInteria3.EscreveValorLinha(num7 + 3, "---", array2[13 + num10] + 5);
								}
								else
								{
									tabelaLinhaInteria3.EscreveValorLinha(num7 + 3, RT_geral.Variaveis_RT_850[indice - 1].Nome.Valor, array2[13 + num10] + 5);
								}
								num10++;
							}
							while (num10 <= 3);
						}
						this.quantos_imprimiu += num2;
						if (this.quantos_imprimiu >= valor2)
						{
							this.quantos_imprimiu = 0;
							this.grupo_impressao = 4;
							flag = true;
							num = tabelaLinhaInteria3.GetNextLineAvailable();
						}
						else
						{
							flag = true;
						}
					}
				}
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
				this.pagina_impressao++;
				return flag;
			}
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x002EEFE8 File Offset: 0x002ED3E8
		private bool DesenhaRelatorioRT821Grupo4e5(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, 3);
			Font font2 = new Font("Calibri", 10f, 3, (FontStyle)3);
			Font font3 = new Font("Calibri", 10f, 0, (FontStyle)3);
			Font valor = new Font("Calibri", 8f, 0, (FontStyle)3);
			Font fonte = new Font("Calibri", 20f, 1, (FontStyle)3);
			Font font4 = new Font("5x8 LCD HD44780U A02", 14f, 0, (FontStyle)3);
			Pen pen = new Pen(Color.Black, 2f);
			bool flag = false;
			int num = 5;
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_850_BD.Equip.Valor, RT_geral.RT_850_BD.Versao.Valor);
			checked
			{
				int num2 = (z.MarginBounds.Bottom - z.MarginBounds.Top) / fonte2.Variavel.Height - 5;
				if (this.grupo_impressao == 4)
				{
					int valor2 = RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor;
					if (valor2 >= 0)
					{
						TabelaLinhaInteria tabelaLinhaInteria;
						if (this.quantos_imprimiu == 0)
						{
							tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 2, "Ctrl 04", false);
						}
						else
						{
							tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 2, "Ctrl 04 - Continuação", false);
						}
						int num3 = this.quantos_imprimiu + num2;
						if (num3 > valor2)
						{
							num3 = valor2;
						}
						string text = "\r\nEnd.";
						string text2 = "\r\nNome";
						string text3 = "\r\nCanal";
						string text4 = "Time\r\nOut";
						string text5 = "\r\nCmd";
						string text6 = "Priori-\r\ndade";
						string text7 = "\r\nModelo";
						string text8 = "CTRL1\r\nMsg";
						string text9 = "\r\nNº";
						string text10 = "CTRL2\r\nMsg";
						string text11 = "\r\nNº";
						string text12 = "CTRL3\r\nMsg";
						string text13 = "\r\nNº";
						string text14 = "CTRL3\r\nMsg";
						string text15 = "\r\nNº";
						string text16 = "Var1";
						string text17 = "Var2";
						int[] array = new int[]
						{
							0,
							36,
							112,
							155,
							190,
							230,
							290,
							370,
							435,
							465,
							530,
							560,
							635,
							665,
							730,
							760,
							850
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
							text17
						};
						TabelaLinhaInteria tabelaLinhaInteria2 = tabelaLinhaInteria;
						int num4 = 1;
						tabelaLinhaInteria2.EscreveTodosTitulos(ref num4, titulos, array);
						int num5 = this.quantos_imprimiu;
						int num6 = num3 - 1;
						for (int i = num5; i <= num6; i++)
						{
							tabelaLinhaInteria.AdicionaLinha();
							int num7 = i - this.quantos_imprimiu;
							string text18 = string.Format("{0:D3}", RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Valor + i);
							tabelaLinhaInteria.EscreveTituloLinha(num7 + 3, text18, array[0]);
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, RT_geral.RT_850_Ctrl_4[i].Nome.Valor, array[1] + 5);
							text18 = string.Format("{0}", RT_geral.RT_850_Ctrl_4[i].Canal.Indice + 1);
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text18, array[2] + 10);
							text18 = string.Format("{0}", RT_geral.RT_850_Ctrl_4[i].Timeout.Indice + 1);
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text18, array[3] + 10);
							text18 = "???";
							switch (RT_geral.RT_850_Ctrl_4[i].Comando.Indice)
							{
							case 0:
								text18 = "Desab.";
								break;
							case 1:
								text18 = "Lib.";
								break;
							case 2:
								text18 = "Bloq.";
								break;
							}
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text18, array[4] + 10);
							text18 = "???";
							switch (RT_geral.RT_850_Ctrl_4[i].Prioridade.Indice)
							{
							case 0:
								text18 = "Desab.";
								break;
							case 1:
							case 2:
							case 3:
							case 4:
							case 5:
							case 6:
							case 7:
								text18 = string.Format("{0}", RT_geral.RT_850_Ctrl_4[i].Prioridade.Indice);
								break;
							}
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text18, array[5] + 10);
							text18 = "???";
							switch (RT_geral.RT_850_Ctrl_4[i].Modelo.Indice)
							{
							case 0:
								text18 = "N.Def";
								break;
							case 1:
								text18 = "RT820 010";
								break;
							case 2:
								text18 = "RT820 200";
								break;
							case 3:
								text18 = "RT820 300";
								break;
							case 4:
								text18 = "RT820 350";
								break;
							case 5:
								text18 = "RT820 400";
								break;
							case 6:
								text18 = "RT821 010";
								break;
							case 7:
								text18 = "RT821 200";
								break;
							case 8:
								text18 = "RT821 300";
								break;
							case 9:
								text18 = "RT821 400";
								break;
							case 11:
								text18 = "VA320 35";
								break;
							case 12:
								text18 = "VA320 50";
								break;
							case 13:
								text18 = "VA220 42";
								break;
							case 14:
								text18 = "VA220 50";
								break;
							case 19:
								text18 = "MD202 520";
								break;
							}
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text18, array[6] + 5);
							text18 = "???";
							int num8 = 0;
							do
							{
								switch (RT_geral.RT_850_Ctrl_4[i].Crtl_nome[num8].Indice)
								{
								case 0:
									text18 = "Controle";
									break;
								case 1:
									text18 = "Motor";
									break;
								case 2:
									text18 = "Válvula";
									break;
								}
								tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text18, array[7 + 2 * num8] + 5);
								tabelaLinhaInteria.EscreveValorLinha(num7 + 3, RT_geral.RT_850_Ctrl_4[i].Crtl_indice[num8].Valor.ToString(), array[8 + 2 * num8] + 5);
								num8++;
							}
							while (num8 <= 3);
							num8 = 0;
							do
							{
								int indice = RT_geral.RT_850_Ctrl_4[i].Var[num8].Indice;
								if (indice == 0)
								{
									tabelaLinhaInteria.EscreveValorLinha(num7 + 3, "---", array[15 + num8] + 5);
								}
								else
								{
									tabelaLinhaInteria.EscreveValorLinha(num7 + 3, RT_geral.Variaveis_RT_850[indice - 1].Nome.Valor, array[15 + num8] + 5);
								}
								num8++;
							}
							while (num8 <= 1);
						}
						this.quantos_imprimiu += num2;
						if (this.quantos_imprimiu >= valor2)
						{
							this.quantos_imprimiu = 0;
							this.grupo_impressao = 5;
							flag = true;
							if (RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor == 0)
							{
								this.grupo_impressao = 6;
							}
						}
						else
						{
							flag = true;
							this.grupo_impressao = 5;
						}
					}
				}
				if (this.grupo_impressao == 5 & !flag)
				{
					int valor2 = RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor;
					if (valor2 >= 0)
					{
						fonte2.Valor = valor;
						TabelaLinhaInteria tabelaLinhaInteria;
						if (this.quantos_imprimiu2 == 0)
						{
							tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, num, 2, "Ctrl 04", false);
						}
						else
						{
							tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, num, 2, "Ctrl 04 - Continuação", false);
						}
						if (num != 5)
						{
							num2 -= num;
						}
						int num3 = this.quantos_imprimiu2 + num2;
						if (num3 > valor2)
						{
							num3 = valor2;
						}
						string text19 = "\r\nEnd.";
						string text20 = "\r\nVar3";
						string text21 = "\r\nVar4";
						string text22 = "\r\nREF1";
						string text23 = "\r\nREF2";
						string text24 = "\r\nREF3";
						string text25 = "\r\nREF4";
						string text26 = "\r\nModelo";
						string text27 = "\r\nEnd";
						int[] array2 = new int[]
						{
							-5,
							25,
							105,
							180,
							255,
							325,
							405,
							480,
							540,
							575,
							635,
							670,
							740,
							775,
							835,
							865,
							935
						};
						int[] array3 = new int[]
						{
							480,
							575,
							670,
							775,
							865
						};
						string[] titulos2 = new string[]
						{
							text19,
							text20,
							text21,
							text22,
							text23,
							text24,
							text25,
							text26,
							text27,
							text26,
							text27,
							text26,
							text27,
							text26,
							text27,
							text26,
							text27
						};
						TabelaLinhaInteria tabelaLinhaInteria3 = tabelaLinhaInteria;
						int num4 = 1;
						tabelaLinhaInteria3.EscreveTodosTitulos(ref num4, titulos2, array2);
						int num9 = this.quantos_imprimiu2;
						int num10 = num3 - 1;
						for (int i = num9; i <= num10; i++)
						{
							tabelaLinhaInteria.AdicionaLinha();
							int num7 = i - this.quantos_imprimiu2;
							string text18 = string.Format("{0:D3}", RT_geral.RT_850_BD.End_inicial_equip_tipo_2.Valor + i);
							tabelaLinhaInteria.EscreveTituloLinha(num7 + 3, text18, array2[0]);
							int num8 = 2;
							do
							{
								int indice = RT_geral.RT_850_Ctrl_4[i].Var[num8].Indice;
								if (indice == 0)
								{
									tabelaLinhaInteria.EscreveValorLinha(num7 + 3, "---", array2[num8 - 1] + 5);
								}
								else
								{
									tabelaLinhaInteria.EscreveValorLinha(num7 + 3, RT_geral.Variaveis_RT_850[indice - 1].Nome.Valor, array2[num8 - 1] + 5);
								}
								num8++;
							}
							while (num8 <= 3);
							num8 = 0;
							do
							{
								int indice = RT_geral.RT_850_Ctrl_4[i].Ref[num8].Indice;
								if (indice == 0)
								{
									tabelaLinhaInteria.EscreveValorLinha(num7 + 3, "---", array2[3 + num8] + 5);
								}
								else
								{
									tabelaLinhaInteria.EscreveValorLinha(num7 + 3, RT_geral.Variaveis_RT_850[indice - 1].Nome.Valor, array2[3 + num8] + 5);
								}
								num8++;
							}
							while (num8 <= 3);
							num8 = 0;
							do
							{
								text18 = string.Format("Periférico {0}", num8 + 1);
								tabelaLinhaInteria.EscreveTituloLinha(1, text18, array3[num8]);
								int indice = RT_geral.RT_850_Ctrl_4[i].Periferico_Modelo[num8].Indice;
								text18 = "???";
								if (indice <= perifericos.perif_CT850_300.Count)
								{
									text18 = perifericos.perif_CT850_300[indice].nome_impressao;
								}
								tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text18, array2[7 + 2 * num8] + 5);
								tabelaLinhaInteria.EscreveValorLinha(num7 + 3, RT_geral.RT_850_Ctrl_4[i].Periferico_Indice[num8].Indice.ToString(), array2[8 + 2 * num8] + 5);
								num8++;
							}
							while (num8 <= 4);
						}
						this.quantos_imprimiu2 += num2;
						if (this.quantos_imprimiu2 >= valor2)
						{
							this.quantos_imprimiu2 = 0;
							this.grupo_impressao = 6;
							flag = true;
						}
						else
						{
							flag = true;
							this.grupo_impressao = 4;
						}
					}
				}
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
				this.pagina_impressao++;
				return flag;
			}
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x002EFC9C File Offset: 0x002EE09C
		private bool DesenhaRelatorioRT821Grupo6e7e8e9(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, 3);
			Font font2 = new Font("Calibri", 10f, 3, (FontStyle)3);
			Font font3 = new Font("Calibri", 10f, 0, (FontStyle)3);
			Font valor = new Font("Calibri", 8f, 0, (FontStyle)3);
			Font fonte = new Font("Calibri", 20f, 1, (FontStyle)3);
			Font font4 = new Font("5x8 LCD HD44780U A02", 14f, 0, (FontStyle)3);
			Pen pen = new Pen(Color.Black, 2f);
			bool flag = false;
			int num = 5;
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_850_BD.Equip.Valor, RT_geral.RT_850_BD.Versao.Valor);
			checked
			{
				int num2 = (z.MarginBounds.Bottom - z.MarginBounds.Top) / fonte2.Variavel.Height - 5;
				if (this.grupo_impressao == 6)
				{
					int valor2 = RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor;
					if (valor2 >= 0)
					{
						TabelaLinhaInteria tabelaLinhaInteria;
						if (this.quantos_imprimiu == 0)
						{
							tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 2, "Ctrl 08", false);
						}
						else
						{
							tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 2, "Ctrl 08 - Continuação", false);
						}
						int num3 = this.quantos_imprimiu + num2;
						if (num3 > valor2)
						{
							num3 = valor2;
						}
						string text = "\r\nEnd.";
						string text2 = "\r\nNome";
						string text3 = "\r\nCanal";
						string text4 = "Time\r\nOut";
						string text5 = "\r\nComando";
						string text6 = "\r\nPrioridade";
						string text7 = "\r\nModelo";
						string text8 = "CTRL1\r\nMensagem";
						string text9 = "\r\nNº";
						string text10 = "CTRL2\r\nMensagem";
						string text11 = "\r\nNº";
						string text12 = "CTRL3\r\nMensagem";
						string text13 = "\r\nNº";
						string text14 = "CTRL4\r\nMensagem";
						string text15 = "\r\nNº";
						string text16 = "CTRL5\r\nMensagem";
						string text17 = "\r\nNº";
						string text18 = "CTRL6\r\nMensagem";
						string text19 = "\r\nNº";
						int[] array = new int[]
						{
							0,
							40,
							110,
							155,
							190,
							250,
							320,
							395,
							465,
							490,
							560,
							585,
							655,
							680,
							750,
							775,
							845,
							870,
							940
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
							text19
						};
						TabelaLinhaInteria tabelaLinhaInteria2 = tabelaLinhaInteria;
						int num4 = 1;
						tabelaLinhaInteria2.EscreveTodosTitulos(ref num4, titulos, array);
						int num5 = this.quantos_imprimiu;
						int num6 = num3 - 1;
						for (int i = num5; i <= num6; i++)
						{
							tabelaLinhaInteria.AdicionaLinha();
							int num7 = i - this.quantos_imprimiu;
							string text20 = string.Format("{0:D3}", RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Valor + i);
							tabelaLinhaInteria.EscreveTituloLinha(num7 + 3, text20, array[0]);
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, RT_geral.RT_850_Ctrl_8[i].Nome.Valor, array[1] + 5);
							text20 = string.Format("{0}", RT_geral.RT_850_Ctrl_8[i].Canal.Indice + 1);
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text20, array[2] + 10);
							text20 = string.Format("{0}", RT_geral.RT_850_Ctrl_8[i].Timeout.Indice + 1);
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text20, array[3] + 10);
							text20 = "???";
							switch (RT_geral.RT_850_Ctrl_8[i].Comando.Indice)
							{
							case 0:
								text20 = "Desab.";
								break;
							case 1:
								text20 = "Lib.";
								break;
							case 2:
								text20 = "Bloq.";
								break;
							}
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text20, array[4] + 10);
							text20 = "???";
							switch (RT_geral.RT_850_Ctrl_8[i].Prioridade.Indice)
							{
							case 0:
								text20 = "Desab.";
								break;
							case 1:
							case 2:
							case 3:
							case 4:
							case 5:
							case 6:
							case 7:
								text20 = string.Format("{0}", RT_geral.RT_850_Ctrl_8[i].Prioridade.Indice);
								break;
							}
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text20, array[5] + 10);
							text20 = "???";
							switch (RT_geral.RT_850_Ctrl_8[i].Modelo.Indice)
							{
							case 0:
								text20 = "N.Def";
								break;
							case 1:
								text20 = "RT820 300";
								break;
							case 2:
								text20 = "RT820 350";
								break;
							case 3:
								text20 = "RT820 400";
								break;
							case 4:
								text20 = "VA220_42";
								break;
							}
							tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text20, array[6] + 5);
							text20 = "???";
							int num8 = 0;
							do
							{
								switch (RT_geral.RT_850_Ctrl_8[i].Crtl_nome[num8].Indice)
								{
								case 0:
									text20 = "Controle";
									break;
								case 1:
									text20 = "Motor";
									break;
								case 2:
									text20 = "Válvula";
									break;
								}
								tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text20, array[7 + 2 * num8] + 5);
								tabelaLinhaInteria.EscreveValorLinha(num7 + 3, RT_geral.RT_850_Ctrl_8[i].Crtl_indice[num8].Valor.ToString(), array[8 + 2 * num8] + 5);
								num8++;
							}
							while (num8 <= 5);
						}
						this.quantos_imprimiu += num2;
						if (this.quantos_imprimiu >= valor2)
						{
							this.quantos_imprimiu = 0;
							this.grupo_impressao = 7;
							flag = true;
							if (RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor == 0)
							{
								this.grupo_impressao = 10;
							}
						}
						else
						{
							flag = true;
							this.grupo_impressao = 7;
						}
					}
				}
				if (this.grupo_impressao == 7 & !flag)
				{
					int valor2 = RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor;
					if (valor2 >= 0)
					{
						fonte2.Valor = valor;
						TabelaLinhaInteria tabelaLinhaInteria;
						if (this.quantos_imprimiu2 == 0)
						{
							tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, num, 2, "Ctrl 08", false);
						}
						else
						{
							tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, num, 2, "Ctrl 08 - Continuação", false);
						}
						if (num != 5)
						{
							num2 -= num;
						}
						int num3 = this.quantos_imprimiu2 + num2;
						if (num3 > valor2)
						{
							num3 = valor2;
						}
						string text21 = "\r\nEnd.";
						string text22 = "CTRL7\r\nMensagem";
						string text23 = "\r\nNº";
						string text24 = "CTRL8\r\nMensagem";
						string text25 = "\r\nNº";
						string text26 = "\r\nVar1";
						string text27 = "\r\nVar2";
						string text28 = "\r\nVar3";
						string text29 = "\r\nVar4";
						string text30 = "\r\nVar5";
						string text31 = "\r\nVar6";
						string text32 = "\r\nVar7";
						string text33 = "\r\nVar8";
						string text34 = "\r\nVar9";
						string text35 = "\r\nVar10";
						string text36 = "\r\nVar11";
						int[] array2 = new int[]
						{
							-5,
							25,
							95,
							125,
							195,
							215,
							280,
							345,
							410,
							480,
							550,
							620,
							685,
							755,
							825,
							895
						};
						string[] titulos2 = new string[]
						{
							text21,
							text22,
							text23,
							text24,
							text25,
							text26,
							text27,
							text28,
							text29,
							text30,
							text31,
							text32,
							text33,
							text34,
							text35,
							text36
						};
						TabelaLinhaInteria tabelaLinhaInteria3 = tabelaLinhaInteria;
						int num4 = 1;
						tabelaLinhaInteria3.EscreveTodosTitulos(ref num4, titulos2, array2);
						int num9 = this.quantos_imprimiu2;
						int num10 = num3 - 1;
						for (int i = num9; i <= num10; i++)
						{
							tabelaLinhaInteria.AdicionaLinha();
							int num7 = i - this.quantos_imprimiu2;
							string text20 = string.Format("{0:D3}", RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Valor + i);
							tabelaLinhaInteria.EscreveTituloLinha(num7 + 3, text20, array2[0]);
							int num8 = 0;
							do
							{
								switch (RT_geral.RT_850_Ctrl_8[i].Crtl_nome[num8 + 6].Indice)
								{
								case 0:
									text20 = "Controle";
									break;
								case 1:
									text20 = "Motor";
									break;
								case 2:
									text20 = "Válvula";
									break;
								}
								tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text20, array2[1 + 2 * num8] + 5);
								tabelaLinhaInteria.EscreveValorLinha(num7 + 3, RT_geral.RT_850_Ctrl_8[i].Crtl_indice[num8 + 6].Valor.ToString(), array2[2 + 2 * num8] + 5);
								num8++;
							}
							while (num8 <= 1);
							num8 = 0;
							do
							{
								int indice = RT_geral.RT_850_Ctrl_8[i].Var[num8].Indice;
								if (indice == 0)
								{
									tabelaLinhaInteria.EscreveValorLinha(num7 + 3, "---", array2[5 + num8] + 5);
								}
								else
								{
									tabelaLinhaInteria.EscreveValorLinha(num7 + 3, RT_geral.Variaveis_RT_850[indice - 1].Nome.Valor, array2[5 + num8] + 5);
								}
								num8++;
							}
							while (num8 <= 10);
						}
						this.quantos_imprimiu2 += num2;
						if (this.quantos_imprimiu2 >= valor2)
						{
							this.quantos_imprimiu2 = 0;
							this.grupo_impressao = 8;
							flag = true;
						}
						else
						{
							flag = true;
							this.grupo_impressao = 8;
						}
					}
				}
				if (this.grupo_impressao == 8 & !flag)
				{
					int valor2 = RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor;
					if (valor2 >= 0)
					{
						fonte2.Valor = valor;
						TabelaLinhaInteria tabelaLinhaInteria;
						if (this.quantos_imprimiu3 == 0)
						{
							tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, num, 2, "Ctrl 08", false);
						}
						else
						{
							tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, num, 2, "Ctrl 08 - Continuação", false);
						}
						if (num != 5)
						{
							num2 -= num;
						}
						int num3 = this.quantos_imprimiu3 + num2;
						if (num3 > valor2)
						{
							num3 = valor2;
						}
						string text37 = "\r\nEnd.";
						string text38 = "\r\nVar12";
						string text39 = "\r\nVar13";
						string text40 = "\r\nVar14";
						string text41 = "\r\nVar15";
						string text42 = "\r\nVar16";
						string text43 = "\r\nRef1";
						string text44 = "\r\nRef2";
						string text45 = "\r\nRef3";
						string text46 = "\r\nRef4";
						int[] array3 = new int[]
						{
							0,
							40,
							120,
							200,
							280,
							360,
							440,
							520,
							600,
							680
						};
						string[] titulos3 = new string[]
						{
							text37,
							text38,
							text39,
							text40,
							text41,
							text42,
							text43,
							text44,
							text45,
							text46
						};
						TabelaLinhaInteria tabelaLinhaInteria4 = tabelaLinhaInteria;
						int num4 = 1;
						tabelaLinhaInteria4.EscreveTodosTitulos(ref num4, titulos3, array3);
						int num11 = this.quantos_imprimiu3;
						int num12 = num3 - 1;
						for (int i = num11; i <= num12; i++)
						{
							tabelaLinhaInteria.AdicionaLinha();
							int num7 = i - this.quantos_imprimiu3;
							string text20 = string.Format("{0:D3}", RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Valor + i);
							tabelaLinhaInteria.EscreveTituloLinha(num7 + 3, text20, array3[0]);
							int num8 = 0;
							do
							{
								int indice = RT_geral.RT_850_Ctrl_8[i].Var[num8 + 11].Indice;
								if (indice == 0)
								{
									tabelaLinhaInteria.EscreveValorLinha(num7 + 3, "---", array3[1 + num8] + 5);
								}
								else
								{
									tabelaLinhaInteria.EscreveValorLinha(num7 + 3, RT_geral.Variaveis_RT_850[indice - 1].Nome.Valor, array3[1 + num8] + 5);
								}
								num8++;
							}
							while (num8 <= 4);
							num8 = 0;
							do
							{
								int indice = RT_geral.RT_850_Ctrl_8[i].Ref[num8].Indice;
								if (indice == 0)
								{
									tabelaLinhaInteria.EscreveValorLinha(num7 + 3, "---", array3[6 + num8] + 5);
								}
								else
								{
									tabelaLinhaInteria.EscreveValorLinha(num7 + 3, RT_geral.Variaveis_RT_850[indice - 1].Nome.Valor, array3[6 + num8] + 5);
								}
								num8++;
							}
							while (num8 <= 3);
						}
						this.quantos_imprimiu3 += num2;
						if (this.quantos_imprimiu3 >= valor2)
						{
							this.quantos_imprimiu3 = 0;
							this.grupo_impressao = 9;
							flag = true;
						}
						else
						{
							flag = true;
							this.grupo_impressao = 9;
						}
					}
				}
				if (this.grupo_impressao == 9 & !flag)
				{
					int valor2 = RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor;
					if (valor2 >= 0)
					{
						TabelaLinhaInteria tabelaLinhaInteria;
						if (this.quantos_imprimiu4 == 0)
						{
							tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, num, 2, "Ctrl 08", false);
						}
						else
						{
							tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, num, 2, "Ctrl 08 - Continuação", false);
						}
						if (num != 5)
						{
							num2 -= num;
						}
						int num3 = this.quantos_imprimiu4 + num2;
						if (num3 > valor2)
						{
							num3 = valor2;
						}
						string text47 = "\r\nEnd.";
						string text48 = "Perif1\r\nModelo";
						string text49 = "\r\nEnd";
						string text50 = "Perif2\r\nModelo";
						string text51 = "\r\nEnd";
						string text52 = "Perif3\r\nModelo";
						string text53 = "\r\nEnd";
						string text54 = "Perif4\r\nModelo";
						string text55 = "\r\nEnd";
						string text56 = "Perif5\r\nModelo";
						string text57 = "\r\nEnd";
						int[] array4 = new int[]
						{
							0,
							40,
							190,
							230,
							380,
							420,
							570,
							610,
							760,
							800,
							920
						};
						string[] titulos4 = new string[]
						{
							text47,
							text48,
							text49,
							text50,
							text51,
							text52,
							text53,
							text54,
							text55,
							text56,
							text57
						};
						TabelaLinhaInteria tabelaLinhaInteria5 = tabelaLinhaInteria;
						int num4 = 1;
						tabelaLinhaInteria5.EscreveTodosTitulos(ref num4, titulos4, array4);
						int num13 = this.quantos_imprimiu4;
						int num14 = num3 - 1;
						for (int i = num13; i <= num14; i++)
						{
							tabelaLinhaInteria.AdicionaLinha();
							int num7 = i - this.quantos_imprimiu4;
							string text20 = string.Format("{0:D3}", RT_geral.RT_850_BD.End_inicial_equip_tipo_3.Valor + i);
							tabelaLinhaInteria.EscreveTituloLinha(num7 + 3, text20, array4[0]);
							int num8 = 0;
							do
							{
								int indice = RT_geral.RT_850_Ctrl_8[i].Periferico_Modelo[num8].Indice;
								if (indice <= perifericos.perif_CT850_300.Count)
								{
									text20 = perifericos.perif_CT850_300[indice].nome_impressao;
								}
								tabelaLinhaInteria.EscreveValorLinha(num7 + 3, text20, array4[1 + 2 * num8] + 5);
								tabelaLinhaInteria.EscreveValorLinha(num7 + 3, RT_geral.RT_850_Ctrl_8[i].Periferico_Indice[num8].Indice.ToString(), array4[2 + 2 * num8] + 10);
								num8++;
							}
							while (num8 <= 4);
						}
						this.quantos_imprimiu4 += num2;
						if (this.quantos_imprimiu4 >= valor2)
						{
							this.quantos_imprimiu4 = 0;
							this.grupo_impressao = 10;
							flag = true;
							if (RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor == 0)
							{
								flag = false;
							}
						}
						else
						{
							flag = true;
							this.grupo_impressao = 10;
						}
					}
				}
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
				this.pagina_impressao++;
				return flag;
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x002F0DF0 File Offset: 0x002EF1F0
		private bool DesenhaRelatorioRT821Grupo10(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, 3);
			Font font2 = new Font("Calibri", 10f, 3, (FontStyle)3);
			Font font3 = new Font("Calibri", 10f, 0, (FontStyle)3);
			Font fonte = new Font("Calibri", 20f, 1, (FontStyle)3);
			Font font4 = new Font("5x8 LCD HD44780U A02", 14f, 0, (FontStyle)3);
			Pen pen = new Pen(Color.Black, 2f);
			bool result = true;
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_850_BD.Equip.Valor, RT_geral.RT_850_BD.Versao.Valor);
			checked
			{
				int num = (z.MarginBounds.Bottom - z.MarginBounds.Top) / fonte2.Variavel.Height - 5;
				string text = "Nº";
				string text2 = "Mensagem";
				int[] posicoes = new int[]
				{
					0,
					100
				};
				string[] titulos = new string[]
				{
					text,
					text2
				};
				if (this.grupo_impressao == 10)
				{
					TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 5, 21, "Mensagens de Alarme", true);
					TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = tabelaMeiaLinhaEsquerda;
					int num2 = 1;
					tabelaMeiaLinhaEsquerda2.EscreveTodosTitulos(ref num2, titulos, posicoes);
					int num3 = 0;
					do
					{
						tabelaMeiaLinhaEsquerda.EscreveTituloLinha(2 + num3, Conversion.Str(num3 + 1), 0);
						tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num3, RT_geral.RT_850_MSG_ALARME_CONFIG[num3], 120);
						num3++;
					}
					while (num3 <= 19);
				}
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
				this.pagina_impressao++;
				this.grupo_impressao = 11;
				return result;
			}
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x002F1020 File Offset: 0x002EF420
		private bool DesenhaRelatorioRT821Grupo11(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, 3);
			Font font2 = new Font("Calibri", 10f, 3, (FontStyle)3);
			Font font3 = new Font("Calibri", 10f, 0, (FontStyle)3);
			Font fonte = new Font("Calibri", 20f, 1, (FontStyle)3);
			Font font4 = new Font("5x8 LCD HD44780U A02", 14f, 0, (FontStyle)3);
			Pen pen = new Pen(Color.Black, 2f);
			int linhaInicial = 5;
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_850_BD.Equip.Valor, RT_geral.RT_850_BD.Versao.Valor);
			checked
			{
				int num = (z.MarginBounds.Bottom - z.MarginBounds.Top) / fonte2.Variavel.Height - 5;
				string text = "End.";
				string text2 = "Canal";
				string text3 = "TimeOut";
				string text4 = "Prioridade";
				string text5 = "Modelo";
				string text6 = "Nº Vars";
				string text7 = "Nº Equip";
				int[] array = new int[]
				{
					210,
					270,
					340,
					470,
					600,
					790,
					870
				};
				int[] array2 = new int[]
				{
					0,
					100,
					200,
					300,
					400,
					500,
					600,
					700,
					800,
					900
				};
				string[] titulos = new string[]
				{
					text,
					text2,
					text3,
					text4,
					text5,
					text6,
					text7
				};
				if (this.grupo_impressao == 11)
				{
					int num2 = 0;
					if (RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor == 0)
					{
						num2 = 0;
					}
					else
					{
						num2 = 1;
					}
					int num3 = num2;
					int valor = RT_geral.RT_850_BD.Numero_equip_tipo_vista.Valor;
					for (int i = num3; i <= valor; i++)
					{
						string text8 = string.Format("Vista {0}: {1}", i, RT_geral.RT_850_Vista[i].Nome.Valor);
						TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, linhaInicial, 0, text8, "L", true);
						TabelaLinhaInteria tabelaLinhaInteria2 = tabelaLinhaInteria;
						int num4 = 0;
						tabelaLinhaInteria2.EscreveTodosTitulos(ref num4, titulos, array);
						text8 = string.Format("{0:D3}", RT_geral.RT_850_BD.End_inicial_equip_tipo_vista.Valor + (i - 1));
						tabelaLinhaInteria.EscreveValorLinha(0, text8, array[0] + 35);
						text8 = string.Format("{0}", RT_geral.RT_850_Vista[i].Canal.Indice + 1);
						tabelaLinhaInteria.EscreveValorLinha(0, text8, array[1] + 50);
						text8 = string.Format("{0}", RT_geral.RT_850_Vista[i].Timeout.Indice + 1);
						tabelaLinhaInteria.EscreveValorLinha(0, text8, array[2] + 70);
						text8 = "???";
						switch (RT_geral.RT_850_Vista[i].Prioridade.Indice)
						{
						case 0:
							text8 = "Desab.";
							break;
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
						case 7:
							text8 = string.Format("{0}", RT_geral.RT_850_Vista[i].Prioridade.Indice);
							break;
						}
						tabelaLinhaInteria.EscreveValorLinha(0, text8, array[3] + 80);
						text8 = "???";
						switch (RT_geral.RT_850_Vista[i].Modelo.Indice)
						{
						case 0:
							text8 = "Não def.";
							break;
						case 1:
							text8 = "CT831-010";
							break;
						case 2:
							text8 = "CT831-200";
							break;
						case 7:
							text8 = "VA241-70";
							break;
						}
						tabelaLinhaInteria.EscreveValorLinha(0, text8, array[4] + 70);
						tabelaLinhaInteria.EscreveValorLinha(0, RT_geral.RT_850_Vista[i].Num_var.Valor.ToString(), array[5] + 60);
						tabelaLinhaInteria.EscreveValorLinha(0, RT_geral.RT_850_Vista[i].Num_equip.Valor.ToString(), array[6] + 70);
						int num5 = 0;
						int num6 = RT_geral.RT_850_Vista[i].Num_var.Valor - 1;
						int num8;
						for (int j = num5; j <= num6; j++)
						{
							int num7 = j % 10;
							num8 = 1 + j / 10;
							if (num7 == 0)
							{
								tabelaLinhaInteria.AdicionaLinha();
							}
							if (RT_geral.RT_850_Vista[i].Variaveis[j].Indice == 0)
							{
								text8 = string.Format("V{0:D2}:---", j + 1);
							}
							else
							{
								text8 = string.Format("V{0:D2}:", j + 1) + RT_geral.Variaveis_RT_850[RT_geral.RT_850_Vista[i].Variaveis[j].Indice - 1].Nome.Valor;
							}
							tabelaLinhaInteria.EscreveValorLinha(num8, text8, array2[num7]);
						}
						int num9 = num8;
						int num10 = 0;
						int num11 = RT_geral.RT_850_Vista[i].Num_equip.Valor - 1;
						for (int j = num10; j <= num11; j++)
						{
							int num7 = j % 10;
							num8 = num9 + 1 + j / 10;
							if (num7 == 0)
							{
								tabelaLinhaInteria.AdicionaLinha();
							}
							if (RT_geral.RT_850_Vista[i].Equipamentos[j].Indice == 0)
							{
								text8 = string.Format("E{0:D2}:---", j + 1);
							}
							else
							{
								int indice = RT_geral.RT_850_Vista[i].Equipamentos[j].Indice;
								if (indice < 80)
								{
									text8 = string.Format("E{0:D2}:", j + 1) + RT_geral.RT_850_Ctrl_1[indice - 1].Nome.Valor;
								}
								else if (indice < 130)
								{
									text8 = string.Format("E{0:D2}:", j + 1) + RT_geral.RT_850_Ctrl_4[indice - 80 - 1].Nome.Valor;
								}
								else if (indice < 150)
								{
									text8 = string.Format("E{0:D2}:", j + 1) + RT_geral.RT_850_Ctrl_8[indice - 130 - 1].Nome.Valor;
								}
							}
							tabelaLinhaInteria.EscreveValorLinha(num8, text8, array2[num7]);
						}
						linhaInicial = tabelaLinhaInteria.GetNextLineAvailable() - 1;
					}
				}
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
				this.pagina_impressao++;
				return false;
			}
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x002F17A4 File Offset: 0x002EFBA4
		private bool DesenhaRelatorio(PrintPageEventArgs z)
		{
			bool result;
			switch (this.grupo_impressao)
			{
			case 1:
				result = this.DesenhaRelatorioRT821Grupo1(z);
				break;
			case 2:
			case 3:
				result = this.DesenhaRelatorioRT821Grupo2e3(z);
				break;
			case 4:
			case 5:
				result = this.DesenhaRelatorioRT821Grupo4e5(z);
				break;
			case 6:
			case 7:
			case 8:
			case 9:
				result = this.DesenhaRelatorioRT821Grupo6e7e8e9(z);
				break;
			case 10:
				result = this.DesenhaRelatorioRT821Grupo10(z);
				break;
			case 11:
				result = this.DesenhaRelatorioRT821Grupo11(z);
				break;
			}
			return result;
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x002F1828 File Offset: 0x002EFC28
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.HasMorePages = this.DesenhaRelatorio(e);
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x002F1838 File Offset: 0x002EFC38
		private void PrintPreviewDialog1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x002F183C File Offset: 0x002EFC3C
		private void dgv_Msg_Alarmes_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (e.ColumnIndex < 0)
			{
				return;
			}
			if (e.RowIndex < 0)
			{
				return;
			}
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string name = this.dgv_Msg_Alarmes.Columns[e.ColumnIndex].Name;
			string text = name;
			if (Operators.CompareString(text, "Alm_col_mensagem", false) == 0)
			{
				RT_geral.RT_850_MSG_ALARME_CONFIG[e.RowIndex] = Conversions.ToString(this.dgv_Msg_Alarmes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x002F18D4 File Offset: 0x002EFCD4
		private void dgv_Msg_Alarmes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			if (e.ColumnIndex < 0)
			{
				return;
			}
			if (e.RowIndex < 0)
			{
				return;
			}
			string text = this.dgv_Msg_Alarmes.Columns[e.ColumnIndex].Name;
			string text2 = text;
			if (Operators.CompareString(text2, "Alm_col_mensagem", false) == 0)
			{
				text = Conversions.ToString(this.dgv_Msg_Alarmes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				RT_geral.RT_850_MSG_ALARME_CONFIG[e.RowIndex] = text;
			}
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x002F1970 File Offset: 0x002EFD70
		private void dgv_Msg_Alarmes_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_Msg_Alarmes.IsCurrentCellDirty)
			{
				this.dgv_Msg_Alarmes.CommitEdit(512);
			}
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x002F1990 File Offset: 0x002EFD90
		private void DataGridView_variaveis_RT850_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x002F1994 File Offset: 0x002EFD94
		private void CheckBox_conf_resp_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null), true, false))
			{
				RT_geral.RT_850_BD.ConfereResposta.Valor = 1;
			}
			else
			{
				RT_geral.RT_850_BD.ConfereResposta.Valor = 0;
			}
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x002F19E8 File Offset: 0x002EFDE8
		private void nud_estatistica_ch1_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_850_BD.Numero_cmd_estatistica_canal1, true);
			sender = numericUpDown;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x002F1A3C File Offset: 0x002EFE3C
		private void nud_estatistica_ch2_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_850_BD.Numero_cmd_estatistica_canal2, true);
			sender = numericUpDown;
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x002F1A90 File Offset: 0x002EFE90
		private void ckb_modo_estatistica_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null), true, false))
			{
				RT_geral.RT_850_BD.Modo_Estatistica.Valor = 1;
			}
			else
			{
				RT_geral.RT_850_BD.Modo_Estatistica.Valor = 0;
			}
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x002F1AE4 File Offset: 0x002EFEE4
		private void T_ModeloFonte_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x002F1AE8 File Offset: 0x002EFEE8
		private void T_Latitude2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x002F1AEC File Offset: 0x002EFEEC
		private void cb_remota_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.Flag_Remota.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_850_BD.Flag_Remota.Valor = RT_geral.RT_850_BD.Flag_Remota.valores[RT_geral.RT_850_BD.Flag_Remota.Indice];
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x002F1B50 File Offset: 0x002EFF50
		private void cb_supervisorio_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_850_BD.Flag_Supervisorio.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_850_BD.Flag_Supervisorio.Valor = RT_geral.RT_850_BD.Flag_Supervisorio.valores[RT_geral.RT_850_BD.Flag_Supervisorio.Indice];
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x002F1BB4 File Offset: 0x002EFFB4
		private void cb_teclado_RT850_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null), true, false))
			{
				RT_geral.RT_850_BD.LiberaTeclado.Valor = 1;
			}
			else
			{
				RT_geral.RT_850_BD.LiberaTeclado.Valor = 0;
			}
		}

		// Token: 0x040006A8 RID: 1704
		[AccessedThroughProperty("ToolStri_RT850")]
		private ToolStrip _ToolStri_RT850;

		// Token: 0x040006A9 RID: 1705
		[AccessedThroughProperty("ToolStripButton_RT850_novo")]
		private ToolStripButton _ToolStripButton_RT850_novo;

		// Token: 0x040006AA RID: 1706
		[AccessedThroughProperty("ToolStripButton_RT850_Abrir")]
		private ToolStripButton _ToolStripButton_RT850_Abrir;

		// Token: 0x040006AB RID: 1707
		[AccessedThroughProperty("ToolStripButton_RT850_Salvar")]
		private ToolStripButton _ToolStripButton_RT850_Salvar;

		// Token: 0x040006AC RID: 1708
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x040006AD RID: 1709
		[AccessedThroughProperty("ToolStripButton_RT850_Download")]
		private ToolStripButton _ToolStripButton_RT850_Download;

		// Token: 0x040006AE RID: 1710
		[AccessedThroughProperty("ToolStripButton_RT850_Upload")]
		private ToolStripButton _ToolStripButton_RT850_Upload;

		// Token: 0x040006AF RID: 1711
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x040006B0 RID: 1712
		[AccessedThroughProperty("ToolStripTextBox_RT850_Msg")]
		private ToolStripTextBox _ToolStripTextBox_RT850_Msg;

		// Token: 0x040006B1 RID: 1713
		[AccessedThroughProperty("ToolStripProgressBar_RT850")]
		private ToolStripProgressBar _ToolStripProgressBar_RT850;

		// Token: 0x040006B2 RID: 1714
		[AccessedThroughProperty("TabControl_850")]
		private TabControl _TabControl_850;

		// Token: 0x040006B3 RID: 1715
		[AccessedThroughProperty("TabPage_geral")]
		private TabPage _TabPage_geral;

		// Token: 0x040006B4 RID: 1716
		[AccessedThroughProperty("GroupBox_descricao_RT850")]
		private GroupBox _GroupBox_descricao_RT850;

		// Token: 0x040006B5 RID: 1717
		[AccessedThroughProperty("TextBox_comentarios_RT850")]
		private TextBox _TextBox_comentarios_RT850;

		// Token: 0x040006B6 RID: 1718
		[AccessedThroughProperty("TextBox_endereco_RT850")]
		private TextBox _TextBox_endereco_RT850;

		// Token: 0x040006B7 RID: 1719
		[AccessedThroughProperty("TextBox_nome_RT850")]
		private TextBox _TextBox_nome_RT850;

		// Token: 0x040006B8 RID: 1720
		[AccessedThroughProperty("Label_comentarios_RT850")]
		private Label _Label_comentarios_RT850;

		// Token: 0x040006B9 RID: 1721
		[AccessedThroughProperty("Label_endereco_RT850")]
		private Label _Label_endereco_RT850;

		// Token: 0x040006BA RID: 1722
		[AccessedThroughProperty("Label_nome_RT850")]
		private Label _Label_nome_RT850;

		// Token: 0x040006BB RID: 1723
		[AccessedThroughProperty("GroupBox_informacoes_RT850")]
		private GroupBox _GroupBox_informacoes_RT850;

		// Token: 0x040006BC RID: 1724
		[AccessedThroughProperty("GroupBox_resumo_RT850")]
		private GroupBox _GroupBox_resumo_RT850;

		// Token: 0x040006BD RID: 1725
		[AccessedThroughProperty("TabPage_controles")]
		private TabPage _TabPage_controles;

		// Token: 0x040006BE RID: 1726
		[AccessedThroughProperty("TabPage_variaveis_RT850")]
		private TabPage _TabPage_variaveis_RT850;

		// Token: 0x040006BF RID: 1727
		[AccessedThroughProperty("TabPage_Ctrl_1_controle")]
		private TabPage _TabPage_Ctrl_1_controle;

		// Token: 0x040006C0 RID: 1728
		[AccessedThroughProperty("GroupBox_Ctrl_1_RT850")]
		private GroupBox _GroupBox_Ctrl_1_RT850;

		// Token: 0x040006C1 RID: 1729
		[AccessedThroughProperty("DataGridView_Ctrl_1_RT850")]
		private DataGridView _DataGridView_Ctrl_1_RT850;

		// Token: 0x040006C2 RID: 1730
		[AccessedThroughProperty("TabPage_Ctrl_4_controle")]
		private TabPage _TabPage_Ctrl_4_controle;

		// Token: 0x040006C3 RID: 1731
		[AccessedThroughProperty("TabPage_Ctrl_8_controle")]
		private TabPage _TabPage_Ctrl_8_controle;

		// Token: 0x040006C4 RID: 1732
		[AccessedThroughProperty("TabPage_Vista")]
		private TabPage _TabPage_Vista;

		// Token: 0x040006C5 RID: 1733
		[AccessedThroughProperty("GroupBox_canal_1_RT850")]
		private GroupBox _GroupBox_canal_1_RT850;

		// Token: 0x040006C6 RID: 1734
		[AccessedThroughProperty("GroupBox_variaveis_RT850")]
		private GroupBox _GroupBox_variaveis_RT850;

		// Token: 0x040006C7 RID: 1735
		[AccessedThroughProperty("DataGridView_variaveis_RT850")]
		private DataGridView _DataGridView_variaveis_RT850;

		// Token: 0x040006C8 RID: 1736
		[AccessedThroughProperty("Label_end_canal_1_RT850")]
		private Label _Label_end_canal_1_RT850;

		// Token: 0x040006C9 RID: 1737
		[AccessedThroughProperty("Label_intervalo_leitura_1_RT850")]
		private Label _Label_intervalo_leitura_1_RT850;

		// Token: 0x040006CA RID: 1738
		[AccessedThroughProperty("ComboBox_baudrate_1_RT850")]
		private ComboBox _ComboBox_baudrate_1_RT850;

		// Token: 0x040006CB RID: 1739
		[AccessedThroughProperty("Label_baudrate_1_RT850")]
		private Label _Label_baudrate_1_RT850;

		// Token: 0x040006CC RID: 1740
		[AccessedThroughProperty("NumericUpDown_timeout_1_RT850")]
		private NumericUpDown _NumericUpDown_timeout_1_RT850;

		// Token: 0x040006CD RID: 1741
		[AccessedThroughProperty("Label_timeout_1_RT850")]
		private Label _Label_timeout_1_RT850;

		// Token: 0x040006CE RID: 1742
		[AccessedThroughProperty("NumericUpDown_num_tentativas_1_RT850")]
		private NumericUpDown _NumericUpDown_num_tentativas_1_RT850;

		// Token: 0x040006CF RID: 1743
		[AccessedThroughProperty("Label_num_tentativas_1_RT850")]
		private Label _Label_num_tentativas_1_RT850;

		// Token: 0x040006D0 RID: 1744
		[AccessedThroughProperty("NumericUpDown_temp_ptt_1_RT850")]
		private NumericUpDown _NumericUpDown_temp_ptt_1_RT850;

		// Token: 0x040006D1 RID: 1745
		[AccessedThroughProperty("Label_tempo_ptt_1_RT850")]
		private Label _Label_tempo_ptt_1_RT850;

		// Token: 0x040006D2 RID: 1746
		[AccessedThroughProperty("NumericUpDown_num_erro_falha_1_RT850")]
		private NumericUpDown _NumericUpDown_num_erro_falha_1_RT850;

		// Token: 0x040006D3 RID: 1747
		[AccessedThroughProperty("Label_num_erro_falha_1_RT850")]
		private Label _Label_num_erro_falha_1_RT850;

		// Token: 0x040006D4 RID: 1748
		[AccessedThroughProperty("NumericUpDown_intervalo_leitura_1_RT850")]
		private NumericUpDown _NumericUpDown_intervalo_leitura_1_RT850;

		// Token: 0x040006D5 RID: 1749
		[AccessedThroughProperty("NumericUpDown_end_1_RT850")]
		private NumericUpDown _NumericUpDown_end_1_RT850;

		// Token: 0x040006D6 RID: 1750
		[AccessedThroughProperty("GroupBox_canal_2_RT850")]
		private GroupBox _GroupBox_canal_2_RT850;

		// Token: 0x040006D7 RID: 1751
		[AccessedThroughProperty("NumericUpDown_intervalo_leitura_2_RT850")]
		private NumericUpDown _NumericUpDown_intervalo_leitura_2_RT850;

		// Token: 0x040006D8 RID: 1752
		[AccessedThroughProperty("NumericUpDown_end_2_RT850")]
		private NumericUpDown _NumericUpDown_end_2_RT850;

		// Token: 0x040006D9 RID: 1753
		[AccessedThroughProperty("NumericUpDown_num_erro_falha_2_RT850")]
		private NumericUpDown _NumericUpDown_num_erro_falha_2_RT850;

		// Token: 0x040006DA RID: 1754
		[AccessedThroughProperty("Label_num_erro_falha_2_RT850")]
		private Label _Label_num_erro_falha_2_RT850;

		// Token: 0x040006DB RID: 1755
		[AccessedThroughProperty("NumericUpDown_num_tentativas_2_RT850")]
		private NumericUpDown _NumericUpDown_num_tentativas_2_RT850;

		// Token: 0x040006DC RID: 1756
		[AccessedThroughProperty("Label_num_tentativas_2_RT850")]
		private Label _Label_num_tentativas_2_RT850;

		// Token: 0x040006DD RID: 1757
		[AccessedThroughProperty("NumericUpDown_temp_ptt_2_RT850")]
		private NumericUpDown _NumericUpDown_temp_ptt_2_RT850;

		// Token: 0x040006DE RID: 1758
		[AccessedThroughProperty("Label_tempo_ptt_2_RT850")]
		private Label _Label_tempo_ptt_2_RT850;

		// Token: 0x040006DF RID: 1759
		[AccessedThroughProperty("NumericUpDown_timeout_2_RT850")]
		private NumericUpDown _NumericUpDown_timeout_2_RT850;

		// Token: 0x040006E0 RID: 1760
		[AccessedThroughProperty("Label_timeout_2_RT850")]
		private Label _Label_timeout_2_RT850;

		// Token: 0x040006E1 RID: 1761
		[AccessedThroughProperty("ComboBox_baudrate_2_RT850")]
		private ComboBox _ComboBox_baudrate_2_RT850;

		// Token: 0x040006E2 RID: 1762
		[AccessedThroughProperty("Label_baudrate_2_RT850")]
		private Label _Label_baudrate_2_RT850;

		// Token: 0x040006E3 RID: 1763
		[AccessedThroughProperty("Label_intervalo_leitura_2_RT850")]
		private Label _Label_intervalo_leitura_2_RT850;

		// Token: 0x040006E4 RID: 1764
		[AccessedThroughProperty("Label_end_canal_2_RT850")]
		private Label _Label_end_canal_2_RT850;

		// Token: 0x040006E5 RID: 1765
		[AccessedThroughProperty("GroupBox_msg_inicial_RT850")]
		private GroupBox _GroupBox_msg_inicial_RT850;

		// Token: 0x040006E6 RID: 1766
		[AccessedThroughProperty("GroupBox_sincronismo_RT_850")]
		private GroupBox _GroupBox_sincronismo_RT_850;

		// Token: 0x040006E7 RID: 1767
		[AccessedThroughProperty("CheckBox_sincronismo_RT850")]
		private CheckBox _CheckBox_sincronismo_RT850;

		// Token: 0x040006E8 RID: 1768
		[AccessedThroughProperty("TextBox_msg_inicial_RT850")]
		private TextBox _TextBox_msg_inicial_RT850;

		// Token: 0x040006E9 RID: 1769
		[AccessedThroughProperty("Button_ins_var_RT850")]
		private Button _Button_ins_var_RT850;

		// Token: 0x040006EA RID: 1770
		[AccessedThroughProperty("Button_del_var_RT850")]
		private Button _Button_del_var_RT850;

		// Token: 0x040006EB RID: 1771
		[AccessedThroughProperty("GroupBox_Ctrl_4_RT850")]
		private GroupBox _GroupBox_Ctrl_4_RT850;

		// Token: 0x040006EC RID: 1772
		[AccessedThroughProperty("DataGridView_Ctrl_4_RT850")]
		private DataGridView _DataGridView_Ctrl_4_RT850;

		// Token: 0x040006ED RID: 1773
		[AccessedThroughProperty("GroupBox_Ctrl_8_RT850")]
		private GroupBox _GroupBox_Ctrl_8_RT850;

		// Token: 0x040006EE RID: 1774
		[AccessedThroughProperty("DataGridView_Ctrl_8_RT850")]
		private DataGridView _DataGridView_Ctrl_8_RT850;

		// Token: 0x040006EF RID: 1775
		[AccessedThroughProperty("OpenFileDialog_RT850")]
		private OpenFileDialog _OpenFileDialog_RT850;

		// Token: 0x040006F0 RID: 1776
		[AccessedThroughProperty("SaveFileDialog_RT850")]
		private SaveFileDialog _SaveFileDialog_RT850;

		// Token: 0x040006F1 RID: 1777
		[AccessedThroughProperty("Timer_limpa_MSG_RT850")]
		private Timer _Timer_limpa_MSG_RT850;

		// Token: 0x040006F2 RID: 1778
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040006F3 RID: 1779
		[AccessedThroughProperty("GroupBox_Vista_RT850")]
		private GroupBox _GroupBox_Vista_RT850;

		// Token: 0x040006F4 RID: 1780
		[AccessedThroughProperty("DataGridView_vista_variaveis_RT_850")]
		private DataGridView _DataGridView_vista_variaveis_RT_850;

		// Token: 0x040006F5 RID: 1781
		[AccessedThroughProperty("GroupBox_parametros_vista")]
		private GroupBox _GroupBox_parametros_vista;

		// Token: 0x040006F6 RID: 1782
		[AccessedThroughProperty("ComboBox_Seleciona_Vista_RT_850")]
		private ComboBox _ComboBox_Seleciona_Vista_RT_850;

		// Token: 0x040006F7 RID: 1783
		[AccessedThroughProperty("GroupBox_variaveis")]
		private GroupBox _GroupBox_variaveis;

		// Token: 0x040006F8 RID: 1784
		[AccessedThroughProperty("GroupBox_equipamentos_vista")]
		private GroupBox _GroupBox_equipamentos_vista;

		// Token: 0x040006F9 RID: 1785
		[AccessedThroughProperty("DataGridView_vista_equipamentos_RT_850")]
		private DataGridView _DataGridView_vista_equipamentos_RT_850;

		// Token: 0x040006FA RID: 1786
		[AccessedThroughProperty("Label_nome_vista")]
		private Label _Label_nome_vista;

		// Token: 0x040006FB RID: 1787
		[AccessedThroughProperty("TextBox_nome_vista")]
		private TextBox _TextBox_nome_vista;

		// Token: 0x040006FC RID: 1788
		[AccessedThroughProperty("ComboBox_porta_vista_RT_850")]
		private ComboBox _ComboBox_porta_vista_RT_850;

		// Token: 0x040006FD RID: 1789
		[AccessedThroughProperty("Label_porta_vista")]
		private Label _Label_porta_vista;

		// Token: 0x040006FE RID: 1790
		[AccessedThroughProperty("ComboBox_prioridade_vista_RT_850")]
		private ComboBox _ComboBox_prioridade_vista_RT_850;

		// Token: 0x040006FF RID: 1791
		[AccessedThroughProperty("Label_prioridade_vista")]
		private Label _Label_prioridade_vista;

		// Token: 0x04000700 RID: 1792
		[AccessedThroughProperty("ComboBox_timeout_vista_RT_850")]
		private ComboBox _ComboBox_timeout_vista_RT_850;

		// Token: 0x04000701 RID: 1793
		[AccessedThroughProperty("Label_timeout_vista")]
		private Label _Label_timeout_vista;

		// Token: 0x04000702 RID: 1794
		[AccessedThroughProperty("NumericUpDown_num_equip_vista")]
		private NumericUpDown _NumericUpDown_num_equip_vista;

		// Token: 0x04000703 RID: 1795
		[AccessedThroughProperty("Label_num_equip_vista")]
		private Label _Label_num_equip_vista;

		// Token: 0x04000704 RID: 1796
		[AccessedThroughProperty("NumericUpDown_num_var_vista")]
		private NumericUpDown _NumericUpDown_num_var_vista;

		// Token: 0x04000705 RID: 1797
		[AccessedThroughProperty("Label_num_var_vista")]
		private Label _Label_num_var_vista;

		// Token: 0x04000706 RID: 1798
		[AccessedThroughProperty("ComboBox_modelo_vista_RT_850")]
		private ComboBox _ComboBox_modelo_vista_RT_850;

		// Token: 0x04000707 RID: 1799
		[AccessedThroughProperty("Label_modelo_vista")]
		private Label _Label_modelo_vista;

		// Token: 0x04000708 RID: 1800
		[AccessedThroughProperty("ToolStripButton_RT850_Imprimir")]
		private ToolStripButton _ToolStripButton_RT850_Imprimir;

		// Token: 0x04000709 RID: 1801
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x0400070A RID: 1802
		[AccessedThroughProperty("PrintDocument1")]
		private PrintDocument _PrintDocument1;

		// Token: 0x0400070B RID: 1803
		[AccessedThroughProperty("PrintPreviewDialog1")]
		private PrintPreviewDialog _PrintPreviewDialog1;

		// Token: 0x0400070C RID: 1804
		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		// Token: 0x0400070D RID: 1805
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x0400070E RID: 1806
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x0400070F RID: 1807
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x04000710 RID: 1808
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x04000711 RID: 1809
		[AccessedThroughProperty("T_AlturaAntena1")]
		private TextBox _T_AlturaAntena1;

		// Token: 0x04000712 RID: 1810
		[AccessedThroughProperty("T_Latitude1")]
		private TextBox _T_Latitude1;

		// Token: 0x04000713 RID: 1811
		[AccessedThroughProperty("T_Longitude1")]
		private TextBox _T_Longitude1;

		// Token: 0x04000714 RID: 1812
		[AccessedThroughProperty("T_Azimute1")]
		private TextBox _T_Azimute1;

		// Token: 0x04000715 RID: 1813
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000716 RID: 1814
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000717 RID: 1815
		[AccessedThroughProperty("T_FreqRadio1")]
		private TextBox _T_FreqRadio1;

		// Token: 0x04000718 RID: 1816
		[AccessedThroughProperty("T_PotRadio1")]
		private TextBox _T_PotRadio1;

		// Token: 0x04000719 RID: 1817
		[AccessedThroughProperty("CB_ModeloRadio1")]
		private ComboBox _CB_ModeloRadio1;

		// Token: 0x0400071A RID: 1818
		[AccessedThroughProperty("CB_PolarizacaoAntena1")]
		private ComboBox _CB_PolarizacaoAntena1;

		// Token: 0x0400071B RID: 1819
		[AccessedThroughProperty("CB_TipoAntena1")]
		private ComboBox _CB_TipoAntena1;

		// Token: 0x0400071C RID: 1820
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x0400071D RID: 1821
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x0400071E RID: 1822
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x0400071F RID: 1823
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000720 RID: 1824
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000721 RID: 1825
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000722 RID: 1826
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000723 RID: 1827
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000724 RID: 1828
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x04000725 RID: 1829
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000726 RID: 1830
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000727 RID: 1831
		[AccessedThroughProperty("T_AlturaAntena2")]
		private TextBox _T_AlturaAntena2;

		// Token: 0x04000728 RID: 1832
		[AccessedThroughProperty("T_Latitude2")]
		private TextBox _T_Latitude2;

		// Token: 0x04000729 RID: 1833
		[AccessedThroughProperty("T_Longitude2")]
		private TextBox _T_Longitude2;

		// Token: 0x0400072A RID: 1834
		[AccessedThroughProperty("T_Azimute2")]
		private TextBox _T_Azimute2;

		// Token: 0x0400072B RID: 1835
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x0400072C RID: 1836
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x0400072D RID: 1837
		[AccessedThroughProperty("T_FreqRadio2")]
		private TextBox _T_FreqRadio2;

		// Token: 0x0400072E RID: 1838
		[AccessedThroughProperty("T_PotRadio2")]
		private TextBox _T_PotRadio2;

		// Token: 0x0400072F RID: 1839
		[AccessedThroughProperty("CB_ModeloRadio2")]
		private ComboBox _CB_ModeloRadio2;

		// Token: 0x04000730 RID: 1840
		[AccessedThroughProperty("CB_PolarizacaoAntena2")]
		private ComboBox _CB_PolarizacaoAntena2;

		// Token: 0x04000731 RID: 1841
		[AccessedThroughProperty("CB_TipoAntena2")]
		private ComboBox _CB_TipoAntena2;

		// Token: 0x04000732 RID: 1842
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x04000733 RID: 1843
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		// Token: 0x04000734 RID: 1844
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		// Token: 0x04000735 RID: 1845
		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		// Token: 0x04000736 RID: 1846
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		// Token: 0x04000737 RID: 1847
		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		// Token: 0x04000738 RID: 1848
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		// Token: 0x04000739 RID: 1849
		[AccessedThroughProperty("Label27")]
		private Label _Label27;

		// Token: 0x0400073A RID: 1850
		[AccessedThroughProperty("Label28")]
		private Label _Label28;

		// Token: 0x0400073B RID: 1851
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x0400073C RID: 1852
		[AccessedThroughProperty("ToolStripLabel1")]
		private ToolStripLabel _ToolStripLabel1;

		// Token: 0x0400073D RID: 1853
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x0400073E RID: 1854
		[AccessedThroughProperty("TextBox_equipamento_RT850")]
		private TextBox _TextBox_equipamento_RT850;

		// Token: 0x0400073F RID: 1855
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x04000740 RID: 1856
		[AccessedThroughProperty("TextBox_release_RT850")]
		private TextBox _TextBox_release_RT850;

		// Token: 0x04000741 RID: 1857
		[AccessedThroughProperty("Label29")]
		private Label _Label29;

		// Token: 0x04000742 RID: 1858
		[AccessedThroughProperty("TextBox_build_RT850")]
		private TextBox _TextBox_build_RT850;

		// Token: 0x04000743 RID: 1859
		[AccessedThroughProperty("Label30")]
		private Label _Label30;

		// Token: 0x04000744 RID: 1860
		[AccessedThroughProperty("TextBox_versao_RT850")]
		private TextBox _TextBox_versao_RT850;

		// Token: 0x04000745 RID: 1861
		[AccessedThroughProperty("Label31")]
		private Label _Label31;

		// Token: 0x04000746 RID: 1862
		[AccessedThroughProperty("tb_lixo1")]
		private TextBox _tb_lixo1;

		// Token: 0x04000747 RID: 1863
		[AccessedThroughProperty("tb_lixo2")]
		private TextBox _tb_lixo2;

		// Token: 0x04000748 RID: 1864
		[AccessedThroughProperty("tb_lixo4")]
		private TextBox _tb_lixo4;

		// Token: 0x04000749 RID: 1865
		[AccessedThroughProperty("tb_lixo5")]
		private TextBox _tb_lixo5;

		// Token: 0x0400074A RID: 1866
		[AccessedThroughProperty("tb_lixo6")]
		private TextBox _tb_lixo6;

		// Token: 0x0400074B RID: 1867
		[AccessedThroughProperty("tb_lixo7")]
		private TextBox _tb_lixo7;

		// Token: 0x0400074C RID: 1868
		[AccessedThroughProperty("tb_lixo8")]
		private TextBox _tb_lixo8;

		// Token: 0x0400074D RID: 1869
		[AccessedThroughProperty("tb_lixo9")]
		private TextBox _tb_lixo9;

		// Token: 0x0400074E RID: 1870
		[AccessedThroughProperty("TabPage_cfg_msg_alarme")]
		private TabPage _TabPage_cfg_msg_alarme;

		// Token: 0x0400074F RID: 1871
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x04000750 RID: 1872
		[AccessedThroughProperty("dgv_Msg_Alarmes")]
		private DataGridView _dgv_Msg_Alarmes;

		// Token: 0x04000751 RID: 1873
		[AccessedThroughProperty("Label32")]
		private Label _Label32;

		// Token: 0x04000752 RID: 1874
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000753 RID: 1875
		[AccessedThroughProperty("DataGridView_equip_1_RT850")]
		private DataGridView _DataGridView_equip_1_RT850;

		// Token: 0x04000754 RID: 1876
		[AccessedThroughProperty("Col_Quantidade")]
		private DataGridViewTextBoxColumn _Col_Quantidade;

		// Token: 0x04000755 RID: 1877
		[AccessedThroughProperty("Col_Endereco")]
		private DataGridViewTextBoxColumn _Col_Endereco;

		// Token: 0x04000756 RID: 1878
		[AccessedThroughProperty("tb_lixo3")]
		private TextBox _tb_lixo3;

		// Token: 0x04000757 RID: 1879
		[AccessedThroughProperty("Alm_col_mensagem")]
		private DataGridViewTextBoxColumn _Alm_col_mensagem;

		// Token: 0x04000758 RID: 1880
		[AccessedThroughProperty("CheckBox_conf_resp")]
		private CheckBox _CheckBox_conf_resp;

		// Token: 0x04000759 RID: 1881
		[AccessedThroughProperty("nud_estatistica_ch2")]
		private NumericUpDown _nud_estatistica_ch2;

		// Token: 0x0400075A RID: 1882
		[AccessedThroughProperty("Label34")]
		private Label _Label34;

		// Token: 0x0400075B RID: 1883
		[AccessedThroughProperty("nud_estatistica_ch1")]
		private NumericUpDown _nud_estatistica_ch1;

		// Token: 0x0400075C RID: 1884
		[AccessedThroughProperty("Label33")]
		private Label _Label33;

		// Token: 0x0400075D RID: 1885
		[AccessedThroughProperty("ckb_modo_estatistica")]
		private CheckBox _ckb_modo_estatistica;

		// Token: 0x0400075E RID: 1886
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x0400075F RID: 1887
		[AccessedThroughProperty("T_ModeloFonte")]
		private TextBox _T_ModeloFonte;

		// Token: 0x04000760 RID: 1888
		[AccessedThroughProperty("Label35")]
		private Label _Label35;

		// Token: 0x04000761 RID: 1889
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		// Token: 0x04000762 RID: 1890
		[AccessedThroughProperty("cb_remota")]
		private ComboBox _cb_remota;

		// Token: 0x04000763 RID: 1891
		[AccessedThroughProperty("cb_supervisorio")]
		private ComboBox _cb_supervisorio;

		// Token: 0x04000764 RID: 1892
		[AccessedThroughProperty("Label37")]
		private Label _Label37;

		// Token: 0x04000765 RID: 1893
		[AccessedThroughProperty("Label36")]
		private Label _Label36;

		// Token: 0x04000766 RID: 1894
		[AccessedThroughProperty("GroupBox7")]
		private GroupBox _GroupBox7;

		// Token: 0x04000767 RID: 1895
		[AccessedThroughProperty("Label39")]
		private Label _Label39;

		// Token: 0x04000768 RID: 1896
		[AccessedThroughProperty("Label38")]
		private Label _Label38;

		// Token: 0x04000769 RID: 1897
		[AccessedThroughProperty("cb_teclado_RT850")]
		private CheckBox _cb_teclado_RT850;

		// Token: 0x0400076A RID: 1898
		private int pagina_impressao;

		// Token: 0x0400076B RID: 1899
		private int grupo_impressao;

		// Token: 0x0400076C RID: 1900
		private int quantos_imprimiu;

		// Token: 0x0400076D RID: 1901
		private int quantos_imprimiu2;

		// Token: 0x0400076E RID: 1902
		private int quantos_imprimiu3;

		// Token: 0x0400076F RID: 1903
		private int quantos_imprimiu4;

		// Token: 0x04000770 RID: 1904
		private int inicio;
	}
}
