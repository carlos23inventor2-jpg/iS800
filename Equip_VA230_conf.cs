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
	// Token: 0x0200009F RID: 159
	[DesignerGenerated]
	public partial class Equip_VA230_conf : Form
	{
		// Token: 0x060026E6 RID: 9958 RVA: 0x0041FE7C File Offset: 0x0041E27C
		public Equip_VA230_conf()
		{
			base.Load += new EventHandler(this.Equip_va230_conf_Load);
			this.InitializeComponent();
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x060026E9 RID: 9961 RVA: 0x00421884 File Offset: 0x0041FC84
		// (set) Token: 0x060026EA RID: 9962 RVA: 0x00421898 File Offset: 0x0041FC98
		internal virtual GroupBox grupo_parametros_gerais
		{
			get
			{
				return this._grupo_parametros_gerais;
			}
			[MethodImpl(32)]
			set
			{
				this._grupo_parametros_gerais = value;
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x060026EB RID: 9963 RVA: 0x004218A4 File Offset: 0x0041FCA4
		// (set) Token: 0x060026EC RID: 9964 RVA: 0x004218B8 File Offset: 0x0041FCB8
		internal virtual TextBox Valor_intervalo_varredura
		{
			get
			{
				return this._Valor_intervalo_varredura;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_intervalo_varredura_Validating);
				if (this._Valor_intervalo_varredura != null)
				{
					this._Valor_intervalo_varredura.Validating -= cancelEventHandler;
				}
				this._Valor_intervalo_varredura = value;
				if (this._Valor_intervalo_varredura != null)
				{
					this._Valor_intervalo_varredura.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x060026ED RID: 9965 RVA: 0x00421904 File Offset: 0x0041FD04
		// (set) Token: 0x060026EE RID: 9966 RVA: 0x00421918 File Offset: 0x0041FD18
		internal virtual Label Label_intervalo_varredura
		{
			get
			{
				return this._Label_intervalo_varredura;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_intervalo_varredura = value;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x060026EF RID: 9967 RVA: 0x00421924 File Offset: 0x0041FD24
		// (set) Token: 0x060026F0 RID: 9968 RVA: 0x00421938 File Offset: 0x0041FD38
		internal virtual TextBox Valor_end_origem
		{
			get
			{
				return this._Valor_end_origem;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_end_origem_Validating);
				if (this._Valor_end_origem != null)
				{
					this._Valor_end_origem.Validating -= cancelEventHandler;
				}
				this._Valor_end_origem = value;
				if (this._Valor_end_origem != null)
				{
					this._Valor_end_origem.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x00421984 File Offset: 0x0041FD84
		// (set) Token: 0x060026F2 RID: 9970 RVA: 0x00421998 File Offset: 0x0041FD98
		internal virtual TextBox Valor_numero_recalques
		{
			get
			{
				return this._Valor_numero_recalques;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_numero_recalques_Validating);
				if (this._Valor_numero_recalques != null)
				{
					this._Valor_numero_recalques.Validating -= cancelEventHandler;
				}
				this._Valor_numero_recalques = value;
				if (this._Valor_numero_recalques != null)
				{
					this._Valor_numero_recalques.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x060026F3 RID: 9971 RVA: 0x004219E4 File Offset: 0x0041FDE4
		// (set) Token: 0x060026F4 RID: 9972 RVA: 0x004219F8 File Offset: 0x0041FDF8
		internal virtual Label Label_end_origem
		{
			get
			{
				return this._Label_end_origem;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_origem = value;
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x00421A04 File Offset: 0x0041FE04
		// (set) Token: 0x060026F6 RID: 9974 RVA: 0x00421A18 File Offset: 0x0041FE18
		internal virtual Label Label_numero_recalques
		{
			get
			{
				return this._Label_numero_recalques;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_numero_recalques = value;
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x00421A24 File Offset: 0x0041FE24
		// (set) Token: 0x060026F8 RID: 9976 RVA: 0x00421A38 File Offset: 0x0041FE38
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

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x00421A44 File Offset: 0x0041FE44
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x00421A58 File Offset: 0x0041FE58
		internal virtual Button Esc_conf_md_201
		{
			get
			{
				return this._Esc_conf_md_201;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Esc_conf_md_201_Click);
				if (this._Esc_conf_md_201 != null)
				{
					this._Esc_conf_md_201.Click -= eventHandler;
				}
				this._Esc_conf_md_201 = value;
				if (this._Esc_conf_md_201 != null)
				{
					this._Esc_conf_md_201.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x00421AA4 File Offset: 0x0041FEA4
		// (set) Token: 0x060026FC RID: 9980 RVA: 0x00421AB8 File Offset: 0x0041FEB8
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

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x060026FD RID: 9981 RVA: 0x00421AC4 File Offset: 0x0041FEC4
		// (set) Token: 0x060026FE RID: 9982 RVA: 0x00421AD8 File Offset: 0x0041FED8
		internal virtual Button Ler_conf_md_201
		{
			get
			{
				return this._Ler_conf_md_201;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Ler_conf_md_201_Click);
				if (this._Ler_conf_md_201 != null)
				{
					this._Ler_conf_md_201.Click -= eventHandler;
				}
				this._Ler_conf_md_201 = value;
				if (this._Ler_conf_md_201 != null)
				{
					this._Ler_conf_md_201.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x00421B24 File Offset: 0x0041FF24
		// (set) Token: 0x06002700 RID: 9984 RVA: 0x00421B38 File Offset: 0x0041FF38
		internal virtual GroupBox grupo_escalas
		{
			get
			{
				return this._grupo_escalas;
			}
			[MethodImpl(32)]
			set
			{
				this._grupo_escalas = value;
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x00421B44 File Offset: 0x0041FF44
		// (set) Token: 0x06002702 RID: 9986 RVA: 0x00421B58 File Offset: 0x0041FF58
		internal virtual TextBox Valor_escala_canal_0
		{
			get
			{
				return this._Valor_escala_canal_0;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_escala_canal_0_Validating);
				if (this._Valor_escala_canal_0 != null)
				{
					this._Valor_escala_canal_0.Validating -= cancelEventHandler;
				}
				this._Valor_escala_canal_0 = value;
				if (this._Valor_escala_canal_0 != null)
				{
					this._Valor_escala_canal_0.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x00421BA4 File Offset: 0x0041FFA4
		// (set) Token: 0x06002704 RID: 9988 RVA: 0x00421BB8 File Offset: 0x0041FFB8
		internal virtual Label Label_escala_canal_0
		{
			get
			{
				return this._Label_escala_canal_0;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_escala_canal_0 = value;
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06002705 RID: 9989 RVA: 0x00421BC4 File Offset: 0x0041FFC4
		// (set) Token: 0x06002706 RID: 9990 RVA: 0x00421BD8 File Offset: 0x0041FFD8
		internal virtual TextBox Valor_escala_canal_7
		{
			get
			{
				return this._Valor_escala_canal_7;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_escala_canal_7_Validating);
				if (this._Valor_escala_canal_7 != null)
				{
					this._Valor_escala_canal_7.Validating -= cancelEventHandler;
				}
				this._Valor_escala_canal_7 = value;
				if (this._Valor_escala_canal_7 != null)
				{
					this._Valor_escala_canal_7.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06002707 RID: 9991 RVA: 0x00421C24 File Offset: 0x00420024
		// (set) Token: 0x06002708 RID: 9992 RVA: 0x00421C38 File Offset: 0x00420038
		internal virtual TextBox Valor_escala_canal_6
		{
			get
			{
				return this._Valor_escala_canal_6;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_escala_canal_6_Validating);
				if (this._Valor_escala_canal_6 != null)
				{
					this._Valor_escala_canal_6.Validating -= cancelEventHandler;
				}
				this._Valor_escala_canal_6 = value;
				if (this._Valor_escala_canal_6 != null)
				{
					this._Valor_escala_canal_6.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x00421C84 File Offset: 0x00420084
		// (set) Token: 0x0600270A RID: 9994 RVA: 0x00421C98 File Offset: 0x00420098
		internal virtual TextBox Valor_escala_canal_5
		{
			get
			{
				return this._Valor_escala_canal_5;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_escala_canal_5_Validating);
				if (this._Valor_escala_canal_5 != null)
				{
					this._Valor_escala_canal_5.Validating -= cancelEventHandler;
				}
				this._Valor_escala_canal_5 = value;
				if (this._Valor_escala_canal_5 != null)
				{
					this._Valor_escala_canal_5.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x00421CE4 File Offset: 0x004200E4
		// (set) Token: 0x0600270C RID: 9996 RVA: 0x00421CF8 File Offset: 0x004200F8
		internal virtual TextBox Valor_escala_canal_4
		{
			get
			{
				return this._Valor_escala_canal_4;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_escala_canal_4_Validating);
				if (this._Valor_escala_canal_4 != null)
				{
					this._Valor_escala_canal_4.Validating -= cancelEventHandler;
				}
				this._Valor_escala_canal_4 = value;
				if (this._Valor_escala_canal_4 != null)
				{
					this._Valor_escala_canal_4.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x00421D44 File Offset: 0x00420144
		// (set) Token: 0x0600270E RID: 9998 RVA: 0x00421D58 File Offset: 0x00420158
		internal virtual TextBox Valor_escala_canal_3
		{
			get
			{
				return this._Valor_escala_canal_3;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_escala_canal_3_Validating);
				if (this._Valor_escala_canal_3 != null)
				{
					this._Valor_escala_canal_3.Validating -= cancelEventHandler;
				}
				this._Valor_escala_canal_3 = value;
				if (this._Valor_escala_canal_3 != null)
				{
					this._Valor_escala_canal_3.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x00421DA4 File Offset: 0x004201A4
		// (set) Token: 0x06002710 RID: 10000 RVA: 0x00421DB8 File Offset: 0x004201B8
		internal virtual TextBox Valor_escala_canal_2
		{
			get
			{
				return this._Valor_escala_canal_2;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_escala_canal_2_Validating);
				if (this._Valor_escala_canal_2 != null)
				{
					this._Valor_escala_canal_2.Validating -= cancelEventHandler;
				}
				this._Valor_escala_canal_2 = value;
				if (this._Valor_escala_canal_2 != null)
				{
					this._Valor_escala_canal_2.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06002711 RID: 10001 RVA: 0x00421E04 File Offset: 0x00420204
		// (set) Token: 0x06002712 RID: 10002 RVA: 0x00421E18 File Offset: 0x00420218
		internal virtual TextBox Valor_escala_canal_1
		{
			get
			{
				return this._Valor_escala_canal_1;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_escala_canal_1_Validating);
				if (this._Valor_escala_canal_1 != null)
				{
					this._Valor_escala_canal_1.Validating -= cancelEventHandler;
				}
				this._Valor_escala_canal_1 = value;
				if (this._Valor_escala_canal_1 != null)
				{
					this._Valor_escala_canal_1.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06002713 RID: 10003 RVA: 0x00421E64 File Offset: 0x00420264
		// (set) Token: 0x06002714 RID: 10004 RVA: 0x00421E78 File Offset: 0x00420278
		internal virtual Label Label_escala_canal_7
		{
			get
			{
				return this._Label_escala_canal_7;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_escala_canal_7 = value;
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x00421E84 File Offset: 0x00420284
		// (set) Token: 0x06002716 RID: 10006 RVA: 0x00421E98 File Offset: 0x00420298
		internal virtual Label Label_escala_canal_6
		{
			get
			{
				return this._Label_escala_canal_6;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_escala_canal_6 = value;
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06002717 RID: 10007 RVA: 0x00421EA4 File Offset: 0x004202A4
		// (set) Token: 0x06002718 RID: 10008 RVA: 0x00421EB8 File Offset: 0x004202B8
		internal virtual Label Label_escala_canal_5
		{
			get
			{
				return this._Label_escala_canal_5;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_escala_canal_5 = value;
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06002719 RID: 10009 RVA: 0x00421EC4 File Offset: 0x004202C4
		// (set) Token: 0x0600271A RID: 10010 RVA: 0x00421ED8 File Offset: 0x004202D8
		internal virtual Label Label_escala_canal_4
		{
			get
			{
				return this._Label_escala_canal_4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_escala_canal_4 = value;
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x0600271B RID: 10011 RVA: 0x00421EE4 File Offset: 0x004202E4
		// (set) Token: 0x0600271C RID: 10012 RVA: 0x00421EF8 File Offset: 0x004202F8
		internal virtual Label Label_escala_canal_3
		{
			get
			{
				return this._Label_escala_canal_3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_escala_canal_3 = value;
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x0600271D RID: 10013 RVA: 0x00421F04 File Offset: 0x00420304
		// (set) Token: 0x0600271E RID: 10014 RVA: 0x00421F18 File Offset: 0x00420318
		internal virtual Label Label_escala_canal_2
		{
			get
			{
				return this._Label_escala_canal_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_escala_canal_2 = value;
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x0600271F RID: 10015 RVA: 0x00421F24 File Offset: 0x00420324
		// (set) Token: 0x06002720 RID: 10016 RVA: 0x00421F38 File Offset: 0x00420338
		internal virtual Label Label_escala_canal_1
		{
			get
			{
				return this._Label_escala_canal_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_escala_canal_1 = value;
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06002721 RID: 10017 RVA: 0x00421F44 File Offset: 0x00420344
		// (set) Token: 0x06002722 RID: 10018 RVA: 0x00421F58 File Offset: 0x00420358
		internal virtual TextBox Valor_escala_canal_15
		{
			get
			{
				return this._Valor_escala_canal_15;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_escala_canal_15_Validating);
				if (this._Valor_escala_canal_15 != null)
				{
					this._Valor_escala_canal_15.Validating -= cancelEventHandler;
				}
				this._Valor_escala_canal_15 = value;
				if (this._Valor_escala_canal_15 != null)
				{
					this._Valor_escala_canal_15.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06002723 RID: 10019 RVA: 0x00421FA4 File Offset: 0x004203A4
		// (set) Token: 0x06002724 RID: 10020 RVA: 0x00421FB8 File Offset: 0x004203B8
		internal virtual TextBox Valor_escala_canal_14
		{
			get
			{
				return this._Valor_escala_canal_14;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_escala_canal_14_Validating);
				if (this._Valor_escala_canal_14 != null)
				{
					this._Valor_escala_canal_14.Validating -= cancelEventHandler;
				}
				this._Valor_escala_canal_14 = value;
				if (this._Valor_escala_canal_14 != null)
				{
					this._Valor_escala_canal_14.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06002725 RID: 10021 RVA: 0x00422004 File Offset: 0x00420404
		// (set) Token: 0x06002726 RID: 10022 RVA: 0x00422018 File Offset: 0x00420418
		internal virtual TextBox Valor_escala_canal_13
		{
			get
			{
				return this._Valor_escala_canal_13;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_escala_canal_13_Validating);
				if (this._Valor_escala_canal_13 != null)
				{
					this._Valor_escala_canal_13.Validating -= cancelEventHandler;
				}
				this._Valor_escala_canal_13 = value;
				if (this._Valor_escala_canal_13 != null)
				{
					this._Valor_escala_canal_13.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x00422064 File Offset: 0x00420464
		// (set) Token: 0x06002728 RID: 10024 RVA: 0x00422078 File Offset: 0x00420478
		internal virtual TextBox Valor_escala_canal_12
		{
			get
			{
				return this._Valor_escala_canal_12;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_escala_canal_12_Validating);
				if (this._Valor_escala_canal_12 != null)
				{
					this._Valor_escala_canal_12.Validating -= cancelEventHandler;
				}
				this._Valor_escala_canal_12 = value;
				if (this._Valor_escala_canal_12 != null)
				{
					this._Valor_escala_canal_12.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06002729 RID: 10025 RVA: 0x004220C4 File Offset: 0x004204C4
		// (set) Token: 0x0600272A RID: 10026 RVA: 0x004220D8 File Offset: 0x004204D8
		internal virtual TextBox Valor_escala_canal_11
		{
			get
			{
				return this._Valor_escala_canal_11;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_escala_canal_11_Validating);
				if (this._Valor_escala_canal_11 != null)
				{
					this._Valor_escala_canal_11.Validating -= cancelEventHandler;
				}
				this._Valor_escala_canal_11 = value;
				if (this._Valor_escala_canal_11 != null)
				{
					this._Valor_escala_canal_11.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x00422124 File Offset: 0x00420524
		// (set) Token: 0x0600272C RID: 10028 RVA: 0x00422138 File Offset: 0x00420538
		internal virtual TextBox Valor_escala_canal_10
		{
			get
			{
				return this._Valor_escala_canal_10;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_escala_canal_10_Validating);
				if (this._Valor_escala_canal_10 != null)
				{
					this._Valor_escala_canal_10.Validating -= cancelEventHandler;
				}
				this._Valor_escala_canal_10 = value;
				if (this._Valor_escala_canal_10 != null)
				{
					this._Valor_escala_canal_10.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x00422184 File Offset: 0x00420584
		// (set) Token: 0x0600272E RID: 10030 RVA: 0x00422198 File Offset: 0x00420598
		internal virtual TextBox Valor_escala_canal_9
		{
			get
			{
				return this._Valor_escala_canal_9;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_escala_canal_9_Validating);
				if (this._Valor_escala_canal_9 != null)
				{
					this._Valor_escala_canal_9.Validating -= cancelEventHandler;
				}
				this._Valor_escala_canal_9 = value;
				if (this._Valor_escala_canal_9 != null)
				{
					this._Valor_escala_canal_9.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x0600272F RID: 10031 RVA: 0x004221E4 File Offset: 0x004205E4
		// (set) Token: 0x06002730 RID: 10032 RVA: 0x004221F8 File Offset: 0x004205F8
		internal virtual TextBox Valor_escala_canal_8
		{
			get
			{
				return this._Valor_escala_canal_8;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_escala_canal_8_Validating);
				if (this._Valor_escala_canal_8 != null)
				{
					this._Valor_escala_canal_8.Validating -= cancelEventHandler;
				}
				this._Valor_escala_canal_8 = value;
				if (this._Valor_escala_canal_8 != null)
				{
					this._Valor_escala_canal_8.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06002731 RID: 10033 RVA: 0x00422244 File Offset: 0x00420644
		// (set) Token: 0x06002732 RID: 10034 RVA: 0x00422258 File Offset: 0x00420658
		internal virtual Label Label_escala_canal_15
		{
			get
			{
				return this._Label_escala_canal_15;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_escala_canal_15 = value;
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06002733 RID: 10035 RVA: 0x00422264 File Offset: 0x00420664
		// (set) Token: 0x06002734 RID: 10036 RVA: 0x00422278 File Offset: 0x00420678
		internal virtual Label Label_escala_canal_14
		{
			get
			{
				return this._Label_escala_canal_14;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_escala_canal_14 = value;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06002735 RID: 10037 RVA: 0x00422284 File Offset: 0x00420684
		// (set) Token: 0x06002736 RID: 10038 RVA: 0x00422298 File Offset: 0x00420698
		internal virtual Label Label_escala_canal_13
		{
			get
			{
				return this._Label_escala_canal_13;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_escala_canal_13 = value;
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06002737 RID: 10039 RVA: 0x004222A4 File Offset: 0x004206A4
		// (set) Token: 0x06002738 RID: 10040 RVA: 0x004222B8 File Offset: 0x004206B8
		internal virtual Label Label_escala_canal_12
		{
			get
			{
				return this._Label_escala_canal_12;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_escala_canal_12 = value;
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06002739 RID: 10041 RVA: 0x004222C4 File Offset: 0x004206C4
		// (set) Token: 0x0600273A RID: 10042 RVA: 0x004222D8 File Offset: 0x004206D8
		internal virtual Label Label_escala_canal_11
		{
			get
			{
				return this._Label_escala_canal_11;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_escala_canal_11 = value;
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x0600273B RID: 10043 RVA: 0x004222E4 File Offset: 0x004206E4
		// (set) Token: 0x0600273C RID: 10044 RVA: 0x004222F8 File Offset: 0x004206F8
		internal virtual Label Label_escala_canal_10
		{
			get
			{
				return this._Label_escala_canal_10;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_escala_canal_10 = value;
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x0600273D RID: 10045 RVA: 0x00422304 File Offset: 0x00420704
		// (set) Token: 0x0600273E RID: 10046 RVA: 0x00422318 File Offset: 0x00420718
		internal virtual Label Label_escala_canal_9
		{
			get
			{
				return this._Label_escala_canal_9;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_escala_canal_9 = value;
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x0600273F RID: 10047 RVA: 0x00422324 File Offset: 0x00420724
		// (set) Token: 0x06002740 RID: 10048 RVA: 0x00422338 File Offset: 0x00420738
		internal virtual Label Label_escala_canal_8
		{
			get
			{
				return this._Label_escala_canal_8;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_escala_canal_8 = value;
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06002741 RID: 10049 RVA: 0x00422344 File Offset: 0x00420744
		// (set) Token: 0x06002742 RID: 10050 RVA: 0x00422358 File Offset: 0x00420758
		internal virtual Label Label_end_estacao
		{
			get
			{
				return this._Label_end_estacao;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_estacao = value;
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06002743 RID: 10051 RVA: 0x00422364 File Offset: 0x00420764
		// (set) Token: 0x06002744 RID: 10052 RVA: 0x00422378 File Offset: 0x00420778
		internal virtual VScrollBar VScroll_end_estacao
		{
			get
			{
				return this._VScroll_end_estacao;
			}
			[MethodImpl(32)]
			set
			{
				ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.VScroll_end_estacao_Scroll);
				if (this._VScroll_end_estacao != null)
				{
					this._VScroll_end_estacao.Scroll -= scrollEventHandler;
				}
				this._VScroll_end_estacao = value;
				if (this._VScroll_end_estacao != null)
				{
					this._VScroll_end_estacao.Scroll += scrollEventHandler;
				}
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06002745 RID: 10053 RVA: 0x004223C4 File Offset: 0x004207C4
		// (set) Token: 0x06002746 RID: 10054 RVA: 0x004223D8 File Offset: 0x004207D8
		internal virtual TextBox Valor_end_estacao
		{
			get
			{
				return this._Valor_end_estacao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_end_estacao_TextChanged);
				if (this._Valor_end_estacao != null)
				{
					this._Valor_end_estacao.TextChanged -= eventHandler;
				}
				this._Valor_end_estacao = value;
				if (this._Valor_end_estacao != null)
				{
					this._Valor_end_estacao.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x00422424 File Offset: 0x00420824
		private void Equip_va230_conf_Load(object sender, EventArgs e)
		{
			this.Limpa_estrutura_VA230();
			this.Atualiza_tela_VA230();
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x00422434 File Offset: 0x00420834
		public void Limpa_estrutura_VA230()
		{
			Mod_VA.Config_VA230.Escalas = new int[41, 17];
			Mod_VA.Config_VA230.End_origem = 0;
			Mod_VA.Config_VA230.Numero_recalques = 0;
			Mod_VA.Config_VA230.Tempo_varredura = 3;
			Mod_VA.Config_VA230.Indice = 1;
			int num = 1;
			checked
			{
				do
				{
					int num2 = 1;
					do
					{
						if (num2 == 5)
						{
							Mod_VA.Config_VA230.Escalas[num, num2] = 500;
						}
						else
						{
							Mod_VA.Config_VA230.Escalas[num, num2] = 100;
						}
						num2++;
					}
					while (num2 <= 16);
					num++;
				}
				while (num <= 40);
			}
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x004224C8 File Offset: 0x004208C8
		public void Atualiza_tela_VA230()
		{
			this.Valor_end_origem.Text = Conversions.ToString(Mod_VA.Config_VA230.End_origem);
			this.Valor_numero_recalques.Text = Conversions.ToString(Mod_VA.Config_VA230.Numero_recalques);
			this.Valor_intervalo_varredura.Text = Conversions.ToString(Mod_VA.Config_VA230.Tempo_varredura);
			this.Valor_end_estacao.Text = Conversions.ToString(Mod_VA.Config_VA230.Indice);
			this.VScroll_end_estacao.Value = Mod_VA.Config_VA230.Indice;
			this.VScroll_end_estacao.Maximum = 40;
			this.VScroll_end_estacao.Minimum = 1;
			this.Valor_escala_canal_0.Text = Conversions.ToString(Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 1]);
			this.Valor_escala_canal_1.Text = Conversions.ToString(Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 2]);
			this.Valor_escala_canal_2.Text = Conversions.ToString(Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 3]);
			this.Valor_escala_canal_3.Text = Conversions.ToString(Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 4]);
			this.Valor_escala_canal_4.Text = Conversions.ToString(Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 5]);
			this.Valor_escala_canal_5.Text = Conversions.ToString(Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 6]);
			this.Valor_escala_canal_6.Text = Conversions.ToString(Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 7]);
			this.Valor_escala_canal_7.Text = Conversions.ToString(Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 8]);
			this.Valor_escala_canal_8.Text = Conversions.ToString(Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 9]);
			this.Valor_escala_canal_9.Text = Conversions.ToString(Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 10]);
			this.Valor_escala_canal_10.Text = Conversions.ToString(Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 11]);
			this.Valor_escala_canal_11.Text = Conversions.ToString(Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 12]);
			this.Valor_escala_canal_12.Text = Conversions.ToString(Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 13]);
			this.Valor_escala_canal_13.Text = Conversions.ToString(Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 14]);
			this.Valor_escala_canal_14.Text = Conversions.ToString(Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 15]);
			this.Valor_escala_canal_15.Text = Conversions.ToString(Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 16]);
			if (Mod_VA.Config_VA230.Numero_recalques < 1)
			{
				this.grupo_escalas.Visible = false;
			}
			else
			{
				this.grupo_escalas.Visible = true;
			}
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x0042283C File Offset: 0x00420C3C
		private void Ler_conf_md_201_Click(object sender, EventArgs e)
		{
			this.Mensagem_MD201("Aguarde ...", 2);
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			checked
			{
				while (i > 0)
				{
					i--;
					Comunicacao.CMD_Le_Pagina(100, 255, 21);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						Mod_MD.Atualiza_dados_MD201(Mod_MD.Controle.Estacao, 100);
						this.Mensagem_MD201("Leitura página 1 - Ok", 0);
						goto IL_C4;
					case 2:
						if (i == 0)
						{
							this.Mensagem_MD201("Erro leitura página 1 - conferência", 1);
							return;
						}
						continue;
					case 3:
						if (i == 0)
						{
							this.Mensagem_MD201("Erro leitura página 1 - timeout", 1);
							return;
						}
						continue;
					}
					if (i == 0)
					{
						this.Mensagem_MD201("Erro leitura - não determinado", 1);
						return;
					}
				}
				IL_C4:
				i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
				while (i > 0)
				{
					i--;
					Comunicacao.CMD_Le_Pagina(512, Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].End_estacao, 52);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						Mod_MD.Atualiza_dados_MD201(Mod_MD.Controle.Estacao, 512);
						this.Mensagem_MD201("Leitura página 2 - Ok", 0);
						return;
					case 2:
						if (i == 0)
						{
							this.Mensagem_MD201("Erro leitura página 2 - conferência", 1);
							return;
						}
						continue;
					case 3:
						if (i == 0)
						{
							this.Mensagem_MD201("Erro leitura página 2 - timeout", 1);
							return;
						}
						continue;
					}
					if (i == 0)
					{
						this.Mensagem_MD201("Erro leitura - não determinado", 1);
						return;
					}
				}
			}
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x004229E0 File Offset: 0x00420DE0
		public void Mensagem_MD201(string msg, int cor)
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

		// Token: 0x0600274C RID: 10060 RVA: 0x00422A44 File Offset: 0x00420E44
		private void Esc_conf_md_201_Click(object sender, EventArgs e)
		{
			this.Mensagem_MD201("Aguarde ...", 2);
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			checked
			{
				while (i > 0)
				{
					i--;
					Comunicacao.CMD_Esc_habilitacao(21845, 255);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						this.Mensagem_MD201("Programação habilitada", 0);
						goto IL_B4;
					case 2:
						if (i == 0)
						{
							this.Mensagem_MD201("Erro ao habilitar programação - conferência", 1);
							return;
						}
						continue;
					case 3:
						if (i == 0)
						{
							this.Mensagem_MD201("Erro ao habilitar programação - timeout", 1);
							return;
						}
						continue;
					}
					if (i == 0)
					{
						this.Mensagem_MD201("Erro ao habilitar programação - não determinado", 1);
						return;
					}
				}
				IL_B4:
				i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
				while (i > 0)
				{
					i--;
					Mod_MD.CMD_Esc_MD201_pagina_1(255, 1);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						this.Mensagem_MD201("Programação página 1 - Ok", 0);
						goto IL_158;
					case 2:
						if (i == 0)
						{
							this.Mensagem_MD201("Erro ao programar página 1 - conferência", 1);
							return;
						}
						continue;
					case 3:
						if (i == 0)
						{
							this.Mensagem_MD201("Erro ao programar página 1 - Ok - timeout", 1);
							return;
						}
						continue;
					}
					if (i == 0)
					{
						this.Mensagem_MD201("Erro ao programar página 1 - não determinado", 1);
						return;
					}
				}
				IL_158:
				i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
				while (i > 0)
				{
					i--;
					Mod_MD.CMD_Esc_MD201_pagina_2(Mod_MD.Recalque_201[1].End_estacao, 1);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						this.Mensagem_MD201("Programação página 2 - Ok", 0);
						goto IL_207;
					case 2:
						if (i == 0)
						{
							this.Mensagem_MD201("Erro ao programar página 2 - conferência", 1);
							return;
						}
						continue;
					case 3:
						if (i == 0)
						{
							this.Mensagem_MD201("Erro ao programar página 2 - Ok - timeout", 1);
							return;
						}
						continue;
					}
					if (i == 0)
					{
						this.Mensagem_MD201("Erro ao programar página 2 - não determinado", 1);
						return;
					}
				}
				IL_207:
				i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
				while (i > 0)
				{
					i--;
					Comunicacao.CMD_Esc_habilitacao(21930, 255);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						this.Mensagem_MD201("Programação finalizada", 0);
						return;
					case 2:
						if (i == 0)
						{
							this.Mensagem_MD201("Erro ao finalizar a programação - conferência", 1);
							return;
						}
						continue;
					case 3:
						if (i == 0)
						{
							this.Mensagem_MD201("Erro ao finalizar a programação - timeout", 1);
							return;
						}
						continue;
					}
					if (i == 0)
					{
						this.Mensagem_MD201("Erro ao finalizar a programação - não determinado", 1);
						return;
					}
				}
			}
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x00422D00 File Offset: 0x00421100
		private void Valor_end_origem_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_end_origem.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.End_origem = num;
			}
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x00422D48 File Offset: 0x00421148
		private void Valor_intervalo_varredura_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_intervalo_varredura.Text)));
			if (num < 3 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Tempo_varredura = num;
			}
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x00422D90 File Offset: 0x00421190
		private void Valor_numero_recalques_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_numero_recalques.Text)));
			if (num < 0 | num > 40)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Numero_recalques = num;
			}
			this.Atualiza_tela_VA230();
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x00422DDC File Offset: 0x004211DC
		private void Valor_escala_canal_0_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_escala_canal_0.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 1] = num;
			}
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x00422E34 File Offset: 0x00421234
		private void Valor_escala_canal_1_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_escala_canal_1.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 2] = num;
			}
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x00422E8C File Offset: 0x0042128C
		private void Valor_escala_canal_2_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_escala_canal_2.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 3] = num;
			}
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x00422EE4 File Offset: 0x004212E4
		private void Valor_escala_canal_3_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_escala_canal_3.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 4] = num;
			}
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x00422F3C File Offset: 0x0042133C
		private void Valor_escala_canal_4_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_escala_canal_4.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 5] = num;
			}
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x00422F94 File Offset: 0x00421394
		private void Valor_escala_canal_5_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_escala_canal_5.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 6] = num;
			}
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x00422FEC File Offset: 0x004213EC
		private void Valor_escala_canal_6_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_escala_canal_6.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 7] = num;
			}
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x00423044 File Offset: 0x00421444
		private void Valor_escala_canal_7_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_escala_canal_7.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 8] = num;
			}
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x0042309C File Offset: 0x0042149C
		private void Valor_escala_canal_8_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_escala_canal_8.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 9] = num;
			}
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x004230F4 File Offset: 0x004214F4
		private void Valor_escala_canal_9_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_escala_canal_9.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 10] = num;
			}
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x0042314C File Offset: 0x0042154C
		private void Valor_escala_canal_10_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_escala_canal_10.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 11] = num;
			}
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x004231A4 File Offset: 0x004215A4
		private void Valor_escala_canal_11_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_escala_canal_11.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 12] = num;
			}
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x004231FC File Offset: 0x004215FC
		private void Valor_escala_canal_12_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_escala_canal_12.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 13] = num;
			}
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x00423254 File Offset: 0x00421654
		private void Valor_escala_canal_13_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_escala_canal_13.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 14] = num;
			}
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x004232AC File Offset: 0x004216AC
		private void Valor_escala_canal_14_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_escala_canal_14.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 15] = num;
			}
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x00423304 File Offset: 0x00421704
		private void Valor_escala_canal_15_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_escala_canal_15.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA230.Escalas[Mod_VA.Config_VA230.Indice, 16] = num;
			}
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x0042335C File Offset: 0x0042175C
		private void VScroll_end_estacao_Scroll(object sender, ScrollEventArgs e)
		{
			this.Valor_end_estacao.Text = Conversion.Str(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null)));
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x00423388 File Offset: 0x00421788
		private void Valor_end_estacao_TextChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA230.Indice = Conversions.ToInteger(this.Valor_end_estacao.Text);
			if (Conversions.ToDouble(this.Valor_end_estacao.Text) != 0.0)
			{
				this.Atualiza_tela_VA230();
			}
		}

		// Token: 0x04001B26 RID: 6950
		[AccessedThroughProperty("grupo_parametros_gerais")]
		private GroupBox _grupo_parametros_gerais;

		// Token: 0x04001B27 RID: 6951
		[AccessedThroughProperty("Valor_intervalo_varredura")]
		private TextBox _Valor_intervalo_varredura;

		// Token: 0x04001B28 RID: 6952
		[AccessedThroughProperty("Label_intervalo_varredura")]
		private Label _Label_intervalo_varredura;

		// Token: 0x04001B29 RID: 6953
		[AccessedThroughProperty("Valor_end_origem")]
		private TextBox _Valor_end_origem;

		// Token: 0x04001B2A RID: 6954
		[AccessedThroughProperty("Valor_numero_recalques")]
		private TextBox _Valor_numero_recalques;

		// Token: 0x04001B2B RID: 6955
		[AccessedThroughProperty("Label_end_origem")]
		private Label _Label_end_origem;

		// Token: 0x04001B2C RID: 6956
		[AccessedThroughProperty("Label_numero_recalques")]
		private Label _Label_numero_recalques;

		// Token: 0x04001B2D RID: 6957
		[AccessedThroughProperty("Grupo_ctrl")]
		private GroupBox _Grupo_ctrl;

		// Token: 0x04001B2E RID: 6958
		[AccessedThroughProperty("Esc_conf_md_201")]
		private Button _Esc_conf_md_201;

		// Token: 0x04001B2F RID: 6959
		[AccessedThroughProperty("Box_Msg")]
		private TextBox _Box_Msg;

		// Token: 0x04001B30 RID: 6960
		[AccessedThroughProperty("Ler_conf_md_201")]
		private Button _Ler_conf_md_201;

		// Token: 0x04001B31 RID: 6961
		[AccessedThroughProperty("grupo_escalas")]
		private GroupBox _grupo_escalas;

		// Token: 0x04001B32 RID: 6962
		[AccessedThroughProperty("Valor_escala_canal_0")]
		private TextBox _Valor_escala_canal_0;

		// Token: 0x04001B33 RID: 6963
		[AccessedThroughProperty("Label_escala_canal_0")]
		private Label _Label_escala_canal_0;

		// Token: 0x04001B34 RID: 6964
		[AccessedThroughProperty("Valor_escala_canal_7")]
		private TextBox _Valor_escala_canal_7;

		// Token: 0x04001B35 RID: 6965
		[AccessedThroughProperty("Valor_escala_canal_6")]
		private TextBox _Valor_escala_canal_6;

		// Token: 0x04001B36 RID: 6966
		[AccessedThroughProperty("Valor_escala_canal_5")]
		private TextBox _Valor_escala_canal_5;

		// Token: 0x04001B37 RID: 6967
		[AccessedThroughProperty("Valor_escala_canal_4")]
		private TextBox _Valor_escala_canal_4;

		// Token: 0x04001B38 RID: 6968
		[AccessedThroughProperty("Valor_escala_canal_3")]
		private TextBox _Valor_escala_canal_3;

		// Token: 0x04001B39 RID: 6969
		[AccessedThroughProperty("Valor_escala_canal_2")]
		private TextBox _Valor_escala_canal_2;

		// Token: 0x04001B3A RID: 6970
		[AccessedThroughProperty("Valor_escala_canal_1")]
		private TextBox _Valor_escala_canal_1;

		// Token: 0x04001B3B RID: 6971
		[AccessedThroughProperty("Label_escala_canal_7")]
		private Label _Label_escala_canal_7;

		// Token: 0x04001B3C RID: 6972
		[AccessedThroughProperty("Label_escala_canal_6")]
		private Label _Label_escala_canal_6;

		// Token: 0x04001B3D RID: 6973
		[AccessedThroughProperty("Label_escala_canal_5")]
		private Label _Label_escala_canal_5;

		// Token: 0x04001B3E RID: 6974
		[AccessedThroughProperty("Label_escala_canal_4")]
		private Label _Label_escala_canal_4;

		// Token: 0x04001B3F RID: 6975
		[AccessedThroughProperty("Label_escala_canal_3")]
		private Label _Label_escala_canal_3;

		// Token: 0x04001B40 RID: 6976
		[AccessedThroughProperty("Label_escala_canal_2")]
		private Label _Label_escala_canal_2;

		// Token: 0x04001B41 RID: 6977
		[AccessedThroughProperty("Label_escala_canal_1")]
		private Label _Label_escala_canal_1;

		// Token: 0x04001B42 RID: 6978
		[AccessedThroughProperty("Valor_escala_canal_15")]
		private TextBox _Valor_escala_canal_15;

		// Token: 0x04001B43 RID: 6979
		[AccessedThroughProperty("Valor_escala_canal_14")]
		private TextBox _Valor_escala_canal_14;

		// Token: 0x04001B44 RID: 6980
		[AccessedThroughProperty("Valor_escala_canal_13")]
		private TextBox _Valor_escala_canal_13;

		// Token: 0x04001B45 RID: 6981
		[AccessedThroughProperty("Valor_escala_canal_12")]
		private TextBox _Valor_escala_canal_12;

		// Token: 0x04001B46 RID: 6982
		[AccessedThroughProperty("Valor_escala_canal_11")]
		private TextBox _Valor_escala_canal_11;

		// Token: 0x04001B47 RID: 6983
		[AccessedThroughProperty("Valor_escala_canal_10")]
		private TextBox _Valor_escala_canal_10;

		// Token: 0x04001B48 RID: 6984
		[AccessedThroughProperty("Valor_escala_canal_9")]
		private TextBox _Valor_escala_canal_9;

		// Token: 0x04001B49 RID: 6985
		[AccessedThroughProperty("Valor_escala_canal_8")]
		private TextBox _Valor_escala_canal_8;

		// Token: 0x04001B4A RID: 6986
		[AccessedThroughProperty("Label_escala_canal_15")]
		private Label _Label_escala_canal_15;

		// Token: 0x04001B4B RID: 6987
		[AccessedThroughProperty("Label_escala_canal_14")]
		private Label _Label_escala_canal_14;

		// Token: 0x04001B4C RID: 6988
		[AccessedThroughProperty("Label_escala_canal_13")]
		private Label _Label_escala_canal_13;

		// Token: 0x04001B4D RID: 6989
		[AccessedThroughProperty("Label_escala_canal_12")]
		private Label _Label_escala_canal_12;

		// Token: 0x04001B4E RID: 6990
		[AccessedThroughProperty("Label_escala_canal_11")]
		private Label _Label_escala_canal_11;

		// Token: 0x04001B4F RID: 6991
		[AccessedThroughProperty("Label_escala_canal_10")]
		private Label _Label_escala_canal_10;

		// Token: 0x04001B50 RID: 6992
		[AccessedThroughProperty("Label_escala_canal_9")]
		private Label _Label_escala_canal_9;

		// Token: 0x04001B51 RID: 6993
		[AccessedThroughProperty("Label_escala_canal_8")]
		private Label _Label_escala_canal_8;

		// Token: 0x04001B52 RID: 6994
		[AccessedThroughProperty("Label_end_estacao")]
		private Label _Label_end_estacao;

		// Token: 0x04001B53 RID: 6995
		[AccessedThroughProperty("VScroll_end_estacao")]
		private VScrollBar _VScroll_end_estacao;

		// Token: 0x04001B54 RID: 6996
		[AccessedThroughProperty("Valor_end_estacao")]
		private TextBox _Valor_end_estacao;

		// Token: 0x04001B55 RID: 6997
		private int passo_va230;

		// Token: 0x04001B56 RID: 6998
		private int passo_va230_motor;
	}
}
