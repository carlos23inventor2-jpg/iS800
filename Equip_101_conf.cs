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
	// Token: 0x0200007F RID: 127
	[DesignerGenerated]
	public partial class Equip_101_conf : Form
	{
		// Token: 0x06001AF8 RID: 6904 RVA: 0x003C4E2C File Offset: 0x003C322C
		public Equip_101_conf()
		{
			base.Load += new EventHandler(this.Equip_101_conf_Load);
			this.InitializeComponent();
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001AFB RID: 6907 RVA: 0x003C7694 File Offset: 0x003C5A94
		// (set) Token: 0x06001AFC RID: 6908 RVA: 0x003C76A8 File Offset: 0x003C5AA8
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

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x003C76B4 File Offset: 0x003C5AB4
		// (set) Token: 0x06001AFE RID: 6910 RVA: 0x003C76C8 File Offset: 0x003C5AC8
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

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x003C76D4 File Offset: 0x003C5AD4
		// (set) Token: 0x06001B00 RID: 6912 RVA: 0x003C76E8 File Offset: 0x003C5AE8
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

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x003C76F4 File Offset: 0x003C5AF4
		// (set) Token: 0x06001B02 RID: 6914 RVA: 0x003C7708 File Offset: 0x003C5B08
		internal virtual GroupBox Grupo_aquisicao
		{
			get
			{
				return this._Grupo_aquisicao;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_aquisicao = value;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x003C7714 File Offset: 0x003C5B14
		// (set) Token: 0x06001B04 RID: 6916 RVA: 0x003C7728 File Offset: 0x003C5B28
		internal virtual Label Label_sensor_range
		{
			get
			{
				return this._Label_sensor_range;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_sensor_range = value;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x003C7734 File Offset: 0x003C5B34
		// (set) Token: 0x06001B06 RID: 6918 RVA: 0x003C7748 File Offset: 0x003C5B48
		internal virtual Label Label_tipo_leitura
		{
			get
			{
				return this._Label_tipo_leitura;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tipo_leitura = value;
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x003C7754 File Offset: 0x003C5B54
		// (set) Token: 0x06001B08 RID: 6920 RVA: 0x003C7768 File Offset: 0x003C5B68
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

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x003C7774 File Offset: 0x003C5B74
		// (set) Token: 0x06001B0A RID: 6922 RVA: 0x003C7788 File Offset: 0x003C5B88
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

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x003C7794 File Offset: 0x003C5B94
		// (set) Token: 0x06001B0C RID: 6924 RVA: 0x003C77A8 File Offset: 0x003C5BA8
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

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x003C77B4 File Offset: 0x003C5BB4
		// (set) Token: 0x06001B0E RID: 6926 RVA: 0x003C77C8 File Offset: 0x003C5BC8
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

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x003C7814 File Offset: 0x003C5C14
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x003C7828 File Offset: 0x003C5C28
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

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001B11 RID: 6929 RVA: 0x003C7834 File Offset: 0x003C5C34
		// (set) Token: 0x06001B12 RID: 6930 RVA: 0x003C7848 File Offset: 0x003C5C48
		internal virtual Label Label_int_tx
		{
			get
			{
				return this._Label_int_tx;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_int_tx = value;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001B13 RID: 6931 RVA: 0x003C7854 File Offset: 0x003C5C54
		// (set) Token: 0x06001B14 RID: 6932 RVA: 0x003C7868 File Offset: 0x003C5C68
		internal virtual ComboBox Combo_modo
		{
			get
			{
				return this._Combo_modo;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_modo_SelectedIndexChanged);
				if (this._Combo_modo != null)
				{
					this._Combo_modo.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_modo = value;
				if (this._Combo_modo != null)
				{
					this._Combo_modo.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x003C78B4 File Offset: 0x003C5CB4
		// (set) Token: 0x06001B16 RID: 6934 RVA: 0x003C78C8 File Offset: 0x003C5CC8
		internal virtual Label Label_modo_ope
		{
			get
			{
				return this._Label_modo_ope;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_modo_ope = value;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x003C78D4 File Offset: 0x003C5CD4
		// (set) Token: 0x06001B18 RID: 6936 RVA: 0x003C78E8 File Offset: 0x003C5CE8
		internal virtual ComboBox Combo_nivel
		{
			get
			{
				return this._Combo_nivel;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_nivel_SelectedIndexChanged);
				if (this._Combo_nivel != null)
				{
					this._Combo_nivel.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_nivel = value;
				if (this._Combo_nivel != null)
				{
					this._Combo_nivel.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x003C7934 File Offset: 0x003C5D34
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x003C7948 File Offset: 0x003C5D48
		internal virtual Label Label_filtro_tamanho
		{
			get
			{
				return this._Label_filtro_tamanho;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_filtro_tamanho = value;
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x003C7954 File Offset: 0x003C5D54
		// (set) Token: 0x06001B1C RID: 6940 RVA: 0x003C7968 File Offset: 0x003C5D68
		internal virtual Label Label_filtro_intervalo
		{
			get
			{
				return this._Label_filtro_intervalo;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_filtro_intervalo = value;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x003C7974 File Offset: 0x003C5D74
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x003C7988 File Offset: 0x003C5D88
		internal virtual Label Label_sensor_offset
		{
			get
			{
				return this._Label_sensor_offset;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_sensor_offset = value;
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x003C7994 File Offset: 0x003C5D94
		// (set) Token: 0x06001B20 RID: 6944 RVA: 0x003C79A8 File Offset: 0x003C5DA8
		internal virtual Label Label_reservatorio_altura
		{
			get
			{
				return this._Label_reservatorio_altura;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_reservatorio_altura = value;
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x003C79B4 File Offset: 0x003C5DB4
		// (set) Token: 0x06001B22 RID: 6946 RVA: 0x003C79C8 File Offset: 0x003C5DC8
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

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x003C79D4 File Offset: 0x003C5DD4
		// (set) Token: 0x06001B24 RID: 6948 RVA: 0x003C79E8 File Offset: 0x003C5DE8
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

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x003C79F4 File Offset: 0x003C5DF4
		// (set) Token: 0x06001B26 RID: 6950 RVA: 0x003C7A08 File Offset: 0x003C5E08
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

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x003C7A54 File Offset: 0x003C5E54
		// (set) Token: 0x06001B28 RID: 6952 RVA: 0x003C7A68 File Offset: 0x003C5E68
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

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x003C7A74 File Offset: 0x003C5E74
		// (set) Token: 0x06001B2A RID: 6954 RVA: 0x003C7A88 File Offset: 0x003C5E88
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

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x003C7AD4 File Offset: 0x003C5ED4
		// (set) Token: 0x06001B2C RID: 6956 RVA: 0x003C7AE8 File Offset: 0x003C5EE8
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

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x003C7AF4 File Offset: 0x003C5EF4
		// (set) Token: 0x06001B2E RID: 6958 RVA: 0x003C7B08 File Offset: 0x003C5F08
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

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x003C7B54 File Offset: 0x003C5F54
		// (set) Token: 0x06001B30 RID: 6960 RVA: 0x003C7B68 File Offset: 0x003C5F68
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

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x003C7B74 File Offset: 0x003C5F74
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x003C7B88 File Offset: 0x003C5F88
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

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x003C7BD4 File Offset: 0x003C5FD4
		// (set) Token: 0x06001B34 RID: 6964 RVA: 0x003C7BE8 File Offset: 0x003C5FE8
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

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x003C7BF4 File Offset: 0x003C5FF4
		// (set) Token: 0x06001B36 RID: 6966 RVA: 0x003C7C08 File Offset: 0x003C6008
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

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x003C7C54 File Offset: 0x003C6054
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x003C7C68 File Offset: 0x003C6068
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

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x003C7C74 File Offset: 0x003C6074
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x003C7C88 File Offset: 0x003C6088
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

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x003C7CD4 File Offset: 0x003C60D4
		// (set) Token: 0x06001B3C RID: 6972 RVA: 0x003C7CE8 File Offset: 0x003C60E8
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

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001B3D RID: 6973 RVA: 0x003C7CF4 File Offset: 0x003C60F4
		// (set) Token: 0x06001B3E RID: 6974 RVA: 0x003C7D08 File Offset: 0x003C6108
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

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x003C7D54 File Offset: 0x003C6154
		// (set) Token: 0x06001B40 RID: 6976 RVA: 0x003C7D68 File Offset: 0x003C6168
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

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x003C7D74 File Offset: 0x003C6174
		// (set) Token: 0x06001B42 RID: 6978 RVA: 0x003C7D88 File Offset: 0x003C6188
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

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001B43 RID: 6979 RVA: 0x003C7D94 File Offset: 0x003C6194
		// (set) Token: 0x06001B44 RID: 6980 RVA: 0x003C7DA8 File Offset: 0x003C61A8
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

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x003C7DF4 File Offset: 0x003C61F4
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x003C7E08 File Offset: 0x003C6208
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

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x003C7E54 File Offset: 0x003C6254
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x003C7E68 File Offset: 0x003C6268
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

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x003C7E74 File Offset: 0x003C6274
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x003C7E88 File Offset: 0x003C6288
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

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x003C7ED4 File Offset: 0x003C62D4
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x003C7EE8 File Offset: 0x003C62E8
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

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x003C7EF4 File Offset: 0x003C62F4
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x003C7F08 File Offset: 0x003C6308
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

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x003C7F54 File Offset: 0x003C6354
		// (set) Token: 0x06001B50 RID: 6992 RVA: 0x003C7F68 File Offset: 0x003C6368
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

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x003C7F74 File Offset: 0x003C6374
		// (set) Token: 0x06001B52 RID: 6994 RVA: 0x003C7F88 File Offset: 0x003C6388
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

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x003C7FD4 File Offset: 0x003C63D4
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x003C7FE8 File Offset: 0x003C63E8
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

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x003C8034 File Offset: 0x003C6434
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x003C8048 File Offset: 0x003C6448
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

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x003C8054 File Offset: 0x003C6454
		// (set) Token: 0x06001B58 RID: 7000 RVA: 0x003C8068 File Offset: 0x003C6468
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

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x003C8074 File Offset: 0x003C6474
		// (set) Token: 0x06001B5A RID: 7002 RVA: 0x003C8088 File Offset: 0x003C6488
		internal virtual ToolStripMenuItem CarregarToolStripMenuItem
		{
			get
			{
				return this._CarregarToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CarregarToolStripMenuItem_Click);
				if (this._CarregarToolStripMenuItem != null)
				{
					this._CarregarToolStripMenuItem.Click -= eventHandler;
				}
				this._CarregarToolStripMenuItem = value;
				if (this._CarregarToolStripMenuItem != null)
				{
					this._CarregarToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x003C80D4 File Offset: 0x003C64D4
		// (set) Token: 0x06001B5C RID: 7004 RVA: 0x003C80E8 File Offset: 0x003C64E8
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

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x003C8134 File Offset: 0x003C6534
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x003C8148 File Offset: 0x003C6548
		internal virtual ToolTip ToolTip1
		{
			get
			{
				return this._ToolTip1;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolTip1 = value;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x003C8154 File Offset: 0x003C6554
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x003C8168 File Offset: 0x003C6568
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

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x003C8174 File Offset: 0x003C6574
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x003C8188 File Offset: 0x003C6588
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

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x003C8194 File Offset: 0x003C6594
		// (set) Token: 0x06001B64 RID: 7012 RVA: 0x003C81A8 File Offset: 0x003C65A8
		internal virtual Button Ler_conf_md_101
		{
			get
			{
				return this._Ler_conf_md_101;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Ler_conf_md_101_Click);
				if (this._Ler_conf_md_101 != null)
				{
					this._Ler_conf_md_101.Click -= eventHandler;
				}
				this._Ler_conf_md_101 = value;
				if (this._Ler_conf_md_101 != null)
				{
					this._Ler_conf_md_101.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x003C81F4 File Offset: 0x003C65F4
		// (set) Token: 0x06001B66 RID: 7014 RVA: 0x003C8208 File Offset: 0x003C6608
		internal virtual ToolStripMenuItem SalvarToolStripMenuItem
		{
			get
			{
				return this._SalvarToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalvarToolStripMenuItem_Click);
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

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x003C8254 File Offset: 0x003C6654
		// (set) Token: 0x06001B68 RID: 7016 RVA: 0x003C8268 File Offset: 0x003C6668
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

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x003C8274 File Offset: 0x003C6674
		// (set) Token: 0x06001B6A RID: 7018 RVA: 0x003C8288 File Offset: 0x003C6688
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

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x003C8294 File Offset: 0x003C6694
		// (set) Token: 0x06001B6C RID: 7020 RVA: 0x003C82A8 File Offset: 0x003C66A8
		internal virtual Button Esc_conf_md_101
		{
			get
			{
				return this._Esc_conf_md_101;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Esc_conf_md_101_Click);
				if (this._Esc_conf_md_101 != null)
				{
					this._Esc_conf_md_101.Click -= eventHandler;
				}
				this._Esc_conf_md_101 = value;
				if (this._Esc_conf_md_101 != null)
				{
					this._Esc_conf_md_101.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x003C82F4 File Offset: 0x003C66F4
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x003C8308 File Offset: 0x003C6708
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

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x003C8354 File Offset: 0x003C6754
		// (set) Token: 0x06001B70 RID: 7024 RVA: 0x003C8368 File Offset: 0x003C6768
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

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x003C83B4 File Offset: 0x003C67B4
		// (set) Token: 0x06001B72 RID: 7026 RVA: 0x003C83C8 File Offset: 0x003C67C8
		internal virtual NumericUpDown Valor_int_tx
		{
			get
			{
				return this._Valor_int_tx;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_int_tx_ValueChanged);
				if (this._Valor_int_tx != null)
				{
					this._Valor_int_tx.ValueChanged -= eventHandler;
				}
				this._Valor_int_tx = value;
				if (this._Valor_int_tx != null)
				{
					this._Valor_int_tx.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x003C8414 File Offset: 0x003C6814
		// (set) Token: 0x06001B74 RID: 7028 RVA: 0x003C8428 File Offset: 0x003C6828
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

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x003C8474 File Offset: 0x003C6874
		// (set) Token: 0x06001B76 RID: 7030 RVA: 0x003C8488 File Offset: 0x003C6888
		internal virtual NumericUpDown Sensor_range
		{
			get
			{
				return this._Sensor_range;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Sensor_range_ValueChanged);
				if (this._Sensor_range != null)
				{
					this._Sensor_range.ValueChanged -= eventHandler;
				}
				this._Sensor_range = value;
				if (this._Sensor_range != null)
				{
					this._Sensor_range.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x003C84D4 File Offset: 0x003C68D4
		// (set) Token: 0x06001B78 RID: 7032 RVA: 0x003C84E8 File Offset: 0x003C68E8
		internal virtual NumericUpDown Reservatorio_altura
		{
			get
			{
				return this._Reservatorio_altura;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Reservatorio_altura_ValueChanged);
				if (this._Reservatorio_altura != null)
				{
					this._Reservatorio_altura.ValueChanged -= eventHandler;
				}
				this._Reservatorio_altura = value;
				if (this._Reservatorio_altura != null)
				{
					this._Reservatorio_altura.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x003C8534 File Offset: 0x003C6934
		// (set) Token: 0x06001B7A RID: 7034 RVA: 0x003C8548 File Offset: 0x003C6948
		internal virtual NumericUpDown Sensor_offset
		{
			get
			{
				return this._Sensor_offset;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Sensor_offset_ValueChanged);
				if (this._Sensor_offset != null)
				{
					this._Sensor_offset.ValueChanged -= eventHandler;
				}
				this._Sensor_offset = value;
				if (this._Sensor_offset != null)
				{
					this._Sensor_offset.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x003C8594 File Offset: 0x003C6994
		// (set) Token: 0x06001B7C RID: 7036 RVA: 0x003C85A8 File Offset: 0x003C69A8
		internal virtual NumericUpDown Filtro_intervalo
		{
			get
			{
				return this._Filtro_intervalo;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Filtro_intervalo_ValueChanged);
				if (this._Filtro_intervalo != null)
				{
					this._Filtro_intervalo.ValueChanged -= eventHandler;
				}
				this._Filtro_intervalo = value;
				if (this._Filtro_intervalo != null)
				{
					this._Filtro_intervalo.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x003C85F4 File Offset: 0x003C69F4
		// (set) Token: 0x06001B7E RID: 7038 RVA: 0x003C8608 File Offset: 0x003C6A08
		internal virtual NumericUpDown Filtro_tamanho
		{
			get
			{
				return this._Filtro_tamanho;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Filtro_tamanho_ValueChanged);
				if (this._Filtro_tamanho != null)
				{
					this._Filtro_tamanho.ValueChanged -= eventHandler;
				}
				this._Filtro_tamanho = value;
				if (this._Filtro_tamanho != null)
				{
					this._Filtro_tamanho.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x003C8654 File Offset: 0x003C6A54
		// (set) Token: 0x06001B80 RID: 7040 RVA: 0x003C8668 File Offset: 0x003C6A68
		internal virtual NumericUpDown Valor_end_est_rep
		{
			get
			{
				return this._Valor_end_est_rep;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_end_est_rep_ValueChanged);
				if (this._Valor_end_est_rep != null)
				{
					this._Valor_end_est_rep.ValueChanged -= eventHandler;
				}
				this._Valor_end_est_rep = value;
				if (this._Valor_end_est_rep != null)
				{
					this._Valor_end_est_rep.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x003C86B4 File Offset: 0x003C6AB4
		// (set) Token: 0x06001B82 RID: 7042 RVA: 0x003C86C8 File Offset: 0x003C6AC8
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

		// Token: 0x06001B83 RID: 7043 RVA: 0x003C8714 File Offset: 0x003C6B14
		private void Equip_101_conf_Load(object sender, EventArgs e)
		{
			this.Combo_nivel.Items.Clear();
			this.Combo_nivel.Items.Add("Leitura Digital");
			this.Combo_nivel.Items.Add("Leitura Analógica");
			this.Combo_modo.Items.Clear();
			this.Combo_modo.Items.Add("Ponto à Ponto - COM1");
			this.Combo_modo.Items.Add("Ponto à Ponto - COM2");
			this.Combo_modo.Items.Add("Rede");
			this.passo = 0;
			Mod_MD.Init_equipamento_MD101();
			this.Limpa_estrutura_MD101(Mod_MD.Controle.Estacao);
			Mod_MD.CarregaConfiguracaoDefault_MD101(Mod_MD.Controle.Estacao);
			this.Atualiza_tela_MD101(Mod_MD.Controle.Estacao);
			Geral.Config_geral.Largura_tela_trabalho = this.Width;
			int num = 48;
			Interaction.MsgBox("Colocar o equipamento em modo de programação !\r\nFechar o jumper de configuração.", (MsgBoxStyle)num, " Atenção - verifique a configuração");
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x003C8810 File Offset: 0x003C6C10
		public void Limpa_estrutura_MD101(int indice)
		{
			Mod_MD.Reservatorio[indice].Repetidoras = new int[51];
			Mod_MD.Reservatorio[indice].Altura_sensor = 0;
			Mod_MD.Reservatorio[indice].End_estacao = 0;
			Mod_MD.Reservatorio[indice].End_mestre = 0;
			Mod_MD.Reservatorio[indice].End_repetidora = 0;
			Mod_MD.Reservatorio[indice].Hab_repetidora = 0;
			Mod_MD.Reservatorio[indice].Intervalo_filtro = 1;
			Mod_MD.Reservatorio[indice].Modo_operacao = 21846;
			Mod_MD.Reservatorio[indice].Num_repetidoras = 0;
			Mod_MD.Reservatorio[indice].Offset_sensor = 0;
			Mod_MD.Reservatorio[indice].Range_sensor = 0;
			Mod_MD.Reservatorio[indice].Tamanho_filtro = 1;
			Mod_MD.Reservatorio[indice].Tempo_ptt = 1;
			Mod_MD.Reservatorio[indice].Tempo_tx_ponto = 1;
			Mod_MD.Reservatorio[indice].Tipo_medida = 21872;
			int num = 0;
			checked
			{
				do
				{
					Mod_MD.Reservatorio[indice].Repetidoras[num] = 0;
					num++;
				}
				while (num <= 50);
				this.VScrollBar1.Value = 0;
			}
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x003C8954 File Offset: 0x003C6D54
		public void Atualiza_tela_MD101(int indice)
		{
			int num = 0;
			int num4 = 0;
			object obj = null;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 2;
				IL_07:
				int num2 = 2;
				int num3 = 0;
				IL_0C:
				num2 = 3;
				this.Reservatorio_altura.Value = new decimal(Mod_MD.Reservatorio[indice].Altura_sensor);
				IL_2F:
				num2 = 4;
				num3 = 1;
				IL_34:
				num2 = 5;
				this.Valor_end_est.Value = new decimal(Mod_MD.Reservatorio[indice].End_estacao);
				IL_57:
				num2 = 6;
				num3 = 2;
				IL_5C:
				num2 = 7;
				this.Valor_end_mestre.Value = new decimal(Mod_MD.Reservatorio[indice].End_mestre);
				IL_7F:
				num2 = 8;
				num3 = 3;
				IL_84:
				num2 = 9;
				this.Valor_end_est_rep.Value = new decimal(Mod_MD.Reservatorio[indice].End_repetidora);
				IL_A8:
				num2 = 10;
				num3 = 4;
				IL_AE:
				num2 = 11;
				int num5;
				checked
				{
					this.Filtro_intervalo.Value = new decimal(Mod_MD.Reservatorio[indice].Intervalo_filtro * 10);
					IL_D5:
					num2 = 12;
					num3 = 5;
					IL_DB:
					num2 = 13;
					this.Filtro_tamanho.Value = new decimal(Mod_MD.Reservatorio[indice].Tamanho_filtro);
					IL_FF:
					num2 = 14;
					num3 = 6;
					IL_105:
					num2 = 15;
					this.Valor_num_est_rep.Value = new decimal(Mod_MD.Reservatorio[indice].Num_repetidoras);
					IL_129:
					num2 = 16;
					num3 = 7;
					IL_12F:
					num2 = 17;
					if (Mod_MD.Reservatorio[indice].Offset_sensor <= 1000)
					{
											}
					IL_14A:
					num2 = 18;
					this.Sensor_offset.Value = new decimal(0 - (Mod_MD.Reservatorio[indice].Offset_sensor - 1000));
					IL_176:
					goto IL_1A0;
					IL_178:
					num2 = 20;
					IL_17C:
					num2 = 21;
					this.Sensor_offset.Value = new decimal(Mod_MD.Reservatorio[indice].Offset_sensor);
					IL_1A0:
					num2 = 23;
					num3 = 8;
					IL_1A6:
					num2 = 24;
					this.Sensor_range.Value = new decimal(Mod_MD.Reservatorio[indice].Range_sensor);
					IL_1CA:
					num2 = 25;
					num3 = 9;
					IL_1D1:
					num2 = 26;
					this.Valor_temp_ptt.Value = new decimal(Mod_MD.Reservatorio[indice].Tempo_ptt * 10);
					IL_1F8:
					num2 = 27;
					num3 = 10;
					IL_1FF:
					num2 = 28;
					this.Valor_int_tx.Value = new decimal(Mod_MD.Reservatorio[indice].Tempo_tx_ponto);
					IL_223:
					num2 = 29;
					this.Atualiza_tela_MD101_repetidora(indice);
					IL_22E:
					num2 = 30;
					this.Atualiza_tela_MD101_operacao(indice);
					IL_239:
					num2 = 31;
					this.Atualiza_tela_MD101_medida(indice);
					IL_244:
					goto IL_579;
					IL_249:
					num2 = 33;
					MsgBoxResult msgBoxResult = Interaction.MsgBox("Existem valores não compatíveis com os parâmetro desta tela !\r\nCarregar configuração Default ?", (MsgBoxStyle)36, "Atenção");
					IL_25F:
					num2 = 34;
					if (msgBoxResult != (MsgBoxResult)6)
					{
											}
					IL_267:
					num2 = 35;
					Mod_MD.CarregaConfiguracaoDefault_MD101(indice);
					IL_271:
					goto IL_3D2;
					IL_276:
					num2 = 37;
					IL_27A:
					num2 = 38;goto IL_3D2;
					IL_2B5:
					num2 = 42;
					Mod_MD.Reservatorio[indice].Altura_sensor = 1000;
					IL_2CE:
					goto IL_3D2;
					IL_2D3:
					num2 = 45;
					Mod_MD.Reservatorio[indice].End_estacao = 1;
					IL_2E8:
					goto IL_3D2;
					IL_2ED:
					num2 = 48;
					Mod_MD.Reservatorio[indice].End_mestre = 200;
					IL_306:
					goto IL_3D2;
					IL_30B:
					num2 = 51;
					Mod_MD.Reservatorio[indice].End_repetidora = 100;
					IL_321:
					goto IL_3D2;
					IL_326:
					num2 = 54;
					Mod_MD.Reservatorio[indice].Intervalo_filtro = 500;
					IL_33F:
					goto IL_3D2;
					IL_344:
					num2 = 57;
					Mod_MD.Reservatorio[indice].Tamanho_filtro = 5;
					IL_359:
					goto IL_3D2;
					IL_35B:
					num2 = 60;
					Mod_MD.Reservatorio[indice].Num_repetidoras = 0;
					IL_370:
					goto IL_3D2;
					IL_372:
					num2 = 63;
					Mod_MD.Reservatorio[indice].Offset_sensor = 0;
					IL_387:
					goto IL_3D2;
					IL_389:
					num2 = 66;
					Mod_MD.Reservatorio[indice].Range_sensor = 1000;
					IL_3A2:
					goto IL_3D2;
					IL_3A4:
					num2 = 69;
					Mod_MD.Reservatorio[indice].Tempo_ptt = 20;
					IL_3BA:
					goto IL_3D2;
					IL_3BC:
					num2 = 72;
					Mod_MD.Reservatorio[indice].Tempo_tx_ponto = 30;
					IL_3D2:
					num2 = 75;
					ProjectData.ClearProjectError();
					if (num4 != 0)
					{
											}
					throw ProjectData.CreateProjectError(-2146828268);
					IL_3EA:
					goto IL_579;
					IL_3EF:
					num5 = num4;
					goto IL_3F7;
					IL_3F3:;
				}
				num5 = num4 + 1;
				IL_3F7:
				num4 = 0;IL_533:
				goto IL_56E;
				IL_535:
				num4 = num2;
								IL_54B:;
			}
			catch (Exception) { }
			IL_56E:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_579:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x003C8F00 File Offset: 0x003C7300
		public void Atualiza_tela_MD101_repetidora(int indice)
		{
			if (Mod_MD.Reservatorio[indice].Hab_repetidora == 21856)
			{
				this.CheckBox_hab_rep.Checked = true;
				this.Grupo_end_rep.Enabled = true;
				this.Valor_end_est_rep.Enabled = true;
				this.Label_end_rep.Enabled = true;
				this.Valor_num_est_rep.Enabled = true;
				this.Label_num_est_rep.Enabled = true;
			}
			else
			{
				this.CheckBox_hab_rep.Checked = false;
				this.Grupo_end_rep.Enabled = false;
				this.Valor_end_est_rep.Enabled = false;
				this.Label_end_rep.Enabled = false;
				this.Valor_num_est_rep.Enabled = false;
				this.Label_num_est_rep.Enabled = false;
			}
			this.Atualiza_tela_MD101_repetidora_enderecos(indice);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x003C8FC0 File Offset: 0x003C73C0
		public void Atualiza_tela_MD101_operacao(int indice)
		{
			if (Mod_MD.Reservatorio[indice].Modo_operacao == 21848)
			{
				this.Valor_int_tx.Enabled = false;
				this.Label_int_tx.Enabled = false;
			}
			else
			{
				this.Valor_int_tx.Enabled = true;
				this.Label_int_tx.Enabled = true;
			}
			this.Combo_modo.SelectedIndex = checked(Mod_MD.Reservatorio[indice].Modo_operacao - 21846);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x003C9038 File Offset: 0x003C7438
		public void Atualiza_tela_MD101_medida(int indice)
		{
			if (Mod_MD.Reservatorio[indice].Tipo_medida == 21872)
			{
				this.Sensor_range.Enabled = false;
				this.Label_sensor_range.Enabled = false;
				this.Reservatorio_altura.Enabled = false;
				this.Label_reservatorio_altura.Enabled = false;
				this.Sensor_offset.Enabled = false;
				this.Label_sensor_offset.Enabled = false;
				this.Filtro_intervalo.Enabled = false;
				this.Label_filtro_intervalo.Enabled = false;
				this.Label_filtro_tamanho.Enabled = false;
				this.Filtro_tamanho.Enabled = false;
			}
			else
			{
				this.Sensor_range.Enabled = true;
				this.Label_sensor_range.Enabled = true;
				this.Reservatorio_altura.Enabled = true;
				this.Label_reservatorio_altura.Enabled = true;
				this.Sensor_offset.Enabled = true;
				this.Label_sensor_offset.Enabled = true;
				this.Filtro_intervalo.Enabled = true;
				this.Label_filtro_intervalo.Enabled = true;
				this.Label_filtro_tamanho.Enabled = true;
				this.Filtro_tamanho.Enabled = true;
			}
			this.Combo_nivel.SelectedIndex = checked(Mod_MD.Reservatorio[indice].Tipo_medida - 21872);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x003C9170 File Offset: 0x003C7570
		public void Atualiza_tela_MD101_repetidora_enderecos(int indice)
		{
			int num = 0;
			int num4 = 0;
			object obj = null;
			try
			{
				IL_00:
				ProjectData.ClearProjectError();
				num = 2;
				IL_08:
				int num2 = 2;
				if (this.passo >= 4)
				{
									}
				IL_17:
				num2 = 3;
				int num3 = 0;
				IL_1C:
				num2 = 4;
				int num5;
				checked
				{
					this.Valor_end_rep_3.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[3 + this.passo * 12]);
					IL_4B:
					num2 = 5;
					num3 = 1;
					IL_50:
					num2 = 6;
					this.Valor_end_rep_4.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[4 + this.passo * 12]);
					IL_7F:
					num2 = 7;
					num3 = 2;
					IL_84:
					num2 = 8;
					this.Valor_end_rep_5.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[5 + this.passo * 12]);
					IL_B3:
					num2 = 9;
					num3 = 3;
					IL_B9:
					num2 = 10;
					this.Valor_end_rep_6.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[6 + this.passo * 12]);
					IL_E9:
					num2 = 11;
					num3 = 4;
					IL_EF:
					num2 = 12;
					this.Valor_end_rep_7.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[7 + this.passo * 12]);
					IL_11F:
					num2 = 13;
					num3 = 5;
					IL_125:
					num2 = 14;
					this.Valor_end_rep_8.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[8 + this.passo * 12]);
					IL_155:
					num2 = 15;
					num3 = 6;
					IL_15B:
					num2 = 16;
					this.Valor_end_rep_9.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[9 + this.passo * 12]);
					IL_18C:
					num2 = 17;
					num3 = 7;
					IL_192:
					num2 = 18;
					this.Valor_end_rep_10.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[10 + this.passo * 12]);
					IL_1C3:
					num2 = 19;
					num3 = 8;
					IL_1C9:
					num2 = 20;
					this.Valor_end_rep_11.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[11 + this.passo * 12]);
					IL_1FA:
					num2 = 21;
					num3 = 9;
					IL_201:
					num2 = 22;
					this.Valor_end_rep_12.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[12 + this.passo * 12]);
					IL_232:
					num2 = 24;
					num3 = 10;
					IL_239:
					num2 = 25;
					this.Valor_end_rep_1.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[1 + this.passo * 12]);
					IL_269:
					num2 = 26;
					num3 = 11;
					IL_270:
					num2 = 27;
					this.Valor_end_rep_2.Text = Conversions.ToString(Mod_MD.Reservatorio[indice].Repetidoras[2 + this.passo * 12]);
					IL_2A0:
					num2 = 28;
					this.Label_end_rep_1.Text = Strings.Format(1 + this.passo * 12, "00:");
					IL_2C9:
					num2 = 29;
					this.Label_end_rep_2.Text = Strings.Format(2 + this.passo * 12, "00:");
					IL_2F2:
					num2 = 30;
					this.Label_end_rep_3.Text = Strings.Format(3 + this.passo * 12, "00:");
					IL_31B:
					num2 = 31;
					this.Label_end_rep_4.Text = Strings.Format(4 + this.passo * 12, "00:");
					IL_344:
					num2 = 32;
					this.Label_end_rep_5.Text = Strings.Format(5 + this.passo * 12, "00:");
					IL_36D:
					num2 = 33;
					this.Label_end_rep_6.Text = Strings.Format(6 + this.passo * 12, "00:");
					IL_396:
					num2 = 34;
					this.Label_end_rep_7.Text = Strings.Format(7 + this.passo * 12, "00:");
					IL_3BF:
					num2 = 35;
					this.Label_end_rep_8.Text = Strings.Format(8 + this.passo * 12, "00:");
					IL_3E8:
					num2 = 36;
					this.Label_end_rep_9.Text = Strings.Format(9 + this.passo * 12, "00:");
					IL_412:
					num2 = 37;
					this.Label_end_rep_10.Text = Strings.Format(10 + this.passo * 12, "00:");
					IL_43C:
					num2 = 38;
					this.Label_end_rep_11.Text = Strings.Format(11 + this.passo * 12, "00:");
					IL_466:
					num2 = 39;
					this.Label_end_rep_12.Text = Strings.Format(12 + this.passo * 12, "00:");
					IL_490:
					num2 = 40;
					int num_repetidoras = Mod_MD.Reservatorio[indice].Num_repetidoras;
					IL_4A5:
					num2 = 41;
					if (num_repetidoras - this.passo * 12 - 0 <= 0)
					{
											}
					IL_4B9:
					num2 = 42;
					this.Label_end_rep_1.Visible = true;
					IL_4C9:
					num2 = 43;
					this.Valor_end_rep_1.Visible = true;
					IL_4D9:
					goto IL_4FF;
					IL_4DB:
					num2 = 45;
					IL_4DF:
					num2 = 46;
					this.Label_end_rep_1.Visible = false;
					IL_4EF:
					num2 = 47;
					this.Valor_end_rep_1.Visible = false;
					IL_4FF:
					num2 = 49;
					if (num_repetidoras - this.passo * 12 - 1 <= 0)
					{
											}
					IL_513:
					num2 = 50;
					this.Label_end_rep_2.Visible = true;
					IL_523:
					num2 = 51;
					this.Valor_end_rep_2.Visible = true;
					IL_533:
					goto IL_559;
					IL_535:
					num2 = 53;
					IL_539:
					num2 = 54;
					this.Label_end_rep_2.Visible = false;
					IL_549:
					num2 = 55;
					this.Valor_end_rep_2.Visible = false;
					IL_559:
					num2 = 57;
					if (num_repetidoras - this.passo * 12 - 2 <= 0)
					{
											}
					IL_56D:
					num2 = 58;
					this.Label_end_rep_3.Visible = true;
					IL_57D:
					num2 = 59;
					this.Valor_end_rep_3.Visible = true;
					IL_58D:
					goto IL_5B3;
					IL_58F:
					num2 = 61;
					IL_593:
					num2 = 62;
					this.Label_end_rep_3.Visible = false;
					IL_5A3:
					num2 = 63;
					this.Valor_end_rep_3.Visible = false;
					IL_5B3:
					num2 = 65;
					if (num_repetidoras - this.passo * 12 - 3 <= 0)
					{
											}
					IL_5C7:
					num2 = 66;
					this.Label_end_rep_4.Visible = true;
					IL_5D7:
					num2 = 67;
					this.Valor_end_rep_4.Visible = true;
					IL_5E7:
					goto IL_60D;
					IL_5E9:
					num2 = 69;
					IL_5ED:
					num2 = 70;
					this.Label_end_rep_4.Visible = false;
					IL_5FD:
					num2 = 71;
					this.Valor_end_rep_4.Visible = false;
					IL_60D:
					num2 = 73;
					if (num_repetidoras - this.passo * 12 - 4 <= 0)
					{
											}
					IL_621:
					num2 = 74;
					this.Label_end_rep_5.Visible = true;
					IL_631:
					num2 = 75;
					this.Valor_end_rep_5.Visible = true;
					IL_641:
					goto IL_667;
					IL_643:
					num2 = 77;
					IL_647:
					num2 = 78;
					this.Label_end_rep_5.Visible = false;
					IL_657:
					num2 = 79;
					this.Valor_end_rep_5.Visible = false;
					IL_667:
					num2 = 81;
					if (num_repetidoras - this.passo * 12 - 5 <= 0)
					{
											}
					IL_67B:
					num2 = 82;
					this.Label_end_rep_6.Visible = true;
					IL_68B:
					num2 = 83;
					this.Valor_end_rep_6.Visible = true;
					IL_69B:
					goto IL_6C1;
					IL_69D:
					num2 = 85;
					IL_6A1:
					num2 = 86;
					this.Label_end_rep_6.Visible = false;
					IL_6B1:
					num2 = 87;
					this.Valor_end_rep_6.Visible = false;
					IL_6C1:
					num2 = 89;
					if (num_repetidoras - this.passo * 12 - 6 <= 0)
					{
											}
					IL_6D5:
					num2 = 90;
					this.Label_end_rep_7.Visible = true;
					IL_6E5:
					num2 = 91;
					this.Valor_end_rep_7.Visible = true;
					IL_6F5:
					goto IL_71B;
					IL_6F7:
					num2 = 93;
					IL_6FB:
					num2 = 94;
					this.Label_end_rep_7.Visible = false;
					IL_70B:
					num2 = 95;
					this.Valor_end_rep_7.Visible = false;
					IL_71B:
					num2 = 97;
					if (num_repetidoras - this.passo * 12 - 7 <= 0)
					{
											}
					IL_72F:
					num2 = 98;
					this.Label_end_rep_8.Visible = true;
					IL_73F:
					num2 = 99;
					this.Valor_end_rep_8.Visible = true;
					IL_74F:
					goto IL_775;
					IL_751:
					num2 = 101;
					IL_755:
					num2 = 102;
					this.Label_end_rep_8.Visible = false;
					IL_765:
					num2 = 103;
					this.Valor_end_rep_8.Visible = false;
					IL_775:
					num2 = 105;
					if (num_repetidoras - this.passo * 12 - 8 <= 0)
					{
											}
					IL_789:
					num2 = 106;
					this.Label_end_rep_9.Visible = true;
					IL_799:
					num2 = 107;
					this.Valor_end_rep_9.Visible = true;
					IL_7A9:
					goto IL_7CF;
					IL_7AB:
					num2 = 109;
					IL_7AF:
					num2 = 110;
					this.Label_end_rep_9.Visible = false;
					IL_7BF:
					num2 = 111;
					this.Valor_end_rep_9.Visible = false;
					IL_7CF:
					num2 = 113;
					if (num_repetidoras - this.passo * 12 - 9 <= 0)
					{
											}
					IL_7E4:
					num2 = 114;
					this.Label_end_rep_10.Visible = true;
					IL_7F4:
					num2 = 115;
					this.Valor_end_rep_10.Visible = true;
					IL_804:
					goto IL_82A;
					IL_806:
					num2 = 117;
					IL_80A:
					num2 = 118;
					this.Label_end_rep_10.Visible = false;
					IL_81A:
					num2 = 119;
					this.Valor_end_rep_10.Visible = false;
					IL_82A:
					num2 = 121;
					if (num_repetidoras - this.passo * 12 - 10 <= 0)
					{
											}
					IL_83F:
					num2 = 122;
					this.Label_end_rep_11.Visible = true;
					IL_84F:
					num2 = 123;
					this.Valor_end_rep_11.Visible = true;
					IL_85F:
					goto IL_885;
					IL_861:
					num2 = 125;
					IL_865:
					num2 = 126;
					this.Label_end_rep_11.Visible = false;
					IL_875:
					num2 = 127;
					this.Valor_end_rep_11.Visible = false;
					IL_885:
					num2 = 129;
					if (num_repetidoras - this.passo * 12 - 11 <= 0)
					{
											}
					IL_89D:
					num2 = 130;
					this.Label_end_rep_12.Visible = true;
					IL_8B0:
					num2 = 131;
					this.Valor_end_rep_12.Visible = true;
					IL_8C3:
					goto IL_EB7;
					IL_8C8:
					num2 = 133;
					IL_8CF:
					num2 = 134;
					this.Label_end_rep_12.Visible = false;
					IL_8E2:
					num2 = 135;
					this.Valor_end_rep_12.Visible = false;
					IL_8F5:
					goto IL_EB7;
					IL_8FA:
					num2 = 138;
					MsgBoxResult msgBoxResult = Interaction.MsgBox("Existem valores não compatíveis com os parâmetro desta tela !\r\nCarregar configuração Default ?", (MsgBoxStyle)36, "Atenção");
					IL_913:
					num2 = 139;
					if (msgBoxResult != (MsgBoxResult)6)
					{
											}
					IL_91E:
					num2 = 140;
					Mod_MD.CarregaConfiguracaoDefault_MD101(indice);
					IL_92B:
					goto IL_B5B;
					IL_930:
					num2 = 142;
					IL_937:
					num2 = 143;goto IL_B5B;
					IL_979:
					num2 = 147;
					Mod_MD.Reservatorio[indice].Repetidoras[3 + this.passo * 12] = 0;
					IL_99D:
					goto IL_B5B;
					IL_9A2:
					num2 = 150;
					Mod_MD.Reservatorio[indice].Repetidoras[4 + this.passo * 12] = 0;
					IL_9C6:
					goto IL_B5B;
					IL_9CB:
					num2 = 153;
					Mod_MD.Reservatorio[indice].Repetidoras[5 + this.passo * 12] = 0;
					IL_9EF:
					goto IL_B5B;
					IL_9F4:
					num2 = 156;
					Mod_MD.Reservatorio[indice].Repetidoras[6 + this.passo * 12] = 0;
					IL_A18:
					goto IL_B5B;
					IL_A1D:
					num2 = 159;
					Mod_MD.Reservatorio[indice].Repetidoras[7 + this.passo * 12] = 0;
					IL_A41:
					goto IL_B5B;
					IL_A46:
					num2 = 162;
					Mod_MD.Reservatorio[indice].Repetidoras[8 + this.passo * 12] = 0;
					IL_A6A:
					goto IL_B5B;
					IL_A6F:
					num2 = 165;
					Mod_MD.Reservatorio[indice].Repetidoras[9 + this.passo * 12] = 0;
					IL_A94:
					goto IL_B5B;
					IL_A99:
					num2 = 168;
					Mod_MD.Reservatorio[indice].Repetidoras[10 + this.passo * 12] = 0;
					IL_ABE:
					goto IL_B5B;
					IL_AC3:
					num2 = 171;
					Mod_MD.Reservatorio[indice].Repetidoras[11 + this.passo * 12] = 0;
					IL_AE8:
					goto IL_B5B;
					IL_AEA:
					num2 = 174;
					Mod_MD.Reservatorio[indice].Repetidoras[12 + this.passo * 12] = 0;
					IL_B0F:
					goto IL_B5B;
					IL_B11:
					num2 = 177;
					Mod_MD.Reservatorio[indice].Repetidoras[1 + this.passo * 12] = 0;
					IL_B35:
					goto IL_B5B;
					IL_B37:
					num2 = 180;
					Mod_MD.Reservatorio[indice].Repetidoras[2 + this.passo * 12] = 0;
					IL_B5B:
					num2 = 183;
					ProjectData.ClearProjectError();
					if (num4 != 0)
					{
											}
					throw ProjectData.CreateProjectError(-2146828268);
					IL_B76:
					goto IL_EB7;
					IL_B7B:
					num5 = num4;
					goto IL_B83;
					IL_B7F:;
				}
				num5 = num4 + 1;
				IL_B83:
				num4 = 0;IL_E6F:
				goto IL_EAC;
				IL_E71:
				num4 = num2;
								IL_E88:;
			}
			catch (Exception) { }
			IL_EAC:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_EB7:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x003CA05C File Offset: 0x003C845C
		public void Limpa_dados_repetidora_MD101(object indice, object end_inicial)
		{
			checked
			{
				for (int i = Conversions.ToInteger(Operators.AddObject(end_inicial, 1)); i <= 50; i++)
				{
					Mod_MD.Reservatorio[Conversions.ToInteger(indice)].Repetidoras[i] = 0;
				}
			}
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x003CA0A0 File Offset: 0x003C84A0
		private void CheckBox_hab_rep_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null), true, false))
			{
				Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Hab_repetidora = 21856;
			}
			else
			{
				Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Hab_repetidora = 0;
			}
			this.Atualiza_tela_MD101_repetidora(Mod_MD.Controle.Estacao);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x003CA11C File Offset: 0x003C851C
		private void Combo_modo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Modo_operacao = Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21846));
			this.Atualiza_tela_MD101_operacao(Mod_MD.Controle.Estacao);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x003CA17C File Offset: 0x003C857C
		private void Combo_nivel_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Tipo_medida = Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21872));
			this.Atualiza_tela_MD101_medida(Mod_MD.Controle.Estacao);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x003CA1DC File Offset: 0x003C85DC
		private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
			this.passo = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			this.Atualiza_tela_MD101_repetidora_enderecos(Mod_MD.Controle.Estacao);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x003CA210 File Offset: 0x003C8610
		[MethodImpl(72)]
		private void CarregarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.OpenFileDialog1.Filter = "Arquivo de configuração de equipamento|*.V1X";
			this.OpenFileDialog1.InitialDirectory = "c:\\";
			if (this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if (Operators.CompareString(this.OpenFileDialog1.FileName, "", false) != 0)
				{
					FileSystem.FileOpen(1, this.OpenFileDialog1.FileName, (OpenMode)4, (OpenAccess)(-1), (OpenShare)(-1), 270);
					int num = 1;
					Mod_MD.DADOS_EQUIP_MD_101_CONFIG[] reservatorio = Mod_MD.Reservatorio;
					Mod_MD.DADOS_EQUIP_MD_101_CONFIG[] array = reservatorio;
					int num2 = 1;
					ValueType valueType = array[num2];
					FileSystem.FileGet(num, ref valueType, -1L);
					Mod_MD.DADOS_EQUIP_MD_101_CONFIG[] array2 = reservatorio;
					int num3 = num2;
					ValueType valueType2 = valueType;
					Mod_MD.DADOS_EQUIP_MD_101_CONFIG dados_EQUIP_MD_101_CONFIG = default(Mod_MD.DADOS_EQUIP_MD_101_CONFIG);
					array2[num3] = ((valueType2 != null) ? ((Mod_MD.DADOS_EQUIP_MD_101_CONFIG)valueType2) : dados_EQUIP_MD_101_CONFIG);
					FileSystem.FileClose(new int[]
					{
						1
					});
				}
				this.Atualiza_tela_MD101(Mod_MD.Controle.Estacao);
			}
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x003CA2E8 File Offset: 0x003C86E8
		[MethodImpl(72)]
		private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Mod_MD.Reservatorio[1].Versao = Geral.Config_geral.Versao;
			this.SaveFileDialog1.Filter = "Arquivo de configuração de equipamento|*.V1X";
			this.SaveFileDialog1.InitialDirectory = "c:\\";
			if (this.SaveFileDialog1.ShowDialog() == DialogResult.OK && Operators.CompareString(this.SaveFileDialog1.FileName, "", false) != 0)
			{
				FileSystem.FileOpen(1, this.SaveFileDialog1.FileName, (OpenMode)4, (OpenAccess)(-1), (OpenShare)(-1), 300);
				FileSystem.FilePut(1, Mod_MD.Reservatorio[1], -1L);
				FileSystem.FileClose(new int[]
				{
					1
				});
			}
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x003CA3A0 File Offset: 0x003C87A0
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
					Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Repetidoras[1 + this.passo * 12] = num;
				}
			}
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x003CA404 File Offset: 0x003C8804
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
					Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Repetidoras[2 + this.passo * 12] = num;
				}
			}
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x003CA468 File Offset: 0x003C8868
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
					Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Repetidoras[3 + this.passo * 12] = num;
				}
			}
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x003CA4CC File Offset: 0x003C88CC
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
					Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Repetidoras[4 + this.passo * 12] = num;
				}
			}
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x003CA530 File Offset: 0x003C8930
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
					Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Repetidoras[5 + this.passo * 12] = num;
				}
			}
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x003CA594 File Offset: 0x003C8994
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
					Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Repetidoras[6 + this.passo * 12] = num;
				}
			}
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x003CA5F8 File Offset: 0x003C89F8
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
					Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Repetidoras[7 + this.passo * 12] = num;
				}
			}
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x003CA65C File Offset: 0x003C8A5C
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
					Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Repetidoras[8 + this.passo * 12] = num;
				}
			}
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x003CA6C0 File Offset: 0x003C8AC0
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
					Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Repetidoras[9 + this.passo * 12] = num;
				}
			}
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x003CA724 File Offset: 0x003C8B24
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
					Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Repetidoras[10 + this.passo * 12] = num;
				}
			}
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x003CA788 File Offset: 0x003C8B88
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
					Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Repetidoras[11 + this.passo * 12] = num;
				}
			}
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x003CA7EC File Offset: 0x003C8BEC
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
					Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Repetidoras[12 + this.passo * 12] = num;
				}
			}
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x003CA850 File Offset: 0x003C8C50
		private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Limpa_estrutura_MD101(Mod_MD.Controle.Estacao);
			Mod_MD.CarregaConfiguracaoDefault_MD101(Mod_MD.Controle.Estacao);
			this.Atualiza_tela_MD101(Mod_MD.Controle.Estacao);
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x003CA884 File Offset: 0x003C8C84
		public void Mensagem_MD101(string msg, int cor)
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

		// Token: 0x06001B9F RID: 7071 RVA: 0x003CA8E8 File Offset: 0x003C8CE8
		private void Ler_conf_md_101_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			this.Ler_conf_md_101.Enabled = false;
			this.Mensagem_MD101("Aguarde ...", 2);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Leitura_pagina(100, 255, 12);
			this.Mensagem_MD101(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Ler_conf_md_101.Enabled = true;
				return;
			}
			Mod_MD.Atualiza_dados_MD101(Mod_MD.Controle.Estacao, 100);
			ctrl_RESP_ = Mod_MD.Leitura_pagina(512, Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].End_estacao, 52);
			this.Mensagem_MD101(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Ler_conf_md_101.Enabled = true;
				return;
			}
			Mod_MD.Atualiza_dados_MD101(Mod_MD.Controle.Estacao, 512);
			this.Mensagem_MD101("Leitura executada com sucesso", 0);
			this.Atualiza_tela_MD101(Mod_MD.Controle.Estacao);
			this.Ler_conf_md_101.Enabled = true;
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x003CAA00 File Offset: 0x003C8E00
		private void Esc_conf_md_101_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			this.Esc_conf_md_101.Enabled = false;
			this.Mensagem_MD101("Aguarde ...", 2);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD101(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Esc_conf_md_101.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(100, 1);
			this.Mensagem_MD101(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Esc_conf_md_101.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD101(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Esc_conf_md_101.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD101(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Esc_conf_md_101.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(512, 1);
			this.Mensagem_MD101(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Esc_conf_md_101.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD101(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Esc_conf_md_101.Enabled = true;
				return;
			}
			this.Mensagem_MD101("Programação concluída com sucesso", 0);
			this.Esc_conf_md_101.Enabled = true;
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x003CAB94 File Offset: 0x003C8F94
		private void Valor_end_est_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].End_estacao = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x003CABCC File Offset: 0x003C8FCC
		private void Valor_end_mestre_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].End_mestre = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x003CAC04 File Offset: 0x003C9004
		private void Valor_int_tx_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Tempo_tx_ponto = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x003CAC3C File Offset: 0x003C903C
		private void Valor_temp_ptt_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Tempo_ptt = Conversions.ToInteger(Operators.DivideObject(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null), 10));
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x003CAC88 File Offset: 0x003C9088
		private void Sensor_range_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Range_sensor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x003CACC0 File Offset: 0x003C90C0
		private void Reservatorio_altura_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Altura_sensor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x003CACF8 File Offset: 0x003C90F8
		private void Sensor_offset_ValueChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null), 0, false))
			{
				Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Offset_sensor = Conversions.ToInteger(Operators.SubtractObject(1000, NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null)));
			}
			else
			{
				Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Offset_sensor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			}
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x003CADA0 File Offset: 0x003C91A0
		private void Filtro_intervalo_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Intervalo_filtro = Conversions.ToInteger(Operators.DivideObject(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null), 10));
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x003CADEC File Offset: 0x003C91EC
		private void Filtro_tamanho_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Tamanho_filtro = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x003CAE24 File Offset: 0x003C9224
		private void Valor_end_est_rep_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].End_repetidora = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x003CAE5C File Offset: 0x003C925C
		private void Valor_num_est_rep_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Reservatorio[Mod_MD.Controle.Estacao].Num_repetidoras = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Limpa_dados_repetidora_MD101(Mod_MD.Controle.Estacao, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null)));
			this.Atualiza_tela_MD101_repetidora_enderecos(Mod_MD.Controle.Estacao);
		}

		// Token: 0x040014CB RID: 5323
		[AccessedThroughProperty("grupo_comunicacao")]
		private GroupBox _grupo_comunicacao;

		// Token: 0x040014CC RID: 5324
		[AccessedThroughProperty("Label_end_mestre")]
		private Label _Label_end_mestre;

		// Token: 0x040014CD RID: 5325
		[AccessedThroughProperty("Label_end_est")]
		private Label _Label_end_est;

		// Token: 0x040014CE RID: 5326
		[AccessedThroughProperty("Grupo_aquisicao")]
		private GroupBox _Grupo_aquisicao;

		// Token: 0x040014CF RID: 5327
		[AccessedThroughProperty("Label_sensor_range")]
		private Label _Label_sensor_range;

		// Token: 0x040014D0 RID: 5328
		[AccessedThroughProperty("Label_tipo_leitura")]
		private Label _Label_tipo_leitura;

		// Token: 0x040014D1 RID: 5329
		[AccessedThroughProperty("Grupo_repetidora")]
		private GroupBox _Grupo_repetidora;

		// Token: 0x040014D2 RID: 5330
		[AccessedThroughProperty("Label_num_est_rep")]
		private Label _Label_num_est_rep;

		// Token: 0x040014D3 RID: 5331
		[AccessedThroughProperty("Label_end_rep")]
		private Label _Label_end_rep;

		// Token: 0x040014D4 RID: 5332
		[AccessedThroughProperty("CheckBox_hab_rep")]
		private CheckBox _CheckBox_hab_rep;

		// Token: 0x040014D5 RID: 5333
		[AccessedThroughProperty("Label_tempo_ptt")]
		private Label _Label_tempo_ptt;

		// Token: 0x040014D6 RID: 5334
		[AccessedThroughProperty("Label_int_tx")]
		private Label _Label_int_tx;

		// Token: 0x040014D7 RID: 5335
		[AccessedThroughProperty("Combo_modo")]
		private ComboBox _Combo_modo;

		// Token: 0x040014D8 RID: 5336
		[AccessedThroughProperty("Label_modo_ope")]
		private Label _Label_modo_ope;

		// Token: 0x040014D9 RID: 5337
		[AccessedThroughProperty("Combo_nivel")]
		private ComboBox _Combo_nivel;

		// Token: 0x040014DA RID: 5338
		[AccessedThroughProperty("Label_filtro_tamanho")]
		private Label _Label_filtro_tamanho;

		// Token: 0x040014DB RID: 5339
		[AccessedThroughProperty("Label_filtro_intervalo")]
		private Label _Label_filtro_intervalo;

		// Token: 0x040014DC RID: 5340
		[AccessedThroughProperty("Label_sensor_offset")]
		private Label _Label_sensor_offset;

		// Token: 0x040014DD RID: 5341
		[AccessedThroughProperty("Label_reservatorio_altura")]
		private Label _Label_reservatorio_altura;

		// Token: 0x040014DE RID: 5342
		[AccessedThroughProperty("Grupo_end_rep")]
		private GroupBox _Grupo_end_rep;

		// Token: 0x040014DF RID: 5343
		[AccessedThroughProperty("Label_end_rep_6")]
		private Label _Label_end_rep_6;

		// Token: 0x040014E0 RID: 5344
		[AccessedThroughProperty("Valor_end_rep_6")]
		private TextBox _Valor_end_rep_6;

		// Token: 0x040014E1 RID: 5345
		[AccessedThroughProperty("Label_end_rep_3")]
		private Label _Label_end_rep_3;

		// Token: 0x040014E2 RID: 5346
		[AccessedThroughProperty("Valor_end_rep_3")]
		private TextBox _Valor_end_rep_3;

		// Token: 0x040014E3 RID: 5347
		[AccessedThroughProperty("Label_end_rep_9")]
		private Label _Label_end_rep_9;

		// Token: 0x040014E4 RID: 5348
		[AccessedThroughProperty("Valor_end_rep_9")]
		private TextBox _Valor_end_rep_9;

		// Token: 0x040014E5 RID: 5349
		[AccessedThroughProperty("Label_end_rep_8")]
		private Label _Label_end_rep_8;

		// Token: 0x040014E6 RID: 5350
		[AccessedThroughProperty("Valor_end_rep_8")]
		private TextBox _Valor_end_rep_8;

		// Token: 0x040014E7 RID: 5351
		[AccessedThroughProperty("Label_end_rep_5")]
		private Label _Label_end_rep_5;

		// Token: 0x040014E8 RID: 5352
		[AccessedThroughProperty("Valor_end_rep_5")]
		private TextBox _Valor_end_rep_5;

		// Token: 0x040014E9 RID: 5353
		[AccessedThroughProperty("Label_end_rep_2")]
		private Label _Label_end_rep_2;

		// Token: 0x040014EA RID: 5354
		[AccessedThroughProperty("Valor_end_rep_2")]
		private TextBox _Valor_end_rep_2;

		// Token: 0x040014EB RID: 5355
		[AccessedThroughProperty("Label_end_rep_10")]
		private Label _Label_end_rep_10;

		// Token: 0x040014EC RID: 5356
		[AccessedThroughProperty("Valor_end_rep_10")]
		private TextBox _Valor_end_rep_10;

		// Token: 0x040014ED RID: 5357
		[AccessedThroughProperty("Label_end_rep_7")]
		private Label _Label_end_rep_7;

		// Token: 0x040014EE RID: 5358
		[AccessedThroughProperty("Label_end_rep_4")]
		private Label _Label_end_rep_4;

		// Token: 0x040014EF RID: 5359
		[AccessedThroughProperty("Valor_end_rep_7")]
		private TextBox _Valor_end_rep_7;

		// Token: 0x040014F0 RID: 5360
		[AccessedThroughProperty("Valor_end_rep_4")]
		private TextBox _Valor_end_rep_4;

		// Token: 0x040014F1 RID: 5361
		[AccessedThroughProperty("Label_end_rep_1")]
		private Label _Label_end_rep_1;

		// Token: 0x040014F2 RID: 5362
		[AccessedThroughProperty("Valor_end_rep_1")]
		private TextBox _Valor_end_rep_1;

		// Token: 0x040014F3 RID: 5363
		[AccessedThroughProperty("Label_end_rep_12")]
		private Label _Label_end_rep_12;

		// Token: 0x040014F4 RID: 5364
		[AccessedThroughProperty("Valor_end_rep_12")]
		private TextBox _Valor_end_rep_12;

		// Token: 0x040014F5 RID: 5365
		[AccessedThroughProperty("Label_end_rep_11")]
		private Label _Label_end_rep_11;

		// Token: 0x040014F6 RID: 5366
		[AccessedThroughProperty("Valor_end_rep_11")]
		private TextBox _Valor_end_rep_11;

		// Token: 0x040014F7 RID: 5367
		[AccessedThroughProperty("VScrollBar1")]
		private VScrollBar _VScrollBar1;

		// Token: 0x040014F8 RID: 5368
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x040014F9 RID: 5369
		[AccessedThroughProperty("ArquivoToolStripMenuItem")]
		private ToolStripMenuItem _ArquivoToolStripMenuItem;

		// Token: 0x040014FA RID: 5370
		[AccessedThroughProperty("CarregarToolStripMenuItem")]
		private ToolStripMenuItem _CarregarToolStripMenuItem;

		// Token: 0x040014FB RID: 5371
		[AccessedThroughProperty("NovoToolStripMenuItem")]
		private ToolStripMenuItem _NovoToolStripMenuItem;

		// Token: 0x040014FC RID: 5372
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		// Token: 0x040014FD RID: 5373
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog _OpenFileDialog1;

		// Token: 0x040014FE RID: 5374
		[AccessedThroughProperty("SaveFileDialog1")]
		private SaveFileDialog _SaveFileDialog1;

		// Token: 0x040014FF RID: 5375
		[AccessedThroughProperty("Ler_conf_md_101")]
		private Button _Ler_conf_md_101;

		// Token: 0x04001500 RID: 5376
		[AccessedThroughProperty("SalvarToolStripMenuItem")]
		private ToolStripMenuItem _SalvarToolStripMenuItem;

		// Token: 0x04001501 RID: 5377
		[AccessedThroughProperty("Grupo_ctrl")]
		private GroupBox _Grupo_ctrl;

		// Token: 0x04001502 RID: 5378
		[AccessedThroughProperty("Box_Msg")]
		private TextBox _Box_Msg;

		// Token: 0x04001503 RID: 5379
		[AccessedThroughProperty("Esc_conf_md_101")]
		private Button _Esc_conf_md_101;

		// Token: 0x04001504 RID: 5380
		[AccessedThroughProperty("Valor_end_est")]
		private NumericUpDown _Valor_end_est;

		// Token: 0x04001505 RID: 5381
		[AccessedThroughProperty("Valor_end_mestre")]
		private NumericUpDown _Valor_end_mestre;

		// Token: 0x04001506 RID: 5382
		[AccessedThroughProperty("Valor_int_tx")]
		private NumericUpDown _Valor_int_tx;

		// Token: 0x04001507 RID: 5383
		[AccessedThroughProperty("Valor_temp_ptt")]
		private NumericUpDown _Valor_temp_ptt;

		// Token: 0x04001508 RID: 5384
		[AccessedThroughProperty("Sensor_range")]
		private NumericUpDown _Sensor_range;

		// Token: 0x04001509 RID: 5385
		[AccessedThroughProperty("Reservatorio_altura")]
		private NumericUpDown _Reservatorio_altura;

		// Token: 0x0400150A RID: 5386
		[AccessedThroughProperty("Sensor_offset")]
		private NumericUpDown _Sensor_offset;

		// Token: 0x0400150B RID: 5387
		[AccessedThroughProperty("Filtro_intervalo")]
		private NumericUpDown _Filtro_intervalo;

		// Token: 0x0400150C RID: 5388
		[AccessedThroughProperty("Filtro_tamanho")]
		private NumericUpDown _Filtro_tamanho;

		// Token: 0x0400150D RID: 5389
		[AccessedThroughProperty("Valor_end_est_rep")]
		private NumericUpDown _Valor_end_est_rep;

		// Token: 0x0400150E RID: 5390
		[AccessedThroughProperty("Valor_num_est_rep")]
		private NumericUpDown _Valor_num_est_rep;

		// Token: 0x0400150F RID: 5391
		private int passo;
	}
}
