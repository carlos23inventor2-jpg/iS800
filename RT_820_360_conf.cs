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
	// Token: 0x02000052 RID: 82
	[DesignerGenerated]
	public partial class RT_820_360_conf : Form
	{
		// Token: 0x06001385 RID: 4997 RVA: 0x0032C6D8 File Offset: 0x0032AAD8
		public RT_820_360_conf()
		{
			base.Load += new EventHandler(this.RT_820_conf_Load);
			base.Activated += new EventHandler(this.RT_820_conf_Activated);
			base.FormClosed += new FormClosedEventHandler(this.RT_820_conf_FormClosed);
			this.InitializeComponent();
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x00338924 File Offset: 0x00336D24
		// (set) Token: 0x06001389 RID: 5001 RVA: 0x00338938 File Offset: 0x00336D38
		internal virtual GroupBox GroupBox_sistema_leitura
		{
			get
			{
				return this._GroupBox_sistema_leitura;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_sistema_leitura = value;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x00338944 File Offset: 0x00336D44
		// (set) Token: 0x0600138B RID: 5003 RVA: 0x00338958 File Offset: 0x00336D58
		internal virtual CheckBox CheckBox_hab_eletrodos
		{
			get
			{
				return this._CheckBox_hab_eletrodos;
			}
			[MethodImpl(32)]
			set
			{
				this._CheckBox_hab_eletrodos = value;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x00338964 File Offset: 0x00336D64
		// (set) Token: 0x0600138D RID: 5005 RVA: 0x00338978 File Offset: 0x00336D78
		internal virtual GroupBox GroupBox_operacao
		{
			get
			{
				return this._GroupBox_operacao;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_operacao = value;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x00338984 File Offset: 0x00336D84
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x00338998 File Offset: 0x00336D98
		internal virtual ComboBox ComboBox_metodo_operacao
		{
			get
			{
				return this._ComboBox_metodo_operacao;
			}
			[MethodImpl(32)]
			set
			{
				this._ComboBox_metodo_operacao = value;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x003389A4 File Offset: 0x00336DA4
		// (set) Token: 0x06001391 RID: 5009 RVA: 0x003389B8 File Offset: 0x00336DB8
		internal virtual NumericUpDown NumericUpDown_intervalo_tx
		{
			get
			{
				return this._NumericUpDown_intervalo_tx;
			}
			[MethodImpl(32)]
			set
			{
				this._NumericUpDown_intervalo_tx = value;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x003389C4 File Offset: 0x00336DC4
		// (set) Token: 0x06001393 RID: 5011 RVA: 0x003389D8 File Offset: 0x00336DD8
		internal virtual Label Label_metodo_operacao
		{
			get
			{
				return this._Label_metodo_operacao;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_metodo_operacao = value;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x003389E4 File Offset: 0x00336DE4
		// (set) Token: 0x06001395 RID: 5013 RVA: 0x003389F8 File Offset: 0x00336DF8
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

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x00338A04 File Offset: 0x00336E04
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x00338A18 File Offset: 0x00336E18
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

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x00338A24 File Offset: 0x00336E24
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x00338A38 File Offset: 0x00336E38
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

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x00338A44 File Offset: 0x00336E44
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x00338A58 File Offset: 0x00336E58
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

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x00338A64 File Offset: 0x00336E64
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x00338A78 File Offset: 0x00336E78
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

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x00338A84 File Offset: 0x00336E84
		// (set) Token: 0x0600139F RID: 5023 RVA: 0x00338A98 File Offset: 0x00336E98
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

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x00338AA4 File Offset: 0x00336EA4
		// (set) Token: 0x060013A1 RID: 5025 RVA: 0x00338AB8 File Offset: 0x00336EB8
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

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x00338AC4 File Offset: 0x00336EC4
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x00338AD8 File Offset: 0x00336ED8
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

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x00338AE4 File Offset: 0x00336EE4
		// (set) Token: 0x060013A5 RID: 5029 RVA: 0x00338AF8 File Offset: 0x00336EF8
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

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x00338B04 File Offset: 0x00336F04
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x00338B18 File Offset: 0x00336F18
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

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00338B24 File Offset: 0x00336F24
		// (set) Token: 0x060013A9 RID: 5033 RVA: 0x00338B38 File Offset: 0x00336F38
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

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x00338B44 File Offset: 0x00336F44
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x00338B58 File Offset: 0x00336F58
		internal virtual ComboBox ComboBox_modo_simulado
		{
			get
			{
				return this._ComboBox_modo_simulado;
			}
			[MethodImpl(32)]
			set
			{
				this._ComboBox_modo_simulado = value;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x00338B64 File Offset: 0x00336F64
		// (set) Token: 0x060013AD RID: 5037 RVA: 0x00338B78 File Offset: 0x00336F78
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

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x00338B84 File Offset: 0x00336F84
		// (set) Token: 0x060013AF RID: 5039 RVA: 0x00338B98 File Offset: 0x00336F98
		internal virtual NumericUpDown NumericUpDown_temp_ptt
		{
			get
			{
				return this._NumericUpDown_temp_ptt;
			}
			[MethodImpl(32)]
			set
			{
				this._NumericUpDown_temp_ptt = value;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x00338BA4 File Offset: 0x00336FA4
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x00338BB8 File Offset: 0x00336FB8
		internal virtual NumericUpDown NumericUpDown_end_mestre
		{
			get
			{
				return this._NumericUpDown_end_mestre;
			}
			[MethodImpl(32)]
			set
			{
				this._NumericUpDown_end_mestre = value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x00338BC4 File Offset: 0x00336FC4
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x00338BD8 File Offset: 0x00336FD8
		internal virtual NumericUpDown NumericUpDown_end_est
		{
			get
			{
				return this._NumericUpDown_end_est;
			}
			[MethodImpl(32)]
			set
			{
				this._NumericUpDown_end_est = value;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x00338BE4 File Offset: 0x00336FE4
		// (set) Token: 0x060013B5 RID: 5045 RVA: 0x00338BF8 File Offset: 0x00336FF8
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

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x00338C04 File Offset: 0x00337004
		// (set) Token: 0x060013B7 RID: 5047 RVA: 0x00338C18 File Offset: 0x00337018
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

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x00338C24 File Offset: 0x00337024
		// (set) Token: 0x060013B9 RID: 5049 RVA: 0x00338C38 File Offset: 0x00337038
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

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x00338C44 File Offset: 0x00337044
		// (set) Token: 0x060013BB RID: 5051 RVA: 0x00338C58 File Offset: 0x00337058
		internal virtual OpenFileDialog OpenFileDialog_RT_820
		{
			get
			{
				return this._OpenFileDialog_RT_820;
			}
			[MethodImpl(32)]
			set
			{
				this._OpenFileDialog_RT_820 = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x00338C64 File Offset: 0x00337064
		// (set) Token: 0x060013BD RID: 5053 RVA: 0x00338C78 File Offset: 0x00337078
		internal virtual SaveFileDialog SaveFileDialog_RT_820
		{
			get
			{
				return this._SaveFileDialog_RT_820;
			}
			[MethodImpl(32)]
			set
			{
				this._SaveFileDialog_RT_820 = value;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x00338C84 File Offset: 0x00337084
		// (set) Token: 0x060013BF RID: 5055 RVA: 0x00338C98 File Offset: 0x00337098
		internal virtual TabControl TabControl_820
		{
			get
			{
				return this._TabControl_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TabControl_820_SelectedIndexChanged);
				if (this._TabControl_820 != null)
				{
					this._TabControl_820.SelectedIndexChanged -= eventHandler;
				}
				this._TabControl_820 = value;
				if (this._TabControl_820 != null)
				{
					this._TabControl_820.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x00338CE4 File Offset: 0x003370E4
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x00338CF8 File Offset: 0x003370F8
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

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x00338D04 File Offset: 0x00337104
		// (set) Token: 0x060013C3 RID: 5059 RVA: 0x00338D18 File Offset: 0x00337118
		internal virtual GroupBox GroupBox_informacoes_820
		{
			get
			{
				return this._GroupBox_informacoes_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_informacoes_820 = value;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x00338D24 File Offset: 0x00337124
		// (set) Token: 0x060013C5 RID: 5061 RVA: 0x00338D38 File Offset: 0x00337138
		internal virtual GroupBox GroupBox_comunicacao_820
		{
			get
			{
				return this._GroupBox_comunicacao_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_comunicacao_820 = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x00338D44 File Offset: 0x00337144
		// (set) Token: 0x060013C7 RID: 5063 RVA: 0x00338D58 File Offset: 0x00337158
		internal virtual NumericUpDown NumericUpDown_temp_ptt_820
		{
			get
			{
				return this._NumericUpDown_temp_ptt_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_temp_ptt_820_ValueChanged);
				if (this._NumericUpDown_temp_ptt_820 != null)
				{
					this._NumericUpDown_temp_ptt_820.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_temp_ptt_820 = value;
				if (this._NumericUpDown_temp_ptt_820 != null)
				{
					this._NumericUpDown_temp_ptt_820.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x00338DA4 File Offset: 0x003371A4
		// (set) Token: 0x060013C9 RID: 5065 RVA: 0x00338DB8 File Offset: 0x003371B8
		internal virtual NumericUpDown NumericUpDown_end_mestre_820
		{
			get
			{
				return this._NumericUpDown_end_mestre_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_mestre_820_ValueChanged);
				if (this._NumericUpDown_end_mestre_820 != null)
				{
					this._NumericUpDown_end_mestre_820.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_mestre_820 = value;
				if (this._NumericUpDown_end_mestre_820 != null)
				{
					this._NumericUpDown_end_mestre_820.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x00338E04 File Offset: 0x00337204
		// (set) Token: 0x060013CB RID: 5067 RVA: 0x00338E18 File Offset: 0x00337218
		internal virtual NumericUpDown NumericUpDown_end1_est_820
		{
			get
			{
				return this._NumericUpDown_end1_est_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_est_820_ValueChanged);
				if (this._NumericUpDown_end1_est_820 != null)
				{
					this._NumericUpDown_end1_est_820.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end1_est_820 = value;
				if (this._NumericUpDown_end1_est_820 != null)
				{
					this._NumericUpDown_end1_est_820.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x00338E64 File Offset: 0x00337264
		// (set) Token: 0x060013CD RID: 5069 RVA: 0x00338E78 File Offset: 0x00337278
		internal virtual Label Label_tempo_ptt_820
		{
			get
			{
				return this._Label_tempo_ptt_820;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_ptt_820 = value;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x00338E84 File Offset: 0x00337284
		// (set) Token: 0x060013CF RID: 5071 RVA: 0x00338E98 File Offset: 0x00337298
		internal virtual Label Label_end_mestre_820
		{
			get
			{
				return this._Label_end_mestre_820;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_mestre_820 = value;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x00338EA4 File Offset: 0x003372A4
		// (set) Token: 0x060013D1 RID: 5073 RVA: 0x00338EB8 File Offset: 0x003372B8
		internal virtual Label Label_end_est_820
		{
			get
			{
				return this._Label_end_est_820;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_est_820 = value;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x00338EC4 File Offset: 0x003372C4
		// (set) Token: 0x060013D3 RID: 5075 RVA: 0x00338ED8 File Offset: 0x003372D8
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

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x00338EE4 File Offset: 0x003372E4
		// (set) Token: 0x060013D5 RID: 5077 RVA: 0x00338EF8 File Offset: 0x003372F8
		internal virtual GroupBox GroupBox_parametros_EA_820
		{
			get
			{
				return this._GroupBox_parametros_EA_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_parametros_EA_820 = value;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x00338F04 File Offset: 0x00337304
		// (set) Token: 0x060013D7 RID: 5079 RVA: 0x00338F18 File Offset: 0x00337318
		internal virtual DataGridView DataGridView_parametros_EA_820
		{
			get
			{
				return this._DataGridView_parametros_EA_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_parametros_EA_820_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_parametros_EA_820_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_parametros_EA_820_CellValueChanged);
				if (this._DataGridView_parametros_EA_820 != null)
				{
					this._DataGridView_parametros_EA_820.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_parametros_EA_820.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_parametros_EA_820.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_parametros_EA_820 = value;
				if (this._DataGridView_parametros_EA_820 != null)
				{
					this._DataGridView_parametros_EA_820.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_parametros_EA_820.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_parametros_EA_820.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x00338FB0 File Offset: 0x003373B0
		// (set) Token: 0x060013D9 RID: 5081 RVA: 0x00338FC4 File Offset: 0x003373C4
		internal virtual GroupBox GroupBox_EA_820
		{
			get
			{
				return this._GroupBox_EA_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_EA_820 = value;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x00338FD0 File Offset: 0x003373D0
		// (set) Token: 0x060013DB RID: 5083 RVA: 0x00338FE4 File Offset: 0x003373E4
		internal virtual NumericUpDown NumericUpDown_intervalo_filtro_820
		{
			get
			{
				return this._NumericUpDown_intervalo_filtro_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_intervalo_filtro_820_ValueChanged);
				if (this._NumericUpDown_intervalo_filtro_820 != null)
				{
					this._NumericUpDown_intervalo_filtro_820.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_intervalo_filtro_820 = value;
				if (this._NumericUpDown_intervalo_filtro_820 != null)
				{
					this._NumericUpDown_intervalo_filtro_820.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x00339030 File Offset: 0x00337430
		// (set) Token: 0x060013DD RID: 5085 RVA: 0x00339044 File Offset: 0x00337444
		internal virtual NumericUpDown NumericUpDown_tamanho_filtro_820
		{
			get
			{
				return this._NumericUpDown_tamanho_filtro_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_tamanho_filtro_820_ValueChanged);
				if (this._NumericUpDown_tamanho_filtro_820 != null)
				{
					this._NumericUpDown_tamanho_filtro_820.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_tamanho_filtro_820 = value;
				if (this._NumericUpDown_tamanho_filtro_820 != null)
				{
					this._NumericUpDown_tamanho_filtro_820.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x00339090 File Offset: 0x00337490
		// (set) Token: 0x060013DF RID: 5087 RVA: 0x003390A4 File Offset: 0x003374A4
		internal virtual Label Label_intervalo_filtro_820
		{
			get
			{
				return this._Label_intervalo_filtro_820;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_intervalo_filtro_820 = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x003390B0 File Offset: 0x003374B0
		// (set) Token: 0x060013E1 RID: 5089 RVA: 0x003390C4 File Offset: 0x003374C4
		internal virtual Label Label_tamanho_filtro_820
		{
			get
			{
				return this._Label_tamanho_filtro_820;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tamanho_filtro_820 = value;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x003390D0 File Offset: 0x003374D0
		// (set) Token: 0x060013E3 RID: 5091 RVA: 0x003390E4 File Offset: 0x003374E4
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

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x003390F0 File Offset: 0x003374F0
		// (set) Token: 0x060013E5 RID: 5093 RVA: 0x00339104 File Offset: 0x00337504
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

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x00339110 File Offset: 0x00337510
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x00339124 File Offset: 0x00337524
		internal virtual TabPage TabPage_vazao_perifericos
		{
			get
			{
				return this._TabPage_vazao_perifericos;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_vazao_perifericos = value;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x00339130 File Offset: 0x00337530
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x00339144 File Offset: 0x00337544
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

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x00339150 File Offset: 0x00337550
		// (set) Token: 0x060013EB RID: 5099 RVA: 0x00339164 File Offset: 0x00337564
		internal virtual GroupBox GroupBox_end_rep_820
		{
			get
			{
				return this._GroupBox_end_rep_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_end_rep_820 = value;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x00339170 File Offset: 0x00337570
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x00339184 File Offset: 0x00337584
		internal virtual DataGridView DataGridView_end_rep_RT820
		{
			get
			{
				return this._DataGridView_end_rep_RT820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_end_rep_820_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_end_rep_820_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_end_rep_820_CellValidating);
				if (this._DataGridView_end_rep_RT820 != null)
				{
					this._DataGridView_end_rep_RT820.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_end_rep_RT820.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_end_rep_RT820.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_end_rep_RT820 = value;
				if (this._DataGridView_end_rep_RT820 != null)
				{
					this._DataGridView_end_rep_RT820.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_end_rep_RT820.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_end_rep_RT820.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x0033921C File Offset: 0x0033761C
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x00339230 File Offset: 0x00337630
		internal virtual GroupBox GroupBox_parametros_repetidora_820
		{
			get
			{
				return this._GroupBox_parametros_repetidora_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_parametros_repetidora_820 = value;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0033923C File Offset: 0x0033763C
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x00339250 File Offset: 0x00337650
		internal virtual NumericUpDown NumericUpDown_num_est_rep_820
		{
			get
			{
				return this._NumericUpDown_num_est_rep_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_num_est_rep_820_ValueChanged);
				if (this._NumericUpDown_num_est_rep_820 != null)
				{
					this._NumericUpDown_num_est_rep_820.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_num_est_rep_820 = value;
				if (this._NumericUpDown_num_est_rep_820 != null)
				{
					this._NumericUpDown_num_est_rep_820.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x0033929C File Offset: 0x0033769C
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x003392B0 File Offset: 0x003376B0
		internal virtual NumericUpDown NumericUpDown_end_rep_820
		{
			get
			{
				return this._NumericUpDown_end_rep_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_rep_820_ValueChanged);
				if (this._NumericUpDown_end_rep_820 != null)
				{
					this._NumericUpDown_end_rep_820.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_rep_820 = value;
				if (this._NumericUpDown_end_rep_820 != null)
				{
					this._NumericUpDown_end_rep_820.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x003392FC File Offset: 0x003376FC
		// (set) Token: 0x060013F5 RID: 5109 RVA: 0x00339310 File Offset: 0x00337710
		internal virtual Label Label_num_est_rep_820
		{
			get
			{
				return this._Label_num_est_rep_820;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_num_est_rep_820 = value;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0033931C File Offset: 0x0033771C
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x00339330 File Offset: 0x00337730
		internal virtual Label Label_end_rep_820
		{
			get
			{
				return this._Label_end_rep_820;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_rep_820 = value;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x0033933C File Offset: 0x0033773C
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x00339350 File Offset: 0x00337750
		internal virtual ToolStrip ToolStri_RT_820
		{
			get
			{
				return this._ToolStri_RT_820;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStri_RT_820 = value;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x0033935C File Offset: 0x0033775C
		// (set) Token: 0x060013FB RID: 5115 RVA: 0x00339370 File Offset: 0x00337770
		internal virtual ToolStripButton ToolStripButton_RT_820_novo
		{
			get
			{
				return this._ToolStripButton_RT_820_novo;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_820_novo_Click);
				if (this._ToolStripButton_RT_820_novo != null)
				{
					this._ToolStripButton_RT_820_novo.Click -= eventHandler;
				}
				this._ToolStripButton_RT_820_novo = value;
				if (this._ToolStripButton_RT_820_novo != null)
				{
					this._ToolStripButton_RT_820_novo.Click += eventHandler;
				}
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x003393BC File Offset: 0x003377BC
		// (set) Token: 0x060013FD RID: 5117 RVA: 0x003393D0 File Offset: 0x003377D0
		internal virtual ToolStripButton ToolStripButton_RT_820_Abrir
		{
			get
			{
				return this._ToolStripButton_RT_820_Abrir;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_820_Abrir_Click);
				if (this._ToolStripButton_RT_820_Abrir != null)
				{
					this._ToolStripButton_RT_820_Abrir.Click -= eventHandler;
				}
				this._ToolStripButton_RT_820_Abrir = value;
				if (this._ToolStripButton_RT_820_Abrir != null)
				{
					this._ToolStripButton_RT_820_Abrir.Click += eventHandler;
				}
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0033941C File Offset: 0x0033781C
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x00339430 File Offset: 0x00337830
		internal virtual ToolStripButton ToolStripButton_RT_820_Salvar
		{
			get
			{
				return this._ToolStripButton_RT_820_Salvar;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_820_Salvar_Click);
				if (this._ToolStripButton_RT_820_Salvar != null)
				{
					this._ToolStripButton_RT_820_Salvar.Click -= eventHandler;
				}
				this._ToolStripButton_RT_820_Salvar = value;
				if (this._ToolStripButton_RT_820_Salvar != null)
				{
					this._ToolStripButton_RT_820_Salvar.Click += eventHandler;
				}
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x0033947C File Offset: 0x0033787C
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x00339490 File Offset: 0x00337890
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

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x0033949C File Offset: 0x0033789C
		// (set) Token: 0x06001403 RID: 5123 RVA: 0x003394B0 File Offset: 0x003378B0
		internal virtual ToolStripButton ToolStripButton_RT_820_Download
		{
			get
			{
				return this._ToolStripButton_RT_820_Download;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_820_Download_Click);
				if (this._ToolStripButton_RT_820_Download != null)
				{
					this._ToolStripButton_RT_820_Download.Click -= eventHandler;
				}
				this._ToolStripButton_RT_820_Download = value;
				if (this._ToolStripButton_RT_820_Download != null)
				{
					this._ToolStripButton_RT_820_Download.Click += eventHandler;
				}
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x003394FC File Offset: 0x003378FC
		// (set) Token: 0x06001405 RID: 5125 RVA: 0x00339510 File Offset: 0x00337910
		internal virtual ToolStripButton ToolStripButton_RT_820_Upload
		{
			get
			{
				return this._ToolStripButton_RT_820_Upload;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_820_Upload_Click);
				if (this._ToolStripButton_RT_820_Upload != null)
				{
					this._ToolStripButton_RT_820_Upload.Click -= eventHandler;
				}
				this._ToolStripButton_RT_820_Upload = value;
				if (this._ToolStripButton_RT_820_Upload != null)
				{
					this._ToolStripButton_RT_820_Upload.Click += eventHandler;
				}
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x0033955C File Offset: 0x0033795C
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x00339570 File Offset: 0x00337970
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

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x0033957C File Offset: 0x0033797C
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x00339590 File Offset: 0x00337990
		internal virtual ToolStripTextBox ToolStripTextBox_RT_820_Msg
		{
			get
			{
				return this._ToolStripTextBox_RT_820_Msg;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripTextBox_RT_820_Msg = value;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x0033959C File Offset: 0x0033799C
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x003395B0 File Offset: 0x003379B0
		internal virtual ToolStripProgressBar ToolStripProgressBar_RT_820
		{
			get
			{
				return this._ToolStripProgressBar_RT_820;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripProgressBar_RT_820 = value;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x003395BC File Offset: 0x003379BC
		// (set) Token: 0x0600140D RID: 5133 RVA: 0x003395D0 File Offset: 0x003379D0
		internal virtual GroupBox GroupBox_parametros_interface_820
		{
			get
			{
				return this._GroupBox_parametros_interface_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_parametros_interface_820 = value;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x003395DC File Offset: 0x003379DC
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x003395F0 File Offset: 0x003379F0
		internal virtual CheckBox CheckBox_hab_expansao_IO_820
		{
			get
			{
				return this._CheckBox_hab_expansao_IO_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_hab_expansao_IO_820_CheckedChanged);
				if (this._CheckBox_hab_expansao_IO_820 != null)
				{
					this._CheckBox_hab_expansao_IO_820.CheckedChanged -= eventHandler;
				}
				this._CheckBox_hab_expansao_IO_820 = value;
				if (this._CheckBox_hab_expansao_IO_820 != null)
				{
					this._CheckBox_hab_expansao_IO_820.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0033963C File Offset: 0x00337A3C
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x00339650 File Offset: 0x00337A50
		internal virtual ComboBox ComboBox_baudrate_COM2_820
		{
			get
			{
				return this._ComboBox_baudrate_COM2_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_baudrate_COM2_820_SelectedIndexChanged);
				if (this._ComboBox_baudrate_COM2_820 != null)
				{
					this._ComboBox_baudrate_COM2_820.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_baudrate_COM2_820 = value;
				if (this._ComboBox_baudrate_COM2_820 != null)
				{
					this._ComboBox_baudrate_COM2_820.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0033969C File Offset: 0x00337A9C
		// (set) Token: 0x06001413 RID: 5139 RVA: 0x003396B0 File Offset: 0x00337AB0
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

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x003396BC File Offset: 0x00337ABC
		// (set) Token: 0x06001415 RID: 5141 RVA: 0x003396D0 File Offset: 0x00337AD0
		internal virtual TabPage TabPage_controle
		{
			get
			{
				return this._TabPage_controle;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TabPage_controle_Click);
				if (this._TabPage_controle != null)
				{
					this._TabPage_controle.Click -= eventHandler;
				}
				this._TabPage_controle = value;
				if (this._TabPage_controle != null)
				{
					this._TabPage_controle.Click += eventHandler;
				}
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0033971C File Offset: 0x00337B1C
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x00339730 File Offset: 0x00337B30
		internal virtual GroupBox GroupBox_controle_820
		{
			get
			{
				return this._GroupBox_controle_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_controle_820 = value;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x0033973C File Offset: 0x00337B3C
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x00339750 File Offset: 0x00337B50
		internal virtual DataGridView DataGridView_processo_820
		{
			get
			{
				return this._DataGridView_processo_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_parametros_EA_820_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_processo_820_CellContentClick);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_processo_820_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler2 = new DataGridViewCellEventHandler(this.DataGridView_processo_820_CellValueChanged);
				if (this._DataGridView_processo_820 != null)
				{
					this._DataGridView_processo_820.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_processo_820.CellContentClick -= dataGridViewCellEventHandler;
					this._DataGridView_processo_820.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_processo_820.CellValueChanged -= dataGridViewCellEventHandler2;
				}
				this._DataGridView_processo_820 = value;
				if (this._DataGridView_processo_820 != null)
				{
					this._DataGridView_processo_820.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_processo_820.CellContentClick += dataGridViewCellEventHandler;
					this._DataGridView_processo_820.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_processo_820.CellValueChanged += dataGridViewCellEventHandler2;
				}
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x0033980C File Offset: 0x00337C0C
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x00339820 File Offset: 0x00337C20
		internal virtual GroupBox GroupBox_Agrupamento_820
		{
			get
			{
				return this._GroupBox_Agrupamento_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_Agrupamento_820 = value;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x0033982C File Offset: 0x00337C2C
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x00339840 File Offset: 0x00337C40
		internal virtual DataGridView DataGridView_grupos_820
		{
			get
			{
				return this._DataGridView_grupos_820;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_grupos_820_CellContentClick);
				EventHandler eventHandler = new EventHandler(this.DataGridView_grupos_820_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_grupos_820_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler2 = new DataGridViewCellEventHandler(this.DataGridView_grupos_820_CellValueChanged);
				if (this._DataGridView_grupos_820 != null)
				{
					this._DataGridView_grupos_820.CellContentClick -= dataGridViewCellEventHandler;
					this._DataGridView_grupos_820.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_grupos_820.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_grupos_820.CellValueChanged -= dataGridViewCellEventHandler2;
				}
				this._DataGridView_grupos_820 = value;
				if (this._DataGridView_grupos_820 != null)
				{
					this._DataGridView_grupos_820.CellContentClick += dataGridViewCellEventHandler;
					this._DataGridView_grupos_820.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_grupos_820.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_grupos_820.CellValueChanged += dataGridViewCellEventHandler2;
				}
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x003398FC File Offset: 0x00337CFC
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x00339910 File Offset: 0x00337D10
		internal virtual GroupBox GroupBox_perifericos_820
		{
			get
			{
				return this._GroupBox_perifericos_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_perifericos_820 = value;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x0033991C File Offset: 0x00337D1C
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x00339930 File Offset: 0x00337D30
		internal virtual DataGridView DataGridView_periferico1_RT820
		{
			get
			{
				return this._DataGridView_periferico1_RT820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_periferico_RT820_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_periferico_RT820_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_periferico_RT820_CellValueChanged);
				if (this._DataGridView_periferico1_RT820 != null)
				{
					this._DataGridView_periferico1_RT820.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_periferico1_RT820.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_periferico1_RT820.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_periferico1_RT820 = value;
				if (this._DataGridView_periferico1_RT820 != null)
				{
					this._DataGridView_periferico1_RT820.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_periferico1_RT820.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_periferico1_RT820.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x003399C8 File Offset: 0x00337DC8
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x003399DC File Offset: 0x00337DDC
		internal virtual DataGridView DataGridView_setpoints_820
		{
			get
			{
				return this._DataGridView_setpoints_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_setpoints_820_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_setpoints_820_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_setpoints_820_CellValueChanged);
				if (this._DataGridView_setpoints_820 != null)
				{
					this._DataGridView_setpoints_820.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_setpoints_820.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_setpoints_820.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_setpoints_820 = value;
				if (this._DataGridView_setpoints_820 != null)
				{
					this._DataGridView_setpoints_820.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_setpoints_820.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_setpoints_820.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x00339A74 File Offset: 0x00337E74
		// (set) Token: 0x06001425 RID: 5157 RVA: 0x00339A88 File Offset: 0x00337E88
		internal virtual GroupBox GroupBox_setpoints_820
		{
			get
			{
				return this._GroupBox_setpoints_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_setpoints_820 = value;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x00339A94 File Offset: 0x00337E94
		// (set) Token: 0x06001427 RID: 5159 RVA: 0x00339AA8 File Offset: 0x00337EA8
		internal virtual Timer Timer_limpa_MSG_820
		{
			get
			{
				return this._Timer_limpa_MSG_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer_limpa_MSG_820_Tick);
				if (this._Timer_limpa_MSG_820 != null)
				{
					this._Timer_limpa_MSG_820.Tick -= eventHandler;
				}
				this._Timer_limpa_MSG_820 = value;
				if (this._Timer_limpa_MSG_820 != null)
				{
					this._Timer_limpa_MSG_820.Tick += eventHandler;
				}
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x00339AF4 File Offset: 0x00337EF4
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x00339B08 File Offset: 0x00337F08
		internal virtual GroupBox GroupBox_descricao_RT820
		{
			get
			{
				return this._GroupBox_descricao_RT820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_descricao_RT820 = value;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x00339B14 File Offset: 0x00337F14
		// (set) Token: 0x0600142B RID: 5163 RVA: 0x00339B28 File Offset: 0x00337F28
		internal virtual TextBox TextBox_comentarios_RT820
		{
			get
			{
				return this._TextBox_comentarios_RT820;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_comentarios_RT820 = value;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x00339B34 File Offset: 0x00337F34
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x00339B48 File Offset: 0x00337F48
		internal virtual TextBox TextBox_endereco_RT820
		{
			get
			{
				return this._TextBox_endereco_RT820;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_endereco_RT820 = value;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x00339B54 File Offset: 0x00337F54
		// (set) Token: 0x0600142F RID: 5167 RVA: 0x00339B68 File Offset: 0x00337F68
		internal virtual TextBox TextBox_nome_RT820
		{
			get
			{
				return this._TextBox_nome_RT820;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_nome_RT820 = value;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x00339B74 File Offset: 0x00337F74
		// (set) Token: 0x06001431 RID: 5169 RVA: 0x00339B88 File Offset: 0x00337F88
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

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x00339B94 File Offset: 0x00337F94
		// (set) Token: 0x06001433 RID: 5171 RVA: 0x00339BA8 File Offset: 0x00337FA8
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

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x00339BB4 File Offset: 0x00337FB4
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x00339BC8 File Offset: 0x00337FC8
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

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x00339BD4 File Offset: 0x00337FD4
		// (set) Token: 0x06001437 RID: 5175 RVA: 0x00339BE8 File Offset: 0x00337FE8
		internal virtual TabPage TabPage_timer
		{
			get
			{
				return this._TabPage_timer;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_timer = value;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x00339BF4 File Offset: 0x00337FF4
		// (set) Token: 0x06001439 RID: 5177 RVA: 0x00339C08 File Offset: 0x00338008
		internal virtual GroupBox GroupBox_timer
		{
			get
			{
				return this._GroupBox_timer;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_timer = value;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x00339C14 File Offset: 0x00338014
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x00339C28 File Offset: 0x00338028
		internal virtual DataGridView DataGridView_timer_RT820
		{
			get
			{
				return this._DataGridView_timer_RT820;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_timer_RT820_CellValidated);
				DataGridViewCellFormattingEventHandler dataGridViewCellFormattingEventHandler = new DataGridViewCellFormattingEventHandler(this.DataGridView_timer_RT820_CellFormatting);
				EventHandler eventHandler = new EventHandler(this.DataGridView_timer_RT820_CurrentCellDirtyStateChanged);
				if (this._DataGridView_timer_RT820 != null)
				{
					this._DataGridView_timer_RT820.CellValidated -= dataGridViewCellEventHandler;
					this._DataGridView_timer_RT820.CellFormatting -= dataGridViewCellFormattingEventHandler;
					this._DataGridView_timer_RT820.CurrentCellDirtyStateChanged -= eventHandler;
				}
				this._DataGridView_timer_RT820 = value;
				if (this._DataGridView_timer_RT820 != null)
				{
					this._DataGridView_timer_RT820.CellValidated += dataGridViewCellEventHandler;
					this._DataGridView_timer_RT820.CellFormatting += dataGridViewCellFormattingEventHandler;
					this._DataGridView_timer_RT820.CurrentCellDirtyStateChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x00339CC0 File Offset: 0x003380C0
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x00339CD4 File Offset: 0x003380D4
		internal virtual DataGridView DataGridView1
		{
			get
			{
				return this._DataGridView1;
			}
			[MethodImpl(32)]
			set
			{
				this._DataGridView1 = value;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x00339CE0 File Offset: 0x003380E0
		// (set) Token: 0x0600143F RID: 5183 RVA: 0x00339CF4 File Offset: 0x003380F4
		internal virtual DataGridViewTextBoxColumn Column2
		{
			get
			{
				return this._Column2;
			}
			[MethodImpl(32)]
			set
			{
				this._Column2 = value;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x00339D00 File Offset: 0x00338100
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x00339D14 File Offset: 0x00338114
		internal virtual DataGridViewTextBoxColumn Column3
		{
			get
			{
				return this._Column3;
			}
			[MethodImpl(32)]
			set
			{
				this._Column3 = value;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x00339D20 File Offset: 0x00338120
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x00339D34 File Offset: 0x00338134
		internal virtual DataGridViewTextBoxColumn Column4
		{
			get
			{
				return this._Column4;
			}
			[MethodImpl(32)]
			set
			{
				this._Column4 = value;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x00339D40 File Offset: 0x00338140
		// (set) Token: 0x06001445 RID: 5189 RVA: 0x00339D54 File Offset: 0x00338154
		internal virtual DataGridViewTextBoxColumn Column5
		{
			get
			{
				return this._Column5;
			}
			[MethodImpl(32)]
			set
			{
				this._Column5 = value;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x00339D60 File Offset: 0x00338160
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x00339D74 File Offset: 0x00338174
		internal virtual DataGridViewTextBoxColumn Column6
		{
			get
			{
				return this._Column6;
			}
			[MethodImpl(32)]
			set
			{
				this._Column6 = value;
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x00339D80 File Offset: 0x00338180
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x00339D94 File Offset: 0x00338194
		internal virtual DataGridViewTextBoxColumn Column7
		{
			get
			{
				return this._Column7;
			}
			[MethodImpl(32)]
			set
			{
				this._Column7 = value;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x00339DA0 File Offset: 0x003381A0
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x00339DB4 File Offset: 0x003381B4
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

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x00339DC0 File Offset: 0x003381C0
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x00339DD4 File Offset: 0x003381D4
		internal virtual GroupBox GroupBox_ED_820
		{
			get
			{
				return this._GroupBox_ED_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_ED_820 = value;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x00339DE0 File Offset: 0x003381E0
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x00339DF4 File Offset: 0x003381F4
		internal virtual DataGridView DataGridView_RT820_ED
		{
			get
			{
				return this._DataGridView_RT820_ED;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_RT820_ED_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_RT820_ED_CellValueChanged);
				if (this._DataGridView_RT820_ED != null)
				{
					this._DataGridView_RT820_ED.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_RT820_ED.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_RT820_ED = value;
				if (this._DataGridView_RT820_ED != null)
				{
					this._DataGridView_RT820_ED.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_RT820_ED.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x00339E64 File Offset: 0x00338264
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x00339E78 File Offset: 0x00338278
		internal virtual ToolStripButton ToolStripButton_RT820_Imprimir
		{
			get
			{
				return this._ToolStripButton_RT820_Imprimir;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT820_Imprimir_Click);
				if (this._ToolStripButton_RT820_Imprimir != null)
				{
					this._ToolStripButton_RT820_Imprimir.Click -= eventHandler;
				}
				this._ToolStripButton_RT820_Imprimir = value;
				if (this._ToolStripButton_RT820_Imprimir != null)
				{
					this._ToolStripButton_RT820_Imprimir.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x00339EC4 File Offset: 0x003382C4
		// (set) Token: 0x06001453 RID: 5203 RVA: 0x00339ED8 File Offset: 0x003382D8
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

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x00339F70 File Offset: 0x00338370
		// (set) Token: 0x06001455 RID: 5205 RVA: 0x00339F84 File Offset: 0x00338384
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

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x00339F90 File Offset: 0x00338390
		// (set) Token: 0x06001457 RID: 5207 RVA: 0x00339FA4 File Offset: 0x003383A4
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

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x00339FB0 File Offset: 0x003383B0
		// (set) Token: 0x06001459 RID: 5209 RVA: 0x00339FC4 File Offset: 0x003383C4
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

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x00339FD0 File Offset: 0x003383D0
		// (set) Token: 0x0600145B RID: 5211 RVA: 0x00339FE4 File Offset: 0x003383E4
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

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x00339FF0 File Offset: 0x003383F0
		// (set) Token: 0x0600145D RID: 5213 RVA: 0x0033A004 File Offset: 0x00338404
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

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x0033A010 File Offset: 0x00338410
		// (set) Token: 0x0600145F RID: 5215 RVA: 0x0033A024 File Offset: 0x00338424
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

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0033A030 File Offset: 0x00338430
		// (set) Token: 0x06001461 RID: 5217 RVA: 0x0033A044 File Offset: 0x00338444
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

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0033A050 File Offset: 0x00338450
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x0033A064 File Offset: 0x00338464
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

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x0033A070 File Offset: 0x00338470
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x0033A084 File Offset: 0x00338484
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

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x0033A090 File Offset: 0x00338490
		// (set) Token: 0x06001467 RID: 5223 RVA: 0x0033A0A4 File Offset: 0x003384A4
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

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0033A0B0 File Offset: 0x003384B0
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x0033A0C4 File Offset: 0x003384C4
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

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x0033A0D0 File Offset: 0x003384D0
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x0033A0E4 File Offset: 0x003384E4
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

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x0033A0F0 File Offset: 0x003384F0
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x0033A104 File Offset: 0x00338504
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

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x0033A110 File Offset: 0x00338510
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x0033A124 File Offset: 0x00338524
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

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x0033A130 File Offset: 0x00338530
		// (set) Token: 0x06001471 RID: 5233 RVA: 0x0033A144 File Offset: 0x00338544
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

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x0033A150 File Offset: 0x00338550
		// (set) Token: 0x06001473 RID: 5235 RVA: 0x0033A164 File Offset: 0x00338564
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

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x0033A170 File Offset: 0x00338570
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x0033A184 File Offset: 0x00338584
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

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x0033A190 File Offset: 0x00338590
		// (set) Token: 0x06001477 RID: 5239 RVA: 0x0033A1A4 File Offset: 0x003385A4
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

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x0033A1B0 File Offset: 0x003385B0
		// (set) Token: 0x06001479 RID: 5241 RVA: 0x0033A1C4 File Offset: 0x003385C4
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

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x0033A1D0 File Offset: 0x003385D0
		// (set) Token: 0x0600147B RID: 5243 RVA: 0x0033A1E4 File Offset: 0x003385E4
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

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x0033A1F0 File Offset: 0x003385F0
		// (set) Token: 0x0600147D RID: 5245 RVA: 0x0033A204 File Offset: 0x00338604
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

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x0033A210 File Offset: 0x00338610
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x0033A224 File Offset: 0x00338624
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

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x0033A230 File Offset: 0x00338630
		// (set) Token: 0x06001481 RID: 5249 RVA: 0x0033A244 File Offset: 0x00338644
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

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x0033A250 File Offset: 0x00338650
		// (set) Token: 0x06001483 RID: 5251 RVA: 0x0033A264 File Offset: 0x00338664
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

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x0033A270 File Offset: 0x00338670
		// (set) Token: 0x06001485 RID: 5253 RVA: 0x0033A284 File Offset: 0x00338684
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

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x0033A290 File Offset: 0x00338690
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x0033A2A4 File Offset: 0x003386A4
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

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x0033A2B0 File Offset: 0x003386B0
		// (set) Token: 0x06001489 RID: 5257 RVA: 0x0033A2C4 File Offset: 0x003386C4
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

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x0033A2D0 File Offset: 0x003386D0
		// (set) Token: 0x0600148B RID: 5259 RVA: 0x0033A2E4 File Offset: 0x003386E4
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

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0033A2F0 File Offset: 0x003386F0
		// (set) Token: 0x0600148D RID: 5261 RVA: 0x0033A304 File Offset: 0x00338704
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

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x0033A310 File Offset: 0x00338710
		// (set) Token: 0x0600148F RID: 5263 RVA: 0x0033A324 File Offset: 0x00338724
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

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x0033A330 File Offset: 0x00338730
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x0033A344 File Offset: 0x00338744
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

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x0033A350 File Offset: 0x00338750
		// (set) Token: 0x06001493 RID: 5267 RVA: 0x0033A364 File Offset: 0x00338764
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

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x0033A370 File Offset: 0x00338770
		// (set) Token: 0x06001495 RID: 5269 RVA: 0x0033A384 File Offset: 0x00338784
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

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x0033A390 File Offset: 0x00338790
		// (set) Token: 0x06001497 RID: 5271 RVA: 0x0033A3A4 File Offset: 0x003387A4
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

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x0033A3B0 File Offset: 0x003387B0
		// (set) Token: 0x06001499 RID: 5273 RVA: 0x0033A3C4 File Offset: 0x003387C4
		internal virtual TextBox TextBox_equipamento_820
		{
			get
			{
				return this._TextBox_equipamento_820;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_equipamento_820 = value;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x0033A3D0 File Offset: 0x003387D0
		// (set) Token: 0x0600149B RID: 5275 RVA: 0x0033A3E4 File Offset: 0x003387E4
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

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x0033A3F0 File Offset: 0x003387F0
		// (set) Token: 0x0600149D RID: 5277 RVA: 0x0033A404 File Offset: 0x00338804
		internal virtual TextBox TextBox_release_820
		{
			get
			{
				return this._TextBox_release_820;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_release_820 = value;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x0033A410 File Offset: 0x00338810
		// (set) Token: 0x0600149F RID: 5279 RVA: 0x0033A424 File Offset: 0x00338824
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

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x0033A430 File Offset: 0x00338830
		// (set) Token: 0x060014A1 RID: 5281 RVA: 0x0033A444 File Offset: 0x00338844
		internal virtual TextBox TextBox_build_820
		{
			get
			{
				return this._TextBox_build_820;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_build_820 = value;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x0033A450 File Offset: 0x00338850
		// (set) Token: 0x060014A3 RID: 5283 RVA: 0x0033A464 File Offset: 0x00338864
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

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x0033A470 File Offset: 0x00338870
		// (set) Token: 0x060014A5 RID: 5285 RVA: 0x0033A484 File Offset: 0x00338884
		internal virtual TextBox TextBox_versao_820
		{
			get
			{
				return this._TextBox_versao_820;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_versao_820 = value;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x0033A490 File Offset: 0x00338890
		// (set) Token: 0x060014A7 RID: 5287 RVA: 0x0033A4A4 File Offset: 0x003388A4
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

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x0033A4B0 File Offset: 0x003388B0
		// (set) Token: 0x060014A9 RID: 5289 RVA: 0x0033A4C4 File Offset: 0x003388C4
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

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x0033A4D0 File Offset: 0x003388D0
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x0033A4E4 File Offset: 0x003388E4
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

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x0033A4F0 File Offset: 0x003388F0
		// (set) Token: 0x060014AD RID: 5293 RVA: 0x0033A504 File Offset: 0x00338904
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

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x0033A510 File Offset: 0x00338910
		// (set) Token: 0x060014AF RID: 5295 RVA: 0x0033A524 File Offset: 0x00338924
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

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x0033A530 File Offset: 0x00338930
		// (set) Token: 0x060014B1 RID: 5297 RVA: 0x0033A544 File Offset: 0x00338944
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

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x0033A550 File Offset: 0x00338950
		// (set) Token: 0x060014B3 RID: 5299 RVA: 0x0033A564 File Offset: 0x00338964
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

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x0033A570 File Offset: 0x00338970
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x0033A584 File Offset: 0x00338984
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

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x0033A590 File Offset: 0x00338990
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x0033A5A4 File Offset: 0x003389A4
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

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x0033A5B0 File Offset: 0x003389B0
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x0033A5C4 File Offset: 0x003389C4
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

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x0033A5D0 File Offset: 0x003389D0
		// (set) Token: 0x060014BB RID: 5307 RVA: 0x0033A5E4 File Offset: 0x003389E4
		internal virtual DataGridView dgv_sph
		{
			get
			{
				return this._dgv_sph;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.dgv_sph_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_sph_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgv_sph_CellValidating);
				if (this._dgv_sph != null)
				{
					this._dgv_sph.CurrentCellDirtyStateChanged -= eventHandler;
					this._dgv_sph.CellValueChanged -= dataGridViewCellEventHandler;
					this._dgv_sph.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._dgv_sph = value;
				if (this._dgv_sph != null)
				{
					this._dgv_sph.CurrentCellDirtyStateChanged += eventHandler;
					this._dgv_sph.CellValueChanged += dataGridViewCellEventHandler;
					this._dgv_sph.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x0033A67C File Offset: 0x00338A7C
		// (set) Token: 0x060014BD RID: 5309 RVA: 0x0033A690 File Offset: 0x00338A90
		internal virtual Label Label73
		{
			get
			{
				return this._Label73;
			}
			[MethodImpl(32)]
			set
			{
				this._Label73 = value;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x0033A69C File Offset: 0x00338A9C
		// (set) Token: 0x060014BF RID: 5311 RVA: 0x0033A6B0 File Offset: 0x00338AB0
		internal virtual DataGridViewTextBoxColumn col_sph_horario
		{
			get
			{
				return this._col_sph_horario;
			}
			[MethodImpl(32)]
			set
			{
				this._col_sph_horario = value;
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x0033A6BC File Offset: 0x00338ABC
		// (set) Token: 0x060014C1 RID: 5313 RVA: 0x0033A6D0 File Offset: 0x00338AD0
		internal virtual DataGridViewCheckBoxColumn col_sph_ativa
		{
			get
			{
				return this._col_sph_ativa;
			}
			[MethodImpl(32)]
			set
			{
				this._col_sph_ativa = value;
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x0033A6DC File Offset: 0x00338ADC
		// (set) Token: 0x060014C3 RID: 5315 RVA: 0x0033A6F0 File Offset: 0x00338AF0
		internal virtual DataGridViewTextBoxColumn col_sph_hora
		{
			get
			{
				return this._col_sph_hora;
			}
			[MethodImpl(32)]
			set
			{
				this._col_sph_hora = value;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x0033A6FC File Offset: 0x00338AFC
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x0033A710 File Offset: 0x00338B10
		internal virtual DataGridViewTextBoxColumn col_sph_minuto
		{
			get
			{
				return this._col_sph_minuto;
			}
			[MethodImpl(32)]
			set
			{
				this._col_sph_minuto = value;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x0033A71C File Offset: 0x00338B1C
		// (set) Token: 0x060014C7 RID: 5319 RVA: 0x0033A730 File Offset: 0x00338B30
		internal virtual DataGridViewTextBoxColumn col_sph_alto
		{
			get
			{
				return this._col_sph_alto;
			}
			[MethodImpl(32)]
			set
			{
				this._col_sph_alto = value;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x0033A73C File Offset: 0x00338B3C
		// (set) Token: 0x060014C9 RID: 5321 RVA: 0x0033A750 File Offset: 0x00338B50
		internal virtual DataGridViewTextBoxColumn col_sph_baixo
		{
			get
			{
				return this._col_sph_baixo;
			}
			[MethodImpl(32)]
			set
			{
				this._col_sph_baixo = value;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x0033A75C File Offset: 0x00338B5C
		// (set) Token: 0x060014CB RID: 5323 RVA: 0x0033A770 File Offset: 0x00338B70
		internal virtual ComboBox cb_ModoRepetidora
		{
			get
			{
				return this._cb_ModoRepetidora;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_ModoRepetidora_SelectedIndexChanged);
				if (this._cb_ModoRepetidora != null)
				{
					this._cb_ModoRepetidora.SelectedIndexChanged -= eventHandler;
				}
				this._cb_ModoRepetidora = value;
				if (this._cb_ModoRepetidora != null)
				{
					this._cb_ModoRepetidora.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x0033A7BC File Offset: 0x00338BBC
		// (set) Token: 0x060014CD RID: 5325 RVA: 0x0033A7D0 File Offset: 0x00338BD0
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

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x0033A7DC File Offset: 0x00338BDC
		// (set) Token: 0x060014CF RID: 5327 RVA: 0x0033A7F0 File Offset: 0x00338BF0
		internal virtual TabPage TabPage_Atuadores
		{
			get
			{
				return this._TabPage_Atuadores;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_Atuadores = value;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x0033A7FC File Offset: 0x00338BFC
		// (set) Token: 0x060014D1 RID: 5329 RVA: 0x0033A810 File Offset: 0x00338C10
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

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x0033A81C File Offset: 0x00338C1C
		// (set) Token: 0x060014D3 RID: 5331 RVA: 0x0033A830 File Offset: 0x00338C30
		internal virtual DataGridView dgv_atuador1
		{
			get
			{
				return this._dgv_atuador1;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgv_atuador1_CellValidating);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler2 = new DataGridViewCellValidatingEventHandler(this.dgv_atuador1_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_atuador1_CellValueChanged);
				EventHandler eventHandler = new EventHandler(this.dgv_atuador1_CurrentCellDirtyStateChanged);
				if (this._dgv_atuador1 != null)
				{
					this._dgv_atuador1.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._dgv_atuador1.CellValidating -= dataGridViewCellValidatingEventHandler2;
					this._dgv_atuador1.CellValueChanged -= dataGridViewCellEventHandler;
					this._dgv_atuador1.CurrentCellDirtyStateChanged -= eventHandler;
				}
				this._dgv_atuador1 = value;
				if (this._dgv_atuador1 != null)
				{
					this._dgv_atuador1.CellValidating += dataGridViewCellValidatingEventHandler;
					this._dgv_atuador1.CellValidating += dataGridViewCellValidatingEventHandler2;
					this._dgv_atuador1.CellValueChanged += dataGridViewCellEventHandler;
					this._dgv_atuador1.CurrentCellDirtyStateChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x0033A8EC File Offset: 0x00338CEC
		// (set) Token: 0x060014D5 RID: 5333 RVA: 0x0033A900 File Offset: 0x00338D00
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

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x0033A90C File Offset: 0x00338D0C
		// (set) Token: 0x060014D7 RID: 5335 RVA: 0x0033A920 File Offset: 0x00338D20
		internal virtual DataGridView datagridview_referenciaperifico
		{
			get
			{
				return this._datagridview_referenciaperifico;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.datagridview_referenciaperifico_CellValidating_1);
				EventHandler eventHandler = new EventHandler(this.datagridview_referenciaperifico_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.datagridview_referenciaperifico_CellValueChanged);
				if (this._datagridview_referenciaperifico != null)
				{
					this._datagridview_referenciaperifico.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._datagridview_referenciaperifico.CurrentCellDirtyStateChanged -= eventHandler;
					this._datagridview_referenciaperifico.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._datagridview_referenciaperifico = value;
				if (this._datagridview_referenciaperifico != null)
				{
					this._datagridview_referenciaperifico.CellValidating += dataGridViewCellValidatingEventHandler;
					this._datagridview_referenciaperifico.CurrentCellDirtyStateChanged += eventHandler;
					this._datagridview_referenciaperifico.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x0033A9B8 File Offset: 0x00338DB8
		// (set) Token: 0x060014D9 RID: 5337 RVA: 0x0033A9CC File Offset: 0x00338DCC
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

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x0033A9D8 File Offset: 0x00338DD8
		// (set) Token: 0x060014DB RID: 5339 RVA: 0x0033A9EC File Offset: 0x00338DEC
		internal virtual DataGridView dgv_atuador_setpoint2
		{
			get
			{
				return this._dgv_atuador_setpoint2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.dgv_atuador_setpoint2_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_atuador_setpoint2_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgv_atuador_setpoint2_CellValidating);
				if (this._dgv_atuador_setpoint2 != null)
				{
					this._dgv_atuador_setpoint2.CurrentCellDirtyStateChanged -= eventHandler;
					this._dgv_atuador_setpoint2.CellValueChanged -= dataGridViewCellEventHandler;
					this._dgv_atuador_setpoint2.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._dgv_atuador_setpoint2 = value;
				if (this._dgv_atuador_setpoint2 != null)
				{
					this._dgv_atuador_setpoint2.CurrentCellDirtyStateChanged += eventHandler;
					this._dgv_atuador_setpoint2.CellValueChanged += dataGridViewCellEventHandler;
					this._dgv_atuador_setpoint2.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x0033AA84 File Offset: 0x00338E84
		// (set) Token: 0x060014DD RID: 5341 RVA: 0x0033AA98 File Offset: 0x00338E98
		internal virtual DataGridView dgv_atuador2
		{
			get
			{
				return this._dgv_atuador2;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_atuador2_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgv_atuador2_CellValidating);
				EventHandler eventHandler = new EventHandler(this.dgv_atuador2_CurrentCellDirtyStateChanged);
				if (this._dgv_atuador2 != null)
				{
					this._dgv_atuador2.CellValueChanged -= dataGridViewCellEventHandler;
					this._dgv_atuador2.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._dgv_atuador2.CurrentCellDirtyStateChanged -= eventHandler;
				}
				this._dgv_atuador2 = value;
				if (this._dgv_atuador2 != null)
				{
					this._dgv_atuador2.CellValueChanged += dataGridViewCellEventHandler;
					this._dgv_atuador2.CellValidating += dataGridViewCellValidatingEventHandler;
					this._dgv_atuador2.CurrentCellDirtyStateChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x0033AB30 File Offset: 0x00338F30
		// (set) Token: 0x060014DF RID: 5343 RVA: 0x0033AB44 File Offset: 0x00338F44
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

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x0033AB50 File Offset: 0x00338F50
		// (set) Token: 0x060014E1 RID: 5345 RVA: 0x0033AB64 File Offset: 0x00338F64
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

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x0033AB70 File Offset: 0x00338F70
		// (set) Token: 0x060014E3 RID: 5347 RVA: 0x0033AB84 File Offset: 0x00338F84
		internal virtual DataGridView dgv_atuador_setpoint1
		{
			get
			{
				return this._dgv_atuador_setpoint1;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_atuador_setpoint1_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgv_atuador_setpoint1_CellValidating);
				EventHandler eventHandler = new EventHandler(this.dgv_atuador_setpoint1_CurrentCellDirtyStateChanged);
				if (this._dgv_atuador_setpoint1 != null)
				{
					this._dgv_atuador_setpoint1.CellValueChanged -= dataGridViewCellEventHandler;
					this._dgv_atuador_setpoint1.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._dgv_atuador_setpoint1.CurrentCellDirtyStateChanged -= eventHandler;
				}
				this._dgv_atuador_setpoint1 = value;
				if (this._dgv_atuador_setpoint1 != null)
				{
					this._dgv_atuador_setpoint1.CellValueChanged += dataGridViewCellEventHandler;
					this._dgv_atuador_setpoint1.CellValidating += dataGridViewCellValidatingEventHandler;
					this._dgv_atuador_setpoint1.CurrentCellDirtyStateChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x0033AC1C File Offset: 0x0033901C
		// (set) Token: 0x060014E5 RID: 5349 RVA: 0x0033AC30 File Offset: 0x00339030
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

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0033AC3C File Offset: 0x0033903C
		// (set) Token: 0x060014E7 RID: 5351 RVA: 0x0033AC50 File Offset: 0x00339050
		internal virtual DataGridView dgv_atuador_setpoint11
		{
			get
			{
				return this._dgv_atuador_setpoint11;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_atuador_setpoint11_CellValueChanged);
				EventHandler eventHandler = new EventHandler(this.dgv_atuador_setpoint11_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler2 = new DataGridViewCellEventHandler(this.dgv_atuador_setpoint11_CellContentClick);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgv_atuador_setpoint11_CellValidating);
				if (this._dgv_atuador_setpoint11 != null)
				{
					this._dgv_atuador_setpoint11.CellValueChanged -= dataGridViewCellEventHandler;
					this._dgv_atuador_setpoint11.CurrentCellDirtyStateChanged -= eventHandler;
					this._dgv_atuador_setpoint11.CellContentClick -= dataGridViewCellEventHandler2;
					this._dgv_atuador_setpoint11.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._dgv_atuador_setpoint11 = value;
				if (this._dgv_atuador_setpoint11 != null)
				{
					this._dgv_atuador_setpoint11.CellValueChanged += dataGridViewCellEventHandler;
					this._dgv_atuador_setpoint11.CurrentCellDirtyStateChanged += eventHandler;
					this._dgv_atuador_setpoint11.CellContentClick += dataGridViewCellEventHandler2;
					this._dgv_atuador_setpoint11.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x0033AD0C File Offset: 0x0033910C
		// (set) Token: 0x060014E9 RID: 5353 RVA: 0x0033AD20 File Offset: 0x00339120
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

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x0033AD2C File Offset: 0x0033912C
		// (set) Token: 0x060014EB RID: 5355 RVA: 0x0033AD40 File Offset: 0x00339140
		internal virtual DataGridView dgv_atuador_setpoint21
		{
			get
			{
				return this._dgv_atuador_setpoint21;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_atuador_setpoint21_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgv_atuador_setpoint21_CellValidating);
				EventHandler eventHandler = new EventHandler(this.dgv_atuador_setpoint21_CurrentCellDirtyStateChanged);
				if (this._dgv_atuador_setpoint21 != null)
				{
					this._dgv_atuador_setpoint21.CellValueChanged -= dataGridViewCellEventHandler;
					this._dgv_atuador_setpoint21.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._dgv_atuador_setpoint21.CurrentCellDirtyStateChanged -= eventHandler;
				}
				this._dgv_atuador_setpoint21 = value;
				if (this._dgv_atuador_setpoint21 != null)
				{
					this._dgv_atuador_setpoint21.CellValueChanged += dataGridViewCellEventHandler;
					this._dgv_atuador_setpoint21.CellValidating += dataGridViewCellValidatingEventHandler;
					this._dgv_atuador_setpoint21.CurrentCellDirtyStateChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x0033ADD8 File Offset: 0x003391D8
		// (set) Token: 0x060014ED RID: 5357 RVA: 0x0033ADEC File Offset: 0x003391EC
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

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x0033ADF8 File Offset: 0x003391F8
		// (set) Token: 0x060014EF RID: 5359 RVA: 0x0033AE0C File Offset: 0x0033920C
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

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x0033AE18 File Offset: 0x00339218
		// (set) Token: 0x060014F1 RID: 5361 RVA: 0x0033AE2C File Offset: 0x0033922C
		internal virtual NumericUpDown nud_tempoforaar
		{
			get
			{
				return this._nud_tempoforaar;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_tempoforaar_ValueChanged);
				if (this._nud_tempoforaar != null)
				{
					this._nud_tempoforaar.ValueChanged -= eventHandler;
				}
				this._nud_tempoforaar = value;
				if (this._nud_tempoforaar != null)
				{
					this._nud_tempoforaar.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x0033AE78 File Offset: 0x00339278
		// (set) Token: 0x060014F3 RID: 5363 RVA: 0x0033AE8C File Offset: 0x0033928C
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

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x0033AE98 File Offset: 0x00339298
		// (set) Token: 0x060014F5 RID: 5365 RVA: 0x0033AEAC File Offset: 0x003392AC
		internal virtual TabPage TabPage_Atuadores2
		{
			get
			{
				return this._TabPage_Atuadores2;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_Atuadores2 = value;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x0033AEB8 File Offset: 0x003392B8
		// (set) Token: 0x060014F7 RID: 5367 RVA: 0x0033AECC File Offset: 0x003392CC
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

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x0033AED8 File Offset: 0x003392D8
		// (set) Token: 0x060014F9 RID: 5369 RVA: 0x0033AEEC File Offset: 0x003392EC
		internal virtual DataGridView dgv_atuador_setpoint41
		{
			get
			{
				return this._dgv_atuador_setpoint41;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_atuador_setpoint41_CellValueChanged);
				EventHandler eventHandler = new EventHandler(this.dgv_atuador_setpoint41_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgv_atuador_setpoint41_CellValidating);
				if (this._dgv_atuador_setpoint41 != null)
				{
					this._dgv_atuador_setpoint41.CellValueChanged -= dataGridViewCellEventHandler;
					this._dgv_atuador_setpoint41.CurrentCellDirtyStateChanged -= eventHandler;
					this._dgv_atuador_setpoint41.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._dgv_atuador_setpoint41 = value;
				if (this._dgv_atuador_setpoint41 != null)
				{
					this._dgv_atuador_setpoint41.CellValueChanged += dataGridViewCellEventHandler;
					this._dgv_atuador_setpoint41.CurrentCellDirtyStateChanged += eventHandler;
					this._dgv_atuador_setpoint41.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x0033AF84 File Offset: 0x00339384
		// (set) Token: 0x060014FB RID: 5371 RVA: 0x0033AF98 File Offset: 0x00339398
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

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x0033AFA4 File Offset: 0x003393A4
		// (set) Token: 0x060014FD RID: 5373 RVA: 0x0033AFB8 File Offset: 0x003393B8
		internal virtual DataGridView dgv_atuador_setpoint4
		{
			get
			{
				return this._dgv_atuador_setpoint4;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_atuador_setpoint4_CellValueChanged);
				EventHandler eventHandler = new EventHandler(this.dgv_atuador_setpoint4_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgv_atuador_setpoint4_CellValidating);
				if (this._dgv_atuador_setpoint4 != null)
				{
					this._dgv_atuador_setpoint4.CellValueChanged -= dataGridViewCellEventHandler;
					this._dgv_atuador_setpoint4.CurrentCellDirtyStateChanged -= eventHandler;
					this._dgv_atuador_setpoint4.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._dgv_atuador_setpoint4 = value;
				if (this._dgv_atuador_setpoint4 != null)
				{
					this._dgv_atuador_setpoint4.CellValueChanged += dataGridViewCellEventHandler;
					this._dgv_atuador_setpoint4.CurrentCellDirtyStateChanged += eventHandler;
					this._dgv_atuador_setpoint4.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x0033B050 File Offset: 0x00339450
		// (set) Token: 0x060014FF RID: 5375 RVA: 0x0033B064 File Offset: 0x00339464
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

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x0033B070 File Offset: 0x00339470
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x0033B084 File Offset: 0x00339484
		internal virtual DataGridView dgv_atuador4
		{
			get
			{
				return this._dgv_atuador4;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_atuador4_CellValueChanged);
				EventHandler eventHandler = new EventHandler(this.dgv_atuador4_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgv_atuador4_CellValidating);
				if (this._dgv_atuador4 != null)
				{
					this._dgv_atuador4.CellValueChanged -= dataGridViewCellEventHandler;
					this._dgv_atuador4.CurrentCellDirtyStateChanged -= eventHandler;
					this._dgv_atuador4.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._dgv_atuador4 = value;
				if (this._dgv_atuador4 != null)
				{
					this._dgv_atuador4.CellValueChanged += dataGridViewCellEventHandler;
					this._dgv_atuador4.CurrentCellDirtyStateChanged += eventHandler;
					this._dgv_atuador4.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x0033B11C File Offset: 0x0033951C
		// (set) Token: 0x06001503 RID: 5379 RVA: 0x0033B130 File Offset: 0x00339530
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

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x0033B13C File Offset: 0x0033953C
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x0033B150 File Offset: 0x00339550
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

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x0033B15C File Offset: 0x0033955C
		// (set) Token: 0x06001507 RID: 5383 RVA: 0x0033B170 File Offset: 0x00339570
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

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x0033B17C File Offset: 0x0033957C
		// (set) Token: 0x06001509 RID: 5385 RVA: 0x0033B190 File Offset: 0x00339590
		internal virtual DataGridView dgv_atuador_setpoint31
		{
			get
			{
				return this._dgv_atuador_setpoint31;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_atuador_setpoint31_CellValueChanged);
				EventHandler eventHandler = new EventHandler(this.dgv_atuador_setpoint31_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgv_atuador_setpoint31_CellValidating);
				if (this._dgv_atuador_setpoint31 != null)
				{
					this._dgv_atuador_setpoint31.CellValueChanged -= dataGridViewCellEventHandler;
					this._dgv_atuador_setpoint31.CurrentCellDirtyStateChanged -= eventHandler;
					this._dgv_atuador_setpoint31.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._dgv_atuador_setpoint31 = value;
				if (this._dgv_atuador_setpoint31 != null)
				{
					this._dgv_atuador_setpoint31.CellValueChanged += dataGridViewCellEventHandler;
					this._dgv_atuador_setpoint31.CurrentCellDirtyStateChanged += eventHandler;
					this._dgv_atuador_setpoint31.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x0033B228 File Offset: 0x00339628
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x0033B23C File Offset: 0x0033963C
		internal virtual DataGridView dgv_atuador_setpoint3
		{
			get
			{
				return this._dgv_atuador_setpoint3;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_atuador_setpoint3_CellValueChanged);
				EventHandler eventHandler = new EventHandler(this.dgv_atuador_setpoint3_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgv_atuador_setpoint3_CellValidating);
				if (this._dgv_atuador_setpoint3 != null)
				{
					this._dgv_atuador_setpoint3.CellValueChanged -= dataGridViewCellEventHandler;
					this._dgv_atuador_setpoint3.CurrentCellDirtyStateChanged -= eventHandler;
					this._dgv_atuador_setpoint3.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._dgv_atuador_setpoint3 = value;
				if (this._dgv_atuador_setpoint3 != null)
				{
					this._dgv_atuador_setpoint3.CellValueChanged += dataGridViewCellEventHandler;
					this._dgv_atuador_setpoint3.CurrentCellDirtyStateChanged += eventHandler;
					this._dgv_atuador_setpoint3.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x0033B2D4 File Offset: 0x003396D4
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x0033B2E8 File Offset: 0x003396E8
		internal virtual DataGridView dgv_atuador3
		{
			get
			{
				return this._dgv_atuador3;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_atuador3_CellValueChanged);
				EventHandler eventHandler = new EventHandler(this.dgv_atuador3_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgv_atuador3_CellValidating);
				if (this._dgv_atuador3 != null)
				{
					this._dgv_atuador3.CellValueChanged -= dataGridViewCellEventHandler;
					this._dgv_atuador3.CurrentCellDirtyStateChanged -= eventHandler;
					this._dgv_atuador3.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._dgv_atuador3 = value;
				if (this._dgv_atuador3 != null)
				{
					this._dgv_atuador3.CellValueChanged += dataGridViewCellEventHandler;
					this._dgv_atuador3.CurrentCellDirtyStateChanged += eventHandler;
					this._dgv_atuador3.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x0033B380 File Offset: 0x00339780
		// (set) Token: 0x0600150F RID: 5391 RVA: 0x0033B394 File Offset: 0x00339794
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

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x0033B3A0 File Offset: 0x003397A0
		// (set) Token: 0x06001511 RID: 5393 RVA: 0x0033B3B4 File Offset: 0x003397B4
		internal virtual ComboBox ComboBox_baudrate_COM1_820
		{
			get
			{
				return this._ComboBox_baudrate_COM1_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_baudrate_COM1_820_SelectedIndexChanged);
				if (this._ComboBox_baudrate_COM1_820 != null)
				{
					this._ComboBox_baudrate_COM1_820.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_baudrate_COM1_820 = value;
				if (this._ComboBox_baudrate_COM1_820 != null)
				{
					this._ComboBox_baudrate_COM1_820.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x0033B400 File Offset: 0x00339800
		// (set) Token: 0x06001513 RID: 5395 RVA: 0x0033B414 File Offset: 0x00339814
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

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x0033B420 File Offset: 0x00339820
		// (set) Token: 0x06001515 RID: 5397 RVA: 0x0033B434 File Offset: 0x00339834
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

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x0033B440 File Offset: 0x00339840
		// (set) Token: 0x06001517 RID: 5399 RVA: 0x0033B454 File Offset: 0x00339854
		internal virtual GroupBox GroupBox8
		{
			get
			{
				return this._GroupBox8;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox8 = value;
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x0033B460 File Offset: 0x00339860
		// (set) Token: 0x06001519 RID: 5401 RVA: 0x0033B474 File Offset: 0x00339874
		internal virtual CheckBox ckb_tratamento_setpoint
		{
			get
			{
				return this._ckb_tratamento_setpoint;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ckb_tratamento_setpoint_CheckedChanged);
				if (this._ckb_tratamento_setpoint != null)
				{
					this._ckb_tratamento_setpoint.CheckedChanged -= eventHandler;
				}
				this._ckb_tratamento_setpoint = value;
				if (this._ckb_tratamento_setpoint != null)
				{
					this._ckb_tratamento_setpoint.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x0033B4C0 File Offset: 0x003398C0
		// (set) Token: 0x0600151B RID: 5403 RVA: 0x0033B4D4 File Offset: 0x003398D4
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

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x0033B4E0 File Offset: 0x003398E0
		// (set) Token: 0x0600151D RID: 5405 RVA: 0x0033B4F4 File Offset: 0x003398F4
		internal virtual TabPage TabPage_vazao
		{
			get
			{
				return this._TabPage_vazao;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_vazao = value;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x0033B500 File Offset: 0x00339900
		// (set) Token: 0x0600151F RID: 5407 RVA: 0x0033B514 File Offset: 0x00339914
		internal virtual GroupBox GroupBox_vazoes_820
		{
			get
			{
				return this._GroupBox_vazoes_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_vazoes_820 = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x0033B520 File Offset: 0x00339920
		// (set) Token: 0x06001521 RID: 5409 RVA: 0x0033B534 File Offset: 0x00339934
		internal virtual DataGridView DataGridView_vazoes_RT820
		{
			get
			{
				return this._DataGridView_vazoes_RT820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_vazoes_RT820_CurrentCellDirtyStateChanged_1);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_vazoes_RT820_CellValueChanged_1);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_vazoes_RT820_CellValidating_1);
				if (this._DataGridView_vazoes_RT820 != null)
				{
					this._DataGridView_vazoes_RT820.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_vazoes_RT820.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_vazoes_RT820.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_vazoes_RT820 = value;
				if (this._DataGridView_vazoes_RT820 != null)
				{
					this._DataGridView_vazoes_RT820.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_vazoes_RT820.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_vazoes_RT820.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x0033B5CC File Offset: 0x003399CC
		// (set) Token: 0x06001523 RID: 5411 RVA: 0x0033B5E0 File Offset: 0x003399E0
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

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x0033B5EC File Offset: 0x003399EC
		// (set) Token: 0x06001525 RID: 5413 RVA: 0x0033B600 File Offset: 0x00339A00
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

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x0033B60C File Offset: 0x00339A0C
		// (set) Token: 0x06001527 RID: 5415 RVA: 0x0033B620 File Offset: 0x00339A20
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

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x0033B62C File Offset: 0x00339A2C
		// (set) Token: 0x06001529 RID: 5417 RVA: 0x0033B640 File Offset: 0x00339A40
		internal virtual NumericUpDown NumericUpDown_end2_est_820
		{
			get
			{
				return this._NumericUpDown_end2_est_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end2_est_820_ValueChanged);
				if (this._NumericUpDown_end2_est_820 != null)
				{
					this._NumericUpDown_end2_est_820.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end2_est_820 = value;
				if (this._NumericUpDown_end2_est_820 != null)
				{
					this._NumericUpDown_end2_est_820.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x0033B68C File Offset: 0x00339A8C
		// (set) Token: 0x0600152B RID: 5419 RVA: 0x0033B6A0 File Offset: 0x00339AA0
		internal virtual GroupBox GroupBox10
		{
			get
			{
				return this._GroupBox10;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox10 = value;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x0033B6AC File Offset: 0x00339AAC
		// (set) Token: 0x0600152D RID: 5421 RVA: 0x0033B6C0 File Offset: 0x00339AC0
		internal virtual GroupBox GroupBox9
		{
			get
			{
				return this._GroupBox9;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox9 = value;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x0033B6CC File Offset: 0x00339ACC
		// (set) Token: 0x0600152F RID: 5423 RVA: 0x0033B6E0 File Offset: 0x00339AE0
		internal virtual DataGridView DataGridView2
		{
			get
			{
				return this._DataGridView2;
			}
			[MethodImpl(32)]
			set
			{
				this._DataGridView2 = value;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x0033B6EC File Offset: 0x00339AEC
		// (set) Token: 0x06001531 RID: 5425 RVA: 0x0033B700 File Offset: 0x00339B00
		internal virtual DataGridView DataGridView_periferico2_RT820
		{
			get
			{
				return this._DataGridView_periferico2_RT820;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_periferico2_RT820_CellContentClick);
				DataGridViewCellEventHandler dataGridViewCellEventHandler2 = new DataGridViewCellEventHandler(this.DataGridView_periferico2_RT820_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_periferico2_RT820_CellValidating);
				EventHandler eventHandler = new EventHandler(this.DataGridView_periferico2_RT820_CurrentCellDirtyStateChanged);
				if (this._DataGridView_periferico2_RT820 != null)
				{
					this._DataGridView_periferico2_RT820.CellContentClick -= dataGridViewCellEventHandler;
					this._DataGridView_periferico2_RT820.CellValueChanged -= dataGridViewCellEventHandler2;
					this._DataGridView_periferico2_RT820.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_periferico2_RT820.CurrentCellDirtyStateChanged -= eventHandler;
				}
				this._DataGridView_periferico2_RT820 = value;
				if (this._DataGridView_periferico2_RT820 != null)
				{
					this._DataGridView_periferico2_RT820.CellContentClick += dataGridViewCellEventHandler;
					this._DataGridView_periferico2_RT820.CellValueChanged += dataGridViewCellEventHandler2;
					this._DataGridView_periferico2_RT820.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_periferico2_RT820.CurrentCellDirtyStateChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x0033B7BC File Offset: 0x00339BBC
		// (set) Token: 0x06001533 RID: 5427 RVA: 0x0033B7D0 File Offset: 0x00339BD0
		internal virtual GroupBox GroupBox11
		{
			get
			{
				return this._GroupBox11;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox11 = value;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x0033B7DC File Offset: 0x00339BDC
		// (set) Token: 0x06001535 RID: 5429 RVA: 0x0033B7F0 File Offset: 0x00339BF0
		internal virtual DataGridView DataGridView_perifericomodbusgenerico_RT820
		{
			get
			{
				return this._DataGridView_perifericomodbusgenerico_RT820;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_perifericomodbusgenerico_RT820_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_perifericomodbusgenerico_RT820_CellValidating);
				EventHandler eventHandler = new EventHandler(this.DataGridView_perifericomodbusgenerico_RT820_CurrentCellDirtyStateChanged);
				if (this._DataGridView_perifericomodbusgenerico_RT820 != null)
				{
					this._DataGridView_perifericomodbusgenerico_RT820.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_perifericomodbusgenerico_RT820.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_perifericomodbusgenerico_RT820.CurrentCellDirtyStateChanged -= eventHandler;
				}
				this._DataGridView_perifericomodbusgenerico_RT820 = value;
				if (this._DataGridView_perifericomodbusgenerico_RT820 != null)
				{
					this._DataGridView_perifericomodbusgenerico_RT820.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_perifericomodbusgenerico_RT820.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_perifericomodbusgenerico_RT820.CurrentCellDirtyStateChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x0033B888 File Offset: 0x00339C88
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x0033B89C File Offset: 0x00339C9C
		internal virtual GroupBox GroupBox12
		{
			get
			{
				return this._GroupBox12;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox12 = value;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x0033B8A8 File Offset: 0x00339CA8
		// (set) Token: 0x06001539 RID: 5433 RVA: 0x0033B8BC File Offset: 0x00339CBC
		internal virtual DataGridView DataGridView_calhas_RT820
		{
			get
			{
				return this._DataGridView_calhas_RT820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_calhas_RT820_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_calhas_RT820_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_calhas_RT820_CellValidating);
				if (this._DataGridView_calhas_RT820 != null)
				{
					this._DataGridView_calhas_RT820.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_calhas_RT820.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_calhas_RT820.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_calhas_RT820 = value;
				if (this._DataGridView_calhas_RT820 != null)
				{
					this._DataGridView_calhas_RT820.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_calhas_RT820.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_calhas_RT820.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x0033B954 File Offset: 0x00339D54
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x0033B968 File Offset: 0x00339D68
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

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x0033B974 File Offset: 0x00339D74
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x0033B988 File Offset: 0x00339D88
		internal virtual TabControl TabControl_Calhas
		{
			get
			{
				return this._TabControl_Calhas;
			}
			[MethodImpl(32)]
			set
			{
				this._TabControl_Calhas = value;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x0033B994 File Offset: 0x00339D94
		// (set) Token: 0x0600153F RID: 5439 RVA: 0x0033B9A8 File Offset: 0x00339DA8
		internal virtual TabPage TabPage2
		{
			get
			{
				return this._TabPage2;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage2 = value;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x0033B9B4 File Offset: 0x00339DB4
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x0033B9C8 File Offset: 0x00339DC8
		internal virtual TabPage TabPage3
		{
			get
			{
				return this._TabPage3;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage3 = value;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x0033B9D4 File Offset: 0x00339DD4
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x0033B9E8 File Offset: 0x00339DE8
		internal virtual TabPage TabPage4
		{
			get
			{
				return this._TabPage4;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage4 = value;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x0033B9F4 File Offset: 0x00339DF4
		// (set) Token: 0x06001545 RID: 5445 RVA: 0x0033BA08 File Offset: 0x00339E08
		internal virtual Label Label42
		{
			get
			{
				return this._Label42;
			}
			[MethodImpl(32)]
			set
			{
				this._Label42 = value;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x0033BA14 File Offset: 0x00339E14
		// (set) Token: 0x06001547 RID: 5447 RVA: 0x0033BA28 File Offset: 0x00339E28
		internal virtual Label Label44
		{
			get
			{
				return this._Label44;
			}
			[MethodImpl(32)]
			set
			{
				this._Label44 = value;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x0033BA34 File Offset: 0x00339E34
		// (set) Token: 0x06001549 RID: 5449 RVA: 0x0033BA48 File Offset: 0x00339E48
		internal virtual Label Label43
		{
			get
			{
				return this._Label43;
			}
			[MethodImpl(32)]
			set
			{
				this._Label43 = value;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x0033BA54 File Offset: 0x00339E54
		// (set) Token: 0x0600154B RID: 5451 RVA: 0x0033BA68 File Offset: 0x00339E68
		internal virtual Label Label47
		{
			get
			{
				return this._Label47;
			}
			[MethodImpl(32)]
			set
			{
				this._Label47 = value;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x0033BA74 File Offset: 0x00339E74
		// (set) Token: 0x0600154D RID: 5453 RVA: 0x0033BA88 File Offset: 0x00339E88
		internal virtual Label Label46
		{
			get
			{
				return this._Label46;
			}
			[MethodImpl(32)]
			set
			{
				this._Label46 = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x0033BA94 File Offset: 0x00339E94
		// (set) Token: 0x0600154F RID: 5455 RVA: 0x0033BAA8 File Offset: 0x00339EA8
		internal virtual PictureBox PictureBox2
		{
			get
			{
				return this._PictureBox2;
			}
			[MethodImpl(32)]
			set
			{
				this._PictureBox2 = value;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x0033BAB4 File Offset: 0x00339EB4
		// (set) Token: 0x06001551 RID: 5457 RVA: 0x0033BAC8 File Offset: 0x00339EC8
		internal virtual PictureBox PictureBox1
		{
			get
			{
				return this._PictureBox1;
			}
			[MethodImpl(32)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x0033BAD4 File Offset: 0x00339ED4
		// (set) Token: 0x06001553 RID: 5459 RVA: 0x0033BAE8 File Offset: 0x00339EE8
		internal virtual Label Label48
		{
			get
			{
				return this._Label48;
			}
			[MethodImpl(32)]
			set
			{
				this._Label48 = value;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x0033BAF4 File Offset: 0x00339EF4
		// (set) Token: 0x06001555 RID: 5461 RVA: 0x0033BB08 File Offset: 0x00339F08
		internal virtual Label Label54
		{
			get
			{
				return this._Label54;
			}
			[MethodImpl(32)]
			set
			{
				this._Label54 = value;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x0033BB14 File Offset: 0x00339F14
		// (set) Token: 0x06001557 RID: 5463 RVA: 0x0033BB28 File Offset: 0x00339F28
		internal virtual Label Label52
		{
			get
			{
				return this._Label52;
			}
			[MethodImpl(32)]
			set
			{
				this._Label52 = value;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x0033BB34 File Offset: 0x00339F34
		// (set) Token: 0x06001559 RID: 5465 RVA: 0x0033BB48 File Offset: 0x00339F48
		internal virtual Label Label51
		{
			get
			{
				return this._Label51;
			}
			[MethodImpl(32)]
			set
			{
				this._Label51 = value;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x0033BB54 File Offset: 0x00339F54
		// (set) Token: 0x0600155B RID: 5467 RVA: 0x0033BB68 File Offset: 0x00339F68
		internal virtual Label Label50
		{
			get
			{
				return this._Label50;
			}
			[MethodImpl(32)]
			set
			{
				this._Label50 = value;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x0033BB74 File Offset: 0x00339F74
		// (set) Token: 0x0600155D RID: 5469 RVA: 0x0033BB88 File Offset: 0x00339F88
		internal virtual Label Label49
		{
			get
			{
				return this._Label49;
			}
			[MethodImpl(32)]
			set
			{
				this._Label49 = value;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x0033BB94 File Offset: 0x00339F94
		// (set) Token: 0x0600155F RID: 5471 RVA: 0x0033BBA8 File Offset: 0x00339FA8
		internal virtual Label Label56
		{
			get
			{
				return this._Label56;
			}
			[MethodImpl(32)]
			set
			{
				this._Label56 = value;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x0033BBB4 File Offset: 0x00339FB4
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x0033BBC8 File Offset: 0x00339FC8
		internal virtual Label Label55
		{
			get
			{
				return this._Label55;
			}
			[MethodImpl(32)]
			set
			{
				this._Label55 = value;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x0033BBD4 File Offset: 0x00339FD4
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x0033BBE8 File Offset: 0x00339FE8
		internal virtual Label Label58
		{
			get
			{
				return this._Label58;
			}
			[MethodImpl(32)]
			set
			{
				this._Label58 = value;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x0033BBF4 File Offset: 0x00339FF4
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x0033BC08 File Offset: 0x0033A008
		internal virtual PictureBox PictureBox3
		{
			get
			{
				return this._PictureBox3;
			}
			[MethodImpl(32)]
			set
			{
				this._PictureBox3 = value;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x0033BC14 File Offset: 0x0033A014
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x0033BC28 File Offset: 0x0033A028
		internal virtual Label Label66
		{
			get
			{
				return this._Label66;
			}
			[MethodImpl(32)]
			set
			{
				this._Label66 = value;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x0033BC34 File Offset: 0x0033A034
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x0033BC48 File Offset: 0x0033A048
		internal virtual Label Label67
		{
			get
			{
				return this._Label67;
			}
			[MethodImpl(32)]
			set
			{
				this._Label67 = value;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x0033BC54 File Offset: 0x0033A054
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x0033BC68 File Offset: 0x0033A068
		internal virtual Label Label62
		{
			get
			{
				return this._Label62;
			}
			[MethodImpl(32)]
			set
			{
				this._Label62 = value;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x0033BC74 File Offset: 0x0033A074
		// (set) Token: 0x0600156D RID: 5485 RVA: 0x0033BC88 File Offset: 0x0033A088
		internal virtual Label Label63
		{
			get
			{
				return this._Label63;
			}
			[MethodImpl(32)]
			set
			{
				this._Label63 = value;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x0033BC94 File Offset: 0x0033A094
		// (set) Token: 0x0600156F RID: 5487 RVA: 0x0033BCA8 File Offset: 0x0033A0A8
		internal virtual Label Label61
		{
			get
			{
				return this._Label61;
			}
			[MethodImpl(32)]
			set
			{
				this._Label61 = value;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x0033BCB4 File Offset: 0x0033A0B4
		// (set) Token: 0x06001571 RID: 5489 RVA: 0x0033BCC8 File Offset: 0x0033A0C8
		internal virtual Label Label60
		{
			get
			{
				return this._Label60;
			}
			[MethodImpl(32)]
			set
			{
				this._Label60 = value;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x0033BCD4 File Offset: 0x0033A0D4
		// (set) Token: 0x06001573 RID: 5491 RVA: 0x0033BCE8 File Offset: 0x0033A0E8
		internal virtual Label Label59
		{
			get
			{
				return this._Label59;
			}
			[MethodImpl(32)]
			set
			{
				this._Label59 = value;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x0033BCF4 File Offset: 0x0033A0F4
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x0033BD08 File Offset: 0x0033A108
		internal virtual Label Label68
		{
			get
			{
				return this._Label68;
			}
			[MethodImpl(32)]
			set
			{
				this._Label68 = value;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x0033BD14 File Offset: 0x0033A114
		// (set) Token: 0x06001577 RID: 5495 RVA: 0x0033BD28 File Offset: 0x0033A128
		internal virtual Label Label69
		{
			get
			{
				return this._Label69;
			}
			[MethodImpl(32)]
			set
			{
				this._Label69 = value;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x0033BD34 File Offset: 0x0033A134
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x0033BD48 File Offset: 0x0033A148
		internal virtual Label Label72
		{
			get
			{
				return this._Label72;
			}
			[MethodImpl(32)]
			set
			{
				this._Label72 = value;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x0033BD54 File Offset: 0x0033A154
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x0033BD68 File Offset: 0x0033A168
		internal virtual Label Label71
		{
			get
			{
				return this._Label71;
			}
			[MethodImpl(32)]
			set
			{
				this._Label71 = value;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x0033BD74 File Offset: 0x0033A174
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x0033BD88 File Offset: 0x0033A188
		internal virtual Label Label70
		{
			get
			{
				return this._Label70;
			}
			[MethodImpl(32)]
			set
			{
				this._Label70 = value;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x0033BD94 File Offset: 0x0033A194
		// (set) Token: 0x0600157F RID: 5503 RVA: 0x0033BDA8 File Offset: 0x0033A1A8
		internal virtual Label Label74
		{
			get
			{
				return this._Label74;
			}
			[MethodImpl(32)]
			set
			{
				this._Label74 = value;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x0033BDB4 File Offset: 0x0033A1B4
		// (set) Token: 0x06001581 RID: 5505 RVA: 0x0033BDC8 File Offset: 0x0033A1C8
		internal virtual Label Label45
		{
			get
			{
				return this._Label45;
			}
			[MethodImpl(32)]
			set
			{
				this._Label45 = value;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x0033BDD4 File Offset: 0x0033A1D4
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x0033BDE8 File Offset: 0x0033A1E8
		internal virtual Label Label64
		{
			get
			{
				return this._Label64;
			}
			[MethodImpl(32)]
			set
			{
				this._Label64 = value;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x0033BDF4 File Offset: 0x0033A1F4
		// (set) Token: 0x06001585 RID: 5509 RVA: 0x0033BE08 File Offset: 0x0033A208
		internal virtual Label Label57
		{
			get
			{
				return this._Label57;
			}
			[MethodImpl(32)]
			set
			{
				this._Label57 = value;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x0033BE14 File Offset: 0x0033A214
		// (set) Token: 0x06001587 RID: 5511 RVA: 0x0033BE28 File Offset: 0x0033A228
		internal virtual Label Label76
		{
			get
			{
				return this._Label76;
			}
			[MethodImpl(32)]
			set
			{
				this._Label76 = value;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x0033BE34 File Offset: 0x0033A234
		// (set) Token: 0x06001589 RID: 5513 RVA: 0x0033BE48 File Offset: 0x0033A248
		internal virtual Label Label75
		{
			get
			{
				return this._Label75;
			}
			[MethodImpl(32)]
			set
			{
				this._Label75 = value;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x0033BE54 File Offset: 0x0033A254
		// (set) Token: 0x0600158B RID: 5515 RVA: 0x0033BE68 File Offset: 0x0033A268
		internal virtual Label Label65
		{
			get
			{
				return this._Label65;
			}
			[MethodImpl(32)]
			set
			{
				this._Label65 = value;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x0033BE74 File Offset: 0x0033A274
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x0033BE88 File Offset: 0x0033A288
		internal virtual Label Label77
		{
			get
			{
				return this._Label77;
			}
			[MethodImpl(32)]
			set
			{
				this._Label77 = value;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x0033BE94 File Offset: 0x0033A294
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x0033BEA8 File Offset: 0x0033A2A8
		internal virtual Label Label78
		{
			get
			{
				return this._Label78;
			}
			[MethodImpl(32)]
			set
			{
				this._Label78 = value;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x0033BEB4 File Offset: 0x0033A2B4
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x0033BEC8 File Offset: 0x0033A2C8
		internal virtual Label Label53
		{
			get
			{
				return this._Label53;
			}
			[MethodImpl(32)]
			set
			{
				this._Label53 = value;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x0033BED4 File Offset: 0x0033A2D4
		// (set) Token: 0x06001593 RID: 5523 RVA: 0x0033BEE8 File Offset: 0x0033A2E8
		internal virtual Label Label79
		{
			get
			{
				return this._Label79;
			}
			[MethodImpl(32)]
			set
			{
				this._Label79 = value;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x0033BEF4 File Offset: 0x0033A2F4
		// (set) Token: 0x06001595 RID: 5525 RVA: 0x0033BF08 File Offset: 0x0033A308
		internal virtual Label Label83
		{
			get
			{
				return this._Label83;
			}
			[MethodImpl(32)]
			set
			{
				this._Label83 = value;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x0033BF14 File Offset: 0x0033A314
		// (set) Token: 0x06001597 RID: 5527 RVA: 0x0033BF28 File Offset: 0x0033A328
		internal virtual Label Label82
		{
			get
			{
				return this._Label82;
			}
			[MethodImpl(32)]
			set
			{
				this._Label82 = value;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x0033BF34 File Offset: 0x0033A334
		// (set) Token: 0x06001599 RID: 5529 RVA: 0x0033BF48 File Offset: 0x0033A348
		internal virtual Label Label81
		{
			get
			{
				return this._Label81;
			}
			[MethodImpl(32)]
			set
			{
				this._Label81 = value;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x0033BF54 File Offset: 0x0033A354
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x0033BF68 File Offset: 0x0033A368
		internal virtual Label Label80
		{
			get
			{
				return this._Label80;
			}
			[MethodImpl(32)]
			set
			{
				this._Label80 = value;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x0033BF74 File Offset: 0x0033A374
		// (set) Token: 0x0600159D RID: 5533 RVA: 0x0033BF88 File Offset: 0x0033A388
		internal virtual TabPage TabPage_SA
		{
			get
			{
				return this._TabPage_SA;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_SA = value;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x0033BF94 File Offset: 0x0033A394
		// (set) Token: 0x0600159F RID: 5535 RVA: 0x0033BFA8 File Offset: 0x0033A3A8
		internal virtual GroupBox GroupBox13
		{
			get
			{
				return this._GroupBox13;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox13 = value;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x0033BFB4 File Offset: 0x0033A3B4
		// (set) Token: 0x060015A1 RID: 5537 RVA: 0x0033BFC8 File Offset: 0x0033A3C8
		internal virtual GroupBox GroupBox14
		{
			get
			{
				return this._GroupBox14;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox14 = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x0033BFD4 File Offset: 0x0033A3D4
		// (set) Token: 0x060015A3 RID: 5539 RVA: 0x0033BFE8 File Offset: 0x0033A3E8
		internal virtual NumericUpDown nud_ganho2
		{
			get
			{
				return this._nud_ganho2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_ganho2_ValueChanged);
				if (this._nud_ganho2 != null)
				{
					this._nud_ganho2.ValueChanged -= eventHandler;
				}
				this._nud_ganho2 = value;
				if (this._nud_ganho2 != null)
				{
					this._nud_ganho2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x0033C034 File Offset: 0x0033A434
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x0033C048 File Offset: 0x0033A448
		internal virtual Label Label84
		{
			get
			{
				return this._Label84;
			}
			[MethodImpl(32)]
			set
			{
				this._Label84 = value;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x0033C054 File Offset: 0x0033A454
		// (set) Token: 0x060015A7 RID: 5543 RVA: 0x0033C068 File Offset: 0x0033A468
		internal virtual NumericUpDown nud_zero2
		{
			get
			{
				return this._nud_zero2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_zero2_ValueChanged);
				if (this._nud_zero2 != null)
				{
					this._nud_zero2.ValueChanged -= eventHandler;
				}
				this._nud_zero2 = value;
				if (this._nud_zero2 != null)
				{
					this._nud_zero2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x0033C0B4 File Offset: 0x0033A4B4
		// (set) Token: 0x060015A9 RID: 5545 RVA: 0x0033C0C8 File Offset: 0x0033A4C8
		internal virtual Label Label85
		{
			get
			{
				return this._Label85;
			}
			[MethodImpl(32)]
			set
			{
				this._Label85 = value;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x0033C0D4 File Offset: 0x0033A4D4
		// (set) Token: 0x060015AB RID: 5547 RVA: 0x0033C0E8 File Offset: 0x0033A4E8
		internal virtual GroupBox GroupBox15
		{
			get
			{
				return this._GroupBox15;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox15 = value;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x0033C0F4 File Offset: 0x0033A4F4
		// (set) Token: 0x060015AD RID: 5549 RVA: 0x0033C108 File Offset: 0x0033A508
		internal virtual GroupBox GroupBox16
		{
			get
			{
				return this._GroupBox16;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox16 = value;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x0033C114 File Offset: 0x0033A514
		// (set) Token: 0x060015AF RID: 5551 RVA: 0x0033C128 File Offset: 0x0033A528
		internal virtual NumericUpDown nud_ganho1
		{
			get
			{
				return this._nud_ganho1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_ganho1_ValueChanged);
				if (this._nud_ganho1 != null)
				{
					this._nud_ganho1.ValueChanged -= eventHandler;
				}
				this._nud_ganho1 = value;
				if (this._nud_ganho1 != null)
				{
					this._nud_ganho1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x0033C174 File Offset: 0x0033A574
		// (set) Token: 0x060015B1 RID: 5553 RVA: 0x0033C188 File Offset: 0x0033A588
		internal virtual Label Label86
		{
			get
			{
				return this._Label86;
			}
			[MethodImpl(32)]
			set
			{
				this._Label86 = value;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x0033C194 File Offset: 0x0033A594
		// (set) Token: 0x060015B3 RID: 5555 RVA: 0x0033C1A8 File Offset: 0x0033A5A8
		internal virtual NumericUpDown nud_zero1
		{
			get
			{
				return this._nud_zero1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_zero1_ValueChanged);
				if (this._nud_zero1 != null)
				{
					this._nud_zero1.ValueChanged -= eventHandler;
				}
				this._nud_zero1 = value;
				if (this._nud_zero1 != null)
				{
					this._nud_zero1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x0033C1F4 File Offset: 0x0033A5F4
		// (set) Token: 0x060015B5 RID: 5557 RVA: 0x0033C208 File Offset: 0x0033A608
		internal virtual Label Label87
		{
			get
			{
				return this._Label87;
			}
			[MethodImpl(32)]
			set
			{
				this._Label87 = value;
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x060015B6 RID: 5558 RVA: 0x0033C214 File Offset: 0x0033A614
		// (set) Token: 0x060015B7 RID: 5559 RVA: 0x0033C228 File Offset: 0x0033A628
		internal virtual GroupBox GroupBox17
		{
			get
			{
				return this._GroupBox17;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox17 = value;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x0033C234 File Offset: 0x0033A634
		// (set) Token: 0x060015B9 RID: 5561 RVA: 0x0033C248 File Offset: 0x0033A648
		internal virtual GroupBox GroupBox18
		{
			get
			{
				return this._GroupBox18;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox18 = value;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x0033C254 File Offset: 0x0033A654
		// (set) Token: 0x060015BB RID: 5563 RVA: 0x0033C268 File Offset: 0x0033A668
		internal virtual ComboBox cb_SA_2
		{
			get
			{
				return this._cb_SA_2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_SA_2_SelectedIndexChanged);
				if (this._cb_SA_2 != null)
				{
					this._cb_SA_2.SelectedIndexChanged -= eventHandler;
				}
				this._cb_SA_2 = value;
				if (this._cb_SA_2 != null)
				{
					this._cb_SA_2.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x0033C2B4 File Offset: 0x0033A6B4
		// (set) Token: 0x060015BD RID: 5565 RVA: 0x0033C2C8 File Offset: 0x0033A6C8
		internal virtual ComboBox cb_SA_1
		{
			get
			{
				return this._cb_SA_1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_SA_1_SelectedIndexChanged);
				if (this._cb_SA_1 != null)
				{
					this._cb_SA_1.SelectedIndexChanged -= eventHandler;
				}
				this._cb_SA_1 = value;
				if (this._cb_SA_1 != null)
				{
					this._cb_SA_1.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x0033C314 File Offset: 0x0033A714
		private void AtivaEfeitoOnChangeValue()
		{
			this.ToolStri_RT_820.Enabled = false;
			this.tb_lixo1.Focus();
			this.tb_lixo2.Focus();
			this.tb_lixo3.Focus();
			this.tb_lixo4.Focus();
			this.tb_lixo5.Focus();
			this.tb_lixo6.Focus();
			this.tb_lixo7.Focus();
			this.tb_lixo8.Focus();
			this.tb_lixo9.Focus();
			this.ToolStri_RT_820.Enabled = true;
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x0033C3A8 File Offset: 0x0033A7A8
		private void InicializaEStruturasVariaveis_RT820()
		{
			this.InicializaEstrutura_DataGridView_Processos();
			this.InicializaEstrutura_DataGridView_Vazoes();
			this.InicializaEstrutura_DataGridView_ED();
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x0033C3BC File Offset: 0x0033A7BC
		private void Desenha_DataGirView_SetPoint_Horario()
		{
			this.dgv_sph.DefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			this.dgv_sph.AlternatingRowsDefaultCellStyle = this.DataGridView_setpoints_820.AlternatingRowsDefaultCellStyle;
			int num = 0;
			checked
			{
				do
				{
					if (num % 10 == 0)
					{
						int num2 = 1;
						this.dgv_sph.Rows[num].HeaderCell.Value = string.Format("Ctrl {0}", unchecked((double)num / 10.0 + 1.0));
						this.dgv_sph.Rows[num].Cells[0].Value = num2.ToString();
						num2++;
					}
					else
					{
						int num2 = 0;
						this.dgv_sph.Rows[num].Cells[0].Value = num2.ToString();
						num2++;
					}
					num++;
				}
				while (num <= 79);
				this.dgv_sph.Height = 550;
			}
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x0033C4B4 File Offset: 0x0033A8B4
		private void RT_820_conf_Load(object sender, EventArgs e)
		{
			RT_geral.Lmte_Init_ok = false;
			this.bloqueio_IO = false;
			perifericos.Cria_ListaBaudRate();
			checked
			{
				RT_geral.RT_820_360_BD.BaudRateCOM2.valores = new int[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_820_360_BD.BaudRateCOM2.itens = new string[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_820_360_BD.BaudRateCOM1.valores = new int[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_820_360_BD.BaudRateCOM1.itens = new string[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_820_360_BD.ctrl_acionamento = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_360_BD.ctrl_desligamento = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_360_BD.ctrl_ret_acionamento = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_360_BD.ctrl_ret_desligamento = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_360_BD.ctrl_ED_selecao = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_360_BD.ctrl_ED_bloqueio = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_360_BD.ctrl_ED_liberacao = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_360_BD.ctrl_reverso = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_360_BD.ctrl_modo = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_360_BD.ctrl_agrupamento = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_360_BD.ctrl_partidas = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_360_BD.ctrl_tempo_max_partida = new RT_geral.Integer_ictel[9];
				RT_geral.RT_820_360_BD.ctrl_tempo_max_parada = new RT_geral.Integer_ictel[9];
				RT_geral.RT_820_360_BD.ctrl_tempo_min_parado = new RT_geral.Integer_ictel[9];
				RT_geral.RT_820_360_BD.ctrl_tempo_min_operando = new RT_geral.Integer_ictel[9];
				RT_geral.RT_820_360_BD.grupo_simultaneos = new RT_geral.Combo_ictel_ctrl[6];
				RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos = new RT_geral.Integer_ictel[5];
				RT_geral.RT_820_360_BD.grupo_rotativo_motores = new RT_geral.Combo_ictel_ctrl[5];
				RT_geral.RT_820_360_BD.EA_Range = new RT_geral.Integer_ictel[18];
				RT_geral.RT_820_360_BD.EA_Inicio = new RT_geral.Integer_ictel[18];
				RT_geral.RT_820_360_BD.EA_Fim = new RT_geral.Integer_ictel[18];
				perifericos.Cria_Lista_SA_Origem_RT820_400();
				RT_geral.RT_820_360_BD.saida_SA_origem = new RT_geral.Combo_ictel[3];
				RT_geral.RT_820_360_BD.saida_SA_contagem_4mA = new RT_geral.Integer_ictel[3];
				RT_geral.RT_820_360_BD.saida_SA_contagem_20mA = new RT_geral.Integer_ictel[3];
				RT_geral.RT_820_360_BD.saida_SA_origem[0].valores = new int[perifericos.Lista_SA_Origem_RT820_400.Count + 1];
				RT_geral.RT_820_360_BD.saida_SA_origem[0].itens = new string[perifericos.Lista_SA_Origem_RT820_400.Count + 1];
				RT_geral.RT_820_360_BD.saida_SA_origem[1].valores = new int[perifericos.Lista_SA_Origem_RT820_400.Count + 1];
				RT_geral.RT_820_360_BD.saida_SA_origem[1].itens = new string[perifericos.Lista_SA_Origem_RT820_400.Count + 1];
				RT_geral.RT_820_360_BD.config_ED = new RT_geral.Combo_ictel_ctrl[18];
				RT_geral.RT_820_360_BD.Setpoints_ctrl_variavel = new RT_geral.Combo_ictel_ctrl[10];
				RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo = new RT_geral.Integer_ictel[10];
				RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto = new RT_geral.Integer_ictel[10];
				RT_geral.RT_820_360_BD.Setpoints_ctrl_bloqueio = new RT_geral.Combo_ictel_ctrl[10];
				RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio = new RT_geral.Integer_ictel[10];
				RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao = new RT_geral.Integer_ictel[10];
				RT_geral.RT_820_360_BD.config_vazao = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_360_BD.config_perifericos1_end = new RT_geral.Integer_ictel[6];
				RT_geral.RT_820_360_BD.config_perifericos1_mod = new RT_geral.Combo_ictel_ctrl[6];
				RT_geral.RT_820_360_BD.config_perifericos2_end = new RT_geral.Integer_ictel[6];
				RT_geral.RT_820_360_BD.config_perifericos2_mod = new RT_geral.Combo_ictel_ctrl[6];
				RT_geral.RT_820_360_BD.config_periferico_modbus_generico_endcom = new RT_geral.Integer_ictel[6];
				RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao = new RT_geral.Combo_ictel_ctrl[6];
				RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem1 = new RT_geral.Integer_ictel[6];
				RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var1 = new RT_geral.Integer_ictel[6];
				RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem2 = new RT_geral.Integer_ictel[6];
				RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var2 = new RT_geral.Integer_ictel[6];
				RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem3 = new RT_geral.Integer_ictel[6];
				RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var3 = new RT_geral.Integer_ictel[6];
				RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem4 = new RT_geral.Integer_ictel[6];
				RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var4 = new RT_geral.Integer_ictel[6];
				RT_geral.RT_820_360_BD.calha_EA = new RT_geral.Combo_ictel_ctrl[3];
				RT_geral.RT_820_360_BD.calha_modelo = new RT_geral.Combo_ictel_ctrl[3];
				RT_geral.RT_820_360_BD.calha_fundo = new RT_geral.Integer_ictel[3];
				RT_geral.RT_820_360_BD.calha_p1 = new RT_geral.Integer_ictel[3];
				RT_geral.RT_820_360_BD.calha_p2 = new RT_geral.Integer_ictel[3];
				RT_geral.RT_820_360_BD.calha_p3 = new RT_geral.Integer_ictel[3];
				RT_geral.RT_820_360_BD.config_referencia_perif_periferico = new RT_geral.Combo_ictel_ctrl[11];
				RT_geral.RT_820_360_BD.config_referencia_perif_memoria = new RT_geral.Integer_ictel[11];
				RT_geral.RT_820_360_BD.config_referencia_perif_variavel1 = new RT_geral.Combo_ictel_ctrl[11];
				RT_geral.RT_820_360_BD.config_referencia_perif_variavel2 = new RT_geral.Combo_ictel_ctrl[11];
				RT_geral.RT_820_360_BD.config_referencia_perif_escala = new RT_geral.Integer_ictel[11];
				RT_geral.RT_820_360_BD.config_referencia_perif_formato = new RT_geral.Combo_ictel_ctrl[11];
				RT_geral.RT_820_360_BD.config_referencia_perif_base10 = new RT_geral.Combo_ictel_ctrl[11];
				RT_geral.RT_820_360_BD.config_atuador1_perif = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador1_mem = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador1_var1 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador1_escala1 = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador1_var2 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador1_escala2 = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador1_histerese = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador1_formato = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador1_base10 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador1_v1baixo = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador1_v1alto = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador1_v2baixo = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador1_v2alto = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_perif = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador2_mem = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador2_var1 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador2_escala1 = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador2_var2 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador2_escala2 = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador2_histerese = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador2_formato = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador2_base10 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador2_v1baixo = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador2_v1alto = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador2_v2baixo = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador2_v2alto = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_perif = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador3_mem = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador3_var1 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador3_escala1 = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador3_var2 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador3_escala2 = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador3_histerese = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador3_formato = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador3_base10 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador3_v1baixo = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador3_v1alto = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador3_v2baixo = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador3_v2alto = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_perif = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador4_mem = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador4_var1 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador4_escala1 = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador4_var2 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador4_escala2 = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador4_histerese = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador4_formato = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador4_base10 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_360_BD.config_atuador4_v1baixo = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador4_v1alto = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador4_v2baixo = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador4_v2alto = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_360_BD.modo_repetidora.valores = new int[3];
				RT_geral.RT_820_360_BD.modo_repetidora.itens = new string[3];
				RT_geral.RT_820_360_BD.Repetidoras = new RT_geral.Integer_ictel[52];
				RT_geral.RT_820_360_BD.Timer_Horario = new RT_geral.Integer_ictel[8][];
				int num = 0;
				do
				{
					RT_geral.Integer_ictel[] array = new RT_geral.Integer_ictel[13];
					RT_geral.RT_820_360_BD.Timer_Horario[num] = array;
					num++;
				}
				while (num <= 7);
				RT_geral.RT_820_360_BD.setpoint_horario = new RT_geral.SETPOINT_HORARIO_RT_820_300[81];
				this.dgv_sph.RowCount = 80;
				this.Desenha_DataGirView_SetPoint_Horario();
				RT_geral.RT_820_360_BD.HabExpIO.Valor = 21856;
				this.Inicializa_DadosEStruturaRT820_Padrao();
				RT_geral.Lmte_Init_ok = true;
				this.InicializaEstrutura_DataGridView_Processos();
				this.GeraDataGridView_Processos();
				this.InicializaEstrutura_DataGridView_agrupamentos();
				this.GeraDataGridView_Grupos();
				this.InicializaEstrutura_DataGridView_EA();
				this.GeraDataGridView_EA();
				perifericos.Cria_ListaPeriferico_RT820_360();
				this.InicializaEstrutura_DataGridView_Periferico1();
				this.GeraDataGridView_Perifericos1();
				this.InicializaEstrutura_DataGridView_Periferico2();
				this.GeraDataGridView_Perifericos2();
				this.InitializaEstrutura_DataGridView_PerifericoModbusGenerico();
				this.GeraDataGridView_PerifecoModbusGenerico();
				this.InicializaEstrutura_DataGridView_Referencia_Periferico();
				this.GeraDataGridView_Referencia_Perifericos();
				this.InicializaEstrutura_DataGridView_Atuador1();
				this.GeraDGV_Colunas(this.dgv_atuador1, RT_geral.RT_820_DataGrigViewAtuador1Colunas, 13, 1);
				this.InicializaEstrutura_DataGridView_Atuador1SetPoint1();
				this.GeraDGV_Colunas(this.dgv_atuador_setpoint1, RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas, 14, 3);
				this.InicializaEstrutura_DataGridView_Atuador1SetPoint2();
				this.GeraDGV_Colunas(this.dgv_atuador_setpoint11, RT_geral.RT_820_DataGrigViewAtuador1SetPoint2Colunas, 12, 3);
				this.InicializaEstrutura_DataGridView_Atuador2();
				this.GeraDGV_Colunas(this.dgv_atuador2, RT_geral.RT_820_DataGrigViewAtuador2Colunas, 13, 1);
				this.InicializaEstrutura_DataGridView_Atuador2SetPoint1();
				this.GeraDGV_Colunas(this.dgv_atuador_setpoint2, RT_geral.RT_820_DataGrigViewAtuador2SetPoint1Colunas, 14, 3);
				this.InicializaEstrutura_DataGridView_Atuador2SetPoint2();
				this.GeraDGV_Colunas(this.dgv_atuador_setpoint21, RT_geral.RT_820_DataGrigViewAtuador2SetPoint2Colunas, 12, 3);
				this.InicializaEstrutura_DataGridView_Atuador3();
				this.GeraDGV_Colunas(this.dgv_atuador3, RT_geral.RT_820_DataGrigViewAtuador3Colunas, 13, 1);
				this.InicializaEstrutura_DataGridView_Atuador3SetPoint1();
				this.GeraDGV_Colunas(this.dgv_atuador_setpoint3, RT_geral.RT_820_DataGrigViewAtuador3SetPoint1Colunas, 14, 3);
				this.InicializaEstrutura_DataGridView_Atuador3SetPoint2();
				this.GeraDGV_Colunas(this.dgv_atuador_setpoint31, RT_geral.RT_820_DataGrigViewAtuador3SetPoint2Colunas, 12, 3);
				this.InicializaEstrutura_DataGridView_Atuador4();
				this.GeraDGV_Colunas(this.dgv_atuador4, RT_geral.RT_820_DataGrigViewAtuador4Colunas, 13, 1);
				this.InicializaEstrutura_DataGridView_Atuador4SetPoint1();
				this.GeraDGV_Colunas(this.dgv_atuador_setpoint4, RT_geral.RT_820_DataGrigViewAtuador4SetPoint1Colunas, 14, 3);
				this.InicializaEstrutura_DataGridView_Atuador4SetPoint2();
				this.GeraDGV_Colunas(this.dgv_atuador_setpoint41, RT_geral.RT_820_DataGrigViewAtuador4SetPoint2Colunas, 12, 3);
				this.InicializaEstrutura_DataGridView_repetidora();
				this.GeraDataGridView_Repedidora();
				this.InicializaEstrutura_DataGridView_Setpoints();
				this.GeraDataGridView_Setpoints();
				this.InicializaEstrutura_DataGridView_Timer();
				this.GeraDataGridView_Timer();
				this.InicializaEstrutura_DataGridView_Vazoes();
				this.GeraDataGridView_Vazoes();
				this.InicializaEstutura_DataGridView_Calhas();
				this.GeraDGV_Colunas_ID_LINHAS(this.DataGridView_calhas_RT820, RT_geral.RT_820_DatagridViewCalhasColunas, 6, 2, "Calha");
				this.InicializaEstrutura_DataGridView_ED();
				this.GeraDataGridView_ED();
				ComboBox comboBox = this.ComboBox_baudrate_COM2_820;
				this.CarregaComboBoxBaudRate(ref comboBox);
				this.ComboBox_baudrate_COM2_820 = comboBox;
				comboBox = this.ComboBox_baudrate_COM1_820;
				this.CarregaComboBoxBaudRate(ref comboBox);
				this.ComboBox_baudrate_COM1_820 = comboBox;
				comboBox = this.cb_ModoRepetidora;
				this.CarregaComboBoxModoRepetidora(ref comboBox);
				this.cb_ModoRepetidora = comboBox;
				comboBox = this.cb_SA_1;
				this.CarregaComboBoxSaidaAnalogica(ref comboBox);
				this.cb_SA_1 = comboBox;
				comboBox = this.cb_SA_2;
				this.CarregaComboBoxSaidaAnalogica(ref comboBox);
				this.cb_SA_2 = comboBox;
				this.Inicializa_DadosEStruturaRT820_Default();
				Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
				this.TabPage_geral.BackColor = Color.FromKnownColor((KnownColor)8);
				this.TabPage_geral.ForeColor = Color.FromKnownColor((KnownColor)10);
				this.TabPage_controle.BackColor = Color.FromKnownColor((KnownColor)8);
				this.TabPage_controle.ForeColor = Color.FromKnownColor((KnownColor)10);
				this.TabPage_EA.BackColor = Color.FromKnownColor((KnownColor)8);
				this.TabPage_EA.ForeColor = Color.FromKnownColor((KnownColor)10);
				this.TabPage_ED.BackColor = Color.FromKnownColor((KnownColor)8);
				this.TabPage_ED.ForeColor = Color.FromKnownColor((KnownColor)10);
				this.TabPage_setpoints.BackColor = Color.FromKnownColor((KnownColor)8);
				this.TabPage_setpoints.ForeColor = Color.FromKnownColor((KnownColor)10);
				this.TabPage_vazao.BackColor = Color.FromKnownColor((KnownColor)8);
				this.TabPage_vazao.ForeColor = Color.FromKnownColor((KnownColor)10);
				this.TabPage_vazao_perifericos.BackColor = Color.FromKnownColor((KnownColor)8);
				this.TabPage_vazao_perifericos.ForeColor = Color.FromKnownColor((KnownColor)10);
				this.TabPage_Atuadores.BackColor = Color.FromKnownColor((KnownColor)8);
				this.TabPage_Atuadores.ForeColor = Color.FromKnownColor((KnownColor)10);
				this.TabPage_Atuadores2.BackColor = Color.FromKnownColor((KnownColor)8);
				this.TabPage_Atuadores2.ForeColor = Color.FromKnownColor((KnownColor)10);
				this.TabPage_repetidora.BackColor = Color.FromKnownColor((KnownColor)8);
				this.TabPage_repetidora.ForeColor = Color.FromKnownColor((KnownColor)10);
				this.TabPage_timer.BackColor = Color.FromKnownColor((KnownColor)8);
				this.TabPage_timer.ForeColor = Color.FromKnownColor((KnownColor)10);
				this.TabPage1.BackColor = Color.FromKnownColor((KnownColor)8);
				this.TabPage1.ForeColor = Color.FromKnownColor((KnownColor)10);
				this.TabPage_SA.BackColor = Color.FromKnownColor((KnownColor)8);
				this.TabPage_SA.ForeColor = Color.FromKnownColor((KnownColor)10);
				string text = ".\\\\Fontes\\\\Ictel Extendida Italic.ttf";
				if (MyProject.Computer.FileSystem.FileExists(text))
				{
					PrivateFontCollection privateFontCollection = new PrivateFontCollection();
					privateFontCollection.AddFontFile(text);
					Font font = new Font(privateFontCollection.Families[0], 8f, (System.Drawing.FontStyle)2);
					Font font2 = new Font(privateFontCollection.Families[0], 18f, (System.Drawing.FontStyle)2);
					this.Label26.Font = font;
					this.TextBox_equipamento_820.Font = font;
					this.TextBox_versao_820.Font = font;
					this.TextBox_build_820.Font = font;
					this.TextBox_release_820.Font = font;
					this.ToolStripLabel1.Font = font2;
				}
				else
				{
					MessageBox.Show("Removido fonte Ictel Extendida Italic da pasta da aplicação!");
				}
				this.NumericUpDown_end_mestre_820.Minimum = new decimal(RT_geral.RT_820_360_BD.End_mestre.Lmte_inf);
				this.NumericUpDown_end_mestre_820.Maximum = new decimal(RT_geral.RT_820_360_BD.End_mestre.Lmte_sup);
				this.NumericUpDown_end1_est_820.Minimum = new decimal(RT_geral.RT_820_360_BD.End_estacao1.Lmte_inf);
				this.NumericUpDown_end1_est_820.Maximum = new decimal(RT_geral.RT_820_360_BD.End_estacao1.Lmte_sup);
				this.NumericUpDown_end2_est_820.Minimum = new decimal(RT_geral.RT_820_360_BD.End_estacao2.Lmte_inf);
				this.NumericUpDown_end2_est_820.Maximum = new decimal(RT_geral.RT_820_360_BD.End_estacao2.Lmte_sup);
				this.NumericUpDown_temp_ptt_820.Minimum = new decimal(RT_geral.RT_820_360_BD.Tempo_ptt.Lmte_inf);
				this.NumericUpDown_temp_ptt_820.Maximum = new decimal(RT_geral.RT_820_360_BD.Tempo_ptt.Lmte_sup);
				this.nud_tempoforaar.Minimum = new decimal(RT_geral.RT_820_360_BD.TempoForaAr.Lmte_inf);
				this.nud_tempoforaar.Maximum = new decimal(RT_geral.RT_820_360_BD.TempoForaAr.Lmte_sup);
				this.nud_zero1.Minimum = new decimal(RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0].Lmte_inf);
				this.nud_zero2.Minimum = new decimal(RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[1].Lmte_inf);
				this.nud_zero1.Maximum = new decimal(RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0].Lmte_sup);
				this.nud_zero2.Maximum = new decimal(RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[1].Lmte_sup);
				this.nud_ganho1.Minimum = new decimal(RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[0].Lmte_inf);
				this.nud_ganho2.Minimum = new decimal(RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[1].Lmte_inf);
				this.nud_ganho1.Maximum = new decimal(RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[0].Lmte_sup);
				this.nud_ganho2.Maximum = new decimal(RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[1].Lmte_sup);
				this.Atualiza_TelaRT820();
				this.ToolStripLabel1.Text = RT_geral.MontaNomePlacaPeloFabricante(RT_geral.RT_820_360_BD.Equip.Valor, RT_geral.RT_820_360_BD.Versao.Valor);
			}
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x0033DBAC File Offset: 0x0033BFAC
		private void RT_820_conf_Activated(object sender, EventArgs e)
		{
			Geral.Equipamento_selecionado = 820;
			Geral.Equipamento_versao = 4;
			Geral.Equipamento_build = 0;
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x0033DBC4 File Offset: 0x0033BFC4
		private void RT_820_conf_FormClosed(object sender, FormClosedEventArgs e)
		{
			RT_geral.Telas_RT_820.Configuracao = false;
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x0033DBD4 File Offset: 0x0033BFD4
		private void GeraDataGridView_Processos()
		{
			this.DataGridView_processo_820.Columns.Clear();
			this.DataGridView_processo_820.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_820_DataGrigViewProcessosColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewProcessosColunas);
						this.DataGridView_processo_820.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewProcessosColunas);
						this.DataGridView_processo_820.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 14);
				this.DataGridView_processo_820.RowCount = 8;
				this.DataGridView_processo_820.RowHeadersWidth = 70;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_processo_820.Rows)
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
					IEnumerator enumerator = null;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x0033DD08 File Offset: 0x0033C108
		private void InicializaEstrutura_DataGridView_Processos()
		{
			int i = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[i].LinhasMenu = new string[35];
					RT_geral.RT_820_DataGrigViewProcessosColunas[i].LinhasValor = new int[35];
					i++;
				}
				while (i <= 15);
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].TagColuna = "Acionamento";
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].TagColuna = "Retorno";
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].TagColuna = "Desacionamento";
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].TagColuna = "Retorno";
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].TagColuna = "Remoto";
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].TagColuna = "Bloqueio Digital";
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].TagColuna = "Liberação Digital";
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].TagColuna = "Reverso";
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].TagColuna = "Modo";
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].TagColuna = "Grupo";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].TagColuna = "N° Partidas";
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].TagColuna = "Tempo Partida  (s)";
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].TagColuna = "Tempo Parada (s)";
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].TagColuna = "Tempo Mínimo Parado (s)";
				RT_geral.RT_820_DataGrigViewProcessosColunas[14].TagColuna = "Tempo Mínimo Operando (s)";
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].NomeColuna = "SDAciona";
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].NomeColuna = "EDRetAci";
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].NomeColuna = "SDDesaci";
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].NomeColuna = "EDRetDes";
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].NomeColuna = "EDRemoto";
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].NomeColuna = "EDBloqueio";
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].NomeColuna = "EDLiberar";
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].NomeColuna = "Reverso";
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].NomeColuna = "ModoCtrl";
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].NomeColuna = "GrupoCtrl";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].NomeColuna = "GrupoPartida";
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].NomeColuna = "TpMaxPart";
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].NomeColuna = "TpMaxParada";
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].NomeColuna = "TpMinParado";
				RT_geral.RT_820_DataGrigViewProcessosColunas[14].NomeColuna = "TpMinOperan";
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].LarguraColuna = 90;
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].LarguraColuna = 90;
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].LarguraColuna = 90;
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].LarguraColuna = 90;
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].LarguraColuna = 110;
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].LarguraColuna = 90;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LarguraColuna = 130;
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LarguraColuna = 90;
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].LarguraColuna = 55;
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].LarguraColuna = 55;
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].LarguraColuna = 55;
				RT_geral.RT_820_DataGrigViewProcessosColunas[14].LarguraColuna = 55;
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewProcessosColunas[14].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasMenu[0] = "Desativo";
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasMenu[0] = "Desativo";
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasValor[0] = 21856;
				int num = 0;
				int num2 = 0;
				if (RT_geral.RT_820_360_BD.HabExpIO.Valor == 21857)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].NumeroLinhaMenu = 18;
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].NumeroLinhaMenu = 18;
					num = 12;
					num2 = 0;
				}
				else
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].NumeroLinhaMenu = 14;
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].NumeroLinhaMenu = 14;
					num = 8;
					num2 = 4;
				}
				int num3 = 1;
				int num4 = num;
				for (i = num3; i <= num4; i++)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasMenu[i] = "SD - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasValor[i] = 21856 + i;
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasMenu[i] = "SD - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasValor[i] = 21856 + i;
				}
				int num5 = num + 1;
				num = num5 + 4;
				int num6 = num5;
				int num7 = num;
				for (i = num6; i <= num7; i++)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasMenu[i] = "Periférico " + Strings.Format(i + num2 - 12, "#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasValor[i] = 21860 + i + num2;
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasMenu[i] = "Periférico " + Strings.Format(i + num2 - 12, "#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasValor[i] = 21860 + i + num2;
				}
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasMenu[0] = "Não usado";
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasMenu[0] = "Não usado";
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].LinhasMenu[0] = "Sempre Remoto";
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].LinhasMenu[0] = "Sem Liberação";
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].LinhasValor[0] = 21856;
				if (RT_geral.RT_820_360_BD.HabExpIO.Valor == 21857)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[1].NumeroLinhaMenu = 22;
					RT_geral.RT_820_DataGrigViewProcessosColunas[3].NumeroLinhaMenu = 22;
					RT_geral.RT_820_DataGrigViewProcessosColunas[4].NumeroLinhaMenu = 17;
					RT_geral.RT_820_DataGrigViewProcessosColunas[6].NumeroLinhaMenu = 17;
					num = 16;
					num2 = 0;
				}
				else
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[1].NumeroLinhaMenu = 14;
					RT_geral.RT_820_DataGrigViewProcessosColunas[3].NumeroLinhaMenu = 14;
					RT_geral.RT_820_DataGrigViewProcessosColunas[4].NumeroLinhaMenu = 9;
					RT_geral.RT_820_DataGrigViewProcessosColunas[6].NumeroLinhaMenu = 9;
					num = 8;
					num2 = 8;
				}
				int num8 = 1;
				int num9 = num;
				for (i = num8; i <= num9; i++)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasMenu[i] = "ED - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasValor[i] = 21856 + i;
					RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasMenu[i] = "ED - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasValor[i] = 21856 + i;
					RT_geral.RT_820_DataGrigViewProcessosColunas[4].LinhasMenu[i] = "ED - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[4].LinhasValor[i] = 21856 + i;
					RT_geral.RT_820_DataGrigViewProcessosColunas[6].LinhasMenu[i] = "ED - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[6].LinhasValor[i] = 21856 + i;
				}
				int num10 = 0;
				if (RT_geral.RT_820_360_BD.HabExpIO.Valor == 21857)
				{
					num10 = 16;
				}
				else
				{
					num10 = 8;
				}
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].NumeroLinhaMenu = RT_geral.RT_820_DataGrigViewProcessosColunas[4].NumeroLinhaMenu + num10;
				int num11 = num + 1;
				int num12 = num + num10;
				for (i = num11; i <= num12; i++)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[4].LinhasMenu[i] = "ED - " + Strings.Format(i - num, "0#") + " bkp status";
					RT_geral.RT_820_DataGrigViewProcessosColunas[4].LinhasValor[i] = 21872 + i - num;
				}
				num5 = num + 1;
				num = num5 + 4;
				int num13 = num5;
				int num14 = num;
				for (i = num13; i <= num14; i++)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasMenu[i] = "Periférico " + Strings.Format(i - 16 + num2, "#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasValor[i] = 21856 + i + num2;
					RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasMenu[i] = "Periférico " + Strings.Format(i - 16 + num2, "#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasValor[i] = 21856 + i + num2;
				}
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasMenu[0] = "Sem Bloqueio";
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasValor[0] = 21856;
				if (RT_geral.RT_820_360_BD.HabExpIO.Valor == 21857)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[5].NumeroLinhaMenu = 33;
					num = 16;
				}
				else
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[5].NumeroLinhaMenu = 17;
					num = 8;
				}
				int num15 = 1;
				int num16 = num;
				for (i = num15; i <= num16; i++)
				{
					num2 = i * 2;
					RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasMenu[num2 - 1] = "ED - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasMenu[num2] = "ED - " + Strings.Format(i, "0#") + " reverso";
					RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasValor[num2 - 1] = 21856 + num2 - 1;
					RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasValor[num2] = 21856 + num2;
				}
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].NumeroLinhaMenu = 2;
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].LinhasMenu[0] = "Desabilitado";
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].LinhasMenu[1] = "Habilitado";
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].LinhasValor[1] = 21857;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].NumeroLinhaMenu = 4;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasMenu[0] = "Telecomando";
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasMenu[1] = "Automático";
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasMenu[2] = "Timer";
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasMenu[3] = "Telecomando com Falha";
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasValor[1] = 21857;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasValor[2] = 21858;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasValor[3] = 21859;
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].NumeroLinhaMenu = 5;
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasMenu[0] = "Nenhum Grupo";
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasValor[0] = 21856;
				i = 1;
				do
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasMenu[i] = "Grupo " + Strings.Format(i, "#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasValor[i] = 21856 + i;
					i++;
				}
				while (i <= 4);
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].NumeroLinhaMenu = 21;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[0] = "Desabilitado";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[1] = "1";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[2] = "2";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[3] = "3";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[4] = "4";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[5] = "5";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[6] = "6";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[7] = "7";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[8] = "8";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[9] = "9";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[10] = "10";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[11] = "11";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[12] = "12";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[13] = "13";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[14] = "14";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[15] = "15";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[16] = "16";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[17] = "17";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[18] = "18";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[19] = "19";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[20] = "20";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[1] = 21857;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[2] = 21858;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[3] = 21859;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[4] = 21860;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[5] = 21861;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[6] = 21862;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[7] = 21863;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[8] = 21864;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[9] = 21865;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[10] = 21866;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[11] = 21867;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[12] = 21868;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[13] = 21869;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[14] = 21870;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[15] = 21871;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[16] = 21872;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[17] = 21873;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[18] = 21874;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[19] = 21875;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasValor[20] = 21876;
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewProcessosColunas[14].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0033EF60 File Offset: 0x0033D360
		private void GeraDataGridView_Grupos()
		{
			this.DataGridView_grupos_820.Columns.Clear();
			this.DataGridView_grupos_820.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_820_DataGrigViewGruposColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewGruposColunas);
						this.DataGridView_grupos_820.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewGruposColunas);
						this.DataGridView_grupos_820.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 2);
				this.DataGridView_grupos_820.RowCount = 4;
				this.DataGridView_grupos_820.RowHeadersWidth = 90;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_grupos_820.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "Grupo " + Strings.Format(num2, "0#");
							num2++;
						}
					}
				}
				finally
				{
					IEnumerator enumerator = null;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x0033F094 File Offset: 0x0033D494
		private void InicializaEstrutura_DataGridView_agrupamentos()
		{
			RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasMenu = new string[10];
			RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasValor = new int[10];
			RT_geral.RT_820_DataGrigViewGruposColunas[2].LinhasMenu = new string[23];
			RT_geral.RT_820_DataGrigViewGruposColunas[2].LinhasValor = new int[23];
			RT_geral.RT_820_DataGrigViewGruposColunas[0].TagColuna = "Acionamentos Permitidos";
			RT_geral.RT_820_DataGrigViewGruposColunas[1].TagColuna = "Tempo Entre Acionamentos (s)";
			RT_geral.RT_820_DataGrigViewGruposColunas[2].TagColuna = "Sistema de Rotação";
			RT_geral.RT_820_DataGrigViewGruposColunas[0].NomeColuna = "ASimultaneos";
			RT_geral.RT_820_DataGrigViewGruposColunas[1].NomeColuna = "TpAcionamentos";
			RT_geral.RT_820_DataGrigViewGruposColunas[2].NomeColuna = "RotMot";
			RT_geral.RT_820_DataGrigViewGruposColunas[0].LarguraColuna = 100;
			RT_geral.RT_820_DataGrigViewGruposColunas[1].LarguraColuna = 120;
			RT_geral.RT_820_DataGrigViewGruposColunas[2].LarguraColuna = 120;
			RT_geral.RT_820_DataGrigViewGruposColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
			RT_geral.RT_820_DataGrigViewGruposColunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewGruposColunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewGruposColunas[0].NumeroLinhaMenu = 9;
			RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasMenu[0] = "Liberado";
			RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasValor[0] = 21856;
			int num = 1;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasMenu[num] = Strings.Format(num, "0#");
					RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasValor[num] = 21856 + num;
					num++;
				}
				while (num <= 8);
				RT_geral.RT_820_DataGrigViewGruposColunas[1].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewGruposColunas[2].NumeroLinhaMenu = 3;
				RT_geral.RT_820_DataGrigViewGruposColunas[2].LinhasMenu[0] = "Desabilitado";
				RT_geral.RT_820_DataGrigViewGruposColunas[2].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewGruposColunas[2].LinhasMenu[1] = "Por tempo";
				RT_geral.RT_820_DataGrigViewGruposColunas[2].LinhasValor[1] = 21857;
				RT_geral.RT_820_DataGrigViewGruposColunas[2].LinhasMenu[2] = "Por partidas";
				RT_geral.RT_820_DataGrigViewGruposColunas[2].LinhasValor[2] = 21858;
			}
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0033F318 File Offset: 0x0033D718
		private void GeraDataGridView_EA()
		{
			this.DataGridView_parametros_EA_820.Columns.Clear();
			this.DataGridView_parametros_EA_820.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_820_DataGrigViewEAColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewEAColunas);
						this.DataGridView_parametros_EA_820.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewEAColunas);
						this.DataGridView_parametros_EA_820.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 2);
				this.DataGridView_parametros_EA_820.RowCount = 16;
				this.DataGridView_parametros_EA_820.RowHeadersWidth = 70;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_parametros_EA_820.Rows)
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
					IEnumerator enumerator = null;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0033F44C File Offset: 0x0033D84C
		private void InicializaEstrutura_DataGridView_EA()
		{
			RT_geral.RT_820_DataGrigViewEAColunas[0].TagColuna = "Range";
			RT_geral.RT_820_DataGrigViewEAColunas[1].TagColuna = "Início";
			RT_geral.RT_820_DataGrigViewEAColunas[2].TagColuna = "Fim";
			RT_geral.RT_820_DataGrigViewEAColunas[0].NomeColuna = "range";
			RT_geral.RT_820_DataGrigViewEAColunas[1].NomeColuna = "ini";
			RT_geral.RT_820_DataGrigViewEAColunas[2].NomeColuna = "fim";
			RT_geral.RT_820_DataGrigViewEAColunas[0].LarguraColuna = 90;
			RT_geral.RT_820_DataGrigViewEAColunas[1].LarguraColuna = 90;
			RT_geral.RT_820_DataGrigViewEAColunas[2].LarguraColuna = 90;
			RT_geral.RT_820_DataGrigViewEAColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewEAColunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewEAColunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewEAColunas[0].NumeroLinhaMenu = 0;
			RT_geral.RT_820_DataGrigViewEAColunas[1].NumeroLinhaMenu = 0;
			RT_geral.RT_820_DataGrigViewEAColunas[2].NumeroLinhaMenu = 0;
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0033F578 File Offset: 0x0033D978
		private void GeraDataGridView_Perifericos1()
		{
			this.DataGridView_periferico1_RT820.Columns.Clear();
			this.DataGridView_periferico1_RT820.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			this.DataGridView_periferico1_RT820.DefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas);
						this.DataGridView_periferico1_RT820.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas);
						this.DataGridView_periferico1_RT820.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 1);
				this.DataGridView_periferico1_RT820.RowCount = 5;
				this.DataGridView_periferico1_RT820.RowHeadersWidth = 100;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_periferico1_RT820.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "Periférico " + Conversions.ToString(num2);
							num2++;
						}
					}
				}
				finally
				{
					IEnumerator enumerator = null;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0033F6B4 File Offset: 0x0033DAB4
		private void GeraDataGridView_Perifericos2()
		{
			this.DataGridView_periferico2_RT820.Columns.Clear();
			this.DataGridView_periferico2_RT820.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			this.DataGridView_periferico2_RT820.DefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas);
						this.DataGridView_periferico2_RT820.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas);
						this.DataGridView_periferico2_RT820.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 1);
				this.DataGridView_periferico2_RT820.RowCount = 5;
				this.DataGridView_periferico2_RT820.RowHeadersWidth = 100;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_periferico2_RT820.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "Periférico " + Conversions.ToString(num2);
							num2++;
						}
					}
				}
				finally
				{
					IEnumerator enumerator = null;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x0033F7F0 File Offset: 0x0033DBF0
		private void GeraDataGridView_PerifecoModbusGenerico()
		{
			DataGridView dataGridView_perifericomodbusgenerico_RT = this.DataGridView_perifericomodbusgenerico_RT820;
			RT_geral.DADOS_DATAGRIDVIEW_RT_820[] rt_820_360_DatagridViewPerifericoModbusGenericoColunas = RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas;
			bool flag = true;
			dataGridView_perifericomodbusgenerico_RT.Columns.Clear();
			dataGridView_perifericomodbusgenerico_RT.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			dataGridView_perifericomodbusgenerico_RT.DefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			dataGridView_perifericomodbusgenerico_RT.AllowUserToAddRows = false;
			dataGridView_perifericomodbusgenerico_RT.AllowUserToDeleteRows = false;
			dataGridView_perifericomodbusgenerico_RT.AllowUserToOrderColumns = false;
			dataGridView_perifericomodbusgenerico_RT.AllowUserToResizeColumns = false;
			dataGridView_perifericomodbusgenerico_RT.AllowUserToResizeRows = false;
			int num = 0;
			int i = 0;
			checked
			{
				do
				{
					if (rt_820_360_DatagridViewPerifericoModbusGenericoColunas[i].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(i), ref rt_820_360_DatagridViewPerifericoModbusGenericoColunas);
						dataGridView_perifericomodbusgenerico_RT.Columns.Insert(i, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(i), ref rt_820_360_DatagridViewPerifericoModbusGenericoColunas);
						dataGridView_perifericomodbusgenerico_RT.Columns.Insert(i, dataGridViewTextBoxColumn);
					}
					num += rt_820_360_DatagridViewPerifericoModbusGenericoColunas[i].LarguraColuna;
					i++;
				}
				while (i <= 9);
				dataGridView_perifericomodbusgenerico_RT.RowCount = 5;
				if (flag)
				{
					dataGridView_perifericomodbusgenerico_RT.RowHeadersWidth = 150;
					dataGridView_perifericomodbusgenerico_RT.RowHeadersVisible = true;
					num += 2;
				}
				else
				{
					dataGridView_perifericomodbusgenerico_RT.RowHeadersWidth = 4;
					dataGridView_perifericomodbusgenerico_RT.RowHeadersVisible = false;
				}
				dataGridView_perifericomodbusgenerico_RT.Width = num + dataGridView_perifericomodbusgenerico_RT.RowHeadersWidth;
				if (flag)
				{
					int num2 = 1;
					try
					{
						foreach (object obj in dataGridView_perifericomodbusgenerico_RT.Rows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							if (!dataGridViewRow.IsNewRow)
							{
								dataGridViewRow.HeaderCell.Value = "ModBUS Genérico " + num2.ToString();
								num2++;
							}
						}
					}
					finally
					{
						IEnumerator enumerator = null;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				int num3 = 0;
				int num4 = 0;
				int num5 = dataGridView_perifericomodbusgenerico_RT.RowCount - 1;
				for (i = num4; i <= num5; i++)
				{
					num3 += dataGridView_perifericomodbusgenerico_RT.Rows[i].Height;
				}
				dataGridView_perifericomodbusgenerico_RT.Height = dataGridView_perifericomodbusgenerico_RT.ColumnHeadersHeight + num3 + 2;
			}
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x0033F9C0 File Offset: 0x0033DDC0
		private void GeraDataGridView_Referencia_Perifericos()
		{
			DataGridView datagridview_referenciaperifico = this.datagridview_referenciaperifico;
			RT_geral.DADOS_DATAGRIDVIEW_RT_820[] rt_820_DataGrigViewReferenciaPerifericosColunas = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas;
			bool flag = true;
			datagridview_referenciaperifico.Columns.Clear();
			datagridview_referenciaperifico.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			datagridview_referenciaperifico.DefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			datagridview_referenciaperifico.AllowUserToAddRows = false;
			datagridview_referenciaperifico.AllowUserToDeleteRows = false;
			datagridview_referenciaperifico.AllowUserToOrderColumns = false;
			datagridview_referenciaperifico.AllowUserToResizeColumns = false;
			datagridview_referenciaperifico.AllowUserToResizeRows = false;
			int num = 0;
			int i = 0;
			checked
			{
				do
				{
					if (rt_820_DataGrigViewReferenciaPerifericosColunas[i].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(i), ref rt_820_DataGrigViewReferenciaPerifericosColunas);
						datagridview_referenciaperifico.Columns.Insert(i, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(i), ref rt_820_DataGrigViewReferenciaPerifericosColunas);
						datagridview_referenciaperifico.Columns.Insert(i, dataGridViewTextBoxColumn);
					}
					num += rt_820_DataGrigViewReferenciaPerifericosColunas[i].LarguraColuna;
					i++;
				}
				while (i <= 6);
				datagridview_referenciaperifico.RowCount = 10;
				if (flag)
				{
					datagridview_referenciaperifico.RowHeadersWidth = 50;
					datagridview_referenciaperifico.RowHeadersVisible = true;
					num += 2;
				}
				else
				{
					datagridview_referenciaperifico.RowHeadersWidth = 4;
					datagridview_referenciaperifico.RowHeadersVisible = false;
				}
				datagridview_referenciaperifico.Width = num + datagridview_referenciaperifico.RowHeadersWidth;
				if (flag)
				{
					int num2 = 1;
					try
					{
						foreach (object obj in datagridview_referenciaperifico.Rows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							if (!dataGridViewRow.IsNewRow)
							{
								dataGridViewRow.HeaderCell.Value = num2.ToString();
								num2++;
							}
						}
					}
					finally
					{
						IEnumerator enumerator = null;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				int num3 = 0;
				int num4 = 0;
				int num5 = datagridview_referenciaperifico.RowCount - 1;
				for (i = num4; i <= num5; i++)
				{
					num3 += datagridview_referenciaperifico.Rows[i].Height;
				}
				datagridview_referenciaperifico.Height = datagridview_referenciaperifico.ColumnHeadersHeight + num3 + 2;
			}
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x0033FB80 File Offset: 0x0033DF80
		private void InicializaEstrutura_DataGridView_Periferico1()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[num].LinhasMenu = new string[perifericos.perif_RT820_360.Count + 1];
					RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[num].LinhasValor = new int[perifericos.perif_RT820_360.Count + 1];
					num++;
				}
				while (num <= 1);
				RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[0].TagColuna = "Modelo";
				RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[1].TagColuna = "Endereço";
				RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[0].NomeColuna = "modelo";
				RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[1].NomeColuna = "end";
				RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[0].LarguraColuna = 250;
				RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[1].LarguraColuna = 60;
				RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[0].NumeroLinhaMenu = perifericos.perif_RT820_360.Count;
				int num2 = 48;
				num = 0;
				try
				{
					foreach (perifericos.Periferico periferico in perifericos.perif_RT820_360)
					{
						RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[0].LinhasMenu[num] = periferico.nome;
						RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[0].LinhasValor[num] = num2 + num;
						num++;
					}
				}
				finally
				{
					List<perifericos.Periferico>.Enumerator enumerator = default(List<perifericos.Periferico>.Enumerator);
					enumerator.Dispose();
				}
				RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[1].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x0033FD18 File Offset: 0x0033E118
		private void InitializaEstrutura_DataGridView_PerifericoModbusGenerico()
		{
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].LinhasMenu = new string[4];
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].LinhasValor = new int[4];
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[0].TagColuna = "Endereço";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].TagColuna = "Função";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[2].TagColuna = "Memória1";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[3].TagColuna = "Variável1";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[4].TagColuna = "Memória2";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[5].TagColuna = "Variável2";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[6].TagColuna = "Memória3";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[7].TagColuna = "Variável3";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[8].TagColuna = "Memória4";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[9].TagColuna = "Variável4";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[0].NomeColuna = "end";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].NomeColuna = "func";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[2].NomeColuna = "mem1";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[3].NomeColuna = "var1";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[4].NomeColuna = "mem2";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[5].NomeColuna = "var2";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[6].NomeColuna = "mem3";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[7].NomeColuna = "var3";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[8].NomeColuna = "mem4";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[9].NomeColuna = "var4";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[0].LarguraColuna = 100;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].LarguraColuna = 100;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[2].LarguraColuna = 60;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[3].LarguraColuna = 60;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[4].LarguraColuna = 60;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[5].LarguraColuna = 60;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[6].LarguraColuna = 60;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[7].LarguraColuna = 60;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[8].LarguraColuna = 60;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[9].LarguraColuna = 60;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[3].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[4].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[5].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[6].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[7].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[8].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[9].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[0].NumeroLinhaMenu = 0;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].NumeroLinhaMenu = 3;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[2].NumeroLinhaMenu = 0;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[3].NumeroLinhaMenu = 0;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[4].NumeroLinhaMenu = 0;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[5].NumeroLinhaMenu = 0;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[6].NumeroLinhaMenu = 0;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[7].NumeroLinhaMenu = 0;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[8].NumeroLinhaMenu = 0;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[9].NumeroLinhaMenu = 0;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].LinhasMenu[0] = "FUNÇÃO 1";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].LinhasMenu[1] = "FUNÇÃO 3";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].LinhasMenu[2] = "FUNÇÃO 4";
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].LinhasValor[0] = 1;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].LinhasValor[1] = 3;
			RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].LinhasValor[2] = 4;
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x0034018C File Offset: 0x0033E58C
		private void InicializaEstrutura_DataGridView_Periferico2()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[num].LinhasMenu = new string[perifericos.perif_RT820_360.Count + 1];
					RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[num].LinhasValor = new int[perifericos.perif_RT820_360.Count + 1];
					num++;
				}
				while (num <= 1);
				RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[0].TagColuna = "Modelo";
				RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[1].TagColuna = "Endereço";
				RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[0].NomeColuna = "modelo";
				RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[1].NomeColuna = "end";
				RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[0].LarguraColuna = 250;
				RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[1].LarguraColuna = 60;
				RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[0].NumeroLinhaMenu = perifericos.perif_RT820_360.Count;
				int num2 = 48;
				num = 0;
				try
				{
					foreach (perifericos.Periferico periferico in perifericos.perif_RT820_360)
					{
						RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[0].LinhasMenu[num] = periferico.nome;
						RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[0].LinhasValor[num] = num2 + num;
						num++;
					}
				}
				finally
				{
					List<perifericos.Periferico>.Enumerator enumerator = default(List<perifericos.Periferico>.Enumerator);
					enumerator.Dispose();
				}
				RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[1].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00340324 File Offset: 0x0033E724
		private void InicializaEstrutura_DataGridView_Referencia_Periferico()
		{
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu = new string[7];
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor = new int[7];
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasMenu = new string[21];
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasValor = new int[21];
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LinhasMenu = new string[17];
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LinhasValor = new int[17];
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasMenu = new string[6];
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor = new int[6];
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasMenu = new string[5];
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasValor = new int[5];
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].TagColuna = "Periférico";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[1].TagColuna = "Memória";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].TagColuna = "Variável1";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].TagColuna = "Variável2";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[4].TagColuna = "Escala";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].TagColuna = "Formato";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].TagColuna = "Base 10";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].NomeColuna = "perif";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[1].NomeColuna = "endmem";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].NomeColuna = "var1";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].NomeColuna = "var2";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[4].NomeColuna = "escala";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].NomeColuna = "formato";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].NomeColuna = "base10";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].NumeroLinhaMenu = 6;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[1].NumeroLinhaMenu = 0;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].NumeroLinhaMenu = 20;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].NumeroLinhaMenu = 16;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[4].NumeroLinhaMenu = 0;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].NumeroLinhaMenu = 5;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].NumeroLinhaMenu = 4;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LarguraColuna = 100;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[1].LarguraColuna = 80;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LarguraColuna = 100;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LarguraColuna = 100;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[4].LarguraColuna = 80;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LarguraColuna = 100;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LarguraColuna = 100;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[4].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor[0] = 0;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor[1] = 1;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor[2] = 2;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor[3] = 3;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor[4] = 4;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor[5] = 5;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu[0] = "Desabilitado";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu[1] = "Periférico 1";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu[2] = "Periférico 2";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu[3] = "Periférico 3";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu[4] = "Periférico 4";
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu[5] = "Periférico 5";
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasValor[num] = 21857 + num;
					RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasMenu[num] = "EA - " + Strings.Format(num + 1, "0#");
					num++;
				}
				while (num <= 15);
				num = 16;
				do
				{
					RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasValor[num] = 21868 + num;
					RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasMenu[num] = "Referência " + Strings.Format(num - 15, "#");
					num++;
				}
				while (num <= 19);
				num = 0;
				do
				{
					RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LinhasValor[num] = 21857 + num;
					RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LinhasMenu[num] = "EA - " + Strings.Format(num + 1, "0#");
					num++;
				}
				while (num <= 15);
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor[0] = 0;
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor[1] = 1;
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor[2] = 2;
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor[2] = 3;
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor[2] = 4;
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasMenu[0] = "Integer";
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasMenu[1] = "Integer SWAP";
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasMenu[2] = "Long";
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasMenu[3] = "Long Inverso";
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasMenu[4] = "Long SWAP";
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasValor[0] = 0;
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasValor[1] = 1;
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasValor[2] = 2;
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasValor[3] = 3;
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasMenu[0] = "0";
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasMenu[1] = ".0";
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasMenu[2] = ".00";
				RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasMenu[3] = ".000";
			}
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00340A1C File Offset: 0x0033EE1C
		private void InicializaEstrutura_DataGridView_Atuador1()
		{
			string[] array = new string[]
			{
				"Periférico",
				"End. Memória",
				"Variável1",
				"Escala1",
				"Variável2",
				"Escala2",
				"Histerese",
				"Formato",
				"Base 10",
				"Var1 Baixo",
				"Var1 Alto",
				"Var2 Baixo",
				"Var2 Alto"
			};
			string[] array2 = new string[]
			{
				"perif",
				"endmem",
				"var1",
				"escala1",
				"var2",
				"escala2",
				"hist",
				"format",
				"base10",
				"V1Baixo",
				"V1Alto",
				"V2Baixo",
				"V2Alto"
			};
			int[] array3 = new int[]
			{
				100,
				100,
				100,
				80,
				100,
				80,
				80,
				100,
				100,
				83,
				83,
				83,
				83
			};
			RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasMenu = new string[7];
			RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasValor = new int[7];
			RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].LinhasMenu = new string[21];
			RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].LinhasValor = new int[21];
			RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].LinhasMenu = new string[17];
			RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].LinhasValor = new int[17];
			RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasMenu = new string[6];
			RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasValor = new int[6];
			RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasMenu = new string[5];
			RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasValor = new int[5];
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador1Colunas[num].TagColuna = array[num];
					RT_geral.RT_820_DataGrigViewAtuador1Colunas[num].NomeColuna = array2[num];
					num++;
				}
				while (num <= 12);
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].NumeroLinhaMenu = 6;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].NumeroLinhaMenu = 20;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].NumeroLinhaMenu = 16;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].NumeroLinhaMenu = 5;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].NumeroLinhaMenu = 4;
				num = 0;
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador1Colunas[num].LarguraColuna = array3[num];
					RT_geral.RT_820_DataGrigViewAtuador1Colunas[num].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
					num++;
				}
				while (num <= 12);
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasValor[0] = 0;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasValor[1] = 1;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasValor[2] = 2;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasValor[3] = 3;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasValor[4] = 4;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasValor[5] = 5;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasMenu[0] = "Desabilitado";
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasMenu[1] = "Periférico 1";
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasMenu[2] = "Periférico 2";
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasMenu[3] = "Periférico 3";
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasMenu[4] = "Periférico 4";
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasMenu[5] = "Periférico 5";
				int num2 = 0;
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].LinhasValor[num2] = num2 + 21857;
					RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].LinhasMenu[num2] = "EA - " + Strings.Format(num2 + 1, "0#");
					num2++;
				}
				while (num2 <= 15);
				num2 = 16;
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].LinhasValor[num2] = num2 - 16 + 21873;
					RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].LinhasMenu[num2] = "Referência " + Strings.Format(num2 - 15, "#");
					num2++;
				}
				while (num2 <= 19);
				num2 = 0;
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].LinhasValor[num2] = num2 + 21857;
					RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].LinhasMenu[num2] = "EA - " + Strings.Format(num2 + 1, "0#");
					num2++;
				}
				while (num2 <= 15);
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasValor[0] = 0;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasValor[1] = 1;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasValor[2] = 2;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasValor[3] = 3;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasValor[4] = 4;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasMenu[0] = "Integer";
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasMenu[1] = "Integer SWAP";
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasMenu[2] = "Long";
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasMenu[3] = "Long Inverso";
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasMenu[4] = "Long SWAP";
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasValor[0] = 0;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasValor[1] = 1;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasValor[2] = 2;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasValor[3] = 3;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasMenu[0] = "0";
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasMenu[1] = ".0";
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasMenu[2] = ".00";
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasMenu[3] = ".000";
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[3].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[5].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[6].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[9].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[10].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[11].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[12].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			}
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x0034118C File Offset: 0x0033F58C
		private void InicializaEstrutura_DataGridView_Atuador2()
		{
			string[] array = new string[]
			{
				"Periférico",
				"End. Memória",
				"Variável1",
				"Escala1",
				"Variável2",
				"Escala2",
				"Histerese",
				"Formato",
				"Base 10",
				"Var1 Baixo",
				"Var1 Alto",
				"Var2 Baixo",
				"Var2 Alto"
			};
			string[] array2 = new string[]
			{
				"perif",
				"endmem",
				"var1",
				"escala1",
				"var2",
				"escala2",
				"hist",
				"format",
				"base10",
				"V1Baixo",
				"V1Alto",
				"V2Baixo",
				"V2Alto"
			};
			int[] array3 = new int[]
			{
				100,
				100,
				100,
				80,
				100,
				80,
				80,
				100,
				100,
				83,
				83,
				83,
				83
			};
			RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasMenu = new string[7];
			RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasValor = new int[7];
			RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].LinhasMenu = new string[21];
			RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].LinhasValor = new int[21];
			RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].LinhasMenu = new string[17];
			RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].LinhasValor = new int[17];
			RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasMenu = new string[6];
			RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasValor = new int[6];
			RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasMenu = new string[5];
			RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasValor = new int[5];
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador2Colunas[num].TagColuna = array[num];
					RT_geral.RT_820_DataGrigViewAtuador2Colunas[num].NomeColuna = array2[num];
					num++;
				}
				while (num <= 12);
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].NumeroLinhaMenu = 6;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].NumeroLinhaMenu = 20;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].NumeroLinhaMenu = 16;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].NumeroLinhaMenu = 5;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].NumeroLinhaMenu = 4;
				num = 0;
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador2Colunas[num].LarguraColuna = array3[num];
					RT_geral.RT_820_DataGrigViewAtuador2Colunas[num].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
					num++;
				}
				while (num <= 12);
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasValor[0] = 0;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasValor[1] = 1;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasValor[2] = 2;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasValor[3] = 3;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasValor[4] = 4;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasValor[5] = 5;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasMenu[0] = "Desabilitado";
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasMenu[1] = "Periférico 1";
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasMenu[2] = "Periférico 2";
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasMenu[3] = "Periférico 3";
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasMenu[4] = "Periférico 4";
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasMenu[5] = "Periférico 5";
				int num2 = 0;
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].LinhasValor[num2] = num2 + 21857;
					RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].LinhasMenu[num2] = "EA - " + Strings.Format(num2 + 1, "0#");
					num2++;
				}
				while (num2 <= 15);
				num2 = 16;
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].LinhasValor[num2] = num2 - 16 + 21873;
					RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].LinhasMenu[num2] = "Referência " + Strings.Format(num2 - 15, "#");
					num2++;
				}
				while (num2 <= 19);
				num2 = 0;
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].LinhasValor[num2] = num2 + 21857;
					RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].LinhasMenu[num2] = "EA - " + Strings.Format(num2 + 1, "0#");
					num2++;
				}
				while (num2 <= 15);
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasValor[0] = 0;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasValor[1] = 1;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasValor[2] = 2;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasValor[3] = 3;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasValor[4] = 4;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasMenu[0] = "Integer";
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasMenu[1] = "Integer SWAP";
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasMenu[2] = "Long";
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasMenu[3] = "Long Inverso";
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasMenu[4] = "Long SWAP";
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasValor[0] = 0;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasValor[1] = 1;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasValor[2] = 2;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasValor[3] = 3;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasMenu[0] = "0";
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasMenu[1] = ".0";
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasMenu[2] = ".00";
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasMenu[3] = ".000";
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[3].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[5].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[6].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[9].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[10].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[11].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[12].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			}
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x003418FC File Offset: 0x0033FCFC
		private void InicializaEstrutura_DataGridView_Atuador3()
		{
			string[] array = new string[]
			{
				"Periférico",
				"End. Memória",
				"Variável1",
				"Escala1",
				"Variável2",
				"Escala2",
				"Histerese",
				"Formato",
				"Base 10",
				"Var1 Baixo",
				"Var1 Alto",
				"Var2 Baixo",
				"Var2 Alto"
			};
			string[] array2 = new string[]
			{
				"perif",
				"endmem",
				"var1",
				"escala1",
				"var2",
				"escala2",
				"hist",
				"format",
				"base10",
				"V1Baixo",
				"V1Alto",
				"V2Baixo",
				"V2Alto"
			};
			int[] array3 = new int[]
			{
				100,
				100,
				100,
				80,
				100,
				80,
				80,
				100,
				100,
				83,
				83,
				83,
				83
			};
			RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasMenu = new string[7];
			RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasValor = new int[7];
			RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].LinhasMenu = new string[21];
			RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].LinhasValor = new int[21];
			RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].LinhasMenu = new string[17];
			RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].LinhasValor = new int[17];
			RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasMenu = new string[6];
			RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasValor = new int[6];
			RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasMenu = new string[5];
			RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasValor = new int[5];
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador3Colunas[num].TagColuna = array[num];
					RT_geral.RT_820_DataGrigViewAtuador3Colunas[num].NomeColuna = array2[num];
					num++;
				}
				while (num <= 12);
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].NumeroLinhaMenu = 6;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].NumeroLinhaMenu = 20;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].NumeroLinhaMenu = 16;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].NumeroLinhaMenu = 5;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].NumeroLinhaMenu = 4;
				num = 0;
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador3Colunas[num].LarguraColuna = array3[num];
					RT_geral.RT_820_DataGrigViewAtuador3Colunas[num].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
					num++;
				}
				while (num <= 12);
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasValor[0] = 0;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasValor[1] = 1;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasValor[2] = 2;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasValor[3] = 3;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasValor[4] = 4;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasValor[5] = 5;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasMenu[0] = "Desabilitado";
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasMenu[1] = "Periférico 1";
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasMenu[2] = "Periférico 2";
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasMenu[3] = "Periférico 3";
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasMenu[4] = "Periférico 4";
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasMenu[5] = "Periférico 5";
				int num2 = 0;
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].LinhasValor[num2] = num2 + 21857;
					RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].LinhasMenu[num2] = "EA - " + Strings.Format(num2 + 1, "0#");
					num2++;
				}
				while (num2 <= 15);
				num2 = 16;
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].LinhasValor[num2] = num2 - 16 + 21873;
					RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].LinhasMenu[num2] = "Referência " + Strings.Format(num2 - 15, "#");
					num2++;
				}
				while (num2 <= 19);
				num2 = 0;
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].LinhasValor[num2] = num2 + 21857;
					RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].LinhasMenu[num2] = "EA - " + Strings.Format(num2 + 1, "0#");
					num2++;
				}
				while (num2 <= 15);
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasValor[0] = 0;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasValor[1] = 1;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasValor[2] = 2;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasValor[3] = 3;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasValor[4] = 4;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasMenu[0] = "Integer";
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasMenu[1] = "Integer SWAP";
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasMenu[2] = "Long";
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasMenu[3] = "Long Inverso";
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasMenu[4] = "Long SWAP";
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasValor[0] = 0;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasValor[1] = 1;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasValor[2] = 2;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasValor[3] = 3;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasMenu[0] = "0";
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasMenu[1] = ".0";
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasMenu[2] = ".00";
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasMenu[3] = ".000";
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[3].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[5].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[6].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[9].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[10].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[11].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[12].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			}
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x0034206C File Offset: 0x0034046C
		private void InicializaEstrutura_DataGridView_Atuador4()
		{
			string[] array = new string[]
			{
				"Periférico",
				"End. Memória",
				"Variável1",
				"Escala1",
				"Variável2",
				"Escala2",
				"Histerese",
				"Formato",
				"Base 10",
				"Var1 Baixo",
				"Var1 Alto",
				"Var2 Baixo",
				"Var2 Alto"
			};
			string[] array2 = new string[]
			{
				"perif",
				"endmem",
				"var1",
				"escala1",
				"var2",
				"escala2",
				"hist",
				"format",
				"base10",
				"V1Baixo",
				"V1Alto",
				"V2Baixo",
				"V2Alto"
			};
			int[] array3 = new int[]
			{
				100,
				100,
				100,
				80,
				100,
				80,
				80,
				100,
				100,
				83,
				83,
				83,
				83
			};
			RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasMenu = new string[7];
			RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasValor = new int[7];
			RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].LinhasMenu = new string[21];
			RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].LinhasValor = new int[21];
			RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].LinhasMenu = new string[17];
			RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].LinhasValor = new int[17];
			RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasMenu = new string[6];
			RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasValor = new int[6];
			RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasMenu = new string[5];
			RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasValor = new int[5];
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador4Colunas[num].TagColuna = array[num];
					RT_geral.RT_820_DataGrigViewAtuador4Colunas[num].NomeColuna = array2[num];
					num++;
				}
				while (num <= 12);
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].NumeroLinhaMenu = 6;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].NumeroLinhaMenu = 20;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].NumeroLinhaMenu = 16;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].NumeroLinhaMenu = 5;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].NumeroLinhaMenu = 4;
				num = 0;
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador4Colunas[num].LarguraColuna = array3[num];
					RT_geral.RT_820_DataGrigViewAtuador4Colunas[num].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
					num++;
				}
				while (num <= 12);
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasValor[0] = 0;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasValor[1] = 1;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasValor[2] = 2;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasValor[3] = 3;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasValor[4] = 4;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasValor[5] = 5;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasMenu[0] = "Desabilitado";
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasMenu[1] = "Periférico 1";
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasMenu[2] = "Periférico 2";
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasMenu[3] = "Periférico 3";
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasMenu[4] = "Periférico 4";
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasMenu[5] = "Periférico 5";
				int num2 = 0;
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].LinhasValor[num2] = num2 + 21857;
					RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].LinhasMenu[num2] = "EA - " + Strings.Format(num2 + 1, "0#");
					num2++;
				}
				while (num2 <= 15);
				num2 = 16;
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].LinhasValor[num2] = num2 - 16 + 21873;
					RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].LinhasMenu[num2] = "Referência " + Strings.Format(num2 - 15, "#");
					num2++;
				}
				while (num2 <= 19);
				num2 = 0;
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].LinhasValor[num2] = num2 + 21857;
					RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].LinhasMenu[num2] = "EA - " + Strings.Format(num2 + 1, "0#");
					num2++;
				}
				while (num2 <= 15);
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasValor[0] = 0;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasValor[1] = 1;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasValor[2] = 2;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasValor[3] = 3;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasValor[4] = 4;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasMenu[0] = "Integer";
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasMenu[1] = "Integer SWAP";
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasMenu[2] = "Long";
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasMenu[3] = "Long Inverso";
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasMenu[4] = "Long SWAP";
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasValor[0] = 0;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasValor[1] = 1;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasValor[2] = 2;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasValor[3] = 3;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasMenu[0] = "0";
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasMenu[1] = ".0";
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasMenu[2] = ".00";
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasMenu[3] = ".000";
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[3].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[5].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[6].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[9].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[10].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[11].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[12].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			}
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x003427DC File Offset: 0x00340BDC
		private void InicializaEstrutura_DataGridView_Atuador1SetPoint1()
		{
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[0].TagColuna = "Hora";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[1].TagColuna = "Minuto";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[2].TagColuna = "Ref 1";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[3].TagColuna = "Sp1";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[4].TagColuna = "Ref2";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[5].TagColuna = "Sp2";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[6].TagColuna = "Ref3";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[7].TagColuna = "Sp3";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[8].TagColuna = "Ref4";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[9].TagColuna = "Sp4";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[10].TagColuna = "Ref5";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[11].TagColuna = "Sp5";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[12].TagColuna = "Ref6";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[13].TagColuna = "Sp6";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[0].NomeColuna = "Hora";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[1].NomeColuna = "Minuto";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[2].NomeColuna = "Ref1";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[3].NomeColuna = "Sp1";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[4].NomeColuna = "Ref2";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[5].NomeColuna = "Sp2";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[6].NomeColuna = "Ref3";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[7].NomeColuna = "Sp3";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[8].NomeColuna = "Ref4";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[9].NomeColuna = "Sp4";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[10].NomeColuna = "Ref5";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[11].NomeColuna = "Sp5";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[12].NomeColuna = "Ref6";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[13].NomeColuna = "Sp6";
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[0].LarguraColuna = 50;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[1].LarguraColuna = 50;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[2].LarguraColuna = 80;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[3].LarguraColuna = 80;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[4].LarguraColuna = 80;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[5].LarguraColuna = 80;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[6].LarguraColuna = 80;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[7].LarguraColuna = 80;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[8].LarguraColuna = 80;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[9].LarguraColuna = 80;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[10].LarguraColuna = 80;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[11].LarguraColuna = 80;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[12].LarguraColuna = 80;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[13].LarguraColuna = 80;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[3].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[4].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[5].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[6].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[7].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[8].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[9].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[10].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[11].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[12].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[13].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00342C44 File Offset: 0x00341044
		private void InicializaEstrutura_DataGridView_Atuador1SetPoint2()
		{
			string[] array = new string[]
			{
				"Ref1",
				"Sp1",
				"Ref2",
				"Sp2",
				"Ref3",
				"Sp3",
				"Ref4",
				"Sp4",
				"Ref5",
				"Sp5",
				"Ref6",
				"Sp6"
			};
			string[] array2 = new string[]
			{
				"Ref1",
				"Sp1",
				"Ref2",
				"Sp2",
				"Ref3",
				"Sp3",
				"Ref4",
				"Sp4",
				"Ref5",
				"Sp5",
				"Ref6",
				"Sp6"
			};
			int[] array3 = new int[]
			{
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80
			};
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador1SetPoint2Colunas[num].TagColuna = array[num];
					RT_geral.RT_820_DataGrigViewAtuador1SetPoint2Colunas[num].NomeColuna = array2[num];
					RT_geral.RT_820_DataGrigViewAtuador1SetPoint2Colunas[num].LarguraColuna = array3[num];
					RT_geral.RT_820_DataGrigViewAtuador1SetPoint2Colunas[num].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
					num++;
				}
				while (num <= 11);
			}
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00342DF4 File Offset: 0x003411F4
		private void InicializaEstrutura_DataGridView_Atuador2SetPoint1()
		{
			string[] array = new string[]
			{
				"Hora",
				"Minuto",
				"Ref1",
				"Sp1",
				"Ref2",
				"Sp2",
				"Ref3",
				"Sp3",
				"Ref4",
				"Sp4",
				"Ref5",
				"Sp5",
				"Ref6",
				"Sp6"
			};
			string[] array2 = new string[]
			{
				"Hora",
				"Minuto",
				"Ref1",
				"Sp1",
				"Ref2",
				"Sp2",
				"Ref3",
				"Sp3",
				"Ref4",
				"Sp4",
				"Ref5",
				"Sp5",
				"Ref6",
				"Sp6"
			};
			int[] array3 = new int[]
			{
				50,
				50,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80
			};
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador2SetPoint1Colunas[num].TagColuna = array[num];
					RT_geral.RT_820_DataGrigViewAtuador2SetPoint1Colunas[num].NomeColuna = array2[num];
					RT_geral.RT_820_DataGrigViewAtuador2SetPoint1Colunas[num].LarguraColuna = array3[num];
					RT_geral.RT_820_DataGrigViewAtuador2SetPoint1Colunas[num].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
					num++;
				}
				while (num <= 13);
			}
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00342FDC File Offset: 0x003413DC
		private void InicializaEstrutura_DataGridView_Atuador3SetPoint1()
		{
			string[] array = new string[]
			{
				"Hora",
				"Minuto",
				"Ref1",
				"Sp1",
				"Ref2",
				"Sp2",
				"Ref3",
				"Sp3",
				"Ref4",
				"Sp4",
				"Ref5",
				"Sp5",
				"Ref6",
				"Sp6"
			};
			string[] array2 = new string[]
			{
				"Hora",
				"Minuto",
				"Ref1",
				"Sp1",
				"Ref2",
				"Sp2",
				"Ref3",
				"Sp3",
				"Ref4",
				"Sp4",
				"Ref5",
				"Sp5",
				"Ref6",
				"Sp6"
			};
			int[] array3 = new int[]
			{
				50,
				50,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80
			};
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador3SetPoint1Colunas[num].TagColuna = array[num];
					RT_geral.RT_820_DataGrigViewAtuador3SetPoint1Colunas[num].NomeColuna = array2[num];
					RT_geral.RT_820_DataGrigViewAtuador3SetPoint1Colunas[num].LarguraColuna = array3[num];
					RT_geral.RT_820_DataGrigViewAtuador3SetPoint1Colunas[num].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
					num++;
				}
				while (num <= 13);
			}
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x003431C4 File Offset: 0x003415C4
		private void InicializaEstrutura_DataGridView_Atuador4SetPoint1()
		{
			string[] array = new string[]
			{
				"Hora",
				"Minuto",
				"Ref1",
				"Sp1",
				"Ref2",
				"Sp2",
				"Ref3",
				"Sp3",
				"Ref4",
				"Sp4",
				"Ref5",
				"Sp5",
				"Ref6",
				"Sp6"
			};
			string[] array2 = new string[]
			{
				"Hora",
				"Minuto",
				"Ref1",
				"Sp1",
				"Ref2",
				"Sp2",
				"Ref3",
				"Sp3",
				"Ref4",
				"Sp4",
				"Ref5",
				"Sp5",
				"Ref6",
				"Sp6"
			};
			int[] array3 = new int[]
			{
				50,
				50,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80
			};
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador4SetPoint1Colunas[num].TagColuna = array[num];
					RT_geral.RT_820_DataGrigViewAtuador4SetPoint1Colunas[num].NomeColuna = array2[num];
					RT_geral.RT_820_DataGrigViewAtuador4SetPoint1Colunas[num].LarguraColuna = array3[num];
					RT_geral.RT_820_DataGrigViewAtuador4SetPoint1Colunas[num].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
					num++;
				}
				while (num <= 13);
			}
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x003433AC File Offset: 0x003417AC
		private void InicializaEstrutura_DataGridView_Atuador2SetPoint2()
		{
			string[] array = new string[]
			{
				"Ref1",
				"Sp1",
				"Ref2",
				"Sp2",
				"Ref3",
				"Sp3",
				"Ref4",
				"Sp4",
				"Ref5",
				"Sp5",
				"Ref6",
				"Sp6"
			};
			string[] array2 = new string[]
			{
				"Ref1",
				"Sp1",
				"Ref2",
				"Sp2",
				"Ref3",
				"Sp3",
				"Ref4",
				"Sp4",
				"Ref5",
				"Sp5",
				"Ref6",
				"Sp6"
			};
			int[] array3 = new int[]
			{
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80
			};
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador2SetPoint2Colunas[num].TagColuna = array[num];
					RT_geral.RT_820_DataGrigViewAtuador2SetPoint2Colunas[num].NomeColuna = array2[num];
					RT_geral.RT_820_DataGrigViewAtuador2SetPoint2Colunas[num].LarguraColuna = array3[num];
					RT_geral.RT_820_DataGrigViewAtuador2SetPoint2Colunas[num].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
					num++;
				}
				while (num <= 11);
			}
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0034355C File Offset: 0x0034195C
		private void InicializaEstrutura_DataGridView_Atuador3SetPoint2()
		{
			string[] array = new string[]
			{
				"Ref1",
				"Sp1",
				"Ref2",
				"Sp2",
				"Ref3",
				"Sp3",
				"Ref4",
				"Sp4",
				"Ref5",
				"Sp5",
				"Ref6",
				"Sp6"
			};
			string[] array2 = new string[]
			{
				"Ref1",
				"Sp1",
				"Ref2",
				"Sp2",
				"Ref3",
				"Sp3",
				"Ref4",
				"Sp4",
				"Ref5",
				"Sp5",
				"Ref6",
				"Sp6"
			};
			int[] array3 = new int[]
			{
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80
			};
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador3SetPoint2Colunas[num].TagColuna = array[num];
					RT_geral.RT_820_DataGrigViewAtuador3SetPoint2Colunas[num].NomeColuna = array2[num];
					RT_geral.RT_820_DataGrigViewAtuador3SetPoint2Colunas[num].LarguraColuna = array3[num];
					RT_geral.RT_820_DataGrigViewAtuador3SetPoint2Colunas[num].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
					num++;
				}
				while (num <= 11);
			}
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x0034370C File Offset: 0x00341B0C
		private void InicializaEstrutura_DataGridView_Atuador4SetPoint2()
		{
			string[] array = new string[]
			{
				"Ref1",
				"Sp1",
				"Ref2",
				"Sp2",
				"Ref3",
				"Sp3",
				"Ref4",
				"Sp4",
				"Ref5",
				"Sp5",
				"Ref6",
				"Sp6"
			};
			string[] array2 = new string[]
			{
				"Ref1",
				"Sp1",
				"Ref2",
				"Sp2",
				"Ref3",
				"Sp3",
				"Ref4",
				"Sp4",
				"Ref5",
				"Sp5",
				"Ref6",
				"Sp6"
			};
			int[] array3 = new int[]
			{
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80,
				80
			};
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewAtuador4SetPoint2Colunas[num].TagColuna = array[num];
					RT_geral.RT_820_DataGrigViewAtuador4SetPoint2Colunas[num].NomeColuna = array2[num];
					RT_geral.RT_820_DataGrigViewAtuador4SetPoint2Colunas[num].LarguraColuna = array3[num];
					RT_geral.RT_820_DataGrigViewAtuador4SetPoint2Colunas[num].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
					num++;
				}
				while (num <= 11);
			}
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x003438BC File Offset: 0x00341CBC
		private void GeraDGV_Colunas(DataGridView datagridview, RT_geral.DADOS_DATAGRIDVIEW_RT_820[] colunas, int NUM_COLUNAS, int NUM_LINHAS)
		{
			RT_geral.DADOS_DATAGRIDVIEW_RT_820[] array = colunas;
			bool flag = false;
			datagridview.Columns.Clear();
			datagridview.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			datagridview.DefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			datagridview.AllowUserToAddRows = false;
			datagridview.AllowUserToDeleteRows = false;
			datagridview.AllowUserToOrderColumns = false;
			datagridview.AllowUserToResizeColumns = false;
			datagridview.AllowUserToResizeRows = false;
			int num = 0;
			int num2 = 0;
			checked
			{
				int num3 = NUM_COLUNAS - 1;
				for (int i = num2; i <= num3; i++)
				{
					if (array[i].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(i), ref array);
						datagridview.Columns.Insert(i, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(i), ref array);
						datagridview.Columns.Insert(i, dataGridViewTextBoxColumn);
					}
					num += array[i].LarguraColuna;
				}
				datagridview.RowCount = NUM_LINHAS;
				if (flag)
				{
					datagridview.RowHeadersWidth = 50;
					datagridview.RowHeadersVisible = true;
					num += 2;
				}
				else
				{
					datagridview.RowHeadersWidth = 4;
					datagridview.RowHeadersVisible = false;
				}
				datagridview.Width = num + datagridview.RowHeadersWidth;
				datagridview.Width = datagridview.Columns.GetColumnsWidth(0) + datagridview.RowHeadersWidth + 0;
				if (flag)
				{
					int num4 = 1;
					try
					{
						foreach (object obj in datagridview.Rows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							if (!dataGridViewRow.IsNewRow)
							{
								dataGridViewRow.HeaderCell.Value = num4.ToString();
								num4++;
							}
						}
					}
					finally
					{
						IEnumerator enumerator = null;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				int num5 = 0;
				int num6 = 0;
				int num7 = datagridview.RowCount - 1;
				for (int i = num6; i <= num7; i++)
				{
					num5 += datagridview.Rows[i].Height;
				}
				datagridview.Height = datagridview.ColumnHeadersHeight + num5;
				datagridview.Height = datagridview.Rows.GetRowsHeight(0) + datagridview.ColumnHeadersHeight + 0;
			}
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00343AB0 File Offset: 0x00341EB0
		private void GeraDGV_Colunas_ID_LINHAS(DataGridView datagridview, RT_geral.DADOS_DATAGRIDVIEW_RT_820[] colunas, int NUM_COLUNAS, int NUM_LINHAS, string nome_linha)
		{
			RT_geral.DADOS_DATAGRIDVIEW_RT_820[] array = colunas;
			bool flag = true;
			datagridview.Columns.Clear();
			datagridview.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			datagridview.DefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			datagridview.AllowUserToAddRows = false;
			datagridview.AllowUserToDeleteRows = false;
			datagridview.AllowUserToOrderColumns = false;
			datagridview.AllowUserToResizeColumns = false;
			datagridview.AllowUserToResizeRows = false;
			int num = 0;
			int num2 = 0;
			checked
			{
				int num3 = NUM_COLUNAS - 1;
				for (int i = num2; i <= num3; i++)
				{
					if (array[i].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(i), ref array);
						datagridview.Columns.Insert(i, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(i), ref array);
						datagridview.Columns.Insert(i, dataGridViewTextBoxColumn);
					}
					num += array[i].LarguraColuna;
				}
				datagridview.RowCount = NUM_LINHAS;
				if (flag)
				{
					datagridview.RowHeadersWidth = 90;
					datagridview.RowHeadersVisible = true;
					num += 2;
				}
				else
				{
					datagridview.RowHeadersWidth = 4;
					datagridview.RowHeadersVisible = false;
				}
				datagridview.Width = num + datagridview.RowHeadersWidth;
				datagridview.Width = datagridview.Columns.GetColumnsWidth(0) + datagridview.RowHeadersWidth + 0;
				if (flag)
				{
					int num4 = 1;
					try
					{
						foreach (object obj in datagridview.Rows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							if (!dataGridViewRow.IsNewRow)
							{
								dataGridViewRow.HeaderCell.Value = nome_linha + " " + num4.ToString();
								num4++;
							}
						}
					}
					finally
					{
						IEnumerator enumerator = null;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				int num5 = 0;
				int num6 = 0;
				int num7 = datagridview.RowCount - 1;
				for (int i = num6; i <= num7; i++)
				{
					num5 += datagridview.Rows[i].Height;
				}
				datagridview.Height = datagridview.ColumnHeadersHeight + num5;
				datagridview.Height = datagridview.Rows.GetRowsHeight(0) + datagridview.ColumnHeadersHeight + 0;
			}
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00343CB0 File Offset: 0x003420B0
		private void GeraDataGridView_Atuador1SetPoint1()
		{
			DataGridView dgv_atuador_setpoint = this.dgv_atuador_setpoint1;
			RT_geral.DADOS_DATAGRIDVIEW_RT_820[] rt_820_DataGrigViewAtuador1SetPoint1Colunas = RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas;
			bool flag = true;
			dgv_atuador_setpoint.Columns.Clear();
			dgv_atuador_setpoint.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			dgv_atuador_setpoint.DefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			dgv_atuador_setpoint.AllowUserToAddRows = false;
			dgv_atuador_setpoint.AllowUserToDeleteRows = false;
			dgv_atuador_setpoint.AllowUserToOrderColumns = false;
			dgv_atuador_setpoint.AllowUserToResizeColumns = false;
			dgv_atuador_setpoint.AllowUserToResizeRows = false;
			int num = 0;
			int i = 0;
			checked
			{
				do
				{
					if (rt_820_DataGrigViewAtuador1SetPoint1Colunas[i].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(i), ref rt_820_DataGrigViewAtuador1SetPoint1Colunas);
						dgv_atuador_setpoint.Columns.Insert(i, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(i), ref rt_820_DataGrigViewAtuador1SetPoint1Colunas);
						dgv_atuador_setpoint.Columns.Insert(i, dataGridViewTextBoxColumn);
					}
					num += rt_820_DataGrigViewAtuador1SetPoint1Colunas[i].LarguraColuna;
					i++;
				}
				while (i <= 13);
				dgv_atuador_setpoint.RowCount = 3;
				if (flag)
				{
					dgv_atuador_setpoint.RowHeadersWidth = 50;
					dgv_atuador_setpoint.RowHeadersVisible = true;
					num += 2;
				}
				else
				{
					dgv_atuador_setpoint.RowHeadersWidth = 4;
					dgv_atuador_setpoint.RowHeadersVisible = false;
				}
				dgv_atuador_setpoint.Width = num + dgv_atuador_setpoint.RowHeadersWidth;
				dgv_atuador_setpoint.Width = dgv_atuador_setpoint.Columns.GetColumnsWidth(0) + dgv_atuador_setpoint.RowHeadersWidth + 1;
				if (flag)
				{
					int num2 = 1;
					try
					{
						foreach (object obj in dgv_atuador_setpoint.Rows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							if (!dataGridViewRow.IsNewRow)
							{
								dataGridViewRow.HeaderCell.Value = num2.ToString();
								num2++;
							}
						}
					}
					finally
					{
						IEnumerator enumerator = null;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				int num3 = 0;
				int num4 = 0;
				int num5 = dgv_atuador_setpoint.RowCount - 1;
				for (i = num4; i <= num5; i++)
				{
					num3 += dgv_atuador_setpoint.Rows[i].Height;
				}
				dgv_atuador_setpoint.Height = dgv_atuador_setpoint.ColumnHeadersHeight + num3 + 2;
				dgv_atuador_setpoint.Height = dgv_atuador_setpoint.Rows.GetRowsHeight(0) + dgv_atuador_setpoint.ColumnHeadersHeight + 1;
			}
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00343EA8 File Offset: 0x003422A8
		private void GeraDataGridView_Atuador1SetPoint2()
		{
			DataGridView dgv_atuador_setpoint = this.dgv_atuador_setpoint11;
			RT_geral.DADOS_DATAGRIDVIEW_RT_820[] rt_820_DataGrigViewAtuador1SetPoint2Colunas = RT_geral.RT_820_DataGrigViewAtuador1SetPoint2Colunas;
			bool flag = true;
			dgv_atuador_setpoint.Columns.Clear();
			dgv_atuador_setpoint.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			dgv_atuador_setpoint.DefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			dgv_atuador_setpoint.AllowUserToAddRows = false;
			dgv_atuador_setpoint.AllowUserToDeleteRows = false;
			dgv_atuador_setpoint.AllowUserToOrderColumns = false;
			dgv_atuador_setpoint.AllowUserToResizeColumns = false;
			dgv_atuador_setpoint.AllowUserToResizeRows = false;
			int num = 0;
			int i = 0;
			checked
			{
				do
				{
					if (rt_820_DataGrigViewAtuador1SetPoint2Colunas[i].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(i), ref rt_820_DataGrigViewAtuador1SetPoint2Colunas);
						dgv_atuador_setpoint.Columns.Insert(i, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(i), ref rt_820_DataGrigViewAtuador1SetPoint2Colunas);
						dgv_atuador_setpoint.Columns.Insert(i, dataGridViewTextBoxColumn);
					}
					num += rt_820_DataGrigViewAtuador1SetPoint2Colunas[i].LarguraColuna;
					i++;
				}
				while (i <= 11);
				dgv_atuador_setpoint.RowCount = 3;
				if (flag)
				{
					dgv_atuador_setpoint.RowHeadersWidth = 50;
					dgv_atuador_setpoint.RowHeadersVisible = true;
					num += 2;
				}
				else
				{
					dgv_atuador_setpoint.RowHeadersWidth = 4;
					dgv_atuador_setpoint.RowHeadersVisible = false;
				}
				dgv_atuador_setpoint.Width = num + dgv_atuador_setpoint.RowHeadersWidth;
				dgv_atuador_setpoint.Width = dgv_atuador_setpoint.Columns.GetColumnsWidth(0) + dgv_atuador_setpoint.RowHeadersWidth + 2;
				if (flag)
				{
					int num2 = 1;
					try
					{
						foreach (object obj in dgv_atuador_setpoint.Rows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							if (!dataGridViewRow.IsNewRow)
							{
								dataGridViewRow.HeaderCell.Value = num2.ToString();
								num2++;
							}
						}
					}
					finally
					{
						IEnumerator enumerator = null;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				int num3 = 0;
				int num4 = 0;
				int num5 = dgv_atuador_setpoint.RowCount - 1;
				for (i = num4; i <= num5; i++)
				{
					num3 += dgv_atuador_setpoint.Rows[i].Height;
				}
				dgv_atuador_setpoint.Height = dgv_atuador_setpoint.ColumnHeadersHeight + num3 + 2;
				dgv_atuador_setpoint.Height = dgv_atuador_setpoint.Rows.GetRowsHeight(0) + dgv_atuador_setpoint.ColumnHeadersHeight + 1;
			}
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x003440A0 File Offset: 0x003424A0
		private void GeraDataGridView_Vazoes()
		{
			this.DataGridView_vazoes_RT820.Columns.Clear();
			this.DataGridView_vazoes_RT820.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			this.DataGridView_vazoes_RT820.DefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_820_DataGrigViewVazoesColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewVazoesColunas);
						this.DataGridView_vazoes_RT820.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewVazoesColunas);
						this.DataGridView_vazoes_RT820.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 0);
				this.DataGridView_vazoes_RT820.RowCount = 8;
				this.DataGridView_vazoes_RT820.RowHeadersWidth = 80;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_vazoes_RT820.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "Vazão " + Conversions.ToString(num2);
							num2++;
						}
					}
				}
				finally
				{
					IEnumerator enumerator = null;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x003441DC File Offset: 0x003425DC
		private void InicializaEstrutura_DataGridView_Vazoes()
		{
			int num = 51;
			checked
			{
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu = new string[num + 1];
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor = new int[num + 1];
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].TagColuna = "Entrada";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].NomeColuna = "Entrada";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LarguraColuna = 200;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[0] = "Leitura desabilitada";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[1] = 21857;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[1] = "Leitura vazão - EA1";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[2] = 21858;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[2] = "Leitura vazão - EA2";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[3] = 21859;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[3] = "Leitura vazão - EA3";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[4] = 21860;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[4] = "Leitura vazão - EA4";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[5] = 21861;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[5] = "Leitura vazão - EA5";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[6] = 21862;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[6] = "Leitura vazão - EA6";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[7] = 21863;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[7] = "Leitura vazão - EA7";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[8] = 21864;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[8] = "Leitura vazão - EA8";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[9] = 21865;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[9] = "Leitura vazão - EA9";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[10] = 21866;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[10] = "Leitura vazão - EA10";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[11] = 21867;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[11] = "Leitura vazão - EA11";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[12] = 21868;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[12] = "Leitura vazão - EA12";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[13] = 21869;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[13] = "Leitura vazão - EA13";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[14] = 21870;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[14] = "Leitura vazão - EA14";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[15] = 21871;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[15] = "Leitura vazão - EA15";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[16] = 21872;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[16] = "Leitura vazão - EA16";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[17] = 21873;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[17] = "Leitura vazão - ED1";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[18] = 21874;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[18] = "Leitura vazão - ED1 reverso";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[19] = 21875;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[19] = "Leitura vazão - ED2";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[20] = 21876;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[20] = "Leitura vazão - ED2 reverso";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[21] = 21877;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[21] = "Leitura vazão - ED3";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[22] = 21878;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[22] = "Leitura vazão - ED3 reverso";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[23] = 21879;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[23] = "Leitura vazão - ED4";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[24] = 21880;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[24] = "Leitura vazão - ED4 reverso";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[25] = 21881;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[25] = "Leitura vazão - ED5";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[26] = 21882;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[26] = "Leitura vazão - ED5 reverso";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[27] = 21883;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[27] = "Leitura vazão - ED6";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[28] = 21884;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[28] = "Leitura vazão - ED6 reverso";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[29] = 21885;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[29] = "Leitura vazão - ED7";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[30] = 21886;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[30] = "Leitura vazão - ED7 reverso";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[31] = 21887;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[31] = "Leitura vazão - ED8";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[32] = 21888;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[32] = "Leitura vazão - ED8 reverso";
				if (RT_geral.RT_820_360_BD.HabExpIO.Valor == 21857)
				{
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[33] = 21889;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[33] = "Leitura vazão - ED9";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[34] = 21890;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[34] = "Leitura vazão - ED9 reverso";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[35] = 21891;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[35] = "Leitura vazão - ED10";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[36] = 21892;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[36] = "Leitura vazão - ED10 reverso";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[37] = 21893;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[37] = "Leitura vazão - ED11";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[38] = 21894;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[38] = "Leitura vazão - ED11 reverso";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[39] = 21895;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[39] = "Leitura vazão - ED12";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[40] = 21896;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[40] = "Leitura vazão - ED12 reverso";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[41] = 21897;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[41] = "Leitura vazão - ED13";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[42] = 21898;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[42] = "Leitura vazão - ED13 reverso";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[43] = 21899;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[43] = "Leitura vazão - ED14";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[44] = 21900;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[44] = "Leitura vazão - ED14 reverso";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[45] = 21901;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[45] = "Leitura vazão - ED15";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[46] = 21902;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[46] = "Leitura vazão - ED15 reverso";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[47] = 21903;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[47] = "Leitura vazão - ED16";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[48] = 21904;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[48] = "Leitura vazão - ED16 reverso";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[49] = 21905;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[49] = "Leitura - Calha 1";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[50] = 21906;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[50] = "Leitura - Calha 2";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].NumeroLinhaMenu = 51;
				}
				else
				{
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[33] = 21905;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[33] = "Leitura - Calha 1";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[34] = 21906;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[34] = "Leitura - Calha 2";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].NumeroLinhaMenu = 35;
				}
			}
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00344C8C File Offset: 0x0034308C
		private void InicializaEstutura_DataGridView_Calhas()
		{
			string[] array = new string[]
			{
				"EA",
				"Tipo Calha",
				"Altura Max(20mA) cm",
				"P1 cm",
				"P2 cm",
				"P3 cm"
			};
			string[] array2 = new string[]
			{
				"ea",
				"calha",
				"fundo_cm",
				"p1",
				"p2",
				"p3"
			};
			int[] array3 = new int[]
			{
				80,
				150,
				150,
				80,
				80,
				80
			};
			RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu = new string[17];
			RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor = new int[17];
			RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasMenu = new string[5];
			RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasValor = new int[5];
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DatagridViewCalhasColunas[num].TagColuna = array[num];
					RT_geral.RT_820_DatagridViewCalhasColunas[num].NomeColuna = array2[num];
					num++;
				}
				while (num <= 5);
				RT_geral.RT_820_DatagridViewCalhasColunas[0].NumeroLinhaMenu = 16;
				RT_geral.RT_820_DatagridViewCalhasColunas[1].NumeroLinhaMenu = 4;
				num = 0;
				do
				{
					RT_geral.RT_820_DatagridViewCalhasColunas[num].LarguraColuna = array3[num];
					RT_geral.RT_820_DatagridViewCalhasColunas[num].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
					num++;
				}
				while (num <= 5);
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[0] = 21857;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[1] = 21858;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[2] = 21859;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[3] = 21860;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[4] = 21861;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[5] = 21862;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[6] = 21863;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[7] = 21864;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[8] = 21865;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[9] = 21866;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[10] = 21867;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[11] = 21868;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[12] = 21869;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[13] = 21870;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[14] = 21871;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[15] = 21872;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[16] = 21873;
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[0] = "EA1";
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[1] = "EA2";
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[2] = "EA3";
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[3] = "EA4";
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[4] = "EA5";
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[5] = "EA6";
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[6] = "EA7";
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[7] = "EA8";
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[8] = "EA9";
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[9] = "EA10";
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[10] = "EA11";
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[11] = "EA12";
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[12] = "EA13";
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[13] = "EA14";
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[14] = "EA15";
				RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[15] = "EA16";
				RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasValor[0] = 0;
				RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasValor[1] = 1;
				RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasValor[2] = 2;
				RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasValor[3] = 3;
				RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasMenu[0] = "Sem Calha";
				RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasMenu[1] = "General Parshal Flume";
				RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasMenu[2] = "Botton Step Weir";
				RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasMenu[3] = "Supressed Retangular";
				RT_geral.RT_820_DatagridViewCalhasColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
				RT_geral.RT_820_DatagridViewCalhasColunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)16;
			}
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00345200 File Offset: 0x00343600
		private void GeraDataGridView_ED()
		{
			this.DataGridView_RT820_ED.Columns.Clear();
			this.DataGridView_RT820_ED.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			this.DataGridView_RT820_ED.DefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_820_DataGrigViewEDColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewEDColunas);
						this.DataGridView_RT820_ED.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewEDColunas);
						this.DataGridView_RT820_ED.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 0);
				if (RT_geral.RT_820_360_BD.HabExpIO.Valor == 21857)
				{
					this.DataGridView_RT820_ED.RowCount = 16;
				}
				else
				{
					this.DataGridView_RT820_ED.RowCount = 8;
				}
				this.DataGridView_RT820_ED.RowHeadersWidth = 80;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_RT820_ED.Rows)
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
					IEnumerator enumerator = null;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00345360 File Offset: 0x00343760
		private void InicializaEstrutura_DataGridView_ED()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewEDColunas[num].LinhasMenu = new string[6];
					RT_geral.RT_820_DataGrigViewEDColunas[num].LinhasValor = new int[6];
					num++;
				}
				while (num <= 0);
				RT_geral.RT_820_DataGrigViewEDColunas[0].TagColuna = "Entrada";
				RT_geral.RT_820_DataGrigViewEDColunas[0].NomeColuna = "Entrada";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LarguraColuna = 200;
				RT_geral.RT_820_DataGrigViewEDColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[1] = 21969;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[2] = 21970;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[3] = 21971;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[4] = 21972;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[0] = "Entrada desabilitada";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[1] = "Verificação de arrombamento";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[2] = "Verificação de falta de fase";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[3] = "Verificação de alagamento";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[4] = "Verificação de horário de ponta";
				RT_geral.RT_820_DataGrigViewEDColunas[0].NumeroLinhaMenu = 5;
			}
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x003454EC File Offset: 0x003438EC
		private void GeraDataGridView_Repedidora()
		{
			this.DataGridView_end_rep_RT820.Columns.Clear();
			this.DataGridView_end_rep_RT820.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			this.DataGridView_end_rep_RT820.DefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_820_DataGrigViewRepetidoraColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewRepetidoraColunas);
						this.DataGridView_end_rep_RT820.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewRepetidoraColunas);
						this.DataGridView_end_rep_RT820.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 9);
				this.DataGridView_end_rep_RT820.RowCount = 10;
				num = 0;
				do
				{
					this.DataGridView_end_rep_RT820.Columns[num].ReadOnly = true;
					num++;
				}
				while (num <= 9);
				num = 0;
				do
				{
					this.DataGridView_end_rep_RT820[0, num].Value = num + 1;
					this.DataGridView_end_rep_RT820[2, num].Value = num + 11;
					this.DataGridView_end_rep_RT820[4, num].Value = num + 21;
					this.DataGridView_end_rep_RT820[6, num].Value = num + 31;
					this.DataGridView_end_rep_RT820[8, num].Value = num + 41;
					num++;
				}
				while (num <= 9);
			}
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00345650 File Offset: 0x00343A50
		private void InicializaEstrutura_DataGridView_repetidora()
		{
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[0].TagColuna = "Posição";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[1].TagColuna = "Endereço";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[2].TagColuna = "Posição";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[3].TagColuna = "Endereço";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[4].TagColuna = "Posição";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[5].TagColuna = "Endereço";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[6].TagColuna = "Posição";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[7].TagColuna = "Endereço";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[8].TagColuna = "Posição";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[9].TagColuna = "Endereço";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[0].NomeColuna = "pos_1";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[1].NomeColuna = "end_1";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[2].NomeColuna = "pos_2";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[3].NomeColuna = "end_2";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[4].NomeColuna = "pos_3";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[5].NomeColuna = "end_3";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[6].NomeColuna = "pos_4";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[7].NomeColuna = "end_4";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[8].NomeColuna = "pos_5";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[9].NomeColuna = "end_5";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[0].LarguraColuna = 50;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[1].LarguraColuna = 65;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[2].LarguraColuna = 50;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[3].LarguraColuna = 65;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[4].LarguraColuna = 50;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[5].LarguraColuna = 65;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[6].LarguraColuna = 50;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[7].LarguraColuna = 65;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[8].LarguraColuna = 50;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[9].LarguraColuna = 65;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[3].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[4].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[5].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[6].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[7].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[8].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[9].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00345970 File Offset: 0x00343D70
		private void GeraDataGridView_Setpoints()
		{
			this.DataGridView_setpoints_820.Columns.Clear();
			this.DataGridView_setpoints_820.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			this.DataGridView_setpoints_820.DefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_820_DataGrigViewSetpointsColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewSetpointsColunas);
						this.DataGridView_setpoints_820.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewSetpointsColunas);
						this.DataGridView_setpoints_820.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 5);
				this.DataGridView_setpoints_820.RowCount = 8;
				this.DataGridView_setpoints_820.RowHeadersWidth = 80;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_setpoints_820.Rows)
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
					IEnumerator enumerator = null;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00345AAC File Offset: 0x00343EAC
		private void InicializaEstrutura_DataGridView_Setpoints()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewSetpointsColunas[num].LinhasMenu = new string[22];
					RT_geral.RT_820_DataGrigViewSetpointsColunas[num].LinhasValor = new int[22];
					num++;
				}
				while (num <= 5);
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasMenu = new string[24];
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasValor = new int[24];
				RT_geral.RT_820_DataGrigViewSetpointsColunas[2].TagColuna = "Alto";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[1].TagColuna = "Baixo";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[4].TagColuna = "Bloqueio";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[5].TagColuna = "Liberação";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].TagColuna = "Variável Controle";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[3].TagColuna = "Variável Bloqueio";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[2].NomeColuna = "Set_NAlto";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[1].NomeColuna = "Set_NBaixo";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[4].NomeColuna = "Set_NBloq";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[5].NomeColuna = "Set_NLib";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].NomeColuna = "Set_Controle";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[3].NomeColuna = "Set_Bloqueio";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[2].LarguraColuna = 60;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[1].LarguraColuna = 60;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[4].LarguraColuna = 60;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[5].LarguraColuna = 60;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LarguraColuna = 160;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LarguraColuna = 160;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[4].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[5].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[3].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[2].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[1].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[4].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[5].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasMenu[0] = "Controle Desabilitado";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].NumeroLinhaMenu = 23;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasMenu[0] = "Bloqueio Desabilitado";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[3].NumeroLinhaMenu = 21;
				num = 1;
				do
				{
					RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasMenu[num] = "EA - " + Strings.Format(num, "0#");
					RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasValor[num] = 21856 + num;
					RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasMenu[num] = "EA - " + Strings.Format(num, "0#");
					RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasValor[num] = 21856 + num;
					num++;
				}
				while (num <= 16);
				num = 17;
				do
				{
					RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasMenu[num] = "Referência " + Strings.Format(num - 16, "#");
					RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasValor[num] = 21856 + num;
					RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasMenu[num] = "Referência " + Strings.Format(num - 16, "#");
					RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasValor[num] = 21856 + num;
					num++;
				}
				while (num <= 20);
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasMenu[21] = "Atuador 1";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasValor[21] = 21889;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasMenu[22] = "Atuador 2";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasValor[22] = 21890;
			}
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00345F54 File Offset: 0x00344354
		private void GeraDataGridView_Timer()
		{
			this.DataGridView_timer_RT820.Columns.Clear();
			this.DataGridView_timer_RT820.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
			this.DataGridView_timer_RT820.DefaultCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_820_DataGrigViewTimerColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewTimerColunas);
						this.DataGridView_timer_RT820.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewTimerColunas);
						this.DataGridView_timer_RT820.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 11);
				this.DataGridView_timer_RT820.RowCount = 8;
				this.DataGridView_timer_RT820.RowHeadersWidth = 80;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_timer_RT820.Rows)
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
					IEnumerator enumerator = null;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00346090 File Offset: 0x00344490
		private void InicializaEstrutura_DataGridView_Timer()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewTimerColunas[num].LinhasMenu = new string[2];
					RT_geral.RT_820_DataGrigViewTimerColunas[num].LinhasValor = new int[2];
					num++;
				}
				while (num <= 12);
				RT_geral.RT_820_DataGrigViewTimerColunas[0].TagColuna = "Liga";
				RT_geral.RT_820_DataGrigViewTimerColunas[1].TagColuna = "Desliga";
				RT_geral.RT_820_DataGrigViewTimerColunas[2].TagColuna = "Liga";
				RT_geral.RT_820_DataGrigViewTimerColunas[3].TagColuna = "Desliga";
				RT_geral.RT_820_DataGrigViewTimerColunas[4].TagColuna = "Liga";
				RT_geral.RT_820_DataGrigViewTimerColunas[5].TagColuna = "Desliga";
				RT_geral.RT_820_DataGrigViewTimerColunas[6].TagColuna = "Liga";
				RT_geral.RT_820_DataGrigViewTimerColunas[7].TagColuna = "Desliga";
				RT_geral.RT_820_DataGrigViewTimerColunas[8].TagColuna = "Liga";
				RT_geral.RT_820_DataGrigViewTimerColunas[9].TagColuna = "Desliga";
				RT_geral.RT_820_DataGrigViewTimerColunas[10].TagColuna = "Liga";
				RT_geral.RT_820_DataGrigViewTimerColunas[11].TagColuna = "Desliga";
				RT_geral.RT_820_DataGrigViewTimerColunas[0].NomeColuna = "Liga_F1";
				RT_geral.RT_820_DataGrigViewTimerColunas[1].NomeColuna = "Desliga_F1";
				RT_geral.RT_820_DataGrigViewTimerColunas[2].NomeColuna = "Liga_F2";
				RT_geral.RT_820_DataGrigViewTimerColunas[3].NomeColuna = "Desliga_F2";
				RT_geral.RT_820_DataGrigViewTimerColunas[4].NomeColuna = "Liga_F3";
				RT_geral.RT_820_DataGrigViewTimerColunas[5].NomeColuna = "Desliga_F3";
				RT_geral.RT_820_DataGrigViewTimerColunas[6].NomeColuna = "Liga_F4";
				RT_geral.RT_820_DataGrigViewTimerColunas[7].NomeColuna = "Desliga_F4";
				RT_geral.RT_820_DataGrigViewTimerColunas[8].NomeColuna = "Liga_F5";
				RT_geral.RT_820_DataGrigViewTimerColunas[9].NomeColuna = "Desliga_F5";
				RT_geral.RT_820_DataGrigViewTimerColunas[10].NomeColuna = "Liga_F6";
				RT_geral.RT_820_DataGrigViewTimerColunas[11].NomeColuna = "Desliga_F6";
				RT_geral.RT_820_DataGrigViewTimerColunas[0].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[1].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[2].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[3].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[4].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[5].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[6].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[7].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[8].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[9].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[10].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[11].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewTimerColunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewTimerColunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewTimerColunas[3].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewTimerColunas[4].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewTimerColunas[5].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewTimerColunas[6].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewTimerColunas[7].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewTimerColunas[8].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewTimerColunas[9].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewTimerColunas[10].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewTimerColunas[11].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_820_DataGrigViewTimerColunas[0].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[1].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[2].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[3].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[4].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[5].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[6].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[7].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[8].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[9].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[10].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[11].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00346558 File Offset: 0x00344958
		public void Inicializa_DadosEStruturaRT820_Padrao()
		{
			RT_geral.RT_820_360_BD.Versao.nome = "Versão";
			RT_geral.RT_820_360_BD.Versao.Padrao = 0;
			RT_geral.RT_820_360_BD.Build.nome = "Build";
			RT_geral.RT_820_360_BD.Build.Padrao = 0;
			RT_geral.RT_820_360_BD.Release.nome = "Release";
			RT_geral.RT_820_360_BD.Release.Padrao = 0;
			RT_geral.RT_820_360_BD.Equip.nome = "Tipo equipamento";
			RT_geral.RT_820_360_BD.Equip.Padrao = 0;
			RT_geral.RT_820_360_BD.End_mestre.nome = "Endereço Mestre";
			RT_geral.RT_820_360_BD.End_mestre.Padrao = 100;
			RT_geral.RT_820_360_BD.End_mestre.Lmte_inf = 1;
			RT_geral.RT_820_360_BD.End_mestre.Lmte_sup = 200;
			RT_geral.RT_820_360_BD.End_estacao1.nome = "Endereço Estação1";
			RT_geral.RT_820_360_BD.End_estacao1.Padrao = 1;
			RT_geral.RT_820_360_BD.End_estacao1.Lmte_inf = 0;
			RT_geral.RT_820_360_BD.End_estacao1.Lmte_sup = 200;
			RT_geral.RT_820_360_BD.End_estacao2.nome = "Endereço Estação2";
			RT_geral.RT_820_360_BD.End_estacao2.Padrao = 0;
			RT_geral.RT_820_360_BD.End_estacao2.Lmte_inf = 0;
			RT_geral.RT_820_360_BD.End_estacao2.Lmte_sup = 200;
			RT_geral.RT_820_360_BD.Tempo_ptt.nome = "Tempo PTT";
			RT_geral.RT_820_360_BD.Tempo_ptt.Padrao = 200;
			RT_geral.RT_820_360_BD.Tempo_ptt.Lmte_inf = 100;
			RT_geral.RT_820_360_BD.Tempo_ptt.Lmte_sup = 2000;
			RT_geral.RT_820_360_BD.TempoForaAr.nome = "Tempo Fora Ar";
			RT_geral.RT_820_360_BD.TempoForaAr.Padrao = 0;
			RT_geral.RT_820_360_BD.TempoForaAr.Lmte_inf = 0;
			RT_geral.RT_820_360_BD.TempoForaAr.Lmte_sup = 1800;
			RT_geral.RT_820_360_BD.BaudRateCOM1.nome = "Baudrate COM1";
			RT_geral.RT_820_360_BD.BaudRateCOM1.Numero_itens = perifericos.ListaBaudRate.Count;
			RT_geral.RT_820_360_BD.BaudRateCOM1.Indice_padrao = 0;
			int num = 0;
			checked
			{
				int num2 = perifericos.ListaBaudRate.Count - 1;
				int i;
				for (i = num; i <= num2; i++)
				{
					RT_geral.RT_820_360_BD.BaudRateCOM1.itens[i] = perifericos.ListaBaudRate[i].nome;
					RT_geral.RT_820_360_BD.BaudRateCOM1.valores[i] = perifericos.ListaBaudRate[i].valor;
					if (perifericos.ListaBaudRate[i].is_default)
					{
						RT_geral.RT_820_360_BD.BaudRateCOM1.Indice_padrao = i;
					}
				}
				RT_geral.RT_820_360_BD.BaudRateCOM2.nome = "Baudrate COM2";
				RT_geral.RT_820_360_BD.BaudRateCOM2.Numero_itens = perifericos.ListaBaudRate.Count;
				RT_geral.RT_820_360_BD.BaudRateCOM2.Indice_padrao = 0;
				int num3 = 0;
				int num4 = perifericos.ListaBaudRate.Count - 1;
				for (i = num3; i <= num4; i++)
				{
					RT_geral.RT_820_360_BD.BaudRateCOM2.itens[i] = perifericos.ListaBaudRate[i].nome;
					RT_geral.RT_820_360_BD.BaudRateCOM2.valores[i] = perifericos.ListaBaudRate[i].valor;
					if (perifericos.ListaBaudRate[i].is_default)
					{
						RT_geral.RT_820_360_BD.BaudRateCOM2.Indice_padrao = i;
					}
				}
				RT_geral.RT_820_360_BD.HabExpIO.nome = "Habilita Expansão I/O";
				RT_geral.RT_820_360_BD.HabExpIO.Padrao = 21856;
				RT_geral.RT_820_360_BD.HabExpIO.Lmte_inf = 21856;
				RT_geral.RT_820_360_BD.HabExpIO.Lmte_sup = 21857;
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.ctrl_acionamento[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - SD acinamento";
					RT_geral.RT_820_360_BD.ctrl_acionamento[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.ctrl_desligamento[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - SD desacionamento";
					RT_geral.RT_820_360_BD.ctrl_desligamento[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.ctrl_ret_acionamento[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - ED acionamento";
					RT_geral.RT_820_360_BD.ctrl_ret_acionamento[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.ctrl_ret_desligamento[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - ED desacionamento";
					RT_geral.RT_820_360_BD.ctrl_ret_desligamento[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.ctrl_ED_selecao[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - ED Remoto";
					RT_geral.RT_820_360_BD.ctrl_ED_selecao[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.ctrl_ED_bloqueio[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - ED bloqueio";
					RT_geral.RT_820_360_BD.ctrl_ED_bloqueio[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.ctrl_ED_liberacao[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - ED liberação";
					RT_geral.RT_820_360_BD.ctrl_ED_liberacao[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.ctrl_reverso[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Reverso ";
					RT_geral.RT_820_360_BD.ctrl_reverso[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.ctrl_modo[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Modo ";
					RT_geral.RT_820_360_BD.ctrl_modo[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.ctrl_agrupamento[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Agrupamentos ";
					RT_geral.RT_820_360_BD.ctrl_agrupamento[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.ctrl_partidas[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Partidas ";
					RT_geral.RT_820_360_BD.ctrl_partidas[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 7);
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.ctrl_tempo_max_partida[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Tempo máx partida";
					RT_geral.RT_820_360_BD.ctrl_tempo_max_partida[i].Padrao = 180;
					RT_geral.RT_820_360_BD.ctrl_tempo_max_partida[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.ctrl_tempo_max_partida[i].Lmte_sup = 1200;
					RT_geral.RT_820_360_BD.ctrl_tempo_max_parada[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Tempo máx parada";
					RT_geral.RT_820_360_BD.ctrl_tempo_max_parada[i].Padrao = 180;
					RT_geral.RT_820_360_BD.ctrl_tempo_max_parada[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.ctrl_tempo_max_parada[i].Lmte_sup = 1200;
					RT_geral.RT_820_360_BD.ctrl_tempo_min_operando[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Tempo min operando";
					RT_geral.RT_820_360_BD.ctrl_tempo_min_operando[i].Padrao = 180;
					RT_geral.RT_820_360_BD.ctrl_tempo_min_operando[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.ctrl_tempo_min_operando[i].Lmte_sup = 1200;
					RT_geral.RT_820_360_BD.ctrl_tempo_min_parado[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Tempo min parado";
					RT_geral.RT_820_360_BD.ctrl_tempo_min_parado[i].Padrao = 180;
					RT_geral.RT_820_360_BD.ctrl_tempo_min_parado[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.ctrl_tempo_min_parado[i].Lmte_sup = 1200;
					i++;
				}
				while (i <= 7);
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.grupo_simultaneos[i].nome = "Grupo " + Conversion.Str(i + 1) + " - Simultâneos ";
					RT_geral.RT_820_360_BD.grupo_simultaneos[i].Indice_padrao = 1;
					RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos[i].nome = "Grupo " + Conversion.Str(i + 1) + " - Tempo entre acionamentos";
					RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos[i].Padrao = 120;
					RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos[i].Lmte_sup = 1200;
					RT_geral.RT_820_360_BD.grupo_rotativo_motores[i].nome = "Rot_Mot " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.grupo_rotativo_motores[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 4);
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.EA_Range[i].nome = "Range sensor " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.EA_Range[i].Padrao = 4000;
					RT_geral.RT_820_360_BD.EA_Range[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.EA_Range[i].Lmte_sup = 4000;
					RT_geral.RT_820_360_BD.EA_Inicio[i].nome = "Início sensor " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.EA_Inicio[i].Padrao = 0;
					RT_geral.RT_820_360_BD.EA_Inicio[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.EA_Inicio[i].Lmte_sup = 20000;
					RT_geral.RT_820_360_BD.EA_Fim[i].nome = "Fim sensor " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.EA_Fim[i].Padrao = 4000;
					RT_geral.RT_820_360_BD.EA_Fim[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.EA_Fim[i].Lmte_sup = 50000;
					i++;
				}
				while (i <= 16);
				RT_geral.RT_820_360_BD.AD_Intervalo.nome = "Intervalo AD";
				RT_geral.RT_820_360_BD.AD_Intervalo.Padrao = 2000;
				RT_geral.RT_820_360_BD.AD_Intervalo.Lmte_inf = 500;
				RT_geral.RT_820_360_BD.AD_Intervalo.Lmte_sup = 20000;
				RT_geral.RT_820_360_BD.AD_Tamanho_filtro.nome = "Tamanho Filtro AD";
				RT_geral.RT_820_360_BD.AD_Tamanho_filtro.Padrao = 3;
				RT_geral.RT_820_360_BD.AD_Tamanho_filtro.Lmte_inf = 1;
				RT_geral.RT_820_360_BD.AD_Tamanho_filtro.Lmte_sup = 10;
				RT_geral.RT_820_360_BD.saida_SA_origem[0].nome = "SA Origem 1";
				RT_geral.RT_820_360_BD.saida_SA_origem[0].Numero_itens = perifericos.Lista_SA_Origem_RT820_400.Count;
				RT_geral.RT_820_360_BD.saida_SA_origem[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.saida_SA_origem[1].nome = "SA Origem 2";
				RT_geral.RT_820_360_BD.saida_SA_origem[1].Numero_itens = perifericos.Lista_SA_Origem_RT820_400.Count;
				RT_geral.RT_820_360_BD.saida_SA_origem[1].Indice_padrao = 0;
				int num5 = 0;
				int num6 = perifericos.Lista_SA_Origem_RT820_400.Count - 1;
				for (i = num5; i <= num6; i++)
				{
					RT_geral.RT_820_360_BD.saida_SA_origem[0].itens[i] = perifericos.Lista_SA_Origem_RT820_400[i].nome;
					RT_geral.RT_820_360_BD.saida_SA_origem[0].valores[i] = perifericos.Lista_SA_Origem_RT820_400[i].valor;
					RT_geral.RT_820_360_BD.saida_SA_origem[1].itens[i] = perifericos.Lista_SA_Origem_RT820_400[i].nome;
					RT_geral.RT_820_360_BD.saida_SA_origem[1].valores[i] = perifericos.Lista_SA_Origem_RT820_400[i].valor;
					if (perifericos.Lista_SA_Origem_RT820_400[i].is_default)
					{
						RT_geral.RT_820_360_BD.saida_SA_origem[0].Indice_padrao = i;
						RT_geral.RT_820_360_BD.saida_SA_origem[1].Indice_padrao = i;
					}
				}
				RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0].nome = "SA 1 4mA";
				RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0].Lmte_sup = 4000;
				RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0].Padrao = RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0].Lmte_inf;
				RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[1].nome = "SA 2 4mA";
				RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[1].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[1].Lmte_sup = 4000;
				RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[1].Padrao = RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0].Lmte_inf;
				RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[0].nome = "SA 1 4mA";
				RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[0].Lmte_sup = 4000;
				RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[0].Padrao = RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0].Lmte_sup;
				RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[1].nome = "SA 2 4mA";
				RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[1].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[1].Lmte_sup = 4000;
				RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[1].Padrao = RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0].Lmte_sup;
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_ED[i].nome = "ED " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_ED[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 15);
				RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.nome = "Tratamenro do Setpoint Percentual";
				RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor = 0;
				RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Lmte_inf = 0;
				RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Lmte_sup = 1;
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[i].nome = "Setpoint Alto " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[i].Padrao = 4000;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[i].Lmte_sup = 4000;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[i].nome = "Setpoint Baixo " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[i].Padrao = 0;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[i].Lmte_sup = 4000;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[i].nome = "Setpoint Bloqueio " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[i].Padrao = 400;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[i].Lmte_sup = 4000;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[i].nome = "Setpoint Liberação " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[i].Padrao = 800;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[i].Lmte_sup = 4000;
					i++;
				}
				while (i <= 8);
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.Setpoints_ctrl_variavel[i].nome = "Setpoint " + Conversion.Str(i + 1) + "Variável de Controle";
					RT_geral.RT_820_360_BD.Setpoints_ctrl_variavel[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 8);
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.Setpoints_ctrl_bloqueio[i].nome = "Setpoint " + Conversion.Str(i + 1) + "Variável de Bloqueio";
					RT_geral.RT_820_360_BD.Setpoints_ctrl_bloqueio[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 8);
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.setpoint_horario[i].Hora.nome = "Hora";
					RT_geral.RT_820_360_BD.setpoint_horario[i].Hora.Padrao = 0;
					RT_geral.RT_820_360_BD.setpoint_horario[i].Hora.Lmte_inf = 0;
					RT_geral.RT_820_360_BD.setpoint_horario[i].Hora.Lmte_sup = 23;
					RT_geral.RT_820_360_BD.setpoint_horario[i].Minuto.nome = "Minuto";
					RT_geral.RT_820_360_BD.setpoint_horario[i].Minuto.Padrao = 0;
					RT_geral.RT_820_360_BD.setpoint_horario[i].Minuto.Lmte_inf = 0;
					RT_geral.RT_820_360_BD.setpoint_horario[i].Minuto.Lmte_sup = 59;
					RT_geral.RT_820_360_BD.setpoint_horario[i].Alto.nome = "Alto";
					RT_geral.RT_820_360_BD.setpoint_horario[i].Alto.Padrao = 4000;
					RT_geral.RT_820_360_BD.setpoint_horario[i].Alto.Lmte_inf = 0;
					RT_geral.RT_820_360_BD.setpoint_horario[i].Alto.Lmte_sup = 4000;
					RT_geral.RT_820_360_BD.setpoint_horario[i].Baixo.nome = "Alto";
					RT_geral.RT_820_360_BD.setpoint_horario[i].Baixo.Padrao = 0;
					RT_geral.RT_820_360_BD.setpoint_horario[i].Baixo.Lmte_inf = 0;
					RT_geral.RT_820_360_BD.setpoint_horario[i].Baixo.Lmte_sup = 4000;
					i++;
				}
				while (i <= 79);
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_vazao[i].nome = "Vazão " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_vazao[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 7);
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.calha_EA[i].nome = "EA " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.calha_EA[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.calha_modelo[i].nome = "Calha Modelo " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.calha_modelo[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.calha_fundo[i].nome = "Calha Fundo " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.calha_fundo[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.calha_fundo[i].Lmte_sup = 1000;
					RT_geral.RT_820_360_BD.calha_fundo[i].Padrao = 0;
					RT_geral.RT_820_360_BD.calha_p1[i].nome = "P1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.calha_p1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.calha_p1[i].Lmte_sup = 1000;
					RT_geral.RT_820_360_BD.calha_p1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.calha_p2[i].nome = "P2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.calha_p2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.calha_p2[i].Lmte_sup = 1000;
					RT_geral.RT_820_360_BD.calha_p2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.calha_p3[i].nome = "P3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.calha_p3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.calha_p3[i].Lmte_sup = 1000;
					RT_geral.RT_820_360_BD.calha_p3[i].Padrao = 0;
					i++;
				}
				while (i <= 1);
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_perifericos1_mod[i].nome = "Periférico1 " + Conversion.Str(i + 1) + " - Modelo ";
					RT_geral.RT_820_360_BD.config_perifericos1_mod[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.config_perifericos1_end[i].nome = "Periférico1 " + Conversion.Str(i + 1) + " - Endereço ";
					RT_geral.RT_820_360_BD.config_perifericos1_end[i].Valor = 0;
					RT_geral.RT_820_360_BD.config_perifericos1_end[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_perifericos1_end[i].Lmte_sup = 255;
					i++;
				}
				while (i <= 5);
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_perifericos2_mod[i].nome = "Periférico2 " + Conversion.Str(i + 1) + " - Modelo ";
					RT_geral.RT_820_360_BD.config_perifericos2_mod[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.config_perifericos2_end[i].nome = "Periférico2 " + Conversion.Str(i + 1) + " - Endereço ";
					RT_geral.RT_820_360_BD.config_perifericos2_end[i].Valor = 0;
					RT_geral.RT_820_360_BD.config_perifericos2_end[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_perifericos2_end[i].Lmte_sup = 255;
					i++;
				}
				while (i <= 5);
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_endcom[i].nome = "Periferico Modbus Genérico " + Conversion.Str(i + 1) + " - Endereço Comunicação";
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_endcom[i].Valor = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_endcom[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_endcom[i].Lmte_sup = 255;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[i].nome = "Periferico Modbus Genérico " + Conversion.Str(i + 1) + " - Função ModBus";
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[i].Indice_padrao = 1;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem1[i].nome = "Periferico Modbus Genérico " + Conversion.Str(i + 1) + " - Memória 1";
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem1[i].Valor = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem1[i].Lmte_sup = 65535;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var1[i].nome = "Periferico Modbus Genérico " + Conversion.Str(i + 1) + " - Qtd Variável 1";
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var1[i].Valor = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var1[i].Lmte_sup = 10;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem2[i].nome = "Periferico Modbus Genérico " + Conversion.Str(i + 1) + " - Memória 2";
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem2[i].Valor = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem2[i].Lmte_sup = 65535;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var2[i].nome = "Periferico Modbus Genérico " + Conversion.Str(i + 1) + " - Qtd Variável 2";
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var2[i].Valor = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var2[i].Lmte_sup = 10;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem3[i].nome = "Periferico Modbus Genérico " + Conversion.Str(i + 1) + " - Memória 3";
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem3[i].Valor = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem3[i].Lmte_sup = 65535;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var3[i].nome = "Periferico Modbus Genérico " + Conversion.Str(i + 1) + " - Qtd Variável 3";
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var3[i].Valor = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var3[i].Lmte_sup = 10;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem4[i].nome = "Periferico Modbus Genérico " + Conversion.Str(i + 1) + " - Memória 4";
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem4[i].Valor = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem4[i].Lmte_sup = 65535;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var4[i].nome = "Periferico Modbus Genérico " + Conversion.Str(i + 1) + " - Qtd Variável 4";
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var4[i].Valor = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var4[i].Lmte_sup = 10;
					i++;
				}
				while (i <= 5);
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_referencia_perif_periferico[i].nome = "Ref Perif Perif" + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_referencia_perif_periferico[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.config_referencia_perif_memoria[i].nome = "Ref Perif Memória" + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_referencia_perif_memoria[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_referencia_perif_memoria[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_referencia_perif_memoria[i].Lmte_sup = 65535;
					RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[i].nome = "Ref Perif Variavel1" + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[i].nome = "Ref Perif Variavel2" + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.config_referencia_perif_escala[i].nome = "Ref Perif Escala" + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_referencia_perif_escala[i].Padrao = 4000;
					RT_geral.RT_820_360_BD.config_referencia_perif_escala[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_referencia_perif_escala[i].Lmte_sup = 4000;
					RT_geral.RT_820_360_BD.config_referencia_perif_formato[i].nome = "Ref Perif Formato" + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_referencia_perif_formato[i].Indice_padrao = 0;
					RT_geral.RT_820_360_BD.config_referencia_perif_base10[i].nome = "Ref Perif Base10" + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_referencia_perif_base10[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 9);
				RT_geral.RT_820_360_BD.config_atuador1_perif[0].nome = "Atuador1 Perif";
				RT_geral.RT_820_360_BD.config_atuador1_perif[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador1_mem[0].nome = "Atuador1 Memoria";
				RT_geral.RT_820_360_BD.config_atuador1_mem[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador1_mem[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador1_mem[0].Lmte_sup = 65535;
				RT_geral.RT_820_360_BD.config_atuador1_var1[0].nome = "Atuador1 Var1";
				RT_geral.RT_820_360_BD.config_atuador1_var1[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador1_escala1[0].nome = "Atuador1 Escala1";
				RT_geral.RT_820_360_BD.config_atuador1_escala1[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador1_escala1[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador1_escala1[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador1_var2[0].nome = "Atuador1 Var2";
				RT_geral.RT_820_360_BD.config_atuador1_var2[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador1_escala2[0].nome = "Atuador1 Escala2";
				RT_geral.RT_820_360_BD.config_atuador1_escala2[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador1_escala2[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador1_escala2[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador1_histerese[0].nome = "Atuador1 Histerese";
				RT_geral.RT_820_360_BD.config_atuador1_histerese[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador1_histerese[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador1_histerese[0].Lmte_sup = 30000;
				RT_geral.RT_820_360_BD.config_atuador1_formato[0].nome = "Atuador1 Formato";
				RT_geral.RT_820_360_BD.config_atuador1_formato[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador1_base10[0].nome = "Atuador1 Base10";
				RT_geral.RT_820_360_BD.config_atuador1_base10[0].Indice_padrao = 0;
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[i].nome = "Atuador1 Variável1 Hora" + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[i].Lmte_sup = 23;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[i].nome = "Atuador1 Variável1 Minuto" + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[i].Lmte_sup = 59;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[i].nome = "Atuador1 Variável1 Referência1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[i].nome = "Atuador1 Variável1 Referência2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[i].nome = "Atuador1 Variável1 Referência3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[i].nome = "Atuador1 Variável1 Referência4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[i].nome = "Atuador1 Variável1 Referência5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[i].nome = "Atuador1 Variável1 Referência6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[i].nome = "Atuador1 Variável1 Setpoint1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[i].nome = "Atuador1 Variável1 Setpoint2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[i].nome = "Atuador1 Variável1 Setpoint3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[i].nome = "Atuador1 Variável1 Setpoint4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[i].nome = "Atuador1 Variável1 Setpoint5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[i].nome = "Atuador1 Variável1 Setpoint6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[i].Lmte_sup = 32767;
					i++;
				}
				while (i <= 2);
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[i].nome = "Atuador1 Variável2 Referência1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[i].nome = "Atuador1 Variável2 Referência2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[i].nome = "Atuador1 Variável2 Referência3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[i].nome = "Atuador1 Variável2 Referência4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[i].nome = "Atuador1 Variável2 Referência5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[i].nome = "Atuador1 Variável2 Referência6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[i].nome = "Atuador1 Variável2 Setpoint1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[i].nome = "Atuador1 Variável2 Setpoint2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[i].nome = "Atuador1 Variável2 Setpoint3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[i].nome = "Atuador1 Variável2 Setpoint4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[i].nome = "Atuador1 Variável2 Setpoint5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[i].nome = "Atuador1 Variável2 Setpoint6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[i].Lmte_sup = 32767;
					i++;
				}
				while (i <= 2);
				RT_geral.RT_820_360_BD.config_atuador1_v1baixo[0].nome = "Atuador1 V1 Baixo";
				RT_geral.RT_820_360_BD.config_atuador1_v1baixo[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador1_v1baixo[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador1_v1baixo[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador1_v1alto[0].nome = "Atuador1 V1 Alto";
				RT_geral.RT_820_360_BD.config_atuador1_v1alto[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador1_v1alto[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador1_v1alto[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador1_v2baixo[0].nome = "Atuador1 V1 Baixo";
				RT_geral.RT_820_360_BD.config_atuador1_v2baixo[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador1_v2baixo[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador1_v2baixo[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador1_v2alto[0].nome = "Atuador1 V1 Alto";
				RT_geral.RT_820_360_BD.config_atuador1_v2alto[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador1_v2alto[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador1_v2alto[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador2_perif[0].nome = "Atuador2 Perif";
				RT_geral.RT_820_360_BD.config_atuador2_perif[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador2_mem[0].nome = "Atuador2 Memoria";
				RT_geral.RT_820_360_BD.config_atuador2_mem[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador2_mem[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador2_mem[0].Lmte_sup = 65535;
				RT_geral.RT_820_360_BD.config_atuador2_var2[0].nome = "Atuador2 Var1";
				RT_geral.RT_820_360_BD.config_atuador2_var2[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador2_escala1[0].nome = "Atuador2 Escala1";
				RT_geral.RT_820_360_BD.config_atuador2_escala1[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador2_escala1[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador2_escala1[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador2_var2[0].nome = "Atuador2 Var2";
				RT_geral.RT_820_360_BD.config_atuador2_var2[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador2_escala2[0].nome = "Atuador2 Escala2";
				RT_geral.RT_820_360_BD.config_atuador2_escala2[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador2_escala2[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador2_escala2[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador2_histerese[0].nome = "Atuador2 Histerese";
				RT_geral.RT_820_360_BD.config_atuador2_histerese[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador2_histerese[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador2_histerese[0].Lmte_sup = 30000;
				RT_geral.RT_820_360_BD.config_atuador2_formato[0].nome = "Atuador2 Formato";
				RT_geral.RT_820_360_BD.config_atuador2_formato[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador2_base10[0].nome = "Atuador2 Base10";
				RT_geral.RT_820_360_BD.config_atuador2_base10[0].Indice_padrao = 0;
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[i].nome = "Atuador2 Variável1 Hora" + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[i].Lmte_sup = 23;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[i].nome = "Atuador2 Variável1 Minuto" + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[i].Lmte_sup = 59;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[i].nome = "Atuador2 Variável1 Referência1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[i].nome = "Atuador2 Variável1 Referência2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[i].nome = "Atuador2 Variável1 Referência3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[i].nome = "Atuador2 Variável1 Referência4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[i].nome = "Atuador2 Variável1 Referência5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[i].nome = "Atuador2 Variável1 Referência6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[i].nome = "Atuador2 Variável1 Setpoint1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[i].nome = "Atuador2 Variável1 Setpoint2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[i].nome = "Atuador2 Variável1 Setpoint3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[i].nome = "Atuador2 Variável1 Setpoint4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[i].nome = "Atuador2 Variável1 Setpoint5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[i].nome = "Atuador2 Variável1 Setpoint6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[i].Lmte_sup = 32767;
					i++;
				}
				while (i <= 2);
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[i].nome = "Atuador2 Variável2 Referência1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[i].nome = "Atuador2 Variável2 Referência2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[i].nome = "Atuador2 Variável2 Referência3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[i].nome = "Atuador2 Variável2 Referência4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[i].nome = "Atuador2 Variável2 Referência5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[i].nome = "Atuador2 Variável2 Referência6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[i].nome = "Atuador2 Variável2 Setpoint1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[i].nome = "Atuador2 Variável2 Setpoint2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[i].nome = "Atuador2 Variável2 Setpoint3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[i].nome = "Atuador2 Variável2 Setpoint4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[i].nome = "Atuador2 Variável2 Setpoint5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[i].nome = "Atuador2 Variável2 Setpoint6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[i].Lmte_sup = 32767;
					i++;
				}
				while (i <= 2);
				RT_geral.RT_820_360_BD.config_atuador2_v1baixo[0].nome = "Atuador1 V1 Baixo";
				RT_geral.RT_820_360_BD.config_atuador2_v1baixo[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador2_v1baixo[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador2_v1baixo[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador2_v1alto[0].nome = "Atuador1 V1 Alto";
				RT_geral.RT_820_360_BD.config_atuador2_v1alto[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador2_v1alto[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador2_v1alto[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador2_v2baixo[0].nome = "Atuador1 V1 Baixo";
				RT_geral.RT_820_360_BD.config_atuador2_v2baixo[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador2_v2baixo[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador2_v2baixo[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador2_v2alto[0].nome = "Atuador1 V1 Alto";
				RT_geral.RT_820_360_BD.config_atuador2_v2alto[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador2_v2alto[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador2_v2alto[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador3_perif[0].nome = "Atuador3 Perif";
				RT_geral.RT_820_360_BD.config_atuador3_perif[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador3_mem[0].nome = "Atuador3 Memoria";
				RT_geral.RT_820_360_BD.config_atuador3_mem[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador3_mem[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador3_mem[0].Lmte_sup = 65535;
				RT_geral.RT_820_360_BD.config_atuador3_var1[0].nome = "Atuador3 Var1";
				RT_geral.RT_820_360_BD.config_atuador3_var1[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador3_escala1[0].nome = "Atuador3 Escala1";
				RT_geral.RT_820_360_BD.config_atuador3_escala1[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador3_escala1[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador3_escala1[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador3_var2[0].nome = "Atuador3 Var2";
				RT_geral.RT_820_360_BD.config_atuador3_var2[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador3_escala2[0].nome = "Atuador3 Escala2";
				RT_geral.RT_820_360_BD.config_atuador3_escala2[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador3_escala2[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador3_escala2[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador3_histerese[0].nome = "Atuador3 Histerese";
				RT_geral.RT_820_360_BD.config_atuador3_histerese[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador3_histerese[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador3_histerese[0].Lmte_sup = 30000;
				RT_geral.RT_820_360_BD.config_atuador3_formato[0].nome = "Atuador3 Formato";
				RT_geral.RT_820_360_BD.config_atuador3_formato[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador3_base10[0].nome = "Atuador3 Base10";
				RT_geral.RT_820_360_BD.config_atuador3_base10[0].Indice_padrao = 0;
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[i].nome = "Atuador3 Variável1 Hora" + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[i].Lmte_sup = 23;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[i].nome = "Atuador3 Variável1 Minuto" + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[i].Lmte_sup = 59;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[i].nome = "Atuador3 Variável1 Referência1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[i].nome = "Atuador3 Variável1 Referência2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[i].nome = "Atuador3 Variável1 Referência3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[i].nome = "Atuador3 Variável1 Referência4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[i].nome = "Atuador3 Variável1 Referência5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[i].nome = "Atuador3 Variável1 Referência6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[i].nome = "Atuador3 Variável1 Setpoint1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[i].nome = "Atuador3 Variável1 Setpoint2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[i].nome = "Atuador3 Variável1 Setpoint3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[i].nome = "Atuador3 Variável1 Setpoint4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[i].nome = "Atuador3 Variável1 Setpoint5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[i].nome = "Atuador3 Variável1 Setpoint6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[i].Lmte_sup = 32767;
					i++;
				}
				while (i <= 2);
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[i].nome = "Atuador3 Variável2 Referência1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[i].nome = "Atuador3 Variável2 Referência2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[i].nome = "Atuador3 Variável2 Referência3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[i].nome = "Atuador3 Variável2 Referência4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[i].nome = "Atuador3 Variável2 Referência5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[i].nome = "Atuador3 Variável2 Referência6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[i].nome = "Atuador3 Variável2 Setpoint1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[i].nome = "Atuador3 Variável2 Setpoint2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[i].nome = "Atuador3 Variável2 Setpoint3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[i].nome = "Atuador3 Variável2 Setpoint4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[i].nome = "Atuador3 Variável2 Setpoint5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[i].nome = "Atuador3 Variável2 Setpoint6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[i].Lmte_sup = 32767;
					i++;
				}
				while (i <= 2);
				RT_geral.RT_820_360_BD.config_atuador3_v1baixo[0].nome = "Atuador3 V1 Baixo";
				RT_geral.RT_820_360_BD.config_atuador3_v1baixo[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador3_v1baixo[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador3_v1baixo[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador3_v1alto[0].nome = "Atuador3 V1 Alto";
				RT_geral.RT_820_360_BD.config_atuador3_v1alto[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador3_v1alto[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador3_v1alto[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador3_v2baixo[0].nome = "Atuador3 V1 Baixo";
				RT_geral.RT_820_360_BD.config_atuador3_v2baixo[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador3_v2baixo[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador3_v2baixo[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador3_v2alto[0].nome = "Atuador3 V1 Alto";
				RT_geral.RT_820_360_BD.config_atuador3_v2alto[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador3_v2alto[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador3_v2alto[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador4_perif[0].nome = "Atuador4 Perif";
				RT_geral.RT_820_360_BD.config_atuador4_perif[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador4_mem[0].nome = "Atuador4 Memoria";
				RT_geral.RT_820_360_BD.config_atuador4_mem[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador4_mem[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador4_mem[0].Lmte_sup = 65535;
				RT_geral.RT_820_360_BD.config_atuador4_var1[0].nome = "Atuador4 Var1";
				RT_geral.RT_820_360_BD.config_atuador4_var1[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador4_escala1[0].nome = "Atuador4 Escala1";
				RT_geral.RT_820_360_BD.config_atuador4_escala1[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador4_escala1[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador4_escala1[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador4_var2[0].nome = "Atuador4 Var2";
				RT_geral.RT_820_360_BD.config_atuador4_var2[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador4_escala2[0].nome = "Atuador4 Escala2";
				RT_geral.RT_820_360_BD.config_atuador4_escala2[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador4_escala2[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador4_escala2[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador4_histerese[0].nome = "Atuador4 Histerese";
				RT_geral.RT_820_360_BD.config_atuador4_histerese[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador4_histerese[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador4_histerese[0].Lmte_sup = 30000;
				RT_geral.RT_820_360_BD.config_atuador4_formato[0].nome = "Atuador4 Formato";
				RT_geral.RT_820_360_BD.config_atuador4_formato[0].Indice_padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador4_base10[0].nome = "Atuador4 Base10";
				RT_geral.RT_820_360_BD.config_atuador4_base10[0].Indice_padrao = 0;
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[i].nome = "Atuador4 Variável1 Hora" + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[i].Lmte_sup = 23;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[i].nome = "Atuador4 Variável1 Minuto" + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[i].Lmte_sup = 59;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[i].nome = "Atuador4 Variável1 Referência1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[i].nome = "Atuador4 Variável1 Referência2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[i].nome = "Atuador4 Variável1 Referência3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[i].nome = "Atuador4 Variável1 Referência4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[i].nome = "Atuador4 Variável1 Referência5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[i].nome = "Atuador4 Variável1 Referência6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[i].nome = "Atuador4 Variável1 Setpoint1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[i].nome = "Atuador4 Variável1 Setpoint2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[i].nome = "Atuador4 Variável1 Setpoint3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[i].nome = "Atuador4 Variável1 Setpoint4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[i].nome = "Atuador4 Variável1 Setpoint5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[i].nome = "Atuador4 Variável1 Setpoint6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[i].Lmte_sup = 32767;
					i++;
				}
				while (i <= 2);
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[i].nome = "Atuador4 Variável2 Referência1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[i].nome = "Atuador4 Variável2 Referência2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[i].nome = "Atuador4 Variável2 Referência3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[i].nome = "Atuador4 Variável2 Referência4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[i].nome = "Atuador4 Variável2 Referência5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[i].nome = "Atuador4 Variável2 Referência6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[i].Lmte_sup = 10000;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[i].nome = "Atuador4 Variável2 Setpoint1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[i].nome = "Atuador4 Variável2 Setpoint2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[i].nome = "Atuador4 Variável2 Setpoint3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[i].nome = "Atuador4 Variável2 Setpoint4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[i].nome = "Atuador4 Variável2 Setpoint5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[i].Lmte_sup = 32767;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[i].nome = "Atuador4 Variável2 Setpoint6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[i].Padrao = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[i].Lmte_sup = 32767;
					i++;
				}
				while (i <= 2);
				RT_geral.RT_820_360_BD.config_atuador4_v1baixo[0].nome = "Atuador4 V1 Baixo";
				RT_geral.RT_820_360_BD.config_atuador4_v1baixo[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador4_v1baixo[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador4_v1baixo[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador4_v1alto[0].nome = "Atuador4 V1 Alto";
				RT_geral.RT_820_360_BD.config_atuador4_v1alto[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador4_v1alto[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador4_v1alto[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador4_v2baixo[0].nome = "Atuador4 V1 Baixo";
				RT_geral.RT_820_360_BD.config_atuador4_v2baixo[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador4_v2baixo[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador4_v2baixo[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.config_atuador4_v2alto[0].nome = "Atuador4 V1 Alto";
				RT_geral.RT_820_360_BD.config_atuador4_v2alto[0].Padrao = 0;
				RT_geral.RT_820_360_BD.config_atuador4_v2alto[0].Lmte_inf = 0;
				RT_geral.RT_820_360_BD.config_atuador4_v2alto[0].Lmte_sup = 10000;
				RT_geral.RT_820_360_BD.modo_repetidora.nome = "Modo de Repetidora";
				RT_geral.RT_820_360_BD.modo_repetidora.Indice_padrao = 0;
				RT_geral.RT_820_360_BD.modo_repetidora.Numero_itens = 2;
				RT_geral.RT_820_360_BD.modo_repetidora.valores[0] = 21856;
				RT_geral.RT_820_360_BD.modo_repetidora.valores[1] = 21857;
				RT_geral.RT_820_360_BD.modo_repetidora.itens[0] = "Desabilitado";
				RT_geral.RT_820_360_BD.modo_repetidora.itens[1] = "Direto";
				RT_geral.RT_820_360_BD.End_repetidora.nome = "Endereço Repetidora";
				RT_geral.RT_820_360_BD.End_repetidora.Padrao = 1;
				RT_geral.RT_820_360_BD.End_repetidora.Lmte_inf = 0;
				RT_geral.RT_820_360_BD.End_repetidora.Lmte_sup = 200;
				RT_geral.RT_820_360_BD.Num_repetidoras.nome = "Número de Repetidoras";
				RT_geral.RT_820_360_BD.Num_repetidoras.Padrao = 0;
				RT_geral.RT_820_360_BD.Num_repetidoras.Lmte_inf = 0;
				RT_geral.RT_820_360_BD.Num_repetidoras.Lmte_sup = 50;
				i = 0;
				do
				{
					RT_geral.RT_820_360_BD.Repetidoras[i].nome = "Endereço da Repetidora " + Conversion.Str(i + 1);
					RT_geral.RT_820_360_BD.Repetidoras[i].Padrao = 0;
					RT_geral.RT_820_360_BD.Repetidoras[i].Lmte_inf = 0;
					RT_geral.RT_820_360_BD.Repetidoras[i].Lmte_sup = 200;
					i++;
				}
				while (i <= 50);
				int num7 = 0;
				do
				{
					int num8 = 0;
					do
					{
						RT_geral.RT_820_360_BD.Timer_Horario[num7][num8].nome = "Timer - Ctrl " + Conversion.Str(num7 + 1);
						RT_geral.RT_820_360_BD.Timer_Horario[num7][num8].Padrao = 0;
						RT_geral.RT_820_360_BD.Timer_Horario[num7][num8].Lmte_inf = 0;
						RT_geral.RT_820_360_BD.Timer_Horario[num7][num8].Lmte_sup = 1439;
						num8++;
					}
					while (num8 <= 11);
					num7++;
				}
				while (num7 <= 7);
			}
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x0034C524 File Offset: 0x0034A924
		public void Inicializa_DadosEStruturaRT820_Default()
		{
			RT_geral.RT_820_360_BD.End_mestre.ValorPadrao();
			RT_geral.RT_820_360_BD.End_estacao2.ValorPadrao();
			RT_geral.RT_820_360_BD.End_estacao2.ValorPadrao();
			RT_geral.RT_820_360_BD.Tempo_ptt.ValorPadrao();
			RT_geral.RT_820_360_BD.TempoForaAr.ValorPadrao();
			RT_geral.RT_820_360_BD.BaudRateCOM2.Indice = perifericos.Lista_GetIndicePadrao(perifericos.ListaBaudRate);
			RT_geral.RT_820_360_BD.BaudRateCOM2.AtualizaValorPeloIndice();
			RT_geral.RT_820_360_BD.BaudRateCOM1.Indice = perifericos.Lista_GetIndicePadrao(perifericos.ListaBaudRate);
			RT_geral.RT_820_360_BD.BaudRateCOM1.AtualizaValorPeloIndice();
			RT_geral.RT_820_360_BD.HabExpIO.Valor = RT_geral.RT_820_360_BD.HabExpIO.Padrao;
			this.TextBox_comentarios_RT820.Text = "";
			this.TextBox_endereco_RT820.Text = "";
			this.TextBox_nome_RT820.Text = "";
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_360_BD.ctrl_acionamento[num].Indice = RT_geral.RT_820_360_BD.ctrl_acionamento[num].Indice_padrao;
					RT_geral.RT_820_360_BD.ctrl_acionamento[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasValor[RT_geral.RT_820_360_BD.ctrl_acionamento[num].Indice];
					RT_geral.RT_820_360_BD.ctrl_desligamento[num].Indice = RT_geral.RT_820_360_BD.ctrl_desligamento[num].Indice_padrao;
					RT_geral.RT_820_360_BD.ctrl_desligamento[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasValor[RT_geral.RT_820_360_BD.ctrl_desligamento[num].Indice];
					RT_geral.RT_820_360_BD.ctrl_ret_acionamento[num].Indice = RT_geral.RT_820_360_BD.ctrl_ret_acionamento[num].Indice_padrao;
					RT_geral.RT_820_360_BD.ctrl_ret_acionamento[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasValor[RT_geral.RT_820_360_BD.ctrl_ret_acionamento[num].Indice];
					RT_geral.RT_820_360_BD.ctrl_ret_desligamento[num].Indice = RT_geral.RT_820_360_BD.ctrl_ret_desligamento[num].Indice_padrao;
					RT_geral.RT_820_360_BD.ctrl_ret_desligamento[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasValor[RT_geral.RT_820_360_BD.ctrl_ret_desligamento[num].Indice];
					RT_geral.RT_820_360_BD.ctrl_ED_selecao[num].Indice = RT_geral.RT_820_360_BD.ctrl_ED_selecao[num].Indice_padrao;
					RT_geral.RT_820_360_BD.ctrl_ED_selecao[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[4].LinhasValor[RT_geral.RT_820_360_BD.ctrl_ED_selecao[num].Indice];
					RT_geral.RT_820_360_BD.ctrl_ED_bloqueio[num].Indice = RT_geral.RT_820_360_BD.ctrl_ED_bloqueio[num].Indice_padrao;
					RT_geral.RT_820_360_BD.ctrl_ED_bloqueio[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasValor[RT_geral.RT_820_360_BD.ctrl_ED_bloqueio[num].Indice];
					RT_geral.RT_820_360_BD.ctrl_ED_liberacao[num].Indice = RT_geral.RT_820_360_BD.ctrl_ED_liberacao[num].Indice_padrao;
					RT_geral.RT_820_360_BD.ctrl_ED_liberacao[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[6].LinhasValor[RT_geral.RT_820_360_BD.ctrl_ED_liberacao[num].Indice];
					RT_geral.RT_820_360_BD.ctrl_reverso[num].Indice = RT_geral.RT_820_360_BD.ctrl_reverso[num].Indice_padrao;
					RT_geral.RT_820_360_BD.ctrl_reverso[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[7].LinhasValor[RT_geral.RT_820_360_BD.ctrl_reverso[num].Indice];
					RT_geral.RT_820_360_BD.ctrl_modo[num].Indice = RT_geral.RT_820_360_BD.ctrl_modo[num].Indice_padrao;
					RT_geral.RT_820_360_BD.ctrl_modo[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasValor[RT_geral.RT_820_360_BD.ctrl_modo[num].Indice];
					RT_geral.RT_820_360_BD.ctrl_agrupamento[num].Indice = RT_geral.RT_820_360_BD.ctrl_agrupamento[num].Indice_padrao;
					RT_geral.RT_820_360_BD.ctrl_agrupamento[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasValor[RT_geral.RT_820_360_BD.ctrl_agrupamento[num].Indice];
					RT_geral.RT_820_360_BD.ctrl_partidas[num].Indice = RT_geral.RT_820_360_BD.ctrl_partidas[num].Indice_padrao;
					RT_geral.RT_820_360_BD.ctrl_partidas[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasValor[RT_geral.RT_820_360_BD.ctrl_partidas[num].Indice];
					RT_geral.RT_820_360_BD.ctrl_tempo_max_partida[num].Valor = RT_geral.RT_820_360_BD.ctrl_tempo_max_partida[num].Padrao;
					RT_geral.RT_820_360_BD.ctrl_tempo_max_parada[num].Valor = RT_geral.RT_820_360_BD.ctrl_tempo_max_parada[num].Padrao;
					RT_geral.RT_820_360_BD.ctrl_tempo_min_operando[num].Valor = RT_geral.RT_820_360_BD.ctrl_tempo_min_operando[num].Padrao;
					RT_geral.RT_820_360_BD.ctrl_tempo_min_parado[num].Valor = RT_geral.RT_820_360_BD.ctrl_tempo_min_parado[num].Padrao;
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					RT_geral.RT_820_360_BD.grupo_simultaneos[num].Indice = RT_geral.RT_820_360_BD.grupo_simultaneos[num].Indice_padrao;
					RT_geral.RT_820_360_BD.grupo_simultaneos[num].Valor = RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasValor[RT_geral.RT_820_360_BD.grupo_simultaneos[num].Indice];
					RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos[num].Valor = RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos[num].Padrao;
					RT_geral.RT_820_360_BD.grupo_rotativo_motores[num].Indice = RT_geral.RT_820_360_BD.grupo_rotativo_motores[num].Indice_padrao;
					RT_geral.RT_820_360_BD.grupo_rotativo_motores[num].Valor = RT_geral.RT_820_DataGrigViewGruposColunas[2].LinhasValor[RT_geral.RT_820_360_BD.grupo_rotativo_motores[num].Indice];
					num++;
				}
				while (num <= 4);
				num = 0;
				do
				{
					RT_geral.RT_820_360_BD.EA_Range[num].Valor = RT_geral.RT_820_360_BD.EA_Range[num].Padrao;
					RT_geral.RT_820_360_BD.EA_Inicio[num].Valor = RT_geral.RT_820_360_BD.EA_Inicio[num].Padrao;
					RT_geral.RT_820_360_BD.EA_Fim[num].Valor = RT_geral.RT_820_360_BD.EA_Fim[num].Padrao;
					num++;
				}
				while (num <= 16);
				RT_geral.RT_820_360_BD.AD_Intervalo.Valor = RT_geral.RT_820_360_BD.AD_Intervalo.Padrao;
				RT_geral.RT_820_360_BD.AD_Tamanho_filtro.Valor = RT_geral.RT_820_360_BD.AD_Tamanho_filtro.Padrao;
				RT_geral.RT_820_360_BD.saida_SA_origem[0].IndicePadrao();
				RT_geral.RT_820_360_BD.saida_SA_origem[1].IndicePadrao();
				RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0].ValorPadrao();
				RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[1].ValorPadrao();
				RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[0].ValorPadrao();
				RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[1].ValorPadrao();
				num = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_ED[num].Indice = RT_geral.RT_820_360_BD.config_ED[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_ED[num].Valor = RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[RT_geral.RT_820_360_BD.config_ED[num].Indice];
					num++;
				}
				while (num <= 15);
				num = 0;
				do
				{
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[num].Valor = RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[num].Padrao;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[num].Valor = RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[num].Padrao;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[num].Valor = RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[num].Padrao;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[num].Valor = RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[num].Padrao;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_variavel[num].Indice = RT_geral.RT_820_360_BD.Setpoints_ctrl_variavel[num].Indice_padrao;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_variavel[num].Valor = RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasValor[RT_geral.RT_820_360_BD.Setpoints_ctrl_variavel[num].Indice];
					RT_geral.RT_820_360_BD.Setpoints_ctrl_bloqueio[num].Indice = RT_geral.RT_820_360_BD.Setpoints_ctrl_bloqueio[num].Indice_padrao;
					RT_geral.RT_820_360_BD.Setpoints_ctrl_bloqueio[num].Valor = RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasValor[RT_geral.RT_820_360_BD.Setpoints_ctrl_bloqueio[num].Indice];
					num++;
				}
				while (num <= 8);
				num = 0;
				do
				{
					RT_geral.RT_820_360_BD.setpoint_horario[num].Hora.ValorPadrao();
					RT_geral.RT_820_360_BD.setpoint_horario[num].Minuto.ValorPadrao();
					RT_geral.RT_820_360_BD.setpoint_horario[num].Alto.ValorPadrao();
					RT_geral.RT_820_360_BD.setpoint_horario[num].Baixo.ValorPadrao();
					num++;
				}
				while (num <= 79);
				num = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_vazao[num].Indice = RT_geral.RT_820_360_BD.config_vazao[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_vazao[num].Valor = RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[RT_geral.RT_820_360_BD.config_vazao[num].Indice];
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					RT_geral.RT_820_360_BD.calha_EA[num].Indice = RT_geral.RT_820_360_BD.calha_EA[num].Indice_padrao;
					RT_geral.RT_820_360_BD.calha_EA[num].Valor = RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[RT_geral.RT_820_360_BD.calha_EA[num].Indice];
					RT_geral.RT_820_360_BD.calha_modelo[num].Indice = RT_geral.RT_820_360_BD.calha_modelo[num].Indice_padrao;
					RT_geral.RT_820_360_BD.calha_modelo[num].Valor = RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasValor[RT_geral.RT_820_360_BD.calha_modelo[num].Indice];
					RT_geral.RT_820_360_BD.calha_fundo[num].ValorPadrao();
					RT_geral.RT_820_360_BD.calha_p1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.calha_p2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.calha_p3[num].ValorPadrao();
					num++;
				}
				while (num <= 1);
				num = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_perifericos1_mod[num].Indice = RT_geral.RT_820_360_BD.config_perifericos1_mod[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_perifericos1_mod[num].Valor = RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[0].LinhasValor[RT_geral.RT_820_360_BD.config_perifericos1_mod[num].Indice];
					RT_geral.RT_820_360_BD.config_perifericos1_end[num].Valor = RT_geral.RT_820_360_BD.config_perifericos1_end[num].Padrao;
					num++;
				}
				while (num <= 5);
				num = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_perifericos2_mod[num].Indice = RT_geral.RT_820_360_BD.config_perifericos2_mod[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_perifericos2_mod[num].Valor = RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[0].LinhasValor[RT_geral.RT_820_360_BD.config_perifericos2_mod[num].Indice];
					RT_geral.RT_820_360_BD.config_perifericos2_end[num].Valor = RT_geral.RT_820_360_BD.config_perifericos2_end[num].Padrao;
					num++;
				}
				while (num <= 5);
				num = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_endcom[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num].Indice = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num].Valor = RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].LinhasValor[RT_geral.RT_820_360_BD.config_perifericos2_mod[num].Indice];
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var4[num].ValorPadrao();
					num++;
				}
				while (num <= 4);
				num = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_referencia_perif_periferico[num].Indice = RT_geral.RT_820_360_BD.config_referencia_perif_periferico[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_referencia_perif_periferico[num].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor[RT_geral.RT_820_360_BD.config_referencia_perif_periferico[num].Indice];
					RT_geral.RT_820_360_BD.config_referencia_perif_memoria[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[num].Indice = RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[num].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasValor[RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[num].Indice];
					RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[num].Indice = RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[num].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LinhasValor[RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[num].Indice];
					RT_geral.RT_820_360_BD.config_referencia_perif_escala[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_referencia_perif_base10[num].Indice = RT_geral.RT_820_360_BD.config_referencia_perif_base10[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_referencia_perif_base10[num].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor[RT_geral.RT_820_360_BD.config_referencia_perif_formato[num].Indice];
					RT_geral.RT_820_360_BD.config_referencia_perif_formato[num].Indice = RT_geral.RT_820_360_BD.config_referencia_perif_formato[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_referencia_perif_formato[num].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor[RT_geral.RT_820_360_BD.config_referencia_perif_formato[num].Indice];
					num++;
				}
				while (num <= 9);
				num = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_atuador1_perif[num].Indice = RT_geral.RT_820_360_BD.config_atuador1_perif[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador1_perif[num].Valor = RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasValor[RT_geral.RT_820_360_BD.config_atuador1_perif[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador2_perif[num].Indice = RT_geral.RT_820_360_BD.config_atuador2_perif[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador2_perif[num].Valor = RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasValor[RT_geral.RT_820_360_BD.config_atuador2_perif[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador3_perif[num].Indice = RT_geral.RT_820_360_BD.config_atuador3_perif[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador3_perif[num].Valor = RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasValor[RT_geral.RT_820_360_BD.config_atuador3_perif[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador3_perif[num].Indice = RT_geral.RT_820_360_BD.config_atuador3_perif[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador3_perif[num].Valor = RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasValor[RT_geral.RT_820_360_BD.config_atuador3_perif[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador4_perif[num].Indice = RT_geral.RT_820_360_BD.config_atuador4_perif[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador4_perif[num].Valor = RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasValor[RT_geral.RT_820_360_BD.config_atuador4_perif[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador1_mem[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_mem[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_mem[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_mem[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_var1[num].Indice = RT_geral.RT_820_360_BD.config_atuador1_var1[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador1_var1[num].Valor = RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].LinhasValor[RT_geral.RT_820_360_BD.config_atuador1_var1[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador2_var1[num].Indice = RT_geral.RT_820_360_BD.config_atuador2_var1[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador2_var1[num].Valor = RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].LinhasValor[RT_geral.RT_820_360_BD.config_atuador2_var1[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador3_var1[num].Indice = RT_geral.RT_820_360_BD.config_atuador3_var1[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador3_var1[num].Valor = RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].LinhasValor[RT_geral.RT_820_360_BD.config_atuador3_var1[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador4_var1[num].Indice = RT_geral.RT_820_360_BD.config_atuador4_var1[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador4_var1[num].Valor = RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].LinhasValor[RT_geral.RT_820_360_BD.config_atuador4_var1[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador1_escala1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_escala1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_escala1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_escala1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_var2[num].Indice = RT_geral.RT_820_360_BD.config_atuador1_var2[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador1_var2[num].Valor = RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].LinhasValor[RT_geral.RT_820_360_BD.config_atuador1_var2[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador2_var2[num].Indice = RT_geral.RT_820_360_BD.config_atuador2_var2[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador2_var2[num].Valor = RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].LinhasValor[RT_geral.RT_820_360_BD.config_atuador2_var2[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador3_var2[num].Indice = RT_geral.RT_820_360_BD.config_atuador3_var2[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador3_var2[num].Valor = RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].LinhasValor[RT_geral.RT_820_360_BD.config_atuador3_var2[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador4_var2[num].Indice = RT_geral.RT_820_360_BD.config_atuador4_var2[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador4_var2[num].Valor = RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].LinhasValor[RT_geral.RT_820_360_BD.config_atuador4_var2[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador1_escala2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_escala2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_escala2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_escala2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_histerese[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_histerese[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_histerese[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_histerese[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_formato[num].Indice = RT_geral.RT_820_360_BD.config_atuador1_formato[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador1_formato[num].Valor = RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasValor[RT_geral.RT_820_360_BD.config_atuador1_formato[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador2_formato[num].Indice = RT_geral.RT_820_360_BD.config_atuador2_formato[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador2_formato[num].Valor = RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasValor[RT_geral.RT_820_360_BD.config_atuador2_formato[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador3_formato[num].Indice = RT_geral.RT_820_360_BD.config_atuador3_formato[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador3_formato[num].Valor = RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasValor[RT_geral.RT_820_360_BD.config_atuador3_formato[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador4_formato[num].Indice = RT_geral.RT_820_360_BD.config_atuador4_formato[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador4_formato[num].Valor = RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasValor[RT_geral.RT_820_360_BD.config_atuador4_formato[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador1_base10[num].Indice = RT_geral.RT_820_360_BD.config_atuador1_base10[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador1_base10[num].Valor = RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasValor[RT_geral.RT_820_360_BD.config_atuador1_base10[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador2_base10[num].Indice = RT_geral.RT_820_360_BD.config_atuador2_base10[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador2_base10[num].Valor = RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasValor[RT_geral.RT_820_360_BD.config_atuador2_base10[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador3_base10[num].Indice = RT_geral.RT_820_360_BD.config_atuador3_base10[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador3_base10[num].Valor = RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasValor[RT_geral.RT_820_360_BD.config_atuador3_base10[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador4_base10[num].Indice = RT_geral.RT_820_360_BD.config_atuador4_base10[num].Indice_padrao;
					RT_geral.RT_820_360_BD.config_atuador4_base10[num].Valor = RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasValor[RT_geral.RT_820_360_BD.config_atuador4_base10[num].Indice];
					RT_geral.RT_820_360_BD.config_atuador1_v1baixo[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_v1baixo[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_v1baixo[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_v1baixo[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_v1alto[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_v1alto[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_v1alto[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_v1alto[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_v2baixo[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_v2baixo[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_v2baixo[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_v2baixo[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_v2alto[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_v2alto[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_v2alto[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_v2alto[num].ValorPadrao();
					num++;
				}
				while (num <= 0);
				num = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[num].ValorPadrao();
					num++;
				}
				while (num <= 2);
				num = 0;
				do
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[num].ValorPadrao();
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[num].ValorPadrao();
					num++;
				}
				while (num <= 3);
				RT_geral.RT_820_360_BD.modo_repetidora.IndicePadrao();
				RT_geral.RT_820_360_BD.End_repetidora.Valor = RT_geral.RT_820_360_BD.End_repetidora.Padrao;
				RT_geral.RT_820_360_BD.Num_repetidoras.Valor = RT_geral.RT_820_360_BD.Num_repetidoras.Padrao;
				num = 0;
				do
				{
					RT_geral.RT_820_360_BD.Repetidoras[num].Valor = RT_geral.RT_820_360_BD.Repetidoras[num].Padrao;
					num++;
				}
				while (num <= 50);
				int num2 = 0;
				do
				{
					int num3 = 0;
					do
					{
						RT_geral.RT_820_360_BD.Timer_Horario[num2][num3].Valor = RT_geral.RT_820_360_BD.Timer_Horario[num2][num3].Padrao;
						num3++;
					}
					while (num3 <= 11);
					num2++;
				}
				while (num2 <= 7);
			}
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x0034EA60 File Offset: 0x0034CE60
		public void Atualiza_TelaRT820()
		{
			checked
			{
				int num = 0;
				int num59 = 0;
				object obj = null;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					string text = "CFG Geral";
					this.TextBox_versao_820.Text = Conversions.ToString(RT_geral.RT_820_360_BD.Versao.Valor);
					this.TextBox_build_820.Text = Conversions.ToString(RT_geral.RT_820_360_BD.Build.Valor);
					this.TextBox_release_820.Text = Conversions.ToString(RT_geral.RT_820_360_BD.Release.Valor);
					this.TextBox_equipamento_820.Text = Conversions.ToString(RT_geral.RT_820_360_BD.Equip.Valor);
					this.NumericUpDown_end_mestre_820.Value = new decimal(RT_geral.RT_820_360_BD.End_mestre.Valor);
					this.NumericUpDown_end1_est_820.Value = new decimal(RT_geral.RT_820_360_BD.End_estacao1.Valor);
					this.NumericUpDown_end2_est_820.Value = new decimal(RT_geral.RT_820_360_BD.End_estacao2.Valor);
					this.NumericUpDown_temp_ptt_820.Value = new decimal(RT_geral.RT_820_360_BD.Tempo_ptt.Valor);
					this.nud_tempoforaar.Value = new decimal(RT_geral.RT_820_360_BD.TempoForaAr.Valor);
					this.ComboBox_baudrate_COM2_820.SelectedIndex = RT_geral.RT_820_360_BD.BaudRateCOM2.Indice;
					this.ComboBox_baudrate_COM1_820.SelectedIndex = RT_geral.RT_820_360_BD.BaudRateCOM1.Indice;
					if (RT_geral.RT_820_360_BD.HabExpIO.Valor == 21856)
					{
						this.CheckBox_hab_expansao_IO_820.Checked = false;
					}
					else
					{
						this.CheckBox_hab_expansao_IO_820.Checked = true;
					}
					text = "CFG Controle";
					int num2 = 0;
					do
					{
						string value = RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasMenu[RT_geral.RT_820_360_BD.ctrl_acionamento[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[0].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasMenu[RT_geral.RT_820_360_BD.ctrl_ret_acionamento[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[1].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasMenu[RT_geral.RT_820_360_BD.ctrl_desligamento[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[2].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasMenu[RT_geral.RT_820_360_BD.ctrl_ret_desligamento[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[3].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[4].LinhasMenu[RT_geral.RT_820_360_BD.ctrl_ED_selecao[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[4].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasMenu[RT_geral.RT_820_360_BD.ctrl_ED_bloqueio[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[5].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[6].LinhasMenu[RT_geral.RT_820_360_BD.ctrl_ED_liberacao[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[6].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[7].LinhasMenu[RT_geral.RT_820_360_BD.ctrl_reverso[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[7].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasMenu[RT_geral.RT_820_360_BD.ctrl_modo[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[8].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasMenu[RT_geral.RT_820_360_BD.ctrl_agrupamento[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[9].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[10].LinhasMenu[RT_geral.RT_820_360_BD.ctrl_partidas[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[10].Value = value;
						this.DataGridView_processo_820.Rows[num2].Cells[11].Value = RT_geral.RT_820_360_BD.ctrl_tempo_max_partida[num2].Valor;
						this.DataGridView_processo_820.Rows[num2].Cells[12].Value = RT_geral.RT_820_360_BD.ctrl_tempo_max_parada[num2].Valor;
						this.DataGridView_processo_820.Rows[num2].Cells[13].Value = RT_geral.RT_820_360_BD.ctrl_tempo_min_parado[num2].Valor;
						this.DataGridView_processo_820.Rows[num2].Cells[14].Value = RT_geral.RT_820_360_BD.ctrl_tempo_min_operando[num2].Valor;
						num2++;
					}
					while (num2 <= 7);
					num2 = 0;
					do
					{
						string value = RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasMenu[RT_geral.RT_820_360_BD.grupo_simultaneos[num2].Indice];
						this.DataGridView_grupos_820.Rows[num2].Cells[0].Value = value;
						this.DataGridView_grupos_820.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos[num2].Valor;
						value = RT_geral.RT_820_DataGrigViewGruposColunas[2].LinhasMenu[RT_geral.RT_820_360_BD.grupo_rotativo_motores[num2].Indice];
						this.DataGridView_grupos_820.Rows[num2].Cells[2].Value = value;
						num2++;
					}
					while (num2 <= 3);
					text = "CFG EA";
					num2 = 0;
					do
					{
						this.DataGridView_parametros_EA_820.Rows[num2].Cells[0].Value = RT_geral.RT_820_360_BD.EA_Range[num2].Valor;
						this.DataGridView_parametros_EA_820.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.EA_Inicio[num2].Valor;
						this.DataGridView_parametros_EA_820.Rows[num2].Cells[2].Value = RT_geral.RT_820_360_BD.EA_Fim[num2].Valor;
						num2++;
					}
					while (num2 <= 15);
					this.NumericUpDown_intervalo_filtro_820.Value = new decimal(RT_geral.RT_820_360_BD.AD_Intervalo.Valor);
					this.NumericUpDown_tamanho_filtro_820.Value = new decimal(RT_geral.RT_820_360_BD.AD_Tamanho_filtro.Valor);
					text = "CFG SA";
					this.cb_SA_1.SelectedIndex = RT_geral.RT_820_360_BD.saida_SA_origem[0].Indice;
					this.cb_SA_2.SelectedIndex = RT_geral.RT_820_360_BD.saida_SA_origem[1].Indice;
					this.nud_zero1.Value = new decimal(RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0].Valor);
					this.nud_zero2.Value = new decimal(RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[1].Valor);
					this.nud_ganho1.Value = new decimal(RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[0].Valor);
					this.nud_ganho2.Value = new decimal(RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[1].Valor);
					text = "CFG ED";
					if (RT_geral.RT_820_360_BD.HabExpIO.Valor == 21857)
					{
						num2 = 0;
						do
						{
							string value = RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[RT_geral.RT_820_360_BD.config_ED[num2].Indice];
							this.DataGridView_RT820_ED.Rows[num2].Cells[0].Value = value;
							num2++;
						}
						while (num2 <= 15);
					}
					else
					{
						num2 = 0;
						do
						{
							string value = RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[RT_geral.RT_820_360_BD.config_ED[num2].Indice];
							this.DataGridView_RT820_ED.Rows[num2].Cells[0].Value = value;
							num2++;
						}
						while (num2 <= 7);
					}
					text = "CFG SETPOINT";
					if (RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						this.ckb_tratamento_setpoint.Checked = true;
					}
					else
					{
						this.ckb_tratamento_setpoint.Checked = false;
					}
					num2 = 0;
					do
					{
						if (RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
						{
							this.DataGridView_setpoints_820.Rows[num2].Cells[2].Value = (double)RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[num2].Valor / 40.0;
							this.DataGridView_setpoints_820.Rows[num2].Cells[1].Value = (double)RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[num2].Valor / 40.0;
							this.DataGridView_setpoints_820.Rows[num2].Cells[4].Value = (double)RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[num2].Valor / 40.0;
							this.DataGridView_setpoints_820.Rows[num2].Cells[5].Value = (double)RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[num2].Valor / 40.0;
						}
						else
						{
							this.DataGridView_setpoints_820.Rows[num2].Cells[2].Value = RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[num2].Valor;
							this.DataGridView_setpoints_820.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[num2].Valor;
							this.DataGridView_setpoints_820.Rows[num2].Cells[4].Value = RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[num2].Valor;
							this.DataGridView_setpoints_820.Rows[num2].Cells[5].Value = RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[num2].Valor;
						}
						string value = RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasMenu[RT_geral.RT_820_360_BD.Setpoints_ctrl_variavel[num2].Indice];
						this.DataGridView_setpoints_820.Rows[num2].Cells[0].Value = value;
						value = RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasMenu[RT_geral.RT_820_360_BD.Setpoints_ctrl_bloqueio[num2].Indice];
						this.DataGridView_setpoints_820.Rows[num2].Cells[3].Value = value;
						num2++;
					}
					while (num2 <= 7);
					text = "CFG SETPOINT HORARIO";
					num2 = 0;
					do
					{
						bool flag = (RT_geral.RT_820_360_BD.setpoint_horario[num2].Hora.Valor & 128) > 0;
						this.dgv_sph.Rows[num2].Cells[1].Value = flag;
						int num3 = RT_geral.RT_820_360_BD.setpoint_horario[num2].Hora.Valor & 127;
						int num4 = RT_geral.RT_820_360_BD.setpoint_horario[num2].Minuto.Valor;
						int num5 = RT_geral.RT_820_360_BD.setpoint_horario[num2].Alto.Valor;
						int num6 = RT_geral.RT_820_360_BD.setpoint_horario[num2].Baixo.Valor;
						if (num3 > 23)
						{
							num3 = 23;
						}
						if (num4 > 59)
						{
							num4 = 59;
						}
						if (num5 > 4000)
						{
							num5 = 4000;
						}
						if (num6 > 4000)
						{
							num6 = 4000;
						}
						this.dgv_sph.Rows[num2].Cells[2].Value = num3;
						this.dgv_sph.Rows[num2].Cells[3].Value = num4;
						if (RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
						{
							this.dgv_sph.Rows[num2].Cells[4].Value = (double)num5 / 40.0;
							this.dgv_sph.Rows[num2].Cells[5].Value = (double)num6 / 40.0;
						}
						else
						{
							this.dgv_sph.Rows[num2].Cells[4].Value = num5;
							this.dgv_sph.Rows[num2].Cells[5].Value = num6;
						}
						num2++;
					}
					while (num2 <= 79);
					text = "CFG VAZOES";
					num2 = 0;
					do
					{
						string value = RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[RT_geral.RT_820_360_BD.config_vazao[num2].Indice];
						this.DataGridView_vazoes_RT820.Rows[num2].Cells[0].Value = value;
						num2++;
					}
					while (num2 <= 7);
					text = "CFG CALHAS";
					num2 = 0;
					do
					{
						string value = RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[RT_geral.RT_820_360_BD.calha_EA[num2].Indice];
						this.DataGridView_calhas_RT820.Rows[num2].Cells[0].Value = value;
						value = RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasMenu[RT_geral.RT_820_360_BD.calha_modelo[num2].Indice];
						this.DataGridView_calhas_RT820.Rows[num2].Cells[1].Value = value;
						this.DataGridView_calhas_RT820.Rows[num2].Cells[2].Value = RT_geral.RT_820_360_BD.calha_fundo[num2].Valor;
						this.DataGridView_calhas_RT820.Rows[num2].Cells[3].Value = RT_geral.RT_820_360_BD.calha_p1[num2].Valor;
						this.DataGridView_calhas_RT820.Rows[num2].Cells[4].Value = RT_geral.RT_820_360_BD.calha_p2[num2].Valor;
						this.DataGridView_calhas_RT820.Rows[num2].Cells[5].Value = RT_geral.RT_820_360_BD.calha_p3[num2].Valor;
						num2++;
					}
					while (num2 <= 1);
					text = "CFG PERIFERICO1";
					num2 = 0;
					do
					{
						string value = RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[0].LinhasMenu[RT_geral.RT_820_360_BD.config_perifericos1_mod[num2].Indice];
						this.DataGridView_periferico1_RT820.Rows[num2].Cells[0].Value = value;
						this.DataGridView_periferico1_RT820.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.config_perifericos1_end[num2].Valor;
						num2++;
					}
					while (num2 <= 4);
					text = "CFG PERIFERICO2";
					num2 = 0;
					do
					{
						string value = RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[0].LinhasMenu[RT_geral.RT_820_360_BD.config_perifericos2_mod[num2].Indice];
						this.DataGridView_periferico2_RT820.Rows[num2].Cells[0].Value = value;
						this.DataGridView_periferico2_RT820.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.config_perifericos2_end[num2].Valor;
						num2++;
					}
					while (num2 <= 4);
					text = "CFG PERIFERICO MODBUS GENERICO";
					num2 = 0;
					do
					{
						int valor = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_endcom[num2].Valor;
						this.DataGridView_perifericomodbusgenerico_RT820.Rows[num2].Cells[0].Value = valor;
						int indice = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num2].Indice;
						string value = RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].LinhasMenu[indice];
						this.DataGridView_perifericomodbusgenerico_RT820.Rows[num2].Cells[1].Value = value;
						this.DataGridView_perifericomodbusgenerico_RT820.Rows[num2].Cells[2].Value = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem1[num2].Valor;
						this.DataGridView_perifericomodbusgenerico_RT820.Rows[num2].Cells[4].Value = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem2[num2].Valor;
						this.DataGridView_perifericomodbusgenerico_RT820.Rows[num2].Cells[6].Value = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem3[num2].Valor;
						this.DataGridView_perifericomodbusgenerico_RT820.Rows[num2].Cells[8].Value = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem4[num2].Valor;
						this.DataGridView_perifericomodbusgenerico_RT820.Rows[num2].Cells[3].Value = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var1[num2].Valor;
						this.DataGridView_perifericomodbusgenerico_RT820.Rows[num2].Cells[5].Value = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var2[num2].Valor;
						this.DataGridView_perifericomodbusgenerico_RT820.Rows[num2].Cells[7].Value = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var3[num2].Valor;
						this.DataGridView_perifericomodbusgenerico_RT820.Rows[num2].Cells[9].Value = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var4[num2].Valor;
						num2++;
					}
					while (num2 <= 4);
					text = "CFG REF PERIFERICOS";
					num2 = 0;
					do
					{
						int num7 = 0;
						int num8 = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].NumeroLinhaMenu - 1;
						for (int i = num7; i <= num8; i++)
						{
							if (RT_geral.RT_820_360_BD.config_referencia_perif_periferico[num2].Valor == RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor[i])
							{
								RT_geral.RT_820_360_BD.config_referencia_perif_periferico[num2].Indice = i;
								break;
							}
						}
						string value = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu[RT_geral.RT_820_360_BD.config_referencia_perif_periferico[num2].Indice];
						this.datagridview_referenciaperifico.Rows[num2].Cells[0].Value = value;
						this.datagridview_referenciaperifico.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.config_referencia_perif_memoria[num2].Valor;
						int num9 = 0;
						int num10 = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].NumeroLinhaMenu - 1;
						for (int i = num9; i <= num10; i++)
						{
							if (RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[num2].Valor == RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasValor[i])
							{
								RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[num2].Indice = i;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasMenu[RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[num2].Indice];
						this.datagridview_referenciaperifico.Rows[num2].Cells[2].Value = value;
						int num11 = 0;
						int num12 = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].NumeroLinhaMenu - 1;
						for (int i = num11; i <= num12; i++)
						{
							if (RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[num2].Valor == RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LinhasValor[i])
							{
								RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[num2].Indice = i;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LinhasMenu[RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[num2].Indice];
						this.datagridview_referenciaperifico.Rows[num2].Cells[3].Value = value;
						this.datagridview_referenciaperifico.Rows[num2].Cells[4].Value = RT_geral.RT_820_360_BD.config_referencia_perif_escala[num2].Valor;
						int num13 = 0;
						int num14 = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].NumeroLinhaMenu - 1;
						for (int i = num13; i <= num14; i++)
						{
							if (RT_geral.RT_820_360_BD.config_referencia_perif_formato[num2].Valor == RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor[i])
							{
								RT_geral.RT_820_360_BD.config_referencia_perif_formato[num2].Indice = i;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasMenu[RT_geral.RT_820_360_BD.config_referencia_perif_formato[num2].Indice];
						this.datagridview_referenciaperifico.Rows[num2].Cells[5].Value = value;
						int num15 = 0;
						int num16 = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].NumeroLinhaMenu - 1;
						for (int i = num15; i <= num16; i++)
						{
							if (RT_geral.RT_820_360_BD.config_referencia_perif_base10[num2].Valor == RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasValor[i])
							{
								RT_geral.RT_820_360_BD.config_referencia_perif_base10[num2].Indice = i;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasMenu[RT_geral.RT_820_360_BD.config_referencia_perif_base10[num2].Indice];
						this.datagridview_referenciaperifico.Rows[num2].Cells[6].Value = value;
						num2++;
					}
					while (num2 <= 9);
					text = "CFG ATUADOR1";
					num2 = 0;
					do
					{
						RT_geral.RT_820_360_BD.config_atuador1_perif[0].Indice = -1;
						int num17 = 0;
						int num18 = RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].NumeroLinhaMenu - 1;
						for (int j = num17; j <= num18; j++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador1_perif[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasValor[j])
							{
								RT_geral.RT_820_360_BD.config_atuador1_perif[num2].Indice = j;
								break;
							}
						}
						if (RT_geral.RT_820_360_BD.config_atuador1_perif[0].Indice == -1)
						{
							RT_geral.RT_820_360_BD.config_atuador1_perif[0].Indice = RT_geral.RT_820_360_BD.config_atuador1_perif[0].Indice_padrao;
							RT_geral.RT_820_360_BD.config_atuador1_perif[0].Valor = RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasValor[RT_geral.RT_820_360_BD.config_atuador1_perif[0].Indice];
						}
						string value = RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador1_perif[0].Indice];
						this.dgv_atuador1.Rows[num2].Cells[0].Value = value;
						this.dgv_atuador1.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.config_atuador1_mem[num2].Valor;
						int num19 = 0;
						int num20 = RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].NumeroLinhaMenu - 1;
						for (int j = num19; j <= num20; j++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador1_var1[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].LinhasValor[j])
							{
								RT_geral.RT_820_360_BD.config_atuador1_var1[num2].Indice = j;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador1_var1[num2].Indice];
						this.dgv_atuador1.Rows[num2].Cells[2].Value = value;
						this.dgv_atuador1.Rows[num2].Cells[3].Value = RT_geral.RT_820_360_BD.config_atuador1_escala1[num2].Valor;
						int num21 = 0;
						int num22 = RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].NumeroLinhaMenu - 1;
						for (int j = num21; j <= num22; j++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador1_var2[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].LinhasValor[j])
							{
								RT_geral.RT_820_360_BD.config_atuador1_var2[num2].Indice = j;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador1_var2[num2].Indice];
						this.dgv_atuador1.Rows[num2].Cells[4].Value = value;
						this.dgv_atuador1.Rows[num2].Cells[5].Value = RT_geral.RT_820_360_BD.config_atuador1_escala2[num2].Valor;
						this.dgv_atuador1.Rows[num2].Cells[6].Value = RT_geral.RT_820_360_BD.config_atuador1_histerese[num2].Valor;
						int num23 = 0;
						int num24 = RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].NumeroLinhaMenu - 1;
						for (int j = num23; j <= num24; j++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador1_formato[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasValor[j])
							{
								RT_geral.RT_820_360_BD.config_atuador1_formato[num2].Indice = j;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador1_formato[num2].Indice];
						this.dgv_atuador1.Rows[num2].Cells[7].Value = value;
						int num25 = 0;
						int num26 = RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].NumeroLinhaMenu - 1;
						for (int j = num25; j <= num26; j++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador1_base10[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasValor[j])
							{
								RT_geral.RT_820_360_BD.config_atuador1_base10[num2].Indice = j;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador1_base10[num2].Indice];
						this.dgv_atuador1.Rows[num2].Cells[8].Value = value;
						this.dgv_atuador1.Rows[num2].Cells[9].Value = RT_geral.RT_820_360_BD.config_atuador1_v1baixo[num2].Valor;
						this.dgv_atuador1.Rows[num2].Cells[10].Value = RT_geral.RT_820_360_BD.config_atuador1_v1alto[num2].Valor;
						this.dgv_atuador1.Rows[num2].Cells[11].Value = RT_geral.RT_820_360_BD.config_atuador1_v2baixo[num2].Valor;
						this.dgv_atuador1.Rows[num2].Cells[12].Value = RT_geral.RT_820_360_BD.config_atuador1_v2alto[num2].Valor;
						num2++;
					}
					while (num2 <= 0);
					text = "CFG ATUADOR1 VARIAVEL1";
					num2 = 0;
					do
					{
						this.dgv_atuador_setpoint1.Rows[num2].Cells[0].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[2].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[4].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[6].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[8].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[10].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[12].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[3].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[5].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[7].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[9].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[11].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[13].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					text = "CFG ATUADOR1 VARIAVEL2";
					num2 = 0;
					do
					{
						this.dgv_atuador_setpoint11.Rows[num2].Cells[0].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[2].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[4].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[6].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[8].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[10].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[3].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[5].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[7].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[9].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[11].Value = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					text = "CFG ATUADOR2";
					num2 = 0;
					do
					{
						RT_geral.RT_820_360_BD.config_atuador2_perif[num2].Indice = -1;
						int num27 = 0;
						int num28 = RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].NumeroLinhaMenu - 1;
						for (int k = num27; k <= num28; k++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador2_perif[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasValor[k])
							{
								RT_geral.RT_820_360_BD.config_atuador2_perif[num2].Indice = k;
								break;
							}
						}
						if (RT_geral.RT_820_360_BD.config_atuador2_perif[0].Indice == -1)
						{
							RT_geral.RT_820_360_BD.config_atuador2_perif[0].Indice = RT_geral.RT_820_360_BD.config_atuador2_perif[0].Indice_padrao;
							RT_geral.RT_820_360_BD.config_atuador2_perif[0].Valor = RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasValor[RT_geral.RT_820_360_BD.config_atuador2_perif[0].Indice];
						}
						string value = RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador2_perif[num2].Indice];
						this.dgv_atuador2.Rows[num2].Cells[0].Value = value;
						this.dgv_atuador2.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.config_atuador2_mem[num2].Valor;
						int num29 = 0;
						int num30 = RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].NumeroLinhaMenu - 1;
						for (int k = num29; k <= num30; k++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador2_var1[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].LinhasValor[k])
							{
								RT_geral.RT_820_360_BD.config_atuador2_var1[num2].Indice = k;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador2_var1[num2].Indice];
						this.dgv_atuador2.Rows[num2].Cells[2].Value = value;
						this.dgv_atuador2.Rows[num2].Cells[3].Value = RT_geral.RT_820_360_BD.config_atuador2_escala1[num2].Valor;
						int num31 = 0;
						int num32 = RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].NumeroLinhaMenu - 1;
						for (int k = num31; k <= num32; k++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador2_var2[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].LinhasValor[k])
							{
								RT_geral.RT_820_360_BD.config_atuador2_var2[num2].Indice = k;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador2_var2[num2].Indice];
						this.dgv_atuador2.Rows[num2].Cells[4].Value = value;
						this.dgv_atuador2.Rows[num2].Cells[5].Value = RT_geral.RT_820_360_BD.config_atuador2_escala2[num2].Valor;
						this.dgv_atuador2.Rows[num2].Cells[6].Value = RT_geral.RT_820_360_BD.config_atuador2_histerese[num2].Valor;
						int num33 = 0;
						int num34 = RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].NumeroLinhaMenu - 1;
						for (int k = num33; k <= num34; k++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador2_formato[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasValor[k])
							{
								RT_geral.RT_820_360_BD.config_atuador2_formato[num2].Indice = k;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador2_formato[num2].Indice];
						this.dgv_atuador2.Rows[num2].Cells[7].Value = value;
						int num35 = 0;
						int num36 = RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].NumeroLinhaMenu - 1;
						for (int k = num35; k <= num36; k++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador2_base10[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasValor[k])
							{
								RT_geral.RT_820_360_BD.config_atuador2_base10[num2].Indice = k;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador2_base10[num2].Indice];
						this.dgv_atuador2.Rows[num2].Cells[8].Value = value;
						this.dgv_atuador2.Rows[num2].Cells[9].Value = RT_geral.RT_820_360_BD.config_atuador2_v1baixo[num2].Valor;
						this.dgv_atuador2.Rows[num2].Cells[10].Value = RT_geral.RT_820_360_BD.config_atuador2_v1alto[num2].Valor;
						this.dgv_atuador2.Rows[num2].Cells[11].Value = RT_geral.RT_820_360_BD.config_atuador2_v2baixo[num2].Valor;
						this.dgv_atuador2.Rows[num2].Cells[12].Value = RT_geral.RT_820_360_BD.config_atuador2_v2alto[num2].Valor;
						num2++;
					}
					while (num2 <= 0);
					text = "CFG ATUADOR2 VARIAVEL1";
					num2 = 0;
					do
					{
						this.dgv_atuador_setpoint2.Rows[num2].Cells[0].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[2].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[4].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[6].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[8].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[10].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[12].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[3].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[5].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[7].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[9].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[11].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[13].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					text = "CFG ATUADOR2 VARIAVEL2";
					num2 = 0;
					do
					{
						this.dgv_atuador_setpoint21.Rows[num2].Cells[0].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[2].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[4].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[6].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[8].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[10].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[3].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[5].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[7].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[9].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[11].Value = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					text = "CFG ATUADOR3";
					num2 = 0;
					do
					{
						RT_geral.RT_820_360_BD.config_atuador3_perif[0].Indice = -1;
						int num37 = 0;
						int num38 = RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].NumeroLinhaMenu - 1;
						for (int l = num37; l <= num38; l++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador3_perif[0].Valor == RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasValor[l])
							{
								RT_geral.RT_820_360_BD.config_atuador3_perif[0].Indice = l;
								break;
							}
						}
						if (RT_geral.RT_820_360_BD.config_atuador3_perif[0].Indice == -1)
						{
							RT_geral.RT_820_360_BD.config_atuador3_perif[0].Indice = RT_geral.RT_820_360_BD.config_atuador3_perif[0].Indice_padrao;
							RT_geral.RT_820_360_BD.config_atuador3_perif[0].Valor = RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasValor[RT_geral.RT_820_360_BD.config_atuador3_perif[0].Indice];
						}
						string value = RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador3_perif[0].Indice];
						this.dgv_atuador3.Rows[num2].Cells[0].Value = value;
						this.dgv_atuador3.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.config_atuador3_mem[num2].Valor;
						int num39 = 0;
						int num40 = RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].NumeroLinhaMenu - 1;
						for (int l = num39; l <= num40; l++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador3_var1[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].LinhasValor[l])
							{
								RT_geral.RT_820_360_BD.config_atuador3_var1[num2].Indice = l;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador3_var1[num2].Indice];
						this.dgv_atuador3.Rows[num2].Cells[2].Value = value;
						this.dgv_atuador3.Rows[num2].Cells[3].Value = RT_geral.RT_820_360_BD.config_atuador3_escala1[num2].Valor;
						int num41 = 0;
						int num42 = RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].NumeroLinhaMenu - 1;
						for (int l = num41; l <= num42; l++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador3_var2[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].LinhasValor[l])
							{
								RT_geral.RT_820_360_BD.config_atuador3_var2[num2].Indice = l;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador3_var2[num2].Indice];
						this.dgv_atuador3.Rows[num2].Cells[4].Value = value;
						this.dgv_atuador3.Rows[num2].Cells[5].Value = RT_geral.RT_820_360_BD.config_atuador3_escala2[num2].Valor;
						this.dgv_atuador3.Rows[num2].Cells[6].Value = RT_geral.RT_820_360_BD.config_atuador3_histerese[num2].Valor;
						int num43 = 0;
						int num44 = RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].NumeroLinhaMenu - 1;
						for (int l = num43; l <= num44; l++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador3_formato[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasValor[l])
							{
								RT_geral.RT_820_360_BD.config_atuador3_formato[num2].Indice = l;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador3_formato[num2].Indice];
						this.dgv_atuador3.Rows[num2].Cells[7].Value = value;
						int num45 = 0;
						int num46 = RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].NumeroLinhaMenu - 1;
						for (int l = num45; l <= num46; l++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador3_base10[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasValor[l])
							{
								RT_geral.RT_820_360_BD.config_atuador3_base10[num2].Indice = l;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador3_base10[num2].Indice];
						this.dgv_atuador3.Rows[num2].Cells[8].Value = value;
						this.dgv_atuador3.Rows[num2].Cells[9].Value = RT_geral.RT_820_360_BD.config_atuador3_v1baixo[num2].Valor;
						this.dgv_atuador3.Rows[num2].Cells[10].Value = RT_geral.RT_820_360_BD.config_atuador3_v1alto[num2].Valor;
						this.dgv_atuador3.Rows[num2].Cells[11].Value = RT_geral.RT_820_360_BD.config_atuador3_v2baixo[num2].Valor;
						this.dgv_atuador3.Rows[num2].Cells[12].Value = RT_geral.RT_820_360_BD.config_atuador3_v2alto[num2].Valor;
						num2++;
					}
					while (num2 <= 0);
					text = "CFG ATUADOR3 VARIAVEL1";
					num2 = 0;
					do
					{
						this.dgv_atuador_setpoint3.Rows[num2].Cells[0].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[2].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[4].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[6].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[8].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[10].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[12].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[3].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[5].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[7].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[9].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[11].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[13].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					text = "CFG ATUADOR3 VARIAVEL2";
					num2 = 0;
					do
					{
						this.dgv_atuador_setpoint31.Rows[num2].Cells[0].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[2].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[4].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[6].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[8].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[10].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[3].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[5].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[7].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[9].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[11].Value = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					text = "CFG ATUADOR4";
					num2 = 0;
					do
					{
						RT_geral.RT_820_360_BD.config_atuador4_perif[num2].Indice = -1;
						int num47 = 0;
						int num48 = RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].NumeroLinhaMenu - 1;
						for (int m = num47; m <= num48; m++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador4_perif[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasValor[m])
							{
								RT_geral.RT_820_360_BD.config_atuador4_perif[num2].Indice = m;
								break;
							}
						}
						if (RT_geral.RT_820_360_BD.config_atuador4_perif[0].Indice == -1)
						{
							RT_geral.RT_820_360_BD.config_atuador4_perif[0].Indice = RT_geral.RT_820_360_BD.config_atuador4_perif[0].Indice_padrao;
							RT_geral.RT_820_360_BD.config_atuador4_perif[0].Valor = RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasValor[RT_geral.RT_820_360_BD.config_atuador4_perif[0].Indice];
						}
						string value = RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador4_perif[num2].Indice];
						this.dgv_atuador4.Rows[num2].Cells[0].Value = value;
						this.dgv_atuador4.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.config_atuador4_mem[num2].Valor;
						int num49 = 0;
						int num50 = RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].NumeroLinhaMenu - 1;
						for (int m = num49; m <= num50; m++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador4_var1[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].LinhasValor[m])
							{
								RT_geral.RT_820_360_BD.config_atuador4_var1[num2].Indice = m;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador4_var1[num2].Indice];
						this.dgv_atuador4.Rows[num2].Cells[2].Value = value;
						this.dgv_atuador4.Rows[num2].Cells[3].Value = RT_geral.RT_820_360_BD.config_atuador4_escala1[num2].Valor;
						int num51 = 0;
						int num52 = RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].NumeroLinhaMenu - 1;
						for (int m = num51; m <= num52; m++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador4_var2[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].LinhasValor[m])
							{
								RT_geral.RT_820_360_BD.config_atuador4_var2[num2].Indice = m;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador4_var2[num2].Indice];
						this.dgv_atuador4.Rows[num2].Cells[4].Value = value;
						this.dgv_atuador4.Rows[num2].Cells[5].Value = RT_geral.RT_820_360_BD.config_atuador4_escala2[num2].Valor;
						this.dgv_atuador4.Rows[num2].Cells[6].Value = RT_geral.RT_820_360_BD.config_atuador4_histerese[num2].Valor;
						int num53 = 0;
						int num54 = RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].NumeroLinhaMenu - 1;
						for (int m = num53; m <= num54; m++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador4_formato[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasValor[m])
							{
								RT_geral.RT_820_360_BD.config_atuador4_formato[num2].Indice = m;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador4_formato[num2].Indice];
						this.dgv_atuador4.Rows[num2].Cells[7].Value = value;
						int num55 = 0;
						int num56 = RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].NumeroLinhaMenu - 1;
						for (int m = num55; m <= num56; m++)
						{
							if (RT_geral.RT_820_360_BD.config_atuador4_base10[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasValor[m])
							{
								RT_geral.RT_820_360_BD.config_atuador4_base10[num2].Indice = m;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador4_base10[num2].Indice];
						this.dgv_atuador4.Rows[num2].Cells[8].Value = value;
						this.dgv_atuador4.Rows[num2].Cells[9].Value = RT_geral.RT_820_360_BD.config_atuador4_v1baixo[num2].Valor;
						this.dgv_atuador4.Rows[num2].Cells[10].Value = RT_geral.RT_820_360_BD.config_atuador4_v1alto[num2].Valor;
						this.dgv_atuador4.Rows[num2].Cells[11].Value = RT_geral.RT_820_360_BD.config_atuador4_v2baixo[num2].Valor;
						this.dgv_atuador4.Rows[num2].Cells[12].Value = RT_geral.RT_820_360_BD.config_atuador4_v2alto[num2].Valor;
						num2++;
					}
					while (num2 <= 0);
					text = "CFG ATUADOR4 VARIAVEL1";
					num2 = 0;
					do
					{
						this.dgv_atuador_setpoint4.Rows[num2].Cells[0].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[2].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[4].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[6].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[8].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[10].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[12].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[3].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[5].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[7].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[9].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[11].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[13].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					text = "CFG ATUADOR4 VARIAVEL2";
					num2 = 0;
					do
					{
						this.dgv_atuador_setpoint41.Rows[num2].Cells[0].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[2].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[4].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[6].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[8].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[10].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[3].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[5].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[7].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[9].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[11].Value = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					text = "CFG REPETIDORA";
					RT_geral.RT_820_360_BD.modo_repetidora.AtualizaIndicePeloValor();
					this.cb_ModoRepetidora.SelectedIndex = RT_geral.RT_820_360_BD.modo_repetidora.Indice;
					this.NumericUpDown_end_rep_820.Value = new decimal(RT_geral.RT_820_360_BD.End_repetidora.Valor);
					this.NumericUpDown_num_est_rep_820.Value = new decimal(RT_geral.RT_820_360_BD.Num_repetidoras.Valor);
					num2 = 0;
					do
					{
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[1].Value = RT_geral.RT_820_360_BD.Repetidoras[num2].Valor;
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[3].Value = RT_geral.RT_820_360_BD.Repetidoras[num2 + 10].Valor;
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[5].Value = RT_geral.RT_820_360_BD.Repetidoras[num2 + 20].Valor;
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[7].Value = RT_geral.RT_820_360_BD.Repetidoras[num2 + 30].Valor;
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[9].Value = RT_geral.RT_820_360_BD.Repetidoras[num2 + 40].Valor;
						num2++;
					}
					while (num2 <= 9);
					text = "CFG TIMER";
					int num57 = 0;
					do
					{
						int num58 = 0;
						do
						{
							int num3 = RT_geral.RT_820_360_BD.Timer_Horario[num57][num58].Valor / 60;
							int num4 = RT_geral.RT_820_360_BD.Timer_Horario[num57][num58].Valor % 60;
							this.DataGridView_timer_RT820.Rows[num57].Cells[num58].Value = Strings.Format(num3, "#0") + ":" + Strings.Format(num4, "#0");
							num58++;
						}
						while (num58 <= 11);
						num57++;
					}
					while (num57 <= 7);
					goto IL_4DE1;
					IL_4D88:
					MessageBox.Show("Erro na Atualização de Tela:" + text);
					goto IL_4DE1;
					IL_4D9C:
					num59 = -1;
										IL_4DB2:;
				}
				catch (Exception) { }
				IL_4DE1:
				if (num59 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00353874 File Offset: 0x00351C74
		public void Habilita_Funcoes_de_Tela_RT_820(int tipo)
		{
			this.GroupBox_comunicacao_820.Enabled = true;
			this.GroupBox_informacoes_820.Enabled = false;
			this.GroupBox_parametros_interface_820.Enabled = false;
			this.GroupBox_controle_820.Enabled = false;
			this.GroupBox_Agrupamento_820.Enabled = false;
			this.DataGridView_processo_820.Visible = false;
			this.DataGridView_grupos_820.Visible = false;
			this.GroupBox_parametros_EA_820.Enabled = false;
			this.GroupBox_EA_820.Enabled = false;
			this.DataGridView_parametros_EA_820.Visible = false;
			this.GroupBox_ED_820.Enabled = false;
			this.GroupBox_setpoints_820.Enabled = false;
			this.DataGridView_setpoints_820.Visible = false;
			this.GroupBox_perifericos_820.Enabled = false;
			this.GroupBox_vazoes_820.Enabled = false;
			this.DataGridView_periferico1_RT820.Visible = false;
			this.GroupBox_parametros_repetidora_820.Enabled = false;
			this.GroupBox_end_rep_820.Enabled = false;
			this.DataGridView_end_rep_RT820.Visible = false;
			switch (tipo)
			{
			case 0:
				this.GroupBox_informacoes_820.Enabled = true;
				this.GroupBox_parametros_interface_820.Enabled = true;
				this.GroupBox_controle_820.Enabled = true;
				this.GroupBox_Agrupamento_820.Enabled = true;
				this.DataGridView_processo_820.Visible = true;
				this.DataGridView_grupos_820.Visible = true;
				this.GroupBox_parametros_EA_820.Enabled = true;
				this.GroupBox_EA_820.Enabled = true;
				this.DataGridView_parametros_EA_820.Visible = true;
				this.GroupBox_ED_820.Enabled = true;
				this.GroupBox_setpoints_820.Enabled = true;
				this.DataGridView_setpoints_820.Visible = true;
				this.GroupBox_perifericos_820.Enabled = true;
				this.GroupBox_vazoes_820.Enabled = true;
				this.DataGridView_periferico1_RT820.Visible = true;
				this.GroupBox_parametros_repetidora_820.Enabled = true;
				this.GroupBox_end_rep_820.Enabled = true;
				this.DataGridView_end_rep_RT820.Visible = true;
				break;
			}
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00353A58 File Offset: 0x00351E58
		private void Habilita_objetos_rep(int valor)
		{
			switch (valor)
			{
			case 0:
				this.Label_end_rep_820.Enabled = true;
				this.Label_num_est_rep_820.Enabled = true;
				this.NumericUpDown_end_rep_820.Enabled = true;
				this.NumericUpDown_num_est_rep_820.Enabled = true;
				this.GroupBox_end_rep_820.Enabled = true;
				this.DataGridView_end_rep_RT820.Visible = true;
				break;
			case 1:
			case 2:
				this.Label_end_rep_820.Enabled = false;
				this.Label_num_est_rep_820.Enabled = false;
				this.NumericUpDown_end_rep_820.Enabled = false;
				this.NumericUpDown_num_est_rep_820.Enabled = false;
				this.GroupBox_end_rep_820.Enabled = false;
				this.DataGridView_end_rep_RT820.Visible = false;
				break;
			}
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00353B10 File Offset: 0x00351F10
		public void AtualizaMsgTela_RT_820(string texto, int cor)
		{
			this.ToolStripTextBox_RT_820_Msg.Text = texto;
			if (cor == 0)
			{
				this.ToolStripTextBox_RT_820_Msg.ForeColor = Color.Blue;
			}
			else if (cor == 1)
			{
				this.ToolStripProgressBar_RT_820.Value = 0;
				this.ToolStripTextBox_RT_820_Msg.ForeColor = Color.Red;
			}
			else
			{
				this.ToolStripTextBox_RT_820_Msg.ForeColor = Color.Black;
			}
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00353B74 File Offset: 0x00351F74
		public void InicializaBarraProgressoTela_RT_820(int num_passos)
		{
			this.ToolStripProgressBar_RT_820.Minimum = 0;
			this.ToolStripProgressBar_RT_820.Maximum = 100;
			this.ToolStripProgressBar_RT_820.Step = checked((int)Math.Round(unchecked(100.0 / (double)num_passos + 1.0)));
			this.ToolStripProgressBar_RT_820.Value = 0;
			this.ToolStripProgressBar_RT_820.BackColor = Color.LightGray;
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00353BE0 File Offset: 0x00351FE0
		private void Timer_limpa_MSG_820_Tick(object sender, EventArgs e)
		{
			this.Timer_limpa_MSG_820.Enabled = false;
			this.AtualizaMsgTela_RT_820("", 0);
			this.ToolStripProgressBar_RT_820.Value = 0;
			this.ToolStripButton_RT_820_Upload.Enabled = true;
			this.ToolStripButton_RT_820_Download.Enabled = true;
			this.ToolStripButton_RT_820_Abrir.Enabled = true;
			this.ToolStripButton_RT_820_novo.Enabled = true;
			this.ToolStripButton_RT_820_Salvar.Enabled = true;
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00353C50 File Offset: 0x00352050
		private void NumericUpDown_end_rep_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.End_repetidora.Valor = 0;
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_360_BD.End_repetidora, true);
			sender = numericUpDown;
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00353CA4 File Offset: 0x003520A4
		private void NumericUpDown_num_est_rep_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.Num_repetidoras.Valor = 0;
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_360_BD.Num_repetidoras, true);
			sender = numericUpDown;
			int num = 0;
			int num2 = 0;
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
						this.DataGridView_end_rep_RT820.Rows[i].Cells[1].ReadOnly = false;
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
						this.DataGridView_end_rep_RT820.Rows[i - 10].Cells[3].ReadOnly = false;
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
						this.DataGridView_end_rep_RT820.Rows[i - 20].Cells[5].ReadOnly = false;
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
						this.DataGridView_end_rep_RT820.Rows[i - 30].Cells[7].ReadOnly = false;
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
						this.DataGridView_end_rep_RT820.Rows[i - 40].Cells[9].ReadOnly = false;
						break;
					}
				}
				for (int i = 0; i <= 49; i++)
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
						this.DataGridView_end_rep_RT820.Rows[i].Cells[1].ReadOnly = true;
						this.DataGridView_end_rep_RT820.Rows[i].Cells[1].Value = 0;
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
						this.DataGridView_end_rep_RT820.Rows[i - 10].Cells[3].ReadOnly = true;
						this.DataGridView_end_rep_RT820.Rows[i - 10].Cells[3].Value = 0;
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
						this.DataGridView_end_rep_RT820.Rows[i - 20].Cells[5].ReadOnly = true;
						this.DataGridView_end_rep_RT820.Rows[i - 20].Cells[5].Value = 0;
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
						this.DataGridView_end_rep_RT820.Rows[i - 30].Cells[7].ReadOnly = true;
						this.DataGridView_end_rep_RT820.Rows[i - 30].Cells[7].Value = 0;
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
						this.DataGridView_end_rep_RT820.Rows[i - 40].Cells[9].ReadOnly = true;
						this.DataGridView_end_rep_RT820.Rows[i - 40].Cells[9].Value = 0;
						break;
					}
				}
			}
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00354150 File Offset: 0x00352550
		private void NumericUpDown_intervalo_filtro_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.AD_Intervalo.Valor = 0;
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_360_BD.AD_Intervalo, true);
			sender = numericUpDown;
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x003541A4 File Offset: 0x003525A4
		private void NumericUpDown_tamanho_filtro_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.AD_Tamanho_filtro.Valor = 0;
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_360_BD.AD_Tamanho_filtro, true);
			sender = numericUpDown;
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x003541F8 File Offset: 0x003525F8
		public void CarregaComboBoxModoRepetidora(ref ComboBox dado)
		{
			dado.Items.Clear();
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_820_360_BD.modo_repetidora.Numero_itens - 1;
				for (int i = num; i <= num2; i++)
				{
					dado.Items.Add(RT_geral.RT_820_360_BD.modo_repetidora.itens[i]);
				}
			}
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00354250 File Offset: 0x00352650
		public void CarregaComboBoxSaidaAnalogica(ref ComboBox dado)
		{
			dado.Items.Clear();
			int num = 0;
			checked
			{
				int num2 = perifericos.Lista_SA_Origem_RT820_400.Count - 1;
				for (int i = num; i <= num2; i++)
				{
					dado.Items.Add(perifericos.Lista_SA_Origem_RT820_400[i].nome);
				}
			}
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x003542A0 File Offset: 0x003526A0
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
				List<perifericos.Valores_ComboBox>.Enumerator enumerator = default(List<perifericos.Valores_ComboBox>.Enumerator);
				enumerator.Dispose();
			}
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x0035430C File Offset: 0x0035270C
		private void CarregaComboBoxVazao(ref ComboBox dado, int expIO)
		{
			dado.Items.Clear();
			dado.Items.Add("Leitura Desabilitada");
			int num = 1;
			checked
			{
				do
				{
					dado.Items.Add("Leitura Vazão EA " + Strings.Format(num, "0#"));
					num++;
				}
				while (num <= 16);
				num = 1;
				do
				{
					dado.Items.Add("Leitura Vazão ED " + Strings.Format(num, "0#"));
					dado.Items.Add("Leitura Vazão ED " + Strings.Format(num, "0#") + " reverso");
					num++;
				}
				while (num <= 8);
				if (expIO == 21857)
				{
					num = 9;
					do
					{
						dado.Items.Add("Leitura Vazão ED " + Strings.Format(num, "0#"));
						dado.Items.Add("Leitura Vazão ED " + Strings.Format(num, "0#") + " reverso");
						num++;
					}
					while (num <= 16);
				}
			}
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00354430 File Offset: 0x00352830
		private void ComboBox_modo_simulado_820_SelectedIndexChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00354434 File Offset: 0x00352834
		private void NumericUpDown_end_mestre_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.End_mestre.Valor = 0;
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_360_BD.End_mestre, true);
			sender = numericUpDown;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00354488 File Offset: 0x00352888
		private void NumericUpDown_end_est_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.End_estacao1.Valor = 0;
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_360_BD.End_estacao1, true);
			sender = numericUpDown;
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x003544DC File Offset: 0x003528DC
		private void NumericUpDown_temp_ptt_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.Tempo_ptt.Valor = Conversions.ToInteger(Operators.MultiplyObject(Operators.IntDivideObject(((NumericUpDown)sender).Value, 10), 10));
						NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_360_BD.Tempo_ptt, true);
			sender = numericUpDown;
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00354574 File Offset: 0x00352974
		private void ComboBox_baudrate_COM2_820_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.BaudRateCOM2.Indice = 0;
			RT_geral.RT_820_360_BD.BaudRateCOM2.Valor = RT_geral.RT_820_360_BD.BaudRateCOM2.valores[RT_geral.RT_820_360_BD.BaudRateCOM2.Indice];
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x003545D8 File Offset: 0x003529D8
		private void CheckBox_hab_expansao_IO_820_CheckedChanged(object sender, EventArgs e)
		{
			this.Atualiza_Expansao_IO_820_360(Conversions.ToBoolean(null));
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x003545FC File Offset: 0x003529FC
		public void Atualiza_Expansao_IO_820_360(bool @checked)
		{
			checked
			{
				if (@checked)
				{
					RT_geral.RT_820_360_BD.HabExpIO.Valor = 21857;
					this.DataGridView_RT820_ED.Height = 376;
					this.GroupBox_ED_820.Height = 417;
				}
				else
				{
					RT_geral.RT_820_360_BD.HabExpIO.Valor = 21856;
					this.DataGridView_RT820_ED.Height = 200;
					this.GroupBox_ED_820.Height = 241;
					int num = 8;
					do
					{
						RT_geral.RT_820_360_BD.config_ED[num].Valor = RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[0];
						RT_geral.RT_820_360_BD.config_ED[num].Indice = 0;
						num++;
					}
					while (num <= 15);
				}
				if (!this.bloqueio_IO)
				{
					int num = 0;
					do
					{
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_360_BD.ctrl_acionamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[0], "SD", RT_geral.RT_820_360_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_360_BD.ctrl_desligamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[2], "SD", RT_geral.RT_820_360_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_360_BD.ctrl_ret_acionamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[1], "ED", RT_geral.RT_820_360_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_360_BD.ctrl_ret_desligamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[3], "ED", RT_geral.RT_820_360_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_360_BD.ctrl_ED_selecao[num], RT_geral.RT_820_DataGrigViewProcessosColunas[4], "ED", RT_geral.RT_820_360_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_360_BD.ctrl_ED_liberacao[num], RT_geral.RT_820_DataGrigViewProcessosColunas[6], "ED", RT_geral.RT_820_360_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_360_BD.ctrl_ED_bloqueio[num], RT_geral.RT_820_DataGrigViewProcessosColunas[5], "ED", RT_geral.RT_820_360_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_360_BD.config_vazao[num], RT_geral.RT_820_DataGrigViewVazoesColunas[0], "VZ", RT_geral.RT_820_360_BD.HabExpIO.Valor);
						num++;
					}
					while (num <= 7);
				}
				this.InicializaEstrutura_DataGridView_Processos();
				this.GeraDataGridView_Processos();
				this.InicializaEstrutura_DataGridView_Vazoes();
				this.GeraDataGridView_Vazoes();
				this.InicializaEstrutura_DataGridView_ED();
				this.GeraDataGridView_ED();
				this.Atualiza_TelaRT820();
			}
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x003548C8 File Offset: 0x00352CC8
		private void DataGridView_processo_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_processo_820.Columns[e.ColumnIndex].DataPropertyName;
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
													if (Operators.CompareString(dataPropertyName, "Col_GrupoPartida", false) != 0)
													{
														if (Operators.CompareString(dataPropertyName, "Col_TpMaxPart", false) == 0)
														{
															this.DataGridView_processo_820.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[11].Value));
															RT_geral.RT_820_360_BD.ctrl_tempo_max_partida[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[11].Value);
															return;
														}
														if (Operators.CompareString(dataPropertyName, "Col_TpMaxParada", false) == 0)
														{
															this.DataGridView_processo_820.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[12].Value));
															RT_geral.RT_820_360_BD.ctrl_tempo_max_parada[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[11].Value);
															return;
														}
														if (Operators.CompareString(dataPropertyName, "Col_TpMinParado", false) == 0)
														{
															this.DataGridView_processo_820.Rows[e.RowIndex].Cells[13].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[13].Value));
															RT_geral.RT_820_360_BD.ctrl_tempo_min_parado[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[13].Value);
															return;
														}
														if (Operators.CompareString(dataPropertyName, "Col_TpMinOperan", false) == 0)
														{
															this.DataGridView_processo_820.Rows[e.RowIndex].Cells[14].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[14].Value));
															RT_geral.RT_820_360_BD.ctrl_tempo_min_operando[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[14].Value);
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
			string text = Conversions.ToString(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
				int i = num;
				while (i <= num2)
				{
					if (Operators.CompareString(RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
					{
						string dataPropertyName2 = this.DataGridView_processo_820.Columns[e.ColumnIndex].DataPropertyName;
						if (Operators.CompareString(dataPropertyName2, "Col_GrupoPartida", false) == 0)
						{
							RT_geral.RT_820_360_BD.ctrl_partidas[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_360_BD.ctrl_partidas[e.RowIndex].Indice = i;
							break;
						}
						if (Operators.CompareString(dataPropertyName2, "Col_SDAciona", false) == 0)
						{
							bool flag = RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_820_360_BD.ctrl_acionamento[e.RowIndex], ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], 8, ref RT_geral.RT_820_360_BD.ctrl_desligamento, text, "Acionamento", "Desacionamento");
							bool flag2 = RT_geral.VerificaEDJaUtilizada_MesmaColuna(8, i, e.RowIndex, ref RT_geral.RT_820_360_BD.ctrl_acionamento, ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], text);
							if (flag || flag2)
							{
								this.DataGridView_processo_820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_820_360_BD.ctrl_acionamento[e.RowIndex].Indice_padrao];
								break;
							}
							RT_geral.RT_820_360_BD.ctrl_acionamento[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_360_BD.ctrl_acionamento[e.RowIndex].Indice = i;
							break;
						}
						else if (Operators.CompareString(dataPropertyName2, "Col_EDRetAci", false) == 0)
						{
							if (RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_820_360_BD.ctrl_ret_acionamento[e.RowIndex], ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], 8, ref RT_geral.RT_820_360_BD.ctrl_ret_desligamento, text, "Ret Acionamento", "Ret Desligamento") | RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_820_360_BD.ctrl_ret_acionamento[e.RowIndex], ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], 8, ref RT_geral.RT_820_360_BD.ctrl_ED_selecao, text, "Ret Acionamento", "ED Seleção") | RT_geral.VerificaEDJaUtilizada_FuncoesEspeciais(i, RT_geral.RT_820_360_BD.config_ED, text) | RT_geral.VerificaEDJaUtilizada_MesmaColuna(8, i, e.RowIndex, ref RT_geral.RT_820_360_BD.ctrl_ret_acionamento, ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], text))
							{
								this.DataGridView_processo_820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_820_360_BD.ctrl_ret_acionamento[e.RowIndex].Indice_padrao];
								break;
							}
							RT_geral.RT_820_360_BD.ctrl_ret_acionamento[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_360_BD.ctrl_ret_acionamento[e.RowIndex].Indice = i;
							break;
						}
						else if (Operators.CompareString(dataPropertyName2, "Col_SDDesaci", false) == 0)
						{
							if (RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_820_360_BD.ctrl_desligamento[e.RowIndex], ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], 8, ref RT_geral.RT_820_360_BD.ctrl_acionamento, text, "Desacionamento", "Acionamento") | RT_geral.VerificaEDJaUtilizada_MesmaColuna(8, i, e.RowIndex, ref RT_geral.RT_820_360_BD.ctrl_desligamento, ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], text))
							{
								this.DataGridView_processo_820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_820_360_BD.ctrl_desligamento[e.RowIndex].Indice_padrao];
								break;
							}
							RT_geral.RT_820_360_BD.ctrl_desligamento[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_360_BD.ctrl_desligamento[e.RowIndex].Indice = i;
							break;
						}
						else if (Operators.CompareString(dataPropertyName2, "Col_EDRetDes", false) == 0)
						{
							if (RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_820_360_BD.ctrl_ret_desligamento[e.RowIndex], ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], 8, ref RT_geral.RT_820_360_BD.ctrl_ret_acionamento, text, "Ret Desligamento", "Ret Acionamento") | RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_820_360_BD.ctrl_ret_desligamento[e.RowIndex], ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], 8, ref RT_geral.RT_820_360_BD.ctrl_ED_selecao, text, "Ret Desligamento", "ED Seleção") | RT_geral.VerificaEDJaUtilizada_FuncoesEspeciais(i, RT_geral.RT_820_360_BD.config_ED, text) | RT_geral.VerificaEDJaUtilizada_MesmaColuna(8, i, e.RowIndex, ref RT_geral.RT_820_360_BD.ctrl_ret_desligamento, ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], text))
							{
								this.DataGridView_processo_820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_820_360_BD.ctrl_ret_desligamento[e.RowIndex].Indice_padrao];
								break;
							}
							RT_geral.RT_820_360_BD.ctrl_ret_desligamento[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_360_BD.ctrl_ret_desligamento[e.RowIndex].Indice = i;
							break;
						}
						else if (Operators.CompareString(dataPropertyName2, "Col_EDRemoto", false) == 0)
						{
							if (RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_820_360_BD.ctrl_ED_selecao[e.RowIndex], ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], 8, ref RT_geral.RT_820_360_BD.ctrl_ret_desligamento, text, "ED Seleção", "Ret Desligamento") | RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_820_360_BD.ctrl_ED_selecao[e.RowIndex], ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], 8, ref RT_geral.RT_820_360_BD.ctrl_ret_acionamento, text, "ED Seleção", "Ret Acionamento") | RT_geral.VerificaEDJaUtilizada_FuncoesEspeciais(i, RT_geral.RT_820_360_BD.config_ED, text) | RT_geral.VerificaEDJaUtilizada_MesmaColuna(8, i, e.RowIndex, ref RT_geral.RT_820_360_BD.ctrl_ED_selecao, ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], text))
							{
								this.DataGridView_processo_820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_820_360_BD.ctrl_ED_selecao[e.RowIndex].Indice_padrao];
								break;
							}
							RT_geral.RT_820_360_BD.ctrl_ED_selecao[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_360_BD.ctrl_ED_selecao[e.RowIndex].Indice = i;
							break;
						}
						else
						{
							if (Operators.CompareString(dataPropertyName2, "Col_EDBloqueio", false) == 0)
							{
								RT_geral.RT_820_360_BD.ctrl_ED_bloqueio[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_360_BD.ctrl_ED_bloqueio[e.RowIndex].Indice = i;
								break;
							}
							if (Operators.CompareString(dataPropertyName2, "Col_EDLiberar", false) == 0)
							{
								RT_geral.RT_820_360_BD.ctrl_ED_liberacao[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_360_BD.ctrl_ED_liberacao[e.RowIndex].Indice = i;
								break;
							}
							if (Operators.CompareString(dataPropertyName2, "Col_Reverso", false) == 0)
							{
								RT_geral.RT_820_360_BD.ctrl_reverso[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_360_BD.ctrl_reverso[e.RowIndex].Indice = i;
								break;
							}
							if (Operators.CompareString(dataPropertyName2, "Col_ModoCtrl", false) == 0)
							{
								RT_geral.RT_820_360_BD.ctrl_modo[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_360_BD.ctrl_modo[e.RowIndex].Indice = i;
								break;
							}
							if (Operators.CompareString(dataPropertyName2, "Col_GrupoCtrl", false) == 0)
							{
								RT_geral.RT_820_360_BD.ctrl_agrupamento[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_360_BD.ctrl_agrupamento[e.RowIndex].Indice = i;
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

		// Token: 0x06001605 RID: 5637 RVA: 0x00355690 File Offset: 0x00353A90
		private void DataGridView_processo_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_processo_820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_TpMaxPart", false) == 0)
				{
					RT_geral.RT_820_360_BD.ctrl_tempo_max_partida[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.ctrl_tempo_max_partida[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_TpMaxParada", false) == 0)
				{
					RT_geral.RT_820_360_BD.ctrl_tempo_max_parada[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.ctrl_tempo_max_parada[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_TpMinParado", false) == 0)
				{
					RT_geral.RT_820_360_BD.ctrl_tempo_min_parado[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.ctrl_tempo_min_parado[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_TpMinOperan", false) == 0)
				{
					RT_geral.RT_820_360_BD.ctrl_tempo_min_operando[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.ctrl_tempo_min_operando[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00355868 File Offset: 0x00353C68
		private void DataGridView_processo_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_processo_820.IsCurrentCellDirty)
			{
				this.DataGridView_processo_820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00355888 File Offset: 0x00353C88
		private void DataGridView_grupos_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			if (e.RowIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_grupos_820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_ASimultaneos", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_grupos_820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_820_DataGrigViewGruposColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					int i = num;
					while (i <= num2)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewGruposColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							string dataPropertyName2 = this.DataGridView_grupos_820.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName2, "Col_ASimultaneos", false) == 0)
							{
								RT_geral.RT_820_360_BD.grupo_simultaneos[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewGruposColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_360_BD.grupo_simultaneos[e.RowIndex].Indice = i;
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
					this.DataGridView_grupos_820.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_grupos_820.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_grupos_820.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_RotMot", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_grupos_820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num3 = 0;
					int num4 = RT_geral.RT_820_DataGrigViewGruposColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					int i = num3;
					while (i <= num4)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewGruposColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							string dataPropertyName3 = this.DataGridView_grupos_820.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName3, "Col_RotMot", false) == 0)
							{
								RT_geral.RT_820_360_BD.grupo_rotativo_motores[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewGruposColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_360_BD.grupo_rotativo_motores[e.RowIndex].Indice = i;
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

		// Token: 0x06001608 RID: 5640 RVA: 0x00355BA0 File Offset: 0x00353FA0
		private void DataGridView_grupos_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_grupos_820.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_TpAcionamentos", false) == 0)
			{
				RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos[e.RowIndex].Valor = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue))));
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos[e.RowIndex], e, true);
				sender = dataGridView;
			}
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00355C34 File Offset: 0x00354034
		private void DataGridView_grupos_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_grupos_820.IsCurrentCellDirty)
			{
				this.DataGridView_grupos_820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00355C54 File Offset: 0x00354054
		private void DataGridView_parametros_EA_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_parametros_EA_820.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_range", false) == 0)
			{
				this.DataGridView_parametros_EA_820.Rows[e.RowIndex].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_parametros_EA_820.Rows[e.RowIndex].Cells[0].Value));
				RT_geral.RT_820_360_BD.EA_Range[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_parametros_EA_820.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(dataPropertyName, "Col_ini", false) == 0)
			{
				this.DataGridView_parametros_EA_820.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_parametros_EA_820.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_360_BD.EA_Inicio[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_parametros_EA_820.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(dataPropertyName, "Col_fim", false) == 0)
			{
				this.DataGridView_parametros_EA_820.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_parametros_EA_820.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_360_BD.EA_Fim[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_parametros_EA_820.Rows[e.RowIndex].Cells[2].Value);
			}
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00355EA8 File Offset: 0x003542A8
		private void DataGridView_parametros_EA_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_parametros_EA_820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_range", false) == 0)
				{
					RT_geral.RT_820_360_BD.EA_Range[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.EA_Range[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_ini", false) == 0)
				{
					RT_geral.RT_820_360_BD.EA_Inicio[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.EA_Inicio[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_fim", false) == 0)
				{
					RT_geral.RT_820_360_BD.EA_Fim[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.EA_Fim[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00356010 File Offset: 0x00354410
		private void DataGridView_parametros_EA_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_parametros_EA_820.IsCurrentCellDirty)
			{
				this.DataGridView_parametros_EA_820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00356030 File Offset: 0x00354430
		private void DataGridView_setpoints_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_setpoints_820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_Set_Controle", false) == 0 || Operators.CompareString(dataPropertyName, "Col_Set_Bloqueio", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_820_DataGrigViewSetpointsColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					int i = num;
					while (i <= num2)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewSetpointsColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							string dataPropertyName2 = this.DataGridView_setpoints_820.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName2, "Col_Set_Controle", false) == 0)
							{
								RT_geral.RT_820_360_BD.Setpoints_ctrl_variavel[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewSetpointsColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_360_BD.Setpoints_ctrl_variavel[e.RowIndex].Indice = i;
								break;
							}
							if (Operators.CompareString(dataPropertyName2, "Col_Set_Bloqueio", false) == 0)
							{
								RT_geral.RT_820_360_BD.Setpoints_ctrl_bloqueio[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewSetpointsColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_360_BD.Setpoints_ctrl_bloqueio[e.RowIndex].Indice = i;
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
					this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[2].Value));
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[2].Value);
					if (RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[e.RowIndex].Valor = RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[e.RowIndex].Valor * 40;
					}
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NBaixo", false) == 0)
				{
					this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[1].Value);
					if (RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex].Valor = RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex].Valor * 40;
					}
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NBloq", false) == 0)
				{
					this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[4].Value));
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[4].Value);
					if (RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[e.RowIndex].Valor = RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[e.RowIndex].Valor * 40;
					}
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NLib", false) == 0)
				{
					this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[5].Value);
					if (RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[e.RowIndex].Valor = RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[e.RowIndex].Valor * 40;
					}
				}
			}
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x003565F0 File Offset: 0x003549F0
		private void DataGridView_setpoints_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_setpoints_820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_Set_NAlto", false) == 0)
				{
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					if (RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[e.RowIndex].Valor = RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[e.RowIndex].Valor * 40;
					}
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NBaixo", false) == 0)
				{
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					if (RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex].Valor = RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex].Valor * 40;
					}
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NBloq", false) == 0)
				{
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					if (RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[e.RowIndex].Valor = RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[e.RowIndex].Valor * 40;
					}
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NLib", false) == 0)
				{
					RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					if (RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[e.RowIndex].Valor = RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[e.RowIndex].Valor * 40;
					}
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x003568F8 File Offset: 0x00354CF8
		private void DataGridView_setpoints_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_setpoints_820.IsCurrentCellDirty)
			{
				this.DataGridView_setpoints_820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00356918 File Offset: 0x00354D18
		private void DataGridView_periferico_RT820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_periferico1_RT820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_modelo", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_periferico1_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					for (int i = num; i <= num2; i++)
					{
						if (Operators.CompareString(RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							RT_geral.RT_820_360_BD.config_perifericos1_mod[e.RowIndex].Valor = RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_360_BD.config_perifericos1_mod[e.RowIndex].Indice = i;
							break;
						}
					}
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end", false) == 0)
				{
					this.DataGridView_periferico1_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_periferico1_RT820.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_360_BD.config_perifericos1_end[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_periferico1_RT820.Rows[e.RowIndex].Cells[1].Value);
				}
			}
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00356AE0 File Offset: 0x00354EE0
		private void DataGridView_periferico_RT820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_periferico1_RT820.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_end", false) == 0)
			{
				RT_geral.RT_820_360_BD.config_perifericos1_end[e.RowIndex].Valor = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue))));
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_perifericos1_end[e.RowIndex], e, true);
				sender = dataGridView;
			}
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00356B74 File Offset: 0x00354F74
		private void DataGridView_periferico_RT820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_periferico1_RT820.IsCurrentCellDirty)
			{
				this.DataGridView_periferico1_RT820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00356B94 File Offset: 0x00354F94
		private void DataGridView_vazoes_RT820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_vazoes_RT820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_Entrada", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_vazoes_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_820_DataGrigViewVazoesColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					int i = num;
					while (i <= num2)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewVazoesColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							string dataPropertyName2 = this.DataGridView_vazoes_RT820.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName2, "Col_Entrada", false) == 0)
							{
								RT_geral.RT_820_360_BD.config_vazao[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewVazoesColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_360_BD.config_vazao[e.RowIndex].Indice = i;
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

		// Token: 0x06001614 RID: 5652 RVA: 0x00356CD0 File Offset: 0x003550D0
		private void DataGridView_vazoes_RT820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00356CD4 File Offset: 0x003550D4
		private void DataGridView_vazoes_RT820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_vazoes_RT820.IsCurrentCellDirty)
			{
				this.DataGridView_vazoes_RT820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00356CF4 File Offset: 0x003550F4
		private void DataGridView_RT820_ED_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_RT820_ED.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_Entrada", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_RT820_ED.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_820_DataGrigViewEDColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					int i = num;
					while (i <= num2)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewEDColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							string dataPropertyName2 = this.DataGridView_RT820_ED.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName2, "Col_Entrada", false) == 0)
							{
								if (!RT_geral.VerificaFuncaoJaUtilizada(i, e.RowIndex, RT_geral.RT_820_360_BD.config_ED, RT_geral.RT_820_360_BD.HabExpIO.Valor) & !RT_geral.VerificaEDdaFuncaoJaUtilizada(e.RowIndex + 1, i, 8, ref RT_geral.RT_820_360_BD.ctrl_ret_desligamento) & !RT_geral.VerificaEDdaFuncaoJaUtilizada(e.RowIndex + 1, i, 8, ref RT_geral.RT_820_360_BD.ctrl_ED_selecao) & !RT_geral.VerificaEDdaFuncaoJaUtilizada(e.RowIndex + 1, i, 8, ref RT_geral.RT_820_360_BD.ctrl_ret_acionamento))
								{
									RT_geral.RT_820_360_BD.config_ED[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewEDColunas[e.ColumnIndex].LinhasValor[i];
									RT_geral.RT_820_360_BD.config_ED[e.RowIndex].Indice = i;
								}
								else
								{
									this.DataGridView_RT820_ED.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_820_DataGrigViewEDColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_820_360_BD.config_ED[e.RowIndex].Indice_padrao];
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

		// Token: 0x06001617 RID: 5655 RVA: 0x00356F14 File Offset: 0x00355314
		private void DataGridView_RT820_ED_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_RT820_ED.IsCurrentCellDirty)
			{
				this.DataGridView_RT820_ED.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00356F34 File Offset: 0x00355334
		private void DataGridView_end_rep_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_end_rep_RT820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_end_1", false) == 0)
				{
					RT_geral.RT_820_360_BD.Repetidoras[0 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.Repetidoras[0 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_2", false) == 0)
				{
					RT_geral.RT_820_360_BD.Repetidoras[10 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.Repetidoras[10 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_3", false) == 0)
				{
					RT_geral.RT_820_360_BD.Repetidoras[20 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.Repetidoras[20 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_4", false) == 0)
				{
					RT_geral.RT_820_360_BD.Repetidoras[30 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.Repetidoras[30 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_5", false) == 0)
				{
					RT_geral.RT_820_360_BD.Repetidoras[40 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.Repetidoras[40 + e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00357194 File Offset: 0x00355594
		private void DataGridView_end_rep_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			string dataPropertyName = this.DataGridView_end_rep_RT820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_end_1", false) == 0)
				{
					int num = 0;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_360_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_2", false) == 0)
				{
					int num = 10;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_820_360_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[3].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_3", false) == 0)
				{
					int num = 20;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_820_360_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[5].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_4", false) == 0)
				{
					int num = 30;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[7].Value));
					RT_geral.RT_820_360_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[7].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_5", false) == 0)
				{
					int num = 40;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[9].Value));
					RT_geral.RT_820_360_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[9].Value);
				}
			}
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00357568 File Offset: 0x00355968
		private void DataGridView_end_rep_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_end_rep_RT820.IsCurrentCellDirty)
			{
				this.DataGridView_end_rep_RT820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00357588 File Offset: 0x00355988
		private void DataGridView_timer_RT820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_timer_RT820.IsCurrentCellDirty)
			{
				this.DataGridView_timer_RT820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x003575A8 File Offset: 0x003559A8
		private void DataGridView_timer_RT820_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			checked
			{
				if (Operators.ConditionalCompareObjectNotEqual(e.Value, null, false))
				{
					string text = e.Value.ToString();
					int length = text.Length;
					int num = text.IndexOf(":");
					if (length > 5 | num < 1)
					{
						e.Value = "00:00";
					}
					else
					{
						int num2 = (int)Math.Round(Conversion.Val(text.Substring(0, num)));
						int num3 = 0;
						if (num2 < 24)
						{
							if (length - num > 1)
							{
								num3 = (int)Math.Round(Conversion.Val(text.Substring(num + 1)));
								if (num3 > 59)
								{
									num3 = 0;
								}
							}
							else
							{
								num3 = 0;
							}
							e.Value = Strings.Format(num2, "0#") + ":" + Strings.Format(num3, "0#");
						}
						else
						{
							e.Value = "00:00";
							num3 = 0;
						}
						num3 = num2 * 60 + num3;
					}
				}
			}
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00357690 File Offset: 0x00355A90
		private void DataGridView_timer_RT820_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_timer_RT820.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_Liga_F1", false) != 0)
			{
				if (Operators.CompareString(dataPropertyName, "Col_Desliga_F1", false) != 0)
				{
					if (Operators.CompareString(dataPropertyName, "Col_Liga_F2", false) != 0)
					{
						if (Operators.CompareString(dataPropertyName, "Col_Desliga_F2", false) != 0)
						{
							if (Operators.CompareString(dataPropertyName, "Col_Liga_F3", false) != 0)
							{
								if (Operators.CompareString(dataPropertyName, "Col_Desliga_F3", false) != 0)
								{
									if (Operators.CompareString(dataPropertyName, "Col_Liga_F4", false) != 0)
									{
										if (Operators.CompareString(dataPropertyName, "Col_Desliga_F4", false) != 0)
										{
											if (Operators.CompareString(dataPropertyName, "Col_Liga_F5", false) != 0)
											{
												if (Operators.CompareString(dataPropertyName, "Col_Desliga_F5", false) != 0)
												{
													if (Operators.CompareString(dataPropertyName, "Col_Liga_F6", false) != 0)
													{
														if (Operators.CompareString(dataPropertyName, "Col_Desliga_F6", false) != 0)
														{
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
			string text = Conversions.ToString(this.DataGridView_timer_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			int length = text.Length;
			int num = text.IndexOf(":");
			int num2 = 0;
			int num3 = 0;
			checked
			{
				if (num > 0)
				{
					num2 = (int)Math.Round(Conversion.Val(text.Substring(0, num)));
					if (length - (num + 1) > 0)
					{
						num3 = (int)Math.Round(Conversion.Val(text.Substring(num + 1)));
					}
				}
				if (num2 > 23 | num2 < 0)
				{
					num2 = 0;
				}
				if (num3 > 59 | num3 < 0)
				{
					num3 = 0;
				}
				num3 += num2 * 60;
				RT_geral.RT_820_360_BD.Timer_Horario[e.RowIndex][e.ColumnIndex].Valor = num3;
			}
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00357870 File Offset: 0x00355C70
		private void ToolStripButton_RT_820_Abrir_Click(object sender, EventArgs e)
		{
			checked
			{
				int num = 0;
				int num8 = 0;
				object obj = null;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					this.AtivaEfeitoOnChangeValue();
					this.ToolStripButton_RT_820_Abrir.Enabled = false;
					this.ToolStripButton_RT_820_novo.Enabled = false;
					this.ToolStripButton_RT_820_Salvar.Enabled = false;
					this.ToolStripButton_RT_820_Download.Enabled = false;
					this.ToolStripButton_RT_820_Upload.Enabled = false;
					this.OpenFileDialog_RT_820.Filter = "Arquivo de configuração de equipamento|*.Cfg820_400";
					this.OpenFileDialog_RT_820.InitialDirectory = Linha_RT.diretorio;
					if (this.OpenFileDialog_RT_820.ShowDialog() == DialogResult.OK)
					{
						if (Operators.CompareString(this.OpenFileDialog_RT_820.FileName, "", false) != 0)
						{
							Linha_RT.diretorio = Path.GetDirectoryName(this.OpenFileDialog_RT_820.FileName) + "\\";
							RT_geral.arquivo_extensao = Path.GetExtension(this.OpenFileDialog_RT_820.FileName);
							IniFile iniFile = new IniFile(this.OpenFileDialog_RT_820.FileName);
							RT_geral.RT_820_360_BD.filename = this.OpenFileDialog_RT_820.FileName;
							RT_geral.RT_820_360_BD.Equip.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "EQUIPAMENTO", RT_geral.RT_820_360_BD.Equip.Valor);
							RT_geral.RT_820_360_BD.Versao.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "VERSAO", RT_geral.RT_820_360_BD.Versao.Valor);
							RT_geral.RT_820_360_BD.Build.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "BUILD", RT_geral.RT_820_360_BD.Build.Valor);
							RT_geral.RT_820_360_BD.Release.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "RELEASE", RT_geral.RT_820_360_BD.Release.Valor);
							if (!Linha_RT.VerificaSeEquipamentoEValido(1, RT_geral.RT_820_360_BD.Equip.Valor, RT_geral.RT_820_360_BD.Versao.Valor, RT_geral.RT_820_360_BD.Build.Valor, RT_geral.RT_820_360_BD.Release.Valor, RT_geral.arquivo_extensao).Status)
							{
								RT_geral.Lmte_Init_ok = false;
								this.Inicializa_DadosEStruturaRT820_Padrao();
								this.Inicializa_DadosEStruturaRT820_Default();
								Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
								this.Atualiza_TelaRT820();
								RT_geral.Lmte_Init_ok = true;
								this.AtualizaMsgTela_RT_820("Valores Default carregados", 0);
								this.Timer_limpa_MSG_820.Enabled = true;
							}
							else
							{
								this.bloqueio_IO = true;
								RT_geral.RT_820_360_BD.End_estacao1.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "ESTACAO1", 0);
								RT_geral.RT_820_360_BD.End_estacao2.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "ESTACAO2", 0);
								RT_geral.RT_820_360_BD.End_mestre.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "MESTRE", 0);
								RT_geral.RT_820_360_BD.Tempo_ptt.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "TEMPO_PTT", 0);
								RT_geral.RT_820_360_BD.BaudRateCOM1.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "BAUDRATE_COM1", Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate)));
								if (!perifericos.Lista_ValorPermitido(RT_geral.RT_820_360_BD.BaudRateCOM1.Valor, perifericos.ListaBaudRate))
								{
									RT_geral.RT_820_360_BD.BaudRateCOM1.Valor = Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate));
								}
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_360_BD.BaudRateCOM1, RT_geral.RT_820_360_BD.BaudRateCOM1.Valor);
								RT_geral.RT_820_360_BD.BaudRateCOM2.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "BAUDRATE_COM2", Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate)));
								if (!perifericos.Lista_ValorPermitido(RT_geral.RT_820_360_BD.BaudRateCOM2.Valor, perifericos.ListaBaudRate))
								{
									RT_geral.RT_820_360_BD.BaudRateCOM2.Valor = Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate));
								}
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_360_BD.BaudRateCOM2, RT_geral.RT_820_360_BD.BaudRateCOM2.Valor);
								RT_geral.RT_820_360_BD.TempoForaAr.Valor = iniFile.ReadInteger("GERAL_DIVERSOS", "TEMPO_FORA_AR", 0);
								RT_geral.RT_820_360_BD.HabExpIO.Valor = iniFile.ReadInteger("GERAL_DIVERSOS", "HAB_EXPANSAO_IO", 0);
								if (RT_geral.RT_820_360_BD.HabExpIO.Valor == 21857)
								{
									this.Atualiza_Expansao_IO_820_360(true);
								}
								else
								{
									this.Atualiza_Expansao_IO_820_360(false);
								}
								RT_geral.RT_820_360_BD.modo_repetidora.Valor = iniFile.ReadInteger("REPETIDORA", "MODO_REPETIDORA", 0);
								RT_geral.RT_820_360_BD.AD_Intervalo.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "INTERVALO", 0);
								RT_geral.RT_820_360_BD.AD_Tamanho_filtro.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "TAMANHO_FILTRO", 0);
								this.InicializaEStruturasVariaveis_RT820();
								int num2 = 0;
								string text;
								do
								{
									text = string.Format("ENTRADA_ANALOGICA_{0}", num2 + 1);
									RT_geral.RT_820_360_BD.EA_Range[num2].Valor = iniFile.ReadInteger(text, "EA_RANGE", 0);
									RT_geral.RT_820_360_BD.EA_Inicio[num2].Valor = iniFile.ReadInteger(text, "EA_INICIO", 0);
									RT_geral.RT_820_360_BD.EA_Fim[num2].Valor = iniFile.ReadInteger(text, "EA_FIM", 0);
									num2++;
								}
								while (num2 <= 15);
								num2 = 0;
								do
								{
									text = string.Format("SAIDA_ANALOGICA_{0}", num2 + 1);
									RT_geral.RT_820_360_BD.saida_SA_origem[num2].Valor = iniFile.ReadInteger(text, "SA_ORIGEM", RT_geral.RT_820_360_BD.saida_SA_origem[num2].valores[RT_geral.RT_820_360_BD.saida_SA_origem[num2].Indice_padrao]);
									RT_geral.RT_820_360_BD.saida_SA_origem[num2].AtualizaIndicePeloValor();
									RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[num2].Valor = iniFile.ReadInteger(text, "SA_INICIO", RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[num2].Padrao);
									RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[num2].Valor = iniFile.ReadInteger(text, "SA_INICIO", RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[num2].Padrao);
									num2++;
								}
								while (num2 <= 1);
								num2 = 0;
								do
								{
									text = string.Format("CFG_CONTROLE_{0}", num2 + 1);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_acionamento[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[0], iniFile.ReadInteger(text, "ACIONAMENTO", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_desligamento[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[2], iniFile.ReadInteger(text, "DESLIGAMENTO", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_ret_acionamento[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[1], iniFile.ReadInteger(text, "RET_ACIONAMENTO", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_ret_desligamento[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[3], iniFile.ReadInteger(text, "RET_DESLIGAMENTO", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_ED_selecao[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[4], iniFile.ReadInteger(text, "SELECAO_REMOTO", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_ED_bloqueio[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[5], iniFile.ReadInteger(text, "BLOQUEIO_DIGITAL", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_ED_liberacao[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[6], iniFile.ReadInteger(text, "LIBERACAO_DIGITAL", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_reverso[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[7], iniFile.ReadInteger(text, "SELECAO_REVERSO", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_modo[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[8], iniFile.ReadInteger(text, "MODO_CONTROLE", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_agrupamento[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[9], iniFile.ReadInteger(text, "GRUPO_CONTROLE", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.ctrl_partidas[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[10], iniFile.ReadInteger(text, "GRUPO_PARTIDA", 0));
									num2++;
								}
								while (num2 <= 7);
								num2 = 0;
								do
								{
									text = string.Format("GRUPO_CONTROLE_{0}", num2 + 1);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.grupo_simultaneos[num2], RT_geral.RT_820_DataGrigViewGruposColunas[0], iniFile.ReadInteger(text, "ACIONAMENTO_PERMITIDO", 0));
									RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos[num2].Valor = iniFile.ReadInteger(text, "TEMPO_ENTRE_ACIONAMENTO", 0);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.grupo_rotativo_motores[num2], RT_geral.RT_820_DataGrigViewGruposColunas[2], iniFile.ReadInteger(text, "ROTATIVO_MOTORES", 21856));
									num2++;
								}
								while (num2 <= 3);
								num2 = 0;
								do
								{
									text = string.Format("CFG_CONTROLE_{0}", num2 + 1);
									RT_geral.RT_820_360_BD.ctrl_tempo_max_partida[num2].Valor = iniFile.ReadInteger(text, "TEMPO_MAX_PARTIDA", 0);
									RT_geral.RT_820_360_BD.ctrl_tempo_max_parada[num2].Valor = iniFile.ReadInteger(text, "TEMPO_MAX_PARADA", 0);
									RT_geral.RT_820_360_BD.ctrl_tempo_min_parado[num2].Valor = iniFile.ReadInteger(text, "TEMPO_MIN_PARADO", 0);
									RT_geral.RT_820_360_BD.ctrl_tempo_min_operando[num2].Valor = iniFile.ReadInteger(text, "TEMPO_MIN_OPERANDO", 0);
									num2++;
								}
								while (num2 <= 7);
								num2 = 0;
								do
								{
									text = string.Format("CFG{0}_ED", num2 + 1);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.config_ED[num2], RT_geral.RT_820_DataGrigViewEDColunas[0], iniFile.ReadInteger("ENTRADA_DIGITAL", text, 0));
									num2++;
								}
								while (num2 <= 15);
								num2 = 0;
								do
								{
									text = string.Format("V{0}", num2 + 1);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.config_vazao[num2], RT_geral.RT_820_DataGrigViewVazoesColunas[0], iniFile.ReadInteger("VAZAO", text, 0));
									num2++;
								}
								while (num2 <= 7);
								num2 = 0;
								do
								{
									string section = string.Format("CALHA_{0}", num2 + 1);
									int num3 = iniFile.ReadInteger(section, "EA", 21856);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.calha_EA[num2], RT_geral.RT_820_DatagridViewCalhasColunas[0], num3);
									num3 = iniFile.ReadInteger(section, "MODELO", 0);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.calha_modelo[num2], RT_geral.RT_820_DatagridViewCalhasColunas[1], num3);
									RT_geral.RT_820_360_BD.calha_fundo[num2].Valor = iniFile.ReadInteger(section, "FUNDO", 0);
									RT_geral.RT_820_360_BD.calha_p1[num2].Valor = iniFile.ReadInteger(section, "P1", 0);
									RT_geral.RT_820_360_BD.calha_p2[num2].Valor = iniFile.ReadInteger(section, "P2", 0);
									RT_geral.RT_820_360_BD.calha_p3[num2].Valor = iniFile.ReadInteger(section, "P3", 0);
									num2++;
								}
								while (num2 <= 1);
								num2 = 0;
								do
								{
									text = string.Format("PERIFERICO{0}", num2 + 1);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.config_perifericos1_mod[num2], RT_geral.RT_820_360_DataGrigViewPerifericos1Colunas[0], iniFile.ReadInteger(text, "MODELO", 0));
									RT_geral.RT_820_360_BD.config_perifericos1_end[num2].Valor = iniFile.ReadInteger(text, "ENDERECO", 0);
									num2++;
								}
								while (num2 <= 4);
								num2 = 0;
								do
								{
									text = string.Format("PERIFERICO{0}", num2 + 6);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.config_perifericos2_mod[num2], RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[0], iniFile.ReadInteger(text, "MODELO", 0));
									RT_geral.RT_820_360_BD.config_perifericos2_end[num2].Valor = iniFile.ReadInteger(text, "ENDERECO", 0);
									num2++;
								}
								while (num2 <= 4);
								num2 = 0;
								do
								{
									text = string.Format("PERIFERICO_MODBUS_GENRICO{0}", num2 + 1);
									RT_geral.RT_820_360_BD.config_periferico_modbus_generico_endcom[num2].Valor = iniFile.ReadInteger(text, "END_COM", 0);
									RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num2].Valor = iniFile.ReadInteger(text, "FUNCAO", 3);
									RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num2].Indice = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num2].Indice_padrao;
									int num4 = 0;
									int num5 = RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].NumeroLinhaMenu - 1;
									for (int i = num4; i <= num5; i++)
									{
										if (RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num2].Valor == RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].LinhasValor[i])
										{
											RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num2].Indice = i;
											break;
										}
									}
									RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem1[num2].Valor = iniFile.ReadInteger(text, "MEM1", 0);
									RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var1[num2].Valor = iniFile.ReadInteger(text, "VAR1", 0);
									RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem2[num2].Valor = iniFile.ReadInteger(text, "MEM2", 0);
									RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var2[num2].Valor = iniFile.ReadInteger(text, "VAR2", 0);
									RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem3[num2].Valor = iniFile.ReadInteger(text, "MEM3", 0);
									RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var3[num2].Valor = iniFile.ReadInteger(text, "VAR3", 0);
									RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem4[num2].Valor = iniFile.ReadInteger(text, "MEM4", 0);
									RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var4[num2].Valor = iniFile.ReadInteger(text, "VAR4", 0);
									num2++;
								}
								while (num2 <= 4);
								RT_geral.RT_820_360_BD.End_repetidora.Valor = iniFile.ReadInteger("REPETIDORA", "ENDERECO", 0);
								RT_geral.RT_820_360_BD.Num_repetidoras.Valor = iniFile.ReadInteger("REPETIDORA", "NUMERO_REPETIDORAS", 0);
								num2 = 0;
								do
								{
									text = string.Format("RPT{0}", num2 + 1);
									RT_geral.RT_820_360_BD.Repetidoras[num2].Valor = iniFile.ReadInteger("REPETIDORA", text, 0);
									num2++;
								}
								while (num2 <= 49);
								string[] array = new string[]
								{
									"L1",
									"D1",
									"L2",
									"D2",
									"L3",
									"D3",
									"L4",
									"D4",
									"L5",
									"D5",
									"L6",
									"D6"
								};
								num2 = 0;
								do
								{
									text = string.Format("TIMER{0}", num2 + 1);
									int num6 = 0;
									int num7 = array.Length - 1;
									for (int j = num6; j <= num7; j++)
									{
										RT_geral.RT_820_360_BD.Timer_Horario[num2][j].Valor = iniFile.ReadInteger(text, array[j], 0);
									}
									num2++;
								}
								while (num2 <= 7);
								RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor = iniFile.ReadInteger("SETPOINT", "TRATAMENTO_PERCENTUAL", 0);
								num2 = 0;
								do
								{
									text = string.Format("SETPOINT{0}", num2 + 1);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.Setpoints_ctrl_variavel[num2], RT_geral.RT_820_DataGrigViewSetpointsColunas[0], iniFile.ReadInteger(text, "CTRL_VARIAVEL", 0));
									RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[num2].Valor = iniFile.ReadInteger(text, "NIVEL_ALTO", 0);
									RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[num2].Valor = iniFile.ReadInteger(text, "NIVEL_BAIXO", 0);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_360_BD.Setpoints_ctrl_bloqueio[num2], RT_geral.RT_820_DataGrigViewSetpointsColunas[3], iniFile.ReadInteger(text, "CTRL_BLOQUEIO", 0));
									RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[num2].Valor = iniFile.ReadInteger(text, "CTRL_NIVEL_BLOQUEIO", 0);
									RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[num2].Valor = iniFile.ReadInteger(text, "CTRL_NIVRL_LIBERACAO", 0);
									num2++;
								}
								while (num2 <= 7);
								num2 = 0;
								do
								{
									text = string.Format("SETPOINT_HORARIO_{0}", num2 + 1);
									int num3 = iniFile.ReadInteger(text, "HORA", 0);
									if (num3 >= 65535)
									{
										num3 = 23;
									}
									RT_geral.RT_820_360_BD.setpoint_horario[num2].Hora.Valor = num3;
									num3 = iniFile.ReadInteger(text, "MINUTO", 0);
									if (num3 >= 65535)
									{
										num3 = 59;
									}
									RT_geral.RT_820_360_BD.setpoint_horario[num2].Minuto.Valor = num3;
									num3 = iniFile.ReadInteger(text, "ALTO", 0);
									if (num3 >= 65535)
									{
										num3 = 4000;
									}
									RT_geral.RT_820_360_BD.setpoint_horario[num2].Alto.Valor = num3;
									num3 = iniFile.ReadInteger(text, "BAIXO", 0);
									if (num3 >= 65535)
									{
										num3 = 4000;
									}
									RT_geral.RT_820_360_BD.setpoint_horario[num2].Baixo.Valor = num3;
									num2++;
								}
								while (num2 <= 79);
								num2 = 0;
								do
								{
									text = string.Format("REFERENCIA_PERIFERICO_{0}", num2 + 1);
									int num3 = iniFile.ReadInteger(text, "PERIFERICO", 0);
									if (num3 >= 6)
									{
										num3 = 0;
									}
									RT_geral.RT_820_360_BD.config_referencia_perif_periferico[num2].Valor = num3;
									num3 = iniFile.ReadInteger(text, "END_MEM", 0);
									if (num3 >= RT_geral.RT_820_360_BD.config_referencia_perif_memoria[num2].Lmte_sup)
									{
										num3 = RT_geral.RT_820_360_BD.config_referencia_perif_memoria[num2].Lmte_sup;
									}
									RT_geral.RT_820_360_BD.config_referencia_perif_memoria[num2].Valor = num3;
									num3 = iniFile.ReadInteger(text, "VARIAVEL1", 0);
									if (num3 >= 21)
									{
										num3 = 0;
									}
									RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[num2].Valor = num3;
									num3 = iniFile.ReadInteger(text, "VARIAVEL2", 0);
									if (num3 >= 17)
									{
										num3 = 0;
									}
									RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[num2].Valor = num3;
									num3 = iniFile.ReadInteger(text, "ESCALA", 0);
									if (num3 >= RT_geral.RT_820_360_BD.config_referencia_perif_escala[num2].Lmte_sup)
									{
										num3 = RT_geral.RT_820_360_BD.config_referencia_perif_escala[num2].Lmte_sup;
									}
									RT_geral.RT_820_360_BD.config_referencia_perif_escala[num2].Valor = num3;
									num3 = iniFile.ReadInteger(text, "FORMATO", 0);
									if (num3 >= 3)
									{
										num3 = 0;
									}
									RT_geral.RT_820_360_BD.config_referencia_perif_formato[num2].Valor = num3;
									num3 = iniFile.ReadInteger(text, "BASE10", 0);
									if (num3 >= 3)
									{
										num3 = 0;
									}
									RT_geral.RT_820_360_BD.config_referencia_perif_base10[num2].Valor = num3;
									num2++;
								}
								while (num2 <= 9);
								text = "ATUADOR1_PERIFERICO";
								RT_geral.RT_820_360_BD.config_atuador1_perif[0].Valor = iniFile.ReadInteger(text, "PERIFERICO", 0);
								RT_geral.RT_820_360_BD.config_atuador1_formato[0].Valor = iniFile.ReadInteger(text, "FORMATO", 0);
								RT_geral.RT_820_360_BD.config_atuador1_base10[0].Valor = iniFile.ReadInteger(text, "BASE10", 0);
								RT_geral.RT_820_360_BD.config_atuador1_mem[0].Valor = iniFile.ReadInteger(text, "END_MEM", 0);
								RT_geral.RT_820_360_BD.config_atuador1_var1[0].Valor = iniFile.ReadInteger(text, "VARIAVEL1", 0);
								RT_geral.RT_820_360_BD.config_atuador1_escala1[0].Valor = iniFile.ReadInteger(text, "ESCALA1", 0);
								RT_geral.RT_820_360_BD.config_atuador1_var2[0].Valor = iniFile.ReadInteger(text, "VARIAVEL2", 0);
								RT_geral.RT_820_360_BD.config_atuador1_escala2[0].Valor = iniFile.ReadInteger(text, "ESCALA2", 0);
								RT_geral.RT_820_360_BD.config_atuador1_histerese[0].Valor = iniFile.ReadInteger(text, "HISTERESE", 0);
								RT_geral.RT_820_360_BD.config_atuador1_v1baixo[0].Valor = iniFile.ReadInteger(text, "V1BAIXO", 0);
								RT_geral.RT_820_360_BD.config_atuador1_v1alto[0].Valor = iniFile.ReadInteger(text, "V1ALTO", 0);
								RT_geral.RT_820_360_BD.config_atuador1_v2baixo[0].Valor = iniFile.ReadInteger(text, "V2BAIXO", 0);
								RT_geral.RT_820_360_BD.config_atuador1_v2alto[0].Valor = iniFile.ReadInteger(text, "V2ALTO", 0);
								num2 = 0;
								do
								{
									text = string.Format("ATUADOR1_VARIAVEL1_PERIFERICO_{0}", num2 + 1);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[num2].Valor = iniFile.ReadInteger(text, "HORA", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[num2].Valor = iniFile.ReadInteger(text, "MINUTO", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[num2].Valor = iniFile.ReadInteger(text, "REF1", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[num2].Valor = iniFile.ReadInteger(text, "REF2", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[num2].Valor = iniFile.ReadInteger(text, "REF3", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[num2].Valor = iniFile.ReadInteger(text, "REF4", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[num2].Valor = iniFile.ReadInteger(text, "REF5", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[num2].Valor = iniFile.ReadInteger(text, "REF6", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[num2].Valor = iniFile.ReadInteger(text, "SETP1", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[num2].Valor = iniFile.ReadInteger(text, "SETP2", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[num2].Valor = iniFile.ReadInteger(text, "SETP3", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[num2].Valor = iniFile.ReadInteger(text, "SETP4", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[num2].Valor = iniFile.ReadInteger(text, "SETP5", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[num2].Valor = iniFile.ReadInteger(text, "SETP6", 0);
									num2++;
								}
								while (num2 <= 2);
								num2 = 0;
								do
								{
									text = string.Format("ATUADOR1_VARIAVEL2_PERIFERICO_{0}", num2 + 1);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[num2].Valor = iniFile.ReadInteger(text, "REF1", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[num2].Valor = iniFile.ReadInteger(text, "REF2", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[num2].Valor = iniFile.ReadInteger(text, "REF3", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[num2].Valor = iniFile.ReadInteger(text, "REF4", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[num2].Valor = iniFile.ReadInteger(text, "REF5", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[num2].Valor = iniFile.ReadInteger(text, "REF6", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[num2].Valor = iniFile.ReadInteger(text, "SETP1", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[num2].Valor = iniFile.ReadInteger(text, "SETP2", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[num2].Valor = iniFile.ReadInteger(text, "SETP3", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[num2].Valor = iniFile.ReadInteger(text, "SETP4", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[num2].Valor = iniFile.ReadInteger(text, "SETP5", 0);
									RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[num2].Valor = iniFile.ReadInteger(text, "SETP6", 0);
									num2++;
								}
								while (num2 <= 2);
								text = "ATUADOR2_PERIFERICO";
								RT_geral.RT_820_360_BD.config_atuador2_perif[0].Valor = iniFile.ReadInteger(text, "PERIFERICO", 0);
								RT_geral.RT_820_360_BD.config_atuador2_formato[0].Valor = iniFile.ReadInteger(text, "FORMATO", 0);
								RT_geral.RT_820_360_BD.config_atuador2_base10[0].Valor = iniFile.ReadInteger(text, "BASE10", 0);
								RT_geral.RT_820_360_BD.config_atuador2_mem[0].Valor = iniFile.ReadInteger(text, "END_MEM", 0);
								RT_geral.RT_820_360_BD.config_atuador2_var1[0].Valor = iniFile.ReadInteger(text, "VARIAVEL1", 0);
								RT_geral.RT_820_360_BD.config_atuador2_escala1[0].Valor = iniFile.ReadInteger(text, "ESCALA1", 0);
								RT_geral.RT_820_360_BD.config_atuador2_var2[0].Valor = iniFile.ReadInteger(text, "VARIAVEL2", 0);
								RT_geral.RT_820_360_BD.config_atuador2_escala2[0].Valor = iniFile.ReadInteger(text, "ESCALA2", 0);
								RT_geral.RT_820_360_BD.config_atuador2_histerese[0].Valor = iniFile.ReadInteger(text, "HISTERESE", 0);
								RT_geral.RT_820_360_BD.config_atuador2_v1baixo[0].Valor = iniFile.ReadInteger(text, "V1BAIXO", 0);
								RT_geral.RT_820_360_BD.config_atuador2_v1alto[0].Valor = iniFile.ReadInteger(text, "V1ALTO", 0);
								RT_geral.RT_820_360_BD.config_atuador2_v2baixo[0].Valor = iniFile.ReadInteger(text, "V2BAIXO", 0);
								RT_geral.RT_820_360_BD.config_atuador2_v2alto[0].Valor = iniFile.ReadInteger(text, "V2ALTO", 0);
								num2 = 0;
								do
								{
									text = string.Format("ATUADOR2_VARIAVEL1_PERIFERICO_{0}", num2 + 1);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[num2].Valor = iniFile.ReadInteger(text, "HORA", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[num2].Valor = iniFile.ReadInteger(text, "MINUTO", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[num2].Valor = iniFile.ReadInteger(text, "REF1", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[num2].Valor = iniFile.ReadInteger(text, "REF2", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[num2].Valor = iniFile.ReadInteger(text, "REF3", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[num2].Valor = iniFile.ReadInteger(text, "REF4", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[num2].Valor = iniFile.ReadInteger(text, "REF5", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[num2].Valor = iniFile.ReadInteger(text, "REF6", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[num2].Valor = iniFile.ReadInteger(text, "SETP1", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[num2].Valor = iniFile.ReadInteger(text, "SETP2", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[num2].Valor = iniFile.ReadInteger(text, "SETP3", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[num2].Valor = iniFile.ReadInteger(text, "SETP4", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[num2].Valor = iniFile.ReadInteger(text, "SETP5", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[num2].Valor = iniFile.ReadInteger(text, "SETP6", 0);
									num2++;
								}
								while (num2 <= 2);
								num2 = 0;
								do
								{
									text = string.Format("ATUADOR2_VARIAVEL2_PERIFERICO_{0}", num2 + 1);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[num2].Valor = iniFile.ReadInteger(text, "REF1", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[num2].Valor = iniFile.ReadInteger(text, "REF2", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[num2].Valor = iniFile.ReadInteger(text, "REF3", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[num2].Valor = iniFile.ReadInteger(text, "REF4", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[num2].Valor = iniFile.ReadInteger(text, "REF5", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[num2].Valor = iniFile.ReadInteger(text, "REF6", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[num2].Valor = iniFile.ReadInteger(text, "SETP1", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[num2].Valor = iniFile.ReadInteger(text, "SETP2", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[num2].Valor = iniFile.ReadInteger(text, "SETP3", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[num2].Valor = iniFile.ReadInteger(text, "SETP4", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[num2].Valor = iniFile.ReadInteger(text, "SETP5", 0);
									RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[num2].Valor = iniFile.ReadInteger(text, "SETP6", 0);
									num2++;
								}
								while (num2 <= 2);
								text = "ATUADOR3_PERIFERICO";
								RT_geral.RT_820_360_BD.config_atuador3_perif[0].Valor = iniFile.ReadInteger(text, "PERIFERICO", 0);
								RT_geral.RT_820_360_BD.config_atuador3_formato[0].Valor = iniFile.ReadInteger(text, "FORMATO", 0);
								RT_geral.RT_820_360_BD.config_atuador3_base10[0].Valor = iniFile.ReadInteger(text, "BASE10", 0);
								RT_geral.RT_820_360_BD.config_atuador3_mem[0].Valor = iniFile.ReadInteger(text, "END_MEM", 0);
								RT_geral.RT_820_360_BD.config_atuador3_var1[0].Valor = iniFile.ReadInteger(text, "VARIAVEL1", 0);
								RT_geral.RT_820_360_BD.config_atuador3_escala1[0].Valor = iniFile.ReadInteger(text, "ESCALA1", 0);
								RT_geral.RT_820_360_BD.config_atuador3_var2[0].Valor = iniFile.ReadInteger(text, "VARIAVEL2", 0);
								RT_geral.RT_820_360_BD.config_atuador3_escala2[0].Valor = iniFile.ReadInteger(text, "ESCALA2", 0);
								RT_geral.RT_820_360_BD.config_atuador3_histerese[0].Valor = iniFile.ReadInteger(text, "HISTERESE", 0);
								RT_geral.RT_820_360_BD.config_atuador3_v1baixo[0].Valor = iniFile.ReadInteger(text, "V1BAIXO", 0);
								RT_geral.RT_820_360_BD.config_atuador3_v1alto[0].Valor = iniFile.ReadInteger(text, "V1ALTO", 0);
								RT_geral.RT_820_360_BD.config_atuador3_v2baixo[0].Valor = iniFile.ReadInteger(text, "V2BAIXO", 0);
								RT_geral.RT_820_360_BD.config_atuador3_v2alto[0].Valor = iniFile.ReadInteger(text, "V2ALTO", 0);
								num2 = 0;
								do
								{
									text = string.Format("ATUADOR3_VARIAVEL1_PERIFERICO_{0}", num2 + 1);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[num2].Valor = iniFile.ReadInteger(text, "HORA", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[num2].Valor = iniFile.ReadInteger(text, "MINUTO", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[num2].Valor = iniFile.ReadInteger(text, "REF1", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[num2].Valor = iniFile.ReadInteger(text, "REF2", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[num2].Valor = iniFile.ReadInteger(text, "REF3", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[num2].Valor = iniFile.ReadInteger(text, "REF4", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[num2].Valor = iniFile.ReadInteger(text, "REF5", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[num2].Valor = iniFile.ReadInteger(text, "REF6", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[num2].Valor = iniFile.ReadInteger(text, "SETP1", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[num2].Valor = iniFile.ReadInteger(text, "SETP2", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[num2].Valor = iniFile.ReadInteger(text, "SETP3", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[num2].Valor = iniFile.ReadInteger(text, "SETP4", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[num2].Valor = iniFile.ReadInteger(text, "SETP5", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[num2].Valor = iniFile.ReadInteger(text, "SETP6", 0);
									num2++;
								}
								while (num2 <= 2);
								num2 = 0;
								do
								{
									text = string.Format("ATUADOR3_VARIAVEL2_PERIFERICO_{0}", num2 + 1);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[num2].Valor = iniFile.ReadInteger(text, "REF1", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[num2].Valor = iniFile.ReadInteger(text, "REF2", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[num2].Valor = iniFile.ReadInteger(text, "REF3", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[num2].Valor = iniFile.ReadInteger(text, "REF4", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[num2].Valor = iniFile.ReadInteger(text, "REF5", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[num2].Valor = iniFile.ReadInteger(text, "REF6", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[num2].Valor = iniFile.ReadInteger(text, "SETP1", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[num2].Valor = iniFile.ReadInteger(text, "SETP2", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[num2].Valor = iniFile.ReadInteger(text, "SETP3", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[num2].Valor = iniFile.ReadInteger(text, "SETP4", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[num2].Valor = iniFile.ReadInteger(text, "SETP5", 0);
									RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[num2].Valor = iniFile.ReadInteger(text, "SETP6", 0);
									num2++;
								}
								while (num2 <= 2);
								text = "ATUADOR4_PERIFERICO";
								RT_geral.RT_820_360_BD.config_atuador4_perif[0].Valor = iniFile.ReadInteger(text, "PERIFERICO", 0);
								RT_geral.RT_820_360_BD.config_atuador4_formato[0].Valor = iniFile.ReadInteger(text, "FORMATO", 0);
								RT_geral.RT_820_360_BD.config_atuador4_base10[0].Valor = iniFile.ReadInteger(text, "BASE10", 0);
								RT_geral.RT_820_360_BD.config_atuador4_mem[0].Valor = iniFile.ReadInteger(text, "END_MEM", 0);
								RT_geral.RT_820_360_BD.config_atuador4_var1[0].Valor = iniFile.ReadInteger(text, "VARIAVEL1", 0);
								RT_geral.RT_820_360_BD.config_atuador4_escala1[0].Valor = iniFile.ReadInteger(text, "ESCALA1", 0);
								RT_geral.RT_820_360_BD.config_atuador4_var2[0].Valor = iniFile.ReadInteger(text, "VARIAVEL2", 0);
								RT_geral.RT_820_360_BD.config_atuador4_escala2[0].Valor = iniFile.ReadInteger(text, "ESCALA2", 0);
								RT_geral.RT_820_360_BD.config_atuador4_histerese[0].Valor = iniFile.ReadInteger(text, "HISTERESE", 0);
								RT_geral.RT_820_360_BD.config_atuador4_v1baixo[0].Valor = iniFile.ReadInteger(text, "V1BAIXO", 0);
								RT_geral.RT_820_360_BD.config_atuador4_v1alto[0].Valor = iniFile.ReadInteger(text, "V1ALTO", 0);
								RT_geral.RT_820_360_BD.config_atuador4_v2baixo[0].Valor = iniFile.ReadInteger(text, "V2BAIXO", 0);
								RT_geral.RT_820_360_BD.config_atuador4_v2alto[0].Valor = iniFile.ReadInteger(text, "V2ALTO", 0);
								num2 = 0;
								do
								{
									text = string.Format("ATUADOR4_VARIAVEL1_PERIFERICO_{0}", num2 + 1);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[num2].Valor = iniFile.ReadInteger(text, "HORA", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[num2].Valor = iniFile.ReadInteger(text, "MINUTO", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[num2].Valor = iniFile.ReadInteger(text, "REF1", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[num2].Valor = iniFile.ReadInteger(text, "REF2", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[num2].Valor = iniFile.ReadInteger(text, "REF3", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[num2].Valor = iniFile.ReadInteger(text, "REF4", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[num2].Valor = iniFile.ReadInteger(text, "REF5", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[num2].Valor = iniFile.ReadInteger(text, "REF6", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[num2].Valor = iniFile.ReadInteger(text, "SETP1", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[num2].Valor = iniFile.ReadInteger(text, "SETP2", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[num2].Valor = iniFile.ReadInteger(text, "SETP3", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[num2].Valor = iniFile.ReadInteger(text, "SETP4", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[num2].Valor = iniFile.ReadInteger(text, "SETP5", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[num2].Valor = iniFile.ReadInteger(text, "SETP6", 0);
									num2++;
								}
								while (num2 <= 2);
								num2 = 0;
								do
								{
									text = string.Format("ATUADOR4_VARIAVEL2_PERIFERICO_{0}", num2 + 1);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[num2].Valor = iniFile.ReadInteger(text, "REF1", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[num2].Valor = iniFile.ReadInteger(text, "REF2", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[num2].Valor = iniFile.ReadInteger(text, "REF3", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[num2].Valor = iniFile.ReadInteger(text, "REF4", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[num2].Valor = iniFile.ReadInteger(text, "REF5", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[num2].Valor = iniFile.ReadInteger(text, "REF6", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[num2].Valor = iniFile.ReadInteger(text, "SETP1", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[num2].Valor = iniFile.ReadInteger(text, "SETP2", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[num2].Valor = iniFile.ReadInteger(text, "SETP3", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[num2].Valor = iniFile.ReadInteger(text, "SETP4", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[num2].Valor = iniFile.ReadInteger(text, "SETP5", 0);
									RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[num2].Valor = iniFile.ReadInteger(text, "SETP6", 0);
									num2++;
								}
								while (num2 <= 2);
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
								this.TextBox_nome_RT820.Text = iniFile.ReadText("GERAL_DESCRICAO", "NOME", "");
								this.TextBox_endereco_RT820.Text = iniFile.ReadText("GERAL_DESCRICAO", "ENDERECO", "");
								this.TextBox_comentarios_RT820.Text = iniFile.ReadText("GERAL_DESCRICAO", "COMENTARIO", "");
								this.Atualiza_TelaRT820();
								this.bloqueio_IO = false;
								this.AtualizaMsgTela_RT_820("Arquivo carregado com sucesso!", 0);
								this.Timer_limpa_MSG_820.Enabled = true;
							}
						}
					}
					else
					{
						this.AtualizaMsgTela_RT_820("Operação Cancelada", 0);
						this.Timer_limpa_MSG_820.Enabled = true;
					}
					goto IL_2DAF;
					IL_2D4A:
					Interaction.MsgBox("Não foi possível carregar os dados", (MsgBoxStyle)32, "Atenção - Erro I/0");
					this.Timer_limpa_MSG_820.Enabled = true;
					goto IL_2DAF;
					IL_2D6A:
					num8 = -1;
										IL_2D80:;
				}
				catch (Exception) { }
				IL_2DAF:
				if (num8 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x0035A654 File Offset: 0x00358A54
		private void ToolStripButton_RT_820_Salvar_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			this.ToolStripButton_RT_820_Abrir.Enabled = false;
			this.ToolStripButton_RT_820_novo.Enabled = false;
			this.ToolStripButton_RT_820_Salvar.Enabled = false;
			this.ToolStripButton_RT_820_Download.Enabled = false;
			this.ToolStripButton_RT_820_Upload.Enabled = false;
			this.SaveFileDialog_RT_820.Filter = "Arquivo de configuração de equipamento|*.Cfg820_400";
			this.SaveFileDialog_RT_820.InitialDirectory = Linha_RT.diretorio;
			checked
			{
				if (this.SaveFileDialog_RT_820.ShowDialog() == DialogResult.OK)
				{
					if (Operators.CompareString(this.SaveFileDialog_RT_820.FileName, "", false) != 0)
					{
						Linha_RT.diretorio = Path.GetDirectoryName(this.SaveFileDialog_RT_820.FileName) + "\\";
						if (File.Exists(this.SaveFileDialog_RT_820.FileName))
						{
							if (File.Exists(this.SaveFileDialog_RT_820.FileName + ".old"))
							{
								File.Delete(this.SaveFileDialog_RT_820.FileName + ".old");
							}
							File.Move(this.SaveFileDialog_RT_820.FileName, this.SaveFileDialog_RT_820.FileName + ".old");
						}
						IniFileWriteFast iniFileWriteFast = new IniFileWriteFast(this.SaveFileDialog_RT_820.FileName);
						RT_geral.RT_820_360_BD.filename = this.SaveFileDialog_RT_820.FileName;
						this.InicializaBarraProgressoTela_RT_820(20);
						iniFileWriteFast.WriteSection("GERAL_INFORMACAO");
						iniFileWriteFast.WriteKey("EQUIPAMENTO", RT_geral.RT_820_360_BD.Equip.Valor);
						iniFileWriteFast.WriteKey("VERSAO", RT_geral.RT_820_360_BD.Versao.Valor);
						iniFileWriteFast.WriteKey("BUILD", RT_geral.RT_820_360_BD.Build.Valor);
						iniFileWriteFast.WriteKey("RELEASE", RT_geral.RT_820_360_BD.Release.Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("GERAL_PARAM_COMINICACAO");
						iniFileWriteFast.WriteKey("ESTACAO1", RT_geral.RT_820_360_BD.End_estacao1.Valor);
						iniFileWriteFast.WriteKey("ESTACAO2", RT_geral.RT_820_360_BD.End_estacao2.Valor);
						iniFileWriteFast.WriteKey("MESTRE", RT_geral.RT_820_360_BD.End_mestre.Valor);
						iniFileWriteFast.WriteKey("TEMPO_PTT", RT_geral.RT_820_360_BD.Tempo_ptt.Valor);
						iniFileWriteFast.WriteKey("BAUDRATE_COM2", RT_geral.RT_820_360_BD.BaudRateCOM2.Valor);
						iniFileWriteFast.WriteKey("BAUDRATE_COM1", RT_geral.RT_820_360_BD.BaudRateCOM1.Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("GERAL_DESCRICAO");
						iniFileWriteFast.WriteKey("NOME", this.TextBox_nome_RT820.Text);
						iniFileWriteFast.WriteKey("ENDERECO", this.TextBox_endereco_RT820.Text);
						iniFileWriteFast.WriteKey("COMENTARIO", this.TextBox_comentarios_RT820.Text);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("GERAL_DIVERSOS");
						iniFileWriteFast.WriteKey("TEMPO_FORA_AR", RT_geral.RT_820_360_BD.TempoForaAr.Valor);
						iniFileWriteFast.WriteKey("HAB_EXPANSAO_IO", RT_geral.RT_820_360_BD.HabExpIO.Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						int num = 0;
						string text;
						do
						{
							text = string.Format("CFG_CONTROLE_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("ACIONAMENTO", RT_geral.RT_820_360_BD.ctrl_acionamento[num].Valor);
							iniFileWriteFast.WriteKey("DESLIGAMENTO", RT_geral.RT_820_360_BD.ctrl_desligamento[num].Valor);
							iniFileWriteFast.WriteKey("RET_ACIONAMENTO", RT_geral.RT_820_360_BD.ctrl_ret_acionamento[num].Valor);
							iniFileWriteFast.WriteKey("RET_DESLIGAMENTO", RT_geral.RT_820_360_BD.ctrl_ret_desligamento[num].Valor);
							iniFileWriteFast.WriteKey("SELECAO_REMOTO", RT_geral.RT_820_360_BD.ctrl_ED_selecao[num].Valor);
							iniFileWriteFast.WriteKey("BLOQUEIO_DIGITAL", RT_geral.RT_820_360_BD.ctrl_ED_bloqueio[num].Valor);
							iniFileWriteFast.WriteKey("LIBERACAO_DIGITAL", RT_geral.RT_820_360_BD.ctrl_ED_liberacao[num].Valor);
							iniFileWriteFast.WriteKey("SELECAO_REVERSO", RT_geral.RT_820_360_BD.ctrl_reverso[num].Valor);
							iniFileWriteFast.WriteKey("MODO_CONTROLE", RT_geral.RT_820_360_BD.ctrl_modo[num].Valor);
							iniFileWriteFast.WriteKey("GRUPO_CONTROLE", RT_geral.RT_820_360_BD.ctrl_agrupamento[num].Valor);
							iniFileWriteFast.WriteKey("GRUPO_PARTIDA", RT_geral.RT_820_360_BD.ctrl_partidas[num].Valor);
							iniFileWriteFast.WriteKey("TEMPO_MAX_PARTIDA", RT_geral.RT_820_360_BD.ctrl_tempo_max_partida[num].Valor);
							iniFileWriteFast.WriteKey("TEMPO_MAX_PARADA", RT_geral.RT_820_360_BD.ctrl_tempo_max_parada[num].Valor);
							iniFileWriteFast.WriteKey("TEMPO_MIN_PARADO", RT_geral.RT_820_360_BD.ctrl_tempo_min_parado[num].Valor);
							iniFileWriteFast.WriteKey("TEMPO_MIN_OPERANDO", RT_geral.RT_820_360_BD.ctrl_tempo_min_operando[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 7);
						num = 0;
						do
						{
							text = string.Format("GRUPO_CONTROLE_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("ACIONAMENTO_PERMITIDO", RT_geral.RT_820_360_BD.grupo_simultaneos[num].Valor);
							iniFileWriteFast.WriteKey("TEMPO_ENTRE_ACIONAMENTO", RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos[num].Valor);
							iniFileWriteFast.WriteKey("ROTATIVO_MOTORES", RT_geral.RT_820_360_BD.grupo_rotativo_motores[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 3);
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("ENTRADA_ANALOGICA");
						iniFileWriteFast.WriteKey("INTERVALO", RT_geral.RT_820_360_BD.AD_Intervalo.Valor);
						iniFileWriteFast.WriteKey("TAMANHO_FILTRO", RT_geral.RT_820_360_BD.AD_Tamanho_filtro.Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						num = 0;
						do
						{
							text = string.Format("ENTRADA_ANALOGICA_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("EA_RANGE", RT_geral.RT_820_360_BD.EA_Range[num].Valor);
							iniFileWriteFast.WriteKey("EA_INICIO", RT_geral.RT_820_360_BD.EA_Inicio[num].Valor);
							iniFileWriteFast.WriteKey("EA_FIM", RT_geral.RT_820_360_BD.EA_Fim[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 15);
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						num = 0;
						do
						{
							text = string.Format("SAIDA_ANALOGICA_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("SA_ORIGEM", RT_geral.RT_820_360_BD.saida_SA_origem[num].Valor);
							iniFileWriteFast.WriteKey("SA_INICIO", RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[num].Valor);
							iniFileWriteFast.WriteKey("SA_FIM", RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[num].Valor);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							num++;
						}
						while (num <= 1);
						iniFileWriteFast.WriteSection("ENTRADA_DIGITAL");
						num = 0;
						do
						{
							text = string.Format("CFG{0}_ED", num + 1);
							iniFileWriteFast.WriteKey(text, RT_geral.RT_820_360_BD.config_ED[num].Valor);
							num++;
						}
						while (num <= 15);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("VAZAO");
						num = 0;
						do
						{
							text = string.Format("V{0}", num + 1);
							iniFileWriteFast.WriteKey(text, RT_geral.RT_820_360_BD.config_vazao[num].Valor);
							num++;
						}
						while (num <= 7);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						num = 0;
						do
						{
							text = string.Format("CALHA_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("EA", RT_geral.RT_820_360_BD.calha_EA[num].Valor);
							iniFileWriteFast.WriteKey("MODELO", RT_geral.RT_820_360_BD.calha_modelo[num].Valor);
							iniFileWriteFast.WriteKey("FUNDO", RT_geral.RT_820_360_BD.calha_fundo[num].Valor);
							iniFileWriteFast.WriteKey("P1", RT_geral.RT_820_360_BD.calha_p1[num].Valor);
							iniFileWriteFast.WriteKey("P2", RT_geral.RT_820_360_BD.calha_p2[num].Valor);
							iniFileWriteFast.WriteKey("P3", RT_geral.RT_820_360_BD.calha_p3[num].Valor);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							num++;
						}
						while (num <= 1);
						num = 0;
						do
						{
							text = string.Format("PERIFERICO{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("MODELO", RT_geral.RT_820_360_BD.config_perifericos1_mod[num].Valor);
							iniFileWriteFast.WriteKey("ENDERECO", RT_geral.RT_820_360_BD.config_perifericos1_end[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 4);
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						num = 0;
						do
						{
							text = string.Format("PERIFERICO{0}", num + 6);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("MODELO", RT_geral.RT_820_360_BD.config_perifericos2_mod[num].Valor);
							iniFileWriteFast.WriteKey("ENDERECO", RT_geral.RT_820_360_BD.config_perifericos2_end[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 4);
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						num = 0;
						do
						{
							text = string.Format("PERIFERICO_MODBUS_GENRICO{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("END_COM", RT_geral.RT_820_360_BD.config_periferico_modbus_generico_endcom[num].Valor);
							iniFileWriteFast.WriteKey("FUNCAO", RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num].Valor);
							iniFileWriteFast.WriteKey("MEM1", RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem1[num].Valor);
							iniFileWriteFast.WriteKey("VAR1", RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var1[num].Valor);
							iniFileWriteFast.WriteKey("MEM2", RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem2[num].Valor);
							iniFileWriteFast.WriteKey("VAR2", RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var2[num].Valor);
							iniFileWriteFast.WriteKey("MEM3", RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem3[num].Valor);
							iniFileWriteFast.WriteKey("VAR3", RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var3[num].Valor);
							iniFileWriteFast.WriteKey("MEM4", RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem4[num].Valor);
							iniFileWriteFast.WriteKey("VAR4", RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var4[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 4);
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("SETPOINT");
						iniFileWriteFast.WriteKey("TRATAMENTO_PERCENTUAL", RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor);
						iniFileWriteFast.LineSpace();
						num = 0;
						do
						{
							text = string.Format("SETPOINT{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("CTRL_VARIAVEL", RT_geral.RT_820_360_BD.Setpoints_ctrl_variavel[num].Valor);
							iniFileWriteFast.WriteKey("NIVEL_ALTO", RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[num].Valor);
							iniFileWriteFast.WriteKey("NIVEL_BAIXO", RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[num].Valor);
							iniFileWriteFast.WriteKey("CTRL_BLOQUEIO", RT_geral.RT_820_360_BD.Setpoints_ctrl_bloqueio[num].Valor);
							iniFileWriteFast.WriteKey("CTRL_NIVEL_BLOQUEIO", RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[num].Valor);
							iniFileWriteFast.WriteKey("CTRL_NIVRL_LIBERACAO", RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 7);
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						num = 0;
						do
						{
							text = string.Format("SETPOINT_HORARIO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("HORA", RT_geral.RT_820_360_BD.setpoint_horario[num].Hora.Valor);
							iniFileWriteFast.WriteKey("MINUTO", RT_geral.RT_820_360_BD.setpoint_horario[num].Minuto.Valor);
							iniFileWriteFast.WriteKey("ALTO", RT_geral.RT_820_360_BD.setpoint_horario[num].Alto.Valor);
							iniFileWriteFast.WriteKey("BAIXO", RT_geral.RT_820_360_BD.setpoint_horario[num].Baixo.Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 79);
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						num = 0;
						do
						{
							text = string.Format("REFERENCIA_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("PERIFERICO", RT_geral.RT_820_360_BD.config_referencia_perif_periferico[num].Valor);
							iniFileWriteFast.WriteKey("END_MEM", RT_geral.RT_820_360_BD.config_referencia_perif_memoria[num].Valor);
							iniFileWriteFast.WriteKey("VARIAVEL1", RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[num].Valor);
							iniFileWriteFast.WriteKey("VARIAVEL2", RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[num].Valor);
							iniFileWriteFast.WriteKey("ESCALA", RT_geral.RT_820_360_BD.config_referencia_perif_escala[num].Valor);
							iniFileWriteFast.WriteKey("FORMATO", RT_geral.RT_820_360_BD.config_referencia_perif_formato[num].Valor);
							iniFileWriteFast.WriteKey("BASE10", RT_geral.RT_820_360_BD.config_referencia_perif_base10[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 9);
						Application.DoEvents();
						text = "ATUADOR1_PERIFERICO";
						iniFileWriteFast.WriteSection(text);
						iniFileWriteFast.WriteKey("PERIFERICO", RT_geral.RT_820_360_BD.config_atuador1_perif[0].Valor);
						iniFileWriteFast.WriteKey("FORMATO", RT_geral.RT_820_360_BD.config_atuador1_formato[0].Valor);
						iniFileWriteFast.WriteKey("BASE10", RT_geral.RT_820_360_BD.config_atuador1_base10[0].Valor);
						iniFileWriteFast.WriteKey("END_MEM", RT_geral.RT_820_360_BD.config_atuador1_mem[0].Valor);
						iniFileWriteFast.WriteKey("VARIAVEL1", RT_geral.RT_820_360_BD.config_atuador1_var1[0].Valor);
						iniFileWriteFast.WriteKey("ESCALA1", RT_geral.RT_820_360_BD.config_atuador1_escala1[0].Valor);
						iniFileWriteFast.WriteKey("VARIAVEL2", RT_geral.RT_820_360_BD.config_atuador1_var2[0].Valor);
						iniFileWriteFast.WriteKey("ESCALA2", RT_geral.RT_820_360_BD.config_atuador1_escala2[0].Valor);
						iniFileWriteFast.WriteKey("HISTERESE", RT_geral.RT_820_360_BD.config_atuador1_histerese[0].Valor);
						iniFileWriteFast.WriteKey("V1BAIXO", RT_geral.RT_820_360_BD.config_atuador1_v1baixo[0].Valor);
						iniFileWriteFast.WriteKey("V1ALTO", RT_geral.RT_820_360_BD.config_atuador1_v1alto[0].Valor);
						iniFileWriteFast.WriteKey("V2BAIXO", RT_geral.RT_820_360_BD.config_atuador1_v2baixo[0].Valor);
						iniFileWriteFast.WriteKey("V2ALTO", RT_geral.RT_820_360_BD.config_atuador1_v2alto[0].Valor);
						iniFileWriteFast.LineSpace();
						num = 0;
						do
						{
							text = string.Format("ATUADOR1_VARIAVEL1_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("HORA", RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[num].Valor);
							iniFileWriteFast.WriteKey("MINUTO", RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[num].Valor);
							iniFileWriteFast.WriteKey("REF1", RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[num].Valor);
							iniFileWriteFast.WriteKey("REF2", RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[num].Valor);
							iniFileWriteFast.WriteKey("REF3", RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[num].Valor);
							iniFileWriteFast.WriteKey("REF4", RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[num].Valor);
							iniFileWriteFast.WriteKey("REF5", RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[num].Valor);
							iniFileWriteFast.WriteKey("REF6", RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[num].Valor);
							iniFileWriteFast.WriteKey("SETP1", RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[num].Valor);
							iniFileWriteFast.WriteKey("SETP2", RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[num].Valor);
							iniFileWriteFast.WriteKey("SETP3", RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[num].Valor);
							iniFileWriteFast.WriteKey("SETP4", RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[num].Valor);
							iniFileWriteFast.WriteKey("SETP5", RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[num].Valor);
							iniFileWriteFast.WriteKey("SETP6", RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 2);
						num = 0;
						do
						{
							text = string.Format("ATUADOR1_VARIAVEL2_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("REF1", RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[num].Valor);
							iniFileWriteFast.WriteKey("REF2", RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[num].Valor);
							iniFileWriteFast.WriteKey("REF3", RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[num].Valor);
							iniFileWriteFast.WriteKey("REF4", RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[num].Valor);
							iniFileWriteFast.WriteKey("REF5", RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[num].Valor);
							iniFileWriteFast.WriteKey("REF6", RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[num].Valor);
							iniFileWriteFast.WriteKey("SETP1", RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[num].Valor);
							iniFileWriteFast.WriteKey("SETP2", RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[num].Valor);
							iniFileWriteFast.WriteKey("SETP3", RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[num].Valor);
							iniFileWriteFast.WriteKey("SETP4", RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[num].Valor);
							iniFileWriteFast.WriteKey("SETP5", RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[num].Valor);
							iniFileWriteFast.WriteKey("SETP6", RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 2);
						text = "ATUADOR2_PERIFERICO";
						iniFileWriteFast.WriteSection(text);
						iniFileWriteFast.WriteKey("PERIFERICO", RT_geral.RT_820_360_BD.config_atuador2_perif[0].Valor);
						iniFileWriteFast.WriteKey("FORMATO", RT_geral.RT_820_360_BD.config_atuador2_formato[0].Valor);
						iniFileWriteFast.WriteKey("BASE10", RT_geral.RT_820_360_BD.config_atuador2_base10[0].Valor);
						iniFileWriteFast.WriteKey("END_MEM", RT_geral.RT_820_360_BD.config_atuador2_mem[0].Valor);
						iniFileWriteFast.WriteKey("VARIAVEL1", RT_geral.RT_820_360_BD.config_atuador2_var1[0].Valor);
						iniFileWriteFast.WriteKey("ESCALA1", RT_geral.RT_820_360_BD.config_atuador2_escala1[0].Valor);
						iniFileWriteFast.WriteKey("VARIAVEL2", RT_geral.RT_820_360_BD.config_atuador2_var2[0].Valor);
						iniFileWriteFast.WriteKey("ESCALA2", RT_geral.RT_820_360_BD.config_atuador2_escala2[0].Valor);
						iniFileWriteFast.WriteKey("HISTERESE", RT_geral.RT_820_360_BD.config_atuador2_histerese[0].Valor);
						iniFileWriteFast.WriteKey("V1BAIXO", RT_geral.RT_820_360_BD.config_atuador2_v1baixo[0].Valor);
						iniFileWriteFast.WriteKey("V1ALTO", RT_geral.RT_820_360_BD.config_atuador2_v1alto[0].Valor);
						iniFileWriteFast.WriteKey("V2BAIXO", RT_geral.RT_820_360_BD.config_atuador2_v2baixo[0].Valor);
						iniFileWriteFast.WriteKey("V2ALTO", RT_geral.RT_820_360_BD.config_atuador2_v2alto[0].Valor);
						iniFileWriteFast.LineSpace();
						num = 0;
						do
						{
							text = string.Format("ATUADOR2_VARIAVEL1_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("HORA", RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[num].Valor);
							iniFileWriteFast.WriteKey("MINUTO", RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[num].Valor);
							iniFileWriteFast.WriteKey("REF1", RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[num].Valor);
							iniFileWriteFast.WriteKey("REF2", RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[num].Valor);
							iniFileWriteFast.WriteKey("REF3", RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[num].Valor);
							iniFileWriteFast.WriteKey("REF4", RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[num].Valor);
							iniFileWriteFast.WriteKey("REF5", RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[num].Valor);
							iniFileWriteFast.WriteKey("REF6", RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[num].Valor);
							iniFileWriteFast.WriteKey("SETP1", RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[num].Valor);
							iniFileWriteFast.WriteKey("SETP2", RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[num].Valor);
							iniFileWriteFast.WriteKey("SETP3", RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[num].Valor);
							iniFileWriteFast.WriteKey("SETP4", RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[num].Valor);
							iniFileWriteFast.WriteKey("SETP5", RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[num].Valor);
							iniFileWriteFast.WriteKey("SETP6", RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 2);
						num = 0;
						do
						{
							text = string.Format("ATUADOR2_VARIAVEL2_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("REF1", RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[num].Valor);
							iniFileWriteFast.WriteKey("REF2", RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[num].Valor);
							iniFileWriteFast.WriteKey("REF3", RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[num].Valor);
							iniFileWriteFast.WriteKey("REF4", RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[num].Valor);
							iniFileWriteFast.WriteKey("REF5", RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[num].Valor);
							iniFileWriteFast.WriteKey("REF6", RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[num].Valor);
							iniFileWriteFast.WriteKey("SETP1", RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[num].Valor);
							iniFileWriteFast.WriteKey("SETP2", RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[num].Valor);
							iniFileWriteFast.WriteKey("SETP3", RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[num].Valor);
							iniFileWriteFast.WriteKey("SETP4", RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[num].Valor);
							iniFileWriteFast.WriteKey("SETP5", RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[num].Valor);
							iniFileWriteFast.WriteKey("SETP6", RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 2);
						text = "ATUADOR3_PERIFERICO";
						iniFileWriteFast.WriteSection(text);
						iniFileWriteFast.WriteKey("PERIFERICO", RT_geral.RT_820_360_BD.config_atuador3_perif[0].Valor);
						iniFileWriteFast.WriteKey("FORMATO", RT_geral.RT_820_360_BD.config_atuador3_formato[0].Valor);
						iniFileWriteFast.WriteKey("BASE10", RT_geral.RT_820_360_BD.config_atuador3_base10[0].Valor);
						iniFileWriteFast.WriteKey("END_MEM", RT_geral.RT_820_360_BD.config_atuador3_mem[0].Valor);
						iniFileWriteFast.WriteKey("VARIAVEL1", RT_geral.RT_820_360_BD.config_atuador3_var1[0].Valor);
						iniFileWriteFast.WriteKey("ESCALA1", RT_geral.RT_820_360_BD.config_atuador3_escala1[0].Valor);
						iniFileWriteFast.WriteKey("VARIAVEL2", RT_geral.RT_820_360_BD.config_atuador3_var2[0].Valor);
						iniFileWriteFast.WriteKey("ESCALA2", RT_geral.RT_820_360_BD.config_atuador3_escala2[0].Valor);
						iniFileWriteFast.WriteKey("HISTERESE", RT_geral.RT_820_360_BD.config_atuador3_histerese[0].Valor);
						iniFileWriteFast.WriteKey("V1BAIXO", RT_geral.RT_820_360_BD.config_atuador3_v1baixo[0].Valor);
						iniFileWriteFast.WriteKey("V1ALTO", RT_geral.RT_820_360_BD.config_atuador3_v1alto[0].Valor);
						iniFileWriteFast.WriteKey("V2BAIXO", RT_geral.RT_820_360_BD.config_atuador3_v2baixo[0].Valor);
						iniFileWriteFast.WriteKey("V2ALTO", RT_geral.RT_820_360_BD.config_atuador3_v2alto[0].Valor);
						iniFileWriteFast.LineSpace();
						num = 0;
						do
						{
							text = string.Format("ATUADOR3_VARIAVEL1_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("HORA", RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[num].Valor);
							iniFileWriteFast.WriteKey("MINUTO", RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[num].Valor);
							iniFileWriteFast.WriteKey("REF1", RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[num].Valor);
							iniFileWriteFast.WriteKey("REF2", RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[num].Valor);
							iniFileWriteFast.WriteKey("REF3", RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[num].Valor);
							iniFileWriteFast.WriteKey("REF4", RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[num].Valor);
							iniFileWriteFast.WriteKey("REF5", RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[num].Valor);
							iniFileWriteFast.WriteKey("REF6", RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[num].Valor);
							iniFileWriteFast.WriteKey("SETP1", RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[num].Valor);
							iniFileWriteFast.WriteKey("SETP2", RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[num].Valor);
							iniFileWriteFast.WriteKey("SETP3", RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[num].Valor);
							iniFileWriteFast.WriteKey("SETP4", RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[num].Valor);
							iniFileWriteFast.WriteKey("SETP5", RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[num].Valor);
							iniFileWriteFast.WriteKey("SETP6", RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 2);
						num = 0;
						do
						{
							text = string.Format("ATUADOR3_VARIAVEL2_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("REF1", RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[num].Valor);
							iniFileWriteFast.WriteKey("REF2", RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[num].Valor);
							iniFileWriteFast.WriteKey("REF3", RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[num].Valor);
							iniFileWriteFast.WriteKey("REF4", RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[num].Valor);
							iniFileWriteFast.WriteKey("REF5", RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[num].Valor);
							iniFileWriteFast.WriteKey("REF6", RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[num].Valor);
							iniFileWriteFast.WriteKey("SETP1", RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[num].Valor);
							iniFileWriteFast.WriteKey("SETP2", RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[num].Valor);
							iniFileWriteFast.WriteKey("SETP3", RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[num].Valor);
							iniFileWriteFast.WriteKey("SETP4", RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[num].Valor);
							iniFileWriteFast.WriteKey("SETP5", RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[num].Valor);
							iniFileWriteFast.WriteKey("SETP6", RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 2);
						text = "ATUADOR4_PERIFERICO";
						iniFileWriteFast.WriteSection(text);
						iniFileWriteFast.WriteKey("PERIFERICO", RT_geral.RT_820_360_BD.config_atuador4_perif[0].Valor);
						iniFileWriteFast.WriteKey("FORMATO", RT_geral.RT_820_360_BD.config_atuador4_formato[0].Valor);
						iniFileWriteFast.WriteKey("BASE10", RT_geral.RT_820_360_BD.config_atuador4_base10[0].Valor);
						iniFileWriteFast.WriteKey("END_MEM", RT_geral.RT_820_360_BD.config_atuador4_mem[0].Valor);
						iniFileWriteFast.WriteKey("VARIAVEL1", RT_geral.RT_820_360_BD.config_atuador4_var1[0].Valor);
						iniFileWriteFast.WriteKey("ESCALA1", RT_geral.RT_820_360_BD.config_atuador4_escala1[0].Valor);
						iniFileWriteFast.WriteKey("VARIAVEL2", RT_geral.RT_820_360_BD.config_atuador4_var2[0].Valor);
						iniFileWriteFast.WriteKey("ESCALA2", RT_geral.RT_820_360_BD.config_atuador4_escala2[0].Valor);
						iniFileWriteFast.WriteKey("HISTERESE", RT_geral.RT_820_360_BD.config_atuador4_histerese[0].Valor);
						iniFileWriteFast.WriteKey("V1BAIXO", RT_geral.RT_820_360_BD.config_atuador4_v1baixo[0].Valor);
						iniFileWriteFast.WriteKey("V1ALTO", RT_geral.RT_820_360_BD.config_atuador4_v1alto[0].Valor);
						iniFileWriteFast.WriteKey("V2BAIXO", RT_geral.RT_820_360_BD.config_atuador4_v2baixo[0].Valor);
						iniFileWriteFast.WriteKey("V2ALTO", RT_geral.RT_820_360_BD.config_atuador4_v2alto[0].Valor);
						iniFileWriteFast.LineSpace();
						num = 0;
						do
						{
							text = string.Format("ATUADOR4_VARIAVEL1_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("HORA", RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[num].Valor);
							iniFileWriteFast.WriteKey("MINUTO", RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[num].Valor);
							iniFileWriteFast.WriteKey("REF1", RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[num].Valor);
							iniFileWriteFast.WriteKey("REF2", RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[num].Valor);
							iniFileWriteFast.WriteKey("REF3", RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[num].Valor);
							iniFileWriteFast.WriteKey("REF4", RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[num].Valor);
							iniFileWriteFast.WriteKey("REF5", RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[num].Valor);
							iniFileWriteFast.WriteKey("REF6", RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[num].Valor);
							iniFileWriteFast.WriteKey("SETP1", RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[num].Valor);
							iniFileWriteFast.WriteKey("SETP2", RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[num].Valor);
							iniFileWriteFast.WriteKey("SETP3", RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[num].Valor);
							iniFileWriteFast.WriteKey("SETP4", RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[num].Valor);
							iniFileWriteFast.WriteKey("SETP5", RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[num].Valor);
							iniFileWriteFast.WriteKey("SETP6", RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 2);
						num = 0;
						do
						{
							text = string.Format("ATUADOR4_VARIAVEL2_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("REF1", RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[num].Valor);
							iniFileWriteFast.WriteKey("REF2", RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[num].Valor);
							iniFileWriteFast.WriteKey("REF3", RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[num].Valor);
							iniFileWriteFast.WriteKey("REF4", RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[num].Valor);
							iniFileWriteFast.WriteKey("REF5", RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[num].Valor);
							iniFileWriteFast.WriteKey("REF6", RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[num].Valor);
							iniFileWriteFast.WriteKey("SETP1", RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[num].Valor);
							iniFileWriteFast.WriteKey("SETP2", RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[num].Valor);
							iniFileWriteFast.WriteKey("SETP3", RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[num].Valor);
							iniFileWriteFast.WriteKey("SETP4", RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[num].Valor);
							iniFileWriteFast.WriteKey("SETP5", RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[num].Valor);
							iniFileWriteFast.WriteKey("SETP6", RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 2);
						iniFileWriteFast.WriteSection("REPETIDORA");
						iniFileWriteFast.WriteKey("MODO_REPETIDORA", RT_geral.RT_820_360_BD.modo_repetidora.Valor);
						iniFileWriteFast.WriteKey("ENDERECO", RT_geral.RT_820_360_BD.End_repetidora.Valor);
						iniFileWriteFast.WriteKey("NUMERO_REPETIDORAS", RT_geral.RT_820_360_BD.Num_repetidoras.Valor);
						num = 0;
						do
						{
							text = string.Format("RPT{0}", num + 1);
							iniFileWriteFast.WriteKey(text, RT_geral.RT_820_360_BD.Repetidoras[num].Valor);
							num++;
						}
						while (num <= 49);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						string[] array = new string[]
						{
							"L1",
							"D1",
							"L2",
							"D2",
							"L3",
							"D3",
							"L4",
							"D4",
							"L5",
							"D5",
							"L6",
							"D6"
						};
						num = 0;
						do
						{
							text = string.Format("TIMER{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							int num2 = 0;
							int num3 = array.Length - 1;
							for (int i = num2; i <= num3; i++)
							{
								iniFileWriteFast.WriteKey(array[i], RT_geral.RT_820_360_BD.Timer_Horario[num][i].Valor);
							}
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 7);
						this.ToolStripProgressBar_RT_820.PerformStep();
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
						iniFileWriteFast.CloseIniFileWriteFast();
						this.AtualizaMsgTela_RT_820("Arquivo gerado com sucesso!", 0);
						this.Timer_limpa_MSG_820.Enabled = true;
						return;
					}
				}
				else
				{
					this.AtualizaMsgTela_RT_820("Operação Cancelada", 0);
					this.Timer_limpa_MSG_820.Enabled = true;
				}
			}
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x0035CD48 File Offset: 0x0035B148
		private void ToolStripButton_RT_820_Upload_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.Config_sistema.tipo_interface == 1)
			{
				if (Comunicacao.VerificaPortaSerialExiste())
				{
					this.Bloqueia_acoes_RT820();
					this.EncerraEdicaoDeCampos_RT820();
					this.Escrita_RT820_360_conf();
				}
				else
				{
					Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
				}
			}
			else if (Comunicacao.Config_sistema.tipo_interface == 2)
			{
				this.Bloqueia_acoes_RT820();
				this.EncerraEdicaoDeCampos_RT820();
				this.Escrita_RT820_360_conf();
			}
			else
			{
				Interaction.MsgBox("Não existe definição de tipo de interface de comunicação!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
			}
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0035CDCC File Offset: 0x0035B1CC
		private void ToolStripButton_RT_820_novo_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			this.Bloqueia_acoes_RT820();
			this.Inicializa_DadosEStruturaRT820_Default();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			RT_geral.RT_820_360_BD.filename = "";
			this.Atualiza_TelaRT820();
			this.AtualizaMsgTela_RT_820("Arquivo gerado com sucesso!", 0);
			this.Timer_limpa_MSG_820.Enabled = true;
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0035CE28 File Offset: 0x0035B228
		private void ToolStripButton_RT_820_Download_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.Config_sistema.tipo_interface == 1)
			{
				if (Comunicacao.VerificaPortaSerialExiste())
				{
					this.Bloqueia_acoes_RT820();
					this.EncerraEdicaoDeCampos_RT820();
					this.Leitura_RT820_360_conf();
				}
				else
				{
					Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
				}
			}
			else if (Comunicacao.Config_sistema.tipo_interface == 2)
			{
				this.Bloqueia_acoes_RT820();
				this.EncerraEdicaoDeCampos_RT820();
				this.Leitura_RT820_360_conf();
			}
			else
			{
				Interaction.MsgBox("Não existe definição de tipo de interface de comunicação!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
			}
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0035CEAC File Offset: 0x0035B2AC
		public void Leitura_RT820_360_conf()
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
			this.InicializaBarraProgressoTela_RT_820(8);
			this.AtualizaMsgTela_RT_820("Identificação de equipamento - Etapa 1", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(0, 255, 4).Status)
			{
				this.AtualizaMsgTela_RT_820("Equipamento não responde", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Linha_RT.VerificaSeEquipamentoEValido(2, 0, 0, 0, 0, "");
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT820_360(0);
			RT_geral.RT_820_360_flag_setpoint_horario = true;
			RT_geral.RT_820_350_flag_referenciaperiferico = true;
			RT_geral.RT_820_360_flag_atuadoresperiferico = true;
			checked
			{
				if (RT_geral.RT_820_360_BD.Equip.Valor == 820 & RT_geral.RT_820_360_BD.Versao.Valor * 100 + RT_geral.RT_820_360_BD.Build.Valor >= 400 & RT_geral.RT_820_360_BD.Release.Valor >= 12)
				{
					RT_geral.RT_820_360_flag_calha_vazao = true;
				}
				else
				{
					RT_geral.RT_820_360_flag_calha_vazao = false;
				}
				if (RT_geral.RT_820_360_BD.Equip.Valor == 820 & RT_geral.RT_820_360_BD.Versao.Valor * 100 + RT_geral.RT_820_360_BD.Build.Valor >= 400 & RT_geral.RT_820_360_BD.Release.Valor >= 19)
				{
					RT_geral.RT_820_360_flag_saida_analogicoAs = true;
				}
				else
				{
					RT_geral.RT_820_360_flag_saida_analogicoAs = false;
				}
				if (RT_geral.RT_820_360_BD.Equip.Valor == 820 & RT_geral.RT_820_360_BD.Versao.Valor * 100 + RT_geral.RT_820_360_BD.Build.Valor >= 400 & RT_geral.RT_820_360_BD.Release.Valor >= 22)
				{
					RT_geral.RT_820_360_flag_rotativo_motor = true;
				}
				else
				{
					RT_geral.RT_820_360_flag_rotativo_motor = false;
				}
				if (!Mod_MD.Leitura_pagina_multi_interface(2058, 255, 1).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT_820_360_HabilitaExpansao();
				if (RT_geral.RT_820_360_BD.HabExpIO.Valor == 21857)
				{
					this.Atualiza_Expansao_IO_820_360(true);
				}
				else
				{
					this.Atualiza_Expansao_IO_820_360(false);
				}
				this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 2", 2);
				this.ToolStripProgressBar_RT_820.PerformStep();
				if (!Mod_MD.Leitura_pagina_multi_interface(2048, 255, 115).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT820_360(2048);
				this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 3", 2);
				this.ToolStripProgressBar_RT_820.PerformStep();
				if (!Mod_MD.Leitura_pagina_multi_interface(2163, 255, 116).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT820_360(2163);
				if (RT_geral.RT_820_360_flag_rotativo_motor)
				{
					if (!Mod_MD.Leitura_pagina_multi_interface(2279, 255, 12).Status)
					{
						this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
						this.Timer_limpa_MSG_820.Enabled = true;
						return;
					}
					Linha_RT.Atualiza_dados_RT820_360(2279);
				}
				if (RT_geral.RT_820_360_flag_setpoint_horario)
				{
					if (!Mod_MD.Leitura_pagina_multi_interface(22528, RT_geral.RT_820_360_BD.End_estacao1.Valor, 120).Status)
					{
						this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
						this.Timer_limpa_MSG_820.Enabled = true;
						return;
					}
					Linha_RT.Atualiza_dados_RT820_360(22528);
					if (!Mod_MD.Leitura_pagina_multi_interface(22648, RT_geral.RT_820_360_BD.End_estacao1.Valor, 120).Status)
					{
						this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
						this.Timer_limpa_MSG_820.Enabled = true;
						return;
					}
					Linha_RT.Atualiza_dados_RT820_360(22648);
				}
				if (RT_geral.RT_820_360_flag_referenciaperiferico)
				{
					if (!Mod_MD.Leitura_pagina_multi_interface(24576, RT_geral.RT_820_360_BD.End_estacao1.Valor, 60).Status)
					{
						this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
						this.Timer_limpa_MSG_820.Enabled = true;
						return;
					}
					Linha_RT.Atualiza_dados_RT820_360(24576);
				}
				if (RT_geral.RT_820_360_flag_atuadoresperiferico)
				{
					if (!Mod_MD.Leitura_pagina_multi_interface(26624, RT_geral.RT_820_360_BD.End_estacao1.Valor, 87).Status)
					{
						this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
						this.Timer_limpa_MSG_820.Enabled = true;
						return;
					}
					Linha_RT.Atualiza_dados_RT820_360(26624);
					if (!Mod_MD.Leitura_pagina_multi_interface(26711, RT_geral.RT_820_360_BD.End_estacao1.Valor, 87).Status)
					{
						this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
						this.Timer_limpa_MSG_820.Enabled = true;
						return;
					}
					Linha_RT.Atualiza_dados_RT820_360(26711);
					if (!Mod_MD.Leitura_pagina_multi_interface(26798, RT_geral.RT_820_360_BD.End_estacao1.Valor, 87).Status)
					{
						this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
						this.Timer_limpa_MSG_820.Enabled = true;
						return;
					}
					Linha_RT.Atualiza_dados_RT820_360(26798);
					if (!Mod_MD.Leitura_pagina_multi_interface(26885, RT_geral.RT_820_360_BD.End_estacao1.Valor, 87).Status)
					{
						this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
						this.Timer_limpa_MSG_820.Enabled = true;
						return;
					}
					Linha_RT.Atualiza_dados_RT820_360(26885);
				}
				this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 4", 2);
				this.ToolStripProgressBar_RT_820.PerformStep();
				if (!Mod_MD.Leitura_pagina_multi_interface(4096, RT_geral.RT_820_360_BD.End_estacao1.Valor, 52).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT820_360(4096);
				this.AtualizaMsgTela_RT_820("Leitura de configuração - Passo 5", 2);
				this.ToolStripProgressBar_RT_820.PerformStep();
				if (!Mod_MD.Leitura_pagina_multi_interface(8192, RT_geral.RT_820_360_BD.End_estacao1.Valor, 16).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT820_360(8192);
				this.AtualizaMsgTela_RT_820("Leitura de configuração - Passo 6", 2);
				this.ToolStripProgressBar_RT_820.PerformStep();
				if (!Mod_MD.Leitura_pagina_multi_interface(10240, RT_geral.RT_820_360_BD.End_estacao1.Valor, 16).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT820_360(10240);
				this.AtualizaMsgTela_RT_820("Leitura de configuração - Passo 7", 2);
				this.ToolStripProgressBar_RT_820.PerformStep();
				if (!Mod_MD.Leitura_pagina_multi_interface(12288, RT_geral.RT_820_360_BD.End_estacao1.Valor, 16).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT820_360(12288);
				this.AtualizaMsgTela_RT_820("Leitura de configuração - Passo 8", 2);
				this.ToolStripProgressBar_RT_820.PerformStep();
				if (!Mod_MD.Leitura_pagina_multi_interface(30720, RT_geral.RT_820_360_BD.End_estacao1.Valor, 96).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT820_360(30720);
				this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 9", 2);
				if (!Mod_MD.Leitura_pagina_multi_interface(28672, RT_geral.RT_820_360_BD.End_estacao1.Valor, 50).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT820_360(28672);
				this.Atualiza_TelaRT820();
				this.AtualizaMsgTela_RT_820("Configuração lida com sucesso", 0);
				this.ToolStripProgressBar_RT_820.PerformStep();
				this.Timer_limpa_MSG_820.Enabled = true;
			}
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x0035D65C File Offset: 0x0035BA5C
		public void Escrita_RT820_360_conf()
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
			this.InicializaBarraProgressoTela_RT_820(14);
			this.AtualizaMsgTela_RT_820("Identificação de equipamento - Etapa 1", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(0, 255, 4).Status)
			{
				this.AtualizaMsgTela_RT_820("Equipamento não responde", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Linha_RT.VerificaSeEquipamentoEValido(2, 0, 0, 0, 0, "");
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(0);
			RT_geral.RT_820_300_flag_setpoint_horario = true;
			RT_geral.RT_820_350_flag_referenciaperiferico = true;
			RT_geral.RT_820_350_flag_atuadoresperiferico = true;
			if (RT_geral.RT_820_360_BD.Equip.Valor == 820 & checked(RT_geral.RT_820_360_BD.Versao.Valor * 100 + RT_geral.RT_820_360_BD.Build.Valor) >= 400 & RT_geral.RT_820_360_BD.Release.Valor >= 22)
			{
				RT_geral.RT_820_360_flag_rotativo_motor = true;
			}
			else
			{
				RT_geral.RT_820_360_flag_rotativo_motor = false;
			}
			this.AtualizaMsgTela_RT_820("Habilita escrita de dados Pag 1 - Etapa 2", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Escrita de configuração Pag 1A - Etapa 3", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(2048, 4, 0).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Escrita de configuração Pag 1B - Etapa 4", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(2163, 4, 0).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			if (RT_geral.RT_820_360_flag_rotativo_motor && !Mod_MD.Escrita_pagina_RT_multi_interface(2279, 4, 0).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Salva Página 1 - Etapa 5", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Escrita de configuração Pag 2 - Etapa 6", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(4096, 4, 0).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Salva Página 2 - Etapa 7", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			if (RT_geral.RT_820_300_flag_setpoint_horario)
			{
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				this.AtualizaMsgTela_RT_820("Salva Página 11 ", 0);
				if (!Mod_MD.Escrita_pagina_RT_multi_interface(22528, 4, 0).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				this.AtualizaMsgTela_RT_820("Salva Página 11 ", 0);
				if (!Mod_MD.Escrita_pagina_RT_multi_interface(22648, 4, 0).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
			}
			if (RT_geral.RT_820_350_flag_referenciaperiferico)
			{
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				this.AtualizaMsgTela_RT_820("Salva Página 12 ", 0);
				if (!Mod_MD.Escrita_pagina_RT_multi_interface(24576, 4, 0).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
			}
			if (RT_geral.RT_820_350_flag_atuadoresperiferico)
			{
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				this.AtualizaMsgTela_RT_820("Salva Página 12 ", 0);
				if (!Mod_MD.Escrita_pagina_RT_multi_interface(26624, 4, 0).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				this.AtualizaMsgTela_RT_820("Salva Página 12 ", 0);
				if (!Mod_MD.Escrita_pagina_RT_multi_interface(26711, 4, 0).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				this.AtualizaMsgTela_RT_820("Salva Página 12 ", 0);
				if (!Mod_MD.Escrita_pagina_RT_multi_interface(26798, 4, 0).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				this.AtualizaMsgTela_RT_820("Salva Página 12 ", 0);
				if (!Mod_MD.Escrita_pagina_RT_multi_interface(26885, 4, 0).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
				if (!ctrl_RESP_.Status)
				{
					this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Escrita de configuração Pag 4 - Etapa 8", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(8192, 4, 0).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Salva Página 4 - Etapa 9", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Escrita de configuração Pag 5 - Etapa 10", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(10240, 4, 0).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Salva Página 5 - Etapa 11", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Escrita de configuração Pag 6 - Etapa 12", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(12288, 4, 0).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Salva Página 6 - Etapa 13", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Controle_escrita_multi_interface(21930).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Escrita de configuração Pag 7 - Etapa 13", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(30720, 4, 0).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21845);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Escrita de configuração Pag 14 ", 0);
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(28672, 4, 0).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Salva Página 14", 0);
			ctrl_RESP_ = Mod_MD.Controle_escrita_multi_interface(21930);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Escrita realizada com sucesso", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			this.Timer_limpa_MSG_820.Enabled = true;
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x0035E140 File Offset: 0x0035C540
		public void Bloqueia_acoes_RT820()
		{
			this.ToolStripButton_RT_820_Abrir.Enabled = false;
			this.ToolStripButton_RT_820_Download.Enabled = false;
			this.ToolStripButton_RT_820_novo.Enabled = false;
			this.ToolStripButton_RT_820_Salvar.Enabled = false;
			this.ToolStripButton_RT_820_Upload.Enabled = false;
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x0035E180 File Offset: 0x0035C580
		public void EncerraEdicaoDeCampos_RT820()
		{
			this.DataGridView_end_rep_RT820.EndEdit();
			this.DataGridView_grupos_820.EndEdit();
			this.DataGridView_parametros_EA_820.EndEdit();
			this.DataGridView_periferico1_RT820.EndEdit();
			this.DataGridView_processo_820.EndEdit();
			this.DataGridView_RT820_ED.EndEdit();
			this.DataGridView_setpoints_820.EndEdit();
			this.DataGridView_timer_RT820.EndEdit();
			this.DataGridView_vazoes_RT820.EndEdit();
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x0035E1FC File Offset: 0x0035C5FC
		private void ToolStripButton_RT820_Imprimir_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			using (EnhancedPrintPreviewDialog enhancedPrintPreviewDialog = new EnhancedPrintPreviewDialog())
			{
				enhancedPrintPreviewDialog.Document = this.PrintDocument1;
				enhancedPrintPreviewDialog.ShowDialog();
			}
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x0035E244 File Offset: 0x0035C644
		[MethodImpl(72)]
		private void DesenhaRelatorioRT820Pagina01(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, (System.Drawing.FontStyle)3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, (System.Drawing.FontStyle)0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, (System.Drawing.FontStyle)1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_360_BD.Equip.Valor, RT_geral.RT_820_360_BD.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 4, "Dados da Estação", true);
			tabelaLinhaInteria.EscreveTituloValorLinha(1, "Local de Instalação", this.TextBox_nome_RT820.Text, 0, 160);
			tabelaLinhaInteria.EscreveTituloValorLinha(2, "Endereço", this.TextBox_endereco_RT820.Text, 0, 90);
			string valor = "iS800 (" + MyProject.Application.Info.Version.ToString() + ")";
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Configurador", valor, 0, 0);
			string valor2 = string.Concat(new string[]
			{
				"RT",
				RT_geral.RT_820_360_BD.Equip.Valor.ToString(),
				"_",
				RT_geral.RT_820_360_BD.Versao.Valor.ToString(),
				string.Format("{0:D2}", RT_geral.RT_820_360_BD.Build.Valor),
				"  R",
				RT_geral.RT_820_360_BD.Release.Valor.ToString()
			});
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Firmware", valor2, 250, 0);
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Data", string.Concat(new string[]
			{
				DateTime.Today.Day.ToString(),
				"/",
				DateTime.Today.Month.ToString(),
				"/",
				DateTime.Today.Year.ToString()
			}), 550, 0);
			tabelaLinhaInteria.EscreveTituloValorLinha(4, "Arquivo", Path.GetFileName(RT_geral.RT_820_360_BD.filename), 0, 0);
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
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(1, "Endereço do Mestre", this.NumericUpDown_end_mestre_820.Value.ToString(), 0, 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(2, "1° Endereço da Estação", this.NumericUpDown_end1_est_820.Value.ToString(), 0, 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(2, "2° Endereço da Estação", this.NumericUpDown_end2_est_820.Value.ToString(), 250, 450);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(3, "Tempo de PTT (ms)", this.NumericUpDown_temp_ptt_820.Value.ToString() + " ms", 0, 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(3, "Tempo Fora Ar (s)", this.nud_tempoforaar.Value.ToString() + " s", 300, 450);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 5, "Grupo de Controle - Acionamneto - Rotação", true);
			tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Grupo", 0);
			tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Permitidos", 45);
			tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Tempo", 120);
			tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Rotação", 180);
			int num = 1;
			checked
			{
				string valor3;
				do
				{
					valor3 = string.Format("0{0}", num);
					tabelaMeiaLinhaDireita.EscreveValorLinha(num + 1, valor3, 0);
					switch (RT_geral.RT_820_360_BD.grupo_simultaneos[num - 1].Valor)
					{
					case 21856:
						valor3 = "Liberada";
						break;
					case 21857:
						valor3 = "01";
						break;
					case 21858:
						valor3 = "02";
						break;
					case 21859:
						valor3 = "03";
						break;
					case 21860:
						valor3 = "04";
						break;
					case 21861:
						valor3 = "05";
						break;
					case 21862:
						valor3 = "06";
						break;
					case 21863:
						valor3 = "07";
						break;
					case 21864:
						valor3 = "08";
						break;
					}
					tabelaMeiaLinhaDireita.EscreveValorLinha(num + 1, valor3, 60);
					valor3 = string.Format("{0}", RT_geral.RT_820_360_BD.grupo_tempo_entre_acionamentos[num - 1].Valor);
					tabelaMeiaLinhaDireita.EscreveValorLinha(num + 1, valor3, 130);
					valor3 = RT_geral.RT_820_DataGrigViewGruposColunas[2].LinhasMenu[RT_geral.RT_820_360_BD.grupo_rotativo_motores[num - 1].Indice];
					tabelaMeiaLinhaDireita.EscreveValorLinha(num + 1, valor3, 180);
					num++;
				}
				while (num <= 4);
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda.GetNextLineAvailable(), 2, "Parâmetros das Interfaces", true);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "BaudRate COM1", 0);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "BaudRate COM2", 250);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(2, "Habilita Expansão I/O", 0);
				valor3 = perifericos.ListaBaudRate[RT_geral.RT_820_360_BD.BaudRateCOM1.Indice].nome_impressao;
				tabelaMeiaLinhaEsquerda2.EscreveValorLinha(1, valor3, 130);
				valor3 = perifericos.ListaBaudRate[RT_geral.RT_820_360_BD.BaudRateCOM2.Indice].nome_impressao;
				tabelaMeiaLinhaEsquerda2.EscreveValorLinha(1, valor3, 380);
				valor3 = "???";
				switch (RT_geral.RT_820_360_BD.HabExpIO.Valor)
				{
				case 21856:
					valor3 = "Não";
					break;
				case 21857:
					valor3 = "Sim";
					break;
				}
				tabelaMeiaLinhaEsquerda2.EscreveValorLinha(2, valor3, 150);
				int[] array = new int[]
				{
					0,
					40,
					100,
					180,
					260,
					330,
					410,
					460,
					520,
					570,
					665,
					725,
					780,
					830,
					875,
					925
				};
				TabelaLinhaInteria tabelaLinhaInteria3 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda2.GetNextLineAvailable(), 2, "Parâmetros de Controle", false);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "\r\nCTRL", array[0]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Aciona-\r\nmento", array[1]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ret Acio-\r\nnamento", array[2]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Desacio-\r\nnamento", array[3]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Retorno\r\nDesacio.", array[4]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Seleção\r\nRemoto", array[5]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Bloq\r\nDigital", array[6]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Libera\r\nDigital", array[7]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Seleção\r\nReverso", array[8]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Modo\r\nControle", array[9]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Grupo\r\nControle", array[10]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Partidas", array[11]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Tempo\r\nPartida", array[12]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Tempo\r\nParada", array[13]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "T. Mín\r\nParado", array[14]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "T. Mín\r\nOper.", array[15]);
				tabelaLinhaInteria3.AdicionaLinha();
				tabelaLinhaInteria3.AdicionaLinha();
				tabelaLinhaInteria3.AdicionaLinha();
				tabelaLinhaInteria3.AdicionaLinha();
				tabelaLinhaInteria3.AdicionaLinha();
				tabelaLinhaInteria3.AdicionaLinha();
				tabelaLinhaInteria3.AdicionaLinha();
				tabelaLinhaInteria3.AdicionaLinha();
				num = 0;
				do
				{
					valor3 = string.Format("0{0}", num + 1);
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, array[0] + 10);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_820_360_BD.ctrl_acionamento[num].Valor)
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
					case 21865:
						valor3 = "SD-09";
						break;
					case 21866:
						valor3 = "SD-10";
						break;
					case 21867:
						valor3 = "SD-11";
						break;
					case 21868:
						valor3 = "SD-12";
						break;
					case 21873:
						valor3 = "Perif-01";
						break;
					case 21874:
						valor3 = "Perif-02";
						break;
					case 21875:
						valor3 = "Perif-03";
						break;
					case 21876:
						valor3 = "Perif-04";
						break;
					case 21877:
						valor3 = "Perif-05";
						break;
					}
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, array[1] + 5);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_820_360_BD.ctrl_ret_acionamento[num].Valor)
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
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, array[2] + 5);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_820_360_BD.ctrl_desligamento[num].Valor)
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
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, array[3] + 5);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_820_360_BD.ctrl_ret_desligamento[num].Valor)
					{
					case 21856:
						valor3 = "Desativa";
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
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, array[4] + 5);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_820_360_BD.ctrl_ED_selecao[num].Valor)
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
					case 21865:
						valor3 = "ED-09";
						break;
					case 21866:
						valor3 = "ED-10";
						break;
					case 21867:
						valor3 = "ED-11";
						break;
					case 21868:
						valor3 = "ED-12";
						break;
					case 21869:
						valor3 = "ED-13";
						break;
					case 21870:
						valor3 = "ED-14";
						break;
					case 21871:
						valor3 = "ED-15";
						break;
					case 21872:
						valor3 = "ED-16";
						break;
					case 21873:
						valor3 = "ED01 BKP";
						break;
					case 21874:
						valor3 = "ED02 BKP";
						break;
					case 21875:
						valor3 = "ED03 BKP";
						break;
					case 21876:
						valor3 = "ED04 BKP";
						break;
					case 21877:
						valor3 = "ED05 BKP";
						break;
					case 21878:
						valor3 = "ED06 BKP";
						break;
					case 21879:
						valor3 = "ED07 BKP";
						break;
					case 21880:
						valor3 = "ED08 BKP";
						break;
					case 21881:
						valor3 = "ED09 BKP";
						break;
					case 21882:
						valor3 = "ED10 BKP";
						break;
					case 21883:
						valor3 = "ED11 BKP";
						break;
					case 21884:
						valor3 = "ED12 BKP";
						break;
					case 21885:
						valor3 = "ED13 BKP";
						break;
					case 21886:
						valor3 = "ED14 BKP";
						break;
					case 21887:
						valor3 = "ED15 BKP";
						break;
					case 21888:
						valor3 = "ED16 BKP";
						break;
					}
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, array[5]);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_820_360_BD.ctrl_ED_bloqueio[num].Valor)
					{
					case 21856:
						valor3 = "S. Bloq";
						break;
					case 21857:
						valor3 = "ED-01";
						break;
					case 21858:
						valor3 = "ED-01 R";
						break;
					case 21859:
						valor3 = "ED-02";
						break;
					case 21860:
						valor3 = "ED-02 R";
						break;
					case 21861:
						valor3 = "ED-03";
						break;
					case 21862:
						valor3 = "ED-03 R";
						break;
					case 21863:
						valor3 = "ED-04";
						break;
					case 21864:
						valor3 = "ED-04 R";
						break;
					case 21865:
						valor3 = "ED-05";
						break;
					case 21866:
						valor3 = "ED-05 R";
						break;
					case 21867:
						valor3 = "ED-06";
						break;
					case 21868:
						valor3 = "ED-06 R";
						break;
					case 21869:
						valor3 = "ED-07";
						break;
					case 21870:
						valor3 = "ED-07 R";
						break;
					case 21871:
						valor3 = "ED-08";
						break;
					case 21872:
						valor3 = "ED-08 R";
						break;
					}
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, array[6]);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_820_360_BD.ctrl_ED_liberacao[num].Valor)
					{
					case 21856:
						valor3 = "S. Lib";
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
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, array[7]);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_820_360_BD.ctrl_reverso[num].Valor)
					{
					case 21856:
						valor3 = "Desab.";
						break;
					case 21857:
						valor3 = "Habilit.";
						break;
					}
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, array[8]);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_820_360_BD.ctrl_modo[num].Valor)
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
					case 21859:
						valor3 = "Telec. com Falha";
						break;
					}
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, array[9] + 5);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_820_360_BD.ctrl_agrupamento[num].Valor)
					{
					case 21856:
						valor3 = "Nenhum";
						break;
					case 21857:
						valor3 = "01";
						break;
					case 21858:
						valor3 = "02";
						break;
					case 21859:
						valor3 = "03";
						break;
					case 21860:
						valor3 = "04";
						break;
					}
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, array[10] + 5);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					valor3 = "????";
					if (RT_geral.RT_820_360_BD.ctrl_partidas[num].Valor == 21856)
					{
						valor3 = "Desab.";
					}
					else if (RT_geral.RT_820_360_BD.ctrl_partidas[num].Valor >= 21857 & RT_geral.RT_820_360_BD.ctrl_partidas[num].Valor <= 21876)
					{
						valor3 = string.Format("0{0}", RT_geral.RT_820_360_BD.ctrl_partidas[num].Valor - 21856);
					}
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, array[11] + 5);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, RT_geral.RT_820_360_BD.ctrl_tempo_max_partida[num].Valor.ToString(), array[12] + 5);
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, RT_geral.RT_820_360_BD.ctrl_tempo_max_parada[num].Valor.ToString(), array[13] + 5);
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, RT_geral.RT_820_360_BD.ctrl_tempo_min_parado[num].Valor.ToString(), array[14] + 5);
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, RT_geral.RT_820_360_BD.ctrl_tempo_min_operando[num].Valor.ToString(), array[15] + 5);
					num++;
				}
				while (num <= 7);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x0035F88C File Offset: 0x0035DC8C
		private void DesenhaRelatorioRT820Pagina02(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, (System.Drawing.FontStyle)3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, (System.Drawing.FontStyle)0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, (System.Drawing.FontStyle)1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_360_BD.Equip.Valor, RT_geral.RT_820_360_BD.Versao.Valor);
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 5, 17, "Escala EA", true);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "EA", 0);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Range", 70);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Início", 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Fim", 340);
			int num = 0;
			checked
			{
				do
				{
					tabelaMeiaLinhaEsquerda.EscreveTituloLinha(num + 2, string.Format("{0:D2}", num + 1), 0);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(num + 2, RT_geral.RT_820_360_BD.EA_Range[num].Valor.ToString(), 80);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(num + 2, RT_geral.RT_820_360_BD.EA_Inicio[num].Valor.ToString(), 210);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(num + 2, RT_geral.RT_820_360_BD.EA_Fim[num].Valor.ToString(), 350);
					num++;
				}
				while (num <= 15);
				TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, 5, 17, "Entrada Digital", true);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "ED", 0);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Função", 200);
				string valor = "";
				num = 0;
				do
				{
					int valor2 = RT_geral.RT_820_360_BD.config_ED[num].Valor;
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
					tabelaMeiaLinhaDireita.EscreveTituloLinha(num + 2, string.Format("{0:D2}", num + 1), 0);
					tabelaMeiaLinhaDireita.EscreveValorLinha(num + 2, valor, 190);
					num++;
				}
				while (num <= 15);
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaDireita.GetNextLineAvailable(), 2, "Filtro", true);
				tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(1, "Filtro Intervalo (ms)", this.NumericUpDown_intervalo_filtro_820.Value.ToString(), 0, 180);
				tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(2, "Filtro Amostras", this.NumericUpDown_tamanho_filtro_820.Value.ToString(), 0, 180);
				TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita2 = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaDireita.GetNextLineAvailable(), 6, "Saídas Analógicas", true);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(1, "SA 01 Origem", perifericos.Lista_SA_Origem_RT820_400[RT_geral.RT_820_360_BD.saida_SA_origem[0].Indice].nome_impressao, 0, 180);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(2, "SA 01 Início", Conversions.ToString(RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0].Valor), 0, 180);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(3, "SA 01 Fim", Conversions.ToString(RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[0].Valor), 0, 180);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(4, "SA 02 Origem", perifericos.Lista_SA_Origem_RT820_400[RT_geral.RT_820_360_BD.saida_SA_origem[1].Indice].nome_impressao, 0, 180);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(5, "SA 02 Início", Conversions.ToString(RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[1].Valor), 0, 180);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(6, "SA 02 Fim", Conversions.ToString(RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[1].Valor), 0, 180);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x0035FD78 File Offset: 0x0035E178
		private void DesenhaRelatorioRT820Pagina03(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, (System.Drawing.FontStyle)3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, (System.Drawing.FontStyle)0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, (System.Drawing.FontStyle)1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_360_BD.Equip.Valor, RT_geral.RT_820_360_BD.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 9, "SetPoint", true);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Ctrl", 0);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Variável Controle", 80);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Nivel Baixo", 220);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Nível Alto", 320);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Variável de Bloqueio", 410);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Nível de Bloqueio", 650);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Nível de Liberação", 800);
			int num = 0;
			checked
			{
				do
				{
					string text = string.Format("{0:D2}", num + 1);
					tabelaLinhaInteria.EscreveTituloLinha(num + 2, text, 0);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					string text = "???";
					switch (RT_geral.RT_820_360_BD.Setpoints_ctrl_variavel[num].Valor)
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
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 90);
					tabelaLinhaInteria.EscreveValorLinha(num + 2, RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_baixo[num].Valor.ToString(), 230);
					tabelaLinhaInteria.EscreveValorLinha(num + 2, RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_alto[num].Valor.ToString(), 330);
					tabelaLinhaInteria.EscreveValorLinha(num + 2, RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_bloqueio[num].Valor.ToString(), 660);
					tabelaLinhaInteria.EscreveValorLinha(num + 2, RT_geral.RT_820_360_BD.Setpoints_ctrl_nivel_liberacao[num].Valor.ToString(), 810);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					string text = "???";
					switch (RT_geral.RT_820_360_BD.Setpoints_ctrl_bloqueio[num].Valor)
					{
					case 21856:
						text = "Bloqueio Desabilitado";
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
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 420);
					num++;
				}
				while (num <= 7);
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria.GetNextLineAvailable() + 2, 11, "SetPoint Horário - Controle 1", true);
				tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Faixa", 0);
				tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Ativar", 70);
				tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Hora", 140);
				tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Minuto", 200);
				tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Alto", 290);
				tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Baixo", 370);
				int num2 = 0;
				num = 0;
				do
				{
					tabelaMeiaLinhaEsquerda.EscreveTituloLinha(2 + num, string.Format("{0}", num + 1), 10);
					if (RT_geral.RT_820_360_BD.setpoint_horario[num2 + num].Hora.Valor > 128)
					{
						tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num, "Sim", 80);
					}
					else
					{
						tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num, "Não", 80);
					}
					int num3 = RT_geral.RT_820_360_BD.setpoint_horario[num2 + num].Hora.Valor & 127;
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num, string.Format("{0}", num3), 150);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num2 + num].Minuto.Valor;
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num, string.Format("{0}", num3), 210);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num2 + num].Alto.Valor;
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num, string.Format("{0}", num3), 300);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num2 + num].Baixo.Valor;
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num, string.Format("{0}", num3), 380);
					num++;
				}
				while (num <= 9);
				TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria.GetNextLineAvailable() + 2, 11, "SetPoint Horário - Controle 2", true);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Faixa", 0);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Ativar", 70);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Hora", 140);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Minuto", 200);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Alto", 290);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Baixo", 370);
				num2 = 10;
				num = 0;
				do
				{
					tabelaMeiaLinhaDireita.EscreveTituloLinha(2 + num, string.Format("{0}", num + 1), 10);
					if (RT_geral.RT_820_360_BD.setpoint_horario[num2 + num].Hora.Valor > 128)
					{
						tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num, "Sim", 80);
					}
					else
					{
						tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num, "Não", 80);
					}
					int num3 = RT_geral.RT_820_360_BD.setpoint_horario[num2 + num].Hora.Valor & 127;
					tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num, string.Format("{0}", num3), 150);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num2 + num].Minuto.Valor;
					tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num, string.Format("{0}", num3), 210);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num2 + num].Alto.Valor;
					tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num, string.Format("{0}", num3), 300);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num2 + num].Baixo.Valor;
					tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num, string.Format("{0}", num3), 380);
					num++;
				}
				while (num <= 9);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x003606FC File Offset: 0x0035EAFC
		private void DesenhaRelatorioRT820Pagina04(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, (System.Drawing.FontStyle)3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, (System.Drawing.FontStyle)0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, (System.Drawing.FontStyle)1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_360_BD.Equip.Valor, RT_geral.RT_820_360_BD.Versao.Valor);
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 5, 11, "SetPoint Horário - Controle 3", true);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Faixa", 0);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Ativar", 70);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Hora", 140);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Minuto", 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Alto", 290);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Baixo", 370);
			int num = 20;
			int num2 = 0;
			checked
			{
				do
				{
					tabelaMeiaLinhaEsquerda.EscreveTituloLinha(2 + num2, string.Format("{0}", num2 + 1), 10);
					if (RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Hora.Valor > 128)
					{
						tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num2, "Sim", 80);
					}
					else
					{
						tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num2, "Não", 80);
					}
					int num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Hora.Valor & 127;
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 150);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Minuto.Valor;
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 210);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Alto.Valor;
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 300);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Baixo.Valor;
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 380);
					num2++;
				}
				while (num2 <= 9);
				TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, 5, 11, "SetPoint Horário - Controle 4", true);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Faixa", 0);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Ativar", 70);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Hora", 140);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Minuto", 200);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Alto", 290);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Baixo", 370);
				num = 30;
				num2 = 0;
				do
				{
					tabelaMeiaLinhaDireita.EscreveTituloLinha(2 + num2, string.Format("{0}", num2 + 1), 10);
					if (RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Hora.Valor > 128)
					{
						tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num2, "Sim", 80);
					}
					else
					{
						tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num2, "Não", 80);
					}
					int num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Hora.Valor & 127;
					tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 150);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Minuto.Valor;
					tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 210);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Alto.Valor;
					tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 300);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Baixo.Valor;
					tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 380);
					num2++;
				}
				while (num2 <= 9);
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda.GetNextLineAvailable(), 11, "SetPoint Horário - Controle 5", true);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "Faixa", 0);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "Ativar", 70);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "Hora", 140);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "Minuto", 200);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "Alto", 290);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "Baixo", 370);
				num = 40;
				num2 = 0;
				do
				{
					tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(2 + num2, string.Format("{0}", num2 + 1), 10);
					if (RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Hora.Valor > 128)
					{
						tabelaMeiaLinhaEsquerda2.EscreveValorLinha(2 + num2, "Sim", 80);
					}
					else
					{
						tabelaMeiaLinhaEsquerda2.EscreveValorLinha(2 + num2, "Não", 80);
					}
					int num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Hora.Valor & 127;
					tabelaMeiaLinhaEsquerda2.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 150);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Minuto.Valor;
					tabelaMeiaLinhaEsquerda2.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 210);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Alto.Valor;
					tabelaMeiaLinhaEsquerda2.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 300);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Baixo.Valor;
					tabelaMeiaLinhaEsquerda2.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 380);
					num2++;
				}
				while (num2 <= 9);
				TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita2 = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda.GetNextLineAvailable(), 11, "SetPoint Horário - Controle 6", true);
				tabelaMeiaLinhaDireita2.EscreveTituloLinha(1, "Faixa", 0);
				tabelaMeiaLinhaDireita2.EscreveTituloLinha(1, "Ativar", 70);
				tabelaMeiaLinhaDireita2.EscreveTituloLinha(1, "Hora", 140);
				tabelaMeiaLinhaDireita2.EscreveTituloLinha(1, "Minuto", 200);
				tabelaMeiaLinhaDireita2.EscreveTituloLinha(1, "Alto", 290);
				tabelaMeiaLinhaDireita2.EscreveTituloLinha(1, "Baixo", 370);
				num = 50;
				num2 = 0;
				do
				{
					tabelaMeiaLinhaDireita2.EscreveTituloLinha(2 + num2, string.Format("{0}", num2 + 1), 10);
					if (RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Hora.Valor > 128)
					{
						tabelaMeiaLinhaDireita2.EscreveValorLinha(2 + num2, "Sim", 80);
					}
					else
					{
						tabelaMeiaLinhaDireita2.EscreveValorLinha(2 + num2, "Não", 80);
					}
					int num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Hora.Valor & 127;
					tabelaMeiaLinhaDireita2.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 150);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Minuto.Valor;
					tabelaMeiaLinhaDireita2.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 210);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Alto.Valor;
					tabelaMeiaLinhaDireita2.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 300);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Baixo.Valor;
					tabelaMeiaLinhaDireita2.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 380);
					num2++;
				}
				while (num2 <= 9);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00361038 File Offset: 0x0035F438
		private void DesenhaRelatorioRT820Pagina05(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, (System.Drawing.FontStyle)3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, (System.Drawing.FontStyle)0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, (System.Drawing.FontStyle)1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_360_BD.Equip.Valor, RT_geral.RT_820_360_BD.Versao.Valor);
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 5, 11, "SetPoint Horário - Controle 7", true);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Faixa", 0);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Ativar", 70);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Hora", 140);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Minuto", 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Alto", 290);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Baixo", 370);
			int num = 60;
			int num2 = 0;
			checked
			{
				do
				{
					tabelaMeiaLinhaEsquerda.EscreveTituloLinha(2 + num2, string.Format("{0}", num2 + 1), 10);
					if (RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Hora.Valor > 128)
					{
						tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num2, "Sim", 80);
					}
					else
					{
						tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num2, "Não", 80);
					}
					int num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Hora.Valor & 127;
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 150);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Minuto.Valor;
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 210);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Alto.Valor;
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 300);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Baixo.Valor;
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 380);
					num2++;
				}
				while (num2 <= 9);
				TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, 5, 11, "SetPoint Horário - Controle 8", true);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Faixa", 0);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Ativar", 70);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Hora", 140);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Minuto", 200);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Alto", 290);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Baixo", 370);
				num = 70;
				num2 = 0;
				do
				{
					tabelaMeiaLinhaDireita.EscreveTituloLinha(2 + num2, string.Format("{0}", num2 + 1), 10);
					if (RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Hora.Valor > 128)
					{
						tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num2, "Sim", 80);
					}
					else
					{
						tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num2, "Não", 80);
					}
					int num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Hora.Valor & 127;
					tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 150);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Minuto.Valor;
					tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 210);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Alto.Valor;
					tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 300);
					num3 = RT_geral.RT_820_360_BD.setpoint_horario[num + num2].Baixo.Valor;
					tabelaMeiaLinhaDireita.EscreveValorLinha(2 + num2, string.Format("{0}", num3), 380);
					num2++;
				}
				while (num2 <= 9);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x0036155C File Offset: 0x0035F95C
		private void DesenhaRelatorioRT820Pagina06(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, (System.Drawing.FontStyle)3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, (System.Drawing.FontStyle)0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, (System.Drawing.FontStyle)1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_360_BD.Equip.Valor, RT_geral.RT_820_360_BD.Versao.Valor);
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 5, 9, "Vazão - Entrada Digital", true);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Vazão", 0);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Entrada", 200);
			int i = 0;
			checked
			{
				do
				{
					string text = string.Format("{0:D2}", i + 1);
					tabelaMeiaLinhaEsquerda.EscreveTituloLinha(i + 2, text, 0);
					text = "???";
					switch (RT_geral.RT_820_360_BD.config_vazao[i].Valor)
					{
					case 21856:
						text = "Leitura Desabilitada";
						break;
					case 21857:
						text = "EA 01";
						break;
					case 21858:
						text = "EA 02";
						break;
					case 21859:
						text = "EA 03";
						break;
					case 21860:
						text = "EA 04";
						break;
					case 21861:
						text = "EA 05";
						break;
					case 21862:
						text = "EA 06";
						break;
					case 21863:
						text = "EA 07";
						break;
					case 21864:
						text = "EA 08";
						break;
					case 21865:
						text = "EA 09";
						break;
					case 21866:
						text = "EA 10";
						break;
					case 21867:
						text = "EA 11";
						break;
					case 21868:
						text = "EA 12";
						break;
					case 21869:
						text = "EA 13";
						break;
					case 21870:
						text = "EA 14";
						break;
					case 21871:
						text = "EA 15";
						break;
					case 21872:
						text = "EA 16";
						break;
					case 21873:
						text = "ED 01";
						break;
					case 21874:
						text = "EA 01 R";
						break;
					case 21875:
						text = "ED 02";
						break;
					case 21876:
						text = "EA 02 R";
						break;
					case 21877:
						text = "ED 03";
						break;
					case 21878:
						text = "EA 03 R";
						break;
					case 21879:
						text = "ED 04";
						break;
					case 21880:
						text = "EA 04 R";
						break;
					case 21881:
						text = "ED 05";
						break;
					case 21882:
						text = "EA 05 R";
						break;
					case 21883:
						text = "ED 06";
						break;
					case 21884:
						text = "EA 06 R";
						break;
					case 21885:
						text = "ED 07";
						break;
					case 21886:
						text = "EA 07 R";
						break;
					case 21887:
						text = "ED 08";
						break;
					case 21888:
						text = "EA 08 R";
						break;
					case 21889:
						text = "ED 09";
						break;
					case 21890:
						text = "EA 09 R";
						break;
					case 21891:
						text = "ED 10";
						break;
					case 21892:
						text = "EA 10 R";
						break;
					case 21893:
						text = "ED 11";
						break;
					case 21894:
						text = "EA 11 R";
						break;
					case 21895:
						text = "ED 12";
						break;
					case 21896:
						text = "EA 12 R";
						break;
					case 21897:
						text = "ED 13";
						break;
					case 21898:
						text = "EA 13 R";
						break;
					case 21899:
						text = "ED 14";
						break;
					case 21900:
						text = "EA 14 R";
						break;
					case 21901:
						text = "ED 15";
						break;
					case 21902:
						text = "EA 15 R";
						break;
					case 21903:
						text = "ED 16";
						break;
					case 21904:
						text = "EA 16 R";
						break;
					case 21905:
						text = "Calha 1";
						break;
					case 21906:
						text = "Calha 2";
						break;
					}
					tabelaMeiaLinhaEsquerda.EscreveTituloLinha(i + 2, text, 205);
					i++;
				}
				while (i <= 7);
				TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, 5, 3, "Calha", true);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Calha", 0);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "EA", 40);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Tipo", 80);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Fundo (cm)", 240);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "P1 (cm)", 310);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "P2 (cm)", 360);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "P3 (cm)", 410);
				i = 0;
				do
				{
					string text = string.Format("{0:D2}", i + 1);
					tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, text, 0);
					text = RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[RT_geral.RT_820_360_BD.calha_EA[i].Indice];
					tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, text, 40);
					text = RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasMenu[RT_geral.RT_820_360_BD.calha_modelo[i].Indice];
					tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, text, 80);
					text = RT_geral.RT_820_360_BD.calha_fundo[i].Valor.ToString();
					tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, text, 240);
					text = RT_geral.RT_820_360_BD.calha_p1[i].Valor.ToString();
					tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, text, 310);
					text = RT_geral.RT_820_360_BD.calha_p2[i].Valor.ToString();
					tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, text, 360);
					text = RT_geral.RT_820_360_BD.calha_p3[i].Valor.ToString();
					tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, text, 410);
					i++;
				}
				while (i <= 1);
				TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda.GetNextLineAvailable(), 1, "Repetidora", true);
				string item = RT_geral.RT_820_360_BD.modo_repetidora.GetItem();
				tabelaLinhaInteria.EscreveTituloValorLinha(1, "Modo", item, 0, 60);
				tabelaLinhaInteria.EscreveTituloValorLinha(1, "End. Mestre", RT_geral.RT_820_360_BD.End_repetidora.Valor.ToString(), 240, 320);
				tabelaLinhaInteria.EscreveTituloValorLinha(1, "Quantidade End. Repetidos", RT_geral.RT_820_360_BD.Num_repetidoras.Valor.ToString(), 410, 600);
				int num = RT_geral.RT_820_360_BD.Num_repetidoras.Valor / 20;
				if (RT_geral.RT_820_360_BD.Num_repetidoras.Valor > 0)
				{
					if (RT_geral.RT_820_360_BD.Num_repetidoras.Valor % 20 != 0)
					{
						num++;
					}
					int num2 = 1;
					int num3 = num;
					for (i = num2; i <= num3; i++)
					{
						tabelaLinhaInteria.AdicionaLinha();
						string text2 = "";
						int num4 = (i - 1) * 20;
						int num5 = (i - 1) * 20 + 19;
						for (int j = num4; j <= num5; j++)
						{
							if (j + 1 < RT_geral.RT_820_360_BD.Num_repetidoras.Valor)
							{
								text2 = text2 + RT_geral.RT_820_360_BD.Repetidoras[j].Valor.ToString() + ", ";
							}
							else if (j + 1 == RT_geral.RT_820_360_BD.Num_repetidoras.Valor)
							{
								text2 += RT_geral.RT_820_360_BD.Repetidoras[j].Valor.ToString();
								break;
							}
						}
						tabelaLinhaInteria.EscreveValorLinha(i + 1, text2, 50);
					}
				}
				TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria.GetNextLineAvailable(), 10, "Timer", true);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Faixa", 0);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "1", 100);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "2", 250);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "3", 400);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "4", 550);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "5", 700);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "6", 850);
				i = 0;
				do
				{
					string text = string.Format("{0:D2}", i + 1);
					tabelaLinhaInteria2.EscreveTituloLinha(i + 3, text, 0);
					i++;
				}
				while (i <= 7);
				int[] array = new int[]
				{
					50,
					200,
					350,
					500,
					650,
					800
				};
				int num6 = 0;
				int num7 = array.Length - 1;
				for (i = num6; i <= num7; i++)
				{
					tabelaLinhaInteria2.EscreveTituloLinha(2, "Liga", array[i]);
					tabelaLinhaInteria2.EscreveTituloLinha(2, "Desliga", array[i] + 50);
				}
				int[] array2 = new int[]
				{
					50,
					110,
					200,
					260,
					350,
					410,
					500,
					560,
					650,
					710,
					800,
					860
				};
				object obj = 12;
				object ex = null;
				object obj3 = null;
				if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(ex, 0, 7, 1, ref obj3, ref ex))
				{
					do
					{
						object obj4 = null;
						if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 0, Operators.SubtractObject(obj, 1), 1, ref obj4, ref obj))
						{
							do
							{
								object obj5 = RT_geral.RT_820_360_BD.Timer_Horario[Conversions.ToInteger(ex)][Conversions.ToInteger(obj)].Valor;
								string text = string.Format("{0:D2}:{1:D2}", Operators.IntDivideObject(obj5, 60), Operators.ModObject(obj5, 60));
								tabelaLinhaInteria2.EscreveValorLinha(Conversions.ToInteger(Operators.AddObject(ex, 3)), text, array2[Conversions.ToInteger(obj)]);
							}
							while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj4, ref obj));
						}
					}
					while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(ex, obj3, ref ex));
				}
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00362074 File Offset: 0x00360474
		private void DesenhaRelatorioRT820Pagina07(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, (System.Drawing.FontStyle)3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, (System.Drawing.FontStyle)0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, (System.Drawing.FontStyle)1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_360_BD.Equip.Valor, RT_geral.RT_820_360_BD.Versao.Valor);
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 5, 6, "Periféricos do 1° Endereço da Estação", true);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Periférico", 0);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Modelo", 100);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Endereço", 300);
			int num = 0;
			checked
			{
				do
				{
					string text = string.Format("{0:D2}", num + 1);
					tabelaMeiaLinhaEsquerda.EscreveTituloLinha(num + 2, text, 0);
					text = "???";
					int num2 = RT_geral.RT_820_360_BD.config_perifericos1_mod[num].Valor - 48;
					if (num2 <= perifericos.perif_RT820_360.Count)
					{
						text = perifericos.perif_RT820_360[num2].nome_impressao;
					}
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(num + 2, text, 105);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(num + 2, RT_geral.RT_820_360_BD.config_perifericos1_end[num].Valor.ToString(), 320);
					num++;
				}
				while (num <= 4);
				TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, 5, 6, "Periféricos do 2° Endereço da Estação", true);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Periférico", 0);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Modelo", 100);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Endereço", 300);
				num = 0;
				do
				{
					string text = string.Format("{0:D2}", num + 1);
					tabelaMeiaLinhaDireita.EscreveTituloLinha(num + 2, text, 0);
					text = "???";
					int num2 = RT_geral.RT_820_360_BD.config_perifericos2_mod[num].Valor - 48;
					if (num2 <= perifericos.perif_RT820_360.Count)
					{
						text = perifericos.perif_RT820_360[num2].nome_impressao;
					}
					tabelaMeiaLinhaDireita.EscreveValorLinha(num + 2, text, 105);
					tabelaMeiaLinhaDireita.EscreveValorLinha(num + 2, RT_geral.RT_820_360_BD.config_perifericos2_end[num].Valor.ToString(), 320);
					num++;
				}
				while (num <= 4);
				TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda.GetNextLineAvailable(), 6, "ModBus Genérico", true);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Endereço", 50);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Função", 150);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Memória 1", 270);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Vars 1", 350);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Memória 2", 420);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Vars 2", 500);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Memória 3", 570);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Vars 3", 650);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Memória 4", 740);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Vars 4", 820);
				num = 0;
				do
				{
					string text = string.Format("{0:D2}", num + 1);
					tabelaLinhaInteria.EscreveTituloLinha(num + 2, text, 0);
					text = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_endcom[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 60);
					int num2 = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[num].Indice;
					text = RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[1].LinhasMenu[num2];
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 150);
					text = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem1[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 280);
					text = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var1[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 360);
					text = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem2[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 430);
					text = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var2[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 510);
					text = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem3[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 580);
					text = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var3[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 660);
					text = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem4[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 760);
					text = RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var4[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 840);
					num++;
				}
				while (num <= 4);
				TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria.GetNextLineAvailable(), 11, "Referências para Periféicos", true);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Endereço", 50);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "End. Memória", 150);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Variável 1", 270);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Variável 2", 400);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Escala", 550);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Formato", 650);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Base10", 800);
				num = 0;
				do
				{
					string text = string.Format("{0:D2}", num + 1);
					tabelaLinhaInteria2.EscreveTituloLinha(num + 2, text, 0);
					text = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu[RT_geral.RT_820_360_BD.config_referencia_perif_periferico[num].Indice];
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 55);
					text = RT_geral.RT_820_360_BD.config_referencia_perif_memoria[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 155);
					text = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasMenu[RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[num].Indice];
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 275);
					text = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LinhasMenu[RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[num].Indice];
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 405);
					text = RT_geral.RT_820_360_BD.config_referencia_perif_escala[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 555);
					text = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasMenu[RT_geral.RT_820_360_BD.config_referencia_perif_formato[num].Indice];
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 655);
					text = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasMenu[RT_geral.RT_820_360_BD.config_referencia_perif_base10[num].Indice];
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 805);
					num++;
				}
				while (num <= 9);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x003628C8 File Offset: 0x00360CC8
		private void DesenhaRelatorioRT820Pagina08(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, (System.Drawing.FontStyle)3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, (System.Drawing.FontStyle)0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, (System.Drawing.FontStyle)1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_360_BD.Equip.Valor, RT_geral.RT_820_360_BD.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 2, "Atuador 1", true);
			int[] array = new int[]
			{
				10,
				100,
				170,
				260,
				330,
				420,
				480,
				550,
				620,
				700,
				770,
				830,
				900
			};
			tabelaLinhaInteria.EscreveTituloLinha(1, "Periférico", array[0]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Memória", array[1]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Variável 1", array[2]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Escala 1", array[3]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Variável 2", array[4]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Escala 2", array[5]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Histerese", array[6]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Formato", array[7]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Base10", array[8]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "V1Baixo", array[9]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "V1Alto", array[10]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "V2Baixo", array[11]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "V2Alto", array[12]);
			string text = RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador1_perif[0].Indice];
			checked
			{
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[0] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador1_mem[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[1] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador1_var1[0].Indice];
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[2] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador1_escala1[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[3] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador1_var2[0].Indice];
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[4] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador1_escala2[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[5] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador1_histerese[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[6] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador1_formato[0].Indice];
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[7] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador1_base10[0].Indice];
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[8] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador1_v1baixo[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[9] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador1_v1alto[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[10] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador1_v2baixo[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[11] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador1_v2alto[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[12] + 5);
				TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria.GetNextLineAvailable(), 4, "Atuador 1 Variável 1", true);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Faixa", 0);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Hora", 50);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Minuto", 100);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref1", 200);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP1", 260);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref2", 320);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP2", 380);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref3", 420);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP3", 480);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref4", 540);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP4", 600);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref5", 660);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP5", 720);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref6", 780);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP6", 840);
				int num = 0;
				do
				{
					text = string.Format("{0:D2}", num + 1);
					tabelaLinhaInteria2.EscreveTituloLinha(num + 2, text, 0);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 55);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 105);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 205);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 265);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 325);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 385);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 425);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 485);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 545);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 605);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 665);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 725);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 785);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 845);
					num++;
				}
				while (num <= 2);
				TabelaLinhaInteria tabelaLinhaInteria3 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria2.GetNextLineAvailable(), 4, "Atuador 1 Variável 2", true);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Faixa", 0);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref1", 200);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP1", 260);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref2", 320);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP2", 380);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref3", 420);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP3", 480);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref4", 540);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP4", 600);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref5", 660);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP5", 720);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref6", 780);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP6", 840);
				num = 0;
				do
				{
					text = string.Format("{0:D2}", num + 1);
					tabelaLinhaInteria3.EscreveTituloLinha(num + 2, text, 0);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 205);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 265);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 325);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 385);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 425);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 485);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 545);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 605);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 665);
					text = RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 725);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 785);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 845);
					num++;
				}
				while (num <= 2);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x003634E0 File Offset: 0x003618E0
		private void DesenhaRelatorioRT820Pagina09(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, (System.Drawing.FontStyle)3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, (System.Drawing.FontStyle)0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, (System.Drawing.FontStyle)1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_360_BD.Equip.Valor, RT_geral.RT_820_360_BD.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 4, 2, "Atuador 2", true);
			int[] array = new int[]
			{
				10,
				100,
				170,
				260,
				330,
				420,
				480,
				550,
				620,
				700,
				770,
				830,
				900
			};
			tabelaLinhaInteria.EscreveTituloLinha(1, "Periférico", array[0]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Memória", array[1]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Variável 1", array[2]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Escala 1", array[3]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Variável 2", array[4]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Escala 2", array[5]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Histerese", array[6]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Formato", array[7]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Base10", array[8]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "V1Baixo", array[9]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "V1Alto", array[10]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "V2Baixo", array[11]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "V2Alto", array[12]);
			string text = RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador2_perif[0].Indice];
			checked
			{
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[0] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador2_mem[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[1] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador2_var1[0].Indice];
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[2] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador2_escala1[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[3] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador2_var2[0].Indice];
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[4] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador2_escala2[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[5] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador2_histerese[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[6] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador2_formato[0].Indice];
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[7] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador2_base10[0].Indice];
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[8] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador2_v1baixo[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[9] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador2_v1alto[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[10] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador2_v2baixo[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[11] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador2_v2alto[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[12] + 5);
				TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria.GetNextLineAvailable(), 4, "Atuador 2 Variável 1", true);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Faixa", 0);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Hora", 50);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Minuto", 100);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref1", 200);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP1", 260);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref2", 320);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP2", 380);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref3", 420);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP3", 480);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref4", 540);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP4", 600);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref5", 660);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP5", 720);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref6", 780);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP6", 840);
				int num = 0;
				do
				{
					text = string.Format("{0:D2}", num + 1);
					tabelaLinhaInteria2.EscreveTituloLinha(num + 2, text, 0);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 55);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 105);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 205);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 265);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 325);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 385);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 425);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 485);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 545);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 605);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 665);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 725);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 785);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 845);
					num++;
				}
				while (num <= 2);
				TabelaLinhaInteria tabelaLinhaInteria3 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria2.GetNextLineAvailable(), 4, "Atuador 2 Variável 2", true);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Faixa", 0);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref1", 200);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP1", 260);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref2", 320);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP2", 380);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref3", 420);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP3", 480);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref4", 540);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP4", 600);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref5", 660);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP5", 720);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref6", 780);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP6", 840);
				num = 0;
				do
				{
					text = string.Format("{0:D2}", num + 1);
					tabelaLinhaInteria3.EscreveTituloLinha(num + 2, text, 0);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 205);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 265);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 325);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 385);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 425);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 485);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 545);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 605);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 665);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 725);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 785);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 845);
					num++;
				}
				while (num <= 2);
				TabelaLinhaInteria tabelaLinhaInteria4 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria3.GetNextLineAvailable(), 2, "Atuador 3", true);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Periférico", array[0]);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Memória", array[1]);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Variável 1", array[2]);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Escala 1", array[3]);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Variável 2", array[4]);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Escala 2", array[5]);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Histerese", array[6]);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Formato", array[7]);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Base10", array[8]);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "V1Baixo", array[9]);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "V1Alto", array[10]);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "V2Baixo", array[11]);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "V2Alto", array[12]);
				text = RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador3_perif[0].Indice];
				tabelaLinhaInteria4.EscreveValorLinha(2, text, array[0] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador3_mem[0].Valor.ToString();
				tabelaLinhaInteria4.EscreveValorLinha(2, text, array[1] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador3_var1[0].Indice];
				tabelaLinhaInteria4.EscreveValorLinha(2, text, array[2] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador2_escala1[0].Valor.ToString();
				tabelaLinhaInteria4.EscreveValorLinha(2, text, array[3] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador3_var2[0].Indice];
				tabelaLinhaInteria4.EscreveValorLinha(2, text, array[4] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador3_escala2[0].Valor.ToString();
				tabelaLinhaInteria4.EscreveValorLinha(2, text, array[5] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador2_histerese[0].Valor.ToString();
				tabelaLinhaInteria4.EscreveValorLinha(2, text, array[6] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador3_formato[0].Indice];
				tabelaLinhaInteria4.EscreveValorLinha(2, text, array[7] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador3_base10[0].Indice];
				tabelaLinhaInteria4.EscreveValorLinha(2, text, array[8] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador3_v1baixo[0].Valor.ToString();
				tabelaLinhaInteria4.EscreveValorLinha(2, text, array[9] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador3_v1alto[0].Valor.ToString();
				tabelaLinhaInteria4.EscreveValorLinha(2, text, array[10] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador3_v2baixo[0].Valor.ToString();
				tabelaLinhaInteria4.EscreveValorLinha(2, text, array[11] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador3_v2alto[0].Valor.ToString();
				tabelaLinhaInteria4.EscreveValorLinha(2, text, array[12] + 5);
				TabelaLinhaInteria tabelaLinhaInteria5 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria4.GetNextLineAvailable(), 4, "Atuador 3 Variável 1", true);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Faixa", 0);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Hora", 50);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Minuto", 100);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Ref1", 200);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "SP1", 260);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Ref2", 320);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "SP2", 380);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Ref3", 420);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "SP3", 480);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Ref4", 540);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "SP4", 600);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Ref5", 660);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "SP5", 720);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Ref6", 780);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "SP6", 840);
				num = 0;
				do
				{
					text = string.Format("{0:D2}", num + 1);
					tabelaLinhaInteria5.EscreveTituloLinha(num + 2, text, 0);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[num].Valor.ToString();
					tabelaLinhaInteria5.EscreveValorLinha(num + 2, text, 55);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[num].Valor.ToString();
					tabelaLinhaInteria5.EscreveValorLinha(num + 2, text, 105);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[num].Valor.ToString();
					tabelaLinhaInteria5.EscreveValorLinha(num + 2, text, 205);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[num].Valor.ToString();
					tabelaLinhaInteria5.EscreveValorLinha(num + 2, text, 265);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[num].Valor.ToString();
					tabelaLinhaInteria5.EscreveValorLinha(num + 2, text, 325);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[num].Valor.ToString();
					tabelaLinhaInteria5.EscreveValorLinha(num + 2, text, 385);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[num].Valor.ToString();
					tabelaLinhaInteria5.EscreveValorLinha(num + 2, text, 425);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[num].Valor.ToString();
					tabelaLinhaInteria5.EscreveValorLinha(num + 2, text, 485);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[num].Valor.ToString();
					tabelaLinhaInteria5.EscreveValorLinha(num + 2, text, 545);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[num].Valor.ToString();
					tabelaLinhaInteria5.EscreveValorLinha(num + 2, text, 605);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[num].Valor.ToString();
					tabelaLinhaInteria5.EscreveValorLinha(num + 2, text, 665);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[num].Valor.ToString();
					tabelaLinhaInteria5.EscreveValorLinha(num + 2, text, 725);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[num].Valor.ToString();
					tabelaLinhaInteria5.EscreveValorLinha(num + 2, text, 785);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[num].Valor.ToString();
					tabelaLinhaInteria5.EscreveValorLinha(num + 2, text, 845);
					num++;
				}
				while (num <= 2);
				TabelaLinhaInteria tabelaLinhaInteria6 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria5.GetNextLineAvailable(), 4, "Atuador 3 Variável 2", true);
				tabelaLinhaInteria6.EscreveTituloLinha(1, "Faixa", 0);
				tabelaLinhaInteria6.EscreveTituloLinha(1, "Ref1", 200);
				tabelaLinhaInteria6.EscreveTituloLinha(1, "SP1", 260);
				tabelaLinhaInteria6.EscreveTituloLinha(1, "Ref2", 320);
				tabelaLinhaInteria6.EscreveTituloLinha(1, "SP2", 380);
				tabelaLinhaInteria6.EscreveTituloLinha(1, "Ref3", 420);
				tabelaLinhaInteria6.EscreveTituloLinha(1, "SP3", 480);
				tabelaLinhaInteria6.EscreveTituloLinha(1, "Ref4", 540);
				tabelaLinhaInteria6.EscreveTituloLinha(1, "SP4", 600);
				tabelaLinhaInteria6.EscreveTituloLinha(1, "Ref5", 660);
				tabelaLinhaInteria6.EscreveTituloLinha(1, "SP5", 720);
				tabelaLinhaInteria6.EscreveTituloLinha(1, "Ref6", 780);
				tabelaLinhaInteria6.EscreveTituloLinha(1, "SP6", 840);
				num = 0;
				do
				{
					text = string.Format("{0:D2}", num + 1);
					tabelaLinhaInteria6.EscreveTituloLinha(num + 2, text, 0);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 205);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 265);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 325);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 385);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 425);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 485);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 545);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 605);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 665);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 725);
					text = RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 785);
					text = RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 845);
					num++;
				}
				while (num <= 2);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00364BD8 File Offset: 0x00362FD8
		private void DesenhaRelatorioRT820Pagina7(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, (System.Drawing.FontStyle)3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, (System.Drawing.FontStyle)0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, (System.Drawing.FontStyle)1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_360_BD.Equip.Valor, RT_geral.RT_820_360_BD.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 4, 2, "Atuador 4", true);
			int[] array = new int[]
			{
				10,
				100,
				170,
				260,
				330,
				420,
				480,
				550,
				620,
				700,
				770,
				830,
				900
			};
			tabelaLinhaInteria.EscreveTituloLinha(1, "Periférico", array[0]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Memória", array[1]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Variável 1", array[2]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Escala 1", array[3]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Variável 2", array[4]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Escala 2", array[5]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Histerese", array[6]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Formato", array[7]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Base10", array[8]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "V1Baixo", array[9]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "V1Alto", array[10]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "V2Baixo", array[11]);
			tabelaLinhaInteria.EscreveTituloLinha(1, "V2Alto", array[12]);
			string text = RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador4_perif[0].Indice];
			checked
			{
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[0] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador4_mem[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[1] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador4_var1[0].Indice];
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[2] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador4_escala1[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[3] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador4_var2[0].Indice];
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[4] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador4_escala2[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[5] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador4_histerese[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[6] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador4_formato[0].Indice];
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[7] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasMenu[RT_geral.RT_820_360_BD.config_atuador4_base10[0].Indice];
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[8] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador4_v1baixo[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[9] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador4_v1alto[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[10] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador4_v2baixo[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[11] + 5);
				text = RT_geral.RT_820_360_BD.config_atuador4_v2alto[0].Valor.ToString();
				tabelaLinhaInteria.EscreveValorLinha(2, text, array[12] + 5);
				TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria.GetNextLineAvailable(), 4, "Atuador 4 Variável 1", true);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Faixa", 0);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Hora", 50);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Minuto", 100);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref1", 200);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP1", 260);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref2", 320);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP2", 380);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref3", 420);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP3", 480);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref4", 540);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP4", 600);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref5", 660);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP5", 720);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ref6", 780);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "SP6", 840);
				int num = 0;
				do
				{
					text = string.Format("{0:D2}", num + 1);
					tabelaLinhaInteria2.EscreveTituloLinha(num + 2, text, 0);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 55);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 105);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 205);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 265);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 325);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 385);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 425);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 485);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 545);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 605);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 665);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 725);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 785);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[num].Valor.ToString();
					tabelaLinhaInteria2.EscreveValorLinha(num + 2, text, 845);
					num++;
				}
				while (num <= 2);
				TabelaLinhaInteria tabelaLinhaInteria3 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria2.GetNextLineAvailable(), 4, "Atuador 4 Variável 2", true);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Faixa", 0);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref1", 200);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP1", 260);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref2", 320);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP2", 380);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref3", 420);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP3", 480);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref4", 540);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP4", 600);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref5", 660);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP5", 720);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Ref6", 780);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "SP6", 840);
				num = 0;
				do
				{
					text = string.Format("{0:D2}", num + 1);
					tabelaLinhaInteria3.EscreveTituloLinha(num + 2, text, 0);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 205);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 265);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 325);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 385);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 425);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 485);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 545);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 605);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 665);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 725);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 785);
					text = RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 845);
					num++;
				}
				while (num <= 2);
				TabelaLinhaInteria tabelaLinhaInteria4 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria3.GetNextLineAvailable(), 3, "Comentários", true);
				tabelaLinhaInteria4.EscreveValorLinha(1, this.TextBox_comentarios_RT820.Text, 0);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00365828 File Offset: 0x00363C28
		private bool DesenhaRelatorio(PrintPageEventArgs z)
		{
			checked
			{
				switch (this.pagina_impressao)
				{
				case 1:
					this.DesenhaRelatorioRT820Pagina01(z);
					this.pagina_impressao++;
					return true;
				case 2:
					this.DesenhaRelatorioRT820Pagina02(z);
					this.pagina_impressao++;
					return true;
				case 3:
					this.DesenhaRelatorioRT820Pagina03(z);
					this.pagina_impressao++;
					return true;
				case 4:
					this.DesenhaRelatorioRT820Pagina04(z);
					this.pagina_impressao++;
					return true;
				case 5:
					this.DesenhaRelatorioRT820Pagina05(z);
					this.pagina_impressao++;
					return true;
				case 6:
					this.DesenhaRelatorioRT820Pagina06(z);
					this.pagina_impressao++;
					return true;
				case 7:
					this.DesenhaRelatorioRT820Pagina07(z);
					this.pagina_impressao++;
					return true;
				case 8:
					this.DesenhaRelatorioRT820Pagina08(z);
					this.pagina_impressao++;
					return true;
				case 9:
					this.DesenhaRelatorioRT820Pagina09(z);
					this.pagina_impressao++;
					return true;
				case 10:
					this.DesenhaRelatorioRT820Pagina7(z);
					this.pagina_impressao++;
					return false;
				default:
					return false;
				}
			}
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00365958 File Offset: 0x00363D58
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.HasMorePages = this.DesenhaRelatorio(e);
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00365968 File Offset: 0x00363D68
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
			case 4:
				e.PageSettings.Landscape = true;
				break;
			case 5:
				e.PageSettings.Landscape = true;
				break;
			case 6:
				e.PageSettings.Landscape = true;
				break;
			case 7:
				e.PageSettings.Landscape = true;
				break;
			case 8:
				e.PageSettings.Landscape = true;
				break;
			case 9:
				e.PageSettings.Landscape = true;
				break;
			case 10:
				e.PageSettings.Landscape = true;
				break;
			}
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00365A3C File Offset: 0x00363E3C
		private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
		{
			this.pagina_impressao = 1;
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00365A48 File Offset: 0x00363E48
		private void dgv_sph_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string name = this.dgv_sph.Columns[e.ColumnIndex].Name;
			string text = name;
			checked
			{
				if (Operators.CompareString(text, "col_sph_ativa", false) == 0)
				{
					bool flag = Conversions.ToBoolean(this.dgv_sph.Rows[e.RowIndex].Cells[1].Value);
					int num = RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Hora.Valor;
					if (flag)
					{
						num |= 128;
					}
					else
					{
						num &= 127;
					}
					RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Hora.Valor = num;
				}
				else if (Operators.CompareString(text, "col_sph_hora", false) == 0)
				{
					int num = RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Hora.Valor & 128;
					RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Hora.Valor = Conversions.ToInteger(this.dgv_sph.Rows[e.RowIndex].Cells[2].Value);
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Hora, e, true);
					sender = dataGridView;
					RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Hora.Valor = RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Hora.Valor + num;
				}
				else if (Operators.CompareString(text, "col_sph_minuto", false) == 0)
				{
					RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Minuto.Valor = Conversions.ToInteger(this.dgv_sph.Rows[e.RowIndex].Cells[3].Value);
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Minuto, e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "col_sph_alto", false) == 0)
				{
					RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Alto.Valor = Conversions.ToInteger(this.dgv_sph.Rows[e.RowIndex].Cells[4].Value);
					if (RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Alto.Valor = RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Alto.Valor * 40;
					}
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Alto, e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "col_sph_baixo", false) == 0)
				{
					RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Baixo.Valor = Conversions.ToInteger(this.dgv_sph.Rows[e.RowIndex].Cells[5].Value);
					if (RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Baixo.Valor = RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Baixo.Valor * 40;
					}
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Baixo, e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00365E5C File Offset: 0x0036425C
		private void dgv_sph_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string name = this.dgv_sph.Columns[e.ColumnIndex].Name;
			string text = name;
			if (Operators.CompareString(text, "col_sph_ativa", false) == 0)
			{
				bool flag = Conversions.ToBoolean(this.dgv_sph.Rows[e.RowIndex].Cells[1].Value);
				int num = RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Hora.Valor;
				if (flag)
				{
					num |= 128;
				}
				else
				{
					num &= 127;
				}
				RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Hora.Valor = num;
			}
			else if (Operators.CompareString(text, "col_sph_hora", false) == 0)
			{
				int num = RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Hora.Valor & 128;
				RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Hora.Valor = Conversions.ToInteger(Operators.AddObject(this.dgv_sph.Rows[e.RowIndex].Cells[2].Value, num));
			}
			else if (Operators.CompareString(text, "col_sph_minuto", false) == 0)
			{
				RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Minuto.Valor = Conversions.ToInteger(this.dgv_sph.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "col_sph_alto", false) == 0)
			{
				RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Alto.Valor = Conversions.ToInteger(this.dgv_sph.Rows[e.RowIndex].Cells[4].Value);
				if (RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
				{
					RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Alto.Valor = Conversions.ToInteger(Operators.MultiplyObject(this.dgv_sph.Rows[e.RowIndex].Cells[4].Value, 40));
				}
			}
			else if (Operators.CompareString(text, "col_sph_baixo", false) == 0)
			{
				RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Baixo.Valor = Conversions.ToInteger(this.dgv_sph.Rows[e.RowIndex].Cells[5].Value);
				if (RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
				{
					RT_geral.RT_820_360_BD.setpoint_horario[e.RowIndex].Baixo.Valor = Conversions.ToInteger(Operators.MultiplyObject(this.dgv_sph.Rows[e.RowIndex].Cells[5].Value, 40));
				}
			}
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x003661A8 File Offset: 0x003645A8
		private void dgv_sph_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_sph.IsCurrentCellDirty)
			{
				this.dgv_sph.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x003661C8 File Offset: 0x003645C8
		private void cb_ModoRepetidora_SelectedIndexChanged(object sender, EventArgs e)
		{
			object obj = null;
			bool flag = false;
			if (Operators.ConditionalCompareObjectEqual(obj, 0, false))
			{
				flag = false;
			}
			else if (Conversions.ToBoolean((Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(obj, 1, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(obj, 2, false)) ? true : false))))
			{
				flag = true;
			}
			this.NumericUpDown_end_rep_820.Enabled = flag;
			this.NumericUpDown_num_est_rep_820.Enabled = flag;
			this.GroupBox_end_rep_820.Visible = flag;
			RT_geral.RT_820_360_BD.modo_repetidora.Valor = RT_geral.RT_820_360_BD.modo_repetidora.valores[Conversions.ToInteger(null)];
			RT_geral.RT_820_360_BD.modo_repetidora.Indice = 0;
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x003662C4 File Offset: 0x003646C4
		private void datagridview_referenciaperifico_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			if (e.RowIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.datagridview_referenciaperifico.Columns[e.ColumnIndex].DataPropertyName;
			string dataPropertyName2 = this.datagridview_referenciaperifico.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName2, "Col_endmem", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_referencia_perif_memoria[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_referencia_perif_memoria[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName2, "Col_escala", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_referencia_perif_escala[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_referencia_perif_escala[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName2, "Col_perif", false) != 0)
				{
					if (Operators.CompareString(dataPropertyName2, "Col_var", false) != 0)
					{
						if (Operators.CompareString(dataPropertyName2, "Col_formato", false) == 0)
						{
						}
					}
				}
			}
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00366428 File Offset: 0x00364828
		private void datagridview_referenciaperifico_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			if (e.RowIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.datagridview_referenciaperifico.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_endmem", false) == 0)
				{
					this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_360_BD.config_referencia_perif_memoria[e.RowIndex].Valor = Conversions.ToInteger(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_escala", false) == 0)
				{
					this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[4].Value));
					RT_geral.RT_820_360_BD.config_referencia_perif_escala[e.RowIndex].Valor = Conversions.ToInteger(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[4].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_perif", false) == 0)
				{
					string text = Conversions.ToString(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					for (int i = num; i <= num2; i++)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							RT_geral.RT_820_360_BD.config_referencia_perif_periferico[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_360_BD.config_referencia_perif_periferico[e.RowIndex].Indice = i;
							break;
						}
					}
				}
				else if (Operators.CompareString(dataPropertyName, "Col_var1", false) == 0)
				{
					string text = Conversions.ToString(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num3 = 0;
					int num4 = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					for (int i = num3; i <= num4; i++)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[e.RowIndex].Indice = i;
							break;
						}
					}
				}
				else if (Operators.CompareString(dataPropertyName, "Col_var2", false) == 0)
				{
					string text = Conversions.ToString(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num5 = 0;
					int num6 = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					for (int i = num5; i <= num6; i++)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[e.RowIndex].Indice = i;
							break;
						}
					}
				}
				else if (Operators.CompareString(dataPropertyName, "Col_formato", false) == 0)
				{
					string text = Conversions.ToString(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num7 = 0;
					int num8 = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					for (int i = num7; i <= num8; i++)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							RT_geral.RT_820_360_BD.config_referencia_perif_formato[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_360_BD.config_referencia_perif_formato[e.RowIndex].Indice = i;
							break;
						}
					}
				}
				else if (Operators.CompareString(dataPropertyName, "Col_base10", false) == 0)
				{
					string text = Conversions.ToString(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num9 = 0;
					int num10 = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					for (int i = num9; i <= num10; i++)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							RT_geral.RT_820_360_BD.config_referencia_perif_base10[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_360_BD.config_referencia_perif_base10[e.RowIndex].Indice = i;
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00366A34 File Offset: 0x00364E34
		private void datagridview_referenciaperifico_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.datagridview_referenciaperifico.IsCurrentCellDirty)
			{
				this.datagridview_referenciaperifico.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00366A54 File Offset: 0x00364E54
		private void datagridview_referenciaperifico_CellValidating_1(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.datagridview_referenciaperifico.Columns[e.ColumnIndex].DataPropertyName;
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_endmem", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_referencia_perif_memoria[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_referencia_perif_memoria[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_referencia_perif_escala[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_referencia_perif_escala[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00366B5C File Offset: 0x00364F5C
		private void datagridview_referenciaperifico_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			checked
			{
				int num = 0;
				int valor = 0;
				if (RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].NumeroLinhaMenu > 0)
				{
					num = -1;
					DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[e.ColumnIndex];
					int num2 = 0;
					int num3 = dataGridViewComboBoxCell.Items.Count - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (Operators.ConditionalCompareObjectEqual(dataGridViewComboBoxCell.Value, dataGridViewComboBoxCell.Items[i], false))
						{
							num = i;
							break;
						}
					}
					valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasValor[num];
				}
				string dataPropertyName = this.datagridview_referenciaperifico.Columns[e.ColumnIndex].DataPropertyName;
				string text = dataPropertyName;
				if (Operators.CompareString(text, "Col_perif", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_referencia_perif_periferico[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_referencia_perif_periferico[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_referencia_perif_variavel1[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_referencia_perif_variavel2[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_formato", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_referencia_perif_formato[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_referencia_perif_formato[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_base10", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_referencia_perif_base10[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_referencia_perif_base10[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_endmem", false) == 0)
				{
					this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_360_BD.config_referencia_perif_memoria[e.RowIndex].Valor = Conversions.ToInteger(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(text, "Col_escala", false) == 0)
				{
					this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[4].Value));
					RT_geral.RT_820_360_BD.config_referencia_perif_escala[e.RowIndex].Valor = Conversions.ToInteger(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[4].Value);
				}
			}
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00366F18 File Offset: 0x00365318
		private void dgv_atuador1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador1.IsCurrentCellDirty)
			{
				this.dgv_atuador1.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00366F38 File Offset: 0x00365338
		private void dgv_atuador1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			checked
			{
				int num = 0;
				int valor = 0;
				if (RT_geral.RT_820_DataGrigViewAtuador1Colunas[e.ColumnIndex].NumeroLinhaMenu > 0)
				{
					num = -1;
					DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.dgv_atuador1.Rows[e.RowIndex].Cells[e.ColumnIndex];
					int num2 = 0;
					int num3 = dataGridViewComboBoxCell.Items.Count - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (Operators.ConditionalCompareObjectEqual(dataGridViewComboBoxCell.Value, dataGridViewComboBoxCell.Items[i], false))
						{
							num = i;
							break;
						}
					}
					valor = RT_geral.RT_820_DataGrigViewAtuador1Colunas[e.ColumnIndex].LinhasValor[num];
				}
				string dataPropertyName = this.dgv_atuador1.Columns[e.ColumnIndex].DataPropertyName;
				string text = dataPropertyName;
				if (Operators.CompareString(text, "Col_perif", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_perif[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador1_perif[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_var1[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador1_var1[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_var2[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador1_var2[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_format", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_formato[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador1_formato[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_base10", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_base10[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador1_base10[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_endmem", false) == 0)
				{
					this.dgv_atuador1.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador1.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_360_BD.config_atuador1_mem[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador1.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(text, "Col_escala1", false) == 0)
				{
					this.dgv_atuador1.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador1.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_820_360_BD.config_atuador1_escala1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador1.Rows[e.RowIndex].Cells[3].Value);
				}
				else if (Operators.CompareString(text, "Col_escala2", false) == 0)
				{
					this.dgv_atuador1.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador1.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_820_360_BD.config_atuador1_escala2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador1.Rows[e.RowIndex].Cells[5].Value);
				}
				else if (Operators.CompareString(text, "Col_redut", false) != 0)
				{
					if (Operators.CompareString(text, "Col_hist", false) == 0)
					{
						this.dgv_atuador1.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador1.Rows[e.RowIndex].Cells[6].Value));
						RT_geral.RT_820_360_BD.config_atuador1_histerese[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador1.Rows[e.RowIndex].Cells[6].Value);
					}
					else if (Operators.CompareString(text, "Col_V1Baixo", false) == 0)
					{
						this.dgv_atuador1.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador1.Rows[e.RowIndex].Cells[9].Value));
						RT_geral.RT_820_360_BD.config_atuador1_v1baixo[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador1.Rows[e.RowIndex].Cells[9].Value);
					}
					else if (Operators.CompareString(text, "Col_V1Alto", false) == 0)
					{
						this.dgv_atuador1.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador1.Rows[e.RowIndex].Cells[10].Value));
						RT_geral.RT_820_360_BD.config_atuador1_v1alto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador1.Rows[e.RowIndex].Cells[10].Value);
					}
					else if (Operators.CompareString(text, "Col_V2Baixo", false) == 0)
					{
						this.dgv_atuador1.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador1.Rows[e.RowIndex].Cells[11].Value));
						RT_geral.RT_820_360_BD.config_atuador1_v2baixo[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador1.Rows[e.RowIndex].Cells[11].Value);
					}
					else if (Operators.CompareString(text, "Col_V2Alto", false) == 0)
					{
						this.dgv_atuador1.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador1.Rows[e.RowIndex].Cells[12].Value));
						RT_geral.RT_820_360_BD.config_atuador1_v2alto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador1.Rows[e.RowIndex].Cells[12].Value);
					}
				}
			}
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00367764 File Offset: 0x00365B64
		private void dgv_atuador1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.dgv_atuador1.Columns[e.ColumnIndex].DataPropertyName;
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_endmem", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_mem[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_mem[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_escala1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_escala1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_escala2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_escala2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_redut", false) != 0)
				{
					if (Operators.CompareString(text, "Col_hist", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador1_histerese[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_histerese[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Va11Baixo", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador1_v1baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_v1baixo[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var1Alto", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador1_v1alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_v1alto[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var2Baixo", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador1_v2baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_v2baixo[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var2Alto", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador1_v2alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_v2alto[e.RowIndex], e, true);
						sender = dataGridView;
					}
				}
			}
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00367B10 File Offset: 0x00365F10
		private void dgv_atuador_setpoint1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador_setpoint1.IsCurrentCellDirty)
			{
				this.dgv_atuador_setpoint1.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00367B30 File Offset: 0x00365F30
		private void dgv_atuador_setpoint1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.dgv_atuador_setpoint1.Columns[e.ColumnIndex].DataPropertyName;
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_Hora", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Minuto", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00368154 File Offset: 0x00366554
		private void dgv_atuador_setpoint2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.dgv_atuador_setpoint2.Columns[e.ColumnIndex].DataPropertyName;
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_Hora", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Minuto", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00368778 File Offset: 0x00366B78
		private void dgv_atuador_setpoint1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.dgv_atuador_setpoint1.Columns[e.ColumnIndex].DataPropertyName;
			string text = dataPropertyName;
			if (Operators.CompareString(text, "Col_Hora", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[0].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_hora[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(text, "Col_Minuto", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_minuto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref1", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[2].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[4].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[4].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[6].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[6].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[8].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[8].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[8].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[10].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[10].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[12].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_ref6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[12].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[3].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[5].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[5].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[7].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[9].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[9].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[11].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[11].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[13].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[13].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint1_setp6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[13].Value);
			}
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x003691BC File Offset: 0x003675BC
		private void dgv_atuador_setpoint2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.dgv_atuador_setpoint2.Columns[e.ColumnIndex].DataPropertyName;
			string text = dataPropertyName;
			if (Operators.CompareString(text, "Col_Hora", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[0].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_hora[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(text, "Col_Minuto", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_minuto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref1", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[2].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[4].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[4].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[6].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[6].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[8].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[8].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[8].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[10].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[10].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[12].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_ref6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[12].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[3].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[5].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[5].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[7].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[9].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[9].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[11].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[11].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[13].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[13].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint1_setp6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[13].Value);
			}
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00369C00 File Offset: 0x00368000
		private void dgv_atuador2_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador2.IsCurrentCellDirty)
			{
				this.dgv_atuador2.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00369C20 File Offset: 0x00368020
		private void dgv_atuador2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.dgv_atuador2.Columns[e.ColumnIndex].DataPropertyName;
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_endmem", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_mem[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_mem[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_escala1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_escala1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_escala2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_escala2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_redut", false) != 0)
				{
					if (Operators.CompareString(text, "Col_hist", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador2_histerese[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_histerese[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_V1Baixo", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador2_v1baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_v1baixo[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_V1Alto", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador2_v1alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_v1alto[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_V2Baixo", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador2_v2baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_v2baixo[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_V2Alto", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador2_v2alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_v2alto[e.RowIndex], e, true);
						sender = dataGridView;
					}
				}
			}
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00369FCC File Offset: 0x003683CC
		private void dgv_atuador2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			checked
			{
				int num = 0;
				int valor = 0;
				if (RT_geral.RT_820_DataGrigViewAtuador2Colunas[e.ColumnIndex].NumeroLinhaMenu > 0)
				{
					num = -1;
					DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.dgv_atuador2.Rows[e.RowIndex].Cells[e.ColumnIndex];
					int num2 = 0;
					int num3 = dataGridViewComboBoxCell.Items.Count - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (Operators.ConditionalCompareObjectEqual(dataGridViewComboBoxCell.Value, dataGridViewComboBoxCell.Items[i], false))
						{
							num = i;
							break;
						}
					}
					valor = RT_geral.RT_820_DataGrigViewAtuador2Colunas[e.ColumnIndex].LinhasValor[num];
				}
				string dataPropertyName = this.dgv_atuador2.Columns[e.ColumnIndex].DataPropertyName;
				string text = dataPropertyName;
				if (Operators.CompareString(text, "Col_perif", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_perif[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador2_perif[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_var1[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador2_var1[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_var2[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador2_var2[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_format", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_formato[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador2_formato[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_base10", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_base10[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador2_base10[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_endmem", false) == 0)
				{
					this.dgv_atuador2.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador2.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_360_BD.config_atuador2_mem[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador2.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(text, "Col_escala1", false) == 0)
				{
					this.dgv_atuador2.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador2.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_820_360_BD.config_atuador2_escala1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador2.Rows[e.RowIndex].Cells[3].Value);
				}
				else if (Operators.CompareString(text, "Col_escala2", false) == 0)
				{
					this.dgv_atuador2.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador2.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_820_360_BD.config_atuador2_escala2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador2.Rows[e.RowIndex].Cells[5].Value);
				}
				else if (Operators.CompareString(text, "Col_redut", false) != 0)
				{
					if (Operators.CompareString(text, "Col_hist", false) == 0)
					{
						this.dgv_atuador2.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador2.Rows[e.RowIndex].Cells[6].Value));
						RT_geral.RT_820_360_BD.config_atuador2_histerese[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador2.Rows[e.RowIndex].Cells[6].Value);
					}
					else if (Operators.CompareString(text, "Col_V1Baixo", false) == 0)
					{
						this.dgv_atuador2.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador2.Rows[e.RowIndex].Cells[9].Value));
						RT_geral.RT_820_360_BD.config_atuador2_v1baixo[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador2.Rows[e.RowIndex].Cells[9].Value);
					}
					else if (Operators.CompareString(text, "Col_V1Alto", false) == 0)
					{
						this.dgv_atuador2.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador2.Rows[e.RowIndex].Cells[10].Value));
						RT_geral.RT_820_360_BD.config_atuador2_v1alto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador2.Rows[e.RowIndex].Cells[10].Value);
					}
					else if (Operators.CompareString(text, "Col_V2Baixo", false) == 0)
					{
						this.dgv_atuador2.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador2.Rows[e.RowIndex].Cells[11].Value));
						RT_geral.RT_820_360_BD.config_atuador2_v2baixo[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador2.Rows[e.RowIndex].Cells[11].Value);
					}
					else if (Operators.CompareString(text, "Col_V2Alto", false) == 0)
					{
						this.dgv_atuador2.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador2.Rows[e.RowIndex].Cells[12].Value));
						RT_geral.RT_820_360_BD.config_atuador2_v2alto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador2.Rows[e.RowIndex].Cells[12].Value);
					}
				}
			}
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0036A7F8 File Offset: 0x00368BF8
		private void dgv_atuador_setpoint11_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.dgv_atuador_setpoint11.Columns[e.ColumnIndex].DataPropertyName;
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_Ref1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0036AD44 File Offset: 0x00369144
		private void dgv_atuador_setpoint11_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0036AD48 File Offset: 0x00369148
		private void dgv_atuador_setpoint11_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador_setpoint11.IsCurrentCellDirty)
			{
				this.dgv_atuador_setpoint11.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0036AD68 File Offset: 0x00369168
		private void dgv_atuador_setpoint11_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.dgv_atuador_setpoint11.Columns[e.ColumnIndex].DataPropertyName;
			string text = dataPropertyName;
			if (Operators.CompareString(text, "Col_Ref1", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[0].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[2].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[4].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[4].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[6].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[6].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[8].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[8].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[8].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[10].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_ref6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[10].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[3].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[5].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[5].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[7].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[9].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[9].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[11].Value));
				RT_geral.RT_820_360_BD.config_atuador1_setpoint2_setp6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[11].Value);
			}
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0036B638 File Offset: 0x00369A38
		private void dgv_atuador_setpoint21_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador_setpoint21.IsCurrentCellDirty)
			{
				this.dgv_atuador_setpoint21.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0036B658 File Offset: 0x00369A58
		private void dgv_atuador_setpoint21_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.dgv_atuador_setpoint21.Columns[e.ColumnIndex].DataPropertyName;
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_Ref1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x0036BBA4 File Offset: 0x00369FA4
		private void dgv_atuador_setpoint21_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.dgv_atuador_setpoint21.Columns[e.ColumnIndex].DataPropertyName;
			string text = dataPropertyName;
			if (Operators.CompareString(text, "Col_Ref1", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[0].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[2].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[4].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[4].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[6].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[6].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[8].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[8].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[8].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[10].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_ref6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[10].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[3].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[5].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[5].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[7].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[9].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[9].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[11].Value));
				RT_geral.RT_820_360_BD.config_atuador2_setpoint2_setp6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[11].Value);
			}
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0036C474 File Offset: 0x0036A874
		private void nud_tempoforaar_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.TempoForaAr.Valor = 0;
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_360_BD.TempoForaAr, true);
			sender = numericUpDown;
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0036C4C8 File Offset: 0x0036A8C8
		private void dgv_atuador_setpoint2_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador_setpoint2.IsCurrentCellDirty)
			{
				this.dgv_atuador_setpoint2.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x0036C4E8 File Offset: 0x0036A8E8
		private void TabControl_820_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0036C4EC File Offset: 0x0036A8EC
		private void dgv_atuador3_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.dgv_atuador3.Columns[e.ColumnIndex].DataPropertyName;
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_endmem", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_mem[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_mem[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_escala1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_escala1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_escala2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_escala2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_redut", false) != 0)
				{
					if (Operators.CompareString(text, "Col_hist", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador3_histerese[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_histerese[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Va11Baixo", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador3_v1baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_v1baixo[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var1Alto", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador3_v1alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_v1alto[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var2Baixo", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador3_v2baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_v2baixo[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var2Alto", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador3_v2alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_v2alto[e.RowIndex], e, true);
						sender = dataGridView;
					}
				}
			}
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x0036C898 File Offset: 0x0036AC98
		private void dgv_atuador4_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.dgv_atuador4.Columns[e.ColumnIndex].DataPropertyName;
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_endmem", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_mem[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_mem[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_escala1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_escala1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_escala2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_escala2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_redut", false) != 0)
				{
					if (Operators.CompareString(text, "Col_hist", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador4_histerese[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_histerese[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Va11Baixo", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador4_v1baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_v1baixo[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var1Alto", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador4_v1alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_v1alto[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var2Baixo", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador4_v2baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_v2baixo[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var2Alto", false) == 0)
					{
						RT_geral.RT_820_360_BD.config_atuador4_v2alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_v2alto[e.RowIndex], e, true);
						sender = dataGridView;
					}
				}
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0036CC44 File Offset: 0x0036B044
		private void dgv_atuador_setpoint3_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.dgv_atuador_setpoint3.Columns[e.ColumnIndex].DataPropertyName;
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_Hora", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Minuto", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x0036D268 File Offset: 0x0036B668
		private void dgv_atuador_setpoint31_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.dgv_atuador_setpoint31.Columns[e.ColumnIndex].DataPropertyName;
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_Ref1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x0036D7B4 File Offset: 0x0036BBB4
		private void dgv_atuador_setpoint4_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.dgv_atuador_setpoint4.Columns[e.ColumnIndex].DataPropertyName;
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_Hora", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Minuto", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x0036DDD8 File Offset: 0x0036C1D8
		private void dgv_atuador_setpoint41_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.dgv_atuador_setpoint41.Columns[e.ColumnIndex].DataPropertyName;
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_Ref1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x0036E324 File Offset: 0x0036C724
		private void dgv_atuador3_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador3.IsCurrentCellDirty)
			{
				this.dgv_atuador3.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0036E344 File Offset: 0x0036C744
		private void dgv_atuador4_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador4.IsCurrentCellDirty)
			{
				this.dgv_atuador4.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0036E364 File Offset: 0x0036C764
		private void dgv_atuador_setpoint3_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador_setpoint3.IsCurrentCellDirty)
			{
				this.dgv_atuador_setpoint3.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0036E384 File Offset: 0x0036C784
		private void dgv_atuador_setpoint31_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador_setpoint31.IsCurrentCellDirty)
			{
				this.dgv_atuador_setpoint31.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0036E3A4 File Offset: 0x0036C7A4
		private void dgv_atuador_setpoint4_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador_setpoint4.IsCurrentCellDirty)
			{
				this.dgv_atuador_setpoint4.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x0036E3C4 File Offset: 0x0036C7C4
		private void dgv_atuador_setpoint41_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador_setpoint41.IsCurrentCellDirty)
			{
				this.dgv_atuador_setpoint41.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x0036E3E4 File Offset: 0x0036C7E4
		private void dgv_atuador3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			checked
			{
				int num = 0;
				int valor = 0;
				if (RT_geral.RT_820_DataGrigViewAtuador3Colunas[e.ColumnIndex].NumeroLinhaMenu > 0)
				{
					num = -1;
					DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.dgv_atuador3.Rows[e.RowIndex].Cells[e.ColumnIndex];
					int num2 = 0;
					int num3 = dataGridViewComboBoxCell.Items.Count - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (Operators.ConditionalCompareObjectEqual(dataGridViewComboBoxCell.Value, dataGridViewComboBoxCell.Items[i], false))
						{
							num = i;
							break;
						}
					}
					valor = RT_geral.RT_820_DataGrigViewAtuador3Colunas[e.ColumnIndex].LinhasValor[num];
				}
				string dataPropertyName = this.dgv_atuador3.Columns[e.ColumnIndex].DataPropertyName;
				string text = dataPropertyName;
				if (Operators.CompareString(text, "Col_perif", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_perif[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador3_perif[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_var1[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador3_var1[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_var2[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador3_var2[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_format", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_formato[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador3_formato[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_base10", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador3_base10[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador3_base10[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_endmem", false) == 0)
				{
					this.dgv_atuador3.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador3.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_360_BD.config_atuador3_mem[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador3.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(text, "Col_escala1", false) == 0)
				{
					this.dgv_atuador3.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador3.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_820_360_BD.config_atuador3_escala1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador3.Rows[e.RowIndex].Cells[3].Value);
				}
				else if (Operators.CompareString(text, "Col_escala2", false) == 0)
				{
					this.dgv_atuador3.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador3.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_820_360_BD.config_atuador3_escala2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador3.Rows[e.RowIndex].Cells[5].Value);
				}
				else if (Operators.CompareString(text, "Col_redut", false) != 0)
				{
					if (Operators.CompareString(text, "Col_hist", false) == 0)
					{
						this.dgv_atuador3.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador3.Rows[e.RowIndex].Cells[6].Value));
						RT_geral.RT_820_360_BD.config_atuador3_histerese[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador3.Rows[e.RowIndex].Cells[6].Value);
					}
					else if (Operators.CompareString(text, "Col_V1Baixo", false) == 0)
					{
						this.dgv_atuador3.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador3.Rows[e.RowIndex].Cells[9].Value));
						RT_geral.RT_820_360_BD.config_atuador3_v1baixo[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador3.Rows[e.RowIndex].Cells[9].Value);
					}
					else if (Operators.CompareString(text, "Col_V1Alto", false) == 0)
					{
						this.dgv_atuador3.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador3.Rows[e.RowIndex].Cells[10].Value));
						RT_geral.RT_820_360_BD.config_atuador3_v1alto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador3.Rows[e.RowIndex].Cells[10].Value);
					}
					else if (Operators.CompareString(text, "Col_V2Baixo", false) == 0)
					{
						this.dgv_atuador3.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador3.Rows[e.RowIndex].Cells[11].Value));
						RT_geral.RT_820_360_BD.config_atuador3_v2baixo[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador3.Rows[e.RowIndex].Cells[11].Value);
					}
					else if (Operators.CompareString(text, "Col_V2Alto", false) == 0)
					{
						this.dgv_atuador3.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador3.Rows[e.RowIndex].Cells[12].Value));
						RT_geral.RT_820_360_BD.config_atuador3_v2alto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador3.Rows[e.RowIndex].Cells[12].Value);
					}
				}
			}
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x0036EC10 File Offset: 0x0036D010
		private void dgv_atuador4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			checked
			{
				int num = 0;
				int valor = 0;
				if (RT_geral.RT_820_DataGrigViewAtuador4Colunas[e.ColumnIndex].NumeroLinhaMenu > 0)
				{
					num = -1;
					DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.dgv_atuador4.Rows[e.RowIndex].Cells[e.ColumnIndex];
					int num2 = 0;
					int num3 = dataGridViewComboBoxCell.Items.Count - 1;
					for (int i = num2; i <= num3; i++)
					{
						if (Operators.ConditionalCompareObjectEqual(dataGridViewComboBoxCell.Value, dataGridViewComboBoxCell.Items[i], false))
						{
							num = i;
							break;
						}
					}
					valor = RT_geral.RT_820_DataGrigViewAtuador4Colunas[e.ColumnIndex].LinhasValor[num];
				}
				string dataPropertyName = this.dgv_atuador2.Columns[e.ColumnIndex].DataPropertyName;
				string text = dataPropertyName;
				if (Operators.CompareString(text, "Col_perif", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_perif[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador4_perif[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_var1[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador4_var1[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_var2[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador4_var2[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_format", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_formato[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador4_formato[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_base10", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_atuador4_base10[e.RowIndex].Valor = valor;
					RT_geral.RT_820_360_BD.config_atuador4_base10[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_endmem", false) == 0)
				{
					this.dgv_atuador4.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador4.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_360_BD.config_atuador4_mem[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador4.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(text, "Col_escala1", false) == 0)
				{
					this.dgv_atuador4.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador4.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_820_360_BD.config_atuador4_escala1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador4.Rows[e.RowIndex].Cells[3].Value);
				}
				else if (Operators.CompareString(text, "Col_escala2", false) == 0)
				{
					this.dgv_atuador4.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador4.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_820_360_BD.config_atuador4_escala2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador4.Rows[e.RowIndex].Cells[5].Value);
				}
				else if (Operators.CompareString(text, "Col_redut", false) != 0)
				{
					if (Operators.CompareString(text, "Col_hist", false) == 0)
					{
						this.dgv_atuador4.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador4.Rows[e.RowIndex].Cells[6].Value));
						RT_geral.RT_820_360_BD.config_atuador4_histerese[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador4.Rows[e.RowIndex].Cells[6].Value);
					}
					else if (Operators.CompareString(text, "Col_V1Baixo", false) == 0)
					{
						this.dgv_atuador4.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador4.Rows[e.RowIndex].Cells[9].Value));
						RT_geral.RT_820_360_BD.config_atuador4_v1baixo[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador4.Rows[e.RowIndex].Cells[9].Value);
					}
					else if (Operators.CompareString(text, "Col_V1Alto", false) == 0)
					{
						this.dgv_atuador4.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador4.Rows[e.RowIndex].Cells[10].Value));
						RT_geral.RT_820_360_BD.config_atuador4_v1alto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador4.Rows[e.RowIndex].Cells[10].Value);
					}
					else if (Operators.CompareString(text, "Col_V2Baixo", false) == 0)
					{
						this.dgv_atuador4.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador4.Rows[e.RowIndex].Cells[11].Value));
						RT_geral.RT_820_360_BD.config_atuador4_v2baixo[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador4.Rows[e.RowIndex].Cells[11].Value);
					}
					else if (Operators.CompareString(text, "Col_V2Alto", false) == 0)
					{
						this.dgv_atuador4.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador4.Rows[e.RowIndex].Cells[12].Value));
						RT_geral.RT_820_360_BD.config_atuador4_v2alto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador4.Rows[e.RowIndex].Cells[12].Value);
					}
				}
			}
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x0036F43C File Offset: 0x0036D83C
		private void dgv_atuador_setpoint3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.dgv_atuador_setpoint3.Columns[e.ColumnIndex].DataPropertyName;
			string text = dataPropertyName;
			if (Operators.CompareString(text, "Col_Hora", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[0].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_hora[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(text, "Col_Minuto", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_minuto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref1", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[2].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[4].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[4].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[6].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[6].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[8].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[8].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[8].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[10].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[10].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[12].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_ref6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[12].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[3].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[5].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[5].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[7].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[9].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[9].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[11].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[11].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[13].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[13].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint1_setp6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[13].Value);
			}
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x0036FE80 File Offset: 0x0036E280
		private void dgv_atuador_setpoint31_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.dgv_atuador_setpoint31.Columns[e.ColumnIndex].DataPropertyName;
			string text = dataPropertyName;
			if (Operators.CompareString(text, "Col_Ref1", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[0].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[2].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[4].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[4].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[6].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[6].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[8].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[8].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[8].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[10].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_ref6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[10].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[3].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[5].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[5].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[7].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[9].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[9].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[11].Value));
				RT_geral.RT_820_360_BD.config_atuador3_setpoint2_setp6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[11].Value);
			}
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x00370750 File Offset: 0x0036EB50
		private void dgv_atuador_setpoint4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.dgv_atuador_setpoint4.Columns[e.ColumnIndex].DataPropertyName;
			string text = dataPropertyName;
			if (Operators.CompareString(text, "Col_Hora", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[0].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_hora[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(text, "Col_Minuto", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_minuto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref1", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[2].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[4].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[4].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[6].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[6].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[8].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[8].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[8].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[10].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[10].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[12].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_ref6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[12].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[3].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[5].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[5].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[7].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[9].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[9].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[11].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[11].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[13].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[13].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint1_setp6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[13].Value);
			}
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00371194 File Offset: 0x0036F594
		private void dgv_atuador_setpoint41_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.dgv_atuador_setpoint41.Columns[e.ColumnIndex].DataPropertyName;
			string text = dataPropertyName;
			if (Operators.CompareString(text, "Col_Ref1", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[0].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[2].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[4].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[4].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[6].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[6].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[8].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[8].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[8].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[10].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_ref6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[10].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[3].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[5].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[5].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[7].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[9].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[9].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[11].Value));
				RT_geral.RT_820_360_BD.config_atuador4_setpoint2_setp6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[11].Value);
			}
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00371A64 File Offset: 0x0036FE64
		private void ComboBox_baudrate_COM1_820_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.BaudRateCOM1.Indice = 0;
			RT_geral.RT_820_360_BD.BaudRateCOM1.AtualizaValorPeloIndice();
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00371AA0 File Offset: 0x0036FEA0
		private void ckb_tratamento_setpoint_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
				RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor = 1;
			}
			else
			{
				RT_geral.RT_820_360_BD.Setpoint_ctrl_tratamento_percentual.Valor = 0;
			}
			this.Atualiza_TelaRT820();
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00371AF8 File Offset: 0x0036FEF8
		private void NumericUpDown_end2_est_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.End_estacao2.Valor = 0;
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_360_BD.End_estacao2, true);
			sender = numericUpDown;
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00371B4C File Offset: 0x0036FF4C
		private void DataGridView_periferico2_RT820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_periferico2_RT820.IsCurrentCellDirty)
			{
				this.DataGridView_periferico2_RT820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00371B6C File Offset: 0x0036FF6C
		private void DataGridView_periferico2_RT820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_periferico1_RT820.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_end", false) == 0)
			{
				RT_geral.RT_820_360_BD.config_perifericos2_end[e.RowIndex].Valor = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue))));
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_perifericos2_end[e.RowIndex], e, true);
				sender = dataGridView;
			}
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00371C00 File Offset: 0x00370000
		private void DataGridView_periferico2_RT820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_periferico2_RT820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_modelo", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_periferico2_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					for (int i = num; i <= num2; i++)
					{
						if (Operators.CompareString(RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							RT_geral.RT_820_360_BD.config_perifericos2_mod[e.RowIndex].Valor = RT_geral.RT_820_360_DataGrigViewPerifericos2Colunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_360_BD.config_perifericos2_mod[e.RowIndex].Indice = i;
							break;
						}
					}
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end", false) == 0)
				{
					this.DataGridView_periferico2_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_periferico2_RT820.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_360_BD.config_perifericos2_end[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_periferico2_RT820.Rows[e.RowIndex].Cells[1].Value);
				}
			}
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00371DC8 File Offset: 0x003701C8
		private void DataGridView_perifericomodbusgenerico_RT820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_perifericomodbusgenerico_RT820.IsCurrentCellDirty)
			{
				this.DataGridView_perifericomodbusgenerico_RT820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x00371DE8 File Offset: 0x003701E8
		private void DataGridView_perifericomodbusgenerico_RT820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_perifericomodbusgenerico_RT820.Columns[e.ColumnIndex].DataPropertyName;
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_end", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_endcom[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_periferico_modbus_generico_endcom[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_mem1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_mem2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_mem3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_mem4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_var1", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_var2", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_var3", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_var4", false) == 0)
				{
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var4[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x003721E0 File Offset: 0x003705E0
		private void DataGridView_perifericomodbusgenerico_RT820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_perifericomodbusgenerico_RT820.Columns[e.ColumnIndex].DataPropertyName;
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_end", false) == 0)
				{
					this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[0].Value));
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_endcom[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[0].Value);
				}
				else if (Operators.CompareString(text, "Col_mem1", false) == 0)
				{
					this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[2].Value));
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem1[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[2].Value);
				}
				else if (Operators.CompareString(text, "Col_mem2", false) == 0)
				{
					this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[4].Value));
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem2[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[4].Value);
				}
				else if (Operators.CompareString(text, "Col_mem3", false) == 0)
				{
					this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[6].Value));
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem3[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[6].Value);
				}
				else if (Operators.CompareString(text, "Col_mem4", false) == 0)
				{
					this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[8].Value));
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_mem4[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[8].Value);
				}
				else if (Operators.CompareString(text, "Col_var1", false) == 0)
				{
					this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var1[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[3].Value);
				}
				else if (Operators.CompareString(text, "Col_var2", false) == 0)
				{
					this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var2[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[5].Value);
				}
				else if (Operators.CompareString(text, "Col_var3", false) == 0)
				{
					this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[7].Value));
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var3[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[7].Value);
				}
				else if (Operators.CompareString(text, "Col_var4", false) == 0)
				{
					this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[9].Value));
					RT_geral.RT_820_360_BD.config_periferico_modbus_generico_var4[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[9].Value);
				}
				else if (Operators.CompareString(text, "Col_func", false) == 0)
				{
					string text2 = Conversions.ToString(this.DataGridView_perifericomodbusgenerico_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					for (int i = num; i <= num2; i++)
					{
						if (Operators.CompareString(RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[e.ColumnIndex].LinhasMenu[i], text2, false) == 0)
						{
							RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[e.RowIndex].Valor = RT_geral.RT_820_360_DatagridViewPerifericoModbusGenericoColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_360_BD.config_periferico_modbus_generico_funcao[e.RowIndex].Indice = i;
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x0037298C File Offset: 0x00370D8C
		private void TabPage_controle_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00372990 File Offset: 0x00370D90
		private void DataGridView_perifericomodbusgenerico_RT820_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00372994 File Offset: 0x00370D94
		private void DataGridView_vazoes_RT820_CellValidating_1(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00372998 File Offset: 0x00370D98
		private void DataGridView_vazoes_RT820_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_vazoes_RT820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_Entrada", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_vazoes_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_820_DataGrigViewVazoesColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					int i = num;
					while (i <= num2)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewVazoesColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							string dataPropertyName2 = this.DataGridView_vazoes_RT820.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName2, "Col_Entrada", false) == 0)
							{
								RT_geral.RT_820_360_BD.config_vazao[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewVazoesColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_360_BD.config_vazao[e.RowIndex].Indice = i;
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

		// Token: 0x06001673 RID: 5747 RVA: 0x00372AD4 File Offset: 0x00370ED4
		private void DataGridView_vazoes_RT820_CurrentCellDirtyStateChanged_1(object sender, EventArgs e)
		{
			if (this.DataGridView_vazoes_RT820.IsCurrentCellDirty)
			{
				this.DataGridView_vazoes_RT820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00372AF4 File Offset: 0x00370EF4
		private void DataGridView_periferico2_RT820_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00372AF8 File Offset: 0x00370EF8
		private void DataGridView_processo_820_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00372AFC File Offset: 0x00370EFC
		private void DataGridView_calhas_RT820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (e.RowIndex < 0)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_calhas_RT820.Columns[e.ColumnIndex].DataPropertyName;
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_fundo_cm", false) == 0)
				{
					RT_geral.RT_820_360_BD.calha_fundo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.calha_fundo[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_p1", false) == 0)
				{
					RT_geral.RT_820_360_BD.calha_p1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.calha_p1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_p2", false) == 0)
				{
					RT_geral.RT_820_360_BD.calha_p2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.calha_p2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_p3", false) == 0)
				{
					RT_geral.RT_820_360_BD.calha_p3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_360_BD.calha_p3[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00372CE0 File Offset: 0x003710E0
		private void DataGridView_calhas_RT820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 | e.ColumnIndex < 0)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_calhas_RT820.Columns[e.ColumnIndex].DataPropertyName;
			string text = dataPropertyName;
			checked
			{
				if (Operators.CompareString(text, "Col_ea", false) == 0)
				{
					string text2 = Conversions.ToString(this.DataGridView_calhas_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_820_DatagridViewCalhasColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					for (int i = num; i <= num2; i++)
					{
						if (Operators.CompareString(RT_geral.RT_820_DatagridViewCalhasColunas[e.ColumnIndex].LinhasMenu[i], text2, false) == 0)
						{
							RT_geral.RT_820_360_BD.calha_EA[e.RowIndex].Valor = RT_geral.RT_820_DatagridViewCalhasColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_360_BD.calha_EA[e.RowIndex].Indice = i;
							break;
						}
					}
				}
				else if (Operators.CompareString(text, "Col_calha", false) == 0)
				{
					string text2 = Conversions.ToString(this.DataGridView_calhas_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num3 = 0;
					int num4 = RT_geral.RT_820_DatagridViewCalhasColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					for (int i = num3; i <= num4; i++)
					{
						if (Operators.CompareString(RT_geral.RT_820_DatagridViewCalhasColunas[e.ColumnIndex].LinhasMenu[i], text2, false) == 0)
						{
							RT_geral.RT_820_360_BD.calha_modelo[e.RowIndex].Valor = RT_geral.RT_820_DatagridViewCalhasColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_360_BD.calha_modelo[e.RowIndex].Indice = i;
							break;
						}
					}
				}
				else if (Operators.CompareString(text, "Col_fundo_cm", false) == 0)
				{
					this.DataGridView_calhas_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_calhas_RT820.Rows[e.RowIndex].Cells[2].Value));
					RT_geral.RT_820_360_BD.calha_fundo[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_calhas_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				}
				else if (Operators.CompareString(text, "Col_p1", false) == 0)
				{
					this.DataGridView_calhas_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_calhas_RT820.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_820_360_BD.calha_p1[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_calhas_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				}
				else if (Operators.CompareString(text, "Col_p2", false) == 0)
				{
					this.DataGridView_calhas_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_calhas_RT820.Rows[e.RowIndex].Cells[4].Value));
					RT_geral.RT_820_360_BD.calha_p2[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_calhas_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				}
				else if (Operators.CompareString(text, "Col_p3", false) == 0)
				{
					this.DataGridView_calhas_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_calhas_RT820.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_820_360_BD.calha_p3[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_calhas_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
				}
			}
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x003731E0 File Offset: 0x003715E0
		private void DataGridView_calhas_RT820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_calhas_RT820.IsCurrentCellDirty)
			{
				this.DataGridView_calhas_RT820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00373200 File Offset: 0x00371600
		private void cb_SA_1_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.saida_SA_origem[0].Indice = 0;
			RT_geral.RT_820_360_BD.saida_SA_origem[0].AtualizaValorPeloIndice();
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00373254 File Offset: 0x00371654
		private void cb_SA_2_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.saida_SA_origem[1].Indice = 0;
			RT_geral.RT_820_360_BD.saida_SA_origem[1].AtualizaValorPeloIndice();
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x003732A8 File Offset: 0x003716A8
		private void nud_zero1_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0].Valor = 0;
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[0], true);
			sender = numericUpDown;
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00373308 File Offset: 0x00371708
		private void nud_zero2_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[1].Valor = 0;
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_360_BD.saida_SA_contagem_4mA[1], true);
			sender = numericUpDown;
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00373368 File Offset: 0x00371768
		private void nud_ganho1_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[0].Valor = 0;
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[0], true);
			sender = numericUpDown;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x003733C8 File Offset: 0x003717C8
		private void nud_ganho2_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[1].Valor = 0;
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_360_BD.saida_SA_contagem_20mA[1], true);
			sender = numericUpDown;
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00373428 File Offset: 0x00371828
		private void DataGridView_grupos_820_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x04000ACB RID: 2763
		[AccessedThroughProperty("GroupBox_sistema_leitura")]
		private GroupBox _GroupBox_sistema_leitura;

		// Token: 0x04000ACC RID: 2764
		[AccessedThroughProperty("CheckBox_hab_eletrodos")]
		private CheckBox _CheckBox_hab_eletrodos;

		// Token: 0x04000ACD RID: 2765
		[AccessedThroughProperty("GroupBox_operacao")]
		private GroupBox _GroupBox_operacao;

		// Token: 0x04000ACE RID: 2766
		[AccessedThroughProperty("ComboBox_metodo_operacao")]
		private ComboBox _ComboBox_metodo_operacao;

		// Token: 0x04000ACF RID: 2767
		[AccessedThroughProperty("NumericUpDown_intervalo_tx")]
		private NumericUpDown _NumericUpDown_intervalo_tx;

		// Token: 0x04000AD0 RID: 2768
		[AccessedThroughProperty("Label_metodo_operacao")]
		private Label _Label_metodo_operacao;

		// Token: 0x04000AD1 RID: 2769
		[AccessedThroughProperty("Label_intevalo_tx_pto_pto")]
		private Label _Label_intevalo_tx_pto_pto;

		// Token: 0x04000AD2 RID: 2770
		[AccessedThroughProperty("GroupBox_informacoes")]
		private GroupBox _GroupBox_informacoes;

		// Token: 0x04000AD3 RID: 2771
		[AccessedThroughProperty("TextBox_equipamento")]
		private TextBox _TextBox_equipamento;

		// Token: 0x04000AD4 RID: 2772
		[AccessedThroughProperty("Label_equipamento")]
		private Label _Label_equipamento;

		// Token: 0x04000AD5 RID: 2773
		[AccessedThroughProperty("TextBox_release")]
		private TextBox _TextBox_release;

		// Token: 0x04000AD6 RID: 2774
		[AccessedThroughProperty("Label_release")]
		private Label _Label_release;

		// Token: 0x04000AD7 RID: 2775
		[AccessedThroughProperty("TextBox_build")]
		private TextBox _TextBox_build;

		// Token: 0x04000AD8 RID: 2776
		[AccessedThroughProperty("Label_build")]
		private Label _Label_build;

		// Token: 0x04000AD9 RID: 2777
		[AccessedThroughProperty("TextBox_versao")]
		private TextBox _TextBox_versao;

		// Token: 0x04000ADA RID: 2778
		[AccessedThroughProperty("Label_versao")]
		private Label _Label_versao;

		// Token: 0x04000ADB RID: 2779
		[AccessedThroughProperty("GroupBox_modelo_simulado")]
		private GroupBox _GroupBox_modelo_simulado;

		// Token: 0x04000ADC RID: 2780
		[AccessedThroughProperty("ComboBox_modo_simulado")]
		private ComboBox _ComboBox_modo_simulado;

		// Token: 0x04000ADD RID: 2781
		[AccessedThroughProperty("GroupBox_comunicacao")]
		private GroupBox _GroupBox_comunicacao;

		// Token: 0x04000ADE RID: 2782
		[AccessedThroughProperty("NumericUpDown_temp_ptt")]
		private NumericUpDown _NumericUpDown_temp_ptt;

		// Token: 0x04000ADF RID: 2783
		[AccessedThroughProperty("NumericUpDown_end_mestre")]
		private NumericUpDown _NumericUpDown_end_mestre;

		// Token: 0x04000AE0 RID: 2784
		[AccessedThroughProperty("NumericUpDown_end_est")]
		private NumericUpDown _NumericUpDown_end_est;

		// Token: 0x04000AE1 RID: 2785
		[AccessedThroughProperty("Label_tempo_ptt")]
		private Label _Label_tempo_ptt;

		// Token: 0x04000AE2 RID: 2786
		[AccessedThroughProperty("Label_end_mestre")]
		private Label _Label_end_mestre;

		// Token: 0x04000AE3 RID: 2787
		[AccessedThroughProperty("Label_end_est")]
		private Label _Label_end_est;

		// Token: 0x04000AE4 RID: 2788
		[AccessedThroughProperty("OpenFileDialog_RT_820")]
		private OpenFileDialog _OpenFileDialog_RT_820;

		// Token: 0x04000AE5 RID: 2789
		[AccessedThroughProperty("SaveFileDialog_RT_820")]
		private SaveFileDialog _SaveFileDialog_RT_820;

		// Token: 0x04000AE6 RID: 2790
		[AccessedThroughProperty("TabControl_820")]
		private TabControl _TabControl_820;

		// Token: 0x04000AE7 RID: 2791
		[AccessedThroughProperty("TabPage_geral")]
		private TabPage _TabPage_geral;

		// Token: 0x04000AE8 RID: 2792
		[AccessedThroughProperty("GroupBox_informacoes_820")]
		private GroupBox _GroupBox_informacoes_820;

		// Token: 0x04000AE9 RID: 2793
		[AccessedThroughProperty("GroupBox_comunicacao_820")]
		private GroupBox _GroupBox_comunicacao_820;

		// Token: 0x04000AEA RID: 2794
		[AccessedThroughProperty("NumericUpDown_temp_ptt_820")]
		private NumericUpDown _NumericUpDown_temp_ptt_820;

		// Token: 0x04000AEB RID: 2795
		[AccessedThroughProperty("NumericUpDown_end_mestre_820")]
		private NumericUpDown _NumericUpDown_end_mestre_820;

		// Token: 0x04000AEC RID: 2796
		[AccessedThroughProperty("NumericUpDown_end1_est_820")]
		private NumericUpDown _NumericUpDown_end1_est_820;

		// Token: 0x04000AED RID: 2797
		[AccessedThroughProperty("Label_tempo_ptt_820")]
		private Label _Label_tempo_ptt_820;

		// Token: 0x04000AEE RID: 2798
		[AccessedThroughProperty("Label_end_mestre_820")]
		private Label _Label_end_mestre_820;

		// Token: 0x04000AEF RID: 2799
		[AccessedThroughProperty("Label_end_est_820")]
		private Label _Label_end_est_820;

		// Token: 0x04000AF0 RID: 2800
		[AccessedThroughProperty("TabPage_EA")]
		private TabPage _TabPage_EA;

		// Token: 0x04000AF1 RID: 2801
		[AccessedThroughProperty("GroupBox_parametros_EA_820")]
		private GroupBox _GroupBox_parametros_EA_820;

		// Token: 0x04000AF2 RID: 2802
		[AccessedThroughProperty("DataGridView_parametros_EA_820")]
		private DataGridView _DataGridView_parametros_EA_820;

		// Token: 0x04000AF3 RID: 2803
		[AccessedThroughProperty("GroupBox_EA_820")]
		private GroupBox _GroupBox_EA_820;

		// Token: 0x04000AF4 RID: 2804
		[AccessedThroughProperty("NumericUpDown_intervalo_filtro_820")]
		private NumericUpDown _NumericUpDown_intervalo_filtro_820;

		// Token: 0x04000AF5 RID: 2805
		[AccessedThroughProperty("NumericUpDown_tamanho_filtro_820")]
		private NumericUpDown _NumericUpDown_tamanho_filtro_820;

		// Token: 0x04000AF6 RID: 2806
		[AccessedThroughProperty("Label_intervalo_filtro_820")]
		private Label _Label_intervalo_filtro_820;

		// Token: 0x04000AF7 RID: 2807
		[AccessedThroughProperty("Label_tamanho_filtro_820")]
		private Label _Label_tamanho_filtro_820;

		// Token: 0x04000AF8 RID: 2808
		[AccessedThroughProperty("TabPage_ED")]
		private TabPage _TabPage_ED;

		// Token: 0x04000AF9 RID: 2809
		[AccessedThroughProperty("TabPage_setpoints")]
		private TabPage _TabPage_setpoints;

		// Token: 0x04000AFA RID: 2810
		[AccessedThroughProperty("TabPage_vazao_perifericos")]
		private TabPage _TabPage_vazao_perifericos;

		// Token: 0x04000AFB RID: 2811
		[AccessedThroughProperty("TabPage_repetidora")]
		private TabPage _TabPage_repetidora;

		// Token: 0x04000AFC RID: 2812
		[AccessedThroughProperty("GroupBox_end_rep_820")]
		private GroupBox _GroupBox_end_rep_820;

		// Token: 0x04000AFD RID: 2813
		[AccessedThroughProperty("DataGridView_end_rep_RT820")]
		private DataGridView _DataGridView_end_rep_RT820;

		// Token: 0x04000AFE RID: 2814
		[AccessedThroughProperty("GroupBox_parametros_repetidora_820")]
		private GroupBox _GroupBox_parametros_repetidora_820;

		// Token: 0x04000AFF RID: 2815
		[AccessedThroughProperty("NumericUpDown_num_est_rep_820")]
		private NumericUpDown _NumericUpDown_num_est_rep_820;

		// Token: 0x04000B00 RID: 2816
		[AccessedThroughProperty("NumericUpDown_end_rep_820")]
		private NumericUpDown _NumericUpDown_end_rep_820;

		// Token: 0x04000B01 RID: 2817
		[AccessedThroughProperty("Label_num_est_rep_820")]
		private Label _Label_num_est_rep_820;

		// Token: 0x04000B02 RID: 2818
		[AccessedThroughProperty("Label_end_rep_820")]
		private Label _Label_end_rep_820;

		// Token: 0x04000B03 RID: 2819
		[AccessedThroughProperty("ToolStri_RT_820")]
		private ToolStrip _ToolStri_RT_820;

		// Token: 0x04000B04 RID: 2820
		[AccessedThroughProperty("ToolStripButton_RT_820_novo")]
		private ToolStripButton _ToolStripButton_RT_820_novo;

		// Token: 0x04000B05 RID: 2821
		[AccessedThroughProperty("ToolStripButton_RT_820_Abrir")]
		private ToolStripButton _ToolStripButton_RT_820_Abrir;

		// Token: 0x04000B06 RID: 2822
		[AccessedThroughProperty("ToolStripButton_RT_820_Salvar")]
		private ToolStripButton _ToolStripButton_RT_820_Salvar;

		// Token: 0x04000B07 RID: 2823
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x04000B08 RID: 2824
		[AccessedThroughProperty("ToolStripButton_RT_820_Download")]
		private ToolStripButton _ToolStripButton_RT_820_Download;

		// Token: 0x04000B09 RID: 2825
		[AccessedThroughProperty("ToolStripButton_RT_820_Upload")]
		private ToolStripButton _ToolStripButton_RT_820_Upload;

		// Token: 0x04000B0A RID: 2826
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x04000B0B RID: 2827
		[AccessedThroughProperty("ToolStripTextBox_RT_820_Msg")]
		private ToolStripTextBox _ToolStripTextBox_RT_820_Msg;

		// Token: 0x04000B0C RID: 2828
		[AccessedThroughProperty("ToolStripProgressBar_RT_820")]
		private ToolStripProgressBar _ToolStripProgressBar_RT_820;

		// Token: 0x04000B0D RID: 2829
		[AccessedThroughProperty("GroupBox_parametros_interface_820")]
		private GroupBox _GroupBox_parametros_interface_820;

		// Token: 0x04000B0E RID: 2830
		[AccessedThroughProperty("CheckBox_hab_expansao_IO_820")]
		private CheckBox _CheckBox_hab_expansao_IO_820;

		// Token: 0x04000B0F RID: 2831
		[AccessedThroughProperty("ComboBox_baudrate_COM2_820")]
		private ComboBox _ComboBox_baudrate_COM2_820;

		// Token: 0x04000B10 RID: 2832
		[AccessedThroughProperty("Label_baudrate_COM2_820")]
		private Label _Label_baudrate_COM2_820;

		// Token: 0x04000B11 RID: 2833
		[AccessedThroughProperty("TabPage_controle")]
		private TabPage _TabPage_controle;

		// Token: 0x04000B12 RID: 2834
		[AccessedThroughProperty("GroupBox_controle_820")]
		private GroupBox _GroupBox_controle_820;

		// Token: 0x04000B13 RID: 2835
		[AccessedThroughProperty("DataGridView_processo_820")]
		private DataGridView _DataGridView_processo_820;

		// Token: 0x04000B14 RID: 2836
		[AccessedThroughProperty("GroupBox_Agrupamento_820")]
		private GroupBox _GroupBox_Agrupamento_820;

		// Token: 0x04000B15 RID: 2837
		[AccessedThroughProperty("DataGridView_grupos_820")]
		private DataGridView _DataGridView_grupos_820;

		// Token: 0x04000B16 RID: 2838
		[AccessedThroughProperty("GroupBox_perifericos_820")]
		private GroupBox _GroupBox_perifericos_820;

		// Token: 0x04000B17 RID: 2839
		[AccessedThroughProperty("DataGridView_periferico1_RT820")]
		private DataGridView _DataGridView_periferico1_RT820;

		// Token: 0x04000B18 RID: 2840
		[AccessedThroughProperty("DataGridView_setpoints_820")]
		private DataGridView _DataGridView_setpoints_820;

		// Token: 0x04000B19 RID: 2841
		[AccessedThroughProperty("GroupBox_setpoints_820")]
		private GroupBox _GroupBox_setpoints_820;

		// Token: 0x04000B1A RID: 2842
		[AccessedThroughProperty("Timer_limpa_MSG_820")]
		private Timer _Timer_limpa_MSG_820;

		// Token: 0x04000B1B RID: 2843
		[AccessedThroughProperty("GroupBox_descricao_RT820")]
		private GroupBox _GroupBox_descricao_RT820;

		// Token: 0x04000B1C RID: 2844
		[AccessedThroughProperty("TextBox_comentarios_RT820")]
		private TextBox _TextBox_comentarios_RT820;

		// Token: 0x04000B1D RID: 2845
		[AccessedThroughProperty("TextBox_endereco_RT820")]
		private TextBox _TextBox_endereco_RT820;

		// Token: 0x04000B1E RID: 2846
		[AccessedThroughProperty("TextBox_nome_RT820")]
		private TextBox _TextBox_nome_RT820;

		// Token: 0x04000B1F RID: 2847
		[AccessedThroughProperty("Label_comentarios")]
		private Label _Label_comentarios;

		// Token: 0x04000B20 RID: 2848
		[AccessedThroughProperty("Label_endereco")]
		private Label _Label_endereco;

		// Token: 0x04000B21 RID: 2849
		[AccessedThroughProperty("Label_nome")]
		private Label _Label_nome;

		// Token: 0x04000B22 RID: 2850
		[AccessedThroughProperty("TabPage_timer")]
		private TabPage _TabPage_timer;

		// Token: 0x04000B23 RID: 2851
		[AccessedThroughProperty("GroupBox_timer")]
		private GroupBox _GroupBox_timer;

		// Token: 0x04000B24 RID: 2852
		[AccessedThroughProperty("DataGridView_timer_RT820")]
		private DataGridView _DataGridView_timer_RT820;

		// Token: 0x04000B25 RID: 2853
		[AccessedThroughProperty("DataGridView1")]
		private DataGridView _DataGridView1;

		// Token: 0x04000B26 RID: 2854
		[AccessedThroughProperty("Column2")]
		private DataGridViewTextBoxColumn _Column2;

		// Token: 0x04000B27 RID: 2855
		[AccessedThroughProperty("Column3")]
		private DataGridViewTextBoxColumn _Column3;

		// Token: 0x04000B28 RID: 2856
		[AccessedThroughProperty("Column4")]
		private DataGridViewTextBoxColumn _Column4;

		// Token: 0x04000B29 RID: 2857
		[AccessedThroughProperty("Column5")]
		private DataGridViewTextBoxColumn _Column5;

		// Token: 0x04000B2A RID: 2858
		[AccessedThroughProperty("Column6")]
		private DataGridViewTextBoxColumn _Column6;

		// Token: 0x04000B2B RID: 2859
		[AccessedThroughProperty("Column7")]
		private DataGridViewTextBoxColumn _Column7;

		// Token: 0x04000B2C RID: 2860
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000B2D RID: 2861
		[AccessedThroughProperty("GroupBox_ED_820")]
		private GroupBox _GroupBox_ED_820;

		// Token: 0x04000B2E RID: 2862
		[AccessedThroughProperty("DataGridView_RT820_ED")]
		private DataGridView _DataGridView_RT820_ED;

		// Token: 0x04000B2F RID: 2863
		[AccessedThroughProperty("ToolStripButton_RT820_Imprimir")]
		private ToolStripButton _ToolStripButton_RT820_Imprimir;

		// Token: 0x04000B30 RID: 2864
		[AccessedThroughProperty("PrintDocument1")]
		private PrintDocument _PrintDocument1;

		// Token: 0x04000B31 RID: 2865
		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		// Token: 0x04000B32 RID: 2866
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000B33 RID: 2867
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x04000B34 RID: 2868
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x04000B35 RID: 2869
		[AccessedThroughProperty("T_ModeloFonte")]
		private TextBox _T_ModeloFonte;

		// Token: 0x04000B36 RID: 2870
		[AccessedThroughProperty("T_AlturaAntena")]
		private TextBox _T_AlturaAntena;

		// Token: 0x04000B37 RID: 2871
		[AccessedThroughProperty("T_Latitude")]
		private TextBox _T_Latitude;

		// Token: 0x04000B38 RID: 2872
		[AccessedThroughProperty("T_Longitude")]
		private TextBox _T_Longitude;

		// Token: 0x04000B39 RID: 2873
		[AccessedThroughProperty("T_Azimute")]
		private TextBox _T_Azimute;

		// Token: 0x04000B3A RID: 2874
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000B3B RID: 2875
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000B3C RID: 2876
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000B3D RID: 2877
		[AccessedThroughProperty("T_FreqRadio")]
		private TextBox _T_FreqRadio;

		// Token: 0x04000B3E RID: 2878
		[AccessedThroughProperty("T_DistCentral")]
		private TextBox _T_DistCentral;

		// Token: 0x04000B3F RID: 2879
		[AccessedThroughProperty("T_PotRadio")]
		private TextBox _T_PotRadio;

		// Token: 0x04000B40 RID: 2880
		[AccessedThroughProperty("CB_ModeloRadio")]
		private ComboBox _CB_ModeloRadio;

		// Token: 0x04000B41 RID: 2881
		[AccessedThroughProperty("CB_PolarizacaoAntena")]
		private ComboBox _CB_PolarizacaoAntena;

		// Token: 0x04000B42 RID: 2882
		[AccessedThroughProperty("CB_TipoAntena")]
		private ComboBox _CB_TipoAntena;

		// Token: 0x04000B43 RID: 2883
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000B44 RID: 2884
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000B45 RID: 2885
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000B46 RID: 2886
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000B47 RID: 2887
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000B48 RID: 2888
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000B49 RID: 2889
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000B4A RID: 2890
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000B4B RID: 2891
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000B4C RID: 2892
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000B4D RID: 2893
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x04000B4E RID: 2894
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x04000B4F RID: 2895
		[AccessedThroughProperty("PrintPreviewDialog1")]
		private PrintPreviewDialog _PrintPreviewDialog1;

		// Token: 0x04000B50 RID: 2896
		[AccessedThroughProperty("ToolStripLabel1")]
		private ToolStripLabel _ToolStripLabel1;

		// Token: 0x04000B51 RID: 2897
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x04000B52 RID: 2898
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		// Token: 0x04000B53 RID: 2899
		[AccessedThroughProperty("TextBox_equipamento_820")]
		private TextBox _TextBox_equipamento_820;

		// Token: 0x04000B54 RID: 2900
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x04000B55 RID: 2901
		[AccessedThroughProperty("TextBox_release_820")]
		private TextBox _TextBox_release_820;

		// Token: 0x04000B56 RID: 2902
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x04000B57 RID: 2903
		[AccessedThroughProperty("TextBox_build_820")]
		private TextBox _TextBox_build_820;

		// Token: 0x04000B58 RID: 2904
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x04000B59 RID: 2905
		[AccessedThroughProperty("TextBox_versao_820")]
		private TextBox _TextBox_versao_820;

		// Token: 0x04000B5A RID: 2906
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		// Token: 0x04000B5B RID: 2907
		[AccessedThroughProperty("tb_lixo1")]
		private TextBox _tb_lixo1;

		// Token: 0x04000B5C RID: 2908
		[AccessedThroughProperty("tb_lixo2")]
		private TextBox _tb_lixo2;

		// Token: 0x04000B5D RID: 2909
		[AccessedThroughProperty("tb_lixo3")]
		private TextBox _tb_lixo3;

		// Token: 0x04000B5E RID: 2910
		[AccessedThroughProperty("tb_lixo4")]
		private TextBox _tb_lixo4;

		// Token: 0x04000B5F RID: 2911
		[AccessedThroughProperty("tb_lixo5")]
		private TextBox _tb_lixo5;

		// Token: 0x04000B60 RID: 2912
		[AccessedThroughProperty("tb_lixo7")]
		private TextBox _tb_lixo7;

		// Token: 0x04000B61 RID: 2913
		[AccessedThroughProperty("tb_lixo8")]
		private TextBox _tb_lixo8;

		// Token: 0x04000B62 RID: 2914
		[AccessedThroughProperty("tb_lixo9")]
		private TextBox _tb_lixo9;

		// Token: 0x04000B63 RID: 2915
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000B64 RID: 2916
		[AccessedThroughProperty("dgv_sph")]
		private DataGridView _dgv_sph;

		// Token: 0x04000B65 RID: 2917
		[AccessedThroughProperty("Label73")]
		private Label _Label73;

		// Token: 0x04000B66 RID: 2918
		[AccessedThroughProperty("col_sph_horario")]
		private DataGridViewTextBoxColumn _col_sph_horario;

		// Token: 0x04000B67 RID: 2919
		[AccessedThroughProperty("col_sph_ativa")]
		private DataGridViewCheckBoxColumn _col_sph_ativa;

		// Token: 0x04000B68 RID: 2920
		[AccessedThroughProperty("col_sph_hora")]
		private DataGridViewTextBoxColumn _col_sph_hora;

		// Token: 0x04000B69 RID: 2921
		[AccessedThroughProperty("col_sph_minuto")]
		private DataGridViewTextBoxColumn _col_sph_minuto;

		// Token: 0x04000B6A RID: 2922
		[AccessedThroughProperty("col_sph_alto")]
		private DataGridViewTextBoxColumn _col_sph_alto;

		// Token: 0x04000B6B RID: 2923
		[AccessedThroughProperty("col_sph_baixo")]
		private DataGridViewTextBoxColumn _col_sph_baixo;

		// Token: 0x04000B6C RID: 2924
		[AccessedThroughProperty("cb_ModoRepetidora")]
		private ComboBox _cb_ModoRepetidora;

		// Token: 0x04000B6D RID: 2925
		[AccessedThroughProperty("Label29")]
		private Label _Label29;

		// Token: 0x04000B6E RID: 2926
		[AccessedThroughProperty("TabPage_Atuadores")]
		private TabPage _TabPage_Atuadores;

		// Token: 0x04000B6F RID: 2927
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x04000B70 RID: 2928
		[AccessedThroughProperty("dgv_atuador1")]
		private DataGridView _dgv_atuador1;

		// Token: 0x04000B71 RID: 2929
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x04000B72 RID: 2930
		[AccessedThroughProperty("datagridview_referenciaperifico")]
		private DataGridView _datagridview_referenciaperifico;

		// Token: 0x04000B73 RID: 2931
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x04000B74 RID: 2932
		[AccessedThroughProperty("dgv_atuador_setpoint2")]
		private DataGridView _dgv_atuador_setpoint2;

		// Token: 0x04000B75 RID: 2933
		[AccessedThroughProperty("dgv_atuador2")]
		private DataGridView _dgv_atuador2;

		// Token: 0x04000B76 RID: 2934
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		// Token: 0x04000B77 RID: 2935
		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		// Token: 0x04000B78 RID: 2936
		[AccessedThroughProperty("dgv_atuador_setpoint1")]
		private DataGridView _dgv_atuador_setpoint1;

		// Token: 0x04000B79 RID: 2937
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		// Token: 0x04000B7A RID: 2938
		[AccessedThroughProperty("dgv_atuador_setpoint11")]
		private DataGridView _dgv_atuador_setpoint11;

		// Token: 0x04000B7B RID: 2939
		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		// Token: 0x04000B7C RID: 2940
		[AccessedThroughProperty("dgv_atuador_setpoint21")]
		private DataGridView _dgv_atuador_setpoint21;

		// Token: 0x04000B7D RID: 2941
		[AccessedThroughProperty("Label28")]
		private Label _Label28;

		// Token: 0x04000B7E RID: 2942
		[AccessedThroughProperty("Label27")]
		private Label _Label27;

		// Token: 0x04000B7F RID: 2943
		[AccessedThroughProperty("nud_tempoforaar")]
		private NumericUpDown _nud_tempoforaar;

		// Token: 0x04000B80 RID: 2944
		[AccessedThroughProperty("Label30")]
		private Label _Label30;

		// Token: 0x04000B81 RID: 2945
		[AccessedThroughProperty("TabPage_Atuadores2")]
		private TabPage _TabPage_Atuadores2;

		// Token: 0x04000B82 RID: 2946
		[AccessedThroughProperty("GroupBox7")]
		private GroupBox _GroupBox7;

		// Token: 0x04000B83 RID: 2947
		[AccessedThroughProperty("dgv_atuador_setpoint41")]
		private DataGridView _dgv_atuador_setpoint41;

		// Token: 0x04000B84 RID: 2948
		[AccessedThroughProperty("Label33")]
		private Label _Label33;

		// Token: 0x04000B85 RID: 2949
		[AccessedThroughProperty("dgv_atuador_setpoint4")]
		private DataGridView _dgv_atuador_setpoint4;

		// Token: 0x04000B86 RID: 2950
		[AccessedThroughProperty("Label34")]
		private Label _Label34;

		// Token: 0x04000B87 RID: 2951
		[AccessedThroughProperty("dgv_atuador4")]
		private DataGridView _dgv_atuador4;

		// Token: 0x04000B88 RID: 2952
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		// Token: 0x04000B89 RID: 2953
		[AccessedThroughProperty("Label31")]
		private Label _Label31;

		// Token: 0x04000B8A RID: 2954
		[AccessedThroughProperty("Label32")]
		private Label _Label32;

		// Token: 0x04000B8B RID: 2955
		[AccessedThroughProperty("dgv_atuador_setpoint31")]
		private DataGridView _dgv_atuador_setpoint31;

		// Token: 0x04000B8C RID: 2956
		[AccessedThroughProperty("dgv_atuador_setpoint3")]
		private DataGridView _dgv_atuador_setpoint3;

		// Token: 0x04000B8D RID: 2957
		[AccessedThroughProperty("dgv_atuador3")]
		private DataGridView _dgv_atuador3;

		// Token: 0x04000B8E RID: 2958
		[AccessedThroughProperty("Label35")]
		private Label _Label35;

		// Token: 0x04000B8F RID: 2959
		[AccessedThroughProperty("ComboBox_baudrate_COM1_820")]
		private ComboBox _ComboBox_baudrate_COM1_820;

		// Token: 0x04000B90 RID: 2960
		[AccessedThroughProperty("Label36")]
		private Label _Label36;

		// Token: 0x04000B91 RID: 2961
		[AccessedThroughProperty("Label37")]
		private Label _Label37;

		// Token: 0x04000B92 RID: 2962
		[AccessedThroughProperty("GroupBox8")]
		private GroupBox _GroupBox8;

		// Token: 0x04000B93 RID: 2963
		[AccessedThroughProperty("ckb_tratamento_setpoint")]
		private CheckBox _ckb_tratamento_setpoint;

		// Token: 0x04000B94 RID: 2964
		[AccessedThroughProperty("Label38")]
		private Label _Label38;

		// Token: 0x04000B95 RID: 2965
		[AccessedThroughProperty("TabPage_vazao")]
		private TabPage _TabPage_vazao;

		// Token: 0x04000B96 RID: 2966
		[AccessedThroughProperty("GroupBox_vazoes_820")]
		private GroupBox _GroupBox_vazoes_820;

		// Token: 0x04000B97 RID: 2967
		[AccessedThroughProperty("DataGridView_vazoes_RT820")]
		private DataGridView _DataGridView_vazoes_RT820;

		// Token: 0x04000B98 RID: 2968
		[AccessedThroughProperty("tb_lixo6")]
		private TextBox _tb_lixo6;

		// Token: 0x04000B99 RID: 2969
		[AccessedThroughProperty("Label40")]
		private Label _Label40;

		// Token: 0x04000B9A RID: 2970
		[AccessedThroughProperty("Label39")]
		private Label _Label39;

		// Token: 0x04000B9B RID: 2971
		[AccessedThroughProperty("NumericUpDown_end2_est_820")]
		private NumericUpDown _NumericUpDown_end2_est_820;

		// Token: 0x04000B9C RID: 2972
		[AccessedThroughProperty("GroupBox10")]
		private GroupBox _GroupBox10;

		// Token: 0x04000B9D RID: 2973
		[AccessedThroughProperty("GroupBox9")]
		private GroupBox _GroupBox9;

		// Token: 0x04000B9E RID: 2974
		[AccessedThroughProperty("DataGridView2")]
		private DataGridView _DataGridView2;

		// Token: 0x04000B9F RID: 2975
		[AccessedThroughProperty("DataGridView_periferico2_RT820")]
		private DataGridView _DataGridView_periferico2_RT820;

		// Token: 0x04000BA0 RID: 2976
		[AccessedThroughProperty("GroupBox11")]
		private GroupBox _GroupBox11;

		// Token: 0x04000BA1 RID: 2977
		[AccessedThroughProperty("DataGridView_perifericomodbusgenerico_RT820")]
		private DataGridView _DataGridView_perifericomodbusgenerico_RT820;

		// Token: 0x04000BA2 RID: 2978
		[AccessedThroughProperty("GroupBox12")]
		private GroupBox _GroupBox12;

		// Token: 0x04000BA3 RID: 2979
		[AccessedThroughProperty("DataGridView_calhas_RT820")]
		private DataGridView _DataGridView_calhas_RT820;

		// Token: 0x04000BA4 RID: 2980
		[AccessedThroughProperty("Label41")]
		private Label _Label41;

		// Token: 0x04000BA5 RID: 2981
		[AccessedThroughProperty("TabControl_Calhas")]
		private TabControl _TabControl_Calhas;

		// Token: 0x04000BA6 RID: 2982
		[AccessedThroughProperty("TabPage2")]
		private TabPage _TabPage2;

		// Token: 0x04000BA7 RID: 2983
		[AccessedThroughProperty("TabPage3")]
		private TabPage _TabPage3;

		// Token: 0x04000BA8 RID: 2984
		[AccessedThroughProperty("TabPage4")]
		private TabPage _TabPage4;

		// Token: 0x04000BA9 RID: 2985
		[AccessedThroughProperty("Label42")]
		private Label _Label42;

		// Token: 0x04000BAA RID: 2986
		[AccessedThroughProperty("Label44")]
		private Label _Label44;

		// Token: 0x04000BAB RID: 2987
		[AccessedThroughProperty("Label43")]
		private Label _Label43;

		// Token: 0x04000BAC RID: 2988
		[AccessedThroughProperty("Label47")]
		private Label _Label47;

		// Token: 0x04000BAD RID: 2989
		[AccessedThroughProperty("Label46")]
		private Label _Label46;

		// Token: 0x04000BAE RID: 2990
		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		// Token: 0x04000BAF RID: 2991
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000BB0 RID: 2992
		[AccessedThroughProperty("Label48")]
		private Label _Label48;

		// Token: 0x04000BB1 RID: 2993
		[AccessedThroughProperty("Label54")]
		private Label _Label54;

		// Token: 0x04000BB2 RID: 2994
		[AccessedThroughProperty("Label52")]
		private Label _Label52;

		// Token: 0x04000BB3 RID: 2995
		[AccessedThroughProperty("Label51")]
		private Label _Label51;

		// Token: 0x04000BB4 RID: 2996
		[AccessedThroughProperty("Label50")]
		private Label _Label50;

		// Token: 0x04000BB5 RID: 2997
		[AccessedThroughProperty("Label49")]
		private Label _Label49;

		// Token: 0x04000BB6 RID: 2998
		[AccessedThroughProperty("Label56")]
		private Label _Label56;

		// Token: 0x04000BB7 RID: 2999
		[AccessedThroughProperty("Label55")]
		private Label _Label55;

		// Token: 0x04000BB8 RID: 3000
		[AccessedThroughProperty("Label58")]
		private Label _Label58;

		// Token: 0x04000BB9 RID: 3001
		[AccessedThroughProperty("PictureBox3")]
		private PictureBox _PictureBox3;

		// Token: 0x04000BBA RID: 3002
		[AccessedThroughProperty("Label66")]
		private Label _Label66;

		// Token: 0x04000BBB RID: 3003
		[AccessedThroughProperty("Label67")]
		private Label _Label67;

		// Token: 0x04000BBC RID: 3004
		[AccessedThroughProperty("Label62")]
		private Label _Label62;

		// Token: 0x04000BBD RID: 3005
		[AccessedThroughProperty("Label63")]
		private Label _Label63;

		// Token: 0x04000BBE RID: 3006
		[AccessedThroughProperty("Label61")]
		private Label _Label61;

		// Token: 0x04000BBF RID: 3007
		[AccessedThroughProperty("Label60")]
		private Label _Label60;

		// Token: 0x04000BC0 RID: 3008
		[AccessedThroughProperty("Label59")]
		private Label _Label59;

		// Token: 0x04000BC1 RID: 3009
		[AccessedThroughProperty("Label68")]
		private Label _Label68;

		// Token: 0x04000BC2 RID: 3010
		[AccessedThroughProperty("Label69")]
		private Label _Label69;

		// Token: 0x04000BC3 RID: 3011
		[AccessedThroughProperty("Label72")]
		private Label _Label72;

		// Token: 0x04000BC4 RID: 3012
		[AccessedThroughProperty("Label71")]
		private Label _Label71;

		// Token: 0x04000BC5 RID: 3013
		[AccessedThroughProperty("Label70")]
		private Label _Label70;

		// Token: 0x04000BC6 RID: 3014
		[AccessedThroughProperty("Label74")]
		private Label _Label74;

		// Token: 0x04000BC7 RID: 3015
		[AccessedThroughProperty("Label45")]
		private Label _Label45;

		// Token: 0x04000BC8 RID: 3016
		[AccessedThroughProperty("Label64")]
		private Label _Label64;

		// Token: 0x04000BC9 RID: 3017
		[AccessedThroughProperty("Label57")]
		private Label _Label57;

		// Token: 0x04000BCA RID: 3018
		[AccessedThroughProperty("Label76")]
		private Label _Label76;

		// Token: 0x04000BCB RID: 3019
		[AccessedThroughProperty("Label75")]
		private Label _Label75;

		// Token: 0x04000BCC RID: 3020
		[AccessedThroughProperty("Label65")]
		private Label _Label65;

		// Token: 0x04000BCD RID: 3021
		[AccessedThroughProperty("Label77")]
		private Label _Label77;

		// Token: 0x04000BCE RID: 3022
		[AccessedThroughProperty("Label78")]
		private Label _Label78;

		// Token: 0x04000BCF RID: 3023
		[AccessedThroughProperty("Label53")]
		private Label _Label53;

		// Token: 0x04000BD0 RID: 3024
		[AccessedThroughProperty("Label79")]
		private Label _Label79;

		// Token: 0x04000BD1 RID: 3025
		[AccessedThroughProperty("Label83")]
		private Label _Label83;

		// Token: 0x04000BD2 RID: 3026
		[AccessedThroughProperty("Label82")]
		private Label _Label82;

		// Token: 0x04000BD3 RID: 3027
		[AccessedThroughProperty("Label81")]
		private Label _Label81;

		// Token: 0x04000BD4 RID: 3028
		[AccessedThroughProperty("Label80")]
		private Label _Label80;

		// Token: 0x04000BD5 RID: 3029
		[AccessedThroughProperty("TabPage_SA")]
		private TabPage _TabPage_SA;

		// Token: 0x04000BD6 RID: 3030
		[AccessedThroughProperty("GroupBox13")]
		private GroupBox _GroupBox13;

		// Token: 0x04000BD7 RID: 3031
		[AccessedThroughProperty("GroupBox14")]
		private GroupBox _GroupBox14;

		// Token: 0x04000BD8 RID: 3032
		[AccessedThroughProperty("nud_ganho2")]
		private NumericUpDown _nud_ganho2;

		// Token: 0x04000BD9 RID: 3033
		[AccessedThroughProperty("Label84")]
		private Label _Label84;

		// Token: 0x04000BDA RID: 3034
		[AccessedThroughProperty("nud_zero2")]
		private NumericUpDown _nud_zero2;

		// Token: 0x04000BDB RID: 3035
		[AccessedThroughProperty("Label85")]
		private Label _Label85;

		// Token: 0x04000BDC RID: 3036
		[AccessedThroughProperty("GroupBox15")]
		private GroupBox _GroupBox15;

		// Token: 0x04000BDD RID: 3037
		[AccessedThroughProperty("GroupBox16")]
		private GroupBox _GroupBox16;

		// Token: 0x04000BDE RID: 3038
		[AccessedThroughProperty("nud_ganho1")]
		private NumericUpDown _nud_ganho1;

		// Token: 0x04000BDF RID: 3039
		[AccessedThroughProperty("Label86")]
		private Label _Label86;

		// Token: 0x04000BE0 RID: 3040
		[AccessedThroughProperty("nud_zero1")]
		private NumericUpDown _nud_zero1;

		// Token: 0x04000BE1 RID: 3041
		[AccessedThroughProperty("Label87")]
		private Label _Label87;

		// Token: 0x04000BE2 RID: 3042
		[AccessedThroughProperty("GroupBox17")]
		private GroupBox _GroupBox17;

		// Token: 0x04000BE3 RID: 3043
		[AccessedThroughProperty("GroupBox18")]
		private GroupBox _GroupBox18;

		// Token: 0x04000BE4 RID: 3044
		[AccessedThroughProperty("cb_SA_2")]
		private ComboBox _cb_SA_2;

		// Token: 0x04000BE5 RID: 3045
		[AccessedThroughProperty("cb_SA_1")]
		private ComboBox _cb_SA_1;

		// Token: 0x04000BE6 RID: 3046
		private bool bloqueio_IO;

		// Token: 0x04000BE7 RID: 3047
		private int pagina_impressao;
	}
}
