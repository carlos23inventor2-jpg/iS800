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

namespace iS800
{
	// Token: 0x02000054 RID: 84
	public partial class RT_820_conf : Form
	{
		// Token: 0x060016BD RID: 5821 RVA: 0x00374C74 File Offset: 0x00373074
		public RT_820_conf()
		{
			base.Load += new EventHandler(this.RT_820_conf_Load);
			base.Activated += new EventHandler(this.RT_820_conf_Activated);
			base.FormClosed += new FormClosedEventHandler(this.RT_820_conf_FormClosed);
			this.InitializeComponent();
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x0037D970 File Offset: 0x0037BD70
		// (set) Token: 0x060016C1 RID: 5825 RVA: 0x0037D984 File Offset: 0x0037BD84
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

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x0037D990 File Offset: 0x0037BD90
		// (set) Token: 0x060016C3 RID: 5827 RVA: 0x0037D9A4 File Offset: 0x0037BDA4
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

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060016C4 RID: 5828 RVA: 0x0037D9B0 File Offset: 0x0037BDB0
		// (set) Token: 0x060016C5 RID: 5829 RVA: 0x0037D9C4 File Offset: 0x0037BDC4
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

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x0037D9D0 File Offset: 0x0037BDD0
		// (set) Token: 0x060016C7 RID: 5831 RVA: 0x0037D9E4 File Offset: 0x0037BDE4
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

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x0037D9F0 File Offset: 0x0037BDF0
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x0037DA04 File Offset: 0x0037BE04
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

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x0037DA10 File Offset: 0x0037BE10
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x0037DA24 File Offset: 0x0037BE24
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

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x0037DA30 File Offset: 0x0037BE30
		// (set) Token: 0x060016CD RID: 5837 RVA: 0x0037DA44 File Offset: 0x0037BE44
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

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x0037DA50 File Offset: 0x0037BE50
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x0037DA64 File Offset: 0x0037BE64
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

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x0037DA70 File Offset: 0x0037BE70
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x0037DA84 File Offset: 0x0037BE84
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

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x0037DA90 File Offset: 0x0037BE90
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x0037DAA4 File Offset: 0x0037BEA4
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

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x0037DAB0 File Offset: 0x0037BEB0
		// (set) Token: 0x060016D5 RID: 5845 RVA: 0x0037DAC4 File Offset: 0x0037BEC4
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

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x0037DAD0 File Offset: 0x0037BED0
		// (set) Token: 0x060016D7 RID: 5847 RVA: 0x0037DAE4 File Offset: 0x0037BEE4
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

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x0037DAF0 File Offset: 0x0037BEF0
		// (set) Token: 0x060016D9 RID: 5849 RVA: 0x0037DB04 File Offset: 0x0037BF04
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

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x0037DB10 File Offset: 0x0037BF10
		// (set) Token: 0x060016DB RID: 5851 RVA: 0x0037DB24 File Offset: 0x0037BF24
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

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x0037DB30 File Offset: 0x0037BF30
		// (set) Token: 0x060016DD RID: 5853 RVA: 0x0037DB44 File Offset: 0x0037BF44
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

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x0037DB50 File Offset: 0x0037BF50
		// (set) Token: 0x060016DF RID: 5855 RVA: 0x0037DB64 File Offset: 0x0037BF64
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

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x0037DB70 File Offset: 0x0037BF70
		// (set) Token: 0x060016E1 RID: 5857 RVA: 0x0037DB84 File Offset: 0x0037BF84
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

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x0037DB90 File Offset: 0x0037BF90
		// (set) Token: 0x060016E3 RID: 5859 RVA: 0x0037DBA4 File Offset: 0x0037BFA4
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

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x0037DBB0 File Offset: 0x0037BFB0
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x0037DBC4 File Offset: 0x0037BFC4
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

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x0037DBD0 File Offset: 0x0037BFD0
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x0037DBE4 File Offset: 0x0037BFE4
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

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x0037DBF0 File Offset: 0x0037BFF0
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x0037DC04 File Offset: 0x0037C004
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

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x0037DC10 File Offset: 0x0037C010
		// (set) Token: 0x060016EB RID: 5867 RVA: 0x0037DC24 File Offset: 0x0037C024
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

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x0037DC30 File Offset: 0x0037C030
		// (set) Token: 0x060016ED RID: 5869 RVA: 0x0037DC44 File Offset: 0x0037C044
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

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x0037DC50 File Offset: 0x0037C050
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x0037DC64 File Offset: 0x0037C064
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

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x0037DC70 File Offset: 0x0037C070
		// (set) Token: 0x060016F1 RID: 5873 RVA: 0x0037DC84 File Offset: 0x0037C084
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

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x0037DC90 File Offset: 0x0037C090
		// (set) Token: 0x060016F3 RID: 5875 RVA: 0x0037DCA4 File Offset: 0x0037C0A4
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

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x0037DCB0 File Offset: 0x0037C0B0
		// (set) Token: 0x060016F5 RID: 5877 RVA: 0x0037DCC4 File Offset: 0x0037C0C4
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

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x0037DCD0 File Offset: 0x0037C0D0
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x0037DCE4 File Offset: 0x0037C0E4
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

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x0037DD30 File Offset: 0x0037C130
		// (set) Token: 0x060016F9 RID: 5881 RVA: 0x0037DD44 File Offset: 0x0037C144
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

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x0037DD50 File Offset: 0x0037C150
		// (set) Token: 0x060016FB RID: 5883 RVA: 0x0037DD64 File Offset: 0x0037C164
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

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x0037DD70 File Offset: 0x0037C170
		// (set) Token: 0x060016FD RID: 5885 RVA: 0x0037DD84 File Offset: 0x0037C184
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

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x0037DD90 File Offset: 0x0037C190
		// (set) Token: 0x060016FF RID: 5887 RVA: 0x0037DDA4 File Offset: 0x0037C1A4
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

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x0037DDF0 File Offset: 0x0037C1F0
		// (set) Token: 0x06001701 RID: 5889 RVA: 0x0037DE04 File Offset: 0x0037C204
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

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x0037DE50 File Offset: 0x0037C250
		// (set) Token: 0x06001703 RID: 5891 RVA: 0x0037DE64 File Offset: 0x0037C264
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

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x0037DEB0 File Offset: 0x0037C2B0
		// (set) Token: 0x06001705 RID: 5893 RVA: 0x0037DEC4 File Offset: 0x0037C2C4
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

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x0037DED0 File Offset: 0x0037C2D0
		// (set) Token: 0x06001707 RID: 5895 RVA: 0x0037DEE4 File Offset: 0x0037C2E4
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

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x0037DEF0 File Offset: 0x0037C2F0
		// (set) Token: 0x06001709 RID: 5897 RVA: 0x0037DF04 File Offset: 0x0037C304
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

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x0037DF10 File Offset: 0x0037C310
		// (set) Token: 0x0600170B RID: 5899 RVA: 0x0037DF24 File Offset: 0x0037C324
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

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x0037DF30 File Offset: 0x0037C330
		// (set) Token: 0x0600170D RID: 5901 RVA: 0x0037DF44 File Offset: 0x0037C344
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

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x0037DF50 File Offset: 0x0037C350
		// (set) Token: 0x0600170F RID: 5903 RVA: 0x0037DF64 File Offset: 0x0037C364
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

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x0037DFFC File Offset: 0x0037C3FC
		// (set) Token: 0x06001711 RID: 5905 RVA: 0x0037E010 File Offset: 0x0037C410
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

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x0037E01C File Offset: 0x0037C41C
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x0037E030 File Offset: 0x0037C430
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

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x0037E07C File Offset: 0x0037C47C
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x0037E090 File Offset: 0x0037C490
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

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x0037E0DC File Offset: 0x0037C4DC
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x0037E0F0 File Offset: 0x0037C4F0
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

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x0037E0FC File Offset: 0x0037C4FC
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x0037E110 File Offset: 0x0037C510
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

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x0037E11C File Offset: 0x0037C51C
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x0037E130 File Offset: 0x0037C530
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

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x0037E13C File Offset: 0x0037C53C
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x0037E150 File Offset: 0x0037C550
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

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x0037E15C File Offset: 0x0037C55C
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x0037E170 File Offset: 0x0037C570
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

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x0037E17C File Offset: 0x0037C57C
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x0037E190 File Offset: 0x0037C590
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

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x0037E19C File Offset: 0x0037C59C
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x0037E1B0 File Offset: 0x0037C5B0
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

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x0037E1BC File Offset: 0x0037C5BC
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x0037E1D0 File Offset: 0x0037C5D0
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

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x0037E268 File Offset: 0x0037C668
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x0037E27C File Offset: 0x0037C67C
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

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x0037E288 File Offset: 0x0037C688
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x0037E29C File Offset: 0x0037C69C
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

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x0037E2E8 File Offset: 0x0037C6E8
		// (set) Token: 0x0600172B RID: 5931 RVA: 0x0037E2FC File Offset: 0x0037C6FC
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

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x0037E348 File Offset: 0x0037C748
		// (set) Token: 0x0600172D RID: 5933 RVA: 0x0037E35C File Offset: 0x0037C75C
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

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x0037E368 File Offset: 0x0037C768
		// (set) Token: 0x0600172F RID: 5935 RVA: 0x0037E37C File Offset: 0x0037C77C
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

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x0037E388 File Offset: 0x0037C788
		// (set) Token: 0x06001731 RID: 5937 RVA: 0x0037E39C File Offset: 0x0037C79C
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

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x0037E3A8 File Offset: 0x0037C7A8
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x0037E3BC File Offset: 0x0037C7BC
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

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x0037E408 File Offset: 0x0037C808
		// (set) Token: 0x06001735 RID: 5941 RVA: 0x0037E41C File Offset: 0x0037C81C
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

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x0037E468 File Offset: 0x0037C868
		// (set) Token: 0x06001737 RID: 5943 RVA: 0x0037E47C File Offset: 0x0037C87C
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

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x0037E4C8 File Offset: 0x0037C8C8
		// (set) Token: 0x06001739 RID: 5945 RVA: 0x0037E4DC File Offset: 0x0037C8DC
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

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x0037E4E8 File Offset: 0x0037C8E8
		// (set) Token: 0x0600173B RID: 5947 RVA: 0x0037E4FC File Offset: 0x0037C8FC
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

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x0037E548 File Offset: 0x0037C948
		// (set) Token: 0x0600173D RID: 5949 RVA: 0x0037E55C File Offset: 0x0037C95C
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

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x0037E5A8 File Offset: 0x0037C9A8
		// (set) Token: 0x0600173F RID: 5951 RVA: 0x0037E5BC File Offset: 0x0037C9BC
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

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x0037E5C8 File Offset: 0x0037C9C8
		// (set) Token: 0x06001741 RID: 5953 RVA: 0x0037E5DC File Offset: 0x0037C9DC
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

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x0037E5E8 File Offset: 0x0037C9E8
		// (set) Token: 0x06001743 RID: 5955 RVA: 0x0037E5FC File Offset: 0x0037C9FC
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

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x0037E608 File Offset: 0x0037CA08
		// (set) Token: 0x06001745 RID: 5957 RVA: 0x0037E61C File Offset: 0x0037CA1C
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

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x0037E628 File Offset: 0x0037CA28
		// (set) Token: 0x06001747 RID: 5959 RVA: 0x0037E63C File Offset: 0x0037CA3C
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

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x0037E688 File Offset: 0x0037CA88
		// (set) Token: 0x06001749 RID: 5961 RVA: 0x0037E69C File Offset: 0x0037CA9C
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

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x0037E6E8 File Offset: 0x0037CAE8
		// (set) Token: 0x0600174B RID: 5963 RVA: 0x0037E6FC File Offset: 0x0037CAFC
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

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x0037E708 File Offset: 0x0037CB08
		// (set) Token: 0x0600174D RID: 5965 RVA: 0x0037E71C File Offset: 0x0037CB1C
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

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x0037E728 File Offset: 0x0037CB28
		// (set) Token: 0x0600174F RID: 5967 RVA: 0x0037E73C File Offset: 0x0037CB3C
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

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x0037E748 File Offset: 0x0037CB48
		// (set) Token: 0x06001751 RID: 5969 RVA: 0x0037E75C File Offset: 0x0037CB5C
		internal virtual DataGridView DataGridView_processo_820
		{
			get
			{
				return this._DataGridView_processo_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_processo_820_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_processo_820_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_processo_820_CellValueChanged);
				if (this._DataGridView_processo_820 != null)
				{
					this._DataGridView_processo_820.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_processo_820.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_processo_820.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_processo_820 = value;
				if (this._DataGridView_processo_820 != null)
				{
					this._DataGridView_processo_820.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_processo_820.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_processo_820.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x0037E7F4 File Offset: 0x0037CBF4
		// (set) Token: 0x06001753 RID: 5971 RVA: 0x0037E808 File Offset: 0x0037CC08
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

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x0037E814 File Offset: 0x0037CC14
		// (set) Token: 0x06001755 RID: 5973 RVA: 0x0037E828 File Offset: 0x0037CC28
		internal virtual DataGridView DataGridView_grupos_820
		{
			get
			{
				return this._DataGridView_grupos_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_grupos_820_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_grupos_820_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_grupos_820_CellValueChanged);
				if (this._DataGridView_grupos_820 != null)
				{
					this._DataGridView_grupos_820.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_grupos_820.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_grupos_820.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_grupos_820 = value;
				if (this._DataGridView_grupos_820 != null)
				{
					this._DataGridView_grupos_820.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_grupos_820.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_grupos_820.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x0037E8C0 File Offset: 0x0037CCC0
		// (set) Token: 0x06001757 RID: 5975 RVA: 0x0037E8D4 File Offset: 0x0037CCD4
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

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001758 RID: 5976 RVA: 0x0037E8E0 File Offset: 0x0037CCE0
		// (set) Token: 0x06001759 RID: 5977 RVA: 0x0037E8F4 File Offset: 0x0037CCF4
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

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x0037E900 File Offset: 0x0037CD00
		// (set) Token: 0x0600175B RID: 5979 RVA: 0x0037E914 File Offset: 0x0037CD14
		internal virtual DataGridView DataGridView_periferico_RT820
		{
			get
			{
				return this._DataGridView_periferico_RT820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_periferico_RT820_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_periferico_RT820_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_periferico_RT820_CellValueChanged);
				if (this._DataGridView_periferico_RT820 != null)
				{
					this._DataGridView_periferico_RT820.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_periferico_RT820.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_periferico_RT820.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_periferico_RT820 = value;
				if (this._DataGridView_periferico_RT820 != null)
				{
					this._DataGridView_periferico_RT820.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_periferico_RT820.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_periferico_RT820.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x0037E9AC File Offset: 0x0037CDAC
		// (set) Token: 0x0600175D RID: 5981 RVA: 0x0037E9C0 File Offset: 0x0037CDC0
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

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x0037EA58 File Offset: 0x0037CE58
		// (set) Token: 0x0600175F RID: 5983 RVA: 0x0037EA6C File Offset: 0x0037CE6C
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

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x0037EA78 File Offset: 0x0037CE78
		// (set) Token: 0x06001761 RID: 5985 RVA: 0x0037EA8C File Offset: 0x0037CE8C
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

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x0037EAD8 File Offset: 0x0037CED8
		// (set) Token: 0x06001763 RID: 5987 RVA: 0x0037EAEC File Offset: 0x0037CEEC
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

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001764 RID: 5988 RVA: 0x0037EAF8 File Offset: 0x0037CEF8
		// (set) Token: 0x06001765 RID: 5989 RVA: 0x0037EB0C File Offset: 0x0037CF0C
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

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x0037EB18 File Offset: 0x0037CF18
		// (set) Token: 0x06001767 RID: 5991 RVA: 0x0037EB2C File Offset: 0x0037CF2C
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

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x0037EB38 File Offset: 0x0037CF38
		// (set) Token: 0x06001769 RID: 5993 RVA: 0x0037EB4C File Offset: 0x0037CF4C
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

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x0037EB58 File Offset: 0x0037CF58
		// (set) Token: 0x0600176B RID: 5995 RVA: 0x0037EB6C File Offset: 0x0037CF6C
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

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x0037EB78 File Offset: 0x0037CF78
		// (set) Token: 0x0600176D RID: 5997 RVA: 0x0037EB8C File Offset: 0x0037CF8C
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

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x0037EB98 File Offset: 0x0037CF98
		// (set) Token: 0x0600176F RID: 5999 RVA: 0x0037EBAC File Offset: 0x0037CFAC
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

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x0037EBB8 File Offset: 0x0037CFB8
		// (set) Token: 0x06001771 RID: 6001 RVA: 0x0037EBCC File Offset: 0x0037CFCC
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

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x0037EBD8 File Offset: 0x0037CFD8
		// (set) Token: 0x06001773 RID: 6003 RVA: 0x0037EBEC File Offset: 0x0037CFEC
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

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x0037EBF8 File Offset: 0x0037CFF8
		// (set) Token: 0x06001775 RID: 6005 RVA: 0x0037EC0C File Offset: 0x0037D00C
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

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x0037ECA4 File Offset: 0x0037D0A4
		// (set) Token: 0x06001777 RID: 6007 RVA: 0x0037ECB8 File Offset: 0x0037D0B8
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

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x0037ECC4 File Offset: 0x0037D0C4
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x0037ECD8 File Offset: 0x0037D0D8
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

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x0037ECE4 File Offset: 0x0037D0E4
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x0037ECF8 File Offset: 0x0037D0F8
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

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x0037ED04 File Offset: 0x0037D104
		// (set) Token: 0x0600177D RID: 6013 RVA: 0x0037ED18 File Offset: 0x0037D118
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

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x0037ED24 File Offset: 0x0037D124
		// (set) Token: 0x0600177F RID: 6015 RVA: 0x0037ED38 File Offset: 0x0037D138
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

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x0037ED44 File Offset: 0x0037D144
		// (set) Token: 0x06001781 RID: 6017 RVA: 0x0037ED58 File Offset: 0x0037D158
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

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x0037ED64 File Offset: 0x0037D164
		// (set) Token: 0x06001783 RID: 6019 RVA: 0x0037ED78 File Offset: 0x0037D178
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

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x0037ED84 File Offset: 0x0037D184
		// (set) Token: 0x06001785 RID: 6021 RVA: 0x0037ED98 File Offset: 0x0037D198
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

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x0037EDA4 File Offset: 0x0037D1A4
		// (set) Token: 0x06001787 RID: 6023 RVA: 0x0037EDB8 File Offset: 0x0037D1B8
		internal virtual DataGridView DataGridView_vazoes_RT820
		{
			get
			{
				return this._DataGridView_vazoes_RT820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_vazoes_RT820_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_vazoes_RT820_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_vazoes_RT820_CellValueChanged);
				if (this._DataGridView_vazoes_RT820 != null)
				{
					this._DataGridView_vazoes_RT820.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_vazoes_RT820.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_vazoes_RT820.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_vazoes_RT820 = value;
				if (this._DataGridView_vazoes_RT820 != null)
				{
					this._DataGridView_vazoes_RT820.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_vazoes_RT820.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_vazoes_RT820.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x0037EE50 File Offset: 0x0037D250
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x0037EE64 File Offset: 0x0037D264
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

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x0037EE70 File Offset: 0x0037D270
		// (set) Token: 0x0600178B RID: 6027 RVA: 0x0037EE84 File Offset: 0x0037D284
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

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x0037EEF4 File Offset: 0x0037D2F4
		// (set) Token: 0x0600178D RID: 6029 RVA: 0x0037EF08 File Offset: 0x0037D308
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

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x0037EF54 File Offset: 0x0037D354
		// (set) Token: 0x0600178F RID: 6031 RVA: 0x0037EF68 File Offset: 0x0037D368
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

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x0037F000 File Offset: 0x0037D400
		// (set) Token: 0x06001791 RID: 6033 RVA: 0x0037F014 File Offset: 0x0037D414
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

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x0037F020 File Offset: 0x0037D420
		// (set) Token: 0x06001793 RID: 6035 RVA: 0x0037F034 File Offset: 0x0037D434
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

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001794 RID: 6036 RVA: 0x0037F040 File Offset: 0x0037D440
		// (set) Token: 0x06001795 RID: 6037 RVA: 0x0037F054 File Offset: 0x0037D454
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

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x0037F060 File Offset: 0x0037D460
		// (set) Token: 0x06001797 RID: 6039 RVA: 0x0037F074 File Offset: 0x0037D474
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

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x0037F080 File Offset: 0x0037D480
		// (set) Token: 0x06001799 RID: 6041 RVA: 0x0037F094 File Offset: 0x0037D494
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

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x0037F0A0 File Offset: 0x0037D4A0
		// (set) Token: 0x0600179B RID: 6043 RVA: 0x0037F0B4 File Offset: 0x0037D4B4
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

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x0037F0C0 File Offset: 0x0037D4C0
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x0037F0D4 File Offset: 0x0037D4D4
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

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x0037F0E0 File Offset: 0x0037D4E0
		// (set) Token: 0x0600179F RID: 6047 RVA: 0x0037F0F4 File Offset: 0x0037D4F4
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

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x0037F100 File Offset: 0x0037D500
		// (set) Token: 0x060017A1 RID: 6049 RVA: 0x0037F114 File Offset: 0x0037D514
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

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x0037F120 File Offset: 0x0037D520
		// (set) Token: 0x060017A3 RID: 6051 RVA: 0x0037F134 File Offset: 0x0037D534
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

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x0037F140 File Offset: 0x0037D540
		// (set) Token: 0x060017A5 RID: 6053 RVA: 0x0037F154 File Offset: 0x0037D554
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

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x0037F160 File Offset: 0x0037D560
		// (set) Token: 0x060017A7 RID: 6055 RVA: 0x0037F174 File Offset: 0x0037D574
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

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x0037F180 File Offset: 0x0037D580
		// (set) Token: 0x060017A9 RID: 6057 RVA: 0x0037F194 File Offset: 0x0037D594
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

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x0037F1A0 File Offset: 0x0037D5A0
		// (set) Token: 0x060017AB RID: 6059 RVA: 0x0037F1B4 File Offset: 0x0037D5B4
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

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x0037F1C0 File Offset: 0x0037D5C0
		// (set) Token: 0x060017AD RID: 6061 RVA: 0x0037F1D4 File Offset: 0x0037D5D4
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

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x0037F1E0 File Offset: 0x0037D5E0
		// (set) Token: 0x060017AF RID: 6063 RVA: 0x0037F1F4 File Offset: 0x0037D5F4
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

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x0037F200 File Offset: 0x0037D600
		// (set) Token: 0x060017B1 RID: 6065 RVA: 0x0037F214 File Offset: 0x0037D614
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

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x0037F220 File Offset: 0x0037D620
		// (set) Token: 0x060017B3 RID: 6067 RVA: 0x0037F234 File Offset: 0x0037D634
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

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x0037F240 File Offset: 0x0037D640
		// (set) Token: 0x060017B5 RID: 6069 RVA: 0x0037F254 File Offset: 0x0037D654
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

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x0037F260 File Offset: 0x0037D660
		// (set) Token: 0x060017B7 RID: 6071 RVA: 0x0037F274 File Offset: 0x0037D674
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

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x0037F280 File Offset: 0x0037D680
		// (set) Token: 0x060017B9 RID: 6073 RVA: 0x0037F294 File Offset: 0x0037D694
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

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x0037F2A0 File Offset: 0x0037D6A0
		// (set) Token: 0x060017BB RID: 6075 RVA: 0x0037F2B4 File Offset: 0x0037D6B4
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

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x0037F2C0 File Offset: 0x0037D6C0
		// (set) Token: 0x060017BD RID: 6077 RVA: 0x0037F2D4 File Offset: 0x0037D6D4
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

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x0037F2E0 File Offset: 0x0037D6E0
		// (set) Token: 0x060017BF RID: 6079 RVA: 0x0037F2F4 File Offset: 0x0037D6F4
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

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x0037F300 File Offset: 0x0037D700
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x0037F314 File Offset: 0x0037D714
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

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x0037F320 File Offset: 0x0037D720
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x0037F334 File Offset: 0x0037D734
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

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x0037F340 File Offset: 0x0037D740
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x0037F354 File Offset: 0x0037D754
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

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x0037F360 File Offset: 0x0037D760
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x0037F374 File Offset: 0x0037D774
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

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x0037F380 File Offset: 0x0037D780
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x0037F394 File Offset: 0x0037D794
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

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x0037F3A0 File Offset: 0x0037D7A0
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x0037F3B4 File Offset: 0x0037D7B4
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

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x0037F3C0 File Offset: 0x0037D7C0
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x0037F3D4 File Offset: 0x0037D7D4
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

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x0037F3E0 File Offset: 0x0037D7E0
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x0037F3F4 File Offset: 0x0037D7F4
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

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x0037F400 File Offset: 0x0037D800
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x0037F414 File Offset: 0x0037D814
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

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x0037F420 File Offset: 0x0037D820
		// (set) Token: 0x060017D3 RID: 6099 RVA: 0x0037F434 File Offset: 0x0037D834
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

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x0037F440 File Offset: 0x0037D840
		// (set) Token: 0x060017D5 RID: 6101 RVA: 0x0037F454 File Offset: 0x0037D854
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

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x0037F460 File Offset: 0x0037D860
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x0037F474 File Offset: 0x0037D874
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

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x0037F480 File Offset: 0x0037D880
		// (set) Token: 0x060017D9 RID: 6105 RVA: 0x0037F494 File Offset: 0x0037D894
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

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x0037F4A0 File Offset: 0x0037D8A0
		// (set) Token: 0x060017DB RID: 6107 RVA: 0x0037F4B4 File Offset: 0x0037D8B4
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

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x0037F4C0 File Offset: 0x0037D8C0
		// (set) Token: 0x060017DD RID: 6109 RVA: 0x0037F4D4 File Offset: 0x0037D8D4
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

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x0037F4E0 File Offset: 0x0037D8E0
		// (set) Token: 0x060017DF RID: 6111 RVA: 0x0037F4F4 File Offset: 0x0037D8F4
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

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x0037F500 File Offset: 0x0037D900
		// (set) Token: 0x060017E1 RID: 6113 RVA: 0x0037F514 File Offset: 0x0037D914
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

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x0037F520 File Offset: 0x0037D920
		// (set) Token: 0x060017E3 RID: 6115 RVA: 0x0037F534 File Offset: 0x0037D934
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

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x0037F540 File Offset: 0x0037D940
		// (set) Token: 0x060017E5 RID: 6117 RVA: 0x0037F554 File Offset: 0x0037D954
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

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x0037F560 File Offset: 0x0037D960
		// (set) Token: 0x060017E7 RID: 6119 RVA: 0x0037F574 File Offset: 0x0037D974
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

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x0037F580 File Offset: 0x0037D980
		// (set) Token: 0x060017E9 RID: 6121 RVA: 0x0037F594 File Offset: 0x0037D994
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

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x0037F5A0 File Offset: 0x0037D9A0
		// (set) Token: 0x060017EB RID: 6123 RVA: 0x0037F5B4 File Offset: 0x0037D9B4
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

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x0037F5C0 File Offset: 0x0037D9C0
		// (set) Token: 0x060017ED RID: 6125 RVA: 0x0037F5D4 File Offset: 0x0037D9D4
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

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x0037F5E0 File Offset: 0x0037D9E0
		// (set) Token: 0x060017EF RID: 6127 RVA: 0x0037F5F4 File Offset: 0x0037D9F4
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

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x0037F600 File Offset: 0x0037DA00
		// (set) Token: 0x060017F1 RID: 6129 RVA: 0x0037F614 File Offset: 0x0037DA14
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

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x0037F620 File Offset: 0x0037DA20
		// (set) Token: 0x060017F3 RID: 6131 RVA: 0x0037F634 File Offset: 0x0037DA34
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

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x0037F640 File Offset: 0x0037DA40
		// (set) Token: 0x060017F5 RID: 6133 RVA: 0x0037F654 File Offset: 0x0037DA54
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

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x0037F660 File Offset: 0x0037DA60
		// (set) Token: 0x060017F7 RID: 6135 RVA: 0x0037F674 File Offset: 0x0037DA74
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

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x0037F680 File Offset: 0x0037DA80
		// (set) Token: 0x060017F9 RID: 6137 RVA: 0x0037F694 File Offset: 0x0037DA94
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

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x0037F72C File Offset: 0x0037DB2C
		// (set) Token: 0x060017FB RID: 6139 RVA: 0x0037F740 File Offset: 0x0037DB40
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

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x0037F74C File Offset: 0x0037DB4C
		// (set) Token: 0x060017FD RID: 6141 RVA: 0x0037F760 File Offset: 0x0037DB60
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

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x0037F76C File Offset: 0x0037DB6C
		// (set) Token: 0x060017FF RID: 6143 RVA: 0x0037F780 File Offset: 0x0037DB80
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

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x0037F78C File Offset: 0x0037DB8C
		// (set) Token: 0x06001801 RID: 6145 RVA: 0x0037F7A0 File Offset: 0x0037DBA0
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

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x0037F7AC File Offset: 0x0037DBAC
		// (set) Token: 0x06001803 RID: 6147 RVA: 0x0037F7C0 File Offset: 0x0037DBC0
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

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x0037F7CC File Offset: 0x0037DBCC
		// (set) Token: 0x06001805 RID: 6149 RVA: 0x0037F7E0 File Offset: 0x0037DBE0
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

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x0037F7EC File Offset: 0x0037DBEC
		// (set) Token: 0x06001807 RID: 6151 RVA: 0x0037F800 File Offset: 0x0037DC00
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

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x0037F80C File Offset: 0x0037DC0C
		// (set) Token: 0x06001809 RID: 6153 RVA: 0x0037F820 File Offset: 0x0037DC20
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

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x0037F86C File Offset: 0x0037DC6C
		// (set) Token: 0x0600180B RID: 6155 RVA: 0x0037F880 File Offset: 0x0037DC80
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

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x0037F88C File Offset: 0x0037DC8C
		// (set) Token: 0x0600180D RID: 6157 RVA: 0x0037F8A0 File Offset: 0x0037DCA0
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

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x0037F8AC File Offset: 0x0037DCAC
		// (set) Token: 0x0600180F RID: 6159 RVA: 0x0037F8C0 File Offset: 0x0037DCC0
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

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001810 RID: 6160 RVA: 0x0037F8CC File Offset: 0x0037DCCC
		// (set) Token: 0x06001811 RID: 6161 RVA: 0x0037F8E0 File Offset: 0x0037DCE0
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

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001812 RID: 6162 RVA: 0x0037F99C File Offset: 0x0037DD9C
		// (set) Token: 0x06001813 RID: 6163 RVA: 0x0037F9B0 File Offset: 0x0037DDB0
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

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x0037F9BC File Offset: 0x0037DDBC
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x0037F9D0 File Offset: 0x0037DDD0
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

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x0037FA68 File Offset: 0x0037DE68
		// (set) Token: 0x06001817 RID: 6167 RVA: 0x0037FA7C File Offset: 0x0037DE7C
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

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x0037FA88 File Offset: 0x0037DE88
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x0037FA9C File Offset: 0x0037DE9C
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

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x0037FB34 File Offset: 0x0037DF34
		// (set) Token: 0x0600181B RID: 6171 RVA: 0x0037FB48 File Offset: 0x0037DF48
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

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x0037FBE0 File Offset: 0x0037DFE0
		// (set) Token: 0x0600181D RID: 6173 RVA: 0x0037FBF4 File Offset: 0x0037DFF4
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

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x0037FC00 File Offset: 0x0037E000
		// (set) Token: 0x0600181F RID: 6175 RVA: 0x0037FC14 File Offset: 0x0037E014
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

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x0037FC20 File Offset: 0x0037E020
		// (set) Token: 0x06001821 RID: 6177 RVA: 0x0037FC34 File Offset: 0x0037E034
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

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001822 RID: 6178 RVA: 0x0037FCCC File Offset: 0x0037E0CC
		// (set) Token: 0x06001823 RID: 6179 RVA: 0x0037FCE0 File Offset: 0x0037E0E0
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

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x0037FCEC File Offset: 0x0037E0EC
		// (set) Token: 0x06001825 RID: 6181 RVA: 0x0037FD00 File Offset: 0x0037E100
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

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x0037FDBC File Offset: 0x0037E1BC
		// (set) Token: 0x06001827 RID: 6183 RVA: 0x0037FDD0 File Offset: 0x0037E1D0
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

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x0037FDDC File Offset: 0x0037E1DC
		// (set) Token: 0x06001829 RID: 6185 RVA: 0x0037FDF0 File Offset: 0x0037E1F0
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

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x0037FE88 File Offset: 0x0037E288
		// (set) Token: 0x0600182B RID: 6187 RVA: 0x0037FE9C File Offset: 0x0037E29C
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

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x0037FEA8 File Offset: 0x0037E2A8
		// (set) Token: 0x0600182D RID: 6189 RVA: 0x0037FEBC File Offset: 0x0037E2BC
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

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x0037FEC8 File Offset: 0x0037E2C8
		// (set) Token: 0x0600182F RID: 6191 RVA: 0x0037FEDC File Offset: 0x0037E2DC
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

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x0037FF28 File Offset: 0x0037E328
		// (set) Token: 0x06001831 RID: 6193 RVA: 0x0037FF3C File Offset: 0x0037E33C
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

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x0037FF48 File Offset: 0x0037E348
		// (set) Token: 0x06001833 RID: 6195 RVA: 0x0037FF5C File Offset: 0x0037E35C
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

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x0037FF68 File Offset: 0x0037E368
		// (set) Token: 0x06001835 RID: 6197 RVA: 0x0037FF7C File Offset: 0x0037E37C
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

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001836 RID: 6198 RVA: 0x0037FF88 File Offset: 0x0037E388
		// (set) Token: 0x06001837 RID: 6199 RVA: 0x0037FF9C File Offset: 0x0037E39C
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

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x00380034 File Offset: 0x0037E434
		// (set) Token: 0x06001839 RID: 6201 RVA: 0x00380048 File Offset: 0x0037E448
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

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x00380054 File Offset: 0x0037E454
		// (set) Token: 0x0600183B RID: 6203 RVA: 0x00380068 File Offset: 0x0037E468
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

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x00380100 File Offset: 0x0037E500
		// (set) Token: 0x0600183D RID: 6205 RVA: 0x00380114 File Offset: 0x0037E514
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

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x00380120 File Offset: 0x0037E520
		// (set) Token: 0x0600183F RID: 6207 RVA: 0x00380134 File Offset: 0x0037E534
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

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x003801CC File Offset: 0x0037E5CC
		// (set) Token: 0x06001841 RID: 6209 RVA: 0x003801E0 File Offset: 0x0037E5E0
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

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x003801EC File Offset: 0x0037E5EC
		// (set) Token: 0x06001843 RID: 6211 RVA: 0x00380200 File Offset: 0x0037E600
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

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x0038020C File Offset: 0x0037E60C
		// (set) Token: 0x06001845 RID: 6213 RVA: 0x00380220 File Offset: 0x0037E620
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

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x0038022C File Offset: 0x0037E62C
		// (set) Token: 0x06001847 RID: 6215 RVA: 0x00380240 File Offset: 0x0037E640
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

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x003802D8 File Offset: 0x0037E6D8
		// (set) Token: 0x06001849 RID: 6217 RVA: 0x003802EC File Offset: 0x0037E6EC
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

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x00380384 File Offset: 0x0037E784
		// (set) Token: 0x0600184B RID: 6219 RVA: 0x00380398 File Offset: 0x0037E798
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

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x00380430 File Offset: 0x0037E830
		// (set) Token: 0x0600184D RID: 6221 RVA: 0x00380444 File Offset: 0x0037E844
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

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x00380450 File Offset: 0x0037E850
		// (set) Token: 0x0600184F RID: 6223 RVA: 0x00380464 File Offset: 0x0037E864
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

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x003804B0 File Offset: 0x0037E8B0
		// (set) Token: 0x06001851 RID: 6225 RVA: 0x003804C4 File Offset: 0x0037E8C4
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

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x003804D0 File Offset: 0x0037E8D0
		// (set) Token: 0x06001853 RID: 6227 RVA: 0x003804E4 File Offset: 0x0037E8E4
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

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x003804F0 File Offset: 0x0037E8F0
		// (set) Token: 0x06001855 RID: 6229 RVA: 0x00380504 File Offset: 0x0037E904
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

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x00380510 File Offset: 0x0037E910
		// (set) Token: 0x06001857 RID: 6231 RVA: 0x00380524 File Offset: 0x0037E924
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

		// Token: 0x06001858 RID: 6232 RVA: 0x00380570 File Offset: 0x0037E970
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

		// Token: 0x06001859 RID: 6233 RVA: 0x00380604 File Offset: 0x0037EA04
		private void InicializaEStruturasVariaveis_RT820()
		{
			this.InicializaEstrutura_DataGridView_Processos();
			this.InicializaEstrutura_DataGridView_Vazoes();
			this.InicializaEstrutura_DataGridView_ED();
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00380618 File Offset: 0x0037EA18
		private void Desenha_DataGirView_SetPoint_Horario()
		{
			this.dgv_sph.DefaultCellStyle.Alignment =(System.Windows.Forms.DataGridViewContentAlignment)64;
			this.dgv_sph.AlternatingRowsDefaultCellStyle = this.DataGridView_setpoints_820.AlternatingRowsDefaultCellStyle;
			int num = 0;
			do
			{
				if (num % 2 == 0)
				{
					this.dgv_sph.Rows[num].HeaderCell.Value = string.Format("Ctrl {0}", (double)num / 2.0 + 1.0);
					this.dgv_sph.Rows[num].Cells[0].Value = "1";
				}
				else
				{
					this.dgv_sph.Rows[num].Cells[0].Value = "2";
				}
				checked
				{
					num++;
				}
			}
			while (num <= 15);
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x003806F0 File Offset: 0x0037EAF0
		private void RT_820_conf_Load(object sender, EventArgs e)
		{
			RT_geral.Lmte_Init_ok = false;
			this.bloqueio_IO = false;
			perifericos.Cria_ListaBaudRate();
			checked
			{
				RT_geral.RT_820_BD.BaudRateCOM2.valores = new int[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_820_BD.BaudRateCOM2.itens = new string[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_820_BD.BaudRateCOM1.valores = new int[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_820_BD.BaudRateCOM1.itens = new string[perifericos.ListaBaudRate.Count + 1];
				RT_geral.RT_820_BD.ctrl_acionamento = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_BD.ctrl_desligamento = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_BD.ctrl_ret_acionamento = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_BD.ctrl_ret_desligamento = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_BD.ctrl_ED_selecao = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_BD.ctrl_ED_bloqueio = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_BD.ctrl_ED_liberacao = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_BD.ctrl_reverso = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_BD.ctrl_modo = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_BD.ctrl_agrupamento = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_BD.ctrl_tempo_max_partida = new RT_geral.Integer_ictel[9];
				RT_geral.RT_820_BD.ctrl_tempo_max_parada = new RT_geral.Integer_ictel[9];
				RT_geral.RT_820_BD.ctrl_tempo_min_parado = new RT_geral.Integer_ictel[9];
				RT_geral.RT_820_BD.ctrl_tempo_min_operando = new RT_geral.Integer_ictel[9];
				RT_geral.RT_820_BD.grupo_simultaneos = new RT_geral.Combo_ictel_ctrl[6];
				RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos = new RT_geral.Integer_ictel[5];
				RT_geral.RT_820_BD.EA_Range = new RT_geral.Integer_ictel[18];
				RT_geral.RT_820_BD.EA_Inicio = new RT_geral.Integer_ictel[18];
				RT_geral.RT_820_BD.EA_Fim = new RT_geral.Integer_ictel[18];
				RT_geral.RT_820_BD.config_ED = new RT_geral.Combo_ictel_ctrl[18];
				RT_geral.RT_820_BD.Setpoints_ctrl_variavel = new RT_geral.Combo_ictel_ctrl[10];
				RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo = new RT_geral.Integer_ictel[10];
				RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto = new RT_geral.Integer_ictel[10];
				RT_geral.RT_820_BD.Setpoints_ctrl_bloqueio = new RT_geral.Combo_ictel_ctrl[10];
				RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio = new RT_geral.Integer_ictel[10];
				RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao = new RT_geral.Integer_ictel[10];
				RT_geral.RT_820_BD.config_vazao = new RT_geral.Combo_ictel_ctrl[9];
				RT_geral.RT_820_BD.config_perifericos_end = new RT_geral.Integer_ictel[6];
				RT_geral.RT_820_BD.config_perifericos_mod = new RT_geral.Combo_ictel_ctrl[6];
				RT_geral.RT_820_BD.config_referencia_perif_periferico = new RT_geral.Combo_ictel_ctrl[11];
				RT_geral.RT_820_BD.config_referencia_perif_memoria = new RT_geral.Integer_ictel[11];
				RT_geral.RT_820_BD.config_referencia_perif_variavel1 = new RT_geral.Combo_ictel_ctrl[11];
				RT_geral.RT_820_BD.config_referencia_perif_variavel2 = new RT_geral.Combo_ictel_ctrl[11];
				RT_geral.RT_820_BD.config_referencia_perif_escala = new RT_geral.Integer_ictel[11];
				RT_geral.RT_820_BD.config_referencia_perif_formato = new RT_geral.Combo_ictel_ctrl[11];
				RT_geral.RT_820_BD.config_referencia_perif_base10 = new RT_geral.Combo_ictel_ctrl[11];
				RT_geral.RT_820_BD.config_atuador1_perif = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador1_mem = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador1_var1 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador1_escala1 = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador1_var2 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador1_escala2 = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador1_histerese = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador1_formato = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador1_base10 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador1_v1baixo = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador1_v1alto = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador1_v2baixo = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador1_v2alto = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador1_setpoint1_hora = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_perif = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador2_mem = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador2_var1 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador2_escala1 = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador2_var2 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador2_escala2 = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador2_histerese = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador2_formato = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador2_base10 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador2_v1baixo = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador2_v1alto = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador2_v2baixo = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador2_v2alto = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador2_setpoint1_hora = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_perif = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador3_mem = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador3_var1 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador3_escala1 = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador3_var2 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador3_escala2 = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador3_histerese = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador3_formato = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador3_base10 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador3_v1baixo = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador3_v1alto = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador3_v2baixo = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador3_v2alto = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador3_setpoint1_hora = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_perif = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador4_mem = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador4_var1 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador4_escala1 = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador4_var2 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador4_escala2 = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador4_histerese = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador4_formato = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador4_base10 = new RT_geral.Combo_ictel_ctrl[2];
				RT_geral.RT_820_BD.config_atuador4_v1baixo = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador4_v1alto = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador4_v2baixo = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador4_v2alto = new RT_geral.Integer_ictel[2];
				RT_geral.RT_820_BD.config_atuador4_setpoint1_hora = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6 = new RT_geral.Integer_ictel[4];
				RT_geral.RT_820_BD.modo_repetidora.valores = new int[3];
				RT_geral.RT_820_BD.modo_repetidora.itens = new string[3];
				RT_geral.RT_820_BD.Repetidoras = new RT_geral.Integer_ictel[52];
				RT_geral.RT_820_BD.Timer_Horario = new RT_geral.Integer_ictel[8][];
				int num = 0;
				do
				{
					RT_geral.Integer_ictel[] array = new RT_geral.Integer_ictel[13];
					RT_geral.RT_820_BD.Timer_Horario[num] = array;
					num++;
				}
				while (num <= 7);
				RT_geral.RT_820_BD.setpoint_horario = new RT_geral.SETPOINT_HORARIO_RT_820_300[17];
				this.dgv_sph.RowCount = 16;
				this.Desenha_DataGirView_SetPoint_Horario();
				RT_geral.RT_820_BD.HabExpIO.Valor = 21856;
				this.Inicializa_DadosEStruturaRT820_Padrao();
				RT_geral.Lmte_Init_ok = true;
				this.InicializaEstrutura_DataGridView_Processos();
				this.GeraDataGridView_Processos();
				this.InicializaEstrutura_DataGridView_agrupamentos();
				this.GeraDataGridView_Grupos();
				this.InicializaEstrutura_DataGridView_EA();
				this.GeraDataGridView_EA();
				perifericos.Cria_ListaPeriferico_RT820_300();
				this.InicializaEstrutura_DataGridView_Periferico();
				this.GeraDataGridView_Perifericos();
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
				this.Inicializa_DadosEStruturaRT820_Default();
				Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
				this.TabPage_geral.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
				this.TabPage_geral.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
				this.TabPage_controle.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
				this.TabPage_controle.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
				this.TabPage_EA.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
				this.TabPage_EA.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
				this.TabPage_ED.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
				this.TabPage_ED.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
				this.TabPage_setpoints.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
				this.TabPage_setpoints.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
				this.TabPage_vazao_perifericos.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
				this.TabPage_vazao_perifericos.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
				this.TabPage_Atuadores.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
				this.TabPage_Atuadores.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
				this.TabPage_Atuadores2.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
				this.TabPage_Atuadores2.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
				this.TabPage_repetidora.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
				this.TabPage_repetidora.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
				this.TabPage_timer.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
				this.TabPage_timer.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
				this.TabPage1.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
				this.TabPage1.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
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
				this.NumericUpDown_end_mestre_820.Minimum = new decimal(RT_geral.RT_820_BD.End_mestre.Lmte_inf);
				this.NumericUpDown_end_mestre_820.Maximum = new decimal(RT_geral.RT_820_BD.End_mestre.Lmte_sup);
				this.NumericUpDown_end_est_820.Minimum = new decimal(RT_geral.RT_820_BD.End_estacao.Lmte_inf);
				this.NumericUpDown_end_est_820.Maximum = new decimal(RT_geral.RT_820_BD.End_estacao.Lmte_sup);
				this.NumericUpDown_temp_ptt_820.Minimum = new decimal(RT_geral.RT_820_BD.Tempo_ptt.Lmte_inf);
				this.NumericUpDown_temp_ptt_820.Maximum = new decimal(RT_geral.RT_820_BD.Tempo_ptt.Lmte_sup);
				this.nud_tempoforaar.Minimum = new decimal(RT_geral.RT_820_BD.TempoForaAr.Lmte_inf);
				this.nud_tempoforaar.Maximum = new decimal(RT_geral.RT_820_BD.TempoForaAr.Lmte_sup);
				this.Atualiza_TelaRT820();
				this.ToolStripLabel1.Text = RT_geral.MontaNomePlacaPeloFabricante(RT_geral.RT_820_BD.Equip.Valor, RT_geral.RT_820_BD.Versao.Valor);
			}
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x003819C8 File Offset: 0x0037FDC8
		private void RT_820_conf_Activated(object sender, EventArgs e)
		{
			Geral.Equipamento_selecionado = 820;
			Geral.Equipamento_versao = 3;
			Geral.Equipamento_build = 0;
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x003819E0 File Offset: 0x0037FDE0
		private void RT_820_conf_FormClosed(object sender, FormClosedEventArgs e)
		{
			RT_geral.Telas_RT_820.Configuracao = false;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x003819F0 File Offset: 0x0037FDF0
		private void GeraDataGridView_Processos()
		{
			this.DataGridView_processo_820.Columns.Clear();
			this.DataGridView_processo_820.CellBorderStyle = DataGridViewCellBorderStyle.Single;
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
				while (num <= 13);
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

		// Token: 0x0600185F RID: 6239 RVA: 0x00381B24 File Offset: 0x0037FF24
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
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].TagColuna = "Tempo Partida  (s)";
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].TagColuna = "Tempo Parada (s)";
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].TagColuna = "Tempo Mínimo Parado (s)";
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].TagColuna = "Tempo Mínimo Operando (s)";
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
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].LarguraColuna = 90;
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].LarguraColuna = 90;
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].LarguraColuna = 90;
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].LarguraColuna = 90;
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].LarguraColuna = 110;
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].LarguraColuna = 90;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LarguraColuna = 60;
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].LarguraColuna = 60;
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].LarguraColuna = 60;
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].LarguraColuna = 60;
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
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasMenu[0] = "Desativo";
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasMenu[0] = "Desativo";
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasValor[0] = 21856;
				int num = 0;
				int num2 = 0;
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
				int num4 = Convert.ToInt32(num);
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
				int num7 = Convert.ToInt32(num);
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
				int num9 = Convert.ToInt32(num);
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
				int num11 = Convert.ToInt32(num);
				for (i = num10; i <= num11; i++)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasMenu[i] = "Periférico " + Strings.Format(i - 16 + num2, "#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasValor[i] = 21856 + i + num2;
					RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasMenu[i] = "Periférico " + Strings.Format(i - 16 + num2, "#");
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
				int num13 = Convert.ToInt32(num);
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
					RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasMenu[i] = "Grupo " + Strings.Format(i, "#");
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

		// Token: 0x06001860 RID: 6240 RVA: 0x00382828 File Offset: 0x00380C28
		private void GeraDataGridView_Grupos()
		{
			this.DataGridView_grupos_820.Columns.Clear();
			this.DataGridView_grupos_820.CellBorderStyle = DataGridViewCellBorderStyle.Single;
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
				while (num <= 1);
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

		// Token: 0x06001861 RID: 6241 RVA: 0x0038295C File Offset: 0x00380D5C
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
				RT_geral.RT_820_DataGrigViewGruposColunas[1].TagColuna = "Tempo Entre Acionamentos (s)";
				RT_geral.RT_820_DataGrigViewGruposColunas[0].NomeColuna = "ASimultaneos";
				RT_geral.RT_820_DataGrigViewGruposColunas[1].NomeColuna = "TpAcionamentos";
				RT_geral.RT_820_DataGrigViewGruposColunas[0].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewGruposColunas[1].LarguraColuna = 120;
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

		// Token: 0x06001862 RID: 6242 RVA: 0x00382AD4 File Offset: 0x00380ED4
		private void GeraDataGridView_EA()
		{
			this.DataGridView_parametros_EA_820.Columns.Clear();
			this.DataGridView_parametros_EA_820.CellBorderStyle = DataGridViewCellBorderStyle.Single;
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

		// Token: 0x06001863 RID: 6243 RVA: 0x00382C08 File Offset: 0x00381008
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

		// Token: 0x06001864 RID: 6244 RVA: 0x00382D34 File Offset: 0x00381134
		private void GeraDataGridView_Perifericos()
		{
			this.DataGridView_periferico_RT820.Columns.Clear();
			this.DataGridView_periferico_RT820.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			this.DataGridView_periferico_RT820.DefaultCellStyle.Alignment =(System.Windows.Forms.DataGridViewContentAlignment)64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_820_DataGrigViewPerifericosColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewPerifericosColunas);
						this.DataGridView_periferico_RT820.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewPerifericosColunas);
						this.DataGridView_periferico_RT820.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 1);
				this.DataGridView_periferico_RT820.RowCount = 5;
				this.DataGridView_periferico_RT820.RowHeadersWidth = 100;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_periferico_RT820.Rows)
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

		// Token: 0x06001865 RID: 6245 RVA: 0x00382E70 File Offset: 0x00381270
		private void GeraDataGridView_Referencia_Perifericos()
		{
			DataGridView datagridview_referenciaperifico = this.datagridview_referenciaperifico;
			RT_geral.DADOS_DATAGRIDVIEW_RT_820[] rt_820_DataGrigViewReferenciaPerifericosColunas = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas;
			bool flag = true;
			datagridview_referenciaperifico.Columns.Clear();
			datagridview_referenciaperifico.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			datagridview_referenciaperifico.DefaultCellStyle.Alignment =(System.Windows.Forms.DataGridViewContentAlignment)64;
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

		// Token: 0x06001866 RID: 6246 RVA: 0x00383030 File Offset: 0x00381430
		private void InicializaEstrutura_DataGridView_Periferico()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewPerifericosColunas[num].LinhasMenu = new string[perifericos.perif_RT820_300.Count + 1];
					RT_geral.RT_820_DataGrigViewPerifericosColunas[num].LinhasValor = new int[perifericos.perif_RT820_300.Count + 1];
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
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].NumeroLinhaMenu = perifericos.perif_RT820_300.Count;
				int num2 = 48;
				num = 0;
				try
				{
					foreach (perifericos.Periferico periferico in perifericos.perif_RT820_300)
					{
						RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[num] = periferico.nome;
						RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[num] = num2 + num;
						num++;
					}
				}
				finally
				{
					List<perifericos.Periferico>.Enumerator enumerator = new List<perifericos.Periferico>.Enumerator();
					enumerator.Dispose();
				}
				RT_geral.RT_820_DataGrigViewPerifericosColunas[1].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x003831C8 File Offset: 0x003815C8
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
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].AlingColuna = 16;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[1].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].AlingColuna = 16;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].AlingColuna = 16;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[4].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].AlingColuna = 16;
			RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].AlingColuna = 16;
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

		// Token: 0x06001868 RID: 6248 RVA: 0x003838C0 File Offset: 0x00381CC0
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
					RT_geral.RT_820_DataGrigViewAtuador1Colunas[num].AlingColuna = 64;
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
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[1].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[3].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[5].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[6].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[9].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[10].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[11].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador1Colunas[12].AlingColuna = 16;
			}
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00384030 File Offset: 0x00382430
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
					RT_geral.RT_820_DataGrigViewAtuador2Colunas[num].AlingColuna = 16;
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
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[1].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[3].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[5].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[6].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[9].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[10].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[11].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador2Colunas[12].AlingColuna = 16;
			}
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x003847A0 File Offset: 0x00382BA0
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
					RT_geral.RT_820_DataGrigViewAtuador3Colunas[num].AlingColuna = 64;
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
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[1].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[3].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[5].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[6].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[9].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[10].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[11].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador3Colunas[12].AlingColuna = 16;
			}
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00384F10 File Offset: 0x00383310
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
					RT_geral.RT_820_DataGrigViewAtuador4Colunas[num].AlingColuna = 64;
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
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[1].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[3].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[5].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[6].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[9].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[10].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[11].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewAtuador4Colunas[12].AlingColuna = 16;
			}
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00385680 File Offset: 0x00383A80
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
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[0].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[1].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[2].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[3].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[4].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[5].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[6].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[7].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[8].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[9].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[10].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[11].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[12].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas[13].AlingColuna = 64;
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00385AE8 File Offset: 0x00383EE8
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
					RT_geral.RT_820_DataGrigViewAtuador1SetPoint2Colunas[num].AlingColuna = 64;
					num++;
				}
				while (num <= 11);
			}
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00385C98 File Offset: 0x00384098
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
					RT_geral.RT_820_DataGrigViewAtuador2SetPoint1Colunas[num].AlingColuna = 64;
					num++;
				}
				while (num <= 13);
			}
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00385E80 File Offset: 0x00384280
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
					RT_geral.RT_820_DataGrigViewAtuador3SetPoint1Colunas[num].AlingColuna = 64;
					num++;
				}
				while (num <= 13);
			}
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00386068 File Offset: 0x00384468
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
					RT_geral.RT_820_DataGrigViewAtuador4SetPoint1Colunas[num].AlingColuna = 64;
					num++;
				}
				while (num <= 13);
			}
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00386250 File Offset: 0x00384650
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
					RT_geral.RT_820_DataGrigViewAtuador2SetPoint2Colunas[num].AlingColuna = 64;
					num++;
				}
				while (num <= 11);
			}
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00386400 File Offset: 0x00384800
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
					RT_geral.RT_820_DataGrigViewAtuador3SetPoint2Colunas[num].AlingColuna = 64;
					num++;
				}
				while (num <= 11);
			}
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x003865B0 File Offset: 0x003849B0
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
					RT_geral.RT_820_DataGrigViewAtuador4SetPoint2Colunas[num].AlingColuna = 64;
					num++;
				}
				while (num <= 11);
			}
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00386760 File Offset: 0x00384B60
		private void GeraDGV_Colunas(DataGridView datagridview, RT_geral.DADOS_DATAGRIDVIEW_RT_820[] colunas, int NUM_COLUNAS, int NUM_LINHAS)
		{
			RT_geral.DADOS_DATAGRIDVIEW_RT_820[] array = colunas;
			bool flag = false;
			datagridview.Columns.Clear();
			datagridview.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			datagridview.DefaultCellStyle.Alignment =(System.Windows.Forms.DataGridViewContentAlignment)64;
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

		// Token: 0x06001875 RID: 6261 RVA: 0x00386954 File Offset: 0x00384D54
		private void GeraDataGridView_Atuador1SetPoint1()
		{
			DataGridView dgv_atuador_setpoint = this.dgv_atuador_setpoint1;
			RT_geral.DADOS_DATAGRIDVIEW_RT_820[] rt_820_DataGrigViewAtuador1SetPoint1Colunas = RT_geral.RT_820_DataGrigViewAtuador1SetPoint1Colunas;
			bool flag = true;
			dgv_atuador_setpoint.Columns.Clear();
			dgv_atuador_setpoint.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			dgv_atuador_setpoint.DefaultCellStyle.Alignment =(System.Windows.Forms.DataGridViewContentAlignment)64;
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

		// Token: 0x06001876 RID: 6262 RVA: 0x00386B4C File Offset: 0x00384F4C
		private void GeraDataGridView_Atuador1SetPoint2()
		{
			DataGridView dgv_atuador_setpoint = this.dgv_atuador_setpoint11;
			RT_geral.DADOS_DATAGRIDVIEW_RT_820[] rt_820_DataGrigViewAtuador1SetPoint2Colunas = RT_geral.RT_820_DataGrigViewAtuador1SetPoint2Colunas;
			bool flag = true;
			dgv_atuador_setpoint.Columns.Clear();
			dgv_atuador_setpoint.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			dgv_atuador_setpoint.DefaultCellStyle.Alignment =(System.Windows.Forms.DataGridViewContentAlignment)64;
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

		// Token: 0x06001877 RID: 6263 RVA: 0x00386D44 File Offset: 0x00385144
		private void GeraDataGridView_Vazoes()
		{
			this.DataGridView_vazoes_RT820.Columns.Clear();
			this.DataGridView_vazoes_RT820.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			this.DataGridView_vazoes_RT820.DefaultCellStyle.Alignment =(System.Windows.Forms.DataGridViewContentAlignment)64;
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

		// Token: 0x06001878 RID: 6264 RVA: 0x00386E80 File Offset: 0x00385280
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
				int num = 0;
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
				int num3 = Convert.ToInt32(num);
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

		// Token: 0x06001879 RID: 6265 RVA: 0x00387090 File Offset: 0x00385490
		private void GeraDataGridView_ED()
		{
			this.DataGridView_RT820_ED.Columns.Clear();
			this.DataGridView_RT820_ED.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			this.DataGridView_RT820_ED.DefaultCellStyle.Alignment =(System.Windows.Forms.DataGridViewContentAlignment)64;
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
				if (RT_geral.RT_820_BD.HabExpIO.Valor == 21857)
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

		// Token: 0x0600187A RID: 6266 RVA: 0x003871F0 File Offset: 0x003855F0
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
				RT_geral.RT_820_DataGrigViewEDColunas[0].AlingColuna = 32;
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

		// Token: 0x0600187B RID: 6267 RVA: 0x0038737C File Offset: 0x0038577C
		private void GeraDataGridView_Repedidora()
		{
			this.DataGridView_end_rep_RT820.Columns.Clear();
			this.DataGridView_end_rep_RT820.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			this.DataGridView_end_rep_RT820.DefaultCellStyle.Alignment =(System.Windows.Forms.DataGridViewContentAlignment)64;
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

		// Token: 0x0600187C RID: 6268 RVA: 0x003874E0 File Offset: 0x003858E0
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

		// Token: 0x0600187D RID: 6269 RVA: 0x00387800 File Offset: 0x00385C00
		private void GeraDataGridView_Setpoints()
		{
			this.DataGridView_setpoints_820.Columns.Clear();
			this.DataGridView_setpoints_820.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			this.DataGridView_setpoints_820.DefaultCellStyle.Alignment =(System.Windows.Forms.DataGridViewContentAlignment)64;
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

		// Token: 0x0600187E RID: 6270 RVA: 0x0038793C File Offset: 0x00385D3C
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

		// Token: 0x0600187F RID: 6271 RVA: 0x00387DE4 File Offset: 0x003861E4
		private void GeraDataGridView_Timer()
		{
			this.DataGridView_timer_RT820.Columns.Clear();
			this.DataGridView_timer_RT820.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			this.DataGridView_timer_RT820.DefaultCellStyle.Alignment =(System.Windows.Forms.DataGridViewContentAlignment)64;
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

		// Token: 0x06001880 RID: 6272 RVA: 0x00387F20 File Offset: 0x00386320
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

		// Token: 0x06001881 RID: 6273 RVA: 0x003883E8 File Offset: 0x003867E8
		public void Inicializa_DadosEStruturaRT820_Padrao()
		{
			RT_geral.RT_820_BD.Versao.nome = "Versão";
			RT_geral.RT_820_BD.Versao.Padrao = 0;
			RT_geral.RT_820_BD.Build.nome = "Build";
			RT_geral.RT_820_BD.Build.Padrao = 0;
			RT_geral.RT_820_BD.Release.nome = "Release";
			RT_geral.RT_820_BD.Release.Padrao = 0;
			RT_geral.RT_820_BD.Equip.nome = "Tipo equipamento";
			RT_geral.RT_820_BD.Equip.Padrao = 0;
			RT_geral.RT_820_BD.End_estacao.nome = "Endereço Estação";
			RT_geral.RT_820_BD.End_estacao.Padrao = 1;
			RT_geral.RT_820_BD.End_estacao.Lmte_inf = 0;
			RT_geral.RT_820_BD.End_estacao.Lmte_sup = 200;
			RT_geral.RT_820_BD.End_mestre.nome = "Endereço Mestre";
			RT_geral.RT_820_BD.End_mestre.Padrao = 100;
			RT_geral.RT_820_BD.End_mestre.Lmte_inf = 1;
			RT_geral.RT_820_BD.End_mestre.Lmte_sup = 200;
			RT_geral.RT_820_BD.TempoForaAr.nome = "Tempo Fora Ar";
			RT_geral.RT_820_BD.TempoForaAr.Padrao = 0;
			RT_geral.RT_820_BD.TempoForaAr.Lmte_inf = 0;
			RT_geral.RT_820_BD.TempoForaAr.Lmte_sup = 1800;
			RT_geral.RT_820_BD.Tempo_ptt.nome = "Tempo PTT";
			RT_geral.RT_820_BD.Tempo_ptt.Padrao = 200;
			RT_geral.RT_820_BD.Tempo_ptt.Lmte_inf = 100;
			RT_geral.RT_820_BD.Tempo_ptt.Lmte_sup = 2000;
			RT_geral.RT_820_BD.BaudRateCOM2.nome = "Baudrate COM2";
			RT_geral.RT_820_BD.BaudRateCOM2.Numero_itens = perifericos.ListaBaudRate.Count;
			RT_geral.RT_820_BD.BaudRateCOM2.Indice_padrao = 0;
			int num = 0;
			checked
			{
				int num2 = perifericos.ListaBaudRate.Count - 1;
				int i;
				for (i = num; i <= num2; i++)
				{
					RT_geral.RT_820_BD.BaudRateCOM2.itens[i] = perifericos.ListaBaudRate[i].nome;
					RT_geral.RT_820_BD.BaudRateCOM2.valores[i] = perifericos.ListaBaudRate[i].valor;
					if (perifericos.ListaBaudRate[i].is_default)
					{
						RT_geral.RT_820_BD.BaudRateCOM2.Indice_padrao = i;
					}
				}
				RT_geral.RT_820_BD.BaudRateCOM1.nome = "Baudrate COM1";
				RT_geral.RT_820_BD.BaudRateCOM1.Numero_itens = perifericos.ListaBaudRate.Count;
				RT_geral.RT_820_BD.BaudRateCOM1.Indice_padrao = 0;
				int num3 = 0;
				int num4 = perifericos.ListaBaudRate.Count - 1;
				for (i = num3; i <= num4; i++)
				{
					RT_geral.RT_820_BD.BaudRateCOM1.itens[i] = perifericos.ListaBaudRate[i].nome;
					RT_geral.RT_820_BD.BaudRateCOM1.valores[i] = perifericos.ListaBaudRate[i].valor;
					if (perifericos.ListaBaudRate[i].is_default)
					{
						RT_geral.RT_820_BD.BaudRateCOM1.Indice_padrao = i;
					}
				}
				RT_geral.RT_820_BD.HabExpIO.nome = "Habilita Expansão I/O";
				RT_geral.RT_820_BD.HabExpIO.Padrao = 21856;
				RT_geral.RT_820_BD.HabExpIO.Lmte_inf = 21856;
				RT_geral.RT_820_BD.HabExpIO.Lmte_sup = 21857;
				i = 0;
				do
				{
					RT_geral.RT_820_BD.ctrl_acionamento[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - SD acinamento";
					RT_geral.RT_820_BD.ctrl_acionamento[i].Indice_padrao = 0;
					RT_geral.RT_820_BD.ctrl_desligamento[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - SD desacionamento";
					RT_geral.RT_820_BD.ctrl_desligamento[i].Indice_padrao = 0;
					RT_geral.RT_820_BD.ctrl_ret_acionamento[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - ED acionamento";
					RT_geral.RT_820_BD.ctrl_ret_acionamento[i].Indice_padrao = 0;
					RT_geral.RT_820_BD.ctrl_ret_desligamento[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - ED desacionamento";
					RT_geral.RT_820_BD.ctrl_ret_desligamento[i].Indice_padrao = 0;
					RT_geral.RT_820_BD.ctrl_ED_selecao[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - ED Remoto";
					RT_geral.RT_820_BD.ctrl_ED_selecao[i].Indice_padrao = 0;
					RT_geral.RT_820_BD.ctrl_ED_bloqueio[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - ED bloqueio";
					RT_geral.RT_820_BD.ctrl_ED_bloqueio[i].Indice_padrao = 0;
					RT_geral.RT_820_BD.ctrl_ED_liberacao[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - ED liberação";
					RT_geral.RT_820_BD.ctrl_ED_liberacao[i].Indice_padrao = 0;
					RT_geral.RT_820_BD.ctrl_reverso[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Reverso ";
					RT_geral.RT_820_BD.ctrl_reverso[i].Indice_padrao = 0;
					RT_geral.RT_820_BD.ctrl_modo[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Modo ";
					RT_geral.RT_820_BD.ctrl_modo[i].Indice_padrao = 0;
					RT_geral.RT_820_BD.ctrl_agrupamento[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Agrupamentos ";
					RT_geral.RT_820_BD.ctrl_agrupamento[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 7);
				i = 0;
				do
				{
					RT_geral.RT_820_BD.ctrl_tempo_max_partida[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Tempo máx partida";
					RT_geral.RT_820_BD.ctrl_tempo_max_partida[i].Padrao = 180;
					RT_geral.RT_820_BD.ctrl_tempo_max_partida[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.ctrl_tempo_max_partida[i].Lmte_sup = 1200;
					RT_geral.RT_820_BD.ctrl_tempo_max_parada[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Tempo máx parada";
					RT_geral.RT_820_BD.ctrl_tempo_max_parada[i].Padrao = 180;
					RT_geral.RT_820_BD.ctrl_tempo_max_parada[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.ctrl_tempo_max_parada[i].Lmte_sup = 1200;
					RT_geral.RT_820_BD.ctrl_tempo_min_operando[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Tempo min operando";
					RT_geral.RT_820_BD.ctrl_tempo_min_operando[i].Padrao = 180;
					RT_geral.RT_820_BD.ctrl_tempo_min_operando[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.ctrl_tempo_min_operando[i].Lmte_sup = 1200;
					RT_geral.RT_820_BD.ctrl_tempo_min_parado[i].nome = "Ctrl " + Conversion.Str(i + 1) + " - Tempo min parado";
					RT_geral.RT_820_BD.ctrl_tempo_min_parado[i].Padrao = 180;
					RT_geral.RT_820_BD.ctrl_tempo_min_parado[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.ctrl_tempo_min_parado[i].Lmte_sup = 1200;
					i++;
				}
				while (i <= 7);
				i = 0;
				do
				{
					RT_geral.RT_820_BD.grupo_simultaneos[i].nome = "Grupo " + Conversion.Str(i + 1) + " - Simultâneos ";
					RT_geral.RT_820_BD.grupo_simultaneos[i].Indice_padrao = 1;
					RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos[i].nome = "Grupo " + Conversion.Str(i + 1) + " - Tempo entre acionamentos";
					RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos[i].Padrao = 120;
					RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos[i].Lmte_sup = 1200;
					i++;
				}
				while (i <= 4);
				i = 0;
				do
				{
					RT_geral.RT_820_BD.EA_Range[i].nome = "Range sensor " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.EA_Range[i].Padrao = 4000;
					RT_geral.RT_820_BD.EA_Range[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.EA_Range[i].Lmte_sup = 4000;
					RT_geral.RT_820_BD.EA_Inicio[i].nome = "Início sensor " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.EA_Inicio[i].Padrao = 0;
					RT_geral.RT_820_BD.EA_Inicio[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.EA_Inicio[i].Lmte_sup = 20000;
					RT_geral.RT_820_BD.EA_Fim[i].nome = "Fim sensor " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.EA_Fim[i].Padrao = 4000;
					RT_geral.RT_820_BD.EA_Fim[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.EA_Fim[i].Lmte_sup = 50000;
					i++;
				}
				while (i <= 16);
				RT_geral.RT_820_BD.AD_Intervalo.nome = "Intervalo AD";
				RT_geral.RT_820_BD.AD_Intervalo.Padrao = 2000;
				RT_geral.RT_820_BD.AD_Intervalo.Lmte_inf = 500;
				RT_geral.RT_820_BD.AD_Intervalo.Lmte_sup = 20000;
				RT_geral.RT_820_BD.AD_Tamanho_filtro.nome = "Tamanho Filtro AD";
				RT_geral.RT_820_BD.AD_Tamanho_filtro.Padrao = 3;
				RT_geral.RT_820_BD.AD_Tamanho_filtro.Lmte_inf = 1;
				RT_geral.RT_820_BD.AD_Tamanho_filtro.Lmte_sup = 10;
				i = 0;
				do
				{
					RT_geral.RT_820_BD.config_ED[i].nome = "ED " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_ED[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 15);
				RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.nome = "Tratamenro do Setpoint Percentual";
				RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor = 0;
				RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Lmte_inf = 0;
				RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Lmte_sup = 1;
				i = 0;
				do
				{
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[i].nome = "Setpoint Alto " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[i].Padrao = 4000;
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[i].Lmte_sup = 4000;
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[i].nome = "Setpoint Baixo " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[i].Padrao = 0;
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[i].Lmte_sup = 4000;
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[i].nome = "Setpoint Bloqueio " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[i].Padrao = 400;
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[i].Lmte_sup = 4000;
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[i].nome = "Setpoint Liberação " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[i].Padrao = 800;
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[i].Lmte_sup = 4000;
					i++;
				}
				while (i <= 8);
				i = 0;
				do
				{
					RT_geral.RT_820_BD.Setpoints_ctrl_variavel[i].nome = "Setpoint " + Conversion.Str(i + 1) + "Variável de Controle";
					RT_geral.RT_820_BD.Setpoints_ctrl_variavel[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 8);
				i = 0;
				do
				{
					RT_geral.RT_820_BD.Setpoints_ctrl_bloqueio[i].nome = "Setpoint " + Conversion.Str(i + 1) + "Variável de Bloqueio";
					RT_geral.RT_820_BD.Setpoints_ctrl_bloqueio[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 8);
				i = 0;
				do
				{
					RT_geral.RT_820_BD.setpoint_horario[i].Hora.nome = "Hora";
					RT_geral.RT_820_BD.setpoint_horario[i].Hora.Padrao = 0;
					RT_geral.RT_820_BD.setpoint_horario[i].Hora.Lmte_inf = 0;
					RT_geral.RT_820_BD.setpoint_horario[i].Hora.Lmte_sup = 23;
					RT_geral.RT_820_BD.setpoint_horario[i].Minuto.nome = "Minuto";
					RT_geral.RT_820_BD.setpoint_horario[i].Minuto.Padrao = 0;
					RT_geral.RT_820_BD.setpoint_horario[i].Minuto.Lmte_inf = 0;
					RT_geral.RT_820_BD.setpoint_horario[i].Minuto.Lmte_sup = 59;
					RT_geral.RT_820_BD.setpoint_horario[i].Alto.nome = "Alto";
					RT_geral.RT_820_BD.setpoint_horario[i].Alto.Padrao = 4000;
					RT_geral.RT_820_BD.setpoint_horario[i].Alto.Lmte_inf = 0;
					RT_geral.RT_820_BD.setpoint_horario[i].Alto.Lmte_sup = 4000;
					RT_geral.RT_820_BD.setpoint_horario[i].Baixo.nome = "Alto";
					RT_geral.RT_820_BD.setpoint_horario[i].Baixo.Padrao = 0;
					RT_geral.RT_820_BD.setpoint_horario[i].Baixo.Lmte_inf = 0;
					RT_geral.RT_820_BD.setpoint_horario[i].Baixo.Lmte_sup = 4000;
					i++;
				}
				while (i <= 15);
				i = 0;
				do
				{
					RT_geral.RT_820_BD.config_vazao[i].nome = "Vazão " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_vazao[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 7);
				i = 0;
				do
				{
					RT_geral.RT_820_BD.config_perifericos_mod[i].nome = "Periférico " + Conversion.Str(i + 1) + " - Modelo ";
					RT_geral.RT_820_BD.config_perifericos_mod[i].Indice_padrao = 0;
					RT_geral.RT_820_BD.config_perifericos_end[i].nome = "Periférico " + Conversion.Str(i + 1) + " - Endereço ";
					RT_geral.RT_820_BD.config_perifericos_end[i].Valor = 0;
					RT_geral.RT_820_BD.config_perifericos_end[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_perifericos_end[i].Lmte_sup = 255;
					i++;
				}
				while (i <= 5);
				i = 0;
				do
				{
					RT_geral.RT_820_BD.config_referencia_perif_periferico[i].nome = "Ref Perif Perif" + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_referencia_perif_periferico[i].Indice_padrao = 0;
					RT_geral.RT_820_BD.config_referencia_perif_memoria[i].nome = "Ref Perif Memória" + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_referencia_perif_memoria[i].Padrao = 0;
					RT_geral.RT_820_BD.config_referencia_perif_memoria[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_referencia_perif_memoria[i].Lmte_sup = 65535;
					RT_geral.RT_820_BD.config_referencia_perif_variavel1[i].nome = "Ref Perif Variavel1" + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_referencia_perif_variavel1[i].Indice_padrao = 0;
					RT_geral.RT_820_BD.config_referencia_perif_variavel2[i].nome = "Ref Perif Variavel2" + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_referencia_perif_variavel2[i].Indice_padrao = 0;
					RT_geral.RT_820_BD.config_referencia_perif_escala[i].nome = "Ref Perif Escala" + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_referencia_perif_escala[i].Padrao = 4000;
					RT_geral.RT_820_BD.config_referencia_perif_escala[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_referencia_perif_escala[i].Lmte_sup = 4000;
					RT_geral.RT_820_BD.config_referencia_perif_formato[i].nome = "Ref Perif Formato" + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_referencia_perif_formato[i].Indice_padrao = 0;
					RT_geral.RT_820_BD.config_referencia_perif_base10[i].nome = "Ref Perif Base10" + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_referencia_perif_base10[i].Indice_padrao = 0;
					i++;
				}
				while (i <= 9);
				RT_geral.RT_820_BD.config_atuador1_perif[0].nome = "Atuador1 Perif";
				RT_geral.RT_820_BD.config_atuador1_perif[0].Indice_padrao = 0;
				RT_geral.RT_820_BD.config_atuador1_mem[0].nome = "Atuador1 Memoria";
				RT_geral.RT_820_BD.config_atuador1_mem[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador1_mem[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador1_mem[0].Lmte_sup = 65535;
				RT_geral.RT_820_BD.config_atuador1_var1[0].nome = "Atuador1 Var1";
				RT_geral.RT_820_BD.config_atuador1_var1[0].Indice_padrao = 0;
				RT_geral.RT_820_BD.config_atuador1_escala1[0].nome = "Atuador1 Escala1";
				RT_geral.RT_820_BD.config_atuador1_escala1[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador1_escala1[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador1_escala1[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador1_var2[0].nome = "Atuador1 Var2";
				RT_geral.RT_820_BD.config_atuador1_var2[0].Indice_padrao = 0;
				RT_geral.RT_820_BD.config_atuador1_escala2[0].nome = "Atuador1 Escala2";
				RT_geral.RT_820_BD.config_atuador1_escala2[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador1_escala2[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador1_escala2[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador1_histerese[0].nome = "Atuador1 Histerese";
				RT_geral.RT_820_BD.config_atuador1_histerese[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador1_histerese[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador1_histerese[0].Lmte_sup = 30000;
				RT_geral.RT_820_BD.config_atuador1_formato[0].nome = "Atuador1 Formato";
				RT_geral.RT_820_BD.config_atuador1_formato[0].Indice_padrao = 0;
				RT_geral.RT_820_BD.config_atuador1_base10[0].nome = "Atuador1 Base10";
				RT_geral.RT_820_BD.config_atuador1_base10[0].Indice_padrao = 0;
				i = 0;
				do
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[i].nome = "Atuador1 Variável1 Hora" + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[i].Lmte_sup = 23;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[i].nome = "Atuador1 Variável1 Minuto" + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[i].Lmte_sup = 59;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[i].nome = "Atuador1 Variável1 Referência1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[i].nome = "Atuador1 Variável1 Referência2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[i].nome = "Atuador1 Variável1 Referência3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[i].nome = "Atuador1 Variável1 Referência4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[i].nome = "Atuador1 Variável1 Referência5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[i].nome = "Atuador1 Variável1 Referência6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[i].nome = "Atuador1 Variável1 Setpoint1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[i].nome = "Atuador1 Variável1 Setpoint2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[i].nome = "Atuador1 Variável1 Setpoint3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[i].nome = "Atuador1 Variável1 Setpoint4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[i].nome = "Atuador1 Variável1 Setpoint5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[i].nome = "Atuador1 Variável1 Setpoint6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[i].Lmte_sup = 32767;
					i++;
				}
				while (i <= 2);
				i = 0;
				do
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[i].nome = "Atuador1 Variável2 Referência1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[i].nome = "Atuador1 Variável2 Referência2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[i].nome = "Atuador1 Variável2 Referência3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[i].nome = "Atuador1 Variável2 Referência4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[i].nome = "Atuador1 Variável2 Referência5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[i].nome = "Atuador1 Variável2 Referência6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[i].nome = "Atuador1 Variável2 Setpoint1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[i].nome = "Atuador1 Variável2 Setpoint2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[i].nome = "Atuador1 Variável2 Setpoint3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[i].nome = "Atuador1 Variável2 Setpoint4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[i].nome = "Atuador1 Variável2 Setpoint5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[i].nome = "Atuador1 Variável2 Setpoint6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[i].Lmte_sup = 32767;
					i++;
				}
				while (i <= 2);
				RT_geral.RT_820_BD.config_atuador1_v1baixo[0].nome = "Atuador1 V1 Baixo";
				RT_geral.RT_820_BD.config_atuador1_v1baixo[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador1_v1baixo[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador1_v1baixo[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador1_v1alto[0].nome = "Atuador1 V1 Alto";
				RT_geral.RT_820_BD.config_atuador1_v1alto[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador1_v1alto[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador1_v1alto[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador1_v2baixo[0].nome = "Atuador1 V1 Baixo";
				RT_geral.RT_820_BD.config_atuador1_v2baixo[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador1_v2baixo[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador1_v2baixo[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador1_v2alto[0].nome = "Atuador1 V1 Alto";
				RT_geral.RT_820_BD.config_atuador1_v2alto[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador1_v2alto[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador1_v2alto[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador2_perif[0].nome = "Atuador2 Perif";
				RT_geral.RT_820_BD.config_atuador2_perif[0].Indice_padrao = 0;
				RT_geral.RT_820_BD.config_atuador2_mem[0].nome = "Atuador2 Memoria";
				RT_geral.RT_820_BD.config_atuador2_mem[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador2_mem[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador2_mem[0].Lmte_sup = 65535;
				RT_geral.RT_820_BD.config_atuador2_var2[0].nome = "Atuador2 Var1";
				RT_geral.RT_820_BD.config_atuador2_var2[0].Indice_padrao = 0;
				RT_geral.RT_820_BD.config_atuador2_escala1[0].nome = "Atuador2 Escala1";
				RT_geral.RT_820_BD.config_atuador2_escala1[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador2_escala1[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador2_escala1[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador2_var2[0].nome = "Atuador2 Var2";
				RT_geral.RT_820_BD.config_atuador2_var2[0].Indice_padrao = 0;
				RT_geral.RT_820_BD.config_atuador2_escala2[0].nome = "Atuador2 Escala2";
				RT_geral.RT_820_BD.config_atuador2_escala2[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador2_escala2[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador2_escala2[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador2_histerese[0].nome = "Atuador2 Histerese";
				RT_geral.RT_820_BD.config_atuador2_histerese[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador2_histerese[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador2_histerese[0].Lmte_sup = 30000;
				RT_geral.RT_820_BD.config_atuador2_formato[0].nome = "Atuador2 Formato";
				RT_geral.RT_820_BD.config_atuador2_formato[0].Indice_padrao = 0;
				RT_geral.RT_820_BD.config_atuador2_base10[0].nome = "Atuador2 Base10";
				RT_geral.RT_820_BD.config_atuador2_base10[0].Indice_padrao = 0;
				i = 0;
				do
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[i].nome = "Atuador2 Variável1 Hora" + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[i].Lmte_sup = 23;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[i].nome = "Atuador2 Variável1 Minuto" + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[i].Lmte_sup = 59;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[i].nome = "Atuador2 Variável1 Referência1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[i].nome = "Atuador2 Variável1 Referência2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[i].nome = "Atuador2 Variável1 Referência3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[i].nome = "Atuador2 Variável1 Referência4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[i].nome = "Atuador2 Variável1 Referência5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[i].nome = "Atuador2 Variável1 Referência6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[i].nome = "Atuador2 Variável1 Setpoint1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[i].nome = "Atuador2 Variável1 Setpoint2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[i].nome = "Atuador2 Variável1 Setpoint3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[i].nome = "Atuador2 Variável1 Setpoint4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[i].nome = "Atuador2 Variável1 Setpoint5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[i].nome = "Atuador2 Variável1 Setpoint6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[i].Lmte_sup = 32767;
					i++;
				}
				while (i <= 2);
				i = 0;
				do
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[i].nome = "Atuador2 Variável2 Referência1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[i].nome = "Atuador2 Variável2 Referência2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[i].nome = "Atuador2 Variável2 Referência3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[i].nome = "Atuador2 Variável2 Referência4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[i].nome = "Atuador2 Variável2 Referência5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[i].nome = "Atuador2 Variável2 Referência6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[i].nome = "Atuador2 Variável2 Setpoint1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[i].nome = "Atuador2 Variável2 Setpoint2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[i].nome = "Atuador2 Variável2 Setpoint3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[i].nome = "Atuador2 Variável2 Setpoint4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[i].nome = "Atuador2 Variável2 Setpoint5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[i].nome = "Atuador2 Variável2 Setpoint6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[i].Lmte_sup = 32767;
					i++;
				}
				while (i <= 2);
				RT_geral.RT_820_BD.config_atuador2_v1baixo[0].nome = "Atuador1 V1 Baixo";
				RT_geral.RT_820_BD.config_atuador2_v1baixo[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador2_v1baixo[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador2_v1baixo[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador2_v1alto[0].nome = "Atuador1 V1 Alto";
				RT_geral.RT_820_BD.config_atuador2_v1alto[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador2_v1alto[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador2_v1alto[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador2_v2baixo[0].nome = "Atuador1 V1 Baixo";
				RT_geral.RT_820_BD.config_atuador2_v2baixo[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador2_v2baixo[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador2_v2baixo[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador2_v2alto[0].nome = "Atuador1 V1 Alto";
				RT_geral.RT_820_BD.config_atuador2_v2alto[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador2_v2alto[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador2_v2alto[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador3_perif[0].nome = "Atuador3 Perif";
				RT_geral.RT_820_BD.config_atuador3_perif[0].Indice_padrao = 0;
				RT_geral.RT_820_BD.config_atuador3_mem[0].nome = "Atuador3 Memoria";
				RT_geral.RT_820_BD.config_atuador3_mem[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador3_mem[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador3_mem[0].Lmte_sup = 65535;
				RT_geral.RT_820_BD.config_atuador3_var1[0].nome = "Atuador3 Var1";
				RT_geral.RT_820_BD.config_atuador3_var1[0].Indice_padrao = 0;
				RT_geral.RT_820_BD.config_atuador3_escala1[0].nome = "Atuador3 Escala1";
				RT_geral.RT_820_BD.config_atuador3_escala1[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador3_escala1[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador3_escala1[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador3_var2[0].nome = "Atuador3 Var2";
				RT_geral.RT_820_BD.config_atuador3_var2[0].Indice_padrao = 0;
				RT_geral.RT_820_BD.config_atuador3_escala2[0].nome = "Atuador3 Escala2";
				RT_geral.RT_820_BD.config_atuador3_escala2[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador3_escala2[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador3_escala2[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador3_histerese[0].nome = "Atuador3 Histerese";
				RT_geral.RT_820_BD.config_atuador3_histerese[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador3_histerese[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador3_histerese[0].Lmte_sup = 30000;
				RT_geral.RT_820_BD.config_atuador3_formato[0].nome = "Atuador3 Formato";
				RT_geral.RT_820_BD.config_atuador3_formato[0].Indice_padrao = 0;
				RT_geral.RT_820_BD.config_atuador3_base10[0].nome = "Atuador3 Base10";
				RT_geral.RT_820_BD.config_atuador3_base10[0].Indice_padrao = 0;
				i = 0;
				do
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[i].nome = "Atuador3 Variável1 Hora" + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[i].Lmte_sup = 23;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[i].nome = "Atuador3 Variável1 Minuto" + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[i].Lmte_sup = 59;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[i].nome = "Atuador3 Variável1 Referência1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[i].nome = "Atuador3 Variável1 Referência2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[i].nome = "Atuador3 Variável1 Referência3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[i].nome = "Atuador3 Variável1 Referência4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[i].nome = "Atuador3 Variável1 Referência5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[i].nome = "Atuador3 Variável1 Referência6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[i].nome = "Atuador3 Variável1 Setpoint1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[i].nome = "Atuador3 Variável1 Setpoint2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[i].nome = "Atuador3 Variável1 Setpoint3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[i].nome = "Atuador3 Variável1 Setpoint4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[i].nome = "Atuador3 Variável1 Setpoint5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[i].nome = "Atuador3 Variável1 Setpoint6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[i].Lmte_sup = 32767;
					i++;
				}
				while (i <= 2);
				i = 0;
				do
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[i].nome = "Atuador3 Variável2 Referência1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[i].nome = "Atuador3 Variável2 Referência2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[i].nome = "Atuador3 Variável2 Referência3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[i].nome = "Atuador3 Variável2 Referência4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[i].nome = "Atuador3 Variável2 Referência5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[i].nome = "Atuador3 Variável2 Referência6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[i].nome = "Atuador3 Variável2 Setpoint1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[i].nome = "Atuador3 Variável2 Setpoint2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[i].nome = "Atuador3 Variável2 Setpoint3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[i].nome = "Atuador3 Variável2 Setpoint4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[i].nome = "Atuador3 Variável2 Setpoint5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[i].nome = "Atuador3 Variável2 Setpoint6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[i].Lmte_sup = 32767;
					i++;
				}
				while (i <= 2);
				RT_geral.RT_820_BD.config_atuador3_v1baixo[0].nome = "Atuador3 V1 Baixo";
				RT_geral.RT_820_BD.config_atuador3_v1baixo[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador3_v1baixo[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador3_v1baixo[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador3_v1alto[0].nome = "Atuador3 V1 Alto";
				RT_geral.RT_820_BD.config_atuador3_v1alto[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador3_v1alto[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador3_v1alto[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador3_v2baixo[0].nome = "Atuador3 V1 Baixo";
				RT_geral.RT_820_BD.config_atuador3_v2baixo[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador3_v2baixo[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador3_v2baixo[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador3_v2alto[0].nome = "Atuador3 V1 Alto";
				RT_geral.RT_820_BD.config_atuador3_v2alto[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador3_v2alto[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador3_v2alto[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador4_perif[0].nome = "Atuador4 Perif";
				RT_geral.RT_820_BD.config_atuador4_perif[0].Indice_padrao = 0;
				RT_geral.RT_820_BD.config_atuador4_mem[0].nome = "Atuador4 Memoria";
				RT_geral.RT_820_BD.config_atuador4_mem[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador4_mem[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador4_mem[0].Lmte_sup = 65535;
				RT_geral.RT_820_BD.config_atuador4_var1[0].nome = "Atuador4 Var1";
				RT_geral.RT_820_BD.config_atuador4_var1[0].Indice_padrao = 0;
				RT_geral.RT_820_BD.config_atuador4_escala1[0].nome = "Atuador4 Escala1";
				RT_geral.RT_820_BD.config_atuador4_escala1[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador4_escala1[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador4_escala1[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador4_var2[0].nome = "Atuador4 Var2";
				RT_geral.RT_820_BD.config_atuador4_var2[0].Indice_padrao = 0;
				RT_geral.RT_820_BD.config_atuador4_escala2[0].nome = "Atuador4 Escala2";
				RT_geral.RT_820_BD.config_atuador4_escala2[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador4_escala2[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador4_escala2[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador4_histerese[0].nome = "Atuador4 Histerese";
				RT_geral.RT_820_BD.config_atuador4_histerese[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador4_histerese[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador4_histerese[0].Lmte_sup = 30000;
				RT_geral.RT_820_BD.config_atuador4_formato[0].nome = "Atuador4 Formato";
				RT_geral.RT_820_BD.config_atuador4_formato[0].Indice_padrao = 0;
				RT_geral.RT_820_BD.config_atuador4_base10[0].nome = "Atuador4 Base10";
				RT_geral.RT_820_BD.config_atuador4_base10[0].Indice_padrao = 0;
				i = 0;
				do
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[i].nome = "Atuador4 Variável1 Hora" + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[i].Lmte_sup = 23;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[i].nome = "Atuador4 Variável1 Minuto" + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[i].Lmte_sup = 59;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[i].nome = "Atuador4 Variável1 Referência1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[i].nome = "Atuador4 Variável1 Referência2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[i].nome = "Atuador4 Variável1 Referência3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[i].nome = "Atuador4 Variável1 Referência4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[i].nome = "Atuador4 Variável1 Referência5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[i].nome = "Atuador4 Variável1 Referência6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[i].nome = "Atuador4 Variável1 Setpoint1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[i].nome = "Atuador4 Variável1 Setpoint2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[i].nome = "Atuador4 Variável1 Setpoint3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[i].nome = "Atuador4 Variável1 Setpoint4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[i].nome = "Atuador4 Variável1 Setpoint5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[i].nome = "Atuador4 Variável1 Setpoint6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[i].Lmte_sup = 32767;
					i++;
				}
				while (i <= 2);
				i = 0;
				do
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[i].nome = "Atuador4 Variável2 Referência1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[i].nome = "Atuador4 Variável2 Referência2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[i].nome = "Atuador4 Variável2 Referência3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[i].nome = "Atuador4 Variável2 Referência4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[i].nome = "Atuador4 Variável2 Referência5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[i].nome = "Atuador4 Variável2 Referência6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[i].Lmte_sup = 10000;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[i].nome = "Atuador4 Variável2 Setpoint1 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[i].nome = "Atuador4 Variável2 Setpoint2 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[i].nome = "Atuador4 Variável2 Setpoint3 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[i].nome = "Atuador4 Variável2 Setpoint4 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[i].nome = "Atuador4 Variável2 Setpoint5 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[i].Lmte_sup = 32767;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[i].nome = "Atuador4 Variável2 Setpoint6 " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[i].Padrao = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[i].Lmte_sup = 32767;
					i++;
				}
				while (i <= 2);
				RT_geral.RT_820_BD.config_atuador4_v1baixo[0].nome = "Atuador4 V1 Baixo";
				RT_geral.RT_820_BD.config_atuador4_v1baixo[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador4_v1baixo[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador4_v1baixo[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador4_v1alto[0].nome = "Atuador4 V1 Alto";
				RT_geral.RT_820_BD.config_atuador4_v1alto[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador4_v1alto[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador4_v1alto[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador4_v2baixo[0].nome = "Atuador4 V1 Baixo";
				RT_geral.RT_820_BD.config_atuador4_v2baixo[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador4_v2baixo[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador4_v2baixo[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.config_atuador4_v2alto[0].nome = "Atuador4 V1 Alto";
				RT_geral.RT_820_BD.config_atuador4_v2alto[0].Padrao = 0;
				RT_geral.RT_820_BD.config_atuador4_v2alto[0].Lmte_inf = 0;
				RT_geral.RT_820_BD.config_atuador4_v2alto[0].Lmte_sup = 10000;
				RT_geral.RT_820_BD.modo_repetidora.nome = "Modo de Repetidora";
				RT_geral.RT_820_BD.modo_repetidora.Indice_padrao = 0;
				RT_geral.RT_820_BD.modo_repetidora.Numero_itens = 2;
				RT_geral.RT_820_BD.modo_repetidora.valores[0] = 21856;
				RT_geral.RT_820_BD.modo_repetidora.valores[1] = 21857;
				RT_geral.RT_820_BD.modo_repetidora.itens[0] = "Desabilitado";
				RT_geral.RT_820_BD.modo_repetidora.itens[1] = "Direto";
				RT_geral.RT_820_BD.End_repetidora.nome = "Endereço Repetidora";
				RT_geral.RT_820_BD.End_repetidora.Padrao = 1;
				RT_geral.RT_820_BD.End_repetidora.Lmte_inf = 0;
				RT_geral.RT_820_BD.End_repetidora.Lmte_sup = 200;
				RT_geral.RT_820_BD.Num_repetidoras.nome = "Número de Repetidoras";
				RT_geral.RT_820_BD.Num_repetidoras.Padrao = 0;
				RT_geral.RT_820_BD.Num_repetidoras.Lmte_inf = 0;
				RT_geral.RT_820_BD.Num_repetidoras.Lmte_sup = 50;
				i = 0;
				do
				{
					RT_geral.RT_820_BD.Repetidoras[i].nome = "Endereço da Repetidora " + Conversion.Str(i + 1);
					RT_geral.RT_820_BD.Repetidoras[i].Padrao = 0;
					RT_geral.RT_820_BD.Repetidoras[i].Lmte_inf = 0;
					RT_geral.RT_820_BD.Repetidoras[i].Lmte_sup = 200;
					i++;
				}
				while (i <= 50);
				int num5 = 0;
				do
				{
					int num6 = 0;
					do
					{
						RT_geral.RT_820_BD.Timer_Horario[num5][num6].nome = "Timer - Ctrl " + Conversion.Str(num5 + 1);
						RT_geral.RT_820_BD.Timer_Horario[num5][num6].Padrao = 0;
						RT_geral.RT_820_BD.Timer_Horario[num5][num6].Lmte_inf = 0;
						RT_geral.RT_820_BD.Timer_Horario[num5][num6].Lmte_sup = 1439;
						num6++;
					}
					while (num6 <= 11);
					num5++;
				}
				while (num5 <= 7);
			}
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x0038D7DC File Offset: 0x0038BBDC
		public void Inicializa_DadosEStruturaRT820_Default()
		{
			RT_geral.RT_820_BD.TempoForaAr.ValorPadrao();
			RT_geral.RT_820_BD.End_estacao.Valor = RT_geral.RT_820_BD.End_estacao.Padrao;
			RT_geral.RT_820_BD.End_mestre.Valor = RT_geral.RT_820_BD.End_mestre.Padrao;
			RT_geral.RT_820_BD.Tempo_ptt.Valor = RT_geral.RT_820_BD.Tempo_ptt.Padrao;
			RT_geral.RT_820_BD.BaudRateCOM2.Indice = perifericos.Lista_GetIndicePadrao(perifericos.ListaBaudRate);
			RT_geral.RT_820_BD.BaudRateCOM2.AtualizaValorPeloIndice();
			RT_geral.RT_820_BD.BaudRateCOM1.Indice = perifericos.Lista_GetIndicePadrao(perifericos.ListaBaudRate);
			RT_geral.RT_820_BD.BaudRateCOM1.AtualizaValorPeloIndice();
			RT_geral.RT_820_BD.HabExpIO.Valor = RT_geral.RT_820_BD.HabExpIO.Padrao;
			this.TextBox_comentarios_RT820.Text = "";
			this.TextBox_endereco_RT820.Text = "";
			this.TextBox_nome_RT820.Text = "";
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_BD.ctrl_acionamento[num].Indice = RT_geral.RT_820_BD.ctrl_acionamento[num].Indice_padrao;
					RT_geral.RT_820_BD.ctrl_acionamento[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasValor[RT_geral.RT_820_BD.ctrl_acionamento[num].Indice];
					RT_geral.RT_820_BD.ctrl_desligamento[num].Indice = RT_geral.RT_820_BD.ctrl_desligamento[num].Indice_padrao;
					RT_geral.RT_820_BD.ctrl_desligamento[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasValor[RT_geral.RT_820_BD.ctrl_desligamento[num].Indice];
					RT_geral.RT_820_BD.ctrl_ret_acionamento[num].Indice = RT_geral.RT_820_BD.ctrl_ret_acionamento[num].Indice_padrao;
					RT_geral.RT_820_BD.ctrl_ret_acionamento[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasValor[RT_geral.RT_820_BD.ctrl_ret_acionamento[num].Indice];
					RT_geral.RT_820_BD.ctrl_ret_desligamento[num].Indice = RT_geral.RT_820_BD.ctrl_ret_desligamento[num].Indice_padrao;
					RT_geral.RT_820_BD.ctrl_ret_desligamento[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasValor[RT_geral.RT_820_BD.ctrl_ret_desligamento[num].Indice];
					RT_geral.RT_820_BD.ctrl_ED_selecao[num].Indice = RT_geral.RT_820_BD.ctrl_ED_selecao[num].Indice_padrao;
					RT_geral.RT_820_BD.ctrl_ED_selecao[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[4].LinhasValor[RT_geral.RT_820_BD.ctrl_ED_selecao[num].Indice];
					RT_geral.RT_820_BD.ctrl_ED_bloqueio[num].Indice = RT_geral.RT_820_BD.ctrl_ED_bloqueio[num].Indice_padrao;
					RT_geral.RT_820_BD.ctrl_ED_bloqueio[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasValor[RT_geral.RT_820_BD.ctrl_ED_bloqueio[num].Indice];
					RT_geral.RT_820_BD.ctrl_ED_liberacao[num].Indice = RT_geral.RT_820_BD.ctrl_ED_liberacao[num].Indice_padrao;
					RT_geral.RT_820_BD.ctrl_ED_liberacao[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[6].LinhasValor[RT_geral.RT_820_BD.ctrl_ED_liberacao[num].Indice];
					RT_geral.RT_820_BD.ctrl_reverso[num].Indice = RT_geral.RT_820_BD.ctrl_reverso[num].Indice_padrao;
					RT_geral.RT_820_BD.ctrl_reverso[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[7].LinhasValor[RT_geral.RT_820_BD.ctrl_reverso[num].Indice];
					RT_geral.RT_820_BD.ctrl_modo[num].Indice = RT_geral.RT_820_BD.ctrl_modo[num].Indice_padrao;
					RT_geral.RT_820_BD.ctrl_modo[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasValor[RT_geral.RT_820_BD.ctrl_modo[num].Indice];
					RT_geral.RT_820_BD.ctrl_agrupamento[num].Indice = RT_geral.RT_820_BD.ctrl_agrupamento[num].Indice_padrao;
					RT_geral.RT_820_BD.ctrl_agrupamento[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasValor[RT_geral.RT_820_BD.ctrl_agrupamento[num].Indice];
					RT_geral.RT_820_BD.ctrl_tempo_max_partida[num].Valor = RT_geral.RT_820_BD.ctrl_tempo_max_partida[num].Padrao;
					RT_geral.RT_820_BD.ctrl_tempo_max_parada[num].Valor = RT_geral.RT_820_BD.ctrl_tempo_max_parada[num].Padrao;
					RT_geral.RT_820_BD.ctrl_tempo_min_operando[num].Valor = RT_geral.RT_820_BD.ctrl_tempo_min_operando[num].Padrao;
					RT_geral.RT_820_BD.ctrl_tempo_min_parado[num].Valor = RT_geral.RT_820_BD.ctrl_tempo_min_parado[num].Padrao;
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					RT_geral.RT_820_BD.grupo_simultaneos[num].Indice = RT_geral.RT_820_BD.grupo_simultaneos[num].Indice_padrao;
					RT_geral.RT_820_BD.grupo_simultaneos[num].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasValor[RT_geral.RT_820_BD.grupo_simultaneos[num].Indice];
					RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos[num].Valor = RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos[num].Padrao;
					num++;
				}
				while (num <= 4);
				num = 0;
				do
				{
					RT_geral.RT_820_BD.EA_Range[num].Valor = RT_geral.RT_820_BD.EA_Range[num].Padrao;
					RT_geral.RT_820_BD.EA_Inicio[num].Valor = RT_geral.RT_820_BD.EA_Inicio[num].Padrao;
					RT_geral.RT_820_BD.EA_Fim[num].Valor = RT_geral.RT_820_BD.EA_Fim[num].Padrao;
					num++;
				}
				while (num <= 16);
				RT_geral.RT_820_BD.AD_Intervalo.Valor = RT_geral.RT_820_BD.AD_Intervalo.Padrao;
				RT_geral.RT_820_BD.AD_Tamanho_filtro.Valor = RT_geral.RT_820_BD.AD_Tamanho_filtro.Padrao;
				num = 0;
				do
				{
					RT_geral.RT_820_BD.config_ED[num].Indice = RT_geral.RT_820_BD.config_ED[num].Indice_padrao;
					RT_geral.RT_820_BD.config_ED[num].Valor = RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[RT_geral.RT_820_BD.config_ED[num].Indice];
					num++;
				}
				while (num <= 15);
				num = 0;
				do
				{
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[num].Valor = RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[num].Padrao;
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[num].Valor = RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[num].Padrao;
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[num].Valor = RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[num].Padrao;
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[num].Valor = RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[num].Padrao;
					RT_geral.RT_820_BD.Setpoints_ctrl_variavel[num].Indice = RT_geral.RT_820_BD.Setpoints_ctrl_variavel[num].Indice_padrao;
					RT_geral.RT_820_BD.Setpoints_ctrl_variavel[num].Valor = RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasValor[RT_geral.RT_820_BD.Setpoints_ctrl_variavel[num].Indice];
					RT_geral.RT_820_BD.Setpoints_ctrl_bloqueio[num].Indice = RT_geral.RT_820_BD.Setpoints_ctrl_bloqueio[num].Indice_padrao;
					RT_geral.RT_820_BD.Setpoints_ctrl_bloqueio[num].Valor = RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasValor[RT_geral.RT_820_BD.Setpoints_ctrl_bloqueio[num].Indice];
					num++;
				}
				while (num <= 8);
				num = 0;
				do
				{
					RT_geral.RT_820_BD.setpoint_horario[num].Hora.ValorPadrao();
					RT_geral.RT_820_BD.setpoint_horario[num].Minuto.ValorPadrao();
					RT_geral.RT_820_BD.setpoint_horario[num].Alto.ValorPadrao();
					RT_geral.RT_820_BD.setpoint_horario[num].Baixo.ValorPadrao();
					num++;
				}
				while (num <= 15);
				num = 0;
				do
				{
					RT_geral.RT_820_BD.config_vazao[num].Indice = RT_geral.RT_820_BD.config_vazao[num].Indice_padrao;
					RT_geral.RT_820_BD.config_vazao[num].Valor = RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[RT_geral.RT_820_BD.config_vazao[num].Indice];
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					RT_geral.RT_820_BD.config_perifericos_mod[num].Indice = RT_geral.RT_820_BD.config_perifericos_mod[num].Indice_padrao;
					RT_geral.RT_820_BD.config_perifericos_mod[num].Valor = RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[RT_geral.RT_820_BD.config_perifericos_mod[num].Indice];
					RT_geral.RT_820_BD.config_perifericos_end[num].Valor = RT_geral.RT_820_BD.config_perifericos_end[num].Padrao;
					num++;
				}
				while (num <= 5);
				num = 0;
				do
				{
					RT_geral.RT_820_BD.config_referencia_perif_periferico[num].Indice = RT_geral.RT_820_BD.config_referencia_perif_periferico[num].Indice_padrao;
					RT_geral.RT_820_BD.config_referencia_perif_periferico[num].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor[RT_geral.RT_820_BD.config_referencia_perif_periferico[num].Indice];
					RT_geral.RT_820_BD.config_referencia_perif_memoria[num].ValorPadrao();
					RT_geral.RT_820_BD.config_referencia_perif_variavel1[num].Indice = RT_geral.RT_820_BD.config_referencia_perif_variavel1[num].Indice_padrao;
					RT_geral.RT_820_BD.config_referencia_perif_variavel1[num].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasValor[RT_geral.RT_820_BD.config_referencia_perif_variavel1[num].Indice];
					RT_geral.RT_820_BD.config_referencia_perif_variavel2[num].Indice = RT_geral.RT_820_BD.config_referencia_perif_variavel2[num].Indice_padrao;
					RT_geral.RT_820_BD.config_referencia_perif_variavel2[num].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LinhasValor[RT_geral.RT_820_BD.config_referencia_perif_variavel2[num].Indice];
					RT_geral.RT_820_BD.config_referencia_perif_escala[num].ValorPadrao();
					RT_geral.RT_820_BD.config_referencia_perif_base10[num].Indice = RT_geral.RT_820_BD.config_referencia_perif_base10[num].Indice_padrao;
					RT_geral.RT_820_BD.config_referencia_perif_base10[num].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor[RT_geral.RT_820_BD.config_referencia_perif_formato[num].Indice];
					RT_geral.RT_820_BD.config_referencia_perif_formato[num].Indice = RT_geral.RT_820_BD.config_referencia_perif_formato[num].Indice_padrao;
					RT_geral.RT_820_BD.config_referencia_perif_formato[num].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor[RT_geral.RT_820_BD.config_referencia_perif_formato[num].Indice];
					num++;
				}
				while (num <= 9);
				num = 0;
				do
				{
					RT_geral.RT_820_BD.config_atuador1_perif[num].Indice = RT_geral.RT_820_BD.config_atuador1_perif[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador1_perif[num].Valor = RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasValor[RT_geral.RT_820_BD.config_atuador1_perif[num].Indice];
					RT_geral.RT_820_BD.config_atuador2_perif[num].Indice = RT_geral.RT_820_BD.config_atuador2_perif[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador2_perif[num].Valor = RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasValor[RT_geral.RT_820_BD.config_atuador2_perif[num].Indice];
					RT_geral.RT_820_BD.config_atuador3_perif[num].Indice = RT_geral.RT_820_BD.config_atuador3_perif[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador3_perif[num].Valor = RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasValor[RT_geral.RT_820_BD.config_atuador3_perif[num].Indice];
					RT_geral.RT_820_BD.config_atuador3_perif[num].Indice = RT_geral.RT_820_BD.config_atuador3_perif[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador3_perif[num].Valor = RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasValor[RT_geral.RT_820_BD.config_atuador3_perif[num].Indice];
					RT_geral.RT_820_BD.config_atuador4_perif[num].Indice = RT_geral.RT_820_BD.config_atuador4_perif[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador4_perif[num].Valor = RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasValor[RT_geral.RT_820_BD.config_atuador4_perif[num].Indice];
					RT_geral.RT_820_BD.config_atuador1_mem[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_mem[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_mem[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_mem[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_var1[num].Indice = RT_geral.RT_820_BD.config_atuador1_var1[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador1_var1[num].Valor = RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].LinhasValor[RT_geral.RT_820_BD.config_atuador1_var1[num].Indice];
					RT_geral.RT_820_BD.config_atuador2_var1[num].Indice = RT_geral.RT_820_BD.config_atuador2_var1[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador2_var1[num].Valor = RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].LinhasValor[RT_geral.RT_820_BD.config_atuador2_var1[num].Indice];
					RT_geral.RT_820_BD.config_atuador3_var1[num].Indice = RT_geral.RT_820_BD.config_atuador3_var1[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador3_var1[num].Valor = RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].LinhasValor[RT_geral.RT_820_BD.config_atuador3_var1[num].Indice];
					RT_geral.RT_820_BD.config_atuador4_var1[num].Indice = RT_geral.RT_820_BD.config_atuador4_var1[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador4_var1[num].Valor = RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].LinhasValor[RT_geral.RT_820_BD.config_atuador4_var1[num].Indice];
					RT_geral.RT_820_BD.config_atuador1_escala1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_escala1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_escala1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_escala1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_var2[num].Indice = RT_geral.RT_820_BD.config_atuador1_var2[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador1_var2[num].Valor = RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].LinhasValor[RT_geral.RT_820_BD.config_atuador1_var2[num].Indice];
					RT_geral.RT_820_BD.config_atuador2_var2[num].Indice = RT_geral.RT_820_BD.config_atuador2_var2[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador2_var2[num].Valor = RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].LinhasValor[RT_geral.RT_820_BD.config_atuador2_var2[num].Indice];
					RT_geral.RT_820_BD.config_atuador3_var2[num].Indice = RT_geral.RT_820_BD.config_atuador3_var2[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador3_var2[num].Valor = RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].LinhasValor[RT_geral.RT_820_BD.config_atuador3_var2[num].Indice];
					RT_geral.RT_820_BD.config_atuador4_var2[num].Indice = RT_geral.RT_820_BD.config_atuador4_var2[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador4_var2[num].Valor = RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].LinhasValor[RT_geral.RT_820_BD.config_atuador4_var2[num].Indice];
					RT_geral.RT_820_BD.config_atuador1_escala2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_escala2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_escala2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_escala2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_histerese[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_histerese[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_histerese[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_histerese[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_formato[num].Indice = RT_geral.RT_820_BD.config_atuador1_formato[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador1_formato[num].Valor = RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasValor[RT_geral.RT_820_BD.config_atuador1_formato[num].Indice];
					RT_geral.RT_820_BD.config_atuador2_formato[num].Indice = RT_geral.RT_820_BD.config_atuador2_formato[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador2_formato[num].Valor = RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasValor[RT_geral.RT_820_BD.config_atuador2_formato[num].Indice];
					RT_geral.RT_820_BD.config_atuador3_formato[num].Indice = RT_geral.RT_820_BD.config_atuador3_formato[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador3_formato[num].Valor = RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasValor[RT_geral.RT_820_BD.config_atuador3_formato[num].Indice];
					RT_geral.RT_820_BD.config_atuador4_formato[num].Indice = RT_geral.RT_820_BD.config_atuador4_formato[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador4_formato[num].Valor = RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasValor[RT_geral.RT_820_BD.config_atuador4_formato[num].Indice];
					RT_geral.RT_820_BD.config_atuador1_base10[num].Indice = RT_geral.RT_820_BD.config_atuador1_base10[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador1_base10[num].Valor = RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasValor[RT_geral.RT_820_BD.config_atuador1_base10[num].Indice];
					RT_geral.RT_820_BD.config_atuador2_base10[num].Indice = RT_geral.RT_820_BD.config_atuador2_base10[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador2_base10[num].Valor = RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasValor[RT_geral.RT_820_BD.config_atuador2_base10[num].Indice];
					RT_geral.RT_820_BD.config_atuador3_base10[num].Indice = RT_geral.RT_820_BD.config_atuador3_base10[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador3_base10[num].Valor = RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasValor[RT_geral.RT_820_BD.config_atuador3_base10[num].Indice];
					RT_geral.RT_820_BD.config_atuador4_base10[num].Indice = RT_geral.RT_820_BD.config_atuador4_base10[num].Indice_padrao;
					RT_geral.RT_820_BD.config_atuador4_base10[num].Valor = RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasValor[RT_geral.RT_820_BD.config_atuador4_base10[num].Indice];
					RT_geral.RT_820_BD.config_atuador1_v1baixo[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_v1baixo[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_v1baixo[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_v1baixo[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_v1alto[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_v1alto[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_v1alto[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_v1alto[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_v2baixo[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_v2baixo[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_v2baixo[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_v2baixo[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_v2alto[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_v2alto[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_v2alto[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_v2alto[num].ValorPadrao();
					num++;
				}
				while (num <= 0);
				num = 0;
				do
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[num].ValorPadrao();
					num++;
				}
				while (num <= 2);
				num = 0;
				do
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[num].ValorPadrao();
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[num].ValorPadrao();
					num++;
				}
				while (num <= 3);
				RT_geral.RT_820_BD.modo_repetidora.IndicePadrao();
				RT_geral.RT_820_BD.End_repetidora.Valor = RT_geral.RT_820_BD.End_repetidora.Padrao;
				RT_geral.RT_820_BD.Num_repetidoras.Valor = RT_geral.RT_820_BD.Num_repetidoras.Padrao;
				num = 0;
				do
				{
					RT_geral.RT_820_BD.Repetidoras[num].Valor = RT_geral.RT_820_BD.Repetidoras[num].Padrao;
					num++;
				}
				while (num <= 50);
				int num2 = 0;
				do
				{
					int num3 = 0;
					do
					{
						RT_geral.RT_820_BD.Timer_Horario[num2][num3].Valor = RT_geral.RT_820_BD.Timer_Horario[num2][num3].Padrao;
						num3++;
					}
					while (num3 <= 11);
					num2++;
				}
				while (num2 <= 7);
			}
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x0038F8F8 File Offset: 0x0038DCF8
		public void Atualiza_TelaRT820()
		{
			checked
			{
				int num = 0;
				int num59 = 0;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					string text = "CFG Geral";
					this.TextBox_versao_820.Text = Conversions.ToString(RT_geral.RT_820_BD.Versao.Valor);
					this.TextBox_build_820.Text = Conversions.ToString(RT_geral.RT_820_BD.Build.Valor);
					this.TextBox_release_820.Text = Conversions.ToString(RT_geral.RT_820_BD.Release.Valor);
					this.TextBox_equipamento_820.Text = Conversions.ToString(RT_geral.RT_820_BD.Equip.Valor);
					this.NumericUpDown_end_est_820.Value = new decimal(RT_geral.RT_820_BD.End_estacao.Valor);
					this.NumericUpDown_end_mestre_820.Value = new decimal(RT_geral.RT_820_BD.End_mestre.Valor);
					this.NumericUpDown_temp_ptt_820.Value = new decimal(RT_geral.RT_820_BD.Tempo_ptt.Valor);
					this.nud_tempoforaar.Value = new decimal(RT_geral.RT_820_BD.TempoForaAr.Valor);
					this.ComboBox_baudrate_COM2_820.SelectedIndex = RT_geral.RT_820_BD.BaudRateCOM2.Indice;
					this.ComboBox_baudrate_COM1_820.SelectedIndex = RT_geral.RT_820_BD.BaudRateCOM1.Indice;
					if (RT_geral.RT_820_BD.HabExpIO.Valor == 21856)
					{
						this.CheckBox_hab_expansao_IO_820.Checked = false;
					}
					else
					{
						this.CheckBox_hab_expansao_IO_820.Checked = true;
					}
					if (RT_geral.RT_820_BD.HabExpIO.Valor != 21857)
					{
					}
					text = "CFG Controle";
					int num2 = 0;
					do
					{
						string value = RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasMenu[RT_geral.RT_820_BD.ctrl_acionamento[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[0].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasMenu[RT_geral.RT_820_BD.ctrl_ret_acionamento[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[1].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasMenu[RT_geral.RT_820_BD.ctrl_desligamento[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[2].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasMenu[RT_geral.RT_820_BD.ctrl_ret_desligamento[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[3].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[4].LinhasMenu[RT_geral.RT_820_BD.ctrl_ED_selecao[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[4].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasMenu[RT_geral.RT_820_BD.ctrl_ED_bloqueio[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[5].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[6].LinhasMenu[RT_geral.RT_820_BD.ctrl_ED_liberacao[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[6].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[7].LinhasMenu[RT_geral.RT_820_BD.ctrl_reverso[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[7].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasMenu[RT_geral.RT_820_BD.ctrl_modo[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[8].Value = value;
						value = RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasMenu[RT_geral.RT_820_BD.ctrl_agrupamento[num2].Indice];
						this.DataGridView_processo_820.Rows[num2].Cells[9].Value = value;
						this.DataGridView_processo_820.Rows[num2].Cells[10].Value = RT_geral.RT_820_BD.ctrl_tempo_max_partida[num2].Valor;
						this.DataGridView_processo_820.Rows[num2].Cells[11].Value = RT_geral.RT_820_BD.ctrl_tempo_max_parada[num2].Valor;
						this.DataGridView_processo_820.Rows[num2].Cells[12].Value = RT_geral.RT_820_BD.ctrl_tempo_min_parado[num2].Valor;
						this.DataGridView_processo_820.Rows[num2].Cells[13].Value = RT_geral.RT_820_BD.ctrl_tempo_min_operando[num2].Valor;
						num2++;
					}
					while (num2 <= 7);
					num2 = 0;
					do
					{
						string value = RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasMenu[RT_geral.RT_820_BD.grupo_simultaneos[num2].Indice];
						this.DataGridView_grupos_820.Rows[num2].Cells[0].Value = value;
						this.DataGridView_grupos_820.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos[num2].Valor;
						num2++;
					}
					while (num2 <= 3);
					this.DataGridView_processo_820.Refresh();
					text = "CFG EA";
					num2 = 0;
					do
					{
						this.DataGridView_parametros_EA_820.Rows[num2].Cells[0].Value = RT_geral.RT_820_BD.EA_Range[num2].Valor;
						this.DataGridView_parametros_EA_820.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.EA_Inicio[num2].Valor;
						this.DataGridView_parametros_EA_820.Rows[num2].Cells[2].Value = RT_geral.RT_820_BD.EA_Fim[num2].Valor;
						num2++;
					}
					while (num2 <= 15);
					this.NumericUpDown_intervalo_filtro_820.Value = new decimal(RT_geral.RT_820_BD.AD_Intervalo.Valor);
					this.NumericUpDown_tamanho_filtro_820.Value = new decimal(RT_geral.RT_820_BD.AD_Tamanho_filtro.Valor);
					text = "CFG ED";
					if (RT_geral.RT_820_BD.HabExpIO.Valor == 21857)
					{
						num2 = 0;
						do
						{
							string value = RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[RT_geral.RT_820_BD.config_ED[num2].Indice];
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
							string value = RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[RT_geral.RT_820_BD.config_ED[num2].Indice];
							this.DataGridView_RT820_ED.Rows[num2].Cells[0].Value = value;
							num2++;
						}
						while (num2 <= 7);
					}
					text = "CFG SETPOINT";
					if (RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
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
						if (RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
						{
							this.DataGridView_setpoints_820.Rows[num2].Cells[2].Value = (double)RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[num2].Valor / 40.0;
							this.DataGridView_setpoints_820.Rows[num2].Cells[1].Value = (double)RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[num2].Valor / 40.0;
							this.DataGridView_setpoints_820.Rows[num2].Cells[4].Value = (double)RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[num2].Valor / 40.0;
							this.DataGridView_setpoints_820.Rows[num2].Cells[5].Value = (double)RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[num2].Valor / 40.0;
						}
						else
						{
							this.DataGridView_setpoints_820.Rows[num2].Cells[2].Value = RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[num2].Valor;
							this.DataGridView_setpoints_820.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[num2].Valor;
							this.DataGridView_setpoints_820.Rows[num2].Cells[4].Value = RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[num2].Valor;
							this.DataGridView_setpoints_820.Rows[num2].Cells[5].Value = RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[num2].Valor;
						}
						string value = RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasMenu[RT_geral.RT_820_BD.Setpoints_ctrl_variavel[num2].Indice];
						this.DataGridView_setpoints_820.Rows[num2].Cells[0].Value = value;
						value = RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasMenu[RT_geral.RT_820_BD.Setpoints_ctrl_bloqueio[num2].Indice];
						this.DataGridView_setpoints_820.Rows[num2].Cells[3].Value = value;
						num2++;
					}
					while (num2 <= 7);
					text = "CFG SETPOINT HORARIO";
					num2 = 0;
					do
					{
						bool flag = (RT_geral.RT_820_BD.setpoint_horario[num2].Hora.Valor & 128) > 0;
						this.dgv_sph.Rows[num2].Cells[1].Value = flag;
						int num3 = RT_geral.RT_820_BD.setpoint_horario[num2].Hora.Valor & 127;
						int num4 = RT_geral.RT_820_BD.setpoint_horario[num2].Minuto.Valor;
						int num5 = RT_geral.RT_820_BD.setpoint_horario[num2].Alto.Valor;
						int num6 = RT_geral.RT_820_BD.setpoint_horario[num2].Baixo.Valor;
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
						if (RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
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
					while (num2 <= 15);
					text = "CFG VAZOES";
					num2 = 0;
					do
					{
						string value = RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[RT_geral.RT_820_BD.config_vazao[num2].Indice];
						this.DataGridView_vazoes_RT820.Rows[num2].Cells[0].Value = value;
						num2++;
					}
					while (num2 <= 7);
					num2 = 0;
					do
					{
						string value = RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[RT_geral.RT_820_BD.config_perifericos_mod[num2].Indice];
						this.DataGridView_periferico_RT820.Rows[num2].Cells[0].Value = value;
						this.DataGridView_periferico_RT820.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.config_perifericos_end[num2].Valor;
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
							if (RT_geral.RT_820_BD.config_referencia_perif_periferico[num2].Valor == RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor[i])
							{
								RT_geral.RT_820_BD.config_referencia_perif_periferico[num2].Indice = i;
								break;
							}
						}
						string value = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu[RT_geral.RT_820_BD.config_referencia_perif_periferico[num2].Indice];
						this.datagridview_referenciaperifico.Rows[num2].Cells[0].Value = value;
						this.datagridview_referenciaperifico.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.config_referencia_perif_memoria[num2].Valor;
						int num9 = 0;
						int num10 = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].NumeroLinhaMenu - 1;
						for (int i = num9; i <= num10; i++)
						{
							if (RT_geral.RT_820_BD.config_referencia_perif_variavel1[num2].Valor == RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasValor[i])
							{
								RT_geral.RT_820_BD.config_referencia_perif_variavel1[num2].Indice = i;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasMenu[RT_geral.RT_820_BD.config_referencia_perif_variavel1[num2].Indice];
						this.datagridview_referenciaperifico.Rows[num2].Cells[2].Value = value;
						int num11 = 0;
						int num12 = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].NumeroLinhaMenu - 1;
						for (int i = num11; i <= num12; i++)
						{
							if (RT_geral.RT_820_BD.config_referencia_perif_variavel2[num2].Valor == RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LinhasValor[i])
							{
								RT_geral.RT_820_BD.config_referencia_perif_variavel2[num2].Indice = i;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LinhasMenu[RT_geral.RT_820_BD.config_referencia_perif_variavel2[num2].Indice];
						this.datagridview_referenciaperifico.Rows[num2].Cells[3].Value = value;
						this.datagridview_referenciaperifico.Rows[num2].Cells[4].Value = RT_geral.RT_820_BD.config_referencia_perif_escala[num2].Valor;
						int num13 = 0;
						int num14 = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].NumeroLinhaMenu - 1;
						for (int i = num13; i <= num14; i++)
						{
							if (RT_geral.RT_820_BD.config_referencia_perif_formato[num2].Valor == RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor[i])
							{
								RT_geral.RT_820_BD.config_referencia_perif_formato[num2].Indice = i;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasMenu[RT_geral.RT_820_BD.config_referencia_perif_formato[num2].Indice];
						this.datagridview_referenciaperifico.Rows[num2].Cells[5].Value = value;
						int num15 = 0;
						int num16 = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].NumeroLinhaMenu - 1;
						for (int i = num15; i <= num16; i++)
						{
							if (RT_geral.RT_820_BD.config_referencia_perif_base10[num2].Valor == RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasValor[i])
							{
								RT_geral.RT_820_BD.config_referencia_perif_base10[num2].Indice = i;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasMenu[RT_geral.RT_820_BD.config_referencia_perif_base10[num2].Indice];
						this.datagridview_referenciaperifico.Rows[num2].Cells[6].Value = value;
						num2++;
					}
					while (num2 <= 9);
					text = "CFG ATUADOR1";
					num2 = 0;
					do
					{
						RT_geral.RT_820_BD.config_atuador1_perif[0].Indice = -1;
						int num17 = 0;
						int num18 = RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].NumeroLinhaMenu - 1;
						for (int j = num17; j <= num18; j++)
						{
							if (RT_geral.RT_820_BD.config_atuador1_perif[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasValor[j])
							{
								RT_geral.RT_820_BD.config_atuador1_perif[num2].Indice = j;
								break;
							}
						}
						if (RT_geral.RT_820_BD.config_atuador1_perif[0].Indice == -1)
						{
							RT_geral.RT_820_BD.config_atuador1_perif[0].Indice = RT_geral.RT_820_BD.config_atuador1_perif[0].Indice_padrao;
							RT_geral.RT_820_BD.config_atuador1_perif[0].Valor = RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasValor[RT_geral.RT_820_BD.config_atuador1_perif[0].Indice];
						}
						string value = RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasMenu[RT_geral.RT_820_BD.config_atuador1_perif[0].Indice];
						this.dgv_atuador1.Rows[num2].Cells[0].Value = value;
						this.dgv_atuador1.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.config_atuador1_mem[num2].Valor;
						int num19 = 0;
						int num20 = RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].NumeroLinhaMenu - 1;
						for (int j = num19; j <= num20; j++)
						{
							if (RT_geral.RT_820_BD.config_atuador1_var1[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].LinhasValor[j])
							{
								RT_geral.RT_820_BD.config_atuador1_var1[num2].Indice = j;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].LinhasMenu[RT_geral.RT_820_BD.config_atuador1_var1[num2].Indice];
						this.dgv_atuador1.Rows[num2].Cells[2].Value = value;
						this.dgv_atuador1.Rows[num2].Cells[3].Value = RT_geral.RT_820_BD.config_atuador1_escala1[num2].Valor;
						int num21 = 0;
						int num22 = RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].NumeroLinhaMenu - 1;
						for (int j = num21; j <= num22; j++)
						{
							if (RT_geral.RT_820_BD.config_atuador1_var2[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].LinhasValor[j])
							{
								RT_geral.RT_820_BD.config_atuador1_var2[num2].Indice = j;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].LinhasMenu[RT_geral.RT_820_BD.config_atuador1_var2[num2].Indice];
						this.dgv_atuador1.Rows[num2].Cells[4].Value = value;
						this.dgv_atuador1.Rows[num2].Cells[5].Value = RT_geral.RT_820_BD.config_atuador1_escala2[num2].Valor;
						this.dgv_atuador1.Rows[num2].Cells[6].Value = RT_geral.RT_820_BD.config_atuador1_histerese[num2].Valor;
						int num23 = 0;
						int num24 = RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].NumeroLinhaMenu - 1;
						for (int j = num23; j <= num24; j++)
						{
							if (RT_geral.RT_820_BD.config_atuador1_formato[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasValor[j])
							{
								RT_geral.RT_820_BD.config_atuador1_formato[num2].Indice = j;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasMenu[RT_geral.RT_820_BD.config_atuador1_formato[num2].Indice];
						this.dgv_atuador1.Rows[num2].Cells[7].Value = value;
						int num25 = 0;
						int num26 = RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].NumeroLinhaMenu - 1;
						for (int j = num25; j <= num26; j++)
						{
							if (RT_geral.RT_820_BD.config_atuador1_base10[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasValor[j])
							{
								RT_geral.RT_820_BD.config_atuador1_base10[num2].Indice = j;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasMenu[RT_geral.RT_820_BD.config_atuador1_base10[num2].Indice];
						this.dgv_atuador1.Rows[num2].Cells[8].Value = value;
						this.dgv_atuador1.Rows[num2].Cells[9].Value = RT_geral.RT_820_BD.config_atuador1_v1baixo[num2].Valor;
						this.dgv_atuador1.Rows[num2].Cells[10].Value = RT_geral.RT_820_BD.config_atuador1_v1alto[num2].Valor;
						this.dgv_atuador1.Rows[num2].Cells[11].Value = RT_geral.RT_820_BD.config_atuador1_v2baixo[num2].Valor;
						this.dgv_atuador1.Rows[num2].Cells[12].Value = RT_geral.RT_820_BD.config_atuador1_v2alto[num2].Valor;
						num2++;
					}
					while (num2 <= 0);
					text = "CFG ATUADOR1 VARIAVEL1";
					num2 = 0;
					do
					{
						this.dgv_atuador_setpoint1.Rows[num2].Cells[0].Value = RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[2].Value = RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[4].Value = RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[6].Value = RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[8].Value = RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[10].Value = RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[12].Value = RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[3].Value = RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[5].Value = RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[7].Value = RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[9].Value = RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[11].Value = RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[num2].Valor;
						this.dgv_atuador_setpoint1.Rows[num2].Cells[13].Value = RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					text = "CFG ATUADOR1 VARIAVEL2";
					num2 = 0;
					do
					{
						this.dgv_atuador_setpoint11.Rows[num2].Cells[0].Value = RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[2].Value = RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[4].Value = RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[6].Value = RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[8].Value = RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[10].Value = RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[3].Value = RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[5].Value = RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[7].Value = RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[9].Value = RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[num2].Valor;
						this.dgv_atuador_setpoint11.Rows[num2].Cells[11].Value = RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					text = "CFG ATUADOR2";
					num2 = 0;
					do
					{
						RT_geral.RT_820_BD.config_atuador2_perif[num2].Indice = -1;
						int num27 = 0;
						int num28 = RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].NumeroLinhaMenu - 1;
						for (int k = num27; k <= num28; k++)
						{
							if (RT_geral.RT_820_BD.config_atuador2_perif[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasValor[k])
							{
								RT_geral.RT_820_BD.config_atuador2_perif[num2].Indice = k;
								break;
							}
						}
						if (RT_geral.RT_820_BD.config_atuador2_perif[0].Indice == -1)
						{
							RT_geral.RT_820_BD.config_atuador2_perif[0].Indice = RT_geral.RT_820_BD.config_atuador2_perif[0].Indice_padrao;
							RT_geral.RT_820_BD.config_atuador2_perif[0].Valor = RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasValor[RT_geral.RT_820_BD.config_atuador2_perif[0].Indice];
						}
						string value = RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasMenu[RT_geral.RT_820_BD.config_atuador2_perif[num2].Indice];
						this.dgv_atuador2.Rows[num2].Cells[0].Value = value;
						this.dgv_atuador2.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.config_atuador2_mem[num2].Valor;
						int num29 = 0;
						int num30 = RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].NumeroLinhaMenu - 1;
						for (int k = num29; k <= num30; k++)
						{
							if (RT_geral.RT_820_BD.config_atuador2_var1[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].LinhasValor[k])
							{
								RT_geral.RT_820_BD.config_atuador2_var1[num2].Indice = k;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].LinhasMenu[RT_geral.RT_820_BD.config_atuador2_var1[num2].Indice];
						this.dgv_atuador2.Rows[num2].Cells[2].Value = value;
						this.dgv_atuador2.Rows[num2].Cells[3].Value = RT_geral.RT_820_BD.config_atuador2_escala1[num2].Valor;
						int num31 = 0;
						int num32 = RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].NumeroLinhaMenu - 1;
						for (int k = num31; k <= num32; k++)
						{
							if (RT_geral.RT_820_BD.config_atuador2_var2[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].LinhasValor[k])
							{
								RT_geral.RT_820_BD.config_atuador2_var2[num2].Indice = k;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].LinhasMenu[RT_geral.RT_820_BD.config_atuador2_var2[num2].Indice];
						this.dgv_atuador2.Rows[num2].Cells[4].Value = value;
						this.dgv_atuador2.Rows[num2].Cells[5].Value = RT_geral.RT_820_BD.config_atuador2_escala2[num2].Valor;
						this.dgv_atuador2.Rows[num2].Cells[6].Value = RT_geral.RT_820_BD.config_atuador2_histerese[num2].Valor;
						int num33 = 0;
						int num34 = RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].NumeroLinhaMenu - 1;
						for (int k = num33; k <= num34; k++)
						{
							if (RT_geral.RT_820_BD.config_atuador2_formato[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasValor[k])
							{
								RT_geral.RT_820_BD.config_atuador2_formato[num2].Indice = k;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasMenu[RT_geral.RT_820_BD.config_atuador2_formato[num2].Indice];
						this.dgv_atuador2.Rows[num2].Cells[7].Value = value;
						int num35 = 0;
						int num36 = RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].NumeroLinhaMenu - 1;
						for (int k = num35; k <= num36; k++)
						{
							if (RT_geral.RT_820_BD.config_atuador2_base10[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasValor[k])
							{
								RT_geral.RT_820_BD.config_atuador2_base10[num2].Indice = k;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasMenu[RT_geral.RT_820_BD.config_atuador2_base10[num2].Indice];
						this.dgv_atuador2.Rows[num2].Cells[8].Value = value;
						this.dgv_atuador2.Rows[num2].Cells[9].Value = RT_geral.RT_820_BD.config_atuador2_v1baixo[num2].Valor;
						this.dgv_atuador2.Rows[num2].Cells[10].Value = RT_geral.RT_820_BD.config_atuador2_v1alto[num2].Valor;
						this.dgv_atuador2.Rows[num2].Cells[11].Value = RT_geral.RT_820_BD.config_atuador2_v2baixo[num2].Valor;
						this.dgv_atuador2.Rows[num2].Cells[12].Value = RT_geral.RT_820_BD.config_atuador2_v2alto[num2].Valor;
						num2++;
					}
					while (num2 <= 0);
					text = "CFG ATUADOR2 VARIAVEL1";
					num2 = 0;
					do
					{
						this.dgv_atuador_setpoint2.Rows[num2].Cells[0].Value = RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[2].Value = RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[4].Value = RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[6].Value = RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[8].Value = RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[10].Value = RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[12].Value = RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[3].Value = RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[5].Value = RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[7].Value = RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[9].Value = RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[11].Value = RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[num2].Valor;
						this.dgv_atuador_setpoint2.Rows[num2].Cells[13].Value = RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					text = "CFG ATUADOR2 VARIAVEL2";
					num2 = 0;
					do
					{
						this.dgv_atuador_setpoint21.Rows[num2].Cells[0].Value = RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[2].Value = RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[4].Value = RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[6].Value = RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[8].Value = RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[10].Value = RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[3].Value = RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[5].Value = RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[7].Value = RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[9].Value = RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[num2].Valor;
						this.dgv_atuador_setpoint21.Rows[num2].Cells[11].Value = RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					text = "CFG ATUADOR3";
					num2 = 0;
					do
					{
						RT_geral.RT_820_BD.config_atuador3_perif[0].Indice = -1;
						int num37 = 0;
						int num38 = RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].NumeroLinhaMenu - 1;
						for (int l = num37; l <= num38; l++)
						{
							if (RT_geral.RT_820_BD.config_atuador3_perif[0].Valor == RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasValor[l])
							{
								RT_geral.RT_820_BD.config_atuador3_perif[0].Indice = l;
								break;
							}
						}
						if (RT_geral.RT_820_BD.config_atuador3_perif[0].Indice == -1)
						{
							RT_geral.RT_820_BD.config_atuador3_perif[0].Indice = RT_geral.RT_820_BD.config_atuador3_perif[0].Indice_padrao;
							RT_geral.RT_820_BD.config_atuador3_perif[0].Valor = RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasValor[RT_geral.RT_820_BD.config_atuador3_perif[0].Indice];
						}
						string value = RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasMenu[RT_geral.RT_820_BD.config_atuador3_perif[0].Indice];
						this.dgv_atuador3.Rows[num2].Cells[0].Value = value;
						this.dgv_atuador3.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.config_atuador3_mem[num2].Valor;
						int num39 = 0;
						int num40 = RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].NumeroLinhaMenu - 1;
						for (int l = num39; l <= num40; l++)
						{
							if (RT_geral.RT_820_BD.config_atuador3_var1[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].LinhasValor[l])
							{
								RT_geral.RT_820_BD.config_atuador3_var1[num2].Indice = l;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].LinhasMenu[RT_geral.RT_820_BD.config_atuador3_var1[num2].Indice];
						this.dgv_atuador3.Rows[num2].Cells[2].Value = value;
						this.dgv_atuador3.Rows[num2].Cells[3].Value = RT_geral.RT_820_BD.config_atuador3_escala1[num2].Valor;
						int num41 = 0;
						int num42 = RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].NumeroLinhaMenu - 1;
						for (int l = num41; l <= num42; l++)
						{
							if (RT_geral.RT_820_BD.config_atuador3_var2[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].LinhasValor[l])
							{
								RT_geral.RT_820_BD.config_atuador3_var2[num2].Indice = l;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].LinhasMenu[RT_geral.RT_820_BD.config_atuador3_var2[num2].Indice];
						this.dgv_atuador3.Rows[num2].Cells[4].Value = value;
						this.dgv_atuador3.Rows[num2].Cells[5].Value = RT_geral.RT_820_BD.config_atuador3_escala2[num2].Valor;
						this.dgv_atuador3.Rows[num2].Cells[6].Value = RT_geral.RT_820_BD.config_atuador3_histerese[num2].Valor;
						int num43 = 0;
						int num44 = RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].NumeroLinhaMenu - 1;
						for (int l = num43; l <= num44; l++)
						{
							if (RT_geral.RT_820_BD.config_atuador3_formato[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasValor[l])
							{
								RT_geral.RT_820_BD.config_atuador3_formato[num2].Indice = l;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasMenu[RT_geral.RT_820_BD.config_atuador3_formato[num2].Indice];
						this.dgv_atuador3.Rows[num2].Cells[7].Value = value;
						int num45 = 0;
						int num46 = RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].NumeroLinhaMenu - 1;
						for (int l = num45; l <= num46; l++)
						{
							if (RT_geral.RT_820_BD.config_atuador3_base10[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasValor[l])
							{
								RT_geral.RT_820_BD.config_atuador3_base10[num2].Indice = l;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasMenu[RT_geral.RT_820_BD.config_atuador3_base10[num2].Indice];
						this.dgv_atuador3.Rows[num2].Cells[8].Value = value;
						this.dgv_atuador3.Rows[num2].Cells[9].Value = RT_geral.RT_820_BD.config_atuador3_v1baixo[num2].Valor;
						this.dgv_atuador3.Rows[num2].Cells[10].Value = RT_geral.RT_820_BD.config_atuador3_v1alto[num2].Valor;
						this.dgv_atuador3.Rows[num2].Cells[11].Value = RT_geral.RT_820_BD.config_atuador3_v2baixo[num2].Valor;
						this.dgv_atuador3.Rows[num2].Cells[12].Value = RT_geral.RT_820_BD.config_atuador3_v2alto[num2].Valor;
						num2++;
					}
					while (num2 <= 0);
					text = "CFG ATUADOR3 VARIAVEL1";
					num2 = 0;
					do
					{
						this.dgv_atuador_setpoint3.Rows[num2].Cells[0].Value = RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[2].Value = RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[4].Value = RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[6].Value = RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[8].Value = RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[10].Value = RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[12].Value = RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[3].Value = RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[5].Value = RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[7].Value = RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[9].Value = RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[11].Value = RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[num2].Valor;
						this.dgv_atuador_setpoint3.Rows[num2].Cells[13].Value = RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					text = "CFG ATUADOR3 VARIAVEL2";
					num2 = 0;
					do
					{
						this.dgv_atuador_setpoint31.Rows[num2].Cells[0].Value = RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[2].Value = RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[4].Value = RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[6].Value = RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[8].Value = RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[10].Value = RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[3].Value = RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[5].Value = RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[7].Value = RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[9].Value = RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[num2].Valor;
						this.dgv_atuador_setpoint31.Rows[num2].Cells[11].Value = RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					text = "CFG ATUADOR4";
					num2 = 0;
					do
					{
						RT_geral.RT_820_BD.config_atuador4_perif[num2].Indice = -1;
						int num47 = 0;
						int num48 = RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].NumeroLinhaMenu - 1;
						for (int m = num47; m <= num48; m++)
						{
							if (RT_geral.RT_820_BD.config_atuador4_perif[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasValor[m])
							{
								RT_geral.RT_820_BD.config_atuador4_perif[num2].Indice = m;
								break;
							}
						}
						if (RT_geral.RT_820_BD.config_atuador4_perif[0].Indice == -1)
						{
							RT_geral.RT_820_BD.config_atuador4_perif[0].Indice = RT_geral.RT_820_BD.config_atuador4_perif[0].Indice_padrao;
							RT_geral.RT_820_BD.config_atuador4_perif[0].Valor = RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasValor[RT_geral.RT_820_BD.config_atuador4_perif[0].Indice];
						}
						string value = RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasMenu[RT_geral.RT_820_BD.config_atuador4_perif[num2].Indice];
						this.dgv_atuador4.Rows[num2].Cells[0].Value = value;
						this.dgv_atuador4.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.config_atuador4_mem[num2].Valor;
						int num49 = 0;
						int num50 = RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].NumeroLinhaMenu - 1;
						for (int m = num49; m <= num50; m++)
						{
							if (RT_geral.RT_820_BD.config_atuador4_var1[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].LinhasValor[m])
							{
								RT_geral.RT_820_BD.config_atuador4_var1[num2].Indice = m;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].LinhasMenu[RT_geral.RT_820_BD.config_atuador4_var1[num2].Indice];
						this.dgv_atuador4.Rows[num2].Cells[2].Value = value;
						this.dgv_atuador4.Rows[num2].Cells[3].Value = RT_geral.RT_820_BD.config_atuador4_escala1[num2].Valor;
						int num51 = 0;
						int num52 = RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].NumeroLinhaMenu - 1;
						for (int m = num51; m <= num52; m++)
						{
							if (RT_geral.RT_820_BD.config_atuador4_var2[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].LinhasValor[m])
							{
								RT_geral.RT_820_BD.config_atuador4_var2[num2].Indice = m;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].LinhasMenu[RT_geral.RT_820_BD.config_atuador4_var2[num2].Indice];
						this.dgv_atuador4.Rows[num2].Cells[4].Value = value;
						this.dgv_atuador4.Rows[num2].Cells[5].Value = RT_geral.RT_820_BD.config_atuador4_escala2[num2].Valor;
						this.dgv_atuador4.Rows[num2].Cells[6].Value = RT_geral.RT_820_BD.config_atuador4_histerese[num2].Valor;
						int num53 = 0;
						int num54 = RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].NumeroLinhaMenu - 1;
						for (int m = num53; m <= num54; m++)
						{
							if (RT_geral.RT_820_BD.config_atuador4_formato[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasValor[m])
							{
								RT_geral.RT_820_BD.config_atuador4_formato[num2].Indice = m;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasMenu[RT_geral.RT_820_BD.config_atuador4_formato[num2].Indice];
						this.dgv_atuador4.Rows[num2].Cells[7].Value = value;
						int num55 = 0;
						int num56 = RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].NumeroLinhaMenu - 1;
						for (int m = num55; m <= num56; m++)
						{
							if (RT_geral.RT_820_BD.config_atuador4_base10[num2].Valor == RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasValor[m])
							{
								RT_geral.RT_820_BD.config_atuador4_base10[num2].Indice = m;
								break;
							}
						}
						value = RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasMenu[RT_geral.RT_820_BD.config_atuador4_base10[num2].Indice];
						this.dgv_atuador4.Rows[num2].Cells[8].Value = value;
						this.dgv_atuador4.Rows[num2].Cells[9].Value = RT_geral.RT_820_BD.config_atuador4_v1baixo[num2].Valor;
						this.dgv_atuador4.Rows[num2].Cells[10].Value = RT_geral.RT_820_BD.config_atuador4_v1alto[num2].Valor;
						this.dgv_atuador4.Rows[num2].Cells[11].Value = RT_geral.RT_820_BD.config_atuador4_v2baixo[num2].Valor;
						this.dgv_atuador4.Rows[num2].Cells[12].Value = RT_geral.RT_820_BD.config_atuador4_v2alto[num2].Valor;
						num2++;
					}
					while (num2 <= 0);
					text = "CFG ATUADOR4 VARIAVEL1";
					num2 = 0;
					do
					{
						this.dgv_atuador_setpoint4.Rows[num2].Cells[0].Value = RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[2].Value = RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[4].Value = RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[6].Value = RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[8].Value = RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[10].Value = RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[12].Value = RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[3].Value = RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[5].Value = RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[7].Value = RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[9].Value = RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[11].Value = RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[num2].Valor;
						this.dgv_atuador_setpoint4.Rows[num2].Cells[13].Value = RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					text = "CFG ATUADOR4 VARIAVEL2";
					num2 = 0;
					do
					{
						this.dgv_atuador_setpoint41.Rows[num2].Cells[0].Value = RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[2].Value = RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[4].Value = RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[6].Value = RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[8].Value = RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[10].Value = RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[3].Value = RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[5].Value = RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[7].Value = RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[9].Value = RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[num2].Valor;
						this.dgv_atuador_setpoint41.Rows[num2].Cells[11].Value = RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[num2].Valor;
						num2++;
					}
					while (num2 <= 2);
					text = "CFG REPETIDORA";
					RT_geral.RT_820_BD.modo_repetidora.AtualizaIndicePeloValor();
					this.cb_ModoRepetidora.SelectedIndex = RT_geral.RT_820_BD.modo_repetidora.Indice;
					this.NumericUpDown_end_rep_820.Value = new decimal(RT_geral.RT_820_BD.End_repetidora.Valor);
					this.NumericUpDown_num_est_rep_820.Value = new decimal(RT_geral.RT_820_BD.Num_repetidoras.Valor);
					num2 = 0;
					do
					{
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[1].Value = RT_geral.RT_820_BD.Repetidoras[num2].Valor;
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[3].Value = RT_geral.RT_820_BD.Repetidoras[num2 + 10].Valor;
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[5].Value = RT_geral.RT_820_BD.Repetidoras[num2 + 20].Valor;
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[7].Value = RT_geral.RT_820_BD.Repetidoras[num2 + 30].Valor;
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[9].Value = RT_geral.RT_820_BD.Repetidoras[num2 + 40].Valor;
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
							int num3 = RT_geral.RT_820_BD.Timer_Horario[num57][num58].Valor / 60;
							int num4 = RT_geral.RT_820_BD.Timer_Horario[num57][num58].Valor % 60;
							this.DataGridView_timer_RT820.Rows[num57].Cells[num58].Value = Strings.Format(num3, "#0") + ":" + Strings.Format(num4, "#0");
							num58++;
						}
						while (num58 <= 11);
						num57++;
					}
					while (num57 <= 7);
					goto IL_478A;
					IL_4731:
					MessageBox.Show("Erro na Atualização de Tela:" + text);
					goto IL_478A;
					IL_4745:
					num59 = -1;
					throw new InvalidOperationException("Decompiler switch pattern not reconstructed.");
					IL_475B:;
				}
				catch (Exception)
			{
				throw;
			}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_478A:
				if (num59 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x003940B4 File Offset: 0x003924B4
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
			this.DataGridView_periferico_RT820.Visible = false;
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
				this.DataGridView_periferico_RT820.Visible = true;
				this.GroupBox_parametros_repetidora_820.Enabled = true;
				this.GroupBox_end_rep_820.Enabled = true;
				this.DataGridView_end_rep_RT820.Visible = true;
				break;
			}
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x00394298 File Offset: 0x00392698
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

		// Token: 0x06001886 RID: 6278 RVA: 0x00394350 File Offset: 0x00392750
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

		// Token: 0x06001887 RID: 6279 RVA: 0x003943B4 File Offset: 0x003927B4
		public void InicializaBarraProgressoTela_RT_820(int num_passos)
		{
			this.ToolStripProgressBar_RT_820.Minimum = 0;
			this.ToolStripProgressBar_RT_820.Maximum = 100;
			this.ToolStripProgressBar_RT_820.Step = checked((int)Math.Round(unchecked(100.0 / (double)num_passos + 1.0)));
			this.ToolStripProgressBar_RT_820.Value = 0;
			this.ToolStripProgressBar_RT_820.BackColor = Color.LightGray;
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x00394420 File Offset: 0x00392820
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

		// Token: 0x06001889 RID: 6281 RVA: 0x00394490 File Offset: 0x00392890
		private void NumericUpDown_end_rep_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_BD.End_repetidora.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_BD.End_repetidora, true);
			sender = numericUpDown;
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x003944E4 File Offset: 0x003928E4
		private void NumericUpDown_num_est_rep_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_BD.Num_repetidoras.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_BD.Num_repetidoras, true);
			sender = numericUpDown;
			int num = 0;
			int num2 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			checked
			{
				for (int i = Convert.ToInt32(num); i <= num2; i++)
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
				for (int i = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null)); i <= 49; i++)
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

		// Token: 0x0600188B RID: 6283 RVA: 0x00394990 File Offset: 0x00392D90
		private void NumericUpDown_intervalo_filtro_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_BD.AD_Intervalo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_BD.AD_Intervalo, true);
			sender = numericUpDown;
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x003949E4 File Offset: 0x00392DE4
		private void NumericUpDown_tamanho_filtro_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_BD.AD_Tamanho_filtro.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_BD.AD_Tamanho_filtro, true);
			sender = numericUpDown;
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00394A38 File Offset: 0x00392E38
		public void CarregaComboBoxModoRepetidora(ref ComboBox dado)
		{
			dado.Items.Clear();
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_820_BD.modo_repetidora.Numero_itens - 1;
				for (int i = Convert.ToInt32(num); i <= num2; i++)
				{
					dado.Items.Add(RT_geral.RT_820_BD.modo_repetidora.itens[i]);
				}
			}
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00394A90 File Offset: 0x00392E90
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
				List<perifericos.Periferico>.Enumerator enumerator = new List<perifericos.Periferico>.Enumerator();
				enumerator.Dispose();
			}
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x00394AFC File Offset: 0x00392EFC
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

		// Token: 0x06001890 RID: 6288 RVA: 0x00394C20 File Offset: 0x00393020
		private void ComboBox_modo_simulado_820_SelectedIndexChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x00394C24 File Offset: 0x00393024
		private void NumericUpDown_end_mestre_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_BD.End_mestre.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_BD.End_mestre, true);
			sender = numericUpDown;
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00394C78 File Offset: 0x00393078
		private void NumericUpDown_end_est_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_BD.End_estacao.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_BD.End_estacao, true);
			sender = numericUpDown;
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x00394CCC File Offset: 0x003930CC
		private void NumericUpDown_temp_ptt_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_BD.Tempo_ptt.Valor = Conversions.ToInteger(Operators.MultiplyObject(Operators.IntDivideObject(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null), 10), 10));
			NewLateBinding.LateSet(sender, null, "Value", new object[]
			{
				RT_geral.RT_820_BD.Tempo_ptt.Valor
			}, null, null);
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_BD.Tempo_ptt, true);
			sender = numericUpDown;
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00394D64 File Offset: 0x00393164
		private void ComboBox_baudrate_COM2_820_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_BD.BaudRateCOM2.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_820_BD.BaudRateCOM2.Valor = RT_geral.RT_820_BD.BaudRateCOM2.valores[RT_geral.RT_820_BD.BaudRateCOM2.Indice];
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00394DC8 File Offset: 0x003931C8
		private void CheckBox_hab_expansao_IO_820_CheckedChanged(object sender, EventArgs e)
		{
			this.Atualiza_Expansao_IO_820_300(Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null)));
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00394DEC File Offset: 0x003931EC
		public void Atualiza_Expansao_IO_820_300(bool @checked)
		{
			checked
			{
				if (@checked)
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

		// Token: 0x06001897 RID: 6295 RVA: 0x003950B8 File Offset: 0x003934B8
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
													if (Operators.CompareString(dataPropertyName, "Col_TpMaxPart", false) == 0)
													{
														this.DataGridView_processo_820.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[10].Value));
														RT_geral.RT_820_BD.ctrl_tempo_max_partida[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[10].Value);
														return;
													}
													if (Operators.CompareString(dataPropertyName, "Col_TpMaxParada", false) == 0)
													{
														this.DataGridView_processo_820.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[11].Value));
														RT_geral.RT_820_BD.ctrl_tempo_max_parada[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[11].Value);
														return;
													}
													if (Operators.CompareString(dataPropertyName, "Col_TpMinParado", false) == 0)
													{
														this.DataGridView_processo_820.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[12].Value));
														RT_geral.RT_820_BD.ctrl_tempo_min_parado[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[12].Value);
														return;
													}
													if (Operators.CompareString(dataPropertyName, "Col_TpMinOperan", false) == 0)
													{
														this.DataGridView_processo_820.Rows[e.RowIndex].Cells[13].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[13].Value));
														RT_geral.RT_820_BD.ctrl_tempo_min_operando[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[13].Value);
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
			string text = Conversions.ToString(this.DataGridView_processo_820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
			int num = 0;
			checked
			{
				int num2 = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
				int i = Convert.ToInt32(num);
				while (i <= num2)
				{
					if (Operators.CompareString(RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
					{
						string dataPropertyName2 = this.DataGridView_processo_820.Columns[e.ColumnIndex].DataPropertyName;
						if (Operators.CompareString(dataPropertyName2, "Col_SDAciona", false) == 0)
						{
							if (RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_820_BD.ctrl_acionamento[e.RowIndex], ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], 8, ref RT_geral.RT_820_BD.ctrl_desligamento, "", "", "") | RT_geral.VerificaEDJaUtilizada_MesmaColuna(8, i, e.RowIndex, ref RT_geral.RT_820_BD.ctrl_acionamento, ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], ""))
							{
								this.DataGridView_processo_820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_820_BD.ctrl_acionamento[e.RowIndex].Indice_padrao];
								break;
							}
							RT_geral.RT_820_BD.ctrl_acionamento[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_BD.ctrl_acionamento[e.RowIndex].Indice = i;
							break;
						}
						else if (Operators.CompareString(dataPropertyName2, "Col_EDRetAci", false) == 0)
						{
							if (RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_820_BD.ctrl_ret_acionamento[e.RowIndex], ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], 8, ref RT_geral.RT_820_BD.ctrl_ret_desligamento, "", "", "") | RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_820_BD.ctrl_ret_acionamento[e.RowIndex], ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], 8, ref RT_geral.RT_820_BD.ctrl_ED_selecao, "", "", "") | RT_geral.VerificaEDJaUtilizada_FuncoesEspeciais(i, RT_geral.RT_820_BD.config_ED, "") | RT_geral.VerificaEDJaUtilizada_MesmaColuna(8, i, e.RowIndex, ref RT_geral.RT_820_BD.ctrl_ret_acionamento, ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], ""))
							{
								this.DataGridView_processo_820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_820_BD.ctrl_ret_acionamento[e.RowIndex].Indice_padrao];
								break;
							}
							RT_geral.RT_820_BD.ctrl_ret_acionamento[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_BD.ctrl_ret_acionamento[e.RowIndex].Indice = i;
							break;
						}
						else if (Operators.CompareString(dataPropertyName2, "Col_SDDesaci", false) == 0)
						{
							if (RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_820_BD.ctrl_desligamento[e.RowIndex], ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], 8, ref RT_geral.RT_820_BD.ctrl_acionamento, "", "", "") | RT_geral.VerificaEDJaUtilizada_MesmaColuna(8, i, e.RowIndex, ref RT_geral.RT_820_BD.ctrl_desligamento, ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], ""))
							{
								this.DataGridView_processo_820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_820_BD.ctrl_desligamento[e.RowIndex].Indice_padrao];
								break;
							}
							RT_geral.RT_820_BD.ctrl_desligamento[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_BD.ctrl_desligamento[e.RowIndex].Indice = i;
							break;
						}
						else if (Operators.CompareString(dataPropertyName2, "Col_EDRetDes", false) == 0)
						{
							if (RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_820_BD.ctrl_ret_desligamento[e.RowIndex], ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], 8, ref RT_geral.RT_820_BD.ctrl_ret_acionamento, "", "", "") | RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_820_BD.ctrl_ret_desligamento[e.RowIndex], ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], 8, ref RT_geral.RT_820_BD.ctrl_ED_selecao, "", "", "") | RT_geral.VerificaEDJaUtilizada_FuncoesEspeciais(i, RT_geral.RT_820_BD.config_ED, "") | RT_geral.VerificaEDJaUtilizada_MesmaColuna(8, i, e.RowIndex, ref RT_geral.RT_820_BD.ctrl_ret_desligamento, ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], ""))
							{
								this.DataGridView_processo_820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_820_BD.ctrl_ret_desligamento[e.RowIndex].Indice_padrao];
								break;
							}
							RT_geral.RT_820_BD.ctrl_ret_desligamento[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_BD.ctrl_ret_desligamento[e.RowIndex].Indice = i;
							break;
						}
						else if (Operators.CompareString(dataPropertyName2, "Col_EDRemoto", false) == 0)
						{
							if (RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_820_BD.ctrl_ED_selecao[e.RowIndex], ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], 8, ref RT_geral.RT_820_BD.ctrl_ret_desligamento, "", "", "") | RT_geral.VerificaEDJaUtilizada_DiferenteColuna(i, ref RT_geral.RT_820_BD.ctrl_ED_selecao[e.RowIndex], ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], 8, ref RT_geral.RT_820_BD.ctrl_ret_acionamento, "", "", "") | RT_geral.VerificaEDJaUtilizada_FuncoesEspeciais(i, RT_geral.RT_820_BD.config_ED, "") | RT_geral.VerificaEDJaUtilizada_MesmaColuna(8, i, e.RowIndex, ref RT_geral.RT_820_BD.ctrl_ED_selecao, ref RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex], ""))
							{
								this.DataGridView_processo_820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_820_BD.ctrl_ED_selecao[e.RowIndex].Indice_padrao];
								break;
							}
							RT_geral.RT_820_BD.ctrl_ED_selecao[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_BD.ctrl_ED_selecao[e.RowIndex].Indice = i;
							break;
						}
						else
						{
							if (Operators.CompareString(dataPropertyName2, "Col_EDBloqueio", false) == 0)
							{
								RT_geral.RT_820_BD.ctrl_ED_bloqueio[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_BD.ctrl_ED_bloqueio[e.RowIndex].Indice = i;
								break;
							}
							if (Operators.CompareString(dataPropertyName2, "Col_EDLiberar", false) == 0)
							{
								RT_geral.RT_820_BD.ctrl_ED_liberacao[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_BD.ctrl_ED_liberacao[e.RowIndex].Indice = i;
								break;
							}
							if (Operators.CompareString(dataPropertyName2, "Col_Reverso", false) == 0)
							{
								RT_geral.RT_820_BD.ctrl_reverso[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_BD.ctrl_reverso[e.RowIndex].Indice = i;
								break;
							}
							if (Operators.CompareString(dataPropertyName2, "Col_ModoCtrl", false) == 0)
							{
								RT_geral.RT_820_BD.ctrl_modo[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_BD.ctrl_modo[e.RowIndex].Indice = i;
								break;
							}
							if (Operators.CompareString(dataPropertyName2, "Col_GrupoCtrl", false) == 0)
							{
								RT_geral.RT_820_BD.ctrl_agrupamento[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewProcessosColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_BD.ctrl_agrupamento[e.RowIndex].Indice = i;
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

		// Token: 0x06001898 RID: 6296 RVA: 0x00395E34 File Offset: 0x00394234
		private void DataGridView_processo_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_processo_820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_TpMaxPart", false) == 0)
				{
					RT_geral.RT_820_BD.ctrl_tempo_max_partida[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.ctrl_tempo_max_partida[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_TpMaxParada", false) == 0)
				{
					RT_geral.RT_820_BD.ctrl_tempo_max_parada[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.ctrl_tempo_max_parada[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_TpMinParado", false) == 0)
				{
					RT_geral.RT_820_BD.ctrl_tempo_min_parado[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.ctrl_tempo_min_parado[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_TpMinOperan", false) == 0)
				{
					RT_geral.RT_820_BD.ctrl_tempo_min_operando[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.ctrl_tempo_min_operando[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x0039600C File Offset: 0x0039440C
		private void DataGridView_processo_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_processo_820.IsCurrentCellDirty)
			{
				this.DataGridView_processo_820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x0039602C File Offset: 0x0039442C
		private void DataGridView_grupos_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
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
					int i = Convert.ToInt32(num);
					while (i <= num2)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewGruposColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							string dataPropertyName2 = this.DataGridView_grupos_820.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName2, "Col_ASimultaneos", false) == 0)
							{
								RT_geral.RT_820_BD.grupo_simultaneos[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewGruposColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_BD.grupo_simultaneos[e.RowIndex].Indice = i;
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
					RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_grupos_820.Rows[e.RowIndex].Cells[1].Value);
				}
			}
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00396228 File Offset: 0x00394628
		private void DataGridView_grupos_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_grupos_820.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_TpAcionamentos", false) == 0)
			{
				RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos[e.RowIndex].Valor = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue))));
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos[e.RowIndex], e, true);
				sender = dataGridView;
			}
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x003962BC File Offset: 0x003946BC
		private void DataGridView_grupos_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_grupos_820.IsCurrentCellDirty)
			{
				this.DataGridView_grupos_820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x003962DC File Offset: 0x003946DC
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
				RT_geral.RT_820_BD.EA_Range[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_parametros_EA_820.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(dataPropertyName, "Col_ini", false) == 0)
			{
				this.DataGridView_parametros_EA_820.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_parametros_EA_820.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_BD.EA_Inicio[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_parametros_EA_820.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(dataPropertyName, "Col_fim", false) == 0)
			{
				this.DataGridView_parametros_EA_820.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_parametros_EA_820.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_BD.EA_Fim[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_parametros_EA_820.Rows[e.RowIndex].Cells[2].Value);
			}
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00396530 File Offset: 0x00394930
		private void DataGridView_parametros_EA_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_parametros_EA_820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_range", false) == 0)
				{
					RT_geral.RT_820_BD.EA_Range[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.EA_Range[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_ini", false) == 0)
				{
					RT_geral.RT_820_BD.EA_Inicio[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.EA_Inicio[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_fim", false) == 0)
				{
					RT_geral.RT_820_BD.EA_Fim[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.EA_Fim[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00396698 File Offset: 0x00394A98
		private void DataGridView_parametros_EA_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_parametros_EA_820.IsCurrentCellDirty)
			{
				this.DataGridView_parametros_EA_820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x003966B8 File Offset: 0x00394AB8
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
					int i = Convert.ToInt32(num);
					while (i <= num2)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewSetpointsColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							string dataPropertyName2 = this.DataGridView_setpoints_820.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName2, "Col_Set_Controle", false) == 0)
							{
								RT_geral.RT_820_BD.Setpoints_ctrl_variavel[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewSetpointsColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_BD.Setpoints_ctrl_variavel[e.RowIndex].Indice = i;
								break;
							}
							if (Operators.CompareString(dataPropertyName2, "Col_Set_Bloqueio", false) == 0)
							{
								RT_geral.RT_820_BD.Setpoints_ctrl_bloqueio[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewSetpointsColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_BD.Setpoints_ctrl_bloqueio[e.RowIndex].Indice = i;
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
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[2].Value);
					if (RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[e.RowIndex].Valor = RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[e.RowIndex].Valor * 40;
					}
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NBaixo", false) == 0)
				{
					this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[1].Value);
					if (RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex].Valor = RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex].Valor * 40;
					}
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NBloq", false) == 0)
				{
					this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[4].Value));
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[4].Value);
					if (RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[e.RowIndex].Valor = RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[e.RowIndex].Valor * 40;
					}
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NLib", false) == 0)
				{
					this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_setpoints_820.Rows[e.RowIndex].Cells[5].Value);
					if (RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[e.RowIndex].Valor = RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[e.RowIndex].Valor * 40;
					}
				}
			}
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00396C78 File Offset: 0x00395078
		private void DataGridView_setpoints_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_setpoints_820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_Set_NAlto", false) == 0)
				{
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					if (RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[e.RowIndex].Valor = RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[e.RowIndex].Valor * 40;
					}
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NBaixo", false) == 0)
				{
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					if (RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex].Valor = RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex].Valor * 40;
					}
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NBloq", false) == 0)
				{
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					if (RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[e.RowIndex].Valor = RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[e.RowIndex].Valor * 40;
					}
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_Set_NLib", false) == 0)
				{
					RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					if (RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[e.RowIndex].Valor = RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[e.RowIndex].Valor * 40;
					}
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00396F80 File Offset: 0x00395380
		private void DataGridView_setpoints_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_setpoints_820.IsCurrentCellDirty)
			{
				this.DataGridView_setpoints_820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00396FA0 File Offset: 0x003953A0
		private void DataGridView_periferico_RT820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_periferico_RT820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_modelo", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_periferico_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_820_DataGrigViewPerifericosColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					for (int i = Convert.ToInt32(num); i <= num2; i++)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewPerifericosColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							RT_geral.RT_820_BD.config_perifericos_mod[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewPerifericosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_BD.config_perifericos_mod[e.RowIndex].Indice = i;
							break;
						}
					}
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end", false) == 0)
				{
					this.DataGridView_periferico_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_periferico_RT820.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_BD.config_perifericos_end[e.RowIndex].Valor = Conversions.ToInteger(this.DataGridView_periferico_RT820.Rows[e.RowIndex].Cells[1].Value);
				}
			}
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00397168 File Offset: 0x00395568
		private void DataGridView_periferico_RT820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_periferico_RT820.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_end", false) == 0)
			{
				RT_geral.RT_820_BD.config_perifericos_end[e.RowIndex].Valor = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue))));
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_perifericos_end[e.RowIndex], e, true);
				sender = dataGridView;
			}
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x003971FC File Offset: 0x003955FC
		private void DataGridView_periferico_RT820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_periferico_RT820.IsCurrentCellDirty)
			{
				this.DataGridView_periferico_RT820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0039721C File Offset: 0x0039561C
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
					int i = Convert.ToInt32(num);
					while (i <= num2)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewVazoesColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							string dataPropertyName2 = this.DataGridView_vazoes_RT820.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName2, "Col_Entrada", false) == 0)
							{
								RT_geral.RT_820_BD.config_vazao[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewVazoesColunas[e.ColumnIndex].LinhasValor[i];
								RT_geral.RT_820_BD.config_vazao[e.RowIndex].Indice = i;
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

		// Token: 0x060018A7 RID: 6311 RVA: 0x00397358 File Offset: 0x00395758
		private void DataGridView_vazoes_RT820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0039735C File Offset: 0x0039575C
		private void DataGridView_vazoes_RT820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_vazoes_RT820.IsCurrentCellDirty)
			{
				this.DataGridView_vazoes_RT820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x0039737C File Offset: 0x0039577C
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
					int i = Convert.ToInt32(num);
					while (i <= num2)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewEDColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							string dataPropertyName2 = this.DataGridView_RT820_ED.Columns[e.ColumnIndex].DataPropertyName;
							if (Operators.CompareString(dataPropertyName2, "Col_Entrada", false) == 0)
							{
								if (!RT_geral.VerificaFuncaoJaUtilizada(i, e.RowIndex, RT_geral.RT_820_BD.config_ED, RT_geral.RT_820_BD.HabExpIO.Valor) & !RT_geral.VerificaEDdaFuncaoJaUtilizada(e.RowIndex + 1, i, 8, ref RT_geral.RT_820_BD.ctrl_ret_desligamento) & !RT_geral.VerificaEDdaFuncaoJaUtilizada(e.RowIndex + 1, i, 8, ref RT_geral.RT_820_BD.ctrl_ED_selecao) & !RT_geral.VerificaEDdaFuncaoJaUtilizada(e.RowIndex + 1, i, 8, ref RT_geral.RT_820_BD.ctrl_ret_acionamento))
								{
									RT_geral.RT_820_BD.config_ED[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewEDColunas[e.ColumnIndex].LinhasValor[i];
									RT_geral.RT_820_BD.config_ED[e.RowIndex].Indice = i;
								}
								else
								{
									this.DataGridView_RT820_ED.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RT_geral.RT_820_DataGrigViewEDColunas[e.ColumnIndex].LinhasMenu[RT_geral.RT_820_BD.config_ED[e.RowIndex].Indice_padrao];
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

		// Token: 0x060018AA RID: 6314 RVA: 0x0039759C File Offset: 0x0039599C
		private void DataGridView_RT820_ED_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_RT820_ED.IsCurrentCellDirty)
			{
				this.DataGridView_RT820_ED.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x003975BC File Offset: 0x003959BC
		private void DataGridView_end_rep_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_end_rep_RT820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_end_1", false) == 0)
				{
					RT_geral.RT_820_BD.Repetidoras[0 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.Repetidoras[0 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_2", false) == 0)
				{
					RT_geral.RT_820_BD.Repetidoras[10 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.Repetidoras[10 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_3", false) == 0)
				{
					RT_geral.RT_820_BD.Repetidoras[20 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.Repetidoras[20 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_4", false) == 0)
				{
					RT_geral.RT_820_BD.Repetidoras[30 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.Repetidoras[30 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_5", false) == 0)
				{
					RT_geral.RT_820_BD.Repetidoras[40 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.Repetidoras[40 + e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0039781C File Offset: 0x00395C1C
		private void DataGridView_end_rep_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			string dataPropertyName = this.DataGridView_end_rep_RT820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_end_1", false) == 0)
				{
					int num = 0;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_2", false) == 0)
				{
					int num = 10;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_820_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[3].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_3", false) == 0)
				{
					int num = 20;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_820_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[5].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_4", false) == 0)
				{
					int num = 30;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[7].Value));
					RT_geral.RT_820_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[7].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_5", false) == 0)
				{
					int num = 40;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[9].Value));
					RT_geral.RT_820_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[9].Value);
				}
			}
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00397BF0 File Offset: 0x00395FF0
		private void DataGridView_end_rep_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_end_rep_RT820.IsCurrentCellDirty)
			{
				this.DataGridView_end_rep_RT820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00397C10 File Offset: 0x00396010
		private void DataGridView_timer_RT820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_timer_RT820.IsCurrentCellDirty)
			{
				this.DataGridView_timer_RT820.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00397C30 File Offset: 0x00396030
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

		// Token: 0x060018B0 RID: 6320 RVA: 0x00397D18 File Offset: 0x00396118
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
				RT_geral.RT_820_BD.Timer_Horario[e.RowIndex][e.ColumnIndex].Valor = num3;
			}
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00397EF8 File Offset: 0x003962F8
		private void ToolStripButton_RT_820_Abrir_Click(object sender, EventArgs e)
		{
			checked
			{
				int num = 0;
				int num6 = 0;
				object obj;
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
					this.OpenFileDialog_RT_820.Filter = "Arquivo de configuração de equipamento|*.Cfg820";
					this.OpenFileDialog_RT_820.InitialDirectory = Linha_RT.diretorio;
					if (this.OpenFileDialog_RT_820.ShowDialog() == System.Windows.Forms.DialogResult.OK)
					{
						if (Operators.CompareString(this.OpenFileDialog_RT_820.FileName, "", false) != 0)
						{
							Linha_RT.diretorio = Path.GetDirectoryName(this.OpenFileDialog_RT_820.FileName) + "\\";
							RT_geral.arquivo_extensao = Path.GetExtension(this.OpenFileDialog_RT_820.FileName);
							IniFile iniFile = new IniFile(this.OpenFileDialog_RT_820.FileName);
							RT_geral.RT_820_BD.filename = this.OpenFileDialog_RT_820.FileName;
							RT_geral.RT_820_BD.Equip.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "EQUIPAMENTO", RT_geral.RT_820_BD.Equip.Valor);
							RT_geral.RT_820_BD.Versao.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "VERSAO", RT_geral.RT_820_BD.Versao.Valor);
							RT_geral.RT_820_BD.Build.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "BUILD", RT_geral.RT_820_BD.Build.Valor);
							RT_geral.RT_820_BD.Release.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "RELEASE", RT_geral.RT_820_BD.Release.Valor);
							if (!Linha_RT.VerificaSeEquipamentoEValido(1, RT_geral.RT_820_BD.Equip.Valor, RT_geral.RT_820_BD.Versao.Valor, RT_geral.RT_820_BD.Build.Valor, RT_geral.RT_820_BD.Release.Valor, RT_geral.arquivo_extensao).Status)
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
								RT_geral.RT_820_BD.End_estacao.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "ESTACAO", 0);
								RT_geral.RT_820_BD.End_mestre.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "MESTRE", 0);
								RT_geral.RT_820_BD.TempoForaAr.Valor = iniFile.ReadInteger("GERAL_DIVERSOS", "TEMPO_FORA_AR", 0);
								RT_geral.RT_820_BD.modo_repetidora.Valor = iniFile.ReadInteger("REPETIDORA", "MODO_REPETIDORA", 0);
								RT_geral.RT_820_BD.Tempo_ptt.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "TEMPO_PTT", 0);
								RT_geral.RT_820_BD.BaudRateCOM1.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "BAUDRATE_COM1", Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate)));
								if (!perifericos.Lista_ValorPermitido(RT_geral.RT_820_BD.BaudRateCOM1.Valor, perifericos.ListaBaudRate))
								{
									RT_geral.RT_820_BD.BaudRateCOM1.Valor = Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate));
								}
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_BD.BaudRateCOM1, RT_geral.RT_820_BD.BaudRateCOM1.Valor);
								RT_geral.RT_820_BD.BaudRateCOM2.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "BAUDRATE_COM2", Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate)));
								if (!perifericos.Lista_ValorPermitido(RT_geral.RT_820_BD.BaudRateCOM2.Valor, perifericos.ListaBaudRate))
								{
									RT_geral.RT_820_BD.BaudRateCOM2.Valor = Conversions.ToInteger(perifericos.Lista_GetValorPadrao(perifericos.ListaBaudRate));
								}
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_BD.BaudRateCOM2, RT_geral.RT_820_BD.BaudRateCOM2.Valor);
								RT_geral.RT_820_BD.AD_Intervalo.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "INTERVALO", 0);
								RT_geral.RT_820_BD.AD_Tamanho_filtro.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "TAMANHO_FILTRO", 0);
								RT_geral.RT_820_BD.HabExpIO.Valor = iniFile.ReadInteger("GERAL_DIVERSOS", "HAB_EXPANSAO_IO", 0);
								if (RT_geral.RT_820_BD.HabExpIO.Valor == 21857)
								{
									this.Atualiza_Expansao_IO_820_300(true);
								}
								else
								{
									this.Atualiza_Expansao_IO_820_300(false);
								}
								this.InicializaEStruturasVariaveis_RT820();
								int num2 = 0;
								string text;
								do
								{
									text = string.Format("ENTRADA_ANALOGICA_{0}", num2 + 1);
									RT_geral.RT_820_BD.EA_Range[num2].Valor = iniFile.ReadInteger(text, "EA_RANGE", 0);
									RT_geral.RT_820_BD.EA_Inicio[num2].Valor = iniFile.ReadInteger(text, "EA_INICIO", 0);
									RT_geral.RT_820_BD.EA_Fim[num2].Valor = iniFile.ReadInteger(text, "EA_FIM", 0);
									num2++;
								}
								while (num2 <= 15);
								num2 = 0;
								do
								{
									text = string.Format("CFG_CONTROLE_{0}", num2 + 1);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_acionamento[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[0], iniFile.ReadInteger(text, "ACIONAMENTO", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_desligamento[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[2], iniFile.ReadInteger(text, "DESLIGAMENTO", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_ret_acionamento[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[1], iniFile.ReadInteger(text, "RET_ACIONAMENTO", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_ret_desligamento[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[3], iniFile.ReadInteger(text, "RET_DESLIGAMENTO", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_ED_selecao[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[4], iniFile.ReadInteger(text, "SELECAO_REMOTO", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_ED_bloqueio[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[5], iniFile.ReadInteger(text, "BLOQUEIO_DIGITAL", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_ED_liberacao[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[6], iniFile.ReadInteger(text, "LIBERACAO_DIGITAL", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_reverso[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[7], iniFile.ReadInteger(text, "SELECAO_REVERSO", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_modo[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[8], iniFile.ReadInteger(text, "MODO_CONTROLE", 0));
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.ctrl_agrupamento[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[9], iniFile.ReadInteger(text, "GRUPO_CONTROLE", 0));
									num2++;
								}
								while (num2 <= 7);
								num2 = 0;
								do
								{
									text = string.Format("GRUPO_CONTROLE_{0}", num2 + 1);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.grupo_simultaneos[num2], RT_geral.RT_820_DataGrigViewProcessosColunas[0], iniFile.ReadInteger(text, "ACIONAMENTO_PERMITIDO", 0));
									RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos[num2].Valor = iniFile.ReadInteger(text, "TEMPO_ENTRE_ACIONAMENTO", 0);
									num2++;
								}
								while (num2 <= 3);
								num2 = 0;
								do
								{
									text = string.Format("CFG_CONTROLE_{0}", num2 + 1);
									RT_geral.RT_820_BD.ctrl_tempo_max_partida[num2].Valor = iniFile.ReadInteger(text, "TEMPO_MAX_PARTIDA", 0);
									RT_geral.RT_820_BD.ctrl_tempo_max_parada[num2].Valor = iniFile.ReadInteger(text, "TEMPO_MAX_PARADA", 0);
									RT_geral.RT_820_BD.ctrl_tempo_min_parado[num2].Valor = iniFile.ReadInteger(text, "TEMPO_MIN_PARADO", 0);
									RT_geral.RT_820_BD.ctrl_tempo_min_operando[num2].Valor = iniFile.ReadInteger(text, "TEMPO_MIN_OPERANDO", 0);
									num2++;
								}
								while (num2 <= 7);
								num2 = 0;
								do
								{
									text = string.Format("CFG{0}_ED", num2 + 1);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.config_ED[num2], RT_geral.RT_820_DataGrigViewEDColunas[0], iniFile.ReadInteger("ENTRADA_DIGITAL", text, 0));
									num2++;
								}
								while (num2 <= 15);
								num2 = 0;
								do
								{
									text = string.Format("V{0}", num2 + 1);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.config_vazao[num2], RT_geral.RT_820_DataGrigViewVazoesColunas[0], iniFile.ReadInteger("VAZAO", text, 0));
									num2++;
								}
								while (num2 <= 7);
								num2 = 0;
								do
								{
									text = string.Format("PERIFERICO{0}", num2 + 1);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.config_perifericos_mod[num2], RT_geral.RT_820_DataGrigViewPerifericosColunas[0], iniFile.ReadInteger(text, "MODELO", 0));
									RT_geral.RT_820_BD.config_perifericos_end[num2].Valor = iniFile.ReadInteger(text, "ENDERECO", 0);
									num2++;
								}
								while (num2 <= 4);
								RT_geral.RT_820_BD.End_repetidora.Valor = iniFile.ReadInteger("REPETIDORA", "ENDERECO", 0);
								RT_geral.RT_820_BD.Num_repetidoras.Valor = iniFile.ReadInteger("REPETIDORA", "NUMERO_REPETIDORAS", 0);
								num2 = 0;
								do
								{
									text = string.Format("RPT{0}", num2 + 1);
									RT_geral.RT_820_BD.Repetidoras[num2].Valor = iniFile.ReadInteger("REPETIDORA", text, 0);
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
									int num3 = 0;
									int num4 = array.Length - 1;
									for (int i = num3; i <= num4; i++)
									{
										RT_geral.RT_820_BD.Timer_Horario[num2][i].Valor = iniFile.ReadInteger(text, array[i], 0);
									}
									num2++;
								}
								while (num2 <= 7);
								RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor = iniFile.ReadInteger("SETPOINT", "TRATAMENTO_PERCENTUAL", 0);
								num2 = 0;
								do
								{
									text = string.Format("SETPOINT{0}", num2 + 1);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.Setpoints_ctrl_variavel[num2], RT_geral.RT_820_DataGrigViewSetpointsColunas[0], iniFile.ReadInteger(text, "CTRL_VARIAVEL", 0));
									RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[num2].Valor = iniFile.ReadInteger(text, "NIVEL_ALTO", 0);
									RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[num2].Valor = iniFile.ReadInteger(text, "NIVEL_BAIXO", 0);
									Linha_RT.Atualiza_estrutura_combo_dataview(ref RT_geral.RT_820_BD.Setpoints_ctrl_bloqueio[num2], RT_geral.RT_820_DataGrigViewSetpointsColunas[3], iniFile.ReadInteger(text, "CTRL_BLOQUEIO", 0));
									RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[num2].Valor = iniFile.ReadInteger(text, "CTRL_NIVEL_BLOQUEIO", 0);
									RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[num2].Valor = iniFile.ReadInteger(text, "CTRL_NIVRL_LIBERACAO", 0);
									num2++;
								}
								while (num2 <= 7);
								num2 = 0;
								do
								{
									text = string.Format("SETPOINT_HORARIO_{0}", num2 + 1);
									int num5 = iniFile.ReadInteger(text, "HORA", 0);
									if (num5 >= 65535)
									{
										num5 = 23;
									}
									RT_geral.RT_820_BD.setpoint_horario[num2].Hora.Valor = num5;
									num5 = iniFile.ReadInteger(text, "MINUTO", 0);
									if (num5 >= 65535)
									{
										num5 = 59;
									}
									RT_geral.RT_820_BD.setpoint_horario[num2].Minuto.Valor = num5;
									num5 = iniFile.ReadInteger(text, "ALTO", 0);
									if (num5 >= 65535)
									{
										num5 = 4000;
									}
									RT_geral.RT_820_BD.setpoint_horario[num2].Alto.Valor = num5;
									num5 = iniFile.ReadInteger(text, "BAIXO", 0);
									if (num5 >= 65535)
									{
										num5 = 4000;
									}
									RT_geral.RT_820_BD.setpoint_horario[num2].Baixo.Valor = num5;
									num2++;
								}
								while (num2 <= 15);
								num2 = 0;
								do
								{
									text = string.Format("REFERENCIA_PERIFERICO_{0}", num2 + 1);
									int num5 = iniFile.ReadInteger(text, "PERIFERICO", 0);
									if (num5 >= 6)
									{
										num5 = 0;
									}
									RT_geral.RT_820_BD.config_referencia_perif_periferico[num2].Valor = num5;
									num5 = iniFile.ReadInteger(text, "END_MEM", 0);
									if (num5 >= RT_geral.RT_820_BD.config_referencia_perif_memoria[num2].Lmte_sup)
									{
										num5 = RT_geral.RT_820_BD.config_referencia_perif_memoria[num2].Lmte_sup;
									}
									RT_geral.RT_820_BD.config_referencia_perif_memoria[num2].Valor = num5;
									num5 = iniFile.ReadInteger(text, "VARIAVEL1", 0);
									if (num5 >= 21)
									{
										num5 = 0;
									}
									RT_geral.RT_820_BD.config_referencia_perif_variavel1[num2].Valor = num5;
									num5 = iniFile.ReadInteger(text, "VARIAVEL2", 0);
									if (num5 >= 17)
									{
										num5 = 0;
									}
									RT_geral.RT_820_BD.config_referencia_perif_variavel2[num2].Valor = num5;
									num5 = iniFile.ReadInteger(text, "ESCALA", 0);
									if (num5 >= RT_geral.RT_820_BD.config_referencia_perif_escala[num2].Lmte_sup)
									{
										num5 = RT_geral.RT_820_BD.config_referencia_perif_escala[num2].Lmte_sup;
									}
									RT_geral.RT_820_BD.config_referencia_perif_escala[num2].Valor = num5;
									num5 = iniFile.ReadInteger(text, "FORMATO", 0);
									if (num5 >= 3)
									{
										num5 = 0;
									}
									RT_geral.RT_820_BD.config_referencia_perif_formato[num2].Valor = num5;
									num5 = iniFile.ReadInteger(text, "BASE10", 0);
									if (num5 >= 3)
									{
										num5 = 0;
									}
									RT_geral.RT_820_BD.config_referencia_perif_base10[num2].Valor = num5;
									num2++;
								}
								while (num2 <= 9);
								text = "ATUADOR1_PERIFERICO";
								RT_geral.RT_820_BD.config_atuador1_perif[0].Valor = iniFile.ReadInteger(text, "PERIFERICO", 0);
								RT_geral.RT_820_BD.config_atuador1_formato[0].Valor = iniFile.ReadInteger(text, "FORMATO", 0);
								RT_geral.RT_820_BD.config_atuador1_base10[0].Valor = iniFile.ReadInteger(text, "BASE10", 0);
								RT_geral.RT_820_BD.config_atuador1_mem[0].Valor = iniFile.ReadInteger(text, "END_MEM", 0);
								RT_geral.RT_820_BD.config_atuador1_var1[0].Valor = iniFile.ReadInteger(text, "VARIAVEL1", 0);
								RT_geral.RT_820_BD.config_atuador1_escala1[0].Valor = iniFile.ReadInteger(text, "ESCALA1", 0);
								RT_geral.RT_820_BD.config_atuador1_var2[0].Valor = iniFile.ReadInteger(text, "VARIAVEL2", 0);
								RT_geral.RT_820_BD.config_atuador1_escala2[0].Valor = iniFile.ReadInteger(text, "ESCALA2", 0);
								RT_geral.RT_820_BD.config_atuador1_histerese[0].Valor = iniFile.ReadInteger(text, "HISTERESE", 0);
								RT_geral.RT_820_BD.config_atuador1_v1baixo[0].Valor = iniFile.ReadInteger(text, "V1BAIXO", 0);
								RT_geral.RT_820_BD.config_atuador1_v1alto[0].Valor = iniFile.ReadInteger(text, "V1ALTO", 0);
								RT_geral.RT_820_BD.config_atuador1_v2baixo[0].Valor = iniFile.ReadInteger(text, "V2BAIXO", 0);
								RT_geral.RT_820_BD.config_atuador1_v2alto[0].Valor = iniFile.ReadInteger(text, "V2ALTO", 0);
								num2 = 0;
								do
								{
									text = string.Format("ATUADOR1_VARIAVEL1_PERIFERICO_{0}", num2 + 1);
									RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[num2].Valor = iniFile.ReadInteger(text, "HORA", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[num2].Valor = iniFile.ReadInteger(text, "MINUTO", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[num2].Valor = iniFile.ReadInteger(text, "REF1", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[num2].Valor = iniFile.ReadInteger(text, "REF2", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[num2].Valor = iniFile.ReadInteger(text, "REF3", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[num2].Valor = iniFile.ReadInteger(text, "REF4", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[num2].Valor = iniFile.ReadInteger(text, "REF5", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[num2].Valor = iniFile.ReadInteger(text, "REF6", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[num2].Valor = iniFile.ReadInteger(text, "SETP1", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[num2].Valor = iniFile.ReadInteger(text, "SETP2", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[num2].Valor = iniFile.ReadInteger(text, "SETP3", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[num2].Valor = iniFile.ReadInteger(text, "SETP4", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[num2].Valor = iniFile.ReadInteger(text, "SETP5", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[num2].Valor = iniFile.ReadInteger(text, "SETP6", 0);
									num2++;
								}
								while (num2 <= 2);
								num2 = 0;
								do
								{
									text = string.Format("ATUADOR1_VARIAVEL2_PERIFERICO_{0}", num2 + 1);
									RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[num2].Valor = iniFile.ReadInteger(text, "REF1", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[num2].Valor = iniFile.ReadInteger(text, "REF2", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[num2].Valor = iniFile.ReadInteger(text, "REF3", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[num2].Valor = iniFile.ReadInteger(text, "REF4", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[num2].Valor = iniFile.ReadInteger(text, "REF5", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[num2].Valor = iniFile.ReadInteger(text, "REF6", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[num2].Valor = iniFile.ReadInteger(text, "SETP1", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[num2].Valor = iniFile.ReadInteger(text, "SETP2", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[num2].Valor = iniFile.ReadInteger(text, "SETP3", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[num2].Valor = iniFile.ReadInteger(text, "SETP4", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[num2].Valor = iniFile.ReadInteger(text, "SETP5", 0);
									RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[num2].Valor = iniFile.ReadInteger(text, "SETP6", 0);
									num2++;
								}
								while (num2 <= 2);
								text = "ATUADOR2_PERIFERICO";
								RT_geral.RT_820_BD.config_atuador2_perif[0].Valor = iniFile.ReadInteger(text, "PERIFERICO", 0);
								RT_geral.RT_820_BD.config_atuador2_formato[0].Valor = iniFile.ReadInteger(text, "FORMATO", 0);
								RT_geral.RT_820_BD.config_atuador2_base10[0].Valor = iniFile.ReadInteger(text, "BASE10", 0);
								RT_geral.RT_820_BD.config_atuador2_mem[0].Valor = iniFile.ReadInteger(text, "END_MEM", 0);
								RT_geral.RT_820_BD.config_atuador2_var1[0].Valor = iniFile.ReadInteger(text, "VARIAVEL1", 0);
								RT_geral.RT_820_BD.config_atuador2_escala1[0].Valor = iniFile.ReadInteger(text, "ESCALA1", 0);
								RT_geral.RT_820_BD.config_atuador2_var2[0].Valor = iniFile.ReadInteger(text, "VARIAVEL2", 0);
								RT_geral.RT_820_BD.config_atuador2_escala2[0].Valor = iniFile.ReadInteger(text, "ESCALA2", 0);
								RT_geral.RT_820_BD.config_atuador2_histerese[0].Valor = iniFile.ReadInteger(text, "HISTERESE", 0);
								RT_geral.RT_820_BD.config_atuador2_v1baixo[0].Valor = iniFile.ReadInteger(text, "V1BAIXO", 0);
								RT_geral.RT_820_BD.config_atuador2_v1alto[0].Valor = iniFile.ReadInteger(text, "V1ALTO", 0);
								RT_geral.RT_820_BD.config_atuador2_v2baixo[0].Valor = iniFile.ReadInteger(text, "V2BAIXO", 0);
								RT_geral.RT_820_BD.config_atuador2_v2alto[0].Valor = iniFile.ReadInteger(text, "V2ALTO", 0);
								num2 = 0;
								do
								{
									text = string.Format("ATUADOR2_VARIAVEL1_PERIFERICO_{0}", num2 + 1);
									RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[num2].Valor = iniFile.ReadInteger(text, "HORA", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[num2].Valor = iniFile.ReadInteger(text, "MINUTO", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[num2].Valor = iniFile.ReadInteger(text, "REF1", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[num2].Valor = iniFile.ReadInteger(text, "REF2", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[num2].Valor = iniFile.ReadInteger(text, "REF3", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[num2].Valor = iniFile.ReadInteger(text, "REF4", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[num2].Valor = iniFile.ReadInteger(text, "REF5", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[num2].Valor = iniFile.ReadInteger(text, "REF6", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[num2].Valor = iniFile.ReadInteger(text, "SETP1", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[num2].Valor = iniFile.ReadInteger(text, "SETP2", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[num2].Valor = iniFile.ReadInteger(text, "SETP3", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[num2].Valor = iniFile.ReadInteger(text, "SETP4", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[num2].Valor = iniFile.ReadInteger(text, "SETP5", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[num2].Valor = iniFile.ReadInteger(text, "SETP6", 0);
									num2++;
								}
								while (num2 <= 2);
								num2 = 0;
								do
								{
									text = string.Format("ATUADOR2_VARIAVEL2_PERIFERICO_{0}", num2 + 1);
									RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[num2].Valor = iniFile.ReadInteger(text, "REF1", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[num2].Valor = iniFile.ReadInteger(text, "REF2", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[num2].Valor = iniFile.ReadInteger(text, "REF3", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[num2].Valor = iniFile.ReadInteger(text, "REF4", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[num2].Valor = iniFile.ReadInteger(text, "REF5", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[num2].Valor = iniFile.ReadInteger(text, "REF6", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[num2].Valor = iniFile.ReadInteger(text, "SETP1", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[num2].Valor = iniFile.ReadInteger(text, "SETP2", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[num2].Valor = iniFile.ReadInteger(text, "SETP3", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[num2].Valor = iniFile.ReadInteger(text, "SETP4", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[num2].Valor = iniFile.ReadInteger(text, "SETP5", 0);
									RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[num2].Valor = iniFile.ReadInteger(text, "SETP6", 0);
									num2++;
								}
								while (num2 <= 2);
								text = "ATUADOR3_PERIFERICO";
								RT_geral.RT_820_BD.config_atuador3_perif[0].Valor = iniFile.ReadInteger(text, "PERIFERICO", 0);
								RT_geral.RT_820_BD.config_atuador3_formato[0].Valor = iniFile.ReadInteger(text, "FORMATO", 0);
								RT_geral.RT_820_BD.config_atuador3_base10[0].Valor = iniFile.ReadInteger(text, "BASE10", 0);
								RT_geral.RT_820_BD.config_atuador3_mem[0].Valor = iniFile.ReadInteger(text, "END_MEM", 0);
								RT_geral.RT_820_BD.config_atuador3_var1[0].Valor = iniFile.ReadInteger(text, "VARIAVEL1", 0);
								RT_geral.RT_820_BD.config_atuador3_escala1[0].Valor = iniFile.ReadInteger(text, "ESCALA1", 0);
								RT_geral.RT_820_BD.config_atuador3_var2[0].Valor = iniFile.ReadInteger(text, "VARIAVEL2", 0);
								RT_geral.RT_820_BD.config_atuador3_escala2[0].Valor = iniFile.ReadInteger(text, "ESCALA2", 0);
								RT_geral.RT_820_BD.config_atuador3_histerese[0].Valor = iniFile.ReadInteger(text, "HISTERESE", 0);
								RT_geral.RT_820_BD.config_atuador3_v1baixo[0].Valor = iniFile.ReadInteger(text, "V1BAIXO", 0);
								RT_geral.RT_820_BD.config_atuador3_v1alto[0].Valor = iniFile.ReadInteger(text, "V1ALTO", 0);
								RT_geral.RT_820_BD.config_atuador3_v2baixo[0].Valor = iniFile.ReadInteger(text, "V2BAIXO", 0);
								RT_geral.RT_820_BD.config_atuador3_v2alto[0].Valor = iniFile.ReadInteger(text, "V2ALTO", 0);
								num2 = 0;
								do
								{
									text = string.Format("ATUADOR3_VARIAVEL1_PERIFERICO_{0}", num2 + 1);
									RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[num2].Valor = iniFile.ReadInteger(text, "HORA", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[num2].Valor = iniFile.ReadInteger(text, "MINUTO", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[num2].Valor = iniFile.ReadInteger(text, "REF1", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[num2].Valor = iniFile.ReadInteger(text, "REF2", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[num2].Valor = iniFile.ReadInteger(text, "REF3", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[num2].Valor = iniFile.ReadInteger(text, "REF4", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[num2].Valor = iniFile.ReadInteger(text, "REF5", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[num2].Valor = iniFile.ReadInteger(text, "REF6", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[num2].Valor = iniFile.ReadInteger(text, "SETP1", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[num2].Valor = iniFile.ReadInteger(text, "SETP2", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[num2].Valor = iniFile.ReadInteger(text, "SETP3", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[num2].Valor = iniFile.ReadInteger(text, "SETP4", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[num2].Valor = iniFile.ReadInteger(text, "SETP5", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[num2].Valor = iniFile.ReadInteger(text, "SETP6", 0);
									num2++;
								}
								while (num2 <= 2);
								num2 = 0;
								do
								{
									text = string.Format("ATUADOR3_VARIAVEL2_PERIFERICO_{0}", num2 + 1);
									RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[num2].Valor = iniFile.ReadInteger(text, "REF1", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[num2].Valor = iniFile.ReadInteger(text, "REF2", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[num2].Valor = iniFile.ReadInteger(text, "REF3", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[num2].Valor = iniFile.ReadInteger(text, "REF4", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[num2].Valor = iniFile.ReadInteger(text, "REF5", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[num2].Valor = iniFile.ReadInteger(text, "REF6", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[num2].Valor = iniFile.ReadInteger(text, "SETP1", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[num2].Valor = iniFile.ReadInteger(text, "SETP2", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[num2].Valor = iniFile.ReadInteger(text, "SETP3", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[num2].Valor = iniFile.ReadInteger(text, "SETP4", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[num2].Valor = iniFile.ReadInteger(text, "SETP5", 0);
									RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[num2].Valor = iniFile.ReadInteger(text, "SETP6", 0);
									num2++;
								}
								while (num2 <= 2);
								text = "ATUADOR4_PERIFERICO";
								RT_geral.RT_820_BD.config_atuador4_perif[0].Valor = iniFile.ReadInteger(text, "PERIFERICO", 0);
								RT_geral.RT_820_BD.config_atuador4_formato[0].Valor = iniFile.ReadInteger(text, "FORMATO", 0);
								RT_geral.RT_820_BD.config_atuador4_base10[0].Valor = iniFile.ReadInteger(text, "BASE10", 0);
								RT_geral.RT_820_BD.config_atuador4_mem[0].Valor = iniFile.ReadInteger(text, "END_MEM", 0);
								RT_geral.RT_820_BD.config_atuador4_var1[0].Valor = iniFile.ReadInteger(text, "VARIAVEL1", 0);
								RT_geral.RT_820_BD.config_atuador4_escala1[0].Valor = iniFile.ReadInteger(text, "ESCALA1", 0);
								RT_geral.RT_820_BD.config_atuador4_var2[0].Valor = iniFile.ReadInteger(text, "VARIAVEL2", 0);
								RT_geral.RT_820_BD.config_atuador4_escala2[0].Valor = iniFile.ReadInteger(text, "ESCALA2", 0);
								RT_geral.RT_820_BD.config_atuador4_histerese[0].Valor = iniFile.ReadInteger(text, "HISTERESE", 0);
								RT_geral.RT_820_BD.config_atuador4_v1baixo[0].Valor = iniFile.ReadInteger(text, "V1BAIXO", 0);
								RT_geral.RT_820_BD.config_atuador4_v1alto[0].Valor = iniFile.ReadInteger(text, "V1ALTO", 0);
								RT_geral.RT_820_BD.config_atuador4_v2baixo[0].Valor = iniFile.ReadInteger(text, "V2BAIXO", 0);
								RT_geral.RT_820_BD.config_atuador4_v2alto[0].Valor = iniFile.ReadInteger(text, "V2ALTO", 0);
								num2 = 0;
								do
								{
									text = string.Format("ATUADOR4_VARIAVEL1_PERIFERICO_{0}", num2 + 1);
									RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[num2].Valor = iniFile.ReadInteger(text, "HORA", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[num2].Valor = iniFile.ReadInteger(text, "MINUTO", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[num2].Valor = iniFile.ReadInteger(text, "REF1", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[num2].Valor = iniFile.ReadInteger(text, "REF2", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[num2].Valor = iniFile.ReadInteger(text, "REF3", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[num2].Valor = iniFile.ReadInteger(text, "REF4", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[num2].Valor = iniFile.ReadInteger(text, "REF5", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[num2].Valor = iniFile.ReadInteger(text, "REF6", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[num2].Valor = iniFile.ReadInteger(text, "SETP1", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[num2].Valor = iniFile.ReadInteger(text, "SETP2", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[num2].Valor = iniFile.ReadInteger(text, "SETP3", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[num2].Valor = iniFile.ReadInteger(text, "SETP4", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[num2].Valor = iniFile.ReadInteger(text, "SETP5", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[num2].Valor = iniFile.ReadInteger(text, "SETP6", 0);
									num2++;
								}
								while (num2 <= 2);
								num2 = 0;
								do
								{
									text = string.Format("ATUADOR4_VARIAVEL2_PERIFERICO_{0}", num2 + 1);
									RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[num2].Valor = iniFile.ReadInteger(text, "REF1", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[num2].Valor = iniFile.ReadInteger(text, "REF2", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[num2].Valor = iniFile.ReadInteger(text, "REF3", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[num2].Valor = iniFile.ReadInteger(text, "REF4", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[num2].Valor = iniFile.ReadInteger(text, "REF5", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[num2].Valor = iniFile.ReadInteger(text, "REF6", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[num2].Valor = iniFile.ReadInteger(text, "SETP1", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[num2].Valor = iniFile.ReadInteger(text, "SETP2", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[num2].Valor = iniFile.ReadInteger(text, "SETP3", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[num2].Valor = iniFile.ReadInteger(text, "SETP4", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[num2].Valor = iniFile.ReadInteger(text, "SETP5", 0);
									RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[num2].Valor = iniFile.ReadInteger(text, "SETP6", 0);
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
					goto IL_2874;
					IL_280F:
					Interaction.MsgBox("Não foi possível carregar os dados", MsgBoxStyle.Question, "Atenção - Erro I/0");
					this.Timer_limpa_MSG_820.Enabled = true;
					goto IL_2874;
					IL_282F:
					num6 = -1;
					throw new InvalidOperationException("Decompiler switch pattern not reconstructed.");
					IL_2845:;
				}
				catch (Exception)
			{
				throw;
			}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_2874:
				if (num6 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0039A7A0 File Offset: 0x00398BA0
		private void ToolStripButton_RT_820_Salvar_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			this.ToolStripButton_RT_820_Abrir.Enabled = false;
			this.ToolStripButton_RT_820_novo.Enabled = false;
			this.ToolStripButton_RT_820_Salvar.Enabled = false;
			this.ToolStripButton_RT_820_Download.Enabled = false;
			this.ToolStripButton_RT_820_Upload.Enabled = false;
			this.SaveFileDialog_RT_820.Filter = "Arquivo de configuração de equipamento|*.Cfg820";
			this.SaveFileDialog_RT_820.InitialDirectory = Linha_RT.diretorio;
			checked
			{
				if (this.SaveFileDialog_RT_820.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
						RT_geral.RT_820_BD.filename = this.SaveFileDialog_RT_820.FileName;
						this.InicializaBarraProgressoTela_RT_820(16);
						iniFileWriteFast.WriteSection("GERAL_INFORMACAO");
						iniFileWriteFast.WriteKey("EQUIPAMENTO", RT_geral.RT_820_BD.Equip.Valor);
						iniFileWriteFast.WriteKey("VERSAO", RT_geral.RT_820_BD.Versao.Valor);
						iniFileWriteFast.WriteKey("BUILD", RT_geral.RT_820_BD.Build.Valor);
						iniFileWriteFast.WriteKey("RELEASE", RT_geral.RT_820_BD.Release.Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("GERAL_PARAM_COMINICACAO");
						iniFileWriteFast.WriteKey("ESTACAO", RT_geral.RT_820_BD.End_estacao.Valor);
						iniFileWriteFast.WriteKey("MESTRE", RT_geral.RT_820_BD.End_mestre.Valor);
						iniFileWriteFast.WriteKey("TEMPO_PTT", RT_geral.RT_820_BD.Tempo_ptt.Valor);
						iniFileWriteFast.WriteKey("BAUDRATE_COM2", RT_geral.RT_820_BD.BaudRateCOM2.Valor);
						iniFileWriteFast.WriteKey("BAUDRATE_COM1", RT_geral.RT_820_BD.BaudRateCOM1.Valor);
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
						iniFileWriteFast.WriteKey("TEMPO_FORA_AR", RT_geral.RT_820_BD.TempoForaAr.Valor);
						iniFileWriteFast.WriteKey("HAB_EXPANSAO_IO", RT_geral.RT_820_BD.HabExpIO.Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						int num = 0;
						string text;
						do
						{
							text = string.Format("CFG_CONTROLE_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("ACIONAMENTO", RT_geral.RT_820_BD.ctrl_acionamento[num].Valor);
							iniFileWriteFast.WriteKey("DESLIGAMENTO", RT_geral.RT_820_BD.ctrl_desligamento[num].Valor);
							iniFileWriteFast.WriteKey("RET_ACIONAMENTO", RT_geral.RT_820_BD.ctrl_ret_acionamento[num].Valor);
							iniFileWriteFast.WriteKey("RET_DESLIGAMENTO", RT_geral.RT_820_BD.ctrl_ret_desligamento[num].Valor);
							iniFileWriteFast.WriteKey("SELECAO_REMOTO", RT_geral.RT_820_BD.ctrl_ED_selecao[num].Valor);
							iniFileWriteFast.WriteKey("BLOQUEIO_DIGITAL", RT_geral.RT_820_BD.ctrl_ED_bloqueio[num].Valor);
							iniFileWriteFast.WriteKey("LIBERACAO_DIGITAL", RT_geral.RT_820_BD.ctrl_ED_liberacao[num].Valor);
							iniFileWriteFast.WriteKey("SELECAO_REVERSO", RT_geral.RT_820_BD.ctrl_reverso[num].Valor);
							iniFileWriteFast.WriteKey("MODO_CONTROLE", RT_geral.RT_820_BD.ctrl_modo[num].Valor);
							iniFileWriteFast.WriteKey("GRUPO_CONTROLE", RT_geral.RT_820_BD.ctrl_agrupamento[num].Valor);
							iniFileWriteFast.WriteKey("TEMPO_MAX_PARTIDA", RT_geral.RT_820_BD.ctrl_tempo_max_partida[num].Valor);
							iniFileWriteFast.WriteKey("TEMPO_MAX_PARADA", RT_geral.RT_820_BD.ctrl_tempo_max_parada[num].Valor);
							iniFileWriteFast.WriteKey("TEMPO_MIN_PARADO", RT_geral.RT_820_BD.ctrl_tempo_min_parado[num].Valor);
							iniFileWriteFast.WriteKey("TEMPO_MIN_OPERANDO", RT_geral.RT_820_BD.ctrl_tempo_min_operando[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 7);
						num = 0;
						do
						{
							text = string.Format("GRUPO_CONTROLE_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("ACIONAMENTO_PERMITIDO", RT_geral.RT_820_BD.grupo_simultaneos[num].Valor);
							iniFileWriteFast.WriteKey("TEMPO_ENTRE_ACIONAMENTO", RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 3);
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("ENTRADA_ANALOGICA");
						iniFileWriteFast.WriteKey("INTERVALO", RT_geral.RT_820_BD.AD_Intervalo.Valor);
						iniFileWriteFast.WriteKey("TAMANHO_FILTRO", RT_geral.RT_820_BD.AD_Tamanho_filtro.Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						num = 0;
						do
						{
							text = string.Format("ENTRADA_ANALOGICA_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("EA_RANGE", RT_geral.RT_820_BD.EA_Range[num].Valor);
							iniFileWriteFast.WriteKey("EA_INICIO", RT_geral.RT_820_BD.EA_Inicio[num].Valor);
							iniFileWriteFast.WriteKey("EA_FIM", RT_geral.RT_820_BD.EA_Fim[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 15);
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("ENTRADA_DIGITAL");
						num = 0;
						do
						{
							text = string.Format("CFG{0}_ED", num + 1);
							iniFileWriteFast.WriteKey(text, RT_geral.RT_820_BD.config_ED[num].Valor);
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
							iniFileWriteFast.WriteKey(text, RT_geral.RT_820_BD.config_vazao[num].Valor);
							num++;
						}
						while (num <= 7);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						num = 0;
						do
						{
							text = string.Format("PERIFERICO{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("MODELO", RT_geral.RT_820_BD.config_perifericos_mod[num].Valor);
							iniFileWriteFast.WriteKey("ENDERECO", RT_geral.RT_820_BD.config_perifericos_end[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 4);
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("SETPOINT");
						iniFileWriteFast.WriteKey("TRATAMENTO_PERCENTUAL", RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor);
						iniFileWriteFast.LineSpace();
						num = 0;
						do
						{
							text = string.Format("SETPOINT{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("CTRL_VARIAVEL", RT_geral.RT_820_BD.Setpoints_ctrl_variavel[num].Valor);
							iniFileWriteFast.WriteKey("NIVEL_ALTO", RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[num].Valor);
							iniFileWriteFast.WriteKey("NIVEL_BAIXO", RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[num].Valor);
							iniFileWriteFast.WriteKey("CTRL_BLOQUEIO", RT_geral.RT_820_BD.Setpoints_ctrl_bloqueio[num].Valor);
							iniFileWriteFast.WriteKey("CTRL_NIVEL_BLOQUEIO", RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[num].Valor);
							iniFileWriteFast.WriteKey("CTRL_NIVRL_LIBERACAO", RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[num].Valor);
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
							iniFileWriteFast.WriteKey("HORA", RT_geral.RT_820_BD.setpoint_horario[num].Hora.Valor);
							iniFileWriteFast.WriteKey("MINUTO", RT_geral.RT_820_BD.setpoint_horario[num].Minuto.Valor);
							iniFileWriteFast.WriteKey("ALTO", RT_geral.RT_820_BD.setpoint_horario[num].Alto.Valor);
							iniFileWriteFast.WriteKey("BAIXO", RT_geral.RT_820_BD.setpoint_horario[num].Baixo.Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 15);
						this.ToolStripProgressBar_RT_820.PerformStep();
						Application.DoEvents();
						num = 0;
						do
						{
							text = string.Format("REFERENCIA_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("PERIFERICO", RT_geral.RT_820_BD.config_referencia_perif_periferico[num].Valor);
							iniFileWriteFast.WriteKey("END_MEM", RT_geral.RT_820_BD.config_referencia_perif_memoria[num].Valor);
							iniFileWriteFast.WriteKey("VARIAVEL1", RT_geral.RT_820_BD.config_referencia_perif_variavel1[num].Valor);
							iniFileWriteFast.WriteKey("VARIAVEL2", RT_geral.RT_820_BD.config_referencia_perif_variavel2[num].Valor);
							iniFileWriteFast.WriteKey("ESCALA", RT_geral.RT_820_BD.config_referencia_perif_escala[num].Valor);
							iniFileWriteFast.WriteKey("FORMATO", RT_geral.RT_820_BD.config_referencia_perif_formato[num].Valor);
							iniFileWriteFast.WriteKey("BASE10", RT_geral.RT_820_BD.config_referencia_perif_base10[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 9);
						Application.DoEvents();
						text = "ATUADOR1_PERIFERICO";
						iniFileWriteFast.WriteSection(text);
						iniFileWriteFast.WriteKey("PERIFERICO", RT_geral.RT_820_BD.config_atuador1_perif[0].Valor);
						iniFileWriteFast.WriteKey("FORMATO", RT_geral.RT_820_BD.config_atuador1_formato[0].Valor);
						iniFileWriteFast.WriteKey("BASE10", RT_geral.RT_820_BD.config_atuador1_base10[0].Valor);
						iniFileWriteFast.WriteKey("END_MEM", RT_geral.RT_820_BD.config_atuador1_mem[0].Valor);
						iniFileWriteFast.WriteKey("VARIAVEL1", RT_geral.RT_820_BD.config_atuador1_var1[0].Valor);
						iniFileWriteFast.WriteKey("ESCALA1", RT_geral.RT_820_BD.config_atuador1_escala1[0].Valor);
						iniFileWriteFast.WriteKey("VARIAVEL2", RT_geral.RT_820_BD.config_atuador1_var2[0].Valor);
						iniFileWriteFast.WriteKey("ESCALA2", RT_geral.RT_820_BD.config_atuador1_escala2[0].Valor);
						iniFileWriteFast.WriteKey("HISTERESE", RT_geral.RT_820_BD.config_atuador1_histerese[0].Valor);
						iniFileWriteFast.WriteKey("V1BAIXO", RT_geral.RT_820_BD.config_atuador1_v1baixo[0].Valor);
						iniFileWriteFast.WriteKey("V1ALTO", RT_geral.RT_820_BD.config_atuador1_v1alto[0].Valor);
						iniFileWriteFast.WriteKey("V2BAIXO", RT_geral.RT_820_BD.config_atuador1_v2baixo[0].Valor);
						iniFileWriteFast.WriteKey("V2ALTO", RT_geral.RT_820_BD.config_atuador1_v2alto[0].Valor);
						iniFileWriteFast.LineSpace();
						num = 0;
						do
						{
							text = string.Format("ATUADOR1_VARIAVEL1_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("HORA", RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[num].Valor);
							iniFileWriteFast.WriteKey("MINUTO", RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[num].Valor);
							iniFileWriteFast.WriteKey("REF1", RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[num].Valor);
							iniFileWriteFast.WriteKey("REF2", RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[num].Valor);
							iniFileWriteFast.WriteKey("REF3", RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[num].Valor);
							iniFileWriteFast.WriteKey("REF4", RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[num].Valor);
							iniFileWriteFast.WriteKey("REF5", RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[num].Valor);
							iniFileWriteFast.WriteKey("REF6", RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[num].Valor);
							iniFileWriteFast.WriteKey("SETP1", RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[num].Valor);
							iniFileWriteFast.WriteKey("SETP2", RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[num].Valor);
							iniFileWriteFast.WriteKey("SETP3", RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[num].Valor);
							iniFileWriteFast.WriteKey("SETP4", RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[num].Valor);
							iniFileWriteFast.WriteKey("SETP5", RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[num].Valor);
							iniFileWriteFast.WriteKey("SETP6", RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 2);
						num = 0;
						do
						{
							text = string.Format("ATUADOR1_VARIAVEL2_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("REF1", RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[num].Valor);
							iniFileWriteFast.WriteKey("REF2", RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[num].Valor);
							iniFileWriteFast.WriteKey("REF3", RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[num].Valor);
							iniFileWriteFast.WriteKey("REF4", RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[num].Valor);
							iniFileWriteFast.WriteKey("REF5", RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[num].Valor);
							iniFileWriteFast.WriteKey("REF6", RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[num].Valor);
							iniFileWriteFast.WriteKey("SETP1", RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[num].Valor);
							iniFileWriteFast.WriteKey("SETP2", RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[num].Valor);
							iniFileWriteFast.WriteKey("SETP3", RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[num].Valor);
							iniFileWriteFast.WriteKey("SETP4", RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[num].Valor);
							iniFileWriteFast.WriteKey("SETP5", RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[num].Valor);
							iniFileWriteFast.WriteKey("SETP6", RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 2);
						text = "ATUADOR2_PERIFERICO";
						iniFileWriteFast.WriteSection(text);
						iniFileWriteFast.WriteKey("PERIFERICO", RT_geral.RT_820_BD.config_atuador2_perif[0].Valor);
						iniFileWriteFast.WriteKey("FORMATO", RT_geral.RT_820_BD.config_atuador2_formato[0].Valor);
						iniFileWriteFast.WriteKey("BASE10", RT_geral.RT_820_BD.config_atuador2_base10[0].Valor);
						iniFileWriteFast.WriteKey("END_MEM", RT_geral.RT_820_BD.config_atuador2_mem[0].Valor);
						iniFileWriteFast.WriteKey("VARIAVEL1", RT_geral.RT_820_BD.config_atuador2_var1[0].Valor);
						iniFileWriteFast.WriteKey("ESCALA1", RT_geral.RT_820_BD.config_atuador2_escala1[0].Valor);
						iniFileWriteFast.WriteKey("VARIAVEL2", RT_geral.RT_820_BD.config_atuador2_var2[0].Valor);
						iniFileWriteFast.WriteKey("ESCALA2", RT_geral.RT_820_BD.config_atuador2_escala2[0].Valor);
						iniFileWriteFast.WriteKey("HISTERESE", RT_geral.RT_820_BD.config_atuador2_histerese[0].Valor);
						iniFileWriteFast.WriteKey("V1BAIXO", RT_geral.RT_820_BD.config_atuador2_v1baixo[0].Valor);
						iniFileWriteFast.WriteKey("V1ALTO", RT_geral.RT_820_BD.config_atuador2_v1alto[0].Valor);
						iniFileWriteFast.WriteKey("V2BAIXO", RT_geral.RT_820_BD.config_atuador2_v2baixo[0].Valor);
						iniFileWriteFast.WriteKey("V2ALTO", RT_geral.RT_820_BD.config_atuador2_v2alto[0].Valor);
						iniFileWriteFast.LineSpace();
						num = 0;
						do
						{
							text = string.Format("ATUADOR2_VARIAVEL1_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("HORA", RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[num].Valor);
							iniFileWriteFast.WriteKey("MINUTO", RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[num].Valor);
							iniFileWriteFast.WriteKey("REF1", RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[num].Valor);
							iniFileWriteFast.WriteKey("REF2", RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[num].Valor);
							iniFileWriteFast.WriteKey("REF3", RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[num].Valor);
							iniFileWriteFast.WriteKey("REF4", RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[num].Valor);
							iniFileWriteFast.WriteKey("REF5", RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[num].Valor);
							iniFileWriteFast.WriteKey("REF6", RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[num].Valor);
							iniFileWriteFast.WriteKey("SETP1", RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[num].Valor);
							iniFileWriteFast.WriteKey("SETP2", RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[num].Valor);
							iniFileWriteFast.WriteKey("SETP3", RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[num].Valor);
							iniFileWriteFast.WriteKey("SETP4", RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[num].Valor);
							iniFileWriteFast.WriteKey("SETP5", RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[num].Valor);
							iniFileWriteFast.WriteKey("SETP6", RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 2);
						num = 0;
						do
						{
							text = string.Format("ATUADOR2_VARIAVEL2_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("REF1", RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[num].Valor);
							iniFileWriteFast.WriteKey("REF2", RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[num].Valor);
							iniFileWriteFast.WriteKey("REF3", RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[num].Valor);
							iniFileWriteFast.WriteKey("REF4", RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[num].Valor);
							iniFileWriteFast.WriteKey("REF5", RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[num].Valor);
							iniFileWriteFast.WriteKey("REF6", RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[num].Valor);
							iniFileWriteFast.WriteKey("SETP1", RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[num].Valor);
							iniFileWriteFast.WriteKey("SETP2", RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[num].Valor);
							iniFileWriteFast.WriteKey("SETP3", RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[num].Valor);
							iniFileWriteFast.WriteKey("SETP4", RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[num].Valor);
							iniFileWriteFast.WriteKey("SETP5", RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[num].Valor);
							iniFileWriteFast.WriteKey("SETP6", RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 2);
						text = "ATUADOR3_PERIFERICO";
						iniFileWriteFast.WriteSection(text);
						iniFileWriteFast.WriteKey("PERIFERICO", RT_geral.RT_820_BD.config_atuador3_perif[0].Valor);
						iniFileWriteFast.WriteKey("FORMATO", RT_geral.RT_820_BD.config_atuador3_formato[0].Valor);
						iniFileWriteFast.WriteKey("BASE10", RT_geral.RT_820_BD.config_atuador3_base10[0].Valor);
						iniFileWriteFast.WriteKey("END_MEM", RT_geral.RT_820_BD.config_atuador3_mem[0].Valor);
						iniFileWriteFast.WriteKey("VARIAVEL1", RT_geral.RT_820_BD.config_atuador3_var1[0].Valor);
						iniFileWriteFast.WriteKey("ESCALA1", RT_geral.RT_820_BD.config_atuador3_escala1[0].Valor);
						iniFileWriteFast.WriteKey("VARIAVEL2", RT_geral.RT_820_BD.config_atuador3_var2[0].Valor);
						iniFileWriteFast.WriteKey("ESCALA2", RT_geral.RT_820_BD.config_atuador3_escala2[0].Valor);
						iniFileWriteFast.WriteKey("HISTERESE", RT_geral.RT_820_BD.config_atuador3_histerese[0].Valor);
						iniFileWriteFast.WriteKey("V1BAIXO", RT_geral.RT_820_BD.config_atuador3_v1baixo[0].Valor);
						iniFileWriteFast.WriteKey("V1ALTO", RT_geral.RT_820_BD.config_atuador3_v1alto[0].Valor);
						iniFileWriteFast.WriteKey("V2BAIXO", RT_geral.RT_820_BD.config_atuador3_v2baixo[0].Valor);
						iniFileWriteFast.WriteKey("V2ALTO", RT_geral.RT_820_BD.config_atuador3_v2alto[0].Valor);
						iniFileWriteFast.LineSpace();
						num = 0;
						do
						{
							text = string.Format("ATUADOR3_VARIAVEL1_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("HORA", RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[num].Valor);
							iniFileWriteFast.WriteKey("MINUTO", RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[num].Valor);
							iniFileWriteFast.WriteKey("REF1", RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[num].Valor);
							iniFileWriteFast.WriteKey("REF2", RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[num].Valor);
							iniFileWriteFast.WriteKey("REF3", RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[num].Valor);
							iniFileWriteFast.WriteKey("REF4", RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[num].Valor);
							iniFileWriteFast.WriteKey("REF5", RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[num].Valor);
							iniFileWriteFast.WriteKey("REF6", RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[num].Valor);
							iniFileWriteFast.WriteKey("SETP1", RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[num].Valor);
							iniFileWriteFast.WriteKey("SETP2", RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[num].Valor);
							iniFileWriteFast.WriteKey("SETP3", RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[num].Valor);
							iniFileWriteFast.WriteKey("SETP4", RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[num].Valor);
							iniFileWriteFast.WriteKey("SETP5", RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[num].Valor);
							iniFileWriteFast.WriteKey("SETP6", RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 2);
						num = 0;
						do
						{
							text = string.Format("ATUADOR3_VARIAVEL2_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("REF1", RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[num].Valor);
							iniFileWriteFast.WriteKey("REF2", RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[num].Valor);
							iniFileWriteFast.WriteKey("REF3", RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[num].Valor);
							iniFileWriteFast.WriteKey("REF4", RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[num].Valor);
							iniFileWriteFast.WriteKey("REF5", RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[num].Valor);
							iniFileWriteFast.WriteKey("REF6", RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[num].Valor);
							iniFileWriteFast.WriteKey("SETP1", RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[num].Valor);
							iniFileWriteFast.WriteKey("SETP2", RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[num].Valor);
							iniFileWriteFast.WriteKey("SETP3", RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[num].Valor);
							iniFileWriteFast.WriteKey("SETP4", RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[num].Valor);
							iniFileWriteFast.WriteKey("SETP5", RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[num].Valor);
							iniFileWriteFast.WriteKey("SETP6", RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 2);
						text = "ATUADOR4_PERIFERICO";
						iniFileWriteFast.WriteSection(text);
						iniFileWriteFast.WriteKey("PERIFERICO", RT_geral.RT_820_BD.config_atuador4_perif[0].Valor);
						iniFileWriteFast.WriteKey("FORMATO", RT_geral.RT_820_BD.config_atuador4_formato[0].Valor);
						iniFileWriteFast.WriteKey("BASE10", RT_geral.RT_820_BD.config_atuador4_base10[0].Valor);
						iniFileWriteFast.WriteKey("END_MEM", RT_geral.RT_820_BD.config_atuador4_mem[0].Valor);
						iniFileWriteFast.WriteKey("VARIAVEL1", RT_geral.RT_820_BD.config_atuador4_var1[0].Valor);
						iniFileWriteFast.WriteKey("ESCALA1", RT_geral.RT_820_BD.config_atuador4_escala1[0].Valor);
						iniFileWriteFast.WriteKey("VARIAVEL2", RT_geral.RT_820_BD.config_atuador4_var2[0].Valor);
						iniFileWriteFast.WriteKey("ESCALA2", RT_geral.RT_820_BD.config_atuador4_escala2[0].Valor);
						iniFileWriteFast.WriteKey("HISTERESE", RT_geral.RT_820_BD.config_atuador4_histerese[0].Valor);
						iniFileWriteFast.WriteKey("V1BAIXO", RT_geral.RT_820_BD.config_atuador4_v1baixo[0].Valor);
						iniFileWriteFast.WriteKey("V1ALTO", RT_geral.RT_820_BD.config_atuador4_v1alto[0].Valor);
						iniFileWriteFast.WriteKey("V2BAIXO", RT_geral.RT_820_BD.config_atuador4_v2baixo[0].Valor);
						iniFileWriteFast.WriteKey("V2ALTO", RT_geral.RT_820_BD.config_atuador4_v2alto[0].Valor);
						iniFileWriteFast.LineSpace();
						num = 0;
						do
						{
							text = string.Format("ATUADOR4_VARIAVEL1_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("HORA", RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[num].Valor);
							iniFileWriteFast.WriteKey("MINUTO", RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[num].Valor);
							iniFileWriteFast.WriteKey("REF1", RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[num].Valor);
							iniFileWriteFast.WriteKey("REF2", RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[num].Valor);
							iniFileWriteFast.WriteKey("REF3", RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[num].Valor);
							iniFileWriteFast.WriteKey("REF4", RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[num].Valor);
							iniFileWriteFast.WriteKey("REF5", RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[num].Valor);
							iniFileWriteFast.WriteKey("REF6", RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[num].Valor);
							iniFileWriteFast.WriteKey("SETP1", RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[num].Valor);
							iniFileWriteFast.WriteKey("SETP2", RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[num].Valor);
							iniFileWriteFast.WriteKey("SETP3", RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[num].Valor);
							iniFileWriteFast.WriteKey("SETP4", RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[num].Valor);
							iniFileWriteFast.WriteKey("SETP5", RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[num].Valor);
							iniFileWriteFast.WriteKey("SETP6", RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 2);
						num = 0;
						do
						{
							text = string.Format("ATUADOR4_VARIAVEL2_PERIFERICO_{0}", num + 1);
							iniFileWriteFast.WriteSection(text);
							iniFileWriteFast.WriteKey("REF1", RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[num].Valor);
							iniFileWriteFast.WriteKey("REF2", RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[num].Valor);
							iniFileWriteFast.WriteKey("REF3", RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[num].Valor);
							iniFileWriteFast.WriteKey("REF4", RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[num].Valor);
							iniFileWriteFast.WriteKey("REF5", RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[num].Valor);
							iniFileWriteFast.WriteKey("REF6", RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[num].Valor);
							iniFileWriteFast.WriteKey("SETP1", RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[num].Valor);
							iniFileWriteFast.WriteKey("SETP2", RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[num].Valor);
							iniFileWriteFast.WriteKey("SETP3", RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[num].Valor);
							iniFileWriteFast.WriteKey("SETP4", RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[num].Valor);
							iniFileWriteFast.WriteKey("SETP5", RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[num].Valor);
							iniFileWriteFast.WriteKey("SETP6", RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[num].Valor);
							iniFileWriteFast.LineSpace();
							num++;
						}
						while (num <= 2);
						iniFileWriteFast.WriteSection("REPETIDORA");
						iniFileWriteFast.WriteKey("MODO_REPETIDORA", RT_geral.RT_820_BD.modo_repetidora.Valor);
						iniFileWriteFast.WriteKey("ENDERECO", RT_geral.RT_820_BD.End_repetidora.Valor);
						iniFileWriteFast.WriteKey("NUMERO_REPETIDORAS", RT_geral.RT_820_BD.Num_repetidoras.Valor);
						num = 0;
						do
						{
							text = string.Format("RPT{0}", num + 1);
							iniFileWriteFast.WriteKey(text, RT_geral.RT_820_BD.Repetidoras[num].Valor);
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
								iniFileWriteFast.WriteKey(array[i], RT_geral.RT_820_BD.Timer_Horario[num][i].Valor);
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

		// Token: 0x060018B3 RID: 6323 RVA: 0x0039CA9C File Offset: 0x0039AE9C
		private void ToolStripButton_RT_820_Upload_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.Config_sistema.tipo_interface == 1)
			{
				if (Comunicacao.VerificaPortaSerialExiste())
				{
					this.Bloqueia_acoes_RT820();
					this.EncerraEdicaoDeCampos_RT820();
					this.Escrita_RT820_conf();
				}
				else
				{
					Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", MsgBoxStyle.Critical, "Atenção");
				}
			}
			else if (Comunicacao.Config_sistema.tipo_interface == 2)
			{
				this.Bloqueia_acoes_RT820();
				this.EncerraEdicaoDeCampos_RT820();
				this.Escrita_RT820_conf();
			}
			else
			{
				Interaction.MsgBox("Não existe definição de tipo de interface de comunicação!\r\nComando não executado!", MsgBoxStyle.Critical, "Atenção");
			}
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0039CB20 File Offset: 0x0039AF20
		private void ToolStripButton_RT_820_novo_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			this.Bloqueia_acoes_RT820();
			this.Inicializa_DadosEStruturaRT820_Default();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			RT_geral.RT_820_BD.filename = "";
			this.Atualiza_TelaRT820();
			this.AtualizaMsgTela_RT_820("Arquivo gerado com sucesso!", 0);
			this.Timer_limpa_MSG_820.Enabled = true;
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0039CB7C File Offset: 0x0039AF7C
		private void ToolStripButton_RT_820_Download_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.Config_sistema.tipo_interface == 1)
			{
				if (Comunicacao.VerificaPortaSerialExiste())
				{
					this.Bloqueia_acoes_RT820();
					this.EncerraEdicaoDeCampos_RT820();
					this.Leitura_RT_820_conf();
				}
				else
				{
					Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", MsgBoxStyle.Critical, "Atenção");
				}
			}
			else if (Comunicacao.Config_sistema.tipo_interface == 2)
			{
				this.Bloqueia_acoes_RT820();
				this.EncerraEdicaoDeCampos_RT820();
				this.Leitura_RT_820_conf();
			}
			else
			{
				Interaction.MsgBox("Não existe definição de tipo de interface de comunicação!\r\nComando não executado!", MsgBoxStyle.Critical, "Atenção");
			}
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0039CC00 File Offset: 0x0039B000
		private void Adiona_Remove_SD_ExpansaoIO(bool valor)
		{
			if (valor)
			{
				if (RT_geral.RT_820_DataGrigViewProcessosColunas[0].NumeroLinhaMenu == 14)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasValor[14] = 21865;
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasMenu[14] = "SD 9";
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasValor[15] = 21866;
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasMenu[15] = "SD 10";
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasValor[16] = 21867;
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasMenu[16] = "SD 11";
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasValor[17] = 21868;
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasMenu[17] = "SD 12";
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].NumeroLinhaMenu = 18;
				}
				if (RT_geral.RT_820_DataGrigViewProcessosColunas[2].NumeroLinhaMenu == 14)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasValor[14] = 21865;
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasMenu[14] = "SD 9";
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasValor[15] = 21866;
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasMenu[15] = "SD 10";
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasValor[16] = 21867;
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasMenu[16] = "SD 11";
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasValor[17] = 21868;
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasMenu[17] = "SD 12";
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].NumeroLinhaMenu = 18;
				}
			}
			else
			{
				if (RT_geral.RT_820_DataGrigViewProcessosColunas[0].NumeroLinhaMenu == 18)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].NumeroLinhaMenu = 14;
				}
				if (RT_geral.RT_820_DataGrigViewProcessosColunas[2].NumeroLinhaMenu == 18)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].NumeroLinhaMenu = 14;
				}
			}
			this.GeraDataGridView_Processos();
			this.DataGridView_processo_820.Refresh();
			this.Atualiza_TelaRT820();
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x0039CE4C File Offset: 0x0039B24C
		public void Leitura_RT_820_conf()
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
			Linha_RT.Atualiza_dados_RT_820(0);
			if (RT_geral.RT_820_BD.Build.Valor >= 30)
			{
				RT_geral.RT_820_300_flag_setpoint_horario = true;
			}
			else
			{
				RT_geral.RT_820_300_flag_setpoint_horario = false;
			}
			if (RT_geral.RT_820_BD.Build.Valor >= 50)
			{
				RT_geral.RT_820_350_flag_referenciaperiferico = true;
				RT_geral.RT_820_350_flag_atuadoresperiferico = true;
			}
			else
			{
				RT_geral.RT_820_350_flag_referenciaperiferico = false;
				RT_geral.RT_820_350_flag_atuadoresperiferico = false;
			}
			if (!Mod_MD.Leitura_pagina_multi_interface(2056, 255, 113).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820_HabilitaExpansao();
			if (RT_geral.RT_820_BD.HabExpIO.Valor == 21857)
			{
				this.Atualiza_Expansao_IO_820_300(true);
			}
			else
			{
				this.Atualiza_Expansao_IO_820_300(false);
			}
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 2", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(2048, 255, 113).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(2048);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 3", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(2161, 255, 94).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(2161);
			if (RT_geral.RT_820_300_flag_setpoint_horario)
			{
				if (!Mod_MD.Leitura_pagina_multi_interface(22528, RT_geral.RT_820_BD.End_estacao.Valor, 48).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT_820(22528);
			}
			if (RT_geral.RT_820_350_flag_referenciaperiferico)
			{
				if (!Mod_MD.Leitura_pagina_multi_interface(24576, RT_geral.RT_820_BD.End_estacao.Valor, 60).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT_820(24576);
			}
			if (RT_geral.RT_820_350_flag_atuadoresperiferico)
			{
				if (!Mod_MD.Leitura_pagina_multi_interface(26624, RT_geral.RT_820_BD.End_estacao.Valor, 87).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT_820(26624);
				if (!Mod_MD.Leitura_pagina_multi_interface(26711, RT_geral.RT_820_BD.End_estacao.Valor, 87).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT_820(26711);
				if (!Mod_MD.Leitura_pagina_multi_interface(26798, RT_geral.RT_820_BD.End_estacao.Valor, 87).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT_820(26798);
				if (!Mod_MD.Leitura_pagina_multi_interface(26885, RT_geral.RT_820_BD.End_estacao.Valor, 87).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT_820(26885);
			}
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 4", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(4096, RT_geral.RT_820_BD.End_estacao.Valor, 52).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(4096);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Passo 5", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(8192, RT_geral.RT_820_BD.End_estacao.Valor, 16).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(8192);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Passo 6", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(10240, RT_geral.RT_820_BD.End_estacao.Valor, 16).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(10240);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Passo 7", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(12288, RT_geral.RT_820_BD.End_estacao.Valor, 16).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(12288);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Passo 8", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina_multi_interface(30720, RT_geral.RT_820_BD.End_estacao.Valor, 96).Status)
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

		// Token: 0x060018B8 RID: 6328 RVA: 0x0039D414 File Offset: 0x0039B814
		public void Escrita_RT820_conf()
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
			if (RT_geral.RT_820_BD.Build.Valor >= 30)
			{
				RT_geral.RT_820_300_flag_setpoint_horario = true;
			}
			else
			{
				RT_geral.RT_820_300_flag_setpoint_horario = false;
			}
			if (RT_geral.RT_820_BD.Build.Valor >= 50)
			{
				RT_geral.RT_820_350_flag_referenciaperiferico = true;
				RT_geral.RT_820_350_flag_atuadoresperiferico = true;
			}
			else
			{
				RT_geral.RT_820_350_flag_referenciaperiferico = false;
				RT_geral.RT_820_350_flag_atuadoresperiferico = false;
			}
			if (RT_geral.RT_820_BD.Build.Valor >= 60)
			{
				string text = string.Concat(new string[]
				{
					"Equipamento lido não é o selecionado!\r\n\r\nInformações obtidas : \r\nEquipamento : ",
					Conversion.Str(RT_geral.RT_820_BD.Equip.Valor),
					"\r\nVersão : ",
					Conversion.Str(RT_geral.RT_820_BD.Versao.Valor),
					"\r\nBuild : ",
					Conversion.Str(RT_geral.RT_820_BD.Build.Valor),
					"\r\nRelease : ",
					Conversion.Str(RT_geral.RT_820_BD.Release.Valor)
				});
				MessageBox.Show(text, " Atenção ", 0, 16);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
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
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(2048, 1, 0).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Escrita de configuração Pag 1B - Etapa 4", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(2161, 1, 0).Status)
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
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(4096, 1, 0).Status)
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
				if (!Mod_MD.Escrita_pagina_RT_multi_interface(22528, 1, 0).Status)
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
				if (!Mod_MD.Escrita_pagina_RT_multi_interface(24576, 1, 0).Status)
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
				if (!Mod_MD.Escrita_pagina_RT_multi_interface(26624, 1, 0).Status)
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
				if (!Mod_MD.Escrita_pagina_RT_multi_interface(26711, 1, 0).Status)
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
				if (!Mod_MD.Escrita_pagina_RT_multi_interface(26798, 1, 0).Status)
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
				if (!Mod_MD.Escrita_pagina_RT_multi_interface(26885, 1, 0).Status)
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
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(8192, 1, 0).Status)
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
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(10240, 1, 0).Status)
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
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(12288, 1, 0).Status)
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
			if (!Mod_MD.Escrita_pagina_RT_multi_interface(30720, 1, 0).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Escrita realizada com sucesso", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			this.Timer_limpa_MSG_820.Enabled = true;
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x0039DE78 File Offset: 0x0039C278
		public void Bloqueia_acoes_RT820()
		{
			this.ToolStripButton_RT_820_Abrir.Enabled = false;
			this.ToolStripButton_RT_820_Download.Enabled = false;
			this.ToolStripButton_RT_820_novo.Enabled = false;
			this.ToolStripButton_RT_820_Salvar.Enabled = false;
			this.ToolStripButton_RT_820_Upload.Enabled = false;
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x0039DEB8 File Offset: 0x0039C2B8
		public void EncerraEdicaoDeCampos_RT820()
		{
			this.DataGridView_end_rep_RT820.EndEdit();
			this.DataGridView_grupos_820.EndEdit();
			this.DataGridView_parametros_EA_820.EndEdit();
			this.DataGridView_periferico_RT820.EndEdit();
			this.DataGridView_processo_820.EndEdit();
			this.DataGridView_RT820_ED.EndEdit();
			this.DataGridView_setpoints_820.EndEdit();
			this.DataGridView_timer_RT820.EndEdit();
			this.DataGridView_vazoes_RT820.EndEdit();
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x0039DF34 File Offset: 0x0039C334
		private void ToolStripButton_RT820_Imprimir_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			using (EnhancedPrintPreviewDialog enhancedPrintPreviewDialog = new EnhancedPrintPreviewDialog())
			{
				enhancedPrintPreviewDialog.Document = this.PrintDocument1;
				enhancedPrintPreviewDialog.ShowDialog();
			}
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x0039DF7C File Offset: 0x0039C37C
		[MethodImpl(72)]
		private void DesenhaRelatorioRT820Pagina1(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, 3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, 0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, 1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_BD.Equip.Valor, RT_geral.RT_820_BD.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 4, "Dados da Estação", true);
			tabelaLinhaInteria.EscreveTituloValorLinha(1, "Local de Instalação", this.TextBox_nome_RT820.Text, 0, 160);
			tabelaLinhaInteria.EscreveTituloValorLinha(2, "Endereço", this.TextBox_endereco_RT820.Text, 0, 90);
			string valor = "iS800 (" + MyProject.Application.Info.Version.ToString() + ")";
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Configurador", valor, 0, 0);
			string valor2 = string.Concat(new string[]
			{
				"RT",
				RT_geral.RT_820_BD.Equip.Valor.ToString(),
				"_",
				RT_geral.RT_820_BD.Versao.Valor.ToString(),
				string.Format("{0:D2}", RT_geral.RT_820_BD.Build.Valor),
				"  R",
				RT_geral.RT_820_BD.Release.Valor.ToString()
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
			tabelaLinhaInteria.EscreveTituloValorLinha(4, "Arquivo", Path.GetFileName(RT_geral.RT_820_BD.filename), 0, 0);
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
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(2, "Endereço da Estação", this.NumericUpDown_end_est_820.Value.ToString(), 0, 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(3, "Tempo de PTT (ms)", this.NumericUpDown_temp_ptt_820.Value.ToString() + " ms", 0, 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(3, "Tempo Fora Ar (s)", this.nud_tempoforaar.Value.ToString() + " s", 300, 450);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 5, "Grupo de Controle", true);
			tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Grupo", 0);
			tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Acionamento Permitidos", 90);
			tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Tempo Entre Acionamentos", 290);
			int num = 1;
			checked
			{
				string valor3;
				do
				{
					valor3 = string.Format("0{0}", num);
					tabelaMeiaLinhaDireita.EscreveValorLinha(num + 1, valor3, 0);
					switch (RT_geral.RT_820_BD.grupo_simultaneos[num - 1].Valor)
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
					tabelaMeiaLinhaDireita.EscreveValorLinha(num + 1, valor3, 100);
					valor3 = string.Format("{0}", RT_geral.RT_820_BD.grupo_tempo_entre_acionamentos[num - 1].Valor);
					tabelaMeiaLinhaDireita.EscreveValorLinha(num + 1, valor3, 300);
					num++;
				}
				while (num <= 4);
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda.GetNextLineAvailable(), 2, "Parâmetros das Interfaces", true);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "BaudRate COM1", 0);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "BaudRate COM2", 250);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(2, "Habilita Expansão I/O", 0);
				valor3 = perifericos.ListaBaudRate[RT_geral.RT_820_BD.BaudRateCOM1.Indice].nome_impressao;
				tabelaMeiaLinhaEsquerda2.EscreveValorLinha(1, valor3, 130);
				valor3 = perifericos.ListaBaudRate[RT_geral.RT_820_BD.BaudRateCOM2.Indice].nome_impressao;
				tabelaMeiaLinhaEsquerda2.EscreveValorLinha(1, valor3, 380);
				valor3 = "???";
				switch (RT_geral.RT_820_BD.HabExpIO.Valor)
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
					470,
					530,
					590,
					660,
					760,
					810,
					865,
					920
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
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Grupo\r\nControle", array[9]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Modo\r\nControle", array[10]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Tempo\r\nPartida", array[11]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Tempo\r\nParada", array[12]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "T. Mín\r\nParado", array[13]);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "T. Mín\r\nOper.", array[14]);
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
					switch (RT_geral.RT_820_BD.ctrl_acionamento[num].Valor)
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
					switch (RT_geral.RT_820_BD.ctrl_ret_acionamento[num].Valor)
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
					switch (RT_geral.RT_820_BD.ctrl_desligamento[num].Valor)
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
					switch (RT_geral.RT_820_BD.ctrl_ret_desligamento[num].Valor)
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
					switch (RT_geral.RT_820_BD.ctrl_ED_selecao[num].Valor)
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
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, array[5]);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_820_BD.ctrl_ED_bloqueio[num].Valor)
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
					switch (RT_geral.RT_820_BD.ctrl_ED_liberacao[num].Valor)
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
					switch (RT_geral.RT_820_BD.ctrl_reverso[num].Valor)
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
					switch (RT_geral.RT_820_BD.ctrl_agrupamento[num].Valor)
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
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, array[9] + 5);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					valor3 = "????";
					switch (RT_geral.RT_820_BD.ctrl_modo[num].Valor)
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
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, valor3, array[10] + 5);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, RT_geral.RT_820_BD.ctrl_tempo_max_partida[num].Valor.ToString(), array[11] + 5);
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, RT_geral.RT_820_BD.ctrl_tempo_max_parada[num].Valor.ToString(), array[12] + 5);
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, RT_geral.RT_820_BD.ctrl_tempo_min_parado[num].Valor.ToString(), array[13] + 5);
					tabelaLinhaInteria3.EscreveValorLinha(num + 3, RT_geral.RT_820_BD.ctrl_tempo_min_operando[num].Valor.ToString(), array[14] + 5);
					num++;
				}
				while (num <= 7);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x0039F2F0 File Offset: 0x0039D6F0
		private void DesenhaRelatorioRT820Pagina2(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, 3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, 0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, 1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_BD.Equip.Valor, RT_geral.RT_820_BD.Versao.Valor);
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
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(num + 2, RT_geral.RT_820_BD.EA_Range[num].Valor.ToString(), 80);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(num + 2, RT_geral.RT_820_BD.EA_Inicio[num].Valor.ToString(), 210);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(num + 2, RT_geral.RT_820_BD.EA_Fim[num].Valor.ToString(), 350);
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
					int valor2 = RT_geral.RT_820_BD.config_ED[num].Valor;
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
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0039F698 File Offset: 0x0039DA98
		private void DesenhaRelatorioRT820Pagina3(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, 3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, 0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, 1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_BD.Equip.Valor, RT_geral.RT_820_BD.Versao.Valor);
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
					switch (RT_geral.RT_820_BD.Setpoints_ctrl_variavel[num].Valor)
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
					tabelaLinhaInteria.EscreveValorLinha(num + 2, RT_geral.RT_820_BD.Setpoints_ctrl_nivel_baixo[num].Valor.ToString(), 230);
					tabelaLinhaInteria.EscreveValorLinha(num + 2, RT_geral.RT_820_BD.Setpoints_ctrl_nivel_alto[num].Valor.ToString(), 330);
					tabelaLinhaInteria.EscreveValorLinha(num + 2, RT_geral.RT_820_BD.Setpoints_ctrl_nivel_bloqueio[num].Valor.ToString(), 660);
					tabelaLinhaInteria.EscreveValorLinha(num + 2, RT_geral.RT_820_BD.Setpoints_ctrl_nivel_liberacao[num].Valor.ToString(), 810);
					num++;
				}
				while (num <= 7);
				num = 0;
				do
				{
					string text = "???";
					switch (RT_geral.RT_820_BD.Setpoints_ctrl_bloqueio[num].Valor)
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
				TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria.GetNextLineAvailable() + 2, 17, "SetPoint Horário", true);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ctrl", 0);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Horário", 80);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Ativar", 220);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Hora", 320);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Minuto", 410);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Alto", 650);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Baixo", 800);
				num = 0;
				do
				{
					if (num % 2 == 0)
					{
						tabelaLinhaInteria2.EscreveTituloLinha(2 + num, string.Format("Ctrl {0}", unchecked((double)num / 2.0 + 1.0)), 0);
						tabelaLinhaInteria2.EscreveValorLinha(2 + num, "1", 80);
					}
					else
					{
						tabelaLinhaInteria2.EscreveValorLinha(2 + num, "2", 80);
					}
					if (RT_geral.RT_820_BD.setpoint_horario[num].Hora.Valor > 128)
					{
						tabelaLinhaInteria2.EscreveValorLinha(2 + num, "Sim", 220);
					}
					else
					{
						tabelaLinhaInteria2.EscreveValorLinha(2 + num, "Não", 220);
					}
					int num2 = RT_geral.RT_820_BD.setpoint_horario[num].Hora.Valor & 127;
					tabelaLinhaInteria2.EscreveValorLinha(2 + num, string.Format("{0}", num2), 320);
					num2 = RT_geral.RT_820_BD.setpoint_horario[num].Minuto.Valor;
					tabelaLinhaInteria2.EscreveValorLinha(2 + num, string.Format("{0}", num2), 410);
					num2 = RT_geral.RT_820_BD.setpoint_horario[num].Alto.Valor;
					tabelaLinhaInteria2.EscreveValorLinha(2 + num, string.Format("{0}", num2), 650);
					num2 = RT_geral.RT_820_BD.setpoint_horario[num].Baixo.Valor;
					tabelaLinhaInteria2.EscreveValorLinha(2 + num, string.Format("{0}", num2), 800);
					num++;
				}
				while (num <= 15);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0039FE58 File Offset: 0x0039E258
		private void DesenhaRelatorioRT820Pagina4(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, 3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, 0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, 1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_BD.Equip.Valor, RT_geral.RT_820_BD.Versao.Valor);
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
					switch (RT_geral.RT_820_BD.config_vazao[i].Valor)
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
					}
					tabelaMeiaLinhaEsquerda.EscreveTituloLinha(i + 2, text, 205);
					i++;
				}
				while (i <= 7);
				TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda.GetNextLineAvailable(), 1, "Repetidora", true);
				string item = RT_geral.RT_820_BD.modo_repetidora.GetItem();
				tabelaLinhaInteria.EscreveTituloValorLinha(1, "Modo", item, 0, 60);
				tabelaLinhaInteria.EscreveTituloValorLinha(1, "End. Mestre", RT_geral.RT_820_BD.End_repetidora.Valor.ToString(), 240, 320);
				tabelaLinhaInteria.EscreveTituloValorLinha(1, "Quantidade End. Repetidos", RT_geral.RT_820_BD.Num_repetidoras.Valor.ToString(), 410, 600);
				int num = RT_geral.RT_820_BD.Num_repetidoras.Valor / 20;
				if (RT_geral.RT_820_BD.Num_repetidoras.Valor > 0)
				{
					if (RT_geral.RT_820_BD.Num_repetidoras.Valor % 20 != 0)
					{
						num++;
					}
					int num2 = 1;
					int num3 = Convert.ToInt32(num);
					for (i = num2; i <= num3; i++)
					{
						tabelaLinhaInteria.AdicionaLinha();
						string text2 = "";
						int num4 = (i - 1) * 20;
						int num5 = (i - 1) * 20 + 19;
						for (int j = num4; j <= num5; j++)
						{
							if (j + 1 < RT_geral.RT_820_BD.Num_repetidoras.Valor)
							{
								text2 = text2 + RT_geral.RT_820_BD.Repetidoras[j].Valor.ToString() + ", ";
							}
							else if (j + 1 == RT_geral.RT_820_BD.Num_repetidoras.Valor)
							{
								text2 += RT_geral.RT_820_BD.Repetidoras[j].Valor.ToString();
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
				object obj2;
				object obj3;
				if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj2, 0, 7, 1, ref obj3, ref obj2))
				{
					do
					{
						object obj4;
						if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 0, Operators.SubtractObject(obj, 1), 1, ref obj4, ref obj))
						{
							do
							{
								object obj5 = RT_geral.RT_820_BD.Timer_Horario[Conversions.ToInteger(obj2)][Conversions.ToInteger(obj)].Valor;
								string text = string.Format("{0:D2}:{1:D2}", Operators.IntDivideObject(obj5, 60), Operators.ModObject(obj5, 60));
								tabelaLinhaInteria2.EscreveValorLinha(Conversions.ToInteger(Operators.AddObject(obj2, 3)), text, array2[Conversions.ToInteger(obj)]);
							}
							while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj4, ref obj));
						}
					}
					while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj2, obj3, ref obj2));
				}
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x003A0764 File Offset: 0x0039EB64
		private void DesenhaRelatorioRT820Pagina5(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, 3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, 0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, 1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_BD.Equip.Valor, RT_geral.RT_820_BD.Versao.Valor);
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 5, 6, "Periféricos", true);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Periférico", 0);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Modelo", 100);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Endereço", 300);
			int num = 0;
			checked
			{
				string text;
				do
				{
					text = string.Format("{0:D2}", num + 1);
					tabelaMeiaLinhaEsquerda.EscreveTituloLinha(num + 2, text, 0);
					text = "???";
					int num2 = RT_geral.RT_820_BD.config_perifericos_mod[num].Valor - 48;
					if (num2 <= perifericos.perif_RT820_300.Count)
					{
						text = perifericos.perif_RT820_300[num2].nome_impressao;
					}
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(num + 2, text, 105);
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(num + 2, RT_geral.RT_820_BD.config_perifericos_end[num].Valor.ToString(), 320);
					num++;
				}
				while (num <= 4);
				TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda.GetNextLineAvailable(), 11, "Referência para Periféricos", true);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Periférico", 50);
				tabelaLinhaInteria.EscreveTituloLinha(1, "End. Memória", 150);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Variável 1", 270);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Variável 2", 400);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Escala", 550);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Formato", 650);
				tabelaLinhaInteria.EscreveTituloLinha(1, "Base10", 800);
				num = 0;
				do
				{
					text = string.Format("{0:D2}", num + 1);
					tabelaLinhaInteria.EscreveTituloLinha(num + 2, text, 0);
					text = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu[RT_geral.RT_820_BD.config_referencia_perif_periferico[num].Indice];
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 55);
					text = RT_geral.RT_820_BD.config_referencia_perif_memoria[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 155);
					text = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasMenu[RT_geral.RT_820_BD.config_referencia_perif_variavel1[num].Indice];
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 275);
					text = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LinhasMenu[RT_geral.RT_820_BD.config_referencia_perif_variavel2[num].Indice];
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 405);
					text = RT_geral.RT_820_BD.config_referencia_perif_escala[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 555);
					text = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasMenu[RT_geral.RT_820_BD.config_referencia_perif_formato[num].Indice];
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 655);
					text = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasMenu[RT_geral.RT_820_BD.config_referencia_perif_base10[num].Indice];
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 805);
					num++;
				}
				while (num <= 9);
				TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria.GetNextLineAvailable(), 2, "Atuador 1", true);
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
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Periférico", array[0]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Memória", array[1]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Variável 1", array[2]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Escala 1", array[3]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Variável 2", array[4]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Escala 2", array[5]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Histerese", array[6]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Formato", array[7]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Base10", array[8]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "V1Baixo", array[9]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "V1Alto", array[10]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "V2Baixo", array[11]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "V2Alto", array[12]);
				text = RT_geral.RT_820_DataGrigViewAtuador1Colunas[0].LinhasMenu[RT_geral.RT_820_BD.config_atuador1_perif[0].Indice];
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[0] + 5);
				text = RT_geral.RT_820_BD.config_atuador1_mem[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[1] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador1Colunas[2].LinhasMenu[RT_geral.RT_820_BD.config_atuador1_var1[0].Indice];
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[2] + 5);
				text = RT_geral.RT_820_BD.config_atuador1_escala1[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[3] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador1Colunas[4].LinhasMenu[RT_geral.RT_820_BD.config_atuador1_var2[0].Indice];
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[4] + 5);
				text = RT_geral.RT_820_BD.config_atuador1_escala2[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[5] + 5);
				text = RT_geral.RT_820_BD.config_atuador1_histerese[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[6] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador1Colunas[7].LinhasMenu[RT_geral.RT_820_BD.config_atuador1_formato[0].Indice];
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[7] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador1Colunas[8].LinhasMenu[RT_geral.RT_820_BD.config_atuador1_base10[0].Indice];
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[8] + 5);
				text = RT_geral.RT_820_BD.config_atuador1_v1baixo[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[9] + 5);
				text = RT_geral.RT_820_BD.config_atuador1_v1alto[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[10] + 5);
				text = RT_geral.RT_820_BD.config_atuador1_v2baixo[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[11] + 5);
				text = RT_geral.RT_820_BD.config_atuador1_v2alto[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[12] + 5);
				TabelaLinhaInteria tabelaLinhaInteria3 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria2.GetNextLineAvailable(), 4, "Atuador 1 Variável 1", true);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Faixa", 0);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Hora", 50);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Minuto", 100);
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
					text = RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 55);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 105);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 205);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 265);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 325);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 385);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 425);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 485);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 545);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 605);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 665);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 725);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 785);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 845);
					num++;
				}
				while (num <= 2);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x003A1368 File Offset: 0x0039F768
		private void DesenhaRelatorioRT820Pagina6(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, 3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, 0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, 1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_BD.Equip.Valor, RT_geral.RT_820_BD.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 4, "Atuador 1 Variável 2", true);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Faixa", 0);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Ref1", 200);
			tabelaLinhaInteria.EscreveTituloLinha(1, "SP1", 260);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Ref2", 320);
			tabelaLinhaInteria.EscreveTituloLinha(1, "SP2", 380);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Ref3", 420);
			tabelaLinhaInteria.EscreveTituloLinha(1, "SP3", 480);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Ref4", 540);
			tabelaLinhaInteria.EscreveTituloLinha(1, "SP4", 600);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Ref5", 660);
			tabelaLinhaInteria.EscreveTituloLinha(1, "SP5", 720);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Ref6", 780);
			tabelaLinhaInteria.EscreveTituloLinha(1, "SP6", 840);
			int num = 0;
			checked
			{
				string text;
				do
				{
					text = string.Format("{0:D2}", num + 1);
					tabelaLinhaInteria.EscreveTituloLinha(num + 2, text, 0);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 205);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 265);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 325);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 385);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 425);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 485);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 545);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 605);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 665);
					text = RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 725);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 785);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 845);
					num++;
				}
				while (num <= 2);
				TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria.GetNextLineAvailable(), 2, "Atuador 2", true);
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
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Periférico", array[0]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Memória", array[1]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Variável 1", array[2]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Escala 1", array[3]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Variável 2", array[4]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Escala 2", array[5]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Histerese", array[6]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Formato", array[7]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Base10", array[8]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "V1Baixo", array[9]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "V1Alto", array[10]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "V2Baixo", array[11]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "V2Alto", array[12]);
				text = RT_geral.RT_820_DataGrigViewAtuador2Colunas[0].LinhasMenu[RT_geral.RT_820_BD.config_atuador2_perif[0].Indice];
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[0] + 5);
				text = RT_geral.RT_820_BD.config_atuador2_mem[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[1] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador2Colunas[2].LinhasMenu[RT_geral.RT_820_BD.config_atuador2_var1[0].Indice];
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[2] + 5);
				text = RT_geral.RT_820_BD.config_atuador2_escala1[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[3] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador2Colunas[4].LinhasMenu[RT_geral.RT_820_BD.config_atuador2_var2[0].Indice];
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[4] + 5);
				text = RT_geral.RT_820_BD.config_atuador2_escala2[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[5] + 5);
				text = RT_geral.RT_820_BD.config_atuador2_histerese[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[6] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador2Colunas[7].LinhasMenu[RT_geral.RT_820_BD.config_atuador2_formato[0].Indice];
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[7] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador2Colunas[8].LinhasMenu[RT_geral.RT_820_BD.config_atuador2_base10[0].Indice];
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[8] + 5);
				text = RT_geral.RT_820_BD.config_atuador2_v1baixo[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[9] + 5);
				text = RT_geral.RT_820_BD.config_atuador2_v1alto[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[10] + 5);
				text = RT_geral.RT_820_BD.config_atuador2_v2baixo[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[11] + 5);
				text = RT_geral.RT_820_BD.config_atuador2_v2alto[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[12] + 5);
				TabelaLinhaInteria tabelaLinhaInteria3 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria2.GetNextLineAvailable(), 4, "Atuador 2 Variável 1", true);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Faixa", 0);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Hora", 50);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Minuto", 100);
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
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 55);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 105);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 205);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 265);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 325);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 385);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 425);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 485);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 545);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 605);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 665);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 725);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 785);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 845);
					num++;
				}
				while (num <= 2);
				TabelaLinhaInteria tabelaLinhaInteria4 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria3.GetNextLineAvailable(), 4, "Atuador 2 Variável 2", true);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Faixa", 0);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Ref1", 200);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "SP1", 260);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Ref2", 320);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "SP2", 380);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Ref3", 420);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "SP3", 480);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Ref4", 540);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "SP4", 600);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Ref5", 660);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "SP5", 720);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Ref6", 780);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "SP6", 840);
				num = 0;
				do
				{
					text = string.Format("{0:D2}", num + 1);
					tabelaLinhaInteria4.EscreveTituloLinha(num + 2, text, 0);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 205);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 265);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 325);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 385);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 425);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 485);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 545);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 605);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 665);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 725);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 785);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 845);
					num++;
				}
				while (num <= 2);
				TabelaLinhaInteria tabelaLinhaInteria5 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria4.GetNextLineAvailable(), 2, "Atuador 3", true);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Periférico", array[0]);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Memória", array[1]);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Variável 1", array[2]);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Escala 1", array[3]);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Variável 2", array[4]);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Escala 2", array[5]);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Histerese", array[6]);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Formato", array[7]);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "Base10", array[8]);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "V1Baixo", array[9]);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "V1Alto", array[10]);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "V2Baixo", array[11]);
				tabelaLinhaInteria5.EscreveTituloLinha(1, "V2Alto", array[12]);
				text = RT_geral.RT_820_DataGrigViewAtuador3Colunas[0].LinhasMenu[RT_geral.RT_820_BD.config_atuador3_perif[0].Indice];
				tabelaLinhaInteria5.EscreveValorLinha(2, text, array[0] + 5);
				text = RT_geral.RT_820_BD.config_atuador3_mem[0].Valor.ToString();
				tabelaLinhaInteria5.EscreveValorLinha(2, text, array[1] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador3Colunas[2].LinhasMenu[RT_geral.RT_820_BD.config_atuador3_var1[0].Indice];
				tabelaLinhaInteria5.EscreveValorLinha(2, text, array[2] + 5);
				text = RT_geral.RT_820_BD.config_atuador2_escala1[0].Valor.ToString();
				tabelaLinhaInteria5.EscreveValorLinha(2, text, array[3] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador3Colunas[4].LinhasMenu[RT_geral.RT_820_BD.config_atuador3_var2[0].Indice];
				tabelaLinhaInteria5.EscreveValorLinha(2, text, array[4] + 5);
				text = RT_geral.RT_820_BD.config_atuador3_escala2[0].Valor.ToString();
				tabelaLinhaInteria5.EscreveValorLinha(2, text, array[5] + 5);
				text = RT_geral.RT_820_BD.config_atuador2_histerese[0].Valor.ToString();
				tabelaLinhaInteria5.EscreveValorLinha(2, text, array[6] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador3Colunas[7].LinhasMenu[RT_geral.RT_820_BD.config_atuador3_formato[0].Indice];
				tabelaLinhaInteria5.EscreveValorLinha(2, text, array[7] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador3Colunas[8].LinhasMenu[RT_geral.RT_820_BD.config_atuador3_base10[0].Indice];
				tabelaLinhaInteria5.EscreveValorLinha(2, text, array[8] + 5);
				text = RT_geral.RT_820_BD.config_atuador3_v1baixo[0].Valor.ToString();
				tabelaLinhaInteria5.EscreveValorLinha(2, text, array[9] + 5);
				text = RT_geral.RT_820_BD.config_atuador3_v1alto[0].Valor.ToString();
				tabelaLinhaInteria5.EscreveValorLinha(2, text, array[10] + 5);
				text = RT_geral.RT_820_BD.config_atuador3_v2baixo[0].Valor.ToString();
				tabelaLinhaInteria5.EscreveValorLinha(2, text, array[11] + 5);
				text = RT_geral.RT_820_BD.config_atuador3_v2alto[0].Valor.ToString();
				tabelaLinhaInteria5.EscreveValorLinha(2, text, array[12] + 5);
				TabelaLinhaInteria tabelaLinhaInteria6 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria5.GetNextLineAvailable(), 4, "Atuador 3 Variável 1", true);
				tabelaLinhaInteria6.EscreveTituloLinha(1, "Faixa", 0);
				tabelaLinhaInteria6.EscreveTituloLinha(1, "Hora", 50);
				tabelaLinhaInteria6.EscreveTituloLinha(1, "Minuto", 100);
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
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 55);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 105);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 205);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 265);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 325);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 385);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 425);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 485);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 545);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 605);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 665);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 725);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 785);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[num].Valor.ToString();
					tabelaLinhaInteria6.EscreveValorLinha(num + 2, text, 845);
					num++;
				}
				while (num <= 2);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x003A2A44 File Offset: 0x003A0E44
		private void DesenhaRelatorioRT820Pagina7(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, (System.Drawing.FontStyle)3);
			Font font2 = new Font("Calibri", 10f, 3, (System.Drawing.GraphicsUnit)3);
			Font font3 = new Font("Calibri", 10f, 0, (System.Drawing.GraphicsUnit)3);
			Font fonte = new Font("Calibri", 20f, 1, (System.Drawing.GraphicsUnit)3);
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_BD.Equip.Valor, RT_geral.RT_820_BD.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 4, "Atuador 3 Variável 2", true);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Faixa", 0);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Ref1", 200);
			tabelaLinhaInteria.EscreveTituloLinha(1, "SP1", 260);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Ref2", 320);
			tabelaLinhaInteria.EscreveTituloLinha(1, "SP2", 380);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Ref3", 420);
			tabelaLinhaInteria.EscreveTituloLinha(1, "SP3", 480);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Ref4", 540);
			tabelaLinhaInteria.EscreveTituloLinha(1, "SP4", 600);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Ref5", 660);
			tabelaLinhaInteria.EscreveTituloLinha(1, "SP5", 720);
			tabelaLinhaInteria.EscreveTituloLinha(1, "Ref6", 780);
			tabelaLinhaInteria.EscreveTituloLinha(1, "SP6", 840);
			int num = 0;
			checked
			{
				string text;
				do
				{
					text = string.Format("{0:D2}", num + 1);
					tabelaLinhaInteria.EscreveTituloLinha(num + 2, text, 0);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 205);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 265);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 325);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 385);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 425);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 485);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 545);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 605);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 665);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 725);
					text = RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 785);
					text = RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[num].Valor.ToString();
					tabelaLinhaInteria.EscreveValorLinha(num + 2, text, 845);
					num++;
				}
				while (num <= 2);
				TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria.GetNextLineAvailable(), 2, "Atuador 4", true);
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
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Periférico", array[0]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Memória", array[1]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Variável 1", array[2]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Escala 1", array[3]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Variável 2", array[4]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Escala 2", array[5]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Histerese", array[6]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Formato", array[7]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "Base10", array[8]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "V1Baixo", array[9]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "V1Alto", array[10]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "V2Baixo", array[11]);
				tabelaLinhaInteria2.EscreveTituloLinha(1, "V2Alto", array[12]);
				text = RT_geral.RT_820_DataGrigViewAtuador4Colunas[0].LinhasMenu[RT_geral.RT_820_BD.config_atuador4_perif[0].Indice];
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[0] + 5);
				text = RT_geral.RT_820_BD.config_atuador4_mem[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[1] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador4Colunas[2].LinhasMenu[RT_geral.RT_820_BD.config_atuador4_var1[0].Indice];
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[2] + 5);
				text = RT_geral.RT_820_BD.config_atuador4_escala1[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[3] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador4Colunas[4].LinhasMenu[RT_geral.RT_820_BD.config_atuador4_var2[0].Indice];
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[4] + 5);
				text = RT_geral.RT_820_BD.config_atuador4_escala2[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[5] + 5);
				text = RT_geral.RT_820_BD.config_atuador4_histerese[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[6] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador4Colunas[7].LinhasMenu[RT_geral.RT_820_BD.config_atuador4_formato[0].Indice];
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[7] + 5);
				text = RT_geral.RT_820_DataGrigViewAtuador4Colunas[8].LinhasMenu[RT_geral.RT_820_BD.config_atuador4_base10[0].Indice];
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[8] + 5);
				text = RT_geral.RT_820_BD.config_atuador4_v1baixo[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[9] + 5);
				text = RT_geral.RT_820_BD.config_atuador4_v1alto[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[10] + 5);
				text = RT_geral.RT_820_BD.config_atuador4_v2baixo[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[11] + 5);
				text = RT_geral.RT_820_BD.config_atuador4_v2alto[0].Valor.ToString();
				tabelaLinhaInteria2.EscreveValorLinha(2, text, array[12] + 5);
				TabelaLinhaInteria tabelaLinhaInteria3 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria2.GetNextLineAvailable(), 4, "Atuador 4 Variável 1", true);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Faixa", 0);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Hora", 50);
				tabelaLinhaInteria3.EscreveTituloLinha(1, "Minuto", 100);
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
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 55);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 105);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 205);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 265);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 325);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 385);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 425);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 485);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 545);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 605);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 665);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 725);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 785);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[num].Valor.ToString();
					tabelaLinhaInteria3.EscreveValorLinha(num + 2, text, 845);
					num++;
				}
				while (num <= 2);
				TabelaLinhaInteria tabelaLinhaInteria4 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria3.GetNextLineAvailable(), 4, "Atuador 4 Variável 2", true);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Faixa", 0);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Ref1", 200);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "SP1", 260);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Ref2", 320);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "SP2", 380);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Ref3", 420);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "SP3", 480);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Ref4", 540);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "SP4", 600);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Ref5", 660);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "SP5", 720);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "Ref6", 780);
				tabelaLinhaInteria4.EscreveTituloLinha(1, "SP6", 840);
				num = 0;
				do
				{
					text = string.Format("{0:D2}", num + 1);
					tabelaLinhaInteria4.EscreveTituloLinha(num + 2, text, 0);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 205);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 265);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 325);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 385);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 425);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 485);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 545);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 605);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 665);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 725);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 785);
					text = RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[num].Valor.ToString();
					tabelaLinhaInteria4.EscreveValorLinha(num + 2, text, 845);
					num++;
				}
				while (num <= 2);
				TabelaLinhaInteria tabelaLinhaInteria5 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria4.GetNextLineAvailable(), 3, "Comentários", true);
				tabelaLinhaInteria5.EscreveValorLinha(1, this.TextBox_comentarios_RT820.Text, 0);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x003A39EC File Offset: 0x003A1DEC
		private bool DesenhaRelatorio(PrintPageEventArgs z)
		{
			checked
			{
				switch (this.pagina_impressao)
				{
				case 1:
					this.DesenhaRelatorioRT820Pagina1(z);
					this.pagina_impressao++;
					return true;
				case 2:
					this.DesenhaRelatorioRT820Pagina2(z);
					this.pagina_impressao++;
					return true;
				case 3:
					this.DesenhaRelatorioRT820Pagina3(z);
					this.pagina_impressao++;
					return true;
				case 4:
					this.DesenhaRelatorioRT820Pagina4(z);
					this.pagina_impressao++;
					return true;
				case 5:
					this.DesenhaRelatorioRT820Pagina5(z);
					this.pagina_impressao++;
					return true;
				case 6:
					this.DesenhaRelatorioRT820Pagina6(z);
					this.pagina_impressao++;
					return true;
				case 7:
					this.DesenhaRelatorioRT820Pagina7(z);
					this.pagina_impressao++;
					return false;
				default:
					return false;
				}
			}
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x003A3ACC File Offset: 0x003A1ECC
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.HasMorePages = this.DesenhaRelatorio(e);
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x003A3ADC File Offset: 0x003A1EDC
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
			}
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x003A3B40 File Offset: 0x003A1F40
		private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
		{
			this.pagina_impressao = 1;
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x003A3B4C File Offset: 0x003A1F4C
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
					int num = RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Hora.Valor;
					if (flag)
					{
						num |= 128;
					}
					else
					{
						num &= 127;
					}
					RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Hora.Valor = num;
				}
				else if (Operators.CompareString(text, "col_sph_hora", false) == 0)
				{
					int num = RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Hora.Valor & 128;
					RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Hora.Valor = Conversions.ToInteger(this.dgv_sph.Rows[e.RowIndex].Cells[2].Value);
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Hora, e, true);
					sender = dataGridView;
					RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Hora.Valor = RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Hora.Valor + num;
				}
				else if (Operators.CompareString(text, "col_sph_minuto", false) == 0)
				{
					RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Minuto.Valor = Conversions.ToInteger(this.dgv_sph.Rows[e.RowIndex].Cells[3].Value);
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Minuto, e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "col_sph_alto", false) == 0)
				{
					RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Alto.Valor = Conversions.ToInteger(this.dgv_sph.Rows[e.RowIndex].Cells[4].Value);
					if (RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Alto.Valor = RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Alto.Valor * 40;
					}
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Alto, e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "col_sph_baixo", false) == 0)
				{
					RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Baixo.Valor = Conversions.ToInteger(this.dgv_sph.Rows[e.RowIndex].Cells[5].Value);
					if (RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
					{
						RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Baixo.Valor = RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Baixo.Valor * 40;
					}
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Baixo, e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x003A3F60 File Offset: 0x003A2360
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
				int num = RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Hora.Valor;
				if (flag)
				{
					num |= 128;
				}
				else
				{
					num &= 127;
				}
				RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Hora.Valor = num;
			}
			else if (Operators.CompareString(text, "col_sph_hora", false) == 0)
			{
				int num = RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Hora.Valor & 128;
				RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Hora.Valor = Conversions.ToInteger(Operators.AddObject(this.dgv_sph.Rows[e.RowIndex].Cells[2].Value, num));
			}
			else if (Operators.CompareString(text, "col_sph_minuto", false) == 0)
			{
				RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Minuto.Valor = Conversions.ToInteger(this.dgv_sph.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "col_sph_alto", false) == 0)
			{
				RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Alto.Valor = Conversions.ToInteger(this.dgv_sph.Rows[e.RowIndex].Cells[4].Value);
				if (RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
				{
					RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Alto.Valor = Conversions.ToInteger(Operators.MultiplyObject(this.dgv_sph.Rows[e.RowIndex].Cells[4].Value, 40));
				}
			}
			else if (Operators.CompareString(text, "col_sph_baixo", false) == 0)
			{
				RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Baixo.Valor = Conversions.ToInteger(this.dgv_sph.Rows[e.RowIndex].Cells[5].Value);
				if (RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor == 1)
				{
					RT_geral.RT_820_BD.setpoint_horario[e.RowIndex].Baixo.Valor = Conversions.ToInteger(Operators.MultiplyObject(this.dgv_sph.Rows[e.RowIndex].Cells[5].Value, 40));
				}
			}
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x003A42AC File Offset: 0x003A26AC
		private void dgv_sph_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_sph.IsCurrentCellDirty)
			{
				this.dgv_sph.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x003A42CC File Offset: 0x003A26CC
		private void cb_ModoRepetidora_SelectedIndexChanged(object sender, EventArgs e)
		{
			object obj = NewLateBinding.LateGet(sender, null, "selectedIndex", new object[0], null, null, null);
			bool flag = false;
			if (Operators.ConditionalCompareObjectEqual(obj, 0, false))
			{
				flag = false;
			}
			else if (Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(obj, 1, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(obj, 2, false))) ? true : false))
			{
				flag = true;
			}
			this.NumericUpDown_end_rep_820.Enabled = flag;
			this.NumericUpDown_num_est_rep_820.Enabled = flag;
			this.GroupBox_end_rep_820.Visible = flag;
			RT_geral.RT_820_BD.modo_repetidora.Valor = RT_geral.RT_820_BD.modo_repetidora.valores[Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "selectedIndex", new object[0], null, null, null))];
			RT_geral.RT_820_BD.modo_repetidora.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null));
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x003A43C8 File Offset: 0x003A27C8
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
					RT_geral.RT_820_BD.config_referencia_perif_memoria[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_referencia_perif_memoria[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName2, "Col_escala", false) == 0)
				{
					RT_geral.RT_820_BD.config_referencia_perif_escala[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_referencia_perif_escala[e.RowIndex], e, true);
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

		// Token: 0x060018CC RID: 6348 RVA: 0x003A452C File Offset: 0x003A292C
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
					RT_geral.RT_820_BD.config_referencia_perif_memoria[e.RowIndex].Valor = Conversions.ToInteger(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_escala", false) == 0)
				{
					this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[4].Value));
					RT_geral.RT_820_BD.config_referencia_perif_escala[e.RowIndex].Valor = Conversions.ToInteger(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[4].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_perif", false) == 0)
				{
					string text = Conversions.ToString(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					for (int i = Convert.ToInt32(num); i <= num2; i++)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							RT_geral.RT_820_BD.config_referencia_perif_periferico[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_BD.config_referencia_perif_periferico[e.RowIndex].Indice = i;
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
							RT_geral.RT_820_BD.config_referencia_perif_variavel1[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_BD.config_referencia_perif_variavel1[e.RowIndex].Indice = i;
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
							RT_geral.RT_820_BD.config_referencia_perif_variavel2[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_BD.config_referencia_perif_variavel2[e.RowIndex].Indice = i;
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
							RT_geral.RT_820_BD.config_referencia_perif_formato[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_BD.config_referencia_perif_formato[e.RowIndex].Indice = i;
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
							RT_geral.RT_820_BD.config_referencia_perif_base10[e.RowIndex].Valor = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_BD.config_referencia_perif_base10[e.RowIndex].Indice = i;
							break;
						}
					}
				}
			}
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x003A4B38 File Offset: 0x003A2F38
		private void datagridview_referenciaperifico_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.datagridview_referenciaperifico.IsCurrentCellDirty)
			{
				this.datagridview_referenciaperifico.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x003A4B58 File Offset: 0x003A2F58
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
					RT_geral.RT_820_BD.config_referencia_perif_memoria[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_referencia_perif_memoria[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala", false) == 0)
				{
					RT_geral.RT_820_BD.config_referencia_perif_escala[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_referencia_perif_escala[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x003A4C60 File Offset: 0x003A3060
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
					RT_geral.RT_820_BD.config_referencia_perif_periferico[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_referencia_perif_periferico[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var1", false) == 0)
				{
					RT_geral.RT_820_BD.config_referencia_perif_variavel1[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_referencia_perif_variavel1[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var2", false) == 0)
				{
					RT_geral.RT_820_BD.config_referencia_perif_variavel2[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_referencia_perif_variavel2[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_formato", false) == 0)
				{
					RT_geral.RT_820_BD.config_referencia_perif_formato[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_referencia_perif_formato[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_base10", false) == 0)
				{
					RT_geral.RT_820_BD.config_referencia_perif_base10[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_referencia_perif_base10[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_endmem", false) == 0)
				{
					this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_BD.config_referencia_perif_memoria[e.RowIndex].Valor = Conversions.ToInteger(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(text, "Col_escala", false) == 0)
				{
					this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[4].Value));
					RT_geral.RT_820_BD.config_referencia_perif_escala[e.RowIndex].Valor = Conversions.ToInteger(this.datagridview_referenciaperifico.Rows[e.RowIndex].Cells[4].Value);
				}
			}
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x003A501C File Offset: 0x003A341C
		private void dgv_atuador1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador1.IsCurrentCellDirty)
			{
				this.dgv_atuador1.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x003A503C File Offset: 0x003A343C
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
					RT_geral.RT_820_BD.config_atuador1_perif[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador1_perif[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_var1[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador1_var1[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_var2[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador1_var2[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_format", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_formato[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador1_formato[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_base10", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_base10[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador1_base10[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_endmem", false) == 0)
				{
					this.dgv_atuador1.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador1.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_BD.config_atuador1_mem[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador1.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(text, "Col_escala1", false) == 0)
				{
					this.dgv_atuador1.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador1.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_820_BD.config_atuador1_escala1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador1.Rows[e.RowIndex].Cells[3].Value);
				}
				else if (Operators.CompareString(text, "Col_escala2", false) == 0)
				{
					this.dgv_atuador1.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador1.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_820_BD.config_atuador1_escala2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador1.Rows[e.RowIndex].Cells[5].Value);
				}
				else if (Operators.CompareString(text, "Col_redut", false) != 0)
				{
					if (Operators.CompareString(text, "Col_hist", false) == 0)
					{
						this.dgv_atuador1.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador1.Rows[e.RowIndex].Cells[6].Value));
						RT_geral.RT_820_BD.config_atuador1_histerese[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador1.Rows[e.RowIndex].Cells[6].Value);
					}
					else if (Operators.CompareString(text, "Col_V1Baixo", false) == 0)
					{
						this.dgv_atuador1.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador1.Rows[e.RowIndex].Cells[9].Value));
						RT_geral.RT_820_BD.config_atuador1_v1baixo[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador1.Rows[e.RowIndex].Cells[9].Value);
					}
					else if (Operators.CompareString(text, "Col_V1Alto", false) == 0)
					{
						this.dgv_atuador1.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador1.Rows[e.RowIndex].Cells[10].Value));
						RT_geral.RT_820_BD.config_atuador1_v1alto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador1.Rows[e.RowIndex].Cells[10].Value);
					}
					else if (Operators.CompareString(text, "Col_V2Baixo", false) == 0)
					{
						this.dgv_atuador1.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador1.Rows[e.RowIndex].Cells[11].Value));
						RT_geral.RT_820_BD.config_atuador1_v2baixo[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador1.Rows[e.RowIndex].Cells[11].Value);
					}
					else if (Operators.CompareString(text, "Col_V2Alto", false) == 0)
					{
						this.dgv_atuador1.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador1.Rows[e.RowIndex].Cells[12].Value));
						RT_geral.RT_820_BD.config_atuador1_v2alto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador1.Rows[e.RowIndex].Cells[12].Value);
					}
				}
			}
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x003A5868 File Offset: 0x003A3C68
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
					RT_geral.RT_820_BD.config_atuador1_mem[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_mem[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_escala1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_escala1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_escala2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_escala2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_redut", false) != 0)
				{
					if (Operators.CompareString(text, "Col_hist", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador1_histerese[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_histerese[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Va11Baixo", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador1_v1baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_v1baixo[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var1Alto", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador1_v1alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_v1alto[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var2Baixo", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador1_v2baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_v2baixo[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var2Alto", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador1_v2alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_v2alto[e.RowIndex], e, true);
						sender = dataGridView;
					}
				}
			}
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x003A5C14 File Offset: 0x003A4014
		private void dgv_atuador_setpoint1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador_setpoint1.IsCurrentCellDirty)
			{
				this.dgv_atuador_setpoint1.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x003A5C34 File Offset: 0x003A4034
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
					RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Minuto", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x003A6258 File Offset: 0x003A4658
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
					RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Minuto", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x003A687C File Offset: 0x003A4C7C
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
				RT_geral.RT_820_BD.config_atuador1_setpoint1_hora[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(text, "Col_Minuto", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint1_minuto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref1", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint1_ref1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[2].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[4].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint1_ref2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[4].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[6].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint1_ref3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[6].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[8].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[8].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint1_ref4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[8].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[10].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint1_ref5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[10].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[12].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint1_ref6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[12].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[3].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint1_setp1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[5].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint1_setp2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[5].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[7].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint1_setp3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[9].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint1_setp4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[9].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[11].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint1_setp5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[11].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
			{
				this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[13].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[13].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint1_setp6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint1.Rows[e.RowIndex].Cells[13].Value);
			}
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x003A72C0 File Offset: 0x003A56C0
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
				RT_geral.RT_820_BD.config_atuador2_setpoint1_hora[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(text, "Col_Minuto", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint1_minuto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref1", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint1_ref1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[2].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[4].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint1_ref2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[4].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[6].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint1_ref3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[6].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[8].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[8].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint1_ref4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[8].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[10].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint1_ref5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[10].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[12].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint1_ref6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[12].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[3].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint1_setp1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[5].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint1_setp2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[5].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[7].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint1_setp3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[9].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint1_setp4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[9].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[11].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint1_setp5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[11].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
			{
				this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[13].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[13].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint1_setp6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint2.Rows[e.RowIndex].Cells[13].Value);
			}
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x003A7D04 File Offset: 0x003A6104
		private void dgv_atuador2_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador2.IsCurrentCellDirty)
			{
				this.dgv_atuador2.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x003A7D24 File Offset: 0x003A6124
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
					RT_geral.RT_820_BD.config_atuador2_mem[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_mem[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_escala1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_escala1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_escala2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_escala2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_redut", false) != 0)
				{
					if (Operators.CompareString(text, "Col_hist", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador2_histerese[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_histerese[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_V1Baixo", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador2_v1baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_v1baixo[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_V1Alto", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador2_v1alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_v1alto[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_V2Baixo", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador2_v2baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_v2baixo[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_V2Alto", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador2_v2alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_v2alto[e.RowIndex], e, true);
						sender = dataGridView;
					}
				}
			}
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x003A80D0 File Offset: 0x003A64D0
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
					RT_geral.RT_820_BD.config_atuador2_perif[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador2_perif[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_var1[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador2_var1[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_var2[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador2_var2[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_format", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_formato[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador2_formato[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_base10", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_base10[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador2_base10[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_endmem", false) == 0)
				{
					this.dgv_atuador2.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador2.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_BD.config_atuador2_mem[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador2.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(text, "Col_escala1", false) == 0)
				{
					this.dgv_atuador2.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador2.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_820_BD.config_atuador2_escala1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador2.Rows[e.RowIndex].Cells[3].Value);
				}
				else if (Operators.CompareString(text, "Col_escala2", false) == 0)
				{
					this.dgv_atuador2.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador2.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_820_BD.config_atuador2_escala2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador2.Rows[e.RowIndex].Cells[5].Value);
				}
				else if (Operators.CompareString(text, "Col_redut", false) != 0)
				{
					if (Operators.CompareString(text, "Col_hist", false) == 0)
					{
						this.dgv_atuador2.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador2.Rows[e.RowIndex].Cells[6].Value));
						RT_geral.RT_820_BD.config_atuador2_histerese[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador2.Rows[e.RowIndex].Cells[6].Value);
					}
					else if (Operators.CompareString(text, "Col_V1Baixo", false) == 0)
					{
						this.dgv_atuador2.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador2.Rows[e.RowIndex].Cells[9].Value));
						RT_geral.RT_820_BD.config_atuador2_v1baixo[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador2.Rows[e.RowIndex].Cells[9].Value);
					}
					else if (Operators.CompareString(text, "Col_V1Alto", false) == 0)
					{
						this.dgv_atuador2.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador2.Rows[e.RowIndex].Cells[10].Value));
						RT_geral.RT_820_BD.config_atuador2_v1alto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador2.Rows[e.RowIndex].Cells[10].Value);
					}
					else if (Operators.CompareString(text, "Col_V2Baixo", false) == 0)
					{
						this.dgv_atuador2.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador2.Rows[e.RowIndex].Cells[11].Value));
						RT_geral.RT_820_BD.config_atuador2_v2baixo[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador2.Rows[e.RowIndex].Cells[11].Value);
					}
					else if (Operators.CompareString(text, "Col_V2Alto", false) == 0)
					{
						this.dgv_atuador2.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador2.Rows[e.RowIndex].Cells[12].Value));
						RT_geral.RT_820_BD.config_atuador2_v2alto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador2.Rows[e.RowIndex].Cells[12].Value);
					}
				}
			}
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x003A88FC File Offset: 0x003A6CFC
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
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x003A8E48 File Offset: 0x003A7248
		private void dgv_atuador_setpoint11_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x003A8E4C File Offset: 0x003A724C
		private void dgv_atuador_setpoint11_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador_setpoint11.IsCurrentCellDirty)
			{
				this.dgv_atuador_setpoint11.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x003A8E6C File Offset: 0x003A726C
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
				RT_geral.RT_820_BD.config_atuador1_setpoint2_ref1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint2_ref2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[2].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[4].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint2_ref3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[4].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[6].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint2_ref4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[6].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[8].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[8].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint2_ref5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[8].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[10].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint2_ref6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[10].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint2_setp1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[3].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint2_setp2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[5].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint2_setp3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[5].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[7].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint2_setp4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[9].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint2_setp5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[9].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
			{
				this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[11].Value));
				RT_geral.RT_820_BD.config_atuador1_setpoint2_setp6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint11.Rows[e.RowIndex].Cells[11].Value);
			}
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x003A973C File Offset: 0x003A7B3C
		private void dgv_atuador_setpoint21_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador_setpoint21.IsCurrentCellDirty)
			{
				this.dgv_atuador_setpoint21.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x003A975C File Offset: 0x003A7B5C
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
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x003A9CA8 File Offset: 0x003A80A8
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
				RT_geral.RT_820_BD.config_atuador2_setpoint2_ref1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint2_ref2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[2].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[4].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint2_ref3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[4].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[6].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint2_ref4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[6].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[8].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[8].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint2_ref5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[8].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[10].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint2_ref6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[10].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint2_setp1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[3].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint2_setp2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[5].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint2_setp3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[5].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[7].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint2_setp4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[9].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint2_setp5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[9].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[11].Value));
				RT_geral.RT_820_BD.config_atuador2_setpoint2_setp6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[11].Value);
			}
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x003AA578 File Offset: 0x003A8978
		private void nud_tempoforaar_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_BD.TempoForaAr.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_BD.TempoForaAr, true);
			sender = numericUpDown;
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x003AA5CC File Offset: 0x003A89CC
		private void dgv_atuador_setpoint2_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador_setpoint2.IsCurrentCellDirty)
			{
				this.dgv_atuador_setpoint2.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x003AA5EC File Offset: 0x003A89EC
		private void TabControl_820_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x003AA5F0 File Offset: 0x003A89F0
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
					RT_geral.RT_820_BD.config_atuador3_mem[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_mem[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_escala1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_escala1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_escala2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_escala2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_redut", false) != 0)
				{
					if (Operators.CompareString(text, "Col_hist", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador3_histerese[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_histerese[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Va11Baixo", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador3_v1baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_v1baixo[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var1Alto", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador3_v1alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_v1alto[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var2Baixo", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador3_v2baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_v2baixo[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var2Alto", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador3_v2alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_v2alto[e.RowIndex], e, true);
						sender = dataGridView;
					}
				}
			}
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x003AA99C File Offset: 0x003A8D9C
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
					RT_geral.RT_820_BD.config_atuador4_mem[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_mem[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_escala1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_escala1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_escala2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_escala2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_escala2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_redut", false) != 0)
				{
					if (Operators.CompareString(text, "Col_hist", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador4_histerese[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_histerese[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Va11Baixo", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador4_v1baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_v1baixo[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var1Alto", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador4_v1alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_v1alto[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var2Baixo", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador4_v2baixo[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_v2baixo[e.RowIndex], e, true);
						sender = dataGridView;
					}
					else if (Operators.CompareString(text, "Col_Var2Alto", false) == 0)
					{
						RT_geral.RT_820_BD.config_atuador4_v2alto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
						DataGridView dataGridView = (DataGridView)sender;
						RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_v2alto[e.RowIndex], e, true);
						sender = dataGridView;
					}
				}
			}
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x003AAD48 File Offset: 0x003A9148
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
					RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Minuto", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x003AB36C File Offset: 0x003A976C
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
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x003AB8B8 File Offset: 0x003A9CB8
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
					RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Minuto", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x003ABEDC File Offset: 0x003AA2DC
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
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x003AC428 File Offset: 0x003AA828
		private void dgv_atuador3_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador3.IsCurrentCellDirty)
			{
				this.dgv_atuador3.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x003AC448 File Offset: 0x003AA848
		private void dgv_atuador4_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador4.IsCurrentCellDirty)
			{
				this.dgv_atuador4.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x003AC468 File Offset: 0x003AA868
		private void dgv_atuador_setpoint3_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador_setpoint3.IsCurrentCellDirty)
			{
				this.dgv_atuador_setpoint3.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x003AC488 File Offset: 0x003AA888
		private void dgv_atuador_setpoint31_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador_setpoint31.IsCurrentCellDirty)
			{
				this.dgv_atuador_setpoint31.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x003AC4A8 File Offset: 0x003AA8A8
		private void dgv_atuador_setpoint4_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador_setpoint4.IsCurrentCellDirty)
			{
				this.dgv_atuador_setpoint4.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x003AC4C8 File Offset: 0x003AA8C8
		private void dgv_atuador_setpoint41_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgv_atuador_setpoint41.IsCurrentCellDirty)
			{
				this.dgv_atuador_setpoint41.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x003AC4E8 File Offset: 0x003AA8E8
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
					RT_geral.RT_820_BD.config_atuador3_perif[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador3_perif[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_var1[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador3_var1[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_var2[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador3_var2[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_format", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_formato[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador3_formato[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_base10", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador3_base10[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador3_base10[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_endmem", false) == 0)
				{
					this.dgv_atuador3.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador3.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_BD.config_atuador3_mem[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador3.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(text, "Col_escala1", false) == 0)
				{
					this.dgv_atuador3.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador3.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_820_BD.config_atuador3_escala1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador3.Rows[e.RowIndex].Cells[3].Value);
				}
				else if (Operators.CompareString(text, "Col_escala2", false) == 0)
				{
					this.dgv_atuador3.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador3.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_820_BD.config_atuador3_escala2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador3.Rows[e.RowIndex].Cells[5].Value);
				}
				else if (Operators.CompareString(text, "Col_redut", false) != 0)
				{
					if (Operators.CompareString(text, "Col_hist", false) == 0)
					{
						this.dgv_atuador3.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador3.Rows[e.RowIndex].Cells[6].Value));
						RT_geral.RT_820_BD.config_atuador3_histerese[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador3.Rows[e.RowIndex].Cells[6].Value);
					}
					else if (Operators.CompareString(text, "Col_V1Baixo", false) == 0)
					{
						this.dgv_atuador3.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador3.Rows[e.RowIndex].Cells[9].Value));
						RT_geral.RT_820_BD.config_atuador3_v1baixo[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador3.Rows[e.RowIndex].Cells[9].Value);
					}
					else if (Operators.CompareString(text, "Col_V1Alto", false) == 0)
					{
						this.dgv_atuador3.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador3.Rows[e.RowIndex].Cells[10].Value));
						RT_geral.RT_820_BD.config_atuador3_v1alto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador3.Rows[e.RowIndex].Cells[10].Value);
					}
					else if (Operators.CompareString(text, "Col_V2Baixo", false) == 0)
					{
						this.dgv_atuador3.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador3.Rows[e.RowIndex].Cells[11].Value));
						RT_geral.RT_820_BD.config_atuador3_v2baixo[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador3.Rows[e.RowIndex].Cells[11].Value);
					}
					else if (Operators.CompareString(text, "Col_V2Alto", false) == 0)
					{
						this.dgv_atuador3.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador3.Rows[e.RowIndex].Cells[12].Value));
						RT_geral.RT_820_BD.config_atuador3_v2alto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador3.Rows[e.RowIndex].Cells[12].Value);
					}
				}
			}
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x003ACD14 File Offset: 0x003AB114
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
					RT_geral.RT_820_BD.config_atuador4_perif[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador4_perif[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var1", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_var1[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador4_var1[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_var2", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_var2[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador4_var2[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_format", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_formato[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador4_formato[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_base10", false) == 0)
				{
					RT_geral.RT_820_BD.config_atuador4_base10[e.RowIndex].Valor = valor;
					RT_geral.RT_820_BD.config_atuador4_base10[e.RowIndex].Indice = num;
				}
				else if (Operators.CompareString(text, "Col_endmem", false) == 0)
				{
					this.dgv_atuador4.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador4.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_BD.config_atuador4_mem[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador4.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(text, "Col_escala1", false) == 0)
				{
					this.dgv_atuador4.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador4.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_820_BD.config_atuador4_escala1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador4.Rows[e.RowIndex].Cells[3].Value);
				}
				else if (Operators.CompareString(text, "Col_escala2", false) == 0)
				{
					this.dgv_atuador4.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador4.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_820_BD.config_atuador4_escala2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador4.Rows[e.RowIndex].Cells[5].Value);
				}
				else if (Operators.CompareString(text, "Col_redut", false) != 0)
				{
					if (Operators.CompareString(text, "Col_hist", false) == 0)
					{
						this.dgv_atuador4.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador4.Rows[e.RowIndex].Cells[6].Value));
						RT_geral.RT_820_BD.config_atuador4_histerese[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador4.Rows[e.RowIndex].Cells[6].Value);
					}
					else if (Operators.CompareString(text, "Col_V1Baixo", false) == 0)
					{
						this.dgv_atuador4.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador4.Rows[e.RowIndex].Cells[9].Value));
						RT_geral.RT_820_BD.config_atuador4_v1baixo[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador4.Rows[e.RowIndex].Cells[9].Value);
					}
					else if (Operators.CompareString(text, "Col_V1Alto", false) == 0)
					{
						this.dgv_atuador4.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador4.Rows[e.RowIndex].Cells[10].Value));
						RT_geral.RT_820_BD.config_atuador4_v1alto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador4.Rows[e.RowIndex].Cells[10].Value);
					}
					else if (Operators.CompareString(text, "Col_V2Baixo", false) == 0)
					{
						this.dgv_atuador4.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador4.Rows[e.RowIndex].Cells[11].Value));
						RT_geral.RT_820_BD.config_atuador4_v2baixo[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador4.Rows[e.RowIndex].Cells[11].Value);
					}
					else if (Operators.CompareString(text, "Col_V2Alto", false) == 0)
					{
						this.dgv_atuador4.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador4.Rows[e.RowIndex].Cells[12].Value));
						RT_geral.RT_820_BD.config_atuador4_v2alto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador4.Rows[e.RowIndex].Cells[12].Value);
					}
				}
			}
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x003AD540 File Offset: 0x003AB940
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
				RT_geral.RT_820_BD.config_atuador3_setpoint1_hora[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(text, "Col_Minuto", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint1_minuto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref1", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint1_ref1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[2].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[4].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint1_ref2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[4].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[6].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint1_ref3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[6].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[8].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[8].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint1_ref4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[8].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[10].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint1_ref5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[10].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[12].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint1_ref6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[12].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[3].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint1_setp1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[5].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint1_setp2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[5].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[7].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint1_setp3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[9].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint1_setp4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[9].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[11].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint1_setp5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[11].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
			{
				this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[13].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[13].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint1_setp6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint3.Rows[e.RowIndex].Cells[13].Value);
			}
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x003ADF84 File Offset: 0x003AC384
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
				RT_geral.RT_820_BD.config_atuador3_setpoint2_ref1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint2_ref2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[2].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[4].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint2_ref3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[4].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[6].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint2_ref4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[6].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[8].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[8].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint2_ref5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[8].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[10].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint2_ref6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[10].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint2_setp1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[3].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint2_setp2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[5].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint2_setp3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[5].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[7].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint2_setp4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[9].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint2_setp5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[9].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
			{
				this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[11].Value));
				RT_geral.RT_820_BD.config_atuador3_setpoint2_setp6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint31.Rows[e.RowIndex].Cells[11].Value);
			}
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x003AE854 File Offset: 0x003ACC54
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
				RT_geral.RT_820_BD.config_atuador4_setpoint1_hora[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(text, "Col_Minuto", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint1_minuto[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref1", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint1_ref1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[2].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[4].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint1_ref2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[4].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[6].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint1_ref3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[6].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[8].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[8].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint1_ref4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[8].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[10].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint1_ref5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[10].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[12].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[12].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint1_ref6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[12].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[3].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint1_setp1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[5].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint1_setp2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[5].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[7].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint1_setp3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[9].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint1_setp4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[9].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[11].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint1_setp5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[11].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
			{
				this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[13].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[13].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint1_setp6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint4.Rows[e.RowIndex].Cells[13].Value);
			}
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x003AF298 File Offset: 0x003AD698
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
				RT_geral.RT_820_BD.config_atuador4_setpoint2_ref1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[0].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref2", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[2].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[2].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint2_ref2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[2].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref3", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[4].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[4].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint2_ref3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[4].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref4", false) == 0)
			{
				this.dgv_atuador_setpoint21.Rows[e.RowIndex].Cells[6].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[6].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint2_ref4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[6].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref5", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[8].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[8].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint2_ref5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[8].Value);
			}
			else if (Operators.CompareString(text, "Col_Ref6", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[10].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[10].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint2_ref6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[10].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp1", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[1].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint2_setp1[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[1].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp2", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[3].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint2_setp2[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[3].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp3", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[5].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint2_setp3[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[5].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp4", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[7].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint2_setp4[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[7].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp5", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[9].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint2_setp5[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[9].Value);
			}
			else if (Operators.CompareString(text, "Col_Sp6", false) == 0)
			{
				this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[11].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[11].Value));
				RT_geral.RT_820_BD.config_atuador4_setpoint2_setp6[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_atuador_setpoint41.Rows[e.RowIndex].Cells[11].Value);
			}
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x003AFB68 File Offset: 0x003ADF68
		private void ComboBox_baudrate_COM1_820_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_BD.BaudRateCOM1.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_820_BD.BaudRateCOM1.AtualizaValorPeloIndice();
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x003AFBA4 File Offset: 0x003ADFA4
		private void ckb_tratamento_setpoint_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null), true, false))
			{
				RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor = 1;
			}
			else
			{
				RT_geral.RT_820_BD.Setpoint_ctrl_tratamento_percentual.Valor = 0;
			}
			this.Atualiza_TelaRT820();
		}

		// Token: 0x04000BFF RID: 3071
		[AccessedThroughProperty("GroupBox_sistema_leitura")]
		private GroupBox _GroupBox_sistema_leitura;

		// Token: 0x04000C00 RID: 3072
		[AccessedThroughProperty("CheckBox_hab_eletrodos")]
		private CheckBox _CheckBox_hab_eletrodos;

		// Token: 0x04000C01 RID: 3073
		[AccessedThroughProperty("GroupBox_operacao")]
		private GroupBox _GroupBox_operacao;

		// Token: 0x04000C02 RID: 3074
		[AccessedThroughProperty("ComboBox_metodo_operacao")]
		private ComboBox _ComboBox_metodo_operacao;

		// Token: 0x04000C03 RID: 3075
		[AccessedThroughProperty("NumericUpDown_intervalo_tx")]
		private NumericUpDown _NumericUpDown_intervalo_tx;

		// Token: 0x04000C04 RID: 3076
		[AccessedThroughProperty("Label_metodo_operacao")]
		private Label _Label_metodo_operacao;

		// Token: 0x04000C05 RID: 3077
		[AccessedThroughProperty("Label_intevalo_tx_pto_pto")]
		private Label _Label_intevalo_tx_pto_pto;

		// Token: 0x04000C06 RID: 3078
		[AccessedThroughProperty("GroupBox_informacoes")]
		private GroupBox _GroupBox_informacoes;

		// Token: 0x04000C07 RID: 3079
		[AccessedThroughProperty("TextBox_equipamento")]
		private TextBox _TextBox_equipamento;

		// Token: 0x04000C08 RID: 3080
		[AccessedThroughProperty("Label_equipamento")]
		private Label _Label_equipamento;

		// Token: 0x04000C09 RID: 3081
		[AccessedThroughProperty("TextBox_release")]
		private TextBox _TextBox_release;

		// Token: 0x04000C0A RID: 3082
		[AccessedThroughProperty("Label_release")]
		private Label _Label_release;

		// Token: 0x04000C0B RID: 3083
		[AccessedThroughProperty("TextBox_build")]
		private TextBox _TextBox_build;

		// Token: 0x04000C0C RID: 3084
		[AccessedThroughProperty("Label_build")]
		private Label _Label_build;

		// Token: 0x04000C0D RID: 3085
		[AccessedThroughProperty("TextBox_versao")]
		private TextBox _TextBox_versao;

		// Token: 0x04000C0E RID: 3086
		[AccessedThroughProperty("Label_versao")]
		private Label _Label_versao;

		// Token: 0x04000C0F RID: 3087
		[AccessedThroughProperty("GroupBox_modelo_simulado")]
		private GroupBox _GroupBox_modelo_simulado;

		// Token: 0x04000C10 RID: 3088
		[AccessedThroughProperty("ComboBox_modo_simulado")]
		private ComboBox _ComboBox_modo_simulado;

		// Token: 0x04000C11 RID: 3089
		[AccessedThroughProperty("GroupBox_comunicacao")]
		private GroupBox _GroupBox_comunicacao;

		// Token: 0x04000C12 RID: 3090
		[AccessedThroughProperty("NumericUpDown_temp_ptt")]
		private NumericUpDown _NumericUpDown_temp_ptt;

		// Token: 0x04000C13 RID: 3091
		[AccessedThroughProperty("NumericUpDown_end_mestre")]
		private NumericUpDown _NumericUpDown_end_mestre;

		// Token: 0x04000C14 RID: 3092
		[AccessedThroughProperty("NumericUpDown_end_est")]
		private NumericUpDown _NumericUpDown_end_est;

		// Token: 0x04000C15 RID: 3093
		[AccessedThroughProperty("Label_tempo_ptt")]
		private Label _Label_tempo_ptt;

		// Token: 0x04000C16 RID: 3094
		[AccessedThroughProperty("Label_end_mestre")]
		private Label _Label_end_mestre;

		// Token: 0x04000C17 RID: 3095
		[AccessedThroughProperty("Label_end_est")]
		private Label _Label_end_est;

		// Token: 0x04000C18 RID: 3096
		[AccessedThroughProperty("OpenFileDialog_RT_820")]
		private OpenFileDialog _OpenFileDialog_RT_820;

		// Token: 0x04000C19 RID: 3097
		[AccessedThroughProperty("SaveFileDialog_RT_820")]
		private SaveFileDialog _SaveFileDialog_RT_820;

		// Token: 0x04000C1A RID: 3098
		[AccessedThroughProperty("TabControl_820")]
		private TabControl _TabControl_820;

		// Token: 0x04000C1B RID: 3099
		[AccessedThroughProperty("TabPage_geral")]
		private TabPage _TabPage_geral;

		// Token: 0x04000C1C RID: 3100
		[AccessedThroughProperty("GroupBox_informacoes_820")]
		private GroupBox _GroupBox_informacoes_820;

		// Token: 0x04000C1D RID: 3101
		[AccessedThroughProperty("GroupBox_comunicacao_820")]
		private GroupBox _GroupBox_comunicacao_820;

		// Token: 0x04000C1E RID: 3102
		[AccessedThroughProperty("NumericUpDown_temp_ptt_820")]
		private NumericUpDown _NumericUpDown_temp_ptt_820;

		// Token: 0x04000C1F RID: 3103
		[AccessedThroughProperty("NumericUpDown_end_mestre_820")]
		private NumericUpDown _NumericUpDown_end_mestre_820;

		// Token: 0x04000C20 RID: 3104
		[AccessedThroughProperty("NumericUpDown_end_est_820")]
		private NumericUpDown _NumericUpDown_end_est_820;

		// Token: 0x04000C21 RID: 3105
		[AccessedThroughProperty("Label_tempo_ptt_820")]
		private Label _Label_tempo_ptt_820;

		// Token: 0x04000C22 RID: 3106
		[AccessedThroughProperty("Label_end_mestre_820")]
		private Label _Label_end_mestre_820;

		// Token: 0x04000C23 RID: 3107
		[AccessedThroughProperty("Label_end_est_820")]
		private Label _Label_end_est_820;

		// Token: 0x04000C24 RID: 3108
		[AccessedThroughProperty("TabPage_EA")]
		private TabPage _TabPage_EA;

		// Token: 0x04000C25 RID: 3109
		[AccessedThroughProperty("GroupBox_parametros_EA_820")]
		private GroupBox _GroupBox_parametros_EA_820;

		// Token: 0x04000C26 RID: 3110
		[AccessedThroughProperty("DataGridView_parametros_EA_820")]
		private DataGridView _DataGridView_parametros_EA_820;

		// Token: 0x04000C27 RID: 3111
		[AccessedThroughProperty("GroupBox_EA_820")]
		private GroupBox _GroupBox_EA_820;

		// Token: 0x04000C28 RID: 3112
		[AccessedThroughProperty("NumericUpDown_intervalo_filtro_820")]
		private NumericUpDown _NumericUpDown_intervalo_filtro_820;

		// Token: 0x04000C29 RID: 3113
		[AccessedThroughProperty("NumericUpDown_tamanho_filtro_820")]
		private NumericUpDown _NumericUpDown_tamanho_filtro_820;

		// Token: 0x04000C2A RID: 3114
		[AccessedThroughProperty("Label_intervalo_filtro_820")]
		private Label _Label_intervalo_filtro_820;

		// Token: 0x04000C2B RID: 3115
		[AccessedThroughProperty("Label_tamanho_filtro_820")]
		private Label _Label_tamanho_filtro_820;

		// Token: 0x04000C2C RID: 3116
		[AccessedThroughProperty("TabPage_ED")]
		private TabPage _TabPage_ED;

		// Token: 0x04000C2D RID: 3117
		[AccessedThroughProperty("TabPage_setpoints")]
		private TabPage _TabPage_setpoints;

		// Token: 0x04000C2E RID: 3118
		[AccessedThroughProperty("TabPage_vazao_perifericos")]
		private TabPage _TabPage_vazao_perifericos;

		// Token: 0x04000C2F RID: 3119
		[AccessedThroughProperty("TabPage_repetidora")]
		private TabPage _TabPage_repetidora;

		// Token: 0x04000C30 RID: 3120
		[AccessedThroughProperty("GroupBox_end_rep_820")]
		private GroupBox _GroupBox_end_rep_820;

		// Token: 0x04000C31 RID: 3121
		[AccessedThroughProperty("DataGridView_end_rep_RT820")]
		private DataGridView _DataGridView_end_rep_RT820;

		// Token: 0x04000C32 RID: 3122
		[AccessedThroughProperty("GroupBox_parametros_repetidora_820")]
		private GroupBox _GroupBox_parametros_repetidora_820;

		// Token: 0x04000C33 RID: 3123
		[AccessedThroughProperty("NumericUpDown_num_est_rep_820")]
		private NumericUpDown _NumericUpDown_num_est_rep_820;

		// Token: 0x04000C34 RID: 3124
		[AccessedThroughProperty("NumericUpDown_end_rep_820")]
		private NumericUpDown _NumericUpDown_end_rep_820;

		// Token: 0x04000C35 RID: 3125
		[AccessedThroughProperty("Label_num_est_rep_820")]
		private Label _Label_num_est_rep_820;

		// Token: 0x04000C36 RID: 3126
		[AccessedThroughProperty("Label_end_rep_820")]
		private Label _Label_end_rep_820;

		// Token: 0x04000C37 RID: 3127
		[AccessedThroughProperty("ToolStri_RT_820")]
		private ToolStrip _ToolStri_RT_820;

		// Token: 0x04000C38 RID: 3128
		[AccessedThroughProperty("ToolStripButton_RT_820_novo")]
		private ToolStripButton _ToolStripButton_RT_820_novo;

		// Token: 0x04000C39 RID: 3129
		[AccessedThroughProperty("ToolStripButton_RT_820_Abrir")]
		private ToolStripButton _ToolStripButton_RT_820_Abrir;

		// Token: 0x04000C3A RID: 3130
		[AccessedThroughProperty("ToolStripButton_RT_820_Salvar")]
		private ToolStripButton _ToolStripButton_RT_820_Salvar;

		// Token: 0x04000C3B RID: 3131
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x04000C3C RID: 3132
		[AccessedThroughProperty("ToolStripButton_RT_820_Download")]
		private ToolStripButton _ToolStripButton_RT_820_Download;

		// Token: 0x04000C3D RID: 3133
		[AccessedThroughProperty("ToolStripButton_RT_820_Upload")]
		private ToolStripButton _ToolStripButton_RT_820_Upload;

		// Token: 0x04000C3E RID: 3134
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x04000C3F RID: 3135
		[AccessedThroughProperty("ToolStripTextBox_RT_820_Msg")]
		private ToolStripTextBox _ToolStripTextBox_RT_820_Msg;

		// Token: 0x04000C40 RID: 3136
		[AccessedThroughProperty("ToolStripProgressBar_RT_820")]
		private ToolStripProgressBar _ToolStripProgressBar_RT_820;

		// Token: 0x04000C41 RID: 3137
		[AccessedThroughProperty("GroupBox_parametros_interface_820")]
		private GroupBox _GroupBox_parametros_interface_820;

		// Token: 0x04000C42 RID: 3138
		[AccessedThroughProperty("CheckBox_hab_expansao_IO_820")]
		private CheckBox _CheckBox_hab_expansao_IO_820;

		// Token: 0x04000C43 RID: 3139
		[AccessedThroughProperty("ComboBox_baudrate_COM2_820")]
		private ComboBox _ComboBox_baudrate_COM2_820;

		// Token: 0x04000C44 RID: 3140
		[AccessedThroughProperty("Label_baudrate_COM2_820")]
		private Label _Label_baudrate_COM2_820;

		// Token: 0x04000C45 RID: 3141
		[AccessedThroughProperty("TabPage_controle")]
		private TabPage _TabPage_controle;

		// Token: 0x04000C46 RID: 3142
		[AccessedThroughProperty("GroupBox_controle_820")]
		private GroupBox _GroupBox_controle_820;

		// Token: 0x04000C47 RID: 3143
		[AccessedThroughProperty("DataGridView_processo_820")]
		private DataGridView _DataGridView_processo_820;

		// Token: 0x04000C48 RID: 3144
		[AccessedThroughProperty("GroupBox_Agrupamento_820")]
		private GroupBox _GroupBox_Agrupamento_820;

		// Token: 0x04000C49 RID: 3145
		[AccessedThroughProperty("DataGridView_grupos_820")]
		private DataGridView _DataGridView_grupos_820;

		// Token: 0x04000C4A RID: 3146
		[AccessedThroughProperty("GroupBox_vazoes_820")]
		private GroupBox _GroupBox_vazoes_820;

		// Token: 0x04000C4B RID: 3147
		[AccessedThroughProperty("GroupBox_perifericos_820")]
		private GroupBox _GroupBox_perifericos_820;

		// Token: 0x04000C4C RID: 3148
		[AccessedThroughProperty("DataGridView_periferico_RT820")]
		private DataGridView _DataGridView_periferico_RT820;

		// Token: 0x04000C4D RID: 3149
		[AccessedThroughProperty("DataGridView_setpoints_820")]
		private DataGridView _DataGridView_setpoints_820;

		// Token: 0x04000C4E RID: 3150
		[AccessedThroughProperty("GroupBox_setpoints_820")]
		private GroupBox _GroupBox_setpoints_820;

		// Token: 0x04000C4F RID: 3151
		[AccessedThroughProperty("Timer_limpa_MSG_820")]
		private Timer _Timer_limpa_MSG_820;

		// Token: 0x04000C50 RID: 3152
		[AccessedThroughProperty("GroupBox_descricao_RT820")]
		private GroupBox _GroupBox_descricao_RT820;

		// Token: 0x04000C51 RID: 3153
		[AccessedThroughProperty("TextBox_comentarios_RT820")]
		private TextBox _TextBox_comentarios_RT820;

		// Token: 0x04000C52 RID: 3154
		[AccessedThroughProperty("TextBox_endereco_RT820")]
		private TextBox _TextBox_endereco_RT820;

		// Token: 0x04000C53 RID: 3155
		[AccessedThroughProperty("TextBox_nome_RT820")]
		private TextBox _TextBox_nome_RT820;

		// Token: 0x04000C54 RID: 3156
		[AccessedThroughProperty("Label_comentarios")]
		private Label _Label_comentarios;

		// Token: 0x04000C55 RID: 3157
		[AccessedThroughProperty("Label_endereco")]
		private Label _Label_endereco;

		// Token: 0x04000C56 RID: 3158
		[AccessedThroughProperty("Label_nome")]
		private Label _Label_nome;

		// Token: 0x04000C57 RID: 3159
		[AccessedThroughProperty("TabPage_timer")]
		private TabPage _TabPage_timer;

		// Token: 0x04000C58 RID: 3160
		[AccessedThroughProperty("GroupBox_timer")]
		private GroupBox _GroupBox_timer;

		// Token: 0x04000C59 RID: 3161
		[AccessedThroughProperty("DataGridView_timer_RT820")]
		private DataGridView _DataGridView_timer_RT820;

		// Token: 0x04000C5A RID: 3162
		[AccessedThroughProperty("DataGridView1")]
		private DataGridView _DataGridView1;

		// Token: 0x04000C5B RID: 3163
		[AccessedThroughProperty("Column2")]
		private DataGridViewTextBoxColumn _Column2;

		// Token: 0x04000C5C RID: 3164
		[AccessedThroughProperty("Column3")]
		private DataGridViewTextBoxColumn _Column3;

		// Token: 0x04000C5D RID: 3165
		[AccessedThroughProperty("Column4")]
		private DataGridViewTextBoxColumn _Column4;

		// Token: 0x04000C5E RID: 3166
		[AccessedThroughProperty("Column5")]
		private DataGridViewTextBoxColumn _Column5;

		// Token: 0x04000C5F RID: 3167
		[AccessedThroughProperty("Column6")]
		private DataGridViewTextBoxColumn _Column6;

		// Token: 0x04000C60 RID: 3168
		[AccessedThroughProperty("Column7")]
		private DataGridViewTextBoxColumn _Column7;

		// Token: 0x04000C61 RID: 3169
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000C62 RID: 3170
		[AccessedThroughProperty("DataGridView_vazoes_RT820")]
		private DataGridView _DataGridView_vazoes_RT820;

		// Token: 0x04000C63 RID: 3171
		[AccessedThroughProperty("GroupBox_ED_820")]
		private GroupBox _GroupBox_ED_820;

		// Token: 0x04000C64 RID: 3172
		[AccessedThroughProperty("DataGridView_RT820_ED")]
		private DataGridView _DataGridView_RT820_ED;

		// Token: 0x04000C65 RID: 3173
		[AccessedThroughProperty("ToolStripButton_RT820_Imprimir")]
		private ToolStripButton _ToolStripButton_RT820_Imprimir;

		// Token: 0x04000C66 RID: 3174
		[AccessedThroughProperty("PrintDocument1")]
		private PrintDocument _PrintDocument1;

		// Token: 0x04000C67 RID: 3175
		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		// Token: 0x04000C68 RID: 3176
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000C69 RID: 3177
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x04000C6A RID: 3178
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x04000C6B RID: 3179
		[AccessedThroughProperty("T_ModeloFonte")]
		private TextBox _T_ModeloFonte;

		// Token: 0x04000C6C RID: 3180
		[AccessedThroughProperty("T_AlturaAntena")]
		private TextBox _T_AlturaAntena;

		// Token: 0x04000C6D RID: 3181
		[AccessedThroughProperty("T_Latitude")]
		private TextBox _T_Latitude;

		// Token: 0x04000C6E RID: 3182
		[AccessedThroughProperty("T_Longitude")]
		private TextBox _T_Longitude;

		// Token: 0x04000C6F RID: 3183
		[AccessedThroughProperty("T_Azimute")]
		private TextBox _T_Azimute;

		// Token: 0x04000C70 RID: 3184
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000C71 RID: 3185
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04000C72 RID: 3186
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000C73 RID: 3187
		[AccessedThroughProperty("T_FreqRadio")]
		private TextBox _T_FreqRadio;

		// Token: 0x04000C74 RID: 3188
		[AccessedThroughProperty("T_DistCentral")]
		private TextBox _T_DistCentral;

		// Token: 0x04000C75 RID: 3189
		[AccessedThroughProperty("T_PotRadio")]
		private TextBox _T_PotRadio;

		// Token: 0x04000C76 RID: 3190
		[AccessedThroughProperty("CB_ModeloRadio")]
		private ComboBox _CB_ModeloRadio;

		// Token: 0x04000C77 RID: 3191
		[AccessedThroughProperty("CB_PolarizacaoAntena")]
		private ComboBox _CB_PolarizacaoAntena;

		// Token: 0x04000C78 RID: 3192
		[AccessedThroughProperty("CB_TipoAntena")]
		private ComboBox _CB_TipoAntena;

		// Token: 0x04000C79 RID: 3193
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000C7A RID: 3194
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000C7B RID: 3195
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000C7C RID: 3196
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000C7D RID: 3197
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000C7E RID: 3198
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000C7F RID: 3199
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000C80 RID: 3200
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000C81 RID: 3201
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000C82 RID: 3202
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000C83 RID: 3203
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x04000C84 RID: 3204
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x04000C85 RID: 3205
		[AccessedThroughProperty("PrintPreviewDialog1")]
		private PrintPreviewDialog _PrintPreviewDialog1;

		// Token: 0x04000C86 RID: 3206
		[AccessedThroughProperty("ToolStripLabel1")]
		private ToolStripLabel _ToolStripLabel1;

		// Token: 0x04000C87 RID: 3207
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x04000C88 RID: 3208
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		// Token: 0x04000C89 RID: 3209
		[AccessedThroughProperty("TextBox_equipamento_820")]
		private TextBox _TextBox_equipamento_820;

		// Token: 0x04000C8A RID: 3210
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x04000C8B RID: 3211
		[AccessedThroughProperty("TextBox_release_820")]
		private TextBox _TextBox_release_820;

		// Token: 0x04000C8C RID: 3212
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x04000C8D RID: 3213
		[AccessedThroughProperty("TextBox_build_820")]
		private TextBox _TextBox_build_820;

		// Token: 0x04000C8E RID: 3214
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x04000C8F RID: 3215
		[AccessedThroughProperty("TextBox_versao_820")]
		private TextBox _TextBox_versao_820;

		// Token: 0x04000C90 RID: 3216
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		// Token: 0x04000C91 RID: 3217
		[AccessedThroughProperty("tb_lixo1")]
		private TextBox _tb_lixo1;

		// Token: 0x04000C92 RID: 3218
		[AccessedThroughProperty("tb_lixo2")]
		private TextBox _tb_lixo2;

		// Token: 0x04000C93 RID: 3219
		[AccessedThroughProperty("tb_lixo3")]
		private TextBox _tb_lixo3;

		// Token: 0x04000C94 RID: 3220
		[AccessedThroughProperty("tb_lixo4")]
		private TextBox _tb_lixo4;

		// Token: 0x04000C95 RID: 3221
		[AccessedThroughProperty("tb_lixo5")]
		private TextBox _tb_lixo5;

		// Token: 0x04000C96 RID: 3222
		[AccessedThroughProperty("tb_lixo6")]
		private TextBox _tb_lixo6;

		// Token: 0x04000C97 RID: 3223
		[AccessedThroughProperty("tb_lixo7")]
		private TextBox _tb_lixo7;

		// Token: 0x04000C98 RID: 3224
		[AccessedThroughProperty("tb_lixo8")]
		private TextBox _tb_lixo8;

		// Token: 0x04000C99 RID: 3225
		[AccessedThroughProperty("tb_lixo9")]
		private TextBox _tb_lixo9;

		// Token: 0x04000C9A RID: 3226
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000C9B RID: 3227
		[AccessedThroughProperty("dgv_sph")]
		private DataGridView _dgv_sph;

		// Token: 0x04000C9C RID: 3228
		[AccessedThroughProperty("Label73")]
		private Label _Label73;

		// Token: 0x04000C9D RID: 3229
		[AccessedThroughProperty("col_sph_horario")]
		private DataGridViewTextBoxColumn _col_sph_horario;

		// Token: 0x04000C9E RID: 3230
		[AccessedThroughProperty("col_sph_ativa")]
		private DataGridViewCheckBoxColumn _col_sph_ativa;

		// Token: 0x04000C9F RID: 3231
		[AccessedThroughProperty("col_sph_hora")]
		private DataGridViewTextBoxColumn _col_sph_hora;

		// Token: 0x04000CA0 RID: 3232
		[AccessedThroughProperty("col_sph_minuto")]
		private DataGridViewTextBoxColumn _col_sph_minuto;

		// Token: 0x04000CA1 RID: 3233
		[AccessedThroughProperty("col_sph_alto")]
		private DataGridViewTextBoxColumn _col_sph_alto;

		// Token: 0x04000CA2 RID: 3234
		[AccessedThroughProperty("col_sph_baixo")]
		private DataGridViewTextBoxColumn _col_sph_baixo;

		// Token: 0x04000CA3 RID: 3235
		[AccessedThroughProperty("cb_ModoRepetidora")]
		private ComboBox _cb_ModoRepetidora;

		// Token: 0x04000CA4 RID: 3236
		[AccessedThroughProperty("Label29")]
		private Label _Label29;

		// Token: 0x04000CA5 RID: 3237
		[AccessedThroughProperty("TabPage_Atuadores")]
		private TabPage _TabPage_Atuadores;

		// Token: 0x04000CA6 RID: 3238
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x04000CA7 RID: 3239
		[AccessedThroughProperty("dgv_atuador1")]
		private DataGridView _dgv_atuador1;

		// Token: 0x04000CA8 RID: 3240
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x04000CA9 RID: 3241
		[AccessedThroughProperty("datagridview_referenciaperifico")]
		private DataGridView _datagridview_referenciaperifico;

		// Token: 0x04000CAA RID: 3242
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x04000CAB RID: 3243
		[AccessedThroughProperty("dgv_atuador_setpoint2")]
		private DataGridView _dgv_atuador_setpoint2;

		// Token: 0x04000CAC RID: 3244
		[AccessedThroughProperty("dgv_atuador2")]
		private DataGridView _dgv_atuador2;

		// Token: 0x04000CAD RID: 3245
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		// Token: 0x04000CAE RID: 3246
		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		// Token: 0x04000CAF RID: 3247
		[AccessedThroughProperty("dgv_atuador_setpoint1")]
		private DataGridView _dgv_atuador_setpoint1;

		// Token: 0x04000CB0 RID: 3248
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		// Token: 0x04000CB1 RID: 3249
		[AccessedThroughProperty("dgv_atuador_setpoint11")]
		private DataGridView _dgv_atuador_setpoint11;

		// Token: 0x04000CB2 RID: 3250
		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		// Token: 0x04000CB3 RID: 3251
		[AccessedThroughProperty("dgv_atuador_setpoint21")]
		private DataGridView _dgv_atuador_setpoint21;

		// Token: 0x04000CB4 RID: 3252
		[AccessedThroughProperty("Label28")]
		private Label _Label28;

		// Token: 0x04000CB5 RID: 3253
		[AccessedThroughProperty("Label27")]
		private Label _Label27;

		// Token: 0x04000CB6 RID: 3254
		[AccessedThroughProperty("nud_tempoforaar")]
		private NumericUpDown _nud_tempoforaar;

		// Token: 0x04000CB7 RID: 3255
		[AccessedThroughProperty("Label30")]
		private Label _Label30;

		// Token: 0x04000CB8 RID: 3256
		[AccessedThroughProperty("TabPage_Atuadores2")]
		private TabPage _TabPage_Atuadores2;

		// Token: 0x04000CB9 RID: 3257
		[AccessedThroughProperty("GroupBox7")]
		private GroupBox _GroupBox7;

		// Token: 0x04000CBA RID: 3258
		[AccessedThroughProperty("dgv_atuador_setpoint41")]
		private DataGridView _dgv_atuador_setpoint41;

		// Token: 0x04000CBB RID: 3259
		[AccessedThroughProperty("Label33")]
		private Label _Label33;

		// Token: 0x04000CBC RID: 3260
		[AccessedThroughProperty("dgv_atuador_setpoint4")]
		private DataGridView _dgv_atuador_setpoint4;

		// Token: 0x04000CBD RID: 3261
		[AccessedThroughProperty("Label34")]
		private Label _Label34;

		// Token: 0x04000CBE RID: 3262
		[AccessedThroughProperty("dgv_atuador4")]
		private DataGridView _dgv_atuador4;

		// Token: 0x04000CBF RID: 3263
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		// Token: 0x04000CC0 RID: 3264
		[AccessedThroughProperty("Label31")]
		private Label _Label31;

		// Token: 0x04000CC1 RID: 3265
		[AccessedThroughProperty("Label32")]
		private Label _Label32;

		// Token: 0x04000CC2 RID: 3266
		[AccessedThroughProperty("dgv_atuador_setpoint31")]
		private DataGridView _dgv_atuador_setpoint31;

		// Token: 0x04000CC3 RID: 3267
		[AccessedThroughProperty("dgv_atuador_setpoint3")]
		private DataGridView _dgv_atuador_setpoint3;

		// Token: 0x04000CC4 RID: 3268
		[AccessedThroughProperty("dgv_atuador3")]
		private DataGridView _dgv_atuador3;

		// Token: 0x04000CC5 RID: 3269
		[AccessedThroughProperty("Label35")]
		private Label _Label35;

		// Token: 0x04000CC6 RID: 3270
		[AccessedThroughProperty("ComboBox_baudrate_COM1_820")]
		private ComboBox _ComboBox_baudrate_COM1_820;

		// Token: 0x04000CC7 RID: 3271
		[AccessedThroughProperty("Label36")]
		private Label _Label36;

		// Token: 0x04000CC8 RID: 3272
		[AccessedThroughProperty("Label37")]
		private Label _Label37;

		// Token: 0x04000CC9 RID: 3273
		[AccessedThroughProperty("GroupBox8")]
		private GroupBox _GroupBox8;

		// Token: 0x04000CCA RID: 3274
		[AccessedThroughProperty("ckb_tratamento_setpoint")]
		private CheckBox _ckb_tratamento_setpoint;

		// Token: 0x04000CCB RID: 3275
		private bool bloqueio_IO;

		// Token: 0x04000CCC RID: 3276
		private int pagina_impressao;
	}
}
