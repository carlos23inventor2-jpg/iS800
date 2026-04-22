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
	// Token: 0x0200009E RID: 158
	[DesignerGenerated]
	public partial class Equip_VA220_ope : Form
	{
		// Token: 0x06002569 RID: 9577 RVA: 0x00415358 File Offset: 0x00413758
		public Equip_VA220_ope()
		{
			base.Load += new EventHandler(this.Equip_VA220_ope_Load);
			this.InitializeComponent();
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x0041A1B8 File Offset: 0x004185B8
		// (set) Token: 0x0600256D RID: 9581 RVA: 0x0041A1CC File Offset: 0x004185CC
		internal virtual GroupBox Grupo_endereco
		{
			get
			{
				return this._Grupo_endereco;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_endereco = value;
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x0041A1D8 File Offset: 0x004185D8
		// (set) Token: 0x0600256F RID: 9583 RVA: 0x0041A1EC File Offset: 0x004185EC
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

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x0041A1F8 File Offset: 0x004185F8
		// (set) Token: 0x06002571 RID: 9585 RVA: 0x0041A20C File Offset: 0x0041860C
		internal virtual VScrollBar VScroll_end_estacao
		{
			get
			{
				return this._VScroll_end_estacao;
			}
			[MethodImpl(32)]
			set
			{
				ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.VScroll_end_estacao_Scroll);
				if (this._VScroll_end_estacao != null)
				{
					this._VScroll_end_estacao.Scroll -= scrollEventHandler;
				}
				this._VScroll_end_estacao = value;
				if (this._VScroll_end_estacao != null)
				{
					this._VScroll_end_estacao.Scroll += scrollEventHandler;
				}
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x0041A258 File Offset: 0x00418658
		// (set) Token: 0x06002573 RID: 9587 RVA: 0x0041A26C File Offset: 0x0041866C
		internal virtual TextBox Valor_end_estacao
		{
			get
			{
				return this._Valor_end_estacao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Valor_end_estacao_TextChanged);
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_end_estacao_Validating);
				if (this._Valor_end_estacao != null)
				{
					this._Valor_end_estacao.TextChanged -= eventHandler;
					this._Valor_end_estacao.Validating -= cancelEventHandler;
				}
				this._Valor_end_estacao = value;
				if (this._Valor_end_estacao != null)
				{
					this._Valor_end_estacao.TextChanged += eventHandler;
					this._Valor_end_estacao.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x0041A2DC File Offset: 0x004186DC
		// (set) Token: 0x06002575 RID: 9589 RVA: 0x0041A2F0 File Offset: 0x004186F0
		internal virtual GroupBox Grupo_setpoint
		{
			get
			{
				return this._Grupo_setpoint;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_setpoint = value;
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x0041A2FC File Offset: 0x004186FC
		// (set) Token: 0x06002577 RID: 9591 RVA: 0x0041A310 File Offset: 0x00418710
		internal virtual GroupBox Grupo_origem
		{
			get
			{
				return this._Grupo_origem;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_origem = value;
			}
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x0041A31C File Offset: 0x0041871C
		// (set) Token: 0x06002579 RID: 9593 RVA: 0x0041A330 File Offset: 0x00418730
		internal virtual Label Label_nivel_ligamento
		{
			get
			{
				return this._Label_nivel_ligamento;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_ligamento = value;
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x0041A33C File Offset: 0x0041873C
		// (set) Token: 0x0600257B RID: 9595 RVA: 0x0041A350 File Offset: 0x00418750
		internal virtual Label Label_nivel_desligamento
		{
			get
			{
				return this._Label_nivel_desligamento;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_desligamento = value;
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x0041A35C File Offset: 0x0041875C
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x0041A370 File Offset: 0x00418770
		internal virtual TextBox Valor_nivel_ligamento
		{
			get
			{
				return this._Valor_nivel_ligamento;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_nivel_ligamento_Validating);
				if (this._Valor_nivel_ligamento != null)
				{
					this._Valor_nivel_ligamento.Validating -= cancelEventHandler;
				}
				this._Valor_nivel_ligamento = value;
				if (this._Valor_nivel_ligamento != null)
				{
					this._Valor_nivel_ligamento.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x0041A3BC File Offset: 0x004187BC
		// (set) Token: 0x0600257F RID: 9599 RVA: 0x0041A3D0 File Offset: 0x004187D0
		internal virtual TextBox Valor_nivel_desligamento
		{
			get
			{
				return this._Valor_nivel_desligamento;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_nivel_desligamento_Validating);
				if (this._Valor_nivel_desligamento != null)
				{
					this._Valor_nivel_desligamento.Validating -= cancelEventHandler;
				}
				this._Valor_nivel_desligamento = value;
				if (this._Valor_nivel_desligamento != null)
				{
					this._Valor_nivel_desligamento.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x0041A41C File Offset: 0x0041881C
		// (set) Token: 0x06002581 RID: 9601 RVA: 0x0041A430 File Offset: 0x00418830
		internal virtual GroupBox Grupo_gerais
		{
			get
			{
				return this._Grupo_gerais;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_gerais = value;
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06002582 RID: 9602 RVA: 0x0041A43C File Offset: 0x0041883C
		// (set) Token: 0x06002583 RID: 9603 RVA: 0x0041A450 File Offset: 0x00418850
		internal virtual Label Label_pressao_controle
		{
			get
			{
				return this._Label_pressao_controle;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_pressao_controle = value;
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x0041A45C File Offset: 0x0041885C
		// (set) Token: 0x06002585 RID: 9605 RVA: 0x0041A470 File Offset: 0x00418870
		internal virtual Label Label_pressao_succao
		{
			get
			{
				return this._Label_pressao_succao;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_pressao_succao = value;
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x0041A47C File Offset: 0x0041887C
		// (set) Token: 0x06002587 RID: 9607 RVA: 0x0041A490 File Offset: 0x00418890
		internal virtual Label Label_tempo_mais_motor
		{
			get
			{
				return this._Label_tempo_mais_motor;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_mais_motor = value;
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x0041A49C File Offset: 0x0041889C
		// (set) Token: 0x06002589 RID: 9609 RVA: 0x0041A4B0 File Offset: 0x004188B0
		internal virtual TextBox Valor_pressao_controle
		{
			get
			{
				return this._Valor_pressao_controle;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_pressao_controle_Validating);
				if (this._Valor_pressao_controle != null)
				{
					this._Valor_pressao_controle.Validating -= cancelEventHandler;
				}
				this._Valor_pressao_controle = value;
				if (this._Valor_pressao_controle != null)
				{
					this._Valor_pressao_controle.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x0600258A RID: 9610 RVA: 0x0041A4FC File Offset: 0x004188FC
		// (set) Token: 0x0600258B RID: 9611 RVA: 0x0041A510 File Offset: 0x00418910
		internal virtual TextBox Valor_pressao_succao
		{
			get
			{
				return this._Valor_pressao_succao;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_pressao_succao_Validating);
				if (this._Valor_pressao_succao != null)
				{
					this._Valor_pressao_succao.Validating -= cancelEventHandler;
				}
				this._Valor_pressao_succao = value;
				if (this._Valor_pressao_succao != null)
				{
					this._Valor_pressao_succao.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x0600258C RID: 9612 RVA: 0x0041A55C File Offset: 0x0041895C
		// (set) Token: 0x0600258D RID: 9613 RVA: 0x0041A570 File Offset: 0x00418970
		internal virtual TextBox Valor_tempo_mais_bomba
		{
			get
			{
				return this._Valor_tempo_mais_bomba;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_tempo_mais_bomba_Validating);
				if (this._Valor_tempo_mais_bomba != null)
				{
					this._Valor_tempo_mais_bomba.Validating -= cancelEventHandler;
				}
				this._Valor_tempo_mais_bomba = value;
				if (this._Valor_tempo_mais_bomba != null)
				{
					this._Valor_tempo_mais_bomba.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x0041A5BC File Offset: 0x004189BC
		// (set) Token: 0x0600258F RID: 9615 RVA: 0x0041A5D0 File Offset: 0x004189D0
		internal virtual GroupBox Grupo_niveis
		{
			get
			{
				return this._Grupo_niveis;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_niveis = value;
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x0041A5DC File Offset: 0x004189DC
		// (set) Token: 0x06002591 RID: 9617 RVA: 0x0041A5F0 File Offset: 0x004189F0
		internal virtual Label Label_nivel_bomba_4
		{
			get
			{
				return this._Label_nivel_bomba_4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_bomba_4 = value;
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x0041A5FC File Offset: 0x004189FC
		// (set) Token: 0x06002593 RID: 9619 RVA: 0x0041A610 File Offset: 0x00418A10
		internal virtual Label Label_nivel_bomba_3
		{
			get
			{
				return this._Label_nivel_bomba_3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_bomba_3 = value;
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x0041A61C File Offset: 0x00418A1C
		// (set) Token: 0x06002595 RID: 9621 RVA: 0x0041A630 File Offset: 0x00418A30
		internal virtual Label Label_nivel_bomba_2
		{
			get
			{
				return this._Label_nivel_bomba_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_bomba_2 = value;
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x0041A63C File Offset: 0x00418A3C
		// (set) Token: 0x06002597 RID: 9623 RVA: 0x0041A650 File Offset: 0x00418A50
		internal virtual Label Label_nivel_bomba_1
		{
			get
			{
				return this._Label_nivel_bomba_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_bomba_1 = value;
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x0041A65C File Offset: 0x00418A5C
		// (set) Token: 0x06002599 RID: 9625 RVA: 0x0041A670 File Offset: 0x00418A70
		internal virtual Label Label_nivel_desejado
		{
			get
			{
				return this._Label_nivel_desejado;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_desejado = value;
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x0600259A RID: 9626 RVA: 0x0041A67C File Offset: 0x00418A7C
		// (set) Token: 0x0600259B RID: 9627 RVA: 0x0041A690 File Offset: 0x00418A90
		internal virtual TextBox Valor_nivel_B4
		{
			get
			{
				return this._Valor_nivel_B4;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_nivel_B4_Validating);
				if (this._Valor_nivel_B4 != null)
				{
					this._Valor_nivel_B4.Validating -= cancelEventHandler;
				}
				this._Valor_nivel_B4 = value;
				if (this._Valor_nivel_B4 != null)
				{
					this._Valor_nivel_B4.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x0600259C RID: 9628 RVA: 0x0041A6DC File Offset: 0x00418ADC
		// (set) Token: 0x0600259D RID: 9629 RVA: 0x0041A6F0 File Offset: 0x00418AF0
		internal virtual TextBox Valor_nivel_B3
		{
			get
			{
				return this._Valor_nivel_B3;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_nivel_B3_Validating);
				if (this._Valor_nivel_B3 != null)
				{
					this._Valor_nivel_B3.Validating -= cancelEventHandler;
				}
				this._Valor_nivel_B3 = value;
				if (this._Valor_nivel_B3 != null)
				{
					this._Valor_nivel_B3.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x0041A73C File Offset: 0x00418B3C
		// (set) Token: 0x0600259F RID: 9631 RVA: 0x0041A750 File Offset: 0x00418B50
		internal virtual TextBox Valor_nivel_B2
		{
			get
			{
				return this._Valor_nivel_B2;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_nivel_B2_Validating);
				if (this._Valor_nivel_B2 != null)
				{
					this._Valor_nivel_B2.Validating -= cancelEventHandler;
				}
				this._Valor_nivel_B2 = value;
				if (this._Valor_nivel_B2 != null)
				{
					this._Valor_nivel_B2.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x0041A79C File Offset: 0x00418B9C
		// (set) Token: 0x060025A1 RID: 9633 RVA: 0x0041A7B0 File Offset: 0x00418BB0
		internal virtual TextBox Valor_nivel_B1
		{
			get
			{
				return this._Valor_nivel_B1;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_nivel_B1_Validating);
				if (this._Valor_nivel_B1 != null)
				{
					this._Valor_nivel_B1.Validating -= cancelEventHandler;
				}
				this._Valor_nivel_B1 = value;
				if (this._Valor_nivel_B1 != null)
				{
					this._Valor_nivel_B1.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x0041A7FC File Offset: 0x00418BFC
		// (set) Token: 0x060025A3 RID: 9635 RVA: 0x0041A810 File Offset: 0x00418C10
		internal virtual TextBox Valor_nivel_desejado
		{
			get
			{
				return this._Valor_nivel_desejado;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_nivel_desejado_Validating);
				if (this._Valor_nivel_desejado != null)
				{
					this._Valor_nivel_desejado.Validating -= cancelEventHandler;
				}
				this._Valor_nivel_desejado = value;
				if (this._Valor_nivel_desejado != null)
				{
					this._Valor_nivel_desejado.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x060025A4 RID: 9636 RVA: 0x0041A85C File Offset: 0x00418C5C
		// (set) Token: 0x060025A5 RID: 9637 RVA: 0x0041A870 File Offset: 0x00418C70
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

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x0041A87C File Offset: 0x00418C7C
		// (set) Token: 0x060025A7 RID: 9639 RVA: 0x0041A890 File Offset: 0x00418C90
		internal virtual Label Label_alm_bomba_1
		{
			get
			{
				return this._Label_alm_bomba_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_alm_bomba_1 = value;
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x0041A89C File Offset: 0x00418C9C
		// (set) Token: 0x060025A9 RID: 9641 RVA: 0x0041A8B0 File Offset: 0x00418CB0
		internal virtual CheckBox CheckBox_alm_rq
		{
			get
			{
				return this._CheckBox_alm_rq;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_alm_rq_CheckedChanged);
				if (this._CheckBox_alm_rq != null)
				{
					this._CheckBox_alm_rq.CheckedChanged -= eventHandler;
				}
				this._CheckBox_alm_rq = value;
				if (this._CheckBox_alm_rq != null)
				{
					this._CheckBox_alm_rq.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x0041A8FC File Offset: 0x00418CFC
		// (set) Token: 0x060025AB RID: 9643 RVA: 0x0041A910 File Offset: 0x00418D10
		internal virtual GroupBox GroupBox_nivel_alto
		{
			get
			{
				return this._GroupBox_nivel_alto;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_nivel_alto = value;
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x0041A91C File Offset: 0x00418D1C
		// (set) Token: 0x060025AD RID: 9645 RVA: 0x0041A930 File Offset: 0x00418D30
		internal virtual TextBox Valor_NA_T
		{
			get
			{
				return this._Valor_NA_T;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_NA_T_Validating);
				if (this._Valor_NA_T != null)
				{
					this._Valor_NA_T.Validating -= cancelEventHandler;
				}
				this._Valor_NA_T = value;
				if (this._Valor_NA_T != null)
				{
					this._Valor_NA_T.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x0041A97C File Offset: 0x00418D7C
		// (set) Token: 0x060025AF RID: 9647 RVA: 0x0041A990 File Offset: 0x00418D90
		internal virtual TextBox Valor_NA_B4
		{
			get
			{
				return this._Valor_NA_B4;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_NA_B4_Validating);
				if (this._Valor_NA_B4 != null)
				{
					this._Valor_NA_B4.Validating -= cancelEventHandler;
				}
				this._Valor_NA_B4 = value;
				if (this._Valor_NA_B4 != null)
				{
					this._Valor_NA_B4.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x0041A9DC File Offset: 0x00418DDC
		// (set) Token: 0x060025B1 RID: 9649 RVA: 0x0041A9F0 File Offset: 0x00418DF0
		internal virtual TextBox Valor_NA_B3
		{
			get
			{
				return this._Valor_NA_B3;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_NA_B3_Validating);
				if (this._Valor_NA_B3 != null)
				{
					this._Valor_NA_B3.Validating -= cancelEventHandler;
				}
				this._Valor_NA_B3 = value;
				if (this._Valor_NA_B3 != null)
				{
					this._Valor_NA_B3.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x060025B2 RID: 9650 RVA: 0x0041AA3C File Offset: 0x00418E3C
		// (set) Token: 0x060025B3 RID: 9651 RVA: 0x0041AA50 File Offset: 0x00418E50
		internal virtual TextBox Valor_NA_B2
		{
			get
			{
				return this._Valor_NA_B2;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_NA_B2_Validating);
				if (this._Valor_NA_B2 != null)
				{
					this._Valor_NA_B2.Validating -= cancelEventHandler;
				}
				this._Valor_NA_B2 = value;
				if (this._Valor_NA_B2 != null)
				{
					this._Valor_NA_B2.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x060025B4 RID: 9652 RVA: 0x0041AA9C File Offset: 0x00418E9C
		// (set) Token: 0x060025B5 RID: 9653 RVA: 0x0041AAB0 File Offset: 0x00418EB0
		internal virtual TextBox Valor_NA_B1
		{
			get
			{
				return this._Valor_NA_B1;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_NA_B1_Validating);
				if (this._Valor_NA_B1 != null)
				{
					this._Valor_NA_B1.Validating -= cancelEventHandler;
				}
				this._Valor_NA_B1 = value;
				if (this._Valor_NA_B1 != null)
				{
					this._Valor_NA_B1.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x060025B6 RID: 9654 RVA: 0x0041AAFC File Offset: 0x00418EFC
		// (set) Token: 0x060025B7 RID: 9655 RVA: 0x0041AB10 File Offset: 0x00418F10
		internal virtual GroupBox GroupBox_nivel_baixo
		{
			get
			{
				return this._GroupBox_nivel_baixo;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_nivel_baixo = value;
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x0041AB1C File Offset: 0x00418F1C
		// (set) Token: 0x060025B9 RID: 9657 RVA: 0x0041AB30 File Offset: 0x00418F30
		internal virtual TextBox Valor_NB_T
		{
			get
			{
				return this._Valor_NB_T;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_NB_T_Validating);
				if (this._Valor_NB_T != null)
				{
					this._Valor_NB_T.Validating -= cancelEventHandler;
				}
				this._Valor_NB_T = value;
				if (this._Valor_NB_T != null)
				{
					this._Valor_NB_T.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x060025BA RID: 9658 RVA: 0x0041AB7C File Offset: 0x00418F7C
		// (set) Token: 0x060025BB RID: 9659 RVA: 0x0041AB90 File Offset: 0x00418F90
		internal virtual TextBox Valor_NB_B4
		{
			get
			{
				return this._Valor_NB_B4;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_NB_B4_Validating);
				if (this._Valor_NB_B4 != null)
				{
					this._Valor_NB_B4.Validating -= cancelEventHandler;
				}
				this._Valor_NB_B4 = value;
				if (this._Valor_NB_B4 != null)
				{
					this._Valor_NB_B4.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x060025BC RID: 9660 RVA: 0x0041ABDC File Offset: 0x00418FDC
		// (set) Token: 0x060025BD RID: 9661 RVA: 0x0041ABF0 File Offset: 0x00418FF0
		internal virtual TextBox Valor_NB_B3
		{
			get
			{
				return this._Valor_NB_B3;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_NB_B3_Validating);
				if (this._Valor_NB_B3 != null)
				{
					this._Valor_NB_B3.Validating -= cancelEventHandler;
				}
				this._Valor_NB_B3 = value;
				if (this._Valor_NB_B3 != null)
				{
					this._Valor_NB_B3.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x060025BE RID: 9662 RVA: 0x0041AC3C File Offset: 0x0041903C
		// (set) Token: 0x060025BF RID: 9663 RVA: 0x0041AC50 File Offset: 0x00419050
		internal virtual TextBox Valor_NB_B2
		{
			get
			{
				return this._Valor_NB_B2;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_NB_B2_Validating);
				if (this._Valor_NB_B2 != null)
				{
					this._Valor_NB_B2.Validating -= cancelEventHandler;
				}
				this._Valor_NB_B2 = value;
				if (this._Valor_NB_B2 != null)
				{
					this._Valor_NB_B2.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x060025C0 RID: 9664 RVA: 0x0041AC9C File Offset: 0x0041909C
		// (set) Token: 0x060025C1 RID: 9665 RVA: 0x0041ACB0 File Offset: 0x004190B0
		internal virtual TextBox Valor_NB_B1
		{
			get
			{
				return this._Valor_NB_B1;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_NB_B1_Validating);
				if (this._Valor_NB_B1 != null)
				{
					this._Valor_NB_B1.Validating -= cancelEventHandler;
				}
				this._Valor_NB_B1 = value;
				if (this._Valor_NB_B1 != null)
				{
					this._Valor_NB_B1.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x060025C2 RID: 9666 RVA: 0x0041ACFC File Offset: 0x004190FC
		// (set) Token: 0x060025C3 RID: 9667 RVA: 0x0041AD10 File Offset: 0x00419110
		internal virtual Label Label_alm_tensao
		{
			get
			{
				return this._Label_alm_tensao;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_alm_tensao = value;
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x060025C4 RID: 9668 RVA: 0x0041AD1C File Offset: 0x0041911C
		// (set) Token: 0x060025C5 RID: 9669 RVA: 0x0041AD30 File Offset: 0x00419130
		internal virtual Label Label_alm_bomba_4
		{
			get
			{
				return this._Label_alm_bomba_4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_alm_bomba_4 = value;
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x060025C6 RID: 9670 RVA: 0x0041AD3C File Offset: 0x0041913C
		// (set) Token: 0x060025C7 RID: 9671 RVA: 0x0041AD50 File Offset: 0x00419150
		internal virtual Label Label_alm_bomba_3
		{
			get
			{
				return this._Label_alm_bomba_3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_alm_bomba_3 = value;
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x060025C8 RID: 9672 RVA: 0x0041AD5C File Offset: 0x0041915C
		// (set) Token: 0x060025C9 RID: 9673 RVA: 0x0041AD70 File Offset: 0x00419170
		internal virtual Label Label_alm_bomba_2
		{
			get
			{
				return this._Label_alm_bomba_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_alm_bomba_2 = value;
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x060025CA RID: 9674 RVA: 0x0041AD7C File Offset: 0x0041917C
		// (set) Token: 0x060025CB RID: 9675 RVA: 0x0041AD90 File Offset: 0x00419190
		internal virtual GroupBox GroupBox_timer_1
		{
			get
			{
				return this._GroupBox_timer_1;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_timer_1 = value;
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x060025CC RID: 9676 RVA: 0x0041AD9C File Offset: 0x0041919C
		// (set) Token: 0x060025CD RID: 9677 RVA: 0x0041ADB0 File Offset: 0x004191B0
		internal virtual GroupBox GroupBox_Liga_B1
		{
			get
			{
				return this._GroupBox_Liga_B1;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_Liga_B1 = value;
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x060025CE RID: 9678 RVA: 0x0041ADBC File Offset: 0x004191BC
		// (set) Token: 0x060025CF RID: 9679 RVA: 0x0041ADD0 File Offset: 0x004191D0
		internal virtual Label Label_faixa1_B1
		{
			get
			{
				return this._Label_faixa1_B1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_faixa1_B1 = value;
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x060025D0 RID: 9680 RVA: 0x0041ADDC File Offset: 0x004191DC
		// (set) Token: 0x060025D1 RID: 9681 RVA: 0x0041ADF0 File Offset: 0x004191F0
		internal virtual TextBox Valor_liga_faixa1_b1
		{
			get
			{
				return this._Valor_liga_faixa1_b1;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_faixa1_b1_Validating);
				if (this._Valor_liga_faixa1_b1 != null)
				{
					this._Valor_liga_faixa1_b1.Validating -= cancelEventHandler;
				}
				this._Valor_liga_faixa1_b1 = value;
				if (this._Valor_liga_faixa1_b1 != null)
				{
					this._Valor_liga_faixa1_b1.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x0041AE3C File Offset: 0x0041923C
		// (set) Token: 0x060025D3 RID: 9683 RVA: 0x0041AE50 File Offset: 0x00419250
		internal virtual GroupBox GroupBox_Desliga_B1
		{
			get
			{
				return this._GroupBox_Desliga_B1;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_Desliga_B1 = value;
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x060025D4 RID: 9684 RVA: 0x0041AE5C File Offset: 0x0041925C
		// (set) Token: 0x060025D5 RID: 9685 RVA: 0x0041AE70 File Offset: 0x00419270
		internal virtual TextBox Valor_desliga_faixa4_b1
		{
			get
			{
				return this._Valor_desliga_faixa4_b1;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_faixa4_b1_Validating);
				if (this._Valor_desliga_faixa4_b1 != null)
				{
					this._Valor_desliga_faixa4_b1.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_faixa4_b1 = value;
				if (this._Valor_desliga_faixa4_b1 != null)
				{
					this._Valor_desliga_faixa4_b1.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x060025D6 RID: 9686 RVA: 0x0041AEBC File Offset: 0x004192BC
		// (set) Token: 0x060025D7 RID: 9687 RVA: 0x0041AED0 File Offset: 0x004192D0
		internal virtual TextBox Valor_desliga_faixa3_b1
		{
			get
			{
				return this._Valor_desliga_faixa3_b1;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_faixa3_b1_Validating);
				if (this._Valor_desliga_faixa3_b1 != null)
				{
					this._Valor_desliga_faixa3_b1.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_faixa3_b1 = value;
				if (this._Valor_desliga_faixa3_b1 != null)
				{
					this._Valor_desliga_faixa3_b1.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x060025D8 RID: 9688 RVA: 0x0041AF1C File Offset: 0x0041931C
		// (set) Token: 0x060025D9 RID: 9689 RVA: 0x0041AF30 File Offset: 0x00419330
		internal virtual TextBox Valor_desliga_faixa2_b1
		{
			get
			{
				return this._Valor_desliga_faixa2_b1;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_faixa2_b1_Validating);
				if (this._Valor_desliga_faixa2_b1 != null)
				{
					this._Valor_desliga_faixa2_b1.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_faixa2_b1 = value;
				if (this._Valor_desliga_faixa2_b1 != null)
				{
					this._Valor_desliga_faixa2_b1.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x0041AF7C File Offset: 0x0041937C
		// (set) Token: 0x060025DB RID: 9691 RVA: 0x0041AF90 File Offset: 0x00419390
		internal virtual TextBox Valor_desliga_faixa1_b1
		{
			get
			{
				return this._Valor_desliga_faixa1_b1;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_faixa1_b1_Validating);
				if (this._Valor_desliga_faixa1_b1 != null)
				{
					this._Valor_desliga_faixa1_b1.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_faixa1_b1 = value;
				if (this._Valor_desliga_faixa1_b1 != null)
				{
					this._Valor_desliga_faixa1_b1.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x0041AFDC File Offset: 0x004193DC
		// (set) Token: 0x060025DD RID: 9693 RVA: 0x0041AFF0 File Offset: 0x004193F0
		internal virtual TextBox Valor_liga_faixa4_b1
		{
			get
			{
				return this._Valor_liga_faixa4_b1;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_faixa4_b1_Validating);
				if (this._Valor_liga_faixa4_b1 != null)
				{
					this._Valor_liga_faixa4_b1.Validating -= cancelEventHandler;
				}
				this._Valor_liga_faixa4_b1 = value;
				if (this._Valor_liga_faixa4_b1 != null)
				{
					this._Valor_liga_faixa4_b1.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x0041B03C File Offset: 0x0041943C
		// (set) Token: 0x060025DF RID: 9695 RVA: 0x0041B050 File Offset: 0x00419450
		internal virtual TextBox Valor_liga_faixa3_b1
		{
			get
			{
				return this._Valor_liga_faixa3_b1;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_faixa3_b1_Validating);
				if (this._Valor_liga_faixa3_b1 != null)
				{
					this._Valor_liga_faixa3_b1.Validating -= cancelEventHandler;
				}
				this._Valor_liga_faixa3_b1 = value;
				if (this._Valor_liga_faixa3_b1 != null)
				{
					this._Valor_liga_faixa3_b1.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x0041B09C File Offset: 0x0041949C
		// (set) Token: 0x060025E1 RID: 9697 RVA: 0x0041B0B0 File Offset: 0x004194B0
		internal virtual TextBox Valor_liga_faixa2_b1
		{
			get
			{
				return this._Valor_liga_faixa2_b1;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_faixa2_b1_Validating);
				if (this._Valor_liga_faixa2_b1 != null)
				{
					this._Valor_liga_faixa2_b1.Validating -= cancelEventHandler;
				}
				this._Valor_liga_faixa2_b1 = value;
				if (this._Valor_liga_faixa2_b1 != null)
				{
					this._Valor_liga_faixa2_b1.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x0041B0FC File Offset: 0x004194FC
		// (set) Token: 0x060025E3 RID: 9699 RVA: 0x0041B110 File Offset: 0x00419510
		internal virtual Label Label_faixa4_B1
		{
			get
			{
				return this._Label_faixa4_B1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_faixa4_B1 = value;
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x0041B11C File Offset: 0x0041951C
		// (set) Token: 0x060025E5 RID: 9701 RVA: 0x0041B130 File Offset: 0x00419530
		internal virtual Label Label_faixa3_B1
		{
			get
			{
				return this._Label_faixa3_B1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_faixa3_B1 = value;
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x0041B13C File Offset: 0x0041953C
		// (set) Token: 0x060025E7 RID: 9703 RVA: 0x0041B150 File Offset: 0x00419550
		internal virtual Label Label_faixa2_B1
		{
			get
			{
				return this._Label_faixa2_B1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_faixa2_B1 = value;
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x060025E8 RID: 9704 RVA: 0x0041B15C File Offset: 0x0041955C
		// (set) Token: 0x060025E9 RID: 9705 RVA: 0x0041B170 File Offset: 0x00419570
		internal virtual GroupBox GroupBox_timer_2
		{
			get
			{
				return this._GroupBox_timer_2;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_timer_2 = value;
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x060025EA RID: 9706 RVA: 0x0041B17C File Offset: 0x0041957C
		// (set) Token: 0x060025EB RID: 9707 RVA: 0x0041B190 File Offset: 0x00419590
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

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x060025EC RID: 9708 RVA: 0x0041B19C File Offset: 0x0041959C
		// (set) Token: 0x060025ED RID: 9709 RVA: 0x0041B1B0 File Offset: 0x004195B0
		internal virtual TextBox Valor_desliga_faixa4_b2
		{
			get
			{
				return this._Valor_desliga_faixa4_b2;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_faixa4_b2_Validating);
				if (this._Valor_desliga_faixa4_b2 != null)
				{
					this._Valor_desliga_faixa4_b2.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_faixa4_b2 = value;
				if (this._Valor_desliga_faixa4_b2 != null)
				{
					this._Valor_desliga_faixa4_b2.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x0041B1FC File Offset: 0x004195FC
		// (set) Token: 0x060025EF RID: 9711 RVA: 0x0041B210 File Offset: 0x00419610
		internal virtual TextBox Valor_desliga_faixa3_b2
		{
			get
			{
				return this._Valor_desliga_faixa3_b2;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_faixa3_b2_Validating);
				if (this._Valor_desliga_faixa3_b2 != null)
				{
					this._Valor_desliga_faixa3_b2.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_faixa3_b2 = value;
				if (this._Valor_desliga_faixa3_b2 != null)
				{
					this._Valor_desliga_faixa3_b2.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x060025F0 RID: 9712 RVA: 0x0041B25C File Offset: 0x0041965C
		// (set) Token: 0x060025F1 RID: 9713 RVA: 0x0041B270 File Offset: 0x00419670
		internal virtual TextBox Valor_desliga_faixa2_b2
		{
			get
			{
				return this._Valor_desliga_faixa2_b2;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_faixa2_b2_Validating);
				if (this._Valor_desliga_faixa2_b2 != null)
				{
					this._Valor_desliga_faixa2_b2.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_faixa2_b2 = value;
				if (this._Valor_desliga_faixa2_b2 != null)
				{
					this._Valor_desliga_faixa2_b2.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x0041B2BC File Offset: 0x004196BC
		// (set) Token: 0x060025F3 RID: 9715 RVA: 0x0041B2D0 File Offset: 0x004196D0
		internal virtual TextBox Valor_desliga_faixa1_b2
		{
			get
			{
				return this._Valor_desliga_faixa1_b2;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_faixa1_b2_Validating);
				if (this._Valor_desliga_faixa1_b2 != null)
				{
					this._Valor_desliga_faixa1_b2.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_faixa1_b2 = value;
				if (this._Valor_desliga_faixa1_b2 != null)
				{
					this._Valor_desliga_faixa1_b2.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x0041B31C File Offset: 0x0041971C
		// (set) Token: 0x060025F5 RID: 9717 RVA: 0x0041B330 File Offset: 0x00419730
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

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x0041B33C File Offset: 0x0041973C
		// (set) Token: 0x060025F7 RID: 9719 RVA: 0x0041B350 File Offset: 0x00419750
		internal virtual TextBox Valor_liga_faixa4_b2
		{
			get
			{
				return this._Valor_liga_faixa4_b2;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_faixa4_b2_Validating);
				if (this._Valor_liga_faixa4_b2 != null)
				{
					this._Valor_liga_faixa4_b2.Validating -= cancelEventHandler;
				}
				this._Valor_liga_faixa4_b2 = value;
				if (this._Valor_liga_faixa4_b2 != null)
				{
					this._Valor_liga_faixa4_b2.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x0041B39C File Offset: 0x0041979C
		// (set) Token: 0x060025F9 RID: 9721 RVA: 0x0041B3B0 File Offset: 0x004197B0
		internal virtual TextBox Valor_liga_faixa3_b2
		{
			get
			{
				return this._Valor_liga_faixa3_b2;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_faixa3_b2_Validating);
				if (this._Valor_liga_faixa3_b2 != null)
				{
					this._Valor_liga_faixa3_b2.Validating -= cancelEventHandler;
				}
				this._Valor_liga_faixa3_b2 = value;
				if (this._Valor_liga_faixa3_b2 != null)
				{
					this._Valor_liga_faixa3_b2.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x0041B3FC File Offset: 0x004197FC
		// (set) Token: 0x060025FB RID: 9723 RVA: 0x0041B410 File Offset: 0x00419810
		internal virtual TextBox Valor_liga_faixa2_b2
		{
			get
			{
				return this._Valor_liga_faixa2_b2;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_faixa2_b2_Validating);
				if (this._Valor_liga_faixa2_b2 != null)
				{
					this._Valor_liga_faixa2_b2.Validating -= cancelEventHandler;
				}
				this._Valor_liga_faixa2_b2 = value;
				if (this._Valor_liga_faixa2_b2 != null)
				{
					this._Valor_liga_faixa2_b2.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x0041B45C File Offset: 0x0041985C
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x0041B470 File Offset: 0x00419870
		internal virtual TextBox Valor_liga_faixa1_b2
		{
			get
			{
				return this._Valor_liga_faixa1_b2;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_faixa1_b2_Validating);
				if (this._Valor_liga_faixa1_b2 != null)
				{
					this._Valor_liga_faixa1_b2.Validating -= cancelEventHandler;
				}
				this._Valor_liga_faixa1_b2 = value;
				if (this._Valor_liga_faixa1_b2 != null)
				{
					this._Valor_liga_faixa1_b2.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x0041B4BC File Offset: 0x004198BC
		// (set) Token: 0x060025FF RID: 9727 RVA: 0x0041B4D0 File Offset: 0x004198D0
		internal virtual Label Label_faixa4_B2
		{
			get
			{
				return this._Label_faixa4_B2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_faixa4_B2 = value;
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x0041B4DC File Offset: 0x004198DC
		// (set) Token: 0x06002601 RID: 9729 RVA: 0x0041B4F0 File Offset: 0x004198F0
		internal virtual Label Label_faixa3_B2
		{
			get
			{
				return this._Label_faixa3_B2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_faixa3_B2 = value;
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x0041B4FC File Offset: 0x004198FC
		// (set) Token: 0x06002603 RID: 9731 RVA: 0x0041B510 File Offset: 0x00419910
		internal virtual Label Label_faixa2_B2
		{
			get
			{
				return this._Label_faixa2_B2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_faixa2_B2 = value;
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x0041B51C File Offset: 0x0041991C
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x0041B530 File Offset: 0x00419930
		internal virtual Label Label_faixa1_B2
		{
			get
			{
				return this._Label_faixa1_B2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_faixa1_B2 = value;
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x0041B53C File Offset: 0x0041993C
		// (set) Token: 0x06002607 RID: 9735 RVA: 0x0041B550 File Offset: 0x00419950
		internal virtual GroupBox GroupBox_timer_4
		{
			get
			{
				return this._GroupBox_timer_4;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_timer_4 = value;
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x0041B55C File Offset: 0x0041995C
		// (set) Token: 0x06002609 RID: 9737 RVA: 0x0041B570 File Offset: 0x00419970
		internal virtual GroupBox GroupBox5
		{
			get
			{
				return this._GroupBox5;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox5 = value;
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x0041B57C File Offset: 0x0041997C
		// (set) Token: 0x0600260B RID: 9739 RVA: 0x0041B590 File Offset: 0x00419990
		internal virtual TextBox Valor_desliga_faixa4_b4
		{
			get
			{
				return this._Valor_desliga_faixa4_b4;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_faixa4_b4_Validating);
				if (this._Valor_desliga_faixa4_b4 != null)
				{
					this._Valor_desliga_faixa4_b4.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_faixa4_b4 = value;
				if (this._Valor_desliga_faixa4_b4 != null)
				{
					this._Valor_desliga_faixa4_b4.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x0041B5DC File Offset: 0x004199DC
		// (set) Token: 0x0600260D RID: 9741 RVA: 0x0041B5F0 File Offset: 0x004199F0
		internal virtual TextBox Valor_desliga_faixa3_b4
		{
			get
			{
				return this._Valor_desliga_faixa3_b4;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_faixa3_b4_Validating);
				if (this._Valor_desliga_faixa3_b4 != null)
				{
					this._Valor_desliga_faixa3_b4.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_faixa3_b4 = value;
				if (this._Valor_desliga_faixa3_b4 != null)
				{
					this._Valor_desliga_faixa3_b4.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x0041B63C File Offset: 0x00419A3C
		// (set) Token: 0x0600260F RID: 9743 RVA: 0x0041B650 File Offset: 0x00419A50
		internal virtual TextBox Valor_desliga_faixa2_b4
		{
			get
			{
				return this._Valor_desliga_faixa2_b4;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_faixa2_b4_Validating);
				if (this._Valor_desliga_faixa2_b4 != null)
				{
					this._Valor_desliga_faixa2_b4.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_faixa2_b4 = value;
				if (this._Valor_desliga_faixa2_b4 != null)
				{
					this._Valor_desliga_faixa2_b4.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x0041B69C File Offset: 0x00419A9C
		// (set) Token: 0x06002611 RID: 9745 RVA: 0x0041B6B0 File Offset: 0x00419AB0
		internal virtual TextBox Valor_desliga_faixa1_b4
		{
			get
			{
				return this._Valor_desliga_faixa1_b4;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_faixa1_b4_Validating);
				if (this._Valor_desliga_faixa1_b4 != null)
				{
					this._Valor_desliga_faixa1_b4.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_faixa1_b4 = value;
				if (this._Valor_desliga_faixa1_b4 != null)
				{
					this._Valor_desliga_faixa1_b4.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x0041B6FC File Offset: 0x00419AFC
		// (set) Token: 0x06002613 RID: 9747 RVA: 0x0041B710 File Offset: 0x00419B10
		internal virtual GroupBox GroupBox6
		{
			get
			{
				return this._GroupBox6;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox6 = value;
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x0041B71C File Offset: 0x00419B1C
		// (set) Token: 0x06002615 RID: 9749 RVA: 0x0041B730 File Offset: 0x00419B30
		internal virtual TextBox Valor_liga_faixa4_b4
		{
			get
			{
				return this._Valor_liga_faixa4_b4;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_faixa4_b4_Validating);
				if (this._Valor_liga_faixa4_b4 != null)
				{
					this._Valor_liga_faixa4_b4.Validating -= cancelEventHandler;
				}
				this._Valor_liga_faixa4_b4 = value;
				if (this._Valor_liga_faixa4_b4 != null)
				{
					this._Valor_liga_faixa4_b4.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06002616 RID: 9750 RVA: 0x0041B77C File Offset: 0x00419B7C
		// (set) Token: 0x06002617 RID: 9751 RVA: 0x0041B790 File Offset: 0x00419B90
		internal virtual TextBox Valor_liga_faixa3_b4
		{
			get
			{
				return this._Valor_liga_faixa3_b4;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_faixa3_b4_Validating);
				if (this._Valor_liga_faixa3_b4 != null)
				{
					this._Valor_liga_faixa3_b4.Validating -= cancelEventHandler;
				}
				this._Valor_liga_faixa3_b4 = value;
				if (this._Valor_liga_faixa3_b4 != null)
				{
					this._Valor_liga_faixa3_b4.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x0041B7DC File Offset: 0x00419BDC
		// (set) Token: 0x06002619 RID: 9753 RVA: 0x0041B7F0 File Offset: 0x00419BF0
		internal virtual TextBox Valor_liga_faixa2_b4
		{
			get
			{
				return this._Valor_liga_faixa2_b4;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_faixa2_b4_Validating);
				if (this._Valor_liga_faixa2_b4 != null)
				{
					this._Valor_liga_faixa2_b4.Validating -= cancelEventHandler;
				}
				this._Valor_liga_faixa2_b4 = value;
				if (this._Valor_liga_faixa2_b4 != null)
				{
					this._Valor_liga_faixa2_b4.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x0041B83C File Offset: 0x00419C3C
		// (set) Token: 0x0600261B RID: 9755 RVA: 0x0041B850 File Offset: 0x00419C50
		internal virtual TextBox Valor_liga_faixa1_b4
		{
			get
			{
				return this._Valor_liga_faixa1_b4;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_faixa1_b4_Validating);
				if (this._Valor_liga_faixa1_b4 != null)
				{
					this._Valor_liga_faixa1_b4.Validating -= cancelEventHandler;
				}
				this._Valor_liga_faixa1_b4 = value;
				if (this._Valor_liga_faixa1_b4 != null)
				{
					this._Valor_liga_faixa1_b4.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x0041B89C File Offset: 0x00419C9C
		// (set) Token: 0x0600261D RID: 9757 RVA: 0x0041B8B0 File Offset: 0x00419CB0
		internal virtual Label Label_faixa4_B4
		{
			get
			{
				return this._Label_faixa4_B4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_faixa4_B4 = value;
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x0041B8BC File Offset: 0x00419CBC
		// (set) Token: 0x0600261F RID: 9759 RVA: 0x0041B8D0 File Offset: 0x00419CD0
		internal virtual Label Label_faixa3_B4
		{
			get
			{
				return this._Label_faixa3_B4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_faixa3_B4 = value;
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x0041B8DC File Offset: 0x00419CDC
		// (set) Token: 0x06002621 RID: 9761 RVA: 0x0041B8F0 File Offset: 0x00419CF0
		internal virtual Label Label_faixa2_B4
		{
			get
			{
				return this._Label_faixa2_B4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_faixa2_B4 = value;
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x0041B8FC File Offset: 0x00419CFC
		// (set) Token: 0x06002623 RID: 9763 RVA: 0x0041B910 File Offset: 0x00419D10
		internal virtual Label Label_faixa1_B4
		{
			get
			{
				return this._Label_faixa1_B4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_faixa1_B4 = value;
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x0041B91C File Offset: 0x00419D1C
		// (set) Token: 0x06002625 RID: 9765 RVA: 0x0041B930 File Offset: 0x00419D30
		internal virtual GroupBox GroupBox_timer_3
		{
			get
			{
				return this._GroupBox_timer_3;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_timer_3 = value;
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06002626 RID: 9766 RVA: 0x0041B93C File Offset: 0x00419D3C
		// (set) Token: 0x06002627 RID: 9767 RVA: 0x0041B950 File Offset: 0x00419D50
		internal virtual GroupBox GroupBox8
		{
			get
			{
				return this._GroupBox8;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox8 = value;
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x0041B95C File Offset: 0x00419D5C
		// (set) Token: 0x06002629 RID: 9769 RVA: 0x0041B970 File Offset: 0x00419D70
		internal virtual TextBox Valor_desliga_faixa4_b3
		{
			get
			{
				return this._Valor_desliga_faixa4_b3;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_faixa4_b3_Validating);
				if (this._Valor_desliga_faixa4_b3 != null)
				{
					this._Valor_desliga_faixa4_b3.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_faixa4_b3 = value;
				if (this._Valor_desliga_faixa4_b3 != null)
				{
					this._Valor_desliga_faixa4_b3.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x0041B9BC File Offset: 0x00419DBC
		// (set) Token: 0x0600262B RID: 9771 RVA: 0x0041B9D0 File Offset: 0x00419DD0
		internal virtual TextBox Valor_desliga_faixa3_b3
		{
			get
			{
				return this._Valor_desliga_faixa3_b3;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_faixa3_b3_Validating);
				if (this._Valor_desliga_faixa3_b3 != null)
				{
					this._Valor_desliga_faixa3_b3.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_faixa3_b3 = value;
				if (this._Valor_desliga_faixa3_b3 != null)
				{
					this._Valor_desliga_faixa3_b3.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x0600262C RID: 9772 RVA: 0x0041BA1C File Offset: 0x00419E1C
		// (set) Token: 0x0600262D RID: 9773 RVA: 0x0041BA30 File Offset: 0x00419E30
		internal virtual TextBox Valor_desliga_faixa2_b3
		{
			get
			{
				return this._Valor_desliga_faixa2_b3;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_faixa2_b3_Validating);
				if (this._Valor_desliga_faixa2_b3 != null)
				{
					this._Valor_desliga_faixa2_b3.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_faixa2_b3 = value;
				if (this._Valor_desliga_faixa2_b3 != null)
				{
					this._Valor_desliga_faixa2_b3.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x0041BA7C File Offset: 0x00419E7C
		// (set) Token: 0x0600262F RID: 9775 RVA: 0x0041BA90 File Offset: 0x00419E90
		internal virtual TextBox Valor_desliga_faixa1_b3
		{
			get
			{
				return this._Valor_desliga_faixa1_b3;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_faixa1_b3_Validating);
				if (this._Valor_desliga_faixa1_b3 != null)
				{
					this._Valor_desliga_faixa1_b3.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_faixa1_b3 = value;
				if (this._Valor_desliga_faixa1_b3 != null)
				{
					this._Valor_desliga_faixa1_b3.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06002630 RID: 9776 RVA: 0x0041BADC File Offset: 0x00419EDC
		// (set) Token: 0x06002631 RID: 9777 RVA: 0x0041BAF0 File Offset: 0x00419EF0
		internal virtual GroupBox GroupBox9
		{
			get
			{
				return this._GroupBox9;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox9 = value;
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06002632 RID: 9778 RVA: 0x0041BAFC File Offset: 0x00419EFC
		// (set) Token: 0x06002633 RID: 9779 RVA: 0x0041BB10 File Offset: 0x00419F10
		internal virtual TextBox Valor_liga_faixa4_b3
		{
			get
			{
				return this._Valor_liga_faixa4_b3;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_faixa4_b3_Validating);
				if (this._Valor_liga_faixa4_b3 != null)
				{
					this._Valor_liga_faixa4_b3.Validating -= cancelEventHandler;
				}
				this._Valor_liga_faixa4_b3 = value;
				if (this._Valor_liga_faixa4_b3 != null)
				{
					this._Valor_liga_faixa4_b3.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x0041BB5C File Offset: 0x00419F5C
		// (set) Token: 0x06002635 RID: 9781 RVA: 0x0041BB70 File Offset: 0x00419F70
		internal virtual TextBox Valor_liga_faixa3_b3
		{
			get
			{
				return this._Valor_liga_faixa3_b3;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_faixa3_b3_Validating);
				if (this._Valor_liga_faixa3_b3 != null)
				{
					this._Valor_liga_faixa3_b3.Validating -= cancelEventHandler;
				}
				this._Valor_liga_faixa3_b3 = value;
				if (this._Valor_liga_faixa3_b3 != null)
				{
					this._Valor_liga_faixa3_b3.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x0041BBBC File Offset: 0x00419FBC
		// (set) Token: 0x06002637 RID: 9783 RVA: 0x0041BBD0 File Offset: 0x00419FD0
		internal virtual TextBox Valor_liga_faixa2_b3
		{
			get
			{
				return this._Valor_liga_faixa2_b3;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_faixa2_b3_Validating);
				if (this._Valor_liga_faixa2_b3 != null)
				{
					this._Valor_liga_faixa2_b3.Validating -= cancelEventHandler;
				}
				this._Valor_liga_faixa2_b3 = value;
				if (this._Valor_liga_faixa2_b3 != null)
				{
					this._Valor_liga_faixa2_b3.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x0041BC1C File Offset: 0x0041A01C
		// (set) Token: 0x06002639 RID: 9785 RVA: 0x0041BC30 File Offset: 0x0041A030
		internal virtual TextBox Valor_liga_faixa1_b3
		{
			get
			{
				return this._Valor_liga_faixa1_b3;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_faixa1_b3_Validating);
				if (this._Valor_liga_faixa1_b3 != null)
				{
					this._Valor_liga_faixa1_b3.Validating -= cancelEventHandler;
				}
				this._Valor_liga_faixa1_b3 = value;
				if (this._Valor_liga_faixa1_b3 != null)
				{
					this._Valor_liga_faixa1_b3.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x0041BC7C File Offset: 0x0041A07C
		// (set) Token: 0x0600263B RID: 9787 RVA: 0x0041BC90 File Offset: 0x0041A090
		internal virtual Label Label_faixa4_B3
		{
			get
			{
				return this._Label_faixa4_B3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_faixa4_B3 = value;
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x0041BC9C File Offset: 0x0041A09C
		// (set) Token: 0x0600263D RID: 9789 RVA: 0x0041BCB0 File Offset: 0x0041A0B0
		internal virtual Label Label_faixa3_B3
		{
			get
			{
				return this._Label_faixa3_B3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_faixa3_B3 = value;
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x0600263E RID: 9790 RVA: 0x0041BCBC File Offset: 0x0041A0BC
		// (set) Token: 0x0600263F RID: 9791 RVA: 0x0041BCD0 File Offset: 0x0041A0D0
		internal virtual Label Label_faixa2_B3
		{
			get
			{
				return this._Label_faixa2_B3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_faixa2_B3 = value;
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06002640 RID: 9792 RVA: 0x0041BCDC File Offset: 0x0041A0DC
		// (set) Token: 0x06002641 RID: 9793 RVA: 0x0041BCF0 File Offset: 0x0041A0F0
		internal virtual Label Label_faixa1_B3
		{
			get
			{
				return this._Label_faixa1_B3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_faixa1_B3 = value;
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06002642 RID: 9794 RVA: 0x0041BCFC File Offset: 0x0041A0FC
		// (set) Token: 0x06002643 RID: 9795 RVA: 0x0041BD10 File Offset: 0x0041A110
		internal virtual GroupBox GroupBox_ponta
		{
			get
			{
				return this._GroupBox_ponta;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_ponta = value;
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06002644 RID: 9796 RVA: 0x0041BD1C File Offset: 0x0041A11C
		// (set) Token: 0x06002645 RID: 9797 RVA: 0x0041BD30 File Offset: 0x0041A130
		internal virtual GroupBox Desliga_ponta
		{
			get
			{
				return this._Desliga_ponta;
			}
			[MethodImpl(32)]
			set
			{
				this._Desliga_ponta = value;
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06002646 RID: 9798 RVA: 0x0041BD3C File Offset: 0x0041A13C
		// (set) Token: 0x06002647 RID: 9799 RVA: 0x0041BD50 File Offset: 0x0041A150
		internal virtual TextBox Valor_desliga_ponta
		{
			get
			{
				return this._Valor_desliga_ponta;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_desliga_ponta_Validating);
				if (this._Valor_desliga_ponta != null)
				{
					this._Valor_desliga_ponta.Validating -= cancelEventHandler;
				}
				this._Valor_desliga_ponta = value;
				if (this._Valor_desliga_ponta != null)
				{
					this._Valor_desliga_ponta.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06002648 RID: 9800 RVA: 0x0041BD9C File Offset: 0x0041A19C
		// (set) Token: 0x06002649 RID: 9801 RVA: 0x0041BDB0 File Offset: 0x0041A1B0
		internal virtual GroupBox Liga_ponta
		{
			get
			{
				return this._Liga_ponta;
			}
			[MethodImpl(32)]
			set
			{
				this._Liga_ponta = value;
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x0041BDBC File Offset: 0x0041A1BC
		// (set) Token: 0x0600264B RID: 9803 RVA: 0x0041BDD0 File Offset: 0x0041A1D0
		internal virtual CheckBox CheckBox_horario_ponta
		{
			get
			{
				return this._CheckBox_horario_ponta;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_horario_ponta_CheckedChanged);
				if (this._CheckBox_horario_ponta != null)
				{
					this._CheckBox_horario_ponta.CheckedChanged -= eventHandler;
				}
				this._CheckBox_horario_ponta = value;
				if (this._CheckBox_horario_ponta != null)
				{
					this._CheckBox_horario_ponta.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x0041BE1C File Offset: 0x0041A21C
		// (set) Token: 0x0600264D RID: 9805 RVA: 0x0041BE30 File Offset: 0x0041A230
		internal virtual GroupBox Grupo_temperaturas
		{
			get
			{
				return this._Grupo_temperaturas;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_temperaturas = value;
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x0041BE3C File Offset: 0x0041A23C
		// (set) Token: 0x0600264F RID: 9807 RVA: 0x0041BE50 File Offset: 0x0041A250
		internal virtual GroupBox Grupo_temp
		{
			get
			{
				return this._Grupo_temp;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_temp = value;
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x0041BE5C File Offset: 0x0041A25C
		// (set) Token: 0x06002651 RID: 9809 RVA: 0x0041BE70 File Offset: 0x0041A270
		internal virtual TextBox Valor_Temp_B4
		{
			get
			{
				return this._Valor_Temp_B4;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_Temp_B4_Validating);
				if (this._Valor_Temp_B4 != null)
				{
					this._Valor_Temp_B4.Validating -= cancelEventHandler;
				}
				this._Valor_Temp_B4 = value;
				if (this._Valor_Temp_B4 != null)
				{
					this._Valor_Temp_B4.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06002652 RID: 9810 RVA: 0x0041BEBC File Offset: 0x0041A2BC
		// (set) Token: 0x06002653 RID: 9811 RVA: 0x0041BED0 File Offset: 0x0041A2D0
		internal virtual TextBox Valor_Temp_B3
		{
			get
			{
				return this._Valor_Temp_B3;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_Temp_B3_Validating);
				if (this._Valor_Temp_B3 != null)
				{
					this._Valor_Temp_B3.Validating -= cancelEventHandler;
				}
				this._Valor_Temp_B3 = value;
				if (this._Valor_Temp_B3 != null)
				{
					this._Valor_Temp_B3.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06002654 RID: 9812 RVA: 0x0041BF1C File Offset: 0x0041A31C
		// (set) Token: 0x06002655 RID: 9813 RVA: 0x0041BF30 File Offset: 0x0041A330
		internal virtual TextBox Valor_Temp_B2
		{
			get
			{
				return this._Valor_Temp_B2;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_Temp_B2_Validating);
				if (this._Valor_Temp_B2 != null)
				{
					this._Valor_Temp_B2.Validating -= cancelEventHandler;
				}
				this._Valor_Temp_B2 = value;
				if (this._Valor_Temp_B2 != null)
				{
					this._Valor_Temp_B2.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06002656 RID: 9814 RVA: 0x0041BF7C File Offset: 0x0041A37C
		// (set) Token: 0x06002657 RID: 9815 RVA: 0x0041BF90 File Offset: 0x0041A390
		internal virtual TextBox Valor_Temp_B1
		{
			get
			{
				return this._Valor_Temp_B1;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_Temp_B1_Validating);
				if (this._Valor_Temp_B1 != null)
				{
					this._Valor_Temp_B1.Validating -= cancelEventHandler;
				}
				this._Valor_Temp_B1 = value;
				if (this._Valor_Temp_B1 != null)
				{
					this._Valor_Temp_B1.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06002658 RID: 9816 RVA: 0x0041BFDC File Offset: 0x0041A3DC
		// (set) Token: 0x06002659 RID: 9817 RVA: 0x0041BFF0 File Offset: 0x0041A3F0
		internal virtual CheckBox CheckBox_habilita_temperatura
		{
			get
			{
				return this._CheckBox_habilita_temperatura;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_habilita_temperatura_CheckedChanged);
				if (this._CheckBox_habilita_temperatura != null)
				{
					this._CheckBox_habilita_temperatura.CheckedChanged -= eventHandler;
				}
				this._CheckBox_habilita_temperatura = value;
				if (this._CheckBox_habilita_temperatura != null)
				{
					this._CheckBox_habilita_temperatura.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x0600265A RID: 9818 RVA: 0x0041C03C File Offset: 0x0041A43C
		// (set) Token: 0x0600265B RID: 9819 RVA: 0x0041C050 File Offset: 0x0041A450
		internal virtual Label Label_temp_bomba_4
		{
			get
			{
				return this._Label_temp_bomba_4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_temp_bomba_4 = value;
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x0600265C RID: 9820 RVA: 0x0041C05C File Offset: 0x0041A45C
		// (set) Token: 0x0600265D RID: 9821 RVA: 0x0041C070 File Offset: 0x0041A470
		internal virtual Label Label_temp_bomba_3
		{
			get
			{
				return this._Label_temp_bomba_3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_temp_bomba_3 = value;
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x0600265E RID: 9822 RVA: 0x0041C07C File Offset: 0x0041A47C
		// (set) Token: 0x0600265F RID: 9823 RVA: 0x0041C090 File Offset: 0x0041A490
		internal virtual Label Label_temp_bomba_2
		{
			get
			{
				return this._Label_temp_bomba_2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_temp_bomba_2 = value;
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06002660 RID: 9824 RVA: 0x0041C09C File Offset: 0x0041A49C
		// (set) Token: 0x06002661 RID: 9825 RVA: 0x0041C0B0 File Offset: 0x0041A4B0
		internal virtual Label Label_temp_bomba_1
		{
			get
			{
				return this._Label_temp_bomba_1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_temp_bomba_1 = value;
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06002662 RID: 9826 RVA: 0x0041C0BC File Offset: 0x0041A4BC
		// (set) Token: 0x06002663 RID: 9827 RVA: 0x0041C0D0 File Offset: 0x0041A4D0
		internal virtual GroupBox GroupBox_opcoes
		{
			get
			{
				return this._GroupBox_opcoes;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_opcoes = value;
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06002664 RID: 9828 RVA: 0x0041C0DC File Offset: 0x0041A4DC
		// (set) Token: 0x06002665 RID: 9829 RVA: 0x0041C0F0 File Offset: 0x0041A4F0
		internal virtual CheckBox CheckBox_alarmes
		{
			get
			{
				return this._CheckBox_alarmes;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_alarmes_CheckedChanged);
				if (this._CheckBox_alarmes != null)
				{
					this._CheckBox_alarmes.CheckedChanged -= eventHandler;
				}
				this._CheckBox_alarmes = value;
				if (this._CheckBox_alarmes != null)
				{
					this._CheckBox_alarmes.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06002666 RID: 9830 RVA: 0x0041C13C File Offset: 0x0041A53C
		// (set) Token: 0x06002667 RID: 9831 RVA: 0x0041C150 File Offset: 0x0041A550
		internal virtual CheckBox CheckBox_ponta
		{
			get
			{
				return this._CheckBox_ponta;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_ponta_CheckedChanged);
				if (this._CheckBox_ponta != null)
				{
					this._CheckBox_ponta.CheckedChanged -= eventHandler;
				}
				this._CheckBox_ponta = value;
				if (this._CheckBox_ponta != null)
				{
					this._CheckBox_ponta.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06002668 RID: 9832 RVA: 0x0041C19C File Offset: 0x0041A59C
		// (set) Token: 0x06002669 RID: 9833 RVA: 0x0041C1B0 File Offset: 0x0041A5B0
		internal virtual CheckBox CheckBox_timer
		{
			get
			{
				return this._CheckBox_timer;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_timer_CheckedChanged);
				if (this._CheckBox_timer != null)
				{
					this._CheckBox_timer.CheckedChanged -= eventHandler;
				}
				this._CheckBox_timer = value;
				if (this._CheckBox_timer != null)
				{
					this._CheckBox_timer.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x0041C1FC File Offset: 0x0041A5FC
		// (set) Token: 0x0600266B RID: 9835 RVA: 0x0041C210 File Offset: 0x0041A610
		internal virtual Button Button_escrever
		{
			get
			{
				return this._Button_escrever;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_escrever_Click);
				if (this._Button_escrever != null)
				{
					this._Button_escrever.Click -= eventHandler;
				}
				this._Button_escrever = value;
				if (this._Button_escrever != null)
				{
					this._Button_escrever.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x0041C25C File Offset: 0x0041A65C
		// (set) Token: 0x0600266D RID: 9837 RVA: 0x0041C270 File Offset: 0x0041A670
		internal virtual Button Button_ler
		{
			get
			{
				return this._Button_ler;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_ler_Click);
				if (this._Button_ler != null)
				{
					this._Button_ler.Click -= eventHandler;
				}
				this._Button_ler = value;
				if (this._Button_ler != null)
				{
					this._Button_ler.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x0041C2BC File Offset: 0x0041A6BC
		// (set) Token: 0x0600266F RID: 9839 RVA: 0x0041C2D0 File Offset: 0x0041A6D0
		internal virtual CheckBox CheckBox_temperatura
		{
			get
			{
				return this._CheckBox_temperatura;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_temperatura_CheckedChanged);
				if (this._CheckBox_temperatura != null)
				{
					this._CheckBox_temperatura.CheckedChanged -= eventHandler;
				}
				this._CheckBox_temperatura = value;
				if (this._CheckBox_temperatura != null)
				{
					this._CheckBox_temperatura.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06002670 RID: 9840 RVA: 0x0041C31C File Offset: 0x0041A71C
		// (set) Token: 0x06002671 RID: 9841 RVA: 0x0041C330 File Offset: 0x0041A730
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

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06002672 RID: 9842 RVA: 0x0041C33C File Offset: 0x0041A73C
		// (set) Token: 0x06002673 RID: 9843 RVA: 0x0041C350 File Offset: 0x0041A750
		internal virtual VScrollBar VScroll_end_mestre
		{
			get
			{
				return this._VScroll_end_mestre;
			}
			[MethodImpl(32)]
			set
			{
				ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.VScroll_end_mestre_Scroll);
				if (this._VScroll_end_mestre != null)
				{
					this._VScroll_end_mestre.Scroll -= scrollEventHandler;
				}
				this._VScroll_end_mestre = value;
				if (this._VScroll_end_mestre != null)
				{
					this._VScroll_end_mestre.Scroll += scrollEventHandler;
				}
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x0041C39C File Offset: 0x0041A79C
		// (set) Token: 0x06002675 RID: 9845 RVA: 0x0041C3B0 File Offset: 0x0041A7B0
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
				EventHandler eventHandler = new EventHandler(this.Valor_end_mestre_TextChanged);
				if (this._Valor_end_mestre != null)
				{
					this._Valor_end_mestre.Validating -= cancelEventHandler;
					this._Valor_end_mestre.TextChanged -= eventHandler;
				}
				this._Valor_end_mestre = value;
				if (this._Valor_end_mestre != null)
				{
					this._Valor_end_mestre.Validating += cancelEventHandler;
					this._Valor_end_mestre.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x0041C420 File Offset: 0x0041A820
		// (set) Token: 0x06002677 RID: 9847 RVA: 0x0041C434 File Offset: 0x0041A834
		internal virtual TextBox Valor_liga_ponta
		{
			get
			{
				return this._Valor_liga_ponta;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_liga_ponta_Validating);
				if (this._Valor_liga_ponta != null)
				{
					this._Valor_liga_ponta.Validating -= cancelEventHandler;
				}
				this._Valor_liga_ponta = value;
				if (this._Valor_liga_ponta != null)
				{
					this._Valor_liga_ponta.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x0041C480 File Offset: 0x0041A880
		// (set) Token: 0x06002679 RID: 9849 RVA: 0x0041C494 File Offset: 0x0041A894
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

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x0041C4A0 File Offset: 0x0041A8A0
		// (set) Token: 0x0600267B RID: 9851 RVA: 0x0041C4B4 File Offset: 0x0041A8B4
		internal virtual CheckBox CheckBox_setpoints
		{
			get
			{
				return this._CheckBox_setpoints;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_setpoints_CheckedChanged);
				if (this._CheckBox_setpoints != null)
				{
					this._CheckBox_setpoints.CheckedChanged -= eventHandler;
				}
				this._CheckBox_setpoints = value;
				if (this._CheckBox_setpoints != null)
				{
					this._CheckBox_setpoints.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x0600267C RID: 9852 RVA: 0x0041C500 File Offset: 0x0041A900
		// (set) Token: 0x0600267D RID: 9853 RVA: 0x0041C514 File Offset: 0x0041A914
		internal virtual GroupBox Grupo_relogio
		{
			get
			{
				return this._Grupo_relogio;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_relogio = value;
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x0600267E RID: 9854 RVA: 0x0041C520 File Offset: 0x0041A920
		// (set) Token: 0x0600267F RID: 9855 RVA: 0x0041C534 File Offset: 0x0041A934
		internal virtual Timer Ctrl_relogio
		{
			get
			{
				return this._Ctrl_relogio;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Ctrl_relogio_Tick);
				if (this._Ctrl_relogio != null)
				{
					this._Ctrl_relogio.Tick -= eventHandler;
				}
				this._Ctrl_relogio = value;
				if (this._Ctrl_relogio != null)
				{
					this._Ctrl_relogio.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x0041C580 File Offset: 0x0041A980
		// (set) Token: 0x06002681 RID: 9857 RVA: 0x0041C594 File Offset: 0x0041A994
		internal virtual TextBox Valor_hora
		{
			get
			{
				return this._Valor_hora;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_hora_Validating);
				if (this._Valor_hora != null)
				{
					this._Valor_hora.Validating -= cancelEventHandler;
				}
				this._Valor_hora = value;
				if (this._Valor_hora != null)
				{
					this._Valor_hora.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06002682 RID: 9858 RVA: 0x0041C5E0 File Offset: 0x0041A9E0
		// (set) Token: 0x06002683 RID: 9859 RVA: 0x0041C5F4 File Offset: 0x0041A9F4
		internal virtual TextBox Valor_data
		{
			get
			{
				return this._Valor_data;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.Valor_data_Validating);
				if (this._Valor_data != null)
				{
					this._Valor_data.Validating -= cancelEventHandler;
				}
				this._Valor_data = value;
				if (this._Valor_data != null)
				{
					this._Valor_data.Validating += cancelEventHandler;
				}
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06002684 RID: 9860 RVA: 0x0041C640 File Offset: 0x0041AA40
		// (set) Token: 0x06002685 RID: 9861 RVA: 0x0041C654 File Offset: 0x0041AA54
		internal virtual Label Label_hora
		{
			get
			{
				return this._Label_hora;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_hora = value;
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x0041C660 File Offset: 0x0041AA60
		// (set) Token: 0x06002687 RID: 9863 RVA: 0x0041C674 File Offset: 0x0041AA74
		internal virtual Label Label_data
		{
			get
			{
				return this._Label_data;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_data = value;
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x0041C680 File Offset: 0x0041AA80
		// (set) Token: 0x06002689 RID: 9865 RVA: 0x0041C694 File Offset: 0x0041AA94
		internal virtual CheckBox CheckBox_relogio
		{
			get
			{
				return this._CheckBox_relogio;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_relogio_CheckedChanged);
				if (this._CheckBox_relogio != null)
				{
					this._CheckBox_relogio.CheckedChanged -= eventHandler;
				}
				this._CheckBox_relogio = value;
				if (this._CheckBox_relogio != null)
				{
					this._CheckBox_relogio.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x0041C6E0 File Offset: 0x0041AAE0
		// (set) Token: 0x0600268B RID: 9867 RVA: 0x0041C6F4 File Offset: 0x0041AAF4
		internal virtual Button Button_atualiza_relogio_micro
		{
			get
			{
				return this._Button_atualiza_relogio_micro;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_atualiza_relogio_micro_Click);
				if (this._Button_atualiza_relogio_micro != null)
				{
					this._Button_atualiza_relogio_micro.Click -= eventHandler;
				}
				this._Button_atualiza_relogio_micro = value;
				if (this._Button_atualiza_relogio_micro != null)
				{
					this._Button_atualiza_relogio_micro.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x0600268C RID: 9868 RVA: 0x0041C740 File Offset: 0x0041AB40
		// (set) Token: 0x0600268D RID: 9869 RVA: 0x0041C754 File Offset: 0x0041AB54
		internal virtual Button Button_bloqueio_relogio
		{
			get
			{
				return this._Button_bloqueio_relogio;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_bloqueio_relogio_Click);
				if (this._Button_bloqueio_relogio != null)
				{
					this._Button_bloqueio_relogio.Click -= eventHandler;
				}
				this._Button_bloqueio_relogio = value;
				if (this._Button_bloqueio_relogio != null)
				{
					this._Button_bloqueio_relogio.Click += eventHandler;
				}
			}
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x0041C7A0 File Offset: 0x0041ABA0
		private void Equip_VA220_ope_Load(object sender, EventArgs e)
		{
			this.VScroll_end_estacao.Maximum = 200;
			this.VScroll_end_estacao.Minimum = 0;
			this.VScroll_end_mestre.Maximum = 200;
			this.VScroll_end_mestre.Minimum = 0;
			this.Limpa_estrutura_ope_VA220();
			this.Atualiza_tela_ope_VA220();
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x0041C7F4 File Offset: 0x0041ABF4
		private void Valor_liga_faixa1_b1_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_liga[1, 1] = "";
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x0041C868 File Offset: 0x0041AC68
		private void Valor_liga_faixa2_b1_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_liga[1, 2] = "";
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x0041C8DC File Offset: 0x0041ACDC
		private void Valor_liga_faixa3_b1_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_liga[1, 3] = "";
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x0041C950 File Offset: 0x0041AD50
		private void Valor_liga_faixa4_b1_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_liga[1, 4] = "";
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x0041C9C4 File Offset: 0x0041ADC4
		private void Valor_liga_faixa1_b2_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_liga[2, 1] = "";
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x0041CA38 File Offset: 0x0041AE38
		private void Valor_liga_faixa2_b2_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_liga[2, 2] = "";
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x0041CAAC File Offset: 0x0041AEAC
		private void Valor_liga_faixa3_b2_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_liga[2, 3] = "";
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x0041CB20 File Offset: 0x0041AF20
		private void Valor_liga_faixa4_b2_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_liga[2, 4] = "";
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x0041CB94 File Offset: 0x0041AF94
		private void Valor_liga_faixa1_b3_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_liga[3, 1] = "";
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x0041CC08 File Offset: 0x0041B008
		private void Valor_liga_faixa2_b3_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_liga[3, 2] = "";
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x0041CC7C File Offset: 0x0041B07C
		private void Valor_liga_faixa3_b3_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_liga[3, 3] = "";
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x0041CCF0 File Offset: 0x0041B0F0
		private void Valor_liga_faixa4_b3_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_liga[3, 4] = "";
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x0041CD64 File Offset: 0x0041B164
		private void Valor_liga_faixa1_b4_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_liga[4, 1] = "";
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x0041CDD8 File Offset: 0x0041B1D8
		private void Valor_liga_faixa2_b4_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_liga[4, 2] = "";
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x0041CE4C File Offset: 0x0041B24C
		private void Valor_liga_faixa3_b4_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_liga[4, 3] = "";
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x0041CEC0 File Offset: 0x0041B2C0
		private void Valor_liga_faixa4_b4_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_liga[4, 4] = "";
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x0041CF34 File Offset: 0x0041B334
		private void Valor_desliga_faixa1_b1_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_desliga[1, 1] = "";
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x0041CFA8 File Offset: 0x0041B3A8
		private void Valor_desliga_faixa2_b1_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_desliga[1, 2] = "";
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x0041D01C File Offset: 0x0041B41C
		private void Valor_desliga_faixa3_b1_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_desliga[1, 3] = "";
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x0041D090 File Offset: 0x0041B490
		private void Valor_desliga_faixa4_b1_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_desliga[1, 4] = "";
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x0041D104 File Offset: 0x0041B504
		private void Valor_desliga_faixa1_b2_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_desliga[2, 1] = "";
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x0041D178 File Offset: 0x0041B578
		private void Valor_desliga_faixa2_b2_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_desliga[2, 2] = "";
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x0041D1EC File Offset: 0x0041B5EC
		private void Valor_desliga_faixa3_b2_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_desliga[2, 3] = "";
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x0041D260 File Offset: 0x0041B660
		private void Valor_desliga_faixa4_b2_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_desliga[2, 4] = "";
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x0041D2D4 File Offset: 0x0041B6D4
		private void Valor_desliga_faixa1_b3_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_desliga[3, 1] = "";
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x0041D348 File Offset: 0x0041B748
		private void Valor_desliga_faixa2_b3_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_desliga[3, 2] = "";
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x0041D3BC File Offset: 0x0041B7BC
		private void Valor_desliga_faixa3_b3_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_desliga[3, 3] = "";
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x0041D430 File Offset: 0x0041B830
		private void Valor_desliga_faixa4_b3_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_desliga[3, 4] = "";
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x0041D4A4 File Offset: 0x0041B8A4
		private void Valor_desliga_faixa1_b4_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_desliga[4, 1] = "";
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x0041D518 File Offset: 0x0041B918
		private void Valor_desliga_faixa2_b4_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_desliga[4, 2] = "";
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x0041D58C File Offset: 0x0041B98C
		private void Valor_desliga_faixa3_b4_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_desliga[4, 3] = "";
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x0041D600 File Offset: 0x0041BA00
		private void Valor_desliga_faixa4_b4_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Timer_desliga[4, 4] = "";
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x0041D674 File Offset: 0x0041BA74
		public string Verifica_horario(string hora, bool ativa_msg)
		{
			int num = 0;
			string text = "";
			int num2 = 0;
			object obj = null;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				text = Strings.FormatDateTime(Conversions.ToDate(hora), (Microsoft.VisualBasic.DateFormat)4);
				goto IL_6F;
				IL_16:
				if (!ativa_msg)
				{
									}
				Interaction.MsgBox("Digite um hórario válido", (MsgBoxStyle)0, null);
				IL_26:
				text = "00:00";
				goto IL_6F;
				IL_2E:
				num2 = -1;
								IL_42:;
			}
			catch (Exception) { }
			IL_6F:
			string result = text;
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x0041D70C File Offset: 0x0041BB0C
		private void ChifeckBox_setpoints_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, false, false))
			{
				this.Grupo_setpoint.Enabled = false;
			}
			else
			{
				this.Grupo_setpoint.Enabled = true;
			}
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x0041D74C File Offset: 0x0041BB4C
		private void CheckBox_timer_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, false, false))
			{
				this.GroupBox_timer_1.Enabled = false;
				this.GroupBox_timer_2.Enabled = false;
				this.GroupBox_timer_3.Enabled = false;
				this.GroupBox_timer_4.Enabled = false;
			}
			else
			{
				this.GroupBox_timer_1.Enabled = true;
				this.GroupBox_timer_2.Enabled = true;
				this.GroupBox_timer_3.Enabled = true;
				this.GroupBox_timer_4.Enabled = true;
			}
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x0041D7E0 File Offset: 0x0041BBE0
		private void CheckBox_ponta_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, false, false))
			{
				this.GroupBox_ponta.Enabled = false;
			}
			else
			{
				this.GroupBox_ponta.Enabled = true;
			}
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x0041D820 File Offset: 0x0041BC20
		private void CheckBox_alarmes_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, false, false))
			{
				this.Grupo_alarmes.Enabled = false;
			}
			else
			{
				this.Grupo_alarmes.Enabled = true;
			}
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x0041D860 File Offset: 0x0041BC60
		private void CheckBox_temperatura_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, false, false))
			{
				this.Grupo_temperaturas.Enabled = false;
			}
			else
			{
				this.Grupo_temperaturas.Enabled = true;
			}
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x0041D8A0 File Offset: 0x0041BCA0
		private void Valor_nivel_desejado_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Nivel_desejado = num;
			}
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x0041D914 File Offset: 0x0041BD14
		private void Valor_nivel_B1_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Nivel_ligar_B1 = num;
			}
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x0041D988 File Offset: 0x0041BD88
		private void Valor_nivel_B2_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Nivel_ligar_B2 = num;
			}
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x0041D9FC File Offset: 0x0041BDFC
		private void Valor_nivel_B3_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Nivel_ligar_B3 = num;
			}
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x0041DA70 File Offset: 0x0041BE70
		private void Valor_nivel_B4_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Nivel_ligar_B4 = num;
			}
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x0041DAE4 File Offset: 0x0041BEE4
		private void Valor_nivel_desligamento_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Nivel_desligamento = num;
			}
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x0041DB58 File Offset: 0x0041BF58
		private void Valor_nivel_ligamento_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Nivel_ligamento = num;
			}
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x0041DBCC File Offset: 0x0041BFCC
		private void Valor_pressao_succao_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 5 | num > 30)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Pressao_succao = num;
			}
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x0041DC40 File Offset: 0x0041C040
		private void Valor_pressao_controle_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 5 | num > 30)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Pressao_recalque = num;
			}
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x0041DCB4 File Offset: 0x0041C0B4
		private void Valor_tempo_mais_bomba_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 180)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Tempo_para_mais_bomba = num;
			}
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x0041DD2C File Offset: 0x0041C12C
		private void CheckBox_horario_ponta_CheckedChanged(object sender, EventArgs e)
		{
			Mod_VA.Operacao_VA220.hab_verificacao_ponta = Conversions.ToBoolean(null);
			if (Operators.ConditionalCompareObjectEqual(null, false, false))
			{
				this.Liga_ponta.Enabled = false;
				this.Desliga_ponta.Enabled = false;
			}
			else
			{
				this.Liga_ponta.Enabled = true;
				this.Desliga_ponta.Enabled = true;
			}
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x0041DDB4 File Offset: 0x0041C1B4
		private void Valor_desliga_ponta_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Ponta_Desliga = "";
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x0041DE20 File Offset: 0x0041C220
		private void Valor_liga_ponta_Validating(object sender, CancelEventArgs e)
		{
						Mod_VA.Operacao_VA220.Ponta_liga = "";
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x0041DE8C File Offset: 0x0041C28C
		private void CheckBox_habilita_temperatura_CheckedChanged(object sender, EventArgs e)
		{
			Mod_VA.Operacao_VA220.hab_verificacao_temp = Conversions.ToBoolean(null);
			if (Operators.ConditionalCompareObjectEqual(null, false, false))
			{
				this.Valor_Temp_B1.Enabled = false;
				this.Valor_Temp_B2.Enabled = false;
				this.Valor_Temp_B3.Enabled = false;
				this.Valor_Temp_B4.Enabled = false;
			}
			else
			{
				this.Valor_Temp_B1.Enabled = true;
				this.Valor_Temp_B2.Enabled = true;
				this.Valor_Temp_B3.Enabled = true;
				this.Valor_Temp_B4.Enabled = true;
			}
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x0041DF44 File Offset: 0x0041C344
		private void Valor_Temp_B1_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Temperaturas[1] = num;
			}
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x0041DFB8 File Offset: 0x0041C3B8
		private void Valor_Temp_B2_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Temperaturas[2] = num;
			}
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x0041E02C File Offset: 0x0041C42C
		private void Valor_Temp_B3_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Temperaturas[3] = num;
			}
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x0041E0A0 File Offset: 0x0041C4A0
		private void Valor_Temp_B4_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Temperaturas[4] = num;
			}
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x0041E114 File Offset: 0x0041C514
		private void CheckBox_alm_rq_CheckedChanged(object sender, EventArgs e)
		{
			Mod_VA.Operacao_VA220.hab_verificacao_alarmes = Conversions.ToBoolean(null);
			if (Operators.ConditionalCompareObjectEqual(null, false, false))
			{
				this.GroupBox_nivel_alto.Enabled = false;
				this.GroupBox_nivel_baixo.Enabled = false;
			}
			else
			{
				this.GroupBox_nivel_alto.Enabled = true;
				this.GroupBox_nivel_baixo.Enabled = true;
			}
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x0041E19C File Offset: 0x0041C59C
		private void Valor_NA_B1_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Alarmes[1, 2] = num;
			}
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x0041E218 File Offset: 0x0041C618
		private void Valor_NA_B2_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Alarmes[2, 2] = num;
			}
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x0041E294 File Offset: 0x0041C694
		private void Valor_NA_B3_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Alarmes[3, 2] = num;
			}
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x0041E310 File Offset: 0x0041C710
		private void Valor_NA_B4_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Alarmes[4, 2] = num;
			}
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x0041E38C File Offset: 0x0041C78C
		private void Valor_NA_T_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Alarmes[5, 2] = num;
			}
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x0041E408 File Offset: 0x0041C808
		private void Valor_NB_B1_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Alarmes[1, 1] = num;
			}
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x0041E484 File Offset: 0x0041C884
		private void Valor_NB_B2_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Alarmes[2, 1] = num;
			}
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x0041E500 File Offset: 0x0041C900
		private void Valor_NB_B3_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Alarmes[3, 1] = num;
			}
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x0041E57C File Offset: 0x0041C97C
		private void Valor_NB_B4_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Alarmes[4, 1] = num;
			}
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x0041E5F8 File Offset: 0x0041C9F8
		private void Valor_NB_T_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
						if (num < 0 | num > 100)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.Alarmes[5, 1] = num;
			}
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x0041E674 File Offset: 0x0041CA74
		private void Valor_end_estacao_TextChanged(object sender, EventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
			if (num >= 0 & num <= 200)
			{
				Mod_VA.Operacao_VA220.End_estacao = num;
				this.VScroll_end_estacao.Value = num;
			}
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x0041E6D4 File Offset: 0x0041CAD4
		private void Valor_end_estacao_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.End_estacao = num;
				this.VScroll_end_estacao.Value = num;
			}
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x0041E738 File Offset: 0x0041CB38
		private void Valor_end_mestre_TextChanged(object sender, EventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
			if (num >= 0 & num <= 200)
			{
				Mod_VA.Operacao_VA220.End_mestre = num;
				this.VScroll_end_mestre.Value = num;
			}
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x0041E798 File Offset: 0x0041CB98
		private void Valor_end_mestre_Validating(object sender, CancelEventArgs e)
		{
			int num = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(null))));
			if (num < 0 | num > 200)
			{
				e.Cancel = true;
			}
			else
			{
				Mod_VA.Operacao_VA220.End_mestre = num;
				this.VScroll_end_mestre.Value = num;
			}
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x0041E7FC File Offset: 0x0041CBFC
		private void VScroll_end_estacao_Scroll(object sender, ScrollEventArgs e)
		{
			this.Valor_end_estacao.Text = Conversion.Str(RuntimeHelpers.GetObjectValue(null));
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x0041E828 File Offset: 0x0041CC28
		private void VScroll_end_mestre_Scroll(object sender, ScrollEventArgs e)
		{
			this.Valor_end_mestre.Text = Conversion.Str(RuntimeHelpers.GetObjectValue(null));
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x0041E854 File Offset: 0x0041CC54
		private void Button_ler_Click(object sender, EventArgs e)
		{
			int[] array = new int[41];
			if (Conversion.Val(this.Valor_end_mestre.Text) == 0.0 | Conversion.Val(this.Valor_end_estacao.Text) == 0.0)
			{
				Interaction.MsgBox(" Existe um endereço não válido ", (MsgBoxStyle)0, null);
				return;
			}
			this.Ctrl_relogio.Enabled = false;
			this.Limpa_tela_ope_VA220();
			this.Mensagem_ope_VA220("Aguarde ...", 2);
			checked
			{
				if (this.CheckBox_setpoints.Checked)
				{
					int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					while (i > 0)
					{
						i--;
						Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 51, 0, array);
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
						switch (Comunicacao.Ctrl_Com.Frame)
						{
						case 0:
							Mod_VA.Atualiza_setpoints_VA220();
							this.Atualiza_tela_ope_VA220();
							this.Mensagem_ope_VA220("Leitura Setpoints - Ok", 0);
							goto IL_13E;
						case 2:
							if (i == 0)
							{
								this.Mensagem_ope_VA220("Erro leitura setpoints - conferência", 1);
								return;
							}
							continue;
						case 3:
							if (i == 0)
							{
								this.Mensagem_ope_VA220("Erro leitura setpoints - timeout", 1);
								return;
							}
							continue;
						}
						if (i == 0)
						{
							this.Mensagem_ope_VA220("Erro leitura setpoints - não determinado", 1);
							return;
						}
					}
				}
				IL_13E:
				if (this.CheckBox_alarmes.Checked)
				{
					int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					while (i > 0)
					{
						i--;
						Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 55, 0, array);
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
						switch (Comunicacao.Ctrl_Com.Frame)
						{
						case 0:
							Mod_VA.Atualiza_alarmes_VA220();
							this.Atualiza_tela_ope_VA220();
							this.Mensagem_ope_VA220("Leitura Alarmes - Ok", 0);
							goto IL_20F;
						case 2:
							if (i == 0)
							{
								this.Mensagem_ope_VA220("Erro leitura alarmes - conferência", 1);
								return;
							}
							continue;
						case 3:
							if (i == 0)
							{
								this.Mensagem_ope_VA220("Erro leitura alarmes - timeout", 1);
								return;
							}
							continue;
						}
						if (i == 0)
						{
							this.Mensagem_ope_VA220("Erro leitura alarmes - não determinado", 1);
							return;
						}
					}
				}
				IL_20F:
				if (this.CheckBox_ponta.Checked)
				{
					int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					while (i > 0)
					{
						i--;
						Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 54, 0, array);
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
						switch (Comunicacao.Ctrl_Com.Frame)
						{
						case 0:
							Mod_VA.Atualiza_ponta_VA220();
							this.Atualiza_tela_ope_VA220();
							this.Mensagem_ope_VA220("Leitura Horário de Ponta - Ok", 0);
							goto IL_2E0;
						case 2:
							if (i == 0)
							{
								this.Mensagem_ope_VA220("Erro horário de ponta - conferência", 1);
								return;
							}
							continue;
						case 3:
							if (i == 0)
							{
								this.Mensagem_ope_VA220("Erro horário de ponta - timeout", 1);
								return;
							}
							continue;
						}
						if (i == 0)
						{
							this.Mensagem_ope_VA220("Erro horário de ponta - não determinado", 1);
							return;
						}
					}
				}
				IL_2E0:
				if (this.CheckBox_temperatura.Checked)
				{
					int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					while (i > 0)
					{
						i--;
						Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 56, 0, array);
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
						switch (Comunicacao.Ctrl_Com.Frame)
						{
						case 0:
							Mod_VA.Atualiza_temp_VA220();
							this.Atualiza_tela_ope_VA220();
							this.Mensagem_ope_VA220("Leitura setpoints de temperatura - Ok", 0);
							goto IL_3B1;
						case 2:
							if (i == 0)
							{
								this.Mensagem_ope_VA220("Erro setpoints de temperatura - conferência", 1);
								return;
							}
							continue;
						case 3:
							if (i == 0)
							{
								this.Mensagem_ope_VA220("Erro setpoints de temperatura - timeout", 1);
								return;
							}
							continue;
						}
						if (i == 0)
						{
							this.Mensagem_ope_VA220("Erro setpoints de temperatura - não determinado", 1);
							return;
						}
					}
				}
				IL_3B1:
				if (this.CheckBox_timer.Checked)
				{
					int num = 1;
					for (;;)
					{
						int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
						while (i > 0)
						{
							i--;
							array[0] = num;
							Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 53, 1, array);
							do
							{
								Application.DoEvents();
							}
							while (Comunicacao.Ctrl_Com.Frame == 255);
							switch (Comunicacao.Ctrl_Com.Frame)
							{
							case 0:
								Mod_VA.Atualiza_timer_VA220(num);
								this.Atualiza_tela_ope_VA220();
								this.Mensagem_ope_VA220("Leitura Timer Bomba " + Conversion.Str(num) + " - Ok", 0);
								goto IL_4DD;
							case 2:
								if (i == 0)
								{
									goto Block_30;
								}
								continue;
							case 3:
								if (i == 0)
								{
									goto Block_29;
								}
								continue;
							}
							if (i == 0)
							{
								goto Block_31;
							}
						}
						IL_4DD:
						num++;
						if (num > 4)
						{
													}
					}
					Block_29:
					this.Mensagem_ope_VA220("Erro Timer Bomba " + Conversion.Str(num) + " - timeout", 1);
					return;
					Block_30:
					this.Mensagem_ope_VA220("Erro Timer Bomba " + Conversion.Str(num) + " - conferência", 1);
					return;
					Block_31:
					this.Mensagem_ope_VA220("Erro Timer Bomba " + Conversion.Str(num) + " - não determinado", 1);
					return;
				}
				IL_4E8:
				if (this.CheckBox_relogio.Checked)
				{
					int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					while (i > 0)
					{
						i--;
						Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 85, 0, array);
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
						switch (Comunicacao.Ctrl_Com.Frame)
						{
						case 0:
							Mod_VA.Atualiza_relogio_VA220();
							this.Ctrl_relogio.Enabled = true;
							this.Mensagem_ope_VA220("Leitura Relogio - Ok", 0);
							goto IL_5BF;
						case 2:
							if (i == 0)
							{
								this.Mensagem_ope_VA220("Erro Relogio - conferência", 1);
								return;
							}
							continue;
						case 3:
							if (i == 0)
							{
								this.Mensagem_ope_VA220("Erro Relogio - timeout", 1);
								return;
							}
							continue;
						}
						if (i == 0)
						{
							this.Mensagem_ope_VA220("Erro Relogio - não determinado", 1);
							return;
						}
					}
				}
				IL_5BF:
				this.Mensagem_ope_VA220("Comando executado com sucesso", 0);
			}
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x0041EE2C File Offset: 0x0041D22C
		public void Mensagem_ope_VA220(string msg, int cor)
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

		// Token: 0x060026DA RID: 9946 RVA: 0x0041EE90 File Offset: 0x0041D290
		public void Atualiza_relogio()
		{
			this.Valor_hora.Text = Strings.Format(Mod_VA.Operacao_VA220.relogio, "HH:mm:ss");
			this.Valor_data.Text = Strings.Format(Mod_VA.Operacao_VA220.relogio, "dd/MM/yyyy");
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x0041EEE8 File Offset: 0x0041D2E8
		public void Limpa_tela_ope_VA220()
		{
			this.Limpa_estrutura_ope_VA220();
			this.Atualiza_tela_ope_VA220();
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x0041EEF8 File Offset: 0x0041D2F8
		public void Limpa_estrutura_ope_VA220()
		{
			Mod_VA.Operacao_VA220.Alarmes = new int[6, 3];
			Mod_VA.Operacao_VA220.Timer_liga = new string[5, 5];
			Mod_VA.Operacao_VA220.Timer_desliga = new string[5, 5];
			Mod_VA.Operacao_VA220.Temperaturas = new int[6];
			Mod_VA.Operacao_VA220.Nivel_desejado = 0;
			Mod_VA.Operacao_VA220.Nivel_ligar_B1 = 0;
			Mod_VA.Operacao_VA220.Nivel_ligar_B2 = 0;
			Mod_VA.Operacao_VA220.Nivel_ligar_B3 = 0;
			Mod_VA.Operacao_VA220.Nivel_ligar_B4 = 0;
			Mod_VA.Operacao_VA220.Nivel_desligamento = 0;
			Mod_VA.Operacao_VA220.Nivel_ligamento = 0;
			Mod_VA.Operacao_VA220.Tempo_para_mais_bomba = 0;
			Mod_VA.Operacao_VA220.Pressao_recalque = 5;
			Mod_VA.Operacao_VA220.Pressao_succao = 5;
			Mod_VA.Operacao_VA220.Ponta_Desliga = "00:00";
			Mod_VA.Operacao_VA220.Ponta_liga = "00:00";
			int num = 1;
			checked
			{
				int num2 = 0;
				do
				{
					num2 = 1;
					do
					{
						Mod_VA.Operacao_VA220.Alarmes[num, num2] = 0;
						num2++;
					}
					while (num2 <= 2);
					num++;
				}
				while (num <= 4);
				num = 1;
				do
				{
					Mod_VA.Operacao_VA220.Temperaturas[num2] = 0;
					num2 = 1;
					do
					{
						Mod_VA.Operacao_VA220.Timer_liga[num, num2] = "00:00";
						Mod_VA.Operacao_VA220.Timer_desliga[num, num2] = "00:00";
						num2++;
					}
					while (num2 <= 4);
					num++;
				}
				while (num <= 4);
				Mod_VA.Operacao_VA220.relogio = Conversions.ToDate("01/01/2007 00:00:00");
			}
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x0041F05C File Offset: 0x0041D45C
		public void Atualiza_tela_ope_VA220()
		{
			this.Valor_nivel_desejado.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Nivel_desejado);
			this.Valor_nivel_B1.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Nivel_ligar_B1);
			this.Valor_nivel_B2.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Nivel_ligar_B2);
			this.Valor_nivel_B3.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Nivel_ligar_B3);
			this.Valor_nivel_B4.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Nivel_ligar_B4);
			this.Valor_nivel_ligamento.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Nivel_ligamento);
			this.Valor_nivel_desligamento.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Nivel_desligamento);
			this.Valor_pressao_controle.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Pressao_recalque);
			this.Valor_pressao_succao.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Pressao_succao);
			this.Valor_tempo_mais_bomba.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Tempo_para_mais_bomba);
			this.Valor_Temp_B1.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Temperaturas[1]);
			this.Valor_Temp_B2.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Temperaturas[2]);
			this.Valor_Temp_B3.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Temperaturas[3]);
			this.Valor_Temp_B4.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Temperaturas[4]);
			this.Valor_NA_B1.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Alarmes[1, 1]);
			this.Valor_NA_B2.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Alarmes[2, 1]);
			this.Valor_NA_B3.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Alarmes[3, 1]);
			this.Valor_NA_B4.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Alarmes[4, 1]);
			this.Valor_NA_T.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Alarmes[5, 1]);
			this.Valor_NB_B1.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Alarmes[1, 2]);
			this.Valor_NB_B2.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Alarmes[2, 2]);
			this.Valor_NB_B3.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Alarmes[3, 2]);
			this.Valor_NB_B4.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Alarmes[4, 2]);
			this.Valor_NB_T.Text = Conversions.ToString(Mod_VA.Operacao_VA220.Alarmes[5, 2]);
			this.Valor_desliga_ponta.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Ponta_Desliga, false);
			this.Valor_liga_ponta.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Ponta_liga, false);
			this.Valor_liga_faixa1_b1.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_liga[1, 1], false);
			this.Valor_liga_faixa2_b1.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_liga[1, 2], false);
			this.Valor_liga_faixa3_b1.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_liga[1, 3], false);
			this.Valor_liga_faixa4_b1.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_liga[1, 4], false);
			this.Valor_liga_faixa1_b2.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_liga[2, 1], false);
			this.Valor_liga_faixa2_b2.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_liga[2, 2], false);
			this.Valor_liga_faixa3_b2.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_liga[2, 3], false);
			this.Valor_liga_faixa4_b2.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_liga[2, 4], false);
			this.Valor_liga_faixa1_b3.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_liga[3, 1], false);
			this.Valor_liga_faixa2_b3.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_liga[3, 2], false);
			this.Valor_liga_faixa3_b3.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_liga[3, 3], false);
			this.Valor_liga_faixa4_b3.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_liga[3, 4], false);
			this.Valor_liga_faixa1_b4.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_liga[4, 1], false);
			this.Valor_liga_faixa2_b4.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_liga[4, 2], false);
			this.Valor_liga_faixa3_b4.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_liga[4, 3], false);
			this.Valor_liga_faixa4_b4.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_liga[4, 4], false);
			this.Valor_desliga_faixa1_b1.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_desliga[1, 1], false);
			this.Valor_desliga_faixa2_b1.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_desliga[1, 2], false);
			this.Valor_desliga_faixa3_b1.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_desliga[1, 3], false);
			this.Valor_desliga_faixa4_b1.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_desliga[1, 4], false);
			this.Valor_desliga_faixa1_b2.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_desliga[2, 1], false);
			this.Valor_desliga_faixa2_b2.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_desliga[2, 2], false);
			this.Valor_desliga_faixa3_b2.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_desliga[2, 3], false);
			this.Valor_desliga_faixa4_b2.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_desliga[2, 4], false);
			this.Valor_desliga_faixa1_b3.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_desliga[3, 1], false);
			this.Valor_desliga_faixa2_b3.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_desliga[3, 2], false);
			this.Valor_desliga_faixa3_b3.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_desliga[3, 3], false);
			this.Valor_desliga_faixa4_b3.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_desliga[3, 4], false);
			this.Valor_desliga_faixa1_b4.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_desliga[4, 1], false);
			this.Valor_desliga_faixa2_b4.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_desliga[4, 2], false);
			this.Valor_desliga_faixa3_b4.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_desliga[4, 3], false);
			this.Valor_desliga_faixa4_b4.Text = this.Verifica_horario(Mod_VA.Operacao_VA220.Timer_desliga[4, 4], false);
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x0041F7C0 File Offset: 0x0041DBC0
		private void Ctrl_relogio_Tick(object sender, EventArgs e)
		{
			Mod_VA.Operacao_VA220.relogio = Mod_VA.Operacao_VA220.relogio.AddSeconds(2.0);
			this.Atualiza_relogio();
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x0041F7EC File Offset: 0x0041DBEC
		private void CheckBox_relogio_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, false, false))
			{
				this.Grupo_relogio.Enabled = false;
			}
			else
			{
				this.Grupo_relogio.Enabled = true;
			}
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x0041F82C File Offset: 0x0041DC2C
		private void CheckBox_setpoints_CheckedChanged(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(null, false, false))
			{
				this.Grupo_setpoint.Enabled = false;
			}
			else
			{
				this.Grupo_setpoint.Enabled = true;
			}
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x0041F86C File Offset: 0x0041DC6C
		private void Button_bloqueio_relogio_Click(object sender, EventArgs e)
		{
			if (!this.Ctrl_relogio.Enabled)
			{
				this.Ctrl_relogio.Enabled = true;
				this.Button_bloqueio_relogio.Text = "Bloqueia";
			}
			else
			{
				this.Ctrl_relogio.Enabled = false;
				this.Button_bloqueio_relogio.Text = "Libera";
			}
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x0041F8C0 File Offset: 0x0041DCC0
		private void Valor_hora_Validating(object sender, CancelEventArgs e)
		{
			string text = this.Valor_data.Text + " " + this.Valor_hora.Text;
			Mod_VA.Operacao_VA220.relogio = Convert.ToDateTime(text);
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x0041F900 File Offset: 0x0041DD00
		private void Valor_data_Validating(object sender, CancelEventArgs e)
		{
			string text = this.Valor_data.Text + " " + this.Valor_hora.Text;
			Mod_VA.Operacao_VA220.relogio = Convert.ToDateTime(text);
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x0041F940 File Offset: 0x0041DD40
		private void Button_atualiza_relogio_micro_Click(object sender, EventArgs e)
		{
			Mod_VA.Operacao_VA220.relogio = DateAndTime.Now;
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x0041F954 File Offset: 0x0041DD54
		private void Button_escrever_Click(object sender, EventArgs e)
		{
			int[] dados = new int[41];
			if (Conversion.Val(this.Valor_end_mestre.Text) == 0.0 | Conversion.Val(this.Valor_end_estacao.Text) == 0.0)
			{
				Interaction.MsgBox(" Existe um endereço não válido ", (MsgBoxStyle)0, null);
				return;
			}
			this.Mensagem_ope_VA220("Aguarde ...", 2);
			checked
			{
				if (this.CheckBox_setpoints.Checked)
				{
					int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					while (i > 0)
					{
						i--;
						Mod_VA.Monta_buffer_setpoint(dados);
						Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 66, 10, dados);
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
						switch (Comunicacao.Ctrl_Com.Frame)
						{
						case 0:
							this.Mensagem_ope_VA220("Escrita Setpoints - Ok", 0);
							goto IL_117;
						case 3:
							if (i == 0)
							{
								this.Mensagem_ope_VA220("Erro escrita setpoints - timeout", 1);
								return;
							}
							continue;
						}
						if (i == 0)
						{
							this.Mensagem_ope_VA220("Erro escrita setpoints - não determinado", 1);
							return;
						}
					}
				}
				IL_117:
				if (this.CheckBox_alarmes.Checked)
				{
					int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					while (i > 0)
					{
						i--;
						Mod_VA.Monta_buffer_alarmes(dados);
						Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 76, 11, dados);
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
						switch (Comunicacao.Ctrl_Com.Frame)
						{
						case 0:
							this.Mensagem_ope_VA220("Escrita Alarmes - Ok", 0);
							goto IL_1D3;
						case 3:
							if (i == 0)
							{
								this.Mensagem_ope_VA220("Erro escrita alarmes - timeout", 1);
								return;
							}
							continue;
						}
						if (i == 0)
						{
							this.Mensagem_ope_VA220("Erro escrita alarmes - não determinado", 1);
							return;
						}
					}
				}
				IL_1D3:
				if (this.CheckBox_ponta.Checked)
				{
					int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					while (i > 0)
					{
						i--;
						Mod_VA.Monta_buffer_ponta(dados);
						Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 75, 5, dados);
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
						switch (Comunicacao.Ctrl_Com.Frame)
						{
						case 0:
							this.Mensagem_ope_VA220("Escrita Horário de Ponta - Ok", 0);
							goto IL_28E;
						case 3:
							if (i == 0)
							{
								this.Mensagem_ope_VA220("Erro escrita de ponta - timeout", 1);
								return;
							}
							continue;
						}
						if (i == 0)
						{
							this.Mensagem_ope_VA220("Erro escrita de ponta - não determinado", 1);
							return;
						}
					}
				}
				IL_28E:
				if (this.CheckBox_temperatura.Checked)
				{
					int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					while (i > 0)
					{
						i--;
						Mod_VA.Monta_buffer_temperatura(dados);
						Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 77, 5, dados);
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
						switch (Comunicacao.Ctrl_Com.Frame)
						{
						case 0:
							this.Mensagem_ope_VA220("Escrita setpoints de temperatura - Ok", 0);
							goto IL_349;
						case 3:
							if (i == 0)
							{
								this.Mensagem_ope_VA220("Erro escrita setpoints de temperatura - timeout", 1);
								return;
							}
							continue;
						}
						if (i == 0)
						{
							this.Mensagem_ope_VA220("Erro escrita setpoints de temperatura - não determinado", 1);
							return;
						}
					}
				}
				IL_349:
				if (this.CheckBox_timer.Checked)
				{
					int num = 1;
					for (;;)
					{
						int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
						while (i > 0)
						{
							i--;
							Mod_VA.Monta_buffer_timer(dados, num);
							Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 74, 17, dados);
							do
							{
								Application.DoEvents();
							}
							while (Comunicacao.Ctrl_Com.Frame == 255);
							switch (Comunicacao.Ctrl_Com.Frame)
							{
							case 0:
								this.Mensagem_ope_VA220("Escrita Timer Bomba " + Conversion.Str(num) + " - Ok", 0);
								goto IL_447;
							case 3:
								if (i == 0)
								{
									goto Block_25;
								}
								continue;
							}
							if (i == 0)
							{
								goto Block_26;
							}
						}
						IL_447:
						num++;
						if (num > 4)
						{
													}
					}
					Block_25:
					this.Mensagem_ope_VA220("Erro Escrita Timer Bomba " + Conversion.Str(num) + " - timeout", 1);
					return;
					Block_26:
					this.Mensagem_ope_VA220("Erro Escrita Timer Bomba " + Conversion.Str(num) + " - não determinado", 1);
					return;
				}
				IL_452:
				if (this.CheckBox_relogio.Checked)
				{
					int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					while (i > 0)
					{
						i--;
						Mod_VA.Monta_buffer_relogio(dados);
						Comunicacao.CMD_Tx_condax(Mod_VA.Operacao_VA220.End_estacao, Mod_VA.Operacao_VA220.End_mestre, 84, 7, dados);
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
						switch (Comunicacao.Ctrl_Com.Frame)
						{
						case 0:
							this.Mensagem_ope_VA220("Escrita Relogio - Ok", 0);
							goto IL_50D;
						case 3:
							if (i == 0)
							{
								this.Mensagem_ope_VA220("Erro Escrita Relogio - timeout", 1);
								return;
							}
							continue;
						}
						if (i == 0)
						{
							this.Mensagem_ope_VA220("Erro Escrita Relogio - não determinado", 1);
							return;
						}
					}
				}
				IL_50D:
				this.Mensagem_ope_VA220("Comando executado com sucesso", 0);
			}
		}

		// Token: 0x04001A94 RID: 6804
		[AccessedThroughProperty("Grupo_endereco")]
		private GroupBox _Grupo_endereco;

		// Token: 0x04001A95 RID: 6805
		[AccessedThroughProperty("Label_end_estacao")]
		private Label _Label_end_estacao;

		// Token: 0x04001A96 RID: 6806
		[AccessedThroughProperty("VScroll_end_estacao")]
		private VScrollBar _VScroll_end_estacao;

		// Token: 0x04001A97 RID: 6807
		[AccessedThroughProperty("Valor_end_estacao")]
		private TextBox _Valor_end_estacao;

		// Token: 0x04001A98 RID: 6808
		[AccessedThroughProperty("Grupo_setpoint")]
		private GroupBox _Grupo_setpoint;

		// Token: 0x04001A99 RID: 6809
		[AccessedThroughProperty("Grupo_origem")]
		private GroupBox _Grupo_origem;

		// Token: 0x04001A9A RID: 6810
		[AccessedThroughProperty("Label_nivel_ligamento")]
		private Label _Label_nivel_ligamento;

		// Token: 0x04001A9B RID: 6811
		[AccessedThroughProperty("Label_nivel_desligamento")]
		private Label _Label_nivel_desligamento;

		// Token: 0x04001A9C RID: 6812
		[AccessedThroughProperty("Valor_nivel_ligamento")]
		private TextBox _Valor_nivel_ligamento;

		// Token: 0x04001A9D RID: 6813
		[AccessedThroughProperty("Valor_nivel_desligamento")]
		private TextBox _Valor_nivel_desligamento;

		// Token: 0x04001A9E RID: 6814
		[AccessedThroughProperty("Grupo_gerais")]
		private GroupBox _Grupo_gerais;

		// Token: 0x04001A9F RID: 6815
		[AccessedThroughProperty("Label_pressao_controle")]
		private Label _Label_pressao_controle;

		// Token: 0x04001AA0 RID: 6816
		[AccessedThroughProperty("Label_pressao_succao")]
		private Label _Label_pressao_succao;

		// Token: 0x04001AA1 RID: 6817
		[AccessedThroughProperty("Label_tempo_mais_motor")]
		private Label _Label_tempo_mais_motor;

		// Token: 0x04001AA2 RID: 6818
		[AccessedThroughProperty("Valor_pressao_controle")]
		private TextBox _Valor_pressao_controle;

		// Token: 0x04001AA3 RID: 6819
		[AccessedThroughProperty("Valor_pressao_succao")]
		private TextBox _Valor_pressao_succao;

		// Token: 0x04001AA4 RID: 6820
		[AccessedThroughProperty("Valor_tempo_mais_bomba")]
		private TextBox _Valor_tempo_mais_bomba;

		// Token: 0x04001AA5 RID: 6821
		[AccessedThroughProperty("Grupo_niveis")]
		private GroupBox _Grupo_niveis;

		// Token: 0x04001AA6 RID: 6822
		[AccessedThroughProperty("Label_nivel_bomba_4")]
		private Label _Label_nivel_bomba_4;

		// Token: 0x04001AA7 RID: 6823
		[AccessedThroughProperty("Label_nivel_bomba_3")]
		private Label _Label_nivel_bomba_3;

		// Token: 0x04001AA8 RID: 6824
		[AccessedThroughProperty("Label_nivel_bomba_2")]
		private Label _Label_nivel_bomba_2;

		// Token: 0x04001AA9 RID: 6825
		[AccessedThroughProperty("Label_nivel_bomba_1")]
		private Label _Label_nivel_bomba_1;

		// Token: 0x04001AAA RID: 6826
		[AccessedThroughProperty("Label_nivel_desejado")]
		private Label _Label_nivel_desejado;

		// Token: 0x04001AAB RID: 6827
		[AccessedThroughProperty("Valor_nivel_B4")]
		private TextBox _Valor_nivel_B4;

		// Token: 0x04001AAC RID: 6828
		[AccessedThroughProperty("Valor_nivel_B3")]
		private TextBox _Valor_nivel_B3;

		// Token: 0x04001AAD RID: 6829
		[AccessedThroughProperty("Valor_nivel_B2")]
		private TextBox _Valor_nivel_B2;

		// Token: 0x04001AAE RID: 6830
		[AccessedThroughProperty("Valor_nivel_B1")]
		private TextBox _Valor_nivel_B1;

		// Token: 0x04001AAF RID: 6831
		[AccessedThroughProperty("Valor_nivel_desejado")]
		private TextBox _Valor_nivel_desejado;

		// Token: 0x04001AB0 RID: 6832
		[AccessedThroughProperty("Grupo_alarmes")]
		private GroupBox _Grupo_alarmes;

		// Token: 0x04001AB1 RID: 6833
		[AccessedThroughProperty("Label_alm_bomba_1")]
		private Label _Label_alm_bomba_1;

		// Token: 0x04001AB2 RID: 6834
		[AccessedThroughProperty("CheckBox_alm_rq")]
		private CheckBox _CheckBox_alm_rq;

		// Token: 0x04001AB3 RID: 6835
		[AccessedThroughProperty("GroupBox_nivel_alto")]
		private GroupBox _GroupBox_nivel_alto;

		// Token: 0x04001AB4 RID: 6836
		[AccessedThroughProperty("Valor_NA_T")]
		private TextBox _Valor_NA_T;

		// Token: 0x04001AB5 RID: 6837
		[AccessedThroughProperty("Valor_NA_B4")]
		private TextBox _Valor_NA_B4;

		// Token: 0x04001AB6 RID: 6838
		[AccessedThroughProperty("Valor_NA_B3")]
		private TextBox _Valor_NA_B3;

		// Token: 0x04001AB7 RID: 6839
		[AccessedThroughProperty("Valor_NA_B2")]
		private TextBox _Valor_NA_B2;

		// Token: 0x04001AB8 RID: 6840
		[AccessedThroughProperty("Valor_NA_B1")]
		private TextBox _Valor_NA_B1;

		// Token: 0x04001AB9 RID: 6841
		[AccessedThroughProperty("GroupBox_nivel_baixo")]
		private GroupBox _GroupBox_nivel_baixo;

		// Token: 0x04001ABA RID: 6842
		[AccessedThroughProperty("Valor_NB_T")]
		private TextBox _Valor_NB_T;

		// Token: 0x04001ABB RID: 6843
		[AccessedThroughProperty("Valor_NB_B4")]
		private TextBox _Valor_NB_B4;

		// Token: 0x04001ABC RID: 6844
		[AccessedThroughProperty("Valor_NB_B3")]
		private TextBox _Valor_NB_B3;

		// Token: 0x04001ABD RID: 6845
		[AccessedThroughProperty("Valor_NB_B2")]
		private TextBox _Valor_NB_B2;

		// Token: 0x04001ABE RID: 6846
		[AccessedThroughProperty("Valor_NB_B1")]
		private TextBox _Valor_NB_B1;

		// Token: 0x04001ABF RID: 6847
		[AccessedThroughProperty("Label_alm_tensao")]
		private Label _Label_alm_tensao;

		// Token: 0x04001AC0 RID: 6848
		[AccessedThroughProperty("Label_alm_bomba_4")]
		private Label _Label_alm_bomba_4;

		// Token: 0x04001AC1 RID: 6849
		[AccessedThroughProperty("Label_alm_bomba_3")]
		private Label _Label_alm_bomba_3;

		// Token: 0x04001AC2 RID: 6850
		[AccessedThroughProperty("Label_alm_bomba_2")]
		private Label _Label_alm_bomba_2;

		// Token: 0x04001AC3 RID: 6851
		[AccessedThroughProperty("GroupBox_timer_1")]
		private GroupBox _GroupBox_timer_1;

		// Token: 0x04001AC4 RID: 6852
		[AccessedThroughProperty("GroupBox_Liga_B1")]
		private GroupBox _GroupBox_Liga_B1;

		// Token: 0x04001AC5 RID: 6853
		[AccessedThroughProperty("Label_faixa1_B1")]
		private Label _Label_faixa1_B1;

		// Token: 0x04001AC6 RID: 6854
		[AccessedThroughProperty("Valor_liga_faixa1_b1")]
		private TextBox _Valor_liga_faixa1_b1;

		// Token: 0x04001AC7 RID: 6855
		[AccessedThroughProperty("GroupBox_Desliga_B1")]
		private GroupBox _GroupBox_Desliga_B1;

		// Token: 0x04001AC8 RID: 6856
		[AccessedThroughProperty("Valor_desliga_faixa4_b1")]
		private TextBox _Valor_desliga_faixa4_b1;

		// Token: 0x04001AC9 RID: 6857
		[AccessedThroughProperty("Valor_desliga_faixa3_b1")]
		private TextBox _Valor_desliga_faixa3_b1;

		// Token: 0x04001ACA RID: 6858
		[AccessedThroughProperty("Valor_desliga_faixa2_b1")]
		private TextBox _Valor_desliga_faixa2_b1;

		// Token: 0x04001ACB RID: 6859
		[AccessedThroughProperty("Valor_desliga_faixa1_b1")]
		private TextBox _Valor_desliga_faixa1_b1;

		// Token: 0x04001ACC RID: 6860
		[AccessedThroughProperty("Valor_liga_faixa4_b1")]
		private TextBox _Valor_liga_faixa4_b1;

		// Token: 0x04001ACD RID: 6861
		[AccessedThroughProperty("Valor_liga_faixa3_b1")]
		private TextBox _Valor_liga_faixa3_b1;

		// Token: 0x04001ACE RID: 6862
		[AccessedThroughProperty("Valor_liga_faixa2_b1")]
		private TextBox _Valor_liga_faixa2_b1;

		// Token: 0x04001ACF RID: 6863
		[AccessedThroughProperty("Label_faixa4_B1")]
		private Label _Label_faixa4_B1;

		// Token: 0x04001AD0 RID: 6864
		[AccessedThroughProperty("Label_faixa3_B1")]
		private Label _Label_faixa3_B1;

		// Token: 0x04001AD1 RID: 6865
		[AccessedThroughProperty("Label_faixa2_B1")]
		private Label _Label_faixa2_B1;

		// Token: 0x04001AD2 RID: 6866
		[AccessedThroughProperty("GroupBox_timer_2")]
		private GroupBox _GroupBox_timer_2;

		// Token: 0x04001AD3 RID: 6867
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04001AD4 RID: 6868
		[AccessedThroughProperty("Valor_desliga_faixa4_b2")]
		private TextBox _Valor_desliga_faixa4_b2;

		// Token: 0x04001AD5 RID: 6869
		[AccessedThroughProperty("Valor_desliga_faixa3_b2")]
		private TextBox _Valor_desliga_faixa3_b2;

		// Token: 0x04001AD6 RID: 6870
		[AccessedThroughProperty("Valor_desliga_faixa2_b2")]
		private TextBox _Valor_desliga_faixa2_b2;

		// Token: 0x04001AD7 RID: 6871
		[AccessedThroughProperty("Valor_desliga_faixa1_b2")]
		private TextBox _Valor_desliga_faixa1_b2;

		// Token: 0x04001AD8 RID: 6872
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x04001AD9 RID: 6873
		[AccessedThroughProperty("Valor_liga_faixa4_b2")]
		private TextBox _Valor_liga_faixa4_b2;

		// Token: 0x04001ADA RID: 6874
		[AccessedThroughProperty("Valor_liga_faixa3_b2")]
		private TextBox _Valor_liga_faixa3_b2;

		// Token: 0x04001ADB RID: 6875
		[AccessedThroughProperty("Valor_liga_faixa2_b2")]
		private TextBox _Valor_liga_faixa2_b2;

		// Token: 0x04001ADC RID: 6876
		[AccessedThroughProperty("Valor_liga_faixa1_b2")]
		private TextBox _Valor_liga_faixa1_b2;

		// Token: 0x04001ADD RID: 6877
		[AccessedThroughProperty("Label_faixa4_B2")]
		private Label _Label_faixa4_B2;

		// Token: 0x04001ADE RID: 6878
		[AccessedThroughProperty("Label_faixa3_B2")]
		private Label _Label_faixa3_B2;

		// Token: 0x04001ADF RID: 6879
		[AccessedThroughProperty("Label_faixa2_B2")]
		private Label _Label_faixa2_B2;

		// Token: 0x04001AE0 RID: 6880
		[AccessedThroughProperty("Label_faixa1_B2")]
		private Label _Label_faixa1_B2;

		// Token: 0x04001AE1 RID: 6881
		[AccessedThroughProperty("GroupBox_timer_4")]
		private GroupBox _GroupBox_timer_4;

		// Token: 0x04001AE2 RID: 6882
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x04001AE3 RID: 6883
		[AccessedThroughProperty("Valor_desliga_faixa4_b4")]
		private TextBox _Valor_desliga_faixa4_b4;

		// Token: 0x04001AE4 RID: 6884
		[AccessedThroughProperty("Valor_desliga_faixa3_b4")]
		private TextBox _Valor_desliga_faixa3_b4;

		// Token: 0x04001AE5 RID: 6885
		[AccessedThroughProperty("Valor_desliga_faixa2_b4")]
		private TextBox _Valor_desliga_faixa2_b4;

		// Token: 0x04001AE6 RID: 6886
		[AccessedThroughProperty("Valor_desliga_faixa1_b4")]
		private TextBox _Valor_desliga_faixa1_b4;

		// Token: 0x04001AE7 RID: 6887
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		// Token: 0x04001AE8 RID: 6888
		[AccessedThroughProperty("Valor_liga_faixa4_b4")]
		private TextBox _Valor_liga_faixa4_b4;

		// Token: 0x04001AE9 RID: 6889
		[AccessedThroughProperty("Valor_liga_faixa3_b4")]
		private TextBox _Valor_liga_faixa3_b4;

		// Token: 0x04001AEA RID: 6890
		[AccessedThroughProperty("Valor_liga_faixa2_b4")]
		private TextBox _Valor_liga_faixa2_b4;

		// Token: 0x04001AEB RID: 6891
		[AccessedThroughProperty("Valor_liga_faixa1_b4")]
		private TextBox _Valor_liga_faixa1_b4;

		// Token: 0x04001AEC RID: 6892
		[AccessedThroughProperty("Label_faixa4_B4")]
		private Label _Label_faixa4_B4;

		// Token: 0x04001AED RID: 6893
		[AccessedThroughProperty("Label_faixa3_B4")]
		private Label _Label_faixa3_B4;

		// Token: 0x04001AEE RID: 6894
		[AccessedThroughProperty("Label_faixa2_B4")]
		private Label _Label_faixa2_B4;

		// Token: 0x04001AEF RID: 6895
		[AccessedThroughProperty("Label_faixa1_B4")]
		private Label _Label_faixa1_B4;

		// Token: 0x04001AF0 RID: 6896
		[AccessedThroughProperty("GroupBox_timer_3")]
		private GroupBox _GroupBox_timer_3;

		// Token: 0x04001AF1 RID: 6897
		[AccessedThroughProperty("GroupBox8")]
		private GroupBox _GroupBox8;

		// Token: 0x04001AF2 RID: 6898
		[AccessedThroughProperty("Valor_desliga_faixa4_b3")]
		private TextBox _Valor_desliga_faixa4_b3;

		// Token: 0x04001AF3 RID: 6899
		[AccessedThroughProperty("Valor_desliga_faixa3_b3")]
		private TextBox _Valor_desliga_faixa3_b3;

		// Token: 0x04001AF4 RID: 6900
		[AccessedThroughProperty("Valor_desliga_faixa2_b3")]
		private TextBox _Valor_desliga_faixa2_b3;

		// Token: 0x04001AF5 RID: 6901
		[AccessedThroughProperty("Valor_desliga_faixa1_b3")]
		private TextBox _Valor_desliga_faixa1_b3;

		// Token: 0x04001AF6 RID: 6902
		[AccessedThroughProperty("GroupBox9")]
		private GroupBox _GroupBox9;

		// Token: 0x04001AF7 RID: 6903
		[AccessedThroughProperty("Valor_liga_faixa4_b3")]
		private TextBox _Valor_liga_faixa4_b3;

		// Token: 0x04001AF8 RID: 6904
		[AccessedThroughProperty("Valor_liga_faixa3_b3")]
		private TextBox _Valor_liga_faixa3_b3;

		// Token: 0x04001AF9 RID: 6905
		[AccessedThroughProperty("Valor_liga_faixa2_b3")]
		private TextBox _Valor_liga_faixa2_b3;

		// Token: 0x04001AFA RID: 6906
		[AccessedThroughProperty("Valor_liga_faixa1_b3")]
		private TextBox _Valor_liga_faixa1_b3;

		// Token: 0x04001AFB RID: 6907
		[AccessedThroughProperty("Label_faixa4_B3")]
		private Label _Label_faixa4_B3;

		// Token: 0x04001AFC RID: 6908
		[AccessedThroughProperty("Label_faixa3_B3")]
		private Label _Label_faixa3_B3;

		// Token: 0x04001AFD RID: 6909
		[AccessedThroughProperty("Label_faixa2_B3")]
		private Label _Label_faixa2_B3;

		// Token: 0x04001AFE RID: 6910
		[AccessedThroughProperty("Label_faixa1_B3")]
		private Label _Label_faixa1_B3;

		// Token: 0x04001AFF RID: 6911
		[AccessedThroughProperty("GroupBox_ponta")]
		private GroupBox _GroupBox_ponta;

		// Token: 0x04001B00 RID: 6912
		[AccessedThroughProperty("Desliga_ponta")]
		private GroupBox _Desliga_ponta;

		// Token: 0x04001B01 RID: 6913
		[AccessedThroughProperty("Valor_desliga_ponta")]
		private TextBox _Valor_desliga_ponta;

		// Token: 0x04001B02 RID: 6914
		[AccessedThroughProperty("Liga_ponta")]
		private GroupBox _Liga_ponta;

		// Token: 0x04001B03 RID: 6915
		[AccessedThroughProperty("CheckBox_horario_ponta")]
		private CheckBox _CheckBox_horario_ponta;

		// Token: 0x04001B04 RID: 6916
		[AccessedThroughProperty("Grupo_temperaturas")]
		private GroupBox _Grupo_temperaturas;

		// Token: 0x04001B05 RID: 6917
		[AccessedThroughProperty("Grupo_temp")]
		private GroupBox _Grupo_temp;

		// Token: 0x04001B06 RID: 6918
		[AccessedThroughProperty("Valor_Temp_B4")]
		private TextBox _Valor_Temp_B4;

		// Token: 0x04001B07 RID: 6919
		[AccessedThroughProperty("Valor_Temp_B3")]
		private TextBox _Valor_Temp_B3;

		// Token: 0x04001B08 RID: 6920
		[AccessedThroughProperty("Valor_Temp_B2")]
		private TextBox _Valor_Temp_B2;

		// Token: 0x04001B09 RID: 6921
		[AccessedThroughProperty("Valor_Temp_B1")]
		private TextBox _Valor_Temp_B1;

		// Token: 0x04001B0A RID: 6922
		[AccessedThroughProperty("CheckBox_habilita_temperatura")]
		private CheckBox _CheckBox_habilita_temperatura;

		// Token: 0x04001B0B RID: 6923
		[AccessedThroughProperty("Label_temp_bomba_4")]
		private Label _Label_temp_bomba_4;

		// Token: 0x04001B0C RID: 6924
		[AccessedThroughProperty("Label_temp_bomba_3")]
		private Label _Label_temp_bomba_3;

		// Token: 0x04001B0D RID: 6925
		[AccessedThroughProperty("Label_temp_bomba_2")]
		private Label _Label_temp_bomba_2;

		// Token: 0x04001B0E RID: 6926
		[AccessedThroughProperty("Label_temp_bomba_1")]
		private Label _Label_temp_bomba_1;

		// Token: 0x04001B0F RID: 6927
		[AccessedThroughProperty("GroupBox_opcoes")]
		private GroupBox _GroupBox_opcoes;

		// Token: 0x04001B10 RID: 6928
		[AccessedThroughProperty("CheckBox_alarmes")]
		private CheckBox _CheckBox_alarmes;

		// Token: 0x04001B11 RID: 6929
		[AccessedThroughProperty("CheckBox_ponta")]
		private CheckBox _CheckBox_ponta;

		// Token: 0x04001B12 RID: 6930
		[AccessedThroughProperty("CheckBox_timer")]
		private CheckBox _CheckBox_timer;

		// Token: 0x04001B13 RID: 6931
		[AccessedThroughProperty("Button_escrever")]
		private Button _Button_escrever;

		// Token: 0x04001B14 RID: 6932
		[AccessedThroughProperty("Button_ler")]
		private Button _Button_ler;

		// Token: 0x04001B15 RID: 6933
		[AccessedThroughProperty("CheckBox_temperatura")]
		private CheckBox _CheckBox_temperatura;

		// Token: 0x04001B16 RID: 6934
		[AccessedThroughProperty("Label_end_mestre")]
		private Label _Label_end_mestre;

		// Token: 0x04001B17 RID: 6935
		[AccessedThroughProperty("VScroll_end_mestre")]
		private VScrollBar _VScroll_end_mestre;

		// Token: 0x04001B18 RID: 6936
		[AccessedThroughProperty("Valor_end_mestre")]
		private TextBox _Valor_end_mestre;

		// Token: 0x04001B19 RID: 6937
		[AccessedThroughProperty("Valor_liga_ponta")]
		private TextBox _Valor_liga_ponta;

		// Token: 0x04001B1A RID: 6938
		[AccessedThroughProperty("Box_Msg")]
		private TextBox _Box_Msg;

		// Token: 0x04001B1B RID: 6939
		[AccessedThroughProperty("CheckBox_setpoints")]
		private CheckBox _CheckBox_setpoints;

		// Token: 0x04001B1C RID: 6940
		[AccessedThroughProperty("Grupo_relogio")]
		private GroupBox _Grupo_relogio;

		// Token: 0x04001B1D RID: 6941
		[AccessedThroughProperty("Ctrl_relogio")]
		private Timer _Ctrl_relogio;

		// Token: 0x04001B1E RID: 6942
		[AccessedThroughProperty("Valor_hora")]
		private TextBox _Valor_hora;

		// Token: 0x04001B1F RID: 6943
		[AccessedThroughProperty("Valor_data")]
		private TextBox _Valor_data;

		// Token: 0x04001B20 RID: 6944
		[AccessedThroughProperty("Label_hora")]
		private Label _Label_hora;

		// Token: 0x04001B21 RID: 6945
		[AccessedThroughProperty("Label_data")]
		private Label _Label_data;

		// Token: 0x04001B22 RID: 6946
		[AccessedThroughProperty("CheckBox_relogio")]
		private CheckBox _CheckBox_relogio;

		// Token: 0x04001B23 RID: 6947
		[AccessedThroughProperty("Button_atualiza_relogio_micro")]
		private Button _Button_atualiza_relogio_micro;

		// Token: 0x04001B24 RID: 6948
		[AccessedThroughProperty("Button_bloqueio_relogio")]
		private Button _Button_bloqueio_relogio;
	}
}
