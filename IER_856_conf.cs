using System;
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
	// Token: 0x0200003C RID: 60
	[DesignerGenerated]
	public partial class IER_856_conf : Form
	{
		// Token: 0x06000DFD RID: 3581 RVA: 0x00300708 File Offset: 0x002FEB08
		public IER_856_conf()
		{
			base.Load += new EventHandler(this.RT_810_conf_Load);
			base.Activated += new EventHandler(this.RT_810_conf_Activated);
			base.FormClosed += new FormClosedEventHandler(this.RT_810_conf_FormClosed);
			this.InitializeComponent();
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x00302800 File Offset: 0x00300C00
		// (set) Token: 0x06000E01 RID: 3585 RVA: 0x00302814 File Offset: 0x00300C14
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

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x00302820 File Offset: 0x00300C20
		// (set) Token: 0x06000E03 RID: 3587 RVA: 0x00302834 File Offset: 0x00300C34
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

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x00302880 File Offset: 0x00300C80
		// (set) Token: 0x06000E05 RID: 3589 RVA: 0x00302894 File Offset: 0x00300C94
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

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x003028A0 File Offset: 0x00300CA0
		// (set) Token: 0x06000E07 RID: 3591 RVA: 0x003028B4 File Offset: 0x00300CB4
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

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x00302900 File Offset: 0x00300D00
		// (set) Token: 0x06000E09 RID: 3593 RVA: 0x00302914 File Offset: 0x00300D14
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

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x00302960 File Offset: 0x00300D60
		// (set) Token: 0x06000E0B RID: 3595 RVA: 0x00302974 File Offset: 0x00300D74
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

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x003029C0 File Offset: 0x00300DC0
		// (set) Token: 0x06000E0D RID: 3597 RVA: 0x003029D4 File Offset: 0x00300DD4
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

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x003029E0 File Offset: 0x00300DE0
		// (set) Token: 0x06000E0F RID: 3599 RVA: 0x003029F4 File Offset: 0x00300DF4
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

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x00302A40 File Offset: 0x00300E40
		// (set) Token: 0x06000E11 RID: 3601 RVA: 0x00302A54 File Offset: 0x00300E54
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

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x00302AA0 File Offset: 0x00300EA0
		// (set) Token: 0x06000E13 RID: 3603 RVA: 0x00302AB4 File Offset: 0x00300EB4
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

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x00302AC0 File Offset: 0x00300EC0
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x00302AD4 File Offset: 0x00300ED4
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

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x00302AE0 File Offset: 0x00300EE0
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x00302AF4 File Offset: 0x00300EF4
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

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x00302B00 File Offset: 0x00300F00
		// (set) Token: 0x06000E19 RID: 3609 RVA: 0x00302B14 File Offset: 0x00300F14
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

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00302B60 File Offset: 0x00300F60
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x00302B74 File Offset: 0x00300F74
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

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x00302B80 File Offset: 0x00300F80
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x00302B94 File Offset: 0x00300F94
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

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00302BA0 File Offset: 0x00300FA0
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x00302BB4 File Offset: 0x00300FB4
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

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x00302C00 File Offset: 0x00301000
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x00302C14 File Offset: 0x00301014
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

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x00302C20 File Offset: 0x00301020
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x00302C34 File Offset: 0x00301034
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

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x00302C80 File Offset: 0x00301080
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x00302C94 File Offset: 0x00301094
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

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x00302CA0 File Offset: 0x003010A0
		// (set) Token: 0x06000E27 RID: 3623 RVA: 0x00302CB4 File Offset: 0x003010B4
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

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x00302D00 File Offset: 0x00301100
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x00302D14 File Offset: 0x00301114
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

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x00302D20 File Offset: 0x00301120
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x00302D34 File Offset: 0x00301134
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

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x00302DCC File Offset: 0x003011CC
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x00302DE0 File Offset: 0x003011E0
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

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00302DEC File Offset: 0x003011EC
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x00302E00 File Offset: 0x00301200
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

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x00302E0C File Offset: 0x0030120C
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x00302E20 File Offset: 0x00301220
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

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x00302E2C File Offset: 0x0030122C
		// (set) Token: 0x06000E33 RID: 3635 RVA: 0x00302E40 File Offset: 0x00301240
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

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x00302E4C File Offset: 0x0030124C
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x00302E60 File Offset: 0x00301260
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

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x00302E6C File Offset: 0x0030126C
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x00302E80 File Offset: 0x00301280
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

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00302ECC File Offset: 0x003012CC
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x00302EE0 File Offset: 0x003012E0
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

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00302EEC File Offset: 0x003012EC
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x00302F00 File Offset: 0x00301300
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

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00302F0C File Offset: 0x0030130C
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x00302F20 File Offset: 0x00301320
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

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00302F2C File Offset: 0x0030132C
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x00302F40 File Offset: 0x00301340
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

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00302F4C File Offset: 0x0030134C
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x00302F60 File Offset: 0x00301360
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

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00302F6C File Offset: 0x0030136C
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x00302F80 File Offset: 0x00301380
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

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x00302F8C File Offset: 0x0030138C
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x00302FA0 File Offset: 0x003013A0
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

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x00302FAC File Offset: 0x003013AC
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x00302FC0 File Offset: 0x003013C0
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

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x0030300C File Offset: 0x0030140C
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x00303020 File Offset: 0x00301420
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

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x0030306C File Offset: 0x0030146C
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x00303080 File Offset: 0x00301480
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

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x0030308C File Offset: 0x0030148C
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x003030A0 File Offset: 0x003014A0
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

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x003030AC File Offset: 0x003014AC
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x003030C0 File Offset: 0x003014C0
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

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x003030CC File Offset: 0x003014CC
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x003030E0 File Offset: 0x003014E0
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

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x003030EC File Offset: 0x003014EC
		// (set) Token: 0x06000E53 RID: 3667 RVA: 0x00303100 File Offset: 0x00301500
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

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x0030310C File Offset: 0x0030150C
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x00303120 File Offset: 0x00301520
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

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x0030312C File Offset: 0x0030152C
		// (set) Token: 0x06000E57 RID: 3671 RVA: 0x00303140 File Offset: 0x00301540
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

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x0030314C File Offset: 0x0030154C
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x00303160 File Offset: 0x00301560
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

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x0030316C File Offset: 0x0030156C
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x00303180 File Offset: 0x00301580
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

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x0030318C File Offset: 0x0030158C
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x003031A0 File Offset: 0x003015A0
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

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x003031AC File Offset: 0x003015AC
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x003031C0 File Offset: 0x003015C0
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

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x003031CC File Offset: 0x003015CC
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x003031E0 File Offset: 0x003015E0
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

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0030322C File Offset: 0x0030162C
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x00303240 File Offset: 0x00301640
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

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x0030324C File Offset: 0x0030164C
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x00303260 File Offset: 0x00301660
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

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x0030326C File Offset: 0x0030166C
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x00303280 File Offset: 0x00301680
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

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x003032CC File Offset: 0x003016CC
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x003032E0 File Offset: 0x003016E0
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

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x003032EC File Offset: 0x003016EC
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x00303300 File Offset: 0x00301700
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

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x0030330C File Offset: 0x0030170C
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x00303320 File Offset: 0x00301720
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

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x0030336C File Offset: 0x0030176C
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x00303380 File Offset: 0x00301780
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

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0030338C File Offset: 0x0030178C
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x003033A0 File Offset: 0x003017A0
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

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x003033EC File Offset: 0x003017EC
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x00303400 File Offset: 0x00301800
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

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0030340C File Offset: 0x0030180C
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x00303420 File Offset: 0x00301820
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

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x00303490 File Offset: 0x00301890
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x003034A4 File Offset: 0x003018A4
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

		// Token: 0x06000E78 RID: 3704 RVA: 0x003034B0 File Offset: 0x003018B0
		private void AtivaEfeitoOnChangeValue()
		{
			this.ToolStri_RT_810.Enabled = false;
			this.ToolStri_RT_810.Enabled = true;
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x003034CC File Offset: 0x003018CC
		public void Cria_ListaBaudRate()
		{
			perifericos.ListaBaudRate_IEC855.Clear();
			perifericos.ListaBaudRate_IEC855.Add(new perifericos.Valores_ComboBox("1200", "1200", 21856, false));
			perifericos.ListaBaudRate_IEC855.Add(new perifericos.Valores_ComboBox("9600", "9600", 21857, true));
			perifericos.ListaBaudRate_IEC855.Add(new perifericos.Valores_ComboBox("19200", "19200", 21858, false));
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00303540 File Offset: 0x00301940
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

		// Token: 0x06000E7B RID: 3707 RVA: 0x003035AC File Offset: 0x003019AC
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
				this.Atualiza_Tela856();
				this.ToolStripLabel_ID.Text = RT_geral.MontaNomePlacaPeloFabricante(RT_geral.IEC_855_BD.Equip.Valor, RT_geral.IEC_855_BD.Versao.Valor);
				RT_geral.Lmte_Init_ok = true;
			}
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x0030385C File Offset: 0x00301C5C
		private void RT_810_conf_Activated(object sender, EventArgs e)
		{
			Geral.Equipamento_selecionado = 856;
			Geral.Equipamento_versao = 3;
			Geral.Equipamento_build = 0;
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00303874 File Offset: 0x00301C74
		private void GeraDataGridView_IP()
		{
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00303878 File Offset: 0x00301C78
		public void Inicializa_DadosEStrutura855_Padrao()
		{
			RT_geral.IEC_855_BD.Versao.nome = "Versão";
			RT_geral.IEC_855_BD.Versao.Padrao = 0;
			RT_geral.IEC_855_BD.Build.nome = "Build";
			RT_geral.IEC_855_BD.Build.Padrao = 0;
			RT_geral.IEC_855_BD.Release.nome = "Release";
			RT_geral.IEC_855_BD.Release.Padrao = 0;
			RT_geral.IEC_855_BD.Equip.nome = "Tipo equipamento";
			RT_geral.IEC_855_BD.Equip.Padrao = 0;
			RT_geral.IEC_855_BD.MAC[0] = 0;
			RT_geral.IEC_855_BD.MAC[1] = 0;
			RT_geral.IEC_855_BD.MAC[2] = 0;
			RT_geral.IEC_855_BD.MAC[3] = 0;
			RT_geral.IEC_855_BD.MAC[4] = 0;
			RT_geral.IEC_855_BD.MAC[5] = 0;
			RT_geral.IEC_855_BD.DHCP_IP = "0.0.0.0";
			RT_geral.IEC_855_BD.DHCP_GW = "0.0.0.0";
			RT_geral.IEC_855_BD.DHCP_SM = "0.0.0.0";
			RT_geral.IEC_855_BD.STATIC_IP = "0.0.0.0";
			RT_geral.IEC_855_BD.STATIC_GW = "0.0.0.0";
			RT_geral.IEC_855_BD.STATIC_SM = "0.0.0.0";
			int i = 0;
			checked
			{
				do
				{
					RT_geral.IEC_855_BD.tab_ips[i] = "0.0.0.0";
					i++;
				}
				while (i <= 199);
				RT_geral.IEC_855_BD.AtribuicaoIP.nome = "Atribuicao IP";
				RT_geral.IEC_855_BD.AtribuicaoIP.Indice_padrao = 1;
				RT_geral.IEC_855_BD.AtribuicaoIP.Numero_itens = 2;
				RT_geral.IEC_855_BD.AtribuicaoIP.valores[0] = 43690;
				RT_geral.IEC_855_BD.AtribuicaoIP.valores[1] = 21845;
				RT_geral.IEC_855_BD.AtribuicaoIP.itens[0] = "Static - Fixo";
				RT_geral.IEC_855_BD.AtribuicaoIP.itens[1] = "Dinamic - DHCP";
				RT_geral.IEC_855_BD.BaudRateCOM1.nome = "BaudRate COM1";
				RT_geral.IEC_855_BD.BaudRateCOM1.Indice_padrao = perifericos.Lista_GetIndicePadrao(perifericos.ListaBaudRate_IEC855);
				RT_geral.IEC_855_BD.BaudRateCOM1.Numero_itens = perifericos.ListaBaudRate_IEC855.Count;
				int num = 0;
				int num2 = RT_geral.IEC_855_BD.BaudRateCOM1.Numero_itens - 1;
				for (i = num; i <= num2; i++)
				{
					RT_geral.IEC_855_BD.BaudRateCOM1.valores[i] = perifericos.ListaBaudRate_IEC855[i].valor;
					RT_geral.IEC_855_BD.BaudRateCOM1.itens[i] = perifericos.ListaBaudRate_IEC855[i].nome;
				}
				RT_geral.IEC_855_BD.filename = "";
			}
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00303B20 File Offset: 0x00301F20
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
			RT_geral.IEC_855_BD.BaudRateCOM1.Indice = 1;
			RT_geral.IEC_855_BD.BaudRateCOM1.Valor = RT_geral.IEC_855_BD.BaudRateCOM1.valores[RT_geral.IEC_855_BD.BaudRateCOM1.Indice];
			int num = 0;
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

		// Token: 0x06000E80 RID: 3712 RVA: 0x00303CC8 File Offset: 0x003020C8
		public void Atualiza_Tela856()
		{
			int num = 0;
			int num2 = 0;
			object obj = null;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
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
				goto IL_23A;
				IL_1E5:
				Interaction.MsgBox("Erro na atualização da tela!", (MsgBoxStyle)32, "Atenção - Erro de dados");
				goto IL_23A;
				IL_1F9:
				num2 = -1;
								IL_20D:;
			}
			catch (Exception) { }
			throw ProjectData.CreateProjectError(-2146828237);
			IL_23A:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00303F34 File Offset: 0x00302334
		public void Habilita_Funcoes_de_Tela_RT_810(int tipo)
		{
			this.GroupBox_informacoes.Enabled = false;
			this.GroupBox_ModoOperacao.Enabled = false;
			switch (tipo)
			{
			case 0:
				this.GroupBox_informacoes.Enabled = true;
				this.GroupBox_ModoOperacao.Enabled = true;
				break;
			}
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00303F88 File Offset: 0x00302388
		public void RT_810_Atualiza_Parametros_EA(int tipo)
		{
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00303F8C File Offset: 0x0030238C
		public void RT_810_Habilita_Pto_a_Pto(int modo)
		{
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00303F90 File Offset: 0x00302390
		public void AtualizaMsgTela_RT_810(string texto, int cor)
		{
			this.ToolStripTextBox_RT_810_Msg.Text = texto;
			if (cor == 0)
			{
				this.ToolStripTextBox_RT_810_Msg.ForeColor = Color.Blue;
			}
			else if (cor == 1)
			{
				this.ToolStripProgressBar_RT_810.Value = 0;
				this.ToolStripTextBox_RT_810_Msg.ForeColor = Color.Red;
			}
			else
			{
				this.ToolStripTextBox_RT_810_Msg.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00303FF4 File Offset: 0x003023F4
		public void EncerraEdicaoDeCampos()
		{
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00303FF8 File Offset: 0x003023F8
		public void Bloqueia_acoes()
		{
			this.ToolStripButton_RT_810_Abrir.Enabled = false;
			this.ToolStripButton_RT_810_novo.Enabled = false;
			this.ToolStripButton_RT_810_Salvar.Enabled = false;
			this.ToolStripButton_RT_810_Download.Enabled = false;
			this.ToolStripButton_RT_810_Upload.Enabled = false;
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x00304038 File Offset: 0x00302438
		public void Libera_acoes()
		{
			this.ToolStripButton_RT_810_Abrir.Enabled = true;
			this.ToolStripButton_RT_810_novo.Enabled = true;
			this.ToolStripButton_RT_810_Salvar.Enabled = true;
			if (Comunicacao.Config_sistema.tipo_interface == 1)
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
			else if (Comunicacao.Config_sistema.tipo_interface == 2)
			{
				this.ToolStripButton_RT_810_Download.Enabled = true;
				this.ToolStripButton_RT_810_Upload.Enabled = true;
			}
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x003040DC File Offset: 0x003024DC
		public void InicializaBarraProgressoTela_RT_810(int num_passos)
		{
			this.ToolStripProgressBar_RT_810.Minimum = 0;
			this.ToolStripProgressBar_RT_810.Maximum = checked(num_passos * 4);
			this.ToolStripProgressBar_RT_810.Step = num_passos;
			this.ToolStripProgressBar_RT_810.Value = 0;
			this.ToolStripProgressBar_RT_810.BackColor = Color.LightGray;
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0030412C File Offset: 0x0030252C
		private void Timer_limpa_MSG_Tick(object sender, EventArgs e)
		{
			this.Timer_limpa_MSG.Enabled = false;
			this.AtualizaMsgTela_RT_810("", 0);
			this.ToolStripProgressBar_RT_810.Value = 0;
			this.Libera_acoes();
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00304158 File Offset: 0x00302558
		private void CheckBox_hab_eletrodos_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0030415C File Offset: 0x0030255C
		private void ComboBox_metodo_operacao_Validating(object sender, CancelEventArgs e)
		{
			if (this.ComboBox_Modo_Operacao.FindStringExact(this.ComboBox_Modo_Operacao.Text) == -1)
			{
				Interaction.MsgBox("Opção digitada não existe!\r\nAssumindo Default!", (MsgBoxStyle)32, "Atenção - Método Operação");
				this.ComboBox_Modo_Operacao.SelectedIndex = 0;
			}
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00304198 File Offset: 0x00302598
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

		// Token: 0x06000E8D RID: 3725 RVA: 0x0030428C File Offset: 0x0030268C
		private void ComboBox_modo_repeticao_RT_810_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00304290 File Offset: 0x00302690
		private void ComboBox_modo_simulado_810_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00304294 File Offset: 0x00302694
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

		// Token: 0x06000E90 RID: 3728 RVA: 0x00304378 File Offset: 0x00302778
		private void NumericUpDown_intervalo_tx_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.IEC_855_BD.Intervalo_tx_pto_pto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.IEC_855_BD.Intervalo_tx_pto_pto, true);
			sender = numericUpDown;
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x003043CC File Offset: 0x003027CC
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

		// Token: 0x06000E92 RID: 3730 RVA: 0x00304464 File Offset: 0x00302864
		private void NumericUpDown_end_mestre_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.IEC_855_BD.End_mestre.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.IEC_855_BD.End_mestre, true);
			sender = numericUpDown;
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x003044B8 File Offset: 0x003028B8
		private void NumericUpDown_end_est_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.IEC_855_BD.End_estacao.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.IEC_855_BD.End_estacao, true);
			sender = numericUpDown;
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0030450C File Offset: 0x0030290C
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

		// Token: 0x06000E95 RID: 3733 RVA: 0x003045A4 File Offset: 0x003029A4
		private void NumericUpDown_tamanho_filtro_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.IEC_855_BD.AD_Tamanho_filtro.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.IEC_855_BD.AD_Tamanho_filtro, true);
			sender = numericUpDown;
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x003045F8 File Offset: 0x003029F8
		private void NumericUpDown_end_rep_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x003045FC File Offset: 0x003029FC
		private void NumericUpDown_num_est_rep_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00304600 File Offset: 0x00302A00
		private bool Entrada_Digital_Ja_Utilizada(int entrada, int num_ED)
		{
			bool result;
			return result;
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00304610 File Offset: 0x00302A10
		private void RT_810_conf_FormClosed(object sender, FormClosedEventArgs e)
		{
			RT_geral.Telas_RT_810.Configuracao = false;
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x00304620 File Offset: 0x00302A20
		private bool Endereco_Repetidora_Ja_Existente(ref DataGridView obj, ref RT_geral.Integer_ictel dado, DataGridViewCellValidatingEventArgs e, int posicao)
		{
			bool result;
			return result;
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00304630 File Offset: 0x00302A30
		public void Leitura_IEC_856_conf()
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
			Comunicacao.Ctrl_Com.Cont_rx = 0;
			this.InicializaBarraProgressoTela_RT_810(3);
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
			Linha_RT.Atualiza_dados_IER_856(0);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 2", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			Application.DoEvents();
			if (!Mod_MD.Leitura_pagina_multi_interface(512, 255, 2).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_IER_856(512);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 3", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			Application.DoEvents();
			if (!Mod_MD.Leitura_pagina_multi_interface(1024, 255, 12).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_IER_856(1024);
			this.Atualiza_Tela856();
			this.AtualizaMsgTela_RT_810("Configuração lida com sucesso", 0);
			this.ToolStripProgressBar_RT_810.PerformStep();
			Application.DoEvents();
			this.Timer_limpa_MSG.Enabled = true;
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x003047A4 File Offset: 0x00302BA4
		public void Gravar_IER_856_conf()
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
			Comunicacao.Ctrl_Com.Cont_rx = 0;
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
			if (!Mod_MD.Escrita_pagina_multi_interface(512, 90).Status)
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
			if (!Mod_MD.Escrita_pagina_multi_interface(1024, 90).Status)
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

		// Token: 0x06000E9D RID: 3741 RVA: 0x003049DC File Offset: 0x00302DDC
		private void ToolStripButton_RT_810_Download_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.Config_sistema.tipo_interface == 1)
			{
				if (Comunicacao.VerificaPortaSerialExiste())
				{
					this.Bloqueia_acoes();
					this.EncerraEdicaoDeCampos();
					this.Leitura_IEC_856_conf();
				}
				else
				{
					Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
				}
			}
			else if (Comunicacao.Config_sistema.tipo_interface == 2)
			{
				this.Bloqueia_acoes();
				this.EncerraEdicaoDeCampos();
				this.Leitura_IEC_856_conf();
			}
			else
			{
				Interaction.MsgBox("Não existe definição de tipo de interface de comunicação!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
			}
			Comunicacao.Config_sistema.endereco_encontrado = false;
			Comunicacao.Config_sistema.endereco_modbus = 0;
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00304A74 File Offset: 0x00302E74
		private void ToolStripButton_RT_810_novo_Click(object sender, EventArgs e)
		{
			RT_geral.Lmte_Init_ok = false;
			this.AtivaEfeitoOnChangeValue();
			this.Inicializa_DadosEStrutura855_Padrao();
			this.Inicializa_DadosEStrutura855_Default();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			RT_geral.IEC_855_BD.filename = "";
			this.Atualiza_Tela856();
			RT_geral.Lmte_Init_ok = true;
			this.AtualizaMsgTela_RT_810("Valores Default carregados", 0);
			this.Timer_limpa_MSG.Enabled = true;
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00304ADC File Offset: 0x00302EDC
		private void ToolStripButton_RT_810_Upload_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.Config_sistema.tipo_interface == 1)
			{
				if (Comunicacao.VerificaPortaSerialExiste())
				{
					this.Bloqueia_acoes();
					this.EncerraEdicaoDeCampos();
					if (!RT_geral.VerificaExixtenciaErroDados_IEC855())
					{
						this.Gravar_IER_856_conf();
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
			else if (Comunicacao.Config_sistema.tipo_interface == 2)
			{
				this.Bloqueia_acoes();
				this.EncerraEdicaoDeCampos();
				if (!RT_geral.VerificaExixtenciaErroDados_IEC855())
				{
					this.Gravar_IER_856_conf();
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
			Comunicacao.Config_sistema.endereco_modbus = 0;
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00304BE0 File Offset: 0x00302FE0
		[MethodImpl(72)]
		private void ToolStripButton_RT_810_Abrir_Click(object sender, EventArgs e)
		{
			checked
			{
				int num = 0;
				int num3 = 0;
				object obj = null;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					this.AtivaEfeitoOnChangeValue();
					this.OpenFileDialog_RT_810.Filter = "Arquivo de configuração de equipamento|*.Cfg855";
					this.OpenFileDialog_RT_810.InitialDirectory = Linha_RT.diretorio;
					if (this.OpenFileDialog_RT_810.ShowDialog() == 1 && Operators.CompareString(this.OpenFileDialog_RT_810.FileName, "", false) != 0)
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
							this.Atualiza_Tela856();
							RT_geral.Lmte_Init_ok = true;
							this.AtualizaMsgTela_RT_810("Valores Default carregados", 0);
							this.Timer_limpa_MSG.Enabled = true;
													}
						RT_geral.IEC_855_BD.filename = this.OpenFileDialog_RT_810.FileName;
						RT_geral.IEC_855_BD.End_estacao.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "ESTACAO", 0);
						RT_geral.IEC_855_BD.End_mestre.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "MESTRE", 0);
						RT_geral.IEC_855_BD.Tempo_ptt.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "TEMPO_PTT", 0);
						RT_geral.IEC_855_BD.BaudRateCOM1.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "BAUDRATE_COM1", 0);
						if (!perifericos.Lista_ValorPermitido(RT_geral.IEC_855_BD.BaudRateCOM1.Valor, perifericos.ListaBaudRate))
						{
							RT_geral.IEC_855_BD.BaudRateCOM1.Valor = 21857;
						}
						RT_geral.IEC_855_BD.BaudRateCOM1.Indice = perifericos.Get_Indice_Pelo_Valor(RT_geral.IEC_855_BD.BaudRateCOM1.Valor, perifericos.ListaBaudRate);
						Linha_RT.Atualiza_estrutura_combo(ref RT_geral.IEC_855_BD.AtribuicaoIP, iniFile.ReadInteger("GERAL_MODO_OPERCAO", "MODO", 0));
						RT_geral.IEC_855_BD.Intervalo_tx_pto_pto.Valor = iniFile.ReadInteger("GERAL_MODO_OPERCAO", "INTERVALO", 0);
						RT_geral.IEC_855_BD.AD_Intervalo.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "INTERVALO", 0);
						RT_geral.IEC_855_BD.AD_Tamanho_filtro.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "TAMANHO_FILTRO", 0);
						int num2 = 0;
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
						num2 = 0;
						do
						{
							string section = string.Format("CFG{0}_ED", num2 + 1);
							num2++;
						}
						while (num2 <= 7);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.IEC_855_BD.Setpoints_ctrl_variavel[0], RT_geral.RT_810_DataGrigViewSetpointsColunas[0], iniFile.ReadInteger("SETPOINT", "CTRL_VARIAVEL", 0));
						RT_geral.IEC_855_BD.Setpoints_ctrl_nivel_alto[0].Valor = iniFile.ReadInteger("SETPOINT", "NIVEL_ALTO", 0);
						RT_geral.IEC_855_BD.Setpoints_ctrl_nivel_baixo[0].Valor = iniFile.ReadInteger("SETPOINT", "NIVEL_BAIXO", 0);
						this.Atualiza_Tela856();
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
				catch (Exception) { }
				throw ProjectData.CreateProjectError(-2146828237);
				IL_645:
				if (num3 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00305258 File Offset: 0x00303658
		[MethodImpl(72)]
		private void ToolStripButton_RT_810_Salvar_Click(object sender, EventArgs e)
		{
			int num = 0;
			int num2 = 0;
			object obj = null;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				this.AtivaEfeitoOnChangeValue();
				this.Bloqueia_acoes();
				this.SaveFileDialog_RT_810.Filter = "Arquivo de configuração de equipamento|*.Cfg810";
				this.SaveFileDialog_RT_810.InitialDirectory = Linha_RT.diretorio;
				if (this.SaveFileDialog_RT_810.ShowDialog() == 1 && Operators.CompareString(this.SaveFileDialog_RT_810.FileName, "", false) != 0)
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
			catch (Exception) { }
			throw ProjectData.CreateProjectError(-2146828237);
			IL_351:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x003055DC File Offset: 0x003039DC
		private void DataGridView_setpoints_810_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x003055E0 File Offset: 0x003039E0
		private void DataGridView_setpoints_810_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x003055E4 File Offset: 0x003039E4
		private void DataGridView_setpoints_810_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x003055E8 File Offset: 0x003039E8
		private void DataGridView_processo_810_P1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x003055EC File Offset: 0x003039EC
		private void DataGridView_processo_810_P1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x003055F0 File Offset: 0x003039F0
		private void DataGridView_processo_810_P1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x003055F4 File Offset: 0x003039F4
		private void DataGridView_end_rep_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x003055F8 File Offset: 0x003039F8
		private void DataGridView_end_rep_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x003055FC File Offset: 0x003039FC
		private void DataGridView_end_rep_RT_810_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00305600 File Offset: 0x00303A00
		private void DataGridView_parametros_EA_810_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00305604 File Offset: 0x00303A04
		private void DataGridView_parametros_EA_810_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00305608 File Offset: 0x00303A08
		private void DataGridView_parametros_EA_810_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0030560C File Offset: 0x00303A0C
		private void DataGridView_RT810_ED_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00305610 File Offset: 0x00303A10
		private void DataGridView_RT810_ED_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00305614 File Offset: 0x00303A14
		private void ToolStripButton_RT_810_Imprimir_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			using (EnhancedPrintPreviewDialog enhancedPrintPreviewDialog = new EnhancedPrintPreviewDialog())
			{
				enhancedPrintPreviewDialog.Document = this.PrintDocument1;
				enhancedPrintPreviewDialog.ShowDialog();
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0030565C File Offset: 0x00303A5C
		private void TextBox_comentarios_RT810_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00305660 File Offset: 0x00303A60
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
			int num = 0;
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
				num = 0;
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

		// Token: 0x06000EB3 RID: 3763 RVA: 0x003060EC File Offset: 0x003044EC
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

		// Token: 0x06000EB4 RID: 3764 RVA: 0x003061B0 File Offset: 0x003045B0
		private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
		{
			this.pagina_impressao = 1;
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x003061BC File Offset: 0x003045BC
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

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0030620C File Offset: 0x0030460C
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.HasMorePages = this.DesenhaRelatorio(e);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0030621C File Offset: 0x0030461C
		private void TabPage_geral_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00306220 File Offset: 0x00304620
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00306224 File Offset: 0x00304624
		private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00306228 File Offset: 0x00304628
		private void RepetidoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00306234 File Offset: 0x00304634
		private void ToolStri_RT_810_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00306238 File Offset: 0x00304638
		private void TextBox_equipamento_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x0030623C File Offset: 0x0030463C
		private void GroupBox_sistema_leitura_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00306240 File Offset: 0x00304640
		private void Label73_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00306244 File Offset: 0x00304644
		private void GroupBox2_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00306248 File Offset: 0x00304648
		private void ComboBox_baudrate_COM1_810_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.IEC_855_BD.BaudRateCOM1.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.IEC_855_BD.BaudRateCOM1.AtualizaValorPeloIndice();
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00306284 File Offset: 0x00304684
		private void ComboBox_baudrate_COM2_810_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00306288 File Offset: 0x00304688
		private void Label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x0030628C File Offset: 0x0030468C
		public bool IPKeyPress(KeyPressEventArgs e)
		{
			bool result;
			if (char.IsDigit(e.KeyChar) | Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0 | Strings.Asc(e.KeyChar) == 46 | Strings.Asc(e.KeyChar) == 8 | Strings.Asc(e.KeyChar) == 39 | Strings.Asc(e.KeyChar) == 37)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00306304 File Offset: 0x00304704
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

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00306448 File Offset: 0x00304848
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

		// Token: 0x06000EC6 RID: 3782 RVA: 0x003064C0 File Offset: 0x003048C0
		private void tb_static_ip_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.IPKeyPress(e);
			if (flag)
			{
				return;
			}
			e.Handled = true;
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x003064E0 File Offset: 0x003048E0
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

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00306558 File Offset: 0x00304958
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

		// Token: 0x06000EC9 RID: 3785 RVA: 0x003065D0 File Offset: 0x003049D0
		private void tb_dhcp_ip_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x003065D4 File Offset: 0x003049D4
		private void DataGridView_RT810_ED_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x0400081B RID: 2075
		[AccessedThroughProperty("TabControl_810")]
		private TabControl _TabControl_810;

		// Token: 0x0400081C RID: 2076
		[AccessedThroughProperty("TabPage_geral")]
		private TabPage _TabPage_geral;

		// Token: 0x0400081D RID: 2077
		[AccessedThroughProperty("GroupBox_informacoes")]
		private GroupBox _GroupBox_informacoes;

		// Token: 0x0400081E RID: 2078
		[AccessedThroughProperty("ToolStri_RT_810")]
		private ToolStrip _ToolStri_RT_810;

		// Token: 0x0400081F RID: 2079
		[AccessedThroughProperty("ToolStripButton_RT_810_Abrir")]
		private ToolStripButton _ToolStripButton_RT_810_Abrir;

		// Token: 0x04000820 RID: 2080
		[AccessedThroughProperty("ToolStripButton_RT_810_Salvar")]
		private ToolStripButton _ToolStripButton_RT_810_Salvar;

		// Token: 0x04000821 RID: 2081
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x04000822 RID: 2082
		[AccessedThroughProperty("ToolStripButton_RT_810_Download")]
		private ToolStripButton _ToolStripButton_RT_810_Download;

		// Token: 0x04000823 RID: 2083
		[AccessedThroughProperty("ToolStripButton_RT_810_Upload")]
		private ToolStripButton _ToolStripButton_RT_810_Upload;

		// Token: 0x04000824 RID: 2084
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x04000825 RID: 2085
		[AccessedThroughProperty("ToolStripProgressBar_RT_810")]
		private ToolStripProgressBar _ToolStripProgressBar_RT_810;

		// Token: 0x04000826 RID: 2086
		[AccessedThroughProperty("ToolStripTextBox_RT_810_Msg")]
		private ToolStripTextBox _ToolStripTextBox_RT_810_Msg;

		// Token: 0x04000827 RID: 2087
		[AccessedThroughProperty("ToolStripButton_RT_810_novo")]
		private ToolStripButton _ToolStripButton_RT_810_novo;

		// Token: 0x04000828 RID: 2088
		[AccessedThroughProperty("OpenFileDialog_RT_810")]
		private OpenFileDialog _OpenFileDialog_RT_810;

		// Token: 0x04000829 RID: 2089
		[AccessedThroughProperty("SaveFileDialog_RT_810")]
		private SaveFileDialog _SaveFileDialog_RT_810;

		// Token: 0x0400082A RID: 2090
		[AccessedThroughProperty("Timer_limpa_MSG")]
		private Timer _Timer_limpa_MSG;

		// Token: 0x0400082B RID: 2091
		[AccessedThroughProperty("GroupBox_ModoOperacao")]
		private GroupBox _GroupBox_ModoOperacao;

		// Token: 0x0400082C RID: 2092
		[AccessedThroughProperty("ComboBox_Modo_Operacao")]
		private ComboBox _ComboBox_Modo_Operacao;

		// Token: 0x0400082D RID: 2093
		[AccessedThroughProperty("Label_MetodoOperacao")]
		private Label _Label_MetodoOperacao;

		// Token: 0x0400082E RID: 2094
		[AccessedThroughProperty("ToolStripButton_RT_810_Imprimir")]
		private ToolStripButton _ToolStripButton_RT_810_Imprimir;

		// Token: 0x0400082F RID: 2095
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x04000830 RID: 2096
		[AccessedThroughProperty("PrintDocument1")]
		private PrintDocument _PrintDocument1;

		// Token: 0x04000831 RID: 2097
		[AccessedThroughProperty("PrintPreviewDialog1")]
		private PrintPreviewDialog _PrintPreviewDialog1;

		// Token: 0x04000832 RID: 2098
		[AccessedThroughProperty("RepetidoraBindingSource1")]
		private BindingSource _RepetidoraBindingSource1;

		// Token: 0x04000833 RID: 2099
		[AccessedThroughProperty("ToolStripLabel_ID")]
		private ToolStripLabel _ToolStripLabel_ID;

		// Token: 0x04000834 RID: 2100
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x04000835 RID: 2101
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		// Token: 0x04000836 RID: 2102
		[AccessedThroughProperty("TextBox_equipamento")]
		private TextBox _TextBox_equipamento;

		// Token: 0x04000837 RID: 2103
		[AccessedThroughProperty("Label_equipamento")]
		private Label _Label_equipamento;

		// Token: 0x04000838 RID: 2104
		[AccessedThroughProperty("TextBox_release")]
		private TextBox _TextBox_release;

		// Token: 0x04000839 RID: 2105
		[AccessedThroughProperty("Label_release")]
		private Label _Label_release;

		// Token: 0x0400083A RID: 2106
		[AccessedThroughProperty("TextBox_build")]
		private TextBox _TextBox_build;

		// Token: 0x0400083B RID: 2107
		[AccessedThroughProperty("Label_build")]
		private Label _Label_build;

		// Token: 0x0400083C RID: 2108
		[AccessedThroughProperty("TextBox_versao")]
		private TextBox _TextBox_versao;

		// Token: 0x0400083D RID: 2109
		[AccessedThroughProperty("Label_versao")]
		private Label _Label_versao;

		// Token: 0x0400083E RID: 2110
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x0400083F RID: 2111
		[AccessedThroughProperty("ComboBox_baudrate")]
		private ComboBox _ComboBox_baudrate;

		// Token: 0x04000840 RID: 2112
		[AccessedThroughProperty("Label36")]
		private Label _Label36;

		// Token: 0x04000841 RID: 2113
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x04000842 RID: 2114
		[AccessedThroughProperty("tbMAC5")]
		private TextBox _tbMAC5;

		// Token: 0x04000843 RID: 2115
		[AccessedThroughProperty("tbMAC4")]
		private TextBox _tbMAC4;

		// Token: 0x04000844 RID: 2116
		[AccessedThroughProperty("tbMAC3")]
		private TextBox _tbMAC3;

		// Token: 0x04000845 RID: 2117
		[AccessedThroughProperty("tbMAC2")]
		private TextBox _tbMAC2;

		// Token: 0x04000846 RID: 2118
		[AccessedThroughProperty("tbMAC1")]
		private TextBox _tbMAC1;

		// Token: 0x04000847 RID: 2119
		[AccessedThroughProperty("tbMAC0")]
		private TextBox _tbMAC0;

		// Token: 0x04000848 RID: 2120
		[AccessedThroughProperty("tbMAC")]
		private Label _tbMAC;

		// Token: 0x04000849 RID: 2121
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x0400084A RID: 2122
		[AccessedThroughProperty("tb_dhcp_sm")]
		private TextBox _tb_dhcp_sm;

		// Token: 0x0400084B RID: 2123
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400084C RID: 2124
		[AccessedThroughProperty("tb_dhcp_gw")]
		private TextBox _tb_dhcp_gw;

		// Token: 0x0400084D RID: 2125
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400084E RID: 2126
		[AccessedThroughProperty("tb_dhcp_ip")]
		private TextBox _tb_dhcp_ip;

		// Token: 0x0400084F RID: 2127
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000850 RID: 2128
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x04000851 RID: 2129
		[AccessedThroughProperty("tb_static_sm")]
		private TextBox _tb_static_sm;

		// Token: 0x04000852 RID: 2130
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000853 RID: 2131
		[AccessedThroughProperty("tb_static_gw")]
		private TextBox _tb_static_gw;

		// Token: 0x04000854 RID: 2132
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000855 RID: 2133
		[AccessedThroughProperty("tb_static_ip")]
		private TextBox _tb_static_ip;

		// Token: 0x04000856 RID: 2134
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000857 RID: 2135
		private int pagina_impressao;
	}
}
