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
	// Token: 0x02000089 RID: 137
	[DesignerGenerated]
	public partial class Equip_590_conf : Form
	{
		// Token: 0x0600230A RID: 8970 RVA: 0x0040386C File Offset: 0x00401C6C
		public Equip_590_conf()
		{
			base.Load += new EventHandler(this.Equip_590_conf_Load);
			this.InitializeComponent();
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x0040680C File Offset: 0x00404C0C
		// (set) Token: 0x0600230E RID: 8974 RVA: 0x00406820 File Offset: 0x00404C20
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

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x0040682C File Offset: 0x00404C2C
		// (set) Token: 0x06002310 RID: 8976 RVA: 0x00406840 File Offset: 0x00404C40
		internal virtual Button Esc_conf_md_590
		{
			get
			{
				return this._Esc_conf_md_590;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Esc_conf_md_590_Click);
				if (this._Esc_conf_md_590 != null)
				{
					this._Esc_conf_md_590.Click -= eventHandler;
				}
				this._Esc_conf_md_590 = value;
				if (this._Esc_conf_md_590 != null)
				{
					this._Esc_conf_md_590.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x0040688C File Offset: 0x00404C8C
		// (set) Token: 0x06002312 RID: 8978 RVA: 0x004068A0 File Offset: 0x00404CA0
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

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x004068AC File Offset: 0x00404CAC
		// (set) Token: 0x06002314 RID: 8980 RVA: 0x004068C0 File Offset: 0x00404CC0
		internal virtual Button Ler_conf_md_590
		{
			get
			{
				return this._Ler_conf_md_590;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Ler_conf_md_590_Click);
				if (this._Ler_conf_md_590 != null)
				{
					this._Ler_conf_md_590.Click -= eventHandler;
				}
				this._Ler_conf_md_590 = value;
				if (this._Ler_conf_md_590 != null)
				{
					this._Ler_conf_md_590.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x0040690C File Offset: 0x00404D0C
		// (set) Token: 0x06002316 RID: 8982 RVA: 0x00406920 File Offset: 0x00404D20
		internal virtual GroupBox Grupo_parametros_radio
		{
			get
			{
				return this._Grupo_parametros_radio;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_parametros_radio = value;
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x0040692C File Offset: 0x00404D2C
		// (set) Token: 0x06002318 RID: 8984 RVA: 0x00406940 File Offset: 0x00404D40
		internal virtual GroupBox Grupo_parametros_rf
		{
			get
			{
				return this._Grupo_parametros_rf;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_parametros_rf = value;
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x0040694C File Offset: 0x00404D4C
		// (set) Token: 0x0600231A RID: 8986 RVA: 0x00406960 File Offset: 0x00404D60
		internal virtual GroupBox Grupo_parametros_comunicacao
		{
			get
			{
				return this._Grupo_parametros_comunicacao;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_parametros_comunicacao = value;
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x0040696C File Offset: 0x00404D6C
		// (set) Token: 0x0600231C RID: 8988 RVA: 0x00406980 File Offset: 0x00404D80
		internal virtual GroupBox Grupo_modo_operacao
		{
			get
			{
				return this._Grupo_modo_operacao;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_modo_operacao = value;
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x0040698C File Offset: 0x00404D8C
		// (set) Token: 0x0600231E RID: 8990 RVA: 0x004069A0 File Offset: 0x00404DA0
		internal virtual NumericUpDown Valor_interface_timeout
		{
			get
			{
				return this._Valor_interface_timeout;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_interface_timeout_ValueChanged);
				if (this._Valor_interface_timeout != null)
				{
					this._Valor_interface_timeout.ValueChanged -= eventHandler;
				}
				this._Valor_interface_timeout = value;
				if (this._Valor_interface_timeout != null)
				{
					this._Valor_interface_timeout.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x004069EC File Offset: 0x00404DEC
		// (set) Token: 0x06002320 RID: 8992 RVA: 0x00406A00 File Offset: 0x00404E00
		internal virtual Label Label_interface_timeout
		{
			get
			{
				return this._Label_interface_timeout;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_interface_timeout = value;
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x00406A0C File Offset: 0x00404E0C
		// (set) Token: 0x06002322 RID: 8994 RVA: 0x00406A20 File Offset: 0x00404E20
		internal virtual NumericUpDown Valor_packed_size
		{
			get
			{
				return this._Valor_packed_size;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_packed_size_ValueChanged);
				if (this._Valor_packed_size != null)
				{
					this._Valor_packed_size.ValueChanged -= eventHandler;
				}
				this._Valor_packed_size = value;
				if (this._Valor_packed_size != null)
				{
					this._Valor_packed_size.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x00406A6C File Offset: 0x00404E6C
		// (set) Token: 0x06002324 RID: 8996 RVA: 0x00406A80 File Offset: 0x00404E80
		internal virtual Label Label_rf_packed_size
		{
			get
			{
				return this._Label_rf_packed_size;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_rf_packed_size = value;
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x00406A8C File Offset: 0x00404E8C
		// (set) Token: 0x06002326 RID: 8998 RVA: 0x00406AA0 File Offset: 0x00404EA0
		internal virtual NumericUpDown Valor_cts_on
		{
			get
			{
				return this._Valor_cts_on;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_cts_on_ValueChanged);
				if (this._Valor_cts_on != null)
				{
					this._Valor_cts_on.ValueChanged -= eventHandler;
				}
				this._Valor_cts_on = value;
				if (this._Valor_cts_on != null)
				{
					this._Valor_cts_on.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x00406AEC File Offset: 0x00404EEC
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x00406B00 File Offset: 0x00404F00
		internal virtual Label Label_cts_on_hysteresis
		{
			get
			{
				return this._Label_cts_on_hysteresis;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cts_on_hysteresis = value;
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x00406B0C File Offset: 0x00404F0C
		// (set) Token: 0x0600232A RID: 9002 RVA: 0x00406B20 File Offset: 0x00404F20
		internal virtual Label Label_cts_on
		{
			get
			{
				return this._Label_cts_on;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_cts_on = value;
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x00406B2C File Offset: 0x00404F2C
		// (set) Token: 0x0600232C RID: 9004 RVA: 0x00406B40 File Offset: 0x00404F40
		internal virtual NumericUpDown Valor_cts_on_hysteresis
		{
			get
			{
				return this._Valor_cts_on_hysteresis;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_cts_on_hysteresis_ValueChanged);
				if (this._Valor_cts_on_hysteresis != null)
				{
					this._Valor_cts_on_hysteresis.ValueChanged -= eventHandler;
				}
				this._Valor_cts_on_hysteresis = value;
				if (this._Valor_cts_on_hysteresis != null)
				{
					this._Valor_cts_on_hysteresis.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x00406B8C File Offset: 0x00404F8C
		// (set) Token: 0x0600232E RID: 9006 RVA: 0x00406BA0 File Offset: 0x00404FA0
		internal virtual NumericUpDown Valor_transmit_retries
		{
			get
			{
				return this._Valor_transmit_retries;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_transmit_retries_ValueChanged);
				if (this._Valor_transmit_retries != null)
				{
					this._Valor_transmit_retries.ValueChanged -= eventHandler;
				}
				this._Valor_transmit_retries = value;
				if (this._Valor_transmit_retries != null)
				{
					this._Valor_transmit_retries.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x00406BEC File Offset: 0x00404FEC
		// (set) Token: 0x06002330 RID: 9008 RVA: 0x00406C00 File Offset: 0x00405000
		internal virtual Label Label_transmit_retries
		{
			get
			{
				return this._Label_transmit_retries;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_transmit_retries = value;
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x00406C0C File Offset: 0x0040500C
		// (set) Token: 0x06002332 RID: 9010 RVA: 0x00406C20 File Offset: 0x00405020
		internal virtual NumericUpDown Valor_Broadcast_Attempts
		{
			get
			{
				return this._Valor_Broadcast_Attempts;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_Broadcast_Attempts_ValueChanged);
				if (this._Valor_Broadcast_Attempts != null)
				{
					this._Valor_Broadcast_Attempts.ValueChanged -= eventHandler;
				}
				this._Valor_Broadcast_Attempts = value;
				if (this._Valor_Broadcast_Attempts != null)
				{
					this._Valor_Broadcast_Attempts.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x00406C6C File Offset: 0x0040506C
		// (set) Token: 0x06002334 RID: 9012 RVA: 0x00406C80 File Offset: 0x00405080
		internal virtual Label Label_Broadcast_Attempts
		{
			get
			{
				return this._Label_Broadcast_Attempts;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_Broadcast_Attempts = value;
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x00406C8C File Offset: 0x0040508C
		// (set) Token: 0x06002336 RID: 9014 RVA: 0x00406CA0 File Offset: 0x004050A0
		internal virtual NumericUpDown Valor_Range_Refresh
		{
			get
			{
				return this._Valor_Range_Refresh;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_Range_Refresh_ValueChanged);
				if (this._Valor_Range_Refresh != null)
				{
					this._Valor_Range_Refresh.ValueChanged -= eventHandler;
				}
				this._Valor_Range_Refresh = value;
				if (this._Valor_Range_Refresh != null)
				{
					this._Valor_Range_Refresh.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x00406CEC File Offset: 0x004050EC
		// (set) Token: 0x06002338 RID: 9016 RVA: 0x00406D00 File Offset: 0x00405100
		internal virtual NumericUpDown Valor_Stop_Bit_Delay
		{
			get
			{
				return this._Valor_Stop_Bit_Delay;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_Stop_Bit_Delay_ValueChanged);
				if (this._Valor_Stop_Bit_Delay != null)
				{
					this._Valor_Stop_Bit_Delay.ValueChanged -= eventHandler;
				}
				this._Valor_Stop_Bit_Delay = value;
				if (this._Valor_Stop_Bit_Delay != null)
				{
					this._Valor_Stop_Bit_Delay.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x00406D4C File Offset: 0x0040514C
		// (set) Token: 0x0600233A RID: 9018 RVA: 0x00406D60 File Offset: 0x00405160
		internal virtual Label Label_Range_Refresh
		{
			get
			{
				return this._Label_Range_Refresh;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_Range_Refresh = value;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x0600233B RID: 9019 RVA: 0x00406D6C File Offset: 0x0040516C
		// (set) Token: 0x0600233C RID: 9020 RVA: 0x00406D80 File Offset: 0x00405180
		internal virtual Label Label_Stop_Bit_Delay
		{
			get
			{
				return this._Label_Stop_Bit_Delay;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_Stop_Bit_Delay = value;
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x0600233D RID: 9021 RVA: 0x00406D8C File Offset: 0x0040518C
		// (set) Token: 0x0600233E RID: 9022 RVA: 0x00406DA0 File Offset: 0x004051A0
		internal virtual ComboBox Combo_mode
		{
			get
			{
				return this._Combo_mode;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_mode_SelectedIndexChanged);
				if (this._Combo_mode != null)
				{
					this._Combo_mode.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_mode = value;
				if (this._Combo_mode != null)
				{
					this._Combo_mode.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x00406DEC File Offset: 0x004051EC
		// (set) Token: 0x06002340 RID: 9024 RVA: 0x00406E00 File Offset: 0x00405200
		internal virtual Label Label_mode
		{
			get
			{
				return this._Label_mode;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_mode = value;
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x00406E0C File Offset: 0x0040520C
		// (set) Token: 0x06002342 RID: 9026 RVA: 0x00406E20 File Offset: 0x00405220
		internal virtual NumericUpDown Valor_Sync_to_Channel
		{
			get
			{
				return this._Valor_Sync_to_Channel;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_Sync_to_Channel_ValueChanged);
				if (this._Valor_Sync_to_Channel != null)
				{
					this._Valor_Sync_to_Channel.ValueChanged -= eventHandler;
				}
				this._Valor_Sync_to_Channel = value;
				if (this._Valor_Sync_to_Channel != null)
				{
					this._Valor_Sync_to_Channel.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x00406E6C File Offset: 0x0040526C
		// (set) Token: 0x06002344 RID: 9028 RVA: 0x00406E80 File Offset: 0x00405280
		internal virtual Label Label_Sync_to_Channel
		{
			get
			{
				return this._Label_Sync_to_Channel;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_Sync_to_Channel = value;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x00406E8C File Offset: 0x0040528C
		// (set) Token: 0x06002346 RID: 9030 RVA: 0x00406EA0 File Offset: 0x004052A0
		internal virtual NumericUpDown Valor_RF_Channel_Number
		{
			get
			{
				return this._Valor_RF_Channel_Number;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_RF_Channel_Number_ValueChanged);
				if (this._Valor_RF_Channel_Number != null)
				{
					this._Valor_RF_Channel_Number.ValueChanged -= eventHandler;
				}
				this._Valor_RF_Channel_Number = value;
				if (this._Valor_RF_Channel_Number != null)
				{
					this._Valor_RF_Channel_Number.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x00406EEC File Offset: 0x004052EC
		// (set) Token: 0x06002348 RID: 9032 RVA: 0x00406F00 File Offset: 0x00405300
		internal virtual Label Label_RF_Channel_Number
		{
			get
			{
				return this._Label_RF_Channel_Number;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_RF_Channel_Number = value;
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x00406F0C File Offset: 0x0040530C
		// (set) Token: 0x0600234A RID: 9034 RVA: 0x00406F20 File Offset: 0x00405320
		internal virtual NumericUpDown Valor_System_ID
		{
			get
			{
				return this._Valor_System_ID;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_System_ID_ValueChanged);
				if (this._Valor_System_ID != null)
				{
					this._Valor_System_ID.ValueChanged -= eventHandler;
				}
				this._Valor_System_ID = value;
				if (this._Valor_System_ID != null)
				{
					this._Valor_System_ID.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x00406F6C File Offset: 0x0040536C
		// (set) Token: 0x0600234C RID: 9036 RVA: 0x00406F80 File Offset: 0x00405380
		internal virtual Label Label_System_ID
		{
			get
			{
				return this._Label_System_ID;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_System_ID = value;
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x00406F8C File Offset: 0x0040538C
		// (set) Token: 0x0600234E RID: 9038 RVA: 0x00406FA0 File Offset: 0x004053A0
		internal virtual ComboBox Combo_max_power
		{
			get
			{
				return this._Combo_max_power;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_max_power_SelectedIndexChanged);
				if (this._Combo_max_power != null)
				{
					this._Combo_max_power.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_max_power = value;
				if (this._Combo_max_power != null)
				{
					this._Combo_max_power.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x00406FEC File Offset: 0x004053EC
		// (set) Token: 0x06002350 RID: 9040 RVA: 0x00407000 File Offset: 0x00405400
		internal virtual Label Label_max_power
		{
			get
			{
				return this._Label_max_power;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_max_power = value;
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06002351 RID: 9041 RVA: 0x0040700C File Offset: 0x0040540C
		// (set) Token: 0x06002352 RID: 9042 RVA: 0x00407020 File Offset: 0x00405420
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

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x0040706C File Offset: 0x0040546C
		// (set) Token: 0x06002354 RID: 9044 RVA: 0x00407080 File Offset: 0x00405480
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

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x0040708C File Offset: 0x0040548C
		// (set) Token: 0x06002356 RID: 9046 RVA: 0x004070A0 File Offset: 0x004054A0
		internal virtual TextBox Valor_dest_4
		{
			get
			{
				return this._Valor_dest_4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_dest_4_TextChanged);
				if (this._Valor_dest_4 != null)
				{
					this._Valor_dest_4.TextChanged -= eventHandler;
				}
				this._Valor_dest_4 = value;
				if (this._Valor_dest_4 != null)
				{
					this._Valor_dest_4.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x004070EC File Offset: 0x004054EC
		// (set) Token: 0x06002358 RID: 9048 RVA: 0x00407100 File Offset: 0x00405500
		internal virtual TextBox Valor_dest_3
		{
			get
			{
				return this._Valor_dest_3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_dest_3_TextChanged);
				if (this._Valor_dest_3 != null)
				{
					this._Valor_dest_3.TextChanged -= eventHandler;
				}
				this._Valor_dest_3 = value;
				if (this._Valor_dest_3 != null)
				{
					this._Valor_dest_3.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06002359 RID: 9049 RVA: 0x0040714C File Offset: 0x0040554C
		// (set) Token: 0x0600235A RID: 9050 RVA: 0x00407160 File Offset: 0x00405560
		internal virtual TextBox Valor_dest_2
		{
			get
			{
				return this._Valor_dest_2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_dest_2_TextChanged);
				if (this._Valor_dest_2 != null)
				{
					this._Valor_dest_2.TextChanged -= eventHandler;
				}
				this._Valor_dest_2 = value;
				if (this._Valor_dest_2 != null)
				{
					this._Valor_dest_2.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x0600235B RID: 9051 RVA: 0x004071AC File Offset: 0x004055AC
		// (set) Token: 0x0600235C RID: 9052 RVA: 0x004071C0 File Offset: 0x004055C0
		internal virtual TextBox Valor_dest_1
		{
			get
			{
				return this._Valor_dest_1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_dest_1_TextChanged);
				if (this._Valor_dest_1 != null)
				{
					this._Valor_dest_1.TextChanged -= eventHandler;
				}
				this._Valor_dest_1 = value;
				if (this._Valor_dest_1 != null)
				{
					this._Valor_dest_1.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x0600235D RID: 9053 RVA: 0x0040720C File Offset: 0x0040560C
		// (set) Token: 0x0600235E RID: 9054 RVA: 0x00407220 File Offset: 0x00405620
		internal virtual Label Label_destination
		{
			get
			{
				return this._Label_destination;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_destination = value;
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x0600235F RID: 9055 RVA: 0x0040722C File Offset: 0x0040562C
		// (set) Token: 0x06002360 RID: 9056 RVA: 0x00407240 File Offset: 0x00405640
		internal virtual TextBox Valor_dest_5
		{
			get
			{
				return this._Valor_dest_5;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_dest_5_TextChanged);
				if (this._Valor_dest_5 != null)
				{
					this._Valor_dest_5.TextChanged -= eventHandler;
				}
				this._Valor_dest_5 = value;
				if (this._Valor_dest_5 != null)
				{
					this._Valor_dest_5.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06002361 RID: 9057 RVA: 0x0040728C File Offset: 0x0040568C
		// (set) Token: 0x06002362 RID: 9058 RVA: 0x004072A0 File Offset: 0x004056A0
		internal virtual TextBox Valor_desK_5
		{
			get
			{
				return this._Valor_desK_5;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_desK_5_TextChanged);
				if (this._Valor_desK_5 != null)
				{
					this._Valor_desK_5.TextChanged -= eventHandler;
				}
				this._Valor_desK_5 = value;
				if (this._Valor_desK_5 != null)
				{
					this._Valor_desK_5.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002363 RID: 9059 RVA: 0x004072EC File Offset: 0x004056EC
		// (set) Token: 0x06002364 RID: 9060 RVA: 0x00407300 File Offset: 0x00405700
		internal virtual TextBox Valor_desK_6
		{
			get
			{
				return this._Valor_desK_6;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_desK_6_TextChanged);
				if (this._Valor_desK_6 != null)
				{
					this._Valor_desK_6.TextChanged -= eventHandler;
				}
				this._Valor_desK_6 = value;
				if (this._Valor_desK_6 != null)
				{
					this._Valor_desK_6.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002365 RID: 9061 RVA: 0x0040734C File Offset: 0x0040574C
		// (set) Token: 0x06002366 RID: 9062 RVA: 0x00407360 File Offset: 0x00405760
		internal virtual TextBox Valor_desK_4
		{
			get
			{
				return this._Valor_desK_4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_desK_4_TextChanged);
				if (this._Valor_desK_4 != null)
				{
					this._Valor_desK_4.TextChanged -= eventHandler;
				}
				this._Valor_desK_4 = value;
				if (this._Valor_desK_4 != null)
				{
					this._Valor_desK_4.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x004073AC File Offset: 0x004057AC
		// (set) Token: 0x06002368 RID: 9064 RVA: 0x004073C0 File Offset: 0x004057C0
		internal virtual TextBox Valor_desK_3
		{
			get
			{
				return this._Valor_desK_3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_desK_3_TextChanged);
				if (this._Valor_desK_3 != null)
				{
					this._Valor_desK_3.TextChanged -= eventHandler;
				}
				this._Valor_desK_3 = value;
				if (this._Valor_desK_3 != null)
				{
					this._Valor_desK_3.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x0040740C File Offset: 0x0040580C
		// (set) Token: 0x0600236A RID: 9066 RVA: 0x00407420 File Offset: 0x00405820
		internal virtual TextBox Valor_desK_2
		{
			get
			{
				return this._Valor_desK_2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_desK_2_TextChanged);
				if (this._Valor_desK_2 != null)
				{
					this._Valor_desK_2.TextChanged -= eventHandler;
				}
				this._Valor_desK_2 = value;
				if (this._Valor_desK_2 != null)
				{
					this._Valor_desK_2.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x0040746C File Offset: 0x0040586C
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x00407480 File Offset: 0x00405880
		internal virtual TextBox Valor_desK_1
		{
			get
			{
				return this._Valor_desK_1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_desK_1_TextChanged);
				if (this._Valor_desK_1 != null)
				{
					this._Valor_desK_1.TextChanged -= eventHandler;
				}
				this._Valor_desK_1 = value;
				if (this._Valor_desK_1 != null)
				{
					this._Valor_desK_1.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x004074CC File Offset: 0x004058CC
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x004074E0 File Offset: 0x004058E0
		internal virtual Label Label_des_key
		{
			get
			{
				return this._Label_des_key;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_des_key = value;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x004074EC File Offset: 0x004058EC
		// (set) Token: 0x06002370 RID: 9072 RVA: 0x00407500 File Offset: 0x00405900
		internal virtual TextBox Valor_dest_6
		{
			get
			{
				return this._Valor_dest_6;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_dest_6_TextChanged);
				if (this._Valor_dest_6 != null)
				{
					this._Valor_dest_6.TextChanged -= eventHandler;
				}
				this._Valor_dest_6 = value;
				if (this._Valor_dest_6 != null)
				{
					this._Valor_dest_6.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x0040754C File Offset: 0x0040594C
		// (set) Token: 0x06002372 RID: 9074 RVA: 0x00407560 File Offset: 0x00405960
		internal virtual Label Label_mac_adress
		{
			get
			{
				return this._Label_mac_adress;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_mac_adress = value;
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x0040756C File Offset: 0x0040596C
		// (set) Token: 0x06002374 RID: 9076 RVA: 0x00407580 File Offset: 0x00405980
		internal virtual TextBox Valor_mac_adress
		{
			get
			{
				return this._Valor_mac_adress;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_mac_adress = value;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x0040758C File Offset: 0x0040598C
		// (set) Token: 0x06002376 RID: 9078 RVA: 0x004075A0 File Offset: 0x004059A0
		internal virtual TextBox Valor_desK_7
		{
			get
			{
				return this._Valor_desK_7;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_desK_7_TextChanged);
				if (this._Valor_desK_7 != null)
				{
					this._Valor_desK_7.TextChanged -= eventHandler;
				}
				this._Valor_desK_7 = value;
				if (this._Valor_desK_7 != null)
				{
					this._Valor_desK_7.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x004075EC File Offset: 0x004059EC
		// (set) Token: 0x06002378 RID: 9080 RVA: 0x00407600 File Offset: 0x00405A00
		internal virtual TextBox Valor_firmware
		{
			get
			{
				return this._Valor_firmware;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_firmware = value;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x0040760C File Offset: 0x00405A0C
		// (set) Token: 0x0600237A RID: 9082 RVA: 0x00407620 File Offset: 0x00405A20
		internal virtual Label Label_firmware
		{
			get
			{
				return this._Label_firmware;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_firmware = value;
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x0040762C File Offset: 0x00405A2C
		// (set) Token: 0x0600237C RID: 9084 RVA: 0x00407640 File Offset: 0x00405A40
		internal virtual CheckBox Check_auto_destination
		{
			get
			{
				return this._Check_auto_destination;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_auto_destination_CheckedChanged);
				if (this._Check_auto_destination != null)
				{
					this._Check_auto_destination.CheckedChanged -= eventHandler;
				}
				this._Check_auto_destination = value;
				if (this._Check_auto_destination != null)
				{
					this._Check_auto_destination.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x0040768C File Offset: 0x00405A8C
		// (set) Token: 0x0600237E RID: 9086 RVA: 0x004076A0 File Offset: 0x00405AA0
		internal virtual CheckBox Check_des_enabled
		{
			get
			{
				return this._Check_des_enabled;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_des_enabled_CheckedChanged);
				if (this._Check_des_enabled != null)
				{
					this._Check_des_enabled.CheckedChanged -= eventHandler;
				}
				this._Check_des_enabled = value;
				if (this._Check_des_enabled != null)
				{
					this._Check_des_enabled.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x004076EC File Offset: 0x00405AEC
		// (set) Token: 0x06002380 RID: 9088 RVA: 0x00407700 File Offset: 0x00405B00
		internal virtual CheckBox Check_full_duplex
		{
			get
			{
				return this._Check_full_duplex;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_full_duplex_CheckedChanged);
				if (this._Check_full_duplex != null)
				{
					this._Check_full_duplex.CheckedChanged -= eventHandler;
				}
				this._Check_full_duplex = value;
				if (this._Check_full_duplex != null)
				{
					this._Check_full_duplex.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06002381 RID: 9089 RVA: 0x0040774C File Offset: 0x00405B4C
		// (set) Token: 0x06002382 RID: 9090 RVA: 0x00407760 File Offset: 0x00405B60
		internal virtual CheckBox Check_auto_config
		{
			get
			{
				return this._Check_auto_config;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_auto_config_CheckedChanged);
				if (this._Check_auto_config != null)
				{
					this._Check_auto_config.CheckedChanged -= eventHandler;
				}
				this._Check_auto_config = value;
				if (this._Check_auto_config != null)
				{
					this._Check_auto_config.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06002383 RID: 9091 RVA: 0x004077AC File Offset: 0x00405BAC
		// (set) Token: 0x06002384 RID: 9092 RVA: 0x004077C0 File Offset: 0x00405BC0
		internal virtual CheckBox Check_sync_channel
		{
			get
			{
				return this._Check_sync_channel;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_sync_channel_CheckedChanged);
				if (this._Check_sync_channel != null)
				{
					this._Check_sync_channel.CheckedChanged -= eventHandler;
				}
				this._Check_sync_channel = value;
				if (this._Check_sync_channel != null)
				{
					this._Check_sync_channel.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06002385 RID: 9093 RVA: 0x0040780C File Offset: 0x00405C0C
		// (set) Token: 0x06002386 RID: 9094 RVA: 0x00407820 File Offset: 0x00405C20
		internal virtual CheckBox Check_auto_channel
		{
			get
			{
				return this._Check_auto_channel;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_auto_channel_CheckedChanged);
				if (this._Check_auto_channel != null)
				{
					this._Check_auto_channel.CheckedChanged -= eventHandler;
				}
				this._Check_auto_channel = value;
				if (this._Check_auto_channel != null)
				{
					this._Check_auto_channel.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x0040786C File Offset: 0x00405C6C
		// (set) Token: 0x06002388 RID: 9096 RVA: 0x00407880 File Offset: 0x00405C80
		internal virtual CheckBox Check_unicast_only
		{
			get
			{
				return this._Check_unicast_only;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_unicast_only_CheckedChanged);
				if (this._Check_unicast_only != null)
				{
					this._Check_unicast_only.CheckedChanged -= eventHandler;
				}
				this._Check_unicast_only = value;
				if (this._Check_unicast_only != null)
				{
					this._Check_unicast_only.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x004078CC File Offset: 0x00405CCC
		// (set) Token: 0x0600238A RID: 9098 RVA: 0x004078E0 File Offset: 0x00405CE0
		internal virtual CheckBox Check_broadcast_mode
		{
			get
			{
				return this._Check_broadcast_mode;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_broadcast_mode_CheckedChanged);
				if (this._Check_broadcast_mode != null)
				{
					this._Check_broadcast_mode.CheckedChanged -= eventHandler;
				}
				this._Check_broadcast_mode = value;
				if (this._Check_broadcast_mode != null)
				{
					this._Check_broadcast_mode.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x0040792C File Offset: 0x00405D2C
		// (set) Token: 0x0600238C RID: 9100 RVA: 0x00407940 File Offset: 0x00405D40
		internal virtual CheckBox Check_parity_mode
		{
			get
			{
				return this._Check_parity_mode;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_parity_mode_CheckedChanged);
				if (this._Check_parity_mode != null)
				{
					this._Check_parity_mode.CheckedChanged -= eventHandler;
				}
				this._Check_parity_mode = value;
				if (this._Check_parity_mode != null)
				{
					this._Check_parity_mode.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x0040798C File Offset: 0x00405D8C
		// (set) Token: 0x0600238E RID: 9102 RVA: 0x004079A0 File Offset: 0x00405DA0
		internal virtual CheckBox Check_protocol_status
		{
			get
			{
				return this._Check_protocol_status;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_protocol_status_CheckedChanged);
				if (this._Check_protocol_status != null)
				{
					this._Check_protocol_status.CheckedChanged -= eventHandler;
				}
				this._Check_protocol_status = value;
				if (this._Check_protocol_status != null)
				{
					this._Check_protocol_status.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x004079EC File Offset: 0x00405DEC
		// (set) Token: 0x06002390 RID: 9104 RVA: 0x00407A00 File Offset: 0x00405E00
		internal virtual CheckBox Check_485dere
		{
			get
			{
				return this._Check_485dere;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_485dere_CheckedChanged);
				if (this._Check_485dere != null)
				{
					this._Check_485dere.CheckedChanged -= eventHandler;
				}
				this._Check_485dere = value;
				if (this._Check_485dere != null)
				{
					this._Check_485dere.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x00407A4C File Offset: 0x00405E4C
		// (set) Token: 0x06002392 RID: 9106 RVA: 0x00407A60 File Offset: 0x00405E60
		internal virtual CheckBox Check_modem_mode
		{
			get
			{
				return this._Check_modem_mode;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_modem_mode_CheckedChanged);
				if (this._Check_modem_mode != null)
				{
					this._Check_modem_mode.CheckedChanged -= eventHandler;
				}
				this._Check_modem_mode = value;
				if (this._Check_modem_mode != null)
				{
					this._Check_modem_mode.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x00407AAC File Offset: 0x00405EAC
		// (set) Token: 0x06002394 RID: 9108 RVA: 0x00407AC0 File Offset: 0x00405EC0
		internal virtual CheckBox Check_rts_enable
		{
			get
			{
				return this._Check_rts_enable;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_rts_enable_CheckedChanged);
				if (this._Check_rts_enable != null)
				{
					this._Check_rts_enable.CheckedChanged -= eventHandler;
				}
				this._Check_rts_enable = value;
				if (this._Check_rts_enable != null)
				{
					this._Check_rts_enable.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06002395 RID: 9109 RVA: 0x00407B0C File Offset: 0x00405F0C
		// (set) Token: 0x06002396 RID: 9110 RVA: 0x00407B20 File Offset: 0x00405F20
		internal virtual CheckBox Check_beacon_mode
		{
			get
			{
				return this._Check_beacon_mode;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_beacon_mode_CheckedChanged);
				if (this._Check_beacon_mode != null)
				{
					this._Check_beacon_mode.CheckedChanged -= eventHandler;
				}
				this._Check_beacon_mode = value;
				if (this._Check_beacon_mode != null)
				{
					this._Check_beacon_mode.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06002397 RID: 9111 RVA: 0x00407B6C File Offset: 0x00405F6C
		// (set) Token: 0x06002398 RID: 9112 RVA: 0x00407B80 File Offset: 0x00405F80
		internal virtual CheckBox Check_enhanced_api_enabled
		{
			get
			{
				return this._Check_enhanced_api_enabled;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_enhanced_api_enabled_CheckedChanged);
				if (this._Check_enhanced_api_enabled != null)
				{
					this._Check_enhanced_api_enabled.CheckedChanged -= eventHandler;
				}
				this._Check_enhanced_api_enabled = value;
				if (this._Check_enhanced_api_enabled != null)
				{
					this._Check_enhanced_api_enabled.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06002399 RID: 9113 RVA: 0x00407BCC File Offset: 0x00405FCC
		// (set) Token: 0x0600239A RID: 9114 RVA: 0x00407BE0 File Offset: 0x00405FE0
		internal virtual CheckBox Check_receive_api
		{
			get
			{
				return this._Check_receive_api;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_receive_api_CheckedChanged);
				if (this._Check_receive_api != null)
				{
					this._Check_receive_api.CheckedChanged -= eventHandler;
				}
				this._Check_receive_api = value;
				if (this._Check_receive_api != null)
				{
					this._Check_receive_api.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x0600239B RID: 9115 RVA: 0x00407C2C File Offset: 0x0040602C
		// (set) Token: 0x0600239C RID: 9116 RVA: 0x00407C40 File Offset: 0x00406040
		internal virtual CheckBox Check_auto_calibrate
		{
			get
			{
				return this._Check_auto_calibrate;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_auto_calibrate_CheckedChanged);
				if (this._Check_auto_calibrate != null)
				{
					this._Check_auto_calibrate.CheckedChanged -= eventHandler;
				}
				this._Check_auto_calibrate = value;
				if (this._Check_auto_calibrate != null)
				{
					this._Check_auto_calibrate.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x0600239D RID: 9117 RVA: 0x00407C8C File Offset: 0x0040608C
		// (set) Token: 0x0600239E RID: 9118 RVA: 0x00407CA0 File Offset: 0x004060A0
		internal virtual CheckBox Check_send_data_complete
		{
			get
			{
				return this._Check_send_data_complete;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_send_data_complete_CheckedChanged);
				if (this._Check_send_data_complete != null)
				{
					this._Check_send_data_complete.CheckedChanged -= eventHandler;
				}
				this._Check_send_data_complete = value;
				if (this._Check_send_data_complete != null)
				{
					this._Check_send_data_complete.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x0600239F RID: 9119 RVA: 0x00407CEC File Offset: 0x004060EC
		// (set) Token: 0x060023A0 RID: 9120 RVA: 0x00407D00 File Offset: 0x00406100
		internal virtual CheckBox Check_enhanced_receive_api
		{
			get
			{
				return this._Check_enhanced_receive_api;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_enhanced_receive_api_CheckedChanged);
				if (this._Check_enhanced_receive_api != null)
				{
					this._Check_enhanced_receive_api.CheckedChanged -= eventHandler;
				}
				this._Check_enhanced_receive_api = value;
				if (this._Check_enhanced_receive_api != null)
				{
					this._Check_enhanced_receive_api.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060023A1 RID: 9121 RVA: 0x00407D4C File Offset: 0x0040614C
		// (set) Token: 0x060023A2 RID: 9122 RVA: 0x00407D60 File Offset: 0x00406160
		internal virtual CheckBox Check_transmit_api
		{
			get
			{
				return this._Check_transmit_api;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_transmit_api_CheckedChanged);
				if (this._Check_transmit_api != null)
				{
					this._Check_transmit_api.CheckedChanged -= eventHandler;
				}
				this._Check_transmit_api = value;
				if (this._Check_transmit_api != null)
				{
					this._Check_transmit_api.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x060023A3 RID: 9123 RVA: 0x00407DAC File Offset: 0x004061AC
		// (set) Token: 0x060023A4 RID: 9124 RVA: 0x00407DC0 File Offset: 0x004061C0
		internal virtual CheckBox Check_cmd_data_disable
		{
			get
			{
				return this._Check_cmd_data_disable;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_cmd_data_disable_CheckedChanged);
				if (this._Check_cmd_data_disable != null)
				{
					this._Check_cmd_data_disable.CheckedChanged -= eventHandler;
				}
				this._Check_cmd_data_disable = value;
				if (this._Check_cmd_data_disable != null)
				{
					this._Check_cmd_data_disable.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x060023A5 RID: 9125 RVA: 0x00407E0C File Offset: 0x0040620C
		// (set) Token: 0x060023A6 RID: 9126 RVA: 0x00407E20 File Offset: 0x00406220
		internal virtual CheckBox Check_485_modem_mode
		{
			get
			{
				return this._Check_485_modem_mode;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Check_485_modem_mode_CheckedChanged);
				if (this._Check_485_modem_mode != null)
				{
					this._Check_485_modem_mode.CheckedChanged -= eventHandler;
				}
				this._Check_485_modem_mode = value;
				if (this._Check_485_modem_mode != null)
				{
					this._Check_485_modem_mode.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x060023A7 RID: 9127 RVA: 0x00407E6C File Offset: 0x0040626C
		// (set) Token: 0x060023A8 RID: 9128 RVA: 0x00407E80 File Offset: 0x00406280
		internal virtual Button Button1
		{
			get
			{
				return this._Button1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= eventHandler;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += eventHandler;
				}
			}
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x00407ECC File Offset: 0x004062CC
		private void Ler_conf_md_590_Click(object sender, EventArgs e)
		{
			this.Controle_tecla_conf_590(2);
			if (this.Ler_conf_590())
			{
				this.Mensagem_MD590("Leitura executada com sucesso", 0);
				this.Atualiza_estrutura_MD590();
				this.Atualiza_tela_MD590();
				this.Grupo_parametros_comunicacao.Enabled = true;
				this.Grupo_parametros_radio.Enabled = true;
				this.Grupo_parametros_rf.Enabled = true;
				this.Grupo_modo_operacao.Enabled = true;
			}
			this.Controle_tecla_conf_590(1);
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x00407F38 File Offset: 0x00406338
		public bool Ler_conf_590()
		{
			this.Mensagem_MD590("Aguarde ...", 2);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Mod_MD.Comandos_gerais_590(1);
			this.Mensagem_MD590(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
			checked
			{
				bool result = false;
				if (!ctrl_RESP_.Status)
				{
					result = false;
				}
				else
				{
					int num = 0;
					for (;;)
					{
						int num2 = num * 64;
						ctrl_RESP_ = Mod_MD.Leitura_eeprom_590(num2, 64);
						this.Mensagem_MD590(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
						if (!ctrl_RESP_.Status)
						{
							break;
						}
						this.Atualiza_dados_MD590(num2, 64);
						num++;
						if (num > 3)
						{
							goto Block_3;
						}
					}
					return false;
					Block_3:
					ctrl_RESP_ = Mod_MD.Comandos_gerais_590(2);
					this.Mensagem_MD590(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
					result = ctrl_RESP_.Status;
				}
				return result;
			}
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x00407FE8 File Offset: 0x004063E8
		public void Controle_tecla_conf_590(int operacao)
		{
			switch (operacao)
			{
			case 1:
				this.Ler_conf_md_590.Enabled = true;
				this.Esc_conf_md_590.Enabled = true;
				break;
			case 2:
				this.Ler_conf_md_590.Enabled = false;
				this.Esc_conf_md_590.Enabled = false;
				break;
			}
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x0040803C File Offset: 0x0040643C
		public void Mensagem_MD590(string msg, int cor)
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

		// Token: 0x060023AD RID: 9133 RVA: 0x004080A0 File Offset: 0x004064A0
		public void Atualiza_dados_MD590(int end_inicial, int tamanho)
		{
			int num = 0;
			checked
			{
				int num2 = tamanho - 1;
				for (int i = num; i <= num2; i++)
				{
					Mod_MD.Tabela_590[i + end_inicial] = (int)Comunicacao.Buffer_resp[i + 3];
				}
			}
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x004080D0 File Offset: 0x004064D0
		public void Atualiza_tela_MD590()
		{
			this.Valor_Range_Refresh.Value = new decimal(Mod_MD.Parametros_590.RangeRefresh);
			this.Valor_Stop_Bit_Delay.Value = new decimal(Mod_MD.Parametros_590.StopBitDelay);
			this.Valor_RF_Channel_Number.Value = new decimal(Mod_MD.Parametros_590.RFChannelNumber);
			this.Combo_mode.SelectedIndex = checked(Mod_MD.Parametros_590.Mode - 1);
			int interfaceBaud = Mod_MD.Parametros_590.InterfaceBaud;
			if (interfaceBaud == 64)
			{
				this.Combo_baudrate.SelectedIndex = 0;
			}
			else if (interfaceBaud == 160)
			{
				this.Combo_baudrate.SelectedIndex = 1;
			}
			else if (interfaceBaud == 208)
			{
				this.Combo_baudrate.SelectedIndex = 2;
			}
			else if (interfaceBaud == 232)
			{
				this.Combo_baudrate.SelectedIndex = 3;
			}
			else if (interfaceBaud == 240)
			{
				this.Combo_baudrate.SelectedIndex = 4;
			}
			else if (interfaceBaud == 244)
			{
				this.Combo_baudrate.SelectedIndex = 5;
			}
			else if (interfaceBaud == 248)
			{
				this.Combo_baudrate.SelectedIndex = 6;
			}
			else if (interfaceBaud == 250)
			{
				this.Combo_baudrate.SelectedIndex = 7;
			}
			else if (interfaceBaud == 252)
			{
				this.Combo_baudrate.SelectedIndex = 8;
			}
			else if (interfaceBaud == 255)
			{
				this.Combo_baudrate.SelectedIndex = 9;
			}
			else
			{
				this.Combo_baudrate.SelectedIndex = 10;
			}
			this.Check_beacon_mode.Checked = Mod_MD.Bit_on(Mod_MD.Parametros_590.Control_0, 128);
			this.Check_des_enabled.Checked = Mod_MD.Bit_on(Mod_MD.Parametros_590.Control_0, 64);
			this.Check_sync_channel.Checked = Mod_MD.Bit_on(Mod_MD.Parametros_590.Control_0, 32);
			this.Check_broadcast_mode.Checked = Mod_MD.Bit_on(Mod_MD.Parametros_590.Control_0, 2);
			this.Valor_transmit_retries.Value = new decimal(Mod_MD.Parametros_590.TransmitRetries);
			this.Valor_Broadcast_Attempts.Value = new decimal(Mod_MD.Parametros_590.BroadcastAttempts);
			this.Check_unicast_only.Checked = Mod_MD.Bit_on(Mod_MD.Parametros_590.APIControl, 32);
			this.Check_auto_destination.Checked = Mod_MD.Bit_on(Mod_MD.Parametros_590.APIControl, 16);
			this.Check_auto_channel.Checked = Mod_MD.Bit_on(Mod_MD.Parametros_590.APIControl, 8);
			this.Check_rts_enable.Checked = Mod_MD.Bit_on(Mod_MD.Parametros_590.APIControl, 4);
			this.Check_full_duplex.Checked = Mod_MD.Bit_on(Mod_MD.Parametros_590.APIControl, 2);
			this.Check_auto_config.Checked = Mod_MD.Bit_on(Mod_MD.Parametros_590.APIControl, 1);
			this.Valor_interface_timeout.Value = new decimal(Mod_MD.Parametros_590.InterfaceTimeout);
			this.Valor_Sync_to_Channel.Value = new decimal(Mod_MD.Parametros_590.SyncToChannel);
			this.Valor_packed_size.Value = new decimal(Mod_MD.Parametros_590.RFPacketSize);
			this.Valor_cts_on.Value = new decimal(Mod_MD.Parametros_590.CTSOn);
			this.Valor_cts_on_hysteresis.Value = new decimal(Mod_MD.Parametros_590.CTSOnHysteresis);
			switch (Mod_MD.Parametros_590.MaxPower)
			{
			case 3:
				this.Combo_max_power.SelectedIndex = 0;
				goto IL_3BA;
			case 10:
				this.Combo_max_power.SelectedIndex = 1;
				goto IL_3BA;
			case 13:
				this.Combo_max_power.SelectedIndex = 2;
				goto IL_3BA;
			case 15:
				this.Combo_max_power.SelectedIndex = 3;
				goto IL_3BA;
							}
			this.Combo_max_power.SelectedIndex = 4;
			IL_3BA:
			int modemMode = Mod_MD.Parametros_590.ModemMode;
			if (modemMode == 227)
			{
				this.Check_modem_mode.Checked = true;
			}
			else if (modemMode == 255)
			{
				this.Check_modem_mode.Checked = false;
			}
			int parityMode = Mod_MD.Parametros_590.ParityMode;
			if (parityMode == 227)
			{
				this.Check_parity_mode.Checked = true;
			}
			else if (parityMode == 255)
			{
				this.Check_parity_mode.Checked = false;
			}
			int rs485DERE = Mod_MD.Parametros_590.RS485DERE;
			if (rs485DERE == 227)
			{
				this.Check_485dere.Checked = true;
			}
			else if (rs485DERE == 255)
			{
				this.Check_485dere.Checked = false;
			}
			this.Valor_dest_1.Text = Conversions.ToString(Mod_MD.Parametros_590.Destination_1);
			this.Valor_dest_2.Text = Conversions.ToString(Mod_MD.Parametros_590.Destination_2);
			this.Valor_dest_3.Text = Conversions.ToString(Mod_MD.Parametros_590.Destination_3);
			this.Valor_dest_4.Text = Conversions.ToString(Mod_MD.Parametros_590.Destination_4);
			this.Valor_dest_5.Text = Conversions.ToString(Mod_MD.Parametros_590.Destination_5);
			this.Valor_dest_6.Text = Conversions.ToString(Mod_MD.Parametros_590.Destination_6);
			this.Valor_System_ID.Value = new decimal(Mod_MD.Parametros_590.SystemID);
			int protocolStatus = Mod_MD.Parametros_590.ProtocolStatus;
			if (protocolStatus == 227)
			{
				this.Check_protocol_status.Checked = true;
			}
			else if (protocolStatus == 255)
			{
				this.Check_protocol_status.Checked = false;
			}
			int receiveAPI = Mod_MD.Parametros_590.ReceiveAPI;
			if (receiveAPI == 227)
			{
				this.Check_receive_api.Checked = true;
			}
			else if (receiveAPI == 255)
			{
				this.Check_receive_api.Checked = false;
			}
			this.Check_enhanced_api_enabled.Checked = !Mod_MD.Bit_on(Mod_MD.Parametros_590.EnhancedAPIControl, 128);
			this.Check_send_data_complete.Checked = Mod_MD.Bit_on(Mod_MD.Parametros_590.EnhancedAPIControl, 4);
			this.Check_transmit_api.Checked = Mod_MD.Bit_on(Mod_MD.Parametros_590.EnhancedAPIControl, 2);
			this.Check_enhanced_receive_api.Checked = Mod_MD.Bit_on(Mod_MD.Parametros_590.EnhancedAPIControl, 1);
			this.Valor_desK_1.Text = Conversions.ToString(Mod_MD.Parametros_590.DesKey_1);
			this.Valor_desK_2.Text = Conversions.ToString(Mod_MD.Parametros_590.DesKey_2);
			this.Valor_desK_3.Text = Conversions.ToString(Mod_MD.Parametros_590.DesKey_3);
			this.Valor_desK_4.Text = Conversions.ToString(Mod_MD.Parametros_590.DesKey_4);
			this.Valor_desK_5.Text = Conversions.ToString(Mod_MD.Parametros_590.DesKey_5);
			this.Valor_desK_6.Text = Conversions.ToString(Mod_MD.Parametros_590.DesKey_6);
			this.Valor_desK_7.Text = Conversions.ToString(Mod_MD.Parametros_590.DesKey_7);
			this.Valor_firmware.Text = Mod_MD.Parametros_590.FirmwareVersion;
			this.Valor_mac_adress.Text = Mod_MD.Parametros_590.MacAddress;
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x004087B4 File Offset: 0x00406BB4
		public void Atualiza_tela_MD590_antigo_8888888888888888888888()
		{
			this.Valor_Range_Refresh.Value = new decimal(Mod_MD.Tabela_590[61]);
			this.Valor_Stop_Bit_Delay.Value = new decimal(Mod_MD.Tabela_590[63]);
			this.Valor_RF_Channel_Number.Value = new decimal(Mod_MD.Tabela_590[64]);
			checked
			{
				this.Combo_mode.SelectedIndex = Mod_MD.Tabela_590[65] - 1;
				int num = Mod_MD.Tabela_590[66];
				if (num == 64)
				{
					this.Combo_baudrate.SelectedIndex = 0;
				}
				else if (num == 160)
				{
					this.Combo_baudrate.SelectedIndex = 1;
				}
				else if (num == 208)
				{
					this.Combo_baudrate.SelectedIndex = 2;
				}
				else if (num == 232)
				{
					this.Combo_baudrate.SelectedIndex = 3;
				}
				else if (num == 240)
				{
					this.Combo_baudrate.SelectedIndex = 4;
				}
				else if (num == 244)
				{
					this.Combo_baudrate.SelectedIndex = 5;
				}
				else if (num == 248)
				{
					this.Combo_baudrate.SelectedIndex = 6;
				}
				else if (num == 250)
				{
					this.Combo_baudrate.SelectedIndex = 7;
				}
				else if (num == 252)
				{
					this.Combo_baudrate.SelectedIndex = 8;
				}
				else if (num == 255)
				{
					this.Combo_baudrate.SelectedIndex = 9;
				}
				else
				{
					this.Combo_baudrate.SelectedIndex = 10;
				}
				this.Check_beacon_mode.Checked = Mod_MD.Bit_on(Mod_MD.Tabela_590[69], 128);
				this.Check_des_enabled.Checked = Mod_MD.Bit_on(Mod_MD.Tabela_590[69], 64);
				this.Check_sync_channel.Checked = Mod_MD.Bit_on(Mod_MD.Tabela_590[69], 32);
				this.Check_broadcast_mode.Checked = Mod_MD.Bit_on(Mod_MD.Tabela_590[69], 2);
				this.Valor_transmit_retries.Value = new decimal(Mod_MD.Tabela_590[76]);
				this.Valor_Broadcast_Attempts.Value = new decimal(Mod_MD.Tabela_590[77]);
				this.Check_unicast_only.Checked = Mod_MD.Bit_on(Mod_MD.Tabela_590[86], 32);
				this.Check_auto_destination.Checked = Mod_MD.Bit_on(Mod_MD.Tabela_590[86], 16);
				this.Check_auto_channel.Checked = Mod_MD.Bit_on(Mod_MD.Tabela_590[86], 8);
				this.Check_rts_enable.Checked = Mod_MD.Bit_on(Mod_MD.Tabela_590[86], 4);
				this.Check_full_duplex.Checked = Mod_MD.Bit_on(Mod_MD.Tabela_590[86], 2);
				this.Check_auto_config.Checked = Mod_MD.Bit_on(Mod_MD.Tabela_590[86], 1);
				this.Valor_interface_timeout.Value = new decimal(Mod_MD.Tabela_590[88]);
				this.Valor_Sync_to_Channel.Value = new decimal(Mod_MD.Tabela_590[90]);
				this.Valor_packed_size.Value = new decimal(Mod_MD.Tabela_590[91]);
				this.Valor_cts_on.Value = new decimal(Mod_MD.Tabela_590[92]);
				this.Valor_cts_on_hysteresis.Value = new decimal(Mod_MD.Tabela_590[93]);
				switch (Mod_MD.Tabela_590[99])
				{
				case 3:
					this.Combo_max_power.SelectedIndex = 0;
					goto IL_38C;
				case 10:
					this.Combo_max_power.SelectedIndex = 1;
					goto IL_38C;
				case 13:
					this.Combo_max_power.SelectedIndex = 2;
					goto IL_38C;
				case 15:
					this.Combo_max_power.SelectedIndex = 3;
					goto IL_38C;
									}
				this.Combo_max_power.SelectedIndex = 4;
				IL_38C:
				int num2 = Mod_MD.Tabela_590[110];
				if (num2 == 227)
				{
					this.Check_modem_mode.Checked = true;
				}
				else if (num2 == 255)
				{
					this.Check_modem_mode.Checked = false;
				}
				int num3 = Mod_MD.Tabela_590[111];
				if (num3 == 227)
				{
					this.Check_parity_mode.Checked = true;
				}
				else if (num3 == 255)
				{
					this.Check_parity_mode.Checked = false;
				}
				int num4 = Mod_MD.Tabela_590[127];
				if (num4 == 227)
				{
					this.Check_485dere.Checked = true;
				}
				else if (num4 == 255)
				{
					this.Check_485dere.Checked = false;
				}
				this.Valor_dest_1.Text = Conversions.ToString(Mod_MD.Tabela_590[112]);
				this.Valor_dest_2.Text = Conversions.ToString(Mod_MD.Tabela_590[113]);
				this.Valor_dest_3.Text = Conversions.ToString(Mod_MD.Tabela_590[114]);
				this.Valor_dest_4.Text = Conversions.ToString(Mod_MD.Tabela_590[115]);
				this.Valor_dest_5.Text = Conversions.ToString(Mod_MD.Tabela_590[116]);
				this.Valor_dest_6.Text = Conversions.ToString(Mod_MD.Tabela_590[117]);
				this.Valor_System_ID.Value = new decimal(Mod_MD.Tabela_590[118]);
				string text = "";
				int num5 = 0;
				do
				{
					text = text + Conversion.Str(Mod_MD.Tabela_590[128 + num5]) + " ";
					num5++;
				}
				while (num5 <= 5);
				this.Valor_mac_adress.Text = text;
				int num6 = Mod_MD.Tabela_590[192];
				if (num6 == 227)
				{
					this.Check_protocol_status.Checked = true;
				}
				else if (num6 == 255)
				{
					this.Check_protocol_status.Checked = false;
				}
				int num7 = Mod_MD.Tabela_590[193];
				if (num7 == 227)
				{
					this.Check_receive_api.Checked = true;
				}
				else if (num7 == 255)
				{
					this.Check_receive_api.Checked = false;
				}
				this.Check_enhanced_api_enabled.Checked = !Mod_MD.Bit_on(Mod_MD.Tabela_590[198], 128);
				this.Check_send_data_complete.Checked = Mod_MD.Bit_on(Mod_MD.Tabela_590[198], 4);
				this.Check_transmit_api.Checked = Mod_MD.Bit_on(Mod_MD.Tabela_590[198], 2);
				this.Check_enhanced_receive_api.Checked = Mod_MD.Bit_on(Mod_MD.Tabela_590[198], 1);
				this.Valor_desK_1.Text = Conversions.ToString(Mod_MD.Tabela_590[208]);
				this.Valor_desK_2.Text = Conversions.ToString(Mod_MD.Tabela_590[209]);
				this.Valor_desK_3.Text = Conversions.ToString(Mod_MD.Tabela_590[210]);
				this.Valor_desK_4.Text = Conversions.ToString(Mod_MD.Tabela_590[211]);
				this.Valor_desK_5.Text = Conversions.ToString(Mod_MD.Tabela_590[212]);
				this.Valor_desK_6.Text = Conversions.ToString(Mod_MD.Tabela_590[213]);
				this.Valor_desK_7.Text = Conversions.ToString(Mod_MD.Tabela_590[214]);
				Mod_MD.CTRL_PESQ_1 ctrl_PESQ_ = Mod_MD.Retira_texto(Mod_MD.Retira_texto(0, ref Mod_MD.Tabela_590, 13, 25).Pxm_end, ref Mod_MD.Tabela_590, 13, 25);
				this.Valor_firmware.Text = Mod_MD.Retira_texto(ctrl_PESQ_.Pxm_end, ref Mod_MD.Tabela_590, 13, 25).Msg;
			}
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00408ECC File Offset: 0x004072CC
		public void Atualiza_estrutura_MD590()
		{
			Mod_MD.Parametros_590.RangeRefresh = Mod_MD.Tabela_590[61];
			Mod_MD.Parametros_590.StopBitDelay = Mod_MD.Tabela_590[63];
			Mod_MD.Parametros_590.RFChannelNumber = Mod_MD.Tabela_590[64];
			Mod_MD.Parametros_590.Mode = Mod_MD.Tabela_590[65];
			Mod_MD.Parametros_590.InterfaceBaud = Mod_MD.Tabela_590[66];
			Mod_MD.Parametros_590.Control_0 = Mod_MD.Tabela_590[69];
			Mod_MD.Parametros_590.TransmitRetries = Mod_MD.Tabela_590[76];
			Mod_MD.Parametros_590.BroadcastAttempts = Mod_MD.Tabela_590[77];
			Mod_MD.Parametros_590.APIControl = Mod_MD.Tabela_590[86];
			Mod_MD.Parametros_590.InterfaceTimeout = Mod_MD.Tabela_590[88];
			Mod_MD.Parametros_590.SyncToChannel = Mod_MD.Tabela_590[90];
			Mod_MD.Parametros_590.RFPacketSize = Mod_MD.Tabela_590[91];
			Mod_MD.Parametros_590.CTSOn = Mod_MD.Tabela_590[92];
			Mod_MD.Parametros_590.CTSOnHysteresis = Mod_MD.Tabela_590[93];
			Mod_MD.Parametros_590.MaxPower = Mod_MD.Tabela_590[99];
			Mod_MD.Parametros_590.ModemMode = Mod_MD.Tabela_590[110];
			Mod_MD.Parametros_590.ParityMode = Mod_MD.Tabela_590[111];
			Mod_MD.Parametros_590.RS485DERE = Mod_MD.Tabela_590[127];
			Mod_MD.Parametros_590.Destination_1 = Mod_MD.Tabela_590[112];
			Mod_MD.Parametros_590.Destination_2 = Mod_MD.Tabela_590[113];
			Mod_MD.Parametros_590.Destination_3 = Mod_MD.Tabela_590[114];
			Mod_MD.Parametros_590.Destination_4 = Mod_MD.Tabela_590[115];
			Mod_MD.Parametros_590.Destination_5 = Mod_MD.Tabela_590[116];
			Mod_MD.Parametros_590.Destination_6 = Mod_MD.Tabela_590[117];
			Mod_MD.Parametros_590.SystemID = Mod_MD.Tabela_590[118];
			string text = "";
			int num = 0;
			checked
			{
				do
				{
					text = text + Conversion.Str(Mod_MD.Tabela_590[128 + num]) + " ";
					num++;
				}
				while (num <= 5);
				Mod_MD.Parametros_590.MacAddress = text;
				Mod_MD.Parametros_590.ProtocolStatus = Mod_MD.Tabela_590[192];
				Mod_MD.Parametros_590.ReceiveAPI = Mod_MD.Tabela_590[193];
				Mod_MD.Parametros_590.EnhancedAPIControl = Mod_MD.Tabela_590[198];
				Mod_MD.Parametros_590.DesKey_1 = Mod_MD.Tabela_590[208];
				Mod_MD.Parametros_590.DesKey_2 = Mod_MD.Tabela_590[209];
				Mod_MD.Parametros_590.DesKey_3 = Mod_MD.Tabela_590[210];
				Mod_MD.Parametros_590.DesKey_4 = Mod_MD.Tabela_590[211];
				Mod_MD.Parametros_590.DesKey_5 = Mod_MD.Tabela_590[212];
				Mod_MD.Parametros_590.DesKey_6 = Mod_MD.Tabela_590[213];
				Mod_MD.Parametros_590.DesKey_7 = Mod_MD.Tabela_590[214];
				Mod_MD.Parametros_590.FirmwareVersion = Mod_MD.Retira_texto(Mod_MD.Retira_texto(Mod_MD.Retira_texto(0, ref Mod_MD.Tabela_590, 13, 25).Pxm_end, ref Mod_MD.Tabela_590, 13, 25).Pxm_end, ref Mod_MD.Tabela_590, 13, 25).Msg;
			}
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x004091F8 File Offset: 0x004075F8
		private void Equip_590_conf_Load(object sender, EventArgs e)
		{
			this.Combo_mode.Items.Clear();
			this.Combo_mode.Items.Add("Server");
			this.Combo_mode.Items.Add("Client");
			this.Combo_max_power.Items.Clear();
			this.Combo_max_power.Items.Add("Low Power - 1 mW");
			this.Combo_max_power.Items.Add("Quarter Power - 25 mW");
			this.Combo_max_power.Items.Add("Half Power - 50 mW");
			this.Combo_max_power.Items.Add("Full Power");
			this.Combo_max_power.Items.Add("Indefinido");
			this.Combo_baudrate.Items.Clear();
			this.Combo_baudrate.Items.Add("1200");
			this.Combo_baudrate.Items.Add("2400");
			this.Combo_baudrate.Items.Add("4800");
			this.Combo_baudrate.Items.Add("9600");
			this.Combo_baudrate.Items.Add("14400");
			this.Combo_baudrate.Items.Add("19200");
			this.Combo_baudrate.Items.Add("28800");
			this.Combo_baudrate.Items.Add("38400");
			this.Combo_baudrate.Items.Add("57600");
			this.Combo_baudrate.Items.Add("115200");
			this.Combo_baudrate.Items.Add(" -----");
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x004093C4 File Offset: 0x004077C4
		private void Valor_interface_timeout_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.InterfaceTimeout = 0;
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x004093EC File Offset: 0x004077EC
		private void Valor_packed_size_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.RFPacketSize = 0;
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x00409414 File Offset: 0x00407814
		private void Valor_cts_on_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.CTSOn = 0;
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x0040943C File Offset: 0x0040783C
		private void Valor_cts_on_hysteresis_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.CTSOnHysteresis = 0;
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x00409464 File Offset: 0x00407864
		private void Valor_transmit_retries_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.TransmitRetries = 0;
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x0040948C File Offset: 0x0040788C
		private void Valor_Broadcast_Attempts_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.BroadcastAttempts = 0;
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x004094B4 File Offset: 0x004078B4
		private void Valor_Stop_Bit_Delay_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.StopBitDelay = 0;
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x004094DC File Offset: 0x004078DC
		private void Valor_Range_Refresh_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.RangeRefresh = 0;
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x00409504 File Offset: 0x00407904
		private void Combo_mode_SelectedIndexChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.ModemMode = Conversions.ToInteger(Operators.AddObject(null, 1));
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x00409538 File Offset: 0x00407938
		private void Valor_RF_Channel_Number_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.RFChannelNumber = 0;
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x00409560 File Offset: 0x00407960
		private void Valor_Sync_to_Channel_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.SyncToChannel = 0;
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x00409588 File Offset: 0x00407988
		private void Combo_max_power_SelectedIndexChanged(object sender, EventArgs e)
		{
			object obj = null;
			if (Operators.ConditionalCompareObjectEqual(obj, 3, false))
			{
				Mod_MD.Parametros_590.MaxPower = 15;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 2, false))
			{
				Mod_MD.Parametros_590.MaxPower = 13;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 1, false))
			{
				Mod_MD.Parametros_590.MaxPower = 10;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 0, false))
			{
				Mod_MD.Parametros_590.MaxPower = 3;
			}
			else
			{
				Mod_MD.Parametros_590.MaxPower = 96;
			}
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x0040962C File Offset: 0x00407A2C
		private void Valor_System_ID_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.SystemID = 0;
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x00409654 File Offset: 0x00407A54
		private void Combo_baudrate_SelectedIndexChanged(object sender, EventArgs e)
		{
			object obj = null;
			if (Operators.ConditionalCompareObjectEqual(obj, 0, false))
			{
				Mod_MD.Parametros_590.InterfaceBaud = 64;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 1, false))
			{
				Mod_MD.Parametros_590.InterfaceBaud = 160;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 2, false))
			{
				Mod_MD.Parametros_590.InterfaceBaud = 208;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 3, false))
			{
				Mod_MD.Parametros_590.InterfaceBaud = 232;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 4, false))
			{
				Mod_MD.Parametros_590.InterfaceBaud = 240;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 5, false))
			{
				Mod_MD.Parametros_590.InterfaceBaud = 244;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 6, false))
			{
				Mod_MD.Parametros_590.InterfaceBaud = 248;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 7, false))
			{
				Mod_MD.Parametros_590.InterfaceBaud = 250;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 8, false))
			{
				Mod_MD.Parametros_590.InterfaceBaud = 252;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 9, false))
			{
				Mod_MD.Parametros_590.InterfaceBaud = 255;
			}
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x004097C4 File Offset: 0x00407BC4
		private void Valor_dest_1_TextChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.Destination_1 = Conversions.ToInteger(((TextBox)sender).Text);
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x004097E0 File Offset: 0x00407BE0
		private void Valor_dest_2_TextChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.Destination_2 = Conversions.ToInteger(((TextBox)sender).Text);
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x004097FC File Offset: 0x00407BFC
		private void Valor_dest_3_TextChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.Destination_3 = Conversions.ToInteger(((TextBox)sender).Text);
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x00409818 File Offset: 0x00407C18
		private void Valor_dest_4_TextChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.Destination_4 = Conversions.ToInteger(((TextBox)sender).Text);
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x00409834 File Offset: 0x00407C34
		private void Valor_dest_5_TextChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.Destination_5 = Conversions.ToInteger(((TextBox)sender).Text);
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x00409850 File Offset: 0x00407C50
		private void Valor_dest_6_TextChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.Destination_6 = Conversions.ToInteger(((TextBox)sender).Text);
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x0040986C File Offset: 0x00407C6C
		private void Valor_desK_1_TextChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.DesKey_1 = Conversions.ToInteger(((TextBox)sender).Text);
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x00409888 File Offset: 0x00407C88
		private void Valor_desK_2_TextChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.DesKey_2 = Conversions.ToInteger(((TextBox)sender).Text);
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x004098A4 File Offset: 0x00407CA4
		private void Valor_desK_3_TextChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.DesKey_3 = Conversions.ToInteger(((TextBox)sender).Text);
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x004098C0 File Offset: 0x00407CC0
		private void Valor_desK_4_TextChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.DesKey_4 = Conversions.ToInteger(((TextBox)sender).Text);
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x004098DC File Offset: 0x00407CDC
		private void Valor_desK_5_TextChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.DesKey_5 = Conversions.ToInteger(((TextBox)sender).Text);
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x004098F8 File Offset: 0x00407CF8
		private void Valor_desK_6_TextChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.DesKey_6 = Conversions.ToInteger(((TextBox)sender).Text);
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x00409914 File Offset: 0x00407D14
		private void Valor_desK_7_TextChanged(object sender, EventArgs e)
		{
			Mod_MD.Parametros_590.DesKey_7 = Conversions.ToInteger(((TextBox)sender).Text);
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x00409930 File Offset: 0x00407D30
		private void Check_auto_config_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
			}
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x00409958 File Offset: 0x00407D58
		private void Check_full_duplex_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
			}
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x00409980 File Offset: 0x00407D80
		private void Check_des_enabled_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
			}
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x004099A8 File Offset: 0x00407DA8
		private void Check_auto_destination_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
			}
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x004099D0 File Offset: 0x00407DD0
		private void Check_broadcast_mode_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
			}
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x004099F8 File Offset: 0x00407DF8
		private void Check_unicast_only_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
			}
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x00409A20 File Offset: 0x00407E20
		private void Check_auto_channel_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
			}
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x00409A48 File Offset: 0x00407E48
		private void Check_sync_channel_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
				Mod_MD.Parametros_590.SyncToChannel = -1;
			}
			else
			{
				Mod_MD.Parametros_590.SyncToChannel = 0;
			}
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x00409A88 File Offset: 0x00407E88
		private void Check_beacon_mode_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
			}
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x00409AB0 File Offset: 0x00407EB0
		private void Check_rts_enable_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
			}
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x00409AD8 File Offset: 0x00407ED8
		private void Check_modem_mode_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
				Mod_MD.Parametros_590.ModemMode = 227;
			}
			else
			{
				Mod_MD.Parametros_590.ModemMode = 255;
			}
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x00409B28 File Offset: 0x00407F28
		private void Check_485dere_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
				Mod_MD.Parametros_590.RS485DERE = 227;
			}
			else
			{
				Mod_MD.Parametros_590.RS485DERE = 255;
			}
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x00409B78 File Offset: 0x00407F78
		private void Check_protocol_status_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
				Mod_MD.Parametros_590.ProtocolStatus = 227;
			}
			else
			{
				Mod_MD.Parametros_590.ProtocolStatus = 255;
			}
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x00409BC8 File Offset: 0x00407FC8
		private void Check_parity_mode_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
				Mod_MD.Parametros_590.ParityMode = 227;
			}
			else
			{
				Mod_MD.Parametros_590.ParityMode = 255;
			}
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x00409C18 File Offset: 0x00408018
		private void Check_receive_api_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
				Mod_MD.Parametros_590.ReceiveAPI = 227;
			}
			else
			{
				Mod_MD.Parametros_590.ReceiveAPI = 255;
			}
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x00409C68 File Offset: 0x00408068
		private void Check_enhanced_api_enabled_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
			}
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x00409C90 File Offset: 0x00408090
		private void Check_transmit_api_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
			}
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x00409CB8 File Offset: 0x004080B8
		private void Check_enhanced_receive_api_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
			}
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x00409CE0 File Offset: 0x004080E0
		private void Check_send_data_complete_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
			}
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x00409D08 File Offset: 0x00408108
		private void Check_auto_calibrate_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
			}
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x00409D30 File Offset: 0x00408130
		private void Check_485_modem_mode_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
			}
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x00409D58 File Offset: 0x00408158
		private void Check_cmd_data_disable_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, true, false))
			{
			}
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x00409D80 File Offset: 0x00408180
		private void Esc_conf_md_590_Click(object sender, EventArgs e)
		{
			this.Controle_tecla_conf_590(2);
			if (this.Ler_conf_590())
			{
				this.Mensagem_MD590("Leitura executada com sucesso", 0);
				this.Atualiza_Estrutura_Dados();
			}
			else
			{
				this.Mensagem_MD590("Erro ao ler rádio", 0);
			}
			this.Controle_tecla_conf_590(1);
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x00409DB8 File Offset: 0x004081B8
		public void Atualiza_Estrutura_Dados()
		{
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x00409DBC File Offset: 0x004081BC
		private void Button1_Click(object sender, EventArgs e)
		{
			int num = 0;
			int endereco = 255;
			int tamanho = 10;
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			Mod_MD.CTRL_RESP_1 ctrl_RESP_;
			ctrl_RESP_.Msg = "";
			ctrl_RESP_.Status = false;
			ctrl_RESP_.Cor = 1;
			checked
			{
				while (i > 0)
				{
					i--;
					Comunicacao.CMD_Le_Pagina(num, endereco, tamanho);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						ctrl_RESP_.Msg = "Leitura página " + Conversion.Str(num / 256) + " - OK";
						ctrl_RESP_.Cor = 0;
						ctrl_RESP_.Status = true;
						goto IL_178;
					case 2:
						if (i == 0)
						{
							ctrl_RESP_.Msg = "Erro chksum - ao ler página " + Conversion.Str(num / 256);
							ctrl_RESP_.Cor = 1;
							ctrl_RESP_.Status = false;
													}
						continue;
					case 3:
						if (i == 0)
						{
							ctrl_RESP_.Msg = "Erro Timeout - ao ler página " + Conversion.Str(num / 256);
							ctrl_RESP_.Cor = 1;
							ctrl_RESP_.Status = false;
													}
						continue;
					}
					if (i == 0)
					{
						ctrl_RESP_.Msg = "Erro indeterminado - ao ler página " + Conversion.Str(num / 256);
						ctrl_RESP_.Cor = 1;
						ctrl_RESP_.Status = false;
						break;
					}
				}
				IL_178:
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
				Comunicacao.Rotina_Delay(300L);
			}
		}

		// Token: 0x04001840 RID: 6208
		[AccessedThroughProperty("Grupo_comandos")]
		private GroupBox _Grupo_comandos;

		// Token: 0x04001841 RID: 6209
		[AccessedThroughProperty("Esc_conf_md_590")]
		private Button _Esc_conf_md_590;

		// Token: 0x04001842 RID: 6210
		[AccessedThroughProperty("Box_Msg")]
		private TextBox _Box_Msg;

		// Token: 0x04001843 RID: 6211
		[AccessedThroughProperty("Ler_conf_md_590")]
		private Button _Ler_conf_md_590;

		// Token: 0x04001844 RID: 6212
		[AccessedThroughProperty("Grupo_parametros_radio")]
		private GroupBox _Grupo_parametros_radio;

		// Token: 0x04001845 RID: 6213
		[AccessedThroughProperty("Grupo_parametros_rf")]
		private GroupBox _Grupo_parametros_rf;

		// Token: 0x04001846 RID: 6214
		[AccessedThroughProperty("Grupo_parametros_comunicacao")]
		private GroupBox _Grupo_parametros_comunicacao;

		// Token: 0x04001847 RID: 6215
		[AccessedThroughProperty("Grupo_modo_operacao")]
		private GroupBox _Grupo_modo_operacao;

		// Token: 0x04001848 RID: 6216
		[AccessedThroughProperty("Valor_interface_timeout")]
		private NumericUpDown _Valor_interface_timeout;

		// Token: 0x04001849 RID: 6217
		[AccessedThroughProperty("Label_interface_timeout")]
		private Label _Label_interface_timeout;

		// Token: 0x0400184A RID: 6218
		[AccessedThroughProperty("Valor_packed_size")]
		private NumericUpDown _Valor_packed_size;

		// Token: 0x0400184B RID: 6219
		[AccessedThroughProperty("Label_rf_packed_size")]
		private Label _Label_rf_packed_size;

		// Token: 0x0400184C RID: 6220
		[AccessedThroughProperty("Valor_cts_on")]
		private NumericUpDown _Valor_cts_on;

		// Token: 0x0400184D RID: 6221
		[AccessedThroughProperty("Label_cts_on_hysteresis")]
		private Label _Label_cts_on_hysteresis;

		// Token: 0x0400184E RID: 6222
		[AccessedThroughProperty("Label_cts_on")]
		private Label _Label_cts_on;

		// Token: 0x0400184F RID: 6223
		[AccessedThroughProperty("Valor_cts_on_hysteresis")]
		private NumericUpDown _Valor_cts_on_hysteresis;

		// Token: 0x04001850 RID: 6224
		[AccessedThroughProperty("Valor_transmit_retries")]
		private NumericUpDown _Valor_transmit_retries;

		// Token: 0x04001851 RID: 6225
		[AccessedThroughProperty("Label_transmit_retries")]
		private Label _Label_transmit_retries;

		// Token: 0x04001852 RID: 6226
		[AccessedThroughProperty("Valor_Broadcast_Attempts")]
		private NumericUpDown _Valor_Broadcast_Attempts;

		// Token: 0x04001853 RID: 6227
		[AccessedThroughProperty("Label_Broadcast_Attempts")]
		private Label _Label_Broadcast_Attempts;

		// Token: 0x04001854 RID: 6228
		[AccessedThroughProperty("Valor_Range_Refresh")]
		private NumericUpDown _Valor_Range_Refresh;

		// Token: 0x04001855 RID: 6229
		[AccessedThroughProperty("Valor_Stop_Bit_Delay")]
		private NumericUpDown _Valor_Stop_Bit_Delay;

		// Token: 0x04001856 RID: 6230
		[AccessedThroughProperty("Label_Range_Refresh")]
		private Label _Label_Range_Refresh;

		// Token: 0x04001857 RID: 6231
		[AccessedThroughProperty("Label_Stop_Bit_Delay")]
		private Label _Label_Stop_Bit_Delay;

		// Token: 0x04001858 RID: 6232
		[AccessedThroughProperty("Combo_mode")]
		private ComboBox _Combo_mode;

		// Token: 0x04001859 RID: 6233
		[AccessedThroughProperty("Label_mode")]
		private Label _Label_mode;

		// Token: 0x0400185A RID: 6234
		[AccessedThroughProperty("Valor_Sync_to_Channel")]
		private NumericUpDown _Valor_Sync_to_Channel;

		// Token: 0x0400185B RID: 6235
		[AccessedThroughProperty("Label_Sync_to_Channel")]
		private Label _Label_Sync_to_Channel;

		// Token: 0x0400185C RID: 6236
		[AccessedThroughProperty("Valor_RF_Channel_Number")]
		private NumericUpDown _Valor_RF_Channel_Number;

		// Token: 0x0400185D RID: 6237
		[AccessedThroughProperty("Label_RF_Channel_Number")]
		private Label _Label_RF_Channel_Number;

		// Token: 0x0400185E RID: 6238
		[AccessedThroughProperty("Valor_System_ID")]
		private NumericUpDown _Valor_System_ID;

		// Token: 0x0400185F RID: 6239
		[AccessedThroughProperty("Label_System_ID")]
		private Label _Label_System_ID;

		// Token: 0x04001860 RID: 6240
		[AccessedThroughProperty("Combo_max_power")]
		private ComboBox _Combo_max_power;

		// Token: 0x04001861 RID: 6241
		[AccessedThroughProperty("Label_max_power")]
		private Label _Label_max_power;

		// Token: 0x04001862 RID: 6242
		[AccessedThroughProperty("Combo_baudrate")]
		private ComboBox _Combo_baudrate;

		// Token: 0x04001863 RID: 6243
		[AccessedThroughProperty("Label_baudrate")]
		private Label _Label_baudrate;

		// Token: 0x04001864 RID: 6244
		[AccessedThroughProperty("Valor_dest_4")]
		private TextBox _Valor_dest_4;

		// Token: 0x04001865 RID: 6245
		[AccessedThroughProperty("Valor_dest_3")]
		private TextBox _Valor_dest_3;

		// Token: 0x04001866 RID: 6246
		[AccessedThroughProperty("Valor_dest_2")]
		private TextBox _Valor_dest_2;

		// Token: 0x04001867 RID: 6247
		[AccessedThroughProperty("Valor_dest_1")]
		private TextBox _Valor_dest_1;

		// Token: 0x04001868 RID: 6248
		[AccessedThroughProperty("Label_destination")]
		private Label _Label_destination;

		// Token: 0x04001869 RID: 6249
		[AccessedThroughProperty("Valor_dest_5")]
		private TextBox _Valor_dest_5;

		// Token: 0x0400186A RID: 6250
		[AccessedThroughProperty("Valor_desK_5")]
		private TextBox _Valor_desK_5;

		// Token: 0x0400186B RID: 6251
		[AccessedThroughProperty("Valor_desK_6")]
		private TextBox _Valor_desK_6;

		// Token: 0x0400186C RID: 6252
		[AccessedThroughProperty("Valor_desK_4")]
		private TextBox _Valor_desK_4;

		// Token: 0x0400186D RID: 6253
		[AccessedThroughProperty("Valor_desK_3")]
		private TextBox _Valor_desK_3;

		// Token: 0x0400186E RID: 6254
		[AccessedThroughProperty("Valor_desK_2")]
		private TextBox _Valor_desK_2;

		// Token: 0x0400186F RID: 6255
		[AccessedThroughProperty("Valor_desK_1")]
		private TextBox _Valor_desK_1;

		// Token: 0x04001870 RID: 6256
		[AccessedThroughProperty("Label_des_key")]
		private Label _Label_des_key;

		// Token: 0x04001871 RID: 6257
		[AccessedThroughProperty("Valor_dest_6")]
		private TextBox _Valor_dest_6;

		// Token: 0x04001872 RID: 6258
		[AccessedThroughProperty("Label_mac_adress")]
		private Label _Label_mac_adress;

		// Token: 0x04001873 RID: 6259
		[AccessedThroughProperty("Valor_mac_adress")]
		private TextBox _Valor_mac_adress;

		// Token: 0x04001874 RID: 6260
		[AccessedThroughProperty("Valor_desK_7")]
		private TextBox _Valor_desK_7;

		// Token: 0x04001875 RID: 6261
		[AccessedThroughProperty("Valor_firmware")]
		private TextBox _Valor_firmware;

		// Token: 0x04001876 RID: 6262
		[AccessedThroughProperty("Label_firmware")]
		private Label _Label_firmware;

		// Token: 0x04001877 RID: 6263
		[AccessedThroughProperty("Check_auto_destination")]
		private CheckBox _Check_auto_destination;

		// Token: 0x04001878 RID: 6264
		[AccessedThroughProperty("Check_des_enabled")]
		private CheckBox _Check_des_enabled;

		// Token: 0x04001879 RID: 6265
		[AccessedThroughProperty("Check_full_duplex")]
		private CheckBox _Check_full_duplex;

		// Token: 0x0400187A RID: 6266
		[AccessedThroughProperty("Check_auto_config")]
		private CheckBox _Check_auto_config;

		// Token: 0x0400187B RID: 6267
		[AccessedThroughProperty("Check_sync_channel")]
		private CheckBox _Check_sync_channel;

		// Token: 0x0400187C RID: 6268
		[AccessedThroughProperty("Check_auto_channel")]
		private CheckBox _Check_auto_channel;

		// Token: 0x0400187D RID: 6269
		[AccessedThroughProperty("Check_unicast_only")]
		private CheckBox _Check_unicast_only;

		// Token: 0x0400187E RID: 6270
		[AccessedThroughProperty("Check_broadcast_mode")]
		private CheckBox _Check_broadcast_mode;

		// Token: 0x0400187F RID: 6271
		[AccessedThroughProperty("Check_parity_mode")]
		private CheckBox _Check_parity_mode;

		// Token: 0x04001880 RID: 6272
		[AccessedThroughProperty("Check_protocol_status")]
		private CheckBox _Check_protocol_status;

		// Token: 0x04001881 RID: 6273
		[AccessedThroughProperty("Check_485dere")]
		private CheckBox _Check_485dere;

		// Token: 0x04001882 RID: 6274
		[AccessedThroughProperty("Check_modem_mode")]
		private CheckBox _Check_modem_mode;

		// Token: 0x04001883 RID: 6275
		[AccessedThroughProperty("Check_rts_enable")]
		private CheckBox _Check_rts_enable;

		// Token: 0x04001884 RID: 6276
		[AccessedThroughProperty("Check_beacon_mode")]
		private CheckBox _Check_beacon_mode;

		// Token: 0x04001885 RID: 6277
		[AccessedThroughProperty("Check_enhanced_api_enabled")]
		private CheckBox _Check_enhanced_api_enabled;

		// Token: 0x04001886 RID: 6278
		[AccessedThroughProperty("Check_receive_api")]
		private CheckBox _Check_receive_api;

		// Token: 0x04001887 RID: 6279
		[AccessedThroughProperty("Check_auto_calibrate")]
		private CheckBox _Check_auto_calibrate;

		// Token: 0x04001888 RID: 6280
		[AccessedThroughProperty("Check_send_data_complete")]
		private CheckBox _Check_send_data_complete;

		// Token: 0x04001889 RID: 6281
		[AccessedThroughProperty("Check_enhanced_receive_api")]
		private CheckBox _Check_enhanced_receive_api;

		// Token: 0x0400188A RID: 6282
		[AccessedThroughProperty("Check_transmit_api")]
		private CheckBox _Check_transmit_api;

		// Token: 0x0400188B RID: 6283
		[AccessedThroughProperty("Check_cmd_data_disable")]
		private CheckBox _Check_cmd_data_disable;

		// Token: 0x0400188C RID: 6284
		[AccessedThroughProperty("Check_485_modem_mode")]
		private CheckBox _Check_485_modem_mode;

		// Token: 0x0400188D RID: 6285
		[AccessedThroughProperty("Button1")]
		private Button _Button1;
	}
}
