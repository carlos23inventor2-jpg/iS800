using System;
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
	// Token: 0x02000025 RID: 37
	[DesignerGenerated]
	public partial class RT_831_200_configurador : Form
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x0027C4D0 File Offset: 0x0027A8D0
		public RT_831_200_configurador()
		{
			base.FormClosing += new FormClosingEventHandler(this.RT_850_conf_FormClosing);
			base.FormClosed += new FormClosedEventHandler(this.RT_850_conf_FormClosed);
			base.Load += new EventHandler(this.RT_850_conf_Load);
			base.Activated += new EventHandler(this.RT_850_conf_Activated);
			this.InitializeComponent();
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x002803C0 File Offset: 0x0027E7C0
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x002803D4 File Offset: 0x0027E7D4
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00280420 File Offset: 0x0027E820
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00280434 File Offset: 0x0027E834
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

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00280480 File Offset: 0x0027E880
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x00280494 File Offset: 0x0027E894
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

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002CA RID: 714 RVA: 0x002804E0 File Offset: 0x0027E8E0
		// (set) Token: 0x060002CB RID: 715 RVA: 0x002804F4 File Offset: 0x0027E8F4
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

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00280540 File Offset: 0x0027E940
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00280554 File Offset: 0x0027E954
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

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00280560 File Offset: 0x0027E960
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00280574 File Offset: 0x0027E974
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

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x002805C0 File Offset: 0x0027E9C0
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x002805D4 File Offset: 0x0027E9D4
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

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00280620 File Offset: 0x0027EA20
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x00280634 File Offset: 0x0027EA34
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

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00280640 File Offset: 0x0027EA40
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00280654 File Offset: 0x0027EA54
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

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00280660 File Offset: 0x0027EA60
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00280674 File Offset: 0x0027EA74
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

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00280680 File Offset: 0x0027EA80
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00280694 File Offset: 0x0027EA94
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

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002DA RID: 730 RVA: 0x002806E0 File Offset: 0x0027EAE0
		// (set) Token: 0x060002DB RID: 731 RVA: 0x002806F4 File Offset: 0x0027EAF4
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

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00280700 File Offset: 0x0027EB00
		// (set) Token: 0x060002DD RID: 733 RVA: 0x00280714 File Offset: 0x0027EB14
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

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002DE RID: 734 RVA: 0x00280720 File Offset: 0x0027EB20
		// (set) Token: 0x060002DF RID: 735 RVA: 0x00280734 File Offset: 0x0027EB34
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

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00280740 File Offset: 0x0027EB40
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00280754 File Offset: 0x0027EB54
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

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00280760 File Offset: 0x0027EB60
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x00280774 File Offset: 0x0027EB74
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

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00280780 File Offset: 0x0027EB80
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x00280794 File Offset: 0x0027EB94
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

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x002807A0 File Offset: 0x0027EBA0
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x002807B4 File Offset: 0x0027EBB4
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x002807C0 File Offset: 0x0027EBC0
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x002807D4 File Offset: 0x0027EBD4
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002EA RID: 746 RVA: 0x002807E0 File Offset: 0x0027EBE0
		// (set) Token: 0x060002EB RID: 747 RVA: 0x002807F4 File Offset: 0x0027EBF4
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00280800 File Offset: 0x0027EC00
		// (set) Token: 0x060002ED RID: 749 RVA: 0x00280814 File Offset: 0x0027EC14
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

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00280820 File Offset: 0x0027EC20
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00280834 File Offset: 0x0027EC34
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00280840 File Offset: 0x0027EC40
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00280854 File Offset: 0x0027EC54
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

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00280860 File Offset: 0x0027EC60
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00280874 File Offset: 0x0027EC74
		internal virtual ComboBox ComboBox_baudrate_RT850
		{
			get
			{
				return this._ComboBox_baudrate_RT850;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_baudrate_1_RT850_SelectedIndexChanged);
				if (this._ComboBox_baudrate_RT850 != null)
				{
					this._ComboBox_baudrate_RT850.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_baudrate_RT850 = value;
				if (this._ComboBox_baudrate_RT850 != null)
				{
					this._ComboBox_baudrate_RT850.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x002808C0 File Offset: 0x0027ECC0
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x002808D4 File Offset: 0x0027ECD4
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

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x002808E0 File Offset: 0x0027ECE0
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x002808F4 File Offset: 0x0027ECF4
		internal virtual NumericUpDown NumericUpDown_end_estacao
		{
			get
			{
				return this._NumericUpDown_end_estacao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_estacao_ValueChanged);
				if (this._NumericUpDown_end_estacao != null)
				{
					this._NumericUpDown_end_estacao.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_estacao = value;
				if (this._NumericUpDown_end_estacao != null)
				{
					this._NumericUpDown_end_estacao.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00280940 File Offset: 0x0027ED40
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00280954 File Offset: 0x0027ED54
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

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00280960 File Offset: 0x0027ED60
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00280974 File Offset: 0x0027ED74
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

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002FC RID: 764 RVA: 0x002809C0 File Offset: 0x0027EDC0
		// (set) Token: 0x060002FD RID: 765 RVA: 0x002809D4 File Offset: 0x0027EDD4
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

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060002FE RID: 766 RVA: 0x002809E0 File Offset: 0x0027EDE0
		// (set) Token: 0x060002FF RID: 767 RVA: 0x002809F4 File Offset: 0x0027EDF4
		internal virtual NumericUpDown NumericUpDown_end_mestre
		{
			get
			{
				return this._NumericUpDown_end_mestre;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_1_RT850_ValueChanged);
				if (this._NumericUpDown_end_mestre != null)
				{
					this._NumericUpDown_end_mestre.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_mestre = value;
				if (this._NumericUpDown_end_mestre != null)
				{
					this._NumericUpDown_end_mestre.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00280A40 File Offset: 0x0027EE40
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00280A54 File Offset: 0x0027EE54
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

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00280A60 File Offset: 0x0027EE60
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00280A74 File Offset: 0x0027EE74
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

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00280A80 File Offset: 0x0027EE80
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00280A94 File Offset: 0x0027EE94
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

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00280AE0 File Offset: 0x0027EEE0
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00280AF4 File Offset: 0x0027EEF4
		internal virtual TabPage TabPage_Equipamentos
		{
			get
			{
				return this._TabPage_Equipamentos;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_Equipamentos = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00280B00 File Offset: 0x0027EF00
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00280B14 File Offset: 0x0027EF14
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

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00280B20 File Offset: 0x0027EF20
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00280B34 File Offset: 0x0027EF34
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

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600030C RID: 780 RVA: 0x00280B80 File Offset: 0x0027EF80
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00280B94 File Offset: 0x0027EF94
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

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00280BA0 File Offset: 0x0027EFA0
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00280BB4 File Offset: 0x0027EFB4
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000310 RID: 784 RVA: 0x00280C4C File Offset: 0x0027F04C
		// (set) Token: 0x06000311 RID: 785 RVA: 0x00280C60 File Offset: 0x0027F060
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

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00280CAC File Offset: 0x0027F0AC
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00280CC0 File Offset: 0x0027F0C0
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

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00280CCC File Offset: 0x0027F0CC
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00280CE0 File Offset: 0x0027F0E0
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

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00280CEC File Offset: 0x0027F0EC
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00280D00 File Offset: 0x0027F100
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

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00280D0C File Offset: 0x0027F10C
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00280D20 File Offset: 0x0027F120
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

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00280D2C File Offset: 0x0027F12C
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00280D40 File Offset: 0x0027F140
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

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00280D4C File Offset: 0x0027F14C
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00280D60 File Offset: 0x0027F160
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

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00280D6C File Offset: 0x0027F16C
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00280D80 File Offset: 0x0027F180
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

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00280D8C File Offset: 0x0027F18C
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00280DA0 File Offset: 0x0027F1A0
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

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00280DAC File Offset: 0x0027F1AC
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00280DC0 File Offset: 0x0027F1C0
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

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00280DCC File Offset: 0x0027F1CC
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00280DE0 File Offset: 0x0027F1E0
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

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00280DEC File Offset: 0x0027F1EC
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00280E00 File Offset: 0x0027F200
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

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00280E0C File Offset: 0x0027F20C
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00280E20 File Offset: 0x0027F220
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

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00280E2C File Offset: 0x0027F22C
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00280E40 File Offset: 0x0027F240
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

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00280E4C File Offset: 0x0027F24C
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00280E60 File Offset: 0x0027F260
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

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00280E6C File Offset: 0x0027F26C
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00280E80 File Offset: 0x0027F280
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

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00280E8C File Offset: 0x0027F28C
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00280EA0 File Offset: 0x0027F2A0
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

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00280EAC File Offset: 0x0027F2AC
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00280EC0 File Offset: 0x0027F2C0
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

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00280ECC File Offset: 0x0027F2CC
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00280EE0 File Offset: 0x0027F2E0
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

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00280EEC File Offset: 0x0027F2EC
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00280F00 File Offset: 0x0027F300
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

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00280F0C File Offset: 0x0027F30C
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00280F20 File Offset: 0x0027F320
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

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00280F2C File Offset: 0x0027F32C
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00280F40 File Offset: 0x0027F340
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

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00280F4C File Offset: 0x0027F34C
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00280F60 File Offset: 0x0027F360
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

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00280F6C File Offset: 0x0027F36C
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00280F80 File Offset: 0x0027F380
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00280F8C File Offset: 0x0027F38C
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00280FA0 File Offset: 0x0027F3A0
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

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00280FAC File Offset: 0x0027F3AC
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00280FC0 File Offset: 0x0027F3C0
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

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00280FCC File Offset: 0x0027F3CC
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00280FE0 File Offset: 0x0027F3E0
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

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00280FEC File Offset: 0x0027F3EC
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00281000 File Offset: 0x0027F400
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

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0028100C File Offset: 0x0027F40C
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00281020 File Offset: 0x0027F420
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

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0028102C File Offset: 0x0027F42C
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00281040 File Offset: 0x0027F440
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

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0028104C File Offset: 0x0027F44C
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00281060 File Offset: 0x0027F460
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

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0028106C File Offset: 0x0027F46C
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00281080 File Offset: 0x0027F480
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

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0028108C File Offset: 0x0027F48C
		// (set) Token: 0x06000351 RID: 849 RVA: 0x002810A0 File Offset: 0x0027F4A0
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

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000352 RID: 850 RVA: 0x002810AC File Offset: 0x0027F4AC
		// (set) Token: 0x06000353 RID: 851 RVA: 0x002810C0 File Offset: 0x0027F4C0
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

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000354 RID: 852 RVA: 0x002810CC File Offset: 0x0027F4CC
		// (set) Token: 0x06000355 RID: 853 RVA: 0x002810E0 File Offset: 0x0027F4E0
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

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000356 RID: 854 RVA: 0x002810EC File Offset: 0x0027F4EC
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00281100 File Offset: 0x0027F500
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

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0028110C File Offset: 0x0027F50C
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00281120 File Offset: 0x0027F520
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

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0028112C File Offset: 0x0027F52C
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00281140 File Offset: 0x0027F540
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

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0028114C File Offset: 0x0027F54C
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00281160 File Offset: 0x0027F560
		internal virtual NumericUpDown nud_numero_equipamentos_recalque
		{
			get
			{
				return this._nud_numero_equipamentos_recalque;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_numero_equipamentos_recalque_ValueChanged);
				if (this._nud_numero_equipamentos_recalque != null)
				{
					this._nud_numero_equipamentos_recalque.ValueChanged -= eventHandler;
				}
				this._nud_numero_equipamentos_recalque = value;
				if (this._nud_numero_equipamentos_recalque != null)
				{
					this._nud_numero_equipamentos_recalque.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600035E RID: 862 RVA: 0x002811AC File Offset: 0x0027F5AC
		// (set) Token: 0x0600035F RID: 863 RVA: 0x002811C0 File Offset: 0x0027F5C0
		internal virtual NumericUpDown nud_numero_equipamentos_reservatorios
		{
			get
			{
				return this._nud_numero_equipamentos_reservatorios;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_numero_equipamentos_reservatorios_ValueChanged);
				if (this._nud_numero_equipamentos_reservatorios != null)
				{
					this._nud_numero_equipamentos_reservatorios.ValueChanged -= eventHandler;
				}
				this._nud_numero_equipamentos_reservatorios = value;
				if (this._nud_numero_equipamentos_reservatorios != null)
				{
					this._nud_numero_equipamentos_reservatorios.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0028120C File Offset: 0x0027F60C
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00281220 File Offset: 0x0027F620
		internal virtual TabPage TabPage_Reservatorio
		{
			get
			{
				return this._TabPage_Reservatorio;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_Reservatorio = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0028122C File Offset: 0x0027F62C
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00281240 File Offset: 0x0027F640
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

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0028124C File Offset: 0x0027F64C
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00281260 File Offset: 0x0027F660
		internal virtual DataGridView DataGridView_Reservatorios
		{
			get
			{
				return this._DataGridView_Reservatorios;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_Reservatorios_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_Reservatorios_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_Reservatorios_CellValidating);
				if (this._DataGridView_Reservatorios != null)
				{
					this._DataGridView_Reservatorios.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_Reservatorios.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_Reservatorios.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_Reservatorios = value;
				if (this._DataGridView_Reservatorios != null)
				{
					this._DataGridView_Reservatorios.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_Reservatorios.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_Reservatorios.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000366 RID: 870 RVA: 0x002812F8 File Offset: 0x0027F6F8
		// (set) Token: 0x06000367 RID: 871 RVA: 0x0028130C File Offset: 0x0027F70C
		internal virtual TabPage TabPage_Recalque
		{
			get
			{
				return this._TabPage_Recalque;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_Recalque = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00281318 File Offset: 0x0027F718
		// (set) Token: 0x06000369 RID: 873 RVA: 0x0028132C File Offset: 0x0027F72C
		internal virtual DataGridView DataGridView_Recalques
		{
			get
			{
				return this._DataGridView_Recalques;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_Recalques_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_Recalques_CellValidating);
				if (this._DataGridView_Recalques != null)
				{
					this._DataGridView_Recalques.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_Recalques.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_Recalques = value;
				if (this._DataGridView_Recalques != null)
				{
					this._DataGridView_Recalques.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_Recalques.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0028139C File Offset: 0x0027F79C
		// (set) Token: 0x0600036B RID: 875 RVA: 0x002813B0 File Offset: 0x0027F7B0
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

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600036C RID: 876 RVA: 0x002813BC File Offset: 0x0027F7BC
		// (set) Token: 0x0600036D RID: 877 RVA: 0x002813D0 File Offset: 0x0027F7D0
		internal virtual DataGridViewTextBoxColumn RES_Posicao
		{
			get
			{
				return this._RES_Posicao;
			}
			[MethodImpl(32)]
			set
			{
				this._RES_Posicao = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600036E RID: 878 RVA: 0x002813DC File Offset: 0x0027F7DC
		// (set) Token: 0x0600036F RID: 879 RVA: 0x002813F0 File Offset: 0x0027F7F0
		internal virtual DataGridViewTextBoxColumn RES_Nome
		{
			get
			{
				return this._RES_Nome;
			}
			[MethodImpl(32)]
			set
			{
				this._RES_Nome = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000370 RID: 880 RVA: 0x002813FC File Offset: 0x0027F7FC
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00281410 File Offset: 0x0027F810
		internal virtual DataGridViewTextBoxColumn REC_Posicao
		{
			get
			{
				return this._REC_Posicao;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Posicao = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0028141C File Offset: 0x0027F81C
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00281430 File Offset: 0x0027F830
		internal virtual DataGridViewTextBoxColumn REC_Nome
		{
			get
			{
				return this._REC_Nome;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Nome = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0028143C File Offset: 0x0027F83C
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00281450 File Offset: 0x0027F850
		internal virtual DataGridViewComboBoxColumn REC_Modelo
		{
			get
			{
				return this._REC_Modelo;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Modelo = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0028145C File Offset: 0x0027F85C
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00281470 File Offset: 0x0027F870
		internal virtual DataGridViewComboBoxColumn REC_HabCMD
		{
			get
			{
				return this._REC_HabCMD;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_HabCMD = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000378 RID: 888 RVA: 0x0028147C File Offset: 0x0027F87C
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00281490 File Offset: 0x0027F890
		internal virtual DataGridViewTextBoxColumn REC_Escala1
		{
			get
			{
				return this._REC_Escala1;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Escala1 = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0028149C File Offset: 0x0027F89C
		// (set) Token: 0x0600037B RID: 891 RVA: 0x002814B0 File Offset: 0x0027F8B0
		internal virtual DataGridViewTextBoxColumn REC_Escala2
		{
			get
			{
				return this._REC_Escala2;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Escala2 = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600037C RID: 892 RVA: 0x002814BC File Offset: 0x0027F8BC
		// (set) Token: 0x0600037D RID: 893 RVA: 0x002814D0 File Offset: 0x0027F8D0
		internal virtual DataGridViewTextBoxColumn REC_Escala3
		{
			get
			{
				return this._REC_Escala3;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Escala3 = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600037E RID: 894 RVA: 0x002814DC File Offset: 0x0027F8DC
		// (set) Token: 0x0600037F RID: 895 RVA: 0x002814F0 File Offset: 0x0027F8F0
		internal virtual DataGridViewTextBoxColumn REC_Escala4
		{
			get
			{
				return this._REC_Escala4;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Escala4 = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000380 RID: 896 RVA: 0x002814FC File Offset: 0x0027F8FC
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00281510 File Offset: 0x0027F910
		internal virtual DataGridViewTextBoxColumn REC_Escala5
		{
			get
			{
				return this._REC_Escala5;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Escala5 = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0028151C File Offset: 0x0027F91C
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00281530 File Offset: 0x0027F930
		internal virtual DataGridViewTextBoxColumn REC_Escala6
		{
			get
			{
				return this._REC_Escala6;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Escala6 = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0028153C File Offset: 0x0027F93C
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00281550 File Offset: 0x0027F950
		internal virtual DataGridViewTextBoxColumn REC_Escala7
		{
			get
			{
				return this._REC_Escala7;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Escala7 = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0028155C File Offset: 0x0027F95C
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00281570 File Offset: 0x0027F970
		internal virtual DataGridViewTextBoxColumn REC_Escala8
		{
			get
			{
				return this._REC_Escala8;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Escala8 = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0028157C File Offset: 0x0027F97C
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00281590 File Offset: 0x0027F990
		internal virtual DataGridViewTextBoxColumn REC_Escala9
		{
			get
			{
				return this._REC_Escala9;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Escala9 = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0028159C File Offset: 0x0027F99C
		// (set) Token: 0x0600038B RID: 907 RVA: 0x002815B0 File Offset: 0x0027F9B0
		internal virtual DataGridViewTextBoxColumn REC_Escala10
		{
			get
			{
				return this._REC_Escala10;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Escala10 = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600038C RID: 908 RVA: 0x002815BC File Offset: 0x0027F9BC
		// (set) Token: 0x0600038D RID: 909 RVA: 0x002815D0 File Offset: 0x0027F9D0
		internal virtual DataGridViewTextBoxColumn REC_Escala11
		{
			get
			{
				return this._REC_Escala11;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Escala11 = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600038E RID: 910 RVA: 0x002815DC File Offset: 0x0027F9DC
		// (set) Token: 0x0600038F RID: 911 RVA: 0x002815F0 File Offset: 0x0027F9F0
		internal virtual DataGridViewTextBoxColumn REC_Escala12
		{
			get
			{
				return this._REC_Escala12;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Escala12 = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000390 RID: 912 RVA: 0x002815FC File Offset: 0x0027F9FC
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00281610 File Offset: 0x0027FA10
		internal virtual DataGridViewTextBoxColumn REC_Escala13
		{
			get
			{
				return this._REC_Escala13;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Escala13 = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0028161C File Offset: 0x0027FA1C
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00281630 File Offset: 0x0027FA30
		internal virtual DataGridViewTextBoxColumn REC_Escala14
		{
			get
			{
				return this._REC_Escala14;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Escala14 = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0028163C File Offset: 0x0027FA3C
		// (set) Token: 0x06000395 RID: 917 RVA: 0x00281650 File Offset: 0x0027FA50
		internal virtual DataGridViewTextBoxColumn REC_Escala15
		{
			get
			{
				return this._REC_Escala15;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Escala15 = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0028165C File Offset: 0x0027FA5C
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00281670 File Offset: 0x0027FA70
		internal virtual DataGridViewTextBoxColumn REC_Escala16
		{
			get
			{
				return this._REC_Escala16;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Escala16 = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0028167C File Offset: 0x0027FA7C
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00281690 File Offset: 0x0027FA90
		internal virtual TabPage TabPage_Senha
		{
			get
			{
				return this._TabPage_Senha;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_Senha = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0028169C File Offset: 0x0027FA9C
		// (set) Token: 0x0600039B RID: 923 RVA: 0x002816B0 File Offset: 0x0027FAB0
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

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600039C RID: 924 RVA: 0x002816BC File Offset: 0x0027FABC
		// (set) Token: 0x0600039D RID: 925 RVA: 0x002816D0 File Offset: 0x0027FAD0
		internal virtual NumericUpDown NumericUpDown_senha
		{
			get
			{
				return this._NumericUpDown_senha;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_senha_ValueChanged);
				if (this._NumericUpDown_senha != null)
				{
					this._NumericUpDown_senha.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_senha = value;
				if (this._NumericUpDown_senha != null)
				{
					this._NumericUpDown_senha.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0028171C File Offset: 0x0027FB1C
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00281730 File Offset: 0x0027FB30
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

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0028173C File Offset: 0x0027FB3C
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00281750 File Offset: 0x0027FB50
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

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0028175C File Offset: 0x0027FB5C
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00281770 File Offset: 0x0027FB70
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

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0028177C File Offset: 0x0027FB7C
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00281790 File Offset: 0x0027FB90
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

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0028179C File Offset: 0x0027FB9C
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x002817B0 File Offset: 0x0027FBB0
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

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x002817BC File Offset: 0x0027FBBC
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x002817D0 File Offset: 0x0027FBD0
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

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060003AA RID: 938 RVA: 0x002817DC File Offset: 0x0027FBDC
		// (set) Token: 0x060003AB RID: 939 RVA: 0x002817F0 File Offset: 0x0027FBF0
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

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060003AC RID: 940 RVA: 0x002817FC File Offset: 0x0027FBFC
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00281810 File Offset: 0x0027FC10
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

		// Token: 0x060003AE RID: 942 RVA: 0x0028181C File Offset: 0x0027FC1C
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
			this.ToolStri_RT850.Enabled = true;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00281898 File Offset: 0x0027FC98
		private void RT_850_conf_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0028189C File Offset: 0x0027FC9C
		private void RT_850_conf_Load(object sender, EventArgs e)
		{
			RT_geral.Lmte_Init_ok = false;
			RT_831_200_redimX.RT_831_200_redim();
			RT_831_200_inicializa_variavies_X.RT_831_200_inicializa_variaveis();
			this.AtualizaTodosNUD();
			this.AtualizaTodosCOMBOBOX();
			RT_831_200_valores_default_X.RT_831_200_valores_default();
			RT_geral.RT_850_BD.Nome_Arquivo = "";
			this.Carrega_Msg_Alarme_RT_850();
			this.Inicializa_Estrutura_Lista_Equipamentos_Recalque();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			this.TabPage_geral.BackColor = Color.FromKnownColor(8);
			this.TabPage_geral.ForeColor = Color.FromKnownColor(10);
			this.TabPage1.BackColor = Color.FromKnownColor(8);
			this.TabPage1.ForeColor = Color.FromKnownColor(10);
			this.TabPage_Equipamentos.BackColor = Color.FromKnownColor(8);
			this.TabPage_Equipamentos.ForeColor = Color.FromKnownColor(10);
			this.TabPage_Senha.BackColor = Color.FromKnownColor(8);
			this.TabPage_Senha.ForeColor = Color.FromKnownColor(10);
			this.TabPage_Reservatorio.BackColor = Color.FromKnownColor(8);
			this.TabPage_Reservatorio.ForeColor = Color.FromKnownColor(10);
			this.TabPage_Recalque.BackColor = Color.FromKnownColor(8);
			this.TabPage_Recalque.ForeColor = Color.FromKnownColor(10);
			this.TabPage_controles.BackColor = Color.FromKnownColor(8);
			this.TabPage_controles.ForeColor = Color.FromKnownColor(10);
			string text = ".\\\\Fontes\\\\Ictel Extendida Italic.ttf";
			if (MyProject.Computer.FileSystem.FileExists(text))
			{
				PrivateFontCollection privateFontCollection = new PrivateFontCollection();
				privateFontCollection.AddFontFile(text);
				Font font = new Font(privateFontCollection.Families[0], 8f, 2);
				Font font2 = new Font(privateFontCollection.Families[0], 18f, 2);
				this.Label11.Font = font;
				this.TextBox_equipamento_RT850.Font = font;
				this.TextBox_versao_RT850.Font = font;
				this.TextBox_build_RT850.Font = font;
				this.TextBox_release_RT850.Font = font;
				this.ToolStripLabel1.Font = font2;
			}
			else
			{
				MessageBox.Show("Removido fonte Ictel Extendida Italic da pasta da aplicação!");
			}
			this.Atualiza_TelaRT830_200();
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.Valor = 831;
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Versao.Valor = 2;
			this.ToolStripLabel1.Text = RT_geral.MontaNomePlacaPeloFabricante(RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.Valor, RT_831_200_variaveis_X.RT_831_200_BD.firmware.Versao.Valor);
			RT_geral.RT_850_Controle.LiberaEventos_Variaveis = true;
			RT_geral.Lmte_Init_ok = true;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00281B08 File Offset: 0x0027FF08
		private void RT_850_conf_Activated(object sender, EventArgs e)
		{
			Geral.Equipamento_selecionado = 831;
			Geral.Equipamento_versao = 2;
			Geral.Equipamento_build = 0;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00281B20 File Offset: 0x0027FF20
		private void GeraDataGridView_Equip_Canal_1()
		{
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas);
					}
					num++;
				}
				while (num <= 1);
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00281B70 File Offset: 0x0027FF70
		private void InicializaEstrutura_DataGridView_Equip_Canal_1()
		{
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[0].TagColuna = "Quant";
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[1].TagColuna = "End Inicial";
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[0].NomeColuna = "Quantidade";
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[1].NomeColuna = "Endereco";
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[0].LarguraColuna = Conversions.ToInteger("60");
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[1].LarguraColuna = Conversions.ToInteger("90");
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[0].AlingColuna = 32;
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[1].AlingColuna = 32;
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[0].NumeroLinhaMenu = 0;
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[1].NumeroLinhaMenu = 0;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00281C4C File Offset: 0x0028004C
		private void Atualiza_canais_comunicacao()
		{
			this.NumericUpDown_end_mestre.Value = new decimal(RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre.Valor);
			this.NumericUpDown_end_estacao.Value = new decimal(RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor);
			this.NumericUpDown_temp_ptt_1_RT850.Value = new decimal(RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT.Valor);
			this.ComboBox_baudrate_RT850.SelectedIndex = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.Indice;
			this.nud_numero_equipamentos_reservatorios.Value = new decimal(RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor);
			this.nud_numero_equipamentos_recalque.Value = new decimal(RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00281D2C File Offset: 0x0028012C
		private void Atualiza_Senha()
		{
			this.NumericUpDown_senha.Value = new decimal(RT_831_200_variaveis_X.RT_831_200_BD.senha.senha.Valor);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00281D54 File Offset: 0x00280154
		private void Atualiza_Reservatorios()
		{
			int num = 20;
			DataGridView dataGridView_Reservatorios = this.DataGridView_Reservatorios;
			int i = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor;
			int num2 = 20;
			int columnHeadersHeight = dataGridView_Reservatorios.ColumnHeadersHeight;
			int num3 = 0;
			int num4 = 0;
			checked
			{
				int num5 = dataGridView_Reservatorios.ColumnCount - 1;
				for (int j = num4; j <= num5; j++)
				{
					num3 += dataGridView_Reservatorios.Columns[j].Width;
				}
				if (i == 0)
				{
					dataGridView_Reservatorios.Height = columnHeadersHeight;
					dataGridView_Reservatorios.Width = num3;
					dataGridView_Reservatorios.ScrollBars = 0;
				}
				else if (i >= 1 & i <= num2)
				{
					int height = dataGridView_Reservatorios.Rows[0].Height;
					dataGridView_Reservatorios.Height = columnHeadersHeight + i * height;
					dataGridView_Reservatorios.Width = num3;
					dataGridView_Reservatorios.ScrollBars = 0;
				}
				else
				{
					int height = dataGridView_Reservatorios.Rows[0].Height;
					dataGridView_Reservatorios.Height = columnHeadersHeight + num2 * height;
					dataGridView_Reservatorios.Width = num3 + num;
					dataGridView_Reservatorios.ScrollBars = 2;
				}
				int num6 = 0;
				int num7 = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor - 1;
				for (i = num6; i <= num7; i++)
				{
					string value = string.Format("{0}", 1 + i);
					this.DataGridView_Reservatorios.Rows[i].Cells[0].Value = value;
					this.DataGridView_Reservatorios.Rows[i].Cells[1].Value = RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[i].Nome.Valor.ToString();
				}
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00281EF8 File Offset: 0x002802F8
		private void Atualiza_Recalques()
		{
			int num = 20;
			DataGridView dataGridView_Recalques = this.DataGridView_Recalques;
			int i = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor;
			int num2 = 20;
			int columnHeadersHeight = dataGridView_Recalques.ColumnHeadersHeight;
			int num3 = 0;
			int num4 = 0;
			checked
			{
				int num5 = dataGridView_Recalques.ColumnCount - 1;
				for (int j = num4; j <= num5; j++)
				{
					num3 += dataGridView_Recalques.Columns[j].Width;
				}
				if (i == 0)
				{
					dataGridView_Recalques.Height = columnHeadersHeight + num;
					dataGridView_Recalques.Width = 1212;
					dataGridView_Recalques.ScrollBars = 1;
				}
				else if (i >= 1 & i <= num2)
				{
					int height = dataGridView_Recalques.Rows[0].Height;
					dataGridView_Recalques.Height = columnHeadersHeight + i * height + num;
					dataGridView_Recalques.Width = 1212;
					dataGridView_Recalques.ScrollBars = 1;
				}
				else
				{
					int height = dataGridView_Recalques.Rows[0].Height;
					dataGridView_Recalques.Height = columnHeadersHeight + num2 * height + num;
					dataGridView_Recalques.Width = 1212;
					dataGridView_Recalques.ScrollBars = 3;
				}
				int num6 = 0;
				int num7 = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor - 1;
				for (i = num6; i <= num7; i++)
				{
					string value = string.Format("{0}", 1 + i);
					this.DataGridView_Recalques.Rows[i].Cells[0].Value = value;
					this.DataGridView_Recalques.Rows[i].Cells[1].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Nome.Valor.ToString();
					DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.DataGridView_Recalques.Rows[i].Cells[2];
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Modelo.AtualizaIndicePeloValor();
					dataGridViewComboBoxCell.Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Modelo.itens[RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Modelo.Indice];
					dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.DataGridView_Recalques.Rows[i].Cells[3];
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Habilita.AtualizaIndicePeloValor();
					dataGridViewComboBoxCell.Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Habilita.itens[RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Habilita.Indice];
					this.DataGridView_Recalques.Rows[i].Cells[4].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala1.Valor;
					this.DataGridView_Recalques.Rows[i].Cells[5].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala2.Valor;
					this.DataGridView_Recalques.Rows[i].Cells[6].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala3.Valor;
					this.DataGridView_Recalques.Rows[i].Cells[7].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala4.Valor;
					this.DataGridView_Recalques.Rows[i].Cells[8].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala5.Valor;
					this.DataGridView_Recalques.Rows[i].Cells[9].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala6.Valor;
					this.DataGridView_Recalques.Rows[i].Cells[10].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala7.Valor;
					this.DataGridView_Recalques.Rows[i].Cells[11].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala8.Valor;
					this.DataGridView_Recalques.Rows[i].Cells[12].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala9.Valor;
					this.DataGridView_Recalques.Rows[i].Cells[13].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala10.Valor;
					this.DataGridView_Recalques.Rows[i].Cells[14].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala11.Valor;
					this.DataGridView_Recalques.Rows[i].Cells[15].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala12.Valor;
					this.DataGridView_Recalques.Rows[i].Cells[16].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala13.Valor;
					this.DataGridView_Recalques.Rows[i].Cells[17].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala14.Valor;
					this.DataGridView_Recalques.Rows[i].Cells[18].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala15.Valor;
					this.DataGridView_Recalques.Rows[i].Cells[19].Value = RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala16.Valor;
				}
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x002825E0 File Offset: 0x002809E0
		private void Inicializa_Estrutura_Lista_Equipamentos_Recalque()
		{
			Linha_RT.CreateComboBoxColumn3(RT_831_200_variaveis_X.RT_831_200_BD.recalque[0].Modelo, (DataGridViewComboBoxColumn)this.DataGridView_Recalques.Columns[2]);
			Linha_RT.CreateComboBoxColumn3(RT_831_200_variaveis_X.RT_831_200_BD.recalque[0].Habilita, (DataGridViewComboBoxColumn)this.DataGridView_Recalques.Columns[3]);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00282650 File Offset: 0x00280A50
		private void InicializaEstrutura_DataGridView_variaveis_RT_850()
		{
			RT_geral.RT_850_DataGridView_variaveis[4].LinhasMenu = new string[5];
			RT_geral.RT_850_DataGridView_variaveis[4].LinhasValor = new int[5];
			RT_geral.RT_850_DataGridView_variaveis[12].LinhasMenu = new string[6];
			RT_geral.RT_850_DataGridView_variaveis[12].LinhasValor = new int[6];
			RT_geral.RT_850_DataGridView_variaveis[6].LinhasMenu = new string[3];
			RT_geral.RT_850_DataGridView_variaveis[6].LinhasValor = new int[3];
			RT_geral.RT_850_DataGridView_variaveis[9].LinhasMenu = new string[3];
			RT_geral.RT_850_DataGridView_variaveis[9].LinhasValor = new int[3];
			RT_geral.RT_850_DataGridView_variaveis[7].LinhasMenu = new string[7];
			RT_geral.RT_850_DataGridView_variaveis[7].LinhasValor = new int[7];
			RT_geral.RT_850_DataGridView_variaveis[10].LinhasMenu = new string[7];
			RT_geral.RT_850_DataGridView_variaveis[10].LinhasValor = new int[7];
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
				RT_geral.RT_850_DataGridView_variaveis[4].TagColuna = "Ponto Decimal";
				RT_geral.RT_850_DataGridView_variaveis[5].TagColuna = "Alarme 1";
				RT_geral.RT_850_DataGridView_variaveis[6].TagColuna = "Tipo Alarme 1";
				RT_geral.RT_850_DataGridView_variaveis[7].TagColuna = "Msg Alarme 1";
				RT_geral.RT_850_DataGridView_variaveis[8].TagColuna = "Alarme 2";
				RT_geral.RT_850_DataGridView_variaveis[9].TagColuna = "Tipo Alarme 2";
				RT_geral.RT_850_DataGridView_variaveis[10].TagColuna = "Msg Alarme 2";
				RT_geral.RT_850_DataGridView_variaveis[11].TagColuna = "Número Tela";
				RT_geral.RT_850_DataGridView_variaveis[12].TagColuna = "Posição Display";
				RT_geral.RT_850_DataGridView_variaveis[0].NomeColuna = "Nome";
				RT_geral.RT_850_DataGridView_variaveis[1].NomeColuna = "Escala_ini";
				RT_geral.RT_850_DataGridView_variaveis[2].NomeColuna = "Escala_fim";
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
				RT_geral.RT_850_DataGridView_variaveis[4].NumeroLinhaMenu = 4;
				RT_geral.RT_850_DataGridView_variaveis[5].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_variaveis[6].NumeroLinhaMenu = 2;
				RT_geral.RT_850_DataGridView_variaveis[7].NumeroLinhaMenu = 6;
				RT_geral.RT_850_DataGridView_variaveis[8].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_variaveis[9].NumeroLinhaMenu = 2;
				RT_geral.RT_850_DataGridView_variaveis[10].NumeroLinhaMenu = 6;
				RT_geral.RT_850_DataGridView_variaveis[11].NumeroLinhaMenu = 0;
				RT_geral.RT_850_DataGridView_variaveis[12].NumeroLinhaMenu = 5;
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00282EEC File Offset: 0x002812EC
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
			RT_geral.RT_850_DataGridView_ctrl_4[22].LinhasMenu = new string[30];
			RT_geral.RT_850_DataGridView_ctrl_4[22].LinhasValor = new int[30];
			RT_geral.RT_850_DataGridView_ctrl_4[24].LinhasMenu = new string[30];
			RT_geral.RT_850_DataGridView_ctrl_4[24].LinhasValor = new int[30];
			RT_geral.RT_850_DataGridView_ctrl_4[26].LinhasMenu = new string[30];
			RT_geral.RT_850_DataGridView_ctrl_4[26].LinhasValor = new int[30];
			RT_geral.RT_850_DataGridView_ctrl_4[28].LinhasMenu = new string[30];
			RT_geral.RT_850_DataGridView_ctrl_4[28].LinhasValor = new int[30];
			RT_geral.RT_850_DataGridView_ctrl_4[30].LinhasMenu = new string[30];
			RT_geral.RT_850_DataGridView_ctrl_4[30].LinhasValor = new int[30];
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
			checked
			{
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
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[0] = "Periférico Desabilitado";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[0] = 0;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[1] = "Medição Vazão - 1 canal";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[1] = 1;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[2] = "Medição Vazão - 2 canais";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[2] = 2;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[3] = "Medição Vazão - 3 canais";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[3] = 3;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[4] = "Medição Vazão - 4 canais";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[4] = 4;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[5] = "Medição Vazão - 5 canais";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[5] = 5;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[6] = "Medição Vazão - 6 canais";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[6] = 6;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[7] = "Medição Vazão - 7 canais";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[7] = 7;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[8] = "Medição Vazão - 8 canais";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[8] = 8;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[9] = "Reserva";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[9] = 9;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[10] = "Equipamento de Leitura Vazão";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[10] = 10;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[11] = "Multimedidor IMS mod: Smart Trans";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[11] = 11;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[12] = "Multimedidor KRON mod: Mult K-05";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[12] = 12;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[13] = "Inversor Danfoss VLT";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[13] = 13;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[14] = "Multimedidor SIEMENS PAC 3200";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[14] = 14;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[15] = "Inversor WEG CFW09";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[15] = 15;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[16] = "Softstarter WEG SSW07";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[16] = 16;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[17] = "Softstarter Danfoss MDC3000";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[17] = 17;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[18] = "Thermo Scientific AquaChlor";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[18] = 18;
					RT_geral.RT_850_DataGridView_ctrl_4[23 + i].LinhasMenu[0] = "----";
					RT_geral.RT_850_DataGridView_ctrl_4[23 + i].LinhasValor[0] = 0;
					int num = 1;
					do
					{
						RT_geral.RT_850_DataGridView_ctrl_4[23 + i].LinhasMenu[num] = Conversion.Str(num);
						RT_geral.RT_850_DataGridView_ctrl_4[23 + i].LinhasValor[num] = num;
						num++;
					}
					while (num <= 65);
					i += 2;
				}
				while (i <= 8);
				if (RT_geral.RT_850_BD.Variaveis_Numero.Valor > 0)
				{
					int num2 = 1;
					int valor = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
					for (i = num2; i <= valor; i++)
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
				RT_geral.RT_850_DataGridView_ctrl_4[22].LarguraColuna = Conversions.ToInteger("170");
				RT_geral.RT_850_DataGridView_ctrl_4[23].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_4[24].LarguraColuna = Conversions.ToInteger("170");
				RT_geral.RT_850_DataGridView_ctrl_4[25].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_4[26].LarguraColuna = Conversions.ToInteger("170");
				RT_geral.RT_850_DataGridView_ctrl_4[27].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_4[28].LarguraColuna = Conversions.ToInteger("170");
				RT_geral.RT_850_DataGridView_ctrl_4[29].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_4[30].LarguraColuna = Conversions.ToInteger("170");
				RT_geral.RT_850_DataGridView_ctrl_4[31].LarguraColuna = Conversions.ToInteger("85");
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
				RT_geral.RT_850_DataGridView_ctrl_4[5].NumeroLinhaMenu = 12;
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
				RT_geral.RT_850_DataGridView_ctrl_4[22].NumeroLinhaMenu = 29;
				RT_geral.RT_850_DataGridView_ctrl_4[23].NumeroLinhaMenu = 66;
				RT_geral.RT_850_DataGridView_ctrl_4[24].NumeroLinhaMenu = 29;
				RT_geral.RT_850_DataGridView_ctrl_4[25].NumeroLinhaMenu = 66;
				RT_geral.RT_850_DataGridView_ctrl_4[26].NumeroLinhaMenu = 29;
				RT_geral.RT_850_DataGridView_ctrl_4[27].NumeroLinhaMenu = 66;
				RT_geral.RT_850_DataGridView_ctrl_4[28].NumeroLinhaMenu = 29;
				RT_geral.RT_850_DataGridView_ctrl_4[29].NumeroLinhaMenu = 66;
				RT_geral.RT_850_DataGridView_ctrl_4[30].NumeroLinhaMenu = 29;
				RT_geral.RT_850_DataGridView_ctrl_4[31].NumeroLinhaMenu = 66;
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x002850EC File Offset: 0x002834EC
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
			RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasMenu = new string[5];
			RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasValor = new int[5];
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
			RT_geral.RT_850_DataGridView_ctrl_8[42].LinhasMenu = new string[30];
			RT_geral.RT_850_DataGridView_ctrl_8[42].LinhasValor = new int[30];
			RT_geral.RT_850_DataGridView_ctrl_8[44].LinhasMenu = new string[30];
			RT_geral.RT_850_DataGridView_ctrl_8[44].LinhasValor = new int[30];
			RT_geral.RT_850_DataGridView_ctrl_8[46].LinhasMenu = new string[30];
			RT_geral.RT_850_DataGridView_ctrl_8[46].LinhasValor = new int[30];
			RT_geral.RT_850_DataGridView_ctrl_8[48].LinhasMenu = new string[30];
			RT_geral.RT_850_DataGridView_ctrl_8[48].LinhasValor = new int[30];
			RT_geral.RT_850_DataGridView_ctrl_8[50].LinhasMenu = new string[30];
			RT_geral.RT_850_DataGridView_ctrl_8[50].LinhasValor = new int[30];
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
			RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasMenu[0] = "Não Definido";
			RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasMenu[1] = "RT820 300";
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
			checked
			{
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
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[0] = "Periférico Desabilitado";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[0] = 0;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[1] = "Medição Vazão - 1 canal";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[1] = 1;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[2] = "Medição Vazão - 2 canais";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[2] = 2;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[3] = "Medição Vazão - 3 canais";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[3] = 3;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[4] = "Medição Vazão - 4 canais";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[4] = 4;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[5] = "Medição Vazão - 5 canais";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[5] = 5;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[6] = "Medição Vazão - 6 canais";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[6] = 6;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[7] = "Medição Vazão - 7 canais";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[7] = 7;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[8] = "Medição Vazão - 8 canais";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[8] = 8;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[9] = "Equipamento de Leitura Vazão";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[9] = 9;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[10] = "Ictel - GC420";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[10] = 10;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[11] = "Multimedidor IMS mod: Smart Trans";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[11] = 11;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[12] = "Multimedidor KRON mod: Mult K-05";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[12] = 12;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[13] = "Inversor Danfoss VLT";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[13] = 13;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[14] = "Multimedidor SIEMENS PAC 3200";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[14] = 14;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[15] = "Inversor WEG CFW09";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[15] = 15;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[16] = "Softstarter WEG SSW07";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[16] = 16;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[17] = "Softstarter Danfoss MDC3000";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[17] = 17;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[18] = "Thermo Scientific AquaChlor";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[18] = 18;
					RT_geral.RT_850_DataGridView_ctrl_8[43 + i].LinhasMenu[0] = "----";
					RT_geral.RT_850_DataGridView_ctrl_8[43 + i].LinhasValor[0] = 0;
					int num = 1;
					do
					{
						RT_geral.RT_850_DataGridView_ctrl_8[43 + i].LinhasMenu[num] = Conversion.Str(num);
						RT_geral.RT_850_DataGridView_ctrl_8[43 + i].LinhasValor[num] = num;
						num++;
					}
					while (num <= 65);
					i += 2;
				}
				while (i <= 8);
				if (RT_geral.RT_850_BD.Variaveis_Numero.Valor > 0)
				{
					int num2 = 1;
					int valor = RT_geral.RT_850_BD.Variaveis_Numero.Valor;
					for (i = num2; i <= valor; i++)
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
				RT_geral.RT_850_DataGridView_ctrl_8[42].LarguraColuna = Conversions.ToInteger("170");
				RT_geral.RT_850_DataGridView_ctrl_8[43].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[44].LarguraColuna = Conversions.ToInteger("170");
				RT_geral.RT_850_DataGridView_ctrl_8[45].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[46].LarguraColuna = Conversions.ToInteger("170");
				RT_geral.RT_850_DataGridView_ctrl_8[47].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[48].LarguraColuna = Conversions.ToInteger("170");
				RT_geral.RT_850_DataGridView_ctrl_8[49].LarguraColuna = Conversions.ToInteger("85");
				RT_geral.RT_850_DataGridView_ctrl_8[50].LarguraColuna = Conversions.ToInteger("170");
				RT_geral.RT_850_DataGridView_ctrl_8[51].LarguraColuna = Conversions.ToInteger("85");
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
				RT_geral.RT_850_DataGridView_ctrl_8[5].NumeroLinhaMenu = 2;
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
				RT_geral.RT_850_DataGridView_ctrl_8[42].NumeroLinhaMenu = 29;
				RT_geral.RT_850_DataGridView_ctrl_8[43].NumeroLinhaMenu = 66;
				RT_geral.RT_850_DataGridView_ctrl_8[44].NumeroLinhaMenu = 29;
				RT_geral.RT_850_DataGridView_ctrl_8[45].NumeroLinhaMenu = 66;
				RT_geral.RT_850_DataGridView_ctrl_8[46].NumeroLinhaMenu = 29;
				RT_geral.RT_850_DataGridView_ctrl_8[47].NumeroLinhaMenu = 66;
				RT_geral.RT_850_DataGridView_ctrl_8[48].NumeroLinhaMenu = 29;
				RT_geral.RT_850_DataGridView_ctrl_8[49].NumeroLinhaMenu = 66;
				RT_geral.RT_850_DataGridView_ctrl_8[50].NumeroLinhaMenu = 29;
				RT_geral.RT_850_DataGridView_ctrl_8[51].NumeroLinhaMenu = 66;
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00288518 File Offset: 0x00286918
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

		// Token: 0x060003BD RID: 957 RVA: 0x002887D8 File Offset: 0x00286BD8
		private void Atualiza_DataGridView_Equipamentos_Vista_RT_850()
		{
		}

		// Token: 0x060003BE RID: 958 RVA: 0x002887DC File Offset: 0x00286BDC
		public void Carrega_Msg_Alarme_RT_850()
		{
			RT_geral.RT_850_MSG_ALARME[0] = "Nível Baixo";
			RT_geral.RT_850_MSG_ALARME[1] = "Nível Alto";
			RT_geral.RT_850_MSG_ALARME[2] = "Pressão Baixo";
			RT_geral.RT_850_MSG_ALARME[3] = "Pressão Alta";
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00288810 File Offset: 0x00286C10
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

		// Token: 0x060003C0 RID: 960 RVA: 0x00288C94 File Offset: 0x00287094
		public bool Verifica_linha_variaveis_RT_850(int linha)
		{
			bool result = false;
			if (linha == 0)
			{
				result = true;
			}
			else if (Operators.CompareString(Strings.Trim(RT_geral.Variaveis_RT_850[checked(linha - 1)].Nome.Valor), "", false) == 0)
			{
				Interaction.MsgBox("Variável: " + Conversion.Str(linha) + "\r\nParâmetro: Nome -> não válido", 32, "Atenção - Erro de Configuração");
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00288D04 File Offset: 0x00287104
		public void Atualiza_TelaRT830_200()
		{
			int num;
			int num2;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				if (Operators.CompareString(RT_geral.RT_850_BD.Nome_Arquivo, "", false) == 0)
				{
					this.Text = "Configuração";
				}
				else
				{
					this.Text = "Configuração -> Arquivo : " + RT_geral.RT_850_BD.Nome_Arquivo;
				}
				this.TextBox_versao_RT850.Text = RT_831_200_variaveis_X.RT_831_200_BD.firmware.Versao.Valor.ToString();
				this.TextBox_build_RT850.Text = RT_831_200_variaveis_X.RT_831_200_BD.firmware.Build.Valor.ToString();
				this.TextBox_release_RT850.Text = RT_831_200_variaveis_X.RT_831_200_BD.firmware.Release.Valor.ToString();
				this.TextBox_equipamento_RT850.Text = RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.Valor.ToString();
				this.Atualiza_canais_comunicacao();
				this.Atualiza_Senha();
				this.Atualiza_Reservatorios();
				this.Atualiza_Recalques();
				goto IL_13E;
				IL_F0:
				MessageBox.Show("ERRO: Atualiza_TelaRT850()");
				goto IL_13E;
				IL_FD:
				num2 = -1;
								IL_111:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num2 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_FD;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			IL_13E:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00288E74 File Offset: 0x00287274
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

		// Token: 0x060003C3 RID: 963 RVA: 0x00288ED8 File Offset: 0x002872D8
		private void CarregaComboBoxBaudRate(ref ComboBox dado)
		{
			dado.Items.Clear();
			dado.Items.Add("1200 bauds");
			dado.Items.Add("9600 bauds");
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00288F0C File Offset: 0x0028730C
		private void CarregaComboBoxVista_Selecao(ref ComboBox dado)
		{
			dado.Items.Clear();
			dado.Items.Add("Vista não definido");
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00288F2C File Offset: 0x0028732C
		private void CarregaComboBoxVista_Selecao_Habilitados(ref ComboBox dado, int num_vista, int vista_selecionado)
		{
			dado.Items.Clear();
			checked
			{
				for (int i = 0; i <= num_vista; i++)
				{
					dado.Items.Add(RT_geral.RT_850_Vista[i].Nome.Valor);
				}
				if (num_vista > 0)
				{
					dado.SelectedIndex = vista_selecionado;
				}
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00288F84 File Offset: 0x00287384
		private void CarregaComboBoxVista_Canal(ref ComboBox dado)
		{
			dado.Items.Clear();
			dado.Items.Add("Canal 1");
			dado.Items.Add("Canal 2");
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00288FB8 File Offset: 0x002873B8
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

		// Token: 0x060003C8 RID: 968 RVA: 0x00288FF4 File Offset: 0x002873F4
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

		// Token: 0x060003C9 RID: 969 RVA: 0x00289044 File Offset: 0x00287444
		private void CarregaComboBoxVista_Modelo(ref ComboBox dado)
		{
			RT_geral.RT_850_Modelo.nome = "Modelo do Vista Emulado";
			RT_geral.RT_850_Modelo.Indice_padrao = 0;
			RT_geral.RT_850_Modelo.Numero_itens = 4;
			RT_geral.RT_850_Modelo.valores[0] = 0;
			RT_geral.RT_850_Modelo.valores[1] = 1;
			RT_geral.RT_850_Modelo.valores[2] = 2;
			RT_geral.RT_850_Modelo.valores[3] = 7;
			RT_geral.RT_850_Modelo.itens[0] = "Não definido";
			RT_geral.RT_850_Modelo.itens[1] = "CT 831-010";
			RT_geral.RT_850_Modelo.itens[2] = "CT 831-200";
			RT_geral.RT_850_Modelo.itens[3] = "VA 241-70";
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

		// Token: 0x060003CA RID: 970 RVA: 0x0028912C File Offset: 0x0028752C
		private void RT_850_conf_FormClosed(object sender, FormClosedEventArgs e)
		{
			int num;
			int num2;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				RT_geral.RT_850_BD.Nome_Arquivo = "";
				ComboBox comboBox_baudrate_RT = this.ComboBox_baudrate_RT850;
				this.CarregaComboBoxBaudRate(ref comboBox_baudrate_RT);
				this.ComboBox_baudrate_RT850 = comboBox_baudrate_RT;
				RT_831_200_inicializa_variavies_X.RT_831_200_inicializa_variaveis();
				RT_831_200_valores_default_X.RT_831_200_valores_default();
				RT_geral.Telas_RT_831_200.Configuracao = false;
				IL_43:
				goto IL_86;
				IL_45:
				num2 = -1;
								IL_59:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num2 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_45;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			IL_86:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x002891D8 File Offset: 0x002875D8
		private void CarregaComboBoxVariaveis(ref ComboBox dado)
		{
			dado.Items.Clear();
			dado.Items.Add("1200 bauds");
			dado.Items.Add("9600 bauds");
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0028920C File Offset: 0x0028760C
		private void DataGridView_equip_1_RT850_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00289210 File Offset: 0x00287610
		private void DataGridView_equip_1_RT850_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0028921C File Offset: 0x0028761C
		private void DataGridView_equip_1_RT850_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00289220 File Offset: 0x00287620
		private void TextBox_nome_vista_Validating(object sender, CancelEventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Nome.Valor = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0028927C File Offset: 0x0028767C
		private void ComboBox_porta_vista_RT_850_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Canal.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x002892D8 File Offset: 0x002876D8
		private void ComboBox_prioridade_vista_RT_850_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Prioridade.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00289334 File Offset: 0x00287734
		private void ComboBox_timeout_vista_RT_850_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				RT_geral.RT_850_Vista[checked(RT_geral.RT_850_BD.Vista_selecionado.Indice - 1)].Timeout.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00289394 File Offset: 0x00287794
		private void ComboBox_modelo_vista_RT_850_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				int num = RT_geral.LocalizaIndiceVetor_str_indice(ref RT_geral.RT_850_Modelo, Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
				RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Modelo.Indice = RT_geral.RT_850_Modelo.valores[num];
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00289408 File Offset: 0x00287808
		private void NumericUpDown_num_var_vista_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0028940C File Offset: 0x0028780C
		private void NumericUpDown_num_equip_vista_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00289410 File Offset: 0x00287810
		private void ComboBox_Seleciona_Vista_RT_850_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00289414 File Offset: 0x00287814
		private void DataGridView_vista_variaveis_RT_850_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00289418 File Offset: 0x00287818
		private void DataGridView_vista_variaveis_RT_850_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0028941C File Offset: 0x0028781C
		private void DataGridView_vista_variaveis_RT_850_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00289420 File Offset: 0x00287820
		private void DataGridView_vista_equipamentos_RT_850_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00289424 File Offset: 0x00287824
		private void DataGridView_vista_equipamentos_RT_850_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00289428 File Offset: 0x00287828
		private void DataGridView_vista_equipamentos_RT_850_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0028942C File Offset: 0x0028782C
		private void TabControl_850_SelectedIndexChanged(object sender, EventArgs e)
		{
			string name = ((TabControl)sender).SelectedTab.Name;
			string text = name;
			if (Operators.CompareString(text, "TabPage_controles", false) == 0 || Operators.CompareString(text, "TabPage_Equipamentos", false) == 0)
			{
				this.Atualiza_canais_comunicacao();
			}
			else if (Operators.CompareString(text, "TabPage_Senha", false) == 0)
			{
				this.Atualiza_Senha();
			}
			else if (Operators.CompareString(text, "TabPage_Reservatorio", false) == 0)
			{
				this.Atualiza_Reservatorios();
			}
			else if (Operators.CompareString(text, "TabPage_Recalque", false) == 0)
			{
				this.Atualiza_Recalques();
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x002894B8 File Offset: 0x002878B8
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

		// Token: 0x060003DF RID: 991 RVA: 0x0028955C File Offset: 0x0028795C
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

		// Token: 0x060003E0 RID: 992 RVA: 0x00289FD8 File Offset: 0x002883D8
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

		// Token: 0x060003E1 RID: 993 RVA: 0x0028AB44 File Offset: 0x00288F44
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

		// Token: 0x060003E2 RID: 994 RVA: 0x0028AC30 File Offset: 0x00289030
		private void Timer_limpa_MSG_RT850_Tick(object sender, EventArgs e)
		{
			this.Timer_limpa_MSG_RT850.Enabled = false;
			this.AtualizaMsgTela_RT850("", 0);
			this.ToolStripProgressBar_RT850.Value = 0;
			this.ControleAtivacaoTeclas(3);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0028AC60 File Offset: 0x00289060
		private void ToolStripButton_RT850_novo_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			RT_geral.Lmte_Init_ok = false;
			RT_geral.RT_850_BD.Nome_Arquivo = "";
			RT_831_200_inicializa_variavies_X.RT_831_200_inicializa_variaveis();
			RT_831_200_valores_default_X.RT_831_200_valores_default();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			this.Atualiza_TelaRT830_200();
			RT_geral.Lmte_Init_ok = true;
			this.AtualizaMsgTela_RT850("Valores Default carregados", 0);
			this.Timer_limpa_MSG_RT850.Enabled = true;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0028ACC8 File Offset: 0x002890C8
		private void ToolStripButton_RT850_Abrir_Click(object sender, EventArgs e)
		{
			int num;
			int num2;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				this.AtivaEfeitoOnChangeValue();
				int[] array = new int[10001];
				this.ControleAtivacaoTeclas(1);
				this.OpenFileDialog_RT850.Filter = "Arquivo de configuração de equipamento|*.Cfg831";
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
						if (!Linha_RT.VerificaSeEquipamentoEValido(1, RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.Valor, RT_831_200_variaveis_X.RT_831_200_BD.firmware.Versao.Valor, RT_831_200_variaveis_X.RT_831_200_BD.firmware.Build.Valor, RT_831_200_variaveis_X.RT_831_200_BD.firmware.Release.Valor, RT_geral.arquivo_extensao).Status)
						{
							RT_geral.Lmte_Init_ok = false;
							RT_geral.RT_850_BD.Nome_Arquivo = "";
							RT_831_200_inicializa_variavies_X.RT_831_200_inicializa_variaveis();
							RT_831_200_valores_default_X.RT_831_200_valores_default();
							Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
							this.Atualiza_TelaRT830_200();
							RT_geral.Lmte_Init_ok = true;
							this.AtualizaMsgTela_RT850("Valores Default carregados", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
						}
						else
						{
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							RT_831_200_Load_X.RT_831_200_Carrega_Geral_Descricao(this.OpenFileDialog_RT850.FileName, this);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							RT_831_200_Load_X.RT_831_200_Carrega_Senha(this.OpenFileDialog_RT850.FileName);
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							RT_831_200_Load_X.RT_831_200_Carrega_Canal_Radio(this.OpenFileDialog_RT850.FileName);
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							RT_831_200_Load_X.RT_831_200_Carrega_Equipamentos(this.OpenFileDialog_RT850.FileName);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							RT_831_200_Load_X.RT_831_200_Carrega_Variaveis(this.OpenFileDialog_RT850.FileName, this);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							RT_831_200_Load_X.RT_831_200_Carrega_RemotasControle(this.OpenFileDialog_RT850.FileName, this);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							RT_831_200_Load_X.RT_831_200_Carrega_Instalacao(this.OpenFileDialog_RT850.FileName, this);
							Application.DoEvents();
							RT_geral.RT_850_BD.Nome_Arquivo = fileName;
							this.Atualiza_TelaRT830_200();
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
				goto IL_38A;
				IL_325:
				Interaction.MsgBox("Não foi possível carregar os dados", 32, "Atenção - Erro I/0");
				this.Timer_limpa_MSG_RT850.Enabled = true;
				goto IL_38A;
				IL_345:
				num2 = -1;
								IL_35B:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num2 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_345;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			IL_38A:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0028B084 File Offset: 0x00289484
		private void Carrega_Geral_Informacao(string filename)
		{
			IniFile iniFile = new IniFile(filename);
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "EQUIPAMENTO", -1);
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Versao.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "VERSAO", -1);
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Build.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "BUILD", -1);
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Release.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "RELEASE", -1);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0028B12C File Offset: 0x0028952C
		private void ToolStripButton_RT850_Salvar_Click(object sender, EventArgs e)
		{
			int num;
			int num2;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				this.AtivaEfeitoOnChangeValue();
				int[] array = new int[10001];
				this.ControleAtivacaoTeclas(2);
				this.SaveFileDialog_RT850.Filter = "Arquivo de configuração de equipamento|*.Cfg831";
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
						this.InicializaBarraProgressoTela_RT850(7);
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						RT_831_200_Save_X.RT_831_200_Salva_Geral_Informacao(iniFileWriteFast);
						RT_831_200_Save_X.RT_831_200_Salva_Geral_Descricao(iniFileWriteFast, this);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						RT_831_200_Save_X.RT_831_200_Salva_Senha(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						RT_831_200_Save_X.RT_831_200_Salva_Canal_Radio(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						RT_831_200_Save_X.RT_831_200_Salva_Equipamentos(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						RT_831_200_Save_X.RT_831_200_Salva_Variaveis(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						RT_831_200_Save_X.RT_831_200_Salva_RemotasControle(iniFileWriteFast);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						RT_831_200_Save_X.RT_831_200_Salva_Instalacao(iniFileWriteFast, this);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.CloseIniFileWriteFast();
						RT_geral.RT_850_BD.Nome_Arquivo = fileName;
						this.Text = "Configuração - CT 830  -> Arquivo : " + RT_geral.RT_850_BD.Nome_Arquivo;
						this.ToolStripProgressBar_RT850.Value = 0;
						this.AtualizaMsgTela_RT850("Arquivo gerado com sucesso!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
					}
				}
				else
				{
					this.AtualizaMsgTela_RT850("Operação Cancelada", 0);
					this.Timer_limpa_MSG_RT850.Enabled = true;
				}
				goto IL_347;
				IL_2E2:
				Interaction.MsgBox("Não foi possível gravar os dados", 32, "Atenção - Erro I/0");
				this.Timer_limpa_MSG_RT850.Enabled = true;
				goto IL_347;
				IL_302:
				num2 = -1;
								IL_318:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num2 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_302;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			IL_347:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0028B4A8 File Offset: 0x002898A8
		private void ToolStripButton_RT850_Download_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.ControleAtivacaoTeclas(4);
				this.EncerraEdicaoDeCampos_RT850();
				this.Leitura_RT831_200_conf();
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", 16, "Atenção");
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0028B4E0 File Offset: 0x002898E0
		private void ToolStripButton_RT850_Upload_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.ControleAtivacaoTeclas(4);
				this.EncerraEdicaoDeCampos_RT850();
				this.Escrita_RT831_conf();
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", 16, "Atenção");
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0028B518 File Offset: 0x00289918
		public void Leitura_RT831_200_conf()
		{
			this.InicializaBarraProgressoTela_RT850(5);
			this.AtualizaMsgTela_RT850("Identificação de equipamento - Etapa 1", 2);
			this.ToolStripProgressBar_RT850.PerformStep();
			if (!Mod_MD.Leitura_pagina(0, 255, 4).Status)
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
			Linha_RT.Atualiza_dados_RT831_200(0, 0);
			this.AtualizaMsgTela_RT850("Leitura de configuração - Geral - Etapa 2", 2);
			this.ToolStripProgressBar_RT850.PerformStep();
			if (!Mod_MD.Leitura_pagina(256, 255, 6).Status)
			{
				this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT831_200(256, 0);
			this.AtualizaMsgTela_RT850("Leitura de configuração - Reservatórios - Etapa 3", 2);
			this.ToolStripProgressBar_RT850.PerformStep();
			if (!Mod_MD.Leitura_pagina(512, RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor, 40).Status)
			{
				this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT831_200(512, 0);
			int num = 0;
			checked
			{
				for (;;)
				{
					string texto = string.Format("Leitura de configuração - Recalque {0} - 1 - Etapa 4", num + 1);
					this.AtualizaMsgTela_RT850(texto, 2);
					Application.DoEvents();
					int numero_pagina = 768 + num * 256;
					if (!Mod_MD.Leitura_pagina(numero_pagina, RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor, 76).Status)
					{
						break;
					}
					Linha_RT.Atualiza_dados_RT831_200(768 + num * 256, 0);
					texto = string.Format("Leitura de configuração - Recalque {0} - 2 - Etapa 4", num + 1);
					this.AtualizaMsgTela_RT850(texto, 2);
					Application.DoEvents();
					numero_pagina = 768 + num * 256 + 76;
					if (!Mod_MD.Leitura_pagina(numero_pagina, RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor, 57).Status)
					{
						goto Block_6;
					}
					Linha_RT.Atualiza_dados_RT831_200(768 + num * 256, 1);
					num++;
					if (num > 3)
					{
						goto Block_7;
					}
				}
				this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_6:
				this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_7:
				this.ToolStripProgressBar_RT850.PerformStep();
				this.AtualizaMsgTela_RT850("Leitura de configuração - Senha - Etapa 5", 2);
				this.ToolStripProgressBar_RT850.PerformStep();
				if (!Mod_MD.Leitura_pagina(2304, RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor, 1).Status)
				{
					this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT831_200(2304, 0);
				this.Atualiza_TelaRT830_200();
				this.AtualizaMsgTela_RT850("Configuração lida com sucesso", 0);
				this.ToolStripProgressBar_RT850.PerformStep();
				this.Timer_limpa_MSG_RT850.Enabled = true;
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0028B818 File Offset: 0x00289C18
		public void InicializaBarraProgressoTela_RT850(int num_passos)
		{
			this.ToolStripProgressBar_RT850.Minimum = 0;
			this.ToolStripProgressBar_RT850.Maximum = 1000;
			this.ToolStripProgressBar_RT850.Step = checked((int)Math.Round(unchecked(1000.0 / (double)num_passos + 1.0)));
			this.ToolStripProgressBar_RT850.Value = 0;
			this.ToolStripProgressBar_RT850.BackColor = Color.LightGray;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0028B884 File Offset: 0x00289C84
		public void EncerraEdicaoDeCampos_RT850()
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0028B888 File Offset: 0x00289C88
		public void Escrita_RT831_conf()
		{
			this.InicializaBarraProgressoTela_RT850(9);
			this.AtualizaMsgTela_RT850("Identificação de equipamento - Etapa 1", 0);
			this.ToolStripProgressBar_RT850.PerformStep();
			if (!Mod_MD.Leitura_pagina(0, 255, 4).Status)
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
			Linha_RT.Atualiza_dados_RT831_200(0, 0);
			this.AtualizaMsgTela_RT850("Escrita da configuração - Página 1 - Etapa 2", 2);
			this.ToolStripProgressBar_RT850.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			this.ToolStripProgressBar_RT850.PerformStep();
			if (!Mod_MD.Escrita_pagina(256, 60).Status)
			{
				this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			this.ToolStripProgressBar_RT850.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT850("Escrita da configuração - Página 2 - Etapa 3", 2);
			this.ToolStripProgressBar_RT850.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT850("Escrita de configuração - Página 2 - Etapa 4", 2);
			this.ToolStripProgressBar_RT850.PerformStep();
			if (!Mod_MD.Escrita_pagina(512, 60).Status)
			{
				this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			this.ToolStripProgressBar_RT850.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			int[] array = new int[]
			{
				768,
				1024,
				1280,
				1536
			};
			int num = 0;
			int num2 = 0;
			checked
			{
				for (;;)
				{
					int num3;
					int num4;
					switch (num2)
					{
					case 0:
						num3 = 0;
						num4 = 6;
						break;
					case 1:
						num3 = 7;
						num4 = 13;
						break;
					case 2:
						num3 = 14;
						num4 = 20;
						break;
					case 3:
						num3 = 20;
						num4 = 26;
						break;
					}
					if (num4 >= RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor)
					{
						num4 = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor - 1;
					}
					int num5 = num4 - num3 + 1;
					ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
					if (!ctrl_RESP_.Status)
					{
						break;
					}
					string texto = string.Format("Escrita da configuração - Página {0}A", num2 + 3);
					this.AtualizaMsgTela_RT850(texto, 2);
					Application.DoEvents();
					int bloco;
					if (num5 > 4)
					{
						bloco = 4;
						num += 4;
					}
					else
					{
						bloco = num5;
						num += num5;
					}
					if (!Mod_MD.Escrita_pagina_RT(array[num2], 60, bloco).Status)
					{
						goto Block_13;
					}
					if (num5 > 4)
					{
						texto = string.Format("Escrita da configuração - Página {0}B", num2 + 3);
						this.AtualizaMsgTela_RT850(texto, 2);
						Application.DoEvents();
						num += num5 - 4;
						bloco = num5 - 4;
						if (!Mod_MD.Escrita_pagina_RT(array[num2] + 76, 60, bloco).Status)
						{
							goto Block_15;
						}
					}
					ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
					if (!ctrl_RESP_.Status)
					{
						goto Block_16;
					}
					if (num == RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor)
					{
						goto IL_42B;
					}
					num2++;
					if (num2 > 3)
					{
						goto IL_42B;
					}
				}
				this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_13:
				this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_15:
				this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_16:
				this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				IL_42B:
				this.ToolStripProgressBar_RT850.PerformStep();
				ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				this.AtualizaMsgTela_RT850("Escrita da configuração - Página 7A", 2);
				Application.DoEvents();
				if (!Mod_MD.Escrita_pagina(2304, 60).Status)
				{
					this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				this.ToolStripProgressBar_RT850.PerformStep();
				this.AtualizaMsgTela_RT850("Escrita realizada com sucesso", 0);
				this.ToolStripProgressBar_RT850.PerformStep();
				this.Timer_limpa_MSG_RT850.Enabled = true;
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0028BDA8 File Offset: 0x0028A1A8
		private void TextBox_msg_inicial_RT850_TextChanged(object sender, EventArgs e)
		{
			int num;
			int num2;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				RT_geral.RT_850_BD.Msg_linha_1.Valor = Conversions.ToString(NewLateBinding.LateGet(sender, null, "lines", new object[]
				{
					0
				}, null, null, null));
				RT_geral.RT_850_BD.Msg_linha_2.Valor = Conversions.ToString(NewLateBinding.LateGet(sender, null, "lines", new object[]
				{
					1
				}, null, null, null));
				RT_geral.RT_850_BD.Msg_linha_3.Valor = Conversions.ToString(NewLateBinding.LateGet(sender, null, "lines", new object[]
				{
					2
				}, null, null, null));
				RT_geral.RT_850_BD.Msg_linha_4.Valor = Conversions.ToString(NewLateBinding.LateGet(sender, null, "lines", new object[]
				{
					3
				}, null, null, null));
				IL_D7:
				goto IL_11A;
				IL_D9:
				num2 = -1;
								IL_ED:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num2 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_D9;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			IL_11A:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0028BEE8 File Offset: 0x0028A2E8
		private void NumericUpDown_end_1_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre, true);
			sender = numericUpDown;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0028BF48 File Offset: 0x0028A348
		private void NumericUpDown_temp_ptt_1_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT, true);
			sender = numericUpDown;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0028BFA8 File Offset: 0x0028A3A8
		private void NumericUpDown_num_erro_falha_1_RT850_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0028BFAC File Offset: 0x0028A3AC
		private void ComboBox_baudrate_1_RT850_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.AtualizaValorPeloIndice();
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0028BFFC File Offset: 0x0028A3FC
		private void Button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0028C000 File Offset: 0x0028A400
		private void ToolStri_RT850_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0028C004 File Offset: 0x0028A404
		private void ToolStripButton_RT850_Imprimir_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			using (EnhancedPrintPreviewDialog enhancedPrintPreviewDialog = new EnhancedPrintPreviewDialog())
			{
				enhancedPrintPreviewDialog.Document = this.PrintDocument1;
				enhancedPrintPreviewDialog.ShowDialog();
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0028C04C File Offset: 0x0028A44C
		private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
		{
			RT_831_200_impressao_X.Impressao_BeginPrint_RT831();
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0028C054 File Offset: 0x0028A454
		private void PrintDocument1_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
		{
			e.PageSettings.Landscape = true;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0028C064 File Offset: 0x0028A464
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.HasMorePages = RT_831_200_impressao_X.DesenhaRelatorio_RT831(e);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0028C074 File Offset: 0x0028A474
		private void PrintPreviewDialog1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0028C078 File Offset: 0x0028A478
		private void AtualizaTodosNUD()
		{
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.NumericUpDown_end_mestre, RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre);
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.NumericUpDown_end_estacao, RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao);
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.NumericUpDown_temp_ptt_1_RT850, RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT);
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.NumericUpDown_senha, RT_831_200_variaveis_X.RT_831_200_BD.senha.senha);
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.nud_numero_equipamentos_reservatorios, RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios);
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.nud_numero_equipamentos_recalque, RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0028C124 File Offset: 0x0028A524
		private void AtualizaTodosCOMBOBOX()
		{
			RT_830_200_inicializa_variavies_X.AtualizaCOMBO(this.ComboBox_baudrate_RT850, RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0028C140 File Offset: 0x0028A540
		private void nud_numero_equipamentos_reservatorios_ValueChanged(object sender, EventArgs e)
		{
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios, true);
			sender = numericUpDown;
			this.DataGridView_Reservatorios.RowCount = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0028C1C4 File Offset: 0x0028A5C4
		private void DataGridView_Reservatorios_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string name = this.DataGridView_Reservatorios.Columns[e.ColumnIndex].Name;
			string text = name;
			if (Operators.CompareString(text, "RES_Nome", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[e.RowIndex].Nome.Valor = Conversions.ToInteger(this.DataGridView_Reservatorios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0028C25C File Offset: 0x0028A65C
		private void DataGridView_Reservatorios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string name = this.DataGridView_Reservatorios.Columns[e.ColumnIndex].Name;
			string text = name;
			if (Operators.CompareString(text, "RES_Nome", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[e.RowIndex].Nome.Valor = Conversions.ToInteger(this.DataGridView_Reservatorios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0028C2FC File Offset: 0x0028A6FC
		private void DataGridView_Recalques_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string name = this.DataGridView_Recalques.Columns[e.ColumnIndex].Name;
			string text = name;
			if (Operators.CompareString(text, "REC_Nome", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Nome.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Modelo", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Modelo.AtualizaIndiceValorPeloItem(Conversions.ToString(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
			}
			else if (Operators.CompareString(text, "REC_HabCMD", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Habilita.AtualizaIndiceValorPeloItem(Conversions.ToString(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
			}
			else if (Operators.CompareString(text, "REC_Escala1", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala1.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala1, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala2", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala2.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala2, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala3", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala3.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala3, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala4", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala4.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala4, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala5", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala5.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala5, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala6", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala6.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala6, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala7", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala7.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala7, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala8", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala8.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala8, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala9", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala9.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala9, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala10", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala10.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala10, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala11", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala11.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala11, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala12", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala12.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala12, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala13", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala13.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala13, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala14", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala14.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala14, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala15", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala15.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala15, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala16", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala16.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala16, e, true);
				sender = dataGridView;
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0028CD98 File Offset: 0x0028B198
		private void DataGridView_Recalques_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string name = this.DataGridView_Recalques.Columns[e.ColumnIndex].Name;
			string text = name;
			if (Operators.CompareString(text, "REC_Nome", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Nome.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Modelo", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Modelo.AtualizaIndiceValorPeloItem(Conversions.ToString(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
			}
			else if (Operators.CompareString(text, "REC_HabCMD", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Habilita.AtualizaIndiceValorPeloItem(Conversions.ToString(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
			}
			else if (Operators.CompareString(text, "REC_Escala1", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala1.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala2", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala2.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala3", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala3.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala4", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala4.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala5", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala5.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala6", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala6.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala7", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala7.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala8", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala8.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala9", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala9.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala10", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala10.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala11", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala11.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala12", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala12.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala13", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala13.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala14", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala14.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala15", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala15.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala16", false) == 0)
			{
				RT_831_200_variaveis_X.RT_831_200_BD.recalque[e.RowIndex].Escala16.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0028D524 File Offset: 0x0028B924
		private void nud_numero_equipamentos_recalque_ValueChanged(object sender, EventArgs e)
		{
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques, true);
			sender = numericUpDown;
			this.DataGridView_Recalques.RowCount = Convert.ToInt32(this.nud_numero_equipamentos_recalque.Value);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0028D59C File Offset: 0x0028B99C
		private void nud_numero_equipamentos_vista_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0028D5A0 File Offset: 0x0028B9A0
		private void DataGridView_Reservatorios_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			if (this.DataGridView_Reservatorios.IsCurrentCellDirty)
			{
				this.DataGridView_Reservatorios.CommitEdit(512);
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0028D5D0 File Offset: 0x0028B9D0
		private void NumericUpDown_senha_ValueChanged(object sender, EventArgs e)
		{
			RT_831_200_variaveis_X.RT_831_200_BD.senha.senha.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_831_200_variaveis_X.RT_831_200_BD.senha.senha, true);
			sender = numericUpDown;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0028D630 File Offset: 0x0028BA30
		private void NumericUpDown_end_estacao_ValueChanged(object sender, EventArgs e)
		{
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao, true);
			sender = numericUpDown;
		}

		// Token: 0x040003AE RID: 942
		[AccessedThroughProperty("ToolStri_RT850")]
		private ToolStrip _ToolStri_RT850;

		// Token: 0x040003AF RID: 943
		[AccessedThroughProperty("ToolStripButton_RT850_novo")]
		private ToolStripButton _ToolStripButton_RT850_novo;

		// Token: 0x040003B0 RID: 944
		[AccessedThroughProperty("ToolStripButton_RT850_Abrir")]
		private ToolStripButton _ToolStripButton_RT850_Abrir;

		// Token: 0x040003B1 RID: 945
		[AccessedThroughProperty("ToolStripButton_RT850_Salvar")]
		private ToolStripButton _ToolStripButton_RT850_Salvar;

		// Token: 0x040003B2 RID: 946
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x040003B3 RID: 947
		[AccessedThroughProperty("ToolStripButton_RT850_Download")]
		private ToolStripButton _ToolStripButton_RT850_Download;

		// Token: 0x040003B4 RID: 948
		[AccessedThroughProperty("ToolStripButton_RT850_Upload")]
		private ToolStripButton _ToolStripButton_RT850_Upload;

		// Token: 0x040003B5 RID: 949
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x040003B6 RID: 950
		[AccessedThroughProperty("ToolStripTextBox_RT850_Msg")]
		private ToolStripTextBox _ToolStripTextBox_RT850_Msg;

		// Token: 0x040003B7 RID: 951
		[AccessedThroughProperty("ToolStripProgressBar_RT850")]
		private ToolStripProgressBar _ToolStripProgressBar_RT850;

		// Token: 0x040003B8 RID: 952
		[AccessedThroughProperty("TabControl_850")]
		private TabControl _TabControl_850;

		// Token: 0x040003B9 RID: 953
		[AccessedThroughProperty("TabPage_geral")]
		private TabPage _TabPage_geral;

		// Token: 0x040003BA RID: 954
		[AccessedThroughProperty("GroupBox_descricao_RT850")]
		private GroupBox _GroupBox_descricao_RT850;

		// Token: 0x040003BB RID: 955
		[AccessedThroughProperty("TextBox_comentarios_RT850")]
		private TextBox _TextBox_comentarios_RT850;

		// Token: 0x040003BC RID: 956
		[AccessedThroughProperty("TextBox_endereco_RT850")]
		private TextBox _TextBox_endereco_RT850;

		// Token: 0x040003BD RID: 957
		[AccessedThroughProperty("TextBox_nome_RT850")]
		private TextBox _TextBox_nome_RT850;

		// Token: 0x040003BE RID: 958
		[AccessedThroughProperty("Label_comentarios_RT850")]
		private Label _Label_comentarios_RT850;

		// Token: 0x040003BF RID: 959
		[AccessedThroughProperty("Label_endereco_RT850")]
		private Label _Label_endereco_RT850;

		// Token: 0x040003C0 RID: 960
		[AccessedThroughProperty("Label_nome_RT850")]
		private Label _Label_nome_RT850;

		// Token: 0x040003C1 RID: 961
		[AccessedThroughProperty("GroupBox_informacoes_RT850")]
		private GroupBox _GroupBox_informacoes_RT850;

		// Token: 0x040003C2 RID: 962
		[AccessedThroughProperty("TabPage_controles")]
		private TabPage _TabPage_controles;

		// Token: 0x040003C3 RID: 963
		[AccessedThroughProperty("GroupBox_canal_1_RT850")]
		private GroupBox _GroupBox_canal_1_RT850;

		// Token: 0x040003C4 RID: 964
		[AccessedThroughProperty("Label_end_canal_1_RT850")]
		private Label _Label_end_canal_1_RT850;

		// Token: 0x040003C5 RID: 965
		[AccessedThroughProperty("ComboBox_baudrate_RT850")]
		private ComboBox _ComboBox_baudrate_RT850;

		// Token: 0x040003C6 RID: 966
		[AccessedThroughProperty("Label_baudrate_1_RT850")]
		private Label _Label_baudrate_1_RT850;

		// Token: 0x040003C7 RID: 967
		[AccessedThroughProperty("NumericUpDown_end_estacao")]
		private NumericUpDown _NumericUpDown_end_estacao;

		// Token: 0x040003C8 RID: 968
		[AccessedThroughProperty("Label_num_tentativas_1_RT850")]
		private Label _Label_num_tentativas_1_RT850;

		// Token: 0x040003C9 RID: 969
		[AccessedThroughProperty("NumericUpDown_temp_ptt_1_RT850")]
		private NumericUpDown _NumericUpDown_temp_ptt_1_RT850;

		// Token: 0x040003CA RID: 970
		[AccessedThroughProperty("Label_tempo_ptt_1_RT850")]
		private Label _Label_tempo_ptt_1_RT850;

		// Token: 0x040003CB RID: 971
		[AccessedThroughProperty("NumericUpDown_end_mestre")]
		private NumericUpDown _NumericUpDown_end_mestre;

		// Token: 0x040003CC RID: 972
		[AccessedThroughProperty("OpenFileDialog_RT850")]
		private OpenFileDialog _OpenFileDialog_RT850;

		// Token: 0x040003CD RID: 973
		[AccessedThroughProperty("SaveFileDialog_RT850")]
		private SaveFileDialog _SaveFileDialog_RT850;

		// Token: 0x040003CE RID: 974
		[AccessedThroughProperty("Timer_limpa_MSG_RT850")]
		private Timer _Timer_limpa_MSG_RT850;

		// Token: 0x040003CF RID: 975
		[AccessedThroughProperty("TabPage_Equipamentos")]
		private TabPage _TabPage_Equipamentos;

		// Token: 0x040003D0 RID: 976
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x040003D1 RID: 977
		[AccessedThroughProperty("ToolStripButton_RT850_Imprimir")]
		private ToolStripButton _ToolStripButton_RT850_Imprimir;

		// Token: 0x040003D2 RID: 978
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x040003D3 RID: 979
		[AccessedThroughProperty("PrintDocument1")]
		private PrintDocument _PrintDocument1;

		// Token: 0x040003D4 RID: 980
		[AccessedThroughProperty("PrintPreviewDialog1")]
		private PrintPreviewDialog _PrintPreviewDialog1;

		// Token: 0x040003D5 RID: 981
		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		// Token: 0x040003D6 RID: 982
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x040003D7 RID: 983
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x040003D8 RID: 984
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x040003D9 RID: 985
		[AccessedThroughProperty("T_AlturaAntena1")]
		private TextBox _T_AlturaAntena1;

		// Token: 0x040003DA RID: 986
		[AccessedThroughProperty("T_Latitude1")]
		private TextBox _T_Latitude1;

		// Token: 0x040003DB RID: 987
		[AccessedThroughProperty("T_Longitude1")]
		private TextBox _T_Longitude1;

		// Token: 0x040003DC RID: 988
		[AccessedThroughProperty("T_Azimute1")]
		private TextBox _T_Azimute1;

		// Token: 0x040003DD RID: 989
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x040003DE RID: 990
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x040003DF RID: 991
		[AccessedThroughProperty("T_FreqRadio1")]
		private TextBox _T_FreqRadio1;

		// Token: 0x040003E0 RID: 992
		[AccessedThroughProperty("T_PotRadio1")]
		private TextBox _T_PotRadio1;

		// Token: 0x040003E1 RID: 993
		[AccessedThroughProperty("CB_ModeloRadio1")]
		private ComboBox _CB_ModeloRadio1;

		// Token: 0x040003E2 RID: 994
		[AccessedThroughProperty("CB_PolarizacaoAntena1")]
		private ComboBox _CB_PolarizacaoAntena1;

		// Token: 0x040003E3 RID: 995
		[AccessedThroughProperty("CB_TipoAntena1")]
		private ComboBox _CB_TipoAntena1;

		// Token: 0x040003E4 RID: 996
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040003E5 RID: 997
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x040003E6 RID: 998
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x040003E7 RID: 999
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040003E8 RID: 1000
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040003E9 RID: 1001
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040003EA RID: 1002
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040003EB RID: 1003
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040003EC RID: 1004
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x040003ED RID: 1005
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x040003EE RID: 1006
		[AccessedThroughProperty("ToolStripLabel1")]
		private ToolStripLabel _ToolStripLabel1;

		// Token: 0x040003EF RID: 1007
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x040003F0 RID: 1008
		[AccessedThroughProperty("TextBox_equipamento_RT850")]
		private TextBox _TextBox_equipamento_RT850;

		// Token: 0x040003F1 RID: 1009
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x040003F2 RID: 1010
		[AccessedThroughProperty("TextBox_release_RT850")]
		private TextBox _TextBox_release_RT850;

		// Token: 0x040003F3 RID: 1011
		[AccessedThroughProperty("Label29")]
		private Label _Label29;

		// Token: 0x040003F4 RID: 1012
		[AccessedThroughProperty("TextBox_build_RT850")]
		private TextBox _TextBox_build_RT850;

		// Token: 0x040003F5 RID: 1013
		[AccessedThroughProperty("Label30")]
		private Label _Label30;

		// Token: 0x040003F6 RID: 1014
		[AccessedThroughProperty("TextBox_versao_RT850")]
		private TextBox _TextBox_versao_RT850;

		// Token: 0x040003F7 RID: 1015
		[AccessedThroughProperty("Label31")]
		private Label _Label31;

		// Token: 0x040003F8 RID: 1016
		[AccessedThroughProperty("Label34")]
		private Label _Label34;

		// Token: 0x040003F9 RID: 1017
		[AccessedThroughProperty("Label33")]
		private Label _Label33;

		// Token: 0x040003FA RID: 1018
		[AccessedThroughProperty("nud_numero_equipamentos_recalque")]
		private NumericUpDown _nud_numero_equipamentos_recalque;

		// Token: 0x040003FB RID: 1019
		[AccessedThroughProperty("nud_numero_equipamentos_reservatorios")]
		private NumericUpDown _nud_numero_equipamentos_reservatorios;

		// Token: 0x040003FC RID: 1020
		[AccessedThroughProperty("TabPage_Reservatorio")]
		private TabPage _TabPage_Reservatorio;

		// Token: 0x040003FD RID: 1021
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x040003FE RID: 1022
		[AccessedThroughProperty("DataGridView_Reservatorios")]
		private DataGridView _DataGridView_Reservatorios;

		// Token: 0x040003FF RID: 1023
		[AccessedThroughProperty("TabPage_Recalque")]
		private TabPage _TabPage_Recalque;

		// Token: 0x04000400 RID: 1024
		[AccessedThroughProperty("DataGridView_Recalques")]
		private DataGridView _DataGridView_Recalques;

		// Token: 0x04000401 RID: 1025
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		// Token: 0x04000402 RID: 1026
		[AccessedThroughProperty("RES_Posicao")]
		private DataGridViewTextBoxColumn _RES_Posicao;

		// Token: 0x04000403 RID: 1027
		[AccessedThroughProperty("RES_Nome")]
		private DataGridViewTextBoxColumn _RES_Nome;

		// Token: 0x04000404 RID: 1028
		[AccessedThroughProperty("REC_Posicao")]
		private DataGridViewTextBoxColumn _REC_Posicao;

		// Token: 0x04000405 RID: 1029
		[AccessedThroughProperty("REC_Nome")]
		private DataGridViewTextBoxColumn _REC_Nome;

		// Token: 0x04000406 RID: 1030
		[AccessedThroughProperty("REC_Modelo")]
		private DataGridViewComboBoxColumn _REC_Modelo;

		// Token: 0x04000407 RID: 1031
		[AccessedThroughProperty("REC_HabCMD")]
		private DataGridViewComboBoxColumn _REC_HabCMD;

		// Token: 0x04000408 RID: 1032
		[AccessedThroughProperty("REC_Escala1")]
		private DataGridViewTextBoxColumn _REC_Escala1;

		// Token: 0x04000409 RID: 1033
		[AccessedThroughProperty("REC_Escala2")]
		private DataGridViewTextBoxColumn _REC_Escala2;

		// Token: 0x0400040A RID: 1034
		[AccessedThroughProperty("REC_Escala3")]
		private DataGridViewTextBoxColumn _REC_Escala3;

		// Token: 0x0400040B RID: 1035
		[AccessedThroughProperty("REC_Escala4")]
		private DataGridViewTextBoxColumn _REC_Escala4;

		// Token: 0x0400040C RID: 1036
		[AccessedThroughProperty("REC_Escala5")]
		private DataGridViewTextBoxColumn _REC_Escala5;

		// Token: 0x0400040D RID: 1037
		[AccessedThroughProperty("REC_Escala6")]
		private DataGridViewTextBoxColumn _REC_Escala6;

		// Token: 0x0400040E RID: 1038
		[AccessedThroughProperty("REC_Escala7")]
		private DataGridViewTextBoxColumn _REC_Escala7;

		// Token: 0x0400040F RID: 1039
		[AccessedThroughProperty("REC_Escala8")]
		private DataGridViewTextBoxColumn _REC_Escala8;

		// Token: 0x04000410 RID: 1040
		[AccessedThroughProperty("REC_Escala9")]
		private DataGridViewTextBoxColumn _REC_Escala9;

		// Token: 0x04000411 RID: 1041
		[AccessedThroughProperty("REC_Escala10")]
		private DataGridViewTextBoxColumn _REC_Escala10;

		// Token: 0x04000412 RID: 1042
		[AccessedThroughProperty("REC_Escala11")]
		private DataGridViewTextBoxColumn _REC_Escala11;

		// Token: 0x04000413 RID: 1043
		[AccessedThroughProperty("REC_Escala12")]
		private DataGridViewTextBoxColumn _REC_Escala12;

		// Token: 0x04000414 RID: 1044
		[AccessedThroughProperty("REC_Escala13")]
		private DataGridViewTextBoxColumn _REC_Escala13;

		// Token: 0x04000415 RID: 1045
		[AccessedThroughProperty("REC_Escala14")]
		private DataGridViewTextBoxColumn _REC_Escala14;

		// Token: 0x04000416 RID: 1046
		[AccessedThroughProperty("REC_Escala15")]
		private DataGridViewTextBoxColumn _REC_Escala15;

		// Token: 0x04000417 RID: 1047
		[AccessedThroughProperty("REC_Escala16")]
		private DataGridViewTextBoxColumn _REC_Escala16;

		// Token: 0x04000418 RID: 1048
		[AccessedThroughProperty("TabPage_Senha")]
		private TabPage _TabPage_Senha;

		// Token: 0x04000419 RID: 1049
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x0400041A RID: 1050
		[AccessedThroughProperty("NumericUpDown_senha")]
		private NumericUpDown _NumericUpDown_senha;

		// Token: 0x0400041B RID: 1051
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400041C RID: 1052
		[AccessedThroughProperty("tb_lixo1")]
		private TextBox _tb_lixo1;

		// Token: 0x0400041D RID: 1053
		[AccessedThroughProperty("tb_lixo2")]
		private TextBox _tb_lixo2;

		// Token: 0x0400041E RID: 1054
		[AccessedThroughProperty("tb_lixo3")]
		private TextBox _tb_lixo3;

		// Token: 0x0400041F RID: 1055
		[AccessedThroughProperty("tb_lixo4")]
		private TextBox _tb_lixo4;

		// Token: 0x04000420 RID: 1056
		[AccessedThroughProperty("tb_lixo5")]
		private TextBox _tb_lixo5;

		// Token: 0x04000421 RID: 1057
		[AccessedThroughProperty("tb_lixo6")]
		private TextBox _tb_lixo6;

		// Token: 0x04000422 RID: 1058
		[AccessedThroughProperty("tb_lixo7")]
		private TextBox _tb_lixo7;
	}
}
