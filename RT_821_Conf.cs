using System;
using System.Collections;
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
	// Token: 0x02000055 RID: 85
	[DesignerGenerated]
	public partial class RT_821_Conf : Form
	{
		// Token: 0x060018F9 RID: 6393 RVA: 0x003AFBFC File Offset: 0x003ADFFC
		public RT_821_Conf()
		{
			base.Activated += new EventHandler(this.RT_821_Conf_Activated);
			base.FormClosed += new FormClosedEventHandler(this.RT_821_Conf_FormClosed);
			base.Load += new EventHandler(this.RT_821_Conf_Load);
			this.InitializeComponent();
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x003B5158 File Offset: 0x003B3558
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x003B516C File Offset: 0x003B356C
		internal virtual TabControl TabControl_821
		{
			get
			{
				return this._TabControl_821;
			}
			[MethodImpl(32)]
			set
			{
				this._TabControl_821 = value;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x003B5178 File Offset: 0x003B3578
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x003B518C File Offset: 0x003B358C
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

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x003B5198 File Offset: 0x003B3598
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x003B51AC File Offset: 0x003B35AC
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

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x003B51B8 File Offset: 0x003B35B8
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x003B51CC File Offset: 0x003B35CC
		internal virtual TabPage TabPage_setpoints
		{
			get
			{
				return this._TabPage_setpoints;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_setpoints = value;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x003B51D8 File Offset: 0x003B35D8
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x003B51EC File Offset: 0x003B35EC
		internal virtual TabPage TabPage_repetidora
		{
			get
			{
				return this._TabPage_repetidora;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_repetidora = value;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x003B51F8 File Offset: 0x003B35F8
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x003B520C File Offset: 0x003B360C
		internal virtual TabPage TabPage_ED
		{
			get
			{
				return this._TabPage_ED;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_ED = value;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x003B5218 File Offset: 0x003B3618
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x003B522C File Offset: 0x003B362C
		internal virtual TabPage TabPage_EA
		{
			get
			{
				return this._TabPage_EA;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_EA = value;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x003B5238 File Offset: 0x003B3638
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x003B524C File Offset: 0x003B364C
		internal virtual GroupBox GroupBox_descricao_RT821
		{
			get
			{
				return this._GroupBox_descricao_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_descricao_RT821 = value;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x003B5258 File Offset: 0x003B3658
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x003B526C File Offset: 0x003B366C
		internal virtual TextBox TextBox_comentarios_RT821
		{
			get
			{
				return this._TextBox_comentarios_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_comentarios_RT821 = value;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x003B5278 File Offset: 0x003B3678
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x003B528C File Offset: 0x003B368C
		internal virtual TextBox TextBox_endereco_RT821
		{
			get
			{
				return this._TextBox_endereco_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_endereco_RT821 = value;
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x003B5298 File Offset: 0x003B3698
		// (set) Token: 0x06001911 RID: 6417 RVA: 0x003B52AC File Offset: 0x003B36AC
		internal virtual TextBox TextBox_nome_RT821
		{
			get
			{
				return this._TextBox_nome_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_nome_RT821 = value;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x003B52B8 File Offset: 0x003B36B8
		// (set) Token: 0x06001913 RID: 6419 RVA: 0x003B52CC File Offset: 0x003B36CC
		internal virtual Label Label_comentarios_RT821
		{
			get
			{
				return this._Label_comentarios_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_comentarios_RT821 = value;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x003B52D8 File Offset: 0x003B36D8
		// (set) Token: 0x06001915 RID: 6421 RVA: 0x003B52EC File Offset: 0x003B36EC
		internal virtual Label Label_endereco_RT821
		{
			get
			{
				return this._Label_endereco_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_endereco_RT821 = value;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x003B52F8 File Offset: 0x003B36F8
		// (set) Token: 0x06001917 RID: 6423 RVA: 0x003B530C File Offset: 0x003B370C
		internal virtual Label Label_nome_RT821
		{
			get
			{
				return this._Label_nome_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nome_RT821 = value;
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x003B5318 File Offset: 0x003B3718
		// (set) Token: 0x06001919 RID: 6425 RVA: 0x003B532C File Offset: 0x003B372C
		internal virtual GroupBox GroupBox_informacoes_RT821
		{
			get
			{
				return this._GroupBox_informacoes_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_informacoes_RT821 = value;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x003B5338 File Offset: 0x003B3738
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x003B534C File Offset: 0x003B374C
		internal virtual GroupBox GroupBox_modelo_simulado_RT821
		{
			get
			{
				return this._GroupBox_modelo_simulado_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_modelo_simulado_RT821 = value;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x003B5358 File Offset: 0x003B3758
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x003B536C File Offset: 0x003B376C
		internal virtual ComboBox ComboBox_modo_simulado_RT_821
		{
			get
			{
				return this._ComboBox_modo_simulado_RT_821;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_modo_simulado_RT_821_SelectedIndexChanged);
				if (this._ComboBox_modo_simulado_RT_821 != null)
				{
					this._ComboBox_modo_simulado_RT_821.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_modo_simulado_RT_821 = value;
				if (this._ComboBox_modo_simulado_RT_821 != null)
				{
					this._ComboBox_modo_simulado_RT_821.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x003B53B8 File Offset: 0x003B37B8
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x003B53CC File Offset: 0x003B37CC
		internal virtual GroupBox GroupBox_comunicacao_RT821
		{
			get
			{
				return this._GroupBox_comunicacao_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_comunicacao_RT821 = value;
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x003B53D8 File Offset: 0x003B37D8
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x003B53EC File Offset: 0x003B37EC
		internal virtual NumericUpDown NumericUpDown_temp_ptt_RT821
		{
			get
			{
				return this._NumericUpDown_temp_ptt_RT821;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_temp_ptt_RT821_ValueChanged);
				if (this._NumericUpDown_temp_ptt_RT821 != null)
				{
					this._NumericUpDown_temp_ptt_RT821.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_temp_ptt_RT821 = value;
				if (this._NumericUpDown_temp_ptt_RT821 != null)
				{
					this._NumericUpDown_temp_ptt_RT821.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x003B5438 File Offset: 0x003B3838
		// (set) Token: 0x06001923 RID: 6435 RVA: 0x003B544C File Offset: 0x003B384C
		internal virtual NumericUpDown NumericUpDown_end_mestre_RT821
		{
			get
			{
				return this._NumericUpDown_end_mestre_RT821;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_mestre_RT821_ValueChanged);
				if (this._NumericUpDown_end_mestre_RT821 != null)
				{
					this._NumericUpDown_end_mestre_RT821.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_mestre_RT821 = value;
				if (this._NumericUpDown_end_mestre_RT821 != null)
				{
					this._NumericUpDown_end_mestre_RT821.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x003B5498 File Offset: 0x003B3898
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x003B54AC File Offset: 0x003B38AC
		internal virtual NumericUpDown NumericUpDown_end_est_RT821
		{
			get
			{
				return this._NumericUpDown_end_est_RT821;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_est_RT821_ValueChanged);
				if (this._NumericUpDown_end_est_RT821 != null)
				{
					this._NumericUpDown_end_est_RT821.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_est_RT821 = value;
				if (this._NumericUpDown_end_est_RT821 != null)
				{
					this._NumericUpDown_end_est_RT821.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x003B54F8 File Offset: 0x003B38F8
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x003B550C File Offset: 0x003B390C
		internal virtual Label Label_tempo_ptt_RT821
		{
			get
			{
				return this._Label_tempo_ptt_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_ptt_RT821 = value;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x003B5518 File Offset: 0x003B3918
		// (set) Token: 0x06001929 RID: 6441 RVA: 0x003B552C File Offset: 0x003B392C
		internal virtual Label Label_end_mestre_RT821
		{
			get
			{
				return this._Label_end_mestre_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_mestre_RT821 = value;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x003B5538 File Offset: 0x003B3938
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x003B554C File Offset: 0x003B394C
		internal virtual Label Label_end_est_RT821
		{
			get
			{
				return this._Label_end_est_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_est_RT821 = value;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x003B5558 File Offset: 0x003B3958
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x003B556C File Offset: 0x003B396C
		internal virtual GroupBox GroupBox_controle_RT821
		{
			get
			{
				return this._GroupBox_controle_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_controle_RT821 = value;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x003B5578 File Offset: 0x003B3978
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x003B558C File Offset: 0x003B398C
		internal virtual DataGridView DataGridView_processo_RT821
		{
			get
			{
				return this._DataGridView_processo_RT821;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_processo_RT821_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_processo_RT821_CellValidating);
				EventHandler eventHandler = new EventHandler(this.DataGridView_processo_RT821_CurrentCellDirtyStateChanged);
				if (this._DataGridView_processo_RT821 != null)
				{
					this._DataGridView_processo_RT821.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_processo_RT821.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_processo_RT821.CurrentCellDirtyStateChanged -= eventHandler;
				}
				this._DataGridView_processo_RT821 = value;
				if (this._DataGridView_processo_RT821 != null)
				{
					this._DataGridView_processo_RT821.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_processo_RT821.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_processo_RT821.CurrentCellDirtyStateChanged += eventHandler;
				}
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x003B5624 File Offset: 0x003B3A24
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x003B5638 File Offset: 0x003B3A38
		internal virtual GroupBox GroupBox_parametros_EA_RT821
		{
			get
			{
				return this._GroupBox_parametros_EA_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_parametros_EA_RT821 = value;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x003B5644 File Offset: 0x003B3A44
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x003B5658 File Offset: 0x003B3A58
		internal virtual DataGridView DataGridView_parametros_EA_RT821
		{
			get
			{
				return this._DataGridView_parametros_EA_RT821;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_parametros_EA_RT821_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_parametros_EA_RT821_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_parametros_EA_RT821_CellValidating);
				if (this._DataGridView_parametros_EA_RT821 != null)
				{
					this._DataGridView_parametros_EA_RT821.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_parametros_EA_RT821.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_parametros_EA_RT821.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_parametros_EA_RT821 = value;
				if (this._DataGridView_parametros_EA_RT821 != null)
				{
					this._DataGridView_parametros_EA_RT821.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_parametros_EA_RT821.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_parametros_EA_RT821.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x003B56F0 File Offset: 0x003B3AF0
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x003B5704 File Offset: 0x003B3B04
		internal virtual GroupBox GroupBox_EA_RT821
		{
			get
			{
				return this._GroupBox_EA_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_EA_RT821 = value;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x003B5710 File Offset: 0x003B3B10
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x003B5724 File Offset: 0x003B3B24
		internal virtual NumericUpDown NumericUpDown_intervalo_filtro_RT821
		{
			get
			{
				return this._NumericUpDown_intervalo_filtro_RT821;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_intervalo_filtro_RT821_ValueChanged);
				if (this._NumericUpDown_intervalo_filtro_RT821 != null)
				{
					this._NumericUpDown_intervalo_filtro_RT821.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_intervalo_filtro_RT821 = value;
				if (this._NumericUpDown_intervalo_filtro_RT821 != null)
				{
					this._NumericUpDown_intervalo_filtro_RT821.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x003B5770 File Offset: 0x003B3B70
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x003B5784 File Offset: 0x003B3B84
		internal virtual NumericUpDown NumericUpDown_tamanho_filtro_RT821
		{
			get
			{
				return this._NumericUpDown_tamanho_filtro_RT821;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_tamanho_filtro_RT821_ValueChanged);
				if (this._NumericUpDown_tamanho_filtro_RT821 != null)
				{
					this._NumericUpDown_tamanho_filtro_RT821.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_tamanho_filtro_RT821 = value;
				if (this._NumericUpDown_tamanho_filtro_RT821 != null)
				{
					this._NumericUpDown_tamanho_filtro_RT821.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x003B57D0 File Offset: 0x003B3BD0
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x003B57E4 File Offset: 0x003B3BE4
		internal virtual Label Label_intervalo_filtro_RT821
		{
			get
			{
				return this._Label_intervalo_filtro_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_intervalo_filtro_RT821 = value;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x003B57F0 File Offset: 0x003B3BF0
		// (set) Token: 0x0600193D RID: 6461 RVA: 0x003B5804 File Offset: 0x003B3C04
		internal virtual Label Label_tamanho_filtro_RT821
		{
			get
			{
				return this._Label_tamanho_filtro_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tamanho_filtro_RT821 = value;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x003B5810 File Offset: 0x003B3C10
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x003B5824 File Offset: 0x003B3C24
		internal virtual GroupBox GroupBox_ED_RT821
		{
			get
			{
				return this._GroupBox_ED_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_ED_RT821 = value;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x003B5830 File Offset: 0x003B3C30
		// (set) Token: 0x06001941 RID: 6465 RVA: 0x003B5844 File Offset: 0x003B3C44
		internal virtual DataGridView DataGridView_RT821_ED
		{
			get
			{
				return this._DataGridView_RT821_ED;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_RT821_ED_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_RT821_ED_CellValueChanged);
				if (this._DataGridView_RT821_ED != null)
				{
					this._DataGridView_RT821_ED.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_RT821_ED.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_RT821_ED = value;
				if (this._DataGridView_RT821_ED != null)
				{
					this._DataGridView_RT821_ED.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_RT821_ED.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x003B58B4 File Offset: 0x003B3CB4
		// (set) Token: 0x06001943 RID: 6467 RVA: 0x003B58C8 File Offset: 0x003B3CC8
		internal virtual GroupBox GroupBox_setpoints_RT821
		{
			get
			{
				return this._GroupBox_setpoints_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_setpoints_RT821 = value;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x003B58D4 File Offset: 0x003B3CD4
		// (set) Token: 0x06001945 RID: 6469 RVA: 0x003B58E8 File Offset: 0x003B3CE8
		internal virtual DataGridView DataGridView_setpoints_RT821
		{
			get
			{
				return this._DataGridView_setpoints_RT821;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_setpoints_RT821_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_setpoints_RT821_CellValidating);
				EventHandler eventHandler = new EventHandler(this.DataGridView_setpoints_RT821_CurrentCellDirtyStateChanged);
				if (this._DataGridView_setpoints_RT821 != null)
				{
					this._DataGridView_setpoints_RT821.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_setpoints_RT821.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_setpoints_RT821.CurrentCellDirtyStateChanged -= eventHandler;
				}
				this._DataGridView_setpoints_RT821 = value;
				if (this._DataGridView_setpoints_RT821 != null)
				{
					this._DataGridView_setpoints_RT821.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_setpoints_RT821.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_setpoints_RT821.CurrentCellDirtyStateChanged += eventHandler;
				}
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001946 RID: 6470 RVA: 0x003B5980 File Offset: 0x003B3D80
		// (set) Token: 0x06001947 RID: 6471 RVA: 0x003B5994 File Offset: 0x003B3D94
		internal virtual GroupBox GroupBox_end_rep_RT821
		{
			get
			{
				return this._GroupBox_end_rep_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_end_rep_RT821 = value;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x003B59A0 File Offset: 0x003B3DA0
		// (set) Token: 0x06001949 RID: 6473 RVA: 0x003B59B4 File Offset: 0x003B3DB4
		internal virtual DataGridView DataGridView_end_rep_RT821
		{
			get
			{
				return this._DataGridView_end_rep_RT821;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_end_rep_RT821_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_end_rep_RT821_CellValidating);
				EventHandler eventHandler = new EventHandler(this.DataGridView_end_rep_RT821_CurrentCellDirtyStateChanged);
				if (this._DataGridView_end_rep_RT821 != null)
				{
					this._DataGridView_end_rep_RT821.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_end_rep_RT821.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_end_rep_RT821.CurrentCellDirtyStateChanged -= eventHandler;
				}
				this._DataGridView_end_rep_RT821 = value;
				if (this._DataGridView_end_rep_RT821 != null)
				{
					this._DataGridView_end_rep_RT821.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_end_rep_RT821.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_end_rep_RT821.CurrentCellDirtyStateChanged += eventHandler;
				}
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x0600194A RID: 6474 RVA: 0x003B5A4C File Offset: 0x003B3E4C
		// (set) Token: 0x0600194B RID: 6475 RVA: 0x003B5A60 File Offset: 0x003B3E60
		internal virtual GroupBox GroupBox_parametros_repetidora_RT821
		{
			get
			{
				return this._GroupBox_parametros_repetidora_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_parametros_repetidora_RT821 = value;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x003B5A6C File Offset: 0x003B3E6C
		// (set) Token: 0x0600194D RID: 6477 RVA: 0x003B5A80 File Offset: 0x003B3E80
		internal virtual NumericUpDown NumericUpDown_num_est_rep_RT821
		{
			get
			{
				return this._NumericUpDown_num_est_rep_RT821;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_num_est_rep_RT821_ValueChanged);
				if (this._NumericUpDown_num_est_rep_RT821 != null)
				{
					this._NumericUpDown_num_est_rep_RT821.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_num_est_rep_RT821 = value;
				if (this._NumericUpDown_num_est_rep_RT821 != null)
				{
					this._NumericUpDown_num_est_rep_RT821.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x003B5ACC File Offset: 0x003B3ECC
		// (set) Token: 0x0600194F RID: 6479 RVA: 0x003B5AE0 File Offset: 0x003B3EE0
		internal virtual NumericUpDown NumericUpDown_end_rep_RT821
		{
			get
			{
				return this._NumericUpDown_end_rep_RT821;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_rep_RT821_ValueChanged);
				if (this._NumericUpDown_end_rep_RT821 != null)
				{
					this._NumericUpDown_end_rep_RT821.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_rep_RT821 = value;
				if (this._NumericUpDown_end_rep_RT821 != null)
				{
					this._NumericUpDown_end_rep_RT821.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x003B5B2C File Offset: 0x003B3F2C
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x003B5B40 File Offset: 0x003B3F40
		internal virtual Label Label_num_est_rep_RT821
		{
			get
			{
				return this._Label_num_est_rep_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_num_est_rep_RT821 = value;
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x003B5B4C File Offset: 0x003B3F4C
		// (set) Token: 0x06001953 RID: 6483 RVA: 0x003B5B60 File Offset: 0x003B3F60
		internal virtual Label Label_end_rep_RT821
		{
			get
			{
				return this._Label_end_rep_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_rep_RT821 = value;
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x003B5B6C File Offset: 0x003B3F6C
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x003B5B80 File Offset: 0x003B3F80
		internal virtual TabPage TabPage_Display
		{
			get
			{
				return this._TabPage_Display;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_Display = value;
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x003B5B8C File Offset: 0x003B3F8C
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x003B5BA0 File Offset: 0x003B3FA0
		internal virtual GroupBox GroupBox_visor_RT_821
		{
			get
			{
				return this._GroupBox_visor_RT_821;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_visor_RT_821 = value;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x003B5BAC File Offset: 0x003B3FAC
		// (set) Token: 0x06001959 RID: 6489 RVA: 0x003B5BC0 File Offset: 0x003B3FC0
		internal virtual DataGridView DataGridView_visor_RT_821
		{
			get
			{
				return this._DataGridView_visor_RT_821;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_visor_RT_821_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_visor_RT_821_CellValidating);
				EventHandler eventHandler = new EventHandler(this.DataGridView_visor_RT_821_CurrentCellDirtyStateChanged);
				if (this._DataGridView_visor_RT_821 != null)
				{
					this._DataGridView_visor_RT_821.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_visor_RT_821.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_visor_RT_821.CurrentCellDirtyStateChanged -= eventHandler;
				}
				this._DataGridView_visor_RT_821 = value;
				if (this._DataGridView_visor_RT_821 != null)
				{
					this._DataGridView_visor_RT_821.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_visor_RT_821.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_visor_RT_821.CurrentCellDirtyStateChanged += eventHandler;
				}
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x003B5C58 File Offset: 0x003B4058
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x003B5C6C File Offset: 0x003B406C
		internal virtual GroupBox GroupBox_MotoresSimultaneos_RT_821
		{
			get
			{
				return this._GroupBox_MotoresSimultaneos_RT_821;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_MotoresSimultaneos_RT_821 = value;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x003B5C78 File Offset: 0x003B4078
		// (set) Token: 0x0600195D RID: 6493 RVA: 0x003B5C8C File Offset: 0x003B408C
		internal virtual DataGridView DataGridView_MotoresSimultaneos_RT_821
		{
			get
			{
				return this._DataGridView_MotoresSimultaneos_RT_821;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_MotoresSimultaneos_RT_821_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_MotoresSimultaneos_RT_821_CellValidating);
				EventHandler eventHandler = new EventHandler(this.DataGridView_MotoresSimultaneos_RT_821_CurrentCellDirtyStateChanged);
				if (this._DataGridView_MotoresSimultaneos_RT_821 != null)
				{
					this._DataGridView_MotoresSimultaneos_RT_821.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_MotoresSimultaneos_RT_821.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_MotoresSimultaneos_RT_821.CurrentCellDirtyStateChanged -= eventHandler;
				}
				this._DataGridView_MotoresSimultaneos_RT_821 = value;
				if (this._DataGridView_MotoresSimultaneos_RT_821 != null)
				{
					this._DataGridView_MotoresSimultaneos_RT_821.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_MotoresSimultaneos_RT_821.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_MotoresSimultaneos_RT_821.CurrentCellDirtyStateChanged += eventHandler;
				}
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x003B5D24 File Offset: 0x003B4124
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x003B5D38 File Offset: 0x003B4138
		internal virtual OpenFileDialog OpenFileDialog_RT821
		{
			get
			{
				return this._OpenFileDialog_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._OpenFileDialog_RT821 = value;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x003B5D44 File Offset: 0x003B4144
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x003B5D58 File Offset: 0x003B4158
		internal virtual SaveFileDialog SaveFileDialog_RT821
		{
			get
			{
				return this._SaveFileDialog_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._SaveFileDialog_RT821 = value;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x003B5D64 File Offset: 0x003B4164
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x003B5D78 File Offset: 0x003B4178
		internal virtual Timer Timer_limpa_MSG_RT821
		{
			get
			{
				return this._Timer_limpa_MSG_RT821;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer_limpa_MSG_RT821_Tick);
				if (this._Timer_limpa_MSG_RT821 != null)
				{
					this._Timer_limpa_MSG_RT821.Tick -= eventHandler;
				}
				this._Timer_limpa_MSG_RT821 = value;
				if (this._Timer_limpa_MSG_RT821 != null)
				{
					this._Timer_limpa_MSG_RT821.Tick += eventHandler;
				}
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x003B5DC4 File Offset: 0x003B41C4
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x003B5DD8 File Offset: 0x003B41D8
		internal virtual ToolStrip ToolStri_RT821
		{
			get
			{
				return this._ToolStri_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStri_RT821 = value;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x003B5DE4 File Offset: 0x003B41E4
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x003B5DF8 File Offset: 0x003B41F8
		internal virtual ToolStripButton ToolStripButton_RT821_novo
		{
			get
			{
				return this._ToolStripButton_RT821_novo;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT821_novo_Click);
				if (this._ToolStripButton_RT821_novo != null)
				{
					this._ToolStripButton_RT821_novo.Click -= eventHandler;
				}
				this._ToolStripButton_RT821_novo = value;
				if (this._ToolStripButton_RT821_novo != null)
				{
					this._ToolStripButton_RT821_novo.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x003B5E44 File Offset: 0x003B4244
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x003B5E58 File Offset: 0x003B4258
		internal virtual ToolStripButton ToolStripButton_RT821_Abrir
		{
			get
			{
				return this._ToolStripButton_RT821_Abrir;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT821_Abrir_Click);
				if (this._ToolStripButton_RT821_Abrir != null)
				{
					this._ToolStripButton_RT821_Abrir.Click -= eventHandler;
				}
				this._ToolStripButton_RT821_Abrir = value;
				if (this._ToolStripButton_RT821_Abrir != null)
				{
					this._ToolStripButton_RT821_Abrir.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x003B5EA4 File Offset: 0x003B42A4
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x003B5EB8 File Offset: 0x003B42B8
		internal virtual ToolStripButton ToolStripButton_RT821_Salvar
		{
			get
			{
				return this._ToolStripButton_RT821_Salvar;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT821_Salvar_Click);
				if (this._ToolStripButton_RT821_Salvar != null)
				{
					this._ToolStripButton_RT821_Salvar.Click -= eventHandler;
				}
				this._ToolStripButton_RT821_Salvar = value;
				if (this._ToolStripButton_RT821_Salvar != null)
				{
					this._ToolStripButton_RT821_Salvar.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x003B5F04 File Offset: 0x003B4304
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x003B5F18 File Offset: 0x003B4318
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

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x003B5F24 File Offset: 0x003B4324
		// (set) Token: 0x0600196F RID: 6511 RVA: 0x003B5F38 File Offset: 0x003B4338
		internal virtual ToolStripButton ToolStripButton_RT821_Download
		{
			get
			{
				return this._ToolStripButton_RT821_Download;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT821_Download_Click);
				if (this._ToolStripButton_RT821_Download != null)
				{
					this._ToolStripButton_RT821_Download.Click -= eventHandler;
				}
				this._ToolStripButton_RT821_Download = value;
				if (this._ToolStripButton_RT821_Download != null)
				{
					this._ToolStripButton_RT821_Download.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x003B5F84 File Offset: 0x003B4384
		// (set) Token: 0x06001971 RID: 6513 RVA: 0x003B5F98 File Offset: 0x003B4398
		internal virtual ToolStripButton ToolStripButton_RT821_Upload
		{
			get
			{
				return this._ToolStripButton_RT821_Upload;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT821_Upload_Click);
				if (this._ToolStripButton_RT821_Upload != null)
				{
					this._ToolStripButton_RT821_Upload.Click -= eventHandler;
				}
				this._ToolStripButton_RT821_Upload = value;
				if (this._ToolStripButton_RT821_Upload != null)
				{
					this._ToolStripButton_RT821_Upload.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001972 RID: 6514 RVA: 0x003B5FE4 File Offset: 0x003B43E4
		// (set) Token: 0x06001973 RID: 6515 RVA: 0x003B5FF8 File Offset: 0x003B43F8
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

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x003B6004 File Offset: 0x003B4404
		// (set) Token: 0x06001975 RID: 6517 RVA: 0x003B6018 File Offset: 0x003B4418
		internal virtual ToolStripTextBox ToolStripTextBox_RT821_Msg
		{
			get
			{
				return this._ToolStripTextBox_RT821_Msg;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripTextBox_RT821_Msg = value;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x003B6024 File Offset: 0x003B4424
		// (set) Token: 0x06001977 RID: 6519 RVA: 0x003B6038 File Offset: 0x003B4438
		internal virtual ToolStripProgressBar ToolStripProgressBar_RT821
		{
			get
			{
				return this._ToolStripProgressBar_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripProgressBar_RT821 = value;
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x003B6044 File Offset: 0x003B4444
		// (set) Token: 0x06001979 RID: 6521 RVA: 0x003B6058 File Offset: 0x003B4458
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

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x003B6064 File Offset: 0x003B4464
		// (set) Token: 0x0600197B RID: 6523 RVA: 0x003B6078 File Offset: 0x003B4478
		internal virtual ToolStripButton ToolStripButton_RT821_Imprimir
		{
			get
			{
				return this._ToolStripButton_RT821_Imprimir;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT821_Imprimir_Click);
				if (this._ToolStripButton_RT821_Imprimir != null)
				{
					this._ToolStripButton_RT821_Imprimir.Click -= eventHandler;
				}
				this._ToolStripButton_RT821_Imprimir = value;
				if (this._ToolStripButton_RT821_Imprimir != null)
				{
					this._ToolStripButton_RT821_Imprimir.Click += eventHandler;
				}
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x003B60C4 File Offset: 0x003B44C4
		// (set) Token: 0x0600197D RID: 6525 RVA: 0x003B60D8 File Offset: 0x003B44D8
		internal virtual TabPage TabPage_DadosInstalacao
		{
			get
			{
				return this._TabPage_DadosInstalacao;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_DadosInstalacao = value;
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x003B60E4 File Offset: 0x003B44E4
		// (set) Token: 0x0600197F RID: 6527 RVA: 0x003B60F8 File Offset: 0x003B44F8
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

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x003B6104 File Offset: 0x003B4504
		// (set) Token: 0x06001981 RID: 6529 RVA: 0x003B6118 File Offset: 0x003B4518
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

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x003B6124 File Offset: 0x003B4524
		// (set) Token: 0x06001983 RID: 6531 RVA: 0x003B6138 File Offset: 0x003B4538
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

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001984 RID: 6532 RVA: 0x003B6144 File Offset: 0x003B4544
		// (set) Token: 0x06001985 RID: 6533 RVA: 0x003B6158 File Offset: 0x003B4558
		internal virtual TextBox T_ModeloFonte
		{
			get
			{
				return this._T_ModeloFonte;
			}
			[MethodImpl(32)]
			set
			{
				this._T_ModeloFonte = value;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x003B6164 File Offset: 0x003B4564
		// (set) Token: 0x06001987 RID: 6535 RVA: 0x003B6178 File Offset: 0x003B4578
		internal virtual TextBox T_AlturaAntena
		{
			get
			{
				return this._T_AlturaAntena;
			}
			[MethodImpl(32)]
			set
			{
				this._T_AlturaAntena = value;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001988 RID: 6536 RVA: 0x003B6184 File Offset: 0x003B4584
		// (set) Token: 0x06001989 RID: 6537 RVA: 0x003B6198 File Offset: 0x003B4598
		internal virtual TextBox T_Latitude
		{
			get
			{
				return this._T_Latitude;
			}
			[MethodImpl(32)]
			set
			{
				this._T_Latitude = value;
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x003B61A4 File Offset: 0x003B45A4
		// (set) Token: 0x0600198B RID: 6539 RVA: 0x003B61B8 File Offset: 0x003B45B8
		internal virtual TextBox T_Longitude
		{
			get
			{
				return this._T_Longitude;
			}
			[MethodImpl(32)]
			set
			{
				this._T_Longitude = value;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x003B61C4 File Offset: 0x003B45C4
		// (set) Token: 0x0600198D RID: 6541 RVA: 0x003B61D8 File Offset: 0x003B45D8
		internal virtual TextBox T_Azimute
		{
			get
			{
				return this._T_Azimute;
			}
			[MethodImpl(32)]
			set
			{
				this._T_Azimute = value;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x0600198E RID: 6542 RVA: 0x003B61E4 File Offset: 0x003B45E4
		// (set) Token: 0x0600198F RID: 6543 RVA: 0x003B61F8 File Offset: 0x003B45F8
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

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x003B6204 File Offset: 0x003B4604
		// (set) Token: 0x06001991 RID: 6545 RVA: 0x003B6218 File Offset: 0x003B4618
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

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001992 RID: 6546 RVA: 0x003B6224 File Offset: 0x003B4624
		// (set) Token: 0x06001993 RID: 6547 RVA: 0x003B6238 File Offset: 0x003B4638
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

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x003B6244 File Offset: 0x003B4644
		// (set) Token: 0x06001995 RID: 6549 RVA: 0x003B6258 File Offset: 0x003B4658
		internal virtual TextBox T_FreqRadio
		{
			get
			{
				return this._T_FreqRadio;
			}
			[MethodImpl(32)]
			set
			{
				this._T_FreqRadio = value;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x003B6264 File Offset: 0x003B4664
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x003B6278 File Offset: 0x003B4678
		internal virtual TextBox T_DistCentral
		{
			get
			{
				return this._T_DistCentral;
			}
			[MethodImpl(32)]
			set
			{
				this._T_DistCentral = value;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001998 RID: 6552 RVA: 0x003B6284 File Offset: 0x003B4684
		// (set) Token: 0x06001999 RID: 6553 RVA: 0x003B6298 File Offset: 0x003B4698
		internal virtual TextBox T_PotRadio
		{
			get
			{
				return this._T_PotRadio;
			}
			[MethodImpl(32)]
			set
			{
				this._T_PotRadio = value;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x003B62A4 File Offset: 0x003B46A4
		// (set) Token: 0x0600199B RID: 6555 RVA: 0x003B62B8 File Offset: 0x003B46B8
		internal virtual ComboBox CB_ModeloRadio
		{
			get
			{
				return this._CB_ModeloRadio;
			}
			[MethodImpl(32)]
			set
			{
				this._CB_ModeloRadio = value;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x003B62C4 File Offset: 0x003B46C4
		// (set) Token: 0x0600199D RID: 6557 RVA: 0x003B62D8 File Offset: 0x003B46D8
		internal virtual ComboBox CB_PolarizacaoAntena
		{
			get
			{
				return this._CB_PolarizacaoAntena;
			}
			[MethodImpl(32)]
			set
			{
				this._CB_PolarizacaoAntena = value;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x003B62E4 File Offset: 0x003B46E4
		// (set) Token: 0x0600199F RID: 6559 RVA: 0x003B62F8 File Offset: 0x003B46F8
		internal virtual ComboBox CB_TipoAntena
		{
			get
			{
				return this._CB_TipoAntena;
			}
			[MethodImpl(32)]
			set
			{
				this._CB_TipoAntena = value;
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x003B6304 File Offset: 0x003B4704
		// (set) Token: 0x060019A1 RID: 6561 RVA: 0x003B6318 File Offset: 0x003B4718
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

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x003B6324 File Offset: 0x003B4724
		// (set) Token: 0x060019A3 RID: 6563 RVA: 0x003B6338 File Offset: 0x003B4738
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

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x003B6344 File Offset: 0x003B4744
		// (set) Token: 0x060019A5 RID: 6565 RVA: 0x003B6358 File Offset: 0x003B4758
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

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x003B6364 File Offset: 0x003B4764
		// (set) Token: 0x060019A7 RID: 6567 RVA: 0x003B6378 File Offset: 0x003B4778
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

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x003B6384 File Offset: 0x003B4784
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x003B6398 File Offset: 0x003B4798
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

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x003B63A4 File Offset: 0x003B47A4
		// (set) Token: 0x060019AB RID: 6571 RVA: 0x003B63B8 File Offset: 0x003B47B8
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

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x003B63C4 File Offset: 0x003B47C4
		// (set) Token: 0x060019AD RID: 6573 RVA: 0x003B63D8 File Offset: 0x003B47D8
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

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x003B63E4 File Offset: 0x003B47E4
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x003B63F8 File Offset: 0x003B47F8
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

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x003B6404 File Offset: 0x003B4804
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x003B6418 File Offset: 0x003B4818
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

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x060019B2 RID: 6578 RVA: 0x003B6424 File Offset: 0x003B4824
		// (set) Token: 0x060019B3 RID: 6579 RVA: 0x003B6438 File Offset: 0x003B4838
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

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x060019B4 RID: 6580 RVA: 0x003B6444 File Offset: 0x003B4844
		// (set) Token: 0x060019B5 RID: 6581 RVA: 0x003B6458 File Offset: 0x003B4858
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

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x003B6464 File Offset: 0x003B4864
		// (set) Token: 0x060019B7 RID: 6583 RVA: 0x003B6478 File Offset: 0x003B4878
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

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x003B6510 File Offset: 0x003B4910
		// (set) Token: 0x060019B9 RID: 6585 RVA: 0x003B6524 File Offset: 0x003B4924
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

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x003B6530 File Offset: 0x003B4930
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x003B6544 File Offset: 0x003B4944
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

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x003B6550 File Offset: 0x003B4950
		// (set) Token: 0x060019BD RID: 6589 RVA: 0x003B6564 File Offset: 0x003B4964
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

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x003B6570 File Offset: 0x003B4970
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x003B6584 File Offset: 0x003B4984
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

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x003B6590 File Offset: 0x003B4990
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x003B65A4 File Offset: 0x003B49A4
		internal virtual TextBox TextBox_equipamento_RT821
		{
			get
			{
				return this._TextBox_equipamento_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_equipamento_RT821 = value;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x003B65B0 File Offset: 0x003B49B0
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x003B65C4 File Offset: 0x003B49C4
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

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x003B65D0 File Offset: 0x003B49D0
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x003B65E4 File Offset: 0x003B49E4
		internal virtual TextBox TextBox_release_RT821
		{
			get
			{
				return this._TextBox_release_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_release_RT821 = value;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x003B65F0 File Offset: 0x003B49F0
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x003B6604 File Offset: 0x003B4A04
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

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x003B6610 File Offset: 0x003B4A10
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x003B6624 File Offset: 0x003B4A24
		internal virtual TextBox TextBox_build_RT821
		{
			get
			{
				return this._TextBox_build_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_build_RT821 = value;
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x003B6630 File Offset: 0x003B4A30
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x003B6644 File Offset: 0x003B4A44
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

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x003B6650 File Offset: 0x003B4A50
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x003B6664 File Offset: 0x003B4A64
		internal virtual TextBox TextBox_versao_RT821
		{
			get
			{
				return this._TextBox_versao_RT821;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_versao_RT821 = value;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x003B6670 File Offset: 0x003B4A70
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x003B6684 File Offset: 0x003B4A84
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

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x003B6690 File Offset: 0x003B4A90
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x003B66A4 File Offset: 0x003B4AA4
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

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x003B66B0 File Offset: 0x003B4AB0
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x003B66C4 File Offset: 0x003B4AC4
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

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x003B66D0 File Offset: 0x003B4AD0
		// (set) Token: 0x060019D5 RID: 6613 RVA: 0x003B66E4 File Offset: 0x003B4AE4
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

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x003B66F0 File Offset: 0x003B4AF0
		// (set) Token: 0x060019D7 RID: 6615 RVA: 0x003B6704 File Offset: 0x003B4B04
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

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x003B6710 File Offset: 0x003B4B10
		// (set) Token: 0x060019D9 RID: 6617 RVA: 0x003B6724 File Offset: 0x003B4B24
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

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x003B6730 File Offset: 0x003B4B30
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x003B6744 File Offset: 0x003B4B44
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

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x003B6750 File Offset: 0x003B4B50
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x003B6764 File Offset: 0x003B4B64
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

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x003B6770 File Offset: 0x003B4B70
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x003B6784 File Offset: 0x003B4B84
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

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x003B6790 File Offset: 0x003B4B90
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x003B67A4 File Offset: 0x003B4BA4
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

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x003B67B0 File Offset: 0x003B4BB0
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x003B67C4 File Offset: 0x003B4BC4
		internal virtual ComboBox cb_modorepetidora
		{
			get
			{
				return this._cb_modorepetidora;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_modorepetidora_SelectedIndexChanged);
				if (this._cb_modorepetidora != null)
				{
					this._cb_modorepetidora.SelectedIndexChanged -= eventHandler;
				}
				this._cb_modorepetidora = value;
				if (this._cb_modorepetidora != null)
				{
					this._cb_modorepetidora.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x003B6810 File Offset: 0x003B4C10
		// (set) Token: 0x060019E5 RID: 6629 RVA: 0x003B6824 File Offset: 0x003B4C24
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

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x003B6830 File Offset: 0x003B4C30
		// (set) Token: 0x060019E7 RID: 6631 RVA: 0x003B6844 File Offset: 0x003B4C44
		internal virtual ComboBox ComboBox_Modo_Operacao
		{
			get
			{
				return this._ComboBox_Modo_Operacao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_Modo_Operacao_SelectedIndexChanged);
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

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x003B6890 File Offset: 0x003B4C90
		// (set) Token: 0x060019E9 RID: 6633 RVA: 0x003B68A4 File Offset: 0x003B4CA4
		internal virtual NumericUpDown NumericUpDown_IntervaloTX
		{
			get
			{
				return this._NumericUpDown_IntervaloTX;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_IntervaloTX_ValueChanged);
				if (this._NumericUpDown_IntervaloTX != null)
				{
					this._NumericUpDown_IntervaloTX.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_IntervaloTX = value;
				if (this._NumericUpDown_IntervaloTX != null)
				{
					this._NumericUpDown_IntervaloTX.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x003B68F0 File Offset: 0x003B4CF0
		// (set) Token: 0x060019EB RID: 6635 RVA: 0x003B6904 File Offset: 0x003B4D04
		internal virtual Label lb_ModoOperacao
		{
			get
			{
				return this._lb_ModoOperacao;
			}
			[MethodImpl(32)]
			set
			{
				this._lb_ModoOperacao = value;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x003B6910 File Offset: 0x003B4D10
		// (set) Token: 0x060019ED RID: 6637 RVA: 0x003B6924 File Offset: 0x003B4D24
		internal virtual Label lb_IntervaloTX
		{
			get
			{
				return this._lb_IntervaloTX;
			}
			[MethodImpl(32)]
			set
			{
				this._lb_IntervaloTX = value;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x003B6930 File Offset: 0x003B4D30
		// (set) Token: 0x060019EF RID: 6639 RVA: 0x003B6944 File Offset: 0x003B4D44
		internal virtual ComboBox cb_baudrate_com2
		{
			get
			{
				return this._cb_baudrate_com2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_baudrate_com2_SelectedIndexChanged);
				if (this._cb_baudrate_com2 != null)
				{
					this._cb_baudrate_com2.SelectedIndexChanged -= eventHandler;
				}
				this._cb_baudrate_com2 = value;
				if (this._cb_baudrate_com2 != null)
				{
					this._cb_baudrate_com2.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x003B6990 File Offset: 0x003B4D90
		// (set) Token: 0x060019F1 RID: 6641 RVA: 0x003B69A4 File Offset: 0x003B4DA4
		internal virtual ComboBox cb_baudrate_com1
		{
			get
			{
				return this._cb_baudrate_com1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_baudrate_com1_SelectedIndexChanged);
				if (this._cb_baudrate_com1 != null)
				{
					this._cb_baudrate_com1.SelectedIndexChanged -= eventHandler;
				}
				this._cb_baudrate_com1 = value;
				if (this._cb_baudrate_com1 != null)
				{
					this._cb_baudrate_com1.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x003B69F0 File Offset: 0x003B4DF0
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x003B6A04 File Offset: 0x003B4E04
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

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x003B6A10 File Offset: 0x003B4E10
		// (set) Token: 0x060019F5 RID: 6645 RVA: 0x003B6A24 File Offset: 0x003B4E24
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

		// Token: 0x060019F6 RID: 6646 RVA: 0x003B6A30 File Offset: 0x003B4E30
		private void AtivaEfeitoOnChangeValue()
		{
			this.ToolStri_RT821.Enabled = false;
			this.tb_lixo1.Focus();
			this.tb_lixo2.Focus();
			this.tb_lixo3.Focus();
			this.tb_lixo4.Focus();
			this.tb_lixo5.Focus();
			this.tb_lixo6.Focus();
			this.tb_lixo7.Focus();
			this.tb_lixo8.Focus();
			this.ToolStri_RT821.Enabled = true;
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x003B6AB8 File Offset: 0x003B4EB8
		private void RT_821_Conf_Load(object sender, EventArgs e)
		{
			RT_geral.Lmte_Init_ok = false;
			RT_geral.RT_821_BD.Modelo.valores = new int[4];
			RT_geral.RT_821_BD.Modelo.itens = new string[4];
			RT_geral.RT_821_BD.ctrl_acionamento = new RT_geral.Combo_ictel_ctrl[4];
			RT_geral.RT_821_BD.ctrl_ret_acionamento = new RT_geral.Combo_ictel_ctrl[4];
			RT_geral.RT_821_BD.ctrl_ED_selecao = new RT_geral.Combo_ictel_ctrl[4];
			RT_geral.RT_821_BD.ctrl_reverso = new RT_geral.Combo_ictel_ctrl[4];
			RT_geral.RT_821_BD.ctrl_modo = new RT_geral.Combo_ictel_ctrl[4];
			RT_geral.RT_821_BD.ctrl_tempo_max_partida = new RT_geral.Integer_ictel[4];
			RT_geral.RT_821_BD.ctrl_tempo_max_parada = new RT_geral.Integer_ictel[4];
			RT_geral.RT_821_BD.motores_simultaneos = new RT_geral.Combo_ictel_ctrl[2];
			RT_geral.RT_821_BD.motores_tempo_entre_acionamentos = new RT_geral.Integer_ictel[2];
			RT_geral.RT_821_BD.EA_Range = new RT_geral.Integer_ictel[5];
			RT_geral.RT_821_BD.EA_Inicio = new RT_geral.Integer_ictel[5];
			RT_geral.RT_821_BD.EA_Fim = new RT_geral.Integer_ictel[5];
			RT_geral.RT_821_BD.config_ED = new RT_geral.Combo_ictel_ctrl[9];
			RT_geral.RT_821_BD.dsp_escalas = new RT_geral.Integer_ictel[9];
			RT_geral.RT_821_BD.dsp_pto_decimal = new RT_geral.Combo_ictel_ctrl[9];
			RT_geral.RT_821_BD.dsp_nome = new RT_geral.String_ictel[9];
			RT_geral.RT_821_BD.dsp_hab = new RT_geral.Integer_ictel[9];
			RT_geral.RT_821_BD.modo_repetidora.valores = new int[3];
			RT_geral.RT_821_BD.modo_repetidora.itens = new string[3];
			RT_geral.RT_821_BD.Repetidoras = new RT_geral.Integer_ictel[52];
			RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto = new RT_geral.Integer_ictel[4];
			RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo = new RT_geral.Integer_ictel[4];
			RT_geral.RT_821_BD.Setpoints_ctrl_variavel = new RT_geral.Combo_ictel_ctrl[10];
			RT_geral.RT_821_BD.modo_operacao.valores = new int[4];
			RT_geral.RT_821_BD.modo_operacao.itens = new string[4];
			perifericos.Cria_ListaBaudRate();
			checked
			{
				RT_geral.RT_821_BD.baudrate_com1.itens = new string[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_821_BD.baudrate_com1.valores = new int[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_821_BD.baudrate_com2.itens = new string[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_821_BD.baudrate_com2.valores = new int[perifericos.ListaBaudRate.Count + 1];
				this.Inicializa_DadosEStruturaRT821_Padrao();
				RT_geral.Lmte_Init_ok = true;
				this.InicializaEstrutura_DataGridView_Processos_RT_821();
				this.GeraDataGridView_Processos_RT_821();
				this.InicializaEstrutura_DataGridView_MotoresSimultaneos_RT_821();
				this.GeraDataGridView_MotoresSimultaneos_RT_821();
				this.InicializaEstrutura_DataGridView_EA_RT_821();
				this.GeraDataGridView_EA_RT_821();
				this.InicializaEstrutura_DataGridView_repetidora_RT_821();
				this.GeraDataGridView_Repedidora_RT_821();
				this.InicializaEstrutura_DataGridView_Setpoints_RT_821();
				this.GeraDataGridView_Setpoints_RT_821();
				this.InicializaEstrutura_DataGridView_ED_RT_821();
				this.GeraDataGridView_ED_RT_821();
				this.InicializaEstrutura_DataGridView_Visor_RT_821();
				this.GeraDataGridView_Visor_RT_821();
				this.Inicializa_DadosEStruturaRT821_Default();
				ComboBox comboBox = this.ComboBox_modo_simulado_RT_821;
				Linha_RT.CarregaCombo(ref comboBox, RT_geral.RT_821_BD.Modelo);
				this.ComboBox_modo_simulado_RT_821 = comboBox;
				comboBox = this.cb_modorepetidora;
				Linha_RT.CarregaCombo(ref comboBox, RT_geral.RT_821_BD.modo_repetidora);
				this.cb_modorepetidora = comboBox;
				comboBox = this.ComboBox_Modo_Operacao;
				Linha_RT.CarregaCombo(ref comboBox, RT_geral.RT_821_BD.modo_operacao);
				this.ComboBox_Modo_Operacao = comboBox;
				comboBox = this.cb_baudrate_com1;
				Linha_RT.CarregaCombo(ref comboBox, RT_geral.RT_821_BD.baudrate_com1);
				this.cb_baudrate_com1 = comboBox;
				comboBox = this.cb_baudrate_com2;
				Linha_RT.CarregaCombo(ref comboBox, RT_geral.RT_821_BD.baudrate_com2);
				this.cb_baudrate_com2 = comboBox;
				Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
				this.TabPage_geral.BackColor = Color.FromKnownColor(8);
				this.TabPage_geral.ForeColor = Color.FromKnownColor(10);
				this.TabPage_controles.BackColor = Color.FromKnownColor(8);
				this.TabPage_controles.ForeColor = Color.FromKnownColor(10);
				this.TabPage_EA.BackColor = Color.FromKnownColor(8);
				this.TabPage_EA.ForeColor = Color.FromKnownColor(10);
				this.TabPage_ED.BackColor = Color.FromKnownColor(8);
				this.TabPage_ED.ForeColor = Color.FromKnownColor(10);
				this.TabPage_setpoints.BackColor = Color.FromKnownColor(8);
				this.TabPage_setpoints.ForeColor = Color.FromKnownColor(10);
				this.TabPage_repetidora.BackColor = Color.FromKnownColor(8);
				this.TabPage_repetidora.ForeColor = Color.FromKnownColor(10);
				this.TabPage_Display.BackColor = Color.FromKnownColor(8);
				this.TabPage_Display.ForeColor = Color.FromKnownColor(10);
				this.TabPage_DadosInstalacao.BackColor = Color.FromKnownColor(8);
				this.TabPage_DadosInstalacao.ForeColor = Color.FromKnownColor(10);
				string text = ".\\\\Fontes\\\\Ictel Extendida Italic.ttf";
				if (MyProject.Computer.FileSystem.FileExists(text))
				{
					PrivateFontCollection privateFontCollection = new PrivateFontCollection();
					privateFontCollection.AddFontFile(text);
					Font font = new Font(privateFontCollection.Families[0], 8f, 2);
					Font font2 = new Font(privateFontCollection.Families[0], 18f, 2);
					this.Label26.Font = font;
					this.TextBox_equipamento_RT821.Font = font;
					this.TextBox_versao_RT821.Font = font;
					this.TextBox_build_RT821.Font = font;
					this.TextBox_release_RT821.Font = font;
					this.ToolStripLabel1.Font = font2;
				}
				else
				{
					MessageBox.Show("Removido fonte Ictel Extendida Italic da pasta da aplicação!");
				}
				this.Atualiza_Tela_RT_821();
				this.ToolStripLabel1.Text = RT_geral.MontaNomePlacaPeloFabricante(RT_geral.RT_821_BD.Equip.Valor, RT_geral.RT_821_BD.Versao.Valor);
			}
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x003B7030 File Offset: 0x003B5430
		private void RT_821_Conf_Activated(object sender, EventArgs e)
		{
			Geral.Equipamento_selecionado = 821;
			Geral.Equipamento_versao = 3;
			Geral.Equipamento_build = 0;
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x003B7048 File Offset: 0x003B5448
		public void Inicializa_DadosEStruturaRT821_Padrao()
		{
			RT_geral.RT_821_BD.Modelo.nome = "Modelo do Equipamento Emulado";
			RT_geral.RT_821_BD.Modelo.Indice_padrao = 0;
			RT_geral.RT_821_BD.Modelo.Numero_itens = 1;
			RT_geral.RT_821_BD.Modelo.valores[0] = 21856;
			RT_geral.RT_821_BD.Modelo.itens[0] = "RT 821";
			RT_geral.RT_821_BD.Versao.nome = "Versão";
			RT_geral.RT_821_BD.Versao.Padrao = 0;
			RT_geral.RT_821_BD.Build.nome = "Build";
			RT_geral.RT_821_BD.Build.Padrao = 3;
			RT_geral.RT_821_BD.Release.nome = "Release";
			RT_geral.RT_821_BD.Release.Padrao = 0;
			RT_geral.RT_821_BD.Equip.nome = "Tipo equipamento";
			RT_geral.RT_821_BD.Equip.Padrao = 821;
			RT_geral.RT_821_BD.End_estacao.nome = "Endereço Estação";
			RT_geral.RT_821_BD.End_estacao.Padrao = 1;
			RT_geral.RT_821_BD.End_estacao.Lmte_inf = 1;
			RT_geral.RT_821_BD.End_estacao.Lmte_sup = 200;
			RT_geral.RT_821_BD.End_mestre.nome = "Endereço Mestre";
			RT_geral.RT_821_BD.End_mestre.Padrao = 100;
			RT_geral.RT_821_BD.End_mestre.Lmte_inf = 1;
			RT_geral.RT_821_BD.End_mestre.Lmte_sup = 200;
			RT_geral.RT_821_BD.Tempo_ptt.nome = "Tempo PTT";
			RT_geral.RT_821_BD.Tempo_ptt.Padrao = 200;
			RT_geral.RT_821_BD.Tempo_ptt.Lmte_inf = 100;
			RT_geral.RT_821_BD.Tempo_ptt.Lmte_sup = 2000;
			RT_geral.RT_821_BD.modo_operacao.nome = "Modo Operação";
			RT_geral.RT_821_BD.modo_operacao.Indice_padrao = 0;
			RT_geral.RT_821_BD.modo_operacao.Numero_itens = 3;
			RT_geral.RT_821_BD.modo_operacao.itens[0] = "Rede";
			RT_geral.RT_821_BD.modo_operacao.itens[1] = "Ponto à Ponto - COM1";
			RT_geral.RT_821_BD.modo_operacao.itens[2] = "Ponto à Ponto - COM2";
			RT_geral.RT_821_BD.modo_operacao.valores[0] = 21856;
			RT_geral.RT_821_BD.modo_operacao.valores[1] = 21857;
			RT_geral.RT_821_BD.modo_operacao.valores[2] = 21858;
			RT_geral.RT_821_BD.intervalo_tx.nome = "Intervalo de Transmissão";
			RT_geral.RT_821_BD.intervalo_tx.Padrao = 3;
			RT_geral.RT_821_BD.intervalo_tx.Lmte_inf = 1;
			RT_geral.RT_821_BD.intervalo_tx.Lmte_sup = 43200;
			RT_geral.RT_821_BD.baudrate_com1.nome = "BaudRate COM1";
			RT_geral.RT_821_BD.baudrate_com1.Numero_itens = perifericos.ListaBaudRate.Count;
			RT_geral.RT_821_BD.baudrate_com1.Indice_padrao = 0;
			int num = 0;
			checked
			{
				int num2 = perifericos.ListaBaudRate.Count - 1;
				int i;
				for (i = num; i <= num2; i++)
				{
					RT_geral.RT_821_BD.baudrate_com1.itens[i] = perifericos.ListaBaudRate[i].nome;
					RT_geral.RT_821_BD.baudrate_com1.valores[i] = perifericos.ListaBaudRate[i].valor;
					if (perifericos.ListaBaudRate[i].is_default)
					{
						RT_geral.RT_821_BD.baudrate_com1.Indice_padrao = i;
					}
				}
				RT_geral.RT_821_BD.baudrate_com2.nome = "BaudRate COM2";
				RT_geral.RT_821_BD.baudrate_com2.Numero_itens = perifericos.ListaBaudRate.Count;
				RT_geral.RT_821_BD.baudrate_com2.Indice_padrao = 0;
				int num3 = 0;
				int num4 = perifericos.ListaBaudRate.Count - 1;
				for (i = num3; i <= num4; i++)
				{
					RT_geral.RT_821_BD.baudrate_com2.itens[i] = perifericos.ListaBaudRate[i].nome;
					RT_geral.RT_821_BD.baudrate_com2.valores[i] = perifericos.ListaBaudRate[i].valor;
					if (perifericos.ListaBaudRate[i].is_default)
					{
						RT_geral.RT_821_BD.baudrate_com2.Indice_padrao = i;
					}
				}
				RT_geral.RT_821_BD.modo_repetidora.nome = "Modo Repetidora";
				RT_geral.RT_821_BD.modo_repetidora.Indice_padrao = 0;
				RT_geral.RT_821_BD.modo_repetidora.Numero_itens = 2;
				RT_geral.RT_821_BD.modo_repetidora.itens[0] = "Desabilitado";
				RT_geral.RT_821_BD.modo_repetidora.itens[1] = "Direto";
				RT_geral.RT_821_BD.modo_repetidora.valores[0] = 21856;
				RT_geral.RT_821_BD.modo_repetidora.valores[1] = 21857;
				i = 0;
				do
				{
					RT_geral.RT_821_BD.ctrl_acionamento[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - SD acinamento";
					RT_geral.RT_821_BD.ctrl_acionamento[i].Indice_padrao = 0;
					RT_geral.RT_821_BD.ctrl_ret_acionamento[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - ED acionamento";
					RT_geral.RT_821_BD.ctrl_ret_acionamento[i].Indice_padrao = 0;
					RT_geral.RT_821_BD.ctrl_ED_selecao[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - ED Remoto";
					RT_geral.RT_821_BD.ctrl_ED_selecao[i].Indice_padrao = 0;
					RT_geral.RT_821_BD.ctrl_reverso[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Reverso ";
					RT_geral.RT_821_BD.ctrl_reverso[i].Indice_padrao = 0;
					RT_geral.RT_821_BD.ctrl_modo[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Modo ";
					RT_geral.RT_821_BD.ctrl_modo[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 2);
				i = 0;
				do
				{
					RT_geral.RT_821_BD.ctrl_tempo_max_partida[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Tempo máx partida";
					RT_geral.RT_821_BD.ctrl_tempo_max_partida[i].Padrao = 180;
					RT_geral.RT_821_BD.ctrl_tempo_max_partida[i].Lmte_inf = 0;
					RT_geral.RT_821_BD.ctrl_tempo_max_partida[i].Lmte_sup = 1200;
					RT_geral.RT_821_BD.ctrl_tempo_max_parada[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Tempo máx parada";
					RT_geral.RT_821_BD.ctrl_tempo_max_parada[i].Padrao = 180;
					RT_geral.RT_821_BD.ctrl_tempo_max_parada[i].Lmte_inf = 0;
					RT_geral.RT_821_BD.ctrl_tempo_max_parada[i].Lmte_sup = 1200;
					i++;
				}
				while (i <= 2);
				i = 0;
				do
				{
					RT_geral.RT_821_BD.motores_simultaneos[i].nome = "Motores - Simultâneos";
					RT_geral.RT_821_BD.motores_simultaneos[i].Indice_padrao = 2;
					RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[i].nome = "Motores - Tempo entre acionamentos";
					RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[i].Padrao = 0;
					RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[i].Lmte_inf = 0;
					RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[i].Lmte_sup = 1200;
					i++;
				}
				while (i <= 0);
				i = 0;
				do
				{
					RT_geral.RT_821_BD.EA_Range[i].nome = "Range sensor " + Conversion.Str(i + 1);
					RT_geral.RT_821_BD.EA_Range[i].Padrao = 4000;
					RT_geral.RT_821_BD.EA_Range[i].Lmte_inf = 0;
					RT_geral.RT_821_BD.EA_Range[i].Lmte_sup = 50000;
					RT_geral.RT_821_BD.EA_Inicio[i].nome = "Início sensor " + Conversion.Str(i + 1);
					RT_geral.RT_821_BD.EA_Inicio[i].Padrao = 0;
					RT_geral.RT_821_BD.EA_Inicio[i].Lmte_inf = 0;
					RT_geral.RT_821_BD.EA_Inicio[i].Lmte_sup = 20000;
					RT_geral.RT_821_BD.EA_Fim[i].nome = "Fim sensor " + Conversion.Str(i + 1);
					RT_geral.RT_821_BD.EA_Fim[i].Padrao = 4000;
					RT_geral.RT_821_BD.EA_Fim[i].Lmte_inf = 0;
					RT_geral.RT_821_BD.EA_Fim[i].Lmte_sup = 50000;
					i++;
				}
				while (i <= 3);
				RT_geral.RT_821_BD.AD_Intervalo.nome = "Intervalo AD";
				RT_geral.RT_821_BD.AD_Intervalo.Padrao = 1000;
				RT_geral.RT_821_BD.AD_Intervalo.Lmte_inf = 500;
				RT_geral.RT_821_BD.AD_Intervalo.Lmte_sup = 20000;
				RT_geral.RT_821_BD.AD_Tamanho_filtro.nome = "Tamanho Filtro AD";
				RT_geral.RT_821_BD.AD_Tamanho_filtro.Padrao = 3;
				RT_geral.RT_821_BD.AD_Tamanho_filtro.Lmte_inf = 1;
				RT_geral.RT_821_BD.AD_Tamanho_filtro.Lmte_sup = 10;
				i = 0;
				do
				{
					RT_geral.RT_821_BD.config_ED[i].nome = "ED " + Conversion.Str(i + 1);
					RT_geral.RT_821_BD.config_ED[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 7);
				i = 0;
				do
				{
					RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[i].nome = "Setpoint Alto " + Conversion.Str(i + 1);
					RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[i].Padrao = 4000;
					RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[i].Lmte_inf = 0;
					RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[i].Lmte_sup = 4000;
					RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[i].nome = "Setpoint Baixo " + Conversion.Str(i + 1);
					RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[i].Padrao = 0;
					RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[i].Lmte_inf = 0;
					RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[i].Lmte_sup = 4000;
					i++;
				}
				while (i <= 2);
				i = 0;
				do
				{
					RT_geral.RT_821_BD.Setpoints_ctrl_variavel[i].nome = "Setpoint " + Conversion.Str(i + 1) + "Variável de Controle";
					RT_geral.RT_821_BD.Setpoints_ctrl_variavel[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 7);
				RT_geral.RT_821_BD.modo_repetidora.nome = "Modo Repetidora";
				RT_geral.RT_821_BD.modo_repetidora.Indice_padrao = 0;
				RT_geral.RT_821_BD.modo_repetidora.Numero_itens = 2;
				RT_geral.RT_821_BD.modo_repetidora.itens[0] = "Desabilitado";
				RT_geral.RT_821_BD.modo_repetidora.itens[1] = "Direto";
				RT_geral.RT_821_BD.modo_repetidora.valores[0] = 21856;
				RT_geral.RT_821_BD.modo_repetidora.valores[1] = 21857;
				RT_geral.RT_821_BD.End_repetidora.nome = "Endereço Repetidora";
				RT_geral.RT_821_BD.End_repetidora.Padrao = 1;
				RT_geral.RT_821_BD.End_repetidora.Lmte_inf = 1;
				RT_geral.RT_821_BD.End_repetidora.Lmte_sup = 200;
				RT_geral.RT_821_BD.Num_repetidoras.nome = "Número de Repetidoras";
				RT_geral.RT_821_BD.Num_repetidoras.Padrao = 0;
				RT_geral.RT_821_BD.Num_repetidoras.Lmte_inf = 0;
				RT_geral.RT_821_BD.Num_repetidoras.Lmte_sup = 50;
				i = 0;
				do
				{
					RT_geral.RT_821_BD.Repetidoras[i].nome = "Endereço da Repetidora " + Conversion.Str(i + 1);
					RT_geral.RT_821_BD.Repetidoras[i].Padrao = 0;
					RT_geral.RT_821_BD.Repetidoras[i].Lmte_inf = 0;
					RT_geral.RT_821_BD.Repetidoras[i].Lmte_sup = 200;
					i++;
				}
				while (i <= 49);
				i = 0;
				do
				{
					RT_geral.RT_821_BD.dsp_escalas[i].nome = "Mensagem n° " + Conversion.Str(i + 1) + " - Escala";
					RT_geral.RT_821_BD.dsp_escalas[i].Padrao = 100;
					RT_geral.RT_821_BD.dsp_escalas[i].Lmte_inf = 0;
					RT_geral.RT_821_BD.dsp_escalas[i].Lmte_sup = 999;
					RT_geral.RT_821_BD.dsp_pto_decimal[i].nome = "Mensagem n° " + Conversion.Str(i + 1) + " - Ponto decimal";
					RT_geral.RT_821_BD.dsp_pto_decimal[i].Indice_padrao = 0;
					RT_geral.RT_821_BD.dsp_nome[i].nome = "Mensagem n° " + Conversion.Str(i + 1) + " - Nome";
					RT_geral.RT_821_BD.dsp_nome[i].Padrao = "   ";
					RT_geral.RT_821_BD.dsp_hab[i].nome = "Mensagem n° " + Conversion.Str(i + 1) + " - Habilição";
					RT_geral.RT_821_BD.dsp_hab[i].Padrao = 0;
					i++;
				}
				while (i <= 7);
			}
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x003B7EC0 File Offset: 0x003B62C0
		public void Inicializa_DadosEStruturaRT821_Default()
		{
			RT_geral.RT_821_BD.Modelo.Valor = RT_geral.RT_821_BD.Modelo.valores[RT_geral.RT_821_BD.Modelo.Indice];
			RT_geral.RT_821_BD.Versao.Valor = RT_geral.RT_821_BD.Equip.Padrao;
			RT_geral.RT_821_BD.Build.Valor = RT_geral.RT_821_BD.Build.Padrao;
			RT_geral.RT_821_BD.Release.Valor = RT_geral.RT_821_BD.Release.Padrao;
			RT_geral.RT_821_BD.Equip.Valor = RT_geral.RT_821_BD.Equip.Padrao;
			RT_geral.RT_821_BD.End_estacao.Valor = RT_geral.RT_821_BD.End_estacao.Padrao;
			RT_geral.RT_821_BD.End_mestre.Valor = RT_geral.RT_821_BD.End_mestre.Padrao;
			RT_geral.RT_821_BD.Tempo_ptt.Valor = RT_geral.RT_821_BD.Tempo_ptt.Padrao;
			RT_geral.RT_821_BD.modo_operacao.IndicePadrao();
			RT_geral.RT_821_BD.intervalo_tx.ValorPadrao();
			RT_geral.RT_821_BD.baudrate_com1.AtualizaValorPeloIndice();
			RT_geral.RT_821_BD.baudrate_com2.AtualizaValorPeloIndice();
			this.TextBox_comentarios_RT821.Text = "";
			this.TextBox_endereco_RT821.Text = "";
			this.TextBox_nome_RT821.Text = "";
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_821_BD.ctrl_acionamento[num].Indice = RT_geral.RT_821_BD.ctrl_acionamento[num].Indice_padrao;
					RT_geral.RT_821_BD.ctrl_acionamento[num].Valor = RT_geral.RT_821_DataGrigViewProcessosColunas[0].LinhasValor[RT_geral.RT_821_BD.ctrl_acionamento[num].Indice];
					RT_geral.RT_821_BD.ctrl_ret_acionamento[num].Indice = RT_geral.RT_821_BD.ctrl_ret_acionamento[num].Indice_padrao;
					RT_geral.RT_821_BD.ctrl_ret_acionamento[num].Valor = RT_geral.RT_821_DataGrigViewProcessosColunas[1].LinhasValor[RT_geral.RT_821_BD.ctrl_ret_acionamento[num].Indice];
					RT_geral.RT_821_BD.ctrl_ED_selecao[num].Indice = RT_geral.RT_821_BD.ctrl_ED_selecao[num].Indice_padrao;
					RT_geral.RT_821_BD.ctrl_ED_selecao[num].Valor = RT_geral.RT_821_DataGrigViewProcessosColunas[2].LinhasValor[RT_geral.RT_821_BD.ctrl_ED_selecao[num].Indice];
					RT_geral.RT_821_BD.ctrl_reverso[num].Indice = RT_geral.RT_821_BD.ctrl_reverso[num].Indice_padrao;
					RT_geral.RT_821_BD.ctrl_reverso[num].Valor = RT_geral.RT_821_DataGrigViewProcessosColunas[3].LinhasValor[RT_geral.RT_821_BD.ctrl_reverso[num].Indice];
					RT_geral.RT_821_BD.ctrl_modo[num].Indice = RT_geral.RT_821_BD.ctrl_modo[num].Indice_padrao;
					RT_geral.RT_821_BD.ctrl_modo[num].Valor = RT_geral.RT_821_DataGrigViewProcessosColunas[4].LinhasValor[RT_geral.RT_821_BD.ctrl_modo[num].Indice];
					RT_geral.RT_821_BD.ctrl_tempo_max_partida[num].Valor = RT_geral.RT_821_BD.ctrl_tempo_max_partida[num].Padrao;
					RT_geral.RT_821_BD.ctrl_tempo_max_parada[num].Valor = RT_geral.RT_821_BD.ctrl_tempo_max_parada[num].Padrao;
					num++;
				}
				while (num <= 2);
				num = 0;
				do
				{
					RT_geral.RT_821_BD.motores_simultaneos[num].Indice = RT_geral.RT_821_BD.motores_simultaneos[num].Indice_padrao;
					RT_geral.RT_821_BD.motores_simultaneos[num].Valor = RT_geral.RT_821_DataGrigViewProcessosColunas[0].LinhasValor[RT_geral.RT_821_BD.motores_simultaneos[num].Indice];
					RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[num].Valor = RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[num].Padrao;
					num++;
				}
				while (num <= 0);
				num = 0;
				do
				{
					RT_geral.RT_821_BD.EA_Range[num].Valor = RT_geral.RT_821_BD.EA_Range[num].Padrao;
					RT_geral.RT_821_BD.EA_Inicio[num].Valor = RT_geral.RT_821_BD.EA_Inicio[num].Padrao;
					RT_geral.RT_821_BD.EA_Fim[num].Valor = RT_geral.RT_821_BD.EA_Fim[num].Padrao;
					num++;
				}
				while (num <= 3);
				RT_geral.RT_821_BD.AD_Intervalo.Valor = RT_geral.RT_821_BD.AD_Intervalo.Padrao;
				RT_geral.RT_821_BD.AD_Tamanho_filtro.Valor = RT_geral.RT_821_BD.AD_Tamanho_filtro.Padrao;
				num = 0;
				do
				{
					RT_geral.RT_821_BD.config_ED[num].Indice = RT_geral.RT_821_BD.config_ED[num].Indice_padrao;
					RT_geral.RT_821_BD.config_ED[num].Valor = RT_geral.RT_821_DataGrigViewEDColunas[0].LinhasValor[RT_geral.RT_821_BD.config_ED[num].Indice];
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[num].Valor = RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[num].Padrao;
					RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[num].Valor = RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[num].Padrao;
					RT_geral.RT_821_BD.Setpoints_ctrl_variavel[num].Indice = RT_geral.RT_821_BD.Setpoints_ctrl_variavel[num].Indice_padrao;
					RT_geral.RT_821_BD.Setpoints_ctrl_variavel[num].Valor = RT_geral.RT_821_DataGrigViewSetpointsColunas[0].LinhasValor[RT_geral.RT_821_BD.Setpoints_ctrl_variavel[num].Indice];
					num++;
				}
				while (num <= 3);
				RT_geral.RT_821_BD.modo_repetidora.IndicePadrao();
				RT_geral.RT_821_BD.End_repetidora.Valor = RT_geral.RT_821_BD.End_repetidora.Padrao;
				RT_geral.RT_821_BD.Num_repetidoras.Valor = RT_geral.RT_821_BD.Num_repetidoras.Padrao;
				num = 0;
				do
				{
					RT_geral.RT_821_BD.Repetidoras[num].Valor = RT_geral.RT_821_BD.Repetidoras[num].Padrao;
					num++;
				}
				while (num <= 49);
				num = 0;
				do
				{
					RT_geral.RT_821_BD.dsp_escalas[num].Valor = RT_geral.RT_821_BD.dsp_escalas[num].Padrao;
					RT_geral.RT_821_BD.dsp_pto_decimal[num].Indice = RT_geral.RT_821_BD.dsp_pto_decimal[num].Indice_padrao;
					RT_geral.RT_821_BD.dsp_nome[num].Valor = RT_geral.RT_821_BD.dsp_nome[num].Padrao;
					RT_geral.RT_821_BD.dsp_hab[num].Valor = RT_geral.RT_821_BD.dsp_hab[num].Padrao;
					num++;
				}
				while (num <= 7);
			}
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x003B8660 File Offset: 0x003B6A60
		private void GeraDataGridView_Processos_RT_821()
		{
			this.DataGridView_processo_RT821.Columns.Clear();
			this.DataGridView_processo_RT821.CellBorderStyle = 1;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_821_DataGrigViewProcessosColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_821_DataGrigViewProcessosColunas);
						this.DataGridView_processo_RT821.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_821_DataGrigViewProcessosColunas);
						this.DataGridView_processo_RT821.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 6);
				this.DataGridView_processo_RT821.RowCount = 3;
				this.DataGridView_processo_RT821.RowHeadersWidth = 80;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_processo_RT821.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "Ctrl " + Strings.Format(num2, "0#");
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

		// Token: 0x060019FC RID: 6652 RVA: 0x003B8794 File Offset: 0x003B6B94
		private void InicializaEstrutura_DataGridView_Processos_RT_821()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_821_DataGrigViewProcessosColunas[num].LinhasMenu = new string[10];
					RT_geral.RT_821_DataGrigViewProcessosColunas[num].LinhasValor = new int[10];
					num++;
				}
				while (num <= 7);
				RT_geral.RT_821_DataGrigViewProcessosColunas[0].TagColuna = "Acionamento";
				RT_geral.RT_821_DataGrigViewProcessosColunas[1].TagColuna = "Retorno";
				RT_geral.RT_821_DataGrigViewProcessosColunas[2].TagColuna = "Remoto";
				RT_geral.RT_821_DataGrigViewProcessosColunas[3].TagColuna = "Reverso";
				RT_geral.RT_821_DataGrigViewProcessosColunas[4].TagColuna = "Modo";
				RT_geral.RT_821_DataGrigViewProcessosColunas[5].TagColuna = "Tempo Partida (s)";
				RT_geral.RT_821_DataGrigViewProcessosColunas[6].TagColuna = "Tempo Parada (s)";
				RT_geral.RT_821_DataGrigViewProcessosColunas[0].NomeColuna = "SDAciona";
				RT_geral.RT_821_DataGrigViewProcessosColunas[1].NomeColuna = "EDRetAci";
				RT_geral.RT_821_DataGrigViewProcessosColunas[2].NomeColuna = "EDRemoto";
				RT_geral.RT_821_DataGrigViewProcessosColunas[3].NomeColuna = "Reverso";
				RT_geral.RT_821_DataGrigViewProcessosColunas[4].NomeColuna = "ModoCtrl";
				RT_geral.RT_821_DataGrigViewProcessosColunas[5].NomeColuna = "TpMaxPart";
				RT_geral.RT_821_DataGrigViewProcessosColunas[6].NomeColuna = "TpMaxParada";
				RT_geral.RT_821_DataGrigViewProcessosColunas[0].LarguraColuna = 100;
				RT_geral.RT_821_DataGrigViewProcessosColunas[1].LarguraColuna = 100;
				RT_geral.RT_821_DataGrigViewProcessosColunas[2].LarguraColuna = 110;
				RT_geral.RT_821_DataGrigViewProcessosColunas[3].LarguraColuna = 100;
				RT_geral.RT_821_DataGrigViewProcessosColunas[4].LarguraColuna = 100;
				RT_geral.RT_821_DataGrigViewProcessosColunas[5].LarguraColuna = 80;
				RT_geral.RT_821_DataGrigViewProcessosColunas[6].LarguraColuna = 80;
				RT_geral.RT_821_DataGrigViewProcessosColunas[0].AlingColuna = 32;
				RT_geral.RT_821_DataGrigViewProcessosColunas[1].AlingColuna = 32;
				RT_geral.RT_821_DataGrigViewProcessosColunas[2].AlingColuna = 32;
				RT_geral.RT_821_DataGrigViewProcessosColunas[3].AlingColuna = 32;
				RT_geral.RT_821_DataGrigViewProcessosColunas[4].AlingColuna = 32;
				RT_geral.RT_821_DataGrigViewProcessosColunas[5].AlingColuna = 64;
				RT_geral.RT_821_DataGrigViewProcessosColunas[6].AlingColuna = 64;
				RT_geral.RT_821_DataGrigViewProcessosColunas[0].LinhasMenu[0] = "Desativo";
				RT_geral.RT_821_DataGrigViewProcessosColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_821_DataGrigViewProcessosColunas[0].NumeroLinhaMenu = 4;
				num = 1;
				do
				{
					RT_geral.RT_821_DataGrigViewProcessosColunas[0].LinhasMenu[num] = "SD - " + Strings.Format(num, "0#");
					RT_geral.RT_821_DataGrigViewProcessosColunas[0].LinhasValor[num] = 21856 + num;
					num++;
				}
				while (num <= 3);
				RT_geral.RT_821_DataGrigViewProcessosColunas[1].LinhasMenu[0] = "Não usado";
				RT_geral.RT_821_DataGrigViewProcessosColunas[1].LinhasValor[0] = 21856;
				RT_geral.RT_821_DataGrigViewProcessosColunas[1].NumeroLinhaMenu = 9;
				RT_geral.RT_821_DataGrigViewProcessosColunas[2].LinhasMenu[0] = "Sempre Remoto";
				RT_geral.RT_821_DataGrigViewProcessosColunas[2].LinhasValor[0] = 21856;
				RT_geral.RT_821_DataGrigViewProcessosColunas[2].NumeroLinhaMenu = 9;
				num = 1;
				do
				{
					RT_geral.RT_821_DataGrigViewProcessosColunas[1].LinhasMenu[num] = "ED - " + Strings.Format(num, "0#");
					RT_geral.RT_821_DataGrigViewProcessosColunas[1].LinhasValor[num] = 21856 + num;
					RT_geral.RT_821_DataGrigViewProcessosColunas[2].LinhasMenu[num] = "ED - " + Strings.Format(num, "0#");
					RT_geral.RT_821_DataGrigViewProcessosColunas[2].LinhasValor[num] = 21856 + num;
					num++;
				}
				while (num <= 8);
				RT_geral.RT_821_DataGrigViewProcessosColunas[3].NumeroLinhaMenu = 2;
				RT_geral.RT_821_DataGrigViewProcessosColunas[3].NumeroLinhaMenu = 2;
				RT_geral.RT_821_DataGrigViewProcessosColunas[3].LinhasMenu[0] = "Desabilitado";
				RT_geral.RT_821_DataGrigViewProcessosColunas[3].LinhasMenu[1] = "Habilitado";
				RT_geral.RT_821_DataGrigViewProcessosColunas[3].LinhasValor[0] = 21856;
				RT_geral.RT_821_DataGrigViewProcessosColunas[3].LinhasValor[1] = 21857;
				RT_geral.RT_821_DataGrigViewProcessosColunas[4].NumeroLinhaMenu = 2;
				RT_geral.RT_821_DataGrigViewProcessosColunas[4].LinhasMenu[0] = "Telecomando";
				RT_geral.RT_821_DataGrigViewProcessosColunas[4].LinhasMenu[1] = "Automático";
				RT_geral.RT_821_DataGrigViewProcessosColunas[4].LinhasValor[0] = 21856;
				RT_geral.RT_821_DataGrigViewProcessosColunas[4].LinhasValor[1] = 21857;
				RT_geral.RT_821_DataGrigViewProcessosColunas[5].NumeroLinhaMenu = 0;
				RT_geral.RT_821_DataGrigViewProcessosColunas[6].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x003B8CB0 File Offset: 0x003B70B0
		private void GeraDataGridView_MotoresSimultaneos_RT_821()
		{
			this.DataGridView_MotoresSimultaneos_RT_821.Columns.Clear();
			this.DataGridView_MotoresSimultaneos_RT_821.CellBorderStyle = 1;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_821_DataGrigMotoresSimultaneosColunas);
						this.DataGridView_MotoresSimultaneos_RT_821.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_821_DataGrigMotoresSimultaneosColunas);
						this.DataGridView_MotoresSimultaneos_RT_821.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 1);
				this.DataGridView_MotoresSimultaneos_RT_821.RowCount = 1;
				this.DataGridView_MotoresSimultaneos_RT_821.RowHeadersWidth = 90;
			}
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x003B8D58 File Offset: 0x003B7158
		private void InicializaEstrutura_DataGridView_MotoresSimultaneos_RT_821()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[num].LinhasMenu = new string[5];
					RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[num].LinhasValor = new int[5];
					num++;
				}
				while (num <= 0);
				RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[0].TagColuna = "Controles Simultâneos";
				RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[1].TagColuna = "Tempo Entre Acionamentos (s)";
				RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[0].NomeColuna = "MSimultaneos";
				RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[1].NomeColuna = "TpAcionamentos";
				RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[0].LarguraColuna = 100;
				RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[1].LarguraColuna = 120;
				RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[0].AlingColuna = 32;
				RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[1].AlingColuna = 64;
				RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[0].NumeroLinhaMenu = 3;
				RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[0].LinhasMenu[0] = "1 Controle";
				RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[0].LinhasMenu[1] = "2 Controles";
				RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[0].LinhasMenu[2] = "3 Controles";
				RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[0].LinhasValor[0] = 21857;
				RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[0].LinhasValor[1] = 21858;
				RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[0].LinhasValor[2] = 21859;
				RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[1].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x003B8EE4 File Offset: 0x003B72E4
		private void GeraDataGridView_EA_RT_821()
		{
			this.DataGridView_parametros_EA_RT821.Columns.Clear();
			this.DataGridView_parametros_EA_RT821.CellBorderStyle = 1;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_821_DataGrigViewEAColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_821_DataGrigViewEAColunas);
						this.DataGridView_parametros_EA_RT821.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_821_DataGrigViewEAColunas);
						this.DataGridView_parametros_EA_RT821.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 2);
				this.DataGridView_parametros_EA_RT821.RowCount = 4;
				this.DataGridView_parametros_EA_RT821.RowHeadersWidth = 70;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_parametros_EA_RT821.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "EA " + Strings.Format(num2, "0#");
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

		// Token: 0x06001A00 RID: 6656 RVA: 0x003B9018 File Offset: 0x003B7418
		private void InicializaEstrutura_DataGridView_EA_RT_821()
		{
			RT_geral.RT_821_DataGrigViewEAColunas[0].TagColuna = "Range";
			RT_geral.RT_821_DataGrigViewEAColunas[1].TagColuna = "Início";
			RT_geral.RT_821_DataGrigViewEAColunas[2].TagColuna = "Fim";
			RT_geral.RT_821_DataGrigViewEAColunas[0].NomeColuna = "range";
			RT_geral.RT_821_DataGrigViewEAColunas[1].NomeColuna = "ini";
			RT_geral.RT_821_DataGrigViewEAColunas[2].NomeColuna = "fim";
			RT_geral.RT_821_DataGrigViewEAColunas[0].LarguraColuna = 90;
			RT_geral.RT_821_DataGrigViewEAColunas[1].LarguraColuna = 90;
			RT_geral.RT_821_DataGrigViewEAColunas[2].LarguraColuna = 90;
			RT_geral.RT_821_DataGrigViewEAColunas[0].AlingColuna = 64;
			RT_geral.RT_821_DataGrigViewEAColunas[1].AlingColuna = 64;
			RT_geral.RT_821_DataGrigViewEAColunas[2].AlingColuna = 64;
			RT_geral.RT_821_DataGrigViewEAColunas[0].NumeroLinhaMenu = 0;
			RT_geral.RT_821_DataGrigViewEAColunas[1].NumeroLinhaMenu = 0;
			RT_geral.RT_821_DataGrigViewEAColunas[2].NumeroLinhaMenu = 0;
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x003B9144 File Offset: 0x003B7544
		private void GeraDataGridView_Repedidora_RT_821()
		{
			this.DataGridView_end_rep_RT821.Columns.Clear();
			this.DataGridView_end_rep_RT821.CellBorderStyle = 1;
			this.DataGridView_end_rep_RT821.DefaultCellStyle.Alignment = 64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_821_DataGrigViewRepetidoraColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_821_DataGrigViewRepetidoraColunas);
						this.DataGridView_end_rep_RT821.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_821_DataGrigViewRepetidoraColunas);
						this.DataGridView_end_rep_RT821.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 9);
				this.DataGridView_end_rep_RT821.RowCount = 10;
				this.DataGridView_end_rep_RT821.Columns[0].ReadOnly = true;
				this.DataGridView_end_rep_RT821.Columns[2].ReadOnly = true;
				this.DataGridView_end_rep_RT821.Columns[4].ReadOnly = true;
				this.DataGridView_end_rep_RT821.Columns[6].ReadOnly = true;
				this.DataGridView_end_rep_RT821.Columns[8].ReadOnly = true;
				num = 0;
				do
				{
					this.DataGridView_end_rep_RT821[0, num].Value = num + 1;
					this.DataGridView_end_rep_RT821[2, num].Value = num + 11;
					this.DataGridView_end_rep_RT821[4, num].Value = num + 21;
					this.DataGridView_end_rep_RT821[6, num].Value = num + 31;
					this.DataGridView_end_rep_RT821[8, num].Value = num + 41;
					num++;
				}
				while (num <= 9);
			}
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x003B92FC File Offset: 0x003B76FC
		private void InicializaEstrutura_DataGridView_repetidora_RT_821()
		{
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[0].TagColuna = "Posição";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[1].TagColuna = "Endereço";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[2].TagColuna = "Posição";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[3].TagColuna = "Endereço";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[4].TagColuna = "Posição";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[5].TagColuna = "Endereço";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[6].TagColuna = "Posição";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[7].TagColuna = "Endereço";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[8].TagColuna = "Posição";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[9].TagColuna = "Endereço";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[0].NomeColuna = "pos_1";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[1].NomeColuna = "end_1";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[2].NomeColuna = "pos_2";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[3].NomeColuna = "end_2";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[4].NomeColuna = "pos_3";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[5].NomeColuna = "end_3";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[6].NomeColuna = "pos_4";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[7].NomeColuna = "end_4";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[8].NomeColuna = "pos_5";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[9].NomeColuna = "end_5";
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[0].LarguraColuna = 50;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[1].LarguraColuna = 65;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[2].LarguraColuna = 50;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[3].LarguraColuna = 65;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[4].LarguraColuna = 50;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[5].LarguraColuna = 65;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[6].LarguraColuna = 50;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[7].LarguraColuna = 65;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[8].LarguraColuna = 50;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[9].LarguraColuna = 65;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[0].AlingColuna = 32;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[1].AlingColuna = 64;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[2].AlingColuna = 32;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[3].AlingColuna = 64;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[4].AlingColuna = 32;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[5].AlingColuna = 64;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[6].AlingColuna = 32;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[7].AlingColuna = 64;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[8].AlingColuna = 32;
			RT_geral.RT_821_DataGrigViewRepetidoraColunas[9].AlingColuna = 64;
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x003B961C File Offset: 0x003B7A1C
		private void GeraDataGridView_Setpoints_RT_821()
		{
			this.DataGridView_setpoints_RT821.Columns.Clear();
			this.DataGridView_setpoints_RT821.CellBorderStyle = 1;
			this.DataGridView_setpoints_RT821.DefaultCellStyle.Alignment = 64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_821_DataGrigViewSetpointsColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_821_DataGrigViewSetpointsColunas);
						this.DataGridView_setpoints_RT821.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_821_DataGrigViewSetpointsColunas);
						this.DataGridView_setpoints_RT821.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 2);
				this.DataGridView_setpoints_RT821.RowCount = 3;
				this.DataGridView_setpoints_RT821.RowHeadersWidth = 80;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_setpoints_RT821.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "Ctrl " + Conversions.ToString(num2);
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

		// Token: 0x06001A04 RID: 6660 RVA: 0x003B9758 File Offset: 0x003B7B58
		private void InicializaEstrutura_DataGridView_Setpoints_RT_821()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_821_DataGrigViewSetpointsColunas[num].LinhasMenu = new string[11];
					RT_geral.RT_821_DataGrigViewSetpointsColunas[num].LinhasValor = new int[11];
					num++;
				}
				while (num <= 2);
				RT_geral.RT_821_DataGrigViewSetpointsColunas[0].TagColuna = "Controle";
				RT_geral.RT_821_DataGrigViewSetpointsColunas[2].TagColuna = "Alto";
				RT_geral.RT_821_DataGrigViewSetpointsColunas[1].TagColuna = "Baixo";
				RT_geral.RT_821_DataGrigViewSetpointsColunas[0].NomeColuna = "Set_Controle";
				RT_geral.RT_821_DataGrigViewSetpointsColunas[2].NomeColuna = "Set_NAlto";
				RT_geral.RT_821_DataGrigViewSetpointsColunas[1].NomeColuna = "Set_NBaixo";
				RT_geral.RT_821_DataGrigViewSetpointsColunas[0].LarguraColuna = 160;
				RT_geral.RT_821_DataGrigViewSetpointsColunas[2].LarguraColuna = 60;
				RT_geral.RT_821_DataGrigViewSetpointsColunas[1].LarguraColuna = 60;
				RT_geral.RT_821_DataGrigViewSetpointsColunas[0].AlingColuna = 32;
				RT_geral.RT_821_DataGrigViewSetpointsColunas[2].AlingColuna = 64;
				RT_geral.RT_821_DataGrigViewSetpointsColunas[1].AlingColuna = 64;
				RT_geral.RT_821_DataGrigViewSetpointsColunas[0].LinhasMenu[0] = "Controle Desabilitado";
				RT_geral.RT_821_DataGrigViewSetpointsColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_821_DataGrigViewSetpointsColunas[0].NumeroLinhaMenu = 9;
				num = 1;
				do
				{
					RT_geral.RT_821_DataGrigViewSetpointsColunas[0].LinhasMenu[num] = "EA - " + Strings.Format(num, "0#");
					RT_geral.RT_821_DataGrigViewSetpointsColunas[0].LinhasValor[num] = 21856 + num;
					RT_geral.RT_821_DataGrigViewSetpointsColunas[0].LinhasMenu[num + 4] = "Referência " + Strings.Format(num, "#");
					RT_geral.RT_821_DataGrigViewSetpointsColunas[0].LinhasValor[num + 4] = 21872 + num;
					num++;
				}
				while (num <= 4);
				RT_geral.RT_821_DataGrigViewSetpointsColunas[1].NumeroLinhaMenu = 0;
				RT_geral.RT_821_DataGrigViewSetpointsColunas[2].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x003B9988 File Offset: 0x003B7D88
		private void GeraDataGridView_ED_RT_821()
		{
			this.DataGridView_RT821_ED.Columns.Clear();
			this.DataGridView_RT821_ED.CellBorderStyle = 1;
			this.DataGridView_RT821_ED.DefaultCellStyle.Alignment = 64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_821_DataGrigViewEDColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_821_DataGrigViewEDColunas);
						this.DataGridView_RT821_ED.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_821_DataGrigViewEDColunas);
						this.DataGridView_RT821_ED.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 0);
				this.DataGridView_RT821_ED.RowCount = 8;
				this.DataGridView_RT821_ED.RowHeadersWidth = 80;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_RT821_ED.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "ED " + Conversions.ToString(num2);
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

		// Token: 0x06001A06 RID: 6662 RVA: 0x003B9AC4 File Offset: 0x003B7EC4
		private void InicializaEstrutura_DataGridView_ED_RT_821()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_821_DataGrigViewEDColunas[num].LinhasMenu = new string[9];
					RT_geral.RT_821_DataGrigViewEDColunas[num].LinhasValor = new int[9];
					num++;
				}
				while (num <= 1);
				RT_geral.RT_821_DataGrigViewEDColunas[0].TagColuna = "Entrada";
				RT_geral.RT_821_DataGrigViewEDColunas[0].NomeColuna = "Entrada";
				RT_geral.RT_821_DataGrigViewEDColunas[0].LarguraColuna = 200;
				RT_geral.RT_821_DataGrigViewEDColunas[0].AlingColuna = 32;
				RT_geral.RT_821_DataGrigViewEDColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_821_DataGrigViewEDColunas[0].LinhasValor[1] = 21969;
				RT_geral.RT_821_DataGrigViewEDColunas[0].LinhasValor[2] = 21970;
				RT_geral.RT_821_DataGrigViewEDColunas[0].LinhasValor[3] = 21971;
				RT_geral.RT_821_DataGrigViewEDColunas[0].LinhasValor[4] = 21972;
				RT_geral.RT_821_DataGrigViewEDColunas[0].LinhasValor[5] = 21973;
				RT_geral.RT_821_DataGrigViewEDColunas[0].LinhasValor[6] = 21974;
				RT_geral.RT_821_DataGrigViewEDColunas[0].LinhasMenu[0] = "Entrada desabilitada";
				RT_geral.RT_821_DataGrigViewEDColunas[0].LinhasMenu[1] = "Arrombamento";
				RT_geral.RT_821_DataGrigViewEDColunas[0].LinhasMenu[2] = "Falta de fase";
				RT_geral.RT_821_DataGrigViewEDColunas[0].LinhasMenu[3] = "Alagamento";
				RT_geral.RT_821_DataGrigViewEDColunas[0].LinhasMenu[4] = "Horário de ponta";
				RT_geral.RT_821_DataGrigViewEDColunas[0].LinhasMenu[5] = "Transbordo";
				RT_geral.RT_821_DataGrigViewEDColunas[0].LinhasMenu[6] = "Operação em Bateria";
				RT_geral.RT_821_DataGrigViewEDColunas[0].NumeroLinhaMenu = 7;
			}
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x003B9CB0 File Offset: 0x003B80B0
		private void GeraDataGridView_Visor_RT_821()
		{
			this.DataGridView_visor_RT_821.Columns.Clear();
			this.DataGridView_visor_RT_821.CellBorderStyle = 1;
			this.DataGridView_visor_RT_821.DefaultCellStyle.Alignment = 64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_821_DataGrigViewVisorColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_821_DataGrigViewVisorColunas);
						this.DataGridView_visor_RT_821.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else if (RT_geral.RT_821_DataGrigViewVisorColunas[num].NumeroLinhaMenu == 0)
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_821_DataGrigViewVisorColunas);
						this.DataGridView_visor_RT_821.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					else
					{
						DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = Linha_RT.CreateCheckColumn(Conversions.ToString(num), ref RT_geral.RT_821_DataGrigViewVisorColunas);
						this.DataGridView_visor_RT_821.Columns.Insert(num, dataGridViewCheckBoxColumn);
					}
					num++;
				}
				while (num <= 3);
				this.DataGridView_visor_RT_821.RowCount = 8;
				this.DataGridView_visor_RT_821.RowHeadersWidth = 100;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_visor_RT_821.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							if (num2 <= 4)
							{
								dataGridViewRow.HeaderCell.Value = "Msg - EA " + Conversions.ToString(num2);
							}
							else
							{
								dataGridViewRow.HeaderCell.Value = "Msg - Ref " + Conversions.ToString(num2 - 4);
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

		// Token: 0x06001A08 RID: 6664 RVA: 0x003B9E4C File Offset: 0x003B824C
		private void InicializaEstrutura_DataGridView_Visor_RT_821()
		{
			RT_geral.RT_821_DataGrigViewVisorColunas[3].LinhasMenu = new string[4];
			RT_geral.RT_821_DataGrigViewVisorColunas[3].LinhasValor = new int[4];
			RT_geral.RT_821_DataGrigViewVisorColunas[0].TagColuna = "Habilita";
			RT_geral.RT_821_DataGrigViewVisorColunas[1].TagColuna = "Nome";
			RT_geral.RT_821_DataGrigViewVisorColunas[2].TagColuna = "Escala";
			RT_geral.RT_821_DataGrigViewVisorColunas[3].TagColuna = "Ponto Decimal";
			RT_geral.RT_821_DataGrigViewVisorColunas[0].NomeColuna = "Hab_msg";
			RT_geral.RT_821_DataGrigViewVisorColunas[1].NomeColuna = "Nome";
			RT_geral.RT_821_DataGrigViewVisorColunas[2].NomeColuna = "Escala";
			RT_geral.RT_821_DataGrigViewVisorColunas[3].NomeColuna = "Pto_Decimal";
			RT_geral.RT_821_DataGrigViewVisorColunas[0].LarguraColuna = 50;
			RT_geral.RT_821_DataGrigViewVisorColunas[1].LarguraColuna = 60;
			RT_geral.RT_821_DataGrigViewVisorColunas[2].LarguraColuna = 60;
			RT_geral.RT_821_DataGrigViewVisorColunas[3].LarguraColuna = 120;
			RT_geral.RT_821_DataGrigViewVisorColunas[0].AlingColuna = 32;
			RT_geral.RT_821_DataGrigViewVisorColunas[1].AlingColuna = 64;
			RT_geral.RT_821_DataGrigViewVisorColunas[2].AlingColuna = 64;
			RT_geral.RT_821_DataGrigViewVisorColunas[3].AlingColuna = 64;
			RT_geral.RT_821_DataGrigViewVisorColunas[0].NumeroLinhaMenu = -1;
			RT_geral.RT_821_DataGrigViewVisorColunas[1].NumeroLinhaMenu = 0;
			RT_geral.RT_821_DataGrigViewVisorColunas[2].NumeroLinhaMenu = 0;
			RT_geral.RT_821_DataGrigViewVisorColunas[3].LinhasMenu[0] = "Sem ponto decimal";
			RT_geral.RT_821_DataGrigViewVisorColunas[3].LinhasMenu[1] = "00.0";
			RT_geral.RT_821_DataGrigViewVisorColunas[3].LinhasMenu[2] = "0.00";
			RT_geral.RT_821_DataGrigViewVisorColunas[3].LinhasValor[0] = 0;
			RT_geral.RT_821_DataGrigViewVisorColunas[3].LinhasValor[1] = 1;
			RT_geral.RT_821_DataGrigViewVisorColunas[3].LinhasValor[2] = 2;
			RT_geral.RT_821_DataGrigViewVisorColunas[3].NumeroLinhaMenu = 3;
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x003BA080 File Offset: 0x003B8480
		public void Atualiza_Tela_RT_821()
		{
			checked
			{
				int num;
				int num3;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					this.Libera_acoes_RT821();
					this.ComboBox_modo_simulado_RT_821.SelectedIndex = RT_geral.RT_821_BD.Modelo.Indice;
					this.TextBox_versao_RT821.Text = Conversions.ToString(RT_geral.RT_821_BD.Versao.Valor);
					this.TextBox_build_RT821.Text = Conversions.ToString(RT_geral.RT_821_BD.Build.Valor);
					this.TextBox_release_RT821.Text = Conversions.ToString(RT_geral.RT_821_BD.Release.Valor);
					this.TextBox_equipamento_RT821.Text = Conversions.ToString(RT_geral.RT_821_BD.Equip.Valor);
					this.NumericUpDown_end_est_RT821.Value = new decimal(RT_geral.RT_821_BD.End_estacao.Valor);
					this.NumericUpDown_end_mestre_RT821.Value = new decimal(RT_geral.RT_821_BD.End_mestre.Valor);
					this.NumericUpDown_temp_ptt_RT821.Value = new decimal(RT_geral.RT_821_BD.Tempo_ptt.Valor);
					RT_geral.RT_821_BD.modo_operacao.AtualizaIndicePeloValor();
					this.ComboBox_Modo_Operacao.SelectedIndex = RT_geral.RT_821_BD.modo_operacao.Indice;
					this.NumericUpDown_IntervaloTX.Value = new decimal(RT_geral.RT_821_BD.intervalo_tx.Valor);
					this.cb_baudrate_com1.SelectedIndex = RT_geral.RT_821_BD.baudrate_com1.Indice;
					this.cb_baudrate_com2.SelectedIndex = RT_geral.RT_821_BD.baudrate_com2.Indice;
					int num2 = 0;
					do
					{
						string value = RT_geral.RT_821_DataGrigViewProcessosColunas[0].LinhasMenu[RT_geral.RT_821_BD.ctrl_acionamento[num2].Indice];
						this.DataGridView_processo_RT821.Rows[num2].Cells[0].Value = value;
						value = RT_geral.RT_821_DataGrigViewProcessosColunas[1].LinhasMenu[RT_geral.RT_821_BD.ctrl_ret_acionamento[num2].Indice];
						this.DataGridView_processo_RT821.Rows[num2].Cells[1].Value = value;
						value = RT_geral.RT_821_DataGrigViewProcessosColunas[2].LinhasMenu[RT_geral.RT_821_BD.ctrl_ED_selecao[num2].Indice];
						this.DataGridView_processo_RT821.Rows[num2].Cells[2].Value = value;
						value = RT_geral.RT_821_DataGrigViewProcessosColunas[3].LinhasMenu[RT_geral.RT_821_BD.ctrl_reverso[num2].Indice];
						this.DataGridView_processo_RT821.Rows[num2].Cells[3].Value = value;
						value = RT_geral.RT_821_DataGrigViewProcessosColunas[4].LinhasMenu[RT_geral.RT_821_BD.ctrl_modo[num2].Indice];
						this.DataGridView_processo_RT821.Rows[num2].Cells[4].Value = value;
						this.DataGridView_processo_RT821.Rows[num2].Cells[5].Value = RT_geral.RT_821_BD.ctrl_tempo_max_partida[num2].Valor;
						this.DataGridView_processo_RT821.Rows[num2].Cells[6].Value = RT_geral.RT_821_BD.ctrl_tempo_max_parada[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					num2 = 0;
					do
					{
						string value = RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[0].LinhasMenu[RT_geral.RT_821_BD.motores_simultaneos[num2].Indice];
						this.DataGridView_MotoresSimultaneos_RT_821.Rows[num2].Cells[0].Value = value;
						this.DataGridView_MotoresSimultaneos_RT_821.Rows[num2].Cells[1].Value = RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[num2].Valor;
						num2++;
					}
					while (num2 <= 0);
					num2 = 0;
					do
					{
						this.DataGridView_parametros_EA_RT821.Rows[num2].Cells[0].Value = RT_geral.RT_821_BD.EA_Range[num2].Valor;
						this.DataGridView_parametros_EA_RT821.Rows[num2].Cells[1].Value = RT_geral.RT_821_BD.EA_Inicio[num2].Valor;
						this.DataGridView_parametros_EA_RT821.Rows[num2].Cells[2].Value = RT_geral.RT_821_BD.EA_Fim[num2].Valor;
						num2++;
					}
					while (num2 <= 3);
					this.NumericUpDown_intervalo_filtro_RT821.Value = new decimal(RT_geral.RT_821_BD.AD_Intervalo.Valor);
					this.NumericUpDown_tamanho_filtro_RT821.Value = new decimal(RT_geral.RT_821_BD.AD_Tamanho_filtro.Valor);
					num2 = 0;
					do
					{
						string value = RT_geral.RT_821_DataGrigViewEDColunas[0].LinhasMenu[RT_geral.RT_821_BD.config_ED[num2].Indice];
						this.DataGridView_RT821_ED.Rows[num2].Cells[0].Value = value;
						num2++;
					}
					while (num2 <= 7);
					num2 = 0;
					do
					{
						this.DataGridView_setpoints_RT821.Rows[num2].Cells[2].Value = RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[num2].Valor;
						this.DataGridView_setpoints_RT821.Rows[num2].Cells[1].Value = RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[num2].Valor;
						string value = RT_geral.RT_821_DataGrigViewSetpointsColunas[0].LinhasMenu[RT_geral.RT_821_BD.Setpoints_ctrl_variavel[num2].Indice];
						this.DataGridView_setpoints_RT821.Rows[num2].Cells[0].Value = value;
						num2++;
					}
					while (num2 <= 2);
					RT_geral.RT_821_BD.modo_repetidora.AtualizaIndicePeloValor();
					this.cb_modorepetidora.SelectedIndex = RT_geral.RT_821_BD.modo_repetidora.Indice;
					this.NumericUpDown_end_rep_RT821.Value = new decimal(RT_geral.RT_821_BD.End_repetidora.Valor);
					this.NumericUpDown_num_est_rep_RT821.Value = new decimal(RT_geral.RT_821_BD.Num_repetidoras.Valor);
					num2 = 0;
					do
					{
						this.DataGridView_end_rep_RT821.Rows[num2].Cells[1].Value = RT_geral.RT_821_BD.Repetidoras[num2].Valor;
						this.DataGridView_end_rep_RT821.Rows[num2].Cells[3].Value = RT_geral.RT_821_BD.Repetidoras[num2 + 10].Valor;
						this.DataGridView_end_rep_RT821.Rows[num2].Cells[5].Value = RT_geral.RT_821_BD.Repetidoras[num2 + 20].Valor;
						this.DataGridView_end_rep_RT821.Rows[num2].Cells[7].Value = RT_geral.RT_821_BD.Repetidoras[num2 + 30].Valor;
						this.DataGridView_end_rep_RT821.Rows[num2].Cells[9].Value = RT_geral.RT_821_BD.Repetidoras[num2 + 40].Valor;
						num2++;
					}
					while (num2 <= 9);
					num2 = 0;
					do
					{
						if (RT_geral.RT_821_BD.dsp_hab[num2].Valor == -1)
						{
							this.DataGridView_visor_RT_821.Rows[num2].Cells[0].Value = true;
							this.DataGridView_visor_RT_821.Rows[num2].Cells[2].Value = RT_geral.RT_821_BD.dsp_escalas[num2].Valor;
							string value = RT_geral.RT_821_DataGrigViewVisorColunas[3].LinhasMenu[RT_geral.RT_821_BD.dsp_pto_decimal[num2].Indice];
							this.DataGridView_visor_RT_821.Rows[num2].Cells[3].Value = value;
							this.DataGridView_visor_RT_821.Rows[num2].Cells[1].Value = RT_geral.RT_821_BD.dsp_nome[num2].Valor;
						}
						else
						{
							this.DataGridView_visor_RT_821.Rows[num2].Cells[0].Value = false;
							this.DataGridView_visor_RT_821.Rows[num2].Cells[2].Value = RT_geral.RT_821_BD.dsp_escalas[num2].Valor;
							string value = RT_geral.RT_821_DataGrigViewVisorColunas[3].LinhasMenu[RT_geral.RT_821_BD.dsp_pto_decimal[num2].Indice];
							this.DataGridView_visor_RT_821.Rows[num2].Cells[3].Value = value;
							this.DataGridView_visor_RT_821.Rows[num2].Cells[1].Value = "   ";
						}
						num2++;
					}
					while (num2 <= 7);
					IL_9B5:
					goto IL_9FC;
					IL_9B7:
					num3 = -1;
										IL_9CD:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num3 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_9B7;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_9FC:
				if (num3 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x003BAAB0 File Offset: 0x003B8EB0
		public void Habilita_Funcoes_de_Tela_RT_821(int tipo)
		{
			this.GroupBox_informacoes_RT821.Enabled = false;
			this.GroupBox_controle_RT821.Enabled = false;
			this.DataGridView_processo_RT821.Visible = false;
			this.GroupBox_parametros_EA_RT821.Enabled = false;
			this.GroupBox_EA_RT821.Enabled = false;
			this.DataGridView_parametros_EA_RT821.Visible = false;
			this.GroupBox_ED_RT821.Enabled = false;
			this.GroupBox_setpoints_RT821.Enabled = false;
			this.DataGridView_setpoints_RT821.Visible = false;
			this.GroupBox_parametros_repetidora_RT821.Enabled = false;
			this.GroupBox_end_rep_RT821.Enabled = false;
			this.DataGridView_end_rep_RT821.Visible = false;
			switch (tipo)
			{
			case 0:
				this.GroupBox_informacoes_RT821.Enabled = true;
				this.GroupBox_controle_RT821.Enabled = true;
				this.DataGridView_processo_RT821.Visible = true;
				this.GroupBox_parametros_EA_RT821.Enabled = true;
				this.GroupBox_EA_RT821.Enabled = true;
				this.DataGridView_parametros_EA_RT821.Visible = true;
				this.GroupBox_ED_RT821.Enabled = true;
				this.GroupBox_setpoints_RT821.Enabled = true;
				this.DataGridView_setpoints_RT821.Visible = true;
				this.GroupBox_parametros_repetidora_RT821.Enabled = true;
				this.GroupBox_end_rep_RT821.Enabled = true;
				this.DataGridView_end_rep_RT821.Visible = true;
				break;
			}
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x003BABF8 File Offset: 0x003B8FF8
		public void AtualizaMsgTela_RT821(string texto, int cor)
		{
			this.ToolStripTextBox_RT821_Msg.Text = texto;
			if (cor == 0)
			{
				this.ToolStripTextBox_RT821_Msg.ForeColor = Color.Blue;
			}
			else if (cor == 1)
			{
				this.ToolStripProgressBar_RT821.Value = 0;
				this.ToolStripTextBox_RT821_Msg.ForeColor = Color.Red;
			}
			else
			{
				this.ToolStripTextBox_RT821_Msg.ForeColor = Color.Black;
			}
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x003BAC5C File Offset: 0x003B905C
		public void InicializaBarraProgressoTela_RT821(int num_passos)
		{
			this.ToolStripProgressBar_RT821.Minimum = 0;
			this.ToolStripProgressBar_RT821.Maximum = 100;
			this.ToolStripProgressBar_RT821.Step = checked((int)Math.Round(unchecked(100.0 / (double)num_passos + 1.0)));
			this.ToolStripProgressBar_RT821.Value = 0;
			this.ToolStripProgressBar_RT821.BackColor = Color.LightGray;
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x003BACC8 File Offset: 0x003B90C8
		private void NumericUpDown_end_rep_RT821_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_BD.End_repetidora.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_BD.End_repetidora, true);
			sender = numericUpDown;
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x003BAD1C File Offset: 0x003B911C
		private void NumericUpDown_num_est_rep_RT821_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_BD.Num_repetidoras.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_BD.Num_repetidoras, true);
			sender = numericUpDown;
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x003BAD70 File Offset: 0x003B9170
		private void ComboBox_modo_simulado_RT_821_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_BD.Modelo.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_821_BD.Modelo.Valor = RT_geral.RT_821_BD.Modelo.valores[RT_geral.RT_821_BD.Modelo.Indice];
			this.Habilita_Funcoes_de_Tela_RT_821(Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null)));
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x003BADF4 File Offset: 0x003B91F4
		private void NumericUpDown_end_mestre_RT821_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_BD.End_mestre.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_BD.End_mestre, true);
			sender = numericUpDown;
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x003BAE48 File Offset: 0x003B9248
		private void NumericUpDown_end_est_RT821_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_BD.End_estacao.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_BD.End_estacao, true);
			sender = numericUpDown;
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x003BAE9C File Offset: 0x003B929C
		private void NumericUpDown_temp_ptt_RT821_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_BD.Tempo_ptt.Valor = Conversions.ToInteger(Operators.MultiplyObject(Operators.IntDivideObject(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null), 10), 10));
			NewLateBinding.LateSet(sender, null, "value", new object[]
			{
				RT_geral.RT_821_BD.Tempo_ptt.Valor
			}, null, null);
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_BD.Tempo_ptt, true);
			sender = numericUpDown;
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x003BAF34 File Offset: 0x003B9334
		private void NumericUpDown_intervalo_filtro_RT821_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_BD.AD_Intervalo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_BD.AD_Intervalo, true);
			sender = numericUpDown;
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x003BAF88 File Offset: 0x003B9388
		private void NumericUpDown_tamanho_filtro_RT821_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_BD.AD_Tamanho_filtro.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_BD.AD_Tamanho_filtro, true);
			sender = numericUpDown;
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x003BAFDC File Offset: 0x003B93DC
		private void DataGridView_processo_RT821_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_processo_RT821.IsCurrentCellDirty)
			{
				this.DataGridView_processo_RT821.CommitEdit(512);
			}
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x003BAFFC File Offset: 0x003B93FC
		private void DataGridView_processo_RT821_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_processo_RT821.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_TpMaxPart", false) == 0)
				{
					RT_geral.RT_821_BD.ctrl_tempo_max_partida[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_BD.ctrl_tempo_max_partida[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_TpMaxParada", false) == 0)
				{
					RT_geral.RT_821_BD.ctrl_tempo_max_parada[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_BD.ctrl_tempo_max_parada[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x003BB0F8 File Offset: 0x003B94F8
		private void DataGridView_processo_RT821_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_processo_RT821.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_SDAciona", false) != 0)
			{
				if (Operators.CompareString(dataPropertyName, "Col_EDRetAci", false) != 0)
				{
					if (Operators.CompareString(dataPropertyName, "Col_SDDesaci", false) != 0)
					{
						if (Operators.CompareString(dataPropertyName, "Col_EDRetDes", false) != 0)
						{
							if (Operators.CompareString(dataPropertyName, "Col_EDRemoto", false) != 0)
							{
								if (Operators.CompareString(dataPropertyName, "Col_EDBloqueio", false) != 0)
								{
									if (Operators.CompareString(dataPropertyName, "Col_EDLiberar", false) != 0)
									{
										if (Operators.CompareString(dataPropertyName, "Col_Reverso", false) != 0)
										{
											if (Operators.CompareString(dataPropertyName, "Col_ModoCtrl", false) != 0)
											{
												if (Operators.CompareString(dataPropertyName, "Col_GrupoCtrl", false) != 0)
												{
													if (Operators.CompareString(dataPropertyName, "Col_TpMaxPart", false) == 0)
													{
														this.DataGridView_processo_RT821.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_processo_RT821.Rows[e.RowIndex].Cells[5].Value));
														RT_geral.RT_821_BD.ctrl_tempo_max_partida[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_processo_RT821.Rows[e.RowIndex].Cells[5].Value);
														return;
													}
													if (Operators.CompareString(dataPropertyName, "Col_TpMaxParada", false) == 0)
													{
														this.DataGridView_processo_RT821.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_processo_RT821.Rows[e.RowIndex].Cells[6].Value));
														RT_geral.RT_821_BD.ctrl_tempo_max_parada[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_processo_RT821.Rows[e.RowIndex].Cells[6].Value);
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
			string text = Conversions.ToString(this.DataGridView_processo_RT821.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_821_DataGrigViewProcessosColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
				int i = num;
				while (i <= num2)
				{
					if (Operators.CompareString(RT_geral.RT_821_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
					{
						string dataPropertyName2 = this.DataGridView_processo_RT821.Columns[e.ColumnIndex].DataPropertyName;
						if (Operators.CompareString(dataPropertyName2, "Col_SDAciona", false) == 0)
						{
							if (RT_geral.VerificaEDJaUtilizada_MesmaColuna(3, i, e.RowIndex, ref RT_geral.RT_821_BD.ctrl_acionamento, ref RT_geral.RT_821_DataGrigViewProcessosColunas[e.ColumnIndex], ""))
							{
								this.DataGridView_processo_RT821.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_821_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_821_BD.ctrl_acionamento[e.RowIndex].Indice_padrao];
								break;
							}
							RT_geral.RT_821_BD.ctrl_acionamento[e.RowIndex].Valor = RT_geral.RT_821_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_821_BD.ctrl_acionamento[e.RowIndex].Indice = i;
							break;
						}
						else if (Operators.CompareString(dataPropertyName2, "Col_EDRetAci", false) == 0)
						{
							if (RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_821_BD.ctrl_ret_acionamento[e.RowIndex], ref RT_geral.RT_821_DataGrigViewProcessosColunas[e.ColumnIndex], 3, ref RT_geral.RT_821_BD.ctrl_ED_selecao, "", "", "") | RT_geral.VerificaEDJaUtilizada_FuncoesEspeciais(i, RT_geral.RT_821_BD.config_ED, "") | RT_geral.VerificaEDJaUtilizada_MesmaColuna(3, i, e.RowIndex, ref RT_geral.RT_821_BD.ctrl_ret_acionamento, ref RT_geral.RT_821_DataGrigViewProcessosColunas[e.ColumnIndex], ""))
							{
								this.DataGridView_processo_RT821.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_821_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_821_BD.ctrl_ret_acionamento[e.RowIndex].Indice_padrao];
								break;
							}
							RT_geral.RT_821_BD.ctrl_ret_acionamento[e.RowIndex].Valor = RT_geral.RT_821_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_821_BD.ctrl_ret_acionamento[e.RowIndex].Indice = i;
							break;
						}
						else if (Operators.CompareString(dataPropertyName2, "Col_EDRemoto", false) == 0)
						{
							if (RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_821_BD.ctrl_ED_selecao[e.RowIndex], ref RT_geral.RT_821_DataGrigViewProcessosColunas[e.ColumnIndex], 3, ref RT_geral.RT_821_BD.ctrl_ret_acionamento, "", "", "") | RT_geral.VerificaEDJaUtilizada_FuncoesEspeciais(i, RT_geral.RT_821_BD.config_ED, "") | RT_geral.VerificaEDJaUtilizada_MesmaColuna(3, i, e.RowIndex, ref RT_geral.RT_821_BD.ctrl_ED_selecao, ref RT_geral.RT_821_DataGrigViewProcessosColunas[e.ColumnIndex], ""))
							{
								this.DataGridView_processo_RT821.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_821_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_821_BD.ctrl_ED_selecao[e.RowIndex].Indice_padrao];
								break;
							}
							RT_geral.RT_821_BD.ctrl_ED_selecao[e.RowIndex].Valor = RT_geral.RT_821_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_821_BD.ctrl_ED_selecao[e.RowIndex].Indice = i;
							break;
						}
						else
						{
							if (Operators.CompareString(dataPropertyName2, "Col_Reverso", false) == 0)
							{
								RT_geral.RT_821_BD.ctrl_reverso[e.RowIndex].Valor = RT_geral.RT_821_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_821_BD.ctrl_reverso[e.RowIndex].Indice = i;
								break;
							}
							if (Operators.CompareString(dataPropertyName2, "Col_ModoCtrl", false) == 0)
							{
								RT_geral.RT_821_BD.ctrl_modo[e.RowIndex].Valor = RT_geral.RT_821_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_821_BD.ctrl_modo[e.RowIndex].Indice = i;
								break;
							}
							break;
						}
					}
					else
					{
						i++;
					}
				}
			}
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x003BB838 File Offset: 0x003B9C38
		private void DataGridView_MotoresSimultaneos_RT_821_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_MotoresSimultaneos_RT_821.IsCurrentCellDirty)
			{
				this.DataGridView_MotoresSimultaneos_RT_821.CommitEdit(512);
			}
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x003BB858 File Offset: 0x003B9C58
		private void DataGridView_MotoresSimultaneos_RT_821_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_MotoresSimultaneos_RT_821.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_TpAcionamentos", false) == 0)
			{
				RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[e.RowIndex].Valor = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue))));
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[e.RowIndex], e, true);
				sender = dataGridView;
			}
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x003BB8EC File Offset: 0x003B9CEC
		private void DataGridView_MotoresSimultaneos_RT_821_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_MotoresSimultaneos_RT_821.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_MSimultaneos", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_MotoresSimultaneos_RT_821.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					int i = num;
					while (i <= num2)
					{
						if (Operators.CompareString(RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							string dataPropertyName2 = this.DataGridView_MotoresSimultaneos_RT_821.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName2, "Col_MSimultaneos", false) == 0)
							{
								RT_geral.RT_821_BD.motores_simultaneos[e.RowIndex].Valor = RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_821_BD.motores_simultaneos[e.RowIndex].Indice = i;
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
				else if (Operators.CompareString(dataPropertyName, "Col_TpAcionamentos", false) == 0)
				{
					this.DataGridView_MotoresSimultaneos_RT_821.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_MotoresSimultaneos_RT_821.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_MotoresSimultaneos_RT_821.Rows[e.RowIndex].Cells[1].Value);
				}
			}
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x003BBAE8 File Offset: 0x003B9EE8
		private void DataGridView_parametros_EA_RT821_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_parametros_EA_RT821.IsCurrentCellDirty)
			{
				this.DataGridView_parametros_EA_RT821.CommitEdit(512);
			}
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x003BBB08 File Offset: 0x003B9F08
		private void DataGridView_parametros_EA_RT821_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_parametros_EA_RT821.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_range", false) == 0)
				{
					RT_geral.RT_821_BD.EA_Range[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_BD.EA_Range[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_ini", false) == 0)
				{
					RT_geral.RT_821_BD.EA_Inicio[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_BD.EA_Inicio[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_fim", false) == 0)
				{
					RT_geral.RT_821_BD.EA_Fim[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_BD.EA_Fim[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x003BBC70 File Offset: 0x003BA070
		private void DataGridView_parametros_EA_RT821_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_parametros_EA_RT821.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_range", false) == 0)
			{
				this.DataGridView_parametros_EA_RT821.Rows[e.RowIndex].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_parametros_EA_RT821.Rows[e.RowIndex].Cells[0].Value));
				RT_geral.RT_821_BD.EA_Range[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_parametros_EA_RT821.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(dataPropertyName, "Col_ini", false) == 0)
			{
				this.DataGridView_parametros_EA_RT821.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_parametros_EA_RT821.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_821_BD.EA_Inicio[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_parametros_EA_RT821.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(dataPropertyName, "Col_fim", false) == 0)
			{
				this.DataGridView_parametros_EA_RT821.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_parametros_EA_RT821.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_821_BD.EA_Fim[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_parametros_EA_RT821.Rows[e.RowIndex].Cells[2].Value);
			}
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x003BBEC4 File Offset: 0x003BA2C4
		private void DataGridView_RT821_ED_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_RT821_ED.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_Entrada", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_RT821_ED.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_821_DataGrigViewEDColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					int i = num;
					while (i <= num2)
					{
						if (Operators.CompareString(RT_geral.RT_821_DataGrigViewEDColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							string dataPropertyName2 = this.DataGridView_RT821_ED.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName2, "Col_Entrada", false) == 0)
							{
								if (!RT_geral.VerificaFuncaoJaUtilizada(i, e.RowIndex, RT_geral.RT_821_BD.config_ED, 21856) & !RT_geral.VerificaEDdaFuncaoJaUtilizada(e.RowIndex + 1, i, 3, ref RT_geral.RT_821_BD.ctrl_ED_selecao) & !RT_geral.VerificaEDdaFuncaoJaUtilizada(e.RowIndex + 1, i, 3, ref RT_geral.RT_821_BD.ctrl_ret_acionamento))
								{
									RT_geral.RT_821_BD.config_ED[e.RowIndex].Valor = RT_geral.RT_821_DataGrigViewEDColunas[e.ColumnIndex].LinhasValor[i];
									RT_geral.RT_821_BD.config_ED[e.RowIndex].Indice = i;
								}
								else
								{
									this.DataGridView_RT821_ED.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_821_DataGrigViewEDColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_821_BD.config_ED[e.RowIndex].Indice_padrao];
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

		// Token: 0x06001A1F RID: 6687 RVA: 0x003BC0C0 File Offset: 0x003BA4C0
		private void DataGridView_RT821_ED_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_RT821_ED.IsCurrentCellDirty)
			{
				this.DataGridView_RT821_ED.CommitEdit(512);
			}
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x003BC0E0 File Offset: 0x003BA4E0
		private void DataGridView_setpoints_RT821_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_setpoints_RT821.IsCurrentCellDirty)
			{
				this.DataGridView_setpoints_RT821.CommitEdit(512);
			}
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x003BC100 File Offset: 0x003BA500
		private void DataGridView_setpoints_RT821_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_setpoints_RT821.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_Set_NAlto", false) == 0)
				{
					RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NBaixo", false) == 0)
				{
					RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x003BC1FC File Offset: 0x003BA5FC
		private void DataGridView_setpoints_RT821_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_setpoints_RT821.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_Set_Controle", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_setpoints_RT821.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_821_DataGrigViewSetpointsColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					int i = num;
					while (i <= num2)
					{
						if (Operators.CompareString(RT_geral.RT_821_DataGrigViewSetpointsColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							string dataPropertyName2 = this.DataGridView_setpoints_RT821.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName2, "Col_Set_Controle", false) == 0)
							{
								RT_geral.RT_821_BD.Setpoints_ctrl_variavel[e.RowIndex].Valor = RT_geral.RT_821_DataGrigViewSetpointsColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_821_BD.Setpoints_ctrl_variavel[e.RowIndex].Indice = i;
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
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NAlto", false) == 0)
				{
					this.DataGridView_setpoints_RT821.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_setpoints_RT821.Rows[e.RowIndex].Cells[2].Value));
					RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_setpoints_RT821.Rows[e.RowIndex].Cells[2].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NBaixo", false) == 0)
				{
					this.DataGridView_setpoints_RT821.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_setpoints_RT821.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_setpoints_RT821.Rows[e.RowIndex].Cells[1].Value);
				}
			}
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x003BC4B0 File Offset: 0x003BA8B0
		private void DataGridView_end_rep_RT821_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_end_rep_RT821.IsCurrentCellDirty)
			{
				this.DataGridView_end_rep_RT821.CommitEdit(512);
			}
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x003BC4D0 File Offset: 0x003BA8D0
		private void DataGridView_end_rep_RT821_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_end_rep_RT821.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_end_1", false) == 0)
				{
					RT_geral.RT_821_BD.Repetidoras[0 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_BD.Repetidoras[0 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_2", false) == 0)
				{
					RT_geral.RT_821_BD.Repetidoras[10 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_BD.Repetidoras[10 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_3", false) == 0)
				{
					RT_geral.RT_821_BD.Repetidoras[20 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_BD.Repetidoras[20 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_4", false) == 0)
				{
					RT_geral.RT_821_BD.Repetidoras[30 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_BD.Repetidoras[30 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_5", false) == 0)
				{
					RT_geral.RT_821_BD.Repetidoras[40 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_BD.Repetidoras[40 + e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x003BC730 File Offset: 0x003BAB30
		private void DataGridView_end_rep_RT821_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			string dataPropertyName = this.DataGridView_end_rep_RT821.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_end_1", false) == 0)
				{
					int num = 0;
					this.DataGridView_end_rep_RT821.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT821.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_821_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT821.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_2", false) == 0)
				{
					int num = 10;
					this.DataGridView_end_rep_RT821.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT821.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_821_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT821.Rows[e.RowIndex].Cells[3].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_3", false) == 0)
				{
					int num = 20;
					this.DataGridView_end_rep_RT821.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT821.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_821_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT821.Rows[e.RowIndex].Cells[5].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_4", false) == 0)
				{
					int num = 30;
					this.DataGridView_end_rep_RT821.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT821.Rows[e.RowIndex].Cells[7].Value));
					RT_geral.RT_821_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT821.Rows[e.RowIndex].Cells[7].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_5", false) == 0)
				{
					int num = 40;
					this.DataGridView_end_rep_RT821.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT821.Rows[e.RowIndex].Cells[9].Value));
					RT_geral.RT_821_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT821.Rows[e.RowIndex].Cells[9].Value);
				}
			}
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x003BCB04 File Offset: 0x003BAF04
		private void DataGridView_visor_RT_821_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_visor_RT_821.IsCurrentCellDirty)
			{
				this.DataGridView_visor_RT_821.CommitEdit(512);
			}
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x003BCB24 File Offset: 0x003BAF24
		private void DataGridView_visor_RT_821_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_visor_RT_821.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_Hab_msg", false) == 0)
			{
				if (Operators.ConditionalCompareObjectEqual(e.FormattedValue, "False", false))
				{
					RT_geral.RT_821_BD.dsp_hab[e.RowIndex].Valor = 0;
					RT_geral.RT_821_BD.dsp_nome[e.RowIndex].Valor = "   ";
					this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[1].Value = RT_geral.RT_821_BD.dsp_nome[e.RowIndex].Valor;
					this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[1].ReadOnly = true;
					this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[2].ReadOnly = true;
					this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[3].ReadOnly = true;
				}
				else
				{
					RT_geral.RT_821_BD.dsp_hab[e.RowIndex].Valor = -1;
					this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[1].ReadOnly = false;
					this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[2].ReadOnly = false;
					this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[3].ReadOnly = false;
				}
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Nome", false) == 0)
			{
				RT_geral.RT_821_BD.dsp_nome[e.RowIndex].Valor = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Strings), "UCase", new object[]
				{
					RuntimeHelpers.GetObjectValue(e.FormattedValue)
				}, null, null, null));
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Testa_nome_dsp_3DIG(ref dataGridView, ref RT_geral.RT_821_BD.dsp_nome[e.RowIndex], e, true);
				sender = dataGridView;
			}
			else if (Operators.CompareString(dataPropertyName, "Col_Escala", false) == 0)
			{
				RT_geral.RT_821_BD.dsp_escalas[e.RowIndex].Valor = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue))));
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_BD.dsp_escalas[e.RowIndex], e, true);
				sender = dataGridView;
			}
			this.DataGridView_visor_RT_821.Refresh();
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x003BCDF8 File Offset: 0x003BB1F8
		private void DataGridView_visor_RT_821_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_visor_RT_821.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_Hab_msg", false) == 0)
				{
					if (Operators.CompareString(RT_geral.RT_821_BD.dsp_nome[e.RowIndex].Valor, "   ", false) == 0)
					{
						RT_geral.RT_821_BD.dsp_nome[e.RowIndex].Valor = "   ";
						this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[1].Value = RT_geral.RT_821_BD.dsp_nome[e.RowIndex].Valor;
						this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[1].ReadOnly = true;
						this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[2].ReadOnly = true;
						this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[3].ReadOnly = true;
					}
					else
					{
						this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[1].ReadOnly = false;
						this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[2].ReadOnly = false;
						this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[3].ReadOnly = false;
					}
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Nome", false) == 0)
				{
					DataGridViewCell dataGridViewCell = this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[1];
					object obj = null;
					Type typeFromHandle = typeof(Strings);
					string text = "UCase";
					object[] array = new object[1];
					object[] array2 = array;
					int num = 0;
					DataGridViewCell dataGridViewCell2 = this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[1];
					array2[num] = RuntimeHelpers.GetObjectValue(dataGridViewCell2.Value);
					object[] array3 = array;
					object[] array4 = array3;
					string[] array5 = null;
					Type[] array6 = null;
					bool[] array7 = new bool[]
					{
						true
					};
					object obj2 = NewLateBinding.LateGet(obj, typeFromHandle, text, array4, array5, array6, array7);
					if (array7[0])
					{
						dataGridViewCell2.Value = RuntimeHelpers.GetObjectValue(array3[0]);
					}
					dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(obj2);
					RT_geral.RT_821_BD.dsp_nome[e.RowIndex].Valor = Conversions.ToString(this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Escala", false) == 0)
				{
					this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[2].Value));
					RT_geral.RT_821_BD.dsp_escalas[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[2].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Pto_Decimal", false) == 0)
				{
					string text2 = Conversions.ToString(this.DataGridView_visor_RT_821.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num2 = 0;
					int num3 = RT_geral.RT_821_DataGrigViewVisorColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					int i = num2;
					while (i <= num3)
					{
						if (Operators.CompareString(RT_geral.RT_821_DataGrigViewVisorColunas[e.ColumnIndex].LinhasMenu[i], text2, false) == 0)
						{
							string dataPropertyName2 = this.DataGridView_visor_RT_821.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName2, "Col_Pto_Decimal", false) == 0)
							{
								RT_geral.RT_821_BD.dsp_pto_decimal[e.RowIndex].Valor = RT_geral.RT_821_DataGrigViewVisorColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_821_BD.dsp_pto_decimal[e.RowIndex].Indice = i;
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

		// Token: 0x06001A29 RID: 6697 RVA: 0x003BD280 File Offset: 0x003BB680
		private void ToolStripButton_RT821_novo_Click(object sender, EventArgs e)
		{
			this.ToolStripButton_RT821_Abrir.Enabled = false;
			this.ToolStripButton_RT821_novo.Enabled = false;
			this.ToolStripButton_RT821_Salvar.Enabled = false;
			this.ToolStripButton_RT821_Download.Enabled = false;
			this.ToolStripButton_RT821_Upload.Enabled = false;
			this.Inicializa_DadosEStruturaRT821_Default();
			RT_geral.RT_821_BD.filename = "";
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			this.Atualiza_Tela_RT_821();
			this.AtualizaMsgTela_RT821("Arquivo gerado com sucesso!", 0);
			this.Timer_limpa_MSG_RT821.Enabled = true;
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x003BD30C File Offset: 0x003BB70C
		private void ToolStripButton_RT821_Abrir_Click(object sender, EventArgs e)
		{
			checked
			{
				int num;
				int num3;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					int[] array = new int[651];
					this.ToolStripButton_RT821_Abrir.Enabled = false;
					this.ToolStripButton_RT821_novo.Enabled = false;
					this.ToolStripButton_RT821_Salvar.Enabled = false;
					this.ToolStripButton_RT821_Download.Enabled = false;
					this.ToolStripButton_RT821_Upload.Enabled = false;
					this.OpenFileDialog_RT821.Filter = "Arquivo de configuração de equipamento|*.Cfg821";
					this.OpenFileDialog_RT821.InitialDirectory = Linha_RT.diretorio;
					if (this.OpenFileDialog_RT821.ShowDialog() == 1)
					{
						if (Operators.CompareString(this.OpenFileDialog_RT821.FileName, "", false) != 0)
						{
							Linha_RT.diretorio = Path.GetDirectoryName(this.OpenFileDialog_RT821.FileName) + "\\";
							RT_geral.arquivo_extensao = Path.GetExtension(this.OpenFileDialog_RT821.FileName);
							IniFile iniFile = new IniFile(this.OpenFileDialog_RT821.FileName);
							RT_geral.RT_821_BD.Equip.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "EQUIPAMENTO", 0);
							RT_geral.RT_821_BD.Versao.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "VERSAO", 0);
							RT_geral.RT_821_BD.Build.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "BUILD", 0);
							RT_geral.RT_821_BD.Release.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "RELEASE", 0);
							if (!Linha_RT.VerificaSeEquipamentoEValido(1, RT_geral.RT_821_BD.Equip.Valor, RT_geral.RT_821_BD.Versao.Valor, RT_geral.RT_821_BD.Build.Valor, RT_geral.RT_821_BD.Release.Valor, RT_geral.arquivo_extensao).Status)
							{
								RT_geral.Lmte_Init_ok = false;
								this.Inicializa_DadosEStruturaRT821_Padrao();
								this.Inicializa_DadosEStruturaRT821_Default();
								Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
								this.Atualiza_Tela_RT_821();
								RT_geral.Lmte_Init_ok = true;
								this.AtualizaMsgTela_RT821("Valores Default carregados", 0);
								this.Timer_limpa_MSG_RT821.Enabled = true;
							}
							else
							{
								RT_geral.RT_821_BD.filename = this.OpenFileDialog_RT821.FileName;
								RT_geral.RT_821_BD.End_estacao.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "ESTACAO", 0);
								RT_geral.RT_821_BD.End_mestre.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "MESTRE", 0);
								RT_geral.RT_821_BD.Modelo.Valor = iniFile.ReadInteger("GERAL_DIVERSOS", "MODELO_EMULADO", 0);
								RT_geral.RT_821_BD.Tempo_ptt.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "TEMPO_PTT", 0);
								RT_geral.RT_821_BD.modo_operacao.Valor = iniFile.ReadInteger("GERAL_PARAM_OPERACAO", "MODO_OPERACAO", RT_geral.RT_821_BD.modo_operacao.valores[0]);
								RT_geral.RT_821_BD.intervalo_tx.Valor = iniFile.ReadInteger("GERAL_PARAM_OPERACAO", "INTERVALO_TX", RT_geral.RT_821_BD.intervalo_tx.Padrao);
								RT_geral.RT_821_BD.baudrate_com1.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "BAUDRATE_COM1", Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate)));
								RT_geral.RT_821_BD.baudrate_com2.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "BAUDRATE_COM2", Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate)));
								if (!perifericos.Lista_ValorPermitido(RT_geral.RT_821_BD.baudrate_com1.Valor, perifericos.ListaBaudRate))
								{
									RT_geral.RT_821_BD.baudrate_com1.Valor = Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate));
								}
								if (!perifericos.Lista_ValorPermitido(RT_geral.RT_821_BD.baudrate_com2.Valor, perifericos.ListaBaudRate))
								{
									RT_geral.RT_821_BD.baudrate_com2.Valor = Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate));
								}
								RT_geral.RT_821_BD.baudrate_com1.AtualizaIndicePeloValor();
								RT_geral.RT_821_BD.baudrate_com2.AtualizaIndicePeloValor();
								RT_geral.RT_821_BD.AD_Intervalo.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "INTERVALO", 0);
								RT_geral.RT_821_BD.AD_Tamanho_filtro.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "TAMANHO_FILTRO", 0);
								int num2 = 0;
								do
								{
									string text = string.Format("ENTRADA_ANALOGICA_{0}", num2 + 1);
									RT_geral.RT_821_BD.EA_Range[num2].Valor = iniFile.ReadInteger(text, "EA_RANGE", 0);
									RT_geral.RT_821_BD.EA_Inicio[num2].Valor = iniFile.ReadInteger(text, "EA_INICIO", 0);
									RT_geral.RT_821_BD.EA_Fim[num2].Valor = iniFile.ReadInteger(text, "EA_FIM", 0);
									num2++;
								}
								while (num2 <= 3);
								num2 = 0;
								do
								{
									string text = string.Format("CFG_CONTROLE_{0}", num2 + 1);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.ctrl_acionamento[num2], RT_geral.RT_821_DataGrigViewProcessosColunas[0], iniFile.ReadInteger(text, "ACIONAMENTO", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.ctrl_ret_acionamento[num2], RT_geral.RT_821_DataGrigViewProcessosColunas[1], iniFile.ReadInteger(text, "RET_ACIONAMENTO", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.ctrl_ED_selecao[num2], RT_geral.RT_821_DataGrigViewProcessosColunas[2], iniFile.ReadInteger(text, "SELECAO_REMOTO", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.ctrl_reverso[num2], RT_geral.RT_821_DataGrigViewProcessosColunas[3], iniFile.ReadInteger(text, "SELECAO_REVERSO", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.ctrl_modo[num2], RT_geral.RT_821_DataGrigViewProcessosColunas[4], iniFile.ReadInteger(text, "MODO_CONTROLE", 0));
									num2++;
								}
								while (num2 <= 2);
								Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.motores_simultaneos[0], RT_geral.RT_821_DataGrigMotoresSimultaneosColunas[0], iniFile.ReadInteger("MOTORES", "SIMULTANEOS", 0));
								RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[0].Valor = iniFile.ReadInteger("MOTORES", "TEMPO_ENTRE_ACIONAMENTOS", 0);
								num2 = 0;
								do
								{
									string text = string.Format("CFG_CONTROLE_{0}", num2 + 1);
									RT_geral.RT_821_BD.ctrl_tempo_max_partida[num2].Valor = iniFile.ReadInteger(text, "TEMPO_MAX_PARTIDA", RT_geral.RT_821_BD.ctrl_tempo_max_partida[num2].Valor);
									RT_geral.RT_821_BD.ctrl_tempo_max_parada[num2].Valor = iniFile.ReadInteger(text, "TEMPO_MAX_PARADA", RT_geral.RT_821_BD.ctrl_tempo_max_parada[num2].Valor);
									num2++;
								}
								while (num2 <= 2);
								num2 = 0;
								do
								{
									string text = string.Format("CFG{0}_ED", num2 + 1);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.config_ED[num2], RT_geral.RT_821_DataGrigViewEDColunas[0], iniFile.ReadInteger("ENTRADA_DIGITAL", text, 0));
									num2++;
								}
								while (num2 <= 7);
								num2 = 0;
								do
								{
									string text = string.Format("DISPLAY{0}", num2 + 1);
									RT_geral.RT_821_BD.dsp_escalas[num2].Valor = iniFile.ReadInteger(text, "ESCALA", RT_geral.RT_821_BD.dsp_escalas[num2].Valor);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.dsp_pto_decimal[num2], RT_geral.RT_821_DataGrigViewVisorColunas[3], iniFile.ReadInteger(text, "PONTO_DECIMAL", 0));
									num2++;
								}
								while (num2 <= 7);
								num2 = 0;
								do
								{
									string text = string.Format("DISPLAY{0}", num2 + 1);
									RT_geral.RT_821_BD.dsp_hab[num2].Valor = iniFile.ReadInteger(text, "HABILITADO", 0);
									num2++;
								}
								while (num2 <= 7);
								num2 = 0;
								do
								{
									string text = string.Format("DISPLAY{0}", num2 + 1);
									RT_geral.RT_821_BD.dsp_nome[num2].Valor = iniFile.ReadText(text, "NOME", "");
									num2++;
								}
								while (num2 <= 7);
								RT_geral.RT_821_BD.modo_repetidora.Valor = iniFile.ReadInteger("REPETIDORA", "HABILITA_REPETIDORA", 0);
								RT_geral.RT_821_BD.End_repetidora.Valor = iniFile.ReadInteger("REPETIDORA", "ENDERECO", 0);
								RT_geral.RT_821_BD.Num_repetidoras.Valor = iniFile.ReadInteger("REPETIDORA", "NUMERO_REPETIDORAS", 0);
								num2 = 0;
								do
								{
									string text = string.Format("RPT{0}", num2 + 1);
									RT_geral.RT_821_BD.Repetidoras[num2].Valor = iniFile.ReadInteger("REPETIDORA", text, 0);
									num2++;
								}
								while (num2 <= 49);
								num2 = 0;
								do
								{
									string text = string.Format("SETPOINT{0}", num2 + 1);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_821_BD.Setpoints_ctrl_variavel[num2], RT_geral.RT_821_DataGrigViewSetpointsColunas[0], iniFile.ReadInteger(text, "CTRL_VARIAVEL", 0));
									RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[num2].Valor = iniFile.ReadInteger(text, "NIVEL_ALTO", 0);
									RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[num2].Valor = iniFile.ReadInteger(text, "NIVEL_BAIXO", 0);
									num2++;
								}
								while (num2 <= 2);
								this.TextBox_nome_RT821.Text = iniFile.ReadText("GERAL_DESCRICAO", "NOME", "");
								this.TextBox_endereco_RT821.Text = iniFile.ReadText("GERAL_DESCRICAO", "ENDERECO", "");
								this.TextBox_comentarios_RT821.Text = iniFile.ReadText("GERAL_DESCRICAO", "COMENTARIO", "");
								this.CB_TipoAntena.SelectedIndex = iniFile.ReadInteger("DADOS_INSTALACAO", "TIPO_ANTENA", -1);
								this.CB_PolarizacaoAntena.SelectedIndex = iniFile.ReadInteger("DADOS_INSTALACAO", "POLARIZACAO_ANTENA", -1);
								this.T_PotRadio.Text = iniFile.ReadText("DADOS_INSTALACAO", "POTENCIA_RADIO", "");
								this.CB_ModeloRadio.SelectedIndex = iniFile.ReadInteger("DADOS_INSTALACAO", "MODELO_RADIO", -1);
								this.T_DistCentral.Text = iniFile.ReadText("DADOS_INSTALACAO", "DISTANCIA_CENTRAL", "");
								this.T_FreqRadio.Text = iniFile.ReadText("DADOS_INSTALACAO", "FREQUENCIA_RADIO", "");
								this.T_Azimute.Text = iniFile.ReadText("DADOS_INSTALACAO", "AZIMUTE", "");
								this.T_Longitude.Text = iniFile.ReadText("DADOS_INSTALACAO", "LONGITUDE", "");
								this.T_Latitude.Text = iniFile.ReadText("DADOS_INSTALACAO", "LATITUDE", "");
								this.T_AlturaAntena.Text = iniFile.ReadText("DADOS_INSTALACAO", "ALTURA_ANTENA", "");
								this.T_ModeloFonte.Text = iniFile.ReadText("DADOS_INSTALACAO", "MODELO_FONTE", "");
								this.Atualiza_Tela_RT_821();
								this.AtualizaMsgTela_RT821("Arquivo carregado com sucesso!", 0);
								this.Timer_limpa_MSG_RT821.Enabled = true;
							}
						}
					}
					else
					{
						this.AtualizaMsgTela_RT821("Operação Cancelada", 0);
						this.Timer_limpa_MSG_RT821.Enabled = true;
					}
					goto IL_BD7;
					IL_B72:
					Interaction.MsgBox("Não foi possível carregar os dados", 32, "Atenção - Erro I/0");
					this.Timer_limpa_MSG_RT821.Enabled = true;
					goto IL_BD7;
					IL_B92:
					num3 = -1;
										IL_BA8:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num3 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_B92;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_BD7:
				if (num3 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x003BDF18 File Offset: 0x003BC318
		private void ToolStripButton_RT821_Salvar_Click(object sender, EventArgs e)
		{
			checked
			{
				int num;
				int num12;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					int[] array = new int[651];
					this.ToolStripButton_RT821_Abrir.Enabled = false;
					this.ToolStripButton_RT821_novo.Enabled = false;
					this.ToolStripButton_RT821_Salvar.Enabled = false;
					this.ToolStripButton_RT821_Download.Enabled = false;
					this.ToolStripButton_RT821_Upload.Enabled = false;
					array[0] = RT_geral.RT_821_BD.Equip.Valor;
					array[1] = RT_geral.RT_821_BD.Versao.Valor;
					array[2] = RT_geral.RT_821_BD.Build.Valor;
					array[3] = RT_geral.RT_821_BD.Release.Valor;
					array[4] = RT_geral.RT_821_BD.End_estacao.Valor;
					array[5] = RT_geral.RT_821_BD.End_mestre.Valor;
					array[6] = RT_geral.RT_821_BD.Modelo.Valor;
					array[8] = RT_geral.RT_821_BD.Tempo_ptt.Valor;
					array[9] = RT_geral.RT_821_BD.AD_Intervalo.Valor;
					array[10] = RT_geral.RT_821_BD.AD_Tamanho_filtro.Valor;
					int i = 0;
					do
					{
						array[11 + i] = RT_geral.RT_821_BD.EA_Range[i].Valor;
						array[15 + i] = RT_geral.RT_821_BD.EA_Inicio[i].Valor;
						array[19 + i] = RT_geral.RT_821_BD.EA_Fim[i].Valor;
						i++;
					}
					while (i <= 3);
					i = 0;
					do
					{
						array[23 + i] = RT_geral.RT_821_BD.ctrl_acionamento[i].Valor;
						array[26 + i] = RT_geral.RT_821_BD.ctrl_ret_acionamento[i].Valor;
						array[29 + i] = RT_geral.RT_821_BD.ctrl_ED_selecao[i].Valor;
						array[32 + i] = RT_geral.RT_821_BD.ctrl_reverso[i].Valor;
						array[35 + i] = RT_geral.RT_821_BD.ctrl_modo[i].Valor;
						i++;
					}
					while (i <= 2);
					array[38] = RT_geral.RT_821_BD.motores_simultaneos[0].Valor;
					array[39] = RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[0].Valor;
					i = 0;
					do
					{
						array[40 + i] = RT_geral.RT_821_BD.ctrl_tempo_max_partida[i].Valor;
						array[43 + i] = RT_geral.RT_821_BD.ctrl_tempo_max_parada[i].Valor;
						i++;
					}
					while (i <= 2);
					i = 0;
					do
					{
						array[46 + i] = RT_geral.RT_821_BD.config_ED[i].Valor;
						i++;
					}
					while (i <= 7);
					i = 0;
					do
					{
						array[54 + i] = RT_geral.RT_821_BD.dsp_escalas[i].Valor;
						array[62 + i] = RT_geral.RT_821_BD.dsp_pto_decimal[i].Valor;
						i++;
					}
					while (i <= 7);
					i = 0;
					do
					{
						array[70 + i] = RT_geral.RT_821_BD.dsp_hab[i].Valor;
						i++;
					}
					while (i <= 7);
					i = 0;
					do
					{
						int num2 = i * 3;
						string valor = RT_geral.RT_821_BD.dsp_nome[i].Valor;
						if (Strings.Len(valor) != 3)
						{
							array[78 + num2] = 32;
							array[79 + num2] = 32;
							array[80 + num2] = 32;
						}
						else
						{
							array[78 + num2] = Strings.Asc(Strings.Mid(valor, 1, 1));
							array[79 + num2] = Strings.Asc(Strings.Mid(valor, 2, 1));
							array[80 + num2] = Strings.Asc(Strings.Mid(valor, 3, 1));
						}
						i++;
					}
					while (i <= 7);
					array[102] = RT_geral.RT_821_BD.End_repetidora.Valor;
					array[103] = RT_geral.RT_821_BD.Num_repetidoras.Valor;
					i = 0;
					do
					{
						array[104 + i] = RT_geral.RT_821_BD.Repetidoras[i].Valor;
						i++;
					}
					while (i <= 49);
					i = 0;
					do
					{
						array[154 + i] = RT_geral.RT_821_BD.Setpoints_ctrl_variavel[i].Valor;
						array[157 + i] = RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[i].Valor;
						array[160 + i] = RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[i].Valor;
						i++;
					}
					while (i <= 2);
					int num3 = 163;
					int textLength = this.TextBox_nome_RT821.TextLength;
					array[num3] = textLength;
					num3++;
					char[] array2 = this.TextBox_nome_RT821.Text.ToCharArray();
					int num4 = 0;
					int num5 = textLength - 1;
					for (i = num4; i <= num5; i++)
					{
						array[num3 + i] = (int)array2[i];
					}
					num3 += i;
					textLength = this.TextBox_endereco_RT821.TextLength;
					array[num3] = textLength;
					num3++;
					char[] array3 = this.TextBox_endereco_RT821.Text.ToCharArray();
					int num6 = 0;
					int num7 = textLength - 1;
					for (i = num6; i <= num7; i++)
					{
						array[num3 + i] = (int)array3[i];
					}
					num3 += i;
					textLength = this.TextBox_comentarios_RT821.TextLength;
					array[num3] = textLength;
					num3++;
					char[] array4 = this.TextBox_comentarios_RT821.Text.ToCharArray();
					int num8 = 0;
					int num9 = textLength - 1;
					for (i = num8; i <= num9; i++)
					{
						array[num3 + i] = (int)array4[i];
					}
					this.SaveFileDialog_RT821.Filter = "Arquivo de configuração de equipamento|*.Cfg821";
					this.SaveFileDialog_RT821.InitialDirectory = Linha_RT.diretorio;
					if (this.SaveFileDialog_RT821.ShowDialog() == 1)
					{
						if (Operators.CompareString(this.SaveFileDialog_RT821.FileName, "", false) != 0)
						{
							Linha_RT.diretorio = Path.GetDirectoryName(this.SaveFileDialog_RT821.FileName) + "\\";
							if (File.Exists(this.SaveFileDialog_RT821.FileName))
							{
								if (File.Exists(this.SaveFileDialog_RT821.FileName + ".old"))
								{
									File.Delete(this.SaveFileDialog_RT821.FileName + ".old");
								}
								File.Move(this.SaveFileDialog_RT821.FileName, this.SaveFileDialog_RT821.FileName + ".old");
							}
							IniFileWriteFast iniFileWriteFast = new IniFileWriteFast(this.SaveFileDialog_RT821.FileName);
							RT_geral.RT_821_BD.filename = this.SaveFileDialog_RT821.FileName;
							this.InicializaBarraProgressoTela_RT821(9);
							iniFileWriteFast.WriteSection("GERAL_INFORMACAO");
							iniFileWriteFast.WriteKey("EQUIPAMENTO", RT_geral.RT_821_BD.Equip.Valor);
							iniFileWriteFast.WriteKey("VERSAO", RT_geral.RT_821_BD.Versao.Valor);
							iniFileWriteFast.WriteKey("BUILD", RT_geral.RT_821_BD.Build.Valor);
							iniFileWriteFast.WriteKey("RELEASE", RT_geral.RT_821_BD.Release.Valor);
							iniFileWriteFast.LineSpace();
							iniFileWriteFast.WriteSection("GERAL_PARAM_COMINICACAO");
							iniFileWriteFast.WriteKey("ESTACAO", RT_geral.RT_821_BD.End_estacao.Valor);
							iniFileWriteFast.WriteKey("MESTRE", RT_geral.RT_821_BD.End_mestre.Valor);
							iniFileWriteFast.WriteKey("TEMPO_PTT", RT_geral.RT_821_BD.Tempo_ptt.Valor);
							iniFileWriteFast.WriteKey("BAUDRATE_COM1", RT_geral.RT_821_BD.baudrate_com1.Valor);
							iniFileWriteFast.WriteKey("BAUDRATE_COM2", RT_geral.RT_821_BD.baudrate_com2.Valor);
							iniFileWriteFast.LineSpace();
							iniFileWriteFast.WriteSection("GERAL_PARAM_OPERACAO");
							iniFileWriteFast.WriteKey("MODO_OPERACAO", RT_geral.RT_821_BD.modo_operacao.Valor);
							iniFileWriteFast.WriteKey("INTERVALO_TX", RT_geral.RT_821_BD.intervalo_tx.Valor);
							iniFileWriteFast.LineSpace();
							iniFileWriteFast.WriteSection("GERAL_DESCRICAO");
							iniFileWriteFast.WriteKey("NOME", this.TextBox_nome_RT821.Text);
							iniFileWriteFast.WriteKey("ENDERECO", this.TextBox_endereco_RT821.Text);
							iniFileWriteFast.WriteKey("COMENTARIO", this.TextBox_comentarios_RT821.Text);
							iniFileWriteFast.LineSpace();
							iniFileWriteFast.WriteSection("GERAL_DIVERSOS");
							iniFileWriteFast.WriteKey("MODELO_EMULADO", RT_geral.RT_821_BD.Modelo.Valor);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT821.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("ENTRADA_ANALOGICA");
							iniFileWriteFast.WriteKey("INTERVALO", RT_geral.RT_821_BD.AD_Intervalo.Valor);
							iniFileWriteFast.WriteKey("TAMANHO_FILTRO", RT_geral.RT_821_BD.AD_Tamanho_filtro.Valor);
							iniFileWriteFast.LineSpace();
							i = 0;
							do
							{
								string text = string.Format("ENTRADA_ANALOGICA_{0}", i + 1);
								iniFileWriteFast.WriteSection(text);
								iniFileWriteFast.WriteKey("EA_RANGE", RT_geral.RT_821_BD.EA_Range[i].Valor);
								iniFileWriteFast.WriteKey("EA_INICIO", RT_geral.RT_821_BD.EA_Inicio[i].Valor);
								iniFileWriteFast.WriteKey("EA_FIM", RT_geral.RT_821_BD.EA_Fim[i].Valor);
								iniFileWriteFast.LineSpace();
								i++;
							}
							while (i <= 3);
							this.ToolStripProgressBar_RT821.PerformStep();
							Application.DoEvents();
							i = 0;
							do
							{
								string text = string.Format("CFG_CONTROLE_{0}", i + 1);
								iniFileWriteFast.WriteSection(text);
								iniFileWriteFast.WriteKey("ACIONAMENTO", RT_geral.RT_821_BD.ctrl_acionamento[i].Valor);
								iniFileWriteFast.WriteKey("RET_ACIONAMENTO", RT_geral.RT_821_BD.ctrl_ret_acionamento[i].Valor);
								iniFileWriteFast.WriteKey("SELECAO_REMOTO", RT_geral.RT_821_BD.ctrl_ED_selecao[i].Valor);
								iniFileWriteFast.WriteKey("SELECAO_REVERSO", RT_geral.RT_821_BD.ctrl_reverso[i].Valor);
								iniFileWriteFast.WriteKey("MODO_CONTROLE", RT_geral.RT_821_BD.ctrl_modo[i].Valor);
								iniFileWriteFast.WriteKey("TEMPO_MAX_PARTIDA", RT_geral.RT_821_BD.ctrl_tempo_max_partida[i].Valor);
								iniFileWriteFast.WriteKey("TEMPO_MAX_PARADA", RT_geral.RT_821_BD.ctrl_tempo_max_parada[i].Valor);
								iniFileWriteFast.LineSpace();
								i++;
							}
							while (i <= 2);
							this.ToolStripProgressBar_RT821.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("MOTORES");
							iniFileWriteFast.WriteKey("SIMULTANEOS", RT_geral.RT_821_BD.motores_simultaneos[0].Valor);
							iniFileWriteFast.WriteKey("TEMPO_ENTRE_ACIONAMENTOS", RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[0].Valor);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT821.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("ENTRADA_DIGITAL");
							i = 0;
							do
							{
								string text = string.Format("CFG{0}_ED", i + 1);
								iniFileWriteFast.WriteKey(text, RT_geral.RT_821_BD.config_ED[i].Valor);
								i++;
							}
							while (i <= 7);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT821.PerformStep();
							Application.DoEvents();
							i = 0;
							do
							{
								string text = string.Format("DISPLAY{0}", i + 1);
								iniFileWriteFast.WriteSection(text);
								iniFileWriteFast.WriteKey("NOME", RT_geral.RT_821_BD.dsp_nome[i].Valor);
								iniFileWriteFast.WriteKey("ESCALA", RT_geral.RT_821_BD.dsp_escalas[i].Valor);
								iniFileWriteFast.WriteKey("PONTO_DECIMAL", RT_geral.RT_821_BD.dsp_pto_decimal[i].Valor);
								iniFileWriteFast.WriteKey("HABILITADO", RT_geral.RT_821_BD.dsp_hab[i].Valor);
								iniFileWriteFast.LineSpace();
								i++;
							}
							while (i <= 7);
							this.ToolStripProgressBar_RT821.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("REPETIDORA");
							iniFileWriteFast.WriteKey("HABILITA_REPETIDORA", RT_geral.RT_821_BD.modo_repetidora.Valor);
							iniFileWriteFast.WriteKey("ENDERECO", RT_geral.RT_821_BD.End_repetidora.Valor);
							iniFileWriteFast.WriteKey("NUMERO_REPETIDORAS", RT_geral.RT_821_BD.Num_repetidoras.Valor);
							int num10 = 0;
							int num11 = RT_geral.RT_821_BD.Num_repetidoras.Valor - 1;
							for (i = num10; i <= num11; i++)
							{
								string text = string.Format("RPT{0}", i + 1);
								iniFileWriteFast.WriteKey(text, RT_geral.RT_821_BD.Repetidoras[i].Valor);
							}
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT821.PerformStep();
							Application.DoEvents();
							i = 0;
							do
							{
								string text = string.Format("SETPOINT{0}", i + 1);
								iniFileWriteFast.WriteSection(text);
								iniFileWriteFast.WriteKey("CTRL_VARIAVEL", RT_geral.RT_821_BD.Setpoints_ctrl_variavel[i].Valor);
								iniFileWriteFast.WriteKey("NIVEL_ALTO", RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[i].Valor);
								iniFileWriteFast.WriteKey("NIVEL_BAIXO", RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[i].Valor);
								iniFileWriteFast.LineSpace();
								i++;
							}
							while (i <= 2);
							this.ToolStripProgressBar_RT821.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("DADOS_INSTALACAO");
							iniFileWriteFast.WriteKey("TIPO_ANTENA", this.CB_TipoAntena.SelectedIndex);
							iniFileWriteFast.WriteKey("POLARIZACAO_ANTENA", this.CB_PolarizacaoAntena.SelectedIndex);
							iniFileWriteFast.WriteKey("POTENCIA_RADIO", this.T_PotRadio.Text);
							iniFileWriteFast.WriteKey("MODELO_RADIO", this.CB_ModeloRadio.SelectedIndex);
							iniFileWriteFast.WriteKey("DISTANCIA_CENTRAL", this.T_DistCentral.Text);
							iniFileWriteFast.WriteKey("FREQUENCIA_RADIO", this.T_FreqRadio.Text);
							iniFileWriteFast.WriteKey("AZIMUTE", this.T_Azimute.Text);
							iniFileWriteFast.WriteKey("LONGITUDE", this.T_Longitude.Text);
							iniFileWriteFast.WriteKey("LATITUDE", this.T_Latitude.Text);
							iniFileWriteFast.WriteKey("ALTURA_ANTENA", this.T_AlturaAntena.Text);
							iniFileWriteFast.WriteKey("MODELO_FONTE", this.T_ModeloFonte.Text);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT821.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.CloseIniFileWriteFast();
							this.AtualizaMsgTela_RT821("Arquivo gerado com sucesso!", 0);
							this.Timer_limpa_MSG_RT821.Enabled = true;
						}
					}
					else
					{
						this.AtualizaMsgTela_RT821("Operação Cancelada", 0);
						this.Timer_limpa_MSG_RT821.Enabled = true;
					}
					goto IL_F87;
					IL_F22:
					Interaction.MsgBox("Não foi possível gravar os dados", 32, "Atenção - Erro I/0");
					this.Timer_limpa_MSG_RT821.Enabled = true;
					goto IL_F87;
					IL_F42:
					num12 = -1;
										IL_F58:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num12 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_F42;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_F87:
				if (num12 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x003BEED4 File Offset: 0x003BD2D4
		private void ToolStripButton_RT821_Download_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface == 1)
			{
				if (Comunicacao.VerificaPortaSerialExiste())
				{
					this.Bloqueia_acoes_RT821();
					this.EncerraEdicaoDeCampos_RT821();
					this.Leitura_RT821_conf();
				}
				else
				{
					Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", 16, "Atenção");
				}
			}
			else if (Comunicacao.Config_sistema.tipo_interface == 2)
			{
				this.Bloqueia_acoes_RT821();
				this.EncerraEdicaoDeCampos_RT821();
				this.Leitura_RT821_conf();
			}
			else
			{
				Interaction.MsgBox("Não existe definição de tipo de interface de comunicação!\r\nComando não executado!", 16, "Atenção");
			}
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x003BEF50 File Offset: 0x003BD350
		private void ToolStripButton_RT821_Upload_Click(object sender, EventArgs e)
		{
			this.ToolStripButton_RT821_Abrir.Enabled = false;
			this.ToolStripButton_RT821_novo.Enabled = false;
			this.ToolStripButton_RT821_Salvar.Enabled = false;
			this.ToolStripButton_RT821_Download.Enabled = false;
			this.ToolStripButton_RT821_Upload.Enabled = false;
			this.Escrita_RT821_conf();
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x003BEFA0 File Offset: 0x003BD3A0
		public void Leitura_RT821_conf()
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
			this.InicializaBarraProgressoTela_RT821(8);
			this.AtualizaMsgTela_RT821("Identificação de equipamento - Etapa 1", 2);
			this.ToolStripProgressBar_RT821.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(0, 255, 4).Status)
			{
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Linha_RT.VerificaSeEquipamentoEValido(2, 0, 0, 0, 0, "");
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT821(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT821(0);
			this.AtualizaMsgTela_RT821("Leitura de configuração - Etapa 2", 2);
			this.ToolStripProgressBar_RT821.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(2048, 255, 94).Status)
			{
				this.AtualizaMsgTela_RT821("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT821(2048);
			this.AtualizaMsgTela_RT821("Leitura de configuração - Etapa 3", 2);
			this.ToolStripProgressBar_RT821.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(4096, RT_geral.RT_821_BD.End_estacao.Valor, 52).Status)
			{
				this.AtualizaMsgTela_RT821("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT821(4096);
			this.AtualizaMsgTela_RT821("Leitura de configuração - Passo 4", 2);
			this.ToolStripProgressBar_RT821.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(8192, RT_geral.RT_821_BD.End_estacao.Valor, 3).Status)
			{
				this.AtualizaMsgTela_RT821("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT821(8192);
			this.AtualizaMsgTela_RT821("Leitura de configuração - Passo 5", 2);
			this.ToolStripProgressBar_RT821.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(10240, RT_geral.RT_821_BD.End_estacao.Valor, 6).Status)
			{
				this.AtualizaMsgTela_RT821("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT821(10240);
			this.Atualiza_Tela_RT_821();
			this.AtualizaMsgTela_RT821("Configuração lida com sucesso", 0);
			this.ToolStripProgressBar_RT821.PerformStep();
			this.Timer_limpa_MSG_RT821.Enabled = true;
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x003BF1D4 File Offset: 0x003BD5D4
		public void Escrita_RT821_conf()
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
			this.InicializaBarraProgressoTela_RT821(14);
			this.AtualizaMsgTela_RT821("Identificação de equipamento - Etapa 1", 0);
			this.ToolStripProgressBar_RT821.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(0, 255, 4).Status)
			{
				this.AtualizaMsgTela_RT821("Equipamento não responde", 1);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Linha_RT.VerificaSeEquipamentoEValido(2, 0, 0, 0, 0, "");
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT821(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT821(0);
			this.AtualizaMsgTela_RT821("Habilita escrita de dados Pag 1 - Etapa 2", 0);
			this.ToolStripProgressBar_RT821.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT821(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT821("Escrita de configuração Pag 1 - Etapa 3", 0);
			this.ToolStripProgressBar_RT821.PerformStep();
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(2048, 2, 0).Status)
			{
				this.AtualizaMsgTela_RT821("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT821("Salva Página 1 - Etapa 5", 0);
			this.ToolStripProgressBar_RT821.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT821(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT821(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT821("Escrita de configuração Pag 2 - Etapa 6", 0);
			this.ToolStripProgressBar_RT821.PerformStep();
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(4096, 2, 0).Status)
			{
				this.AtualizaMsgTela_RT821("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT821("Salva Página 2 - Etapa 7", 0);
			this.ToolStripProgressBar_RT821.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT821(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT821(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT821("Escrita de configuração Pag 4 - Etapa 8", 0);
			this.ToolStripProgressBar_RT821.PerformStep();
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(8192, 2, 0).Status)
			{
				this.AtualizaMsgTela_RT821("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT821("Salva Página 4 - Etapa 9", 0);
			this.ToolStripProgressBar_RT821.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT821(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT821(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT821("Escrita de configuração Pag 5 - Etapa 10", 0);
			this.ToolStripProgressBar_RT821.PerformStep();
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(10240, 2, 0).Status)
			{
				this.AtualizaMsgTela_RT821("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT821("Salva Página 5 - Etapa 11", 0);
			this.ToolStripProgressBar_RT821.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT821(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_RT821.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT821("Escrita realizada com sucesso", 0);
			this.ToolStripProgressBar_RT821.PerformStep();
			this.Timer_limpa_MSG_RT821.Enabled = true;
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x003BF5D0 File Offset: 0x003BD9D0
		private void Timer_limpa_MSG_RT821_Tick(object sender, EventArgs e)
		{
			this.Timer_limpa_MSG_RT821.Enabled = false;
			this.AtualizaMsgTela_RT821("", 0);
			this.ToolStripProgressBar_RT821.Value = 0;
			this.Libera_acoes_RT821();
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x003BF5FC File Offset: 0x003BD9FC
		public void Libera_acoes_RT821()
		{
			this.ToolStripButton_RT821_Abrir.Enabled = true;
			this.ToolStripButton_RT821_novo.Enabled = true;
			this.ToolStripButton_RT821_Salvar.Enabled = true;
			if (Comunicacao.Config_sistema.tipo_interface == 1)
			{
				if (Geral.Config_geral.Porta_serial_Ok)
				{
					this.ToolStripButton_RT821_Download.Enabled = true;
					this.ToolStripButton_RT821_Upload.Enabled = true;
				}
				else
				{
					this.ToolStripButton_RT821_Download.Enabled = false;
					this.ToolStripButton_RT821_Upload.Enabled = false;
				}
			}
			else if (Comunicacao.Config_sistema.tipo_interface == 2)
			{
				this.ToolStripButton_RT821_Download.Enabled = true;
				this.ToolStripButton_RT821_Upload.Enabled = true;
			}
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x003BF6A0 File Offset: 0x003BDAA0
		public void Bloqueia_acoes_RT821()
		{
			this.ToolStripButton_RT821_Abrir.Enabled = false;
			this.ToolStripButton_RT821_novo.Enabled = false;
			this.ToolStripButton_RT821_Salvar.Enabled = false;
			this.ToolStripButton_RT821_Download.Enabled = false;
			this.ToolStripButton_RT821_Upload.Enabled = false;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x003BF6E0 File Offset: 0x003BDAE0
		public void EncerraEdicaoDeCampos_RT821()
		{
			this.DataGridView_end_rep_RT821.EndEdit();
			this.DataGridView_MotoresSimultaneos_RT_821.EndEdit();
			this.DataGridView_parametros_EA_RT821.EndEdit();
			this.DataGridView_processo_RT821.EndEdit();
			this.DataGridView_RT821_ED.EndEdit();
			this.DataGridView_setpoints_RT821.EndEdit();
			this.DataGridView_visor_RT_821.EndEdit();
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x003BF744 File Offset: 0x003BDB44
		private void RT_821_Conf_FormClosed(object sender, FormClosedEventArgs e)
		{
			RT_geral.Telas_RT_821.Configuracao = false;
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x003BF754 File Offset: 0x003BDB54
		private void ToolStripButton_RT821_Imprimir_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			using (EnhancedPrintPreviewDialog enhancedPrintPreviewDialog = new EnhancedPrintPreviewDialog())
			{
				enhancedPrintPreviewDialog.Document = this.PrintDocument1;
				enhancedPrintPreviewDialog.ShowDialog();
			}
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x003BF79C File Offset: 0x003BDB9C
		private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
		{
			this.pagina_impressao = 1;
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x003BF7A8 File Offset: 0x003BDBA8
		private void PrintDocument1_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
		{
			switch (this.pagina_impressao)
			{
			case 1:
				e.PageSettings.Landscape = true;
				break;
			case 2:
				e.PageSettings.Landscape = true;
				break;
			case 3:
				e.PageSettings.Landscape = true;
				break;
			}
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x003BF7F8 File Offset: 0x003BDBF8
		private void DesenhaRelatorioRT821Pagina2(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, 3);
			Font font2 = new Font("Calibri", 10f, 3, 3);
			Font font3 = new Font("Calibri", 10f, 0, 3);
			Font fonte = new Font("Calibri", 20f, 1, 3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_821_BD.Equip.Valor, RT_geral.RT_821_BD.Versao.Valor);
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 5, 9, "Entrada Digital", true);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "ED", 0);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Função", 200);
			string valor = "";
			int i = 0;
			checked
			{
				do
				{
					int valor2 = RT_geral.RT_821_BD.config_ED[i].Valor;
					if (valor2 == 21856)
					{
						valor = "Sem Função";
					}
					else if (valor2 == 21969)
					{
						valor = "Arrombamento";
					}
					else if (valor2 == 21970)
					{
						valor = "Falta de Fase";
					}
					else if (valor2 == 21971)
					{
						valor = "Alagamento";
					}
					else if (valor2 == 21972)
					{
						valor = "Horário de Ponta";
					}
					else if (valor2 == 21973)
					{
						valor = "Transbordo";
					}
					else if (valor2 == 21974)
					{
						valor = "Operação em Bateria";
					}
					tabelaMeiaLinhaEsquerda.EscreveTituloLinha(i + 2, string.Format("{0:D2}", i + 1), 0);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(i + 2, valor, 190);
					i++;
				}
				while (i <= 7);
				TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, 5, 9, "Visor", true);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "MSG", 0);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Habilita MSG", 50);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Nome", 175);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Escala", 300);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Pto Dec", 400);
				string[] array = new string[]
				{
					"EA1",
					"EA2",
					"EA3",
					"EA4",
					"REF1",
					"REF2",
					"REF3",
					"REF4"
				};
				int num = 0;
				int num2 = array.Length - 1;
				for (i = num; i <= num2; i++)
				{
					tabelaMeiaLinhaDireita.EscreveTituloLinha(i + 2, array[i], 0);
					string text = "???";
					switch (RT_geral.RT_821_BD.dsp_hab[i].Valor)
					{
					case -1:
						text = "Sim";
						break;
					case 0:
						text = "Não";
						break;
					}
					tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, text, 55);
					tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, RT_geral.RT_821_BD.dsp_nome[i].Valor, 180);
					tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, RT_geral.RT_821_BD.dsp_escalas[i].Valor.ToString(), 305);
					text = "???";
					switch (RT_geral.RT_821_BD.dsp_pto_decimal[i].Valor)
					{
					case 0:
						text = "Sem pto";
						break;
					case 1:
						text = "00.0";
						break;
					case 2:
						text = "0.00";
						break;
					}
					tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, text, 405);
				}
				TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda.GetNextLineAvailable(), 4, "SetPoint", true);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Ctrl", 0);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Variável Controle", 80);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Nivel Baixo", 410);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Nível Alto", 800);
				i = 0;
				do
				{
					string text = string.Format("{0:D2}", i + 1);
					tabelaLinhaInteria.EscreveTituloLinha(i + 2, text, 0);
					text = "???";
					switch (RT_geral.RT_821_BD.Setpoints_ctrl_variavel[i].Valor)
					{
					case 21856:
						text = "CTRL Desativado";
						break;
					case 21857:
						text = "EA01";
						break;
					case 21858:
						text = "EA02";
						break;
					case 21859:
						text = "EA03";
						break;
					case 21860:
						text = "EA04";
						break;
					case 21861:
						text = "EA05";
						break;
					case 21862:
						text = "EA06";
						break;
					case 21863:
						text = "EA07";
						break;
					case 21864:
						text = "EA08";
						break;
					case 21865:
						text = "EA09";
						break;
					case 21866:
						text = "EA10";
						break;
					case 21867:
						text = "EA11";
						break;
					case 21868:
						text = "EA12";
						break;
					case 21869:
						text = "EA13";
						break;
					case 21870:
						text = "EA14";
						break;
					case 21871:
						text = "EA15";
						break;
					case 21872:
						text = "EA16";
						break;
					case 21873:
						text = "Valor Refêrencia1";
						break;
					case 21874:
						text = "Valor Refêrencia2";
						break;
					case 21875:
						text = "Valor Refêrencia3";
						break;
					case 21876:
						text = "Valor Refêrencia4";
						break;
					}
					tabelaLinhaInteria.EscreveValorLinha(i + 2, text, 90);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_geral.RT_821_BD.Setpoints_ctrl_nivel_baixo[i].Valor.ToString(), 415);
					tabelaLinhaInteria.EscreveValorLinha(i + 2, RT_geral.RT_821_BD.Setpoints_ctrl_nivel_alto[i].Valor.ToString(), 805);
					i++;
				}
				while (i <= 2);
				TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria.GetNextLineAvailable(), 1, "Repetidora", true);
				string item = RT_geral.RT_821_BD.modo_repetidora.GetItem();
				tabelaLinhaInteria2.EscreveTituloValorLinha(1, "Modo", item, 0, 60);
				tabelaLinhaInteria2.EscreveTituloValorLinha(1, "End. Mestre", RT_geral.RT_821_BD.End_repetidora.Valor.ToString(), 240, 320);
				tabelaLinhaInteria2.EscreveTituloValorLinha(1, "Quantidade End. Repetidos", RT_geral.RT_821_BD.Num_repetidoras.Valor.ToString(), 410, 600);
				int num3 = RT_geral.RT_821_BD.Num_repetidoras.Valor / 20;
				if (RT_geral.RT_821_BD.Num_repetidoras.Valor > 0)
				{
					if (RT_geral.RT_821_BD.Num_repetidoras.Valor % 20 != 0)
					{
						num3++;
					}
					int num4 = 1;
					int num5 = num3;
					for (i = num4; i <= num5; i++)
					{
						tabelaLinhaInteria2.AdicionaLinha();
						string text2 = "";
						int num6 = (i - 1) * 20;
						int num7 = (i - 1) * 20 + 19;
						for (int j = num6; j <= num7; j++)
						{
							if (j + 1 < RT_geral.RT_821_BD.Num_repetidoras.Valor)
							{
								text2 = text2 + RT_geral.RT_821_BD.Repetidoras[j].Valor.ToString() + ", ";
							}
							else if (j + 1 == RT_geral.RT_821_BD.Num_repetidoras.Valor)
							{
								text2 += RT_geral.RT_821_BD.Repetidoras[j].Valor.ToString();
								break;
							}
						}
						tabelaLinhaInteria2.EscreveValorLinha(i + 1, text2, 50);
					}
				}
				TabelaLinhaInteria tabelaLinhaInteria3 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria2.GetNextLineAvailable(), 3, "Comentários", true);
				tabelaLinhaInteria3.EscreveValorLinha(1, this.TextBox_comentarios_RT821.Text, 0);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x003C0054 File Offset: 0x003BE454
		[MethodImpl(72)]
		private void DesenhaRelatorioRT821Pagina1(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, 3);
			Font font2 = new Font("Calibri", 10f, 3, 3);
			Font font3 = new Font("Calibri", 10f, 0, 3);
			Font fonte = new Font("Calibri", 20f, 1, 3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_821_BD.Equip.Valor, RT_geral.RT_821_BD.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 4, "Dados da Estação", true);
			tabelaLinhaInteria.EscreveTituloValorLinha(1, "Local de Instalação", this.TextBox_nome_RT821.Text, 0, 160);
			tabelaLinhaInteria.EscreveTituloValorLinha(2, "Endereço", this.TextBox_endereco_RT821.Text, 0, 90);
			string valor = string.Concat(new string[]
			{
				"RT",
				RT_geral.RT_821_BD.Equip.Valor.ToString(),
				"_",
				RT_geral.RT_821_BD.Versao.Valor.ToString(),
				string.Format("{0:D2}", RT_geral.RT_821_BD.Build.Valor),
				"  R",
				RT_geral.RT_821_BD.Release.Valor.ToString()
			});
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Modelo Simulado", this.ComboBox_modo_simulado_RT_821.Text, 0, 0);
			string valor2 = "iS800 (" + MyProject.Application.Info.Version.ToString() + ")";
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Configurador", valor2, 250, 0);
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Firmware", valor, 500, 430);
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Data", string.Concat(new string[]
			{
				DateTime.Today.Day.ToString(),
				"/",
				DateTime.Today.Month.ToString(),
				"/",
				DateTime.Today.Year.ToString()
			}), 850, 0);
			tabelaLinhaInteria.EscreveTituloValorLinha(4, "Arquivo", Path.GetFileName(RT_geral.RT_821_BD.filename), 0, 0);
			int nextLineAvailable = tabelaLinhaInteria.GetNextLineAvailable();
			TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 6, "Dados de Instalação", true);
			tabelaLinhaInteria2.EscreveTituloValorLinha(1, "Tipo de antena", this.CB_TipoAntena.Text, 0, 150);
			tabelaLinhaInteria2.EscreveTituloValorLinha(1, "Azimute", this.T_Azimute.Text + " °", 400, 500);
			tabelaLinhaInteria2.EscreveTituloValorLinha(2, "Polarização", this.CB_PolarizacaoAntena.Text, 0, 150);
			tabelaLinhaInteria2.EscreveTituloValorLinha(2, "Longitude", this.T_Longitude.Text, 400, 500);
			tabelaLinhaInteria2.EscreveTituloValorLinha(3, "Potência do Rádio", this.T_PotRadio.Text + " W", 0, 150);
			tabelaLinhaInteria2.EscreveTituloValorLinha(3, "Latidude", this.T_Latitude.Text, 400, 500);
			tabelaLinhaInteria2.EscreveTituloValorLinha(4, "Modelo do Rádio", this.CB_ModeloRadio.Text, 0, 150);
			tabelaLinhaInteria2.EscreveTituloValorLinha(4, "Altura", this.T_AlturaAntena.Text + " m", 400, 500);
			tabelaLinhaInteria2.EscreveTituloValorLinha(5, "Distância para Central", this.T_DistCentral.Text + " km", 0, 150);
			tabelaLinhaInteria2.EscreveTituloValorLinha(5, "Modelo da Fonte", this.T_ModeloFonte.Text, 400, 520);
			tabelaLinhaInteria2.EscreveTituloValorLinha(6, "Frequência do Rádio", this.T_FreqRadio.Text + " MHz", 0, 150);
			nextLineAvailable = tabelaLinhaInteria2.GetNextLineAvailable();
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 3, "Parâmetro de Comunicação", true);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(1, "Endereço do Mestre", this.NumericUpDown_end_mestre_RT821.Value.ToString(), 0, 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(2, "Endereço da Estação", this.NumericUpDown_end_est_RT821.Value.ToString(), 0, 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(3, "Tempo de PTT (ms)", this.NumericUpDown_temp_ptt_RT821.Value.ToString() + " ms", 0, 200);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 3, "Modo Oeração", true);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(1, "Modo Operação", this.ComboBox_Modo_Operacao.Text, 0, 180);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(2, "Intervalo de Transmissão", this.NumericUpDown_IntervaloTX.Value.ToString(), 0, 180);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(3, "BaudRate COM1", perifericos.ListaBaudRate[RT_geral.RT_821_BD.baudrate_com1.Indice].nome_impressao, 0, 170);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(3, "BaudRate COM2", perifericos.ListaBaudRate[RT_geral.RT_821_BD.baudrate_com2.Indice].nome_impressao, 300, 400);
			TabelaLinhaInteria tabelaLinhaInteria3 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda.GetNextLineAvailable(), 2, "Parâmetros de Controle", false);
			tabelaLinhaInteria3.EscreveTituloLinha(1, "\r\nCTRL", 0);
			tabelaLinhaInteria3.EscreveTituloLinha(1, "\r\nAcionamento", 60);
			tabelaLinhaInteria3.EscreveTituloLinha(1, "Retorno\r\nAcionamento", 200);
			tabelaLinhaInteria3.EscreveTituloLinha(1, "Seleção\r\nRemoto", 370);
			tabelaLinhaInteria3.EscreveTituloLinha(1, "Seleção\r\nReverso", 500);
			tabelaLinhaInteria3.EscreveTituloLinha(1, "Modo\r\nControle", 600);
			tabelaLinhaInteria3.EscreveTituloLinha(1, "Tempo\r\nPartida", 740);
			tabelaLinhaInteria3.EscreveTituloLinha(1, "Tempo\r\nParada", 900);
			tabelaLinhaInteria3.AdicionaLinha();
			tabelaLinhaInteria3.AdicionaLinha();
			tabelaLinhaInteria3.AdicionaLinha();
			int num = 0;
			checked
			{
				string valor3;
				do
				{
					valor3 = string.Format("0{0}", num + 1);
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, 10);
					num++;
				}
				while (num <= 2);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_821_BD.ctrl_acionamento[num].Valor)
					{
					case 21856:
						valor3 = "Desativa";
						break;
					case 21857:
						valor3 = "SD-01";
						break;
					case 21858:
						valor3 = "SD-02";
						break;
					case 21859:
						valor3 = "SD-03";
						break;
					case 21860:
						valor3 = "SD-04";
						break;
					case 21861:
						valor3 = "SD-05";
						break;
					case 21862:
						valor3 = "SD-06";
						break;
					case 21863:
						valor3 = "SD-07";
						break;
					case 21864:
						valor3 = "SD-08";
						break;
					case 21873:
						valor3 = "Periférico1";
						break;
					case 21874:
						valor3 = "Periférico2";
						break;
					case 21875:
						valor3 = "Periférico3";
						break;
					case 21876:
						valor3 = "Periférico4";
						break;
					case 21877:
						valor3 = "Periférico5";
						break;
					}
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, 65);
					num++;
				}
				while (num <= 2);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_821_BD.ctrl_ret_acionamento[num].Valor)
					{
					case 21856:
						valor3 = "Não usada";
						break;
					case 21857:
						valor3 = "ED-01";
						break;
					case 21858:
						valor3 = "ED-02";
						break;
					case 21859:
						valor3 = "ED-03";
						break;
					case 21860:
						valor3 = "ED-04";
						break;
					case 21861:
						valor3 = "ED-05";
						break;
					case 21862:
						valor3 = "ED-06";
						break;
					case 21863:
						valor3 = "ED-07";
						break;
					case 21864:
						valor3 = "ED-08";
						break;
					case 21873:
						valor3 = "Periférico1";
						break;
					case 21874:
						valor3 = "Periférico2";
						break;
					case 21875:
						valor3 = "Periférico3";
						break;
					case 21876:
						valor3 = "Periférico4";
						break;
					case 21877:
						valor3 = "Periférico5";
						break;
					}
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, 205);
					num++;
				}
				while (num <= 2);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_821_BD.ctrl_ED_selecao[num].Valor)
					{
					case 21856:
						valor3 = "S. Remoto";
						break;
					case 21857:
						valor3 = "ED-01";
						break;
					case 21858:
						valor3 = "ED-02";
						break;
					case 21859:
						valor3 = "ED-03";
						break;
					case 21860:
						valor3 = "ED-04";
						break;
					case 21861:
						valor3 = "ED-05";
						break;
					case 21862:
						valor3 = "ED-06";
						break;
					case 21863:
						valor3 = "ED-07";
						break;
					case 21864:
						valor3 = "ED-08";
						break;
					}
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, 375);
					num++;
				}
				while (num <= 2);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_821_BD.ctrl_reverso[num].Valor)
					{
					case 21856:
						valor3 = "Desab.";
						break;
					case 21857:
						valor3 = "Habilit.";
						break;
					}
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, 505);
					num++;
				}
				while (num <= 2);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_821_BD.ctrl_modo[num].Valor)
					{
					case 21856:
						valor3 = "Telecomando";
						break;
					case 21857:
						valor3 = "Automático";
						break;
					case 21858:
						valor3 = "Timer";
						break;
					}
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, 605);
					num++;
				}
				while (num <= 2);
				num = 0;
				do
				{
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, RT_geral.RT_821_BD.ctrl_tempo_max_partida[num].Valor.ToString(), 745);
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, RT_geral.RT_821_BD.ctrl_tempo_max_parada[num].Valor.ToString(), 905);
					num++;
				}
				while (num <= 2);
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria3.GetNextLineAvailable(), 2, "Acionamentos", true);
				valor3 = "???";
				switch (RT_geral.RT_821_BD.motores_simultaneos[0].Valor)
				{
				case 21856:
					valor3 = "Liberado";
					break;
				case 21857:
					valor3 = "1 Ctrl Acionado";
					break;
				case 21858:
					valor3 = "2 Ctrl Acionado";
					break;
				case 21859:
					valor3 = "3 Ctrl Acionado";
					break;
				}
				tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(1, "Motores Simultâneos", valor3, 0, 0);
				tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(2, "Tempo entre Acionamentos", RT_geral.RT_821_BD.motores_tempo_entre_acionamentos[0].Valor.ToString(), 2, 0);
				TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita2 = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria3.GetNextLineAvailable(), 5, "Escala EA", true);
				tabelaMeiaLinhaDireita2.EscreveTituloLinha(1, "EA", 0);
				tabelaMeiaLinhaDireita2.EscreveTituloLinha(1, "Range", 70);
				tabelaMeiaLinhaDireita2.EscreveTituloLinha(1, "Início", 200);
				tabelaMeiaLinhaDireita2.EscreveTituloLinha(1, "Fim", 340);
				num = 0;
				do
				{
					tabelaMeiaLinhaDireita2.EscreveTituloLinha(num + 2, string.Format("{0:D2}", num + 1), 0);
					tabelaMeiaLinhaDireita2.EscreveValorLinha(num + 2, RT_geral.RT_821_BD.EA_Range[num].Valor.ToString(), 80);
					tabelaMeiaLinhaDireita2.EscreveValorLinha(num + 2, RT_geral.RT_821_BD.EA_Inicio[num].Valor.ToString(), 210);
					tabelaMeiaLinhaDireita2.EscreveValorLinha(num + 2, RT_geral.RT_821_BD.EA_Fim[num].Valor.ToString(), 350);
					num++;
				}
				while (num <= 3);
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda3 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda2.GetNextLineAvailable(), 2, "Filtro EA", true);
				tabelaMeiaLinhaEsquerda3.EscreveTituloValorLinha(1, "Filtro Intervalo (ms)", this.NumericUpDown_intervalo_filtro_RT821.Value.ToString(), 0, 180);
				tabelaMeiaLinhaEsquerda3.EscreveTituloValorLinha(2, "Filtro Amostras", this.NumericUpDown_tamanho_filtro_RT821.Value.ToString(), 0, 180);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x003C0DF4 File Offset: 0x003BF1F4
		private bool DesenhaRelatorio(PrintPageEventArgs z)
		{
			checked
			{
				switch (this.pagina_impressao)
				{
				case 1:
					this.DesenhaRelatorioRT821Pagina1(z);
					this.pagina_impressao++;
					return true;
				case 2:
					this.DesenhaRelatorioRT821Pagina2(z);
					this.pagina_impressao++;
					return false;
				case 3:
					this.pagina_impressao++;
					return false;
				default:
					return false;
				}
			}
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x003C0E5C File Offset: 0x003BF25C
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.HasMorePages = this.DesenhaRelatorio(e);
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x003C0E6C File Offset: 0x003BF26C
		private void cb_modorepetidora_SelectedIndexChanged(object sender, EventArgs e)
		{
			object obj = NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null);
			bool flag;
			if (Operators.ConditionalCompareObjectEqual(obj, 0, false))
			{
				flag = false;
			}
			else if (Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(obj, 1, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(obj, 2, false))) ? true : false))
			{
				flag = true;
			}
			this.NumericUpDown_end_rep_RT821.Enabled = flag;
			this.NumericUpDown_num_est_rep_RT821.Enabled = flag;
			this.GroupBox_end_rep_RT821.Visible = flag;
			RT_geral.RT_821_BD.modo_repetidora.Valor = RT_geral.RT_821_BD.modo_repetidora.valores[Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null))];
			RT_geral.RT_821_BD.modo_repetidora.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null));
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x003C0F68 File Offset: 0x003BF368
		private void ComboBox_Modo_Operacao_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_BD.modo_operacao.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_821_BD.modo_operacao.Valor = RT_geral.RT_821_BD.modo_operacao.valores[RT_geral.RT_821_BD.modo_operacao.Indice];
			switch (RT_geral.RT_821_BD.modo_operacao.Indice)
			{
			case 0:
				this.NumericUpDown_IntervaloTX.Enabled = false;
				break;
			case 1:
			case 2:
				this.NumericUpDown_IntervaloTX.Enabled = true;
				break;
			}
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x003C1008 File Offset: 0x003BF408
		private void NumericUpDown_IntervaloTX_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_BD.intervalo_tx.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_BD.intervalo_tx, true);
			sender = numericUpDown;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x003C105C File Offset: 0x003BF45C
		private void cb_baudrate_com1_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_BD.baudrate_com1.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_821_BD.baudrate_com1.AtualizaValorPeloIndice();
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x003C1098 File Offset: 0x003BF498
		private void cb_baudrate_com2_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_BD.baudrate_com2.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_821_BD.baudrate_com2.AtualizaValorPeloIndice();
		}

		// Token: 0x04000CCE RID: 3278
		[AccessedThroughProperty("TabControl_821")]
		private TabControl _TabControl_821;

		// Token: 0x04000CCF RID: 3279
		[AccessedThroughProperty("TabPage_geral")]
		private TabPage _TabPage_geral;

		// Token: 0x04000CD0 RID: 3280
		[AccessedThroughProperty("TabPage_controles")]
		private TabPage _TabPage_controles;

		// Token: 0x04000CD1 RID: 3281
		[AccessedThroughProperty("TabPage_setpoints")]
		private TabPage _TabPage_setpoints;

		// Token: 0x04000CD2 RID: 3282
		[AccessedThroughProperty("TabPage_repetidora")]
		private TabPage _TabPage_repetidora;

		// Token: 0x04000CD3 RID: 3283
		[AccessedThroughProperty("TabPage_ED")]
		private TabPage _TabPage_ED;

		// Token: 0x04000CD4 RID: 3284
		[AccessedThroughProperty("TabPage_EA")]
		private TabPage _TabPage_EA;

		// Token: 0x04000CD5 RID: 3285
		[AccessedThroughProperty("GroupBox_descricao_RT821")]
		private GroupBox _GroupBox_descricao_RT821;

		// Token: 0x04000CD6 RID: 3286
		[AccessedThroughProperty("TextBox_comentarios_RT821")]
		private TextBox _TextBox_comentarios_RT821;

		// Token: 0x04000CD7 RID: 3287
		[AccessedThroughProperty("TextBox_endereco_RT821")]
		private TextBox _TextBox_endereco_RT821;

		// Token: 0x04000CD8 RID: 3288
		[AccessedThroughProperty("TextBox_nome_RT821")]
		private TextBox _TextBox_nome_RT821;

		// Token: 0x04000CD9 RID: 3289
		[AccessedThroughProperty("Label_comentarios_RT821")]
		private Label _Label_comentarios_RT821;

		// Token: 0x04000CDA RID: 3290
		[AccessedThroughProperty("Label_endereco_RT821")]
		private Label _Label_endereco_RT821;

		// Token: 0x04000CDB RID: 3291
		[AccessedThroughProperty("Label_nome_RT821")]
		private Label _Label_nome_RT821;

		// Token: 0x04000CDC RID: 3292
		[AccessedThroughProperty("GroupBox_informacoes_RT821")]
		private GroupBox _GroupBox_informacoes_RT821;

		// Token: 0x04000CDD RID: 3293
		[AccessedThroughProperty("GroupBox_modelo_simulado_RT821")]
		private GroupBox _GroupBox_modelo_simulado_RT821;

		// Token: 0x04000CDE RID: 3294
		[AccessedThroughProperty("ComboBox_modo_simulado_RT_821")]
		private ComboBox _ComboBox_modo_simulado_RT_821;

		// Token: 0x04000CDF RID: 3295
		[AccessedThroughProperty("GroupBox_comunicacao_RT821")]
		private GroupBox _GroupBox_comunicacao_RT821;

		// Token: 0x04000CE0 RID: 3296
		[AccessedThroughProperty("NumericUpDown_temp_ptt_RT821")]
		private NumericUpDown _NumericUpDown_temp_ptt_RT821;

		// Token: 0x04000CE1 RID: 3297
		[AccessedThroughProperty("NumericUpDown_end_mestre_RT821")]
		private NumericUpDown _NumericUpDown_end_mestre_RT821;

		// Token: 0x04000CE2 RID: 3298
		[AccessedThroughProperty("NumericUpDown_end_est_RT821")]
		private NumericUpDown _NumericUpDown_end_est_RT821;

		// Token: 0x04000CE3 RID: 3299
		[AccessedThroughProperty("Label_tempo_ptt_RT821")]
		private Label _Label_tempo_ptt_RT821;

		// Token: 0x04000CE4 RID: 3300
		[AccessedThroughProperty("Label_end_mestre_RT821")]
		private Label _Label_end_mestre_RT821;

		// Token: 0x04000CE5 RID: 3301
		[AccessedThroughProperty("Label_end_est_RT821")]
		private Label _Label_end_est_RT821;

		// Token: 0x04000CE6 RID: 3302
		[AccessedThroughProperty("GroupBox_controle_RT821")]
		private GroupBox _GroupBox_controle_RT821;

		// Token: 0x04000CE7 RID: 3303
		[AccessedThroughProperty("DataGridView_processo_RT821")]
		private DataGridView _DataGridView_processo_RT821;

		// Token: 0x04000CE8 RID: 3304
		[AccessedThroughProperty("GroupBox_parametros_EA_RT821")]
		private GroupBox _GroupBox_parametros_EA_RT821;

		// Token: 0x04000CE9 RID: 3305
		[AccessedThroughProperty("DataGridView_parametros_EA_RT821")]
		private DataGridView _DataGridView_parametros_EA_RT821;

		// Token: 0x04000CEA RID: 3306
		[AccessedThroughProperty("GroupBox_EA_RT821")]
		private GroupBox _GroupBox_EA_RT821;

		// Token: 0x04000CEB RID: 3307
		[AccessedThroughProperty("NumericUpDown_intervalo_filtro_RT821")]
		private NumericUpDown _NumericUpDown_intervalo_filtro_RT821;

		// Token: 0x04000CEC RID: 3308
		[AccessedThroughProperty("NumericUpDown_tamanho_filtro_RT821")]
		private NumericUpDown _NumericUpDown_tamanho_filtro_RT821;

		// Token: 0x04000CED RID: 3309
		[AccessedThroughProperty("Label_intervalo_filtro_RT821")]
		private Label _Label_intervalo_filtro_RT821;

		// Token: 0x04000CEE RID: 3310
		[AccessedThroughProperty("Label_tamanho_filtro_RT821")]
		private Label _Label_tamanho_filtro_RT821;

		// Token: 0x04000CEF RID: 3311
		[AccessedThroughProperty("GroupBox_ED_RT821")]
		private GroupBox _GroupBox_ED_RT821;

		// Token: 0x04000CF0 RID: 3312
		[AccessedThroughProperty("DataGridView_RT821_ED")]
		private DataGridView _DataGridView_RT821_ED;

		// Token: 0x04000CF1 RID: 3313
		[AccessedThroughProperty("GroupBox_setpoints_RT821")]
		private GroupBox _GroupBox_setpoints_RT821;

		// Token: 0x04000CF2 RID: 3314
		[AccessedThroughProperty("DataGridView_setpoints_RT821")]
		private DataGridView _DataGridView_setpoints_RT821;

		// Token: 0x04000CF3 RID: 3315
		[AccessedThroughProperty("GroupBox_end_rep_RT821")]
		private GroupBox _GroupBox_end_rep_RT821;

		// Token: 0x04000CF4 RID: 3316
		[AccessedThroughProperty("DataGridView_end_rep_RT821")]
		private DataGridView _DataGridView_end_rep_RT821;

		// Token: 0x04000CF5 RID: 3317
		[AccessedThroughProperty("GroupBox_parametros_repetidora_RT821")]
		private GroupBox _GroupBox_parametros_repetidora_RT821;

		// Token: 0x04000CF6 RID: 3318
		[AccessedThroughProperty("NumericUpDown_num_est_rep_RT821")]
		private NumericUpDown _NumericUpDown_num_est_rep_RT821;

		// Token: 0x04000CF7 RID: 3319
		[AccessedThroughProperty("NumericUpDown_end_rep_RT821")]
		private NumericUpDown _NumericUpDown_end_rep_RT821;

		// Token: 0x04000CF8 RID: 3320
		[AccessedThroughProperty("Label_num_est_rep_RT821")]
		private Label _Label_num_est_rep_RT821;

		// Token: 0x04000CF9 RID: 3321
		[AccessedThroughProperty("Label_end_rep_RT821")]
		private Label _Label_end_rep_RT821;

		// Token: 0x04000CFA RID: 3322
		[AccessedThroughProperty("TabPage_Display")]
		private TabPage _TabPage_Display;

		// Token: 0x04000CFB RID: 3323
		[AccessedThroughProperty("GroupBox_visor_RT_821")]
		private GroupBox _GroupBox_visor_RT_821;

		// Token: 0x04000CFC RID: 3324
		[AccessedThroughProperty("DataGridView_visor_RT_821")]
		private DataGridView _DataGridView_visor_RT_821;

		// Token: 0x04000CFD RID: 3325
		[AccessedThroughProperty("GroupBox_MotoresSimultaneos_RT_821")]
		private GroupBox _GroupBox_MotoresSimultaneos_RT_821;

		// Token: 0x04000CFE RID: 3326
		[AccessedThroughProperty("DataGridView_MotoresSimultaneos_RT_821")]
		private DataGridView _DataGridView_MotoresSimultaneos_RT_821;

		// Token: 0x04000CFF RID: 3327
		[AccessedThroughProperty("OpenFileDialog_RT821")]
		private OpenFileDialog _OpenFileDialog_RT821;

		// Token: 0x04000D00 RID: 3328
		[AccessedThroughProperty("SaveFileDialog_RT821")]
		private SaveFileDialog _SaveFileDialog_RT821;

		// Token: 0x04000D01 RID: 3329
		[AccessedThroughProperty("Timer_limpa_MSG_RT821")]
		private Timer _Timer_limpa_MSG_RT821;

		// Token: 0x04000D02 RID: 3330
		[AccessedThroughProperty("ToolStri_RT821")]
		private ToolStrip _ToolStri_RT821;

		// Token: 0x04000D03 RID: 3331
		[AccessedThroughProperty("ToolStripButton_RT821_novo")]
		private ToolStripButton _ToolStripButton_RT821_novo;

		// Token: 0x04000D04 RID: 3332
		[AccessedThroughProperty("ToolStripButton_RT821_Abrir")]
		private ToolStripButton _ToolStripButton_RT821_Abrir;

		// Token: 0x04000D05 RID: 3333
		[AccessedThroughProperty("ToolStripButton_RT821_Salvar")]
		private ToolStripButton _ToolStripButton_RT821_Salvar;

		// Token: 0x04000D06 RID: 3334
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x04000D07 RID: 3335
		[AccessedThroughProperty("ToolStripButton_RT821_Download")]
		private ToolStripButton _ToolStripButton_RT821_Download;

		// Token: 0x04000D08 RID: 3336
		[AccessedThroughProperty("ToolStripButton_RT821_Upload")]
		private ToolStripButton _ToolStripButton_RT821_Upload;

		// Token: 0x04000D09 RID: 3337
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x04000D0A RID: 3338
		[AccessedThroughProperty("ToolStripTextBox_RT821_Msg")]
		private ToolStripTextBox _ToolStripTextBox_RT821_Msg;

		// Token: 0x04000D0B RID: 3339
		[AccessedThroughProperty("ToolStripProgressBar_RT821")]
		private ToolStripProgressBar _ToolStripProgressBar_RT821;

		// Token: 0x04000D0C RID: 3340
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x04000D0D RID: 3341
		[AccessedThroughProperty("ToolStripButton_RT821_Imprimir")]
		private ToolStripButton _ToolStripButton_RT821_Imprimir;

		// Token: 0x04000D0E RID: 3342
		[AccessedThroughProperty("TabPage_DadosInstalacao")]
		private TabPage _TabPage_DadosInstalacao;

		// Token: 0x04000D0F RID: 3343
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000D10 RID: 3344
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x04000D11 RID: 3345
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x04000D12 RID: 3346
		[AccessedThroughProperty("T_ModeloFonte")]
		private TextBox _T_ModeloFonte;

		// Token: 0x04000D13 RID: 3347
		[AccessedThroughProperty("T_AlturaAntena")]
		private TextBox _T_AlturaAntena;

		// Token: 0x04000D14 RID: 3348
		[AccessedThroughProperty("T_Latitude")]
		private TextBox _T_Latitude;

		// Token: 0x04000D15 RID: 3349
		[AccessedThroughProperty("T_Longitude")]
		private TextBox _T_Longitude;

		// Token: 0x04000D16 RID: 3350
		[AccessedThroughProperty("T_Azimute")]
		private TextBox _T_Azimute;

		// Token: 0x04000D17 RID: 3351
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000D18 RID: 3352
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000D19 RID: 3353
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000D1A RID: 3354
		[AccessedThroughProperty("T_FreqRadio")]
		private TextBox _T_FreqRadio;

		// Token: 0x04000D1B RID: 3355
		[AccessedThroughProperty("T_DistCentral")]
		private TextBox _T_DistCentral;

		// Token: 0x04000D1C RID: 3356
		[AccessedThroughProperty("T_PotRadio")]
		private TextBox _T_PotRadio;

		// Token: 0x04000D1D RID: 3357
		[AccessedThroughProperty("CB_ModeloRadio")]
		private ComboBox _CB_ModeloRadio;

		// Token: 0x04000D1E RID: 3358
		[AccessedThroughProperty("CB_PolarizacaoAntena")]
		private ComboBox _CB_PolarizacaoAntena;

		// Token: 0x04000D1F RID: 3359
		[AccessedThroughProperty("CB_TipoAntena")]
		private ComboBox _CB_TipoAntena;

		// Token: 0x04000D20 RID: 3360
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000D21 RID: 3361
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000D22 RID: 3362
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000D23 RID: 3363
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000D24 RID: 3364
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000D25 RID: 3365
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000D26 RID: 3366
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000D27 RID: 3367
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000D28 RID: 3368
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000D29 RID: 3369
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000D2A RID: 3370
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x04000D2B RID: 3371
		[AccessedThroughProperty("PrintDocument1")]
		private PrintDocument _PrintDocument1;

		// Token: 0x04000D2C RID: 3372
		[AccessedThroughProperty("PrintPreviewDialog1")]
		private PrintPreviewDialog _PrintPreviewDialog1;

		// Token: 0x04000D2D RID: 3373
		[AccessedThroughProperty("ToolStripLabel1")]
		private ToolStripLabel _ToolStripLabel1;

		// Token: 0x04000D2E RID: 3374
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x04000D2F RID: 3375
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		// Token: 0x04000D30 RID: 3376
		[AccessedThroughProperty("TextBox_equipamento_RT821")]
		private TextBox _TextBox_equipamento_RT821;

		// Token: 0x04000D31 RID: 3377
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x04000D32 RID: 3378
		[AccessedThroughProperty("TextBox_release_RT821")]
		private TextBox _TextBox_release_RT821;

		// Token: 0x04000D33 RID: 3379
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x04000D34 RID: 3380
		[AccessedThroughProperty("TextBox_build_RT821")]
		private TextBox _TextBox_build_RT821;

		// Token: 0x04000D35 RID: 3381
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		// Token: 0x04000D36 RID: 3382
		[AccessedThroughProperty("TextBox_versao_RT821")]
		private TextBox _TextBox_versao_RT821;

		// Token: 0x04000D37 RID: 3383
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		// Token: 0x04000D38 RID: 3384
		[AccessedThroughProperty("tb_lixo1")]
		private TextBox _tb_lixo1;

		// Token: 0x04000D39 RID: 3385
		[AccessedThroughProperty("tb_lixo2")]
		private TextBox _tb_lixo2;

		// Token: 0x04000D3A RID: 3386
		[AccessedThroughProperty("tb_lixo3")]
		private TextBox _tb_lixo3;

		// Token: 0x04000D3B RID: 3387
		[AccessedThroughProperty("tb_lixo4")]
		private TextBox _tb_lixo4;

		// Token: 0x04000D3C RID: 3388
		[AccessedThroughProperty("tb_lixo5")]
		private TextBox _tb_lixo5;

		// Token: 0x04000D3D RID: 3389
		[AccessedThroughProperty("tb_lixo6")]
		private TextBox _tb_lixo6;

		// Token: 0x04000D3E RID: 3390
		[AccessedThroughProperty("tb_lixo7")]
		private TextBox _tb_lixo7;

		// Token: 0x04000D3F RID: 3391
		[AccessedThroughProperty("tb_lixo8")]
		private TextBox _tb_lixo8;

		// Token: 0x04000D40 RID: 3392
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000D41 RID: 3393
		[AccessedThroughProperty("cb_modorepetidora")]
		private ComboBox _cb_modorepetidora;

		// Token: 0x04000D42 RID: 3394
		[AccessedThroughProperty("GroupBox_ModoOperacao")]
		private GroupBox _GroupBox_ModoOperacao;

		// Token: 0x04000D43 RID: 3395
		[AccessedThroughProperty("ComboBox_Modo_Operacao")]
		private ComboBox _ComboBox_Modo_Operacao;

		// Token: 0x04000D44 RID: 3396
		[AccessedThroughProperty("NumericUpDown_IntervaloTX")]
		private NumericUpDown _NumericUpDown_IntervaloTX;

		// Token: 0x04000D45 RID: 3397
		[AccessedThroughProperty("lb_ModoOperacao")]
		private Label _lb_ModoOperacao;

		// Token: 0x04000D46 RID: 3398
		[AccessedThroughProperty("lb_IntervaloTX")]
		private Label _lb_IntervaloTX;

		// Token: 0x04000D47 RID: 3399
		[AccessedThroughProperty("cb_baudrate_com2")]
		private ComboBox _cb_baudrate_com2;

		// Token: 0x04000D48 RID: 3400
		[AccessedThroughProperty("cb_baudrate_com1")]
		private ComboBox _cb_baudrate_com1;

		// Token: 0x04000D49 RID: 3401
		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		// Token: 0x04000D4A RID: 3402
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x04000D4B RID: 3403
		private int pagina_impressao;
	}
}
