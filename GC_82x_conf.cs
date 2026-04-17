using System;
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
	// Token: 0x0200003A RID: 58
	public partial class GC_82x_conf : Form
	{
		// Token: 0x06000C62 RID: 3170 RVA: 0x002F46A4 File Offset: 0x002F2AA4
		public GC_82x_conf()
		{
			base.Activated += new EventHandler(this.RT_810_conf_Activated);
			base.Load += new EventHandler(this.GC_82x_conf_Load);
			base.FormClosed += new FormClosedEventHandler(this.GC_82x_conf_FormClosed);
			this.InitializeComponent();
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x002F6174 File Offset: 0x002F4574
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x002F6188 File Offset: 0x002F4588
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

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x002F61D4 File Offset: 0x002F45D4
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x002F61E8 File Offset: 0x002F45E8
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

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x002F6234 File Offset: 0x002F4634
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x002F6248 File Offset: 0x002F4648
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

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x002F6294 File Offset: 0x002F4694
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x002F62A8 File Offset: 0x002F46A8
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

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x002F62B4 File Offset: 0x002F46B4
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x002F62C8 File Offset: 0x002F46C8
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

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x002F6314 File Offset: 0x002F4714
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x002F6328 File Offset: 0x002F4728
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

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x002F6374 File Offset: 0x002F4774
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x002F6388 File Offset: 0x002F4788
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

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x002F6394 File Offset: 0x002F4794
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x002F63A8 File Offset: 0x002F47A8
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

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x002F63B4 File Offset: 0x002F47B4
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x002F63C8 File Offset: 0x002F47C8
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

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x002F63D4 File Offset: 0x002F47D4
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x002F63E8 File Offset: 0x002F47E8
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

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x002F6434 File Offset: 0x002F4834
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x002F6448 File Offset: 0x002F4848
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

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x002F6454 File Offset: 0x002F4854
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x002F6468 File Offset: 0x002F4868
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

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x002F6474 File Offset: 0x002F4874
		// (set) Token: 0x06000C7E RID: 3198 RVA: 0x002F6488 File Offset: 0x002F4888
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

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x002F64D4 File Offset: 0x002F48D4
		// (set) Token: 0x06000C80 RID: 3200 RVA: 0x002F64E8 File Offset: 0x002F48E8
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

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x002F6534 File Offset: 0x002F4934
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x002F6548 File Offset: 0x002F4948
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

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x002F6554 File Offset: 0x002F4954
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x002F6568 File Offset: 0x002F4968
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

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x002F6600 File Offset: 0x002F4A00
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x002F6614 File Offset: 0x002F4A14
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

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x002F6620 File Offset: 0x002F4A20
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x002F6634 File Offset: 0x002F4A34
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

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x002F6640 File Offset: 0x002F4A40
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x002F6654 File Offset: 0x002F4A54
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

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x002F6660 File Offset: 0x002F4A60
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x002F6674 File Offset: 0x002F4A74
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

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x002F6680 File Offset: 0x002F4A80
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x002F6694 File Offset: 0x002F4A94
		internal virtual ToolStripButton ToolStripButton1
		{
			get
			{
				return this._ToolStripButton1;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripButton1 = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x002F66A0 File Offset: 0x002F4AA0
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x002F66B4 File Offset: 0x002F4AB4
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

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x002F6700 File Offset: 0x002F4B00
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x002F6714 File Offset: 0x002F4B14
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

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x002F6720 File Offset: 0x002F4B20
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x002F6734 File Offset: 0x002F4B34
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

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x002F6740 File Offset: 0x002F4B40
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x002F6754 File Offset: 0x002F4B54
		internal virtual TextBox TextBox_equipamento
		{
			get
			{
				return this._TextBox_equipamento;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox_equipamento_TextChanged);
				if (this._TextBox_equipamento != null)
				{
					this._TextBox_equipamento.TextChanged -= eventHandler;
				}
				this._TextBox_equipamento = value;
				if (this._TextBox_equipamento != null)
				{
					this._TextBox_equipamento.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x002F67A0 File Offset: 0x002F4BA0
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x002F67B4 File Offset: 0x002F4BB4
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

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x002F67C0 File Offset: 0x002F4BC0
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x002F67D4 File Offset: 0x002F4BD4
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

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x002F67E0 File Offset: 0x002F4BE0
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x002F67F4 File Offset: 0x002F4BF4
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

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x002F6800 File Offset: 0x002F4C00
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x002F6814 File Offset: 0x002F4C14
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

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x002F6820 File Offset: 0x002F4C20
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x002F6834 File Offset: 0x002F4C34
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

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x002F6840 File Offset: 0x002F4C40
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x002F6854 File Offset: 0x002F4C54
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

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x002F6860 File Offset: 0x002F4C60
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x002F6874 File Offset: 0x002F4C74
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

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x002F6880 File Offset: 0x002F4C80
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x002F6894 File Offset: 0x002F4C94
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

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x002F68A0 File Offset: 0x002F4CA0
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x002F68B4 File Offset: 0x002F4CB4
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

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x002F6900 File Offset: 0x002F4D00
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x002F6914 File Offset: 0x002F4D14
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

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x002F6920 File Offset: 0x002F4D20
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x002F6934 File Offset: 0x002F4D34
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

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x002F6940 File Offset: 0x002F4D40
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x002F6954 File Offset: 0x002F4D54
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

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x002F6960 File Offset: 0x002F4D60
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x002F6974 File Offset: 0x002F4D74
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

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x002F6980 File Offset: 0x002F4D80
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x002F6994 File Offset: 0x002F4D94
		internal virtual NumericUpDown lmt_2_20mA
		{
			get
			{
				return this._lmt_2_20mA;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.lmt_2_20mA_ValueChanged_1);
				if (this._lmt_2_20mA != null)
				{
					this._lmt_2_20mA.ValueChanged -= eventHandler;
				}
				this._lmt_2_20mA = value;
				if (this._lmt_2_20mA != null)
				{
					this._lmt_2_20mA.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x002F69E0 File Offset: 0x002F4DE0
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x002F69F4 File Offset: 0x002F4DF4
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

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x002F6A00 File Offset: 0x002F4E00
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x002F6A14 File Offset: 0x002F4E14
		internal virtual NumericUpDown lmt_2_4mA
		{
			get
			{
				return this._lmt_2_4mA;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.lmt_2_4mA_ValueChanged_1);
				if (this._lmt_2_4mA != null)
				{
					this._lmt_2_4mA.ValueChanged -= eventHandler;
				}
				this._lmt_2_4mA = value;
				if (this._lmt_2_4mA != null)
				{
					this._lmt_2_4mA.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x002F6A60 File Offset: 0x002F4E60
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x002F6A74 File Offset: 0x002F4E74
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

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x002F6A80 File Offset: 0x002F4E80
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x002F6A94 File Offset: 0x002F4E94
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

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x002F6AA0 File Offset: 0x002F4EA0
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x002F6AB4 File Offset: 0x002F4EB4
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

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x002F6AC0 File Offset: 0x002F4EC0
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x002F6AD4 File Offset: 0x002F4ED4
		internal virtual NumericUpDown lmt_1_20mA
		{
			get
			{
				return this._lmt_1_20mA;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.lmt_1_20mA_ValueChanged_1);
				if (this._lmt_1_20mA != null)
				{
					this._lmt_1_20mA.ValueChanged -= eventHandler;
				}
				this._lmt_1_20mA = value;
				if (this._lmt_1_20mA != null)
				{
					this._lmt_1_20mA.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x002F6B20 File Offset: 0x002F4F20
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x002F6B34 File Offset: 0x002F4F34
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

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x002F6B40 File Offset: 0x002F4F40
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x002F6B54 File Offset: 0x002F4F54
		internal virtual NumericUpDown lmt_1_4mA
		{
			get
			{
				return this._lmt_1_4mA;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.lmt_1_4mA_ValueChanged_1);
				if (this._lmt_1_4mA != null)
				{
					this._lmt_1_4mA.ValueChanged -= eventHandler;
				}
				this._lmt_1_4mA = value;
				if (this._lmt_1_4mA != null)
				{
					this._lmt_1_4mA.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x002F6BA0 File Offset: 0x002F4FA0
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x002F6BB4 File Offset: 0x002F4FB4
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

		// Token: 0x06000CC5 RID: 3269 RVA: 0x002F6BC0 File Offset: 0x002F4FC0
		private void AtivaEfeitoOnChangeValue()
		{
			this.ToolStri_RT_810.Enabled = false;
			this.ToolStri_RT_810.Enabled = true;
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x002F6BDC File Offset: 0x002F4FDC
		public void Cria_ListaBaudRate()
		{
			perifericos.ListaBaudRate.Clear();
			perifericos.ListaBaudRate.Add(new perifericos.Valores_ComboBox("1200", "1200", 21856, false));
			perifericos.ListaBaudRate.Add(new perifericos.Valores_ComboBox("9600", "9600", 21857, true));
			perifericos.ListaBaudRate.Add(new perifericos.Valores_ComboBox("19200", "19200", 21858, false));
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x002F6C50 File Offset: 0x002F5050
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

		// Token: 0x06000CC8 RID: 3272 RVA: 0x002F6CBC File Offset: 0x002F50BC
		private void GC_82x_conf_Load(object sender, EventArgs e)
		{
			RT_geral.Lmte_Init_ok = false;
			this.Inicializa_DadosEStruturaGC_82x_Padrao();
			this.NumericUpDown_end_est.Minimum = 0m;
			this.NumericUpDown_end_est.Maximum = 207m;
			this.lmt_1_4mA.Minimum = 0m;
			this.lmt_1_4mA.Maximum = 4000m;
			this.lmt_2_4mA.Minimum = 0m;
			this.lmt_2_4mA.Maximum = 4000m;
			this.lmt_1_20mA.Minimum = 0m;
			this.lmt_1_20mA.Maximum = 4000m;
			this.lmt_2_20mA.Minimum = 0m;
			this.lmt_2_20mA.Maximum = 4000m;
			RT_geral.Lmte_Init_ok = true;
			this.Inicializa_DadosEStruturaGC_82x_Default();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			this.TabPage_geral.BackColor = Color.FromKnownColor((System.Drawing.KnownColor)8);
			this.TabPage_geral.ForeColor = Color.FromKnownColor((System.Drawing.KnownColor)10);
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
			this.Atualiza_TelaGC82x();
			this.ToolStripLabel_ID.Text = RT_geral.MontaNomePlacaPeloFabricante(RT_geral.GC_82x_BD.Equip.Valor, RT_geral.GC_82x_BD.Versao.Valor);
			RT_geral.Lmte_Init_ok = true;
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x002F6EB8 File Offset: 0x002F52B8
		private void RT_810_conf_Activated(object sender, EventArgs e)
		{
			Geral.Equipamento_selecionado = this.QualModelo;
			Geral.Equipamento_versao = 3;
			Geral.Equipamento_build = 0;
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x002F6ED4 File Offset: 0x002F52D4
		private void GeraDataGridView_Processos_RT_810()
		{
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x002F6ED8 File Offset: 0x002F52D8
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
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].TagColuna = "Retorno";
				RT_geral.RT_810_DataGrigViewProcessosColunas[2].TagColuna = "Remoto";
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].TagColuna = "Reverso";
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].TagColuna = "Modo";
				RT_geral.RT_810_DataGrigViewProcessosColunas[5].TagColuna = "Tempo Partida (s)";
				RT_geral.RT_810_DataGrigViewProcessosColunas[6].TagColuna = "Tempo Parada (s)";
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
				RT_geral.RT_810_DataGrigViewProcessosColunas[5].LarguraColuna = 80;
				RT_geral.RT_810_DataGrigViewProcessosColunas[6].LarguraColuna = 80;
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].AlingColuna = 32;
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].AlingColuna = 32;
				RT_geral.RT_810_DataGrigViewProcessosColunas[2].AlingColuna = 32;
				RT_geral.RT_810_DataGrigViewProcessosColunas[3].AlingColuna = 32;
				RT_geral.RT_810_DataGrigViewProcessosColunas[4].AlingColuna = 32;
				RT_geral.RT_810_DataGrigViewProcessosColunas[5].AlingColuna = 64;
				RT_geral.RT_810_DataGrigViewProcessosColunas[6].AlingColuna = 64;
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].NumeroLinhaMenu = 2;
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].LinhasMenu[0] = "Desativo";
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].LinhasMenu[1] = "SD - 01";
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_810_DataGrigViewProcessosColunas[0].LinhasValor[1] = 21857;
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].NumeroLinhaMenu = 9;
				RT_geral.RT_810_DataGrigViewProcessosColunas[1].LinhasMenu[0] = "Não usado";
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

		// Token: 0x06000CCC RID: 3276 RVA: 0x002F73C0 File Offset: 0x002F57C0
		private void GeraDataGridView_EA_RT_810()
		{
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x002F73C4 File Offset: 0x002F57C4
		private void InicializaEstrutura_DataGridView_EA_RT_810()
		{
			RT_geral.RT_810_DataGrigViewEAColunas[0].TagColuna = "Range";
			RT_geral.RT_810_DataGrigViewEAColunas[1].TagColuna = "Início";
			RT_geral.RT_810_DataGrigViewEAColunas[2].TagColuna = "Fim";
			RT_geral.RT_810_DataGrigViewEAColunas[0].NomeColuna = "range";
			RT_geral.RT_810_DataGrigViewEAColunas[1].NomeColuna = "ini";
			RT_geral.RT_810_DataGrigViewEAColunas[2].NomeColuna = "fim";
			RT_geral.RT_810_DataGrigViewEAColunas[0].LarguraColuna = 90;
			RT_geral.RT_810_DataGrigViewEAColunas[1].LarguraColuna = 90;
			RT_geral.RT_810_DataGrigViewEAColunas[2].LarguraColuna = 90;
			RT_geral.RT_810_DataGrigViewEAColunas[0].AlingColuna = 64;
			RT_geral.RT_810_DataGrigViewEAColunas[1].AlingColuna = 64;
			RT_geral.RT_810_DataGrigViewEAColunas[2].AlingColuna = 64;
			RT_geral.RT_810_DataGrigViewEAColunas[0].NumeroLinhaMenu = 0;
			RT_geral.RT_810_DataGrigViewEAColunas[1].NumeroLinhaMenu = 0;
			RT_geral.RT_810_DataGrigViewEAColunas[2].NumeroLinhaMenu = 0;
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x002F74F0 File Offset: 0x002F58F0
		private void GeraDataGridView_Repedidora_RT_810()
		{
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x002F74F4 File Offset: 0x002F58F4
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
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[0].AlingColuna = 32;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[1].AlingColuna = 64;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[2].AlingColuna = 32;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[3].AlingColuna = 64;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[4].AlingColuna = 32;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[5].AlingColuna = 64;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[6].AlingColuna = 32;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[7].AlingColuna = 64;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[8].AlingColuna = 32;
			RT_geral.RT_810_DataGrigViewRepetidoraColunas[9].AlingColuna = 64;
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x002F7814 File Offset: 0x002F5C14
		private void GeraDataGridView_Setpoints_RT_810()
		{
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x002F7818 File Offset: 0x002F5C18
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
				RT_geral.RT_810_DataGrigViewSetpointsColunas[2].TagColuna = "Alto";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[1].TagColuna = "Baixo";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].TagColuna = "Controle";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[2].NomeColuna = "Set_NAlto";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[1].NomeColuna = "Set_NBaixo";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].NomeColuna = "Set_Controle";
				RT_geral.RT_810_DataGrigViewSetpointsColunas[2].LarguraColuna = 60;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[1].LarguraColuna = 60;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LarguraColuna = 160;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[2].AlingColuna = 64;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[1].AlingColuna = 64;
				RT_geral.RT_810_DataGrigViewSetpointsColunas[0].AlingColuna = 32;
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
					RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LinhasMenu[num] = "Referência " + Strings.Format(num - 4, "#");
					RT_geral.RT_810_DataGrigViewSetpointsColunas[0].LinhasValor[num] = 21868 + num;
					num++;
				}
				while (num <= 8);
			}
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x002F7A4C File Offset: 0x002F5E4C
		private void GeraDataGridView_ED_RT_810()
		{
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x002F7A50 File Offset: 0x002F5E50
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
				RT_geral.RT_810_DataGrigViewEDColunas[0].AlingColuna = 32;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[1] = 21969;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[2] = 21970;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[3] = 21971;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[4] = 21972;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[5] = 21973;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasValor[6] = 21974;
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[0] = "Sem função";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[1] = "Arrombamento";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[2] = "Falta de fase";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[3] = "Alagamento";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[4] = "Horário de ponta";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[5] = "Transbordo";
				RT_geral.RT_810_DataGrigViewEDColunas[0].LinhasMenu[6] = "Operação em bateira";
				RT_geral.RT_810_DataGrigViewEDColunas[0].NumeroLinhaMenu = 7;
			}
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x002F7C3C File Offset: 0x002F603C
		public void Inicializa_DadosEStruturaGC_82x_Padrao()
		{
			RT_geral.GC_82x_BD.Equip.nome = "Tipo equipamento";
			RT_geral.GC_82x_BD.Equip.Padrao = Geral.Equipamento_selecionado;
			RT_geral.GC_82x_BD.Equip.Valor = Geral.Equipamento_selecionado;
			RT_geral.GC_82x_BD.Build.nome = "Build";
			RT_geral.GC_82x_BD.Build.Padrao = 0;
			RT_geral.GC_82x_BD.Versao.nome = "Versão";
			RT_geral.GC_82x_BD.Versao.Padrao = 0;
			RT_geral.GC_82x_BD.Release.nome = "Release";
			RT_geral.GC_82x_BD.Release.Padrao = 0;
			RT_geral.GC_82x_BD.modo_SD1.Valor = 0;
			RT_geral.GC_82x_BD.modo_SD2.Valor = 0;
			RT_geral.GC_82x_BD.modo_SD3.Valor = 0;
			RT_geral.GC_82x_BD.sentido_SD1.Valor = 0;
			RT_geral.GC_82x_BD.sentido_SD2.Valor = 0;
			RT_geral.GC_82x_BD.sentido_SD3.Valor = 0;
			RT_geral.GC_82x_BD.liga_SD1.Valor = 0;
			RT_geral.GC_82x_BD.liga_SD2.Valor = 0;
			RT_geral.GC_82x_BD.liga_SD3.Valor = 0;
			RT_geral.GC_82x_BD.desliga_SD1.Valor = 0;
			RT_geral.GC_82x_BD.desliga_SD2.Valor = 0;
			RT_geral.GC_82x_BD.desliga_SD3.Valor = 0;
			RT_geral.GC_82x_BD.AD_Intervalo.Valor = 0;
			RT_geral.GC_82x_BD.AD_Tamanho_filtro.Valor = 0;
			RT_geral.GC_82x_BD.End_estacao.nome = "Endereço Estação";
			RT_geral.GC_82x_BD.End_estacao.Padrao = 1;
			RT_geral.GC_82x_BD.End_estacao.Lmte_inf = 0;
			RT_geral.GC_82x_BD.End_estacao.Lmte_sup = 200;
			RT_geral.GC_82x_BD.End_mestre.nome = "Endereço Mestre";
			RT_geral.GC_82x_BD.End_mestre.Padrao = 100;
			RT_geral.GC_82x_BD.End_mestre.Lmte_inf = 1;
			RT_geral.GC_82x_BD.End_mestre.Lmte_sup = 200;
			RT_geral.GC_82x_BD.modo_SA1.nome = "Modo SD1";
			RT_geral.GC_82x_BD.modo_SA1.Padrao = 21937;
			RT_geral.GC_82x_BD.modo_SA1.Lmte_inf = 21937;
			RT_geral.GC_82x_BD.modo_SA1.Lmte_sup = 21937;
			RT_geral.GC_82x_BD.limt_inferior1.nome = "4mA Ch1";
			RT_geral.GC_82x_BD.limt_inferior1.Padrao = 0;
			RT_geral.GC_82x_BD.limt_inferior1.Lmte_inf = 0;
			RT_geral.GC_82x_BD.limt_inferior1.Lmte_sup = 4000;
			RT_geral.GC_82x_BD.limt_superior1.nome = "20mA Ch1";
			RT_geral.GC_82x_BD.limt_superior1.Padrao = 4000;
			RT_geral.GC_82x_BD.limt_superior1.Lmte_inf = 0;
			RT_geral.GC_82x_BD.limt_superior1.Lmte_sup = 4000;
			RT_geral.GC_82x_BD.modo_SA2.nome = "Modo SD2";
			RT_geral.GC_82x_BD.modo_SA2.Padrao = 21937;
			RT_geral.GC_82x_BD.modo_SA2.Lmte_inf = 21937;
			RT_geral.GC_82x_BD.modo_SA2.Lmte_sup = 21937;
			RT_geral.GC_82x_BD.limt_inferior2.nome = "4mA Ch2";
			RT_geral.GC_82x_BD.limt_inferior2.Padrao = 0;
			RT_geral.GC_82x_BD.limt_inferior2.Lmte_inf = 0;
			RT_geral.GC_82x_BD.limt_inferior2.Lmte_sup = 4000;
			RT_geral.GC_82x_BD.limt_superior2.nome = "20mA Ch2";
			RT_geral.GC_82x_BD.limt_superior2.Padrao = 4000;
			RT_geral.GC_82x_BD.limt_superior2.Lmte_inf = 0;
			RT_geral.GC_82x_BD.limt_superior2.Lmte_sup = 4000;
			RT_geral.GC_82x_BD.filename = "";
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x002F803C File Offset: 0x002F643C
		public void Inicializa_DadosEStruturaGC_82x_Default()
		{
			RT_geral.GC_82x_BD.Equip.Valor = RT_geral.GC_82x_BD.Equip.Padrao;
			RT_geral.GC_82x_BD.Versao.Valor = RT_geral.GC_82x_BD.Versao.Padrao;
			RT_geral.GC_82x_BD.Build.Valor = RT_geral.GC_82x_BD.Build.Padrao;
			RT_geral.GC_82x_BD.Release.Valor = RT_geral.GC_82x_BD.Release.Padrao;
			RT_geral.GC_82x_BD.End_estacao.ValorPadrao();
			RT_geral.GC_82x_BD.End_mestre.ValorPadrao();
			RT_geral.GC_82x_BD.modo_SA1.ValorPadrao();
			RT_geral.GC_82x_BD.limt_inferior1.ValorPadrao();
			RT_geral.GC_82x_BD.limt_superior1.ValorPadrao();
			RT_geral.GC_82x_BD.modo_SA2.ValorPadrao();
			RT_geral.GC_82x_BD.limt_inferior2.ValorPadrao();
			RT_geral.GC_82x_BD.limt_superior2.ValorPadrao();
			RT_geral.GC_82x_BD.AD_Intervalo.ValorPadrao();
			RT_geral.GC_82x_BD.AD_Tamanho_filtro.ValorPadrao();
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x002F8158 File Offset: 0x002F6558
		public void Atualiza_TelaGC82x()
		{
			int num = 0;
			int num2 = 0;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				this.Libera_acoes();
				this.NumericUpDown_end_est.Minimum = new decimal(RT_geral.GC_82x_BD.End_estacao.Lmte_inf);
				this.NumericUpDown_end_est.Maximum = new decimal(RT_geral.GC_82x_BD.End_estacao.Lmte_sup);
				this.NumericUpDown_end_est.Value = new decimal(RT_geral.GC_82x_BD.End_estacao.Valor);
				this.TextBox_equipamento.Text = Conversions.ToString(RT_geral.GC_82x_BD.Equip.Valor);
				this.TextBox_versao.Text = Conversions.ToString(RT_geral.GC_82x_BD.Versao.Valor);
				this.TextBox_build.Text = Conversions.ToString(RT_geral.GC_82x_BD.Build.Valor);
				this.TextBox_release.Text = Conversions.ToString(RT_geral.GC_82x_BD.Release.Valor);
				this.lmt_1_4mA.Value = new decimal(RT_geral.GC_82x_BD.limt_inferior1.Valor);
				this.lmt_1_20mA.Value = new decimal(RT_geral.GC_82x_BD.limt_superior1.Valor);
				this.lmt_2_4mA.Value = new decimal(RT_geral.GC_82x_BD.limt_inferior2.Valor);
				this.lmt_2_20mA.Value = new decimal(RT_geral.GC_82x_BD.limt_superior2.Valor);
				goto IL_1B9;
				IL_164:
				Interaction.MsgBox("Erro na atualização da tela!", MsgBoxStyle.Question, "Atenção - Erro de dados");
				goto IL_1B9;
				IL_178:
				num2 = -1;
				throw new InvalidOperationException("Decompiler switch pattern not reconstructed.");
				IL_18C:;
			}
			catch (Exception)
			{
				throw;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1B9:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x002F8344 File Offset: 0x002F6744
		public void Habilita_Funcoes_de_Tela_RT_810(int tipo)
		{
			this.GroupBox_comunicacao.Enabled = true;
			this.GroupBox_informacoes.Enabled = false;
			switch (tipo)
			{
			case 0:
				this.GroupBox_informacoes.Enabled = true;
				break;
			}
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x002F838C File Offset: 0x002F678C
		public void RT_810_Atualiza_Parametros_EA(int tipo)
		{
			int num = 0;
			if (tipo == 0)
			{
				num = 3;
			}
			else
			{
				num = 0;
			}
			int num2 = 0;
			int num3 = Convert.ToInt32(num);
			checked
			{
				for (int i = num2; i <= num3; i++)
				{
				}
			}
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x002F83BC File Offset: 0x002F67BC
		public void RT_810_Habilita_Pto_a_Pto(int modo)
		{
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x002F83C0 File Offset: 0x002F67C0
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

		// Token: 0x06000CDB RID: 3291 RVA: 0x002F8424 File Offset: 0x002F6824
		public void EncerraEdicaoDeCampos()
		{
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x002F8428 File Offset: 0x002F6828
		public void Bloqueia_acoes()
		{
			this.ToolStripButton_RT_810_Abrir.Enabled = false;
			this.ToolStripButton_RT_810_novo.Enabled = false;
			this.ToolStripButton_RT_810_Salvar.Enabled = false;
			this.ToolStripButton_RT_810_Download.Enabled = false;
			this.ToolStripButton_RT_810_Upload.Enabled = false;
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x002F8468 File Offset: 0x002F6868
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

		// Token: 0x06000CDE RID: 3294 RVA: 0x002F84D8 File Offset: 0x002F68D8
		public void InicializaBarraProgressoTela_RT_810(int num_passos)
		{
			this.ToolStripProgressBar_RT_810.Minimum = 0;
			this.ToolStripProgressBar_RT_810.Maximum = checked(num_passos * 4);
			this.ToolStripProgressBar_RT_810.Step = num_passos;
			this.ToolStripProgressBar_RT_810.Value = 0;
			this.ToolStripProgressBar_RT_810.BackColor = Color.LightGray;
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x002F8528 File Offset: 0x002F6928
		private void Timer_limpa_MSG_Tick(object sender, EventArgs e)
		{
			this.Timer_limpa_MSG.Enabled = false;
			this.AtualizaMsgTela_RT_810("", 0);
			this.ToolStripProgressBar_RT_810.Value = 0;
			this.Libera_acoes();
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x002F8554 File Offset: 0x002F6954
		private void CheckBox_hab_eletrodos_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x002F8558 File Offset: 0x002F6958
		private void ComboBox_metodo_operacao_Validating(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x002F855C File Offset: 0x002F695C
		private void ComboBox_metodo_operacao_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x002F8560 File Offset: 0x002F6960
		private void ComboBox_modo_repeticao_RT_810_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x002F8564 File Offset: 0x002F6964
		private void ComboBox_modo_simulado_810_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x002F8568 File Offset: 0x002F6968
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

		// Token: 0x06000CE6 RID: 3302 RVA: 0x002F864C File Offset: 0x002F6A4C
		private void NumericUpDown_intervalo_tx_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x002F8650 File Offset: 0x002F6A50
		private void NumericUpDown_temp_ptt_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x002F8654 File Offset: 0x002F6A54
		private void NumericUpDown_end_mestre_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.GC_82x_BD.End_mestre.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.GC_82x_BD.End_mestre, true);
			sender = numericUpDown;
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x002F86A8 File Offset: 0x002F6AA8
		private void NumericUpDown_end_est_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.GC_82x_BD.End_estacao.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.GC_82x_BD.End_estacao, true);
			sender = numericUpDown;
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x002F86FC File Offset: 0x002F6AFC
		private void NumericUpDown_intervalo_filtro_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x002F8700 File Offset: 0x002F6B00
		private void NumericUpDown_tamanho_filtro_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x002F8704 File Offset: 0x002F6B04
		private void NumericUpDown_end_rep_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x002F8708 File Offset: 0x002F6B08
		private void NumericUpDown_num_est_rep_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x002F870C File Offset: 0x002F6B0C
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

		// Token: 0x06000CEF RID: 3311 RVA: 0x002F8764 File Offset: 0x002F6B64
		private void RT_810_conf_FormClosed(object sender, FormClosedEventArgs e)
		{
			RT_geral.Telas_RT_810.Configuracao = false;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x002F8774 File Offset: 0x002F6B74
		private bool Endereco_Repetidora_Ja_Existente(ref DataGridView obj, ref RT_geral.Integer_ictel dado, DataGridViewCellValidatingEventArgs e, int posicao)
		{
			checked
			{
				if (dado.Valor != 0)
				{
					int num = 0;
					while (posicao == num || RT_geral.RT_810_BD.Repetidoras[num].Valor != dado.Valor)
					{
						num++;
						if (num > 49)
						{
							goto IL_A2;
						}
					}
					obj.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
					Interaction.MsgBox(Operators.AddObject(Operators.AddObject("Endereço : ", e.FormattedValue), " já existe"), 32, "Erro na entrada de dados");
					dado.erro = true;
					return true;
				}
				IL_A2:
				obj.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
				dado.erro = false;
				return false;
			}
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x002F8860 File Offset: 0x002F6C60
		public void Leitura_GC_82x_conf()
		{
			this.InicializaBarraProgressoTela_RT_810(3);
			this.AtualizaMsgTela_RT_810("Identificando equipamento - Passo 1", 2);
			if (!Mod_MD.Leitura_pagina(0, 255, 4).Status)
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
			Linha_RT.Atualiza_dados_GC_82x(0);
			this.AtualizaMsgTela_RT_810("Leitura de configuração - Passo 2", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			if (!Mod_MD.Leitura_pagina(2048, 255, 22).Status)
			{
				this.AtualizaMsgTela_RT_810("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_GC_82x(2048);
			this.Atualiza_TelaGC82x();
			this.AtualizaMsgTela_RT_810("Configuração lida com sucesso", 0);
			this.ToolStripProgressBar_RT_810.PerformStep();
			this.Timer_limpa_MSG.Enabled = true;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x002F895C File Offset: 0x002F6D5C
		public void Gravar_GC_82x_conf()
		{
			this.InicializaBarraProgressoTela_RT_810(2);
			this.AtualizaMsgTela_RT_810("Verificando equipamento - Passo 1", 2);
			this.ToolStripProgressBar_RT_810.PerformStep();
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Leitura_pagina(0, 255, 12);
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_810("Equipamento não responde", 1);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			if (!Linha_RT.VerificaSeEquipamento_GC_82x(2, 0, 0, ""))
			{
				this.AtualizaMsgTela_RT_810("Equipamento inválido", ctrl_RESP_.Cor);
				this.Timer_limpa_MSG.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_GC_82x(0);
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
			if (!Mod_MD.Escrita_pagina(2048, 70).Status)
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

		// Token: 0x06000CF3 RID: 3315 RVA: 0x002F8ABC File Offset: 0x002F6EBC
		private void ToolStripButton_RT_810_Download_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.Bloqueia_acoes();
				this.EncerraEdicaoDeCampos();
				this.Leitura_GC_82x_conf();
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", MsgBoxStyle.Critical, "Atenção");
			}
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x002F8AF4 File Offset: 0x002F6EF4
		private void ToolStripButton_RT_810_novo_Click(object sender, EventArgs e)
		{
			RT_geral.Lmte_Init_ok = false;
			this.AtivaEfeitoOnChangeValue();
			this.Inicializa_DadosEStruturaGC_82x_Padrao();
			this.Inicializa_DadosEStruturaGC_82x_Default();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			RT_geral.GC_82x_BD.filename = "";
			this.Atualiza_TelaGC82x();
			RT_geral.Lmte_Init_ok = true;
			this.AtualizaMsgTela_RT_810("Valores Default carregados", 0);
			this.Timer_limpa_MSG.Enabled = true;
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x002F8B5C File Offset: 0x002F6F5C
		private void ToolStripButton_RT_810_Upload_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.Bloqueia_acoes();
				this.EncerraEdicaoDeCampos();
				if (!RT_geral.VerificaExistenciaErroDados_GC_82x())
				{
					this.Gravar_GC_82x_conf();
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

		// Token: 0x06000CF6 RID: 3318 RVA: 0x002F8BD4 File Offset: 0x002F6FD4
		[MethodImpl(72)]
		private void ToolStripButton_RT_810_Abrir_Click(object sender, EventArgs e)
		{
			int num = 0;
			int num2 = 0;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				this.AtivaEfeitoOnChangeValue();
				this.SaveFileDialog_RT_810.Filter = "Arquivo de configuração de equipamento|*.CfgGC82x";
				this.OpenFileDialog_RT_810.InitialDirectory = Linha_RT.diretorio;
				if (this.OpenFileDialog_RT_810.ShowDialog() == System.Windows.Forms.DialogResult.OK && Operators.CompareString(this.OpenFileDialog_RT_810.FileName, "", false) != 0)
				{
					Linha_RT.diretorio = Path.GetDirectoryName(this.OpenFileDialog_RT_810.FileName) + "\\";
					RT_geral.arquivo_extensao = Path.GetExtension(this.OpenFileDialog_RT_810.FileName);
					IniFile iniFile = new IniFile(this.OpenFileDialog_RT_810.FileName);
					RT_geral.GC_82x_BD.Equip.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "EQUIPAMENTO", 0);
					RT_geral.GC_82x_BD.Versao.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "VERSAO", 0);
					RT_geral.GC_82x_BD.Build.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "BUILD", 0);
					RT_geral.GC_82x_BD.Release.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "RELEASE", 0);
					if (!Linha_RT.VerificaSeEquipamento_GC_82x(1, RT_geral.GC_82x_BD.Equip.Valor, RT_geral.GC_82x_BD.Versao.Valor, RT_geral.arquivo_extensao))
					{
						RT_geral.Lmte_Init_ok = false;
						this.Inicializa_DadosEStruturaGC_82x_Padrao();
						this.Inicializa_DadosEStruturaGC_82x_Default();
						Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
						this.Atualiza_TelaGC82x();
						RT_geral.Lmte_Init_ok = true;
						this.AtualizaMsgTela_RT_810("Valores Default carregados", 0);
						this.Timer_limpa_MSG.Enabled = true;
						goto IL_36B;
					}
					RT_geral.GC_82x_BD.filename = this.OpenFileDialog_RT_810.FileName;
					RT_geral.GC_82x_BD.End_estacao.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "ESTACAO", 0);
					RT_geral.GC_82x_BD.modo_SA1.Valor = iniFile.ReadInteger("MODO_OPERCAO_SA1", "MODO", 0);
					RT_geral.GC_82x_BD.limt_inferior1.Valor = iniFile.ReadInteger("MODO_OPERCAO_SA1", "LIMITE_INFERIOR", 0);
					RT_geral.GC_82x_BD.limt_superior1.Valor = iniFile.ReadInteger("MODO_OPERCAO_SA1", "LIMITE_SUPERIOR", 4000);
					RT_geral.GC_82x_BD.modo_SA2.Valor = iniFile.ReadInteger("MODO_OPERCAO_SA2", "MODO", 0);
					RT_geral.GC_82x_BD.limt_inferior2.Valor = iniFile.ReadInteger("MODO_OPERCAO_SA2", "LIMITE_INFERIOR", 0);
					RT_geral.GC_82x_BD.limt_superior2.Valor = iniFile.ReadInteger("MODO_OPERCAO_SA2", "LIMITE_SUPERIOR", 4000);
					RT_geral.GC_82x_BD.AD_Intervalo.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "INTERVALO", 0);
					RT_geral.GC_82x_BD.AD_Tamanho_filtro.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "TAMANHO_FILTRO", 0);
					this.Atualiza_TelaGC82x();
					this.AtualizaMsgTela_RT_810("Arquivo carregado com sucesso!", 0);
				}
				this.Timer_limpa_MSG.Enabled = true;
				goto IL_36B;
				IL_2F2:
				Interaction.MsgBox("Não foi possível carregar os dados", MsgBoxStyle.Question, "Atenção - Erro I/0");
				FileSystem.FileClose(new int[]
				{
					1
				});
				this.Timer_limpa_MSG.Enabled = true;
				goto IL_36B;
				IL_326:
				num2 = -1;
				throw new InvalidOperationException("Decompiler switch pattern not reconstructed.");
				IL_33C:;
			}
			catch (Exception)
			{
				throw;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			IL_36B:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x002F8F74 File Offset: 0x002F7374
		[MethodImpl(72)]
		private void ToolStripButton_RT_810_Salvar_Click(object sender, EventArgs e)
		{
			int num = 0;
			int num2 = 0;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				this.AtivaEfeitoOnChangeValue();
				this.Bloqueia_acoes();
				this.SaveFileDialog_RT_810.Filter = "Arquivo de configuração de equipamento|*.CfgGC82x";
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
					RT_geral.GC_82x_BD.filename = this.SaveFileDialog_RT_810.FileName;
					this.InicializaBarraProgressoTela_RT_810(5);
					IniFileWriteFast iniFileWriteFast = new IniFileWriteFast(this.SaveFileDialog_RT_810.FileName);
					iniFileWriteFast.WriteSection("GERAL_INFORMACAO");
					iniFileWriteFast.WriteKey("EQUIPAMENTO", RT_geral.GC_82x_BD.Equip.Valor);
					iniFileWriteFast.WriteKey("VERSAO", RT_geral.GC_82x_BD.Versao.Valor);
					iniFileWriteFast.WriteKey("BUILD", RT_geral.GC_82x_BD.Build.Valor);
					iniFileWriteFast.WriteKey("RELEASE", RT_geral.GC_82x_BD.Release.Valor);
					iniFileWriteFast.LineSpace();
					this.ToolStripProgressBar_RT_810.PerformStep();
					Application.DoEvents();
					iniFileWriteFast.WriteSection("GERAL_PARAM_COMINICACAO");
					iniFileWriteFast.WriteKey("ESTACAO", RT_geral.GC_82x_BD.End_estacao.Valor);
					iniFileWriteFast.LineSpace();
					this.ToolStripProgressBar_RT_810.PerformStep();
					Application.DoEvents();
					iniFileWriteFast.WriteSection("MODO_OPERCAO_SA1");
					iniFileWriteFast.WriteKey("MODO", RT_geral.GC_82x_BD.modo_SA1.Valor);
					iniFileWriteFast.WriteKey("LIMITE_INFERIOR", RT_geral.GC_82x_BD.limt_inferior1.Valor);
					iniFileWriteFast.WriteKey("LIMITE_SUPERIOR", RT_geral.GC_82x_BD.limt_superior1.Valor);
					iniFileWriteFast.LineSpace();
					this.ToolStripProgressBar_RT_810.PerformStep();
					Application.DoEvents();
					iniFileWriteFast.WriteSection("MODO_OPERCAO_SA2");
					iniFileWriteFast.WriteKey("MODO", RT_geral.GC_82x_BD.modo_SA2.Valor);
					iniFileWriteFast.WriteKey("LIMITE_INFERIOR", RT_geral.GC_82x_BD.limt_inferior2.Valor);
					iniFileWriteFast.WriteKey("LIMITE_SUPERIOR", RT_geral.GC_82x_BD.limt_superior2.Valor);
					iniFileWriteFast.LineSpace();
					this.ToolStripProgressBar_RT_810.PerformStep();
					Application.DoEvents();
					iniFileWriteFast.WriteSection("ENTRADA_ANALOGICA");
					iniFileWriteFast.WriteKey("INTERVALO", RT_geral.GC_82x_BD.AD_Intervalo.Valor);
					iniFileWriteFast.WriteKey("TAMANHO_FILTRO", RT_geral.GC_82x_BD.AD_Tamanho_filtro.Valor);
					iniFileWriteFast.LineSpace();
					this.ToolStripProgressBar_RT_810.PerformStep();
					Application.DoEvents();
					this.AtualizaMsgTela_RT_810("Arquivo gerado com sucesso!", 0);
					this.Timer_limpa_MSG.Enabled = true;
				}
				this.Timer_limpa_MSG.Enabled = true;
				goto IL_3B0;
				IL_337:
				Interaction.MsgBox("Não foi possível gravar os dados", MsgBoxStyle.Question, "Atenção - Erro I/0");
				FileSystem.FileClose(new int[]
				{
					1
				});
				this.Timer_limpa_MSG.Enabled = true;
				goto IL_3B0;
				IL_36B:
				num2 = -1;
				throw new InvalidOperationException("Decompiler switch pattern not reconstructed.");
				IL_381:;
			}
			catch (Exception)
			{
				throw;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			IL_3B0:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x002F9358 File Offset: 0x002F7758
		private void DataGridView_setpoints_810_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x002F935C File Offset: 0x002F775C
		private void DataGridView_setpoints_810_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x002F9360 File Offset: 0x002F7760
		private void DataGridView_setpoints_810_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x002F9364 File Offset: 0x002F7764
		private void DataGridView_processo_810_P1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x002F9368 File Offset: 0x002F7768
		private void DataGridView_processo_810_P1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x002F936C File Offset: 0x002F776C
		private void DataGridView_processo_810_P1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x002F9370 File Offset: 0x002F7770
		private void DataGridView_end_rep_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x002F9374 File Offset: 0x002F7774
		private void DataGridView_end_rep_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x002F9378 File Offset: 0x002F7778
		private void DataGridView_end_rep_RT_810_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x002F937C File Offset: 0x002F777C
		private void DataGridView_parametros_EA_810_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x002F9380 File Offset: 0x002F7780
		private void DataGridView_parametros_EA_810_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x002F9384 File Offset: 0x002F7784
		private void DataGridView_parametros_EA_810_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x002F9388 File Offset: 0x002F7788
		private void DataGridView_RT810_ED_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x002F938C File Offset: 0x002F778C
		private void DataGridView_RT810_ED_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x002F9390 File Offset: 0x002F7790
		private void ToolStripButton_RT_810_Imprimir_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			using (EnhancedPrintPreviewDialog enhancedPrintPreviewDialog = new EnhancedPrintPreviewDialog())
			{
				enhancedPrintPreviewDialog.Document = this.PrintDocument1;
				enhancedPrintPreviewDialog.ShowDialog();
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x002F93D8 File Offset: 0x002F77D8
		private void TextBox_comentarios_RT810_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x002F93DC File Offset: 0x002F77DC
		[MethodImpl(72)]
		private void DesenhaRelatorioRT810(PrintPageEventArgs z)
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
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.GC_82x_BD.Equip.Valor, RT_geral.GC_82x_BD.Versao.Valor);
			int linhaInicial = 5;
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, linhaInicial, 3, "Dados da Estação", true);
			string valor = "iS800 (" + MyProject.Application.Info.Version.ToString() + ")";
			tabelaLinhaInteria.EscreveTituloValorLinha(1, "Configurador", valor, 0, 160);
			string valor2 = string.Concat(new string[]
			{
				"GC",
				RT_geral.GC_82x_BD.Equip.Valor.ToString(),
				"_",
				RT_geral.GC_82x_BD.Versao.Valor.ToString(),
				string.Format("{0:D2}", RT_geral.GC_82x_BD.Build.Valor),
				"  R",
				RT_geral.GC_82x_BD.Release.Valor.ToString()
			});
			tabelaLinhaInteria.EscreveTituloValorLinha(1, "Firmware", valor2, 450, 530);
			tabelaLinhaInteria.EscreveTituloValorLinha(2, "Data", string.Concat(new string[]
			{
				DateTime.Today.Day.ToString(),
				"/",
				DateTime.Today.Month.ToString(),
				"/",
				DateTime.Today.Year.ToString()
			}), 450, 530);
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Arquivo", Path.GetFileName(RT_geral.GC_82x_BD.filename), 0, 160);
			linhaInicial = tabelaLinhaInteria.GetNextLineAvailable();
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, linhaInicial, 1, "Parâmetro de Comunicação", true);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(1, "Endereço da Estação", this.NumericUpDown_end_est.Value.ToString(), 0, 200);
			linhaInicial = tabelaMeiaLinhaEsquerda.GetNextLineAvailable();
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, linhaInicial, 2, "Saída Analógica Canal 1", true);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(1, "Limite Inferior", RT_geral.GC_82x_BD.limt_inferior1.Valor.ToString(), 0, 180);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(2, "Limite Superior", RT_geral.GC_82x_BD.limt_superior1.Valor.ToString(), 0, 180);
			TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, linhaInicial, 2, "Saída Analógica Canal 2", true);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(1, "Limite Inferior", RT_geral.GC_82x_BD.limt_inferior2.Valor.ToString(), 0, 180);
			tabelaMeiaLinhaDireita.EscreveTituloValorLinha(2, "Limite Superior", RT_geral.GC_82x_BD.limt_superior2.Valor.ToString(), 0, 180);
			linhaInicial = tabelaMeiaLinhaEsquerda2.GetNextLineAvailable();
			RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x002F97DC File Offset: 0x002F7BDC
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

		// Token: 0x06000D0A RID: 3338 RVA: 0x002F98A0 File Offset: 0x002F7CA0
		private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
		{
			this.pagina_impressao = 1;
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x002F98AC File Offset: 0x002F7CAC
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

		// Token: 0x06000D0C RID: 3340 RVA: 0x002F98FC File Offset: 0x002F7CFC
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.HasMorePages = this.DesenhaRelatorio(e);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x002F990C File Offset: 0x002F7D0C
		private void TabPage_geral_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x002F9910 File Offset: 0x002F7D10
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x002F9914 File Offset: 0x002F7D14
		private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x002F9918 File Offset: 0x002F7D18
		private void RepetidoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x002F9924 File Offset: 0x002F7D24
		private void ToolStri_RT_810_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x002F9928 File Offset: 0x002F7D28
		private void TextBox_equipamento_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x002F992C File Offset: 0x002F7D2C
		private void GroupBox_sistema_leitura_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x002F9930 File Offset: 0x002F7D30
		private void Label73_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x002F9934 File Offset: 0x002F7D34
		private void GroupBox_descricao_RT810_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x002F9938 File Offset: 0x002F7D38
		private void GroupBox2_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x002F993C File Offset: 0x002F7D3C
		private void ComboBox_baudrate_COM1_810_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_810_BD.BaudRateCOM1.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_810_BD.BaudRateCOM1.AtualizaValorPeloIndice();
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x002F9978 File Offset: 0x002F7D78
		private void ComboBox_baudrate_COM2_810_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x002F997C File Offset: 0x002F7D7C
		private void GC_82x_conf_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x002F9980 File Offset: 0x002F7D80
		private void lmt_1_4mA_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.GC_82x_BD.limt_inferior1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.GC_82x_BD.limt_inferior1, true);
			sender = numericUpDown;
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x002F99D4 File Offset: 0x002F7DD4
		private void lmt_1_20mA_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.GC_82x_BD.limt_superior1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.GC_82x_BD.limt_superior1, true);
			sender = numericUpDown;
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x002F9A28 File Offset: 0x002F7E28
		private void lmt_2_4mA_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.GC_82x_BD.limt_inferior2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.GC_82x_BD.limt_inferior2, true);
			sender = numericUpDown;
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x002F9A7C File Offset: 0x002F7E7C
		private void lmt_2_20mA_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.GC_82x_BD.limt_superior2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.GC_82x_BD.limt_superior2, true);
			sender = numericUpDown;
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x002F9AD0 File Offset: 0x002F7ED0
		private void cb_modo_sa1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x002F9AD4 File Offset: 0x002F7ED4
		private void cb_modo_sa2_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x002F9AD8 File Offset: 0x002F7ED8
		private void cb_modo_sa1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x002F9ADC File Offset: 0x002F7EDC
		private void lmt_1_4mA_ValueChanged_1(object sender, EventArgs e)
		{
			RT_geral.GC_82x_BD.limt_inferior1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.GC_82x_BD.limt_inferior1, true);
			sender = numericUpDown;
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x002F9B30 File Offset: 0x002F7F30
		private void lmt_2_4mA_ValueChanged_1(object sender, EventArgs e)
		{
			RT_geral.GC_82x_BD.limt_inferior2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.GC_82x_BD.limt_inferior2, true);
			sender = numericUpDown;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x002F9B84 File Offset: 0x002F7F84
		private void lmt_1_20mA_ValueChanged_1(object sender, EventArgs e)
		{
			RT_geral.GC_82x_BD.limt_superior1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.GC_82x_BD.limt_superior1, true);
			sender = numericUpDown;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x002F9BD8 File Offset: 0x002F7FD8
		private void lmt_2_20mA_ValueChanged_1(object sender, EventArgs e)
		{
			RT_geral.GC_82x_BD.limt_superior2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.GC_82x_BD.limt_superior2, true);
			sender = numericUpDown;
		}

		// Token: 0x040007A5 RID: 1957
		[AccessedThroughProperty("ToolStri_RT_810")]
		private ToolStrip _ToolStri_RT_810;

		// Token: 0x040007A6 RID: 1958
		[AccessedThroughProperty("ToolStripButton_RT_810_Abrir")]
		private ToolStripButton _ToolStripButton_RT_810_Abrir;

		// Token: 0x040007A7 RID: 1959
		[AccessedThroughProperty("ToolStripButton_RT_810_Salvar")]
		private ToolStripButton _ToolStripButton_RT_810_Salvar;

		// Token: 0x040007A8 RID: 1960
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x040007A9 RID: 1961
		[AccessedThroughProperty("ToolStripButton_RT_810_Download")]
		private ToolStripButton _ToolStripButton_RT_810_Download;

		// Token: 0x040007AA RID: 1962
		[AccessedThroughProperty("ToolStripButton_RT_810_Upload")]
		private ToolStripButton _ToolStripButton_RT_810_Upload;

		// Token: 0x040007AB RID: 1963
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x040007AC RID: 1964
		[AccessedThroughProperty("ToolStripProgressBar_RT_810")]
		private ToolStripProgressBar _ToolStripProgressBar_RT_810;

		// Token: 0x040007AD RID: 1965
		[AccessedThroughProperty("ToolStripTextBox_RT_810_Msg")]
		private ToolStripTextBox _ToolStripTextBox_RT_810_Msg;

		// Token: 0x040007AE RID: 1966
		[AccessedThroughProperty("ToolStripButton_RT_810_novo")]
		private ToolStripButton _ToolStripButton_RT_810_novo;

		// Token: 0x040007AF RID: 1967
		[AccessedThroughProperty("OpenFileDialog_RT_810")]
		private OpenFileDialog _OpenFileDialog_RT_810;

		// Token: 0x040007B0 RID: 1968
		[AccessedThroughProperty("SaveFileDialog_RT_810")]
		private SaveFileDialog _SaveFileDialog_RT_810;

		// Token: 0x040007B1 RID: 1969
		[AccessedThroughProperty("Timer_limpa_MSG")]
		private Timer _Timer_limpa_MSG;

		// Token: 0x040007B2 RID: 1970
		[AccessedThroughProperty("ToolStripButton_RT_810_Imprimir")]
		private ToolStripButton _ToolStripButton_RT_810_Imprimir;

		// Token: 0x040007B3 RID: 1971
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x040007B4 RID: 1972
		[AccessedThroughProperty("PrintDocument1")]
		private PrintDocument _PrintDocument1;

		// Token: 0x040007B5 RID: 1973
		[AccessedThroughProperty("PrintPreviewDialog1")]
		private PrintPreviewDialog _PrintPreviewDialog1;

		// Token: 0x040007B6 RID: 1974
		[AccessedThroughProperty("RepetidoraBindingSource1")]
		private BindingSource _RepetidoraBindingSource1;

		// Token: 0x040007B7 RID: 1975
		[AccessedThroughProperty("ToolStripLabel_ID")]
		private ToolStripLabel _ToolStripLabel_ID;

		// Token: 0x040007B8 RID: 1976
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x040007B9 RID: 1977
		[AccessedThroughProperty("ToolStripButton1")]
		private ToolStripButton _ToolStripButton1;

		// Token: 0x040007BA RID: 1978
		[AccessedThroughProperty("TabPage_geral")]
		private TabPage _TabPage_geral;

		// Token: 0x040007BB RID: 1979
		[AccessedThroughProperty("GroupBox_informacoes")]
		private GroupBox _GroupBox_informacoes;

		// Token: 0x040007BC RID: 1980
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		// Token: 0x040007BD RID: 1981
		[AccessedThroughProperty("TextBox_equipamento")]
		private TextBox _TextBox_equipamento;

		// Token: 0x040007BE RID: 1982
		[AccessedThroughProperty("Label_equipamento")]
		private Label _Label_equipamento;

		// Token: 0x040007BF RID: 1983
		[AccessedThroughProperty("TextBox_release")]
		private TextBox _TextBox_release;

		// Token: 0x040007C0 RID: 1984
		[AccessedThroughProperty("Label_release")]
		private Label _Label_release;

		// Token: 0x040007C1 RID: 1985
		[AccessedThroughProperty("TextBox_build")]
		private TextBox _TextBox_build;

		// Token: 0x040007C2 RID: 1986
		[AccessedThroughProperty("Label_build")]
		private Label _Label_build;

		// Token: 0x040007C3 RID: 1987
		[AccessedThroughProperty("TextBox_versao")]
		private TextBox _TextBox_versao;

		// Token: 0x040007C4 RID: 1988
		[AccessedThroughProperty("Label_versao")]
		private Label _Label_versao;

		// Token: 0x040007C5 RID: 1989
		[AccessedThroughProperty("GroupBox_comunicacao")]
		private GroupBox _GroupBox_comunicacao;

		// Token: 0x040007C6 RID: 1990
		[AccessedThroughProperty("NumericUpDown_end_est")]
		private NumericUpDown _NumericUpDown_end_est;

		// Token: 0x040007C7 RID: 1991
		[AccessedThroughProperty("Label_end_est")]
		private Label _Label_end_est;

		// Token: 0x040007C8 RID: 1992
		[AccessedThroughProperty("TabControl_810")]
		private TabControl _TabControl_810;

		// Token: 0x040007C9 RID: 1993
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x040007CA RID: 1994
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x040007CB RID: 1995
		[AccessedThroughProperty("lmt_2_20mA")]
		private NumericUpDown _lmt_2_20mA;

		// Token: 0x040007CC RID: 1996
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040007CD RID: 1997
		[AccessedThroughProperty("lmt_2_4mA")]
		private NumericUpDown _lmt_2_4mA;

		// Token: 0x040007CE RID: 1998
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040007CF RID: 1999
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x040007D0 RID: 2000
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x040007D1 RID: 2001
		[AccessedThroughProperty("lmt_1_20mA")]
		private NumericUpDown _lmt_1_20mA;

		// Token: 0x040007D2 RID: 2002
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040007D3 RID: 2003
		[AccessedThroughProperty("lmt_1_4mA")]
		private NumericUpDown _lmt_1_4mA;

		// Token: 0x040007D4 RID: 2004
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040007D5 RID: 2005
		private int pagina_impressao;

		// Token: 0x040007D6 RID: 2006
		public int QualModelo;
	}
}
