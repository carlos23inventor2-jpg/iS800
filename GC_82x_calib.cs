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
	// Token: 0x02000039 RID: 57
	[DesignerGenerated]
	public partial class GC_82x_calib : Form
	{
		// Token: 0x06000BF0 RID: 3056 RVA: 0x002F1C08 File Offset: 0x002F0008
		public GC_82x_calib()
		{
			base.Load += new EventHandler(this.GC_82x_calib_Load);
			this.InitializeComponent();
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x002F3660 File Offset: 0x002F1A60
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x002F3674 File Offset: 0x002F1A74
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

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x002F3680 File Offset: 0x002F1A80
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x002F3694 File Offset: 0x002F1A94
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

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x002F36A0 File Offset: 0x002F1AA0
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x002F36B4 File Offset: 0x002F1AB4
		internal virtual Button bt_busca
		{
			get
			{
				return this._bt_busca;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bt_busca_Click);
				if (this._bt_busca != null)
				{
					this._bt_busca.Click -= eventHandler;
				}
				this._bt_busca = value;
				if (this._bt_busca != null)
				{
					this._bt_busca.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x002F3700 File Offset: 0x002F1B00
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x002F3714 File Offset: 0x002F1B14
		internal virtual NumericUpDown nud_estacao
		{
			get
			{
				return this._nud_estacao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_estacao_ValueChanged);
				if (this._nud_estacao != null)
				{
					this._nud_estacao.ValueChanged -= eventHandler;
				}
				this._nud_estacao = value;
				if (this._nud_estacao != null)
				{
					this._nud_estacao.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x002F3760 File Offset: 0x002F1B60
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x002F3774 File Offset: 0x002F1B74
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

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x002F3780 File Offset: 0x002F1B80
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x002F3794 File Offset: 0x002F1B94
		internal virtual RadioButton rb_channel2
		{
			get
			{
				return this._rb_channel2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.rb_channel2_CheckedChanged);
				if (this._rb_channel2 != null)
				{
					this._rb_channel2.CheckedChanged -= eventHandler;
				}
				this._rb_channel2 = value;
				if (this._rb_channel2 != null)
				{
					this._rb_channel2.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x002F37E0 File Offset: 0x002F1BE0
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x002F37F4 File Offset: 0x002F1BF4
		internal virtual RadioButton rb_channel1
		{
			get
			{
				return this._rb_channel1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.rb_channel1_CheckedChanged);
				if (this._rb_channel1 != null)
				{
					this._rb_channel1.CheckedChanged -= eventHandler;
				}
				this._rb_channel1 = value;
				if (this._rb_channel1 != null)
				{
					this._rb_channel1.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x002F3840 File Offset: 0x002F1C40
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x002F3854 File Offset: 0x002F1C54
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

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x002F3860 File Offset: 0x002F1C60
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x002F3874 File Offset: 0x002F1C74
		internal virtual NumericUpDown nud_contagens
		{
			get
			{
				return this._nud_contagens;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_contagens_ValueChanged);
				if (this._nud_contagens != null)
				{
					this._nud_contagens.ValueChanged -= eventHandler;
				}
				this._nud_contagens = value;
				if (this._nud_contagens != null)
				{
					this._nud_contagens.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x002F38C0 File Offset: 0x002F1CC0
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x002F38D4 File Offset: 0x002F1CD4
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

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x002F38E0 File Offset: 0x002F1CE0
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x002F38F4 File Offset: 0x002F1CF4
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

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x002F3900 File Offset: 0x002F1D00
		// (set) Token: 0x06000C0A RID: 3082 RVA: 0x002F3914 File Offset: 0x002F1D14
		internal virtual Button Button3
		{
			get
			{
				return this._Button3;
			}
			[MethodImpl(32)]
			set
			{
				this._Button3 = value;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x002F3920 File Offset: 0x002F1D20
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x002F3934 File Offset: 0x002F1D34
		internal virtual Button Button4
		{
			get
			{
				return this._Button4;
			}
			[MethodImpl(32)]
			set
			{
				this._Button4 = value;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x002F3940 File Offset: 0x002F1D40
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x002F3954 File Offset: 0x002F1D54
		internal virtual Button bt_envia
		{
			get
			{
				return this._bt_envia;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bt_envia_Click);
				if (this._bt_envia != null)
				{
					this._bt_envia.Click -= eventHandler;
				}
				this._bt_envia = value;
				if (this._bt_envia != null)
				{
					this._bt_envia.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x002F39A0 File Offset: 0x002F1DA0
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x002F39B4 File Offset: 0x002F1DB4
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

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x002F39C0 File Offset: 0x002F1DC0
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x002F39D4 File Offset: 0x002F1DD4
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

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x002F39E0 File Offset: 0x002F1DE0
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x002F39F4 File Offset: 0x002F1DF4
		internal virtual Button Button5
		{
			get
			{
				return this._Button5;
			}
			[MethodImpl(32)]
			set
			{
				this._Button5 = value;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x002F3A00 File Offset: 0x002F1E00
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x002F3A14 File Offset: 0x002F1E14
		internal virtual Button Button6
		{
			get
			{
				return this._Button6;
			}
			[MethodImpl(32)]
			set
			{
				this._Button6 = value;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x002F3A20 File Offset: 0x002F1E20
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x002F3A34 File Offset: 0x002F1E34
		internal virtual Button bt_confirma_4
		{
			get
			{
				return this._bt_confirma_4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bt_confirma_4_Click);
				if (this._bt_confirma_4 != null)
				{
					this._bt_confirma_4.Click -= eventHandler;
				}
				this._bt_confirma_4 = value;
				if (this._bt_confirma_4 != null)
				{
					this._bt_confirma_4.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x002F3A80 File Offset: 0x002F1E80
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x002F3A94 File Offset: 0x002F1E94
		internal virtual Button bt_confirma_20
		{
			get
			{
				return this._bt_confirma_20;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bt_confirma_20_Click);
				if (this._bt_confirma_20 != null)
				{
					this._bt_confirma_20.Click -= eventHandler;
				}
				this._bt_confirma_20 = value;
				if (this._bt_confirma_20 != null)
				{
					this._bt_confirma_20.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x002F3AE0 File Offset: 0x002F1EE0
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x002F3AF4 File Offset: 0x002F1EF4
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

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x002F3B00 File Offset: 0x002F1F00
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x002F3B14 File Offset: 0x002F1F14
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

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x002F3B20 File Offset: 0x002F1F20
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x002F3B34 File Offset: 0x002F1F34
		internal virtual Button Button9
		{
			get
			{
				return this._Button9;
			}
			[MethodImpl(32)]
			set
			{
				this._Button9 = value;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x002F3B40 File Offset: 0x002F1F40
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x002F3B54 File Offset: 0x002F1F54
		internal virtual Button Button10
		{
			get
			{
				return this._Button10;
			}
			[MethodImpl(32)]
			set
			{
				this._Button10 = value;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x002F3B60 File Offset: 0x002F1F60
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x002F3B74 File Offset: 0x002F1F74
		internal virtual Button bt_finaliza
		{
			get
			{
				return this._bt_finaliza;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bt_finaliza_Click);
				if (this._bt_finaliza != null)
				{
					this._bt_finaliza.Click -= eventHandler;
				}
				this._bt_finaliza = value;
				if (this._bt_finaliza != null)
				{
					this._bt_finaliza.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x002F3BC0 File Offset: 0x002F1FC0
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x002F3BD4 File Offset: 0x002F1FD4
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

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x002F3BE0 File Offset: 0x002F1FE0
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x002F3BF4 File Offset: 0x002F1FF4
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

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x002F3C00 File Offset: 0x002F2000
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x002F3C14 File Offset: 0x002F2014
		internal virtual TextBox mensagens
		{
			get
			{
				return this._mensagens;
			}
			[MethodImpl(32)]
			set
			{
				this._mensagens = value;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x002F3C20 File Offset: 0x002F2020
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x002F3C34 File Offset: 0x002F2034
		internal virtual Button Bt_inic_20
		{
			get
			{
				return this._Bt_inic_20;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Bt_inic_20_Click);
				if (this._Bt_inic_20 != null)
				{
					this._Bt_inic_20.Click -= eventHandler;
				}
				this._Bt_inic_20 = value;
				if (this._Bt_inic_20 != null)
				{
					this._Bt_inic_20.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x002F3C80 File Offset: 0x002F2080
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x002F3C94 File Offset: 0x002F2094
		internal virtual Button Bt_inic_4
		{
			get
			{
				return this._Bt_inic_4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Bt_inic_4_Click);
				if (this._Bt_inic_4 != null)
				{
					this._Bt_inic_4.Click -= eventHandler;
				}
				this._Bt_inic_4 = value;
				if (this._Bt_inic_4 != null)
				{
					this._Bt_inic_4.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x002F3CE0 File Offset: 0x002F20E0
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x002F3CF4 File Offset: 0x002F20F4
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

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x002F3D00 File Offset: 0x002F2100
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x002F3D14 File Offset: 0x002F2114
		internal virtual TrackBar tb_corrente1
		{
			get
			{
				return this._tb_corrente1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.tb_corrente1_ValueChanged);
				EventHandler eventHandler2 = new EventHandler(this.tb_corrente1_Scroll);
				if (this._tb_corrente1 != null)
				{
					this._tb_corrente1.ValueChanged -= eventHandler;
					this._tb_corrente1.Scroll -= eventHandler2;
				}
				this._tb_corrente1 = value;
				if (this._tb_corrente1 != null)
				{
					this._tb_corrente1.ValueChanged += eventHandler;
					this._tb_corrente1.Scroll += eventHandler2;
				}
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x002F3D84 File Offset: 0x002F2184
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x002F3D98 File Offset: 0x002F2198
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

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x002F3DA4 File Offset: 0x002F21A4
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x002F3DB8 File Offset: 0x002F21B8
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

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x002F3DC4 File Offset: 0x002F21C4
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x002F3DD8 File Offset: 0x002F21D8
		internal virtual TrackBar tb_corrente2
		{
			get
			{
				return this._tb_corrente2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.tb_corrente2_Scroll);
				EventHandler eventHandler2 = new EventHandler(this.tb_corrente2_ValueChanged);
				if (this._tb_corrente2 != null)
				{
					this._tb_corrente2.Scroll -= eventHandler;
					this._tb_corrente2.ValueChanged -= eventHandler2;
				}
				this._tb_corrente2 = value;
				if (this._tb_corrente2 != null)
				{
					this._tb_corrente2.Scroll += eventHandler;
					this._tb_corrente2.ValueChanged += eventHandler2;
				}
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x002F3E48 File Offset: 0x002F2248
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x002F3E5C File Offset: 0x002F225C
		internal virtual Label lb_corrente2
		{
			get
			{
				return this._lb_corrente2;
			}
			[MethodImpl(32)]
			set
			{
				this._lb_corrente2 = value;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x002F3E68 File Offset: 0x002F2268
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x002F3E7C File Offset: 0x002F227C
		internal virtual Label lb_corrente1
		{
			get
			{
				return this._lb_corrente1;
			}
			[MethodImpl(32)]
			set
			{
				this._lb_corrente1 = value;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x002F3E88 File Offset: 0x002F2288
		// (set) Token: 0x06000C3E RID: 3134 RVA: 0x002F3E9C File Offset: 0x002F229C
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

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x002F3EA8 File Offset: 0x002F22A8
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x002F3EBC File Offset: 0x002F22BC
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

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x002F3EC8 File Offset: 0x002F22C8
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x002F3EDC File Offset: 0x002F22DC
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

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x002F3EE8 File Offset: 0x002F22E8
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x002F3EFC File Offset: 0x002F22FC
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

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x002F3F08 File Offset: 0x002F2308
		// (set) Token: 0x06000C46 RID: 3142 RVA: 0x002F3F1C File Offset: 0x002F231C
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

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x002F3F28 File Offset: 0x002F2328
		// (set) Token: 0x06000C48 RID: 3144 RVA: 0x002F3F3C File Offset: 0x002F233C
		internal virtual Button tb_escreve_corrente
		{
			get
			{
				return this._tb_escreve_corrente;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.tb_escreve_corrente_Click);
				if (this._tb_escreve_corrente != null)
				{
					this._tb_escreve_corrente.Click -= eventHandler;
				}
				this._tb_escreve_corrente = value;
				if (this._tb_escreve_corrente != null)
				{
					this._tb_escreve_corrente.Click += eventHandler;
				}
			}
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x002F3F88 File Offset: 0x002F2388
		private void atualiza_bt_envia()
		{
			string text = "";
			if (this.canal == 1)
			{
				text = "Canal1";
			}
			if (this.canal == 2)
			{
				text = "Canal2";
			}
			this.bt_envia.Text = "Envia " + this.corrente.ToString() + " mA " + text;
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x002F3FE0 File Offset: 0x002F23E0
		private void GC_82x_calib_Load(object sender, EventArgs e)
		{
			this.Text = "GC" + this.QualModelo.ToString() + " Calibração";
			this.corrente = 0;
			this.corrente1 = 0;
			this.corrente2 = 0;
			this.canal = 1;
			this.rb_channel1.Checked = true;
			this.atualiza_bt_envia();
			this.tb_corrente1.Value = 4;
			this.tb_corrente1.Value = 0;
			this.tb_corrente2.Value = 4;
			this.tb_corrente2.Value = 0;
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x002F406C File Offset: 0x002F246C
		private void rb_channel1_CheckedChanged(object sender, EventArgs e)
		{
			this.canal = 1;
			RT_geral.GC_82x_BD.calib_canal = this.canal;
			this.atualiza_bt_envia();
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x002F408C File Offset: 0x002F248C
		private void rb_channel2_CheckedChanged(object sender, EventArgs e)
		{
			this.canal = 2;
			RT_geral.GC_82x_BD.calib_canal = this.canal;
			this.atualiza_bt_envia();
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x002F40AC File Offset: 0x002F24AC
		private void rb_4ma_CheckedChanged(object sender, EventArgs e)
		{
			this.atualiza_bt_envia();
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x002F40B4 File Offset: 0x002F24B4
		private void rb_20ma_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x002F40B8 File Offset: 0x002F24B8
		private void Button7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x002F40BC File Offset: 0x002F24BC
		private void Button8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x002F40C0 File Offset: 0x002F24C0
		private void bt_envia_Click(object sender, EventArgs e)
		{
			this.AtualizaMsgTela_GC_82x("Enviando Contagens", 2);
			RT_geral.GC_82x_BD.tipo_tipo_envio = "CONTAGEM";
			if (!Mod_MD.Escrita_pagina(20480, 70).Status)
			{
				this.AtualizaMsgTela_GC_82x("Erro na escrita de parâmetros", 1);
				return;
			}
			this.AtualizaMsgTela_GC_82x("Contagens Enviadas", 0);
			this.bt_confirma_4.Enabled = true;
			this.bt_confirma_20.Enabled = true;
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x002F4130 File Offset: 0x002F2530
		private int BuscaContagens()
		{
			return 0;
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x002F4140 File Offset: 0x002F2540
		private void bt_finaliza_Click(object sender, EventArgs e)
		{
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.AtualizaMsgTela_GC_82x("Finalizando Calibração", 2);
				Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
				this.AtualizaMsgTela_GC_82x(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x002F4194 File Offset: 0x002F2594
		private void nud_estacao_ValueChanged(object sender, EventArgs e)
		{
			this.end_estacao = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			RT_geral.GC_82x_BD.End_estacao.Valor = this.end_estacao;
			this.Bt_inic_4.Enabled = true;
			this.Bt_inic_20.Enabled = true;
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x002F41F0 File Offset: 0x002F25F0
		public void AtualizaMsgTela_GC_82x(string texto, int cor)
		{
			this.mensagens.Text = texto;
			if (cor == 0)
			{
				this.mensagens.ForeColor = Color.Blue;
			}
			else if (cor == 1)
			{
				this.mensagens.ForeColor = Color.Red;
			}
			else
			{
				this.mensagens.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x002F4248 File Offset: 0x002F2648
		private int Leitura_EnderecoEstacao()
		{
			this.AtualizaMsgTela_GC_82x("Buscando Endereço", 2);
			int result;
			if (!Mod_MD.Leitura_pagina(2048, 255, 1).Status)
			{
				this.AtualizaMsgTela_GC_82x("Equipamento não responde", 1);
				result = 0;
			}
			else
			{
				Comunicacao.Rotina_Delay(5L);
				this.AtualizaMsgTela_GC_82x("Busca Endereço OK", 0);
				result = Linha_RT.Retorna_End_Est_GC_82x();
			}
			return result;
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x002F42A8 File Offset: 0x002F26A8
		private void bt_busca_Click(object sender, EventArgs e)
		{
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				if (!Mod_MD.Leitura_pagina(0, 255, 4).Status)
				{
					this.AtualizaMsgTela_GC_82x("Equipamento não responde", 1);
					return;
				}
				if (!Linha_RT.VerificaSeEquipamento_GC_82x(2, 0, 0, ""))
				{
					return;
				}
				Linha_RT.Atualiza_dados_GC_82x(0);
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
			}
			this.nud_estacao.Value = new decimal(this.Leitura_EnderecoEstacao());
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x002F4320 File Offset: 0x002F2720
		private void Bt_inic_4_Click(object sender, EventArgs e)
		{
			this.corrente = 4;
			this.atualiza_bt_envia();
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				if (!Mod_MD.Leitura_pagina(6144, this.end_estacao, 8).Status)
				{
					this.AtualizaMsgTela_GC_82x("Equipamento não responde", 1);
					return;
				}
				this.nud_contagens.Value = Conversions.ToDecimal(Linha_RT.AtualizaContagens_GC_82x(this.canal, 4));
				Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
				this.AtualizaMsgTela_GC_82x(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.bt_envia.Enabled = true;
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
			}
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x002F43C4 File Offset: 0x002F27C4
		private void Bt_inic_20_Click(object sender, EventArgs e)
		{
			this.corrente = 20;
			this.atualiza_bt_envia();
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				if (!Mod_MD.Leitura_pagina(6144, this.end_estacao, 8).Status)
				{
					this.AtualizaMsgTela_GC_82x("Equipamento não responde", 1);
					return;
				}
				this.nud_contagens.Value = Conversions.ToDecimal(Linha_RT.AtualizaContagens_GC_82x(this.canal, 20));
				Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
				this.AtualizaMsgTela_GC_82x(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.bt_envia.Enabled = true;
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
			}
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x002F446C File Offset: 0x002F286C
		private void nud_contagens_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.GC_82x_BD.calib_contagens = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x002F4494 File Offset: 0x002F2894
		private void bt_confirma_4_Click(object sender, EventArgs e)
		{
			RT_geral.GC_82x_BD.calib_funcao = 0;
			this.AtualizaMsgTela_GC_82x("Confirmando Calibração 4mA", 2);
			if (!Mod_MD.Escrita_pagina(6144, 70).Status)
			{
				this.AtualizaMsgTela_GC_82x("Erro na escrita de parâmetros", 1);
				return;
			}
			this.AtualizaMsgTela_GC_82x("4mA Calibrado", 0);
			this.bt_finaliza.Enabled = true;
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x002F44F4 File Offset: 0x002F28F4
		private void bt_confirma_20_Click(object sender, EventArgs e)
		{
			RT_geral.GC_82x_BD.calib_funcao = 1;
			this.AtualizaMsgTela_GC_82x("Confirmando Calibração 20mA", 2);
			if (!Mod_MD.Escrita_pagina(6144, 70).Status)
			{
				this.AtualizaMsgTela_GC_82x("Erro na escrita de parâmetros", 1);
				return;
			}
			this.AtualizaMsgTela_GC_82x("20mA Calibrado", 0);
			this.bt_finaliza.Enabled = true;
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x002F4554 File Offset: 0x002F2954
		private void tb_corrente1_Scroll(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x002F4558 File Offset: 0x002F2958
		private void tb_corrente2_Scroll(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x002F455C File Offset: 0x002F295C
		private void tb_corrente1_ValueChanged(object sender, EventArgs e)
		{
			checked
			{
				this.lb_corrente1.Text = (4 + this.tb_corrente1.Value).ToString() + "mA";
				RT_geral.GC_82x_BD.corrente_canal1 = (int)Math.Round(unchecked((double)this.tb_corrente1.Value / (double)this.tb_corrente1.Maximum * 4000.0));
			}
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x002F45C8 File Offset: 0x002F29C8
		private void tb_corrente2_ValueChanged(object sender, EventArgs e)
		{
			checked
			{
				this.lb_corrente2.Text = (4 + this.tb_corrente2.Value).ToString() + "mA";
				RT_geral.GC_82x_BD.corrente_canal2 = (int)Math.Round(unchecked((double)this.tb_corrente2.Value / (double)this.tb_corrente2.Maximum * 4000.0));
			}
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x002F4634 File Offset: 0x002F2A34
		private void tb_escreve_corrente_Click(object sender, EventArgs e)
		{
			this.AtualizaMsgTela_GC_82x("Enviando Contagens", 2);
			RT_geral.GC_82x_BD.tipo_tipo_envio = "mA";
			if (!Mod_MD.Escrita_pagina(20480, 70).Status)
			{
				this.AtualizaMsgTela_GC_82x("Erro na escrita de parâmetros", 1);
				return;
			}
			this.AtualizaMsgTela_GC_82x("Contagens Enviadas", 0);
			this.bt_confirma_4.Enabled = true;
			this.bt_confirma_20.Enabled = true;
		}

		// Token: 0x04000772 RID: 1906
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000773 RID: 1907
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000774 RID: 1908
		[AccessedThroughProperty("bt_busca")]
		private Button _bt_busca;

		// Token: 0x04000775 RID: 1909
		[AccessedThroughProperty("nud_estacao")]
		private NumericUpDown _nud_estacao;

		// Token: 0x04000776 RID: 1910
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x04000777 RID: 1911
		[AccessedThroughProperty("rb_channel2")]
		private RadioButton _rb_channel2;

		// Token: 0x04000778 RID: 1912
		[AccessedThroughProperty("rb_channel1")]
		private RadioButton _rb_channel1;

		// Token: 0x04000779 RID: 1913
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x0400077A RID: 1914
		[AccessedThroughProperty("nud_contagens")]
		private NumericUpDown _nud_contagens;

		// Token: 0x0400077B RID: 1915
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400077C RID: 1916
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		// Token: 0x0400077D RID: 1917
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x0400077E RID: 1918
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		// Token: 0x0400077F RID: 1919
		[AccessedThroughProperty("bt_envia")]
		private Button _bt_envia;

		// Token: 0x04000780 RID: 1920
		[AccessedThroughProperty("GroupBox7")]
		private GroupBox _GroupBox7;

		// Token: 0x04000781 RID: 1921
		[AccessedThroughProperty("GroupBox8")]
		private GroupBox _GroupBox8;

		// Token: 0x04000782 RID: 1922
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		// Token: 0x04000783 RID: 1923
		[AccessedThroughProperty("Button6")]
		private Button _Button6;

		// Token: 0x04000784 RID: 1924
		[AccessedThroughProperty("bt_confirma_4")]
		private Button _bt_confirma_4;

		// Token: 0x04000785 RID: 1925
		[AccessedThroughProperty("bt_confirma_20")]
		private Button _bt_confirma_20;

		// Token: 0x04000786 RID: 1926
		[AccessedThroughProperty("GroupBox9")]
		private GroupBox _GroupBox9;

		// Token: 0x04000787 RID: 1927
		[AccessedThroughProperty("GroupBox10")]
		private GroupBox _GroupBox10;

		// Token: 0x04000788 RID: 1928
		[AccessedThroughProperty("Button9")]
		private Button _Button9;

		// Token: 0x04000789 RID: 1929
		[AccessedThroughProperty("Button10")]
		private Button _Button10;

		// Token: 0x0400078A RID: 1930
		[AccessedThroughProperty("bt_finaliza")]
		private Button _bt_finaliza;

		// Token: 0x0400078B RID: 1931
		[AccessedThroughProperty("GroupBox11")]
		private GroupBox _GroupBox11;

		// Token: 0x0400078C RID: 1932
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x0400078D RID: 1933
		[AccessedThroughProperty("mensagens")]
		private TextBox _mensagens;

		// Token: 0x0400078E RID: 1934
		[AccessedThroughProperty("Bt_inic_20")]
		private Button _Bt_inic_20;

		// Token: 0x0400078F RID: 1935
		[AccessedThroughProperty("Bt_inic_4")]
		private Button _Bt_inic_4;

		// Token: 0x04000790 RID: 1936
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x04000791 RID: 1937
		[AccessedThroughProperty("tb_corrente1")]
		private TrackBar _tb_corrente1;

		// Token: 0x04000792 RID: 1938
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000793 RID: 1939
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000794 RID: 1940
		[AccessedThroughProperty("tb_corrente2")]
		private TrackBar _tb_corrente2;

		// Token: 0x04000795 RID: 1941
		[AccessedThroughProperty("lb_corrente2")]
		private Label _lb_corrente2;

		// Token: 0x04000796 RID: 1942
		[AccessedThroughProperty("lb_corrente1")]
		private Label _lb_corrente1;

		// Token: 0x04000797 RID: 1943
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000798 RID: 1944
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000799 RID: 1945
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x0400079A RID: 1946
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400079B RID: 1947
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x0400079C RID: 1948
		[AccessedThroughProperty("tb_escreve_corrente")]
		private Button _tb_escreve_corrente;

		// Token: 0x0400079D RID: 1949
		public int QualModelo;

		// Token: 0x0400079E RID: 1950
		private int canal;

		// Token: 0x0400079F RID: 1951
		private int corrente;

		// Token: 0x040007A0 RID: 1952
		private int end_estacao;

		// Token: 0x040007A1 RID: 1953
		private bool equipamentto_certo;

		// Token: 0x040007A2 RID: 1954
		private int corrente1;

		// Token: 0x040007A3 RID: 1955
		private int corrente2;
	}
}
