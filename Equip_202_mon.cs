using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iS800.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x02000085 RID: 133
	[DesignerGenerated]
	public partial class Equip_202_mon : Form
	{
		// Token: 0x06002072 RID: 8306 RVA: 0x003EDE44 File Offset: 0x003EC244
		public Equip_202_mon()
		{
			base.FormClosed += new FormClosedEventHandler(this.Equip_202_mon_FormClosed);
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
			this.InitializeComponent();
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x003F2A74 File Offset: 0x003F0E74
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x003F2A88 File Offset: 0x003F0E88
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

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x003F2A94 File Offset: 0x003F0E94
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x003F2AA8 File Offset: 0x003F0EA8
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

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x003F2AF4 File Offset: 0x003F0EF4
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x003F2B08 File Offset: 0x003F0F08
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

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x003F2B54 File Offset: 0x003F0F54
		// (set) Token: 0x0600207C RID: 8316 RVA: 0x003F2B68 File Offset: 0x003F0F68
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

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x003F2B74 File Offset: 0x003F0F74
		// (set) Token: 0x0600207E RID: 8318 RVA: 0x003F2B88 File Offset: 0x003F0F88
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

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x003F2B94 File Offset: 0x003F0F94
		// (set) Token: 0x06002080 RID: 8320 RVA: 0x003F2BA8 File Offset: 0x003F0FA8
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

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x003F2BF4 File Offset: 0x003F0FF4
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x003F2C08 File Offset: 0x003F1008
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

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x003F2C14 File Offset: 0x003F1014
		// (set) Token: 0x06002084 RID: 8324 RVA: 0x003F2C28 File Offset: 0x003F1028
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

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x003F2C74 File Offset: 0x003F1074
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x003F2C88 File Offset: 0x003F1088
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

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x003F2C94 File Offset: 0x003F1094
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x003F2CA8 File Offset: 0x003F10A8
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

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x003F2CF4 File Offset: 0x003F10F4
		// (set) Token: 0x0600208A RID: 8330 RVA: 0x003F2D08 File Offset: 0x003F1108
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

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x003F2D54 File Offset: 0x003F1154
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x003F2D68 File Offset: 0x003F1168
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

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x003F2D74 File Offset: 0x003F1174
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x003F2D88 File Offset: 0x003F1188
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

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x003F2D94 File Offset: 0x003F1194
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x003F2DA8 File Offset: 0x003F11A8
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

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x003F2DB4 File Offset: 0x003F11B4
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x003F2DC8 File Offset: 0x003F11C8
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

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x003F2DD4 File Offset: 0x003F11D4
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x003F2DE8 File Offset: 0x003F11E8
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

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x003F2E34 File Offset: 0x003F1234
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x003F2E48 File Offset: 0x003F1248
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

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x003F2E54 File Offset: 0x003F1254
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x003F2E68 File Offset: 0x003F1268
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

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x003F2E74 File Offset: 0x003F1274
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x003F2E88 File Offset: 0x003F1288
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

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x003F2E94 File Offset: 0x003F1294
		// (set) Token: 0x0600209C RID: 8348 RVA: 0x003F2EA8 File Offset: 0x003F12A8
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

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x003F2EB4 File Offset: 0x003F12B4
		// (set) Token: 0x0600209E RID: 8350 RVA: 0x003F2EC8 File Offset: 0x003F12C8
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

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x003F2ED4 File Offset: 0x003F12D4
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x003F2EE8 File Offset: 0x003F12E8
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

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x003F2EF4 File Offset: 0x003F12F4
		// (set) Token: 0x060020A2 RID: 8354 RVA: 0x003F2F08 File Offset: 0x003F1308
		internal virtual GroupBox Grupo_bomba3
		{
			get
			{
				return this._Grupo_bomba3;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_bomba3 = value;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x003F2F14 File Offset: 0x003F1314
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x003F2F28 File Offset: 0x003F1328
		internal virtual TextBox Modo_b3
		{
			get
			{
				return this._Modo_b3;
			}
			[MethodImpl(32)]
			set
			{
				this._Modo_b3 = value;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x003F2F34 File Offset: 0x003F1334
		// (set) Token: 0x060020A6 RID: 8358 RVA: 0x003F2F48 File Offset: 0x003F1348
		internal virtual Label Label_modo_b3
		{
			get
			{
				return this._Label_modo_b3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_modo_b3 = value;
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x003F2F54 File Offset: 0x003F1354
		// (set) Token: 0x060020A8 RID: 8360 RVA: 0x003F2F68 File Offset: 0x003F1368
		internal virtual Button Cmd_manual_b3
		{
			get
			{
				return this._Cmd_manual_b3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_manual_b3_Click);
				if (this._Cmd_manual_b3 != null)
				{
					this._Cmd_manual_b3.Click -= eventHandler;
				}
				this._Cmd_manual_b3 = value;
				if (this._Cmd_manual_b3 != null)
				{
					this._Cmd_manual_b3.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x003F2FB4 File Offset: 0x003F13B4
		// (set) Token: 0x060020AA RID: 8362 RVA: 0x003F2FC8 File Offset: 0x003F13C8
		internal virtual Button Cmd_desliga_b3
		{
			get
			{
				return this._Cmd_desliga_b3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_desliga_b3_Click);
				if (this._Cmd_desliga_b3 != null)
				{
					this._Cmd_desliga_b3.Click -= eventHandler;
				}
				this._Cmd_desliga_b3 = value;
				if (this._Cmd_desliga_b3 != null)
				{
					this._Cmd_desliga_b3.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x003F3014 File Offset: 0x003F1414
		// (set) Token: 0x060020AC RID: 8364 RVA: 0x003F3028 File Offset: 0x003F1428
		internal virtual Button Cmd_liga_b3
		{
			get
			{
				return this._Cmd_liga_b3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_liga_b3_Click);
				if (this._Cmd_liga_b3 != null)
				{
					this._Cmd_liga_b3.Click -= eventHandler;
				}
				this._Cmd_liga_b3 = value;
				if (this._Cmd_liga_b3 != null)
				{
					this._Cmd_liga_b3.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x003F3074 File Offset: 0x003F1474
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x003F3088 File Offset: 0x003F1488
		internal virtual Label Label_status_b3
		{
			get
			{
				return this._Label_status_b3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_status_b3 = value;
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x060020AF RID: 8367 RVA: 0x003F3094 File Offset: 0x003F1494
		// (set) Token: 0x060020B0 RID: 8368 RVA: 0x003F30A8 File Offset: 0x003F14A8
		internal virtual Button Cmd_automatico_b3
		{
			get
			{
				return this._Cmd_automatico_b3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_automatico_b3_Click);
				if (this._Cmd_automatico_b3 != null)
				{
					this._Cmd_automatico_b3.Click -= eventHandler;
				}
				this._Cmd_automatico_b3 = value;
				if (this._Cmd_automatico_b3 != null)
				{
					this._Cmd_automatico_b3.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x003F30F4 File Offset: 0x003F14F4
		// (set) Token: 0x060020B2 RID: 8370 RVA: 0x003F3108 File Offset: 0x003F1508
		internal virtual TextBox Status_b3
		{
			get
			{
				return this._Status_b3;
			}
			[MethodImpl(32)]
			set
			{
				this._Status_b3 = value;
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x003F3114 File Offset: 0x003F1514
		// (set) Token: 0x060020B4 RID: 8372 RVA: 0x003F3128 File Offset: 0x003F1528
		internal virtual GroupBox Grupo_bomba2
		{
			get
			{
				return this._Grupo_bomba2;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_bomba2 = value;
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x003F3134 File Offset: 0x003F1534
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x003F3148 File Offset: 0x003F1548
		internal virtual TextBox Modo_b2
		{
			get
			{
				return this._Modo_b2;
			}
			[MethodImpl(32)]
			set
			{
				this._Modo_b2 = value;
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x003F3154 File Offset: 0x003F1554
		// (set) Token: 0x060020B8 RID: 8376 RVA: 0x003F3168 File Offset: 0x003F1568
		internal virtual Label Label_modo_b2
		{
			get
			{
				return this._Label_modo_b2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_modo_b2 = value;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x003F3174 File Offset: 0x003F1574
		// (set) Token: 0x060020BA RID: 8378 RVA: 0x003F3188 File Offset: 0x003F1588
		internal virtual Button Cmd_manual_b2
		{
			get
			{
				return this._Cmd_manual_b2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_manual_b2_Click);
				if (this._Cmd_manual_b2 != null)
				{
					this._Cmd_manual_b2.Click -= eventHandler;
				}
				this._Cmd_manual_b2 = value;
				if (this._Cmd_manual_b2 != null)
				{
					this._Cmd_manual_b2.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x003F31D4 File Offset: 0x003F15D4
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x003F31E8 File Offset: 0x003F15E8
		internal virtual Button Cmd_desliga_b2
		{
			get
			{
				return this._Cmd_desliga_b2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_desliga_b2_Click);
				if (this._Cmd_desliga_b2 != null)
				{
					this._Cmd_desliga_b2.Click -= eventHandler;
				}
				this._Cmd_desliga_b2 = value;
				if (this._Cmd_desliga_b2 != null)
				{
					this._Cmd_desliga_b2.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x003F3234 File Offset: 0x003F1634
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x003F3248 File Offset: 0x003F1648
		internal virtual Button Cmd_liga_b2
		{
			get
			{
				return this._Cmd_liga_b2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_liga_b2_Click);
				if (this._Cmd_liga_b2 != null)
				{
					this._Cmd_liga_b2.Click -= eventHandler;
				}
				this._Cmd_liga_b2 = value;
				if (this._Cmd_liga_b2 != null)
				{
					this._Cmd_liga_b2.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x003F3294 File Offset: 0x003F1694
		// (set) Token: 0x060020C0 RID: 8384 RVA: 0x003F32A8 File Offset: 0x003F16A8
		internal virtual Button Cmd_automatico_b2
		{
			get
			{
				return this._Cmd_automatico_b2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_automatico_b2_Click);
				if (this._Cmd_automatico_b2 != null)
				{
					this._Cmd_automatico_b2.Click -= eventHandler;
				}
				this._Cmd_automatico_b2 = value;
				if (this._Cmd_automatico_b2 != null)
				{
					this._Cmd_automatico_b2.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x003F32F4 File Offset: 0x003F16F4
		// (set) Token: 0x060020C2 RID: 8386 RVA: 0x003F3308 File Offset: 0x003F1708
		internal virtual Label Label_status_b2
		{
			get
			{
				return this._Label_status_b2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_status_b2 = value;
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x003F3314 File Offset: 0x003F1714
		// (set) Token: 0x060020C4 RID: 8388 RVA: 0x003F3328 File Offset: 0x003F1728
		internal virtual TextBox Status_b2
		{
			get
			{
				return this._Status_b2;
			}
			[MethodImpl(32)]
			set
			{
				this._Status_b2 = value;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x003F3334 File Offset: 0x003F1734
		// (set) Token: 0x060020C6 RID: 8390 RVA: 0x003F3348 File Offset: 0x003F1748
		internal virtual GroupBox Grupo_bomba1
		{
			get
			{
				return this._Grupo_bomba1;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_bomba1 = value;
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x003F3354 File Offset: 0x003F1754
		// (set) Token: 0x060020C8 RID: 8392 RVA: 0x003F3368 File Offset: 0x003F1768
		internal virtual TextBox Modo_b1
		{
			get
			{
				return this._Modo_b1;
			}
			[MethodImpl(32)]
			set
			{
				this._Modo_b1 = value;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x003F3374 File Offset: 0x003F1774
		// (set) Token: 0x060020CA RID: 8394 RVA: 0x003F3388 File Offset: 0x003F1788
		internal virtual Button Cmd_manual_b1
		{
			get
			{
				return this._Cmd_manual_b1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_manual_b1_Click);
				if (this._Cmd_manual_b1 != null)
				{
					this._Cmd_manual_b1.Click -= eventHandler;
				}
				this._Cmd_manual_b1 = value;
				if (this._Cmd_manual_b1 != null)
				{
					this._Cmd_manual_b1.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x003F33D4 File Offset: 0x003F17D4
		// (set) Token: 0x060020CC RID: 8396 RVA: 0x003F33E8 File Offset: 0x003F17E8
		internal virtual Button Cmd_desliga_b1
		{
			get
			{
				return this._Cmd_desliga_b1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_desliga_b1_Click);
				if (this._Cmd_desliga_b1 != null)
				{
					this._Cmd_desliga_b1.Click -= eventHandler;
				}
				this._Cmd_desliga_b1 = value;
				if (this._Cmd_desliga_b1 != null)
				{
					this._Cmd_desliga_b1.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x003F3434 File Offset: 0x003F1834
		// (set) Token: 0x060020CE RID: 8398 RVA: 0x003F3448 File Offset: 0x003F1848
		internal virtual Button Cmd_automatico_b1
		{
			get
			{
				return this._Cmd_automatico_b1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_automatico_b1_Click);
				if (this._Cmd_automatico_b1 != null)
				{
					this._Cmd_automatico_b1.Click -= eventHandler;
				}
				this._Cmd_automatico_b1 = value;
				if (this._Cmd_automatico_b1 != null)
				{
					this._Cmd_automatico_b1.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x003F3494 File Offset: 0x003F1894
		// (set) Token: 0x060020D0 RID: 8400 RVA: 0x003F34A8 File Offset: 0x003F18A8
		internal virtual Button Cmd_liga_b1
		{
			get
			{
				return this._Cmd_liga_b1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_liga_b1_Click);
				if (this._Cmd_liga_b1 != null)
				{
					this._Cmd_liga_b1.Click -= eventHandler;
				}
				this._Cmd_liga_b1 = value;
				if (this._Cmd_liga_b1 != null)
				{
					this._Cmd_liga_b1.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x003F34F4 File Offset: 0x003F18F4
		// (set) Token: 0x060020D2 RID: 8402 RVA: 0x003F3508 File Offset: 0x003F1908
		internal virtual Label Label_modo_b1
		{
			get
			{
				return this._Label_modo_b1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_modo_b1 = value;
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x060020D3 RID: 8403 RVA: 0x003F3514 File Offset: 0x003F1914
		// (set) Token: 0x060020D4 RID: 8404 RVA: 0x003F3528 File Offset: 0x003F1928
		internal virtual Label Label_status_b1
		{
			get
			{
				return this._Label_status_b1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_status_b1 = value;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x060020D5 RID: 8405 RVA: 0x003F3534 File Offset: 0x003F1934
		// (set) Token: 0x060020D6 RID: 8406 RVA: 0x003F3548 File Offset: 0x003F1948
		internal virtual TextBox Status_b1
		{
			get
			{
				return this._Status_b1;
			}
			[MethodImpl(32)]
			set
			{
				this._Status_b1 = value;
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x003F3554 File Offset: 0x003F1954
		// (set) Token: 0x060020D8 RID: 8408 RVA: 0x003F3568 File Offset: 0x003F1968
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

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x060020D9 RID: 8409 RVA: 0x003F3574 File Offset: 0x003F1974
		// (set) Token: 0x060020DA RID: 8410 RVA: 0x003F3588 File Offset: 0x003F1988
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

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x060020DB RID: 8411 RVA: 0x003F35D4 File Offset: 0x003F19D4
		// (set) Token: 0x060020DC RID: 8412 RVA: 0x003F35E8 File Offset: 0x003F19E8
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

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x060020DD RID: 8413 RVA: 0x003F35F4 File Offset: 0x003F19F4
		// (set) Token: 0x060020DE RID: 8414 RVA: 0x003F3608 File Offset: 0x003F1A08
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

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x060020DF RID: 8415 RVA: 0x003F3614 File Offset: 0x003F1A14
		// (set) Token: 0x060020E0 RID: 8416 RVA: 0x003F3628 File Offset: 0x003F1A28
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

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x003F3634 File Offset: 0x003F1A34
		// (set) Token: 0x060020E2 RID: 8418 RVA: 0x003F3648 File Offset: 0x003F1A48
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

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x003F3654 File Offset: 0x003F1A54
		// (set) Token: 0x060020E4 RID: 8420 RVA: 0x003F3668 File Offset: 0x003F1A68
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

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x003F3674 File Offset: 0x003F1A74
		// (set) Token: 0x060020E6 RID: 8422 RVA: 0x003F3688 File Offset: 0x003F1A88
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

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x060020E7 RID: 8423 RVA: 0x003F3694 File Offset: 0x003F1A94
		// (set) Token: 0x060020E8 RID: 8424 RVA: 0x003F36A8 File Offset: 0x003F1AA8
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

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x003F36B4 File Offset: 0x003F1AB4
		// (set) Token: 0x060020EA RID: 8426 RVA: 0x003F36C8 File Offset: 0x003F1AC8
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

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x060020EB RID: 8427 RVA: 0x003F36D4 File Offset: 0x003F1AD4
		// (set) Token: 0x060020EC RID: 8428 RVA: 0x003F36E8 File Offset: 0x003F1AE8
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

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x060020ED RID: 8429 RVA: 0x003F36F4 File Offset: 0x003F1AF4
		// (set) Token: 0x060020EE RID: 8430 RVA: 0x003F3708 File Offset: 0x003F1B08
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

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x003F3714 File Offset: 0x003F1B14
		// (set) Token: 0x060020F0 RID: 8432 RVA: 0x003F3728 File Offset: 0x003F1B28
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

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x060020F1 RID: 8433 RVA: 0x003F3734 File Offset: 0x003F1B34
		// (set) Token: 0x060020F2 RID: 8434 RVA: 0x003F3748 File Offset: 0x003F1B48
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

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x060020F3 RID: 8435 RVA: 0x003F3754 File Offset: 0x003F1B54
		// (set) Token: 0x060020F4 RID: 8436 RVA: 0x003F3768 File Offset: 0x003F1B68
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

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x003F3774 File Offset: 0x003F1B74
		// (set) Token: 0x060020F6 RID: 8438 RVA: 0x003F3788 File Offset: 0x003F1B88
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

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x003F3794 File Offset: 0x003F1B94
		// (set) Token: 0x060020F8 RID: 8440 RVA: 0x003F37A8 File Offset: 0x003F1BA8
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

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x003F37B4 File Offset: 0x003F1BB4
		// (set) Token: 0x060020FA RID: 8442 RVA: 0x003F37C8 File Offset: 0x003F1BC8
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

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x003F37D4 File Offset: 0x003F1BD4
		// (set) Token: 0x060020FC RID: 8444 RVA: 0x003F37E8 File Offset: 0x003F1BE8
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

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x003F37F4 File Offset: 0x003F1BF4
		// (set) Token: 0x060020FE RID: 8446 RVA: 0x003F3808 File Offset: 0x003F1C08
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

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060020FF RID: 8447 RVA: 0x003F3814 File Offset: 0x003F1C14
		// (set) Token: 0x06002100 RID: 8448 RVA: 0x003F3828 File Offset: 0x003F1C28
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

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06002101 RID: 8449 RVA: 0x003F3834 File Offset: 0x003F1C34
		// (set) Token: 0x06002102 RID: 8450 RVA: 0x003F3848 File Offset: 0x003F1C48
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

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06002103 RID: 8451 RVA: 0x003F3854 File Offset: 0x003F1C54
		// (set) Token: 0x06002104 RID: 8452 RVA: 0x003F3868 File Offset: 0x003F1C68
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

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x003F3874 File Offset: 0x003F1C74
		// (set) Token: 0x06002106 RID: 8454 RVA: 0x003F3888 File Offset: 0x003F1C88
		internal virtual GroupBox Grupo_alarmes
		{
			get
			{
				return this._Grupo_alarmes;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_alarmes = value;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06002107 RID: 8455 RVA: 0x003F3894 File Offset: 0x003F1C94
		// (set) Token: 0x06002108 RID: 8456 RVA: 0x003F38A8 File Offset: 0x003F1CA8
		internal virtual CheckBox CheckBox_Alm_alagamento_status
		{
			get
			{
				return this._CheckBox_Alm_alagamento_status;
			}
			[MethodImpl(32)]
			set
			{
				this._CheckBox_Alm_alagamento_status = value;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x003F38B4 File Offset: 0x003F1CB4
		// (set) Token: 0x0600210A RID: 8458 RVA: 0x003F38C8 File Offset: 0x003F1CC8
		internal virtual CheckBox CheckBox_Alm_ope_bat_status
		{
			get
			{
				return this._CheckBox_Alm_ope_bat_status;
			}
			[MethodImpl(32)]
			set
			{
				this._CheckBox_Alm_ope_bat_status = value;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x003F38D4 File Offset: 0x003F1CD4
		// (set) Token: 0x0600210C RID: 8460 RVA: 0x003F38E8 File Offset: 0x003F1CE8
		internal virtual CheckBox CheckBox_Alm_arrombamento_status
		{
			get
			{
				return this._CheckBox_Alm_arrombamento_status;
			}
			[MethodImpl(32)]
			set
			{
				this._CheckBox_Alm_arrombamento_status = value;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x0600210D RID: 8461 RVA: 0x003F38F4 File Offset: 0x003F1CF4
		// (set) Token: 0x0600210E RID: 8462 RVA: 0x003F3908 File Offset: 0x003F1D08
		internal virtual GroupBox Grupo_bomba4
		{
			get
			{
				return this._Grupo_bomba4;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_bomba4 = value;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x0600210F RID: 8463 RVA: 0x003F3914 File Offset: 0x003F1D14
		// (set) Token: 0x06002110 RID: 8464 RVA: 0x003F3928 File Offset: 0x003F1D28
		internal virtual TextBox Modo_b4
		{
			get
			{
				return this._Modo_b4;
			}
			[MethodImpl(32)]
			set
			{
				this._Modo_b4 = value;
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x003F3934 File Offset: 0x003F1D34
		// (set) Token: 0x06002112 RID: 8466 RVA: 0x003F3948 File Offset: 0x003F1D48
		internal virtual Label Label_modo_b4
		{
			get
			{
				return this._Label_modo_b4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_modo_b4 = value;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06002113 RID: 8467 RVA: 0x003F3954 File Offset: 0x003F1D54
		// (set) Token: 0x06002114 RID: 8468 RVA: 0x003F3968 File Offset: 0x003F1D68
		internal virtual Button Cmd_manual_b4
		{
			get
			{
				return this._Cmd_manual_b4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_manual_b4_Click);
				if (this._Cmd_manual_b4 != null)
				{
					this._Cmd_manual_b4.Click -= eventHandler;
				}
				this._Cmd_manual_b4 = value;
				if (this._Cmd_manual_b4 != null)
				{
					this._Cmd_manual_b4.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x003F39B4 File Offset: 0x003F1DB4
		// (set) Token: 0x06002116 RID: 8470 RVA: 0x003F39C8 File Offset: 0x003F1DC8
		internal virtual Button Cmd_desliga_b4
		{
			get
			{
				return this._Cmd_desliga_b4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_desliga_b4_Click);
				if (this._Cmd_desliga_b4 != null)
				{
					this._Cmd_desliga_b4.Click -= eventHandler;
				}
				this._Cmd_desliga_b4 = value;
				if (this._Cmd_desliga_b4 != null)
				{
					this._Cmd_desliga_b4.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x003F3A14 File Offset: 0x003F1E14
		// (set) Token: 0x06002118 RID: 8472 RVA: 0x003F3A28 File Offset: 0x003F1E28
		internal virtual Button Cmd_liga_b4
		{
			get
			{
				return this._Cmd_liga_b4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_liga_b4_Click);
				if (this._Cmd_liga_b4 != null)
				{
					this._Cmd_liga_b4.Click -= eventHandler;
				}
				this._Cmd_liga_b4 = value;
				if (this._Cmd_liga_b4 != null)
				{
					this._Cmd_liga_b4.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06002119 RID: 8473 RVA: 0x003F3A74 File Offset: 0x003F1E74
		// (set) Token: 0x0600211A RID: 8474 RVA: 0x003F3A88 File Offset: 0x003F1E88
		internal virtual Label Label_status_b4
		{
			get
			{
				return this._Label_status_b4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_status_b4 = value;
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x0600211B RID: 8475 RVA: 0x003F3A94 File Offset: 0x003F1E94
		// (set) Token: 0x0600211C RID: 8476 RVA: 0x003F3AA8 File Offset: 0x003F1EA8
		internal virtual Button Cmd_automatico_b4
		{
			get
			{
				return this._Cmd_automatico_b4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_automatico_b4_Click);
				if (this._Cmd_automatico_b4 != null)
				{
					this._Cmd_automatico_b4.Click -= eventHandler;
				}
				this._Cmd_automatico_b4 = value;
				if (this._Cmd_automatico_b4 != null)
				{
					this._Cmd_automatico_b4.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x0600211D RID: 8477 RVA: 0x003F3AF4 File Offset: 0x003F1EF4
		// (set) Token: 0x0600211E RID: 8478 RVA: 0x003F3B08 File Offset: 0x003F1F08
		internal virtual TextBox Status_b4
		{
			get
			{
				return this._Status_b4;
			}
			[MethodImpl(32)]
			set
			{
				this._Status_b4 = value;
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x003F3B14 File Offset: 0x003F1F14
		// (set) Token: 0x06002120 RID: 8480 RVA: 0x003F3B28 File Offset: 0x003F1F28
		internal virtual Label Label_EA1
		{
			get
			{
				return this._Label_EA1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_EA1 = value;
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x003F3B34 File Offset: 0x003F1F34
		// (set) Token: 0x06002122 RID: 8482 RVA: 0x003F3B48 File Offset: 0x003F1F48
		internal virtual TextBox Valor_EA1
		{
			get
			{
				return this._Valor_EA1;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_EA1 = value;
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x003F3B54 File Offset: 0x003F1F54
		// (set) Token: 0x06002124 RID: 8484 RVA: 0x003F3B68 File Offset: 0x003F1F68
		internal virtual Label Label_EA2
		{
			get
			{
				return this._Label_EA2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_EA2 = value;
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06002125 RID: 8485 RVA: 0x003F3B74 File Offset: 0x003F1F74
		// (set) Token: 0x06002126 RID: 8486 RVA: 0x003F3B88 File Offset: 0x003F1F88
		internal virtual TextBox Valor_EA2
		{
			get
			{
				return this._Valor_EA2;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_EA2 = value;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x003F3B94 File Offset: 0x003F1F94
		// (set) Token: 0x06002128 RID: 8488 RVA: 0x003F3BA8 File Offset: 0x003F1FA8
		internal virtual Label Label_EA3
		{
			get
			{
				return this._Label_EA3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_EA3 = value;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06002129 RID: 8489 RVA: 0x003F3BB4 File Offset: 0x003F1FB4
		// (set) Token: 0x0600212A RID: 8490 RVA: 0x003F3BC8 File Offset: 0x003F1FC8
		internal virtual TextBox Valor_EA3
		{
			get
			{
				return this._Valor_EA3;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_EA3 = value;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x003F3BD4 File Offset: 0x003F1FD4
		// (set) Token: 0x0600212C RID: 8492 RVA: 0x003F3BE8 File Offset: 0x003F1FE8
		internal virtual Label Label_EA4
		{
			get
			{
				return this._Label_EA4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_EA4 = value;
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x003F3BF4 File Offset: 0x003F1FF4
		// (set) Token: 0x0600212E RID: 8494 RVA: 0x003F3C08 File Offset: 0x003F2008
		internal virtual TextBox Valor_EA4
		{
			get
			{
				return this._Valor_EA4;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_EA4 = value;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x003F3C14 File Offset: 0x003F2014
		// (set) Token: 0x06002130 RID: 8496 RVA: 0x003F3C28 File Offset: 0x003F2028
		internal virtual Label Label_EA5
		{
			get
			{
				return this._Label_EA5;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_EA5 = value;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x003F3C34 File Offset: 0x003F2034
		// (set) Token: 0x06002132 RID: 8498 RVA: 0x003F3C48 File Offset: 0x003F2048
		internal virtual TextBox Valor_EA5
		{
			get
			{
				return this._Valor_EA5;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_EA5 = value;
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x003F3C54 File Offset: 0x003F2054
		// (set) Token: 0x06002134 RID: 8500 RVA: 0x003F3C68 File Offset: 0x003F2068
		internal virtual Label Label_EA6
		{
			get
			{
				return this._Label_EA6;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_EA6 = value;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x003F3C74 File Offset: 0x003F2074
		// (set) Token: 0x06002136 RID: 8502 RVA: 0x003F3C88 File Offset: 0x003F2088
		internal virtual TextBox Valor_EA6
		{
			get
			{
				return this._Valor_EA6;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_EA6 = value;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x003F3C94 File Offset: 0x003F2094
		// (set) Token: 0x06002138 RID: 8504 RVA: 0x003F3CA8 File Offset: 0x003F20A8
		internal virtual Label Label_EA7
		{
			get
			{
				return this._Label_EA7;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_EA7 = value;
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x003F3CB4 File Offset: 0x003F20B4
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x003F3CC8 File Offset: 0x003F20C8
		internal virtual TextBox Valor_EA7
		{
			get
			{
				return this._Valor_EA7;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_EA7 = value;
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x003F3CD4 File Offset: 0x003F20D4
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x003F3CE8 File Offset: 0x003F20E8
		internal virtual Label Label_EA8
		{
			get
			{
				return this._Label_EA8;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_EA8 = value;
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x003F3CF4 File Offset: 0x003F20F4
		// (set) Token: 0x0600213E RID: 8510 RVA: 0x003F3D08 File Offset: 0x003F2108
		internal virtual TextBox Valor_EA8
		{
			get
			{
				return this._Valor_EA8;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_EA8 = value;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x003F3D14 File Offset: 0x003F2114
		// (set) Token: 0x06002140 RID: 8512 RVA: 0x003F3D28 File Offset: 0x003F2128
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

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x003F3D34 File Offset: 0x003F2134
		// (set) Token: 0x06002142 RID: 8514 RVA: 0x003F3D48 File Offset: 0x003F2148
		internal virtual TextBox Valor_EA16
		{
			get
			{
				return this._Valor_EA16;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_EA16 = value;
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x003F3D54 File Offset: 0x003F2154
		// (set) Token: 0x06002144 RID: 8516 RVA: 0x003F3D68 File Offset: 0x003F2168
		internal virtual Label Label_EA16
		{
			get
			{
				return this._Label_EA16;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_EA16 = value;
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x003F3D74 File Offset: 0x003F2174
		// (set) Token: 0x06002146 RID: 8518 RVA: 0x003F3D88 File Offset: 0x003F2188
		internal virtual TextBox Valor_EA15
		{
			get
			{
				return this._Valor_EA15;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_EA15 = value;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x003F3D94 File Offset: 0x003F2194
		// (set) Token: 0x06002148 RID: 8520 RVA: 0x003F3DA8 File Offset: 0x003F21A8
		internal virtual Label Label_EA15
		{
			get
			{
				return this._Label_EA15;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_EA15 = value;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x003F3DB4 File Offset: 0x003F21B4
		// (set) Token: 0x0600214A RID: 8522 RVA: 0x003F3DC8 File Offset: 0x003F21C8
		internal virtual TextBox Valor_EA14
		{
			get
			{
				return this._Valor_EA14;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_EA14 = value;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x003F3DD4 File Offset: 0x003F21D4
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x003F3DE8 File Offset: 0x003F21E8
		internal virtual Label Label_EA14
		{
			get
			{
				return this._Label_EA14;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_EA14 = value;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x003F3DF4 File Offset: 0x003F21F4
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x003F3E08 File Offset: 0x003F2208
		internal virtual TextBox Valor_EA13
		{
			get
			{
				return this._Valor_EA13;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_EA13 = value;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x003F3E14 File Offset: 0x003F2214
		// (set) Token: 0x06002150 RID: 8528 RVA: 0x003F3E28 File Offset: 0x003F2228
		internal virtual Label Label_EA13
		{
			get
			{
				return this._Label_EA13;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_EA13 = value;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x003F3E34 File Offset: 0x003F2234
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x003F3E48 File Offset: 0x003F2248
		internal virtual TextBox Valor_EA12
		{
			get
			{
				return this._Valor_EA12;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_EA12 = value;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x003F3E54 File Offset: 0x003F2254
		// (set) Token: 0x06002154 RID: 8532 RVA: 0x003F3E68 File Offset: 0x003F2268
		internal virtual Label Label_EA12
		{
			get
			{
				return this._Label_EA12;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_EA12 = value;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x003F3E74 File Offset: 0x003F2274
		// (set) Token: 0x06002156 RID: 8534 RVA: 0x003F3E88 File Offset: 0x003F2288
		internal virtual TextBox Valor_EA11
		{
			get
			{
				return this._Valor_EA11;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_EA11 = value;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x003F3E94 File Offset: 0x003F2294
		// (set) Token: 0x06002158 RID: 8536 RVA: 0x003F3EA8 File Offset: 0x003F22A8
		internal virtual Label Label_EA11
		{
			get
			{
				return this._Label_EA11;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_EA11 = value;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x003F3EB4 File Offset: 0x003F22B4
		// (set) Token: 0x0600215A RID: 8538 RVA: 0x003F3EC8 File Offset: 0x003F22C8
		internal virtual TextBox Valor_EA10
		{
			get
			{
				return this._Valor_EA10;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_EA10 = value;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x003F3ED4 File Offset: 0x003F22D4
		// (set) Token: 0x0600215C RID: 8540 RVA: 0x003F3EE8 File Offset: 0x003F22E8
		internal virtual Label Label_EA10
		{
			get
			{
				return this._Label_EA10;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_EA10 = value;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x003F3EF4 File Offset: 0x003F22F4
		// (set) Token: 0x0600215E RID: 8542 RVA: 0x003F3F08 File Offset: 0x003F2308
		internal virtual TextBox Valor_EA9
		{
			get
			{
				return this._Valor_EA9;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_EA9 = value;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x003F3F14 File Offset: 0x003F2314
		// (set) Token: 0x06002160 RID: 8544 RVA: 0x003F3F28 File Offset: 0x003F2328
		internal virtual Label Label_EA9
		{
			get
			{
				return this._Label_EA9;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_EA9 = value;
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x003F3F34 File Offset: 0x003F2334
		// (set) Token: 0x06002162 RID: 8546 RVA: 0x003F3F48 File Offset: 0x003F2348
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

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x003F3F94 File Offset: 0x003F2394
		// (set) Token: 0x06002164 RID: 8548 RVA: 0x003F3FA8 File Offset: 0x003F23A8
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

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x003F3FB4 File Offset: 0x003F23B4
		// (set) Token: 0x06002166 RID: 8550 RVA: 0x003F3FC8 File Offset: 0x003F23C8
		internal virtual Button Cmd_falha_b4
		{
			get
			{
				return this._Cmd_falha_b4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_falha_b4_Click);
				if (this._Cmd_falha_b4 != null)
				{
					this._Cmd_falha_b4.Click -= eventHandler;
				}
				this._Cmd_falha_b4 = value;
				if (this._Cmd_falha_b4 != null)
				{
					this._Cmd_falha_b4.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x003F4014 File Offset: 0x003F2414
		// (set) Token: 0x06002168 RID: 8552 RVA: 0x003F4028 File Offset: 0x003F2428
		internal virtual Button Cmd_falha_b1
		{
			get
			{
				return this._Cmd_falha_b1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_falha_b1_Click);
				if (this._Cmd_falha_b1 != null)
				{
					this._Cmd_falha_b1.Click -= eventHandler;
				}
				this._Cmd_falha_b1 = value;
				if (this._Cmd_falha_b1 != null)
				{
					this._Cmd_falha_b1.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x003F4074 File Offset: 0x003F2474
		// (set) Token: 0x0600216A RID: 8554 RVA: 0x003F4088 File Offset: 0x003F2488
		internal virtual Button Cmd_falha_b3
		{
			get
			{
				return this._Cmd_falha_b3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Cmd_falha_b3_Click);
				if (this._Cmd_falha_b3 != null)
				{
					this._Cmd_falha_b3.Click -= eventHandler;
				}
				this._Cmd_falha_b3 = value;
				if (this._Cmd_falha_b3 != null)
				{
					this._Cmd_falha_b3.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x003F40D4 File Offset: 0x003F24D4
		// (set) Token: 0x0600216C RID: 8556 RVA: 0x003F40E8 File Offset: 0x003F24E8
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

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x003F4134 File Offset: 0x003F2534
		// (set) Token: 0x0600216E RID: 8558 RVA: 0x003F4148 File Offset: 0x003F2548
		internal virtual CheckBox CheckBox_Alm_ff_status
		{
			get
			{
				return this._CheckBox_Alm_ff_status;
			}
			[MethodImpl(32)]
			set
			{
				this._CheckBox_Alm_ff_status = value;
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x003F4154 File Offset: 0x003F2554
		// (set) Token: 0x06002170 RID: 8560 RVA: 0x003F4168 File Offset: 0x003F2568
		internal virtual CheckBox CheckBox_Alm_bat_bx_status
		{
			get
			{
				return this._CheckBox_Alm_bat_bx_status;
			}
			[MethodImpl(32)]
			set
			{
				this._CheckBox_Alm_bat_bx_status = value;
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06002171 RID: 8561 RVA: 0x003F4174 File Offset: 0x003F2574
		// (set) Token: 0x06002172 RID: 8562 RVA: 0x003F4188 File Offset: 0x003F2588
		internal virtual TextBox msg_modo_operacao
		{
			get
			{
				return this._msg_modo_operacao;
			}
			[MethodImpl(32)]
			set
			{
				this._msg_modo_operacao = value;
			}
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x003F4194 File Offset: 0x003F2594
		private void Equip_202_mon_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x003F4198 File Offset: 0x003F2598
		private void Equip_202_mon_Load(object sender, EventArgs e)
		{
			Geral.Config_geral.Largura_tela_trabalho = this.Width;
			int num = 48;
			string text = "Colocar o equipamento em modo de monitoração !\r\nAbrir o jumper de configuração.\r\n";
			switch (Geral.Config_geral.Protocolo)
			{
			case 1:
				text += "Utilize canal COM1 ou COM2";
				break;
			case 2:
				text += "Utilize canal COM2.";
				break;
			}
			Interaction.MsgBox(text, num, " Atenção - verifique a configuração");
			string versao = Geral.Config_geral.Versao;
			if (Operators.CompareString(versao, "21", false) == 0)
			{
				this.Label_EA9.Visible = true;
				this.Label_EA10.Visible = true;
				this.Label_EA11.Visible = true;
				this.Label_EA12.Visible = true;
				this.Valor_EA9.Visible = true;
				this.Valor_EA10.Visible = true;
				this.Valor_EA11.Visible = true;
				this.Valor_EA12.Visible = true;
				this.Tela_nivel_destino.Value = 100m;
				this.Tela_nivel_origem.Value = 100m;
				this.Grupo_setpoints.Text = this.Grupo_setpoints.Text + " (0 - 100%)";
			}
			else if (Operators.CompareString(versao, "50", false) == 0)
			{
				this.Label_EA9.Visible = false;
				this.Label_EA10.Visible = false;
				this.Label_EA11.Visible = false;
				this.Label_EA12.Visible = false;
				this.Valor_EA9.Visible = false;
				this.Valor_EA10.Visible = false;
				this.Valor_EA11.Visible = false;
				this.Valor_EA12.Visible = false;
				this.Tela_nivel_destino.Value = 100m;
				this.Tela_nivel_origem.Value = 100m;
			}
			else if (Operators.CompareString(versao, "820_10", false) == 0)
			{
				this.Tela_nivel_destino.Maximum = 4000m;
				this.Tela_nivel_origem.Maximum = 4000m;
				this.Tela_nivel_destino.Value = 4000m;
				this.Tela_nivel_origem.Value = 4000m;
			}
			else
			{
				this.Label_EA9.Visible = true;
				this.Label_EA10.Visible = true;
				this.Label_EA11.Visible = true;
				this.Label_EA12.Visible = true;
				this.Valor_EA9.Visible = true;
				this.Valor_EA10.Visible = true;
				this.Valor_EA11.Visible = true;
				this.Valor_EA12.Visible = true;
				this.Tela_nivel_destino.Value = 100m;
				this.Tela_nivel_origem.Value = 100m;
			}
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x003F4458 File Offset: 0x003F2858
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
							this.Calcula_Estatistica_202(1);
							this.Atualiza_setpoint_monitoracao_202();
							goto IL_177;
						case 1:
							goto IL_13E;
						case 2:
							if (i == 0)
							{
								this.Mensagem_MD202_mon("Erro Leitura Setpoints - ChkSum", 1);
								this.Calcula_Estatistica_202(3);
								this.Limpa_monitoracao_202(2);
							}
							else
							{
								this.Calcula_Estatistica_202(2);
							}
							break;
						case 3:
							if (i == 0)
							{
								this.Mensagem_MD202_mon("Erro Leitura Setpoints - Timeout", 1);
								this.Calcula_Estatistica_202(3);
								this.Limpa_monitoracao_202(2);
							}
							else
							{
								this.Calcula_Estatistica_202(2);
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
							this.Calcula_Estatistica_202(3);
							this.Limpa_monitoracao_202(2);
							goto IL_165;
						}
						this.Calcula_Estatistica_202(2);
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
						string versao = Geral.Config_geral.Versao;
						if (Operators.CompareString(versao, "820_10", false) == 0)
						{
							array[0] = Mod_MD.Monitoracao_MD_RQ.Nivel_dest / 200;
							array[1] = Mod_MD.Monitoracao_MD_RQ.Nivel_dest % 200;
							array[2] = Mod_MD.Monitoracao_MD_RQ.Nivel_origem / 200;
							array[3] = Mod_MD.Monitoracao_MD_RQ.Nivel_origem % 200;
							array[4] = 0;
							Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, 57, 5, array);
						}
						else
						{
							array[0] = Mod_MD.Monitoracao_MD_RQ.Nivel_dest * 2;
							array[1] = Mod_MD.Monitoracao_MD_RQ.Nivel_origem * 2;
							Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, 57, 2, array);
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
							this.Calcula_Estatistica_202(1);
							this.Atualiza_status_monitoracao_202();
							goto IL_379;
						case 1:
							goto IL_340;
						case 2:
							if (i == 0)
							{
								this.Mensagem_MD202_mon("Erro Leitura Equipamento - ChkSum", 1);
								this.Calcula_Estatistica_202(3);
								this.Limpa_monitoracao_202(1);
							}
							else
							{
								this.Calcula_Estatistica_202(2);
							}
							break;
						case 3:
							if (i == 0)
							{
								this.Mensagem_MD202_mon("Erro Leitura Equipamento - Timeout", 1);
								this.Calcula_Estatistica_202(3);
								this.Limpa_monitoracao_202(1);
							}
							else
							{
								this.Calcula_Estatistica_202(2);
							}
							break;
						default:
							goto IL_340;
						}
						IL_367:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_340:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro Leitura Equipamento - não determinado", 1);
							this.Calcula_Estatistica_202(3);
							this.Limpa_monitoracao_202(1);
							goto IL_367;
						}
						this.Calcula_Estatistica_202(2);
						goto IL_367;
					}
					IL_379:
					MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
					break;
				case 3:
					i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					Mod_MD.Monitoracao_MD_RQ.Controle_mon = 2;
					while (i > 0)
					{
						i--;
						string versao2 = Geral.Config_geral.Versao;
						if (Operators.CompareString(versao2, "820_10", false) == 0)
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
							this.Calcula_Estatistica_202(1);
							goto IL_8E7;
						case 1:
							goto IL_8B5;
						case 2:
							if (i == 0)
							{
								this.Mensagem_MD202_mon("Erro Escrita Setpoints - ChkSum", 1);
								this.Calcula_Estatistica_202(3);
							}
							else
							{
								this.Calcula_Estatistica_202(2);
							}
							break;
						case 3:
							if (i == 0)
							{
								this.Mensagem_MD202_mon("Erro Escrita Setpoints - Timeout", 1);
								this.Calcula_Estatistica_202(3);
							}
							else
							{
								this.Calcula_Estatistica_202(2);
							}
							break;
						default:
							goto IL_8B5;
						}
						IL_8D5:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_8B5:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro Escrita Setpoints - não determinado", 1);
							this.Calcula_Estatistica_202(3);
							goto IL_8D5;
						}
						this.Calcula_Estatistica_202(2);
						goto IL_8D5;
					}
					IL_8E7:
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
							Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Verifica_resposta();
							this.Mensagem_MD202_mon(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
							this.Calcula_Estatistica_202(1);
							goto IL_A44;
						}
						case 1:
							goto IL_A12;
						case 2:
							if (i == 0)
							{
								this.Mensagem_MD202_mon("Erro ao executar o camando - ChkSum", 1);
								this.Calcula_Estatistica_202(3);
							}
							else
							{
								this.Calcula_Estatistica_202(2);
							}
							break;
						case 3:
							if (i == 0)
							{
								this.Mensagem_MD202_mon("Erro ao executar o camando - Timeout", 1);
								this.Calcula_Estatistica_202(3);
							}
							else
							{
								this.Calcula_Estatistica_202(2);
							}
							break;
						default:
							goto IL_A12;
						}
						IL_A32:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_A12:
						if (i == 0)
						{
							this.Mensagem_MD202_mon("Erro ao executar o camando - não determinado", 1);
							this.Calcula_Estatistica_202(3);
							goto IL_A32;
						}
						this.Calcula_Estatistica_202(2);
						goto IL_A32;
					}
					IL_A44:
					MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
					break;
				}
				if (Mod_MD.Monitoracao_MD_RQ.Partir_mon)
				{
					this.Timer_monitoracao.Enabled = true;
				}
			}
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x003F4EDC File Offset: 0x003F32DC
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

		// Token: 0x06002177 RID: 8567 RVA: 0x003F4F40 File Offset: 0x003F3340
		public void Calcula_Estatistica_202(int opcao)
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

		// Token: 0x06002178 RID: 8568 RVA: 0x003F5080 File Offset: 0x003F3480
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

		// Token: 0x06002179 RID: 8569 RVA: 0x003F53D8 File Offset: 0x003F37D8
		public void Limpa_monitoracao_202(int tipo)
		{
			switch (tipo)
			{
			case 1:
				this.Status_b1.Text = Mod_MD.Mensagem_status_bomba_201(0);
				this.Status_b2.Text = Mod_MD.Mensagem_status_bomba_201(0);
				this.Status_b3.Text = Mod_MD.Mensagem_status_bomba_201(0);
				this.Modo_b1.Text = Mod_MD.Mensagem_modo_bomba_201(0);
				this.Modo_b2.Text = Mod_MD.Mensagem_modo_bomba_201(0);
				this.Modo_b3.Text = Mod_MD.Mensagem_modo_bomba_201(0);
				this.CheckBox_Alm_arrombamento_status.Checked = false;
				this.CheckBox_Alm_ope_bat_status.Checked = false;
				this.CheckBox_Alm_alagamento_status.Checked = false;
				this.Grupo_alarmes.Enabled = false;
				this.Grupo_medidas.Enabled = false;
				this.Cmd_manual_b1.Enabled = false;
				this.Cmd_automatico_b1.Enabled = false;
				this.Cmd_liga_b1.Enabled = false;
				this.Cmd_desliga_b1.Enabled = false;
				this.Grupo_bomba1.Enabled = false;
				this.Cmd_manual_b2.Enabled = false;
				this.Cmd_automatico_b2.Enabled = false;
				this.Cmd_liga_b2.Enabled = false;
				this.Cmd_desliga_b2.Enabled = false;
				this.Grupo_bomba2.Enabled = false;
				this.Cmd_manual_b3.Enabled = false;
				this.Cmd_automatico_b3.Enabled = false;
				this.Cmd_liga_b3.Enabled = false;
				this.Cmd_desliga_b3.Enabled = false;
				this.Grupo_bomba3.Enabled = false;
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

		// Token: 0x0600217A RID: 8570 RVA: 0x003F55F8 File Offset: 0x003F39F8
		public void Atualiza_status_monitoracao_202()
		{
			string versao = Geral.Config_geral.Versao;
			int tipo;
			int num;
			int num2;
			if (Operators.CompareString(versao, "50", false) == 0)
			{
				tipo = 2;
				num = 18;
				num2 = 17;
			}
			else if (Operators.CompareString(versao, "820_10", false) == 0)
			{
				tipo = 3;
				num = 34;
				num2 = 33;
			}
			else
			{
				tipo = 1;
				num = 18;
				num2 = 17;
			}
			checked
			{
				this.Atualiza_tela_motores_modo((int)Comunicacao.Buffer_resp[3 + num], (int)Comunicacao.Buffer_resp[3 + num + 1], (int)Comunicacao.Buffer_resp[3 + num + 2], (int)Comunicacao.Buffer_resp[3 + num + 3], (int)Comunicacao.Buffer_resp[3 + num + 4]);
				this.Atualiza_tela_medidas_analogicas(ref Comunicacao.Buffer_resp, tipo);
				this.Atualiza_tela_alarmes((int)Comunicacao.Buffer_resp[3 + num2]);
			}
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x003F56A0 File Offset: 0x003F3AA0
		public void Atualiza_tela_medidas_analogicas(ref byte[] dados, int tipo)
		{
			checked
			{
				switch (tipo)
				{
				case 1:
					this.Valor_EA1.Text = Strings.Format((double)(dados[4] - 48) / 2.0, "0.0");
					this.Valor_EA2.Text = Strings.Format((double)(dados[5] - 48) / 2.0, "0.0");
					this.Valor_EA3.Text = Strings.Format((double)(dados[6] - 48) / 2.0, "0.0");
					this.Valor_EA4.Text = Strings.Format((double)(dados[7] - 48) / 2.0, "0.0");
					this.Valor_EA5.Text = Strings.Format((double)(dados[8] - 48) / 2.0, "0.0");
					this.Valor_EA6.Text = Strings.Format((double)(dados[9] - 48) / 2.0, "0.0");
					this.Valor_EA7.Text = Strings.Format((double)(dados[10] - 48) / 2.0, "0.0");
					this.Valor_EA8.Text = Strings.Format((double)(dados[11] - 48) / 2.0, "0.0");
					this.Valor_EA9.Text = Strings.Format((double)(dados[12] - 48) / 2.0, "0.0");
					this.Valor_EA10.Text = Strings.Format((double)(dados[13] - 48) / 2.0, "0.0");
					this.Valor_EA11.Text = Strings.Format((double)(dados[14] - 48) / 2.0, "0.0");
					this.Valor_EA12.Text = Strings.Format((double)(dados[15] - 48) / 2.0, "0.0");
					this.Valor_EA13.Text = Strings.Format((double)(dados[16] - 48) / 2.0, "0.0");
					this.Valor_EA14.Text = Strings.Format((double)(dados[17] - 48) / 2.0, "0.0");
					this.Valor_EA15.Text = Strings.Format((double)(dados[18] - 48) / 2.0, "0.0");
					this.Valor_EA16.Text = Strings.Format((double)(dados[19] - 48) / 2.0, "0.0");
					break;
				case 2:
					this.Valor_EA1.Text = Strings.Format((double)(dados[4] - 48) / 2.0, "0.0");
					this.Valor_EA2.Text = Strings.Format((double)(dados[5] - 48) / 2.0, "0.0");
					this.Valor_EA3.Text = Strings.Format((double)(dados[6] - 48) / 2.0, "0.0");
					this.Valor_EA4.Text = Strings.Format((double)(dados[7] - 48) / 2.0, "0.0");
					this.Valor_EA5.Text = Strings.Format((double)(dados[8] - 48) / 2.0, "0.0");
					this.Valor_EA6.Text = Strings.Format((double)(dados[9] - 48) / 2.0, "0.0");
					this.Valor_EA7.Text = Strings.Format((double)(dados[10] - 48) / 2.0, "0.0");
					this.Valor_EA8.Text = Strings.Format((double)(dados[11] - 48) / 2.0, "0.0");
					this.Valor_EA9.Text = Conversions.ToString(0);
					this.Valor_EA10.Text = Conversions.ToString(0);
					this.Valor_EA11.Text = Conversions.ToString(0);
					this.Valor_EA12.Text = Conversions.ToString(0);
					this.Valor_EA13.Text = Strings.Format((double)((dados[12] - 48) * 200 + dados[13] - 48) / 40.0, "0.0");
					this.Valor_EA14.Text = Strings.Format((double)((dados[14] - 48) * 200 + dados[15] - 48) / 40.0, "0.0");
					this.Valor_EA15.Text = Strings.Format((double)((dados[16] - 48) * 200 + dados[17] - 48) / 40.0, "0.0");
					this.Valor_EA16.Text = Strings.Format((double)((dados[18] - 48) * 200 + dados[19] - 48) / 40.0, "0.0");
					break;
				case 3:
					this.Valor_EA1.Text = Strings.Format((double)((dados[4] - 48) * 200 + dados[5] - 48) / 40.0, "0.0");
					this.Valor_EA2.Text = Strings.Format((double)((dados[6] - 48) * 200 + dados[7] - 48) / 40.0, "0.0");
					this.Valor_EA3.Text = Strings.Format((double)((dados[8] - 48) * 200 + dados[9] - 48) / 40.0, "0.0");
					this.Valor_EA4.Text = Strings.Format((double)((dados[10] - 48) * 200 + dados[11] - 48) / 40.0, "0.0");
					this.Valor_EA5.Text = Strings.Format((double)((dados[12] - 48) * 200 + dados[13] - 48) / 40.0, "0.0");
					this.Valor_EA6.Text = Strings.Format((double)((dados[14] - 48) * 200 + dados[15] - 48) / 40.0, "0.0");
					this.Valor_EA7.Text = Strings.Format((double)((dados[16] - 48) * 200 + dados[17] - 48) / 40.0, "0.0");
					this.Valor_EA8.Text = Strings.Format((double)((dados[18] - 48) * 200 + dados[19] - 48) / 40.0, "0.0");
					this.Valor_EA9.Text = Strings.Format((double)((dados[20] - 48) * 200 + dados[21] - 48) / 40.0, "0.0");
					this.Valor_EA10.Text = Strings.Format((double)((dados[22] - 48) * 200 + dados[23] - 48) / 40.0, "0.0");
					this.Valor_EA11.Text = Strings.Format((double)((dados[24] - 48) * 200 + dados[25] - 48) / 40.0, "0.0");
					this.Valor_EA12.Text = Strings.Format((double)((dados[26] - 48) * 200 + dados[27] - 48) / 40.0, "0.0");
					this.Valor_EA13.Text = Strings.Format((double)((dados[28] - 48) * 200 + dados[29] - 48) / 40.0, "0.0");
					this.Valor_EA14.Text = Strings.Format((double)((dados[30] - 48) * 200 + dados[31] - 48) / 40.0, "0.0");
					this.Valor_EA15.Text = Strings.Format((double)((dados[32] - 48) * 200 + dados[33] - 48) / 40.0, "0.0");
					this.Valor_EA16.Text = Strings.Format((double)((dados[34] - 48) * 200 + dados[35] - 48) / 40.0, "0.0");
					break;
				}
			}
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x003F5FF0 File Offset: 0x003F43F0
		public void Atualiza_tela_alarmes(int alarme)
		{
			if ((alarme & 16) != 0)
			{
				this.CheckBox_Alm_alagamento_status.Checked = true;
			}
			else
			{
				this.CheckBox_Alm_alagamento_status.Checked = false;
			}
			if ((alarme & 8) != 0)
			{
				this.CheckBox_Alm_arrombamento_status.Checked = true;
			}
			else
			{
				this.CheckBox_Alm_arrombamento_status.Checked = false;
			}
			if ((alarme & 2) != 0)
			{
				this.CheckBox_Alm_bat_bx_status.Checked = true;
			}
			else
			{
				this.CheckBox_Alm_bat_bx_status.Checked = false;
			}
			if ((alarme & 1) != 0)
			{
				this.CheckBox_Alm_ope_bat_status.Checked = true;
			}
			else
			{
				this.CheckBox_Alm_ope_bat_status.Checked = false;
			}
			if ((alarme & 4) != 0)
			{
				this.CheckBox_Alm_ff_status.Checked = true;
			}
			else
			{
				this.CheckBox_Alm_ff_status.Checked = false;
			}
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x003F60A8 File Offset: 0x003F44A8
		public void Atualiza_tela_motores_modo(int modo, int st_b1, int st_b2, int st_b3, int st_b4)
		{
			checked
			{
				int modo_placa = (modo - 48 & 24) / 8;
				st_b1 -= 48;
				st_b2 -= 48;
				st_b3 -= 48;
				st_b4 -= 48;
				modo -= 48;
				switch (modo & 7)
				{
				case 0:
					this.Grupo_bomba1.Enabled = false;
					this.Grupo_bomba2.Enabled = false;
					this.Grupo_bomba3.Enabled = false;
					this.Grupo_bomba4.Enabled = false;
					break;
				case 1:
					this.Grupo_bomba1.Enabled = true;
					this.Grupo_bomba2.Enabled = false;
					this.Grupo_bomba3.Enabled = false;
					this.Grupo_bomba4.Enabled = false;
					break;
				case 2:
					this.Grupo_bomba1.Enabled = true;
					this.Grupo_bomba2.Enabled = true;
					this.Grupo_bomba3.Enabled = false;
					this.Grupo_bomba4.Enabled = false;
					break;
				case 3:
					this.Grupo_bomba1.Enabled = true;
					this.Grupo_bomba2.Enabled = true;
					this.Grupo_bomba3.Enabled = true;
					this.Grupo_bomba4.Enabled = false;
					break;
				case 4:
					this.Grupo_bomba1.Enabled = true;
					this.Grupo_bomba2.Enabled = true;
					this.Grupo_bomba3.Enabled = true;
					this.Grupo_bomba4.Enabled = true;
					break;
				}
				this.Grupo_alarmes.Enabled = true;
				this.Grupo_medidas.Enabled = true;
				Equip_202_mon.HAB_CTRL hab_CTRL = this.Controles_bombas(modo_placa, st_b1);
				this.Cmd_automatico_b1.Enabled = hab_CTRL.Tecla_auto;
				this.Cmd_manual_b1.Enabled = hab_CTRL.Tecla_man;
				this.Cmd_liga_b1.Enabled = hab_CTRL.Tecla_liga;
				this.Cmd_desliga_b1.Enabled = hab_CTRL.Tecla_desliga;
				this.Cmd_falha_b1.Enabled = hab_CTRL.Tecla_falha;
				this.Status_b1.Text = hab_CTRL.status;
				this.Modo_b1.Text = hab_CTRL.modo_motor;
				this.msg_modo_operacao.Text = hab_CTRL.modo_placa;
				hab_CTRL = this.Controles_bombas(modo_placa, st_b2);
				this.Cmd_automatico_b2.Enabled = hab_CTRL.Tecla_auto;
				this.Cmd_manual_b2.Enabled = hab_CTRL.Tecla_man;
				this.Cmd_liga_b2.Enabled = hab_CTRL.Tecla_liga;
				this.Cmd_desliga_b2.Enabled = hab_CTRL.Tecla_desliga;
				this.Cmd_falha_b2.Enabled = hab_CTRL.Tecla_falha;
				this.Status_b2.Text = hab_CTRL.status;
				this.Modo_b2.Text = hab_CTRL.modo_motor;
				hab_CTRL = this.Controles_bombas(modo_placa, st_b3);
				this.Cmd_automatico_b3.Enabled = hab_CTRL.Tecla_auto;
				this.Cmd_manual_b3.Enabled = hab_CTRL.Tecla_man;
				this.Cmd_liga_b3.Enabled = hab_CTRL.Tecla_liga;
				this.Cmd_desliga_b3.Enabled = hab_CTRL.Tecla_desliga;
				this.Cmd_falha_b3.Enabled = hab_CTRL.Tecla_falha;
				this.Status_b3.Text = hab_CTRL.status;
				this.Modo_b3.Text = hab_CTRL.modo_motor;
				hab_CTRL = this.Controles_bombas(modo_placa, st_b4);
				this.Cmd_automatico_b4.Enabled = hab_CTRL.Tecla_auto;
				this.Cmd_manual_b4.Enabled = hab_CTRL.Tecla_man;
				this.Cmd_liga_b4.Enabled = hab_CTRL.Tecla_liga;
				this.Cmd_desliga_b4.Enabled = hab_CTRL.Tecla_desliga;
				this.Cmd_falha_b4.Enabled = hab_CTRL.Tecla_falha;
				this.Status_b4.Text = hab_CTRL.status;
				this.Modo_b4.Text = hab_CTRL.modo_motor;
			}
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x003F6448 File Offset: 0x003F4848
		public Equip_202_mon.HAB_CTRL Controles_bombas(int modo_placa, int status_bomba)
		{
			int num = status_bomba & 15;
			int num2 = checked((int)Math.Round((double)(status_bomba & 32) / 32.0));
			Equip_202_mon.HAB_CTRL result;
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

		// Token: 0x0600217F RID: 8575 RVA: 0x003F65B4 File Offset: 0x003F49B4
		private void Comando_hab_monitoracao_Click(object sender, EventArgs e)
		{
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
				this.Grupo_alarmes.Enabled = false;
				this.Grupo_medidas.Enabled = false;
			}
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x003F6780 File Offset: 0x003F4B80
		private void Tela_endereco_mestre_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Mestre = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Inicializa_tela_equipamento_MD202_mon();
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x003F67AC File Offset: 0x003F4BAC
		public void Inicializa_tela_equipamento_MD202_mon()
		{
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Iniciar", false) != 0)
			{
				this.Mensagem_MD202_mon(" Aguarde ... ", 2);
				Mod_MD.Monitoracao_MD_RQ.Controle_mon = 1;
			}
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x003F67E0 File Offset: 0x003F4BE0
		private void Tela_endereco_estacao_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Estacao = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Inicializa_tela_equipamento_MD202_mon();
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x003F680C File Offset: 0x003F4C0C
		private void Button_limpa_estatistica_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Num_Rx = 0L;
			Mod_MD.Monitoracao_MD_RQ.Num_Tx = 0L;
			Mod_MD.Monitoracao_MD_RQ.Eficiencia_com = 0;
			Mod_MD.Monitoracao_MD_RQ.Num_Retry = 0L;
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x003F6840 File Offset: 0x003F4C40
		private void Comando_le_setpoint_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 1;
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x003F6850 File Offset: 0x003F4C50
		private void Comando_escreve_setpoint_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 3;
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x003F6860 File Offset: 0x003F4C60
		private void Cmd_liga_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x003F6884 File Offset: 0x003F4C84
		private void Cmd_desliga_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x003F68A8 File Offset: 0x003F4CA8
		private void Cmd_manual_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x003F68CC File Offset: 0x003F4CCC
		private void Cmd_automatico_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x003F68F0 File Offset: 0x003F4CF0
		private void Cmd_falha_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 71;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x003F6914 File Offset: 0x003F4D14
		private void Cmd_liga_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x003F6938 File Offset: 0x003F4D38
		private void Cmd_desliga_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x003F695C File Offset: 0x003F4D5C
		private void Cmd_manual_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x003F6980 File Offset: 0x003F4D80
		private void Cmd_automatico_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x003F69A4 File Offset: 0x003F4DA4
		private void Cmd_falha_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 71;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x003F69C8 File Offset: 0x003F4DC8
		private void Cmd_liga_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x003F69EC File Offset: 0x003F4DEC
		private void Cmd_desliga_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x003F6A10 File Offset: 0x003F4E10
		private void Cmd_manual_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x003F6A34 File Offset: 0x003F4E34
		private void Cmd_automatico_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x003F6A58 File Offset: 0x003F4E58
		private void Cmd_falha_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 71;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x003F6A7C File Offset: 0x003F4E7C
		private void Cmd_liga_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x003F6AA0 File Offset: 0x003F4EA0
		private void Cmd_desliga_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x003F6AC4 File Offset: 0x003F4EC4
		private void Cmd_manual_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x003F6AE8 File Offset: 0x003F4EE8
		private void Cmd_automatico_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x003F6B0C File Offset: 0x003F4F0C
		private void Cmd_falha_b4_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 4;
			Mod_MD.Monitoracao_MD_RQ.Comando = 71;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x003F6B30 File Offset: 0x003F4F30
		private void Tela_nivel_origem_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Nivel_origem = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x003F6B58 File Offset: 0x003F4F58
		private void Tela_nivel_destino_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Nivel_dest = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x04001714 RID: 5908
		[AccessedThroughProperty("Grupo_ctrl_com")]
		private GroupBox _Grupo_ctrl_com;

		// Token: 0x04001715 RID: 5909
		[AccessedThroughProperty("Tela_endereco_estacao")]
		private NumericUpDown _Tela_endereco_estacao;

		// Token: 0x04001716 RID: 5910
		[AccessedThroughProperty("Tela_endereco_mestre")]
		private NumericUpDown _Tela_endereco_mestre;

		// Token: 0x04001717 RID: 5911
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001718 RID: 5912
		[AccessedThroughProperty("msg")]
		private TextBox _msg;

		// Token: 0x04001719 RID: 5913
		[AccessedThroughProperty("Comando_hab_monitoracao")]
		private Button _Comando_hab_monitoracao;

		// Token: 0x0400171A RID: 5914
		[AccessedThroughProperty("Label_end_estacao")]
		private Label _Label_end_estacao;

		// Token: 0x0400171B RID: 5915
		[AccessedThroughProperty("Timer_monitoracao")]
		private Timer _Timer_monitoracao;

		// Token: 0x0400171C RID: 5916
		[AccessedThroughProperty("Grupo_setpoints")]
		private GroupBox _Grupo_setpoints;

		// Token: 0x0400171D RID: 5917
		[AccessedThroughProperty("Comando_escreve_setpoint")]
		private Button _Comando_escreve_setpoint;

		// Token: 0x0400171E RID: 5918
		[AccessedThroughProperty("Comando_le_setpoint")]
		private Button _Comando_le_setpoint;

		// Token: 0x0400171F RID: 5919
		[AccessedThroughProperty("Grupo_estatistica")]
		private GroupBox _Grupo_estatistica;

		// Token: 0x04001720 RID: 5920
		[AccessedThroughProperty("Label_Est_retry")]
		private Label _Label_Est_retry;

		// Token: 0x04001721 RID: 5921
		[AccessedThroughProperty("Est_retry")]
		private TextBox _Est_retry;

		// Token: 0x04001722 RID: 5922
		[AccessedThroughProperty("Est_eficiencia")]
		private TextBox _Est_eficiencia;

		// Token: 0x04001723 RID: 5923
		[AccessedThroughProperty("Button_limpa_estatistica")]
		private Button _Button_limpa_estatistica;

		// Token: 0x04001724 RID: 5924
		[AccessedThroughProperty("Label_Est_RX")]
		private Label _Label_Est_RX;

		// Token: 0x04001725 RID: 5925
		[AccessedThroughProperty("Label_Est_Eficiencia")]
		private Label _Label_Est_Eficiencia;

		// Token: 0x04001726 RID: 5926
		[AccessedThroughProperty("Label_Est_TX")]
		private Label _Label_Est_TX;

		// Token: 0x04001727 RID: 5927
		[AccessedThroughProperty("Est_Rx")]
		private TextBox _Est_Rx;

		// Token: 0x04001728 RID: 5928
		[AccessedThroughProperty("Est_TX")]
		private TextBox _Est_TX;

		// Token: 0x04001729 RID: 5929
		[AccessedThroughProperty("Grupo_status")]
		private GroupBox _Grupo_status;

		// Token: 0x0400172A RID: 5930
		[AccessedThroughProperty("Grupo_bomba3")]
		private GroupBox _Grupo_bomba3;

		// Token: 0x0400172B RID: 5931
		[AccessedThroughProperty("Modo_b3")]
		private TextBox _Modo_b3;

		// Token: 0x0400172C RID: 5932
		[AccessedThroughProperty("Label_modo_b3")]
		private Label _Label_modo_b3;

		// Token: 0x0400172D RID: 5933
		[AccessedThroughProperty("Cmd_manual_b3")]
		private Button _Cmd_manual_b3;

		// Token: 0x0400172E RID: 5934
		[AccessedThroughProperty("Cmd_desliga_b3")]
		private Button _Cmd_desliga_b3;

		// Token: 0x0400172F RID: 5935
		[AccessedThroughProperty("Cmd_liga_b3")]
		private Button _Cmd_liga_b3;

		// Token: 0x04001730 RID: 5936
		[AccessedThroughProperty("Label_status_b3")]
		private Label _Label_status_b3;

		// Token: 0x04001731 RID: 5937
		[AccessedThroughProperty("Cmd_automatico_b3")]
		private Button _Cmd_automatico_b3;

		// Token: 0x04001732 RID: 5938
		[AccessedThroughProperty("Status_b3")]
		private TextBox _Status_b3;

		// Token: 0x04001733 RID: 5939
		[AccessedThroughProperty("Grupo_bomba2")]
		private GroupBox _Grupo_bomba2;

		// Token: 0x04001734 RID: 5940
		[AccessedThroughProperty("Modo_b2")]
		private TextBox _Modo_b2;

		// Token: 0x04001735 RID: 5941
		[AccessedThroughProperty("Label_modo_b2")]
		private Label _Label_modo_b2;

		// Token: 0x04001736 RID: 5942
		[AccessedThroughProperty("Cmd_manual_b2")]
		private Button _Cmd_manual_b2;

		// Token: 0x04001737 RID: 5943
		[AccessedThroughProperty("Cmd_desliga_b2")]
		private Button _Cmd_desliga_b2;

		// Token: 0x04001738 RID: 5944
		[AccessedThroughProperty("Cmd_liga_b2")]
		private Button _Cmd_liga_b2;

		// Token: 0x04001739 RID: 5945
		[AccessedThroughProperty("Cmd_automatico_b2")]
		private Button _Cmd_automatico_b2;

		// Token: 0x0400173A RID: 5946
		[AccessedThroughProperty("Label_status_b2")]
		private Label _Label_status_b2;

		// Token: 0x0400173B RID: 5947
		[AccessedThroughProperty("Status_b2")]
		private TextBox _Status_b2;

		// Token: 0x0400173C RID: 5948
		[AccessedThroughProperty("Grupo_bomba1")]
		private GroupBox _Grupo_bomba1;

		// Token: 0x0400173D RID: 5949
		[AccessedThroughProperty("Modo_b1")]
		private TextBox _Modo_b1;

		// Token: 0x0400173E RID: 5950
		[AccessedThroughProperty("Cmd_manual_b1")]
		private Button _Cmd_manual_b1;

		// Token: 0x0400173F RID: 5951
		[AccessedThroughProperty("Cmd_desliga_b1")]
		private Button _Cmd_desliga_b1;

		// Token: 0x04001740 RID: 5952
		[AccessedThroughProperty("Cmd_automatico_b1")]
		private Button _Cmd_automatico_b1;

		// Token: 0x04001741 RID: 5953
		[AccessedThroughProperty("Cmd_liga_b1")]
		private Button _Cmd_liga_b1;

		// Token: 0x04001742 RID: 5954
		[AccessedThroughProperty("Label_modo_b1")]
		private Label _Label_modo_b1;

		// Token: 0x04001743 RID: 5955
		[AccessedThroughProperty("Label_status_b1")]
		private Label _Label_status_b1;

		// Token: 0x04001744 RID: 5956
		[AccessedThroughProperty("Status_b1")]
		private TextBox _Status_b1;

		// Token: 0x04001745 RID: 5957
		[AccessedThroughProperty("Grupo_escrita_de_dados")]
		private GroupBox _Grupo_escrita_de_dados;

		// Token: 0x04001746 RID: 5958
		[AccessedThroughProperty("Tela_nivel_destino")]
		private NumericUpDown _Tela_nivel_destino;

		// Token: 0x04001747 RID: 5959
		[AccessedThroughProperty("Label_nivel_destino")]
		private Label _Label_nivel_destino;

		// Token: 0x04001748 RID: 5960
		[AccessedThroughProperty("Valor_NivelDesejado")]
		private TextBox _Valor_NivelDesejado;

		// Token: 0x04001749 RID: 5961
		[AccessedThroughProperty("Label_NivelDesejado")]
		private Label _Label_NivelDesejado;

		// Token: 0x0400174A RID: 5962
		[AccessedThroughProperty("Valor_NivelB1")]
		private TextBox _Valor_NivelB1;

		// Token: 0x0400174B RID: 5963
		[AccessedThroughProperty("Label_NivelB1")]
		private Label _Label_NivelB1;

		// Token: 0x0400174C RID: 5964
		[AccessedThroughProperty("Valor_PressaoRec")]
		private TextBox _Valor_PressaoRec;

		// Token: 0x0400174D RID: 5965
		[AccessedThroughProperty("Label_PressaoRec")]
		private Label _Label_PressaoRec;

		// Token: 0x0400174E RID: 5966
		[AccessedThroughProperty("Valor_TempoMaisUmaBomba")]
		private TextBox _Valor_TempoMaisUmaBomba;

		// Token: 0x0400174F RID: 5967
		[AccessedThroughProperty("Label_TempoMaisUmaBomba")]
		private Label _Label_TempoMaisUmaBomba;

		// Token: 0x04001750 RID: 5968
		[AccessedThroughProperty("Valor_NivelB4")]
		private TextBox _Valor_NivelB4;

		// Token: 0x04001751 RID: 5969
		[AccessedThroughProperty("Label_NivelB4")]
		private Label _Label_NivelB4;

		// Token: 0x04001752 RID: 5970
		[AccessedThroughProperty("Valor_NivelB3")]
		private TextBox _Valor_NivelB3;

		// Token: 0x04001753 RID: 5971
		[AccessedThroughProperty("Label_NivelB3")]
		private Label _Label_NivelB3;

		// Token: 0x04001754 RID: 5972
		[AccessedThroughProperty("Valor_NivelB2")]
		private TextBox _Valor_NivelB2;

		// Token: 0x04001755 RID: 5973
		[AccessedThroughProperty("Label_NivelB2")]
		private Label _Label_NivelB2;

		// Token: 0x04001756 RID: 5974
		[AccessedThroughProperty("Valor_Niveldesliga")]
		private TextBox _Valor_Niveldesliga;

		// Token: 0x04001757 RID: 5975
		[AccessedThroughProperty("Label_NivelDesliga")]
		private Label _Label_NivelDesliga;

		// Token: 0x04001758 RID: 5976
		[AccessedThroughProperty("Valor_NivelLiga")]
		private TextBox _Valor_NivelLiga;

		// Token: 0x04001759 RID: 5977
		[AccessedThroughProperty("Label_NivelLiga")]
		private Label _Label_NivelLiga;

		// Token: 0x0400175A RID: 5978
		[AccessedThroughProperty("Valor_PressaoSuc")]
		private TextBox _Valor_PressaoSuc;

		// Token: 0x0400175B RID: 5979
		[AccessedThroughProperty("Label_PressaoSuc")]
		private Label _Label_PressaoSuc;

		// Token: 0x0400175C RID: 5980
		[AccessedThroughProperty("Grupo_alarmes")]
		private GroupBox _Grupo_alarmes;

		// Token: 0x0400175D RID: 5981
		[AccessedThroughProperty("CheckBox_Alm_alagamento_status")]
		private CheckBox _CheckBox_Alm_alagamento_status;

		// Token: 0x0400175E RID: 5982
		[AccessedThroughProperty("CheckBox_Alm_ope_bat_status")]
		private CheckBox _CheckBox_Alm_ope_bat_status;

		// Token: 0x0400175F RID: 5983
		[AccessedThroughProperty("CheckBox_Alm_arrombamento_status")]
		private CheckBox _CheckBox_Alm_arrombamento_status;

		// Token: 0x04001760 RID: 5984
		[AccessedThroughProperty("Grupo_bomba4")]
		private GroupBox _Grupo_bomba4;

		// Token: 0x04001761 RID: 5985
		[AccessedThroughProperty("Modo_b4")]
		private TextBox _Modo_b4;

		// Token: 0x04001762 RID: 5986
		[AccessedThroughProperty("Label_modo_b4")]
		private Label _Label_modo_b4;

		// Token: 0x04001763 RID: 5987
		[AccessedThroughProperty("Cmd_manual_b4")]
		private Button _Cmd_manual_b4;

		// Token: 0x04001764 RID: 5988
		[AccessedThroughProperty("Cmd_desliga_b4")]
		private Button _Cmd_desliga_b4;

		// Token: 0x04001765 RID: 5989
		[AccessedThroughProperty("Cmd_liga_b4")]
		private Button _Cmd_liga_b4;

		// Token: 0x04001766 RID: 5990
		[AccessedThroughProperty("Label_status_b4")]
		private Label _Label_status_b4;

		// Token: 0x04001767 RID: 5991
		[AccessedThroughProperty("Cmd_automatico_b4")]
		private Button _Cmd_automatico_b4;

		// Token: 0x04001768 RID: 5992
		[AccessedThroughProperty("Status_b4")]
		private TextBox _Status_b4;

		// Token: 0x04001769 RID: 5993
		[AccessedThroughProperty("Label_EA1")]
		private Label _Label_EA1;

		// Token: 0x0400176A RID: 5994
		[AccessedThroughProperty("Valor_EA1")]
		private TextBox _Valor_EA1;

		// Token: 0x0400176B RID: 5995
		[AccessedThroughProperty("Label_EA2")]
		private Label _Label_EA2;

		// Token: 0x0400176C RID: 5996
		[AccessedThroughProperty("Valor_EA2")]
		private TextBox _Valor_EA2;

		// Token: 0x0400176D RID: 5997
		[AccessedThroughProperty("Label_EA3")]
		private Label _Label_EA3;

		// Token: 0x0400176E RID: 5998
		[AccessedThroughProperty("Valor_EA3")]
		private TextBox _Valor_EA3;

		// Token: 0x0400176F RID: 5999
		[AccessedThroughProperty("Label_EA4")]
		private Label _Label_EA4;

		// Token: 0x04001770 RID: 6000
		[AccessedThroughProperty("Valor_EA4")]
		private TextBox _Valor_EA4;

		// Token: 0x04001771 RID: 6001
		[AccessedThroughProperty("Label_EA5")]
		private Label _Label_EA5;

		// Token: 0x04001772 RID: 6002
		[AccessedThroughProperty("Valor_EA5")]
		private TextBox _Valor_EA5;

		// Token: 0x04001773 RID: 6003
		[AccessedThroughProperty("Label_EA6")]
		private Label _Label_EA6;

		// Token: 0x04001774 RID: 6004
		[AccessedThroughProperty("Valor_EA6")]
		private TextBox _Valor_EA6;

		// Token: 0x04001775 RID: 6005
		[AccessedThroughProperty("Label_EA7")]
		private Label _Label_EA7;

		// Token: 0x04001776 RID: 6006
		[AccessedThroughProperty("Valor_EA7")]
		private TextBox _Valor_EA7;

		// Token: 0x04001777 RID: 6007
		[AccessedThroughProperty("Label_EA8")]
		private Label _Label_EA8;

		// Token: 0x04001778 RID: 6008
		[AccessedThroughProperty("Valor_EA8")]
		private TextBox _Valor_EA8;

		// Token: 0x04001779 RID: 6009
		[AccessedThroughProperty("Grupo_medidas")]
		private GroupBox _Grupo_medidas;

		// Token: 0x0400177A RID: 6010
		[AccessedThroughProperty("Valor_EA16")]
		private TextBox _Valor_EA16;

		// Token: 0x0400177B RID: 6011
		[AccessedThroughProperty("Label_EA16")]
		private Label _Label_EA16;

		// Token: 0x0400177C RID: 6012
		[AccessedThroughProperty("Valor_EA15")]
		private TextBox _Valor_EA15;

		// Token: 0x0400177D RID: 6013
		[AccessedThroughProperty("Label_EA15")]
		private Label _Label_EA15;

		// Token: 0x0400177E RID: 6014
		[AccessedThroughProperty("Valor_EA14")]
		private TextBox _Valor_EA14;

		// Token: 0x0400177F RID: 6015
		[AccessedThroughProperty("Label_EA14")]
		private Label _Label_EA14;

		// Token: 0x04001780 RID: 6016
		[AccessedThroughProperty("Valor_EA13")]
		private TextBox _Valor_EA13;

		// Token: 0x04001781 RID: 6017
		[AccessedThroughProperty("Label_EA13")]
		private Label _Label_EA13;

		// Token: 0x04001782 RID: 6018
		[AccessedThroughProperty("Valor_EA12")]
		private TextBox _Valor_EA12;

		// Token: 0x04001783 RID: 6019
		[AccessedThroughProperty("Label_EA12")]
		private Label _Label_EA12;

		// Token: 0x04001784 RID: 6020
		[AccessedThroughProperty("Valor_EA11")]
		private TextBox _Valor_EA11;

		// Token: 0x04001785 RID: 6021
		[AccessedThroughProperty("Label_EA11")]
		private Label _Label_EA11;

		// Token: 0x04001786 RID: 6022
		[AccessedThroughProperty("Valor_EA10")]
		private TextBox _Valor_EA10;

		// Token: 0x04001787 RID: 6023
		[AccessedThroughProperty("Label_EA10")]
		private Label _Label_EA10;

		// Token: 0x04001788 RID: 6024
		[AccessedThroughProperty("Valor_EA9")]
		private TextBox _Valor_EA9;

		// Token: 0x04001789 RID: 6025
		[AccessedThroughProperty("Label_EA9")]
		private Label _Label_EA9;

		// Token: 0x0400178A RID: 6026
		[AccessedThroughProperty("Tela_nivel_origem")]
		private NumericUpDown _Tela_nivel_origem;

		// Token: 0x0400178B RID: 6027
		[AccessedThroughProperty("Label_nivel_origem")]
		private Label _Label_nivel_origem;

		// Token: 0x0400178C RID: 6028
		[AccessedThroughProperty("Cmd_falha_b4")]
		private Button _Cmd_falha_b4;

		// Token: 0x0400178D RID: 6029
		[AccessedThroughProperty("Cmd_falha_b1")]
		private Button _Cmd_falha_b1;

		// Token: 0x0400178E RID: 6030
		[AccessedThroughProperty("Cmd_falha_b3")]
		private Button _Cmd_falha_b3;

		// Token: 0x0400178F RID: 6031
		[AccessedThroughProperty("Cmd_falha_b2")]
		private Button _Cmd_falha_b2;

		// Token: 0x04001790 RID: 6032
		[AccessedThroughProperty("CheckBox_Alm_ff_status")]
		private CheckBox _CheckBox_Alm_ff_status;

		// Token: 0x04001791 RID: 6033
		[AccessedThroughProperty("CheckBox_Alm_bat_bx_status")]
		private CheckBox _CheckBox_Alm_bat_bx_status;

		// Token: 0x04001792 RID: 6034
		[AccessedThroughProperty("msg_modo_operacao")]
		private TextBox _msg_modo_operacao;

		// Token: 0x04001793 RID: 6035
		public const int DADOS_FORMATO_200 = 1;

		// Token: 0x04001794 RID: 6036
		public const int DADOS_FORMATO_200_4000 = 2;

		// Token: 0x04001795 RID: 6037
		public const int DADOS_FORMATO_4000 = 3;

		// Token: 0x04001796 RID: 6038
		public const int OFFSET_END = 3;

		// Token: 0x04001797 RID: 6039
		public const int MASCARA_ALM_ALAGAMENTO_202 = 16;

		// Token: 0x04001798 RID: 6040
		public const int MASCARA_ALM_ARROMBAMENTO_202 = 8;

		// Token: 0x04001799 RID: 6041
		public const int MASCARA_ALM_FF_202 = 4;

		// Token: 0x0400179A RID: 6042
		public const int MASCARA_ALM_BAT_BAIXA_202 = 2;

		// Token: 0x0400179B RID: 6043
		public const int MASCARA_ALM_OPERANDO_BAT_202 = 1;

		// Token: 0x0400179C RID: 6044
		public string[] Msg_status_202;

		// Token: 0x0400179D RID: 6045
		public string[] Msg_modo_bomba_202;

		// Token: 0x0400179E RID: 6046
		public string[] Msg_modo_placa_202;

		// Token: 0x02000086 RID: 134
		public struct HAB_CTRL
		{
			// Token: 0x0400179F RID: 6047
			public bool Tecla_auto;

			// Token: 0x040017A0 RID: 6048
			public bool Tecla_man;

			// Token: 0x040017A1 RID: 6049
			public bool Tecla_liga;

			// Token: 0x040017A2 RID: 6050
			public bool Tecla_desliga;

			// Token: 0x040017A3 RID: 6051
			public bool Tecla_falha;

			// Token: 0x040017A4 RID: 6052
			public string status;

			// Token: 0x040017A5 RID: 6053
			public string modo_motor;

			// Token: 0x040017A6 RID: 6054
			public string modo_placa;
		}
	}
}
