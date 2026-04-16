using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using iS800.My;
using iS800.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x020000AE RID: 174
	[DesignerGenerated]
	public partial class Plataforma : Form
	{
		// Token: 0x060027F8 RID: 10232 RVA: 0x00424B48 File Offset: 0x00422F48
		public Plataforma()
		{
			base.Shown += new EventHandler(this.Plataforma_Shown);
			base.Resize += new EventHandler(this.Plataforma_Resize);
			base.Load += new EventHandler(this.Plataforma_Load);
			this.InitializeComponent();
			this.ConfigurarMenusRT821Extras();
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x060027FB RID: 10235 RVA: 0x00427110 File Offset: 0x00425510
		// (set) Token: 0x060027FC RID: 10236 RVA: 0x00427124 File Offset: 0x00425524
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

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x00427130 File Offset: 0x00425530
		// (set) Token: 0x060027FE RID: 10238 RVA: 0x00427144 File Offset: 0x00425544
		internal virtual ToolStripMenuItem MenuEquipamentosToolStripMenuItem
		{
			get
			{
				return this._MenuEquipamentosToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._MenuEquipamentosToolStripMenuItem = value;
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x060027FF RID: 10239 RVA: 0x00427150 File Offset: 0x00425550
		// (set) Token: 0x06002800 RID: 10240 RVA: 0x00427164 File Offset: 0x00425564
		internal virtual ToolStripMenuItem TipoDeOperacaoToolStripMenuItem
		{
			get
			{
				return this._TipoDeOperacaoToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TipoDeOperacaoToolStripMenuItem_Click);
				if (this._TipoDeOperacaoToolStripMenuItem != null)
				{
					this._TipoDeOperacaoToolStripMenuItem.Click -= eventHandler;
				}
				this._TipoDeOperacaoToolStripMenuItem = value;
				if (this._TipoDeOperacaoToolStripMenuItem != null)
				{
					this._TipoDeOperacaoToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06002801 RID: 10241 RVA: 0x004271B0 File Offset: 0x004255B0
		// (set) Token: 0x06002802 RID: 10242 RVA: 0x004271C4 File Offset: 0x004255C4
		internal virtual ToolStripMenuItem ArquivosToolStripMenuItem
		{
			get
			{
				return this._ArquivosToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._ArquivosToolStripMenuItem = value;
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06002803 RID: 10243 RVA: 0x004271D0 File Offset: 0x004255D0
		// (set) Token: 0x06002804 RID: 10244 RVA: 0x004271E4 File Offset: 0x004255E4
		internal virtual ToolStripMenuItem NovoProjetoToolStripMenuItem
		{
			get
			{
				return this._NovoProjetoToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._NovoProjetoToolStripMenuItem = value;
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06002805 RID: 10245 RVA: 0x004271F0 File Offset: 0x004255F0
		// (set) Token: 0x06002806 RID: 10246 RVA: 0x00427204 File Offset: 0x00425604
		internal virtual ToolStripMenuItem AbrirToolStripMenuItem
		{
			get
			{
				return this._AbrirToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._AbrirToolStripMenuItem = value;
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06002807 RID: 10247 RVA: 0x00427210 File Offset: 0x00425610
		// (set) Token: 0x06002808 RID: 10248 RVA: 0x00427224 File Offset: 0x00425624
		internal virtual ToolStripMenuItem SalvarProjetoToolStripMenuItem
		{
			get
			{
				return this._SalvarProjetoToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._SalvarProjetoToolStripMenuItem = value;
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06002809 RID: 10249 RVA: 0x00427230 File Offset: 0x00425630
		// (set) Token: 0x0600280A RID: 10250 RVA: 0x00427244 File Offset: 0x00425644
		internal virtual SerialPort SerialPort1
		{
			get
			{
				return this._SerialPort1;
			}
			[MethodImpl(32)]
			set
			{
				SerialDataReceivedEventHandler serialDataReceivedEventHandler = new SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
				if (this._SerialPort1 != null)
				{
					this._SerialPort1.DataReceived -= serialDataReceivedEventHandler;
				}
				this._SerialPort1 = value;
				if (this._SerialPort1 != null)
				{
					this._SerialPort1.DataReceived += serialDataReceivedEventHandler;
				}
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x00427290 File Offset: 0x00425690
		// (set) Token: 0x0600280C RID: 10252 RVA: 0x004272A4 File Offset: 0x004256A4
		internal virtual Timer Timer_timeout
		{
			get
			{
				return this._Timer_timeout;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer_timeout_Tick);
				if (this._Timer_timeout != null)
				{
					this._Timer_timeout.Tick -= eventHandler;
				}
				this._Timer_timeout = value;
				if (this._Timer_timeout != null)
				{
					this._Timer_timeout.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x004272F0 File Offset: 0x004256F0
		// (set) Token: 0x0600280E RID: 10254 RVA: 0x00427304 File Offset: 0x00425704
		internal virtual Timer Timer_espera
		{
			get
			{
				return this._Timer_espera;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer_espera_Tick);
				if (this._Timer_espera != null)
				{
					this._Timer_espera.Tick -= eventHandler;
				}
				this._Timer_espera = value;
				if (this._Timer_espera != null)
				{
					this._Timer_espera.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x00427350 File Offset: 0x00425750
		// (set) Token: 0x06002810 RID: 10256 RVA: 0x00427364 File Offset: 0x00425764
		internal virtual BackgroundWorker Background_ouvidor
		{
			get
			{
				return this._Background_ouvidor;
			}
			[MethodImpl(32)]
			set
			{
				RunWorkerCompletedEventHandler runWorkerCompletedEventHandler = new RunWorkerCompletedEventHandler(this.Background_ouvidor_RunWorkerCompleted);
				if (this._Background_ouvidor != null)
				{
					this._Background_ouvidor.RunWorkerCompleted -= runWorkerCompletedEventHandler;
				}
				this._Background_ouvidor = value;
				if (this._Background_ouvidor != null)
				{
					this._Background_ouvidor.RunWorkerCompleted += runWorkerCompletedEventHandler;
				}
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06002811 RID: 10257 RVA: 0x004273B0 File Offset: 0x004257B0
		// (set) Token: 0x06002812 RID: 10258 RVA: 0x004273C4 File Offset: 0x004257C4
		internal virtual Timer Timer_ouvidor
		{
			get
			{
				return this._Timer_ouvidor;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer_ouvidor_Tick);
				if (this._Timer_ouvidor != null)
				{
					this._Timer_ouvidor.Tick -= eventHandler;
				}
				this._Timer_ouvidor = value;
				if (this._Timer_ouvidor != null)
				{
					this._Timer_ouvidor.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06002813 RID: 10259 RVA: 0x00427410 File Offset: 0x00425810
		// (set) Token: 0x06002814 RID: 10260 RVA: 0x00427424 File Offset: 0x00425824
		internal virtual ToolStripMenuItem SobreToolStripMenuItem
		{
			get
			{
				return this._SobreToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SobreToolStripMenuItem_Click);
				if (this._SobreToolStripMenuItem != null)
				{
					this._SobreToolStripMenuItem.Click -= eventHandler;
				}
				this._SobreToolStripMenuItem = value;
				if (this._SobreToolStripMenuItem != null)
				{
					this._SobreToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x00427470 File Offset: 0x00425870
		// (set) Token: 0x06002816 RID: 10262 RVA: 0x00427484 File Offset: 0x00425884
		internal virtual ToolStrip Menu_ouvidor
		{
			get
			{
				return this._Menu_ouvidor;
			}
			[MethodImpl(32)]
			set
			{
				this._Menu_ouvidor = value;
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x00427490 File Offset: 0x00425890
		// (set) Token: 0x06002818 RID: 10264 RVA: 0x004274A4 File Offset: 0x004258A4
		internal virtual ToolStripButton Menu_ouvidor_limpa
		{
			get
			{
				return this._Menu_ouvidor_limpa;
			}
			[MethodImpl(32)]
			set
			{
				this._Menu_ouvidor_limpa = value;
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x004274B0 File Offset: 0x004258B0
		// (set) Token: 0x0600281A RID: 10266 RVA: 0x004274C4 File Offset: 0x004258C4
		internal virtual ToolStripButton Menu_ouvidor_Off
		{
			get
			{
				return this._Menu_ouvidor_Off;
			}
			[MethodImpl(32)]
			set
			{
				this._Menu_ouvidor_Off = value;
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x0600281B RID: 10267 RVA: 0x004274D0 File Offset: 0x004258D0
		// (set) Token: 0x0600281C RID: 10268 RVA: 0x004274E4 File Offset: 0x004258E4
		internal virtual ToolStripButton Menu_ouvidor_On
		{
			get
			{
				return this._Menu_ouvidor_On;
			}
			[MethodImpl(32)]
			set
			{
				this._Menu_ouvidor_On = value;
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x0600281D RID: 10269 RVA: 0x004274F0 File Offset: 0x004258F0
		// (set) Token: 0x0600281E RID: 10270 RVA: 0x00427504 File Offset: 0x00425904
		internal virtual ToolStripMenuItem RT821ToolStripMenuItem
		{
			get
			{
				return this._RT821ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._RT821ToolStripMenuItem = value;
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x0600281F RID: 10271 RVA: 0x00427510 File Offset: 0x00425910
		// (set) Token: 0x06002820 RID: 10272 RVA: 0x00427524 File Offset: 0x00425924
		internal virtual ToolStrip ToolStrip1
		{
			get
			{
				return this._ToolStrip1;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStrip1 = value;
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06002821 RID: 10273 RVA: 0x00427530 File Offset: 0x00425930
		// (set) Token: 0x06002822 RID: 10274 RVA: 0x00427544 File Offset: 0x00425944
		internal virtual ToolStripComboBox ToolStripComboBox_equipamento
		{
			get
			{
				return this._ToolStripComboBox_equipamento;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripComboBox_equipamento_TextChanged);
				if (this._ToolStripComboBox_equipamento != null)
				{
					this._ToolStripComboBox_equipamento.TextChanged -= eventHandler;
				}
				this._ToolStripComboBox_equipamento = value;
				if (this._ToolStripComboBox_equipamento != null)
				{
					this._ToolStripComboBox_equipamento.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06002823 RID: 10275 RVA: 0x00427590 File Offset: 0x00425990
		// (set) Token: 0x06002824 RID: 10276 RVA: 0x004275A4 File Offset: 0x004259A4
		internal virtual ToolStripButton ToolStripButton_Configuracao
		{
			get
			{
				return this._ToolStripButton_Configuracao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_Configuracao_Click);
				if (this._ToolStripButton_Configuracao != null)
				{
					this._ToolStripButton_Configuracao.Click -= eventHandler;
				}
				this._ToolStripButton_Configuracao = value;
				if (this._ToolStripButton_Configuracao != null)
				{
					this._ToolStripButton_Configuracao.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06002825 RID: 10277 RVA: 0x004275F0 File Offset: 0x004259F0
		// (set) Token: 0x06002826 RID: 10278 RVA: 0x00427604 File Offset: 0x00425A04
		internal virtual ToolStripButton ToolStripButton_Calibracao
		{
			get
			{
				return this._ToolStripButton_Calibracao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_Calibracao_Click);
				if (this._ToolStripButton_Calibracao != null)
				{
					this._ToolStripButton_Calibracao.Click -= eventHandler;
				}
				this._ToolStripButton_Calibracao = value;
				if (this._ToolStripButton_Calibracao != null)
				{
					this._ToolStripButton_Calibracao.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06002827 RID: 10279 RVA: 0x00427650 File Offset: 0x00425A50
		// (set) Token: 0x06002828 RID: 10280 RVA: 0x00427664 File Offset: 0x00425A64
		internal virtual ToolStripButton ToolStripButton_Monitoracao
		{
			get
			{
				return this._ToolStripButton_Monitoracao;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripButton_Monitoracao = value;
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06002829 RID: 10281 RVA: 0x00427670 File Offset: 0x00425A70
		// (set) Token: 0x0600282A RID: 10282 RVA: 0x00427684 File Offset: 0x00425A84
		internal virtual ToolStripButton ToolStripButton_serial
		{
			get
			{
				return this._ToolStripButton_serial;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_serial_Click);
				if (this._ToolStripButton_serial != null)
				{
					this._ToolStripButton_serial.Click -= eventHandler;
				}
				this._ToolStripButton_serial = value;
				if (this._ToolStripButton_serial != null)
				{
					this._ToolStripButton_serial.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x0600282B RID: 10283 RVA: 0x004276D0 File Offset: 0x00425AD0
		// (set) Token: 0x0600282C RID: 10284 RVA: 0x004276E4 File Offset: 0x00425AE4
		internal virtual ToolStripMenuItem RT810ToolStripMenuItem
		{
			get
			{
				return this._RT810ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RT810ToolStripMenuItem_Click);
				PaintEventHandler paintEventHandler = new PaintEventHandler(this.RT810ToolStripMenuItem_Paint);
				if (this._RT810ToolStripMenuItem != null)
				{
					this._RT810ToolStripMenuItem.Click -= eventHandler;
					this._RT810ToolStripMenuItem.Paint -= paintEventHandler;
				}
				this._RT810ToolStripMenuItem = value;
				if (this._RT810ToolStripMenuItem != null)
				{
					this._RT810ToolStripMenuItem.Click += eventHandler;
					this._RT810ToolStripMenuItem.Paint += paintEventHandler;
				}
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x00427754 File Offset: 0x00425B54
		// (set) Token: 0x0600282E RID: 10286 RVA: 0x00427768 File Offset: 0x00425B68
		internal virtual ToolStripMenuItem RT820ToolStripMenuItem
		{
			get
			{
				return this._RT820ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._RT820ToolStripMenuItem = value;
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x0600282F RID: 10287 RVA: 0x00427774 File Offset: 0x00425B74
		// (set) Token: 0x06002830 RID: 10288 RVA: 0x00427788 File Offset: 0x00425B88
		internal virtual ToolStripMenuItem RT850ToolStripMenuItem
		{
			get
			{
				return this._RT850ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._RT850ToolStripMenuItem = value;
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x00427794 File Offset: 0x00425B94
		// (set) Token: 0x06002832 RID: 10290 RVA: 0x004277A8 File Offset: 0x00425BA8
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

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x004277B4 File Offset: 0x00425BB4
		// (set) Token: 0x06002834 RID: 10292 RVA: 0x004277C8 File Offset: 0x00425BC8
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

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x004277D4 File Offset: 0x00425BD4
		// (set) Token: 0x06002836 RID: 10294 RVA: 0x004277E8 File Offset: 0x00425BE8
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

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06002837 RID: 10295 RVA: 0x004277F4 File Offset: 0x00425BF4
		// (set) Token: 0x06002838 RID: 10296 RVA: 0x00427808 File Offset: 0x00425C08
		internal virtual ToolStripMenuItem RT810_Versão30ToolStripMenuItem
		{
			get
			{
				return this._RT810_Versão30ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RT810_Versão30ToolStripMenuItem_Click);
				if (this._RT810_Versão30ToolStripMenuItem != null)
				{
					this._RT810_Versão30ToolStripMenuItem.Click -= eventHandler;
				}
				this._RT810_Versão30ToolStripMenuItem = value;
				if (this._RT810_Versão30ToolStripMenuItem != null)
				{
					this._RT810_Versão30ToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06002839 RID: 10297 RVA: 0x00427854 File Offset: 0x00425C54
		// (set) Token: 0x0600283A RID: 10298 RVA: 0x00427868 File Offset: 0x00425C68
		internal virtual ToolStripComboBox ToolStripComboBox_versao
		{
			get
			{
				return this._ToolStripComboBox_versao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripComboBox_versao_TextChanged);
				if (this._ToolStripComboBox_versao != null)
				{
					this._ToolStripComboBox_versao.TextChanged -= eventHandler;
				}
				this._ToolStripComboBox_versao = value;
				if (this._ToolStripComboBox_versao != null)
				{
					this._ToolStripComboBox_versao.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x004278B4 File Offset: 0x00425CB4
		// (set) Token: 0x0600283C RID: 10300 RVA: 0x004278C8 File Offset: 0x00425CC8
		internal virtual ToolStripMenuItem RT820_Versão30ToolStripMenuItem
		{
			get
			{
				return this._RT820_Versão30ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RT820_Versão30ToolStripMenuItem_Click);
				if (this._RT820_Versão30ToolStripMenuItem != null)
				{
					this._RT820_Versão30ToolStripMenuItem.Click -= eventHandler;
				}
				this._RT820_Versão30ToolStripMenuItem = value;
				if (this._RT820_Versão30ToolStripMenuItem != null)
				{
					this._RT820_Versão30ToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x00427914 File Offset: 0x00425D14
		// (set) Token: 0x0600283E RID: 10302 RVA: 0x00427928 File Offset: 0x00425D28
		internal virtual ToolStripMenuItem RT821_Versão30ToolStripMenuItem
		{
			get
			{
				return this._RT821_Versão30ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RT821_Versão30ToolStripMenuItem_Click);
				if (this._RT821_Versão30ToolStripMenuItem != null)
				{
					this._RT821_Versão30ToolStripMenuItem.Click -= eventHandler;
				}
				this._RT821_Versão30ToolStripMenuItem = value;
				if (this._RT821_Versão30ToolStripMenuItem != null)
				{
					this._RT821_Versão30ToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x00427974 File Offset: 0x00425D74
		// (set) Token: 0x06002840 RID: 10304 RVA: 0x00427988 File Offset: 0x00425D88
		internal virtual ToolStripMenuItem RT850_Versão30ToolStripMenuItem
		{
			get
			{
				return this._RT850_Versão30ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.RT850_Versão30ToolStripMenuItem_Click);
				if (this._RT850_Versão30ToolStripMenuItem != null)
				{
					this._RT850_Versão30ToolStripMenuItem.Click -= eventHandler;
				}
				this._RT850_Versão30ToolStripMenuItem = value;
				if (this._RT850_Versão30ToolStripMenuItem != null)
				{
					this._RT850_Versão30ToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06002841 RID: 10305 RVA: 0x004279D4 File Offset: 0x00425DD4
		// (set) Token: 0x06002842 RID: 10306 RVA: 0x004279E8 File Offset: 0x00425DE8
		internal virtual ToolStripButton ToolStripButton_sobre
		{
			get
			{
				return this._ToolStripButton_sobre;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_sobre_Click);
				if (this._ToolStripButton_sobre != null)
				{
					this._ToolStripButton_sobre.Click -= eventHandler;
				}
				this._ToolStripButton_sobre = value;
				if (this._ToolStripButton_sobre != null)
				{
					this._ToolStripButton_sobre.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x00427A34 File Offset: 0x00425E34
		// (set) Token: 0x06002844 RID: 10308 RVA: 0x00427A48 File Offset: 0x00425E48
		internal virtual ToolStripMenuItem JalenaToolStripMenuItem
		{
			get
			{
				return this._JalenaToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._JalenaToolStripMenuItem = value;
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06002845 RID: 10309 RVA: 0x00427A54 File Offset: 0x00425E54
		// (set) Token: 0x06002846 RID: 10310 RVA: 0x00427A68 File Offset: 0x00425E68
		internal virtual ToolStripMenuItem Versão20ToolStripMenuItem
		{
			get
			{
				return this._Versão20ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Versão20ToolStripMenuItem_Click);
				if (this._Versão20ToolStripMenuItem != null)
				{
					this._Versão20ToolStripMenuItem.Click -= eventHandler;
				}
				this._Versão20ToolStripMenuItem = value;
				if (this._Versão20ToolStripMenuItem != null)
				{
					this._Versão20ToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06002847 RID: 10311 RVA: 0x00427AB4 File Offset: 0x00425EB4
		// (set) Token: 0x06002848 RID: 10312 RVA: 0x00427AC8 File Offset: 0x00425EC8
		internal virtual ToolStripMenuItem Versão20ToolStripMenuItem1
		{
			get
			{
				return this._Versão20ToolStripMenuItem1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Versão20ToolStripMenuItem1_Click);
				if (this._Versão20ToolStripMenuItem1 != null)
				{
					this._Versão20ToolStripMenuItem1.Click -= eventHandler;
				}
				this._Versão20ToolStripMenuItem1 = value;
				if (this._Versão20ToolStripMenuItem1 != null)
				{
					this._Versão20ToolStripMenuItem1.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06002849 RID: 10313 RVA: 0x00427B14 File Offset: 0x00425F14
		// (set) Token: 0x0600284A RID: 10314 RVA: 0x00427B28 File Offset: 0x00425F28
		internal virtual ToolStripMenuItem Versão20ToolStripMenuItem2
		{
			get
			{
				return this._Versão20ToolStripMenuItem2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Versão20ToolStripMenuItem2_Click);
				if (this._Versão20ToolStripMenuItem2 != null)
				{
					this._Versão20ToolStripMenuItem2.Click -= eventHandler;
				}
				this._Versão20ToolStripMenuItem2 = value;
				if (this._Versão20ToolStripMenuItem2 != null)
				{
					this._Versão20ToolStripMenuItem2.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x0600284B RID: 10315 RVA: 0x00427B74 File Offset: 0x00425F74
		// (set) Token: 0x0600284C RID: 10316 RVA: 0x00427B88 File Offset: 0x00425F88
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

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x0600284D RID: 10317 RVA: 0x00427B94 File Offset: 0x00425F94
		// (set) Token: 0x0600284E RID: 10318 RVA: 0x00427BA8 File Offset: 0x00425FA8
		internal virtual ToolStripButton ToolStripButton_FindEquip
		{
			get
			{
				return this._ToolStripButton_FindEquip;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_FindEquip_Click);
				if (this._ToolStripButton_FindEquip != null)
				{
					this._ToolStripButton_FindEquip.Click -= eventHandler;
				}
				this._ToolStripButton_FindEquip = value;
				if (this._ToolStripButton_FindEquip != null)
				{
					this._ToolStripButton_FindEquip.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x0600284F RID: 10319 RVA: 0x00427BF4 File Offset: 0x00425FF4
		// (set) Token: 0x06002850 RID: 10320 RVA: 0x00427C08 File Offset: 0x00426008
		internal virtual ToolStripMenuItem CT830ToolStripMenuItem
		{
			get
			{
				return this._CT830ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._CT830ToolStripMenuItem = value;
			}
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06002851 RID: 10321 RVA: 0x00427C14 File Offset: 0x00426014
		// (set) Token: 0x06002852 RID: 10322 RVA: 0x00427C28 File Offset: 0x00426028
		internal virtual ToolStripMenuItem Versão20ToolStripMenuItem3
		{
			get
			{
				return this._Versão20ToolStripMenuItem3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Versão20ToolStripMenuItem3_Click);
				if (this._Versão20ToolStripMenuItem3 != null)
				{
					this._Versão20ToolStripMenuItem3.Click -= eventHandler;
				}
				this._Versão20ToolStripMenuItem3 = value;
				if (this._Versão20ToolStripMenuItem3 != null)
				{
					this._Versão20ToolStripMenuItem3.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06002853 RID: 10323 RVA: 0x00427C74 File Offset: 0x00426074
		// (set) Token: 0x06002854 RID: 10324 RVA: 0x00427C88 File Offset: 0x00426088
		internal virtual ToolStripMenuItem ToolStripMenuItem1
		{
			get
			{
				return this._ToolStripMenuItem1;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripMenuItem1 = value;
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06002855 RID: 10325 RVA: 0x00427C94 File Offset: 0x00426094
		// (set) Token: 0x06002856 RID: 10326 RVA: 0x00427CA8 File Offset: 0x004260A8
		internal virtual ToolStripMenuItem Versão20ToolStripMenuItem4
		{
			get
			{
				return this._Versão20ToolStripMenuItem4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Versão20ToolStripMenuItem4_Click);
				if (this._Versão20ToolStripMenuItem4 != null)
				{
					this._Versão20ToolStripMenuItem4.Click -= eventHandler;
				}
				this._Versão20ToolStripMenuItem4 = value;
				if (this._Versão20ToolStripMenuItem4 != null)
				{
					this._Versão20ToolStripMenuItem4.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x00427CF4 File Offset: 0x004260F4
		// (set) Token: 0x06002858 RID: 10328 RVA: 0x00427D08 File Offset: 0x00426108
		internal virtual ToolStripMenuItem CalibraçãoToolStripMenuItem
		{
			get
			{
				return this._CalibraçãoToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._CalibraçãoToolStripMenuItem = value;
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06002859 RID: 10329 RVA: 0x00427D14 File Offset: 0x00426114
		// (set) Token: 0x0600285A RID: 10330 RVA: 0x00427D28 File Offset: 0x00426128
		internal virtual ToolStripMenuItem RT810ToolStripMenuItem1
		{
			get
			{
				return this._RT810ToolStripMenuItem1;
			}
			[MethodImpl(32)]
			set
			{
				this._RT810ToolStripMenuItem1 = value;
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x00427D34 File Offset: 0x00426134
		// (set) Token: 0x0600285C RID: 10332 RVA: 0x00427D48 File Offset: 0x00426148
		internal virtual ToolStripMenuItem Versão200ToolStripMenuItem
		{
			get
			{
				return this._Versão200ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._Versão200ToolStripMenuItem = value;
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x0600285D RID: 10333 RVA: 0x00427D54 File Offset: 0x00426154
		// (set) Token: 0x0600285E RID: 10334 RVA: 0x00427D68 File Offset: 0x00426168
		internal virtual ToolStripMenuItem LeituraCalibraçãoDaPlacaToolStripMenuItem
		{
			get
			{
				return this._LeituraCalibraçãoDaPlacaToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.LeituraCalibraçãoDaPlacaToolStripMenuItem_Click);
				if (this._LeituraCalibraçãoDaPlacaToolStripMenuItem != null)
				{
					this._LeituraCalibraçãoDaPlacaToolStripMenuItem.Click -= eventHandler;
				}
				this._LeituraCalibraçãoDaPlacaToolStripMenuItem = value;
				if (this._LeituraCalibraçãoDaPlacaToolStripMenuItem != null)
				{
					this._LeituraCalibraçãoDaPlacaToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x00427DB4 File Offset: 0x004261B4
		// (set) Token: 0x06002860 RID: 10336 RVA: 0x00427DC8 File Offset: 0x004261C8
		internal virtual ToolStripMenuItem Versão300ToolStripMenuItem
		{
			get
			{
				return this._Versão300ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._Versão300ToolStripMenuItem = value;
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06002861 RID: 10337 RVA: 0x00427DD4 File Offset: 0x004261D4
		// (set) Token: 0x06002862 RID: 10338 RVA: 0x00427DE8 File Offset: 0x004261E8
		internal virtual ToolStripMenuItem LeituraCalibração420mADaPlacaToolStripMenuItem
		{
			get
			{
				return this._LeituraCalibração420mADaPlacaToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.LeituraCalibração420mADaPlacaToolStripMenuItem_Click);
				if (this._LeituraCalibração420mADaPlacaToolStripMenuItem != null)
				{
					this._LeituraCalibração420mADaPlacaToolStripMenuItem.Click -= eventHandler;
				}
				this._LeituraCalibração420mADaPlacaToolStripMenuItem = value;
				if (this._LeituraCalibração420mADaPlacaToolStripMenuItem != null)
				{
					this._LeituraCalibração420mADaPlacaToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06002863 RID: 10339 RVA: 0x00427E34 File Offset: 0x00426234
		// (set) Token: 0x06002864 RID: 10340 RVA: 0x00427E48 File Offset: 0x00426248
		internal virtual ToolStripMenuItem RT820ToolStripMenuItem1
		{
			get
			{
				return this._RT820ToolStripMenuItem1;
			}
			[MethodImpl(32)]
			set
			{
				this._RT820ToolStripMenuItem1 = value;
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06002865 RID: 10341 RVA: 0x00427E54 File Offset: 0x00426254
		// (set) Token: 0x06002866 RID: 10342 RVA: 0x00427E68 File Offset: 0x00426268
		internal virtual ToolStripMenuItem Versão200ToolStripMenuItem1
		{
			get
			{
				return this._Versão200ToolStripMenuItem1;
			}
			[MethodImpl(32)]
			set
			{
				this._Versão200ToolStripMenuItem1 = value;
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06002867 RID: 10343 RVA: 0x00427E74 File Offset: 0x00426274
		// (set) Token: 0x06002868 RID: 10344 RVA: 0x00427E88 File Offset: 0x00426288
		internal virtual ToolStripMenuItem LeituraCalibração420mADaPlacaToolStripMenuItem1
		{
			get
			{
				return this._LeituraCalibração420mADaPlacaToolStripMenuItem1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.LeituraCalibração420mADaPlacaToolStripMenuItem1_Click);
				if (this._LeituraCalibração420mADaPlacaToolStripMenuItem1 != null)
				{
					this._LeituraCalibração420mADaPlacaToolStripMenuItem1.Click -= eventHandler;
				}
				this._LeituraCalibração420mADaPlacaToolStripMenuItem1 = value;
				if (this._LeituraCalibração420mADaPlacaToolStripMenuItem1 != null)
				{
					this._LeituraCalibração420mADaPlacaToolStripMenuItem1.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x00427ED4 File Offset: 0x004262D4
		// (set) Token: 0x0600286A RID: 10346 RVA: 0x00427EE8 File Offset: 0x004262E8
		internal virtual ToolStripMenuItem Versão300ToolStripMenuItem1
		{
			get
			{
				return this._Versão300ToolStripMenuItem1;
			}
			[MethodImpl(32)]
			set
			{
				this._Versão300ToolStripMenuItem1 = value;
			}
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x00427EF4 File Offset: 0x004262F4
		// (set) Token: 0x0600286C RID: 10348 RVA: 0x00427F08 File Offset: 0x00426308
		internal virtual ToolStripMenuItem LeituraCalibração420mADaPlacaToolStripMenuItem2
		{
			get
			{
				return this._LeituraCalibração420mADaPlacaToolStripMenuItem2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.LeituraCalibração420mADaPlacaToolStripMenuItem2_Click);
				if (this._LeituraCalibração420mADaPlacaToolStripMenuItem2 != null)
				{
					this._LeituraCalibração420mADaPlacaToolStripMenuItem2.Click -= eventHandler;
				}
				this._LeituraCalibração420mADaPlacaToolStripMenuItem2 = value;
				if (this._LeituraCalibração420mADaPlacaToolStripMenuItem2 != null)
				{
					this._LeituraCalibração420mADaPlacaToolStripMenuItem2.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x0600286D RID: 10349 RVA: 0x00427F54 File Offset: 0x00426354
		// (set) Token: 0x0600286E RID: 10350 RVA: 0x00427F68 File Offset: 0x00426368
		internal virtual ToolStripMenuItem RT821ToolStripMenuItem1
		{
			get
			{
				return this._RT821ToolStripMenuItem1;
			}
			[MethodImpl(32)]
			set
			{
				this._RT821ToolStripMenuItem1 = value;
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x0600286F RID: 10351 RVA: 0x00427F74 File Offset: 0x00426374
		// (set) Token: 0x06002870 RID: 10352 RVA: 0x00427F88 File Offset: 0x00426388
		internal virtual ToolStripMenuItem Versão300ToolStripMenuItem2
		{
			get
			{
				return this._Versão300ToolStripMenuItem2;
			}
			[MethodImpl(32)]
			set
			{
				this._Versão300ToolStripMenuItem2 = value;
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06002871 RID: 10353 RVA: 0x00427F94 File Offset: 0x00426394
		// (set) Token: 0x06002872 RID: 10354 RVA: 0x00427FA8 File Offset: 0x004263A8
		internal virtual ToolStripMenuItem LeituraCalibração420mADaPlacaToolStripMenuItem3
		{
			get
			{
				return this._LeituraCalibração420mADaPlacaToolStripMenuItem3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.LeituraCalibração420mADaPlacaToolStripMenuItem3_Click);
				if (this._LeituraCalibração420mADaPlacaToolStripMenuItem3 != null)
				{
					this._LeituraCalibração420mADaPlacaToolStripMenuItem3.Click -= eventHandler;
				}
				this._LeituraCalibração420mADaPlacaToolStripMenuItem3 = value;
				if (this._LeituraCalibração420mADaPlacaToolStripMenuItem3 != null)
				{
					this._LeituraCalibração420mADaPlacaToolStripMenuItem3.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06002873 RID: 10355 RVA: 0x00427FF4 File Offset: 0x004263F4
		// (set) Token: 0x06002874 RID: 10356 RVA: 0x00428008 File Offset: 0x00426408
		internal virtual ToolStripMenuItem ExecutaCalibraçãoToolStripMenuItem
		{
			get
			{
				return this._ExecutaCalibraçãoToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ExecutaCalibraçãoToolStripMenuItem_Click);
				if (this._ExecutaCalibraçãoToolStripMenuItem != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem.Click -= eventHandler;
				}
				this._ExecutaCalibraçãoToolStripMenuItem = value;
				if (this._ExecutaCalibraçãoToolStripMenuItem != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06002875 RID: 10357 RVA: 0x00428054 File Offset: 0x00426454
		// (set) Token: 0x06002876 RID: 10358 RVA: 0x00428068 File Offset: 0x00426468
		internal virtual ToolStripMenuItem ExecutaCalibraçãoToolStripMenuItem1
		{
			get
			{
				return this._ExecutaCalibraçãoToolStripMenuItem1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ExecutaCalibraçãoToolStripMenuItem1_Click);
				if (this._ExecutaCalibraçãoToolStripMenuItem1 != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem1.Click -= eventHandler;
				}
				this._ExecutaCalibraçãoToolStripMenuItem1 = value;
				if (this._ExecutaCalibraçãoToolStripMenuItem1 != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem1.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06002877 RID: 10359 RVA: 0x004280B4 File Offset: 0x004264B4
		// (set) Token: 0x06002878 RID: 10360 RVA: 0x004280C8 File Offset: 0x004264C8
		internal virtual ToolStripMenuItem ExecutaCalibraçãoToolStripMenuItem2
		{
			get
			{
				return this._ExecutaCalibraçãoToolStripMenuItem2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ExecutaCalibraçãoToolStripMenuItem2_Click);
				if (this._ExecutaCalibraçãoToolStripMenuItem2 != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem2.Click -= eventHandler;
				}
				this._ExecutaCalibraçãoToolStripMenuItem2 = value;
				if (this._ExecutaCalibraçãoToolStripMenuItem2 != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem2.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06002879 RID: 10361 RVA: 0x00428114 File Offset: 0x00426514
		// (set) Token: 0x0600287A RID: 10362 RVA: 0x00428128 File Offset: 0x00426528
		internal virtual ToolStripMenuItem ExecutaCalibraçãoToolStripMenuItem3
		{
			get
			{
				return this._ExecutaCalibraçãoToolStripMenuItem3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ExecutaCalibraçãoToolStripMenuItem3_Click);
				if (this._ExecutaCalibraçãoToolStripMenuItem3 != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem3.Click -= eventHandler;
				}
				this._ExecutaCalibraçãoToolStripMenuItem3 = value;
				if (this._ExecutaCalibraçãoToolStripMenuItem3 != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem3.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x0600287B RID: 10363 RVA: 0x00428174 File Offset: 0x00426574
		// (set) Token: 0x0600287C RID: 10364 RVA: 0x00428188 File Offset: 0x00426588
		internal virtual ToolStripMenuItem ExecutaCalibraçãoToolStripMenuItem4
		{
			get
			{
				return this._ExecutaCalibraçãoToolStripMenuItem4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ExecutaCalibraçãoToolStripMenuItem4_Click);
				if (this._ExecutaCalibraçãoToolStripMenuItem4 != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem4.Click -= eventHandler;
				}
				this._ExecutaCalibraçãoToolStripMenuItem4 = value;
				if (this._ExecutaCalibraçãoToolStripMenuItem4 != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem4.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x0600287D RID: 10365 RVA: 0x004281D4 File Offset: 0x004265D4
		// (set) Token: 0x0600287E RID: 10366 RVA: 0x004281E8 File Offset: 0x004265E8
		internal virtual ToolStripMenuItem Versão200ToolStripMenuItem2
		{
			get
			{
				return this._Versão200ToolStripMenuItem2;
			}
			[MethodImpl(32)]
			set
			{
				this._Versão200ToolStripMenuItem2 = value;
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x0600287F RID: 10367 RVA: 0x004281F4 File Offset: 0x004265F4
		// (set) Token: 0x06002880 RID: 10368 RVA: 0x00428208 File Offset: 0x00426608
		internal virtual ToolStripMenuItem ExecutaCalibraçãoToolStripMenuItem5
		{
			get
			{
				return this._ExecutaCalibraçãoToolStripMenuItem5;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ExecutaCalibraçãoToolStripMenuItem5_Click);
				if (this._ExecutaCalibraçãoToolStripMenuItem5 != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem5.Click -= eventHandler;
				}
				this._ExecutaCalibraçãoToolStripMenuItem5 = value;
				if (this._ExecutaCalibraçãoToolStripMenuItem5 != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem5.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06002881 RID: 10369 RVA: 0x00428254 File Offset: 0x00426654
		// (set) Token: 0x06002882 RID: 10370 RVA: 0x00428268 File Offset: 0x00426668
		internal virtual ToolStripMenuItem RT810ToolStripMenuItem2
		{
			get
			{
				return this._RT810ToolStripMenuItem2;
			}
			[MethodImpl(32)]
			set
			{
				this._RT810ToolStripMenuItem2 = value;
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06002883 RID: 10371 RVA: 0x00428274 File Offset: 0x00426674
		// (set) Token: 0x06002884 RID: 10372 RVA: 0x00428288 File Offset: 0x00426688
		internal virtual ToolStripMenuItem Versão300ToolStripMenuItem3
		{
			get
			{
				return this._Versão300ToolStripMenuItem3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Versão300ToolStripMenuItem3_Click);
				if (this._Versão300ToolStripMenuItem3 != null)
				{
					this._Versão300ToolStripMenuItem3.Click -= eventHandler;
				}
				this._Versão300ToolStripMenuItem3 = value;
				if (this._Versão300ToolStripMenuItem3 != null)
				{
					this._Versão300ToolStripMenuItem3.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06002885 RID: 10373 RVA: 0x004282D4 File Offset: 0x004266D4
		// (set) Token: 0x06002886 RID: 10374 RVA: 0x004282E8 File Offset: 0x004266E8
		internal virtual ToolStripMenuItem RT820ToolStripMenuItem2
		{
			get
			{
				return this._RT820ToolStripMenuItem2;
			}
			[MethodImpl(32)]
			set
			{
				this._RT820ToolStripMenuItem2 = value;
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06002887 RID: 10375 RVA: 0x004282F4 File Offset: 0x004266F4
		// (set) Token: 0x06002888 RID: 10376 RVA: 0x00428308 File Offset: 0x00426708
		internal virtual ToolStripMenuItem Versão300ToolStripMenuItem4
		{
			get
			{
				return this._Versão300ToolStripMenuItem4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Versão300ToolStripMenuItem4_Click);
				if (this._Versão300ToolStripMenuItem4 != null)
				{
					this._Versão300ToolStripMenuItem4.Click -= eventHandler;
				}
				this._Versão300ToolStripMenuItem4 = value;
				if (this._Versão300ToolStripMenuItem4 != null)
				{
					this._Versão300ToolStripMenuItem4.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06002889 RID: 10377 RVA: 0x00428354 File Offset: 0x00426754
		// (set) Token: 0x0600288A RID: 10378 RVA: 0x00428368 File Offset: 0x00426768
		internal virtual ToolStripMenuItem RT821ToolStripMenuItem2
		{
			get
			{
				return this._RT821ToolStripMenuItem2;
			}
			[MethodImpl(32)]
			set
			{
				this._RT821ToolStripMenuItem2 = value;
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x0600288B RID: 10379 RVA: 0x00428374 File Offset: 0x00426774
		// (set) Token: 0x0600288C RID: 10380 RVA: 0x00428388 File Offset: 0x00426788
		internal virtual ToolStripMenuItem Versão300ToolStripMenuItem5
		{
			get
			{
				return this._Versão300ToolStripMenuItem5;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Versão300ToolStripMenuItem5_Click);
				if (this._Versão300ToolStripMenuItem5 != null)
				{
					this._Versão300ToolStripMenuItem5.Click -= eventHandler;
				}
				this._Versão300ToolStripMenuItem5 = value;
				if (this._Versão300ToolStripMenuItem5 != null)
				{
					this._Versão300ToolStripMenuItem5.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x0600288D RID: 10381 RVA: 0x004283D4 File Offset: 0x004267D4
		// (set) Token: 0x0600288E RID: 10382 RVA: 0x004283E8 File Offset: 0x004267E8
		internal virtual ToolStripMenuItem LogComunicaçãoToolStripMenuItem
		{
			get
			{
				return this._LogComunicaçãoToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.LogComunicaçãoToolStripMenuItem_Click);
				if (this._LogComunicaçãoToolStripMenuItem != null)
				{
					this._LogComunicaçãoToolStripMenuItem.Click -= eventHandler;
				}
				this._LogComunicaçãoToolStripMenuItem = value;
				if (this._LogComunicaçãoToolStripMenuItem != null)
				{
					this._LogComunicaçãoToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x0600288F RID: 10383 RVA: 0x00428434 File Offset: 0x00426834
		// (set) Token: 0x06002890 RID: 10384 RVA: 0x00428448 File Offset: 0x00426848
		internal virtual Timer Timer_timeout2
		{
			get
			{
				return this._Timer_timeout2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer_timeout2_Tick);
				if (this._Timer_timeout2 != null)
				{
					this._Timer_timeout2.Tick -= eventHandler;
				}
				this._Timer_timeout2 = value;
				if (this._Timer_timeout2 != null)
				{
					this._Timer_timeout2.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06002891 RID: 10385 RVA: 0x00428494 File Offset: 0x00426894
		// (set) Token: 0x06002892 RID: 10386 RVA: 0x004284A8 File Offset: 0x004268A8
		internal virtual ToolStripMenuItem Versão36ToolStripMenuItem
		{
			get
			{
				return this._Versão36ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Versão36ToolStripMenuItem_Click);
				if (this._Versão36ToolStripMenuItem != null)
				{
					this._Versão36ToolStripMenuItem.Click -= eventHandler;
				}
				this._Versão36ToolStripMenuItem = value;
				if (this._Versão36ToolStripMenuItem != null)
				{
					this._Versão36ToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06002893 RID: 10387 RVA: 0x004284F4 File Offset: 0x004268F4
		// (set) Token: 0x06002894 RID: 10388 RVA: 0x00428508 File Offset: 0x00426908
		internal virtual ToolStripMenuItem Versão400ToolStripMenuItem
		{
			get
			{
				return this._Versão400ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._Versão400ToolStripMenuItem = value;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06002895 RID: 10389 RVA: 0x00428514 File Offset: 0x00426914
		// (set) Token: 0x06002896 RID: 10390 RVA: 0x00428528 File Offset: 0x00426928
		internal virtual ToolStripMenuItem LeituraCalibração420mADaPlacaToolStripMenuItem4
		{
			get
			{
				return this._LeituraCalibração420mADaPlacaToolStripMenuItem4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.LeituraCalibração420mADaPlacaToolStripMenuItem4_Click);
				if (this._LeituraCalibração420mADaPlacaToolStripMenuItem4 != null)
				{
					this._LeituraCalibração420mADaPlacaToolStripMenuItem4.Click -= eventHandler;
				}
				this._LeituraCalibração420mADaPlacaToolStripMenuItem4 = value;
				if (this._LeituraCalibração420mADaPlacaToolStripMenuItem4 != null)
				{
					this._LeituraCalibração420mADaPlacaToolStripMenuItem4.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06002897 RID: 10391 RVA: 0x00428574 File Offset: 0x00426974
		// (set) Token: 0x06002898 RID: 10392 RVA: 0x00428588 File Offset: 0x00426988
		internal virtual ToolStripMenuItem ExecutaCalibraçãoToolStripMenuItem6
		{
			get
			{
				return this._ExecutaCalibraçãoToolStripMenuItem6;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ExecutaCalibraçãoToolStripMenuItem6_Click);
				if (this._ExecutaCalibraçãoToolStripMenuItem6 != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem6.Click -= eventHandler;
				}
				this._ExecutaCalibraçãoToolStripMenuItem6 = value;
				if (this._ExecutaCalibraçãoToolStripMenuItem6 != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem6.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x004285D4 File Offset: 0x004269D4
		// (set) Token: 0x0600289A RID: 10394 RVA: 0x004285E8 File Offset: 0x004269E8
		internal virtual ToolStripMenuItem GC828ToolStripMenuItem
		{
			get
			{
				return this._GC828ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._GC828ToolStripMenuItem = value;
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x0600289B RID: 10395 RVA: 0x004285F4 File Offset: 0x004269F4
		// (set) Token: 0x0600289C RID: 10396 RVA: 0x00428608 File Offset: 0x00426A08
		internal virtual ToolStripSeparator ToolStripSeparator5
		{
			get
			{
				return this._ToolStripSeparator5;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripSeparator5 = value;
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x0600289D RID: 10397 RVA: 0x00428614 File Offset: 0x00426A14
		// (set) Token: 0x0600289E RID: 10398 RVA: 0x00428628 File Offset: 0x00426A28
		internal virtual ToolStripSeparator ToolStripSeparator6
		{
			get
			{
				return this._ToolStripSeparator6;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripSeparator6 = value;
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x00428634 File Offset: 0x00426A34
		// (set) Token: 0x060028A0 RID: 10400 RVA: 0x00428648 File Offset: 0x00426A48
		internal virtual ToolStripMenuItem Versão300ToolStripMenuItem6
		{
			get
			{
				return this._Versão300ToolStripMenuItem6;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Versão300ToolStripMenuItem6_Click);
				if (this._Versão300ToolStripMenuItem6 != null)
				{
					this._Versão300ToolStripMenuItem6.Click -= eventHandler;
				}
				this._Versão300ToolStripMenuItem6 = value;
				if (this._Versão300ToolStripMenuItem6 != null)
				{
					this._Versão300ToolStripMenuItem6.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x060028A1 RID: 10401 RVA: 0x00428694 File Offset: 0x00426A94
		// (set) Token: 0x060028A2 RID: 10402 RVA: 0x004286A8 File Offset: 0x00426AA8
		internal virtual ToolStripMenuItem GC824ToolStripMenuItem
		{
			get
			{
				return this._GC824ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._GC824ToolStripMenuItem = value;
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x004286B4 File Offset: 0x00426AB4
		// (set) Token: 0x060028A4 RID: 10404 RVA: 0x004286C8 File Offset: 0x00426AC8
		internal virtual ToolStripMenuItem Versão300ToolStripMenuItem7
		{
			get
			{
				return this._Versão300ToolStripMenuItem7;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Versão300ToolStripMenuItem7_Click);
				if (this._Versão300ToolStripMenuItem7 != null)
				{
					this._Versão300ToolStripMenuItem7.Click -= eventHandler;
				}
				this._Versão300ToolStripMenuItem7 = value;
				if (this._Versão300ToolStripMenuItem7 != null)
				{
					this._Versão300ToolStripMenuItem7.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x060028A5 RID: 10405 RVA: 0x00428714 File Offset: 0x00426B14
		// (set) Token: 0x060028A6 RID: 10406 RVA: 0x00428728 File Offset: 0x00426B28
		internal virtual ToolStripMenuItem GC824ToolStripMenuItem1
		{
			get
			{
				return this._GC824ToolStripMenuItem1;
			}
			[MethodImpl(32)]
			set
			{
				this._GC824ToolStripMenuItem1 = value;
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x00428734 File Offset: 0x00426B34
		// (set) Token: 0x060028A8 RID: 10408 RVA: 0x00428748 File Offset: 0x00426B48
		internal virtual ToolStripMenuItem Versão300ToolStripMenuItem8
		{
			get
			{
				return this._Versão300ToolStripMenuItem8;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Versão300ToolStripMenuItem8_Click);
				if (this._Versão300ToolStripMenuItem8 != null)
				{
					this._Versão300ToolStripMenuItem8.Click -= eventHandler;
				}
				this._Versão300ToolStripMenuItem8 = value;
				if (this._Versão300ToolStripMenuItem8 != null)
				{
					this._Versão300ToolStripMenuItem8.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x060028A9 RID: 10409 RVA: 0x00428794 File Offset: 0x00426B94
		// (set) Token: 0x060028AA RID: 10410 RVA: 0x004287A8 File Offset: 0x00426BA8
		internal virtual ToolStripMenuItem ExecutaCalibraçãoToolStripMenuItem7
		{
			get
			{
				return this._ExecutaCalibraçãoToolStripMenuItem7;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ExecutaCalibraçãoToolStripMenuItem7_Click);
				if (this._ExecutaCalibraçãoToolStripMenuItem7 != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem7.Click -= eventHandler;
				}
				this._ExecutaCalibraçãoToolStripMenuItem7 = value;
				if (this._ExecutaCalibraçãoToolStripMenuItem7 != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem7.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x004287F4 File Offset: 0x00426BF4
		// (set) Token: 0x060028AC RID: 10412 RVA: 0x00428808 File Offset: 0x00426C08
		internal virtual ToolStripMenuItem GC828ToolStripMenuItem1
		{
			get
			{
				return this._GC828ToolStripMenuItem1;
			}
			[MethodImpl(32)]
			set
			{
				this._GC828ToolStripMenuItem1 = value;
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x00428814 File Offset: 0x00426C14
		// (set) Token: 0x060028AE RID: 10414 RVA: 0x00428828 File Offset: 0x00426C28
		internal virtual ToolStripMenuItem Versão300ToolStripMenuItem9
		{
			get
			{
				return this._Versão300ToolStripMenuItem9;
			}
			[MethodImpl(32)]
			set
			{
				this._Versão300ToolStripMenuItem9 = value;
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x00428834 File Offset: 0x00426C34
		// (set) Token: 0x060028B0 RID: 10416 RVA: 0x00428848 File Offset: 0x00426C48
		internal virtual ToolStripMenuItem ExecutaCalibraçãoToolStripMenuItem8
		{
			get
			{
				return this._ExecutaCalibraçãoToolStripMenuItem8;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ExecutaCalibraçãoToolStripMenuItem8_Click);
				if (this._ExecutaCalibraçãoToolStripMenuItem8 != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem8.Click -= eventHandler;
				}
				this._ExecutaCalibraçãoToolStripMenuItem8 = value;
				if (this._ExecutaCalibraçãoToolStripMenuItem8 != null)
				{
					this._ExecutaCalibraçãoToolStripMenuItem8.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x00428894 File Offset: 0x00426C94
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x004288A8 File Offset: 0x00426CA8
		internal virtual ToolStripSeparator ToolStripSeparator7
		{
			get
			{
				return this._ToolStripSeparator7;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripSeparator7 = value;
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x004288B4 File Offset: 0x00426CB4
		// (set) Token: 0x060028B4 RID: 10420 RVA: 0x004288C8 File Offset: 0x00426CC8
		internal virtual PrintDialog PrintDialog1
		{
			get
			{
				return this._PrintDialog1;
			}
			[MethodImpl(32)]
			set
			{
				this._PrintDialog1 = value;
			}
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x004288D4 File Offset: 0x00426CD4
		// (set) Token: 0x060028B6 RID: 10422 RVA: 0x004288E8 File Offset: 0x00426CE8
		internal virtual ToolStripSeparator ToolStripSeparator8
		{
			get
			{
				return this._ToolStripSeparator8;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripSeparator8 = value;
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x004288F4 File Offset: 0x00426CF4
		// (set) Token: 0x060028B8 RID: 10424 RVA: 0x00428908 File Offset: 0x00426D08
		internal virtual ToolStripMenuItem LeituraCalibraçãoSA420mADaPlacaToolStripMenuItem
		{
			get
			{
				return this._LeituraCalibraçãoSA420mADaPlacaToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.LeituraCalibraçãoSA420mADaPlacaToolStripMenuItem_Click);
				if (this._LeituraCalibraçãoSA420mADaPlacaToolStripMenuItem != null)
				{
					this._LeituraCalibraçãoSA420mADaPlacaToolStripMenuItem.Click -= eventHandler;
				}
				this._LeituraCalibraçãoSA420mADaPlacaToolStripMenuItem = value;
				if (this._LeituraCalibraçãoSA420mADaPlacaToolStripMenuItem != null)
				{
					this._LeituraCalibraçãoSA420mADaPlacaToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x00428954 File Offset: 0x00426D54
		// (set) Token: 0x060028BA RID: 10426 RVA: 0x00428968 File Offset: 0x00426D68
		internal virtual ToolStripMenuItem ExecutaCalibraçãoSAToolStripMenuItem
		{
			get
			{
				return this._ExecutaCalibraçãoSAToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ExecutaCalibraçãoSAToolStripMenuItem_Click);
				if (this._ExecutaCalibraçãoSAToolStripMenuItem != null)
				{
					this._ExecutaCalibraçãoSAToolStripMenuItem.Click -= eventHandler;
				}
				this._ExecutaCalibraçãoSAToolStripMenuItem = value;
				if (this._ExecutaCalibraçãoSAToolStripMenuItem != null)
				{
					this._ExecutaCalibraçãoSAToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x004289B4 File Offset: 0x00426DB4
		// (set) Token: 0x060028BC RID: 10428 RVA: 0x004289C8 File Offset: 0x00426DC8
		internal virtual ToolStripMenuItem Versão400ToolStripMenuItem1
		{
			get
			{
				return this._Versão400ToolStripMenuItem1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Versão400ToolStripMenuItem1_Click);
				if (this._Versão400ToolStripMenuItem1 != null)
				{
					this._Versão400ToolStripMenuItem1.Click -= eventHandler;
				}
				this._Versão400ToolStripMenuItem1 = value;
				if (this._Versão400ToolStripMenuItem1 != null)
				{
					this._Versão400ToolStripMenuItem1.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x00428A14 File Offset: 0x00426E14
		// (set) Token: 0x060028BE RID: 10430 RVA: 0x00428A28 File Offset: 0x00426E28
		internal virtual ToolStripSeparator ToolStripSeparator9
		{
			get
			{
				return this._ToolStripSeparator9;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripSeparator9 = value;
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x060028BF RID: 10431 RVA: 0x00428A34 File Offset: 0x00426E34
		// (set) Token: 0x060028C0 RID: 10432 RVA: 0x00428A48 File Offset: 0x00426E48
		internal virtual ToolStripMenuItem IEC855ToolStripMenuItem
		{
			get
			{
				return this._IEC855ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				this._IEC855ToolStripMenuItem = value;
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x060028C1 RID: 10433 RVA: 0x00428A54 File Offset: 0x00426E54
		// (set) Token: 0x060028C2 RID: 10434 RVA: 0x00428A68 File Offset: 0x00426E68
		internal virtual ToolStripMenuItem ToolStripMenuItem3
		{
			get
			{
				return this._ToolStripMenuItem3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem3_Click);
				if (this._ToolStripMenuItem3 != null)
				{
					this._ToolStripMenuItem3.Click -= eventHandler;
				}
				this._ToolStripMenuItem3 = value;
				if (this._ToolStripMenuItem3 != null)
				{
					this._ToolStripMenuItem3.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x060028C3 RID: 10435 RVA: 0x00428AB4 File Offset: 0x00426EB4
		// (set) Token: 0x060028C4 RID: 10436 RVA: 0x00428AC8 File Offset: 0x00426EC8
		internal virtual ToolStripMenuItem IEC856ToolStripMenuItem
		{
			get
			{
				return this._IEC856ToolStripMenuItem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.IEC856ToolStripMenuItem_Click);
				if (this._IEC856ToolStripMenuItem != null)
				{
					this._IEC856ToolStripMenuItem.Click -= eventHandler;
				}
				this._IEC856ToolStripMenuItem = value;
				if (this._IEC856ToolStripMenuItem != null)
				{
					this._IEC856ToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x060028C5 RID: 10437 RVA: 0x00428B14 File Offset: 0x00426F14
		// (set) Token: 0x060028C6 RID: 10438 RVA: 0x00428B28 File Offset: 0x00426F28
		internal virtual ToolStripMenuItem Versão300ToolStripMenuItem10
		{
			get
			{
				return this._Versão300ToolStripMenuItem10;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Versão300ToolStripMenuItem10_Click);
				if (this._Versão300ToolStripMenuItem10 != null)
				{
					this._Versão300ToolStripMenuItem10.Click -= eventHandler;
				}
				this._Versão300ToolStripMenuItem10 = value;
				if (this._Versão300ToolStripMenuItem10 != null)
				{
					this._Versão300ToolStripMenuItem10.Click += eventHandler;
				}
			}
		}

		// Token: 0x060028C7 RID: 10439
		[DllImport("gdi32", CharSet = 2, EntryPoint = "AddFontResourceA", ExactSpelling = true, SetLastError = true)]
		private static extern long AddFontResource([MarshalAs(34)] ref string lpFileName);

		// Token: 0x060028C8 RID: 10440 RVA: 0x00428B74 File Offset: 0x00426F74
		private void Plataforma_Resize(object sender, EventArgs e)
		{
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x00428B78 File Offset: 0x00426F78
		private void Visualizador_AfterExpand(object sender, TreeViewEventArgs e)
		{
			Form activeMdiChild = this.ActiveMdiChild;
			if (Operators.CompareString(activeMdiChild.Name, "Abertura", false) != 0)
			{
				activeMdiChild.Close();
				new Abertura
				{
					MdiParent = this
				}.Show();
			}
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x00428BBC File Offset: 0x00426FBC
		private void Visualizador_AfterSelect(object sender, TreeViewEventArgs e)
		{
			Form activeMdiChild = this.ActiveMdiChild;
			if (Operators.CompareString(activeMdiChild.Name, "", false) != 0)
			{
				activeMdiChild.Close();
			}
			string text = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "SelectedNode", new object[0], null, null, null), null, "Name", new object[0], null, null, null));
			string text2 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, null, "TopNode", new object[0], null, null, null), null, "Text", new object[0], null, null, null));
			string text3 = text2;
			if (Operators.CompareString(text3, "Equipamentos - Linha VA", false) == 0)
			{
				Comunicacao.Ctrl_Com.Tipo_protocolo = 2;
				string text4 = text;
				if (Operators.CompareString(text4, "Equip_VA210", false) == 0)
				{
					new Equip_VA210_conf
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text4, "Equip_VA220", false) == 0)
				{
					new Equip_VA220_conf
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text4, "Equip_VA230", false) == 0)
				{
					new Equip_VA230_conf
					{
						MdiParent = this
					}.Show();
				}
			}
			else if (Operators.CompareString(text3, "Operação - Linha VA", false) == 0)
			{
				Comunicacao.Ctrl_Com.Tipo_protocolo = 2;
				string text5 = text;
				if (Operators.CompareString(text5, "Equip_VA220", false) == 0)
				{
					new Equip_VA220_ope
					{
						MdiParent = this
					}.Show();
				}
			}
			else if (Operators.CompareString(text3, "Monitoração - Linha VA", false) == 0)
			{
				Comunicacao.Ctrl_Com.Tipo_protocolo = 2;
				string text6 = text;
				if (Operators.CompareString(text6, "Equip_VA220", false) == 0)
				{
					new Equip_VA220_mon
					{
						MdiParent = this
					}.Show();
				}
			}
			else if (Operators.CompareString(text3, "Configuração - Linha MD", false) == 0)
			{
				Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				string text7 = text;
				if (Operators.CompareString(text7, "Equip_MD101_V43", false) == 0)
				{
					Geral.Config_geral.Versao = "43";
					new Equip_101_conf
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text7, "Equip_MD101_V70", false) == 0)
				{
					Geral.Config_geral.Versao = "70";
					new Equip_101_conf
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text7, "Equip_MD201_V21", false) == 0)
				{
					Geral.Config_geral.Versao = "21";
					new Equip_201_conf
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text7, "Equip_MD202_V21", false) == 0)
				{
					Geral.Config_geral.Versao = "21";
					new Equip_202_conf
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text7, "Equip_MD202_V22", false) == 0)
				{
					Geral.Config_geral.Versao = "22";
					new Equip_202_conf
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text7, "Equip_MD202_V23", false) == 0)
				{
					Geral.Config_geral.Versao = "23";
					new Equip_202_conf
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text7, "Equip_MD202_V50", false) == 0)
				{
					Geral.Config_geral.Versao = "50";
					new Equip_202_conf
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text7, "Equip_MD820_V10", false) == 0)
				{
					Geral.Config_geral.Versao = "820_10";
					new Equip_202_conf
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text7, "Equip_MD821_V10", false) == 0)
				{
					Geral.Config_geral.Versao = "821_10";
					new Equip_201_conf
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text7, "Equip_MD302", false) == 0)
				{
					Geral.Config_geral.Versao = "20";
					new Equip_302_conf
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text7, "Equip_MD303", false) == 0)
				{
					Geral.Config_geral.Versao = "20";
					new Equip_303_conf
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text7, "Equip_MD590", false) == 0)
				{
					Comunicacao.Ctrl_Com.Tipo_protocolo = 3;
					new Equip_590_conf
					{
						MdiParent = this
					}.Show();
				}
				else
				{
					new Abertura
					{
						MdiParent = this
					}.Show();
				}
			}
			else if (Operators.CompareString(text3, "Monitoração - Linha MD", false) == 0)
			{
				Comunicacao.Ctrl_Com.Tipo_protocolo = 2;
				string text8 = text;
				if (Operators.CompareString(text8, "Equip_MD101_V43", false) == 0)
				{
					Geral.Config_geral.Versao = "43";
					new Equip_101_mon
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text8, "Equip_MD101_V70", false) == 0)
				{
					Geral.Config_geral.Versao = "70";
					new Equip_101_mon
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text8, "Equip_MD201_V21", false) == 0)
				{
					new Equip_201_mon
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text8, "Equip_MD202_V21_MODBUS", false) == 0)
				{
					Geral.Config_geral.Versao = "21";
					Geral.Config_geral.Protocolo = 1;
					new Equip_202_mon
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text8, "Equip_MD202_V21_RADIO", false) == 0)
				{
					Geral.Config_geral.Versao = "21";
					Geral.Config_geral.Protocolo = 2;
					new Equip_202_mon
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text8, "Equip_MD202_V22", false) == 0)
				{
					Geral.Config_geral.Versao = "22";
					new Equip_202_mon
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text8, "Equip_MD202_V50", false) == 0)
				{
					Geral.Config_geral.Versao = "50";
					new Equip_202_mon
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text8, "Equip_MD810_V10", false) == 0)
				{
					Geral.Config_geral.Versao = "810_10";
					new Equip_101_mon
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text8, "Equip_MD820_V10", false) == 0)
				{
					Geral.Config_geral.Versao = "820_10";
					new Equip_202_mon
					{
						MdiParent = this
					}.Show();
				}
				else
				{
					new Abertura
					{
						MdiParent = this
					}.Show();
				}
			}
			else if (Operators.CompareString(text3, "Calibração - Linha MD", false) == 0)
			{
				Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				string text9 = text;
				if (Operators.CompareString(text9, "Equip_MD101_V43", false) == 0)
				{
					Geral.Config_geral.Versao = "43";
					new Equip_101_cal
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text9, "Equip_MD101_V70", false) == 0)
				{
					Geral.Config_geral.Versao = "70";
					new Equip_101_cal
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text9, "Equip_MD202", false) == 0)
				{
					new Equip_202_cal
					{
						MdiParent = this
					}.Show();
				}
				else if (Operators.CompareString(text9, "Equip_MD820", false) == 0)
				{
					new Equip_202_cal
					{
						MdiParent = this
					}.Show();
				}
				else
				{
					new Abertura
					{
						MdiParent = this
					}.Show();
				}
			}
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x004293BC File Offset: 0x004277BC
		private bool Font_Is_Installed(string FontName)
		{
			InstalledFontCollection installedFontCollection = new InstalledFontCollection();
			foreach (FontFamily fontFamily in installedFontCollection.Families)
			{
				if (Operators.CompareString(fontFamily.Name.ToLower(), FontName.ToLower(), false) == 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x00429408 File Offset: 0x00427808
		[MethodImpl(72)]
		private void Plataforma_Load(object sender, EventArgs e)
		{
			this.Text = "iS800 - " + MyProject.Application.Info.Version.ToString();
			this.ToolStripButton_sobre.Image = Resources.logo_vortice_pp;
			MyProject.Forms.Logo.ShowDialog();
			Linha_RT.diretorio = "c:\\";
			string text = FileSystem.CurDir();
			string fileName = text + "\\config.ini";
			IniFile iniFile = new IniFile(fileName);
			Comunicacao.Config_sistema.tipo_interface = iniFile.ReadInteger("Interfaces", "tipo_interface", 100);
			if (Comunicacao.Config_sistema.tipo_interface == 100)
			{
				Comunicacao.Config_sistema.tipo_interface = 1;
				Comunicacao.Config_sistema.Serial.Baudrate = 3;
				Comunicacao.Config_sistema.Serial.DataBits = 4;
				Comunicacao.Config_sistema.Serial.StopBits = StopBits.One;
				Comunicacao.Config_sistema.Serial.Parity = Parity.None;
				Comunicacao.Config_sistema.Serial.Porta_serial = "COM1";
				Comunicacao.Config_sistema.Serial.PortaSerialAtiva = false;
				Comunicacao.Config_sistema.Tcpip.IP = "169.254.75.100";
				Comunicacao.Config_sistema.Tcpip.Porta = 502;
				Comunicacao.Config_sistema.Wifi.IP = "192.168.1.100";
				Comunicacao.Config_sistema.Wifi.Porta = 502;
				Comunicacao.Config_sistema.Wifi.SSID = "ICTEL WIFI RS232";
				Comunicacao.Config_sistema.Wifi.PassWord = "12345678";
				Comunicacao.Config_sistema.Retry = Conversions.ToString(5);
				Comunicacao.Config_sistema.Dir_dados = ".\\";
				Interaction.MsgBox("Não foi possível carregar as configurações! Foram utilizadas configurações Padrão!", 16, null);
			}
			else
			{
				Comunicacao.Config_sistema.Serial.Porta_serial = iniFile.ReadText("Serial RS232", "porta", "");
				Comunicacao.Config_sistema.Serial.Baudrate = iniFile.ReadInteger("Serial RS232", "baudrate", 9600);
				Comunicacao.Config_sistema.Serial.DataBits = iniFile.ReadInteger("Serial RS232", "data_bits", 8);
				Comunicacao.Config_sistema.Serial.StopBits = iniFile.ReadInteger("Serial RS232", "stop_bits", 0);
				Comunicacao.Config_sistema.Serial.Parity = iniFile.ReadInteger("Serial RS232", "parity", 0);
				Comunicacao.Config_sistema.Tcpip.IP = iniFile.ReadText("EThernet TCP/IP RS232", "ip", "0.0.0.0");
				Comunicacao.Config_sistema.Tcpip.Porta = iniFile.ReadInteger("EThernet TCP/IP RS232", "porta", 0);
				Comunicacao.Config_sistema.Retry = Conversions.ToString(iniFile.ReadInteger("Geral", "retry", 5));
			}
			Geral.Ctrl_equipamento = 0;
			Geral.Ctrl_operacao = 0;
			Geral.Ctrl_versao = 0;
			RT_geral.Lmte_Init_ok = false;
			this.ToolStripComboBox_equipamento.Items.Clear();
			this.ToolStripComboBox_equipamento.Items.Add("------");
			this.ToolStripComboBox_equipamento.Items.Add("RT 810");
			this.ToolStripComboBox_equipamento.Items.Add("RT 820");
			this.ToolStripComboBox_equipamento.Items.Add("RT 821");
			this.ToolStripComboBox_equipamento.Items.Add("CT 850");
			this.ToolStripComboBox_equipamento.SelectedIndex = 0;
			this.ToolStripComboBox_versao.Items.Clear();
			this.ToolStripComboBox_versao.Items.Add("----------");
			this.ToolStripComboBox_versao.Items.Add("Versão 3.0");
			this.ToolStripComboBox_versao.SelectedIndex = 0;
			RT_geral.Tela_limpa_Ctrl(RT_geral.Telas_RT_810);
			RT_geral.Tela_limpa_Ctrl(RT_geral.Telas_RT_820);
			RT_geral.Tela_limpa_Ctrl(RT_geral.Telas_RT_820_360);
			RT_geral.Tela_limpa_Ctrl(RT_geral.Telas_RT_821);
			RT_geral.Tela_limpa_Ctrl(RT_geral.Telas_RT_850);
			RT_geral.Tela_limpa_Ctrl(RT_geral.Telas_RT_810_200);
			RT_geral.Tela_limpa_Ctrl(RT_geral.Telas_RT_820_200);
			RT_geral.Tela_limpa_Ctrl(RT_geral.Telas_RT_821_200);
			RT_geral.Tela_limpa_Ctrl(RT_geral.Telas_RT_830_200);
			RT_geral.Tela_limpa_Ctrl(RT_geral.Telas_RT_831_200);
			this.RT810ToolStripMenuItem.Text = "MD 101";
			this.RT820ToolStripMenuItem.Text = "MD 202";
			this.RT821ToolStripMenuItem.Text = "MD 201";
			this.CT830ToolStripMenuItem.Text = "MD 302";
			this.ToolStripMenuItem1.Text = "MD 301";
			this.RT850ToolStripMenuItem.Text = "MD 305";
			this.RT810ToolStripMenuItem1.Text = "MD 101";
			this.RT820ToolStripMenuItem1.Text = "MD 202";
			this.RT821ToolStripMenuItem1.Text = "MD 201";
			this.RT810ToolStripMenuItem2.Text = "MD 101";
			this.RT820ToolStripMenuItem2.Text = "MD 202";
			this.RT821ToolStripMenuItem2.Text = "MD 201";
			if (Comunicacao.Config_sistema.tipo_interface == 2)
			{
				this.ToolStripButton_serial.Image = Resources.rj45_128x128;
			}
			else
			{
				this.ToolStripButton_serial.Image = Resources.DB9_128;
			}
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x0042990C File Offset: 0x00427D0C
		private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			switch (Comunicacao.Ctrl_Com.Tipo_protocolo)
			{
			case 1:
				this.Analisa_Protocolo_MODBUS();
				break;
			case 2:
				this.Analisa_Protocolo_CONDAX();
				break;
			case 3:
				this.Analisa_Protocolo_Aerocomm();
				break;
			case 4:
				this.Analisa_Protocolo_OUVIDOR();
				break;
			}
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x0042995C File Offset: 0x00427D5C
		private void Analisa_Protocolo_MODBUS()
		{
			int bytesToRead = this.SerialPort1.BytesToRead;
			checked
			{
				if (bytesToRead != 0)
				{
					int num = 0;
					int num2 = bytesToRead - 1;
					for (int i = num; i <= num2; i++)
					{
						Comunicacao.Buffer_resp[Comunicacao.Ctrl_Com.Cont_rx] = (byte)this.SerialPort1.ReadChar();
						if (Comunicacao.Ctrl_Com.Cont_rx == 0)
						{
							Comunicacao.Ctrl_Com.Cont_rx = Comunicacao.Ctrl_Com.Cont_rx + 1;
						}
						else if (Comunicacao.Ctrl_Com.Cont_rx == 1)
						{
							byte b = Comunicacao.Buffer_resp[Comunicacao.Ctrl_Com.Cont_rx];
							if (b == 3)
							{
								Comunicacao.Ctrl_Com.Tipo_funcao = 3;
								Comunicacao.Ctrl_Com.Cont_rx = Comunicacao.Ctrl_Com.Cont_rx + 1;
							}
							else if (b == 16)
							{
								Comunicacao.Ctrl_Com.Tipo_funcao = 16;
								Comunicacao.Ctrl_Com.Cont_rx = Comunicacao.Ctrl_Com.Cont_rx + 1;
							}
							else
							{
								Comunicacao.Ctrl_Com.Tipo_funcao = 0;
								Comunicacao.Ctrl_Com.Cont_rx = 0;
							}
						}
						else if (Comunicacao.Ctrl_Com.Tipo_funcao != 0)
						{
							int tipo_funcao = Comunicacao.Ctrl_Com.Tipo_funcao;
							if (tipo_funcao == 3)
							{
								if (Comunicacao.Ctrl_Com.Cont_rx == 2)
								{
									Comunicacao.Ctrl_Com.Num_bytes = (int)(Comunicacao.Buffer_resp[Comunicacao.Ctrl_Com.Cont_rx] + 2);
									Comunicacao.Ctrl_Com.Cont_rx = Comunicacao.Ctrl_Com.Cont_rx + 1;
								}
								else
								{
									Comunicacao.Ctrl_Com.Cont_rx = Comunicacao.Ctrl_Com.Cont_rx + 1;
									Comunicacao.Ctrl_Com.Num_bytes = Comunicacao.Ctrl_Com.Num_bytes - 1;
									if (Comunicacao.Ctrl_Com.Num_bytes == 0)
									{
										this.Timer_timeout.Enabled = false;
										int num3 = (int)(Comunicacao.Buffer_resp[2] + 3);
										if (Comunicacao.Crc16_RX(ref num3))
										{
											Comunicacao.Ctrl_Com.Frame = 0;
											return;
										}
										Comunicacao.Ctrl_Com.Frame = 2;
										return;
									}
								}
							}
							else if (tipo_funcao == 16)
							{
								if (Comunicacao.Ctrl_Com.Cont_rx == 7)
								{
									if (Comunicacao.Ctrl_Com.Num_bytes == 0)
									{
										this.Timer_timeout.Enabled = false;
										int num3 = 6;
										if (Comunicacao.Crc16_RX(ref num3))
										{
											Comunicacao.Ctrl_Com.Frame = 0;
											return;
										}
										Comunicacao.Ctrl_Com.Frame = 2;
										return;
									}
								}
								else
								{
									Comunicacao.Ctrl_Com.Cont_rx = Comunicacao.Ctrl_Com.Cont_rx + 1;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x00429BAC File Offset: 0x00427FAC
		private void Analisa_Protocolo_CONDAX()
		{
			int bytesToRead = this.SerialPort1.BytesToRead;
			checked
			{
				if (bytesToRead != 0)
				{
					int num = 0;
					int num2 = bytesToRead - 1;
					int i = num;
					while (i <= num2)
					{
						Comunicacao.Buffer_resp[Comunicacao.Ctrl_Com.Cont_rx] = (byte)this.SerialPort1.ReadChar();
						if (Comunicacao.Ctrl_Com.Tipo_funcao == 100)
						{
							Comunicacao.Ctrl_Com.Cont_rx = Comunicacao.Ctrl_Com.Cont_rx + 1;
							if (Comunicacao.Calcula_rx_chksum(Comunicacao.Ctrl_Com.Cont_rx - 1))
							{
								Comunicacao.Ctrl_Com.Frame = 0;
								return;
							}
							Comunicacao.Ctrl_Com.Frame = 2;
							return;
						}
						else
						{
							switch (Comunicacao.Buffer_resp[Comunicacao.Ctrl_Com.Cont_rx])
							{
							case 1:
								if (Comunicacao.Ctrl_Com.Cont_rx == 0)
								{
									Comunicacao.Ctrl_Com.Tipo_funcao = 1;
									Comunicacao.Ctrl_Com.Cont_rx = Comunicacao.Ctrl_Com.Cont_rx + 1;
								}
								else
								{
									Comunicacao.Ctrl_Com.Cont_rx = 0;
									Comunicacao.Ctrl_Com.Tipo_funcao = 0;
								}
								break;
							case 2:
								goto IL_127;
							case 3:
								if (Comunicacao.Ctrl_Com.Cont_rx != 0)
								{
									Comunicacao.Ctrl_Com.Tipo_funcao = 100;
									Comunicacao.Ctrl_Com.Cont_rx = Comunicacao.Ctrl_Com.Cont_rx + 1;
								}
								break;
							default:
								goto IL_127;
							}
							IL_14A:
							i++;
							continue;
							IL_127:
							if (Comunicacao.Ctrl_Com.Tipo_funcao != 0)
							{
								Comunicacao.Ctrl_Com.Cont_rx = Comunicacao.Ctrl_Com.Cont_rx + 1;
								goto IL_14A;
							}
							goto IL_14A;
						}
					}
				}
			}
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x00429D10 File Offset: 0x00428110
		private void Analisa_Protocolo_OUVIDOR()
		{
			int bytesToRead = this.SerialPort1.BytesToRead;
			if (bytesToRead > 0 && !Comunicacao.Ctrl_Log.flag)
			{
				Comunicacao.Ctrl_Log.inicio = DateAndTime.Now;
				Comunicacao.Ctrl_Log.flag = true;
			}
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x00429D54 File Offset: 0x00428154
		private void Analisa_Protocolo_Aerocomm()
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
					Comunicacao.Buffer_resp[Comunicacao.Ctrl_Com.Cont_rx] = (byte)this.SerialPort1.ReadChar();
					if (Comunicacao.Ctrl_Com.Cont_rx == 0)
					{
						Comunicacao.Ctrl_Com.Tipo_funcao = 1;
					}
					switch (Comunicacao.Ctrl_Com.Tipo_funcao)
					{
					case 1:
						if (Comunicacao.Buffer_resp[Comunicacao.Ctrl_Com.Cont_rx] == 204)
						{
							Comunicacao.Ctrl_Com.Tipo_funcao = 2;
							Comunicacao.Ctrl_Com.Cont_rx = 1;
						}
						break;
					case 2:
						Comunicacao.Ctrl_Com.Cont_rx = Comunicacao.Ctrl_Com.Cont_rx + 1;
						if (Comunicacao.Ctrl_Com.Cont_rx >= Comunicacao.Ctrl_Com.Numero_bytes_rx)
						{
							this.Timer_timeout.Enabled = false;
							Comunicacao.Ctrl_Com.Frame = 0;
						}
						break;
					}
					IL_D0:
					goto IL_113;
					IL_D2:
					num2 = -1;
					throw new InvalidOperationException("Decompiler switch pattern not reconstructed.");
					IL_E6:;
				}
				catch (Exception)
			{
				throw;
			}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_113:
				if (num2 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x00429E8C File Offset: 0x0042828C
		private void Timer_timeout_Tick(object sender, EventArgs e)
		{
			Comunicacao.Ctrl_Com.Frame = 3;
			this.Timer_timeout.Enabled = false;
			this.Timer_timeout.Interval = 2000;
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x00429EB8 File Offset: 0x004282B8
		private void ProtocoloMODBUSToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateSet(sender, null, "Checked", new object[]
			{
				true
			}, null, null);
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x00429EE4 File Offset: 0x004282E4
		private void Timer_espera_Tick(object sender, EventArgs e)
		{
			this.Timer_espera.Enabled = false;
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x00429EF4 File Offset: 0x004282F4
		private void SetText(string text)
		{
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x00429EF8 File Offset: 0x004282F8
		private void Background_ouvidor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			Geral.Config_geral.Tarefa_em_andamento = false;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x00429F08 File Offset: 0x00428308
		private void DesabilitaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateSet(sender, null, "Checked", new object[]
			{
				true
			}, null, null);
			this.Timer_ouvidor.Enabled = false;
			this.Menu_ouvidor.Visible = false;
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x00429F4C File Offset: 0x0042834C
		private void LimpaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Comunicacao.Escreve_dados_buffer_ouvidor(3, "");
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x00429F5C File Offset: 0x0042835C
		public void Mostra_no_ouvidor(int aviso)
		{
			string msg = "";
			do
			{
				Application.DoEvents();
			}
			while (Geral.Config_geral.Tarefa_em_andamento);
			int tipo;
			switch (aviso)
			{
			case 0:
				msg = " Comando executado com sucesso ";
				tipo = 1;
				break;
			case 2:
				msg = " Erro na recepção do bloco de dados (ChkSum) ";
				tipo = 6;
				break;
			case 3:
				msg = " Erro na recepção do bloco de dados (TimeOut) ";
				tipo = 5;
				break;
			}
			Comunicacao.Escreve_dados_buffer_ouvidor(tipo, msg);
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x00429FBC File Offset: 0x004283BC
		private void Timer_ouvidor_Tick(object sender, EventArgs e)
		{
			this.Background_ouvidor.RunWorkerAsync(0);
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x00429FD0 File Offset: 0x004283D0
		private void DecimalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateSet(sender, null, "Checked", new object[]
			{
				true
			}, null, null);
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x00429FFC File Offset: 0x004283FC
		private void HexadecimalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewLateBinding.LateSet(sender, null, "Checked", new object[]
			{
				true
			}, null, null);
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x0042A028 File Offset: 0x00428428
		private void ComunicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Configuracao
			{
				MdiParent = this
			}.Show();
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x0042A048 File Offset: 0x00428448
		private void DiretóriosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Diretorios
			{
				MdiParent = this
			}.Show();
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x0042A068 File Offset: 0x00428468
		private void Plataforma_Shown(object sender, EventArgs e)
		{
			Comunicacao.Init_porta_serial();
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x0042A070 File Offset: 0x00428470
		private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Sobre.ShowDialog();
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x0042A084 File Offset: 0x00428484
		public void Seleciona_tela(bool Troca)
		{
			int num = checked(Geral.Ctrl_equipamento + Geral.Ctrl_operacao + Geral.Ctrl_versao);
			if (num == 109030)
			{
				if (!RT_geral.Telas_RT_810.Configuracao)
				{
					RT_geral.Telas_RT_810.Configuracao = true;
					new IER_856_conf
					{
						MdiParent = this,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = true;
					this.ToolStripButton_Calibracao.Enabled = true;
					this.ToolStripButton_Monitoracao.Enabled = true;
					this.RT810ToolStripMenuItem.Checked = true;
					this.RT820ToolStripMenuItem.Checked = false;
					this.RT821ToolStripMenuItem.Checked = false;
					this.RT850ToolStripMenuItem.Checked = false;
					Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 108030)
			{
				if (!RT_geral.Telas_RT_810.Configuracao)
				{
					RT_geral.Telas_RT_810.Configuracao = true;
					new IEC_855_conf
					{
						MdiParent = this,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = true;
					this.ToolStripButton_Calibracao.Enabled = true;
					this.ToolStripButton_Monitoracao.Enabled = true;
					this.RT810ToolStripMenuItem.Checked = true;
					this.RT820ToolStripMenuItem.Checked = false;
					this.RT821ToolStripMenuItem.Checked = false;
					this.RT850ToolStripMenuItem.Checked = false;
					Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 101030)
			{
				if (!RT_geral.Telas_RT_810.Configuracao)
				{
					RT_geral.Telas_RT_810.Configuracao = true;
					new RT_810_conf
					{
						MdiParent = this,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = true;
					this.ToolStripButton_Calibracao.Enabled = true;
					this.ToolStripButton_Monitoracao.Enabled = true;
					this.RT810ToolStripMenuItem.Checked = true;
					this.RT820ToolStripMenuItem.Checked = false;
					this.RT821ToolStripMenuItem.Checked = false;
					this.RT850ToolStripMenuItem.Checked = false;
					Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 101020)
			{
				if (!RT_geral.Telas_RT_810_200.Configuracao)
				{
					RT_geral.Telas_RT_810_200.Configuracao = true;
					new RT_810_200_conf
					{
						MdiParent = this,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = true;
					this.ToolStripButton_Calibracao.Enabled = true;
					this.ToolStripButton_Monitoracao.Enabled = true;
					this.RT810ToolStripMenuItem.Checked = true;
					this.RT820ToolStripMenuItem.Checked = false;
					this.RT821ToolStripMenuItem.Checked = false;
					this.RT850ToolStripMenuItem.Checked = false;
					Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 102030)
			{
				if (!RT_geral.Telas_GC_82x.Configuracao)
				{
					RT_geral.Telas_GC_82x.Configuracao = true;
					new RT_820_conf
					{
						MdiParent = this,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = true;
					this.ToolStripButton_Calibracao.Enabled = true;
					this.ToolStripButton_Monitoracao.Enabled = true;
					this.RT810ToolStripMenuItem.Checked = false;
					this.RT820ToolStripMenuItem.Checked = true;
					this.RT821ToolStripMenuItem.Checked = false;
					this.RT850ToolStripMenuItem.Checked = false;
					Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 107030)
			{
				if (!RT_geral.Telas_GC_82x.Configuracao)
				{
					RT_geral.Telas_RT_820.Configuracao = true;
					new GC_82x_conf
					{
						MdiParent = this,
						QualModelo = Geral.Equipamento_selecionado,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = true;
					this.ToolStripButton_Calibracao.Enabled = true;
					this.ToolStripButton_Monitoracao.Enabled = true;
					this.RT810ToolStripMenuItem.Checked = false;
					this.RT820ToolStripMenuItem.Checked = true;
					this.RT821ToolStripMenuItem.Checked = false;
					this.RT850ToolStripMenuItem.Checked = false;
					Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 207030)
			{
				if (!RT_geral.Telas_GC_82x.Calibracao)
				{
					RT_geral.Telas_RT_820.Calibracao = true;
					new GC_82x_calib
					{
						MdiParent = this,
						QualModelo = Geral.Ctrl_adicional,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = true;
					this.ToolStripButton_Calibracao.Enabled = true;
					this.ToolStripButton_Monitoracao.Enabled = true;
					Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 102036)
			{
				if (!RT_geral.Telas_RT_820_360.Configuracao)
				{
					RT_geral.Telas_RT_820.Configuracao = true;
					new RT_820_360_conf
					{
						MdiParent = this,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = true;
					this.ToolStripButton_Calibracao.Enabled = true;
					this.ToolStripButton_Monitoracao.Enabled = true;
					this.RT810ToolStripMenuItem.Checked = false;
					this.RT820ToolStripMenuItem.Checked = true;
					this.RT821ToolStripMenuItem.Checked = false;
					this.RT850ToolStripMenuItem.Checked = false;
					Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 102040)
			{
				if (!RT_geral.Telas_RT_820_360.Configuracao)
				{
					RT_geral.Telas_RT_820.Configuracao = true;
					new RT_820_360_conf
					{
						MdiParent = this,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = true;
					this.ToolStripButton_Calibracao.Enabled = true;
					this.ToolStripButton_Monitoracao.Enabled = true;
					this.RT810ToolStripMenuItem.Checked = false;
					this.RT820ToolStripMenuItem.Checked = true;
					this.RT821ToolStripMenuItem.Checked = false;
					this.RT850ToolStripMenuItem.Checked = false;
					Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 102020)
			{
				if (!RT_geral.Telas_RT_820_200.Configuracao)
				{
					RT_geral.Telas_RT_820_200.Configuracao = true;
					new RT_820_200_conf
					{
						MdiParent = this,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = true;
					this.ToolStripButton_Calibracao.Enabled = true;
					this.ToolStripButton_Monitoracao.Enabled = true;
					this.RT810ToolStripMenuItem.Checked = false;
					this.RT820ToolStripMenuItem.Checked = true;
					this.RT821ToolStripMenuItem.Checked = false;
					this.RT850ToolStripMenuItem.Checked = false;
					Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 103030)
			{
				if (!RT_geral.Telas_RT_821.Configuracao)
				{
					RT_geral.Telas_RT_821.Configuracao = true;
					new RT_821_Conf
					{
						MdiParent = this,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = true;
					this.ToolStripButton_Calibracao.Enabled = true;
					this.ToolStripButton_Monitoracao.Enabled = true;
					this.RT810ToolStripMenuItem.Checked = false;
					this.RT820ToolStripMenuItem.Checked = false;
					this.RT821ToolStripMenuItem.Checked = true;
					this.RT850ToolStripMenuItem.Checked = false;
					Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 103020)
			{
				if (!RT_geral.Telas_RT_821_200.Configuracao)
				{
					RT_geral.Telas_RT_821_200.Configuracao = true;
					new RT_821_200_conf
					{
						MdiParent = this,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = true;
					this.ToolStripButton_Calibracao.Enabled = true;
					this.ToolStripButton_Monitoracao.Enabled = true;
					this.RT810ToolStripMenuItem.Checked = false;
					this.RT820ToolStripMenuItem.Checked = false;
					this.RT821ToolStripMenuItem.Checked = true;
					this.RT850ToolStripMenuItem.Checked = false;
					Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 105020)
			{
				if (!RT_geral.Telas_RT_830_200.Configuracao)
				{
					RT_geral.Telas_RT_830_200.Configuracao = true;
					new RT_830_200_configurador
					{
						MdiParent = this,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = true;
					this.ToolStripButton_Calibracao.Enabled = false;
					this.ToolStripButton_Monitoracao.Enabled = false;
					this.RT810ToolStripMenuItem.Checked = false;
					this.RT820ToolStripMenuItem.Checked = false;
					this.RT821ToolStripMenuItem.Checked = false;
					this.RT850ToolStripMenuItem.Checked = true;
					Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 106020)
			{
				if (!RT_geral.Telas_RT_831_200.Configuracao)
				{
					RT_geral.Telas_RT_831_200.Configuracao = true;
					new RT_831_200_configurador
					{
						MdiParent = this,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = true;
					this.ToolStripButton_Calibracao.Enabled = false;
					this.ToolStripButton_Monitoracao.Enabled = false;
					this.RT810ToolStripMenuItem.Checked = false;
					this.RT820ToolStripMenuItem.Checked = false;
					this.RT821ToolStripMenuItem.Checked = false;
					this.RT850ToolStripMenuItem.Checked = true;
					Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 104030)
			{
				if (!RT_geral.Telas_RT_850.Configuracao)
				{
					RT_geral.Telas_RT_850.Configuracao = true;
					new RT_850_conf
					{
						MdiParent = this,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = true;
					this.ToolStripButton_Calibracao.Enabled = false;
					this.ToolStripButton_Monitoracao.Enabled = false;
					this.RT810ToolStripMenuItem.Checked = false;
					this.RT820ToolStripMenuItem.Checked = false;
					this.RT821ToolStripMenuItem.Checked = false;
					this.RT850ToolStripMenuItem.Checked = true;
					Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 302030 || num == 302040)
			{
				if (!RT_geral.Telas_RT_820.Monitoracao)
				{
					Comunicacao.Ctrl_Com.Tipo_protocolo = 2;
					RT_geral.Telas_RT_820.Monitoracao = true;
					new Equip_820_mon
					{
						MdiParent = this,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = false;
					this.ToolStripButton_Calibracao.Enabled = false;
					this.ToolStripButton_Monitoracao.Enabled = true;
					this.RT810ToolStripMenuItem.Checked = false;
					this.RT820ToolStripMenuItem.Checked = false;
					this.RT821ToolStripMenuItem.Checked = false;
					this.RT850ToolStripMenuItem.Checked = true;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 303030)
			{
				if (!RT_geral.Telas_RT_821.Monitoracao)
				{
					Comunicacao.Ctrl_Com.Tipo_protocolo = 2;
					RT_geral.Telas_RT_821.Monitoracao = true;
					new Equip_821_mon
					{
						MdiParent = this,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = false;
					this.ToolStripButton_Calibracao.Enabled = false;
					this.ToolStripButton_Monitoracao.Enabled = true;
					this.RT810ToolStripMenuItem.Checked = false;
					this.RT820ToolStripMenuItem.Checked = false;
					this.RT821ToolStripMenuItem.Checked = false;
					this.RT850ToolStripMenuItem.Checked = true;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else if (num == 301030)
			{
				if (!RT_geral.Telas_RT_810.Monitoracao)
				{
					Comunicacao.Ctrl_Com.Tipo_protocolo = 2;
					RT_geral.Telas_RT_810.Monitoracao = true;
					new Equip_810_mon
					{
						MdiParent = this,
						StartPosition = 1
					}.Show();
					this.ToolStripButton_Configuracao.Enabled = false;
					this.ToolStripButton_Calibracao.Enabled = false;
					this.ToolStripButton_Monitoracao.Enabled = true;
					this.RT810ToolStripMenuItem.Checked = false;
					this.RT820ToolStripMenuItem.Checked = false;
					this.RT821ToolStripMenuItem.Checked = false;
					this.RT850ToolStripMenuItem.Checked = true;
				}
				else
				{
					Interaction.MsgBox("Tela de configuração já carregada !", 0, null);
				}
			}
			else
			{
				this.ToolStripButton_Configuracao.Enabled = false;
				this.ToolStripButton_Calibracao.Enabled = false;
				this.ToolStripButton_Monitoracao.Enabled = false;
				this.RT810ToolStripMenuItem.Checked = false;
				this.RT820ToolStripMenuItem.Checked = false;
				this.RT821ToolStripMenuItem.Checked = false;
				this.RT850ToolStripMenuItem.Checked = false;
			}
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x0042ADE4 File Offset: 0x004291E4
		private void Configuracao_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Geral.Ctrl_operacao = 100000;
			this.Seleciona_tela(true);
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x0042ADF8 File Offset: 0x004291F8
		private void Monitoração_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Equip_820_mon
			{
				MdiParent = this
			}.Show();
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x0042AE18 File Offset: 0x00429218
		private void Calibração_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Geral.Ctrl_operacao = 200000;
			this.Seleciona_tela(true);
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x0042AE2C File Offset: 0x0042922C
		private void ToolStripButton_serial_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Configuracao.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			MyProject.Forms.Configuracao.ShowDialog();
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x0042AE50 File Offset: 0x00429250
		private void ToolStripComboBox_equipamento_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x0042AE54 File Offset: 0x00429254
		private void RT810_Versão30ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Geral.Ctrl_equipamento = 1000;
			Geral.Ctrl_versao = 30;
			Geral.Ctrl_operacao = 100000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 1;
			Geral.Equipamento_selecionado = 810;
			Geral.Equipamento_versao = 3;
			Geral.Equipamento_build = 0;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x0042AEB8 File Offset: 0x004292B8
		private void RT821_Versão30ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Geral.Ctrl_equipamento = 3000;
			Geral.Ctrl_versao = 30;
			Geral.Ctrl_operacao = 100000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 3;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x0042AF08 File Offset: 0x00429308
		private void RT820_Versão30ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Geral.Ctrl_equipamento = 2000;
			Geral.Ctrl_versao = 30;
			Geral.Ctrl_operacao = 100000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 2;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x0042AF58 File Offset: 0x00429358
		private void RT850_Versão30ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Geral.Ctrl_equipamento = 4000;
			Geral.Ctrl_versao = 30;
			Geral.Ctrl_operacao = 100000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 4;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x0042AFA8 File Offset: 0x004293A8
		private void ToolStripComboBox_versao_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x0042AFAC File Offset: 0x004293AC
		private void ToolStripButton_sobre_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Sobre.ShowDialog();
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x0042AFC0 File Offset: 0x004293C0
		private void Versão20ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			Geral.Ctrl_equipamento = 1000;
			Geral.Ctrl_versao = 20;
			Geral.Ctrl_operacao = 100000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 1;
			Geral.Equipamento_selecionado = 810;
			Geral.Equipamento_versao = 2;
			Geral.Equipamento_build = 0;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x0042B040 File Offset: 0x00429440
		private void Versão20ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			Geral.Ctrl_equipamento = 2000;
			Geral.Ctrl_versao = 20;
			Geral.Ctrl_operacao = 100000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 2;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x0042B0A8 File Offset: 0x004294A8
		private void Versão20ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			Geral.Ctrl_equipamento = 3000;
			Geral.Ctrl_versao = 20;
			Geral.Ctrl_operacao = 100000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 3;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x0042B110 File Offset: 0x00429510
		private void ToolStripButton_FindEquip_Click(object sender, EventArgs e)
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
			Comunicacao.Config_sistema.endereco_encontrado = false;
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Leitura_pagina_multi_interface(0, 255, 4);
			if (!ctrl_RESP_.Status)
			{
				MessageBox.Show(ctrl_RESP_.Msg);
				Comunicacao.Config_sistema.endereco_encontrado = false;
				return;
			}
			checked
			{
				int num = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
				int num2 = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
				int build = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
				int release = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
				int num3 = num;
				if (num3 == 810 || num3 == 820 || num3 == 821 || num3 == 830 || num3 == 831 || num3 == 850 || num3 == 855 || num3 == 856)
				{
					new Discover
					{
						equipamento = num,
						versao = num2,
						build = build,
						release = release,
						MdiParent = this
					}.Show();
				}
				else if (num3 == 824 || num3 == 828 || num3 == 920)
				{
					Discover discover = new Discover();
					if (num == 920 & num2 == 300)
					{
						num2 = 3;
					}
					discover.equipamento = num;
					discover.versao = num2;
					discover.build = build;
					discover.release = release;
					discover.MdiParent = this;
					discover.Show();
				}
				else
				{
					MessageBox.Show(string.Format("Equipamento {0} não suportado, contate o fornecedor!", num));
				}
				Comunicacao.Config_sistema.endereco_encontrado = false;
			}
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x0042B2D4 File Offset: 0x004296D4
		private void Versão20ToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			Geral.Ctrl_equipamento = 5000;
			Geral.Ctrl_versao = 20;
			Geral.Ctrl_operacao = 100000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 3;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x0042B33C File Offset: 0x0042973C
		private void Versão20ToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			Geral.Ctrl_equipamento = 6000;
			Geral.Ctrl_versao = 20;
			Geral.Ctrl_operacao = 100000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 3;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x0042B3A4 File Offset: 0x004297A4
		private string Trata_Cal_SA(int Def4ma, int Def20mA, int qtd_SA, int buf4mA, int buf20mA)
		{
			string text = "Calibração SA para 4mA:" + Environment.NewLine;
			int num = 0;
			checked
			{
				int num2 = qtd_SA - 1;
				for (int i = num; i <= num2; i++)
				{
					int num3 = (int)Comunicacao.Buffer_resp[buf4mA + i * 2] * 256 + (int)Comunicacao.Buffer_resp[buf4mA + 1 + i * 2];
					if (num3 == 0)
					{
						text = string.Concat(new string[]
						{
							text,
							string.Format("Ch{0}=", i + 1),
							num3.ToString(),
							" Erro!",
							Environment.NewLine
						});
					}
					else if (num3 == Def4ma)
					{
						text = string.Concat(new string[]
						{
							text,
							string.Format("Ch{0}=", i + 1),
							num3.ToString(),
							" Valor de Referência",
							Environment.NewLine
						});
					}
					else if (num3 >= 4095)
					{
						text = string.Concat(new string[]
						{
							text,
							string.Format("Ch{0}=", i + 1),
							num3.ToString(),
							" Erro!",
							Environment.NewLine
						});
					}
					else
					{
						decimal num4 = new decimal((double)num3 / (double)Def4ma);
						if (decimal.Compare(num4, 1m) >= 0)
						{
							num4 = decimal.Subtract(num4, 1m);
						}
						else if (decimal.Compare(num4, 1m) < 0)
						{
							num4 = decimal.Subtract(1m, num4);
						}
						num4 = decimal.Multiply(num4, 100m);
						text = string.Concat(new string[]
						{
							text,
							string.Format("Ch{0}=", i + 1),
							num3.ToString(),
							"         ",
							string.Format("{0:00.0}%", num4),
							Environment.NewLine
						});
					}
				}
				text = text + Environment.NewLine + "Calibração SA para 20mA:" + Environment.NewLine;
				int num5 = 0;
				int num6 = qtd_SA - 1;
				for (int i = num5; i <= num6; i++)
				{
					int num7 = (int)Comunicacao.Buffer_resp[buf20mA + i * 2] * 256 + (int)Comunicacao.Buffer_resp[buf20mA + 1 + i * 2];
					if (num7 == 0)
					{
						text = string.Concat(new string[]
						{
							text,
							string.Format("Ch{0}=", i + 1),
							num7.ToString(),
							" Erro!",
							Environment.NewLine
						});
					}
					else if (num7 == Def20mA)
					{
						text = string.Concat(new string[]
						{
							text,
							string.Format("Ch{0}=", i + 1),
							num7.ToString(),
							" Valor de Referência",
							Environment.NewLine
						});
					}
					else if (num7 >= 4095)
					{
						text = string.Concat(new string[]
						{
							text,
							string.Format("Ch{0}=", i + 1),
							num7.ToString(),
							" Erro!",
							Environment.NewLine
						});
					}
					else
					{
						decimal num4 = new decimal((double)num7 / (double)Def20mA);
						if (decimal.Compare(num4, 1m) >= 0)
						{
							num4 = decimal.Subtract(num4, 1m);
						}
						else if (decimal.Compare(num4, 1m) < 0)
						{
							num4 = decimal.Subtract(1m, num4);
						}
						num4 = decimal.Multiply(num4, 100m);
						text = string.Concat(new string[]
						{
							text,
							string.Format("Ch{0}=", i + 1),
							num7.ToString(),
							"         ",
							string.Format("{0:00.0}%", num4),
							Environment.NewLine
						});
					}
				}
				return text;
			}
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x0042B7AC File Offset: 0x00429BAC
		private string Trata_Cal(int Def4ma, int Def20mA, int qtd_EA, int buf4mA, int buf20mA)
		{
			string text = "Calibração para 4mA:" + Environment.NewLine;
			int num = 0;
			checked
			{
				int num2 = qtd_EA - 1;
				for (int i = num; i <= num2; i++)
				{
					int num3 = (int)Comunicacao.Buffer_resp[buf4mA + i * 2] * 256 + (int)Comunicacao.Buffer_resp[buf4mA + 1 + i * 2];
					if (num3 == 0)
					{
						text = string.Concat(new string[]
						{
							text,
							string.Format("Ch{0}=", i + 1),
							num3.ToString(),
							" Erro!",
							Environment.NewLine
						});
					}
					else if (num3 == Def4ma)
					{
						text = string.Concat(new string[]
						{
							text,
							string.Format("Ch{0}=", i + 1),
							num3.ToString(),
							" Valor Default - Não Calibrado",
							Environment.NewLine
						});
					}
					else if (num3 >= 4095)
					{
						text = string.Concat(new string[]
						{
							text,
							string.Format("Ch{0}=", i + 1),
							num3.ToString(),
							" Erro!",
							Environment.NewLine
						});
					}
					else
					{
						decimal num4 = new decimal((double)num3 / (double)Def4ma);
						if (decimal.Compare(num4, 1m) >= 0)
						{
							num4 = decimal.Subtract(num4, 1m);
						}
						else if (decimal.Compare(num4, 1m) < 0)
						{
							num4 = decimal.Subtract(1m, num4);
						}
						num4 = decimal.Multiply(num4, 100m);
						text = string.Concat(new string[]
						{
							text,
							string.Format("Ch{0}=", i + 1),
							num3.ToString(),
							"         ",
							string.Format("{0:00.0}%", num4),
							Environment.NewLine
						});
					}
				}
				text = text + Environment.NewLine + "Calibração para 20mA:" + Environment.NewLine;
				int num5 = 0;
				int num6 = qtd_EA - 1;
				for (int i = num5; i <= num6; i++)
				{
					int num7 = (int)Comunicacao.Buffer_resp[buf20mA + i * 2] * 256 + (int)Comunicacao.Buffer_resp[buf20mA + 1 + i * 2];
					if (num7 == 0)
					{
						text = string.Concat(new string[]
						{
							text,
							string.Format("Ch{0}=", i + 1),
							num7.ToString(),
							" Erro!",
							Environment.NewLine
						});
					}
					else if (num7 == Def20mA)
					{
						text = string.Concat(new string[]
						{
							text,
							string.Format("Ch{0}=", i + 1),
							num7.ToString(),
							" Valor Default - Não Calibrado",
							Environment.NewLine
						});
					}
					else if (num7 >= 4095)
					{
						text = string.Concat(new string[]
						{
							text,
							string.Format("Ch{0}=", i + 1),
							num7.ToString(),
							" Erro!",
							Environment.NewLine
						});
					}
					else
					{
						decimal num4 = new decimal((double)num7 / (double)Def20mA);
						if (decimal.Compare(num4, 1m) >= 0)
						{
							num4 = decimal.Subtract(num4, 1m);
						}
						else if (decimal.Compare(num4, 1m) < 0)
						{
							num4 = decimal.Subtract(1m, num4);
						}
						num4 = decimal.Multiply(num4, 100m);
						text = string.Concat(new string[]
						{
							text,
							string.Format("Ch{0}=", i + 1),
							num7.ToString(),
							"         ",
							string.Format("{0:00.0}%", num4),
							Environment.NewLine
						});
					}
				}
				return text;
			}
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x0042BBB4 File Offset: 0x00429FB4
		private void ExecutaCalibracaoGC(int equipamento)
		{
			MessageBox.Show("oia que maravilha");
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x0042BBC4 File Offset: 0x00429FC4
		private void ExecutaCalibracaoRT(int equipamento, int versao)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int bloco;
			switch (equipamento)
			{
			case 810:
				if (versao == 200)
				{
					bloco = 1;
					num = 1;
					num2 = 8;
					num3 = 0;
				}
				else if (versao == 300)
				{
					bloco = 4;
					num = 4;
					num2 = 8;
					num3 = 1;
				}
				break;
			case 820:
				if (versao == 200)
				{
					bloco = 2;
					num = 16;
					num2 = 8;
					num3 = 8;
				}
				else if (versao == 300)
				{
					bloco = 5;
					num = 16;
					num2 = 8;
					num3 = 8;
				}
				else if (versao == 400)
				{
					bloco = 5;
					num = 0;
					num2 = 0;
					num3 = 0;
				}
				break;
			case 821:
				if (versao == 200)
				{
					bloco = 3;
					num = 0;
					num2 = 8;
					num3 = 3;
				}
				else if (versao == 300)
				{
					bloco = 6;
					num = 4;
					num2 = 8;
					num3 = 3;
				}
				break;
			}
			Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
			if (!Mod_MD.Escrita_pagina_RT(256, 2010, bloco).Status)
			{
				MessageBox.Show("Calibração não respondeu ao comando de início!");
				return;
			}
			Comunicacao.Rotina_Delay(1000L);
			for (;;)
			{
				Application.DoEvents();
				if (!Mod_MD.Leitura_pagina(768, 1, 1).Status)
				{
					break;
				}
				int num4 = Linha_RT.Atualiza_GT2010(768);
				Comunicacao.Rotina_Delay(5000L);
				if (num4 == 1)
				{
					goto Block_11;
				}
			}
			MessageBox.Show("Calibração não respondeu ao comando de status!");
			return;
			Block_11:
			if (!Mod_MD.Leitura_pagina(512, 1, 80).Status)
			{
				MessageBox.Show("Calibração não respondeu ao comando de resultado!");
				return;
			}
			string text = string.Concat(new string[]
			{
				"Resultado de Calibração para o equipamento RT",
				equipamento.ToString(),
				"_",
				versao.ToString(),
				":",
				Environment.NewLine,
				Environment.NewLine
			});
			checked
			{
				if (num > 0)
				{
					text = text + "Calibração Analógica" + Environment.NewLine;
					text = text + "Canal:  4mA:    20mA:  Resultado: (%)" + Environment.NewLine;
					int num5 = 0;
					int num6 = num - 1;
					for (int i = num5; i <= num6; i++)
					{
						text = text + (i + 1).ToString("D2") + "       ";
						int num7 = 67 + i * 2;
						int num8 = (int)Comunicacao.Buffer_resp[num7] * 256;
						num7++;
						num8 += (int)Comunicacao.Buffer_resp[num7];
						text = text + num8.ToString("D5") + "   ";
						num7 = 99 + i * 2;
						int num9 = (int)Comunicacao.Buffer_resp[num7] * 256;
						num7++;
						num9 += (int)Comunicacao.Buffer_resp[num7];
						text = text + num9.ToString("D5") + "       ";
						decimal num10 = new decimal((double)num8 / 112.0);
						if (decimal.Compare(num10, 1m) >= 0)
						{
							num10 = decimal.Subtract(num10, 1m);
						}
						else if (decimal.Compare(num10, 1m) < 0)
						{
							num10 = decimal.Subtract(1m, num10);
						}
						num10 = decimal.Multiply(num10, 100m);
						text = text + string.Format("{0:00.0}", num10) + "   ";
						decimal num11 = new decimal((double)num9 / 4018.0);
						if (decimal.Compare(num11, 1m) >= 0)
						{
							num11 = decimal.Subtract(num11, 1m);
						}
						else if (decimal.Compare(num11, 1m) < 0)
						{
							num11 = decimal.Subtract(1m, num11);
						}
						num11 = decimal.Multiply(num11, 100m);
						text = text + string.Format("{0:00.0}", num11) + " ";
						text += Environment.NewLine;
					}
				}
				if (num2 > 0)
				{
					text += Environment.NewLine;
					text = text + "Calibração Entradas Digitais" + Environment.NewLine;
					text = text + "Canal:  Valor:  Resultado:" + Environment.NewLine;
					int num9 = 1;
					int num12 = 0;
					int num13 = num2 - 1;
					for (int i = num12; i <= num13; i++)
					{
						text = text + (i + 1).ToString("D2") + "       ";
						int num7 = 3 + i * 2;
						int num8 = (int)Comunicacao.Buffer_resp[num7] * 256;
						num7++;
						num8 += (int)Comunicacao.Buffer_resp[num7];
						string text2;
						if (num8 == num9)
						{
							text2 = "OK";
						}
						else
						{
							text2 = "???";
						}
						text = string.Concat(new string[]
						{
							text,
							num8.ToString("X4"),
							"       ",
							text2,
							Environment.NewLine
						});
						num9 *= 2;
					}
				}
				if (num3 > 0)
				{
					text += Environment.NewLine;
					text = text + "Calibração Saídas Digitais" + Environment.NewLine;
					text = text + "Canal:  Valor:  Resultado:" + Environment.NewLine;
					int num9 = 1;
					int num14 = 0;
					int num15 = num3 - 1;
					for (int i = num14; i <= num15; i++)
					{
						text = text + (i + 1).ToString("D2") + "       ";
						int num7 = 35 + i * 2;
						int num8 = (int)Comunicacao.Buffer_resp[num7] * 256;
						num7++;
						num8 += (int)Comunicacao.Buffer_resp[num7];
						string text2;
						if (num8 == num9)
						{
							text2 = "OK";
						}
						else
						{
							text2 = "???";
						}
						num9 *= 2;
						text = string.Concat(new string[]
						{
							text,
							num8.ToString("X4"),
							"       ",
							text2,
							Environment.NewLine
						});
					}
				}
				MessageBox.Show(text);
			}
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x0042C1A8 File Offset: 0x0042A5A8
		private void MostaCalibracao420PlacaSA(int equipamento, int versao)
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
			if (!Mod_MD.Leitura_pagina(0, 255, 4).Status)
			{
				MessageBox.Show("Não houve resposta do equipamento!");
				return;
			}
			checked
			{
				int num = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
				int num2 = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
				int num3 = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
				int num4 = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
				if (equipamento != num | versao != num2 * 100)
				{
					MessageBox.Show("Equipamento não corresponde ao solicitado!");
					return;
				}
				Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				Mod_MD.CTRL_RESP_1 ctrl_RESP_;
				switch (num2)
				{
				case 2:
					ctrl_RESP_ = Mod_MD.Leitura_pagina(256, 255, 1);
					break;
				case 3:
					ctrl_RESP_ = Mod_MD.Leitura_pagina(2048, 255, 1);
					break;
				case 4:
					ctrl_RESP_ = Mod_MD.Leitura_pagina(2048, 255, 1);
					break;
				default:
					MessageBox.Show("Versão de Placa inconsistente!");
					return;
				}
				if (!ctrl_RESP_.Status)
				{
					MessageBox.Show("Não houve resposta do equipamento!");
					return;
				}
				int endereco = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
				int num5 = num2;
				if (num5 != 4)
				{
					MessageBox.Show("Versão de Placa inconsistente!");
					return;
				}
				if (!Mod_MD.Leitura_pagina(6176, endereco, 4).Status)
				{
					MessageBox.Show("Não houve resposta do equipamento!");
					return;
				}
				endereco = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
				string text = "Equipamento: " + string.Format("RT{0}_{1}_{2}", num, num2 * 100 + num3, num4) + Environment.NewLine + Environment.NewLine;
				int num6 = num;
				if (num6 == 820)
				{
					int num7 = num2;
					if (num7 == 4)
					{
						text += this.Trata_Cal_SA(750, 3800, 2, 3, 7);
						MessageBox.Show(text, "Resultado da Calibração:");
					}
				}
			}
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x0042C3CC File Offset: 0x0042A7CC
		private void MostaCalibracao420Placa(int equipamento, int versao)
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
			if (!Mod_MD.Leitura_pagina(0, 255, 4).Status)
			{
				MessageBox.Show("Não houve resposta do equipamento!");
				return;
			}
			checked
			{
				int num = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
				int num2 = (int)Comunicacao.Buffer_resp[5] * 256 + (int)Comunicacao.Buffer_resp[6];
				int num3 = (int)Comunicacao.Buffer_resp[7] * 256 + (int)Comunicacao.Buffer_resp[8];
				int num4 = (int)Comunicacao.Buffer_resp[9] * 256 + (int)Comunicacao.Buffer_resp[10];
				if (equipamento != num | versao != num2 * 100)
				{
					MessageBox.Show("Equipamento não corresponde ao solicitado!");
					return;
				}
				Comunicacao.Ctrl_Com.Tipo_protocolo = 1;
				Mod_MD.CTRL_RESP_1 ctrl_RESP_;
				switch (num2)
				{
				case 2:
					ctrl_RESP_ = Mod_MD.Leitura_pagina(256, 255, 1);
					break;
				case 3:
					ctrl_RESP_ = Mod_MD.Leitura_pagina(2048, 255, 1);
					break;
				case 4:
					ctrl_RESP_ = Mod_MD.Leitura_pagina(2048, 255, 1);
					break;
				default:
					MessageBox.Show("Versão de Placa inconsistente!");
					return;
				}
				if (!ctrl_RESP_.Status)
				{
					MessageBox.Show("Não houve resposta do equipamento!");
					return;
				}
				int endereco = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
				switch (num2)
				{
				case 2:
					ctrl_RESP_ = Mod_MD.Leitura_pagina(768, endereco, 32);
					break;
				case 3:
				case 4:
					ctrl_RESP_ = Mod_MD.Leitura_pagina(6144, endereco, 32);
					break;
				default:
					MessageBox.Show("Versão de Placa inconsistente!");
					return;
				}
				if (!ctrl_RESP_.Status)
				{
					MessageBox.Show("Não houve resposta do equipamento!");
					return;
				}
				endereco = (int)Comunicacao.Buffer_resp[3] * 256 + (int)Comunicacao.Buffer_resp[4];
				string text = "Equipamento: " + string.Format("RT{0}_{1}_{2}", num, num2 * 100 + num3, num4) + Environment.NewLine + Environment.NewLine;
				switch (num)
				{
				case 810:
					switch (num2)
					{
					case 2:
						text += this.Trata_Cal(112, 4018, 1, 3, 11);
						MessageBox.Show(text, "Resultado da Calibração:");
						break;
					case 3:
						text += this.Trata_Cal(112, 4018, 4, 3, 35);
						MessageBox.Show(text, "Resultado da Calibração:");
						break;
					}
					break;
				case 820:
					switch (num2)
					{
					case 2:
					case 3:
					case 4:
						text += this.Trata_Cal(112, 4018, 16, 3, 35);
						MessageBox.Show(text, "Resultado da Calibração:");
						break;
					}
					break;
				case 821:
				{
					int num5 = num2;
					if (num5 == 3)
					{
						text += this.Trata_Cal(112, 4018, 4, 3, 35);
						MessageBox.Show(text, "Resultado da Calibração:");
					}
					break;
				}
				}
			}
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x0042C6EC File Offset: 0x0042AAEC
		private void LeituraCalibração420mADaPlacaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			this.MostaCalibracao420Placa(810, 300);
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x0042C71C File Offset: 0x0042AB1C
		private void LeituraCalibraçãoDaPlacaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			this.MostaCalibracao420Placa(810, 200);
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x0042C74C File Offset: 0x0042AB4C
		private void LeituraCalibração420mADaPlacaToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			this.MostaCalibracao420Placa(820, 200);
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x0042C77C File Offset: 0x0042AB7C
		private void LeituraCalibração420mADaPlacaToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			this.MostaCalibracao420Placa(820, 300);
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x0042C7AC File Offset: 0x0042ABAC
		private void LeituraCalibração420mADaPlacaToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			this.MostaCalibracao420Placa(821, 300);
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x0042C7DC File Offset: 0x0042ABDC
		private void ExecutaCalibraçãoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			this.ExecutaCalibracaoRT(810, 300);
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x0042C80C File Offset: 0x0042AC0C
		private void ExecutaCalibraçãoToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			this.ExecutaCalibracaoRT(810, 200);
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x0042C83C File Offset: 0x0042AC3C
		private void ExecutaCalibraçãoToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			this.ExecutaCalibracaoRT(820, 200);
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x0042C86C File Offset: 0x0042AC6C
		private void ExecutaCalibraçãoToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			this.ExecutaCalibracaoRT(820, 300);
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x0042C89C File Offset: 0x0042AC9C
		private void ExecutaCalibraçãoToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			this.ExecutaCalibracaoRT(821, 300);
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x0042C8CC File Offset: 0x0042ACCC
		private void ExecutaCalibraçãoToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			this.ExecutaCalibracaoRT(821, 200);
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x0042C8FC File Offset: 0x0042ACFC
		private void ToolStripButton_Configuracao_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x0042C900 File Offset: 0x0042AD00
		private void ToolStripButton_Calibracao_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x0042C904 File Offset: 0x0042AD04
		private void Versão300ToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			Geral.Ctrl_equipamento = 2000;
			Geral.Ctrl_versao = 30;
			Geral.Ctrl_operacao = 300000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 1;
			Geral.Equipamento_selecionado = 820;
			Geral.Equipamento_versao = 3;
			Geral.Equipamento_build = 0;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x0042C984 File Offset: 0x0042AD84
		private void Versão300ToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			Geral.Ctrl_equipamento = 3000;
			Geral.Ctrl_versao = 30;
			Geral.Ctrl_operacao = 300000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 1;
			Geral.Equipamento_selecionado = 821;
			Geral.Equipamento_versao = 3;
			Geral.Equipamento_build = 0;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x0042CA04 File Offset: 0x0042AE04
		private void Versão300ToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			Geral.Ctrl_equipamento = 1000;
			Geral.Ctrl_versao = 30;
			Geral.Ctrl_operacao = 300000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 1;
			Geral.Equipamento_selecionado = 810;
			Geral.Equipamento_versao = 3;
			Geral.Equipamento_build = 0;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x0042CA84 File Offset: 0x0042AE84
		private void LogComunicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new LogComunicacao
			{
				MdiParent = this,
				StartPosition = 1
			}.Show();
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x0042CAAC File Offset: 0x0042AEAC
		private void Timer_timeout2_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x0042CAB0 File Offset: 0x0042AEB0
		private void RT810ToolStripMenuItem_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x0042CAB4 File Offset: 0x0042AEB4
		private void Versão36ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Geral.Ctrl_equipamento = 2000;
			Geral.Ctrl_versao = 40;
			Geral.Ctrl_operacao = 100000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 2;
			Geral.Equipamento_selecionado = 820;
			Geral.Equipamento_versao = 4;
			Geral.Equipamento_build = 0;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x0042CB18 File Offset: 0x0042AF18
		private void RT810ToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x0042CB1C File Offset: 0x0042AF1C
		private void LeituraCalibração420mADaPlacaToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			this.MostaCalibracao420Placa(820, 400);
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x0042CB4C File Offset: 0x0042AF4C
		private void ExecutaCalibraçãoToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			this.ExecutaCalibracaoRT(820, 300);
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x0042CB7C File Offset: 0x0042AF7C
		private void GC824ToolStripTextBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x0042CB80 File Offset: 0x0042AF80
		private void Versão300ToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			Geral.Ctrl_equipamento = 7000;
			Geral.Ctrl_versao = 30;
			Geral.Ctrl_operacao = 100000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 1;
			Geral.Equipamento_selecionado = 824;
			Geral.Equipamento_versao = 3;
			Geral.Equipamento_build = 0;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x0042CC00 File Offset: 0x0042B000
		private void Versão300ToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			Geral.Ctrl_equipamento = 7000;
			Geral.Ctrl_versao = 30;
			Geral.Ctrl_operacao = 100000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 1;
			Geral.Equipamento_selecionado = 824;
			Geral.Equipamento_versao = 3;
			Geral.Equipamento_build = 0;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x0042CC80 File Offset: 0x0042B080
		private void ExecutaCalibraçãoToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			Geral.Ctrl_equipamento = 7000;
			Geral.Ctrl_versao = 30;
			Geral.Ctrl_operacao = 200000;
			Geral.Ctrl_adicional = 824;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 1;
			Geral.Equipamento_selecionado = 824;
			Geral.Equipamento_versao = 3;
			Geral.Equipamento_build = 0;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x0042CD08 File Offset: 0x0042B108
		private void ExecutaCalibraçãoToolStripMenuItem8_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			Geral.Ctrl_equipamento = 7000;
			Geral.Ctrl_versao = 30;
			Geral.Ctrl_operacao = 200000;
			Geral.Ctrl_adicional = 828;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 1;
			Geral.Equipamento_selecionado = 824;
			Geral.Equipamento_versao = 3;
			Geral.Equipamento_build = 0;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x0042CD90 File Offset: 0x0042B190
		private void Versão300ToolStripMenuItem8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x0042CD94 File Offset: 0x0042B194
		private void TipoDeOperacaoToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x0042CD98 File Offset: 0x0042B198
		private void ToolStripButton1_Click(object sender, EventArgs e)
		{
			PrintDialog printDialog = new PrintDialog();
			if (printDialog.ShowDialog() == 1)
			{
				MessageBox.Show(printDialog.ToString());
			}
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x0042CDC0 File Offset: 0x0042B1C0
		private void LeituraCalibraçãoSA420mADaPlacaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			this.MostaCalibracao420PlacaSA(820, 400);
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x0042CDF0 File Offset: 0x0042B1F0
		private void ExecutaCalibraçãoSAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			new RT_820_400_SA_CALIB
			{
				MdiParent = this,
				StartPosition = 1
			}.Show();
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x0042CE34 File Offset: 0x0042B234
		private void Versão400ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (Comunicacao.Config_sistema.tipo_interface != 1)
			{
				Interaction.MsgBox("Equipamento não suporta a interface selecionada", 0, null);
				return;
			}
			Geral.Ctrl_equipamento = 2000;
			Geral.Ctrl_versao = 40;
			Geral.Ctrl_operacao = 300000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 1;
			Geral.Equipamento_selecionado = 820;
			Geral.Equipamento_versao = 4;
			Geral.Equipamento_build = 0;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x0042CEB4 File Offset: 0x0042B2B4
		private void ToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			Geral.Ctrl_equipamento = 8000;
			Geral.Ctrl_versao = 30;
			Geral.Ctrl_operacao = 100000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 4;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x0042CF04 File Offset: 0x0042B304
		private void IEC856ToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x0042CF08 File Offset: 0x0042B308
		private void Versão300ToolStripMenuItem10_Click(object sender, EventArgs e)
		{
			Geral.Ctrl_equipamento = 9000;
			Geral.Ctrl_versao = 30;
			Geral.Ctrl_operacao = 100000;
			this.ToolStripComboBox_versao.SelectedIndex = 1;
			this.ToolStripComboBox_equipamento.SelectedIndex = 4;
			RT_geral.Lmte_Init_ok = false;
			this.Seleciona_tela(true);
		}

		// Token: 0x04001C2D RID: 7213
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x04001C2E RID: 7214
		[AccessedThroughProperty("MenuEquipamentosToolStripMenuItem")]
		private ToolStripMenuItem _MenuEquipamentosToolStripMenuItem;

		// Token: 0x04001C2F RID: 7215
		[AccessedThroughProperty("TipoDeOperacaoToolStripMenuItem")]
		private ToolStripMenuItem _TipoDeOperacaoToolStripMenuItem;

		// Token: 0x04001C30 RID: 7216
		[AccessedThroughProperty("ArquivosToolStripMenuItem")]
		private ToolStripMenuItem _ArquivosToolStripMenuItem;

		// Token: 0x04001C31 RID: 7217
		[AccessedThroughProperty("NovoProjetoToolStripMenuItem")]
		private ToolStripMenuItem _NovoProjetoToolStripMenuItem;

		// Token: 0x04001C32 RID: 7218
		[AccessedThroughProperty("AbrirToolStripMenuItem")]
		private ToolStripMenuItem _AbrirToolStripMenuItem;

		// Token: 0x04001C33 RID: 7219
		[AccessedThroughProperty("SalvarProjetoToolStripMenuItem")]
		private ToolStripMenuItem _SalvarProjetoToolStripMenuItem;

		// Token: 0x04001C34 RID: 7220
		[AccessedThroughProperty("SerialPort1")]
		private SerialPort _SerialPort1;

		// Token: 0x04001C35 RID: 7221
		[AccessedThroughProperty("Timer_timeout")]
		private Timer _Timer_timeout;

		// Token: 0x04001C36 RID: 7222
		[AccessedThroughProperty("Timer_espera")]
		private Timer _Timer_espera;

		// Token: 0x04001C37 RID: 7223
		[AccessedThroughProperty("Background_ouvidor")]
		private BackgroundWorker _Background_ouvidor;

		// Token: 0x04001C38 RID: 7224
		[AccessedThroughProperty("Timer_ouvidor")]
		private Timer _Timer_ouvidor;

		// Token: 0x04001C39 RID: 7225
		[AccessedThroughProperty("SobreToolStripMenuItem")]
		private ToolStripMenuItem _SobreToolStripMenuItem;

		// Token: 0x04001C3A RID: 7226
		[AccessedThroughProperty("Menu_ouvidor")]
		private ToolStrip _Menu_ouvidor;

		// Token: 0x04001C3B RID: 7227
		[AccessedThroughProperty("Menu_ouvidor_limpa")]
		private ToolStripButton _Menu_ouvidor_limpa;

		// Token: 0x04001C3C RID: 7228
		[AccessedThroughProperty("Menu_ouvidor_Off")]
		private ToolStripButton _Menu_ouvidor_Off;

		// Token: 0x04001C3D RID: 7229
		[AccessedThroughProperty("Menu_ouvidor_On")]
		private ToolStripButton _Menu_ouvidor_On;

		// Token: 0x04001C3E RID: 7230
		[AccessedThroughProperty("RT821ToolStripMenuItem")]
		private ToolStripMenuItem _RT821ToolStripMenuItem;

		// Token: 0x04001C3F RID: 7231
		[AccessedThroughProperty("ToolStrip1")]
		private ToolStrip _ToolStrip1;

		// Token: 0x04001C40 RID: 7232
		[AccessedThroughProperty("ToolStripComboBox_equipamento")]
		private ToolStripComboBox _ToolStripComboBox_equipamento;

		// Token: 0x04001C41 RID: 7233
		[AccessedThroughProperty("ToolStripButton_Configuracao")]
		private ToolStripButton _ToolStripButton_Configuracao;

		// Token: 0x04001C42 RID: 7234
		[AccessedThroughProperty("ToolStripButton_Calibracao")]
		private ToolStripButton _ToolStripButton_Calibracao;

		// Token: 0x04001C43 RID: 7235
		[AccessedThroughProperty("ToolStripButton_Monitoracao")]
		private ToolStripButton _ToolStripButton_Monitoracao;

		// Token: 0x04001C44 RID: 7236
		[AccessedThroughProperty("ToolStripButton_serial")]
		private ToolStripButton _ToolStripButton_serial;

		// Token: 0x04001C45 RID: 7237
		[AccessedThroughProperty("RT810ToolStripMenuItem")]
		private ToolStripMenuItem _RT810ToolStripMenuItem;

		// Token: 0x04001C46 RID: 7238
		[AccessedThroughProperty("RT820ToolStripMenuItem")]
		private ToolStripMenuItem _RT820ToolStripMenuItem;

		// Token: 0x04001C47 RID: 7239
		[AccessedThroughProperty("RT850ToolStripMenuItem")]
		private ToolStripMenuItem _RT850ToolStripMenuItem;

		// Token: 0x04001C48 RID: 7240
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x04001C49 RID: 7241
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x04001C4A RID: 7242
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x04001C4B RID: 7243
		[AccessedThroughProperty("RT810_Versão30ToolStripMenuItem")]
		private ToolStripMenuItem _RT810_Versão30ToolStripMenuItem;

		// Token: 0x04001C4C RID: 7244
		[AccessedThroughProperty("ToolStripComboBox_versao")]
		private ToolStripComboBox _ToolStripComboBox_versao;

		// Token: 0x04001C4D RID: 7245
		[AccessedThroughProperty("RT820_Versão30ToolStripMenuItem")]
		private ToolStripMenuItem _RT820_Versão30ToolStripMenuItem;

		// Token: 0x04001C4E RID: 7246
		[AccessedThroughProperty("RT821_Versão30ToolStripMenuItem")]
		private ToolStripMenuItem _RT821_Versão30ToolStripMenuItem;

		// Token: 0x04001C4F RID: 7247
		[AccessedThroughProperty("RT850_Versão30ToolStripMenuItem")]
		private ToolStripMenuItem _RT850_Versão30ToolStripMenuItem;

		// Token: 0x04001C50 RID: 7248
		[AccessedThroughProperty("ToolStripButton_sobre")]
		private ToolStripButton _ToolStripButton_sobre;

		// Token: 0x04001C51 RID: 7249
		[AccessedThroughProperty("JalenaToolStripMenuItem")]
		private ToolStripMenuItem _JalenaToolStripMenuItem;

		// Token: 0x04001C52 RID: 7250
		[AccessedThroughProperty("Versão20ToolStripMenuItem")]
		private ToolStripMenuItem _Versão20ToolStripMenuItem;

		// Token: 0x04001C53 RID: 7251
		[AccessedThroughProperty("Versão20ToolStripMenuItem1")]
		private ToolStripMenuItem _Versão20ToolStripMenuItem1;

		// Token: 0x04001C54 RID: 7252
		[AccessedThroughProperty("Versão20ToolStripMenuItem2")]
		private ToolStripMenuItem _Versão20ToolStripMenuItem2;

		// Token: 0x04001C55 RID: 7253
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x04001C56 RID: 7254
		[AccessedThroughProperty("ToolStripButton_FindEquip")]
		private ToolStripButton _ToolStripButton_FindEquip;

		// Token: 0x04001C57 RID: 7255
		[AccessedThroughProperty("CT830ToolStripMenuItem")]
		private ToolStripMenuItem _CT830ToolStripMenuItem;

		// Token: 0x04001C58 RID: 7256
		[AccessedThroughProperty("Versão20ToolStripMenuItem3")]
		private ToolStripMenuItem _Versão20ToolStripMenuItem3;

		// Token: 0x04001C59 RID: 7257
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x04001C5A RID: 7258
		[AccessedThroughProperty("Versão20ToolStripMenuItem4")]
		private ToolStripMenuItem _Versão20ToolStripMenuItem4;

		// Token: 0x04001C5B RID: 7259
		[AccessedThroughProperty("CalibraçãoToolStripMenuItem")]
		private ToolStripMenuItem _CalibraçãoToolStripMenuItem;

		// Token: 0x04001C5C RID: 7260
		[AccessedThroughProperty("RT810ToolStripMenuItem1")]
		private ToolStripMenuItem _RT810ToolStripMenuItem1;

		// Token: 0x04001C5D RID: 7261
		[AccessedThroughProperty("Versão200ToolStripMenuItem")]
		private ToolStripMenuItem _Versão200ToolStripMenuItem;

		// Token: 0x04001C5E RID: 7262
		[AccessedThroughProperty("LeituraCalibraçãoDaPlacaToolStripMenuItem")]
		private ToolStripMenuItem _LeituraCalibraçãoDaPlacaToolStripMenuItem;

		// Token: 0x04001C5F RID: 7263
		[AccessedThroughProperty("Versão300ToolStripMenuItem")]
		private ToolStripMenuItem _Versão300ToolStripMenuItem;

		// Token: 0x04001C60 RID: 7264
		[AccessedThroughProperty("LeituraCalibração420mADaPlacaToolStripMenuItem")]
		private ToolStripMenuItem _LeituraCalibração420mADaPlacaToolStripMenuItem;

		// Token: 0x04001C61 RID: 7265
		[AccessedThroughProperty("RT820ToolStripMenuItem1")]
		private ToolStripMenuItem _RT820ToolStripMenuItem1;

		// Token: 0x04001C62 RID: 7266
		[AccessedThroughProperty("Versão200ToolStripMenuItem1")]
		private ToolStripMenuItem _Versão200ToolStripMenuItem1;

		// Token: 0x04001C63 RID: 7267
		[AccessedThroughProperty("LeituraCalibração420mADaPlacaToolStripMenuItem1")]
		private ToolStripMenuItem _LeituraCalibração420mADaPlacaToolStripMenuItem1;

		// Token: 0x04001C64 RID: 7268
		[AccessedThroughProperty("Versão300ToolStripMenuItem1")]
		private ToolStripMenuItem _Versão300ToolStripMenuItem1;

		// Token: 0x04001C65 RID: 7269
		[AccessedThroughProperty("LeituraCalibração420mADaPlacaToolStripMenuItem2")]
		private ToolStripMenuItem _LeituraCalibração420mADaPlacaToolStripMenuItem2;

		// Token: 0x04001C66 RID: 7270
		[AccessedThroughProperty("RT821ToolStripMenuItem1")]
		private ToolStripMenuItem _RT821ToolStripMenuItem1;

		// Token: 0x04001C67 RID: 7271
		[AccessedThroughProperty("Versão300ToolStripMenuItem2")]
		private ToolStripMenuItem _Versão300ToolStripMenuItem2;

		// Token: 0x04001C68 RID: 7272
		[AccessedThroughProperty("LeituraCalibração420mADaPlacaToolStripMenuItem3")]
		private ToolStripMenuItem _LeituraCalibração420mADaPlacaToolStripMenuItem3;

		// Token: 0x04001C69 RID: 7273
		[AccessedThroughProperty("ExecutaCalibraçãoToolStripMenuItem")]
		private ToolStripMenuItem _ExecutaCalibraçãoToolStripMenuItem;

		// Token: 0x04001C6A RID: 7274
		[AccessedThroughProperty("ExecutaCalibraçãoToolStripMenuItem1")]
		private ToolStripMenuItem _ExecutaCalibraçãoToolStripMenuItem1;

		// Token: 0x04001C6B RID: 7275
		[AccessedThroughProperty("ExecutaCalibraçãoToolStripMenuItem2")]
		private ToolStripMenuItem _ExecutaCalibraçãoToolStripMenuItem2;

		// Token: 0x04001C6C RID: 7276
		[AccessedThroughProperty("ExecutaCalibraçãoToolStripMenuItem3")]
		private ToolStripMenuItem _ExecutaCalibraçãoToolStripMenuItem3;

		// Token: 0x04001C6D RID: 7277
		[AccessedThroughProperty("ExecutaCalibraçãoToolStripMenuItem4")]
		private ToolStripMenuItem _ExecutaCalibraçãoToolStripMenuItem4;

		// Token: 0x04001C6E RID: 7278
		[AccessedThroughProperty("Versão200ToolStripMenuItem2")]
		private ToolStripMenuItem _Versão200ToolStripMenuItem2;

		// Token: 0x04001C6F RID: 7279
		[AccessedThroughProperty("ExecutaCalibraçãoToolStripMenuItem5")]
		private ToolStripMenuItem _ExecutaCalibraçãoToolStripMenuItem5;

		// Token: 0x04001C70 RID: 7280
		[AccessedThroughProperty("RT810ToolStripMenuItem2")]
		private ToolStripMenuItem _RT810ToolStripMenuItem2;

		// Token: 0x04001C71 RID: 7281
		[AccessedThroughProperty("Versão300ToolStripMenuItem3")]
		private ToolStripMenuItem _Versão300ToolStripMenuItem3;

		// Token: 0x04001C72 RID: 7282
		[AccessedThroughProperty("RT820ToolStripMenuItem2")]
		private ToolStripMenuItem _RT820ToolStripMenuItem2;

		// Token: 0x04001C73 RID: 7283
		[AccessedThroughProperty("Versão300ToolStripMenuItem4")]
		private ToolStripMenuItem _Versão300ToolStripMenuItem4;

		// Token: 0x04001C74 RID: 7284
		[AccessedThroughProperty("RT821ToolStripMenuItem2")]
		private ToolStripMenuItem _RT821ToolStripMenuItem2;

		// Token: 0x04001C75 RID: 7285
		[AccessedThroughProperty("Versão300ToolStripMenuItem5")]
		private ToolStripMenuItem _Versão300ToolStripMenuItem5;

		// Token: 0x04001C76 RID: 7286
		[AccessedThroughProperty("LogComunicaçãoToolStripMenuItem")]
		private ToolStripMenuItem _LogComunicaçãoToolStripMenuItem;

		// Token: 0x04001C77 RID: 7287
		[AccessedThroughProperty("Timer_timeout2")]
		private Timer _Timer_timeout2;

		// Token: 0x04001C78 RID: 7288
		[AccessedThroughProperty("Versão36ToolStripMenuItem")]
		private ToolStripMenuItem _Versão36ToolStripMenuItem;

		// Token: 0x04001C79 RID: 7289
		[AccessedThroughProperty("Versão400ToolStripMenuItem")]
		private ToolStripMenuItem _Versão400ToolStripMenuItem;

		// Token: 0x04001C7A RID: 7290
		[AccessedThroughProperty("LeituraCalibração420mADaPlacaToolStripMenuItem4")]
		private ToolStripMenuItem _LeituraCalibração420mADaPlacaToolStripMenuItem4;

		// Token: 0x04001C7B RID: 7291
		[AccessedThroughProperty("ExecutaCalibraçãoToolStripMenuItem6")]
		private ToolStripMenuItem _ExecutaCalibraçãoToolStripMenuItem6;

		// Token: 0x04001C7C RID: 7292
		[AccessedThroughProperty("GC828ToolStripMenuItem")]
		private ToolStripMenuItem _GC828ToolStripMenuItem;

		// Token: 0x04001C7D RID: 7293
		[AccessedThroughProperty("ToolStripSeparator5")]
		private ToolStripSeparator _ToolStripSeparator5;

		// Token: 0x04001C7E RID: 7294
		[AccessedThroughProperty("ToolStripSeparator6")]
		private ToolStripSeparator _ToolStripSeparator6;

		// Token: 0x04001C7F RID: 7295
		[AccessedThroughProperty("Versão300ToolStripMenuItem6")]
		private ToolStripMenuItem _Versão300ToolStripMenuItem6;

		// Token: 0x04001C80 RID: 7296
		[AccessedThroughProperty("GC824ToolStripMenuItem")]
		private ToolStripMenuItem _GC824ToolStripMenuItem;

		// Token: 0x04001C81 RID: 7297
		[AccessedThroughProperty("Versão300ToolStripMenuItem7")]
		private ToolStripMenuItem _Versão300ToolStripMenuItem7;

		// Token: 0x04001C82 RID: 7298
		[AccessedThroughProperty("GC824ToolStripMenuItem1")]
		private ToolStripMenuItem _GC824ToolStripMenuItem1;

		// Token: 0x04001C83 RID: 7299
		[AccessedThroughProperty("Versão300ToolStripMenuItem8")]
		private ToolStripMenuItem _Versão300ToolStripMenuItem8;

		// Token: 0x04001C84 RID: 7300
		[AccessedThroughProperty("ExecutaCalibraçãoToolStripMenuItem7")]
		private ToolStripMenuItem _ExecutaCalibraçãoToolStripMenuItem7;

		// Token: 0x04001C85 RID: 7301
		[AccessedThroughProperty("GC828ToolStripMenuItem1")]
		private ToolStripMenuItem _GC828ToolStripMenuItem1;

		// Token: 0x04001C86 RID: 7302
		[AccessedThroughProperty("Versão300ToolStripMenuItem9")]
		private ToolStripMenuItem _Versão300ToolStripMenuItem9;

		// Token: 0x04001C87 RID: 7303
		[AccessedThroughProperty("ExecutaCalibraçãoToolStripMenuItem8")]
		private ToolStripMenuItem _ExecutaCalibraçãoToolStripMenuItem8;

		// Token: 0x04001C88 RID: 7304
		[AccessedThroughProperty("ToolStripSeparator7")]
		private ToolStripSeparator _ToolStripSeparator7;

		// Token: 0x04001C89 RID: 7305
		[AccessedThroughProperty("PrintDialog1")]
		private PrintDialog _PrintDialog1;

		// Token: 0x04001C8A RID: 7306
		[AccessedThroughProperty("ToolStripSeparator8")]
		private ToolStripSeparator _ToolStripSeparator8;

		// Token: 0x04001C8B RID: 7307
		[AccessedThroughProperty("LeituraCalibraçãoSA420mADaPlacaToolStripMenuItem")]
		private ToolStripMenuItem _LeituraCalibraçãoSA420mADaPlacaToolStripMenuItem;

		// Token: 0x04001C8C RID: 7308
		[AccessedThroughProperty("ExecutaCalibraçãoSAToolStripMenuItem")]
		private ToolStripMenuItem _ExecutaCalibraçãoSAToolStripMenuItem;

		// Token: 0x04001C8D RID: 7309
		[AccessedThroughProperty("Versão400ToolStripMenuItem1")]
		private ToolStripMenuItem _Versão400ToolStripMenuItem1;

		// Token: 0x04001C8E RID: 7310
		[AccessedThroughProperty("ToolStripSeparator9")]
		private ToolStripSeparator _ToolStripSeparator9;

		// Token: 0x04001C8F RID: 7311
		[AccessedThroughProperty("IEC855ToolStripMenuItem")]
		private ToolStripMenuItem _IEC855ToolStripMenuItem;

		// Token: 0x04001C90 RID: 7312
		[AccessedThroughProperty("ToolStripMenuItem3")]
		private ToolStripMenuItem _ToolStripMenuItem3;

		// Token: 0x04001C91 RID: 7313
		[AccessedThroughProperty("IEC856ToolStripMenuItem")]
		private ToolStripMenuItem _IEC856ToolStripMenuItem;

		// Token: 0x04001C92 RID: 7314
		[AccessedThroughProperty("Versão300ToolStripMenuItem10")]
		private ToolStripMenuItem _Versão300ToolStripMenuItem10;

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x06002921 RID: 10529
		public delegate void SetTextCallback(string text);
	}
}
