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
	// Token: 0x0200009C RID: 156
	[DesignerGenerated]
	public partial class Equip_VA220_conf : Form
	{
		// Token: 0x06002497 RID: 9367 RVA: 0x0040D450 File Offset: 0x0040B850
		public Equip_VA220_conf()
		{
			base.Load += new EventHandler(this.Equip_va220_conf_Load);
			this.InitializeComponent();
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x0600249A RID: 9370 RVA: 0x0040F5F0 File Offset: 0x0040D9F0
		// (set) Token: 0x0600249B RID: 9371 RVA: 0x0040F604 File Offset: 0x0040DA04
		internal virtual GroupBox grupo_parametros_gerais
		{
			get
			{
				return this._grupo_parametros_gerais;
			}
			[MethodImpl(32)]
			set
			{
				this._grupo_parametros_gerais = value;
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x0600249C RID: 9372 RVA: 0x0040F610 File Offset: 0x0040DA10
		// (set) Token: 0x0600249D RID: 9373 RVA: 0x0040F624 File Offset: 0x0040DA24
		internal virtual TextBox Valor_temp_ptt
		{
			get
			{
				return this._Valor_temp_ptt;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_temp_ptt_Validating);
				if (this._Valor_temp_ptt != null)
				{
					this._Valor_temp_ptt.Validating -= cancelEventHandler;
				}
				this._Valor_temp_ptt = value;
				if (this._Valor_temp_ptt != null)
				{
					this._Valor_temp_ptt.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x0600249E RID: 9374 RVA: 0x0040F670 File Offset: 0x0040DA70
		// (set) Token: 0x0600249F RID: 9375 RVA: 0x0040F684 File Offset: 0x0040DA84
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

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x0040F690 File Offset: 0x0040DA90
		// (set) Token: 0x060024A1 RID: 9377 RVA: 0x0040F6A4 File Offset: 0x0040DAA4
		internal virtual TextBox Valor_end_mestre
		{
			get
			{
				return this._Valor_end_mestre;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_end_mestre_Validating);
				if (this._Valor_end_mestre != null)
				{
					this._Valor_end_mestre.Validating -= cancelEventHandler;
				}
				this._Valor_end_mestre = value;
				if (this._Valor_end_mestre != null)
				{
					this._Valor_end_mestre.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x0040F6F0 File Offset: 0x0040DAF0
		// (set) Token: 0x060024A3 RID: 9379 RVA: 0x0040F704 File Offset: 0x0040DB04
		internal virtual TextBox Valor_end_est
		{
			get
			{
				return this._Valor_end_est;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_end_est_Validating);
				if (this._Valor_end_est != null)
				{
					this._Valor_end_est.Validating -= cancelEventHandler;
				}
				this._Valor_end_est = value;
				if (this._Valor_end_est != null)
				{
					this._Valor_end_est.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x060024A4 RID: 9380 RVA: 0x0040F750 File Offset: 0x0040DB50
		// (set) Token: 0x060024A5 RID: 9381 RVA: 0x0040F764 File Offset: 0x0040DB64
		internal virtual Label Label_end_mestre
		{
			get
			{
				return this._Label_end_mestre;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_mestre = value;
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x060024A6 RID: 9382 RVA: 0x0040F770 File Offset: 0x0040DB70
		// (set) Token: 0x060024A7 RID: 9383 RVA: 0x0040F784 File Offset: 0x0040DB84
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

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x060024A8 RID: 9384 RVA: 0x0040F790 File Offset: 0x0040DB90
		// (set) Token: 0x060024A9 RID: 9385 RVA: 0x0040F7A4 File Offset: 0x0040DBA4
		internal virtual GroupBox Grupo_ctrl
		{
			get
			{
				return this._Grupo_ctrl;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_ctrl = value;
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x060024AA RID: 9386 RVA: 0x0040F7B0 File Offset: 0x0040DBB0
		// (set) Token: 0x060024AB RID: 9387 RVA: 0x0040F7C4 File Offset: 0x0040DBC4
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

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x060024AC RID: 9388 RVA: 0x0040F7D0 File Offset: 0x0040DBD0
		// (set) Token: 0x060024AD RID: 9389 RVA: 0x0040F7E4 File Offset: 0x0040DBE4
		internal virtual Button Ler_conf_VA220
		{
			get
			{
				return this._Ler_conf_VA220;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Ler_conf_VA220_Click);
				if (this._Ler_conf_VA220 != null)
				{
					this._Ler_conf_VA220.Click -= eventHandler;
				}
				this._Ler_conf_VA220 = value;
				if (this._Ler_conf_VA220 != null)
				{
					this._Ler_conf_VA220.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x060024AE RID: 9390 RVA: 0x0040F830 File Offset: 0x0040DC30
		// (set) Token: 0x060024AF RID: 9391 RVA: 0x0040F844 File Offset: 0x0040DC44
		internal virtual Label Label_Max_bombas
		{
			get
			{
				return this._Label_Max_bombas;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_Max_bombas = value;
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x060024B0 RID: 9392 RVA: 0x0040F850 File Offset: 0x0040DC50
		// (set) Token: 0x060024B1 RID: 9393 RVA: 0x0040F864 File Offset: 0x0040DC64
		internal virtual TextBox Valor_max_bombas
		{
			get
			{
				return this._Valor_max_bombas;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_max_bombas_Validating);
				if (this._Valor_max_bombas != null)
				{
					this._Valor_max_bombas.Validating -= cancelEventHandler;
				}
				this._Valor_max_bombas = value;
				if (this._Valor_max_bombas != null)
				{
					this._Valor_max_bombas.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x0040F8B0 File Offset: 0x0040DCB0
		// (set) Token: 0x060024B3 RID: 9395 RVA: 0x0040F8C4 File Offset: 0x0040DCC4
		internal virtual Label Label_tempo_falha_ligar_motor
		{
			get
			{
				return this._Label_tempo_falha_ligar_motor;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_falha_ligar_motor = value;
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x060024B4 RID: 9396 RVA: 0x0040F8D0 File Offset: 0x0040DCD0
		// (set) Token: 0x060024B5 RID: 9397 RVA: 0x0040F8E4 File Offset: 0x0040DCE4
		internal virtual TextBox Valor_tempo_falha_ligar_motor
		{
			get
			{
				return this._Valor_tempo_falha_ligar_motor;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_tempo_falha_ligar_motor_Validating);
				if (this._Valor_tempo_falha_ligar_motor != null)
				{
					this._Valor_tempo_falha_ligar_motor.Validating -= cancelEventHandler;
				}
				this._Valor_tempo_falha_ligar_motor = value;
				if (this._Valor_tempo_falha_ligar_motor != null)
				{
					this._Valor_tempo_falha_ligar_motor.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x0040F930 File Offset: 0x0040DD30
		// (set) Token: 0x060024B7 RID: 9399 RVA: 0x0040F944 File Offset: 0x0040DD44
		internal virtual Label Label_tempo_falha_desligar_motor
		{
			get
			{
				return this._Label_tempo_falha_desligar_motor;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_falha_desligar_motor = value;
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x0040F950 File Offset: 0x0040DD50
		// (set) Token: 0x060024B9 RID: 9401 RVA: 0x0040F964 File Offset: 0x0040DD64
		internal virtual TextBox Valor_tempo_falha_desligar_motor
		{
			get
			{
				return this._Valor_tempo_falha_desligar_motor;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_tempo_falha_desligar_motor_Validating);
				if (this._Valor_tempo_falha_desligar_motor != null)
				{
					this._Valor_tempo_falha_desligar_motor.Validating -= cancelEventHandler;
				}
				this._Valor_tempo_falha_desligar_motor = value;
				if (this._Valor_tempo_falha_desligar_motor != null)
				{
					this._Valor_tempo_falha_desligar_motor.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x0040F9B0 File Offset: 0x0040DDB0
		// (set) Token: 0x060024BB RID: 9403 RVA: 0x0040F9C4 File Offset: 0x0040DDC4
		internal virtual Label Label_tempo_minimo_motor_ligado
		{
			get
			{
				return this._Label_tempo_minimo_motor_ligado;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_minimo_motor_ligado = value;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x0040F9D0 File Offset: 0x0040DDD0
		// (set) Token: 0x060024BD RID: 9405 RVA: 0x0040F9E4 File Offset: 0x0040DDE4
		internal virtual TextBox Valor_tempo_motor_operando
		{
			get
			{
				return this._Valor_tempo_motor_operando;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_tempo_motor_operando_Validating);
				if (this._Valor_tempo_motor_operando != null)
				{
					this._Valor_tempo_motor_operando.Validating -= cancelEventHandler;
				}
				this._Valor_tempo_motor_operando = value;
				if (this._Valor_tempo_motor_operando != null)
				{
					this._Valor_tempo_motor_operando.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x0040FA30 File Offset: 0x0040DE30
		// (set) Token: 0x060024BF RID: 9407 RVA: 0x0040FA44 File Offset: 0x0040DE44
		internal virtual Label Label_tempo_minimo_motor_parado
		{
			get
			{
				return this._Label_tempo_minimo_motor_parado;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_minimo_motor_parado = value;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x060024C0 RID: 9408 RVA: 0x0040FA50 File Offset: 0x0040DE50
		// (set) Token: 0x060024C1 RID: 9409 RVA: 0x0040FA64 File Offset: 0x0040DE64
		internal virtual TextBox Valor_tempo_motor_parado
		{
			get
			{
				return this._Valor_tempo_motor_parado;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_tempo_motor_parado_Validating);
				if (this._Valor_tempo_motor_parado != null)
				{
					this._Valor_tempo_motor_parado.Validating -= cancelEventHandler;
				}
				this._Valor_tempo_motor_parado = value;
				if (this._Valor_tempo_motor_parado != null)
				{
					this._Valor_tempo_motor_parado.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x0040FAB0 File Offset: 0x0040DEB0
		// (set) Token: 0x060024C3 RID: 9411 RVA: 0x0040FAC4 File Offset: 0x0040DEC4
		internal virtual Label Label_tempo_entre_acionamentos
		{
			get
			{
				return this._Label_tempo_entre_acionamentos;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_entre_acionamentos = value;
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x0040FAD0 File Offset: 0x0040DED0
		// (set) Token: 0x060024C5 RID: 9413 RVA: 0x0040FAE4 File Offset: 0x0040DEE4
		internal virtual TextBox Valor_tempo_entre_acionamentos
		{
			get
			{
				return this._Valor_tempo_entre_acionamentos;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_tempo_entre_acionamentos_Validating);
				if (this._Valor_tempo_entre_acionamentos != null)
				{
					this._Valor_tempo_entre_acionamentos.Validating -= cancelEventHandler;
				}
				this._Valor_tempo_entre_acionamentos = value;
				if (this._Valor_tempo_entre_acionamentos != null)
				{
					this._Valor_tempo_entre_acionamentos.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x0040FB30 File Offset: 0x0040DF30
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x0040FB44 File Offset: 0x0040DF44
		internal virtual ComboBox ComboBox_modo_operacao
		{
			get
			{
				return this._ComboBox_modo_operacao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_modo_operacao_SelectedIndexChanged);
				if (this._ComboBox_modo_operacao != null)
				{
					this._ComboBox_modo_operacao.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_modo_operacao = value;
				if (this._ComboBox_modo_operacao != null)
				{
					this._ComboBox_modo_operacao.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x0040FB90 File Offset: 0x0040DF90
		// (set) Token: 0x060024C9 RID: 9417 RVA: 0x0040FBA4 File Offset: 0x0040DFA4
		internal virtual Label Label_modo_operacao
		{
			get
			{
				return this._Label_modo_operacao;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_modo_operacao = value;
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x0040FBB0 File Offset: 0x0040DFB0
		// (set) Token: 0x060024CB RID: 9419 RVA: 0x0040FBC4 File Offset: 0x0040DFC4
		internal virtual ComboBox ComboBox_controle_nivel
		{
			get
			{
				return this._ComboBox_controle_nivel;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_controle_nivel_SelectedIndexChanged);
				if (this._ComboBox_controle_nivel != null)
				{
					this._ComboBox_controle_nivel.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_controle_nivel = value;
				if (this._ComboBox_controle_nivel != null)
				{
					this._ComboBox_controle_nivel.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x0040FC10 File Offset: 0x0040E010
		// (set) Token: 0x060024CD RID: 9421 RVA: 0x0040FC24 File Offset: 0x0040E024
		internal virtual Label Label_controle_nivel
		{
			get
			{
				return this._Label_controle_nivel;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_controle_nivel = value;
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x060024CE RID: 9422 RVA: 0x0040FC30 File Offset: 0x0040E030
		// (set) Token: 0x060024CF RID: 9423 RVA: 0x0040FC44 File Offset: 0x0040E044
		internal virtual GroupBox grupo_programacao_io
		{
			get
			{
				return this._grupo_programacao_io;
			}
			[MethodImpl(32)]
			set
			{
				this._grupo_programacao_io = value;
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x060024D0 RID: 9424 RVA: 0x0040FC50 File Offset: 0x0040E050
		// (set) Token: 0x060024D1 RID: 9425 RVA: 0x0040FC64 File Offset: 0x0040E064
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

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x0040FC70 File Offset: 0x0040E070
		// (set) Token: 0x060024D3 RID: 9427 RVA: 0x0040FC84 File Offset: 0x0040E084
		internal virtual ComboBox ComboBox_E01
		{
			get
			{
				return this._ComboBox_E01;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_E01_SelectedIndexChanged);
				if (this._ComboBox_E01 != null)
				{
					this._ComboBox_E01.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_E01 = value;
				if (this._ComboBox_E01 != null)
				{
					this._ComboBox_E01.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x0040FCD0 File Offset: 0x0040E0D0
		// (set) Token: 0x060024D5 RID: 9429 RVA: 0x0040FCE4 File Offset: 0x0040E0E4
		internal virtual Label Label_E08
		{
			get
			{
				return this._Label_E08;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_E08 = value;
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x0040FCF0 File Offset: 0x0040E0F0
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x0040FD04 File Offset: 0x0040E104
		internal virtual Label Label_E07
		{
			get
			{
				return this._Label_E07;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_E07 = value;
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x0040FD10 File Offset: 0x0040E110
		// (set) Token: 0x060024D9 RID: 9433 RVA: 0x0040FD24 File Offset: 0x0040E124
		internal virtual Label Label_E06
		{
			get
			{
				return this._Label_E06;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_E06 = value;
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x060024DA RID: 9434 RVA: 0x0040FD30 File Offset: 0x0040E130
		// (set) Token: 0x060024DB RID: 9435 RVA: 0x0040FD44 File Offset: 0x0040E144
		internal virtual Label Label_E05
		{
			get
			{
				return this._Label_E05;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_E05 = value;
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x0040FD50 File Offset: 0x0040E150
		// (set) Token: 0x060024DD RID: 9437 RVA: 0x0040FD64 File Offset: 0x0040E164
		internal virtual Label Label_E04
		{
			get
			{
				return this._Label_E04;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_E04 = value;
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x0040FD70 File Offset: 0x0040E170
		// (set) Token: 0x060024DF RID: 9439 RVA: 0x0040FD84 File Offset: 0x0040E184
		internal virtual Label Label_E03
		{
			get
			{
				return this._Label_E03;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_E03 = value;
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x060024E0 RID: 9440 RVA: 0x0040FD90 File Offset: 0x0040E190
		// (set) Token: 0x060024E1 RID: 9441 RVA: 0x0040FDA4 File Offset: 0x0040E1A4
		internal virtual Label Label_E02
		{
			get
			{
				return this._Label_E02;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_E02 = value;
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x060024E2 RID: 9442 RVA: 0x0040FDB0 File Offset: 0x0040E1B0
		// (set) Token: 0x060024E3 RID: 9443 RVA: 0x0040FDC4 File Offset: 0x0040E1C4
		internal virtual Label Label_E01
		{
			get
			{
				return this._Label_E01;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_E01 = value;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x0040FDD0 File Offset: 0x0040E1D0
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x0040FDE4 File Offset: 0x0040E1E4
		internal virtual ComboBox ComboBox_E08
		{
			get
			{
				return this._ComboBox_E08;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_E08_SelectedIndexChanged);
				if (this._ComboBox_E08 != null)
				{
					this._ComboBox_E08.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_E08 = value;
				if (this._ComboBox_E08 != null)
				{
					this._ComboBox_E08.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x0040FE30 File Offset: 0x0040E230
		// (set) Token: 0x060024E7 RID: 9447 RVA: 0x0040FE44 File Offset: 0x0040E244
		internal virtual ComboBox ComboBox_E07
		{
			get
			{
				return this._ComboBox_E07;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_E07_SelectedIndexChanged);
				if (this._ComboBox_E07 != null)
				{
					this._ComboBox_E07.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_E07 = value;
				if (this._ComboBox_E07 != null)
				{
					this._ComboBox_E07.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x0040FE90 File Offset: 0x0040E290
		// (set) Token: 0x060024E9 RID: 9449 RVA: 0x0040FEA4 File Offset: 0x0040E2A4
		internal virtual ComboBox ComboBox_E06
		{
			get
			{
				return this._ComboBox_E06;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_E06_SelectedIndexChanged);
				if (this._ComboBox_E06 != null)
				{
					this._ComboBox_E06.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_E06 = value;
				if (this._ComboBox_E06 != null)
				{
					this._ComboBox_E06.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x0040FEF0 File Offset: 0x0040E2F0
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x0040FF04 File Offset: 0x0040E304
		internal virtual ComboBox ComboBox_E05
		{
			get
			{
				return this._ComboBox_E05;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_E05_SelectedIndexChanged);
				if (this._ComboBox_E05 != null)
				{
					this._ComboBox_E05.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_E05 = value;
				if (this._ComboBox_E05 != null)
				{
					this._ComboBox_E05.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x0040FF50 File Offset: 0x0040E350
		// (set) Token: 0x060024ED RID: 9453 RVA: 0x0040FF64 File Offset: 0x0040E364
		internal virtual ComboBox ComboBox_E04
		{
			get
			{
				return this._ComboBox_E04;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_E04_SelectedIndexChanged);
				if (this._ComboBox_E04 != null)
				{
					this._ComboBox_E04.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_E04 = value;
				if (this._ComboBox_E04 != null)
				{
					this._ComboBox_E04.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x0040FFB0 File Offset: 0x0040E3B0
		// (set) Token: 0x060024EF RID: 9455 RVA: 0x0040FFC4 File Offset: 0x0040E3C4
		internal virtual ComboBox ComboBox_E03
		{
			get
			{
				return this._ComboBox_E03;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_E03_SelectedIndexChanged);
				if (this._ComboBox_E03 != null)
				{
					this._ComboBox_E03.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_E03 = value;
				if (this._ComboBox_E03 != null)
				{
					this._ComboBox_E03.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x00410010 File Offset: 0x0040E410
		// (set) Token: 0x060024F1 RID: 9457 RVA: 0x00410024 File Offset: 0x0040E424
		internal virtual ComboBox ComboBox_E02
		{
			get
			{
				return this._ComboBox_E02;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_E02_SelectedIndexChanged);
				if (this._ComboBox_E02 != null)
				{
					this._ComboBox_E02.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_E02 = value;
				if (this._ComboBox_E02 != null)
				{
					this._ComboBox_E02.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x00410070 File Offset: 0x0040E470
		// (set) Token: 0x060024F3 RID: 9459 RVA: 0x00410084 File Offset: 0x0040E484
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

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x00410090 File Offset: 0x0040E490
		// (set) Token: 0x060024F5 RID: 9461 RVA: 0x004100A4 File Offset: 0x0040E4A4
		internal virtual ComboBox ComboBox_S08
		{
			get
			{
				return this._ComboBox_S08;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_S08_SelectedIndexChanged);
				if (this._ComboBox_S08 != null)
				{
					this._ComboBox_S08.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_S08 = value;
				if (this._ComboBox_S08 != null)
				{
					this._ComboBox_S08.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x004100F0 File Offset: 0x0040E4F0
		// (set) Token: 0x060024F7 RID: 9463 RVA: 0x00410104 File Offset: 0x0040E504
		internal virtual ComboBox ComboBox_S07
		{
			get
			{
				return this._ComboBox_S07;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_S07_SelectedIndexChanged);
				if (this._ComboBox_S07 != null)
				{
					this._ComboBox_S07.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_S07 = value;
				if (this._ComboBox_S07 != null)
				{
					this._ComboBox_S07.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x00410150 File Offset: 0x0040E550
		// (set) Token: 0x060024F9 RID: 9465 RVA: 0x00410164 File Offset: 0x0040E564
		internal virtual ComboBox ComboBox_S06
		{
			get
			{
				return this._ComboBox_S06;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_S06_SelectedIndexChanged);
				if (this._ComboBox_S06 != null)
				{
					this._ComboBox_S06.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_S06 = value;
				if (this._ComboBox_S06 != null)
				{
					this._ComboBox_S06.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x004101B0 File Offset: 0x0040E5B0
		// (set) Token: 0x060024FB RID: 9467 RVA: 0x004101C4 File Offset: 0x0040E5C4
		internal virtual ComboBox ComboBox_S05
		{
			get
			{
				return this._ComboBox_S05;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_S05_SelectedIndexChanged);
				if (this._ComboBox_S05 != null)
				{
					this._ComboBox_S05.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_S05 = value;
				if (this._ComboBox_S05 != null)
				{
					this._ComboBox_S05.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x060024FC RID: 9468 RVA: 0x00410210 File Offset: 0x0040E610
		// (set) Token: 0x060024FD RID: 9469 RVA: 0x00410224 File Offset: 0x0040E624
		internal virtual ComboBox ComboBox_S04
		{
			get
			{
				return this._ComboBox_S04;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_S04_SelectedIndexChanged);
				if (this._ComboBox_S04 != null)
				{
					this._ComboBox_S04.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_S04 = value;
				if (this._ComboBox_S04 != null)
				{
					this._ComboBox_S04.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x060024FE RID: 9470 RVA: 0x00410270 File Offset: 0x0040E670
		// (set) Token: 0x060024FF RID: 9471 RVA: 0x00410284 File Offset: 0x0040E684
		internal virtual ComboBox ComboBox_S03
		{
			get
			{
				return this._ComboBox_S03;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_S03_SelectedIndexChanged);
				if (this._ComboBox_S03 != null)
				{
					this._ComboBox_S03.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_S03 = value;
				if (this._ComboBox_S03 != null)
				{
					this._ComboBox_S03.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x004102D0 File Offset: 0x0040E6D0
		// (set) Token: 0x06002501 RID: 9473 RVA: 0x004102E4 File Offset: 0x0040E6E4
		internal virtual ComboBox ComboBox_S02
		{
			get
			{
				return this._ComboBox_S02;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_S02_SelectedIndexChanged);
				if (this._ComboBox_S02 != null)
				{
					this._ComboBox_S02.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_S02 = value;
				if (this._ComboBox_S02 != null)
				{
					this._ComboBox_S02.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06002502 RID: 9474 RVA: 0x00410330 File Offset: 0x0040E730
		// (set) Token: 0x06002503 RID: 9475 RVA: 0x00410344 File Offset: 0x0040E744
		internal virtual ComboBox ComboBox_S01
		{
			get
			{
				return this._ComboBox_S01;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_S01_SelectedIndexChanged);
				if (this._ComboBox_S01 != null)
				{
					this._ComboBox_S01.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_S01 = value;
				if (this._ComboBox_S01 != null)
				{
					this._ComboBox_S01.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06002504 RID: 9476 RVA: 0x00410390 File Offset: 0x0040E790
		// (set) Token: 0x06002505 RID: 9477 RVA: 0x004103A4 File Offset: 0x0040E7A4
		internal virtual Label Label_S08
		{
			get
			{
				return this._Label_S08;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_S08 = value;
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06002506 RID: 9478 RVA: 0x004103B0 File Offset: 0x0040E7B0
		// (set) Token: 0x06002507 RID: 9479 RVA: 0x004103C4 File Offset: 0x0040E7C4
		internal virtual Label Label_S07
		{
			get
			{
				return this._Label_S07;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_S07 = value;
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06002508 RID: 9480 RVA: 0x004103D0 File Offset: 0x0040E7D0
		// (set) Token: 0x06002509 RID: 9481 RVA: 0x004103E4 File Offset: 0x0040E7E4
		internal virtual Label Label_S06
		{
			get
			{
				return this._Label_S06;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_S06 = value;
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x0600250A RID: 9482 RVA: 0x004103F0 File Offset: 0x0040E7F0
		// (set) Token: 0x0600250B RID: 9483 RVA: 0x00410404 File Offset: 0x0040E804
		internal virtual Label Label_S05
		{
			get
			{
				return this._Label_S05;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_S05 = value;
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x0600250C RID: 9484 RVA: 0x00410410 File Offset: 0x0040E810
		// (set) Token: 0x0600250D RID: 9485 RVA: 0x00410424 File Offset: 0x0040E824
		internal virtual Label Label_S04
		{
			get
			{
				return this._Label_S04;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_S04 = value;
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x0600250E RID: 9486 RVA: 0x00410430 File Offset: 0x0040E830
		// (set) Token: 0x0600250F RID: 9487 RVA: 0x00410444 File Offset: 0x0040E844
		internal virtual Label Label_S03
		{
			get
			{
				return this._Label_S03;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_S03 = value;
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06002510 RID: 9488 RVA: 0x00410450 File Offset: 0x0040E850
		// (set) Token: 0x06002511 RID: 9489 RVA: 0x00410464 File Offset: 0x0040E864
		internal virtual Label Label_S02
		{
			get
			{
				return this._Label_S02;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_S02 = value;
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x00410470 File Offset: 0x0040E870
		// (set) Token: 0x06002513 RID: 9491 RVA: 0x00410484 File Offset: 0x0040E884
		internal virtual Label Label_S01
		{
			get
			{
				return this._Label_S01;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_S01 = value;
			}
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x00410490 File Offset: 0x0040E890
		private void Equip_va220_conf_Load(object sender, EventArgs e)
		{
			this.ComboBox_controle_nivel.Items.Clear();
			this.ComboBox_controle_nivel.Items.Add("Não");
			this.ComboBox_controle_nivel.Items.Add("Sim");
			this.ComboBox_modo_operacao.Items.Clear();
			this.ComboBox_modo_operacao.Items.Add("Manual");
			this.ComboBox_modo_operacao.Items.Add("Automático");
			this.ComboBox_modo_operacao.Items.Add("Timer");
			this.ComboBox_E01.Items.Clear();
			this.ComboBox_E01.Items.Add("N/C");
			this.ComboBox_E01.Items.Add("Retorno Motor 1");
			this.ComboBox_E01.Items.Add("Retorno Motor 2");
			this.ComboBox_E01.Items.Add("Retorno Motor 3");
			this.ComboBox_E01.Items.Add("Retorno Motor 4");
			this.ComboBox_E01.Items.Add("Retorno Val.Abert 1");
			this.ComboBox_E01.Items.Add("Retorno Val.Abert 2");
			this.ComboBox_E01.Items.Add("Retorno Val.Abert 3");
			this.ComboBox_E01.Items.Add("Retorno Val.Abert 4");
			this.ComboBox_E01.Items.Add("Retorno Val.Fecha 1");
			this.ComboBox_E01.Items.Add("Retorno Val.Fecha 2");
			this.ComboBox_E01.Items.Add("Retorno Val.Fecha 3");
			this.ComboBox_E01.Items.Add("Retorno Val.Fecha 4");
			this.ComboBox_E01.Items.Add("Retorno Val.Abert.Indep 1");
			this.ComboBox_E01.Items.Add("Retorno Val.Abert.Indep 2");
			this.ComboBox_E01.Items.Add("Retorno Val.Abert.Indep 3");
			this.ComboBox_E01.Items.Add("Retorno Val.Abert.Indep 4");
			this.ComboBox_E01.Items.Add("Retorno Val.Fecha.Indep 1");
			this.ComboBox_E01.Items.Add("Retorno Val.Fecha.Indep 2");
			this.ComboBox_E01.Items.Add("Retorno Val.Fecha.Indep 3");
			this.ComboBox_E01.Items.Add("Retorno Val.Fecha.Indep 4");
			this.ComboBox_E01.Items.Add("Retorno Motor c/ Val. Prop 1");
			this.ComboBox_E01.Items.Add("Retorno Motor c/ Val. Prop 2");
			this.ComboBox_E01.Items.Add("Retorno Motor c/ Val. Prop 3");
			this.ComboBox_E01.Items.Add("Retorno Motor c/ Val. Prop 4");
			this.ComboBox_E01.Items.Add("Arrombamento");
			this.ComboBox_E01.Items.Add("Faltas de Fase");
			this.ComboBox_E01.Items.Add("Alagamento");
			this.ComboBox_E01.Items.Add("Proteção - Nível Desliga");
			this.ComboBox_E01.Items.Add("Proteção - Nível Liga");
			this.ComboBox_E02.Items.Clear();
			this.ComboBox_E02.Items.Add("N/C");
			this.ComboBox_E02.Items.Add("Retorno Motor 1");
			this.ComboBox_E02.Items.Add("Retorno Motor 2");
			this.ComboBox_E02.Items.Add("Retorno Motor 3");
			this.ComboBox_E02.Items.Add("Retorno Motor 4");
			this.ComboBox_E02.Items.Add("Retorno Val.Abert 1");
			this.ComboBox_E02.Items.Add("Retorno Val.Abert 2");
			this.ComboBox_E02.Items.Add("Retorno Val.Abert 3");
			this.ComboBox_E02.Items.Add("Retorno Val.Abert 4");
			this.ComboBox_E02.Items.Add("Retorno Val.Fecha 1");
			this.ComboBox_E02.Items.Add("Retorno Val.Fecha 2");
			this.ComboBox_E02.Items.Add("Retorno Val.Fecha 3");
			this.ComboBox_E02.Items.Add("Retorno Val.Fecha 4");
			this.ComboBox_E02.Items.Add("Retorno Val.Abert.Indep 1");
			this.ComboBox_E02.Items.Add("Retorno Val.Abert.Indep 2");
			this.ComboBox_E02.Items.Add("Retorno Val.Abert.Indep 3");
			this.ComboBox_E02.Items.Add("Retorno Val.Abert.Indep 4");
			this.ComboBox_E02.Items.Add("Retorno Val.Fecha.Indep 1");
			this.ComboBox_E02.Items.Add("Retorno Val.Fecha.Indep 2");
			this.ComboBox_E02.Items.Add("Retorno Val.Fecha.Indep 3");
			this.ComboBox_E02.Items.Add("Retorno Val.Fecha.Indep 4");
			this.ComboBox_E02.Items.Add("Retorno Motor c/ Val. Prop 1");
			this.ComboBox_E02.Items.Add("Retorno Motor c/ Val. Prop 2");
			this.ComboBox_E02.Items.Add("Retorno Motor c/ Val. Prop 3");
			this.ComboBox_E02.Items.Add("Retorno Motor c/ Val. Prop 4");
			this.ComboBox_E02.Items.Add("Arrombamento");
			this.ComboBox_E02.Items.Add("Faltas de Fase");
			this.ComboBox_E02.Items.Add("Alagamento");
			this.ComboBox_E02.Items.Add("Proteção - Nível Desliga");
			this.ComboBox_E02.Items.Add("Proteção - Nível Liga");
			this.ComboBox_E03.Items.Clear();
			this.ComboBox_E03.Items.Add("N/C");
			this.ComboBox_E03.Items.Add("Retorno Motor 1");
			this.ComboBox_E03.Items.Add("Retorno Motor 2");
			this.ComboBox_E03.Items.Add("Retorno Motor 3");
			this.ComboBox_E03.Items.Add("Retorno Motor 4");
			this.ComboBox_E03.Items.Add("Retorno Val.Abert 1");
			this.ComboBox_E03.Items.Add("Retorno Val.Abert 2");
			this.ComboBox_E03.Items.Add("Retorno Val.Abert 3");
			this.ComboBox_E03.Items.Add("Retorno Val.Abert 4");
			this.ComboBox_E03.Items.Add("Retorno Val.Fecha 1");
			this.ComboBox_E03.Items.Add("Retorno Val.Fecha 2");
			this.ComboBox_E03.Items.Add("Retorno Val.Fecha 3");
			this.ComboBox_E03.Items.Add("Retorno Val.Fecha 4");
			this.ComboBox_E03.Items.Add("Retorno Val.Abert.Indep 1");
			this.ComboBox_E03.Items.Add("Retorno Val.Abert.Indep 2");
			this.ComboBox_E03.Items.Add("Retorno Val.Abert.Indep 3");
			this.ComboBox_E03.Items.Add("Retorno Val.Abert.Indep 4");
			this.ComboBox_E03.Items.Add("Retorno Val.Fecha.Indep 1");
			this.ComboBox_E03.Items.Add("Retorno Val.Fecha.Indep 2");
			this.ComboBox_E03.Items.Add("Retorno Val.Fecha.Indep 3");
			this.ComboBox_E03.Items.Add("Retorno Val.Fecha.Indep 4");
			this.ComboBox_E03.Items.Add("Retorno Motor c/ Val. Prop 1");
			this.ComboBox_E03.Items.Add("Retorno Motor c/ Val. Prop 2");
			this.ComboBox_E03.Items.Add("Retorno Motor c/ Val. Prop 3");
			this.ComboBox_E03.Items.Add("Retorno Motor c/ Val. Prop 4");
			this.ComboBox_E03.Items.Add("Arrombamento");
			this.ComboBox_E03.Items.Add("Faltas de Fase");
			this.ComboBox_E03.Items.Add("Alagamento");
			this.ComboBox_E03.Items.Add("Proteção - Nível Desliga");
			this.ComboBox_E03.Items.Add("Proteção - Nível Liga");
			this.ComboBox_E04.Items.Clear();
			this.ComboBox_E04.Items.Add("N/C");
			this.ComboBox_E04.Items.Add("Retorno Motor 1");
			this.ComboBox_E04.Items.Add("Retorno Motor 2");
			this.ComboBox_E04.Items.Add("Retorno Motor 3");
			this.ComboBox_E04.Items.Add("Retorno Motor 4");
			this.ComboBox_E04.Items.Add("Retorno Val.Abert 1");
			this.ComboBox_E04.Items.Add("Retorno Val.Abert 2");
			this.ComboBox_E04.Items.Add("Retorno Val.Abert 3");
			this.ComboBox_E04.Items.Add("Retorno Val.Abert 4");
			this.ComboBox_E04.Items.Add("Retorno Val.Fecha 1");
			this.ComboBox_E04.Items.Add("Retorno Val.Fecha 2");
			this.ComboBox_E04.Items.Add("Retorno Val.Fecha 3");
			this.ComboBox_E04.Items.Add("Retorno Val.Fecha 4");
			this.ComboBox_E04.Items.Add("Retorno Val.Abert.Indep 1");
			this.ComboBox_E04.Items.Add("Retorno Val.Abert.Indep 2");
			this.ComboBox_E04.Items.Add("Retorno Val.Abert.Indep 3");
			this.ComboBox_E04.Items.Add("Retorno Val.Abert.Indep 4");
			this.ComboBox_E04.Items.Add("Retorno Val.Fecha.Indep 1");
			this.ComboBox_E04.Items.Add("Retorno Val.Fecha.Indep 2");
			this.ComboBox_E04.Items.Add("Retorno Val.Fecha.Indep 3");
			this.ComboBox_E04.Items.Add("Retorno Val.Fecha.Indep 4");
			this.ComboBox_E04.Items.Add("Retorno Motor c/ Val. Prop 1");
			this.ComboBox_E04.Items.Add("Retorno Motor c/ Val. Prop 2");
			this.ComboBox_E04.Items.Add("Retorno Motor c/ Val. Prop 3");
			this.ComboBox_E04.Items.Add("Retorno Motor c/ Val. Prop 4");
			this.ComboBox_E04.Items.Add("Arrombamento");
			this.ComboBox_E04.Items.Add("Faltas de Fase");
			this.ComboBox_E04.Items.Add("Alagamento");
			this.ComboBox_E04.Items.Add("Proteção - Nível Desliga");
			this.ComboBox_E04.Items.Add("Proteção - Nível Liga");
			this.ComboBox_E05.Items.Clear();
			this.ComboBox_E05.Items.Add("N/C");
			this.ComboBox_E05.Items.Add("Retorno Motor 1");
			this.ComboBox_E05.Items.Add("Retorno Motor 2");
			this.ComboBox_E05.Items.Add("Retorno Motor 3");
			this.ComboBox_E05.Items.Add("Retorno Motor 4");
			this.ComboBox_E05.Items.Add("Retorno Val.Abert 1");
			this.ComboBox_E05.Items.Add("Retorno Val.Abert 2");
			this.ComboBox_E05.Items.Add("Retorno Val.Abert 3");
			this.ComboBox_E05.Items.Add("Retorno Val.Abert 4");
			this.ComboBox_E05.Items.Add("Retorno Val.Fecha 1");
			this.ComboBox_E05.Items.Add("Retorno Val.Fecha 2");
			this.ComboBox_E05.Items.Add("Retorno Val.Fecha 3");
			this.ComboBox_E05.Items.Add("Retorno Val.Fecha 4");
			this.ComboBox_E05.Items.Add("Retorno Val.Abert.Indep 1");
			this.ComboBox_E05.Items.Add("Retorno Val.Abert.Indep 2");
			this.ComboBox_E05.Items.Add("Retorno Val.Abert.Indep 3");
			this.ComboBox_E05.Items.Add("Retorno Val.Abert.Indep 4");
			this.ComboBox_E05.Items.Add("Retorno Val.Fecha.Indep 1");
			this.ComboBox_E05.Items.Add("Retorno Val.Fecha.Indep 2");
			this.ComboBox_E05.Items.Add("Retorno Val.Fecha.Indep 3");
			this.ComboBox_E05.Items.Add("Retorno Val.Fecha.Indep 4");
			this.ComboBox_E05.Items.Add("Retorno Motor c/ Val. Prop 1");
			this.ComboBox_E05.Items.Add("Retorno Motor c/ Val. Prop 2");
			this.ComboBox_E05.Items.Add("Retorno Motor c/ Val. Prop 3");
			this.ComboBox_E05.Items.Add("Retorno Motor c/ Val. Prop 4");
			this.ComboBox_E05.Items.Add("Arrombamento");
			this.ComboBox_E05.Items.Add("Faltas de Fase");
			this.ComboBox_E05.Items.Add("Alagamento");
			this.ComboBox_E05.Items.Add("Proteção - Nível Desliga");
			this.ComboBox_E05.Items.Add("Proteção - Nível Liga");
			this.ComboBox_E06.Items.Clear();
			this.ComboBox_E06.Items.Add("N/C");
			this.ComboBox_E06.Items.Add("Retorno Motor 1");
			this.ComboBox_E06.Items.Add("Retorno Motor 2");
			this.ComboBox_E06.Items.Add("Retorno Motor 3");
			this.ComboBox_E06.Items.Add("Retorno Motor 4");
			this.ComboBox_E06.Items.Add("Retorno Val.Abert 1");
			this.ComboBox_E06.Items.Add("Retorno Val.Abert 2");
			this.ComboBox_E06.Items.Add("Retorno Val.Abert 3");
			this.ComboBox_E06.Items.Add("Retorno Val.Abert 4");
			this.ComboBox_E06.Items.Add("Retorno Val.Fecha 1");
			this.ComboBox_E06.Items.Add("Retorno Val.Fecha 2");
			this.ComboBox_E06.Items.Add("Retorno Val.Fecha 3");
			this.ComboBox_E06.Items.Add("Retorno Val.Fecha 4");
			this.ComboBox_E06.Items.Add("Retorno Val.Abert.Indep 1");
			this.ComboBox_E06.Items.Add("Retorno Val.Abert.Indep 2");
			this.ComboBox_E06.Items.Add("Retorno Val.Abert.Indep 3");
			this.ComboBox_E06.Items.Add("Retorno Val.Abert.Indep 4");
			this.ComboBox_E06.Items.Add("Retorno Val.Fecha.Indep 1");
			this.ComboBox_E06.Items.Add("Retorno Val.Fecha.Indep 2");
			this.ComboBox_E06.Items.Add("Retorno Val.Fecha.Indep 3");
			this.ComboBox_E06.Items.Add("Retorno Val.Fecha.Indep 4");
			this.ComboBox_E06.Items.Add("Retorno Motor c/ Val. Prop 1");
			this.ComboBox_E06.Items.Add("Retorno Motor c/ Val. Prop 2");
			this.ComboBox_E06.Items.Add("Retorno Motor c/ Val. Prop 3");
			this.ComboBox_E06.Items.Add("Retorno Motor c/ Val. Prop 4");
			this.ComboBox_E06.Items.Add("Arrombamento");
			this.ComboBox_E06.Items.Add("Faltas de Fase");
			this.ComboBox_E06.Items.Add("Alagamento");
			this.ComboBox_E06.Items.Add("Proteção - Nível Desliga");
			this.ComboBox_E06.Items.Add("Proteção - Nível Liga");
			this.ComboBox_E07.Items.Clear();
			this.ComboBox_E07.Items.Add("N/C");
			this.ComboBox_E07.Items.Add("Retorno Motor 1");
			this.ComboBox_E07.Items.Add("Retorno Motor 2");
			this.ComboBox_E07.Items.Add("Retorno Motor 3");
			this.ComboBox_E07.Items.Add("Retorno Motor 4");
			this.ComboBox_E07.Items.Add("Retorno Val.Abert 1");
			this.ComboBox_E07.Items.Add("Retorno Val.Abert 2");
			this.ComboBox_E07.Items.Add("Retorno Val.Abert 3");
			this.ComboBox_E07.Items.Add("Retorno Val.Abert 4");
			this.ComboBox_E07.Items.Add("Retorno Val.Fecha 1");
			this.ComboBox_E07.Items.Add("Retorno Val.Fecha 2");
			this.ComboBox_E07.Items.Add("Retorno Val.Fecha 3");
			this.ComboBox_E07.Items.Add("Retorno Val.Fecha 4");
			this.ComboBox_E07.Items.Add("Retorno Val.Abert.Indep 1");
			this.ComboBox_E07.Items.Add("Retorno Val.Abert.Indep 2");
			this.ComboBox_E07.Items.Add("Retorno Val.Abert.Indep 3");
			this.ComboBox_E07.Items.Add("Retorno Val.Abert.Indep 4");
			this.ComboBox_E07.Items.Add("Retorno Val.Fecha.Indep 1");
			this.ComboBox_E07.Items.Add("Retorno Val.Fecha.Indep 2");
			this.ComboBox_E07.Items.Add("Retorno Val.Fecha.Indep 3");
			this.ComboBox_E07.Items.Add("Retorno Val.Fecha.Indep 4");
			this.ComboBox_E07.Items.Add("Retorno Motor c/ Val. Prop 1");
			this.ComboBox_E07.Items.Add("Retorno Motor c/ Val. Prop 2");
			this.ComboBox_E07.Items.Add("Retorno Motor c/ Val. Prop 3");
			this.ComboBox_E07.Items.Add("Retorno Motor c/ Val. Prop 4");
			this.ComboBox_E07.Items.Add("Arrombamento");
			this.ComboBox_E07.Items.Add("Faltas de Fase");
			this.ComboBox_E07.Items.Add("Alagamento");
			this.ComboBox_E07.Items.Add("Proteção - Nível Desliga");
			this.ComboBox_E07.Items.Add("Proteção - Nível Liga");
			this.ComboBox_E08.Items.Clear();
			this.ComboBox_E08.Items.Add("N/C");
			this.ComboBox_E08.Items.Add("Retorno Motor 1");
			this.ComboBox_E08.Items.Add("Retorno Motor 2");
			this.ComboBox_E08.Items.Add("Retorno Motor 3");
			this.ComboBox_E08.Items.Add("Retorno Motor 4");
			this.ComboBox_E08.Items.Add("Retorno Val.Abert 1");
			this.ComboBox_E08.Items.Add("Retorno Val.Abert 2");
			this.ComboBox_E08.Items.Add("Retorno Val.Abert 3");
			this.ComboBox_E08.Items.Add("Retorno Val.Abert 4");
			this.ComboBox_E08.Items.Add("Retorno Val.Fecha 1");
			this.ComboBox_E08.Items.Add("Retorno Val.Fecha 2");
			this.ComboBox_E08.Items.Add("Retorno Val.Fecha 3");
			this.ComboBox_E08.Items.Add("Retorno Val.Fecha 4");
			this.ComboBox_E08.Items.Add("Retorno Val.Abert.Indep 1");
			this.ComboBox_E08.Items.Add("Retorno Val.Abert.Indep 2");
			this.ComboBox_E08.Items.Add("Retorno Val.Abert.Indep 3");
			this.ComboBox_E08.Items.Add("Retorno Val.Abert.Indep 4");
			this.ComboBox_E08.Items.Add("Retorno Val.Fecha.Indep 1");
			this.ComboBox_E08.Items.Add("Retorno Val.Fecha.Indep 2");
			this.ComboBox_E08.Items.Add("Retorno Val.Fecha.Indep 3");
			this.ComboBox_E08.Items.Add("Retorno Val.Fecha.Indep 4");
			this.ComboBox_E08.Items.Add("Retorno Motor c/ Val. Prop 1");
			this.ComboBox_E08.Items.Add("Retorno Motor c/ Val. Prop 2");
			this.ComboBox_E08.Items.Add("Retorno Motor c/ Val. Prop 3");
			this.ComboBox_E08.Items.Add("Retorno Motor c/ Val. Prop 4");
			this.ComboBox_E08.Items.Add("Arrombamento");
			this.ComboBox_E08.Items.Add("Faltas de Fase");
			this.ComboBox_E08.Items.Add("Alagamento");
			this.ComboBox_E08.Items.Add("Proteção - Nível Desliga");
			this.ComboBox_E08.Items.Add("Proteção - Nível Liga");
			this.ComboBox_S01.Items.Clear();
			this.ComboBox_S01.Items.Add("N/C");
			this.ComboBox_S01.Items.Add("Acionamento Motor 1");
			this.ComboBox_S01.Items.Add("Acionamento Motor 2");
			this.ComboBox_S01.Items.Add("Acionamento Motor 3");
			this.ComboBox_S01.Items.Add("Acionamento Motor 4");
			this.ComboBox_S01.Items.Add("Acionamento Val.Abert 1");
			this.ComboBox_S01.Items.Add("Acionamento Val.Abert 2");
			this.ComboBox_S01.Items.Add("Acionamento Val.Abert 3");
			this.ComboBox_S01.Items.Add("Acionamento Val.Abert 4");
			this.ComboBox_S01.Items.Add("Acionamento Val.Fecha 1");
			this.ComboBox_S01.Items.Add("Acionamento Val.Fecha 2");
			this.ComboBox_S01.Items.Add("Acionamento Val.Fecha 3");
			this.ComboBox_S01.Items.Add("Acionamento Val.Fecha 4");
			this.ComboBox_S01.Items.Add("Acionamento Val.Abert.Indep 1");
			this.ComboBox_S01.Items.Add("Acionamento Val.Abert.Indep 2");
			this.ComboBox_S01.Items.Add("Acionamento Val.Abert.Indep 3");
			this.ComboBox_S01.Items.Add("Acionamento Val.Abert.Indep 4");
			this.ComboBox_S01.Items.Add("Acionamento Val.Fecha.Indep 1");
			this.ComboBox_S01.Items.Add("Acionamento Val.Fecha.Indep 2");
			this.ComboBox_S01.Items.Add("Acionamento Val.Fecha.Indep 3");
			this.ComboBox_S01.Items.Add("Acionamento Val.Fecha.Indep 4");
			this.ComboBox_S01.Items.Add("Acionamento Motor c/ Val. Prop 1");
			this.ComboBox_S01.Items.Add("Acionamento Motor c/ Val. Prop 2");
			this.ComboBox_S01.Items.Add("Acionamento Motor c/ Val. Prop 3");
			this.ComboBox_S01.Items.Add("Acionamento Motor c/ Val. Prop 4");
			this.ComboBox_S02.Items.Clear();
			this.ComboBox_S02.Items.Add("N/C");
			this.ComboBox_S02.Items.Add("Acionamento Motor 1");
			this.ComboBox_S02.Items.Add("Acionamento Motor 2");
			this.ComboBox_S02.Items.Add("Acionamento Motor 3");
			this.ComboBox_S02.Items.Add("Acionamento Motor 4");
			this.ComboBox_S02.Items.Add("Acionamento Val.Abert 1");
			this.ComboBox_S02.Items.Add("Acionamento Val.Abert 2");
			this.ComboBox_S02.Items.Add("Acionamento Val.Abert 3");
			this.ComboBox_S02.Items.Add("Acionamento Val.Abert 4");
			this.ComboBox_S02.Items.Add("Acionamento Val.Fecha 1");
			this.ComboBox_S02.Items.Add("Acionamento Val.Fecha 2");
			this.ComboBox_S02.Items.Add("Acionamento Val.Fecha 3");
			this.ComboBox_S02.Items.Add("Acionamento Val.Fecha 4");
			this.ComboBox_S02.Items.Add("Acionamento Val.Abert.Indep 1");
			this.ComboBox_S02.Items.Add("Acionamento Val.Abert.Indep 2");
			this.ComboBox_S02.Items.Add("Acionamento Val.Abert.Indep 3");
			this.ComboBox_S02.Items.Add("Acionamento Val.Abert.Indep 4");
			this.ComboBox_S02.Items.Add("Acionamento Val.Fecha.Indep 1");
			this.ComboBox_S02.Items.Add("Acionamento Val.Fecha.Indep 2");
			this.ComboBox_S02.Items.Add("Acionamento Val.Fecha.Indep 3");
			this.ComboBox_S02.Items.Add("Acionamento Val.Fecha.Indep 4");
			this.ComboBox_S02.Items.Add("Acionamento Motor c/ Val. Prop 1");
			this.ComboBox_S02.Items.Add("Acionamento Motor c/ Val. Prop 2");
			this.ComboBox_S02.Items.Add("Acionamento Motor c/ Val. Prop 3");
			this.ComboBox_S02.Items.Add("Acionamento Motor c/ Val. Prop 4");
			this.ComboBox_S03.Items.Clear();
			this.ComboBox_S03.Items.Add("N/C");
			this.ComboBox_S03.Items.Add("Acionamento Motor 1");
			this.ComboBox_S03.Items.Add("Acionamento Motor 2");
			this.ComboBox_S03.Items.Add("Acionamento Motor 3");
			this.ComboBox_S03.Items.Add("Acionamento Motor 4");
			this.ComboBox_S03.Items.Add("Acionamento Val.Abert 1");
			this.ComboBox_S03.Items.Add("Acionamento Val.Abert 2");
			this.ComboBox_S03.Items.Add("Acionamento Val.Abert 3");
			this.ComboBox_S03.Items.Add("Acionamento Val.Abert 4");
			this.ComboBox_S03.Items.Add("Acionamento Val.Fecha 1");
			this.ComboBox_S03.Items.Add("Acionamento Val.Fecha 2");
			this.ComboBox_S03.Items.Add("Acionamento Val.Fecha 3");
			this.ComboBox_S03.Items.Add("Acionamento Val.Fecha 4");
			this.ComboBox_S03.Items.Add("Acionamento Val.Abert.Indep 1");
			this.ComboBox_S03.Items.Add("Acionamento Val.Abert.Indep 2");
			this.ComboBox_S03.Items.Add("Acionamento Val.Abert.Indep 3");
			this.ComboBox_S03.Items.Add("Acionamento Val.Abert.Indep 4");
			this.ComboBox_S03.Items.Add("Acionamento Val.Fecha.Indep 1");
			this.ComboBox_S03.Items.Add("Acionamento Val.Fecha.Indep 2");
			this.ComboBox_S03.Items.Add("Acionamento Val.Fecha.Indep 3");
			this.ComboBox_S03.Items.Add("Acionamento Val.Fecha.Indep 4");
			this.ComboBox_S03.Items.Add("Acionamento Motor c/ Val. Prop 1");
			this.ComboBox_S03.Items.Add("Acionamento Motor c/ Val. Prop 2");
			this.ComboBox_S03.Items.Add("Acionamento Motor c/ Val. Prop 3");
			this.ComboBox_S03.Items.Add("Acionamento Motor c/ Val. Prop 4");
			this.ComboBox_S04.Items.Clear();
			this.ComboBox_S04.Items.Add("N/C");
			this.ComboBox_S04.Items.Add("Acionamento Motor 1");
			this.ComboBox_S04.Items.Add("Acionamento Motor 2");
			this.ComboBox_S04.Items.Add("Acionamento Motor 3");
			this.ComboBox_S04.Items.Add("Acionamento Motor 4");
			this.ComboBox_S04.Items.Add("Acionamento Val.Abert 1");
			this.ComboBox_S04.Items.Add("Acionamento Val.Abert 2");
			this.ComboBox_S04.Items.Add("Acionamento Val.Abert 3");
			this.ComboBox_S04.Items.Add("Acionamento Val.Abert 4");
			this.ComboBox_S04.Items.Add("Acionamento Val.Fecha 1");
			this.ComboBox_S04.Items.Add("Acionamento Val.Fecha 2");
			this.ComboBox_S04.Items.Add("Acionamento Val.Fecha 3");
			this.ComboBox_S04.Items.Add("Acionamento Val.Fecha 4");
			this.ComboBox_S04.Items.Add("Acionamento Val.Abert.Indep 1");
			this.ComboBox_S04.Items.Add("Acionamento Val.Abert.Indep 2");
			this.ComboBox_S04.Items.Add("Acionamento Val.Abert.Indep 3");
			this.ComboBox_S04.Items.Add("Acionamento Val.Abert.Indep 4");
			this.ComboBox_S04.Items.Add("Acionamento Val.Fecha.Indep 1");
			this.ComboBox_S04.Items.Add("Acionamento Val.Fecha.Indep 2");
			this.ComboBox_S04.Items.Add("Acionamento Val.Fecha.Indep 3");
			this.ComboBox_S04.Items.Add("Acionamento Val.Fecha.Indep 4");
			this.ComboBox_S04.Items.Add("Acionamento Motor c/ Val. Prop 1");
			this.ComboBox_S04.Items.Add("Acionamento Motor c/ Val. Prop 2");
			this.ComboBox_S04.Items.Add("Acionamento Motor c/ Val. Prop 3");
			this.ComboBox_S04.Items.Add("Acionamento Motor c/ Val. Prop 4");
			this.ComboBox_S05.Items.Clear();
			this.ComboBox_S05.Items.Add("N/C");
			this.ComboBox_S05.Items.Add("Acionamento Motor 1");
			this.ComboBox_S05.Items.Add("Acionamento Motor 2");
			this.ComboBox_S05.Items.Add("Acionamento Motor 3");
			this.ComboBox_S05.Items.Add("Acionamento Motor 4");
			this.ComboBox_S05.Items.Add("Acionamento Val.Abert 1");
			this.ComboBox_S05.Items.Add("Acionamento Val.Abert 2");
			this.ComboBox_S05.Items.Add("Acionamento Val.Abert 3");
			this.ComboBox_S05.Items.Add("Acionamento Val.Abert 4");
			this.ComboBox_S05.Items.Add("Acionamento Val.Fecha 1");
			this.ComboBox_S05.Items.Add("Acionamento Val.Fecha 2");
			this.ComboBox_S05.Items.Add("Acionamento Val.Fecha 3");
			this.ComboBox_S05.Items.Add("Acionamento Val.Fecha 4");
			this.ComboBox_S05.Items.Add("Acionamento Val.Abert.Indep 1");
			this.ComboBox_S05.Items.Add("Acionamento Val.Abert.Indep 2");
			this.ComboBox_S05.Items.Add("Acionamento Val.Abert.Indep 3");
			this.ComboBox_S05.Items.Add("Acionamento Val.Abert.Indep 4");
			this.ComboBox_S05.Items.Add("Acionamento Val.Fecha.Indep 1");
			this.ComboBox_S05.Items.Add("Acionamento Val.Fecha.Indep 2");
			this.ComboBox_S05.Items.Add("Acionamento Val.Fecha.Indep 3");
			this.ComboBox_S05.Items.Add("Acionamento Val.Fecha.Indep 4");
			this.ComboBox_S05.Items.Add("Acionamento Motor c/ Val. Prop 1");
			this.ComboBox_S05.Items.Add("Acionamento Motor c/ Val. Prop 2");
			this.ComboBox_S05.Items.Add("Acionamento Motor c/ Val. Prop 3");
			this.ComboBox_S05.Items.Add("Acionamento Motor c/ Val. Prop 4");
			this.ComboBox_S06.Items.Clear();
			this.ComboBox_S06.Items.Add("N/C");
			this.ComboBox_S06.Items.Add("Acionamento Motor 1");
			this.ComboBox_S06.Items.Add("Acionamento Motor 2");
			this.ComboBox_S06.Items.Add("Acionamento Motor 3");
			this.ComboBox_S06.Items.Add("Acionamento Motor 4");
			this.ComboBox_S06.Items.Add("Acionamento Val.Abert 1");
			this.ComboBox_S06.Items.Add("Acionamento Val.Abert 2");
			this.ComboBox_S06.Items.Add("Acionamento Val.Abert 3");
			this.ComboBox_S06.Items.Add("Acionamento Val.Abert 4");
			this.ComboBox_S06.Items.Add("Acionamento Val.Fecha 1");
			this.ComboBox_S06.Items.Add("Acionamento Val.Fecha 2");
			this.ComboBox_S06.Items.Add("Acionamento Val.Fecha 3");
			this.ComboBox_S06.Items.Add("Acionamento Val.Fecha 4");
			this.ComboBox_S06.Items.Add("Acionamento Val.Abert.Indep 1");
			this.ComboBox_S06.Items.Add("Acionamento Val.Abert.Indep 2");
			this.ComboBox_S06.Items.Add("Acionamento Val.Abert.Indep 3");
			this.ComboBox_S06.Items.Add("Acionamento Val.Abert.Indep 4");
			this.ComboBox_S06.Items.Add("Acionamento Val.Fecha.Indep 1");
			this.ComboBox_S06.Items.Add("Acionamento Val.Fecha.Indep 2");
			this.ComboBox_S06.Items.Add("Acionamento Val.Fecha.Indep 3");
			this.ComboBox_S06.Items.Add("Acionamento Val.Fecha.Indep 4");
			this.ComboBox_S06.Items.Add("Acionamento Motor c/ Val. Prop 1");
			this.ComboBox_S06.Items.Add("Acionamento Motor c/ Val. Prop 2");
			this.ComboBox_S06.Items.Add("Acionamento Motor c/ Val. Prop 3");
			this.ComboBox_S06.Items.Add("Acionamento Motor c/ Val. Prop 4");
			this.ComboBox_S07.Items.Clear();
			this.ComboBox_S07.Items.Add("N/C");
			this.ComboBox_S07.Items.Add("Acionamento Motor 1");
			this.ComboBox_S07.Items.Add("Acionamento Motor 2");
			this.ComboBox_S07.Items.Add("Acionamento Motor 3");
			this.ComboBox_S07.Items.Add("Acionamento Motor 4");
			this.ComboBox_S07.Items.Add("Acionamento Val.Abert 1");
			this.ComboBox_S07.Items.Add("Acionamento Val.Abert 2");
			this.ComboBox_S07.Items.Add("Acionamento Val.Abert 3");
			this.ComboBox_S07.Items.Add("Acionamento Val.Abert 4");
			this.ComboBox_S07.Items.Add("Acionamento Val.Fecha 1");
			this.ComboBox_S07.Items.Add("Acionamento Val.Fecha 2");
			this.ComboBox_S07.Items.Add("Acionamento Val.Fecha 3");
			this.ComboBox_S07.Items.Add("Acionamento Val.Fecha 4");
			this.ComboBox_S07.Items.Add("Acionamento Val.Abert.Indep 1");
			this.ComboBox_S07.Items.Add("Acionamento Val.Abert.Indep 2");
			this.ComboBox_S07.Items.Add("Acionamento Val.Abert.Indep 3");
			this.ComboBox_S07.Items.Add("Acionamento Val.Abert.Indep 4");
			this.ComboBox_S07.Items.Add("Acionamento Val.Fecha.Indep 1");
			this.ComboBox_S07.Items.Add("Acionamento Val.Fecha.Indep 2");
			this.ComboBox_S07.Items.Add("Acionamento Val.Fecha.Indep 3");
			this.ComboBox_S07.Items.Add("Acionamento Val.Fecha.Indep 4");
			this.ComboBox_S07.Items.Add("Acionamento Motor c/ Val. Prop 1");
			this.ComboBox_S07.Items.Add("Acionamento Motor c/ Val. Prop 2");
			this.ComboBox_S07.Items.Add("Acionamento Motor c/ Val. Prop 3");
			this.ComboBox_S07.Items.Add("Acionamento Motor c/ Val. Prop 4");
			this.ComboBox_S08.Items.Clear();
			this.ComboBox_S08.Items.Add("N/C");
			this.ComboBox_S08.Items.Add("Acionamento Motor 1");
			this.ComboBox_S08.Items.Add("Acionamento Motor 2");
			this.ComboBox_S08.Items.Add("Acionamento Motor 3");
			this.ComboBox_S08.Items.Add("Acionamento Motor 4");
			this.ComboBox_S08.Items.Add("Acionamento Val.Abert 1");
			this.ComboBox_S08.Items.Add("Acionamento Val.Abert 2");
			this.ComboBox_S08.Items.Add("Acionamento Val.Abert 3");
			this.ComboBox_S08.Items.Add("Acionamento Val.Abert 4");
			this.ComboBox_S08.Items.Add("Acionamento Val.Fecha 1");
			this.ComboBox_S08.Items.Add("Acionamento Val.Fecha 2");
			this.ComboBox_S08.Items.Add("Acionamento Val.Fecha 3");
			this.ComboBox_S08.Items.Add("Acionamento Val.Fecha 4");
			this.ComboBox_S08.Items.Add("Acionamento Val.Abert.Indep 1");
			this.ComboBox_S08.Items.Add("Acionamento Val.Abert.Indep 2");
			this.ComboBox_S08.Items.Add("Acionamento Val.Abert.Indep 3");
			this.ComboBox_S08.Items.Add("Acionamento Val.Abert.Indep 4");
			this.ComboBox_S08.Items.Add("Acionamento Val.Fecha.Indep 1");
			this.ComboBox_S08.Items.Add("Acionamento Val.Fecha.Indep 2");
			this.ComboBox_S08.Items.Add("Acionamento Val.Fecha.Indep 3");
			this.ComboBox_S08.Items.Add("Acionamento Val.Fecha.Indep 4");
			this.ComboBox_S08.Items.Add("Acionamento Motor c/ Val. Prop 1");
			this.ComboBox_S08.Items.Add("Acionamento Motor c/ Val. Prop 2");
			this.ComboBox_S08.Items.Add("Acionamento Motor c/ Val. Prop 3");
			this.ComboBox_S08.Items.Add("Acionamento Motor c/ Val. Prop 4");
			this.Limpa_tela_conf_VA220();
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x00412C04 File Offset: 0x00411004
		public void Limpa_tela_conf_VA220()
		{
			this.Limpa_estrutura_VA220();
			this.Atualiza_tela_VA220();
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x00412C14 File Offset: 0x00411014
		public void Limpa_estrutura_VA220()
		{
			Mod_VA.Config_VA220.Entradas_digitais = new int[9];
			Mod_VA.Config_VA220.Saidas_digitais = new int[9];
			Mod_VA.Config_VA220.End_estacao = 0;
			Mod_VA.Config_VA220.End_mestre = 0;
			Mod_VA.Config_VA220.Ctrl_nivel_fonte = 0;
			Mod_VA.Config_VA220.Modo_operacao = 0;
			Mod_VA.Config_VA220.Numero_max_bombas = 0;
			Mod_VA.Config_VA220.Tempo_entre_acionamentos = 0;
			Mod_VA.Config_VA220.Tempo_falha_parada = 0;
			Mod_VA.Config_VA220.Tempo_falha_partida = 0;
			Mod_VA.Config_VA220.Tempo_minimo_operando = 0;
			Mod_VA.Config_VA220.Tempo_minimo_parado = 0;
			Mod_VA.Config_VA220.Tempo_ptt = 0;
			Mod_VA.Config_VA220.Saidas_digitais[1] = 0;
			Mod_VA.Config_VA220.Saidas_digitais[2] = 0;
			Mod_VA.Config_VA220.Saidas_digitais[3] = 0;
			Mod_VA.Config_VA220.Saidas_digitais[4] = 0;
			Mod_VA.Config_VA220.Saidas_digitais[5] = 0;
			Mod_VA.Config_VA220.Saidas_digitais[6] = 0;
			Mod_VA.Config_VA220.Saidas_digitais[7] = 0;
			Mod_VA.Config_VA220.Saidas_digitais[8] = 0;
			Mod_VA.Config_VA220.Entradas_digitais[1] = 0;
			Mod_VA.Config_VA220.Entradas_digitais[2] = 0;
			Mod_VA.Config_VA220.Entradas_digitais[3] = 0;
			Mod_VA.Config_VA220.Entradas_digitais[4] = 0;
			Mod_VA.Config_VA220.Entradas_digitais[5] = 0;
			Mod_VA.Config_VA220.Entradas_digitais[6] = 0;
			Mod_VA.Config_VA220.Entradas_digitais[7] = 0;
			Mod_VA.Config_VA220.Entradas_digitais[8] = 0;
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x00412D8C File Offset: 0x0041118C
		public void Atualiza_tela_VA220()
		{
			this.Valor_end_est.Text = Conversions.ToString(Mod_VA.Config_VA220.End_estacao);
			this.Valor_end_mestre.Text = Conversions.ToString(Mod_VA.Config_VA220.End_mestre);
			this.Valor_max_bombas.Text = Conversions.ToString(Mod_VA.Config_VA220.Numero_max_bombas);
			this.Valor_temp_ptt.Text = Conversions.ToString(Mod_VA.Config_VA220.Tempo_ptt);
			this.Valor_tempo_entre_acionamentos.Text = Conversions.ToString(Mod_VA.Config_VA220.Tempo_entre_acionamentos);
			this.Valor_tempo_falha_desligar_motor.Text = Conversions.ToString(Mod_VA.Config_VA220.Tempo_falha_parada);
			this.Valor_tempo_falha_ligar_motor.Text = Conversions.ToString(Mod_VA.Config_VA220.Tempo_falha_partida);
			this.Valor_tempo_motor_operando.Text = Conversions.ToString(Mod_VA.Config_VA220.Tempo_minimo_operando);
			this.Valor_tempo_motor_parado.Text = Conversions.ToString(Mod_VA.Config_VA220.Tempo_minimo_parado);
			this.ComboBox_controle_nivel.SelectedIndex = Mod_VA.Config_VA220.Ctrl_nivel_fonte;
			this.ComboBox_modo_operacao.SelectedIndex = Mod_VA.Config_VA220.Modo_operacao;
			this.ComboBox_E01.SelectedIndex = Mod_VA.Config_VA220.Entradas_digitais[1];
			this.ComboBox_E02.SelectedIndex = Mod_VA.Config_VA220.Entradas_digitais[2];
			this.ComboBox_E03.SelectedIndex = Mod_VA.Config_VA220.Entradas_digitais[3];
			this.ComboBox_E04.SelectedIndex = Mod_VA.Config_VA220.Entradas_digitais[4];
			this.ComboBox_E05.SelectedIndex = Mod_VA.Config_VA220.Entradas_digitais[5];
			this.ComboBox_E06.SelectedIndex = Mod_VA.Config_VA220.Entradas_digitais[6];
			this.ComboBox_E07.SelectedIndex = Mod_VA.Config_VA220.Entradas_digitais[7];
			this.ComboBox_E08.SelectedIndex = Mod_VA.Config_VA220.Entradas_digitais[8];
			this.ComboBox_S01.SelectedIndex = Mod_VA.Config_VA220.Saidas_digitais[1];
			this.ComboBox_S02.SelectedIndex = Mod_VA.Config_VA220.Saidas_digitais[2];
			this.ComboBox_S03.SelectedIndex = Mod_VA.Config_VA220.Saidas_digitais[3];
			this.ComboBox_S04.SelectedIndex = Mod_VA.Config_VA220.Saidas_digitais[4];
			this.ComboBox_S05.SelectedIndex = Mod_VA.Config_VA220.Saidas_digitais[5];
			this.ComboBox_S06.SelectedIndex = Mod_VA.Config_VA220.Saidas_digitais[6];
			this.ComboBox_S07.SelectedIndex = Mod_VA.Config_VA220.Saidas_digitais[7];
			this.ComboBox_S08.SelectedIndex = Mod_VA.Config_VA220.Saidas_digitais[8];
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x00413020 File Offset: 0x00411420
		private void Ler_conf_VA220_Click(object sender, EventArgs e)
		{
			int[] array = new int[41];
			this.Limpa_tela_conf_VA220();
			this.Mensagem_VA220("Aguarde ...", 2);
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			checked
			{
				while (i > 0)
				{
					i--;
					array[0] = 1;
					Comunicacao.CMD_Tx_condax(0, 0, 100, 1, array);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						Mod_VA.Atualiza_dados_VA220_configuracao_geral();
						this.Atualiza_tela_VA220_configuracao_geral();
						this.Mensagem_VA220("Leitura configuração geral - Ok", 0);
						goto IL_CD;
					case 2:
						if (i == 0)
						{
							this.Mensagem_VA220("Erro leitura configuração geral - conferência", 1);
							return;
						}
						continue;
					case 3:
						if (i == 0)
						{
							this.Mensagem_VA220("Erro leitura configuração geral - timeout", 1);
							return;
						}
						continue;
					}
					if (i == 0)
					{
						this.Mensagem_VA220("Erro leitura configuração geral - não determinado", 1);
						return;
					}
				}
				IL_CD:
				i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
				while (i > 0)
				{
					i--;
					array[0] = 4;
					Comunicacao.CMD_Tx_condax(0, 0, 100, 1, array);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						Mod_VA.Atualiza_dados_VA220_configuracao_IO();
						this.Atualiza_tela_VA220_configuracao_IO();
						this.Mensagem_VA220("Leitura configuração I/O - Ok", 0);
						goto IL_180;
					case 2:
						if (i == 0)
						{
							this.Mensagem_VA220("Erro leitura configuração I/O - conferência", 1);
							return;
						}
						continue;
					case 3:
						if (i == 0)
						{
							this.Mensagem_VA220("Erro leitura configuração I/O - timeout", 1);
							return;
						}
						continue;
					}
					if (i == 0)
					{
						this.Mensagem_VA220("Erro leitura configuração I/O - não determinado", 1);
						return;
					}
				}
				IL_180:
				this.Mensagem_VA220("Leitura executada com sucesso", 0);
			}
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x004131BC File Offset: 0x004115BC
		public void Mensagem_VA220(string msg, int cor)
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

		// Token: 0x0600251A RID: 9498 RVA: 0x00413220 File Offset: 0x00411620
		public void Atualiza_tela_VA220_configuracao_geral()
		{
			this.Valor_end_est.Text = Conversions.ToString(Mod_VA.Config_VA220.End_estacao);
			this.Valor_end_mestre.Text = Conversions.ToString(Mod_VA.Config_VA220.End_mestre);
			this.Valor_max_bombas.Text = Conversions.ToString(Mod_VA.Config_VA220.Numero_max_bombas);
			this.Valor_temp_ptt.Text = Conversions.ToString(Mod_VA.Config_VA220.Tempo_ptt);
			this.Valor_tempo_entre_acionamentos.Text = Conversions.ToString(Mod_VA.Config_VA220.Tempo_entre_acionamentos);
			this.Valor_tempo_falha_desligar_motor.Text = Conversions.ToString(Mod_VA.Config_VA220.Tempo_falha_parada);
			this.Valor_tempo_falha_ligar_motor.Text = Conversions.ToString(Mod_VA.Config_VA220.Tempo_falha_partida);
			this.Valor_tempo_motor_operando.Text = Conversions.ToString(Mod_VA.Config_VA220.Tempo_minimo_operando);
			this.Valor_tempo_motor_parado.Text = Conversions.ToString(Mod_VA.Config_VA220.Tempo_minimo_parado);
			this.ComboBox_modo_operacao.SelectedIndex = Mod_VA.Config_VA220.Modo_operacao;
			this.ComboBox_controle_nivel.SelectedIndex = Mod_VA.Config_VA220.Ctrl_nivel_fonte;
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x00413344 File Offset: 0x00411744
		public void Atualiza_tela_VA220_configuracao_IO()
		{
			this.ComboBox_E01.SelectedIndex = Mod_VA.Config_VA220.Entradas_digitais[1];
			this.ComboBox_E02.SelectedIndex = Mod_VA.Config_VA220.Entradas_digitais[2];
			this.ComboBox_E03.SelectedIndex = Mod_VA.Config_VA220.Entradas_digitais[3];
			this.ComboBox_E04.SelectedIndex = Mod_VA.Config_VA220.Entradas_digitais[4];
			this.ComboBox_E05.SelectedIndex = Mod_VA.Config_VA220.Entradas_digitais[5];
			this.ComboBox_E06.SelectedIndex = Mod_VA.Config_VA220.Entradas_digitais[6];
			this.ComboBox_E07.SelectedIndex = Mod_VA.Config_VA220.Entradas_digitais[7];
			this.ComboBox_E08.SelectedIndex = Mod_VA.Config_VA220.Entradas_digitais[8];
			this.ComboBox_S01.SelectedIndex = Mod_VA.Config_VA220.Saidas_digitais[1];
			this.ComboBox_S02.SelectedIndex = Mod_VA.Config_VA220.Saidas_digitais[2];
			this.ComboBox_S03.SelectedIndex = Mod_VA.Config_VA220.Saidas_digitais[3];
			this.ComboBox_S04.SelectedIndex = Mod_VA.Config_VA220.Saidas_digitais[4];
			this.ComboBox_S05.SelectedIndex = Mod_VA.Config_VA220.Saidas_digitais[5];
			this.ComboBox_S06.SelectedIndex = Mod_VA.Config_VA220.Saidas_digitais[6];
			this.ComboBox_S07.SelectedIndex = Mod_VA.Config_VA220.Saidas_digitais[7];
			this.ComboBox_S08.SelectedIndex = Mod_VA.Config_VA220.Saidas_digitais[8];
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x004134C4 File Offset: 0x004118C4
		private void Esc_conf_VA220_Click(object sender, EventArgs e)
		{
			int[] dados = new int[41];
			this.Mensagem_VA220("Aguarde ...", 2);
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			checked
			{
				while (i > 0)
				{
					i--;
					Comunicacao.CMD_Tx_condax(0, 0, 104, 0, dados);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						this.Mensagem_VA220("Habilitação de configuração - Ok", 0);
						goto IL_B8;
					case 2:
						if (i == 0)
						{
							this.Mensagem_VA220("Habilitação de configuração - conferência", 1);
							return;
						}
						continue;
					case 3:
						if (i == 0)
						{
							this.Mensagem_VA220("Habilitação de configuração - timeout", 1);
							return;
						}
						continue;
					}
					if (i == 0)
					{
						this.Mensagem_VA220("Habilitação de configuração - não determinado", 1);
						return;
					}
				}
				IL_B8:
				i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
				while (i > 0)
				{
					i--;
					Mod_VA.Monta_buffer_conf_geral(dados);
					Comunicacao.CMD_Tx_condax(0, 0, 96, 11, dados);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						this.Mensagem_VA220("Escrita configuração geral - Ok", 0);
						goto IL_163;
					case 2:
						if (i == 0)
						{
							this.Mensagem_VA220("Escrita configuração geral - conferência", 1);
							return;
						}
						continue;
					case 3:
						if (i == 0)
						{
							this.Mensagem_VA220("Escrita configuração geral - timeout", 1);
							return;
						}
						continue;
					}
					if (i == 0)
					{
						this.Mensagem_VA220("Escrita configuração geral - não determinado", 1);
						return;
					}
				}
				IL_163:
				i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
				while (i > 0)
				{
					i--;
					Mod_VA.Monta_buffer_conf_IO(dados);
					Comunicacao.CMD_Tx_condax(0, 0, 105, 16, dados);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						this.Mensagem_VA220("Escrita configuração I/O - Ok", 0);
						goto IL_20E;
					case 2:
						if (i == 0)
						{
							this.Mensagem_VA220("Escrita configuração I/O - conferência", 1);
							return;
						}
						continue;
					case 3:
						if (i == 0)
						{
							this.Mensagem_VA220("Escrita configuração I/O - timeout", 1);
							return;
						}
						continue;
					}
					if (i == 0)
					{
						this.Mensagem_VA220("Escrita configuração I/O - não determinado", 1);
						return;
					}
				}
				IL_20E:
				i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
				while (i > 0)
				{
					i--;
					Comunicacao.CMD_Tx_condax(0, 0, 103, 0, dados);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						this.Mensagem_VA220("Término de configuração - Ok", 0);
						goto IL_2B2;
					case 2:
						if (i == 0)
						{
							this.Mensagem_VA220("Término de configuração - conferência", 1);
							return;
						}
						continue;
					case 3:
						if (i == 0)
						{
							this.Mensagem_VA220("Término de configuração - timeout", 1);
							return;
						}
						continue;
					}
					if (i == 0)
					{
						this.Mensagem_VA220("Término de configuração - não determinado", 1);
						return;
					}
				}
				IL_2B2:
				this.Mensagem_VA220("Escrita executada com sucesso", 0);
			}
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x00413790 File Offset: 0x00411B90
		private void Valor_end_est_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_end_est.Text)));
			this.Valor_end_est.Text = Conversions.ToString(num);
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA220.End_estacao = num;
			}
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x004137E8 File Offset: 0x00411BE8
		private void Valor_end_mestre_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_end_mestre.Text)));
			this.Valor_end_mestre.Text = Conversions.ToString(num);
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA220.End_mestre = num;
			}
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x00413840 File Offset: 0x00411C40
		private void Valor_temp_ptt_Validating(object sender, CancelEventArgs e)
		{
			checked
			{
				int num = (int)Math.Round(Conversion.Val(this.Valor_temp_ptt.Text));
				this.Valor_temp_ptt.Text = Conversions.ToString(num);
				if (num < 0 | num > 100)
				{
					e.Cancel = true;
				}
				else
				{
					Mod_VA.Config_VA220.Tempo_ptt = (int)Math.Round((double)num / 10.0);
				}
			}
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x004138A8 File Offset: 0x00411CA8
		private void Valor_max_bombas_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_max_bombas.Text)));
			this.Valor_max_bombas.Text = Conversions.ToString(num);
			if (num < 0 | num > 4)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA220.Numero_max_bombas = num;
			}
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x004138FC File Offset: 0x00411CFC
		private void Valor_tempo_entre_acionamentos_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_tempo_entre_acionamentos.Text)));
			this.Valor_tempo_entre_acionamentos.Text = Conversions.ToString(num);
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA220.Tempo_entre_acionamentos = num;
			}
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x00413954 File Offset: 0x00411D54
		private void Valor_tempo_falha_desligar_motor_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_tempo_falha_desligar_motor.Text)));
			this.Valor_tempo_falha_desligar_motor.Text = Conversions.ToString(num);
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA220.Tempo_falha_parada = num;
			}
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x004139AC File Offset: 0x00411DAC
		private void Valor_tempo_falha_ligar_motor_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_tempo_falha_ligar_motor.Text)));
			this.Valor_tempo_falha_ligar_motor.Text = Conversions.ToString(num);
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA220.Tempo_falha_partida = num;
			}
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x00413A04 File Offset: 0x00411E04
		private void Valor_tempo_motor_operando_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_tempo_motor_operando.Text)));
			this.Valor_tempo_motor_operando.Text = Conversions.ToString(num);
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA220.Tempo_minimo_operando = num;
			}
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x00413A5C File Offset: 0x00411E5C
		private void Valor_tempo_motor_parado_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_tempo_motor_parado.Text)));
			this.Valor_tempo_motor_parado.Text = Conversions.ToString(num);
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA220.Tempo_minimo_parado = num;
			}
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x00413AB4 File Offset: 0x00411EB4
		private void ComboBox_modo_operacao_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Modo_operacao = this.ComboBox_modo_operacao.SelectedIndex;
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x00413ACC File Offset: 0x00411ECC
		private void ComboBox_controle_nivel_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Ctrl_nivel_fonte = this.ComboBox_controle_nivel.SelectedIndex;
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x00413AE4 File Offset: 0x00411EE4
		private void ComboBox_E01_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Entradas_digitais[1] = this.ComboBox_E01.SelectedIndex;
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x00413B00 File Offset: 0x00411F00
		private void ComboBox_E02_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Entradas_digitais[2] = this.ComboBox_E02.SelectedIndex;
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x00413B1C File Offset: 0x00411F1C
		private void ComboBox_E03_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Entradas_digitais[3] = this.ComboBox_E03.SelectedIndex;
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x00413B38 File Offset: 0x00411F38
		private void ComboBox_E04_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Entradas_digitais[4] = this.ComboBox_E04.SelectedIndex;
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x00413B54 File Offset: 0x00411F54
		private void ComboBox_E05_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Entradas_digitais[5] = this.ComboBox_E05.SelectedIndex;
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x00413B70 File Offset: 0x00411F70
		private void ComboBox_E06_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Entradas_digitais[6] = this.ComboBox_E06.SelectedIndex;
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x00413B8C File Offset: 0x00411F8C
		private void ComboBox_E07_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Entradas_digitais[7] = this.ComboBox_E07.SelectedIndex;
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x00413BA8 File Offset: 0x00411FA8
		private void ComboBox_E08_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Entradas_digitais[8] = this.ComboBox_E08.SelectedIndex;
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x00413BC4 File Offset: 0x00411FC4
		private void ComboBox_S01_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Saidas_digitais[1] = this.ComboBox_S01.SelectedIndex;
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00413BE0 File Offset: 0x00411FE0
		private void ComboBox_S02_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Saidas_digitais[2] = this.ComboBox_S02.SelectedIndex;
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x00413BFC File Offset: 0x00411FFC
		private void ComboBox_S03_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Saidas_digitais[3] = this.ComboBox_S03.SelectedIndex;
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00413C18 File Offset: 0x00412018
		private void ComboBox_S04_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Saidas_digitais[4] = this.ComboBox_S04.SelectedIndex;
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x00413C34 File Offset: 0x00412034
		private void ComboBox_S05_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Saidas_digitais[5] = this.ComboBox_S05.SelectedIndex;
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x00413C50 File Offset: 0x00412050
		private void ComboBox_S06_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Saidas_digitais[6] = this.ComboBox_S06.SelectedIndex;
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x00413C6C File Offset: 0x0041206C
		private void ComboBox_S07_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Saidas_digitais[7] = this.ComboBox_S07.SelectedIndex;
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x00413C88 File Offset: 0x00412088
		private void ComboBox_S08_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_VA.Config_VA220.Saidas_digitais[8] = this.ComboBox_S08.SelectedIndex;
		}

		// Token: 0x04001A43 RID: 6723
		[AccessedThroughProperty("grupo_parametros_gerais")]
		private GroupBox _grupo_parametros_gerais;

		// Token: 0x04001A44 RID: 6724
		[AccessedThroughProperty("Valor_temp_ptt")]
		private TextBox _Valor_temp_ptt;

		// Token: 0x04001A45 RID: 6725
		[AccessedThroughProperty("Label_tempo_ptt")]
		private Label _Label_tempo_ptt;

		// Token: 0x04001A46 RID: 6726
		[AccessedThroughProperty("Valor_end_mestre")]
		private TextBox _Valor_end_mestre;

		// Token: 0x04001A47 RID: 6727
		[AccessedThroughProperty("Valor_end_est")]
		private TextBox _Valor_end_est;

		// Token: 0x04001A48 RID: 6728
		[AccessedThroughProperty("Label_end_mestre")]
		private Label _Label_end_mestre;

		// Token: 0x04001A49 RID: 6729
		[AccessedThroughProperty("Label_end_est")]
		private Label _Label_end_est;

		// Token: 0x04001A4A RID: 6730
		[AccessedThroughProperty("Grupo_ctrl")]
		private GroupBox _Grupo_ctrl;

		// Token: 0x04001A4B RID: 6731
		[AccessedThroughProperty("Box_Msg")]
		private TextBox _Box_Msg;

		// Token: 0x04001A4C RID: 6732
		[AccessedThroughProperty("Ler_conf_VA220")]
		private Button _Ler_conf_VA220;

		// Token: 0x04001A4D RID: 6733
		[AccessedThroughProperty("Label_Max_bombas")]
		private Label _Label_Max_bombas;

		// Token: 0x04001A4E RID: 6734
		[AccessedThroughProperty("Valor_max_bombas")]
		private TextBox _Valor_max_bombas;

		// Token: 0x04001A4F RID: 6735
		[AccessedThroughProperty("Label_tempo_falha_ligar_motor")]
		private Label _Label_tempo_falha_ligar_motor;

		// Token: 0x04001A50 RID: 6736
		[AccessedThroughProperty("Valor_tempo_falha_ligar_motor")]
		private TextBox _Valor_tempo_falha_ligar_motor;

		// Token: 0x04001A51 RID: 6737
		[AccessedThroughProperty("Label_tempo_falha_desligar_motor")]
		private Label _Label_tempo_falha_desligar_motor;

		// Token: 0x04001A52 RID: 6738
		[AccessedThroughProperty("Valor_tempo_falha_desligar_motor")]
		private TextBox _Valor_tempo_falha_desligar_motor;

		// Token: 0x04001A53 RID: 6739
		[AccessedThroughProperty("Label_tempo_minimo_motor_ligado")]
		private Label _Label_tempo_minimo_motor_ligado;

		// Token: 0x04001A54 RID: 6740
		[AccessedThroughProperty("Valor_tempo_motor_operando")]
		private TextBox _Valor_tempo_motor_operando;

		// Token: 0x04001A55 RID: 6741
		[AccessedThroughProperty("Label_tempo_minimo_motor_parado")]
		private Label _Label_tempo_minimo_motor_parado;

		// Token: 0x04001A56 RID: 6742
		[AccessedThroughProperty("Valor_tempo_motor_parado")]
		private TextBox _Valor_tempo_motor_parado;

		// Token: 0x04001A57 RID: 6743
		[AccessedThroughProperty("Label_tempo_entre_acionamentos")]
		private Label _Label_tempo_entre_acionamentos;

		// Token: 0x04001A58 RID: 6744
		[AccessedThroughProperty("Valor_tempo_entre_acionamentos")]
		private TextBox _Valor_tempo_entre_acionamentos;

		// Token: 0x04001A59 RID: 6745
		[AccessedThroughProperty("ComboBox_modo_operacao")]
		private ComboBox _ComboBox_modo_operacao;

		// Token: 0x04001A5A RID: 6746
		[AccessedThroughProperty("Label_modo_operacao")]
		private Label _Label_modo_operacao;

		// Token: 0x04001A5B RID: 6747
		[AccessedThroughProperty("ComboBox_controle_nivel")]
		private ComboBox _ComboBox_controle_nivel;

		// Token: 0x04001A5C RID: 6748
		[AccessedThroughProperty("Label_controle_nivel")]
		private Label _Label_controle_nivel;

		// Token: 0x04001A5D RID: 6749
		[AccessedThroughProperty("grupo_programacao_io")]
		private GroupBox _grupo_programacao_io;

		// Token: 0x04001A5E RID: 6750
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04001A5F RID: 6751
		[AccessedThroughProperty("ComboBox_E01")]
		private ComboBox _ComboBox_E01;

		// Token: 0x04001A60 RID: 6752
		[AccessedThroughProperty("Label_E08")]
		private Label _Label_E08;

		// Token: 0x04001A61 RID: 6753
		[AccessedThroughProperty("Label_E07")]
		private Label _Label_E07;

		// Token: 0x04001A62 RID: 6754
		[AccessedThroughProperty("Label_E06")]
		private Label _Label_E06;

		// Token: 0x04001A63 RID: 6755
		[AccessedThroughProperty("Label_E05")]
		private Label _Label_E05;

		// Token: 0x04001A64 RID: 6756
		[AccessedThroughProperty("Label_E04")]
		private Label _Label_E04;

		// Token: 0x04001A65 RID: 6757
		[AccessedThroughProperty("Label_E03")]
		private Label _Label_E03;

		// Token: 0x04001A66 RID: 6758
		[AccessedThroughProperty("Label_E02")]
		private Label _Label_E02;

		// Token: 0x04001A67 RID: 6759
		[AccessedThroughProperty("Label_E01")]
		private Label _Label_E01;

		// Token: 0x04001A68 RID: 6760
		[AccessedThroughProperty("ComboBox_E08")]
		private ComboBox _ComboBox_E08;

		// Token: 0x04001A69 RID: 6761
		[AccessedThroughProperty("ComboBox_E07")]
		private ComboBox _ComboBox_E07;

		// Token: 0x04001A6A RID: 6762
		[AccessedThroughProperty("ComboBox_E06")]
		private ComboBox _ComboBox_E06;

		// Token: 0x04001A6B RID: 6763
		[AccessedThroughProperty("ComboBox_E05")]
		private ComboBox _ComboBox_E05;

		// Token: 0x04001A6C RID: 6764
		[AccessedThroughProperty("ComboBox_E04")]
		private ComboBox _ComboBox_E04;

		// Token: 0x04001A6D RID: 6765
		[AccessedThroughProperty("ComboBox_E03")]
		private ComboBox _ComboBox_E03;

		// Token: 0x04001A6E RID: 6766
		[AccessedThroughProperty("ComboBox_E02")]
		private ComboBox _ComboBox_E02;

		// Token: 0x04001A6F RID: 6767
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04001A70 RID: 6768
		[AccessedThroughProperty("ComboBox_S08")]
		private ComboBox _ComboBox_S08;

		// Token: 0x04001A71 RID: 6769
		[AccessedThroughProperty("ComboBox_S07")]
		private ComboBox _ComboBox_S07;

		// Token: 0x04001A72 RID: 6770
		[AccessedThroughProperty("ComboBox_S06")]
		private ComboBox _ComboBox_S06;

		// Token: 0x04001A73 RID: 6771
		[AccessedThroughProperty("ComboBox_S05")]
		private ComboBox _ComboBox_S05;

		// Token: 0x04001A74 RID: 6772
		[AccessedThroughProperty("ComboBox_S04")]
		private ComboBox _ComboBox_S04;

		// Token: 0x04001A75 RID: 6773
		[AccessedThroughProperty("ComboBox_S03")]
		private ComboBox _ComboBox_S03;

		// Token: 0x04001A76 RID: 6774
		[AccessedThroughProperty("ComboBox_S02")]
		private ComboBox _ComboBox_S02;

		// Token: 0x04001A77 RID: 6775
		[AccessedThroughProperty("ComboBox_S01")]
		private ComboBox _ComboBox_S01;

		// Token: 0x04001A78 RID: 6776
		[AccessedThroughProperty("Label_S08")]
		private Label _Label_S08;

		// Token: 0x04001A79 RID: 6777
		[AccessedThroughProperty("Label_S07")]
		private Label _Label_S07;

		// Token: 0x04001A7A RID: 6778
		[AccessedThroughProperty("Label_S06")]
		private Label _Label_S06;

		// Token: 0x04001A7B RID: 6779
		[AccessedThroughProperty("Label_S05")]
		private Label _Label_S05;

		// Token: 0x04001A7C RID: 6780
		[AccessedThroughProperty("Label_S04")]
		private Label _Label_S04;

		// Token: 0x04001A7D RID: 6781
		[AccessedThroughProperty("Label_S03")]
		private Label _Label_S03;

		// Token: 0x04001A7E RID: 6782
		[AccessedThroughProperty("Label_S02")]
		private Label _Label_S02;

		// Token: 0x04001A7F RID: 6783
		[AccessedThroughProperty("Label_S01")]
		private Label _Label_S01;
	}
}
