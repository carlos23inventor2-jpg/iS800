using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x02000084 RID: 132
	[DesignerGenerated]
	public partial class Equip_202_conf : Form
	{
		// Token: 0x06001ED6 RID: 7894 RVA: 0x003E0D90 File Offset: 0x003DF190
		public Equip_202_conf()
		{
			base.Load += new EventHandler(this.Equip_202_conf_Load);
			this.InitializeComponent();
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x003E6CB8 File Offset: 0x003E50B8
		// (set) Token: 0x06001EDA RID: 7898 RVA: 0x003E6CCC File Offset: 0x003E50CC
		internal virtual GroupBox Grupo_ctrl
		{
			get
			{
				return this._Grupo_ctrl;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_ctrl = value;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x003E6CD8 File Offset: 0x003E50D8
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x003E6CEC File Offset: 0x003E50EC
		internal virtual Button Esc_conf_md_202
		{
			get
			{
				return this._Esc_conf_md_202;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Esc_conf_md_202_Click);
				if (this._Esc_conf_md_202 != null)
				{
					this._Esc_conf_md_202.Click -= eventHandler;
				}
				this._Esc_conf_md_202 = value;
				if (this._Esc_conf_md_202 != null)
				{
					this._Esc_conf_md_202.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x003E6D38 File Offset: 0x003E5138
		// (set) Token: 0x06001EDE RID: 7902 RVA: 0x003E6D4C File Offset: 0x003E514C
		internal virtual TextBox Box_Msg
		{
			get
			{
				return this._Box_Msg;
			}
			[MethodImpl(32)]
			set
			{
				this._Box_Msg = value;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x003E6D58 File Offset: 0x003E5158
		// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x003E6D6C File Offset: 0x003E516C
		internal virtual Button Ler_conf_md_202
		{
			get
			{
				return this._Ler_conf_md_202;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Ler_conf_md_202_Click);
				if (this._Ler_conf_md_202 != null)
				{
					this._Ler_conf_md_202.Click -= eventHandler;
				}
				this._Ler_conf_md_202 = value;
				if (this._Ler_conf_md_202 != null)
				{
					this._Ler_conf_md_202.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x003E6DB8 File Offset: 0x003E51B8
		// (set) Token: 0x06001EE2 RID: 7906 RVA: 0x003E6DCC File Offset: 0x003E51CC
		internal virtual GroupBox Grupo_motores_valvulas
		{
			get
			{
				return this._Grupo_motores_valvulas;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_motores_valvulas = value;
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x003E6DD8 File Offset: 0x003E51D8
		// (set) Token: 0x06001EE4 RID: 7908 RVA: 0x003E6DEC File Offset: 0x003E51EC
		internal virtual NumericUpDown Tempo_entre_acionamentos
		{
			get
			{
				return this._Tempo_entre_acionamentos;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_entre_acionamentos_ValueChanged);
				if (this._Tempo_entre_acionamentos != null)
				{
					this._Tempo_entre_acionamentos.ValueChanged -= eventHandler;
				}
				this._Tempo_entre_acionamentos = value;
				if (this._Tempo_entre_acionamentos != null)
				{
					this._Tempo_entre_acionamentos.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x003E6E38 File Offset: 0x003E5238
		// (set) Token: 0x06001EE6 RID: 7910 RVA: 0x003E6E4C File Offset: 0x003E524C
		internal virtual NumericUpDown Numero_valvulas
		{
			get
			{
				return this._Numero_valvulas;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Numero_valvulas_ValueChanged);
				if (this._Numero_valvulas != null)
				{
					this._Numero_valvulas.ValueChanged -= eventHandler;
				}
				this._Numero_valvulas = value;
				if (this._Numero_valvulas != null)
				{
					this._Numero_valvulas.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x003E6E98 File Offset: 0x003E5298
		// (set) Token: 0x06001EE8 RID: 7912 RVA: 0x003E6EAC File Offset: 0x003E52AC
		internal virtual NumericUpDown Valor_pressao_min_recalque
		{
			get
			{
				return this._Valor_pressao_min_recalque;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_pressao_min_recalque_ValueChanged);
				if (this._Valor_pressao_min_recalque != null)
				{
					this._Valor_pressao_min_recalque.ValueChanged -= eventHandler;
				}
				this._Valor_pressao_min_recalque = value;
				if (this._Valor_pressao_min_recalque != null)
				{
					this._Valor_pressao_min_recalque.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x003E6EF8 File Offset: 0x003E52F8
		// (set) Token: 0x06001EEA RID: 7914 RVA: 0x003E6F0C File Offset: 0x003E530C
		internal virtual NumericUpDown Valor_pressao_min_succao
		{
			get
			{
				return this._Valor_pressao_min_succao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_pressao_min_succao_ValueChanged);
				if (this._Valor_pressao_min_succao != null)
				{
					this._Valor_pressao_min_succao.ValueChanged -= eventHandler;
				}
				this._Valor_pressao_min_succao = value;
				if (this._Valor_pressao_min_succao != null)
				{
					this._Valor_pressao_min_succao.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06001EEB RID: 7915 RVA: 0x003E6F58 File Offset: 0x003E5358
		// (set) Token: 0x06001EEC RID: 7916 RVA: 0x003E6F6C File Offset: 0x003E536C
		internal virtual Label Label_pressao_min_succao
		{
			get
			{
				return this._Label_pressao_min_succao;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_pressao_min_succao = value;
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06001EED RID: 7917 RVA: 0x003E6F78 File Offset: 0x003E5378
		// (set) Token: 0x06001EEE RID: 7918 RVA: 0x003E6F8C File Offset: 0x003E538C
		internal virtual Label Label_pressao_min_recalque
		{
			get
			{
				return this._Label_pressao_min_recalque;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_pressao_min_recalque = value;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x003E6F98 File Offset: 0x003E5398
		// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x003E6FAC File Offset: 0x003E53AC
		internal virtual NumericUpDown Valor_tempo_mais_bomba
		{
			get
			{
				return this._Valor_tempo_mais_bomba;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_tempo_mais_bomba_ValueChanged);
				if (this._Valor_tempo_mais_bomba != null)
				{
					this._Valor_tempo_mais_bomba.ValueChanged -= eventHandler;
				}
				this._Valor_tempo_mais_bomba = value;
				if (this._Valor_tempo_mais_bomba != null)
				{
					this._Valor_tempo_mais_bomba.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x003E6FF8 File Offset: 0x003E53F8
		// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x003E700C File Offset: 0x003E540C
		internal virtual NumericUpDown Valor_nivel_liga_b4
		{
			get
			{
				return this._Valor_nivel_liga_b4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_nivel_liga_b4_ValueChanged);
				if (this._Valor_nivel_liga_b4 != null)
				{
					this._Valor_nivel_liga_b4.ValueChanged -= eventHandler;
				}
				this._Valor_nivel_liga_b4 = value;
				if (this._Valor_nivel_liga_b4 != null)
				{
					this._Valor_nivel_liga_b4.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x003E7058 File Offset: 0x003E5458
		// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x003E706C File Offset: 0x003E546C
		internal virtual Label Label_nivel_liga_b4
		{
			get
			{
				return this._Label_nivel_liga_b4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_liga_b4 = value;
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x003E7078 File Offset: 0x003E5478
		// (set) Token: 0x06001EF6 RID: 7926 RVA: 0x003E708C File Offset: 0x003E548C
		internal virtual Label Label_tempo_mais_bomba
		{
			get
			{
				return this._Label_tempo_mais_bomba;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_mais_bomba = value;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x003E7098 File Offset: 0x003E5498
		// (set) Token: 0x06001EF8 RID: 7928 RVA: 0x003E70AC File Offset: 0x003E54AC
		internal virtual NumericUpDown Valor_nivel_liga_b1
		{
			get
			{
				return this._Valor_nivel_liga_b1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_nivel_liga_b1_ValueChanged);
				if (this._Valor_nivel_liga_b1 != null)
				{
					this._Valor_nivel_liga_b1.ValueChanged -= eventHandler;
				}
				this._Valor_nivel_liga_b1 = value;
				if (this._Valor_nivel_liga_b1 != null)
				{
					this._Valor_nivel_liga_b1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x003E70F8 File Offset: 0x003E54F8
		// (set) Token: 0x06001EFA RID: 7930 RVA: 0x003E710C File Offset: 0x003E550C
		internal virtual NumericUpDown Valor_nivel_desejado
		{
			get
			{
				return this._Valor_nivel_desejado;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_nivel_desejado_ValueChanged);
				if (this._Valor_nivel_desejado != null)
				{
					this._Valor_nivel_desejado.ValueChanged -= eventHandler;
				}
				this._Valor_nivel_desejado = value;
				if (this._Valor_nivel_desejado != null)
				{
					this._Valor_nivel_desejado.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06001EFB RID: 7931 RVA: 0x003E7158 File Offset: 0x003E5558
		// (set) Token: 0x06001EFC RID: 7932 RVA: 0x003E716C File Offset: 0x003E556C
		internal virtual Label Label_nivel_desejado
		{
			get
			{
				return this._Label_nivel_desejado;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_desejado = value;
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06001EFD RID: 7933 RVA: 0x003E7178 File Offset: 0x003E5578
		// (set) Token: 0x06001EFE RID: 7934 RVA: 0x003E718C File Offset: 0x003E558C
		internal virtual Label Label_nivel_liga_b1
		{
			get
			{
				return this._Label_nivel_liga_b1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_liga_b1 = value;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06001EFF RID: 7935 RVA: 0x003E7198 File Offset: 0x003E5598
		// (set) Token: 0x06001F00 RID: 7936 RVA: 0x003E71AC File Offset: 0x003E55AC
		internal virtual Label Label_tempo_entre_acionamentos
		{
			get
			{
				return this._Label_tempo_entre_acionamentos;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_entre_acionamentos = value;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06001F01 RID: 7937 RVA: 0x003E71B8 File Offset: 0x003E55B8
		// (set) Token: 0x06001F02 RID: 7938 RVA: 0x003E71CC File Offset: 0x003E55CC
		internal virtual Label Label_num_valvulas
		{
			get
			{
				return this._Label_num_valvulas;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_num_valvulas = value;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06001F03 RID: 7939 RVA: 0x003E71D8 File Offset: 0x003E55D8
		// (set) Token: 0x06001F04 RID: 7940 RVA: 0x003E71EC File Offset: 0x003E55EC
		internal virtual GroupBox Grupo_repetidora
		{
			get
			{
				return this._Grupo_repetidora;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_repetidora = value;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06001F05 RID: 7941 RVA: 0x003E71F8 File Offset: 0x003E55F8
		// (set) Token: 0x06001F06 RID: 7942 RVA: 0x003E720C File Offset: 0x003E560C
		internal virtual NumericUpDown Valor_num_est_rep
		{
			get
			{
				return this._Valor_num_est_rep;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_num_est_rep_ValueChanged);
				if (this._Valor_num_est_rep != null)
				{
					this._Valor_num_est_rep.ValueChanged -= eventHandler;
				}
				this._Valor_num_est_rep = value;
				if (this._Valor_num_est_rep != null)
				{
					this._Valor_num_est_rep.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06001F07 RID: 7943 RVA: 0x003E7258 File Offset: 0x003E5658
		// (set) Token: 0x06001F08 RID: 7944 RVA: 0x003E726C File Offset: 0x003E566C
		internal virtual NumericUpDown Valor_end_rep
		{
			get
			{
				return this._Valor_end_rep;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_end_rep_ValueChanged);
				if (this._Valor_end_rep != null)
				{
					this._Valor_end_rep.ValueChanged -= eventHandler;
				}
				this._Valor_end_rep = value;
				if (this._Valor_end_rep != null)
				{
					this._Valor_end_rep.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x003E72B8 File Offset: 0x003E56B8
		// (set) Token: 0x06001F0A RID: 7946 RVA: 0x003E72CC File Offset: 0x003E56CC
		internal virtual GroupBox Grupo_end_rep
		{
			get
			{
				return this._Grupo_end_rep;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_end_rep = value;
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x003E72D8 File Offset: 0x003E56D8
		// (set) Token: 0x06001F0C RID: 7948 RVA: 0x003E72EC File Offset: 0x003E56EC
		internal virtual VScrollBar VScrollBar1
		{
			get
			{
				return this._VScrollBar1;
			}
			[MethodImpl(32)]
			set
			{
				ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.VScrollBar1_Scroll);
				if (this._VScrollBar1 != null)
				{
					this._VScrollBar1.Scroll -= scrollEventHandler;
				}
				this._VScrollBar1 = value;
				if (this._VScrollBar1 != null)
				{
					this._VScrollBar1.Scroll += scrollEventHandler;
				}
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x003E7338 File Offset: 0x003E5738
		// (set) Token: 0x06001F0E RID: 7950 RVA: 0x003E734C File Offset: 0x003E574C
		internal virtual Label Label_end_rep_12
		{
			get
			{
				return this._Label_end_rep_12;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_rep_12 = value;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x003E7358 File Offset: 0x003E5758
		// (set) Token: 0x06001F10 RID: 7952 RVA: 0x003E736C File Offset: 0x003E576C
		internal virtual TextBox Valor_end_rep_12
		{
			get
			{
				return this._Valor_end_rep_12;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_end_rep_12_Validating);
				if (this._Valor_end_rep_12 != null)
				{
					this._Valor_end_rep_12.Validating -= cancelEventHandler;
				}
				this._Valor_end_rep_12 = value;
				if (this._Valor_end_rep_12 != null)
				{
					this._Valor_end_rep_12.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x003E73B8 File Offset: 0x003E57B8
		// (set) Token: 0x06001F12 RID: 7954 RVA: 0x003E73CC File Offset: 0x003E57CC
		internal virtual Label Label_end_rep_11
		{
			get
			{
				return this._Label_end_rep_11;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_rep_11 = value;
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06001F13 RID: 7955 RVA: 0x003E73D8 File Offset: 0x003E57D8
		// (set) Token: 0x06001F14 RID: 7956 RVA: 0x003E73EC File Offset: 0x003E57EC
		internal virtual TextBox Valor_end_rep_11
		{
			get
			{
				return this._Valor_end_rep_11;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_end_rep_11_Validating);
				if (this._Valor_end_rep_11 != null)
				{
					this._Valor_end_rep_11.Validating -= cancelEventHandler;
				}
				this._Valor_end_rep_11 = value;
				if (this._Valor_end_rep_11 != null)
				{
					this._Valor_end_rep_11.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x003E7438 File Offset: 0x003E5838
		// (set) Token: 0x06001F16 RID: 7958 RVA: 0x003E744C File Offset: 0x003E584C
		internal virtual Label Label_end_rep_6
		{
			get
			{
				return this._Label_end_rep_6;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_rep_6 = value;
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x003E7458 File Offset: 0x003E5858
		// (set) Token: 0x06001F18 RID: 7960 RVA: 0x003E746C File Offset: 0x003E586C
		internal virtual TextBox Valor_end_rep_6
		{
			get
			{
				return this._Valor_end_rep_6;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_end_rep_6_Validating);
				if (this._Valor_end_rep_6 != null)
				{
					this._Valor_end_rep_6.Validating -= cancelEventHandler;
				}
				this._Valor_end_rep_6 = value;
				if (this._Valor_end_rep_6 != null)
				{
					this._Valor_end_rep_6.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06001F19 RID: 7961 RVA: 0x003E74B8 File Offset: 0x003E58B8
		// (set) Token: 0x06001F1A RID: 7962 RVA: 0x003E74CC File Offset: 0x003E58CC
		internal virtual Label Label_end_rep_3
		{
			get
			{
				return this._Label_end_rep_3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_rep_3 = value;
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x003E74D8 File Offset: 0x003E58D8
		// (set) Token: 0x06001F1C RID: 7964 RVA: 0x003E74EC File Offset: 0x003E58EC
		internal virtual TextBox Valor_end_rep_3
		{
			get
			{
				return this._Valor_end_rep_3;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_end_rep_3_Validating);
				if (this._Valor_end_rep_3 != null)
				{
					this._Valor_end_rep_3.Validating -= cancelEventHandler;
				}
				this._Valor_end_rep_3 = value;
				if (this._Valor_end_rep_3 != null)
				{
					this._Valor_end_rep_3.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x003E7538 File Offset: 0x003E5938
		// (set) Token: 0x06001F1E RID: 7966 RVA: 0x003E754C File Offset: 0x003E594C
		internal virtual Label Label_end_rep_9
		{
			get
			{
				return this._Label_end_rep_9;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_rep_9 = value;
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06001F1F RID: 7967 RVA: 0x003E7558 File Offset: 0x003E5958
		// (set) Token: 0x06001F20 RID: 7968 RVA: 0x003E756C File Offset: 0x003E596C
		internal virtual TextBox Valor_end_rep_9
		{
			get
			{
				return this._Valor_end_rep_9;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_end_rep_9_Validating);
				if (this._Valor_end_rep_9 != null)
				{
					this._Valor_end_rep_9.Validating -= cancelEventHandler;
				}
				this._Valor_end_rep_9 = value;
				if (this._Valor_end_rep_9 != null)
				{
					this._Valor_end_rep_9.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x003E75B8 File Offset: 0x003E59B8
		// (set) Token: 0x06001F22 RID: 7970 RVA: 0x003E75CC File Offset: 0x003E59CC
		internal virtual Label Label_end_rep_8
		{
			get
			{
				return this._Label_end_rep_8;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_rep_8 = value;
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x003E75D8 File Offset: 0x003E59D8
		// (set) Token: 0x06001F24 RID: 7972 RVA: 0x003E75EC File Offset: 0x003E59EC
		internal virtual TextBox Valor_end_rep_8
		{
			get
			{
				return this._Valor_end_rep_8;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_end_rep_8_Validating);
				if (this._Valor_end_rep_8 != null)
				{
					this._Valor_end_rep_8.Validating -= cancelEventHandler;
				}
				this._Valor_end_rep_8 = value;
				if (this._Valor_end_rep_8 != null)
				{
					this._Valor_end_rep_8.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x003E7638 File Offset: 0x003E5A38
		// (set) Token: 0x06001F26 RID: 7974 RVA: 0x003E764C File Offset: 0x003E5A4C
		internal virtual Label Label_end_rep_5
		{
			get
			{
				return this._Label_end_rep_5;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_rep_5 = value;
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06001F27 RID: 7975 RVA: 0x003E7658 File Offset: 0x003E5A58
		// (set) Token: 0x06001F28 RID: 7976 RVA: 0x003E766C File Offset: 0x003E5A6C
		internal virtual TextBox Valor_end_rep_5
		{
			get
			{
				return this._Valor_end_rep_5;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_end_rep_5_Validating);
				if (this._Valor_end_rep_5 != null)
				{
					this._Valor_end_rep_5.Validating -= cancelEventHandler;
				}
				this._Valor_end_rep_5 = value;
				if (this._Valor_end_rep_5 != null)
				{
					this._Valor_end_rep_5.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x003E76B8 File Offset: 0x003E5AB8
		// (set) Token: 0x06001F2A RID: 7978 RVA: 0x003E76CC File Offset: 0x003E5ACC
		internal virtual Label Label_end_rep_2
		{
			get
			{
				return this._Label_end_rep_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_rep_2 = value;
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06001F2B RID: 7979 RVA: 0x003E76D8 File Offset: 0x003E5AD8
		// (set) Token: 0x06001F2C RID: 7980 RVA: 0x003E76EC File Offset: 0x003E5AEC
		internal virtual TextBox Valor_end_rep_2
		{
			get
			{
				return this._Valor_end_rep_2;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_end_rep_2_Validating);
				if (this._Valor_end_rep_2 != null)
				{
					this._Valor_end_rep_2.Validating -= cancelEventHandler;
				}
				this._Valor_end_rep_2 = value;
				if (this._Valor_end_rep_2 != null)
				{
					this._Valor_end_rep_2.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06001F2D RID: 7981 RVA: 0x003E7738 File Offset: 0x003E5B38
		// (set) Token: 0x06001F2E RID: 7982 RVA: 0x003E774C File Offset: 0x003E5B4C
		internal virtual Label Label_end_rep_10
		{
			get
			{
				return this._Label_end_rep_10;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_rep_10 = value;
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x003E7758 File Offset: 0x003E5B58
		// (set) Token: 0x06001F30 RID: 7984 RVA: 0x003E776C File Offset: 0x003E5B6C
		internal virtual TextBox Valor_end_rep_10
		{
			get
			{
				return this._Valor_end_rep_10;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_end_rep_10_Validating);
				if (this._Valor_end_rep_10 != null)
				{
					this._Valor_end_rep_10.Validating -= cancelEventHandler;
				}
				this._Valor_end_rep_10 = value;
				if (this._Valor_end_rep_10 != null)
				{
					this._Valor_end_rep_10.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06001F31 RID: 7985 RVA: 0x003E77B8 File Offset: 0x003E5BB8
		// (set) Token: 0x06001F32 RID: 7986 RVA: 0x003E77CC File Offset: 0x003E5BCC
		internal virtual Label Label_end_rep_7
		{
			get
			{
				return this._Label_end_rep_7;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_rep_7 = value;
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x003E77D8 File Offset: 0x003E5BD8
		// (set) Token: 0x06001F34 RID: 7988 RVA: 0x003E77EC File Offset: 0x003E5BEC
		internal virtual Label Label_end_rep_4
		{
			get
			{
				return this._Label_end_rep_4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_rep_4 = value;
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x003E77F8 File Offset: 0x003E5BF8
		// (set) Token: 0x06001F36 RID: 7990 RVA: 0x003E780C File Offset: 0x003E5C0C
		internal virtual TextBox Valor_end_rep_7
		{
			get
			{
				return this._Valor_end_rep_7;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_end_rep_7_Validating);
				if (this._Valor_end_rep_7 != null)
				{
					this._Valor_end_rep_7.Validating -= cancelEventHandler;
				}
				this._Valor_end_rep_7 = value;
				if (this._Valor_end_rep_7 != null)
				{
					this._Valor_end_rep_7.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x003E7858 File Offset: 0x003E5C58
		// (set) Token: 0x06001F38 RID: 7992 RVA: 0x003E786C File Offset: 0x003E5C6C
		internal virtual TextBox Valor_end_rep_4
		{
			get
			{
				return this._Valor_end_rep_4;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_end_rep_4_Validating);
				if (this._Valor_end_rep_4 != null)
				{
					this._Valor_end_rep_4.Validating -= cancelEventHandler;
				}
				this._Valor_end_rep_4 = value;
				if (this._Valor_end_rep_4 != null)
				{
					this._Valor_end_rep_4.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x003E78B8 File Offset: 0x003E5CB8
		// (set) Token: 0x06001F3A RID: 7994 RVA: 0x003E78CC File Offset: 0x003E5CCC
		internal virtual Label Label_end_rep_1
		{
			get
			{
				return this._Label_end_rep_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_rep_1 = value;
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x003E78D8 File Offset: 0x003E5CD8
		// (set) Token: 0x06001F3C RID: 7996 RVA: 0x003E78EC File Offset: 0x003E5CEC
		internal virtual TextBox Valor_end_rep_1
		{
			get
			{
				return this._Valor_end_rep_1;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_end_rep_1_Validating);
				if (this._Valor_end_rep_1 != null)
				{
					this._Valor_end_rep_1.Validating -= cancelEventHandler;
				}
				this._Valor_end_rep_1 = value;
				if (this._Valor_end_rep_1 != null)
				{
					this._Valor_end_rep_1.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x003E7938 File Offset: 0x003E5D38
		// (set) Token: 0x06001F3E RID: 7998 RVA: 0x003E794C File Offset: 0x003E5D4C
		internal virtual CheckBox CheckBox_hab_rep
		{
			get
			{
				return this._CheckBox_hab_rep;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_hab_rep_CheckedChanged);
				if (this._CheckBox_hab_rep != null)
				{
					this._CheckBox_hab_rep.CheckedChanged -= eventHandler;
				}
				this._CheckBox_hab_rep = value;
				if (this._CheckBox_hab_rep != null)
				{
					this._CheckBox_hab_rep.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x003E7998 File Offset: 0x003E5D98
		// (set) Token: 0x06001F40 RID: 8000 RVA: 0x003E79AC File Offset: 0x003E5DAC
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

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x003E79B8 File Offset: 0x003E5DB8
		// (set) Token: 0x06001F42 RID: 8002 RVA: 0x003E79CC File Offset: 0x003E5DCC
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

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06001F43 RID: 8003 RVA: 0x003E79D8 File Offset: 0x003E5DD8
		// (set) Token: 0x06001F44 RID: 8004 RVA: 0x003E79EC File Offset: 0x003E5DEC
		internal virtual GroupBox grupo_comunicacao
		{
			get
			{
				return this._grupo_comunicacao;
			}
			[MethodImpl(32)]
			set
			{
				this._grupo_comunicacao = value;
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06001F45 RID: 8005 RVA: 0x003E79F8 File Offset: 0x003E5DF8
		// (set) Token: 0x06001F46 RID: 8006 RVA: 0x003E7A0C File Offset: 0x003E5E0C
		internal virtual NumericUpDown Valor_temp_ptt
		{
			get
			{
				return this._Valor_temp_ptt;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_temp_ptt_ValueChanged);
				if (this._Valor_temp_ptt != null)
				{
					this._Valor_temp_ptt.ValueChanged -= eventHandler;
				}
				this._Valor_temp_ptt = value;
				if (this._Valor_temp_ptt != null)
				{
					this._Valor_temp_ptt.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06001F47 RID: 8007 RVA: 0x003E7A58 File Offset: 0x003E5E58
		// (set) Token: 0x06001F48 RID: 8008 RVA: 0x003E7A6C File Offset: 0x003E5E6C
		internal virtual NumericUpDown Valor_end_mestre
		{
			get
			{
				return this._Valor_end_mestre;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_end_mestre_ValueChanged);
				if (this._Valor_end_mestre != null)
				{
					this._Valor_end_mestre.ValueChanged -= eventHandler;
				}
				this._Valor_end_mestre = value;
				if (this._Valor_end_mestre != null)
				{
					this._Valor_end_mestre.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x003E7AB8 File Offset: 0x003E5EB8
		// (set) Token: 0x06001F4A RID: 8010 RVA: 0x003E7ACC File Offset: 0x003E5ECC
		internal virtual NumericUpDown Valor_end_est
		{
			get
			{
				return this._Valor_end_est;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_end_est_ValueChanged);
				if (this._Valor_end_est != null)
				{
					this._Valor_end_est.ValueChanged -= eventHandler;
				}
				this._Valor_end_est = value;
				if (this._Valor_end_est != null)
				{
					this._Valor_end_est.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x003E7B18 File Offset: 0x003E5F18
		// (set) Token: 0x06001F4C RID: 8012 RVA: 0x003E7B2C File Offset: 0x003E5F2C
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

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x003E7B38 File Offset: 0x003E5F38
		// (set) Token: 0x06001F4E RID: 8014 RVA: 0x003E7B4C File Offset: 0x003E5F4C
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

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x003E7B58 File Offset: 0x003E5F58
		// (set) Token: 0x06001F50 RID: 8016 RVA: 0x003E7B6C File Offset: 0x003E5F6C
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

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x003E7B78 File Offset: 0x003E5F78
		// (set) Token: 0x06001F52 RID: 8018 RVA: 0x003E7B8C File Offset: 0x003E5F8C
		internal virtual MenuStrip MenuStrip1
		{
			get
			{
				return this._MenuStrip1;
			}
			[MethodImpl(32)]
			set
			{
				this._MenuStrip1 = value;
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x003E7B98 File Offset: 0x003E5F98
		// (set) Token: 0x06001F54 RID: 8020 RVA: 0x003E7BAC File Offset: 0x003E5FAC
		internal virtual ToolStripMenuItem ArquivoToolStripMenuItem
		{
			get
			{
				return this._ArquivoToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._ArquivoToolStripMenuItem = value;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x003E7BB8 File Offset: 0x003E5FB8
		// (set) Token: 0x06001F56 RID: 8022 RVA: 0x003E7BCC File Offset: 0x003E5FCC
		internal virtual ToolStripMenuItem NovoToolStripMenuItem
		{
			get
			{
				return this._NovoToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NovoToolStripMenuItem_Click);
				if (this._NovoToolStripMenuItem != null)
				{
					this._NovoToolStripMenuItem.Click -= eventHandler;
				}
				this._NovoToolStripMenuItem = value;
				if (this._NovoToolStripMenuItem != null)
				{
					this._NovoToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x003E7C18 File Offset: 0x003E6018
		// (set) Token: 0x06001F58 RID: 8024 RVA: 0x003E7C2C File Offset: 0x003E602C
		internal virtual ToolStripMenuItem AbrirToolStripMenuItem
		{
			get
			{
				return this._AbrirToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.AbrirToolStripMenuItem_Click);
				if (this._AbrirToolStripMenuItem != null)
				{
					this._AbrirToolStripMenuItem.Click -= eventHandler;
				}
				this._AbrirToolStripMenuItem = value;
				if (this._AbrirToolStripMenuItem != null)
				{
					this._AbrirToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x003E7C78 File Offset: 0x003E6078
		// (set) Token: 0x06001F5A RID: 8026 RVA: 0x003E7C8C File Offset: 0x003E608C
		internal virtual ToolStripMenuItem SalvarToolStripMenuItem
		{
			get
			{
				return this._SalvarToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalvarToolStripMenuItem_Click_1);
				if (this._SalvarToolStripMenuItem != null)
				{
					this._SalvarToolStripMenuItem.Click -= eventHandler;
				}
				this._SalvarToolStripMenuItem = value;
				if (this._SalvarToolStripMenuItem != null)
				{
					this._SalvarToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x003E7CD8 File Offset: 0x003E60D8
		// (set) Token: 0x06001F5C RID: 8028 RVA: 0x003E7CEC File Offset: 0x003E60EC
		internal virtual NumericUpDown Numero_motores
		{
			get
			{
				return this._Numero_motores;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Numero_motores_ValueChanged);
				if (this._Numero_motores != null)
				{
					this._Numero_motores.ValueChanged -= eventHandler;
				}
				this._Numero_motores = value;
				if (this._Numero_motores != null)
				{
					this._Numero_motores.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06001F5D RID: 8029 RVA: 0x003E7D38 File Offset: 0x003E6138
		// (set) Token: 0x06001F5E RID: 8030 RVA: 0x003E7D4C File Offset: 0x003E614C
		internal virtual NumericUpDown Valor_nivel_liga_b3
		{
			get
			{
				return this._Valor_nivel_liga_b3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_nivel_liga_b3_ValueChanged);
				if (this._Valor_nivel_liga_b3 != null)
				{
					this._Valor_nivel_liga_b3.ValueChanged -= eventHandler;
				}
				this._Valor_nivel_liga_b3 = value;
				if (this._Valor_nivel_liga_b3 != null)
				{
					this._Valor_nivel_liga_b3.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x003E7D98 File Offset: 0x003E6198
		// (set) Token: 0x06001F60 RID: 8032 RVA: 0x003E7DAC File Offset: 0x003E61AC
		internal virtual NumericUpDown Valor_nivel_liga_b2
		{
			get
			{
				return this._Valor_nivel_liga_b2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_nivel_liga_b2_ValueChanged);
				if (this._Valor_nivel_liga_b2 != null)
				{
					this._Valor_nivel_liga_b2.ValueChanged -= eventHandler;
				}
				this._Valor_nivel_liga_b2 = value;
				if (this._Valor_nivel_liga_b2 != null)
				{
					this._Valor_nivel_liga_b2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x003E7DF8 File Offset: 0x003E61F8
		// (set) Token: 0x06001F62 RID: 8034 RVA: 0x003E7E0C File Offset: 0x003E620C
		internal virtual Label Label_nivel_liga_b2
		{
			get
			{
				return this._Label_nivel_liga_b2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_liga_b2 = value;
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06001F63 RID: 8035 RVA: 0x003E7E18 File Offset: 0x003E6218
		// (set) Token: 0x06001F64 RID: 8036 RVA: 0x003E7E2C File Offset: 0x003E622C
		internal virtual Label Label_nivel_liga_b3
		{
			get
			{
				return this._Label_nivel_liga_b3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_liga_b3 = value;
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06001F65 RID: 8037 RVA: 0x003E7E38 File Offset: 0x003E6238
		// (set) Token: 0x06001F66 RID: 8038 RVA: 0x003E7E4C File Offset: 0x003E624C
		internal virtual Label Label_num_motores
		{
			get
			{
				return this._Label_num_motores;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_num_motores = value;
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06001F67 RID: 8039 RVA: 0x003E7E58 File Offset: 0x003E6258
		// (set) Token: 0x06001F68 RID: 8040 RVA: 0x003E7E6C File Offset: 0x003E626C
		internal virtual GroupBox Grupo_setpoints
		{
			get
			{
				return this._Grupo_setpoints;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_setpoints = value;
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06001F69 RID: 8041 RVA: 0x003E7E78 File Offset: 0x003E6278
		// (set) Token: 0x06001F6A RID: 8042 RVA: 0x003E7E8C File Offset: 0x003E628C
		internal virtual NumericUpDown Valor_nivel_liberacao
		{
			get
			{
				return this._Valor_nivel_liberacao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_nivel_liberacao_ValueChanged);
				if (this._Valor_nivel_liberacao != null)
				{
					this._Valor_nivel_liberacao.ValueChanged -= eventHandler;
				}
				this._Valor_nivel_liberacao = value;
				if (this._Valor_nivel_liberacao != null)
				{
					this._Valor_nivel_liberacao.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x003E7ED8 File Offset: 0x003E62D8
		// (set) Token: 0x06001F6C RID: 8044 RVA: 0x003E7EEC File Offset: 0x003E62EC
		internal virtual NumericUpDown Valor_nivel_bloqueio
		{
			get
			{
				return this._Valor_nivel_bloqueio;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_nivel_bloqueio_ValueChanged);
				if (this._Valor_nivel_bloqueio != null)
				{
					this._Valor_nivel_bloqueio.ValueChanged -= eventHandler;
				}
				this._Valor_nivel_bloqueio = value;
				if (this._Valor_nivel_bloqueio != null)
				{
					this._Valor_nivel_bloqueio.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x003E7F38 File Offset: 0x003E6338
		// (set) Token: 0x06001F6E RID: 8046 RVA: 0x003E7F4C File Offset: 0x003E634C
		internal virtual Label Label_nivel_liberacao
		{
			get
			{
				return this._Label_nivel_liberacao;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_liberacao = value;
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x003E7F58 File Offset: 0x003E6358
		// (set) Token: 0x06001F70 RID: 8048 RVA: 0x003E7F6C File Offset: 0x003E636C
		internal virtual Label Label_nivel_bloqueio
		{
			get
			{
				return this._Label_nivel_bloqueio;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_bloqueio = value;
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x003E7F78 File Offset: 0x003E6378
		// (set) Token: 0x06001F72 RID: 8050 RVA: 0x003E7F8C File Offset: 0x003E638C
		internal virtual GroupBox Grupo_analogicas
		{
			get
			{
				return this._Grupo_analogicas;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_analogicas = value;
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x003E7F98 File Offset: 0x003E6398
		// (set) Token: 0x06001F74 RID: 8052 RVA: 0x003E7FAC File Offset: 0x003E63AC
		internal virtual GroupBox Grupo_entradas_digitais
		{
			get
			{
				return this._Grupo_entradas_digitais;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_entradas_digitais = value;
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06001F75 RID: 8053 RVA: 0x003E7FB8 File Offset: 0x003E63B8
		// (set) Token: 0x06001F76 RID: 8054 RVA: 0x003E7FCC File Offset: 0x003E63CC
		internal virtual ComboBox ComboBox_E08
		{
			get
			{
				return this._ComboBox_E08;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_E08_SelectedIndexChanged);
				if (this._ComboBox_E08 != null)
				{
					this._ComboBox_E08.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_E08 = value;
				if (this._ComboBox_E08 != null)
				{
					this._ComboBox_E08.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x003E8018 File Offset: 0x003E6418
		// (set) Token: 0x06001F78 RID: 8056 RVA: 0x003E802C File Offset: 0x003E642C
		internal virtual ComboBox ComboBox_E07
		{
			get
			{
				return this._ComboBox_E07;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_E07_SelectedIndexChanged);
				if (this._ComboBox_E07 != null)
				{
					this._ComboBox_E07.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_E07 = value;
				if (this._ComboBox_E07 != null)
				{
					this._ComboBox_E07.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x003E8078 File Offset: 0x003E6478
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x003E808C File Offset: 0x003E648C
		internal virtual ComboBox ComboBox_E06
		{
			get
			{
				return this._ComboBox_E06;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_E06_SelectedIndexChanged);
				if (this._ComboBox_E06 != null)
				{
					this._ComboBox_E06.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_E06 = value;
				if (this._ComboBox_E06 != null)
				{
					this._ComboBox_E06.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x003E80D8 File Offset: 0x003E64D8
		// (set) Token: 0x06001F7C RID: 8060 RVA: 0x003E80EC File Offset: 0x003E64EC
		internal virtual ComboBox ComboBox_E05
		{
			get
			{
				return this._ComboBox_E05;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_E05_SelectedIndexChanged);
				if (this._ComboBox_E05 != null)
				{
					this._ComboBox_E05.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_E05 = value;
				if (this._ComboBox_E05 != null)
				{
					this._ComboBox_E05.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x003E8138 File Offset: 0x003E6538
		// (set) Token: 0x06001F7E RID: 8062 RVA: 0x003E814C File Offset: 0x003E654C
		internal virtual ComboBox ComboBox_E04
		{
			get
			{
				return this._ComboBox_E04;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_E04_SelectedIndexChanged);
				if (this._ComboBox_E04 != null)
				{
					this._ComboBox_E04.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_E04 = value;
				if (this._ComboBox_E04 != null)
				{
					this._ComboBox_E04.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x003E8198 File Offset: 0x003E6598
		// (set) Token: 0x06001F80 RID: 8064 RVA: 0x003E81AC File Offset: 0x003E65AC
		internal virtual ComboBox ComboBox_E03
		{
			get
			{
				return this._ComboBox_E03;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_E03_SelectedIndexChanged);
				if (this._ComboBox_E03 != null)
				{
					this._ComboBox_E03.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_E03 = value;
				if (this._ComboBox_E03 != null)
				{
					this._ComboBox_E03.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x003E81F8 File Offset: 0x003E65F8
		// (set) Token: 0x06001F82 RID: 8066 RVA: 0x003E820C File Offset: 0x003E660C
		internal virtual ComboBox ComboBox_E02
		{
			get
			{
				return this._ComboBox_E02;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_E02_SelectedIndexChanged);
				if (this._ComboBox_E02 != null)
				{
					this._ComboBox_E02.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_E02 = value;
				if (this._ComboBox_E02 != null)
				{
					this._ComboBox_E02.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x003E8258 File Offset: 0x003E6658
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x003E826C File Offset: 0x003E666C
		internal virtual ComboBox ComboBox_E01
		{
			get
			{
				return this._ComboBox_E01;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_E01_SelectedIndexChanged);
				if (this._ComboBox_E01 != null)
				{
					this._ComboBox_E01.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_E01 = value;
				if (this._ComboBox_E01 != null)
				{
					this._ComboBox_E01.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x003E82B8 File Offset: 0x003E66B8
		// (set) Token: 0x06001F86 RID: 8070 RVA: 0x003E82CC File Offset: 0x003E66CC
		internal virtual Label Label_E08
		{
			get
			{
				return this._Label_E08;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_E08 = value;
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x003E82D8 File Offset: 0x003E66D8
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x003E82EC File Offset: 0x003E66EC
		internal virtual Label Label_E07
		{
			get
			{
				return this._Label_E07;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_E07 = value;
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x003E82F8 File Offset: 0x003E66F8
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x003E830C File Offset: 0x003E670C
		internal virtual Label Label_E06
		{
			get
			{
				return this._Label_E06;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_E06 = value;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x003E8318 File Offset: 0x003E6718
		// (set) Token: 0x06001F8C RID: 8076 RVA: 0x003E832C File Offset: 0x003E672C
		internal virtual Label Label_E05
		{
			get
			{
				return this._Label_E05;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_E05 = value;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x003E8338 File Offset: 0x003E6738
		// (set) Token: 0x06001F8E RID: 8078 RVA: 0x003E834C File Offset: 0x003E674C
		internal virtual Label Label_E04
		{
			get
			{
				return this._Label_E04;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_E04 = value;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x003E8358 File Offset: 0x003E6758
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x003E836C File Offset: 0x003E676C
		internal virtual Label Label_E03
		{
			get
			{
				return this._Label_E03;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_E03 = value;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x003E8378 File Offset: 0x003E6778
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x003E838C File Offset: 0x003E678C
		internal virtual Label Label_E02
		{
			get
			{
				return this._Label_E02;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_E02 = value;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x003E8398 File Offset: 0x003E6798
		// (set) Token: 0x06001F94 RID: 8084 RVA: 0x003E83AC File Offset: 0x003E67AC
		internal virtual Label Label_E01
		{
			get
			{
				return this._Label_E01;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_E01 = value;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x003E83B8 File Offset: 0x003E67B8
		// (set) Token: 0x06001F96 RID: 8086 RVA: 0x003E83CC File Offset: 0x003E67CC
		internal virtual NumericUpDown Valor_tamanho_filtro_AD
		{
			get
			{
				return this._Valor_tamanho_filtro_AD;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_tamanho_filtro_AD_ValueChanged);
				if (this._Valor_tamanho_filtro_AD != null)
				{
					this._Valor_tamanho_filtro_AD.ValueChanged -= eventHandler;
				}
				this._Valor_tamanho_filtro_AD = value;
				if (this._Valor_tamanho_filtro_AD != null)
				{
					this._Valor_tamanho_filtro_AD.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x003E8418 File Offset: 0x003E6818
		// (set) Token: 0x06001F98 RID: 8088 RVA: 0x003E842C File Offset: 0x003E682C
		internal virtual NumericUpDown Valor_intervalo_filtro_AD
		{
			get
			{
				return this._Valor_intervalo_filtro_AD;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_intervalo_filtro_AD_ValueChanged);
				if (this._Valor_intervalo_filtro_AD != null)
				{
					this._Valor_intervalo_filtro_AD.ValueChanged -= eventHandler;
				}
				this._Valor_intervalo_filtro_AD = value;
				if (this._Valor_intervalo_filtro_AD != null)
				{
					this._Valor_intervalo_filtro_AD.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x003E8478 File Offset: 0x003E6878
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x003E848C File Offset: 0x003E688C
		internal virtual Label Label_tamanho_filtro_AD
		{
			get
			{
				return this._Label_tamanho_filtro_AD;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tamanho_filtro_AD = value;
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x003E8498 File Offset: 0x003E6898
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x003E84AC File Offset: 0x003E68AC
		internal virtual Label Label_intervalo_filtro_AD
		{
			get
			{
				return this._Label_intervalo_filtro_AD;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_intervalo_filtro_AD = value;
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x003E84B8 File Offset: 0x003E68B8
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x003E84CC File Offset: 0x003E68CC
		internal virtual ComboBox Combo_modo_operacao
		{
			get
			{
				return this._Combo_modo_operacao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_modo_operacao_SelectedIndexChanged);
				if (this._Combo_modo_operacao != null)
				{
					this._Combo_modo_operacao.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_modo_operacao = value;
				if (this._Combo_modo_operacao != null)
				{
					this._Combo_modo_operacao.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x003E8518 File Offset: 0x003E6918
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x003E852C File Offset: 0x003E692C
		internal virtual Label Label_modo_operacao
		{
			get
			{
				return this._Label_modo_operacao;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_modo_operacao = value;
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x003E8538 File Offset: 0x003E6938
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x003E854C File Offset: 0x003E694C
		internal virtual ComboBox Combo_baudrate
		{
			get
			{
				return this._Combo_baudrate;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_baudrate_SelectedIndexChanged);
				if (this._Combo_baudrate != null)
				{
					this._Combo_baudrate.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_baudrate = value;
				if (this._Combo_baudrate != null)
				{
					this._Combo_baudrate.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x003E8598 File Offset: 0x003E6998
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x003E85AC File Offset: 0x003E69AC
		internal virtual Label Label_baudrate
		{
			get
			{
				return this._Label_baudrate;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_baudrate = value;
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x003E85B8 File Offset: 0x003E69B8
		// (set) Token: 0x06001FA6 RID: 8102 RVA: 0x003E85CC File Offset: 0x003E69CC
		internal virtual NumericUpDown Valor_num_bomba_simultaneas
		{
			get
			{
				return this._Valor_num_bomba_simultaneas;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_num_bomba_simultaneas_ValueChanged);
				if (this._Valor_num_bomba_simultaneas != null)
				{
					this._Valor_num_bomba_simultaneas.ValueChanged -= eventHandler;
				}
				this._Valor_num_bomba_simultaneas = value;
				if (this._Valor_num_bomba_simultaneas != null)
				{
					this._Valor_num_bomba_simultaneas.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x003E8618 File Offset: 0x003E6A18
		// (set) Token: 0x06001FA8 RID: 8104 RVA: 0x003E862C File Offset: 0x003E6A2C
		internal virtual Label Label_num_bombas_simultaneas
		{
			get
			{
				return this._Label_num_bombas_simultaneas;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_num_bombas_simultaneas = value;
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06001FA9 RID: 8105 RVA: 0x003E8638 File Offset: 0x003E6A38
		// (set) Token: 0x06001FAA RID: 8106 RVA: 0x003E864C File Offset: 0x003E6A4C
		internal virtual ComboBox Combo_modo_partida_m1
		{
			get
			{
				return this._Combo_modo_partida_m1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_modo_partida_m1_SelectedIndexChanged_1);
				if (this._Combo_modo_partida_m1 != null)
				{
					this._Combo_modo_partida_m1.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_modo_partida_m1 = value;
				if (this._Combo_modo_partida_m1 != null)
				{
					this._Combo_modo_partida_m1.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x003E8698 File Offset: 0x003E6A98
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x003E86AC File Offset: 0x003E6AAC
		internal virtual NumericUpDown Tempo_parada_m1
		{
			get
			{
				return this._Tempo_parada_m1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_parada_m1_ValueChanged);
				if (this._Tempo_parada_m1 != null)
				{
					this._Tempo_parada_m1.ValueChanged -= eventHandler;
				}
				this._Tempo_parada_m1 = value;
				if (this._Tempo_parada_m1 != null)
				{
					this._Tempo_parada_m1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x003E86F8 File Offset: 0x003E6AF8
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x003E870C File Offset: 0x003E6B0C
		internal virtual NumericUpDown Tempo_partida_m1
		{
			get
			{
				return this._Tempo_partida_m1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_partida_m1_ValueChanged);
				if (this._Tempo_partida_m1 != null)
				{
					this._Tempo_partida_m1.ValueChanged -= eventHandler;
				}
				this._Tempo_partida_m1 = value;
				if (this._Tempo_partida_m1 != null)
				{
					this._Tempo_partida_m1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x003E8758 File Offset: 0x003E6B58
		// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x003E876C File Offset: 0x003E6B6C
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

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x003E8778 File Offset: 0x003E6B78
		// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x003E878C File Offset: 0x003E6B8C
		internal virtual Label Label_motor4
		{
			get
			{
				return this._Label_motor4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_motor4 = value;
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x003E8798 File Offset: 0x003E6B98
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x003E87AC File Offset: 0x003E6BAC
		internal virtual Label Label_motor3
		{
			get
			{
				return this._Label_motor3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_motor3 = value;
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x003E87B8 File Offset: 0x003E6BB8
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x003E87CC File Offset: 0x003E6BCC
		internal virtual ComboBox Combo_modo_partida_m4
		{
			get
			{
				return this._Combo_modo_partida_m4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_modo_partida_m4_SelectedIndexChanged);
				if (this._Combo_modo_partida_m4 != null)
				{
					this._Combo_modo_partida_m4.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_modo_partida_m4 = value;
				if (this._Combo_modo_partida_m4 != null)
				{
					this._Combo_modo_partida_m4.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x003E8818 File Offset: 0x003E6C18
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x003E882C File Offset: 0x003E6C2C
		internal virtual ComboBox Combo_modo_partida_m3
		{
			get
			{
				return this._Combo_modo_partida_m3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_modo_partida_m3_SelectedIndexChanged);
				if (this._Combo_modo_partida_m3 != null)
				{
					this._Combo_modo_partida_m3.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_modo_partida_m3 = value;
				if (this._Combo_modo_partida_m3 != null)
				{
					this._Combo_modo_partida_m3.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x003E8878 File Offset: 0x003E6C78
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x003E888C File Offset: 0x003E6C8C
		internal virtual Label Label_motor2
		{
			get
			{
				return this._Label_motor2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_motor2 = value;
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x003E8898 File Offset: 0x003E6C98
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x003E88AC File Offset: 0x003E6CAC
		internal virtual ComboBox Combo_modo_partida_m2
		{
			get
			{
				return this._Combo_modo_partida_m2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_modo_partida_m2_SelectedIndexChanged);
				if (this._Combo_modo_partida_m2 != null)
				{
					this._Combo_modo_partida_m2.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_modo_partida_m2 = value;
				if (this._Combo_modo_partida_m2 != null)
				{
					this._Combo_modo_partida_m2.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x003E88F8 File Offset: 0x003E6CF8
		// (set) Token: 0x06001FBE RID: 8126 RVA: 0x003E890C File Offset: 0x003E6D0C
		internal virtual NumericUpDown Tempo_partida_m4
		{
			get
			{
				return this._Tempo_partida_m4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_partida_m4_ValueChanged);
				if (this._Tempo_partida_m4 != null)
				{
					this._Tempo_partida_m4.ValueChanged -= eventHandler;
				}
				this._Tempo_partida_m4 = value;
				if (this._Tempo_partida_m4 != null)
				{
					this._Tempo_partida_m4.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x003E8958 File Offset: 0x003E6D58
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x003E896C File Offset: 0x003E6D6C
		internal virtual NumericUpDown Tempo_partida_m3
		{
			get
			{
				return this._Tempo_partida_m3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_partida_m3_ValueChanged);
				if (this._Tempo_partida_m3 != null)
				{
					this._Tempo_partida_m3.ValueChanged -= eventHandler;
				}
				this._Tempo_partida_m3 = value;
				if (this._Tempo_partida_m3 != null)
				{
					this._Tempo_partida_m3.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x003E89B8 File Offset: 0x003E6DB8
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x003E89CC File Offset: 0x003E6DCC
		internal virtual Label Label_motor1
		{
			get
			{
				return this._Label_motor1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_motor1 = value;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x003E89D8 File Offset: 0x003E6DD8
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x003E89EC File Offset: 0x003E6DEC
		internal virtual NumericUpDown Tempo_parada_m4
		{
			get
			{
				return this._Tempo_parada_m4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_parada_m4_ValueChanged);
				if (this._Tempo_parada_m4 != null)
				{
					this._Tempo_parada_m4.ValueChanged -= eventHandler;
				}
				this._Tempo_parada_m4 = value;
				if (this._Tempo_parada_m4 != null)
				{
					this._Tempo_parada_m4.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x003E8A38 File Offset: 0x003E6E38
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x003E8A4C File Offset: 0x003E6E4C
		internal virtual NumericUpDown Tempo_partida_m2
		{
			get
			{
				return this._Tempo_partida_m2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_partida_m2_ValueChanged);
				if (this._Tempo_partida_m2 != null)
				{
					this._Tempo_partida_m2.ValueChanged -= eventHandler;
				}
				this._Tempo_partida_m2 = value;
				if (this._Tempo_partida_m2 != null)
				{
					this._Tempo_partida_m2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x003E8A98 File Offset: 0x003E6E98
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x003E8AAC File Offset: 0x003E6EAC
		internal virtual NumericUpDown Tempo_parada_m3
		{
			get
			{
				return this._Tempo_parada_m3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_parada_m3_ValueChanged);
				if (this._Tempo_parada_m3 != null)
				{
					this._Tempo_parada_m3.ValueChanged -= eventHandler;
				}
				this._Tempo_parada_m3 = value;
				if (this._Tempo_parada_m3 != null)
				{
					this._Tempo_parada_m3.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x003E8AF8 File Offset: 0x003E6EF8
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x003E8B0C File Offset: 0x003E6F0C
		internal virtual NumericUpDown Tempo_parada_m2
		{
			get
			{
				return this._Tempo_parada_m2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_parada_m2_ValueChanged);
				if (this._Tempo_parada_m2 != null)
				{
					this._Tempo_parada_m2.ValueChanged -= eventHandler;
				}
				this._Tempo_parada_m2 = value;
				if (this._Tempo_parada_m2 != null)
				{
					this._Tempo_parada_m2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x003E8B58 File Offset: 0x003E6F58
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x003E8B6C File Offset: 0x003E6F6C
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

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x003E8B78 File Offset: 0x003E6F78
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x003E8B8C File Offset: 0x003E6F8C
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

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x003E8B98 File Offset: 0x003E6F98
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x003E8BAC File Offset: 0x003E6FAC
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

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x003E8BB8 File Offset: 0x003E6FB8
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x003E8BCC File Offset: 0x003E6FCC
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

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x003E8BD8 File Offset: 0x003E6FD8
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x003E8BEC File Offset: 0x003E6FEC
		internal virtual NumericUpDown Tempo_abertura_v4
		{
			get
			{
				return this._Tempo_abertura_v4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_abertura_v4_ValueChanged);
				if (this._Tempo_abertura_v4 != null)
				{
					this._Tempo_abertura_v4.ValueChanged -= eventHandler;
				}
				this._Tempo_abertura_v4 = value;
				if (this._Tempo_abertura_v4 != null)
				{
					this._Tempo_abertura_v4.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x003E8C38 File Offset: 0x003E7038
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x003E8C4C File Offset: 0x003E704C
		internal virtual NumericUpDown Tempo_abertura_v3
		{
			get
			{
				return this._Tempo_abertura_v3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_abertura_v3_ValueChanged);
				if (this._Tempo_abertura_v3 != null)
				{
					this._Tempo_abertura_v3.ValueChanged -= eventHandler;
				}
				this._Tempo_abertura_v3 = value;
				if (this._Tempo_abertura_v3 != null)
				{
					this._Tempo_abertura_v3.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x003E8C98 File Offset: 0x003E7098
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x003E8CAC File Offset: 0x003E70AC
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

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x003E8CB8 File Offset: 0x003E70B8
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x003E8CCC File Offset: 0x003E70CC
		internal virtual NumericUpDown Tempo_fechamento_v4
		{
			get
			{
				return this._Tempo_fechamento_v4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_fechamento_v4_ValueChanged);
				if (this._Tempo_fechamento_v4 != null)
				{
					this._Tempo_fechamento_v4.ValueChanged -= eventHandler;
				}
				this._Tempo_fechamento_v4 = value;
				if (this._Tempo_fechamento_v4 != null)
				{
					this._Tempo_fechamento_v4.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x003E8D18 File Offset: 0x003E7118
		// (set) Token: 0x06001FDC RID: 8156 RVA: 0x003E8D2C File Offset: 0x003E712C
		internal virtual NumericUpDown Tempo_abertura_v2
		{
			get
			{
				return this._Tempo_abertura_v2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_abertura_v2_ValueChanged);
				if (this._Tempo_abertura_v2 != null)
				{
					this._Tempo_abertura_v2.ValueChanged -= eventHandler;
				}
				this._Tempo_abertura_v2 = value;
				if (this._Tempo_abertura_v2 != null)
				{
					this._Tempo_abertura_v2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x003E8D78 File Offset: 0x003E7178
		// (set) Token: 0x06001FDE RID: 8158 RVA: 0x003E8D8C File Offset: 0x003E718C
		internal virtual NumericUpDown Tempo_fechamento_v3
		{
			get
			{
				return this._Tempo_fechamento_v3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_fechamento_v3_ValueChanged);
				if (this._Tempo_fechamento_v3 != null)
				{
					this._Tempo_fechamento_v3.ValueChanged -= eventHandler;
				}
				this._Tempo_fechamento_v3 = value;
				if (this._Tempo_fechamento_v3 != null)
				{
					this._Tempo_fechamento_v3.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x003E8DD8 File Offset: 0x003E71D8
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x003E8DEC File Offset: 0x003E71EC
		internal virtual NumericUpDown Tempo_fechamento_v2
		{
			get
			{
				return this._Tempo_fechamento_v2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_fechamento_v2_ValueChanged);
				if (this._Tempo_fechamento_v2 != null)
				{
					this._Tempo_fechamento_v2.ValueChanged -= eventHandler;
				}
				this._Tempo_fechamento_v2 = value;
				if (this._Tempo_fechamento_v2 != null)
				{
					this._Tempo_fechamento_v2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x003E8E38 File Offset: 0x003E7238
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x003E8E4C File Offset: 0x003E724C
		internal virtual NumericUpDown Tempo_abertura_v1
		{
			get
			{
				return this._Tempo_abertura_v1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_abertura_v1_ValueChanged);
				if (this._Tempo_abertura_v1 != null)
				{
					this._Tempo_abertura_v1.ValueChanged -= eventHandler;
				}
				this._Tempo_abertura_v1 = value;
				if (this._Tempo_abertura_v1 != null)
				{
					this._Tempo_abertura_v1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x003E8E98 File Offset: 0x003E7298
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x003E8EAC File Offset: 0x003E72AC
		internal virtual NumericUpDown Tempo_fechamento_v1
		{
			get
			{
				return this._Tempo_fechamento_v1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tempo_fechamento_v1_ValueChanged);
				if (this._Tempo_fechamento_v1 != null)
				{
					this._Tempo_fechamento_v1.ValueChanged -= eventHandler;
				}
				this._Tempo_fechamento_v1 = value;
				if (this._Tempo_fechamento_v1 != null)
				{
					this._Tempo_fechamento_v1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x003E8EF8 File Offset: 0x003E72F8
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x003E8F0C File Offset: 0x003E730C
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

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x003E8F18 File Offset: 0x003E7318
		// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x003E8F2C File Offset: 0x003E732C
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

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x003E8F38 File Offset: 0x003E7338
		// (set) Token: 0x06001FEA RID: 8170 RVA: 0x003E8F4C File Offset: 0x003E734C
		internal virtual Label Label_tempo_parada
		{
			get
			{
				return this._Label_tempo_parada;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_parada = value;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x003E8F58 File Offset: 0x003E7358
		// (set) Token: 0x06001FEC RID: 8172 RVA: 0x003E8F6C File Offset: 0x003E736C
		internal virtual Label Label_tempo_partida
		{
			get
			{
				return this._Label_tempo_partida;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_partida = value;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x003E8F78 File Offset: 0x003E7378
		// (set) Token: 0x06001FEE RID: 8174 RVA: 0x003E8F8C File Offset: 0x003E738C
		internal virtual Label Label_modo_de_operacao_motor
		{
			get
			{
				return this._Label_modo_de_operacao_motor;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_modo_de_operacao_motor = value;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x003E8F98 File Offset: 0x003E7398
		// (set) Token: 0x06001FF0 RID: 8176 RVA: 0x003E8FAC File Offset: 0x003E73AC
		internal virtual ComboBox Combo_num_totalizacoes
		{
			get
			{
				return this._Combo_num_totalizacoes;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_num_totalizacoes_SelectedIndexChanged);
				if (this._Combo_num_totalizacoes != null)
				{
					this._Combo_num_totalizacoes.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_num_totalizacoes = value;
				if (this._Combo_num_totalizacoes != null)
				{
					this._Combo_num_totalizacoes.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x003E8FF8 File Offset: 0x003E73F8
		// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x003E900C File Offset: 0x003E740C
		internal virtual Label Label_num_totalizacoes
		{
			get
			{
				return this._Label_num_totalizacoes;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_num_totalizacoes = value;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x003E9018 File Offset: 0x003E7418
		// (set) Token: 0x06001FF4 RID: 8180 RVA: 0x003E902C File Offset: 0x003E742C
		internal virtual CheckBox CheckBox_ctrl_nivel_fonte
		{
			get
			{
				return this._CheckBox_ctrl_nivel_fonte;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_ctrl_nivel_fonte_CheckedChanged);
				if (this._CheckBox_ctrl_nivel_fonte != null)
				{
					this._CheckBox_ctrl_nivel_fonte.CheckedChanged -= eventHandler;
				}
				this._CheckBox_ctrl_nivel_fonte = value;
				if (this._CheckBox_ctrl_nivel_fonte != null)
				{
					this._CheckBox_ctrl_nivel_fonte.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x003E9078 File Offset: 0x003E7478
		// (set) Token: 0x06001FF6 RID: 8182 RVA: 0x003E908C File Offset: 0x003E748C
		internal virtual OpenFileDialog OpenFileDialog1
		{
			get
			{
				return this._OpenFileDialog1;
			}
			[MethodImpl(32)]
			set
			{
				this._OpenFileDialog1 = value;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x003E9098 File Offset: 0x003E7498
		// (set) Token: 0x06001FF8 RID: 8184 RVA: 0x003E90AC File Offset: 0x003E74AC
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get
			{
				return this._SaveFileDialog1;
			}
			[MethodImpl(32)]
			set
			{
				this._SaveFileDialog1 = value;
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x003E90B8 File Offset: 0x003E74B8
		// (set) Token: 0x06001FFA RID: 8186 RVA: 0x003E90CC File Offset: 0x003E74CC
		internal virtual GroupBox Grupo_perifericos
		{
			get
			{
				return this._Grupo_perifericos;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_perifericos = value;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x003E90D8 File Offset: 0x003E74D8
		// (set) Token: 0x06001FFC RID: 8188 RVA: 0x003E90EC File Offset: 0x003E74EC
		internal virtual NumericUpDown Endereco_p1
		{
			get
			{
				return this._Endereco_p1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Endereco_p1_ValueChanged);
				if (this._Endereco_p1 != null)
				{
					this._Endereco_p1.ValueChanged -= eventHandler;
				}
				this._Endereco_p1 = value;
				if (this._Endereco_p1 != null)
				{
					this._Endereco_p1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x003E9138 File Offset: 0x003E7538
		// (set) Token: 0x06001FFE RID: 8190 RVA: 0x003E914C File Offset: 0x003E754C
		internal virtual ComboBox Combo_tipo_p4
		{
			get
			{
				return this._Combo_tipo_p4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_tipo_p4_SelectedIndexChanged);
				if (this._Combo_tipo_p4 != null)
				{
					this._Combo_tipo_p4.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_tipo_p4 = value;
				if (this._Combo_tipo_p4 != null)
				{
					this._Combo_tipo_p4.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x003E9198 File Offset: 0x003E7598
		// (set) Token: 0x06002000 RID: 8192 RVA: 0x003E91AC File Offset: 0x003E75AC
		internal virtual ComboBox Combo_tipo_p2
		{
			get
			{
				return this._Combo_tipo_p2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_tipo_p2_SelectedIndexChanged);
				if (this._Combo_tipo_p2 != null)
				{
					this._Combo_tipo_p2.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_tipo_p2 = value;
				if (this._Combo_tipo_p2 != null)
				{
					this._Combo_tipo_p2.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x003E91F8 File Offset: 0x003E75F8
		// (set) Token: 0x06002002 RID: 8194 RVA: 0x003E920C File Offset: 0x003E760C
		internal virtual ComboBox Combo_tipo_p3
		{
			get
			{
				return this._Combo_tipo_p3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_tipo_p3_SelectedIndexChanged);
				if (this._Combo_tipo_p3 != null)
				{
					this._Combo_tipo_p3.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_tipo_p3 = value;
				if (this._Combo_tipo_p3 != null)
				{
					this._Combo_tipo_p3.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x003E9258 File Offset: 0x003E7658
		// (set) Token: 0x06002004 RID: 8196 RVA: 0x003E926C File Offset: 0x003E766C
		internal virtual ComboBox Combo_tipo_p1
		{
			get
			{
				return this._Combo_tipo_p1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_tipo_p1_SelectedIndexChanged);
				if (this._Combo_tipo_p1 != null)
				{
					this._Combo_tipo_p1.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_tipo_p1 = value;
				if (this._Combo_tipo_p1 != null)
				{
					this._Combo_tipo_p1.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06002005 RID: 8197 RVA: 0x003E92B8 File Offset: 0x003E76B8
		// (set) Token: 0x06002006 RID: 8198 RVA: 0x003E92CC File Offset: 0x003E76CC
		internal virtual Label Label_nota_2
		{
			get
			{
				return this._Label_nota_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nota_2 = value;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06002007 RID: 8199 RVA: 0x003E92D8 File Offset: 0x003E76D8
		// (set) Token: 0x06002008 RID: 8200 RVA: 0x003E92EC File Offset: 0x003E76EC
		internal virtual Label Label_periferico_2
		{
			get
			{
				return this._Label_periferico_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_periferico_2 = value;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x003E92F8 File Offset: 0x003E76F8
		// (set) Token: 0x0600200A RID: 8202 RVA: 0x003E930C File Offset: 0x003E770C
		internal virtual Label Label_nota_1
		{
			get
			{
				return this._Label_nota_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nota_1 = value;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x003E9318 File Offset: 0x003E7718
		// (set) Token: 0x0600200C RID: 8204 RVA: 0x003E932C File Offset: 0x003E772C
		internal virtual Label Label_periferico_1
		{
			get
			{
				return this._Label_periferico_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_periferico_1 = value;
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x0600200D RID: 8205 RVA: 0x003E9338 File Offset: 0x003E7738
		// (set) Token: 0x0600200E RID: 8206 RVA: 0x003E934C File Offset: 0x003E774C
		internal virtual NumericUpDown Endereco_p4
		{
			get
			{
				return this._Endereco_p4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Endereco_p4_ValueChanged);
				if (this._Endereco_p4 != null)
				{
					this._Endereco_p4.ValueChanged -= eventHandler;
				}
				this._Endereco_p4 = value;
				if (this._Endereco_p4 != null)
				{
					this._Endereco_p4.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x0600200F RID: 8207 RVA: 0x003E9398 File Offset: 0x003E7798
		// (set) Token: 0x06002010 RID: 8208 RVA: 0x003E93AC File Offset: 0x003E77AC
		internal virtual NumericUpDown Endereco_p2
		{
			get
			{
				return this._Endereco_p2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Endereco_p2_ValueChanged);
				if (this._Endereco_p2 != null)
				{
					this._Endereco_p2.ValueChanged -= eventHandler;
				}
				this._Endereco_p2 = value;
				if (this._Endereco_p2 != null)
				{
					this._Endereco_p2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06002011 RID: 8209 RVA: 0x003E93F8 File Offset: 0x003E77F8
		// (set) Token: 0x06002012 RID: 8210 RVA: 0x003E940C File Offset: 0x003E780C
		internal virtual NumericUpDown Endereco_p3
		{
			get
			{
				return this._Endereco_p3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Endereco_p3_ValueChanged);
				if (this._Endereco_p3 != null)
				{
					this._Endereco_p3.ValueChanged -= eventHandler;
				}
				this._Endereco_p3 = value;
				if (this._Endereco_p3 != null)
				{
					this._Endereco_p3.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06002013 RID: 8211 RVA: 0x003E9458 File Offset: 0x003E7858
		// (set) Token: 0x06002014 RID: 8212 RVA: 0x003E946C File Offset: 0x003E786C
		internal virtual Label Label_periferico_4
		{
			get
			{
				return this._Label_periferico_4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_periferico_4 = value;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x003E9478 File Offset: 0x003E7878
		// (set) Token: 0x06002016 RID: 8214 RVA: 0x003E948C File Offset: 0x003E788C
		internal virtual Label Label_periferico_3
		{
			get
			{
				return this._Label_periferico_3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_periferico_3 = value;
			}
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x003E9498 File Offset: 0x003E7898
		private void Valor_end_mestre_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].End_mestre = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x003E94D0 File Offset: 0x003E78D0
		private void Valor_end_est_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].End_estacao = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x003E9508 File Offset: 0x003E7908
		private void Valor_temp_ptt_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_ptt = Conversions.ToInteger(Operators.DivideObject(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null), 10));
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x003E9554 File Offset: 0x003E7954
		private void Numero_motores_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Numero_motores = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			this.Atualiza_tela_MD202_motores(Mod_MD.Controle.Estacao);
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x003E95A4 File Offset: 0x003E79A4
		private void Numero_valvulas_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Numero_valvulas = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			this.Atualiza_tela_MD202_valvulas(Mod_MD.Controle.Estacao);
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x003E95F4 File Offset: 0x003E79F4
		private void Tempo_entre_acionamentos_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_entre_acionamento = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x003E962C File Offset: 0x003E7A2C
		private void Valor_num_bomba_simultaneas_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Num_bombas_simultaneas = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x003E9664 File Offset: 0x003E7A64
		private void Valor_intervalo_filtro_AD_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Intervalo_filtroAD = Conversions.ToInteger(Operators.DivideObject(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null), 10));
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x003E96B0 File Offset: 0x003E7AB0
		private void Valor_tamanho_filtro_AD_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tamanho_filtroAD = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x003E96E8 File Offset: 0x003E7AE8
		private void Valor_nivel_desejado_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Set_nivel_desejado = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x003E9720 File Offset: 0x003E7B20
		private void Valor_nivel_liga_b1_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Set_nivel_liga_bomba1 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x003E9758 File Offset: 0x003E7B58
		private void Valor_nivel_liga_b2_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Set_nivel_liga_bomba2 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x003E9790 File Offset: 0x003E7B90
		private void Valor_nivel_liga_b3_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Set_nivel_liga_bomba3 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x003E97C8 File Offset: 0x003E7BC8
		private void Valor_nivel_liga_b4_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Set_nivel_liga_bomba4 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x003E9800 File Offset: 0x003E7C00
		private void Valor_tempo_mais_bomba_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_mais_bomba = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x003E9838 File Offset: 0x003E7C38
		private void Valor_pressao_min_succao_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Pressao_min_succao = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x003E9870 File Offset: 0x003E7C70
		private void Valor_pressao_min_recalque_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Pressao_min_recalque = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x003E98A8 File Offset: 0x003E7CA8
		private void Valor_nivel_bloqueio_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Nivel_protecao_desliga = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x003E98E0 File Offset: 0x003E7CE0
		private void Valor_nivel_liberacao_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Nivel_protecao_liga = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x003E9918 File Offset: 0x003E7D18
		private void Tempo_partida_m1_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_partida[1] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x003E995C File Offset: 0x003E7D5C
		private void Tempo_partida_m2_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_partida[2] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x003E99A0 File Offset: 0x003E7DA0
		private void Tempo_partida_m3_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_partida[3] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x003E99E4 File Offset: 0x003E7DE4
		private void Tempo_partida_m4_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_partida[4] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x003E9A28 File Offset: 0x003E7E28
		private void Tempo_parada_m1_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_parada[1] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x003E9A6C File Offset: 0x003E7E6C
		private void Tempo_parada_m2_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_parada[2] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x003E9AB0 File Offset: 0x003E7EB0
		private void Tempo_parada_m3_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_parada[3] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x003E9AF4 File Offset: 0x003E7EF4
		private void Tempo_parada_m4_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_parada[4] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x003E9B38 File Offset: 0x003E7F38
		private void Combo_modo_partida_m2_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Modo_partida[2] = Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21877));
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x003E9B8C File Offset: 0x003E7F8C
		private void Combo_modo_partida_m3_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Modo_partida[3] = Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21877));
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x003E9BE0 File Offset: 0x003E7FE0
		private void Combo_modo_partida_m4_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Modo_partida[4] = Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21877));
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x003E9C34 File Offset: 0x003E8034
		private void CheckBox_hab_rep_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null), true, false))
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Hab_repetidora = 21856;
			}
			else
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Hab_repetidora = 0;
			}
			this.Atualiza_tela_MD202_repetidora(Mod_MD.Controle.Estacao);
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x003E9CB0 File Offset: 0x003E80B0
		private void Valor_end_rep_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].End_repetidora = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x003E9CE8 File Offset: 0x003E80E8
		private void Valor_num_est_rep_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Num_repetidoras = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			this.Limpa_dados_repetidora_MD202(Mod_MD.Controle.Estacao, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null)));
			this.Atualiza_tela_MD202_repetidora(Mod_MD.Controle.Estacao);
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x003E9D68 File Offset: 0x003E8168
		private void Valor_end_rep_1_Validating(object sender, CancelEventArgs e)
		{
			checked
			{
				int num = (int)Math.Round(Conversion.Val(this.Valor_end_rep_1.Text));
				if (num < 0 | num > 200)
				{
					e.Cancel = true;
				}
				else
				{
					Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Repetidoras[1 + this.passo_202 * 12] = num;
				}
			}
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x003E9DCC File Offset: 0x003E81CC
		private void Valor_end_rep_2_Validating(object sender, CancelEventArgs e)
		{
			checked
			{
				int num = (int)Math.Round(Conversion.Val(this.Valor_end_rep_2.Text));
				if (num < 0 | num > 200)
				{
					e.Cancel = true;
				}
				else
				{
					Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Repetidoras[2 + this.passo_202 * 12] = num;
				}
			}
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x003E9E30 File Offset: 0x003E8230
		private void Valor_end_rep_3_Validating(object sender, CancelEventArgs e)
		{
			checked
			{
				int num = (int)Math.Round(Conversion.Val(this.Valor_end_rep_3.Text));
				if (num < 0 | num > 200)
				{
					e.Cancel = true;
				}
				else
				{
					Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Repetidoras[3 + this.passo_202 * 12] = num;
				}
			}
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x003E9E94 File Offset: 0x003E8294
		private void Valor_end_rep_4_Validating(object sender, CancelEventArgs e)
		{
			checked
			{
				int num = (int)Math.Round(Conversion.Val(this.Valor_end_rep_4.Text));
				if (num < 0 | num > 200)
				{
					e.Cancel = true;
				}
				else
				{
					Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Repetidoras[4 + this.passo_202 * 12] = num;
				}
			}
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x003E9EF8 File Offset: 0x003E82F8
		private void Valor_end_rep_5_Validating(object sender, CancelEventArgs e)
		{
			checked
			{
				int num = (int)Math.Round(Conversion.Val(this.Valor_end_rep_5.Text));
				if (num < 0 | num > 200)
				{
					e.Cancel = true;
				}
				else
				{
					Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Repetidoras[5 + this.passo_202 * 12] = num;
				}
			}
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x003E9F5C File Offset: 0x003E835C
		private void Valor_end_rep_6_Validating(object sender, CancelEventArgs e)
		{
			checked
			{
				int num = (int)Math.Round(Conversion.Val(this.Valor_end_rep_6.Text));
				if (num < 0 | num > 200)
				{
					e.Cancel = true;
				}
				else
				{
					Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Repetidoras[6 + this.passo_202 * 12] = num;
				}
			}
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x003E9FC0 File Offset: 0x003E83C0
		private void Valor_end_rep_7_Validating(object sender, CancelEventArgs e)
		{
			checked
			{
				int num = (int)Math.Round(Conversion.Val(this.Valor_end_rep_7.Text));
				if (num < 0 | num > 200)
				{
					e.Cancel = true;
				}
				else
				{
					Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Repetidoras[7 + this.passo_202 * 12] = num;
				}
			}
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x003EA024 File Offset: 0x003E8424
		private void Valor_end_rep_8_Validating(object sender, CancelEventArgs e)
		{
			checked
			{
				int num = (int)Math.Round(Conversion.Val(this.Valor_end_rep_8.Text));
				if (num < 0 | num > 200)
				{
					e.Cancel = true;
				}
				else
				{
					Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Repetidoras[8 + this.passo_202 * 12] = num;
				}
			}
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x003EA088 File Offset: 0x003E8488
		private void Valor_end_rep_9_Validating(object sender, CancelEventArgs e)
		{
			checked
			{
				int num = (int)Math.Round(Conversion.Val(this.Valor_end_rep_9.Text));
				if (num < 0 | num > 200)
				{
					e.Cancel = true;
				}
				else
				{
					Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Repetidoras[9 + this.passo_202 * 12] = num;
				}
			}
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x003EA0EC File Offset: 0x003E84EC
		private void Valor_end_rep_10_Validating(object sender, CancelEventArgs e)
		{
			checked
			{
				int num = (int)Math.Round(Conversion.Val(this.Valor_end_rep_10.Text));
				if (num < 0 | num > 200)
				{
					e.Cancel = true;
				}
				else
				{
					Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Repetidoras[10 + this.passo_202 * 12] = num;
				}
			}
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x003EA150 File Offset: 0x003E8550
		private void Valor_end_rep_11_Validating(object sender, CancelEventArgs e)
		{
			checked
			{
				int num = (int)Math.Round(Conversion.Val(this.Valor_end_rep_11.Text));
				if (num < 0 | num > 200)
				{
					e.Cancel = true;
				}
				else
				{
					Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Repetidoras[11 + this.passo_202 * 12] = num;
				}
			}
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x003EA1B4 File Offset: 0x003E85B4
		private void Valor_end_rep_12_Validating(object sender, CancelEventArgs e)
		{
			checked
			{
				int num = (int)Math.Round(Conversion.Val(this.Valor_end_rep_12.Text));
				if (num < 0 | num > 200)
				{
					e.Cancel = true;
				}
				else
				{
					Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Repetidoras[12 + this.passo_202 * 12] = num;
				}
			}
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x003EA218 File Offset: 0x003E8618
		private void ComboBox_E01_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null), 0, false))
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Entrada_digital[1] = Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21904), 1));
			}
			else
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Entrada_digital[1] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x003EA2D0 File Offset: 0x003E86D0
		private void ComboBox_E02_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null), 0, false))
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Entrada_digital[2] = Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21904), 1));
			}
			else
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Entrada_digital[2] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x003EA388 File Offset: 0x003E8788
		private void ComboBox_E03_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null), 0, false))
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Entrada_digital[3] = Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21904), 1));
			}
			else
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Entrada_digital[3] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x003EA440 File Offset: 0x003E8840
		private void ComboBox_E04_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null), 0, false))
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Entrada_digital[4] = Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21904), 1));
			}
			else
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Entrada_digital[4] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x003EA4F8 File Offset: 0x003E88F8
		private void ComboBox_E05_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null), 0, false))
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Entrada_digital[5] = Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21904), 1));
			}
			else
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Entrada_digital[5] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x003EA5B0 File Offset: 0x003E89B0
		private void ComboBox_E06_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null), 0, false))
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Entrada_digital[6] = Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21904), 1));
			}
			else
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Entrada_digital[6] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x003EA668 File Offset: 0x003E8A68
		private void ComboBox_E07_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null), 0, false))
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Entrada_digital[7] = Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21904), 1));
			}
			else
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Entrada_digital[7] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x003EA720 File Offset: 0x003E8B20
		private void ComboBox_E08_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null), 0, false))
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Entrada_digital[8] = Conversions.ToInteger(Operators.SubtractObject(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21904), 1));
			}
			else
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Entrada_digital[8] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			}
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x003EA7D8 File Offset: 0x003E8BD8
		private void Equip_202_conf_Load(object sender, EventArgs e)
		{
			this.Combo_num_totalizacoes.Items.Clear();
			this.Combo_num_totalizacoes.Items.Add("Uma");
			this.Combo_num_totalizacoes.Items.Add("Cinco");
			this.Combo_modo_operacao.Items.Clear();
			this.Combo_modo_operacao.Items.Add("Manual");
			this.Combo_modo_operacao.Items.Add("Automático");
			this.Combo_modo_operacao.Items.Add("Timer");
			this.Combo_modo_partida_m1.Items.Clear();
			this.Combo_modo_partida_m1.Items.Add("Manual");
			this.Combo_modo_partida_m1.Items.Add("Automático");
			this.Combo_modo_partida_m2.Items.Clear();
			this.Combo_modo_partida_m2.Items.Add("Manual");
			this.Combo_modo_partida_m2.Items.Add("Automático");
			this.Combo_modo_partida_m3.Items.Clear();
			this.Combo_modo_partida_m3.Items.Add("Manual");
			this.Combo_modo_partida_m3.Items.Add("Automático");
			this.Combo_modo_partida_m4.Items.Clear();
			this.Combo_modo_partida_m4.Items.Add("Manual");
			this.Combo_modo_partida_m4.Items.Add("Automático");
			this.ComboBox_E01.Items.Clear();
			this.ComboBox_E01.Items.Add(" -------------");
			this.ComboBox_E01.Items.Add("Retorno motor 1");
			this.ComboBox_E01.Items.Add("Retorno motor 2");
			this.ComboBox_E01.Items.Add("Retorno motor 3");
			this.ComboBox_E01.Items.Add("Retorno motor 4");
			this.ComboBox_E01.Items.Add("Monitoração de arrombamento");
			this.ComboBox_E01.Items.Add("Monitoração falta de fase");
			this.ComboBox_E01.Items.Add("Monitoração de alagamento");
			this.ComboBox_E01.Items.Add("Retorno fechamento válvula 1");
			this.ComboBox_E01.Items.Add("Retorno fechamento válvula 2");
			this.ComboBox_E01.Items.Add("Retorno fechamento válvula 3");
			this.ComboBox_E01.Items.Add("Retorno fechamento válvula 4");
			this.ComboBox_E01.Items.Add("Retorno abertura válvula 1");
			this.ComboBox_E01.Items.Add("Retorno abertura válvula 2");
			this.ComboBox_E01.Items.Add("Retorno abertura válvula 3");
			this.ComboBox_E01.Items.Add("Retorno abertura válvula 4");
			this.ComboBox_E01.Items.Add("Monitoramento vazão");
			this.ComboBox_E02.Items.Clear();
			this.ComboBox_E02.Items.Add(" -------------");
			this.ComboBox_E02.Items.Add("Retorno motor 1");
			this.ComboBox_E02.Items.Add("Retorno motor 2");
			this.ComboBox_E02.Items.Add("Retorno motor 3");
			this.ComboBox_E02.Items.Add("Retorno motor 4");
			this.ComboBox_E02.Items.Add("Monitoração de arrombamento");
			this.ComboBox_E02.Items.Add("Monitoração falta de fase");
			this.ComboBox_E02.Items.Add("Monitoração de alagamento");
			this.ComboBox_E02.Items.Add("Retorno fechamento válvula 1");
			this.ComboBox_E02.Items.Add("Retorno fechamento válvula 2");
			this.ComboBox_E02.Items.Add("Retorno fechamento válvula 3");
			this.ComboBox_E02.Items.Add("Retorno fechamento válvula 4");
			this.ComboBox_E02.Items.Add("Retorno abertura válvula 1");
			this.ComboBox_E02.Items.Add("Retorno abertura válvula 2");
			this.ComboBox_E02.Items.Add("Retorno abertura válvula 3");
			this.ComboBox_E02.Items.Add("Retorno abertura válvula 4");
			this.ComboBox_E02.Items.Add("Monitoramento vazão");
			this.ComboBox_E03.Items.Clear();
			this.ComboBox_E03.Items.Add(" -------------");
			this.ComboBox_E03.Items.Add("Retorno motor 1");
			this.ComboBox_E03.Items.Add("Retorno motor 2");
			this.ComboBox_E03.Items.Add("Retorno motor 3");
			this.ComboBox_E03.Items.Add("Retorno motor 4");
			this.ComboBox_E03.Items.Add("Monitoração de arrombamento");
			this.ComboBox_E03.Items.Add("Monitoração falta de fase");
			this.ComboBox_E03.Items.Add("Monitoração de alagamento");
			this.ComboBox_E03.Items.Add("Retorno fechamento válvula 1");
			this.ComboBox_E03.Items.Add("Retorno fechamento válvula 2");
			this.ComboBox_E03.Items.Add("Retorno fechamento válvula 3");
			this.ComboBox_E03.Items.Add("Retorno fechamento válvula 4");
			this.ComboBox_E03.Items.Add("Retorno abertura válvula 1");
			this.ComboBox_E03.Items.Add("Retorno abertura válvula 2");
			this.ComboBox_E03.Items.Add("Retorno abertura válvula 3");
			this.ComboBox_E03.Items.Add("Retorno abertura válvula 4");
			this.ComboBox_E03.Items.Add("Monitoramento vazão");
			this.ComboBox_E04.Items.Clear();
			this.ComboBox_E04.Items.Add(" -------------");
			this.ComboBox_E04.Items.Add("Retorno motor 1");
			this.ComboBox_E04.Items.Add("Retorno motor 2");
			this.ComboBox_E04.Items.Add("Retorno motor 3");
			this.ComboBox_E04.Items.Add("Retorno motor 4");
			this.ComboBox_E04.Items.Add("Monitoração de arrombamento");
			this.ComboBox_E04.Items.Add("Monitoração falta de fase");
			this.ComboBox_E04.Items.Add("Monitoração de alagamento");
			this.ComboBox_E04.Items.Add("Retorno fechamento válvula 1");
			this.ComboBox_E04.Items.Add("Retorno fechamento válvula 2");
			this.ComboBox_E04.Items.Add("Retorno fechamento válvula 3");
			this.ComboBox_E04.Items.Add("Retorno fechamento válvula 4");
			this.ComboBox_E04.Items.Add("Retorno abertura válvula 1");
			this.ComboBox_E04.Items.Add("Retorno abertura válvula 2");
			this.ComboBox_E04.Items.Add("Retorno abertura válvula 3");
			this.ComboBox_E04.Items.Add("Retorno abertura válvula 4");
			this.ComboBox_E04.Items.Add("Monitoramento vazão");
			this.ComboBox_E05.Items.Clear();
			this.ComboBox_E05.Items.Add(" -------------");
			this.ComboBox_E05.Items.Add("Retorno motor 1");
			this.ComboBox_E05.Items.Add("Retorno motor 2");
			this.ComboBox_E05.Items.Add("Retorno motor 3");
			this.ComboBox_E05.Items.Add("Retorno motor 4");
			this.ComboBox_E05.Items.Add("Monitoração de arrombamento");
			this.ComboBox_E05.Items.Add("Monitoração falta de fase");
			this.ComboBox_E05.Items.Add("Monitoração de alagamento");
			this.ComboBox_E05.Items.Add("Retorno fechamento válvula 1");
			this.ComboBox_E05.Items.Add("Retorno fechamento válvula 2");
			this.ComboBox_E05.Items.Add("Retorno fechamento válvula 3");
			this.ComboBox_E05.Items.Add("Retorno fechamento válvula 4");
			this.ComboBox_E05.Items.Add("Retorno abertura válvula 1");
			this.ComboBox_E05.Items.Add("Retorno abertura válvula 2");
			this.ComboBox_E05.Items.Add("Retorno abertura válvula 3");
			this.ComboBox_E05.Items.Add("Retorno abertura válvula 4");
			this.ComboBox_E05.Items.Add("Monitoramento vazão");
			this.ComboBox_E06.Items.Clear();
			this.ComboBox_E06.Items.Add(" -------------");
			this.ComboBox_E06.Items.Add("Retorno motor 1");
			this.ComboBox_E06.Items.Add("Retorno motor 2");
			this.ComboBox_E06.Items.Add("Retorno motor 3");
			this.ComboBox_E06.Items.Add("Retorno motor 4");
			this.ComboBox_E06.Items.Add("Monitoração de arrombamento");
			this.ComboBox_E06.Items.Add("Monitoração falta de fase");
			this.ComboBox_E06.Items.Add("Monitoração de alagamento");
			this.ComboBox_E06.Items.Add("Retorno fechamento válvula 1");
			this.ComboBox_E06.Items.Add("Retorno fechamento válvula 2");
			this.ComboBox_E06.Items.Add("Retorno fechamento válvula 3");
			this.ComboBox_E06.Items.Add("Retorno fechamento válvula 4");
			this.ComboBox_E06.Items.Add("Retorno abertura válvula 1");
			this.ComboBox_E06.Items.Add("Retorno abertura válvula 2");
			this.ComboBox_E06.Items.Add("Retorno abertura válvula 3");
			this.ComboBox_E06.Items.Add("Retorno abertura válvula 4");
			this.ComboBox_E06.Items.Add("Monitoramento vazão");
			this.ComboBox_E07.Items.Clear();
			this.ComboBox_E07.Items.Add(" -------------");
			this.ComboBox_E07.Items.Add("Retorno motor 1");
			this.ComboBox_E07.Items.Add("Retorno motor 2");
			this.ComboBox_E07.Items.Add("Retorno motor 3");
			this.ComboBox_E07.Items.Add("Retorno motor 4");
			this.ComboBox_E07.Items.Add("Monitoração de arrombamento");
			this.ComboBox_E07.Items.Add("Monitoração falta de fase");
			this.ComboBox_E07.Items.Add("Monitoração de alagamento");
			this.ComboBox_E07.Items.Add("Retorno fechamento válvula 1");
			this.ComboBox_E07.Items.Add("Retorno fechamento válvula 2");
			this.ComboBox_E07.Items.Add("Retorno fechamento válvula 3");
			this.ComboBox_E07.Items.Add("Retorno fechamento válvula 4");
			this.ComboBox_E07.Items.Add("Retorno abertura válvula 1");
			this.ComboBox_E07.Items.Add("Retorno abertura válvula 2");
			this.ComboBox_E07.Items.Add("Retorno abertura válvula 3");
			this.ComboBox_E07.Items.Add("Retorno abertura válvula 4");
			this.ComboBox_E07.Items.Add("Monitoramento vazão");
			this.ComboBox_E08.Items.Clear();
			this.ComboBox_E08.Items.Add(" -------------");
			this.ComboBox_E08.Items.Add("Retorno motor 1");
			this.ComboBox_E08.Items.Add("Retorno motor 2");
			this.ComboBox_E08.Items.Add("Retorno motor 3");
			this.ComboBox_E08.Items.Add("Retorno motor 4");
			this.ComboBox_E08.Items.Add("Monitoração de arrombamento");
			this.ComboBox_E08.Items.Add("Monitoração falta de fase");
			this.ComboBox_E08.Items.Add("Monitoração de alagamento");
			this.ComboBox_E08.Items.Add("Retorno fechamento válvula 1");
			this.ComboBox_E08.Items.Add("Retorno fechamento válvula 2");
			this.ComboBox_E08.Items.Add("Retorno fechamento válvula 3");
			this.ComboBox_E08.Items.Add("Retorno fechamento válvula 4");
			this.ComboBox_E08.Items.Add("Retorno abertura válvula 1");
			this.ComboBox_E08.Items.Add("Retorno abertura válvula 2");
			this.ComboBox_E08.Items.Add("Retorno abertura válvula 3");
			this.ComboBox_E08.Items.Add("Retorno abertura válvula 4");
			this.ComboBox_E08.Items.Add("Monitoramento vazão");
			this.Combo_baudrate.Items.Clear();
			this.Combo_baudrate.Items.Add("1200");
			this.Combo_baudrate.Items.Add("9600");
			this.Combo_tipo_p1.Items.Clear();
			this.Combo_tipo_p1.Items.Add("----------------");
			this.Combo_tipo_p1.Items.Add("Vazões");
			this.Combo_tipo_p1.Items.Add("Med.Grand.Elét.-Smart Trans");
			this.Combo_tipo_p1.Items.Add("Med.Grand.Elét.-Mult K05");
			this.Combo_tipo_p1.Items.Add("Inversor Danfoss Agua Drive");
			this.Combo_tipo_p2.Items.Clear();
			this.Combo_tipo_p2.Items.Add("----------------");
			this.Combo_tipo_p2.Items.Add("Med.Grand.Elét.-Smart Trans");
			this.Combo_tipo_p2.Items.Add("Med.Grand.Elét.-Mult K05");
			this.Combo_tipo_p2.Items.Add("Inversor Danfoss Agua Drive");
			this.Combo_tipo_p3.Items.Clear();
			this.Combo_tipo_p3.Items.Add("----------------");
			this.Combo_tipo_p3.Items.Add("Med.Grand.Elét.-Smart Trans");
			this.Combo_tipo_p3.Items.Add("Med.Grand.Elét.-Mult K05");
			this.Combo_tipo_p3.Items.Add("Inversor Danfoss Agua Drive");
			this.Combo_tipo_p4.Items.Clear();
			this.Combo_tipo_p4.Items.Add("----------------");
			this.Combo_tipo_p4.Items.Add("Med.Grand.Elét.-Smart Trans");
			this.Combo_tipo_p4.Items.Add("Med.Grand.Elét.-Mult K05");
			this.Combo_tipo_p4.Items.Add("Inversor Danfoss Agua Drive");
			this.passo_202 = 0;
			string versao = Geral.Config_geral.Versao;
			if (Operators.CompareString(versao, "21", false) == 0)
			{
				this.Grupo_setpoints.Text = this.Grupo_setpoints.Text + " (0 - 100%)";
			}
			else if (Operators.CompareString(versao, "22", false) == 0)
			{
				this.Combo_modo_operacao.Items.Add("Automático s/desl.falha");
			}
			else if (Operators.CompareString(versao, "23", false) == 0)
			{
				this.Combo_modo_operacao.Items.Add("Automático s/desl.falha");
				this.Combo_modo_operacao.Items.Add("Manual s/desl.falha");
			}
			else if (Operators.CompareString(versao, "50", false) == 0)
			{
				this.Combo_modo_operacao.Items.Add("Automático s/desl.falha");
				this.Combo_modo_operacao.Items.Add("Manual s/desl.falha");
			}
			else if (Operators.CompareString(versao, "820_10", false) == 0)
			{
				this.Combo_modo_operacao.Items.Add("Automático s/desl.falha");
				this.Combo_modo_operacao.Items.Add("Manual s/desl.falha");
				this.Valor_nivel_desejado.Maximum = 4000m;
				this.Valor_nivel_liga_b1.Maximum = 4000m;
				this.Valor_nivel_liga_b2.Maximum = 4000m;
				this.Valor_nivel_liga_b3.Maximum = 4000m;
				this.Valor_nivel_liga_b4.Maximum = 4000m;
				this.Valor_pressao_min_recalque.Maximum = 4000m;
				this.Valor_pressao_min_succao.Maximum = 4000m;
				this.Valor_tempo_mais_bomba.Maximum = 4000m;
				this.Valor_nivel_bloqueio.Maximum = 4000m;
				this.Valor_nivel_liberacao.Maximum = 4000m;
				this.Grupo_perifericos.Enabled = true;
			}
			this.Init_equipamento_MD202();
			this.Limpa_estrutura_MD202(Mod_MD.Controle.Estacao);
			this.Atualiza_tela_MD202(Mod_MD.Controle.Estacao);
			Geral.Config_geral.Largura_tela_trabalho = this.Width;
			int num = 48;
			Interaction.MsgBox("Colocar o equipamento em modo de programação !\r\nFechar o jumper de configuração.", num, " Atenção - verifique a configuração");
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x003EB9E8 File Offset: 0x003E9DE8
		public void Limpa_estrutura_MD202(int indice)
		{
			Mod_MD.Recalque_202[indice].Repetidoras = new int[51];
			Mod_MD.Recalque_202[indice].Modo_partida = new int[5];
			Mod_MD.Recalque_202[indice].Tempo_partida = new int[5];
			Mod_MD.Recalque_202[indice].Tempo_parada = new int[5];
			Mod_MD.Recalque_202[indice].Tempo_abertura_val = new int[5];
			Mod_MD.Recalque_202[indice].Tempo_fechamento_val = new int[5];
			Mod_MD.Recalque_202[indice].Entrada_digital = new int[9];
			Mod_MD.Recalque_202[indice].End_estacao = 0;
			Mod_MD.Recalque_202[indice].End_mestre = 0;
			Mod_MD.Recalque_202[indice].Hab_repetidora = 0;
			Mod_MD.Recalque_202[indice].Tempo_ptt = 1;
			Mod_MD.Recalque_202[indice].BaudRate = 21849;
			Mod_MD.Recalque_202[indice].Intervalo_filtroAD = 1;
			Mod_MD.Recalque_202[indice].Tamanho_filtroAD = 1;
			Mod_MD.Recalque_202[indice].Modo_operacao = 21888;
			Mod_MD.Recalque_202[indice].Numero_motores = 0;
			Mod_MD.Recalque_202[indice].Numero_valvulas = 0;
			int num = 1;
			checked
			{
				do
				{
					Mod_MD.Recalque_202[indice].Modo_partida[num] = 21877;
					Mod_MD.Recalque_202[indice].Tempo_partida[num] = 180;
					Mod_MD.Recalque_202[indice].Tempo_parada[num] = 180;
					Mod_MD.Recalque_202[indice].Tempo_abertura_val[num] = 180;
					Mod_MD.Recalque_202[indice].Tempo_fechamento_val[num] = 180;
					num++;
				}
				while (num <= 4);
				num = 1;
				do
				{
					Mod_MD.Recalque_202[indice].Entrada_digital[num] = 0;
					num++;
				}
				while (num <= 8);
				Mod_MD.Recalque_202[indice].Set_nivel_desejado = 100;
				Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba1 = 1;
				Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba2 = 1;
				Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba3 = 1;
				Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba4 = 1;
				Mod_MD.Recalque_202[indice].Tempo_mais_bomba = 0;
				Mod_MD.Recalque_202[indice].Pressao_min_succao = 5;
				Mod_MD.Recalque_202[indice].Pressao_min_recalque = 5;
				Mod_MD.Recalque_202[indice].Nivel_protecao_liga = 40;
				Mod_MD.Recalque_202[indice].Nivel_protecao_desliga = 20;
				Mod_MD.Recalque_202[indice].Num_bombas_simultaneas = 0;
				Mod_MD.Recalque_202[indice].Tempo_entre_acionamento = 0;
				Mod_MD.Recalque_202[indice].Num_totalizacoes = 1;
				Mod_MD.Recalque_202[indice].Controle_nivel_fonte = 21921;
				Mod_MD.Recalque_202[indice].End_repetidora = 0;
				Mod_MD.Recalque_202[indice].Num_repetidoras = 0;
				num = 0;
				do
				{
					Mod_MD.Recalque_202[indice].Repetidoras[num] = 0;
					num++;
				}
				while (num <= 50);
			}
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x003EBD18 File Offset: 0x003EA118
		public void Init_equipamento_MD202()
		{
			Mod_MD.Controle.Estacao = 1;
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x003EBD28 File Offset: 0x003EA128
		public void Atualiza_tela_MD202(int indice)
		{
			checked
			{
				int num;
				int num2;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					this.Atualiza_tela_MD202_repetidora(indice);
					this.Atualiza_tela_MD202_motores(indice);
					this.Atualiza_tela_MD202_valvulas(indice);
					this.Valor_end_est.Value = new decimal(Mod_MD.Recalque_202[indice].End_estacao);
					this.Valor_end_mestre.Value = new decimal(Mod_MD.Recalque_202[indice].End_mestre);
					this.Valor_end_rep.Value = new decimal(Mod_MD.Recalque_202[indice].End_repetidora);
					this.Valor_num_est_rep.Value = new decimal(Mod_MD.Recalque_202[indice].Num_repetidoras);
					this.Valor_temp_ptt.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_ptt * 10);
					this.Numero_motores.Value = new decimal(Mod_MD.Recalque_202[indice].Numero_motores);
					this.Combo_modo_partida_m1.SelectedIndex = Mod_MD.Recalque_202[indice].Modo_partida[1] - 21877;
					this.Combo_modo_partida_m2.SelectedIndex = Mod_MD.Recalque_202[indice].Modo_partida[2] - 21877;
					this.Combo_modo_partida_m3.SelectedIndex = Mod_MD.Recalque_202[indice].Modo_partida[3] - 21877;
					this.Combo_modo_partida_m4.SelectedIndex = Mod_MD.Recalque_202[indice].Modo_partida[4] - 21877;
					this.Combo_baudrate.SelectedIndex = Mod_MD.Recalque_202[indice].BaudRate - 21849;
					this.Valor_intervalo_filtro_AD.Value = new decimal(Mod_MD.Recalque_202[indice].Intervalo_filtroAD * 10);
					this.Valor_tamanho_filtro_AD.Value = new decimal(Mod_MD.Recalque_202[indice].Tamanho_filtroAD);
					this.Valor_nivel_desejado.Value = new decimal(Mod_MD.Recalque_202[indice].Set_nivel_desejado);
					this.Valor_nivel_liga_b1.Value = new decimal(Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba1);
					this.Valor_nivel_liga_b2.Value = new decimal(Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba2);
					this.Valor_nivel_liga_b3.Value = new decimal(Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba3);
					this.Valor_nivel_liga_b4.Value = new decimal(Mod_MD.Recalque_202[indice].Set_nivel_liga_bomba4);
					this.Valor_tempo_mais_bomba.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_mais_bomba);
					this.Valor_pressao_min_succao.Value = new decimal(Mod_MD.Recalque_202[indice].Pressao_min_succao);
					this.Valor_pressao_min_recalque.Value = new decimal(Mod_MD.Recalque_202[indice].Pressao_min_recalque);
					this.Valor_nivel_bloqueio.Value = new decimal(Mod_MD.Recalque_202[indice].Nivel_protecao_desliga);
					this.Valor_nivel_liberacao.Value = new decimal(Mod_MD.Recalque_202[indice].Nivel_protecao_liga);
					this.Tempo_entre_acionamentos.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_entre_acionamento);
					this.Tempo_partida_m1.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_partida[1]);
					this.Tempo_partida_m2.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_partida[2]);
					this.Tempo_partida_m3.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_partida[3]);
					this.Tempo_partida_m4.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_partida[4]);
					this.Tempo_parada_m1.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_parada[1]);
					this.Tempo_parada_m2.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_parada[2]);
					this.Tempo_parada_m3.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_parada[3]);
					this.Tempo_parada_m4.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_parada[4]);
					this.Tempo_abertura_v1.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_abertura_val[1]);
					this.Tempo_abertura_v2.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_abertura_val[2]);
					this.Tempo_abertura_v3.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_abertura_val[3]);
					this.Tempo_abertura_v4.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_abertura_val[4]);
					this.Tempo_fechamento_v1.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_fechamento_val[1]);
					this.Tempo_fechamento_v2.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_fechamento_val[2]);
					this.Tempo_fechamento_v3.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_fechamento_val[3]);
					this.Tempo_fechamento_v4.Value = new decimal(Mod_MD.Recalque_202[indice].Tempo_fechamento_val[4]);
					this.Combo_modo_operacao.SelectedIndex = Conversions.ToInteger(Operators.SubtractObject(Mod_MD.Recalque_202[indice].Modo_operacao, 21888));
					this.Numero_valvulas.Value = new decimal(Mod_MD.Recalque_202[indice].Numero_valvulas);
					this.Valor_num_bomba_simultaneas.Value = new decimal(Mod_MD.Recalque_202[indice].Num_bombas_simultaneas);
					this.Combo_baudrate.SelectedIndex = Mod_MD.Recalque_202[indice].BaudRate - 21849;
					if (Mod_MD.Recalque_202[indice].Entrada_digital[1] >= 21904)
					{
						this.ComboBox_E01.SelectedIndex = Mod_MD.Recalque_202[indice].Entrada_digital[1] - 21904 + 1;
					}
					else
					{
						this.ComboBox_E01.SelectedIndex = 0;
					}
					if (Mod_MD.Recalque_202[indice].Entrada_digital[2] >= 21904)
					{
						this.ComboBox_E02.SelectedIndex = Mod_MD.Recalque_202[indice].Entrada_digital[2] - 21904 + 1;
					}
					else
					{
						this.ComboBox_E02.SelectedIndex = 0;
					}
					if (Mod_MD.Recalque_202[indice].Entrada_digital[3] >= 21904)
					{
						this.ComboBox_E03.SelectedIndex = Mod_MD.Recalque_202[indice].Entrada_digital[3] - 21904 + 1;
					}
					else
					{
						this.ComboBox_E03.SelectedIndex = 0;
					}
					if (Mod_MD.Recalque_202[indice].Entrada_digital[4] >= 21904)
					{
						this.ComboBox_E04.SelectedIndex = Mod_MD.Recalque_202[indice].Entrada_digital[4] - 21904 + 1;
					}
					else
					{
						this.ComboBox_E04.SelectedIndex = 0;
					}
					if (Mod_MD.Recalque_202[indice].Entrada_digital[5] >= 21904)
					{
						this.ComboBox_E05.SelectedIndex = Mod_MD.Recalque_202[indice].Entrada_digital[5] - 21904 + 1;
					}
					else
					{
						this.ComboBox_E05.SelectedIndex = 0;
					}
					if (Mod_MD.Recalque_202[indice].Entrada_digital[6] >= 21904)
					{
						this.ComboBox_E06.SelectedIndex = Mod_MD.Recalque_202[indice].Entrada_digital[6] - 21904 + 1;
					}
					else
					{
						this.ComboBox_E06.SelectedIndex = 0;
					}
					if (Mod_MD.Recalque_202[indice].Entrada_digital[7] >= 21904)
					{
						this.ComboBox_E07.SelectedIndex = Mod_MD.Recalque_202[indice].Entrada_digital[7] - 21904 + 1;
					}
					else
					{
						this.ComboBox_E07.SelectedIndex = 0;
					}
					if (Mod_MD.Recalque_202[indice].Entrada_digital[8] >= 21904)
					{
						this.ComboBox_E08.SelectedIndex = Mod_MD.Recalque_202[indice].Entrada_digital[8] - 21904 + 1;
					}
					else
					{
						this.ComboBox_E08.SelectedIndex = 0;
					}
					if (Mod_MD.Recalque_202[indice].Num_totalizacoes == 1)
					{
						this.Combo_num_totalizacoes.SelectedIndex = 0;
					}
					else
					{
						this.Combo_num_totalizacoes.SelectedIndex = 1;
					}
					if (Mod_MD.Recalque_202[indice].Controle_nivel_fonte == 21921)
					{
						this.CheckBox_ctrl_nivel_fonte.Checked = true;
					}
					else
					{
						this.CheckBox_ctrl_nivel_fonte.Checked = false;
					}
					this.Combo_tipo_p1.SelectedIndex = Mod_MD.Recalque_202[indice].Periferico_Tipo_1;
					this.Combo_tipo_p2.SelectedIndex = Mod_MD.Recalque_202[indice].Periferico_Tipo_2;
					this.Combo_tipo_p3.SelectedIndex = Mod_MD.Recalque_202[indice].Periferico_Tipo_3;
					this.Combo_tipo_p4.SelectedIndex = Mod_MD.Recalque_202[indice].Periferico_Tipo_4;
					this.Endereco_p1.Value = new decimal(Mod_MD.Recalque_202[indice].Periferico_End_1);
					this.Endereco_p2.Value = new decimal(Mod_MD.Recalque_202[indice].Periferico_End_2);
					this.Endereco_p3.Value = new decimal(Mod_MD.Recalque_202[indice].Periferico_End_3);
					this.Endereco_p4.Value = new decimal(Mod_MD.Recalque_202[indice].Periferico_End_4);
					goto IL_9F1;
					IL_98B:
					this.Init_equipamento_MD202();
					this.Limpa_estrutura_MD202(Mod_MD.Controle.Estacao);
					Interaction.MsgBox("Dados de configuração não compatíveis com a tela", 1, null);
					goto IL_9F1;
					IL_9B0:
					num2 = -1;
					throw new InvalidOperationException("Decompiler switch pattern not reconstructed.");
					IL_9C4:;
				}
				catch (Exception)
			{
				throw;
			}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_9F1:
				if (num2 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x003EC74C File Offset: 0x003EAB4C
		public void Atualiza_tela_MD202_repetidora(int indice)
		{
			if (Mod_MD.Recalque_202[indice].Hab_repetidora == 21856)
			{
				this.CheckBox_hab_rep.Checked = true;
				this.Grupo_end_rep.Enabled = true;
				this.Valor_end_rep.Enabled = true;
				this.Label_end_rep.Enabled = true;
				this.Valor_num_est_rep.Enabled = true;
				this.Label_num_est_rep.Enabled = true;
			}
			else
			{
				this.CheckBox_hab_rep.Checked = false;
				this.Grupo_end_rep.Enabled = false;
				this.Valor_end_rep.Enabled = false;
				this.Label_end_rep.Enabled = false;
				this.Valor_num_est_rep.Enabled = false;
				this.Label_num_est_rep.Enabled = false;
			}
			this.Atualiza_tela_MD202_repetidora_enderecos(indice);
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x003EC80C File Offset: 0x003EAC0C
		public void Limpa_dados_repetidora_MD202(object indice, object end_inicial)
		{
			checked
			{
				for (int i = Conversions.ToInteger(Operators.AddObject(end_inicial, 1)); i <= 50; i++)
				{
					Mod_MD.Recalque_202[Conversions.ToInteger(indice)].Repetidoras[i] = 0;
				}
			}
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x003EC850 File Offset: 0x003EAC50
		public void Atualiza_tela_MD202_repetidora_enderecos(int indice)
		{
			Mod_MD.Recalque_201[indice].Repetidoras = new int[51];
			checked
			{
				if (this.passo_202 < 4)
				{
					this.Valor_end_rep_3.Text = Conversions.ToString(Mod_MD.Recalque_202[indice].Repetidoras[3 + this.passo_202 * 12]);
					this.Valor_end_rep_4.Text = Conversions.ToString(Mod_MD.Recalque_202[indice].Repetidoras[4 + this.passo_202 * 12]);
					this.Valor_end_rep_5.Text = Conversions.ToString(Mod_MD.Recalque_202[indice].Repetidoras[5 + this.passo_202 * 12]);
					this.Valor_end_rep_6.Text = Conversions.ToString(Mod_MD.Recalque_202[indice].Repetidoras[6 + this.passo_202 * 12]);
					this.Valor_end_rep_7.Text = Conversions.ToString(Mod_MD.Recalque_202[indice].Repetidoras[7 + this.passo_202 * 12]);
					this.Valor_end_rep_8.Text = Conversions.ToString(Mod_MD.Recalque_202[indice].Repetidoras[8 + this.passo_202 * 12]);
					this.Valor_end_rep_9.Text = Conversions.ToString(Mod_MD.Recalque_202[indice].Repetidoras[9 + this.passo_202 * 12]);
					this.Valor_end_rep_10.Text = Conversions.ToString(Mod_MD.Recalque_202[indice].Repetidoras[10 + this.passo_202 * 12]);
					this.Valor_end_rep_11.Text = Conversions.ToString(Mod_MD.Recalque_202[indice].Repetidoras[11 + this.passo_202 * 12]);
					this.Valor_end_rep_12.Text = Conversions.ToString(Mod_MD.Recalque_202[indice].Repetidoras[12 + this.passo_202 * 12]);
				}
				this.Valor_end_rep_1.Text = Conversions.ToString(Mod_MD.Recalque_202[indice].Repetidoras[1 + this.passo_202 * 12]);
				this.Valor_end_rep_2.Text = Conversions.ToString(Mod_MD.Recalque_202[indice].Repetidoras[2 + this.passo_202 * 12]);
				this.Label_end_rep_1.Text = Strings.Format(1 + this.passo_202 * 12, "00:");
				this.Label_end_rep_2.Text = Strings.Format(2 + this.passo_202 * 12, "00:");
				this.Label_end_rep_3.Text = Strings.Format(3 + this.passo_202 * 12, "00:");
				this.Label_end_rep_4.Text = Strings.Format(4 + this.passo_202 * 12, "00:");
				this.Label_end_rep_5.Text = Strings.Format(5 + this.passo_202 * 12, "00:");
				this.Label_end_rep_6.Text = Strings.Format(6 + this.passo_202 * 12, "00:");
				this.Label_end_rep_7.Text = Strings.Format(7 + this.passo_202 * 12, "00:");
				this.Label_end_rep_8.Text = Strings.Format(8 + this.passo_202 * 12, "00:");
				this.Label_end_rep_9.Text = Strings.Format(9 + this.passo_202 * 12, "00:");
				this.Label_end_rep_10.Text = Strings.Format(10 + this.passo_202 * 12, "00:");
				this.Label_end_rep_11.Text = Strings.Format(11 + this.passo_202 * 12, "00:");
				this.Label_end_rep_12.Text = Strings.Format(12 + this.passo_202 * 12, "00:");
				int num_repetidoras = Mod_MD.Recalque_202[indice].Num_repetidoras;
				if (num_repetidoras - this.passo_202 * 12 - 0 > 0)
				{
					this.Label_end_rep_1.Visible = true;
					this.Valor_end_rep_1.Visible = true;
				}
				else
				{
					this.Label_end_rep_1.Visible = false;
					this.Valor_end_rep_1.Visible = false;
				}
				if (num_repetidoras - this.passo_202 * 12 - 1 > 0)
				{
					this.Label_end_rep_2.Visible = true;
					this.Valor_end_rep_2.Visible = true;
				}
				else
				{
					this.Label_end_rep_2.Visible = false;
					this.Valor_end_rep_2.Visible = false;
				}
				if (num_repetidoras - this.passo_202 * 12 - 2 > 0)
				{
					this.Label_end_rep_3.Visible = true;
					this.Valor_end_rep_3.Visible = true;
				}
				else
				{
					this.Label_end_rep_3.Visible = false;
					this.Valor_end_rep_3.Visible = false;
				}
				if (num_repetidoras - this.passo_202 * 12 - 3 > 0)
				{
					this.Label_end_rep_4.Visible = true;
					this.Valor_end_rep_4.Visible = true;
				}
				else
				{
					this.Label_end_rep_4.Visible = false;
					this.Valor_end_rep_4.Visible = false;
				}
				if (num_repetidoras - this.passo_202 * 12 - 4 > 0)
				{
					this.Label_end_rep_5.Visible = true;
					this.Valor_end_rep_5.Visible = true;
				}
				else
				{
					this.Label_end_rep_5.Visible = false;
					this.Valor_end_rep_5.Visible = false;
				}
				if (num_repetidoras - this.passo_202 * 12 - 5 > 0)
				{
					this.Label_end_rep_6.Visible = true;
					this.Valor_end_rep_6.Visible = true;
				}
				else
				{
					this.Label_end_rep_6.Visible = false;
					this.Valor_end_rep_6.Visible = false;
				}
				if (num_repetidoras - this.passo_202 * 12 - 6 > 0)
				{
					this.Label_end_rep_7.Visible = true;
					this.Valor_end_rep_7.Visible = true;
				}
				else
				{
					this.Label_end_rep_7.Visible = false;
					this.Valor_end_rep_7.Visible = false;
				}
				if (num_repetidoras - this.passo_202 * 12 - 7 > 0)
				{
					this.Label_end_rep_8.Visible = true;
					this.Valor_end_rep_8.Visible = true;
				}
				else
				{
					this.Label_end_rep_8.Visible = false;
					this.Valor_end_rep_8.Visible = false;
				}
				if (num_repetidoras - this.passo_202 * 12 - 8 > 0)
				{
					this.Label_end_rep_9.Visible = true;
					this.Valor_end_rep_9.Visible = true;
				}
				else
				{
					this.Label_end_rep_9.Visible = false;
					this.Valor_end_rep_9.Visible = false;
				}
				if (num_repetidoras - this.passo_202 * 12 - 9 > 0)
				{
					this.Label_end_rep_10.Visible = true;
					this.Valor_end_rep_10.Visible = true;
				}
				else
				{
					this.Label_end_rep_10.Visible = false;
					this.Valor_end_rep_10.Visible = false;
				}
				if (num_repetidoras - this.passo_202 * 12 - 10 > 0)
				{
					this.Label_end_rep_11.Visible = true;
					this.Valor_end_rep_11.Visible = true;
				}
				else
				{
					this.Label_end_rep_11.Visible = false;
					this.Valor_end_rep_11.Visible = false;
				}
				if (num_repetidoras - this.passo_202 * 12 - 11 > 0)
				{
					this.Label_end_rep_12.Visible = true;
					this.Valor_end_rep_12.Visible = true;
				}
				else
				{
					this.Label_end_rep_12.Visible = false;
					this.Valor_end_rep_12.Visible = false;
				}
			}
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x003ECF80 File Offset: 0x003EB380
		public void Atualiza_tela_MD202_motores(int indice)
		{
			this.Combo_modo_partida_m1.Enabled = false;
			this.Combo_modo_partida_m2.Enabled = false;
			this.Combo_modo_partida_m3.Enabled = false;
			this.Combo_modo_partida_m4.Enabled = false;
			this.Tempo_parada_m1.Enabled = false;
			this.Tempo_parada_m2.Enabled = false;
			this.Tempo_parada_m3.Enabled = false;
			this.Tempo_parada_m4.Enabled = false;
			this.Tempo_partida_m1.Enabled = false;
			this.Tempo_partida_m2.Enabled = false;
			this.Tempo_partida_m3.Enabled = false;
			this.Tempo_partida_m4.Enabled = false;
			if (Mod_MD.Recalque_202[indice].Numero_motores >= 1)
			{
				if (Operators.ConditionalCompareObjectNotEqual(Mod_MD.Recalque_202[indice].Modo_operacao, 21888, false))
				{
					this.Combo_modo_partida_m1.Enabled = true;
				}
				this.Tempo_parada_m1.Enabled = true;
				this.Tempo_partida_m1.Enabled = true;
			}
			if (Mod_MD.Recalque_202[indice].Numero_motores >= 2)
			{
				if (Operators.ConditionalCompareObjectNotEqual(Mod_MD.Recalque_202[indice].Modo_operacao, 21888, false))
				{
					this.Combo_modo_partida_m2.Enabled = true;
				}
				this.Tempo_parada_m2.Enabled = true;
				this.Tempo_partida_m2.Enabled = true;
			}
			if (Mod_MD.Recalque_202[indice].Numero_motores >= 3)
			{
				if (Operators.ConditionalCompareObjectNotEqual(Mod_MD.Recalque_202[indice].Modo_operacao, 21888, false))
				{
					this.Combo_modo_partida_m3.Enabled = true;
				}
				this.Tempo_parada_m3.Enabled = true;
				this.Tempo_partida_m3.Enabled = true;
			}
			if (Mod_MD.Recalque_202[indice].Numero_motores == 4)
			{
				if (Operators.ConditionalCompareObjectNotEqual(Mod_MD.Recalque_202[indice].Modo_operacao, 21888, false))
				{
					this.Combo_modo_partida_m4.Enabled = true;
				}
				this.Tempo_parada_m4.Enabled = true;
				this.Tempo_partida_m4.Enabled = true;
			}
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x003ED184 File Offset: 0x003EB584
		public void Atualiza_tela_MD202_valvulas(int indice)
		{
			this.Tempo_abertura_v1.Enabled = false;
			this.Tempo_abertura_v2.Enabled = false;
			this.Tempo_abertura_v3.Enabled = false;
			this.Tempo_abertura_v4.Enabled = false;
			this.Tempo_fechamento_v1.Enabled = false;
			this.Tempo_fechamento_v2.Enabled = false;
			this.Tempo_fechamento_v3.Enabled = false;
			this.Tempo_fechamento_v4.Enabled = false;
			if (Mod_MD.Recalque_202[indice].Numero_valvulas >= 1)
			{
				this.Tempo_abertura_v1.Enabled = true;
				this.Tempo_fechamento_v1.Enabled = true;
			}
			if (Mod_MD.Recalque_202[indice].Numero_valvulas >= 2)
			{
				this.Tempo_abertura_v2.Enabled = true;
				this.Tempo_fechamento_v2.Enabled = true;
			}
			if (Mod_MD.Recalque_202[indice].Numero_valvulas >= 3)
			{
				this.Tempo_abertura_v3.Enabled = true;
				this.Tempo_fechamento_v3.Enabled = true;
			}
			if (Mod_MD.Recalque_202[indice].Numero_valvulas == 4)
			{
				this.Tempo_abertura_v4.Enabled = true;
				this.Tempo_fechamento_v4.Enabled = true;
			}
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x003ED2A0 File Offset: 0x003EB6A0
		private void Ler_conf_md_202_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", 0, null);
				return;
			}
			this.Controle_tecla_conf_202(2);
			this.Mensagem_MD202("Aguarde ...", 2);
			string versao = Geral.Config_geral.Versao;
			int tamanho;
			if (Operators.CompareString(versao, "820_10", false) == 0)
			{
				tamanho = 56;
			}
			else
			{
				tamanho = 52;
			}
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Leitura_pagina(100, 255, tamanho);
			this.Mensagem_MD202(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_202(1);
				return;
			}
			Mod_MD.Atualiza_dados_MD202(Mod_MD.Controle.Estacao, 100);
			ctrl_RESP_ = Mod_MD.Leitura_pagina(512, Mod_MD.Recalque_202[1].End_estacao, 52);
			this.Mensagem_MD202(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_202(1);
				return;
			}
			Mod_MD.Atualiza_dados_MD202(Mod_MD.Controle.Estacao, 512);
			this.Mensagem_MD202("Leitura executada com sucesso", 0);
			this.Atualiza_tela_MD202(Mod_MD.Controle.Estacao);
			this.Controle_tecla_conf_202(1);
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x003ED3BC File Offset: 0x003EB7BC
		public void Controle_tecla_conf_202(int operacao)
		{
			switch (operacao)
			{
			case 1:
				this.Ler_conf_md_202.Enabled = true;
				this.Esc_conf_md_202.Enabled = true;
				break;
			case 2:
				this.Ler_conf_md_202.Enabled = false;
				this.Esc_conf_md_202.Enabled = false;
				break;
			}
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x003ED410 File Offset: 0x003EB810
		public void Mensagem_MD202(string msg, int cor)
		{
			switch (cor)
			{
			case 0:
				this.Box_Msg.ForeColor = Color.Blue;
				break;
			case 1:
				this.Box_Msg.ForeColor = Color.Red;
				break;
			case 2:
				this.Box_Msg.ForeColor = Color.Black;
				break;
			}
			this.Box_Msg.Text = msg;
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x003ED474 File Offset: 0x003EB874
		private void Esc_conf_md_202_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", 0, null);
				return;
			}
			this.Controle_tecla_conf_202(2);
			this.Mensagem_MD202("Aguarde ...", 2);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD202(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_202(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(100, 3);
			this.Mensagem_MD202(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_202(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD202(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_202(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD202(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_202(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(512, 3);
			this.Mensagem_MD202(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_202(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD202(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_202(1);
				return;
			}
			this.Mensagem_MD202("Programação concluída com sucesso", 0);
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x003ED5DC File Offset: 0x003EB9DC
		private void Combo_baudrate_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].BaudRate = Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21849));
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x003ED62C File Offset: 0x003EBA2C
		private void Combo_modo_operacao_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Modo_operacao = Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21888);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null), 0, false))
			{
				this.Combo_modo_partida_m1.SelectedIndex = 0;
				this.Combo_modo_partida_m2.SelectedIndex = 0;
				this.Combo_modo_partida_m3.SelectedIndex = 0;
				this.Combo_modo_partida_m4.SelectedIndex = 0;
				this.Combo_modo_partida_m1.Enabled = false;
				this.Combo_modo_partida_m2.Enabled = false;
				this.Combo_modo_partida_m3.Enabled = false;
				this.Combo_modo_partida_m4.Enabled = false;
			}
			this.Atualiza_tela_MD202_motores(Mod_MD.Controle.Estacao);
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x003ED70C File Offset: 0x003EBB0C
		private void Combo_modo_partida_m1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Modo_partida[1] = Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21877));
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x003ED760 File Offset: 0x003EBB60
		private void Tempo_abertura_v1_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_abertura_val[1] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x003ED7A4 File Offset: 0x003EBBA4
		private void Tempo_abertura_v2_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_abertura_val[2] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x003ED7E8 File Offset: 0x003EBBE8
		private void Tempo_abertura_v3_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_abertura_val[3] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x003ED82C File Offset: 0x003EBC2C
		private void Tempo_abertura_v4_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_abertura_val[4] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x003ED870 File Offset: 0x003EBC70
		private void Tempo_fechamento_v1_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_fechamento_val[1] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x003ED8B4 File Offset: 0x003EBCB4
		private void Tempo_fechamento_v2_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_fechamento_val[2] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x003ED8F8 File Offset: 0x003EBCF8
		private void Tempo_fechamento_v3_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_fechamento_val[3] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x003ED93C File Offset: 0x003EBD3C
		private void Tempo_fechamento_v4_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Tempo_fechamento_val[4] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x003ED980 File Offset: 0x003EBD80
		private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
			this.passo_202 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			this.Atualiza_tela_MD202_repetidora_enderecos(Mod_MD.Controle.Estacao);
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x003ED9B4 File Offset: 0x003EBDB4
		private void Combo_num_totalizacoes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 0, false))
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Num_totalizacoes = 1;
			}
			else
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Num_totalizacoes = 5;
			}
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x003EDA1C File Offset: 0x003EBE1C
		private void CheckBox_ctrl_nivel_fonte_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null), true, false))
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Controle_nivel_fonte = 21921;
			}
			else
			{
				Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Controle_nivel_fonte = 0;
			}
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x003EDA88 File Offset: 0x003EBE88
		private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Limpa_estrutura_MD202(Mod_MD.Controle.Estacao);
			this.Atualiza_tela_MD202(Mod_MD.Controle.Estacao);
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x003EDAAC File Offset: 0x003EBEAC
		[MethodImpl(72)]
		private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.OpenFileDialog1.Filter = "Arquivo de configuração de equipamento|*.V202";
			this.OpenFileDialog1.InitialDirectory = "c:\\";
			if (this.OpenFileDialog1.ShowDialog() == 1)
			{
				if (Operators.CompareString(this.OpenFileDialog1.FileName, "", false) != 0)
				{
					FileSystem.FileOpen(1, this.OpenFileDialog1.FileName, 4, -1, -1, 600);
					int num = 1;
					Mod_MD.DADOS_EQUIP_MD_202_CONFIG[] recalque_ = Mod_MD.Recalque_202;
					Mod_MD.DADOS_EQUIP_MD_202_CONFIG[] array = recalque_;
					int num2 = 1;
					ValueType valueType = array[num2];
					FileSystem.FileGet(num, ref valueType, -1L);
					Mod_MD.DADOS_EQUIP_MD_202_CONFIG[] array2 = recalque_;
					int num3 = num2;
					ValueType valueType2 = valueType;
					Mod_MD.DADOS_EQUIP_MD_202_CONFIG dados_EQUIP_MD_202_CONFIG;
					array2[num3] = ((valueType2 != null) ? ((Mod_MD.DADOS_EQUIP_MD_202_CONFIG)valueType2) : dados_EQUIP_MD_202_CONFIG);
					FileSystem.FileClose(new int[]
					{
						1
					});
				}
				if (Operators.CompareString(Mod_MD.Recalque_202[1].Versao, Geral.Config_geral.Versao, false) == 0)
				{
					this.Atualiza_tela_MD202(Mod_MD.Controle.Estacao);
				}
				else
				{
					this.Init_equipamento_MD202();
					this.Limpa_estrutura_MD202(Mod_MD.Controle.Estacao);
					Interaction.MsgBox("Versão do equipamento não é compatível\r\ncom os dados do arquivo", 1, null);
				}
			}
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x003EDBCC File Offset: 0x003EBFCC
		[MethodImpl(72)]
		private void SalvarToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[1].Versao = Geral.Config_geral.Versao;
			this.SaveFileDialog1.Filter = "Arquivo de configuração de equipamento|*.V202";
			this.SaveFileDialog1.InitialDirectory = "c:\\";
			if (this.SaveFileDialog1.ShowDialog() == 1 && Operators.CompareString(this.SaveFileDialog1.FileName, "", false) != 0)
			{
				FileSystem.FileOpen(1, this.SaveFileDialog1.FileName, 4, -1, -1, 600);
				FileSystem.FilePut(1, Mod_MD.Recalque_202[1], -1L);
				FileSystem.FileClose(new int[]
				{
					1
				});
			}
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x003EDC84 File Offset: 0x003EC084
		private void Combo_tipo_p1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Periferico_Tipo_1 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x003EDCBC File Offset: 0x003EC0BC
		private void Combo_tipo_p2_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Periferico_Tipo_2 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x003EDCF4 File Offset: 0x003EC0F4
		private void Combo_tipo_p3_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Periferico_Tipo_3 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x003EDD2C File Offset: 0x003EC12C
		private void Combo_tipo_p4_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Periferico_Tipo_4 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x003EDD64 File Offset: 0x003EC164
		private void Endereco_p1_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Periferico_End_1 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x003EDD9C File Offset: 0x003EC19C
		private void Endereco_p2_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Periferico_End_2 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x003EDDD4 File Offset: 0x003EC1D4
		private void Endereco_p3_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Periferico_End_3 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x003EDE0C File Offset: 0x003EC20C
		private void Endereco_p4_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_202[Mod_MD.Controle.Estacao].Periferico_End_4 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x04001672 RID: 5746
		[AccessedThroughProperty("Grupo_ctrl")]
		private GroupBox _Grupo_ctrl;

		// Token: 0x04001673 RID: 5747
		[AccessedThroughProperty("Esc_conf_md_202")]
		private Button _Esc_conf_md_202;

		// Token: 0x04001674 RID: 5748
		[AccessedThroughProperty("Box_Msg")]
		private TextBox _Box_Msg;

		// Token: 0x04001675 RID: 5749
		[AccessedThroughProperty("Ler_conf_md_202")]
		private Button _Ler_conf_md_202;

		// Token: 0x04001676 RID: 5750
		[AccessedThroughProperty("Grupo_motores_valvulas")]
		private GroupBox _Grupo_motores_valvulas;

		// Token: 0x04001677 RID: 5751
		[AccessedThroughProperty("Tempo_entre_acionamentos")]
		private NumericUpDown _Tempo_entre_acionamentos;

		// Token: 0x04001678 RID: 5752
		[AccessedThroughProperty("Numero_valvulas")]
		private NumericUpDown _Numero_valvulas;

		// Token: 0x04001679 RID: 5753
		[AccessedThroughProperty("Valor_pressao_min_recalque")]
		private NumericUpDown _Valor_pressao_min_recalque;

		// Token: 0x0400167A RID: 5754
		[AccessedThroughProperty("Valor_pressao_min_succao")]
		private NumericUpDown _Valor_pressao_min_succao;

		// Token: 0x0400167B RID: 5755
		[AccessedThroughProperty("Label_pressao_min_succao")]
		private Label _Label_pressao_min_succao;

		// Token: 0x0400167C RID: 5756
		[AccessedThroughProperty("Label_pressao_min_recalque")]
		private Label _Label_pressao_min_recalque;

		// Token: 0x0400167D RID: 5757
		[AccessedThroughProperty("Valor_tempo_mais_bomba")]
		private NumericUpDown _Valor_tempo_mais_bomba;

		// Token: 0x0400167E RID: 5758
		[AccessedThroughProperty("Valor_nivel_liga_b4")]
		private NumericUpDown _Valor_nivel_liga_b4;

		// Token: 0x0400167F RID: 5759
		[AccessedThroughProperty("Label_nivel_liga_b4")]
		private Label _Label_nivel_liga_b4;

		// Token: 0x04001680 RID: 5760
		[AccessedThroughProperty("Label_tempo_mais_bomba")]
		private Label _Label_tempo_mais_bomba;

		// Token: 0x04001681 RID: 5761
		[AccessedThroughProperty("Valor_nivel_liga_b1")]
		private NumericUpDown _Valor_nivel_liga_b1;

		// Token: 0x04001682 RID: 5762
		[AccessedThroughProperty("Valor_nivel_desejado")]
		private NumericUpDown _Valor_nivel_desejado;

		// Token: 0x04001683 RID: 5763
		[AccessedThroughProperty("Label_nivel_desejado")]
		private Label _Label_nivel_desejado;

		// Token: 0x04001684 RID: 5764
		[AccessedThroughProperty("Label_nivel_liga_b1")]
		private Label _Label_nivel_liga_b1;

		// Token: 0x04001685 RID: 5765
		[AccessedThroughProperty("Label_tempo_entre_acionamentos")]
		private Label _Label_tempo_entre_acionamentos;

		// Token: 0x04001686 RID: 5766
		[AccessedThroughProperty("Label_num_valvulas")]
		private Label _Label_num_valvulas;

		// Token: 0x04001687 RID: 5767
		[AccessedThroughProperty("Grupo_repetidora")]
		private GroupBox _Grupo_repetidora;

		// Token: 0x04001688 RID: 5768
		[AccessedThroughProperty("Valor_num_est_rep")]
		private NumericUpDown _Valor_num_est_rep;

		// Token: 0x04001689 RID: 5769
		[AccessedThroughProperty("Valor_end_rep")]
		private NumericUpDown _Valor_end_rep;

		// Token: 0x0400168A RID: 5770
		[AccessedThroughProperty("Grupo_end_rep")]
		private GroupBox _Grupo_end_rep;

		// Token: 0x0400168B RID: 5771
		[AccessedThroughProperty("VScrollBar1")]
		private VScrollBar _VScrollBar1;

		// Token: 0x0400168C RID: 5772
		[AccessedThroughProperty("Label_end_rep_12")]
		private Label _Label_end_rep_12;

		// Token: 0x0400168D RID: 5773
		[AccessedThroughProperty("Valor_end_rep_12")]
		private TextBox _Valor_end_rep_12;

		// Token: 0x0400168E RID: 5774
		[AccessedThroughProperty("Label_end_rep_11")]
		private Label _Label_end_rep_11;

		// Token: 0x0400168F RID: 5775
		[AccessedThroughProperty("Valor_end_rep_11")]
		private TextBox _Valor_end_rep_11;

		// Token: 0x04001690 RID: 5776
		[AccessedThroughProperty("Label_end_rep_6")]
		private Label _Label_end_rep_6;

		// Token: 0x04001691 RID: 5777
		[AccessedThroughProperty("Valor_end_rep_6")]
		private TextBox _Valor_end_rep_6;

		// Token: 0x04001692 RID: 5778
		[AccessedThroughProperty("Label_end_rep_3")]
		private Label _Label_end_rep_3;

		// Token: 0x04001693 RID: 5779
		[AccessedThroughProperty("Valor_end_rep_3")]
		private TextBox _Valor_end_rep_3;

		// Token: 0x04001694 RID: 5780
		[AccessedThroughProperty("Label_end_rep_9")]
		private Label _Label_end_rep_9;

		// Token: 0x04001695 RID: 5781
		[AccessedThroughProperty("Valor_end_rep_9")]
		private TextBox _Valor_end_rep_9;

		// Token: 0x04001696 RID: 5782
		[AccessedThroughProperty("Label_end_rep_8")]
		private Label _Label_end_rep_8;

		// Token: 0x04001697 RID: 5783
		[AccessedThroughProperty("Valor_end_rep_8")]
		private TextBox _Valor_end_rep_8;

		// Token: 0x04001698 RID: 5784
		[AccessedThroughProperty("Label_end_rep_5")]
		private Label _Label_end_rep_5;

		// Token: 0x04001699 RID: 5785
		[AccessedThroughProperty("Valor_end_rep_5")]
		private TextBox _Valor_end_rep_5;

		// Token: 0x0400169A RID: 5786
		[AccessedThroughProperty("Label_end_rep_2")]
		private Label _Label_end_rep_2;

		// Token: 0x0400169B RID: 5787
		[AccessedThroughProperty("Valor_end_rep_2")]
		private TextBox _Valor_end_rep_2;

		// Token: 0x0400169C RID: 5788
		[AccessedThroughProperty("Label_end_rep_10")]
		private Label _Label_end_rep_10;

		// Token: 0x0400169D RID: 5789
		[AccessedThroughProperty("Valor_end_rep_10")]
		private TextBox _Valor_end_rep_10;

		// Token: 0x0400169E RID: 5790
		[AccessedThroughProperty("Label_end_rep_7")]
		private Label _Label_end_rep_7;

		// Token: 0x0400169F RID: 5791
		[AccessedThroughProperty("Label_end_rep_4")]
		private Label _Label_end_rep_4;

		// Token: 0x040016A0 RID: 5792
		[AccessedThroughProperty("Valor_end_rep_7")]
		private TextBox _Valor_end_rep_7;

		// Token: 0x040016A1 RID: 5793
		[AccessedThroughProperty("Valor_end_rep_4")]
		private TextBox _Valor_end_rep_4;

		// Token: 0x040016A2 RID: 5794
		[AccessedThroughProperty("Label_end_rep_1")]
		private Label _Label_end_rep_1;

		// Token: 0x040016A3 RID: 5795
		[AccessedThroughProperty("Valor_end_rep_1")]
		private TextBox _Valor_end_rep_1;

		// Token: 0x040016A4 RID: 5796
		[AccessedThroughProperty("CheckBox_hab_rep")]
		private CheckBox _CheckBox_hab_rep;

		// Token: 0x040016A5 RID: 5797
		[AccessedThroughProperty("Label_num_est_rep")]
		private Label _Label_num_est_rep;

		// Token: 0x040016A6 RID: 5798
		[AccessedThroughProperty("Label_end_rep")]
		private Label _Label_end_rep;

		// Token: 0x040016A7 RID: 5799
		[AccessedThroughProperty("grupo_comunicacao")]
		private GroupBox _grupo_comunicacao;

		// Token: 0x040016A8 RID: 5800
		[AccessedThroughProperty("Valor_temp_ptt")]
		private NumericUpDown _Valor_temp_ptt;

		// Token: 0x040016A9 RID: 5801
		[AccessedThroughProperty("Valor_end_mestre")]
		private NumericUpDown _Valor_end_mestre;

		// Token: 0x040016AA RID: 5802
		[AccessedThroughProperty("Valor_end_est")]
		private NumericUpDown _Valor_end_est;

		// Token: 0x040016AB RID: 5803
		[AccessedThroughProperty("Label_tempo_ptt")]
		private Label _Label_tempo_ptt;

		// Token: 0x040016AC RID: 5804
		[AccessedThroughProperty("Label_end_mestre")]
		private Label _Label_end_mestre;

		// Token: 0x040016AD RID: 5805
		[AccessedThroughProperty("Label_end_est")]
		private Label _Label_end_est;

		// Token: 0x040016AE RID: 5806
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x040016AF RID: 5807
		[AccessedThroughProperty("ArquivoToolStripMenuItem")]
		private ToolStripMenuItem _ArquivoToolStripMenuItem;

		// Token: 0x040016B0 RID: 5808
		[AccessedThroughProperty("NovoToolStripMenuItem")]
		private ToolStripMenuItem _NovoToolStripMenuItem;

		// Token: 0x040016B1 RID: 5809
		[AccessedThroughProperty("AbrirToolStripMenuItem")]
		private ToolStripMenuItem _AbrirToolStripMenuItem;

		// Token: 0x040016B2 RID: 5810
		[AccessedThroughProperty("SalvarToolStripMenuItem")]
		private ToolStripMenuItem _SalvarToolStripMenuItem;

		// Token: 0x040016B3 RID: 5811
		[AccessedThroughProperty("Numero_motores")]
		private NumericUpDown _Numero_motores;

		// Token: 0x040016B4 RID: 5812
		[AccessedThroughProperty("Valor_nivel_liga_b3")]
		private NumericUpDown _Valor_nivel_liga_b3;

		// Token: 0x040016B5 RID: 5813
		[AccessedThroughProperty("Valor_nivel_liga_b2")]
		private NumericUpDown _Valor_nivel_liga_b2;

		// Token: 0x040016B6 RID: 5814
		[AccessedThroughProperty("Label_nivel_liga_b2")]
		private Label _Label_nivel_liga_b2;

		// Token: 0x040016B7 RID: 5815
		[AccessedThroughProperty("Label_nivel_liga_b3")]
		private Label _Label_nivel_liga_b3;

		// Token: 0x040016B8 RID: 5816
		[AccessedThroughProperty("Label_num_motores")]
		private Label _Label_num_motores;

		// Token: 0x040016B9 RID: 5817
		[AccessedThroughProperty("Grupo_setpoints")]
		private GroupBox _Grupo_setpoints;

		// Token: 0x040016BA RID: 5818
		[AccessedThroughProperty("Valor_nivel_liberacao")]
		private NumericUpDown _Valor_nivel_liberacao;

		// Token: 0x040016BB RID: 5819
		[AccessedThroughProperty("Valor_nivel_bloqueio")]
		private NumericUpDown _Valor_nivel_bloqueio;

		// Token: 0x040016BC RID: 5820
		[AccessedThroughProperty("Label_nivel_liberacao")]
		private Label _Label_nivel_liberacao;

		// Token: 0x040016BD RID: 5821
		[AccessedThroughProperty("Label_nivel_bloqueio")]
		private Label _Label_nivel_bloqueio;

		// Token: 0x040016BE RID: 5822
		[AccessedThroughProperty("Grupo_analogicas")]
		private GroupBox _Grupo_analogicas;

		// Token: 0x040016BF RID: 5823
		[AccessedThroughProperty("Grupo_entradas_digitais")]
		private GroupBox _Grupo_entradas_digitais;

		// Token: 0x040016C0 RID: 5824
		[AccessedThroughProperty("ComboBox_E08")]
		private ComboBox _ComboBox_E08;

		// Token: 0x040016C1 RID: 5825
		[AccessedThroughProperty("ComboBox_E07")]
		private ComboBox _ComboBox_E07;

		// Token: 0x040016C2 RID: 5826
		[AccessedThroughProperty("ComboBox_E06")]
		private ComboBox _ComboBox_E06;

		// Token: 0x040016C3 RID: 5827
		[AccessedThroughProperty("ComboBox_E05")]
		private ComboBox _ComboBox_E05;

		// Token: 0x040016C4 RID: 5828
		[AccessedThroughProperty("ComboBox_E04")]
		private ComboBox _ComboBox_E04;

		// Token: 0x040016C5 RID: 5829
		[AccessedThroughProperty("ComboBox_E03")]
		private ComboBox _ComboBox_E03;

		// Token: 0x040016C6 RID: 5830
		[AccessedThroughProperty("ComboBox_E02")]
		private ComboBox _ComboBox_E02;

		// Token: 0x040016C7 RID: 5831
		[AccessedThroughProperty("ComboBox_E01")]
		private ComboBox _ComboBox_E01;

		// Token: 0x040016C8 RID: 5832
		[AccessedThroughProperty("Label_E08")]
		private Label _Label_E08;

		// Token: 0x040016C9 RID: 5833
		[AccessedThroughProperty("Label_E07")]
		private Label _Label_E07;

		// Token: 0x040016CA RID: 5834
		[AccessedThroughProperty("Label_E06")]
		private Label _Label_E06;

		// Token: 0x040016CB RID: 5835
		[AccessedThroughProperty("Label_E05")]
		private Label _Label_E05;

		// Token: 0x040016CC RID: 5836
		[AccessedThroughProperty("Label_E04")]
		private Label _Label_E04;

		// Token: 0x040016CD RID: 5837
		[AccessedThroughProperty("Label_E03")]
		private Label _Label_E03;

		// Token: 0x040016CE RID: 5838
		[AccessedThroughProperty("Label_E02")]
		private Label _Label_E02;

		// Token: 0x040016CF RID: 5839
		[AccessedThroughProperty("Label_E01")]
		private Label _Label_E01;

		// Token: 0x040016D0 RID: 5840
		[AccessedThroughProperty("Valor_tamanho_filtro_AD")]
		private NumericUpDown _Valor_tamanho_filtro_AD;

		// Token: 0x040016D1 RID: 5841
		[AccessedThroughProperty("Valor_intervalo_filtro_AD")]
		private NumericUpDown _Valor_intervalo_filtro_AD;

		// Token: 0x040016D2 RID: 5842
		[AccessedThroughProperty("Label_tamanho_filtro_AD")]
		private Label _Label_tamanho_filtro_AD;

		// Token: 0x040016D3 RID: 5843
		[AccessedThroughProperty("Label_intervalo_filtro_AD")]
		private Label _Label_intervalo_filtro_AD;

		// Token: 0x040016D4 RID: 5844
		[AccessedThroughProperty("Combo_modo_operacao")]
		private ComboBox _Combo_modo_operacao;

		// Token: 0x040016D5 RID: 5845
		[AccessedThroughProperty("Label_modo_operacao")]
		private Label _Label_modo_operacao;

		// Token: 0x040016D6 RID: 5846
		[AccessedThroughProperty("Combo_baudrate")]
		private ComboBox _Combo_baudrate;

		// Token: 0x040016D7 RID: 5847
		[AccessedThroughProperty("Label_baudrate")]
		private Label _Label_baudrate;

		// Token: 0x040016D8 RID: 5848
		[AccessedThroughProperty("Valor_num_bomba_simultaneas")]
		private NumericUpDown _Valor_num_bomba_simultaneas;

		// Token: 0x040016D9 RID: 5849
		[AccessedThroughProperty("Label_num_bombas_simultaneas")]
		private Label _Label_num_bombas_simultaneas;

		// Token: 0x040016DA RID: 5850
		[AccessedThroughProperty("Combo_modo_partida_m1")]
		private ComboBox _Combo_modo_partida_m1;

		// Token: 0x040016DB RID: 5851
		[AccessedThroughProperty("Tempo_parada_m1")]
		private NumericUpDown _Tempo_parada_m1;

		// Token: 0x040016DC RID: 5852
		[AccessedThroughProperty("Tempo_partida_m1")]
		private NumericUpDown _Tempo_partida_m1;

		// Token: 0x040016DD RID: 5853
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x040016DE RID: 5854
		[AccessedThroughProperty("Label_motor4")]
		private Label _Label_motor4;

		// Token: 0x040016DF RID: 5855
		[AccessedThroughProperty("Label_motor3")]
		private Label _Label_motor3;

		// Token: 0x040016E0 RID: 5856
		[AccessedThroughProperty("Combo_modo_partida_m4")]
		private ComboBox _Combo_modo_partida_m4;

		// Token: 0x040016E1 RID: 5857
		[AccessedThroughProperty("Combo_modo_partida_m3")]
		private ComboBox _Combo_modo_partida_m3;

		// Token: 0x040016E2 RID: 5858
		[AccessedThroughProperty("Label_motor2")]
		private Label _Label_motor2;

		// Token: 0x040016E3 RID: 5859
		[AccessedThroughProperty("Combo_modo_partida_m2")]
		private ComboBox _Combo_modo_partida_m2;

		// Token: 0x040016E4 RID: 5860
		[AccessedThroughProperty("Tempo_partida_m4")]
		private NumericUpDown _Tempo_partida_m4;

		// Token: 0x040016E5 RID: 5861
		[AccessedThroughProperty("Tempo_partida_m3")]
		private NumericUpDown _Tempo_partida_m3;

		// Token: 0x040016E6 RID: 5862
		[AccessedThroughProperty("Label_motor1")]
		private Label _Label_motor1;

		// Token: 0x040016E7 RID: 5863
		[AccessedThroughProperty("Tempo_parada_m4")]
		private NumericUpDown _Tempo_parada_m4;

		// Token: 0x040016E8 RID: 5864
		[AccessedThroughProperty("Tempo_partida_m2")]
		private NumericUpDown _Tempo_partida_m2;

		// Token: 0x040016E9 RID: 5865
		[AccessedThroughProperty("Tempo_parada_m3")]
		private NumericUpDown _Tempo_parada_m3;

		// Token: 0x040016EA RID: 5866
		[AccessedThroughProperty("Tempo_parada_m2")]
		private NumericUpDown _Tempo_parada_m2;

		// Token: 0x040016EB RID: 5867
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x040016EC RID: 5868
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040016ED RID: 5869
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040016EE RID: 5870
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040016EF RID: 5871
		[AccessedThroughProperty("Tempo_abertura_v4")]
		private NumericUpDown _Tempo_abertura_v4;

		// Token: 0x040016F0 RID: 5872
		[AccessedThroughProperty("Tempo_abertura_v3")]
		private NumericUpDown _Tempo_abertura_v3;

		// Token: 0x040016F1 RID: 5873
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x040016F2 RID: 5874
		[AccessedThroughProperty("Tempo_fechamento_v4")]
		private NumericUpDown _Tempo_fechamento_v4;

		// Token: 0x040016F3 RID: 5875
		[AccessedThroughProperty("Tempo_abertura_v2")]
		private NumericUpDown _Tempo_abertura_v2;

		// Token: 0x040016F4 RID: 5876
		[AccessedThroughProperty("Tempo_fechamento_v3")]
		private NumericUpDown _Tempo_fechamento_v3;

		// Token: 0x040016F5 RID: 5877
		[AccessedThroughProperty("Tempo_fechamento_v2")]
		private NumericUpDown _Tempo_fechamento_v2;

		// Token: 0x040016F6 RID: 5878
		[AccessedThroughProperty("Tempo_abertura_v1")]
		private NumericUpDown _Tempo_abertura_v1;

		// Token: 0x040016F7 RID: 5879
		[AccessedThroughProperty("Tempo_fechamento_v1")]
		private NumericUpDown _Tempo_fechamento_v1;

		// Token: 0x040016F8 RID: 5880
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040016F9 RID: 5881
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x040016FA RID: 5882
		[AccessedThroughProperty("Label_tempo_parada")]
		private Label _Label_tempo_parada;

		// Token: 0x040016FB RID: 5883
		[AccessedThroughProperty("Label_tempo_partida")]
		private Label _Label_tempo_partida;

		// Token: 0x040016FC RID: 5884
		[AccessedThroughProperty("Label_modo_de_operacao_motor")]
		private Label _Label_modo_de_operacao_motor;

		// Token: 0x040016FD RID: 5885
		[AccessedThroughProperty("Combo_num_totalizacoes")]
		private ComboBox _Combo_num_totalizacoes;

		// Token: 0x040016FE RID: 5886
		[AccessedThroughProperty("Label_num_totalizacoes")]
		private Label _Label_num_totalizacoes;

		// Token: 0x040016FF RID: 5887
		[AccessedThroughProperty("CheckBox_ctrl_nivel_fonte")]
		private CheckBox _CheckBox_ctrl_nivel_fonte;

		// Token: 0x04001700 RID: 5888
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog _OpenFileDialog1;

		// Token: 0x04001701 RID: 5889
		[AccessedThroughProperty("SaveFileDialog1")]
		private SaveFileDialog _SaveFileDialog1;

		// Token: 0x04001702 RID: 5890
		[AccessedThroughProperty("Grupo_perifericos")]
		private GroupBox _Grupo_perifericos;

		// Token: 0x04001703 RID: 5891
		[AccessedThroughProperty("Endereco_p1")]
		private NumericUpDown _Endereco_p1;

		// Token: 0x04001704 RID: 5892
		[AccessedThroughProperty("Combo_tipo_p4")]
		private ComboBox _Combo_tipo_p4;

		// Token: 0x04001705 RID: 5893
		[AccessedThroughProperty("Combo_tipo_p2")]
		private ComboBox _Combo_tipo_p2;

		// Token: 0x04001706 RID: 5894
		[AccessedThroughProperty("Combo_tipo_p3")]
		private ComboBox _Combo_tipo_p3;

		// Token: 0x04001707 RID: 5895
		[AccessedThroughProperty("Combo_tipo_p1")]
		private ComboBox _Combo_tipo_p1;

		// Token: 0x04001708 RID: 5896
		[AccessedThroughProperty("Label_nota_2")]
		private Label _Label_nota_2;

		// Token: 0x04001709 RID: 5897
		[AccessedThroughProperty("Label_periferico_2")]
		private Label _Label_periferico_2;

		// Token: 0x0400170A RID: 5898
		[AccessedThroughProperty("Label_nota_1")]
		private Label _Label_nota_1;

		// Token: 0x0400170B RID: 5899
		[AccessedThroughProperty("Label_periferico_1")]
		private Label _Label_periferico_1;

		// Token: 0x0400170C RID: 5900
		[AccessedThroughProperty("Endereco_p4")]
		private NumericUpDown _Endereco_p4;

		// Token: 0x0400170D RID: 5901
		[AccessedThroughProperty("Endereco_p2")]
		private NumericUpDown _Endereco_p2;

		// Token: 0x0400170E RID: 5902
		[AccessedThroughProperty("Endereco_p3")]
		private NumericUpDown _Endereco_p3;

		// Token: 0x0400170F RID: 5903
		[AccessedThroughProperty("Label_periferico_4")]
		private Label _Label_periferico_4;

		// Token: 0x04001710 RID: 5904
		[AccessedThroughProperty("Label_periferico_3")]
		private Label _Label_periferico_3;

		// Token: 0x04001711 RID: 5905
		private int passo_202;

		// Token: 0x04001712 RID: 5906
		private int passo_202_motor;
	}
}
