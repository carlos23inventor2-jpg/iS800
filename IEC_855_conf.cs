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
	// Token: 0x0200003B RID: 59
	[DesignerGenerated]
	public partial class IEC_855_conf : Form
	{
		// Token: 0x06000D25 RID: 3365 RVA: 0x002F9C2C File Offset: 0x002F802C
		public IEC_855_conf()
		{
			base.Load += new EventHandler(this.RT_810_conf_Load);
			base.Activated += new EventHandler(this.RT_810_conf_Activated);
			base.FormClosed += new FormClosedEventHandler(this.RT_810_conf_FormClosed);
			this.InitializeComponent();
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x002FC1BC File Offset: 0x002FA5BC
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x002FC1D0 File Offset: 0x002FA5D0
		internal virtual TabControl TabControl_810
		{
			get
			{
				return this._TabControl_810;
			}
			[MethodImpl(32)]
			set
			{
				this._TabControl_810 = value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000D2A RID: 3370 RVA: 0x002FC1DC File Offset: 0x002FA5DC
		// (set) Token: 0x06000D2B RID: 3371 RVA: 0x002FC1F0 File Offset: 0x002FA5F0
		internal virtual TabPage TabPage_geral
		{
			get
			{
				return this._TabPage_geral;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TabPage_geral_Click);
				if (this._TabPage_geral != null)
				{
					this._TabPage_geral.Click -= eventHandler;
				}
				this._TabPage_geral = value;
				if (this._TabPage_geral != null)
				{
					this._TabPage_geral.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x002FC23C File Offset: 0x002FA63C
		// (set) Token: 0x06000D2D RID: 3373 RVA: 0x002FC250 File Offset: 0x002FA650
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

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000D2E RID: 3374 RVA: 0x002FC25C File Offset: 0x002FA65C
		// (set) Token: 0x06000D2F RID: 3375 RVA: 0x002FC270 File Offset: 0x002FA670
		internal virtual TabPage TabPage_IP
		{
			get
			{
				return this._TabPage_IP;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_IP = value;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000D30 RID: 3376 RVA: 0x002FC27C File Offset: 0x002FA67C
		// (set) Token: 0x06000D31 RID: 3377 RVA: 0x002FC290 File Offset: 0x002FA690
		internal virtual ToolStrip ToolStri_RT_810
		{
			get
			{
				return this._ToolStri_RT_810;
			}
			[MethodImpl(32)]
			set
			{
				ToolStripItemClickedEventHandler toolStripItemClickedEventHandler = new ToolStripItemClickedEventHandler(this.ToolStri_RT_810_ItemClicked);
				if (this._ToolStri_RT_810 != null)
				{
					this._ToolStri_RT_810.ItemClicked -= toolStripItemClickedEventHandler;
				}
				this._ToolStri_RT_810 = value;
				if (this._ToolStri_RT_810 != null)
				{
					this._ToolStri_RT_810.ItemClicked += toolStripItemClickedEventHandler;
				}
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000D32 RID: 3378 RVA: 0x002FC2DC File Offset: 0x002FA6DC
		// (set) Token: 0x06000D33 RID: 3379 RVA: 0x002FC2F0 File Offset: 0x002FA6F0
		internal virtual ToolStripButton ToolStripButton_RT_810_Abrir
		{
			get
			{
				return this._ToolStripButton_RT_810_Abrir;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_810_Abrir_Click);
				if (this._ToolStripButton_RT_810_Abrir != null)
				{
					this._ToolStripButton_RT_810_Abrir.Click -= eventHandler;
				}
				this._ToolStripButton_RT_810_Abrir = value;
				if (this._ToolStripButton_RT_810_Abrir != null)
				{
					this._ToolStripButton_RT_810_Abrir.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x002FC33C File Offset: 0x002FA73C
		// (set) Token: 0x06000D35 RID: 3381 RVA: 0x002FC350 File Offset: 0x002FA750
		internal virtual ToolStripButton ToolStripButton_RT_810_Salvar
		{
			get
			{
				return this._ToolStripButton_RT_810_Salvar;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_810_Salvar_Click);
				if (this._ToolStripButton_RT_810_Salvar != null)
				{
					this._ToolStripButton_RT_810_Salvar.Click -= eventHandler;
				}
				this._ToolStripButton_RT_810_Salvar = value;
				if (this._ToolStripButton_RT_810_Salvar != null)
				{
					this._ToolStripButton_RT_810_Salvar.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x002FC39C File Offset: 0x002FA79C
		// (set) Token: 0x06000D37 RID: 3383 RVA: 0x002FC3B0 File Offset: 0x002FA7B0
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

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000D38 RID: 3384 RVA: 0x002FC3BC File Offset: 0x002FA7BC
		// (set) Token: 0x06000D39 RID: 3385 RVA: 0x002FC3D0 File Offset: 0x002FA7D0
		internal virtual ToolStripButton ToolStripButton_RT_810_Download
		{
			get
			{
				return this._ToolStripButton_RT_810_Download;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_810_Download_Click);
				if (this._ToolStripButton_RT_810_Download != null)
				{
					this._ToolStripButton_RT_810_Download.Click -= eventHandler;
				}
				this._ToolStripButton_RT_810_Download = value;
				if (this._ToolStripButton_RT_810_Download != null)
				{
					this._ToolStripButton_RT_810_Download.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x002FC41C File Offset: 0x002FA81C
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x002FC430 File Offset: 0x002FA830
		internal virtual ToolStripButton ToolStripButton_RT_810_Upload
		{
			get
			{
				return this._ToolStripButton_RT_810_Upload;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_810_Upload_Click);
				if (this._ToolStripButton_RT_810_Upload != null)
				{
					this._ToolStripButton_RT_810_Upload.Click -= eventHandler;
				}
				this._ToolStripButton_RT_810_Upload = value;
				if (this._ToolStripButton_RT_810_Upload != null)
				{
					this._ToolStripButton_RT_810_Upload.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x002FC47C File Offset: 0x002FA87C
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x002FC490 File Offset: 0x002FA890
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

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x002FC49C File Offset: 0x002FA89C
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x002FC4B0 File Offset: 0x002FA8B0
		internal virtual ToolStripProgressBar ToolStripProgressBar_RT_810
		{
			get
			{
				return this._ToolStripProgressBar_RT_810;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripProgressBar_RT_810 = value;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x002FC4BC File Offset: 0x002FA8BC
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x002FC4D0 File Offset: 0x002FA8D0
		internal virtual ToolStripTextBox ToolStripTextBox_RT_810_Msg
		{
			get
			{
				return this._ToolStripTextBox_RT_810_Msg;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripTextBox_RT_810_Msg = value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x002FC4DC File Offset: 0x002FA8DC
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x002FC4F0 File Offset: 0x002FA8F0
		internal virtual ToolStripButton ToolStripButton_RT_810_novo
		{
			get
			{
				return this._ToolStripButton_RT_810_novo;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_810_novo_Click);
				if (this._ToolStripButton_RT_810_novo != null)
				{
					this._ToolStripButton_RT_810_novo.Click -= eventHandler;
				}
				this._ToolStripButton_RT_810_novo = value;
				if (this._ToolStripButton_RT_810_novo != null)
				{
					this._ToolStripButton_RT_810_novo.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x002FC53C File Offset: 0x002FA93C
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x002FC550 File Offset: 0x002FA950
		internal virtual OpenFileDialog OpenFileDialog_RT_810
		{
			get
			{
				return this._OpenFileDialog_RT_810;
			}
			[MethodImpl(32)]
			set
			{
				this._OpenFileDialog_RT_810 = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x002FC55C File Offset: 0x002FA95C
		// (set) Token: 0x06000D47 RID: 3399 RVA: 0x002FC570 File Offset: 0x002FA970
		internal virtual SaveFileDialog SaveFileDialog_RT_810
		{
			get
			{
				return this._SaveFileDialog_RT_810;
			}
			[MethodImpl(32)]
			set
			{
				this._SaveFileDialog_RT_810 = value;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x002FC57C File Offset: 0x002FA97C
		// (set) Token: 0x06000D49 RID: 3401 RVA: 0x002FC590 File Offset: 0x002FA990
		internal virtual Timer Timer_limpa_MSG
		{
			get
			{
				return this._Timer_limpa_MSG;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer_limpa_MSG_Tick);
				if (this._Timer_limpa_MSG != null)
				{
					this._Timer_limpa_MSG.Tick -= eventHandler;
				}
				this._Timer_limpa_MSG = value;
				if (this._Timer_limpa_MSG != null)
				{
					this._Timer_limpa_MSG.Tick += eventHandler;
				}
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x002FC5DC File Offset: 0x002FA9DC
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x002FC5F0 File Offset: 0x002FA9F0
		internal virtual GroupBox GroupBox_ModoOperacao
		{
			get
			{
				return this._GroupBox_ModoOperacao;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_ModoOperacao = value;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x002FC5FC File Offset: 0x002FA9FC
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x002FC610 File Offset: 0x002FAA10
		internal virtual ComboBox ComboBox_Modo_Operacao
		{
			get
			{
				return this._ComboBox_Modo_Operacao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_metodo_operacao_SelectedIndexChanged);
				if (this._ComboBox_Modo_Operacao != null)
				{
					this._ComboBox_Modo_Operacao.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_Modo_Operacao = value;
				if (this._ComboBox_Modo_Operacao != null)
				{
					this._ComboBox_Modo_Operacao.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x002FC65C File Offset: 0x002FAA5C
		// (set) Token: 0x06000D4F RID: 3407 RVA: 0x002FC670 File Offset: 0x002FAA70
		internal virtual Label Label_MetodoOperacao
		{
			get
			{
				return this._Label_MetodoOperacao;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_MetodoOperacao = value;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x002FC67C File Offset: 0x002FAA7C
		// (set) Token: 0x06000D51 RID: 3409 RVA: 0x002FC690 File Offset: 0x002FAA90
		internal virtual GroupBox GroupBox_ED
		{
			get
			{
				return this._GroupBox_ED;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_ED = value;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x002FC69C File Offset: 0x002FAA9C
		// (set) Token: 0x06000D53 RID: 3411 RVA: 0x002FC6B0 File Offset: 0x002FAAB0
		internal virtual DataGridView DataGridView_RT810_ED
		{
			get
			{
				return this._DataGridView_RT810_ED;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_RT810_ED_CellValidating);
				EventHandler eventHandler = new EventHandler(this.DataGridView_RT810_ED_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_RT810_ED_CellValueChanged);
				if (this._DataGridView_RT810_ED != null)
				{
					this._DataGridView_RT810_ED.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_RT810_ED.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_RT810_ED.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_RT810_ED = value;
				if (this._DataGridView_RT810_ED != null)
				{
					this._DataGridView_RT810_ED.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_RT810_ED.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_RT810_ED.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x002FC748 File Offset: 0x002FAB48
		// (set) Token: 0x06000D55 RID: 3413 RVA: 0x002FC75C File Offset: 0x002FAB5C
		internal virtual ToolStripButton ToolStripButton_RT_810_Imprimir
		{
			get
			{
				return this._ToolStripButton_RT_810_Imprimir;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_810_Imprimir_Click);
				if (this._ToolStripButton_RT_810_Imprimir != null)
				{
					this._ToolStripButton_RT_810_Imprimir.Click -= eventHandler;
				}
				this._ToolStripButton_RT_810_Imprimir = value;
				if (this._ToolStripButton_RT_810_Imprimir != null)
				{
					this._ToolStripButton_RT_810_Imprimir.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x002FC7A8 File Offset: 0x002FABA8
		// (set) Token: 0x06000D57 RID: 3415 RVA: 0x002FC7BC File Offset: 0x002FABBC
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

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x002FC7C8 File Offset: 0x002FABC8
		// (set) Token: 0x06000D59 RID: 3417 RVA: 0x002FC7DC File Offset: 0x002FABDC
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

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x002FC874 File Offset: 0x002FAC74
		// (set) Token: 0x06000D5B RID: 3419 RVA: 0x002FC888 File Offset: 0x002FAC88
		internal virtual PrintPreviewDialog PrintPreviewDialog1
		{
			get
			{
				return this._PrintPreviewDialog1;
			}
			[MethodImpl(32)]
			set
			{
				this._PrintPreviewDialog1 = value;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x002FC894 File Offset: 0x002FAC94
		// (set) Token: 0x06000D5D RID: 3421 RVA: 0x002FC8A8 File Offset: 0x002FACA8
		internal virtual BindingSource RepetidoraBindingSource1
		{
			get
			{
				return this._RepetidoraBindingSource1;
			}
			[MethodImpl(32)]
			set
			{
				this._RepetidoraBindingSource1 = value;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x002FC8B4 File Offset: 0x002FACB4
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x002FC8C8 File Offset: 0x002FACC8
		internal virtual ToolStripLabel ToolStripLabel_ID
		{
			get
			{
				return this._ToolStripLabel_ID;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripLabel_ID = value;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x002FC8D4 File Offset: 0x002FACD4
		// (set) Token: 0x06000D61 RID: 3425 RVA: 0x002FC8E8 File Offset: 0x002FACE8
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

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x002FC8F4 File Offset: 0x002FACF4
		// (set) Token: 0x06000D63 RID: 3427 RVA: 0x002FC908 File Offset: 0x002FAD08
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

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x002FC914 File Offset: 0x002FAD14
		// (set) Token: 0x06000D65 RID: 3429 RVA: 0x002FC928 File Offset: 0x002FAD28
		internal virtual TextBox TextBox_equipamento
		{
			get
			{
				return this._TextBox_equipamento;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox_equipamento_TextChanged);
				if (this._TextBox_equipamento != null)
				{
					this._TextBox_equipamento.TextChanged -= eventHandler;
				}
				this._TextBox_equipamento = value;
				if (this._TextBox_equipamento != null)
				{
					this._TextBox_equipamento.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x002FC974 File Offset: 0x002FAD74
		// (set) Token: 0x06000D67 RID: 3431 RVA: 0x002FC988 File Offset: 0x002FAD88
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

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x002FC994 File Offset: 0x002FAD94
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x002FC9A8 File Offset: 0x002FADA8
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

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x002FC9B4 File Offset: 0x002FADB4
		// (set) Token: 0x06000D6B RID: 3435 RVA: 0x002FC9C8 File Offset: 0x002FADC8
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

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x002FC9D4 File Offset: 0x002FADD4
		// (set) Token: 0x06000D6D RID: 3437 RVA: 0x002FC9E8 File Offset: 0x002FADE8
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

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x002FC9F4 File Offset: 0x002FADF4
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x002FCA08 File Offset: 0x002FAE08
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

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x002FCA14 File Offset: 0x002FAE14
		// (set) Token: 0x06000D71 RID: 3441 RVA: 0x002FCA28 File Offset: 0x002FAE28
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

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x002FCA34 File Offset: 0x002FAE34
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x002FCA48 File Offset: 0x002FAE48
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

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x002FCA54 File Offset: 0x002FAE54
		// (set) Token: 0x06000D75 RID: 3445 RVA: 0x002FCA68 File Offset: 0x002FAE68
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

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x002FCA74 File Offset: 0x002FAE74
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x002FCA88 File Offset: 0x002FAE88
		internal virtual GroupBox GroupBox2
		{
			get
			{
				return this._GroupBox2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GroupBox2_Enter);
				if (this._GroupBox2 != null)
				{
					this._GroupBox2.Enter -= eventHandler;
				}
				this._GroupBox2 = value;
				if (this._GroupBox2 != null)
				{
					this._GroupBox2.Enter += eventHandler;
				}
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x002FCAD4 File Offset: 0x002FAED4
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x002FCAE8 File Offset: 0x002FAEE8
		internal virtual ComboBox ComboBox_baudrate
		{
			get
			{
				return this._ComboBox_baudrate;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_baudrate_COM1_810_SelectedIndexChanged);
				if (this._ComboBox_baudrate != null)
				{
					this._ComboBox_baudrate.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_baudrate = value;
				if (this._ComboBox_baudrate != null)
				{
					this._ComboBox_baudrate.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x002FCB34 File Offset: 0x002FAF34
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x002FCB48 File Offset: 0x002FAF48
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

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x002FCB54 File Offset: 0x002FAF54
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x002FCB68 File Offset: 0x002FAF68
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

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x002FCB74 File Offset: 0x002FAF74
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x002FCB88 File Offset: 0x002FAF88
		internal virtual TextBox tbMAC5
		{
			get
			{
				return this._tbMAC5;
			}
			[MethodImpl(32)]
			set
			{
				this._tbMAC5 = value;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x002FCB94 File Offset: 0x002FAF94
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x002FCBA8 File Offset: 0x002FAFA8
		internal virtual TextBox tbMAC4
		{
			get
			{
				return this._tbMAC4;
			}
			[MethodImpl(32)]
			set
			{
				this._tbMAC4 = value;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x002FCBB4 File Offset: 0x002FAFB4
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x002FCBC8 File Offset: 0x002FAFC8
		internal virtual TextBox tbMAC3
		{
			get
			{
				return this._tbMAC3;
			}
			[MethodImpl(32)]
			set
			{
				this._tbMAC3 = value;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x002FCBD4 File Offset: 0x002FAFD4
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x002FCBE8 File Offset: 0x002FAFE8
		internal virtual TextBox tbMAC2
		{
			get
			{
				return this._tbMAC2;
			}
			[MethodImpl(32)]
			set
			{
				this._tbMAC2 = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x002FCBF4 File Offset: 0x002FAFF4
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x002FCC08 File Offset: 0x002FB008
		internal virtual TextBox tbMAC1
		{
			get
			{
				return this._tbMAC1;
			}
			[MethodImpl(32)]
			set
			{
				this._tbMAC1 = value;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x002FCC14 File Offset: 0x002FB014
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x002FCC28 File Offset: 0x002FB028
		internal virtual TextBox tbMAC0
		{
			get
			{
				return this._tbMAC0;
			}
			[MethodImpl(32)]
			set
			{
				this._tbMAC0 = value;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x002FCC34 File Offset: 0x002FB034
		// (set) Token: 0x06000D8B RID: 3467 RVA: 0x002FCC48 File Offset: 0x002FB048
		internal virtual Label tbMAC
		{
			get
			{
				return this._tbMAC;
			}
			[MethodImpl(32)]
			set
			{
				this._tbMAC = value;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x002FCC54 File Offset: 0x002FB054
		// (set) Token: 0x06000D8D RID: 3469 RVA: 0x002FCC68 File Offset: 0x002FB068
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

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x002FCC74 File Offset: 0x002FB074
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x002FCC88 File Offset: 0x002FB088
		internal virtual TextBox tb_dhcp_sm
		{
			get
			{
				return this._tb_dhcp_sm;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_dhcp_sm = value;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x002FCC94 File Offset: 0x002FB094
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x002FCCA8 File Offset: 0x002FB0A8
		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label3_Click);
				if (this._Label3 != null)
				{
					this._Label3.Click -= eventHandler;
				}
				this._Label3 = value;
				if (this._Label3 != null)
				{
					this._Label3.Click += eventHandler;
				}
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x002FCCF4 File Offset: 0x002FB0F4
		// (set) Token: 0x06000D93 RID: 3475 RVA: 0x002FCD08 File Offset: 0x002FB108
		internal virtual TextBox tb_dhcp_gw
		{
			get
			{
				return this._tb_dhcp_gw;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_dhcp_gw = value;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x002FCD14 File Offset: 0x002FB114
		// (set) Token: 0x06000D95 RID: 3477 RVA: 0x002FCD28 File Offset: 0x002FB128
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

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x002FCD34 File Offset: 0x002FB134
		// (set) Token: 0x06000D97 RID: 3479 RVA: 0x002FCD48 File Offset: 0x002FB148
		internal virtual TextBox tb_dhcp_ip
		{
			get
			{
				return this._tb_dhcp_ip;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.tb_dhcp_ip_TextChanged);
				if (this._tb_dhcp_ip != null)
				{
					this._tb_dhcp_ip.TextChanged -= eventHandler;
				}
				this._tb_dhcp_ip = value;
				if (this._tb_dhcp_ip != null)
				{
					this._tb_dhcp_ip.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x002FCD94 File Offset: 0x002FB194
		// (set) Token: 0x06000D99 RID: 3481 RVA: 0x002FCDA8 File Offset: 0x002FB1A8
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

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x002FCDB4 File Offset: 0x002FB1B4
		// (set) Token: 0x06000D9B RID: 3483 RVA: 0x002FCDC8 File Offset: 0x002FB1C8
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

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x002FCDD4 File Offset: 0x002FB1D4
		// (set) Token: 0x06000D9D RID: 3485 RVA: 0x002FCDE8 File Offset: 0x002FB1E8
		internal virtual TextBox tb_static_sm
		{
			get
			{
				return this._tb_static_sm;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.tb_static_sm_TextChanged);
				if (this._tb_static_sm != null)
				{
					this._tb_static_sm.TextChanged -= eventHandler;
				}
				this._tb_static_sm = value;
				if (this._tb_static_sm != null)
				{
					this._tb_static_sm.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x002FCE34 File Offset: 0x002FB234
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x002FCE48 File Offset: 0x002FB248
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

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x002FCE54 File Offset: 0x002FB254
		// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x002FCE68 File Offset: 0x002FB268
		internal virtual TextBox tb_static_gw
		{
			get
			{
				return this._tb_static_gw;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.tb_static_gw_TextChanged);
				if (this._tb_static_gw != null)
				{
					this._tb_static_gw.TextChanged -= eventHandler;
				}
				this._tb_static_gw = value;
				if (this._tb_static_gw != null)
				{
					this._tb_static_gw.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x002FCEB4 File Offset: 0x002FB2B4
		// (set) Token: 0x06000DA3 RID: 3491 RVA: 0x002FCEC8 File Offset: 0x002FB2C8
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

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x002FCED4 File Offset: 0x002FB2D4
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x002FCEE8 File Offset: 0x002FB2E8
		internal virtual TextBox tb_static_ip
		{
			get
			{
				return this._tb_static_ip;
			}
			[MethodImpl(32)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.tb_static_ip_KeyPress);
				EventHandler eventHandler = new EventHandler(this.tb_static_ip_TextChanged);
				if (this._tb_static_ip != null)
				{
					this._tb_static_ip.KeyPress -= keyPressEventHandler;
					this._tb_static_ip.TextChanged -= eventHandler;
				}
				this._tb_static_ip = value;
				if (this._tb_static_ip != null)
				{
					this._tb_static_ip.KeyPress += keyPressEventHandler;
					this._tb_static_ip.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x002FCF58 File Offset: 0x002FB358
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x002FCF6C File Offset: 0x002FB36C
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

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x002FCF78 File Offset: 0x002FB378
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x002FCF8C File Offset: 0x002FB38C
		internal virtual DataGridViewTextBoxColumn ip
		{
			get
			{
				return this._ip;
			}
			[MethodImpl(32)]
			set
			{
				this._ip = value;
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x002FCF98 File Offset: 0x002FB398
		private void AtivaEfeitoOnChangeValue()
		{
			this.ToolStri_RT_810.Enabled = false;
			this.ToolStri_RT_810.Enabled = true;
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x002FCFB4 File Offset: 0x002FB3B4
		public void Cria_ListaBaudRate()
		{
			perifericos.ListaBaudRate_IEC855.Clear();
			perifericos.ListaBaudRate_IEC855.Add(new perifericos.Valores_ComboBox("1200", "1200", 21856, false));
			perifericos.ListaBaudRate_IEC855.Add(new perifericos.Valores_ComboBox("9600", "9600", 21857, true));
			perifericos.ListaBaudRate_IEC855.Add(new perifericos.Valores_ComboBox("19200", "19200", 21858, false));
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x002FD028 File Offset: 0x002FB428
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

		// Token: 0x06000DAD RID: 3501 RVA: 0x002FD094 File Offset: 0x002FB494
		private void RT_810_conf_Load(object sender, EventArgs e)
		{
			RT_geral.Lmte_Init_ok = false;
			perifericos.Cria_ListaBaudRate_IEC855();
			checked
			{
				RT_geral.IEC_855_BD.BaudRateCOM1.valores = new int[perifericos.ListaBaudRate_IEC855.Count + 1];
				RT_geral.IEC_855_BD.BaudRateCOM1.itens = new string[perifericos.ListaBaudRate_IEC855.Count + 1];
				RT_geral.IEC_855_BD.AtribuicaoIP.valores = new int[3];
				RT_geral.IEC_855_BD.AtribuicaoIP.itens = new string[3];
				RT_geral.IEC_855_BD.tab_ips = new string[201];
				RT_geral.IEC_855_BD.MAC = new byte[7];
				this.Inicializa_DadosEStrutura855_Padrao();
				RT_geral.Lmte_Init_ok = true;
				this.GeraDataGridView_IP();
				ComboBox comboBox = this.ComboBox_Modo_Operacao;
				Linha_RT.CarregaCombo(ref comboBox, RT_geral.IEC_855_BD.AtribuicaoIP);
				this.ComboBox_Modo_Operacao = comboBox;
				comboBox = this.ComboBox_baudrate;
				Linha_RT.CarregaCombo(ref comboBox, RT_geral.IEC_855_BD.BaudRateCOM1);
				this.ComboBox_baudrate = comboBox;
				this.Inicializa_DadosEStrutura855_Default();
				Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
				this.TabPage_geral.BackColor = Color.FromKnownColor(8);
				this.TabPage_geral.ForeColor = Color.FromKnownColor(10);
				this.TabPage_IP.BackColor = Color.FromKnownColor(8);
				this.TabPage_IP.ForeColor = Color.FromKnownColor(10);
				string text = ".\\\\Fontes\\\\Ictel Extendida Italic.ttf";
				if (MyProject.Computer.FileSystem.FileExists(text))
				{
					PrivateFontCollection privateFontCollection = new PrivateFontCollection();
					privateFontCollection.AddFontFile(text);
					Font font = new Font(privateFontCollection.Families[0], 8f, 2);
					Font font2 = new Font(privateFontCollection.Families[0], 18f, 2);
					this.Label26.Font = font;
					this.Label17.Font = font;
					this.TextBox_equipamento.Font = font;
					this.TextBox_versao.Font = font;
					this.TextBox_build.Font = font;
					this.TextBox_release.Font = font;
					this.tbMAC.Font = font;
					this.tbMAC0.Font = this.tbMAC.Font;
					this.tbMAC1.Font = this.tbMAC.Font;
					this.tbMAC2.Font = this.tbMAC.Font;
					this.tbMAC3.Font = this.tbMAC.Font;
					this.tbMAC4.Font = this.tbMAC.Font;
					this.tbMAC5.Font = this.tbMAC.Font;
					this.ToolStripLabel_ID.Font = font2;
				}
				else
				{
					MessageBox.Show("Removido fonte Ictel Extendida Italic da pasta da aplicação!");
				}
				this.Atualiza_Tela855();
				this.ToolStripLabel_ID.Text = RT_geral.MontaNomePlacaPeloFabricante(RT_geral.IEC_855_BD.Equip.Valor, RT_geral.IEC_855_BD.Versao.Valor);
				RT_geral.Lmte_Init_ok = true;
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x002FD364 File Offset: 0x002FB764
		private void RT_810_conf_Activated(object sender, EventArgs e)
		{
			Geral.Equipamento_selecionado = (HorizontalAlignment)855;
			Geral.Equipamento_versao = (HorizontalAlignment)3;
			Geral.Equipamento_build = (HorizontalAlignment)0;
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x002FD37C File Offset: 0x002FB77C
		private void GeraDataGridView_IP()
		{
			this.DataGridView_RT810_ED.ScrollBars = (HorizontalAlignment)2;
			this.DataGridView_RT810_ED.RowCount = (HorizontalAlignment)200;
			this.DataGridView_RT810_ED.RowHeadersWidth = (HorizontalAlignment)80;
			int num = (HorizontalAlignment)1;
			checked
			{
				try
				{
					foreach (object obj in this.DataGridView_RT810_ED.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "End " + Conversions.ToString(num);
							num++;
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

		// Token: 0x06000DB0 RID: 3504 RVA: 0x002FD42C File Offset: 0x002FB82C
		public void Inicializa_DadosEStrutura855_Padrao()
		{
			RT_geral.IEC_855_BD.Versao.nome = "Versão";
			RT_geral.IEC_855_BD.Versao.Padrao = (HorizontalAlignment)0;
			RT_geral.IEC_855_BD.Build.nome = "Build";
			RT_geral.IEC_855_BD.Build.Padrao = (HorizontalAlignment)0;
			RT_geral.IEC_855_BD.Release.nome = "Release";
			RT_geral.IEC_855_BD.Release.Padrao = (HorizontalAlignment)0;
			RT_geral.IEC_855_BD.Equip.nome = "Tipo equipamento";
			RT_geral.IEC_855_BD.Equip.Padrao = (HorizontalAlignment)0;
			RT_geral.IEC_855_BD.MAC[0] = (HorizontalAlignment)0;
			RT_geral.IEC_855_BD.MAC[1] = (HorizontalAlignment)0;
			RT_geral.IEC_855_BD.MAC[2] = (HorizontalAlignment)0;
			RT_geral.IEC_855_BD.MAC[3] = (HorizontalAlignment)0;
			RT_geral.IEC_855_BD.MAC[4] = (HorizontalAlignment)0;
			RT_geral.IEC_855_BD.MAC[5] = (HorizontalAlignment)0;
			RT_geral.IEC_855_BD.DHCP_IP = "0.0.0.0";
			RT_geral.IEC_855_BD.DHCP_GW = "0.0.0.0";
			RT_geral.IEC_855_BD.DHCP_SM = "0.0.0.0";
			RT_geral.IEC_855_BD.STATIC_IP = "0.0.0.0";
			RT_geral.IEC_855_BD.STATIC_GW = "0.0.0.0";
			RT_geral.IEC_855_BD.STATIC_SM = "0.0.0.0";
			int i = (HorizontalAlignment)0;
			checked
			{
				do
				{
					RT_geral.IEC_855_BD.tab_ips[i] = "0.0.0.0";
					i++;
				}
				while (i <= 199);
				RT_geral.IEC_855_BD.AtribuicaoIP.nome = "Atribuicao IP";
				RT_geral.IEC_855_BD.AtribuicaoIP.Indice_padrao = (HorizontalAlignment)1;
				RT_geral.IEC_855_BD.AtribuicaoIP.Numero_itens = (HorizontalAlignment)2;
				RT_geral.IEC_855_BD.AtribuicaoIP.valores[0] = (HorizontalAlignment)43690;
				RT_geral.IEC_855_BD.AtribuicaoIP.valores[1] = (HorizontalAlignment)21845;
				RT_geral.IEC_855_BD.AtribuicaoIP.itens[0] = "Static - Fixo";
				RT_geral.IEC_855_BD.AtribuicaoIP.itens[1] = "Dinamic - DHCP";
				RT_geral.IEC_855_BD.BaudRateCOM1.nome = "BaudRate COM1";
				RT_geral.IEC_855_BD.BaudRateCOM1.Indice_padrao = perifericos.Lista_GetIndicePadrao(perifericos.ListaBaudRate_IEC855);
				RT_geral.IEC_855_BD.BaudRateCOM1.Numero_itens = perifericos.ListaBaudRate_IEC855.Count;
				int num = (HorizontalAlignment)0;
				int num2 = RT_geral.IEC_855_BD.BaudRateCOM1.Numero_itens - 1;
				for (i = num; i <= num2; i++)
				{
					RT_geral.IEC_855_BD.BaudRateCOM1.valores[i] = perifericos.ListaBaudRate_IEC855[i].valor;
					RT_geral.IEC_855_BD.BaudRateCOM1.itens[i] = perifericos.ListaBaudRate_IEC855[i].nome;
				}
				RT_geral.IEC_855_BD.filename = "";
			}
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x002FD6D4 File Offset: 0x002FBAD4
		public void Inicializa_DadosEStrutura855_Default()
		{
			RT_geral.IEC_855_BD.Equip.Valor = RT_geral.IEC_855_BD.Equip.Padrao;
			RT_geral.IEC_855_BD.Versao.Valor = RT_geral.IEC_855_BD.Versao.Padrao;
			RT_geral.IEC_855_BD.Build.Valor = RT_geral.IEC_855_BD.Build.Padrao;
			RT_geral.IEC_855_BD.Release.Valor = RT_geral.IEC_855_BD.Release.Padrao;
			RT_geral.IEC_855_BD.End_estacao.Valor = RT_geral.IEC_855_BD.End_estacao.Padrao;
			RT_geral.IEC_855_BD.End_mestre.Valor = RT_geral.IEC_855_BD.End_mestre.Padrao;
			RT_geral.IEC_855_BD.Tempo_ptt.Valor = RT_geral.IEC_855_BD.Tempo_ptt.Padrao;
			RT_geral.IEC_855_BD.Intervalo_tx_pto_pto.Valor = RT_geral.IEC_855_BD.Intervalo_tx_pto_pto.Padrao;
			RT_geral.IEC_855_BD.AtribuicaoIP.Indice = RT_geral.IEC_855_BD.AtribuicaoIP.Indice_padrao;
			RT_geral.IEC_855_BD.AtribuicaoIP.Valor = RT_geral.IEC_855_BD.AtribuicaoIP.valores[RT_geral.IEC_855_BD.AtribuicaoIP.Indice];
			RT_geral.IEC_855_BD.BaudRateCOM1.Indice = (HorizontalAlignment)1;
			RT_geral.IEC_855_BD.BaudRateCOM1.Valor = RT_geral.IEC_855_BD.BaudRateCOM1.valores[RT_geral.IEC_855_BD.BaudRateCOM1.Indice];
			int num = (HorizontalAlignment)0;
			checked
			{
				do
				{
					RT_geral.IEC_855_BD.tab_ips[num] = "0.0.0.0";
					num++;
				}
				while (num <= 199);
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x002FD87C File Offset: 0x002FBC7C
		public void Atualiza_Tela855()
		{
			checked
			{
				int num;
				int num3;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = (HorizontalAlignment)2;
					this.Libera_acoes();
					this.TextBox_equipamento.Text = RT_geral.IEC_855_BD.Equip.Valor.ToString();
					this.TextBox_versao.Text = RT_geral.IEC_855_BD.Versao.Valor.ToString();
					this.TextBox_build.Text = RT_geral.IEC_855_BD.Build.Valor.ToString();
					this.TextBox_release.Text = RT_geral.IEC_855_BD.Release.Valor.ToString();
					this.tbMAC0.Text = Conversion.Hex(RT_geral.IEC_855_BD.MAC[0]);
					this.tbMAC1.Text = Conversion.Hex(RT_geral.IEC_855_BD.MAC[1]);
					this.tbMAC2.Text = Conversion.Hex(RT_geral.IEC_855_BD.MAC[2]);
					this.tbMAC3.Text = Conversion.Hex(RT_geral.IEC_855_BD.MAC[3]);
					this.tbMAC4.Text = Conversion.Hex(RT_geral.IEC_855_BD.MAC[4]);
					this.tbMAC5.Text = Conversion.Hex(RT_geral.IEC_855_BD.MAC[5]);
					this.ComboBox_baudrate.SelectedIndex = RT_geral.IEC_855_BD.BaudRateCOM1.Indice;
					this.ComboBox_Modo_Operacao.SelectedIndex = RT_geral.IEC_855_BD.AtribuicaoIP.Indice;
					this.tb_dhcp_ip.Text = RT_geral.IEC_855_BD.DHCP_IP;
					this.tb_dhcp_gw.Text = RT_geral.IEC_855_BD.DHCP_GW;
					this.tb_dhcp_sm.Text = RT_geral.IEC_855_BD.DHCP_SM;
					this.tb_static_ip.Text = RT_geral.IEC_855_BD.STATIC_IP;
					this.tb_static_gw.Text = RT_geral.IEC_855_BD.STATIC_GW;
					this.tb_static_sm.Text = RT_geral.IEC_855_BD.STATIC_SM;
					int num2 = (HorizontalAlignment)0;
					do
					{
						this.DataGridView_RT810_ED.Rows[num2].Cells[0].Value = RT_geral.IEC_855_BD.tab_ips[num2];
						num2++;
					}
					while (num2 <= 199);
					goto IL_275;
					IL_220:
					Interaction.MsgBox("Erro na atualização da tela!", (MsgBoxStyle)32, "Atenção - Erro de dados");
					goto IL_275;
					IL_234:
					num3 = -1;
										IL_248:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num3 == (DialogResult)0))
				{
					Exception ex = (Exception)obj2;
					goto IL_234;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_275:
				if (num3 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x002FDB24 File Offset: 0x002FBF24
		public void Habilita_Funcoes_de_Tela_RT_810(int tipo)
		{
			this.GroupBox_informacoes.Enabled = false;
			this.GroupBox_ModoOperacao.Enabled = false;
			this.GroupBox_ED.Enabled = false;
			switch (tipo)
			{
			case 0:
				this.GroupBox_informacoes.Enabled = true;
				this.GroupBox_ModoOperacao.Enabled = true;
				this.GroupBox_ED.Enabled = true;
				break;
			}
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x002FDB90 File Offset: 0x002FBF90
		public void RT_810_Atualiza_Parametros_EA(int tipo)
		{
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x002FDB94 File Offset: 0x002FBF94
		public void RT_810_Habilita_Pto_a_Pto(int modo)
		{
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x002FDB98 File Offset: 0x002FBF98
		public void AtualizaMsgTela_RT_810(string texto, int cor)
		{
			this.ToolStripTextBox_RT_810_Msg.Text = texto;
			if (cor == (DialogResult)0)
			{
				this.ToolStripTextBox_RT_810_Msg.ForeColor = Color.Blue;
			}
			else if (cor == (DialogResult)1)
			{
				this.ToolStripProgressBar_RT_810.Value = (HorizontalAlignment)0;
				this.ToolStripTextBox_RT_810_Msg.ForeColor = Color.Red;
			}
			else
			{
				this.ToolStripTextBox_RT_810_Msg.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x002FDBFC File Offset: 0x002FBFFC
		public void EncerraEdicaoDeCampos()
		{
			this.DataGridView_RT810_ED.EndEdit();
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x002FDC0C File Offset: 0x002FC00C
		public void Bloqueia_acoes()
		{
			this.ToolStripButton_RT_810_Abrir.Enabled = false;
			this.ToolStripButton_RT_810_novo.Enabled = false;
			this.ToolStripButton_RT_810_Salvar.Enabled = false;
			this.ToolStripButton_RT_810_Download.Enabled = false;
			this.ToolStripButton_RT_810_Upload.Enabled = false;
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x002FDC4C File Offset: 0x002FC04C
		public void Libera_acoes()
		{
			this.ToolStripButton_RT_810_Abrir.Enabled = true;
			this.ToolStripButton_RT_810_novo.Enabled = true;
			this.ToolStripButton_RT_810_Salvar.Enabled = true;
			if (Comunicacao.Config_sistema.tipo_interface == (DialogResult)1)
			{
				if (Geral.Config_geral.Porta_serial_Ok)
				{
					this.ToolStripButton_RT_810_Download.Enabled = true;
					this.ToolStripButton_RT_810_Upload.Enabled = true;
				}
				else
				{
					this.ToolStripButton_RT_810_Download.Enabled = false;
					this.ToolStripButton_RT_810_Upload.Enabled = false;
				}
			}
			else if (Comunicacao.Config_sistema.tipo_interface == (DialogResult)2)
			{
				this.ToolStripButton_RT_810_Download.Enabled = true;
				this.ToolStripButton_RT_810_Upload.Enabled = true;
			}
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x002FDCF0 File Offset: 0x002FC0F0
		public void InicializaBarraProgressoTela_RT_810(int num_passos)
		{
			this.ToolStripProgressBar_RT_810.Minimum = (HorizontalAlignment)0;
			this.ToolStripProgressBar_RT_810.Maximum = checked(num_passos * 4);
			this.ToolStripProgressBar_RT_810.Step = num_passos;
			this.ToolStripProgressBar_RT_810.Value = (HorizontalAlignment)0;
			this.ToolStripProgressBar_RT_810.BackColor = Color.LightGray;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x002FDD40 File Offset: 0x002FC140
		private void Timer_limpa_MSG_Tick(object sender, EventArgs e)
		{
			this.Timer_limpa_MSG.Enabled = false;
			this.AtualizaMsgTela_RT_810("", 0);
			this.ToolStripProgressBar_RT_810.Value = (HorizontalAlignment)0;
			this.Libera_acoes();
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x002FDD6C File Offset: 0x002FC16C
		private void CheckBox_hab_eletrodos_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x002FDD70 File Offset: 0x002FC170
		private void ComboBox_metodo_operacao_Validating(object sender, CancelEventArgs e)
		{
			if (this.ComboBox_Modo_Operacao.FindStringExact(this.ComboBox_Modo_Operacao.Text) == -1)
			{
				Interaction.MsgBox("Opção digitada não existe!\r\nAssumindo Default!", (MsgBoxStyle)32, "Atenção - Método Operação");
				this.ComboBox_Modo_Operacao.SelectedIndex = (HorizontalAlignment)0;
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x002FDDAC File Offset: 0x002FC1AC
		private void ComboBox_metodo_operacao_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.IEC_855_BD.AtribuicaoIP.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.IEC_855_BD.AtribuicaoIP.Valor = RT_geral.IEC_855_BD.AtribuicaoIP.valores[RT_geral.IEC_855_BD.AtribuicaoIP.Indice];
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 1, false))
			{
				this.tb_static_ip.ReadOnly = true;
				this.tb_static_gw.ReadOnly = true;
				this.tb_static_sm.ReadOnly = true;
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 0, false))
			{
				this.tb_static_ip.ReadOnly = false;
				this.tb_static_gw.ReadOnly = false;
				this.tb_static_sm.ReadOnly = false;
			}
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x002FDEA0 File Offset: 0x002FC2A0
		private void ComboBox_modo_repeticao_RT_810_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x002FDEA4 File Offset: 0x002FC2A4
		private void ComboBox_modo_simulado_810_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x002FDEA8 File Offset: 0x002FC2A8
		private void ComboBox_RT810_ED_Validating(object sender, CancelEventArgs e)
		{
			Type type = null;
			string text = "FindStringExact";
			object[] array = new object[]
			{
				RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null))
			};
			object[] array2 = array;
			string[] array3 = null;
			Type[] array4 = null;
			bool[] array5 = new bool[]
			{
				true
			};
			object obj = NewLateBinding.LateGet(sender, type, text, array2, array3, array4, array5);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(sender, null, "Text", new object[]
				{
					RuntimeHelpers.GetObjectValue(array[0])
				}, null, null, true, false);
			}
			if (Operators.ConditionalCompareObjectEqual(obj, -1, false))
			{
				Interaction.MsgBox("Opção digitada não existe!\r\nAssumindo Default!", (MsgBoxStyle)32, "Atenção - Entrada digital " + Conversion.Str(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "ValueMember", new object[0], null, null, null))));
				NewLateBinding.LateSet(sender, null, "SelectedIndex", new object[]
				{
					0
				}, null, null);
			}
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x002FDF8C File Offset: 0x002FC38C
		private void NumericUpDown_intervalo_tx_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.IEC_855_BD.Intervalo_tx_pto_pto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.IEC_855_BD.Intervalo_tx_pto_pto, true);
			sender = numericUpDown;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x002FDFE0 File Offset: 0x002FC3E0
		private void NumericUpDown_temp_ptt_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.IEC_855_BD.Tempo_ptt.Valor = Conversions.ToInteger(Operators.MultiplyObject(Operators.IntDivideObject(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null), 10), 10));
			NewLateBinding.LateSet(sender, null, "value", new object[]
			{
				RT_geral.IEC_855_BD.Tempo_ptt.Valor
			}, null, null);
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.IEC_855_BD.Tempo_ptt, true);
			sender = numericUpDown;
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x002FE078 File Offset: 0x002FC478
		private void NumericUpDown_end_mestre_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.IEC_855_BD.End_mestre.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.IEC_855_BD.End_mestre, true);
			sender = numericUpDown;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x002FE0CC File Offset: 0x002FC4CC
		private void NumericUpDown_end_est_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.IEC_855_BD.End_estacao.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.IEC_855_BD.End_estacao, true);
			sender = numericUpDown;
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x002FE120 File Offset: 0x002FC520
		private void NumericUpDown_intervalo_filtro_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.IEC_855_BD.AD_Intervalo.Valor = Conversions.ToInteger(Operators.MultiplyObject(Operators.IntDivideObject(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null), 10), 10));
			NewLateBinding.LateSet(sender, null, "value", new object[]
			{
				RT_geral.IEC_855_BD.AD_Intervalo.Valor
			}, null, null);
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.IEC_855_BD.AD_Intervalo, true);
			sender = numericUpDown;
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x002FE1B8 File Offset: 0x002FC5B8
		private void NumericUpDown_tamanho_filtro_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.IEC_855_BD.AD_Tamanho_filtro.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.IEC_855_BD.AD_Tamanho_filtro, true);
			sender = numericUpDown;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x002FE20C File Offset: 0x002FC60C
		private void NumericUpDown_end_rep_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x002FE210 File Offset: 0x002FC610
		private void NumericUpDown_num_est_rep_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x002FE214 File Offset: 0x002FC614
		private bool Entrada_Digital_Ja_Utilizada(int entrada, int num_ED)
		{
			bool result;
			return result;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x002FE224 File Offset: 0x002FC624
		private void RT_810_conf_FormClosed(object sender, FormClosedEventArgs e)
		{
			RT_geral.Telas_RT_810.Configuracao = false;
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x002FE234 File Offset: 0x002FC634
		private bool Endereco_Repetidora_Ja_Existente(ref DataGridView obj, ref RT_geral.Integer_ictel dado, DataGridViewCellValidatingEventArgs e, int posicao)
		{
			bool result;
			return result;
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x002FE244 File Offset: 0x002FC644
		public void Leitura_IER_856_conf()
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = (HorizontalAlignment)1;
			Comunicacao.Ctrl_Com.Cont_rx = (HorizontalAlignment)0;
			this.InicializaBarraProgressoTela_RT_810(7);
			this.AtualizaMsgTela_RT_810("Identificando equipamento - Passo 1", 2);
			if (!Mod_MD.Leitura_pagina_multi_interface(0, 255, 7).Status)
			{
				this.AtualizaMsgTela_RT_810("Equipamento não responde", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Linha_RT.VerificaSeEquipamentoEValido(2, 0, 0, 0, 0, "").Status)
			{
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_IEC_855(0);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 2", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			Application.DoEvents();
			if (!Mod_MD.Leitura_pagina_multi_interface(512, 255, 2).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_IEC_855(512);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 3", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			Application.DoEvents();
			if (!Mod_MD.Leitura_pagina_multi_interface(1024, 255, 12).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_IEC_855(1024);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 4", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			Application.DoEvents();
			if (!Mod_MD.Leitura_pagina_multi_interface(1536, 255, 100).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_IEC_855(1536);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 5", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			Application.DoEvents();
			if (!Mod_MD.Leitura_pagina_multi_interface(2048, 255, 100).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_IEC_855(2048);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 6", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			Application.DoEvents();
			if (!Mod_MD.Leitura_pagina_multi_interface(2560, 255, 100).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_IEC_855(2560);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 7", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			Application.DoEvents();
			if (!Mod_MD.Leitura_pagina_multi_interface(3072, 255, 100).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_IEC_855(3072);
			this.Atualiza_Tela855();
			this.AtualizaMsgTela_RT_810("Configuração lida com sucesso", 0);
			this.ToolStripProgressBar_RT_810.PerformStep();
			Application.DoEvents();
			this.Timer_limpa_MSG.Enabled = true;
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x002FE520 File Offset: 0x002FC920
		public void Gravar_IEC_855_conf()
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = (HorizontalAlignment)1;
			Comunicacao.Ctrl_Com.Cont_rx = (HorizontalAlignment)0;
			this.InicializaBarraProgressoTela_RT_810(6);
			this.AtualizaMsgTela_RT_810("Verificando equipamento - Passo 1", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(0, 255, 7).Status)
			{
				this.AtualizaMsgTela_RT_810("Equipamento não responde", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Linha_RT.VerificaSeEquipamentoEValido(2, 0, 0, 0, 0, "");
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_810(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_IEC_855(0);
			this.AtualizaMsgTela_RT_810("Habilitando gravação - Passo 2", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Controle_escrita_multi_interface(21845).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro ao habilitar gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_810("Gravando configuração - Passo 3", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Escrita_pagina_multi_interface(512, 80).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Controle_escrita_multi_interface(21930).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro durante a gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_810("Habilitando gravação - Passo 4", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Controle_escrita_multi_interface(21845).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro ao habilitar gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_810("Gravando configuração - Passo 3", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Escrita_pagina_multi_interface(1024, 80).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Controle_escrita_multi_interface(21930).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro durante a gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Controle_escrita_multi_interface(21845).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro ao habilitar gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_810("Gravando configuração - Passo 3", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Escrita_pagina_multi_interface(1536, 80).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Controle_escrita_multi_interface(21930).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro durante a gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Controle_escrita_multi_interface(21845).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro ao habilitar gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Escrita_pagina_multi_interface(2048, 80).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Controle_escrita_multi_interface(21930).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro durante a gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Controle_escrita_multi_interface(21845).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro ao habilitar gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Escrita_pagina_multi_interface(2560, 80).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Controle_escrita_multi_interface(21930).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro durante a gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Controle_escrita_multi_interface(21845).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro ao habilitar gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Escrita_pagina_multi_interface(3072, 80).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Controle_escrita_multi_interface(21930).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro durante a gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_810("Programação executada com sucesso", 0);
			this.ToolStripProgressBar_RT_810.PerformStep();
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x002FE990 File Offset: 0x002FCD90
		private void ToolStripButton_RT_810_Download_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.Config_sistema.tipo_interface == (DialogResult)1)
			{
				if (Comunicacao.VerificaPortaSerialExiste())
				{
					this.Bloqueia_acoes();
					this.EncerraEdicaoDeCampos();
					this.Leitura_IER_856_conf();
				}
				else
				{
					Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
				}
			}
			else if (Comunicacao.Config_sistema.tipo_interface == (DialogResult)2)
			{
				this.Bloqueia_acoes();
				this.EncerraEdicaoDeCampos();
				this.Leitura_IER_856_conf();
			}
			else
			{
				Interaction.MsgBox("Não existe definição de tipo de interface de comunicação!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
			}
			Comunicacao.Config_sistema.endereco_encontrado = false;
			Comunicacao.Config_sistema.endereco_modbus = (HorizontalAlignment)0;
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x002FEA28 File Offset: 0x002FCE28
		private void ToolStripButton_RT_810_novo_Click(object sender, EventArgs e)
		{
			RT_geral.Lmte_Init_ok = false;
			this.AtivaEfeitoOnChangeValue();
			this.Inicializa_DadosEStrutura855_Padrao();
			this.Inicializa_DadosEStrutura855_Default();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			RT_geral.IEC_855_BD.filename = "";
			this.Atualiza_Tela855();
			RT_geral.Lmte_Init_ok = true;
			this.AtualizaMsgTela_RT_810("Valores Default carregados", 0);
			this.Timer_limpa_MSG.Enabled = true;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x002FEA90 File Offset: 0x002FCE90
		private void ToolStripButton_RT_810_Upload_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.Config_sistema.tipo_interface == (DialogResult)1)
			{
				if (Comunicacao.VerificaPortaSerialExiste())
				{
					this.Bloqueia_acoes();
					this.EncerraEdicaoDeCampos();
					if (!RT_geral.VerificaExixtenciaErroDados_IEC855())
					{
						this.Gravar_IEC_855_conf();
					}
					else
					{
						string text = "Existem parâmetros não compatíveis com o equipamento!\r\nGravação dos parâmetros foi cancelada.";
						Interaction.MsgBox(text, (MsgBoxStyle)16, "Atenção - Valor fora das especificações");
						this.ToolStripButton_RT_810_Salvar.Enabled = true;
					}
				}
				else
				{
					Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
				}
				this.Timer_limpa_MSG.Enabled = true;
			}
			else if (Comunicacao.Config_sistema.tipo_interface == (DialogResult)2)
			{
				this.Bloqueia_acoes();
				this.EncerraEdicaoDeCampos();
				if (!RT_geral.VerificaExixtenciaErroDados_IEC855())
				{
					this.Gravar_IEC_855_conf();
				}
				else
				{
					string text = "Existem parâmetros não compatíveis com o equipamento!\r\nGravação dos parâmetros foi cancelada.";
					Interaction.MsgBox(text, (MsgBoxStyle)16, "Atenção - Valor fora das especificações");
					this.ToolStripButton_RT_810_Salvar.Enabled = true;
				}
				this.Timer_limpa_MSG.Enabled = true;
			}
			else
			{
				Interaction.MsgBox("Não existe definição de tipo de interface de comunicação!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
			}
			Comunicacao.Config_sistema.endereco_encontrado = false;
			Comunicacao.Config_sistema.endereco_modbus = (HorizontalAlignment)0;
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x002FEB94 File Offset: 0x002FCF94
		[MethodImpl(72)]
		private void ToolStripButton_RT_810_Abrir_Click(object sender, EventArgs e)
		{
			checked
			{
				int num;
				int num3;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = (HorizontalAlignment)2;
					this.AtivaEfeitoOnChangeValue();
					this.OpenFileDialog_RT_810.Filter = "Arquivo de configuração de equipamento|*.Cfg855";
					this.OpenFileDialog_RT_810.InitialDirectory = Linha_RT.diretorio;
					if (this.OpenFileDialog_RT_810.ShowDialog() == (DialogResult)1 && Operators.CompareString(this.OpenFileDialog_RT_810.FileName, "", false) != 0)
					{
						Linha_RT.diretorio = Path.GetDirectoryName(this.OpenFileDialog_RT_810.FileName) + "\\";
						RT_geral.arquivo_extensao = Path.GetExtension(this.OpenFileDialog_RT_810.FileName);
						IniFile iniFile = new IniFile(this.OpenFileDialog_RT_810.FileName);
						RT_geral.IEC_855_BD.Equip.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "EQUIPAMENTO", 0);
						RT_geral.IEC_855_BD.Versao.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "VERSAO", 0);
						RT_geral.IEC_855_BD.Build.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "BUILD", 0);
						RT_geral.IEC_855_BD.Release.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "RELEASE", 0);
						if (!Linha_RT.VerificaSeEquipamentoEValido(1, RT_geral.IEC_855_BD.Equip.Valor, RT_geral.IEC_855_BD.Versao.Valor, RT_geral.IEC_855_BD.Build.Valor, RT_geral.IEC_855_BD.Release.Valor, RT_geral.arquivo_extensao).Status)
						{
							RT_geral.Lmte_Init_ok = false;
							this.Inicializa_DadosEStrutura855_Padrao();
							this.Inicializa_DadosEStrutura855_Default();
							Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
							this.Atualiza_Tela855();
							RT_geral.Lmte_Init_ok = true;
							this.AtualizaMsgTela_RT_810("Valores Default carregados", 0);
							this.Timer_limpa_MSG.Enabled = true;
							goto IL_645;
						}
						RT_geral.IEC_855_BD.filename = this.OpenFileDialog_RT_810.FileName;
						RT_geral.IEC_855_BD.End_estacao.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "ESTACAO", 0);
						RT_geral.IEC_855_BD.End_mestre.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "MESTRE", 0);
						RT_geral.IEC_855_BD.Tempo_ptt.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "TEMPO_PTT", 0);
						RT_geral.IEC_855_BD.BaudRateCOM1.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "BAUDRATE_COM1", 0);
						if (!perifericos.Lista_ValorPermitido(RT_geral.IEC_855_BD.BaudRateCOM1.Valor, perifericos.ListaBaudRate))
						{
							RT_geral.IEC_855_BD.BaudRateCOM1.Valor = (HorizontalAlignment)21857;
						}
						RT_geral.IEC_855_BD.BaudRateCOM1.Indice = perifericos.Get_Indice_Pelo_Valor(RT_geral.IEC_855_BD.BaudRateCOM1.Valor, perifericos.ListaBaudRate);
						Linha_RT.Atualiza_estrutura_combo(ref RT_geral.IEC_855_BD.AtribuicaoIP, iniFile.ReadInteger("GERAL_MODO_OPERCAO", "MODO", 0));
						RT_geral.IEC_855_BD.Intervalo_tx_pto_pto.Valor = iniFile.ReadInteger("GERAL_MODO_OPERCAO", "INTERVALO", 0);
						RT_geral.IEC_855_BD.AD_Intervalo.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "INTERVALO", 0);
						RT_geral.IEC_855_BD.AD_Tamanho_filtro.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "TAMANHO_FILTRO", 0);
						int num2 = (HorizontalAlignment)0;
						do
						{
							string section = string.Format("ENTRADA_ANALOGICA_{0}", num2 + 1);
							RT_geral.IEC_855_BD.EA_Range[num2].Valor = iniFile.ReadInteger(section, "EA_RANGE", 0);
							RT_geral.IEC_855_BD.EA_Inicio[num2].Valor = iniFile.ReadInteger(section, "EA_INICIO", 0);
							RT_geral.IEC_855_BD.EA_Fim[num2].Valor = iniFile.ReadInteger(section, "EA_FIM", 0);
							num2++;
						}
						while (num2 <= 3);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.IEC_855_BD.ctrl_acionamento[0], RT_geral.RT_810_DataGrigViewProcessosColunas[0], iniFile.ReadInteger("CFG_CONTROLE", "ACIONAMENTO", 0));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.IEC_855_BD.ctrl_ret_acionamento[0], RT_geral.RT_810_DataGrigViewProcessosColunas[1], iniFile.ReadInteger("CFG_CONTROLE", "RET_ACIONAMENTO", 0));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.IEC_855_BD.ctrl_ED_selecao[0], RT_geral.RT_810_DataGrigViewProcessosColunas[2], iniFile.ReadInteger("CFG_CONTROLE", "SELECAO_REMOTO", 0));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.IEC_855_BD.ctrl_reverso[0], RT_geral.RT_810_DataGrigViewProcessosColunas[3], iniFile.ReadInteger("CFG_CONTROLE", "SELECAO_REVERSO", 0));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.IEC_855_BD.ctrl_modo[0], RT_geral.RT_810_DataGrigViewProcessosColunas[4], iniFile.ReadInteger("CFG_CONTROLE", "MODO_CONTROLE", 0));
						RT_geral.IEC_855_BD.ctrl_tempo_max_partida[0].Valor = iniFile.ReadInteger("CFG_CONTROLE", "TEMPO_MAX_PARTIDA", 0);
						RT_geral.IEC_855_BD.ctrl_tempo_max_parada[0].Valor = iniFile.ReadInteger("CFG_CONTROLE", "TEMPO_MAX_PARADA", 0);
						num2 = (HorizontalAlignment)0;
						do
						{
							string section = string.Format("CFG{0}_ED", num2 + 1);
							num2++;
						}
						while (num2 <= 7);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.IEC_855_BD.Setpoints_ctrl_variavel[0], RT_geral.RT_810_DataGrigViewSetpointsColunas[0], iniFile.ReadInteger("SETPOINT", "CTRL_VARIAVEL", 0));
						RT_geral.IEC_855_BD.Setpoints_ctrl_nivel_alto[0].Valor = iniFile.ReadInteger("SETPOINT", "NIVEL_ALTO", 0);
						RT_geral.IEC_855_BD.Setpoints_ctrl_nivel_baixo[0].Valor = iniFile.ReadInteger("SETPOINT", "NIVEL_BAIXO", 0);
						this.Atualiza_Tela855();
						this.AtualizaMsgTela_RT_810("Arquivo carregado com sucesso!", 0);
					}
					this.Timer_limpa_MSG.Enabled = true;
					goto IL_645;
					IL_5CC:
					Interaction.MsgBox("Não foi possível carregar os dados", (MsgBoxStyle)32, "Atenção - Erro I/0");
					FileSystem.FileClose(new int[]
					{
						1
					});
					this.Timer_limpa_MSG.Enabled = true;
					goto IL_645;
					IL_600:
					num3 = -1;
										IL_616:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num3 == (DialogResult)0))
				{
					Exception ex = (Exception)obj2;
					goto IL_600;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_645:
				if (num3 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x002FF20C File Offset: 0x002FD60C
		[MethodImpl(72)]
		private void ToolStripButton_RT_810_Salvar_Click(object sender, EventArgs e)
		{
			int num;
			int num2;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = (HorizontalAlignment)2;
				this.AtivaEfeitoOnChangeValue();
				this.Bloqueia_acoes();
				this.SaveFileDialog_RT_810.Filter = "Arquivo de configuração de equipamento|*.Cfg810";
				this.SaveFileDialog_RT_810.InitialDirectory = Linha_RT.diretorio;
				if (this.SaveFileDialog_RT_810.ShowDialog() == (DialogResult)1 && Operators.CompareString(this.SaveFileDialog_RT_810.FileName, "", false) != 0)
				{
					Linha_RT.diretorio = Path.GetDirectoryName(this.SaveFileDialog_RT_810.FileName) + "\\";
					if (File.Exists(this.SaveFileDialog_RT_810.FileName))
					{
						if (File.Exists(this.SaveFileDialog_RT_810.FileName + ".old"))
						{
							File.Delete(this.SaveFileDialog_RT_810.FileName + ".old");
						}
						File.Move(this.SaveFileDialog_RT_810.FileName, this.SaveFileDialog_RT_810.FileName + ".old");
					}
					RT_geral.IEC_855_BD.filename = this.SaveFileDialog_RT_810.FileName;
					this.InicializaBarraProgressoTela_RT_810(12);
					IniFileWriteFast iniFileWriteFast = new IniFileWriteFast(this.SaveFileDialog_RT_810.FileName);
					iniFileWriteFast.WriteSection("GERAL_INFORMACAO");
					iniFileWriteFast.WriteKey("EQUIPAMENTO", RT_geral.IEC_855_BD.Equip.Valor);
					iniFileWriteFast.WriteKey("VERSAO", RT_geral.IEC_855_BD.Versao.Valor);
					iniFileWriteFast.WriteKey("BUILD", RT_geral.IEC_855_BD.Build.Valor);
					iniFileWriteFast.WriteKey("RELEASE", RT_geral.IEC_855_BD.Release.Valor);
					iniFileWriteFast.WriteKey("MAC0", (int)RT_geral.IEC_855_BD.MAC[0]);
					iniFileWriteFast.WriteKey("MAC1", (int)RT_geral.IEC_855_BD.MAC[1]);
					iniFileWriteFast.WriteKey("MAC2", (int)RT_geral.IEC_855_BD.MAC[2]);
					iniFileWriteFast.WriteKey("MAC3", (int)RT_geral.IEC_855_BD.MAC[3]);
					iniFileWriteFast.WriteKey("MAC4", (int)RT_geral.IEC_855_BD.MAC[4]);
					iniFileWriteFast.WriteKey("MAC5", (int)RT_geral.IEC_855_BD.MAC[5]);
					iniFileWriteFast.LineSpace();
					this.ToolStripProgressBar_RT_810.PerformStep();
					Application.DoEvents();
					iniFileWriteFast.WriteSection("GERAL_CONFIGURACAO");
					iniFileWriteFast.WriteKey("BAUDRATE_COM1", RT_geral.IEC_855_BD.BaudRateCOM1.Valor);
					iniFileWriteFast.WriteKey("ATRIBUICAO_IP", RT_geral.IEC_855_BD.AD_Tamanho_filtro.Valor);
					iniFileWriteFast.LineSpace();
					this.ToolStripProgressBar_RT_810.PerformStep();
					Application.DoEvents();
					this.ToolStripProgressBar_RT_810.PerformStep();
					Application.DoEvents();
					this.ToolStripProgressBar_RT_810.PerformStep();
					Application.DoEvents();
					Application.DoEvents();
					this.ToolStripProgressBar_RT_810.PerformStep();
					Application.DoEvents();
					this.AtualizaMsgTela_RT_810("Arquivo gerado com sucesso!", 0);
					this.Timer_limpa_MSG.Enabled = true;
				}
				this.Timer_limpa_MSG.Enabled = true;
				goto IL_351;
				IL_2DD:
				Interaction.MsgBox("Não foi possível gravar os dados", (MsgBoxStyle)32, "Atenção - Erro I/0");
				FileSystem.FileClose(new int[]
				{
					1
				});
				this.Timer_limpa_MSG.Enabled = true;
				goto IL_351;
				IL_30E:
				num2 = -1;
								IL_323:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num2 == (DialogResult)0))
			{
				Exception ex = (Exception)obj2;
				goto IL_30E;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			IL_351:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x002FF590 File Offset: 0x002FD990
		private void DataGridView_setpoints_810_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x002FF594 File Offset: 0x002FD994
		private void DataGridView_setpoints_810_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x002FF598 File Offset: 0x002FD998
		private void DataGridView_setpoints_810_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x002FF59C File Offset: 0x002FD99C
		private void DataGridView_processo_810_P1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x002FF5A0 File Offset: 0x002FD9A0
		private void DataGridView_processo_810_P1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x002FF5A4 File Offset: 0x002FD9A4
		private void DataGridView_processo_810_P1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x002FF5A8 File Offset: 0x002FD9A8
		private void DataGridView_end_rep_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x002FF5AC File Offset: 0x002FD9AC
		private void DataGridView_end_rep_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x002FF5B0 File Offset: 0x002FD9B0
		private void DataGridView_end_rep_RT_810_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x002FF5B4 File Offset: 0x002FD9B4
		private void DataGridView_parametros_EA_810_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x002FF5B8 File Offset: 0x002FD9B8
		private void DataGridView_parametros_EA_810_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x002FF5BC File Offset: 0x002FD9BC
		private void DataGridView_parametros_EA_810_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x002FF5C0 File Offset: 0x002FD9C0
		private void DataGridView_RT810_ED_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			if (e.RowIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_RT810_ED.Columns[e.ColumnIndex].DataPropertyName;
			string text = dataPropertyName;
			if (Operators.CompareString(text, "IP", false) == (DialogResult)0)
			{
				string text2 = Conversions.ToString(this.DataGridView_RT810_ED.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				bool flag = this.QuebraIPString(text2);
				if (flag)
				{
					this.tb_static_ip.ForeColor = Color.Black;
					this.DataGridView_RT810_ED[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Black;
					this.DataGridView_RT810_ED.CurrentCell = this.DataGridView_RT810_ED.Rows[e.RowIndex].Cells[e.ColumnIndex];
					RT_geral.IEC_855_BD.tab_ips[e.RowIndex] = text2;
				}
				else
				{
					this.DataGridView_RT810_ED[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Red;
					this.DataGridView_RT810_ED.CurrentCell = this.DataGridView_RT810_ED.Rows[e.RowIndex].Cells[e.ColumnIndex];
				}
			}
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x002FF724 File Offset: 0x002FDB24
		private void DataGridView_RT810_ED_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_RT810_ED.IsCurrentCellDirty)
			{
				this.DataGridView_RT810_ED.CommitEdit(512);
			}
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x002FF744 File Offset: 0x002FDB44
		private void ToolStripButton_RT_810_Imprimir_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			using (EnhancedPrintPreviewDialog enhancedPrintPreviewDialog = new EnhancedPrintPreviewDialog())
			{
				enhancedPrintPreviewDialog.Document = this.PrintDocument1;
				enhancedPrintPreviewDialog.ShowDialog();
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x002FF78C File Offset: 0x002FDB8C
		private void TextBox_comentarios_RT810_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x002FF790 File Offset: 0x002FDB90
		[MethodImpl(72)]
		private void DesenhaRelatorioRT810(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, 3);
			Font font2 = new Font("Calibri", 10f, 3, (FontStyle)3);
			Font font3 = new Font("Calibri", 10f, 0, (FontStyle)3);
			Font fonte = new Font("Calibri", 20f, 1, (FontStyle)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.IEC_855_BD.Equip.Valor, RT_geral.IEC_855_BD.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 5, "Dados da Estação", true);
			string valor = string.Concat(new string[]
			{
				"RT",
				RT_geral.IEC_855_BD.Equip.Valor.ToString(),
				"_",
				RT_geral.IEC_855_BD.Versao.Valor.ToString(),
				string.Format("{0:D2}", RT_geral.IEC_855_BD.Build.Valor),
				"  R",
				RT_geral.IEC_855_BD.Release.Valor.ToString()
			});
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Data", string.Concat(new string[]
			{
				DateTime.Today.Day.ToString(),
				"/",
				DateTime.Today.Month.ToString(),
				"/",
				DateTime.Today.Year.ToString()
			}), 450, 530);
			string valor2 = "iS800 (" + MyProject.Application.Info.Version.ToString() + ")";
			tabelaLinhaInteria.EscreveTituloValorLinha(4, "Configurador", valor2, 0, 160);
			tabelaLinhaInteria.EscreveTituloValorLinha(4, "Firmware", valor, 450, 530);
			tabelaLinhaInteria.EscreveTituloValorLinha(5, "Arquivo", Path.GetFileName(RT_geral.IEC_855_BD.filename), 0, 160);
			int nextLineAvailable = tabelaLinhaInteria.GetNextLineAvailable();
			TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 6, "Dados de Instalação", true);
			nextLineAvailable = tabelaLinhaInteria2.GetNextLineAvailable();
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 3, "Parâmetro de Comunicação", true);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 3, "Parâmetro de Operação", true);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(1, "Método de Operação", this.ComboBox_Modo_Operacao.Text, 0, 140);
			nextLineAvailable = tabelaMeiaLinhaDireita.GetNextLineAvailable();
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 2, "Parâmetro de Interface", true);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(1, "BaudRate COM1", perifericos.ListaBaudRate[RT_geral.IEC_855_BD.BaudRateCOM1.Indice].nome_impressao, 0, 170);
			nextLineAvailable = tabelaMeiaLinhaEsquerda2.GetNextLineAvailable();
			TabelaLinhaInteria tabelaLinhaInteria3 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 2, "Parâmetro de Controle", false);
			tabelaLinhaInteria3.AdicionaLinha();
			tabelaLinhaInteria3.EscreveTituloLinha(1, "\r\nAcionamento", 80);
			tabelaLinhaInteria3.EscreveTituloLinha(1, "Retorno\r\nAcionamento", 180);
			tabelaLinhaInteria3.EscreveTituloLinha(1, "Seleção\r\nRemoto", 280);
			tabelaLinhaInteria3.EscreveTituloLinha(1, "Seleção\r\nReverso", 350);
			tabelaLinhaInteria3.EscreveTituloLinha(1, "Modo\r\nControle", 430);
			tabelaLinhaInteria3.EscreveTituloLinha(1, "Tempo\r\nPartida", 510);
			tabelaLinhaInteria3.EscreveTituloLinha(1, "Tempo\r\nParada", 570);
			tabelaLinhaInteria3.EscreveTituloLinha(3, "CTRL 01", 0);
			string valor3 = "???";
			switch (RT_geral.IEC_855_BD.ctrl_acionamento[0].Valor)
			{
			case 21856:
				valor3 = "Desativa";
				break;
			case 21857:
				valor3 = "SD-01";
				break;
			}
			tabelaLinhaInteria3.EscreveValorLinha(3, valor3, 80);
			string valor4 = "???";
			switch (RT_geral.IEC_855_BD.ctrl_ret_acionamento[0].Valor)
			{
			case 21856:
				valor4 = "Não usada";
				break;
			case 21857:
				valor4 = "ED-01";
				break;
			case 21858:
				valor4 = "ED-02";
				break;
			case 21859:
				valor4 = "ED-03";
				break;
			case 21860:
				valor4 = "ED-04";
				break;
			case 21861:
				valor4 = "ED-05";
				break;
			case 21862:
				valor4 = "ED-06";
				break;
			case 21863:
				valor4 = "ED-07";
				break;
			case 21864:
				valor4 = "ED-08";
				break;
			}
			tabelaLinhaInteria3.EscreveValorLinha(3, valor4, 180);
			string valor5 = "???";
			switch (RT_geral.IEC_855_BD.ctrl_ED_selecao[0].Valor)
			{
			case 21856:
				valor5 = "Remoto";
				break;
			case 21857:
				valor5 = "ED-01";
				break;
			case 21858:
				valor5 = "ED-02";
				break;
			case 21859:
				valor5 = "ED-03";
				break;
			case 21860:
				valor5 = "ED-04";
				break;
			case 21861:
				valor5 = "ED-05";
				break;
			case 21862:
				valor5 = "ED-06";
				break;
			case 21863:
				valor5 = "ED-07";
				break;
			case 21864:
				valor5 = "ED-08";
				break;
			}
			tabelaLinhaInteria3.EscreveValorLinha(3, valor5, 280);
			string valor6 = "???";
			switch (RT_geral.IEC_855_BD.ctrl_reverso[0].Valor)
			{
			case 21856:
				valor6 = "Desab.";
				break;
			case 21857:
				valor6 = "Habilit.";
				break;
			}
			tabelaLinhaInteria3.EscreveValorLinha(3, valor6, 350);
			string valor7 = "???";
			switch (RT_geral.IEC_855_BD.ctrl_modo[0].Valor)
			{
			case 21856:
				valor7 = "Telecomando";
				break;
			case 21857:
				valor7 = "Automático";
				break;
			}
			tabelaLinhaInteria3.EscreveValorLinha(3, valor7, 430);
			tabelaLinhaInteria3.EscreveValorLinha(3, RT_geral.IEC_855_BD.ctrl_tempo_max_partida[0].Valor.ToString(), 530);
			tabelaLinhaInteria3.EscreveValorLinha(3, RT_geral.IEC_855_BD.ctrl_tempo_max_parada[0].Valor.ToString(), 590);
			nextLineAvailable = tabelaLinhaInteria3.GetNextLineAvailable();
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda3 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 2, "Filtro EA", true);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita2 = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 8, "Entrada Digital", true);
			int num = (HorizontalAlignment)0;
			checked
			{
				do
				{
					num++;
				}
				while (num <= 7);
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda4 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda3.GetNextLineAvailable(), 5, "Escala EA", true);
				tabelaMeiaLinhaEsquerda4.EscreveTituloLinha(1, "Range", 70);
				tabelaMeiaLinhaEsquerda4.EscreveTituloLinha(1, "Início", 140);
				tabelaMeiaLinhaEsquerda4.EscreveTituloLinha(1, "Range", 240);
				num = (HorizontalAlignment)0;
				do
				{
					tabelaMeiaLinhaEsquerda4.EscreveTituloLinha(num + 2, string.Format("ED0{0}", num + 1), 0);
					tabelaMeiaLinhaEsquerda4.EscreveValorLinha(num + 2, RT_geral.IEC_855_BD.EA_Range[num].Valor.ToString(), 70);
					tabelaMeiaLinhaEsquerda4.EscreveValorLinha(num + 2, RT_geral.IEC_855_BD.EA_Inicio[num].Valor.ToString(), 150);
					tabelaMeiaLinhaEsquerda4.EscreveValorLinha(num + 2, RT_geral.IEC_855_BD.EA_Fim[num].Valor.ToString(), 250);
					num++;
				}
				while (num <= 3);
				nextLineAvailable = tabelaMeiaLinhaEsquerda4.GetNextLineAvailable();
				TabelaLinhaInteria tabelaLinhaInteria4 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 2, "SetPoint", true);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "EA Controle", 150);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Nivel Baixo", 300);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Nível Alto", 550);
				tabelaLinhaInteria4.EscreveTituloLinha(2, "CTRL 01", 0);
				string valor8 = "???";
				switch (RT_geral.IEC_855_BD.Setpoints_ctrl_variavel[0].Valor)
				{
				case 21856:
					valor8 = "CTRL Desativado";
					break;
				case 21857:
					valor8 = "EA01";
					break;
				case 21858:
					valor8 = "EA02";
					break;
				case 21859:
					valor8 = "EA03";
					break;
				case 21860:
					valor8 = "EA04";
					break;
				case 21873:
					valor8 = "Valor Referência 1";
					break;
				case 21874:
					valor8 = "Valor Referência 2";
					break;
				case 21875:
					valor8 = "Valor Referência 3";
					break;
				case 21876:
					valor8 = "Valor Referência 4";
					break;
				}
				tabelaLinhaInteria4.EscreveValorLinha(2, valor8, 150);
				tabelaLinhaInteria4.EscreveValorLinha(2, RT_geral.IEC_855_BD.Setpoints_ctrl_nivel_baixo[0].Valor.ToString(), 300);
				tabelaLinhaInteria4.EscreveValorLinha(2, RT_geral.IEC_855_BD.Setpoints_ctrl_nivel_alto[0].Valor.ToString(), 550);
				nextLineAvailable = tabelaLinhaInteria4.GetNextLineAvailable();
				TabelaLinhaInteria tabelaLinhaInteria5 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 1, "Repetidora", true);
				string valor9 = "???";
				tabelaLinhaInteria5.EscreveTituloValorLinha(1, "Modo", valor9, 0, 60);
				tabelaLinhaInteria5.EscreveTituloValorLinha(1, "End. Mestre", "X", 240, 320);
				tabelaLinhaInteria5.EscreveTituloValorLinha(1, "Quantidade End. Repetidos", "Z", 410, 600);
				nextLineAvailable = tabelaLinhaInteria5.GetNextLineAvailable();
				TabelaLinhaInteria tabelaLinhaInteria6 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 4, "Observação", true);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0030021C File Offset: 0x002FE61C
		private bool DesenhaRelatorio(PrintPageEventArgs z)
		{
			Font font = new Font("Arial", 12f, 3);
			Pen pen = new Pen(Color.Black, 2f);
			checked
			{
				switch (this.pagina_impressao)
				{
				case 1:
					this.DesenhaRelatorioRT810(z);
					this.pagina_impressao++;
					return false;
				case 2:
					z.Graphics.DrawString("PIMBA", font, Brushes.Red, 100f, 100f);
					this.pagina_impressao++;
					break;
				case 3:
					z.Graphics.DrawString("ZE", font, Brushes.Blue, 100f, 100f);
					this.pagina_impressao++;
					return false;
				}
				return false;
			}
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x003002E0 File Offset: 0x002FE6E0
		private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
		{
			this.pagina_impressao = (HorizontalAlignment)1;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x003002EC File Offset: 0x002FE6EC
		private void PrintDocument1_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
		{
			switch (this.pagina_impressao)
			{
			case 1:
				e.PageSettings.Landscape = false;
				break;
			case 2:
				e.PageSettings.Landscape = true;
				break;
			case 3:
				e.PageSettings.Landscape = true;
				break;
			}
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0030033C File Offset: 0x002FE73C
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.HasMorePages = this.DesenhaRelatorio(e);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0030034C File Offset: 0x002FE74C
		private void TabPage_geral_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00300350 File Offset: 0x002FE750
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00300354 File Offset: 0x002FE754
		private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00300358 File Offset: 0x002FE758
		private void RepetidoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00300364 File Offset: 0x002FE764
		private void ToolStri_RT_810_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00300368 File Offset: 0x002FE768
		private void TextBox_equipamento_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0030036C File Offset: 0x002FE76C
		private void GroupBox_sistema_leitura_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00300370 File Offset: 0x002FE770
		private void Label73_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00300374 File Offset: 0x002FE774
		private void GroupBox2_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00300378 File Offset: 0x002FE778
		private void ComboBox_baudrate_COM1_810_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.IEC_855_BD.BaudRateCOM1.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.IEC_855_BD.BaudRateCOM1.AtualizaValorPeloIndice();
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x003003B4 File Offset: 0x002FE7B4
		private void ComboBox_baudrate_COM2_810_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x003003B8 File Offset: 0x002FE7B8
		private void Label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x003003BC File Offset: 0x002FE7BC
		public bool IPKeyPress(KeyPressEventArgs e)
		{
			bool result;
			if (char.IsDigit(e.KeyChar) | Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == (DialogResult)0 | Strings.Asc(e.KeyChar) == (DialogResult)46 | Strings.Asc(e.KeyChar) == (DialogResult)8 | Strings.Asc(e.KeyChar) == (DialogResult)39 | Strings.Asc(e.KeyChar) == (DialogResult)37)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00300434 File Offset: 0x002FE834
		public bool QuebraIPString(string ip)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			string[] array = ip.Split(new char[]
			{
				'.'
			});
			bool result;
			if (array.Length != 4)
			{
				result = false;
			}
			else if (Operators.CompareString(array[3], "", false) != 0)
			{
				int num = (int)Convert.ToInt16(array[3]);
				if (num >= 0 & num <= 255)
				{
					flag4 = true;
				}
				if (Operators.CompareString(array[2], "", false) != 0)
				{
					int num2 = (int)Convert.ToInt16(array[2]);
					if (num2 >= 0 & num2 <= 255)
					{
						flag3 = true;
					}
					if (Operators.CompareString(array[1], "", false) != 0)
					{
						int num3 = (int)Convert.ToInt16(array[1]);
						if (num3 >= 0 & num3 <= 255)
						{
							flag2 = true;
						}
						if (Operators.CompareString(array[0], "", false) != 0)
						{
							int num4 = (int)Convert.ToInt16(array[0]);
							if (num4 >= 0 & num4 <= 255)
							{
								flag = true;
							}
							result = (flag && flag2 && flag3 && flag4);
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00300578 File Offset: 0x002FE978
		private void tb_static_ip_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.QuebraIPString(Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
			if (flag)
			{
				this.tb_static_ip.ForeColor = Color.Black;
				RT_geral.IEC_855_BD.STATIC_IP = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
			}
			else
			{
				this.tb_static_ip.ForeColor = Color.Red;
			}
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x003005F0 File Offset: 0x002FE9F0
		private void tb_static_ip_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.IPKeyPress(e);
			if (flag)
			{
				return;
			}
			e.Handled = true;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00300610 File Offset: 0x002FEA10
		private void tb_static_gw_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.QuebraIPString(Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
			if (flag)
			{
				this.tb_static_ip.ForeColor = Color.Black;
				RT_geral.IEC_855_BD.STATIC_GW = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
			}
			else
			{
				this.tb_static_ip.ForeColor = Color.Red;
			}
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00300688 File Offset: 0x002FEA88
		private void tb_static_sm_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.QuebraIPString(Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null)));
			if (flag)
			{
				this.tb_static_ip.ForeColor = Color.Black;
				RT_geral.IEC_855_BD.STATIC_SM = Conversions.ToString(NewLateBinding.LateGet(sender, null, "text", new object[0], null, null, null));
			}
			else
			{
				this.tb_static_ip.ForeColor = Color.Red;
			}
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00300700 File Offset: 0x002FEB00
		private void tb_dhcp_ip_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00300704 File Offset: 0x002FEB04
		private void DataGridView_RT810_ED_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x040007D8 RID: 2008
		[AccessedThroughProperty("TabControl_810")]
		private TabControl _TabControl_810;

		// Token: 0x040007D9 RID: 2009
		[AccessedThroughProperty("TabPage_geral")]
		private TabPage _TabPage_geral;

		// Token: 0x040007DA RID: 2010
		[AccessedThroughProperty("GroupBox_informacoes")]
		private GroupBox _GroupBox_informacoes;

		// Token: 0x040007DB RID: 2011
		[AccessedThroughProperty("TabPage_IP")]
		private TabPage _TabPage_IP;

		// Token: 0x040007DC RID: 2012
		[AccessedThroughProperty("ToolStri_RT_810")]
		private ToolStrip _ToolStri_RT_810;

		// Token: 0x040007DD RID: 2013
		[AccessedThroughProperty("ToolStripButton_RT_810_Abrir")]
		private ToolStripButton _ToolStripButton_RT_810_Abrir;

		// Token: 0x040007DE RID: 2014
		[AccessedThroughProperty("ToolStripButton_RT_810_Salvar")]
		private ToolStripButton _ToolStripButton_RT_810_Salvar;

		// Token: 0x040007DF RID: 2015
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x040007E0 RID: 2016
		[AccessedThroughProperty("ToolStripButton_RT_810_Download")]
		private ToolStripButton _ToolStripButton_RT_810_Download;

		// Token: 0x040007E1 RID: 2017
		[AccessedThroughProperty("ToolStripButton_RT_810_Upload")]
		private ToolStripButton _ToolStripButton_RT_810_Upload;

		// Token: 0x040007E2 RID: 2018
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x040007E3 RID: 2019
		[AccessedThroughProperty("ToolStripProgressBar_RT_810")]
		private ToolStripProgressBar _ToolStripProgressBar_RT_810;

		// Token: 0x040007E4 RID: 2020
		[AccessedThroughProperty("ToolStripTextBox_RT_810_Msg")]
		private ToolStripTextBox _ToolStripTextBox_RT_810_Msg;

		// Token: 0x040007E5 RID: 2021
		[AccessedThroughProperty("ToolStripButton_RT_810_novo")]
		private ToolStripButton _ToolStripButton_RT_810_novo;

		// Token: 0x040007E6 RID: 2022
		[AccessedThroughProperty("OpenFileDialog_RT_810")]
		private OpenFileDialog _OpenFileDialog_RT_810;

		// Token: 0x040007E7 RID: 2023
		[AccessedThroughProperty("SaveFileDialog_RT_810")]
		private SaveFileDialog _SaveFileDialog_RT_810;

		// Token: 0x040007E8 RID: 2024
		[AccessedThroughProperty("Timer_limpa_MSG")]
		private Timer _Timer_limpa_MSG;

		// Token: 0x040007E9 RID: 2025
		[AccessedThroughProperty("GroupBox_ModoOperacao")]
		private GroupBox _GroupBox_ModoOperacao;

		// Token: 0x040007EA RID: 2026
		[AccessedThroughProperty("ComboBox_Modo_Operacao")]
		private ComboBox _ComboBox_Modo_Operacao;

		// Token: 0x040007EB RID: 2027
		[AccessedThroughProperty("Label_MetodoOperacao")]
		private Label _Label_MetodoOperacao;

		// Token: 0x040007EC RID: 2028
		[AccessedThroughProperty("GroupBox_ED")]
		private GroupBox _GroupBox_ED;

		// Token: 0x040007ED RID: 2029
		[AccessedThroughProperty("DataGridView_RT810_ED")]
		private DataGridView _DataGridView_RT810_ED;

		// Token: 0x040007EE RID: 2030
		[AccessedThroughProperty("ToolStripButton_RT_810_Imprimir")]
		private ToolStripButton _ToolStripButton_RT_810_Imprimir;

		// Token: 0x040007EF RID: 2031
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x040007F0 RID: 2032
		[AccessedThroughProperty("PrintDocument1")]
		private PrintDocument _PrintDocument1;

		// Token: 0x040007F1 RID: 2033
		[AccessedThroughProperty("PrintPreviewDialog1")]
		private PrintPreviewDialog _PrintPreviewDialog1;

		// Token: 0x040007F2 RID: 2034
		[AccessedThroughProperty("RepetidoraBindingSource1")]
		private BindingSource _RepetidoraBindingSource1;

		// Token: 0x040007F3 RID: 2035
		[AccessedThroughProperty("ToolStripLabel_ID")]
		private ToolStripLabel _ToolStripLabel_ID;

		// Token: 0x040007F4 RID: 2036
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x040007F5 RID: 2037
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		// Token: 0x040007F6 RID: 2038
		[AccessedThroughProperty("TextBox_equipamento")]
		private TextBox _TextBox_equipamento;

		// Token: 0x040007F7 RID: 2039
		[AccessedThroughProperty("Label_equipamento")]
		private Label _Label_equipamento;

		// Token: 0x040007F8 RID: 2040
		[AccessedThroughProperty("TextBox_release")]
		private TextBox _TextBox_release;

		// Token: 0x040007F9 RID: 2041
		[AccessedThroughProperty("Label_release")]
		private Label _Label_release;

		// Token: 0x040007FA RID: 2042
		[AccessedThroughProperty("TextBox_build")]
		private TextBox _TextBox_build;

		// Token: 0x040007FB RID: 2043
		[AccessedThroughProperty("Label_build")]
		private Label _Label_build;

		// Token: 0x040007FC RID: 2044
		[AccessedThroughProperty("TextBox_versao")]
		private TextBox _TextBox_versao;

		// Token: 0x040007FD RID: 2045
		[AccessedThroughProperty("Label_versao")]
		private Label _Label_versao;

		// Token: 0x040007FE RID: 2046
		[AccessedThroughProperty("tb_lixo4")]
		private TextBox _tb_lixo4;

		// Token: 0x040007FF RID: 2047
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000800 RID: 2048
		[AccessedThroughProperty("ComboBox_baudrate")]
		private ComboBox _ComboBox_baudrate;

		// Token: 0x04000801 RID: 2049
		[AccessedThroughProperty("Label36")]
		private Label _Label36;

		// Token: 0x04000802 RID: 2050
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x04000803 RID: 2051
		[AccessedThroughProperty("tbMAC5")]
		private TextBox _tbMAC5;

		// Token: 0x04000804 RID: 2052
		[AccessedThroughProperty("tbMAC4")]
		private TextBox _tbMAC4;

		// Token: 0x04000805 RID: 2053
		[AccessedThroughProperty("tbMAC3")]
		private TextBox _tbMAC3;

		// Token: 0x04000806 RID: 2054
		[AccessedThroughProperty("tbMAC2")]
		private TextBox _tbMAC2;

		// Token: 0x04000807 RID: 2055
		[AccessedThroughProperty("tbMAC1")]
		private TextBox _tbMAC1;

		// Token: 0x04000808 RID: 2056
		[AccessedThroughProperty("tbMAC0")]
		private TextBox _tbMAC0;

		// Token: 0x04000809 RID: 2057
		[AccessedThroughProperty("tbMAC")]
		private Label _tbMAC;

		// Token: 0x0400080A RID: 2058
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x0400080B RID: 2059
		[AccessedThroughProperty("tb_dhcp_sm")]
		private TextBox _tb_dhcp_sm;

		// Token: 0x0400080C RID: 2060
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400080D RID: 2061
		[AccessedThroughProperty("tb_dhcp_gw")]
		private TextBox _tb_dhcp_gw;

		// Token: 0x0400080E RID: 2062
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400080F RID: 2063
		[AccessedThroughProperty("tb_dhcp_ip")]
		private TextBox _tb_dhcp_ip;

		// Token: 0x04000810 RID: 2064
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000811 RID: 2065
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x04000812 RID: 2066
		[AccessedThroughProperty("tb_static_sm")]
		private TextBox _tb_static_sm;

		// Token: 0x04000813 RID: 2067
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000814 RID: 2068
		[AccessedThroughProperty("tb_static_gw")]
		private TextBox _tb_static_gw;

		// Token: 0x04000815 RID: 2069
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000816 RID: 2070
		[AccessedThroughProperty("tb_static_ip")]
		private TextBox _tb_static_ip;

		// Token: 0x04000817 RID: 2071
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000818 RID: 2072
		[AccessedThroughProperty("ip")]
		private DataGridViewTextBoxColumn _ip;

		// Token: 0x04000819 RID: 2073
		private int pagina_impressao;
	}
}
