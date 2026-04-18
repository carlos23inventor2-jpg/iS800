using System;
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
	// Token: 0x02000034 RID: 52
	public partial class RT_810_200_conf : Form
	{
		// Token: 0x0600041E RID: 1054 RVA: 0x0028D690 File Offset: 0x0028BA90
		public RT_810_200_conf()
		{
			base.Load += new EventHandler(this.RT_810_200_conf_Load);
			base.Activated += new EventHandler(this.RT_810_200_conf_Activated);
			base.FormClosed += new FormClosedEventHandler(this.RT_810_200_conf_FormClosed);
			this.InitializeComponent();
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00292464 File Offset: 0x00290864
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x00292478 File Offset: 0x00290878
		internal virtual TabControl TabControl_810
		{
			get
			{
				return this._TabControl_810;
			}
			[MethodImpl(32)]
			set
			{
				this._TabControl_810 = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00292484 File Offset: 0x00290884
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x00292498 File Offset: 0x00290898
		internal virtual TabPage TabPage_geral
		{
			get
			{
				return this._TabPage_geral;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TabPage_geral_Click);
				if (this._TabPage_geral != null)
				{
					this._TabPage_geral.Click -= eventHandler;
				}
				this._TabPage_geral = value;
				if (this._TabPage_geral != null)
				{
					this._TabPage_geral.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x002924E4 File Offset: 0x002908E4
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x002924F8 File Offset: 0x002908F8
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

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00292504 File Offset: 0x00290904
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x00292518 File Offset: 0x00290918
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

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00292524 File Offset: 0x00290924
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00292538 File Offset: 0x00290938
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

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00292544 File Offset: 0x00290944
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00292558 File Offset: 0x00290958
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

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00292564 File Offset: 0x00290964
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x00292578 File Offset: 0x00290978
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

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x00292584 File Offset: 0x00290984
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00292598 File Offset: 0x00290998
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

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x002925A4 File Offset: 0x002909A4
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x002925B8 File Offset: 0x002909B8
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

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x002925C4 File Offset: 0x002909C4
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x002925D8 File Offset: 0x002909D8
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

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x002925E4 File Offset: 0x002909E4
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x002925F8 File Offset: 0x002909F8
		internal virtual NumericUpDown NumericUpDown_temp_ptt
		{
			get
			{
				return this._NumericUpDown_temp_ptt;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_temp_ptt_ValueChanged);
				if (this._NumericUpDown_temp_ptt != null)
				{
					this._NumericUpDown_temp_ptt.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_temp_ptt = value;
				if (this._NumericUpDown_temp_ptt != null)
				{
					this._NumericUpDown_temp_ptt.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x00292644 File Offset: 0x00290A44
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00292658 File Offset: 0x00290A58
		internal virtual NumericUpDown NumericUpDown_end_mestre
		{
			get
			{
				return this._NumericUpDown_end_mestre;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_mestre_ValueChanged);
				EventHandler eventHandler2 = new EventHandler(this.NumericUpDown_end_mestre_Leave);
				if (this._NumericUpDown_end_mestre != null)
				{
					this._NumericUpDown_end_mestre.ValueChanged -= eventHandler;
					this._NumericUpDown_end_mestre.Leave -= eventHandler2;
				}
				this._NumericUpDown_end_mestre = value;
				if (this._NumericUpDown_end_mestre != null)
				{
					this._NumericUpDown_end_mestre.ValueChanged += eventHandler;
					this._NumericUpDown_end_mestre.Leave += eventHandler2;
				}
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x002926C8 File Offset: 0x00290AC8
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x002926DC File Offset: 0x00290ADC
		internal virtual NumericUpDown NumericUpDown_end_est
		{
			get
			{
				return this._NumericUpDown_end_est;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_est_ValueChanged);
				if (this._NumericUpDown_end_est != null)
				{
					this._NumericUpDown_end_est.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_est = value;
				if (this._NumericUpDown_end_est != null)
				{
					this._NumericUpDown_end_est.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00292728 File Offset: 0x00290B28
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x0029273C File Offset: 0x00290B3C
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

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00292748 File Offset: 0x00290B48
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x0029275C File Offset: 0x00290B5C
		internal virtual GroupBox GroupBox_parametros_repetidora
		{
			get
			{
				return this._GroupBox_parametros_repetidora;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_parametros_repetidora = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00292768 File Offset: 0x00290B68
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x0029277C File Offset: 0x00290B7C
		internal virtual NumericUpDown NumericUpDown_num_est_rep
		{
			get
			{
				return this._NumericUpDown_num_est_rep;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_num_est_rep_ValueChanged);
				if (this._NumericUpDown_num_est_rep != null)
				{
					this._NumericUpDown_num_est_rep.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_num_est_rep = value;
				if (this._NumericUpDown_num_est_rep != null)
				{
					this._NumericUpDown_num_est_rep.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x002927C8 File Offset: 0x00290BC8
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x002927DC File Offset: 0x00290BDC
		internal virtual NumericUpDown NumericUpDown_end_rep
		{
			get
			{
				return this._NumericUpDown_end_rep;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_rep_ValueChanged);
				if (this._NumericUpDown_end_rep != null)
				{
					this._NumericUpDown_end_rep.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_rep = value;
				if (this._NumericUpDown_end_rep != null)
				{
					this._NumericUpDown_end_rep.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00292828 File Offset: 0x00290C28
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x0029283C File Offset: 0x00290C3C
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

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00292848 File Offset: 0x00290C48
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x0029285C File Offset: 0x00290C5C
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

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00292868 File Offset: 0x00290C68
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x0029287C File Offset: 0x00290C7C
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

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00292888 File Offset: 0x00290C88
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x0029289C File Offset: 0x00290C9C
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

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x002928A8 File Offset: 0x00290CA8
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x002928BC File Offset: 0x00290CBC
		internal virtual GroupBox GroupBox_EA
		{
			get
			{
				return this._GroupBox_EA;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_EA = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x002928C8 File Offset: 0x00290CC8
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x002928DC File Offset: 0x00290CDC
		internal virtual NumericUpDown NumericUpDown_tamanho_filtro
		{
			get
			{
				return this._NumericUpDown_tamanho_filtro;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_tamanho_filtro_ValueChanged);
				if (this._NumericUpDown_tamanho_filtro != null)
				{
					this._NumericUpDown_tamanho_filtro.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_tamanho_filtro = value;
				if (this._NumericUpDown_tamanho_filtro != null)
				{
					this._NumericUpDown_tamanho_filtro.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00292928 File Offset: 0x00290D28
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x0029293C File Offset: 0x00290D3C
		internal virtual Label lb_Intervalo
		{
			get
			{
				return this._lb_Intervalo;
			}
			[MethodImpl(32)]
			set
			{
				this._lb_Intervalo = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00292948 File Offset: 0x00290D48
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x0029295C File Offset: 0x00290D5C
		internal virtual Label lb_Amostras
		{
			get
			{
				return this._lb_Amostras;
			}
			[MethodImpl(32)]
			set
			{
				this._lb_Amostras = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x00292968 File Offset: 0x00290D68
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x0029297C File Offset: 0x00290D7C
		internal virtual GroupBox GroupBox_end_rep
		{
			get
			{
				return this._GroupBox_end_rep;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_end_rep = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x00292988 File Offset: 0x00290D88
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x0029299C File Offset: 0x00290D9C
		internal virtual DataGridView DataGridView_end_rep_RT_810
		{
			get
			{
				return this._DataGridView_end_rep_RT_810;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_end_rep_RT_810_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_end_rep_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_end_rep_CellValueChanged);
				if (this._DataGridView_end_rep_RT_810 != null)
				{
					this._DataGridView_end_rep_RT_810.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_end_rep_RT_810.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_end_rep_RT_810.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_end_rep_RT_810 = value;
				if (this._DataGridView_end_rep_RT_810 != null)
				{
					this._DataGridView_end_rep_RT_810.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_end_rep_RT_810.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_end_rep_RT_810.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00292A34 File Offset: 0x00290E34
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00292A48 File Offset: 0x00290E48
		internal virtual DataGridViewTextBoxColumn Posicao_1_10
		{
			get
			{
				return this._Posicao_1_10;
			}
			[MethodImpl(32)]
			set
			{
				this._Posicao_1_10 = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00292A54 File Offset: 0x00290E54
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00292A68 File Offset: 0x00290E68
		internal virtual DataGridViewTextBoxColumn End_01_10
		{
			get
			{
				return this._End_01_10;
			}
			[MethodImpl(32)]
			set
			{
				this._End_01_10 = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00292A74 File Offset: 0x00290E74
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00292A88 File Offset: 0x00290E88
		internal virtual DataGridViewTextBoxColumn Posicao_11_20
		{
			get
			{
				return this._Posicao_11_20;
			}
			[MethodImpl(32)]
			set
			{
				this._Posicao_11_20 = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00292A94 File Offset: 0x00290E94
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00292AA8 File Offset: 0x00290EA8
		internal virtual DataGridViewTextBoxColumn End_11_20
		{
			get
			{
				return this._End_11_20;
			}
			[MethodImpl(32)]
			set
			{
				this._End_11_20 = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00292AB4 File Offset: 0x00290EB4
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x00292AC8 File Offset: 0x00290EC8
		internal virtual DataGridViewTextBoxColumn Posicao_21_30
		{
			get
			{
				return this._Posicao_21_30;
			}
			[MethodImpl(32)]
			set
			{
				this._Posicao_21_30 = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00292AD4 File Offset: 0x00290ED4
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00292AE8 File Offset: 0x00290EE8
		internal virtual DataGridViewTextBoxColumn End_21_30
		{
			get
			{
				return this._End_21_30;
			}
			[MethodImpl(32)]
			set
			{
				this._End_21_30 = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00292AF4 File Offset: 0x00290EF4
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x00292B08 File Offset: 0x00290F08
		internal virtual DataGridViewTextBoxColumn Posicao_31_40
		{
			get
			{
				return this._Posicao_31_40;
			}
			[MethodImpl(32)]
			set
			{
				this._Posicao_31_40 = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00292B14 File Offset: 0x00290F14
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00292B28 File Offset: 0x00290F28
		internal virtual DataGridViewTextBoxColumn End_31_40
		{
			get
			{
				return this._End_31_40;
			}
			[MethodImpl(32)]
			set
			{
				this._End_31_40 = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00292B34 File Offset: 0x00290F34
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00292B48 File Offset: 0x00290F48
		internal virtual DataGridViewTextBoxColumn Posicao_41_50
		{
			get
			{
				return this._Posicao_41_50;
			}
			[MethodImpl(32)]
			set
			{
				this._Posicao_41_50 = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00292B54 File Offset: 0x00290F54
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00292B68 File Offset: 0x00290F68
		internal virtual DataGridViewTextBoxColumn End_41_50
		{
			get
			{
				return this._End_41_50;
			}
			[MethodImpl(32)]
			set
			{
				this._End_41_50 = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00292B74 File Offset: 0x00290F74
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00292B88 File Offset: 0x00290F88
		internal virtual ToolStrip ToolStri_RT_810
		{
			get
			{
				return this._ToolStri_RT_810;
			}
			[MethodImpl(32)]
			set
			{
				ToolStripItemClickedEventHandler toolStripItemClickedEventHandler = new ToolStripItemClickedEventHandler(this.ToolStri_RT_810_ItemClicked);
				if (this._ToolStri_RT_810 != null)
				{
					this._ToolStri_RT_810.ItemClicked -= toolStripItemClickedEventHandler;
				}
				this._ToolStri_RT_810 = value;
				if (this._ToolStri_RT_810 != null)
				{
					this._ToolStri_RT_810.ItemClicked += toolStripItemClickedEventHandler;
				}
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00292BD4 File Offset: 0x00290FD4
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00292BE8 File Offset: 0x00290FE8
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

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00292BF4 File Offset: 0x00290FF4
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00292C08 File Offset: 0x00291008
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

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00292C14 File Offset: 0x00291014
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00292C28 File Offset: 0x00291028
		internal virtual ToolStripButton ToolStripButton_RT_810_Abrir
		{
			get
			{
				return this._ToolStripButton_RT_810_Abrir;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_810_Abrir_Click);
				if (this._ToolStripButton_RT_810_Abrir != null)
				{
					this._ToolStripButton_RT_810_Abrir.Click -= eventHandler;
				}
				this._ToolStripButton_RT_810_Abrir = value;
				if (this._ToolStripButton_RT_810_Abrir != null)
				{
					this._ToolStripButton_RT_810_Abrir.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00292C74 File Offset: 0x00291074
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00292C88 File Offset: 0x00291088
		internal virtual ToolStripButton ToolStripButton_RT_810_Salvar
		{
			get
			{
				return this._ToolStripButton_RT_810_Salvar;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_810_Salvar_Click);
				if (this._ToolStripButton_RT_810_Salvar != null)
				{
					this._ToolStripButton_RT_810_Salvar.Click -= eventHandler;
				}
				this._ToolStripButton_RT_810_Salvar = value;
				if (this._ToolStripButton_RT_810_Salvar != null)
				{
					this._ToolStripButton_RT_810_Salvar.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00292CD4 File Offset: 0x002910D4
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x00292CE8 File Offset: 0x002910E8
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

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00292CF4 File Offset: 0x002910F4
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00292D08 File Offset: 0x00291108
		internal virtual ToolStripButton ToolStripButton_RT_810_Download
		{
			get
			{
				return this._ToolStripButton_RT_810_Download;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_810_Download_Click);
				if (this._ToolStripButton_RT_810_Download != null)
				{
					this._ToolStripButton_RT_810_Download.Click -= eventHandler;
				}
				this._ToolStripButton_RT_810_Download = value;
				if (this._ToolStripButton_RT_810_Download != null)
				{
					this._ToolStripButton_RT_810_Download.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00292D54 File Offset: 0x00291154
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00292D68 File Offset: 0x00291168
		internal virtual ToolStripButton ToolStripButton_RT_810_Upload
		{
			get
			{
				return this._ToolStripButton_RT_810_Upload;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_810_Upload_Click);
				if (this._ToolStripButton_RT_810_Upload != null)
				{
					this._ToolStripButton_RT_810_Upload.Click -= eventHandler;
				}
				this._ToolStripButton_RT_810_Upload = value;
				if (this._ToolStripButton_RT_810_Upload != null)
				{
					this._ToolStripButton_RT_810_Upload.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00292DB4 File Offset: 0x002911B4
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00292DC8 File Offset: 0x002911C8
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

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00292DD4 File Offset: 0x002911D4
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00292DE8 File Offset: 0x002911E8
		internal virtual ToolStripProgressBar ToolStripProgressBar_RT_810
		{
			get
			{
				return this._ToolStripProgressBar_RT_810;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripProgressBar_RT_810 = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00292DF4 File Offset: 0x002911F4
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00292E08 File Offset: 0x00291208
		internal virtual ToolStripTextBox ToolStripTextBox_RT_810_Msg
		{
			get
			{
				return this._ToolStripTextBox_RT_810_Msg;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripTextBox_RT_810_Msg = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00292E14 File Offset: 0x00291214
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00292E28 File Offset: 0x00291228
		internal virtual ToolStripButton ToolStripButton_RT_810_novo
		{
			get
			{
				return this._ToolStripButton_RT_810_novo;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_810_novo_Click);
				if (this._ToolStripButton_RT_810_novo != null)
				{
					this._ToolStripButton_RT_810_novo.Click -= eventHandler;
				}
				this._ToolStripButton_RT_810_novo = value;
				if (this._ToolStripButton_RT_810_novo != null)
				{
					this._ToolStripButton_RT_810_novo.Click += eventHandler;
				}
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00292E74 File Offset: 0x00291274
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x00292E88 File Offset: 0x00291288
		internal virtual OpenFileDialog OpenFileDialog_RT_810
		{
			get
			{
				return this._OpenFileDialog_RT_810;
			}
			[MethodImpl(32)]
			set
			{
				this._OpenFileDialog_RT_810 = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00292E94 File Offset: 0x00291294
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00292EA8 File Offset: 0x002912A8
		internal virtual SaveFileDialog SaveFileDialog_RT_810
		{
			get
			{
				return this._SaveFileDialog_RT_810;
			}
			[MethodImpl(32)]
			set
			{
				this._SaveFileDialog_RT_810 = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00292EB4 File Offset: 0x002912B4
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00292EC8 File Offset: 0x002912C8
		internal virtual NumericUpDown NumericUpDown_intervalo_filtro
		{
			get
			{
				return this._NumericUpDown_intervalo_filtro;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_intervalo_filtro_ValueChanged);
				if (this._NumericUpDown_intervalo_filtro != null)
				{
					this._NumericUpDown_intervalo_filtro.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_intervalo_filtro = value;
				if (this._NumericUpDown_intervalo_filtro != null)
				{
					this._NumericUpDown_intervalo_filtro.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00292F14 File Offset: 0x00291314
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00292F28 File Offset: 0x00291328
		internal virtual Timer Timer_limpa_MSG
		{
			get
			{
				return this._Timer_limpa_MSG;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer_limpa_MSG_Tick);
				if (this._Timer_limpa_MSG != null)
				{
					this._Timer_limpa_MSG.Tick -= eventHandler;
				}
				this._Timer_limpa_MSG = value;
				if (this._Timer_limpa_MSG != null)
				{
					this._Timer_limpa_MSG.Tick += eventHandler;
				}
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00292F74 File Offset: 0x00291374
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00292F88 File Offset: 0x00291388
		internal virtual GroupBox GroupBox_ModoOperacao
		{
			get
			{
				return this._GroupBox_ModoOperacao;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_ModoOperacao = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00292F94 File Offset: 0x00291394
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00292FA8 File Offset: 0x002913A8
		internal virtual ComboBox ComboBox_Modo_Operacao
		{
			get
			{
				return this._ComboBox_Modo_Operacao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_metodo_operacao_SelectedIndexChanged);
				if (this._ComboBox_Modo_Operacao != null)
				{
					this._ComboBox_Modo_Operacao.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_Modo_Operacao = value;
				if (this._ComboBox_Modo_Operacao != null)
				{
					this._ComboBox_Modo_Operacao.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00292FF4 File Offset: 0x002913F4
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00293008 File Offset: 0x00291408
		internal virtual NumericUpDown NumericUpDown_intervalo_tx
		{
			get
			{
				return this._NumericUpDown_intervalo_tx;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_intervalo_tx_ValueChanged);
				if (this._NumericUpDown_intervalo_tx != null)
				{
					this._NumericUpDown_intervalo_tx.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_intervalo_tx = value;
				if (this._NumericUpDown_intervalo_tx != null)
				{
					this._NumericUpDown_intervalo_tx.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00293054 File Offset: 0x00291454
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00293068 File Offset: 0x00291468
		internal virtual Label lb_ModoOperacao
		{
			get
			{
				return this._lb_ModoOperacao;
			}
			[MethodImpl(32)]
			set
			{
				this._lb_ModoOperacao = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00293074 File Offset: 0x00291474
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00293088 File Offset: 0x00291488
		internal virtual Label lb_IntervaloTX
		{
			get
			{
				return this._lb_IntervaloTX;
			}
			[MethodImpl(32)]
			set
			{
				this._lb_IntervaloTX = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00293094 File Offset: 0x00291494
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x002930A8 File Offset: 0x002914A8
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

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x002930B4 File Offset: 0x002914B4
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x002930C8 File Offset: 0x002914C8
		internal virtual GroupBox GroupBox_ED
		{
			get
			{
				return this._GroupBox_ED;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_ED = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x002930D4 File Offset: 0x002914D4
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x002930E8 File Offset: 0x002914E8
		internal virtual GroupBox GroupBox_descricao_RT810
		{
			get
			{
				return this._GroupBox_descricao_RT810;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_descricao_RT810 = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x002930F4 File Offset: 0x002914F4
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00293108 File Offset: 0x00291508
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

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00293114 File Offset: 0x00291514
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00293128 File Offset: 0x00291528
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

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00293134 File Offset: 0x00291534
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00293148 File Offset: 0x00291548
		internal virtual TextBox TextBox_comentarios_RT810
		{
			get
			{
				return this._TextBox_comentarios_RT810;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox_comentarios_RT810_TextChanged);
				if (this._TextBox_comentarios_RT810 != null)
				{
					this._TextBox_comentarios_RT810.TextChanged -= eventHandler;
				}
				this._TextBox_comentarios_RT810 = value;
				if (this._TextBox_comentarios_RT810 != null)
				{
					this._TextBox_comentarios_RT810.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00293194 File Offset: 0x00291594
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x002931A8 File Offset: 0x002915A8
		internal virtual TextBox TextBox_endereco_RT810
		{
			get
			{
				return this._TextBox_endereco_RT810;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_endereco_RT810 = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x002931B4 File Offset: 0x002915B4
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x002931C8 File Offset: 0x002915C8
		internal virtual TextBox TextBox_nome_RT810
		{
			get
			{
				return this._TextBox_nome_RT810;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_nome_RT810 = value;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x002931D4 File Offset: 0x002915D4
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x002931E8 File Offset: 0x002915E8
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

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x002931F4 File Offset: 0x002915F4
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00293208 File Offset: 0x00291608
		internal virtual ComboBox ComboBox_modo_repeticao_RT_810
		{
			get
			{
				return this._ComboBox_modo_repeticao_RT_810;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_modo_repeticao_RT_810_SelectedIndexChanged);
				if (this._ComboBox_modo_repeticao_RT_810 != null)
				{
					this._ComboBox_modo_repeticao_RT_810.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_modo_repeticao_RT_810 = value;
				if (this._ComboBox_modo_repeticao_RT_810 != null)
				{
					this._ComboBox_modo_repeticao_RT_810.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00293254 File Offset: 0x00291654
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00293268 File Offset: 0x00291668
		internal virtual Label Label_modo_rep_RT_810
		{
			get
			{
				return this._Label_modo_rep_RT_810;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_modo_rep_RT_810 = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00293274 File Offset: 0x00291674
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00293288 File Offset: 0x00291688
		internal virtual ToolStripButton ToolStripButton_RT_810_Imprimir
		{
			get
			{
				return this._ToolStripButton_RT_810_Imprimir;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_810_Imprimir_Click);
				if (this._ToolStripButton_RT_810_Imprimir != null)
				{
					this._ToolStripButton_RT_810_Imprimir.Click -= eventHandler;
				}
				this._ToolStripButton_RT_810_Imprimir = value;
				if (this._ToolStripButton_RT_810_Imprimir != null)
				{
					this._ToolStripButton_RT_810_Imprimir.Click += eventHandler;
				}
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x002932D4 File Offset: 0x002916D4
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x002932E8 File Offset: 0x002916E8
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

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x002932F4 File Offset: 0x002916F4
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x00293308 File Offset: 0x00291708
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

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x002933A0 File Offset: 0x002917A0
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x002933B4 File Offset: 0x002917B4
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

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x002933C0 File Offset: 0x002917C0
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x002933D4 File Offset: 0x002917D4
		internal virtual TabPage TabPage_dadosinstalacao
		{
			get
			{
				return this._TabPage_dadosinstalacao;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_dadosinstalacao = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x002933E0 File Offset: 0x002917E0
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x002933F4 File Offset: 0x002917F4
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

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00293400 File Offset: 0x00291800
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00293414 File Offset: 0x00291814
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

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00293420 File Offset: 0x00291820
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00293434 File Offset: 0x00291834
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

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00293440 File Offset: 0x00291840
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00293454 File Offset: 0x00291854
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

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00293460 File Offset: 0x00291860
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x00293474 File Offset: 0x00291874
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

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00293480 File Offset: 0x00291880
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00293494 File Offset: 0x00291894
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

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x002934A0 File Offset: 0x002918A0
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x002934B4 File Offset: 0x002918B4
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

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x002934C0 File Offset: 0x002918C0
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x002934D4 File Offset: 0x002918D4
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

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x002934E0 File Offset: 0x002918E0
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x002934F4 File Offset: 0x002918F4
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

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00293500 File Offset: 0x00291900
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00293514 File Offset: 0x00291914
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

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00293520 File Offset: 0x00291920
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00293534 File Offset: 0x00291934
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

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00293540 File Offset: 0x00291940
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x00293554 File Offset: 0x00291954
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

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00293560 File Offset: 0x00291960
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00293574 File Offset: 0x00291974
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

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00293580 File Offset: 0x00291980
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00293594 File Offset: 0x00291994
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

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x002935A0 File Offset: 0x002919A0
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x002935B4 File Offset: 0x002919B4
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

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x002935C0 File Offset: 0x002919C0
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x002935D4 File Offset: 0x002919D4
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

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x002935E0 File Offset: 0x002919E0
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x002935F4 File Offset: 0x002919F4
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

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00293600 File Offset: 0x00291A00
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00293614 File Offset: 0x00291A14
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

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00293620 File Offset: 0x00291A20
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00293634 File Offset: 0x00291A34
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

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00293640 File Offset: 0x00291A40
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00293654 File Offset: 0x00291A54
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

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00293660 File Offset: 0x00291A60
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00293674 File Offset: 0x00291A74
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

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00293680 File Offset: 0x00291A80
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00293694 File Offset: 0x00291A94
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

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x002936A0 File Offset: 0x00291AA0
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x002936B4 File Offset: 0x00291AB4
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

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x002936C0 File Offset: 0x00291AC0
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x002936D4 File Offset: 0x00291AD4
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

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x002936E0 File Offset: 0x00291AE0
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x002936F4 File Offset: 0x00291AF4
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

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00293700 File Offset: 0x00291B00
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00293714 File Offset: 0x00291B14
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

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00293720 File Offset: 0x00291B20
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00293734 File Offset: 0x00291B34
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

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00293740 File Offset: 0x00291B40
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00293754 File Offset: 0x00291B54
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

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00293760 File Offset: 0x00291B60
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x00293774 File Offset: 0x00291B74
		internal virtual BindingSource RepetidoraBindingSource1
		{
			get
			{
				return this._RepetidoraBindingSource1;
			}
			[MethodImpl(32)]
			set
			{
				this._RepetidoraBindingSource1 = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00293780 File Offset: 0x00291B80
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00293794 File Offset: 0x00291B94
		internal virtual Label lb_EndEst
		{
			get
			{
				return this._lb_EndEst;
			}
			[MethodImpl(32)]
			set
			{
				this._lb_EndEst = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x002937A0 File Offset: 0x00291BA0
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x002937B4 File Offset: 0x00291BB4
		internal virtual Label lb_EndMestre
		{
			get
			{
				return this._lb_EndMestre;
			}
			[MethodImpl(32)]
			set
			{
				this._lb_EndMestre = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x002937C0 File Offset: 0x00291BC0
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x002937D4 File Offset: 0x00291BD4
		internal virtual Label lb_PTT
		{
			get
			{
				return this._lb_PTT;
			}
			[MethodImpl(32)]
			set
			{
				this._lb_PTT = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x002937E0 File Offset: 0x00291BE0
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x002937F4 File Offset: 0x00291BF4
		internal virtual ComboBox cb_ModoLeituraNivel
		{
			get
			{
				return this._cb_ModoLeituraNivel;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_ModoLeituraNivel_SelectedIndexChanged);
				if (this._cb_ModoLeituraNivel != null)
				{
					this._cb_ModoLeituraNivel.SelectedIndexChanged -= eventHandler;
				}
				this._cb_ModoLeituraNivel = value;
				if (this._cb_ModoLeituraNivel != null)
				{
					this._cb_ModoLeituraNivel.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00293840 File Offset: 0x00291C40
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00293854 File Offset: 0x00291C54
		internal virtual Label lb_RangeSensor
		{
			get
			{
				return this._lb_RangeSensor;
			}
			[MethodImpl(32)]
			set
			{
				this._lb_RangeSensor = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00293860 File Offset: 0x00291C60
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00293874 File Offset: 0x00291C74
		internal virtual Label lb_ErroOffsetSensor
		{
			get
			{
				return this._lb_ErroOffsetSensor;
			}
			[MethodImpl(32)]
			set
			{
				this._lb_ErroOffsetSensor = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00293880 File Offset: 0x00291C80
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00293894 File Offset: 0x00291C94
		internal virtual Label lb_AlturaReservatorio
		{
			get
			{
				return this._lb_AlturaReservatorio;
			}
			[MethodImpl(32)]
			set
			{
				this._lb_AlturaReservatorio = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x002938A0 File Offset: 0x00291CA0
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x002938B4 File Offset: 0x00291CB4
		internal virtual NumericUpDown NumericUpDown_errooffsetsensor
		{
			get
			{
				return this._NumericUpDown_errooffsetsensor;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_errooffsetsensor_ValueChanged);
				if (this._NumericUpDown_errooffsetsensor != null)
				{
					this._NumericUpDown_errooffsetsensor.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_errooffsetsensor = value;
				if (this._NumericUpDown_errooffsetsensor != null)
				{
					this._NumericUpDown_errooffsetsensor.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00293900 File Offset: 0x00291D00
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00293914 File Offset: 0x00291D14
		internal virtual NumericUpDown NumericUpDown_alturareservatorio
		{
			get
			{
				return this._NumericUpDown_alturareservatorio;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_alturareservatorio_ValueChanged);
				if (this._NumericUpDown_alturareservatorio != null)
				{
					this._NumericUpDown_alturareservatorio.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_alturareservatorio = value;
				if (this._NumericUpDown_alturareservatorio != null)
				{
					this._NumericUpDown_alturareservatorio.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x00293960 File Offset: 0x00291D60
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x00293974 File Offset: 0x00291D74
		internal virtual NumericUpDown NumericUpDown_rangesensor
		{
			get
			{
				return this._NumericUpDown_rangesensor;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_rangesensor_ValueChanged);
				if (this._NumericUpDown_rangesensor != null)
				{
					this._NumericUpDown_rangesensor.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_rangesensor = value;
				if (this._NumericUpDown_rangesensor != null)
				{
					this._NumericUpDown_rangesensor.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x002939C0 File Offset: 0x00291DC0
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x002939D4 File Offset: 0x00291DD4
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

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x002939E0 File Offset: 0x00291DE0
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x002939F4 File Offset: 0x00291DF4
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

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00293A00 File Offset: 0x00291E00
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00293A14 File Offset: 0x00291E14
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

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00293A20 File Offset: 0x00291E20
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x00293A34 File Offset: 0x00291E34
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

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00293A40 File Offset: 0x00291E40
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x00293A54 File Offset: 0x00291E54
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

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x00293A60 File Offset: 0x00291E60
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00293A74 File Offset: 0x00291E74
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

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00293A80 File Offset: 0x00291E80
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x00293A94 File Offset: 0x00291E94
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

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00293AA0 File Offset: 0x00291EA0
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x00293AB4 File Offset: 0x00291EB4
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

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00293AC0 File Offset: 0x00291EC0
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x00293AD4 File Offset: 0x00291ED4
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

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00293AE0 File Offset: 0x00291EE0
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x00293AF4 File Offset: 0x00291EF4
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

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00293B00 File Offset: 0x00291F00
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00293B14 File Offset: 0x00291F14
		internal virtual ToolStripLabel ToolStripLabel_ID
		{
			get
			{
				return this._ToolStripLabel_ID;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripLabel_ID = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00293B20 File Offset: 0x00291F20
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x00293B34 File Offset: 0x00291F34
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

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00293B40 File Offset: 0x00291F40
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00293B54 File Offset: 0x00291F54
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

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00293B60 File Offset: 0x00291F60
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00293B74 File Offset: 0x00291F74
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

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00293B80 File Offset: 0x00291F80
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00293B94 File Offset: 0x00291F94
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

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00293BA0 File Offset: 0x00291FA0
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00293BB4 File Offset: 0x00291FB4
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

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00293BC0 File Offset: 0x00291FC0
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00293BD4 File Offset: 0x00291FD4
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

		// Token: 0x06000525 RID: 1317 RVA: 0x00293BE0 File Offset: 0x00291FE0
		private void RT_810_200_conf_Load(object sender, EventArgs e)
		{
			RT_geral.Lmte_Init_ok = false;
			RT_geral.RT_810_200_BD.Tipo_nivel.valores = new int[3];
			RT_geral.RT_810_200_BD.Tipo_nivel.itens = new string[3];
			RT_geral.RT_810_200_BD.EA_Range = new RT_geral.Integer_ictel[2];
			RT_geral.RT_810_200_BD.EA_Inicio = new RT_geral.Integer_ictel[2];
			RT_geral.RT_810_200_BD.EA_Fim = new RT_geral.Integer_ictel[2];
			RT_geral.RT_810_200_BD.Repetidoras = new RT_geral.Integer_ictel[51];
			RT_geral.RT_810_200_BD.Modo_de_operacao.valores = new int[5];
			RT_geral.RT_810_200_BD.Modo_de_operacao.itens = new string[5];
			RT_geral.RT_810_200_BD.Hab_repetidora.valores = new int[4];
			RT_geral.RT_810_200_BD.Hab_repetidora.itens = new string[4];
			this.Inicializa_DadosEStruturaRT810_Padrao();
			RT_geral.Lmte_Init_ok = true;
			this.InicializaEstrutura_DataGridView_EA_RT_810();
			this.GeraDataGridView_EA_RT_810();
			this.InicializaEstrutura_DataGridView_repetidora_RT_810();
			this.GeraDataGridView_Repedidora_RT_810();
			ComboBox comboBox = this.ComboBox_Modo_Operacao;
			Linha_RT.CarregaCombo(ref comboBox, RT_geral.RT_810_200_BD.Modo_de_operacao);
			this.ComboBox_Modo_Operacao = comboBox;
			comboBox = this.ComboBox_modo_repeticao_RT_810;
			Linha_RT.CarregaCombo(ref comboBox, RT_geral.RT_810_200_BD.Hab_repetidora);
			this.ComboBox_modo_repeticao_RT_810 = comboBox;
			comboBox = this.cb_ModoLeituraNivel;
			Linha_RT.CarregaCombo(ref comboBox, RT_geral.RT_810_200_BD.Tipo_nivel);
			this.cb_ModoLeituraNivel = comboBox;
			this.Inicializa_DadosEStruturaRT810_Default();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			this.TabPage_geral.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
			this.TabPage_geral.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
			this.TabPage_EA.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
			this.TabPage_EA.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
			this.TabPage_ED.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
			this.TabPage_ED.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
			this.TabPage_repetidora.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
			this.TabPage_repetidora.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
			this.TabPage_dadosinstalacao.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
			this.TabPage_dadosinstalacao.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
			string text = ".\\\\Fontes\\\\Ictel Extendida Italic.ttf";
			if (MyProject.Computer.FileSystem.FileExists(text))
			{
				PrivateFontCollection privateFontCollection = new PrivateFontCollection();
				privateFontCollection.AddFontFile(text);
				Font font = new Font(privateFontCollection.Families[0], 8f, (System.Drawing.FontStyle)2);
				Font font2 = new Font(privateFontCollection.Families[0], 18f, (System.Drawing.FontStyle)2);
				this.Label26.Font = font;
				this.TextBox_equipamento.Font = font;
				this.TextBox_versao.Font = font;
				this.TextBox_build.Font = font;
				this.TextBox_release.Font = font;
				this.ToolStripLabel_ID.Font = font2;
			}
			else
			{
				MessageBox.Show("Removido fonte Ictel Extendida Italic da pasta da aplicação!");
			}
			this.Atualiza_TelaRT810();
			this.ToolStripLabel_ID.Text = RT_geral.MontaNomePlacaPeloFabricante(RT_geral.RT_810_200_BD.Equip.Valor, RT_geral.RT_810_200_BD.Versao.Valor);
			RT_geral.Lmte_Init_ok = true;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00293EDC File Offset: 0x002922DC
		private void RT_810_200_conf_Activated(object sender, EventArgs e)
		{
			Geral.Equipamento_selecionado = 810;
			Geral.Equipamento_versao = 2;
			Geral.Equipamento_build = 0;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00293EF4 File Offset: 0x002922F4
		private void GeraDataGridView_Processos_RT_810()
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00293EF8 File Offset: 0x002922F8
		private void InicializaEstrutura_DataGridView_Processos_RT_810()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_810_DataGrigViewProcessosColunas[num].LinhasMenu = new string[11];
					RT_geral.RT_810_DataGrigViewProcessosColunas[num].LinhasValor = new int[11];
					num++;
				}
				while (num <= 6);
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].TagColuna = "Acionamento";
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].TagColuna = "Retorno Acionamento";
				RT_geral.RT_810_DataGrigViewProcessosColunas[2].TagColuna = "Seleção Remoto";
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].TagColuna = "Seleção Reverso";
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].TagColuna = "Modo Controle";
				RT_geral.RT_810_DataGrigViewProcessosColunas[5].TagColuna = "Tempo Partida(s)";
				RT_geral.RT_810_DataGrigViewProcessosColunas[6].TagColuna = "Tempo Parada(s)";
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].NomeColuna = "SDAciona";
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].NomeColuna = "EDRetAci";
				RT_geral.RT_810_DataGrigViewProcessosColunas[2].NomeColuna = "EDRemoto";
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].NomeColuna = "Reverso";
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].NomeColuna = "ModoCtrl";
				RT_geral.RT_810_DataGrigViewProcessosColunas[5].NomeColuna = "TpMaxPart";
				RT_geral.RT_810_DataGrigViewProcessosColunas[6].NomeColuna = "TpMaxParada";
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].LarguraColuna = 100;
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].LarguraColuna = 100;
				RT_geral.RT_810_DataGrigViewProcessosColunas[2].LarguraColuna = 110;
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].LarguraColuna = 100;
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].LarguraColuna = 100;
				RT_geral.RT_810_DataGrigViewProcessosColunas[5].LarguraColuna = 60;
				RT_geral.RT_810_DataGrigViewProcessosColunas[6].LarguraColuna = 60;
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_810_DataGrigViewProcessosColunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_810_DataGrigViewProcessosColunas[5].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_810_DataGrigViewProcessosColunas[6].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].NumeroLinhaMenu = 2;
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].LinhasMenu[0] = "Desativa";
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].LinhasMenu[1] = "SD - 01";
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].LinhasValor[1] = 21857;
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].NumeroLinhaMenu = 9;
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].LinhasMenu[0] = "Não usada";
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].LinhasValor[0] = 21856;
				RT_geral.RT_810_DataGrigViewProcessosColunas[2].NumeroLinhaMenu = 9;
				RT_geral.RT_810_DataGrigViewProcessosColunas[2].LinhasMenu[0] = "Sempre Remoto";
				RT_geral.RT_810_DataGrigViewProcessosColunas[2].LinhasValor[0] = 21856;
				num = 1;
				do
				{
					RT_geral.RT_810_DataGrigViewProcessosColunas[1].LinhasMenu[num] = "ED - " + Strings.Format(num, "0#");
					RT_geral.RT_810_DataGrigViewProcessosColunas[1].LinhasValor[num] = 21856 + num;
					RT_geral.RT_810_DataGrigViewProcessosColunas[2].LinhasMenu[num] = "ED - " + Strings.Format(num, "0#");
					RT_geral.RT_810_DataGrigViewProcessosColunas[2].LinhasValor[num] = 21856 + num;
					num++;
				}
				while (num <= 8);
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].NumeroLinhaMenu = 2;
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].LinhasMenu[0] = "Desabilitado";
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].LinhasMenu[1] = "Habilitado";
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].LinhasValor[0] = 21856;
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].LinhasValor[1] = 21857;
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].NumeroLinhaMenu = 2;
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].LinhasMenu[0] = "Telecomando";
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].LinhasMenu[1] = "Automático";
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].LinhasValor[0] = 21856;
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].LinhasValor[1] = 21857;
				RT_geral.RT_810_DataGrigViewProcessosColunas[5].NumeroLinhaMenu = 0;
				RT_geral.RT_810_DataGrigViewProcessosColunas[6].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x002943E0 File Offset: 0x002927E0
		private void GeraDataGridView_EA_RT_810()
		{
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x002943E4 File Offset: 0x002927E4
		private void InicializaEstrutura_DataGridView_EA_RT_810()
		{
			RT_geral.RT_810_200_DataGrigViewEAColunas[0].TagColuna = "Range";
			RT_geral.RT_810_200_DataGrigViewEAColunas[1].TagColuna = "Início";
			RT_geral.RT_810_200_DataGrigViewEAColunas[2].TagColuna = "Fim";
			RT_geral.RT_810_200_DataGrigViewEAColunas[0].NomeColuna = "range";
			RT_geral.RT_810_200_DataGrigViewEAColunas[1].NomeColuna = "ini";
			RT_geral.RT_810_200_DataGrigViewEAColunas[2].NomeColuna = "fim";
			RT_geral.RT_810_200_DataGrigViewEAColunas[0].LarguraColuna = 90;
			RT_geral.RT_810_200_DataGrigViewEAColunas[1].LarguraColuna = 90;
			RT_geral.RT_810_200_DataGrigViewEAColunas[2].LarguraColuna = 90;
			RT_geral.RT_810_200_DataGrigViewEAColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_810_200_DataGrigViewEAColunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_810_200_DataGrigViewEAColunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_810_200_DataGrigViewEAColunas[0].NumeroLinhaMenu = 0;
			RT_geral.RT_810_200_DataGrigViewEAColunas[1].NumeroLinhaMenu = 0;
			RT_geral.RT_810_200_DataGrigViewEAColunas[2].NumeroLinhaMenu = 0;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00294510 File Offset: 0x00292910
		private void GeraDataGridView_Repedidora_RT_810()
		{
			this.DataGridView_end_rep_RT_810.Columns.Clear();
			this.DataGridView_end_rep_RT_810.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			this.DataGridView_end_rep_RT_810.DefaultCellStyle.Alignment =(System.Windows.Forms.DataGridViewContentAlignment)64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_810_DataGrigViewRepetidoraColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_810_DataGrigViewRepetidoraColunas);
						this.DataGridView_end_rep_RT_810.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_810_DataGrigViewRepetidoraColunas);
						this.DataGridView_end_rep_RT_810.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 9);
				this.DataGridView_end_rep_RT_810.RowCount = 10;
				num = 0;
				do
				{
					this.DataGridView_end_rep_RT_810.Columns[num].ReadOnly = true;
					num++;
				}
				while (num <= 9);
				num = 0;
				do
				{
					this.DataGridView_end_rep_RT_810[0, num].Value = num + 1;
					this.DataGridView_end_rep_RT_810[2, num].Value = num + 11;
					this.DataGridView_end_rep_RT_810[4, num].Value = num + 21;
					this.DataGridView_end_rep_RT_810[6, num].Value = num + 31;
					this.DataGridView_end_rep_RT_810[8, num].Value = num + 41;
					num++;
				}
				while (num <= 9);
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00294674 File Offset: 0x00292A74
		private void InicializaEstrutura_DataGridView_repetidora_RT_810()
		{
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[0].TagColuna = "Posição";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[1].TagColuna = "Endereço";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[2].TagColuna = "Posição";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[3].TagColuna = "Endereço";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[4].TagColuna = "Posição";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[5].TagColuna = "Endereço";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[6].TagColuna = "Posição";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[7].TagColuna = "Endereço";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[8].TagColuna = "Posição";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[9].TagColuna = "Endereço";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[0].NomeColuna = "pos_1";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[1].NomeColuna = "End_01_10";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[2].NomeColuna = "pos_2";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[3].NomeColuna = "End_11_20";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[4].NomeColuna = "pos_3";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[5].NomeColuna = "End_21_30";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[6].NomeColuna = "pos_4";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[7].NomeColuna = "End_31_40";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[8].NomeColuna = "pos_5";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[9].NomeColuna = "End_41_50";
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[0].LarguraColuna = 50;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[1].LarguraColuna = 65;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[2].LarguraColuna = 50;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[3].LarguraColuna = 65;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[4].LarguraColuna = 50;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[5].LarguraColuna = 65;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[6].LarguraColuna = 50;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[7].LarguraColuna = 65;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[8].LarguraColuna = 50;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[9].LarguraColuna = 65;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[3].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[4].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[5].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[6].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[7].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[8].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[9].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00294994 File Offset: 0x00292D94
		private void GeraDataGridView_Setpoints_RT_810()
		{
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00294998 File Offset: 0x00292D98
		private void InicializaEstrutura_DataGridView_Setpoints_RT_810()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_810_DataGrigViewSetpointsColunas[num].LinhasMenu = new string[22];
					RT_geral.RT_810_DataGrigViewSetpointsColunas[num].LinhasValor = new int[22];
					num++;
				}
				while (num <= 5);
				RT_geral.RT_810_DataGrigViewSetpointsColunas[2].TagColuna = "Nível Alto";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[1].TagColuna = "Nível Baixo";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].TagColuna = "EA - Controle";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[2].NomeColuna = "Set_NAlto";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[1].NomeColuna = "Set_NBaixo";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].NomeColuna = "Set_Controle";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[2].LarguraColuna = 60;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[1].LarguraColuna = 60;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LarguraColuna = 160;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[2].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[1].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[1].NumeroLinhaMenu = 0;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[2].NumeroLinhaMenu = 0;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LinhasMenu[0] = "Controle Desabilitado";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].NumeroLinhaMenu = 9;
				num = 1;
				do
				{
					RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LinhasMenu[num] = "EA - " + Strings.Format(num, "0#");
					RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LinhasValor[num] = 21856 + num;
					num++;
				}
				while (num <= 4);
				num = 5;
				do
				{
					RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LinhasMenu[num] = "Valor Referência " + Strings.Format(num - 4, "#");
					RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LinhasValor[num] = 21868 + num;
					num++;
				}
				while (num <= 8);
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00294BCC File Offset: 0x00292FCC
		private void GeraDataGridView_ED_RT_810()
		{
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00294BD0 File Offset: 0x00292FD0
		private void InicializaEstrutura_DataGridView_ED_RT_810()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_810_DataGrigViewEDColunas[num].LinhasMenu = new string[10];
					RT_geral.RT_810_DataGrigViewEDColunas[num].LinhasValor = new int[10];
					num++;
				}
				while (num <= 0);
				RT_geral.RT_810_DataGrigViewEDColunas[0].TagColuna = "Entrada";
				RT_geral.RT_810_DataGrigViewEDColunas[0].NomeColuna = "Entrada";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LarguraColuna = 200;
				RT_geral.RT_810_DataGrigViewEDColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)32;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[1] = 21969;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[2] = 21970;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[3] = 21971;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[4] = 21972;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[5] = 21973;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[6] = 21974;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[0] = "Sem função";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[1] = "Verificação de arrombamento";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[2] = "Verificação de falta de fase";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[3] = "Verificação de alagamento";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[4] = "Verificação de horário de ponta";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[5] = "Verificação de transbordo";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[6] = "Verificação de operação em bateira";
				RT_geral.RT_810_DataGrigViewEDColunas[0].NumeroLinhaMenu = 7;
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00294DBC File Offset: 0x002931BC
		public void Inicializa_DadosEStruturaRT810_Padrao()
		{
			RT_geral.RT_810_200_BD.Versao.nome = "Versão";
			RT_geral.RT_810_200_BD.Versao.Padrao = 0;
			RT_geral.RT_810_200_BD.Build.nome = "Build";
			RT_geral.RT_810_200_BD.Build.Padrao = 0;
			RT_geral.RT_810_200_BD.Release.nome = "Release";
			RT_geral.RT_810_200_BD.Release.Padrao = 0;
			RT_geral.RT_810_200_BD.Equip.nome = "Tipo equipamento";
			RT_geral.RT_810_200_BD.Equip.Padrao = 810;
			RT_geral.RT_810_200_BD.End_estacao.nome = "Endereço Estação";
			RT_geral.RT_810_200_BD.End_estacao.Padrao = 1;
			RT_geral.RT_810_200_BD.End_estacao.Lmte_inf = 0;
			RT_geral.RT_810_200_BD.End_estacao.Lmte_sup = 200;
			RT_geral.RT_810_200_BD.End_mestre.nome = "Endereço Mestre";
			RT_geral.RT_810_200_BD.End_mestre.Padrao = 100;
			RT_geral.RT_810_200_BD.End_mestre.Lmte_inf = 1;
			RT_geral.RT_810_200_BD.End_mestre.Lmte_sup = 200;
			RT_geral.RT_810_200_BD.Tempo_ptt.nome = "Tempo PTT";
			RT_geral.RT_810_200_BD.Tempo_ptt.Padrao = 200;
			RT_geral.RT_810_200_BD.Tempo_ptt.Lmte_inf = 1;
			RT_geral.RT_810_200_BD.Tempo_ptt.Lmte_sup = 2000;
			RT_geral.RT_810_200_BD.Intervalo_tx_pto_pto.nome = "Intervalo Ponto à Ponto";
			RT_geral.RT_810_200_BD.Intervalo_tx_pto_pto.Padrao = 3;
			RT_geral.RT_810_200_BD.Intervalo_tx_pto_pto.Lmte_inf = 1;
			RT_geral.RT_810_200_BD.Intervalo_tx_pto_pto.Lmte_sup = 43200;
			RT_geral.RT_810_200_BD.Tipo_nivel.nome = "Leitura de Nível";
			RT_geral.RT_810_200_BD.Tipo_nivel.Numero_itens = 2;
			RT_geral.RT_810_200_BD.Tipo_nivel.valores[0] = 21872;
			RT_geral.RT_810_200_BD.Tipo_nivel.valores[1] = 21873;
			RT_geral.RT_810_200_BD.Tipo_nivel.itens[0] = "Leitura por Eletrodo (ED)";
			RT_geral.RT_810_200_BD.Tipo_nivel.itens[1] = "Leitura por Sensor (EA) 4-20mA";
			RT_geral.RT_810_200_BD.Tipo_nivel.Indice_padrao = 0;
			RT_geral.RT_810_200_BD.Modo_de_operacao.nome = "Modo Operação";
			RT_geral.RT_810_200_BD.Modo_de_operacao.Indice_padrao = 0;
			RT_geral.RT_810_200_BD.Modo_de_operacao.Numero_itens = 3;
			RT_geral.RT_810_200_BD.Modo_de_operacao.valores[0] = 21848;
			RT_geral.RT_810_200_BD.Modo_de_operacao.valores[1] = 21846;
			RT_geral.RT_810_200_BD.Modo_de_operacao.valores[2] = 21847;
			RT_geral.RT_810_200_BD.Modo_de_operacao.itens[0] = "Rede";
			RT_geral.RT_810_200_BD.Modo_de_operacao.itens[1] = "Ponto à ponto - COM1";
			RT_geral.RT_810_200_BD.Modo_de_operacao.itens[2] = "Ponto à ponto - COM2";
			RT_geral.RT_810_200_BD.RangeSensor.nome = "Range do Sensor";
			RT_geral.RT_810_200_BD.RangeSensor.Padrao = 1000;
			RT_geral.RT_810_200_BD.RangeSensor.Lmte_sup = 5000;
			RT_geral.RT_810_200_BD.RangeSensor.Lmte_inf = 0;
			RT_geral.RT_810_200_BD.AlturaReservatorio.nome = "Altura do Reservatório";
			RT_geral.RT_810_200_BD.AlturaReservatorio.Padrao = 1000;
			RT_geral.RT_810_200_BD.AlturaReservatorio.Lmte_sup = 5000;
			RT_geral.RT_810_200_BD.AlturaReservatorio.Lmte_inf = 0;
			RT_geral.RT_810_200_BD.ErroOffSet.nome = "Erro de Offset do Sensor";
			RT_geral.RT_810_200_BD.ErroOffSet.Padrao = 0;
			RT_geral.RT_810_200_BD.ErroOffSet.Lmte_sup = 4000;
			RT_geral.RT_810_200_BD.ErroOffSet.Lmte_inf = -4000;
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_810_200_BD.EA_Range[num].nome = "Range sensor " + Conversion.Str(num + 1);
					RT_geral.RT_810_200_BD.EA_Range[num].Padrao = 4000;
					RT_geral.RT_810_200_BD.EA_Range[num].Lmte_inf = 1;
					RT_geral.RT_810_200_BD.EA_Range[num].Lmte_sup = 65535;
					RT_geral.RT_810_200_BD.EA_Inicio[num].nome = "Início sensor " + Conversion.Str(num + 1);
					RT_geral.RT_810_200_BD.EA_Inicio[num].Padrao = 0;
					RT_geral.RT_810_200_BD.EA_Inicio[num].Lmte_inf = 0;
					RT_geral.RT_810_200_BD.EA_Inicio[num].Lmte_sup = 65536;
					RT_geral.RT_810_200_BD.EA_Fim[num].nome = "Fim sensor " + Conversion.Str(num + 1);
					RT_geral.RT_810_200_BD.EA_Fim[num].Padrao = 4000;
					RT_geral.RT_810_200_BD.EA_Fim[num].Lmte_inf = 1;
					RT_geral.RT_810_200_BD.EA_Fim[num].Lmte_sup = 65535;
					num++;
				}
				while (num <= 1);
				RT_geral.RT_810_200_BD.AD_Intervalo.nome = "Intervalo AD";
				RT_geral.RT_810_200_BD.AD_Intervalo.Padrao = 500;
				RT_geral.RT_810_200_BD.AD_Intervalo.Lmte_inf = 100;
				RT_geral.RT_810_200_BD.AD_Intervalo.Lmte_sup = 20000;
				RT_geral.RT_810_200_BD.AD_Tamanho_filtro.nome = "Tamanho Filtro AD";
				RT_geral.RT_810_200_BD.AD_Tamanho_filtro.Padrao = 3;
				RT_geral.RT_810_200_BD.AD_Tamanho_filtro.Lmte_inf = 1;
				RT_geral.RT_810_200_BD.AD_Tamanho_filtro.Lmte_sup = 10;
				RT_geral.RT_810_200_BD.Hab_repetidora.nome = "Modo Operação da repetidora";
				RT_geral.RT_810_200_BD.Hab_repetidora.Indice_padrao = 0;
				RT_geral.RT_810_200_BD.Hab_repetidora.Numero_itens = 3;
				RT_geral.RT_810_200_BD.Hab_repetidora.valores[0] = 0;
				RT_geral.RT_810_200_BD.Hab_repetidora.valores[1] = 21856;
				RT_geral.RT_810_200_BD.Hab_repetidora.valores[2] = 21857;
				RT_geral.RT_810_200_BD.Hab_repetidora.itens[0] = "Desabilitada";
				RT_geral.RT_810_200_BD.Hab_repetidora.itens[1] = "Direta";
				RT_geral.RT_810_200_BD.Hab_repetidora.itens[2] = "Cruzada";
				RT_geral.RT_810_200_BD.End_repetidora.nome = "Endereço Repetidora";
				RT_geral.RT_810_200_BD.End_repetidora.Padrao = 1;
				RT_geral.RT_810_200_BD.End_repetidora.Lmte_inf = 0;
				RT_geral.RT_810_200_BD.End_repetidora.Lmte_sup = 200;
				RT_geral.RT_810_200_BD.Num_repetidoras.nome = "Número de Repetidoras";
				RT_geral.RT_810_200_BD.Num_repetidoras.Padrao = 0;
				RT_geral.RT_810_200_BD.Num_repetidoras.Lmte_inf = 0;
				RT_geral.RT_810_200_BD.Num_repetidoras.Lmte_sup = 50;
				num = 0;
				do
				{
					RT_geral.RT_810_200_BD.Repetidoras[num].nome = "Endereço da Repetidora " + Conversion.Str(num + 1);
					RT_geral.RT_810_200_BD.Repetidoras[num].Padrao = 0;
					RT_geral.RT_810_200_BD.Repetidoras[num].Lmte_inf = 0;
					RT_geral.RT_810_200_BD.Repetidoras[num].Lmte_sup = 200;
					num++;
				}
				while (num <= 50);
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00295568 File Offset: 0x00293968
		public void Inicializa_DadosEStruturaRT810_Default()
		{
			RT_geral.RT_810_200_BD.Equip.Valor = RT_geral.RT_810_200_BD.Equip.Padrao;
			RT_geral.RT_810_200_BD.Versao.Valor = RT_geral.RT_810_200_BD.Versao.Padrao;
			RT_geral.RT_810_200_BD.Build.Valor = RT_geral.RT_810_200_BD.Build.Padrao;
			RT_geral.RT_810_200_BD.Release.Valor = RT_geral.RT_810_200_BD.Release.Padrao;
			RT_geral.RT_810_200_BD.End_estacao.Valor = RT_geral.RT_810_200_BD.End_estacao.Padrao;
			RT_geral.RT_810_200_BD.End_mestre.Valor = RT_geral.RT_810_200_BD.End_mestre.Padrao;
			RT_geral.RT_810_200_BD.Tempo_ptt.Valor = RT_geral.RT_810_200_BD.Tempo_ptt.Padrao;
			RT_geral.RT_810_200_BD.Intervalo_tx_pto_pto.Valor = RT_geral.RT_810_200_BD.Intervalo_tx_pto_pto.Padrao;
			RT_geral.RT_810_200_BD.Tipo_nivel.Indice = RT_geral.RT_810_200_BD.Tipo_nivel.Indice_padrao;
			RT_geral.RT_810_200_BD.Tipo_nivel.Valor = RT_geral.RT_810_200_BD.Tipo_nivel.valores[RT_geral.RT_810_200_BD.Tipo_nivel.Indice];
			RT_geral.RT_810_200_BD.Modo_de_operacao.Indice = RT_geral.RT_810_200_BD.Modo_de_operacao.Indice_padrao;
			RT_geral.RT_810_200_BD.Modo_de_operacao.Valor = RT_geral.RT_810_200_BD.Modo_de_operacao.valores[RT_geral.RT_810_200_BD.Modo_de_operacao.Indice];
			RT_geral.RT_810_200_BD.RangeSensor.Valor = RT_geral.RT_810_200_BD.RangeSensor.Padrao;
			RT_geral.RT_810_200_BD.AlturaReservatorio.Valor = RT_geral.RT_810_200_BD.AlturaReservatorio.Padrao;
			RT_geral.RT_810_200_BD.ErroOffSet.Valor = RT_geral.RT_810_200_BD.ErroOffSet.Padrao;
			this.TextBox_comentarios_RT810.Text = "";
			this.TextBox_nome_RT810.Text = "";
			this.TextBox_endereco_RT810.Text = "";
			RT_geral.RT_810_200_BD.AD_Intervalo.Valor = RT_geral.RT_810_200_BD.AD_Intervalo.Padrao;
			RT_geral.RT_810_200_BD.AD_Tamanho_filtro.Valor = RT_geral.RT_810_200_BD.AD_Tamanho_filtro.Padrao;
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_810_200_BD.EA_Range[num].Valor = RT_geral.RT_810_200_BD.EA_Range[num].Padrao;
					RT_geral.RT_810_200_BD.EA_Inicio[num].Valor = RT_geral.RT_810_200_BD.EA_Inicio[num].Padrao;
					RT_geral.RT_810_200_BD.EA_Fim[num].Valor = RT_geral.RT_810_200_BD.EA_Fim[num].Padrao;
					num++;
				}
				while (num <= 1);
				RT_geral.RT_810_200_BD.Hab_repetidora.Indice = RT_geral.RT_810_200_BD.Hab_repetidora.Indice_padrao;
				RT_geral.RT_810_200_BD.Hab_repetidora.Valor = RT_geral.RT_810_200_BD.Hab_repetidora.valores[RT_geral.RT_810_200_BD.Hab_repetidora.Indice];
				RT_geral.RT_810_200_BD.End_repetidora.Valor = RT_geral.RT_810_200_BD.End_repetidora.Padrao;
				RT_geral.RT_810_200_BD.Num_repetidoras.Valor = RT_geral.RT_810_200_BD.Num_repetidoras.Padrao;
				num = 0;
				do
				{
					RT_geral.RT_810_200_BD.Repetidoras[num].Valor = RT_geral.RT_810_200_BD.Repetidoras[num].Padrao;
					num++;
				}
				while (num <= 50);
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0029590C File Offset: 0x00293D0C
		public void Atualiza_TelaRT810()
		{
			checked
			{
				int num = 0;
				int num3 = 0;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					this.Libera_acoes();
					this.ComboBox_Modo_Operacao.SelectedIndex = RT_geral.RT_810_200_BD.Modo_de_operacao.Indice;
					this.TextBox_equipamento.Text = Conversions.ToString(RT_geral.RT_810_200_BD.Equip.Valor);
					this.TextBox_versao.Text = Conversions.ToString(RT_geral.RT_810_200_BD.Versao.Valor);
					this.TextBox_build.Text = Conversions.ToString(RT_geral.RT_810_200_BD.Build.Valor);
					this.TextBox_release.Text = Conversions.ToString(RT_geral.RT_810_200_BD.Release.Valor);
					this.NumericUpDown_end_est.Value = new decimal(RT_geral.RT_810_200_BD.End_estacao.Valor);
					this.NumericUpDown_end_mestre.Value = new decimal(RT_geral.RT_810_200_BD.End_mestre.Valor);
					this.NumericUpDown_temp_ptt.Value = new decimal(RT_geral.RT_810_200_BD.Tempo_ptt.Valor);
					this.NumericUpDown_intervalo_tx.Value = new decimal(RT_geral.RT_810_200_BD.Intervalo_tx_pto_pto.Valor);
					this.cb_ModoLeituraNivel.SelectedIndex = RT_geral.RT_810_200_BD.Tipo_nivel.Indice;
					this.NumericUpDown_rangesensor.Value = new decimal(RT_geral.RT_810_200_BD.RangeSensor.Valor);
					this.NumericUpDown_alturareservatorio.Value = new decimal(RT_geral.RT_810_200_BD.AlturaReservatorio.Valor);
					this.NumericUpDown_errooffsetsensor.Value = new decimal(RT_geral.RT_810_200_BD.ErroOffSet.Valor);
					this.NumericUpDown_intervalo_filtro.Value = new decimal(RT_geral.RT_810_200_BD.AD_Intervalo.Valor);
					this.NumericUpDown_tamanho_filtro.Value = new decimal(RT_geral.RT_810_200_BD.AD_Tamanho_filtro.Valor);
					this.ComboBox_modo_repeticao_RT_810.SelectedIndex = RT_geral.RT_810_200_BD.Hab_repetidora.Indice;
					this.NumericUpDown_end_rep.Value = new decimal(RT_geral.RT_810_200_BD.End_repetidora.Valor);
					this.NumericUpDown_num_est_rep.Value = new decimal(RT_geral.RT_810_200_BD.Num_repetidoras.Valor);
					int num2 = 0;
					do
					{
						this.DataGridView_end_rep_RT_810.Rows[num2].Cells[1].Value = RT_geral.RT_810_200_BD.Repetidoras[num2].Valor;
						this.DataGridView_end_rep_RT_810.Rows[num2].Cells[3].Value = RT_geral.RT_810_200_BD.Repetidoras[num2 + 10].Valor;
						this.DataGridView_end_rep_RT_810.Rows[num2].Cells[5].Value = RT_geral.RT_810_200_BD.Repetidoras[num2 + 20].Valor;
						this.DataGridView_end_rep_RT_810.Rows[num2].Cells[7].Value = RT_geral.RT_810_200_BD.Repetidoras[num2 + 30].Valor;
						this.DataGridView_end_rep_RT_810.Rows[num2].Cells[9].Value = RT_geral.RT_810_200_BD.Repetidoras[num2 + 40].Valor;
						num2++;
					}
					while (num2 <= 9);
					this.Habilita_Funcoes_de_Tela_RT_810(0);
					goto IL_3CE;
					IL_377:
					Interaction.MsgBox("Erro na atualização da tela!", MsgBoxStyle.Question, "Atenção - Erro de dados");
					goto IL_3CE;
					IL_38B:
					num3 = -1;
					throw new InvalidOperationException("Decompiler switch pattern not reconstructed.");
					IL_3A0:;
				}
				catch (Exception)
			{
				throw;
			}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_3CE:
				if (num3 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00295D0C File Offset: 0x0029410C
		public void Habilita_Funcoes_de_Tela_RT_810(int tipo)
		{
			this.GroupBox_comunicacao.Enabled = true;
			this.GroupBox_informacoes.Enabled = false;
			this.GroupBox_ModoOperacao.Enabled = false;
			this.GroupBox_sistema_leitura.Enabled = false;
			this.GroupBox_EA.Enabled = false;
			this.GroupBox_ED.Enabled = false;
			this.GroupBox_parametros_repetidora.Enabled = false;
			this.GroupBox_end_rep.Enabled = false;
			this.DataGridView_end_rep_RT_810.Visible = false;
			switch (tipo)
			{
			case 0:
				this.GroupBox_informacoes.Enabled = true;
				this.GroupBox_ModoOperacao.Enabled = true;
				this.GroupBox_sistema_leitura.Enabled = true;
				this.GroupBox_EA.Enabled = true;
				this.GroupBox_ED.Enabled = true;
				this.GroupBox_parametros_repetidora.Enabled = true;
				this.GroupBox_end_rep.Enabled = true;
				this.DataGridView_end_rep_RT_810.Visible = true;
				break;
			}
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00295DFC File Offset: 0x002941FC
		public void RT_810_Atualiza_Parametros_EA(int tipo)
		{
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00295E00 File Offset: 0x00294200
		public void RT_810_Habilita_Pto_a_Pto(int modo)
		{
			if (modo == 0)
			{
				this.lb_IntervaloTX.Enabled = false;
				this.NumericUpDown_intervalo_tx.Enabled = false;
			}
			else
			{
				this.lb_IntervaloTX.Enabled = true;
				this.NumericUpDown_intervalo_tx.Enabled = true;
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00295E38 File Offset: 0x00294238
		public void AtualizaMsgTela_RT_810(string texto, int cor)
		{
			this.ToolStripTextBox_RT_810_Msg.Text = texto;
			if (cor == 0)
			{
				this.ToolStripTextBox_RT_810_Msg.ForeColor = Color.Blue;
			}
			else if (cor == 1)
			{
				this.ToolStripProgressBar_RT_810.Value = 0;
				this.ToolStripTextBox_RT_810_Msg.ForeColor = Color.Red;
			}
			else
			{
				this.ToolStripTextBox_RT_810_Msg.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00295E9C File Offset: 0x0029429C
		public void EncerraEdicaoDeCampos()
		{
			this.DataGridView_end_rep_RT_810.EndEdit();
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00295EAC File Offset: 0x002942AC
		public void Bloqueia_acoes()
		{
			this.ToolStripButton_RT_810_Abrir.Enabled = false;
			this.ToolStripButton_RT_810_novo.Enabled = false;
			this.ToolStripButton_RT_810_Salvar.Enabled = false;
			this.ToolStripButton_RT_810_Download.Enabled = false;
			this.ToolStripButton_RT_810_Upload.Enabled = false;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00295EEC File Offset: 0x002942EC
		public void Libera_acoes()
		{
			this.ToolStripButton_RT_810_Abrir.Enabled = true;
			this.ToolStripButton_RT_810_novo.Enabled = true;
			this.ToolStripButton_RT_810_Salvar.Enabled = true;
			if (Geral.Config_geral.Porta_serial_Ok)
			{
				this.ToolStripButton_RT_810_Download.Enabled = true;
				this.ToolStripButton_RT_810_Upload.Enabled = true;
			}
			else
			{
				this.ToolStripButton_RT_810_Download.Enabled = false;
				this.ToolStripButton_RT_810_Upload.Enabled = false;
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00295F5C File Offset: 0x0029435C
		public void InicializaBarraProgressoTela_RT_810(int num_passos)
		{
			this.ToolStripProgressBar_RT_810.Minimum = 0;
			this.ToolStripProgressBar_RT_810.Maximum = checked(num_passos * 4);
			this.ToolStripProgressBar_RT_810.Step = num_passos;
			this.ToolStripProgressBar_RT_810.Value = 0;
			this.ToolStripProgressBar_RT_810.BackColor = Color.LightGray;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00295FAC File Offset: 0x002943AC
		private void Timer_limpa_MSG_Tick(object sender, EventArgs e)
		{
			this.Timer_limpa_MSG.Enabled = false;
			this.AtualizaMsgTela_RT_810("", 0);
			this.ToolStripProgressBar_RT_810.Value = 0;
			this.Libera_acoes();
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00295FD8 File Offset: 0x002943D8
		private void CheckBox_hab_eletrodos_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00295FDC File Offset: 0x002943DC
		private void ComboBox_metodo_operacao_Validating(object sender, CancelEventArgs e)
		{
			if (this.ComboBox_Modo_Operacao.FindStringExact(this.ComboBox_Modo_Operacao.Text) == -1)
			{
				Interaction.MsgBox("Opção digitada não existe!\r\nAssumindo Default!", MsgBoxStyle.Question, "Atenção - Método Operação");
				this.ComboBox_Modo_Operacao.SelectedIndex = 0;
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00296018 File Offset: 0x00294418
		private void ComboBox_metodo_operacao_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_200_BD.Modo_de_operacao.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_810_200_BD.Modo_de_operacao.Valor = RT_geral.RT_810_200_BD.Modo_de_operacao.valores[RT_geral.RT_810_200_BD.Modo_de_operacao.Indice];
			this.RT_810_Habilita_Pto_a_Pto(RT_geral.RT_810_200_BD.Modo_de_operacao.Indice);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00296094 File Offset: 0x00294494
		private void ComboBox_modo_repeticao_RT_810_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_200_BD.Hab_repetidora.Valor = RT_geral.RT_810_200_BD.Hab_repetidora.valores[Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null))];
			object obj = NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(obj, 0, false))
			{
				this.GroupBox_end_rep.Visible = false;
				this.DataGridView_end_rep_RT_810.Visible = false;
				this.NumericUpDown_end_rep.Enabled = false;
				this.NumericUpDown_num_est_rep.Enabled = false;
			}
			else if (Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(obj, 1, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(obj, 2, false))) ? true : false))
			{
				this.GroupBox_end_rep.Visible = true;
				this.DataGridView_end_rep_RT_810.Visible = true;
				this.NumericUpDown_end_rep.Enabled = true;
				this.NumericUpDown_num_est_rep.Enabled = true;
			}
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x002961A0 File Offset: 0x002945A0
		private void ComboBox_modo_simulado_810_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.Habilita_Funcoes_de_Tela_RT_810(Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null)));
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x002961C4 File Offset: 0x002945C4
		private void ComboBox_RT810_ED_Validating(object sender, CancelEventArgs e)
		{
			Type type = null;
			string text = "FindStringExact";
			object[] array = new object[]
			{
				RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null))
			};
			object[] array2 = array;
			string[] array3 = null;
			Type[] array4 = null;
			bool[] array5 = new bool[]
			{
				true
			};
			object obj = NewLateBinding.LateGet(sender, type, text, array2, array3, array4, array5);
			if (array5[0])
			{
				NewLateBinding.LateSetComplex(sender, null, "Text", new object[]
				{
					RuntimeHelpers.GetObjectValue(array[0])
				}, null, null, true, false);
			}
			if (Operators.ConditionalCompareObjectEqual(obj, -1, false))
			{
				Interaction.MsgBox("Opção digitada não existe!\r\nAssumindo Default!", MsgBoxStyle.Question, "Atenção - Entrada digital " + Conversion.Str(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "ValueMember", new object[0], null, null, null))));
				NewLateBinding.LateSet(sender, null, "SelectedIndex", new object[]
				{
					0
				}, null, null);
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x002962A8 File Offset: 0x002946A8
		private void NumericUpDown_intervalo_tx_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_200_BD.Intervalo_tx_pto_pto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_200_BD.Intervalo_tx_pto_pto, true);
			sender = numericUpDown;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x002962FC File Offset: 0x002946FC
		private void NumericUpDown_temp_ptt_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_200_BD.Tempo_ptt.Valor = Conversions.ToInteger(Operators.MultiplyObject(Operators.IntDivideObject(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null), 10), 10));
			NewLateBinding.LateSet(sender, null, "Value", new object[]
			{
				RT_geral.RT_810_200_BD.Tempo_ptt.Valor
			}, null, null);
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_200_BD.Tempo_ptt, true);
			sender = numericUpDown;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00296394 File Offset: 0x00294794
		private void NumericUpDown_end_mestre_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_200_BD.End_mestre.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_200_BD.End_mestre, true);
			sender = numericUpDown;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x002963E8 File Offset: 0x002947E8
		private void NumericUpDown_end_est_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_200_BD.End_estacao.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_200_BD.End_estacao, true);
			sender = numericUpDown;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0029643C File Offset: 0x0029483C
		private void NumericUpDown_intervalo_filtro_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_200_BD.AD_Intervalo.Valor = Conversions.ToInteger(Operators.MultiplyObject(Operators.IntDivideObject(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null), 10), 10));
			NewLateBinding.LateSet(sender, null, "Value", new object[]
			{
				RT_geral.RT_810_200_BD.AD_Intervalo.Valor
			}, null, null);
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_200_BD.AD_Intervalo, true);
			sender = numericUpDown;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x002964D4 File Offset: 0x002948D4
		private void NumericUpDown_tamanho_filtro_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_200_BD.AD_Tamanho_filtro.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_200_BD.AD_Tamanho_filtro, true);
			sender = numericUpDown;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00296528 File Offset: 0x00294928
		private void NumericUpDown_end_rep_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_200_BD.End_repetidora.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_200_BD.End_repetidora, true);
			sender = numericUpDown;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0029657C File Offset: 0x0029497C
		private void NumericUpDown_num_est_rep_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_200_BD.Num_repetidoras.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_200_BD.Num_repetidoras, true);
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
						this.DataGridView_end_rep_RT_810.Rows[i].Cells[1].ReadOnly = false;
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
						this.DataGridView_end_rep_RT_810.Rows[i - 10].Cells[3].ReadOnly = false;
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
						this.DataGridView_end_rep_RT_810.Rows[i - 20].Cells[5].ReadOnly = false;
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
						this.DataGridView_end_rep_RT_810.Rows[i - 30].Cells[7].ReadOnly = false;
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
						this.DataGridView_end_rep_RT_810.Rows[i - 40].Cells[9].ReadOnly = false;
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
						this.DataGridView_end_rep_RT_810.Rows[i].Cells[1].ReadOnly = true;
						this.DataGridView_end_rep_RT_810.Rows[i].Cells[1].Value = 0;
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
						this.DataGridView_end_rep_RT_810.Rows[i - 10].Cells[3].ReadOnly = true;
						this.DataGridView_end_rep_RT_810.Rows[i - 10].Cells[3].Value = 0;
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
						this.DataGridView_end_rep_RT_810.Rows[i - 20].Cells[5].ReadOnly = true;
						this.DataGridView_end_rep_RT_810.Rows[i - 20].Cells[5].Value = 0;
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
						this.DataGridView_end_rep_RT_810.Rows[i - 30].Cells[7].ReadOnly = true;
						this.DataGridView_end_rep_RT_810.Rows[i - 30].Cells[7].Value = 0;
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
						this.DataGridView_end_rep_RT_810.Rows[i - 40].Cells[9].ReadOnly = true;
						this.DataGridView_end_rep_RT_810.Rows[i - 40].Cells[9].Value = 0;
						break;
					}
				}
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00296A28 File Offset: 0x00294E28
		private bool Entrada_Digital_Ja_Utilizada(int entrada, int num_ED)
		{
			int num = 0;
			checked
			{
				if (entrada != RT_geral.RT_810_BD.config_ED[num_ED].Indice_padrao)
				{
					int num2 = 0;
					do
					{
						if (entrada == RT_geral.RT_810_BD.config_ED[num2].Indice)
						{
							num++;
						}
						num2++;
					}
					while (num2 <= 7);
				}
				return num > 1;
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00296A80 File Offset: 0x00294E80
		private void RT_810_200_conf_FormClosed(object sender, FormClosedEventArgs e)
		{
			RT_geral.Telas_RT_810_200.Configuracao = false;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00296A90 File Offset: 0x00294E90
		private bool Endereco_Repetidora_Ja_Existente(ref DataGridView obj, ref RT_geral.Integer_ictel dado, DataGridViewCellValidatingEventArgs e, int posicao)
		{
			checked
			{
				if (dado.Valor != 0)
				{
					int num = 0;
					while (posicao == num || RT_geral.RT_810_200_BD.Repetidoras[num].Valor != dado.Valor)
					{
						num++;
						if (num > 49)
						{
							goto IL_A2;
						}
					}
					obj.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
					Interaction.MsgBox(Operators.AddObject(Operators.AddObject("Endereço : ", e.FormattedValue), " já existe"), (Microsoft.VisualBasic.MsgBoxStyle)32, "Erro na entrada de dados");
					dado.erro = true;
					return true;
				}
				IL_A2:
				obj.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
				dado.erro = false;
				return false;
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00296B7C File Offset: 0x00294F7C
		public void Leitura_RT_810_200_conf()
		{
			this.InicializaBarraProgressoTela_RT_810(3);
			this.AtualizaMsgTela_RT_810("Identificando equipamento - Passo 1", 2);
			if (!Mod_MD.Leitura_pagina(0, 255, 8).Status)
			{
				this.AtualizaMsgTela_RT_810("Equipamento não responde", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Linha_RT.VerificaSeEquipamentoEValido(2, 0, 0, 0, 0, "").Status)
			{
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_810_200(0);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 2", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Leitura_pagina(256, 255, 12).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_810_200(256);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 3", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Leitura_pagina(512, RT_geral.RT_810_200_BD.End_estacao.Valor, 52).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_810_200(512);
			this.ToolStripProgressBar_RT_810.PerformStep();
			this.Atualiza_TelaRT810();
			this.AtualizaMsgTela_RT_810("Configuração lida com sucesso", 0);
			this.ToolStripProgressBar_RT_810.PerformStep();
			this.Timer_limpa_MSG.Enabled = true;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00296CE0 File Offset: 0x002950E0
		public void Leitura_RT_810_conf()
		{
			this.InicializaBarraProgressoTela_RT_810(6);
			this.AtualizaMsgTela_RT_810("Identificando equipamento - Passo 1", 2);
			if (!Mod_MD.Leitura_pagina(0, 255, 12).Status)
			{
				this.AtualizaMsgTela_RT_810("Equipamento não responde", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Linha_RT.VerificaSeEquipamentoEValido(2, 0, 0, 0, 0, "").Status)
			{
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_810_200(0);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 2", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Leitura_pagina(2048, 255, 39).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_810_200(2048);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 3", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Leitura_pagina(4096, RT_geral.RT_810_BD.End_estacao.Valor, 52).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_810(4096);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 4", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Leitura_pagina(8192, RT_geral.RT_810_BD.End_estacao.Valor, 1).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_810_200(8192);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 5", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Leitura_pagina(10240, RT_geral.RT_810_BD.End_estacao.Valor, 2).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_810(10240);
			this.Atualiza_TelaRT810();
			this.AtualizaMsgTela_RT_810("Configuração lida com sucesso", 0);
			this.ToolStripProgressBar_RT_810.PerformStep();
			this.Timer_limpa_MSG.Enabled = true;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00296EF8 File Offset: 0x002952F8
		public void Gravar_RT_810_conf()
		{
			this.InicializaBarraProgressoTela_RT_810(5);
			this.AtualizaMsgTela_RT_810("Verificando equipamento - Passo 1", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Leitura_pagina(0, 255, 8).Status)
			{
				this.AtualizaMsgTela_RT_810("Equipamento não responde", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Linha_RT.VerificaSeEquipamentoEValido(2, 0, 0, 0, 0, "");
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_810(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_810_200(0);
			this.AtualizaMsgTela_RT_810("Habilitando gravação - Passo 2", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Controle_escrita(21845).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro ao habilitar gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_810("Gravando configuração - Passo 3", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Escrita_pagina(256, 20).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Controle_escrita(21930).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro durante a gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_810("Gravando configuração - Passo 4", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Controle_escrita(21845).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro ao habilitar gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Escrita_pagina(512, 20).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Mod_MD.Controle_escrita(21930).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro durante a gravação", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_810("Programação executada com sucesso", 0);
			this.ToolStripProgressBar_RT_810.PerformStep();
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00297100 File Offset: 0x00295500
		private void AtivaEfeitoOnChangeValue()
		{
			this.ToolStri_RT_810.Enabled = false;
			this.tb_lixo1.Focus();
			this.tb_lixo2.Focus();
			this.tb_lixo3.Focus();
			this.tb_lixo4.Focus();
			this.ToolStri_RT_810.Enabled = true;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00297158 File Offset: 0x00295558
		private void ToolStripButton_RT_810_Download_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.Bloqueia_acoes();
				this.EncerraEdicaoDeCampos();
				this.Leitura_RT_810_200_conf();
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", MsgBoxStyle.Critical, "Atenção");
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00297190 File Offset: 0x00295590
		private void ToolStripButton_RT_810_novo_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			RT_geral.Lmte_Init_ok = false;
			this.Inicializa_DadosEStruturaRT810_Padrao();
			this.Inicializa_DadosEStruturaRT810_Default();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			RT_geral.RT_810_200_BD.filename = "";
			this.Atualiza_TelaRT810();
			RT_geral.Lmte_Init_ok = true;
			this.AtualizaMsgTela_RT_810("Valores Default carregados", 0);
			this.Timer_limpa_MSG.Enabled = true;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x002971F8 File Offset: 0x002955F8
		private void ToolStripButton_RT_810_Upload_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.Bloqueia_acoes();
				this.EncerraEdicaoDeCampos();
				if (!RT_geral.VerificaExistenciaErroDados_RT810_200())
				{
					this.Gravar_RT_810_conf();
				}
				else
				{
					string text = "Existem parâmetros não compatíveis com o equipamento!\r\nGravação dos parâmetros foi cancelada.";
					Interaction.MsgBox(text, MsgBoxStyle.Critical, "Atenção - Valor fora das especificações");
					this.ToolStripButton_RT_810_Salvar.Enabled = true;
				}
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", MsgBoxStyle.Critical, "Atenção");
			}
			this.Timer_limpa_MSG.Enabled = true;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00297270 File Offset: 0x00295670
		private void ToolStripButton_RT_810_Abrir_Click(object sender, EventArgs e)
		{
			checked
			{
				int num = 0;
				int num4 = 0;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					this.AtivaEfeitoOnChangeValue();
					int[] array = new int[651];
					this.ToolStri_RT_810.Enabled = false;
					this.TextBox_equipamento.Focus();
					this.ToolStri_RT_810.Enabled = true;
					this.OpenFileDialog_RT_810.Filter = "Arquivo de configuração de equipamento|*.Cfg810_200";
					this.OpenFileDialog_RT_810.InitialDirectory = Linha_RT.diretorio;
					if (this.OpenFileDialog_RT_810.ShowDialog() == System.Windows.Forms.DialogResult.OK && Operators.CompareString(this.OpenFileDialog_RT_810.FileName, "", false) != 0)
					{
						Linha_RT.diretorio = Path.GetDirectoryName(this.OpenFileDialog_RT_810.FileName) + "\\";
						RT_geral.arquivo_extensao = Path.GetExtension(this.OpenFileDialog_RT_810.FileName);
						IniFile iniFile = new IniFile(this.OpenFileDialog_RT_810.FileName);
						RT_geral.RT_810_200_BD.filename = this.OpenFileDialog_RT_810.FileName;
						RT_geral.RT_810_200_BD.Equip.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "EQUIPAMENTO", 0);
						RT_geral.RT_810_200_BD.Versao.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "VERSAO", 0);
						RT_geral.RT_810_200_BD.Build.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "BUILD", 0);
						RT_geral.RT_810_200_BD.Release.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "RELEASE", 0);
						if (!Linha_RT.VerificaSeEquipamentoEValido(1, RT_geral.RT_810_200_BD.Equip.Valor, RT_geral.RT_810_200_BD.Versao.Valor, RT_geral.RT_810_200_BD.Build.Valor, RT_geral.RT_810_200_BD.Release.Valor, RT_geral.arquivo_extensao).Status)
						{
							RT_geral.Lmte_Init_ok = false;
							this.Inicializa_DadosEStruturaRT810_Padrao();
							this.Inicializa_DadosEStruturaRT810_Default();
							Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
							this.Atualiza_TelaRT810();
							RT_geral.Lmte_Init_ok = true;
							this.AtualizaMsgTela_RT_810("Valores Default carregados", 0);
							this.Timer_limpa_MSG.Enabled = true;
							goto IL_6F7;
						}
						RT_geral.RT_810_200_BD.End_estacao.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "ESTACAO", 0);
						RT_geral.RT_810_200_BD.End_mestre.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "MESTRE", 0);
						RT_geral.RT_810_200_BD.Tempo_ptt.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "TEMPO_PTT", 0);
						Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_810_200_BD.Modo_de_operacao, iniFile.ReadInteger("GERAL_MODO_OPERCAO", "MODO", 0));
						RT_geral.RT_810_200_BD.Intervalo_tx_pto_pto.Valor = iniFile.ReadInteger("GERAL_MODO_OPERCAO", "INTERVALO", 0);
						this.TextBox_nome_RT810.Text = iniFile.ReadText("GERAL_DESCRICAO", "NOME", "");
						this.TextBox_endereco_RT810.Text = iniFile.ReadText("GERAL_DESCRICAO", "ENDERECO", "");
						this.TextBox_comentarios_RT810.Text = iniFile.ReadText("GERAL_DESCRICAO", "COMENTARIO", "");
						Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_810_200_BD.Tipo_nivel, iniFile.ReadInteger("GERAL_DIVERSOS", "TIPO_NIVEL", 21872));
						RT_geral.RT_810_200_BD.AD_Intervalo.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "INTERVALO", RT_geral.RT_810_200_BD.AD_Intervalo.Padrao);
						RT_geral.RT_810_200_BD.AD_Tamanho_filtro.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "TAMANHO_FILTRO", RT_geral.RT_810_200_BD.AD_Tamanho_filtro.Padrao);
						RT_geral.RT_810_200_BD.RangeSensor.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "RANGE_SENSOR", RT_geral.RT_810_200_BD.RangeSensor.Padrao);
						RT_geral.RT_810_200_BD.AlturaReservatorio.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "ALTURA_RESERVATORIO", RT_geral.RT_810_200_BD.AlturaReservatorio.Padrao);
						decimal num2 = new decimal(iniFile.ReadInteger("ENTRADA_ANALOGICA", "ERRO_OFFSET", RT_geral.RT_810_200_BD.ErroOffSet.Padrao));
						if (decimal.Compare(num2, 4000m) > 0)
						{
							num2 = decimal.Add(decimal.Multiply(num2, -1m), 4000m);
						}
						num2 = decimal.Multiply(num2, new decimal(RT_geral.RT_810_200_BD.RangeSensor.Valor));
						num2 = decimal.Divide(num2, 4000m);
						RT_geral.RT_810_200_BD.ErroOffSet.Valor = Convert.ToInt32(num2);
						Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_810_200_BD.Hab_repetidora, iniFile.ReadInteger("REPETIDORA", "MODO_REPETIDORA", 0));
						RT_geral.RT_810_200_BD.End_repetidora.Valor = iniFile.ReadInteger("REPETIDORA", "ENDERECO", 0);
						RT_geral.RT_810_200_BD.Num_repetidoras.Valor = iniFile.ReadInteger("REPETIDORA", "NUMERO_REPETIDORAS", 0);
						int num3 = 0;
						do
						{
							string key = string.Format("RPT{0}", num3 + 1);
							RT_geral.RT_810_200_BD.Repetidoras[num3].Valor = iniFile.ReadInteger("REPETIDORA", key, 0);
							num3++;
						}
						while (num3 <= 49);
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
						this.Atualiza_TelaRT810();
						this.AtualizaMsgTela_RT_810("Arquivo carregado com sucesso!", 0);
					}
					this.Timer_limpa_MSG.Enabled = true;
					goto IL_6F7;
					IL_692:
					Interaction.MsgBox("Não foi possível carregar os dados", MsgBoxStyle.Question, "Atenção - Erro I/0");
					this.Timer_limpa_MSG.Enabled = true;
					goto IL_6F7;
					IL_6B2:
					num4 = -1;
					throw new InvalidOperationException("Decompiler switch pattern not reconstructed.");
					IL_6C8:;
				}
				catch (Exception)
			{
				throw;
			}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_6F7:
				if (num4 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0029799C File Offset: 0x00295D9C
		[MethodImpl(72)]
		private void ToolStripButton_RT_810_Salvar_Click(object sender, EventArgs e)
		{
			checked
			{
				int num = 0;
				int num5 = 0;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					this.AtivaEfeitoOnChangeValue();
					this.Bloqueia_acoes();
					this.SaveFileDialog_RT_810.Filter = "Arquivo de configuração de equipamento|*.Cfg810_200";
					this.SaveFileDialog_RT_810.InitialDirectory = Linha_RT.diretorio;
					if (this.SaveFileDialog_RT_810.ShowDialog() == System.Windows.Forms.DialogResult.OK && Operators.CompareString(this.SaveFileDialog_RT_810.FileName, "", false) != 0)
					{
						Linha_RT.diretorio = Path.GetDirectoryName(this.SaveFileDialog_RT_810.FileName) + "\\";
						if (File.Exists(this.SaveFileDialog_RT_810.FileName))
						{
							if (File.Exists(this.SaveFileDialog_RT_810.FileName + ".old"))
							{
								File.Delete(this.SaveFileDialog_RT_810.FileName + ".old");
							}
							File.Move(this.SaveFileDialog_RT_810.FileName, this.SaveFileDialog_RT_810.FileName + ".old");
						}
						RT_geral.RT_810_200_BD.filename = this.SaveFileDialog_RT_810.FileName;
						this.InicializaBarraProgressoTela_RT_810(8);
						IniFileWriteFast iniFileWriteFast = new IniFileWriteFast(this.SaveFileDialog_RT_810.FileName);
						iniFileWriteFast.WriteSection("GERAL_INFORMACAO");
						iniFileWriteFast.WriteKey("EQUIPAMENTO", RT_geral.RT_810_200_BD.Equip.Valor);
						iniFileWriteFast.WriteKey("VERSAO", RT_geral.RT_810_200_BD.Versao.Valor);
						iniFileWriteFast.WriteKey("BUILD", RT_geral.RT_810_200_BD.Build.Valor);
						iniFileWriteFast.WriteKey("RELEASE", RT_geral.RT_810_200_BD.Release.Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("GERAL_PARAM_COMINICACAO");
						iniFileWriteFast.WriteKey("ESTACAO", RT_geral.RT_810_200_BD.End_estacao.Valor);
						iniFileWriteFast.WriteKey("MESTRE", RT_geral.RT_810_200_BD.End_mestre.Valor);
						iniFileWriteFast.WriteKey("TEMPO_PTT", RT_geral.RT_810_200_BD.Tempo_ptt.Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("GERAL_MODO_OPERCAO");
						iniFileWriteFast.WriteKey("MODO", RT_geral.RT_810_200_BD.Modo_de_operacao.Valor);
						iniFileWriteFast.WriteKey("INTERVALO", RT_geral.RT_810_200_BD.Intervalo_tx_pto_pto.Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("GERAL_DESCRICAO");
						iniFileWriteFast.WriteKey("NOME", this.TextBox_nome_RT810.Text);
						iniFileWriteFast.WriteKey("ENDERECO", this.TextBox_endereco_RT810.Text);
						iniFileWriteFast.WriteKey("COMENTARIO", this.TextBox_comentarios_RT810.Text);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("GERAL_DIVERSOS");
						iniFileWriteFast.WriteKey("TIPO_NIVEL", RT_geral.RT_810_200_BD.Tipo_nivel.Valor);
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("ENTRADA_ANALOGICA");
						iniFileWriteFast.WriteKey("INTERVALO", RT_geral.RT_810_200_BD.AD_Intervalo.Valor);
						iniFileWriteFast.WriteKey("TAMANHO_FILTRO", RT_geral.RT_810_200_BD.AD_Tamanho_filtro.Valor);
						iniFileWriteFast.WriteKey("RANGE_SENSOR", RT_geral.RT_810_200_BD.RangeSensor.Valor);
						iniFileWriteFast.WriteKey("ALTURA_RESERVATORIO", RT_geral.RT_810_200_BD.AlturaReservatorio.Valor);
						decimal num2 = new decimal((double)RT_geral.RT_810_200_BD.ErroOffSet.Valor / (double)RT_geral.RT_810_200_BD.RangeSensor.Valor);
						num2 = decimal.Multiply(num2, 4000m);
						if (decimal.Compare(num2, 0m) < 0)
						{
							num2 = decimal.Multiply(num2, -1m);
							num2 = decimal.Add(num2, 4000m);
						}
						iniFileWriteFast.WriteKey("ERRO_OFFSET", Convert.ToInt32(num2));
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.WriteSection("REPETIDORA");
						iniFileWriteFast.WriteKey("MODO_REPETIDORA", RT_geral.RT_810_200_BD.Hab_repetidora.Valor);
						iniFileWriteFast.WriteKey("ENDERECO", RT_geral.RT_810_200_BD.End_repetidora.Valor);
						iniFileWriteFast.WriteKey("NUMERO_REPETIDORAS", RT_geral.RT_810_200_BD.Num_repetidoras.Valor);
						int num3 = 0;
						int num4 = RT_geral.RT_810_200_BD.Num_repetidoras.Valor - 1;
						for (int i = num3; i <= num4; i++)
						{
							string key = string.Format("RPT{0}", i + 1);
							iniFileWriteFast.WriteKey(key, RT_geral.RT_810_200_BD.Repetidoras[i].Valor);
						}
						iniFileWriteFast.LineSpace();
						this.ToolStripProgressBar_RT_810.PerformStep();
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
						this.ToolStripProgressBar_RT_810.PerformStep();
						Application.DoEvents();
						iniFileWriteFast.CloseIniFileWriteFast();
						this.AtualizaMsgTela_RT_810("Arquivo gerado com sucesso!", 0);
						this.Timer_limpa_MSG.Enabled = true;
					}
					this.Timer_limpa_MSG.Enabled = true;
					goto IL_67A;
					IL_601:
					Interaction.MsgBox("Não foi possível gravar os dados", MsgBoxStyle.Question, "Atenção - Erro I/0");
					FileSystem.FileClose(new int[]
					{
						1
					});
					this.Timer_limpa_MSG.Enabled = true;
					goto IL_67A;
					IL_635:
					num5 = -1;
					throw new InvalidOperationException("Decompiler switch pattern not reconstructed.");
					IL_64B:;
				}
				catch (Exception)
			{
				throw;
			}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_67A:
				if (num5 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00298048 File Offset: 0x00296448
		private void DataGridView_setpoints_810_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0029804C File Offset: 0x0029644C
		private void DataGridView_setpoints_810_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00298050 File Offset: 0x00296450
		private void DataGridView_setpoints_810_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00298054 File Offset: 0x00296454
		private void DataGridView_processo_810_P1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00298058 File Offset: 0x00296458
		private void DataGridView_processo_810_P1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0029805C File Offset: 0x0029645C
		private void DataGridView_processo_810_P1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00298060 File Offset: 0x00296460
		private void DataGridView_end_rep_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			string dataPropertyName = this.DataGridView_end_rep_RT_810.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_End_01_10", false) == 0)
				{
					int num = 0;
					this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_810_200_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_End_11_20", false) == 0)
				{
					int num = 10;
					this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_810_200_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[3].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_End_21_30", false) == 0)
				{
					int num = 20;
					this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_810_200_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[5].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_End_31_40", false) == 0)
				{
					int num = 30;
					this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[7].Value));
					RT_geral.RT_810_200_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[7].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_End_41_50", false) == 0)
				{
					int num = 40;
					this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[9].Value));
					RT_geral.RT_810_200_BD.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT_810.Rows[e.RowIndex].Cells[9].Value);
				}
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00298434 File Offset: 0x00296834
		private void DataGridView_end_rep_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_end_rep_RT_810.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_End_01_10", false) == 0)
				{
					int num = 0;
					RT_geral.RT_810_200_BD.Repetidoras[num + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_200_BD.Repetidoras[num + e.RowIndex], e, true);
					sender = dataGridView;
					dataGridView = (DataGridView)sender;
					this.Endereco_Repetidora_Ja_Existente(ref dataGridView, ref RT_geral.RT_810_200_BD.Repetidoras[num + e.RowIndex], e, num + e.RowIndex);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_End_11_20", false) == 0)
				{
					int num = 10;
					RT_geral.RT_810_200_BD.Repetidoras[num + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_200_BD.Repetidoras[num + e.RowIndex], e, true);
					sender = dataGridView;
					dataGridView = (DataGridView)sender;
					this.Endereco_Repetidora_Ja_Existente(ref dataGridView, ref RT_geral.RT_810_200_BD.Repetidoras[num + e.RowIndex], e, num + e.RowIndex);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_End_21_30", false) == 0)
				{
					int num = 20;
					RT_geral.RT_810_200_BD.Repetidoras[num + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_200_BD.Repetidoras[num + e.RowIndex], e, true);
					sender = dataGridView;
					dataGridView = (DataGridView)sender;
					this.Endereco_Repetidora_Ja_Existente(ref dataGridView, ref RT_geral.RT_810_200_BD.Repetidoras[num + e.RowIndex], e, num + e.RowIndex);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_End_31_40", false) == 0)
				{
					int num = 30;
					RT_geral.RT_810_200_BD.Repetidoras[num + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_200_BD.Repetidoras[num + e.RowIndex], e, true);
					sender = dataGridView;
					dataGridView = (DataGridView)sender;
					this.Endereco_Repetidora_Ja_Existente(ref dataGridView, ref RT_geral.RT_810_200_BD.Repetidoras[num + e.RowIndex], e, num + e.RowIndex);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_End_41_50", false) == 0)
				{
					int num = 40;
					RT_geral.RT_810_200_BD.Repetidoras[num + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_810_200_BD.Repetidoras[num + e.RowIndex], e, true);
					sender = dataGridView;
					dataGridView = (DataGridView)sender;
					this.Endereco_Repetidora_Ja_Existente(ref dataGridView, ref RT_geral.RT_810_200_BD.Repetidoras[num + e.RowIndex], e, num + e.RowIndex);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x002987AC File Offset: 0x00296BAC
		private void DataGridView_end_rep_RT_810_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_end_rep_RT_810.IsCurrentCellDirty)
			{
				this.DataGridView_end_rep_RT_810.CommitEdit((System.Windows.Forms.DataGridViewDataErrorContexts)512);
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x002987CC File Offset: 0x00296BCC
		private void DataGridView_parametros_EA_810_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x002987D0 File Offset: 0x00296BD0
		private void DataGridView_parametros_EA_810_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x002987D4 File Offset: 0x00296BD4
		private void DataGridView_parametros_EA_810_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x002987D8 File Offset: 0x00296BD8
		private void DataGridView_RT810_ED_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x002987DC File Offset: 0x00296BDC
		private void DataGridView_RT810_ED_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x002987E0 File Offset: 0x00296BE0
		private void ToolStripButton_RT_810_Imprimir_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			using (EnhancedPrintPreviewDialog enhancedPrintPreviewDialog = new EnhancedPrintPreviewDialog())
			{
				enhancedPrintPreviewDialog.Document = this.PrintDocument1;
				enhancedPrintPreviewDialog.ShowDialog();
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00298828 File Offset: 0x00296C28
		private void TextBox_comentarios_RT810_TextChanged(object sender, EventArgs e)
		{
			int num = this.TextBox_comentarios_RT810.Lines.Length;
			checked
			{
				if (num > 0)
				{
					int num2 = Strings.Len(this.TextBox_comentarios_RT810.Lines[num - 1]);
					if (num2 > 60)
					{
						this.TextBox_comentarios_RT810.Text = this.TextBox_comentarios_RT810.Text + "\r\n";
						this.TextBox_comentarios_RT810.Select(Strings.Len(this.TextBox_comentarios_RT810.Text), 0);
					}
				}
				int num3 = Strings.Len(this.TextBox_comentarios_RT810.Text) - Strings.Len(Strings.Replace(this.TextBox_comentarios_RT810.Text, "\r\n", "\r", 1, -1, 0));
				if (num3 > 7)
				{
					Interaction.MsgBox("Número máximo de linhas atingido", MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x002988E4 File Offset: 0x00296CE4
		[MethodImpl(72)]
		private void DesenhaRelatorioRT810(PrintPageEventArgs z)
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
			CoresTabela cores2;
			cores2.Titulo = Brushes.Black;
			cores2.Variavel = Brushes.Blue;
			cores2.Valor = Brushes.DarkGray;
			cores2.Tabela = Color.Black;
			cores2.TituloBG = Color.AliceBlue;
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_810_200_BD.Equip.Valor, RT_geral.RT_810_200_BD.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 4, "Dados da Estação", true);
			tabelaLinhaInteria.EscreveTituloValorLinha(1, "Local de Instalação", this.TextBox_nome_RT810.Text, 0, 160);
			tabelaLinhaInteria.EscreveTituloValorLinha(2, "Endereço", this.TextBox_endereco_RT810.Text, 0, 90);
			string valor = "iS800 (" + MyProject.Application.Info.Version.ToString() + ")";
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Configurador", valor, 240, 0);
			string valor2 = string.Concat(new string[]
			{
				"RT",
				RT_geral.RT_810_BD.Equip.Valor.ToString(),
				"_",
				RT_geral.RT_810_200_BD.Versao.Valor.ToString(),
				string.Format("{0:D2}", RT_geral.RT_810_200_BD.Build.Valor),
				"  R",
				RT_geral.RT_810_200_BD.Release.Valor.ToString()
			});
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Firmware", valor2, 0, 160);
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Data", string.Concat(new string[]
			{
				DateTime.Today.Day.ToString(),
				"/",
				DateTime.Today.Month.ToString(),
				"/",
				DateTime.Today.Year.ToString()
			}), 500, 0);
			tabelaLinhaInteria.EscreveTituloValorLinha(4, "Arquivo", Path.GetFileName(RT_geral.RT_810_200_BD.filename), 0, 0);
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
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(1, "Endereço do Mestre", this.NumericUpDown_end_mestre.Value.ToString(), 0, 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(2, "Endereço da Estação", this.NumericUpDown_end_est.Value.ToString(), 0, 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(3, "Tempo de PTT (ms)", this.NumericUpDown_temp_ptt.Value.ToString() + " ms", 0, 200);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 3, "Parâmetro de Operação", true);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(1, "Método de Operação", this.ComboBox_Modo_Operacao.Text, 0, 140);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(2, "Intervalo de TX Pto\\Pto(s)", this.NumericUpDown_intervalo_tx.Value.ToString() + " s", 0, 170);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(3, "Leitura de Nível", this.cb_ModoLeituraNivel.Text, 0, 230);
			nextLineAvailable = tabelaMeiaLinhaDireita.GetNextLineAvailable();
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 2, "Filtro EA", true);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(1, "Filtro Intervalo (ms)", this.NumericUpDown_intervalo_filtro.Value.ToString(), 0, 180);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(2, "Filtro Amostras", this.NumericUpDown_tamanho_filtro.Value.ToString(), 0, 180);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita2 = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores2, nextLineAvailable, 8, "Entrada Digital", true);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(1, "ED 01", "Eletrodo 20%", 0, 150);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(2, "ED 02", "Eletrodo 40%", 0, 150);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(3, "ED 03", "Eletrodo 60%", 0, 150);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(4, "ED 04", "Eletrodo 80%", 0, 150);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(5, "ED 05", "Eletrodo 100%", 0, 150);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(6, "ED 06", "Eletrodo Transbordo%", 0, 150);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(7, "ED 07", "Alarme Falta de Fase", 0, 150);
			tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(8, "ED 08", "Alarme Arrombamento", 0, 150);
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda3 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 28, 3, "Sensor", true);
			tabelaMeiaLinhaEsquerda3.EscreveTituloValorLinha(1, "Range", this.NumericUpDown_rangesensor.Value.ToString(), 0, 200);
			tabelaMeiaLinhaEsquerda3.EscreveTituloValorLinha(2, "Altura Reservatório", this.NumericUpDown_alturareservatorio.Value.ToString(), 0, 200);
			tabelaMeiaLinhaEsquerda3.EscreveTituloValorLinha(3, "Erro Offset", this.NumericUpDown_errooffsetsensor.Value.ToString(), 0, 200);
			nextLineAvailable = tabelaMeiaLinhaEsquerda3.GetNextLineAvailable();
			TabelaLinhaInteria tabelaLinhaInteria3 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 1, "Repetidora", true);
			tabelaLinhaInteria3.EscreveTituloValorLinha(1, "Modo", this.ComboBox_modo_repeticao_RT_810.Text, 0, 60);
			tabelaLinhaInteria3.EscreveTituloValorLinha(1, "End. Mestre", RT_geral.RT_810_200_BD.End_repetidora.Valor.ToString(), 240, 320);
			tabelaLinhaInteria3.EscreveTituloValorLinha(1, "Quantidade End. Repetidos", RT_geral.RT_810_200_BD.Num_repetidoras.Valor.ToString(), 410, 600);
			int num = RT_geral.RT_810_200_BD.Num_repetidoras.Valor / 20;
			checked
			{
				if (RT_geral.RT_810_200_BD.Num_repetidoras.Valor > 0)
				{
					if (RT_geral.RT_810_200_BD.Num_repetidoras.Valor % 20 != 0)
					{
						num++;
					}
					int num2 = 1;
					int num3 = Convert.ToInt32(num);
					for (int i = num2; i <= num3; i++)
					{
						tabelaLinhaInteria3.AdicionaLinha();
						string text = "";
						int num4 = (i - 1) * 20;
						int num5 = (i - 1) * 20 + 19;
						for (int j = num4; j <= num5; j++)
						{
							if (j + 1 < RT_geral.RT_810_200_BD.Num_repetidoras.Valor)
							{
								text = text + RT_geral.RT_810_200_BD.Repetidoras[j].Valor.ToString() + ", ";
							}
							else if (j + 1 == RT_geral.RT_810_200_BD.Num_repetidoras.Valor)
							{
								text += RT_geral.RT_810_200_BD.Repetidoras[j].Valor.ToString();
								break;
							}
						}
						tabelaLinhaInteria3.EscreveValorLinha(i + 1, text, 50);
					}
				}
				nextLineAvailable = tabelaLinhaInteria3.GetNextLineAvailable();
				TabelaLinhaInteria tabelaLinhaInteria4 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 4, "Observação", true);
				tabelaLinhaInteria4.EscreveValorLinha(1, this.TextBox_comentarios_RT810.Text, 0);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x002992E0 File Offset: 0x002976E0
		private bool DesenhaRelatorio(PrintPageEventArgs z)
		{
			Font font = new Font("Arial", 12f, (System.Drawing.FontStyle)3);
			Pen pen = new Pen(Color.Black, 2f);
			checked
			{
				switch (this.pagina_impressao)
				{
				case 1:
					this.DesenhaRelatorioRT810(z);
					this.pagina_impressao++;
					return false;
				case 2:
					z.Graphics.DrawString("PIMBA", font, Brushes.Red, 100f, 100f);
					this.pagina_impressao++;
					break;
				case 3:
					z.Graphics.DrawString("ZE", font, Brushes.Blue, 100f, 100f);
					this.pagina_impressao++;
					return false;
				}
				return false;
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x002993A4 File Offset: 0x002977A4
		private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
		{
			this.pagina_impressao = 1;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x002993B0 File Offset: 0x002977B0
		private void PrintDocument1_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
		{
			switch (this.pagina_impressao)
			{
			case 1:
				e.PageSettings.Landscape = false;
				break;
			case 2:
				e.PageSettings.Landscape = true;
				break;
			case 3:
				e.PageSettings.Landscape = true;
				break;
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00299400 File Offset: 0x00297800
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.HasMorePages = this.DesenhaRelatorio(e);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00299410 File Offset: 0x00297810
		private void TabPage_geral_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00299414 File Offset: 0x00297814
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00299418 File Offset: 0x00297818
		private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0029941C File Offset: 0x0029781C
		private void RepetidoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00299428 File Offset: 0x00297828
		private void ToolStri_RT_810_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0029942C File Offset: 0x0029782C
		private void NumericUpDown_rangesensor_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_200_BD.RangeSensor.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_200_BD.RangeSensor, true);
			sender = numericUpDown;
			this.NumericUpDown_errooffsetsensor.Minimum = Conversions.ToDecimal(Operators.MultiplyObject(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null), -1));
			this.NumericUpDown_errooffsetsensor.Maximum = Conversions.ToDecimal(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			RT_geral.RT_810_200_BD.ErroOffSet.Lmte_sup = Convert.ToInt32(this.NumericUpDown_errooffsetsensor.Maximum);
			RT_geral.RT_810_200_BD.ErroOffSet.Lmte_inf = Convert.ToInt32(this.NumericUpDown_errooffsetsensor.Minimum);
			decimal num = new decimal((double)RT_geral.RT_810_200_BD.ErroOffSet.Valor / (double)RT_geral.RT_810_200_BD.RangeSensor.Valor);
			num = decimal.Multiply(num, 4000m);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0029954C File Offset: 0x0029794C
		private void NumericUpDown_alturareservatorio_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_200_BD.AlturaReservatorio.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_200_BD.AlturaReservatorio, true);
			sender = numericUpDown;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x002995A0 File Offset: 0x002979A0
		private void NumericUpDown_errooffsetsensor_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_200_BD.ErroOffSet.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_810_200_BD.ErroOffSet, true);
			sender = numericUpDown;
			decimal num = new decimal((double)RT_geral.RT_810_200_BD.ErroOffSet.Valor / (double)RT_geral.RT_810_200_BD.RangeSensor.Valor);
			num = decimal.Multiply(num, 4000m);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0029962C File Offset: 0x00297A2C
		private void cb_ModoLeituraNivel_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_200_BD.Tipo_nivel.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_810_200_BD.Tipo_nivel.Valor = RT_geral.RT_810_200_BD.Tipo_nivel.valores[RT_geral.RT_810_200_BD.Tipo_nivel.Indice];
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00299690 File Offset: 0x00297A90
		private void NumericUpDown_end_mestre_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00299694 File Offset: 0x00297A94
		private void NumericUpDown_end_mestre_KeyUp(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00299698 File Offset: 0x00297A98
		private void Button1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0029969C File Offset: 0x00297A9C
		private void NumericUpDown_end_mestre_Leave(object sender, EventArgs e)
		{
			string text = Conversions.ToString(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
		}

		// Token: 0x0400048A RID: 1162
		[AccessedThroughProperty("TabControl_810")]
		private TabControl _TabControl_810;

		// Token: 0x0400048B RID: 1163
		[AccessedThroughProperty("TabPage_geral")]
		private TabPage _TabPage_geral;

		// Token: 0x0400048C RID: 1164
		[AccessedThroughProperty("GroupBox_informacoes")]
		private GroupBox _GroupBox_informacoes;

		// Token: 0x0400048D RID: 1165
		[AccessedThroughProperty("TextBox_release")]
		private TextBox _TextBox_release;

		// Token: 0x0400048E RID: 1166
		[AccessedThroughProperty("Label_release")]
		private Label _Label_release;

		// Token: 0x0400048F RID: 1167
		[AccessedThroughProperty("TextBox_build")]
		private TextBox _TextBox_build;

		// Token: 0x04000490 RID: 1168
		[AccessedThroughProperty("Label_build")]
		private Label _Label_build;

		// Token: 0x04000491 RID: 1169
		[AccessedThroughProperty("TextBox_versao")]
		private TextBox _TextBox_versao;

		// Token: 0x04000492 RID: 1170
		[AccessedThroughProperty("Label_versao")]
		private Label _Label_versao;

		// Token: 0x04000493 RID: 1171
		[AccessedThroughProperty("GroupBox_comunicacao")]
		private GroupBox _GroupBox_comunicacao;

		// Token: 0x04000494 RID: 1172
		[AccessedThroughProperty("NumericUpDown_temp_ptt")]
		private NumericUpDown _NumericUpDown_temp_ptt;

		// Token: 0x04000495 RID: 1173
		[AccessedThroughProperty("NumericUpDown_end_mestre")]
		private NumericUpDown _NumericUpDown_end_mestre;

		// Token: 0x04000496 RID: 1174
		[AccessedThroughProperty("NumericUpDown_end_est")]
		private NumericUpDown _NumericUpDown_end_est;

		// Token: 0x04000497 RID: 1175
		[AccessedThroughProperty("TabPage_repetidora")]
		private TabPage _TabPage_repetidora;

		// Token: 0x04000498 RID: 1176
		[AccessedThroughProperty("GroupBox_parametros_repetidora")]
		private GroupBox _GroupBox_parametros_repetidora;

		// Token: 0x04000499 RID: 1177
		[AccessedThroughProperty("NumericUpDown_num_est_rep")]
		private NumericUpDown _NumericUpDown_num_est_rep;

		// Token: 0x0400049A RID: 1178
		[AccessedThroughProperty("NumericUpDown_end_rep")]
		private NumericUpDown _NumericUpDown_end_rep;

		// Token: 0x0400049B RID: 1179
		[AccessedThroughProperty("Label_num_est_rep")]
		private Label _Label_num_est_rep;

		// Token: 0x0400049C RID: 1180
		[AccessedThroughProperty("Label_end_rep")]
		private Label _Label_end_rep;

		// Token: 0x0400049D RID: 1181
		[AccessedThroughProperty("TabPage_ED")]
		private TabPage _TabPage_ED;

		// Token: 0x0400049E RID: 1182
		[AccessedThroughProperty("TabPage_EA")]
		private TabPage _TabPage_EA;

		// Token: 0x0400049F RID: 1183
		[AccessedThroughProperty("GroupBox_EA")]
		private GroupBox _GroupBox_EA;

		// Token: 0x040004A0 RID: 1184
		[AccessedThroughProperty("NumericUpDown_tamanho_filtro")]
		private NumericUpDown _NumericUpDown_tamanho_filtro;

		// Token: 0x040004A1 RID: 1185
		[AccessedThroughProperty("lb_Intervalo")]
		private Label _lb_Intervalo;

		// Token: 0x040004A2 RID: 1186
		[AccessedThroughProperty("lb_Amostras")]
		private Label _lb_Amostras;

		// Token: 0x040004A3 RID: 1187
		[AccessedThroughProperty("GroupBox_end_rep")]
		private GroupBox _GroupBox_end_rep;

		// Token: 0x040004A4 RID: 1188
		[AccessedThroughProperty("DataGridView_end_rep_RT_810")]
		private DataGridView _DataGridView_end_rep_RT_810;

		// Token: 0x040004A5 RID: 1189
		[AccessedThroughProperty("Posicao_1_10")]
		private DataGridViewTextBoxColumn _Posicao_1_10;

		// Token: 0x040004A6 RID: 1190
		[AccessedThroughProperty("End_01_10")]
		private DataGridViewTextBoxColumn _End_01_10;

		// Token: 0x040004A7 RID: 1191
		[AccessedThroughProperty("Posicao_11_20")]
		private DataGridViewTextBoxColumn _Posicao_11_20;

		// Token: 0x040004A8 RID: 1192
		[AccessedThroughProperty("End_11_20")]
		private DataGridViewTextBoxColumn _End_11_20;

		// Token: 0x040004A9 RID: 1193
		[AccessedThroughProperty("Posicao_21_30")]
		private DataGridViewTextBoxColumn _Posicao_21_30;

		// Token: 0x040004AA RID: 1194
		[AccessedThroughProperty("End_21_30")]
		private DataGridViewTextBoxColumn _End_21_30;

		// Token: 0x040004AB RID: 1195
		[AccessedThroughProperty("Posicao_31_40")]
		private DataGridViewTextBoxColumn _Posicao_31_40;

		// Token: 0x040004AC RID: 1196
		[AccessedThroughProperty("End_31_40")]
		private DataGridViewTextBoxColumn _End_31_40;

		// Token: 0x040004AD RID: 1197
		[AccessedThroughProperty("Posicao_41_50")]
		private DataGridViewTextBoxColumn _Posicao_41_50;

		// Token: 0x040004AE RID: 1198
		[AccessedThroughProperty("End_41_50")]
		private DataGridViewTextBoxColumn _End_41_50;

		// Token: 0x040004AF RID: 1199
		[AccessedThroughProperty("ToolStri_RT_810")]
		private ToolStrip _ToolStri_RT_810;

		// Token: 0x040004B0 RID: 1200
		[AccessedThroughProperty("TextBox_equipamento")]
		private TextBox _TextBox_equipamento;

		// Token: 0x040004B1 RID: 1201
		[AccessedThroughProperty("Label_equipamento")]
		private Label _Label_equipamento;

		// Token: 0x040004B2 RID: 1202
		[AccessedThroughProperty("ToolStripButton_RT_810_Abrir")]
		private ToolStripButton _ToolStripButton_RT_810_Abrir;

		// Token: 0x040004B3 RID: 1203
		[AccessedThroughProperty("ToolStripButton_RT_810_Salvar")]
		private ToolStripButton _ToolStripButton_RT_810_Salvar;

		// Token: 0x040004B4 RID: 1204
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x040004B5 RID: 1205
		[AccessedThroughProperty("ToolStripButton_RT_810_Download")]
		private ToolStripButton _ToolStripButton_RT_810_Download;

		// Token: 0x040004B6 RID: 1206
		[AccessedThroughProperty("ToolStripButton_RT_810_Upload")]
		private ToolStripButton _ToolStripButton_RT_810_Upload;

		// Token: 0x040004B7 RID: 1207
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x040004B8 RID: 1208
		[AccessedThroughProperty("ToolStripProgressBar_RT_810")]
		private ToolStripProgressBar _ToolStripProgressBar_RT_810;

		// Token: 0x040004B9 RID: 1209
		[AccessedThroughProperty("ToolStripTextBox_RT_810_Msg")]
		private ToolStripTextBox _ToolStripTextBox_RT_810_Msg;

		// Token: 0x040004BA RID: 1210
		[AccessedThroughProperty("ToolStripButton_RT_810_novo")]
		private ToolStripButton _ToolStripButton_RT_810_novo;

		// Token: 0x040004BB RID: 1211
		[AccessedThroughProperty("OpenFileDialog_RT_810")]
		private OpenFileDialog _OpenFileDialog_RT_810;

		// Token: 0x040004BC RID: 1212
		[AccessedThroughProperty("SaveFileDialog_RT_810")]
		private SaveFileDialog _SaveFileDialog_RT_810;

		// Token: 0x040004BD RID: 1213
		[AccessedThroughProperty("NumericUpDown_intervalo_filtro")]
		private NumericUpDown _NumericUpDown_intervalo_filtro;

		// Token: 0x040004BE RID: 1214
		[AccessedThroughProperty("Timer_limpa_MSG")]
		private Timer _Timer_limpa_MSG;

		// Token: 0x040004BF RID: 1215
		[AccessedThroughProperty("GroupBox_ModoOperacao")]
		private GroupBox _GroupBox_ModoOperacao;

		// Token: 0x040004C0 RID: 1216
		[AccessedThroughProperty("ComboBox_Modo_Operacao")]
		private ComboBox _ComboBox_Modo_Operacao;

		// Token: 0x040004C1 RID: 1217
		[AccessedThroughProperty("NumericUpDown_intervalo_tx")]
		private NumericUpDown _NumericUpDown_intervalo_tx;

		// Token: 0x040004C2 RID: 1218
		[AccessedThroughProperty("lb_ModoOperacao")]
		private Label _lb_ModoOperacao;

		// Token: 0x040004C3 RID: 1219
		[AccessedThroughProperty("lb_IntervaloTX")]
		private Label _lb_IntervaloTX;

		// Token: 0x040004C4 RID: 1220
		[AccessedThroughProperty("GroupBox_sistema_leitura")]
		private GroupBox _GroupBox_sistema_leitura;

		// Token: 0x040004C5 RID: 1221
		[AccessedThroughProperty("GroupBox_ED")]
		private GroupBox _GroupBox_ED;

		// Token: 0x040004C6 RID: 1222
		[AccessedThroughProperty("GroupBox_descricao_RT810")]
		private GroupBox _GroupBox_descricao_RT810;

		// Token: 0x040004C7 RID: 1223
		[AccessedThroughProperty("Label_endereco")]
		private Label _Label_endereco;

		// Token: 0x040004C8 RID: 1224
		[AccessedThroughProperty("Label_nome")]
		private Label _Label_nome;

		// Token: 0x040004C9 RID: 1225
		[AccessedThroughProperty("TextBox_comentarios_RT810")]
		private TextBox _TextBox_comentarios_RT810;

		// Token: 0x040004CA RID: 1226
		[AccessedThroughProperty("TextBox_endereco_RT810")]
		private TextBox _TextBox_endereco_RT810;

		// Token: 0x040004CB RID: 1227
		[AccessedThroughProperty("TextBox_nome_RT810")]
		private TextBox _TextBox_nome_RT810;

		// Token: 0x040004CC RID: 1228
		[AccessedThroughProperty("Label_comentarios")]
		private Label _Label_comentarios;

		// Token: 0x040004CD RID: 1229
		[AccessedThroughProperty("ComboBox_modo_repeticao_RT_810")]
		private ComboBox _ComboBox_modo_repeticao_RT_810;

		// Token: 0x040004CE RID: 1230
		[AccessedThroughProperty("Label_modo_rep_RT_810")]
		private Label _Label_modo_rep_RT_810;

		// Token: 0x040004CF RID: 1231
		[AccessedThroughProperty("ToolStripButton_RT_810_Imprimir")]
		private ToolStripButton _ToolStripButton_RT_810_Imprimir;

		// Token: 0x040004D0 RID: 1232
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x040004D1 RID: 1233
		[AccessedThroughProperty("PrintDocument1")]
		private PrintDocument _PrintDocument1;

		// Token: 0x040004D2 RID: 1234
		[AccessedThroughProperty("PrintPreviewDialog1")]
		private PrintPreviewDialog _PrintPreviewDialog1;

		// Token: 0x040004D3 RID: 1235
		[AccessedThroughProperty("TabPage_dadosinstalacao")]
		private TabPage _TabPage_dadosinstalacao;

		// Token: 0x040004D4 RID: 1236
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x040004D5 RID: 1237
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040004D6 RID: 1238
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040004D7 RID: 1239
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040004D8 RID: 1240
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040004D9 RID: 1241
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x040004DA RID: 1242
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040004DB RID: 1243
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x040004DC RID: 1244
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x040004DD RID: 1245
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040004DE RID: 1246
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040004DF RID: 1247
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040004E0 RID: 1248
		[AccessedThroughProperty("CB_ModeloRadio")]
		private ComboBox _CB_ModeloRadio;

		// Token: 0x040004E1 RID: 1249
		[AccessedThroughProperty("CB_PolarizacaoAntena")]
		private ComboBox _CB_PolarizacaoAntena;

		// Token: 0x040004E2 RID: 1250
		[AccessedThroughProperty("CB_TipoAntena")]
		private ComboBox _CB_TipoAntena;

		// Token: 0x040004E3 RID: 1251
		[AccessedThroughProperty("T_FreqRadio")]
		private TextBox _T_FreqRadio;

		// Token: 0x040004E4 RID: 1252
		[AccessedThroughProperty("T_DistCentral")]
		private TextBox _T_DistCentral;

		// Token: 0x040004E5 RID: 1253
		[AccessedThroughProperty("T_PotRadio")]
		private TextBox _T_PotRadio;

		// Token: 0x040004E6 RID: 1254
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x040004E7 RID: 1255
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x040004E8 RID: 1256
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x040004E9 RID: 1257
		[AccessedThroughProperty("T_Latitude")]
		private TextBox _T_Latitude;

		// Token: 0x040004EA RID: 1258
		[AccessedThroughProperty("T_Longitude")]
		private TextBox _T_Longitude;

		// Token: 0x040004EB RID: 1259
		[AccessedThroughProperty("T_Azimute")]
		private TextBox _T_Azimute;

		// Token: 0x040004EC RID: 1260
		[AccessedThroughProperty("T_ModeloFonte")]
		private TextBox _T_ModeloFonte;

		// Token: 0x040004ED RID: 1261
		[AccessedThroughProperty("T_AlturaAntena")]
		private TextBox _T_AlturaAntena;

		// Token: 0x040004EE RID: 1262
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x040004EF RID: 1263
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x040004F0 RID: 1264
		[AccessedThroughProperty("RepetidoraBindingSource1")]
		private BindingSource _RepetidoraBindingSource1;

		// Token: 0x040004F1 RID: 1265
		[AccessedThroughProperty("lb_EndEst")]
		private Label _lb_EndEst;

		// Token: 0x040004F2 RID: 1266
		[AccessedThroughProperty("lb_EndMestre")]
		private Label _lb_EndMestre;

		// Token: 0x040004F3 RID: 1267
		[AccessedThroughProperty("lb_PTT")]
		private Label _lb_PTT;

		// Token: 0x040004F4 RID: 1268
		[AccessedThroughProperty("cb_ModoLeituraNivel")]
		private ComboBox _cb_ModoLeituraNivel;

		// Token: 0x040004F5 RID: 1269
		[AccessedThroughProperty("lb_RangeSensor")]
		private Label _lb_RangeSensor;

		// Token: 0x040004F6 RID: 1270
		[AccessedThroughProperty("lb_ErroOffsetSensor")]
		private Label _lb_ErroOffsetSensor;

		// Token: 0x040004F7 RID: 1271
		[AccessedThroughProperty("lb_AlturaReservatorio")]
		private Label _lb_AlturaReservatorio;

		// Token: 0x040004F8 RID: 1272
		[AccessedThroughProperty("NumericUpDown_errooffsetsensor")]
		private NumericUpDown _NumericUpDown_errooffsetsensor;

		// Token: 0x040004F9 RID: 1273
		[AccessedThroughProperty("NumericUpDown_alturareservatorio")]
		private NumericUpDown _NumericUpDown_alturareservatorio;

		// Token: 0x040004FA RID: 1274
		[AccessedThroughProperty("NumericUpDown_rangesensor")]
		private NumericUpDown _NumericUpDown_rangesensor;

		// Token: 0x040004FB RID: 1275
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x040004FC RID: 1276
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		// Token: 0x040004FD RID: 1277
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		// Token: 0x040004FE RID: 1278
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x040004FF RID: 1279
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x04000500 RID: 1280
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x04000501 RID: 1281
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x04000502 RID: 1282
		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		// Token: 0x04000503 RID: 1283
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		// Token: 0x04000504 RID: 1284
		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		// Token: 0x04000505 RID: 1285
		[AccessedThroughProperty("ToolStripLabel_ID")]
		private ToolStripLabel _ToolStripLabel_ID;

		// Token: 0x04000506 RID: 1286
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x04000507 RID: 1287
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		// Token: 0x04000508 RID: 1288
		[AccessedThroughProperty("tb_lixo1")]
		private TextBox _tb_lixo1;

		// Token: 0x04000509 RID: 1289
		[AccessedThroughProperty("tb_lixo2")]
		private TextBox _tb_lixo2;

		// Token: 0x0400050A RID: 1290
		[AccessedThroughProperty("tb_lixo3")]
		private TextBox _tb_lixo3;

		// Token: 0x0400050B RID: 1291
		[AccessedThroughProperty("tb_lixo4")]
		private TextBox _tb_lixo4;

		// Token: 0x0400050C RID: 1292
		private int pagina_impressao;
	}
}
