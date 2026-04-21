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
	// Token: 0x02000083 RID: 131
	[DesignerGenerated]
	public partial class Equip_202_cal : Form
	{
		// Token: 0x06001D8F RID: 7567 RVA: 0x003D86EC File Offset: 0x003D6AEC
		public Equip_202_cal()
		{
			base.Load += new EventHandler(this.Equip_202_cal_Load);
			this.InitializeComponent();
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x003DE88C File Offset: 0x003DCC8C
		// (set) Token: 0x06001D93 RID: 7571 RVA: 0x003DE8A0 File Offset: 0x003DCCA0
		internal virtual GroupBox Grupo_ctrl_com
		{
			get
			{
				return this._Grupo_ctrl_com;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_ctrl_com = value;
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x003DE8AC File Offset: 0x003DCCAC
		// (set) Token: 0x06001D95 RID: 7573 RVA: 0x003DE8C0 File Offset: 0x003DCCC0
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

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x003DE8CC File Offset: 0x003DCCCC
		// (set) Token: 0x06001D97 RID: 7575 RVA: 0x003DE8E0 File Offset: 0x003DCCE0
		internal virtual Button Comando_ler_cal
		{
			get
			{
				return this._Comando_ler_cal;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Comando_ler_cal_Click);
				if (this._Comando_ler_cal != null)
				{
					this._Comando_ler_cal.Click -= eventHandler;
				}
				this._Comando_ler_cal = value;
				if (this._Comando_ler_cal != null)
				{
					this._Comando_ler_cal.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x003DE92C File Offset: 0x003DCD2C
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x003DE940 File Offset: 0x003DCD40
		internal virtual NumericUpDown Tela_end_estacao
		{
			get
			{
				return this._Tela_end_estacao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tela_end_estacao_ValueChanged);
				if (this._Tela_end_estacao != null)
				{
					this._Tela_end_estacao.ValueChanged -= eventHandler;
				}
				this._Tela_end_estacao = value;
				if (this._Tela_end_estacao != null)
				{
					this._Tela_end_estacao.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x003DE98C File Offset: 0x003DCD8C
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x003DE9A0 File Offset: 0x003DCDA0
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

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x003DE9AC File Offset: 0x003DCDAC
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x003DE9C0 File Offset: 0x003DCDC0
		internal virtual GroupBox Grupo_ent_digitais
		{
			get
			{
				return this._Grupo_ent_digitais;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_ent_digitais = value;
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x003DE9CC File Offset: 0x003DCDCC
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x003DE9E0 File Offset: 0x003DCDE0
		internal virtual CheckBox CheckBox_ED8
		{
			get
			{
				return this._CheckBox_ED8;
			}
			[MethodImpl(32)]
			set
			{
				this._CheckBox_ED8 = value;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x003DE9EC File Offset: 0x003DCDEC
		// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x003DEA00 File Offset: 0x003DCE00
		internal virtual CheckBox CheckBox_ED4
		{
			get
			{
				return this._CheckBox_ED4;
			}
			[MethodImpl(32)]
			set
			{
				this._CheckBox_ED4 = value;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x003DEA0C File Offset: 0x003DCE0C
		// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x003DEA20 File Offset: 0x003DCE20
		internal virtual CheckBox CheckBox_ED7
		{
			get
			{
				return this._CheckBox_ED7;
			}
			[MethodImpl(32)]
			set
			{
				this._CheckBox_ED7 = value;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x003DEA2C File Offset: 0x003DCE2C
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x003DEA40 File Offset: 0x003DCE40
		internal virtual CheckBox CheckBox_ED3
		{
			get
			{
				return this._CheckBox_ED3;
			}
			[MethodImpl(32)]
			set
			{
				this._CheckBox_ED3 = value;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x003DEA4C File Offset: 0x003DCE4C
		// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x003DEA60 File Offset: 0x003DCE60
		internal virtual CheckBox CheckBox_ED6
		{
			get
			{
				return this._CheckBox_ED6;
			}
			[MethodImpl(32)]
			set
			{
				this._CheckBox_ED6 = value;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x003DEA6C File Offset: 0x003DCE6C
		// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x003DEA80 File Offset: 0x003DCE80
		internal virtual CheckBox CheckBox_ED2
		{
			get
			{
				return this._CheckBox_ED2;
			}
			[MethodImpl(32)]
			set
			{
				this._CheckBox_ED2 = value;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x003DEA8C File Offset: 0x003DCE8C
		// (set) Token: 0x06001DAB RID: 7595 RVA: 0x003DEAA0 File Offset: 0x003DCEA0
		internal virtual CheckBox CheckBox_ED5
		{
			get
			{
				return this._CheckBox_ED5;
			}
			[MethodImpl(32)]
			set
			{
				this._CheckBox_ED5 = value;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06001DAC RID: 7596 RVA: 0x003DEAAC File Offset: 0x003DCEAC
		// (set) Token: 0x06001DAD RID: 7597 RVA: 0x003DEAC0 File Offset: 0x003DCEC0
		internal virtual CheckBox CheckBox_ED1
		{
			get
			{
				return this._CheckBox_ED1;
			}
			[MethodImpl(32)]
			set
			{
				this._CheckBox_ED1 = value;
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06001DAE RID: 7598 RVA: 0x003DEACC File Offset: 0x003DCECC
		// (set) Token: 0x06001DAF RID: 7599 RVA: 0x003DEAE0 File Offset: 0x003DCEE0
		internal virtual GroupBox Grupo_calibracao
		{
			get
			{
				return this._Grupo_calibracao;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_calibracao = value;
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x003DEAEC File Offset: 0x003DCEEC
		// (set) Token: 0x06001DB1 RID: 7601 RVA: 0x003DEB00 File Offset: 0x003DCF00
		internal virtual GroupBox Grupo_zero
		{
			get
			{
				return this._Grupo_zero;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_zero = value;
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x003DEB0C File Offset: 0x003DCF0C
		// (set) Token: 0x06001DB3 RID: 7603 RVA: 0x003DEB20 File Offset: 0x003DCF20
		internal virtual TextBox Valor_zero_4
		{
			get
			{
				return this._Valor_zero_4;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_zero_4 = value;
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x003DEB2C File Offset: 0x003DCF2C
		// (set) Token: 0x06001DB5 RID: 7605 RVA: 0x003DEB40 File Offset: 0x003DCF40
		internal virtual TextBox Valor_zero_3
		{
			get
			{
				return this._Valor_zero_3;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_zero_3 = value;
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x003DEB4C File Offset: 0x003DCF4C
		// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x003DEB60 File Offset: 0x003DCF60
		internal virtual TextBox Valor_zero_2
		{
			get
			{
				return this._Valor_zero_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_zero_2 = value;
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x003DEB6C File Offset: 0x003DCF6C
		// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x003DEB80 File Offset: 0x003DCF80
		internal virtual TextBox Valor_zero_1
		{
			get
			{
				return this._Valor_zero_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_zero_1 = value;
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06001DBA RID: 7610 RVA: 0x003DEB8C File Offset: 0x003DCF8C
		// (set) Token: 0x06001DBB RID: 7611 RVA: 0x003DEBA0 File Offset: 0x003DCFA0
		internal virtual Label Label_zero_4
		{
			get
			{
				return this._Label_zero_4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_zero_4 = value;
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x003DEBAC File Offset: 0x003DCFAC
		// (set) Token: 0x06001DBD RID: 7613 RVA: 0x003DEBC0 File Offset: 0x003DCFC0
		internal virtual Label Label_zero_3
		{
			get
			{
				return this._Label_zero_3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_zero_3 = value;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x003DEBCC File Offset: 0x003DCFCC
		// (set) Token: 0x06001DBF RID: 7615 RVA: 0x003DEBE0 File Offset: 0x003DCFE0
		internal virtual Label Label_zero_2
		{
			get
			{
				return this._Label_zero_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_zero_2 = value;
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x003DEBEC File Offset: 0x003DCFEC
		// (set) Token: 0x06001DC1 RID: 7617 RVA: 0x003DEC00 File Offset: 0x003DD000
		internal virtual Label Label_zero_1
		{
			get
			{
				return this._Label_zero_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_zero_1 = value;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x003DEC0C File Offset: 0x003DD00C
		// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x003DEC20 File Offset: 0x003DD020
		internal virtual TextBox Valor_zero_10
		{
			get
			{
				return this._Valor_zero_10;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_zero_10 = value;
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x003DEC2C File Offset: 0x003DD02C
		// (set) Token: 0x06001DC5 RID: 7621 RVA: 0x003DEC40 File Offset: 0x003DD040
		internal virtual TextBox Valor_zero_9
		{
			get
			{
				return this._Valor_zero_9;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_zero_9 = value;
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x003DEC4C File Offset: 0x003DD04C
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x003DEC60 File Offset: 0x003DD060
		internal virtual TextBox Valor_zero_8
		{
			get
			{
				return this._Valor_zero_8;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_zero_8 = value;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x003DEC6C File Offset: 0x003DD06C
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x003DEC80 File Offset: 0x003DD080
		internal virtual TextBox Valor_zero_7
		{
			get
			{
				return this._Valor_zero_7;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_zero_7 = value;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x003DEC8C File Offset: 0x003DD08C
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x003DECA0 File Offset: 0x003DD0A0
		internal virtual TextBox Valor_zero_6
		{
			get
			{
				return this._Valor_zero_6;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_zero_6 = value;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x003DECAC File Offset: 0x003DD0AC
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x003DECC0 File Offset: 0x003DD0C0
		internal virtual TextBox Valor_zero_5
		{
			get
			{
				return this._Valor_zero_5;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_zero_5 = value;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x003DECCC File Offset: 0x003DD0CC
		// (set) Token: 0x06001DCF RID: 7631 RVA: 0x003DECE0 File Offset: 0x003DD0E0
		internal virtual Label Label_zero_10
		{
			get
			{
				return this._Label_zero_10;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_zero_10 = value;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x003DECEC File Offset: 0x003DD0EC
		// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x003DED00 File Offset: 0x003DD100
		internal virtual Label Label_zero_9
		{
			get
			{
				return this._Label_zero_9;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_zero_9 = value;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x003DED0C File Offset: 0x003DD10C
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x003DED20 File Offset: 0x003DD120
		internal virtual Label Label_zero_8
		{
			get
			{
				return this._Label_zero_8;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_zero_8 = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x003DED2C File Offset: 0x003DD12C
		// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x003DED40 File Offset: 0x003DD140
		internal virtual Label Label_zero_7
		{
			get
			{
				return this._Label_zero_7;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_zero_7 = value;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x003DED4C File Offset: 0x003DD14C
		// (set) Token: 0x06001DD7 RID: 7639 RVA: 0x003DED60 File Offset: 0x003DD160
		internal virtual Label Label_zero_6
		{
			get
			{
				return this._Label_zero_6;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_zero_6 = value;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x003DED6C File Offset: 0x003DD16C
		// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x003DED80 File Offset: 0x003DD180
		internal virtual Label Label_zero_5
		{
			get
			{
				return this._Label_zero_5;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_zero_5 = value;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x003DED8C File Offset: 0x003DD18C
		// (set) Token: 0x06001DDB RID: 7643 RVA: 0x003DEDA0 File Offset: 0x003DD1A0
		internal virtual GroupBox Grupo_ganho
		{
			get
			{
				return this._Grupo_ganho;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_ganho = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06001DDC RID: 7644 RVA: 0x003DEDAC File Offset: 0x003DD1AC
		// (set) Token: 0x06001DDD RID: 7645 RVA: 0x003DEDC0 File Offset: 0x003DD1C0
		internal virtual TextBox Valor_ganho_4
		{
			get
			{
				return this._Valor_ganho_4;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_ganho_4 = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06001DDE RID: 7646 RVA: 0x003DEDCC File Offset: 0x003DD1CC
		// (set) Token: 0x06001DDF RID: 7647 RVA: 0x003DEDE0 File Offset: 0x003DD1E0
		internal virtual TextBox Valor_ganho_3
		{
			get
			{
				return this._Valor_ganho_3;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_ganho_3 = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x003DEDEC File Offset: 0x003DD1EC
		// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x003DEE00 File Offset: 0x003DD200
		internal virtual TextBox Valor_ganho_2
		{
			get
			{
				return this._Valor_ganho_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_ganho_2 = value;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x003DEE0C File Offset: 0x003DD20C
		// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x003DEE20 File Offset: 0x003DD220
		internal virtual TextBox Valor_ganho_1
		{
			get
			{
				return this._Valor_ganho_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_ganho_1 = value;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x003DEE2C File Offset: 0x003DD22C
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x003DEE40 File Offset: 0x003DD240
		internal virtual Label Label_ganho_4
		{
			get
			{
				return this._Label_ganho_4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_ganho_4 = value;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x003DEE4C File Offset: 0x003DD24C
		// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x003DEE60 File Offset: 0x003DD260
		internal virtual Label Label_ganho_3
		{
			get
			{
				return this._Label_ganho_3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_ganho_3 = value;
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x003DEE6C File Offset: 0x003DD26C
		// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x003DEE80 File Offset: 0x003DD280
		internal virtual Label Label_ganho_2
		{
			get
			{
				return this._Label_ganho_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_ganho_2 = value;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x003DEE8C File Offset: 0x003DD28C
		// (set) Token: 0x06001DEB RID: 7659 RVA: 0x003DEEA0 File Offset: 0x003DD2A0
		internal virtual Label Label_ganho_1
		{
			get
			{
				return this._Label_ganho_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_ganho_1 = value;
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x003DEEAC File Offset: 0x003DD2AC
		// (set) Token: 0x06001DED RID: 7661 RVA: 0x003DEEC0 File Offset: 0x003DD2C0
		internal virtual TextBox Valor_zero_16
		{
			get
			{
				return this._Valor_zero_16;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_zero_16 = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x003DEECC File Offset: 0x003DD2CC
		// (set) Token: 0x06001DEF RID: 7663 RVA: 0x003DEEE0 File Offset: 0x003DD2E0
		internal virtual TextBox Valor_zero_15
		{
			get
			{
				return this._Valor_zero_15;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_zero_15 = value;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x003DEEEC File Offset: 0x003DD2EC
		// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x003DEF00 File Offset: 0x003DD300
		internal virtual TextBox Valor_zero_14
		{
			get
			{
				return this._Valor_zero_14;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_zero_14 = value;
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x003DEF0C File Offset: 0x003DD30C
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x003DEF20 File Offset: 0x003DD320
		internal virtual TextBox Valor_zero_13
		{
			get
			{
				return this._Valor_zero_13;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_zero_13 = value;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x003DEF2C File Offset: 0x003DD32C
		// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x003DEF40 File Offset: 0x003DD340
		internal virtual TextBox Valor_zero_12
		{
			get
			{
				return this._Valor_zero_12;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_zero_12 = value;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x003DEF4C File Offset: 0x003DD34C
		// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x003DEF60 File Offset: 0x003DD360
		internal virtual TextBox Valor_zero_11
		{
			get
			{
				return this._Valor_zero_11;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_zero_11 = value;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x003DEF6C File Offset: 0x003DD36C
		// (set) Token: 0x06001DF9 RID: 7673 RVA: 0x003DEF80 File Offset: 0x003DD380
		internal virtual Label Label_zero_16
		{
			get
			{
				return this._Label_zero_16;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_zero_16 = value;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06001DFA RID: 7674 RVA: 0x003DEF8C File Offset: 0x003DD38C
		// (set) Token: 0x06001DFB RID: 7675 RVA: 0x003DEFA0 File Offset: 0x003DD3A0
		internal virtual Label Label_zero_15
		{
			get
			{
				return this._Label_zero_15;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_zero_15 = value;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06001DFC RID: 7676 RVA: 0x003DEFAC File Offset: 0x003DD3AC
		// (set) Token: 0x06001DFD RID: 7677 RVA: 0x003DEFC0 File Offset: 0x003DD3C0
		internal virtual Label Label_zero_14
		{
			get
			{
				return this._Label_zero_14;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_zero_14 = value;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x003DEFCC File Offset: 0x003DD3CC
		// (set) Token: 0x06001DFF RID: 7679 RVA: 0x003DEFE0 File Offset: 0x003DD3E0
		internal virtual Label Label_zero_13
		{
			get
			{
				return this._Label_zero_13;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_zero_13 = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x003DEFEC File Offset: 0x003DD3EC
		// (set) Token: 0x06001E01 RID: 7681 RVA: 0x003DF000 File Offset: 0x003DD400
		internal virtual Label Label_zero_12
		{
			get
			{
				return this._Label_zero_12;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_zero_12 = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x003DF00C File Offset: 0x003DD40C
		// (set) Token: 0x06001E03 RID: 7683 RVA: 0x003DF020 File Offset: 0x003DD420
		internal virtual Label Label_zero_11
		{
			get
			{
				return this._Label_zero_11;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_zero_11 = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x003DF02C File Offset: 0x003DD42C
		// (set) Token: 0x06001E05 RID: 7685 RVA: 0x003DF040 File Offset: 0x003DD440
		internal virtual TextBox Valor_ganho_8
		{
			get
			{
				return this._Valor_ganho_8;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_ganho_8 = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x003DF04C File Offset: 0x003DD44C
		// (set) Token: 0x06001E07 RID: 7687 RVA: 0x003DF060 File Offset: 0x003DD460
		internal virtual TextBox Valor_ganho_7
		{
			get
			{
				return this._Valor_ganho_7;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_ganho_7 = value;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x003DF06C File Offset: 0x003DD46C
		// (set) Token: 0x06001E09 RID: 7689 RVA: 0x003DF080 File Offset: 0x003DD480
		internal virtual TextBox Valor_ganho_6
		{
			get
			{
				return this._Valor_ganho_6;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_ganho_6 = value;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x003DF08C File Offset: 0x003DD48C
		// (set) Token: 0x06001E0B RID: 7691 RVA: 0x003DF0A0 File Offset: 0x003DD4A0
		internal virtual TextBox Valor_ganho_5
		{
			get
			{
				return this._Valor_ganho_5;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_ganho_5 = value;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x003DF0AC File Offset: 0x003DD4AC
		// (set) Token: 0x06001E0D RID: 7693 RVA: 0x003DF0C0 File Offset: 0x003DD4C0
		internal virtual Label Label_ganho_8
		{
			get
			{
				return this._Label_ganho_8;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_ganho_8 = value;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x003DF0CC File Offset: 0x003DD4CC
		// (set) Token: 0x06001E0F RID: 7695 RVA: 0x003DF0E0 File Offset: 0x003DD4E0
		internal virtual Label Label_ganho_7
		{
			get
			{
				return this._Label_ganho_7;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_ganho_7 = value;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x003DF0EC File Offset: 0x003DD4EC
		// (set) Token: 0x06001E11 RID: 7697 RVA: 0x003DF100 File Offset: 0x003DD500
		internal virtual Label Label_ganho_6
		{
			get
			{
				return this._Label_ganho_6;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_ganho_6 = value;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x003DF10C File Offset: 0x003DD50C
		// (set) Token: 0x06001E13 RID: 7699 RVA: 0x003DF120 File Offset: 0x003DD520
		internal virtual Label Label_ganho_5
		{
			get
			{
				return this._Label_ganho_5;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_ganho_5 = value;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x003DF12C File Offset: 0x003DD52C
		// (set) Token: 0x06001E15 RID: 7701 RVA: 0x003DF140 File Offset: 0x003DD540
		internal virtual TextBox Valor_ganho_10
		{
			get
			{
				return this._Valor_ganho_10;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_ganho_10 = value;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x003DF14C File Offset: 0x003DD54C
		// (set) Token: 0x06001E17 RID: 7703 RVA: 0x003DF160 File Offset: 0x003DD560
		internal virtual TextBox Valor_ganho_9
		{
			get
			{
				return this._Valor_ganho_9;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_ganho_9 = value;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x003DF16C File Offset: 0x003DD56C
		// (set) Token: 0x06001E19 RID: 7705 RVA: 0x003DF180 File Offset: 0x003DD580
		internal virtual Label Label_ganho_10
		{
			get
			{
				return this._Label_ganho_10;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_ganho_10 = value;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x003DF18C File Offset: 0x003DD58C
		// (set) Token: 0x06001E1B RID: 7707 RVA: 0x003DF1A0 File Offset: 0x003DD5A0
		internal virtual Label Label_ganho_9
		{
			get
			{
				return this._Label_ganho_9;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_ganho_9 = value;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x003DF1AC File Offset: 0x003DD5AC
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x003DF1C0 File Offset: 0x003DD5C0
		internal virtual TextBox Valor_ganho_14
		{
			get
			{
				return this._Valor_ganho_14;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_ganho_14 = value;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x003DF1CC File Offset: 0x003DD5CC
		// (set) Token: 0x06001E1F RID: 7711 RVA: 0x003DF1E0 File Offset: 0x003DD5E0
		internal virtual TextBox Valor_ganho_13
		{
			get
			{
				return this._Valor_ganho_13;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_ganho_13 = value;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x003DF1EC File Offset: 0x003DD5EC
		// (set) Token: 0x06001E21 RID: 7713 RVA: 0x003DF200 File Offset: 0x003DD600
		internal virtual TextBox Valor_ganho_16
		{
			get
			{
				return this._Valor_ganho_16;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_ganho_16 = value;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x003DF20C File Offset: 0x003DD60C
		// (set) Token: 0x06001E23 RID: 7715 RVA: 0x003DF220 File Offset: 0x003DD620
		internal virtual TextBox Valor_ganho_12
		{
			get
			{
				return this._Valor_ganho_12;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_ganho_12 = value;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x003DF22C File Offset: 0x003DD62C
		// (set) Token: 0x06001E25 RID: 7717 RVA: 0x003DF240 File Offset: 0x003DD640
		internal virtual TextBox Valor_ganho_15
		{
			get
			{
				return this._Valor_ganho_15;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_ganho_15 = value;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x003DF24C File Offset: 0x003DD64C
		// (set) Token: 0x06001E27 RID: 7719 RVA: 0x003DF260 File Offset: 0x003DD660
		internal virtual TextBox Valor_ganho_11
		{
			get
			{
				return this._Valor_ganho_11;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_ganho_11 = value;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x003DF26C File Offset: 0x003DD66C
		// (set) Token: 0x06001E29 RID: 7721 RVA: 0x003DF280 File Offset: 0x003DD680
		internal virtual Label Label_ganho_14
		{
			get
			{
				return this._Label_ganho_14;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_ganho_14 = value;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x003DF28C File Offset: 0x003DD68C
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x003DF2A0 File Offset: 0x003DD6A0
		internal virtual Label Label_ganho_13
		{
			get
			{
				return this._Label_ganho_13;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_ganho_13 = value;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x003DF2AC File Offset: 0x003DD6AC
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x003DF2C0 File Offset: 0x003DD6C0
		internal virtual Label Label_ganho_16
		{
			get
			{
				return this._Label_ganho_16;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_ganho_16 = value;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x003DF2CC File Offset: 0x003DD6CC
		// (set) Token: 0x06001E2F RID: 7727 RVA: 0x003DF2E0 File Offset: 0x003DD6E0
		internal virtual Label Label_ganho_12
		{
			get
			{
				return this._Label_ganho_12;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_ganho_12 = value;
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x003DF2EC File Offset: 0x003DD6EC
		// (set) Token: 0x06001E31 RID: 7729 RVA: 0x003DF300 File Offset: 0x003DD700
		internal virtual Label Label_ganho_15
		{
			get
			{
				return this._Label_ganho_15;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_ganho_15 = value;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x003DF30C File Offset: 0x003DD70C
		// (set) Token: 0x06001E33 RID: 7731 RVA: 0x003DF320 File Offset: 0x003DD720
		internal virtual Label Label_ganho_11
		{
			get
			{
				return this._Label_ganho_11;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_ganho_11 = value;
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06001E34 RID: 7732 RVA: 0x003DF32C File Offset: 0x003DD72C
		// (set) Token: 0x06001E35 RID: 7733 RVA: 0x003DF340 File Offset: 0x003DD740
		internal virtual GroupBox Grupo_cont_sem_norm
		{
			get
			{
				return this._Grupo_cont_sem_norm;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_cont_sem_norm = value;
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x003DF34C File Offset: 0x003DD74C
		// (set) Token: 0x06001E37 RID: 7735 RVA: 0x003DF360 File Offset: 0x003DD760
		internal virtual TextBox Valor_cont_s_norm_10
		{
			get
			{
				return this._Valor_cont_s_norm_10;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_s_norm_10 = value;
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x003DF36C File Offset: 0x003DD76C
		// (set) Token: 0x06001E39 RID: 7737 RVA: 0x003DF380 File Offset: 0x003DD780
		internal virtual TextBox Valor_cont_s_norm_9
		{
			get
			{
				return this._Valor_cont_s_norm_9;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_s_norm_9 = value;
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x003DF38C File Offset: 0x003DD78C
		// (set) Token: 0x06001E3B RID: 7739 RVA: 0x003DF3A0 File Offset: 0x003DD7A0
		internal virtual TextBox Valor_cont_s_norm_8
		{
			get
			{
				return this._Valor_cont_s_norm_8;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_s_norm_8 = value;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x003DF3AC File Offset: 0x003DD7AC
		// (set) Token: 0x06001E3D RID: 7741 RVA: 0x003DF3C0 File Offset: 0x003DD7C0
		internal virtual TextBox Valor_cont_s_norm_7
		{
			get
			{
				return this._Valor_cont_s_norm_7;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_s_norm_7 = value;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x003DF3CC File Offset: 0x003DD7CC
		// (set) Token: 0x06001E3F RID: 7743 RVA: 0x003DF3E0 File Offset: 0x003DD7E0
		internal virtual TextBox Valor_cont_s_norm_16
		{
			get
			{
				return this._Valor_cont_s_norm_16;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_s_norm_16 = value;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x003DF3EC File Offset: 0x003DD7EC
		// (set) Token: 0x06001E41 RID: 7745 RVA: 0x003DF400 File Offset: 0x003DD800
		internal virtual TextBox Valor_cont_s_norm_6
		{
			get
			{
				return this._Valor_cont_s_norm_6;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_s_norm_6 = value;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x003DF40C File Offset: 0x003DD80C
		// (set) Token: 0x06001E43 RID: 7747 RVA: 0x003DF420 File Offset: 0x003DD820
		internal virtual TextBox Valor_cont_s_norm_15
		{
			get
			{
				return this._Valor_cont_s_norm_15;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_s_norm_15 = value;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x003DF42C File Offset: 0x003DD82C
		// (set) Token: 0x06001E45 RID: 7749 RVA: 0x003DF440 File Offset: 0x003DD840
		internal virtual TextBox Valor_cont_s_norm_5
		{
			get
			{
				return this._Valor_cont_s_norm_5;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_s_norm_5 = value;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x003DF44C File Offset: 0x003DD84C
		// (set) Token: 0x06001E47 RID: 7751 RVA: 0x003DF460 File Offset: 0x003DD860
		internal virtual TextBox Valor_cont_s_norm_14
		{
			get
			{
				return this._Valor_cont_s_norm_14;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_s_norm_14 = value;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x003DF46C File Offset: 0x003DD86C
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x003DF480 File Offset: 0x003DD880
		internal virtual TextBox Valor_cont_s_norm_4
		{
			get
			{
				return this._Valor_cont_s_norm_4;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_s_norm_4 = value;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x003DF48C File Offset: 0x003DD88C
		// (set) Token: 0x06001E4B RID: 7755 RVA: 0x003DF4A0 File Offset: 0x003DD8A0
		internal virtual TextBox Valor_cont_s_norm_13
		{
			get
			{
				return this._Valor_cont_s_norm_13;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_s_norm_13 = value;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x003DF4AC File Offset: 0x003DD8AC
		// (set) Token: 0x06001E4D RID: 7757 RVA: 0x003DF4C0 File Offset: 0x003DD8C0
		internal virtual TextBox Valor_cont_s_norm_3
		{
			get
			{
				return this._Valor_cont_s_norm_3;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_s_norm_3 = value;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x003DF4CC File Offset: 0x003DD8CC
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x003DF4E0 File Offset: 0x003DD8E0
		internal virtual TextBox Valor_cont_s_norm_12
		{
			get
			{
				return this._Valor_cont_s_norm_12;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_s_norm_12 = value;
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x003DF4EC File Offset: 0x003DD8EC
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x003DF500 File Offset: 0x003DD900
		internal virtual TextBox Valor_cont_s_norm_2
		{
			get
			{
				return this._Valor_cont_s_norm_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_s_norm_2 = value;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x003DF50C File Offset: 0x003DD90C
		// (set) Token: 0x06001E53 RID: 7763 RVA: 0x003DF520 File Offset: 0x003DD920
		internal virtual TextBox Valor_cont_s_norm_11
		{
			get
			{
				return this._Valor_cont_s_norm_11;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_s_norm_11 = value;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x003DF52C File Offset: 0x003DD92C
		// (set) Token: 0x06001E55 RID: 7765 RVA: 0x003DF540 File Offset: 0x003DD940
		internal virtual TextBox Valor_cont_s_norm_1
		{
			get
			{
				return this._Valor_cont_s_norm_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_s_norm_1 = value;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x003DF54C File Offset: 0x003DD94C
		// (set) Token: 0x06001E57 RID: 7767 RVA: 0x003DF560 File Offset: 0x003DD960
		internal virtual Label Label_cont_s_norm_10
		{
			get
			{
				return this._Label_cont_s_norm_10;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_s_norm_10 = value;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x003DF56C File Offset: 0x003DD96C
		// (set) Token: 0x06001E59 RID: 7769 RVA: 0x003DF580 File Offset: 0x003DD980
		internal virtual Label Label_cont_s_norm_9
		{
			get
			{
				return this._Label_cont_s_norm_9;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_s_norm_9 = value;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x003DF58C File Offset: 0x003DD98C
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x003DF5A0 File Offset: 0x003DD9A0
		internal virtual Label Label_cont_s_norm_8
		{
			get
			{
				return this._Label_cont_s_norm_8;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_s_norm_8 = value;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x003DF5AC File Offset: 0x003DD9AC
		// (set) Token: 0x06001E5D RID: 7773 RVA: 0x003DF5C0 File Offset: 0x003DD9C0
		internal virtual Label Label_cont_s_norm_7
		{
			get
			{
				return this._Label_cont_s_norm_7;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_s_norm_7 = value;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x003DF5CC File Offset: 0x003DD9CC
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x003DF5E0 File Offset: 0x003DD9E0
		internal virtual Label Label_cont_s_norm_16
		{
			get
			{
				return this._Label_cont_s_norm_16;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_s_norm_16 = value;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x003DF5EC File Offset: 0x003DD9EC
		// (set) Token: 0x06001E61 RID: 7777 RVA: 0x003DF600 File Offset: 0x003DDA00
		internal virtual Label Label_cont_s_norm_6
		{
			get
			{
				return this._Label_cont_s_norm_6;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_s_norm_6 = value;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x003DF60C File Offset: 0x003DDA0C
		// (set) Token: 0x06001E63 RID: 7779 RVA: 0x003DF620 File Offset: 0x003DDA20
		internal virtual Label Label_cont_s_norm_15
		{
			get
			{
				return this._Label_cont_s_norm_15;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_s_norm_15 = value;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x003DF62C File Offset: 0x003DDA2C
		// (set) Token: 0x06001E65 RID: 7781 RVA: 0x003DF640 File Offset: 0x003DDA40
		internal virtual Label Label_cont_s_norm_5
		{
			get
			{
				return this._Label_cont_s_norm_5;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_s_norm_5 = value;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x003DF64C File Offset: 0x003DDA4C
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x003DF660 File Offset: 0x003DDA60
		internal virtual Label Label_cont_s_norm_14
		{
			get
			{
				return this._Label_cont_s_norm_14;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_s_norm_14 = value;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x003DF66C File Offset: 0x003DDA6C
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x003DF680 File Offset: 0x003DDA80
		internal virtual Label Label_cont_s_norm_4
		{
			get
			{
				return this._Label_cont_s_norm_4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_s_norm_4 = value;
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x003DF68C File Offset: 0x003DDA8C
		// (set) Token: 0x06001E6B RID: 7787 RVA: 0x003DF6A0 File Offset: 0x003DDAA0
		internal virtual Label Label_cont_s_norm_13
		{
			get
			{
				return this._Label_cont_s_norm_13;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_s_norm_13 = value;
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x003DF6AC File Offset: 0x003DDAAC
		// (set) Token: 0x06001E6D RID: 7789 RVA: 0x003DF6C0 File Offset: 0x003DDAC0
		internal virtual Label Label_cont_s_norm_3
		{
			get
			{
				return this._Label_cont_s_norm_3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_s_norm_3 = value;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x003DF6CC File Offset: 0x003DDACC
		// (set) Token: 0x06001E6F RID: 7791 RVA: 0x003DF6E0 File Offset: 0x003DDAE0
		internal virtual Label Label_cont_s_norm_12
		{
			get
			{
				return this._Label_cont_s_norm_12;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_s_norm_12 = value;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x003DF6EC File Offset: 0x003DDAEC
		// (set) Token: 0x06001E71 RID: 7793 RVA: 0x003DF700 File Offset: 0x003DDB00
		internal virtual Label Label_cont_s_norm_2
		{
			get
			{
				return this._Label_cont_s_norm_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_s_norm_2 = value;
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x003DF70C File Offset: 0x003DDB0C
		// (set) Token: 0x06001E73 RID: 7795 RVA: 0x003DF720 File Offset: 0x003DDB20
		internal virtual Label Label_cont_s_norm_11
		{
			get
			{
				return this._Label_cont_s_norm_11;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_s_norm_11 = value;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x003DF72C File Offset: 0x003DDB2C
		// (set) Token: 0x06001E75 RID: 7797 RVA: 0x003DF740 File Offset: 0x003DDB40
		internal virtual Label Label_cont_s_norm_1
		{
			get
			{
				return this._Label_cont_s_norm_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_s_norm_1 = value;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x003DF74C File Offset: 0x003DDB4C
		// (set) Token: 0x06001E77 RID: 7799 RVA: 0x003DF760 File Offset: 0x003DDB60
		internal virtual GroupBox Grupo_cont_norm
		{
			get
			{
				return this._Grupo_cont_norm;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_cont_norm = value;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06001E78 RID: 7800 RVA: 0x003DF76C File Offset: 0x003DDB6C
		// (set) Token: 0x06001E79 RID: 7801 RVA: 0x003DF780 File Offset: 0x003DDB80
		internal virtual TextBox Valor_cont_norm_10
		{
			get
			{
				return this._Valor_cont_norm_10;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_norm_10 = value;
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x003DF78C File Offset: 0x003DDB8C
		// (set) Token: 0x06001E7B RID: 7803 RVA: 0x003DF7A0 File Offset: 0x003DDBA0
		internal virtual TextBox Valor_cont_norm_9
		{
			get
			{
				return this._Valor_cont_norm_9;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_norm_9 = value;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x003DF7AC File Offset: 0x003DDBAC
		// (set) Token: 0x06001E7D RID: 7805 RVA: 0x003DF7C0 File Offset: 0x003DDBC0
		internal virtual TextBox Valor_cont_norm_8
		{
			get
			{
				return this._Valor_cont_norm_8;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_norm_8 = value;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x003DF7CC File Offset: 0x003DDBCC
		// (set) Token: 0x06001E7F RID: 7807 RVA: 0x003DF7E0 File Offset: 0x003DDBE0
		internal virtual TextBox Valor_cont_norm_7
		{
			get
			{
				return this._Valor_cont_norm_7;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_norm_7 = value;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x003DF7EC File Offset: 0x003DDBEC
		// (set) Token: 0x06001E81 RID: 7809 RVA: 0x003DF800 File Offset: 0x003DDC00
		internal virtual TextBox Valor_cont_norm_16
		{
			get
			{
				return this._Valor_cont_norm_16;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_norm_16 = value;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06001E82 RID: 7810 RVA: 0x003DF80C File Offset: 0x003DDC0C
		// (set) Token: 0x06001E83 RID: 7811 RVA: 0x003DF820 File Offset: 0x003DDC20
		internal virtual TextBox Valor_cont_norm_6
		{
			get
			{
				return this._Valor_cont_norm_6;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_norm_6 = value;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x003DF82C File Offset: 0x003DDC2C
		// (set) Token: 0x06001E85 RID: 7813 RVA: 0x003DF840 File Offset: 0x003DDC40
		internal virtual TextBox Valor_cont_norm_15
		{
			get
			{
				return this._Valor_cont_norm_15;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_norm_15 = value;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x003DF84C File Offset: 0x003DDC4C
		// (set) Token: 0x06001E87 RID: 7815 RVA: 0x003DF860 File Offset: 0x003DDC60
		internal virtual TextBox Valor_cont_norm_5
		{
			get
			{
				return this._Valor_cont_norm_5;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_norm_5 = value;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x003DF86C File Offset: 0x003DDC6C
		// (set) Token: 0x06001E89 RID: 7817 RVA: 0x003DF880 File Offset: 0x003DDC80
		internal virtual TextBox Valor_cont_norm_14
		{
			get
			{
				return this._Valor_cont_norm_14;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_norm_14 = value;
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x003DF88C File Offset: 0x003DDC8C
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x003DF8A0 File Offset: 0x003DDCA0
		internal virtual TextBox Valor_cont_norm_4
		{
			get
			{
				return this._Valor_cont_norm_4;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_norm_4 = value;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x003DF8AC File Offset: 0x003DDCAC
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x003DF8C0 File Offset: 0x003DDCC0
		internal virtual TextBox Valor_cont_norm_13
		{
			get
			{
				return this._Valor_cont_norm_13;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_norm_13 = value;
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x003DF8CC File Offset: 0x003DDCCC
		// (set) Token: 0x06001E8F RID: 7823 RVA: 0x003DF8E0 File Offset: 0x003DDCE0
		internal virtual TextBox Valor_cont_norm_3
		{
			get
			{
				return this._Valor_cont_norm_3;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_norm_3 = value;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x003DF8EC File Offset: 0x003DDCEC
		// (set) Token: 0x06001E91 RID: 7825 RVA: 0x003DF900 File Offset: 0x003DDD00
		internal virtual TextBox Valor_cont_norm_12
		{
			get
			{
				return this._Valor_cont_norm_12;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_norm_12 = value;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x003DF90C File Offset: 0x003DDD0C
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x003DF920 File Offset: 0x003DDD20
		internal virtual TextBox Valor_cont_norm_2
		{
			get
			{
				return this._Valor_cont_norm_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_norm_2 = value;
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x003DF92C File Offset: 0x003DDD2C
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x003DF940 File Offset: 0x003DDD40
		internal virtual TextBox Valor_cont_norm_11
		{
			get
			{
				return this._Valor_cont_norm_11;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_norm_11 = value;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x003DF94C File Offset: 0x003DDD4C
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x003DF960 File Offset: 0x003DDD60
		internal virtual TextBox Valor_cont_norm_1
		{
			get
			{
				return this._Valor_cont_norm_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_cont_norm_1 = value;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x003DF96C File Offset: 0x003DDD6C
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x003DF980 File Offset: 0x003DDD80
		internal virtual Label Label_cont_norm_10
		{
			get
			{
				return this._Label_cont_norm_10;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_norm_10 = value;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x003DF98C File Offset: 0x003DDD8C
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x003DF9A0 File Offset: 0x003DDDA0
		internal virtual Label Label_cont_norm_9
		{
			get
			{
				return this._Label_cont_norm_9;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_norm_9 = value;
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x003DF9AC File Offset: 0x003DDDAC
		// (set) Token: 0x06001E9D RID: 7837 RVA: 0x003DF9C0 File Offset: 0x003DDDC0
		internal virtual Label Label_cont_norm_8
		{
			get
			{
				return this._Label_cont_norm_8;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_norm_8 = value;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x003DF9CC File Offset: 0x003DDDCC
		// (set) Token: 0x06001E9F RID: 7839 RVA: 0x003DF9E0 File Offset: 0x003DDDE0
		internal virtual Label Label_cont_norm_7
		{
			get
			{
				return this._Label_cont_norm_7;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_norm_7 = value;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x003DF9EC File Offset: 0x003DDDEC
		// (set) Token: 0x06001EA1 RID: 7841 RVA: 0x003DFA00 File Offset: 0x003DDE00
		internal virtual Label Label_cont_norm_16
		{
			get
			{
				return this._Label_cont_norm_16;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_norm_16 = value;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x003DFA0C File Offset: 0x003DDE0C
		// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x003DFA20 File Offset: 0x003DDE20
		internal virtual Label Label_cont_norm_6
		{
			get
			{
				return this._Label_cont_norm_6;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_norm_6 = value;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x003DFA2C File Offset: 0x003DDE2C
		// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x003DFA40 File Offset: 0x003DDE40
		internal virtual Label Label_cont_norm_15
		{
			get
			{
				return this._Label_cont_norm_15;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_norm_15 = value;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x003DFA4C File Offset: 0x003DDE4C
		// (set) Token: 0x06001EA7 RID: 7847 RVA: 0x003DFA60 File Offset: 0x003DDE60
		internal virtual Label Label_cont_norm_5
		{
			get
			{
				return this._Label_cont_norm_5;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_norm_5 = value;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x003DFA6C File Offset: 0x003DDE6C
		// (set) Token: 0x06001EA9 RID: 7849 RVA: 0x003DFA80 File Offset: 0x003DDE80
		internal virtual Label Label_cont_norm_14
		{
			get
			{
				return this._Label_cont_norm_14;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_norm_14 = value;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x003DFA8C File Offset: 0x003DDE8C
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x003DFAA0 File Offset: 0x003DDEA0
		internal virtual Label Label_cont_norm_4
		{
			get
			{
				return this._Label_cont_norm_4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_norm_4 = value;
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x003DFAAC File Offset: 0x003DDEAC
		// (set) Token: 0x06001EAD RID: 7853 RVA: 0x003DFAC0 File Offset: 0x003DDEC0
		internal virtual Label Label_cont_norm_13
		{
			get
			{
				return this._Label_cont_norm_13;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_norm_13 = value;
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x003DFACC File Offset: 0x003DDECC
		// (set) Token: 0x06001EAF RID: 7855 RVA: 0x003DFAE0 File Offset: 0x003DDEE0
		internal virtual Label Label_cont_norm_3
		{
			get
			{
				return this._Label_cont_norm_3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_norm_3 = value;
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x003DFAEC File Offset: 0x003DDEEC
		// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x003DFB00 File Offset: 0x003DDF00
		internal virtual Label Label_cont_norm_12
		{
			get
			{
				return this._Label_cont_norm_12;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_norm_12 = value;
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x003DFB0C File Offset: 0x003DDF0C
		// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x003DFB20 File Offset: 0x003DDF20
		internal virtual Label Label_cont_norm_2
		{
			get
			{
				return this._Label_cont_norm_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_norm_2 = value;
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x003DFB2C File Offset: 0x003DDF2C
		// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x003DFB40 File Offset: 0x003DDF40
		internal virtual Label Label_cont_norm_11
		{
			get
			{
				return this._Label_cont_norm_11;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_norm_11 = value;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x003DFB4C File Offset: 0x003DDF4C
		// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x003DFB60 File Offset: 0x003DDF60
		internal virtual Label Label_cont_norm_1
		{
			get
			{
				return this._Label_cont_norm_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cont_norm_1 = value;
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x003DFB6C File Offset: 0x003DDF6C
		// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x003DFB80 File Offset: 0x003DDF80
		internal virtual GroupBox Grupo_controle_calibracao
		{
			get
			{
				return this._Grupo_controle_calibracao;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_controle_calibracao = value;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x003DFB8C File Offset: 0x003DDF8C
		// (set) Token: 0x06001EBB RID: 7867 RVA: 0x003DFBA0 File Offset: 0x003DDFA0
		internal virtual NumericUpDown Valor_canal_calibracao
		{
			get
			{
				return this._Valor_canal_calibracao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_canal_calibracao_ValueChanged);
				if (this._Valor_canal_calibracao != null)
				{
					this._Valor_canal_calibracao.ValueChanged -= eventHandler;
				}
				this._Valor_canal_calibracao = value;
				if (this._Valor_canal_calibracao != null)
				{
					this._Valor_canal_calibracao.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x003DFBEC File Offset: 0x003DDFEC
		// (set) Token: 0x06001EBD RID: 7869 RVA: 0x003DFC00 File Offset: 0x003DE000
		internal virtual Label Label_canal
		{
			get
			{
				return this._Label_canal;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_canal = value;
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x003DFC0C File Offset: 0x003DE00C
		// (set) Token: 0x06001EBF RID: 7871 RVA: 0x003DFC20 File Offset: 0x003DE020
		internal virtual Button Button_20_5ma
		{
			get
			{
				return this._Button_20_5ma;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_20_5ma_Click);
				if (this._Button_20_5ma != null)
				{
					this._Button_20_5ma.Click -= eventHandler;
				}
				this._Button_20_5ma = value;
				if (this._Button_20_5ma != null)
				{
					this._Button_20_5ma.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x003DFC6C File Offset: 0x003DE06C
		// (set) Token: 0x06001EC1 RID: 7873 RVA: 0x003DFC80 File Offset: 0x003DE080
		internal virtual Button Button_3_5ma
		{
			get
			{
				return this._Button_3_5ma;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_3_5ma_Click);
				if (this._Button_3_5ma != null)
				{
					this._Button_3_5ma.Click -= eventHandler;
				}
				this._Button_3_5ma = value;
				if (this._Button_3_5ma != null)
				{
					this._Button_3_5ma.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x003DFCCC File Offset: 0x003DE0CC
		// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x003DFCE0 File Offset: 0x003DE0E0
		internal virtual NumericUpDown Valor_cal_end
		{
			get
			{
				return this._Valor_cal_end;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_cal_end_ValueChanged);
				if (this._Valor_cal_end != null)
				{
					this._Valor_cal_end.ValueChanged -= eventHandler;
				}
				this._Valor_cal_end = value;
				if (this._Valor_cal_end != null)
				{
					this._Valor_cal_end.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x003DFD2C File Offset: 0x003DE12C
		// (set) Token: 0x06001EC5 RID: 7877 RVA: 0x003DFD40 File Offset: 0x003DE140
		internal virtual Label Label_end_cal
		{
			get
			{
				return this._Label_end_cal;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_cal = value;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x003DFD4C File Offset: 0x003DE14C
		// (set) Token: 0x06001EC7 RID: 7879 RVA: 0x003DFD60 File Offset: 0x003DE160
		internal virtual Button Button_termina
		{
			get
			{
				return this._Button_termina;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_termina_Click);
				if (this._Button_termina != null)
				{
					this._Button_termina.Click -= eventHandler;
				}
				this._Button_termina = value;
				if (this._Button_termina != null)
				{
					this._Button_termina.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x003DFDAC File Offset: 0x003DE1AC
		// (set) Token: 0x06001EC9 RID: 7881 RVA: 0x003DFDC0 File Offset: 0x003DE1C0
		internal virtual Button Button_inicia
		{
			get
			{
				return this._Button_inicia;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_inicia_Click);
				if (this._Button_inicia != null)
				{
					this._Button_inicia.Click -= eventHandler;
				}
				this._Button_inicia = value;
				if (this._Button_inicia != null)
				{
					this._Button_inicia.Click += eventHandler;
				}
			}
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x003DFE0C File Offset: 0x003DE20C
		private void Equip_202_cal_Load(object sender, EventArgs e)
		{
			Geral.Config_geral.Largura_tela_trabalho = this.Width;
			Mod_MD.Ctrl_cal.End_memoria = 768;
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x003DFE30 File Offset: 0x003DE230
		private void Comando_ler_cal_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			this.Comando_ler_cal.Enabled = false;
			this.Mensagem_MD202_cal("Aguarde ...", 2);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Leitura_pagina(768, Mod_MD.Monitoracao_MD_RQ.Estacao, 32);
			this.Mensagem_MD202_cal(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Comando_ler_cal.Enabled = true;
				return;
			}
			this.Atualiza_dados_tela_cal_MD202(768);
			Comunicacao.Rotina_Delay(200L);
			ctrl_RESP_ = Mod_MD.Leitura_pagina(1024, Mod_MD.Monitoracao_MD_RQ.Estacao, 33);
			this.Mensagem_MD202_cal(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Comando_ler_cal.Enabled = true;
				return;
			}
			this.Atualiza_dados_tela_cal_MD202(1024);
			this.Mensagem_MD202_cal("Leitura executada com sucesso", 0);
			this.Comando_ler_cal.Enabled = true;
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x003DFF2C File Offset: 0x003DE32C
		public void Mensagem_MD202_cal(string msg, int cor)
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

		// Token: 0x06001ECD RID: 7885 RVA: 0x003DFF90 File Offset: 0x003DE390
		public void Atualiza_dados_tela_cal_MD202(int pagina)
		{
			checked
			{
				if (pagina == 768)
				{
					this.Valor_zero_1.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4]);
					this.Valor_zero_2.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6]);
					this.Valor_zero_3.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8]);
					this.Valor_zero_4.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10]);
					this.Valor_zero_5.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12]);
					this.Valor_zero_6.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14]);
					this.Valor_zero_7.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[15] * 256 + (int)Comunicacao.Buffer_resp[16]);
					this.Valor_zero_8.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[17] * 256 + (int)Comunicacao.Buffer_resp[18]);
					this.Valor_zero_9.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[19] * 256 + (int)Comunicacao.Buffer_resp[20]);
					this.Valor_zero_10.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[21] * 256 + (int)Comunicacao.Buffer_resp[22]);
					this.Valor_zero_11.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[23] * 256 + (int)Comunicacao.Buffer_resp[24]);
					this.Valor_zero_12.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[25] * 256 + (int)Comunicacao.Buffer_resp[26]);
					this.Valor_zero_13.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[27] * 256 + (int)Comunicacao.Buffer_resp[28]);
					this.Valor_zero_14.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[29] * 256 + (int)Comunicacao.Buffer_resp[30]);
					this.Valor_zero_15.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[31] * 256 + (int)Comunicacao.Buffer_resp[32]);
					this.Valor_zero_16.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[33] * 256 + (int)Comunicacao.Buffer_resp[34]);
					this.Valor_ganho_1.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[35] * 256 + (int)Comunicacao.Buffer_resp[36]);
					this.Valor_ganho_2.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[37] * 256 + (int)Comunicacao.Buffer_resp[38]);
					this.Valor_ganho_3.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[39] * 256 + (int)Comunicacao.Buffer_resp[40]);
					this.Valor_ganho_4.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[41] * 256 + (int)Comunicacao.Buffer_resp[42]);
					this.Valor_ganho_5.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[43] * 256 + (int)Comunicacao.Buffer_resp[44]);
					this.Valor_ganho_6.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[45] * 256 + (int)Comunicacao.Buffer_resp[46]);
					this.Valor_ganho_7.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[47] * 256 + (int)Comunicacao.Buffer_resp[48]);
					this.Valor_ganho_8.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[49] * 256 + (int)Comunicacao.Buffer_resp[50]);
					this.Valor_ganho_9.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[51] * 256 + (int)Comunicacao.Buffer_resp[52]);
					this.Valor_ganho_10.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[53] * 256 + (int)Comunicacao.Buffer_resp[54]);
					this.Valor_ganho_11.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[55] * 256 + (int)Comunicacao.Buffer_resp[56]);
					this.Valor_ganho_12.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[57] * 256 + (int)Comunicacao.Buffer_resp[58]);
					this.Valor_ganho_13.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[59] * 256 + (int)Comunicacao.Buffer_resp[60]);
					this.Valor_ganho_14.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[61] * 256 + (int)Comunicacao.Buffer_resp[62]);
					this.Valor_ganho_15.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[63] * 256 + (int)Comunicacao.Buffer_resp[64]);
					this.Valor_ganho_16.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[65] * 256 + (int)Comunicacao.Buffer_resp[66]);
				}
				else if (pagina == 1024)
				{
					this.Valor_cont_norm_1.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4]);
					this.Valor_cont_norm_2.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6]);
					this.Valor_cont_norm_3.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8]);
					this.Valor_cont_norm_4.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10]);
					this.Valor_cont_norm_5.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12]);
					this.Valor_cont_norm_6.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14]);
					this.Valor_cont_norm_7.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[15] * 256 + (int)Comunicacao.Buffer_resp[16]);
					this.Valor_cont_norm_8.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[17] * 256 + (int)Comunicacao.Buffer_resp[18]);
					this.Valor_cont_norm_9.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[19] * 256 + (int)Comunicacao.Buffer_resp[20]);
					this.Valor_cont_norm_10.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[21] * 256 + (int)Comunicacao.Buffer_resp[22]);
					this.Valor_cont_norm_11.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[23] * 256 + (int)Comunicacao.Buffer_resp[24]);
					this.Valor_cont_norm_12.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[25] * 256 + (int)Comunicacao.Buffer_resp[26]);
					this.Valor_cont_norm_13.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[27] * 256 + (int)Comunicacao.Buffer_resp[28]);
					this.Valor_cont_norm_14.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[29] * 256 + (int)Comunicacao.Buffer_resp[30]);
					this.Valor_cont_norm_15.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[31] * 256 + (int)Comunicacao.Buffer_resp[32]);
					this.Valor_cont_norm_16.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[33] * 256 + (int)Comunicacao.Buffer_resp[34]);
					int num = (int)Comunicacao.Buffer_resp[35] * 256 + (int)Comunicacao.Buffer_resp[36];
					if ((num & 1) != 0)
					{
						this.CheckBox_ED1.Checked = true;
					}
					else
					{
						this.CheckBox_ED1.Checked = false;
					}
					if ((num & 2) != 0)
					{
						this.CheckBox_ED2.Checked = true;
					}
					else
					{
						this.CheckBox_ED2.Checked = false;
					}
					if ((num & 4) != 0)
					{
						this.CheckBox_ED3.Checked = true;
					}
					else
					{
						this.CheckBox_ED3.Checked = false;
					}
					if ((num & 8) != 0)
					{
						this.CheckBox_ED4.Checked = true;
					}
					else
					{
						this.CheckBox_ED4.Checked = false;
					}
					if ((num & 16) != 0)
					{
						this.CheckBox_ED5.Checked = true;
					}
					else
					{
						this.CheckBox_ED5.Checked = false;
					}
					if ((num & 32) != 0)
					{
						this.CheckBox_ED6.Checked = true;
					}
					else
					{
						this.CheckBox_ED6.Checked = false;
					}
					if ((num & 64) != 0)
					{
						this.CheckBox_ED7.Checked = true;
					}
					else
					{
						this.CheckBox_ED7.Checked = false;
					}
					if ((num & 128) != 0)
					{
						this.CheckBox_ED8.Checked = true;
					}
					else
					{
						this.CheckBox_ED8.Checked = false;
					}
					this.Valor_cont_s_norm_1.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[37] * 256 + (int)Comunicacao.Buffer_resp[38]);
					this.Valor_cont_s_norm_2.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[39] * 256 + (int)Comunicacao.Buffer_resp[40]);
					this.Valor_cont_s_norm_3.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[41] * 256 + (int)Comunicacao.Buffer_resp[42]);
					this.Valor_cont_s_norm_4.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[43] * 256 + (int)Comunicacao.Buffer_resp[44]);
					this.Valor_cont_s_norm_5.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[45] * 256 + (int)Comunicacao.Buffer_resp[46]);
					this.Valor_cont_s_norm_6.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[47] * 256 + (int)Comunicacao.Buffer_resp[48]);
					this.Valor_cont_s_norm_7.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[49] * 256 + (int)Comunicacao.Buffer_resp[50]);
					this.Valor_cont_s_norm_8.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[51] * 256 + (int)Comunicacao.Buffer_resp[52]);
					this.Valor_cont_s_norm_9.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[53] * 256 + (int)Comunicacao.Buffer_resp[54]);
					this.Valor_cont_s_norm_10.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[55] * 256 + (int)Comunicacao.Buffer_resp[56]);
					this.Valor_cont_s_norm_11.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[57] * 256 + (int)Comunicacao.Buffer_resp[58]);
					this.Valor_cont_s_norm_12.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[59] * 256 + (int)Comunicacao.Buffer_resp[60]);
					this.Valor_cont_s_norm_13.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[61] * 256 + (int)Comunicacao.Buffer_resp[62]);
					this.Valor_cont_s_norm_14.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[63] * 256 + (int)Comunicacao.Buffer_resp[64]);
					this.Valor_cont_s_norm_15.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[65] * 256 + (int)Comunicacao.Buffer_resp[66]);
					this.Valor_cont_s_norm_16.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[67] * 256 + (int)Comunicacao.Buffer_resp[68]);
				}
			}
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x003E0AA0 File Offset: 0x003DEEA0
		private void Tela_end_estacao_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Estacao = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x003E0AC8 File Offset: 0x003DEEC8
		public void Controle_tecla_202_cal(int operacao)
		{
			switch (operacao)
			{
			case 1:
				this.Button_3_5ma.Enabled = true;
				this.Button_20_5ma.Enabled = true;
				break;
			case 2:
				this.Button_3_5ma.Enabled = false;
				this.Button_20_5ma.Enabled = false;
				break;
			case 3:
				this.Button_3_5ma.Enabled = true;
				break;
			case 4:
				this.Button_20_5ma.Enabled = true;
				break;
			}
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x003E0B40 File Offset: 0x003DEF40
		private void Valor_canal_calibracao_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Ctrl_cal.Canal = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x003E0B68 File Offset: 0x003DEF68
		private void Valor_cal_end_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Ctrl_cal.End_equip = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x003E0B90 File Offset: 0x003DEF90
		private void Button_3_5ma_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			this.Controle_tecla_202_cal(2);
			Mod_MD.Ctrl_cal.End_memoria = checked(767 + Mod_MD.Ctrl_cal.Canal);
			Mod_MD.Ctrl_cal.Dado = 21845;
			this.Mensagem_MD202_cal("Aguarde ...", 2);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Escrita_pagina(768, 3);
			this.Mensagem_MD202_cal(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_202_cal(1);
				return;
			}
			this.Mensagem_MD202_cal("Calibração 3,5 mA executada com sucesso", 0);
			this.Controle_tecla_202_cal(1);
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x003E0C38 File Offset: 0x003DF038
		private void Button_20_5ma_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			this.Controle_tecla_202_cal(2);
			Mod_MD.Ctrl_cal.End_memoria = checked(783 + Mod_MD.Ctrl_cal.Canal);
			Mod_MD.Ctrl_cal.Dado = 21845;
			this.Mensagem_MD202_cal("Aguarde ...", 2);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Escrita_pagina(768, 3);
			this.Mensagem_MD202_cal(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_202_cal(1);
				return;
			}
			this.Mensagem_MD202_cal("Calibração executada com sucesso", 0);
			this.Controle_tecla_202_cal(1);
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x003E0CE0 File Offset: 0x003DF0E0
		private void Button_inicia_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD202_cal(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_202_cal(1);
				return;
			}
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x003E0D38 File Offset: 0x003DF138
		private void Button_termina_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD202_cal(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_202_cal(1);
				return;
			}
		}

		// Token: 0x040015D5 RID: 5589
		[AccessedThroughProperty("Grupo_ctrl_com")]
		private GroupBox _Grupo_ctrl_com;

		// Token: 0x040015D6 RID: 5590
		[AccessedThroughProperty("Box_Msg")]
		private TextBox _Box_Msg;

		// Token: 0x040015D7 RID: 5591
		[AccessedThroughProperty("Comando_ler_cal")]
		private Button _Comando_ler_cal;

		// Token: 0x040015D8 RID: 5592
		[AccessedThroughProperty("Tela_end_estacao")]
		private NumericUpDown _Tela_end_estacao;

		// Token: 0x040015D9 RID: 5593
		[AccessedThroughProperty("Label_end_estacao")]
		private Label _Label_end_estacao;

		// Token: 0x040015DA RID: 5594
		[AccessedThroughProperty("Grupo_ent_digitais")]
		private GroupBox _Grupo_ent_digitais;

		// Token: 0x040015DB RID: 5595
		[AccessedThroughProperty("CheckBox_ED8")]
		private CheckBox _CheckBox_ED8;

		// Token: 0x040015DC RID: 5596
		[AccessedThroughProperty("CheckBox_ED4")]
		private CheckBox _CheckBox_ED4;

		// Token: 0x040015DD RID: 5597
		[AccessedThroughProperty("CheckBox_ED7")]
		private CheckBox _CheckBox_ED7;

		// Token: 0x040015DE RID: 5598
		[AccessedThroughProperty("CheckBox_ED3")]
		private CheckBox _CheckBox_ED3;

		// Token: 0x040015DF RID: 5599
		[AccessedThroughProperty("CheckBox_ED6")]
		private CheckBox _CheckBox_ED6;

		// Token: 0x040015E0 RID: 5600
		[AccessedThroughProperty("CheckBox_ED2")]
		private CheckBox _CheckBox_ED2;

		// Token: 0x040015E1 RID: 5601
		[AccessedThroughProperty("CheckBox_ED5")]
		private CheckBox _CheckBox_ED5;

		// Token: 0x040015E2 RID: 5602
		[AccessedThroughProperty("CheckBox_ED1")]
		private CheckBox _CheckBox_ED1;

		// Token: 0x040015E3 RID: 5603
		[AccessedThroughProperty("Grupo_calibracao")]
		private GroupBox _Grupo_calibracao;

		// Token: 0x040015E4 RID: 5604
		[AccessedThroughProperty("Grupo_zero")]
		private GroupBox _Grupo_zero;

		// Token: 0x040015E5 RID: 5605
		[AccessedThroughProperty("Valor_zero_4")]
		private TextBox _Valor_zero_4;

		// Token: 0x040015E6 RID: 5606
		[AccessedThroughProperty("Valor_zero_3")]
		private TextBox _Valor_zero_3;

		// Token: 0x040015E7 RID: 5607
		[AccessedThroughProperty("Valor_zero_2")]
		private TextBox _Valor_zero_2;

		// Token: 0x040015E8 RID: 5608
		[AccessedThroughProperty("Valor_zero_1")]
		private TextBox _Valor_zero_1;

		// Token: 0x040015E9 RID: 5609
		[AccessedThroughProperty("Label_zero_4")]
		private Label _Label_zero_4;

		// Token: 0x040015EA RID: 5610
		[AccessedThroughProperty("Label_zero_3")]
		private Label _Label_zero_3;

		// Token: 0x040015EB RID: 5611
		[AccessedThroughProperty("Label_zero_2")]
		private Label _Label_zero_2;

		// Token: 0x040015EC RID: 5612
		[AccessedThroughProperty("Label_zero_1")]
		private Label _Label_zero_1;

		// Token: 0x040015ED RID: 5613
		[AccessedThroughProperty("Valor_zero_10")]
		private TextBox _Valor_zero_10;

		// Token: 0x040015EE RID: 5614
		[AccessedThroughProperty("Valor_zero_9")]
		private TextBox _Valor_zero_9;

		// Token: 0x040015EF RID: 5615
		[AccessedThroughProperty("Valor_zero_8")]
		private TextBox _Valor_zero_8;

		// Token: 0x040015F0 RID: 5616
		[AccessedThroughProperty("Valor_zero_7")]
		private TextBox _Valor_zero_7;

		// Token: 0x040015F1 RID: 5617
		[AccessedThroughProperty("Valor_zero_6")]
		private TextBox _Valor_zero_6;

		// Token: 0x040015F2 RID: 5618
		[AccessedThroughProperty("Valor_zero_5")]
		private TextBox _Valor_zero_5;

		// Token: 0x040015F3 RID: 5619
		[AccessedThroughProperty("Label_zero_10")]
		private Label _Label_zero_10;

		// Token: 0x040015F4 RID: 5620
		[AccessedThroughProperty("Label_zero_9")]
		private Label _Label_zero_9;

		// Token: 0x040015F5 RID: 5621
		[AccessedThroughProperty("Label_zero_8")]
		private Label _Label_zero_8;

		// Token: 0x040015F6 RID: 5622
		[AccessedThroughProperty("Label_zero_7")]
		private Label _Label_zero_7;

		// Token: 0x040015F7 RID: 5623
		[AccessedThroughProperty("Label_zero_6")]
		private Label _Label_zero_6;

		// Token: 0x040015F8 RID: 5624
		[AccessedThroughProperty("Label_zero_5")]
		private Label _Label_zero_5;

		// Token: 0x040015F9 RID: 5625
		[AccessedThroughProperty("Grupo_ganho")]
		private GroupBox _Grupo_ganho;

		// Token: 0x040015FA RID: 5626
		[AccessedThroughProperty("Valor_ganho_4")]
		private TextBox _Valor_ganho_4;

		// Token: 0x040015FB RID: 5627
		[AccessedThroughProperty("Valor_ganho_3")]
		private TextBox _Valor_ganho_3;

		// Token: 0x040015FC RID: 5628
		[AccessedThroughProperty("Valor_ganho_2")]
		private TextBox _Valor_ganho_2;

		// Token: 0x040015FD RID: 5629
		[AccessedThroughProperty("Valor_ganho_1")]
		private TextBox _Valor_ganho_1;

		// Token: 0x040015FE RID: 5630
		[AccessedThroughProperty("Label_ganho_4")]
		private Label _Label_ganho_4;

		// Token: 0x040015FF RID: 5631
		[AccessedThroughProperty("Label_ganho_3")]
		private Label _Label_ganho_3;

		// Token: 0x04001600 RID: 5632
		[AccessedThroughProperty("Label_ganho_2")]
		private Label _Label_ganho_2;

		// Token: 0x04001601 RID: 5633
		[AccessedThroughProperty("Label_ganho_1")]
		private Label _Label_ganho_1;

		// Token: 0x04001602 RID: 5634
		[AccessedThroughProperty("Valor_zero_16")]
		private TextBox _Valor_zero_16;

		// Token: 0x04001603 RID: 5635
		[AccessedThroughProperty("Valor_zero_15")]
		private TextBox _Valor_zero_15;

		// Token: 0x04001604 RID: 5636
		[AccessedThroughProperty("Valor_zero_14")]
		private TextBox _Valor_zero_14;

		// Token: 0x04001605 RID: 5637
		[AccessedThroughProperty("Valor_zero_13")]
		private TextBox _Valor_zero_13;

		// Token: 0x04001606 RID: 5638
		[AccessedThroughProperty("Valor_zero_12")]
		private TextBox _Valor_zero_12;

		// Token: 0x04001607 RID: 5639
		[AccessedThroughProperty("Valor_zero_11")]
		private TextBox _Valor_zero_11;

		// Token: 0x04001608 RID: 5640
		[AccessedThroughProperty("Label_zero_16")]
		private Label _Label_zero_16;

		// Token: 0x04001609 RID: 5641
		[AccessedThroughProperty("Label_zero_15")]
		private Label _Label_zero_15;

		// Token: 0x0400160A RID: 5642
		[AccessedThroughProperty("Label_zero_14")]
		private Label _Label_zero_14;

		// Token: 0x0400160B RID: 5643
		[AccessedThroughProperty("Label_zero_13")]
		private Label _Label_zero_13;

		// Token: 0x0400160C RID: 5644
		[AccessedThroughProperty("Label_zero_12")]
		private Label _Label_zero_12;

		// Token: 0x0400160D RID: 5645
		[AccessedThroughProperty("Label_zero_11")]
		private Label _Label_zero_11;

		// Token: 0x0400160E RID: 5646
		[AccessedThroughProperty("Valor_ganho_8")]
		private TextBox _Valor_ganho_8;

		// Token: 0x0400160F RID: 5647
		[AccessedThroughProperty("Valor_ganho_7")]
		private TextBox _Valor_ganho_7;

		// Token: 0x04001610 RID: 5648
		[AccessedThroughProperty("Valor_ganho_6")]
		private TextBox _Valor_ganho_6;

		// Token: 0x04001611 RID: 5649
		[AccessedThroughProperty("Valor_ganho_5")]
		private TextBox _Valor_ganho_5;

		// Token: 0x04001612 RID: 5650
		[AccessedThroughProperty("Label_ganho_8")]
		private Label _Label_ganho_8;

		// Token: 0x04001613 RID: 5651
		[AccessedThroughProperty("Label_ganho_7")]
		private Label _Label_ganho_7;

		// Token: 0x04001614 RID: 5652
		[AccessedThroughProperty("Label_ganho_6")]
		private Label _Label_ganho_6;

		// Token: 0x04001615 RID: 5653
		[AccessedThroughProperty("Label_ganho_5")]
		private Label _Label_ganho_5;

		// Token: 0x04001616 RID: 5654
		[AccessedThroughProperty("Valor_ganho_10")]
		private TextBox _Valor_ganho_10;

		// Token: 0x04001617 RID: 5655
		[AccessedThroughProperty("Valor_ganho_9")]
		private TextBox _Valor_ganho_9;

		// Token: 0x04001618 RID: 5656
		[AccessedThroughProperty("Label_ganho_10")]
		private Label _Label_ganho_10;

		// Token: 0x04001619 RID: 5657
		[AccessedThroughProperty("Label_ganho_9")]
		private Label _Label_ganho_9;

		// Token: 0x0400161A RID: 5658
		[AccessedThroughProperty("Valor_ganho_14")]
		private TextBox _Valor_ganho_14;

		// Token: 0x0400161B RID: 5659
		[AccessedThroughProperty("Valor_ganho_13")]
		private TextBox _Valor_ganho_13;

		// Token: 0x0400161C RID: 5660
		[AccessedThroughProperty("Valor_ganho_16")]
		private TextBox _Valor_ganho_16;

		// Token: 0x0400161D RID: 5661
		[AccessedThroughProperty("Valor_ganho_12")]
		private TextBox _Valor_ganho_12;

		// Token: 0x0400161E RID: 5662
		[AccessedThroughProperty("Valor_ganho_15")]
		private TextBox _Valor_ganho_15;

		// Token: 0x0400161F RID: 5663
		[AccessedThroughProperty("Valor_ganho_11")]
		private TextBox _Valor_ganho_11;

		// Token: 0x04001620 RID: 5664
		[AccessedThroughProperty("Label_ganho_14")]
		private Label _Label_ganho_14;

		// Token: 0x04001621 RID: 5665
		[AccessedThroughProperty("Label_ganho_13")]
		private Label _Label_ganho_13;

		// Token: 0x04001622 RID: 5666
		[AccessedThroughProperty("Label_ganho_16")]
		private Label _Label_ganho_16;

		// Token: 0x04001623 RID: 5667
		[AccessedThroughProperty("Label_ganho_12")]
		private Label _Label_ganho_12;

		// Token: 0x04001624 RID: 5668
		[AccessedThroughProperty("Label_ganho_15")]
		private Label _Label_ganho_15;

		// Token: 0x04001625 RID: 5669
		[AccessedThroughProperty("Label_ganho_11")]
		private Label _Label_ganho_11;

		// Token: 0x04001626 RID: 5670
		[AccessedThroughProperty("Grupo_cont_sem_norm")]
		private GroupBox _Grupo_cont_sem_norm;

		// Token: 0x04001627 RID: 5671
		[AccessedThroughProperty("Valor_cont_s_norm_10")]
		private TextBox _Valor_cont_s_norm_10;

		// Token: 0x04001628 RID: 5672
		[AccessedThroughProperty("Valor_cont_s_norm_9")]
		private TextBox _Valor_cont_s_norm_9;

		// Token: 0x04001629 RID: 5673
		[AccessedThroughProperty("Valor_cont_s_norm_8")]
		private TextBox _Valor_cont_s_norm_8;

		// Token: 0x0400162A RID: 5674
		[AccessedThroughProperty("Valor_cont_s_norm_7")]
		private TextBox _Valor_cont_s_norm_7;

		// Token: 0x0400162B RID: 5675
		[AccessedThroughProperty("Valor_cont_s_norm_16")]
		private TextBox _Valor_cont_s_norm_16;

		// Token: 0x0400162C RID: 5676
		[AccessedThroughProperty("Valor_cont_s_norm_6")]
		private TextBox _Valor_cont_s_norm_6;

		// Token: 0x0400162D RID: 5677
		[AccessedThroughProperty("Valor_cont_s_norm_15")]
		private TextBox _Valor_cont_s_norm_15;

		// Token: 0x0400162E RID: 5678
		[AccessedThroughProperty("Valor_cont_s_norm_5")]
		private TextBox _Valor_cont_s_norm_5;

		// Token: 0x0400162F RID: 5679
		[AccessedThroughProperty("Valor_cont_s_norm_14")]
		private TextBox _Valor_cont_s_norm_14;

		// Token: 0x04001630 RID: 5680
		[AccessedThroughProperty("Valor_cont_s_norm_4")]
		private TextBox _Valor_cont_s_norm_4;

		// Token: 0x04001631 RID: 5681
		[AccessedThroughProperty("Valor_cont_s_norm_13")]
		private TextBox _Valor_cont_s_norm_13;

		// Token: 0x04001632 RID: 5682
		[AccessedThroughProperty("Valor_cont_s_norm_3")]
		private TextBox _Valor_cont_s_norm_3;

		// Token: 0x04001633 RID: 5683
		[AccessedThroughProperty("Valor_cont_s_norm_12")]
		private TextBox _Valor_cont_s_norm_12;

		// Token: 0x04001634 RID: 5684
		[AccessedThroughProperty("Valor_cont_s_norm_2")]
		private TextBox _Valor_cont_s_norm_2;

		// Token: 0x04001635 RID: 5685
		[AccessedThroughProperty("Valor_cont_s_norm_11")]
		private TextBox _Valor_cont_s_norm_11;

		// Token: 0x04001636 RID: 5686
		[AccessedThroughProperty("Valor_cont_s_norm_1")]
		private TextBox _Valor_cont_s_norm_1;

		// Token: 0x04001637 RID: 5687
		[AccessedThroughProperty("Label_cont_s_norm_10")]
		private Label _Label_cont_s_norm_10;

		// Token: 0x04001638 RID: 5688
		[AccessedThroughProperty("Label_cont_s_norm_9")]
		private Label _Label_cont_s_norm_9;

		// Token: 0x04001639 RID: 5689
		[AccessedThroughProperty("Label_cont_s_norm_8")]
		private Label _Label_cont_s_norm_8;

		// Token: 0x0400163A RID: 5690
		[AccessedThroughProperty("Label_cont_s_norm_7")]
		private Label _Label_cont_s_norm_7;

		// Token: 0x0400163B RID: 5691
		[AccessedThroughProperty("Label_cont_s_norm_16")]
		private Label _Label_cont_s_norm_16;

		// Token: 0x0400163C RID: 5692
		[AccessedThroughProperty("Label_cont_s_norm_6")]
		private Label _Label_cont_s_norm_6;

		// Token: 0x0400163D RID: 5693
		[AccessedThroughProperty("Label_cont_s_norm_15")]
		private Label _Label_cont_s_norm_15;

		// Token: 0x0400163E RID: 5694
		[AccessedThroughProperty("Label_cont_s_norm_5")]
		private Label _Label_cont_s_norm_5;

		// Token: 0x0400163F RID: 5695
		[AccessedThroughProperty("Label_cont_s_norm_14")]
		private Label _Label_cont_s_norm_14;

		// Token: 0x04001640 RID: 5696
		[AccessedThroughProperty("Label_cont_s_norm_4")]
		private Label _Label_cont_s_norm_4;

		// Token: 0x04001641 RID: 5697
		[AccessedThroughProperty("Label_cont_s_norm_13")]
		private Label _Label_cont_s_norm_13;

		// Token: 0x04001642 RID: 5698
		[AccessedThroughProperty("Label_cont_s_norm_3")]
		private Label _Label_cont_s_norm_3;

		// Token: 0x04001643 RID: 5699
		[AccessedThroughProperty("Label_cont_s_norm_12")]
		private Label _Label_cont_s_norm_12;

		// Token: 0x04001644 RID: 5700
		[AccessedThroughProperty("Label_cont_s_norm_2")]
		private Label _Label_cont_s_norm_2;

		// Token: 0x04001645 RID: 5701
		[AccessedThroughProperty("Label_cont_s_norm_11")]
		private Label _Label_cont_s_norm_11;

		// Token: 0x04001646 RID: 5702
		[AccessedThroughProperty("Label_cont_s_norm_1")]
		private Label _Label_cont_s_norm_1;

		// Token: 0x04001647 RID: 5703
		[AccessedThroughProperty("Grupo_cont_norm")]
		private GroupBox _Grupo_cont_norm;

		// Token: 0x04001648 RID: 5704
		[AccessedThroughProperty("Valor_cont_norm_10")]
		private TextBox _Valor_cont_norm_10;

		// Token: 0x04001649 RID: 5705
		[AccessedThroughProperty("Valor_cont_norm_9")]
		private TextBox _Valor_cont_norm_9;

		// Token: 0x0400164A RID: 5706
		[AccessedThroughProperty("Valor_cont_norm_8")]
		private TextBox _Valor_cont_norm_8;

		// Token: 0x0400164B RID: 5707
		[AccessedThroughProperty("Valor_cont_norm_7")]
		private TextBox _Valor_cont_norm_7;

		// Token: 0x0400164C RID: 5708
		[AccessedThroughProperty("Valor_cont_norm_16")]
		private TextBox _Valor_cont_norm_16;

		// Token: 0x0400164D RID: 5709
		[AccessedThroughProperty("Valor_cont_norm_6")]
		private TextBox _Valor_cont_norm_6;

		// Token: 0x0400164E RID: 5710
		[AccessedThroughProperty("Valor_cont_norm_15")]
		private TextBox _Valor_cont_norm_15;

		// Token: 0x0400164F RID: 5711
		[AccessedThroughProperty("Valor_cont_norm_5")]
		private TextBox _Valor_cont_norm_5;

		// Token: 0x04001650 RID: 5712
		[AccessedThroughProperty("Valor_cont_norm_14")]
		private TextBox _Valor_cont_norm_14;

		// Token: 0x04001651 RID: 5713
		[AccessedThroughProperty("Valor_cont_norm_4")]
		private TextBox _Valor_cont_norm_4;

		// Token: 0x04001652 RID: 5714
		[AccessedThroughProperty("Valor_cont_norm_13")]
		private TextBox _Valor_cont_norm_13;

		// Token: 0x04001653 RID: 5715
		[AccessedThroughProperty("Valor_cont_norm_3")]
		private TextBox _Valor_cont_norm_3;

		// Token: 0x04001654 RID: 5716
		[AccessedThroughProperty("Valor_cont_norm_12")]
		private TextBox _Valor_cont_norm_12;

		// Token: 0x04001655 RID: 5717
		[AccessedThroughProperty("Valor_cont_norm_2")]
		private TextBox _Valor_cont_norm_2;

		// Token: 0x04001656 RID: 5718
		[AccessedThroughProperty("Valor_cont_norm_11")]
		private TextBox _Valor_cont_norm_11;

		// Token: 0x04001657 RID: 5719
		[AccessedThroughProperty("Valor_cont_norm_1")]
		private TextBox _Valor_cont_norm_1;

		// Token: 0x04001658 RID: 5720
		[AccessedThroughProperty("Label_cont_norm_10")]
		private Label _Label_cont_norm_10;

		// Token: 0x04001659 RID: 5721
		[AccessedThroughProperty("Label_cont_norm_9")]
		private Label _Label_cont_norm_9;

		// Token: 0x0400165A RID: 5722
		[AccessedThroughProperty("Label_cont_norm_8")]
		private Label _Label_cont_norm_8;

		// Token: 0x0400165B RID: 5723
		[AccessedThroughProperty("Label_cont_norm_7")]
		private Label _Label_cont_norm_7;

		// Token: 0x0400165C RID: 5724
		[AccessedThroughProperty("Label_cont_norm_16")]
		private Label _Label_cont_norm_16;

		// Token: 0x0400165D RID: 5725
		[AccessedThroughProperty("Label_cont_norm_6")]
		private Label _Label_cont_norm_6;

		// Token: 0x0400165E RID: 5726
		[AccessedThroughProperty("Label_cont_norm_15")]
		private Label _Label_cont_norm_15;

		// Token: 0x0400165F RID: 5727
		[AccessedThroughProperty("Label_cont_norm_5")]
		private Label _Label_cont_norm_5;

		// Token: 0x04001660 RID: 5728
		[AccessedThroughProperty("Label_cont_norm_14")]
		private Label _Label_cont_norm_14;

		// Token: 0x04001661 RID: 5729
		[AccessedThroughProperty("Label_cont_norm_4")]
		private Label _Label_cont_norm_4;

		// Token: 0x04001662 RID: 5730
		[AccessedThroughProperty("Label_cont_norm_13")]
		private Label _Label_cont_norm_13;

		// Token: 0x04001663 RID: 5731
		[AccessedThroughProperty("Label_cont_norm_3")]
		private Label _Label_cont_norm_3;

		// Token: 0x04001664 RID: 5732
		[AccessedThroughProperty("Label_cont_norm_12")]
		private Label _Label_cont_norm_12;

		// Token: 0x04001665 RID: 5733
		[AccessedThroughProperty("Label_cont_norm_2")]
		private Label _Label_cont_norm_2;

		// Token: 0x04001666 RID: 5734
		[AccessedThroughProperty("Label_cont_norm_11")]
		private Label _Label_cont_norm_11;

		// Token: 0x04001667 RID: 5735
		[AccessedThroughProperty("Label_cont_norm_1")]
		private Label _Label_cont_norm_1;

		// Token: 0x04001668 RID: 5736
		[AccessedThroughProperty("Grupo_controle_calibracao")]
		private GroupBox _Grupo_controle_calibracao;

		// Token: 0x04001669 RID: 5737
		[AccessedThroughProperty("Valor_canal_calibracao")]
		private NumericUpDown _Valor_canal_calibracao;

		// Token: 0x0400166A RID: 5738
		[AccessedThroughProperty("Label_canal")]
		private Label _Label_canal;

		// Token: 0x0400166B RID: 5739
		[AccessedThroughProperty("Button_20_5ma")]
		private Button _Button_20_5ma;

		// Token: 0x0400166C RID: 5740
		[AccessedThroughProperty("Button_3_5ma")]
		private Button _Button_3_5ma;

		// Token: 0x0400166D RID: 5741
		[AccessedThroughProperty("Valor_cal_end")]
		private NumericUpDown _Valor_cal_end;

		// Token: 0x0400166E RID: 5742
		[AccessedThroughProperty("Label_end_cal")]
		private Label _Label_end_cal;

		// Token: 0x0400166F RID: 5743
		[AccessedThroughProperty("Button_termina")]
		private Button _Button_termina;

		// Token: 0x04001670 RID: 5744
		[AccessedThroughProperty("Button_inicia")]
		private Button _Button_inicia;
	}
}
