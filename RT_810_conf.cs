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
	// Token: 0x02000051 RID: 81
	[DesignerGenerated]
	public partial class RT_810_conf : Form
	{
		// Token: 0x06001222 RID: 4642 RVA: 0x0031C430 File Offset: 0x0031A830
		public RT_810_conf()
		{
			base.Load += new EventHandler(this.RT_810_conf_Load);
			base.Activated += new EventHandler(this.RT_810_conf_Activated);
			base.FormClosed += new FormClosedEventHandler(this.RT_810_conf_FormClosed);
			this.InitializeComponent();
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x00321AB8 File Offset: 0x0031FEB8
		// (set) Token: 0x06001226 RID: 4646 RVA: 0x00321ACC File Offset: 0x0031FECC
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

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x00321AD8 File Offset: 0x0031FED8
		// (set) Token: 0x06001228 RID: 4648 RVA: 0x00321AEC File Offset: 0x0031FEEC
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

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x00321B38 File Offset: 0x0031FF38
		// (set) Token: 0x0600122A RID: 4650 RVA: 0x00321B4C File Offset: 0x0031FF4C
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

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x00321B58 File Offset: 0x0031FF58
		// (set) Token: 0x0600122C RID: 4652 RVA: 0x00321B6C File Offset: 0x0031FF6C
		internal virtual GroupBox GroupBox_modelo_simulado
		{
			get
			{
				return this._GroupBox_modelo_simulado;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_modelo_simulado = value;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x00321B78 File Offset: 0x0031FF78
		// (set) Token: 0x0600122E RID: 4654 RVA: 0x00321B8C File Offset: 0x0031FF8C
		internal virtual GroupBox GroupBox_comunicacao
		{
			get
			{
				return this._GroupBox_comunicacao;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_comunicacao = value;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x00321B98 File Offset: 0x0031FF98
		// (set) Token: 0x06001230 RID: 4656 RVA: 0x00321BAC File Offset: 0x0031FFAC
		internal virtual NumericUpDown NumericUpDown_temp_ptt
		{
			get
			{
				return this._NumericUpDown_temp_ptt;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_temp_ptt_ValueChanged);
				if (this._NumericUpDown_temp_ptt != null)
				{
					this._NumericUpDown_temp_ptt.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_temp_ptt = value;
				if (this._NumericUpDown_temp_ptt != null)
				{
					this._NumericUpDown_temp_ptt.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x00321BF8 File Offset: 0x0031FFF8
		// (set) Token: 0x06001232 RID: 4658 RVA: 0x00321C0C File Offset: 0x0032000C
		internal virtual NumericUpDown NumericUpDown_end_mestre
		{
			get
			{
				return this._NumericUpDown_end_mestre;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_mestre_ValueChanged);
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

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x00321C58 File Offset: 0x00320058
		// (set) Token: 0x06001234 RID: 4660 RVA: 0x00321C6C File Offset: 0x0032006C
		internal virtual NumericUpDown NumericUpDown_end_est
		{
			get
			{
				return this._NumericUpDown_end_est;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_est_ValueChanged);
				if (this._NumericUpDown_end_est != null)
				{
					this._NumericUpDown_end_est.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_est = value;
				if (this._NumericUpDown_end_est != null)
				{
					this._NumericUpDown_end_est.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x00321CB8 File Offset: 0x003200B8
		// (set) Token: 0x06001236 RID: 4662 RVA: 0x00321CCC File Offset: 0x003200CC
		internal virtual Label Label_tempo_ptt
		{
			get
			{
				return this._Label_tempo_ptt;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_ptt = value;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x00321CD8 File Offset: 0x003200D8
		// (set) Token: 0x06001238 RID: 4664 RVA: 0x00321CEC File Offset: 0x003200EC
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

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x00321CF8 File Offset: 0x003200F8
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x00321D0C File Offset: 0x0032010C
		internal virtual Label Label_end_est
		{
			get
			{
				return this._Label_end_est;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_est = value;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x00321D18 File Offset: 0x00320118
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x00321D2C File Offset: 0x0032012C
		internal virtual TabPage TabPage_controle
		{
			get
			{
				return this._TabPage_controle;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_controle = value;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x00321D38 File Offset: 0x00320138
		// (set) Token: 0x0600123E RID: 4670 RVA: 0x00321D4C File Offset: 0x0032014C
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

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x00321D58 File Offset: 0x00320158
		// (set) Token: 0x06001240 RID: 4672 RVA: 0x00321D6C File Offset: 0x0032016C
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

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x00321D78 File Offset: 0x00320178
		// (set) Token: 0x06001242 RID: 4674 RVA: 0x00321D8C File Offset: 0x0032018C
		internal virtual GroupBox GroupBox_parametros_repetidora
		{
			get
			{
				return this._GroupBox_parametros_repetidora;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_parametros_repetidora = value;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x00321D98 File Offset: 0x00320198
		// (set) Token: 0x06001244 RID: 4676 RVA: 0x00321DAC File Offset: 0x003201AC
		internal virtual NumericUpDown NumericUpDown_num_est_rep
		{
			get
			{
				return this._NumericUpDown_num_est_rep;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_num_est_rep_ValueChanged);
				if (this._NumericUpDown_num_est_rep != null)
				{
					this._NumericUpDown_num_est_rep.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_num_est_rep = value;
				if (this._NumericUpDown_num_est_rep != null)
				{
					this._NumericUpDown_num_est_rep.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x00321DF8 File Offset: 0x003201F8
		// (set) Token: 0x06001246 RID: 4678 RVA: 0x00321E0C File Offset: 0x0032020C
		internal virtual NumericUpDown NumericUpDown_end_rep
		{
			get
			{
				return this._NumericUpDown_end_rep;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_rep_ValueChanged);
				if (this._NumericUpDown_end_rep != null)
				{
					this._NumericUpDown_end_rep.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_rep = value;
				if (this._NumericUpDown_end_rep != null)
				{
					this._NumericUpDown_end_rep.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x00321E58 File Offset: 0x00320258
		// (set) Token: 0x06001248 RID: 4680 RVA: 0x00321E6C File Offset: 0x0032026C
		internal virtual Label Label_num_est_rep
		{
			get
			{
				return this._Label_num_est_rep;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_num_est_rep = value;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x00321E78 File Offset: 0x00320278
		// (set) Token: 0x0600124A RID: 4682 RVA: 0x00321E8C File Offset: 0x0032028C
		internal virtual Label Label_end_rep
		{
			get
			{
				return this._Label_end_rep;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_rep = value;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x00321E98 File Offset: 0x00320298
		// (set) Token: 0x0600124C RID: 4684 RVA: 0x00321EAC File Offset: 0x003202AC
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

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x00321EB8 File Offset: 0x003202B8
		// (set) Token: 0x0600124E RID: 4686 RVA: 0x00321ECC File Offset: 0x003202CC
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

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x00321ED8 File Offset: 0x003202D8
		// (set) Token: 0x06001250 RID: 4688 RVA: 0x00321EEC File Offset: 0x003202EC
		internal virtual GroupBox GroupBox_EA
		{
			get
			{
				return this._GroupBox_EA;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_EA = value;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x00321EF8 File Offset: 0x003202F8
		// (set) Token: 0x06001252 RID: 4690 RVA: 0x00321F0C File Offset: 0x0032030C
		internal virtual NumericUpDown NumericUpDown_tamanho_filtro
		{
			get
			{
				return this._NumericUpDown_tamanho_filtro;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_tamanho_filtro_ValueChanged);
				if (this._NumericUpDown_tamanho_filtro != null)
				{
					this._NumericUpDown_tamanho_filtro.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_tamanho_filtro = value;
				if (this._NumericUpDown_tamanho_filtro != null)
				{
					this._NumericUpDown_tamanho_filtro.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x00321F58 File Offset: 0x00320358
		// (set) Token: 0x06001254 RID: 4692 RVA: 0x00321F6C File Offset: 0x0032036C
		internal virtual Label Label_intervalo_filtro
		{
			get
			{
				return this._Label_intervalo_filtro;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_intervalo_filtro = value;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x00321F78 File Offset: 0x00320378
		// (set) Token: 0x06001256 RID: 4694 RVA: 0x00321F8C File Offset: 0x0032038C
		internal virtual Label Label_tamanho_filtro
		{
			get
			{
				return this._Label_tamanho_filtro;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tamanho_filtro = value;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x00321F98 File Offset: 0x00320398
		// (set) Token: 0x06001258 RID: 4696 RVA: 0x00321FAC File Offset: 0x003203AC
		internal virtual GroupBox GroupBox_parametros_EA
		{
			get
			{
				return this._GroupBox_parametros_EA;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_parametros_EA = value;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x00321FB8 File Offset: 0x003203B8
		// (set) Token: 0x0600125A RID: 4698 RVA: 0x00321FCC File Offset: 0x003203CC
		internal virtual GroupBox GroupBox_end_rep
		{
			get
			{
				return this._GroupBox_end_rep;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_end_rep = value;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x00321FD8 File Offset: 0x003203D8
		// (set) Token: 0x0600125C RID: 4700 RVA: 0x00321FEC File Offset: 0x003203EC
		internal virtual DataGridView DataGridView_end_rep_RT_810
		{
			get
			{
				return this._DataGridView_end_rep_RT_810;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_end_rep_RT_810_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_end_rep_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_end_rep_CellValueChanged);
				if (this._DataGridView_end_rep_RT_810 != null)
				{
					this._DataGridView_end_rep_RT_810.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_end_rep_RT_810.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_end_rep_RT_810.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_end_rep_RT_810 = value;
				if (this._DataGridView_end_rep_RT_810 != null)
				{
					this._DataGridView_end_rep_RT_810.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_end_rep_RT_810.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_end_rep_RT_810.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x00322084 File Offset: 0x00320484
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x00322098 File Offset: 0x00320498
		internal virtual ComboBox ComboBox_modo_simulado_810
		{
			get
			{
				return this._ComboBox_modo_simulado_810;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_modo_simulado_810_SelectedIndexChanged);
				if (this._ComboBox_modo_simulado_810 != null)
				{
					this._ComboBox_modo_simulado_810.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_modo_simulado_810 = value;
				if (this._ComboBox_modo_simulado_810 != null)
				{
					this._ComboBox_modo_simulado_810.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x003220E4 File Offset: 0x003204E4
		// (set) Token: 0x06001260 RID: 4704 RVA: 0x003220F8 File Offset: 0x003204F8
		internal virtual DataGridViewTextBoxColumn Posicao_1_10
		{
			get
			{
				return this._Posicao_1_10;
			}
			[MethodImpl(32)]
			set
			{
				this._Posicao_1_10 = value;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x00322104 File Offset: 0x00320504
		// (set) Token: 0x06001262 RID: 4706 RVA: 0x00322118 File Offset: 0x00320518
		internal virtual DataGridViewTextBoxColumn End_01_10
		{
			get
			{
				return this._End_01_10;
			}
			[MethodImpl(32)]
			set
			{
				this._End_01_10 = value;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x00322124 File Offset: 0x00320524
		// (set) Token: 0x06001264 RID: 4708 RVA: 0x00322138 File Offset: 0x00320538
		internal virtual DataGridViewTextBoxColumn Posicao_11_20
		{
			get
			{
				return this._Posicao_11_20;
			}
			[MethodImpl(32)]
			set
			{
				this._Posicao_11_20 = value;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x00322144 File Offset: 0x00320544
		// (set) Token: 0x06001266 RID: 4710 RVA: 0x00322158 File Offset: 0x00320558
		internal virtual DataGridViewTextBoxColumn End_11_20
		{
			get
			{
				return this._End_11_20;
			}
			[MethodImpl(32)]
			set
			{
				this._End_11_20 = value;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x00322164 File Offset: 0x00320564
		// (set) Token: 0x06001268 RID: 4712 RVA: 0x00322178 File Offset: 0x00320578
		internal virtual DataGridViewTextBoxColumn Posicao_21_30
		{
			get
			{
				return this._Posicao_21_30;
			}
			[MethodImpl(32)]
			set
			{
				this._Posicao_21_30 = value;
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x00322184 File Offset: 0x00320584
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x00322198 File Offset: 0x00320598
		internal virtual DataGridViewTextBoxColumn End_21_30
		{
			get
			{
				return this._End_21_30;
			}
			[MethodImpl(32)]
			set
			{
				this._End_21_30 = value;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x003221A4 File Offset: 0x003205A4
		// (set) Token: 0x0600126C RID: 4716 RVA: 0x003221B8 File Offset: 0x003205B8
		internal virtual DataGridViewTextBoxColumn Posicao_31_40
		{
			get
			{
				return this._Posicao_31_40;
			}
			[MethodImpl(32)]
			set
			{
				this._Posicao_31_40 = value;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x003221C4 File Offset: 0x003205C4
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x003221D8 File Offset: 0x003205D8
		internal virtual DataGridViewTextBoxColumn End_31_40
		{
			get
			{
				return this._End_31_40;
			}
			[MethodImpl(32)]
			set
			{
				this._End_31_40 = value;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x003221E4 File Offset: 0x003205E4
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x003221F8 File Offset: 0x003205F8
		internal virtual DataGridViewTextBoxColumn Posicao_41_50
		{
			get
			{
				return this._Posicao_41_50;
			}
			[MethodImpl(32)]
			set
			{
				this._Posicao_41_50 = value;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x00322204 File Offset: 0x00320604
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x00322218 File Offset: 0x00320618
		internal virtual DataGridViewTextBoxColumn End_41_50
		{
			get
			{
				return this._End_41_50;
			}
			[MethodImpl(32)]
			set
			{
				this._End_41_50 = value;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x00322224 File Offset: 0x00320624
		// (set) Token: 0x06001274 RID: 4724 RVA: 0x00322238 File Offset: 0x00320638
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

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x00322284 File Offset: 0x00320684
		// (set) Token: 0x06001276 RID: 4726 RVA: 0x00322298 File Offset: 0x00320698
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

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x003222E4 File Offset: 0x003206E4
		// (set) Token: 0x06001278 RID: 4728 RVA: 0x003222F8 File Offset: 0x003206F8
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

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x00322344 File Offset: 0x00320744
		// (set) Token: 0x0600127A RID: 4730 RVA: 0x00322358 File Offset: 0x00320758
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

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x00322364 File Offset: 0x00320764
		// (set) Token: 0x0600127C RID: 4732 RVA: 0x00322378 File Offset: 0x00320778
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

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x003223C4 File Offset: 0x003207C4
		// (set) Token: 0x0600127E RID: 4734 RVA: 0x003223D8 File Offset: 0x003207D8
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

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x00322424 File Offset: 0x00320824
		// (set) Token: 0x06001280 RID: 4736 RVA: 0x00322438 File Offset: 0x00320838
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

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x00322444 File Offset: 0x00320844
		// (set) Token: 0x06001282 RID: 4738 RVA: 0x00322458 File Offset: 0x00320858
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

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x00322464 File Offset: 0x00320864
		// (set) Token: 0x06001284 RID: 4740 RVA: 0x00322478 File Offset: 0x00320878
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

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x00322484 File Offset: 0x00320884
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x00322498 File Offset: 0x00320898
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

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x003224E4 File Offset: 0x003208E4
		// (set) Token: 0x06001288 RID: 4744 RVA: 0x003224F8 File Offset: 0x003208F8
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

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x00322504 File Offset: 0x00320904
		// (set) Token: 0x0600128A RID: 4746 RVA: 0x00322518 File Offset: 0x00320918
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

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x00322524 File Offset: 0x00320924
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x00322538 File Offset: 0x00320938
		internal virtual NumericUpDown NumericUpDown_intervalo_filtro
		{
			get
			{
				return this._NumericUpDown_intervalo_filtro;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_intervalo_filtro_ValueChanged);
				if (this._NumericUpDown_intervalo_filtro != null)
				{
					this._NumericUpDown_intervalo_filtro.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_intervalo_filtro = value;
				if (this._NumericUpDown_intervalo_filtro != null)
				{
					this._NumericUpDown_intervalo_filtro.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x00322584 File Offset: 0x00320984
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x00322598 File Offset: 0x00320998
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

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x003225E4 File Offset: 0x003209E4
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x003225F8 File Offset: 0x003209F8
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

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x00322604 File Offset: 0x00320A04
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x00322618 File Offset: 0x00320A18
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

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x00322664 File Offset: 0x00320A64
		// (set) Token: 0x06001294 RID: 4756 RVA: 0x00322678 File Offset: 0x00320A78
		internal virtual NumericUpDown NumericUpDown_intervalo_tx
		{
			get
			{
				return this._NumericUpDown_intervalo_tx;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_intervalo_tx_ValueChanged);
				if (this._NumericUpDown_intervalo_tx != null)
				{
					this._NumericUpDown_intervalo_tx.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_intervalo_tx = value;
				if (this._NumericUpDown_intervalo_tx != null)
				{
					this._NumericUpDown_intervalo_tx.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x003226C4 File Offset: 0x00320AC4
		// (set) Token: 0x06001296 RID: 4758 RVA: 0x003226D8 File Offset: 0x00320AD8
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

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x003226E4 File Offset: 0x00320AE4
		// (set) Token: 0x06001298 RID: 4760 RVA: 0x003226F8 File Offset: 0x00320AF8
		internal virtual Label Label_intevalo_tx_pto_pto
		{
			get
			{
				return this._Label_intevalo_tx_pto_pto;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_intevalo_tx_pto_pto = value;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x00322704 File Offset: 0x00320B04
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x00322718 File Offset: 0x00320B18
		internal virtual GroupBox GroupBox_sistema_leitura
		{
			get
			{
				return this._GroupBox_sistema_leitura;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GroupBox_sistema_leitura_Enter);
				if (this._GroupBox_sistema_leitura != null)
				{
					this._GroupBox_sistema_leitura.Enter -= eventHandler;
				}
				this._GroupBox_sistema_leitura = value;
				if (this._GroupBox_sistema_leitura != null)
				{
					this._GroupBox_sistema_leitura.Enter += eventHandler;
				}
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x00322764 File Offset: 0x00320B64
		// (set) Token: 0x0600129C RID: 4764 RVA: 0x00322778 File Offset: 0x00320B78
		internal virtual CheckBox CheckBox_Hab_eletrodos
		{
			get
			{
				return this._CheckBox_Hab_eletrodos;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_hab_eletrodos_CheckedChanged);
				if (this._CheckBox_Hab_eletrodos != null)
				{
					this._CheckBox_Hab_eletrodos.CheckedChanged -= eventHandler;
				}
				this._CheckBox_Hab_eletrodos = value;
				if (this._CheckBox_Hab_eletrodos != null)
				{
					this._CheckBox_Hab_eletrodos.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x003227C4 File Offset: 0x00320BC4
		// (set) Token: 0x0600129E RID: 4766 RVA: 0x003227D8 File Offset: 0x00320BD8
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

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x003227E4 File Offset: 0x00320BE4
		// (set) Token: 0x060012A0 RID: 4768 RVA: 0x003227F8 File Offset: 0x00320BF8
		internal virtual GroupBox GroupBox_controle_810
		{
			get
			{
				return this._GroupBox_controle_810;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_controle_810 = value;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x00322804 File Offset: 0x00320C04
		// (set) Token: 0x060012A2 RID: 4770 RVA: 0x00322818 File Offset: 0x00320C18
		internal virtual DataGridView DataGridView_processo_810_P1
		{
			get
			{
				return this._DataGridView_processo_810_P1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_processo_810_P1_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_processo_810_P1_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_processo_810_P1_CellValueChanged);
				if (this._DataGridView_processo_810_P1 != null)
				{
					this._DataGridView_processo_810_P1.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_processo_810_P1.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_processo_810_P1.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_processo_810_P1 = value;
				if (this._DataGridView_processo_810_P1 != null)
				{
					this._DataGridView_processo_810_P1.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_processo_810_P1.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_processo_810_P1.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x003228B0 File Offset: 0x00320CB0
		// (set) Token: 0x060012A4 RID: 4772 RVA: 0x003228C4 File Offset: 0x00320CC4
		internal virtual GroupBox GroupBox_setpoints_810
		{
			get
			{
				return this._GroupBox_setpoints_810;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_setpoints_810 = value;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x003228D0 File Offset: 0x00320CD0
		// (set) Token: 0x060012A6 RID: 4774 RVA: 0x003228E4 File Offset: 0x00320CE4
		internal virtual DataGridView DataGridView_setpoints_810
		{
			get
			{
				return this._DataGridView_setpoints_810;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_setpoints_810_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_setpoints_810_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_setpoints_810_CellValueChanged);
				if (this._DataGridView_setpoints_810 != null)
				{
					this._DataGridView_setpoints_810.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_setpoints_810.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_setpoints_810.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_setpoints_810 = value;
				if (this._DataGridView_setpoints_810 != null)
				{
					this._DataGridView_setpoints_810.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_setpoints_810.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_setpoints_810.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x0032297C File Offset: 0x00320D7C
		// (set) Token: 0x060012A8 RID: 4776 RVA: 0x00322990 File Offset: 0x00320D90
		internal virtual GroupBox GroupBox_descricao_RT810
		{
			get
			{
				return this._GroupBox_descricao_RT810;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GroupBox_descricao_RT810_Enter);
				if (this._GroupBox_descricao_RT810 != null)
				{
					this._GroupBox_descricao_RT810.Enter -= eventHandler;
				}
				this._GroupBox_descricao_RT810 = value;
				if (this._GroupBox_descricao_RT810 != null)
				{
					this._GroupBox_descricao_RT810.Enter += eventHandler;
				}
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x003229DC File Offset: 0x00320DDC
		// (set) Token: 0x060012AA RID: 4778 RVA: 0x003229F0 File Offset: 0x00320DF0
		internal virtual Label Label_endereco
		{
			get
			{
				return this._Label_endereco;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_endereco = value;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x003229FC File Offset: 0x00320DFC
		// (set) Token: 0x060012AC RID: 4780 RVA: 0x00322A10 File Offset: 0x00320E10
		internal virtual Label Label_nome
		{
			get
			{
				return this._Label_nome;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nome = value;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x00322A1C File Offset: 0x00320E1C
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x00322A30 File Offset: 0x00320E30
		internal virtual TextBox TextBox_comentarios_RT810
		{
			get
			{
				return this._TextBox_comentarios_RT810;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox_comentarios_RT810_TextChanged);
				if (this._TextBox_comentarios_RT810 != null)
				{
					this._TextBox_comentarios_RT810.TextChanged -= eventHandler;
				}
				this._TextBox_comentarios_RT810 = value;
				if (this._TextBox_comentarios_RT810 != null)
				{
					this._TextBox_comentarios_RT810.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x00322A7C File Offset: 0x00320E7C
		// (set) Token: 0x060012B0 RID: 4784 RVA: 0x00322A90 File Offset: 0x00320E90
		internal virtual TextBox TextBox_endereco_RT810
		{
			get
			{
				return this._TextBox_endereco_RT810;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_endereco_RT810 = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x00322A9C File Offset: 0x00320E9C
		// (set) Token: 0x060012B2 RID: 4786 RVA: 0x00322AB0 File Offset: 0x00320EB0
		internal virtual TextBox TextBox_nome_RT810
		{
			get
			{
				return this._TextBox_nome_RT810;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_nome_RT810 = value;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x00322ABC File Offset: 0x00320EBC
		// (set) Token: 0x060012B4 RID: 4788 RVA: 0x00322AD0 File Offset: 0x00320ED0
		internal virtual Label Label_comentarios
		{
			get
			{
				return this._Label_comentarios;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_comentarios = value;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x00322ADC File Offset: 0x00320EDC
		// (set) Token: 0x060012B6 RID: 4790 RVA: 0x00322AF0 File Offset: 0x00320EF0
		internal virtual DataGridView DataGridView_RT810_ED
		{
			get
			{
				return this._DataGridView_RT810_ED;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_RT810_ED_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_RT810_ED_CellValueChanged);
				if (this._DataGridView_RT810_ED != null)
				{
					this._DataGridView_RT810_ED.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_RT810_ED.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_RT810_ED = value;
				if (this._DataGridView_RT810_ED != null)
				{
					this._DataGridView_RT810_ED.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_RT810_ED.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00322B60 File Offset: 0x00320F60
		// (set) Token: 0x060012B8 RID: 4792 RVA: 0x00322B74 File Offset: 0x00320F74
		internal virtual DataGridView DataGridView_parametros_EA_810
		{
			get
			{
				return this._DataGridView_parametros_EA_810;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_parametros_EA_810_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_parametros_EA_810_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_parametros_EA_810_CellValueChanged);
				if (this._DataGridView_parametros_EA_810 != null)
				{
					this._DataGridView_parametros_EA_810.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_parametros_EA_810.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_parametros_EA_810.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_parametros_EA_810 = value;
				if (this._DataGridView_parametros_EA_810 != null)
				{
					this._DataGridView_parametros_EA_810.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_parametros_EA_810.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_parametros_EA_810.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x00322C0C File Offset: 0x0032100C
		// (set) Token: 0x060012BA RID: 4794 RVA: 0x00322C20 File Offset: 0x00321020
		internal virtual ComboBox ComboBox_modo_repeticao_RT_810
		{
			get
			{
				return this._ComboBox_modo_repeticao_RT_810;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_modo_repeticao_RT_810_SelectedIndexChanged);
				if (this._ComboBox_modo_repeticao_RT_810 != null)
				{
					this._ComboBox_modo_repeticao_RT_810.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_modo_repeticao_RT_810 = value;
				if (this._ComboBox_modo_repeticao_RT_810 != null)
				{
					this._ComboBox_modo_repeticao_RT_810.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x00322C6C File Offset: 0x0032106C
		// (set) Token: 0x060012BC RID: 4796 RVA: 0x00322C80 File Offset: 0x00321080
		internal virtual Label Label_modo_rep_RT_810
		{
			get
			{
				return this._Label_modo_rep_RT_810;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_modo_rep_RT_810 = value;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x00322C8C File Offset: 0x0032108C
		// (set) Token: 0x060012BE RID: 4798 RVA: 0x00322CA0 File Offset: 0x003210A0
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

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x00322CEC File Offset: 0x003210EC
		// (set) Token: 0x060012C0 RID: 4800 RVA: 0x00322D00 File Offset: 0x00321100
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

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x00322D0C File Offset: 0x0032110C
		// (set) Token: 0x060012C2 RID: 4802 RVA: 0x00322D20 File Offset: 0x00321120
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

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x00322DB8 File Offset: 0x003211B8
		// (set) Token: 0x060012C4 RID: 4804 RVA: 0x00322DCC File Offset: 0x003211CC
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

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x00322DD8 File Offset: 0x003211D8
		// (set) Token: 0x060012C6 RID: 4806 RVA: 0x00322DEC File Offset: 0x003211EC
		internal virtual TabPage TabPage_dadosinstalacao
		{
			get
			{
				return this._TabPage_dadosinstalacao;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_dadosinstalacao = value;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00322DF8 File Offset: 0x003211F8
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x00322E0C File Offset: 0x0032120C
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

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00322E18 File Offset: 0x00321218
		// (set) Token: 0x060012CA RID: 4810 RVA: 0x00322E2C File Offset: 0x0032122C
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

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x00322E38 File Offset: 0x00321238
		// (set) Token: 0x060012CC RID: 4812 RVA: 0x00322E4C File Offset: 0x0032124C
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

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x00322E58 File Offset: 0x00321258
		// (set) Token: 0x060012CE RID: 4814 RVA: 0x00322E6C File Offset: 0x0032126C
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

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x00322E78 File Offset: 0x00321278
		// (set) Token: 0x060012D0 RID: 4816 RVA: 0x00322E8C File Offset: 0x0032128C
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

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x00322E98 File Offset: 0x00321298
		// (set) Token: 0x060012D2 RID: 4818 RVA: 0x00322EAC File Offset: 0x003212AC
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

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x00322EB8 File Offset: 0x003212B8
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x00322ECC File Offset: 0x003212CC
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

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x00322ED8 File Offset: 0x003212D8
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x00322EEC File Offset: 0x003212EC
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

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x00322EF8 File Offset: 0x003212F8
		// (set) Token: 0x060012D8 RID: 4824 RVA: 0x00322F0C File Offset: 0x0032130C
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

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x00322F18 File Offset: 0x00321318
		// (set) Token: 0x060012DA RID: 4826 RVA: 0x00322F2C File Offset: 0x0032132C
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

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x00322F38 File Offset: 0x00321338
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x00322F4C File Offset: 0x0032134C
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

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x00322F58 File Offset: 0x00321358
		// (set) Token: 0x060012DE RID: 4830 RVA: 0x00322F6C File Offset: 0x0032136C
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

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x00322F78 File Offset: 0x00321378
		// (set) Token: 0x060012E0 RID: 4832 RVA: 0x00322F8C File Offset: 0x0032138C
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

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x00322F98 File Offset: 0x00321398
		// (set) Token: 0x060012E2 RID: 4834 RVA: 0x00322FAC File Offset: 0x003213AC
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

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x00322FB8 File Offset: 0x003213B8
		// (set) Token: 0x060012E4 RID: 4836 RVA: 0x00322FCC File Offset: 0x003213CC
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

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x00322FD8 File Offset: 0x003213D8
		// (set) Token: 0x060012E6 RID: 4838 RVA: 0x00322FEC File Offset: 0x003213EC
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

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x00322FF8 File Offset: 0x003213F8
		// (set) Token: 0x060012E8 RID: 4840 RVA: 0x0032300C File Offset: 0x0032140C
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

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x00323018 File Offset: 0x00321418
		// (set) Token: 0x060012EA RID: 4842 RVA: 0x0032302C File Offset: 0x0032142C
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

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x00323038 File Offset: 0x00321438
		// (set) Token: 0x060012EC RID: 4844 RVA: 0x0032304C File Offset: 0x0032144C
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

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00323058 File Offset: 0x00321458
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x0032306C File Offset: 0x0032146C
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

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x00323078 File Offset: 0x00321478
		// (set) Token: 0x060012F0 RID: 4848 RVA: 0x0032308C File Offset: 0x0032148C
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

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00323098 File Offset: 0x00321498
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x003230AC File Offset: 0x003214AC
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

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x003230B8 File Offset: 0x003214B8
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x003230CC File Offset: 0x003214CC
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

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x003230D8 File Offset: 0x003214D8
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x003230EC File Offset: 0x003214EC
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

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x003230F8 File Offset: 0x003214F8
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x0032310C File Offset: 0x0032150C
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

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00323118 File Offset: 0x00321518
		// (set) Token: 0x060012FA RID: 4858 RVA: 0x0032312C File Offset: 0x0032152C
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

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x00323138 File Offset: 0x00321538
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x0032314C File Offset: 0x0032154C
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

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x00323158 File Offset: 0x00321558
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x0032316C File Offset: 0x0032156C
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

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00323178 File Offset: 0x00321578
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x0032318C File Offset: 0x0032158C
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

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x00323198 File Offset: 0x00321598
		// (set) Token: 0x06001302 RID: 4866 RVA: 0x003231AC File Offset: 0x003215AC
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

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x003231B8 File Offset: 0x003215B8
		// (set) Token: 0x06001304 RID: 4868 RVA: 0x003231CC File Offset: 0x003215CC
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

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x003231D8 File Offset: 0x003215D8
		// (set) Token: 0x06001306 RID: 4870 RVA: 0x003231EC File Offset: 0x003215EC
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

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x003231F8 File Offset: 0x003215F8
		// (set) Token: 0x06001308 RID: 4872 RVA: 0x0032320C File Offset: 0x0032160C
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

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x00323258 File Offset: 0x00321658
		// (set) Token: 0x0600130A RID: 4874 RVA: 0x0032326C File Offset: 0x0032166C
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

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x00323278 File Offset: 0x00321678
		// (set) Token: 0x0600130C RID: 4876 RVA: 0x0032328C File Offset: 0x0032168C
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

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600130D RID: 4877 RVA: 0x00323298 File Offset: 0x00321698
		// (set) Token: 0x0600130E RID: 4878 RVA: 0x003232AC File Offset: 0x003216AC
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

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x003232B8 File Offset: 0x003216B8
		// (set) Token: 0x06001310 RID: 4880 RVA: 0x003232CC File Offset: 0x003216CC
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

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x003232D8 File Offset: 0x003216D8
		// (set) Token: 0x06001312 RID: 4882 RVA: 0x003232EC File Offset: 0x003216EC
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

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001313 RID: 4883 RVA: 0x003232F8 File Offset: 0x003216F8
		// (set) Token: 0x06001314 RID: 4884 RVA: 0x0032330C File Offset: 0x0032170C
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

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x00323318 File Offset: 0x00321718
		// (set) Token: 0x06001316 RID: 4886 RVA: 0x0032332C File Offset: 0x0032172C
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

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x00323338 File Offset: 0x00321738
		// (set) Token: 0x06001318 RID: 4888 RVA: 0x0032334C File Offset: 0x0032174C
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

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x00323358 File Offset: 0x00321758
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x0032336C File Offset: 0x0032176C
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

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x00323378 File Offset: 0x00321778
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x0032338C File Offset: 0x0032178C
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

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x00323398 File Offset: 0x00321798
		// (set) Token: 0x0600131E RID: 4894 RVA: 0x003233AC File Offset: 0x003217AC
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

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x003233B8 File Offset: 0x003217B8
		// (set) Token: 0x06001320 RID: 4896 RVA: 0x003233CC File Offset: 0x003217CC
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

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001321 RID: 4897 RVA: 0x003233D8 File Offset: 0x003217D8
		// (set) Token: 0x06001322 RID: 4898 RVA: 0x003233EC File Offset: 0x003217EC
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

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x003233F8 File Offset: 0x003217F8
		// (set) Token: 0x06001324 RID: 4900 RVA: 0x0032340C File Offset: 0x0032180C
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

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x00323418 File Offset: 0x00321818
		// (set) Token: 0x06001326 RID: 4902 RVA: 0x0032342C File Offset: 0x0032182C
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

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001327 RID: 4903 RVA: 0x00323478 File Offset: 0x00321878
		// (set) Token: 0x06001328 RID: 4904 RVA: 0x0032348C File Offset: 0x0032188C
		internal virtual ComboBox ComboBox_baudrate_COM1_810
		{
			get
			{
				return this._ComboBox_baudrate_COM1_810;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_baudrate_COM1_810_SelectedIndexChanged);
				if (this._ComboBox_baudrate_COM1_810 != null)
				{
					this._ComboBox_baudrate_COM1_810.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_baudrate_COM1_810 = value;
				if (this._ComboBox_baudrate_COM1_810 != null)
				{
					this._ComboBox_baudrate_COM1_810.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x003234D8 File Offset: 0x003218D8
		// (set) Token: 0x0600132A RID: 4906 RVA: 0x003234EC File Offset: 0x003218EC
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

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x003234F8 File Offset: 0x003218F8
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x0032350C File Offset: 0x0032190C
		internal virtual ComboBox ComboBox_baudrate_COM2_810
		{
			get
			{
				return this._ComboBox_baudrate_COM2_810;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_baudrate_COM2_810_SelectedIndexChanged);
				if (this._ComboBox_baudrate_COM2_810 != null)
				{
					this._ComboBox_baudrate_COM2_810.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_baudrate_COM2_810 = value;
				if (this._ComboBox_baudrate_COM2_810 != null)
				{
					this._ComboBox_baudrate_COM2_810.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x00323558 File Offset: 0x00321958
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x0032356C File Offset: 0x0032196C
		internal virtual Label Label_baudrate_COM2_820
		{
			get
			{
				return this._Label_baudrate_COM2_820;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_baudrate_COM2_820 = value;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x00323578 File Offset: 0x00321978
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x0032358C File Offset: 0x0032198C
		internal virtual Label Label73
		{
			get
			{
				return this._Label73;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label73_Click);
				if (this._Label73 != null)
				{
					this._Label73.Click -= eventHandler;
				}
				this._Label73 = value;
				if (this._Label73 != null)
				{
					this._Label73.Click += eventHandler;
				}
			}
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x003235D8 File Offset: 0x003219D8
		private void AtivaEfeitoOnChangeValue()
		{
			this.ToolStri_RT_810.Enabled = false;
			this.tb_lixo1.Focus();
			this.tb_lixo2.Focus();
			this.tb_lixo3.Focus();
			this.tb_lixo4.Focus();
			this.tb_lixo5.Focus();
			this.tb_lixo6.Focus();
			this.tb_lixo7.Focus();
			this.ToolStri_RT_810.Enabled = true;
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00323654 File Offset: 0x00321A54
		public void Cria_ListaBaudRate()
		{
			perifericos.ListaBaudRate.Clear();
			perifericos.ListaBaudRate.Add(new perifericos.Valores_ComboBox("1200", "1200", 21856, false));
			perifericos.ListaBaudRate.Add(new perifericos.Valores_ComboBox("9600", "9600", 21857, true));
			perifericos.ListaBaudRate.Add(new perifericos.Valores_ComboBox("19200", "19200", 21858, false));
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x003236C8 File Offset: 0x00321AC8
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

		// Token: 0x06001334 RID: 4916 RVA: 0x00323734 File Offset: 0x00321B34
		private void RT_810_conf_Load(object sender, EventArgs e)
		{
			RT_geral.Lmte_Init_ok = false;
			RT_geral.RT_810_BD.Modelo.valores = new int[4];
			RT_geral.RT_810_BD.Modelo.itens = new string[4];
			this.Cria_ListaBaudRate();
			checked
			{
				RT_geral.RT_810_BD.BaudRateCOM1.valores = new int[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_810_BD.BaudRateCOM1.itens = new string[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_810_BD.BaudRateCOM2.valores = new int[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_810_BD.BaudRateCOM2.itens = new string[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_810_BD.ctrl_acionamento = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_810_BD.ctrl_ret_acionamento = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_810_BD.ctrl_ED_selecao = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_810_BD.ctrl_reverso = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_810_BD.ctrl_modo = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_810_BD.ctrl_tempo_max_partida = new RT_geral.Integer_ictel[2];
				RT_geral.RT_810_BD.ctrl_tempo_max_parada = new RT_geral.Integer_ictel[2];
				RT_geral.RT_810_BD.EA_Range = new RT_geral.Integer_ictel[5];
				RT_geral.RT_810_BD.EA_Inicio = new RT_geral.Integer_ictel[5];
				RT_geral.RT_810_BD.EA_Fim = new RT_geral.Integer_ictel[5];
				RT_geral.RT_810_BD.config_ED = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto = new RT_geral.Integer_ictel[3];
				RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo = new RT_geral.Integer_ictel[3];
				RT_geral.RT_810_BD.Setpoints_ctrl_variavel = new RT_geral.Combo_ictel_ctrl[3];
				RT_geral.RT_810_BD.Repetidoras = new RT_geral.Integer_ictel[51];
				RT_geral.RT_810_BD.Modo_de_operacao.valores = new int[5];
				RT_geral.RT_810_BD.Modo_de_operacao.itens = new string[5];
				RT_geral.RT_810_BD.Hab_repetidora.valores = new int[5];
				RT_geral.RT_810_BD.Hab_repetidora.itens = new string[5];
				this.Inicializa_DadosEStruturaRT810_Padrao();
				RT_geral.Lmte_Init_ok = true;
				this.InicializaEstrutura_DataGridView_Processos_RT_810();
				this.GeraDataGridView_Processos_RT_810();
				this.InicializaEstrutura_DataGridView_EA_RT_810();
				this.GeraDataGridView_EA_RT_810();
				this.InicializaEstrutura_DataGridView_repetidora_RT_810();
				this.GeraDataGridView_Repedidora_RT_810();
				this.InicializaEstrutura_DataGridView_Setpoints_RT_810();
				this.GeraDataGridView_Setpoints_RT_810();
				this.InicializaEstrutura_DataGridView_ED_RT_810();
				this.GeraDataGridView_ED_RT_810();
				ComboBox comboBox = this.ComboBox_modo_simulado_810;
				Linha_RT.CarregaCombo(ref comboBox, RT_geral.RT_810_BD.Modelo);
				this.ComboBox_modo_simulado_810 = comboBox;
				comboBox = this.ComboBox_Modo_Operacao;
				Linha_RT.CarregaCombo(ref comboBox, RT_geral.RT_810_BD.Modo_de_operacao);
				this.ComboBox_Modo_Operacao = comboBox;
				comboBox = this.ComboBox_modo_repeticao_RT_810;
				Linha_RT.CarregaCombo(ref comboBox, RT_geral.RT_810_BD.Hab_repetidora);
				this.ComboBox_modo_repeticao_RT_810 = comboBox;
				comboBox = this.ComboBox_baudrate_COM2_810;
				this.CarregaComboBoxBaudRate(ref comboBox);
				this.ComboBox_baudrate_COM2_810 = comboBox;
				comboBox = this.ComboBox_baudrate_COM1_810;
				this.CarregaComboBoxBaudRate(ref comboBox);
				this.ComboBox_baudrate_COM1_810 = comboBox;
				this.Inicializa_DadosEStruturaRT810_Default();
				Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
				this.TabPage_geral.BackColor = Color.FromKnownColor(8);
				this.TabPage_geral.ForeColor = Color.FromKnownColor(10);
				this.TabPage_controle.BackColor = Color.FromKnownColor(8);
				this.TabPage_controle.ForeColor = Color.FromKnownColor(10);
				this.TabPage_EA.BackColor = Color.FromKnownColor(8);
				this.TabPage_EA.ForeColor = Color.FromKnownColor(10);
				this.TabPage_ED.BackColor = Color.FromKnownColor(8);
				this.TabPage_ED.ForeColor = Color.FromKnownColor(10);
				this.TabPage_setpoints.BackColor = Color.FromKnownColor(8);
				this.TabPage_setpoints.ForeColor = Color.FromKnownColor(10);
				this.TabPage_repetidora.BackColor = Color.FromKnownColor(8);
				this.TabPage_repetidora.ForeColor = Color.FromKnownColor(10);
				this.TabPage_dadosinstalacao.BackColor = Color.FromKnownColor(8);
				this.TabPage_dadosinstalacao.ForeColor = Color.FromKnownColor(10);
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
					this.ToolStripLabel_ID.Font = font2;
				}
				else
				{
					MessageBox.Show("Removido fonte Ictel Extendida Italic da pasta da aplicação!");
				}
				this.Atualiza_TelaRT810();
				this.ToolStripLabel_ID.Text = RT_geral.MontaNomePlacaPeloFabricante(RT_geral.RT_810_BD.Equip.Valor, RT_geral.RT_810_BD.Versao.Valor);
				RT_geral.Lmte_Init_ok = true;
			}
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00323C00 File Offset: 0x00322000
		private void RT_810_conf_Activated(object sender, EventArgs e)
		{
			Geral.Equipamento_selecionado = 810;
			Geral.Equipamento_versao = 3;
			Geral.Equipamento_build = 0;
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00323C18 File Offset: 0x00322018
		private void GeraDataGridView_Processos_RT_810()
		{
			this.DataGridView_processo_810_P1.Columns.Clear();
			this.DataGridView_processo_810_P1.CellBorderStyle = 1;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_810_DataGrigViewProcessosColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_810_DataGrigViewProcessosColunas);
						this.DataGridView_processo_810_P1.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_810_DataGrigViewProcessosColunas);
						this.DataGridView_processo_810_P1.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 6);
				this.DataGridView_processo_810_P1.RowCount = 1;
				this.DataGridView_processo_810_P1.RowHeadersWidth = 70;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_processo_810_P1.Rows)
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

		// Token: 0x06001337 RID: 4919 RVA: 0x00323D4C File Offset: 0x0032214C
		private void InicializaEstrutura_DataGridView_Processos_RT_810()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_810_DataGrigViewProcessosColunas[num].LinhasMenu = new string[11];
					RT_geral.RT_810_DataGrigViewProcessosColunas[num].LinhasValor = new int[11];
					num++;
				}
				while (num <= 6);
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].TagColuna = "Acionamento";
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].TagColuna = "Retorno";
				RT_geral.RT_810_DataGrigViewProcessosColunas[2].TagColuna = "Remoto";
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].TagColuna = "Reverso";
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].TagColuna = "Modo";
				RT_geral.RT_810_DataGrigViewProcessosColunas[5].TagColuna = "Tempo Partida (s)";
				RT_geral.RT_810_DataGrigViewProcessosColunas[6].TagColuna = "Tempo Parada (s)";
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].NomeColuna = "SDAciona";
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].NomeColuna = "EDRetAci";
				RT_geral.RT_810_DataGrigViewProcessosColunas[2].NomeColuna = "EDRemoto";
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].NomeColuna = "Reverso";
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].NomeColuna = "ModoCtrl";
				RT_geral.RT_810_DataGrigViewProcessosColunas[5].NomeColuna = "TpMaxPart";
				RT_geral.RT_810_DataGrigViewProcessosColunas[6].NomeColuna = "TpMaxParada";
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].LarguraColuna = 100;
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].LarguraColuna = 100;
				RT_geral.RT_810_DataGrigViewProcessosColunas[2].LarguraColuna = 110;
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].LarguraColuna = 100;
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].LarguraColuna = 100;
				RT_geral.RT_810_DataGrigViewProcessosColunas[5].LarguraColuna = 80;
				RT_geral.RT_810_DataGrigViewProcessosColunas[6].LarguraColuna = 80;
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].AlingColuna = 32;
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].AlingColuna = 32;
				RT_geral.RT_810_DataGrigViewProcessosColunas[2].AlingColuna = 32;
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].AlingColuna = 32;
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].AlingColuna = 32;
				RT_geral.RT_810_DataGrigViewProcessosColunas[5].AlingColuna = 64;
				RT_geral.RT_810_DataGrigViewProcessosColunas[6].AlingColuna = 64;
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].NumeroLinhaMenu = 2;
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].LinhasMenu[0] = "Desativo";
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].LinhasMenu[1] = "SD - 01";
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].LinhasValor[1] = 21857;
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].NumeroLinhaMenu = 9;
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].LinhasMenu[0] = "Não usado";
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].LinhasValor[0] = 21856;
				RT_geral.RT_810_DataGrigViewProcessosColunas[2].NumeroLinhaMenu = 9;
				RT_geral.RT_810_DataGrigViewProcessosColunas[2].LinhasMenu[0] = "Sempre Remoto";
				RT_geral.RT_810_DataGrigViewProcessosColunas[2].LinhasValor[0] = 21856;
				num = 1;
				do
				{
					RT_geral.RT_810_DataGrigViewProcessosColunas[1].LinhasMenu[num] = "ED - " + Strings.Format(num, "0#");
					RT_geral.RT_810_DataGrigViewProcessosColunas[1].LinhasValor[num] = 21856 + num;
					RT_geral.RT_810_DataGrigViewProcessosColunas[2].LinhasMenu[num] = "ED - " + Strings.Format(num, "0#");
					RT_geral.RT_810_DataGrigViewProcessosColunas[2].LinhasValor[num] = 21856 + num;
					num++;
				}
				while (num <= 8);
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].NumeroLinhaMenu = 2;
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].LinhasMenu[0] = "Desabilitado";
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].LinhasMenu[1] = "Habilitado";
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].LinhasValor[0] = 21856;
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].LinhasValor[1] = 21857;
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].NumeroLinhaMenu = 2;
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].LinhasMenu[0] = "Telecomando";
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].LinhasMenu[1] = "Automático";
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].LinhasValor[0] = 21856;
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].LinhasValor[1] = 21857;
				RT_geral.RT_810_DataGrigViewProcessosColunas[5].NumeroLinhaMenu = 0;
				RT_geral.RT_810_DataGrigViewProcessosColunas[6].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00324234 File Offset: 0x00322634
		private void GeraDataGridView_EA_RT_810()
		{
			this.DataGridView_parametros_EA_810.Columns.Clear();
			this.DataGridView_parametros_EA_810.CellBorderStyle = 1;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_810_DataGrigViewEAColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_810_DataGrigViewEAColunas);
						this.DataGridView_parametros_EA_810.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_810_DataGrigViewEAColunas);
						this.DataGridView_parametros_EA_810.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 2);
				this.DataGridView_parametros_EA_810.RowCount = 4;
				this.DataGridView_parametros_EA_810.RowHeadersWidth = 70;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_parametros_EA_810.Rows)
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

		// Token: 0x06001339 RID: 4921 RVA: 0x00324368 File Offset: 0x00322768
		private void InicializaEstrutura_DataGridView_EA_RT_810()
		{
			RT_geral.RT_810_DataGrigViewEAColunas[0].TagColuna = "Range";
			RT_geral.RT_810_DataGrigViewEAColunas[1].TagColuna = "Início";
			RT_geral.RT_810_DataGrigViewEAColunas[2].TagColuna = "Fim";
			RT_geral.RT_810_DataGrigViewEAColunas[0].NomeColuna = "range";
			RT_geral.RT_810_DataGrigViewEAColunas[1].NomeColuna = "ini";
			RT_geral.RT_810_DataGrigViewEAColunas[2].NomeColuna = "fim";
			RT_geral.RT_810_DataGrigViewEAColunas[0].LarguraColuna = 90;
			RT_geral.RT_810_DataGrigViewEAColunas[1].LarguraColuna = 90;
			RT_geral.RT_810_DataGrigViewEAColunas[2].LarguraColuna = 90;
			RT_geral.RT_810_DataGrigViewEAColunas[0].AlingColuna = 64;
			RT_geral.RT_810_DataGrigViewEAColunas[1].AlingColuna = 64;
			RT_geral.RT_810_DataGrigViewEAColunas[2].AlingColuna = 64;
			RT_geral.RT_810_DataGrigViewEAColunas[0].NumeroLinhaMenu = 0;
			RT_geral.RT_810_DataGrigViewEAColunas[1].NumeroLinhaMenu = 0;
			RT_geral.RT_810_DataGrigViewEAColunas[2].NumeroLinhaMenu = 0;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00324494 File Offset: 0x00322894
		private void GeraDataGridView_Repedidora_RT_810()
		{
			this.DataGridView_end_rep_RT_810.Columns.Clear();
			this.DataGridView_end_rep_RT_810.CellBorderStyle = 1;
			this.DataGridView_end_rep_RT_810.DefaultCellStyle.Alignment = 64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_810_DataGrigViewRepetidoraColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_810_DataGrigViewRepetidoraColunas);
						this.DataGridView_end_rep_RT_810.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_810_DataGrigViewRepetidoraColunas);
						this.DataGridView_end_rep_RT_810.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 9);
				this.DataGridView_end_rep_RT_810.RowCount = 10;
				num = 0;
				do
				{
					this.DataGridView_end_rep_RT_810.Columns[num].ReadOnly = true;
					num++;
				}
				while (num <= 9);
				num = 0;
				do
				{
					this.DataGridView_end_rep_RT_810[0, num].Value = num + 1;
					this.DataGridView_end_rep_RT_810[2, num].Value = num + 11;
					this.DataGridView_end_rep_RT_810[4, num].Value = num + 21;
					this.DataGridView_end_rep_RT_810[6, num].Value = num + 31;
					this.DataGridView_end_rep_RT_810[8, num].Value = num + 41;
					num++;
				}
				while (num <= 9);
			}
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x003245F8 File Offset: 0x003229F8
		private void InicializaEstrutura_DataGridView_repetidora_RT_810()
		{
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[0].TagColuna = "Posição";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[1].TagColuna = "Endereço";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[2].TagColuna = "Posição";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[3].TagColuna = "Endereço";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[4].TagColuna = "Posição";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[5].TagColuna = "Endereço";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[6].TagColuna = "Posição";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[7].TagColuna = "Endereço";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[8].TagColuna = "Posição";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[9].TagColuna = "Endereço";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[0].NomeColuna = "pos_1";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[1].NomeColuna = "End_01_10";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[2].NomeColuna = "pos_2";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[3].NomeColuna = "End_11_20";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[4].NomeColuna = "pos_3";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[5].NomeColuna = "End_21_30";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[6].NomeColuna = "pos_4";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[7].NomeColuna = "End_31_40";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[8].NomeColuna = "pos_5";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[9].NomeColuna = "End_41_50";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[0].LarguraColuna = 50;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[1].LarguraColuna = 65;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[2].LarguraColuna = 50;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[3].LarguraColuna = 65;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[4].LarguraColuna = 50;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[5].LarguraColuna = 65;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[6].LarguraColuna = 50;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[7].LarguraColuna = 65;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[8].LarguraColuna = 50;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[9].LarguraColuna = 65;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[0].AlingColuna = 32;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[1].AlingColuna = 64;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[2].AlingColuna = 32;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[3].AlingColuna = 64;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[4].AlingColuna = 32;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[5].AlingColuna = 64;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[6].AlingColuna = 32;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[7].AlingColuna = 64;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[8].AlingColuna = 32;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[9].AlingColuna = 64;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00324918 File Offset: 0x00322D18
		private void GeraDataGridView_Setpoints_RT_810()
		{
			this.DataGridView_setpoints_810.Columns.Clear();
			this.DataGridView_setpoints_810.CellBorderStyle = 1;
			this.DataGridView_setpoints_810.DefaultCellStyle.Alignment = 64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_810_DataGrigViewSetpointsColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_810_DataGrigViewSetpointsColunas);
						this.DataGridView_setpoints_810.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_810_DataGrigViewSetpointsColunas);
						this.DataGridView_setpoints_810.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 2);
				this.DataGridView_setpoints_810.RowCount = 1;
				this.DataGridView_setpoints_810.RowHeadersWidth = 80;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_setpoints_810.Rows)
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

		// Token: 0x0600133D RID: 4925 RVA: 0x00324A54 File Offset: 0x00322E54
		private void InicializaEstrutura_DataGridView_Setpoints_RT_810()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_810_DataGrigViewSetpointsColunas[num].LinhasMenu = new string[22];
					RT_geral.RT_810_DataGrigViewSetpointsColunas[num].LinhasValor = new int[22];
					num++;
				}
				while (num <= 5);
				RT_geral.RT_810_DataGrigViewSetpointsColunas[2].TagColuna = "Alto";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[1].TagColuna = "Baixo";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].TagColuna = "Controle";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[2].NomeColuna = "Set_NAlto";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[1].NomeColuna = "Set_NBaixo";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].NomeColuna = "Set_Controle";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[2].LarguraColuna = 60;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[1].LarguraColuna = 60;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LarguraColuna = 160;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[2].AlingColuna = 64;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[1].AlingColuna = 64;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].AlingColuna = 32;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[1].NumeroLinhaMenu = 0;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[2].NumeroLinhaMenu = 0;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LinhasMenu[0] = "Controle Desabilitado";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].NumeroLinhaMenu = 9;
				num = 1;
				do
				{
					RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LinhasMenu[num] = "EA - " + Strings.Format(num, "0#");
					RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LinhasValor[num] = 21856 + num;
					num++;
				}
				while (num <= 4);
				num = 5;
				do
				{
					RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LinhasMenu[num] = "Referência " + Strings.Format(num - 4, "#");
					RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LinhasValor[num] = 21868 + num;
					num++;
				}
				while (num <= 8);
			}
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00324C88 File Offset: 0x00323088
		private void GeraDataGridView_ED_RT_810()
		{
			this.DataGridView_RT810_ED.Columns.Clear();
			this.DataGridView_RT810_ED.CellBorderStyle = 1;
			this.DataGridView_RT810_ED.DefaultCellStyle.Alignment = 64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_810_DataGrigViewEDColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_810_DataGrigViewEDColunas);
						this.DataGridView_RT810_ED.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_810_DataGrigViewEDColunas);
						this.DataGridView_RT810_ED.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 0);
				this.DataGridView_RT810_ED.RowCount = 8;
				this.DataGridView_RT810_ED.RowHeadersWidth = 80;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_RT810_ED.Rows)
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

		// Token: 0x0600133F RID: 4927 RVA: 0x00324DC4 File Offset: 0x003231C4
		private void InicializaEstrutura_DataGridView_ED_RT_810()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_810_DataGrigViewEDColunas[num].LinhasMenu = new string[10];
					RT_geral.RT_810_DataGrigViewEDColunas[num].LinhasValor = new int[10];
					num++;
				}
				while (num <= 0);
				RT_geral.RT_810_DataGrigViewEDColunas[0].TagColuna = "Entrada";
				RT_geral.RT_810_DataGrigViewEDColunas[0].NomeColuna = "Entrada";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LarguraColuna = 200;
				RT_geral.RT_810_DataGrigViewEDColunas[0].AlingColuna = 32;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[1] = 21969;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[2] = 21970;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[3] = 21971;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[4] = 21972;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[5] = 21973;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[6] = 21974;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[0] = "Sem função";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[1] = "Arrombamento";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[2] = "Falta de fase";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[3] = "Alagamento";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[4] = "Horário de ponta";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[5] = "Transbordo";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[6] = "Operação em bateira";
				RT_geral.RT_810_DataGrigViewEDColunas[0].NumeroLinhaMenu = 7;
			}
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00324FB0 File Offset: 0x003233B0
		public void Inicializa_DadosEStruturaRT810_Padrao()
		{
			RT_geral.RT_810_BD.Modelo.nome = "Modelo do Equipamento Emulado";
			RT_geral.RT_810_BD.Modelo.Indice_padrao = 0;
			RT_geral.RT_810_BD.Modelo.Numero_itens = 1;
			RT_geral.RT_810_BD.Modelo.valores[0] = 21856;
			RT_geral.RT_810_BD.Modelo.valores[1] = 21857;
			RT_geral.RT_810_BD.Modelo.valores[2] = 21858;
			RT_geral.RT_810_BD.Modelo.itens[0] = "RT 810";
			RT_geral.RT_810_BD.Modelo.itens[1] = "VA 310";
			RT_geral.RT_810_BD.Modelo.itens[2] = "MD 101";
			RT_geral.RT_810_BD.Versao.nome = "Versão";
			RT_geral.RT_810_BD.Versao.Padrao = 0;
			RT_geral.RT_810_BD.Build.nome = "Build";
			RT_geral.RT_810_BD.Build.Padrao = 0;
			RT_geral.RT_810_BD.Release.nome = "Release";
			RT_geral.RT_810_BD.Release.Padrao = 0;
			RT_geral.RT_810_BD.Equip.nome = "Tipo equipamento";
			RT_geral.RT_810_BD.Equip.Padrao = 0;
			RT_geral.RT_810_BD.End_estacao.nome = "Endereço Estação";
			RT_geral.RT_810_BD.End_estacao.Padrao = 1;
			RT_geral.RT_810_BD.End_estacao.Lmte_inf = 0;
			RT_geral.RT_810_BD.End_estacao.Lmte_sup = 200;
			RT_geral.RT_810_BD.End_mestre.nome = "Endereço Mestre";
			RT_geral.RT_810_BD.End_mestre.Padrao = 100;
			RT_geral.RT_810_BD.End_mestre.Lmte_inf = 1;
			RT_geral.RT_810_BD.End_mestre.Lmte_sup = 200;
			RT_geral.RT_810_BD.Tempo_ptt.nome = "Tempo PTT";
			RT_geral.RT_810_BD.Tempo_ptt.Padrao = 200;
			RT_geral.RT_810_BD.Tempo_ptt.Lmte_inf = 1;
			RT_geral.RT_810_BD.Tempo_ptt.Lmte_sup = 2000;
			RT_geral.RT_810_BD.Intervalo_tx_pto_pto.nome = "Intervalo Ponto à Ponto";
			RT_geral.RT_810_BD.Intervalo_tx_pto_pto.Padrao = 3;
			RT_geral.RT_810_BD.Intervalo_tx_pto_pto.Lmte_inf = 1;
			RT_geral.RT_810_BD.Intervalo_tx_pto_pto.Lmte_sup = 43200;
			RT_geral.RT_810_BD.Hab_eletrodos.nome = "Habilita leitura por eletrodos";
			RT_geral.RT_810_BD.Hab_eletrodos.Padrao = 21856;
			RT_geral.RT_810_BD.Hab_eletrodos.Lmte_inf = 21856;
			RT_geral.RT_810_BD.Hab_eletrodos.Lmte_sup = 21857;
			RT_geral.RT_810_BD.Modo_de_operacao.nome = "Modo Operação";
			RT_geral.RT_810_BD.Modo_de_operacao.Indice_padrao = 0;
			RT_geral.RT_810_BD.Modo_de_operacao.Numero_itens = 3;
			RT_geral.RT_810_BD.Modo_de_operacao.valores[0] = 21856;
			RT_geral.RT_810_BD.Modo_de_operacao.valores[1] = 21857;
			RT_geral.RT_810_BD.Modo_de_operacao.valores[2] = 21858;
			RT_geral.RT_810_BD.Modo_de_operacao.itens[0] = "Rede";
			RT_geral.RT_810_BD.Modo_de_operacao.itens[1] = "Ponto à ponto - COM1";
			RT_geral.RT_810_BD.Modo_de_operacao.itens[2] = "Ponto à ponto - COM2";
			RT_geral.RT_810_BD.BaudRateCOM1.nome = "BaudRate COM1";
			RT_geral.RT_810_BD.BaudRateCOM1.Indice_padrao = perifericos.Lista_GetIndicePadrao(perifericos.ListaBaudRate);
			RT_geral.RT_810_BD.BaudRateCOM1.Numero_itens = 3;
			int num = 0;
			checked
			{
				int num2 = perifericos.ListaBaudRate.Count - 1;
				int i;
				for (i = num; i <= num2; i++)
				{
					RT_geral.RT_810_BD.BaudRateCOM1.valores[i] = perifericos.ListaBaudRate[i].valor;
					RT_geral.RT_810_BD.BaudRateCOM1.itens[i] = perifericos.ListaBaudRate[i].nome;
				}
				RT_geral.RT_810_BD.BaudRateCOM2.nome = "BaudRate COM2";
				RT_geral.RT_810_BD.BaudRateCOM2.Indice_padrao = perifericos.Lista_GetIndicePadrao(perifericos.ListaBaudRate);
				RT_geral.RT_810_BD.BaudRateCOM2.Numero_itens = 3;
				int num3 = 0;
				int num4 = perifericos.ListaBaudRate.Count - 1;
				for (i = num3; i <= num4; i++)
				{
					RT_geral.RT_810_BD.BaudRateCOM2.valores[i] = perifericos.ListaBaudRate[i].valor;
					RT_geral.RT_810_BD.BaudRateCOM2.itens[i] = perifericos.ListaBaudRate[i].nome;
				}
				i = 0;
				do
				{
					RT_geral.RT_810_BD.ctrl_acionamento[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - SD acinamento";
					RT_geral.RT_810_BD.ctrl_acionamento[i].Indice_padrao = 0;
					RT_geral.RT_810_BD.ctrl_ret_acionamento[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - ED acionamento";
					RT_geral.RT_810_BD.ctrl_ret_acionamento[i].Indice_padrao = 0;
					RT_geral.RT_810_BD.ctrl_ED_selecao[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - ED seleção ";
					RT_geral.RT_810_BD.ctrl_ED_selecao[i].Indice_padrao = 0;
					RT_geral.RT_810_BD.ctrl_reverso[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Reverso ";
					RT_geral.RT_810_BD.ctrl_reverso[i].Indice_padrao = 0;
					RT_geral.RT_810_BD.ctrl_modo[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Modo ";
					RT_geral.RT_810_BD.ctrl_modo[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 1);
				i = 0;
				do
				{
					RT_geral.RT_810_BD.ctrl_tempo_max_partida[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Tempo máx partida";
					RT_geral.RT_810_BD.ctrl_tempo_max_partida[i].Padrao = 180;
					RT_geral.RT_810_BD.ctrl_tempo_max_partida[i].Lmte_inf = 0;
					RT_geral.RT_810_BD.ctrl_tempo_max_partida[i].Lmte_sup = 1200;
					RT_geral.RT_810_BD.ctrl_tempo_max_parada[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Tempo máx parada";
					RT_geral.RT_810_BD.ctrl_tempo_max_parada[i].Padrao = 180;
					RT_geral.RT_810_BD.ctrl_tempo_max_parada[i].Lmte_inf = 0;
					RT_geral.RT_810_BD.ctrl_tempo_max_parada[i].Lmte_sup = 1200;
					i++;
				}
				while (i <= 1);
				i = 0;
				do
				{
					RT_geral.RT_810_BD.EA_Range[i].nome = "Range sensor " + Conversion.Str(i + 1);
					RT_geral.RT_810_BD.EA_Range[i].Padrao = 4000;
					RT_geral.RT_810_BD.EA_Range[i].Lmte_inf = 1;
					RT_geral.RT_810_BD.EA_Range[i].Lmte_sup = 65535;
					RT_geral.RT_810_BD.EA_Inicio[i].nome = "Início sensor " + Conversion.Str(i + 1);
					RT_geral.RT_810_BD.EA_Inicio[i].Padrao = 0;
					RT_geral.RT_810_BD.EA_Inicio[i].Lmte_inf = 0;
					RT_geral.RT_810_BD.EA_Inicio[i].Lmte_sup = 65536;
					RT_geral.RT_810_BD.EA_Fim[i].nome = "Fim sensor " + Conversion.Str(i + 1);
					RT_geral.RT_810_BD.EA_Fim[i].Padrao = 4000;
					RT_geral.RT_810_BD.EA_Fim[i].Lmte_inf = 1;
					RT_geral.RT_810_BD.EA_Fim[i].Lmte_sup = 65535;
					i++;
				}
				while (i <= 4);
				RT_geral.RT_810_BD.AD_Intervalo.nome = "Intervalo AD";
				RT_geral.RT_810_BD.AD_Intervalo.Padrao = 500;
				RT_geral.RT_810_BD.AD_Intervalo.Lmte_inf = 100;
				RT_geral.RT_810_BD.AD_Intervalo.Lmte_sup = 20000;
				RT_geral.RT_810_BD.AD_Tamanho_filtro.nome = "Tamanho Filtro AD";
				RT_geral.RT_810_BD.AD_Tamanho_filtro.Padrao = 3;
				RT_geral.RT_810_BD.AD_Tamanho_filtro.Lmte_inf = 1;
				RT_geral.RT_810_BD.AD_Tamanho_filtro.Lmte_sup = 10;
				i = 0;
				do
				{
					RT_geral.RT_810_BD.config_ED[i].nome = "ED " + Conversion.Str(i + 1);
					RT_geral.RT_810_BD.config_ED[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 7);
				i = 0;
				do
				{
					RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[i].nome = "Setpoint Alto " + Conversion.Str(i + 1);
					RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[i].Padrao = 4000;
					RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[i].Lmte_inf = 0;
					RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[i].Lmte_sup = 4000;
					RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[i].nome = "Setpoint Baixo " + Conversion.Str(i + 1);
					RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[i].Padrao = 0;
					RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[i].Lmte_inf = 0;
					RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[i].Lmte_sup = 4000;
					i++;
				}
				while (i <= 1);
				i = 0;
				do
				{
					RT_geral.RT_810_BD.Setpoints_ctrl_variavel[i].nome = "Setpoint " + Conversion.Str(i + 1) + "Variável de Controle";
					RT_geral.RT_810_BD.Setpoints_ctrl_variavel[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 1);
				RT_geral.RT_810_BD.Hab_repetidora.nome = "Modo Operação da repetidora";
				RT_geral.RT_810_BD.Hab_repetidora.Indice_padrao = 0;
				RT_geral.RT_810_BD.Hab_repetidora.Numero_itens = 3;
				RT_geral.RT_810_BD.Hab_repetidora.valores[0] = 21856;
				RT_geral.RT_810_BD.Hab_repetidora.valores[1] = 21857;
				RT_geral.RT_810_BD.Hab_repetidora.valores[2] = 21858;
				RT_geral.RT_810_BD.Hab_repetidora.itens[0] = "Desabilitada";
				RT_geral.RT_810_BD.Hab_repetidora.itens[1] = "Direta";
				RT_geral.RT_810_BD.Hab_repetidora.itens[2] = "Cruzada";
				RT_geral.RT_810_BD.End_repetidora.nome = "Endereço Repetidora";
				RT_geral.RT_810_BD.End_repetidora.Padrao = 1;
				RT_geral.RT_810_BD.End_repetidora.Lmte_inf = 0;
				RT_geral.RT_810_BD.End_repetidora.Lmte_sup = 200;
				RT_geral.RT_810_BD.Num_repetidoras.nome = "Número de Repetidoras";
				RT_geral.RT_810_BD.Num_repetidoras.Padrao = 0;
				RT_geral.RT_810_BD.Num_repetidoras.Lmte_inf = 0;
				RT_geral.RT_810_BD.Num_repetidoras.Lmte_sup = 50;
				i = 0;
				do
				{
					RT_geral.RT_810_BD.Repetidoras[i].nome = "Endereço da Repetidora " + Conversion.Str(i + 1);
					RT_geral.RT_810_BD.Repetidoras[i].Padrao = 0;
					RT_geral.RT_810_BD.Repetidoras[i].Lmte_inf = 0;
					RT_geral.RT_810_BD.Repetidoras[i].Lmte_sup = 200;
					i++;
				}
				while (i <= 50);
				RT_geral.RT_810_BD.filename = "";
			}
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00325C38 File Offset: 0x00324038
		public void Inicializa_DadosEStruturaRT810_Default()
		{
			RT_geral.RT_810_BD.Equip.Valor = RT_geral.RT_810_BD.Equip.Padrao;
			RT_geral.RT_810_BD.Versao.Valor = RT_geral.RT_810_BD.Versao.Padrao;
			RT_geral.RT_810_BD.Build.Valor = RT_geral.RT_810_BD.Build.Padrao;
			RT_geral.RT_810_BD.Release.Valor = RT_geral.RT_810_BD.Release.Padrao;
			RT_geral.RT_810_BD.End_estacao.Valor = RT_geral.RT_810_BD.End_estacao.Padrao;
			RT_geral.RT_810_BD.End_mestre.Valor = RT_geral.RT_810_BD.End_mestre.Padrao;
			RT_geral.RT_810_BD.Tempo_ptt.Valor = RT_geral.RT_810_BD.Tempo_ptt.Padrao;
			RT_geral.RT_810_BD.Intervalo_tx_pto_pto.Valor = RT_geral.RT_810_BD.Intervalo_tx_pto_pto.Padrao;
			RT_geral.RT_810_BD.Hab_eletrodos.Valor = RT_geral.RT_810_BD.Hab_eletrodos.Padrao;
			RT_geral.RT_810_BD.Modelo.Indice = RT_geral.RT_810_BD.Modelo.Indice_padrao;
			RT_geral.RT_810_BD.Modelo.Valor = RT_geral.RT_810_BD.Modelo.valores[RT_geral.RT_810_BD.Modelo.Indice];
			RT_geral.RT_810_BD.Modo_de_operacao.Indice = RT_geral.RT_810_BD.Modo_de_operacao.Indice_padrao;
			RT_geral.RT_810_BD.Modo_de_operacao.Valor = RT_geral.RT_810_BD.Modo_de_operacao.valores[RT_geral.RT_810_BD.Modo_de_operacao.Indice];
			this.TextBox_comentarios_RT810.Text = "";
			this.TextBox_nome_RT810.Text = "";
			this.TextBox_endereco_RT810.Text = "";
			RT_geral.RT_810_BD.BaudRateCOM1.Indice = 1;
			RT_geral.RT_810_BD.BaudRateCOM1.Valor = RT_geral.RT_810_BD.BaudRateCOM1.valores[RT_geral.RT_810_BD.BaudRateCOM1.Indice];
			RT_geral.RT_810_BD.BaudRateCOM2.Indice = 0;
			RT_geral.RT_810_BD.BaudRateCOM2.Valor = RT_geral.RT_810_BD.BaudRateCOM2.valores[RT_geral.RT_810_BD.BaudRateCOM2.Indice];
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_810_BD.ctrl_acionamento[num].Indice = RT_geral.RT_810_BD.ctrl_acionamento[num].Indice_padrao;
					RT_geral.RT_810_BD.ctrl_acionamento[num].Valor = RT_geral.RT_810_DataGrigViewProcessosColunas[0].LinhasValor[RT_geral.RT_810_BD.ctrl_acionamento[num].Indice];
					RT_geral.RT_810_BD.ctrl_ret_acionamento[num].Indice = RT_geral.RT_810_BD.ctrl_ret_acionamento[num].Indice_padrao;
					RT_geral.RT_810_BD.ctrl_ret_acionamento[num].Valor = RT_geral.RT_810_DataGrigViewProcessosColunas[1].LinhasValor[RT_geral.RT_810_BD.ctrl_ret_acionamento[num].Indice];
					RT_geral.RT_810_BD.ctrl_ED_selecao[num].Indice = RT_geral.RT_810_BD.ctrl_ED_selecao[num].Indice_padrao;
					RT_geral.RT_810_BD.ctrl_ED_selecao[num].Valor = RT_geral.RT_810_DataGrigViewProcessosColunas[2].LinhasValor[RT_geral.RT_810_BD.ctrl_ED_selecao[num].Indice];
					RT_geral.RT_810_BD.ctrl_reverso[num].Indice = RT_geral.RT_810_BD.ctrl_reverso[num].Indice_padrao;
					RT_geral.RT_810_BD.ctrl_reverso[num].Valor = RT_geral.RT_810_DataGrigViewProcessosColunas[3].LinhasValor[RT_geral.RT_810_BD.ctrl_reverso[num].Indice];
					RT_geral.RT_810_BD.ctrl_modo[num].Indice = RT_geral.RT_810_BD.ctrl_modo[num].Indice_padrao;
					RT_geral.RT_810_BD.ctrl_modo[num].Valor = RT_geral.RT_810_DataGrigViewProcessosColunas[4].LinhasValor[RT_geral.RT_810_BD.ctrl_modo[num].Indice];
					num++;
				}
				while (num <= 1);
				num = 0;
				do
				{
					RT_geral.RT_810_BD.ctrl_tempo_max_partida[num].Valor = RT_geral.RT_810_BD.ctrl_tempo_max_partida[num].Padrao;
					RT_geral.RT_810_BD.ctrl_tempo_max_parada[num].Valor = RT_geral.RT_810_BD.ctrl_tempo_max_parada[num].Padrao;
					num++;
				}
				while (num <= 1);
				RT_geral.RT_810_BD.AD_Intervalo.Valor = RT_geral.RT_810_BD.AD_Intervalo.Padrao;
				RT_geral.RT_810_BD.AD_Tamanho_filtro.Valor = RT_geral.RT_810_BD.AD_Tamanho_filtro.Padrao;
				num = 0;
				do
				{
					RT_geral.RT_810_BD.EA_Range[num].Valor = RT_geral.RT_810_BD.EA_Range[num].Padrao;
					RT_geral.RT_810_BD.EA_Inicio[num].Valor = RT_geral.RT_810_BD.EA_Inicio[num].Padrao;
					RT_geral.RT_810_BD.EA_Fim[num].Valor = RT_geral.RT_810_BD.EA_Fim[num].Padrao;
					num++;
				}
				while (num <= 4);
				num = 0;
				do
				{
					RT_geral.RT_810_BD.config_ED[num].Indice = RT_geral.RT_810_BD.config_ED[num].Indice_padrao;
					num++;
				}
				while (num <= 8);
				num = 0;
				do
				{
					RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[num].Valor = RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[num].Padrao;
					RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[num].Valor = RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[num].Padrao;
					RT_geral.RT_810_BD.Setpoints_ctrl_variavel[num].Indice = RT_geral.RT_810_BD.Setpoints_ctrl_variavel[num].Indice_padrao;
					RT_geral.RT_810_BD.Setpoints_ctrl_variavel[num].Valor = RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LinhasValor[RT_geral.RT_810_BD.Setpoints_ctrl_variavel[num].Indice];
					num++;
				}
				while (num <= 1);
				RT_geral.RT_810_BD.Hab_repetidora.Indice = RT_geral.RT_810_BD.Hab_repetidora.Indice_padrao;
				RT_geral.RT_810_BD.Hab_repetidora.Valor = RT_geral.RT_810_BD.Hab_repetidora.valores[RT_geral.RT_810_BD.Hab_repetidora.Indice];
				RT_geral.RT_810_BD.End_repetidora.Valor = RT_geral.RT_810_BD.End_repetidora.Padrao;
				RT_geral.RT_810_BD.Num_repetidoras.Valor = RT_geral.RT_810_BD.Num_repetidoras.Padrao;
				num = 0;
				do
				{
					RT_geral.RT_810_BD.Repetidoras[num].Valor = RT_geral.RT_810_BD.Repetidoras[num].Padrao;
					num++;
				}
				while (num <= 50);
			}
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0032637C File Offset: 0x0032477C
		public void Atualiza_TelaRT810()
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
					this.Libera_acoes();
					this.ComboBox_modo_simulado_810.SelectedIndex = RT_geral.RT_810_BD.Modelo.Indice;
					this.ComboBox_Modo_Operacao.SelectedIndex = RT_geral.RT_810_BD.Modo_de_operacao.Indice;
					this.TextBox_equipamento.Text = Conversions.ToString(RT_geral.RT_810_BD.Equip.Valor);
					this.TextBox_versao.Text = Conversions.ToString(RT_geral.RT_810_BD.Versao.Valor);
					this.TextBox_build.Text = Conversions.ToString(RT_geral.RT_810_BD.Build.Valor);
					this.TextBox_release.Text = Conversions.ToString(RT_geral.RT_810_BD.Release.Valor);
					this.NumericUpDown_end_est.Value = new decimal(RT_geral.RT_810_BD.End_estacao.Valor);
					this.NumericUpDown_end_mestre.Value = new decimal(RT_geral.RT_810_BD.End_mestre.Valor);
					this.NumericUpDown_temp_ptt.Value = new decimal(RT_geral.RT_810_BD.Tempo_ptt.Valor);
					this.NumericUpDown_intervalo_tx.Value = new decimal(RT_geral.RT_810_BD.Intervalo_tx_pto_pto.Valor);
					if (RT_geral.RT_810_BD.Hab_eletrodos.Valor == 21856)
					{
						this.CheckBox_Hab_eletrodos.Checked = false;
					}
					else
					{
						this.CheckBox_Hab_eletrodos.Checked = true;
					}
					this.ComboBox_baudrate_COM1_810.SelectedIndex = RT_geral.RT_810_BD.BaudRateCOM1.Indice;
					this.ComboBox_baudrate_COM2_810.SelectedIndex = RT_geral.RT_810_BD.BaudRateCOM2.Indice;
					int num2 = 0;
					do
					{
						string value = RT_geral.RT_810_DataGrigViewProcessosColunas[0].LinhasMenu[RT_geral.RT_810_BD.ctrl_acionamento[num2].Indice];
						this.DataGridView_processo_810_P1.Rows[num2].Cells[0].Value = value;
						value = RT_geral.RT_810_DataGrigViewProcessosColunas[1].LinhasMenu[RT_geral.RT_810_BD.ctrl_ret_acionamento[num2].Indice];
						this.DataGridView_processo_810_P1.Rows[num2].Cells[1].Value = value;
						value = RT_geral.RT_810_DataGrigViewProcessosColunas[2].LinhasMenu[RT_geral.RT_810_BD.ctrl_ED_selecao[num2].Indice];
						this.DataGridView_processo_810_P1.Rows[num2].Cells[2].Value = value;
						value = RT_geral.RT_810_DataGrigViewProcessosColunas[3].LinhasMenu[RT_geral.RT_810_BD.ctrl_reverso[num2].Indice];
						this.DataGridView_processo_810_P1.Rows[num2].Cells[3].Value = value;
						value = RT_geral.RT_810_DataGrigViewProcessosColunas[4].LinhasMenu[RT_geral.RT_810_BD.ctrl_modo[num2].Indice];
						this.DataGridView_processo_810_P1.Rows[num2].Cells[4].Value = value;
						this.DataGridView_processo_810_P1.Rows[num2].Cells[5].Value = RT_geral.RT_810_BD.ctrl_tempo_max_partida[num2].Valor;
						this.DataGridView_processo_810_P1.Rows[num2].Cells[6].Value = RT_geral.RT_810_BD.ctrl_tempo_max_parada[num2].Valor;
						num2++;
					}
					while (num2 <= 0);
					num2 = 0;
					do
					{
						this.DataGridView_parametros_EA_810.Rows[num2].Cells[0].Value = RT_geral.RT_810_BD.EA_Range[num2].Valor;
						this.DataGridView_parametros_EA_810.Rows[num2].Cells[1].Value = RT_geral.RT_810_BD.EA_Inicio[num2].Valor;
						this.DataGridView_parametros_EA_810.Rows[num2].Cells[2].Value = RT_geral.RT_810_BD.EA_Fim[num2].Valor;
						num2++;
					}
					while (num2 <= 3);
					this.NumericUpDown_intervalo_filtro.Value = new decimal(RT_geral.RT_810_BD.AD_Intervalo.Valor);
					this.NumericUpDown_tamanho_filtro.Value = new decimal(RT_geral.RT_810_BD.AD_Tamanho_filtro.Valor);
					num2 = 0;
					do
					{
						string value = RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[RT_geral.RT_810_BD.config_ED[num2].Indice];
						this.DataGridView_RT810_ED.Rows[num2].Cells[0].Value = value;
						num2++;
					}
					while (num2 <= 7);
					num2 = 0;
					do
					{
						this.DataGridView_setpoints_810.Rows[num2].Cells[2].Value = RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[num2].Valor;
						this.DataGridView_setpoints_810.Rows[num2].Cells[1].Value = RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[num2].Valor;
						string value = RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LinhasMenu[RT_geral.RT_810_BD.Setpoints_ctrl_variavel[num2].Indice];
						this.DataGridView_setpoints_810.Rows[num2].Cells[0].Value = value;
						num2++;
					}
					while (num2 <= 0);
					this.ComboBox_modo_repeticao_RT_810.SelectedIndex = RT_geral.RT_810_BD.Hab_repetidora.Indice;
					this.NumericUpDown_end_rep.Value = new decimal(RT_geral.RT_810_BD.End_repetidora.Valor);
					this.NumericUpDown_num_est_rep.Value = new decimal(RT_geral.RT_810_BD.Num_repetidoras.Valor);
					num2 = 0;
					do
					{
						this.DataGridView_end_rep_RT_810.Rows[num2].Cells[1].Value = RT_geral.RT_810_BD.Repetidoras[num2].Valor;
						this.DataGridView_end_rep_RT_810.Rows[num2].Cells[3].Value = RT_geral.RT_810_BD.Repetidoras[num2 + 10].Valor;
						this.DataGridView_end_rep_RT_810.Rows[num2].Cells[5].Value = RT_geral.RT_810_BD.Repetidoras[num2 + 20].Valor;
						this.DataGridView_end_rep_RT_810.Rows[num2].Cells[7].Value = RT_geral.RT_810_BD.Repetidoras[num2 + 30].Valor;
						this.DataGridView_end_rep_RT_810.Rows[num2].Cells[9].Value = RT_geral.RT_810_BD.Repetidoras[num2 + 40].Valor;
						num2++;
					}
					while (num2 <= 9);
					goto IL_79B;
					IL_744:
					Interaction.MsgBox("Erro na atualização da tela!", 32, "Atenção - Erro de dados");
					goto IL_79B;
					IL_758:
					num3 = -1;
										IL_76D:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num3 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_758;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_79B:
				if (num3 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00326B4C File Offset: 0x00324F4C
		public void Habilita_Funcoes_de_Tela_RT_810(int tipo)
		{
			this.GroupBox_comunicacao.Enabled = true;
			this.GroupBox_informacoes.Enabled = false;
			this.GroupBox_ModoOperacao.Enabled = false;
			this.GroupBox_sistema_leitura.Enabled = false;
			this.GroupBox_controle_810.Enabled = false;
			this.DataGridView_processo_810_P1.Visible = false;
			this.GroupBox_parametros_EA.Enabled = false;
			this.GroupBox_EA.Enabled = false;
			this.DataGridView_parametros_EA_810.Visible = false;
			this.GroupBox_ED.Enabled = false;
			this.GroupBox_setpoints_810.Enabled = false;
			this.DataGridView_setpoints_810.Visible = false;
			this.GroupBox_parametros_repetidora.Enabled = false;
			this.GroupBox_end_rep.Enabled = false;
			this.DataGridView_end_rep_RT_810.Visible = false;
			switch (tipo)
			{
			case 0:
				this.GroupBox_informacoes.Enabled = true;
				this.GroupBox_ModoOperacao.Enabled = true;
				this.GroupBox_sistema_leitura.Enabled = true;
				this.GroupBox_controle_810.Enabled = true;
				this.DataGridView_processo_810_P1.Visible = true;
				this.GroupBox_parametros_EA.Enabled = true;
				this.GroupBox_EA.Enabled = true;
				this.DataGridView_parametros_EA_810.Visible = true;
				this.GroupBox_ED.Enabled = true;
				this.GroupBox_setpoints_810.Enabled = true;
				this.DataGridView_setpoints_810.Visible = true;
				this.GroupBox_parametros_repetidora.Enabled = true;
				this.GroupBox_end_rep.Enabled = true;
				this.DataGridView_end_rep_RT_810.Visible = true;
				break;
			}
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00326CD0 File Offset: 0x003250D0
		public void RT_810_Atualiza_Parametros_EA(int tipo)
		{
			int num;
			int rowCount;
			if (tipo == 0)
			{
				num = 3;
				rowCount = 4;
			}
			else
			{
				num = 0;
				rowCount = 1;
			}
			this.DataGridView_parametros_EA_810.Rows.Clear();
			this.DataGridView_parametros_EA_810.ColumnCount = 4;
			this.DataGridView_parametros_EA_810.RowCount = rowCount;
			int num2 = 0;
			int num3 = num;
			checked
			{
				for (int i = num2; i <= num3; i++)
				{
					this.DataGridView_parametros_EA_810.Rows[i].Cells[0].Value = i + 1;
					this.DataGridView_parametros_EA_810.Rows[i].Cells[1].Value = RT_geral.RT_810_BD.EA_Range[i].Valor;
					this.DataGridView_parametros_EA_810.Rows[i].Cells[2].Value = RT_geral.RT_810_BD.EA_Inicio[i].Valor;
					this.DataGridView_parametros_EA_810.Rows[i].Cells[3].Value = RT_geral.RT_810_BD.EA_Fim[i].Valor;
				}
			}
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00326E08 File Offset: 0x00325208
		public void RT_810_Habilita_Pto_a_Pto(int modo)
		{
			if (modo == 0)
			{
				this.Label_intevalo_tx_pto_pto.Enabled = false;
				this.NumericUpDown_intervalo_tx.Enabled = false;
			}
			else
			{
				this.Label_intevalo_tx_pto_pto.Enabled = true;
				this.NumericUpDown_intervalo_tx.Enabled = true;
			}
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00326E40 File Offset: 0x00325240
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

		// Token: 0x06001347 RID: 4935 RVA: 0x00326EA4 File Offset: 0x003252A4
		public void EncerraEdicaoDeCampos()
		{
			this.DataGridView_end_rep_RT_810.EndEdit();
			this.DataGridView_parametros_EA_810.EndEdit();
			this.DataGridView_processo_810_P1.EndEdit();
			this.DataGridView_RT810_ED.EndEdit();
			this.DataGridView_setpoints_810.EndEdit();
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00326EE4 File Offset: 0x003252E4
		public void Bloqueia_acoes()
		{
			this.ToolStripButton_RT_810_Abrir.Enabled = false;
			this.ToolStripButton_RT_810_novo.Enabled = false;
			this.ToolStripButton_RT_810_Salvar.Enabled = false;
			this.ToolStripButton_RT_810_Download.Enabled = false;
			this.ToolStripButton_RT_810_Upload.Enabled = false;
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00326F24 File Offset: 0x00325324
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

		// Token: 0x0600134A RID: 4938 RVA: 0x00326FC8 File Offset: 0x003253C8
		public void InicializaBarraProgressoTela_RT_810(int num_passos)
		{
			this.ToolStripProgressBar_RT_810.Minimum = 0;
			this.ToolStripProgressBar_RT_810.Maximum = checked(num_passos * 4);
			this.ToolStripProgressBar_RT_810.Step = num_passos;
			this.ToolStripProgressBar_RT_810.Value = 0;
			this.ToolStripProgressBar_RT_810.BackColor = Color.LightGray;
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00327018 File Offset: 0x00325418
		private void Timer_limpa_MSG_Tick(object sender, EventArgs e)
		{
			this.Timer_limpa_MSG.Enabled = false;
			this.AtualizaMsgTela_RT_810("", 0);
			this.ToolStripProgressBar_RT_810.Value = 0;
			this.Libera_acoes();
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00327044 File Offset: 0x00325444
		private void CheckBox_hab_eletrodos_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null), true, false))
			{
				RT_geral.RT_810_BD.Hab_eletrodos.Valor = 21857;
			}
			else
			{
				RT_geral.RT_810_BD.Hab_eletrodos.Valor = 21856;
			}
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x003270A0 File Offset: 0x003254A0
		private void ComboBox_metodo_operacao_Validating(object sender, CancelEventArgs e)
		{
			if (this.ComboBox_Modo_Operacao.FindStringExact(this.ComboBox_Modo_Operacao.Text) == -1)
			{
				Interaction.MsgBox("Opção digitada não existe!\r\nAssumindo Default!", 32, "Atenção - Método Operação");
				this.ComboBox_Modo_Operacao.SelectedIndex = 0;
			}
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x003270DC File Offset: 0x003254DC
		private void ComboBox_metodo_operacao_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_BD.Modo_de_operacao.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_810_BD.Modo_de_operacao.Valor = RT_geral.RT_810_BD.Modo_de_operacao.valores[RT_geral.RT_810_BD.Modo_de_operacao.Indice];
			this.RT_810_Habilita_Pto_a_Pto(RT_geral.RT_810_BD.Modo_de_operacao.Indice);
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00327158 File Offset: 0x00325558
		private void ComboBox_modo_repeticao_RT_810_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 0, false))
			{
				RT_geral.RT_810_BD.Hab_repetidora.Valor = 21856;
				this.GroupBox_end_rep.Visible = false;
				this.DataGridView_end_rep_RT_810.Visible = false;
				this.NumericUpDown_end_rep.Enabled = false;
				this.NumericUpDown_num_est_rep.Enabled = false;
			}
			else
			{
				RT_geral.RT_810_BD.Hab_repetidora.Valor = Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21856));
				this.GroupBox_end_rep.Visible = true;
				this.DataGridView_end_rep_RT_810.Visible = true;
				this.NumericUpDown_end_rep.Enabled = true;
				this.NumericUpDown_num_est_rep.Enabled = true;
			}
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00327238 File Offset: 0x00325638
		private void ComboBox_modo_simulado_810_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_BD.Modelo.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_810_BD.Modelo.Valor = RT_geral.RT_810_BD.Modelo.valores[RT_geral.RT_810_BD.Modelo.Indice];
			this.Habilita_Funcoes_de_Tela_RT_810(Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null)));
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x003272BC File Offset: 0x003256BC
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
				Interaction.MsgBox("Opção digitada não existe!\r\nAssumindo Default!", 32, "Atenção - Entrada digital " + Conversion.Str(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "ValueMember", new object[0], null, null, null))));
				NewLateBinding.LateSet(sender, null, "SelectedIndex", new object[]
				{
					0
				}, null, null);
			}
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x003273A0 File Offset: 0x003257A0
		private void NumericUpDown_intervalo_tx_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_BD.Intervalo_tx_pto_pto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_BD.Intervalo_tx_pto_pto, true);
			sender = numericUpDown;
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x003273F4 File Offset: 0x003257F4
		private void NumericUpDown_temp_ptt_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_BD.Tempo_ptt.Valor = Conversions.ToInteger(Operators.MultiplyObject(Operators.IntDivideObject(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null), 10), 10));
			NewLateBinding.LateSet(sender, null, "value", new object[]
			{
				RT_geral.RT_810_BD.Tempo_ptt.Valor
			}, null, null);
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_BD.Tempo_ptt, true);
			sender = numericUpDown;
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0032748C File Offset: 0x0032588C
		private void NumericUpDown_end_mestre_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_BD.End_mestre.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_BD.End_mestre, true);
			sender = numericUpDown;
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x003274E0 File Offset: 0x003258E0
		private void NumericUpDown_end_est_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_BD.End_estacao.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_BD.End_estacao, true);
			sender = numericUpDown;
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00327534 File Offset: 0x00325934
		private void NumericUpDown_intervalo_filtro_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_BD.AD_Intervalo.Valor = Conversions.ToInteger(Operators.MultiplyObject(Operators.IntDivideObject(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null), 10), 10));
			NewLateBinding.LateSet(sender, null, "value", new object[]
			{
				RT_geral.RT_810_BD.AD_Intervalo.Valor
			}, null, null);
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_BD.AD_Intervalo, true);
			sender = numericUpDown;
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x003275CC File Offset: 0x003259CC
		private void NumericUpDown_tamanho_filtro_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_BD.AD_Tamanho_filtro.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_BD.AD_Tamanho_filtro, true);
			sender = numericUpDown;
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00327620 File Offset: 0x00325A20
		private void NumericUpDown_end_rep_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_BD.End_repetidora.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_BD.End_repetidora, true);
			sender = numericUpDown;
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00327674 File Offset: 0x00325A74
		private void NumericUpDown_num_est_rep_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_BD.Num_repetidoras.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_BD.Num_repetidoras, true);
			sender = numericUpDown;
			int num = 0;
			int num2 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			checked
			{
				for (int i = num; i <= num2; i++)
				{
					switch (i)
					{
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
						this.DataGridView_end_rep_RT_810.Rows[i].Cells[1].ReadOnly = false;
						break;
					case 10:
					case 11:
					case 12:
					case 13:
					case 14:
					case 15:
					case 16:
					case 17:
					case 18:
					case 19:
						this.DataGridView_end_rep_RT_810.Rows[i - 10].Cells[3].ReadOnly = false;
						break;
					case 20:
					case 21:
					case 22:
					case 23:
					case 24:
					case 25:
					case 26:
					case 27:
					case 28:
					case 29:
						this.DataGridView_end_rep_RT_810.Rows[i - 20].Cells[5].ReadOnly = false;
						break;
					case 30:
					case 31:
					case 32:
					case 33:
					case 34:
					case 35:
					case 36:
					case 37:
					case 38:
					case 39:
						this.DataGridView_end_rep_RT_810.Rows[i - 30].Cells[7].ReadOnly = false;
						break;
					case 40:
					case 41:
					case 42:
					case 43:
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:
						this.DataGridView_end_rep_RT_810.Rows[i - 40].Cells[9].ReadOnly = false;
						break;
					}
				}
				for (int i = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null)); i <= 49; i++)
				{
					switch (i)
					{
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
						this.DataGridView_end_rep_RT_810.Rows[i].Cells[1].ReadOnly = true;
						this.DataGridView_end_rep_RT_810.Rows[i].Cells[1].Value = 0;
						break;
					case 10:
					case 11:
					case 12:
					case 13:
					case 14:
					case 15:
					case 16:
					case 17:
					case 18:
					case 19:
						this.DataGridView_end_rep_RT_810.Rows[i - 10].Cells[3].ReadOnly = true;
						this.DataGridView_end_rep_RT_810.Rows[i - 10].Cells[3].Value = 0;
						break;
					case 20:
					case 21:
					case 22:
					case 23:
					case 24:
					case 25:
					case 26:
					case 27:
					case 28:
					case 29:
						this.DataGridView_end_rep_RT_810.Rows[i - 20].Cells[5].ReadOnly = true;
						this.DataGridView_end_rep_RT_810.Rows[i - 20].Cells[5].Value = 0;
						break;
					case 30:
					case 31:
					case 32:
					case 33:
					case 34:
					case 35:
					case 36:
					case 37:
					case 38:
					case 39:
						this.DataGridView_end_rep_RT_810.Rows[i - 30].Cells[7].ReadOnly = true;
						this.DataGridView_end_rep_RT_810.Rows[i - 30].Cells[7].Value = 0;
						break;
					case 40:
					case 41:
					case 42:
					case 43:
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:
						this.DataGridView_end_rep_RT_810.Rows[i - 40].Cells[9].ReadOnly = true;
						this.DataGridView_end_rep_RT_810.Rows[i - 40].Cells[9].Value = 0;
						break;
					}
				}
			}
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00327B20 File Offset: 0x00325F20
		private bool Entrada_Digital_Ja_Utilizada(int entrada, int num_ED)
		{
			int num = 0;
			checked
			{
				if (entrada != RT_geral.RT_810_BD.config_ED[num_ED].Indice_padrao)
				{
					int num2 = 0;
					do
					{
						if (entrada == RT_geral.RT_810_BD.config_ED[num2].Indice)
						{
							num++;
						}
						num2++;
					}
					while (num2 <= 7);
				}
				return num > 1;
			}
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00327B78 File Offset: 0x00325F78
		private void RT_810_conf_FormClosed(object sender, FormClosedEventArgs e)
		{
			RT_geral.Telas_RT_810.Configuracao = false;
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00327B88 File Offset: 0x00325F88
		private bool Endereco_Repetidora_Ja_Existente(ref DataGridView obj, ref RT_geral.Integer_ictel dado, DataGridViewCellValidatingEventArgs e, int posicao)
		{
			checked
			{
				if (dado.Valor != 0)
				{
					int num = 0;
					while (posicao == num || RT_geral.RT_810_BD.Repetidoras[num].Valor != dado.Valor)
					{
						num++;
						if (num > 49)
						{
							goto IL_A2;
						}
					}
					obj.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
					Interaction.MsgBox(Operators.AddObject(Operators.AddObject("Endereço : ", e.FormattedValue), " já existe"), 32, "Erro na entrada de dados");
					dado.erro = true;
					return true;
				}
				IL_A2:
				obj.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
				dado.erro = false;
				return false;
			}
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00327C74 File Offset: 0x00326074
		public void Leitura_RT_810_conf()
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
			Comunicacao.Ctrl_Com.Cont_rx = 0;
			this.InicializaBarraProgressoTela_RT_810(6);
			this.AtualizaMsgTela_RT_810("Identificando equipamento - Passo 1", 2);
			if (!Mod_MD.Leitura_pagina_multi_interface(0, 255, 12).Status)
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
			Linha_RT.Atualiza_dados_RT_810(0);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 2", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			Application.DoEvents();
			if (!Mod_MD.Leitura_pagina_multi_interface(2048, 255, 39).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_810(2048);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 3", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			Application.DoEvents();
			if (!Mod_MD.Leitura_pagina_multi_interface(4096, RT_geral.RT_810_BD.End_estacao.Valor, 52).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_810(4096);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 4", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			Application.DoEvents();
			if (!Mod_MD.Leitura_pagina_multi_interface(8192, RT_geral.RT_810_BD.End_estacao.Valor, 1).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_810(8192);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 5", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			Application.DoEvents();
			if (!Mod_MD.Leitura_pagina_multi_interface(10240, RT_geral.RT_810_BD.End_estacao.Valor, 2).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_810(10240);
			this.Atualiza_TelaRT810();
			this.AtualizaMsgTela_RT_810("Configuração lida com sucesso", 0);
			this.ToolStripProgressBar_RT_810.PerformStep();
			Application.DoEvents();
			this.Timer_limpa_MSG.Enabled = true;
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00327EB8 File Offset: 0x003262B8
		public void Gravar_RT_810_conf()
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
			Comunicacao.Ctrl_Com.Cont_rx = 0;
			this.InicializaBarraProgressoTela_RT_810(6);
			this.AtualizaMsgTela_RT_810("Verificando equipamento - Passo 1", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(0, 255, 12).Status)
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
			Linha_RT.Atualiza_dados_RT_810(0);
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
			if (!Mod_MD.Escrita_pagina_multi_interface(2048, 0).Status)
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
			this.AtualizaMsgTela_RT_810("Gravando configuração - Passo 4", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Controle_escrita_multi_interface(21845).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro ao habilitar gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Escrita_pagina_multi_interface(4096, 0).Status)
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
			this.AtualizaMsgTela_RT_810("Gravando configuração - Passo 5", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Controle_escrita_multi_interface(21845).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro ao habilitar gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Escrita_pagina_multi_interface(8192, 0).Status)
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
			this.AtualizaMsgTela_RT_810("Gravando configuração - Passo 6", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Controle_escrita_multi_interface(21845).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro ao habilitar gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Escrita_pagina_multi_interface(10240, 0).Status)
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

		// Token: 0x0600135F RID: 4959 RVA: 0x00328214 File Offset: 0x00326614
		private void ToolStripButton_RT_810_Download_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.Config_sistema.tipo_interface == 1)
			{
				if (Comunicacao.VerificaPortaSerialExiste())
				{
					this.Bloqueia_acoes();
					this.EncerraEdicaoDeCampos();
					this.Leitura_RT_810_conf();
				}
				else
				{
					Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", 16, "Atenção");
				}
			}
			else if (Comunicacao.Config_sistema.tipo_interface == 2)
			{
				this.Bloqueia_acoes();
				this.EncerraEdicaoDeCampos();
				this.Leitura_RT_810_conf();
			}
			else
			{
				Interaction.MsgBox("Não existe definição de tipo de interface de comunicação!\r\nComando não executado!", 16, "Atenção");
			}
			Comunicacao.Config_sistema.endereco_encontrado = false;
			Comunicacao.Config_sistema.endereco_modbus = 0;
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x003282AC File Offset: 0x003266AC
		private void ToolStripButton_RT_810_novo_Click(object sender, EventArgs e)
		{
			RT_geral.Lmte_Init_ok = false;
			this.AtivaEfeitoOnChangeValue();
			this.Inicializa_DadosEStruturaRT810_Padrao();
			this.Inicializa_DadosEStruturaRT810_Default();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			RT_geral.RT_810_BD.filename = "";
			this.Atualiza_TelaRT810();
			RT_geral.Lmte_Init_ok = true;
			this.AtualizaMsgTela_RT_810("Valores Default carregados", 0);
			this.Timer_limpa_MSG.Enabled = true;
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00328314 File Offset: 0x00326714
		private void ToolStripButton_RT_810_Upload_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.Config_sistema.tipo_interface == 1)
			{
				if (Comunicacao.VerificaPortaSerialExiste())
				{
					this.Bloqueia_acoes();
					this.EncerraEdicaoDeCampos();
					if (!RT_geral.VerificaExistenciaErroDados_RT810())
					{
						this.Gravar_RT_810_conf();
					}
					else
					{
						string text = "Existem parâmetros não compatíveis com o equipamento!\r\nGravação dos parâmetros foi cancelada.";
						Interaction.MsgBox(text, 16, "Atenção - Valor fora das especificações");
						this.ToolStripButton_RT_810_Salvar.Enabled = true;
					}
				}
				else
				{
					Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", 16, "Atenção");
				}
				this.Timer_limpa_MSG.Enabled = true;
			}
			else if (Comunicacao.Config_sistema.tipo_interface == 2)
			{
				this.Bloqueia_acoes();
				this.EncerraEdicaoDeCampos();
				if (!RT_geral.VerificaExistenciaErroDados_RT810())
				{
					this.Gravar_RT_810_conf();
				}
				else
				{
					string text = "Existem parâmetros não compatíveis com o equipamento!\r\nGravação dos parâmetros foi cancelada.";
					Interaction.MsgBox(text, 16, "Atenção - Valor fora das especificações");
					this.ToolStripButton_RT_810_Salvar.Enabled = true;
				}
				this.Timer_limpa_MSG.Enabled = true;
			}
			else
			{
				Interaction.MsgBox("Não existe definição de tipo de interface de comunicação!\r\nComando não executado!", 16, "Atenção");
			}
			Comunicacao.Config_sistema.endereco_encontrado = false;
			Comunicacao.Config_sistema.endereco_modbus = 0;
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00328418 File Offset: 0x00326818
		[MethodImpl(72)]
		private void ToolStripButton_RT_810_Abrir_Click(object sender, EventArgs e)
		{
			checked
			{
				int num;
				int num10;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					this.AtivaEfeitoOnChangeValue();
					int[] array = new int[651];
					this.OpenFileDialog_RT_810.Filter = "Arquivo de configuração de equipamento|*.Cfg810";
					this.OpenFileDialog_RT_810.InitialDirectory = Linha_RT.diretorio;
					if (this.OpenFileDialog_RT_810.ShowDialog() == 1 && Operators.CompareString(this.OpenFileDialog_RT_810.FileName, "", false) != 0)
					{
						Linha_RT.diretorio = Path.GetDirectoryName(this.OpenFileDialog_RT_810.FileName) + "\\";
						RT_geral.arquivo_extensao = Path.GetExtension(this.OpenFileDialog_RT_810.FileName);
						IniFile iniFile = new IniFile(this.OpenFileDialog_RT_810.FileName);
						RT_geral.RT_810_BD.Equip.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "EQUIPAMENTO", 0);
						RT_geral.RT_810_BD.Versao.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "VERSAO", 0);
						RT_geral.RT_810_BD.Build.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "BUILD", 0);
						RT_geral.RT_810_BD.Release.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "RELEASE", 0);
						if (!Linha_RT.VerificaSeEquipamentoEValido(1, RT_geral.RT_810_BD.Equip.Valor, RT_geral.RT_810_BD.Versao.Valor, RT_geral.RT_810_BD.Build.Valor, RT_geral.RT_810_BD.Release.Valor, RT_geral.arquivo_extensao).Status)
						{
							RT_geral.Lmte_Init_ok = false;
							this.Inicializa_DadosEStruturaRT810_Padrao();
							this.Inicializa_DadosEStruturaRT810_Default();
							Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
							this.Atualiza_TelaRT810();
							RT_geral.Lmte_Init_ok = true;
							this.AtualizaMsgTela_RT_810("Valores Default carregados", 0);
							this.Timer_limpa_MSG.Enabled = true;
							goto IL_A51;
						}
						RT_geral.RT_810_BD.filename = this.OpenFileDialog_RT_810.FileName;
						RT_geral.RT_810_BD.End_estacao.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "ESTACAO", 0);
						RT_geral.RT_810_BD.End_mestre.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "MESTRE", 0);
						Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_810_BD.Modelo, iniFile.ReadInteger("GERAL_DIVERSOS", "MODELO_EMULADO", 0));
						Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_810_BD.Hab_repetidora, iniFile.ReadInteger("REPETIDORA", "MODO_REPETIDORA", 0));
						RT_geral.RT_810_BD.Tempo_ptt.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "TEMPO_PTT", 0);
						RT_geral.RT_810_BD.BaudRateCOM1.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "BAUDRATE_COM1", 0);
						RT_geral.RT_810_BD.BaudRateCOM2.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "BAUDRATE_COM2", 0);
						if (!perifericos.Lista_ValorPermitido(RT_geral.RT_810_BD.BaudRateCOM1.Valor, perifericos.ListaBaudRate))
						{
							RT_geral.RT_810_BD.BaudRateCOM1.Valor = 21857;
						}
						RT_geral.RT_810_BD.BaudRateCOM1.Indice = perifericos.Get_Indice_Pelo_Valor(RT_geral.RT_810_BD.BaudRateCOM1.Valor, perifericos.ListaBaudRate);
						if (!perifericos.Lista_ValorPermitido(RT_geral.RT_810_BD.BaudRateCOM2.Valor, perifericos.ListaBaudRate))
						{
							RT_geral.RT_810_BD.BaudRateCOM2.Valor = 21856;
						}
						RT_geral.RT_810_BD.BaudRateCOM2.Indice = perifericos.Get_Indice_Pelo_Valor(RT_geral.RT_810_BD.BaudRateCOM2.Valor, perifericos.ListaBaudRate);
						Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_810_BD.Modo_de_operacao, iniFile.ReadInteger("GERAL_MODO_OPERCAO", "MODO", 0));
						RT_geral.RT_810_BD.Intervalo_tx_pto_pto.Valor = iniFile.ReadInteger("GERAL_MODO_OPERCAO", "INTERVALO", 0);
						RT_geral.RT_810_BD.AD_Intervalo.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "INTERVALO", 0);
						RT_geral.RT_810_BD.AD_Tamanho_filtro.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "TAMANHO_FILTRO", 0);
						int i = 0;
						do
						{
							string text = string.Format("ENTRADA_ANALOGICA_{0}", i + 1);
							RT_geral.RT_810_BD.EA_Range[i].Valor = iniFile.ReadInteger(text, "EA_RANGE", 0);
							RT_geral.RT_810_BD.EA_Inicio[i].Valor = iniFile.ReadInteger(text, "EA_INICIO", 0);
							RT_geral.RT_810_BD.EA_Fim[i].Valor = iniFile.ReadInteger(text, "EA_FIM", 0);
							i++;
						}
						while (i <= 3);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_810_BD.ctrl_acionamento[0], RT_geral.RT_810_DataGrigViewProcessosColunas[0], iniFile.ReadInteger("CFG_CONTROLE", "ACIONAMENTO", 0));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_810_BD.ctrl_ret_acionamento[0], RT_geral.RT_810_DataGrigViewProcessosColunas[1], iniFile.ReadInteger("CFG_CONTROLE", "RET_ACIONAMENTO", 0));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_810_BD.ctrl_ED_selecao[0], RT_geral.RT_810_DataGrigViewProcessosColunas[2], iniFile.ReadInteger("CFG_CONTROLE", "SELECAO_REMOTO", 0));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_810_BD.ctrl_reverso[0], RT_geral.RT_810_DataGrigViewProcessosColunas[3], iniFile.ReadInteger("CFG_CONTROLE", "SELECAO_REVERSO", 0));
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_810_BD.ctrl_modo[0], RT_geral.RT_810_DataGrigViewProcessosColunas[4], iniFile.ReadInteger("CFG_CONTROLE", "MODO_CONTROLE", 0));
						RT_geral.RT_810_BD.ctrl_tempo_max_partida[0].Valor = iniFile.ReadInteger("CFG_CONTROLE", "TEMPO_MAX_PARTIDA", 0);
						RT_geral.RT_810_BD.ctrl_tempo_max_parada[0].Valor = iniFile.ReadInteger("CFG_CONTROLE", "TEMPO_MAX_PARADA", 0);
						i = 0;
						do
						{
							string text = string.Format("CFG{0}_ED", i + 1);
							Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_810_BD.config_ED[i], RT_geral.RT_810_DataGrigViewEDColunas[0], iniFile.ReadInteger("ENTRADA_DIGITAL", text, 0));
							i++;
						}
						while (i <= 7);
						RT_geral.RT_810_BD.Hab_eletrodos.Valor = iniFile.ReadInteger("GERAL_DIVERSOS", "HAB_ELETRODO", 0);
						RT_geral.RT_810_BD.End_repetidora.Valor = iniFile.ReadInteger("REPETIDORA", "ENDERECO", 0);
						RT_geral.RT_810_BD.Num_repetidoras.Valor = iniFile.ReadInteger("REPETIDORA", "NUMERO_REPETIDORAS", 0);
						i = 0;
						do
						{
							string text = string.Format("RPT{0}", i + 1);
							RT_geral.RT_810_BD.Repetidoras[i].Valor = iniFile.ReadInteger("REPETIDORA", text, 0);
							i++;
						}
						while (i <= 49);
						Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_810_BD.Setpoints_ctrl_variavel[0], RT_geral.RT_810_DataGrigViewSetpointsColunas[0], iniFile.ReadInteger("SETPOINT", "CTRL_VARIAVEL", 0));
						RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[0].Valor = iniFile.ReadInteger("SETPOINT", "NIVEL_ALTO", 0);
						RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[0].Valor = iniFile.ReadInteger("SETPOINT", "NIVEL_BAIXO", 0);
						string text2 = "";
						int num2 = array[96];
						int num3 = 97;
						int num4 = 0;
						int num5 = num2 - 1;
						for (i = num4; i <= num5; i++)
						{
							text2 += Conversions.ToString(Strings.Chr(array[num3 + i]));
						}
						this.TextBox_nome_RT810.Text = iniFile.ReadText("GERAL_DESCRICAO", "NOME", "");
						num3 += i;
						num2 = array[num3];
						num3++;
						text2 = "";
						int num6 = 0;
						int num7 = num2 - 1;
						for (i = num6; i <= num7; i++)
						{
							text2 += Conversions.ToString(Strings.Chr(array[num3 + i]));
						}
						this.TextBox_endereco_RT810.Text = iniFile.ReadText("GERAL_DESCRICAO", "ENDERECO", "");
						num3 += i;
						num2 = array[num3];
						num3++;
						text2 = "";
						int num8 = 0;
						int num9 = num2 - 1;
						for (i = num8; i <= num9; i++)
						{
							text2 += Conversions.ToString(Strings.Chr(array[num3 + i]));
						}
						this.TextBox_comentarios_RT810.Text = iniFile.ReadText("GERAL_DESCRICAO", "COMENTARIO", "");
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
						this.Atualiza_TelaRT810();
						this.AtualizaMsgTela_RT_810("Arquivo carregado com sucesso!", 0);
					}
					this.Timer_limpa_MSG.Enabled = true;
					goto IL_A51;
					IL_9D8:
					Interaction.MsgBox("Não foi possível carregar os dados", 32, "Atenção - Erro I/0");
					FileSystem.FileClose(new int[]
					{
						1
					});
					this.Timer_limpa_MSG.Enabled = true;
					goto IL_A51;
					IL_A0C:
					num10 = -1;
										IL_A22:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num10 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_A0C;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_A51:
				if (num10 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00328E9C File Offset: 0x0032729C
		[MethodImpl(72)]
		private void ToolStripButton_RT_810_Salvar_Click(object sender, EventArgs e)
		{
			checked
			{
				int num;
				int num11;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					int[] array = new int[651];
					this.AtivaEfeitoOnChangeValue();
					int i = 0;
					do
					{
						array[i] = 0;
						i++;
					}
					while (i <= 110);
					this.Bloqueia_acoes();
					array[0] = RT_geral.RT_810_BD.Equip.Valor;
					array[1] = RT_geral.RT_810_BD.Versao.Valor;
					array[2] = RT_geral.RT_810_BD.Build.Valor;
					array[3] = RT_geral.RT_810_BD.Release.Valor;
					array[4] = RT_geral.RT_810_BD.End_estacao.Valor;
					array[5] = RT_geral.RT_810_BD.End_mestre.Valor;
					array[6] = RT_geral.RT_810_BD.Modelo.Valor;
					array[7] = RT_geral.RT_810_BD.Hab_repetidora.Valor;
					array[8] = RT_geral.RT_810_BD.Tempo_ptt.Valor;
					array[9] = RT_geral.RT_810_BD.Modo_de_operacao.Valor;
					array[10] = RT_geral.RT_810_BD.Intervalo_tx_pto_pto.Valor;
					array[11] = RT_geral.RT_810_BD.AD_Intervalo.Valor;
					array[12] = RT_geral.RT_810_BD.AD_Tamanho_filtro.Valor;
					i = 0;
					do
					{
						array[13 + i] = RT_geral.RT_810_BD.EA_Range[i].Valor;
						array[17 + i] = RT_geral.RT_810_BD.EA_Inicio[i].Valor;
						array[21 + i] = RT_geral.RT_810_BD.EA_Fim[i].Valor;
						i++;
					}
					while (i <= 3);
					array[25] = RT_geral.RT_810_BD.ctrl_acionamento[0].Valor;
					array[26] = RT_geral.RT_810_BD.ctrl_ret_acionamento[0].Valor;
					array[27] = RT_geral.RT_810_BD.ctrl_ED_selecao[0].Valor;
					array[28] = RT_geral.RT_810_BD.ctrl_reverso[0].Valor;
					array[29] = RT_geral.RT_810_BD.ctrl_modo[0].Valor;
					array[30] = RT_geral.RT_810_BD.ctrl_tempo_max_partida[0].Valor;
					array[31] = RT_geral.RT_810_BD.ctrl_tempo_max_parada[0].Valor;
					i = 0;
					do
					{
						array[32 + i] = RT_geral.RT_810_BD.config_ED[i].Valor;
						i++;
					}
					while (i <= 7);
					array[40] = RT_geral.RT_810_BD.Hab_eletrodos.Valor;
					array[41] = RT_geral.RT_810_BD.End_repetidora.Valor;
					array[42] = RT_geral.RT_810_BD.Num_repetidoras.Valor;
					i = 0;
					do
					{
						array[43 + i] = RT_geral.RT_810_BD.Repetidoras[i].Valor;
						i++;
					}
					while (i <= 49);
					array[93] = RT_geral.RT_810_BD.Setpoints_ctrl_variavel[0].Valor;
					array[94] = RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[0].Valor;
					array[95] = RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[0].Valor;
					int num2 = 96;
					int textLength = this.TextBox_nome_RT810.TextLength;
					array[num2] = textLength;
					num2++;
					char[] array2 = this.TextBox_nome_RT810.Text.ToCharArray();
					int num3 = 0;
					int num4 = textLength - 1;
					for (i = num3; i <= num4; i++)
					{
						array[num2 + i] = (int)array2[i];
					}
					num2 += i;
					textLength = this.TextBox_endereco_RT810.TextLength;
					array[num2] = textLength;
					num2++;
					char[] array3 = this.TextBox_endereco_RT810.Text.ToCharArray();
					int num5 = 0;
					int num6 = textLength - 1;
					for (i = num5; i <= num6; i++)
					{
						array[num2 + i] = (int)array3[i];
					}
					num2 += i;
					textLength = this.TextBox_comentarios_RT810.TextLength;
					array[num2] = textLength;
					num2++;
					char[] array4 = this.TextBox_comentarios_RT810.Text.ToCharArray();
					int num7 = 0;
					int num8 = textLength - 1;
					for (i = num7; i <= num8; i++)
					{
						array[num2 + i] = (int)array4[i];
					}
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
						RT_geral.RT_810_BD.filename = this.SaveFileDialog_RT_810.FileName;
						this.InicializaBarraProgressoTela_RT_810(12);
						IniFileWriteFast iniFileWriteFast = new IniFileWriteFast(this.SaveFileDialog_RT_810.FileName);
						iniFileWriteFast.WriteSection("GERAL_INFORMACAO");
						iniFileWriteFast.WriteKey("EQUIPAMENTO", RT_geral.RT_810_BD.Equip.Valor);
						iniFileWriteFast.WriteKey("VERSAO", RT_geral.RT_810_BD.Versao.Valor);
						iniFileWriteFast.WriteKey("BUILD", RT_geral.RT_810_BD.Build.Valor);
						iniFileWriteFast.WriteKey("RELEASE", RT_geral.RT_810_BD.Release.Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("GERAL_PARAM_COMINICACAO");
						iniFileWriteFast.WriteKey("ESTACAO", RT_geral.RT_810_BD.End_estacao.Valor);
						iniFileWriteFast.WriteKey("MESTRE", RT_geral.RT_810_BD.End_mestre.Valor);
						iniFileWriteFast.WriteKey("TEMPO_PTT", RT_geral.RT_810_BD.Tempo_ptt.Valor);
						iniFileWriteFast.WriteKey("BAUDRATE_COM1", RT_geral.RT_810_BD.BaudRateCOM1.Valor);
						iniFileWriteFast.WriteKey("BAUDRATE_COM2", RT_geral.RT_810_BD.BaudRateCOM2.Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("GERAL_MODO_OPERCAO");
						iniFileWriteFast.WriteKey("MODO", RT_geral.RT_810_BD.Modo_de_operacao.Valor);
						iniFileWriteFast.WriteKey("INTERVALO", RT_geral.RT_810_BD.Intervalo_tx_pto_pto.Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("GERAL_DESCRICAO");
						iniFileWriteFast.WriteKey("NOME", this.TextBox_nome_RT810.Text);
						iniFileWriteFast.WriteKey("ENDERECO", this.TextBox_endereco_RT810.Text);
						iniFileWriteFast.WriteKey("COMENTARIO", this.TextBox_comentarios_RT810.Text);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("GERAL_DIVERSOS");
						iniFileWriteFast.WriteKey("MODELO_EMULADO", RT_geral.RT_810_BD.Modelo.Valor);
						iniFileWriteFast.WriteKey("HAB_ELETRODO", RT_geral.RT_810_BD.Hab_eletrodos.Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("CFG_CONTROLE");
						iniFileWriteFast.WriteKey("ACIONAMENTO", RT_geral.RT_810_BD.ctrl_acionamento[0].Valor);
						iniFileWriteFast.WriteKey("RET_ACIONAMENTO", RT_geral.RT_810_BD.ctrl_ret_acionamento[0].Valor);
						iniFileWriteFast.WriteKey("SELECAO_REMOTO", RT_geral.RT_810_BD.ctrl_ED_selecao[0].Valor);
						iniFileWriteFast.WriteKey("SELECAO_REVERSO", RT_geral.RT_810_BD.ctrl_reverso[0].Valor);
						iniFileWriteFast.WriteKey("MODO_CONTROLE", RT_geral.RT_810_BD.ctrl_modo[0].Valor);
						iniFileWriteFast.WriteKey("TEMPO_MAX_PARTIDA", RT_geral.RT_810_BD.ctrl_tempo_max_partida[0].Valor);
						iniFileWriteFast.WriteKey("TEMPO_MAX_PARADA", RT_geral.RT_810_BD.ctrl_tempo_max_parada[0].Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("ENTRADA_ANALOGICA");
						iniFileWriteFast.WriteKey("INTERVALO", RT_geral.RT_810_BD.AD_Intervalo.Valor);
						iniFileWriteFast.WriteKey("TAMANHO_FILTRO", RT_geral.RT_810_BD.AD_Tamanho_filtro.Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						i = 0;
						do
						{
							string text = string.Format("ENTRADA_ANALOGICA_{0}", i + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("EA_RANGE", RT_geral.RT_810_BD.EA_Range[i].Valor);
							iniFileWriteFast.WriteKey("EA_INICIO", RT_geral.RT_810_BD.EA_Inicio[i].Valor);
							iniFileWriteFast.WriteKey("EA_FIM", RT_geral.RT_810_BD.EA_Fim[i].Valor);
							iniFileWriteFast.LineSpace();
							i++;
						}
						while (i <= 3);
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("ENTRADA_DIGITAL");
						i = 0;
						do
						{
							string text = string.Format("CFG{0}_ED", i + 1);
							iniFileWriteFast.WriteKey(text, RT_geral.RT_810_BD.config_ED[i].Valor);
							i++;
						}
						while (i <= 7);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("SETPOINT");
						iniFileWriteFast.WriteKey("CTRL_VARIAVEL", RT_geral.RT_810_BD.Setpoints_ctrl_variavel[0].Valor);
						iniFileWriteFast.WriteKey("NIVEL_ALTO", RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[0].Valor);
						iniFileWriteFast.WriteKey("NIVEL_BAIXO", RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[0].Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("REPETIDORA");
						iniFileWriteFast.WriteKey("MODO_REPETIDORA", RT_geral.RT_810_BD.Hab_repetidora.Valor);
						iniFileWriteFast.WriteKey("ENDERECO", RT_geral.RT_810_BD.End_repetidora.Valor);
						iniFileWriteFast.WriteKey("NUMERO_REPETIDORAS", RT_geral.RT_810_BD.Num_repetidoras.Valor);
						int num9 = 0;
						int num10 = RT_geral.RT_810_BD.Num_repetidoras.Valor - 1;
						for (i = num9; i <= num10; i++)
						{
							string text = string.Format("RPT{0}", i + 1);
							iniFileWriteFast.WriteKey(text, RT_geral.RT_810_BD.Repetidoras[i].Valor);
						}
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
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
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						this.AtualizaMsgTela_RT_810("Arquivo gerado com sucesso!", 0);
						this.Timer_limpa_MSG.Enabled = true;
					}
					this.Timer_limpa_MSG.Enabled = true;
					goto IL_CFC;
					IL_C83:
					Interaction.MsgBox("Não foi possível gravar os dados", 32, "Atenção - Erro I/0");
					FileSystem.FileClose(new int[]
					{
						1
					});
					this.Timer_limpa_MSG.Enabled = true;
					goto IL_CFC;
					IL_CB7:
					num11 = -1;
										IL_CCD:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num11 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_CB7;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_CFC:
				if (num11 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00329BCC File Offset: 0x00327FCC
		private void DataGridView_setpoints_810_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_setpoints_810.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_Set_Controle", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_setpoints_810.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_810_DataGrigViewSetpointsColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					for (int i = num; i <= num2; i++)
					{
						if (Operators.CompareString(RT_geral.RT_810_DataGrigViewSetpointsColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							RT_geral.RT_810_BD.Setpoints_ctrl_variavel[e.RowIndex].Valor = RT_geral.RT_810_DataGrigViewSetpointsColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_810_BD.Setpoints_ctrl_variavel[e.RowIndex].Indice = i;
							break;
						}
					}
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NAlto", false) == 0)
				{
					this.DataGridView_setpoints_810.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_setpoints_810.Rows[e.RowIndex].Cells[2].Value));
					RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_setpoints_810.Rows[e.RowIndex].Cells[2].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NBaixo", false) == 0)
				{
					this.DataGridView_setpoints_810.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_setpoints_810.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_setpoints_810.Rows[e.RowIndex].Cells[1].Value);
				}
			}
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00329E48 File Offset: 0x00328248
		private void DataGridView_setpoints_810_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_setpoints_810.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_Set_NAlto", false) == 0)
				{
					RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NBaixo", false) == 0)
				{
					RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00329F44 File Offset: 0x00328344
		private void DataGridView_setpoints_810_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_setpoints_810.IsCurrentCellDirty)
			{
				this.DataGridView_setpoints_810.CommitEdit(512);
			}
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00329F64 File Offset: 0x00328364
		private void DataGridView_processo_810_P1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_processo_810_P1.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_SDAciona", false) != 0)
			{
				if (Operators.CompareString(dataPropertyName, "Col_EDRetAci", false) != 0)
				{
					if (Operators.CompareString(dataPropertyName, "Col_EDRemoto", false) != 0)
					{
						if (Operators.CompareString(dataPropertyName, "Col_Reverso", false) != 0)
						{
							if (Operators.CompareString(dataPropertyName, "Col_ModoCtrl", false) != 0)
							{
								if (Operators.CompareString(dataPropertyName, "Col_TpMaxPart", false) == 0)
								{
									this.DataGridView_processo_810_P1.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_processo_810_P1.Rows[e.RowIndex].Cells[5].Value));
									RT_geral.RT_810_BD.ctrl_tempo_max_partida[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_processo_810_P1.Rows[e.RowIndex].Cells[5].Value);
									return;
								}
								if (Operators.CompareString(dataPropertyName, "Col_TpMaxParada", false) == 0)
								{
									this.DataGridView_processo_810_P1.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_processo_810_P1.Rows[e.RowIndex].Cells[6].Value));
									RT_geral.RT_810_BD.ctrl_tempo_max_parada[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_processo_810_P1.Rows[e.RowIndex].Cells[6].Value);
									return;
								}
								return;
							}
						}
					}
				}
			}
			string text = Conversions.ToString(this.DataGridView_processo_810_P1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_810_DataGrigViewProcessosColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
				int i = num;
				while (i <= num2)
				{
					if (Operators.CompareString(RT_geral.RT_810_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
					{
						string dataPropertyName2 = this.DataGridView_processo_810_P1.Columns[e.ColumnIndex].DataPropertyName;
						if (Operators.CompareString(dataPropertyName2, "Col_SDAciona", false) == 0)
						{
							RT_geral.RT_810_BD.ctrl_acionamento[e.RowIndex].Valor = RT_geral.RT_810_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_810_BD.ctrl_acionamento[e.RowIndex].Indice = i;
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_EDRetAci", false) == 0)
						{
							if (RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_810_BD.ctrl_ret_acionamento[e.RowIndex], ref RT_geral.RT_810_DataGrigViewProcessosColunas[e.ColumnIndex], 1, ref RT_geral.RT_810_BD.ctrl_ED_selecao, "", "", "") | RT_geral.VerificaEDJaUtilizada_FuncoesEspeciais(i, RT_geral.RT_810_BD.config_ED, ""))
							{
								this.DataGridView_processo_810_P1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_810_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_810_BD.ctrl_ret_acionamento[e.RowIndex].Indice_padrao];
								break;
							}
							RT_geral.RT_810_BD.ctrl_ret_acionamento[e.RowIndex].Valor = RT_geral.RT_810_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_810_BD.ctrl_ret_acionamento[e.RowIndex].Indice = i;
							break;
						}
						else if (Operators.CompareString(dataPropertyName2, "Col_EDRemoto", false) == 0)
						{
							if (RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_810_BD.ctrl_ED_selecao[e.RowIndex], ref RT_geral.RT_810_DataGrigViewProcessosColunas[e.ColumnIndex], 1, ref RT_geral.RT_810_BD.ctrl_ret_acionamento, "", "", "") | RT_geral.VerificaEDJaUtilizada_FuncoesEspeciais(i, RT_geral.RT_810_BD.config_ED, ""))
							{
								this.DataGridView_processo_810_P1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_810_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_810_BD.ctrl_ED_selecao[e.RowIndex].Indice_padrao];
								break;
							}
							RT_geral.RT_810_BD.ctrl_ED_selecao[e.RowIndex].Valor = RT_geral.RT_810_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_810_BD.ctrl_ED_selecao[e.RowIndex].Indice = i;
							break;
						}
						else
						{
							if (Operators.CompareString(dataPropertyName2, "Col_Reverso", false) == 0)
							{
								RT_geral.RT_810_BD.ctrl_reverso[e.RowIndex].Valor = RT_geral.RT_810_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_810_BD.ctrl_reverso[e.RowIndex].Indice = i;
								break;
							}
							if (Operators.CompareString(dataPropertyName2, "Col_ModoCtrl", false) == 0)
							{
								RT_geral.RT_810_BD.ctrl_modo[e.RowIndex].Valor = RT_geral.RT_810_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_810_BD.ctrl_modo[e.RowIndex].Indice = i;
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

		// Token: 0x06001368 RID: 4968 RVA: 0x0032A560 File Offset: 0x00328960
		private void DataGridView_processo_810_P1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_processo_810_P1.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_TpMaxPart", false) == 0)
				{
					RT_geral.RT_810_BD.ctrl_tempo_max_partida[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_BD.ctrl_tempo_max_partida[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_TpMaxParada", false) == 0)
				{
					RT_geral.RT_810_BD.ctrl_tempo_max_parada[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_BD.ctrl_tempo_max_parada[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x0032A65C File Offset: 0x00328A5C
		private void DataGridView_processo_810_P1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_processo_810_P1.IsCurrentCellDirty)
			{
				this.DataGridView_processo_810_P1.CommitEdit(512);
			}
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x0032A67C File Offset: 0x00328A7C
		private void DataGridView_end_rep_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			string dataPropertyName = this.DataGridView_end_rep_RT_810.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_End_01_10", false) == 0)
				{
					int num = 0;
					this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_810_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_End_11_20", false) == 0)
				{
					int num = 10;
					this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_810_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[3].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_End_21_30", false) == 0)
				{
					int num = 20;
					this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_810_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[5].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_End_31_40", false) == 0)
				{
					int num = 30;
					this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[7].Value));
					RT_geral.RT_810_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[7].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_End_41_50", false) == 0)
				{
					int num = 40;
					this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[9].Value));
					RT_geral.RT_810_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[9].Value);
				}
			}
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x0032AA50 File Offset: 0x00328E50
		private void DataGridView_end_rep_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_end_rep_RT_810.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_End_01_10", false) == 0)
				{
					int num = 0;
					RT_geral.RT_810_BD.Repetidoras[num + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_BD.Repetidoras[num + e.RowIndex], e, true);
					sender = dataGridView;
					dataGridView = (DataGridView)sender;
					this.Endereco_Repetidora_Ja_Existente(ref dataGridView, ref RT_geral.RT_810_BD.Repetidoras[num + e.RowIndex], e, num + e.RowIndex);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_End_11_20", false) == 0)
				{
					int num = 10;
					RT_geral.RT_810_BD.Repetidoras[num + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_BD.Repetidoras[num + e.RowIndex], e, true);
					sender = dataGridView;
					dataGridView = (DataGridView)sender;
					this.Endereco_Repetidora_Ja_Existente(ref dataGridView, ref RT_geral.RT_810_BD.Repetidoras[num + e.RowIndex], e, num + e.RowIndex);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_End_21_30", false) == 0)
				{
					int num = 20;
					RT_geral.RT_810_BD.Repetidoras[num + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_BD.Repetidoras[num + e.RowIndex], e, true);
					sender = dataGridView;
					dataGridView = (DataGridView)sender;
					this.Endereco_Repetidora_Ja_Existente(ref dataGridView, ref RT_geral.RT_810_BD.Repetidoras[num + e.RowIndex], e, num + e.RowIndex);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_End_31_40", false) == 0)
				{
					int num = 30;
					RT_geral.RT_810_BD.Repetidoras[num + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_BD.Repetidoras[num + e.RowIndex], e, true);
					sender = dataGridView;
					dataGridView = (DataGridView)sender;
					this.Endereco_Repetidora_Ja_Existente(ref dataGridView, ref RT_geral.RT_810_BD.Repetidoras[num + e.RowIndex], e, num + e.RowIndex);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_End_41_50", false) == 0)
				{
					int num = 40;
					RT_geral.RT_810_BD.Repetidoras[num + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_BD.Repetidoras[num + e.RowIndex], e, true);
					sender = dataGridView;
					dataGridView = (DataGridView)sender;
					this.Endereco_Repetidora_Ja_Existente(ref dataGridView, ref RT_geral.RT_810_BD.Repetidoras[num + e.RowIndex], e, num + e.RowIndex);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x0032ADC8 File Offset: 0x003291C8
		private void DataGridView_end_rep_RT_810_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_end_rep_RT_810.IsCurrentCellDirty)
			{
				this.DataGridView_end_rep_RT_810.CommitEdit(512);
			}
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x0032ADE8 File Offset: 0x003291E8
		private void DataGridView_parametros_EA_810_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_parametros_EA_810.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "EA_range", false) == 0)
			{
				this.DataGridView_parametros_EA_810.Rows[e.RowIndex].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_parametros_EA_810.Rows[e.RowIndex].Cells[0].Value));
				RT_geral.RT_810_BD.EA_Range[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_parametros_EA_810.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(dataPropertyName, "EA_inicio_medida", false) == 0)
			{
				this.DataGridView_parametros_EA_810.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_parametros_EA_810.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_810_BD.EA_Inicio[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_parametros_EA_810.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(dataPropertyName, "EA_fim_medida", false) == 0)
			{
				this.DataGridView_parametros_EA_810.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_parametros_EA_810.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_810_BD.EA_Fim[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_parametros_EA_810.Rows[e.RowIndex].Cells[2].Value);
			}
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x0032B03C File Offset: 0x0032943C
		private void DataGridView_parametros_EA_810_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_parametros_EA_810.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_range", false) == 0)
				{
					RT_geral.RT_810_BD.EA_Range[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_BD.EA_Range[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_ini", false) == 0)
				{
					RT_geral.RT_810_BD.EA_Inicio[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_BD.EA_Inicio[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_fim", false) == 0)
				{
					RT_geral.RT_810_BD.EA_Fim[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_BD.EA_Fim[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x0032B1A4 File Offset: 0x003295A4
		private void DataGridView_parametros_EA_810_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_parametros_EA_810.IsCurrentCellDirty)
			{
				this.DataGridView_parametros_EA_810.CommitEdit(512);
			}
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x0032B1C4 File Offset: 0x003295C4
		private void DataGridView_RT810_ED_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_RT810_ED.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_Entrada", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_RT810_ED.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_810_DataGrigViewEDColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					int i = num;
					while (i <= num2)
					{
						if (Operators.CompareString(RT_geral.RT_810_DataGrigViewEDColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							string dataPropertyName2 = this.DataGridView_RT810_ED.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName2, "Col_Entrada", false) == 0)
							{
								if (!RT_geral.VerificaFuncaoJaUtilizada(i, e.RowIndex, RT_geral.RT_810_BD.config_ED, 0) & !RT_geral.VerificaEDdaFuncaoJaUtilizada(e.RowIndex + 1, i, 1, ref RT_geral.RT_810_BD.ctrl_ret_acionamento) & !RT_geral.VerificaEDdaFuncaoJaUtilizada(e.RowIndex + 1, i, 1, ref RT_geral.RT_810_BD.ctrl_ED_selecao))
								{
									RT_geral.RT_810_BD.config_ED[e.RowIndex].Valor = RT_geral.RT_810_DataGrigViewEDColunas[e.ColumnIndex].LinhasValor[i];
									RT_geral.RT_810_BD.config_ED[e.RowIndex].Indice = i;
								}
								else
								{
									this.DataGridView_RT810_ED.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_810_DataGrigViewEDColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_810_BD.config_ED[e.RowIndex].Indice_padrao];
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

		// Token: 0x06001371 RID: 4977 RVA: 0x0032B3BC File Offset: 0x003297BC
		private void DataGridView_RT810_ED_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_RT810_ED.IsCurrentCellDirty)
			{
				this.DataGridView_RT810_ED.CommitEdit(512);
			}
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x0032B3DC File Offset: 0x003297DC
		private void ToolStripButton_RT_810_Imprimir_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			using (EnhancedPrintPreviewDialog enhancedPrintPreviewDialog = new EnhancedPrintPreviewDialog())
			{
				enhancedPrintPreviewDialog.Document = this.PrintDocument1;
				enhancedPrintPreviewDialog.ShowDialog();
			}
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0032B424 File Offset: 0x00329824
		private void TextBox_comentarios_RT810_TextChanged(object sender, EventArgs e)
		{
			int num = this.TextBox_comentarios_RT810.Lines.Length;
			checked
			{
				if (num > 0)
				{
					int num2 = Strings.Len(this.TextBox_comentarios_RT810.Lines[num - 1]);
					if (num2 > 60)
					{
						this.TextBox_comentarios_RT810.Text = this.TextBox_comentarios_RT810.Text + "\r\n";
						this.TextBox_comentarios_RT810.Select(Strings.Len(this.TextBox_comentarios_RT810.Text), 0);
					}
				}
				int num3 = Strings.Len(this.TextBox_comentarios_RT810.Text) - Strings.Len(Strings.Replace(this.TextBox_comentarios_RT810.Text, "\r\n", "\r", 1, -1, 0));
				if (num3 > 7)
				{
					Interaction.MsgBox("Número máximo de linhas atingido", 0, null);
				}
			}
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x0032B4E0 File Offset: 0x003298E0
		[MethodImpl(72)]
		private void DesenhaRelatorioRT810(PrintPageEventArgs z)
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_810_BD.Equip.Valor, RT_geral.RT_810_BD.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 5, "Dados da Estação", true);
			tabelaLinhaInteria.EscreveTituloValorLinha(1, "Local de Instalação", this.TextBox_nome_RT810.Text, 0, 160);
			tabelaLinhaInteria.EscreveTituloValorLinha(2, "Endereço", this.TextBox_endereco_RT810.Text, 0, 90);
			string valor = string.Concat(new string[]
			{
				"RT",
				RT_geral.RT_810_BD.Equip.Valor.ToString(),
				"_",
				RT_geral.RT_810_BD.Versao.Valor.ToString(),
				string.Format("{0:D2}", RT_geral.RT_810_BD.Build.Valor),
				"  R",
				RT_geral.RT_810_BD.Release.Valor.ToString()
			});
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Modelo Simulado", this.ComboBox_modo_simulado_810.Text, 0, 160);
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
			tabelaLinhaInteria.EscreveTituloValorLinha(5, "Arquivo", Path.GetFileName(RT_geral.RT_810_BD.filename), 0, 160);
			int nextLineAvailable = tabelaLinhaInteria.GetNextLineAvailable();
			TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 6, "Dados de Instalação", true);
			tabelaLinhaInteria2.EscreveTituloValorLinha(1, "Tipo de antena", this.CB_TipoAntena.Text, 0, 150);
			tabelaLinhaInteria2.EscreveTituloValorLinha(1, "Azimute", this.T_Azimute.Text + " °", 400, 500);
			tabelaLinhaInteria2.EscreveTituloValorLinha(2, "Polarização", this.CB_PolarizacaoAntena.Text, 0, 150);
			tabelaLinhaInteria2.EscreveTituloValorLinha(2, "Longitude", this.T_Longitude.Text, 400, 500);
			tabelaLinhaInteria2.EscreveTituloValorLinha(3, "Potência do Rádio", this.T_PotRadio.Text + " W", 0, 150);
			tabelaLinhaInteria2.EscreveTituloValorLinha(3, "Latidude:", this.T_Latitude.Text, 400, 500);
			tabelaLinhaInteria2.EscreveTituloValorLinha(4, "Modelo do Rádio", this.CB_ModeloRadio.Text, 0, 150);
			tabelaLinhaInteria2.EscreveTituloValorLinha(4, "Altura", this.T_AlturaAntena.Text + " m", 400, 500);
			tabelaLinhaInteria2.EscreveTituloValorLinha(5, "Distância para Central", this.T_DistCentral.Text + " km", 0, 150);
			tabelaLinhaInteria2.EscreveTituloValorLinha(5, "Modelo da Fonte", this.T_ModeloFonte.Text, 400, 520);
			tabelaLinhaInteria2.EscreveTituloValorLinha(6, "Frequência do Rádio", this.T_FreqRadio.Text + " MHz", 0, 150);
			nextLineAvailable = tabelaLinhaInteria2.GetNextLineAvailable();
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 3, "Parâmetro de Comunicação", true);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(1, "Endereço do Mestre", this.NumericUpDown_end_mestre.Value.ToString(), 0, 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(2, "Endereço da Estação", this.NumericUpDown_end_est.Value.ToString(), 0, 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(3, "Tempo de PTT (ms)", this.NumericUpDown_temp_ptt.Value.ToString() + " ms", 0, 200);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 3, "Parâmetro de Operação", true);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(1, "Método de Operação", this.ComboBox_Modo_Operacao.Text, 0, 140);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(2, "Intervalo de TX Pto\\Pto(s)", this.NumericUpDown_intervalo_tx.Value.ToString() + " s", 0, 170);
			string valor3;
			if (this.CheckBox_Hab_eletrodos.Checked)
			{
				valor3 = "Sim";
			}
			else
			{
				valor3 = "Não";
			}
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(3, "Leitura por Eletrodo", valor3, 0, 170);
			nextLineAvailable = tabelaMeiaLinhaDireita.GetNextLineAvailable();
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 2, "Parâmetro de Interface", true);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(1, "BaudRate COM1", perifericos.ListaBaudRate[RT_geral.RT_810_BD.BaudRateCOM1.Indice].nome_impressao, 0, 170);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(2, "BaudRate COM2", perifericos.ListaBaudRate[RT_geral.RT_810_BD.BaudRateCOM2.Indice].nome_impressao, 0, 170);
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
			string valor4 = "???";
			switch (RT_geral.RT_810_BD.ctrl_acionamento[0].Valor)
			{
			case 21856:
				valor4 = "Desativa";
				break;
			case 21857:
				valor4 = "SD-01";
				break;
			}
			tabelaLinhaInteria3.EscreveValorLinha(3, valor4, 80);
			string valor5 = "???";
			switch (RT_geral.RT_810_BD.ctrl_ret_acionamento[0].Valor)
			{
			case 21856:
				valor5 = "Não usada";
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
			tabelaLinhaInteria3.EscreveValorLinha(3, valor5, 180);
			string valor6 = "???";
			switch (RT_geral.RT_810_BD.ctrl_ED_selecao[0].Valor)
			{
			case 21856:
				valor6 = "Remoto";
				break;
			case 21857:
				valor6 = "ED-01";
				break;
			case 21858:
				valor6 = "ED-02";
				break;
			case 21859:
				valor6 = "ED-03";
				break;
			case 21860:
				valor6 = "ED-04";
				break;
			case 21861:
				valor6 = "ED-05";
				break;
			case 21862:
				valor6 = "ED-06";
				break;
			case 21863:
				valor6 = "ED-07";
				break;
			case 21864:
				valor6 = "ED-08";
				break;
			}
			tabelaLinhaInteria3.EscreveValorLinha(3, valor6, 280);
			string valor7 = "???";
			switch (RT_geral.RT_810_BD.ctrl_reverso[0].Valor)
			{
			case 21856:
				valor7 = "Desab.";
				break;
			case 21857:
				valor7 = "Habilit.";
				break;
			}
			tabelaLinhaInteria3.EscreveValorLinha(3, valor7, 350);
			string valor8 = "???";
			switch (RT_geral.RT_810_BD.ctrl_modo[0].Valor)
			{
			case 21856:
				valor8 = "Telecomando";
				break;
			case 21857:
				valor8 = "Automático";
				break;
			}
			tabelaLinhaInteria3.EscreveValorLinha(3, valor8, 430);
			tabelaLinhaInteria3.EscreveValorLinha(3, RT_geral.RT_810_BD.ctrl_tempo_max_partida[0].Valor.ToString(), 530);
			tabelaLinhaInteria3.EscreveValorLinha(3, RT_geral.RT_810_BD.ctrl_tempo_max_parada[0].Valor.ToString(), 590);
			nextLineAvailable = tabelaLinhaInteria3.GetNextLineAvailable();
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda3 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 2, "Filtro EA", true);
			tabelaMeiaLinhaEsquerda3.EscreveTituloValorLinha(1, "Filtro Intervalo (ms)", this.NumericUpDown_intervalo_filtro.Value.ToString(), 0, 180);
			tabelaMeiaLinhaEsquerda3.EscreveTituloValorLinha(2, "Filtro Amostras", this.NumericUpDown_tamanho_filtro.Value.ToString(), 0, 180);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita2 = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 8, "Entrada Digital", true);
			string valor9 = "";
			int i = 0;
			checked
			{
				do
				{
					int valor10 = RT_geral.RT_810_BD.config_ED[i].Valor;
					if (valor10 == 21856)
					{
						valor9 = "Sem Função";
					}
					else if (valor10 == 21969)
					{
						valor9 = "Arrombamento";
					}
					else if (valor10 == 21970)
					{
						valor9 = "Falta de Fase";
					}
					else if (valor10 == 21971)
					{
						valor9 = "Alagamento";
					}
					else if (valor10 == 21972)
					{
						valor9 = "Horário de Ponta";
					}
					else if (valor10 == 21973)
					{
						valor9 = "Transbordo";
					}
					else if (valor10 == 21974)
					{
						valor9 = "Operação em Bateria";
					}
					tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(i + 1, string.Format("ED0{0}", i + 1), valor9, 0, 100);
					i++;
				}
				while (i <= 7);
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda4 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda3.GetNextLineAvailable(), 5, "Escala EA", true);
				tabelaMeiaLinhaEsquerda4.EscreveTituloLinha(1, "Range", 70);
				tabelaMeiaLinhaEsquerda4.EscreveTituloLinha(1, "Início", 140);
				tabelaMeiaLinhaEsquerda4.EscreveTituloLinha(1, "Range", 240);
				i = 0;
				do
				{
					tabelaMeiaLinhaEsquerda4.EscreveTituloLinha(i + 2, string.Format("ED0{0}", i + 1), 0);
					tabelaMeiaLinhaEsquerda4.EscreveValorLinha(i + 2, RT_geral.RT_810_BD.EA_Range[i].Valor.ToString(), 70);
					tabelaMeiaLinhaEsquerda4.EscreveValorLinha(i + 2, RT_geral.RT_810_BD.EA_Inicio[i].Valor.ToString(), 150);
					tabelaMeiaLinhaEsquerda4.EscreveValorLinha(i + 2, RT_geral.RT_810_BD.EA_Fim[i].Valor.ToString(), 250);
					i++;
				}
				while (i <= 3);
				nextLineAvailable = tabelaMeiaLinhaEsquerda4.GetNextLineAvailable();
				TabelaLinhaInteria tabelaLinhaInteria4 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 2, "SetPoint", true);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "EA Controle", 150);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Nivel Baixo", 300);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Nível Alto", 550);
				tabelaLinhaInteria4.EscreveTituloLinha(2, "CTRL 01", 0);
				string valor11 = "???";
				switch (RT_geral.RT_810_BD.Setpoints_ctrl_variavel[0].Valor)
				{
				case 21856:
					valor11 = "CTRL Desativado";
					break;
				case 21857:
					valor11 = "EA01";
					break;
				case 21858:
					valor11 = "EA02";
					break;
				case 21859:
					valor11 = "EA03";
					break;
				case 21860:
					valor11 = "EA04";
					break;
				case 21873:
					valor11 = "Valor Referência 1";
					break;
				case 21874:
					valor11 = "Valor Referência 2";
					break;
				case 21875:
					valor11 = "Valor Referência 3";
					break;
				case 21876:
					valor11 = "Valor Referência 4";
					break;
				}
				tabelaLinhaInteria4.EscreveValorLinha(2, valor11, 150);
				tabelaLinhaInteria4.EscreveValorLinha(2, RT_geral.RT_810_BD.Setpoints_ctrl_nivel_baixo[0].Valor.ToString(), 300);
				tabelaLinhaInteria4.EscreveValorLinha(2, RT_geral.RT_810_BD.Setpoints_ctrl_nivel_alto[0].Valor.ToString(), 550);
				nextLineAvailable = tabelaLinhaInteria4.GetNextLineAvailable();
				TabelaLinhaInteria tabelaLinhaInteria5 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 1, "Repetidora", true);
				string valor12 = "???";
				switch (RT_geral.RT_810_BD.Hab_repetidora.Valor)
				{
				case 21856:
					valor12 = "Desabilitado";
					break;
				case 21857:
					valor12 = "Direto";
					break;
				case 21858:
					valor12 = "Cruzado";
					break;
				}
				tabelaLinhaInteria5.EscreveTituloValorLinha(1, "Modo", valor12, 0, 60);
				tabelaLinhaInteria5.EscreveTituloValorLinha(1, "End. Mestre", RT_geral.RT_810_BD.End_repetidora.Valor.ToString(), 240, 320);
				tabelaLinhaInteria5.EscreveTituloValorLinha(1, "Quantidade End. Repetidos", RT_geral.RT_810_BD.Num_repetidoras.Valor.ToString(), 410, 600);
				int num = RT_geral.RT_810_BD.Num_repetidoras.Valor / 20;
				if (RT_geral.RT_810_BD.Num_repetidoras.Valor > 0)
				{
					if (RT_geral.RT_810_BD.Num_repetidoras.Valor % 20 != 0)
					{
						num++;
					}
					int num2 = 1;
					int num3 = num;
					for (i = num2; i <= num3; i++)
					{
						tabelaLinhaInteria5.AdicionaLinha();
						string text = "";
						int num4 = (i - 1) * 20;
						int num5 = (i - 1) * 20 + 19;
						for (int j = num4; j <= num5; j++)
						{
							if (j + 1 < RT_geral.RT_810_BD.Num_repetidoras.Valor)
							{
								text = text + RT_geral.RT_810_BD.Repetidoras[j].Valor.ToString() + ", ";
							}
							else if (j + 1 == RT_geral.RT_810_BD.Num_repetidoras.Valor)
							{
								text += RT_geral.RT_810_BD.Repetidoras[j].Valor.ToString();
								break;
							}
						}
						tabelaLinhaInteria5.EscreveValorLinha(i + 1, text, 50);
					}
				}
				nextLineAvailable = tabelaLinhaInteria5.GetNextLineAvailable();
				TabelaLinhaInteria tabelaLinhaInteria6 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 4, "Observação", true);
				tabelaLinhaInteria6.EscreveValorLinha(1, this.TextBox_comentarios_RT810.Text, 0);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0032C500 File Offset: 0x0032A900
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

		// Token: 0x06001376 RID: 4982 RVA: 0x0032C5C4 File Offset: 0x0032A9C4
		private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
		{
			this.pagina_impressao = 1;
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x0032C5D0 File Offset: 0x0032A9D0
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

		// Token: 0x06001378 RID: 4984 RVA: 0x0032C620 File Offset: 0x0032AA20
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.HasMorePages = this.DesenhaRelatorio(e);
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x0032C630 File Offset: 0x0032AA30
		private void TabPage_geral_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0032C634 File Offset: 0x0032AA34
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x0032C638 File Offset: 0x0032AA38
		private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x0032C63C File Offset: 0x0032AA3C
		private void RepetidoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0032C648 File Offset: 0x0032AA48
		private void ToolStri_RT_810_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0032C64C File Offset: 0x0032AA4C
		private void TextBox_equipamento_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0032C650 File Offset: 0x0032AA50
		private void GroupBox_sistema_leitura_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0032C654 File Offset: 0x0032AA54
		private void Label73_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0032C658 File Offset: 0x0032AA58
		private void GroupBox_descricao_RT810_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x0032C65C File Offset: 0x0032AA5C
		private void GroupBox2_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0032C660 File Offset: 0x0032AA60
		private void ComboBox_baudrate_COM1_810_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_BD.BaudRateCOM1.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_810_BD.BaudRateCOM1.AtualizaValorPeloIndice();
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0032C69C File Offset: 0x0032AA9C
		private void ComboBox_baudrate_COM2_810_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_BD.BaudRateCOM2.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_810_BD.BaudRateCOM2.AtualizaValorPeloIndice();
		}

		// Token: 0x04000A43 RID: 2627
		[AccessedThroughProperty("TabControl_810")]
		private TabControl _TabControl_810;

		// Token: 0x04000A44 RID: 2628
		[AccessedThroughProperty("TabPage_geral")]
		private TabPage _TabPage_geral;

		// Token: 0x04000A45 RID: 2629
		[AccessedThroughProperty("GroupBox_informacoes")]
		private GroupBox _GroupBox_informacoes;

		// Token: 0x04000A46 RID: 2630
		[AccessedThroughProperty("GroupBox_modelo_simulado")]
		private GroupBox _GroupBox_modelo_simulado;

		// Token: 0x04000A47 RID: 2631
		[AccessedThroughProperty("GroupBox_comunicacao")]
		private GroupBox _GroupBox_comunicacao;

		// Token: 0x04000A48 RID: 2632
		[AccessedThroughProperty("NumericUpDown_temp_ptt")]
		private NumericUpDown _NumericUpDown_temp_ptt;

		// Token: 0x04000A49 RID: 2633
		[AccessedThroughProperty("NumericUpDown_end_mestre")]
		private NumericUpDown _NumericUpDown_end_mestre;

		// Token: 0x04000A4A RID: 2634
		[AccessedThroughProperty("NumericUpDown_end_est")]
		private NumericUpDown _NumericUpDown_end_est;

		// Token: 0x04000A4B RID: 2635
		[AccessedThroughProperty("Label_tempo_ptt")]
		private Label _Label_tempo_ptt;

		// Token: 0x04000A4C RID: 2636
		[AccessedThroughProperty("Label_end_mestre")]
		private Label _Label_end_mestre;

		// Token: 0x04000A4D RID: 2637
		[AccessedThroughProperty("Label_end_est")]
		private Label _Label_end_est;

		// Token: 0x04000A4E RID: 2638
		[AccessedThroughProperty("TabPage_controle")]
		private TabPage _TabPage_controle;

		// Token: 0x04000A4F RID: 2639
		[AccessedThroughProperty("TabPage_setpoints")]
		private TabPage _TabPage_setpoints;

		// Token: 0x04000A50 RID: 2640
		[AccessedThroughProperty("TabPage_repetidora")]
		private TabPage _TabPage_repetidora;

		// Token: 0x04000A51 RID: 2641
		[AccessedThroughProperty("GroupBox_parametros_repetidora")]
		private GroupBox _GroupBox_parametros_repetidora;

		// Token: 0x04000A52 RID: 2642
		[AccessedThroughProperty("NumericUpDown_num_est_rep")]
		private NumericUpDown _NumericUpDown_num_est_rep;

		// Token: 0x04000A53 RID: 2643
		[AccessedThroughProperty("NumericUpDown_end_rep")]
		private NumericUpDown _NumericUpDown_end_rep;

		// Token: 0x04000A54 RID: 2644
		[AccessedThroughProperty("Label_num_est_rep")]
		private Label _Label_num_est_rep;

		// Token: 0x04000A55 RID: 2645
		[AccessedThroughProperty("Label_end_rep")]
		private Label _Label_end_rep;

		// Token: 0x04000A56 RID: 2646
		[AccessedThroughProperty("TabPage_ED")]
		private TabPage _TabPage_ED;

		// Token: 0x04000A57 RID: 2647
		[AccessedThroughProperty("TabPage_EA")]
		private TabPage _TabPage_EA;

		// Token: 0x04000A58 RID: 2648
		[AccessedThroughProperty("GroupBox_EA")]
		private GroupBox _GroupBox_EA;

		// Token: 0x04000A59 RID: 2649
		[AccessedThroughProperty("NumericUpDown_tamanho_filtro")]
		private NumericUpDown _NumericUpDown_tamanho_filtro;

		// Token: 0x04000A5A RID: 2650
		[AccessedThroughProperty("Label_intervalo_filtro")]
		private Label _Label_intervalo_filtro;

		// Token: 0x04000A5B RID: 2651
		[AccessedThroughProperty("Label_tamanho_filtro")]
		private Label _Label_tamanho_filtro;

		// Token: 0x04000A5C RID: 2652
		[AccessedThroughProperty("GroupBox_parametros_EA")]
		private GroupBox _GroupBox_parametros_EA;

		// Token: 0x04000A5D RID: 2653
		[AccessedThroughProperty("GroupBox_end_rep")]
		private GroupBox _GroupBox_end_rep;

		// Token: 0x04000A5E RID: 2654
		[AccessedThroughProperty("DataGridView_end_rep_RT_810")]
		private DataGridView _DataGridView_end_rep_RT_810;

		// Token: 0x04000A5F RID: 2655
		[AccessedThroughProperty("ComboBox_modo_simulado_810")]
		private ComboBox _ComboBox_modo_simulado_810;

		// Token: 0x04000A60 RID: 2656
		[AccessedThroughProperty("Posicao_1_10")]
		private DataGridViewTextBoxColumn _Posicao_1_10;

		// Token: 0x04000A61 RID: 2657
		[AccessedThroughProperty("End_01_10")]
		private DataGridViewTextBoxColumn _End_01_10;

		// Token: 0x04000A62 RID: 2658
		[AccessedThroughProperty("Posicao_11_20")]
		private DataGridViewTextBoxColumn _Posicao_11_20;

		// Token: 0x04000A63 RID: 2659
		[AccessedThroughProperty("End_11_20")]
		private DataGridViewTextBoxColumn _End_11_20;

		// Token: 0x04000A64 RID: 2660
		[AccessedThroughProperty("Posicao_21_30")]
		private DataGridViewTextBoxColumn _Posicao_21_30;

		// Token: 0x04000A65 RID: 2661
		[AccessedThroughProperty("End_21_30")]
		private DataGridViewTextBoxColumn _End_21_30;

		// Token: 0x04000A66 RID: 2662
		[AccessedThroughProperty("Posicao_31_40")]
		private DataGridViewTextBoxColumn _Posicao_31_40;

		// Token: 0x04000A67 RID: 2663
		[AccessedThroughProperty("End_31_40")]
		private DataGridViewTextBoxColumn _End_31_40;

		// Token: 0x04000A68 RID: 2664
		[AccessedThroughProperty("Posicao_41_50")]
		private DataGridViewTextBoxColumn _Posicao_41_50;

		// Token: 0x04000A69 RID: 2665
		[AccessedThroughProperty("End_41_50")]
		private DataGridViewTextBoxColumn _End_41_50;

		// Token: 0x04000A6A RID: 2666
		[AccessedThroughProperty("ToolStri_RT_810")]
		private ToolStrip _ToolStri_RT_810;

		// Token: 0x04000A6B RID: 2667
		[AccessedThroughProperty("ToolStripButton_RT_810_Abrir")]
		private ToolStripButton _ToolStripButton_RT_810_Abrir;

		// Token: 0x04000A6C RID: 2668
		[AccessedThroughProperty("ToolStripButton_RT_810_Salvar")]
		private ToolStripButton _ToolStripButton_RT_810_Salvar;

		// Token: 0x04000A6D RID: 2669
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x04000A6E RID: 2670
		[AccessedThroughProperty("ToolStripButton_RT_810_Download")]
		private ToolStripButton _ToolStripButton_RT_810_Download;

		// Token: 0x04000A6F RID: 2671
		[AccessedThroughProperty("ToolStripButton_RT_810_Upload")]
		private ToolStripButton _ToolStripButton_RT_810_Upload;

		// Token: 0x04000A70 RID: 2672
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x04000A71 RID: 2673
		[AccessedThroughProperty("ToolStripProgressBar_RT_810")]
		private ToolStripProgressBar _ToolStripProgressBar_RT_810;

		// Token: 0x04000A72 RID: 2674
		[AccessedThroughProperty("ToolStripTextBox_RT_810_Msg")]
		private ToolStripTextBox _ToolStripTextBox_RT_810_Msg;

		// Token: 0x04000A73 RID: 2675
		[AccessedThroughProperty("ToolStripButton_RT_810_novo")]
		private ToolStripButton _ToolStripButton_RT_810_novo;

		// Token: 0x04000A74 RID: 2676
		[AccessedThroughProperty("OpenFileDialog_RT_810")]
		private OpenFileDialog _OpenFileDialog_RT_810;

		// Token: 0x04000A75 RID: 2677
		[AccessedThroughProperty("SaveFileDialog_RT_810")]
		private SaveFileDialog _SaveFileDialog_RT_810;

		// Token: 0x04000A76 RID: 2678
		[AccessedThroughProperty("NumericUpDown_intervalo_filtro")]
		private NumericUpDown _NumericUpDown_intervalo_filtro;

		// Token: 0x04000A77 RID: 2679
		[AccessedThroughProperty("Timer_limpa_MSG")]
		private Timer _Timer_limpa_MSG;

		// Token: 0x04000A78 RID: 2680
		[AccessedThroughProperty("GroupBox_ModoOperacao")]
		private GroupBox _GroupBox_ModoOperacao;

		// Token: 0x04000A79 RID: 2681
		[AccessedThroughProperty("ComboBox_Modo_Operacao")]
		private ComboBox _ComboBox_Modo_Operacao;

		// Token: 0x04000A7A RID: 2682
		[AccessedThroughProperty("NumericUpDown_intervalo_tx")]
		private NumericUpDown _NumericUpDown_intervalo_tx;

		// Token: 0x04000A7B RID: 2683
		[AccessedThroughProperty("Label_MetodoOperacao")]
		private Label _Label_MetodoOperacao;

		// Token: 0x04000A7C RID: 2684
		[AccessedThroughProperty("Label_intevalo_tx_pto_pto")]
		private Label _Label_intevalo_tx_pto_pto;

		// Token: 0x04000A7D RID: 2685
		[AccessedThroughProperty("GroupBox_sistema_leitura")]
		private GroupBox _GroupBox_sistema_leitura;

		// Token: 0x04000A7E RID: 2686
		[AccessedThroughProperty("CheckBox_Hab_eletrodos")]
		private CheckBox _CheckBox_Hab_eletrodos;

		// Token: 0x04000A7F RID: 2687
		[AccessedThroughProperty("GroupBox_ED")]
		private GroupBox _GroupBox_ED;

		// Token: 0x04000A80 RID: 2688
		[AccessedThroughProperty("GroupBox_controle_810")]
		private GroupBox _GroupBox_controle_810;

		// Token: 0x04000A81 RID: 2689
		[AccessedThroughProperty("DataGridView_processo_810_P1")]
		private DataGridView _DataGridView_processo_810_P1;

		// Token: 0x04000A82 RID: 2690
		[AccessedThroughProperty("GroupBox_setpoints_810")]
		private GroupBox _GroupBox_setpoints_810;

		// Token: 0x04000A83 RID: 2691
		[AccessedThroughProperty("DataGridView_setpoints_810")]
		private DataGridView _DataGridView_setpoints_810;

		// Token: 0x04000A84 RID: 2692
		[AccessedThroughProperty("GroupBox_descricao_RT810")]
		private GroupBox _GroupBox_descricao_RT810;

		// Token: 0x04000A85 RID: 2693
		[AccessedThroughProperty("Label_endereco")]
		private Label _Label_endereco;

		// Token: 0x04000A86 RID: 2694
		[AccessedThroughProperty("Label_nome")]
		private Label _Label_nome;

		// Token: 0x04000A87 RID: 2695
		[AccessedThroughProperty("TextBox_comentarios_RT810")]
		private TextBox _TextBox_comentarios_RT810;

		// Token: 0x04000A88 RID: 2696
		[AccessedThroughProperty("TextBox_endereco_RT810")]
		private TextBox _TextBox_endereco_RT810;

		// Token: 0x04000A89 RID: 2697
		[AccessedThroughProperty("TextBox_nome_RT810")]
		private TextBox _TextBox_nome_RT810;

		// Token: 0x04000A8A RID: 2698
		[AccessedThroughProperty("Label_comentarios")]
		private Label _Label_comentarios;

		// Token: 0x04000A8B RID: 2699
		[AccessedThroughProperty("DataGridView_RT810_ED")]
		private DataGridView _DataGridView_RT810_ED;

		// Token: 0x04000A8C RID: 2700
		[AccessedThroughProperty("DataGridView_parametros_EA_810")]
		private DataGridView _DataGridView_parametros_EA_810;

		// Token: 0x04000A8D RID: 2701
		[AccessedThroughProperty("ComboBox_modo_repeticao_RT_810")]
		private ComboBox _ComboBox_modo_repeticao_RT_810;

		// Token: 0x04000A8E RID: 2702
		[AccessedThroughProperty("Label_modo_rep_RT_810")]
		private Label _Label_modo_rep_RT_810;

		// Token: 0x04000A8F RID: 2703
		[AccessedThroughProperty("ToolStripButton_RT_810_Imprimir")]
		private ToolStripButton _ToolStripButton_RT_810_Imprimir;

		// Token: 0x04000A90 RID: 2704
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x04000A91 RID: 2705
		[AccessedThroughProperty("PrintDocument1")]
		private PrintDocument _PrintDocument1;

		// Token: 0x04000A92 RID: 2706
		[AccessedThroughProperty("PrintPreviewDialog1")]
		private PrintPreviewDialog _PrintPreviewDialog1;

		// Token: 0x04000A93 RID: 2707
		[AccessedThroughProperty("TabPage_dadosinstalacao")]
		private TabPage _TabPage_dadosinstalacao;

		// Token: 0x04000A94 RID: 2708
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000A95 RID: 2709
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000A96 RID: 2710
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000A97 RID: 2711
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000A98 RID: 2712
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000A99 RID: 2713
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000A9A RID: 2714
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000A9B RID: 2715
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000A9C RID: 2716
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000A9D RID: 2717
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000A9E RID: 2718
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000A9F RID: 2719
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000AA0 RID: 2720
		[AccessedThroughProperty("CB_ModeloRadio")]
		private ComboBox _CB_ModeloRadio;

		// Token: 0x04000AA1 RID: 2721
		[AccessedThroughProperty("CB_PolarizacaoAntena")]
		private ComboBox _CB_PolarizacaoAntena;

		// Token: 0x04000AA2 RID: 2722
		[AccessedThroughProperty("CB_TipoAntena")]
		private ComboBox _CB_TipoAntena;

		// Token: 0x04000AA3 RID: 2723
		[AccessedThroughProperty("T_FreqRadio")]
		private TextBox _T_FreqRadio;

		// Token: 0x04000AA4 RID: 2724
		[AccessedThroughProperty("T_DistCentral")]
		private TextBox _T_DistCentral;

		// Token: 0x04000AA5 RID: 2725
		[AccessedThroughProperty("T_PotRadio")]
		private TextBox _T_PotRadio;

		// Token: 0x04000AA6 RID: 2726
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000AA7 RID: 2727
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000AA8 RID: 2728
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000AA9 RID: 2729
		[AccessedThroughProperty("T_Latitude")]
		private TextBox _T_Latitude;

		// Token: 0x04000AAA RID: 2730
		[AccessedThroughProperty("T_Longitude")]
		private TextBox _T_Longitude;

		// Token: 0x04000AAB RID: 2731
		[AccessedThroughProperty("T_Azimute")]
		private TextBox _T_Azimute;

		// Token: 0x04000AAC RID: 2732
		[AccessedThroughProperty("T_ModeloFonte")]
		private TextBox _T_ModeloFonte;

		// Token: 0x04000AAD RID: 2733
		[AccessedThroughProperty("T_AlturaAntena")]
		private TextBox _T_AlturaAntena;

		// Token: 0x04000AAE RID: 2734
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x04000AAF RID: 2735
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x04000AB0 RID: 2736
		[AccessedThroughProperty("RepetidoraBindingSource1")]
		private BindingSource _RepetidoraBindingSource1;

		// Token: 0x04000AB1 RID: 2737
		[AccessedThroughProperty("ToolStripLabel_ID")]
		private ToolStripLabel _ToolStripLabel_ID;

		// Token: 0x04000AB2 RID: 2738
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x04000AB3 RID: 2739
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		// Token: 0x04000AB4 RID: 2740
		[AccessedThroughProperty("TextBox_equipamento")]
		private TextBox _TextBox_equipamento;

		// Token: 0x04000AB5 RID: 2741
		[AccessedThroughProperty("Label_equipamento")]
		private Label _Label_equipamento;

		// Token: 0x04000AB6 RID: 2742
		[AccessedThroughProperty("TextBox_release")]
		private TextBox _TextBox_release;

		// Token: 0x04000AB7 RID: 2743
		[AccessedThroughProperty("Label_release")]
		private Label _Label_release;

		// Token: 0x04000AB8 RID: 2744
		[AccessedThroughProperty("TextBox_build")]
		private TextBox _TextBox_build;

		// Token: 0x04000AB9 RID: 2745
		[AccessedThroughProperty("Label_build")]
		private Label _Label_build;

		// Token: 0x04000ABA RID: 2746
		[AccessedThroughProperty("TextBox_versao")]
		private TextBox _TextBox_versao;

		// Token: 0x04000ABB RID: 2747
		[AccessedThroughProperty("Label_versao")]
		private Label _Label_versao;

		// Token: 0x04000ABC RID: 2748
		[AccessedThroughProperty("tb_lixo1")]
		private TextBox _tb_lixo1;

		// Token: 0x04000ABD RID: 2749
		[AccessedThroughProperty("tb_lixo2")]
		private TextBox _tb_lixo2;

		// Token: 0x04000ABE RID: 2750
		[AccessedThroughProperty("tb_lixo3")]
		private TextBox _tb_lixo3;

		// Token: 0x04000ABF RID: 2751
		[AccessedThroughProperty("tb_lixo4")]
		private TextBox _tb_lixo4;

		// Token: 0x04000AC0 RID: 2752
		[AccessedThroughProperty("tb_lixo5")]
		private TextBox _tb_lixo5;

		// Token: 0x04000AC1 RID: 2753
		[AccessedThroughProperty("tb_lixo6")]
		private TextBox _tb_lixo6;

		// Token: 0x04000AC2 RID: 2754
		[AccessedThroughProperty("tb_lixo7")]
		private TextBox _tb_lixo7;

		// Token: 0x04000AC3 RID: 2755
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000AC4 RID: 2756
		[AccessedThroughProperty("ComboBox_baudrate_COM1_810")]
		private ComboBox _ComboBox_baudrate_COM1_810;

		// Token: 0x04000AC5 RID: 2757
		[AccessedThroughProperty("Label36")]
		private Label _Label36;

		// Token: 0x04000AC6 RID: 2758
		[AccessedThroughProperty("ComboBox_baudrate_COM2_810")]
		private ComboBox _ComboBox_baudrate_COM2_810;

		// Token: 0x04000AC7 RID: 2759
		[AccessedThroughProperty("Label_baudrate_COM2_820")]
		private Label _Label_baudrate_COM2_820;

		// Token: 0x04000AC8 RID: 2760
		[AccessedThroughProperty("Label73")]
		private Label _Label73;

		// Token: 0x04000AC9 RID: 2761
		private int pagina_impressao;
	}
}
