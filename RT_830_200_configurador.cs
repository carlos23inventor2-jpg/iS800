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
	// Token: 0x02000016 RID: 22
	[DesignerGenerated]
	public partial class RT_830_200_configurador : Form
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x00266858 File Offset: 0x00264C58
		public RT_830_200_configurador()
		{
			base.FormClosing += new FormClosingEventHandler(this.RT_850_conf_FormClosing);
			base.Load += new EventHandler(this.RT_850_conf_Load);
			base.FormClosed += new FormClosedEventHandler(this.RT_850_conf_FormClosed);
			base.Activated += new EventHandler(this.RT_850_conf_Activated);
			this.InitializeComponent();
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0026BDAC File Offset: 0x0026A1AC
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0026BDC0 File Offset: 0x0026A1C0
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

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0026BE0C File Offset: 0x0026A20C
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0026BE20 File Offset: 0x0026A220
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

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0026BE6C File Offset: 0x0026A26C
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0026BE80 File Offset: 0x0026A280
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

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0026BECC File Offset: 0x0026A2CC
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0026BEE0 File Offset: 0x0026A2E0
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

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0026BF2C File Offset: 0x0026A32C
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0026BF40 File Offset: 0x0026A340
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

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0026BF4C File Offset: 0x0026A34C
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0026BF60 File Offset: 0x0026A360
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

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0026BFAC File Offset: 0x0026A3AC
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0026BFC0 File Offset: 0x0026A3C0
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

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0026C00C File Offset: 0x0026A40C
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0026C020 File Offset: 0x0026A420
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

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0026C02C File Offset: 0x0026A42C
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0026C040 File Offset: 0x0026A440
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0026C04C File Offset: 0x0026A44C
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0026C060 File Offset: 0x0026A460
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

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0026C06C File Offset: 0x0026A46C
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0026C080 File Offset: 0x0026A480
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

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0026C0CC File Offset: 0x0026A4CC
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0026C0E0 File Offset: 0x0026A4E0
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

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0026C0EC File Offset: 0x0026A4EC
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0026C100 File Offset: 0x0026A500
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

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0026C10C File Offset: 0x0026A50C
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0026C120 File Offset: 0x0026A520
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0026C12C File Offset: 0x0026A52C
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0026C140 File Offset: 0x0026A540
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

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0026C14C File Offset: 0x0026A54C
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0026C160 File Offset: 0x0026A560
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

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0026C16C File Offset: 0x0026A56C
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0026C180 File Offset: 0x0026A580
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

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0026C18C File Offset: 0x0026A58C
		// (set) Token: 0x0600011E RID: 286 RVA: 0x0026C1A0 File Offset: 0x0026A5A0
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

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0026C1AC File Offset: 0x0026A5AC
		// (set) Token: 0x06000120 RID: 288 RVA: 0x0026C1C0 File Offset: 0x0026A5C0
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

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0026C1CC File Offset: 0x0026A5CC
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0026C1E0 File Offset: 0x0026A5E0
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0026C1EC File Offset: 0x0026A5EC
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0026C200 File Offset: 0x0026A600
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

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0026C20C File Offset: 0x0026A60C
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0026C220 File Offset: 0x0026A620
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

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0026C22C File Offset: 0x0026A62C
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0026C240 File Offset: 0x0026A640
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

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0026C24C File Offset: 0x0026A64C
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0026C260 File Offset: 0x0026A660
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0026C26C File Offset: 0x0026A66C
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0026C280 File Offset: 0x0026A680
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

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0026C2CC File Offset: 0x0026A6CC
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0026C2E0 File Offset: 0x0026A6E0
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

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0026C2EC File Offset: 0x0026A6EC
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0026C300 File Offset: 0x0026A700
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0026C34C File Offset: 0x0026A74C
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0026C360 File Offset: 0x0026A760
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

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0026C36C File Offset: 0x0026A76C
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0026C380 File Offset: 0x0026A780
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

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0026C3CC File Offset: 0x0026A7CC
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0026C3E0 File Offset: 0x0026A7E0
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

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0026C3EC File Offset: 0x0026A7EC
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0026C400 File Offset: 0x0026A800
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

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0026C44C File Offset: 0x0026A84C
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0026C460 File Offset: 0x0026A860
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

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0026C46C File Offset: 0x0026A86C
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0026C480 File Offset: 0x0026A880
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0026C4CC File Offset: 0x0026A8CC
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0026C4E0 File Offset: 0x0026A8E0
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

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0026C4EC File Offset: 0x0026A8EC
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0026C500 File Offset: 0x0026A900
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

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0026C54C File Offset: 0x0026A94C
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0026C560 File Offset: 0x0026A960
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

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0026C5AC File Offset: 0x0026A9AC
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0026C5C0 File Offset: 0x0026A9C0
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

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0026C5CC File Offset: 0x0026A9CC
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0026C5E0 File Offset: 0x0026A9E0
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

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0026C5EC File Offset: 0x0026A9EC
		// (set) Token: 0x06000148 RID: 328 RVA: 0x0026C600 File Offset: 0x0026AA00
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

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0026C64C File Offset: 0x0026AA4C
		// (set) Token: 0x0600014A RID: 330 RVA: 0x0026C660 File Offset: 0x0026AA60
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

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0026C66C File Offset: 0x0026AA6C
		// (set) Token: 0x0600014C RID: 332 RVA: 0x0026C680 File Offset: 0x0026AA80
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

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0026C68C File Offset: 0x0026AA8C
		// (set) Token: 0x0600014E RID: 334 RVA: 0x0026C6A0 File Offset: 0x0026AAA0
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

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0026C6EC File Offset: 0x0026AAEC
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0026C700 File Offset: 0x0026AB00
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

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0026C70C File Offset: 0x0026AB0C
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0026C720 File Offset: 0x0026AB20
		internal virtual PrintDocument PrintDocument1
		{
			get
			{
				return this._PrintDocument1;
			}
			[MethodImpl(32)]
			set
			{
				PrintEventHandler printEventHandler = new PrintEventHandler(this.PrintDocument1_BeginPrint);
				PrintPageEventHandler printPageEventHandler = new PrintPageEventHandler(this.PrintDocument1_PrintPage);
				QueryPageSettingsEventHandler queryPageSettingsEventHandler = new QueryPageSettingsEventHandler(this.PrintDocument1_QueryPageSettings);
				if (this._PrintDocument1 != null)
				{
					this._PrintDocument1.BeginPrint -= printEventHandler;
					this._PrintDocument1.PrintPage -= printPageEventHandler;
					this._PrintDocument1.QueryPageSettings -= queryPageSettingsEventHandler;
				}
				this._PrintDocument1 = value;
				if (this._PrintDocument1 != null)
				{
					this._PrintDocument1.BeginPrint += printEventHandler;
					this._PrintDocument1.PrintPage += printPageEventHandler;
					this._PrintDocument1.QueryPageSettings += queryPageSettingsEventHandler;
				}
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0026C7B8 File Offset: 0x0026ABB8
		// (set) Token: 0x06000154 RID: 340 RVA: 0x0026C7CC File Offset: 0x0026ABCC
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

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0026C818 File Offset: 0x0026AC18
		// (set) Token: 0x06000156 RID: 342 RVA: 0x0026C82C File Offset: 0x0026AC2C
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

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0026C838 File Offset: 0x0026AC38
		// (set) Token: 0x06000158 RID: 344 RVA: 0x0026C84C File Offset: 0x0026AC4C
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0026C858 File Offset: 0x0026AC58
		// (set) Token: 0x0600015A RID: 346 RVA: 0x0026C86C File Offset: 0x0026AC6C
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

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0026C878 File Offset: 0x0026AC78
		// (set) Token: 0x0600015C RID: 348 RVA: 0x0026C88C File Offset: 0x0026AC8C
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

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0026C898 File Offset: 0x0026AC98
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0026C8AC File Offset: 0x0026ACAC
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

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0026C8B8 File Offset: 0x0026ACB8
		// (set) Token: 0x06000160 RID: 352 RVA: 0x0026C8CC File Offset: 0x0026ACCC
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

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0026C8D8 File Offset: 0x0026ACD8
		// (set) Token: 0x06000162 RID: 354 RVA: 0x0026C8EC File Offset: 0x0026ACEC
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

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0026C8F8 File Offset: 0x0026ACF8
		// (set) Token: 0x06000164 RID: 356 RVA: 0x0026C90C File Offset: 0x0026AD0C
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

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0026C918 File Offset: 0x0026AD18
		// (set) Token: 0x06000166 RID: 358 RVA: 0x0026C92C File Offset: 0x0026AD2C
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

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0026C938 File Offset: 0x0026AD38
		// (set) Token: 0x06000168 RID: 360 RVA: 0x0026C94C File Offset: 0x0026AD4C
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

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0026C958 File Offset: 0x0026AD58
		// (set) Token: 0x0600016A RID: 362 RVA: 0x0026C96C File Offset: 0x0026AD6C
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

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0026C978 File Offset: 0x0026AD78
		// (set) Token: 0x0600016C RID: 364 RVA: 0x0026C98C File Offset: 0x0026AD8C
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

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0026C998 File Offset: 0x0026AD98
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0026C9AC File Offset: 0x0026ADAC
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

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0026C9B8 File Offset: 0x0026ADB8
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0026C9CC File Offset: 0x0026ADCC
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

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0026C9D8 File Offset: 0x0026ADD8
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0026C9EC File Offset: 0x0026ADEC
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

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0026C9F8 File Offset: 0x0026ADF8
		// (set) Token: 0x06000174 RID: 372 RVA: 0x0026CA0C File Offset: 0x0026AE0C
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

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0026CA18 File Offset: 0x0026AE18
		// (set) Token: 0x06000176 RID: 374 RVA: 0x0026CA2C File Offset: 0x0026AE2C
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0026CA38 File Offset: 0x0026AE38
		// (set) Token: 0x06000178 RID: 376 RVA: 0x0026CA4C File Offset: 0x0026AE4C
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

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0026CA58 File Offset: 0x0026AE58
		// (set) Token: 0x0600017A RID: 378 RVA: 0x0026CA6C File Offset: 0x0026AE6C
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

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0026CA78 File Offset: 0x0026AE78
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0026CA8C File Offset: 0x0026AE8C
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

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0026CA98 File Offset: 0x0026AE98
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0026CAAC File Offset: 0x0026AEAC
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

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0026CAB8 File Offset: 0x0026AEB8
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0026CACC File Offset: 0x0026AECC
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

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0026CAD8 File Offset: 0x0026AED8
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0026CAEC File Offset: 0x0026AEEC
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

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0026CAF8 File Offset: 0x0026AEF8
		// (set) Token: 0x06000184 RID: 388 RVA: 0x0026CB0C File Offset: 0x0026AF0C
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

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0026CB18 File Offset: 0x0026AF18
		// (set) Token: 0x06000186 RID: 390 RVA: 0x0026CB2C File Offset: 0x0026AF2C
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

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0026CB38 File Offset: 0x0026AF38
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0026CB4C File Offset: 0x0026AF4C
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

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0026CB58 File Offset: 0x0026AF58
		// (set) Token: 0x0600018A RID: 394 RVA: 0x0026CB6C File Offset: 0x0026AF6C
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

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0026CB78 File Offset: 0x0026AF78
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0026CB8C File Offset: 0x0026AF8C
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0026CB98 File Offset: 0x0026AF98
		// (set) Token: 0x0600018E RID: 398 RVA: 0x0026CBAC File Offset: 0x0026AFAC
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0026CBB8 File Offset: 0x0026AFB8
		// (set) Token: 0x06000190 RID: 400 RVA: 0x0026CBCC File Offset: 0x0026AFCC
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

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0026CBD8 File Offset: 0x0026AFD8
		// (set) Token: 0x06000192 RID: 402 RVA: 0x0026CBEC File Offset: 0x0026AFEC
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0026CBF8 File Offset: 0x0026AFF8
		// (set) Token: 0x06000194 RID: 404 RVA: 0x0026CC0C File Offset: 0x0026B00C
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

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0026CC18 File Offset: 0x0026B018
		// (set) Token: 0x06000196 RID: 406 RVA: 0x0026CC2C File Offset: 0x0026B02C
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

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0026CC38 File Offset: 0x0026B038
		// (set) Token: 0x06000198 RID: 408 RVA: 0x0026CC4C File Offset: 0x0026B04C
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0026CC58 File Offset: 0x0026B058
		// (set) Token: 0x0600019A RID: 410 RVA: 0x0026CC6C File Offset: 0x0026B06C
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

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0026CC78 File Offset: 0x0026B078
		// (set) Token: 0x0600019C RID: 412 RVA: 0x0026CC8C File Offset: 0x0026B08C
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

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0026CC98 File Offset: 0x0026B098
		// (set) Token: 0x0600019E RID: 414 RVA: 0x0026CCAC File Offset: 0x0026B0AC
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

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0026CCB8 File Offset: 0x0026B0B8
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x0026CCCC File Offset: 0x0026B0CC
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

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0026CCD8 File Offset: 0x0026B0D8
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x0026CCEC File Offset: 0x0026B0EC
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0026CCF8 File Offset: 0x0026B0F8
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0026CD0C File Offset: 0x0026B10C
		internal virtual NumericUpDown nud_numero_equipamentos_vista
		{
			get
			{
				return this._nud_numero_equipamentos_vista;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_numero_equipamentos_vista_ValueChanged);
				if (this._nud_numero_equipamentos_vista != null)
				{
					this._nud_numero_equipamentos_vista.ValueChanged -= eventHandler;
				}
				this._nud_numero_equipamentos_vista = value;
				if (this._nud_numero_equipamentos_vista != null)
				{
					this._nud_numero_equipamentos_vista.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0026CD58 File Offset: 0x0026B158
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0026CD6C File Offset: 0x0026B16C
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0026CDB8 File Offset: 0x0026B1B8
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x0026CDCC File Offset: 0x0026B1CC
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0026CE18 File Offset: 0x0026B218
		// (set) Token: 0x060001AA RID: 426 RVA: 0x0026CE2C File Offset: 0x0026B22C
		internal virtual NumericUpDown nud_numero_reservatorios
		{
			get
			{
				return this._nud_numero_reservatorios;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_numero_reservatorios_ValueChanged);
				if (this._nud_numero_reservatorios != null)
				{
					this._nud_numero_reservatorios.ValueChanged -= eventHandler;
				}
				this._nud_numero_reservatorios = value;
				if (this._nud_numero_reservatorios != null)
				{
					this._nud_numero_reservatorios.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0026CE78 File Offset: 0x0026B278
		// (set) Token: 0x060001AC RID: 428 RVA: 0x0026CE8C File Offset: 0x0026B28C
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

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0026CE98 File Offset: 0x0026B298
		// (set) Token: 0x060001AE RID: 430 RVA: 0x0026CEAC File Offset: 0x0026B2AC
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0026CEB8 File Offset: 0x0026B2B8
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x0026CECC File Offset: 0x0026B2CC
		internal virtual NumericUpDown nud_end_inicial_vista
		{
			get
			{
				return this._nud_end_inicial_vista;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_end_inicial_vista_ValueChanged);
				if (this._nud_end_inicial_vista != null)
				{
					this._nud_end_inicial_vista.ValueChanged -= eventHandler;
				}
				this._nud_end_inicial_vista = value;
				if (this._nud_end_inicial_vista != null)
				{
					this._nud_end_inicial_vista.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0026CF18 File Offset: 0x0026B318
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x0026CF2C File Offset: 0x0026B32C
		internal virtual NumericUpDown nud_end_inicial_recalque
		{
			get
			{
				return this._nud_end_inicial_recalque;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_end_inicial_recalque_ValueChanged);
				if (this._nud_end_inicial_recalque != null)
				{
					this._nud_end_inicial_recalque.ValueChanged -= eventHandler;
				}
				this._nud_end_inicial_recalque = value;
				if (this._nud_end_inicial_recalque != null)
				{
					this._nud_end_inicial_recalque.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0026CF78 File Offset: 0x0026B378
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x0026CF8C File Offset: 0x0026B38C
		internal virtual NumericUpDown nud_end_inicial_reservatorio
		{
			get
			{
				return this._nud_end_inicial_reservatorio;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_end_inicial_reservatorio_ValueChanged);
				if (this._nud_end_inicial_reservatorio != null)
				{
					this._nud_end_inicial_reservatorio.ValueChanged -= eventHandler;
				}
				this._nud_end_inicial_reservatorio = value;
				if (this._nud_end_inicial_reservatorio != null)
				{
					this._nud_end_inicial_reservatorio.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0026CFD8 File Offset: 0x0026B3D8
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x0026CFEC File Offset: 0x0026B3EC
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

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0026CFF8 File Offset: 0x0026B3F8
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x0026D00C File Offset: 0x0026B40C
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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0026D018 File Offset: 0x0026B418
		// (set) Token: 0x060001BA RID: 442 RVA: 0x0026D02C File Offset: 0x0026B42C
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0026D038 File Offset: 0x0026B438
		// (set) Token: 0x060001BC RID: 444 RVA: 0x0026D04C File Offset: 0x0026B44C
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0026D058 File Offset: 0x0026B458
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0026D06C File Offset: 0x0026B46C
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

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0026D104 File Offset: 0x0026B504
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x0026D118 File Offset: 0x0026B518
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0026D124 File Offset: 0x0026B524
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x0026D138 File Offset: 0x0026B538
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

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0026D144 File Offset: 0x0026B544
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x0026D158 File Offset: 0x0026B558
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

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0026D1C8 File Offset: 0x0026B5C8
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x0026D1DC File Offset: 0x0026B5DC
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0026D1E8 File Offset: 0x0026B5E8
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x0026D1FC File Offset: 0x0026B5FC
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

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0026D208 File Offset: 0x0026B608
		// (set) Token: 0x060001CA RID: 458 RVA: 0x0026D21C File Offset: 0x0026B61C
		internal virtual DataGridView DataGridView_Qtd_Vista
		{
			get
			{
				return this._DataGridView_Qtd_Vista;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_Qtd_Vista_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_Qtd_Vista_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_Qtd_Vista_CellValidating);
				if (this._DataGridView_Qtd_Vista != null)
				{
					this._DataGridView_Qtd_Vista.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_Qtd_Vista.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_Qtd_Vista.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_Qtd_Vista = value;
				if (this._DataGridView_Qtd_Vista != null)
				{
					this._DataGridView_Qtd_Vista.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_Qtd_Vista.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_Qtd_Vista.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0026D2B4 File Offset: 0x0026B6B4
		// (set) Token: 0x060001CC RID: 460 RVA: 0x0026D2C8 File Offset: 0x0026B6C8
		internal virtual DataGridView DataGridView_Vista_Variaveis
		{
			get
			{
				return this._DataGridView_Vista_Variaveis;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_Vista_Variaveis_CellValidated);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_Vista_Variaveis_CellValidating);
				EventHandler eventHandler = new EventHandler(this.DataGridView_Vista_Variaveis_CurrentCellDirtyStateChanged);
				if (this._DataGridView_Vista_Variaveis != null)
				{
					this._DataGridView_Vista_Variaveis.CellValidated -= dataGridViewCellEventHandler;
					this._DataGridView_Vista_Variaveis.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_Vista_Variaveis.CurrentCellDirtyStateChanged -= eventHandler;
				}
				this._DataGridView_Vista_Variaveis = value;
				if (this._DataGridView_Vista_Variaveis != null)
				{
					this._DataGridView_Vista_Variaveis.CellValidated += dataGridViewCellEventHandler;
					this._DataGridView_Vista_Variaveis.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_Vista_Variaveis.CurrentCellDirtyStateChanged += eventHandler;
				}
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0026D360 File Offset: 0x0026B760
		// (set) Token: 0x060001CE RID: 462 RVA: 0x0026D374 File Offset: 0x0026B774
		internal virtual DataGridView DataGridView_Vista_Remotas
		{
			get
			{
				return this._DataGridView_Vista_Remotas;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_Vista_Remotas_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_Vista_Remotas_CellValidated);
				EventHandler eventHandler = new EventHandler(this.DataGridView_Vista_Remotas_CurrentCellDirtyStateChanged);
				if (this._DataGridView_Vista_Remotas != null)
				{
					this._DataGridView_Vista_Remotas.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_Vista_Remotas.CellValidated -= dataGridViewCellEventHandler;
					this._DataGridView_Vista_Remotas.CurrentCellDirtyStateChanged -= eventHandler;
				}
				this._DataGridView_Vista_Remotas = value;
				if (this._DataGridView_Vista_Remotas != null)
				{
					this._DataGridView_Vista_Remotas.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_Vista_Remotas.CellValidated += dataGridViewCellEventHandler;
					this._DataGridView_Vista_Remotas.CurrentCellDirtyStateChanged += eventHandler;
				}
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0026D40C File Offset: 0x0026B80C
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x0026D420 File Offset: 0x0026B820
		internal virtual Label Label40
		{
			get
			{
				return this._Label40;
			}
			[MethodImpl(32)]
			set
			{
				this._Label40 = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0026D42C File Offset: 0x0026B82C
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x0026D440 File Offset: 0x0026B840
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

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0026D44C File Offset: 0x0026B84C
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x0026D460 File Offset: 0x0026B860
		internal virtual Label Label41
		{
			get
			{
				return this._Label41;
			}
			[MethodImpl(32)]
			set
			{
				this._Label41 = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0026D46C File Offset: 0x0026B86C
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x0026D480 File Offset: 0x0026B880
		internal virtual DataGridViewTextBoxColumn RES_End_Comunicacao
		{
			get
			{
				return this._RES_End_Comunicacao;
			}
			[MethodImpl(32)]
			set
			{
				this._RES_End_Comunicacao = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0026D48C File Offset: 0x0026B88C
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x0026D4A0 File Offset: 0x0026B8A0
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

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0026D4AC File Offset: 0x0026B8AC
		// (set) Token: 0x060001DA RID: 474 RVA: 0x0026D4C0 File Offset: 0x0026B8C0
		internal virtual DataGridViewTextBoxColumn RES_Altura
		{
			get
			{
				return this._RES_Altura;
			}
			[MethodImpl(32)]
			set
			{
				this._RES_Altura = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0026D4CC File Offset: 0x0026B8CC
		// (set) Token: 0x060001DC RID: 476 RVA: 0x0026D4E0 File Offset: 0x0026B8E0
		internal virtual DataGridViewTextBoxColumn RES_Prioridade
		{
			get
			{
				return this._RES_Prioridade;
			}
			[MethodImpl(32)]
			set
			{
				this._RES_Prioridade = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0026D4EC File Offset: 0x0026B8EC
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0026D500 File Offset: 0x0026B900
		internal virtual DataGridViewTextBoxColumn RES_Numero_Reservatorio
		{
			get
			{
				return this._RES_Numero_Reservatorio;
			}
			[MethodImpl(32)]
			set
			{
				this._RES_Numero_Reservatorio = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0026D50C File Offset: 0x0026B90C
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x0026D520 File Offset: 0x0026B920
		internal virtual DataGridViewTextBoxColumn Vista
		{
			get
			{
				return this._Vista;
			}
			[MethodImpl(32)]
			set
			{
				this._Vista = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0026D52C File Offset: 0x0026B92C
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x0026D540 File Offset: 0x0026B940
		internal virtual DataGridViewTextBoxColumn Endereco
		{
			get
			{
				return this._Endereco;
			}
			[MethodImpl(32)]
			set
			{
				this._Endereco = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0026D54C File Offset: 0x0026B94C
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x0026D560 File Offset: 0x0026B960
		internal virtual DataGridViewTextBoxColumn Qtd_Vista_Reservatorio
		{
			get
			{
				return this._Qtd_Vista_Reservatorio;
			}
			[MethodImpl(32)]
			set
			{
				this._Qtd_Vista_Reservatorio = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0026D56C File Offset: 0x0026B96C
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x0026D580 File Offset: 0x0026B980
		internal virtual DataGridViewTextBoxColumn Qtd_Vista_Recalque
		{
			get
			{
				return this._Qtd_Vista_Recalque;
			}
			[MethodImpl(32)]
			set
			{
				this._Qtd_Vista_Recalque = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0026D58C File Offset: 0x0026B98C
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x0026D5A0 File Offset: 0x0026B9A0
		internal virtual DataGridViewTextBoxColumn Qtd_Vista_Prioridade
		{
			get
			{
				return this._Qtd_Vista_Prioridade;
			}
			[MethodImpl(32)]
			set
			{
				this._Qtd_Vista_Prioridade = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0026D5AC File Offset: 0x0026B9AC
		// (set) Token: 0x060001EA RID: 490 RVA: 0x0026D5C0 File Offset: 0x0026B9C0
		internal virtual DataGridViewTextBoxColumn REC_End_Comunicacao
		{
			get
			{
				return this._REC_End_Comunicacao;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_End_Comunicacao = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0026D5CC File Offset: 0x0026B9CC
		// (set) Token: 0x060001EC RID: 492 RVA: 0x0026D5E0 File Offset: 0x0026B9E0
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

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0026D5EC File Offset: 0x0026B9EC
		// (set) Token: 0x060001EE RID: 494 RVA: 0x0026D600 File Offset: 0x0026BA00
		internal virtual DataGridViewTextBoxColumn REC_Res_Origem
		{
			get
			{
				return this._REC_Res_Origem;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Res_Origem = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0026D60C File Offset: 0x0026BA0C
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x0026D620 File Offset: 0x0026BA20
		internal virtual DataGridViewTextBoxColumn REC_Res_Destino
		{
			get
			{
				return this._REC_Res_Destino;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Res_Destino = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0026D62C File Offset: 0x0026BA2C
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x0026D640 File Offset: 0x0026BA40
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

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0026D64C File Offset: 0x0026BA4C
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x0026D660 File Offset: 0x0026BA60
		internal virtual DataGridViewTextBoxColumn REC_Prioridade
		{
			get
			{
				return this._REC_Prioridade;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Prioridade = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0026D66C File Offset: 0x0026BA6C
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x0026D680 File Offset: 0x0026BA80
		internal virtual DataGridViewTextBoxColumn REC_Reservatorio1
		{
			get
			{
				return this._REC_Reservatorio1;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Reservatorio1 = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0026D68C File Offset: 0x0026BA8C
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x0026D6A0 File Offset: 0x0026BAA0
		internal virtual DataGridViewTextBoxColumn REC_Reservatorio2
		{
			get
			{
				return this._REC_Reservatorio2;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Reservatorio2 = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0026D6AC File Offset: 0x0026BAAC
		// (set) Token: 0x060001FA RID: 506 RVA: 0x0026D6C0 File Offset: 0x0026BAC0
		internal virtual DataGridViewTextBoxColumn REC_Reservatorio3
		{
			get
			{
				return this._REC_Reservatorio3;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Reservatorio3 = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0026D6CC File Offset: 0x0026BACC
		// (set) Token: 0x060001FC RID: 508 RVA: 0x0026D6E0 File Offset: 0x0026BAE0
		internal virtual DataGridViewTextBoxColumn REC_Reservatorio4
		{
			get
			{
				return this._REC_Reservatorio4;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_Reservatorio4 = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0026D6EC File Offset: 0x0026BAEC
		// (set) Token: 0x060001FE RID: 510 RVA: 0x0026D700 File Offset: 0x0026BB00
		internal virtual DataGridViewTextBoxColumn REC_NomeRes1
		{
			get
			{
				return this._REC_NomeRes1;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_NomeRes1 = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0026D70C File Offset: 0x0026BB0C
		// (set) Token: 0x06000200 RID: 512 RVA: 0x0026D720 File Offset: 0x0026BB20
		internal virtual DataGridViewTextBoxColumn REC_NomeRes2
		{
			get
			{
				return this._REC_NomeRes2;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_NomeRes2 = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0026D72C File Offset: 0x0026BB2C
		// (set) Token: 0x06000202 RID: 514 RVA: 0x0026D740 File Offset: 0x0026BB40
		internal virtual DataGridViewTextBoxColumn REC_NomeRes3
		{
			get
			{
				return this._REC_NomeRes3;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_NomeRes3 = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0026D74C File Offset: 0x0026BB4C
		// (set) Token: 0x06000204 RID: 516 RVA: 0x0026D760 File Offset: 0x0026BB60
		internal virtual DataGridViewTextBoxColumn REC_NomeRes4
		{
			get
			{
				return this._REC_NomeRes4;
			}
			[MethodImpl(32)]
			set
			{
				this._REC_NomeRes4 = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0026D76C File Offset: 0x0026BB6C
		// (set) Token: 0x06000206 RID: 518 RVA: 0x0026D780 File Offset: 0x0026BB80
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

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0026D78C File Offset: 0x0026BB8C
		// (set) Token: 0x06000208 RID: 520 RVA: 0x0026D7A0 File Offset: 0x0026BBA0
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

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0026D7AC File Offset: 0x0026BBAC
		// (set) Token: 0x0600020A RID: 522 RVA: 0x0026D7C0 File Offset: 0x0026BBC0
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

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0026D7CC File Offset: 0x0026BBCC
		// (set) Token: 0x0600020C RID: 524 RVA: 0x0026D7E0 File Offset: 0x0026BBE0
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

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0026D7EC File Offset: 0x0026BBEC
		// (set) Token: 0x0600020E RID: 526 RVA: 0x0026D800 File Offset: 0x0026BC00
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

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0026D80C File Offset: 0x0026BC0C
		// (set) Token: 0x06000210 RID: 528 RVA: 0x0026D820 File Offset: 0x0026BC20
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

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0026D82C File Offset: 0x0026BC2C
		// (set) Token: 0x06000212 RID: 530 RVA: 0x0026D840 File Offset: 0x0026BC40
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

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0026D84C File Offset: 0x0026BC4C
		// (set) Token: 0x06000214 RID: 532 RVA: 0x0026D860 File Offset: 0x0026BC60
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

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0026D86C File Offset: 0x0026BC6C
		// (set) Token: 0x06000216 RID: 534 RVA: 0x0026D880 File Offset: 0x0026BC80
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0026D88C File Offset: 0x0026BC8C
		// (set) Token: 0x06000218 RID: 536 RVA: 0x0026D8A0 File Offset: 0x0026BCA0
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0026D8AC File Offset: 0x0026BCAC
		// (set) Token: 0x0600021A RID: 538 RVA: 0x0026D8C0 File Offset: 0x0026BCC0
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

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0026D8CC File Offset: 0x0026BCCC
		// (set) Token: 0x0600021C RID: 540 RVA: 0x0026D8E0 File Offset: 0x0026BCE0
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

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0026D8EC File Offset: 0x0026BCEC
		// (set) Token: 0x0600021E RID: 542 RVA: 0x0026D900 File Offset: 0x0026BD00
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

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0026D90C File Offset: 0x0026BD0C
		// (set) Token: 0x06000220 RID: 544 RVA: 0x0026D920 File Offset: 0x0026BD20
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

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0026D92C File Offset: 0x0026BD2C
		// (set) Token: 0x06000222 RID: 546 RVA: 0x0026D940 File Offset: 0x0026BD40
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

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0026D94C File Offset: 0x0026BD4C
		// (set) Token: 0x06000224 RID: 548 RVA: 0x0026D960 File Offset: 0x0026BD60
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

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0026D96C File Offset: 0x0026BD6C
		// (set) Token: 0x06000226 RID: 550 RVA: 0x0026D980 File Offset: 0x0026BD80
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

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0026D98C File Offset: 0x0026BD8C
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0026D9A0 File Offset: 0x0026BDA0
		internal virtual DataGridViewTextBoxColumn VC_Vista
		{
			get
			{
				return this._VC_Vista;
			}
			[MethodImpl(32)]
			set
			{
				this._VC_Vista = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0026D9AC File Offset: 0x0026BDAC
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0026D9C0 File Offset: 0x0026BDC0
		internal virtual DataGridViewTextBoxColumn VC_Endereco
		{
			get
			{
				return this._VC_Endereco;
			}
			[MethodImpl(32)]
			set
			{
				this._VC_Endereco = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0026D9CC File Offset: 0x0026BDCC
		// (set) Token: 0x0600022C RID: 556 RVA: 0x0026D9E0 File Offset: 0x0026BDE0
		internal virtual DataGridViewTextBoxColumn VR_Vista
		{
			get
			{
				return this._VR_Vista;
			}
			[MethodImpl(32)]
			set
			{
				this._VR_Vista = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0026D9EC File Offset: 0x0026BDEC
		// (set) Token: 0x0600022E RID: 558 RVA: 0x0026DA00 File Offset: 0x0026BE00
		internal virtual DataGridViewTextBoxColumn VR_End
		{
			get
			{
				return this._VR_End;
			}
			[MethodImpl(32)]
			set
			{
				this._VR_End = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0026DA0C File Offset: 0x0026BE0C
		// (set) Token: 0x06000230 RID: 560 RVA: 0x0026DA20 File Offset: 0x0026BE20
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

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0026DA2C File Offset: 0x0026BE2C
		// (set) Token: 0x06000232 RID: 562 RVA: 0x0026DA40 File Offset: 0x0026BE40
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

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0026DA4C File Offset: 0x0026BE4C
		// (set) Token: 0x06000234 RID: 564 RVA: 0x0026DA60 File Offset: 0x0026BE60
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

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0026DA6C File Offset: 0x0026BE6C
		// (set) Token: 0x06000236 RID: 566 RVA: 0x0026DA80 File Offset: 0x0026BE80
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

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0026DA8C File Offset: 0x0026BE8C
		// (set) Token: 0x06000238 RID: 568 RVA: 0x0026DAA0 File Offset: 0x0026BEA0
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

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0026DAAC File Offset: 0x0026BEAC
		// (set) Token: 0x0600023A RID: 570 RVA: 0x0026DAC0 File Offset: 0x0026BEC0
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

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0026DACC File Offset: 0x0026BECC
		// (set) Token: 0x0600023C RID: 572 RVA: 0x0026DAE0 File Offset: 0x0026BEE0
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

		// Token: 0x0600023D RID: 573 RVA: 0x0026DAEC File Offset: 0x0026BEEC
		private void RT_850_conf_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0026DAF0 File Offset: 0x0026BEF0
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

		// Token: 0x0600023F RID: 575 RVA: 0x0026DB6C File Offset: 0x0026BF6C
		private void RT_850_conf_Load(object sender, EventArgs e)
		{
			RT_geral.Lmte_Init_ok = false;
			RT_830_200_redimX.RT_830_200_redim();
			RT_830_200_inicializa_variavies_X.RT_830_200_inicializa_variaveis();
			this.AtualizaTodosNUD();
			this.AtualizaTodosCOMBOBOX();
			RT_830_200_valores_default_X.RT_830_200_valores_default();
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
			this.TabPage_Reservatorio.BackColor = Color.FromKnownColor(8);
			this.TabPage_Reservatorio.ForeColor = Color.FromKnownColor(10);
			this.TabPage_Recalque.BackColor = Color.FromKnownColor(8);
			this.TabPage_Recalque.ForeColor = Color.FromKnownColor(10);
			this.TabPage_Vista.BackColor = Color.FromKnownColor(8);
			this.TabPage_Vista.ForeColor = Color.FromKnownColor(10);
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
			RT_830_200_variaveis_X.RT_830_200_BD.firmware.Equip.Valor = (HorizontalAlignment)830;
			RT_830_200_variaveis_X.RT_830_200_BD.firmware.Versao.Valor = (HorizontalAlignment)2;
			this.ToolStripLabel1.Text = RT_geral.MontaNomePlacaPeloFabricante(RT_830_200_variaveis_X.RT_830_200_BD.firmware.Equip.Valor, RT_830_200_variaveis_X.RT_830_200_BD.firmware.Versao.Valor);
			RT_geral.RT_850_Controle.LiberaEventos_Variaveis = true;
			RT_geral.Lmte_Init_ok = true;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0026DDD8 File Offset: 0x0026C1D8
		private void RT_850_conf_Activated(object sender, EventArgs e)
		{
			Geral.Equipamento_selecionado = (HorizontalAlignment)830;
			Geral.Equipamento_versao = (HorizontalAlignment)2;
			Geral.Equipamento_build = (HorizontalAlignment)0;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0026DDF0 File Offset: 0x0026C1F0
		private void GeraDataGridView_Equip_Canal_1()
		{
			int num = (HorizontalAlignment)0;
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

		// Token: 0x06000242 RID: 578 RVA: 0x0026DE40 File Offset: 0x0026C240
		private void InicializaEstrutura_DataGridView_Equip_Canal_1()
		{
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[0].TagColuna = "Quant";
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[1].TagColuna = "End Inicial";
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[0].NomeColuna = "Quantidade";
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[1].NomeColuna = "Endereco";
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[0].LarguraColuna = Conversions.ToInteger("60");
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[1].LarguraColuna = Conversions.ToInteger("90");
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[0].AlingColuna = (HorizontalAlignment)32;
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[1].AlingColuna = (HorizontalAlignment)32;
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[0].NumeroLinhaMenu = (HorizontalAlignment)0;
			RT_geral.RT_850_DataGrigViewEquipCanal_1Colunas[1].NumeroLinhaMenu = (HorizontalAlignment)0;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0026DF1C File Offset: 0x0026C31C
		private void Atualiza_canais_comunicacao()
		{
			this.NumericUpDown_end_1_RT850.Value = new decimal(RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor);
			this.ComboBox_baudrate_RT850.SelectedIndex = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.Indice;
			this.NumericUpDown_intervalo_leitura_1_RT850.Value = new decimal(RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.intervalo_polling.Valor);
			this.NumericUpDown_timeout_1_RT850.Value = new decimal(RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.timeout.Valor);
			this.NumericUpDown_temp_ptt_1_RT850.Value = new decimal(RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.PTT.Valor);
			this.NumericUpDown_num_tentativas_1_RT850.Value = new decimal(RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.retrys.Valor);
			this.NumericUpDown_num_erro_falha_1_RT850.Value = new decimal(RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.erros_falha.Valor);
			this.nud_numero_reservatorios.Value = new decimal(RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_reservatorios.Valor);
			this.nud_numero_equipamentos_reservatorios.Value = new decimal(RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios.Valor);
			this.nud_numero_equipamentos_recalque.Value = new decimal(RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques.Valor);
			this.nud_numero_equipamentos_vista.Value = new decimal(RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor);
			this.nud_end_inicial_reservatorio.Value = new decimal(RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_reservatorio.Valor);
			this.nud_end_inicial_recalque.Value = new decimal(RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_recalque.Valor);
			this.nud_end_inicial_vista.Value = new decimal(RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista.Valor);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0026E11C File Offset: 0x0026C51C
		private void Atualiza_Reservatorios()
		{
			int num = (HorizontalAlignment)20;
			DataGridView dataGridView_Reservatorios = this.DataGridView_Reservatorios;
			dataGridView_Reservatorios.AllowDrop = false;
			dataGridView_Reservatorios.AllowUserToAddRows = false;
			dataGridView_Reservatorios.AllowUserToDeleteRows = false;
			dataGridView_Reservatorios.AllowUserToOrderColumns = false;
			dataGridView_Reservatorios.AllowUserToResizeColumns = false;
			dataGridView_Reservatorios.AllowUserToResizeRows = false;
			checked
			{
				int num2 = dataGridView_Reservatorios.ColumnHeadersHeight + 1;
				int num3 = (HorizontalAlignment)0;
				int num4 = (HorizontalAlignment)0;
				int num5 = dataGridView_Reservatorios.ColumnCount - 1;
				for (int i = num4; i <= num5; i++)
				{
					num3 += dataGridView_Reservatorios.Columns[i].Width;
				}
				int j = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios.Valor;
				int num6 = (HorizontalAlignment)20;
				if (j == (DialogResult)0)
				{
					dataGridView_Reservatorios.Height = num2;
					dataGridView_Reservatorios.Width = num3;
					dataGridView_Reservatorios.ScrollBars = (HorizontalAlignment)0;
				}
				else if (j >= 1 & j <= num6)
				{
					int height = dataGridView_Reservatorios.Rows[0].Height;
					dataGridView_Reservatorios.Height = num2 + j * height;
					dataGridView_Reservatorios.Width = num3;
					dataGridView_Reservatorios.ScrollBars = (HorizontalAlignment)0;
				}
				else
				{
					int height = dataGridView_Reservatorios.Rows[0].Height;
					dataGridView_Reservatorios.Height = num2 + (num6 - 1) * height;
					dataGridView_Reservatorios.Width = num3 + num;
					dataGridView_Reservatorios.ScrollBars = (HorizontalAlignment)2;
				}
				int num7 = (HorizontalAlignment)0;
				int num8 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios.Valor - 1;
				for (j = num7; j <= num8; j++)
				{
					string value = string.Format("{0}", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_reservatorio.Valor + j);
					this.DataGridView_Reservatorios.Rows[j].Cells[0].Value = value;
					this.DataGridView_Reservatorios.Rows[j].Cells[1].Value = RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[j].Nome.Valor.ToString();
					this.DataGridView_Reservatorios.Rows[j].Cells[2].Value = RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[j].Altura.Valor.ToString();
					this.DataGridView_Reservatorios.Rows[j].Cells[3].Value = RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[j].Prioridade.Valor.ToString();
					this.DataGridView_Reservatorios.Rows[j].Cells[4].Value = RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[j].NumeroVariavel.Valor.ToString();
				}
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0026E3C8 File Offset: 0x0026C7C8
		private void Atualiza_Recalques()
		{
			int num = (HorizontalAlignment)18;
			DataGridView dataGridView_Recalques = this.DataGridView_Recalques;
			dataGridView_Recalques.AllowDrop = false;
			dataGridView_Recalques.AllowUserToAddRows = false;
			dataGridView_Recalques.AllowUserToDeleteRows = false;
			dataGridView_Recalques.AllowUserToOrderColumns = false;
			dataGridView_Recalques.AllowUserToResizeColumns = false;
			dataGridView_Recalques.AllowUserToResizeRows = false;
			checked
			{
				int num2 = dataGridView_Recalques.ColumnHeadersHeight + 1;
				int num3 = (HorizontalAlignment)0;
				int num4 = (HorizontalAlignment)0;
				int num5 = dataGridView_Recalques.ColumnCount - 1;
				for (int i = num4; i <= num5; i++)
				{
					num3 += dataGridView_Recalques.Columns[i].Width;
				}
				int j = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques.Valor;
				int num6 = (HorizontalAlignment)20;
				if (j == (DialogResult)0)
				{
					dataGridView_Recalques.Height = num2 + num;
					dataGridView_Recalques.Width = (HorizontalAlignment)1212;
					dataGridView_Recalques.ScrollBars = (HorizontalAlignment)1;
				}
				else if (j >= 1 & j <= num6)
				{
					int height = dataGridView_Recalques.Rows[0].Height;
					dataGridView_Recalques.Height = num2 + j * height + num;
					dataGridView_Recalques.Width = (HorizontalAlignment)1212;
					dataGridView_Recalques.ScrollBars = (HorizontalAlignment)1;
				}
				else
				{
					int height = dataGridView_Recalques.Rows[0].Height;
					dataGridView_Recalques.Height = num2 + num6 * height + num;
					dataGridView_Recalques.Width = (HorizontalAlignment)1212;
					dataGridView_Recalques.ScrollBars = (HorizontalAlignment)3;
				}
				int num7 = (HorizontalAlignment)0;
				int num8 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques.Valor - 1;
				for (j = num7; j <= num8; j++)
				{
					string value = string.Format("{0}", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_recalque.Valor + j);
					this.DataGridView_Recalques.Rows[j].Cells[0].Value = value;
					this.DataGridView_Recalques.Rows[j].Cells[1].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Nome.Valor.ToString();
					value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].origem.Valor.ToString();
					this.DataGridView_Recalques.Rows[j].Cells[2].Value = value;
					value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].destino.Valor.ToString();
					this.DataGridView_Recalques.Rows[j].Cells[3].Value = value;
					DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.DataGridView_Recalques.Rows[j].Cells[4];
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Modelo.AtualizaIndicePeloValor();
					dataGridViewComboBoxCell.Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Modelo.itens[RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Modelo.Indice];
					this.DataGridView_Recalques.Rows[j].Cells[5].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Prioridade.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[6].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Var1.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[7].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Var2.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[8].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Var3.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[9].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Var4.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[10].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Nome_Var1.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[11].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Nome_Var2.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[12].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Nome_Var3.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[13].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Nome_Var4.Valor;
					dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.DataGridView_Recalques.Rows[j].Cells[14];
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Habilita.AtualizaIndicePeloValor();
					dataGridViewComboBoxCell.Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Habilita.itens[RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Habilita.Indice];
					this.DataGridView_Recalques.Rows[j].Cells[15].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Escala1.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[16].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Escala2.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[17].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Escala3.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[18].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Escala4.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[19].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Escala5.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[20].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Escala6.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[21].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Escala7.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[22].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Escala8.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[23].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Escala9.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[24].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Escala10.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[25].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Escala11.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[26].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Escala12.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[27].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Escala13.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[28].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Escala14.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[29].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Escala15.Valor;
					this.DataGridView_Recalques.Rows[j].Cells[30].Value = RT_830_200_variaveis_X.RT_830_200_BD.recalque[j].Escala16.Valor;
				}
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0026EDE0 File Offset: 0x0026D1E0
		public void Atualiza_Vista()
		{
			this.Atualiza_Vista_Quantidade_Equipamentos();
			this.Atualiza_Vista_Lista_Variaveis();
			this.Atualiza_Vista_Lista_Remotas();
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0026EDF4 File Offset: 0x0026D1F4
		public void Atualiza_Vista_Quantidade_Equipamentos()
		{
			DataGridView dataGridView_Qtd_Vista = this.DataGridView_Qtd_Vista;
			dataGridView_Qtd_Vista.AllowDrop = false;
			dataGridView_Qtd_Vista.AllowUserToAddRows = false;
			dataGridView_Qtd_Vista.AllowUserToDeleteRows = false;
			dataGridView_Qtd_Vista.AllowUserToOrderColumns = false;
			dataGridView_Qtd_Vista.AllowUserToResizeColumns = false;
			dataGridView_Qtd_Vista.AllowUserToResizeRows = false;
			checked
			{
				int num = dataGridView_Qtd_Vista.ColumnHeadersHeight + 1;
				int num2 = (HorizontalAlignment)0;
				int num3 = (HorizontalAlignment)0;
				int num4 = dataGridView_Qtd_Vista.ColumnCount - 1;
				for (int i = num3; i <= num4; i++)
				{
					num2 += dataGridView_Qtd_Vista.Columns[i].Width;
				}
				int valor = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor;
				int num5 = (HorizontalAlignment)5;
				if (valor == (DialogResult)0)
				{
					dataGridView_Qtd_Vista.Height = num;
					dataGridView_Qtd_Vista.Width = num2;
					dataGridView_Qtd_Vista.ScrollBars = (HorizontalAlignment)0;
				}
				else if (valor >= 1 & valor <= num5)
				{
					int height = dataGridView_Qtd_Vista.Rows[0].Height;
					this.DataGridView_Qtd_Vista.Height = num + valor * height;
					this.DataGridView_Qtd_Vista.Width = num2;
				}
				else
				{
					int height = dataGridView_Qtd_Vista.Rows[0].Height;
					this.DataGridView_Qtd_Vista.Height = num + num5 * height;
					this.DataGridView_Qtd_Vista.Width = (HorizontalAlignment)381;
				}
				int num6 = (HorizontalAlignment)0;
				int num7 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor - 1;
				for (int j = num6; j <= num7; j++)
				{
					this.DataGridView_Qtd_Vista.Rows[j].Cells[0].Value = Conversion.Str(j + 1);
					this.DataGridView_Qtd_Vista.Rows[j].Cells[1].Value = Conversion.Str(RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista.Valor + j);
					this.DataGridView_Qtd_Vista.Rows[j].Cells[2].Value = RT_830_200_variaveis_X.RT_830_200_BD.vista[j].Numero_Variaveis.Valor.ToString();
					this.DataGridView_Qtd_Vista.Rows[j].Cells[3].Value = RT_830_200_variaveis_X.RT_830_200_BD.vista[j].Numero_RemotasControles.Valor.ToString();
					this.DataGridView_Qtd_Vista.Rows[j].Cells[4].Value = RT_830_200_variaveis_X.RT_830_200_BD.vista[j].Prioridade.Valor.ToString();
				}
				int num8 = (HorizontalAlignment)0;
				int num9 = (HorizontalAlignment)0;
				int num10 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor - 1;
				for (int j = num9; j <= num10; j++)
				{
					if (num8 < RT_830_200_variaveis_X.RT_830_200_BD.vista[j].Numero_Variaveis.Valor)
					{
						num8 = RT_830_200_variaveis_X.RT_830_200_BD.vista[j].Numero_Variaveis.Valor;
					}
				}
				this.DataGridView_Vista_Variaveis.ColumnCount = num8 + 2;
				num8 = (HorizontalAlignment)0;
				int num11 = (HorizontalAlignment)0;
				int num12 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor - 1;
				for (int j = num11; j <= num12; j++)
				{
					if (num8 < RT_830_200_variaveis_X.RT_830_200_BD.vista[j].Numero_RemotasControles.Valor)
					{
						num8 = RT_830_200_variaveis_X.RT_830_200_BD.vista[j].Numero_RemotasControles.Valor;
					}
				}
				this.DataGridView_Vista_Remotas.ColumnCount = num8 + 2;
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0026F16C File Offset: 0x0026D56C
		public void Atualiza_Vista_Lista_Variaveis()
		{
			DataGridView dataGridView_Vista_Variaveis = this.DataGridView_Vista_Variaveis;
			int valor = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor;
			int num = (HorizontalAlignment)5;
			int columnHeadersHeight = dataGridView_Vista_Variaveis.ColumnHeadersHeight;
			int num2 = (HorizontalAlignment)0;
			int num3 = (HorizontalAlignment)0;
			checked
			{
				int num4 = dataGridView_Vista_Variaveis.ColumnCount - 1;
				for (int i = num3; i <= num4; i++)
				{
					num2 += dataGridView_Vista_Variaveis.Columns[i].Width;
				}
				if (valor == (DialogResult)0)
				{
					dataGridView_Vista_Variaveis.Height = columnHeadersHeight;
					if (num2 > 1212)
					{
						dataGridView_Vista_Variaveis.Width = (HorizontalAlignment)1212;
					}
					else
					{
						dataGridView_Vista_Variaveis.Width = num2;
					}
				}
				else if (valor >= 1 & valor <= num)
				{
					int height = dataGridView_Vista_Variaveis.Rows[0].Height;
					dataGridView_Vista_Variaveis.Height = columnHeadersHeight + valor * height;
					if (num2 > 1212)
					{
						dataGridView_Vista_Variaveis.Width = (HorizontalAlignment)1212;
						dataGridView_Vista_Variaveis.Height += (HorizontalAlignment)16;
						dataGridView_Vista_Variaveis.ScrollBars = (HorizontalAlignment)1;
					}
					else
					{
						dataGridView_Vista_Variaveis.Width = num2;
						dataGridView_Vista_Variaveis.ScrollBars = (HorizontalAlignment)0;
					}
				}
				else
				{
					dataGridView_Vista_Variaveis.Height = columnHeadersHeight + num * this.DataGridView_Vista_Variaveis.RowTemplate.Height + 40;
					dataGridView_Vista_Variaveis.Width = (HorizontalAlignment)1212;
				}
				int num5 = (HorizontalAlignment)0;
				int num6 = (HorizontalAlignment)0;
				int num7 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor - 1;
				for (int j = num6; j <= num7; j++)
				{
					if (num5 < RT_830_200_variaveis_X.RT_830_200_BD.vista[j].Numero_Variaveis.Valor)
					{
						num5 = RT_830_200_variaveis_X.RT_830_200_BD.vista[j].Numero_Variaveis.Valor;
					}
				}
				int num8 = (HorizontalAlignment)2;
				int num9 = num5 + 2 - 1;
				for (int j = num8; j <= num9; j++)
				{
					this.DataGridView_Vista_Variaveis.Columns[j].HeaderText = "Var" + Conversion.Str(j - 1);
				}
				int num10 = (HorizontalAlignment)0;
				int num11 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor - 1;
				for (int j = num10; j <= num11; j++)
				{
					this.DataGridView_Vista_Variaveis.Rows[j].Cells[0].Value = Conversion.Str(j + 1);
					this.DataGridView_Vista_Variaveis.Rows[j].Cells[1].Value = Conversion.Str(RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista.Valor + j);
					int num12 = RT_830_200_variaveis_X.RT_830_200_BD.vista[j].Numero_Variaveis.Valor + 2;
					int num13 = (HorizontalAlignment)2;
					int num14 = num5 + 2 - 1;
					for (int k = num13; k <= num14; k++)
					{
						if (k < num12)
						{
							this.DataGridView_Vista_Variaveis.Rows[j].Cells[k].Value = RT_830_200_variaveis_X.RT_830_200_BD.vista[j].Variaveis[k - 2].Valor.ToString();
							this.DataGridView_Vista_Variaveis.Rows[j].Cells[k].ReadOnly = false;
						}
						else
						{
							this.DataGridView_Vista_Variaveis.Rows[j].Cells[k].Value = "";
							this.DataGridView_Vista_Variaveis.Rows[j].Cells[k].ReadOnly = true;
						}
					}
				}
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0026F4E8 File Offset: 0x0026D8E8
		public void Atualiza_Vista_Lista_Remotas()
		{
			DataGridView dataGridView_Vista_Remotas = this.DataGridView_Vista_Remotas;
			int valor = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor;
			int num = (HorizontalAlignment)5;
			int columnHeadersHeight = dataGridView_Vista_Remotas.ColumnHeadersHeight;
			int num2 = (HorizontalAlignment)0;
			int num3 = (HorizontalAlignment)0;
			checked
			{
				int num4 = dataGridView_Vista_Remotas.ColumnCount - 1;
				for (int i = num3; i <= num4; i++)
				{
					num2 += dataGridView_Vista_Remotas.Columns[i].Width;
				}
				if (valor == (DialogResult)0)
				{
					dataGridView_Vista_Remotas.Height = columnHeadersHeight;
					if (num2 > 1212)
					{
						dataGridView_Vista_Remotas.Width = (HorizontalAlignment)1212;
					}
					else
					{
						dataGridView_Vista_Remotas.Width = num2;
					}
				}
				else if (valor >= 1 & valor <= num)
				{
					int height = dataGridView_Vista_Remotas.Rows[0].Height;
					dataGridView_Vista_Remotas.Height = columnHeadersHeight + valor * height;
					if (num2 > 1212)
					{
						dataGridView_Vista_Remotas.Width = (HorizontalAlignment)1212;
						dataGridView_Vista_Remotas.Height += (HorizontalAlignment)16;
						dataGridView_Vista_Remotas.ScrollBars = (HorizontalAlignment)1;
					}
					else
					{
						dataGridView_Vista_Remotas.Width = num2;
						dataGridView_Vista_Remotas.ScrollBars = (HorizontalAlignment)0;
					}
				}
				else
				{
					dataGridView_Vista_Remotas.Height = columnHeadersHeight + num * this.DataGridView_Vista_Variaveis.RowTemplate.Height + 40;
					dataGridView_Vista_Remotas.Width = (HorizontalAlignment)1212;
				}
				int num5 = (HorizontalAlignment)0;
				int num6 = (HorizontalAlignment)0;
				int num7 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor - 1;
				for (int j = num6; j <= num7; j++)
				{
					if (num5 < RT_830_200_variaveis_X.RT_830_200_BD.vista[j].Numero_RemotasControles.Valor)
					{
						num5 = RT_830_200_variaveis_X.RT_830_200_BD.vista[j].Numero_RemotasControles.Valor;
					}
				}
				int num8 = (HorizontalAlignment)2;
				int num9 = num5 + 2 - 1;
				for (int j = num8; j <= num9; j++)
				{
					this.DataGridView_Vista_Remotas.Columns[j].HeaderText = "R.Ctrl" + Conversion.Str(j - 1);
				}
				int num10 = (HorizontalAlignment)0;
				int num11 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor - 1;
				for (int j = num10; j <= num11; j++)
				{
					this.DataGridView_Vista_Remotas.Rows[j].Cells[0].Value = Conversion.Str(j + 1);
					this.DataGridView_Vista_Remotas.Rows[j].Cells[1].Value = Conversion.Str(RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista.Valor + j);
					int num12 = RT_830_200_variaveis_X.RT_830_200_BD.vista[j].Numero_RemotasControles.Valor + 2;
					int num13 = (HorizontalAlignment)2;
					int num14 = num5 + 2 - 1;
					for (int k = num13; k <= num14; k++)
					{
						if (k < num12)
						{
							this.DataGridView_Vista_Remotas.Rows[j].Cells[k].Value = RT_830_200_variaveis_X.RT_830_200_BD.vista[j].RemotasControles[k - 2].Valor.ToString();
							this.DataGridView_Vista_Remotas.Rows[j].Cells[k].ReadOnly = false;
						}
						else
						{
							this.DataGridView_Vista_Remotas.Rows[j].Cells[k].Value = "";
							this.DataGridView_Vista_Remotas.Rows[j].Cells[k].ReadOnly = true;
						}
					}
				}
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0026F864 File Offset: 0x0026DC64
		private void Inicializa_Estrutura_Lista_Equipamentos_Recalque()
		{
			Linha_RT.CreateComboBoxColumn3(RT_830_200_variaveis_X.RT_830_200_BD.recalque[0].Modelo, (DataGridViewComboBoxColumn)this.DataGridView_Recalques.Columns[4]);
			Linha_RT.CreateComboBoxColumn3(RT_830_200_variaveis_X.RT_830_200_BD.recalque[0].Habilita, (DataGridViewComboBoxColumn)this.DataGridView_Recalques.Columns[14]);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0026F8D4 File Offset: 0x0026DCD4
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
			int num = (HorizontalAlignment)0;
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
				RT_geral.RT_850_DataGridView_variaveis[4].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_variaveis[4].LinhasValor[1] = (HorizontalAlignment)1;
				RT_geral.RT_850_DataGridView_variaveis[4].LinhasValor[2] = (HorizontalAlignment)2;
				RT_geral.RT_850_DataGridView_variaveis[4].LinhasValor[3] = (HorizontalAlignment)3;
				RT_geral.RT_850_DataGridView_variaveis[4].LinhasMenu[0] = "0";
				RT_geral.RT_850_DataGridView_variaveis[4].LinhasMenu[1] = "0,0";
				RT_geral.RT_850_DataGridView_variaveis[4].LinhasMenu[2] = "0,00";
				RT_geral.RT_850_DataGridView_variaveis[4].LinhasMenu[3] = "0,000";
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasValor[1] = (HorizontalAlignment)1;
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasValor[2] = (HorizontalAlignment)2;
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasValor[3] = (HorizontalAlignment)3;
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasValor[4] = (HorizontalAlignment)4;
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasMenu[0] = "-------";
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasMenu[1] = "Linha 1";
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasMenu[2] = "Linha 2";
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasMenu[3] = "Linha 3";
				RT_geral.RT_850_DataGridView_variaveis[12].LinhasMenu[4] = "Linha 4";
				RT_geral.RT_850_DataGridView_variaveis[6].LinhasMenu[0] = "Baixo";
				RT_geral.RT_850_DataGridView_variaveis[6].LinhasMenu[1] = "Alto";
				RT_geral.RT_850_DataGridView_variaveis[6].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_variaveis[6].LinhasValor[1] = (HorizontalAlignment)1;
				RT_geral.RT_850_DataGridView_variaveis[9].LinhasMenu[0] = "Baixo";
				RT_geral.RT_850_DataGridView_variaveis[9].LinhasMenu[1] = "Alto";
				RT_geral.RT_850_DataGridView_variaveis[9].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_variaveis[9].LinhasValor[1] = (HorizontalAlignment)1;
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
				RT_geral.RT_850_DataGridView_variaveis[0].AlingColuna = (HorizontalAlignment)256;
				RT_geral.RT_850_DataGridView_variaveis[1].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_variaveis[2].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_variaveis[4].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_variaveis[5].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_variaveis[6].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_variaveis[7].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_variaveis[8].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_variaveis[9].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_variaveis[10].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_variaveis[11].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_variaveis[12].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_variaveis[0].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_variaveis[1].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_variaveis[2].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_variaveis[4].NumeroLinhaMenu = (HorizontalAlignment)4;
				RT_geral.RT_850_DataGridView_variaveis[5].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_variaveis[6].NumeroLinhaMenu = (HorizontalAlignment)2;
				RT_geral.RT_850_DataGridView_variaveis[7].NumeroLinhaMenu = (HorizontalAlignment)6;
				RT_geral.RT_850_DataGridView_variaveis[8].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_variaveis[9].NumeroLinhaMenu = (HorizontalAlignment)2;
				RT_geral.RT_850_DataGridView_variaveis[10].NumeroLinhaMenu = (HorizontalAlignment)6;
				RT_geral.RT_850_DataGridView_variaveis[11].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_variaveis[12].NumeroLinhaMenu = (HorizontalAlignment)5;
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00270170 File Offset: 0x0026E570
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
			RT_geral.RT_850_DataGridView_ctrl_4[1].LinhasValor[0] = (HorizontalAlignment)0;
			RT_geral.RT_850_DataGridView_ctrl_4[1].LinhasValor[1] = (HorizontalAlignment)1;
			RT_geral.RT_850_DataGridView_ctrl_4[1].LinhasMenu[0] = "Canal 1";
			RT_geral.RT_850_DataGridView_ctrl_4[1].LinhasMenu[1] = "Canal 2";
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor[0] = (HorizontalAlignment)0;
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor[1] = (HorizontalAlignment)1;
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor[2] = (HorizontalAlignment)2;
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor[3] = (HorizontalAlignment)3;
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor[4] = (HorizontalAlignment)4;
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor[5] = (HorizontalAlignment)5;
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor[6] = (HorizontalAlignment)6;
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasValor[7] = (HorizontalAlignment)7;
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[0] = "1";
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[1] = "2";
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[2] = "3";
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[3] = "4";
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[4] = "5";
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[5] = "6";
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[6] = "7";
			RT_geral.RT_850_DataGridView_ctrl_4[2].LinhasMenu[7] = "8";
			RT_geral.RT_850_DataGridView_ctrl_4[3].LinhasValor[0] = (HorizontalAlignment)0;
			RT_geral.RT_850_DataGridView_ctrl_4[3].LinhasValor[1] = (HorizontalAlignment)1;
			RT_geral.RT_850_DataGridView_ctrl_4[3].LinhasValor[2] = (HorizontalAlignment)2;
			RT_geral.RT_850_DataGridView_ctrl_4[3].LinhasMenu[0] = "Desabilitado";
			RT_geral.RT_850_DataGridView_ctrl_4[3].LinhasMenu[1] = "Liberado";
			RT_geral.RT_850_DataGridView_ctrl_4[3].LinhasMenu[2] = "Bloqueado";
			RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[0] = (HorizontalAlignment)0;
			RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[1] = (HorizontalAlignment)1;
			RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[2] = (HorizontalAlignment)2;
			RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[3] = (HorizontalAlignment)3;
			RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[4] = (HorizontalAlignment)6;
			RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[5] = (HorizontalAlignment)7;
			RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[6] = (HorizontalAlignment)8;
			RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[7] = (HorizontalAlignment)11;
			RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[8] = (HorizontalAlignment)12;
			RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[9] = (HorizontalAlignment)13;
			RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[10] = (HorizontalAlignment)14;
			RT_geral.RT_850_DataGridView_ctrl_4[5].LinhasValor[11] = (HorizontalAlignment)19;
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
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor[0] = (HorizontalAlignment)0;
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor[1] = (HorizontalAlignment)1;
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor[2] = (HorizontalAlignment)2;
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor[3] = (HorizontalAlignment)3;
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor[4] = (HorizontalAlignment)4;
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor[5] = (HorizontalAlignment)5;
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor[6] = (HorizontalAlignment)6;
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasValor[7] = (HorizontalAlignment)7;
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[0] = "Desabilitada";
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[1] = "1";
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[2] = "2";
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[3] = "3";
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[4] = "4";
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[5] = "5";
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[6] = "6";
			RT_geral.RT_850_DataGridView_ctrl_4[4].LinhasMenu[7] = "7";
			int i = (HorizontalAlignment)0;
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
				RT_geral.RT_850_DataGridView_ctrl_4[14].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_4[15].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_4[15].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_4[16].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_4[16].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_4[17].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_4[17].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_4[18].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_4[18].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_4[19].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_4[19].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_4[20].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_4[20].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_4[21].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_4[21].LinhasValor[0] = (HorizontalAlignment)0;
				i = (HorizontalAlignment)0;
				do
				{
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[0] = "Periférico Desabilitado";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[0] = (HorizontalAlignment)0;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[1] = "Medição Vazão - 1 canal";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[1] = (HorizontalAlignment)1;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[2] = "Medição Vazão - 2 canais";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[2] = (HorizontalAlignment)2;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[3] = "Medição Vazão - 3 canais";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[3] = (HorizontalAlignment)3;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[4] = "Medição Vazão - 4 canais";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[4] = (HorizontalAlignment)4;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[5] = "Medição Vazão - 5 canais";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[5] = (HorizontalAlignment)5;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[6] = "Medição Vazão - 6 canais";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[6] = (HorizontalAlignment)6;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[7] = "Medição Vazão - 7 canais";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[7] = (HorizontalAlignment)7;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[8] = "Medição Vazão - 8 canais";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[8] = (HorizontalAlignment)8;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[9] = "Reserva";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[9] = (HorizontalAlignment)9;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[10] = "Equipamento de Leitura Vazão";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[10] = (HorizontalAlignment)10;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[11] = "Multimedidor IMS mod: Smart Trans";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[11] = (HorizontalAlignment)11;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[12] = "Multimedidor KRON mod: Mult K-05";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[12] = (HorizontalAlignment)12;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[13] = "Inversor Danfoss VLT";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[13] = (HorizontalAlignment)13;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[14] = "Multimedidor SIEMENS PAC 3200";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[14] = (HorizontalAlignment)14;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[15] = "Inversor WEG CFW09";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[15] = (HorizontalAlignment)15;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[16] = "Softstarter WEG SSW07";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[16] = (HorizontalAlignment)16;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[17] = "Softstarter Danfoss MDC3000";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[17] = (HorizontalAlignment)17;
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasMenu[18] = "Thermo Scientific AquaChlor";
					RT_geral.RT_850_DataGridView_ctrl_4[22 + i].LinhasValor[18] = (HorizontalAlignment)18;
					RT_geral.RT_850_DataGridView_ctrl_4[23 + i].LinhasMenu[0] = "----";
					RT_geral.RT_850_DataGridView_ctrl_4[23 + i].LinhasValor[0] = (HorizontalAlignment)0;
					int num = (HorizontalAlignment)1;
					do
					{
						RT_geral.RT_850_DataGridView_ctrl_4[23 + i].LinhasMenu[num] = Conversion.Str(num);
						RT_geral.RT_850_DataGridView_ctrl_4[23 + i].LinhasValor[num] = num;
						num++;
					}
					while (num <= 65);
					i += (HorizontalAlignment)2;
				}
				while (i <= 8);
				if (RT_geral.RT_850_BD.Variaveis_Numero.Valor > 0)
				{
					int num2 = (HorizontalAlignment)1;
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
				RT_geral.RT_850_DataGridView_ctrl_4[0].AlingColuna = (HorizontalAlignment)16;
				RT_geral.RT_850_DataGridView_ctrl_4[1].AlingColuna = (HorizontalAlignment)256;
				RT_geral.RT_850_DataGridView_ctrl_4[2].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[3].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[4].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[5].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[6].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[7].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[8].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[9].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[10].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[11].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[12].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[13].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[14].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[15].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[16].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[17].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[18].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[19].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[20].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[21].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[22].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[23].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[24].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[25].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[26].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[27].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[28].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[29].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[30].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[31].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_4[0].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_4[1].NumeroLinhaMenu = (HorizontalAlignment)2;
				RT_geral.RT_850_DataGridView_ctrl_4[2].NumeroLinhaMenu = (HorizontalAlignment)8;
				RT_geral.RT_850_DataGridView_ctrl_4[3].NumeroLinhaMenu = (HorizontalAlignment)3;
				RT_geral.RT_850_DataGridView_ctrl_4[4].NumeroLinhaMenu = (HorizontalAlignment)8;
				RT_geral.RT_850_DataGridView_ctrl_4[5].NumeroLinhaMenu = (HorizontalAlignment)12;
				RT_geral.RT_850_DataGridView_ctrl_4[6].NumeroLinhaMenu = (HorizontalAlignment)3;
				RT_geral.RT_850_DataGridView_ctrl_4[7].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_4[8].NumeroLinhaMenu = (HorizontalAlignment)3;
				RT_geral.RT_850_DataGridView_ctrl_4[9].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_4[10].NumeroLinhaMenu = (HorizontalAlignment)3;
				RT_geral.RT_850_DataGridView_ctrl_4[11].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_4[12].NumeroLinhaMenu = (HorizontalAlignment)3;
				RT_geral.RT_850_DataGridView_ctrl_4[13].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_4[14].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_4[15].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_4[16].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_4[17].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_4[18].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_4[19].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_4[20].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_4[21].NumeroLinhaMenu = RT_geral.RT_850_BD.Variaveis_Numero.Valor + 1;
				RT_geral.RT_850_DataGridView_ctrl_4[22].NumeroLinhaMenu = (HorizontalAlignment)29;
				RT_geral.RT_850_DataGridView_ctrl_4[23].NumeroLinhaMenu = (HorizontalAlignment)66;
				RT_geral.RT_850_DataGridView_ctrl_4[24].NumeroLinhaMenu = (HorizontalAlignment)29;
				RT_geral.RT_850_DataGridView_ctrl_4[25].NumeroLinhaMenu = (HorizontalAlignment)66;
				RT_geral.RT_850_DataGridView_ctrl_4[26].NumeroLinhaMenu = (HorizontalAlignment)29;
				RT_geral.RT_850_DataGridView_ctrl_4[27].NumeroLinhaMenu = (HorizontalAlignment)66;
				RT_geral.RT_850_DataGridView_ctrl_4[28].NumeroLinhaMenu = (HorizontalAlignment)29;
				RT_geral.RT_850_DataGridView_ctrl_4[29].NumeroLinhaMenu = (HorizontalAlignment)66;
				RT_geral.RT_850_DataGridView_ctrl_4[30].NumeroLinhaMenu = (HorizontalAlignment)29;
				RT_geral.RT_850_DataGridView_ctrl_4[31].NumeroLinhaMenu = (HorizontalAlignment)66;
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00272370 File Offset: 0x00270770
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
			RT_geral.RT_850_DataGridView_ctrl_8[1].LinhasValor[0] = (HorizontalAlignment)0;
			RT_geral.RT_850_DataGridView_ctrl_8[1].LinhasValor[1] = (HorizontalAlignment)1;
			RT_geral.RT_850_DataGridView_ctrl_8[1].LinhasMenu[0] = "Canal 1";
			RT_geral.RT_850_DataGridView_ctrl_8[1].LinhasMenu[1] = "Canal 2";
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor[0] = (HorizontalAlignment)0;
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor[1] = (HorizontalAlignment)1;
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor[2] = (HorizontalAlignment)2;
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor[3] = (HorizontalAlignment)3;
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor[4] = (HorizontalAlignment)4;
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor[5] = (HorizontalAlignment)5;
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor[6] = (HorizontalAlignment)6;
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasValor[7] = (HorizontalAlignment)7;
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[0] = "1";
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[1] = "2";
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[2] = "3";
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[3] = "4";
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[4] = "5";
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[5] = "6";
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[6] = "7";
			RT_geral.RT_850_DataGridView_ctrl_8[2].LinhasMenu[7] = "8";
			RT_geral.RT_850_DataGridView_ctrl_8[3].LinhasValor[0] = (HorizontalAlignment)0;
			RT_geral.RT_850_DataGridView_ctrl_8[3].LinhasValor[1] = (HorizontalAlignment)1;
			RT_geral.RT_850_DataGridView_ctrl_8[3].LinhasValor[2] = (HorizontalAlignment)2;
			RT_geral.RT_850_DataGridView_ctrl_8[3].LinhasMenu[0] = "Desabilitado";
			RT_geral.RT_850_DataGridView_ctrl_8[3].LinhasMenu[1] = "Liberado";
			RT_geral.RT_850_DataGridView_ctrl_8[3].LinhasMenu[2] = "Bloqueado";
			RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasValor[0] = (HorizontalAlignment)0;
			RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasValor[1] = (HorizontalAlignment)1;
			RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasMenu[0] = "Não Definido";
			RT_geral.RT_850_DataGridView_ctrl_8[5].LinhasMenu[1] = "RT820 300";
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor[0] = (HorizontalAlignment)0;
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor[1] = (HorizontalAlignment)1;
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor[2] = (HorizontalAlignment)2;
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor[3] = (HorizontalAlignment)3;
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor[4] = (HorizontalAlignment)4;
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor[5] = (HorizontalAlignment)5;
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor[6] = (HorizontalAlignment)6;
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasValor[7] = (HorizontalAlignment)7;
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[0] = "Desabilitada";
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[1] = "1";
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[2] = "2";
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[3] = "3";
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[4] = "4";
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[5] = "5";
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[6] = "6";
			RT_geral.RT_850_DataGridView_ctrl_8[4].LinhasMenu[7] = "7";
			int i = (HorizontalAlignment)0;
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
				RT_geral.RT_850_DataGridView_ctrl_8[22].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[23].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[23].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[24].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[24].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[25].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[25].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[26].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[26].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[27].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[27].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[28].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[28].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[29].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[29].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[30].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[30].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[31].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[31].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[32].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[32].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[33].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[33].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[34].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[34].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[35].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[35].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[36].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[36].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[37].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[37].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[38].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[38].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[39].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[39].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[40].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[40].LinhasValor[0] = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[41].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_ctrl_8[41].LinhasValor[0] = (HorizontalAlignment)0;
				i = (HorizontalAlignment)0;
				do
				{
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[0] = "Periférico Desabilitado";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[0] = (HorizontalAlignment)0;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[1] = "Medição Vazão - 1 canal";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[1] = (HorizontalAlignment)1;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[2] = "Medição Vazão - 2 canais";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[2] = (HorizontalAlignment)2;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[3] = "Medição Vazão - 3 canais";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[3] = (HorizontalAlignment)3;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[4] = "Medição Vazão - 4 canais";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[4] = (HorizontalAlignment)4;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[5] = "Medição Vazão - 5 canais";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[5] = (HorizontalAlignment)5;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[6] = "Medição Vazão - 6 canais";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[6] = (HorizontalAlignment)6;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[7] = "Medição Vazão - 7 canais";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[7] = (HorizontalAlignment)7;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[8] = "Medição Vazão - 8 canais";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[8] = (HorizontalAlignment)8;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[9] = "Equipamento de Leitura Vazão";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[9] = (HorizontalAlignment)9;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[10] = "Ictel - GC420";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[10] = (HorizontalAlignment)10;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[11] = "Multimedidor IMS mod: Smart Trans";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[11] = (HorizontalAlignment)11;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[12] = "Multimedidor KRON mod: Mult K-05";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[12] = (HorizontalAlignment)12;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[13] = "Inversor Danfoss VLT";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[13] = (HorizontalAlignment)13;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[14] = "Multimedidor SIEMENS PAC 3200";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[14] = (HorizontalAlignment)14;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[15] = "Inversor WEG CFW09";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[15] = (HorizontalAlignment)15;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[16] = "Softstarter WEG SSW07";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[16] = (HorizontalAlignment)16;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[17] = "Softstarter Danfoss MDC3000";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[17] = (HorizontalAlignment)17;
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasMenu[18] = "Thermo Scientific AquaChlor";
					RT_geral.RT_850_DataGridView_ctrl_8[42 + i].LinhasValor[18] = (HorizontalAlignment)18;
					RT_geral.RT_850_DataGridView_ctrl_8[43 + i].LinhasMenu[0] = "----";
					RT_geral.RT_850_DataGridView_ctrl_8[43 + i].LinhasValor[0] = (HorizontalAlignment)0;
					int num = (HorizontalAlignment)1;
					do
					{
						RT_geral.RT_850_DataGridView_ctrl_8[43 + i].LinhasMenu[num] = Conversion.Str(num);
						RT_geral.RT_850_DataGridView_ctrl_8[43 + i].LinhasValor[num] = num;
						num++;
					}
					while (num <= 65);
					i += (HorizontalAlignment)2;
				}
				while (i <= 8);
				if (RT_geral.RT_850_BD.Variaveis_Numero.Valor > 0)
				{
					int num2 = (HorizontalAlignment)1;
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
				RT_geral.RT_850_DataGridView_ctrl_8[0].AlingColuna = (HorizontalAlignment)16;
				RT_geral.RT_850_DataGridView_ctrl_8[1].AlingColuna = (HorizontalAlignment)256;
				RT_geral.RT_850_DataGridView_ctrl_8[2].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[3].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[4].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[5].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[6].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[7].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[8].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[9].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[10].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[11].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[12].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[13].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[14].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[15].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[16].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[17].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[18].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[19].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[20].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[21].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[22].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[23].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[24].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[25].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[26].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[27].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[28].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[29].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[30].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[31].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[32].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[33].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[34].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[35].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[36].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[37].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[38].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[39].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[40].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[41].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[42].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[43].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[44].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[45].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[46].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[47].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[48].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[49].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[50].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[51].AlingColuna = (HorizontalAlignment)64;
				RT_geral.RT_850_DataGridView_ctrl_8[0].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[1].NumeroLinhaMenu = (HorizontalAlignment)2;
				RT_geral.RT_850_DataGridView_ctrl_8[2].NumeroLinhaMenu = (HorizontalAlignment)8;
				RT_geral.RT_850_DataGridView_ctrl_8[3].NumeroLinhaMenu = (HorizontalAlignment)3;
				RT_geral.RT_850_DataGridView_ctrl_8[4].NumeroLinhaMenu = (HorizontalAlignment)8;
				RT_geral.RT_850_DataGridView_ctrl_8[5].NumeroLinhaMenu = (HorizontalAlignment)2;
				RT_geral.RT_850_DataGridView_ctrl_8[6].NumeroLinhaMenu = (HorizontalAlignment)3;
				RT_geral.RT_850_DataGridView_ctrl_8[7].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[8].NumeroLinhaMenu = (HorizontalAlignment)3;
				RT_geral.RT_850_DataGridView_ctrl_8[9].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[10].NumeroLinhaMenu = (HorizontalAlignment)3;
				RT_geral.RT_850_DataGridView_ctrl_8[11].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[12].NumeroLinhaMenu = (HorizontalAlignment)3;
				RT_geral.RT_850_DataGridView_ctrl_8[13].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[14].NumeroLinhaMenu = (HorizontalAlignment)3;
				RT_geral.RT_850_DataGridView_ctrl_8[15].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[16].NumeroLinhaMenu = (HorizontalAlignment)3;
				RT_geral.RT_850_DataGridView_ctrl_8[17].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[18].NumeroLinhaMenu = (HorizontalAlignment)3;
				RT_geral.RT_850_DataGridView_ctrl_8[19].NumeroLinhaMenu = (HorizontalAlignment)0;
				RT_geral.RT_850_DataGridView_ctrl_8[20].NumeroLinhaMenu = (HorizontalAlignment)3;
				RT_geral.RT_850_DataGridView_ctrl_8[21].NumeroLinhaMenu = (HorizontalAlignment)0;
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
				RT_geral.RT_850_DataGridView_ctrl_8[42].NumeroLinhaMenu = (HorizontalAlignment)29;
				RT_geral.RT_850_DataGridView_ctrl_8[43].NumeroLinhaMenu = (HorizontalAlignment)66;
				RT_geral.RT_850_DataGridView_ctrl_8[44].NumeroLinhaMenu = (HorizontalAlignment)29;
				RT_geral.RT_850_DataGridView_ctrl_8[45].NumeroLinhaMenu = (HorizontalAlignment)66;
				RT_geral.RT_850_DataGridView_ctrl_8[46].NumeroLinhaMenu = (HorizontalAlignment)29;
				RT_geral.RT_850_DataGridView_ctrl_8[47].NumeroLinhaMenu = (HorizontalAlignment)66;
				RT_geral.RT_850_DataGridView_ctrl_8[48].NumeroLinhaMenu = (HorizontalAlignment)29;
				RT_geral.RT_850_DataGridView_ctrl_8[49].NumeroLinhaMenu = (HorizontalAlignment)66;
				RT_geral.RT_850_DataGridView_ctrl_8[50].NumeroLinhaMenu = (HorizontalAlignment)29;
				RT_geral.RT_850_DataGridView_ctrl_8[51].NumeroLinhaMenu = (HorizontalAlignment)66;
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0027579C File Offset: 0x00273B9C
		public void InicializaEstrutura_DataGridView_Equipamentos_Vista_RT_850()
		{
			checked
			{
				RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].LinhasMenu = new string[RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor + RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor + RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor + 1];
				RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].LinhasValor = new int[RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor + RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor + RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor + 1];
				int num = RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor + RT_geral.RT_850_BD.Numero_equip_tipo_2.Valor + RT_geral.RT_850_BD.Numero_equip_tipo_3.Valor;
				RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].NumeroLinhaMenu = num + 1;
				RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].LinhasMenu[0] = "  --     ";
				RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].LinhasValor[0] = (HorizontalAlignment)0;
				if (num > 0)
				{
					int num2 = (HorizontalAlignment)1;
					if (RT_geral.RT_850_BD.Numero_equip_tipo_1.Valor > 0)
					{
						int num3 = (HorizontalAlignment)1;
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
						int num4 = (HorizontalAlignment)1;
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
						int num5 = (HorizontalAlignment)1;
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
				RT_geral.RT_850_DataGridView_Equipamentos_Vista[0].AlingColuna = (HorizontalAlignment)16;
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00275A5C File Offset: 0x00273E5C
		private void Atualiza_DataGridView_Equipamentos_Vista_RT_850()
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00275A60 File Offset: 0x00273E60
		public void Carrega_Msg_Alarme_RT_850()
		{
			RT_geral.RT_850_MSG_ALARME[0] = "Nível Baixo";
			RT_geral.RT_850_MSG_ALARME[1] = "Nível Alto";
			RT_geral.RT_850_MSG_ALARME[2] = "Pressão Baixo";
			RT_geral.RT_850_MSG_ALARME[3] = "Pressão Alta";
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00275A94 File Offset: 0x00273E94
		public void Inicializa_Linha_Variaveis_RT_850(int linha)
		{
			checked
			{
				RT_geral.Variaveis_RT_850[linha - 1].Nome.Padrao = "";
				RT_geral.Variaveis_RT_850[linha - 1].Escala_ini.Padrao = (HorizontalAlignment)0;
				RT_geral.Variaveis_RT_850[linha - 1].Escala_ini.Lmte_inf = -999;
				RT_geral.Variaveis_RT_850[linha - 1].Escala_ini.Lmte_sup = (HorizontalAlignment)20000;
				RT_geral.Variaveis_RT_850[linha - 1].Escala_fim.Padrao = (HorizontalAlignment)100;
				RT_geral.Variaveis_RT_850[linha - 1].Escala_fim.Lmte_inf = -999;
				RT_geral.Variaveis_RT_850[linha - 1].Escala_fim.Lmte_sup = (HorizontalAlignment)20000;
				RT_geral.Variaveis_RT_850[linha - 1].Pto_dec_ini.Indice_padrao = (HorizontalAlignment)0;
				RT_geral.Variaveis_RT_850[linha - 1].Pto_dec_fim.Indice_padrao = (HorizontalAlignment)0;
				RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_1.Padrao = (HorizontalAlignment)0;
				RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_1.Lmte_inf = -999;
				RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_1.Lmte_sup = (HorizontalAlignment)20000;
				RT_geral.Variaveis_RT_850[linha - 1].Tipo_alm_1.Indice_padrao = (HorizontalAlignment)0;
				RT_geral.Variaveis_RT_850[linha - 1].Msg_alm_1.Indice_padrao = (HorizontalAlignment)0;
				RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_2.Padrao = (HorizontalAlignment)0;
				RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_2.Lmte_inf = -999;
				RT_geral.Variaveis_RT_850[linha - 1].Nivel_alm_2.Lmte_sup = (HorizontalAlignment)20000;
				RT_geral.Variaveis_RT_850[linha - 1].Tipo_alm_2.Indice_padrao = (HorizontalAlignment)0;
				RT_geral.Variaveis_RT_850[linha - 1].Msg_alm_2.Indice_padrao = (HorizontalAlignment)0;
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
				RT_geral.Variaveis_RT_850[linha - 1].Dsp_tela.Lmte_inf = (HorizontalAlignment)0;
				RT_geral.Variaveis_RT_850[linha - 1].Dsp_tela.Lmte_sup = (HorizontalAlignment)100;
				RT_geral.Variaveis_RT_850[linha - 1].Dsp_pos.Valor = RT_geral.Variaveis_RT_850[linha - 1].Dsp_pos.Indice_padrao;
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00275F18 File Offset: 0x00274318
		public bool Verifica_linha_variaveis_RT_850(int linha)
		{
			bool result = false;
			if (linha == (DialogResult)0)
			{
				result = true;
			}
			else if (Operators.CompareString(Strings.Trim(RT_geral.Variaveis_RT_850[checked(linha - 1)].Nome.Valor), "", false) == (DialogResult)0)
			{
				Interaction.MsgBox("Variável: " + Conversion.Str(linha) + "\r\nParâmetro: Nome -> não válido", (MsgBoxStyle)32, "Atenção - Erro de Configuração");
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00275F88 File Offset: 0x00274388
		public void Atualiza_TelaRT830_200()
		{
			int num;
			int num2;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = (HorizontalAlignment)2;
				if (Operators.CompareString(RT_geral.RT_850_BD.Nome_Arquivo, "", false) == (DialogResult)0)
				{
					this.Text = "Configuração";
				}
				else
				{
					this.Text = "Configuração -> Arquivo : " + RT_geral.RT_850_BD.Nome_Arquivo;
				}
				this.TextBox_versao_RT850.Text = RT_830_200_variaveis_X.RT_830_200_BD.firmware.Versao.Valor.ToString();
				this.TextBox_build_RT850.Text = RT_830_200_variaveis_X.RT_830_200_BD.firmware.Build.Valor.ToString();
				this.TextBox_release_RT850.Text = RT_830_200_variaveis_X.RT_830_200_BD.firmware.Release.Valor.ToString();
				this.TextBox_equipamento_RT850.Text = RT_830_200_variaveis_X.RT_830_200_BD.firmware.Equip.Valor.ToString();
				this.Atualiza_canais_comunicacao();
				this.Atualiza_Reservatorios();
				this.Atualiza_Recalques();
				this.Atualiza_Vista();
				goto IL_13E;
				IL_F0:
				MessageBox.Show("ERRO: Atualiza_TelaRT830()");
				goto IL_13E;
				IL_FD:
				num2 = -1;
								IL_111:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num2 == (DialogResult)0))
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

		// Token: 0x06000254 RID: 596 RVA: 0x002760F8 File Offset: 0x002744F8
		public void AtualizaMsgTela_RT850(string texto, int cor)
		{
			this.ToolStripTextBox_RT850_Msg.Text = texto;
			if (cor == (DialogResult)0)
			{
				this.ToolStripTextBox_RT850_Msg.ForeColor = Color.Blue;
			}
			else if (cor == (DialogResult)1)
			{
				this.ToolStripProgressBar_RT850.Value = (HorizontalAlignment)0;
				this.ToolStripTextBox_RT850_Msg.ForeColor = Color.Red;
			}
			else
			{
				this.ToolStripTextBox_RT850_Msg.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0027615C File Offset: 0x0027455C
		private void CarregaComboBoxBaudRate(ref ComboBox dado)
		{
			dado.Items.Clear();
			dado.Items.Add("1200 bauds");
			dado.Items.Add("9600 bauds");
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00276190 File Offset: 0x00274590
		private void CarregaComboBoxVista_Selecao(ref ComboBox dado)
		{
			dado.Items.Clear();
			dado.Items.Add("Vista não definido");
		}

		// Token: 0x06000257 RID: 599 RVA: 0x002761B0 File Offset: 0x002745B0
		private void CarregaComboBoxVista_Selecao_Habilitados(ref ComboBox dado, int num_vista, int vista_selecionado)
		{
			dado.Items.Clear();
			checked
			{
				for (int i = (HorizontalAlignment)0; i <= num_vista; i++)
				{
					dado.Items.Add(RT_geral.RT_850_Vista[i].Nome.Valor);
				}
				if (num_vista > 0)
				{
					dado.SelectedIndex = vista_selecionado;
				}
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00276208 File Offset: 0x00274608
		private void CarregaComboBoxVista_Canal(ref ComboBox dado)
		{
			dado.Items.Clear();
			dado.Items.Add("Canal 1");
			dado.Items.Add("Canal 2");
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0027623C File Offset: 0x0027463C
		private void CarregaComboBoxVista_Timeout(ref ComboBox dado)
		{
			dado.Items.Clear();
			int num = (HorizontalAlignment)1;
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

		// Token: 0x0600025A RID: 602 RVA: 0x00276278 File Offset: 0x00274678
		private void CarregaComboBoxVista_Prioridade(ref ComboBox dado)
		{
			dado.Items.Clear();
			dado.Items.Add("Desabilitada");
			int num = (HorizontalAlignment)1;
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

		// Token: 0x0600025B RID: 603 RVA: 0x002762C8 File Offset: 0x002746C8
		private void CarregaComboBoxVista_Modelo(ref ComboBox dado)
		{
			RT_geral.RT_850_Modelo.nome = "Modelo do Vista Emulado";
			RT_geral.RT_850_Modelo.Indice_padrao = (HorizontalAlignment)0;
			RT_geral.RT_850_Modelo.Numero_itens = (HorizontalAlignment)4;
			RT_geral.RT_850_Modelo.valores[0] = (HorizontalAlignment)0;
			RT_geral.RT_850_Modelo.valores[1] = (HorizontalAlignment)1;
			RT_geral.RT_850_Modelo.valores[2] = (HorizontalAlignment)2;
			RT_geral.RT_850_Modelo.valores[3] = (HorizontalAlignment)7;
			RT_geral.RT_850_Modelo.itens[0] = "Não definido";
			RT_geral.RT_850_Modelo.itens[1] = "CT 831-010";
			RT_geral.RT_850_Modelo.itens[2] = "CT 831-200";
			RT_geral.RT_850_Modelo.itens[3] = "VA 241-70";
			dado.Items.Clear();
			int num = (HorizontalAlignment)0;
			checked
			{
				int num2 = RT_geral.RT_850_Modelo.Numero_itens - 1;
				for (int i = num; i <= num2; i++)
				{
					dado.Items.Add(RT_geral.RT_850_Modelo.itens[i]);
				}
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x002763B0 File Offset: 0x002747B0
		private void RT_850_conf_FormClosed(object sender, FormClosedEventArgs e)
		{
			int num;
			int num2;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = (HorizontalAlignment)2;
				RT_geral.RT_850_BD.Nome_Arquivo = "";
				ComboBox comboBox_baudrate_RT = this.ComboBox_baudrate_RT850;
				this.CarregaComboBoxBaudRate(ref comboBox_baudrate_RT);
				this.ComboBox_baudrate_RT850 = comboBox_baudrate_RT;
				RT_830_200_inicializa_variavies_X.RT_830_200_inicializa_variaveis();
				RT_830_200_valores_default_X.RT_830_200_valores_default();
				RT_geral.Telas_RT_830_200.Configuracao = false;
				IL_43:
				goto IL_86;
				IL_45:
				num2 = -1;
								IL_59:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num2 == (DialogResult)0))
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

		// Token: 0x0600025D RID: 605 RVA: 0x0027645C File Offset: 0x0027485C
		private void CarregaComboBoxVariaveis(ref ComboBox dado)
		{
			dado.Items.Clear();
			dado.Items.Add("1200 bauds");
			dado.Items.Add("9600 bauds");
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00276490 File Offset: 0x00274890
		private void DataGridView_equip_1_RT850_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00276494 File Offset: 0x00274894
		private void DataGridView_equip_1_RT850_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x002764A0 File Offset: 0x002748A0
		private void DataGridView_equip_1_RT850_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x002764A4 File Offset: 0x002748A4
		private void TextBox_nome_vista_Validating(object sender, CancelEventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Nome.Valor = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00276500 File Offset: 0x00274900
		private void ComboBox_porta_vista_RT_850_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Canal.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0027655C File Offset: 0x0027495C
		private void ComboBox_prioridade_vista_RT_850_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Prioridade.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x002765B8 File Offset: 0x002749B8
		private void ComboBox_timeout_vista_RT_850_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				RT_geral.RT_850_Vista[checked(RT_geral.RT_850_BD.Vista_selecionado.Indice - 1)].Timeout.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00276618 File Offset: 0x00274A18
		private void ComboBox_modelo_vista_RT_850_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RT_geral.RT_850_BD.Vista_selecionado.Indice != 0)
			{
				int num = RT_geral.LocalizaIndiceVetor_str_indice(ref RT_geral.RT_850_Modelo, Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
				RT_geral.RT_850_Vista[RT_geral.RT_850_BD.Vista_selecionado.Indice].Modelo.Indice = RT_geral.RT_850_Modelo.valores[num];
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0027668C File Offset: 0x00274A8C
		private void NumericUpDown_num_var_vista_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00276690 File Offset: 0x00274A90
		private void NumericUpDown_num_equip_vista_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00276694 File Offset: 0x00274A94
		private void ComboBox_Seleciona_Vista_RT_850_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00276698 File Offset: 0x00274A98
		private void DataGridView_vista_variaveis_RT_850_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0027669C File Offset: 0x00274A9C
		private void DataGridView_vista_variaveis_RT_850_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x002766A0 File Offset: 0x00274AA0
		private void DataGridView_vista_variaveis_RT_850_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600026C RID: 620 RVA: 0x002766A4 File Offset: 0x00274AA4
		private void DataGridView_vista_equipamentos_RT_850_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x002766A8 File Offset: 0x00274AA8
		private void DataGridView_vista_equipamentos_RT_850_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x002766AC File Offset: 0x00274AAC
		private void DataGridView_vista_equipamentos_RT_850_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x002766B0 File Offset: 0x00274AB0
		private void TabControl_850_SelectedIndexChanged(object sender, EventArgs e)
		{
			string name = ((TabControl)sender).SelectedTab.Name;
			string text = name;
			if (Operators.CompareString(text, "TabPage_controles", false) == (DialogResult)0 || Operators.CompareString(text, "TabPage_Equipamentos", false) == (DialogResult)0)
			{
				this.Atualiza_canais_comunicacao();
			}
			else if (Operators.CompareString(text, "TabPage_Reservatorio", false) == (DialogResult)0)
			{
				this.Atualiza_Reservatorios();
			}
			else if (Operators.CompareString(text, "TabPage_Recalque", false) == (DialogResult)0)
			{
				this.Atualiza_Recalques();
			}
			else if (Operators.CompareString(text, "TabPage_Vista", false) == (DialogResult)0)
			{
				this.Atualiza_Vista();
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0027673C File Offset: 0x00274B3C
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

		// Token: 0x06000271 RID: 625 RVA: 0x002767E0 File Offset: 0x00274BE0
		public void CriaImagem_RT850(ref int[] dados)
		{
			int num = (HorizontalAlignment)0;
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
			int num2 = (HorizontalAlignment)0;
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
				num2 = (HorizontalAlignment)0;
				do
				{
					Linha_RT.ConverterStringToIntegerArray(RT_geral.RT_850_Ctrl_1[num2].Nome.Valor, ref dados, ref num, 5);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_1[num2].Canal.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_1[num2].Timeout.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_1[num2].Comando.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_1[num2].Prioridade.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_1[num2].Modelo.Indice, ref num);
					int num3 = (HorizontalAlignment)0;
					do
					{
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_1[num2].Var[num3].Indice, ref num);
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_1[num2].Ref[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 3);
					num3 = (HorizontalAlignment)0;
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
				num2 = (HorizontalAlignment)0;
				do
				{
					Linha_RT.ConverterStringToIntegerArray(RT_geral.RT_850_Ctrl_4[num2].Nome.Valor, ref dados, ref num, 5);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Canal.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Timeout.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Comando.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Prioridade.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Modelo.Indice, ref num);
					int num3 = (HorizontalAlignment)0;
					do
					{
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Var[num3].Indice, ref num);
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Ref[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 3);
					num3 = (HorizontalAlignment)0;
					do
					{
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Periferico_Indice[num3].Indice, ref num);
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_4[num2].Periferico_Modelo[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 4);
					num3 = (HorizontalAlignment)0;
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
				num2 = (HorizontalAlignment)0;
				do
				{
					Linha_RT.ConverterStringToIntegerArray(RT_geral.RT_850_Ctrl_8[num2].Nome.Valor, ref dados, ref num, 5);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Canal.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Timeout.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Comando.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Prioridade.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Modelo.Indice, ref num);
					int num3 = (HorizontalAlignment)0;
					do
					{
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Var[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 15);
					num3 = (HorizontalAlignment)0;
					do
					{
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Ref[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 3);
					num3 = (HorizontalAlignment)0;
					do
					{
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Periferico_Indice[num3].Indice, ref num);
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Ctrl_8[num2].Periferico_Modelo[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 4);
					num3 = (HorizontalAlignment)0;
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
				num2 = (HorizontalAlignment)0;
				do
				{
					Linha_RT.ConverterStringToIntegerArray(RT_geral.RT_850_Vista[num2].Nome.Valor, ref dados, ref num, 5);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Vista[num2].Canal.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Vista[num2].Prioridade.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Vista[num2].Timeout.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Vista[num2].Modelo.Indice, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Vista[num2].Num_var.Valor, ref num);
					Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Vista[num2].Num_equip.Valor, ref num);
					int num3 = (HorizontalAlignment)0;
					do
					{
						Linha_RT.AddDadoArrayInteger(ref dados, RT_geral.RT_850_Vista[num2].Variaveis[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 39);
					num3 = (HorizontalAlignment)0;
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

		// Token: 0x06000272 RID: 626 RVA: 0x0027725C File Offset: 0x0027565C
		public void EstrairImagem_RT850(ref int[] dados)
		{
			int num = (HorizontalAlignment)0;
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
			int num2 = (HorizontalAlignment)0;
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
				num2 = (HorizontalAlignment)0;
				do
				{
					RT_geral.RT_850_Ctrl_1[num2].Nome.Valor = Linha_RT.ConverterIntegerArrayToString(ref dados, ref num, 5);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_1[num2].Canal.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_1[num2].Timeout.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_1[num2].Comando.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_1[num2].Prioridade.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_1[num2].Modelo.Indice, ref num);
					int num3 = (HorizontalAlignment)0;
					do
					{
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_1[num2].Var[num3].Indice, ref num);
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_1[num2].Ref[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 3);
					num3 = (HorizontalAlignment)0;
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
				num2 = (HorizontalAlignment)0;
				do
				{
					RT_geral.RT_850_Ctrl_4[num2].Nome.Valor = Linha_RT.ConverterIntegerArrayToString(ref dados, ref num, 5);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Canal.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Timeout.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Comando.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Prioridade.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Modelo.Indice, ref num);
					int num3 = (HorizontalAlignment)0;
					do
					{
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Var[num3].Indice, ref num);
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Ref[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 3);
					num3 = (HorizontalAlignment)0;
					do
					{
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Periferico_Indice[num3].Indice, ref num);
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_4[num2].Periferico_Modelo[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 4);
					num3 = (HorizontalAlignment)0;
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
				num2 = (HorizontalAlignment)0;
				do
				{
					RT_geral.RT_850_Ctrl_8[num2].Nome.Valor = Linha_RT.ConverterIntegerArrayToString(ref dados, ref num, 5);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Canal.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Timeout.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Comando.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Prioridade.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Modelo.Indice, ref num);
					int num3 = (HorizontalAlignment)0;
					do
					{
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Var[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 15);
					num3 = (HorizontalAlignment)0;
					do
					{
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Ref[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 3);
					num3 = (HorizontalAlignment)0;
					do
					{
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Periferico_Indice[num3].Indice, ref num);
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Ctrl_8[num2].Periferico_Modelo[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 4);
					num3 = (HorizontalAlignment)0;
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
				num2 = (HorizontalAlignment)0;
				do
				{
					RT_geral.RT_850_Vista[num2].Nome.Valor = Linha_RT.ConverterIntegerArrayToString(ref dados, ref num, 5);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Vista[num2].Canal.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Vista[num2].Prioridade.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Vista[num2].Timeout.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Vista[num2].Modelo.Indice, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Vista[num2].Num_var.Valor, ref num);
					Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Vista[num2].Num_equip.Valor, ref num);
					int num3 = (HorizontalAlignment)0;
					do
					{
						Linha_RT.ExtraiDadoArrayInteger(dados[num], ref RT_geral.RT_850_Vista[num2].Variaveis[num3].Indice, ref num);
						num3++;
					}
					while (num3 <= 39);
					num3 = (HorizontalAlignment)0;
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

		// Token: 0x06000273 RID: 627 RVA: 0x00277DC8 File Offset: 0x002761C8
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

		// Token: 0x06000274 RID: 628 RVA: 0x00277EB4 File Offset: 0x002762B4
		private void Timer_limpa_MSG_RT850_Tick(object sender, EventArgs e)
		{
			this.Timer_limpa_MSG_RT850.Enabled = false;
			this.AtualizaMsgTela_RT850("", 0);
			this.ToolStripProgressBar_RT850.Value = (HorizontalAlignment)0;
			this.ControleAtivacaoTeclas(3);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00277EE4 File Offset: 0x002762E4
		private void ToolStripButton_RT850_novo_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			RT_geral.Lmte_Init_ok = false;
			RT_geral.RT_850_BD.Nome_Arquivo = "";
			RT_830_200_inicializa_variavies_X.RT_830_200_inicializa_variaveis();
			RT_830_200_valores_default_X.RT_830_200_valores_default();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			this.Atualiza_TelaRT830_200();
			RT_830_200_variaveis_X.RT_830_200_BD.filename = "";
			RT_geral.Lmte_Init_ok = true;
			this.AtualizaMsgTela_RT850("Valores Default carregados", 0);
			this.Timer_limpa_MSG_RT850.Enabled = true;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00277F58 File Offset: 0x00276358
		private void ToolStripButton_RT850_Abrir_Click(object sender, EventArgs e)
		{
			int num;
			int num2;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = (HorizontalAlignment)2;
				this.AtivaEfeitoOnChangeValue();
				int[] array = new int[10001];
				this.ControleAtivacaoTeclas(1);
				this.OpenFileDialog_RT850.Filter = "Arquivo de configuração de equipamento|*.Cfg830";
				this.OpenFileDialog_RT850.InitialDirectory = Linha_RT.diretorio;
				string text;
				if (this.OpenFileDialog_RT850.ShowDialog() == (DialogResult)1)
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
						if (!Linha_RT.VerificaSeEquipamentoEValido(1, RT_830_200_variaveis_X.RT_830_200_BD.firmware.Equip.Valor, RT_830_200_variaveis_X.RT_830_200_BD.firmware.Versao.Valor, RT_830_200_variaveis_X.RT_830_200_BD.firmware.Build.Valor, RT_830_200_variaveis_X.RT_830_200_BD.firmware.Release.Valor, RT_geral.arquivo_extensao).Status)
						{
							RT_geral.Lmte_Init_ok = false;
							RT_geral.RT_850_BD.Nome_Arquivo = "";
							RT_830_200_inicializa_variavies_X.RT_830_200_inicializa_variaveis();
							RT_830_200_valores_default_X.RT_830_200_valores_default();
							Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
							this.Atualiza_TelaRT830_200();
							RT_geral.Lmte_Init_ok = true;
							this.AtualizaMsgTela_RT850("Valores Default carregados", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
						}
						else
						{
							RT_830_200_variaveis_X.RT_830_200_BD.filename = this.OpenFileDialog_RT850.FileName;
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							text = "Geral_Descricao";
							RT_830_200_Load_X.RT_830_200_Carrega_Geral_Descricao(this.OpenFileDialog_RT850.FileName, this);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							text = "Canal_Radio";
							RT_830_200_Load_X.RT_830_200_Carrega_Canal_Radio(this.OpenFileDialog_RT850.FileName);
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							text = "Equipamentos";
							RT_830_200_Load_X.RT_830_200_Carrega_Equipamentos(this.OpenFileDialog_RT850.FileName);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							text = "Variaveis";
							RT_830_200_Load_X.RT_830_200_Carrega_Variaveis(this.OpenFileDialog_RT850.FileName, this);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							text = "RemotasControle";
							RT_830_200_Load_X.RT_830_200_Carrega_RemotasControle(this.OpenFileDialog_RT850.FileName, this);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							text = "Vista";
							RT_830_200_Load_X.RT_830_200_Carrega_Vista(this.OpenFileDialog_RT850.FileName, this);
							Application.DoEvents();
							this.AtualizaMsgTela_RT850("Aguarde: Carregando!", 0);
							this.Timer_limpa_MSG_RT850.Enabled = true;
							text = "Instalacao";
							RT_830_200_Load_X.RT_830_200_Carrega_Instalacao(this.OpenFileDialog_RT850.FileName, this);
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
				goto IL_3E0;
				IL_374:
				Interaction.MsgBox("Não foi possível carregar os dados: " + text, (MsgBoxStyle)32, "Atenção - Erro I/0");
				this.Timer_limpa_MSG_RT850.Enabled = true;
				goto IL_3E0;
				IL_39B:
				num2 = -1;
								IL_3B1:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num2 == (DialogResult)0))
			{
				Exception ex = (Exception)obj2;
				goto IL_39B;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3E0:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0027836C File Offset: 0x0027676C
		private void Carrega_Geral_Informacao(string filename)
		{
			IniFile iniFile = new IniFile(filename);
			RT_830_200_variaveis_X.RT_830_200_BD.firmware.Equip.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "EQUIPAMENTO", -1);
			RT_830_200_variaveis_X.RT_830_200_BD.firmware.Versao.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "VERSAO", -1);
			RT_830_200_variaveis_X.RT_830_200_BD.firmware.Build.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "BUILD", -1);
			RT_830_200_variaveis_X.RT_830_200_BD.firmware.Release.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "RELEASE", -1);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00278414 File Offset: 0x00276814
		private void ToolStripButton_RT850_Salvar_Click(object sender, EventArgs e)
		{
			int num;
			int num2;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = (HorizontalAlignment)2;
				this.AtivaEfeitoOnChangeValue();
				int[] array = new int[10001];
				this.ControleAtivacaoTeclas(2);
				this.SaveFileDialog_RT850.Filter = "Arquivo de configuração de equipamento|*.Cfg830";
				this.SaveFileDialog_RT850.InitialDirectory = Linha_RT.diretorio;
				if (this.SaveFileDialog_RT850.ShowDialog() == (DialogResult)1)
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
						this.InicializaBarraProgressoTela_RT850(8);
						IniFileWriteFast ini = new IniFileWriteFast(this.SaveFileDialog_RT850.FileName);
						RT_830_200_variaveis_X.RT_830_200_BD.filename = this.SaveFileDialog_RT850.FileName;
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						Application.DoEvents();
						RT_830_200_Save_X.RT_830_200_Salva_Geral_Informacao(ini);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						Application.DoEvents();
						RT_830_200_Save_X.RT_830_200_Salva_Geral_Descricao(ini, this);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						Application.DoEvents();
						RT_830_200_Save_X.RT_830_200_Salva_Canal_Radio(ini);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						Application.DoEvents();
						RT_830_200_Save_X.RT_830_200_Salva_Equipamentos(ini);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						Application.DoEvents();
						RT_830_200_Save_X.RT_830_200_Salva_Variaveis(ini);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						Application.DoEvents();
						RT_830_200_Save_X.RT_830_200_Salva_RemotasControle(ini);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						Application.DoEvents();
						RT_830_200_Save_X.RT_830_200_Salva_Vista(ini);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT850("Aguarde: Salvando!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
						Application.DoEvents();
						RT_830_200_Save_X.RT_830_200_Salva_Instalacao(ini, this);
						this.ToolStripProgressBar_RT850.PerformStep();
						Application.DoEvents();
						RT_geral.RT_850_BD.Nome_Arquivo = fileName;
						this.Text = "Configuração - CT 830  -> Arquivo : " + RT_geral.RT_850_BD.Nome_Arquivo;
						this.ToolStripProgressBar_RT850.Value = (HorizontalAlignment)0;
						this.AtualizaMsgTela_RT850("Arquivo gerado com sucesso!", 0);
						this.Timer_limpa_MSG_RT850.Enabled = true;
					}
				}
				else
				{
					this.AtualizaMsgTela_RT850("Operação Cancelada", 0);
					this.Timer_limpa_MSG_RT850.Enabled = true;
				}
				goto IL_3A5;
				IL_340:
				Interaction.MsgBox("Não foi possível gravar os dados", (MsgBoxStyle)32, "Atenção - Erro I/0");
				this.Timer_limpa_MSG_RT850.Enabled = true;
				goto IL_3A5;
				IL_360:
				num2 = -1;
								IL_376:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num2 == (DialogResult)0))
			{
				Exception ex = (Exception)obj2;
				goto IL_360;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3A5:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x002787EC File Offset: 0x00276BEC
		private void ToolStripButton_RT850_Download_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.ControleAtivacaoTeclas(4);
				this.EncerraEdicaoDeCampos_RT850();
				this.Leitura_RT830_200_conf();
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00278824 File Offset: 0x00276C24
		private void ToolStripButton_RT850_Upload_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.ControleAtivacaoTeclas(4);
				this.EncerraEdicaoDeCampos_RT850();
				this.Escrita_RT830_conf();
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0027885C File Offset: 0x00276C5C
		public void Leitura_RT830_200_conf()
		{
			this.InicializaBarraProgressoTela_RT850(9);
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
			Linha_RT.Atualiza_dados_RT830_200(0, 0);
			this.AtualizaMsgTela_RT850("Leitura de configuração - Geral - Etapa 2", 2);
			this.ToolStripProgressBar_RT850.PerformStep();
			if (!Mod_MD.Leitura_pagina(256, 255, 14).Status)
			{
				this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT830_200(256, 0);
			this.AtualizaMsgTela_RT850("Leitura de configuração - Reservatórios - Etapa 3", 2);
			this.ToolStripProgressBar_RT850.PerformStep();
			if (!Mod_MD.Leitura_pagina(512, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 100).Status)
			{
				this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT830_200(512, 0);
			if (!Mod_MD.Leitura_pagina(612, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 100).Status)
			{
				this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT830_200(612, 1);
			int num = (HorizontalAlignment)0;
			checked
			{
				string texto;
				int numero_pagina;
				for (;;)
				{
					texto = string.Format("Leitura de configuração - Recalque {0} - Etapa {1}", num + 1, num + 4);
					this.AtualizaMsgTela_RT850(texto, 2);
					this.ToolStripProgressBar_RT850.PerformStep();
					numero_pagina = 768 + num * 256;
					if (!Mod_MD.Leitura_pagina(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 120).Status)
					{
						break;
					}
					Linha_RT.Atualiza_dados_RT830_200(768 + num * 256, 0);
					numero_pagina = 768 + num * 256 + 120;
					if (!Mod_MD.Leitura_pagina(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 90).Status)
					{
						goto Block_7;
					}
					Linha_RT.Atualiza_dados_RT830_200(768 + num * 256, 1);
					num++;
					if (num > 3)
					{
						goto Block_8;
					}
				}
				this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_7:
				this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_8:
				texto = string.Format("Leitura de configuração - Vista {0} - Etapa {1}", 1, 8);
				this.AtualizaMsgTela_RT850(texto, 2);
				this.ToolStripProgressBar_RT850.PerformStep();
				if (!Mod_MD.Leitura_pagina(1792, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 86).Status)
				{
					this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT830_200(1792, 0);
				texto = string.Format("Leitura de configuração - Vista {0} - Etapa {1}", 2, 9);
				this.AtualizaMsgTela_RT850(texto, 2);
				this.ToolStripProgressBar_RT850.PerformStep();
				numero_pagina = (HorizontalAlignment)1878;
				if (!Mod_MD.Leitura_pagina(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 86).Status)
				{
					this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT830_200(1792, 1);
				texto = string.Format("Leitura de configuração - Vista {0} - Etapa {1}", 2, 9);
				this.AtualizaMsgTela_RT850(texto, 2);
				this.ToolStripProgressBar_RT850.PerformStep();
				numero_pagina = (HorizontalAlignment)1964;
				if (!Mod_MD.Leitura_pagina(numero_pagina, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor, 43).Status)
				{
					this.AtualizaMsgTela_RT850("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT830_200(1792, 2);
				this.Atualiza_TelaRT830_200();
				this.AtualizaMsgTela_RT850("Configuração lida com sucesso", 0);
				this.ToolStripProgressBar_RT850.PerformStep();
				this.Timer_limpa_MSG_RT850.Enabled = true;
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00278C98 File Offset: 0x00277098
		public void InicializaBarraProgressoTela_RT850(int num_passos)
		{
			this.ToolStripProgressBar_RT850.Minimum = (HorizontalAlignment)0;
			this.ToolStripProgressBar_RT850.Maximum = (HorizontalAlignment)1000;
			this.ToolStripProgressBar_RT850.Step = checked((int)Math.Round(unchecked(1000.0 / (double)num_passos + 1.0)));
			this.ToolStripProgressBar_RT850.Value = (HorizontalAlignment)0;
			this.ToolStripProgressBar_RT850.BackColor = Color.LightGray;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00278D04 File Offset: 0x00277104
		public void EncerraEdicaoDeCampos_RT850()
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00278D08 File Offset: 0x00277108
		public void Escrita_RT830_conf()
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
			Linha_RT.Atualiza_dados_RT830_200(0, 0);
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
			if (!Mod_MD.Escrita_pagina(256, 50).Status)
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
			if (!Mod_MD.Escrita_pagina(512, 50).Status)
			{
				this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
			}
			if (!Mod_MD.Escrita_pagina(612, 50).Status)
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
			int num = (HorizontalAlignment)0;
			checked
			{
				for (;;)
				{
					ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
					if (!ctrl_RESP_.Status)
					{
						break;
					}
					string texto = string.Format("Escrita da configuração - Página {0}A", num + 3);
					this.AtualizaMsgTela_RT850(texto, 2);
					Application.DoEvents();
					if (!Mod_MD.Escrita_pagina_RT(array[num], 50, 0).Status)
					{
						goto Block_11;
					}
					if (!Mod_MD.Escrita_pagina_RT(array[num] + 120, 50, 0).Status)
					{
						goto Block_12;
					}
					ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
					if (!ctrl_RESP_.Status)
					{
						goto Block_13;
					}
					this.ToolStripProgressBar_RT850.PerformStep();
					num++;
					if (num > 3)
					{
						goto Block_14;
					}
				}
				this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_11:
				this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_12:
				this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_13:
				this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT850.Enabled = true;
				return;
				Block_14:
				ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT850(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				this.AtualizaMsgTela_RT850("Escrita da configuração - Página 7A", 2);
				Application.DoEvents();
				int num2 = (HorizontalAlignment)1792;
				if (!Mod_MD.Escrita_pagina_RT(num2, 50, 0).Status)
				{
					this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				this.AtualizaMsgTela_RT850("Escrita da configuração - Página 7B", 2);
				Application.DoEvents();
				num2 += (HorizontalAlignment)86;
				if (!Mod_MD.Escrita_pagina_RT(num2, 50, 1).Status)
				{
					this.AtualizaMsgTela_RT850("Erro na escrita de parâmetros", 1);
					this.Timer_limpa_MSG_RT850.Enabled = true;
					return;
				}
				this.AtualizaMsgTela_RT850("Escrita da configuração - Página 7C", 2);
				Application.DoEvents();
				num2 += (HorizontalAlignment)86;
				if (!Mod_MD.Escrita_pagina_RT(num2, 50, 2).Status)
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

		// Token: 0x0600027F RID: 639 RVA: 0x002791FC File Offset: 0x002775FC
		private void TextBox_msg_inicial_RT850_TextChanged(object sender, EventArgs e)
		{
			int num;
			int num2;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = (HorizontalAlignment)2;
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
			catch when (endfilter(obj is Exception & num != 0 & num2 == (DialogResult)0))
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

		// Token: 0x06000280 RID: 640 RVA: 0x0027933C File Offset: 0x0027773C
		private void NumericUpDown_end_1_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco, true);
			sender = numericUpDown;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0027939C File Offset: 0x0027779C
		private void NumericUpDown_intervalo_leitura_1_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.intervalo_polling.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.intervalo_polling, true);
			sender = numericUpDown;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x002793FC File Offset: 0x002777FC
		private void NumericUpDown_timeout_1_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.timeout.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.timeout, true);
			sender = numericUpDown;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0027945C File Offset: 0x0027785C
		private void NumericUpDown_temp_ptt_1_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.PTT.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.PTT, true);
			sender = numericUpDown;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x002794BC File Offset: 0x002778BC
		private void NumericUpDown_num_tentativas_1_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.retrys.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.retrys, true);
			sender = numericUpDown;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0027951C File Offset: 0x0027791C
		private void NumericUpDown_num_erro_falha_1_RT850_ValueChanged(object sender, EventArgs e)
		{
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.erros_falha.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.erros_falha, true);
			sender = numericUpDown;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0027957C File Offset: 0x0027797C
		private void ComboBox_baudrate_1_RT850_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.AtualizaValorPeloIndice();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x002795CC File Offset: 0x002779CC
		private void Button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x002795D0 File Offset: 0x002779D0
		private void ToolStri_RT850_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x002795D4 File Offset: 0x002779D4
		private void ToolStripButton_RT850_Imprimir_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			using (EnhancedPrintPreviewDialog enhancedPrintPreviewDialog = new EnhancedPrintPreviewDialog())
			{
				enhancedPrintPreviewDialog.Document = this.PrintDocument1;
				enhancedPrintPreviewDialog.ShowDialog();
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0027961C File Offset: 0x00277A1C
		private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
		{
			RT_830_200_impressao_X.Impressao_BeginPrint_RT830();
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00279624 File Offset: 0x00277A24
		private void PrintDocument1_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
		{
			e.PageSettings.Landscape = true;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00279634 File Offset: 0x00277A34
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.HasMorePages = RT_830_200_impressao_X.DesenhaRelatorio_RT830(e, this);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00279644 File Offset: 0x00277A44
		private void PrintPreviewDialog1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00279648 File Offset: 0x00277A48
		private void AtualizaTodosNUD()
		{
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.NumericUpDown_end_1_RT850, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco);
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.NumericUpDown_intervalo_leitura_1_RT850, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.intervalo_polling);
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.NumericUpDown_timeout_1_RT850, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.timeout);
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.NumericUpDown_temp_ptt_1_RT850, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.PTT);
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.NumericUpDown_num_tentativas_1_RT850, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.retrys);
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.nud_numero_reservatorios, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_reservatorios);
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.nud_numero_equipamentos_reservatorios, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios);
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.nud_numero_equipamentos_recalque, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques);
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.nud_numero_equipamentos_vista, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas);
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.nud_end_inicial_reservatorio, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_reservatorio);
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.nud_end_inicial_recalque, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_recalque);
			RT_830_200_inicializa_variavies_X.AtualizaNUD(this.nud_end_inicial_vista, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00279790 File Offset: 0x00277B90
		private void AtualizaTodosCOMBOBOX()
		{
			RT_830_200_inicializa_variavies_X.AtualizaCOMBO(this.ComboBox_baudrate_RT850, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x002797AC File Offset: 0x00277BAC
		private void nud_numero_equipamentos_reservatorios_ValueChanged(object sender, EventArgs e)
		{
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios, true);
			sender = numericUpDown;
			this.DataGridView_Reservatorios.RowCount = Convert.ToInt32(this.nud_numero_equipamentos_reservatorios.Value);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00279824 File Offset: 0x00277C24
		private void DataGridView_Reservatorios_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string name = this.DataGridView_Reservatorios.Columns[e.ColumnIndex].Name;
			string text = name;
			if (Operators.CompareString(text, "RES_Nome", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[e.RowIndex].Nome.Valor = Conversions.ToInteger(this.DataGridView_Reservatorios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "RES_Altura", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[e.RowIndex].Altura.Valor = Conversions.ToInteger(this.DataGridView_Reservatorios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[e.RowIndex].Altura, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "RES_Prioridade", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[e.RowIndex].Prioridade.Valor = Conversions.ToInteger(this.DataGridView_Reservatorios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[e.RowIndex].Prioridade, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "RES_Numero_Reservatorio", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[e.RowIndex].NumeroVariavel.Valor = Conversions.ToInteger(this.DataGridView_Reservatorios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[e.RowIndex].NumeroVariavel, e, true);
				sender = dataGridView;
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00279A74 File Offset: 0x00277E74
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
			if (Operators.CompareString(text, "RES_Nome", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[e.RowIndex].Nome.Valor = Conversions.ToInteger(this.DataGridView_Reservatorios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "RES_Altura", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[e.RowIndex].Altura.Valor = Conversions.ToInteger(this.DataGridView_Reservatorios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "RES_Prioridade", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[e.RowIndex].Prioridade.Valor = Conversions.ToInteger(this.DataGridView_Reservatorios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "RES_Numero_Reservatorio", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[e.RowIndex].NumeroVariavel.Valor = Conversions.ToInteger(this.DataGridView_Reservatorios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00279C3C File Offset: 0x0027803C
		private void DataGridView_Recalques_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string name = this.DataGridView_Recalques.Columns[e.ColumnIndex].Name;
			string text = name;
			if (Operators.CompareString(text, "REC_Nome", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Nome.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Res_Origem", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].origem.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].origem, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Res_Destino", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].destino.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].destino, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Modelo", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Modelo.AtualizaIndiceValorPeloItem(Conversions.ToString(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
			}
			else if (Operators.CompareString(text, "REC_Prioridade", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Prioridade.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Prioridade, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Reservatorio1", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Var1.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Var1, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Reservatorio2", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Var2.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Var2, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Reservatorio3", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Var3.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Var3, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Reservatorio4", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Var4.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Var4, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_NomeRes1", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Nome_Var1.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Nome_Var1, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_NomeRes2", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Nome_Var2.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Nome_Var2, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_NomeRes3", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Nome_Var3.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Nome_Var3, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_NomeRes4", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Nome_Var4.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Nome_Var4, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_HabCMD", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Habilita.AtualizaIndiceValorPeloItem(Conversions.ToString(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
			}
			else if (Operators.CompareString(text, "REC_Escala1", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala1.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala1, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala2", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala2.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala2, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala3", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala3.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala3, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala4", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala4.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala4, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala5", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala5.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala5, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala6", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala6.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala6, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala7", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala7.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala7, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala8", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala8.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala8, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala9", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala9.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala9, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala10", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala10.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala10, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala11", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala11.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala11, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala12", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala12.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala12, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala13", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala13.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala13, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala14", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala14.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala14, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala15", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala15.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala15, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "REC_Escala16", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala16.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala16, e, true);
				sender = dataGridView;
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0027AD34 File Offset: 0x00279134
		private void DataGridView_Recalques_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string name = this.DataGridView_Recalques.Columns[e.ColumnIndex].Name;
			string text = name;
			if (Operators.CompareString(text, "REC_Nome", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Nome.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Res_Origem", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].origem.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Res_Destino", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].destino.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Modelo", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Modelo.AtualizaIndiceValorPeloItem(Conversions.ToString(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
			}
			else if (Operators.CompareString(text, "REC_Prioridade", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Prioridade.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Reservatorio1", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Var1.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Reservatorio2", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Var2.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Reservatorio3", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Var3.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Reservatorio4", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Var4.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_NomeRes1", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Nome_Var1.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_NomeRes2", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Nome_Var2.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_NomeRes3", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Nome_Var3.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_NomeRes4", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Nome_Var4.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_HabCMD", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Habilita.AtualizaIndiceValorPeloItem(Conversions.ToString(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
			}
			else if (Operators.CompareString(text, "REC_Escala1", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala1.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala2", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala2.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala3", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala3.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala4", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala4.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala5", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala5.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala6", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala6.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala7", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala7.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala8", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala8.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala9", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala9.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala10", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala10.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala11", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala11.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala12", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala12.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala13", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala13.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala14", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala14.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala15", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala15.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
			else if (Operators.CompareString(text, "REC_Escala16", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.recalque[e.RowIndex].Escala16.Valor = Conversions.ToInteger(this.DataGridView_Recalques.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0027B900 File Offset: 0x00279D00
		private void nud_numero_equipamentos_recalque_ValueChanged(object sender, EventArgs e)
		{
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques, true);
			sender = numericUpDown;
			this.DataGridView_Recalques.RowCount = Convert.ToInt32(this.nud_numero_equipamentos_recalque.Value);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0027B978 File Offset: 0x00279D78
		private void nud_numero_equipamentos_vista_ValueChanged(object sender, EventArgs e)
		{
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas, true);
			sender = numericUpDown;
			this.DataGridView_Qtd_Vista.RowCount = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor;
			this.DataGridView_Vista_Variaveis.RowCount = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor;
			this.DataGridView_Vista_Remotas.RowCount = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0027BA34 File Offset: 0x00279E34
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

		// Token: 0x06000298 RID: 664 RVA: 0x0027BA64 File Offset: 0x00279E64
		private void DataGridView_Qtd_Vista_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string name = this.DataGridView_Qtd_Vista.Columns[e.ColumnIndex].Name;
			string text = name;
			if (Operators.CompareString(text, "Qtd_Vista_Reservatorio", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.vista[e.RowIndex].Numero_Variaveis.Valor = Conversions.ToInteger(this.DataGridView_Qtd_Vista.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.vista[e.RowIndex].Numero_Variaveis, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "Qtd_Vista_Recalque", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.vista[e.RowIndex].Numero_RemotasControles.Valor = Conversions.ToInteger(this.DataGridView_Qtd_Vista.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.vista[e.RowIndex].Numero_RemotasControles, e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(text, "Qtd_Vista_Prioridade", false) == (DialogResult)0)
			{
				RT_830_200_variaveis_X.RT_830_200_BD.vista[e.RowIndex].Prioridade.Valor = Conversions.ToInteger(this.DataGridView_Qtd_Vista.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.vista[e.RowIndex].Prioridade, e, true);
				sender = dataGridView;
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0027BC50 File Offset: 0x0027A050
		private void DataGridView_Qtd_Vista_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string name = this.DataGridView_Qtd_Vista.Columns[e.ColumnIndex].Name;
			string text = name;
			checked
			{
				if (Operators.CompareString(text, "Qtd_Vista_Reservatorio", false) == (DialogResult)0)
				{
					RT_830_200_variaveis_X.RT_830_200_BD.vista[e.RowIndex].Numero_Variaveis.Valor = Conversions.ToInteger(this.DataGridView_Qtd_Vista.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = (HorizontalAlignment)0;
					int num2 = (HorizontalAlignment)0;
					int num3 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (num < RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_Variaveis.Valor)
						{
							num = RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_Variaveis.Valor;
						}
					}
					this.DataGridView_Vista_Variaveis.ColumnCount = num + 2;
					this.Atualiza_Vista_Lista_Variaveis();
				}
				else if (Operators.CompareString(text, "Qtd_Vista_Recalque", false) == (DialogResult)0)
				{
					RT_830_200_variaveis_X.RT_830_200_BD.vista[e.RowIndex].Numero_RemotasControles.Valor = Conversions.ToInteger(this.DataGridView_Qtd_Vista.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = (HorizontalAlignment)0;
					int num4 = (HorizontalAlignment)0;
					int num5 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor - 1;
					for (int i = num4; i <= num5; i++)
					{
						if (num < RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_RemotasControles.Valor)
						{
							num = RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_RemotasControles.Valor;
						}
					}
					this.DataGridView_Vista_Remotas.ColumnCount = num + 2;
					this.Atualiza_Vista_Lista_Remotas();
				}
				else if (Operators.CompareString(text, "Qtd_Vista_Prioridade", false) == (DialogResult)0)
				{
					RT_830_200_variaveis_X.RT_830_200_BD.vista[e.RowIndex].Prioridade.Valor = Conversions.ToInteger(this.DataGridView_Qtd_Vista.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				}
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0027BE98 File Offset: 0x0027A298
		private void DataGridView_Qtd_Vista_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			if (this.DataGridView_Qtd_Vista.IsCurrentCellDirty)
			{
				this.DataGridView_Qtd_Vista.CommitEdit(512);
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0027BEC8 File Offset: 0x0027A2C8
		private void nud_numero_reservatorios_ValueChanged(object sender, EventArgs e)
		{
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_reservatorios.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_reservatorios, true);
			sender = numericUpDown;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0027BF28 File Offset: 0x0027A328
		private void DataGridView_Vista_Variaveis_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			if (this.DataGridView_Vista_Variaveis.IsCurrentCellDirty)
			{
				this.DataGridView_Vista_Variaveis.CommitEdit(512);
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0027BF58 File Offset: 0x0027A358
		private void DataGridView_Vista_Remotas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			if (this.DataGridView_Vista_Remotas.IsCurrentCellDirty)
			{
				this.DataGridView_Vista_Remotas.CommitEdit(512);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0027BF88 File Offset: 0x0027A388
		private void DataGridView_Vista_Variaveis_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string name = this.DataGridView_Vista_Variaveis.Columns[e.ColumnIndex].Name;
			object objectValue = RuntimeHelpers.GetObjectValue(this.DataGridView_Vista_Variaveis.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			string text = name;
			checked
			{
				if (Operators.CompareString(text, "VR_Vista", false) != 0)
				{
					if (Operators.CompareString(text, "VR_End", false) != 0)
					{
						if (!this.DataGridView_Vista_Variaveis.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly)
						{
							RT_830_200_variaveis_X.RT_830_200_BD.vista[e.RowIndex].Variaveis[e.ColumnIndex - 2].Valor = Conversions.ToInteger(objectValue);
							DataGridView dataGridView = (DataGridView)sender;
							RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.vista[e.RowIndex].Variaveis[e.ColumnIndex - 2], e, true);
							sender = dataGridView;
						}
					}
				}
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0027C0B4 File Offset: 0x0027A4B4
		private void DataGridView_Vista_Variaveis_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string name = this.DataGridView_Vista_Variaveis.Columns[e.ColumnIndex].Name;
			object objectValue = RuntimeHelpers.GetObjectValue(this.DataGridView_Vista_Variaveis.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			string text = name;
			if (Operators.CompareString(text, "VR_Vista", false) != 0)
			{
				if (Operators.CompareString(text, "VR_End", false) != 0)
				{
					if (!this.DataGridView_Vista_Variaveis.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly)
					{
						RT_830_200_variaveis_X.RT_830_200_BD.vista[e.RowIndex].Variaveis[checked(e.ColumnIndex - 2)].Valor = Conversions.ToInteger(objectValue);
					}
				}
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0027C19C File Offset: 0x0027A59C
		private void DataGridView_Vista_Remotas_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string name = this.DataGridView_Vista_Remotas.Columns[e.ColumnIndex].Name;
			object objectValue = RuntimeHelpers.GetObjectValue(this.DataGridView_Vista_Remotas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			string text = name;
			if (Operators.CompareString(text, "VC_Vista", false) != 0)
			{
				if (Operators.CompareString(text, "VC_Endereco", false) != 0)
				{
					if (!this.DataGridView_Vista_Remotas.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly)
					{
						RT_830_200_variaveis_X.RT_830_200_BD.vista[e.RowIndex].RemotasControles[checked(e.ColumnIndex - 2)].Valor = Conversions.ToInteger(objectValue);
					}
				}
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0027C284 File Offset: 0x0027A684
		private void DataGridView_Vista_Remotas_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (!RT_geral.RT_850_Controle.LiberaEventos_Variaveis)
			{
				return;
			}
			string name = this.DataGridView_Vista_Remotas.Columns[e.ColumnIndex].Name;
			object objectValue = RuntimeHelpers.GetObjectValue(this.DataGridView_Vista_Remotas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			string text = name;
			checked
			{
				if (Operators.CompareString(text, "VC_Vista", false) != 0)
				{
					if (Operators.CompareString(text, "VC_Endereco", false) != 0)
					{
						if (!this.DataGridView_Vista_Remotas.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly)
						{
							RT_830_200_variaveis_X.RT_830_200_BD.vista[e.RowIndex].RemotasControles[e.ColumnIndex - 2].Valor = Conversions.ToInteger(objectValue);
							DataGridView dataGridView = (DataGridView)sender;
							RT_geral.Limite_ok_celula(ref dataGridView, ref RT_830_200_variaveis_X.RT_830_200_BD.vista[e.RowIndex].RemotasControles[e.ColumnIndex - 2], e, true);
							sender = dataGridView;
						}
					}
				}
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0027C3B0 File Offset: 0x0027A7B0
		private void nud_end_inicial_reservatorio_ValueChanged(object sender, EventArgs e)
		{
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_reservatorio.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_reservatorio, true);
			sender = numericUpDown;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0027C410 File Offset: 0x0027A810
		private void nud_end_inicial_recalque_ValueChanged(object sender, EventArgs e)
		{
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_recalque.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_recalque, true);
			sender = numericUpDown;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0027C470 File Offset: 0x0027A870
		private void nud_end_inicial_vista_ValueChanged(object sender, EventArgs e)
		{
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista, true);
			sender = numericUpDown;
		}

		// Token: 0x0400024F RID: 591
		[AccessedThroughProperty("ToolStri_RT850")]
		private ToolStrip _ToolStri_RT850;

		// Token: 0x04000250 RID: 592
		[AccessedThroughProperty("ToolStripButton_RT850_novo")]
		private ToolStripButton _ToolStripButton_RT850_novo;

		// Token: 0x04000251 RID: 593
		[AccessedThroughProperty("ToolStripButton_RT850_Abrir")]
		private ToolStripButton _ToolStripButton_RT850_Abrir;

		// Token: 0x04000252 RID: 594
		[AccessedThroughProperty("ToolStripButton_RT850_Salvar")]
		private ToolStripButton _ToolStripButton_RT850_Salvar;

		// Token: 0x04000253 RID: 595
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x04000254 RID: 596
		[AccessedThroughProperty("ToolStripButton_RT850_Download")]
		private ToolStripButton _ToolStripButton_RT850_Download;

		// Token: 0x04000255 RID: 597
		[AccessedThroughProperty("ToolStripButton_RT850_Upload")]
		private ToolStripButton _ToolStripButton_RT850_Upload;

		// Token: 0x04000256 RID: 598
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x04000257 RID: 599
		[AccessedThroughProperty("ToolStripTextBox_RT850_Msg")]
		private ToolStripTextBox _ToolStripTextBox_RT850_Msg;

		// Token: 0x04000258 RID: 600
		[AccessedThroughProperty("ToolStripProgressBar_RT850")]
		private ToolStripProgressBar _ToolStripProgressBar_RT850;

		// Token: 0x04000259 RID: 601
		[AccessedThroughProperty("TabControl_850")]
		private TabControl _TabControl_850;

		// Token: 0x0400025A RID: 602
		[AccessedThroughProperty("TabPage_geral")]
		private TabPage _TabPage_geral;

		// Token: 0x0400025B RID: 603
		[AccessedThroughProperty("GroupBox_descricao_RT850")]
		private GroupBox _GroupBox_descricao_RT850;

		// Token: 0x0400025C RID: 604
		[AccessedThroughProperty("TextBox_comentarios_RT850")]
		private TextBox _TextBox_comentarios_RT850;

		// Token: 0x0400025D RID: 605
		[AccessedThroughProperty("TextBox_endereco_RT850")]
		private TextBox _TextBox_endereco_RT850;

		// Token: 0x0400025E RID: 606
		[AccessedThroughProperty("TextBox_nome_RT850")]
		private TextBox _TextBox_nome_RT850;

		// Token: 0x0400025F RID: 607
		[AccessedThroughProperty("Label_comentarios_RT850")]
		private Label _Label_comentarios_RT850;

		// Token: 0x04000260 RID: 608
		[AccessedThroughProperty("Label_endereco_RT850")]
		private Label _Label_endereco_RT850;

		// Token: 0x04000261 RID: 609
		[AccessedThroughProperty("Label_nome_RT850")]
		private Label _Label_nome_RT850;

		// Token: 0x04000262 RID: 610
		[AccessedThroughProperty("GroupBox_informacoes_RT850")]
		private GroupBox _GroupBox_informacoes_RT850;

		// Token: 0x04000263 RID: 611
		[AccessedThroughProperty("TabPage_controles")]
		private TabPage _TabPage_controles;

		// Token: 0x04000264 RID: 612
		[AccessedThroughProperty("GroupBox_canal_1_RT850")]
		private GroupBox _GroupBox_canal_1_RT850;

		// Token: 0x04000265 RID: 613
		[AccessedThroughProperty("Label_end_canal_1_RT850")]
		private Label _Label_end_canal_1_RT850;

		// Token: 0x04000266 RID: 614
		[AccessedThroughProperty("Label_intervalo_leitura_1_RT850")]
		private Label _Label_intervalo_leitura_1_RT850;

		// Token: 0x04000267 RID: 615
		[AccessedThroughProperty("ComboBox_baudrate_RT850")]
		private ComboBox _ComboBox_baudrate_RT850;

		// Token: 0x04000268 RID: 616
		[AccessedThroughProperty("Label_baudrate_1_RT850")]
		private Label _Label_baudrate_1_RT850;

		// Token: 0x04000269 RID: 617
		[AccessedThroughProperty("NumericUpDown_timeout_1_RT850")]
		private NumericUpDown _NumericUpDown_timeout_1_RT850;

		// Token: 0x0400026A RID: 618
		[AccessedThroughProperty("Label_timeout_1_RT850")]
		private Label _Label_timeout_1_RT850;

		// Token: 0x0400026B RID: 619
		[AccessedThroughProperty("NumericUpDown_num_tentativas_1_RT850")]
		private NumericUpDown _NumericUpDown_num_tentativas_1_RT850;

		// Token: 0x0400026C RID: 620
		[AccessedThroughProperty("Label_num_tentativas_1_RT850")]
		private Label _Label_num_tentativas_1_RT850;

		// Token: 0x0400026D RID: 621
		[AccessedThroughProperty("NumericUpDown_temp_ptt_1_RT850")]
		private NumericUpDown _NumericUpDown_temp_ptt_1_RT850;

		// Token: 0x0400026E RID: 622
		[AccessedThroughProperty("Label_tempo_ptt_1_RT850")]
		private Label _Label_tempo_ptt_1_RT850;

		// Token: 0x0400026F RID: 623
		[AccessedThroughProperty("NumericUpDown_num_erro_falha_1_RT850")]
		private NumericUpDown _NumericUpDown_num_erro_falha_1_RT850;

		// Token: 0x04000270 RID: 624
		[AccessedThroughProperty("Label_num_erro_falha_1_RT850")]
		private Label _Label_num_erro_falha_1_RT850;

		// Token: 0x04000271 RID: 625
		[AccessedThroughProperty("NumericUpDown_intervalo_leitura_1_RT850")]
		private NumericUpDown _NumericUpDown_intervalo_leitura_1_RT850;

		// Token: 0x04000272 RID: 626
		[AccessedThroughProperty("NumericUpDown_end_1_RT850")]
		private NumericUpDown _NumericUpDown_end_1_RT850;

		// Token: 0x04000273 RID: 627
		[AccessedThroughProperty("OpenFileDialog_RT850")]
		private OpenFileDialog _OpenFileDialog_RT850;

		// Token: 0x04000274 RID: 628
		[AccessedThroughProperty("SaveFileDialog_RT850")]
		private SaveFileDialog _SaveFileDialog_RT850;

		// Token: 0x04000275 RID: 629
		[AccessedThroughProperty("Timer_limpa_MSG_RT850")]
		private Timer _Timer_limpa_MSG_RT850;

		// Token: 0x04000276 RID: 630
		[AccessedThroughProperty("TabPage_Equipamentos")]
		private TabPage _TabPage_Equipamentos;

		// Token: 0x04000277 RID: 631
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000278 RID: 632
		[AccessedThroughProperty("ToolStripButton_RT850_Imprimir")]
		private ToolStripButton _ToolStripButton_RT850_Imprimir;

		// Token: 0x04000279 RID: 633
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x0400027A RID: 634
		[AccessedThroughProperty("PrintDocument1")]
		private PrintDocument _PrintDocument1;

		// Token: 0x0400027B RID: 635
		[AccessedThroughProperty("PrintPreviewDialog1")]
		private PrintPreviewDialog _PrintPreviewDialog1;

		// Token: 0x0400027C RID: 636
		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		// Token: 0x0400027D RID: 637
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x0400027E RID: 638
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x0400027F RID: 639
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x04000280 RID: 640
		[AccessedThroughProperty("T_AlturaAntena1")]
		private TextBox _T_AlturaAntena1;

		// Token: 0x04000281 RID: 641
		[AccessedThroughProperty("T_Latitude1")]
		private TextBox _T_Latitude1;

		// Token: 0x04000282 RID: 642
		[AccessedThroughProperty("T_Longitude1")]
		private TextBox _T_Longitude1;

		// Token: 0x04000283 RID: 643
		[AccessedThroughProperty("T_Azimute1")]
		private TextBox _T_Azimute1;

		// Token: 0x04000284 RID: 644
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000285 RID: 645
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000286 RID: 646
		[AccessedThroughProperty("T_FreqRadio1")]
		private TextBox _T_FreqRadio1;

		// Token: 0x04000287 RID: 647
		[AccessedThroughProperty("T_PotRadio1")]
		private TextBox _T_PotRadio1;

		// Token: 0x04000288 RID: 648
		[AccessedThroughProperty("CB_ModeloRadio1")]
		private ComboBox _CB_ModeloRadio1;

		// Token: 0x04000289 RID: 649
		[AccessedThroughProperty("CB_PolarizacaoAntena1")]
		private ComboBox _CB_PolarizacaoAntena1;

		// Token: 0x0400028A RID: 650
		[AccessedThroughProperty("CB_TipoAntena1")]
		private ComboBox _CB_TipoAntena1;

		// Token: 0x0400028B RID: 651
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x0400028C RID: 652
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x0400028D RID: 653
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x0400028E RID: 654
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x0400028F RID: 655
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000290 RID: 656
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000291 RID: 657
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000292 RID: 658
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000293 RID: 659
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x04000294 RID: 660
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x04000295 RID: 661
		[AccessedThroughProperty("ToolStripLabel1")]
		private ToolStripLabel _ToolStripLabel1;

		// Token: 0x04000296 RID: 662
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000297 RID: 663
		[AccessedThroughProperty("TextBox_equipamento_RT850")]
		private TextBox _TextBox_equipamento_RT850;

		// Token: 0x04000298 RID: 664
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x04000299 RID: 665
		[AccessedThroughProperty("TextBox_release_RT850")]
		private TextBox _TextBox_release_RT850;

		// Token: 0x0400029A RID: 666
		[AccessedThroughProperty("Label29")]
		private Label _Label29;

		// Token: 0x0400029B RID: 667
		[AccessedThroughProperty("TextBox_build_RT850")]
		private TextBox _TextBox_build_RT850;

		// Token: 0x0400029C RID: 668
		[AccessedThroughProperty("Label30")]
		private Label _Label30;

		// Token: 0x0400029D RID: 669
		[AccessedThroughProperty("TextBox_versao_RT850")]
		private TextBox _TextBox_versao_RT850;

		// Token: 0x0400029E RID: 670
		[AccessedThroughProperty("Label31")]
		private Label _Label31;

		// Token: 0x0400029F RID: 671
		[AccessedThroughProperty("Label35")]
		private Label _Label35;

		// Token: 0x040002A0 RID: 672
		[AccessedThroughProperty("Label34")]
		private Label _Label34;

		// Token: 0x040002A1 RID: 673
		[AccessedThroughProperty("Label33")]
		private Label _Label33;

		// Token: 0x040002A2 RID: 674
		[AccessedThroughProperty("Label32")]
		private Label _Label32;

		// Token: 0x040002A3 RID: 675
		[AccessedThroughProperty("nud_numero_equipamentos_vista")]
		private NumericUpDown _nud_numero_equipamentos_vista;

		// Token: 0x040002A4 RID: 676
		[AccessedThroughProperty("nud_numero_equipamentos_recalque")]
		private NumericUpDown _nud_numero_equipamentos_recalque;

		// Token: 0x040002A5 RID: 677
		[AccessedThroughProperty("nud_numero_equipamentos_reservatorios")]
		private NumericUpDown _nud_numero_equipamentos_reservatorios;

		// Token: 0x040002A6 RID: 678
		[AccessedThroughProperty("nud_numero_reservatorios")]
		private NumericUpDown _nud_numero_reservatorios;

		// Token: 0x040002A7 RID: 679
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x040002A8 RID: 680
		[AccessedThroughProperty("Label36")]
		private Label _Label36;

		// Token: 0x040002A9 RID: 681
		[AccessedThroughProperty("nud_end_inicial_vista")]
		private NumericUpDown _nud_end_inicial_vista;

		// Token: 0x040002AA RID: 682
		[AccessedThroughProperty("nud_end_inicial_recalque")]
		private NumericUpDown _nud_end_inicial_recalque;

		// Token: 0x040002AB RID: 683
		[AccessedThroughProperty("nud_end_inicial_reservatorio")]
		private NumericUpDown _nud_end_inicial_reservatorio;

		// Token: 0x040002AC RID: 684
		[AccessedThroughProperty("Label38")]
		private Label _Label38;

		// Token: 0x040002AD RID: 685
		[AccessedThroughProperty("Label37")]
		private Label _Label37;

		// Token: 0x040002AE RID: 686
		[AccessedThroughProperty("TabPage_Reservatorio")]
		private TabPage _TabPage_Reservatorio;

		// Token: 0x040002AF RID: 687
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x040002B0 RID: 688
		[AccessedThroughProperty("DataGridView_Reservatorios")]
		private DataGridView _DataGridView_Reservatorios;

		// Token: 0x040002B1 RID: 689
		[AccessedThroughProperty("TabPage_Recalque")]
		private TabPage _TabPage_Recalque;

		// Token: 0x040002B2 RID: 690
		[AccessedThroughProperty("TabPage_Vista")]
		private TabPage _TabPage_Vista;

		// Token: 0x040002B3 RID: 691
		[AccessedThroughProperty("DataGridView_Recalques")]
		private DataGridView _DataGridView_Recalques;

		// Token: 0x040002B4 RID: 692
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		// Token: 0x040002B5 RID: 693
		[AccessedThroughProperty("GroupBox7")]
		private GroupBox _GroupBox7;

		// Token: 0x040002B6 RID: 694
		[AccessedThroughProperty("DataGridView_Qtd_Vista")]
		private DataGridView _DataGridView_Qtd_Vista;

		// Token: 0x040002B7 RID: 695
		[AccessedThroughProperty("DataGridView_Vista_Variaveis")]
		private DataGridView _DataGridView_Vista_Variaveis;

		// Token: 0x040002B8 RID: 696
		[AccessedThroughProperty("DataGridView_Vista_Remotas")]
		private DataGridView _DataGridView_Vista_Remotas;

		// Token: 0x040002B9 RID: 697
		[AccessedThroughProperty("Label40")]
		private Label _Label40;

		// Token: 0x040002BA RID: 698
		[AccessedThroughProperty("Label39")]
		private Label _Label39;

		// Token: 0x040002BB RID: 699
		[AccessedThroughProperty("Label41")]
		private Label _Label41;

		// Token: 0x040002BC RID: 700
		[AccessedThroughProperty("RES_End_Comunicacao")]
		private DataGridViewTextBoxColumn _RES_End_Comunicacao;

		// Token: 0x040002BD RID: 701
		[AccessedThroughProperty("RES_Nome")]
		private DataGridViewTextBoxColumn _RES_Nome;

		// Token: 0x040002BE RID: 702
		[AccessedThroughProperty("RES_Altura")]
		private DataGridViewTextBoxColumn _RES_Altura;

		// Token: 0x040002BF RID: 703
		[AccessedThroughProperty("RES_Prioridade")]
		private DataGridViewTextBoxColumn _RES_Prioridade;

		// Token: 0x040002C0 RID: 704
		[AccessedThroughProperty("RES_Numero_Reservatorio")]
		private DataGridViewTextBoxColumn _RES_Numero_Reservatorio;

		// Token: 0x040002C1 RID: 705
		[AccessedThroughProperty("Vista")]
		private DataGridViewTextBoxColumn _Vista;

		// Token: 0x040002C2 RID: 706
		[AccessedThroughProperty("Endereco")]
		private DataGridViewTextBoxColumn _Endereco;

		// Token: 0x040002C3 RID: 707
		[AccessedThroughProperty("Qtd_Vista_Reservatorio")]
		private DataGridViewTextBoxColumn _Qtd_Vista_Reservatorio;

		// Token: 0x040002C4 RID: 708
		[AccessedThroughProperty("Qtd_Vista_Recalque")]
		private DataGridViewTextBoxColumn _Qtd_Vista_Recalque;

		// Token: 0x040002C5 RID: 709
		[AccessedThroughProperty("Qtd_Vista_Prioridade")]
		private DataGridViewTextBoxColumn _Qtd_Vista_Prioridade;

		// Token: 0x040002C6 RID: 710
		[AccessedThroughProperty("REC_End_Comunicacao")]
		private DataGridViewTextBoxColumn _REC_End_Comunicacao;

		// Token: 0x040002C7 RID: 711
		[AccessedThroughProperty("REC_Nome")]
		private DataGridViewTextBoxColumn _REC_Nome;

		// Token: 0x040002C8 RID: 712
		[AccessedThroughProperty("REC_Res_Origem")]
		private DataGridViewTextBoxColumn _REC_Res_Origem;

		// Token: 0x040002C9 RID: 713
		[AccessedThroughProperty("REC_Res_Destino")]
		private DataGridViewTextBoxColumn _REC_Res_Destino;

		// Token: 0x040002CA RID: 714
		[AccessedThroughProperty("REC_Modelo")]
		private DataGridViewComboBoxColumn _REC_Modelo;

		// Token: 0x040002CB RID: 715
		[AccessedThroughProperty("REC_Prioridade")]
		private DataGridViewTextBoxColumn _REC_Prioridade;

		// Token: 0x040002CC RID: 716
		[AccessedThroughProperty("REC_Reservatorio1")]
		private DataGridViewTextBoxColumn _REC_Reservatorio1;

		// Token: 0x040002CD RID: 717
		[AccessedThroughProperty("REC_Reservatorio2")]
		private DataGridViewTextBoxColumn _REC_Reservatorio2;

		// Token: 0x040002CE RID: 718
		[AccessedThroughProperty("REC_Reservatorio3")]
		private DataGridViewTextBoxColumn _REC_Reservatorio3;

		// Token: 0x040002CF RID: 719
		[AccessedThroughProperty("REC_Reservatorio4")]
		private DataGridViewTextBoxColumn _REC_Reservatorio4;

		// Token: 0x040002D0 RID: 720
		[AccessedThroughProperty("REC_NomeRes1")]
		private DataGridViewTextBoxColumn _REC_NomeRes1;

		// Token: 0x040002D1 RID: 721
		[AccessedThroughProperty("REC_NomeRes2")]
		private DataGridViewTextBoxColumn _REC_NomeRes2;

		// Token: 0x040002D2 RID: 722
		[AccessedThroughProperty("REC_NomeRes3")]
		private DataGridViewTextBoxColumn _REC_NomeRes3;

		// Token: 0x040002D3 RID: 723
		[AccessedThroughProperty("REC_NomeRes4")]
		private DataGridViewTextBoxColumn _REC_NomeRes4;

		// Token: 0x040002D4 RID: 724
		[AccessedThroughProperty("REC_HabCMD")]
		private DataGridViewComboBoxColumn _REC_HabCMD;

		// Token: 0x040002D5 RID: 725
		[AccessedThroughProperty("REC_Escala1")]
		private DataGridViewTextBoxColumn _REC_Escala1;

		// Token: 0x040002D6 RID: 726
		[AccessedThroughProperty("REC_Escala2")]
		private DataGridViewTextBoxColumn _REC_Escala2;

		// Token: 0x040002D7 RID: 727
		[AccessedThroughProperty("REC_Escala3")]
		private DataGridViewTextBoxColumn _REC_Escala3;

		// Token: 0x040002D8 RID: 728
		[AccessedThroughProperty("REC_Escala4")]
		private DataGridViewTextBoxColumn _REC_Escala4;

		// Token: 0x040002D9 RID: 729
		[AccessedThroughProperty("REC_Escala5")]
		private DataGridViewTextBoxColumn _REC_Escala5;

		// Token: 0x040002DA RID: 730
		[AccessedThroughProperty("REC_Escala6")]
		private DataGridViewTextBoxColumn _REC_Escala6;

		// Token: 0x040002DB RID: 731
		[AccessedThroughProperty("REC_Escala7")]
		private DataGridViewTextBoxColumn _REC_Escala7;

		// Token: 0x040002DC RID: 732
		[AccessedThroughProperty("REC_Escala8")]
		private DataGridViewTextBoxColumn _REC_Escala8;

		// Token: 0x040002DD RID: 733
		[AccessedThroughProperty("REC_Escala9")]
		private DataGridViewTextBoxColumn _REC_Escala9;

		// Token: 0x040002DE RID: 734
		[AccessedThroughProperty("REC_Escala10")]
		private DataGridViewTextBoxColumn _REC_Escala10;

		// Token: 0x040002DF RID: 735
		[AccessedThroughProperty("REC_Escala11")]
		private DataGridViewTextBoxColumn _REC_Escala11;

		// Token: 0x040002E0 RID: 736
		[AccessedThroughProperty("REC_Escala12")]
		private DataGridViewTextBoxColumn _REC_Escala12;

		// Token: 0x040002E1 RID: 737
		[AccessedThroughProperty("REC_Escala13")]
		private DataGridViewTextBoxColumn _REC_Escala13;

		// Token: 0x040002E2 RID: 738
		[AccessedThroughProperty("REC_Escala14")]
		private DataGridViewTextBoxColumn _REC_Escala14;

		// Token: 0x040002E3 RID: 739
		[AccessedThroughProperty("REC_Escala15")]
		private DataGridViewTextBoxColumn _REC_Escala15;

		// Token: 0x040002E4 RID: 740
		[AccessedThroughProperty("REC_Escala16")]
		private DataGridViewTextBoxColumn _REC_Escala16;

		// Token: 0x040002E5 RID: 741
		[AccessedThroughProperty("VC_Vista")]
		private DataGridViewTextBoxColumn _VC_Vista;

		// Token: 0x040002E6 RID: 742
		[AccessedThroughProperty("VC_Endereco")]
		private DataGridViewTextBoxColumn _VC_Endereco;

		// Token: 0x040002E7 RID: 743
		[AccessedThroughProperty("VR_Vista")]
		private DataGridViewTextBoxColumn _VR_Vista;

		// Token: 0x040002E8 RID: 744
		[AccessedThroughProperty("VR_End")]
		private DataGridViewTextBoxColumn _VR_End;

		// Token: 0x040002E9 RID: 745
		[AccessedThroughProperty("tb_lixo1")]
		private TextBox _tb_lixo1;

		// Token: 0x040002EA RID: 746
		[AccessedThroughProperty("tb_lixo2")]
		private TextBox _tb_lixo2;

		// Token: 0x040002EB RID: 747
		[AccessedThroughProperty("tb_lixo3")]
		private TextBox _tb_lixo3;

		// Token: 0x040002EC RID: 748
		[AccessedThroughProperty("tb_lixo4")]
		private TextBox _tb_lixo4;

		// Token: 0x040002ED RID: 749
		[AccessedThroughProperty("tb_lixo5")]
		private TextBox _tb_lixo5;

		// Token: 0x040002EE RID: 750
		[AccessedThroughProperty("tb_lixo6")]
		private TextBox _tb_lixo6;

		// Token: 0x040002EF RID: 751
		[AccessedThroughProperty("tb_lixo7")]
		private TextBox _tb_lixo7;
	}
}
