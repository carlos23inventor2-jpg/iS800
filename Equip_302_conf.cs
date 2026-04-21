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
	// Token: 0x02000087 RID: 135
	[DesignerGenerated]
	public partial class Equip_302_conf : Form
	{
		// Token: 0x0600219C RID: 8604 RVA: 0x003F6B80 File Offset: 0x003F4F80
		public Equip_302_conf()
		{
			base.Load += new EventHandler(this.Equip_302_conf_Load);
			this.InitializeComponent();
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x0600219F RID: 8607 RVA: 0x003FA55C File Offset: 0x003F895C
		// (set) Token: 0x060021A0 RID: 8608 RVA: 0x003FA570 File Offset: 0x003F8970
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

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x060021A1 RID: 8609 RVA: 0x003FA57C File Offset: 0x003F897C
		// (set) Token: 0x060021A2 RID: 8610 RVA: 0x003FA590 File Offset: 0x003F8990
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

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x003FA59C File Offset: 0x003F899C
		// (set) Token: 0x060021A4 RID: 8612 RVA: 0x003FA5B0 File Offset: 0x003F89B0
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

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060021A5 RID: 8613 RVA: 0x003FA5FC File Offset: 0x003F89FC
		// (set) Token: 0x060021A6 RID: 8614 RVA: 0x003FA610 File Offset: 0x003F8A10
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

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x003FA61C File Offset: 0x003F8A1C
		// (set) Token: 0x060021A8 RID: 8616 RVA: 0x003FA630 File Offset: 0x003F8A30
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

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x003FA67C File Offset: 0x003F8A7C
		// (set) Token: 0x060021AA RID: 8618 RVA: 0x003FA690 File Offset: 0x003F8A90
		internal virtual NumericUpDown Valor_endereco
		{
			get
			{
				return this._Valor_endereco;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_endereco_ValueChanged);
				if (this._Valor_endereco != null)
				{
					this._Valor_endereco.ValueChanged -= eventHandler;
				}
				this._Valor_endereco = value;
				if (this._Valor_endereco != null)
				{
					this._Valor_endereco.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x003FA6DC File Offset: 0x003F8ADC
		// (set) Token: 0x060021AC RID: 8620 RVA: 0x003FA6F0 File Offset: 0x003F8AF0
		internal virtual NumericUpDown Valor_num_tentativas
		{
			get
			{
				return this._Valor_num_tentativas;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_num_tentativas_ValueChanged);
				if (this._Valor_num_tentativas != null)
				{
					this._Valor_num_tentativas.ValueChanged -= eventHandler;
				}
				this._Valor_num_tentativas = value;
				if (this._Valor_num_tentativas != null)
				{
					this._Valor_num_tentativas.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x003FA73C File Offset: 0x003F8B3C
		// (set) Token: 0x060021AE RID: 8622 RVA: 0x003FA750 File Offset: 0x003F8B50
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

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x003FA75C File Offset: 0x003F8B5C
		// (set) Token: 0x060021B0 RID: 8624 RVA: 0x003FA770 File Offset: 0x003F8B70
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

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x003FA77C File Offset: 0x003F8B7C
		// (set) Token: 0x060021B2 RID: 8626 RVA: 0x003FA790 File Offset: 0x003F8B90
		internal virtual Label Label_retry
		{
			get
			{
				return this._Label_retry;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_retry = value;
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x003FA79C File Offset: 0x003F8B9C
		// (set) Token: 0x060021B4 RID: 8628 RVA: 0x003FA7B0 File Offset: 0x003F8BB0
		internal virtual NumericUpDown Valor_timeout
		{
			get
			{
				return this._Valor_timeout;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_timeout_ValueChanged);
				if (this._Valor_timeout != null)
				{
					this._Valor_timeout.ValueChanged -= eventHandler;
				}
				this._Valor_timeout = value;
				if (this._Valor_timeout != null)
				{
					this._Valor_timeout.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x003FA7FC File Offset: 0x003F8BFC
		// (set) Token: 0x060021B6 RID: 8630 RVA: 0x003FA810 File Offset: 0x003F8C10
		internal virtual Label Label_timeout
		{
			get
			{
				return this._Label_timeout;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_timeout = value;
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x003FA81C File Offset: 0x003F8C1C
		// (set) Token: 0x060021B8 RID: 8632 RVA: 0x003FA830 File Offset: 0x003F8C30
		internal virtual NumericUpDown Valor_intervalo_polling
		{
			get
			{
				return this._Valor_intervalo_polling;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_intervalo_polling_ValueChanged);
				if (this._Valor_intervalo_polling != null)
				{
					this._Valor_intervalo_polling.ValueChanged -= eventHandler;
				}
				this._Valor_intervalo_polling = value;
				if (this._Valor_intervalo_polling != null)
				{
					this._Valor_intervalo_polling.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x003FA87C File Offset: 0x003F8C7C
		// (set) Token: 0x060021BA RID: 8634 RVA: 0x003FA890 File Offset: 0x003F8C90
		internal virtual Label Label_intervalo_polling
		{
			get
			{
				return this._Label_intervalo_polling;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_intervalo_polling = value;
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x003FA89C File Offset: 0x003F8C9C
		// (set) Token: 0x060021BC RID: 8636 RVA: 0x003FA8B0 File Offset: 0x003F8CB0
		internal virtual NumericUpDown Valor_erro_falha
		{
			get
			{
				return this._Valor_erro_falha;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_erro_falha_ValueChanged);
				if (this._Valor_erro_falha != null)
				{
					this._Valor_erro_falha.ValueChanged -= eventHandler;
				}
				this._Valor_erro_falha = value;
				if (this._Valor_erro_falha != null)
				{
					this._Valor_erro_falha.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x003FA8FC File Offset: 0x003F8CFC
		// (set) Token: 0x060021BE RID: 8638 RVA: 0x003FA910 File Offset: 0x003F8D10
		internal virtual Label Label_erros_falha
		{
			get
			{
				return this._Label_erros_falha;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_erros_falha = value;
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x003FA91C File Offset: 0x003F8D1C
		// (set) Token: 0x060021C0 RID: 8640 RVA: 0x003FA930 File Offset: 0x003F8D30
		internal virtual GroupBox Grupo_conf_equipamentos
		{
			get
			{
				return this._Grupo_conf_equipamentos;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_conf_equipamentos = value;
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x003FA93C File Offset: 0x003F8D3C
		// (set) Token: 0x060021C2 RID: 8642 RVA: 0x003FA950 File Offset: 0x003F8D50
		internal virtual NumericUpDown Valor_res_equipamentos
		{
			get
			{
				return this._Valor_res_equipamentos;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_res_equipamentos_ValueChanged);
				if (this._Valor_res_equipamentos != null)
				{
					this._Valor_res_equipamentos.ValueChanged -= eventHandler;
				}
				this._Valor_res_equipamentos = value;
				if (this._Valor_res_equipamentos != null)
				{
					this._Valor_res_equipamentos.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x003FA99C File Offset: 0x003F8D9C
		// (set) Token: 0x060021C4 RID: 8644 RVA: 0x003FA9B0 File Offset: 0x003F8DB0
		internal virtual Label Label_res_equipamentos
		{
			get
			{
				return this._Label_res_equipamentos;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_res_equipamentos = value;
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x003FA9BC File Offset: 0x003F8DBC
		// (set) Token: 0x060021C6 RID: 8646 RVA: 0x003FA9D0 File Offset: 0x003F8DD0
		internal virtual NumericUpDown Valor_res_sistema
		{
			get
			{
				return this._Valor_res_sistema;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_res_sistema_ValueChanged);
				if (this._Valor_res_sistema != null)
				{
					this._Valor_res_sistema.ValueChanged -= eventHandler;
				}
				this._Valor_res_sistema = value;
				if (this._Valor_res_sistema != null)
				{
					this._Valor_res_sistema.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x003FAA1C File Offset: 0x003F8E1C
		// (set) Token: 0x060021C8 RID: 8648 RVA: 0x003FAA30 File Offset: 0x003F8E30
		internal virtual Label Label_res_sistema
		{
			get
			{
				return this._Label_res_sistema;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_res_sistema = value;
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x003FAA3C File Offset: 0x003F8E3C
		// (set) Token: 0x060021CA RID: 8650 RVA: 0x003FAA50 File Offset: 0x003F8E50
		internal virtual NumericUpDown Valor_end_ini_vista
		{
			get
			{
				return this._Valor_end_ini_vista;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_end_ini_vista_ValueChanged);
				if (this._Valor_end_ini_vista != null)
				{
					this._Valor_end_ini_vista.ValueChanged -= eventHandler;
				}
				this._Valor_end_ini_vista = value;
				if (this._Valor_end_ini_vista != null)
				{
					this._Valor_end_ini_vista.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x003FAA9C File Offset: 0x003F8E9C
		// (set) Token: 0x060021CC RID: 8652 RVA: 0x003FAAB0 File Offset: 0x003F8EB0
		internal virtual Label Label_end_ini_vista
		{
			get
			{
				return this._Label_end_ini_vista;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_ini_vista = value;
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x003FAABC File Offset: 0x003F8EBC
		// (set) Token: 0x060021CE RID: 8654 RVA: 0x003FAAD0 File Offset: 0x003F8ED0
		internal virtual NumericUpDown Valor_end_ini_rq
		{
			get
			{
				return this._Valor_end_ini_rq;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_end_ini_rq_ValueChanged);
				if (this._Valor_end_ini_rq != null)
				{
					this._Valor_end_ini_rq.ValueChanged -= eventHandler;
				}
				this._Valor_end_ini_rq = value;
				if (this._Valor_end_ini_rq != null)
				{
					this._Valor_end_ini_rq.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x003FAB1C File Offset: 0x003F8F1C
		// (set) Token: 0x060021D0 RID: 8656 RVA: 0x003FAB30 File Offset: 0x003F8F30
		internal virtual Label Label_end_ini_rq
		{
			get
			{
				return this._Label_end_ini_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_ini_rq = value;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x003FAB3C File Offset: 0x003F8F3C
		// (set) Token: 0x060021D2 RID: 8658 RVA: 0x003FAB50 File Offset: 0x003F8F50
		internal virtual NumericUpDown Valor_end_ini_res
		{
			get
			{
				return this._Valor_end_ini_res;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_end_ini_res_ValueChanged);
				if (this._Valor_end_ini_res != null)
				{
					this._Valor_end_ini_res.ValueChanged -= eventHandler;
				}
				this._Valor_end_ini_res = value;
				if (this._Valor_end_ini_res != null)
				{
					this._Valor_end_ini_res.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x003FAB9C File Offset: 0x003F8F9C
		// (set) Token: 0x060021D4 RID: 8660 RVA: 0x003FABB0 File Offset: 0x003F8FB0
		internal virtual Label Label_end_ini_res
		{
			get
			{
				return this._Label_end_ini_res;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_ini_res = value;
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x003FABBC File Offset: 0x003F8FBC
		// (set) Token: 0x060021D6 RID: 8662 RVA: 0x003FABD0 File Offset: 0x003F8FD0
		internal virtual NumericUpDown Valor_rq_equipamentos
		{
			get
			{
				return this._Valor_rq_equipamentos;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_rq_equipamentos_ValueChanged);
				if (this._Valor_rq_equipamentos != null)
				{
					this._Valor_rq_equipamentos.ValueChanged -= eventHandler;
				}
				this._Valor_rq_equipamentos = value;
				if (this._Valor_rq_equipamentos != null)
				{
					this._Valor_rq_equipamentos.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x003FAC1C File Offset: 0x003F901C
		// (set) Token: 0x060021D8 RID: 8664 RVA: 0x003FAC30 File Offset: 0x003F9030
		internal virtual Label Label_rq_equipamentos
		{
			get
			{
				return this._Label_rq_equipamentos;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_rq_equipamentos = value;
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x003FAC3C File Offset: 0x003F903C
		// (set) Token: 0x060021DA RID: 8666 RVA: 0x003FAC50 File Offset: 0x003F9050
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

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x003FAC5C File Offset: 0x003F905C
		// (set) Token: 0x060021DC RID: 8668 RVA: 0x003FAC70 File Offset: 0x003F9070
		internal virtual Button Esc_conf_md_302
		{
			get
			{
				return this._Esc_conf_md_302;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Esc_conf_md_302_Click);
				if (this._Esc_conf_md_302 != null)
				{
					this._Esc_conf_md_302.Click -= eventHandler;
				}
				this._Esc_conf_md_302 = value;
				if (this._Esc_conf_md_302 != null)
				{
					this._Esc_conf_md_302.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x003FACBC File Offset: 0x003F90BC
		// (set) Token: 0x060021DE RID: 8670 RVA: 0x003FACD0 File Offset: 0x003F90D0
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

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x003FACDC File Offset: 0x003F90DC
		// (set) Token: 0x060021E0 RID: 8672 RVA: 0x003FACF0 File Offset: 0x003F90F0
		internal virtual Button Ler_conf_md_302
		{
			get
			{
				return this._Ler_conf_md_302;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Ler_conf_md_302_Click);
				if (this._Ler_conf_md_302 != null)
				{
					this._Ler_conf_md_302.Click -= eventHandler;
				}
				this._Ler_conf_md_302 = value;
				if (this._Ler_conf_md_302 != null)
				{
					this._Ler_conf_md_302.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x003FAD3C File Offset: 0x003F913C
		// (set) Token: 0x060021E2 RID: 8674 RVA: 0x003FAD50 File Offset: 0x003F9150
		internal virtual TabControl TabControl2
		{
			get
			{
				return this._TabControl2;
			}
			[MethodImpl(32)]
			set
			{
				this._TabControl2 = value;
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x003FAD5C File Offset: 0x003F915C
		// (set) Token: 0x060021E4 RID: 8676 RVA: 0x003FAD70 File Offset: 0x003F9170
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

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x060021E5 RID: 8677 RVA: 0x003FAD7C File Offset: 0x003F917C
		// (set) Token: 0x060021E6 RID: 8678 RVA: 0x003FAD90 File Offset: 0x003F9190
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

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x060021E7 RID: 8679 RVA: 0x003FAD9C File Offset: 0x003F919C
		// (set) Token: 0x060021E8 RID: 8680 RVA: 0x003FADB0 File Offset: 0x003F91B0
		internal virtual TabPage Conf_centrais
		{
			get
			{
				return this._Conf_centrais;
			}
			[MethodImpl(32)]
			set
			{
				this._Conf_centrais = value;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x060021E9 RID: 8681 RVA: 0x003FADBC File Offset: 0x003F91BC
		// (set) Token: 0x060021EA RID: 8682 RVA: 0x003FADD0 File Offset: 0x003F91D0
		internal virtual DataGridView DataGridView1
		{
			get
			{
				return this._DataGridView1;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView1_CellValidating);
				if (this._DataGridView1 != null)
				{
					this._DataGridView1.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView1 = value;
				if (this._DataGridView1 != null)
				{
					this._DataGridView1.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x060021EB RID: 8683 RVA: 0x003FAE1C File Offset: 0x003F921C
		// (set) Token: 0x060021EC RID: 8684 RVA: 0x003FAE30 File Offset: 0x003F9230
		internal virtual NumericUpDown Valor_vista_equipamentos
		{
			get
			{
				return this._Valor_vista_equipamentos;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_vista_equipamentos_ValueChanged);
				if (this._Valor_vista_equipamentos != null)
				{
					this._Valor_vista_equipamentos.ValueChanged -= eventHandler;
				}
				this._Valor_vista_equipamentos = value;
				if (this._Valor_vista_equipamentos != null)
				{
					this._Valor_vista_equipamentos.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x060021ED RID: 8685 RVA: 0x003FAE7C File Offset: 0x003F927C
		// (set) Token: 0x060021EE RID: 8686 RVA: 0x003FAE90 File Offset: 0x003F9290
		internal virtual Label Label_vista_equipamentos
		{
			get
			{
				return this._Label_vista_equipamentos;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_vista_equipamentos = value;
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x060021EF RID: 8687 RVA: 0x003FAE9C File Offset: 0x003F929C
		// (set) Token: 0x060021F0 RID: 8688 RVA: 0x003FAEB0 File Offset: 0x003F92B0
		internal virtual DataGridView DataGridView_RQ
		{
			get
			{
				return this._DataGridView_RQ;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_RQ_CellValidating);
				if (this._DataGridView_RQ != null)
				{
					this._DataGridView_RQ.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_RQ = value;
				if (this._DataGridView_RQ != null)
				{
					this._DataGridView_RQ.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x060021F1 RID: 8689 RVA: 0x003FAEFC File Offset: 0x003F92FC
		// (set) Token: 0x060021F2 RID: 8690 RVA: 0x003FAF10 File Offset: 0x003F9310
		internal virtual DataGridView DataGridView_central_geral
		{
			get
			{
				return this._DataGridView_central_geral;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_central_geral_CellValidating);
				if (this._DataGridView_central_geral != null)
				{
					this._DataGridView_central_geral.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_central_geral = value;
				if (this._DataGridView_central_geral != null)
				{
					this._DataGridView_central_geral.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x060021F3 RID: 8691 RVA: 0x003FAF5C File Offset: 0x003F935C
		// (set) Token: 0x060021F4 RID: 8692 RVA: 0x003FAF70 File Offset: 0x003F9370
		internal virtual DataGridView DataGridView_central_rq
		{
			get
			{
				return this._DataGridView_central_rq;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_central_rq_CellValidating);
				DataGridViewCellPaintingEventHandler dataGridViewCellPaintingEventHandler = new DataGridViewCellPaintingEventHandler(this.DataGridView_central_rq_CellPainting);
				if (this._DataGridView_central_rq != null)
				{
					this._DataGridView_central_rq.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_central_rq.CellPainting -= dataGridViewCellPaintingEventHandler;
				}
				this._DataGridView_central_rq = value;
				if (this._DataGridView_central_rq != null)
				{
					this._DataGridView_central_rq.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_central_rq.CellPainting += dataGridViewCellPaintingEventHandler;
				}
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x060021F5 RID: 8693 RVA: 0x003FAFE0 File Offset: 0x003F93E0
		// (set) Token: 0x060021F6 RID: 8694 RVA: 0x003FAFF4 File Offset: 0x003F93F4
		internal virtual DataGridView DataGridView_central_res
		{
			get
			{
				return this._DataGridView_central_res;
			}
			[MethodImpl(32)]
			set
			{
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_central_res_CellValidating);
				DataGridViewCellPaintingEventHandler dataGridViewCellPaintingEventHandler = new DataGridViewCellPaintingEventHandler(this.DataGridView_central_res_CellPainting);
				if (this._DataGridView_central_res != null)
				{
					this._DataGridView_central_res.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_central_res.CellPainting -= dataGridViewCellPaintingEventHandler;
				}
				this._DataGridView_central_res = value;
				if (this._DataGridView_central_res != null)
				{
					this._DataGridView_central_res.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_central_res.CellPainting += dataGridViewCellPaintingEventHandler;
				}
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x003FB064 File Offset: 0x003F9464
		// (set) Token: 0x060021F8 RID: 8696 RVA: 0x003FB078 File Offset: 0x003F9478
		internal virtual Label Label_rq
		{
			get
			{
				return this._Label_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_rq = value;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x003FB084 File Offset: 0x003F9484
		// (set) Token: 0x060021FA RID: 8698 RVA: 0x003FB098 File Offset: 0x003F9498
		internal virtual Label Label_res
		{
			get
			{
				return this._Label_res;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_res = value;
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x060021FB RID: 8699 RVA: 0x003FB0A4 File Offset: 0x003F94A4
		// (set) Token: 0x060021FC RID: 8700 RVA: 0x003FB0B8 File Offset: 0x003F94B8
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

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x003FB0C4 File Offset: 0x003F94C4
		// (set) Token: 0x060021FE RID: 8702 RVA: 0x003FB0D8 File Offset: 0x003F94D8
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

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x003FB0E4 File Offset: 0x003F94E4
		// (set) Token: 0x06002200 RID: 8704 RVA: 0x003FB0F8 File Offset: 0x003F94F8
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

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x003FB144 File Offset: 0x003F9544
		// (set) Token: 0x06002202 RID: 8706 RVA: 0x003FB158 File Offset: 0x003F9558
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

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x003FB1A4 File Offset: 0x003F95A4
		// (set) Token: 0x06002204 RID: 8708 RVA: 0x003FB1B8 File Offset: 0x003F95B8
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

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x003FB204 File Offset: 0x003F9604
		// (set) Token: 0x06002206 RID: 8710 RVA: 0x003FB218 File Offset: 0x003F9618
		internal virtual DataGridViewTextBoxColumn Col_vista_end
		{
			get
			{
				return this._Col_vista_end;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_vista_end = value;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x003FB224 File Offset: 0x003F9624
		// (set) Token: 0x06002208 RID: 8712 RVA: 0x003FB238 File Offset: 0x003F9638
		internal virtual DataGridViewTextBoxColumn Col_vista_res
		{
			get
			{
				return this._Col_vista_res;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_vista_res = value;
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x003FB244 File Offset: 0x003F9644
		// (set) Token: 0x0600220A RID: 8714 RVA: 0x003FB258 File Offset: 0x003F9658
		internal virtual DataGridViewTextBoxColumn Col_vista_rq
		{
			get
			{
				return this._Col_vista_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_vista_rq = value;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x003FB264 File Offset: 0x003F9664
		// (set) Token: 0x0600220C RID: 8716 RVA: 0x003FB278 File Offset: 0x003F9678
		internal virtual DataGridViewTextBoxColumn Col_vista_pri
		{
			get
			{
				return this._Col_vista_pri;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_vista_pri = value;
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x003FB284 File Offset: 0x003F9684
		// (set) Token: 0x0600220E RID: 8718 RVA: 0x003FB298 File Offset: 0x003F9698
		internal virtual DataGridViewTextBoxColumn Col_ct_rq_end
		{
			get
			{
				return this._Col_ct_rq_end;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_ct_rq_end = value;
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x003FB2A4 File Offset: 0x003F96A4
		// (set) Token: 0x06002210 RID: 8720 RVA: 0x003FB2B8 File Offset: 0x003F96B8
		internal virtual DataGridViewTextBoxColumn Col_ct_res_end
		{
			get
			{
				return this._Col_ct_res_end;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_ct_res_end = value;
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06002211 RID: 8721 RVA: 0x003FB2C4 File Offset: 0x003F96C4
		// (set) Token: 0x06002212 RID: 8722 RVA: 0x003FB2D8 File Offset: 0x003F96D8
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

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06002213 RID: 8723 RVA: 0x003FB2E4 File Offset: 0x003F96E4
		// (set) Token: 0x06002214 RID: 8724 RVA: 0x003FB2F8 File Offset: 0x003F96F8
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

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x003FB304 File Offset: 0x003F9704
		// (set) Token: 0x06002216 RID: 8726 RVA: 0x003FB318 File Offset: 0x003F9718
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

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06002217 RID: 8727 RVA: 0x003FB324 File Offset: 0x003F9724
		// (set) Token: 0x06002218 RID: 8728 RVA: 0x003FB338 File Offset: 0x003F9738
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

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06002219 RID: 8729 RVA: 0x003FB344 File Offset: 0x003F9744
		// (set) Token: 0x0600221A RID: 8730 RVA: 0x003FB358 File Offset: 0x003F9758
		internal virtual DataGridViewTextBoxColumn Col_altura
		{
			get
			{
				return this._Col_altura;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_altura = value;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x0600221B RID: 8731 RVA: 0x003FB364 File Offset: 0x003F9764
		// (set) Token: 0x0600221C RID: 8732 RVA: 0x003FB378 File Offset: 0x003F9778
		internal virtual DataGridViewTextBoxColumn Col_pri
		{
			get
			{
				return this._Col_pri;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_pri = value;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x0600221D RID: 8733 RVA: 0x003FB384 File Offset: 0x003F9784
		// (set) Token: 0x0600221E RID: 8734 RVA: 0x003FB398 File Offset: 0x003F9798
		internal virtual DataGridViewTextBoxColumn Col_posicao
		{
			get
			{
				return this._Col_posicao;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_posicao = value;
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x0600221F RID: 8735 RVA: 0x003FB3A4 File Offset: 0x003F97A4
		// (set) Token: 0x06002220 RID: 8736 RVA: 0x003FB3B8 File Offset: 0x003F97B8
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

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06002221 RID: 8737 RVA: 0x003FB3C4 File Offset: 0x003F97C4
		// (set) Token: 0x06002222 RID: 8738 RVA: 0x003FB3D8 File Offset: 0x003F97D8
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

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x003FB3E4 File Offset: 0x003F97E4
		// (set) Token: 0x06002224 RID: 8740 RVA: 0x003FB3F8 File Offset: 0x003F97F8
		internal virtual DataGridViewTextBoxColumn Col_ROrg_rq
		{
			get
			{
				return this._Col_ROrg_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_ROrg_rq = value;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06002225 RID: 8741 RVA: 0x003FB404 File Offset: 0x003F9804
		// (set) Token: 0x06002226 RID: 8742 RVA: 0x003FB418 File Offset: 0x003F9818
		internal virtual DataGridViewTextBoxColumn Col_RDest_rq
		{
			get
			{
				return this._Col_RDest_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_RDest_rq = value;
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06002227 RID: 8743 RVA: 0x003FB424 File Offset: 0x003F9824
		// (set) Token: 0x06002228 RID: 8744 RVA: 0x003FB438 File Offset: 0x003F9838
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

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06002229 RID: 8745 RVA: 0x003FB444 File Offset: 0x003F9844
		// (set) Token: 0x0600222A RID: 8746 RVA: 0x003FB458 File Offset: 0x003F9858
		internal virtual DataGridViewTextBoxColumn Col_pri_rq
		{
			get
			{
				return this._Col_pri_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_pri_rq = value;
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x0600222B RID: 8747 RVA: 0x003FB464 File Offset: 0x003F9864
		// (set) Token: 0x0600222C RID: 8748 RVA: 0x003FB478 File Offset: 0x003F9878
		internal virtual DataGridViewTextBoxColumn Col_Res1_rq
		{
			get
			{
				return this._Col_Res1_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Res1_rq = value;
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x0600222D RID: 8749 RVA: 0x003FB484 File Offset: 0x003F9884
		// (set) Token: 0x0600222E RID: 8750 RVA: 0x003FB498 File Offset: 0x003F9898
		internal virtual DataGridViewTextBoxColumn Col_Res2_rq
		{
			get
			{
				return this._Col_Res2_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Res2_rq = value;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x003FB4A4 File Offset: 0x003F98A4
		// (set) Token: 0x06002230 RID: 8752 RVA: 0x003FB4B8 File Offset: 0x003F98B8
		internal virtual DataGridViewTextBoxColumn Col_Res3_rq
		{
			get
			{
				return this._Col_Res3_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Res3_rq = value;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06002231 RID: 8753 RVA: 0x003FB4C4 File Offset: 0x003F98C4
		// (set) Token: 0x06002232 RID: 8754 RVA: 0x003FB4D8 File Offset: 0x003F98D8
		internal virtual DataGridViewTextBoxColumn Col_Res4_rq
		{
			get
			{
				return this._Col_Res4_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_Res4_rq = value;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06002233 RID: 8755 RVA: 0x003FB4E4 File Offset: 0x003F98E4
		// (set) Token: 0x06002234 RID: 8756 RVA: 0x003FB4F8 File Offset: 0x003F98F8
		internal virtual DataGridViewTextBoxColumn Col_MsgR1_rq
		{
			get
			{
				return this._Col_MsgR1_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_MsgR1_rq = value;
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x003FB504 File Offset: 0x003F9904
		// (set) Token: 0x06002236 RID: 8758 RVA: 0x003FB518 File Offset: 0x003F9918
		internal virtual DataGridViewTextBoxColumn Col_MsgR2_rq
		{
			get
			{
				return this._Col_MsgR2_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_MsgR2_rq = value;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06002237 RID: 8759 RVA: 0x003FB524 File Offset: 0x003F9924
		// (set) Token: 0x06002238 RID: 8760 RVA: 0x003FB538 File Offset: 0x003F9938
		internal virtual DataGridViewTextBoxColumn Col_MsgR3_rq
		{
			get
			{
				return this._Col_MsgR3_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_MsgR3_rq = value;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x003FB544 File Offset: 0x003F9944
		// (set) Token: 0x0600223A RID: 8762 RVA: 0x003FB558 File Offset: 0x003F9958
		internal virtual DataGridViewTextBoxColumn Col_MsgR4_rq
		{
			get
			{
				return this._Col_MsgR4_rq;
			}
			[MethodImpl(32)]
			set
			{
				this._Col_MsgR4_rq = value;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x0600223B RID: 8763 RVA: 0x003FB564 File Offset: 0x003F9964
		// (set) Token: 0x0600223C RID: 8764 RVA: 0x003FB578 File Offset: 0x003F9978
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

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x0600223D RID: 8765 RVA: 0x003FB584 File Offset: 0x003F9984
		// (set) Token: 0x0600223E RID: 8766 RVA: 0x003FB598 File Offset: 0x003F9998
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

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x0600223F RID: 8767 RVA: 0x003FB5A4 File Offset: 0x003F99A4
		// (set) Token: 0x06002240 RID: 8768 RVA: 0x003FB5B8 File Offset: 0x003F99B8
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

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06002241 RID: 8769 RVA: 0x003FB5C4 File Offset: 0x003F99C4
		// (set) Token: 0x06002242 RID: 8770 RVA: 0x003FB5D8 File Offset: 0x003F99D8
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

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06002243 RID: 8771 RVA: 0x003FB5E4 File Offset: 0x003F99E4
		// (set) Token: 0x06002244 RID: 8772 RVA: 0x003FB5F8 File Offset: 0x003F99F8
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

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x003FB604 File Offset: 0x003F9A04
		// (set) Token: 0x06002246 RID: 8774 RVA: 0x003FB618 File Offset: 0x003F9A18
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

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x003FB624 File Offset: 0x003F9A24
		// (set) Token: 0x06002248 RID: 8776 RVA: 0x003FB638 File Offset: 0x003F9A38
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

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x003FB644 File Offset: 0x003F9A44
		// (set) Token: 0x0600224A RID: 8778 RVA: 0x003FB658 File Offset: 0x003F9A58
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

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x003FB664 File Offset: 0x003F9A64
		// (set) Token: 0x0600224C RID: 8780 RVA: 0x003FB678 File Offset: 0x003F9A78
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

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x003FB684 File Offset: 0x003F9A84
		// (set) Token: 0x0600224E RID: 8782 RVA: 0x003FB698 File Offset: 0x003F9A98
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

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x003FB6A4 File Offset: 0x003F9AA4
		// (set) Token: 0x06002250 RID: 8784 RVA: 0x003FB6B8 File Offset: 0x003F9AB8
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

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x003FB6C4 File Offset: 0x003F9AC4
		// (set) Token: 0x06002252 RID: 8786 RVA: 0x003FB6D8 File Offset: 0x003F9AD8
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

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06002253 RID: 8787 RVA: 0x003FB6E4 File Offset: 0x003F9AE4
		// (set) Token: 0x06002254 RID: 8788 RVA: 0x003FB6F8 File Offset: 0x003F9AF8
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

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06002255 RID: 8789 RVA: 0x003FB704 File Offset: 0x003F9B04
		// (set) Token: 0x06002256 RID: 8790 RVA: 0x003FB718 File Offset: 0x003F9B18
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

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06002257 RID: 8791 RVA: 0x003FB724 File Offset: 0x003F9B24
		// (set) Token: 0x06002258 RID: 8792 RVA: 0x003FB738 File Offset: 0x003F9B38
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

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x003FB744 File Offset: 0x003F9B44
		// (set) Token: 0x0600225A RID: 8794 RVA: 0x003FB758 File Offset: 0x003F9B58
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

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x003FB764 File Offset: 0x003F9B64
		// (set) Token: 0x0600225C RID: 8796 RVA: 0x003FB778 File Offset: 0x003F9B78
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

		// Token: 0x0600225D RID: 8797 RVA: 0x003FB784 File Offset: 0x003F9B84
		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (((TabControl)sender).SelectedIndex)
			{
			case 0:
				this.Grupo_lapelas.Text = "Configuração de equipamentos de reservatórios";
				break;
			case 1:
				this.Grupo_lapelas.Text = "Configuração de equipamentos de recalques";
				break;
			case 2:
				this.Grupo_lapelas.Text = "Configuração de equipamentos vistas";
				break;
			}
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x003FB7E4 File Offset: 0x003F9BE4
		private void Equip_302_conf_Load(object sender, EventArgs e)
		{
			this.Combo_baudrate.Items.Clear();
			this.Combo_baudrate.Items.Add("1200");
			this.Combo_baudrate.Items.Add("9600");
			this.Limpa_estrutura_MD302();
			this.Atualiza_dados_gerais();
			this.Atualiza_dados_re(Mod_MD.Central_302_geral.Qtd_equip_res);
			this.Atualiza_dados_rq(Mod_MD.Central_302_geral.Qdt_equip_rq);
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x003FB85C File Offset: 0x003F9C5C
		public void Atualiza_dados_gerais()
		{
			this.Valor_endereco.Value = new decimal(Mod_MD.Central_302_geral.Endereco);
			this.Valor_temp_ptt.Value = new decimal(Mod_MD.Central_302_geral.Tempo_ptt);
			this.Valor_intervalo_polling.Value = new decimal(Mod_MD.Central_302_geral.Intervalo_polling);
			this.Valor_timeout.Value = new decimal(Mod_MD.Central_302_geral.Timeout);
			this.Valor_num_tentativas.Value = new decimal(Mod_MD.Central_302_geral.Retray);
			this.Valor_erro_falha.Value = new decimal(Mod_MD.Central_302_geral.Erros_falha);
			this.Combo_baudrate.SelectedIndex = checked(Mod_MD.Central_302_geral.Baud_rate_com2 - 21849);
			this.Valor_res_sistema.Value = new decimal(Mod_MD.Central_302_geral.Qtd_res);
			this.Valor_res_equipamentos.Value = new decimal(Mod_MD.Central_302_geral.Qtd_equip_res);
			this.Valor_rq_equipamentos.Value = new decimal(Mod_MD.Central_302_geral.Qdt_equip_rq);
			this.Valor_vista_equipamentos.Value = new decimal(Mod_MD.Central_302_geral.Qtd_equip_vista);
			this.Valor_end_ini_res.Value = new decimal(Mod_MD.Central_302_geral.End_ini_equip_res);
			this.Valor_end_ini_rq.Value = new decimal(Mod_MD.Central_302_geral.End_ini_equip_rq);
			this.Valor_end_ini_vista.Value = new decimal(Mod_MD.Central_302_geral.End_ini_equip_vista);
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x003FB9D8 File Offset: 0x003F9DD8
		public void Atualiza_dados_re(int numero)
		{
			if (numero == 0)
			{
				this.DataGridView1.Rows.Clear();
				return;
			}
			int end_ini_equip_res = Mod_MD.Central_302_geral.End_ini_equip_res;
			this.DataGridView1.Rows.Clear();
			checked
			{
				for (int i = 1; i <= numero; i++)
				{
					string text = Conversion.Str(end_ini_equip_res + i - 1);
					string text2 = Conversion.Str(Mod_MD.Central_302_res[i].Altura);
					string text3 = Conversion.Str(Mod_MD.Central_302_res[i].Msg);
					string text4 = Conversion.Str(Mod_MD.Central_302_res[i].Prioridade);
					string text5 = Conversion.Str(Mod_MD.Central_302_res[i].Res_relativo);
					this.DataGridView1.Rows.Add(new object[]
					{
						text,
						text3,
						text2,
						text4,
						text5
					});
				}
			}
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x003FBAE4 File Offset: 0x003F9EE4
		public void Atualiza_dados_rq(int numero)
		{
			if (numero == 0)
			{
				this.DataGridView_RQ.Rows.Clear();
				return;
			}
			string text = "";
			int end_ini_equip_rq = Mod_MD.Central_302_geral.End_ini_equip_rq;
			this.DataGridView_RQ.Rows.Clear();
			int i = 1;
			checked
			{
				while (i <= numero)
				{
					string text2 = Conversion.Str(end_ini_equip_rq + i - 1);
					string text3 = Conversion.Str(Mod_MD.Central_302_rq[i].Res_origem);
					string text4 = Conversion.Str(Mod_MD.Central_302_rq[i].Res_destino);
					string text5 = Conversion.Str(Mod_MD.Central_302_rq[i].Res_relativo_R1);
					string text6 = Conversion.Str(Mod_MD.Central_302_rq[i].Res_relativo_R2);
					string text7 = Conversion.Str(Mod_MD.Central_302_rq[i].Res_relativo_R3);
					string text8 = Conversion.Str(Mod_MD.Central_302_rq[i].Res_relativo_R4);
					string text9 = Conversion.Str(Mod_MD.Central_302_rq[i].Msg_res_R1);
					string text10 = Conversion.Str(Mod_MD.Central_302_rq[i].Msg_res_R2);
					string text11 = Conversion.Str(Mod_MD.Central_302_rq[i].Msg_res_R3);
					string text12 = Conversion.Str(Mod_MD.Central_302_rq[i].Msg_res_R4);
					string text13;
					switch (Mod_MD.Central_302_rq[i].modelo)
					{
					case 1:
						text13 = "MD 201";
						break;
					case 2:
						text13 = "MD 202";
						break;
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
					case 10:
						goto IL_211;
					case 11:
						text13 = "MD 101 - ELO548";
						break;
					case 12:
						text13 = "MD 101 - BERMAD";
						break;
					case 13:
						text13 = "MD 101 - KOYO";
						break;
					case 14:
						text13 = "MD 202 - KRON";
						break;
					case 15:
						text13 = "MD 202 - KRON - PEXTRON";
						break;
					case 16:
						text13 = "MD 202 - SoftStarter ABB - 1";
						break;
					default:
						goto IL_211;
					}
					IL_218:
					string text14 = Conversion.Str(Mod_MD.Central_302_rq[i].Prioridade);
					string text15 = Conversion.Str(Mod_MD.Central_302_rq[i].Msg);
					int hab_cmd = Mod_MD.Central_302_rq[i].Hab_cmd;
					if (hab_cmd == 0)
					{
						text = "Bloqueado";
					}
					else if (hab_cmd == 21882)
					{
						text = "Habilitado";
					}
					string text16 = Conversion.Str(Mod_MD.Central_302_rq[i].escala_1);
					string text17 = Conversion.Str(Mod_MD.Central_302_rq[i].escala_2);
					string text18 = Conversion.Str(Mod_MD.Central_302_rq[i].escala_3);
					string text19 = Conversion.Str(Mod_MD.Central_302_rq[i].escala_4);
					string text20 = Conversion.Str(Mod_MD.Central_302_rq[i].escala_5);
					string text21 = Conversion.Str(Mod_MD.Central_302_rq[i].escala_6);
					string text22 = Conversion.Str(Mod_MD.Central_302_rq[i].escala_7);
					string text23 = Conversion.Str(Mod_MD.Central_302_rq[i].escala_8);
					string text24 = Conversion.Str(Mod_MD.Central_302_rq[i].escala_9);
					string text25 = Conversion.Str(Mod_MD.Central_302_rq[i].escala_10);
					string text26 = Conversion.Str(Mod_MD.Central_302_rq[i].escala_11);
					string text27 = Conversion.Str(Mod_MD.Central_302_rq[i].escala_12);
					string text28 = Conversion.Str(Mod_MD.Central_302_rq[i].escala_13);
					string text29 = Conversion.Str(Mod_MD.Central_302_rq[i].escala_14);
					string text30 = Conversion.Str(Mod_MD.Central_302_rq[i].escala_15);
					string text31 = Conversion.Str(Mod_MD.Central_302_rq[i].escala_16);
					this.DataGridView_RQ.Rows.Add(new object[]
					{
						text2,
						text15,
						text3,
						text4,
						text13,
						text14,
						text5,
						text6,
						text7,
						text8,
						text9,
						text10,
						text11,
						text12,
						text,
						text16,
						text17,
						text18,
						text19,
						text20,
						text21,
						text22,
						text23,
						text24,
						text25,
						text26,
						text27,
						text28,
						text29,
						text30,
						text31
					});
					i++;
					continue;
					IL_211:
					text13 = "--------";
					goto IL_218;
				}
			}
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x003FC028 File Offset: 0x003FA428
		private void Valor_res_equipamentos_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_302_geral.Qtd_equip_res = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Atualiza_dados_re(Mod_MD.Central_302_geral.Qtd_equip_res);
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x003FC060 File Offset: 0x003FA460
		private void Valor_res_sistema_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_302_geral.Qtd_res = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x003FC088 File Offset: 0x003FA488
		private void Valor_rq_equipamentos_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_302_geral.Qdt_equip_rq = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Atualiza_dados_rq(Mod_MD.Central_302_geral.Qdt_equip_rq);
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x003FC0C0 File Offset: 0x003FA4C0
		private void Valor_vista_equipamentos_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_302_geral.Qtd_equip_vista = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Atualiza_dados_centrais(Mod_MD.Central_302_geral.Qtd_equip_vista);
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x003FC0F8 File Offset: 0x003FA4F8
		private void Valor_end_ini_res_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_302_geral.End_ini_equip_res = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Atualiza_dados_re(Mod_MD.Central_302_geral.Qtd_equip_res);
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x003FC130 File Offset: 0x003FA530
		private void Valor_end_ini_rq_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_302_geral.End_ini_equip_rq = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Atualiza_dados_rq(Mod_MD.Central_302_geral.Qdt_equip_rq);
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x003FC168 File Offset: 0x003FA568
		private void Valor_end_ini_vista_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_302_geral.End_ini_equip_vista = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x003FC190 File Offset: 0x003FA590
		private void Valor_endereco_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_302_geral.Endereco = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x003FC1B8 File Offset: 0x003FA5B8
		private void Valor_temp_ptt_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_302_geral.Tempo_ptt = Conversions.ToInteger(Operators.DivideObject(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null), 10));
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x003FC1EC File Offset: 0x003FA5EC
		private void Valor_intervalo_polling_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_302_geral.Intervalo_polling = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x003FC214 File Offset: 0x003FA614
		private void Valor_timeout_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_302_geral.Timeout = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x003FC23C File Offset: 0x003FA63C
		private void Valor_num_tentativas_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_302_geral.Retray = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x003FC264 File Offset: 0x003FA664
		private void Valor_erro_falha_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_302_geral.Erros_falha = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x003FC28C File Offset: 0x003FA68C
		private void Combo_baudrate_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Central_302_geral.Baud_rate_com2 = Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), 21849));
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x003FC2C4 File Offset: 0x003FA6C4
		public void Limpa_estrutura_MD302()
		{
			Mod_MD.Central_302_geral.Baud_rate_com2 = 21849;
			Mod_MD.Central_302_geral.End_ini_equip_res = 1;
			Mod_MD.Central_302_geral.End_ini_equip_rq = 11;
			Mod_MD.Central_302_geral.End_ini_equip_vista = 21;
			Mod_MD.Central_302_geral.Endereco = 200;
			Mod_MD.Central_302_geral.Erros_falha = 3;
			Mod_MD.Central_302_geral.Intervalo_polling = 3;
			Mod_MD.Central_302_geral.Qdt_equip_rq = 0;
			Mod_MD.Central_302_geral.Qtd_equip_res = 0;
			Mod_MD.Central_302_geral.Qtd_equip_vista = 0;
			Mod_MD.Central_302_geral.Qtd_res = 0;
			Mod_MD.Central_302_geral.Retray = 3;
			Mod_MD.Central_302_geral.Tempo_ptt = 200;
			Mod_MD.Central_302_geral.Timeout = 5;
			int num = 0;
			int num_MAX_RE = Mod_MD.NUM_MAX_RE;
			checked
			{
				for (int i = num; i <= num_MAX_RE; i++)
				{
					Mod_MD.Central_302_res[i].Altura = 0;
					Mod_MD.Central_302_res[i].Msg = 0;
					Mod_MD.Central_302_res[i].Prioridade = 1;
					Mod_MD.Central_302_res[i].Res_relativo = 0;
				}
				int num2 = 0;
				int num_MAX_RQ = Mod_MD.NUM_MAX_RQ;
				for (int i = num2; i <= num_MAX_RQ; i++)
				{
					Mod_MD.Central_302_rq[i].modelo = 1;
					Mod_MD.Central_302_rq[i].Msg = 0;
					Mod_MD.Central_302_rq[i].Hab_cmd = 0;
					Mod_MD.Central_302_rq[i].Prioridade = 1;
					Mod_MD.Central_302_rq[i].Res_destino = 0;
					Mod_MD.Central_302_rq[i].Res_origem = 0;
					Mod_MD.Central_302_rq[i].Res_relativo_R1 = 0;
					Mod_MD.Central_302_rq[i].Res_relativo_R2 = 0;
					Mod_MD.Central_302_rq[i].Res_relativo_R3 = 0;
					Mod_MD.Central_302_rq[i].Res_relativo_R4 = 0;
					Mod_MD.Central_302_rq[i].Msg_res_R1 = 0;
					Mod_MD.Central_302_rq[i].Msg_res_R2 = 0;
					Mod_MD.Central_302_rq[i].Msg_res_R3 = 0;
					Mod_MD.Central_302_rq[i].Msg_res_R4 = 0;
					Mod_MD.Central_302_rq[i].escala_1 = 100;
					Mod_MD.Central_302_rq[i].escala_2 = 100;
					Mod_MD.Central_302_rq[i].escala_3 = 100;
					Mod_MD.Central_302_rq[i].escala_4 = 100;
					Mod_MD.Central_302_rq[i].escala_5 = 100;
					Mod_MD.Central_302_rq[i].escala_6 = 100;
					Mod_MD.Central_302_rq[i].escala_7 = 100;
					Mod_MD.Central_302_rq[i].escala_8 = 100;
					Mod_MD.Central_302_rq[i].escala_9 = 100;
					Mod_MD.Central_302_rq[i].escala_10 = 100;
					Mod_MD.Central_302_rq[i].escala_11 = 100;
					Mod_MD.Central_302_rq[i].escala_12 = 100;
					Mod_MD.Central_302_rq[i].escala_13 = 100;
					Mod_MD.Central_302_rq[i].escala_14 = 100;
					Mod_MD.Central_302_rq[i].escala_15 = 100;
					Mod_MD.Central_302_rq[i].escala_16 = 100;
				}
				int num3 = 0;
				int num_MAX_VISTA = Mod_MD.NUM_MAX_VISTA;
				for (int i = num3; i <= num_MAX_VISTA; i++)
				{
					Mod_MD.Central_302_centrais[i].num_res = 0;
					Mod_MD.Central_302_centrais[i].num_rq = 0;
					Mod_MD.Central_302_centrais[i].prioridade = 0;
				}
				int num4 = 0;
				int num_MAX_VISTA2 = Mod_MD.NUM_MAX_VISTA;
				for (int i = num4; i <= num_MAX_VISTA2; i++)
				{
					int num5 = 0;
					do
					{
						Mod_MD.Central_302_indices[i, num5] = 0;
						num5++;
					}
					while (num5 <= 150);
				}
			}
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x003FC66C File Offset: 0x003FAA6C
		private void DataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			bool flag = true;
			Mod_MD.CTRL_RESP_1 ctrl_RESP_;
			ctrl_RESP_.Msg = "";
			string name = this.DataGridView1.Columns[e.ColumnIndex].Name;
			checked
			{
				if (Operators.CompareString(name, "Col_nome", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 9999, 0);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_302_res[e.RowIndex + 1].Msg = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_altura", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 20000, 0);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_302_res[e.RowIndex + 1].Altura = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_pri", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 13, 0);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_302_res[e.RowIndex + 1].Prioridade = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_posicao", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 60, 0);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_302_res[e.RowIndex + 1].Res_relativo = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else
				{
					flag = false;
				}
				if (flag)
				{
					this.DataGridView1.CurrentCell.Value = ctrl_RESP_.Msg;
					this.DataGridView1.RefreshEdit();
				}
			}
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x003FC828 File Offset: 0x003FAC28
		private void Ler_conf_md_302_Click(object sender, EventArgs e)
		{
			int[] array = new int[]
			{
				100,
				512,
				592,
				768,
				888,
				1024,
				1144,
				1280,
				1400,
				1536,
				1656,
				1792,
				1878,
				1964
			};
			int[] array2 = new int[]
			{
				14,
				80,
				80,
				120,
				90,
				120,
				90,
				120,
				90,
				120,
				90,
				86,
				86,
				43
			};
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			this.DataGridView_central_geral.CurrentCell = null;
			this.DataGridView_central_rq.CurrentCell = null;
			this.DataGridView_central_res.CurrentCell = null;
			this.DataGridView_RQ.CurrentCell = null;
			this.DataGridView1.CurrentCell = null;
			this.Controle_tecla_conf_302(2);
			this.Mensagem_MD302("Aguarde ...", 2);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Leitura_pagina(100, 255, 14);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			Mod_MD.Atualiza_dados_MD302(100);
			int num = 1;
			checked
			{
				for (;;)
				{
					ctrl_RESP_ = Mod_MD.Leitura_pagina(array[num], Mod_MD.Central_302_geral.Endereco, array2[num]);
					this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					if (!ctrl_RESP_.Status)
					{
						break;
					}
					Mod_MD.Atualiza_dados_MD302(array[num]);
					num++;
					if (num > 13)
					{
						goto Block_4;
					}
				}
				this.Controle_tecla_conf_302(1);
				return;
				Block_4:
				this.Mensagem_MD302("Leitura executada com sucesso", 0);
				this.Atualiza_tela_MD302(Mod_MD.Controle.Estacao);
				this.Atualiza_dados_centrais(Mod_MD.Central_302_geral.Qtd_equip_vista);
				this.Atualiza_dados_re(Mod_MD.Central_302_geral.Qtd_equip_res);
				this.Atualiza_dados_rq(Mod_MD.Central_302_geral.Qdt_equip_rq);
				this.Controle_tecla_conf_302(1);
			}
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x003FCA6C File Offset: 0x003FAE6C
		public void Controle_tecla_conf_302(int operacao)
		{
			switch (operacao)
			{
			case 1:
				this.Ler_conf_md_302.Enabled = true;
				this.Esc_conf_md_302.Enabled = true;
				break;
			case 2:
				this.Ler_conf_md_302.Enabled = false;
				this.Esc_conf_md_302.Enabled = false;
				break;
			}
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x003FCAC0 File Offset: 0x003FAEC0
		public void Mensagem_MD302(string msg, int cor)
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

		// Token: 0x06002275 RID: 8821 RVA: 0x003FCB24 File Offset: 0x003FAF24
		private void DataGridView_RQ_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			bool flag = true;
			Mod_MD.CTRL_RESP_1 ctrl_RESP_;
			ctrl_RESP_.Msg = "";
			string name = this.DataGridView_RQ.Columns[e.ColumnIndex].Name;
			checked
			{
				if (Operators.CompareString(name, "Col_nome_rq", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 9999, 0);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_302_rq[e.RowIndex + 1].Msg = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_ROrg_rq", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 9999, 0);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_302_rq[e.RowIndex + 1].Res_origem = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_RDest_rq", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 9999, 0);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_302_rq[e.RowIndex + 1].Res_destino = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else if (Operators.CompareString(name, "Col_mod_rq", false) == 0)
				{
					object formattedValue = e.FormattedValue;
					if (Operators.ConditionalCompareObjectEqual(formattedValue, "MD 201", false))
					{
						Mod_MD.Central_302_rq[e.RowIndex + 1].modelo = 1;
					}
					else if (Operators.ConditionalCompareObjectEqual(formattedValue, "MD 202", false))
					{
						Mod_MD.Central_302_rq[e.RowIndex + 1].modelo = 2;
					}
					else if (Operators.ConditionalCompareObjectEqual(formattedValue, "MD 101 - ELO548", false))
					{
						Mod_MD.Central_302_rq[e.RowIndex + 1].modelo = 11;
					}
					else if (Operators.ConditionalCompareObjectEqual(formattedValue, "MD 101 - BERMAD", false))
					{
						Mod_MD.Central_302_rq[e.RowIndex + 1].modelo = 12;
					}
					else if (Operators.ConditionalCompareObjectEqual(formattedValue, "MD 101 - KOYO", false))
					{
						Mod_MD.Central_302_rq[e.RowIndex + 1].modelo = 13;
					}
					else if (Operators.ConditionalCompareObjectEqual(formattedValue, "MD 202 - KRON", false))
					{
						Mod_MD.Central_302_rq[e.RowIndex + 1].modelo = 14;
					}
					else if (Operators.ConditionalCompareObjectEqual(formattedValue, "MD 202 - KRON - PEXTRON", false))
					{
						Mod_MD.Central_302_rq[e.RowIndex + 1].modelo = 15;
					}
					else if (Operators.ConditionalCompareObjectEqual(formattedValue, "MD 202 - SoftStarter ABB - 1", false))
					{
						Mod_MD.Central_302_rq[e.RowIndex + 1].modelo = 16;
					}
					flag = false;
				}
				else if (Operators.CompareString(name, "Col_pri_rq", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 13, 0);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_302_rq[e.RowIndex + 1].Prioridade = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else
				{
					if (Operators.CompareString(name, "Col_Res1_rq", false) != 0)
					{
						if (Operators.CompareString(name, "Col_Res2_rq", false) != 0)
						{
							if (Operators.CompareString(name, "Col_Res3_rq", false) != 0)
							{
								if (Operators.CompareString(name, "Col_Res4_rq", false) != 0)
								{
									if (Operators.CompareString(name, "Col_MsgR1_rq", false) != 0)
									{
										if (Operators.CompareString(name, "Col_MsgR2_rq", false) != 0)
										{
											if (Operators.CompareString(name, "Col_MsgR3_rq", false) != 0)
											{
												if (Operators.CompareString(name, "Col_MsgR4_rq", false) != 0)
												{
													if (Operators.CompareString(name, "Col_hab", false) == 0)
													{
														object formattedValue2 = e.FormattedValue;
														if (Operators.ConditionalCompareObjectEqual(formattedValue2, "Habilitado", false))
														{
															Mod_MD.Central_302_rq[e.RowIndex + 1].Hab_cmd = 21882;
														}
														else if (Operators.ConditionalCompareObjectEqual(formattedValue2, "Bloqueado", false))
														{
															Mod_MD.Central_302_rq[e.RowIndex + 1].Hab_cmd = 0;
														}
														flag = false;
														goto IL_B98;
													}
													if (Operators.CompareString(name, "Col_Esc_1", false) != 0)
													{
														if (Operators.CompareString(name, "Col_Esc_2", false) != 0)
														{
															if (Operators.CompareString(name, "Col_Esc_3", false) != 0)
															{
																if (Operators.CompareString(name, "Col_Esc_4", false) != 0)
																{
																	if (Operators.CompareString(name, "Col_Esc_5", false) != 0)
																	{
																		if (Operators.CompareString(name, "Col_Esc_6", false) != 0)
																		{
																			if (Operators.CompareString(name, "Col_Esc_7", false) != 0)
																			{
																				if (Operators.CompareString(name, "Col_Esc_8", false) != 0)
																				{
																					if (Operators.CompareString(name, "Col_Esc_9", false) != 0)
																					{
																						if (Operators.CompareString(name, "Col_Esc_10", false) != 0)
																						{
																							if (Operators.CompareString(name, "Col_Esc_11", false) != 0)
																							{
																								if (Operators.CompareString(name, "Col_Esc_12", false) != 0)
																								{
																									if (Operators.CompareString(name, "Col_Esc_13", false) != 0)
																									{
																										if (Operators.CompareString(name, "Col_Esc_14", false) != 0)
																										{
																											if (Operators.CompareString(name, "Col_Esc_15", false) != 0)
																											{
																												if (Operators.CompareString(name, "Col_Esc_16", false) != 0)
																												{
																													flag = false;
																													goto IL_B98;
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
													ctrl_RESP_ = Mod_MD.Valida_celula(e, 32000, 1);
													if (!ctrl_RESP_.Status)
													{
														e.Cancel = true;
													}
													string name2 = this.DataGridView_RQ.Columns[e.ColumnIndex].Name;
													if (Operators.CompareString(name2, "Col_Esc_1", false) == 0)
													{
														Mod_MD.Central_302_rq[e.RowIndex + 1].escala_1 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
														goto IL_B98;
													}
													if (Operators.CompareString(name2, "Col_Esc_2", false) == 0)
													{
														Mod_MD.Central_302_rq[e.RowIndex + 1].escala_2 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
														goto IL_B98;
													}
													if (Operators.CompareString(name2, "Col_Esc_3", false) == 0)
													{
														Mod_MD.Central_302_rq[e.RowIndex + 1].escala_3 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
														goto IL_B98;
													}
													if (Operators.CompareString(name2, "Col_Esc_4", false) == 0)
													{
														Mod_MD.Central_302_rq[e.RowIndex + 1].escala_4 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
														goto IL_B98;
													}
													if (Operators.CompareString(name2, "Col_Esc_5", false) == 0)
													{
														Mod_MD.Central_302_rq[e.RowIndex + 1].escala_5 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
														goto IL_B98;
													}
													if (Operators.CompareString(name2, "Col_Esc_6", false) == 0)
													{
														Mod_MD.Central_302_rq[e.RowIndex + 1].escala_6 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
														goto IL_B98;
													}
													if (Operators.CompareString(name2, "Col_Esc_7", false) == 0)
													{
														Mod_MD.Central_302_rq[e.RowIndex + 1].escala_7 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
														goto IL_B98;
													}
													if (Operators.CompareString(name2, "Col_Esc_8", false) == 0)
													{
														Mod_MD.Central_302_rq[e.RowIndex + 1].escala_8 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
														goto IL_B98;
													}
													if (Operators.CompareString(name2, "Col_Esc_9", false) == 0)
													{
														Mod_MD.Central_302_rq[e.RowIndex + 1].escala_9 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
														goto IL_B98;
													}
													if (Operators.CompareString(name2, "Col_Esc_10", false) == 0)
													{
														Mod_MD.Central_302_rq[e.RowIndex + 1].escala_10 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
														goto IL_B98;
													}
													if (Operators.CompareString(name2, "Col_Esc_11", false) == 0)
													{
														Mod_MD.Central_302_rq[e.RowIndex + 1].escala_11 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
														goto IL_B98;
													}
													if (Operators.CompareString(name2, "Col_Esc_12", false) == 0)
													{
														Mod_MD.Central_302_rq[e.RowIndex + 1].escala_12 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
														goto IL_B98;
													}
													if (Operators.CompareString(name2, "Col_Esc_13", false) == 0)
													{
														Mod_MD.Central_302_rq[e.RowIndex + 1].escala_13 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
														goto IL_B98;
													}
													if (Operators.CompareString(name2, "Col_Esc_14", false) == 0)
													{
														Mod_MD.Central_302_rq[e.RowIndex + 1].escala_14 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
														goto IL_B98;
													}
													if (Operators.CompareString(name2, "Col_Esc_15", false) == 0)
													{
														Mod_MD.Central_302_rq[e.RowIndex + 1].escala_15 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
														goto IL_B98;
													}
													if (Operators.CompareString(name2, "Col_Esc_16", false) == 0)
													{
														Mod_MD.Central_302_rq[e.RowIndex + 1].escala_16 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
														goto IL_B98;
													}
													goto IL_B98;
												}
											}
										}
									}
									ctrl_RESP_ = Mod_MD.Valida_celula(e, 9999, 0);
									if (!ctrl_RESP_.Status)
									{
										e.Cancel = true;
									}
									string name3 = this.DataGridView_RQ.Columns[e.ColumnIndex].Name;
									if (Operators.CompareString(name3, "Col_MsgR1_rq", false) == 0)
									{
										Mod_MD.Central_302_rq[e.RowIndex + 1].Msg_res_R1 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
										goto IL_B98;
									}
									if (Operators.CompareString(name3, "Col_MsgR2_rq", false) == 0)
									{
										Mod_MD.Central_302_rq[e.RowIndex + 1].Msg_res_R2 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
										goto IL_B98;
									}
									if (Operators.CompareString(name3, "Col_MsgR3_rq", false) == 0)
									{
										Mod_MD.Central_302_rq[e.RowIndex + 1].Msg_res_R3 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
										goto IL_B98;
									}
									if (Operators.CompareString(name3, "Col_MsgR4_rq", false) == 0)
									{
										Mod_MD.Central_302_rq[e.RowIndex + 1].Msg_res_R4 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
										goto IL_B98;
									}
									goto IL_B98;
								}
							}
						}
					}
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 60, 0);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					string name4 = this.DataGridView_RQ.Columns[e.ColumnIndex].Name;
					if (Operators.CompareString(name4, "Col_Res1_rq", false) == 0)
					{
						Mod_MD.Central_302_rq[e.RowIndex + 1].Res_relativo_R1 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
					}
					else if (Operators.CompareString(name4, "Col_Res2_rq", false) == 0)
					{
						Mod_MD.Central_302_rq[e.RowIndex + 1].Res_relativo_R2 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
					}
					else if (Operators.CompareString(name4, "Col_Res3_rq", false) == 0)
					{
						Mod_MD.Central_302_rq[e.RowIndex + 1].Res_relativo_R3 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
					}
					else if (Operators.CompareString(name4, "Col_Res4_rq", false) == 0)
					{
						Mod_MD.Central_302_rq[e.RowIndex + 1].Res_relativo_R4 = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
					}
				}
				IL_B98:
				if (flag)
				{
					this.DataGridView_RQ.CurrentCell.Value = ctrl_RESP_.Msg;
					this.DataGridView_RQ.RefreshEdit();
				}
			}
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x003FD6F0 File Offset: 0x003FBAF0
		public void Atualiza_tela_MD302(int indice)
		{
			this.Valor_endereco.Value = new decimal(Mod_MD.Central_302_geral.Endereco);
			checked
			{
				this.Valor_temp_ptt.Value = new decimal(Mod_MD.Central_302_geral.Tempo_ptt * 10);
				this.Valor_intervalo_polling.Value = new decimal(Mod_MD.Central_302_geral.Intervalo_polling);
				this.Valor_timeout.Value = new decimal(Mod_MD.Central_302_geral.Timeout);
				this.Valor_num_tentativas.Value = new decimal(Mod_MD.Central_302_geral.Retray);
				this.Valor_erro_falha.Value = new decimal(Mod_MD.Central_302_geral.Erros_falha);
				this.Combo_baudrate.SelectedIndex = Mod_MD.Central_302_geral.Baud_rate_com2 - 21849;
				this.Valor_res_sistema.Value = new decimal(Mod_MD.Central_302_geral.Qtd_res);
				this.Valor_res_equipamentos.Value = new decimal(Mod_MD.Central_302_geral.Qtd_equip_res);
				this.Valor_rq_equipamentos.Value = new decimal(Mod_MD.Central_302_geral.Qdt_equip_rq);
				this.Valor_vista_equipamentos.Value = new decimal(Mod_MD.Central_302_geral.Qtd_equip_vista);
				this.Valor_end_ini_res.Value = new decimal(Mod_MD.Central_302_geral.End_ini_equip_res);
				this.Valor_end_ini_rq.Value = new decimal(Mod_MD.Central_302_geral.End_ini_equip_rq);
				this.Valor_end_ini_vista.Value = new decimal(Mod_MD.Central_302_geral.End_ini_equip_vista);
			}
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x003FD870 File Offset: 0x003FBC70
		public void Atualiza_dados_centrais(int numero)
		{
			if (numero == 0)
			{
				this.DataGridView_central_geral.Rows.Clear();
				this.DataGridView_central_res.Rows.Clear();
				this.DataGridView_central_rq.Rows.Clear();
				return;
			}
			int end_ini_equip_vista = Mod_MD.Central_302_geral.End_ini_equip_vista;
			this.DataGridView_central_geral.Rows.Clear();
			checked
			{
				for (int i = 1; i <= numero; i++)
				{
					string text = Conversion.Str(end_ini_equip_vista + i - 1);
					string text2 = Conversion.Str(Mod_MD.Central_302_centrais[i].num_res);
					string text3 = Conversion.Str(Mod_MD.Central_302_centrais[i].num_rq);
					string text4 = Conversion.Str(Mod_MD.Central_302_centrais[i].prioridade);
					this.DataGridView_central_geral.Rows.Add(new object[]
					{
						text,
						text2,
						text3,
						text4
					});
				}
				this.Atualiza_vista_res(numero);
				this.Atualiza_vista_rq(numero);
			}
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x003FD988 File Offset: 0x003FBD88
		private void DataGridView_central_res_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			int num;
			int num2;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				int columnIndex = e.ColumnIndex;
				int rowIndex = e.RowIndex;
				if (this.Verifica_celula_ativa(columnIndex, rowIndex, 1, 0))
				{
					e.CellStyle.BackColor = Color.LightCyan;
				}
				IL_33:
				goto IL_78;
				IL_35:
				num2 = -1;
								IL_4A:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num2 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_35;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			IL_78:
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x003FDA28 File Offset: 0x003FBE28
		private void DataGridView_central_geral_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			bool flag = true;
			Mod_MD.CTRL_RESP_1 ctrl_RESP_;
			ctrl_RESP_.Msg = "";
			string name = this.DataGridView_central_geral.Columns[e.ColumnIndex].Name;
			checked
			{
				if (Operators.CompareString(name, "Col_vista_res", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 40, 0);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_302_centrais[e.RowIndex + 1].num_res = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
					Mod_MD.Atualiza_tabela_equipamentos_vista();
					this.Atualiza_vista_res(Mod_MD.Central_302_geral.Qtd_equip_vista);
					this.Atualiza_vista_rq(Mod_MD.Central_302_geral.Qtd_equip_vista);
				}
				else if (Operators.CompareString(name, "Col_vista_rq", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 30, 0);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_302_centrais[e.RowIndex + 1].num_rq = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
					Mod_MD.Atualiza_tabela_equipamentos_vista();
					this.Atualiza_vista_rq(Mod_MD.Central_302_geral.Qtd_equip_vista);
				}
				else if (Operators.CompareString(name, "Col_vista_pri", false) == 0)
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 13, 0);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_302_centrais[e.RowIndex + 1].prioridade = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else
				{
					flag = false;
				}
				if (flag)
				{
					this.DataGridView_central_geral.CurrentCell.Value = ctrl_RESP_.Msg;
					this.DataGridView_central_geral.RefreshEdit();
				}
			}
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x003FDBC0 File Offset: 0x003FBFC0
		public void Atualiza_vista_res(int num)
		{
			checked
			{
				int num2;
				int num8;
				object obj;
				try
				{
					string text = "CRI";
					string text2 = "End ";
					string[] array = new string[41];
					ProjectData.ClearProjectError();
					num2 = 2;
					if (this.DataGridView_central_res.Columns.Count > 1)
					{
						for (int i = this.DataGridView_central_res.Columns.Count - 1; i >= 1; i += -1)
						{
							string name = this.DataGridView_central_res.Columns[i].Name;
							this.DataGridView_central_res.Columns.Remove(name);
						}
					}
					int num3 = 0;
					int num4 = 1;
					int qtd_equip_vista = Mod_MD.Central_302_geral.Qtd_equip_vista;
					for (int i = num4; i <= qtd_equip_vista; i++)
					{
						if (num3 < Mod_MD.Central_302_centrais[i].num_res)
						{
							num3 = Mod_MD.Central_302_centrais[i].num_res;
						}
					}
					if (num3 > 0)
					{
						int num5 = 1;
						int num6 = num3;
						for (int i = num5; i <= num6; i++)
						{
							this.DataGridView_central_res.Columns.Add(text + Conversion.Str(i), text2 + Conversion.Str(i));
							DataGridViewColumn dataGridViewColumn = this.DataGridView_central_res.Columns[text + Conversion.Str(i)];
							dataGridViewColumn.Width = 55;
							dataGridViewColumn.SortMode = 0;
						}
					}
					int end_ini_equip_vista = Mod_MD.Central_302_geral.End_ini_equip_vista;
					this.DataGridView_central_res.Rows.Clear();
					for (int j = 1; j <= num; j++)
					{
						string text3 = Conversion.Str(end_ini_equip_vista + j - 1);
						int num7 = 1;
						int num_res = Mod_MD.Central_302_centrais[j].num_res;
						for (int k = num7; k <= num_res; k++)
						{
							array[k] = Conversions.ToString(Mod_MD.Central_302_indices[j, k]);
						}
						for (int k = Mod_MD.Central_302_centrais[j].num_res + 1; k <= 40; k++)
						{
							array[k] = "";
						}
						this.DataGridView_central_res.Rows.Add(new object[]
						{
							text3,
							array[1],
							array[2],
							array[3],
							array[4],
							array[5],
							array[6],
							array[7],
							array[8],
							array[9],
							array[10],
							array[11],
							array[12],
							array[13],
							array[14],
							array[15],
							array[16],
							array[17],
							array[18],
							array[19],
							array[20],
							array[21],
							array[22],
							array[23],
							array[24],
							array[25],
							array[26],
							array[27],
							array[28],
							array[29],
							array[30],
							array[31],
							array[32],
							array[33],
							array[34],
							array[35],
							array[36],
							array[37],
							array[38],
							array[39],
							array[40]
						});
					}
					IL_391:
					goto IL_3D8;
					IL_393:
					num8 = -1;IL_3A9:;
				}
				catch when (endfilter(obj is Exception & num2 != 0 & num8 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_393;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_3D8:
				if (num8 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x003FDFCC File Offset: 0x003FC3CC
		public void Atualiza_vista_rq(int num)
		{
			string text = "CRQI";
			string text2 = "End ";
			string[] array = new string[151];
			checked
			{
				if (this.DataGridView_central_rq.Columns.Count > 1)
				{
					for (int i = this.DataGridView_central_rq.Columns.Count - 1; i >= 1; i += -1)
					{
						string name = this.DataGridView_central_rq.Columns[i].Name;
						this.DataGridView_central_rq.Columns.Remove(name);
					}
				}
				int num2 = 0;
				int num3 = 255;
				int num4 = 1;
				int qtd_equip_vista = Mod_MD.Central_302_geral.Qtd_equip_vista;
				for (int i = num4; i <= qtd_equip_vista; i++)
				{
					if (num2 < Mod_MD.Central_302_centrais[i].num_res)
					{
						num2 = Mod_MD.Central_302_centrais[i].num_res;
					}
					if (num3 > Mod_MD.Central_302_centrais[i].num_res)
					{
						num3 = Mod_MD.Central_302_centrais[i].num_res;
					}
				}
				int num5 = 0;
				int num6 = 1;
				int qtd_equip_vista2 = Mod_MD.Central_302_geral.Qtd_equip_vista;
				for (int i = num6; i <= qtd_equip_vista2; i++)
				{
					if (num5 < Mod_MD.Central_302_centrais[i].num_rq + Mod_MD.Central_302_centrais[i].num_res - num3 && Mod_MD.Central_302_centrais[i].num_rq != 0)
					{
						num5 = Mod_MD.Central_302_centrais[i].num_rq + Mod_MD.Central_302_centrais[i].num_res - num3;
					}
				}
				if (num5 > 0)
				{
					int num7 = num3 + 1;
					int num8 = num5 + num3;
					for (int i = num7; i <= num8; i++)
					{
						this.DataGridView_central_rq.Columns.Add(text + Conversion.Str(i), text2 + Conversion.Str(i));
						DataGridViewColumn dataGridViewColumn = this.DataGridView_central_rq.Columns[text + Conversion.Str(i)];
						dataGridViewColumn.Width = 55;
						dataGridViewColumn.SortMode = 0;
					}
				}
				int end_ini_equip_vista = Mod_MD.Central_302_geral.End_ini_equip_vista;
				this.DataGridView_central_rq.Rows.Clear();
				for (int j = 1; j <= num; j++)
				{
					string text3 = Conversion.Str(end_ini_equip_vista + j - 1);
					int num9 = 1;
					int num10 = num5 + num2;
					for (int k = num9; k <= num10; k++)
					{
						array[k] = "";
					}
					int num11 = Mod_MD.Central_302_centrais[j].num_res + 1;
					int num12 = Mod_MD.Central_302_centrais[j].num_res + Mod_MD.Central_302_centrais[j].num_rq;
					for (int k = num11; k <= num12; k++)
					{
						array[k - num3] = Conversions.ToString(Mod_MD.Central_302_indices[j, k]);
					}
					this.DataGridView_central_rq.Rows.Add(new object[]
					{
						text3,
						array[1],
						array[2],
						array[3],
						array[4],
						array[5],
						array[6],
						array[7],
						array[8],
						array[9],
						array[10],
						array[11],
						array[12],
						array[13],
						array[14],
						array[15],
						array[16],
						array[17],
						array[18],
						array[19],
						array[20],
						array[21],
						array[22],
						array[23],
						array[24],
						array[25],
						array[26],
						array[27],
						array[28],
						array[29],
						array[30]
					});
				}
			}
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x003FE3D8 File Offset: 0x003FC7D8
		public bool Verifica_celula_ativa(int coluna, int linha, int tipo, int coluna_end)
		{
			bool flag = false;
			checked
			{
				bool result;
				if (coluna < 1 | linha < 0)
				{
					result = false;
				}
				else
				{
					switch (tipo)
					{
					case 1:
						if (Mod_MD.Central_302_centrais[linha + 1].num_res <= coluna - 1)
						{
							flag = true;
						}
						break;
					case 2:
					{
						int num = Mod_MD.Tabela_302[linha + 1, coluna_end];
						flag = (num != 2);
						break;
					}
					}
					result = flag;
				}
				return result;
			}
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x003FE440 File Offset: 0x003FC840
		private void DataGridView_central_rq_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
					int columnIndex = e.ColumnIndex;
					int rowIndex = e.RowIndex;
					if (!(columnIndex < 1 | rowIndex < 0))
					{
						string text = this.DataGridView_central_rq.Columns[e.ColumnIndex].Name;
						text = Strings.Right(text, Strings.Len(text) - 4);
						if (this.Verifica_celula_ativa(columnIndex, rowIndex, 2, (int)Math.Round(Conversion.Val(text))))
						{
							e.CellStyle.BackColor = Color.LightCyan;
						}
					}
					IL_7A:
					goto IL_C1;
					IL_7C:
					num2 = -1;
										IL_92:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num2 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_7C;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_C1:
				if (num2 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x003FE528 File Offset: 0x003FC928
		private void DataGridView_central_res_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			bool flag = true;
			Mod_MD.CTRL_RESP_1 ctrl_RESP_;
			ctrl_RESP_.Msg = "";
			if (e.ColumnIndex < 1 | e.RowIndex < 0)
			{
				return;
			}
			checked
			{
				if (!this.Verifica_celula_ativa(e.ColumnIndex, e.RowIndex, 1, 0))
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 40, 0);
					Mod_MD.Central_302_indices[e.RowIndex + 1, e.ColumnIndex] = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else
				{
					ctrl_RESP_.Msg = "";
					flag = true;
				}
				if (flag)
				{
					this.DataGridView_central_res.CurrentCell.Value = ctrl_RESP_.Msg;
					this.DataGridView_central_res.RefreshEdit();
					return;
				}
			}
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x003FE5DC File Offset: 0x003FC9DC
		private void DataGridView_central_rq_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (e.ColumnIndex < 1 | e.RowIndex < 0)
			{
				return;
			}
			bool flag = true;
			Mod_MD.CTRL_RESP_1 ctrl_RESP_;
			ctrl_RESP_.Msg = "";
			string text = this.DataGridView_central_rq.Columns[e.ColumnIndex].Name;
			checked
			{
				text = Strings.Right(text, Strings.Len(text) - 4);
				if (!this.Verifica_celula_ativa(e.ColumnIndex, e.RowIndex, 2, (int)Math.Round(Conversion.Val(text))))
				{
					ctrl_RESP_ = Mod_MD.Valida_celula(e, 40, 0);
					if (!ctrl_RESP_.Status)
					{
						e.Cancel = true;
					}
					Mod_MD.Central_302_indices[e.RowIndex + 1, (int)Math.Round(Conversion.Val(text))] = (int)Math.Round(Conversion.Val(ctrl_RESP_.Msg));
				}
				else
				{
					ctrl_RESP_.Msg = "";
					flag = true;
				}
				if (flag)
				{
					this.DataGridView_central_rq.CurrentCell.Value = ctrl_RESP_.Msg;
					this.DataGridView_central_rq.RefreshEdit();
				}
			}
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x003FE6DC File Offset: 0x003FCADC
		private void Esc_conf_md_302_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			this.DataGridView_central_geral.CurrentCell = null;
			this.DataGridView_central_rq.CurrentCell = null;
			this.DataGridView_central_res.CurrentCell = null;
			this.DataGridView_RQ.CurrentCell = null;
			this.DataGridView1.CurrentCell = null;
			this.Controle_tecla_conf_302(2);
			this.Mensagem_MD302("Aguarde ...", 2);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(100, 4);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(512, 4);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(592, 4);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(768, 4);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(888, 4);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(1024, 4);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(1144, 4);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(1280, 4);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(1400, 4);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(1536, 4);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(1656, 4);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21845);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(1792, 4);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(1878, 4);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Escrita_pagina(1964, 4);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			ctrl_RESP_ = Mod_MD.Controle_escrita(21930);
			this.Mensagem_MD302(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			if (!ctrl_RESP_.Status)
			{
				this.Controle_tecla_conf_302(1);
				return;
			}
			this.Mensagem_MD302("Programação concluída com sucesso", 0);
			this.Controle_tecla_conf_302(1);
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x003FECB0 File Offset: 0x003FD0B0
		private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Limpa_estrutura_MD302();
			this.Atualiza_tela_MD302(Mod_MD.Controle.Estacao);
			this.Atualiza_dados_re(Mod_MD.Central_302_geral.Qtd_equip_res);
			this.Atualiza_dados_rq(Mod_MD.Central_302_geral.Qdt_equip_rq);
			this.Atualiza_dados_centrais(Mod_MD.Central_302_geral.Qtd_equip_vista);
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x003FED04 File Offset: 0x003FD104
		[MethodImpl(72)]
		private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Limpa_estrutura_MD302();
			this.OpenFileDialog1.Filter = "Arquivo de configuração de equipamento|*.V321";
			this.OpenFileDialog1.InitialDirectory = "c:\\";
			checked
			{
				if (this.OpenFileDialog1.ShowDialog() == 1)
				{
					int num = Strings.InStr(1, this.OpenFileDialog1.FileName, ".", 1);
					string text = Strings.Left(this.OpenFileDialog1.FileName, num);
					if (Operators.CompareString(this.OpenFileDialog1.FileName, "", false) != 0)
					{
						num = Strings.Len(Mod_MD.Central_302_geral);
						FileSystem.FileOpen(1, this.OpenFileDialog1.FileName, 4, -1, -1, num);
						int num2 = 1;
						ValueType valueType = Mod_MD.Central_302_geral;
						FileSystem.FileGet(num2, ref valueType, -1L);
						ValueType valueType2 = valueType;
						Mod_MD.DADOS_EQUIP_MD_302_CONFIG_GERAL dados_EQUIP_MD_302_CONFIG_GERAL;
						Mod_MD.Central_302_geral = ((valueType2 != null) ? ((Mod_MD.DADOS_EQUIP_MD_302_CONFIG_GERAL)valueType2) : dados_EQUIP_MD_302_CONFIG_GERAL);
						FileSystem.FileClose(new int[]
						{
							1
						});
						num = Strings.Len(Mod_MD.Central_302_res[1]) * Mod_MD.NUM_MAX_RE + 50;
						FileSystem.FileOpen(1, text + "V322", 4, -1, -1, num);
						int num3 = 1;
						Array array = Mod_MD.Central_302_res;
						FileSystem.FileGet(num3, ref array, -1L, false, false);
						Mod_MD.Central_302_res = (Mod_MD.DADOS_EQUIP_MD_302_CONFIG_RES[])array;
						FileSystem.FileClose(new int[]
						{
							1
						});
						num = Strings.Len(Mod_MD.Central_302_rq[1]) * Mod_MD.NUM_MAX_RQ + 200;
						FileSystem.FileOpen(1, text + "V323", 4, -1, -1, num);
						int num4 = 1;
						array = Mod_MD.Central_302_rq;
						FileSystem.FileGet(num4, ref array, -1L, false, false);
						Mod_MD.Central_302_rq = (Mod_MD.DADOS_EQUIP_MD_302_CONFIG_RQ[])array;
						FileSystem.FileClose(new int[]
						{
							1
						});
						num = Strings.Len(Mod_MD.Central_302_centrais[1]) * Mod_MD.NUM_MAX_VISTA + 50;
						FileSystem.FileOpen(1, text + "V324", 4, -1, -1, num);
						int num5 = 1;
						array = Mod_MD.Central_302_centrais;
						FileSystem.FileGet(num5, ref array, -1L, false, false);
						Mod_MD.Central_302_centrais = (Mod_MD.DADOS_EQUIP_MD_302_CONFIG_CENTRAIS[])array;
						FileSystem.FileClose(new int[]
						{
							1
						});
						num = Strings.Len(Mod_MD.Central_302_indices[1, 1]) * 5 * 150 + 700;
						FileSystem.FileOpen(1, text + "V325", 4, -1, -1, num);
						int num6 = 1;
						array = Mod_MD.Central_302_indices;
						FileSystem.FileGet(num6, ref array, -1L, false, false);
						Mod_MD.Central_302_indices = (int[,])array;
						FileSystem.FileClose(new int[]
						{
							1
						});
					}
					this.Atualiza_tela_MD302(Mod_MD.Controle.Estacao);
					this.Atualiza_dados_centrais(Mod_MD.Central_302_geral.Qtd_equip_vista);
					this.Atualiza_dados_re(Mod_MD.Central_302_geral.Qtd_equip_res);
					this.Atualiza_dados_rq(Mod_MD.Central_302_geral.Qdt_equip_rq);
					Mod_MD.Atualiza_tabela_equipamentos_vista();
					this.Atualiza_vista_res(Mod_MD.Central_302_geral.Qtd_equip_vista);
					this.Atualiza_vista_rq(Mod_MD.Central_302_geral.Qtd_equip_vista);
				}
			}
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x003FF008 File Offset: 0x003FD408
		[MethodImpl(72)]
		private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Mod_MD.Central_302_geral.Versao = Geral.Config_geral.Versao;
			this.SaveFileDialog1.Filter = "Arquivo de configuração de equipamento|*.V321";
			this.SaveFileDialog1.InitialDirectory = "c:\\";
			checked
			{
				if (this.SaveFileDialog1.ShowDialog() == 1)
				{
					int num = Strings.InStr(1, this.SaveFileDialog1.FileName, ".", 1);
					string text = Strings.Left(this.SaveFileDialog1.FileName, num);
					if (Operators.CompareString(this.SaveFileDialog1.FileName, "", false) != 0)
					{
						num = Strings.Len(Mod_MD.Central_302_geral);
						FileSystem.FileOpen(1, this.SaveFileDialog1.FileName, 4, -1, -1, num);
						FileSystem.FilePut(1, Mod_MD.Central_302_geral, -1L);
						FileSystem.FileClose(new int[]
						{
							1
						});
						num = Strings.Len(Mod_MD.Central_302_res[1]) * Mod_MD.NUM_MAX_RE + 50;
						FileSystem.FileOpen(1, text + "V322", 4, -1, -1, num);
						FileSystem.FilePut(1, Mod_MD.Central_302_res, -1L, false, false);
						FileSystem.FileClose(new int[]
						{
							1
						});
						num = Strings.Len(Mod_MD.Central_302_rq[1]) * Mod_MD.NUM_MAX_RQ + 200;
						FileSystem.FileOpen(1, text + "V323", 4, -1, -1, num);
						FileSystem.FilePut(1, Mod_MD.Central_302_rq, -1L, false, false);
						FileSystem.FileClose(new int[]
						{
							1
						});
						num = Strings.Len(Mod_MD.Central_302_centrais[1]) * Mod_MD.NUM_MAX_VISTA + 50;
						FileSystem.FileOpen(1, text + "V324", 4, -1, -1, num);
						FileSystem.FilePut(1, Mod_MD.Central_302_centrais, -1L, false, false);
						FileSystem.FileClose(new int[]
						{
							1
						});
						num = Strings.Len(Mod_MD.Central_302_indices[1, 1]) * 5 * 150 + 700;
						FileSystem.FileOpen(1, text + "V325", 4, -1, -1, num);
						FileSystem.FilePut(1, Mod_MD.Central_302_indices, -1L, false, false);
						FileSystem.FileClose(new int[]
						{
							1
						});
					}
				}
			}
		}

		// Token: 0x040017A8 RID: 6056
		[AccessedThroughProperty("Grupo_conf_comunicacao")]
		private GroupBox _Grupo_conf_comunicacao;

		// Token: 0x040017A9 RID: 6057
		[AccessedThroughProperty("Grupo_lapelas")]
		private GroupBox _Grupo_lapelas;

		// Token: 0x040017AA RID: 6058
		[AccessedThroughProperty("Combo_baudrate")]
		private ComboBox _Combo_baudrate;

		// Token: 0x040017AB RID: 6059
		[AccessedThroughProperty("Label_baudrate")]
		private Label _Label_baudrate;

		// Token: 0x040017AC RID: 6060
		[AccessedThroughProperty("Valor_temp_ptt")]
		private NumericUpDown _Valor_temp_ptt;

		// Token: 0x040017AD RID: 6061
		[AccessedThroughProperty("Valor_endereco")]
		private NumericUpDown _Valor_endereco;

		// Token: 0x040017AE RID: 6062
		[AccessedThroughProperty("Valor_num_tentativas")]
		private NumericUpDown _Valor_num_tentativas;

		// Token: 0x040017AF RID: 6063
		[AccessedThroughProperty("Label_tempo_ptt")]
		private Label _Label_tempo_ptt;

		// Token: 0x040017B0 RID: 6064
		[AccessedThroughProperty("Label_endereco")]
		private Label _Label_endereco;

		// Token: 0x040017B1 RID: 6065
		[AccessedThroughProperty("Label_retry")]
		private Label _Label_retry;

		// Token: 0x040017B2 RID: 6066
		[AccessedThroughProperty("Valor_timeout")]
		private NumericUpDown _Valor_timeout;

		// Token: 0x040017B3 RID: 6067
		[AccessedThroughProperty("Label_timeout")]
		private Label _Label_timeout;

		// Token: 0x040017B4 RID: 6068
		[AccessedThroughProperty("Valor_intervalo_polling")]
		private NumericUpDown _Valor_intervalo_polling;

		// Token: 0x040017B5 RID: 6069
		[AccessedThroughProperty("Label_intervalo_polling")]
		private Label _Label_intervalo_polling;

		// Token: 0x040017B6 RID: 6070
		[AccessedThroughProperty("Valor_erro_falha")]
		private NumericUpDown _Valor_erro_falha;

		// Token: 0x040017B7 RID: 6071
		[AccessedThroughProperty("Label_erros_falha")]
		private Label _Label_erros_falha;

		// Token: 0x040017B8 RID: 6072
		[AccessedThroughProperty("Grupo_conf_equipamentos")]
		private GroupBox _Grupo_conf_equipamentos;

		// Token: 0x040017B9 RID: 6073
		[AccessedThroughProperty("Valor_res_equipamentos")]
		private NumericUpDown _Valor_res_equipamentos;

		// Token: 0x040017BA RID: 6074
		[AccessedThroughProperty("Label_res_equipamentos")]
		private Label _Label_res_equipamentos;

		// Token: 0x040017BB RID: 6075
		[AccessedThroughProperty("Valor_res_sistema")]
		private NumericUpDown _Valor_res_sistema;

		// Token: 0x040017BC RID: 6076
		[AccessedThroughProperty("Label_res_sistema")]
		private Label _Label_res_sistema;

		// Token: 0x040017BD RID: 6077
		[AccessedThroughProperty("Valor_end_ini_vista")]
		private NumericUpDown _Valor_end_ini_vista;

		// Token: 0x040017BE RID: 6078
		[AccessedThroughProperty("Label_end_ini_vista")]
		private Label _Label_end_ini_vista;

		// Token: 0x040017BF RID: 6079
		[AccessedThroughProperty("Valor_end_ini_rq")]
		private NumericUpDown _Valor_end_ini_rq;

		// Token: 0x040017C0 RID: 6080
		[AccessedThroughProperty("Label_end_ini_rq")]
		private Label _Label_end_ini_rq;

		// Token: 0x040017C1 RID: 6081
		[AccessedThroughProperty("Valor_end_ini_res")]
		private NumericUpDown _Valor_end_ini_res;

		// Token: 0x040017C2 RID: 6082
		[AccessedThroughProperty("Label_end_ini_res")]
		private Label _Label_end_ini_res;

		// Token: 0x040017C3 RID: 6083
		[AccessedThroughProperty("Valor_rq_equipamentos")]
		private NumericUpDown _Valor_rq_equipamentos;

		// Token: 0x040017C4 RID: 6084
		[AccessedThroughProperty("Label_rq_equipamentos")]
		private Label _Label_rq_equipamentos;

		// Token: 0x040017C5 RID: 6085
		[AccessedThroughProperty("Grupo_comandos")]
		private GroupBox _Grupo_comandos;

		// Token: 0x040017C6 RID: 6086
		[AccessedThroughProperty("Esc_conf_md_302")]
		private Button _Esc_conf_md_302;

		// Token: 0x040017C7 RID: 6087
		[AccessedThroughProperty("Box_Msg")]
		private TextBox _Box_Msg;

		// Token: 0x040017C8 RID: 6088
		[AccessedThroughProperty("Ler_conf_md_302")]
		private Button _Ler_conf_md_302;

		// Token: 0x040017C9 RID: 6089
		[AccessedThroughProperty("TabControl2")]
		private TabControl _TabControl2;

		// Token: 0x040017CA RID: 6090
		[AccessedThroughProperty("Conf_res")]
		private TabPage _Conf_res;

		// Token: 0x040017CB RID: 6091
		[AccessedThroughProperty("Conf_rq")]
		private TabPage _Conf_rq;

		// Token: 0x040017CC RID: 6092
		[AccessedThroughProperty("Conf_centrais")]
		private TabPage _Conf_centrais;

		// Token: 0x040017CD RID: 6093
		[AccessedThroughProperty("DataGridView1")]
		private DataGridView _DataGridView1;

		// Token: 0x040017CE RID: 6094
		[AccessedThroughProperty("Valor_vista_equipamentos")]
		private NumericUpDown _Valor_vista_equipamentos;

		// Token: 0x040017CF RID: 6095
		[AccessedThroughProperty("Label_vista_equipamentos")]
		private Label _Label_vista_equipamentos;

		// Token: 0x040017D0 RID: 6096
		[AccessedThroughProperty("DataGridView_RQ")]
		private DataGridView _DataGridView_RQ;

		// Token: 0x040017D1 RID: 6097
		[AccessedThroughProperty("DataGridView_central_geral")]
		private DataGridView _DataGridView_central_geral;

		// Token: 0x040017D2 RID: 6098
		[AccessedThroughProperty("DataGridView_central_rq")]
		private DataGridView _DataGridView_central_rq;

		// Token: 0x040017D3 RID: 6099
		[AccessedThroughProperty("DataGridView_central_res")]
		private DataGridView _DataGridView_central_res;

		// Token: 0x040017D4 RID: 6100
		[AccessedThroughProperty("Label_rq")]
		private Label _Label_rq;

		// Token: 0x040017D5 RID: 6101
		[AccessedThroughProperty("Label_res")]
		private Label _Label_res;

		// Token: 0x040017D6 RID: 6102
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x040017D7 RID: 6103
		[AccessedThroughProperty("ArquivoToolStripMenuItem")]
		private ToolStripMenuItem _ArquivoToolStripMenuItem;

		// Token: 0x040017D8 RID: 6104
		[AccessedThroughProperty("NovoToolStripMenuItem")]
		private ToolStripMenuItem _NovoToolStripMenuItem;

		// Token: 0x040017D9 RID: 6105
		[AccessedThroughProperty("AbrirToolStripMenuItem")]
		private ToolStripMenuItem _AbrirToolStripMenuItem;

		// Token: 0x040017DA RID: 6106
		[AccessedThroughProperty("SalvarToolStripMenuItem")]
		private ToolStripMenuItem _SalvarToolStripMenuItem;

		// Token: 0x040017DB RID: 6107
		[AccessedThroughProperty("Col_vista_end")]
		private DataGridViewTextBoxColumn _Col_vista_end;

		// Token: 0x040017DC RID: 6108
		[AccessedThroughProperty("Col_vista_res")]
		private DataGridViewTextBoxColumn _Col_vista_res;

		// Token: 0x040017DD RID: 6109
		[AccessedThroughProperty("Col_vista_rq")]
		private DataGridViewTextBoxColumn _Col_vista_rq;

		// Token: 0x040017DE RID: 6110
		[AccessedThroughProperty("Col_vista_pri")]
		private DataGridViewTextBoxColumn _Col_vista_pri;

		// Token: 0x040017DF RID: 6111
		[AccessedThroughProperty("Col_ct_rq_end")]
		private DataGridViewTextBoxColumn _Col_ct_rq_end;

		// Token: 0x040017E0 RID: 6112
		[AccessedThroughProperty("Col_ct_res_end")]
		private DataGridViewTextBoxColumn _Col_ct_res_end;

		// Token: 0x040017E1 RID: 6113
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog _OpenFileDialog1;

		// Token: 0x040017E2 RID: 6114
		[AccessedThroughProperty("SaveFileDialog1")]
		private SaveFileDialog _SaveFileDialog1;

		// Token: 0x040017E3 RID: 6115
		[AccessedThroughProperty("Col_end")]
		private DataGridViewTextBoxColumn _Col_end;

		// Token: 0x040017E4 RID: 6116
		[AccessedThroughProperty("Col_nome")]
		private DataGridViewTextBoxColumn _Col_nome;

		// Token: 0x040017E5 RID: 6117
		[AccessedThroughProperty("Col_altura")]
		private DataGridViewTextBoxColumn _Col_altura;

		// Token: 0x040017E6 RID: 6118
		[AccessedThroughProperty("Col_pri")]
		private DataGridViewTextBoxColumn _Col_pri;

		// Token: 0x040017E7 RID: 6119
		[AccessedThroughProperty("Col_posicao")]
		private DataGridViewTextBoxColumn _Col_posicao;

		// Token: 0x040017E8 RID: 6120
		[AccessedThroughProperty("Col_End_rq")]
		private DataGridViewTextBoxColumn _Col_End_rq;

		// Token: 0x040017E9 RID: 6121
		[AccessedThroughProperty("Col_nome_rq")]
		private DataGridViewTextBoxColumn _Col_nome_rq;

		// Token: 0x040017EA RID: 6122
		[AccessedThroughProperty("Col_ROrg_rq")]
		private DataGridViewTextBoxColumn _Col_ROrg_rq;

		// Token: 0x040017EB RID: 6123
		[AccessedThroughProperty("Col_RDest_rq")]
		private DataGridViewTextBoxColumn _Col_RDest_rq;

		// Token: 0x040017EC RID: 6124
		[AccessedThroughProperty("Col_mod_rq")]
		private DataGridViewComboBoxColumn _Col_mod_rq;

		// Token: 0x040017ED RID: 6125
		[AccessedThroughProperty("Col_pri_rq")]
		private DataGridViewTextBoxColumn _Col_pri_rq;

		// Token: 0x040017EE RID: 6126
		[AccessedThroughProperty("Col_Res1_rq")]
		private DataGridViewTextBoxColumn _Col_Res1_rq;

		// Token: 0x040017EF RID: 6127
		[AccessedThroughProperty("Col_Res2_rq")]
		private DataGridViewTextBoxColumn _Col_Res2_rq;

		// Token: 0x040017F0 RID: 6128
		[AccessedThroughProperty("Col_Res3_rq")]
		private DataGridViewTextBoxColumn _Col_Res3_rq;

		// Token: 0x040017F1 RID: 6129
		[AccessedThroughProperty("Col_Res4_rq")]
		private DataGridViewTextBoxColumn _Col_Res4_rq;

		// Token: 0x040017F2 RID: 6130
		[AccessedThroughProperty("Col_MsgR1_rq")]
		private DataGridViewTextBoxColumn _Col_MsgR1_rq;

		// Token: 0x040017F3 RID: 6131
		[AccessedThroughProperty("Col_MsgR2_rq")]
		private DataGridViewTextBoxColumn _Col_MsgR2_rq;

		// Token: 0x040017F4 RID: 6132
		[AccessedThroughProperty("Col_MsgR3_rq")]
		private DataGridViewTextBoxColumn _Col_MsgR3_rq;

		// Token: 0x040017F5 RID: 6133
		[AccessedThroughProperty("Col_MsgR4_rq")]
		private DataGridViewTextBoxColumn _Col_MsgR4_rq;

		// Token: 0x040017F6 RID: 6134
		[AccessedThroughProperty("Col_hab")]
		private DataGridViewComboBoxColumn _Col_hab;

		// Token: 0x040017F7 RID: 6135
		[AccessedThroughProperty("Col_Esc_1")]
		private DataGridViewTextBoxColumn _Col_Esc_1;

		// Token: 0x040017F8 RID: 6136
		[AccessedThroughProperty("Col_Esc_2")]
		private DataGridViewTextBoxColumn _Col_Esc_2;

		// Token: 0x040017F9 RID: 6137
		[AccessedThroughProperty("Col_Esc_3")]
		private DataGridViewTextBoxColumn _Col_Esc_3;

		// Token: 0x040017FA RID: 6138
		[AccessedThroughProperty("Col_Esc_4")]
		private DataGridViewTextBoxColumn _Col_Esc_4;

		// Token: 0x040017FB RID: 6139
		[AccessedThroughProperty("Col_Esc_5")]
		private DataGridViewTextBoxColumn _Col_Esc_5;

		// Token: 0x040017FC RID: 6140
		[AccessedThroughProperty("Col_Esc_6")]
		private DataGridViewTextBoxColumn _Col_Esc_6;

		// Token: 0x040017FD RID: 6141
		[AccessedThroughProperty("Col_Esc_7")]
		private DataGridViewTextBoxColumn _Col_Esc_7;

		// Token: 0x040017FE RID: 6142
		[AccessedThroughProperty("Col_Esc_8")]
		private DataGridViewTextBoxColumn _Col_Esc_8;

		// Token: 0x040017FF RID: 6143
		[AccessedThroughProperty("Col_Esc_9")]
		private DataGridViewTextBoxColumn _Col_Esc_9;

		// Token: 0x04001800 RID: 6144
		[AccessedThroughProperty("Col_Esc_10")]
		private DataGridViewTextBoxColumn _Col_Esc_10;

		// Token: 0x04001801 RID: 6145
		[AccessedThroughProperty("Col_Esc_11")]
		private DataGridViewTextBoxColumn _Col_Esc_11;

		// Token: 0x04001802 RID: 6146
		[AccessedThroughProperty("Col_Esc_12")]
		private DataGridViewTextBoxColumn _Col_Esc_12;

		// Token: 0x04001803 RID: 6147
		[AccessedThroughProperty("Col_Esc_13")]
		private DataGridViewTextBoxColumn _Col_Esc_13;

		// Token: 0x04001804 RID: 6148
		[AccessedThroughProperty("Col_Esc_14")]
		private DataGridViewTextBoxColumn _Col_Esc_14;

		// Token: 0x04001805 RID: 6149
		[AccessedThroughProperty("Col_Esc_15")]
		private DataGridViewTextBoxColumn _Col_Esc_15;

		// Token: 0x04001806 RID: 6150
		[AccessedThroughProperty("Col_Esc_16")]
		private DataGridViewTextBoxColumn _Col_Esc_16;
	}
}
