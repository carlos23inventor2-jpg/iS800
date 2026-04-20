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
	// Token: 0x02000044 RID: 68
	[DesignerGenerated]
	public partial class Equip_820_mon : Form
	{
		// Token: 0x06001031 RID: 4145 RVA: 0x0030D3E0 File Offset: 0x0030B7E0
		public Equip_820_mon()
		{
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
				"Ligado Anormal",
				"Em Falha !!!"
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
			this.Mon_820_DGVSAColunas = new RT_geral.DADOS_DATAGRIDVIEW_RT_820[2];
			this.ValorSA = new RT_geral.Integer_ictel[3];
			this.ReallyExit = true;
			this.ctlr = new Equip_820_mon.ST_CONTROLE[9];
			this.isValidForNumber = false;
			this.InitializeComponent();
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x00310C54 File Offset: 0x0030F054
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x00310C68 File Offset: 0x0030F068
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

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x00310C74 File Offset: 0x0030F074
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x00310C88 File Offset: 0x0030F088
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

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x00310CD4 File Offset: 0x0030F0D4
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x00310CE8 File Offset: 0x0030F0E8
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

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x00310D34 File Offset: 0x0030F134
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x00310D48 File Offset: 0x0030F148
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

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x00310D54 File Offset: 0x0030F154
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x00310D68 File Offset: 0x0030F168
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

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x00310D74 File Offset: 0x0030F174
		// (set) Token: 0x0600103F RID: 4159 RVA: 0x00310D88 File Offset: 0x0030F188
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

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x00310DD4 File Offset: 0x0030F1D4
		// (set) Token: 0x06001041 RID: 4161 RVA: 0x00310DE8 File Offset: 0x0030F1E8
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

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x00310DF4 File Offset: 0x0030F1F4
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x00310E08 File Offset: 0x0030F208
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

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x00310E54 File Offset: 0x0030F254
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x00310E68 File Offset: 0x0030F268
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

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x00310E74 File Offset: 0x0030F274
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x00310E88 File Offset: 0x0030F288
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

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x00310ED4 File Offset: 0x0030F2D4
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x00310EE8 File Offset: 0x0030F2E8
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

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x00310F34 File Offset: 0x0030F334
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x00310F48 File Offset: 0x0030F348
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

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x00310F54 File Offset: 0x0030F354
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x00310F68 File Offset: 0x0030F368
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

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x00310F74 File Offset: 0x0030F374
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x00310F88 File Offset: 0x0030F388
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

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x00310F94 File Offset: 0x0030F394
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x00310FA8 File Offset: 0x0030F3A8
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

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x00310FB4 File Offset: 0x0030F3B4
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x00310FC8 File Offset: 0x0030F3C8
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

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x00311014 File Offset: 0x0030F414
		// (set) Token: 0x06001055 RID: 4181 RVA: 0x00311028 File Offset: 0x0030F428
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

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x00311034 File Offset: 0x0030F434
		// (set) Token: 0x06001057 RID: 4183 RVA: 0x00311048 File Offset: 0x0030F448
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

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x00311054 File Offset: 0x0030F454
		// (set) Token: 0x06001059 RID: 4185 RVA: 0x00311068 File Offset: 0x0030F468
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

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x00311074 File Offset: 0x0030F474
		// (set) Token: 0x0600105B RID: 4187 RVA: 0x00311088 File Offset: 0x0030F488
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

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x00311094 File Offset: 0x0030F494
		// (set) Token: 0x0600105D RID: 4189 RVA: 0x003110A8 File Offset: 0x0030F4A8
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

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x003110B4 File Offset: 0x0030F4B4
		// (set) Token: 0x0600105F RID: 4191 RVA: 0x003110C8 File Offset: 0x0030F4C8
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

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x003110D4 File Offset: 0x0030F4D4
		// (set) Token: 0x06001061 RID: 4193 RVA: 0x003110E8 File Offset: 0x0030F4E8
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

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x003110F4 File Offset: 0x0030F4F4
		// (set) Token: 0x06001063 RID: 4195 RVA: 0x00311108 File Offset: 0x0030F508
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

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x00311154 File Offset: 0x0030F554
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x00311168 File Offset: 0x0030F568
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

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x00311174 File Offset: 0x0030F574
		// (set) Token: 0x06001067 RID: 4199 RVA: 0x00311188 File Offset: 0x0030F588
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

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x00311194 File Offset: 0x0030F594
		// (set) Token: 0x06001069 RID: 4201 RVA: 0x003111A8 File Offset: 0x0030F5A8
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

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x003111B4 File Offset: 0x0030F5B4
		// (set) Token: 0x0600106B RID: 4203 RVA: 0x003111C8 File Offset: 0x0030F5C8
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

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x003111D4 File Offset: 0x0030F5D4
		// (set) Token: 0x0600106D RID: 4205 RVA: 0x003111E8 File Offset: 0x0030F5E8
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

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x003111F4 File Offset: 0x0030F5F4
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x00311208 File Offset: 0x0030F608
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

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x00311214 File Offset: 0x0030F614
		// (set) Token: 0x06001071 RID: 4209 RVA: 0x00311228 File Offset: 0x0030F628
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

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x00311234 File Offset: 0x0030F634
		// (set) Token: 0x06001073 RID: 4211 RVA: 0x00311248 File Offset: 0x0030F648
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

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x00311254 File Offset: 0x0030F654
		// (set) Token: 0x06001075 RID: 4213 RVA: 0x00311268 File Offset: 0x0030F668
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

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x00311274 File Offset: 0x0030F674
		// (set) Token: 0x06001077 RID: 4215 RVA: 0x00311288 File Offset: 0x0030F688
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

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x00311294 File Offset: 0x0030F694
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x003112A8 File Offset: 0x0030F6A8
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

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x003112B4 File Offset: 0x0030F6B4
		// (set) Token: 0x0600107B RID: 4219 RVA: 0x003112C8 File Offset: 0x0030F6C8
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

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x003112D4 File Offset: 0x0030F6D4
		// (set) Token: 0x0600107D RID: 4221 RVA: 0x003112E8 File Offset: 0x0030F6E8
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

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x003112F4 File Offset: 0x0030F6F4
		// (set) Token: 0x0600107F RID: 4223 RVA: 0x00311308 File Offset: 0x0030F708
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

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x00311314 File Offset: 0x0030F714
		// (set) Token: 0x06001081 RID: 4225 RVA: 0x00311328 File Offset: 0x0030F728
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

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x00311334 File Offset: 0x0030F734
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x00311348 File Offset: 0x0030F748
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

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x00311354 File Offset: 0x0030F754
		// (set) Token: 0x06001085 RID: 4229 RVA: 0x00311368 File Offset: 0x0030F768
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

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x00311374 File Offset: 0x0030F774
		// (set) Token: 0x06001087 RID: 4231 RVA: 0x00311388 File Offset: 0x0030F788
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

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x00311394 File Offset: 0x0030F794
		// (set) Token: 0x06001089 RID: 4233 RVA: 0x003113A8 File Offset: 0x0030F7A8
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

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600108A RID: 4234 RVA: 0x003113B4 File Offset: 0x0030F7B4
		// (set) Token: 0x0600108B RID: 4235 RVA: 0x003113C8 File Offset: 0x0030F7C8
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

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x003113D4 File Offset: 0x0030F7D4
		// (set) Token: 0x0600108D RID: 4237 RVA: 0x003113E8 File Offset: 0x0030F7E8
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

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x003113F4 File Offset: 0x0030F7F4
		// (set) Token: 0x0600108F RID: 4239 RVA: 0x00311408 File Offset: 0x0030F808
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

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001090 RID: 4240 RVA: 0x00311414 File Offset: 0x0030F814
		// (set) Token: 0x06001091 RID: 4241 RVA: 0x00311428 File Offset: 0x0030F828
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

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x00311474 File Offset: 0x0030F874
		// (set) Token: 0x06001093 RID: 4243 RVA: 0x00311488 File Offset: 0x0030F888
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

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x00311494 File Offset: 0x0030F894
		// (set) Token: 0x06001095 RID: 4245 RVA: 0x003114A8 File Offset: 0x0030F8A8
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

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x003114F4 File Offset: 0x0030F8F4
		// (set) Token: 0x06001097 RID: 4247 RVA: 0x00311508 File Offset: 0x0030F908
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

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x00311514 File Offset: 0x0030F914
		// (set) Token: 0x06001099 RID: 4249 RVA: 0x00311528 File Offset: 0x0030F928
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

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x00311534 File Offset: 0x0030F934
		// (set) Token: 0x0600109B RID: 4251 RVA: 0x00311548 File Offset: 0x0030F948
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

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x00311630 File Offset: 0x0030FA30
		// (set) Token: 0x0600109D RID: 4253 RVA: 0x00311644 File Offset: 0x0030FA44
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

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x00311650 File Offset: 0x0030FA50
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x00311664 File Offset: 0x0030FA64
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

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x00311670 File Offset: 0x0030FA70
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x00311684 File Offset: 0x0030FA84
		internal virtual DataGridView dgv_Controle
		{
			get
			{
				return this._dgv_Controle;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_Controle_CellContentClick);
				DataGridViewCellEventHandler dataGridViewCellEventHandler2 = new DataGridViewCellEventHandler(this.dgv_Controle_CellContentDoubleClick);
				EventHandler eventHandler = new EventHandler(this.dgv_Controle_DoubleClick);
				if (this._dgv_Controle != null)
				{
					this._dgv_Controle.CellContentClick -= dataGridViewCellEventHandler;
					this._dgv_Controle.CellContentDoubleClick -= dataGridViewCellEventHandler2;
					this._dgv_Controle.DoubleClick -= eventHandler;
				}
				this._dgv_Controle = value;
				if (this._dgv_Controle != null)
				{
					this._dgv_Controle.CellContentClick += dataGridViewCellEventHandler;
					this._dgv_Controle.CellContentDoubleClick += dataGridViewCellEventHandler2;
					this._dgv_Controle.DoubleClick += eventHandler;
				}
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x0031171C File Offset: 0x0030FB1C
		// (set) Token: 0x060010A3 RID: 4259 RVA: 0x00311730 File Offset: 0x0030FB30
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

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x0031173C File Offset: 0x0030FB3C
		// (set) Token: 0x060010A5 RID: 4261 RVA: 0x00311750 File Offset: 0x0030FB50
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

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x0031175C File Offset: 0x0030FB5C
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x00311770 File Offset: 0x0030FB70
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

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x0031177C File Offset: 0x0030FB7C
		// (set) Token: 0x060010A9 RID: 4265 RVA: 0x00311790 File Offset: 0x0030FB90
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

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x0031179C File Offset: 0x0030FB9C
		// (set) Token: 0x060010AB RID: 4267 RVA: 0x003117B0 File Offset: 0x0030FBB0
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

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060010AC RID: 4268 RVA: 0x003117BC File Offset: 0x0030FBBC
		// (set) Token: 0x060010AD RID: 4269 RVA: 0x003117D0 File Offset: 0x0030FBD0
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

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060010AE RID: 4270 RVA: 0x0031181C File Offset: 0x0030FC1C
		// (set) Token: 0x060010AF RID: 4271 RVA: 0x00311830 File Offset: 0x0030FC30
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

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060010B0 RID: 4272 RVA: 0x0031187C File Offset: 0x0030FC7C
		// (set) Token: 0x060010B1 RID: 4273 RVA: 0x00311890 File Offset: 0x0030FC90
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

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x0031189C File Offset: 0x0030FC9C
		// (set) Token: 0x060010B3 RID: 4275 RVA: 0x003118B0 File Offset: 0x0030FCB0
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

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x003118BC File Offset: 0x0030FCBC
		// (set) Token: 0x060010B5 RID: 4277 RVA: 0x003118D0 File Offset: 0x0030FCD0
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

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x003118DC File Offset: 0x0030FCDC
		// (set) Token: 0x060010B7 RID: 4279 RVA: 0x003118F0 File Offset: 0x0030FCF0
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

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x003118FC File Offset: 0x0030FCFC
		// (set) Token: 0x060010B9 RID: 4281 RVA: 0x00311910 File Offset: 0x0030FD10
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

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x0031191C File Offset: 0x0030FD1C
		// (set) Token: 0x060010BB RID: 4283 RVA: 0x00311930 File Offset: 0x0030FD30
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

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060010BC RID: 4284 RVA: 0x0031193C File Offset: 0x0030FD3C
		// (set) Token: 0x060010BD RID: 4285 RVA: 0x00311950 File Offset: 0x0030FD50
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

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060010BE RID: 4286 RVA: 0x0031195C File Offset: 0x0030FD5C
		// (set) Token: 0x060010BF RID: 4287 RVA: 0x00311970 File Offset: 0x0030FD70
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

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060010C0 RID: 4288 RVA: 0x0031197C File Offset: 0x0030FD7C
		// (set) Token: 0x060010C1 RID: 4289 RVA: 0x00311990 File Offset: 0x0030FD90
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

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x0031199C File Offset: 0x0030FD9C
		// (set) Token: 0x060010C3 RID: 4291 RVA: 0x003119B0 File Offset: 0x0030FDB0
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

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x003119BC File Offset: 0x0030FDBC
		// (set) Token: 0x060010C5 RID: 4293 RVA: 0x003119D0 File Offset: 0x0030FDD0
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

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x003119DC File Offset: 0x0030FDDC
		// (set) Token: 0x060010C7 RID: 4295 RVA: 0x003119F0 File Offset: 0x0030FDF0
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

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x003119FC File Offset: 0x0030FDFC
		// (set) Token: 0x060010C9 RID: 4297 RVA: 0x00311A10 File Offset: 0x0030FE10
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

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060010CA RID: 4298 RVA: 0x00311A1C File Offset: 0x0030FE1C
		// (set) Token: 0x060010CB RID: 4299 RVA: 0x00311A30 File Offset: 0x0030FE30
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

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060010CC RID: 4300 RVA: 0x00311A3C File Offset: 0x0030FE3C
		// (set) Token: 0x060010CD RID: 4301 RVA: 0x00311A50 File Offset: 0x0030FE50
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

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060010CE RID: 4302 RVA: 0x00311A5C File Offset: 0x0030FE5C
		// (set) Token: 0x060010CF RID: 4303 RVA: 0x00311A70 File Offset: 0x0030FE70
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

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x00311A7C File Offset: 0x0030FE7C
		// (set) Token: 0x060010D1 RID: 4305 RVA: 0x00311A90 File Offset: 0x0030FE90
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

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060010D2 RID: 4306 RVA: 0x00311A9C File Offset: 0x0030FE9C
		// (set) Token: 0x060010D3 RID: 4307 RVA: 0x00311AB0 File Offset: 0x0030FEB0
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

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x00311ABC File Offset: 0x0030FEBC
		// (set) Token: 0x060010D5 RID: 4309 RVA: 0x00311AD0 File Offset: 0x0030FED0
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

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060010D6 RID: 4310 RVA: 0x00311ADC File Offset: 0x0030FEDC
		// (set) Token: 0x060010D7 RID: 4311 RVA: 0x00311AF0 File Offset: 0x0030FEF0
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

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x00311AFC File Offset: 0x0030FEFC
		// (set) Token: 0x060010D9 RID: 4313 RVA: 0x00311B10 File Offset: 0x0030FF10
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

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x00311B1C File Offset: 0x0030FF1C
		// (set) Token: 0x060010DB RID: 4315 RVA: 0x00311B30 File Offset: 0x0030FF30
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

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x00311B3C File Offset: 0x0030FF3C
		// (set) Token: 0x060010DD RID: 4317 RVA: 0x00311B50 File Offset: 0x0030FF50
		internal virtual GroupBox gb_ajuste
		{
			get
			{
				return this._gb_ajuste;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GroupBox2_Enter);
				if (this._gb_ajuste != null)
				{
					this._gb_ajuste.Enter -= eventHandler;
				}
				this._gb_ajuste = value;
				if (this._gb_ajuste != null)
				{
					this._gb_ajuste.Enter += eventHandler;
				}
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x00311B9C File Offset: 0x0030FF9C
		// (set) Token: 0x060010DF RID: 4319 RVA: 0x00311BB0 File Offset: 0x0030FFB0
		internal virtual Button bt_rel_escrita
		{
			get
			{
				return this._bt_rel_escrita;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bt_rel_escrita_Click);
				if (this._bt_rel_escrita != null)
				{
					this._bt_rel_escrita.Click -= eventHandler;
				}
				this._bt_rel_escrita = value;
				if (this._bt_rel_escrita != null)
				{
					this._bt_rel_escrita.Click += eventHandler;
				}
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x00311BFC File Offset: 0x0030FFFC
		// (set) Token: 0x060010E1 RID: 4321 RVA: 0x00311C10 File Offset: 0x00310010
		internal virtual Button bt_rel_leitura
		{
			get
			{
				return this._bt_rel_leitura;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bt_rel_leitura_Click);
				if (this._bt_rel_leitura != null)
				{
					this._bt_rel_leitura.Click -= eventHandler;
				}
				this._bt_rel_leitura = value;
				if (this._bt_rel_leitura != null)
				{
					this._bt_rel_leitura.Click += eventHandler;
				}
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x00311C5C File Offset: 0x0031005C
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x00311C70 File Offset: 0x00310070
		internal virtual CheckBox ck_ativa_ref
		{
			get
			{
				return this._ck_ativa_ref;
			}
			[MethodImpl(32)]
			set
			{
				this._ck_ativa_ref = value;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x00311C7C File Offset: 0x0031007C
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x00311C90 File Offset: 0x00310090
		internal virtual GroupBox gb_SA
		{
			get
			{
				return this._gb_SA;
			}
			[MethodImpl(32)]
			set
			{
				this._gb_SA = value;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x00311C9C File Offset: 0x0031009C
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x00311CB0 File Offset: 0x003100B0
		internal virtual CheckBox ck_ativa_sa
		{
			get
			{
				return this._ck_ativa_sa;
			}
			[MethodImpl(32)]
			set
			{
				this._ck_ativa_sa = value;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x00311CBC File Offset: 0x003100BC
		// (set) Token: 0x060010E9 RID: 4329 RVA: 0x00311CD0 File Offset: 0x003100D0
		internal virtual DataGridView dgv_SA
		{
			get
			{
				return this._dgv_SA;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgv_SA_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgv_SA_CellValidating);
				if (this._dgv_SA != null)
				{
					this._dgv_SA.CellValueChanged -= dataGridViewCellEventHandler;
					this._dgv_SA.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._dgv_SA = value;
				if (this._dgv_SA != null)
				{
					this._dgv_SA.CellValueChanged += dataGridViewCellEventHandler;
					this._dgv_SA.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x00311D40 File Offset: 0x00310140
		// (set) Token: 0x060010EB RID: 4331 RVA: 0x00311D54 File Offset: 0x00310154
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
		{
			get
			{
				return this._DataGridViewTextBoxColumn1;
			}
			[MethodImpl(32)]
			set
			{
				this._DataGridViewTextBoxColumn1 = value;
			}
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x00311D60 File Offset: 0x00310160
		private void Equip_202_mon_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Parar", false) == 0)
			{
				Interaction.MsgBox("Anter de fechar a tela é necessário parar a monitoração!", 0, null);
				return;
			}
			this.Timer_monitoracao.Enabled = false;
			RT_geral.Telas_RT_820.Monitoracao = false;
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00311DA0 File Offset: 0x003101A0
		private void InicializaEstrutura_DataGridView_Referencia()
		{
			this.Mon_820_DGVReferenciaColunas[0].TagColuna = "Ref 0-4000";
			this.Mon_820_DGVReferenciaColunas[0].NomeColuna = "range";
			this.Mon_820_DGVReferenciaColunas[0].LarguraColuna = 100;
			this.Mon_820_DGVReferenciaColunas[0].AlingColuna = 64;
			this.Mon_820_DGVReferenciaColunas[0].NumeroLinhaMenu = 0;
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x00311E14 File Offset: 0x00310214
		private void InicializaEstrutura_DataGridView_SA()
		{
			this.Mon_820_DGVSAColunas[0].TagColuna = "Ref 0-4000";
			this.Mon_820_DGVSAColunas[0].NomeColuna = "range";
			this.Mon_820_DGVSAColunas[0].LarguraColuna = 100;
			this.Mon_820_DGVSAColunas[0].AlingColuna = 64;
			this.Mon_820_DGVSAColunas[0].NumeroLinhaMenu = 0;
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x00311E88 File Offset: 0x00310288
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

		// Token: 0x060010F0 RID: 4336 RVA: 0x00311FBC File Offset: 0x003103BC
		private void GeraDataGridView_SA()
		{
			this.dgv_SA.Columns.Clear();
			this.dgv_SA.CellBorderStyle = 1;
			int num = 0;
			checked
			{
				do
				{
					if (this.Mon_820_DGVSAColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref this.Mon_820_DGVReferenciaColunas);
						this.dgv_SA.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref this.Mon_820_DGVReferenciaColunas);
						this.dgv_SA.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 0);
				this.dgv_SA.RowCount = 2;
				this.dgv_SA.RowHeadersWidth = 80;
				int num2 = 1;
				try
				{
					foreach (object obj in this.dgv_SA.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "SA " + Strings.Format(num2, "0#");
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

		// Token: 0x060010F1 RID: 4337 RVA: 0x003120F0 File Offset: 0x003104F0
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
					this.ValorSA[num2].Lmte_inf = 0;
					this.ValorSA[num2].Lmte_sup = 4000;
					this.ValorSA[num2].Padrao = 0;
					this.ValorSA[num2].ValorPadrao();
					num2++;
				}
				while (num2 <= 1);
				RT_geral.Lmte_Init_ok = true;
				num2 = 0;
				do
				{
					this.ValorReferencia[num2].Lmte_inf = 0;
					this.ValorReferencia[num2].Lmte_sup = 4000;
					this.ValorReferencia[num2].Padrao = 0;
					this.ValorReferencia[num2].ValorPadrao();
					num2++;
				}
				while (num2 <= 3);
				this.InicializaEstrutura_DataGridView_Referencia();
				this.GeraDataGridView_Referencia();
				this.InicializaEstrutura_DataGridView_SA();
				this.GeraDataGridView_SA();
				this.dgv_EA.RowCount = 16;
				this.dgv_EA.RowHeadersWidth = 75;
				num2 = 0;
				do
				{
					this.dgv_EA.Rows[num2].HeaderCell.Value = "EA" + (num2 + 1).ToString();
					this.dgv_EA.Rows[num2].Cells[4].Value = "";
					this.dgv_EA.Rows[num2].Cells[0].Value = "";
					num2++;
				}
				while (num2 <= 15);
				this.dgv_Controle.RowCount = 8;
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
				while (num2 <= 7);
				if (Geral.Ctrl_versao == 30)
				{
					this.gb_SA.Enabled = false;
				}
				else if (Geral.Ctrl_versao == 30)
				{
					this.gb_SA.Enabled = true;
				}
				this.Grupo_medidas.Enabled = true;
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00312454 File Offset: 0x00310854
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
							goto IL_17F;
						case 1:
							goto IL_146;
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
							goto IL_146;
						}
						IL_16D:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_146:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro Leitura Setpoints - não determinado", 1);
							this.Calcula_Estatistica_820_300(3);
							this.Limpa_monitoracao_820_300(2);
							goto IL_16D;
						}
						this.Calcula_Estatistica_820_300(2);
						goto IL_16D;
					}
					IL_17F:
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
						if (this.ck_ativa_ref.Checked)
						{
							Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, 57, 10, array);
						}
						else
						{
							Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, 50, 0, array);
						}
						if (this.ck_ativa_sa.Checked)
						{
							Mod_MD.Monitoracao_MD_RQ.Controle_mon = 5;
						}
						else
						{
							Mod_MD.Monitoracao_MD_RQ.Controle_mon = 2;
						}
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
							goto IL_DA5;
						case 1:
							goto IL_3CA;
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
							goto IL_3CA;
						}
						IL_3F1:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_3CA:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro Leitura Equipamento - não determinado", 1);
							this.Calcula_Estatistica_820_300(3);
							this.Limpa_monitoracao_820_300(1);
							goto IL_3F1;
						}
						this.Calcula_Estatistica_820_300(2);
						goto IL_3F1;
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
							goto IL_958;
						case 1:
							goto IL_926;
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
							goto IL_926;
						}
						IL_946:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_926:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro Escrita Setpoints - não determinado", 1);
							this.Calcula_Estatistica_820_300(3);
							goto IL_946;
						}
						this.Calcula_Estatistica_820_300(2);
						goto IL_946;
					}
					IL_958:
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
							goto IL_AB5;
						}
						case 1:
							goto IL_A83;
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
							goto IL_A83;
						}
						IL_AA3:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_A83:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro ao executar o camando - não determinado", 1);
							this.Calcula_Estatistica_820_300(3);
							goto IL_AA3;
						}
						this.Calcula_Estatistica_820_300(2);
						goto IL_AA3;
					}
					IL_AB5:
					MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
					break;
				case 5:
					i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					Mod_MD.Monitoracao_MD_RQ.Controle_mon = 2;
					while (i > 0)
					{
						i--;
						array[0] = 1;
						array[1] = this.ValorSA[0].Valor / 200;
						array[2] = this.ValorSA[0].Valor % 200;
						Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, 86, 3, array);
						if (this.ck_ativa_sa.Checked)
						{
							Mod_MD.Monitoracao_MD_RQ.Controle_mon = 6;
						}
						else
						{
							Mod_MD.Monitoracao_MD_RQ.Controle_mon = 2;
						}
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
							goto IL_DA5;
						case 1:
							goto IL_C13;
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
							goto IL_C13;
						}
						IL_C3A:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_C13:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro Leitura Equipamento - não determinado", 1);
							this.Calcula_Estatistica_820_300(3);
							this.Limpa_monitoracao_820_300(1);
							goto IL_C3A;
						}
						this.Calcula_Estatistica_820_300(2);
						goto IL_C3A;
					}
					break;
				case 6:
					i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					Mod_MD.Monitoracao_MD_RQ.Controle_mon = 2;
					while (i > 0)
					{
						i--;
						array[0] = 2;
						array[1] = this.ValorSA[1].Valor / 200;
						array[2] = this.ValorSA[1].Valor % 200;
						Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, 86, 3, array);
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
							goto IL_DA5;
						case 1:
							goto IL_D6C;
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
							goto IL_D6C;
						}
						IL_D93:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_D6C:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro Leitura Equipamento - não determinado", 1);
							this.Calcula_Estatistica_820_300(3);
							this.Limpa_monitoracao_820_300(1);
							goto IL_D93;
						}
						this.Calcula_Estatistica_820_300(2);
						goto IL_D93;
					}
					break;
				}
				IL_DA5:
				if (Mod_MD.Monitoracao_MD_RQ.Partir_mon)
				{
					this.Timer_monitoracao.Enabled = true;
				}
			}
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00313220 File Offset: 0x00311620
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

		// Token: 0x060010F4 RID: 4340 RVA: 0x00313284 File Offset: 0x00311684
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

		// Token: 0x060010F5 RID: 4341 RVA: 0x003133C4 File Offset: 0x003117C4
		public void Atualiza_Leitura_Relogio_820_300()
		{
			checked
			{
				int num = 2000 + (int)(Comunicacao.Buffer_resp[4] - 48);
				int num2 = (int)(Comunicacao.Buffer_resp[5] - 48);
				int num3 = (int)(Comunicacao.Buffer_resp[6] - 48);
				int num4 = (int)(Comunicacao.Buffer_resp[7] - 48);
				int num5 = (int)(Comunicacao.Buffer_resp[8] - 48);
				int num6 = (int)(Comunicacao.Buffer_resp[9] - 48);
				int num7 = (int)(Comunicacao.Buffer_resp[10] - 48);
				string text = string.Format("Leitura de Relógio = {0:00}:{1:00}:{2:00} {3:00}/{4:00}/{5}", new object[]
				{
					num5,
					num6,
					num7,
					num3,
					num2,
					num
				});
				MessageBox.Show(text);
			}
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00313488 File Offset: 0x00311888
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

		// Token: 0x060010F7 RID: 4343 RVA: 0x003137E0 File Offset: 0x00311BE0
		public void Limpa_monitoracao_820_300(int tipo)
		{
			switch (tipo)
			{
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

		// Token: 0x060010F8 RID: 4344 RVA: 0x003138A8 File Offset: 0x00311CA8
		public void Atualiza_status_monitoracao_820_300()
		{
			int tipo = 3;
			this.Atualiza_tela_medidas_analogicas(ref Comunicacao.Buffer_resp, tipo);
			this.Atualiza_tela_alarmes(ref Comunicacao.Buffer_resp);
			this.Atualiza_tela_controles(ref Comunicacao.Buffer_resp);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x003138E0 File Offset: 0x00311CE0
		public void Atualiza_tela_medidas_analogicas(ref byte[] dados, int tipo)
		{
			int[] array = new int[17];
			checked
			{
				switch (tipo)
				{
				case 3:
				{
					int num = 0;
					do
					{
						array[num] = (int)((dados[9 + num * 2] - 48) * 200);
						array[num] += (int)(dados[9 + num * 2 + 1] - 48);
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
					while (num <= 15);
					break;
				}
				}
			}
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00313ACC File Offset: 0x00311ECC
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
				int num = (int)(dados[4] - 48) * 4096;
				num += (int)((dados[5] - 48) * 64);
				num += (int)(dados[6] - 48);
				this.cb_ED1.Checked = ((num & 1) != 0);
				this.cb_ED2.Checked = ((num & 2) != 0);
				this.cb_ED3.Checked = ((num & 4) != 0);
				this.cb_ED4.Checked = ((num & 8) != 0);
				this.cb_ED5.Checked = ((num & 16) != 0);
				this.cb_ED6.Checked = ((num & 32) != 0);
				this.cb_ED7.Checked = ((num & 64) != 0);
				this.cb_ED8.Checked = ((num & 128) != 0);
				int num2 = (int)((dados[42] - 48) * 200);
				num2 += (int)(dados[43] - 48);
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

		// Token: 0x060010FB RID: 4347 RVA: 0x00313D2C File Offset: 0x0031212C
		public void Atualiza_tela_controles(ref byte[] dados)
		{
			Bitmap chave_local = Resources.chave_local;
			Bitmap chave_remoto = Resources.chave_remoto;
			Bitmap chave_vazia = Resources.chave_vazia;
			Bitmap chave_auto = Resources.chave_auto;
			Bitmap chave_manual = Resources.chave_manual;
			Bitmap chave_on = Resources.chave_on;
			Bitmap chave_off = Resources.chave_off;
			Bitmap chave_falha = Resources.chave_falha;
			int num = 0;
			checked
			{
				do
				{
					byte b = dados[43 + num] - 48;
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
								this.ctlr[num].falha = false;
								break;
							case 3:
								this.dgv_Controle.Rows[num].Cells[3].Value = chave_on;
								this.dgv_Controle.Rows[num].Cells[3].ReadOnly = false;
								this.ctlr[num].ld = true;
								this.ctlr[num].falha = false;
								break;
							case 7:
								this.dgv_Controle.Rows[num].Cells[3].Value = chave_falha;
								this.dgv_Controle.Rows[num].Cells[3].ReadOnly = false;
								this.ctlr[num].ld = true;
								this.ctlr[num].falha = true;
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
								this.dgv_Controle.Rows[num].Cells[3].Value = chave_vazia;
								break;
							case 3:
								this.dgv_Controle.Rows[num].Cells[3].Value = chave_vazia;
								break;
							}
							this.dgv_Controle.Rows[num].Cells[3].ReadOnly = true;
						}
					}
					num++;
				}
				while (num <= 7);
			}
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x003142C4 File Offset: 0x003126C4
		public Equip_820_mon.HAB_CTRL Controles_bombas(int modo_placa, int status_bomba)
		{
			int num = status_bomba & 15;
			int num2 = checked((int)Math.Round((double)(status_bomba & 32) / 32.0));
			Equip_820_mon.HAB_CTRL result;
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

		// Token: 0x060010FD RID: 4349 RVA: 0x00314430 File Offset: 0x00312830
		private void Tela_endereco_mestre_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Mestre = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Inicializa_tela_equipamento_MD202_mon();
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x0031445C File Offset: 0x0031285C
		public void Inicializa_tela_equipamento_MD202_mon()
		{
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Iniciar", false) != 0)
			{
				this.Mensagem_MD202_mon(" Aguarde ... ", 2);
				Mod_MD.Monitoracao_MD_RQ.Controle_mon = 1;
			}
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x00314490 File Offset: 0x00312890
		private void Tela_endereco_estacao_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Estacao = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Inicializa_tela_equipamento_MD202_mon();
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x003144BC File Offset: 0x003128BC
		private void Button_limpa_estatistica_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Num_Rx = 0L;
			Mod_MD.Monitoracao_MD_RQ.Num_Tx = 0L;
			Mod_MD.Monitoracao_MD_RQ.Eficiencia_com = 0;
			Mod_MD.Monitoracao_MD_RQ.Num_Retry = 0L;
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x003144F0 File Offset: 0x003128F0
		private void Comando_le_setpoint_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 1;
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00314500 File Offset: 0x00312900
		private void Comando_escreve_setpoint_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 3;
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00314510 File Offset: 0x00312910
		private void Cmd_liga_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00314534 File Offset: 0x00312934
		private void Cmd_desliga_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x00314558 File Offset: 0x00312958
		private void Cmd_manual_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0031457C File Offset: 0x0031297C
		private void Cmd_automatico_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x003145A0 File Offset: 0x003129A0
		private void Cmd_falha_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 71;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x003145C4 File Offset: 0x003129C4
		private void Cmd_liga_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x003145E8 File Offset: 0x003129E8
		private void Cmd_desliga_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0031460C File Offset: 0x00312A0C
		private void Cmd_manual_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00314630 File Offset: 0x00312A30
		private void Cmd_automatico_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00314654 File Offset: 0x00312A54
		private void Cmd_falha_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 71;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00314678 File Offset: 0x00312A78
		private void Cmd_liga_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x0031469C File Offset: 0x00312A9C
		private void Cmd_desliga_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x003146C0 File Offset: 0x00312AC0
		private void Cmd_manual_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x003146E4 File Offset: 0x00312AE4
		private void Cmd_automatico_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00314708 File Offset: 0x00312B08
		private void Cmd_falha_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 71;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0031472C File Offset: 0x00312B2C
		private void Cmd_liga_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00314750 File Offset: 0x00312B50
		private void Cmd_desliga_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00314774 File Offset: 0x00312B74
		private void Cmd_manual_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00314798 File Offset: 0x00312B98
		private void Cmd_automatico_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x003147BC File Offset: 0x00312BBC
		private void Cmd_falha_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 71;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x003147E0 File Offset: 0x00312BE0
		private void Tela_nivel_origem_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Nivel_origem = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x00314808 File Offset: 0x00312C08
		private void Tela_nivel_destino_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Nivel_dest = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00314830 File Offset: 0x00312C30
		private void Equip_820_mon_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Parar", false) == 0)
			{
				Interaction.MsgBox("Anter de fechar a tela é necessário parar a monitoração!", 0, null);
			}
			else
			{
				RT_geral.Telas_RT_820.Monitoracao = false;
				this.Timer_monitoracao.Enabled = false;
			}
			e.Cancel = !this.ReallyExit;
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0031488C File Offset: 0x00312C8C
		private void dgv_Controle_DoubleClick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00314890 File Offset: 0x00312C90
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
						if (this.ctlr[e.RowIndex].falha)
						{
							Interaction.MsgBox("Comando Tirar de FALHA" + (e.RowIndex + 1).ToString(), 0, null);
							Mod_MD.Monitoracao_MD_RQ.Numero_motor = e.RowIndex + 1;
							Mod_MD.Monitoracao_MD_RQ.Comando = 71;
							Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
						}
						else if (!this.ctlr[e.RowIndex].ld)
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

		// Token: 0x0600111C RID: 4380 RVA: 0x00314B20 File Offset: 0x00312F20
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

		// Token: 0x0600111D RID: 4381 RVA: 0x00314B78 File Offset: 0x00312F78
		private void pb_hab_monitoracao_Click(object sender, EventArgs e)
		{
			Bitmap start_button = Resources.start_button;
			Bitmap stop_button = Resources.stop_button;
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Iniciar", false) == 0)
			{
				Comunicacao.Ctrl_Com.Tipo_protocolo = 2;
				this.ReallyExit = false;
				this.gb_ajuste.Enabled = false;
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
				this.ReallyExit = true;
				this.gb_ajuste.Enabled = true;
				this.Comando_hab_monitoracao.Text = "Iniciar";
				this.pb_hab_monitoracao.Image = start_button;
				this.Mensagem_MD202_mon("Monitoração desativada", 2);
				Mod_MD.Monitoracao_MD_RQ.Partir_mon = false;
				this.Timer_monitoracao.Enabled = false;
				this.Grupo_setpoints.Enabled = false;
				this.Grupo_escrita_de_dados.Enabled = false;
				this.Grupo_status.Enabled = false;
				this.Grupo_estatistica.Enabled = false;
				this.Grupo_medidas.Enabled = true;
			}
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00314D74 File Offset: 0x00313174
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

		// Token: 0x0600111F RID: 4383 RVA: 0x00314F3C File Offset: 0x0031333C
		private void dgv_Referencias_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00314F40 File Offset: 0x00313340
		private void dgv_Referencias_KeyDown(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00314F44 File Offset: 0x00313344
		private void dgv_Referencias_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00314F48 File Offset: 0x00313348
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

		// Token: 0x06001123 RID: 4387 RVA: 0x00314FF4 File Offset: 0x003133F4
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

		// Token: 0x06001124 RID: 4388 RVA: 0x003150D8 File Offset: 0x003134D8
		private void GroupBox2_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x003150DC File Offset: 0x003134DC
		private void bt_rel_leitura_Click(object sender, EventArgs e)
		{
			int[] dados = new int[41];
			Comunicacao.Ctrl_Com.Tipo_protocolo = 2;
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			checked
			{
				while (i > 0)
				{
					i--;
					Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, 85, 0, dados);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						this.Mensagem_MD202_mon("Leitura Relógio - Ok", 0);
						this.Calcula_Estatistica_820_300(1);
						this.Atualiza_Leitura_Relogio_820_300();
						return;
					case 1:
						goto IL_E0;
					case 2:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro Leitura Relógio - ChkSum", 1);
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
							this.Mensagem_MD202_mon("Erro Leitura Relógio - Timeout", 1);
							this.Calcula_Estatistica_820_300(3);
						}
						else
						{
							this.Calcula_Estatistica_820_300(2);
						}
						break;
					default:
						goto IL_E0;
					}
					IL_100:
					Comunicacao.Rotina_Delay(400L);
					continue;
					IL_E0:
					if (i == 0)
					{
						this.Mensagem_MD202_mon("Erro Leitura Relógio - não determinado", 1);
						this.Calcula_Estatistica_820_300(3);
						goto IL_100;
					}
					this.Calcula_Estatistica_820_300(2);
					goto IL_100;
				}
			}
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x003151FC File Offset: 0x003135FC
		private void bt_rel_escrita_Click(object sender, EventArgs e)
		{
			int[] array = new int[41];
			Comunicacao.Ctrl_Com.Tipo_protocolo = 2;
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			checked
			{
				while (i > 0)
				{
					i--;
					array[0] = DateAndTime.Now.Year - 2000;
					array[1] = DateAndTime.Now.Month;
					array[2] = DateAndTime.Now.Day;
					array[3] = 0;
					array[4] = DateAndTime.Now.Hour;
					array[5] = DateAndTime.Now.Minute;
					array[6] = DateAndTime.Now.Second;
					Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, 84, 7, array);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						this.Mensagem_MD202_mon("Escrita Relógio - Ok", 0);
						this.Calcula_Estatistica_820_300(1);
						return;
					case 1:
						goto IL_144;
					case 2:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro Escrita Relógio - ChkSum", 1);
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
							this.Mensagem_MD202_mon("Erro Escrita Relógio - Timeout", 1);
							this.Calcula_Estatistica_820_300(3);
						}
						else
						{
							this.Calcula_Estatistica_820_300(2);
						}
						break;
					default:
						goto IL_144;
					}
					IL_164:
					Comunicacao.Rotina_Delay(400L);
					continue;
					IL_144:
					if (i == 0)
					{
						this.Mensagem_MD202_mon("Erro Escrita Relógio - não determinado", 1);
						this.Calcula_Estatistica_820_300(3);
						goto IL_164;
					}
					this.Calcula_Estatistica_820_300(2);
					goto IL_164;
				}
			}
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00315380 File Offset: 0x00313780
		private void dgv_SA_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.dgv_SA.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_range", false) == 0)
			{
				this.ValorSA[e.RowIndex].Valor = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue))));
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Ctrl_erro ctrl_erro = RT_geral.Limite_ok_celula(ref dataGridView, ref this.ValorSA[e.RowIndex], e, true);
				sender = dataGridView;
				RT_geral.Ctrl_erro ctrl_erro2 = ctrl_erro;
				if (!ctrl_erro2.resultado)
				{
					this.ValorSA[e.RowIndex].Valor = 0;
				}
			}
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0031542C File Offset: 0x0031382C
		private void dgv_SA_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.dgv_SA.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_range", false) == 0)
			{
				this.dgv_SA.Rows[e.RowIndex].Cells[0].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.dgv_SA.Rows[e.RowIndex].Cells[0].Value));
				this.ValorSA[e.RowIndex].Valor = Conversions.ToInteger(this.dgv_SA.Rows[e.RowIndex].Cells[0].Value);
			}
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00315510 File Offset: 0x00313910
		private void dgv_Controle_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00315514 File Offset: 0x00313914
		private void Equip_820_mon_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Parar", false) == 0)
			{
				Interaction.MsgBox("Anter de fechar a tela é necessário parar a monitoração!", 0, null);
				return;
			}
			this.Timer_monitoracao.Enabled = false;
			RT_geral.Telas_RT_820.Monitoracao = false;
		}

		// Token: 0x040008F2 RID: 2290
		[AccessedThroughProperty("Grupo_ctrl_com")]
		private GroupBox _Grupo_ctrl_com;

		// Token: 0x040008F3 RID: 2291
		[AccessedThroughProperty("Tela_endereco_estacao")]
		private NumericUpDown _Tela_endereco_estacao;

		// Token: 0x040008F4 RID: 2292
		[AccessedThroughProperty("Tela_endereco_mestre")]
		private NumericUpDown _Tela_endereco_mestre;

		// Token: 0x040008F5 RID: 2293
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040008F6 RID: 2294
		[AccessedThroughProperty("msg")]
		private TextBox _msg;

		// Token: 0x040008F7 RID: 2295
		[AccessedThroughProperty("Comando_hab_monitoracao")]
		private Button _Comando_hab_monitoracao;

		// Token: 0x040008F8 RID: 2296
		[AccessedThroughProperty("Label_end_estacao")]
		private Label _Label_end_estacao;

		// Token: 0x040008F9 RID: 2297
		[AccessedThroughProperty("Timer_monitoracao")]
		private Timer _Timer_monitoracao;

		// Token: 0x040008FA RID: 2298
		[AccessedThroughProperty("Grupo_setpoints")]
		private GroupBox _Grupo_setpoints;

		// Token: 0x040008FB RID: 2299
		[AccessedThroughProperty("Comando_escreve_setpoint")]
		private Button _Comando_escreve_setpoint;

		// Token: 0x040008FC RID: 2300
		[AccessedThroughProperty("Comando_le_setpoint")]
		private Button _Comando_le_setpoint;

		// Token: 0x040008FD RID: 2301
		[AccessedThroughProperty("Grupo_estatistica")]
		private GroupBox _Grupo_estatistica;

		// Token: 0x040008FE RID: 2302
		[AccessedThroughProperty("Label_Est_retry")]
		private Label _Label_Est_retry;

		// Token: 0x040008FF RID: 2303
		[AccessedThroughProperty("Est_retry")]
		private TextBox _Est_retry;

		// Token: 0x04000900 RID: 2304
		[AccessedThroughProperty("Est_eficiencia")]
		private TextBox _Est_eficiencia;

		// Token: 0x04000901 RID: 2305
		[AccessedThroughProperty("Button_limpa_estatistica")]
		private Button _Button_limpa_estatistica;

		// Token: 0x04000902 RID: 2306
		[AccessedThroughProperty("Label_Est_RX")]
		private Label _Label_Est_RX;

		// Token: 0x04000903 RID: 2307
		[AccessedThroughProperty("Label_Est_Eficiencia")]
		private Label _Label_Est_Eficiencia;

		// Token: 0x04000904 RID: 2308
		[AccessedThroughProperty("Label_Est_TX")]
		private Label _Label_Est_TX;

		// Token: 0x04000905 RID: 2309
		[AccessedThroughProperty("Est_Rx")]
		private TextBox _Est_Rx;

		// Token: 0x04000906 RID: 2310
		[AccessedThroughProperty("Est_TX")]
		private TextBox _Est_TX;

		// Token: 0x04000907 RID: 2311
		[AccessedThroughProperty("Grupo_status")]
		private GroupBox _Grupo_status;

		// Token: 0x04000908 RID: 2312
		[AccessedThroughProperty("Grupo_escrita_de_dados")]
		private GroupBox _Grupo_escrita_de_dados;

		// Token: 0x04000909 RID: 2313
		[AccessedThroughProperty("Tela_nivel_destino")]
		private NumericUpDown _Tela_nivel_destino;

		// Token: 0x0400090A RID: 2314
		[AccessedThroughProperty("Label_nivel_destino")]
		private Label _Label_nivel_destino;

		// Token: 0x0400090B RID: 2315
		[AccessedThroughProperty("Valor_NivelDesejado")]
		private TextBox _Valor_NivelDesejado;

		// Token: 0x0400090C RID: 2316
		[AccessedThroughProperty("Label_NivelDesejado")]
		private Label _Label_NivelDesejado;

		// Token: 0x0400090D RID: 2317
		[AccessedThroughProperty("Valor_NivelB1")]
		private TextBox _Valor_NivelB1;

		// Token: 0x0400090E RID: 2318
		[AccessedThroughProperty("Label_NivelB1")]
		private Label _Label_NivelB1;

		// Token: 0x0400090F RID: 2319
		[AccessedThroughProperty("Valor_PressaoRec")]
		private TextBox _Valor_PressaoRec;

		// Token: 0x04000910 RID: 2320
		[AccessedThroughProperty("Label_PressaoRec")]
		private Label _Label_PressaoRec;

		// Token: 0x04000911 RID: 2321
		[AccessedThroughProperty("Valor_TempoMaisUmaBomba")]
		private TextBox _Valor_TempoMaisUmaBomba;

		// Token: 0x04000912 RID: 2322
		[AccessedThroughProperty("Label_TempoMaisUmaBomba")]
		private Label _Label_TempoMaisUmaBomba;

		// Token: 0x04000913 RID: 2323
		[AccessedThroughProperty("Valor_NivelB4")]
		private TextBox _Valor_NivelB4;

		// Token: 0x04000914 RID: 2324
		[AccessedThroughProperty("Label_NivelB4")]
		private Label _Label_NivelB4;

		// Token: 0x04000915 RID: 2325
		[AccessedThroughProperty("Valor_NivelB3")]
		private TextBox _Valor_NivelB3;

		// Token: 0x04000916 RID: 2326
		[AccessedThroughProperty("Label_NivelB3")]
		private Label _Label_NivelB3;

		// Token: 0x04000917 RID: 2327
		[AccessedThroughProperty("Valor_NivelB2")]
		private TextBox _Valor_NivelB2;

		// Token: 0x04000918 RID: 2328
		[AccessedThroughProperty("Label_NivelB2")]
		private Label _Label_NivelB2;

		// Token: 0x04000919 RID: 2329
		[AccessedThroughProperty("Valor_Niveldesliga")]
		private TextBox _Valor_Niveldesliga;

		// Token: 0x0400091A RID: 2330
		[AccessedThroughProperty("Label_NivelDesliga")]
		private Label _Label_NivelDesliga;

		// Token: 0x0400091B RID: 2331
		[AccessedThroughProperty("Valor_NivelLiga")]
		private TextBox _Valor_NivelLiga;

		// Token: 0x0400091C RID: 2332
		[AccessedThroughProperty("Label_NivelLiga")]
		private Label _Label_NivelLiga;

		// Token: 0x0400091D RID: 2333
		[AccessedThroughProperty("Valor_PressaoSuc")]
		private TextBox _Valor_PressaoSuc;

		// Token: 0x0400091E RID: 2334
		[AccessedThroughProperty("Label_PressaoSuc")]
		private Label _Label_PressaoSuc;

		// Token: 0x0400091F RID: 2335
		[AccessedThroughProperty("Grupo_medidas")]
		private GroupBox _Grupo_medidas;

		// Token: 0x04000920 RID: 2336
		[AccessedThroughProperty("Tela_nivel_origem")]
		private NumericUpDown _Tela_nivel_origem;

		// Token: 0x04000921 RID: 2337
		[AccessedThroughProperty("Label_nivel_origem")]
		private Label _Label_nivel_origem;

		// Token: 0x04000922 RID: 2338
		[AccessedThroughProperty("Cmd_falha_b2")]
		private Button _Cmd_falha_b2;

		// Token: 0x04000923 RID: 2339
		[AccessedThroughProperty("msg_modo_operacaoZ")]
		private TextBox _msg_modo_operacaoZ;

		// Token: 0x04000924 RID: 2340
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000925 RID: 2341
		[AccessedThroughProperty("dgv_Referencias")]
		private DataGridView _dgv_Referencias;

		// Token: 0x04000926 RID: 2342
		[AccessedThroughProperty("Ref")]
		private DataGridViewTextBoxColumn _Ref;

		// Token: 0x04000927 RID: 2343
		[AccessedThroughProperty("dgv_EA")]
		private DataGridView _dgv_EA;

		// Token: 0x04000928 RID: 2344
		[AccessedThroughProperty("dgv_Controle")]
		private DataGridView _dgv_Controle;

		// Token: 0x04000929 RID: 2345
		[AccessedThroughProperty("Estado")]
		private DataGridViewTextBoxColumn _Estado;

		// Token: 0x0400092A RID: 2346
		[AccessedThroughProperty("Quadro")]
		private DataGridViewImageColumn _Quadro;

		// Token: 0x0400092B RID: 2347
		[AccessedThroughProperty("Controle")]
		private DataGridViewImageColumn _Controle;

		// Token: 0x0400092C RID: 2348
		[AccessedThroughProperty("LD")]
		private DataGridViewImageColumn _LD;

		// Token: 0x0400092D RID: 2349
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400092E RID: 2350
		[AccessedThroughProperty("bt_end_default")]
		private Button _bt_end_default;

		// Token: 0x0400092F RID: 2351
		[AccessedThroughProperty("pb_hab_monitoracao")]
		private PictureBox _pb_hab_monitoracao;

		// Token: 0x04000930 RID: 2352
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000931 RID: 2353
		[AccessedThroughProperty("Contagens")]
		private DataGridViewTextBoxColumn _Contagens;

		// Token: 0x04000932 RID: 2354
		[AccessedThroughProperty("Conv")]
		private DataGridViewCheckBoxColumn _Conv;

		// Token: 0x04000933 RID: 2355
		[AccessedThroughProperty("Inicio")]
		private DataGridViewTextBoxColumn _Inicio;

		// Token: 0x04000934 RID: 2356
		[AccessedThroughProperty("Fim")]
		private DataGridViewTextBoxColumn _Fim;

		// Token: 0x04000935 RID: 2357
		[AccessedThroughProperty("Medida")]
		private DataGridViewTextBoxColumn _Medida;

		// Token: 0x04000936 RID: 2358
		[AccessedThroughProperty("GroupBox_ED")]
		private GroupBox _GroupBox_ED;

		// Token: 0x04000937 RID: 2359
		[AccessedThroughProperty("cb_ED8")]
		private CheckBox _cb_ED8;

		// Token: 0x04000938 RID: 2360
		[AccessedThroughProperty("cb_ED7")]
		private CheckBox _cb_ED7;

		// Token: 0x04000939 RID: 2361
		[AccessedThroughProperty("cb_ED6")]
		private CheckBox _cb_ED6;

		// Token: 0x0400093A RID: 2362
		[AccessedThroughProperty("cb_ED5")]
		private CheckBox _cb_ED5;

		// Token: 0x0400093B RID: 2363
		[AccessedThroughProperty("cb_ED4")]
		private CheckBox _cb_ED4;

		// Token: 0x0400093C RID: 2364
		[AccessedThroughProperty("cb_ED3")]
		private CheckBox _cb_ED3;

		// Token: 0x0400093D RID: 2365
		[AccessedThroughProperty("cb_ED2")]
		private CheckBox _cb_ED2;

		// Token: 0x0400093E RID: 2366
		[AccessedThroughProperty("cb_ED1")]
		private CheckBox _cb_ED1;

		// Token: 0x0400093F RID: 2367
		[AccessedThroughProperty("GroupBox_Alarmes")]
		private GroupBox _GroupBox_Alarmes;

		// Token: 0x04000940 RID: 2368
		[AccessedThroughProperty("pb_bit0")]
		private PictureBox _pb_bit0;

		// Token: 0x04000941 RID: 2369
		[AccessedThroughProperty("pb_bit1")]
		private PictureBox _pb_bit1;

		// Token: 0x04000942 RID: 2370
		[AccessedThroughProperty("pb_bit5")]
		private PictureBox _pb_bit5;

		// Token: 0x04000943 RID: 2371
		[AccessedThroughProperty("pb_bit2")]
		private PictureBox _pb_bit2;

		// Token: 0x04000944 RID: 2372
		[AccessedThroughProperty("pb_bit4")]
		private PictureBox _pb_bit4;

		// Token: 0x04000945 RID: 2373
		[AccessedThroughProperty("pb_bit3")]
		private PictureBox _pb_bit3;

		// Token: 0x04000946 RID: 2374
		[AccessedThroughProperty("gb_ajuste")]
		private GroupBox _gb_ajuste;

		// Token: 0x04000947 RID: 2375
		[AccessedThroughProperty("bt_rel_escrita")]
		private Button _bt_rel_escrita;

		// Token: 0x04000948 RID: 2376
		[AccessedThroughProperty("bt_rel_leitura")]
		private Button _bt_rel_leitura;

		// Token: 0x04000949 RID: 2377
		[AccessedThroughProperty("ck_ativa_ref")]
		private CheckBox _ck_ativa_ref;

		// Token: 0x0400094A RID: 2378
		[AccessedThroughProperty("gb_SA")]
		private GroupBox _gb_SA;

		// Token: 0x0400094B RID: 2379
		[AccessedThroughProperty("ck_ativa_sa")]
		private CheckBox _ck_ativa_sa;

		// Token: 0x0400094C RID: 2380
		[AccessedThroughProperty("dgv_SA")]
		private DataGridView _dgv_SA;

		// Token: 0x0400094D RID: 2381
		[AccessedThroughProperty("DataGridViewTextBoxColumn1")]
		private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;

		// Token: 0x0400094E RID: 2382
		public const int DADOS_FORMATO_200 = 1;

		// Token: 0x0400094F RID: 2383
		public const int DADOS_FORMATO_200_4000 = 2;

		// Token: 0x04000950 RID: 2384
		public const int DADOS_FORMATO_4000 = 3;

		// Token: 0x04000951 RID: 2385
		public const int OFFSET_END = 3;

		// Token: 0x04000952 RID: 2386
		public const int OFFSET_ED = 4;

		// Token: 0x04000953 RID: 2387
		public const int OFFSET_EA = 9;

		// Token: 0x04000954 RID: 2388
		public const int OFFSET_ALARMES = 41;

		// Token: 0x04000955 RID: 2389
		public const int OFFSET_CONTROLE = 43;

		// Token: 0x04000956 RID: 2390
		public const int MASCARA_ALM_OPERANDO_BAT_820_300 = 1;

		// Token: 0x04000957 RID: 2391
		public const int MASCARA_ALM_TRANSBORDE_820_300 = 2;

		// Token: 0x04000958 RID: 2392
		public const int MASCARA_ALM_FALTAFASE_820_300 = 4;

		// Token: 0x04000959 RID: 2393
		public const int MASCARA_ALM_ARROMBAMENTO_820_300 = 8;

		// Token: 0x0400095A RID: 2394
		public const int MASCARA_ALM_ALAGAMENTO_820_300 = 16;

		// Token: 0x0400095B RID: 2395
		public const int MASCARA_ALM_HORARIOPONTA_820_300 = 32;

		// Token: 0x0400095C RID: 2396
		public const int MASCARA_CONTROLE_REMOTO_LOCAL = 64;

		// Token: 0x0400095D RID: 2397
		public const int MASCARA_CONTROLE_AUTO_MANUAL = 32;

		// Token: 0x0400095E RID: 2398
		public const int MASCARA_CONTROLE_ESTADO = 15;

		// Token: 0x0400095F RID: 2399
		public string[] Msg_status_202;

		// Token: 0x04000960 RID: 2400
		public string[] Msg_modo_bomba_202;

		// Token: 0x04000961 RID: 2401
		public string[] Msg_modo_placa_202;

		// Token: 0x04000962 RID: 2402
		public string[] Msg_Estado_820_300;

		// Token: 0x04000963 RID: 2403
		public string[] Msg_Controle_820_300;

		// Token: 0x04000964 RID: 2404
		public string[] Msg_Quadro_820_300;

		// Token: 0x04000965 RID: 2405
		public RT_geral.DADOS_DATAGRIDVIEW_RT_820[] Mon_820_DGVReferenciaColunas;

		// Token: 0x04000966 RID: 2406
		private RT_geral.Integer_ictel[] ValorReferencia;

		// Token: 0x04000967 RID: 2407
		public RT_geral.DADOS_DATAGRIDVIEW_RT_820[] Mon_820_DGVSAColunas;

		// Token: 0x04000968 RID: 2408
		private RT_geral.Integer_ictel[] ValorSA;

		// Token: 0x04000969 RID: 2409
		public bool ReallyExit;

		// Token: 0x0400096A RID: 2410
		public const int COLUNA_REFERENCIA = 0;

		// Token: 0x0400096B RID: 2411
		public const int COLUNA_CONTAGENS = 0;

		// Token: 0x0400096C RID: 2412
		public const int COLUNA_CONVERTE = 1;

		// Token: 0x0400096D RID: 2413
		public const int COLUNA_INICIO = 2;

		// Token: 0x0400096E RID: 2414
		public const int COLUNA_FIM = 3;

		// Token: 0x0400096F RID: 2415
		public const int COLUNA_MEDIDA = 4;

		// Token: 0x04000970 RID: 2416
		public const int COLUNA_ESTADO = 0;

		// Token: 0x04000971 RID: 2417
		public const int COLUNA_CONTROLE = 2;

		// Token: 0x04000972 RID: 2418
		public const int COLUNA_QUADRO = 1;

		// Token: 0x04000973 RID: 2419
		public const int COLUNA_LD = 3;

		// Token: 0x04000974 RID: 2420
		public const int NUMERO_REFERENCIAS = 4;

		// Token: 0x04000975 RID: 2421
		public const int NUMERO_ENTRADAS_ANALOGICAS = 16;

		// Token: 0x04000976 RID: 2422
		public const int NUMERO_CONTROLES = 8;

		// Token: 0x04000977 RID: 2423
		private Equip_820_mon.ST_CONTROLE[] ctlr;

		// Token: 0x04000978 RID: 2424
		private bool isValidForNumber;

		// Token: 0x02000045 RID: 69
		public struct HAB_CTRL
		{
			// Token: 0x04000979 RID: 2425
			public bool Tecla_auto;

			// Token: 0x0400097A RID: 2426
			public bool Tecla_man;

			// Token: 0x0400097B RID: 2427
			public bool Tecla_liga;

			// Token: 0x0400097C RID: 2428
			public bool Tecla_desliga;

			// Token: 0x0400097D RID: 2429
			public bool Tecla_falha;

			// Token: 0x0400097E RID: 2430
			public string status;

			// Token: 0x0400097F RID: 2431
			public string modo_motor;

			// Token: 0x04000980 RID: 2432
			public string modo_placa;
		}

		// Token: 0x02000046 RID: 70
		public struct ST_CONTROLE
		{
			// Token: 0x04000981 RID: 2433
			public bool modo;

			// Token: 0x04000982 RID: 2434
			public bool ld;

			// Token: 0x04000983 RID: 2435
			public bool falha;
		}
	}
}
