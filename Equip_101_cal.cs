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
	// Token: 0x0200007E RID: 126
	[DesignerGenerated]
	public partial class Equip_101_cal : Form
	{
		// Token: 0x06001A68 RID: 6760 RVA: 0x003C10D4 File Offset: 0x003BF4D4
		public Equip_101_cal()
		{
			base.Load += new EventHandler(this.Equip_101_cal_Load);
			this.InitializeComponent();
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001A6B RID: 6763 RVA: 0x003C3A98 File Offset: 0x003C1E98
		// (set) Token: 0x06001A6C RID: 6764 RVA: 0x003C3AAC File Offset: 0x003C1EAC
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

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x003C3AB8 File Offset: 0x003C1EB8
		// (set) Token: 0x06001A6E RID: 6766 RVA: 0x003C3ACC File Offset: 0x003C1ECC
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

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x003C3AD8 File Offset: 0x003C1ED8
		// (set) Token: 0x06001A70 RID: 6768 RVA: 0x003C3AEC File Offset: 0x003C1EEC
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

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001A71 RID: 6769 RVA: 0x003C3AF8 File Offset: 0x003C1EF8
		// (set) Token: 0x06001A72 RID: 6770 RVA: 0x003C3B0C File Offset: 0x003C1F0C
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

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001A73 RID: 6771 RVA: 0x003C3B18 File Offset: 0x003C1F18
		// (set) Token: 0x06001A74 RID: 6772 RVA: 0x003C3B2C File Offset: 0x003C1F2C
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

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001A75 RID: 6773 RVA: 0x003C3B38 File Offset: 0x003C1F38
		// (set) Token: 0x06001A76 RID: 6774 RVA: 0x003C3B4C File Offset: 0x003C1F4C
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

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001A77 RID: 6775 RVA: 0x003C3B58 File Offset: 0x003C1F58
		// (set) Token: 0x06001A78 RID: 6776 RVA: 0x003C3B6C File Offset: 0x003C1F6C
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

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001A79 RID: 6777 RVA: 0x003C3B78 File Offset: 0x003C1F78
		// (set) Token: 0x06001A7A RID: 6778 RVA: 0x003C3B8C File Offset: 0x003C1F8C
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

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x003C3B98 File Offset: 0x003C1F98
		// (set) Token: 0x06001A7C RID: 6780 RVA: 0x003C3BAC File Offset: 0x003C1FAC
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

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x003C3BB8 File Offset: 0x003C1FB8
		// (set) Token: 0x06001A7E RID: 6782 RVA: 0x003C3BCC File Offset: 0x003C1FCC
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

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001A7F RID: 6783 RVA: 0x003C3BD8 File Offset: 0x003C1FD8
		// (set) Token: 0x06001A80 RID: 6784 RVA: 0x003C3BEC File Offset: 0x003C1FEC
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

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001A81 RID: 6785 RVA: 0x003C3BF8 File Offset: 0x003C1FF8
		// (set) Token: 0x06001A82 RID: 6786 RVA: 0x003C3C0C File Offset: 0x003C200C
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

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001A83 RID: 6787 RVA: 0x003C3C18 File Offset: 0x003C2018
		// (set) Token: 0x06001A84 RID: 6788 RVA: 0x003C3C2C File Offset: 0x003C202C
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

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x003C3C38 File Offset: 0x003C2038
		// (set) Token: 0x06001A86 RID: 6790 RVA: 0x003C3C4C File Offset: 0x003C204C
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

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001A87 RID: 6791 RVA: 0x003C3C58 File Offset: 0x003C2058
		// (set) Token: 0x06001A88 RID: 6792 RVA: 0x003C3C6C File Offset: 0x003C206C
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

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001A89 RID: 6793 RVA: 0x003C3C78 File Offset: 0x003C2078
		// (set) Token: 0x06001A8A RID: 6794 RVA: 0x003C3C8C File Offset: 0x003C208C
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

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x003C3C98 File Offset: 0x003C2098
		// (set) Token: 0x06001A8C RID: 6796 RVA: 0x003C3CAC File Offset: 0x003C20AC
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

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x003C3CB8 File Offset: 0x003C20B8
		// (set) Token: 0x06001A8E RID: 6798 RVA: 0x003C3CCC File Offset: 0x003C20CC
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

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001A8F RID: 6799 RVA: 0x003C3CD8 File Offset: 0x003C20D8
		// (set) Token: 0x06001A90 RID: 6800 RVA: 0x003C3CEC File Offset: 0x003C20EC
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

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001A91 RID: 6801 RVA: 0x003C3CF8 File Offset: 0x003C20F8
		// (set) Token: 0x06001A92 RID: 6802 RVA: 0x003C3D0C File Offset: 0x003C210C
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

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x003C3D18 File Offset: 0x003C2118
		// (set) Token: 0x06001A94 RID: 6804 RVA: 0x003C3D2C File Offset: 0x003C212C
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

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001A95 RID: 6805 RVA: 0x003C3D38 File Offset: 0x003C2138
		// (set) Token: 0x06001A96 RID: 6806 RVA: 0x003C3D4C File Offset: 0x003C214C
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

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x003C3D58 File Offset: 0x003C2158
		// (set) Token: 0x06001A98 RID: 6808 RVA: 0x003C3D6C File Offset: 0x003C216C
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

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x003C3D78 File Offset: 0x003C2178
		// (set) Token: 0x06001A9A RID: 6810 RVA: 0x003C3D8C File Offset: 0x003C218C
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

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001A9B RID: 6811 RVA: 0x003C3D98 File Offset: 0x003C2198
		// (set) Token: 0x06001A9C RID: 6812 RVA: 0x003C3DAC File Offset: 0x003C21AC
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

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x003C3DB8 File Offset: 0x003C21B8
		// (set) Token: 0x06001A9E RID: 6814 RVA: 0x003C3DCC File Offset: 0x003C21CC
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

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001A9F RID: 6815 RVA: 0x003C3DD8 File Offset: 0x003C21D8
		// (set) Token: 0x06001AA0 RID: 6816 RVA: 0x003C3DEC File Offset: 0x003C21EC
		internal virtual GroupBox Grupo_cont_sem_nor
		{
			get
			{
				return this._Grupo_cont_sem_nor;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_cont_sem_nor = value;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x003C3DF8 File Offset: 0x003C21F8
		// (set) Token: 0x06001AA2 RID: 6818 RVA: 0x003C3E0C File Offset: 0x003C220C
		internal virtual TextBox Valor_sem_nor_EA4
		{
			get
			{
				return this._Valor_sem_nor_EA4;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_sem_nor_EA4 = value;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001AA3 RID: 6819 RVA: 0x003C3E18 File Offset: 0x003C2218
		// (set) Token: 0x06001AA4 RID: 6820 RVA: 0x003C3E2C File Offset: 0x003C222C
		internal virtual TextBox Valor_sem_nor_EA3
		{
			get
			{
				return this._Valor_sem_nor_EA3;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_sem_nor_EA3 = value;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x003C3E38 File Offset: 0x003C2238
		// (set) Token: 0x06001AA6 RID: 6822 RVA: 0x003C3E4C File Offset: 0x003C224C
		internal virtual TextBox Valor_sem_nor_EA2
		{
			get
			{
				return this._Valor_sem_nor_EA2;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_sem_nor_EA2 = value;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x003C3E58 File Offset: 0x003C2258
		// (set) Token: 0x06001AA8 RID: 6824 RVA: 0x003C3E6C File Offset: 0x003C226C
		internal virtual TextBox Valor_sem_nor_EA1
		{
			get
			{
				return this._Valor_sem_nor_EA1;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_sem_nor_EA1 = value;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x003C3E78 File Offset: 0x003C2278
		// (set) Token: 0x06001AAA RID: 6826 RVA: 0x003C3E8C File Offset: 0x003C228C
		internal virtual Label Label_sem_nor_EA4
		{
			get
			{
				return this._Label_sem_nor_EA4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_sem_nor_EA4 = value;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x003C3E98 File Offset: 0x003C2298
		// (set) Token: 0x06001AAC RID: 6828 RVA: 0x003C3EAC File Offset: 0x003C22AC
		internal virtual Label Label_sem_nor_EA3
		{
			get
			{
				return this._Label_sem_nor_EA3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_sem_nor_EA3 = value;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x003C3EB8 File Offset: 0x003C22B8
		// (set) Token: 0x06001AAE RID: 6830 RVA: 0x003C3ECC File Offset: 0x003C22CC
		internal virtual Label Label_sem_nor_EA2
		{
			get
			{
				return this._Label_sem_nor_EA2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_sem_nor_EA2 = value;
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001AAF RID: 6831 RVA: 0x003C3ED8 File Offset: 0x003C22D8
		// (set) Token: 0x06001AB0 RID: 6832 RVA: 0x003C3EEC File Offset: 0x003C22EC
		internal virtual Label Label_sem_nor_EA1
		{
			get
			{
				return this._Label_sem_nor_EA1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_sem_nor_EA1 = value;
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001AB1 RID: 6833 RVA: 0x003C3EF8 File Offset: 0x003C22F8
		// (set) Token: 0x06001AB2 RID: 6834 RVA: 0x003C3F0C File Offset: 0x003C230C
		internal virtual GroupBox Grupo_cont_normal
		{
			get
			{
				return this._Grupo_cont_normal;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_cont_normal = value;
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x003C3F18 File Offset: 0x003C2318
		// (set) Token: 0x06001AB4 RID: 6836 RVA: 0x003C3F2C File Offset: 0x003C232C
		internal virtual TextBox Valor_nor_EA4
		{
			get
			{
				return this._Valor_nor_EA4;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_nor_EA4 = value;
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x003C3F38 File Offset: 0x003C2338
		// (set) Token: 0x06001AB6 RID: 6838 RVA: 0x003C3F4C File Offset: 0x003C234C
		internal virtual TextBox Valor_nor_EA3
		{
			get
			{
				return this._Valor_nor_EA3;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_nor_EA3 = value;
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x003C3F58 File Offset: 0x003C2358
		// (set) Token: 0x06001AB8 RID: 6840 RVA: 0x003C3F6C File Offset: 0x003C236C
		internal virtual TextBox Valor_nor_EA2
		{
			get
			{
				return this._Valor_nor_EA2;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_nor_EA2 = value;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x003C3F78 File Offset: 0x003C2378
		// (set) Token: 0x06001ABA RID: 6842 RVA: 0x003C3F8C File Offset: 0x003C238C
		internal virtual TextBox Valor_nor_EA1
		{
			get
			{
				return this._Valor_nor_EA1;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_nor_EA1 = value;
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001ABB RID: 6843 RVA: 0x003C3F98 File Offset: 0x003C2398
		// (set) Token: 0x06001ABC RID: 6844 RVA: 0x003C3FAC File Offset: 0x003C23AC
		internal virtual Label Label_nor_EA4
		{
			get
			{
				return this._Label_nor_EA4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nor_EA4 = value;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001ABD RID: 6845 RVA: 0x003C3FB8 File Offset: 0x003C23B8
		// (set) Token: 0x06001ABE RID: 6846 RVA: 0x003C3FCC File Offset: 0x003C23CC
		internal virtual Label Label_nor_EA3
		{
			get
			{
				return this._Label_nor_EA3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nor_EA3 = value;
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x003C3FD8 File Offset: 0x003C23D8
		// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x003C3FEC File Offset: 0x003C23EC
		internal virtual Label Label_nor_EA2
		{
			get
			{
				return this._Label_nor_EA2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nor_EA2 = value;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x003C3FF8 File Offset: 0x003C23F8
		// (set) Token: 0x06001AC2 RID: 6850 RVA: 0x003C400C File Offset: 0x003C240C
		internal virtual Label Label_nor_EA1
		{
			get
			{
				return this._Label_nor_EA1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nor_EA1 = value;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x003C4018 File Offset: 0x003C2418
		// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x003C402C File Offset: 0x003C242C
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

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x003C4038 File Offset: 0x003C2438
		// (set) Token: 0x06001AC6 RID: 6854 RVA: 0x003C404C File Offset: 0x003C244C
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

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x003C4098 File Offset: 0x003C2498
		// (set) Token: 0x06001AC8 RID: 6856 RVA: 0x003C40AC File Offset: 0x003C24AC
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

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x003C40B8 File Offset: 0x003C24B8
		// (set) Token: 0x06001ACA RID: 6858 RVA: 0x003C40CC File Offset: 0x003C24CC
		internal virtual GroupBox Grupo_medidas_eng
		{
			get
			{
				return this._Grupo_medidas_eng;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_medidas_eng = value;
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x003C40D8 File Offset: 0x003C24D8
		// (set) Token: 0x06001ACC RID: 6860 RVA: 0x003C40EC File Offset: 0x003C24EC
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

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001ACD RID: 6861 RVA: 0x003C40F8 File Offset: 0x003C24F8
		// (set) Token: 0x06001ACE RID: 6862 RVA: 0x003C410C File Offset: 0x003C250C
		internal virtual Label Label_defeito_sensor
		{
			get
			{
				return this._Label_defeito_sensor;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_defeito_sensor = value;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x003C4118 File Offset: 0x003C2518
		// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x003C412C File Offset: 0x003C252C
		internal virtual Label Label_arrombamento
		{
			get
			{
				return this._Label_arrombamento;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_arrombamento = value;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x003C4138 File Offset: 0x003C2538
		// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x003C414C File Offset: 0x003C254C
		internal virtual Label Label_vazio
		{
			get
			{
				return this._Label_vazio;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_vazio = value;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x003C4158 File Offset: 0x003C2558
		// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x003C416C File Offset: 0x003C256C
		internal virtual Label Label_transbordo
		{
			get
			{
				return this._Label_transbordo;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_transbordo = value;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x003C4178 File Offset: 0x003C2578
		// (set) Token: 0x06001AD6 RID: 6870 RVA: 0x003C418C File Offset: 0x003C258C
		internal virtual Label Label_em_bat
		{
			get
			{
				return this._Label_em_bat;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_em_bat = value;
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x003C4198 File Offset: 0x003C2598
		// (set) Token: 0x06001AD8 RID: 6872 RVA: 0x003C41AC File Offset: 0x003C25AC
		internal virtual Label Label_nivel_eng
		{
			get
			{
				return this._Label_nivel_eng;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_eng = value;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x003C41B8 File Offset: 0x003C25B8
		// (set) Token: 0x06001ADA RID: 6874 RVA: 0x003C41CC File Offset: 0x003C25CC
		internal virtual TextBox Tela_nivel
		{
			get
			{
				return this._Tela_nivel;
			}
			[MethodImpl(32)]
			set
			{
				this._Tela_nivel = value;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x003C41D8 File Offset: 0x003C25D8
		// (set) Token: 0x06001ADC RID: 6876 RVA: 0x003C41EC File Offset: 0x003C25EC
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

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x003C41F8 File Offset: 0x003C25F8
		// (set) Token: 0x06001ADE RID: 6878 RVA: 0x003C420C File Offset: 0x003C260C
		internal virtual Button Comando_hab_cal
		{
			get
			{
				return this._Comando_hab_cal;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Comando_hab_cal_Click);
				if (this._Comando_hab_cal != null)
				{
					this._Comando_hab_cal.Click -= eventHandler;
				}
				this._Comando_hab_cal = value;
				if (this._Comando_hab_cal != null)
				{
					this._Comando_hab_cal.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x003C4258 File Offset: 0x003C2658
		// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x003C426C File Offset: 0x003C266C
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

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x003C4278 File Offset: 0x003C2678
		// (set) Token: 0x06001AE2 RID: 6882 RVA: 0x003C428C File Offset: 0x003C268C
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

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x003C42D8 File Offset: 0x003C26D8
		// (set) Token: 0x06001AE4 RID: 6884 RVA: 0x003C42EC File Offset: 0x003C26EC
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

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x003C4338 File Offset: 0x003C2738
		// (set) Token: 0x06001AE6 RID: 6886 RVA: 0x003C434C File Offset: 0x003C274C
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

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x003C4398 File Offset: 0x003C2798
		// (set) Token: 0x06001AE8 RID: 6888 RVA: 0x003C43AC File Offset: 0x003C27AC
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

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x003C43F8 File Offset: 0x003C27F8
		// (set) Token: 0x06001AEA RID: 6890 RVA: 0x003C440C File Offset: 0x003C280C
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

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x003C4418 File Offset: 0x003C2818
		// (set) Token: 0x06001AEC RID: 6892 RVA: 0x003C442C File Offset: 0x003C282C
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

		// Token: 0x06001AED RID: 6893 RVA: 0x003C4438 File Offset: 0x003C2838
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Mensagem_MD101_cal("Aguarde ...", 2);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Leitura_pagina(1024, Mod_MD.Monitoracao_MD_RE.Estacao, 9);
			this.Mensagem_MD101_cal(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				return;
			}
			this.Atualiza_dados_tela_cal_MD101(1024);
			Comunicacao.Rotina_Delay(200L);
			ctrl_RESP_ = Mod_MD.Leitura_pagina(768, Mod_MD.Monitoracao_MD_RE.Estacao, 8);
			this.Mensagem_MD101_cal(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				return;
			}
			this.Atualiza_dados_tela_cal_MD101(768);
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x003C44DC File Offset: 0x003C28DC
		public void Mensagem_MD101_cal(string msg, int cor)
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

		// Token: 0x06001AEF RID: 6895 RVA: 0x003C4540 File Offset: 0x003C2940
		private void Tela_end_estacao_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RE.Estacao = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x003C4568 File Offset: 0x003C2968
		public void Atualiza_dados_tela_cal_MD101(int pagina)
		{
			checked
			{
				if (pagina == (DialogResult)768)
				{
					this.Valor_zero_1.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4]);
					this.Valor_zero_2.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6]);
					this.Valor_zero_3.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8]);
					this.Valor_zero_4.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10]);
					this.Valor_ganho_1.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12]);
					this.Valor_ganho_2.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14]);
					this.Valor_ganho_3.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[15] * 256 + (int)Comunicacao.Buffer_resp[16]);
					this.Valor_ganho_4.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[17] * 256 + (int)Comunicacao.Buffer_resp[18]);
				}
				else if (pagina == (DialogResult)1024)
				{
					this.Valor_nor_EA1.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4]);
					this.Valor_nor_EA2.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6]);
					this.Valor_nor_EA3.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8]);
					this.Valor_nor_EA4.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10]);
					int num = (int)Comunicacao.Buffer_resp[11] * 256 + (int)Comunicacao.Buffer_resp[12];
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
					this.Valor_sem_nor_EA1.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[13] * 256 + (int)Comunicacao.Buffer_resp[14]);
					this.Valor_sem_nor_EA2.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[15] * 256 + (int)Comunicacao.Buffer_resp[16]);
					this.Valor_sem_nor_EA3.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[17] * 256 + (int)Comunicacao.Buffer_resp[18]);
					this.Valor_sem_nor_EA4.Text = Conversions.ToString((int)Comunicacao.Buffer_resp[19] * 256 + (int)Comunicacao.Buffer_resp[20]);
				}
				else if (pagina == (DialogResult)1280)
				{
					this.Tela_nivel.Text = Strings.Format((double)((int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4]) / 40.0, "0.0");
					int num = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
					if ((num & 1) != 0)
					{
						this.Label_em_bat.BackColor = Color.Red;
					}
					else
					{
						this.Label_em_bat.BackColor = Color.Gainsboro;
					}
					if ((num & 4) != 0)
					{
						this.Label_transbordo.BackColor = Color.Red;
					}
					else
					{
						this.Label_transbordo.BackColor = Color.Gainsboro;
					}
					if ((num & 8) != 0)
					{
						this.Label_vazio.BackColor = Color.Red;
					}
					else
					{
						this.Label_vazio.BackColor = Color.Gainsboro;
					}
					if ((num & 16) != 0)
					{
						this.Label_defeito_sensor.BackColor = Color.Red;
					}
					else
					{
						this.Label_defeito_sensor.BackColor = Color.Gainsboro;
					}
					if ((num & 32) != 0)
					{
						this.Label_arrombamento.BackColor = Color.Red;
					}
					else
					{
						this.Label_arrombamento.BackColor = Color.Gainsboro;
					}
				}
			}
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x003C4A5C File Offset: 0x003C2E5C
		private void Comando_hab_cal_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			this.Comando_hab_cal.Enabled = false;
			this.Mensagem_MD101_cal("Aguarde ...", 2);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Leitura_pagina(768, Mod_MD.Monitoracao_MD_RE.Estacao, 8);
			this.Mensagem_MD101_cal(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Comando_hab_cal.Enabled = true;
				return;
			}
			this.Atualiza_dados_tela_cal_MD101(768);
			Comunicacao.Rotina_Delay(200L);
			ctrl_RESP_ = Mod_MD.Leitura_pagina(1024, Mod_MD.Monitoracao_MD_RE.Estacao, 9);
			this.Mensagem_MD101_cal(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Comando_hab_cal.Enabled = true;
				return;
			}
			this.Atualiza_dados_tela_cal_MD101(1024);
			Comunicacao.Rotina_Delay(200L);
			ctrl_RESP_ = Mod_MD.Leitura_pagina(1280, Mod_MD.Monitoracao_MD_RE.Estacao, 2);
			this.Mensagem_MD101_cal(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Comando_hab_cal.Enabled = true;
				return;
			}
			this.Atualiza_dados_tela_cal_MD101(1280);
			this.Comando_hab_cal.Enabled = true;
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x003C4BA0 File Offset: 0x003C2FA0
		private void Equip_101_cal_Load(object sender, EventArgs e)
		{
			Geral.Config_geral.Largura_tela_trabalho = this.Width;
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x003C4BB4 File Offset: 0x003C2FB4
		private void Button_3_5ma_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			this.Controle_tecla_101_cal(2);
			Mod_MD.Ctrl_cal.End_memoria = checked(767 + Mod_MD.Ctrl_cal.Canal);
			this.Mensagem_MD101_cal("Aguarde ...", 2);
			Mod_MD.Ctrl_cal.Dado = (HorizontalAlignment)21845;
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD101_cal(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_101_cal(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(768, 1);
			this.Mensagem_MD101_cal(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_101_cal(1);
				return;
			}
			this.Mensagem_MD101_cal("Calibração 3,5 mA executada com sucesso", 0);
			this.Controle_tecla_101_cal(1);
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x003C4C8C File Offset: 0x003C308C
		private void Button_20_5ma_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			this.Controle_tecla_101_cal(2);
			Mod_MD.Ctrl_cal.End_memoria = checked(783 + Mod_MD.Ctrl_cal.Canal);
			Mod_MD.Ctrl_cal.Dado = (HorizontalAlignment)21845;
			this.Mensagem_MD101_cal("Aguarde ...", 2);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Escrita_pagina(768, 1);
			this.Mensagem_MD101_cal(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_101_cal(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD101_cal(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_101_cal(1);
				return;
			}
			this.Mensagem_MD101_cal("Calibração executada com sucesso", 0);
			this.Controle_tecla_101_cal(1);
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x003C4D64 File Offset: 0x003C3164
		public void Controle_tecla_101_cal(int operacao)
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

		// Token: 0x06001AF6 RID: 6902 RVA: 0x003C4DDC File Offset: 0x003C31DC
		private void Valor_canal_calibracao_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Ctrl_cal.Canal = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x003C4E04 File Offset: 0x003C3204
		private void Valor_cal_end_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Ctrl_cal.End_equip = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x04001489 RID: 5257
		[AccessedThroughProperty("Grupo_ent_digitais")]
		private GroupBox _Grupo_ent_digitais;

		// Token: 0x0400148A RID: 5258
		[AccessedThroughProperty("CheckBox_ED8")]
		private CheckBox _CheckBox_ED8;

		// Token: 0x0400148B RID: 5259
		[AccessedThroughProperty("CheckBox_ED4")]
		private CheckBox _CheckBox_ED4;

		// Token: 0x0400148C RID: 5260
		[AccessedThroughProperty("CheckBox_ED7")]
		private CheckBox _CheckBox_ED7;

		// Token: 0x0400148D RID: 5261
		[AccessedThroughProperty("CheckBox_ED3")]
		private CheckBox _CheckBox_ED3;

		// Token: 0x0400148E RID: 5262
		[AccessedThroughProperty("CheckBox_ED6")]
		private CheckBox _CheckBox_ED6;

		// Token: 0x0400148F RID: 5263
		[AccessedThroughProperty("CheckBox_ED2")]
		private CheckBox _CheckBox_ED2;

		// Token: 0x04001490 RID: 5264
		[AccessedThroughProperty("CheckBox_ED5")]
		private CheckBox _CheckBox_ED5;

		// Token: 0x04001491 RID: 5265
		[AccessedThroughProperty("CheckBox_ED1")]
		private CheckBox _CheckBox_ED1;

		// Token: 0x04001492 RID: 5266
		[AccessedThroughProperty("Grupo_calibracao")]
		private GroupBox _Grupo_calibracao;

		// Token: 0x04001493 RID: 5267
		[AccessedThroughProperty("Valor_ganho_4")]
		private TextBox _Valor_ganho_4;

		// Token: 0x04001494 RID: 5268
		[AccessedThroughProperty("Valor_ganho_3")]
		private TextBox _Valor_ganho_3;

		// Token: 0x04001495 RID: 5269
		[AccessedThroughProperty("Valor_ganho_2")]
		private TextBox _Valor_ganho_2;

		// Token: 0x04001496 RID: 5270
		[AccessedThroughProperty("Valor_ganho_1")]
		private TextBox _Valor_ganho_1;

		// Token: 0x04001497 RID: 5271
		[AccessedThroughProperty("Valor_zero_4")]
		private TextBox _Valor_zero_4;

		// Token: 0x04001498 RID: 5272
		[AccessedThroughProperty("Valor_zero_3")]
		private TextBox _Valor_zero_3;

		// Token: 0x04001499 RID: 5273
		[AccessedThroughProperty("Valor_zero_2")]
		private TextBox _Valor_zero_2;

		// Token: 0x0400149A RID: 5274
		[AccessedThroughProperty("Valor_zero_1")]
		private TextBox _Valor_zero_1;

		// Token: 0x0400149B RID: 5275
		[AccessedThroughProperty("Label_ganho_4")]
		private Label _Label_ganho_4;

		// Token: 0x0400149C RID: 5276
		[AccessedThroughProperty("Label_ganho_3")]
		private Label _Label_ganho_3;

		// Token: 0x0400149D RID: 5277
		[AccessedThroughProperty("Label_zero_4")]
		private Label _Label_zero_4;

		// Token: 0x0400149E RID: 5278
		[AccessedThroughProperty("Label_ganho_2")]
		private Label _Label_ganho_2;

		// Token: 0x0400149F RID: 5279
		[AccessedThroughProperty("Label_zero_3")]
		private Label _Label_zero_3;

		// Token: 0x040014A0 RID: 5280
		[AccessedThroughProperty("Label_ganho_1")]
		private Label _Label_ganho_1;

		// Token: 0x040014A1 RID: 5281
		[AccessedThroughProperty("Label_zero_2")]
		private Label _Label_zero_2;

		// Token: 0x040014A2 RID: 5282
		[AccessedThroughProperty("Label_zero_1")]
		private Label _Label_zero_1;

		// Token: 0x040014A3 RID: 5283
		[AccessedThroughProperty("Grupo_cont_sem_nor")]
		private GroupBox _Grupo_cont_sem_nor;

		// Token: 0x040014A4 RID: 5284
		[AccessedThroughProperty("Valor_sem_nor_EA4")]
		private TextBox _Valor_sem_nor_EA4;

		// Token: 0x040014A5 RID: 5285
		[AccessedThroughProperty("Valor_sem_nor_EA3")]
		private TextBox _Valor_sem_nor_EA3;

		// Token: 0x040014A6 RID: 5286
		[AccessedThroughProperty("Valor_sem_nor_EA2")]
		private TextBox _Valor_sem_nor_EA2;

		// Token: 0x040014A7 RID: 5287
		[AccessedThroughProperty("Valor_sem_nor_EA1")]
		private TextBox _Valor_sem_nor_EA1;

		// Token: 0x040014A8 RID: 5288
		[AccessedThroughProperty("Label_sem_nor_EA4")]
		private Label _Label_sem_nor_EA4;

		// Token: 0x040014A9 RID: 5289
		[AccessedThroughProperty("Label_sem_nor_EA3")]
		private Label _Label_sem_nor_EA3;

		// Token: 0x040014AA RID: 5290
		[AccessedThroughProperty("Label_sem_nor_EA2")]
		private Label _Label_sem_nor_EA2;

		// Token: 0x040014AB RID: 5291
		[AccessedThroughProperty("Label_sem_nor_EA1")]
		private Label _Label_sem_nor_EA1;

		// Token: 0x040014AC RID: 5292
		[AccessedThroughProperty("Grupo_cont_normal")]
		private GroupBox _Grupo_cont_normal;

		// Token: 0x040014AD RID: 5293
		[AccessedThroughProperty("Valor_nor_EA4")]
		private TextBox _Valor_nor_EA4;

		// Token: 0x040014AE RID: 5294
		[AccessedThroughProperty("Valor_nor_EA3")]
		private TextBox _Valor_nor_EA3;

		// Token: 0x040014AF RID: 5295
		[AccessedThroughProperty("Valor_nor_EA2")]
		private TextBox _Valor_nor_EA2;

		// Token: 0x040014B0 RID: 5296
		[AccessedThroughProperty("Valor_nor_EA1")]
		private TextBox _Valor_nor_EA1;

		// Token: 0x040014B1 RID: 5297
		[AccessedThroughProperty("Label_nor_EA4")]
		private Label _Label_nor_EA4;

		// Token: 0x040014B2 RID: 5298
		[AccessedThroughProperty("Label_nor_EA3")]
		private Label _Label_nor_EA3;

		// Token: 0x040014B3 RID: 5299
		[AccessedThroughProperty("Label_nor_EA2")]
		private Label _Label_nor_EA2;

		// Token: 0x040014B4 RID: 5300
		[AccessedThroughProperty("Label_nor_EA1")]
		private Label _Label_nor_EA1;

		// Token: 0x040014B5 RID: 5301
		[AccessedThroughProperty("Box_Msg")]
		private TextBox _Box_Msg;

		// Token: 0x040014B6 RID: 5302
		[AccessedThroughProperty("Tela_end_estacao")]
		private NumericUpDown _Tela_end_estacao;

		// Token: 0x040014B7 RID: 5303
		[AccessedThroughProperty("Label_end_estacao")]
		private Label _Label_end_estacao;

		// Token: 0x040014B8 RID: 5304
		[AccessedThroughProperty("Grupo_medidas_eng")]
		private GroupBox _Grupo_medidas_eng;

		// Token: 0x040014B9 RID: 5305
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x040014BA RID: 5306
		[AccessedThroughProperty("Label_defeito_sensor")]
		private Label _Label_defeito_sensor;

		// Token: 0x040014BB RID: 5307
		[AccessedThroughProperty("Label_arrombamento")]
		private Label _Label_arrombamento;

		// Token: 0x040014BC RID: 5308
		[AccessedThroughProperty("Label_vazio")]
		private Label _Label_vazio;

		// Token: 0x040014BD RID: 5309
		[AccessedThroughProperty("Label_transbordo")]
		private Label _Label_transbordo;

		// Token: 0x040014BE RID: 5310
		[AccessedThroughProperty("Label_em_bat")]
		private Label _Label_em_bat;

		// Token: 0x040014BF RID: 5311
		[AccessedThroughProperty("Label_nivel_eng")]
		private Label _Label_nivel_eng;

		// Token: 0x040014C0 RID: 5312
		[AccessedThroughProperty("Tela_nivel")]
		private TextBox _Tela_nivel;

		// Token: 0x040014C1 RID: 5313
		[AccessedThroughProperty("Grupo_ctrl_com")]
		private GroupBox _Grupo_ctrl_com;

		// Token: 0x040014C2 RID: 5314
		[AccessedThroughProperty("Comando_hab_cal")]
		private Button _Comando_hab_cal;

		// Token: 0x040014C3 RID: 5315
		[AccessedThroughProperty("Grupo_controle_calibracao")]
		private GroupBox _Grupo_controle_calibracao;

		// Token: 0x040014C4 RID: 5316
		[AccessedThroughProperty("Button_20_5ma")]
		private Button _Button_20_5ma;

		// Token: 0x040014C5 RID: 5317
		[AccessedThroughProperty("Button_3_5ma")]
		private Button _Button_3_5ma;

		// Token: 0x040014C6 RID: 5318
		[AccessedThroughProperty("Valor_cal_end")]
		private NumericUpDown _Valor_cal_end;

		// Token: 0x040014C7 RID: 5319
		[AccessedThroughProperty("Valor_canal_calibracao")]
		private NumericUpDown _Valor_canal_calibracao;

		// Token: 0x040014C8 RID: 5320
		[AccessedThroughProperty("Label_end_cal")]
		private Label _Label_end_cal;

		// Token: 0x040014C9 RID: 5321
		[AccessedThroughProperty("Label_canal")]
		private Label _Label_canal;
	}
}
