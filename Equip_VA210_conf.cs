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
	// Token: 0x0200009B RID: 155
	[DesignerGenerated]
	public partial class Equip_VA210_conf : Form
	{
		// Token: 0x06002418 RID: 9240 RVA: 0x00409F68 File Offset: 0x00408368
		public Equip_VA210_conf()
		{
			base.Load += new EventHandler(this.Equip_va210_conf_Load);
			this.InitializeComponent();
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x0600241B RID: 9243 RVA: 0x0040BA50 File Offset: 0x00409E50
		// (set) Token: 0x0600241C RID: 9244 RVA: 0x0040BA64 File Offset: 0x00409E64
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

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x0040BA70 File Offset: 0x00409E70
		// (set) Token: 0x0600241E RID: 9246 RVA: 0x0040BA84 File Offset: 0x00409E84
		internal virtual TextBox Valor_altura_pressiostato
		{
			get
			{
				return this._Valor_altura_pressiostato;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_altura_pressiostato_Validating);
				if (this._Valor_altura_pressiostato != null)
				{
					this._Valor_altura_pressiostato.Validating -= cancelEventHandler;
				}
				this._Valor_altura_pressiostato = value;
				if (this._Valor_altura_pressiostato != null)
				{
					this._Valor_altura_pressiostato.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x0040BAD0 File Offset: 0x00409ED0
		// (set) Token: 0x06002420 RID: 9248 RVA: 0x0040BAE4 File Offset: 0x00409EE4
		internal virtual Label Label_altura_pressiostato
		{
			get
			{
				return this._Label_altura_pressiostato;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_altura_pressiostato = value;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06002421 RID: 9249 RVA: 0x0040BAF0 File Offset: 0x00409EF0
		// (set) Token: 0x06002422 RID: 9250 RVA: 0x0040BB04 File Offset: 0x00409F04
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

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x0040BB50 File Offset: 0x00409F50
		// (set) Token: 0x06002424 RID: 9252 RVA: 0x0040BB64 File Offset: 0x00409F64
		internal virtual TextBox Valor_nivel_baixo
		{
			get
			{
				return this._Valor_nivel_baixo;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_nivel_baixo_Validating);
				if (this._Valor_nivel_baixo != null)
				{
					this._Valor_nivel_baixo.Validating -= cancelEventHandler;
				}
				this._Valor_nivel_baixo = value;
				if (this._Valor_nivel_baixo != null)
				{
					this._Valor_nivel_baixo.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x0040BBB0 File Offset: 0x00409FB0
		// (set) Token: 0x06002426 RID: 9254 RVA: 0x0040BBC4 File Offset: 0x00409FC4
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

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x0040BBD0 File Offset: 0x00409FD0
		// (set) Token: 0x06002428 RID: 9256 RVA: 0x0040BBE4 File Offset: 0x00409FE4
		internal virtual Label Label_numero_recalques
		{
			get
			{
				return this._Label_numero_recalques;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_numero_recalques = value;
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x0040BBF0 File Offset: 0x00409FF0
		// (set) Token: 0x0600242A RID: 9258 RVA: 0x0040BC04 File Offset: 0x0040A004
		internal virtual ComboBox ComboBox_tipo_leitura
		{
			get
			{
				return this._ComboBox_tipo_leitura;
			}
			[MethodImpl(32)]
			set
			{
				this._ComboBox_tipo_leitura = value;
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x0040BC10 File Offset: 0x0040A010
		// (set) Token: 0x0600242C RID: 9260 RVA: 0x0040BC24 File Offset: 0x0040A024
		internal virtual Label Label_altura_nivel_baixo
		{
			get
			{
				return this._Label_altura_nivel_baixo;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_altura_nivel_baixo = value;
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x0040BC30 File Offset: 0x0040A030
		// (set) Token: 0x0600242E RID: 9262 RVA: 0x0040BC44 File Offset: 0x0040A044
		internal virtual Label Label_tempo_sem_comunicacao
		{
			get
			{
				return this._Label_tempo_sem_comunicacao;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_sem_comunicacao = value;
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x0040BC50 File Offset: 0x0040A050
		// (set) Token: 0x06002430 RID: 9264 RVA: 0x0040BC64 File Offset: 0x0040A064
		internal virtual Label Label_altura_nivel_alto
		{
			get
			{
				return this._Label_altura_nivel_alto;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_altura_nivel_alto = value;
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06002431 RID: 9265 RVA: 0x0040BC70 File Offset: 0x0040A070
		// (set) Token: 0x06002432 RID: 9266 RVA: 0x0040BC84 File Offset: 0x0040A084
		internal virtual TextBox Valor_tempo_max_sem_comunicacao
		{
			get
			{
				return this._Valor_tempo_max_sem_comunicacao;
			}
			[MethodImpl(32)]
			set
			{
				this._Valor_tempo_max_sem_comunicacao = value;
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x0040BC90 File Offset: 0x0040A090
		// (set) Token: 0x06002434 RID: 9268 RVA: 0x0040BCA4 File Offset: 0x0040A0A4
		internal virtual TextBox Valor_nivel_alto
		{
			get
			{
				return this._Valor_nivel_alto;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_nivel_alto_Validating);
				if (this._Valor_nivel_alto != null)
				{
					this._Valor_nivel_alto.Validating -= cancelEventHandler;
				}
				this._Valor_nivel_alto = value;
				if (this._Valor_nivel_alto != null)
				{
					this._Valor_nivel_alto.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06002435 RID: 9269 RVA: 0x0040BCF0 File Offset: 0x0040A0F0
		// (set) Token: 0x06002436 RID: 9270 RVA: 0x0040BD04 File Offset: 0x0040A104
		internal virtual GroupBox grupo_grupos
		{
			get
			{
				return this._grupo_grupos;
			}
			[MethodImpl(32)]
			set
			{
				this._grupo_grupos = value;
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06002437 RID: 9271 RVA: 0x0040BD10 File Offset: 0x0040A110
		// (set) Token: 0x06002438 RID: 9272 RVA: 0x0040BD24 File Offset: 0x0040A124
		internal virtual Label Label_numero_grupos
		{
			get
			{
				return this._Label_numero_grupos;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_numero_grupos = value;
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06002439 RID: 9273 RVA: 0x0040BD30 File Offset: 0x0040A130
		// (set) Token: 0x0600243A RID: 9274 RVA: 0x0040BD44 File Offset: 0x0040A144
		internal virtual VScrollBar VScroll_num_grupo
		{
			get
			{
				return this._VScroll_num_grupo;
			}
			[MethodImpl(32)]
			set
			{
				ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.VScroll_num_grupo_Scroll);
				if (this._VScroll_num_grupo != null)
				{
					this._VScroll_num_grupo.Scroll -= scrollEventHandler;
				}
				this._VScroll_num_grupo = value;
				if (this._VScroll_num_grupo != null)
				{
					this._VScroll_num_grupo.Scroll += scrollEventHandler;
				}
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x0600243B RID: 9275 RVA: 0x0040BD90 File Offset: 0x0040A190
		// (set) Token: 0x0600243C RID: 9276 RVA: 0x0040BDA4 File Offset: 0x0040A1A4
		internal virtual TextBox Valor_num_grupo
		{
			get
			{
				return this._Valor_num_grupo;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_num_grupo_Validating);
				if (this._Valor_num_grupo != null)
				{
					this._Valor_num_grupo.Validating -= cancelEventHandler;
				}
				this._Valor_num_grupo = value;
				if (this._Valor_num_grupo != null)
				{
					this._Valor_num_grupo.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x0600243D RID: 9277 RVA: 0x0040BDF0 File Offset: 0x0040A1F0
		// (set) Token: 0x0600243E RID: 9278 RVA: 0x0040BE04 File Offset: 0x0040A204
		internal virtual TextBox Valor_grupo_16
		{
			get
			{
				return this._Valor_grupo_16;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_grupo_16_Validating);
				if (this._Valor_grupo_16 != null)
				{
					this._Valor_grupo_16.Validating -= cancelEventHandler;
				}
				this._Valor_grupo_16 = value;
				if (this._Valor_grupo_16 != null)
				{
					this._Valor_grupo_16.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x0600243F RID: 9279 RVA: 0x0040BE50 File Offset: 0x0040A250
		// (set) Token: 0x06002440 RID: 9280 RVA: 0x0040BE64 File Offset: 0x0040A264
		internal virtual TextBox Valor_grupo_8
		{
			get
			{
				return this._Valor_grupo_8;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_grupo_8_Validating);
				if (this._Valor_grupo_8 != null)
				{
					this._Valor_grupo_8.Validating -= cancelEventHandler;
				}
				this._Valor_grupo_8 = value;
				if (this._Valor_grupo_8 != null)
				{
					this._Valor_grupo_8.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x0040BEB0 File Offset: 0x0040A2B0
		// (set) Token: 0x06002442 RID: 9282 RVA: 0x0040BEC4 File Offset: 0x0040A2C4
		internal virtual TextBox Valor_grupo_15
		{
			get
			{
				return this._Valor_grupo_15;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_grupo_15_Validating);
				if (this._Valor_grupo_15 != null)
				{
					this._Valor_grupo_15.Validating -= cancelEventHandler;
				}
				this._Valor_grupo_15 = value;
				if (this._Valor_grupo_15 != null)
				{
					this._Valor_grupo_15.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x0040BF10 File Offset: 0x0040A310
		// (set) Token: 0x06002444 RID: 9284 RVA: 0x0040BF24 File Offset: 0x0040A324
		internal virtual TextBox Valor_grupo_7
		{
			get
			{
				return this._Valor_grupo_7;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_grupo_7_Validating);
				if (this._Valor_grupo_7 != null)
				{
					this._Valor_grupo_7.Validating -= cancelEventHandler;
				}
				this._Valor_grupo_7 = value;
				if (this._Valor_grupo_7 != null)
				{
					this._Valor_grupo_7.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x0040BF70 File Offset: 0x0040A370
		// (set) Token: 0x06002446 RID: 9286 RVA: 0x0040BF84 File Offset: 0x0040A384
		internal virtual TextBox Valor_grupo_14
		{
			get
			{
				return this._Valor_grupo_14;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_grupo_14_Validating);
				if (this._Valor_grupo_14 != null)
				{
					this._Valor_grupo_14.Validating -= cancelEventHandler;
				}
				this._Valor_grupo_14 = value;
				if (this._Valor_grupo_14 != null)
				{
					this._Valor_grupo_14.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x0040BFD0 File Offset: 0x0040A3D0
		// (set) Token: 0x06002448 RID: 9288 RVA: 0x0040BFE4 File Offset: 0x0040A3E4
		internal virtual TextBox Valor_grupo_6
		{
			get
			{
				return this._Valor_grupo_6;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_grupo_6_Validating);
				if (this._Valor_grupo_6 != null)
				{
					this._Valor_grupo_6.Validating -= cancelEventHandler;
				}
				this._Valor_grupo_6 = value;
				if (this._Valor_grupo_6 != null)
				{
					this._Valor_grupo_6.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x0040C030 File Offset: 0x0040A430
		// (set) Token: 0x0600244A RID: 9290 RVA: 0x0040C044 File Offset: 0x0040A444
		internal virtual TextBox Valor_grupo_13
		{
			get
			{
				return this._Valor_grupo_13;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_grupo_13_Validating);
				if (this._Valor_grupo_13 != null)
				{
					this._Valor_grupo_13.Validating -= cancelEventHandler;
				}
				this._Valor_grupo_13 = value;
				if (this._Valor_grupo_13 != null)
				{
					this._Valor_grupo_13.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x0040C090 File Offset: 0x0040A490
		// (set) Token: 0x0600244C RID: 9292 RVA: 0x0040C0A4 File Offset: 0x0040A4A4
		internal virtual TextBox Valor_grupo_5
		{
			get
			{
				return this._Valor_grupo_5;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_grupo_5_Validating);
				if (this._Valor_grupo_5 != null)
				{
					this._Valor_grupo_5.Validating -= cancelEventHandler;
				}
				this._Valor_grupo_5 = value;
				if (this._Valor_grupo_5 != null)
				{
					this._Valor_grupo_5.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x0040C0F0 File Offset: 0x0040A4F0
		// (set) Token: 0x0600244E RID: 9294 RVA: 0x0040C104 File Offset: 0x0040A504
		internal virtual TextBox Valor_grupo_12
		{
			get
			{
				return this._Valor_grupo_12;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_grupo_12_Validating);
				if (this._Valor_grupo_12 != null)
				{
					this._Valor_grupo_12.Validating -= cancelEventHandler;
				}
				this._Valor_grupo_12 = value;
				if (this._Valor_grupo_12 != null)
				{
					this._Valor_grupo_12.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x0040C150 File Offset: 0x0040A550
		// (set) Token: 0x06002450 RID: 9296 RVA: 0x0040C164 File Offset: 0x0040A564
		internal virtual TextBox Valor_grupo_4
		{
			get
			{
				return this._Valor_grupo_4;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_grupo_4_Validating);
				if (this._Valor_grupo_4 != null)
				{
					this._Valor_grupo_4.Validating -= cancelEventHandler;
				}
				this._Valor_grupo_4 = value;
				if (this._Valor_grupo_4 != null)
				{
					this._Valor_grupo_4.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x0040C1B0 File Offset: 0x0040A5B0
		// (set) Token: 0x06002452 RID: 9298 RVA: 0x0040C1C4 File Offset: 0x0040A5C4
		internal virtual TextBox Valor_grupo_11
		{
			get
			{
				return this._Valor_grupo_11;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_grupo_11_Validating);
				if (this._Valor_grupo_11 != null)
				{
					this._Valor_grupo_11.Validating -= cancelEventHandler;
				}
				this._Valor_grupo_11 = value;
				if (this._Valor_grupo_11 != null)
				{
					this._Valor_grupo_11.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x0040C210 File Offset: 0x0040A610
		// (set) Token: 0x06002454 RID: 9300 RVA: 0x0040C224 File Offset: 0x0040A624
		internal virtual TextBox Valor_grupo_3
		{
			get
			{
				return this._Valor_grupo_3;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_grupo_3_Validating);
				if (this._Valor_grupo_3 != null)
				{
					this._Valor_grupo_3.Validating -= cancelEventHandler;
				}
				this._Valor_grupo_3 = value;
				if (this._Valor_grupo_3 != null)
				{
					this._Valor_grupo_3.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x0040C270 File Offset: 0x0040A670
		// (set) Token: 0x06002456 RID: 9302 RVA: 0x0040C284 File Offset: 0x0040A684
		internal virtual TextBox Valor_grupo_10
		{
			get
			{
				return this._Valor_grupo_10;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_grupo_10_Validating);
				if (this._Valor_grupo_10 != null)
				{
					this._Valor_grupo_10.Validating -= cancelEventHandler;
				}
				this._Valor_grupo_10 = value;
				if (this._Valor_grupo_10 != null)
				{
					this._Valor_grupo_10.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x0040C2D0 File Offset: 0x0040A6D0
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x0040C2E4 File Offset: 0x0040A6E4
		internal virtual TextBox Valor_grupo_2
		{
			get
			{
				return this._Valor_grupo_2;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_grupo_2_Validating);
				if (this._Valor_grupo_2 != null)
				{
					this._Valor_grupo_2.Validating -= cancelEventHandler;
				}
				this._Valor_grupo_2 = value;
				if (this._Valor_grupo_2 != null)
				{
					this._Valor_grupo_2.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x0040C330 File Offset: 0x0040A730
		// (set) Token: 0x0600245A RID: 9306 RVA: 0x0040C344 File Offset: 0x0040A744
		internal virtual TextBox Valor_grupo_9
		{
			get
			{
				return this._Valor_grupo_9;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_grupo_9_Validating);
				if (this._Valor_grupo_9 != null)
				{
					this._Valor_grupo_9.Validating -= cancelEventHandler;
				}
				this._Valor_grupo_9 = value;
				if (this._Valor_grupo_9 != null)
				{
					this._Valor_grupo_9.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x0040C390 File Offset: 0x0040A790
		// (set) Token: 0x0600245C RID: 9308 RVA: 0x0040C3A4 File Offset: 0x0040A7A4
		internal virtual TextBox Valor_grupo_1
		{
			get
			{
				return this._Valor_grupo_1;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_grupo_1_Validating);
				if (this._Valor_grupo_1 != null)
				{
					this._Valor_grupo_1.Validating -= cancelEventHandler;
				}
				this._Valor_grupo_1 = value;
				if (this._Valor_grupo_1 != null)
				{
					this._Valor_grupo_1.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x0040C3F0 File Offset: 0x0040A7F0
		// (set) Token: 0x0600245E RID: 9310 RVA: 0x0040C404 File Offset: 0x0040A804
		internal virtual Label Label_grupo_16
		{
			get
			{
				return this._Label_grupo_16;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_grupo_16 = value;
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x0600245F RID: 9311 RVA: 0x0040C410 File Offset: 0x0040A810
		// (set) Token: 0x06002460 RID: 9312 RVA: 0x0040C424 File Offset: 0x0040A824
		internal virtual Label Label_grupo_8
		{
			get
			{
				return this._Label_grupo_8;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_grupo_8 = value;
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06002461 RID: 9313 RVA: 0x0040C430 File Offset: 0x0040A830
		// (set) Token: 0x06002462 RID: 9314 RVA: 0x0040C444 File Offset: 0x0040A844
		internal virtual Label Label_grupo_15
		{
			get
			{
				return this._Label_grupo_15;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_grupo_15 = value;
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x0040C450 File Offset: 0x0040A850
		// (set) Token: 0x06002464 RID: 9316 RVA: 0x0040C464 File Offset: 0x0040A864
		internal virtual Label Label_grupo_7
		{
			get
			{
				return this._Label_grupo_7;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_grupo_7 = value;
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06002465 RID: 9317 RVA: 0x0040C470 File Offset: 0x0040A870
		// (set) Token: 0x06002466 RID: 9318 RVA: 0x0040C484 File Offset: 0x0040A884
		internal virtual Label Label_grupo_14
		{
			get
			{
				return this._Label_grupo_14;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_grupo_14 = value;
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06002467 RID: 9319 RVA: 0x0040C490 File Offset: 0x0040A890
		// (set) Token: 0x06002468 RID: 9320 RVA: 0x0040C4A4 File Offset: 0x0040A8A4
		internal virtual Label Label_grupo_6
		{
			get
			{
				return this._Label_grupo_6;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_grupo_6 = value;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06002469 RID: 9321 RVA: 0x0040C4B0 File Offset: 0x0040A8B0
		// (set) Token: 0x0600246A RID: 9322 RVA: 0x0040C4C4 File Offset: 0x0040A8C4
		internal virtual Label Label_grupo_13
		{
			get
			{
				return this._Label_grupo_13;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_grupo_13 = value;
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x0040C4D0 File Offset: 0x0040A8D0
		// (set) Token: 0x0600246C RID: 9324 RVA: 0x0040C4E4 File Offset: 0x0040A8E4
		internal virtual Label Label_grupo_5
		{
			get
			{
				return this._Label_grupo_5;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_grupo_5 = value;
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x0040C4F0 File Offset: 0x0040A8F0
		// (set) Token: 0x0600246E RID: 9326 RVA: 0x0040C504 File Offset: 0x0040A904
		internal virtual Label Label_grupo_12
		{
			get
			{
				return this._Label_grupo_12;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_grupo_12 = value;
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x0040C510 File Offset: 0x0040A910
		// (set) Token: 0x06002470 RID: 9328 RVA: 0x0040C524 File Offset: 0x0040A924
		internal virtual Label Label_grupo_4
		{
			get
			{
				return this._Label_grupo_4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_grupo_4 = value;
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06002471 RID: 9329 RVA: 0x0040C530 File Offset: 0x0040A930
		// (set) Token: 0x06002472 RID: 9330 RVA: 0x0040C544 File Offset: 0x0040A944
		internal virtual Label Label_grupo_11
		{
			get
			{
				return this._Label_grupo_11;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_grupo_11 = value;
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x0040C550 File Offset: 0x0040A950
		// (set) Token: 0x06002474 RID: 9332 RVA: 0x0040C564 File Offset: 0x0040A964
		internal virtual Label Label_grupo_3
		{
			get
			{
				return this._Label_grupo_3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_grupo_3 = value;
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06002475 RID: 9333 RVA: 0x0040C570 File Offset: 0x0040A970
		// (set) Token: 0x06002476 RID: 9334 RVA: 0x0040C584 File Offset: 0x0040A984
		internal virtual Label Label_grupo_10
		{
			get
			{
				return this._Label_grupo_10;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_grupo_10 = value;
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06002477 RID: 9335 RVA: 0x0040C590 File Offset: 0x0040A990
		// (set) Token: 0x06002478 RID: 9336 RVA: 0x0040C5A4 File Offset: 0x0040A9A4
		internal virtual Label Label_grupo_2
		{
			get
			{
				return this._Label_grupo_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_grupo_2 = value;
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06002479 RID: 9337 RVA: 0x0040C5B0 File Offset: 0x0040A9B0
		// (set) Token: 0x0600247A RID: 9338 RVA: 0x0040C5C4 File Offset: 0x0040A9C4
		internal virtual Label Label_grupo_9
		{
			get
			{
				return this._Label_grupo_9;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_grupo_9 = value;
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x0600247B RID: 9339 RVA: 0x0040C5D0 File Offset: 0x0040A9D0
		// (set) Token: 0x0600247C RID: 9340 RVA: 0x0040C5E4 File Offset: 0x0040A9E4
		internal virtual Label Label_grupo_1
		{
			get
			{
				return this._Label_grupo_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_grupo_1 = value;
			}
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x0040C5F0 File Offset: 0x0040A9F0
		private void Equip_va210_conf_Load(object sender, EventArgs e)
		{
			this.ComboBox_tipo_leitura.Items.Clear();
			this.ComboBox_tipo_leitura.Items.Add("AD");
			this.ComboBox_tipo_leitura.Items.Add("Bóias");
			this.Limpa_estrutura_VA210();
			this.Atualiza_tela_VA210();
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x0040C648 File Offset: 0x0040AA48
		public void Limpa_estrutura_VA210()
		{
			Mod_VA.Config_VA210.grupos = new int[17];
			Mod_VA.Config_VA210.End_mestre = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.Altura_pressiostato = (HorizontalAlignment)1000;
			Mod_VA.Config_VA210.Altura_nivel_baixo = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.Altura_nivel_alto = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.Num_grupos = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.grupos[1] = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.grupos[2] = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.grupos[3] = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.grupos[4] = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.grupos[5] = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.grupos[6] = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.grupos[7] = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.grupos[8] = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.grupos[9] = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.grupos[10] = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.grupos[11] = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.grupos[12] = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.grupos[13] = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.grupos[14] = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.grupos[15] = (HorizontalAlignment)0;
			Mod_VA.Config_VA210.grupos[16] = (HorizontalAlignment)0;
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x0040C77C File Offset: 0x0040AB7C
		public void Atualiza_tela_VA210()
		{
			this.Valor_end_mestre.Text = Conversions.ToString(Mod_VA.Config_VA210.End_mestre);
			this.Valor_altura_pressiostato.Text = Conversions.ToString(Mod_VA.Config_VA210.Altura_pressiostato);
			this.Valor_nivel_alto.Text = Conversions.ToString(Mod_VA.Config_VA210.Altura_nivel_alto);
			this.Valor_nivel_baixo.Text = Conversions.ToString(Mod_VA.Config_VA210.Altura_nivel_baixo);
			this.Valor_tempo_max_sem_comunicacao.Text = Conversions.ToString(Mod_VA.Config_VA210.Tempo_max_sem_comunicacao);
			this.ComboBox_tipo_leitura.SelectedIndex = Mod_VA.Config_VA210.Tipo_leitura;
			this.Valor_num_grupo.Text = Conversions.ToString(Mod_VA.Config_VA210.Num_grupos);
			this.VScroll_num_grupo.Value = Mod_VA.Config_VA210.Num_grupos;
			this.VScroll_num_grupo.Maximum = (HorizontalAlignment)16;
			this.VScroll_num_grupo.Minimum = (HorizontalAlignment)0;
			this.Habilita_grupos(Mod_VA.Config_VA210.Num_grupos);
			this.Valor_grupo_1.Text = Conversions.ToString(Mod_VA.Config_VA210.grupos[1]);
			this.Valor_grupo_2.Text = Conversions.ToString(Mod_VA.Config_VA210.grupos[2]);
			this.Valor_grupo_3.Text = Conversions.ToString(Mod_VA.Config_VA210.grupos[3]);
			this.Valor_grupo_4.Text = Conversions.ToString(Mod_VA.Config_VA210.grupos[4]);
			this.Valor_grupo_5.Text = Conversions.ToString(Mod_VA.Config_VA210.grupos[5]);
			this.Valor_grupo_6.Text = Conversions.ToString(Mod_VA.Config_VA210.grupos[6]);
			this.Valor_grupo_7.Text = Conversions.ToString(Mod_VA.Config_VA210.grupos[7]);
			this.Valor_grupo_8.Text = Conversions.ToString(Mod_VA.Config_VA210.grupos[8]);
			this.Valor_grupo_9.Text = Conversions.ToString(Mod_VA.Config_VA210.grupos[9]);
			this.Valor_grupo_10.Text = Conversions.ToString(Mod_VA.Config_VA210.grupos[10]);
			this.Valor_grupo_11.Text = Conversions.ToString(Mod_VA.Config_VA210.grupos[11]);
			this.Valor_grupo_12.Text = Conversions.ToString(Mod_VA.Config_VA210.grupos[12]);
			this.Valor_grupo_13.Text = Conversions.ToString(Mod_VA.Config_VA210.grupos[13]);
			this.Valor_grupo_14.Text = Conversions.ToString(Mod_VA.Config_VA210.grupos[14]);
			this.Valor_grupo_15.Text = Conversions.ToString(Mod_VA.Config_VA210.grupos[15]);
			this.Valor_grupo_16.Text = Conversions.ToString(Mod_VA.Config_VA210.grupos[16]);
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x0040CA40 File Offset: 0x0040AE40
		private void Valor_end_mestre_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_end_mestre.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.End_mestre = num;
			}
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x0040CA88 File Offset: 0x0040AE88
		private void Valor_altura_pressiostato_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_altura_pressiostato.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.Altura_pressiostato = num;
			}
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x0040CAD0 File Offset: 0x0040AED0
		private void Valor_nivel_alto_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_nivel_alto.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.Altura_nivel_alto = num;
			}
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x0040CB18 File Offset: 0x0040AF18
		private void Valor_nivel_baixo_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_nivel_baixo.Text)));
			if (num < 0 | num > 9999)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.Altura_nivel_baixo = num;
			}
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x0040CB60 File Offset: 0x0040AF60
		private void Valor_num_grupo_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_num_grupo.Text)));
			if (num < 0 | num > 16)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.Num_grupos = num;
				this.VScroll_num_grupo.Value = Mod_VA.Config_VA210.Num_grupos;
				this.Habilita_grupos(num);
			}
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x0040CBC0 File Offset: 0x0040AFC0
		private void Valor_grupo_1_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_grupo_1.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.grupos[1] = num;
			}
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x0040CC0C File Offset: 0x0040B00C
		private void Valor_grupo_2_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_grupo_2.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.grupos[2] = num;
			}
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x0040CC58 File Offset: 0x0040B058
		private void Valor_grupo_3_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_grupo_3.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.grupos[3] = num;
			}
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x0040CCA4 File Offset: 0x0040B0A4
		private void Valor_grupo_4_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_grupo_4.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.grupos[4] = num;
			}
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x0040CCF0 File Offset: 0x0040B0F0
		private void Valor_grupo_5_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_grupo_5.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.grupos[5] = num;
			}
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x0040CD3C File Offset: 0x0040B13C
		private void Valor_grupo_6_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_grupo_6.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.grupos[6] = num;
			}
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x0040CD88 File Offset: 0x0040B188
		private void Valor_grupo_7_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_grupo_7.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.grupos[7] = num;
			}
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x0040CDD4 File Offset: 0x0040B1D4
		private void Valor_grupo_8_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_grupo_8.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.grupos[8] = num;
			}
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x0040CE20 File Offset: 0x0040B220
		private void Valor_grupo_9_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_grupo_9.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.grupos[9] = num;
			}
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x0040CE6C File Offset: 0x0040B26C
		private void Valor_grupo_10_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_grupo_10.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.grupos[10] = num;
			}
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x0040CEB8 File Offset: 0x0040B2B8
		private void Valor_grupo_11_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_grupo_11.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.grupos[11] = num;
			}
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x0040CF04 File Offset: 0x0040B304
		private void Valor_grupo_12_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_grupo_12.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.grupos[12] = num;
			}
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x0040CF50 File Offset: 0x0040B350
		private void Valor_grupo_13_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_grupo_13.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.grupos[13] = num;
			}
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x0040CF9C File Offset: 0x0040B39C
		private void Valor_grupo_14_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_grupo_14.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.grupos[14] = num;
			}
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x0040CFE8 File Offset: 0x0040B3E8
		private void Valor_grupo_15_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_grupo_15.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.grupos[15] = num;
			}
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x0040D034 File Offset: 0x0040B434
		private void Valor_grupo_16_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(this.Valor_grupo_16.Text)));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Config_VA210.grupos[16] = num;
			}
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x0040D080 File Offset: 0x0040B480
		private void VScroll_num_grupo_Scroll(object sender, ScrollEventArgs e)
		{
			this.Valor_num_grupo.Text = Conversion.Str(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null)));
			this.Habilita_grupos(Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null)));
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x0040D0D8 File Offset: 0x0040B4D8
		public void Habilita_grupos(int numero)
		{
			if (numero < 1)
			{
				this.Label_grupo_1.Visible = false;
				this.Valor_grupo_1.Visible = false;
			}
			else
			{
				this.Label_grupo_1.Visible = true;
				this.Valor_grupo_1.Visible = true;
			}
			if (numero < 2)
			{
				this.Label_grupo_2.Visible = false;
				this.Valor_grupo_2.Visible = false;
			}
			else
			{
				this.Label_grupo_2.Visible = true;
				this.Valor_grupo_2.Visible = true;
			}
			if (numero < 3)
			{
				this.Label_grupo_3.Visible = false;
				this.Valor_grupo_3.Visible = false;
			}
			else
			{
				this.Label_grupo_3.Visible = true;
				this.Valor_grupo_3.Visible = true;
			}
			if (numero < 4)
			{
				this.Label_grupo_4.Visible = false;
				this.Valor_grupo_4.Visible = false;
			}
			else
			{
				this.Label_grupo_4.Visible = true;
				this.Valor_grupo_4.Visible = true;
			}
			if (numero < 5)
			{
				this.Label_grupo_5.Visible = false;
				this.Valor_grupo_5.Visible = false;
			}
			else
			{
				this.Label_grupo_5.Visible = true;
				this.Valor_grupo_5.Visible = true;
			}
			if (numero < 6)
			{
				this.Label_grupo_6.Visible = false;
				this.Valor_grupo_6.Visible = false;
			}
			else
			{
				this.Label_grupo_6.Visible = true;
				this.Valor_grupo_6.Visible = true;
			}
			if (numero < 7)
			{
				this.Label_grupo_7.Visible = false;
				this.Valor_grupo_7.Visible = false;
			}
			else
			{
				this.Label_grupo_7.Visible = true;
				this.Valor_grupo_7.Visible = true;
			}
			if (numero < 8)
			{
				this.Label_grupo_8.Visible = false;
				this.Valor_grupo_8.Visible = false;
			}
			else
			{
				this.Label_grupo_8.Visible = true;
				this.Valor_grupo_8.Visible = true;
			}
			if (numero < 9)
			{
				this.Label_grupo_9.Visible = false;
				this.Valor_grupo_9.Visible = false;
			}
			else
			{
				this.Label_grupo_9.Visible = true;
				this.Valor_grupo_9.Visible = true;
			}
			if (numero < 10)
			{
				this.Label_grupo_10.Visible = false;
				this.Valor_grupo_10.Visible = false;
			}
			else
			{
				this.Label_grupo_10.Visible = true;
				this.Valor_grupo_10.Visible = true;
			}
			if (numero < 11)
			{
				this.Label_grupo_11.Visible = false;
				this.Valor_grupo_11.Visible = false;
			}
			else
			{
				this.Label_grupo_11.Visible = true;
				this.Valor_grupo_11.Visible = true;
			}
			if (numero < 12)
			{
				this.Label_grupo_12.Visible = false;
				this.Valor_grupo_12.Visible = false;
			}
			else
			{
				this.Label_grupo_12.Visible = true;
				this.Valor_grupo_12.Visible = true;
			}
			if (numero < 13)
			{
				this.Label_grupo_13.Visible = false;
				this.Valor_grupo_13.Visible = false;
			}
			else
			{
				this.Label_grupo_13.Visible = true;
				this.Valor_grupo_13.Visible = true;
			}
			if (numero < 14)
			{
				this.Label_grupo_14.Visible = false;
				this.Valor_grupo_14.Visible = false;
			}
			else
			{
				this.Label_grupo_14.Visible = true;
				this.Valor_grupo_14.Visible = true;
			}
			if (numero < 15)
			{
				this.Label_grupo_15.Visible = false;
				this.Valor_grupo_15.Visible = false;
			}
			else
			{
				this.Label_grupo_15.Visible = true;
				this.Valor_grupo_15.Visible = true;
			}
			if (numero < 16)
			{
				this.Label_grupo_16.Visible = false;
				this.Valor_grupo_16.Visible = false;
			}
			else
			{
				this.Label_grupo_16.Visible = true;
				this.Valor_grupo_16.Visible = true;
			}
		}

		// Token: 0x04001A11 RID: 6673
		[AccessedThroughProperty("grupo_parametros_gerais")]
		private GroupBox _grupo_parametros_gerais;

		// Token: 0x04001A12 RID: 6674
		[AccessedThroughProperty("Valor_altura_pressiostato")]
		private TextBox _Valor_altura_pressiostato;

		// Token: 0x04001A13 RID: 6675
		[AccessedThroughProperty("Label_altura_pressiostato")]
		private Label _Label_altura_pressiostato;

		// Token: 0x04001A14 RID: 6676
		[AccessedThroughProperty("Valor_end_mestre")]
		private TextBox _Valor_end_mestre;

		// Token: 0x04001A15 RID: 6677
		[AccessedThroughProperty("Valor_nivel_baixo")]
		private TextBox _Valor_nivel_baixo;

		// Token: 0x04001A16 RID: 6678
		[AccessedThroughProperty("Label_end_mestre")]
		private Label _Label_end_mestre;

		// Token: 0x04001A17 RID: 6679
		[AccessedThroughProperty("Label_numero_recalques")]
		private Label _Label_numero_recalques;

		// Token: 0x04001A18 RID: 6680
		[AccessedThroughProperty("ComboBox_tipo_leitura")]
		private ComboBox _ComboBox_tipo_leitura;

		// Token: 0x04001A19 RID: 6681
		[AccessedThroughProperty("Label_altura_nivel_baixo")]
		private Label _Label_altura_nivel_baixo;

		// Token: 0x04001A1A RID: 6682
		[AccessedThroughProperty("Label_tempo_sem_comunicacao")]
		private Label _Label_tempo_sem_comunicacao;

		// Token: 0x04001A1B RID: 6683
		[AccessedThroughProperty("Label_altura_nivel_alto")]
		private Label _Label_altura_nivel_alto;

		// Token: 0x04001A1C RID: 6684
		[AccessedThroughProperty("Valor_tempo_max_sem_comunicacao")]
		private TextBox _Valor_tempo_max_sem_comunicacao;

		// Token: 0x04001A1D RID: 6685
		[AccessedThroughProperty("Valor_nivel_alto")]
		private TextBox _Valor_nivel_alto;

		// Token: 0x04001A1E RID: 6686
		[AccessedThroughProperty("grupo_grupos")]
		private GroupBox _grupo_grupos;

		// Token: 0x04001A1F RID: 6687
		[AccessedThroughProperty("Label_numero_grupos")]
		private Label _Label_numero_grupos;

		// Token: 0x04001A20 RID: 6688
		[AccessedThroughProperty("VScroll_num_grupo")]
		private VScrollBar _VScroll_num_grupo;

		// Token: 0x04001A21 RID: 6689
		[AccessedThroughProperty("Valor_num_grupo")]
		private TextBox _Valor_num_grupo;

		// Token: 0x04001A22 RID: 6690
		[AccessedThroughProperty("Valor_grupo_16")]
		private TextBox _Valor_grupo_16;

		// Token: 0x04001A23 RID: 6691
		[AccessedThroughProperty("Valor_grupo_8")]
		private TextBox _Valor_grupo_8;

		// Token: 0x04001A24 RID: 6692
		[AccessedThroughProperty("Valor_grupo_15")]
		private TextBox _Valor_grupo_15;

		// Token: 0x04001A25 RID: 6693
		[AccessedThroughProperty("Valor_grupo_7")]
		private TextBox _Valor_grupo_7;

		// Token: 0x04001A26 RID: 6694
		[AccessedThroughProperty("Valor_grupo_14")]
		private TextBox _Valor_grupo_14;

		// Token: 0x04001A27 RID: 6695
		[AccessedThroughProperty("Valor_grupo_6")]
		private TextBox _Valor_grupo_6;

		// Token: 0x04001A28 RID: 6696
		[AccessedThroughProperty("Valor_grupo_13")]
		private TextBox _Valor_grupo_13;

		// Token: 0x04001A29 RID: 6697
		[AccessedThroughProperty("Valor_grupo_5")]
		private TextBox _Valor_grupo_5;

		// Token: 0x04001A2A RID: 6698
		[AccessedThroughProperty("Valor_grupo_12")]
		private TextBox _Valor_grupo_12;

		// Token: 0x04001A2B RID: 6699
		[AccessedThroughProperty("Valor_grupo_4")]
		private TextBox _Valor_grupo_4;

		// Token: 0x04001A2C RID: 6700
		[AccessedThroughProperty("Valor_grupo_11")]
		private TextBox _Valor_grupo_11;

		// Token: 0x04001A2D RID: 6701
		[AccessedThroughProperty("Valor_grupo_3")]
		private TextBox _Valor_grupo_3;

		// Token: 0x04001A2E RID: 6702
		[AccessedThroughProperty("Valor_grupo_10")]
		private TextBox _Valor_grupo_10;

		// Token: 0x04001A2F RID: 6703
		[AccessedThroughProperty("Valor_grupo_2")]
		private TextBox _Valor_grupo_2;

		// Token: 0x04001A30 RID: 6704
		[AccessedThroughProperty("Valor_grupo_9")]
		private TextBox _Valor_grupo_9;

		// Token: 0x04001A31 RID: 6705
		[AccessedThroughProperty("Valor_grupo_1")]
		private TextBox _Valor_grupo_1;

		// Token: 0x04001A32 RID: 6706
		[AccessedThroughProperty("Label_grupo_16")]
		private Label _Label_grupo_16;

		// Token: 0x04001A33 RID: 6707
		[AccessedThroughProperty("Label_grupo_8")]
		private Label _Label_grupo_8;

		// Token: 0x04001A34 RID: 6708
		[AccessedThroughProperty("Label_grupo_15")]
		private Label _Label_grupo_15;

		// Token: 0x04001A35 RID: 6709
		[AccessedThroughProperty("Label_grupo_7")]
		private Label _Label_grupo_7;

		// Token: 0x04001A36 RID: 6710
		[AccessedThroughProperty("Label_grupo_14")]
		private Label _Label_grupo_14;

		// Token: 0x04001A37 RID: 6711
		[AccessedThroughProperty("Label_grupo_6")]
		private Label _Label_grupo_6;

		// Token: 0x04001A38 RID: 6712
		[AccessedThroughProperty("Label_grupo_13")]
		private Label _Label_grupo_13;

		// Token: 0x04001A39 RID: 6713
		[AccessedThroughProperty("Label_grupo_5")]
		private Label _Label_grupo_5;

		// Token: 0x04001A3A RID: 6714
		[AccessedThroughProperty("Label_grupo_12")]
		private Label _Label_grupo_12;

		// Token: 0x04001A3B RID: 6715
		[AccessedThroughProperty("Label_grupo_4")]
		private Label _Label_grupo_4;

		// Token: 0x04001A3C RID: 6716
		[AccessedThroughProperty("Label_grupo_11")]
		private Label _Label_grupo_11;

		// Token: 0x04001A3D RID: 6717
		[AccessedThroughProperty("Label_grupo_3")]
		private Label _Label_grupo_3;

		// Token: 0x04001A3E RID: 6718
		[AccessedThroughProperty("Label_grupo_10")]
		private Label _Label_grupo_10;

		// Token: 0x04001A3F RID: 6719
		[AccessedThroughProperty("Label_grupo_2")]
		private Label _Label_grupo_2;

		// Token: 0x04001A40 RID: 6720
		[AccessedThroughProperty("Label_grupo_9")]
		private Label _Label_grupo_9;

		// Token: 0x04001A41 RID: 6721
		[AccessedThroughProperty("Label_grupo_1")]
		private Label _Label_grupo_1;
	}
}
