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
	// Token: 0x02000082 RID: 130
	[DesignerGenerated]
	public partial class Equip_201_mon : Form
	{
		// Token: 0x06001CD4 RID: 7380 RVA: 0x003D346C File Offset: 0x003D186C
		public Equip_201_mon()
		{
			base.Load += new EventHandler(this.Equip_201_mon_Load);
			base.FormClosed += new FormClosedEventHandler(this.Equip_201_mon_FormClosed);
			this.InitializeComponent();
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x003D61BC File Offset: 0x003D45BC
		// (set) Token: 0x06001CD8 RID: 7384 RVA: 0x003D61D0 File Offset: 0x003D45D0
		internal virtual CheckBox CheckBox_Alm_transbordo
		{
			get
			{
				return this._CheckBox_Alm_transbordo;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_Alm_transbordo_Click);
				if (this._CheckBox_Alm_transbordo != null)
				{
					this._CheckBox_Alm_transbordo.Click -= eventHandler;
				}
				this._CheckBox_Alm_transbordo = value;
				if (this._CheckBox_Alm_transbordo != null)
				{
					this._CheckBox_Alm_transbordo.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x003D621C File Offset: 0x003D461C
		// (set) Token: 0x06001CDA RID: 7386 RVA: 0x003D6230 File Offset: 0x003D4630
		internal virtual CheckBox CheckBox_Alm_energia
		{
			get
			{
				return this._CheckBox_Alm_energia;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_Alm_energia_Click);
				if (this._CheckBox_Alm_energia != null)
				{
					this._CheckBox_Alm_energia.Click -= eventHandler;
				}
				this._CheckBox_Alm_energia = value;
				if (this._CheckBox_Alm_energia != null)
				{
					this._CheckBox_Alm_energia.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x003D627C File Offset: 0x003D467C
		// (set) Token: 0x06001CDC RID: 7388 RVA: 0x003D6290 File Offset: 0x003D4690
		internal virtual CheckBox CheckBox_Alm_nivel
		{
			get
			{
				return this._CheckBox_Alm_nivel;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_Alm_nivel_Click);
				if (this._CheckBox_Alm_nivel != null)
				{
					this._CheckBox_Alm_nivel.Click -= eventHandler;
				}
				this._CheckBox_Alm_nivel = value;
				if (this._CheckBox_Alm_nivel != null)
				{
					this._CheckBox_Alm_nivel.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06001CDD RID: 7389 RVA: 0x003D62DC File Offset: 0x003D46DC
		// (set) Token: 0x06001CDE RID: 7390 RVA: 0x003D62F0 File Offset: 0x003D46F0
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

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x003D62FC File Offset: 0x003D46FC
		// (set) Token: 0x06001CE0 RID: 7392 RVA: 0x003D6310 File Offset: 0x003D4710
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

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x003D631C File Offset: 0x003D471C
		// (set) Token: 0x06001CE2 RID: 7394 RVA: 0x003D6330 File Offset: 0x003D4730
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

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x003D633C File Offset: 0x003D473C
		// (set) Token: 0x06001CE4 RID: 7396 RVA: 0x003D6350 File Offset: 0x003D4750
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

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x003D639C File Offset: 0x003D479C
		// (set) Token: 0x06001CE6 RID: 7398 RVA: 0x003D63B0 File Offset: 0x003D47B0
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

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x003D63BC File Offset: 0x003D47BC
		// (set) Token: 0x06001CE8 RID: 7400 RVA: 0x003D63D0 File Offset: 0x003D47D0
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

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x003D63DC File Offset: 0x003D47DC
		// (set) Token: 0x06001CEA RID: 7402 RVA: 0x003D63F0 File Offset: 0x003D47F0
		internal virtual GroupBox Grupo_simulacao_alarmes
		{
			get
			{
				return this._Grupo_simulacao_alarmes;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_simulacao_alarmes = value;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x003D63FC File Offset: 0x003D47FC
		// (set) Token: 0x06001CEC RID: 7404 RVA: 0x003D6410 File Offset: 0x003D4810
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

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x003D641C File Offset: 0x003D481C
		// (set) Token: 0x06001CEE RID: 7406 RVA: 0x003D6430 File Offset: 0x003D4830
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

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06001CEF RID: 7407 RVA: 0x003D643C File Offset: 0x003D483C
		// (set) Token: 0x06001CF0 RID: 7408 RVA: 0x003D6450 File Offset: 0x003D4850
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

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x003D649C File Offset: 0x003D489C
		// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x003D64B0 File Offset: 0x003D48B0
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

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x003D64BC File Offset: 0x003D48BC
		// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x003D64D0 File Offset: 0x003D48D0
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

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x003D64DC File Offset: 0x003D48DC
		// (set) Token: 0x06001CF6 RID: 7414 RVA: 0x003D64F0 File Offset: 0x003D48F0
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

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x003D64FC File Offset: 0x003D48FC
		// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x003D6510 File Offset: 0x003D4910
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

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x003D651C File Offset: 0x003D491C
		// (set) Token: 0x06001CFA RID: 7418 RVA: 0x003D6530 File Offset: 0x003D4930
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

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x003D657C File Offset: 0x003D497C
		// (set) Token: 0x06001CFC RID: 7420 RVA: 0x003D6590 File Offset: 0x003D4990
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

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x003D65DC File Offset: 0x003D49DC
		// (set) Token: 0x06001CFE RID: 7422 RVA: 0x003D65F0 File Offset: 0x003D49F0
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

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x003D65FC File Offset: 0x003D49FC
		// (set) Token: 0x06001D00 RID: 7424 RVA: 0x003D6610 File Offset: 0x003D4A10
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

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x003D661C File Offset: 0x003D4A1C
		// (set) Token: 0x06001D02 RID: 7426 RVA: 0x003D6630 File Offset: 0x003D4A30
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

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x003D663C File Offset: 0x003D4A3C
		// (set) Token: 0x06001D04 RID: 7428 RVA: 0x003D6650 File Offset: 0x003D4A50
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

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x003D669C File Offset: 0x003D4A9C
		// (set) Token: 0x06001D06 RID: 7430 RVA: 0x003D66B0 File Offset: 0x003D4AB0
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

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x003D66FC File Offset: 0x003D4AFC
		// (set) Token: 0x06001D08 RID: 7432 RVA: 0x003D6710 File Offset: 0x003D4B10
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

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x003D671C File Offset: 0x003D4B1C
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x003D6730 File Offset: 0x003D4B30
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

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x003D673C File Offset: 0x003D4B3C
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x003D6750 File Offset: 0x003D4B50
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

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x003D679C File Offset: 0x003D4B9C
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x003D67B0 File Offset: 0x003D4BB0
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

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x003D67BC File Offset: 0x003D4BBC
		// (set) Token: 0x06001D10 RID: 7440 RVA: 0x003D67D0 File Offset: 0x003D4BD0
		internal virtual CheckBox CheckBox_Alm_energia_status
		{
			get
			{
				return this._CheckBox_Alm_energia_status;
			}
			[MethodImpl(32)]
			set
			{
				this._CheckBox_Alm_energia_status = value;
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x003D67DC File Offset: 0x003D4BDC
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x003D67F0 File Offset: 0x003D4BF0
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

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x003D67FC File Offset: 0x003D4BFC
		// (set) Token: 0x06001D14 RID: 7444 RVA: 0x003D6810 File Offset: 0x003D4C10
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

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x003D681C File Offset: 0x003D4C1C
		// (set) Token: 0x06001D16 RID: 7446 RVA: 0x003D6830 File Offset: 0x003D4C30
		internal virtual GroupBox Grupo_set_B1
		{
			get
			{
				return this._Grupo_set_B1;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_set_B1 = value;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x003D683C File Offset: 0x003D4C3C
		// (set) Token: 0x06001D18 RID: 7448 RVA: 0x003D6850 File Offset: 0x003D4C50
		internal virtual Label Label_desliga_b1
		{
			get
			{
				return this._Label_desliga_b1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_desliga_b1 = value;
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x003D685C File Offset: 0x003D4C5C
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x003D6870 File Offset: 0x003D4C70
		internal virtual Label Label_liga_b1
		{
			get
			{
				return this._Label_liga_b1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_liga_b1 = value;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x003D687C File Offset: 0x003D4C7C
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x003D6890 File Offset: 0x003D4C90
		internal virtual TextBox Set_valor_Liga_B1
		{
			get
			{
				return this._Set_valor_Liga_B1;
			}
			[MethodImpl(32)]
			set
			{
				this._Set_valor_Liga_B1 = value;
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x003D689C File Offset: 0x003D4C9C
		// (set) Token: 0x06001D1E RID: 7454 RVA: 0x003D68B0 File Offset: 0x003D4CB0
		internal virtual TextBox Set_valor_Desiga_B1
		{
			get
			{
				return this._Set_valor_Desiga_B1;
			}
			[MethodImpl(32)]
			set
			{
				this._Set_valor_Desiga_B1 = value;
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x003D68BC File Offset: 0x003D4CBC
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x003D68D0 File Offset: 0x003D4CD0
		internal virtual GroupBox Grupo_set_B3
		{
			get
			{
				return this._Grupo_set_B3;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_set_B3 = value;
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x003D68DC File Offset: 0x003D4CDC
		// (set) Token: 0x06001D22 RID: 7458 RVA: 0x003D68F0 File Offset: 0x003D4CF0
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

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x003D68FC File Offset: 0x003D4CFC
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x003D6910 File Offset: 0x003D4D10
		internal virtual Label Label_liga_b3
		{
			get
			{
				return this._Label_liga_b3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_liga_b3 = value;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x003D691C File Offset: 0x003D4D1C
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x003D6930 File Offset: 0x003D4D30
		internal virtual TextBox Set_valor_Desiga_B3
		{
			get
			{
				return this._Set_valor_Desiga_B3;
			}
			[MethodImpl(32)]
			set
			{
				this._Set_valor_Desiga_B3 = value;
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x003D693C File Offset: 0x003D4D3C
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x003D6950 File Offset: 0x003D4D50
		internal virtual TextBox Set_valor_Liga_B3
		{
			get
			{
				return this._Set_valor_Liga_B3;
			}
			[MethodImpl(32)]
			set
			{
				this._Set_valor_Liga_B3 = value;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x003D695C File Offset: 0x003D4D5C
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x003D6970 File Offset: 0x003D4D70
		internal virtual GroupBox Grupo_set_B2
		{
			get
			{
				return this._Grupo_set_B2;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_set_B2 = value;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x003D697C File Offset: 0x003D4D7C
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x003D6990 File Offset: 0x003D4D90
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

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x003D699C File Offset: 0x003D4D9C
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x003D69B0 File Offset: 0x003D4DB0
		internal virtual Label Label_liga_b2
		{
			get
			{
				return this._Label_liga_b2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_liga_b2 = value;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x003D69BC File Offset: 0x003D4DBC
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x003D69D0 File Offset: 0x003D4DD0
		internal virtual TextBox Set_valor_Desiga_B2
		{
			get
			{
				return this._Set_valor_Desiga_B2;
			}
			[MethodImpl(32)]
			set
			{
				this._Set_valor_Desiga_B2 = value;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x003D69DC File Offset: 0x003D4DDC
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x003D69F0 File Offset: 0x003D4DF0
		internal virtual TextBox Set_valor_Liga_B2
		{
			get
			{
				return this._Set_valor_Liga_B2;
			}
			[MethodImpl(32)]
			set
			{
				this._Set_valor_Liga_B2 = value;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x003D69FC File Offset: 0x003D4DFC
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x003D6A10 File Offset: 0x003D4E10
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

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x003D6A5C File Offset: 0x003D4E5C
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x003D6A70 File Offset: 0x003D4E70
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

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x003D6ABC File Offset: 0x003D4EBC
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x003D6AD0 File Offset: 0x003D4ED0
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

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x003D6B1C File Offset: 0x003D4F1C
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x003D6B30 File Offset: 0x003D4F30
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

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x003D6B3C File Offset: 0x003D4F3C
		// (set) Token: 0x06001D3C RID: 7484 RVA: 0x003D6B50 File Offset: 0x003D4F50
		internal virtual CheckBox CheckBox_Alm_arrombamento
		{
			get
			{
				return this._CheckBox_Alm_arrombamento;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox_Alm_arrombamento_Click);
				if (this._CheckBox_Alm_arrombamento != null)
				{
					this._CheckBox_Alm_arrombamento.Click -= eventHandler;
				}
				this._CheckBox_Alm_arrombamento = value;
				if (this._CheckBox_Alm_arrombamento != null)
				{
					this._CheckBox_Alm_arrombamento.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x003D6B9C File Offset: 0x003D4F9C
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x003D6BB0 File Offset: 0x003D4FB0
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

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x003D6BFC File Offset: 0x003D4FFC
		// (set) Token: 0x06001D40 RID: 7488 RVA: 0x003D6C10 File Offset: 0x003D5010
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

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x003D6C5C File Offset: 0x003D505C
		// (set) Token: 0x06001D42 RID: 7490 RVA: 0x003D6C70 File Offset: 0x003D5070
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

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x003D6C7C File Offset: 0x003D507C
		// (set) Token: 0x06001D44 RID: 7492 RVA: 0x003D6C90 File Offset: 0x003D5090
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

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x003D6CDC File Offset: 0x003D50DC
		// (set) Token: 0x06001D46 RID: 7494 RVA: 0x003D6CF0 File Offset: 0x003D50F0
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

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06001D47 RID: 7495 RVA: 0x003D6CFC File Offset: 0x003D50FC
		// (set) Token: 0x06001D48 RID: 7496 RVA: 0x003D6D10 File Offset: 0x003D5110
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

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001D49 RID: 7497 RVA: 0x003D6D1C File Offset: 0x003D511C
		// (set) Token: 0x06001D4A RID: 7498 RVA: 0x003D6D30 File Offset: 0x003D5130
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

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x003D6D3C File Offset: 0x003D513C
		// (set) Token: 0x06001D4C RID: 7500 RVA: 0x003D6D50 File Offset: 0x003D5150
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

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x003D6D5C File Offset: 0x003D515C
		// (set) Token: 0x06001D4E RID: 7502 RVA: 0x003D6D70 File Offset: 0x003D5170
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

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x003D6D7C File Offset: 0x003D517C
		// (set) Token: 0x06001D50 RID: 7504 RVA: 0x003D6D90 File Offset: 0x003D5190
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

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x003D6D9C File Offset: 0x003D519C
		// (set) Token: 0x06001D52 RID: 7506 RVA: 0x003D6DB0 File Offset: 0x003D51B0
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

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x003D6DBC File Offset: 0x003D51BC
		// (set) Token: 0x06001D54 RID: 7508 RVA: 0x003D6DD0 File Offset: 0x003D51D0
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

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x003D6DDC File Offset: 0x003D51DC
		// (set) Token: 0x06001D56 RID: 7510 RVA: 0x003D6DF0 File Offset: 0x003D51F0
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

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x003D6E3C File Offset: 0x003D523C
		// (set) Token: 0x06001D58 RID: 7512 RVA: 0x003D6E50 File Offset: 0x003D5250
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

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x003D6E9C File Offset: 0x003D529C
		// (set) Token: 0x06001D5A RID: 7514 RVA: 0x003D6EB0 File Offset: 0x003D52B0
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

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x003D6EFC File Offset: 0x003D52FC
		// (set) Token: 0x06001D5C RID: 7516 RVA: 0x003D6F10 File Offset: 0x003D5310
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

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x003D6F5C File Offset: 0x003D535C
		// (set) Token: 0x06001D5E RID: 7518 RVA: 0x003D6F70 File Offset: 0x003D5370
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

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001D5F RID: 7519 RVA: 0x003D6FBC File Offset: 0x003D53BC
		// (set) Token: 0x06001D60 RID: 7520 RVA: 0x003D6FD0 File Offset: 0x003D53D0
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

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x003D701C File Offset: 0x003D541C
		// (set) Token: 0x06001D62 RID: 7522 RVA: 0x003D7030 File Offset: 0x003D5430
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

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x003D703C File Offset: 0x003D543C
		// (set) Token: 0x06001D64 RID: 7524 RVA: 0x003D7050 File Offset: 0x003D5450
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

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x003D705C File Offset: 0x003D545C
		// (set) Token: 0x06001D66 RID: 7526 RVA: 0x003D7070 File Offset: 0x003D5470
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

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x003D707C File Offset: 0x003D547C
		// (set) Token: 0x06001D68 RID: 7528 RVA: 0x003D7090 File Offset: 0x003D5490
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

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x003D709C File Offset: 0x003D549C
		// (set) Token: 0x06001D6A RID: 7530 RVA: 0x003D70B0 File Offset: 0x003D54B0
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

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x003D70BC File Offset: 0x003D54BC
		// (set) Token: 0x06001D6C RID: 7532 RVA: 0x003D70D0 File Offset: 0x003D54D0
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

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x003D70DC File Offset: 0x003D54DC
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x003D70F0 File Offset: 0x003D54F0
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

		// Token: 0x06001D6F RID: 7535 RVA: 0x003D713C File Offset: 0x003D553C
		private void Equip_201_mon_Load(object sender, EventArgs e)
		{
			Geral.Config_geral.Largura_tela_trabalho = this.Width;
			this.Mensagem_MD201_mon("Monitoração desativada", 2);
			this.Grupo_setpoints.Enabled = false;
			this.Grupo_escrita_de_dados.Enabled = false;
			this.Grupo_status.Enabled = false;
			this.Grupo_estatistica.Enabled = false;
			int num = 48;
			Interaction.MsgBox("Colocar o equipamento em modo de monitoração !\r\nAbrir o jumper de configuração.", num, " Atenção - verifique a configuração");
			this.Comando_le_setpoint.Enabled = false;
			this.Comando_escreve_setpoint.Enabled = false;
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x003D71C4 File Offset: 0x003D55C4
		private void Comando_hab_monitoracao_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null), "Iniciar", false))
			{
				if (Mod_MD.Monitoracao_MD_RQ.Estacao > 0 & Mod_MD.Monitoracao_MD_RQ.Estacao <= 200)
				{
					NewLateBinding.LateSet(sender, null, "text", new object[]
					{
						"Parar"
					}, null, null);
					this.Mensagem_MD201_mon("Monitoração Ativada", 2);
					Mod_MD.Monitoracao_MD_RQ.Controle_mon = 1;
					Mod_MD.Monitoracao_MD_RQ.Partir_mon = true;
					this.Timer_monitoracao.Enabled = true;
					this.Grupo_setpoints.Enabled = true;
					this.Grupo_escrita_de_dados.Enabled = true;
					this.Grupo_status.Enabled = true;
					this.Grupo_estatistica.Enabled = true;
				}
				else
				{
					this.Mensagem_MD201_mon("Selecione Estação", 1);
				}
			}
			else
			{
				NewLateBinding.LateSet(sender, null, "text", new object[]
				{
					"Iniciar"
				}, null, null);
				this.Mensagem_MD201_mon("Monitoração desativada", 2);
				Mod_MD.Monitoracao_MD_RQ.Partir_mon = false;
				this.Timer_monitoracao.Enabled = false;
				this.Grupo_setpoints.Enabled = false;
				this.Grupo_escrita_de_dados.Enabled = false;
				this.Grupo_status.Enabled = false;
				this.Grupo_estatistica.Enabled = false;
			}
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x003D7334 File Offset: 0x003D5734
		public void Inicializa_tela_equipamento_MD201_mon()
		{
			if (Operators.CompareString(this.Comando_hab_monitoracao.Text, "Iniciar", false) != 0)
			{
				this.Mensagem_MD201_mon(" Aguarde ... ", 2);
				Mod_MD.Monitoracao_MD_RQ.Controle_mon = 1;
			}
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x003D7368 File Offset: 0x003D5768
		public void Mensagem_MD201_mon(string msg, int cor)
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

		// Token: 0x06001D73 RID: 7539 RVA: 0x003D73CC File Offset: 0x003D57CC
		private void Timer_monitoracao_Tick(object sender, EventArgs e)
		{
			int[] array = new int[41];
			this.Timer_monitoracao.Enabled = false;
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
							this.Mensagem_MD201_mon("Leitura Setpoints - Ok", 0);
							this.Calcula_Estatistica(1);
							this.Atualiza_setpoint_monitoracao();
							goto IL_15C;
						case 1:
							goto IL_123;
						case 2:
							if (i == 0)
							{
								this.Mensagem_MD201_mon("Erro Leitura Setpoints - ChkSum", 1);
								this.Calcula_Estatistica(3);
								this.Limpa_monitoracao_201(2);
							}
							else
							{
								this.Calcula_Estatistica(2);
							}
							break;
						case 3:
							if (i == 0)
							{
								this.Mensagem_MD201_mon("Erro Leitura Setpoints - Timeout", 1);
								this.Calcula_Estatistica(3);
								this.Limpa_monitoracao_201(2);
							}
							else
							{
								this.Calcula_Estatistica(2);
							}
							break;
						default:
													}
						IL_14A:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_123:
						if (i == 0)
						{
							this.Mensagem_MD201_mon("Erro Leitura Setpoints - não determinado", 1);
							this.Calcula_Estatistica(3);
							this.Limpa_monitoracao_201(2);
													}
						this.Calcula_Estatistica(2);
											}
					IL_15C:
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
						array[0] = Mod_MD.Monitoracao_MD_RQ.Nivel_dest * 2;
						array[1] = Mod_MD.Monitoracao_MD_RQ.alarmes;
						Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, 57, 2, array);
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
						switch (Comunicacao.Ctrl_Com.Frame)
						{
						case 0:
							this.Mensagem_MD201_mon("Leitura Equipamento - Ok", 0);
							this.Calcula_Estatistica(1);
							this.Atualiza_status_monitoracao();
							goto IL_2D0;
						case 1:
							goto IL_297;
						case 2:
							if (i == 0)
							{
								this.Mensagem_MD201_mon("Erro Leitura Equipamento - ChkSum", 1);
								this.Calcula_Estatistica(3);
								this.Limpa_monitoracao_201(1);
							}
							else
							{
								this.Calcula_Estatistica(2);
							}
							break;
						case 3:
							if (i == 0)
							{
								this.Mensagem_MD201_mon("Erro Leitura Equipamento - Timeout", 1);
								this.Calcula_Estatistica(3);
								this.Limpa_monitoracao_201(1);
							}
							else
							{
								this.Calcula_Estatistica(2);
							}
							break;
						default:
													}
						IL_2BE:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_297:
						if (i == 0)
						{
							this.Mensagem_MD201_mon("Erro Leitura Equipamento - não determinado", 1);
							this.Calcula_Estatistica(3);
							this.Limpa_monitoracao_201(1);
													}
						this.Calcula_Estatistica(2);
											}
					IL_2D0:
					MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
					break;
				case 3:
					i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
					Mod_MD.Monitoracao_MD_RQ.Controle_mon = 2;
					while (i > 0)
					{
						i--;
						array[0] = (int)Math.Round(unchecked(Conversion.Val(this.Set_valor_Liga_B1.Text) * 2.0));
						array[1] = (int)Math.Round(unchecked(Conversion.Val(this.Set_valor_Liga_B2.Text) * 2.0));
						array[2] = (int)Math.Round(unchecked(Conversion.Val(this.Set_valor_Liga_B3.Text) * 2.0));
						array[3] = (int)Math.Round(unchecked(Conversion.Val(this.Set_valor_Desiga_B1.Text) * 2.0));
						array[4] = (int)Math.Round(unchecked(Conversion.Val(this.Set_valor_Desiga_B2.Text) * 2.0));
						array[5] = (int)Math.Round(unchecked(Conversion.Val(this.Set_valor_Desiga_B3.Text) * 2.0));
						array[6] = 0;
						array[7] = 0;
						array[8] = 0;
						array[9] = 0;
						Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RQ.Estacao, Mod_MD.Monitoracao_MD_RQ.Mestre, 66, 10, array);
						do
						{
							Application.DoEvents();
						}
						while (Comunicacao.Ctrl_Com.Frame == 255);
						switch (Comunicacao.Ctrl_Com.Frame)
						{
						case 0:
							this.Mensagem_MD201_mon("Escrita Setpoints - Ok", 0);
							this.Calcula_Estatistica(1);
							goto IL_4D6;
						case 1:
							goto IL_4A4;
						case 2:
							if (i == 0)
							{
								this.Mensagem_MD201_mon("Erro Escrita Setpoints - ChkSum", 1);
								this.Calcula_Estatistica(3);
							}
							else
							{
								this.Calcula_Estatistica(2);
							}
							break;
						case 3:
							if (i == 0)
							{
								this.Mensagem_MD201_mon("Erro Escrita Setpoints - Timeout", 1);
								this.Calcula_Estatistica(3);
							}
							else
							{
								this.Calcula_Estatistica(2);
							}
							break;
						default:
													}
						IL_4C4:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_4A4:
						if (i == 0)
						{
							this.Mensagem_MD201_mon("Erro Escrita Setpoints - não determinado", 1);
							this.Calcula_Estatistica(3);
													}
						this.Calcula_Estatistica(2);
											}
					IL_4D6:
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
							this.Mensagem_MD201_mon(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
							this.Calcula_Estatistica(1);
													}
						case 1:
							goto IL_601;
						case 2:
							if (i == 0)
							{
								this.Mensagem_MD201_mon("Erro ao executar o camando - ChkSum", 1);
								this.Calcula_Estatistica(3);
							}
							else
							{
								this.Calcula_Estatistica(2);
							}
							break;
						case 3:
							if (i == 0)
							{
								this.Mensagem_MD201_mon("Erro ao executar o camando - Timeout", 1);
								this.Calcula_Estatistica(3);
							}
							else
							{
								this.Calcula_Estatistica(2);
							}
							break;
						default:
													}
						IL_621:
						Comunicacao.Rotina_Delay(400L);
						continue;
						IL_601:
						if (i == 0)
						{
							this.Mensagem_MD201_mon("Erro ao executar o camando - não determinado", 1);
							this.Calcula_Estatistica(3);
													}
						this.Calcula_Estatistica(2);
											}
					IL_633:
					MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
					break;
				}
				if (Mod_MD.Monitoracao_MD_RQ.Partir_mon)
				{
					this.Timer_monitoracao.Enabled = true;
				}
			}
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x003D7A40 File Offset: 0x003D5E40
		private void CheckBox_Alm_energia_Click(object sender, EventArgs e)
		{
			bool flag = ((CheckBox)sender).Checked;
			flag = !flag;
			((CheckBox)sender).Checked = flag;
			if (flag)
			{
				Mod_MD.Monitoracao_MD_RQ.alarmes = (Mod_MD.Monitoracao_MD_RQ.alarmes | 1);
			}
			else
			{
				Mod_MD.Monitoracao_MD_RQ.alarmes = (Mod_MD.Monitoracao_MD_RQ.alarmes & -2);
			}
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x003D7A9C File Offset: 0x003D5E9C
		private void CheckBox_Alm_transbordo_Click(object sender, EventArgs e)
		{
			bool flag = ((CheckBox)sender).Checked;
			flag = !flag;
			((CheckBox)sender).Checked = flag;
			if (flag)
			{
				Mod_MD.Monitoracao_MD_RQ.alarmes = (Mod_MD.Monitoracao_MD_RQ.alarmes | 4);
				this.Tela_nivel_destino.Enabled = false;
				this.Tela_nivel_destino.Value = 100m;
				Mod_MD.Monitoracao_MD_RQ.Nivel_dest = 100;
			}
			else
			{
				Mod_MD.Monitoracao_MD_RQ.alarmes = (Mod_MD.Monitoracao_MD_RQ.alarmes & -5);
				this.Tela_nivel_destino.Enabled = true;
			}
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x003D7B30 File Offset: 0x003D5F30
		private void CheckBox_Alm_arrombamento_Click(object sender, EventArgs e)
		{
			bool flag = ((CheckBox)sender).Checked;
			flag = !flag;
			((CheckBox)sender).Checked = flag;
			if (flag)
			{
				Mod_MD.Monitoracao_MD_RQ.alarmes = (Mod_MD.Monitoracao_MD_RQ.alarmes | 32);
			}
			else
			{
				Mod_MD.Monitoracao_MD_RQ.alarmes = (Mod_MD.Monitoracao_MD_RQ.alarmes & -33);
			}
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x003D7B90 File Offset: 0x003D5F90
		private void CheckBox_Alm_nivel_Click(object sender, EventArgs e)
		{
			bool flag = ((CheckBox)sender).Checked;
			flag = !flag;
			((CheckBox)sender).Checked = flag;
			if (flag)
			{
				Mod_MD.Monitoracao_MD_RQ.alarmes = (Mod_MD.Monitoracao_MD_RQ.alarmes | 16);
				this.Tela_nivel_destino.Enabled = false;
				this.Tela_nivel_destino.Value = 100m;
				Mod_MD.Monitoracao_MD_RQ.Nivel_dest = 100;
			}
			else
			{
				Mod_MD.Monitoracao_MD_RQ.alarmes = (Mod_MD.Monitoracao_MD_RQ.alarmes & -17);
				this.Tela_nivel_destino.Enabled = true;
			}
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x003D7C24 File Offset: 0x003D6024
		private void Tela_endereco_mestre_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Mestre = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Inicializa_tela_equipamento_MD201_mon();
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x003D7C50 File Offset: 0x003D6050
		private void Tela_endereco_estacao_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Estacao = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.Inicializa_tela_equipamento_MD201_mon();
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x003D7C7C File Offset: 0x003D607C
		private void Button_limpa_estatistica_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Num_Rx = 0L;
			Mod_MD.Monitoracao_MD_RQ.Num_Tx = 0L;
			Mod_MD.Monitoracao_MD_RQ.Eficiencia_com = 0;
			Mod_MD.Monitoracao_MD_RQ.Num_Retry = 0L;
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x003D7CB0 File Offset: 0x003D60B0
		public void Calcula_Estatistica(int opcao)
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

		// Token: 0x06001D7C RID: 7548 RVA: 0x003D7DF0 File Offset: 0x003D61F0
		public void Atualiza_setpoint_monitoracao()
		{
			checked
			{
				this.Set_valor_Liga_B1.Text = Conversions.ToString((double)(Comunicacao.Buffer_resp[4] - 48) / 2.0);
				this.Set_valor_Liga_B2.Text = Conversions.ToString((double)(Comunicacao.Buffer_resp[5] - 48) / 2.0);
				this.Set_valor_Liga_B3.Text = Conversions.ToString((double)(Comunicacao.Buffer_resp[6] - 48) / 2.0);
				this.Set_valor_Desiga_B1.Text = Conversions.ToString((double)(Comunicacao.Buffer_resp[7] - 48) / 2.0);
				this.Set_valor_Desiga_B2.Text = Conversions.ToString((double)(Comunicacao.Buffer_resp[8] - 48) / 2.0);
				this.Set_valor_Desiga_B3.Text = Conversions.ToString((double)(Comunicacao.Buffer_resp[9] - 48) / 2.0);
			}
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x003D7EDC File Offset: 0x003D62DC
		public void Atualiza_status_monitoracao()
		{
			checked
			{
				int num = (int)(Comunicacao.Buffer_resp[4] - 48);
				int num2 = (int)(Comunicacao.Buffer_resp[5] - 48);
				int num3 = (int)(Comunicacao.Buffer_resp[6] - 48);
				this.Status_b1.Text = Mod_MD.Mensagem_status_bomba_201(num);
				this.Status_b2.Text = Mod_MD.Mensagem_status_bomba_201(num2);
				this.Status_b3.Text = Mod_MD.Mensagem_status_bomba_201(num3);
				this.Modo_b1.Text = Mod_MD.Mensagem_modo_bomba_201((int)(Comunicacao.Buffer_resp[4] - 48));
				this.Modo_b2.Text = Mod_MD.Mensagem_modo_bomba_201((int)(Comunicacao.Buffer_resp[5] - 48));
				this.Modo_b3.Text = Mod_MD.Mensagem_modo_bomba_201((int)(Comunicacao.Buffer_resp[6] - 48));
				this.CheckBox_Alm_arrombamento_status.Checked = Mod_MD.Alarme_recalque_201((int)(Comunicacao.Buffer_resp[7] - 48), 8);
				this.CheckBox_Alm_energia_status.Checked = Mod_MD.Alarme_recalque_201((int)(Comunicacao.Buffer_resp[7] - 48), 1);
				this.CheckBox_Alm_alagamento_status.Checked = Mod_MD.Alarme_recalque_201((int)(Comunicacao.Buffer_resp[7] - 48), 16);
				this.Cmd_manual_b1.Enabled = false;
				this.Cmd_automatico_b1.Enabled = false;
				this.Cmd_liga_b1.Enabled = false;
				this.Cmd_desliga_b1.Enabled = false;
				if ((num & -33) != 0)
				{
					if (Operators.CompareString(this.Modo_b1.Text, "Automático", false) == 0)
					{
						this.Cmd_manual_b1.Enabled = true;
					}
					else
					{
						this.Cmd_automatico_b1.Enabled = true;
						this.Cmd_liga_b1.Enabled = true;
						this.Cmd_desliga_b1.Enabled = true;
					}
				}
				this.Cmd_manual_b2.Enabled = false;
				this.Cmd_automatico_b2.Enabled = false;
				this.Cmd_liga_b2.Enabled = false;
				this.Cmd_desliga_b2.Enabled = false;
				if ((num2 & -33) != 0)
				{
					if (Operators.CompareString(this.Modo_b2.Text, "Automático", false) == 0)
					{
						this.Cmd_manual_b2.Enabled = true;
					}
					else
					{
						this.Cmd_automatico_b2.Enabled = true;
						this.Cmd_liga_b2.Enabled = true;
						this.Cmd_desliga_b2.Enabled = true;
					}
				}
				this.Cmd_manual_b3.Enabled = false;
				this.Cmd_automatico_b3.Enabled = false;
				this.Cmd_liga_b3.Enabled = false;
				this.Cmd_desliga_b3.Enabled = false;
				if ((num3 & -33) != 0)
				{
					if (Operators.CompareString(this.Modo_b3.Text, "Automático", false) == 0)
					{
						this.Cmd_manual_b3.Enabled = true;
					}
					else
					{
						this.Cmd_automatico_b3.Enabled = true;
						this.Cmd_liga_b3.Enabled = true;
						this.Cmd_desliga_b3.Enabled = true;
					}
				}
			}
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x003D8164 File Offset: 0x003D6564
		public void Limpa_monitoracao_201(int tipo)
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
				this.CheckBox_Alm_energia_status.Checked = false;
				this.CheckBox_Alm_alagamento_status.Checked = false;
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
				this.Set_valor_Liga_B1.Text = "";
				this.Set_valor_Liga_B2.Text = "";
				this.Set_valor_Liga_B3.Text = "";
				this.Set_valor_Desiga_B1.Text = "";
				this.Set_valor_Desiga_B2.Text = "";
				this.Set_valor_Desiga_B3.Text = "";
				break;
			}
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x003D8328 File Offset: 0x003D6728
		private void Comando_le_setpoint_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			this.Comando_le_setpoint.Enabled = false;
			this.Comando_escreve_setpoint.Enabled = false;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 1;
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x003D8368 File Offset: 0x003D6768
		private void Comando_escreve_setpoint_Click(object sender, EventArgs e)
		{
			object obj = true;
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			if ((checked((long)Math.Round(Conversion.Val(Conversions.ToDouble(this.Set_valor_Desiga_B1.Text) > Conversion.Val(this.Set_valor_Liga_B1.Text)))) & ((-(((Conversions.ToDouble(this.Set_valor_Liga_B1.Text) != 0.0) > false) ? 1L : 0L)) ? 1L : 0L)) != 0L && (checked((long)Math.Round(Conversion.Val(Conversions.ToDouble(this.Set_valor_Desiga_B2.Text) > Conversion.Val(this.Set_valor_Liga_B2.Text)))) & ((-(((Conversions.ToDouble(this.Set_valor_Liga_B2.Text) != 0.0) > false) ? 1L : 0L)) ? 1L : 0L)) != 0L && (checked((long)Math.Round(Conversion.Val(Conversions.ToDouble(this.Set_valor_Desiga_B3.Text) > Conversion.Val(this.Set_valor_Liga_B3.Text)))) & ((-(((Conversions.ToDouble(this.Set_valor_Liga_B3.Text) != 0.0) > false) ? 1L : 0L)) ? 1L : 0L)) != 0L)
			{
				obj = false;
			}
			if (Operators.ConditionalCompareObjectEqual(obj, true, false))
			{
				Interaction.MsgBox("                Verifique o preenchimento dos campos de setpoints.\r\nTodos os campos devem ter valores não nulos e o limite para desligar maior que o para ligar.", (MsgBoxStyle)48, null);
			}
			else
			{
				this.Comando_escreve_setpoint.Enabled = false;
				this.Comando_le_setpoint.Enabled = false;
				Mod_MD.Monitoracao_MD_RQ.Controle_mon = 3;
			}
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x003D84F8 File Offset: 0x003D68F8
		private void Tela_nivel_destino_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Nivel_dest = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x003D8520 File Offset: 0x003D6920
		private void Cmd_manual_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x003D8544 File Offset: 0x003D6944
		private void Cmd_automatico_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x003D8568 File Offset: 0x003D6968
		private void Cmd_liga_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x003D858C File Offset: 0x003D698C
		private void Cmd_desliga_b1_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 1;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x003D85B0 File Offset: 0x003D69B0
		private void Cmd_liga_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x003D85D4 File Offset: 0x003D69D4
		private void Cmd_desliga_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x003D85F8 File Offset: 0x003D69F8
		private void Cmd_automatico_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x003D861C File Offset: 0x003D6A1C
		private void Cmd_manual_b2_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 2;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x003D8640 File Offset: 0x003D6A40
		private void Cmd_liga_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 67;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x003D8664 File Offset: 0x003D6A64
		private void Cmd_desliga_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 68;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x003D8688 File Offset: 0x003D6A88
		private void Cmd_automatico_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 70;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x003D86AC File Offset: 0x003D6AAC
		private void Cmd_manual_b3_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Numero_motor = 3;
			Mod_MD.Monitoracao_MD_RQ.Comando = 69;
			Mod_MD.Monitoracao_MD_RQ.Controle_mon = 4;
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x003D86D0 File Offset: 0x003D6AD0
		private void Equip_201_mon_FormClosed(object sender, FormClosedEventArgs e)
		{
			Mod_MD.Monitoracao_MD_RQ.Partir_mon = false;
			this.Timer_monitoracao.Enabled = false;
		}

		// Token: 0x04001588 RID: 5512
		[AccessedThroughProperty("CheckBox_Alm_transbordo")]
		private CheckBox _CheckBox_Alm_transbordo;

		// Token: 0x04001589 RID: 5513
		[AccessedThroughProperty("CheckBox_Alm_energia")]
		private CheckBox _CheckBox_Alm_energia;

		// Token: 0x0400158A RID: 5514
		[AccessedThroughProperty("CheckBox_Alm_nivel")]
		private CheckBox _CheckBox_Alm_nivel;

		// Token: 0x0400158B RID: 5515
		[AccessedThroughProperty("Grupo_escrita_de_dados")]
		private GroupBox _Grupo_escrita_de_dados;

		// Token: 0x0400158C RID: 5516
		[AccessedThroughProperty("Grupo_ctrl_com")]
		private GroupBox _Grupo_ctrl_com;

		// Token: 0x0400158D RID: 5517
		[AccessedThroughProperty("msg")]
		private TextBox _msg;

		// Token: 0x0400158E RID: 5518
		[AccessedThroughProperty("Comando_hab_monitoracao")]
		private Button _Comando_hab_monitoracao;

		// Token: 0x0400158F RID: 5519
		[AccessedThroughProperty("Label_end_estacao")]
		private Label _Label_end_estacao;

		// Token: 0x04001590 RID: 5520
		[AccessedThroughProperty("Label_nivel_destino")]
		private Label _Label_nivel_destino;

		// Token: 0x04001591 RID: 5521
		[AccessedThroughProperty("Grupo_simulacao_alarmes")]
		private GroupBox _Grupo_simulacao_alarmes;

		// Token: 0x04001592 RID: 5522
		[AccessedThroughProperty("Grupo_status")]
		private GroupBox _Grupo_status;

		// Token: 0x04001593 RID: 5523
		[AccessedThroughProperty("Grupo_bomba1")]
		private GroupBox _Grupo_bomba1;

		// Token: 0x04001594 RID: 5524
		[AccessedThroughProperty("Cmd_liga_b1")]
		private Button _Cmd_liga_b1;

		// Token: 0x04001595 RID: 5525
		[AccessedThroughProperty("Label_status_b1")]
		private Label _Label_status_b1;

		// Token: 0x04001596 RID: 5526
		[AccessedThroughProperty("Status_b1")]
		private TextBox _Status_b1;

		// Token: 0x04001597 RID: 5527
		[AccessedThroughProperty("Grupo_alarmes")]
		private GroupBox _Grupo_alarmes;

		// Token: 0x04001598 RID: 5528
		[AccessedThroughProperty("Grupo_bomba3")]
		private GroupBox _Grupo_bomba3;

		// Token: 0x04001599 RID: 5529
		[AccessedThroughProperty("Cmd_desliga_b3")]
		private Button _Cmd_desliga_b3;

		// Token: 0x0400159A RID: 5530
		[AccessedThroughProperty("Cmd_liga_b3")]
		private Button _Cmd_liga_b3;

		// Token: 0x0400159B RID: 5531
		[AccessedThroughProperty("Label_status_b3")]
		private Label _Label_status_b3;

		// Token: 0x0400159C RID: 5532
		[AccessedThroughProperty("Status_b3")]
		private TextBox _Status_b3;

		// Token: 0x0400159D RID: 5533
		[AccessedThroughProperty("Grupo_bomba2")]
		private GroupBox _Grupo_bomba2;

		// Token: 0x0400159E RID: 5534
		[AccessedThroughProperty("Cmd_desliga_b2")]
		private Button _Cmd_desliga_b2;

		// Token: 0x0400159F RID: 5535
		[AccessedThroughProperty("Cmd_liga_b2")]
		private Button _Cmd_liga_b2;

		// Token: 0x040015A0 RID: 5536
		[AccessedThroughProperty("Label_status_b2")]
		private Label _Label_status_b2;

		// Token: 0x040015A1 RID: 5537
		[AccessedThroughProperty("Status_b2")]
		private TextBox _Status_b2;

		// Token: 0x040015A2 RID: 5538
		[AccessedThroughProperty("Cmd_desliga_b1")]
		private Button _Cmd_desliga_b1;

		// Token: 0x040015A3 RID: 5539
		[AccessedThroughProperty("CheckBox_Alm_alagamento_status")]
		private CheckBox _CheckBox_Alm_alagamento_status;

		// Token: 0x040015A4 RID: 5540
		[AccessedThroughProperty("CheckBox_Alm_energia_status")]
		private CheckBox _CheckBox_Alm_energia_status;

		// Token: 0x040015A5 RID: 5541
		[AccessedThroughProperty("CheckBox_Alm_arrombamento_status")]
		private CheckBox _CheckBox_Alm_arrombamento_status;

		// Token: 0x040015A6 RID: 5542
		[AccessedThroughProperty("Grupo_setpoints")]
		private GroupBox _Grupo_setpoints;

		// Token: 0x040015A7 RID: 5543
		[AccessedThroughProperty("Grupo_set_B1")]
		private GroupBox _Grupo_set_B1;

		// Token: 0x040015A8 RID: 5544
		[AccessedThroughProperty("Label_desliga_b1")]
		private Label _Label_desliga_b1;

		// Token: 0x040015A9 RID: 5545
		[AccessedThroughProperty("Label_liga_b1")]
		private Label _Label_liga_b1;

		// Token: 0x040015AA RID: 5546
		[AccessedThroughProperty("Set_valor_Liga_B1")]
		private TextBox _Set_valor_Liga_B1;

		// Token: 0x040015AB RID: 5547
		[AccessedThroughProperty("Set_valor_Desiga_B1")]
		private TextBox _Set_valor_Desiga_B1;

		// Token: 0x040015AC RID: 5548
		[AccessedThroughProperty("Grupo_set_B3")]
		private GroupBox _Grupo_set_B3;

		// Token: 0x040015AD RID: 5549
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040015AE RID: 5550
		[AccessedThroughProperty("Label_liga_b3")]
		private Label _Label_liga_b3;

		// Token: 0x040015AF RID: 5551
		[AccessedThroughProperty("Set_valor_Desiga_B3")]
		private TextBox _Set_valor_Desiga_B3;

		// Token: 0x040015B0 RID: 5552
		[AccessedThroughProperty("Set_valor_Liga_B3")]
		private TextBox _Set_valor_Liga_B3;

		// Token: 0x040015B1 RID: 5553
		[AccessedThroughProperty("Grupo_set_B2")]
		private GroupBox _Grupo_set_B2;

		// Token: 0x040015B2 RID: 5554
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040015B3 RID: 5555
		[AccessedThroughProperty("Label_liga_b2")]
		private Label _Label_liga_b2;

		// Token: 0x040015B4 RID: 5556
		[AccessedThroughProperty("Set_valor_Desiga_B2")]
		private TextBox _Set_valor_Desiga_B2;

		// Token: 0x040015B5 RID: 5557
		[AccessedThroughProperty("Set_valor_Liga_B2")]
		private TextBox _Set_valor_Liga_B2;

		// Token: 0x040015B6 RID: 5558
		[AccessedThroughProperty("Comando_escreve_setpoint")]
		private Button _Comando_escreve_setpoint;

		// Token: 0x040015B7 RID: 5559
		[AccessedThroughProperty("Comando_le_setpoint")]
		private Button _Comando_le_setpoint;

		// Token: 0x040015B8 RID: 5560
		[AccessedThroughProperty("Timer_monitoracao")]
		private Timer _Timer_monitoracao;

		// Token: 0x040015B9 RID: 5561
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040015BA RID: 5562
		[AccessedThroughProperty("CheckBox_Alm_arrombamento")]
		private CheckBox _CheckBox_Alm_arrombamento;

		// Token: 0x040015BB RID: 5563
		[AccessedThroughProperty("Tela_endereco_mestre")]
		private NumericUpDown _Tela_endereco_mestre;

		// Token: 0x040015BC RID: 5564
		[AccessedThroughProperty("Tela_endereco_estacao")]
		private NumericUpDown _Tela_endereco_estacao;

		// Token: 0x040015BD RID: 5565
		[AccessedThroughProperty("Grupo_estatistica")]
		private GroupBox _Grupo_estatistica;

		// Token: 0x040015BE RID: 5566
		[AccessedThroughProperty("Button_limpa_estatistica")]
		private Button _Button_limpa_estatistica;

		// Token: 0x040015BF RID: 5567
		[AccessedThroughProperty("Label_Est_RX")]
		private Label _Label_Est_RX;

		// Token: 0x040015C0 RID: 5568
		[AccessedThroughProperty("Label_Est_Eficiencia")]
		private Label _Label_Est_Eficiencia;

		// Token: 0x040015C1 RID: 5569
		[AccessedThroughProperty("Label_Est_TX")]
		private Label _Label_Est_TX;

		// Token: 0x040015C2 RID: 5570
		[AccessedThroughProperty("Est_Rx")]
		private TextBox _Est_Rx;

		// Token: 0x040015C3 RID: 5571
		[AccessedThroughProperty("Est_eficiencia")]
		private TextBox _Est_eficiencia;

		// Token: 0x040015C4 RID: 5572
		[AccessedThroughProperty("Est_TX")]
		private TextBox _Est_TX;

		// Token: 0x040015C5 RID: 5573
		[AccessedThroughProperty("Label_Est_retry")]
		private Label _Label_Est_retry;

		// Token: 0x040015C6 RID: 5574
		[AccessedThroughProperty("Est_retry")]
		private TextBox _Est_retry;

		// Token: 0x040015C7 RID: 5575
		[AccessedThroughProperty("Cmd_manual_b3")]
		private Button _Cmd_manual_b3;

		// Token: 0x040015C8 RID: 5576
		[AccessedThroughProperty("Cmd_automatico_b3")]
		private Button _Cmd_automatico_b3;

		// Token: 0x040015C9 RID: 5577
		[AccessedThroughProperty("Cmd_manual_b2")]
		private Button _Cmd_manual_b2;

		// Token: 0x040015CA RID: 5578
		[AccessedThroughProperty("Cmd_automatico_b2")]
		private Button _Cmd_automatico_b2;

		// Token: 0x040015CB RID: 5579
		[AccessedThroughProperty("Cmd_manual_b1")]
		private Button _Cmd_manual_b1;

		// Token: 0x040015CC RID: 5580
		[AccessedThroughProperty("Cmd_automatico_b1")]
		private Button _Cmd_automatico_b1;

		// Token: 0x040015CD RID: 5581
		[AccessedThroughProperty("Label_modo_b2")]
		private Label _Label_modo_b2;

		// Token: 0x040015CE RID: 5582
		[AccessedThroughProperty("Modo_b2")]
		private TextBox _Modo_b2;

		// Token: 0x040015CF RID: 5583
		[AccessedThroughProperty("Label_modo_b1")]
		private Label _Label_modo_b1;

		// Token: 0x040015D0 RID: 5584
		[AccessedThroughProperty("Modo_b1")]
		private TextBox _Modo_b1;

		// Token: 0x040015D1 RID: 5585
		[AccessedThroughProperty("Label_modo_b3")]
		private Label _Label_modo_b3;

		// Token: 0x040015D2 RID: 5586
		[AccessedThroughProperty("Modo_b3")]
		private TextBox _Modo_b3;

		// Token: 0x040015D3 RID: 5587
		[AccessedThroughProperty("Tela_nivel_destino")]
		private NumericUpDown _Tela_nivel_destino;
	}
}
