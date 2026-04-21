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
	// Token: 0x02000081 RID: 129
	[DesignerGenerated]
	public partial class Equip_201_conf : Form
	{
		// Token: 0x06001BF0 RID: 7152 RVA: 0x003CCC28 File Offset: 0x003CB028
		public Equip_201_conf()
		{
			base.Load += new EventHandler(this.Equip_201_conf_Load);
			this.InitializeComponent();
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x003CFF60 File Offset: 0x003CE360
		// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x003CFF74 File Offset: 0x003CE374
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

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x003CFF80 File Offset: 0x003CE380
		// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x003CFF94 File Offset: 0x003CE394
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

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x003CFFA0 File Offset: 0x003CE3A0
		// (set) Token: 0x06001BF8 RID: 7160 RVA: 0x003CFFB4 File Offset: 0x003CE3B4
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

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06001BF9 RID: 7161 RVA: 0x003CFFC0 File Offset: 0x003CE3C0
		// (set) Token: 0x06001BFA RID: 7162 RVA: 0x003CFFD4 File Offset: 0x003CE3D4
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

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06001BFB RID: 7163 RVA: 0x003CFFE0 File Offset: 0x003CE3E0
		// (set) Token: 0x06001BFC RID: 7164 RVA: 0x003CFFF4 File Offset: 0x003CE3F4
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

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x003D0000 File Offset: 0x003CE400
		// (set) Token: 0x06001BFE RID: 7166 RVA: 0x003D0014 File Offset: 0x003CE414
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

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x003D0020 File Offset: 0x003CE420
		// (set) Token: 0x06001C00 RID: 7168 RVA: 0x003D0034 File Offset: 0x003CE434
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

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001C01 RID: 7169 RVA: 0x003D0080 File Offset: 0x003CE480
		// (set) Token: 0x06001C02 RID: 7170 RVA: 0x003D0094 File Offset: 0x003CE494
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

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001C03 RID: 7171 RVA: 0x003D00A0 File Offset: 0x003CE4A0
		// (set) Token: 0x06001C04 RID: 7172 RVA: 0x003D00B4 File Offset: 0x003CE4B4
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

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x003D0100 File Offset: 0x003CE500
		// (set) Token: 0x06001C06 RID: 7174 RVA: 0x003D0114 File Offset: 0x003CE514
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

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x003D0120 File Offset: 0x003CE520
		// (set) Token: 0x06001C08 RID: 7176 RVA: 0x003D0134 File Offset: 0x003CE534
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

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x003D0180 File Offset: 0x003CE580
		// (set) Token: 0x06001C0A RID: 7178 RVA: 0x003D0194 File Offset: 0x003CE594
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

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x003D01A0 File Offset: 0x003CE5A0
		// (set) Token: 0x06001C0C RID: 7180 RVA: 0x003D01B4 File Offset: 0x003CE5B4
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

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001C0D RID: 7181 RVA: 0x003D0200 File Offset: 0x003CE600
		// (set) Token: 0x06001C0E RID: 7182 RVA: 0x003D0214 File Offset: 0x003CE614
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

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001C0F RID: 7183 RVA: 0x003D0220 File Offset: 0x003CE620
		// (set) Token: 0x06001C10 RID: 7184 RVA: 0x003D0234 File Offset: 0x003CE634
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

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001C11 RID: 7185 RVA: 0x003D0280 File Offset: 0x003CE680
		// (set) Token: 0x06001C12 RID: 7186 RVA: 0x003D0294 File Offset: 0x003CE694
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

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001C13 RID: 7187 RVA: 0x003D02A0 File Offset: 0x003CE6A0
		// (set) Token: 0x06001C14 RID: 7188 RVA: 0x003D02B4 File Offset: 0x003CE6B4
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

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x003D0300 File Offset: 0x003CE700
		// (set) Token: 0x06001C16 RID: 7190 RVA: 0x003D0314 File Offset: 0x003CE714
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

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x003D0320 File Offset: 0x003CE720
		// (set) Token: 0x06001C18 RID: 7192 RVA: 0x003D0334 File Offset: 0x003CE734
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

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x003D0380 File Offset: 0x003CE780
		// (set) Token: 0x06001C1A RID: 7194 RVA: 0x003D0394 File Offset: 0x003CE794
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

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x003D03A0 File Offset: 0x003CE7A0
		// (set) Token: 0x06001C1C RID: 7196 RVA: 0x003D03B4 File Offset: 0x003CE7B4
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

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x003D0400 File Offset: 0x003CE800
		// (set) Token: 0x06001C1E RID: 7198 RVA: 0x003D0414 File Offset: 0x003CE814
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

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x003D0420 File Offset: 0x003CE820
		// (set) Token: 0x06001C20 RID: 7200 RVA: 0x003D0434 File Offset: 0x003CE834
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

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x003D0480 File Offset: 0x003CE880
		// (set) Token: 0x06001C22 RID: 7202 RVA: 0x003D0494 File Offset: 0x003CE894
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

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x003D04A0 File Offset: 0x003CE8A0
		// (set) Token: 0x06001C24 RID: 7204 RVA: 0x003D04B4 File Offset: 0x003CE8B4
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

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x003D0500 File Offset: 0x003CE900
		// (set) Token: 0x06001C26 RID: 7206 RVA: 0x003D0514 File Offset: 0x003CE914
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

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x003D0520 File Offset: 0x003CE920
		// (set) Token: 0x06001C28 RID: 7208 RVA: 0x003D0534 File Offset: 0x003CE934
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

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x003D0540 File Offset: 0x003CE940
		// (set) Token: 0x06001C2A RID: 7210 RVA: 0x003D0554 File Offset: 0x003CE954
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

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x003D05A0 File Offset: 0x003CE9A0
		// (set) Token: 0x06001C2C RID: 7212 RVA: 0x003D05B4 File Offset: 0x003CE9B4
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

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x003D0600 File Offset: 0x003CEA00
		// (set) Token: 0x06001C2E RID: 7214 RVA: 0x003D0614 File Offset: 0x003CEA14
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

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x003D0620 File Offset: 0x003CEA20
		// (set) Token: 0x06001C30 RID: 7216 RVA: 0x003D0634 File Offset: 0x003CEA34
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

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x003D0680 File Offset: 0x003CEA80
		// (set) Token: 0x06001C32 RID: 7218 RVA: 0x003D0694 File Offset: 0x003CEA94
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

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x003D06E0 File Offset: 0x003CEAE0
		// (set) Token: 0x06001C34 RID: 7220 RVA: 0x003D06F4 File Offset: 0x003CEAF4
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

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x003D0700 File Offset: 0x003CEB00
		// (set) Token: 0x06001C36 RID: 7222 RVA: 0x003D0714 File Offset: 0x003CEB14
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

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x003D0720 File Offset: 0x003CEB20
		// (set) Token: 0x06001C38 RID: 7224 RVA: 0x003D0734 File Offset: 0x003CEB34
		internal virtual GroupBox Grupo_motores
		{
			get
			{
				return this._Grupo_motores;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_motores = value;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x003D0740 File Offset: 0x003CEB40
		// (set) Token: 0x06001C3A RID: 7226 RVA: 0x003D0754 File Offset: 0x003CEB54
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

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x003D0760 File Offset: 0x003CEB60
		// (set) Token: 0x06001C3C RID: 7228 RVA: 0x003D0774 File Offset: 0x003CEB74
		internal virtual GroupBox Grupo_M1
		{
			get
			{
				return this._Grupo_M1;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_M1 = value;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x003D0780 File Offset: 0x003CEB80
		// (set) Token: 0x06001C3E RID: 7230 RVA: 0x003D0794 File Offset: 0x003CEB94
		internal virtual Label Label_nivel_acionamento_m1
		{
			get
			{
				return this._Label_nivel_acionamento_m1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_acionamento_m1 = value;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x003D07A0 File Offset: 0x003CEBA0
		// (set) Token: 0x06001C40 RID: 7232 RVA: 0x003D07B4 File Offset: 0x003CEBB4
		internal virtual ComboBox Combo_modo_partida_m1
		{
			get
			{
				return this._Combo_modo_partida_m1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_modo_partida_m1_SelectedIndexChanged);
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

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x003D0800 File Offset: 0x003CEC00
		// (set) Token: 0x06001C42 RID: 7234 RVA: 0x003D0814 File Offset: 0x003CEC14
		internal virtual Label Label_modo_partida_m1
		{
			get
			{
				return this._Label_modo_partida_m1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_modo_partida_m1 = value;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x003D0820 File Offset: 0x003CEC20
		// (set) Token: 0x06001C44 RID: 7236 RVA: 0x003D0834 File Offset: 0x003CEC34
		internal virtual Label Label_tempo_parada_m1
		{
			get
			{
				return this._Label_tempo_parada_m1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_parada_m1 = value;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x003D0840 File Offset: 0x003CEC40
		// (set) Token: 0x06001C46 RID: 7238 RVA: 0x003D0854 File Offset: 0x003CEC54
		internal virtual Label Label_tempo_partida_m1
		{
			get
			{
				return this._Label_tempo_partida_m1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_partida_m1 = value;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x003D0860 File Offset: 0x003CEC60
		// (set) Token: 0x06001C48 RID: 7240 RVA: 0x003D0874 File Offset: 0x003CEC74
		internal virtual Label Label_nivel_parada_m1
		{
			get
			{
				return this._Label_nivel_parada_m1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_parada_m1 = value;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x003D0880 File Offset: 0x003CEC80
		// (set) Token: 0x06001C4A RID: 7242 RVA: 0x003D0894 File Offset: 0x003CEC94
		internal virtual GroupBox Grupo_M2
		{
			get
			{
				return this._Grupo_M2;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_M2 = value;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x003D08A0 File Offset: 0x003CECA0
		// (set) Token: 0x06001C4C RID: 7244 RVA: 0x003D08B4 File Offset: 0x003CECB4
		internal virtual Label Label_tempo_parada_m2
		{
			get
			{
				return this._Label_tempo_parada_m2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_parada_m2 = value;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x003D08C0 File Offset: 0x003CECC0
		// (set) Token: 0x06001C4E RID: 7246 RVA: 0x003D08D4 File Offset: 0x003CECD4
		internal virtual Label Label_tempo_partida_m2
		{
			get
			{
				return this._Label_tempo_partida_m2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_partida_m2 = value;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x003D08E0 File Offset: 0x003CECE0
		// (set) Token: 0x06001C50 RID: 7248 RVA: 0x003D08F4 File Offset: 0x003CECF4
		internal virtual Label Label_nivel_parada_m2
		{
			get
			{
				return this._Label_nivel_parada_m2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_parada_m2 = value;
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x003D0900 File Offset: 0x003CED00
		// (set) Token: 0x06001C52 RID: 7250 RVA: 0x003D0914 File Offset: 0x003CED14
		internal virtual Label Label_nivel_acionamento_m2
		{
			get
			{
				return this._Label_nivel_acionamento_m2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_acionamento_m2 = value;
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x003D0920 File Offset: 0x003CED20
		// (set) Token: 0x06001C54 RID: 7252 RVA: 0x003D0934 File Offset: 0x003CED34
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

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x003D0980 File Offset: 0x003CED80
		// (set) Token: 0x06001C56 RID: 7254 RVA: 0x003D0994 File Offset: 0x003CED94
		internal virtual Label Label_modo_partida_m2
		{
			get
			{
				return this._Label_modo_partida_m2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_modo_partida_m2 = value;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x003D09A0 File Offset: 0x003CEDA0
		// (set) Token: 0x06001C58 RID: 7256 RVA: 0x003D09B4 File Offset: 0x003CEDB4
		internal virtual GroupBox Grupo_M3
		{
			get
			{
				return this._Grupo_M3;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_M3 = value;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x003D09C0 File Offset: 0x003CEDC0
		// (set) Token: 0x06001C5A RID: 7258 RVA: 0x003D09D4 File Offset: 0x003CEDD4
		internal virtual Label Label_tempo_parada_m3
		{
			get
			{
				return this._Label_tempo_parada_m3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_parada_m3 = value;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x003D09E0 File Offset: 0x003CEDE0
		// (set) Token: 0x06001C5C RID: 7260 RVA: 0x003D09F4 File Offset: 0x003CEDF4
		internal virtual Label Label_tempo_partida_m3
		{
			get
			{
				return this._Label_tempo_partida_m3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_partida_m3 = value;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x003D0A00 File Offset: 0x003CEE00
		// (set) Token: 0x06001C5E RID: 7262 RVA: 0x003D0A14 File Offset: 0x003CEE14
		internal virtual Label Label_nivel_parada_m3
		{
			get
			{
				return this._Label_nivel_parada_m3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_parada_m3 = value;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x003D0A20 File Offset: 0x003CEE20
		// (set) Token: 0x06001C60 RID: 7264 RVA: 0x003D0A34 File Offset: 0x003CEE34
		internal virtual Label Label_nivel_acionamento_m3
		{
			get
			{
				return this._Label_nivel_acionamento_m3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_acionamento_m3 = value;
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x003D0A40 File Offset: 0x003CEE40
		// (set) Token: 0x06001C62 RID: 7266 RVA: 0x003D0A54 File Offset: 0x003CEE54
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

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x003D0AA0 File Offset: 0x003CEEA0
		// (set) Token: 0x06001C64 RID: 7268 RVA: 0x003D0AB4 File Offset: 0x003CEEB4
		internal virtual Label Label_modo_partida_m3
		{
			get
			{
				return this._Label_modo_partida_m3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_modo_partida_m3 = value;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x003D0AC0 File Offset: 0x003CEEC0
		// (set) Token: 0x06001C66 RID: 7270 RVA: 0x003D0AD4 File Offset: 0x003CEED4
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

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x003D0AE0 File Offset: 0x003CEEE0
		// (set) Token: 0x06001C68 RID: 7272 RVA: 0x003D0AF4 File Offset: 0x003CEEF4
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

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x003D0B40 File Offset: 0x003CEF40
		// (set) Token: 0x06001C6A RID: 7274 RVA: 0x003D0B54 File Offset: 0x003CEF54
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

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x003D0B60 File Offset: 0x003CEF60
		// (set) Token: 0x06001C6C RID: 7276 RVA: 0x003D0B74 File Offset: 0x003CEF74
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

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x003D0BC0 File Offset: 0x003CEFC0
		// (set) Token: 0x06001C6E RID: 7278 RVA: 0x003D0BD4 File Offset: 0x003CEFD4
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

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x003D0BE0 File Offset: 0x003CEFE0
		// (set) Token: 0x06001C70 RID: 7280 RVA: 0x003D0BF4 File Offset: 0x003CEFF4
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

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x003D0C40 File Offset: 0x003CF040
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x003D0C54 File Offset: 0x003CF054
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

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x003D0CA0 File Offset: 0x003CF0A0
		// (set) Token: 0x06001C74 RID: 7284 RVA: 0x003D0CB4 File Offset: 0x003CF0B4
		internal virtual NumericUpDown Valor_end_rep
		{
			get
			{
				return this._Valor_end_rep;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_end_est_rep_ValueChanged);
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

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x003D0D00 File Offset: 0x003CF100
		// (set) Token: 0x06001C76 RID: 7286 RVA: 0x003D0D14 File Offset: 0x003CF114
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

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x003D0D60 File Offset: 0x003CF160
		// (set) Token: 0x06001C78 RID: 7288 RVA: 0x003D0D74 File Offset: 0x003CF174
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

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x003D0DC0 File Offset: 0x003CF1C0
		// (set) Token: 0x06001C7A RID: 7290 RVA: 0x003D0DD4 File Offset: 0x003CF1D4
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

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001C7B RID: 7291 RVA: 0x003D0E20 File Offset: 0x003CF220
		// (set) Token: 0x06001C7C RID: 7292 RVA: 0x003D0E34 File Offset: 0x003CF234
		internal virtual NumericUpDown Nivel_parada_m1
		{
			get
			{
				return this._Nivel_parada_m1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Nivel_parada_m1_ValueChanged);
				if (this._Nivel_parada_m1 != null)
				{
					this._Nivel_parada_m1.ValueChanged -= eventHandler;
				}
				this._Nivel_parada_m1 = value;
				if (this._Nivel_parada_m1 != null)
				{
					this._Nivel_parada_m1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x003D0E80 File Offset: 0x003CF280
		// (set) Token: 0x06001C7E RID: 7294 RVA: 0x003D0E94 File Offset: 0x003CF294
		internal virtual NumericUpDown Nivel_partida_m1
		{
			get
			{
				return this._Nivel_partida_m1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Nivel_partida_m1_ValueChanged);
				if (this._Nivel_partida_m1 != null)
				{
					this._Nivel_partida_m1.ValueChanged -= eventHandler;
				}
				this._Nivel_partida_m1 = value;
				if (this._Nivel_partida_m1 != null)
				{
					this._Nivel_partida_m1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x003D0EE0 File Offset: 0x003CF2E0
		// (set) Token: 0x06001C80 RID: 7296 RVA: 0x003D0EF4 File Offset: 0x003CF2F4
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

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001C81 RID: 7297 RVA: 0x003D0F40 File Offset: 0x003CF340
		// (set) Token: 0x06001C82 RID: 7298 RVA: 0x003D0F54 File Offset: 0x003CF354
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

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x003D0FA0 File Offset: 0x003CF3A0
		// (set) Token: 0x06001C84 RID: 7300 RVA: 0x003D0FB4 File Offset: 0x003CF3B4
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

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x003D1000 File Offset: 0x003CF400
		// (set) Token: 0x06001C86 RID: 7302 RVA: 0x003D1014 File Offset: 0x003CF414
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

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x003D1060 File Offset: 0x003CF460
		// (set) Token: 0x06001C88 RID: 7304 RVA: 0x003D1074 File Offset: 0x003CF474
		internal virtual NumericUpDown Nivel_partida_m2
		{
			get
			{
				return this._Nivel_partida_m2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Nivel_partida_m2_ValueChanged);
				if (this._Nivel_partida_m2 != null)
				{
					this._Nivel_partida_m2.ValueChanged -= eventHandler;
				}
				this._Nivel_partida_m2 = value;
				if (this._Nivel_partida_m2 != null)
				{
					this._Nivel_partida_m2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x003D10C0 File Offset: 0x003CF4C0
		// (set) Token: 0x06001C8A RID: 7306 RVA: 0x003D10D4 File Offset: 0x003CF4D4
		internal virtual NumericUpDown Nivel_parada_m2
		{
			get
			{
				return this._Nivel_parada_m2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Nivel_parada_m2_ValueChanged);
				if (this._Nivel_parada_m2 != null)
				{
					this._Nivel_parada_m2.ValueChanged -= eventHandler;
				}
				this._Nivel_parada_m2 = value;
				if (this._Nivel_parada_m2 != null)
				{
					this._Nivel_parada_m2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x003D1120 File Offset: 0x003CF520
		// (set) Token: 0x06001C8C RID: 7308 RVA: 0x003D1134 File Offset: 0x003CF534
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

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x003D1180 File Offset: 0x003CF580
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x003D1194 File Offset: 0x003CF594
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

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x003D11E0 File Offset: 0x003CF5E0
		// (set) Token: 0x06001C90 RID: 7312 RVA: 0x003D11F4 File Offset: 0x003CF5F4
		internal virtual NumericUpDown Nivel_partida_m3
		{
			get
			{
				return this._Nivel_partida_m3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Nivel_partida_m3_ValueChanged);
				if (this._Nivel_partida_m3 != null)
				{
					this._Nivel_partida_m3.ValueChanged -= eventHandler;
				}
				this._Nivel_partida_m3 = value;
				if (this._Nivel_partida_m3 != null)
				{
					this._Nivel_partida_m3.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x003D1240 File Offset: 0x003CF640
		// (set) Token: 0x06001C92 RID: 7314 RVA: 0x003D1254 File Offset: 0x003CF654
		internal virtual NumericUpDown Nivel_parada_m3
		{
			get
			{
				return this._Nivel_parada_m3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Nivel_parada_m3_ValueChanged);
				if (this._Nivel_parada_m3 != null)
				{
					this._Nivel_parada_m3.ValueChanged -= eventHandler;
				}
				this._Nivel_parada_m3 = value;
				if (this._Nivel_parada_m3 != null)
				{
					this._Nivel_parada_m3.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x003D12A0 File Offset: 0x003CF6A0
		// (set) Token: 0x06001C94 RID: 7316 RVA: 0x003D12B4 File Offset: 0x003CF6B4
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

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x003D1300 File Offset: 0x003CF700
		// (set) Token: 0x06001C96 RID: 7318 RVA: 0x003D1314 File Offset: 0x003CF714
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

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x003D1320 File Offset: 0x003CF720
		// (set) Token: 0x06001C98 RID: 7320 RVA: 0x003D1334 File Offset: 0x003CF734
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

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x003D1340 File Offset: 0x003CF740
		// (set) Token: 0x06001C9A RID: 7322 RVA: 0x003D1354 File Offset: 0x003CF754
		internal virtual ToolStripMenuItem SalvarToolStripMenuItem
		{
			get
			{
				return this._SalvarToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NovoToolStripMenuItem_Click);
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

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x003D13A0 File Offset: 0x003CF7A0
		// (set) Token: 0x06001C9C RID: 7324 RVA: 0x003D13B4 File Offset: 0x003CF7B4
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

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06001C9D RID: 7325 RVA: 0x003D1400 File Offset: 0x003CF800
		// (set) Token: 0x06001C9E RID: 7326 RVA: 0x003D1414 File Offset: 0x003CF814
		internal virtual ToolStripMenuItem NovoToolStripMenuItem
		{
			get
			{
				return this._NovoToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SalvarToolStripMenuItem_Click);
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

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06001C9F RID: 7327 RVA: 0x003D1460 File Offset: 0x003CF860
		// (set) Token: 0x06001CA0 RID: 7328 RVA: 0x003D1474 File Offset: 0x003CF874
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

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x003D1480 File Offset: 0x003CF880
		// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x003D1494 File Offset: 0x003CF894
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

		// Token: 0x06001CA3 RID: 7331 RVA: 0x003D14A0 File Offset: 0x003CF8A0
		private void Equip_201_conf_Load(object sender, EventArgs e)
		{
			this.Combo_modo_partida_m1.Items.Clear();
			this.Combo_modo_partida_m1.Items.Add("Manual");
			this.Combo_modo_partida_m1.Items.Add("Automático");
			this.Combo_modo_partida_m2.Items.Clear();
			this.Combo_modo_partida_m2.Items.Add("Manual");
			this.Combo_modo_partida_m2.Items.Add("Automático");
			this.Combo_modo_partida_m3.Items.Clear();
			this.Combo_modo_partida_m3.Items.Add("Manual");
			this.Combo_modo_partida_m3.Items.Add("Automático");
			this.passo_201 = 0;
			Mod_MD.Init_equipamento_MD201();
			this.Limpa_estrutura_MD201(Mod_MD.Controle.Estacao);
			this.Atualiza_tela_MD201(Mod_MD.Controle.Estacao);
			Geral.Config_geral.Largura_tela_trabalho = this.Width;
			int num = 48;
			Interaction.MsgBox("Colocar o equipamento em modo de programação !\r\nFechar o jumper de configuração.", num, " Atenção - verifique a configuração");
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x003D15B4 File Offset: 0x003CF9B4
		public void Limpa_estrutura_MD201(int indice)
		{
			Mod_MD.Recalque_201[indice].Repetidoras = new int[51];
			Mod_MD.Recalque_201[indice].Modo_partida = new int[4];
			Mod_MD.Recalque_201[indice].Nivel_acionamento = new int[4];
			Mod_MD.Recalque_201[indice].Nivel_parada = new int[4];
			Mod_MD.Recalque_201[indice].Tempo_partida = new int[4];
			Mod_MD.Recalque_201[indice].Tempo_parada = new int[4];
			Mod_MD.Recalque_201[indice].End_estacao = 0;
			Mod_MD.Recalque_201[indice].End_mestre = 0;
			Mod_MD.Recalque_201[indice].Hab_repetidora = 0;
			Mod_MD.Recalque_201[indice].Tempo_ptt = 1;
			Mod_MD.Recalque_201[indice].Quantidade_motores = 0;
			Mod_MD.Recalque_201[indice].Tempo_entre_acionamento = 0;
			Mod_MD.Recalque_201[indice].Modo_partida[1] = 21877;
			Mod_MD.Recalque_201[indice].Modo_partida[2] = 21877;
			Mod_MD.Recalque_201[indice].Modo_partida[3] = 21877;
			Mod_MD.Recalque_201[indice].Nivel_acionamento[1] = 0;
			Mod_MD.Recalque_201[indice].Nivel_acionamento[2] = 0;
			Mod_MD.Recalque_201[indice].Nivel_acionamento[3] = 0;
			Mod_MD.Recalque_201[indice].Nivel_parada[1] = 0;
			Mod_MD.Recalque_201[indice].Nivel_parada[2] = 0;
			Mod_MD.Recalque_201[indice].Nivel_parada[3] = 0;
			Mod_MD.Recalque_201[indice].Tempo_partida[1] = 0;
			Mod_MD.Recalque_201[indice].Tempo_partida[2] = 0;
			Mod_MD.Recalque_201[indice].Tempo_partida[3] = 0;
			Mod_MD.Recalque_201[indice].Tempo_parada[1] = 0;
			Mod_MD.Recalque_201[indice].Tempo_parada[2] = 0;
			Mod_MD.Recalque_201[indice].Tempo_parada[3] = 0;
			Mod_MD.Recalque_201[indice].End_repetidora = 0;
			Mod_MD.Recalque_201[indice].Num_repetidoras = 0;
			int num = 0;
			checked
			{
				do
				{
					Mod_MD.Recalque_201[indice].Repetidoras[num] = 0;
					num++;
				}
				while (num <= 50);
				this.VScrollBar1.Value = 0;
				this.Numero_motores.Value = 0m;
			}
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x003D1834 File Offset: 0x003CFC34
		public void Atualiza_tela_MD201(int indice)
		{
			this.Atualiza_tela_MD201_repetidora(indice);
			this.Atualiza_tela_MD201_motores(indice);
			this.Valor_end_est.Value = new decimal(Mod_MD.Recalque_201[indice].End_estacao);
			this.Valor_end_mestre.Value = new decimal(Mod_MD.Recalque_201[indice].End_mestre);
			this.Valor_end_rep.Value = new decimal(Mod_MD.Recalque_201[indice].End_repetidora);
			this.Valor_num_est_rep.Text = Conversions.ToString(Mod_MD.Recalque_201[indice].Num_repetidoras);
			checked
			{
				this.Valor_temp_ptt.Value = new decimal(Mod_MD.Recalque_201[indice].Tempo_ptt * 10);
				this.Numero_motores.Value = new decimal(Mod_MD.Recalque_201[indice].Quantidade_motores);
				this.Combo_modo_partida_m1.SelectedIndex = Mod_MD.Recalque_201[indice].Modo_partida[1] - 21877;
				this.Combo_modo_partida_m2.SelectedIndex = Mod_MD.Recalque_201[indice].Modo_partida[2] - 21877;
				this.Combo_modo_partida_m3.SelectedIndex = Mod_MD.Recalque_201[indice].Modo_partida[3] - 21877;
				this.Nivel_partida_m1.Value = new decimal(Mod_MD.Recalque_201[indice].Nivel_acionamento[1]);
				this.Nivel_partida_m2.Value = new decimal(Mod_MD.Recalque_201[indice].Nivel_acionamento[2]);
				this.Nivel_partida_m3.Value = new decimal(Mod_MD.Recalque_201[indice].Nivel_acionamento[3]);
				this.Nivel_parada_m1.Value = new decimal(Mod_MD.Recalque_201[indice].Nivel_parada[1]);
				this.Nivel_parada_m2.Value = new decimal(Mod_MD.Recalque_201[indice].Nivel_parada[2]);
				this.Nivel_parada_m3.Value = new decimal(Mod_MD.Recalque_201[indice].Nivel_parada[3]);
				this.Tempo_partida_m1.Value = new decimal(Mod_MD.Recalque_201[indice].Tempo_partida[1]);
				this.Tempo_partida_m2.Value = new decimal(Mod_MD.Recalque_201[indice].Tempo_partida[2]);
				this.Tempo_partida_m3.Value = new decimal(Mod_MD.Recalque_201[indice].Tempo_partida[3]);
				this.Tempo_parada_m1.Value = new decimal(Mod_MD.Recalque_201[indice].Tempo_parada[1]);
				this.Tempo_parada_m2.Value = new decimal(Mod_MD.Recalque_201[indice].Tempo_parada[2]);
				this.Tempo_parada_m3.Value = new decimal(Mod_MD.Recalque_201[indice].Tempo_parada[3]);
				this.Tempo_entre_acionamentos.Value = new decimal((double)Mod_MD.Recalque_201[indice].Tempo_entre_acionamento / 60.0);
			}
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x003D1B40 File Offset: 0x003CFF40
		public void Atualiza_tela_MD201_motores(int indice)
		{
			this.Grupo_M1.Enabled = false;
			this.Grupo_M2.Enabled = false;
			this.Grupo_M3.Enabled = false;
			if (Mod_MD.Recalque_201[indice].Quantidade_motores == 1)
			{
				this.Grupo_M1.Enabled = true;
			}
			else if (Mod_MD.Recalque_201[indice].Quantidade_motores == 2)
			{
				this.Grupo_M1.Enabled = true;
				this.Grupo_M2.Enabled = true;
			}
			else if (Mod_MD.Recalque_201[indice].Quantidade_motores == 3)
			{
				this.Grupo_M1.Enabled = true;
				this.Grupo_M2.Enabled = true;
				this.Grupo_M3.Enabled = true;
			}
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x003D1BF8 File Offset: 0x003CFFF8
		public void Atualiza_tela_MD201_repetidora(int indice)
		{
			if (Mod_MD.Recalque_201[indice].Hab_repetidora == 21856)
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
			this.Atualiza_tela_MD201_repetidora_enderecos(indice);
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x003D1CB8 File Offset: 0x003D00B8
		public void Atualiza_tela_MD201_repetidora_enderecos(int indice)
		{
			checked
			{
				if (this.passo_201 < 4)
				{
					this.Valor_end_rep_3.Text = Conversions.ToString(Mod_MD.Recalque_201[indice].Repetidoras[3 + this.passo_201 * 12]);
					this.Valor_end_rep_4.Text = Conversions.ToString(Mod_MD.Recalque_201[indice].Repetidoras[4 + this.passo_201 * 12]);
					this.Valor_end_rep_5.Text = Conversions.ToString(Mod_MD.Recalque_201[indice].Repetidoras[5 + this.passo_201 * 12]);
					this.Valor_end_rep_6.Text = Conversions.ToString(Mod_MD.Recalque_201[indice].Repetidoras[6 + this.passo_201 * 12]);
					this.Valor_end_rep_7.Text = Conversions.ToString(Mod_MD.Recalque_201[indice].Repetidoras[7 + this.passo_201 * 12]);
					this.Valor_end_rep_8.Text = Conversions.ToString(Mod_MD.Recalque_201[indice].Repetidoras[8 + this.passo_201 * 12]);
					this.Valor_end_rep_9.Text = Conversions.ToString(Mod_MD.Recalque_201[indice].Repetidoras[9 + this.passo_201 * 12]);
					this.Valor_end_rep_10.Text = Conversions.ToString(Mod_MD.Recalque_201[indice].Repetidoras[10 + this.passo_201 * 12]);
					this.Valor_end_rep_11.Text = Conversions.ToString(Mod_MD.Recalque_201[indice].Repetidoras[11 + this.passo_201 * 12]);
					this.Valor_end_rep_12.Text = Conversions.ToString(Mod_MD.Recalque_201[indice].Repetidoras[12 + this.passo_201 * 12]);
				}
				this.Valor_end_rep_1.Text = Conversions.ToString(Mod_MD.Recalque_201[indice].Repetidoras[1 + this.passo_201 * 12]);
				this.Valor_end_rep_2.Text = Conversions.ToString(Mod_MD.Recalque_201[indice].Repetidoras[2 + this.passo_201 * 12]);
				this.Label_end_rep_1.Text = Strings.Format(1 + this.passo_201 * 12, "00:");
				this.Label_end_rep_2.Text = Strings.Format(2 + this.passo_201 * 12, "00:");
				this.Label_end_rep_3.Text = Strings.Format(3 + this.passo_201 * 12, "00:");
				this.Label_end_rep_4.Text = Strings.Format(4 + this.passo_201 * 12, "00:");
				this.Label_end_rep_5.Text = Strings.Format(5 + this.passo_201 * 12, "00:");
				this.Label_end_rep_6.Text = Strings.Format(6 + this.passo_201 * 12, "00:");
				this.Label_end_rep_7.Text = Strings.Format(7 + this.passo_201 * 12, "00:");
				this.Label_end_rep_8.Text = Strings.Format(8 + this.passo_201 * 12, "00:");
				this.Label_end_rep_9.Text = Strings.Format(9 + this.passo_201 * 12, "00:");
				this.Label_end_rep_10.Text = Strings.Format(10 + this.passo_201 * 12, "00:");
				this.Label_end_rep_11.Text = Strings.Format(11 + this.passo_201 * 12, "00:");
				this.Label_end_rep_12.Text = Strings.Format(12 + this.passo_201 * 12, "00:");
				int num_repetidoras = Mod_MD.Recalque_201[indice].Num_repetidoras;
				if (num_repetidoras - this.passo_201 * 12 - 0 > 0)
				{
					this.Label_end_rep_1.Visible = true;
					this.Valor_end_rep_1.Visible = true;
				}
				else
				{
					this.Label_end_rep_1.Visible = false;
					this.Valor_end_rep_1.Visible = false;
				}
				if (num_repetidoras - this.passo_201 * 12 - 1 > 0)
				{
					this.Label_end_rep_2.Visible = true;
					this.Valor_end_rep_2.Visible = true;
				}
				else
				{
					this.Label_end_rep_2.Visible = false;
					this.Valor_end_rep_2.Visible = false;
				}
				if (num_repetidoras - this.passo_201 * 12 - 2 > 0)
				{
					this.Label_end_rep_3.Visible = true;
					this.Valor_end_rep_3.Visible = true;
				}
				else
				{
					this.Label_end_rep_3.Visible = false;
					this.Valor_end_rep_3.Visible = false;
				}
				if (num_repetidoras - this.passo_201 * 12 - 3 > 0)
				{
					this.Label_end_rep_4.Visible = true;
					this.Valor_end_rep_4.Visible = true;
				}
				else
				{
					this.Label_end_rep_4.Visible = false;
					this.Valor_end_rep_4.Visible = false;
				}
				if (num_repetidoras - this.passo_201 * 12 - 4 > 0)
				{
					this.Label_end_rep_5.Visible = true;
					this.Valor_end_rep_5.Visible = true;
				}
				else
				{
					this.Label_end_rep_5.Visible = false;
					this.Valor_end_rep_5.Visible = false;
				}
				if (num_repetidoras - this.passo_201 * 12 - 5 > 0)
				{
					this.Label_end_rep_6.Visible = true;
					this.Valor_end_rep_6.Visible = true;
				}
				else
				{
					this.Label_end_rep_6.Visible = false;
					this.Valor_end_rep_6.Visible = false;
				}
				if (num_repetidoras - this.passo_201 * 12 - 6 > 0)
				{
					this.Label_end_rep_7.Visible = true;
					this.Valor_end_rep_7.Visible = true;
				}
				else
				{
					this.Label_end_rep_7.Visible = false;
					this.Valor_end_rep_7.Visible = false;
				}
				if (num_repetidoras - this.passo_201 * 12 - 7 > 0)
				{
					this.Label_end_rep_8.Visible = true;
					this.Valor_end_rep_8.Visible = true;
				}
				else
				{
					this.Label_end_rep_8.Visible = false;
					this.Valor_end_rep_8.Visible = false;
				}
				if (num_repetidoras - this.passo_201 * 12 - 8 > 0)
				{
					this.Label_end_rep_9.Visible = true;
					this.Valor_end_rep_9.Visible = true;
				}
				else
				{
					this.Label_end_rep_9.Visible = false;
					this.Valor_end_rep_9.Visible = false;
				}
				if (num_repetidoras - this.passo_201 * 12 - 9 > 0)
				{
					this.Label_end_rep_10.Visible = true;
					this.Valor_end_rep_10.Visible = true;
				}
				else
				{
					this.Label_end_rep_10.Visible = false;
					this.Valor_end_rep_10.Visible = false;
				}
				if (num_repetidoras - this.passo_201 * 12 - 10 > 0)
				{
					this.Label_end_rep_11.Visible = true;
					this.Valor_end_rep_11.Visible = true;
				}
				else
				{
					this.Label_end_rep_11.Visible = false;
					this.Valor_end_rep_11.Visible = false;
				}
				if (num_repetidoras - this.passo_201 * 12 - 11 > 0)
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

		// Token: 0x06001CA9 RID: 7337 RVA: 0x003D23D4 File Offset: 0x003D07D4
		public void Limpa_dados_repetidora_MD201(object indice, object end_inicial)
		{
			checked
			{
				for (int i = Conversions.ToInteger(Operators.AddObject(end_inicial, 1)); i <= 50; i++)
				{
					Mod_MD.Recalque_201[Conversions.ToInteger(indice)].Repetidoras[i] = 0;
				}
			}
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x003D2418 File Offset: 0x003D0818
		private void Ler_conf_md_201_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			this.Ler_conf_md_201.Enabled = false;
			this.Mensagem_MD201("Aguarde ...", 2);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Leitura_pagina(100, 255, 21);
			this.Mensagem_MD201(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Ler_conf_md_201.Enabled = true;
				return;
			}
			Mod_MD.Atualiza_dados_MD201(Mod_MD.Controle.Estacao, 100);
			ctrl_RESP_ = Mod_MD.Leitura_pagina(512, Mod_MD.Recalque_201[1].End_estacao, 52);
			this.Mensagem_MD201(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Ler_conf_md_201.Enabled = true;
				return;
			}
			Mod_MD.Atualiza_dados_MD201(Mod_MD.Controle.Estacao, 512);
			this.Mensagem_MD201("Leitura executada com sucesso", 0);
			this.Atualiza_tela_MD201(Mod_MD.Controle.Estacao);
			this.Ler_conf_md_201.Enabled = true;
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x003D2524 File Offset: 0x003D0924
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

		// Token: 0x06001CAC RID: 7340 RVA: 0x003D2588 File Offset: 0x003D0988
		private void CheckBox_hab_rep_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null), true, false))
			{
				Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Hab_repetidora = 21856;
			}
			else
			{
				Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Hab_repetidora = 0;
			}
			this.Atualiza_tela_MD201_repetidora(Mod_MD.Controle.Estacao);
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x003D2604 File Offset: 0x003D0A04
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
					Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Repetidoras[1 + this.passo_201 * 12] = num;
				}
			}
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x003D2668 File Offset: 0x003D0A68
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
					Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Repetidoras[2 + this.passo_201 * 12] = num;
				}
			}
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x003D26CC File Offset: 0x003D0ACC
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
					Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Repetidoras[3 + this.passo_201 * 12] = num;
				}
			}
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x003D2730 File Offset: 0x003D0B30
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
					Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Repetidoras[4 + this.passo_201 * 12] = num;
				}
			}
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x003D2794 File Offset: 0x003D0B94
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
					Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Repetidoras[5 + this.passo_201 * 12] = num;
				}
			}
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x003D27F8 File Offset: 0x003D0BF8
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
					Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Repetidoras[6 + this.passo_201 * 12] = num;
				}
			}
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x003D285C File Offset: 0x003D0C5C
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
					Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Repetidoras[7 + this.passo_201 * 12] = num;
				}
			}
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x003D28C0 File Offset: 0x003D0CC0
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
					Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Repetidoras[8 + this.passo_201 * 12] = num;
				}
			}
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x003D2924 File Offset: 0x003D0D24
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
					Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Repetidoras[9 + this.passo_201 * 12] = num;
				}
			}
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x003D2988 File Offset: 0x003D0D88
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
					Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Repetidoras[10 + this.passo_201 * 12] = num;
				}
			}
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x003D29EC File Offset: 0x003D0DEC
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
					Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Repetidoras[11 + this.passo_201 * 12] = num;
				}
			}
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x003D2A50 File Offset: 0x003D0E50
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
					Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Repetidoras[12 + this.passo_201 * 12] = num;
				}
			}
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x003D2AB4 File Offset: 0x003D0EB4
		private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
			this.passo_201 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			this.Atualiza_tela_MD201_repetidora_enderecos(Mod_MD.Controle.Estacao);
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x003D2AE8 File Offset: 0x003D0EE8
		private void Esc_conf_md_201_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			this.Esc_conf_md_201.Enabled = false;
			this.Mensagem_MD201("Aguarde ...", 2);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD201(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Esc_conf_md_201.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(100, 2);
			this.Mensagem_MD201(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Esc_conf_md_201.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD201(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Esc_conf_md_201.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD201(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Esc_conf_md_201.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(512, 2);
			this.Mensagem_MD201(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Esc_conf_md_201.Enabled = true;
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD201(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Esc_conf_md_201.Enabled = true;
				return;
			}
			this.Mensagem_MD201("Programação concluída com sucesso", 0);
			this.Esc_conf_md_201.Enabled = true;
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x003D2C7C File Offset: 0x003D107C
		private void Combo_modo_partida_m1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Modo_partida[1] = Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21877));
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x003D2CD0 File Offset: 0x003D10D0
		private void Combo_modo_partida_m2_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Modo_partida[2] = Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21877));
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x003D2D24 File Offset: 0x003D1124
		private void Combo_modo_partida_m3_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Modo_partida[3] = Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21877));
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x003D2D78 File Offset: 0x003D1178
		private void Valor_end_est_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].End_estacao = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x003D2DB0 File Offset: 0x003D11B0
		private void Valor_end_mestre_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].End_mestre = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x003D2DE8 File Offset: 0x003D11E8
		private void Valor_end_est_rep_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].End_repetidora = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x003D2E20 File Offset: 0x003D1220
		private void Valor_num_est_rep_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Num_repetidoras = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Limpa_dados_repetidora_MD201(Mod_MD.Controle.Estacao, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null)));
			this.Atualiza_tela_MD201_repetidora(Mod_MD.Controle.Estacao);
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x003D2EA0 File Offset: 0x003D12A0
		private void Numero_motores_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Quantidade_motores = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Atualiza_tela_MD201_motores(Mod_MD.Controle.Estacao);
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x003D2EF0 File Offset: 0x003D12F0
		private void Tempo_entre_acionamentos_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Tempo_entre_acionamento = Conversions.ToInteger(Operators.MultiplyObject(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null), 60));
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x003D2F3C File Offset: 0x003D133C
		private void Nivel_parada_m1_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Nivel_parada[1] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x003D2F80 File Offset: 0x003D1380
		private void Nivel_partida_m1_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Nivel_acionamento[1] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x003D2FC4 File Offset: 0x003D13C4
		private void Tempo_partida_m1_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Tempo_partida[1] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x003D3008 File Offset: 0x003D1408
		private void Tempo_parada_m1_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Tempo_parada[1] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x003D304C File Offset: 0x003D144C
		private void Nivel_parada_m2_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Nivel_parada[2] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x003D3090 File Offset: 0x003D1490
		private void Nivel_partida_m2_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Nivel_acionamento[2] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x003D30D4 File Offset: 0x003D14D4
		private void Tempo_partida_m2_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Tempo_partida[2] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x003D3118 File Offset: 0x003D1518
		private void Tempo_parada_m2_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Tempo_parada[2] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x003D315C File Offset: 0x003D155C
		private void Nivel_parada_m3_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Nivel_parada[3] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x003D31A0 File Offset: 0x003D15A0
		private void Nivel_partida_m3_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Nivel_acionamento[3] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x003D31E4 File Offset: 0x003D15E4
		private void Tempo_partida_m3_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Tempo_partida[3] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x003D3228 File Offset: 0x003D1628
		private void Tempo_parada_m3_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Tempo_parada[3] = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x003D326C File Offset: 0x003D166C
		private void Valor_temp_ptt_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[Mod_MD.Controle.Estacao].Tempo_ptt = Conversions.ToInteger(Operators.DivideObject(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null), 10));
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x003D32B8 File Offset: 0x003D16B8
		[MethodImpl(72)]
		private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.OpenFileDialog1.Filter = "Arquivo de configuração de equipamento|*.V201";
			this.OpenFileDialog1.InitialDirectory = "c:\\";
			if (this.OpenFileDialog1.ShowDialog() == 1)
			{
				if (Operators.CompareString(this.OpenFileDialog1.FileName, "", false) != 0)
				{
					FileSystem.FileOpen(1, this.OpenFileDialog1.FileName, 4, -1, -1, 500);
					int num = 1;
					Mod_MD.DADOS_EQUIP_MD_201_CONFIG[] recalque_ = Mod_MD.Recalque_201;
					Mod_MD.DADOS_EQUIP_MD_201_CONFIG[] array = recalque_;
					int num2 = 1;
					ValueType valueType = array[num2];
					FileSystem.FileGet(num, ref valueType, -1L);
					Mod_MD.DADOS_EQUIP_MD_201_CONFIG[] array2 = recalque_;
					int num3 = num2;
					ValueType valueType2 = valueType;
					Mod_MD.DADOS_EQUIP_MD_201_CONFIG dados_EQUIP_MD_201_CONFIG;
					array2[num3] = ((valueType2 != null) ? ((Mod_MD.DADOS_EQUIP_MD_201_CONFIG)valueType2) : dados_EQUIP_MD_201_CONFIG);
					FileSystem.FileClose(new int[]
					{
						1
					});
				}
				this.Atualiza_tela_MD201(Mod_MD.Controle.Estacao);
			}
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x003D3390 File Offset: 0x003D1790
		private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Limpa_estrutura_MD201(Mod_MD.Controle.Estacao);
			this.Atualiza_tela_MD201(Mod_MD.Controle.Estacao);
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x003D33B4 File Offset: 0x003D17B4
		[MethodImpl(72)]
		private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Mod_MD.Recalque_201[1].Versao = Geral.Config_geral.Versao;
			this.SaveFileDialog1.Filter = "Arquivo de configuração de equipamento|*.V201";
			this.SaveFileDialog1.InitialDirectory = "c:\\";
			if (this.SaveFileDialog1.ShowDialog() == 1 && Operators.CompareString(this.SaveFileDialog1.FileName, "", false) != 0)
			{
				FileSystem.FileOpen(1, this.SaveFileDialog1.FileName, 4, -1, -1, 500);
				FileSystem.FilePut(1, Mod_MD.Recalque_201[1], -1L);
				FileSystem.FileClose(new int[]
				{
					1
				});
			}
		}

		// Token: 0x0400152D RID: 5421
		[AccessedThroughProperty("grupo_comunicacao")]
		private GroupBox _grupo_comunicacao;

		// Token: 0x0400152E RID: 5422
		[AccessedThroughProperty("Label_tempo_ptt")]
		private Label _Label_tempo_ptt;

		// Token: 0x0400152F RID: 5423
		[AccessedThroughProperty("Label_end_mestre")]
		private Label _Label_end_mestre;

		// Token: 0x04001530 RID: 5424
		[AccessedThroughProperty("Label_end_est")]
		private Label _Label_end_est;

		// Token: 0x04001531 RID: 5425
		[AccessedThroughProperty("Grupo_repetidora")]
		private GroupBox _Grupo_repetidora;

		// Token: 0x04001532 RID: 5426
		[AccessedThroughProperty("Grupo_end_rep")]
		private GroupBox _Grupo_end_rep;

		// Token: 0x04001533 RID: 5427
		[AccessedThroughProperty("VScrollBar1")]
		private VScrollBar _VScrollBar1;

		// Token: 0x04001534 RID: 5428
		[AccessedThroughProperty("Label_end_rep_12")]
		private Label _Label_end_rep_12;

		// Token: 0x04001535 RID: 5429
		[AccessedThroughProperty("Valor_end_rep_12")]
		private TextBox _Valor_end_rep_12;

		// Token: 0x04001536 RID: 5430
		[AccessedThroughProperty("Label_end_rep_11")]
		private Label _Label_end_rep_11;

		// Token: 0x04001537 RID: 5431
		[AccessedThroughProperty("Valor_end_rep_11")]
		private TextBox _Valor_end_rep_11;

		// Token: 0x04001538 RID: 5432
		[AccessedThroughProperty("Label_end_rep_6")]
		private Label _Label_end_rep_6;

		// Token: 0x04001539 RID: 5433
		[AccessedThroughProperty("Valor_end_rep_6")]
		private TextBox _Valor_end_rep_6;

		// Token: 0x0400153A RID: 5434
		[AccessedThroughProperty("Label_end_rep_3")]
		private Label _Label_end_rep_3;

		// Token: 0x0400153B RID: 5435
		[AccessedThroughProperty("Valor_end_rep_3")]
		private TextBox _Valor_end_rep_3;

		// Token: 0x0400153C RID: 5436
		[AccessedThroughProperty("Label_end_rep_9")]
		private Label _Label_end_rep_9;

		// Token: 0x0400153D RID: 5437
		[AccessedThroughProperty("Valor_end_rep_9")]
		private TextBox _Valor_end_rep_9;

		// Token: 0x0400153E RID: 5438
		[AccessedThroughProperty("Label_end_rep_8")]
		private Label _Label_end_rep_8;

		// Token: 0x0400153F RID: 5439
		[AccessedThroughProperty("Valor_end_rep_8")]
		private TextBox _Valor_end_rep_8;

		// Token: 0x04001540 RID: 5440
		[AccessedThroughProperty("Label_end_rep_5")]
		private Label _Label_end_rep_5;

		// Token: 0x04001541 RID: 5441
		[AccessedThroughProperty("Valor_end_rep_5")]
		private TextBox _Valor_end_rep_5;

		// Token: 0x04001542 RID: 5442
		[AccessedThroughProperty("Label_end_rep_2")]
		private Label _Label_end_rep_2;

		// Token: 0x04001543 RID: 5443
		[AccessedThroughProperty("Valor_end_rep_2")]
		private TextBox _Valor_end_rep_2;

		// Token: 0x04001544 RID: 5444
		[AccessedThroughProperty("Label_end_rep_10")]
		private Label _Label_end_rep_10;

		// Token: 0x04001545 RID: 5445
		[AccessedThroughProperty("Valor_end_rep_10")]
		private TextBox _Valor_end_rep_10;

		// Token: 0x04001546 RID: 5446
		[AccessedThroughProperty("Label_end_rep_7")]
		private Label _Label_end_rep_7;

		// Token: 0x04001547 RID: 5447
		[AccessedThroughProperty("Label_end_rep_4")]
		private Label _Label_end_rep_4;

		// Token: 0x04001548 RID: 5448
		[AccessedThroughProperty("Valor_end_rep_7")]
		private TextBox _Valor_end_rep_7;

		// Token: 0x04001549 RID: 5449
		[AccessedThroughProperty("Valor_end_rep_4")]
		private TextBox _Valor_end_rep_4;

		// Token: 0x0400154A RID: 5450
		[AccessedThroughProperty("Label_end_rep_1")]
		private Label _Label_end_rep_1;

		// Token: 0x0400154B RID: 5451
		[AccessedThroughProperty("Valor_end_rep_1")]
		private TextBox _Valor_end_rep_1;

		// Token: 0x0400154C RID: 5452
		[AccessedThroughProperty("CheckBox_hab_rep")]
		private CheckBox _CheckBox_hab_rep;

		// Token: 0x0400154D RID: 5453
		[AccessedThroughProperty("Label_num_est_rep")]
		private Label _Label_num_est_rep;

		// Token: 0x0400154E RID: 5454
		[AccessedThroughProperty("Label_end_rep")]
		private Label _Label_end_rep;

		// Token: 0x0400154F RID: 5455
		[AccessedThroughProperty("Grupo_motores")]
		private GroupBox _Grupo_motores;

		// Token: 0x04001550 RID: 5456
		[AccessedThroughProperty("Label_num_motores")]
		private Label _Label_num_motores;

		// Token: 0x04001551 RID: 5457
		[AccessedThroughProperty("Grupo_M1")]
		private GroupBox _Grupo_M1;

		// Token: 0x04001552 RID: 5458
		[AccessedThroughProperty("Label_nivel_acionamento_m1")]
		private Label _Label_nivel_acionamento_m1;

		// Token: 0x04001553 RID: 5459
		[AccessedThroughProperty("Combo_modo_partida_m1")]
		private ComboBox _Combo_modo_partida_m1;

		// Token: 0x04001554 RID: 5460
		[AccessedThroughProperty("Label_modo_partida_m1")]
		private Label _Label_modo_partida_m1;

		// Token: 0x04001555 RID: 5461
		[AccessedThroughProperty("Label_tempo_parada_m1")]
		private Label _Label_tempo_parada_m1;

		// Token: 0x04001556 RID: 5462
		[AccessedThroughProperty("Label_tempo_partida_m1")]
		private Label _Label_tempo_partida_m1;

		// Token: 0x04001557 RID: 5463
		[AccessedThroughProperty("Label_nivel_parada_m1")]
		private Label _Label_nivel_parada_m1;

		// Token: 0x04001558 RID: 5464
		[AccessedThroughProperty("Grupo_M2")]
		private GroupBox _Grupo_M2;

		// Token: 0x04001559 RID: 5465
		[AccessedThroughProperty("Label_tempo_parada_m2")]
		private Label _Label_tempo_parada_m2;

		// Token: 0x0400155A RID: 5466
		[AccessedThroughProperty("Label_tempo_partida_m2")]
		private Label _Label_tempo_partida_m2;

		// Token: 0x0400155B RID: 5467
		[AccessedThroughProperty("Label_nivel_parada_m2")]
		private Label _Label_nivel_parada_m2;

		// Token: 0x0400155C RID: 5468
		[AccessedThroughProperty("Label_nivel_acionamento_m2")]
		private Label _Label_nivel_acionamento_m2;

		// Token: 0x0400155D RID: 5469
		[AccessedThroughProperty("Combo_modo_partida_m2")]
		private ComboBox _Combo_modo_partida_m2;

		// Token: 0x0400155E RID: 5470
		[AccessedThroughProperty("Label_modo_partida_m2")]
		private Label _Label_modo_partida_m2;

		// Token: 0x0400155F RID: 5471
		[AccessedThroughProperty("Grupo_M3")]
		private GroupBox _Grupo_M3;

		// Token: 0x04001560 RID: 5472
		[AccessedThroughProperty("Label_tempo_parada_m3")]
		private Label _Label_tempo_parada_m3;

		// Token: 0x04001561 RID: 5473
		[AccessedThroughProperty("Label_tempo_partida_m3")]
		private Label _Label_tempo_partida_m3;

		// Token: 0x04001562 RID: 5474
		[AccessedThroughProperty("Label_nivel_parada_m3")]
		private Label _Label_nivel_parada_m3;

		// Token: 0x04001563 RID: 5475
		[AccessedThroughProperty("Label_nivel_acionamento_m3")]
		private Label _Label_nivel_acionamento_m3;

		// Token: 0x04001564 RID: 5476
		[AccessedThroughProperty("Combo_modo_partida_m3")]
		private ComboBox _Combo_modo_partida_m3;

		// Token: 0x04001565 RID: 5477
		[AccessedThroughProperty("Label_modo_partida_m3")]
		private Label _Label_modo_partida_m3;

		// Token: 0x04001566 RID: 5478
		[AccessedThroughProperty("Grupo_ctrl")]
		private GroupBox _Grupo_ctrl;

		// Token: 0x04001567 RID: 5479
		[AccessedThroughProperty("Esc_conf_md_201")]
		private Button _Esc_conf_md_201;

		// Token: 0x04001568 RID: 5480
		[AccessedThroughProperty("Box_Msg")]
		private TextBox _Box_Msg;

		// Token: 0x04001569 RID: 5481
		[AccessedThroughProperty("Ler_conf_md_201")]
		private Button _Ler_conf_md_201;

		// Token: 0x0400156A RID: 5482
		[AccessedThroughProperty("Label_tempo_entre_acionamentos")]
		private Label _Label_tempo_entre_acionamentos;

		// Token: 0x0400156B RID: 5483
		[AccessedThroughProperty("Valor_end_est")]
		private NumericUpDown _Valor_end_est;

		// Token: 0x0400156C RID: 5484
		[AccessedThroughProperty("Valor_end_mestre")]
		private NumericUpDown _Valor_end_mestre;

		// Token: 0x0400156D RID: 5485
		[AccessedThroughProperty("Valor_end_rep")]
		private NumericUpDown _Valor_end_rep;

		// Token: 0x0400156E RID: 5486
		[AccessedThroughProperty("Valor_num_est_rep")]
		private NumericUpDown _Valor_num_est_rep;

		// Token: 0x0400156F RID: 5487
		[AccessedThroughProperty("Numero_motores")]
		private NumericUpDown _Numero_motores;

		// Token: 0x04001570 RID: 5488
		[AccessedThroughProperty("Tempo_entre_acionamentos")]
		private NumericUpDown _Tempo_entre_acionamentos;

		// Token: 0x04001571 RID: 5489
		[AccessedThroughProperty("Nivel_parada_m1")]
		private NumericUpDown _Nivel_parada_m1;

		// Token: 0x04001572 RID: 5490
		[AccessedThroughProperty("Nivel_partida_m1")]
		private NumericUpDown _Nivel_partida_m1;

		// Token: 0x04001573 RID: 5491
		[AccessedThroughProperty("Tempo_partida_m1")]
		private NumericUpDown _Tempo_partida_m1;

		// Token: 0x04001574 RID: 5492
		[AccessedThroughProperty("Tempo_parada_m1")]
		private NumericUpDown _Tempo_parada_m1;

		// Token: 0x04001575 RID: 5493
		[AccessedThroughProperty("Tempo_parada_m2")]
		private NumericUpDown _Tempo_parada_m2;

		// Token: 0x04001576 RID: 5494
		[AccessedThroughProperty("Tempo_partida_m2")]
		private NumericUpDown _Tempo_partida_m2;

		// Token: 0x04001577 RID: 5495
		[AccessedThroughProperty("Nivel_partida_m2")]
		private NumericUpDown _Nivel_partida_m2;

		// Token: 0x04001578 RID: 5496
		[AccessedThroughProperty("Nivel_parada_m2")]
		private NumericUpDown _Nivel_parada_m2;

		// Token: 0x04001579 RID: 5497
		[AccessedThroughProperty("Tempo_parada_m3")]
		private NumericUpDown _Tempo_parada_m3;

		// Token: 0x0400157A RID: 5498
		[AccessedThroughProperty("Tempo_partida_m3")]
		private NumericUpDown _Tempo_partida_m3;

		// Token: 0x0400157B RID: 5499
		[AccessedThroughProperty("Nivel_partida_m3")]
		private NumericUpDown _Nivel_partida_m3;

		// Token: 0x0400157C RID: 5500
		[AccessedThroughProperty("Nivel_parada_m3")]
		private NumericUpDown _Nivel_parada_m3;

		// Token: 0x0400157D RID: 5501
		[AccessedThroughProperty("Valor_temp_ptt")]
		private NumericUpDown _Valor_temp_ptt;

		// Token: 0x0400157E RID: 5502
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x0400157F RID: 5503
		[AccessedThroughProperty("ArquivoToolStripMenuItem")]
		private ToolStripMenuItem _ArquivoToolStripMenuItem;

		// Token: 0x04001580 RID: 5504
		[AccessedThroughProperty("SalvarToolStripMenuItem")]
		private ToolStripMenuItem _SalvarToolStripMenuItem;

		// Token: 0x04001581 RID: 5505
		[AccessedThroughProperty("AbrirToolStripMenuItem")]
		private ToolStripMenuItem _AbrirToolStripMenuItem;

		// Token: 0x04001582 RID: 5506
		[AccessedThroughProperty("NovoToolStripMenuItem")]
		private ToolStripMenuItem _NovoToolStripMenuItem;

		// Token: 0x04001583 RID: 5507
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog _OpenFileDialog1;

		// Token: 0x04001584 RID: 5508
		[AccessedThroughProperty("SaveFileDialog1")]
		private SaveFileDialog _SaveFileDialog1;

		// Token: 0x04001585 RID: 5509
		private int passo_201;

		// Token: 0x04001586 RID: 5510
		private int passo_201_motor;
	}
}
