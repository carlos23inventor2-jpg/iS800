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
	// Token: 0x02000047 RID: 71
	[DesignerGenerated]
	public partial class Equip_821_mon : Form
	{
		// Token: 0x0600112B RID: 4395 RVA: 0x00315554 File Offset: 0x00313954
		public Equip_821_mon()
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
			this.ctlr = new Equip_821_mon.ST_CONTROLE[4];
			this.isValidForNumber = false;
			this.InitializeComponent();
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x003188B0 File Offset: 0x00316CB0
		// (set) Token: 0x0600112F RID: 4399 RVA: 0x003188C4 File Offset: 0x00316CC4
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

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x003188D0 File Offset: 0x00316CD0
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x003188E4 File Offset: 0x00316CE4
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

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x00318930 File Offset: 0x00316D30
		// (set) Token: 0x06001133 RID: 4403 RVA: 0x00318944 File Offset: 0x00316D44
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

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x00318990 File Offset: 0x00316D90
		// (set) Token: 0x06001135 RID: 4405 RVA: 0x003189A4 File Offset: 0x00316DA4
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

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x003189B0 File Offset: 0x00316DB0
		// (set) Token: 0x06001137 RID: 4407 RVA: 0x003189C4 File Offset: 0x00316DC4
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

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x003189D0 File Offset: 0x00316DD0
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x003189E4 File Offset: 0x00316DE4
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

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x00318A30 File Offset: 0x00316E30
		// (set) Token: 0x0600113B RID: 4411 RVA: 0x00318A44 File Offset: 0x00316E44
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

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x00318A50 File Offset: 0x00316E50
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x00318A64 File Offset: 0x00316E64
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

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x00318AB0 File Offset: 0x00316EB0
		// (set) Token: 0x0600113F RID: 4415 RVA: 0x00318AC4 File Offset: 0x00316EC4
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

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x00318AD0 File Offset: 0x00316ED0
		// (set) Token: 0x06001141 RID: 4417 RVA: 0x00318AE4 File Offset: 0x00316EE4
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

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x00318B30 File Offset: 0x00316F30
		// (set) Token: 0x06001143 RID: 4419 RVA: 0x00318B44 File Offset: 0x00316F44
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

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x00318B90 File Offset: 0x00316F90
		// (set) Token: 0x06001145 RID: 4421 RVA: 0x00318BA4 File Offset: 0x00316FA4
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

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x00318BB0 File Offset: 0x00316FB0
		// (set) Token: 0x06001147 RID: 4423 RVA: 0x00318BC4 File Offset: 0x00316FC4
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

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x00318BD0 File Offset: 0x00316FD0
		// (set) Token: 0x06001149 RID: 4425 RVA: 0x00318BE4 File Offset: 0x00316FE4
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

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x00318BF0 File Offset: 0x00316FF0
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x00318C04 File Offset: 0x00317004
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

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x00318C10 File Offset: 0x00317010
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x00318C24 File Offset: 0x00317024
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

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00318C70 File Offset: 0x00317070
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x00318C84 File Offset: 0x00317084
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

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x00318C90 File Offset: 0x00317090
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x00318CA4 File Offset: 0x003170A4
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

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x00318CB0 File Offset: 0x003170B0
		// (set) Token: 0x06001153 RID: 4435 RVA: 0x00318CC4 File Offset: 0x003170C4
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

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x00318CD0 File Offset: 0x003170D0
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x00318CE4 File Offset: 0x003170E4
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

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x00318CF0 File Offset: 0x003170F0
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x00318D04 File Offset: 0x00317104
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

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x00318D10 File Offset: 0x00317110
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x00318D24 File Offset: 0x00317124
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

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x00318D30 File Offset: 0x00317130
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x00318D44 File Offset: 0x00317144
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

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x00318D50 File Offset: 0x00317150
		// (set) Token: 0x0600115D RID: 4445 RVA: 0x00318D64 File Offset: 0x00317164
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

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x00318DB0 File Offset: 0x003171B0
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x00318DC4 File Offset: 0x003171C4
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

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x00318DD0 File Offset: 0x003171D0
		// (set) Token: 0x06001161 RID: 4449 RVA: 0x00318DE4 File Offset: 0x003171E4
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

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x00318DF0 File Offset: 0x003171F0
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x00318E04 File Offset: 0x00317204
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

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x00318E10 File Offset: 0x00317210
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x00318E24 File Offset: 0x00317224
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

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x00318E30 File Offset: 0x00317230
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x00318E44 File Offset: 0x00317244
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

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x00318E50 File Offset: 0x00317250
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x00318E64 File Offset: 0x00317264
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

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x00318E70 File Offset: 0x00317270
		// (set) Token: 0x0600116B RID: 4459 RVA: 0x00318E84 File Offset: 0x00317284
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

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x00318E90 File Offset: 0x00317290
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x00318EA4 File Offset: 0x003172A4
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

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x00318EB0 File Offset: 0x003172B0
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x00318EC4 File Offset: 0x003172C4
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

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x00318ED0 File Offset: 0x003172D0
		// (set) Token: 0x06001171 RID: 4465 RVA: 0x00318EE4 File Offset: 0x003172E4
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

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x00318EF0 File Offset: 0x003172F0
		// (set) Token: 0x06001173 RID: 4467 RVA: 0x00318F04 File Offset: 0x00317304
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

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x00318F10 File Offset: 0x00317310
		// (set) Token: 0x06001175 RID: 4469 RVA: 0x00318F24 File Offset: 0x00317324
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

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x00318F30 File Offset: 0x00317330
		// (set) Token: 0x06001177 RID: 4471 RVA: 0x00318F44 File Offset: 0x00317344
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

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x00318F50 File Offset: 0x00317350
		// (set) Token: 0x06001179 RID: 4473 RVA: 0x00318F64 File Offset: 0x00317364
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

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x00318F70 File Offset: 0x00317370
		// (set) Token: 0x0600117B RID: 4475 RVA: 0x00318F84 File Offset: 0x00317384
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

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x00318F90 File Offset: 0x00317390
		// (set) Token: 0x0600117D RID: 4477 RVA: 0x00318FA4 File Offset: 0x003173A4
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

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x00318FB0 File Offset: 0x003173B0
		// (set) Token: 0x0600117F RID: 4479 RVA: 0x00318FC4 File Offset: 0x003173C4
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

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x00318FD0 File Offset: 0x003173D0
		// (set) Token: 0x06001181 RID: 4481 RVA: 0x00318FE4 File Offset: 0x003173E4
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

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x00318FF0 File Offset: 0x003173F0
		// (set) Token: 0x06001183 RID: 4483 RVA: 0x00319004 File Offset: 0x00317404
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

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x00319010 File Offset: 0x00317410
		// (set) Token: 0x06001185 RID: 4485 RVA: 0x00319024 File Offset: 0x00317424
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

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x00319030 File Offset: 0x00317430
		// (set) Token: 0x06001187 RID: 4487 RVA: 0x00319044 File Offset: 0x00317444
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

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x00319050 File Offset: 0x00317450
		// (set) Token: 0x06001189 RID: 4489 RVA: 0x00319064 File Offset: 0x00317464
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

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x00319070 File Offset: 0x00317470
		// (set) Token: 0x0600118B RID: 4491 RVA: 0x00319084 File Offset: 0x00317484
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

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x003190D0 File Offset: 0x003174D0
		// (set) Token: 0x0600118D RID: 4493 RVA: 0x003190E4 File Offset: 0x003174E4
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

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x003190F0 File Offset: 0x003174F0
		// (set) Token: 0x0600118F RID: 4495 RVA: 0x00319104 File Offset: 0x00317504
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

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x00319150 File Offset: 0x00317550
		// (set) Token: 0x06001191 RID: 4497 RVA: 0x00319164 File Offset: 0x00317564
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

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x00319170 File Offset: 0x00317570
		// (set) Token: 0x06001193 RID: 4499 RVA: 0x00319184 File Offset: 0x00317584
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

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x00319190 File Offset: 0x00317590
		// (set) Token: 0x06001195 RID: 4501 RVA: 0x003191A4 File Offset: 0x003175A4
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

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x0031928C File Offset: 0x0031768C
		// (set) Token: 0x06001197 RID: 4503 RVA: 0x003192A0 File Offset: 0x003176A0
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

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x003192AC File Offset: 0x003176AC
		// (set) Token: 0x06001199 RID: 4505 RVA: 0x003192C0 File Offset: 0x003176C0
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

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x003192CC File Offset: 0x003176CC
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x003192E0 File Offset: 0x003176E0
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

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x00319350 File Offset: 0x00317750
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x00319364 File Offset: 0x00317764
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

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x00319370 File Offset: 0x00317770
		// (set) Token: 0x0600119F RID: 4511 RVA: 0x00319384 File Offset: 0x00317784
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

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00319390 File Offset: 0x00317790
		// (set) Token: 0x060011A1 RID: 4513 RVA: 0x003193A4 File Offset: 0x003177A4
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

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x003193B0 File Offset: 0x003177B0
		// (set) Token: 0x060011A3 RID: 4515 RVA: 0x003193C4 File Offset: 0x003177C4
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

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x003193D0 File Offset: 0x003177D0
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x003193E4 File Offset: 0x003177E4
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

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x003193F0 File Offset: 0x003177F0
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x00319404 File Offset: 0x00317804
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

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00319450 File Offset: 0x00317850
		// (set) Token: 0x060011A9 RID: 4521 RVA: 0x00319464 File Offset: 0x00317864
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

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x003194B0 File Offset: 0x003178B0
		// (set) Token: 0x060011AB RID: 4523 RVA: 0x003194C4 File Offset: 0x003178C4
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

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x003194D0 File Offset: 0x003178D0
		// (set) Token: 0x060011AD RID: 4525 RVA: 0x003194E4 File Offset: 0x003178E4
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

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x003194F0 File Offset: 0x003178F0
		// (set) Token: 0x060011AF RID: 4527 RVA: 0x00319504 File Offset: 0x00317904
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

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x00319510 File Offset: 0x00317910
		// (set) Token: 0x060011B1 RID: 4529 RVA: 0x00319524 File Offset: 0x00317924
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

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x00319530 File Offset: 0x00317930
		// (set) Token: 0x060011B3 RID: 4531 RVA: 0x00319544 File Offset: 0x00317944
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

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x00319550 File Offset: 0x00317950
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x00319564 File Offset: 0x00317964
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

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x00319570 File Offset: 0x00317970
		// (set) Token: 0x060011B7 RID: 4535 RVA: 0x00319584 File Offset: 0x00317984
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

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x00319590 File Offset: 0x00317990
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x003195A4 File Offset: 0x003179A4
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

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x003195B0 File Offset: 0x003179B0
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x003195C4 File Offset: 0x003179C4
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

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x003195D0 File Offset: 0x003179D0
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x003195E4 File Offset: 0x003179E4
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

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x003195F0 File Offset: 0x003179F0
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x00319604 File Offset: 0x00317A04
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

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x00319610 File Offset: 0x00317A10
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x00319624 File Offset: 0x00317A24
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

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00319630 File Offset: 0x00317A30
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x00319644 File Offset: 0x00317A44
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

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x00319650 File Offset: 0x00317A50
		// (set) Token: 0x060011C5 RID: 4549 RVA: 0x00319664 File Offset: 0x00317A64
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

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x00319670 File Offset: 0x00317A70
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x00319684 File Offset: 0x00317A84
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

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x00319690 File Offset: 0x00317A90
		// (set) Token: 0x060011C9 RID: 4553 RVA: 0x003196A4 File Offset: 0x00317AA4
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

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x003196B0 File Offset: 0x00317AB0
		// (set) Token: 0x060011CB RID: 4555 RVA: 0x003196C4 File Offset: 0x00317AC4
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

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x003196D0 File Offset: 0x00317AD0
		// (set) Token: 0x060011CD RID: 4557 RVA: 0x003196E4 File Offset: 0x00317AE4
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

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x003196F0 File Offset: 0x00317AF0
		// (set) Token: 0x060011CF RID: 4559 RVA: 0x00319704 File Offset: 0x00317B04
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

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00319710 File Offset: 0x00317B10
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x00319724 File Offset: 0x00317B24
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

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x00319730 File Offset: 0x00317B30
		// (set) Token: 0x060011D3 RID: 4563 RVA: 0x00319744 File Offset: 0x00317B44
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

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x00319750 File Offset: 0x00317B50
		// (set) Token: 0x060011D5 RID: 4565 RVA: 0x00319764 File Offset: 0x00317B64
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

		// Token: 0x060011D6 RID: 4566 RVA: 0x00319770 File Offset: 0x00317B70
		private void Equip_202_mon_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Parar", false) == 0)
			{
				Interaction.MsgBox("Anter de fechar a tela é necessário parar a monitoração!", (MsgBoxStyle)0, null);
				return;
			}
			this.Timer_monitoracao.Enabled = false;
			RT_geral.Telas_RT_821.Monitoracao = false;
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x003197B0 File Offset: 0x00317BB0
		private void InicializaEstrutura_DataGridView_Referencia()
		{
			this.Mon_820_DGVReferenciaColunas[0].TagColuna = "Ref 0-4000";
			this.Mon_820_DGVReferenciaColunas[0].NomeColuna = "range";
			this.Mon_820_DGVReferenciaColunas[0].LarguraColuna = 100;
			this.Mon_820_DGVReferenciaColunas[0].AlingColuna = (System.Windows.Forms.DataGridViewContentAlignment)64;
			this.Mon_820_DGVReferenciaColunas[0].NumeroLinhaMenu = 0;
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00319824 File Offset: 0x00317C24
		private void GeraDataGridView_Referencia()
		{
			this.dgv_Referencias.Columns.Clear();
			this.dgv_Referencias.CellBorderStyle = (System.Windows.Forms.DataGridViewCellBorderStyle)1;
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
					IEnumerator enumerator = null;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00319958 File Offset: 0x00317D58
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
			Interaction.MsgBox(text, (MsgBoxStyle)num, " Atenção");
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
					this.dgv_EA.Rows[num2].Cells[0].ReadOnly = true;
					this.dgv_EA.Rows[num2].Cells[1].ReadOnly = false;
					this.dgv_EA.Rows[num2].Cells[2].ReadOnly = false;
					this.dgv_EA.Rows[num2].Cells[3].ReadOnly = false;
					this.dgv_EA.Rows[num2].Cells[4].ReadOnly = false;
					num2++;
				}
				while (num2 <= 3);
				this.dgv_Controle.RowCount = 3;
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
				while (num2 <= 2);
			}
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00319CC8 File Offset: 0x003180C8
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
													break;
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
													}
						this.Calcula_Estatistica_820_300(2);
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
							goto IL_A88;
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
													break;
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
													}
						this.Calcula_Estatistica_820_300(2);
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
							array[0] = (int)Convert.ToInt16((long)Math.Round(Conversion.Val(this.Valor_NivelDesejado.Text)) / 200L);
							array[1] = (int)Convert.ToInt16(Conversion.Val(this.Valor_NivelDesejado.Text) % 200.0);
							array[2] = (int)Convert.ToInt16((long)Math.Round(Conversion.Val(this.Valor_NivelB1.Text)) / 200L);
							array[3] = (int)Convert.ToInt16(Conversion.Val(this.Valor_NivelB1.Text) % 200.0);
							array[4] = (int)Convert.ToInt16((long)Math.Round(Conversion.Val(this.Valor_NivelB2.Text)) / 200L);
							array[5] = (int)Convert.ToInt16(Conversion.Val(this.Valor_NivelB2.Text) % 200.0);
							array[6] = (int)Convert.ToInt16((long)Math.Round(Conversion.Val(this.Valor_NivelB3.Text)) / 200L);
							array[7] = (int)Convert.ToInt16(Conversion.Val(this.Valor_NivelB3.Text) % 200.0);
							array[8] = (int)Convert.ToInt16((long)Math.Round(Conversion.Val(this.Valor_NivelB4.Text)) / 200L);
							array[9] = (int)Convert.ToInt16(Conversion.Val(this.Valor_NivelB4.Text) % 200.0);
							array[10] = (int)Convert.ToInt16((long)Math.Round(Conversion.Val(this.Valor_TempoMaisUmaBomba.Text)) / 200L);
							array[11] = (int)Convert.ToInt16(Conversion.Val(this.Valor_TempoMaisUmaBomba.Text) % 200.0);
							array[12] = (int)Convert.ToInt16((long)Math.Round(Conversion.Val(this.Valor_PressaoRec.Text)) / 200L);
							array[13] = (int)Convert.ToInt16(Conversion.Val(this.Valor_PressaoRec.Text) % 200.0);
							array[14] = (int)Convert.ToInt16((long)Math.Round(Conversion.Val(this.Valor_PressaoSuc.Text)) / 200L);
							array[15] = (int)Convert.ToInt16(Conversion.Val(this.Valor_PressaoSuc.Text) % 200.0);
							array[16] = (int)Convert.ToInt16((long)Math.Round(Conversion.Val(this.Valor_Niveldesliga.Text)) / 200L);
							array[17] = (int)Convert.ToInt16(Conversion.Val(this.Valor_Niveldesliga.Text) % 200.0);
							array[18] = (int)Convert.ToInt16((long)Math.Round(Conversion.Val(this.Valor_NivelLiga.Text)) / 200L);
							array[19] = (int)Convert.ToInt16(Conversion.Val(this.Valor_NivelLiga.Text) % 200.0);
							Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, 66, 20, array);
						}
						else
						{
							unchecked
							{
								array[0] = (int)Convert.ToInt16(Conversion.Val(this.Valor_NivelDesejado.Text) * 2.0);
								array[1] = (int)Convert.ToInt16(Conversion.Val(this.Valor_NivelB1.Text) * 2.0);
								array[2] = (int)Convert.ToInt16(Conversion.Val(this.Valor_NivelB2.Text) * 2.0);
								array[3] = (int)Convert.ToInt16(Conversion.Val(this.Valor_NivelB3.Text) * 2.0);
								array[4] = (int)Convert.ToInt16(Conversion.Val(this.Valor_NivelB4.Text) * 2.0);
								array[5] = (int)Convert.ToInt16(Conversion.Val(this.Valor_TempoMaisUmaBomba.Text));
								array[6] = (int)Convert.ToInt16(Conversion.Val(this.Valor_PressaoRec.Text) * 2.0);
								array[7] = (int)Convert.ToInt16(Conversion.Val(this.Valor_PressaoSuc.Text) * 2.0);
								array[8] = (int)Convert.ToInt16(Conversion.Val(this.Valor_NivelLiga.Text) * 2.0);
								array[9] = (int)Convert.ToInt16(Conversion.Val(this.Valor_Niveldesliga.Text) * 2.0);
								Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, 66, 10, array);
							}
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
							goto IL_912;
						case 1:
							goto IL_8E0;
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
													break;
													}
						IL_900:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_8E0:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro Escrita Setpoints - não determinado", 1);
							this.Calcula_Estatistica_820_300(3);
													}
						this.Calcula_Estatistica_820_300(2);
											}
					IL_912:
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
							goto IL_A6F;
													}
						case 1:
							goto IL_A3D;
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
													break;
													}
						IL_A5D:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_A3D:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro ao executar o camando - não determinado", 1);
							this.Calcula_Estatistica_820_300(3);
													}
						this.Calcula_Estatistica_820_300(2);
											}
					IL_A6F:
					MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
					break;
				}
				IL_A88:
				if (Mod_MD.Monitoracao_MD_RQ.Partir_mon)
				{
					this.Timer_monitoracao.Enabled = true;
				}
			}
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0031A778 File Offset: 0x00318B78
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

		// Token: 0x060011DC RID: 4572 RVA: 0x0031A7DC File Offset: 0x00318BDC
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

		// Token: 0x060011DD RID: 4573 RVA: 0x0031A91C File Offset: 0x00318D1C
		public void Atualiza_setpoint_monitoracao_202()
		{
			string versao = Geral.Config_geral.Versao;
			checked
			{
				if (Operators.CompareString(versao, "820_10", false) == 0)
				{
					this.Valor_NivelDesejado.Text = ((int)((Comunicacao.Buffer_resp[4] - 48) * 200 + (Comunicacao.Buffer_resp[5] - 48))).ToString();
					this.Valor_NivelB1.Text = ((int)((Comunicacao.Buffer_resp[6] - 48) * 200 + (Comunicacao.Buffer_resp[7] - 48))).ToString();
					this.Valor_NivelB2.Text = ((int)((Comunicacao.Buffer_resp[8] - 48) * 200 + (Comunicacao.Buffer_resp[9] - 48))).ToString();
					this.Valor_NivelB3.Text = ((int)((Comunicacao.Buffer_resp[10] - 48) * 200 + (Comunicacao.Buffer_resp[11] - 48))).ToString();
					this.Valor_NivelB4.Text = ((int)((Comunicacao.Buffer_resp[12] - 48) * 200 + (Comunicacao.Buffer_resp[13] - 48))).ToString();
					this.Valor_TempoMaisUmaBomba.Text = ((int)((Comunicacao.Buffer_resp[14] - 48) * 200 + (Comunicacao.Buffer_resp[15] - 48))).ToString();
					this.Valor_PressaoRec.Text = ((int)((Comunicacao.Buffer_resp[16] - 48) * 200 + (Comunicacao.Buffer_resp[17] - 48))).ToString();
					this.Valor_PressaoSuc.Text = ((int)((Comunicacao.Buffer_resp[18] - 48) * 200 + (Comunicacao.Buffer_resp[19] - 48))).ToString();
					this.Valor_Niveldesliga.Text = ((int)((Comunicacao.Buffer_resp[20] - 48) * 200 + (Comunicacao.Buffer_resp[21] - 48))).ToString();
					this.Valor_NivelLiga.Text = ((int)((Comunicacao.Buffer_resp[22] - 48) * 200 + (Comunicacao.Buffer_resp[23] - 48))).ToString();
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

		// Token: 0x060011DE RID: 4574 RVA: 0x0031AC94 File Offset: 0x00319094
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

		// Token: 0x060011DF RID: 4575 RVA: 0x0031AD68 File Offset: 0x00319168
		public void Atualiza_status_monitoracao_820_300()
		{
			int tipo = 3;
			this.Atualiza_tela_medidas_analogicas(ref Comunicacao.Buffer_resp, tipo);
			this.Atualiza_tela_alarmes(ref Comunicacao.Buffer_resp);
			this.Atualiza_tela_controles(ref Comunicacao.Buffer_resp);
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x0031ADA0 File Offset: 0x003191A0
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
						array[num] = (int)((dados[7 + num * 2] - 48) * 200);
						array[num] += (int)(dados[7 + num * 2 + 1] - 48);
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

		// Token: 0x060011E1 RID: 4577 RVA: 0x0031AF88 File Offset: 0x00319388
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
				num += (int)(dados[5] - 48);
				this.cb_ED1.Checked = Convert.ToBoolean(num & 1);
				this.cb_ED2.Checked = Convert.ToBoolean(num & 2);
				this.cb_ED3.Checked = Convert.ToBoolean(num & 4);
				this.cb_ED4.Checked = Convert.ToBoolean(num & 8);
				this.cb_ED5.Checked = Convert.ToBoolean(num & 16);
				this.cb_ED6.Checked = Convert.ToBoolean(num & 32);
				this.cb_ED7.Checked = Convert.ToBoolean(num & 64);
				this.cb_ED8.Checked = Convert.ToBoolean(num & 128);
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
				flag = Convert.ToBoolean(num2 & 8);
				if (flag)
				{
					this.pb_bit3.Image = porta_aberta;
				}
				else
				{
					this.pb_bit3.Image = porta_fechada_greyed;
				}
				this.pb_bit3.Refresh();
				flag = Convert.ToBoolean(num2 & 16);
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

		// Token: 0x060011E2 RID: 4578 RVA: 0x0031B1EC File Offset: 0x003195EC
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
					byte b = (byte)(dados[17 + num] - 48);
					bool flag = Convert.ToBoolean((int)(b & 64));
					bool flag2 = Convert.ToBoolean((int)(b & 32));
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
				while (num <= 2);
			}
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0031B6E0 File Offset: 0x00319AE0
		public Equip_821_mon.HAB_CTRL Controles_bombas(int modo_placa, int status_bomba)
		{
			int num = status_bomba & 15;
			int num2 = checked((int)Math.Round((double)(status_bomba & 32) / 32.0));
			Equip_821_mon.HAB_CTRL result;
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

		// Token: 0x060011E4 RID: 4580 RVA: 0x0031B84C File Offset: 0x00319C4C
		private void Tela_endereco_mestre_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Mestre = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Inicializa_tela_equipamento_MD202_mon();
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x0031B878 File Offset: 0x00319C78
		public void Inicializa_tela_equipamento_MD202_mon()
		{
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Iniciar", false) != 0)
			{
				this.Mensagem_MD202_mon(" Aguarde ... ", 2);
				Mod_MD.Monitoracao_MD_RQ.Controle_mon = 1;
			}
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x0031B8AC File Offset: 0x00319CAC
		private void Tela_endereco_estacao_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Estacao = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Inicializa_tela_equipamento_MD202_mon();
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0031B8D8 File Offset: 0x00319CD8
		private void Button_limpa_estatistica_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Num_Rx = 0L;
			Mod_MD.Monitoracao_MD_RQ.Num_Tx = 0L;
			Mod_MD.Monitoracao_MD_RQ.Eficiencia_com = 0;
			Mod_MD.Monitoracao_MD_RQ.Num_Retry = 0L;
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x0031B90C File Offset: 0x00319D0C
		private void Comando_le_setpoint_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 1;
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x0031B91C File Offset: 0x00319D1C
		private void Comando_escreve_setpoint_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 3;
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x0031B92C File Offset: 0x00319D2C
		private void Cmd_liga_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x0031B950 File Offset: 0x00319D50
		private void Cmd_desliga_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x0031B974 File Offset: 0x00319D74
		private void Cmd_manual_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x0031B998 File Offset: 0x00319D98
		private void Cmd_automatico_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x0031B9BC File Offset: 0x00319DBC
		private void Cmd_falha_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 71;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0031B9E0 File Offset: 0x00319DE0
		private void Cmd_liga_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0031BA04 File Offset: 0x00319E04
		private void Cmd_desliga_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x0031BA28 File Offset: 0x00319E28
		private void Cmd_manual_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x0031BA4C File Offset: 0x00319E4C
		private void Cmd_automatico_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x0031BA70 File Offset: 0x00319E70
		private void Cmd_falha_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 71;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x0031BA94 File Offset: 0x00319E94
		private void Cmd_liga_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0031BAB8 File Offset: 0x00319EB8
		private void Cmd_desliga_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x0031BADC File Offset: 0x00319EDC
		private void Cmd_manual_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0031BB00 File Offset: 0x00319F00
		private void Cmd_automatico_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0031BB24 File Offset: 0x00319F24
		private void Cmd_falha_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 71;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x0031BB48 File Offset: 0x00319F48
		private void Cmd_liga_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0031BB6C File Offset: 0x00319F6C
		private void Cmd_desliga_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0031BB90 File Offset: 0x00319F90
		private void Cmd_manual_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0031BBB4 File Offset: 0x00319FB4
		private void Cmd_automatico_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0031BBD8 File Offset: 0x00319FD8
		private void Cmd_falha_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 71;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0031BBFC File Offset: 0x00319FFC
		private void Tela_nivel_origem_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Nivel_origem = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0031BC24 File Offset: 0x0031A024
		private void Tela_nivel_destino_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Nivel_dest = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0031BC4C File Offset: 0x0031A04C
		private void Equip_820_mon_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Parar", false) == 0)
			{
				Interaction.MsgBox("Anter de fechar a tela é necessário parar a monitoração!", (MsgBoxStyle)0, null);
				return;
			}
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0031BC78 File Offset: 0x0031A078
		private void dgv_Controle_DoubleClick(object sender, EventArgs e)
		{
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0031BC7C File Offset: 0x0031A07C
		private void dgv_Controle_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			checked
			{
				switch (e.ColumnIndex)
				{
				case 1:
					Interaction.MsgBox("Nesta configuração é permitido apenas a visualização do estado do controle!", (MsgBoxStyle)0, null);
					break;
				case 2:
					if (!this.dgv_Controle.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly)
					{
						if (!this.ctlr[e.RowIndex].modo)
						{
							Interaction.MsgBox("AUTOMÁTICO -> MANUAL CONTROLE" + (e.RowIndex + 1).ToString(), (MsgBoxStyle)0, null);
							Mod_MD.Monitoracao_MD_RQ.Numero_motor = e.RowIndex + 1;
							Mod_MD.Monitoracao_MD_RQ.Comando = 69;
							Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
						}
						else
						{
							Interaction.MsgBox("MANUAL -> AUTOMÁTICO CONTROLE" + (e.RowIndex + 1).ToString(), (MsgBoxStyle)0, null);
							Mod_MD.Monitoracao_MD_RQ.Numero_motor = e.RowIndex + 1;
							Mod_MD.Monitoracao_MD_RQ.Comando = 70;
							Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
						}
					}
					else
					{
						Interaction.MsgBox("Nesta configuração é permitido apenas a visualização do estado do controle!", (MsgBoxStyle)0, null);
					}
					break;
				case 3:
					if (!this.dgv_Controle.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly)
					{
						if (!this.ctlr[e.RowIndex].ld)
						{
							Interaction.MsgBox("Comando de Ligar CONTROLE" + (e.RowIndex + 1).ToString(), (MsgBoxStyle)0, null);
							Mod_MD.Monitoracao_MD_RQ.Numero_motor = e.RowIndex + 1;
							Mod_MD.Monitoracao_MD_RQ.Comando = 67;
							Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
						}
						else
						{
							Interaction.MsgBox("Comando de Desligar CONTROLE" + (e.RowIndex + 1).ToString(), (MsgBoxStyle)0, null);
							Mod_MD.Monitoracao_MD_RQ.Numero_motor = e.RowIndex + 1;
							Mod_MD.Monitoracao_MD_RQ.Comando = 68;
							Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
						}
					}
					else
					{
						Interaction.MsgBox("Nesta configuração é permitido apenas a visualização do estado do controle!", (MsgBoxStyle)0, null);
					}
					break;
				}
			}
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0031BEA4 File Offset: 0x0031A2A4
		private void bt_end_default_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Iniciar", false) != 0)
			{
				Interaction.MsgBox("Monitoração em execução. Não é possivel trocar os endereços", (MsgBoxStyle)0, null);
			}
			else
			{
				this.Tela_endereco_mestre.Value = 100m;
				this.Tela_endereco_estacao.Value = 1m;
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0031BEFC File Offset: 0x0031A2FC
		private void pb_hab_monitoracao_Click(object sender, EventArgs e)
		{
			Bitmap start_button = Resources.start_button;
			Bitmap stop_button = Resources.stop_button;
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Iniciar", false) == 0)
			{
				Comunicacao.Ctrl_Com.Tipo_protocolo = 2;
				if (!Geral.Config_geral.Porta_serial_Ok)
				{
					Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
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
					this.Grupo_medidas.Enabled = false;
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

		// Token: 0x06001205 RID: 4613 RVA: 0x0031C0CC File Offset: 0x0031A4CC
		private void Comando_hab_monitoracao_Click(object sender, EventArgs e)
		{
			this.Grupo_medidas.Enabled = true;
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null), "Iniciar", false))
			{
				if (!Geral.Config_geral.Porta_serial_Ok)
				{
					Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
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

		// Token: 0x06001206 RID: 4614 RVA: 0x0031C294 File Offset: 0x0031A694
		private void dgv_Referencias_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0031C298 File Offset: 0x0031A698
		private void dgv_Referencias_KeyDown(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0031C29C File Offset: 0x0031A69C
		private void dgv_Referencias_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0031C2A0 File Offset: 0x0031A6A0
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

		// Token: 0x0600120A RID: 4618 RVA: 0x0031C34C File Offset: 0x0031A74C
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

		// Token: 0x04000985 RID: 2437
		[AccessedThroughProperty("Grupo_ctrl_com")]
		private GroupBox _Grupo_ctrl_com;

		// Token: 0x04000986 RID: 2438
		[AccessedThroughProperty("Tela_endereco_estacao")]
		private NumericUpDown _Tela_endereco_estacao;

		// Token: 0x04000987 RID: 2439
		[AccessedThroughProperty("Tela_endereco_mestre")]
		private NumericUpDown _Tela_endereco_mestre;

		// Token: 0x04000988 RID: 2440
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000989 RID: 2441
		[AccessedThroughProperty("msg")]
		private TextBox _msg;

		// Token: 0x0400098A RID: 2442
		[AccessedThroughProperty("Comando_hab_monitoracao")]
		private Button _Comando_hab_monitoracao;

		// Token: 0x0400098B RID: 2443
		[AccessedThroughProperty("Label_end_estacao")]
		private Label _Label_end_estacao;

		// Token: 0x0400098C RID: 2444
		[AccessedThroughProperty("Timer_monitoracao")]
		private Timer _Timer_monitoracao;

		// Token: 0x0400098D RID: 2445
		[AccessedThroughProperty("Grupo_setpoints")]
		private GroupBox _Grupo_setpoints;

		// Token: 0x0400098E RID: 2446
		[AccessedThroughProperty("Comando_escreve_setpoint")]
		private Button _Comando_escreve_setpoint;

		// Token: 0x0400098F RID: 2447
		[AccessedThroughProperty("Comando_le_setpoint")]
		private Button _Comando_le_setpoint;

		// Token: 0x04000990 RID: 2448
		[AccessedThroughProperty("Grupo_estatistica")]
		private GroupBox _Grupo_estatistica;

		// Token: 0x04000991 RID: 2449
		[AccessedThroughProperty("Label_Est_retry")]
		private Label _Label_Est_retry;

		// Token: 0x04000992 RID: 2450
		[AccessedThroughProperty("Est_retry")]
		private TextBox _Est_retry;

		// Token: 0x04000993 RID: 2451
		[AccessedThroughProperty("Est_eficiencia")]
		private TextBox _Est_eficiencia;

		// Token: 0x04000994 RID: 2452
		[AccessedThroughProperty("Button_limpa_estatistica")]
		private Button _Button_limpa_estatistica;

		// Token: 0x04000995 RID: 2453
		[AccessedThroughProperty("Label_Est_RX")]
		private Label _Label_Est_RX;

		// Token: 0x04000996 RID: 2454
		[AccessedThroughProperty("Label_Est_Eficiencia")]
		private Label _Label_Est_Eficiencia;

		// Token: 0x04000997 RID: 2455
		[AccessedThroughProperty("Label_Est_TX")]
		private Label _Label_Est_TX;

		// Token: 0x04000998 RID: 2456
		[AccessedThroughProperty("Est_Rx")]
		private TextBox _Est_Rx;

		// Token: 0x04000999 RID: 2457
		[AccessedThroughProperty("Est_TX")]
		private TextBox _Est_TX;

		// Token: 0x0400099A RID: 2458
		[AccessedThroughProperty("Grupo_status")]
		private GroupBox _Grupo_status;

		// Token: 0x0400099B RID: 2459
		[AccessedThroughProperty("Grupo_escrita_de_dados")]
		private GroupBox _Grupo_escrita_de_dados;

		// Token: 0x0400099C RID: 2460
		[AccessedThroughProperty("Tela_nivel_destino")]
		private NumericUpDown _Tela_nivel_destino;

		// Token: 0x0400099D RID: 2461
		[AccessedThroughProperty("Label_nivel_destino")]
		private Label _Label_nivel_destino;

		// Token: 0x0400099E RID: 2462
		[AccessedThroughProperty("Valor_NivelDesejado")]
		private TextBox _Valor_NivelDesejado;

		// Token: 0x0400099F RID: 2463
		[AccessedThroughProperty("Label_NivelDesejado")]
		private Label _Label_NivelDesejado;

		// Token: 0x040009A0 RID: 2464
		[AccessedThroughProperty("Valor_NivelB1")]
		private TextBox _Valor_NivelB1;

		// Token: 0x040009A1 RID: 2465
		[AccessedThroughProperty("Label_NivelB1")]
		private Label _Label_NivelB1;

		// Token: 0x040009A2 RID: 2466
		[AccessedThroughProperty("Valor_PressaoRec")]
		private TextBox _Valor_PressaoRec;

		// Token: 0x040009A3 RID: 2467
		[AccessedThroughProperty("Label_PressaoRec")]
		private Label _Label_PressaoRec;

		// Token: 0x040009A4 RID: 2468
		[AccessedThroughProperty("Valor_TempoMaisUmaBomba")]
		private TextBox _Valor_TempoMaisUmaBomba;

		// Token: 0x040009A5 RID: 2469
		[AccessedThroughProperty("Label_TempoMaisUmaBomba")]
		private Label _Label_TempoMaisUmaBomba;

		// Token: 0x040009A6 RID: 2470
		[AccessedThroughProperty("Valor_NivelB4")]
		private TextBox _Valor_NivelB4;

		// Token: 0x040009A7 RID: 2471
		[AccessedThroughProperty("Label_NivelB4")]
		private Label _Label_NivelB4;

		// Token: 0x040009A8 RID: 2472
		[AccessedThroughProperty("Valor_NivelB3")]
		private TextBox _Valor_NivelB3;

		// Token: 0x040009A9 RID: 2473
		[AccessedThroughProperty("Label_NivelB3")]
		private Label _Label_NivelB3;

		// Token: 0x040009AA RID: 2474
		[AccessedThroughProperty("Valor_NivelB2")]
		private TextBox _Valor_NivelB2;

		// Token: 0x040009AB RID: 2475
		[AccessedThroughProperty("Label_NivelB2")]
		private Label _Label_NivelB2;

		// Token: 0x040009AC RID: 2476
		[AccessedThroughProperty("Valor_Niveldesliga")]
		private TextBox _Valor_Niveldesliga;

		// Token: 0x040009AD RID: 2477
		[AccessedThroughProperty("Label_NivelDesliga")]
		private Label _Label_NivelDesliga;

		// Token: 0x040009AE RID: 2478
		[AccessedThroughProperty("Valor_NivelLiga")]
		private TextBox _Valor_NivelLiga;

		// Token: 0x040009AF RID: 2479
		[AccessedThroughProperty("Label_NivelLiga")]
		private Label _Label_NivelLiga;

		// Token: 0x040009B0 RID: 2480
		[AccessedThroughProperty("Valor_PressaoSuc")]
		private TextBox _Valor_PressaoSuc;

		// Token: 0x040009B1 RID: 2481
		[AccessedThroughProperty("Label_PressaoSuc")]
		private Label _Label_PressaoSuc;

		// Token: 0x040009B2 RID: 2482
		[AccessedThroughProperty("Grupo_medidas")]
		private GroupBox _Grupo_medidas;

		// Token: 0x040009B3 RID: 2483
		[AccessedThroughProperty("Tela_nivel_origem")]
		private NumericUpDown _Tela_nivel_origem;

		// Token: 0x040009B4 RID: 2484
		[AccessedThroughProperty("Label_nivel_origem")]
		private Label _Label_nivel_origem;

		// Token: 0x040009B5 RID: 2485
		[AccessedThroughProperty("Cmd_falha_b2")]
		private Button _Cmd_falha_b2;

		// Token: 0x040009B6 RID: 2486
		[AccessedThroughProperty("msg_modo_operacaoZ")]
		private TextBox _msg_modo_operacaoZ;

		// Token: 0x040009B7 RID: 2487
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x040009B8 RID: 2488
		[AccessedThroughProperty("dgv_Referencias")]
		private DataGridView _dgv_Referencias;

		// Token: 0x040009B9 RID: 2489
		[AccessedThroughProperty("Ref")]
		private DataGridViewTextBoxColumn _Ref;

		// Token: 0x040009BA RID: 2490
		[AccessedThroughProperty("dgv_EA")]
		private DataGridView _dgv_EA;

		// Token: 0x040009BB RID: 2491
		[AccessedThroughProperty("dgv_Controle")]
		private DataGridView _dgv_Controle;

		// Token: 0x040009BC RID: 2492
		[AccessedThroughProperty("Estado")]
		private DataGridViewTextBoxColumn _Estado;

		// Token: 0x040009BD RID: 2493
		[AccessedThroughProperty("Quadro")]
		private DataGridViewImageColumn _Quadro;

		// Token: 0x040009BE RID: 2494
		[AccessedThroughProperty("Controle")]
		private DataGridViewImageColumn _Controle;

		// Token: 0x040009BF RID: 2495
		[AccessedThroughProperty("LD")]
		private DataGridViewImageColumn _LD;

		// Token: 0x040009C0 RID: 2496
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040009C1 RID: 2497
		[AccessedThroughProperty("bt_end_default")]
		private Button _bt_end_default;

		// Token: 0x040009C2 RID: 2498
		[AccessedThroughProperty("pb_hab_monitoracao")]
		private PictureBox _pb_hab_monitoracao;

		// Token: 0x040009C3 RID: 2499
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040009C4 RID: 2500
		[AccessedThroughProperty("Contagens")]
		private DataGridViewTextBoxColumn _Contagens;

		// Token: 0x040009C5 RID: 2501
		[AccessedThroughProperty("Conv")]
		private DataGridViewCheckBoxColumn _Conv;

		// Token: 0x040009C6 RID: 2502
		[AccessedThroughProperty("Inicio")]
		private DataGridViewTextBoxColumn _Inicio;

		// Token: 0x040009C7 RID: 2503
		[AccessedThroughProperty("Fim")]
		private DataGridViewTextBoxColumn _Fim;

		// Token: 0x040009C8 RID: 2504
		[AccessedThroughProperty("Medida")]
		private DataGridViewTextBoxColumn _Medida;

		// Token: 0x040009C9 RID: 2505
		[AccessedThroughProperty("pb_bit0")]
		private PictureBox _pb_bit0;

		// Token: 0x040009CA RID: 2506
		[AccessedThroughProperty("pb_bit3")]
		private PictureBox _pb_bit3;

		// Token: 0x040009CB RID: 2507
		[AccessedThroughProperty("pb_bit1")]
		private PictureBox _pb_bit1;

		// Token: 0x040009CC RID: 2508
		[AccessedThroughProperty("pb_bit2")]
		private PictureBox _pb_bit2;

		// Token: 0x040009CD RID: 2509
		[AccessedThroughProperty("pb_bit4")]
		private PictureBox _pb_bit4;

		// Token: 0x040009CE RID: 2510
		[AccessedThroughProperty("pb_bit5")]
		private PictureBox _pb_bit5;

		// Token: 0x040009CF RID: 2511
		[AccessedThroughProperty("GroupBox_Alarmes")]
		private GroupBox _GroupBox_Alarmes;

		// Token: 0x040009D0 RID: 2512
		[AccessedThroughProperty("GroupBox_ED")]
		private GroupBox _GroupBox_ED;

		// Token: 0x040009D1 RID: 2513
		[AccessedThroughProperty("cb_ED1")]
		private CheckBox _cb_ED1;

		// Token: 0x040009D2 RID: 2514
		[AccessedThroughProperty("cb_ED8")]
		private CheckBox _cb_ED8;

		// Token: 0x040009D3 RID: 2515
		[AccessedThroughProperty("cb_ED7")]
		private CheckBox _cb_ED7;

		// Token: 0x040009D4 RID: 2516
		[AccessedThroughProperty("cb_ED6")]
		private CheckBox _cb_ED6;

		// Token: 0x040009D5 RID: 2517
		[AccessedThroughProperty("cb_ED5")]
		private CheckBox _cb_ED5;

		// Token: 0x040009D6 RID: 2518
		[AccessedThroughProperty("cb_ED4")]
		private CheckBox _cb_ED4;

		// Token: 0x040009D7 RID: 2519
		[AccessedThroughProperty("cb_ED3")]
		private CheckBox _cb_ED3;

		// Token: 0x040009D8 RID: 2520
		[AccessedThroughProperty("cb_ED2")]
		private CheckBox _cb_ED2;

		// Token: 0x040009D9 RID: 2521
		public const int DADOS_FORMATO_200 = 1;

		// Token: 0x040009DA RID: 2522
		public const int DADOS_FORMATO_200_4000 = 2;

		// Token: 0x040009DB RID: 2523
		public const int DADOS_FORMATO_4000 = 3;

		// Token: 0x040009DC RID: 2524
		public const int OFFSET_END = 3;

		// Token: 0x040009DD RID: 2525
		public const int OFFSET_ED = 4;

		// Token: 0x040009DE RID: 2526
		public const int OFFSET_EA = 7;

		// Token: 0x040009DF RID: 2527
		public const int OFFSET_ALARMES = 15;

		// Token: 0x040009E0 RID: 2528
		public const int OFFSET_CONTROLE = 17;

		// Token: 0x040009E1 RID: 2529
		public const int MASCARA_ALM_OPERANDO_BAT_820_300 = 1;

		// Token: 0x040009E2 RID: 2530
		public const int MASCARA_ALM_TRANSBORDE_820_300 = 2;

		// Token: 0x040009E3 RID: 2531
		public const int MASCARA_ALM_FALTAFASE_820_300 = 4;

		// Token: 0x040009E4 RID: 2532
		public const int MASCARA_ALM_ARROMBAMENTO_820_300 = 8;

		// Token: 0x040009E5 RID: 2533
		public const int MASCARA_ALM_ALAGAMENTO_820_300 = 16;

		// Token: 0x040009E6 RID: 2534
		public const int MASCARA_ALM_HORARIOPONTA_820_300 = 32;

		// Token: 0x040009E7 RID: 2535
		public const int MASCARA_CONTROLE_REMOTO_LOCAL = 64;

		// Token: 0x040009E8 RID: 2536
		public const int MASCARA_CONTROLE_AUTO_MANUAL = 32;

		// Token: 0x040009E9 RID: 2537
		public const int MASCARA_CONTROLE_ESTADO = 15;

		// Token: 0x040009EA RID: 2538
		public string[] Msg_status_202;

		// Token: 0x040009EB RID: 2539
		public string[] Msg_modo_bomba_202;

		// Token: 0x040009EC RID: 2540
		public string[] Msg_modo_placa_202;

		// Token: 0x040009ED RID: 2541
		public string[] Msg_Estado_820_300;

		// Token: 0x040009EE RID: 2542
		public string[] Msg_Controle_820_300;

		// Token: 0x040009EF RID: 2543
		public string[] Msg_Quadro_820_300;

		// Token: 0x040009F0 RID: 2544
		public RT_geral.DADOS_DATAGRIDVIEW_RT_820[] Mon_820_DGVReferenciaColunas;

		// Token: 0x040009F1 RID: 2545
		private RT_geral.Integer_ictel[] ValorReferencia;

		// Token: 0x040009F2 RID: 2546
		public const int COLUNA_REFERENCIA = 0;

		// Token: 0x040009F3 RID: 2547
		public const int COLUNA_CONTAGENS = 0;

		// Token: 0x040009F4 RID: 2548
		public const int COLUNA_CONVERTE = 1;

		// Token: 0x040009F5 RID: 2549
		public const int COLUNA_INICIO = 2;

		// Token: 0x040009F6 RID: 2550
		public const int COLUNA_FIM = 3;

		// Token: 0x040009F7 RID: 2551
		public const int COLUNA_MEDIDA = 4;

		// Token: 0x040009F8 RID: 2552
		public const int COLUNA_ESTADO = 0;

		// Token: 0x040009F9 RID: 2553
		public const int COLUNA_CONTROLE = 2;

		// Token: 0x040009FA RID: 2554
		public const int COLUNA_QUADRO = 1;

		// Token: 0x040009FB RID: 2555
		public const int COLUNA_LD = 3;

		// Token: 0x040009FC RID: 2556
		public const int NUMERO_REFERENCIAS = 4;

		// Token: 0x040009FD RID: 2557
		public const int NUMERO_ENTRADAS_ANALOGICAS = 4;

		// Token: 0x040009FE RID: 2558
		public const int NUMERO_CONTROLES = 3;

		// Token: 0x040009FF RID: 2559
		private Equip_821_mon.ST_CONTROLE[] ctlr;

		// Token: 0x04000A00 RID: 2560
		private bool isValidForNumber;

		// Token: 0x02000048 RID: 72
		public struct HAB_CTRL
		{
			// Token: 0x04000A01 RID: 2561
			public bool Tecla_auto;

			// Token: 0x04000A02 RID: 2562
			public bool Tecla_man;

			// Token: 0x04000A03 RID: 2563
			public bool Tecla_liga;

			// Token: 0x04000A04 RID: 2564
			public bool Tecla_desliga;

			// Token: 0x04000A05 RID: 2565
			public bool Tecla_falha;

			// Token: 0x04000A06 RID: 2566
			public string status;

			// Token: 0x04000A07 RID: 2567
			public string modo_motor;

			// Token: 0x04000A08 RID: 2568
			public string modo_placa;
		}

		// Token: 0x02000049 RID: 73
		public struct ST_CONTROLE
		{
			// Token: 0x04000A09 RID: 2569
			public bool modo;

			// Token: 0x04000A0A RID: 2570
			public bool ld;
		}
	}
}
