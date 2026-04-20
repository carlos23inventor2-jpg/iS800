using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iS800.My;
using iS800.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x02000041 RID: 65
	[DesignerGenerated]
	public partial class Equip_810_mon : Form
	{
		// Token: 0x06000F51 RID: 3921 RVA: 0x003065D8 File Offset: 0x003049D8
		public Equip_810_mon()
		{
			base.FormClosed += new FormClosedEventHandler(this.Equip_202_mon_FormClosed);
			base.FormClosing += new FormClosingEventHandler(this.Equip_820_mon_FormClosing);
			base.Load += new EventHandler(this.Equip_202_mon_Load);
			this.Msg_status_202 = new string[]
			{
				" Não inst",
				" Parado",
				"Partindo",
				"Operando",
				"Ope. Sobre Cor",
				"Ope. Sub Cor",
				"Ope. Sobre Temp",
				"Parando",
				"Falha Partida",
				"Falha Operação",
				"Falha Parando",
				"Falha Parado",
				"Falha Sobre Cor",
				"Falha Sub Cor",
				"Falha Sobre Temp",
				"Falha Ligado"
			};
			this.Msg_modo_bomba_202 = new string[]
			{
				"Automático",
				"Manual"
			};
			this.Msg_modo_placa_202 = new string[]
			{
				"",
				"Modo Manual",
				"Modo Automático/Manual",
				"Modo Timer/Manual",
				"Modo Auto/Manual s/ Falha",
				"Modo Manual s/ Falha"
			};
			this.Msg_Estado_820_300 = new string[]
			{
				"Não Habilitado",
				"Parado",
				"Partindo",
				"Operando",
				"Parado",
				"Parado Anormal",
				"Ligado Anormal"
			};
			this.Msg_Controle_820_300 = new string[]
			{
				"Automático",
				"Manual"
			};
			this.Msg_Quadro_820_300 = new string[]
			{
				"Remoto",
				"Local"
			};
			this.Mon_820_DGVReferenciaColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[2];
			this.ValorReferencia = new RT_geral.Integer_ictel[5];
			this.ctlr = new Equip_810_mon.ST_CONTROLE[2];
			this.isValidForNumber = false;
			this.InitializeComponent();
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x00309938 File Offset: 0x00307D38
		// (set) Token: 0x06000F55 RID: 3925 RVA: 0x0030994C File Offset: 0x00307D4C
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

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x00309958 File Offset: 0x00307D58
		// (set) Token: 0x06000F57 RID: 3927 RVA: 0x0030996C File Offset: 0x00307D6C
		internal virtual NumericUpDown Tela_endereco_estacao
		{
			get
			{
				return this._Tela_endereco_estacao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tela_endereco_estacao_ValueChanged);
				if (this._Tela_endereco_estacao != null)
				{
					this._Tela_endereco_estacao.ValueChanged -= eventHandler;
				}
				this._Tela_endereco_estacao = value;
				if (this._Tela_endereco_estacao != null)
				{
					this._Tela_endereco_estacao.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x003099B8 File Offset: 0x00307DB8
		// (set) Token: 0x06000F59 RID: 3929 RVA: 0x003099CC File Offset: 0x00307DCC
		internal virtual NumericUpDown Tela_endereco_mestre
		{
			get
			{
				return this._Tela_endereco_mestre;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tela_endereco_mestre_ValueChanged);
				if (this._Tela_endereco_mestre != null)
				{
					this._Tela_endereco_mestre.ValueChanged -= eventHandler;
				}
				this._Tela_endereco_mestre = value;
				if (this._Tela_endereco_mestre != null)
				{
					this._Tela_endereco_mestre.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x00309A18 File Offset: 0x00307E18
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x00309A2C File Offset: 0x00307E2C
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

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x00309A38 File Offset: 0x00307E38
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x00309A4C File Offset: 0x00307E4C
		internal virtual TextBox msg
		{
			get
			{
				return this._msg;
			}
			[MethodImpl(32)]
			set
			{
				this._msg = value;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00309A58 File Offset: 0x00307E58
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x00309A6C File Offset: 0x00307E6C
		internal virtual Button Comando_hab_monitoracao
		{
			get
			{
				return this._Comando_hab_monitoracao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Comando_hab_monitoracao_Click);
				if (this._Comando_hab_monitoracao != null)
				{
					this._Comando_hab_monitoracao.Click -= eventHandler;
				}
				this._Comando_hab_monitoracao = value;
				if (this._Comando_hab_monitoracao != null)
				{
					this._Comando_hab_monitoracao.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00309AB8 File Offset: 0x00307EB8
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x00309ACC File Offset: 0x00307ECC
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

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x00309AD8 File Offset: 0x00307ED8
		// (set) Token: 0x06000F63 RID: 3939 RVA: 0x00309AEC File Offset: 0x00307EEC
		internal virtual Timer Timer_monitoracao
		{
			get
			{
				return this._Timer_monitoracao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer_monitoracao_Tick);
				if (this._Timer_monitoracao != null)
				{
					this._Timer_monitoracao.Tick -= eventHandler;
				}
				this._Timer_monitoracao = value;
				if (this._Timer_monitoracao != null)
				{
					this._Timer_monitoracao.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x00309B38 File Offset: 0x00307F38
		// (set) Token: 0x06000F65 RID: 3941 RVA: 0x00309B4C File Offset: 0x00307F4C
		internal virtual GroupBox Grupo_setpoints
		{
			get
			{
				return this._Grupo_setpoints;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_setpoints = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x00309B58 File Offset: 0x00307F58
		// (set) Token: 0x06000F67 RID: 3943 RVA: 0x00309B6C File Offset: 0x00307F6C
		internal virtual Button Comando_escreve_setpoint
		{
			get
			{
				return this._Comando_escreve_setpoint;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Comando_escreve_setpoint_Click);
				if (this._Comando_escreve_setpoint != null)
				{
					this._Comando_escreve_setpoint.Click -= eventHandler;
				}
				this._Comando_escreve_setpoint = value;
				if (this._Comando_escreve_setpoint != null)
				{
					this._Comando_escreve_setpoint.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x00309BB8 File Offset: 0x00307FB8
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x00309BCC File Offset: 0x00307FCC
		internal virtual Button Comando_le_setpoint
		{
			get
			{
				return this._Comando_le_setpoint;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Comando_le_setpoint_Click);
				if (this._Comando_le_setpoint != null)
				{
					this._Comando_le_setpoint.Click -= eventHandler;
				}
				this._Comando_le_setpoint = value;
				if (this._Comando_le_setpoint != null)
				{
					this._Comando_le_setpoint.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x00309C18 File Offset: 0x00308018
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x00309C2C File Offset: 0x0030802C
		internal virtual GroupBox Grupo_estatistica
		{
			get
			{
				return this._Grupo_estatistica;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_estatistica = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00309C38 File Offset: 0x00308038
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x00309C4C File Offset: 0x0030804C
		internal virtual Label Label_Est_retry
		{
			get
			{
				return this._Label_Est_retry;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_Est_retry = value;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x00309C58 File Offset: 0x00308058
		// (set) Token: 0x06000F6F RID: 3951 RVA: 0x00309C6C File Offset: 0x0030806C
		internal virtual TextBox Est_retry
		{
			get
			{
				return this._Est_retry;
			}
			[MethodImpl(32)]
			set
			{
				this._Est_retry = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x00309C78 File Offset: 0x00308078
		// (set) Token: 0x06000F71 RID: 3953 RVA: 0x00309C8C File Offset: 0x0030808C
		internal virtual TextBox Est_eficiencia
		{
			get
			{
				return this._Est_eficiencia;
			}
			[MethodImpl(32)]
			set
			{
				this._Est_eficiencia = value;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x00309C98 File Offset: 0x00308098
		// (set) Token: 0x06000F73 RID: 3955 RVA: 0x00309CAC File Offset: 0x003080AC
		internal virtual Button Button_limpa_estatistica
		{
			get
			{
				return this._Button_limpa_estatistica;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_limpa_estatistica_Click);
				if (this._Button_limpa_estatistica != null)
				{
					this._Button_limpa_estatistica.Click -= eventHandler;
				}
				this._Button_limpa_estatistica = value;
				if (this._Button_limpa_estatistica != null)
				{
					this._Button_limpa_estatistica.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000F74 RID: 3956 RVA: 0x00309CF8 File Offset: 0x003080F8
		// (set) Token: 0x06000F75 RID: 3957 RVA: 0x00309D0C File Offset: 0x0030810C
		internal virtual Label Label_Est_RX
		{
			get
			{
				return this._Label_Est_RX;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_Est_RX = value;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x00309D18 File Offset: 0x00308118
		// (set) Token: 0x06000F77 RID: 3959 RVA: 0x00309D2C File Offset: 0x0030812C
		internal virtual Label Label_Est_Eficiencia
		{
			get
			{
				return this._Label_Est_Eficiencia;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_Est_Eficiencia = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x00309D38 File Offset: 0x00308138
		// (set) Token: 0x06000F79 RID: 3961 RVA: 0x00309D4C File Offset: 0x0030814C
		internal virtual Label Label_Est_TX
		{
			get
			{
				return this._Label_Est_TX;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_Est_TX = value;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x00309D58 File Offset: 0x00308158
		// (set) Token: 0x06000F7B RID: 3963 RVA: 0x00309D6C File Offset: 0x0030816C
		internal virtual TextBox Est_Rx
		{
			get
			{
				return this._Est_Rx;
			}
			[MethodImpl(32)]
			set
			{
				this._Est_Rx = value;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x00309D78 File Offset: 0x00308178
		// (set) Token: 0x06000F7D RID: 3965 RVA: 0x00309D8C File Offset: 0x0030818C
		internal virtual TextBox Est_TX
		{
			get
			{
				return this._Est_TX;
			}
			[MethodImpl(32)]
			set
			{
				this._Est_TX = value;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x00309D98 File Offset: 0x00308198
		// (set) Token: 0x06000F7F RID: 3967 RVA: 0x00309DAC File Offset: 0x003081AC
		internal virtual GroupBox Grupo_status
		{
			get
			{
				return this._Grupo_status;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_status = value;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x00309DB8 File Offset: 0x003081B8
		// (set) Token: 0x06000F81 RID: 3969 RVA: 0x00309DCC File Offset: 0x003081CC
		internal virtual GroupBox Grupo_escrita_de_dados
		{
			get
			{
				return this._Grupo_escrita_de_dados;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_escrita_de_dados = value;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x00309DD8 File Offset: 0x003081D8
		// (set) Token: 0x06000F83 RID: 3971 RVA: 0x00309DEC File Offset: 0x003081EC
		internal virtual NumericUpDown Tela_nivel_destino
		{
			get
			{
				return this._Tela_nivel_destino;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tela_nivel_destino_ValueChanged);
				if (this._Tela_nivel_destino != null)
				{
					this._Tela_nivel_destino.ValueChanged -= eventHandler;
				}
				this._Tela_nivel_destino = value;
				if (this._Tela_nivel_destino != null)
				{
					this._Tela_nivel_destino.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x00309E38 File Offset: 0x00308238
		// (set) Token: 0x06000F85 RID: 3973 RVA: 0x00309E4C File Offset: 0x0030824C
		internal virtual Label Label_nivel_destino
		{
			get
			{
				return this._Label_nivel_destino;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_destino = value;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x00309E58 File Offset: 0x00308258
		// (set) Token: 0x06000F87 RID: 3975 RVA: 0x00309E6C File Offset: 0x0030826C
		internal virtual TextBox Valor_NivelDesejado
		{
			get
			{
				return this._Valor_NivelDesejado;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_NivelDesejado = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x00309E78 File Offset: 0x00308278
		// (set) Token: 0x06000F89 RID: 3977 RVA: 0x00309E8C File Offset: 0x0030828C
		internal virtual Label Label_NivelDesejado
		{
			get
			{
				return this._Label_NivelDesejado;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_NivelDesejado = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x00309E98 File Offset: 0x00308298
		// (set) Token: 0x06000F8B RID: 3979 RVA: 0x00309EAC File Offset: 0x003082AC
		internal virtual TextBox Valor_NivelB1
		{
			get
			{
				return this._Valor_NivelB1;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_NivelB1 = value;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x00309EB8 File Offset: 0x003082B8
		// (set) Token: 0x06000F8D RID: 3981 RVA: 0x00309ECC File Offset: 0x003082CC
		internal virtual Label Label_NivelB1
		{
			get
			{
				return this._Label_NivelB1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_NivelB1 = value;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00309ED8 File Offset: 0x003082D8
		// (set) Token: 0x06000F8F RID: 3983 RVA: 0x00309EEC File Offset: 0x003082EC
		internal virtual TextBox Valor_PressaoRec
		{
			get
			{
				return this._Valor_PressaoRec;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_PressaoRec = value;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00309EF8 File Offset: 0x003082F8
		// (set) Token: 0x06000F91 RID: 3985 RVA: 0x00309F0C File Offset: 0x0030830C
		internal virtual Label Label_PressaoRec
		{
			get
			{
				return this._Label_PressaoRec;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_PressaoRec = value;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x00309F18 File Offset: 0x00308318
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x00309F2C File Offset: 0x0030832C
		internal virtual TextBox Valor_TempoMaisUmaBomba
		{
			get
			{
				return this._Valor_TempoMaisUmaBomba;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_TempoMaisUmaBomba = value;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x00309F38 File Offset: 0x00308338
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x00309F4C File Offset: 0x0030834C
		internal virtual Label Label_TempoMaisUmaBomba
		{
			get
			{
				return this._Label_TempoMaisUmaBomba;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_TempoMaisUmaBomba = value;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x00309F58 File Offset: 0x00308358
		// (set) Token: 0x06000F97 RID: 3991 RVA: 0x00309F6C File Offset: 0x0030836C
		internal virtual TextBox Valor_NivelB4
		{
			get
			{
				return this._Valor_NivelB4;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_NivelB4 = value;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x00309F78 File Offset: 0x00308378
		// (set) Token: 0x06000F99 RID: 3993 RVA: 0x00309F8C File Offset: 0x0030838C
		internal virtual Label Label_NivelB4
		{
			get
			{
				return this._Label_NivelB4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_NivelB4 = value;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x00309F98 File Offset: 0x00308398
		// (set) Token: 0x06000F9B RID: 3995 RVA: 0x00309FAC File Offset: 0x003083AC
		internal virtual TextBox Valor_NivelB3
		{
			get
			{
				return this._Valor_NivelB3;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_NivelB3 = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x00309FB8 File Offset: 0x003083B8
		// (set) Token: 0x06000F9D RID: 3997 RVA: 0x00309FCC File Offset: 0x003083CC
		internal virtual Label Label_NivelB3
		{
			get
			{
				return this._Label_NivelB3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_NivelB3 = value;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x00309FD8 File Offset: 0x003083D8
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x00309FEC File Offset: 0x003083EC
		internal virtual TextBox Valor_NivelB2
		{
			get
			{
				return this._Valor_NivelB2;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_NivelB2 = value;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00309FF8 File Offset: 0x003083F8
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x0030A00C File Offset: 0x0030840C
		internal virtual Label Label_NivelB2
		{
			get
			{
				return this._Label_NivelB2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_NivelB2 = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x0030A018 File Offset: 0x00308418
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x0030A02C File Offset: 0x0030842C
		internal virtual TextBox Valor_Niveldesliga
		{
			get
			{
				return this._Valor_Niveldesliga;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_Niveldesliga = value;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x0030A038 File Offset: 0x00308438
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x0030A04C File Offset: 0x0030844C
		internal virtual Label Label_NivelDesliga
		{
			get
			{
				return this._Label_NivelDesliga;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_NivelDesliga = value;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x0030A058 File Offset: 0x00308458
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x0030A06C File Offset: 0x0030846C
		internal virtual TextBox Valor_NivelLiga
		{
			get
			{
				return this._Valor_NivelLiga;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_NivelLiga = value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x0030A078 File Offset: 0x00308478
		// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x0030A08C File Offset: 0x0030848C
		internal virtual Label Label_NivelLiga
		{
			get
			{
				return this._Label_NivelLiga;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_NivelLiga = value;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0030A098 File Offset: 0x00308498
		// (set) Token: 0x06000FAB RID: 4011 RVA: 0x0030A0AC File Offset: 0x003084AC
		internal virtual TextBox Valor_PressaoSuc
		{
			get
			{
				return this._Valor_PressaoSuc;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_PressaoSuc = value;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x0030A0B8 File Offset: 0x003084B8
		// (set) Token: 0x06000FAD RID: 4013 RVA: 0x0030A0CC File Offset: 0x003084CC
		internal virtual Label Label_PressaoSuc
		{
			get
			{
				return this._Label_PressaoSuc;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_PressaoSuc = value;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0030A0D8 File Offset: 0x003084D8
		// (set) Token: 0x06000FAF RID: 4015 RVA: 0x0030A0EC File Offset: 0x003084EC
		internal virtual GroupBox Grupo_medidas
		{
			get
			{
				return this._Grupo_medidas;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_medidas = value;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x0030A0F8 File Offset: 0x003084F8
		// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x0030A10C File Offset: 0x0030850C
		internal virtual NumericUpDown Tela_nivel_origem
		{
			get
			{
				return this._Tela_nivel_origem;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tela_nivel_origem_ValueChanged);
				if (this._Tela_nivel_origem != null)
				{
					this._Tela_nivel_origem.ValueChanged -= eventHandler;
				}
				this._Tela_nivel_origem = value;
				if (this._Tela_nivel_origem != null)
				{
					this._Tela_nivel_origem.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x0030A158 File Offset: 0x00308558
		// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x0030A16C File Offset: 0x0030856C
		internal virtual Label Label_nivel_origem
		{
			get
			{
				return this._Label_nivel_origem;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_origem = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x0030A178 File Offset: 0x00308578
		// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x0030A18C File Offset: 0x0030858C
		internal virtual Button Cmd_falha_b2
		{
			get
			{
				return this._Cmd_falha_b2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_falha_b2_Click);
				if (this._Cmd_falha_b2 != null)
				{
					this._Cmd_falha_b2.Click -= eventHandler;
				}
				this._Cmd_falha_b2 = value;
				if (this._Cmd_falha_b2 != null)
				{
					this._Cmd_falha_b2.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x0030A1D8 File Offset: 0x003085D8
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x0030A1EC File Offset: 0x003085EC
		internal virtual TextBox msg_modo_operacaoZ
		{
			get
			{
				return this._msg_modo_operacaoZ;
			}
			[MethodImpl(32)]
			set
			{
				this._msg_modo_operacaoZ = value;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x0030A1F8 File Offset: 0x003085F8
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x0030A20C File Offset: 0x0030860C
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

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x0030A218 File Offset: 0x00308618
		// (set) Token: 0x06000FBB RID: 4027 RVA: 0x0030A22C File Offset: 0x0030862C
		internal virtual DataGridView dgv_Referencias
		{
			get
			{
				return this._dgv_Referencias;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_Referencias_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgv_Referencias_CellValidating);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.dgv_Referencias_KeyPress);
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.dgv_Referencias_KeyDown);
				DataGridViewEditingControlShowingEventHandler dataGridViewEditingControlShowingEventHandler = new DataGridViewEditingControlShowingEventHandler(this.dgv_Referencias_EditingControlShowing);
				if (this._dgv_Referencias != null)
				{
					this._dgv_Referencias.CellValueChanged -= dataGridViewCellEventHandler;
					this._dgv_Referencias.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._dgv_Referencias.KeyPress -= keyPressEventHandler;
					this._dgv_Referencias.KeyDown -= keyEventHandler;
					this._dgv_Referencias.EditingControlShowing -= dataGridViewEditingControlShowingEventHandler;
				}
				this._dgv_Referencias = value;
				if (this._dgv_Referencias != null)
				{
					this._dgv_Referencias.CellValueChanged += dataGridViewCellEventHandler;
					this._dgv_Referencias.CellValidating += dataGridViewCellValidatingEventHandler;
					this._dgv_Referencias.KeyPress += keyPressEventHandler;
					this._dgv_Referencias.KeyDown += keyEventHandler;
					this._dgv_Referencias.EditingControlShowing += dataGridViewEditingControlShowingEventHandler;
				}
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x0030A314 File Offset: 0x00308714
		// (set) Token: 0x06000FBD RID: 4029 RVA: 0x0030A328 File Offset: 0x00308728
		internal virtual DataGridViewTextBoxColumn Ref
		{
			get
			{
				return this._Ref;
			}
			[MethodImpl(32)]
			set
			{
				this._Ref = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x0030A334 File Offset: 0x00308734
		// (set) Token: 0x06000FBF RID: 4031 RVA: 0x0030A348 File Offset: 0x00308748
		internal virtual DataGridView dgv_EA
		{
			get
			{
				return this._dgv_EA;
			}
			[MethodImpl(32)]
			set
			{
				this._dgv_EA = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x0030A354 File Offset: 0x00308754
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x0030A368 File Offset: 0x00308768
		internal virtual DataGridView dgv_Controle
		{
			get
			{
				return this._dgv_Controle;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_Controle_CellContentDoubleClick);
				EventHandler eventHandler = new EventHandler(this.dgv_Controle_DoubleClick);
				if (this._dgv_Controle != null)
				{
					this._dgv_Controle.CellContentDoubleClick -= dataGridViewCellEventHandler;
					this._dgv_Controle.DoubleClick -= eventHandler;
				}
				this._dgv_Controle = value;
				if (this._dgv_Controle != null)
				{
					this._dgv_Controle.CellContentDoubleClick += dataGridViewCellEventHandler;
					this._dgv_Controle.DoubleClick += eventHandler;
				}
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x0030A3D8 File Offset: 0x003087D8
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x0030A3EC File Offset: 0x003087EC
		internal virtual DataGridViewTextBoxColumn Estado
		{
			get
			{
				return this._Estado;
			}
			[MethodImpl(32)]
			set
			{
				this._Estado = value;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x0030A3F8 File Offset: 0x003087F8
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x0030A40C File Offset: 0x0030880C
		internal virtual DataGridViewImageColumn Quadro
		{
			get
			{
				return this._Quadro;
			}
			[MethodImpl(32)]
			set
			{
				this._Quadro = value;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x0030A418 File Offset: 0x00308818
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x0030A42C File Offset: 0x0030882C
		internal virtual DataGridViewImageColumn Controle
		{
			get
			{
				return this._Controle;
			}
			[MethodImpl(32)]
			set
			{
				this._Controle = value;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x0030A438 File Offset: 0x00308838
		// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x0030A44C File Offset: 0x0030884C
		internal virtual DataGridViewImageColumn LD
		{
			get
			{
				return this._LD;
			}
			[MethodImpl(32)]
			set
			{
				this._LD = value;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x0030A458 File Offset: 0x00308858
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x0030A46C File Offset: 0x0030886C
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

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x0030A478 File Offset: 0x00308878
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x0030A48C File Offset: 0x0030888C
		internal virtual Button bt_end_default
		{
			get
			{
				return this._bt_end_default;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bt_end_default_Click);
				if (this._bt_end_default != null)
				{
					this._bt_end_default.Click -= eventHandler;
				}
				this._bt_end_default = value;
				if (this._bt_end_default != null)
				{
					this._bt_end_default.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x0030A4D8 File Offset: 0x003088D8
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x0030A4EC File Offset: 0x003088EC
		internal virtual PictureBox pb_hab_monitoracao
		{
			get
			{
				return this._pb_hab_monitoracao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.pb_hab_monitoracao_Click);
				if (this._pb_hab_monitoracao != null)
				{
					this._pb_hab_monitoracao.Click -= eventHandler;
				}
				this._pb_hab_monitoracao = value;
				if (this._pb_hab_monitoracao != null)
				{
					this._pb_hab_monitoracao.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x0030A538 File Offset: 0x00308938
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x0030A54C File Offset: 0x0030894C
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

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x0030A558 File Offset: 0x00308958
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x0030A56C File Offset: 0x0030896C
		internal virtual DataGridViewTextBoxColumn Contagens
		{
			get
			{
				return this._Contagens;
			}
			[MethodImpl(32)]
			set
			{
				this._Contagens = value;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x0030A578 File Offset: 0x00308978
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x0030A58C File Offset: 0x0030898C
		internal virtual DataGridViewCheckBoxColumn Conv
		{
			get
			{
				return this._Conv;
			}
			[MethodImpl(32)]
			set
			{
				this._Conv = value;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x0030A598 File Offset: 0x00308998
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x0030A5AC File Offset: 0x003089AC
		internal virtual DataGridViewTextBoxColumn Inicio
		{
			get
			{
				return this._Inicio;
			}
			[MethodImpl(32)]
			set
			{
				this._Inicio = value;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x0030A5B8 File Offset: 0x003089B8
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x0030A5CC File Offset: 0x003089CC
		internal virtual DataGridViewTextBoxColumn Fim
		{
			get
			{
				return this._Fim;
			}
			[MethodImpl(32)]
			set
			{
				this._Fim = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x0030A5D8 File Offset: 0x003089D8
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x0030A5EC File Offset: 0x003089EC
		internal virtual DataGridViewTextBoxColumn Medida
		{
			get
			{
				return this._Medida;
			}
			[MethodImpl(32)]
			set
			{
				this._Medida = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x0030A5F8 File Offset: 0x003089F8
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x0030A60C File Offset: 0x00308A0C
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

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0030A618 File Offset: 0x00308A18
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x0030A62C File Offset: 0x00308A2C
		internal virtual CheckBox cb_ED8
		{
			get
			{
				return this._cb_ED8;
			}
			[MethodImpl(32)]
			set
			{
				this._cb_ED8 = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x0030A638 File Offset: 0x00308A38
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x0030A64C File Offset: 0x00308A4C
		internal virtual CheckBox cb_ED7
		{
			get
			{
				return this._cb_ED7;
			}
			[MethodImpl(32)]
			set
			{
				this._cb_ED7 = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0030A658 File Offset: 0x00308A58
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x0030A66C File Offset: 0x00308A6C
		internal virtual CheckBox cb_ED6
		{
			get
			{
				return this._cb_ED6;
			}
			[MethodImpl(32)]
			set
			{
				this._cb_ED6 = value;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x0030A678 File Offset: 0x00308A78
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x0030A68C File Offset: 0x00308A8C
		internal virtual CheckBox cb_ED5
		{
			get
			{
				return this._cb_ED5;
			}
			[MethodImpl(32)]
			set
			{
				this._cb_ED5 = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x0030A698 File Offset: 0x00308A98
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x0030A6AC File Offset: 0x00308AAC
		internal virtual CheckBox cb_ED4
		{
			get
			{
				return this._cb_ED4;
			}
			[MethodImpl(32)]
			set
			{
				this._cb_ED4 = value;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x0030A6B8 File Offset: 0x00308AB8
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x0030A6CC File Offset: 0x00308ACC
		internal virtual CheckBox cb_ED3
		{
			get
			{
				return this._cb_ED3;
			}
			[MethodImpl(32)]
			set
			{
				this._cb_ED3 = value;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x0030A6D8 File Offset: 0x00308AD8
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x0030A6EC File Offset: 0x00308AEC
		internal virtual CheckBox cb_ED2
		{
			get
			{
				return this._cb_ED2;
			}
			[MethodImpl(32)]
			set
			{
				this._cb_ED2 = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x0030A6F8 File Offset: 0x00308AF8
		// (set) Token: 0x06000FED RID: 4077 RVA: 0x0030A70C File Offset: 0x00308B0C
		internal virtual CheckBox cb_ED1
		{
			get
			{
				return this._cb_ED1;
			}
			[MethodImpl(32)]
			set
			{
				this._cb_ED1 = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x0030A718 File Offset: 0x00308B18
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x0030A72C File Offset: 0x00308B2C
		internal virtual GroupBox GroupBox_Alarmes
		{
			get
			{
				return this._GroupBox_Alarmes;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_Alarmes = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x0030A738 File Offset: 0x00308B38
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x0030A74C File Offset: 0x00308B4C
		internal virtual PictureBox pb_bit0
		{
			get
			{
				return this._pb_bit0;
			}
			[MethodImpl(32)]
			set
			{
				this._pb_bit0 = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0030A758 File Offset: 0x00308B58
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x0030A76C File Offset: 0x00308B6C
		internal virtual PictureBox pb_bit1
		{
			get
			{
				return this._pb_bit1;
			}
			[MethodImpl(32)]
			set
			{
				this._pb_bit1 = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x0030A778 File Offset: 0x00308B78
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x0030A78C File Offset: 0x00308B8C
		internal virtual PictureBox pb_bit5
		{
			get
			{
				return this._pb_bit5;
			}
			[MethodImpl(32)]
			set
			{
				this._pb_bit5 = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x0030A798 File Offset: 0x00308B98
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x0030A7AC File Offset: 0x00308BAC
		internal virtual PictureBox pb_bit2
		{
			get
			{
				return this._pb_bit2;
			}
			[MethodImpl(32)]
			set
			{
				this._pb_bit2 = value;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x0030A7B8 File Offset: 0x00308BB8
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x0030A7CC File Offset: 0x00308BCC
		internal virtual PictureBox pb_bit4
		{
			get
			{
				return this._pb_bit4;
			}
			[MethodImpl(32)]
			set
			{
				this._pb_bit4 = value;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x0030A7D8 File Offset: 0x00308BD8
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x0030A7EC File Offset: 0x00308BEC
		internal virtual PictureBox pb_bit3
		{
			get
			{
				return this._pb_bit3;
			}
			[MethodImpl(32)]
			set
			{
				this._pb_bit3 = value;
			}
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x0030A7F8 File Offset: 0x00308BF8
		private void Equip_202_mon_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Parar", false) == 0)
			{
				Interaction.MsgBox("Anter de fechar a tela é necessário parar a monitoração!", 0, null);
				return;
			}
			this.Timer_monitoracao.Enabled = false;
			RT_geral.Telas_RT_810.Monitoracao = false;
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0030A838 File Offset: 0x00308C38
		private void InicializaEstrutura_DataGridView_Referencia()
		{
			this.Mon_820_DGVReferenciaColunas[0].TagColuna = "Ref 0-4000";
			this.Mon_820_DGVReferenciaColunas[0].NomeColuna = "range";
			this.Mon_820_DGVReferenciaColunas[0].LarguraColuna = 100;
			this.Mon_820_DGVReferenciaColunas[0].AlingColuna = 64;
			this.Mon_820_DGVReferenciaColunas[0].NumeroLinhaMenu = 0;
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0030A8AC File Offset: 0x00308CAC
		private void GeraDataGridView_Referencia()
		{
			this.dgv_Referencias.Columns.Clear();
			this.dgv_Referencias.CellBorderStyle = 1;
			int num = 0;
			checked
			{
				do
				{
					if (this.Mon_820_DGVReferenciaColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref this.Mon_820_DGVReferenciaColunas);
						this.dgv_Referencias.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref this.Mon_820_DGVReferenciaColunas);
						this.dgv_Referencias.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 0);
				this.dgv_Referencias.RowCount = 4;
				this.dgv_Referencias.RowHeadersWidth = 80;
				int num2 = 1;
				try
				{
					foreach (object obj in this.dgv_Referencias.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "Ref " + Strings.Format(num2, "0#");
							num2++;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0030A9E0 File Offset: 0x00308DE0
		private void Equip_202_mon_Load(object sender, EventArgs e)
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = 2;
			Geral.Config_geral.Largura_tela_trabalho = this.Width;
			int num = 48;
			string text = "O equipamento deve estar em modo de operação!\r\nDeve ser removido o jumper de configuração.\r\n";
			switch (Geral.Config_geral.Protocolo)
			{
			case 1:
				text += " Utilize canal COM1 ou COM2\r\n";
				break;
			case 2:
				text += " Utilize canal COM2.\r\n";
				break;
			}
			Interaction.MsgBox(text, num, " Atenção");
			int num2 = 0;
			checked
			{
				do
				{
					this.ValorReferencia[num2].Lmte_inf = 0;
					this.ValorReferencia[num2].Lmte_sup = 4000;
					this.ValorReferencia[num2].Padrao = 0;
					this.ValorReferencia[num2].ValorPadrao();
					num2++;
				}
				while (num2 <= 3);
				RT_geral.Lmte_Init_ok = true;
				this.InicializaEstrutura_DataGridView_Referencia();
				this.GeraDataGridView_Referencia();
				this.dgv_EA.RowCount = 4;
				this.dgv_EA.RowHeadersWidth = 75;
				num2 = 0;
				do
				{
					this.dgv_EA.Rows[num2].HeaderCell.Value = "EA" + (num2 + 1).ToString();
					this.dgv_EA.Rows[num2].Cells[4].Value = "";
					this.dgv_EA.Rows[num2].Cells[0].Value = "";
					num2++;
				}
				while (num2 <= 3);
				this.dgv_Controle.RowCount = 1;
				this.dgv_Controle.RowHeadersWidth = 50;
				num2 = 0;
				do
				{
					this.dgv_Controle.Rows[num2].HeaderCell.Value = "C" + (num2 + 1).ToString();
					this.dgv_Controle.Rows[num2].Cells[0].Value = "";
					this.dgv_Controle.Rows[num2].Height = 64;
					Bitmap chave_vazia = Resources.chave_vazia;
					this.dgv_Controle.Rows[num2].Cells[2].Value = chave_vazia;
					this.dgv_Controle.Columns[2].Width = 64;
					this.dgv_Controle.Rows[num2].Cells[1].Value = chave_vazia;
					this.dgv_Controle.Columns[1].Width = 64;
					this.dgv_Controle.Rows[num2].Cells[3].Value = chave_vazia;
					this.dgv_Controle.Columns[3].Width = 64;
					num2++;
				}
				while (num2 <= 0);
				this.Grupo_medidas.Enabled = true;
			}
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0030ACB4 File Offset: 0x003090B4
		private void Timer_monitoracao_Tick(object sender, EventArgs e)
		{
			int[] array = new int[41];
			this.Timer_monitoracao.Enabled = false;
			this.Timer_monitoracao.Interval = 1000;
			Comunicacao.Ctrl_Com.Tipo_protocolo = 2;
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			checked
			{
				switch (Mod_MD.Monitoracao_MD_RQ.Controle_mon)
				{
				case 1:
					Mod_MD.Monitoracao_MD_RQ.Controle_mon = 2;
					while (i > 0)
					{
						i--;
						Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, 51, 0, array);
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
						switch (Comunicacao.Ctrl_Com.Frame)
						{
						case 0:
							this.Mensagem_MD202_mon("Leitura Setpoints - Ok", 0);
							this.Calcula_Estatistica_820_300(1);
							this.Atualiza_setpoint_monitoracao_202();
							goto IL_177;
						case 1:
							goto IL_13E;
						case 2:
							if (i == 0)
							{
								this.Mensagem_MD202_mon("Erro Leitura Setpoints - ChkSum", 1);
								this.Calcula_Estatistica_820_300(3);
								this.Limpa_monitoracao_820_300(2);
							}
							else
							{
								this.Calcula_Estatistica_820_300(2);
							}
							break;
						case 3:
							if (i == 0)
							{
								this.Mensagem_MD202_mon("Erro Leitura Setpoints - Timeout", 1);
								this.Calcula_Estatistica_820_300(3);
								this.Limpa_monitoracao_820_300(2);
							}
							else
							{
								this.Calcula_Estatistica_820_300(2);
							}
							break;
						default:
							goto IL_13E;
						}
						IL_165:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_13E:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro Leitura Setpoints - não determinado", 1);
							this.Calcula_Estatistica_820_300(3);
							this.Limpa_monitoracao_820_300(2);
							goto IL_165;
						}
						this.Calcula_Estatistica_820_300(2);
						goto IL_165;
					}
					IL_177:
					this.Comando_le_setpoint.Enabled = true;
					this.Comando_escreve_setpoint.Enabled = true;
					MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
					break;
				case 2:
					i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					Mod_MD.Monitoracao_MD_RQ.Controle_mon = 2;
					while (i > 0)
					{
						i--;
						array[0] = this.ValorReferencia[0].Valor / 200;
						array[1] = this.ValorReferencia[0].Valor % 200;
						array[2] = this.ValorReferencia[1].Valor / 200;
						array[3] = this.ValorReferencia[1].Valor % 200;
						array[4] = this.ValorReferencia[2].Valor / 200;
						array[5] = this.ValorReferencia[3].Valor % 200;
						array[6] = this.ValorReferencia[4].Valor / 200;
						array[7] = this.ValorReferencia[4].Valor % 200;
						array[8] = 0;
						array[9] = 0;
						Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, 57, 10, array);
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
						switch (Comunicacao.Ctrl_Com.Frame)
						{
						case 0:
							this.Mensagem_MD202_mon("Leitura Equipamento - Ok", 0);
							this.Calcula_Estatistica_820_300(1);
							this.Atualiza_status_monitoracao_820_300();
							goto IL_A74;
						case 1:
							goto IL_370;
						case 2:
							if (i == 0)
							{
								this.Mensagem_MD202_mon("Erro Leitura Equipamento - ChkSum", 1);
								this.Calcula_Estatistica_820_300(3);
								this.Limpa_monitoracao_820_300(1);
							}
							else
							{
								this.Calcula_Estatistica_820_300(2);
							}
							break;
						case 3:
							if (i == 0)
							{
								this.Mensagem_MD202_mon("Erro Leitura Equipamento - Timeout", 1);
								this.Calcula_Estatistica_820_300(3);
								this.Limpa_monitoracao_820_300(1);
							}
							else
							{
								this.Calcula_Estatistica_820_300(2);
							}
							break;
						default:
							goto IL_370;
						}
						IL_397:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_370:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro Leitura Equipamento - não determinado", 1);
							this.Calcula_Estatistica_820_300(3);
							this.Limpa_monitoracao_820_300(1);
							goto IL_397;
						}
						this.Calcula_Estatistica_820_300(2);
						goto IL_397;
					}
					break;
				case 3:
					i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					Mod_MD.Monitoracao_MD_RQ.Controle_mon = 2;
					while (i > 0)
					{
						i--;
						string versao = Geral.Config_geral.Versao;
						if (Operators.CompareString(versao, "820_10", false) == 0)
						{
							array[0] = (int)((long)Math.Round(Conversion.Val(this.Valor_NivelDesejado.Text)) / 200L);
							array[1] = (int)Math.Round(Conversion.Val(this.Valor_NivelDesejado.Text) % 200.0);
							array[2] = (int)((long)Math.Round(Conversion.Val(this.Valor_NivelB1.Text)) / 200L);
							array[3] = (int)Math.Round(Conversion.Val(this.Valor_NivelB1.Text) % 200.0);
							array[4] = (int)((long)Math.Round(Conversion.Val(this.Valor_NivelB2.Text)) / 200L);
							array[5] = (int)Math.Round(Conversion.Val(this.Valor_NivelB2.Text) % 200.0);
							array[6] = (int)((long)Math.Round(Conversion.Val(this.Valor_NivelB3.Text)) / 200L);
							array[7] = (int)Math.Round(Conversion.Val(this.Valor_NivelB3.Text) % 200.0);
							array[8] = (int)((long)Math.Round(Conversion.Val(this.Valor_NivelB4.Text)) / 200L);
							array[9] = (int)Math.Round(Conversion.Val(this.Valor_NivelB4.Text) % 200.0);
							array[10] = (int)((long)Math.Round(Conversion.Val(this.Valor_TempoMaisUmaBomba.Text)) / 200L);
							array[11] = (int)Math.Round(Conversion.Val(this.Valor_TempoMaisUmaBomba.Text) % 200.0);
							array[12] = (int)((long)Math.Round(Conversion.Val(this.Valor_PressaoRec.Text)) / 200L);
							array[13] = (int)Math.Round(Conversion.Val(this.Valor_PressaoRec.Text) % 200.0);
							array[14] = (int)((long)Math.Round(Conversion.Val(this.Valor_PressaoSuc.Text)) / 200L);
							array[15] = (int)Math.Round(Conversion.Val(this.Valor_PressaoSuc.Text) % 200.0);
							array[16] = (int)((long)Math.Round(Conversion.Val(this.Valor_Niveldesliga.Text)) / 200L);
							array[17] = (int)Math.Round(Conversion.Val(this.Valor_Niveldesliga.Text) % 200.0);
							array[18] = (int)((long)Math.Round(Conversion.Val(this.Valor_NivelLiga.Text)) / 200L);
							array[19] = (int)Math.Round(Conversion.Val(this.Valor_NivelLiga.Text) % 200.0);
							Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, 66, 20, array);
						}
						else
						{
							array[0] = (int)Math.Round(unchecked(Conversion.Val(this.Valor_NivelDesejado.Text) * 2.0));
							array[1] = (int)Math.Round(unchecked(Conversion.Val(this.Valor_NivelB1.Text) * 2.0));
							array[2] = (int)Math.Round(unchecked(Conversion.Val(this.Valor_NivelB2.Text) * 2.0));
							array[3] = (int)Math.Round(unchecked(Conversion.Val(this.Valor_NivelB3.Text) * 2.0));
							array[4] = (int)Math.Round(unchecked(Conversion.Val(this.Valor_NivelB4.Text) * 2.0));
							array[5] = (int)Math.Round(Conversion.Val(this.Valor_TempoMaisUmaBomba.Text));
							array[6] = (int)Math.Round(unchecked(Conversion.Val(this.Valor_PressaoRec.Text) * 2.0));
							array[7] = (int)Math.Round(unchecked(Conversion.Val(this.Valor_PressaoSuc.Text) * 2.0));
							array[8] = (int)Math.Round(unchecked(Conversion.Val(this.Valor_NivelLiga.Text) * 2.0));
							array[9] = (int)Math.Round(unchecked(Conversion.Val(this.Valor_Niveldesliga.Text) * 2.0));
							Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, 66, 10, array);
						}
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
						switch (Comunicacao.Ctrl_Com.Frame)
						{
						case 0:
							this.Mensagem_MD202_mon("Escrita Setpoints - Ok", 0);
							this.Calcula_Estatistica_820_300(1);
							goto IL_8FE;
						case 1:
							goto IL_8CC;
						case 2:
							if (i == 0)
							{
								this.Mensagem_MD202_mon("Erro Escrita Setpoints - ChkSum", 1);
								this.Calcula_Estatistica_820_300(3);
							}
							else
							{
								this.Calcula_Estatistica_820_300(2);
							}
							break;
						case 3:
							if (i == 0)
							{
								this.Mensagem_MD202_mon("Erro Escrita Setpoints - Timeout", 1);
								this.Calcula_Estatistica_820_300(3);
							}
							else
							{
								this.Calcula_Estatistica_820_300(2);
							}
							break;
						default:
							goto IL_8CC;
						}
						IL_8EC:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_8CC:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro Escrita Setpoints - não determinado", 1);
							this.Calcula_Estatistica_820_300(3);
							goto IL_8EC;
						}
						this.Calcula_Estatistica_820_300(2);
						goto IL_8EC;
					}
					IL_8FE:
					this.Comando_le_setpoint.Enabled = true;
					this.Comando_escreve_setpoint.Enabled = true;
					MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
					break;
				case 4:
					i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					Mod_MD.Monitoracao_MD_RQ.Controle_mon = 2;
					while (i > 0)
					{
						i--;
						array[0] = Mod_MD.Monitoracao_MD_RQ.Numero_motor;
						Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, Mod_MD.Monitoracao_MD_RQ.Comando, 1, array);
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
						switch (Comunicacao.Ctrl_Com.Frame)
						{
						case 0:
						{
							Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Verifica_resposta_Linha300();
							this.Mensagem_MD202_mon(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
							this.Calcula_Estatistica_820_300(1);
							goto IL_A5B;
						}
						case 1:
							goto IL_A29;
						case 2:
							if (i == 0)
							{
								this.Mensagem_MD202_mon("Erro ao executar o camando - ChkSum", 1);
								this.Calcula_Estatistica_820_300(3);
							}
							else
							{
								this.Calcula_Estatistica_820_300(2);
							}
							break;
						case 3:
							if (i == 0)
							{
								this.Mensagem_MD202_mon("Erro ao executar o camando - Timeout", 1);
								this.Calcula_Estatistica_820_300(3);
							}
							else
							{
								this.Calcula_Estatistica_820_300(2);
							}
							break;
						default:
							goto IL_A29;
						}
						IL_A49:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_A29:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro ao executar o camando - não determinado", 1);
							this.Calcula_Estatistica_820_300(3);
							goto IL_A49;
						}
						this.Calcula_Estatistica_820_300(2);
						goto IL_A49;
					}
					IL_A5B:
					MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
					break;
				}
				IL_A74:
				if (Mod_MD.Monitoracao_MD_RQ.Partir_mon)
				{
					this.Timer_monitoracao.Enabled = true;
				}
			}
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0030B750 File Offset: 0x00309B50
		public void Mensagem_MD202_mon(string msg, int cor)
		{
			switch (cor)
			{
			case 0:
				this.msg.ForeColor = Color.Blue;
				break;
			case 1:
				this.msg.ForeColor = Color.Red;
				break;
			case 2:
				this.msg.ForeColor = Color.Black;
				break;
			}
			this.msg.Text = msg;
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0030B7B4 File Offset: 0x00309BB4
		public void Calcula_Estatistica_820_300(int opcao)
		{
			checked
			{
				switch (opcao)
				{
				case 1:
					Mod_MD.Monitoracao_MD_RQ.Num_Rx = Mod_MD.Monitoracao_MD_RQ.Num_Rx + 1L;
					Mod_MD.Monitoracao_MD_RQ.Num_Tx = Mod_MD.Monitoracao_MD_RQ.Num_Tx + 1L;
					break;
				case 2:
					Mod_MD.Monitoracao_MD_RQ.Num_Retry = Mod_MD.Monitoracao_MD_RQ.Num_Retry + 1L;
					break;
				case 3:
					Mod_MD.Monitoracao_MD_RQ.Num_Tx = Mod_MD.Monitoracao_MD_RQ.Num_Tx + 1L;
					break;
				}
				if (Mod_MD.Monitoracao_MD_RQ.Num_Tx != 0L)
				{
					Mod_MD.Monitoracao_MD_RQ.Eficiencia_com = (int)Math.Round(unchecked((double)Mod_MD.Monitoracao_MD_RQ.Num_Rx / (double)Mod_MD.Monitoracao_MD_RQ.Num_Tx * 100.0));
				}
				this.Est_TX.Text = Conversion.Str(Mod_MD.Monitoracao_MD_RQ.Num_Tx);
				this.Est_Rx.Text = Conversion.Str(Mod_MD.Monitoracao_MD_RQ.Num_Rx);
				this.Est_retry.Text = Conversion.Str(Mod_MD.Monitoracao_MD_RQ.Num_Retry);
				this.Est_eficiencia.Text = Conversion.Str(Mod_MD.Monitoracao_MD_RQ.Eficiencia_com);
			}
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0030B8F4 File Offset: 0x00309CF4
		public void Atualiza_setpoint_monitoracao_202()
		{
			string versao = Geral.Config_geral.Versao;
			checked
			{
				if (Operators.CompareString(versao, "820_10", false) == 0)
				{
					this.Valor_NivelDesejado.Text = Conversions.ToString((int)((Comunicacao.Buffer_resp[4] - 48) * 200 + (Comunicacao.Buffer_resp[5] - 48)));
					this.Valor_NivelB1.Text = Conversions.ToString((int)((Comunicacao.Buffer_resp[6] - 48) * 200 + (Comunicacao.Buffer_resp[7] - 48)));
					this.Valor_NivelB2.Text = Conversions.ToString((int)((Comunicacao.Buffer_resp[8] - 48) * 200 + (Comunicacao.Buffer_resp[9] - 48)));
					this.Valor_NivelB3.Text = Conversions.ToString((int)((Comunicacao.Buffer_resp[10] - 48) * 200 + (Comunicacao.Buffer_resp[11] - 48)));
					this.Valor_NivelB4.Text = Conversions.ToString((int)((Comunicacao.Buffer_resp[12] - 48) * 200 + (Comunicacao.Buffer_resp[13] - 48)));
					this.Valor_TempoMaisUmaBomba.Text = Conversions.ToString((int)((Comunicacao.Buffer_resp[14] - 48) * 200 + (Comunicacao.Buffer_resp[15] - 48)));
					this.Valor_PressaoRec.Text = Conversions.ToString((int)((Comunicacao.Buffer_resp[16] - 48) * 200 + (Comunicacao.Buffer_resp[17] - 48)));
					this.Valor_PressaoSuc.Text = Conversions.ToString((int)((Comunicacao.Buffer_resp[18] - 48) * 200 + (Comunicacao.Buffer_resp[19] - 48)));
					this.Valor_Niveldesliga.Text = Conversions.ToString((int)((Comunicacao.Buffer_resp[20] - 48) * 200 + (Comunicacao.Buffer_resp[21] - 48)));
					this.Valor_NivelLiga.Text = Conversions.ToString((int)((Comunicacao.Buffer_resp[22] - 48) * 200 + (Comunicacao.Buffer_resp[23] - 48)));
				}
				else
				{
					this.Valor_NivelDesejado.Text = Conversions.ToString((double)(Comunicacao.Buffer_resp[4] - 48) / 2.0);
					this.Valor_NivelB1.Text = Conversions.ToString((double)(Comunicacao.Buffer_resp[5] - 48) / 2.0);
					this.Valor_NivelB2.Text = Conversions.ToString((double)(Comunicacao.Buffer_resp[6] - 48) / 2.0);
					this.Valor_NivelB3.Text = Conversions.ToString((double)(Comunicacao.Buffer_resp[7] - 48) / 2.0);
					this.Valor_NivelB4.Text = Conversions.ToString((double)(Comunicacao.Buffer_resp[8] - 48) / 2.0);
					this.Valor_TempoMaisUmaBomba.Text = Conversions.ToString((int)(Comunicacao.Buffer_resp[9] - 48));
					this.Valor_PressaoRec.Text = Conversions.ToString((double)(Comunicacao.Buffer_resp[10] - 48) / 2.0);
					this.Valor_PressaoSuc.Text = Conversions.ToString((double)(Comunicacao.Buffer_resp[11] - 48) / 2.0);
					this.Valor_NivelLiga.Text = Conversions.ToString((double)(Comunicacao.Buffer_resp[12] - 48) / 2.0);
					this.Valor_Niveldesliga.Text = Conversions.ToString((double)(Comunicacao.Buffer_resp[13] - 48) / 2.0);
				}
			}
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0030BC4C File Offset: 0x0030A04C
		public void Limpa_monitoracao_820_300(int tipo)
		{
			switch (tipo)
			{
			case 1:
				this.Grupo_medidas.Enabled = false;
				break;
			case 2:
				this.Valor_NivelDesejado.Text = "";
				this.Valor_NivelB1.Text = "";
				this.Valor_NivelB2.Text = "";
				this.Valor_NivelB3.Text = "";
				this.Valor_NivelB4.Text = "";
				this.Valor_TempoMaisUmaBomba.Text = "";
				this.Valor_PressaoRec.Text = "";
				this.Valor_PressaoSuc.Text = "";
				this.Valor_NivelLiga.Text = "";
				this.Valor_Niveldesliga.Text = "";
				break;
			}
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0030BD20 File Offset: 0x0030A120
		public void Atualiza_status_monitoracao_820_300()
		{
			int tipo = 3;
			this.Atualiza_tela_medidas_analogicas(ref Comunicacao.Buffer_resp, tipo);
			this.Atualiza_tela_alarmes(ref Comunicacao.Buffer_resp);
			this.Atualiza_tela_controles(ref Comunicacao.Buffer_resp);
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0030BD58 File Offset: 0x0030A158
		public void Atualiza_tela_medidas_analogicas(ref byte[] dados, int tipo)
		{
			int[] array = new int[5];
			checked
			{
				switch (tipo)
				{
				case 3:
				{
					int num = 0;
					do
					{
						array[num] = (int)((dados[6 + num * 2] - 48) * 200);
						array[num] += (int)(dados[6 + num * 2 + 1] - 48);
						this.dgv_EA.Rows[num].Cells[0].Value = array[num].ToString();
						bool flag = Conversions.ToBoolean(this.dgv_EA.Rows[num].Cells[1].Value);
						if (flag)
						{
							decimal num2 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.dgv_EA.Rows[num].Cells[2].Value));
							decimal num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(this.dgv_EA.Rows[num].Cells[3].Value));
							decimal num4 = decimal.Subtract(num3, num2);
							if (decimal.Compare(num4, 0m) != 0)
							{
								decimal num5 = decimal.Divide(4000m, num4);
								decimal num6 = decimal.Add(decimal.Divide(new decimal(array[num]), num5), num2);
								this.dgv_EA.Rows[num].Cells[4].Value = Strings.Format(num6, "0.0");
							}
							else
							{
								this.dgv_EA.Rows[num].Cells[4].Value = "DIV 0";
							}
						}
						else
						{
							this.dgv_EA.Rows[num].Cells[4].Value = "";
						}
						num++;
					}
					while (num <= 3);
					break;
				}
				}
			}
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0030BF40 File Offset: 0x0030A340
		public void Atualiza_tela_alarmes(ref byte[] dados)
		{
			Bitmap sem_bateria_greyed = Resources.sem_bateria_greyed;
			Bitmap com_bateria = Resources.com_bateria;
			Bitmap sem_transbordo_greyed = Resources.sem_transbordo_greyed;
			Bitmap com_transbordo_colored = Resources.com_transbordo_colored;
			Bitmap com_ac_greyed = Resources.com_ac_greyed;
			Bitmap sem_ac = Resources.sem_ac;
			Bitmap porta_fechada_greyed = Resources.porta_fechada_greyed;
			Bitmap porta_aberta = Resources.porta_aberta;
			Bitmap com_alagamento_colored = Resources.com_alagamento_colored;
			Bitmap sem_alagamento = Resources.sem_alagamento;
			Bitmap com_horarioponta = Resources.com_horarioponta;
			Bitmap sem_horarioponta_greyed = Resources.sem_horarioponta_greyed;
			checked
			{
				int num = (int)((dados[4] - 48) * 16);
				num += (int)(dados[6] - 48);
				this.cb_ED1.Checked = ((num & 1) != 0);
				this.cb_ED2.Checked = ((num & 2) != 0);
				this.cb_ED3.Checked = ((num & 4) != 0);
				this.cb_ED4.Checked = ((num & 8) != 0);
				this.cb_ED5.Checked = ((num & 16) != 0);
				this.cb_ED6.Checked = ((num & 32) != 0);
				this.cb_ED7.Checked = ((num & 64) != 0);
				this.cb_ED8.Checked = ((num & 128) != 0);
				int num2 = (int)((dados[15] - 48) * 200);
				num2 += (int)(dados[16] - 48);
				bool flag = (num2 & 1) != 0;
				if (flag)
				{
					this.pb_bit0.Image = com_bateria;
				}
				else
				{
					this.pb_bit0.Image = sem_bateria_greyed;
				}
				this.pb_bit0.Refresh();
				flag = ((num2 & 2) != 0);
				if (flag)
				{
					this.pb_bit1.Image = com_transbordo_colored;
				}
				else
				{
					this.pb_bit1.Image = sem_transbordo_greyed;
				}
				this.pb_bit1.Refresh();
				flag = ((num2 & 4) != 0);
				if (flag)
				{
					this.pb_bit2.Image = sem_ac;
				}
				else
				{
					this.pb_bit2.Image = com_ac_greyed;
				}
				this.pb_bit2.Refresh();
				flag = ((num2 & 8) != 0);
				if (flag)
				{
					this.pb_bit3.Image = porta_aberta;
				}
				else
				{
					this.pb_bit3.Image = porta_fechada_greyed;
				}
				this.pb_bit3.Refresh();
				flag = ((num2 & 16) != 0);
				if (flag)
				{
					this.pb_bit4.Image = com_alagamento_colored;
				}
				else
				{
					this.pb_bit4.Image = sem_alagamento;
				}
				this.pb_bit4.Refresh();
				flag = ((num2 & 32) != 0);
				if (flag)
				{
					this.pb_bit5.Image = com_horarioponta;
				}
				else
				{
					this.pb_bit5.Image = sem_horarioponta_greyed;
				}
				this.pb_bit5.Refresh();
			}
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0030C190 File Offset: 0x0030A590
		public void Atualiza_tela_controles(ref byte[] dados)
		{
			Bitmap chave_local = Resources.chave_local;
			Bitmap chave_remoto = Resources.chave_remoto;
			Bitmap chave_vazia = Resources.chave_vazia;
			Bitmap chave_auto = Resources.chave_auto;
			Bitmap chave_manual = Resources.chave_manual;
			Bitmap chave_on = Resources.chave_on;
			Bitmap chave_off = Resources.chave_off;
			int num = 0;
			checked
			{
				do
				{
					byte b = dados[14 + num] - 48;
					bool flag = (b & 64) > 0;
					bool flag2 = (b & 32) > 0;
					int num2 = (int)(b & 15);
					this.ctlr[num].modo = flag2;
					if (flag)
					{
						this.dgv_Controle.Rows[num].Cells[0].Value = this.Msg_Estado_820_300[num2];
						this.dgv_Controle.Rows[num].Cells[0].ReadOnly = true;
						this.dgv_Controle.Rows[num].Cells[1].Value = chave_local;
						this.dgv_Controle.Rows[num].Cells[1].ReadOnly = true;
						this.dgv_Controle.Rows[num].Cells[2].Value = chave_vazia;
						this.dgv_Controle.Rows[num].Cells[2].ReadOnly = true;
						switch (num2)
						{
						case 0:
							this.dgv_Controle.Rows[num].Cells[3].Value = chave_vazia;
							break;
						case 1:
							this.dgv_Controle.Rows[num].Cells[3].Value = chave_off;
							break;
						case 3:
							this.dgv_Controle.Rows[num].Cells[3].Value = chave_on;
							break;
						}
						this.dgv_Controle.Rows[num].Cells[3].ReadOnly = true;
					}
					else
					{
						this.dgv_Controle.Rows[num].Cells[1].Value = chave_remoto;
						this.dgv_Controle.Rows[num].Cells[1].ReadOnly = true;
						this.dgv_Controle.Rows[num].Cells[0].Value = this.Msg_Estado_820_300[num2];
						this.dgv_Controle.Rows[num].Cells[0].ReadOnly = true;
						if (flag2)
						{
							this.dgv_Controle.Rows[num].Cells[2].Value = chave_manual;
							this.dgv_Controle.Rows[num].Cells[2].ReadOnly = false;
							switch (num2)
							{
							case 0:
								this.dgv_Controle.Rows[num].Cells[3].Value = chave_vazia;
								this.dgv_Controle.Rows[num].Cells[3].ReadOnly = true;
								break;
							case 1:
								this.dgv_Controle.Rows[num].Cells[3].Value = chave_off;
								this.dgv_Controle.Rows[num].Cells[3].ReadOnly = false;
								this.ctlr[num].ld = false;
								break;
							case 3:
								this.dgv_Controle.Rows[num].Cells[3].Value = chave_on;
								this.dgv_Controle.Rows[num].Cells[3].ReadOnly = false;
								this.ctlr[num].ld = true;
								break;
							}
						}
						else
						{
							this.dgv_Controle.Rows[num].Cells[2].Value = chave_auto;
							this.dgv_Controle.Rows[num].Cells[2].ReadOnly = false;
							switch (num2)
							{
							case 0:
								this.dgv_Controle.Rows[num].Cells[3].Value = chave_vazia;
								break;
							case 1:
								this.dgv_Controle.Rows[num].Cells[3].Value = chave_off;
								break;
							case 3:
								this.dgv_Controle.Rows[num].Cells[3].Value = chave_on;
								break;
							}
							this.dgv_Controle.Rows[num].Cells[3].ReadOnly = true;
						}
					}
					num++;
				}
				while (num <= 0);
			}
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0030C680 File Offset: 0x0030AA80
		public Equip_810_mon.HAB_CTRL Controles_bombas(int modo_placa, int status_bomba)
		{
			int num = status_bomba & 15;
			int num2 = checked((int)Math.Round((double)(status_bomba & 32) / 32.0));
			Equip_810_mon.HAB_CTRL result;
			result.modo_motor = this.Msg_modo_bomba_202[num2];
			result.modo_placa = this.Msg_modo_placa_202[modo_placa];
			result.status = this.Msg_status_202[num];
			switch (modo_placa)
			{
			case 1:
			case 5:
				result.Tecla_auto = false;
				result.Tecla_man = false;
				if (num == 1)
				{
					result.Tecla_liga = true;
					result.Tecla_desliga = false;
					result.Tecla_falha = false;
					return result;
				}
				if (num >= 3 & num <= 6)
				{
					result.Tecla_liga = false;
					result.Tecla_desliga = true;
					result.Tecla_falha = false;
					return result;
				}
				if (num > 6 & num < 15)
				{
					result.Tecla_liga = false;
					result.Tecla_desliga = false;
					result.Tecla_falha = true;
					return result;
				}
				result.Tecla_liga = false;
				result.Tecla_desliga = false;
				result.Tecla_falha = false;
				return result;
			}
			if (num2 == 0)
			{
				result.Tecla_auto = false;
				result.Tecla_man = true;
				result.Tecla_liga = false;
				result.Tecla_desliga = false;
				result.Tecla_falha = true;
			}
			else
			{
				result.Tecla_auto = true;
				result.Tecla_man = false;
				result.Tecla_liga = true;
				result.Tecla_desliga = true;
				result.Tecla_falha = true;
			}
			return result;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0030C7EC File Offset: 0x0030ABEC
		private void Tela_endereco_mestre_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Mestre = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Inicializa_tela_equipamento_MD202_mon();
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0030C818 File Offset: 0x0030AC18
		public void Inicializa_tela_equipamento_MD202_mon()
		{
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Iniciar", false) != 0)
			{
				this.Mensagem_MD202_mon(" Aguarde ... ", 2);
				Mod_MD.Monitoracao_MD_RQ.Controle_mon = 1;
			}
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0030C84C File Offset: 0x0030AC4C
		private void Tela_endereco_estacao_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Estacao = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Inicializa_tela_equipamento_MD202_mon();
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0030C878 File Offset: 0x0030AC78
		private void Button_limpa_estatistica_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Num_Rx = 0L;
			Mod_MD.Monitoracao_MD_RQ.Num_Tx = 0L;
			Mod_MD.Monitoracao_MD_RQ.Eficiencia_com = 0;
			Mod_MD.Monitoracao_MD_RQ.Num_Retry = 0L;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0030C8AC File Offset: 0x0030ACAC
		private void Comando_le_setpoint_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 1;
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0030C8BC File Offset: 0x0030ACBC
		private void Comando_escreve_setpoint_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 3;
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0030C8CC File Offset: 0x0030ACCC
		private void Cmd_liga_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0030C8F0 File Offset: 0x0030ACF0
		private void Cmd_desliga_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0030C914 File Offset: 0x0030AD14
		private void Cmd_manual_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0030C938 File Offset: 0x0030AD38
		private void Cmd_automatico_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0030C95C File Offset: 0x0030AD5C
		private void Cmd_falha_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 71;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0030C980 File Offset: 0x0030AD80
		private void Cmd_liga_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x0030C9A4 File Offset: 0x0030ADA4
		private void Cmd_desliga_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0030C9C8 File Offset: 0x0030ADC8
		private void Cmd_manual_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0030C9EC File Offset: 0x0030ADEC
		private void Cmd_automatico_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0030CA10 File Offset: 0x0030AE10
		private void Cmd_falha_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 71;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0030CA34 File Offset: 0x0030AE34
		private void Cmd_liga_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0030CA58 File Offset: 0x0030AE58
		private void Cmd_desliga_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x0030CA7C File Offset: 0x0030AE7C
		private void Cmd_manual_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x0030CAA0 File Offset: 0x0030AEA0
		private void Cmd_automatico_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x0030CAC4 File Offset: 0x0030AEC4
		private void Cmd_falha_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 71;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0030CAE8 File Offset: 0x0030AEE8
		private void Cmd_liga_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0030CB0C File Offset: 0x0030AF0C
		private void Cmd_desliga_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0030CB30 File Offset: 0x0030AF30
		private void Cmd_manual_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x0030CB54 File Offset: 0x0030AF54
		private void Cmd_automatico_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x0030CB78 File Offset: 0x0030AF78
		private void Cmd_falha_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 71;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0030CB9C File Offset: 0x0030AF9C
		private void Tela_nivel_origem_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Nivel_origem = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0030CBC4 File Offset: 0x0030AFC4
		private void Tela_nivel_destino_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Nivel_dest = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0030CBEC File Offset: 0x0030AFEC
		private void Equip_820_mon_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Parar", false) == 0)
			{
				Interaction.MsgBox("Anter de fechar a tela é necessário parar a monitoração!", 0, null);
				return;
			}
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0030CC18 File Offset: 0x0030B018
		private void dgv_Controle_DoubleClick(object sender, EventArgs e)
		{
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0030CC1C File Offset: 0x0030B01C
		private void dgv_Controle_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			checked
			{
				switch (e.ColumnIndex)
				{
				case 1:
					Interaction.MsgBox("Nesta configuração é permitido apenas a visualização do estado do controle!", 0, null);
					break;
				case 2:
					if (!this.dgv_Controle.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly)
					{
						if (!this.ctlr[e.RowIndex].modo)
						{
							Interaction.MsgBox("AUTOMÁTICO -> MANUAL CONTROLE" + (e.RowIndex + 1).ToString(), 0, null);
							Mod_MD.Monitoracao_MD_RQ.Numero_motor = e.RowIndex + 1;
							Mod_MD.Monitoracao_MD_RQ.Comando = 69;
							Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
						}
						else
						{
							Interaction.MsgBox("MANUAL -> AUTOMÁTICO CONTROLE" + (e.RowIndex + 1).ToString(), 0, null);
							Mod_MD.Monitoracao_MD_RQ.Numero_motor = e.RowIndex + 1;
							Mod_MD.Monitoracao_MD_RQ.Comando = 70;
							Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
						}
					}
					else
					{
						Interaction.MsgBox("Nesta configuração é permitido apenas a visualização do estado do controle!", 0, null);
					}
					break;
				case 3:
					if (!this.dgv_Controle.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly)
					{
						if (!this.ctlr[e.RowIndex].ld)
						{
							Interaction.MsgBox("Comando de Ligar CONTROLE" + (e.RowIndex + 1).ToString(), 0, null);
							Mod_MD.Monitoracao_MD_RQ.Numero_motor = e.RowIndex + 1;
							Mod_MD.Monitoracao_MD_RQ.Comando = 67;
							Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
						}
						else
						{
							Interaction.MsgBox("Comando de Desligar CONTROLE" + (e.RowIndex + 1).ToString(), 0, null);
							Mod_MD.Monitoracao_MD_RQ.Numero_motor = e.RowIndex + 1;
							Mod_MD.Monitoracao_MD_RQ.Comando = 68;
							Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
						}
					}
					else
					{
						Interaction.MsgBox("Nesta configuração é permitido apenas a visualização do estado do controle!", 0, null);
					}
					break;
				}
			}
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0030CE44 File Offset: 0x0030B244
		private void bt_end_default_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Iniciar", false) != 0)
			{
				Interaction.MsgBox("Monitoração em execução. Não é possivel trocar os endereços", 0, null);
			}
			else
			{
				this.Tela_endereco_mestre.Value = 100m;
				this.Tela_endereco_estacao.Value = 1m;
			}
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0030CE9C File Offset: 0x0030B29C
		private void pb_hab_monitoracao_Click(object sender, EventArgs e)
		{
			Bitmap start_button = Resources.start_button;
			Bitmap stop_button = Resources.stop_button;
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Iniciar", false) == 0)
			{
				Comunicacao.Ctrl_Com.Tipo_protocolo = 2;
				if (!Geral.Config_geral.Porta_serial_Ok)
				{
					Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", 0, null);
					return;
				}
				if (Mod_MD.Monitoracao_MD_RQ.Estacao > 0 & Mod_MD.Monitoracao_MD_RQ.Estacao <= 200)
				{
					this.Comando_hab_monitoracao.Text = "Parar";
					this.pb_hab_monitoracao.Image = stop_button;
					this.Mensagem_MD202_mon("Monitoração Ativada", 2);
					Mod_MD.Monitoracao_MD_RQ.Controle_mon = 2;
					Mod_MD.Monitoracao_MD_RQ.Partir_mon = true;
					this.Timer_monitoracao.Interval = 1;
					this.Timer_monitoracao.Enabled = true;
					this.Grupo_setpoints.Enabled = true;
					this.Grupo_escrita_de_dados.Enabled = true;
					this.Grupo_status.Enabled = true;
					this.Grupo_estatistica.Enabled = true;
					Mod_MD.Monitoracao_MD_RQ.Num_Rx = 0L;
					Mod_MD.Monitoracao_MD_RQ.Num_Tx = 0L;
					Mod_MD.Monitoracao_MD_RQ.Eficiencia_com = 0;
					Mod_MD.Monitoracao_MD_RQ.Num_Retry = 0L;
					this.Grupo_medidas.Enabled = false;
				}
				else
				{
					this.Mensagem_MD202_mon("Selecione Estação", 1);
				}
			}
			else
			{
				this.Comando_hab_monitoracao.Text = "Iniciar";
				this.pb_hab_monitoracao.Image = start_button;
				this.Mensagem_MD202_mon("Monitoração desativada", 2);
				Mod_MD.Monitoracao_MD_RQ.Partir_mon = false;
				this.Timer_monitoracao.Enabled = false;
				this.Grupo_setpoints.Enabled = false;
				this.Grupo_escrita_de_dados.Enabled = false;
				this.Grupo_status.Enabled = false;
				this.Grupo_estatistica.Enabled = false;
				this.Grupo_medidas.Enabled = false;
				this.Grupo_medidas.Enabled = true;
			}
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0030D07C File Offset: 0x0030B47C
		private void Comando_hab_monitoracao_Click(object sender, EventArgs e)
		{
			this.Grupo_medidas.Enabled = true;
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null), "Iniciar", false))
			{
				if (!Geral.Config_geral.Porta_serial_Ok)
				{
					Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", 0, null);
					return;
				}
				if (Mod_MD.Monitoracao_MD_RQ.Estacao > 0 & Mod_MD.Monitoracao_MD_RQ.Estacao <= 200)
				{
					NewLateBinding.LateSet(sender, null, "text", new object[]
					{
						"Parar"
					}, null, null);
					this.Mensagem_MD202_mon("Monitoração Ativada", 2);
					Mod_MD.Monitoracao_MD_RQ.Controle_mon = 2;
					Mod_MD.Monitoracao_MD_RQ.Partir_mon = true;
					this.Timer_monitoracao.Interval = 1;
					this.Timer_monitoracao.Enabled = true;
					this.Grupo_setpoints.Enabled = true;
					this.Grupo_escrita_de_dados.Enabled = true;
					this.Grupo_status.Enabled = true;
					this.Grupo_estatistica.Enabled = true;
					Mod_MD.Monitoracao_MD_RQ.Num_Rx = 0L;
					Mod_MD.Monitoracao_MD_RQ.Num_Tx = 0L;
					Mod_MD.Monitoracao_MD_RQ.Eficiencia_com = 0;
					Mod_MD.Monitoracao_MD_RQ.Num_Retry = 0L;
				}
				else
				{
					this.Mensagem_MD202_mon("Selecione Estação", 1);
				}
			}
			else
			{
				NewLateBinding.LateSet(sender, null, "text", new object[]
				{
					"Iniciar"
				}, null, null);
				this.Mensagem_MD202_mon("Monitoração desativada", 2);
				Mod_MD.Monitoracao_MD_RQ.Partir_mon = false;
				this.Timer_monitoracao.Enabled = false;
				this.Grupo_setpoints.Enabled = false;
				this.Grupo_escrita_de_dados.Enabled = false;
				this.Grupo_status.Enabled = false;
				this.Grupo_estatistica.Enabled = false;
				this.Grupo_medidas.Enabled = false;
			}
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0030D244 File Offset: 0x0030B644
		private void dgv_Referencias_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0030D248 File Offset: 0x0030B648
		private void dgv_Referencias_KeyDown(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0030D24C File Offset: 0x0030B64C
		private void dgv_Referencias_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0030D250 File Offset: 0x0030B650
		private void dgv_Referencias_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.dgv_Referencias.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_range", false) == 0)
			{
				this.ValorReferencia[e.RowIndex].Valor = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue))));
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Ctrl_erro ctrl_erro = RT_geral.Limite_ok_celula(ref dataGridView, ref this.ValorReferencia[e.RowIndex], e, true);
				sender = dataGridView;
				RT_geral.Ctrl_erro ctrl_erro2 = ctrl_erro;
				if (!ctrl_erro2.resultado)
				{
					this.ValorReferencia[e.RowIndex].Valor = 0;
				}
			}
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0030D2FC File Offset: 0x0030B6FC
		private void dgv_Referencias_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.dgv_Referencias.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_range", false) == 0)
			{
				this.dgv_Referencias.Rows[e.RowIndex].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_Referencias.Rows[e.RowIndex].Cells[0].Value));
				this.ValorReferencia[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_Referencias.Rows[e.RowIndex].Cells[0].Value);
			}
		}

		// Token: 0x0400086B RID: 2155
		[AccessedThroughProperty("Grupo_ctrl_com")]
		private GroupBox _Grupo_ctrl_com;

		// Token: 0x0400086C RID: 2156
		[AccessedThroughProperty("Tela_endereco_estacao")]
		private NumericUpDown _Tela_endereco_estacao;

		// Token: 0x0400086D RID: 2157
		[AccessedThroughProperty("Tela_endereco_mestre")]
		private NumericUpDown _Tela_endereco_mestre;

		// Token: 0x0400086E RID: 2158
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400086F RID: 2159
		[AccessedThroughProperty("msg")]
		private TextBox _msg;

		// Token: 0x04000870 RID: 2160
		[AccessedThroughProperty("Comando_hab_monitoracao")]
		private Button _Comando_hab_monitoracao;

		// Token: 0x04000871 RID: 2161
		[AccessedThroughProperty("Label_end_estacao")]
		private Label _Label_end_estacao;

		// Token: 0x04000872 RID: 2162
		[AccessedThroughProperty("Timer_monitoracao")]
		private Timer _Timer_monitoracao;

		// Token: 0x04000873 RID: 2163
		[AccessedThroughProperty("Grupo_setpoints")]
		private GroupBox _Grupo_setpoints;

		// Token: 0x04000874 RID: 2164
		[AccessedThroughProperty("Comando_escreve_setpoint")]
		private Button _Comando_escreve_setpoint;

		// Token: 0x04000875 RID: 2165
		[AccessedThroughProperty("Comando_le_setpoint")]
		private Button _Comando_le_setpoint;

		// Token: 0x04000876 RID: 2166
		[AccessedThroughProperty("Grupo_estatistica")]
		private GroupBox _Grupo_estatistica;

		// Token: 0x04000877 RID: 2167
		[AccessedThroughProperty("Label_Est_retry")]
		private Label _Label_Est_retry;

		// Token: 0x04000878 RID: 2168
		[AccessedThroughProperty("Est_retry")]
		private TextBox _Est_retry;

		// Token: 0x04000879 RID: 2169
		[AccessedThroughProperty("Est_eficiencia")]
		private TextBox _Est_eficiencia;

		// Token: 0x0400087A RID: 2170
		[AccessedThroughProperty("Button_limpa_estatistica")]
		private Button _Button_limpa_estatistica;

		// Token: 0x0400087B RID: 2171
		[AccessedThroughProperty("Label_Est_RX")]
		private Label _Label_Est_RX;

		// Token: 0x0400087C RID: 2172
		[AccessedThroughProperty("Label_Est_Eficiencia")]
		private Label _Label_Est_Eficiencia;

		// Token: 0x0400087D RID: 2173
		[AccessedThroughProperty("Label_Est_TX")]
		private Label _Label_Est_TX;

		// Token: 0x0400087E RID: 2174
		[AccessedThroughProperty("Est_Rx")]
		private TextBox _Est_Rx;

		// Token: 0x0400087F RID: 2175
		[AccessedThroughProperty("Est_TX")]
		private TextBox _Est_TX;

		// Token: 0x04000880 RID: 2176
		[AccessedThroughProperty("Grupo_status")]
		private GroupBox _Grupo_status;

		// Token: 0x04000881 RID: 2177
		[AccessedThroughProperty("Grupo_escrita_de_dados")]
		private GroupBox _Grupo_escrita_de_dados;

		// Token: 0x04000882 RID: 2178
		[AccessedThroughProperty("Tela_nivel_destino")]
		private NumericUpDown _Tela_nivel_destino;

		// Token: 0x04000883 RID: 2179
		[AccessedThroughProperty("Label_nivel_destino")]
		private Label _Label_nivel_destino;

		// Token: 0x04000884 RID: 2180
		[AccessedThroughProperty("Valor_NivelDesejado")]
		private TextBox _Valor_NivelDesejado;

		// Token: 0x04000885 RID: 2181
		[AccessedThroughProperty("Label_NivelDesejado")]
		private Label _Label_NivelDesejado;

		// Token: 0x04000886 RID: 2182
		[AccessedThroughProperty("Valor_NivelB1")]
		private TextBox _Valor_NivelB1;

		// Token: 0x04000887 RID: 2183
		[AccessedThroughProperty("Label_NivelB1")]
		private Label _Label_NivelB1;

		// Token: 0x04000888 RID: 2184
		[AccessedThroughProperty("Valor_PressaoRec")]
		private TextBox _Valor_PressaoRec;

		// Token: 0x04000889 RID: 2185
		[AccessedThroughProperty("Label_PressaoRec")]
		private Label _Label_PressaoRec;

		// Token: 0x0400088A RID: 2186
		[AccessedThroughProperty("Valor_TempoMaisUmaBomba")]
		private TextBox _Valor_TempoMaisUmaBomba;

		// Token: 0x0400088B RID: 2187
		[AccessedThroughProperty("Label_TempoMaisUmaBomba")]
		private Label _Label_TempoMaisUmaBomba;

		// Token: 0x0400088C RID: 2188
		[AccessedThroughProperty("Valor_NivelB4")]
		private TextBox _Valor_NivelB4;

		// Token: 0x0400088D RID: 2189
		[AccessedThroughProperty("Label_NivelB4")]
		private Label _Label_NivelB4;

		// Token: 0x0400088E RID: 2190
		[AccessedThroughProperty("Valor_NivelB3")]
		private TextBox _Valor_NivelB3;

		// Token: 0x0400088F RID: 2191
		[AccessedThroughProperty("Label_NivelB3")]
		private Label _Label_NivelB3;

		// Token: 0x04000890 RID: 2192
		[AccessedThroughProperty("Valor_NivelB2")]
		private TextBox _Valor_NivelB2;

		// Token: 0x04000891 RID: 2193
		[AccessedThroughProperty("Label_NivelB2")]
		private Label _Label_NivelB2;

		// Token: 0x04000892 RID: 2194
		[AccessedThroughProperty("Valor_Niveldesliga")]
		private TextBox _Valor_Niveldesliga;

		// Token: 0x04000893 RID: 2195
		[AccessedThroughProperty("Label_NivelDesliga")]
		private Label _Label_NivelDesliga;

		// Token: 0x04000894 RID: 2196
		[AccessedThroughProperty("Valor_NivelLiga")]
		private TextBox _Valor_NivelLiga;

		// Token: 0x04000895 RID: 2197
		[AccessedThroughProperty("Label_NivelLiga")]
		private Label _Label_NivelLiga;

		// Token: 0x04000896 RID: 2198
		[AccessedThroughProperty("Valor_PressaoSuc")]
		private TextBox _Valor_PressaoSuc;

		// Token: 0x04000897 RID: 2199
		[AccessedThroughProperty("Label_PressaoSuc")]
		private Label _Label_PressaoSuc;

		// Token: 0x04000898 RID: 2200
		[AccessedThroughProperty("Grupo_medidas")]
		private GroupBox _Grupo_medidas;

		// Token: 0x04000899 RID: 2201
		[AccessedThroughProperty("Tela_nivel_origem")]
		private NumericUpDown _Tela_nivel_origem;

		// Token: 0x0400089A RID: 2202
		[AccessedThroughProperty("Label_nivel_origem")]
		private Label _Label_nivel_origem;

		// Token: 0x0400089B RID: 2203
		[AccessedThroughProperty("Cmd_falha_b2")]
		private Button _Cmd_falha_b2;

		// Token: 0x0400089C RID: 2204
		[AccessedThroughProperty("msg_modo_operacaoZ")]
		private TextBox _msg_modo_operacaoZ;

		// Token: 0x0400089D RID: 2205
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x0400089E RID: 2206
		[AccessedThroughProperty("dgv_Referencias")]
		private DataGridView _dgv_Referencias;

		// Token: 0x0400089F RID: 2207
		[AccessedThroughProperty("Ref")]
		private DataGridViewTextBoxColumn _Ref;

		// Token: 0x040008A0 RID: 2208
		[AccessedThroughProperty("dgv_EA")]
		private DataGridView _dgv_EA;

		// Token: 0x040008A1 RID: 2209
		[AccessedThroughProperty("dgv_Controle")]
		private DataGridView _dgv_Controle;

		// Token: 0x040008A2 RID: 2210
		[AccessedThroughProperty("Estado")]
		private DataGridViewTextBoxColumn _Estado;

		// Token: 0x040008A3 RID: 2211
		[AccessedThroughProperty("Quadro")]
		private DataGridViewImageColumn _Quadro;

		// Token: 0x040008A4 RID: 2212
		[AccessedThroughProperty("Controle")]
		private DataGridViewImageColumn _Controle;

		// Token: 0x040008A5 RID: 2213
		[AccessedThroughProperty("LD")]
		private DataGridViewImageColumn _LD;

		// Token: 0x040008A6 RID: 2214
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040008A7 RID: 2215
		[AccessedThroughProperty("bt_end_default")]
		private Button _bt_end_default;

		// Token: 0x040008A8 RID: 2216
		[AccessedThroughProperty("pb_hab_monitoracao")]
		private PictureBox _pb_hab_monitoracao;

		// Token: 0x040008A9 RID: 2217
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040008AA RID: 2218
		[AccessedThroughProperty("Contagens")]
		private DataGridViewTextBoxColumn _Contagens;

		// Token: 0x040008AB RID: 2219
		[AccessedThroughProperty("Conv")]
		private DataGridViewCheckBoxColumn _Conv;

		// Token: 0x040008AC RID: 2220
		[AccessedThroughProperty("Inicio")]
		private DataGridViewTextBoxColumn _Inicio;

		// Token: 0x040008AD RID: 2221
		[AccessedThroughProperty("Fim")]
		private DataGridViewTextBoxColumn _Fim;

		// Token: 0x040008AE RID: 2222
		[AccessedThroughProperty("Medida")]
		private DataGridViewTextBoxColumn _Medida;

		// Token: 0x040008AF RID: 2223
		[AccessedThroughProperty("GroupBox_ED")]
		private GroupBox _GroupBox_ED;

		// Token: 0x040008B0 RID: 2224
		[AccessedThroughProperty("cb_ED8")]
		private CheckBox _cb_ED8;

		// Token: 0x040008B1 RID: 2225
		[AccessedThroughProperty("cb_ED7")]
		private CheckBox _cb_ED7;

		// Token: 0x040008B2 RID: 2226
		[AccessedThroughProperty("cb_ED6")]
		private CheckBox _cb_ED6;

		// Token: 0x040008B3 RID: 2227
		[AccessedThroughProperty("cb_ED5")]
		private CheckBox _cb_ED5;

		// Token: 0x040008B4 RID: 2228
		[AccessedThroughProperty("cb_ED4")]
		private CheckBox _cb_ED4;

		// Token: 0x040008B5 RID: 2229
		[AccessedThroughProperty("cb_ED3")]
		private CheckBox _cb_ED3;

		// Token: 0x040008B6 RID: 2230
		[AccessedThroughProperty("cb_ED2")]
		private CheckBox _cb_ED2;

		// Token: 0x040008B7 RID: 2231
		[AccessedThroughProperty("cb_ED1")]
		private CheckBox _cb_ED1;

		// Token: 0x040008B8 RID: 2232
		[AccessedThroughProperty("GroupBox_Alarmes")]
		private GroupBox _GroupBox_Alarmes;

		// Token: 0x040008B9 RID: 2233
		[AccessedThroughProperty("pb_bit0")]
		private PictureBox _pb_bit0;

		// Token: 0x040008BA RID: 2234
		[AccessedThroughProperty("pb_bit1")]
		private PictureBox _pb_bit1;

		// Token: 0x040008BB RID: 2235
		[AccessedThroughProperty("pb_bit5")]
		private PictureBox _pb_bit5;

		// Token: 0x040008BC RID: 2236
		[AccessedThroughProperty("pb_bit2")]
		private PictureBox _pb_bit2;

		// Token: 0x040008BD RID: 2237
		[AccessedThroughProperty("pb_bit4")]
		private PictureBox _pb_bit4;

		// Token: 0x040008BE RID: 2238
		[AccessedThroughProperty("pb_bit3")]
		private PictureBox _pb_bit3;

		// Token: 0x040008BF RID: 2239
		public const int DADOS_FORMATO_200 = 1;

		// Token: 0x040008C0 RID: 2240
		public const int DADOS_FORMATO_200_4000 = 2;

		// Token: 0x040008C1 RID: 2241
		public const int DADOS_FORMATO_4000 = 3;

		// Token: 0x040008C2 RID: 2242
		public const int OFFSET_END = 3;

		// Token: 0x040008C3 RID: 2243
		public const int OFFSET_EA = 6;

		// Token: 0x040008C4 RID: 2244
		public const int OFFSET_ED = 4;

		// Token: 0x040008C5 RID: 2245
		public const int OFFSET_ALARMES = 15;

		// Token: 0x040008C6 RID: 2246
		public const int OFFSET_CONTROLE = 14;

		// Token: 0x040008C7 RID: 2247
		public const int MASCARA_ALM_OPERANDO_BAT_820_300 = 1;

		// Token: 0x040008C8 RID: 2248
		public const int MASCARA_ALM_TRANSBORDE_820_300 = 2;

		// Token: 0x040008C9 RID: 2249
		public const int MASCARA_ALM_FALTAFASE_820_300 = 4;

		// Token: 0x040008CA RID: 2250
		public const int MASCARA_ALM_ARROMBAMENTO_820_300 = 8;

		// Token: 0x040008CB RID: 2251
		public const int MASCARA_ALM_ALAGAMENTO_820_300 = 16;

		// Token: 0x040008CC RID: 2252
		public const int MASCARA_ALM_HORARIOPONTA_820_300 = 32;

		// Token: 0x040008CD RID: 2253
		public const int MASCARA_CONTROLE_REMOTO_LOCAL = 64;

		// Token: 0x040008CE RID: 2254
		public const int MASCARA_CONTROLE_AUTO_MANUAL = 32;

		// Token: 0x040008CF RID: 2255
		public const int MASCARA_CONTROLE_ESTADO = 15;

		// Token: 0x040008D0 RID: 2256
		public string[] Msg_status_202;

		// Token: 0x040008D1 RID: 2257
		public string[] Msg_modo_bomba_202;

		// Token: 0x040008D2 RID: 2258
		public string[] Msg_modo_placa_202;

		// Token: 0x040008D3 RID: 2259
		public string[] Msg_Estado_820_300;

		// Token: 0x040008D4 RID: 2260
		public string[] Msg_Controle_820_300;

		// Token: 0x040008D5 RID: 2261
		public string[] Msg_Quadro_820_300;

		// Token: 0x040008D6 RID: 2262
		public RT_geral.DADOS_DATAGRIDVIEW_RT_820[] Mon_820_DGVReferenciaColunas;

		// Token: 0x040008D7 RID: 2263
		private RT_geral.Integer_ictel[] ValorReferencia;

		// Token: 0x040008D8 RID: 2264
		public const int COLUNA_REFERENCIA = 0;

		// Token: 0x040008D9 RID: 2265
		public const int COLUNA_CONTAGENS = 0;

		// Token: 0x040008DA RID: 2266
		public const int COLUNA_CONVERTE = 1;

		// Token: 0x040008DB RID: 2267
		public const int COLUNA_INICIO = 2;

		// Token: 0x040008DC RID: 2268
		public const int COLUNA_FIM = 3;

		// Token: 0x040008DD RID: 2269
		public const int COLUNA_MEDIDA = 4;

		// Token: 0x040008DE RID: 2270
		public const int COLUNA_ESTADO = 0;

		// Token: 0x040008DF RID: 2271
		public const int COLUNA_CONTROLE = 2;

		// Token: 0x040008E0 RID: 2272
		public const int COLUNA_QUADRO = 1;

		// Token: 0x040008E1 RID: 2273
		public const int COLUNA_LD = 3;

		// Token: 0x040008E2 RID: 2274
		public const int NUMERO_REFERENCIAS = 4;

		// Token: 0x040008E3 RID: 2275
		public const int NUMERO_ENTRADAS_ANALOGICAS = 4;

		// Token: 0x040008E4 RID: 2276
		public const int NUMERO_CONTROLES = 1;

		// Token: 0x040008E5 RID: 2277
		private Equip_810_mon.ST_CONTROLE[] ctlr;

		// Token: 0x040008E6 RID: 2278
		private bool isValidForNumber;

		// Token: 0x02000042 RID: 66
		public struct HAB_CTRL
		{
			// Token: 0x040008E7 RID: 2279
			public bool Tecla_auto;

			// Token: 0x040008E8 RID: 2280
			public bool Tecla_man;

			// Token: 0x040008E9 RID: 2281
			public bool Tecla_liga;

			// Token: 0x040008EA RID: 2282
			public bool Tecla_desliga;

			// Token: 0x040008EB RID: 2283
			public bool Tecla_falha;

			// Token: 0x040008EC RID: 2284
			public string status;

			// Token: 0x040008ED RID: 2285
			public string modo_motor;

			// Token: 0x040008EE RID: 2286
			public string modo_placa;
		}

		// Token: 0x02000043 RID: 67
		public struct ST_CONTROLE
		{
			// Token: 0x040008EF RID: 2287
			public bool modo;

			// Token: 0x040008F0 RID: 2288
			public bool ld;
		}
	}
}
