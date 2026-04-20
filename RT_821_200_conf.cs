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
	// Token: 0x02000036 RID: 54
	[DesignerGenerated]
	public partial class RT_821_200_conf : Form
	{
		// Token: 0x06000822 RID: 2082 RVA: 0x002B7318 File Offset: 0x002B5718
		public RT_821_200_conf()
		{
			base.Load += new EventHandler(this.RT_821_conf_Load);
			base.Activated += new EventHandler(this.RT_821_conf_Activated);
			base.FormClosed += new FormClosedEventHandler(this.RT_821_conf_FormClosed);
			this.InitializeComponent();
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x002BCDE0 File Offset: 0x002BB1E0
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x002BCDF4 File Offset: 0x002BB1F4
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

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x002BCE00 File Offset: 0x002BB200
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x002BCE14 File Offset: 0x002BB214
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

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x002BCE20 File Offset: 0x002BB220
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x002BCE34 File Offset: 0x002BB234
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

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x002BCE40 File Offset: 0x002BB240
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x002BCE54 File Offset: 0x002BB254
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

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x002BCE60 File Offset: 0x002BB260
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x002BCE74 File Offset: 0x002BB274
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

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x002BCE80 File Offset: 0x002BB280
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x002BCE94 File Offset: 0x002BB294
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

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x002BCEA0 File Offset: 0x002BB2A0
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x002BCEB4 File Offset: 0x002BB2B4
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

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x002BCEC0 File Offset: 0x002BB2C0
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x002BCED4 File Offset: 0x002BB2D4
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

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x002BCEE0 File Offset: 0x002BB2E0
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x002BCEF4 File Offset: 0x002BB2F4
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

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x002BCF00 File Offset: 0x002BB300
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x002BCF14 File Offset: 0x002BB314
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

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x002BCF20 File Offset: 0x002BB320
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x002BCF34 File Offset: 0x002BB334
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

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x002BCF40 File Offset: 0x002BB340
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x002BCF54 File Offset: 0x002BB354
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

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x002BCF60 File Offset: 0x002BB360
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x002BCF74 File Offset: 0x002BB374
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

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x002BCF80 File Offset: 0x002BB380
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x002BCF94 File Offset: 0x002BB394
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

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x002BCFA0 File Offset: 0x002BB3A0
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x002BCFB4 File Offset: 0x002BB3B4
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

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x002BCFC0 File Offset: 0x002BB3C0
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x002BCFD4 File Offset: 0x002BB3D4
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

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x002BCFE0 File Offset: 0x002BB3E0
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x002BCFF4 File Offset: 0x002BB3F4
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

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x002BD000 File Offset: 0x002BB400
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x002BD014 File Offset: 0x002BB414
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

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x002BD020 File Offset: 0x002BB420
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x002BD034 File Offset: 0x002BB434
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

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x002BD040 File Offset: 0x002BB440
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x002BD054 File Offset: 0x002BB454
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

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x002BD060 File Offset: 0x002BB460
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x002BD074 File Offset: 0x002BB474
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

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x002BD080 File Offset: 0x002BB480
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x002BD094 File Offset: 0x002BB494
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

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x002BD0A0 File Offset: 0x002BB4A0
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x002BD0B4 File Offset: 0x002BB4B4
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

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x002BD0C0 File Offset: 0x002BB4C0
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x002BD0D4 File Offset: 0x002BB4D4
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

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x002BD0E0 File Offset: 0x002BB4E0
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x002BD0F4 File Offset: 0x002BB4F4
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

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x002BD100 File Offset: 0x002BB500
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x002BD114 File Offset: 0x002BB514
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

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x002BD120 File Offset: 0x002BB520
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x002BD134 File Offset: 0x002BB534
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

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x002BD140 File Offset: 0x002BB540
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x002BD154 File Offset: 0x002BB554
		internal virtual TabControl TabControl_820
		{
			get
			{
				return this._TabControl_820;
			}
			[MethodImpl(32)]
			set
			{
				this._TabControl_820 = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x002BD160 File Offset: 0x002BB560
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x002BD174 File Offset: 0x002BB574
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

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x002BD180 File Offset: 0x002BB580
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x002BD194 File Offset: 0x002BB594
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

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x002BD1A0 File Offset: 0x002BB5A0
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x002BD1B4 File Offset: 0x002BB5B4
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

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x002BD1C0 File Offset: 0x002BB5C0
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x002BD1D4 File Offset: 0x002BB5D4
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

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x002BD220 File Offset: 0x002BB620
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x002BD234 File Offset: 0x002BB634
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

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x002BD280 File Offset: 0x002BB680
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x002BD294 File Offset: 0x002BB694
		internal virtual NumericUpDown NumericUpDown_end_est_820
		{
			get
			{
				return this._NumericUpDown_end_est_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_est_820_ValueChanged);
				if (this._NumericUpDown_end_est_820 != null)
				{
					this._NumericUpDown_end_est_820.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_est_820 = value;
				if (this._NumericUpDown_end_est_820 != null)
				{
					this._NumericUpDown_end_est_820.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x002BD2E0 File Offset: 0x002BB6E0
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x002BD2F4 File Offset: 0x002BB6F4
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

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x002BD300 File Offset: 0x002BB700
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x002BD314 File Offset: 0x002BB714
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

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x002BD320 File Offset: 0x002BB720
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x002BD334 File Offset: 0x002BB734
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

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x002BD340 File Offset: 0x002BB740
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x002BD354 File Offset: 0x002BB754
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

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x002BD360 File Offset: 0x002BB760
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x002BD374 File Offset: 0x002BB774
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

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x002BD380 File Offset: 0x002BB780
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x002BD394 File Offset: 0x002BB794
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

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x002BD3A0 File Offset: 0x002BB7A0
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x002BD3B4 File Offset: 0x002BB7B4
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

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x002BD44C File Offset: 0x002BB84C
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x002BD460 File Offset: 0x002BB860
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

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x002BD46C File Offset: 0x002BB86C
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x002BD480 File Offset: 0x002BB880
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

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x002BD4CC File Offset: 0x002BB8CC
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x002BD4E0 File Offset: 0x002BB8E0
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

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x002BD52C File Offset: 0x002BB92C
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x002BD540 File Offset: 0x002BB940
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

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x002BD54C File Offset: 0x002BB94C
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x002BD560 File Offset: 0x002BB960
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

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x002BD56C File Offset: 0x002BB96C
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x002BD580 File Offset: 0x002BB980
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

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x002BD58C File Offset: 0x002BB98C
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x002BD5A0 File Offset: 0x002BB9A0
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

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x002BD5EC File Offset: 0x002BB9EC
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x002BD600 File Offset: 0x002BBA00
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

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x002BD64C File Offset: 0x002BBA4C
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x002BD660 File Offset: 0x002BBA60
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

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x002BD6AC File Offset: 0x002BBAAC
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x002BD6C0 File Offset: 0x002BBAC0
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

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x002BD6CC File Offset: 0x002BBACC
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x002BD6E0 File Offset: 0x002BBAE0
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

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x002BD72C File Offset: 0x002BBB2C
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x002BD740 File Offset: 0x002BBB40
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

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x002BD78C File Offset: 0x002BBB8C
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x002BD7A0 File Offset: 0x002BBBA0
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

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x002BD7AC File Offset: 0x002BBBAC
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x002BD7C0 File Offset: 0x002BBBC0
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

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x002BD7CC File Offset: 0x002BBBCC
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x002BD7E0 File Offset: 0x002BBBE0
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

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x002BD7EC File Offset: 0x002BBBEC
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x002BD800 File Offset: 0x002BBC00
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

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x002BD84C File Offset: 0x002BBC4C
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x002BD860 File Offset: 0x002BBC60
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

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x002BD86C File Offset: 0x002BBC6C
		// (set) Token: 0x0600089A RID: 2202 RVA: 0x002BD880 File Offset: 0x002BBC80
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

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x002BD88C File Offset: 0x002BBC8C
		// (set) Token: 0x0600089C RID: 2204 RVA: 0x002BD8A0 File Offset: 0x002BBCA0
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

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x002BD8AC File Offset: 0x002BBCAC
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x002BD8C0 File Offset: 0x002BBCC0
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

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x002BD8CC File Offset: 0x002BBCCC
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x002BD8E0 File Offset: 0x002BBCE0
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

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x002BD8EC File Offset: 0x002BBCEC
		// (set) Token: 0x060008A2 RID: 2210 RVA: 0x002BD900 File Offset: 0x002BBD00
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

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x002BD90C File Offset: 0x002BBD0C
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x002BD920 File Offset: 0x002BBD20
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

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x002BD92C File Offset: 0x002BBD2C
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x002BD940 File Offset: 0x002BBD40
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

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x002BD94C File Offset: 0x002BBD4C
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x002BD960 File Offset: 0x002BBD60
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

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x002BD9D0 File Offset: 0x002BBDD0
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x002BD9E4 File Offset: 0x002BBDE4
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

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x002BDA30 File Offset: 0x002BBE30
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x002BDA44 File Offset: 0x002BBE44
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

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x002BDADC File Offset: 0x002BBEDC
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x002BDAF0 File Offset: 0x002BBEF0
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

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x002BDAFC File Offset: 0x002BBEFC
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x002BDB10 File Offset: 0x002BBF10
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

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x002BDB1C File Offset: 0x002BBF1C
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x002BDB30 File Offset: 0x002BBF30
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

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x002BDB3C File Offset: 0x002BBF3C
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x002BDB50 File Offset: 0x002BBF50
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

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x002BDB5C File Offset: 0x002BBF5C
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x002BDB70 File Offset: 0x002BBF70
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

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x002BDB7C File Offset: 0x002BBF7C
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x002BDB90 File Offset: 0x002BBF90
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

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x002BDB9C File Offset: 0x002BBF9C
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x002BDBB0 File Offset: 0x002BBFB0
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

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x002BDBBC File Offset: 0x002BBFBC
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x002BDBD0 File Offset: 0x002BBFD0
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

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x002BDBDC File Offset: 0x002BBFDC
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x002BDBF0 File Offset: 0x002BBFF0
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

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x002BDBFC File Offset: 0x002BBFFC
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x002BDC10 File Offset: 0x002BC010
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

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x002BDC1C File Offset: 0x002BC01C
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x002BDC30 File Offset: 0x002BC030
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

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x002BDC3C File Offset: 0x002BC03C
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x002BDC50 File Offset: 0x002BC050
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

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x002BDC5C File Offset: 0x002BC05C
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x002BDC70 File Offset: 0x002BC070
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

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x002BDC7C File Offset: 0x002BC07C
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x002BDC90 File Offset: 0x002BC090
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

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x002BDC9C File Offset: 0x002BC09C
		// (set) Token: 0x060008CA RID: 2250 RVA: 0x002BDCB0 File Offset: 0x002BC0B0
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

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x002BDCBC File Offset: 0x002BC0BC
		// (set) Token: 0x060008CC RID: 2252 RVA: 0x002BDCD0 File Offset: 0x002BC0D0
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

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x002BDCDC File Offset: 0x002BC0DC
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x002BDCF0 File Offset: 0x002BC0F0
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

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x002BDCFC File Offset: 0x002BC0FC
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x002BDD10 File Offset: 0x002BC110
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

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x002BDD1C File Offset: 0x002BC11C
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x002BDD30 File Offset: 0x002BC130
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

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x002BDD3C File Offset: 0x002BC13C
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x002BDD50 File Offset: 0x002BC150
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

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x002BDD5C File Offset: 0x002BC15C
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x002BDD70 File Offset: 0x002BC170
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

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x002BDD7C File Offset: 0x002BC17C
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x002BDD90 File Offset: 0x002BC190
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

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x002BDD9C File Offset: 0x002BC19C
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x002BDDB0 File Offset: 0x002BC1B0
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

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x002BDDBC File Offset: 0x002BC1BC
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x002BDDD0 File Offset: 0x002BC1D0
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

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x002BDDDC File Offset: 0x002BC1DC
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x002BDDF0 File Offset: 0x002BC1F0
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

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x002BDDFC File Offset: 0x002BC1FC
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x002BDE10 File Offset: 0x002BC210
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

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x002BDE1C File Offset: 0x002BC21C
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x002BDE30 File Offset: 0x002BC230
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

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x002BDE3C File Offset: 0x002BC23C
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x002BDE50 File Offset: 0x002BC250
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

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x002BDE5C File Offset: 0x002BC25C
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x002BDE70 File Offset: 0x002BC270
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

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x002BDE7C File Offset: 0x002BC27C
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x002BDE90 File Offset: 0x002BC290
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

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x002BDE9C File Offset: 0x002BC29C
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x002BDEB0 File Offset: 0x002BC2B0
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

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x002BDEBC File Offset: 0x002BC2BC
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x002BDED0 File Offset: 0x002BC2D0
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

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x002BDEDC File Offset: 0x002BC2DC
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x002BDEF0 File Offset: 0x002BC2F0
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

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x002BDF3C File Offset: 0x002BC33C
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x002BDF50 File Offset: 0x002BC350
		internal virtual TabPage TabPage_MotoresValvulas
		{
			get
			{
				return this._TabPage_MotoresValvulas;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_MotoresValvulas = value;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x002BDF5C File Offset: 0x002BC35C
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x002BDF70 File Offset: 0x002BC370
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

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x002BDF7C File Offset: 0x002BC37C
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x002BDF90 File Offset: 0x002BC390
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

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x002BDF9C File Offset: 0x002BC39C
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x002BDFB0 File Offset: 0x002BC3B0
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

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x002BDFBC File Offset: 0x002BC3BC
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x002BDFD0 File Offset: 0x002BC3D0
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

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x002BDFDC File Offset: 0x002BC3DC
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x002BDFF0 File Offset: 0x002BC3F0
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

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x002BDFFC File Offset: 0x002BC3FC
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x002BE010 File Offset: 0x002BC410
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

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x002BE01C File Offset: 0x002BC41C
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x002BE030 File Offset: 0x002BC430
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

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x002BE03C File Offset: 0x002BC43C
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x002BE050 File Offset: 0x002BC450
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

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x002BE05C File Offset: 0x002BC45C
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x002BE070 File Offset: 0x002BC470
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

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x002BE07C File Offset: 0x002BC47C
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x002BE090 File Offset: 0x002BC490
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

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x002BE09C File Offset: 0x002BC49C
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x002BE0B0 File Offset: 0x002BC4B0
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

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x002BE0BC File Offset: 0x002BC4BC
		// (set) Token: 0x06000908 RID: 2312 RVA: 0x002BE0D0 File Offset: 0x002BC4D0
		internal virtual NumericUpDown nud_motores_simultaneos
		{
			get
			{
				return this._nud_motores_simultaneos;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_motores_simultaneos_ValueChanged);
				if (this._nud_motores_simultaneos != null)
				{
					this._nud_motores_simultaneos.ValueChanged -= eventHandler;
				}
				this._nud_motores_simultaneos = value;
				if (this._nud_motores_simultaneos != null)
				{
					this._nud_motores_simultaneos.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x002BE11C File Offset: 0x002BC51C
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x002BE130 File Offset: 0x002BC530
		internal virtual NumericUpDown nud_numero_motores
		{
			get
			{
				return this._nud_numero_motores;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_numero_motores_ValueChanged);
				if (this._nud_numero_motores != null)
				{
					this._nud_numero_motores.ValueChanged -= eventHandler;
				}
				this._nud_numero_motores = value;
				if (this._nud_numero_motores != null)
				{
					this._nud_numero_motores.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x002BE17C File Offset: 0x002BC57C
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x002BE190 File Offset: 0x002BC590
		internal virtual NumericUpDown nud_tempo_operacoes
		{
			get
			{
				return this._nud_tempo_operacoes;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_tempo_operacoes_ValueChanged);
				if (this._nud_tempo_operacoes != null)
				{
					this._nud_tempo_operacoes.ValueChanged -= eventHandler;
				}
				this._nud_tempo_operacoes = value;
				if (this._nud_tempo_operacoes != null)
				{
					this._nud_tempo_operacoes.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x002BE1DC File Offset: 0x002BC5DC
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x002BE1F0 File Offset: 0x002BC5F0
		internal virtual NumericUpDown nud_parada3
		{
			get
			{
				return this._nud_parada3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_parada3_ValueChanged);
				if (this._nud_parada3 != null)
				{
					this._nud_parada3.ValueChanged -= eventHandler;
				}
				this._nud_parada3 = value;
				if (this._nud_parada3 != null)
				{
					this._nud_parada3.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x002BE23C File Offset: 0x002BC63C
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x002BE250 File Offset: 0x002BC650
		internal virtual NumericUpDown nud_partida3
		{
			get
			{
				return this._nud_partida3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_partida3_ValueChanged);
				if (this._nud_partida3 != null)
				{
					this._nud_partida3.ValueChanged -= eventHandler;
				}
				this._nud_partida3 = value;
				if (this._nud_partida3 != null)
				{
					this._nud_partida3.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x002BE29C File Offset: 0x002BC69C
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x002BE2B0 File Offset: 0x002BC6B0
		internal virtual NumericUpDown nud_parada2
		{
			get
			{
				return this._nud_parada2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_parada2_ValueChanged);
				if (this._nud_parada2 != null)
				{
					this._nud_parada2.ValueChanged -= eventHandler;
				}
				this._nud_parada2 = value;
				if (this._nud_parada2 != null)
				{
					this._nud_parada2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x002BE2FC File Offset: 0x002BC6FC
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x002BE310 File Offset: 0x002BC710
		internal virtual NumericUpDown nud_partida2
		{
			get
			{
				return this._nud_partida2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_partida2_ValueChanged);
				if (this._nud_partida2 != null)
				{
					this._nud_partida2.ValueChanged -= eventHandler;
				}
				this._nud_partida2 = value;
				if (this._nud_partida2 != null)
				{
					this._nud_partida2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x002BE35C File Offset: 0x002BC75C
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x002BE370 File Offset: 0x002BC770
		internal virtual NumericUpDown nud_parada1
		{
			get
			{
				return this._nud_parada1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_parada1_ValueChanged);
				if (this._nud_parada1 != null)
				{
					this._nud_parada1.ValueChanged -= eventHandler;
				}
				this._nud_parada1 = value;
				if (this._nud_parada1 != null)
				{
					this._nud_parada1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x002BE3BC File Offset: 0x002BC7BC
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x002BE3D0 File Offset: 0x002BC7D0
		internal virtual NumericUpDown nud_partida1
		{
			get
			{
				return this._nud_partida1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_partida1_ValueChanged);
				if (this._nud_partida1 != null)
				{
					this._nud_partida1.ValueChanged -= eventHandler;
				}
				this._nud_partida1 = value;
				if (this._nud_partida1 != null)
				{
					this._nud_partida1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x002BE41C File Offset: 0x002BC81C
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x002BE430 File Offset: 0x002BC830
		internal virtual ComboBox cb_modo_partida2
		{
			get
			{
				return this._cb_modo_partida2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_modo_partida2_SelectedIndexChanged);
				if (this._cb_modo_partida2 != null)
				{
					this._cb_modo_partida2.SelectedIndexChanged -= eventHandler;
				}
				this._cb_modo_partida2 = value;
				if (this._cb_modo_partida2 != null)
				{
					this._cb_modo_partida2.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x002BE47C File Offset: 0x002BC87C
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x002BE490 File Offset: 0x002BC890
		internal virtual ComboBox cb_modo_partida1
		{
			get
			{
				return this._cb_modo_partida1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_modo_partida1_SelectedIndexChanged);
				if (this._cb_modo_partida1 != null)
				{
					this._cb_modo_partida1.SelectedIndexChanged -= eventHandler;
				}
				this._cb_modo_partida1 = value;
				if (this._cb_modo_partida1 != null)
				{
					this._cb_modo_partida1.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x002BE4DC File Offset: 0x002BC8DC
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x002BE4F0 File Offset: 0x002BC8F0
		internal virtual ComboBox cb_modo_partida3
		{
			get
			{
				return this._cb_modo_partida3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_modo_partida3_SelectedIndexChanged);
				if (this._cb_modo_partida3 != null)
				{
					this._cb_modo_partida3.SelectedIndexChanged -= eventHandler;
				}
				this._cb_modo_partida3 = value;
				if (this._cb_modo_partida3 != null)
				{
					this._cb_modo_partida3.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x002BE53C File Offset: 0x002BC93C
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x002BE550 File Offset: 0x002BC950
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

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x002BE55C File Offset: 0x002BC95C
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x002BE570 File Offset: 0x002BC970
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

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x002BE57C File Offset: 0x002BC97C
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x002BE590 File Offset: 0x002BC990
		internal virtual NumericUpDown nud_nb_m1
		{
			get
			{
				return this._nud_nb_m1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_nb_m1_ValueChanged);
				if (this._nud_nb_m1 != null)
				{
					this._nud_nb_m1.ValueChanged -= eventHandler;
				}
				this._nud_nb_m1 = value;
				if (this._nud_nb_m1 != null)
				{
					this._nud_nb_m1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x002BE5DC File Offset: 0x002BC9DC
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x002BE5F0 File Offset: 0x002BC9F0
		internal virtual NumericUpDown nud_na_m1
		{
			get
			{
				return this._nud_na_m1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_na_m1_ValueChanged);
				if (this._nud_na_m1 != null)
				{
					this._nud_na_m1.ValueChanged -= eventHandler;
				}
				this._nud_na_m1 = value;
				if (this._nud_na_m1 != null)
				{
					this._nud_na_m1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x002BE63C File Offset: 0x002BCA3C
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x002BE650 File Offset: 0x002BCA50
		internal virtual NumericUpDown nud_nb_m3
		{
			get
			{
				return this._nud_nb_m3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_nb_m3_ValueChanged);
				if (this._nud_nb_m3 != null)
				{
					this._nud_nb_m3.ValueChanged -= eventHandler;
				}
				this._nud_nb_m3 = value;
				if (this._nud_nb_m3 != null)
				{
					this._nud_nb_m3.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x002BE69C File Offset: 0x002BCA9C
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x002BE6B0 File Offset: 0x002BCAB0
		internal virtual NumericUpDown nud_na_m3
		{
			get
			{
				return this._nud_na_m3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_na_m3_ValueChanged);
				if (this._nud_na_m3 != null)
				{
					this._nud_na_m3.ValueChanged -= eventHandler;
				}
				this._nud_na_m3 = value;
				if (this._nud_na_m3 != null)
				{
					this._nud_na_m3.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x002BE6FC File Offset: 0x002BCAFC
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x002BE710 File Offset: 0x002BCB10
		internal virtual NumericUpDown nud_nb_m2
		{
			get
			{
				return this._nud_nb_m2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_nb_m2_ValueChanged);
				if (this._nud_nb_m2 != null)
				{
					this._nud_nb_m2.ValueChanged -= eventHandler;
				}
				this._nud_nb_m2 = value;
				if (this._nud_nb_m2 != null)
				{
					this._nud_nb_m2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x002BE75C File Offset: 0x002BCB5C
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x002BE770 File Offset: 0x002BCB70
		internal virtual NumericUpDown nud_na_m2
		{
			get
			{
				return this._nud_na_m2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_na_m2_ValueChanged);
				if (this._nud_na_m2 != null)
				{
					this._nud_na_m2.ValueChanged -= eventHandler;
				}
				this._nud_na_m2 = value;
				if (this._nud_na_m2 != null)
				{
					this._nud_na_m2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x002BE7BC File Offset: 0x002BCBBC
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x002BE7D0 File Offset: 0x002BCBD0
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

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x002BE7DC File Offset: 0x002BCBDC
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x002BE7F0 File Offset: 0x002BCBF0
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

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x002BE7FC File Offset: 0x002BCBFC
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x002BE810 File Offset: 0x002BCC10
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

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x002BE81C File Offset: 0x002BCC1C
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x002BE830 File Offset: 0x002BCC30
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

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x002BE83C File Offset: 0x002BCC3C
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x002BE850 File Offset: 0x002BCC50
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

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x002BE85C File Offset: 0x002BCC5C
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x002BE870 File Offset: 0x002BCC70
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

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x002BE87C File Offset: 0x002BCC7C
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x002BE890 File Offset: 0x002BCC90
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

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x002BE89C File Offset: 0x002BCC9C
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x002BE8B0 File Offset: 0x002BCCB0
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

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x002BE8BC File Offset: 0x002BCCBC
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x002BE8D0 File Offset: 0x002BCCD0
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

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x002BE8DC File Offset: 0x002BCCDC
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x002BE8F0 File Offset: 0x002BCCF0
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

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x002BE8FC File Offset: 0x002BCCFC
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x002BE910 File Offset: 0x002BCD10
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

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x002BE91C File Offset: 0x002BCD1C
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x002BE930 File Offset: 0x002BCD30
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

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x002BE93C File Offset: 0x002BCD3C
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x002BE950 File Offset: 0x002BCD50
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

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x002BE95C File Offset: 0x002BCD5C
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x002BE970 File Offset: 0x002BCD70
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

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x002BE97C File Offset: 0x002BCD7C
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x002BE990 File Offset: 0x002BCD90
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

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x002BE99C File Offset: 0x002BCD9C
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x002BE9B0 File Offset: 0x002BCDB0
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

		// Token: 0x0600094F RID: 2383 RVA: 0x002BE9BC File Offset: 0x002BCDBC
		private void AtivaEfeitoOnChangeValue()
		{
			this.ToolStri_RT_820.Enabled = false;
			this.tb_lixo1.Focus();
			this.tb_lixo2.Focus();
			this.tb_lixo3.Focus();
			this.tb_lixo5.Focus();
			this.tb_lixo6.Focus();
			this.ToolStri_RT_820.Enabled = true;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x002BEA20 File Offset: 0x002BCE20
		private void InicializaEStruturasVariaveis_RT820()
		{
			this.InicializaEstrutura_DataGridView_ED();
			this.GeraDataGridView_ED();
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x002BEA30 File Offset: 0x002BCE30
		private void RT_821_conf_Load(object sender, EventArgs e)
		{
			RT_geral.Lmte_Init_ok = false;
			this.bloqueio_IO = false;
			RT_geral.RT_821_200_BD.cfg_geral.entradas = new RT_geral.Combo_ictel[9];
			RT_geral.RT_821_200_BD.cfg_geral.entradas[0].itens = new string[16];
			RT_geral.RT_821_200_BD.cfg_geral.entradas[0].valores = new int[16];
			RT_geral.RT_821_200_BD.cfg_geral.entradas[1].itens = new string[16];
			RT_geral.RT_821_200_BD.cfg_geral.entradas[1].valores = new int[16];
			RT_geral.RT_821_200_BD.cfg_geral.entradas[2].itens = new string[16];
			RT_geral.RT_821_200_BD.cfg_geral.entradas[2].valores = new int[16];
			RT_geral.RT_821_200_BD.cfg_geral.entradas[3].itens = new string[16];
			RT_geral.RT_821_200_BD.cfg_geral.entradas[3].valores = new int[16];
			RT_geral.RT_821_200_BD.cfg_geral.entradas[4].itens = new string[16];
			RT_geral.RT_821_200_BD.cfg_geral.entradas[4].valores = new int[16];
			RT_geral.RT_821_200_BD.cfg_geral.entradas[5].itens = new string[16];
			RT_geral.RT_821_200_BD.cfg_geral.entradas[5].valores = new int[16];
			RT_geral.RT_821_200_BD.cfg_geral.entradas[6].itens = new string[16];
			RT_geral.RT_821_200_BD.cfg_geral.entradas[6].valores = new int[16];
			RT_geral.RT_821_200_BD.cfg_geral.entradas[7].itens = new string[16];
			RT_geral.RT_821_200_BD.cfg_geral.entradas[7].valores = new int[16];
			RT_geral.RT_821_200_BD.cfg_geral.modo_partida = new RT_geral.Combo_ictel[4];
			RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].itens = new string[3];
			RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].valores = new int[3];
			RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].itens = new string[3];
			RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].valores = new int[3];
			RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].itens = new string[3];
			RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].valores = new int[3];
			RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.valores = new int[4];
			RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.itens = new string[4];
			RT_geral.RT_821_200_BD.repetidora.Repetidoras = new RT_geral.Integer_ictel[51];
			this.Inicializa_DadosEStruturaRT821_Padrao();
			RT_geral.Lmte_Init_ok = true;
			this.InicializaEstrutura_DataGridView_ED();
			this.GeraDataGridView_ED();
			this.InicializaEstrutura_DataGridView_repetidora();
			this.GeraDataGridView_Repedidora();
			NumericUpDown numericUpDown = this.NumericUpDown_end_est;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.End_estacao);
			this.NumericUpDown_end_est = numericUpDown;
			numericUpDown = this.NumericUpDown_end_mestre;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.End_mestre);
			this.NumericUpDown_end_mestre = numericUpDown;
			numericUpDown = this.NumericUpDown_temp_ptt;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.Tempo_ptt);
			this.NumericUpDown_temp_ptt = numericUpDown;
			numericUpDown = this.nud_numero_motores;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.quantidade_motores);
			this.nud_numero_motores = numericUpDown;
			numericUpDown = this.nud_motores_simultaneos;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.motores_simultaneos);
			this.nud_motores_simultaneos = numericUpDown;
			numericUpDown = this.nud_tempo_operacoes;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.tempo_acionamentos);
			this.nud_tempo_operacoes = numericUpDown;
			ComboBox comboBox = this.cb_modo_partida1;
			this.CarregaComboBoxBaudRate(ref comboBox, ref RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0]);
			this.cb_modo_partida1 = comboBox;
			numericUpDown = this.nud_na_m1;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Alto);
			this.nud_na_m1 = numericUpDown;
			numericUpDown = this.nud_nb_m1;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Baixo);
			this.nud_nb_m1 = numericUpDown;
			numericUpDown = this.nud_partida1;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.partida.Motor1);
			this.nud_partida1 = numericUpDown;
			numericUpDown = this.nud_parada1;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.parada.Motor1);
			this.nud_parada1 = numericUpDown;
			comboBox = this.cb_modo_partida2;
			this.CarregaComboBoxBaudRate(ref comboBox, ref RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1]);
			this.cb_modo_partida2 = comboBox;
			numericUpDown = this.nud_na_m2;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Alto);
			this.nud_na_m2 = numericUpDown;
			numericUpDown = this.nud_nb_m2;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Baixo);
			this.nud_nb_m2 = numericUpDown;
			numericUpDown = this.nud_partida2;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.partida.Motor2);
			this.nud_partida2 = numericUpDown;
			numericUpDown = this.nud_parada2;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.parada.Motor2);
			this.nud_parada2 = numericUpDown;
			comboBox = this.cb_modo_partida3;
			this.CarregaComboBoxBaudRate(ref comboBox, ref RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2]);
			this.cb_modo_partida3 = comboBox;
			numericUpDown = this.nud_na_m3;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Alto);
			this.nud_na_m3 = numericUpDown;
			numericUpDown = this.nud_nb_m3;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Baixo);
			this.nud_nb_m3 = numericUpDown;
			numericUpDown = this.nud_partida3;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.partida.Motor2);
			this.nud_partida3 = numericUpDown;
			numericUpDown = this.nud_parada3;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.cfg_geral.parada.Motor2);
			this.nud_parada3 = numericUpDown;
			comboBox = this.cb_ModoRepetidora;
			this.CarregaComboBoxBaudRate(ref comboBox, ref RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora);
			this.cb_ModoRepetidora = comboBox;
			numericUpDown = this.NumericUpDown_end_rep_820;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.repetidora.End_repetidora);
			this.NumericUpDown_end_rep_820 = numericUpDown;
			numericUpDown = this.NumericUpDown_num_est_rep_820;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_821_200_BD.repetidora.Num_repetidoras);
			this.NumericUpDown_num_est_rep_820 = numericUpDown;
			this.Inicializa_DadosEStruturaRT820_Default();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			this.TabPage_geral.BackColor = Color.FromKnownColor(8);
			this.TabPage_geral.ForeColor = Color.FromKnownColor(10);
			this.TabPage_ED.BackColor = Color.FromKnownColor(8);
			this.TabPage_ED.ForeColor = Color.FromKnownColor(10);
			this.TabPage_repetidora.BackColor = Color.FromKnownColor(8);
			this.TabPage_repetidora.ForeColor = Color.FromKnownColor(10);
			this.TabPage1.BackColor = Color.FromKnownColor(8);
			this.TabPage1.ForeColor = Color.FromKnownColor(10);
			this.TabPage_MotoresValvulas.BackColor = Color.FromKnownColor(8);
			this.TabPage_MotoresValvulas.ForeColor = Color.FromKnownColor(10);
			this.GroupBox_comunicacao_820.Enabled = true;
			this.GroupBox_informacoes_820.Enabled = true;
			this.GroupBox_descricao_RT820.Enabled = true;
			this.GroupBox_parametros_repetidora_820.Enabled = true;
			this.GroupBox_end_rep_820.Enabled = true;
			string text = ".\\\\Fontes\\\\Ictel Extendida Italic.ttf";
			if (MyProject.Computer.FileSystem.FileExists(text))
			{
				PrivateFontCollection privateFontCollection = new PrivateFontCollection();
				privateFontCollection.AddFontFile(text);
				Font font = new Font(privateFontCollection.Families[0], 8f, 2);
				Font font2 = new Font(privateFontCollection.Families[0], 18f, 2);
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
			this.Atualiza_TelaRT820();
			this.ToolStripLabel1.Text = RT_geral.MontaNomePlacaPeloFabricante(RT_geral.RT_821_200_BD.firmware.Equip.Valor, RT_geral.RT_821_200_BD.firmware.Versao.Valor);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x002BF38C File Offset: 0x002BD78C
		private void RT_821_conf_Activated(object sender, EventArgs e)
		{
			Geral.Equipamento_selecionado = 821;
			Geral.Equipamento_versao = 2;
			Geral.Equipamento_build = 20;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x002BF3A8 File Offset: 0x002BD7A8
		private void RT_821_conf_FormClosed(object sender, FormClosedEventArgs e)
		{
			RT_geral.Telas_RT_821_200.Configuracao = false;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x002BF3B8 File Offset: 0x002BD7B8
		private void GeraDataGridView_Processos()
		{
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x002BF3BC File Offset: 0x002BD7BC
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
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].TagColuna = "Retorno Acionamento";
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].TagColuna = "Desacionamento";
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].TagColuna = "Retorno Desacionamento";
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].TagColuna = "Seleção Remoto";
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].TagColuna = "Bloqueio Digital";
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].TagColuna = "Liberação Digital";
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].TagColuna = "Seleção Reverso";
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].TagColuna = "Modo Controle";
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].TagColuna = "Grupo de Controle";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].TagColuna = "Tempo Partida";
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].TagColuna = "Tempo Parada";
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].TagColuna = "Tempo Mínimo Parado";
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].TagColuna = "Tempo Mínimo Operando";
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
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].NomeColuna = "TpMaxPart";
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].NomeColuna = "TpMaxParada";
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].NomeColuna = "TpMinParado";
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].NomeColuna = "TpMinOperan";
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].LarguraColuna = 110;
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LarguraColuna = 50;
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].LarguraColuna = 50;
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].LarguraColuna = 50;
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].LarguraColuna = 55;
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasMenu[0] = "Desativa";
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasMenu[0] = "Desativa";
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasValor[0] = 21856;
				int num;
				int num2;
				if (RT_geral.RT_820_BD.HabExpIO.Valor == 21857)
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
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasMenu[i] = "Periférico - " + Strings.Format(i + num2 - 12, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasValor[i] = 21860 + i + num2;
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasMenu[i] = "Periférico - " + Strings.Format(i + num2 - 12, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasValor[i] = 21860 + i + num2;
				}
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasMenu[0] = "Não usada";
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasMenu[0] = "Não usada";
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].LinhasMenu[0] = "Sempre Remoto";
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].LinhasMenu[0] = "Sem Liberação";
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].LinhasValor[0] = 21856;
				if (RT_geral.RT_820_BD.HabExpIO.Valor == 21857)
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
				num5 = num + 1;
				num = num5 + 4;
				int num10 = num5;
				int num11 = num;
				for (i = num10; i <= num11; i++)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasMenu[i] = "Periférico - " + Strings.Format(i - 16 + num2, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasValor[i] = 21856 + i + num2;
					RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasMenu[i] = "Periférico - " + Strings.Format(i - 16 + num2, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasValor[i] = 21856 + i + num2;
				}
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasMenu[0] = "Sem Bloqueio";
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasValor[0] = 21856;
				if (RT_geral.RT_820_BD.HabExpIO.Valor == 21857)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[5].NumeroLinhaMenu = 33;
					num = 16;
				}
				else
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[5].NumeroLinhaMenu = 17;
					num = 8;
				}
				int num12 = 1;
				int num13 = num;
				for (i = num12; i <= num13; i++)
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
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].NumeroLinhaMenu = 3;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasMenu[0] = "Telecomando";
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasMenu[1] = "Automático";
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasMenu[2] = "Timer";
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasValor[1] = 21857;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasValor[2] = 21858;
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].NumeroLinhaMenu = 5;
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasMenu[0] = "Nenhum Grupo";
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasValor[0] = 21856;
				i = 1;
				do
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasMenu[i] = "Grupo - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasValor[i] = 21856 + i;
					i++;
				}
				while (i <= 4);
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x002C00C0 File Offset: 0x002BE4C0
		private void GeraDataGridView_Grupos()
		{
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x002C00C4 File Offset: 0x002BE4C4
		private void InicializaEstrutura_DataGridView_agrupamentos()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewGruposColunas[num].LinhasMenu = new string[10];
					RT_geral.RT_820_DataGrigViewGruposColunas[num].LinhasValor = new int[10];
					num++;
				}
				while (num <= 1);
				RT_geral.RT_820_DataGrigViewGruposColunas[0].TagColuna = "Acionamentos Permitidos";
				RT_geral.RT_820_DataGrigViewGruposColunas[1].TagColuna = "Tempo Entre Acionamentos";
				RT_geral.RT_820_DataGrigViewGruposColunas[0].NomeColuna = "ASimultaneos";
				RT_geral.RT_820_DataGrigViewGruposColunas[1].NomeColuna = "TpAcionamentos";
				RT_geral.RT_820_DataGrigViewGruposColunas[0].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewGruposColunas[1].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewGruposColunas[0].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewGruposColunas[1].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewGruposColunas[0].NumeroLinhaMenu = 9;
				RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasMenu[0] = "Liberado";
				RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasValor[0] = 21856;
				num = 1;
				do
				{
					RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasMenu[num] = Strings.Format(num, "0#");
					RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasValor[num] = 21856 + num;
					num++;
				}
				while (num <= 8);
				RT_geral.RT_820_DataGrigViewGruposColunas[1].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x002C023C File Offset: 0x002BE63C
		private void GeraDataGridView_EA()
		{
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x002C0240 File Offset: 0x002BE640
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
			RT_geral.RT_820_DataGrigViewEAColunas[0].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewEAColunas[1].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewEAColunas[2].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewEAColunas[0].NumeroLinhaMenu = 0;
			RT_geral.RT_820_DataGrigViewGruposColunas[1].NumeroLinhaMenu = 0;
			RT_geral.RT_820_DataGrigViewGruposColunas[2].NumeroLinhaMenu = 0;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x002C036C File Offset: 0x002BE76C
		private void GeraDataGridView_Perifericos()
		{
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x002C0370 File Offset: 0x002BE770
		private void InicializaEstrutura_DataGridView_Periferico()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewPerifericosColunas[num].LinhasMenu = new string[12];
					RT_geral.RT_820_DataGrigViewPerifericosColunas[num].LinhasValor = new int[12];
					num++;
				}
				while (num <= 1);
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].TagColuna = "Modelo";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[1].TagColuna = "Endereço";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].NomeColuna = "modelo";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[1].NomeColuna = "end";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LarguraColuna = 250;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[1].LarguraColuna = 60;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[1].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].NumeroLinhaMenu = 12;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[0] = 48;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[1] = 49;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[2] = 50;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[3] = 51;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[4] = 52;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[5] = 53;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[6] = 54;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[7] = 55;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[8] = 56;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[9] = 57;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[10] = 58;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[11] = 59;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[0] = "Periférico Desabilitado";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[1] = "Reserva";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[2] = "Leitura Vazão Interna";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[3] = "Equipamento de Leitura Vazão";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[4] = "Multimedidor IMS mod: Smart Trans";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[5] = "Multimedidor KRON mod: Mult K-05";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[6] = "Inversor Danfoss VLT";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[7] = "Multimedidor SIEMENS PAC 3200";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[8] = "Inversor WEG CFW09";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[9] = "Softstarter WEG SSW07";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[10] = "Interface ELO 2148";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[11] = "Softstarter Danfoss MD3000";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[1].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x002C0684 File Offset: 0x002BEA84
		private void GeraDataGridView_Vazoes()
		{
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x002C0688 File Offset: 0x002BEA88
		private void InicializaEstrutura_DataGridView_Vazoes()
		{
			int i = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewVazoesColunas[i].LinhasMenu = new string[51];
					RT_geral.RT_820_DataGrigViewVazoesColunas[i].LinhasValor = new int[51];
					i++;
				}
				while (i <= 0);
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].TagColuna = "Entrada";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].NomeColuna = "Entrada";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LarguraColuna = 200;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[0] = "Leitura desabilitada";
				int num;
				if (RT_geral.RT_820_BD.HabExpIO.Valor == 21857)
				{
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].NumeroLinhaMenu = 49;
					num = 16;
				}
				else
				{
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].NumeroLinhaMenu = 33;
					num = 8;
				}
				i = 1;
				do
				{
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[i] = 21856 + i;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[i] = "Leitura vazão - EA " + Strings.Format(i, "#0");
					i++;
				}
				while (i <= 16);
				int num2 = 1;
				int num3 = num;
				for (i = num2; i <= num3; i++)
				{
					int num4 = i * 2;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[num4 + 16 - 1] = "ED - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[num4 + 16] = "ED - " + Strings.Format(i, "0#") + " reverso";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[num4 + 16 - 1] = 21872 + num4 - 1;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[num4 + 16] = 21872 + num4;
				}
			}
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x002C0898 File Offset: 0x002BEC98
		private void GeraDataGridView_ED()
		{
			this.DataGridView_RT820_ED.Columns.Clear();
			this.DataGridView_RT820_ED.CellBorderStyle = 1;
			this.DataGridView_RT820_ED.DefaultCellStyle.Alignment = 64;
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
				this.DataGridView_RT820_ED.RowCount = 8;
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
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x002C09D4 File Offset: 0x002BEDD4
		private void InicializaEstrutura_DataGridView_ED()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewEDColunas[num].LinhasMenu = new string[32];
					RT_geral.RT_820_DataGrigViewEDColunas[num].LinhasValor = new int[32];
					num++;
				}
				while (num <= 0);
				RT_geral.RT_820_DataGrigViewEDColunas[0].TagColuna = "Entrada";
				RT_geral.RT_820_DataGrigViewEDColunas[0].NomeColuna = "Entrada";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LarguraColuna = 250;
				RT_geral.RT_820_DataGrigViewEDColunas[0].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[0] = 0;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[1] = 21904;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[2] = 21905;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[3] = 21906;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[4] = 21908;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[5] = 21909;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[6] = 21910;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[7] = 21920;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[8] = 21921;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[9] = 21922;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[10] = 21923;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[11] = 21934;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[0] = "--------";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[1] = "Retorno Motor1";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[2] = "Retorno Motor2";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[3] = "Retorno Motor3";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[4] = "Monitoração de Arrombamento";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[5] = "Monitoração de Falta de Fase";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[6] = "Monitoração de Alagamento";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[7] = "Monitoramento de Horario de Ponta";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[8] = "Local / Remoto Motor1";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[9] = "Local / Remoto Motor2";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[10] = "Local / Remoto Motor3";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[11] = "Verificação Operação em Bateria";
				RT_geral.RT_820_DataGrigViewEDColunas[0].NumeroLinhaMenu = 12;
			}
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x002C0CA8 File Offset: 0x002BF0A8
		private void GeraDataGridView_Repedidora()
		{
			this.DataGridView_end_rep_RT820.Columns.Clear();
			this.DataGridView_end_rep_RT820.CellBorderStyle = 1;
			this.DataGridView_end_rep_RT820.DefaultCellStyle.Alignment = 64;
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

		// Token: 0x06000961 RID: 2401 RVA: 0x002C0E0C File Offset: 0x002BF20C
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
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[0].AlingColuna = 32;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[1].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[2].AlingColuna = 32;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[3].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[4].AlingColuna = 32;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[5].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[6].AlingColuna = 32;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[7].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[8].AlingColuna = 32;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[9].AlingColuna = 64;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x002C112C File Offset: 0x002BF52C
		private void GeraDataGridView_Setpoints()
		{
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x002C1130 File Offset: 0x002BF530
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
				RT_geral.RT_820_DataGrigViewSetpointsColunas[2].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[1].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[4].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[5].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[3].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[2].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[1].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[4].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[5].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasMenu[0] = "Controle Desabilitado";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].NumeroLinhaMenu = 21;
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
					RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasMenu[num] = "Valor Referência " + Strings.Format(num - 16, "#");
					RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasValor[num] = 21856 + num;
					RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasMenu[num] = "Valor Referência " + Strings.Format(num - 16, "#");
					RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasValor[num] = 21856 + num;
					num++;
				}
				while (num <= 20);
			}
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x002C154C File Offset: 0x002BF94C
		private void GeraDataGridView_Timer()
		{
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x002C1550 File Offset: 0x002BF950
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
				RT_geral.RT_820_DataGrigViewTimerColunas[0].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[1].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[2].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[3].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[4].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[5].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[6].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[7].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[8].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[9].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[10].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[11].AlingColuna = 32;
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

		// Token: 0x06000966 RID: 2406 RVA: 0x002C1A18 File Offset: 0x002BFE18
		public void Inicializa_DadosEStruturaRT821_Padrao()
		{
			RT_geral.RT_821_200_BD.firmware.Versao.nome = "Versão";
			RT_geral.RT_821_200_BD.firmware.Versao.Padrao = 2;
			RT_geral.RT_821_200_BD.firmware.Build.nome = "Build";
			RT_geral.RT_821_200_BD.firmware.Build.Padrao = 0;
			RT_geral.RT_821_200_BD.firmware.Release.nome = "Release";
			RT_geral.RT_821_200_BD.firmware.Release.Padrao = 0;
			RT_geral.RT_821_200_BD.firmware.Equip.nome = "Tipo equipamento";
			RT_geral.RT_821_200_BD.firmware.Equip.Padrao = 821;
			RT_geral.RT_821_200_BD.cfg_geral.End_estacao.nome = "Endereço Estação";
			RT_geral.RT_821_200_BD.cfg_geral.End_estacao.Padrao = 1;
			RT_geral.RT_821_200_BD.cfg_geral.End_estacao.Lmte_inf = 1;
			RT_geral.RT_821_200_BD.cfg_geral.End_estacao.Lmte_sup = 200;
			RT_geral.RT_821_200_BD.cfg_geral.End_mestre.nome = "Endereço Mestre";
			RT_geral.RT_821_200_BD.cfg_geral.End_mestre.Padrao = 100;
			RT_geral.RT_821_200_BD.cfg_geral.End_mestre.Lmte_inf = 1;
			RT_geral.RT_821_200_BD.cfg_geral.End_mestre.Lmte_sup = 200;
			RT_geral.RT_821_200_BD.cfg_geral.Tempo_ptt.nome = "Tempo PTT";
			RT_geral.RT_821_200_BD.cfg_geral.Tempo_ptt.Padrao = 200;
			RT_geral.RT_821_200_BD.cfg_geral.Tempo_ptt.Lmte_inf = 100;
			RT_geral.RT_821_200_BD.cfg_geral.Tempo_ptt.Lmte_sup = 2000;
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].nome = "ED " + Conversion.Str(num + 1);
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].Indice_padrao = 0;
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].Numero_itens = 12;
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].itens = new string[RT_geral.RT_821_200_BD.cfg_geral.entradas[num].Numero_itens + 1];
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].valores = new int[RT_geral.RT_821_200_BD.cfg_geral.entradas[num].Numero_itens + 1];
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].itens[0] = "--------";
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].itens[1] = "Retorno Motor1";
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].itens[2] = "Retorno Motor2";
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].itens[3] = "Retorno Motor3";
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].itens[4] = "Monitoração de Arrombamento";
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].itens[5] = "Monitoração de Falta de Fase";
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].itens[6] = "Monitoração de Alagamento";
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].itens[7] = "Indicação Horário Ponta";
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].itens[8] = "Local/Remoto Motor1";
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].itens[9] = "Local/Remoto Motor2";
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].itens[10] = "Local/Remoto Motor3";
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].itens[11] = "Verificação Operação em Bateria";
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].valores[0] = 0;
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].valores[1] = 21904;
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].valores[2] = 21905;
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].valores[3] = 21906;
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].valores[4] = 21908;
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].valores[5] = 21909;
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].valores[6] = 21910;
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].valores[7] = 21920;
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].valores[8] = 21921;
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].valores[9] = 21922;
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].valores[10] = 21923;
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].valores[11] = 21934;
					num++;
				}
				while (num <= 7);
				RT_geral.RT_821_200_BD.cfg_geral.quantidade_motores.nome = "Número de Motores";
				RT_geral.RT_821_200_BD.cfg_geral.quantidade_motores.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.cfg_geral.quantidade_motores.Lmte_sup = 3;
				RT_geral.RT_821_200_BD.cfg_geral.quantidade_motores.Padrao = 0;
				RT_geral.RT_821_200_BD.cfg_geral.motores_simultaneos.nome = "Motores Simultâneos";
				RT_geral.RT_821_200_BD.cfg_geral.motores_simultaneos.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.cfg_geral.motores_simultaneos.Lmte_sup = 3;
				RT_geral.RT_821_200_BD.cfg_geral.motores_simultaneos.Padrao = 0;
				RT_geral.RT_821_200_BD.cfg_geral.tempo_acionamentos.nome = "Tempo entre acionamentos";
				RT_geral.RT_821_200_BD.cfg_geral.tempo_acionamentos.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.cfg_geral.tempo_acionamentos.Lmte_sup = 32000;
				RT_geral.RT_821_200_BD.cfg_geral.tempo_acionamentos.Padrao = 0;
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].nome = "Modo Partida Motor1";
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].Numero_itens = 2;
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].Indice_padrao = 0;
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].itens[0] = "Manual";
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].itens[1] = "Automático";
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].valores[0] = 21877;
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].valores[1] = 21878;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Alto.nome = "Nível Alto";
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Alto.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Alto.Lmte_sup = 4000;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Alto.Padrao = 4000;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Baixo.nome = "Nível Alto";
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Baixo.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Baixo.Lmte_sup = 4000;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Baixo.Padrao = 3200;
				RT_geral.RT_821_200_BD.cfg_geral.partida.Motor1.nome = "Tempo partida";
				RT_geral.RT_821_200_BD.cfg_geral.partida.Motor1.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.cfg_geral.partida.Motor1.Lmte_sup = 32000;
				RT_geral.RT_821_200_BD.cfg_geral.partida.Motor1.Padrao = 180;
				RT_geral.RT_821_200_BD.cfg_geral.parada.Motor1.nome = "Tempo partida";
				RT_geral.RT_821_200_BD.cfg_geral.parada.Motor1.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.cfg_geral.parada.Motor1.Lmte_sup = 32000;
				RT_geral.RT_821_200_BD.cfg_geral.parada.Motor1.Padrao = 180;
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].nome = "Modo Partida Motor2";
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].Numero_itens = 2;
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].Indice_padrao = 0;
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].itens[0] = "Manual";
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].itens[1] = "Automático";
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].valores[0] = 21877;
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].valores[1] = 21878;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Alto.nome = "Nível Alto";
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Alto.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Alto.Lmte_sup = 4000;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Alto.Padrao = 4000;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Baixo.nome = "Nível Alto";
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Baixo.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Baixo.Lmte_sup = 4000;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Baixo.Padrao = 3200;
				RT_geral.RT_821_200_BD.cfg_geral.partida.Motor2.nome = "Tempo partida";
				RT_geral.RT_821_200_BD.cfg_geral.partida.Motor2.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.cfg_geral.partida.Motor2.Lmte_sup = 32000;
				RT_geral.RT_821_200_BD.cfg_geral.partida.Motor2.Padrao = 180;
				RT_geral.RT_821_200_BD.cfg_geral.parada.Motor2.nome = "Tempo partida";
				RT_geral.RT_821_200_BD.cfg_geral.parada.Motor2.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.cfg_geral.parada.Motor2.Lmte_sup = 32000;
				RT_geral.RT_821_200_BD.cfg_geral.parada.Motor2.Padrao = 180;
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].nome = "Modo Partida Motor3";
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].Numero_itens = 2;
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].Indice_padrao = 0;
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].itens[0] = "Manual";
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].itens[1] = "Automático";
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].valores[0] = 21877;
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].valores[1] = 21878;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Alto.nome = "Nível Alto";
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Alto.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Alto.Lmte_sup = 4000;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Alto.Padrao = 4000;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Baixo.nome = "Nível Alto";
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Baixo.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Baixo.Lmte_sup = 4000;
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Baixo.Padrao = 3200;
				RT_geral.RT_821_200_BD.cfg_geral.partida.Motor3.nome = "Tempo partida";
				RT_geral.RT_821_200_BD.cfg_geral.partida.Motor3.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.cfg_geral.partida.Motor3.Lmte_sup = 32000;
				RT_geral.RT_821_200_BD.cfg_geral.partida.Motor3.Padrao = 180;
				RT_geral.RT_821_200_BD.cfg_geral.parada.Motor3.nome = "Tempo partida";
				RT_geral.RT_821_200_BD.cfg_geral.parada.Motor3.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.cfg_geral.parada.Motor3.Lmte_sup = 32000;
				RT_geral.RT_821_200_BD.cfg_geral.parada.Motor3.Padrao = 180;
				RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.nome = "Modo Repetição";
				RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.Numero_itens = 3;
				RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.Indice_padrao = 0;
				RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.valores[0] = 0;
				RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.valores[1] = 21856;
				RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.valores[2] = 21857;
				RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.itens[0] = "Função Desabilitada";
				RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.itens[1] = "Repetidora Direta";
				RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.itens[2] = "Repetidora Cruzada";
				RT_geral.RT_821_200_BD.repetidora.End_repetidora.nome = "Endereço Repetidora";
				RT_geral.RT_821_200_BD.repetidora.End_repetidora.Padrao = 1;
				RT_geral.RT_821_200_BD.repetidora.End_repetidora.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.repetidora.End_repetidora.Lmte_sup = 200;
				RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.nome = "Número de Repetidoras";
				RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.Padrao = 0;
				RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.Lmte_inf = 0;
				RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.Lmte_sup = 50;
				num = 0;
				do
				{
					RT_geral.RT_821_200_BD.repetidora.Repetidoras[num].nome = "Endereço da Repetidora " + Conversion.Str(num + 1);
					RT_geral.RT_821_200_BD.repetidora.Repetidoras[num].Padrao = 0;
					RT_geral.RT_821_200_BD.repetidora.Repetidoras[num].Lmte_inf = 0;
					RT_geral.RT_821_200_BD.repetidora.Repetidoras[num].Lmte_sup = 200;
					num++;
				}
				while (num <= 49);
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x002C2B34 File Offset: 0x002C0F34
		public void Inicializa_DadosEStruturaRT820_Default()
		{
			RT_geral.RT_821_200_BD.firmware.Equip.ValorPadrao();
			RT_geral.RT_821_200_BD.firmware.Versao.ValorPadrao();
			RT_geral.RT_821_200_BD.firmware.Build.ValorPadrao();
			RT_geral.RT_821_200_BD.firmware.Release.ValorPadrao();
			RT_geral.RT_821_200_BD.cfg_geral.End_estacao.ValorPadrao();
			RT_geral.RT_821_200_BD.cfg_geral.End_mestre.ValorPadrao();
			RT_geral.RT_821_200_BD.cfg_geral.Tempo_ptt.ValorPadrao();
			this.TextBox_comentarios_RT820.Text = "";
			this.TextBox_endereco_RT820.Text = "";
			this.TextBox_nome_RT820.Text = "";
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_821_200_BD.cfg_geral.entradas[num].IndicePadrao();
					num++;
				}
				while (num <= 7);
				RT_geral.RT_821_200_BD.cfg_geral.quantidade_motores.ValorPadrao();
				RT_geral.RT_821_200_BD.cfg_geral.motores_simultaneos.ValorPadrao();
				RT_geral.RT_821_200_BD.cfg_geral.tempo_acionamentos.ValorPadrao();
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].IndicePadrao();
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Alto.ValorPadrao();
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Baixo.ValorPadrao();
				RT_geral.RT_821_200_BD.cfg_geral.partida.Motor1.ValorPadrao();
				RT_geral.RT_821_200_BD.cfg_geral.parada.Motor1.ValorPadrao();
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].IndicePadrao();
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Alto.ValorPadrao();
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Baixo.ValorPadrao();
				RT_geral.RT_821_200_BD.cfg_geral.partida.Motor2.ValorPadrao();
				RT_geral.RT_821_200_BD.cfg_geral.parada.Motor2.ValorPadrao();
				RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].IndicePadrao();
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Alto.ValorPadrao();
				RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Baixo.ValorPadrao();
				RT_geral.RT_821_200_BD.cfg_geral.partida.Motor3.ValorPadrao();
				RT_geral.RT_821_200_BD.cfg_geral.parada.Motor3.ValorPadrao();
				RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.IndicePadrao();
				RT_geral.RT_821_200_BD.repetidora.End_repetidora.ValorPadrao();
				RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.ValorPadrao();
				num = 0;
				do
				{
					RT_geral.RT_821_200_BD.repetidora.Repetidoras[num].ValorPadrao();
					num++;
				}
				while (num <= 49);
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x002C2E38 File Offset: 0x002C1238
		public void Atualiza_TelaRT820()
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
					string text = "Geral";
					this.TextBox_versao_820.Text = Conversions.ToString(RT_geral.RT_821_200_BD.firmware.Versao.Valor);
					this.TextBox_build_820.Text = Conversions.ToString(RT_geral.RT_821_200_BD.firmware.Build.Valor);
					this.TextBox_release_820.Text = Conversions.ToString(RT_geral.RT_821_200_BD.firmware.Release.Valor);
					this.TextBox_equipamento_820.Text = Conversions.ToString(RT_geral.RT_821_200_BD.firmware.Equip.Valor);
					this.NumericUpDown_end_est_820.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.End_estacao.Valor);
					this.NumericUpDown_end_mestre_820.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.End_mestre.Valor);
					this.NumericUpDown_temp_ptt_820.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.Tempo_ptt.Valor);
					text = "ED";
					int num2 = 0;
					do
					{
						string value = RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[RT_geral.RT_821_200_BD.cfg_geral.entradas[num2].Indice];
						this.DataGridView_RT820_ED.Rows[num2].Cells[0].Value = value;
						num2++;
					}
					while (num2 <= 7);
					text = "MOTORES";
					this.nud_numero_motores.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.quantidade_motores.Valor);
					this.nud_motores_simultaneos.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.motores_simultaneos.Valor);
					this.nud_tempo_operacoes.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.tempo_acionamentos.Valor);
					this.cb_modo_partida1.SelectedIndex = RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].Indice;
					this.nud_na_m1.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Alto.Valor);
					this.nud_nb_m1.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Baixo.Valor);
					this.nud_partida1.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.partida.Motor1.Valor);
					this.nud_parada1.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.parada.Motor1.Valor);
					this.cb_modo_partida2.SelectedIndex = RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].Indice;
					this.nud_na_m2.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Alto.Valor);
					this.nud_nb_m2.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Baixo.Valor);
					this.nud_partida2.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.partida.Motor2.Valor);
					this.nud_parada2.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.parada.Motor2.Valor);
					this.cb_modo_partida3.SelectedIndex = RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].Indice;
					this.nud_na_m3.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Alto.Valor);
					this.nud_nb_m3.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Baixo.Valor);
					this.nud_partida3.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.partida.Motor3.Valor);
					this.nud_parada3.Value = new decimal(RT_geral.RT_821_200_BD.cfg_geral.parada.Motor3.Valor);
					text = "Repetidora";
					this.cb_ModoRepetidora.SelectedIndex = RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.Indice;
					this.NumericUpDown_end_rep_820.Value = new decimal(RT_geral.RT_821_200_BD.repetidora.End_repetidora.Valor);
					this.NumericUpDown_num_est_rep_820.Value = new decimal(RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.Valor);
					num2 = 0;
					do
					{
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[1].Value = RT_geral.RT_821_200_BD.repetidora.Repetidoras[num2].Valor.ToString();
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[3].Value = RT_geral.RT_821_200_BD.repetidora.Repetidoras[num2 + 10].Valor.ToString();
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[5].Value = RT_geral.RT_821_200_BD.repetidora.Repetidoras[num2 + 20].Valor.ToString();
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[7].Value = RT_geral.RT_821_200_BD.repetidora.Repetidoras[num2 + 30].Valor.ToString();
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[9].Value = RT_geral.RT_821_200_BD.repetidora.Repetidoras[num2 + 40].Valor.ToString();
						num2++;
					}
					while (num2 <= 9);
					goto IL_65E;
					IL_601:
					MessageBox.Show("Erro nas variávies: " + text, "Função: Atualiza_TelaRT820");
					goto IL_65E;
					IL_619:
					num3 = -1;
										IL_62F:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num3 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_619;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_65E:
				if (num3 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x002C34C8 File Offset: 0x002C18C8
		public void Habilita_Funcoes_de_Tela_RT_820(int tipo)
		{
			this.GroupBox_comunicacao_820.Enabled = true;
			this.GroupBox_informacoes_820.Enabled = false;
			this.GroupBox_ED_820.Enabled = false;
			this.GroupBox_parametros_repetidora_820.Enabled = false;
			this.GroupBox_end_rep_820.Enabled = false;
			this.DataGridView_end_rep_RT820.Visible = false;
			switch (tipo)
			{
			case 0:
				this.GroupBox_informacoes_820.Enabled = true;
				this.GroupBox_ED_820.Enabled = true;
				this.GroupBox_parametros_repetidora_820.Enabled = true;
				this.GroupBox_end_rep_820.Enabled = true;
				this.DataGridView_end_rep_RT820.Visible = true;
				break;
			}
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x002C3570 File Offset: 0x002C1970
		private void Habilita_objetos_rep(bool ativa)
		{
			if (ativa)
			{
				this.Label_end_rep_820.Enabled = true;
				this.Label_num_est_rep_820.Enabled = true;
				this.NumericUpDown_end_rep_820.Enabled = true;
				this.NumericUpDown_num_est_rep_820.Enabled = true;
				this.GroupBox_end_rep_820.Enabled = true;
				this.DataGridView_end_rep_RT820.Visible = true;
			}
			else
			{
				this.Label_end_rep_820.Enabled = false;
				this.Label_num_est_rep_820.Enabled = false;
				this.NumericUpDown_end_rep_820.Enabled = false;
				this.NumericUpDown_num_est_rep_820.Enabled = false;
				this.GroupBox_end_rep_820.Enabled = false;
				this.DataGridView_end_rep_RT820.Visible = false;
			}
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x002C3614 File Offset: 0x002C1A14
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

		// Token: 0x0600096C RID: 2412 RVA: 0x002C3678 File Offset: 0x002C1A78
		public void InicializaBarraProgressoTela_RT_820(int num_passos)
		{
			this.ToolStripProgressBar_RT_820.Minimum = 0;
			this.ToolStripProgressBar_RT_820.Maximum = 100;
			this.ToolStripProgressBar_RT_820.Step = checked((int)Math.Round(unchecked(100.0 / (double)num_passos + 1.0)));
			this.ToolStripProgressBar_RT_820.Value = 0;
			this.ToolStripProgressBar_RT_820.BackColor = Color.LightGray;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x002C36E4 File Offset: 0x002C1AE4
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

		// Token: 0x0600096E RID: 2414 RVA: 0x002C3754 File Offset: 0x002C1B54
		private void NumericUpDown_end_rep_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.repetidora.End_repetidora.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.repetidora.End_repetidora, true);
			sender = numericUpDown;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x002C37B4 File Offset: 0x002C1BB4
		private void NumericUpDown_num_est_rep_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.repetidora.Num_repetidoras, true);
			sender = numericUpDown;
			int num = 0;
			int num2 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null), 1));
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

		// Token: 0x06000970 RID: 2416 RVA: 0x002C3C78 File Offset: 0x002C2078
		private void NumericUpDown_intervalo_filtro_820_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x002C3C7C File Offset: 0x002C207C
		private void NumericUpDown_tamanho_filtro_820_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x002C3C80 File Offset: 0x002C2080
		private void CarregaNumericUpDown(ref NumericUpDown nud, RT_geral.Integer_ictel @int)
		{
			nud.Maximum = new decimal(@int.Lmte_sup);
			nud.Minimum = new decimal(@int.Lmte_inf);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x002C3CA8 File Offset: 0x002C20A8
		private void CarregaComboBoxBaudRate(ref ComboBox cb, ref RT_geral.Combo_ictel dado)
		{
			cb.Items.Clear();
			int num = 0;
			checked
			{
				int num2 = dado.Numero_itens - 1;
				for (int i = num; i <= num2; i++)
				{
					cb.Items.Add(dado.itens[i]);
				}
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x002C3CEC File Offset: 0x002C20EC
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

		// Token: 0x06000975 RID: 2421 RVA: 0x002C3E10 File Offset: 0x002C2210
		private void ComboBox_modo_simulado_820_SelectedIndexChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x002C3E14 File Offset: 0x002C2214
		private void NumericUpDown_end_mestre_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.End_mestre.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.End_mestre, true);
			sender = numericUpDown;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x002C3E74 File Offset: 0x002C2274
		private void NumericUpDown_end_est_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.End_estacao.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.End_estacao, true);
			sender = numericUpDown;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x002C3ED4 File Offset: 0x002C22D4
		private void NumericUpDown_temp_ptt_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.Tempo_ptt.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.Tempo_ptt, true);
			sender = numericUpDown;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x002C3F34 File Offset: 0x002C2334
		private void ComboBox_baudrate_COM2_820_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.Valor = RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.valores[RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.Indice];
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x002C3FAC File Offset: 0x002C23AC
		private void CheckBox_hab_expansao_IO_820_CheckedChanged(object sender, EventArgs e)
		{
			checked
			{
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null), true, false))
				{
					RT_geral.RT_820_BD.HabExpIO.Valor = 21857;
					this.DataGridView_RT820_ED.Height = 376;
					this.GroupBox_ED_820.Height = 417;
				}
				else
				{
					RT_geral.RT_820_BD.HabExpIO.Valor = 21856;
					this.DataGridView_RT820_ED.Height = 200;
					this.GroupBox_ED_820.Height = 241;
					int num = 8;
					do
					{
						RT_geral.RT_820_BD.config_ED[num].Valor = RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[0];
						RT_geral.RT_820_BD.config_ED[num].Indice = 0;
						num++;
					}
					while (num <= 15);
				}
				if (!this.bloqueio_IO)
				{
					int num = 0;
					do
					{
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_BD.ctrl_acionamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[0], "SD", RT_geral.RT_820_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_BD.ctrl_desligamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[2], "SD", RT_geral.RT_820_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_BD.ctrl_ret_acionamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[1], "ED", RT_geral.RT_820_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_BD.ctrl_ret_desligamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[3], "ED", RT_geral.RT_820_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_BD.ctrl_ED_selecao[num], RT_geral.RT_820_DataGrigViewProcessosColunas[4], "ED", RT_geral.RT_820_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_BD.ctrl_ED_liberacao[num], RT_geral.RT_820_DataGrigViewProcessosColunas[6], "ED", RT_geral.RT_820_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_BD.ctrl_ED_bloqueio[num], RT_geral.RT_820_DataGrigViewProcessosColunas[5], "ED", RT_geral.RT_820_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_BD.config_vazao[num], RT_geral.RT_820_DataGrigViewVazoesColunas[0], "VZ", RT_geral.RT_820_BD.HabExpIO.Valor);
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

		// Token: 0x0600097B RID: 2427 RVA: 0x002C4298 File Offset: 0x002C2698
		private void DataGridView_processo_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x002C429C File Offset: 0x002C269C
		private void DataGridView_processo_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x002C42A0 File Offset: 0x002C26A0
		private void DataGridView_processo_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x002C42A4 File Offset: 0x002C26A4
		private void DataGridView_grupos_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x002C42A8 File Offset: 0x002C26A8
		private void DataGridView_grupos_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x002C42AC File Offset: 0x002C26AC
		private void DataGridView_grupos_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x002C42B0 File Offset: 0x002C26B0
		private void DataGridView_parametros_EA_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x002C42B4 File Offset: 0x002C26B4
		private void DataGridView_parametros_EA_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x002C42B8 File Offset: 0x002C26B8
		private void DataGridView_parametros_EA_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x002C42BC File Offset: 0x002C26BC
		private void DataGridView_setpoints_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x002C42C0 File Offset: 0x002C26C0
		private void DataGridView_setpoints_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x002C42C4 File Offset: 0x002C26C4
		private void DataGridView_setpoints_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x002C42C8 File Offset: 0x002C26C8
		private void DataGridView_periferico_RT820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x002C42CC File Offset: 0x002C26CC
		private void DataGridView_periferico_RT820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x002C42D0 File Offset: 0x002C26D0
		private void DataGridView_periferico_RT820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x002C42D4 File Offset: 0x002C26D4
		private void DataGridView_vazoes_RT820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x002C42D8 File Offset: 0x002C26D8
		private void DataGridView_vazoes_RT820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x002C42DC File Offset: 0x002C26DC
		private void DataGridView_vazoes_RT820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x002C42E0 File Offset: 0x002C26E0
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
								RT_geral.RT_821_200_BD.cfg_geral.entradas[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewEDColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_821_200_BD.cfg_geral.entradas[e.RowIndex].Indice = i;
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

		// Token: 0x0600098E RID: 2446 RVA: 0x002C442C File Offset: 0x002C282C
		private void DataGridView_RT820_ED_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_RT820_ED.IsCurrentCellDirty)
			{
				this.DataGridView_RT820_ED.CommitEdit(512);
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x002C444C File Offset: 0x002C284C
		private void DataGridView_end_rep_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_end_rep_RT820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_end_1", false) == 0)
				{
					RT_geral.RT_821_200_BD.repetidora.Repetidoras[0 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_200_BD.repetidora.Repetidoras[0 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_2", false) == 0)
				{
					RT_geral.RT_821_200_BD.repetidora.Repetidoras[10 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_200_BD.repetidora.Repetidoras[10 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_3", false) == 0)
				{
					RT_geral.RT_821_200_BD.repetidora.Repetidoras[20 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_200_BD.repetidora.Repetidoras[20 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_4", false) == 0)
				{
					RT_geral.RT_821_200_BD.repetidora.Repetidoras[30 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_200_BD.repetidora.Repetidoras[30 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_5", false) == 0)
				{
					RT_geral.RT_821_200_BD.repetidora.Repetidoras[40 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_821_200_BD.repetidora.Repetidoras[40 + e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x002C46E0 File Offset: 0x002C2AE0
		private void DataGridView_end_rep_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			string dataPropertyName = this.DataGridView_end_rep_RT820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_end_1", false) == 0)
				{
					int num = 0;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_821_200_BD.repetidora.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_2", false) == 0)
				{
					int num = 10;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_821_200_BD.repetidora.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[3].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_3", false) == 0)
				{
					int num = 20;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_821_200_BD.repetidora.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[5].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_4", false) == 0)
				{
					int num = 30;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[7].Value));
					RT_geral.RT_821_200_BD.repetidora.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[7].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_5", false) == 0)
				{
					int num = 40;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[9].Value));
					RT_geral.RT_821_200_BD.repetidora.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[9].Value);
				}
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x002C4ACC File Offset: 0x002C2ECC
		private void DataGridView_end_rep_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_end_rep_RT820.IsCurrentCellDirty)
			{
				this.DataGridView_end_rep_RT820.CommitEdit(512);
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x002C4AEC File Offset: 0x002C2EEC
		private void DataGridView_timer_RT820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x002C4AF0 File Offset: 0x002C2EF0
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
						int num3;
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

		// Token: 0x06000994 RID: 2452 RVA: 0x002C4BD8 File Offset: 0x002C2FD8
		private void DataGridView_timer_RT820_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x002C4BDC File Offset: 0x002C2FDC
		private void ToolStripButton_RT_820_Abrir_Click(object sender, EventArgs e)
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
					this.AtivaEfeitoOnChangeValue();
					int[] array = new int[651];
					this.ToolStripButton_RT_820_Abrir.Enabled = false;
					this.ToolStripButton_RT_820_novo.Enabled = false;
					this.ToolStripButton_RT_820_Salvar.Enabled = false;
					this.ToolStripButton_RT_820_Download.Enabled = false;
					this.ToolStripButton_RT_820_Upload.Enabled = false;
					this.OpenFileDialog_RT_820.Filter = "Arquivo de configuração de equipamento|*.Cfg821_200";
					this.OpenFileDialog_RT_820.InitialDirectory = Linha_RT.diretorio;
					if (this.OpenFileDialog_RT_820.ShowDialog() == 1)
					{
						if (Operators.CompareString(this.OpenFileDialog_RT_820.FileName, "", false) != 0)
						{
							Linha_RT.diretorio = Path.GetDirectoryName(this.OpenFileDialog_RT_820.FileName) + "\\";
							RT_geral.arquivo_extensao = Path.GetExtension(this.OpenFileDialog_RT_820.FileName);
							IniFile iniFile = new IniFile(this.OpenFileDialog_RT_820.FileName);
							RT_geral.RT_821_200_BD.firmware.Equip.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "EQUIPAMENTO", RT_geral.RT_820_200_BD.firmware.Equip.Valor);
							RT_geral.RT_821_200_BD.firmware.Versao.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "VERSAO", RT_geral.RT_820_200_BD.firmware.Versao.Valor);
							RT_geral.RT_821_200_BD.firmware.Build.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "BUILD", RT_geral.RT_820_200_BD.firmware.Build.Valor);
							RT_geral.RT_821_200_BD.firmware.Release.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "RELEASE", RT_geral.RT_820_200_BD.firmware.Release.Valor);
							if (!Linha_RT.VerificaSeEquipamentoEValido(1, RT_geral.RT_821_200_BD.firmware.Equip.Valor, RT_geral.RT_821_200_BD.firmware.Versao.Valor, RT_geral.RT_821_200_BD.firmware.Build.Valor, RT_geral.RT_821_200_BD.firmware.Release.Valor, RT_geral.arquivo_extensao).Status)
							{
								RT_geral.Lmte_Init_ok = false;
								this.Inicializa_DadosEStruturaRT821_Padrao();
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
								RT_geral.RT_821_200_BD.filename = this.OpenFileDialog_RT_820.FileName;
								RT_geral.RT_821_200_BD.cfg_geral.End_estacao.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "ESTACAO", 0);
								RT_geral.RT_821_200_BD.cfg_geral.End_mestre.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "MESTRE", 0);
								RT_geral.RT_821_200_BD.cfg_geral.Tempo_ptt.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "TEMPO_PTT", 0);
								this.InicializaEStruturasVariaveis_RT820();
								int num2 = 0;
								do
								{
									string key = string.Format("ED{0}", num2 + 1);
									RT_geral.RT_821_200_BD.cfg_geral.entradas[num2].Valor = iniFile.ReadInteger("ENTRADA_DIGITAL", key, 0);
									Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.entradas[num2], RT_geral.RT_821_200_BD.cfg_geral.entradas[num2].Valor);
									num2++;
								}
								while (num2 <= 7);
								RT_geral.RT_821_200_BD.cfg_geral.quantidade_motores.Valor = iniFile.ReadInteger("MOTORES", "NUMERO_MOTORES", 0);
								RT_geral.RT_821_200_BD.cfg_geral.motores_simultaneos.Valor = iniFile.ReadInteger("MOTORES", "MOTORES_SIMULTANEOS", 0);
								RT_geral.RT_821_200_BD.cfg_geral.tempo_acionamentos.Valor = iniFile.ReadInteger("MOTORES", "TEMPO_ENTRE_OPERACOES", 0);
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0], iniFile.ReadInteger("MOTOR1", "MODO_CONTROLE", 0));
								RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Alto.Valor = iniFile.ReadInteger("MOTOR1", "NIVEL_ALTO", 0);
								RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Baixo.Valor = iniFile.ReadInteger("MOTOR1", "NIVEL_BAIXO", 0);
								RT_geral.RT_821_200_BD.cfg_geral.partida.Motor1.Valor = iniFile.ReadInteger("MOTOR1", "TEMPO_PARTIDA", 0);
								RT_geral.RT_821_200_BD.cfg_geral.parada.Motor1.Valor = iniFile.ReadInteger("MOTOR1", "TEMPO_PARADA", 0);
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1], iniFile.ReadInteger("MOTOR2", "MODO_CONTROLE", 0));
								RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Alto.Valor = iniFile.ReadInteger("MOTOR2", "NIVEL_ALTO", 0);
								RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Baixo.Valor = iniFile.ReadInteger("MOTOR2", "NIVEL_BAIXO", 0);
								RT_geral.RT_821_200_BD.cfg_geral.partida.Motor2.Valor = iniFile.ReadInteger("MOTOR2", "TEMPO_PARTIDA", 0);
								RT_geral.RT_821_200_BD.cfg_geral.parada.Motor2.Valor = iniFile.ReadInteger("MOTOR2", "TEMPO_PARADA", 0);
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2], iniFile.ReadInteger("MOTOR3", "MODO_CONTROLE", 0));
								RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Alto.Valor = iniFile.ReadInteger("MOTOR3", "NIVEL_ALTO", 0);
								RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Baixo.Valor = iniFile.ReadInteger("MOTOR3", "NIVEL_BAIXO", 0);
								RT_geral.RT_821_200_BD.cfg_geral.partida.Motor3.Valor = iniFile.ReadInteger("MOTOR3", "TEMPO_PARTIDA", 0);
								RT_geral.RT_821_200_BD.cfg_geral.parada.Motor3.Valor = iniFile.ReadInteger("MOTOR3", "TEMPO_PARADA", 0);
								RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.Valor = iniFile.ReadInteger("REPETIDORA", "MODO_REPETIDORA", 0);
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora, RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.Valor);
								RT_geral.RT_821_200_BD.repetidora.End_repetidora.Valor = iniFile.ReadInteger("REPETIDORA", "ENDERECO", 0);
								RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.Valor = iniFile.ReadInteger("REPETIDORA", "NUMERO_REPETIDORAS", 0);
								num2 = 0;
								do
								{
									string key = string.Format("RPT{0}", num2 + 1);
									RT_geral.RT_821_200_BD.repetidora.Repetidoras[num2].Valor = iniFile.ReadInteger("REPETIDORA", key, 0);
									num2++;
								}
								while (num2 <= 49);
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
					goto IL_9CF;
					IL_96A:
					Interaction.MsgBox("Não foi possível carregar os dados", 32, "Atenção - Erro I/0");
					this.Timer_limpa_MSG_820.Enabled = true;
					goto IL_9CF;
					IL_98A:
					num3 = -1;
										IL_9A0:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num3 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_98A;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_9CF:
				if (num3 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x002C55E0 File Offset: 0x002C39E0
		private void ToolStripButton_RT_820_Salvar_Click(object sender, EventArgs e)
		{
			checked
			{
				int num;
				int num4;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					this.AtivaEfeitoOnChangeValue();
					int[] array = new int[651];
					this.ToolStripButton_RT_820_Abrir.Enabled = false;
					this.ToolStripButton_RT_820_novo.Enabled = false;
					this.ToolStripButton_RT_820_Salvar.Enabled = false;
					this.ToolStripButton_RT_820_Download.Enabled = false;
					this.ToolStripButton_RT_820_Upload.Enabled = false;
					this.SaveFileDialog_RT_820.Filter = "Arquivo de configuração de equipamento|*.Cfg821_200";
					this.SaveFileDialog_RT_820.InitialDirectory = Linha_RT.diretorio;
					if (this.SaveFileDialog_RT_820.ShowDialog() == 1)
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
							RT_geral.RT_821_200_BD.filename = this.SaveFileDialog_RT_820.FileName;
							this.InicializaBarraProgressoTela_RT_820(5);
							iniFileWriteFast.WriteSection("GERAL_INFORMACAO");
							iniFileWriteFast.WriteKey("EQUIPAMENTO", RT_geral.RT_821_200_BD.firmware.Equip.Valor);
							iniFileWriteFast.WriteKey("VERSAO", RT_geral.RT_821_200_BD.firmware.Versao.Valor);
							iniFileWriteFast.WriteKey("BUILD", RT_geral.RT_821_200_BD.firmware.Build.Valor);
							iniFileWriteFast.WriteKey("RELEASE", RT_geral.RT_821_200_BD.firmware.Release.Valor);
							iniFileWriteFast.LineSpace();
							iniFileWriteFast.WriteSection("GERAL_PARAM_COMINICACAO");
							iniFileWriteFast.WriteKey("ESTACAO", RT_geral.RT_821_200_BD.cfg_geral.End_estacao.Valor);
							iniFileWriteFast.WriteKey("MESTRE", RT_geral.RT_821_200_BD.cfg_geral.End_mestre.Valor);
							iniFileWriteFast.WriteKey("TEMPO_PTT", RT_geral.RT_821_200_BD.cfg_geral.Tempo_ptt.Valor);
							iniFileWriteFast.LineSpace();
							iniFileWriteFast.WriteSection("GERAL_DESCRICAO");
							iniFileWriteFast.WriteKey("NOME", this.TextBox_nome_RT820.Text);
							iniFileWriteFast.WriteKey("ENDERECO", this.TextBox_endereco_RT820.Text);
							iniFileWriteFast.WriteKey("COMENTARIO", this.TextBox_comentarios_RT820.Text);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("ENTRADA_DIGITAL");
							int i = 0;
							do
							{
								string key = string.Format("ED{0}", i + 1);
								iniFileWriteFast.WriteKey(key, RT_geral.RT_821_200_BD.cfg_geral.entradas[i].Valor);
								i++;
							}
							while (i <= 7);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("MOTORES");
							iniFileWriteFast.WriteKey("NUMERO_MOTORES", RT_geral.RT_821_200_BD.cfg_geral.quantidade_motores.Valor);
							iniFileWriteFast.WriteKey("MOTORES_SIMULTANEOS", RT_geral.RT_821_200_BD.cfg_geral.motores_simultaneos.Valor);
							iniFileWriteFast.WriteKey("TEMPO_ENTRE_OPERACOES", RT_geral.RT_821_200_BD.cfg_geral.tempo_acionamentos.Valor);
							iniFileWriteFast.LineSpace();
							iniFileWriteFast.WriteSection("MOTOR1");
							iniFileWriteFast.WriteKey("MODO_CONTROLE", RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].Valor);
							iniFileWriteFast.WriteKey("NIVEL_ALTO", RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Alto.Valor);
							iniFileWriteFast.WriteKey("NIVEL_BAIXO", RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Baixo.Valor);
							iniFileWriteFast.WriteKey("TEMPO_PARTIDA", RT_geral.RT_821_200_BD.cfg_geral.partida.Motor1.Valor);
							iniFileWriteFast.WriteKey("TEMPO_PARADA", RT_geral.RT_821_200_BD.cfg_geral.parada.Motor1.Valor);
							iniFileWriteFast.LineSpace();
							iniFileWriteFast.WriteSection("MOTOR2");
							iniFileWriteFast.WriteKey("MODO_CONTROLE", RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].Valor);
							iniFileWriteFast.WriteKey("NIVEL_ALTO", RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Alto.Valor);
							iniFileWriteFast.WriteKey("NIVEL_BAIXO", RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Baixo.Valor);
							iniFileWriteFast.WriteKey("TEMPO_PARTIDA", RT_geral.RT_821_200_BD.cfg_geral.partida.Motor2.Valor);
							iniFileWriteFast.WriteKey("TEMPO_PARADA", RT_geral.RT_821_200_BD.cfg_geral.parada.Motor2.Valor);
							iniFileWriteFast.LineSpace();
							iniFileWriteFast.WriteSection("MOTOR3");
							iniFileWriteFast.WriteKey("MODO_CONTROLE", RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].Valor);
							iniFileWriteFast.WriteKey("NIVEL_ALTO", RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Alto.Valor);
							iniFileWriteFast.WriteKey("NIVEL_BAIXO", RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Baixo.Valor);
							iniFileWriteFast.WriteKey("TEMPO_PARTIDA", RT_geral.RT_821_200_BD.cfg_geral.partida.Motor3.Valor);
							iniFileWriteFast.WriteKey("TEMPO_PARADA", RT_geral.RT_821_200_BD.cfg_geral.parada.Motor3.Valor);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("REPETIDORA");
							iniFileWriteFast.WriteKey("MODO_REPETIDORA", RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.Valor);
							iniFileWriteFast.WriteKey("ENDERECO", RT_geral.RT_821_200_BD.repetidora.End_repetidora.Valor);
							iniFileWriteFast.WriteKey("NUMERO_REPETIDORAS", RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.Valor);
							int num2 = 0;
							int num3 = RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.Valor - 1;
							for (i = num2; i <= num3; i++)
							{
								string key = string.Format("RPT{0}", i + 1);
								iniFileWriteFast.WriteKey(key, RT_geral.RT_821_200_BD.repetidora.Repetidoras[i].Valor);
							}
							iniFileWriteFast.LineSpace();
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
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.CloseIniFileWriteFast();
							this.AtualizaMsgTela_RT_820("Arquivo gerado com sucesso!", 0);
							this.Timer_limpa_MSG_820.Enabled = true;
						}
					}
					else
					{
						this.AtualizaMsgTela_RT_820("Operação Cancelada", 0);
						this.Timer_limpa_MSG_820.Enabled = true;
					}
					goto IL_8B7;
					IL_852:
					Interaction.MsgBox("Não foi possível gravar os dados", 32, "Atenção - Erro I/0");
					this.Timer_limpa_MSG_820.Enabled = true;
					goto IL_8B7;
					IL_872:
					num4 = -1;
										IL_888:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_872;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_8B7:
				if (num4 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x002C5ECC File Offset: 0x002C42CC
		private void ToolStripButton_RT_820_Upload_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.Bloqueia_acoes_RT821();
				this.EncerraEdicaoDeCampos_RT820();
				this.Escrita_RT820_conf();
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", 16, "Atenção");
			}
			this.Libera_acoes_RT821();
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x002C5F08 File Offset: 0x002C4308
		private void ToolStripButton_RT_820_novo_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			this.Bloqueia_acoes_RT821();
			this.Inicializa_DadosEStruturaRT820_Default();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			RT_geral.RT_821_200_BD.filename = "";
			this.Atualiza_TelaRT820();
			this.AtualizaMsgTela_RT_820("Arquivo gerado com sucesso!", 0);
			this.Timer_limpa_MSG_820.Enabled = true;
			this.Libera_acoes_RT821();
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x002C5F6C File Offset: 0x002C436C
		private void ToolStripButton_RT_820_Download_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.Bloqueia_acoes_RT821();
				this.EncerraEdicaoDeCampos_RT820();
				this.Leitura_RT_820_200_conf();
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", 16, "Atenção");
			}
			this.Libera_acoes_RT821();
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x002C5FA8 File Offset: 0x002C43A8
		public void Leitura_RT_820_conf()
		{
			this.InicializaBarraProgressoTela_RT_820(8);
			this.AtualizaMsgTela_RT_820("Identificação de equipamento - Etapa 1", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(0, 255, 4).Status)
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
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 2", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(2048, 255, 113).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(2048);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 3", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(2161, 255, 94).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(2161);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 4", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(4096, RT_geral.RT_820_BD.End_estacao.Valor, 52).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(4096);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Passo 5", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(8192, RT_geral.RT_820_BD.End_estacao.Valor, 16).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(8192);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Passo 6", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(10240, RT_geral.RT_820_BD.End_estacao.Valor, 16).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(10240);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Passo 7", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(12288, RT_geral.RT_820_BD.End_estacao.Valor, 16).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(12288);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Passo 8", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(30720, RT_geral.RT_820_BD.End_estacao.Valor, 96).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(30720);
			this.Atualiza_TelaRT820();
			this.AtualizaMsgTela_RT_820("Configuração lida com sucesso", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			this.Timer_limpa_MSG_820.Enabled = true;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x002C62F0 File Offset: 0x002C46F0
		public void Leitura_RT_820_200_conf()
		{
			this.InicializaBarraProgressoTela_RT_820(3);
			this.AtualizaMsgTela_RT_820("Identificação de equipamento - Etapa 1", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(0, 255, 4).Status)
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
			Linha_RT.Atualiza_dados_RT_821_200(0);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 2", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(256, 255, 30).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_821_200(256);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 3", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(512, RT_geral.RT_821_200_BD.cfg_geral.End_estacao.Valor, 52).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_821_200(512);
			this.ToolStripProgressBar_RT_820.PerformStep();
			this.Atualiza_TelaRT820();
			this.AtualizaMsgTela_RT_820("Configuração lida com sucesso", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			this.Timer_limpa_MSG_820.Enabled = true;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x002C6478 File Offset: 0x002C4878
		public void Escrita_RT820_conf()
		{
			this.InicializaBarraProgressoTela_RT_820(5);
			this.AtualizaMsgTela_RT_820("Verificando equipamento - Passo 1", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(0, 255, 4).Status)
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
			Linha_RT.Atualiza_dados_RT_821_200(0);
			this.AtualizaMsgTela_RT_820("Habilitando gravação - Passo 2", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Controle_escrita(21845).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro ao habilitar gravação", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Gravando configuração - Passo 3", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Escrita_pagina(256, 40).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			if (!Mod_MD.Controle_escrita(21930).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro durante a gravação", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Gravando configuração - Passo 4", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Controle_escrita(21845).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro ao habilitar gravação", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			if (!Mod_MD.Escrita_pagina(512, 40).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			if (!Mod_MD.Controle_escrita(21930).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro durante a gravação", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Programação executada com sucesso", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x002C6680 File Offset: 0x002C4A80
		public void Bloqueia_acoes_RT821()
		{
			this.ToolStripButton_RT_820_Abrir.Enabled = false;
			this.ToolStripButton_RT_820_Download.Enabled = false;
			this.ToolStripButton_RT_820_novo.Enabled = false;
			this.ToolStripButton_RT_820_Salvar.Enabled = false;
			this.ToolStripButton_RT_820_Upload.Enabled = false;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x002C66C0 File Offset: 0x002C4AC0
		public void Libera_acoes_RT821()
		{
			this.ToolStripButton_RT_820_Abrir.Enabled = true;
			this.ToolStripButton_RT_820_Download.Enabled = true;
			this.ToolStripButton_RT_820_novo.Enabled = true;
			this.ToolStripButton_RT_820_Salvar.Enabled = true;
			this.ToolStripButton_RT_820_Upload.Enabled = true;
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x002C6700 File Offset: 0x002C4B00
		public void EncerraEdicaoDeCampos_RT820()
		{
			this.DataGridView_end_rep_RT820.EndEdit();
			this.DataGridView_RT820_ED.EndEdit();
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x002C671C File Offset: 0x002C4B1C
		private void ToolStripButton_RT820_Imprimir_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			using (EnhancedPrintPreviewDialog enhancedPrintPreviewDialog = new EnhancedPrintPreviewDialog())
			{
				enhancedPrintPreviewDialog.Document = this.PrintDocument1;
				enhancedPrintPreviewDialog.ShowDialog();
			}
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x002C6764 File Offset: 0x002C4B64
		[MethodImpl(72)]
		private void DesenhaRelatorioRT820Pagina1(PrintPageEventArgs z)
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_821_200_BD.firmware.Equip.Valor, RT_geral.RT_821_200_BD.firmware.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 4, "Dados da Estação", true);
			tabelaLinhaInteria.EscreveTituloValorLinha(1, "Local de Instalação", this.TextBox_nome_RT820.Text, 0, 160);
			tabelaLinhaInteria.EscreveTituloValorLinha(2, "Endereço", this.TextBox_endereco_RT820.Text, 0, 90);
			string valor = "iS800 (" + MyProject.Application.Info.Version.ToString() + ")";
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Configurador", valor, 0, 160);
			string valor2 = string.Concat(new string[]
			{
				"RT",
				RT_geral.RT_821_200_BD.firmware.Equip.Valor.ToString(),
				"_",
				RT_geral.RT_821_200_BD.firmware.Versao.Valor.ToString(),
				string.Format("{0:D2}", RT_geral.RT_821_200_BD.firmware.Build.Valor),
				"  R",
				RT_geral.RT_821_200_BD.firmware.Release.Valor.ToString()
			});
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Firmware", valor2, 350, 430);
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Data", string.Concat(new string[]
			{
				DateTime.Today.Day.ToString(),
				"/",
				DateTime.Today.Month.ToString(),
				"/",
				DateTime.Today.Year.ToString()
			}), 850, 0);
			tabelaLinhaInteria.EscreveTituloValorLinha(4, "Arquivo", Path.GetFileName(RT_geral.RT_821_200_BD.filename), 0, 0);
			int nextLineAvailable = tabelaLinhaInteria.GetNextLineAvailable();
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 6, "Dados de Instalação", true);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(1, "Tipo de antena", this.CB_TipoAntena.Text, 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(1, "Azimute", this.T_Azimute.Text + " °", 280, 500);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(2, "Polarização", this.CB_PolarizacaoAntena.Text, 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(2, "Longitude", this.T_Longitude.Text, 280, 500);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(3, "Potência do Rádio", this.T_PotRadio.Text + " W", 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(3, "Latidude", this.T_Latitude.Text, 280, 500);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(4, "Modelo do Rádio", this.CB_ModeloRadio.Text, 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(4, "Altura", this.T_AlturaAntena.Text + " m", 280, 500);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(5, "Distância para Central", this.T_DistCentral.Text + " km", 0, 150);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(5, "Modelo da Fonte", this.T_ModeloFonte.Text, 280, 520);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(6, "Frequência do Rádio", this.T_FreqRadio.Text + " MHz", 0, 150);
			nextLineAvailable = tabelaMeiaLinhaEsquerda.GetNextLineAvailable();
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria.GetNextLineAvailable(), 3, "Parâmetro de Comunicação", true);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(1, "Endereço do Mestre", this.NumericUpDown_end_mestre_820.Value.ToString(), 0, 200);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(2, "Endereço da Estação", this.NumericUpDown_end_est_820.Value.ToString(), 0, 200);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(3, "Tempo de PTT (ms)", this.NumericUpDown_temp_ptt_820.Value.ToString() + " ms", 0, 200);
			nextLineAvailable = tabelaMeiaLinhaDireita.GetNextLineAvailable();
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita2 = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaDireita.GetNextLineAvailable(), 3, "Controles", true);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(1, "Número de Motores", RT_geral.RT_821_200_BD.cfg_geral.quantidade_motores.Valor.ToString(), 0, 200);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(2, "Numero Motores Simultâneos", RT_geral.RT_821_200_BD.cfg_geral.motores_simultaneos.Valor.ToString(), 0, 200);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(3, "Tempo entre operações (s)", RT_geral.RT_821_200_BD.cfg_geral.tempo_acionamentos.Valor.ToString() + " s", 0, 200);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita3 = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaDireita2.GetNextLineAvailable(), 4, "Setpoint", true);
			tabelaMeiaLinhaDireita3.EscreveTituloLinha(1, "Motor", 0);
			tabelaMeiaLinhaDireita3.EscreveTituloLinha(1, "Modo Controle", 50);
			tabelaMeiaLinhaDireita3.EscreveTituloLinha(1, "N. Alto", 160);
			tabelaMeiaLinhaDireita3.EscreveTituloLinha(1, "N. Baixo ", 220);
			tabelaMeiaLinhaDireita3.EscreveTituloLinha(1, "T. Partida", 300);
			tabelaMeiaLinhaDireita3.EscreveTituloLinha(1, "T. Parada", 390);
			int i = 0;
			checked
			{
				do
				{
					tabelaMeiaLinhaDireita3.EscreveValorLinha(i + 2, "M" + Conversion.Str(i + 1), 5);
					i++;
				}
				while (i <= 2);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(2, this.cb_modo_partida1.Text, 55);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(2, this.nud_na_m1.Value.ToString(), 165);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(2, this.nud_nb_m1.Value.ToString(), 225);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(2, this.nud_partida1.Value.ToString(), 305);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(2, this.nud_parada1.Value.ToString(), 395);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(3, this.cb_modo_partida2.Text, 55);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(3, this.nud_na_m2.Value.ToString(), 165);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(3, this.nud_nb_m2.Value.ToString(), 225);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(3, this.nud_partida2.Value.ToString(), 305);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(3, this.nud_parada2.Value.ToString(), 395);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(4, this.cb_modo_partida3.Text, 55);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(4, this.nud_na_m3.Value.ToString(), 165);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(4, this.nud_nb_m3.Value.ToString(), 225);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(4, this.nud_partida3.Value.ToString(), 305);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(4, this.nud_parada3.Value.ToString(), 395);
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda.GetNextLineAvailable(), 9, "Entrada Digital", true);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "ED", 0);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "Função", 90);
				i = 0;
				do
				{
					string valor3 = string.Format("ED 0{0}", i + 1);
					tabelaMeiaLinhaEsquerda2.EscreveValorLinha(i + 2, valor3, 0);
					valor3 = this.DataGridView_RT820_ED.Rows[i].Cells[0].Value.ToString();
					tabelaMeiaLinhaEsquerda2.EscreveValorLinha(i + 2, valor3, 90);
					i++;
				}
				while (i <= 7);
				TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda2.GetNextLineAvailable(), 1, "Repetidora", true);
				tabelaLinhaInteria2.EscreveTituloValorLinha(1, "Modo", this.cb_ModoRepetidora.Text, 0, 60);
				tabelaLinhaInteria2.EscreveTituloValorLinha(1, "End. Mestre", RT_geral.RT_821_200_BD.repetidora.End_repetidora.Valor.ToString(), 240, 320);
				tabelaLinhaInteria2.EscreveTituloValorLinha(1, "Quantidade End. Repetidos", RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.Valor.ToString(), 410, 600);
				int num = RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.Valor / 20;
				if (RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.Valor > 0)
				{
					if (RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.Valor % 20 != 0)
					{
						num++;
					}
					int num2 = 1;
					int num3 = num;
					for (i = num2; i <= num3; i++)
					{
						tabelaLinhaInteria2.AdicionaLinha();
						string text = "";
						int num4 = (i - 1) * 20;
						int num5 = (i - 1) * 20 + 19;
						for (int j = num4; j <= num5; j++)
						{
							if (j + 1 < RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.Valor)
							{
								text = text + RT_geral.RT_821_200_BD.repetidora.Repetidoras[j].Valor.ToString() + ", ";
							}
							else if (j + 1 == RT_geral.RT_821_200_BD.repetidora.Num_repetidoras.Valor)
							{
								text += RT_geral.RT_821_200_BD.repetidora.Repetidoras[j].Valor.ToString();
								break;
							}
						}
						tabelaLinhaInteria2.EscreveValorLinha(i + 1, text, 50);
					}
				}
				TabelaLinhaInteria tabelaLinhaInteria3 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria2.GetNextLineAvailable(), 3, "Comentários", true);
				tabelaLinhaInteria3.EscreveValorLinha(1, this.TextBox_comentarios_RT820.Text, 0);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x002C72F0 File Offset: 0x002C56F0
		private bool DesenhaRelatorio(PrintPageEventArgs z)
		{
			checked
			{
				switch (this.pagina_impressao)
				{
				case 1:
					this.DesenhaRelatorioRT820Pagina1(z);
					this.pagina_impressao++;
					return false;
				case 2:
					this.pagina_impressao++;
					return false;
				case 3:
					return false;
				default:
					return false;
				}
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x002C7344 File Offset: 0x002C5744
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.HasMorePages = this.DesenhaRelatorio(e);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x002C7354 File Offset: 0x002C5754
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

		// Token: 0x060009A5 RID: 2469 RVA: 0x002C73A4 File Offset: 0x002C57A4
		private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
		{
			this.pagina_impressao = 1;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x002C73B0 File Offset: 0x002C57B0
		private void cb_ModoRepetidora_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (this.cb_ModoRepetidora.SelectedIndex)
			{
			case 0:
				this.NumericUpDown_end_rep_820.Enabled = false;
				this.NumericUpDown_num_est_rep_820.Enabled = false;
				this.GroupBox_end_rep_820.Visible = false;
				break;
			case 1:
			case 2:
				this.NumericUpDown_end_rep_820.Enabled = true;
				this.NumericUpDown_num_est_rep_820.Enabled = true;
				this.GroupBox_end_rep_820.Visible = true;
				break;
			}
			RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.Valor = RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.valores[this.cb_ModoRepetidora.SelectedIndex];
			RT_geral.RT_821_200_BD.cfg_geral.modo_repetidora.Indice = this.cb_ModoRepetidora.SelectedIndex;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x002C7478 File Offset: 0x002C5878
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x002C747C File Offset: 0x002C587C
		private void nud_numero_motores_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.quantidade_motores.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.quantidade_motores, true);
			sender = numericUpDown;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x002C74DC File Offset: 0x002C58DC
		private void nud_motores_simultaneos_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.motores_simultaneos.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.motores_simultaneos, true);
			sender = numericUpDown;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x002C753C File Offset: 0x002C593C
		private void nud_tempo_operacoes_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.tempo_acionamentos.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.tempo_acionamentos, true);
			sender = numericUpDown;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x002C759C File Offset: 0x002C599C
		private void nud_na_m1_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Alto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Alto, true);
			sender = numericUpDown;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x002C7604 File Offset: 0x002C5A04
		private void nud_na_m2_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Alto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Alto, true);
			sender = numericUpDown;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x002C766C File Offset: 0x002C5A6C
		private void nud_na_m3_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Alto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Alto, true);
			sender = numericUpDown;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x002C76D4 File Offset: 0x002C5AD4
		private void nud_nb_m1_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Baixo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.setpoints.M1_Baixo, true);
			sender = numericUpDown;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x002C773C File Offset: 0x002C5B3C
		private void nud_nb_m2_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Baixo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.setpoints.M2_Baixo, true);
			sender = numericUpDown;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x002C77A4 File Offset: 0x002C5BA4
		private void nud_nb_m3_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Baixo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.setpoints.M3_Baixo, true);
			sender = numericUpDown;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x002C780C File Offset: 0x002C5C0C
		private void nud_partida1_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.partida.Motor1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.partida.Motor1, true);
			sender = numericUpDown;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x002C7874 File Offset: 0x002C5C74
		private void nud_partida2_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.partida.Motor2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.partida.Motor2, true);
			sender = numericUpDown;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x002C78DC File Offset: 0x002C5CDC
		private void nud_partida3_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.partida.Motor3.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.partida.Motor3, true);
			sender = numericUpDown;
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x002C7944 File Offset: 0x002C5D44
		private void nud_parada1_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.parada.Motor1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.parada.Motor1, true);
			sender = numericUpDown;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x002C79AC File Offset: 0x002C5DAC
		private void nud_parada2_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.parada.Motor2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.parada.Motor2, true);
			sender = numericUpDown;
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x002C7A14 File Offset: 0x002C5E14
		private void nud_parada3_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.parada.Motor3.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_821_200_BD.cfg_geral.parada.Motor3, true);
			sender = numericUpDown;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x002C7A7C File Offset: 0x002C5E7C
		private void cb_modo_partida1_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].Valor = RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].valores[this.cb_modo_partida1.SelectedIndex];
			RT_geral.RT_821_200_BD.cfg_geral.modo_partida[0].Indice = this.cb_modo_partida1.SelectedIndex;
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x002C7AF0 File Offset: 0x002C5EF0
		private void cb_modo_partida2_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].Valor = RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].valores[this.cb_modo_partida2.SelectedIndex];
			RT_geral.RT_821_200_BD.cfg_geral.modo_partida[1].Indice = this.cb_modo_partida2.SelectedIndex;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x002C7B64 File Offset: 0x002C5F64
		private void cb_modo_partida3_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].Valor = RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].valores[this.cb_modo_partida3.SelectedIndex];
			RT_geral.RT_821_200_BD.cfg_geral.modo_partida[2].Indice = this.cb_modo_partida3.SelectedIndex;
		}

		// Token: 0x04000610 RID: 1552
		[AccessedThroughProperty("GroupBox_sistema_leitura")]
		private GroupBox _GroupBox_sistema_leitura;

		// Token: 0x04000611 RID: 1553
		[AccessedThroughProperty("CheckBox_hab_eletrodos")]
		private CheckBox _CheckBox_hab_eletrodos;

		// Token: 0x04000612 RID: 1554
		[AccessedThroughProperty("GroupBox_operacao")]
		private GroupBox _GroupBox_operacao;

		// Token: 0x04000613 RID: 1555
		[AccessedThroughProperty("ComboBox_metodo_operacao")]
		private ComboBox _ComboBox_metodo_operacao;

		// Token: 0x04000614 RID: 1556
		[AccessedThroughProperty("NumericUpDown_intervalo_tx")]
		private NumericUpDown _NumericUpDown_intervalo_tx;

		// Token: 0x04000615 RID: 1557
		[AccessedThroughProperty("Label_metodo_operacao")]
		private Label _Label_metodo_operacao;

		// Token: 0x04000616 RID: 1558
		[AccessedThroughProperty("Label_intevalo_tx_pto_pto")]
		private Label _Label_intevalo_tx_pto_pto;

		// Token: 0x04000617 RID: 1559
		[AccessedThroughProperty("GroupBox_informacoes")]
		private GroupBox _GroupBox_informacoes;

		// Token: 0x04000618 RID: 1560
		[AccessedThroughProperty("TextBox_equipamento")]
		private TextBox _TextBox_equipamento;

		// Token: 0x04000619 RID: 1561
		[AccessedThroughProperty("Label_equipamento")]
		private Label _Label_equipamento;

		// Token: 0x0400061A RID: 1562
		[AccessedThroughProperty("TextBox_release")]
		private TextBox _TextBox_release;

		// Token: 0x0400061B RID: 1563
		[AccessedThroughProperty("Label_release")]
		private Label _Label_release;

		// Token: 0x0400061C RID: 1564
		[AccessedThroughProperty("TextBox_build")]
		private TextBox _TextBox_build;

		// Token: 0x0400061D RID: 1565
		[AccessedThroughProperty("Label_build")]
		private Label _Label_build;

		// Token: 0x0400061E RID: 1566
		[AccessedThroughProperty("TextBox_versao")]
		private TextBox _TextBox_versao;

		// Token: 0x0400061F RID: 1567
		[AccessedThroughProperty("Label_versao")]
		private Label _Label_versao;

		// Token: 0x04000620 RID: 1568
		[AccessedThroughProperty("GroupBox_modelo_simulado")]
		private GroupBox _GroupBox_modelo_simulado;

		// Token: 0x04000621 RID: 1569
		[AccessedThroughProperty("ComboBox_modo_simulado")]
		private ComboBox _ComboBox_modo_simulado;

		// Token: 0x04000622 RID: 1570
		[AccessedThroughProperty("GroupBox_comunicacao")]
		private GroupBox _GroupBox_comunicacao;

		// Token: 0x04000623 RID: 1571
		[AccessedThroughProperty("NumericUpDown_temp_ptt")]
		private NumericUpDown _NumericUpDown_temp_ptt;

		// Token: 0x04000624 RID: 1572
		[AccessedThroughProperty("NumericUpDown_end_mestre")]
		private NumericUpDown _NumericUpDown_end_mestre;

		// Token: 0x04000625 RID: 1573
		[AccessedThroughProperty("NumericUpDown_end_est")]
		private NumericUpDown _NumericUpDown_end_est;

		// Token: 0x04000626 RID: 1574
		[AccessedThroughProperty("Label_tempo_ptt")]
		private Label _Label_tempo_ptt;

		// Token: 0x04000627 RID: 1575
		[AccessedThroughProperty("Label_end_mestre")]
		private Label _Label_end_mestre;

		// Token: 0x04000628 RID: 1576
		[AccessedThroughProperty("Label_end_est")]
		private Label _Label_end_est;

		// Token: 0x04000629 RID: 1577
		[AccessedThroughProperty("OpenFileDialog_RT_820")]
		private OpenFileDialog _OpenFileDialog_RT_820;

		// Token: 0x0400062A RID: 1578
		[AccessedThroughProperty("SaveFileDialog_RT_820")]
		private SaveFileDialog _SaveFileDialog_RT_820;

		// Token: 0x0400062B RID: 1579
		[AccessedThroughProperty("TabControl_820")]
		private TabControl _TabControl_820;

		// Token: 0x0400062C RID: 1580
		[AccessedThroughProperty("TabPage_geral")]
		private TabPage _TabPage_geral;

		// Token: 0x0400062D RID: 1581
		[AccessedThroughProperty("GroupBox_informacoes_820")]
		private GroupBox _GroupBox_informacoes_820;

		// Token: 0x0400062E RID: 1582
		[AccessedThroughProperty("GroupBox_comunicacao_820")]
		private GroupBox _GroupBox_comunicacao_820;

		// Token: 0x0400062F RID: 1583
		[AccessedThroughProperty("NumericUpDown_temp_ptt_820")]
		private NumericUpDown _NumericUpDown_temp_ptt_820;

		// Token: 0x04000630 RID: 1584
		[AccessedThroughProperty("NumericUpDown_end_mestre_820")]
		private NumericUpDown _NumericUpDown_end_mestre_820;

		// Token: 0x04000631 RID: 1585
		[AccessedThroughProperty("NumericUpDown_end_est_820")]
		private NumericUpDown _NumericUpDown_end_est_820;

		// Token: 0x04000632 RID: 1586
		[AccessedThroughProperty("Label_tempo_ptt_820")]
		private Label _Label_tempo_ptt_820;

		// Token: 0x04000633 RID: 1587
		[AccessedThroughProperty("Label_end_mestre_820")]
		private Label _Label_end_mestre_820;

		// Token: 0x04000634 RID: 1588
		[AccessedThroughProperty("Label_end_est_820")]
		private Label _Label_end_est_820;

		// Token: 0x04000635 RID: 1589
		[AccessedThroughProperty("TabPage_ED")]
		private TabPage _TabPage_ED;

		// Token: 0x04000636 RID: 1590
		[AccessedThroughProperty("TabPage_repetidora")]
		private TabPage _TabPage_repetidora;

		// Token: 0x04000637 RID: 1591
		[AccessedThroughProperty("GroupBox_end_rep_820")]
		private GroupBox _GroupBox_end_rep_820;

		// Token: 0x04000638 RID: 1592
		[AccessedThroughProperty("DataGridView_end_rep_RT820")]
		private DataGridView _DataGridView_end_rep_RT820;

		// Token: 0x04000639 RID: 1593
		[AccessedThroughProperty("GroupBox_parametros_repetidora_820")]
		private GroupBox _GroupBox_parametros_repetidora_820;

		// Token: 0x0400063A RID: 1594
		[AccessedThroughProperty("NumericUpDown_num_est_rep_820")]
		private NumericUpDown _NumericUpDown_num_est_rep_820;

		// Token: 0x0400063B RID: 1595
		[AccessedThroughProperty("NumericUpDown_end_rep_820")]
		private NumericUpDown _NumericUpDown_end_rep_820;

		// Token: 0x0400063C RID: 1596
		[AccessedThroughProperty("Label_num_est_rep_820")]
		private Label _Label_num_est_rep_820;

		// Token: 0x0400063D RID: 1597
		[AccessedThroughProperty("Label_end_rep_820")]
		private Label _Label_end_rep_820;

		// Token: 0x0400063E RID: 1598
		[AccessedThroughProperty("ToolStri_RT_820")]
		private ToolStrip _ToolStri_RT_820;

		// Token: 0x0400063F RID: 1599
		[AccessedThroughProperty("ToolStripButton_RT_820_novo")]
		private ToolStripButton _ToolStripButton_RT_820_novo;

		// Token: 0x04000640 RID: 1600
		[AccessedThroughProperty("ToolStripButton_RT_820_Abrir")]
		private ToolStripButton _ToolStripButton_RT_820_Abrir;

		// Token: 0x04000641 RID: 1601
		[AccessedThroughProperty("ToolStripButton_RT_820_Salvar")]
		private ToolStripButton _ToolStripButton_RT_820_Salvar;

		// Token: 0x04000642 RID: 1602
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x04000643 RID: 1603
		[AccessedThroughProperty("ToolStripButton_RT_820_Download")]
		private ToolStripButton _ToolStripButton_RT_820_Download;

		// Token: 0x04000644 RID: 1604
		[AccessedThroughProperty("ToolStripButton_RT_820_Upload")]
		private ToolStripButton _ToolStripButton_RT_820_Upload;

		// Token: 0x04000645 RID: 1605
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x04000646 RID: 1606
		[AccessedThroughProperty("ToolStripTextBox_RT_820_Msg")]
		private ToolStripTextBox _ToolStripTextBox_RT_820_Msg;

		// Token: 0x04000647 RID: 1607
		[AccessedThroughProperty("ToolStripProgressBar_RT_820")]
		private ToolStripProgressBar _ToolStripProgressBar_RT_820;

		// Token: 0x04000648 RID: 1608
		[AccessedThroughProperty("Timer_limpa_MSG_820")]
		private Timer _Timer_limpa_MSG_820;

		// Token: 0x04000649 RID: 1609
		[AccessedThroughProperty("GroupBox_descricao_RT820")]
		private GroupBox _GroupBox_descricao_RT820;

		// Token: 0x0400064A RID: 1610
		[AccessedThroughProperty("TextBox_comentarios_RT820")]
		private TextBox _TextBox_comentarios_RT820;

		// Token: 0x0400064B RID: 1611
		[AccessedThroughProperty("TextBox_endereco_RT820")]
		private TextBox _TextBox_endereco_RT820;

		// Token: 0x0400064C RID: 1612
		[AccessedThroughProperty("TextBox_nome_RT820")]
		private TextBox _TextBox_nome_RT820;

		// Token: 0x0400064D RID: 1613
		[AccessedThroughProperty("Label_comentarios")]
		private Label _Label_comentarios;

		// Token: 0x0400064E RID: 1614
		[AccessedThroughProperty("Label_endereco")]
		private Label _Label_endereco;

		// Token: 0x0400064F RID: 1615
		[AccessedThroughProperty("Label_nome")]
		private Label _Label_nome;

		// Token: 0x04000650 RID: 1616
		[AccessedThroughProperty("GroupBox_ED_820")]
		private GroupBox _GroupBox_ED_820;

		// Token: 0x04000651 RID: 1617
		[AccessedThroughProperty("DataGridView_RT820_ED")]
		private DataGridView _DataGridView_RT820_ED;

		// Token: 0x04000652 RID: 1618
		[AccessedThroughProperty("ToolStripButton_RT820_Imprimir")]
		private ToolStripButton _ToolStripButton_RT820_Imprimir;

		// Token: 0x04000653 RID: 1619
		[AccessedThroughProperty("PrintDocument1")]
		private PrintDocument _PrintDocument1;

		// Token: 0x04000654 RID: 1620
		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		// Token: 0x04000655 RID: 1621
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000656 RID: 1622
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x04000657 RID: 1623
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x04000658 RID: 1624
		[AccessedThroughProperty("T_ModeloFonte")]
		private TextBox _T_ModeloFonte;

		// Token: 0x04000659 RID: 1625
		[AccessedThroughProperty("T_AlturaAntena")]
		private TextBox _T_AlturaAntena;

		// Token: 0x0400065A RID: 1626
		[AccessedThroughProperty("T_Latitude")]
		private TextBox _T_Latitude;

		// Token: 0x0400065B RID: 1627
		[AccessedThroughProperty("T_Longitude")]
		private TextBox _T_Longitude;

		// Token: 0x0400065C RID: 1628
		[AccessedThroughProperty("T_Azimute")]
		private TextBox _T_Azimute;

		// Token: 0x0400065D RID: 1629
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x0400065E RID: 1630
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x0400065F RID: 1631
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000660 RID: 1632
		[AccessedThroughProperty("T_FreqRadio")]
		private TextBox _T_FreqRadio;

		// Token: 0x04000661 RID: 1633
		[AccessedThroughProperty("T_DistCentral")]
		private TextBox _T_DistCentral;

		// Token: 0x04000662 RID: 1634
		[AccessedThroughProperty("T_PotRadio")]
		private TextBox _T_PotRadio;

		// Token: 0x04000663 RID: 1635
		[AccessedThroughProperty("CB_ModeloRadio")]
		private ComboBox _CB_ModeloRadio;

		// Token: 0x04000664 RID: 1636
		[AccessedThroughProperty("CB_PolarizacaoAntena")]
		private ComboBox _CB_PolarizacaoAntena;

		// Token: 0x04000665 RID: 1637
		[AccessedThroughProperty("CB_TipoAntena")]
		private ComboBox _CB_TipoAntena;

		// Token: 0x04000666 RID: 1638
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000667 RID: 1639
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000668 RID: 1640
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000669 RID: 1641
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x0400066A RID: 1642
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x0400066B RID: 1643
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400066C RID: 1644
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x0400066D RID: 1645
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x0400066E RID: 1646
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400066F RID: 1647
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000670 RID: 1648
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x04000671 RID: 1649
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x04000672 RID: 1650
		[AccessedThroughProperty("PrintPreviewDialog1")]
		private PrintPreviewDialog _PrintPreviewDialog1;

		// Token: 0x04000673 RID: 1651
		[AccessedThroughProperty("Label29")]
		private Label _Label29;

		// Token: 0x04000674 RID: 1652
		[AccessedThroughProperty("cb_ModoRepetidora")]
		private ComboBox _cb_ModoRepetidora;

		// Token: 0x04000675 RID: 1653
		[AccessedThroughProperty("TabPage_MotoresValvulas")]
		private TabPage _TabPage_MotoresValvulas;

		// Token: 0x04000676 RID: 1654
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		// Token: 0x04000677 RID: 1655
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x04000678 RID: 1656
		[AccessedThroughProperty("Label47")]
		private Label _Label47;

		// Token: 0x04000679 RID: 1657
		[AccessedThroughProperty("Label46")]
		private Label _Label46;

		// Token: 0x0400067A RID: 1658
		[AccessedThroughProperty("Label45")]
		private Label _Label45;

		// Token: 0x0400067B RID: 1659
		[AccessedThroughProperty("Label43")]
		private Label _Label43;

		// Token: 0x0400067C RID: 1660
		[AccessedThroughProperty("Label42")]
		private Label _Label42;

		// Token: 0x0400067D RID: 1661
		[AccessedThroughProperty("Label41")]
		private Label _Label41;

		// Token: 0x0400067E RID: 1662
		[AccessedThroughProperty("Label34")]
		private Label _Label34;

		// Token: 0x0400067F RID: 1663
		[AccessedThroughProperty("Label33")]
		private Label _Label33;

		// Token: 0x04000680 RID: 1664
		[AccessedThroughProperty("Label31")]
		private Label _Label31;

		// Token: 0x04000681 RID: 1665
		[AccessedThroughProperty("nud_motores_simultaneos")]
		private NumericUpDown _nud_motores_simultaneos;

		// Token: 0x04000682 RID: 1666
		[AccessedThroughProperty("nud_numero_motores")]
		private NumericUpDown _nud_numero_motores;

		// Token: 0x04000683 RID: 1667
		[AccessedThroughProperty("nud_tempo_operacoes")]
		private NumericUpDown _nud_tempo_operacoes;

		// Token: 0x04000684 RID: 1668
		[AccessedThroughProperty("nud_parada3")]
		private NumericUpDown _nud_parada3;

		// Token: 0x04000685 RID: 1669
		[AccessedThroughProperty("nud_partida3")]
		private NumericUpDown _nud_partida3;

		// Token: 0x04000686 RID: 1670
		[AccessedThroughProperty("nud_parada2")]
		private NumericUpDown _nud_parada2;

		// Token: 0x04000687 RID: 1671
		[AccessedThroughProperty("nud_partida2")]
		private NumericUpDown _nud_partida2;

		// Token: 0x04000688 RID: 1672
		[AccessedThroughProperty("nud_parada1")]
		private NumericUpDown _nud_parada1;

		// Token: 0x04000689 RID: 1673
		[AccessedThroughProperty("nud_partida1")]
		private NumericUpDown _nud_partida1;

		// Token: 0x0400068A RID: 1674
		[AccessedThroughProperty("cb_modo_partida2")]
		private ComboBox _cb_modo_partida2;

		// Token: 0x0400068B RID: 1675
		[AccessedThroughProperty("cb_modo_partida1")]
		private ComboBox _cb_modo_partida1;

		// Token: 0x0400068C RID: 1676
		[AccessedThroughProperty("cb_modo_partida3")]
		private ComboBox _cb_modo_partida3;

		// Token: 0x0400068D RID: 1677
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x0400068E RID: 1678
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400068F RID: 1679
		[AccessedThroughProperty("nud_nb_m1")]
		private NumericUpDown _nud_nb_m1;

		// Token: 0x04000690 RID: 1680
		[AccessedThroughProperty("nud_na_m1")]
		private NumericUpDown _nud_na_m1;

		// Token: 0x04000691 RID: 1681
		[AccessedThroughProperty("nud_nb_m3")]
		private NumericUpDown _nud_nb_m3;

		// Token: 0x04000692 RID: 1682
		[AccessedThroughProperty("nud_na_m3")]
		private NumericUpDown _nud_na_m3;

		// Token: 0x04000693 RID: 1683
		[AccessedThroughProperty("nud_nb_m2")]
		private NumericUpDown _nud_nb_m2;

		// Token: 0x04000694 RID: 1684
		[AccessedThroughProperty("nud_na_m2")]
		private NumericUpDown _nud_na_m2;

		// Token: 0x04000695 RID: 1685
		[AccessedThroughProperty("ToolStripLabel1")]
		private ToolStripLabel _ToolStripLabel1;

		// Token: 0x04000696 RID: 1686
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x04000697 RID: 1687
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		// Token: 0x04000698 RID: 1688
		[AccessedThroughProperty("TextBox_equipamento_820")]
		private TextBox _TextBox_equipamento_820;

		// Token: 0x04000699 RID: 1689
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x0400069A RID: 1690
		[AccessedThroughProperty("TextBox_release_820")]
		private TextBox _TextBox_release_820;

		// Token: 0x0400069B RID: 1691
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x0400069C RID: 1692
		[AccessedThroughProperty("TextBox_build_820")]
		private TextBox _TextBox_build_820;

		// Token: 0x0400069D RID: 1693
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		// Token: 0x0400069E RID: 1694
		[AccessedThroughProperty("TextBox_versao_820")]
		private TextBox _TextBox_versao_820;

		// Token: 0x0400069F RID: 1695
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		// Token: 0x040006A0 RID: 1696
		[AccessedThroughProperty("tb_lixo1")]
		private TextBox _tb_lixo1;

		// Token: 0x040006A1 RID: 1697
		[AccessedThroughProperty("tb_lixo2")]
		private TextBox _tb_lixo2;

		// Token: 0x040006A2 RID: 1698
		[AccessedThroughProperty("tb_lixo3")]
		private TextBox _tb_lixo3;

		// Token: 0x040006A3 RID: 1699
		[AccessedThroughProperty("tb_lixo5")]
		private TextBox _tb_lixo5;

		// Token: 0x040006A4 RID: 1700
		[AccessedThroughProperty("tb_lixo6")]
		private TextBox _tb_lixo6;

		// Token: 0x040006A5 RID: 1701
		private bool bloqueio_IO;

		// Token: 0x040006A6 RID: 1702
		private int pagina_impressao;
	}
}
