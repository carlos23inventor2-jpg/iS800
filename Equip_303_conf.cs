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
	// Token: 0x02000088 RID: 136
	[DesignerGenerated]
	public partial class Equip_303_conf : Form
	{
		// Token: 0x06002284 RID: 8836 RVA: 0x003FF24C File Offset: 0x003FD64C
		public Equip_303_conf()
		{
			base.Load += new EventHandler(this.Equip_303_conf_Load);
			this.InitializeComponent();
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x00401298 File Offset: 0x003FF698
		// (set) Token: 0x06002288 RID: 8840 RVA: 0x004012AC File Offset: 0x003FF6AC
		internal virtual GroupBox Grupo_conf_comunicacao
		{
			get
			{
				return this._Grupo_conf_comunicacao;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_conf_comunicacao = value;
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x004012B8 File Offset: 0x003FF6B8
		// (set) Token: 0x0600228A RID: 8842 RVA: 0x004012CC File Offset: 0x003FF6CC
		internal virtual NumericUpDown Valor_endereco_estacao
		{
			get
			{
				return this._Valor_endereco_estacao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_endereco_estacao_ValueChanged);
				if (this._Valor_endereco_estacao != null)
				{
					this._Valor_endereco_estacao.ValueChanged -= eventHandler;
				}
				this._Valor_endereco_estacao = value;
				if (this._Valor_endereco_estacao != null)
				{
					this._Valor_endereco_estacao.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x0600228B RID: 8843 RVA: 0x00401318 File Offset: 0x003FF718
		// (set) Token: 0x0600228C RID: 8844 RVA: 0x0040132C File Offset: 0x003FF72C
		internal virtual Label Label_endereco_estacao
		{
			get
			{
				return this._Label_endereco_estacao;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_endereco_estacao = value;
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x00401338 File Offset: 0x003FF738
		// (set) Token: 0x0600228E RID: 8846 RVA: 0x0040134C File Offset: 0x003FF74C
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

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x0600228F RID: 8847 RVA: 0x00401398 File Offset: 0x003FF798
		// (set) Token: 0x06002290 RID: 8848 RVA: 0x004013AC File Offset: 0x003FF7AC
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

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06002291 RID: 8849 RVA: 0x004013B8 File Offset: 0x003FF7B8
		// (set) Token: 0x06002292 RID: 8850 RVA: 0x004013CC File Offset: 0x003FF7CC
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

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06002293 RID: 8851 RVA: 0x00401418 File Offset: 0x003FF818
		// (set) Token: 0x06002294 RID: 8852 RVA: 0x0040142C File Offset: 0x003FF82C
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

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06002295 RID: 8853 RVA: 0x00401438 File Offset: 0x003FF838
		// (set) Token: 0x06002296 RID: 8854 RVA: 0x0040144C File Offset: 0x003FF84C
		internal virtual Label Label_endereco_mestre
		{
			get
			{
				return this._Label_endereco_mestre;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_endereco_mestre = value;
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06002297 RID: 8855 RVA: 0x00401458 File Offset: 0x003FF858
		// (set) Token: 0x06002298 RID: 8856 RVA: 0x0040146C File Offset: 0x003FF86C
		internal virtual GroupBox Grupo_equipamentos
		{
			get
			{
				return this._Grupo_equipamentos;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_equipamentos = value;
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06002299 RID: 8857 RVA: 0x00401478 File Offset: 0x003FF878
		// (set) Token: 0x0600229A RID: 8858 RVA: 0x0040148C File Offset: 0x003FF88C
		internal virtual NumericUpDown Valor_num_rq
		{
			get
			{
				return this._Valor_num_rq;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_num_rq_ValueChanged);
				if (this._Valor_num_rq != null)
				{
					this._Valor_num_rq.ValueChanged -= eventHandler;
				}
				this._Valor_num_rq = value;
				if (this._Valor_num_rq != null)
				{
					this._Valor_num_rq.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x0600229B RID: 8859 RVA: 0x004014D8 File Offset: 0x003FF8D8
		// (set) Token: 0x0600229C RID: 8860 RVA: 0x004014EC File Offset: 0x003FF8EC
		internal virtual Label Label_num_rq
		{
			get
			{
				return this._Label_num_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_num_rq = value;
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x0600229D RID: 8861 RVA: 0x004014F8 File Offset: 0x003FF8F8
		// (set) Token: 0x0600229E RID: 8862 RVA: 0x0040150C File Offset: 0x003FF90C
		internal virtual NumericUpDown Valor_num_res
		{
			get
			{
				return this._Valor_num_res;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_num_res_ValueChanged);
				if (this._Valor_num_res != null)
				{
					this._Valor_num_res.ValueChanged -= eventHandler;
				}
				this._Valor_num_res = value;
				if (this._Valor_num_res != null)
				{
					this._Valor_num_res.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x00401558 File Offset: 0x003FF958
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x0040156C File Offset: 0x003FF96C
		internal virtual Label Label_num_res
		{
			get
			{
				return this._Label_num_res;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_num_res = value;
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x00401578 File Offset: 0x003FF978
		// (set) Token: 0x060022A2 RID: 8866 RVA: 0x0040158C File Offset: 0x003FF98C
		internal virtual GroupBox Grupo_lapelas
		{
			get
			{
				return this._Grupo_lapelas;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_lapelas = value;
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x00401598 File Offset: 0x003FF998
		// (set) Token: 0x060022A4 RID: 8868 RVA: 0x004015AC File Offset: 0x003FF9AC
		internal virtual TabControl TabControl_303
		{
			get
			{
				return this._TabControl_303;
			}
			[MethodImpl(32)]
			set
			{
				this._TabControl_303 = value;
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x004015B8 File Offset: 0x003FF9B8
		// (set) Token: 0x060022A6 RID: 8870 RVA: 0x004015CC File Offset: 0x003FF9CC
		internal virtual TabPage Conf_res
		{
			get
			{
				return this._Conf_res;
			}
			[MethodImpl(32)]
			set
			{
				this._Conf_res = value;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x004015D8 File Offset: 0x003FF9D8
		// (set) Token: 0x060022A8 RID: 8872 RVA: 0x004015EC File Offset: 0x003FF9EC
		internal virtual DataGridView DataGridView_RE_303
		{
			get
			{
				return this._DataGridView_RE_303;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_RE_303_CellValidating);
				if (this._DataGridView_RE_303 != null)
				{
					this._DataGridView_RE_303.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_RE_303 = value;
				if (this._DataGridView_RE_303 != null)
				{
					this._DataGridView_RE_303.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x00401638 File Offset: 0x003FFA38
		// (set) Token: 0x060022AA RID: 8874 RVA: 0x0040164C File Offset: 0x003FFA4C
		internal virtual TabPage Conf_rq
		{
			get
			{
				return this._Conf_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Conf_rq = value;
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x00401658 File Offset: 0x003FFA58
		// (set) Token: 0x060022AC RID: 8876 RVA: 0x0040166C File Offset: 0x003FFA6C
		internal virtual DataGridView DataGridView_RQ_303
		{
			get
			{
				return this._DataGridView_RQ_303;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_RQ_303_CellValidating);
				if (this._DataGridView_RQ_303 != null)
				{
					this._DataGridView_RQ_303.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_RQ_303 = value;
				if (this._DataGridView_RQ_303 != null)
				{
					this._DataGridView_RQ_303.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x004016B8 File Offset: 0x003FFAB8
		// (set) Token: 0x060022AE RID: 8878 RVA: 0x004016CC File Offset: 0x003FFACC
		internal virtual GroupBox Grupo_comandos
		{
			get
			{
				return this._Grupo_comandos;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_comandos = value;
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x004016D8 File Offset: 0x003FFAD8
		// (set) Token: 0x060022B0 RID: 8880 RVA: 0x004016EC File Offset: 0x003FFAEC
		internal virtual Button Esc_conf_md_303
		{
			get
			{
				return this._Esc_conf_md_303;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Esc_conf_md_303_Click);
				if (this._Esc_conf_md_303 != null)
				{
					this._Esc_conf_md_303.Click -= eventHandler;
				}
				this._Esc_conf_md_303 = value;
				if (this._Esc_conf_md_303 != null)
				{
					this._Esc_conf_md_303.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x00401738 File Offset: 0x003FFB38
		// (set) Token: 0x060022B2 RID: 8882 RVA: 0x0040174C File Offset: 0x003FFB4C
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

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x00401758 File Offset: 0x003FFB58
		// (set) Token: 0x060022B4 RID: 8884 RVA: 0x0040176C File Offset: 0x003FFB6C
		internal virtual Button Ler_conf_md_303
		{
			get
			{
				return this._Ler_conf_md_303;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Ler_conf_md_303_Click);
				if (this._Ler_conf_md_303 != null)
				{
					this._Ler_conf_md_303.Click -= eventHandler;
				}
				this._Ler_conf_md_303 = value;
				if (this._Ler_conf_md_303 != null)
				{
					this._Ler_conf_md_303.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x004017B8 File Offset: 0x003FFBB8
		// (set) Token: 0x060022B6 RID: 8886 RVA: 0x004017CC File Offset: 0x003FFBCC
		internal virtual DataGridViewTextBoxColumn Col_end
		{
			get
			{
				return this._Col_end;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_end = value;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x004017D8 File Offset: 0x003FFBD8
		// (set) Token: 0x060022B8 RID: 8888 RVA: 0x004017EC File Offset: 0x003FFBEC
		internal virtual DataGridViewTextBoxColumn Col_nome
		{
			get
			{
				return this._Col_nome;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_nome = value;
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x004017F8 File Offset: 0x003FFBF8
		// (set) Token: 0x060022BA RID: 8890 RVA: 0x0040180C File Offset: 0x003FFC0C
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

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x060022BB RID: 8891 RVA: 0x00401818 File Offset: 0x003FFC18
		// (set) Token: 0x060022BC RID: 8892 RVA: 0x0040182C File Offset: 0x003FFC2C
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

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x00401838 File Offset: 0x003FFC38
		// (set) Token: 0x060022BE RID: 8894 RVA: 0x0040184C File Offset: 0x003FFC4C
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

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x00401898 File Offset: 0x003FFC98
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x004018AC File Offset: 0x003FFCAC
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

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x004018F8 File Offset: 0x003FFCF8
		// (set) Token: 0x060022C2 RID: 8898 RVA: 0x0040190C File Offset: 0x003FFD0C
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

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x00401958 File Offset: 0x003FFD58
		// (set) Token: 0x060022C4 RID: 8900 RVA: 0x0040196C File Offset: 0x003FFD6C
		internal virtual GroupBox Gupo_senha
		{
			get
			{
				return this._Gupo_senha;
			}
			[MethodImpl(32)]
			set
			{
				this._Gupo_senha = value;
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x00401978 File Offset: 0x003FFD78
		// (set) Token: 0x060022C6 RID: 8902 RVA: 0x0040198C File Offset: 0x003FFD8C
		internal virtual NumericUpDown Valor_NumericUpDown_senha
		{
			get
			{
				return this._Valor_NumericUpDown_senha;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_NumericUpDown_senha_ValueChanged);
				if (this._Valor_NumericUpDown_senha != null)
				{
					this._Valor_NumericUpDown_senha.ValueChanged -= eventHandler;
				}
				this._Valor_NumericUpDown_senha = value;
				if (this._Valor_NumericUpDown_senha != null)
				{
					this._Valor_NumericUpDown_senha.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x004019D8 File Offset: 0x003FFDD8
		// (set) Token: 0x060022C8 RID: 8904 RVA: 0x004019EC File Offset: 0x003FFDEC
		internal virtual NumericUpDown Valor_endereco_mestre
		{
			get
			{
				return this._Valor_endereco_mestre;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_endereco_mestre_ValueChanged);
				if (this._Valor_endereco_mestre != null)
				{
					this._Valor_endereco_mestre.ValueChanged -= eventHandler;
				}
				this._Valor_endereco_mestre = value;
				if (this._Valor_endereco_mestre != null)
				{
					this._Valor_endereco_mestre.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x00401A38 File Offset: 0x003FFE38
		// (set) Token: 0x060022CA RID: 8906 RVA: 0x00401A4C File Offset: 0x003FFE4C
		internal virtual DataGridViewTextBoxColumn Col_End_rq
		{
			get
			{
				return this._Col_End_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_End_rq = value;
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x00401A58 File Offset: 0x003FFE58
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x00401A6C File Offset: 0x003FFE6C
		internal virtual DataGridViewTextBoxColumn Col_nome_rq
		{
			get
			{
				return this._Col_nome_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_nome_rq = value;
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x00401A78 File Offset: 0x003FFE78
		// (set) Token: 0x060022CE RID: 8910 RVA: 0x00401A8C File Offset: 0x003FFE8C
		internal virtual DataGridViewComboBoxColumn Col_mod_rq
		{
			get
			{
				return this._Col_mod_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_mod_rq = value;
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x00401A98 File Offset: 0x003FFE98
		// (set) Token: 0x060022D0 RID: 8912 RVA: 0x00401AAC File Offset: 0x003FFEAC
		internal virtual DataGridViewComboBoxColumn Col_hab
		{
			get
			{
				return this._Col_hab;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_hab = value;
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x00401AB8 File Offset: 0x003FFEB8
		// (set) Token: 0x060022D2 RID: 8914 RVA: 0x00401ACC File Offset: 0x003FFECC
		internal virtual DataGridViewTextBoxColumn Col_Esc_1
		{
			get
			{
				return this._Col_Esc_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Esc_1 = value;
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x00401AD8 File Offset: 0x003FFED8
		// (set) Token: 0x060022D4 RID: 8916 RVA: 0x00401AEC File Offset: 0x003FFEEC
		internal virtual DataGridViewTextBoxColumn Col_Esc_2
		{
			get
			{
				return this._Col_Esc_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Esc_2 = value;
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x00401AF8 File Offset: 0x003FFEF8
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x00401B0C File Offset: 0x003FFF0C
		internal virtual DataGridViewTextBoxColumn Col_Esc_3
		{
			get
			{
				return this._Col_Esc_3;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Esc_3 = value;
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x00401B18 File Offset: 0x003FFF18
		// (set) Token: 0x060022D8 RID: 8920 RVA: 0x00401B2C File Offset: 0x003FFF2C
		internal virtual DataGridViewTextBoxColumn Col_Esc_4
		{
			get
			{
				return this._Col_Esc_4;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Esc_4 = value;
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x00401B38 File Offset: 0x003FFF38
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x00401B4C File Offset: 0x003FFF4C
		internal virtual DataGridViewTextBoxColumn Col_Esc_5
		{
			get
			{
				return this._Col_Esc_5;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Esc_5 = value;
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x00401B58 File Offset: 0x003FFF58
		// (set) Token: 0x060022DC RID: 8924 RVA: 0x00401B6C File Offset: 0x003FFF6C
		internal virtual DataGridViewTextBoxColumn Col_Esc_6
		{
			get
			{
				return this._Col_Esc_6;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Esc_6 = value;
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x00401B78 File Offset: 0x003FFF78
		// (set) Token: 0x060022DE RID: 8926 RVA: 0x00401B8C File Offset: 0x003FFF8C
		internal virtual DataGridViewTextBoxColumn Col_Esc_7
		{
			get
			{
				return this._Col_Esc_7;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Esc_7 = value;
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x00401B98 File Offset: 0x003FFF98
		// (set) Token: 0x060022E0 RID: 8928 RVA: 0x00401BAC File Offset: 0x003FFFAC
		internal virtual DataGridViewTextBoxColumn Col_Esc_8
		{
			get
			{
				return this._Col_Esc_8;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Esc_8 = value;
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x00401BB8 File Offset: 0x003FFFB8
		// (set) Token: 0x060022E2 RID: 8930 RVA: 0x00401BCC File Offset: 0x003FFFCC
		internal virtual DataGridViewTextBoxColumn Col_Esc_9
		{
			get
			{
				return this._Col_Esc_9;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Esc_9 = value;
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x00401BD8 File Offset: 0x003FFFD8
		// (set) Token: 0x060022E4 RID: 8932 RVA: 0x00401BEC File Offset: 0x003FFFEC
		internal virtual DataGridViewTextBoxColumn Col_Esc_10
		{
			get
			{
				return this._Col_Esc_10;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Esc_10 = value;
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x00401BF8 File Offset: 0x003FFFF8
		// (set) Token: 0x060022E6 RID: 8934 RVA: 0x00401C0C File Offset: 0x0040000C
		internal virtual DataGridViewTextBoxColumn Col_Esc_11
		{
			get
			{
				return this._Col_Esc_11;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Esc_11 = value;
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x00401C18 File Offset: 0x00400018
		// (set) Token: 0x060022E8 RID: 8936 RVA: 0x00401C2C File Offset: 0x0040002C
		internal virtual DataGridViewTextBoxColumn Col_Esc_12
		{
			get
			{
				return this._Col_Esc_12;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Esc_12 = value;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x00401C38 File Offset: 0x00400038
		// (set) Token: 0x060022EA RID: 8938 RVA: 0x00401C4C File Offset: 0x0040004C
		internal virtual DataGridViewTextBoxColumn Col_Esc_13
		{
			get
			{
				return this._Col_Esc_13;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Esc_13 = value;
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x00401C58 File Offset: 0x00400058
		// (set) Token: 0x060022EC RID: 8940 RVA: 0x00401C6C File Offset: 0x0040006C
		internal virtual DataGridViewTextBoxColumn Col_Esc_14
		{
			get
			{
				return this._Col_Esc_14;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Esc_14 = value;
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x00401C78 File Offset: 0x00400078
		// (set) Token: 0x060022EE RID: 8942 RVA: 0x00401C8C File Offset: 0x0040008C
		internal virtual DataGridViewTextBoxColumn Col_Esc_15
		{
			get
			{
				return this._Col_Esc_15;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Esc_15 = value;
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x00401C98 File Offset: 0x00400098
		// (set) Token: 0x060022F0 RID: 8944 RVA: 0x00401CAC File Offset: 0x004000AC
		internal virtual DataGridViewTextBoxColumn Col_Esc_16
		{
			get
			{
				return this._Col_Esc_16;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Esc_16 = value;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x00401CB8 File Offset: 0x004000B8
		// (set) Token: 0x060022F2 RID: 8946 RVA: 0x00401CCC File Offset: 0x004000CC
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

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x00401CD8 File Offset: 0x004000D8
		// (set) Token: 0x060022F4 RID: 8948 RVA: 0x00401CEC File Offset: 0x004000EC
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

		// Token: 0x060022F5 RID: 8949 RVA: 0x00401CF8 File Offset: 0x004000F8
		private void Valor_endereco_mestre_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_303_geral.Endereco_mestre = 0;
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00401D20 File Offset: 0x00400120
		private void Valor_endereco_estacao_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_303_geral.Endereco_estacao = 0;
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x00401D48 File Offset: 0x00400148
		private void Valor_temp_ptt_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_303_geral.Tempo_ptt = Conversions.ToInteger(Operators.DivideObject(null, 10));
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x00401D7C File Offset: 0x0040017C
		private void Combo_baudrate_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_303_geral.Baud_rate_com2 = Conversions.ToInteger(Operators.AddObject(null, 21849));
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00401DB4 File Offset: 0x004001B4
		private void Valor_num_res_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_303_geral.Qtd_equip_res = 0;
			this.Atualiza_dados_re_303(Mod_MD.Central_303_geral.Qtd_equip_res);
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00401DEC File Offset: 0x004001EC
		private void Valor_num_rq_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_303_geral.Qdt_equip_rq = 0;
			this.Atualiza_dados_rq_303(Mod_MD.Central_303_geral.Qdt_equip_rq);
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00401E24 File Offset: 0x00400224
		private void Equip_303_conf_Load(object sender, EventArgs e)
		{
			this.Combo_baudrate.Items.Clear();
			this.Combo_baudrate.Items.Add("1200");
			this.Combo_baudrate.Items.Add("9600");
			this.Limpa_estrutura_MD303();
			this.Atualiza_dados_gerais_303();
			this.Atualiza_dados_re_303(Mod_MD.Central_302_geral.Qtd_equip_res);
			this.Atualiza_dados_rq_303(Mod_MD.Central_302_geral.Qdt_equip_rq);
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x00401E9C File Offset: 0x0040029C
		public void Limpa_estrutura_MD303()
		{
			Mod_MD.Central_303_geral.Baud_rate_com2 = 21849;
			Mod_MD.Central_303_geral.Endereco_mestre = 0;
			Mod_MD.Central_303_geral.Endereco_estacao = 0;
			Mod_MD.Central_303_geral.Qdt_equip_rq = 0;
			Mod_MD.Central_303_geral.Qtd_equip_res = 0;
			Mod_MD.Central_303_geral.Tempo_ptt = 200;
			int num = 0;
			int num_MAX_RE = Mod_MD.NUM_MAX_RE;
			checked
			{
				for (int i = num; i <= num_MAX_RE; i++)
				{
					Mod_MD.Central_303_res[i].Msg = 0;
				}
				int num2 = 0;
				int num_MAX_RQ = Mod_MD.NUM_MAX_RQ;
				for (int i = num2; i <= num_MAX_RQ; i++)
				{
					Mod_MD.Central_303_rq[i].modelo = 1;
					Mod_MD.Central_303_rq[i].Hab_cmd = 0;
					Mod_MD.Central_303_rq[i].Msg = 0;
					Mod_MD.Central_303_rq[i].escala_1 = 100;
					Mod_MD.Central_303_rq[i].escala_2 = 100;
					Mod_MD.Central_303_rq[i].escala_3 = 100;
					Mod_MD.Central_303_rq[i].escala_4 = 100;
					Mod_MD.Central_303_rq[i].escala_5 = 100;
					Mod_MD.Central_303_rq[i].escala_6 = 100;
					Mod_MD.Central_303_rq[i].escala_7 = 100;
					Mod_MD.Central_303_rq[i].escala_8 = 100;
					Mod_MD.Central_303_rq[i].escala_9 = 100;
					Mod_MD.Central_303_rq[i].escala_10 = 100;
					Mod_MD.Central_303_rq[i].escala_11 = 100;
					Mod_MD.Central_303_rq[i].escala_12 = 100;
					Mod_MD.Central_303_rq[i].escala_13 = 100;
					Mod_MD.Central_303_rq[i].escala_14 = 100;
					Mod_MD.Central_303_rq[i].escala_15 = 100;
					Mod_MD.Central_303_rq[i].escala_16 = 100;
				}
				Mod_MD.Central_303_geral.Senha = 0;
			}
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x0040208C File Offset: 0x0040048C
		public void Atualiza_dados_gerais_303()
		{
			this.Valor_endereco_mestre.Value = new decimal(Mod_MD.Central_303_geral.Endereco_mestre);
			this.Valor_endereco_estacao.Value = new decimal(Mod_MD.Central_303_geral.Endereco_estacao);
			checked
			{
				this.Valor_temp_ptt.Value = new decimal(10 * Mod_MD.Central_303_geral.Tempo_ptt);
				this.Combo_baudrate.SelectedIndex = Mod_MD.Central_303_geral.Baud_rate_com2 - 21849;
				this.Valor_num_res.Value = new decimal(Mod_MD.Central_303_geral.Qtd_equip_res);
				this.Valor_num_rq.Value = new decimal(Mod_MD.Central_303_geral.Qdt_equip_rq);
				this.Valor_NumericUpDown_senha.Value = new decimal(Mod_MD.Central_303_geral.Senha);
			}
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x00402154 File Offset: 0x00400554
		public void Atualiza_dados_re_303(int numero)
		{
			if (numero == 0)
			{
				this.DataGridView_RE_303.Rows.Clear();
				return;
			}
			this.DataGridView_RE_303.Rows.Clear();
			checked
			{
				for (int i = 1; i <= numero; i++)
				{
					string text = Conversion.Str(i);
					string text2 = Conversion.Str(Mod_MD.Central_303_res[i].Msg);
					this.DataGridView_RE_303.Rows.Add(new object[]
					{
						text,
						text2
					});
				}
			}
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x004021E0 File Offset: 0x004005E0
		public void Atualiza_dados_rq_303(int numero)
		{
			if (numero == 0)
			{
				this.DataGridView_RQ_303.Rows.Clear();
				return;
			}
			this.DataGridView_RQ_303.Rows.Clear();
			checked
			{
				for (int i = 1; i <= numero; i++)
				{
					string text = Conversion.Str(i);
					string text2;
					switch (Mod_MD.Central_303_rq[i].modelo)
					{
					case 1:
						text2 = "MD 201";
						break;
					case 2:
						text2 = "MD 202";
						break;
					default:
						text2 = "--------";
						break;
					}
					string text3 = Conversion.Str(Mod_MD.Central_303_rq[i].Msg);
					int hab_cmd = Mod_MD.Central_303_rq[i].Hab_cmd;
					string text4;
					if (hab_cmd == 0)
					{
						text4 = "Bloqueado";
					}
					else if (hab_cmd == 21882)
					{
						text4 = "Habilitado";
					}
					else
					{
						text4 = "Erro conf";
					}
					string text5 = Conversion.Str(Mod_MD.Central_303_rq[i].escala_1);
					string text6 = Conversion.Str(Mod_MD.Central_303_rq[i].escala_2);
					string text7 = Conversion.Str(Mod_MD.Central_303_rq[i].escala_3);
					string text8 = Conversion.Str(Mod_MD.Central_303_rq[i].escala_4);
					string text9 = Conversion.Str(Mod_MD.Central_303_rq[i].escala_5);
					string text10 = Conversion.Str(Mod_MD.Central_303_rq[i].escala_6);
					string text11 = Conversion.Str(Mod_MD.Central_303_rq[i].escala_7);
					string text12 = Conversion.Str(Mod_MD.Central_303_rq[i].escala_8);
					string text13 = Conversion.Str(Mod_MD.Central_303_rq[i].escala_9);
					string text14 = Conversion.Str(Mod_MD.Central_303_rq[i].escala_10);
					string text15 = Conversion.Str(Mod_MD.Central_303_rq[i].escala_11);
					string text16 = Conversion.Str(Mod_MD.Central_303_rq[i].escala_12);
					string text17 = Conversion.Str(Mod_MD.Central_303_rq[i].escala_13);
					string text18 = Conversion.Str(Mod_MD.Central_303_rq[i].escala_14);
					string text19 = Conversion.Str(Mod_MD.Central_303_rq[i].escala_15);
					string text20 = Conversion.Str(Mod_MD.Central_303_rq[i].escala_16);
					this.DataGridView_RQ_303.Rows.Add(new object[]
					{
						text,
						text3,
						text2,
						text4,
						text5,
						text6,
						text7,
						text8,
						text9,
						text10,
						text11,
						text12,
						text13,
						text14,
						text15,
						text16,
						text17,
						text18,
						text19,
						text20
					});
				}
			}
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x00402524 File Offset: 0x00400924
		public void Controle_tecla_conf_303(int operacao)
		{
			switch (operacao)
			{
			case 1:
				this.Ler_conf_md_303.Enabled = true;
				this.Esc_conf_md_303.Enabled = true;
				break;
			case 2:
				this.Ler_conf_md_303.Enabled = false;
				this.Esc_conf_md_303.Enabled = false;
				break;
			}
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00402578 File Offset: 0x00400978
		public void Mensagem_MD303(string msg, int cor)
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

		// Token: 0x06002302 RID: 8962 RVA: 0x004025DC File Offset: 0x004009DC
		private void Ler_conf_md_303_Click(object sender, EventArgs e)
		{
			int[] array = new int[]
			{
				256,
				512,
				768,
				844,
				1024,
				1100,
				1280,
				1356,
				1536,
				1612,
				2304
			};
			int[] array2 = new int[]
			{
				6,
				40,
				76,
				57,
				76,
				57,
				76,
				57,
				76,
				57,
				1
			};
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			this.DataGridView_RE_303.CurrentCell = null;
			this.DataGridView_RQ_303.CurrentCell = null;
			this.Controle_tecla_conf_303(2);
			this.Mensagem_MD303("Aguarde ...", 2);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Leitura_pagina(100, 255, 6);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			Mod_MD.Atualiza_dados_MD303(100);
			int num = 1;
			checked
			{
				for (;;)
				{
					ctrl_RESP_ = Mod_MD.Leitura_pagina(array[num], Mod_MD.Central_303_geral.Endereco_estacao, array2[num]);
					this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					if (!ctrl_RESP_.Status)
					{
						break;
					}
					Mod_MD.Atualiza_dados_MD303(array[num]);
					num++;
					if (num > 10)
					{
						goto Block_4;
					}
				}
				this.Controle_tecla_conf_303(1);
				return;
				Block_4:
				this.Atualiza_dados_gerais_303();
				this.Atualiza_dados_re_303(Mod_MD.Central_303_geral.Qtd_equip_res);
				this.Atualiza_dados_rq_303(Mod_MD.Central_303_geral.Qdt_equip_rq);
				this.Mensagem_MD303("Leitura executada com sucesso", 0);
				this.Controle_tecla_conf_303(1);
			}
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x004027B0 File Offset: 0x00400BB0
		private void Esc_conf_md_303_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			this.DataGridView_RE_303.CurrentCell = null;
			this.DataGridView_RQ_303.CurrentCell = null;
			this.Controle_tecla_conf_303(2);
			this.Mensagem_MD303("Aguarde ...", 2);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(100, 5);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(512, 5);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(768, 5);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(888, 5);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(1024, 5);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(1144, 5);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(1280, 5);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(1400, 5);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(1536, 5);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(1656, 5);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(1424, 5);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD303(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_303(1);
				return;
			}
			this.Controle_tecla_conf_303(1);
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x00402CC4 File Offset: 0x004010C4
		private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Limpa_estrutura_MD303();
			this.Atualiza_dados_gerais_303();
			this.Atualiza_dados_re_303(Mod_MD.Central_303_geral.Qtd_equip_res);
			this.Atualiza_dados_rq_303(Mod_MD.Central_303_geral.Qdt_equip_rq);
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x00402CF4 File Offset: 0x004010F4
		private void DataGridView_RE_303_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			bool flag = true;
			Mod_MD.CTRL_RESP_1 ctrl_RESP_;
			ctrl_RESP_.Msg = "";
			string name = this.DataGridView_RE_303.Columns[e.ColumnIndex].Name;
			checked
			{
				if (Operators.CompareString(name, "Col_nome", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 9999, 0);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_res[e.RowIndex + 1].Msg = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else
				{
					flag = false;
				}
				if (flag)
				{
					this.DataGridView_RE_303.CurrentCell.Value = ctrl_RESP_.Msg;
					this.DataGridView_RE_303.RefreshEdit();
				}
			}
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00402DAC File Offset: 0x004011AC
		private void DataGridView_RQ_303_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			bool flag = true;
			Mod_MD.CTRL_RESP_1 ctrl_RESP_;
			ctrl_RESP_.Msg = "";
			string name = this.DataGridView_RQ_303.Columns[e.ColumnIndex].Name;
			checked
			{
				if (Operators.CompareString(name, "Col_nome_rq", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 9999, 0);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].Msg = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_mod_rq", false) == 0)
				{
					int num = 0;
					object formattedValue = e.FormattedValue;
					if (Operators.ConditionalCompareObjectEqual(formattedValue, "MD 201", false))
					{
						num = 1;
					}
					else if (Operators.ConditionalCompareObjectEqual(formattedValue, "MD 202", false))
					{
						num = 2;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].modelo = num;
					flag = false;
				}
				else if (Operators.CompareString(name, "Col_hab", false) == 0)
				{
					int num = 0;
					object formattedValue2 = e.FormattedValue;
					if (Operators.ConditionalCompareObjectEqual(formattedValue2, "Bloqueado", false))
					{
						num = 0;
					}
					else if (Operators.ConditionalCompareObjectEqual(formattedValue2, "Habilitado", false))
					{
						num = 21882;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].Hab_cmd = num;
					flag = false;
				}
				else if (Operators.CompareString(name, "Col_Esc_1", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].escala_1 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_Esc_2", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].escala_2 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_Esc_3", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].escala_3 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_Esc_4", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].escala_4 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_Esc_5", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].escala_5 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_Esc_6", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].escala_6 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_Esc_7", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].escala_7 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_Esc_8", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].escala_9 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_Esc_9", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].escala_9 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_Esc_10", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].escala_10 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_Esc_11", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].escala_11 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_Esc_12", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].escala_12 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_Esc_13", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].escala_13 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_Esc_14", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].escala_14 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_Esc_15", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].escala_15 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_Esc_16", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_303_rq[e.RowIndex + 1].escala_16 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else
				{
					flag = false;
				}
				if (flag)
				{
					this.DataGridView_RQ_303.CurrentCell.Value = ctrl_RESP_.Msg;
					this.DataGridView_RQ_303.RefreshEdit();
				}
			}
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x004034BC File Offset: 0x004018BC
		private void Valor_NumericUpDown_senha_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_303_geral.Senha = 0;
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x004034E4 File Offset: 0x004018E4
		[MethodImpl(72)]
		private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Limpa_estrutura_MD303();
			this.OpenFileDialog1.Filter = "Arquivo de configuração de equipamento|*.V331";
			this.OpenFileDialog1.InitialDirectory = "c:\\";
			checked
			{
				if (this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
				{
					int num = Strings.InStr(1, this.OpenFileDialog1.FileName, ".", Microsoft.VisualBasic.CompareMethod.Text);
					string text = Strings.Left(this.OpenFileDialog1.FileName, num);
					if (Operators.CompareString(this.OpenFileDialog1.FileName, "", false) != 0)
					{
						num = Strings.Len(Mod_MD.Central_303_geral);
						FileSystem.FileOpen(1, this.OpenFileDialog1.FileName, (OpenMode)4, (OpenAccess)(-1), (OpenShare)(-1), num);
						int num2 = 1;
						ValueType valueType = Mod_MD.Central_303_geral;
						FileSystem.FileGet(num2, ref valueType, -1L);
						ValueType valueType2 = valueType;
						Mod_MD.DADOS_EQUIP_MD_303_CONFIG_GERAL dados_EQUIP_MD_303_CONFIG_GERAL = default(Mod_MD.DADOS_EQUIP_MD_303_CONFIG_GERAL);
						Mod_MD.Central_303_geral = ((valueType2 != null) ? ((Mod_MD.DADOS_EQUIP_MD_303_CONFIG_GERAL)valueType2) : dados_EQUIP_MD_303_CONFIG_GERAL);
						FileSystem.FileClose(new int[]
						{
							1
						});
						num = Strings.Len(Mod_MD.Central_303_res[1]) * Mod_MD.NUM_MAX_RE + 50;
						FileSystem.FileOpen(1, text + "V332", (OpenMode)4, (OpenAccess)(-1), (OpenShare)(-1), num);
						int num3 = 1;
						Array array = Mod_MD.Central_303_res;
						FileSystem.FileGet(num3, ref array, -1L, false, false);
						Mod_MD.Central_303_res = (Mod_MD.DADOS_EQUIP_MD_303_CONFIG_RES[])array;
						FileSystem.FileClose(new int[]
						{
							1
						});
						num = Strings.Len(Mod_MD.Central_303_rq[1]) * Mod_MD.NUM_MAX_RQ + 200;
						FileSystem.FileOpen(1, text + "V333", (OpenMode)4, (OpenAccess)(-1), (OpenShare)(-1), num);
						int num4 = 1;
						array = Mod_MD.Central_303_rq;
						FileSystem.FileGet(num4, ref array, -1L, false, false);
						Mod_MD.Central_303_rq = (Mod_MD.DADOS_EQUIP_MD_303_CONFIG_RQ[])array;
						FileSystem.FileClose(new int[]
						{
							1
						});
					}
					this.Atualiza_dados_gerais_303();
					this.Atualiza_dados_re_303(Mod_MD.Central_303_geral.Qtd_equip_res);
					this.Atualiza_dados_rq_303(Mod_MD.Central_303_geral.Qdt_equip_rq);
				}
			}
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x004036D4 File Offset: 0x00401AD4
		[MethodImpl(72)]
		private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Mod_MD.Central_303_geral.Versao = Geral.Config_geral.Versao;
			this.SaveFileDialog1.Filter = "Arquivo de configuração de equipamento|*.V331";
			this.SaveFileDialog1.InitialDirectory = "c:\\";
			checked
			{
				if (this.SaveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					int num = Strings.InStr(1, this.SaveFileDialog1.FileName, ".", Microsoft.VisualBasic.CompareMethod.Text);
					string text = Strings.Left(this.SaveFileDialog1.FileName, num);
					if (Operators.CompareString(this.SaveFileDialog1.FileName, "", false) != 0)
					{
						num = Strings.Len(Mod_MD.Central_303_geral);
						FileSystem.FileOpen(1, this.SaveFileDialog1.FileName, (OpenMode)4, (OpenAccess)(-1), (OpenShare)(-1), num);
						FileSystem.FilePut(1, Mod_MD.Central_303_geral, -1L);
						FileSystem.FileClose(new int[]
						{
							1
						});
						num = Strings.Len(Mod_MD.Central_303_res[1]) * Mod_MD.NUM_MAX_RE + 50;
						FileSystem.FileOpen(1, text + "V332", (OpenMode)4, (OpenAccess)(-1), (OpenShare)(-1), num);
						FileSystem.FilePut(1, Mod_MD.Central_303_res, -1L, false, false);
						FileSystem.FileClose(new int[]
						{
							1
						});
						num = Strings.Len(Mod_MD.Central_303_rq[1]) * Mod_MD.NUM_MAX_RQ + 200;
						FileSystem.FileOpen(1, text + "V333", (OpenMode)4, (OpenAccess)(-1), (OpenShare)(-1), num);
						FileSystem.FilePut(1, Mod_MD.Central_303_rq, -1L, false, false);
						FileSystem.FileClose(new int[]
						{
							1
						});
					}
				}
			}
		}

		// Token: 0x04001808 RID: 6152
		[AccessedThroughProperty("Grupo_conf_comunicacao")]
		private GroupBox _Grupo_conf_comunicacao;

		// Token: 0x04001809 RID: 6153
		[AccessedThroughProperty("Valor_endereco_estacao")]
		private NumericUpDown _Valor_endereco_estacao;

		// Token: 0x0400180A RID: 6154
		[AccessedThroughProperty("Label_endereco_estacao")]
		private Label _Label_endereco_estacao;

		// Token: 0x0400180B RID: 6155
		[AccessedThroughProperty("Combo_baudrate")]
		private ComboBox _Combo_baudrate;

		// Token: 0x0400180C RID: 6156
		[AccessedThroughProperty("Label_baudrate")]
		private Label _Label_baudrate;

		// Token: 0x0400180D RID: 6157
		[AccessedThroughProperty("Valor_temp_ptt")]
		private NumericUpDown _Valor_temp_ptt;

		// Token: 0x0400180E RID: 6158
		[AccessedThroughProperty("Label_tempo_ptt")]
		private Label _Label_tempo_ptt;

		// Token: 0x0400180F RID: 6159
		[AccessedThroughProperty("Label_endereco_mestre")]
		private Label _Label_endereco_mestre;

		// Token: 0x04001810 RID: 6160
		[AccessedThroughProperty("Grupo_equipamentos")]
		private GroupBox _Grupo_equipamentos;

		// Token: 0x04001811 RID: 6161
		[AccessedThroughProperty("Valor_num_rq")]
		private NumericUpDown _Valor_num_rq;

		// Token: 0x04001812 RID: 6162
		[AccessedThroughProperty("Label_num_rq")]
		private Label _Label_num_rq;

		// Token: 0x04001813 RID: 6163
		[AccessedThroughProperty("Valor_num_res")]
		private NumericUpDown _Valor_num_res;

		// Token: 0x04001814 RID: 6164
		[AccessedThroughProperty("Label_num_res")]
		private Label _Label_num_res;

		// Token: 0x04001815 RID: 6165
		[AccessedThroughProperty("Grupo_lapelas")]
		private GroupBox _Grupo_lapelas;

		// Token: 0x04001816 RID: 6166
		[AccessedThroughProperty("TabControl_303")]
		private TabControl _TabControl_303;

		// Token: 0x04001817 RID: 6167
		[AccessedThroughProperty("Conf_res")]
		private TabPage _Conf_res;

		// Token: 0x04001818 RID: 6168
		[AccessedThroughProperty("DataGridView_RE_303")]
		private DataGridView _DataGridView_RE_303;

		// Token: 0x04001819 RID: 6169
		[AccessedThroughProperty("Conf_rq")]
		private TabPage _Conf_rq;

		// Token: 0x0400181A RID: 6170
		[AccessedThroughProperty("DataGridView_RQ_303")]
		private DataGridView _DataGridView_RQ_303;

		// Token: 0x0400181B RID: 6171
		[AccessedThroughProperty("Grupo_comandos")]
		private GroupBox _Grupo_comandos;

		// Token: 0x0400181C RID: 6172
		[AccessedThroughProperty("Esc_conf_md_303")]
		private Button _Esc_conf_md_303;

		// Token: 0x0400181D RID: 6173
		[AccessedThroughProperty("Box_Msg")]
		private TextBox _Box_Msg;

		// Token: 0x0400181E RID: 6174
		[AccessedThroughProperty("Ler_conf_md_303")]
		private Button _Ler_conf_md_303;

		// Token: 0x0400181F RID: 6175
		[AccessedThroughProperty("Col_end")]
		private DataGridViewTextBoxColumn _Col_end;

		// Token: 0x04001820 RID: 6176
		[AccessedThroughProperty("Col_nome")]
		private DataGridViewTextBoxColumn _Col_nome;

		// Token: 0x04001821 RID: 6177
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x04001822 RID: 6178
		[AccessedThroughProperty("ArquivoToolStripMenuItem")]
		private ToolStripMenuItem _ArquivoToolStripMenuItem;

		// Token: 0x04001823 RID: 6179
		[AccessedThroughProperty("NovoToolStripMenuItem")]
		private ToolStripMenuItem _NovoToolStripMenuItem;

		// Token: 0x04001824 RID: 6180
		[AccessedThroughProperty("AbrirToolStripMenuItem")]
		private ToolStripMenuItem _AbrirToolStripMenuItem;

		// Token: 0x04001825 RID: 6181
		[AccessedThroughProperty("SalvarToolStripMenuItem")]
		private ToolStripMenuItem _SalvarToolStripMenuItem;

		// Token: 0x04001826 RID: 6182
		[AccessedThroughProperty("Gupo_senha")]
		private GroupBox _Gupo_senha;

		// Token: 0x04001827 RID: 6183
		[AccessedThroughProperty("Valor_NumericUpDown_senha")]
		private NumericUpDown _Valor_NumericUpDown_senha;

		// Token: 0x04001828 RID: 6184
		[AccessedThroughProperty("Valor_endereco_mestre")]
		private NumericUpDown _Valor_endereco_mestre;

		// Token: 0x04001829 RID: 6185
		[AccessedThroughProperty("Col_End_rq")]
		private DataGridViewTextBoxColumn _Col_End_rq;

		// Token: 0x0400182A RID: 6186
		[AccessedThroughProperty("Col_nome_rq")]
		private DataGridViewTextBoxColumn _Col_nome_rq;

		// Token: 0x0400182B RID: 6187
		[AccessedThroughProperty("Col_mod_rq")]
		private DataGridViewComboBoxColumn _Col_mod_rq;

		// Token: 0x0400182C RID: 6188
		[AccessedThroughProperty("Col_hab")]
		private DataGridViewComboBoxColumn _Col_hab;

		// Token: 0x0400182D RID: 6189
		[AccessedThroughProperty("Col_Esc_1")]
		private DataGridViewTextBoxColumn _Col_Esc_1;

		// Token: 0x0400182E RID: 6190
		[AccessedThroughProperty("Col_Esc_2")]
		private DataGridViewTextBoxColumn _Col_Esc_2;

		// Token: 0x0400182F RID: 6191
		[AccessedThroughProperty("Col_Esc_3")]
		private DataGridViewTextBoxColumn _Col_Esc_3;

		// Token: 0x04001830 RID: 6192
		[AccessedThroughProperty("Col_Esc_4")]
		private DataGridViewTextBoxColumn _Col_Esc_4;

		// Token: 0x04001831 RID: 6193
		[AccessedThroughProperty("Col_Esc_5")]
		private DataGridViewTextBoxColumn _Col_Esc_5;

		// Token: 0x04001832 RID: 6194
		[AccessedThroughProperty("Col_Esc_6")]
		private DataGridViewTextBoxColumn _Col_Esc_6;

		// Token: 0x04001833 RID: 6195
		[AccessedThroughProperty("Col_Esc_7")]
		private DataGridViewTextBoxColumn _Col_Esc_7;

		// Token: 0x04001834 RID: 6196
		[AccessedThroughProperty("Col_Esc_8")]
		private DataGridViewTextBoxColumn _Col_Esc_8;

		// Token: 0x04001835 RID: 6197
		[AccessedThroughProperty("Col_Esc_9")]
		private DataGridViewTextBoxColumn _Col_Esc_9;

		// Token: 0x04001836 RID: 6198
		[AccessedThroughProperty("Col_Esc_10")]
		private DataGridViewTextBoxColumn _Col_Esc_10;

		// Token: 0x04001837 RID: 6199
		[AccessedThroughProperty("Col_Esc_11")]
		private DataGridViewTextBoxColumn _Col_Esc_11;

		// Token: 0x04001838 RID: 6200
		[AccessedThroughProperty("Col_Esc_12")]
		private DataGridViewTextBoxColumn _Col_Esc_12;

		// Token: 0x04001839 RID: 6201
		[AccessedThroughProperty("Col_Esc_13")]
		private DataGridViewTextBoxColumn _Col_Esc_13;

		// Token: 0x0400183A RID: 6202
		[AccessedThroughProperty("Col_Esc_14")]
		private DataGridViewTextBoxColumn _Col_Esc_14;

		// Token: 0x0400183B RID: 6203
		[AccessedThroughProperty("Col_Esc_15")]
		private DataGridViewTextBoxColumn _Col_Esc_15;

		// Token: 0x0400183C RID: 6204
		[AccessedThroughProperty("Col_Esc_16")]
		private DataGridViewTextBoxColumn _Col_Esc_16;

		// Token: 0x0400183D RID: 6205
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog _OpenFileDialog1;

		// Token: 0x0400183E RID: 6206
		[AccessedThroughProperty("SaveFileDialog1")]
		private SaveFileDialog _SaveFileDialog1;
	}
}
