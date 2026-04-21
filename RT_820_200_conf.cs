using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iS800.My;
using iS800.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using VR.PrintPreview;

namespace iS800
{
	// Token: 0x02000035 RID: 53
	[DesignerGenerated]
	public partial class RT_820_200_conf : Form
	{
		// Token: 0x06000579 RID: 1401 RVA: 0x002996C4 File Offset: 0x00297AC4
		public RT_820_200_conf()
		{
			base.Load += new EventHandler(this.RT_820_conf_Load);
			base.Activated += new EventHandler(this.RT_820_conf_Activated);
			base.FormClosed += new FormClosedEventHandler(this.RT_820_conf_FormClosed);
			this.InitializeComponent();
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x002A3280 File Offset: 0x002A1680
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x002A3294 File Offset: 0x002A1694
		internal virtual GroupBox GroupBox_sistema_leitura
		{
			get
			{
				return this._GroupBox_sistema_leitura;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_sistema_leitura = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x002A32A0 File Offset: 0x002A16A0
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x002A32B4 File Offset: 0x002A16B4
		internal virtual CheckBox CheckBox_hab_eletrodos
		{
			get
			{
				return this._CheckBox_hab_eletrodos;
			}
			[MethodImpl(32)]
			set
			{
				this._CheckBox_hab_eletrodos = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x002A32C0 File Offset: 0x002A16C0
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x002A32D4 File Offset: 0x002A16D4
		internal virtual GroupBox GroupBox_operacao
		{
			get
			{
				return this._GroupBox_operacao;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_operacao = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x002A32E0 File Offset: 0x002A16E0
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x002A32F4 File Offset: 0x002A16F4
		internal virtual ComboBox ComboBox_metodo_operacao
		{
			get
			{
				return this._ComboBox_metodo_operacao;
			}
			[MethodImpl(32)]
			set
			{
				this._ComboBox_metodo_operacao = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x002A3300 File Offset: 0x002A1700
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x002A3314 File Offset: 0x002A1714
		internal virtual NumericUpDown NumericUpDown_intervalo_tx
		{
			get
			{
				return this._NumericUpDown_intervalo_tx;
			}
			[MethodImpl(32)]
			set
			{
				this._NumericUpDown_intervalo_tx = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x002A3320 File Offset: 0x002A1720
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x002A3334 File Offset: 0x002A1734
		internal virtual Label Label_metodo_operacao
		{
			get
			{
				return this._Label_metodo_operacao;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_metodo_operacao = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x002A3340 File Offset: 0x002A1740
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x002A3354 File Offset: 0x002A1754
		internal virtual Label Label_intevalo_tx_pto_pto
		{
			get
			{
				return this._Label_intevalo_tx_pto_pto;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_intevalo_tx_pto_pto = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x002A3360 File Offset: 0x002A1760
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x002A3374 File Offset: 0x002A1774
		internal virtual GroupBox GroupBox_informacoes
		{
			get
			{
				return this._GroupBox_informacoes;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_informacoes = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x002A3380 File Offset: 0x002A1780
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x002A3394 File Offset: 0x002A1794
		internal virtual TextBox TextBox_equipamento
		{
			get
			{
				return this._TextBox_equipamento;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_equipamento = value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x002A33A0 File Offset: 0x002A17A0
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x002A33B4 File Offset: 0x002A17B4
		internal virtual Label Label_equipamento
		{
			get
			{
				return this._Label_equipamento;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_equipamento = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x002A33C0 File Offset: 0x002A17C0
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x002A33D4 File Offset: 0x002A17D4
		internal virtual TextBox TextBox_release
		{
			get
			{
				return this._TextBox_release;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_release = value;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x002A33E0 File Offset: 0x002A17E0
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x002A33F4 File Offset: 0x002A17F4
		internal virtual Label Label_release
		{
			get
			{
				return this._Label_release;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_release = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x002A3400 File Offset: 0x002A1800
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x002A3414 File Offset: 0x002A1814
		internal virtual TextBox TextBox_build
		{
			get
			{
				return this._TextBox_build;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_build = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x002A3420 File Offset: 0x002A1820
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x002A3434 File Offset: 0x002A1834
		internal virtual Label Label_build
		{
			get
			{
				return this._Label_build;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_build = value;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x002A3440 File Offset: 0x002A1840
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x002A3454 File Offset: 0x002A1854
		internal virtual TextBox TextBox_versao
		{
			get
			{
				return this._TextBox_versao;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_versao = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x002A3460 File Offset: 0x002A1860
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x002A3474 File Offset: 0x002A1874
		internal virtual Label Label_versao
		{
			get
			{
				return this._Label_versao;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_versao = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x002A3480 File Offset: 0x002A1880
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x002A3494 File Offset: 0x002A1894
		internal virtual GroupBox GroupBox_modelo_simulado
		{
			get
			{
				return this._GroupBox_modelo_simulado;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_modelo_simulado = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x002A34A0 File Offset: 0x002A18A0
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x002A34B4 File Offset: 0x002A18B4
		internal virtual ComboBox ComboBox_modo_simulado
		{
			get
			{
				return this._ComboBox_modo_simulado;
			}
			[MethodImpl(32)]
			set
			{
				this._ComboBox_modo_simulado = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x002A34C0 File Offset: 0x002A18C0
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x002A34D4 File Offset: 0x002A18D4
		internal virtual GroupBox GroupBox_comunicacao
		{
			get
			{
				return this._GroupBox_comunicacao;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_comunicacao = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x002A34E0 File Offset: 0x002A18E0
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x002A34F4 File Offset: 0x002A18F4
		internal virtual NumericUpDown NumericUpDown_temp_ptt
		{
			get
			{
				return this._NumericUpDown_temp_ptt;
			}
			[MethodImpl(32)]
			set
			{
				this._NumericUpDown_temp_ptt = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x002A3500 File Offset: 0x002A1900
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x002A3514 File Offset: 0x002A1914
		internal virtual NumericUpDown NumericUpDown_end_mestre
		{
			get
			{
				return this._NumericUpDown_end_mestre;
			}
			[MethodImpl(32)]
			set
			{
				this._NumericUpDown_end_mestre = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x002A3520 File Offset: 0x002A1920
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x002A3534 File Offset: 0x002A1934
		internal virtual NumericUpDown NumericUpDown_end_est
		{
			get
			{
				return this._NumericUpDown_end_est;
			}
			[MethodImpl(32)]
			set
			{
				this._NumericUpDown_end_est = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x002A3540 File Offset: 0x002A1940
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x002A3554 File Offset: 0x002A1954
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

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x002A3560 File Offset: 0x002A1960
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x002A3574 File Offset: 0x002A1974
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

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x002A3580 File Offset: 0x002A1980
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x002A3594 File Offset: 0x002A1994
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

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x002A35A0 File Offset: 0x002A19A0
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x002A35B4 File Offset: 0x002A19B4
		internal virtual OpenFileDialog OpenFileDialog_RT_820
		{
			get
			{
				return this._OpenFileDialog_RT_820;
			}
			[MethodImpl(32)]
			set
			{
				this._OpenFileDialog_RT_820 = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x002A35C0 File Offset: 0x002A19C0
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x002A35D4 File Offset: 0x002A19D4
		internal virtual SaveFileDialog SaveFileDialog_RT_820
		{
			get
			{
				return this._SaveFileDialog_RT_820;
			}
			[MethodImpl(32)]
			set
			{
				this._SaveFileDialog_RT_820 = value;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x002A35E0 File Offset: 0x002A19E0
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x002A35F4 File Offset: 0x002A19F4
		internal virtual TabControl TabControl_820
		{
			get
			{
				return this._TabControl_820;
			}
			[MethodImpl(32)]
			set
			{
				this._TabControl_820 = value;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x002A3600 File Offset: 0x002A1A00
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x002A3614 File Offset: 0x002A1A14
		internal virtual TabPage TabPage_geral
		{
			get
			{
				return this._TabPage_geral;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_geral = value;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x002A3620 File Offset: 0x002A1A20
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x002A3634 File Offset: 0x002A1A34
		internal virtual GroupBox GroupBox_informacoes_820
		{
			get
			{
				return this._GroupBox_informacoes_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_informacoes_820 = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x002A3640 File Offset: 0x002A1A40
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x002A3654 File Offset: 0x002A1A54
		internal virtual GroupBox GroupBox_comunicacao_820
		{
			get
			{
				return this._GroupBox_comunicacao_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_comunicacao_820 = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x002A3660 File Offset: 0x002A1A60
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x002A3674 File Offset: 0x002A1A74
		internal virtual NumericUpDown NumericUpDown_temp_ptt_820
		{
			get
			{
				return this._NumericUpDown_temp_ptt_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_temp_ptt_820_ValueChanged);
				if (this._NumericUpDown_temp_ptt_820 != null)
				{
					this._NumericUpDown_temp_ptt_820.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_temp_ptt_820 = value;
				if (this._NumericUpDown_temp_ptt_820 != null)
				{
					this._NumericUpDown_temp_ptt_820.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x002A36C0 File Offset: 0x002A1AC0
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x002A36D4 File Offset: 0x002A1AD4
		internal virtual NumericUpDown NumericUpDown_end_mestre_820
		{
			get
			{
				return this._NumericUpDown_end_mestre_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_mestre_820_ValueChanged);
				if (this._NumericUpDown_end_mestre_820 != null)
				{
					this._NumericUpDown_end_mestre_820.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_mestre_820 = value;
				if (this._NumericUpDown_end_mestre_820 != null)
				{
					this._NumericUpDown_end_mestre_820.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x002A3720 File Offset: 0x002A1B20
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x002A3734 File Offset: 0x002A1B34
		internal virtual NumericUpDown NumericUpDown_end_est_820
		{
			get
			{
				return this._NumericUpDown_end_est_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_est_820_ValueChanged);
				if (this._NumericUpDown_end_est_820 != null)
				{
					this._NumericUpDown_end_est_820.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_est_820 = value;
				if (this._NumericUpDown_end_est_820 != null)
				{
					this._NumericUpDown_end_est_820.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x002A3780 File Offset: 0x002A1B80
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x002A3794 File Offset: 0x002A1B94
		internal virtual Label Label_tempo_ptt_820
		{
			get
			{
				return this._Label_tempo_ptt_820;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tempo_ptt_820 = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x002A37A0 File Offset: 0x002A1BA0
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x002A37B4 File Offset: 0x002A1BB4
		internal virtual Label Label_end_mestre_820
		{
			get
			{
				return this._Label_end_mestre_820;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_mestre_820 = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x002A37C0 File Offset: 0x002A1BC0
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x002A37D4 File Offset: 0x002A1BD4
		internal virtual Label Label_end_est_820
		{
			get
			{
				return this._Label_end_est_820;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_est_820 = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x002A37E0 File Offset: 0x002A1BE0
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x002A37F4 File Offset: 0x002A1BF4
		internal virtual TabPage TabPage_EA
		{
			get
			{
				return this._TabPage_EA;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_EA = value;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x002A3800 File Offset: 0x002A1C00
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x002A3814 File Offset: 0x002A1C14
		internal virtual GroupBox GroupBox_EA_820
		{
			get
			{
				return this._GroupBox_EA_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_EA_820 = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x002A3820 File Offset: 0x002A1C20
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x002A3834 File Offset: 0x002A1C34
		internal virtual NumericUpDown NumericUpDown_intervalo_filtro_820
		{
			get
			{
				return this._NumericUpDown_intervalo_filtro_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_intervalo_filtro_820_ValueChanged);
				if (this._NumericUpDown_intervalo_filtro_820 != null)
				{
					this._NumericUpDown_intervalo_filtro_820.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_intervalo_filtro_820 = value;
				if (this._NumericUpDown_intervalo_filtro_820 != null)
				{
					this._NumericUpDown_intervalo_filtro_820.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x002A3880 File Offset: 0x002A1C80
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x002A3894 File Offset: 0x002A1C94
		internal virtual NumericUpDown NumericUpDown_tamanho_filtro_820
		{
			get
			{
				return this._NumericUpDown_tamanho_filtro_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_tamanho_filtro_820_ValueChanged);
				if (this._NumericUpDown_tamanho_filtro_820 != null)
				{
					this._NumericUpDown_tamanho_filtro_820.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_tamanho_filtro_820 = value;
				if (this._NumericUpDown_tamanho_filtro_820 != null)
				{
					this._NumericUpDown_tamanho_filtro_820.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x002A38E0 File Offset: 0x002A1CE0
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x002A38F4 File Offset: 0x002A1CF4
		internal virtual Label Label_intervalo_filtro_820
		{
			get
			{
				return this._Label_intervalo_filtro_820;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_intervalo_filtro_820 = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x002A3900 File Offset: 0x002A1D00
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x002A3914 File Offset: 0x002A1D14
		internal virtual Label Label_tamanho_filtro_820
		{
			get
			{
				return this._Label_tamanho_filtro_820;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_tamanho_filtro_820 = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x002A3920 File Offset: 0x002A1D20
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x002A3934 File Offset: 0x002A1D34
		internal virtual TabPage TabPage_ED
		{
			get
			{
				return this._TabPage_ED;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_ED = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x002A3940 File Offset: 0x002A1D40
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x002A3954 File Offset: 0x002A1D54
		internal virtual TabPage TabPage_setpoints
		{
			get
			{
				return this._TabPage_setpoints;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_setpoints = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x002A3960 File Offset: 0x002A1D60
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x002A3974 File Offset: 0x002A1D74
		internal virtual TabPage TabPage_vazao_perifericos
		{
			get
			{
				return this._TabPage_vazao_perifericos;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_vazao_perifericos = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x002A3980 File Offset: 0x002A1D80
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x002A3994 File Offset: 0x002A1D94
		internal virtual TabPage TabPage_repetidora
		{
			get
			{
				return this._TabPage_repetidora;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_repetidora = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x002A39A0 File Offset: 0x002A1DA0
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x002A39B4 File Offset: 0x002A1DB4
		internal virtual GroupBox GroupBox_end_rep_820
		{
			get
			{
				return this._GroupBox_end_rep_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_end_rep_820 = value;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x002A39C0 File Offset: 0x002A1DC0
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x002A39D4 File Offset: 0x002A1DD4
		internal virtual DataGridView DataGridView_end_rep_RT820
		{
			get
			{
				return this._DataGridView_end_rep_RT820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_end_rep_820_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_end_rep_820_CellValueChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_end_rep_820_CellValidating);
				if (this._DataGridView_end_rep_RT820 != null)
				{
					this._DataGridView_end_rep_RT820.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_end_rep_RT820.CellValueChanged -= dataGridViewCellEventHandler;
					this._DataGridView_end_rep_RT820.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._DataGridView_end_rep_RT820 = value;
				if (this._DataGridView_end_rep_RT820 != null)
				{
					this._DataGridView_end_rep_RT820.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_end_rep_RT820.CellValueChanged += dataGridViewCellEventHandler;
					this._DataGridView_end_rep_RT820.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x002A3A6C File Offset: 0x002A1E6C
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x002A3A80 File Offset: 0x002A1E80
		internal virtual GroupBox GroupBox_parametros_repetidora_820
		{
			get
			{
				return this._GroupBox_parametros_repetidora_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_parametros_repetidora_820 = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x002A3A8C File Offset: 0x002A1E8C
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x002A3AA0 File Offset: 0x002A1EA0
		internal virtual NumericUpDown NumericUpDown_num_est_rep_820
		{
			get
			{
				return this._NumericUpDown_num_est_rep_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_num_est_rep_820_ValueChanged);
				if (this._NumericUpDown_num_est_rep_820 != null)
				{
					this._NumericUpDown_num_est_rep_820.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_num_est_rep_820 = value;
				if (this._NumericUpDown_num_est_rep_820 != null)
				{
					this._NumericUpDown_num_est_rep_820.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x002A3AEC File Offset: 0x002A1EEC
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x002A3B00 File Offset: 0x002A1F00
		internal virtual NumericUpDown NumericUpDown_end_rep_820
		{
			get
			{
				return this._NumericUpDown_end_rep_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_end_rep_820_ValueChanged);
				if (this._NumericUpDown_end_rep_820 != null)
				{
					this._NumericUpDown_end_rep_820.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_end_rep_820 = value;
				if (this._NumericUpDown_end_rep_820 != null)
				{
					this._NumericUpDown_end_rep_820.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x002A3B4C File Offset: 0x002A1F4C
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x002A3B60 File Offset: 0x002A1F60
		internal virtual Label Label_num_est_rep_820
		{
			get
			{
				return this._Label_num_est_rep_820;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_num_est_rep_820 = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x002A3B6C File Offset: 0x002A1F6C
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x002A3B80 File Offset: 0x002A1F80
		internal virtual Label Label_end_rep_820
		{
			get
			{
				return this._Label_end_rep_820;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_end_rep_820 = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x002A3B8C File Offset: 0x002A1F8C
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x002A3BA0 File Offset: 0x002A1FA0
		internal virtual ToolStrip ToolStri_RT_820
		{
			get
			{
				return this._ToolStri_RT_820;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStri_RT_820 = value;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x002A3BAC File Offset: 0x002A1FAC
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x002A3BC0 File Offset: 0x002A1FC0
		internal virtual ToolStripButton ToolStripButton_RT_820_novo
		{
			get
			{
				return this._ToolStripButton_RT_820_novo;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_820_novo_Click);
				if (this._ToolStripButton_RT_820_novo != null)
				{
					this._ToolStripButton_RT_820_novo.Click -= eventHandler;
				}
				this._ToolStripButton_RT_820_novo = value;
				if (this._ToolStripButton_RT_820_novo != null)
				{
					this._ToolStripButton_RT_820_novo.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x002A3C0C File Offset: 0x002A200C
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x002A3C20 File Offset: 0x002A2020
		internal virtual ToolStripButton ToolStripButton_RT_820_Abrir
		{
			get
			{
				return this._ToolStripButton_RT_820_Abrir;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_820_Abrir_Click);
				if (this._ToolStripButton_RT_820_Abrir != null)
				{
					this._ToolStripButton_RT_820_Abrir.Click -= eventHandler;
				}
				this._ToolStripButton_RT_820_Abrir = value;
				if (this._ToolStripButton_RT_820_Abrir != null)
				{
					this._ToolStripButton_RT_820_Abrir.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x002A3C6C File Offset: 0x002A206C
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x002A3C80 File Offset: 0x002A2080
		internal virtual ToolStripButton ToolStripButton_RT_820_Salvar
		{
			get
			{
				return this._ToolStripButton_RT_820_Salvar;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_820_Salvar_Click);
				if (this._ToolStripButton_RT_820_Salvar != null)
				{
					this._ToolStripButton_RT_820_Salvar.Click -= eventHandler;
				}
				this._ToolStripButton_RT_820_Salvar = value;
				if (this._ToolStripButton_RT_820_Salvar != null)
				{
					this._ToolStripButton_RT_820_Salvar.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x002A3CCC File Offset: 0x002A20CC
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x002A3CE0 File Offset: 0x002A20E0
		internal virtual ToolStripSeparator ToolStripSeparator1
		{
			get
			{
				return this._ToolStripSeparator1;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripSeparator1 = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x002A3CEC File Offset: 0x002A20EC
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x002A3D00 File Offset: 0x002A2100
		internal virtual ToolStripButton ToolStripButton_RT_820_Download
		{
			get
			{
				return this._ToolStripButton_RT_820_Download;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_820_Download_Click);
				if (this._ToolStripButton_RT_820_Download != null)
				{
					this._ToolStripButton_RT_820_Download.Click -= eventHandler;
				}
				this._ToolStripButton_RT_820_Download = value;
				if (this._ToolStripButton_RT_820_Download != null)
				{
					this._ToolStripButton_RT_820_Download.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x002A3D4C File Offset: 0x002A214C
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x002A3D60 File Offset: 0x002A2160
		internal virtual ToolStripButton ToolStripButton_RT_820_Upload
		{
			get
			{
				return this._ToolStripButton_RT_820_Upload;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT_820_Upload_Click);
				if (this._ToolStripButton_RT_820_Upload != null)
				{
					this._ToolStripButton_RT_820_Upload.Click -= eventHandler;
				}
				this._ToolStripButton_RT_820_Upload = value;
				if (this._ToolStripButton_RT_820_Upload != null)
				{
					this._ToolStripButton_RT_820_Upload.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x002A3DAC File Offset: 0x002A21AC
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x002A3DC0 File Offset: 0x002A21C0
		internal virtual ToolStripSeparator ToolStripSeparator2
		{
			get
			{
				return this._ToolStripSeparator2;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripSeparator2 = value;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x002A3DCC File Offset: 0x002A21CC
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x002A3DE0 File Offset: 0x002A21E0
		internal virtual ToolStripTextBox ToolStripTextBox_RT_820_Msg
		{
			get
			{
				return this._ToolStripTextBox_RT_820_Msg;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripTextBox_RT_820_Msg = value;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x002A3DEC File Offset: 0x002A21EC
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x002A3E00 File Offset: 0x002A2200
		internal virtual ToolStripProgressBar ToolStripProgressBar_RT_820
		{
			get
			{
				return this._ToolStripProgressBar_RT_820;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripProgressBar_RT_820 = value;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x002A3E0C File Offset: 0x002A220C
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x002A3E20 File Offset: 0x002A2220
		internal virtual ComboBox ComboBox_baudrate_COM2_820
		{
			get
			{
				return this._ComboBox_baudrate_COM2_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox_baudrate_COM2_820_SelectedIndexChanged);
				if (this._ComboBox_baudrate_COM2_820 != null)
				{
					this._ComboBox_baudrate_COM2_820.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBox_baudrate_COM2_820 = value;
				if (this._ComboBox_baudrate_COM2_820 != null)
				{
					this._ComboBox_baudrate_COM2_820.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x002A3E6C File Offset: 0x002A226C
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x002A3E80 File Offset: 0x002A2280
		internal virtual Label Label_baudrate_COM2_820
		{
			get
			{
				return this._Label_baudrate_COM2_820;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_baudrate_COM2_820 = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x002A3E8C File Offset: 0x002A228C
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x002A3EA0 File Offset: 0x002A22A0
		internal virtual TabPage TabPage_controle
		{
			get
			{
				return this._TabPage_controle;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_controle = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x002A3EAC File Offset: 0x002A22AC
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x002A3EC0 File Offset: 0x002A22C0
		internal virtual GroupBox GroupBox_perifericos_820
		{
			get
			{
				return this._GroupBox_perifericos_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_perifericos_820 = value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x002A3ECC File Offset: 0x002A22CC
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x002A3EE0 File Offset: 0x002A22E0
		internal virtual DataGridView DataGridView_periferico_RT820
		{
			get
			{
				return this._DataGridView_periferico_RT820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_periferico_RT820_CurrentCellDirtyStateChanged);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView_periferico_RT820_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_periferico_RT820_CellValueChanged);
				if (this._DataGridView_periferico_RT820 != null)
				{
					this._DataGridView_periferico_RT820.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_periferico_RT820.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._DataGridView_periferico_RT820.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_periferico_RT820 = value;
				if (this._DataGridView_periferico_RT820 != null)
				{
					this._DataGridView_periferico_RT820.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_periferico_RT820.CellValidating += dataGridViewCellValidatingEventHandler;
					this._DataGridView_periferico_RT820.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x002A3F78 File Offset: 0x002A2378
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x002A3F8C File Offset: 0x002A238C
		internal virtual Timer Timer_limpa_MSG_820
		{
			get
			{
				return this._Timer_limpa_MSG_820;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer_limpa_MSG_820_Tick);
				if (this._Timer_limpa_MSG_820 != null)
				{
					this._Timer_limpa_MSG_820.Tick -= eventHandler;
				}
				this._Timer_limpa_MSG_820 = value;
				if (this._Timer_limpa_MSG_820 != null)
				{
					this._Timer_limpa_MSG_820.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x002A3FD8 File Offset: 0x002A23D8
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x002A3FEC File Offset: 0x002A23EC
		internal virtual GroupBox GroupBox_descricao_RT820
		{
			get
			{
				return this._GroupBox_descricao_RT820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_descricao_RT820 = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x002A3FF8 File Offset: 0x002A23F8
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x002A400C File Offset: 0x002A240C
		internal virtual TextBox TextBox_comentarios_RT820
		{
			get
			{
				return this._TextBox_comentarios_RT820;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_comentarios_RT820 = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x002A4018 File Offset: 0x002A2418
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x002A402C File Offset: 0x002A242C
		internal virtual TextBox TextBox_endereco_RT820
		{
			get
			{
				return this._TextBox_endereco_RT820;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_endereco_RT820 = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x002A4038 File Offset: 0x002A2438
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x002A404C File Offset: 0x002A244C
		internal virtual TextBox TextBox_nome_RT820
		{
			get
			{
				return this._TextBox_nome_RT820;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_nome_RT820 = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x002A4058 File Offset: 0x002A2458
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x002A406C File Offset: 0x002A246C
		internal virtual Label Label_comentarios
		{
			get
			{
				return this._Label_comentarios;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_comentarios = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x002A4078 File Offset: 0x002A2478
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x002A408C File Offset: 0x002A248C
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

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x002A4098 File Offset: 0x002A2498
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x002A40AC File Offset: 0x002A24AC
		internal virtual Label Label_nome
		{
			get
			{
				return this._Label_nome;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nome = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x002A40B8 File Offset: 0x002A24B8
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x002A40CC File Offset: 0x002A24CC
		internal virtual GroupBox GroupBox_ED_820
		{
			get
			{
				return this._GroupBox_ED_820;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_ED_820 = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x002A40D8 File Offset: 0x002A24D8
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x002A40EC File Offset: 0x002A24EC
		internal virtual DataGridView DataGridView_RT820_ED
		{
			get
			{
				return this._DataGridView_RT820_ED;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.DataGridView_RT820_ED_CurrentCellDirtyStateChanged);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView_RT820_ED_CellValueChanged);
				if (this._DataGridView_RT820_ED != null)
				{
					this._DataGridView_RT820_ED.CurrentCellDirtyStateChanged -= eventHandler;
					this._DataGridView_RT820_ED.CellValueChanged -= dataGridViewCellEventHandler;
				}
				this._DataGridView_RT820_ED = value;
				if (this._DataGridView_RT820_ED != null)
				{
					this._DataGridView_RT820_ED.CurrentCellDirtyStateChanged += eventHandler;
					this._DataGridView_RT820_ED.CellValueChanged += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x002A415C File Offset: 0x002A255C
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x002A4170 File Offset: 0x002A2570
		internal virtual ToolStripButton ToolStripButton_RT820_Imprimir
		{
			get
			{
				return this._ToolStripButton_RT820_Imprimir;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ToolStripButton_RT820_Imprimir_Click);
				if (this._ToolStripButton_RT820_Imprimir != null)
				{
					this._ToolStripButton_RT820_Imprimir.Click -= eventHandler;
				}
				this._ToolStripButton_RT820_Imprimir = value;
				if (this._ToolStripButton_RT820_Imprimir != null)
				{
					this._ToolStripButton_RT820_Imprimir.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x002A41BC File Offset: 0x002A25BC
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x002A41D0 File Offset: 0x002A25D0
		internal virtual PrintDocument PrintDocument1
		{
			get
			{
				return this._PrintDocument1;
			}
			[MethodImpl(32)]
			set
			{
				PrintPageEventHandler printPageEventHandler = new PrintPageEventHandler(this.PrintDocument1_PrintPage);
				QueryPageSettingsEventHandler queryPageSettingsEventHandler = new QueryPageSettingsEventHandler(this.PrintDocument1_QueryPageSettings);
				PrintEventHandler printEventHandler = new PrintEventHandler(this.PrintDocument1_BeginPrint);
				if (this._PrintDocument1 != null)
				{
					this._PrintDocument1.PrintPage -= printPageEventHandler;
					this._PrintDocument1.QueryPageSettings -= queryPageSettingsEventHandler;
					this._PrintDocument1.BeginPrint -= printEventHandler;
				}
				this._PrintDocument1 = value;
				if (this._PrintDocument1 != null)
				{
					this._PrintDocument1.PrintPage += printPageEventHandler;
					this._PrintDocument1.QueryPageSettings += queryPageSettingsEventHandler;
					this._PrintDocument1.BeginPrint += printEventHandler;
				}
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x002A4268 File Offset: 0x002A2668
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x002A427C File Offset: 0x002A267C
		internal virtual TabPage TabPage1
		{
			get
			{
				return this._TabPage1;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage1 = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x002A4288 File Offset: 0x002A2688
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x002A429C File Offset: 0x002A269C
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

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x002A42A8 File Offset: 0x002A26A8
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x002A42BC File Offset: 0x002A26BC
		internal virtual Label Label16
		{
			get
			{
				return this._Label16;
			}
			[MethodImpl(32)]
			set
			{
				this._Label16 = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x002A42C8 File Offset: 0x002A26C8
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x002A42DC File Offset: 0x002A26DC
		internal virtual Label Label15
		{
			get
			{
				return this._Label15;
			}
			[MethodImpl(32)]
			set
			{
				this._Label15 = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x002A42E8 File Offset: 0x002A26E8
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x002A42FC File Offset: 0x002A26FC
		internal virtual TextBox T_ModeloFonte
		{
			get
			{
				return this._T_ModeloFonte;
			}
			[MethodImpl(32)]
			set
			{
				this._T_ModeloFonte = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x002A4308 File Offset: 0x002A2708
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x002A431C File Offset: 0x002A271C
		internal virtual TextBox T_AlturaAntena
		{
			get
			{
				return this._T_AlturaAntena;
			}
			[MethodImpl(32)]
			set
			{
				this._T_AlturaAntena = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x002A4328 File Offset: 0x002A2728
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x002A433C File Offset: 0x002A273C
		internal virtual TextBox T_Latitude
		{
			get
			{
				return this._T_Latitude;
			}
			[MethodImpl(32)]
			set
			{
				this._T_Latitude = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x002A4348 File Offset: 0x002A2748
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x002A435C File Offset: 0x002A275C
		internal virtual TextBox T_Longitude
		{
			get
			{
				return this._T_Longitude;
			}
			[MethodImpl(32)]
			set
			{
				this._T_Longitude = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x002A4368 File Offset: 0x002A2768
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x002A437C File Offset: 0x002A277C
		internal virtual TextBox T_Azimute
		{
			get
			{
				return this._T_Azimute;
			}
			[MethodImpl(32)]
			set
			{
				this._T_Azimute = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x002A4388 File Offset: 0x002A2788
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x002A439C File Offset: 0x002A279C
		internal virtual Label Label14
		{
			get
			{
				return this._Label14;
			}
			[MethodImpl(32)]
			set
			{
				this._Label14 = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x002A43A8 File Offset: 0x002A27A8
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x002A43BC File Offset: 0x002A27BC
		internal virtual Label Label13
		{
			get
			{
				return this._Label13;
			}
			[MethodImpl(32)]
			set
			{
				this._Label13 = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x002A43C8 File Offset: 0x002A27C8
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x002A43DC File Offset: 0x002A27DC
		internal virtual Label Label12
		{
			get
			{
				return this._Label12;
			}
			[MethodImpl(32)]
			set
			{
				this._Label12 = value;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x002A43E8 File Offset: 0x002A27E8
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x002A43FC File Offset: 0x002A27FC
		internal virtual TextBox T_FreqRadio
		{
			get
			{
				return this._T_FreqRadio;
			}
			[MethodImpl(32)]
			set
			{
				this._T_FreqRadio = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x002A4408 File Offset: 0x002A2808
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x002A441C File Offset: 0x002A281C
		internal virtual TextBox T_DistCentral
		{
			get
			{
				return this._T_DistCentral;
			}
			[MethodImpl(32)]
			set
			{
				this._T_DistCentral = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x002A4428 File Offset: 0x002A2828
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x002A443C File Offset: 0x002A283C
		internal virtual TextBox T_PotRadio
		{
			get
			{
				return this._T_PotRadio;
			}
			[MethodImpl(32)]
			set
			{
				this._T_PotRadio = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x002A4448 File Offset: 0x002A2848
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x002A445C File Offset: 0x002A285C
		internal virtual ComboBox CB_ModeloRadio
		{
			get
			{
				return this._CB_ModeloRadio;
			}
			[MethodImpl(32)]
			set
			{
				this._CB_ModeloRadio = value;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x002A4468 File Offset: 0x002A2868
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x002A447C File Offset: 0x002A287C
		internal virtual ComboBox CB_PolarizacaoAntena
		{
			get
			{
				return this._CB_PolarizacaoAntena;
			}
			[MethodImpl(32)]
			set
			{
				this._CB_PolarizacaoAntena = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x002A4488 File Offset: 0x002A2888
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x002A449C File Offset: 0x002A289C
		internal virtual ComboBox CB_TipoAntena
		{
			get
			{
				return this._CB_TipoAntena;
			}
			[MethodImpl(32)]
			set
			{
				this._CB_TipoAntena = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x002A44A8 File Offset: 0x002A28A8
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x002A44BC File Offset: 0x002A28BC
		internal virtual Label Label11
		{
			get
			{
				return this._Label11;
			}
			[MethodImpl(32)]
			set
			{
				this._Label11 = value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x002A44C8 File Offset: 0x002A28C8
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x002A44DC File Offset: 0x002A28DC
		internal virtual Label Label10
		{
			get
			{
				return this._Label10;
			}
			[MethodImpl(32)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x002A44E8 File Offset: 0x002A28E8
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x002A44FC File Offset: 0x002A28FC
		internal virtual Label Label9
		{
			get
			{
				return this._Label9;
			}
			[MethodImpl(32)]
			set
			{
				this._Label9 = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x002A4508 File Offset: 0x002A2908
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x002A451C File Offset: 0x002A291C
		internal virtual Label Label8
		{
			get
			{
				return this._Label8;
			}
			[MethodImpl(32)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x002A4528 File Offset: 0x002A2928
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x002A453C File Offset: 0x002A293C
		internal virtual Label Label7
		{
			get
			{
				return this._Label7;
			}
			[MethodImpl(32)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x002A4548 File Offset: 0x002A2948
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x002A455C File Offset: 0x002A295C
		internal virtual Label Label6
		{
			get
			{
				return this._Label6;
			}
			[MethodImpl(32)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x002A4568 File Offset: 0x002A2968
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x002A457C File Offset: 0x002A297C
		internal virtual Label Label5
		{
			get
			{
				return this._Label5;
			}
			[MethodImpl(32)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x002A4588 File Offset: 0x002A2988
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x002A459C File Offset: 0x002A299C
		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x002A45A8 File Offset: 0x002A29A8
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x002A45BC File Offset: 0x002A29BC
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

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x002A45C8 File Offset: 0x002A29C8
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x002A45DC File Offset: 0x002A29DC
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

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x002A45E8 File Offset: 0x002A29E8
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x002A45FC File Offset: 0x002A29FC
		internal virtual Label Label17
		{
			get
			{
				return this._Label17;
			}
			[MethodImpl(32)]
			set
			{
				this._Label17 = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x002A4608 File Offset: 0x002A2A08
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x002A461C File Offset: 0x002A2A1C
		internal virtual ToolStripSeparator ToolStripSeparator3
		{
			get
			{
				return this._ToolStripSeparator3;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripSeparator3 = value;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x002A4628 File Offset: 0x002A2A28
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x002A463C File Offset: 0x002A2A3C
		internal virtual PrintPreviewDialog PrintPreviewDialog1
		{
			get
			{
				return this._PrintPreviewDialog1;
			}
			[MethodImpl(32)]
			set
			{
				this._PrintPreviewDialog1 = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x002A4648 File Offset: 0x002A2A48
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x002A465C File Offset: 0x002A2A5C
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

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x002A4668 File Offset: 0x002A2A68
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x002A467C File Offset: 0x002A2A7C
		internal virtual Label Label18
		{
			get
			{
				return this._Label18;
			}
			[MethodImpl(32)]
			set
			{
				this._Label18 = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x002A4688 File Offset: 0x002A2A88
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x002A469C File Offset: 0x002A2A9C
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

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x002A46A8 File Offset: 0x002A2AA8
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x002A46BC File Offset: 0x002A2ABC
		internal virtual CheckBox checkbox_habilita_controle
		{
			get
			{
				return this._checkbox_habilita_controle;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
				if (this._checkbox_habilita_controle != null)
				{
					this._checkbox_habilita_controle.CheckedChanged -= eventHandler;
				}
				this._checkbox_habilita_controle = value;
				if (this._checkbox_habilita_controle != null)
				{
					this._checkbox_habilita_controle.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x002A4708 File Offset: 0x002A2B08
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x002A471C File Offset: 0x002A2B1C
		internal virtual ComboBox cb_Controle
		{
			get
			{
				return this._cb_Controle;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_Controle_SelectedIndexChanged);
				if (this._cb_Controle != null)
				{
					this._cb_Controle.SelectedIndexChanged -= eventHandler;
				}
				this._cb_Controle = value;
				if (this._cb_Controle != null)
				{
					this._cb_Controle.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x002A4768 File Offset: 0x002A2B68
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x002A477C File Offset: 0x002A2B7C
		internal virtual ComboBox cb_Protecao
		{
			get
			{
				return this._cb_Protecao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_Protecao_SelectedIndexChanged);
				if (this._cb_Protecao != null)
				{
					this._cb_Protecao.SelectedIndexChanged -= eventHandler;
				}
				this._cb_Protecao = value;
				if (this._cb_Protecao != null)
				{
					this._cb_Protecao.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x002A47C8 File Offset: 0x002A2BC8
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x002A47DC File Offset: 0x002A2BDC
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

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x002A47E8 File Offset: 0x002A2BE8
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x002A47FC File Offset: 0x002A2BFC
		internal virtual Label Label25
		{
			get
			{
				return this._Label25;
			}
			[MethodImpl(32)]
			set
			{
				this._Label25 = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x002A4808 File Offset: 0x002A2C08
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x002A481C File Offset: 0x002A2C1C
		internal virtual Label Label22
		{
			get
			{
				return this._Label22;
			}
			[MethodImpl(32)]
			set
			{
				this._Label22 = value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x002A4828 File Offset: 0x002A2C28
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x002A483C File Offset: 0x002A2C3C
		internal virtual Label Label21
		{
			get
			{
				return this._Label21;
			}
			[MethodImpl(32)]
			set
			{
				this._Label21 = value;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x002A4848 File Offset: 0x002A2C48
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x002A485C File Offset: 0x002A2C5C
		internal virtual Label Label19
		{
			get
			{
				return this._Label19;
			}
			[MethodImpl(32)]
			set
			{
				this._Label19 = value;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x002A4868 File Offset: 0x002A2C68
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x002A487C File Offset: 0x002A2C7C
		internal virtual Label Label27
		{
			get
			{
				return this._Label27;
			}
			[MethodImpl(32)]
			set
			{
				this._Label27 = value;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x002A4888 File Offset: 0x002A2C88
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x002A489C File Offset: 0x002A2C9C
		internal virtual Label Label28
		{
			get
			{
				return this._Label28;
			}
			[MethodImpl(32)]
			set
			{
				this._Label28 = value;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x002A48A8 File Offset: 0x002A2CA8
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x002A48BC File Offset: 0x002A2CBC
		internal virtual NumericUpDown nud_motor1_baixo
		{
			get
			{
				return this._nud_motor1_baixo;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_motor1_baixo_ValueChanged);
				if (this._nud_motor1_baixo != null)
				{
					this._nud_motor1_baixo.ValueChanged -= eventHandler;
				}
				this._nud_motor1_baixo = value;
				if (this._nud_motor1_baixo != null)
				{
					this._nud_motor1_baixo.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x002A4908 File Offset: 0x002A2D08
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x002A491C File Offset: 0x002A2D1C
		internal virtual NumericUpDown nud_motor1_alto
		{
			get
			{
				return this._nud_motor1_alto;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_motor1_alto_ValueChanged);
				if (this._nud_motor1_alto != null)
				{
					this._nud_motor1_alto.ValueChanged -= eventHandler;
				}
				this._nud_motor1_alto = value;
				if (this._nud_motor1_alto != null)
				{
					this._nud_motor1_alto.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x002A4968 File Offset: 0x002A2D68
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x002A497C File Offset: 0x002A2D7C
		internal virtual NumericUpDown nud_motor4_baixo
		{
			get
			{
				return this._nud_motor4_baixo;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_motor4_baixo_ValueChanged);
				if (this._nud_motor4_baixo != null)
				{
					this._nud_motor4_baixo.ValueChanged -= eventHandler;
				}
				this._nud_motor4_baixo = value;
				if (this._nud_motor4_baixo != null)
				{
					this._nud_motor4_baixo.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x002A49C8 File Offset: 0x002A2DC8
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x002A49DC File Offset: 0x002A2DDC
		internal virtual NumericUpDown nud_motor4_alto
		{
			get
			{
				return this._nud_motor4_alto;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_motor4_alto_ValueChanged);
				if (this._nud_motor4_alto != null)
				{
					this._nud_motor4_alto.ValueChanged -= eventHandler;
				}
				this._nud_motor4_alto = value;
				if (this._nud_motor4_alto != null)
				{
					this._nud_motor4_alto.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x002A4A28 File Offset: 0x002A2E28
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x002A4A3C File Offset: 0x002A2E3C
		internal virtual NumericUpDown nud_motor3_baixo
		{
			get
			{
				return this._nud_motor3_baixo;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_motor3_baixo_ValueChanged);
				if (this._nud_motor3_baixo != null)
				{
					this._nud_motor3_baixo.ValueChanged -= eventHandler;
				}
				this._nud_motor3_baixo = value;
				if (this._nud_motor3_baixo != null)
				{
					this._nud_motor3_baixo.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x002A4A88 File Offset: 0x002A2E88
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x002A4A9C File Offset: 0x002A2E9C
		internal virtual NumericUpDown nud_motor3_alto
		{
			get
			{
				return this._nud_motor3_alto;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_motor3_alto_ValueChanged);
				if (this._nud_motor3_alto != null)
				{
					this._nud_motor3_alto.ValueChanged -= eventHandler;
				}
				this._nud_motor3_alto = value;
				if (this._nud_motor3_alto != null)
				{
					this._nud_motor3_alto.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x002A4AE8 File Offset: 0x002A2EE8
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x002A4AFC File Offset: 0x002A2EFC
		internal virtual NumericUpDown nud_motor2_baixo
		{
			get
			{
				return this._nud_motor2_baixo;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_motor2_baixo_ValueChanged);
				if (this._nud_motor2_baixo != null)
				{
					this._nud_motor2_baixo.ValueChanged -= eventHandler;
				}
				this._nud_motor2_baixo = value;
				if (this._nud_motor2_baixo != null)
				{
					this._nud_motor2_baixo.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x002A4B48 File Offset: 0x002A2F48
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x002A4B5C File Offset: 0x002A2F5C
		internal virtual NumericUpDown nud_motor2_alto
		{
			get
			{
				return this._nud_motor2_alto;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_motor2_alto_ValueChanged);
				if (this._nud_motor2_alto != null)
				{
					this._nud_motor2_alto.ValueChanged -= eventHandler;
				}
				this._nud_motor2_alto = value;
				if (this._nud_motor2_alto != null)
				{
					this._nud_motor2_alto.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x002A4BA8 File Offset: 0x002A2FA8
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x002A4BBC File Offset: 0x002A2FBC
		internal virtual NumericUpDown nud_protecao_liga
		{
			get
			{
				return this._nud_protecao_liga;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_protecao_liga_ValueChanged);
				if (this._nud_protecao_liga != null)
				{
					this._nud_protecao_liga.ValueChanged -= eventHandler;
				}
				this._nud_protecao_liga = value;
				if (this._nud_protecao_liga != null)
				{
					this._nud_protecao_liga.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x002A4C08 File Offset: 0x002A3008
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x002A4C1C File Offset: 0x002A301C
		internal virtual NumericUpDown nud_protecao_desliga
		{
			get
			{
				return this._nud_protecao_desliga;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_protecao_desliga_ValueChanged);
				if (this._nud_protecao_desliga != null)
				{
					this._nud_protecao_desliga.ValueChanged -= eventHandler;
				}
				this._nud_protecao_desliga = value;
				if (this._nud_protecao_desliga != null)
				{
					this._nud_protecao_desliga.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x002A4C68 File Offset: 0x002A3068
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x002A4C7C File Offset: 0x002A307C
		internal virtual Label Label29
		{
			get
			{
				return this._Label29;
			}
			[MethodImpl(32)]
			set
			{
				this._Label29 = value;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x002A4C88 File Offset: 0x002A3088
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x002A4C9C File Offset: 0x002A309C
		internal virtual ComboBox cb_ModoRepetidora
		{
			get
			{
				return this._cb_ModoRepetidora;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_ModoRepetidora_SelectedIndexChanged);
				if (this._cb_ModoRepetidora != null)
				{
					this._cb_ModoRepetidora.SelectedIndexChanged -= eventHandler;
				}
				this._cb_ModoRepetidora = value;
				if (this._cb_ModoRepetidora != null)
				{
					this._cb_ModoRepetidora.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x002A4CE8 File Offset: 0x002A30E8
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x002A4CFC File Offset: 0x002A30FC
		internal virtual TabPage TabPage_MotoresValvulas
		{
			get
			{
				return this._TabPage_MotoresValvulas;
			}
			[MethodImpl(32)]
			set
			{
				this._TabPage_MotoresValvulas = value;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x002A4D08 File Offset: 0x002A3108
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x002A4D1C File Offset: 0x002A311C
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

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x002A4D28 File Offset: 0x002A3128
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x002A4D3C File Offset: 0x002A313C
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

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x002A4D48 File Offset: 0x002A3148
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x002A4D5C File Offset: 0x002A315C
		internal virtual GroupBox GroupBox4
		{
			get
			{
				return this._GroupBox4;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox4 = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x002A4D68 File Offset: 0x002A3168
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x002A4D7C File Offset: 0x002A317C
		internal virtual Label Label47
		{
			get
			{
				return this._Label47;
			}
			[MethodImpl(32)]
			set
			{
				this._Label47 = value;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x002A4D88 File Offset: 0x002A3188
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x002A4D9C File Offset: 0x002A319C
		internal virtual Label Label46
		{
			get
			{
				return this._Label46;
			}
			[MethodImpl(32)]
			set
			{
				this._Label46 = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x002A4DA8 File Offset: 0x002A31A8
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x002A4DBC File Offset: 0x002A31BC
		internal virtual Label Label45
		{
			get
			{
				return this._Label45;
			}
			[MethodImpl(32)]
			set
			{
				this._Label45 = value;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x002A4DC8 File Offset: 0x002A31C8
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x002A4DDC File Offset: 0x002A31DC
		internal virtual Label Label44
		{
			get
			{
				return this._Label44;
			}
			[MethodImpl(32)]
			set
			{
				this._Label44 = value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x002A4DE8 File Offset: 0x002A31E8
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x002A4DFC File Offset: 0x002A31FC
		internal virtual Label Label43
		{
			get
			{
				return this._Label43;
			}
			[MethodImpl(32)]
			set
			{
				this._Label43 = value;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x002A4E08 File Offset: 0x002A3208
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x002A4E1C File Offset: 0x002A321C
		internal virtual Label Label42
		{
			get
			{
				return this._Label42;
			}
			[MethodImpl(32)]
			set
			{
				this._Label42 = value;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x002A4E28 File Offset: 0x002A3228
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x002A4E3C File Offset: 0x002A323C
		internal virtual Label Label41
		{
			get
			{
				return this._Label41;
			}
			[MethodImpl(32)]
			set
			{
				this._Label41 = value;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x002A4E48 File Offset: 0x002A3248
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x002A4E5C File Offset: 0x002A325C
		internal virtual Label Label40
		{
			get
			{
				return this._Label40;
			}
			[MethodImpl(32)]
			set
			{
				this._Label40 = value;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x002A4E68 File Offset: 0x002A3268
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x002A4E7C File Offset: 0x002A327C
		internal virtual Label Label39
		{
			get
			{
				return this._Label39;
			}
			[MethodImpl(32)]
			set
			{
				this._Label39 = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x002A4E88 File Offset: 0x002A3288
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x002A4E9C File Offset: 0x002A329C
		internal virtual Label Label38
		{
			get
			{
				return this._Label38;
			}
			[MethodImpl(32)]
			set
			{
				this._Label38 = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x002A4EA8 File Offset: 0x002A32A8
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x002A4EBC File Offset: 0x002A32BC
		internal virtual Label Label37
		{
			get
			{
				return this._Label37;
			}
			[MethodImpl(32)]
			set
			{
				this._Label37 = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x002A4EC8 File Offset: 0x002A32C8
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x002A4EDC File Offset: 0x002A32DC
		internal virtual Label Label36
		{
			get
			{
				return this._Label36;
			}
			[MethodImpl(32)]
			set
			{
				this._Label36 = value;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x002A4EE8 File Offset: 0x002A32E8
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x002A4EFC File Offset: 0x002A32FC
		internal virtual Label Label35
		{
			get
			{
				return this._Label35;
			}
			[MethodImpl(32)]
			set
			{
				this._Label35 = value;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x002A4F08 File Offset: 0x002A3308
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x002A4F1C File Offset: 0x002A331C
		internal virtual Label Label34
		{
			get
			{
				return this._Label34;
			}
			[MethodImpl(32)]
			set
			{
				this._Label34 = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x002A4F28 File Offset: 0x002A3328
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x002A4F3C File Offset: 0x002A333C
		internal virtual Label Label33
		{
			get
			{
				return this._Label33;
			}
			[MethodImpl(32)]
			set
			{
				this._Label33 = value;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x002A4F48 File Offset: 0x002A3348
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x002A4F5C File Offset: 0x002A335C
		internal virtual Label Label32
		{
			get
			{
				return this._Label32;
			}
			[MethodImpl(32)]
			set
			{
				this._Label32 = value;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x002A4F68 File Offset: 0x002A3368
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x002A4F7C File Offset: 0x002A337C
		internal virtual Label Label31
		{
			get
			{
				return this._Label31;
			}
			[MethodImpl(32)]
			set
			{
				this._Label31 = value;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x002A4F88 File Offset: 0x002A3388
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x002A4F9C File Offset: 0x002A339C
		internal virtual Label Label30
		{
			get
			{
				return this._Label30;
			}
			[MethodImpl(32)]
			set
			{
				this._Label30 = value;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x002A4FA8 File Offset: 0x002A33A8
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x002A4FBC File Offset: 0x002A33BC
		internal virtual NumericUpDown nud_bombas_simultaneas
		{
			get
			{
				return this._nud_bombas_simultaneas;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_bombas_simultaneas_ValueChanged);
				if (this._nud_bombas_simultaneas != null)
				{
					this._nud_bombas_simultaneas.ValueChanged -= eventHandler;
				}
				this._nud_bombas_simultaneas = value;
				if (this._nud_bombas_simultaneas != null)
				{
					this._nud_bombas_simultaneas.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x002A5008 File Offset: 0x002A3408
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x002A501C File Offset: 0x002A341C
		internal virtual NumericUpDown nud_numero_valvulas
		{
			get
			{
				return this._nud_numero_valvulas;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_numero_valvulas_ValueChanged);
				if (this._nud_numero_valvulas != null)
				{
					this._nud_numero_valvulas.ValueChanged -= eventHandler;
				}
				this._nud_numero_valvulas = value;
				if (this._nud_numero_valvulas != null)
				{
					this._nud_numero_valvulas.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x002A5068 File Offset: 0x002A3468
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x002A507C File Offset: 0x002A347C
		internal virtual NumericUpDown nud_numero_motores
		{
			get
			{
				return this._nud_numero_motores;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_numero_motores_ValueChanged);
				if (this._nud_numero_motores != null)
				{
					this._nud_numero_motores.ValueChanged -= eventHandler;
				}
				this._nud_numero_motores = value;
				if (this._nud_numero_motores != null)
				{
					this._nud_numero_motores.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x002A50C8 File Offset: 0x002A34C8
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x002A50DC File Offset: 0x002A34DC
		internal virtual ComboBox cb_modo_operacao
		{
			get
			{
				return this._cb_modo_operacao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_modo_operacao_SelectedIndexChanged);
				if (this._cb_modo_operacao != null)
				{
					this._cb_modo_operacao.SelectedIndexChanged -= eventHandler;
				}
				this._cb_modo_operacao = value;
				if (this._cb_modo_operacao != null)
				{
					this._cb_modo_operacao.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x002A5128 File Offset: 0x002A3528
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x002A513C File Offset: 0x002A353C
		internal virtual NumericUpDown nud_tempo_operacoes
		{
			get
			{
				return this._nud_tempo_operacoes;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_tempo_operacoes_ValueChanged);
				if (this._nud_tempo_operacoes != null)
				{
					this._nud_tempo_operacoes.ValueChanged -= eventHandler;
				}
				this._nud_tempo_operacoes = value;
				if (this._nud_tempo_operacoes != null)
				{
					this._nud_tempo_operacoes.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x002A5188 File Offset: 0x002A3588
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x002A519C File Offset: 0x002A359C
		internal virtual NumericUpDown nud_valvula3_abertura
		{
			get
			{
				return this._nud_valvula3_abertura;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_valvula3_abertura_ValueChanged);
				if (this._nud_valvula3_abertura != null)
				{
					this._nud_valvula3_abertura.ValueChanged -= eventHandler;
				}
				this._nud_valvula3_abertura = value;
				if (this._nud_valvula3_abertura != null)
				{
					this._nud_valvula3_abertura.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x002A51E8 File Offset: 0x002A35E8
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x002A51FC File Offset: 0x002A35FC
		internal virtual NumericUpDown nud_valvula2_fechamento
		{
			get
			{
				return this._nud_valvula2_fechamento;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_valvula2_fechamento_ValueChanged);
				if (this._nud_valvula2_fechamento != null)
				{
					this._nud_valvula2_fechamento.ValueChanged -= eventHandler;
				}
				this._nud_valvula2_fechamento = value;
				if (this._nud_valvula2_fechamento != null)
				{
					this._nud_valvula2_fechamento.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x002A5248 File Offset: 0x002A3648
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x002A525C File Offset: 0x002A365C
		internal virtual NumericUpDown nud_valvula2_abertura
		{
			get
			{
				return this._nud_valvula2_abertura;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_valvula2_abertura_ValueChanged);
				if (this._nud_valvula2_abertura != null)
				{
					this._nud_valvula2_abertura.ValueChanged -= eventHandler;
				}
				this._nud_valvula2_abertura = value;
				if (this._nud_valvula2_abertura != null)
				{
					this._nud_valvula2_abertura.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x002A52A8 File Offset: 0x002A36A8
		// (set) Token: 0x060006CB RID: 1739 RVA: 0x002A52BC File Offset: 0x002A36BC
		internal virtual NumericUpDown nud_valvula1_fechamento
		{
			get
			{
				return this._nud_valvula1_fechamento;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_valvula1_fechamento_ValueChanged);
				if (this._nud_valvula1_fechamento != null)
				{
					this._nud_valvula1_fechamento.ValueChanged -= eventHandler;
				}
				this._nud_valvula1_fechamento = value;
				if (this._nud_valvula1_fechamento != null)
				{
					this._nud_valvula1_fechamento.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x002A5308 File Offset: 0x002A3708
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x002A531C File Offset: 0x002A371C
		internal virtual NumericUpDown nud_valvula1_abertura
		{
			get
			{
				return this._nud_valvula1_abertura;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_valvula1_abertura_ValueChanged);
				if (this._nud_valvula1_abertura != null)
				{
					this._nud_valvula1_abertura.ValueChanged -= eventHandler;
				}
				this._nud_valvula1_abertura = value;
				if (this._nud_valvula1_abertura != null)
				{
					this._nud_valvula1_abertura.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x002A5368 File Offset: 0x002A3768
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x002A537C File Offset: 0x002A377C
		internal virtual NumericUpDown nud_valvula4_fechamento
		{
			get
			{
				return this._nud_valvula4_fechamento;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_valvula4_fechamento_ValueChanged);
				if (this._nud_valvula4_fechamento != null)
				{
					this._nud_valvula4_fechamento.ValueChanged -= eventHandler;
				}
				this._nud_valvula4_fechamento = value;
				if (this._nud_valvula4_fechamento != null)
				{
					this._nud_valvula4_fechamento.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x002A53C8 File Offset: 0x002A37C8
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x002A53DC File Offset: 0x002A37DC
		internal virtual NumericUpDown nud_valvula4_abertura
		{
			get
			{
				return this._nud_valvula4_abertura;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_valvula4_abertura_ValueChanged);
				if (this._nud_valvula4_abertura != null)
				{
					this._nud_valvula4_abertura.ValueChanged -= eventHandler;
				}
				this._nud_valvula4_abertura = value;
				if (this._nud_valvula4_abertura != null)
				{
					this._nud_valvula4_abertura.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x002A5428 File Offset: 0x002A3828
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x002A543C File Offset: 0x002A383C
		internal virtual NumericUpDown nud_valvula3_fechamento
		{
			get
			{
				return this._nud_valvula3_fechamento;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_valvula3_fechamento_ValueChanged);
				if (this._nud_valvula3_fechamento != null)
				{
					this._nud_valvula3_fechamento.ValueChanged -= eventHandler;
				}
				this._nud_valvula3_fechamento = value;
				if (this._nud_valvula3_fechamento != null)
				{
					this._nud_valvula3_fechamento.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x002A5488 File Offset: 0x002A3888
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x002A549C File Offset: 0x002A389C
		internal virtual NumericUpDown nud_parada4
		{
			get
			{
				return this._nud_parada4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_parada4_ValueChanged);
				if (this._nud_parada4 != null)
				{
					this._nud_parada4.ValueChanged -= eventHandler;
				}
				this._nud_parada4 = value;
				if (this._nud_parada4 != null)
				{
					this._nud_parada4.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x002A54E8 File Offset: 0x002A38E8
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x002A54FC File Offset: 0x002A38FC
		internal virtual NumericUpDown nud_partida4
		{
			get
			{
				return this._nud_partida4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_partida4_ValueChanged);
				if (this._nud_partida4 != null)
				{
					this._nud_partida4.ValueChanged -= eventHandler;
				}
				this._nud_partida4 = value;
				if (this._nud_partida4 != null)
				{
					this._nud_partida4.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x002A5548 File Offset: 0x002A3948
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x002A555C File Offset: 0x002A395C
		internal virtual NumericUpDown nud_parada3
		{
			get
			{
				return this._nud_parada3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_parada3_ValueChanged);
				if (this._nud_parada3 != null)
				{
					this._nud_parada3.ValueChanged -= eventHandler;
				}
				this._nud_parada3 = value;
				if (this._nud_parada3 != null)
				{
					this._nud_parada3.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x002A55A8 File Offset: 0x002A39A8
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x002A55BC File Offset: 0x002A39BC
		internal virtual NumericUpDown nud_partida3
		{
			get
			{
				return this._nud_partida3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_partida3_ValueChanged);
				if (this._nud_partida3 != null)
				{
					this._nud_partida3.ValueChanged -= eventHandler;
				}
				this._nud_partida3 = value;
				if (this._nud_partida3 != null)
				{
					this._nud_partida3.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x002A5608 File Offset: 0x002A3A08
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x002A561C File Offset: 0x002A3A1C
		internal virtual NumericUpDown nud_parada2
		{
			get
			{
				return this._nud_parada2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.NumericUpDown22_ValueChanged);
				if (this._nud_parada2 != null)
				{
					this._nud_parada2.ValueChanged -= eventHandler;
				}
				this._nud_parada2 = value;
				if (this._nud_parada2 != null)
				{
					this._nud_parada2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x002A5668 File Offset: 0x002A3A68
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x002A567C File Offset: 0x002A3A7C
		internal virtual NumericUpDown nud_partida2
		{
			get
			{
				return this._nud_partida2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_partida2_ValueChanged);
				if (this._nud_partida2 != null)
				{
					this._nud_partida2.ValueChanged -= eventHandler;
				}
				this._nud_partida2 = value;
				if (this._nud_partida2 != null)
				{
					this._nud_partida2.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x002A56C8 File Offset: 0x002A3AC8
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x002A56DC File Offset: 0x002A3ADC
		internal virtual NumericUpDown nud_parada1
		{
			get
			{
				return this._nud_parada1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_parada1_ValueChanged);
				if (this._nud_parada1 != null)
				{
					this._nud_parada1.ValueChanged -= eventHandler;
				}
				this._nud_parada1 = value;
				if (this._nud_parada1 != null)
				{
					this._nud_parada1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x002A5728 File Offset: 0x002A3B28
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x002A573C File Offset: 0x002A3B3C
		internal virtual NumericUpDown nud_partida1
		{
			get
			{
				return this._nud_partida1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.nud_partida1_ValueChanged);
				if (this._nud_partida1 != null)
				{
					this._nud_partida1.ValueChanged -= eventHandler;
				}
				this._nud_partida1 = value;
				if (this._nud_partida1 != null)
				{
					this._nud_partida1.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x002A5788 File Offset: 0x002A3B88
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x002A579C File Offset: 0x002A3B9C
		internal virtual ComboBox cb_modo_partida2
		{
			get
			{
				return this._cb_modo_partida2;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_modo_partida2_SelectedIndexChanged);
				if (this._cb_modo_partida2 != null)
				{
					this._cb_modo_partida2.SelectedIndexChanged -= eventHandler;
				}
				this._cb_modo_partida2 = value;
				if (this._cb_modo_partida2 != null)
				{
					this._cb_modo_partida2.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x002A57E8 File Offset: 0x002A3BE8
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x002A57FC File Offset: 0x002A3BFC
		internal virtual ComboBox cb_modo_partida1
		{
			get
			{
				return this._cb_modo_partida1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_modo_partida1_SelectedIndexChanged);
				if (this._cb_modo_partida1 != null)
				{
					this._cb_modo_partida1.SelectedIndexChanged -= eventHandler;
				}
				this._cb_modo_partida1 = value;
				if (this._cb_modo_partida1 != null)
				{
					this._cb_modo_partida1.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x002A5848 File Offset: 0x002A3C48
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x002A585C File Offset: 0x002A3C5C
		internal virtual ComboBox cb_modo_partida3
		{
			get
			{
				return this._cb_modo_partida3;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_modo_partida3_SelectedIndexChanged);
				if (this._cb_modo_partida3 != null)
				{
					this._cb_modo_partida3.SelectedIndexChanged -= eventHandler;
				}
				this._cb_modo_partida3 = value;
				if (this._cb_modo_partida3 != null)
				{
					this._cb_modo_partida3.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x002A58A8 File Offset: 0x002A3CA8
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x002A58BC File Offset: 0x002A3CBC
		internal virtual ComboBox cb_modo_partida4
		{
			get
			{
				return this._cb_modo_partida4;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_modo_partida4_SelectedIndexChanged);
				if (this._cb_modo_partida4 != null)
				{
					this._cb_modo_partida4.SelectedIndexChanged -= eventHandler;
				}
				this._cb_modo_partida4 = value;
				if (this._cb_modo_partida4 != null)
				{
					this._cb_modo_partida4.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x002A5908 File Offset: 0x002A3D08
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x002A591C File Offset: 0x002A3D1C
		internal virtual PrintDialog PrintDialog1
		{
			get
			{
				return this._PrintDialog1;
			}
			[MethodImpl(32)]
			set
			{
				this._PrintDialog1 = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x002A5928 File Offset: 0x002A3D28
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x002A593C File Offset: 0x002A3D3C
		internal virtual ToolStripLabel ToolStripLabel_ID
		{
			get
			{
				return this._ToolStripLabel_ID;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripLabel_ID = value;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x002A5948 File Offset: 0x002A3D48
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x002A595C File Offset: 0x002A3D5C
		internal virtual ToolStripSeparator ToolStripSeparator4
		{
			get
			{
				return this._ToolStripSeparator4;
			}
			[MethodImpl(32)]
			set
			{
				this._ToolStripSeparator4 = value;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x002A5968 File Offset: 0x002A3D68
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x002A597C File Offset: 0x002A3D7C
		internal virtual Label Label48
		{
			get
			{
				return this._Label48;
			}
			[MethodImpl(32)]
			set
			{
				this._Label48 = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x002A5988 File Offset: 0x002A3D88
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x002A599C File Offset: 0x002A3D9C
		internal virtual TextBox TextBox_equipamento_820
		{
			get
			{
				return this._TextBox_equipamento_820;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_equipamento_820 = value;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x002A59A8 File Offset: 0x002A3DA8
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x002A59BC File Offset: 0x002A3DBC
		internal virtual Label Label49
		{
			get
			{
				return this._Label49;
			}
			[MethodImpl(32)]
			set
			{
				this._Label49 = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x002A59C8 File Offset: 0x002A3DC8
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x002A59DC File Offset: 0x002A3DDC
		internal virtual TextBox TextBox_release_820
		{
			get
			{
				return this._TextBox_release_820;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_release_820 = value;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x002A59E8 File Offset: 0x002A3DE8
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x002A59FC File Offset: 0x002A3DFC
		internal virtual Label Label50
		{
			get
			{
				return this._Label50;
			}
			[MethodImpl(32)]
			set
			{
				this._Label50 = value;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x002A5A08 File Offset: 0x002A3E08
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x002A5A1C File Offset: 0x002A3E1C
		internal virtual TextBox TextBox_build_820
		{
			get
			{
				return this._TextBox_build_820;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_build_820 = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x002A5A28 File Offset: 0x002A3E28
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x002A5A3C File Offset: 0x002A3E3C
		internal virtual Label Label51
		{
			get
			{
				return this._Label51;
			}
			[MethodImpl(32)]
			set
			{
				this._Label51 = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x002A5A48 File Offset: 0x002A3E48
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x002A5A5C File Offset: 0x002A3E5C
		internal virtual TextBox TextBox_versao_820
		{
			get
			{
				return this._TextBox_versao_820;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox_versao_820 = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x002A5A68 File Offset: 0x002A3E68
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x002A5A7C File Offset: 0x002A3E7C
		internal virtual Label Label52
		{
			get
			{
				return this._Label52;
			}
			[MethodImpl(32)]
			set
			{
				this._Label52 = value;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x002A5A88 File Offset: 0x002A3E88
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x002A5A9C File Offset: 0x002A3E9C
		internal virtual TextBox tb_lixo1
		{
			get
			{
				return this._tb_lixo1;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_lixo1 = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x002A5AA8 File Offset: 0x002A3EA8
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x002A5ABC File Offset: 0x002A3EBC
		internal virtual TextBox tb_lixo2
		{
			get
			{
				return this._tb_lixo2;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_lixo2 = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x002A5AC8 File Offset: 0x002A3EC8
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x002A5ADC File Offset: 0x002A3EDC
		internal virtual TextBox tb_lixo3
		{
			get
			{
				return this._tb_lixo3;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_lixo3 = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x002A5AE8 File Offset: 0x002A3EE8
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x002A5AFC File Offset: 0x002A3EFC
		internal virtual TextBox tb_lixo5
		{
			get
			{
				return this._tb_lixo5;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_lixo5 = value;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x002A5B08 File Offset: 0x002A3F08
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x002A5B1C File Offset: 0x002A3F1C
		internal virtual TextBox tb_lixo6
		{
			get
			{
				return this._tb_lixo6;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_lixo6 = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x002A5B28 File Offset: 0x002A3F28
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x002A5B3C File Offset: 0x002A3F3C
		internal virtual TextBox tb_lixo7
		{
			get
			{
				return this._tb_lixo7;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_lixo7 = value;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x002A5B48 File Offset: 0x002A3F48
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x002A5B5C File Offset: 0x002A3F5C
		internal virtual TextBox tb_lixo8
		{
			get
			{
				return this._tb_lixo8;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_lixo8 = value;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x002A5B68 File Offset: 0x002A3F68
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x002A5B7C File Offset: 0x002A3F7C
		internal virtual GroupBox GroupBox7
		{
			get
			{
				return this._GroupBox7;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox7 = value;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x002A5B88 File Offset: 0x002A3F88
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x002A5B9C File Offset: 0x002A3F9C
		internal virtual CheckBox sph_ativa10
		{
			get
			{
				return this._sph_ativa10;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_ativa10_CheckedChanged);
				if (this._sph_ativa10 != null)
				{
					this._sph_ativa10.CheckedChanged -= eventHandler;
				}
				this._sph_ativa10 = value;
				if (this._sph_ativa10 != null)
				{
					this._sph_ativa10.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x002A5BE8 File Offset: 0x002A3FE8
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x002A5BFC File Offset: 0x002A3FFC
		internal virtual Label Label55
		{
			get
			{
				return this._Label55;
			}
			[MethodImpl(32)]
			set
			{
				this._Label55 = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x002A5C08 File Offset: 0x002A4008
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x002A5C1C File Offset: 0x002A401C
		internal virtual Label Label54
		{
			get
			{
				return this._Label54;
			}
			[MethodImpl(32)]
			set
			{
				this._Label54 = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x002A5C28 File Offset: 0x002A4028
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x002A5C3C File Offset: 0x002A403C
		internal virtual NumericUpDown sph_hora10
		{
			get
			{
				return this._sph_hora10;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_hora10_ValueChanged);
				if (this._sph_hora10 != null)
				{
					this._sph_hora10.ValueChanged -= eventHandler;
				}
				this._sph_hora10 = value;
				if (this._sph_hora10 != null)
				{
					this._sph_hora10.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x002A5C88 File Offset: 0x002A4088
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x002A5C9C File Offset: 0x002A409C
		internal virtual Label Label53
		{
			get
			{
				return this._Label53;
			}
			[MethodImpl(32)]
			set
			{
				this._Label53 = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x002A5CA8 File Offset: 0x002A40A8
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x002A5CBC File Offset: 0x002A40BC
		internal virtual NumericUpDown sph_baixo11
		{
			get
			{
				return this._sph_baixo11;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_baixo11_ValueChanged);
				if (this._sph_baixo11 != null)
				{
					this._sph_baixo11.ValueChanged -= eventHandler;
				}
				this._sph_baixo11 = value;
				if (this._sph_baixo11 != null)
				{
					this._sph_baixo11.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x002A5D08 File Offset: 0x002A4108
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x002A5D1C File Offset: 0x002A411C
		internal virtual NumericUpDown sph_alto11
		{
			get
			{
				return this._sph_alto11;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_alto11_ValueChanged);
				if (this._sph_alto11 != null)
				{
					this._sph_alto11.ValueChanged -= eventHandler;
				}
				this._sph_alto11 = value;
				if (this._sph_alto11 != null)
				{
					this._sph_alto11.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x002A5D68 File Offset: 0x002A4168
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x002A5D7C File Offset: 0x002A417C
		internal virtual NumericUpDown sph_minuto11
		{
			get
			{
				return this._sph_minuto11;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_minuto11_ValueChanged);
				if (this._sph_minuto11 != null)
				{
					this._sph_minuto11.ValueChanged -= eventHandler;
				}
				this._sph_minuto11 = value;
				if (this._sph_minuto11 != null)
				{
					this._sph_minuto11.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x002A5DC8 File Offset: 0x002A41C8
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x002A5DDC File Offset: 0x002A41DC
		internal virtual CheckBox sph_ativa11
		{
			get
			{
				return this._sph_ativa11;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_ativa11_CheckedChanged);
				if (this._sph_ativa11 != null)
				{
					this._sph_ativa11.CheckedChanged -= eventHandler;
				}
				this._sph_ativa11 = value;
				if (this._sph_ativa11 != null)
				{
					this._sph_ativa11.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x002A5E28 File Offset: 0x002A4228
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x002A5E3C File Offset: 0x002A423C
		internal virtual NumericUpDown sph_hora11
		{
			get
			{
				return this._sph_hora11;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_hora11_ValueChanged);
				if (this._sph_hora11 != null)
				{
					this._sph_hora11.ValueChanged -= eventHandler;
				}
				this._sph_hora11 = value;
				if (this._sph_hora11 != null)
				{
					this._sph_hora11.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x002A5E88 File Offset: 0x002A4288
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x002A5E9C File Offset: 0x002A429C
		internal virtual Label Label57
		{
			get
			{
				return this._Label57;
			}
			[MethodImpl(32)]
			set
			{
				this._Label57 = value;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x002A5EA8 File Offset: 0x002A42A8
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x002A5EBC File Offset: 0x002A42BC
		internal virtual Label Label56
		{
			get
			{
				return this._Label56;
			}
			[MethodImpl(32)]
			set
			{
				this._Label56 = value;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x002A5EC8 File Offset: 0x002A42C8
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x002A5EDC File Offset: 0x002A42DC
		internal virtual NumericUpDown sph_baixo10
		{
			get
			{
				return this._sph_baixo10;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_baixo10_ValueChanged);
				if (this._sph_baixo10 != null)
				{
					this._sph_baixo10.ValueChanged -= eventHandler;
				}
				this._sph_baixo10 = value;
				if (this._sph_baixo10 != null)
				{
					this._sph_baixo10.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x002A5F28 File Offset: 0x002A4328
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x002A5F3C File Offset: 0x002A433C
		internal virtual NumericUpDown sph_alto10
		{
			get
			{
				return this._sph_alto10;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_alto10_ValueChanged);
				if (this._sph_alto10 != null)
				{
					this._sph_alto10.ValueChanged -= eventHandler;
				}
				this._sph_alto10 = value;
				if (this._sph_alto10 != null)
				{
					this._sph_alto10.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x002A5F88 File Offset: 0x002A4388
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x002A5F9C File Offset: 0x002A439C
		internal virtual NumericUpDown sph_minuto10
		{
			get
			{
				return this._sph_minuto10;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_minuto10_ValueChanged);
				if (this._sph_minuto10 != null)
				{
					this._sph_minuto10.ValueChanged -= eventHandler;
				}
				this._sph_minuto10 = value;
				if (this._sph_minuto10 != null)
				{
					this._sph_minuto10.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x002A5FE8 File Offset: 0x002A43E8
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x002A5FFC File Offset: 0x002A43FC
		internal virtual NumericUpDown sph_baixo41
		{
			get
			{
				return this._sph_baixo41;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_baixo41_ValueChanged);
				if (this._sph_baixo41 != null)
				{
					this._sph_baixo41.ValueChanged -= eventHandler;
				}
				this._sph_baixo41 = value;
				if (this._sph_baixo41 != null)
				{
					this._sph_baixo41.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x002A6048 File Offset: 0x002A4448
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x002A605C File Offset: 0x002A445C
		internal virtual NumericUpDown sph_alto41
		{
			get
			{
				return this._sph_alto41;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_alto41_ValueChanged);
				if (this._sph_alto41 != null)
				{
					this._sph_alto41.ValueChanged -= eventHandler;
				}
				this._sph_alto41 = value;
				if (this._sph_alto41 != null)
				{
					this._sph_alto41.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x002A60A8 File Offset: 0x002A44A8
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x002A60BC File Offset: 0x002A44BC
		internal virtual NumericUpDown sph_minuto41
		{
			get
			{
				return this._sph_minuto41;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_minuto41_ValueChanged);
				if (this._sph_minuto41 != null)
				{
					this._sph_minuto41.ValueChanged -= eventHandler;
				}
				this._sph_minuto41 = value;
				if (this._sph_minuto41 != null)
				{
					this._sph_minuto41.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x002A6108 File Offset: 0x002A4508
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x002A611C File Offset: 0x002A451C
		internal virtual CheckBox sph_ativa41
		{
			get
			{
				return this._sph_ativa41;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_ativa41_CheckedChanged);
				if (this._sph_ativa41 != null)
				{
					this._sph_ativa41.CheckedChanged -= eventHandler;
				}
				this._sph_ativa41 = value;
				if (this._sph_ativa41 != null)
				{
					this._sph_ativa41.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x002A6168 File Offset: 0x002A4568
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x002A617C File Offset: 0x002A457C
		internal virtual NumericUpDown sph_hora41
		{
			get
			{
				return this._sph_hora41;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_hora41_ValueChanged);
				if (this._sph_hora41 != null)
				{
					this._sph_hora41.ValueChanged -= eventHandler;
				}
				this._sph_hora41 = value;
				if (this._sph_hora41 != null)
				{
					this._sph_hora41.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x002A61C8 File Offset: 0x002A45C8
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x002A61DC File Offset: 0x002A45DC
		internal virtual NumericUpDown sph_baixo40
		{
			get
			{
				return this._sph_baixo40;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_baixo40_ValueChanged);
				if (this._sph_baixo40 != null)
				{
					this._sph_baixo40.ValueChanged -= eventHandler;
				}
				this._sph_baixo40 = value;
				if (this._sph_baixo40 != null)
				{
					this._sph_baixo40.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x002A6228 File Offset: 0x002A4628
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x002A623C File Offset: 0x002A463C
		internal virtual NumericUpDown sph_alto40
		{
			get
			{
				return this._sph_alto40;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_alto40_ValueChanged);
				if (this._sph_alto40 != null)
				{
					this._sph_alto40.ValueChanged -= eventHandler;
				}
				this._sph_alto40 = value;
				if (this._sph_alto40 != null)
				{
					this._sph_alto40.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x002A6288 File Offset: 0x002A4688
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x002A629C File Offset: 0x002A469C
		internal virtual NumericUpDown sph_minuto40
		{
			get
			{
				return this._sph_minuto40;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_minuto40_ValueChanged);
				if (this._sph_minuto40 != null)
				{
					this._sph_minuto40.ValueChanged -= eventHandler;
				}
				this._sph_minuto40 = value;
				if (this._sph_minuto40 != null)
				{
					this._sph_minuto40.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x002A62E8 File Offset: 0x002A46E8
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x002A62FC File Offset: 0x002A46FC
		internal virtual CheckBox sph_ativa40
		{
			get
			{
				return this._sph_ativa40;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_ativa40_CheckedChanged);
				if (this._sph_ativa40 != null)
				{
					this._sph_ativa40.CheckedChanged -= eventHandler;
				}
				this._sph_ativa40 = value;
				if (this._sph_ativa40 != null)
				{
					this._sph_ativa40.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x002A6348 File Offset: 0x002A4748
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x002A635C File Offset: 0x002A475C
		internal virtual NumericUpDown sph_hora40
		{
			get
			{
				return this._sph_hora40;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_hora40_ValueChanged);
				if (this._sph_hora40 != null)
				{
					this._sph_hora40.ValueChanged -= eventHandler;
				}
				this._sph_hora40 = value;
				if (this._sph_hora40 != null)
				{
					this._sph_hora40.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x002A63A8 File Offset: 0x002A47A8
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x002A63BC File Offset: 0x002A47BC
		internal virtual Label Label72
		{
			get
			{
				return this._Label72;
			}
			[MethodImpl(32)]
			set
			{
				this._Label72 = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x002A63C8 File Offset: 0x002A47C8
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x002A63DC File Offset: 0x002A47DC
		internal virtual NumericUpDown sph_baixo31
		{
			get
			{
				return this._sph_baixo31;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_baixo31_ValueChanged);
				if (this._sph_baixo31 != null)
				{
					this._sph_baixo31.ValueChanged -= eventHandler;
				}
				this._sph_baixo31 = value;
				if (this._sph_baixo31 != null)
				{
					this._sph_baixo31.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x002A6428 File Offset: 0x002A4828
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x002A643C File Offset: 0x002A483C
		internal virtual NumericUpDown sph_alto31
		{
			get
			{
				return this._sph_alto31;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_alto31_ValueChanged);
				if (this._sph_alto31 != null)
				{
					this._sph_alto31.ValueChanged -= eventHandler;
				}
				this._sph_alto31 = value;
				if (this._sph_alto31 != null)
				{
					this._sph_alto31.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x002A6488 File Offset: 0x002A4888
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x002A649C File Offset: 0x002A489C
		internal virtual NumericUpDown sph_minuto31
		{
			get
			{
				return this._sph_minuto31;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_minuto31_ValueChanged);
				if (this._sph_minuto31 != null)
				{
					this._sph_minuto31.ValueChanged -= eventHandler;
				}
				this._sph_minuto31 = value;
				if (this._sph_minuto31 != null)
				{
					this._sph_minuto31.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x002A64E8 File Offset: 0x002A48E8
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x002A64FC File Offset: 0x002A48FC
		internal virtual CheckBox sph_ativa31
		{
			get
			{
				return this._sph_ativa31;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_ativa31_CheckedChanged);
				if (this._sph_ativa31 != null)
				{
					this._sph_ativa31.CheckedChanged -= eventHandler;
				}
				this._sph_ativa31 = value;
				if (this._sph_ativa31 != null)
				{
					this._sph_ativa31.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x002A6548 File Offset: 0x002A4948
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x002A655C File Offset: 0x002A495C
		internal virtual NumericUpDown sph_hora31
		{
			get
			{
				return this._sph_hora31;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_hora31_ValueChanged);
				if (this._sph_hora31 != null)
				{
					this._sph_hora31.ValueChanged -= eventHandler;
				}
				this._sph_hora31 = value;
				if (this._sph_hora31 != null)
				{
					this._sph_hora31.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x002A65A8 File Offset: 0x002A49A8
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x002A65BC File Offset: 0x002A49BC
		internal virtual NumericUpDown sph_baixo30
		{
			get
			{
				return this._sph_baixo30;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_baixo30_ValueChanged);
				if (this._sph_baixo30 != null)
				{
					this._sph_baixo30.ValueChanged -= eventHandler;
				}
				this._sph_baixo30 = value;
				if (this._sph_baixo30 != null)
				{
					this._sph_baixo30.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x002A6608 File Offset: 0x002A4A08
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x002A661C File Offset: 0x002A4A1C
		internal virtual NumericUpDown sph_alto30
		{
			get
			{
				return this._sph_alto30;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_alto30_ValueChanged);
				if (this._sph_alto30 != null)
				{
					this._sph_alto30.ValueChanged -= eventHandler;
				}
				this._sph_alto30 = value;
				if (this._sph_alto30 != null)
				{
					this._sph_alto30.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x002A6668 File Offset: 0x002A4A68
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x002A667C File Offset: 0x002A4A7C
		internal virtual NumericUpDown sph_minuto30
		{
			get
			{
				return this._sph_minuto30;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_minuto30_ValueChanged);
				if (this._sph_minuto30 != null)
				{
					this._sph_minuto30.ValueChanged -= eventHandler;
				}
				this._sph_minuto30 = value;
				if (this._sph_minuto30 != null)
				{
					this._sph_minuto30.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x002A66C8 File Offset: 0x002A4AC8
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x002A66DC File Offset: 0x002A4ADC
		internal virtual CheckBox sph_ativa30
		{
			get
			{
				return this._sph_ativa30;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_ativa30_CheckedChanged);
				if (this._sph_ativa30 != null)
				{
					this._sph_ativa30.CheckedChanged -= eventHandler;
				}
				this._sph_ativa30 = value;
				if (this._sph_ativa30 != null)
				{
					this._sph_ativa30.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x002A6728 File Offset: 0x002A4B28
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x002A673C File Offset: 0x002A4B3C
		internal virtual NumericUpDown sph_hora30
		{
			get
			{
				return this._sph_hora30;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_hora30_ValueChanged);
				if (this._sph_hora30 != null)
				{
					this._sph_hora30.ValueChanged -= eventHandler;
				}
				this._sph_hora30 = value;
				if (this._sph_hora30 != null)
				{
					this._sph_hora30.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x002A6788 File Offset: 0x002A4B88
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x002A679C File Offset: 0x002A4B9C
		internal virtual Label Label67
		{
			get
			{
				return this._Label67;
			}
			[MethodImpl(32)]
			set
			{
				this._Label67 = value;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x002A67A8 File Offset: 0x002A4BA8
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x002A67BC File Offset: 0x002A4BBC
		internal virtual NumericUpDown sph_baixo21
		{
			get
			{
				return this._sph_baixo21;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_baixo21_ValueChanged);
				if (this._sph_baixo21 != null)
				{
					this._sph_baixo21.ValueChanged -= eventHandler;
				}
				this._sph_baixo21 = value;
				if (this._sph_baixo21 != null)
				{
					this._sph_baixo21.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x002A6808 File Offset: 0x002A4C08
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x002A681C File Offset: 0x002A4C1C
		internal virtual NumericUpDown sph_alto21
		{
			get
			{
				return this._sph_alto21;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_alto21_ValueChanged);
				if (this._sph_alto21 != null)
				{
					this._sph_alto21.ValueChanged -= eventHandler;
				}
				this._sph_alto21 = value;
				if (this._sph_alto21 != null)
				{
					this._sph_alto21.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x002A6868 File Offset: 0x002A4C68
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x002A687C File Offset: 0x002A4C7C
		internal virtual NumericUpDown sph_minuto21
		{
			get
			{
				return this._sph_minuto21;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_minuto21_ValueChanged);
				if (this._sph_minuto21 != null)
				{
					this._sph_minuto21.ValueChanged -= eventHandler;
				}
				this._sph_minuto21 = value;
				if (this._sph_minuto21 != null)
				{
					this._sph_minuto21.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x002A68C8 File Offset: 0x002A4CC8
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x002A68DC File Offset: 0x002A4CDC
		internal virtual CheckBox sph_ativa21
		{
			get
			{
				return this._sph_ativa21;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_ativa21_CheckedChanged);
				if (this._sph_ativa21 != null)
				{
					this._sph_ativa21.CheckedChanged -= eventHandler;
				}
				this._sph_ativa21 = value;
				if (this._sph_ativa21 != null)
				{
					this._sph_ativa21.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x002A6928 File Offset: 0x002A4D28
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x002A693C File Offset: 0x002A4D3C
		internal virtual NumericUpDown sph_hora21
		{
			get
			{
				return this._sph_hora21;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_hora21_ValueChanged);
				if (this._sph_hora21 != null)
				{
					this._sph_hora21.ValueChanged -= eventHandler;
				}
				this._sph_hora21 = value;
				if (this._sph_hora21 != null)
				{
					this._sph_hora21.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x002A6988 File Offset: 0x002A4D88
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x002A699C File Offset: 0x002A4D9C
		internal virtual NumericUpDown sph_baixo20
		{
			get
			{
				return this._sph_baixo20;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_baixo20_ValueChanged);
				if (this._sph_baixo20 != null)
				{
					this._sph_baixo20.ValueChanged -= eventHandler;
				}
				this._sph_baixo20 = value;
				if (this._sph_baixo20 != null)
				{
					this._sph_baixo20.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x002A69E8 File Offset: 0x002A4DE8
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x002A69FC File Offset: 0x002A4DFC
		internal virtual NumericUpDown sph_alto20
		{
			get
			{
				return this._sph_alto20;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_alto20_ValueChanged);
				if (this._sph_alto20 != null)
				{
					this._sph_alto20.ValueChanged -= eventHandler;
				}
				this._sph_alto20 = value;
				if (this._sph_alto20 != null)
				{
					this._sph_alto20.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x002A6A48 File Offset: 0x002A4E48
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x002A6A5C File Offset: 0x002A4E5C
		internal virtual NumericUpDown sph_minuto20
		{
			get
			{
				return this._sph_minuto20;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_minuto20_ValueChanged);
				if (this._sph_minuto20 != null)
				{
					this._sph_minuto20.ValueChanged -= eventHandler;
				}
				this._sph_minuto20 = value;
				if (this._sph_minuto20 != null)
				{
					this._sph_minuto20.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x002A6AA8 File Offset: 0x002A4EA8
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x002A6ABC File Offset: 0x002A4EBC
		internal virtual CheckBox sph_ativa20
		{
			get
			{
				return this._sph_ativa20;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_ativa20_CheckedChanged);
				if (this._sph_ativa20 != null)
				{
					this._sph_ativa20.CheckedChanged -= eventHandler;
				}
				this._sph_ativa20 = value;
				if (this._sph_ativa20 != null)
				{
					this._sph_ativa20.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x002A6B08 File Offset: 0x002A4F08
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x002A6B1C File Offset: 0x002A4F1C
		internal virtual NumericUpDown sph_hora20
		{
			get
			{
				return this._sph_hora20;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.sph_hora20_ValueChanged);
				if (this._sph_hora20 != null)
				{
					this._sph_hora20.ValueChanged -= eventHandler;
				}
				this._sph_hora20 = value;
				if (this._sph_hora20 != null)
				{
					this._sph_hora20.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x002A6B68 File Offset: 0x002A4F68
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x002A6B7C File Offset: 0x002A4F7C
		internal virtual Label Label62
		{
			get
			{
				return this._Label62;
			}
			[MethodImpl(32)]
			set
			{
				this._Label62 = value;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x002A6B88 File Offset: 0x002A4F88
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x002A6B9C File Offset: 0x002A4F9C
		internal virtual Label Label73
		{
			get
			{
				return this._Label73;
			}
			[MethodImpl(32)]
			set
			{
				this._Label73 = value;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x002A6BA8 File Offset: 0x002A4FA8
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x002A6BBC File Offset: 0x002A4FBC
		internal virtual Label Label75
		{
			get
			{
				return this._Label75;
			}
			[MethodImpl(32)]
			set
			{
				this._Label75 = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x002A6BC8 File Offset: 0x002A4FC8
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x002A6BDC File Offset: 0x002A4FDC
		internal virtual Label Label74
		{
			get
			{
				return this._Label74;
			}
			[MethodImpl(32)]
			set
			{
				this._Label74 = value;
			}
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x002A6BE8 File Offset: 0x002A4FE8
		private void InicializaEStruturasVariaveis_RT820()
		{
			this.InicializaEstrutura_DataGridView_Processos();
			this.InicializaEstrutura_DataGridView_Vazoes();
			this.InicializaEstrutura_DataGridView_ED();
			this.GeraDataGridView_ED();
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x002A6C04 File Offset: 0x002A5004
		private void RT_820_conf_Load(object sender, EventArgs e)
		{
			RT_geral.Lmte_Init_ok = false;
			this.bloqueio_IO = false;
			RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.valores = new int[3];
			RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.itens = new string[3];
			RT_geral.RT_820_200_BD.cfg_geral.entradas = new RT_geral.Combo_ictel[9];
			RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.valores = new int[6];
			RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.itens = new string[6];
			RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.valores = new int[3];
			RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.itens = new string[3];
			RT_geral.RT_820_200_BD.repetidora.Repetidoras = new RT_geral.Integer_ictel[51];
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida = new RT_geral.Combo_ictel[5];
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida[0].itens = new string[28];
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida[0].valores = new int[28];
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida[1].itens = new string[28];
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida[1].valores = new int[28];
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida[2].itens = new string[28];
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida[2].valores = new int[28];
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida[3].itens = new string[28];
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida[3].valores = new int[28];
			RT_geral.RT_820_200_BD.cfg_geral.perifericos = new RT_geral.PERIFERICO[5];
			RT_geral.RT_820_200_BD.cfg_geral.perifericos[0].Equipamento.itens = new string[20];
			RT_geral.RT_820_200_BD.cfg_geral.perifericos[0].Equipamento.valores = new int[20];
			RT_geral.RT_820_200_BD.cfg_geral.perifericos[1].Equipamento.itens = new string[20];
			RT_geral.RT_820_200_BD.cfg_geral.perifericos[1].Equipamento.valores = new int[20];
			RT_geral.RT_820_200_BD.cfg_geral.perifericos[2].Equipamento.itens = new string[20];
			RT_geral.RT_820_200_BD.cfg_geral.perifericos[2].Equipamento.valores = new int[20];
			RT_geral.RT_820_200_BD.cfg_geral.perifericos[3].Equipamento.itens = new string[20];
			RT_geral.RT_820_200_BD.cfg_geral.perifericos[3].Equipamento.valores = new int[20];
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens = new string[19];
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores = new int[19];
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens = new string[19];
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores = new int[19];
			RT_geral.RT_820_200_BD.setpoint_horario = new RT_geral.SETPOINT_HORARIO_RT_820_200[9];
			this.Inicializa_DadosEStruturaRT820_Padrao();
			RT_geral.Lmte_Init_ok = true;
			this.InicializaEstrutura_DataGridView_ED();
			this.GeraDataGridView_ED();
			perifericos.Cria_ListaPeriferico_RT820_200();
			this.InicializaEstrutura_DataGridView_Periferico();
			this.GeraDataGridView_Perifericos();
			this.InicializaEstrutura_DataGridView_repetidora();
			this.GeraDataGridView_Repedidora();
			NumericUpDown numericUpDown = this.NumericUpDown_end_est;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.End_estacao);
			this.NumericUpDown_end_est = numericUpDown;
			numericUpDown = this.NumericUpDown_end_mestre;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.End_mestre);
			this.NumericUpDown_end_mestre = numericUpDown;
			numericUpDown = this.NumericUpDown_temp_ptt;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.Tempo_ptt);
			this.NumericUpDown_temp_ptt = numericUpDown;
			ComboBox comboBox = this.ComboBox_baudrate_COM2_820;
			this.CarregaComboBoxBaudRate(ref comboBox, ref RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2);
			this.ComboBox_baudrate_COM2_820 = comboBox;
			numericUpDown = this.NumericUpDown_intervalo_filtro_820;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.AD_Intervalo);
			this.NumericUpDown_intervalo_filtro_820 = numericUpDown;
			numericUpDown = this.NumericUpDown_tamanho_filtro_820;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.AD_Tamanho_filtro);
			this.NumericUpDown_tamanho_filtro_820 = numericUpDown;
			comboBox = this.cb_Protecao;
			this.CarregaComboBoxBaudRate(ref comboBox, ref RT_geral.RT_820_200_BD.cfg_geral.origem_protecao);
			this.cb_Protecao = comboBox;
			comboBox = this.cb_Controle;
			this.CarregaComboBoxBaudRate(ref comboBox, ref RT_geral.RT_820_200_BD.cfg_geral.origem_controle);
			this.cb_Controle = comboBox;
			numericUpDown = this.nud_motor1_alto;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Alto);
			this.nud_motor1_alto = numericUpDown;
			numericUpDown = this.nud_motor1_baixo;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Baixo);
			this.nud_motor1_baixo = numericUpDown;
			numericUpDown = this.nud_motor2_alto;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Alto);
			this.nud_motor2_alto = numericUpDown;
			numericUpDown = this.nud_motor2_baixo;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Baixo);
			this.nud_motor2_baixo = numericUpDown;
			numericUpDown = this.nud_motor3_alto;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Alto);
			this.nud_motor3_alto = numericUpDown;
			numericUpDown = this.nud_motor3_baixo;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Baixo);
			this.nud_motor3_baixo = numericUpDown;
			numericUpDown = this.nud_motor4_alto;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Alto);
			this.nud_motor4_alto = numericUpDown;
			numericUpDown = this.nud_motor4_baixo;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Baixo);
			this.nud_motor4_baixo = numericUpDown;
			numericUpDown = this.nud_protecao_desliga;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Desliga);
			this.nud_protecao_desliga = numericUpDown;
			numericUpDown = this.nud_protecao_liga;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Liga);
			this.nud_protecao_liga = numericUpDown;
			numericUpDown = this.sph_hora10;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[0].Hora);
			this.sph_hora10 = numericUpDown;
			numericUpDown = this.sph_minuto10;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[0].Minuto);
			this.sph_minuto10 = numericUpDown;
			numericUpDown = this.sph_alto10;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[0].Alto);
			this.sph_alto10 = numericUpDown;
			numericUpDown = this.sph_baixo10;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[0].Baixo);
			this.sph_baixo10 = numericUpDown;
			numericUpDown = this.sph_hora11;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[1].Hora);
			this.sph_hora11 = numericUpDown;
			numericUpDown = this.sph_minuto11;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[1].Minuto);
			this.sph_minuto11 = numericUpDown;
			numericUpDown = this.sph_alto11;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[1].Alto);
			this.sph_alto11 = numericUpDown;
			numericUpDown = this.sph_baixo11;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[1].Baixo);
			this.sph_baixo11 = numericUpDown;
			numericUpDown = this.sph_hora20;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[2].Hora);
			this.sph_hora20 = numericUpDown;
			numericUpDown = this.sph_minuto20;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[2].Minuto);
			this.sph_minuto20 = numericUpDown;
			numericUpDown = this.sph_alto20;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[2].Alto);
			this.sph_alto20 = numericUpDown;
			numericUpDown = this.sph_baixo20;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[2].Baixo);
			this.sph_baixo20 = numericUpDown;
			numericUpDown = this.sph_hora21;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[3].Hora);
			this.sph_hora21 = numericUpDown;
			numericUpDown = this.sph_minuto21;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[3].Minuto);
			this.sph_minuto21 = numericUpDown;
			numericUpDown = this.sph_alto21;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[3].Alto);
			this.sph_alto21 = numericUpDown;
			numericUpDown = this.sph_baixo21;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[3].Baixo);
			this.sph_baixo21 = numericUpDown;
			numericUpDown = this.sph_hora30;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[4].Hora);
			this.sph_hora30 = numericUpDown;
			numericUpDown = this.sph_minuto30;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[4].Minuto);
			this.sph_minuto30 = numericUpDown;
			numericUpDown = this.sph_alto30;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[4].Alto);
			this.sph_alto30 = numericUpDown;
			numericUpDown = this.sph_baixo30;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[4].Baixo);
			this.sph_baixo30 = numericUpDown;
			numericUpDown = this.sph_hora31;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[5].Hora);
			this.sph_hora31 = numericUpDown;
			numericUpDown = this.sph_minuto31;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[5].Minuto);
			this.sph_minuto31 = numericUpDown;
			numericUpDown = this.sph_alto31;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[5].Alto);
			this.sph_alto31 = numericUpDown;
			numericUpDown = this.sph_baixo31;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[5].Baixo);
			this.sph_baixo31 = numericUpDown;
			numericUpDown = this.sph_hora40;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[6].Hora);
			this.sph_hora40 = numericUpDown;
			numericUpDown = this.sph_minuto40;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[6].Minuto);
			this.sph_minuto40 = numericUpDown;
			numericUpDown = this.sph_alto40;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[6].Alto);
			this.sph_alto40 = numericUpDown;
			numericUpDown = this.sph_baixo40;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[6].Baixo);
			this.sph_baixo40 = numericUpDown;
			numericUpDown = this.sph_hora41;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[7].Hora);
			this.sph_hora41 = numericUpDown;
			numericUpDown = this.sph_minuto41;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[7].Minuto);
			this.sph_minuto41 = numericUpDown;
			numericUpDown = this.sph_alto41;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[7].Alto);
			this.sph_alto41 = numericUpDown;
			numericUpDown = this.sph_baixo41;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.setpoint_horario[7].Baixo);
			this.sph_baixo41 = numericUpDown;
			comboBox = this.cb_modo_operacao;
			this.CarregaComboBoxBaudRate(ref comboBox, ref RT_geral.RT_820_200_BD.cfg_geral.modo_operacao);
			this.cb_modo_operacao = comboBox;
			numericUpDown = this.nud_numero_motores;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.quantidade_motores);
			this.nud_numero_motores = numericUpDown;
			numericUpDown = this.nud_numero_valvulas;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.quantidade_valvulas);
			this.nud_numero_valvulas = numericUpDown;
			numericUpDown = this.nud_bombas_simultaneas;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.bombas_simultaneas);
			this.nud_bombas_simultaneas = numericUpDown;
			numericUpDown = this.nud_tempo_operacoes;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.tempo_acionamentos);
			this.nud_tempo_operacoes = numericUpDown;
			numericUpDown = this.nud_valvula1_abertura;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula1);
			this.nud_valvula1_abertura = numericUpDown;
			numericUpDown = this.nud_valvula2_abertura;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula2);
			this.nud_valvula2_abertura = numericUpDown;
			numericUpDown = this.nud_valvula3_abertura;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula3);
			this.nud_valvula3_abertura = numericUpDown;
			numericUpDown = this.nud_valvula4_abertura;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula4);
			this.nud_valvula4_abertura = numericUpDown;
			numericUpDown = this.nud_valvula1_fechamento;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula1);
			this.nud_valvula1_fechamento = numericUpDown;
			numericUpDown = this.nud_valvula2_fechamento;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula2);
			this.nud_valvula2_fechamento = numericUpDown;
			numericUpDown = this.nud_valvula3_fechamento;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula3);
			this.nud_valvula3_fechamento = numericUpDown;
			numericUpDown = this.nud_valvula4_fechamento;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula4);
			this.nud_valvula4_fechamento = numericUpDown;
			comboBox = this.cb_modo_partida1;
			this.CarregaComboBoxBaudRate(ref comboBox, ref RT_geral.RT_820_200_BD.cfg_geral.modo_partida[0]);
			this.cb_modo_partida1 = comboBox;
			comboBox = this.cb_modo_partida2;
			this.CarregaComboBoxBaudRate(ref comboBox, ref RT_geral.RT_820_200_BD.cfg_geral.modo_partida[1]);
			this.cb_modo_partida2 = comboBox;
			comboBox = this.cb_modo_partida3;
			this.CarregaComboBoxBaudRate(ref comboBox, ref RT_geral.RT_820_200_BD.cfg_geral.modo_partida[2]);
			this.cb_modo_partida3 = comboBox;
			comboBox = this.cb_modo_partida4;
			this.CarregaComboBoxBaudRate(ref comboBox, ref RT_geral.RT_820_200_BD.cfg_geral.modo_partida[3]);
			this.cb_modo_partida4 = comboBox;
			numericUpDown = this.nud_partida1;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.partida.Motor1);
			this.nud_partida1 = numericUpDown;
			numericUpDown = this.nud_partida2;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.partida.Motor2);
			this.nud_partida2 = numericUpDown;
			numericUpDown = this.nud_partida3;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.partida.Motor3);
			this.nud_partida3 = numericUpDown;
			numericUpDown = this.nud_partida4;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.partida.Motor4);
			this.nud_partida4 = numericUpDown;
			numericUpDown = this.nud_parada1;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.parada.Motor1);
			this.nud_parada1 = numericUpDown;
			numericUpDown = this.nud_parada2;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.parada.Motor2);
			this.nud_parada2 = numericUpDown;
			numericUpDown = this.nud_parada3;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.parada.Motor3);
			this.nud_parada3 = numericUpDown;
			numericUpDown = this.nud_parada4;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.cfg_geral.parada.Motor4);
			this.nud_parada4 = numericUpDown;
			comboBox = this.cb_ModoRepetidora;
			this.CarregaComboBoxBaudRate(ref comboBox, ref RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora);
			this.cb_ModoRepetidora = comboBox;
			numericUpDown = this.NumericUpDown_end_rep_820;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.repetidora.End_repetidora);
			this.NumericUpDown_end_rep_820 = numericUpDown;
			numericUpDown = this.NumericUpDown_num_est_rep_820;
			this.CarregaNumericUpDown(ref numericUpDown, RT_geral.RT_820_200_BD.repetidora.Num_repetidoras);
			this.NumericUpDown_num_est_rep_820 = numericUpDown;
			this.Inicializa_DadosEStruturaRT820_Default();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			this.TabPage_geral.BackColor = Color.FromKnownColor(8);
			this.TabPage_geral.ForeColor = Color.FromKnownColor(10);
			this.TabPage_controle.BackColor = Color.FromKnownColor(8);
			this.TabPage_controle.ForeColor = Color.FromKnownColor(10);
			this.TabPage_EA.BackColor = Color.FromKnownColor(8);
			this.TabPage_EA.ForeColor = Color.FromKnownColor(10);
			this.TabPage_ED.BackColor = Color.FromKnownColor(8);
			this.TabPage_ED.ForeColor = Color.FromKnownColor(10);
			this.TabPage_setpoints.BackColor = Color.FromKnownColor(8);
			this.TabPage_setpoints.ForeColor = Color.FromKnownColor(10);
			this.TabPage_vazao_perifericos.BackColor = Color.FromKnownColor(8);
			this.TabPage_vazao_perifericos.ForeColor = Color.FromKnownColor(10);
			this.TabPage_repetidora.BackColor = Color.FromKnownColor(8);
			this.TabPage_repetidora.ForeColor = Color.FromKnownColor(10);
			this.TabPage1.BackColor = Color.FromKnownColor(8);
			this.TabPage1.ForeColor = Color.FromKnownColor(10);
			this.TabPage_MotoresValvulas.BackColor = Color.FromKnownColor(8);
			this.TabPage_MotoresValvulas.ForeColor = Color.FromKnownColor(10);
			this.GroupBox_comunicacao_820.Enabled = true;
			this.GroupBox_informacoes_820.Enabled = true;
			this.GroupBox_descricao_RT820.Enabled = true;
			this.GroupBox_parametros_repetidora_820.Enabled = true;
			this.GroupBox_EA_820.Enabled = true;
			this.GroupBox_end_rep_820.Enabled = true;
			string text = ".\\\\Fontes\\\\Ictel Extendida Italic.ttf";
			if (MyProject.Computer.FileSystem.FileExists(text))
			{
				PrivateFontCollection privateFontCollection = new PrivateFontCollection();
				privateFontCollection.AddFontFile(text);
				Font font = new Font(privateFontCollection.Families[0], 8f, 2);
				Font font2 = new Font(privateFontCollection.Families[0], 18f, 2);
				this.Label48.Font = font;
				this.TextBox_equipamento_820.Font = font;
				this.TextBox_versao_820.Font = font;
				this.TextBox_build_820.Font = font;
				this.TextBox_release_820.Font = font;
				this.ToolStripLabel_ID.Font = font2;
			}
			else
			{
				MessageBox.Show("Removido fonte Ictel Extendida Italic da pasta da aplicação!");
			}
			this.Atualiza_TelaRT820();
			this.ToolStripLabel_ID.Text = RT_geral.MontaNomePlacaPeloFabricante(RT_geral.RT_820_200_BD.firmware.Equip.Valor, RT_geral.RT_820_200_BD.firmware.Versao.Valor);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x002A7FB0 File Offset: 0x002A63B0
		private void RT_820_conf_Activated(object sender, EventArgs e)
		{
			Geral.Equipamento_selecionado = 820;
			Geral.Equipamento_versao = 2;
			Geral.Equipamento_build = 20;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x002A7FCC File Offset: 0x002A63CC
		private void RT_820_conf_FormClosed(object sender, FormClosedEventArgs e)
		{
			RT_geral.Telas_RT_820_200.Configuracao = false;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x002A7FDC File Offset: 0x002A63DC
		private void GeraDataGridView_Processos()
		{
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x002A7FE0 File Offset: 0x002A63E0
		private void InicializaEstrutura_DataGridView_Processos()
		{
			int i = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[i].LinhasMenu = new string[35];
					RT_geral.RT_820_DataGrigViewProcessosColunas[i].LinhasValor = new int[35];
					i++;
				}
				while (i <= 15);
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].TagColuna = "Acionamento";
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].TagColuna = "Retorno Acionamento";
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].TagColuna = "Desacionamento";
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].TagColuna = "Retorno Desacionamento";
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].TagColuna = "Seleção Remoto";
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].TagColuna = "Bloqueio Digital";
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].TagColuna = "Liberação Digital";
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].TagColuna = "Seleção Reverso";
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].TagColuna = "Modo Controle";
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].TagColuna = "Grupo de Controle";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].TagColuna = "Tempo Partida";
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].TagColuna = "Tempo Parada";
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].TagColuna = "Tempo Mínimo Parado";
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].TagColuna = "Tempo Mínimo Operando";
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].NomeColuna = "SDAciona";
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].NomeColuna = "EDRetAci";
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].NomeColuna = "SDDesaci";
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].NomeColuna = "EDRetDes";
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].NomeColuna = "EDRemoto";
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].NomeColuna = "EDBloqueio";
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].NomeColuna = "EDLiberar";
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].NomeColuna = "Reverso";
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].NomeColuna = "ModoCtrl";
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].NomeColuna = "GrupoCtrl";
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].NomeColuna = "TpMaxPart";
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].NomeColuna = "TpMaxParada";
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].NomeColuna = "TpMinParado";
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].NomeColuna = "TpMinOperan";
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].LarguraColuna = 110;
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].LarguraColuna = 50;
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].LarguraColuna = 50;
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].LarguraColuna = 50;
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].LarguraColuna = 55;
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasMenu[0] = "Desativa";
				RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasMenu[0] = "Desativa";
				RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasValor[0] = 21856;
				int num;
				int num2;
				if (RT_geral.RT_820_BD.HabExpIO.Valor == 21857)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].NumeroLinhaMenu = 18;
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].NumeroLinhaMenu = 18;
					num = 12;
					num2 = 0;
				}
				else
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].NumeroLinhaMenu = 14;
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].NumeroLinhaMenu = 14;
					num = 8;
					num2 = 4;
				}
				int num3 = 1;
				int num4 = num;
				for (i = num3; i <= num4; i++)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasMenu[i] = "SD - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasValor[i] = 21856 + i;
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasMenu[i] = "SD - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasValor[i] = 21856 + i;
				}
				int num5 = num + 1;
				num = num5 + 4;
				int num6 = num5;
				int num7 = num;
				for (i = num6; i <= num7; i++)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasMenu[i] = "Periférico - " + Strings.Format(i + num2 - 12, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[0].LinhasValor[i] = 21860 + i + num2;
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasMenu[i] = "Periférico - " + Strings.Format(i + num2 - 12, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[2].LinhasValor[i] = 21860 + i + num2;
				}
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasMenu[0] = "Não usada";
				RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasMenu[0] = "Não usada";
				RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].LinhasMenu[0] = "Sempre Remoto";
				RT_geral.RT_820_DataGrigViewProcessosColunas[4].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].LinhasMenu[0] = "Sem Liberação";
				RT_geral.RT_820_DataGrigViewProcessosColunas[6].LinhasValor[0] = 21856;
				if (RT_geral.RT_820_BD.HabExpIO.Valor == 21857)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[1].NumeroLinhaMenu = 22;
					RT_geral.RT_820_DataGrigViewProcessosColunas[3].NumeroLinhaMenu = 22;
					RT_geral.RT_820_DataGrigViewProcessosColunas[4].NumeroLinhaMenu = 17;
					RT_geral.RT_820_DataGrigViewProcessosColunas[6].NumeroLinhaMenu = 17;
					num = 16;
					num2 = 0;
				}
				else
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[1].NumeroLinhaMenu = 14;
					RT_geral.RT_820_DataGrigViewProcessosColunas[3].NumeroLinhaMenu = 14;
					RT_geral.RT_820_DataGrigViewProcessosColunas[4].NumeroLinhaMenu = 9;
					RT_geral.RT_820_DataGrigViewProcessosColunas[6].NumeroLinhaMenu = 9;
					num = 8;
					num2 = 8;
				}
				int num8 = 1;
				int num9 = num;
				for (i = num8; i <= num9; i++)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasMenu[i] = "ED - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasValor[i] = 21856 + i;
					RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasMenu[i] = "ED - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasValor[i] = 21856 + i;
					RT_geral.RT_820_DataGrigViewProcessosColunas[4].LinhasMenu[i] = "ED - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[4].LinhasValor[i] = 21856 + i;
					RT_geral.RT_820_DataGrigViewProcessosColunas[6].LinhasMenu[i] = "ED - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[6].LinhasValor[i] = 21856 + i;
				}
				num5 = num + 1;
				num = num5 + 4;
				int num10 = num5;
				int num11 = num;
				for (i = num10; i <= num11; i++)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasMenu[i] = "Periférico - " + Strings.Format(i - 16 + num2, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[1].LinhasValor[i] = 21856 + i + num2;
					RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasMenu[i] = "Periférico - " + Strings.Format(i - 16 + num2, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[3].LinhasValor[i] = 21856 + i + num2;
				}
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasMenu[0] = "Sem Bloqueio";
				RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasValor[0] = 21856;
				if (RT_geral.RT_820_BD.HabExpIO.Valor == 21857)
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[5].NumeroLinhaMenu = 33;
					num = 16;
				}
				else
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[5].NumeroLinhaMenu = 17;
					num = 8;
				}
				int num12 = 1;
				int num13 = num;
				for (i = num12; i <= num13; i++)
				{
					num2 = i * 2;
					RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasMenu[num2 - 1] = "ED - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasMenu[num2] = "ED - " + Strings.Format(i, "0#") + " reverso";
					RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasValor[num2 - 1] = 21856 + num2 - 1;
					RT_geral.RT_820_DataGrigViewProcessosColunas[5].LinhasValor[num2] = 21856 + num2;
				}
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].NumeroLinhaMenu = 2;
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].LinhasMenu[0] = "Desabilitado";
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].LinhasMenu[1] = "Habilitado";
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[7].LinhasValor[1] = 21857;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].NumeroLinhaMenu = 3;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasMenu[0] = "Telecomando";
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasMenu[1] = "Automático";
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasMenu[2] = "Timer";
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasValor[1] = 21857;
				RT_geral.RT_820_DataGrigViewProcessosColunas[8].LinhasValor[2] = 21858;
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].NumeroLinhaMenu = 5;
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasMenu[0] = "Nenhum Grupo";
				RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasValor[0] = 21856;
				i = 1;
				do
				{
					RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasMenu[i] = "Grupo - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewProcessosColunas[9].LinhasValor[i] = 21856 + i;
					i++;
				}
				while (i <= 4);
				RT_geral.RT_820_DataGrigViewProcessosColunas[10].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewProcessosColunas[11].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewProcessosColunas[12].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewProcessosColunas[13].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x002A8CE4 File Offset: 0x002A70E4
		private void GeraDataGridView_Grupos()
		{
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x002A8CE8 File Offset: 0x002A70E8
		private void InicializaEstrutura_DataGridView_agrupamentos()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewGruposColunas[num].LinhasMenu = new string[10];
					RT_geral.RT_820_DataGrigViewGruposColunas[num].LinhasValor = new int[10];
					num++;
				}
				while (num <= 1);
				RT_geral.RT_820_DataGrigViewGruposColunas[0].TagColuna = "Acionamentos Permitidos";
				RT_geral.RT_820_DataGrigViewGruposColunas[1].TagColuna = "Tempo Entre Acionamentos";
				RT_geral.RT_820_DataGrigViewGruposColunas[0].NomeColuna = "ASimultaneos";
				RT_geral.RT_820_DataGrigViewGruposColunas[1].NomeColuna = "TpAcionamentos";
				RT_geral.RT_820_DataGrigViewGruposColunas[0].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewGruposColunas[1].LarguraColuna = 100;
				RT_geral.RT_820_DataGrigViewGruposColunas[0].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewGruposColunas[1].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewGruposColunas[0].NumeroLinhaMenu = 9;
				RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasMenu[0] = "Liberado";
				RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasValor[0] = 21856;
				num = 1;
				do
				{
					RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasMenu[num] = Strings.Format(num, "0#");
					RT_geral.RT_820_DataGrigViewGruposColunas[0].LinhasValor[num] = 21856 + num;
					num++;
				}
				while (num <= 8);
				RT_geral.RT_820_DataGrigViewGruposColunas[1].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x002A8E60 File Offset: 0x002A7260
		private void GeraDataGridView_EA()
		{
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x002A8E64 File Offset: 0x002A7264
		private void InicializaEstrutura_DataGridView_EA()
		{
			RT_geral.RT_820_DataGrigViewEAColunas[0].TagColuna = "Range";
			RT_geral.RT_820_DataGrigViewEAColunas[1].TagColuna = "Início";
			RT_geral.RT_820_DataGrigViewEAColunas[2].TagColuna = "Fim";
			RT_geral.RT_820_DataGrigViewEAColunas[0].NomeColuna = "range";
			RT_geral.RT_820_DataGrigViewEAColunas[1].NomeColuna = "ini";
			RT_geral.RT_820_DataGrigViewEAColunas[2].NomeColuna = "fim";
			RT_geral.RT_820_DataGrigViewEAColunas[0].LarguraColuna = 90;
			RT_geral.RT_820_DataGrigViewEAColunas[1].LarguraColuna = 90;
			RT_geral.RT_820_DataGrigViewEAColunas[2].LarguraColuna = 90;
			RT_geral.RT_820_DataGrigViewEAColunas[0].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewEAColunas[1].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewEAColunas[2].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewEAColunas[0].NumeroLinhaMenu = 0;
			RT_geral.RT_820_DataGrigViewGruposColunas[1].NumeroLinhaMenu = 0;
			RT_geral.RT_820_DataGrigViewGruposColunas[2].NumeroLinhaMenu = 0;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x002A8F90 File Offset: 0x002A7390
		private void GeraDataGridView_Perifericos()
		{
			this.DataGridView_periferico_RT820.Columns.Clear();
			this.DataGridView_periferico_RT820.CellBorderStyle = (System.Windows.Forms.BorderStyle)1;
			this.DataGridView_periferico_RT820.DefaultCellStyle.Alignment = (System.Windows.Forms.HorizontalAlignment)64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_820_DataGrigViewPerifericosColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewPerifericosColunas);
						this.DataGridView_periferico_RT820.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewPerifericosColunas);
						this.DataGridView_periferico_RT820.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 1);
				this.DataGridView_periferico_RT820.RowCount = 4;
				this.DataGridView_periferico_RT820.RowHeadersWidth = 100;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_periferico_RT820.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "Periférico " + Conversions.ToString(num2);
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

		// Token: 0x06000785 RID: 1925 RVA: 0x002A90CC File Offset: 0x002A74CC
		private void InicializaEstrutura_DataGridView_Periferico()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewPerifericosColunas[num].LinhasMenu = new string[perifericos.perif_RT820_200.Count + 1];
					RT_geral.RT_820_DataGrigViewPerifericosColunas[num].LinhasValor = new int[perifericos.perif_RT820_200.Count + 1];
					num++;
				}
				while (num <= 1);
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].TagColuna = "Modelo";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[1].TagColuna = "Endereço";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].NomeColuna = "modelo";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[1].NomeColuna = "end";
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LarguraColuna = 250;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[1].LarguraColuna = 60;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].AlingColuna = 16;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[1].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewPerifericosColunas[0].NumeroLinhaMenu = perifericos.perif_RT820_200.Count;
				int num2 = 48;
				num = 0;
				try
				{
					foreach (perifericos.Periferico periferico in perifericos.perif_RT820_200)
					{
						RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[num] = periferico.nome;
						RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[num] = num2 + num;
						num++;
					}
				}
				finally
				{
					List<perifericos.Periferico>.Enumerator enumerator;
					enumerator.Dispose();
				}
				RT_geral.RT_820_DataGrigViewPerifericosColunas[1].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x002A9264 File Offset: 0x002A7664
		private void GeraDataGridView_Vazoes()
		{
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x002A9268 File Offset: 0x002A7668
		private void InicializaEstrutura_DataGridView_Vazoes()
		{
			int i = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewVazoesColunas[i].LinhasMenu = new string[51];
					RT_geral.RT_820_DataGrigViewVazoesColunas[i].LinhasValor = new int[51];
					i++;
				}
				while (i <= 0);
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].TagColuna = "Entrada";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].NomeColuna = "Entrada";
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LarguraColuna = 200;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[0] = "Leitura desabilitada";
				int num;
				if (RT_geral.RT_820_BD.HabExpIO.Valor == 21857)
				{
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].NumeroLinhaMenu = 49;
					num = 16;
				}
				else
				{
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].NumeroLinhaMenu = 33;
					num = 8;
				}
				i = 1;
				do
				{
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[i] = 21856 + i;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[i] = "Leitura vazão - EA " + Strings.Format(i, "#0");
					i++;
				}
				while (i <= 16);
				int num2 = 1;
				int num3 = num;
				for (i = num2; i <= num3; i++)
				{
					int num4 = i * 2;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[num4 + 16 - 1] = "ED - " + Strings.Format(i, "0#");
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[num4 + 16] = "ED - " + Strings.Format(i, "0#") + " reverso";
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[num4 + 16 - 1] = 21872 + num4 - 1;
					RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[num4 + 16] = 21872 + num4;
				}
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x002A9478 File Offset: 0x002A7878
		private void GeraDataGridView_ED()
		{
			this.DataGridView_RT820_ED.Columns.Clear();
			this.DataGridView_RT820_ED.CellBorderStyle = (System.Windows.Forms.BorderStyle)1;
			this.DataGridView_RT820_ED.DefaultCellStyle.Alignment = (System.Windows.Forms.HorizontalAlignment)64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_820_DataGrigViewEDColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewEDColunas);
						this.DataGridView_RT820_ED.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewEDColunas);
						this.DataGridView_RT820_ED.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 0);
				this.DataGridView_RT820_ED.RowCount = 8;
				this.DataGridView_RT820_ED.RowHeadersWidth = 80;
				int num2 = 1;
				try
				{
					foreach (object obj in this.DataGridView_RT820_ED.Rows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							dataGridViewRow.HeaderCell.Value = "ED " + Conversions.ToString(num2);
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

		// Token: 0x06000789 RID: 1929 RVA: 0x002A95B4 File Offset: 0x002A79B4
		private void InicializaEstrutura_DataGridView_ED()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewEDColunas[num].LinhasMenu = new string[32];
					RT_geral.RT_820_DataGrigViewEDColunas[num].LinhasValor = new int[32];
					num++;
				}
				while (num <= 0);
				RT_geral.RT_820_DataGrigViewEDColunas[0].TagColuna = "Entrada";
				RT_geral.RT_820_DataGrigViewEDColunas[0].NomeColuna = "Entrada";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LarguraColuna = 250;
				RT_geral.RT_820_DataGrigViewEDColunas[0].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[1] = 21904;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[2] = 21905;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[3] = 21906;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[4] = 21907;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[5] = 21908;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[6] = 21909;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[7] = 21910;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[8] = 21911;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[9] = 21912;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[10] = 21913;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[11] = 21914;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[12] = 21915;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[13] = 21916;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[14] = 21917;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[15] = 21918;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[16] = 21919;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[17] = 21920;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[18] = 21921;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[19] = 21922;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[20] = 21923;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[21] = 21924;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[22] = 21925;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[23] = 21926;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[24] = 21927;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[25] = 21928;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[26] = 21929;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[27] = 21931;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[28] = 21932;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[29] = 21933;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[30] = 21935;
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[0] = "--------";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[1] = "Retorno Motor1";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[2] = "Retorno Motor2";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[3] = "Retorno Motor3";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[4] = "Retorno Motor4";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[5] = "Monitoração de Arrombamento";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[6] = "Monitoração de Falta de Fase";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[7] = "Monitoração de Alagamento";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[8] = "Retorno de Fechamento de Válvula1";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[9] = "Retorno de Fechamento de Válvula2";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[10] = "Retorno de Fechamento de Válvula3";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[11] = "Retorno de Fechamento de Válvula4";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[12] = "Retorno de Abertura de Válvula1";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[13] = "Retorno de Abertura de Válvula2";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[14] = "Retorno de Abertura de Válvula3";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[15] = "Retorno de Abertura de Válvula4";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[16] = "Monitoramento de Vazão";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[17] = "Monitoramento de Horario de Ponta";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[18] = "Local / Remoto Motor1";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[19] = "Local / Remoto Motor2";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[20] = "Local / Remoto Motor3";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[21] = "Local / Remoto Motor4";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[22] = "Entrada VRP1";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[23] = "Entrada VRP2";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[24] = "Entrada VRP3";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[25] = "Entrada VRP4";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[26] = "Monitoração Vazão Pulso Invertido";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[27] = "Monitoramento Temperatura Motor1";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[28] = "Monitoramento Temperatura Motor2";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[29] = "Monitoramento Temperatura Motor3";
				RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[30] = "Monitoramento Temperatura Motor4";
				RT_geral.RT_820_DataGrigViewEDColunas[0].NumeroLinhaMenu = 31;
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x002A9C1C File Offset: 0x002A801C
		private void GeraDataGridView_Repedidora()
		{
			this.DataGridView_end_rep_RT820.Columns.Clear();
			this.DataGridView_end_rep_RT820.CellBorderStyle = (System.Windows.Forms.BorderStyle)1;
			this.DataGridView_end_rep_RT820.DefaultCellStyle.Alignment = (System.Windows.Forms.HorizontalAlignment)64;
			int num = 0;
			checked
			{
				do
				{
					if (RT_geral.RT_820_DataGrigViewRepetidoraColunas[num].NumeroLinhaMenu > 0)
					{
						DataGridViewComboBoxColumn dataGridViewComboBoxColumn = Linha_RT.CreateComboBoxColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewRepetidoraColunas);
						this.DataGridView_end_rep_RT820.Columns.Insert(num, dataGridViewComboBoxColumn);
					}
					else
					{
						DataGridViewTextBoxColumn dataGridViewTextBoxColumn = Linha_RT.CreateTextColumn(Conversions.ToString(num), ref RT_geral.RT_820_DataGrigViewRepetidoraColunas);
						this.DataGridView_end_rep_RT820.Columns.Insert(num, dataGridViewTextBoxColumn);
					}
					num++;
				}
				while (num <= 9);
				this.DataGridView_end_rep_RT820.RowCount = 10;
				num = 0;
				do
				{
					this.DataGridView_end_rep_RT820.Columns[num].ReadOnly = true;
					num++;
				}
				while (num <= 9);
				num = 0;
				do
				{
					this.DataGridView_end_rep_RT820[0, num].Value = num + 1;
					this.DataGridView_end_rep_RT820[2, num].Value = num + 11;
					this.DataGridView_end_rep_RT820[4, num].Value = num + 21;
					this.DataGridView_end_rep_RT820[6, num].Value = num + 31;
					this.DataGridView_end_rep_RT820[8, num].Value = num + 41;
					num++;
				}
				while (num <= 9);
			}
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x002A9D80 File Offset: 0x002A8180
		private void InicializaEstrutura_DataGridView_repetidora()
		{
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[0].TagColuna = "Posição";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[1].TagColuna = "Endereço";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[2].TagColuna = "Posição";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[3].TagColuna = "Endereço";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[4].TagColuna = "Posição";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[5].TagColuna = "Endereço";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[6].TagColuna = "Posição";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[7].TagColuna = "Endereço";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[8].TagColuna = "Posição";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[9].TagColuna = "Endereço";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[0].NomeColuna = "pos_1";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[1].NomeColuna = "end_1";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[2].NomeColuna = "pos_2";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[3].NomeColuna = "end_2";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[4].NomeColuna = "pos_3";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[5].NomeColuna = "end_3";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[6].NomeColuna = "pos_4";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[7].NomeColuna = "end_4";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[8].NomeColuna = "pos_5";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[9].NomeColuna = "end_5";
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[0].LarguraColuna = 50;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[1].LarguraColuna = 65;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[2].LarguraColuna = 50;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[3].LarguraColuna = 65;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[4].LarguraColuna = 50;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[5].LarguraColuna = 65;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[6].LarguraColuna = 50;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[7].LarguraColuna = 65;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[8].LarguraColuna = 50;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[9].LarguraColuna = 65;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[0].AlingColuna = 32;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[1].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[2].AlingColuna = 32;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[3].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[4].AlingColuna = 32;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[5].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[6].AlingColuna = 32;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[7].AlingColuna = 64;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[8].AlingColuna = 32;
			RT_geral.RT_820_DataGrigViewRepetidoraColunas[9].AlingColuna = 64;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x002AA0A0 File Offset: 0x002A84A0
		private void GeraDataGridView_Setpoints()
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x002AA0A4 File Offset: 0x002A84A4
		private void InicializaEstrutura_DataGridView_Setpoints()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewSetpointsColunas[num].LinhasMenu = new string[22];
					RT_geral.RT_820_DataGrigViewSetpointsColunas[num].LinhasValor = new int[22];
					num++;
				}
				while (num <= 5);
				RT_geral.RT_820_DataGrigViewSetpointsColunas[2].TagColuna = "Alto";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[1].TagColuna = "Baixo";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[4].TagColuna = "Bloqueio";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[5].TagColuna = "Liberação";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].TagColuna = "Variável Controle";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[3].TagColuna = "Variável Bloqueio";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[2].NomeColuna = "Set_NAlto";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[1].NomeColuna = "Set_NBaixo";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[4].NomeColuna = "Set_NBloq";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[5].NomeColuna = "Set_NLib";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].NomeColuna = "Set_Controle";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[3].NomeColuna = "Set_Bloqueio";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[2].LarguraColuna = 60;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[1].LarguraColuna = 60;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[4].LarguraColuna = 60;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[5].LarguraColuna = 60;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LarguraColuna = 160;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LarguraColuna = 160;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[2].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[1].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[4].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[5].AlingColuna = 64;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[3].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[2].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[1].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[4].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[5].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasMenu[0] = "Controle Desabilitado";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[0].NumeroLinhaMenu = 21;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasMenu[0] = "Bloqueio Desabilitado";
				RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasValor[0] = 21856;
				RT_geral.RT_820_DataGrigViewSetpointsColunas[3].NumeroLinhaMenu = 21;
				num = 1;
				do
				{
					RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasMenu[num] = "EA - " + Strings.Format(num, "0#");
					RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasValor[num] = 21856 + num;
					RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasMenu[num] = "EA - " + Strings.Format(num, "0#");
					RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasValor[num] = 21856 + num;
					num++;
				}
				while (num <= 16);
				num = 17;
				do
				{
					RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasMenu[num] = "Valor Referência " + Strings.Format(num - 16, "#");
					RT_geral.RT_820_DataGrigViewSetpointsColunas[0].LinhasValor[num] = 21856 + num;
					RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasMenu[num] = "Valor Referência " + Strings.Format(num - 16, "#");
					RT_geral.RT_820_DataGrigViewSetpointsColunas[3].LinhasValor[num] = 21856 + num;
					num++;
				}
				while (num <= 20);
			}
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x002AA4C0 File Offset: 0x002A88C0
		private void GeraDataGridView_Timer()
		{
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x002AA4C4 File Offset: 0x002A88C4
		private void InicializaEstrutura_DataGridView_Timer()
		{
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_DataGrigViewTimerColunas[num].LinhasMenu = new string[2];
					RT_geral.RT_820_DataGrigViewTimerColunas[num].LinhasValor = new int[2];
					num++;
				}
				while (num <= 12);
				RT_geral.RT_820_DataGrigViewTimerColunas[0].TagColuna = "Liga";
				RT_geral.RT_820_DataGrigViewTimerColunas[1].TagColuna = "Desliga";
				RT_geral.RT_820_DataGrigViewTimerColunas[2].TagColuna = "Liga";
				RT_geral.RT_820_DataGrigViewTimerColunas[3].TagColuna = "Desliga";
				RT_geral.RT_820_DataGrigViewTimerColunas[4].TagColuna = "Liga";
				RT_geral.RT_820_DataGrigViewTimerColunas[5].TagColuna = "Desliga";
				RT_geral.RT_820_DataGrigViewTimerColunas[6].TagColuna = "Liga";
				RT_geral.RT_820_DataGrigViewTimerColunas[7].TagColuna = "Desliga";
				RT_geral.RT_820_DataGrigViewTimerColunas[8].TagColuna = "Liga";
				RT_geral.RT_820_DataGrigViewTimerColunas[9].TagColuna = "Desliga";
				RT_geral.RT_820_DataGrigViewTimerColunas[10].TagColuna = "Liga";
				RT_geral.RT_820_DataGrigViewTimerColunas[11].TagColuna = "Desliga";
				RT_geral.RT_820_DataGrigViewTimerColunas[0].NomeColuna = "Liga_F1";
				RT_geral.RT_820_DataGrigViewTimerColunas[1].NomeColuna = "Desliga_F1";
				RT_geral.RT_820_DataGrigViewTimerColunas[2].NomeColuna = "Liga_F2";
				RT_geral.RT_820_DataGrigViewTimerColunas[3].NomeColuna = "Desliga_F2";
				RT_geral.RT_820_DataGrigViewTimerColunas[4].NomeColuna = "Liga_F3";
				RT_geral.RT_820_DataGrigViewTimerColunas[5].NomeColuna = "Desliga_F3";
				RT_geral.RT_820_DataGrigViewTimerColunas[6].NomeColuna = "Liga_F4";
				RT_geral.RT_820_DataGrigViewTimerColunas[7].NomeColuna = "Desliga_F4";
				RT_geral.RT_820_DataGrigViewTimerColunas[8].NomeColuna = "Liga_F5";
				RT_geral.RT_820_DataGrigViewTimerColunas[9].NomeColuna = "Desliga_F5";
				RT_geral.RT_820_DataGrigViewTimerColunas[10].NomeColuna = "Liga_F6";
				RT_geral.RT_820_DataGrigViewTimerColunas[11].NomeColuna = "Desliga_F6";
				RT_geral.RT_820_DataGrigViewTimerColunas[0].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[1].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[2].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[3].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[4].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[5].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[6].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[7].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[8].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[9].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[10].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[11].LarguraColuna = 58;
				RT_geral.RT_820_DataGrigViewTimerColunas[0].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[1].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[2].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[3].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[4].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[5].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[6].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[7].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[8].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[9].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[10].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[11].AlingColuna = 32;
				RT_geral.RT_820_DataGrigViewTimerColunas[0].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[1].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[2].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[3].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[4].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[5].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[6].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[7].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[8].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[9].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[10].NumeroLinhaMenu = 0;
				RT_geral.RT_820_DataGrigViewTimerColunas[11].NumeroLinhaMenu = 0;
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x002AA98C File Offset: 0x002A8D8C
		public void Inicializa_DadosEStruturaRT820_Padrao()
		{
			RT_geral.RT_820_200_BD.firmware.Versao.nome = "Versão";
			RT_geral.RT_820_200_BD.firmware.Versao.Padrao = 2;
			RT_geral.RT_820_200_BD.firmware.Build.nome = "Build";
			RT_geral.RT_820_200_BD.firmware.Build.Padrao = 0;
			RT_geral.RT_820_200_BD.firmware.Release.nome = "Release";
			RT_geral.RT_820_200_BD.firmware.Release.Padrao = 0;
			RT_geral.RT_820_200_BD.firmware.Equip.nome = "Tipo equipamento";
			RT_geral.RT_820_200_BD.firmware.Equip.Padrao = 820;
			RT_geral.RT_820_200_BD.cfg_geral.End_estacao.nome = "Endereço Estação";
			RT_geral.RT_820_200_BD.cfg_geral.End_estacao.Padrao = 1;
			RT_geral.RT_820_200_BD.cfg_geral.End_estacao.Lmte_inf = 0;
			RT_geral.RT_820_200_BD.cfg_geral.End_estacao.Lmte_sup = 200;
			RT_geral.RT_820_200_BD.cfg_geral.End_mestre.nome = "Endereço Mestre";
			RT_geral.RT_820_200_BD.cfg_geral.End_mestre.Padrao = 100;
			RT_geral.RT_820_200_BD.cfg_geral.End_mestre.Lmte_inf = 1;
			RT_geral.RT_820_200_BD.cfg_geral.End_mestre.Lmte_sup = 200;
			RT_geral.RT_820_200_BD.cfg_geral.Tempo_ptt.nome = "Tempo PTT";
			RT_geral.RT_820_200_BD.cfg_geral.Tempo_ptt.Padrao = 200;
			RT_geral.RT_820_200_BD.cfg_geral.Tempo_ptt.Lmte_inf = 100;
			RT_geral.RT_820_200_BD.cfg_geral.Tempo_ptt.Lmte_sup = 2000;
			RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.nome = "Baudrate COM2";
			RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.Indice_padrao = 0;
			RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.Numero_itens = 2;
			RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.valores[0] = 21849;
			RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.valores[1] = 21850;
			RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.itens[0] = "1200 bauds";
			RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.itens[1] = "9600 bauds";
			RT_geral.RT_820_200_BD.cfg_geral.AD_Intervalo.nome = "Intervalo AD";
			RT_geral.RT_820_200_BD.cfg_geral.AD_Intervalo.Padrao = 2000;
			RT_geral.RT_820_200_BD.cfg_geral.AD_Intervalo.Lmte_inf = 10;
			RT_geral.RT_820_200_BD.cfg_geral.AD_Intervalo.Lmte_sup = 20000;
			RT_geral.RT_820_200_BD.cfg_geral.AD_Tamanho_filtro.nome = "Tamanho Filtro AD";
			RT_geral.RT_820_200_BD.cfg_geral.AD_Tamanho_filtro.Padrao = 3;
			RT_geral.RT_820_200_BD.cfg_geral.AD_Tamanho_filtro.Lmte_inf = 1;
			RT_geral.RT_820_200_BD.cfg_geral.AD_Tamanho_filtro.Lmte_sup = 10;
			RT_geral.RT_820_200_BD.cfg_geral.nivel_fonte.nome = "Nível Fonte";
			RT_geral.RT_820_200_BD.cfg_geral.nivel_fonte.Padrao = 768;
			RT_geral.RT_820_200_BD.cfg_geral.nivel_fonte.Lmte_sup = 853;
			RT_geral.RT_820_200_BD.cfg_geral.nivel_fonte.Lmte_inf = 768;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.nome = "Proteção";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.Numero_itens = 18;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.Indice_padrao = 0;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[0] = "EA 01";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[1] = "EA 02";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[2] = "EA 03";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[3] = "EA 04";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[4] = "EA 05";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[5] = "EA 06";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[6] = "EA 07";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[7] = "EA 08";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[8] = "EA 09";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[9] = "EA 10";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[10] = "EA 11";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[11] = "EA 12";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[12] = "EA 13";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[13] = "EA 14";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[14] = "EA 15";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[15] = "EA 16";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[16] = "Comunicação Destino";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.itens[17] = "Comunicação Origem";
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[0] = 21856;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[1] = 21857;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[2] = 21858;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[3] = 21859;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[4] = 21860;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[5] = 21861;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[6] = 21862;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[7] = 21863;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[8] = 21864;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[9] = 21865;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[10] = 21866;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[11] = 21867;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[12] = 21868;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[13] = 21869;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[14] = 21870;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[15] = 21871;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[16] = 21872;
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.valores[17] = 21873;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.nome = "Controle";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.Numero_itens = 18;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.Indice_padrao = 0;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[0] = "EA 01";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[1] = "EA 02";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[2] = "EA 03";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[3] = "EA 04";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[4] = "EA 05";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[5] = "EA 06";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[6] = "EA 07";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[7] = "EA 08";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[8] = "EA 09";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[9] = "EA 10";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[10] = "EA 11";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[11] = "EA 12";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[12] = "EA 13";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[13] = "EA 14";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[14] = "EA 15";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[15] = "EA 16";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[16] = "Comunicação Destino";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.itens[17] = "Comunicação Origem";
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[0] = 21856;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[1] = 21857;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[2] = 21858;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[3] = 21859;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[4] = 21860;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[5] = 21861;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[6] = 21862;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[7] = 21863;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[8] = 21864;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[9] = 21865;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[10] = 21866;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[11] = 21867;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[12] = 21868;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[13] = 21869;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[14] = 21870;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[15] = 21871;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[16] = 21872;
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.valores[17] = 21873;
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].nome = "ED " + Conversion.Str(num + 1);
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].Indice_padrao = 0;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].Numero_itens = 31;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens = new string[RT_geral.RT_820_200_BD.cfg_geral.entradas[num].Numero_itens + 1];
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores = new int[RT_geral.RT_820_200_BD.cfg_geral.entradas[num].Numero_itens + 1];
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[0] = "--------";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[1] = "Retorno Motor1";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[2] = "Retorno Motor2";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[3] = "Retorno Motor3";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[4] = "Retorno Motor4";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[5] = "Monitoração de Arrombamento";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[6] = "Monitoração de Falta de Fase";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[7] = "Monitoração de Alagamento";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[8] = "Retorno de Fechamento de Válvula1";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[9] = "Retorno de Fechamento de Válvula2";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[10] = "Retorno de Fechamento de Válvula3";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[11] = "Retorno de Fechamento de Válvula4";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[12] = "Retorno de Abertura de Válvula1";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[13] = "Retorno de Abertura de Válvula2";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[14] = "Retorno de Abertura de Válvula3";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[15] = "Retorno de Abertura de Válvula4";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[16] = "Monitoramento de Vazão";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[17] = "Monitoramento de Horario de Ponta";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[18] = "Local / Remoto Motor1";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[19] = "Local / Remoto Motor2";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[20] = "Local / Remoto Motor3";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[21] = "Local / Remoto Motor4";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[22] = "Entrada VRP1";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[23] = "Entrada VRP2";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[24] = "Entrada VRP3";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[25] = "Entrada VRP4";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[26] = "Monitoração Vazão Pulso Invertido";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[27] = "Monitoramento Temperatura Motor1";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[28] = "Monitoramento Temperatura Motor2";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[29] = "Monitoramento Temperatura Motor3";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].itens[30] = "Monitoramento Temperatura Motor4";
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[0] = 21856;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[1] = 21904;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[2] = 21905;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[3] = 21906;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[4] = 21907;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[5] = 21908;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[6] = 21909;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[7] = 21910;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[8] = 21911;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[9] = 21912;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[10] = 21913;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[11] = 21914;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[12] = 21915;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[13] = 21916;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[14] = 21917;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[15] = 21918;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[16] = 21919;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[17] = 21920;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[18] = 21921;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[19] = 21922;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[20] = 21923;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[21] = 21924;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[22] = 21929;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[23] = 21930;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[24] = 21931;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[25] = 21932;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[26] = 21933;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[27] = 21934;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[28] = 21935;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[29] = 21936;
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].valores[30] = 21937;
					num++;
				}
				while (num <= 7);
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Alto.nome = "M1 Alto";
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Alto.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Alto.Lmte_sup = 4000;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Alto.Padrao = 4000;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Baixo.nome = "M1 Baixo";
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Baixo.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Baixo.Lmte_sup = 4000;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Baixo.Padrao = 2400;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Alto.nome = "M2 Alto";
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Alto.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Alto.Lmte_sup = 4000;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Alto.Padrao = 4000;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Baixo.nome = "M2 Baixo";
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Baixo.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Baixo.Lmte_sup = 4000;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Baixo.Padrao = 2400;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Alto.nome = "M3 Alto";
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Alto.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Alto.Lmte_sup = 4000;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Alto.Padrao = 4000;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Baixo.nome = "M3 Baixo";
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Baixo.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Baixo.Lmte_sup = 4000;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Baixo.Padrao = 2400;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Alto.nome = "M4 Alto";
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Alto.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Alto.Lmte_sup = 4000;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Alto.Padrao = 4000;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Baixo.nome = "M4 Baixo";
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Baixo.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Baixo.Lmte_sup = 4000;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Baixo.Padrao = 2400;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Desliga.nome = "Proteção Desliga";
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Desliga.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Desliga.Lmte_sup = 4000;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Desliga.Padrao = 800;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Liga.nome = "Proteção Liga";
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Liga.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Liga.Lmte_sup = 4000;
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Liga.Padrao = 1600;
				num = 0;
				do
				{
					RT_geral.RT_820_200_BD.setpoint_horario[num].Hora.nome = "Hora";
					RT_geral.RT_820_200_BD.setpoint_horario[num].Hora.Padrao = 0;
					RT_geral.RT_820_200_BD.setpoint_horario[num].Hora.Lmte_inf = 0;
					RT_geral.RT_820_200_BD.setpoint_horario[num].Hora.Lmte_sup = 23;
					RT_geral.RT_820_200_BD.setpoint_horario[num].Minuto.nome = "Minuto";
					RT_geral.RT_820_200_BD.setpoint_horario[num].Minuto.Padrao = 0;
					RT_geral.RT_820_200_BD.setpoint_horario[num].Minuto.Lmte_inf = 0;
					RT_geral.RT_820_200_BD.setpoint_horario[num].Minuto.Lmte_sup = 59;
					RT_geral.RT_820_200_BD.setpoint_horario[num].Baixo.nome = "Baixo";
					RT_geral.RT_820_200_BD.setpoint_horario[num].Baixo.Padrao = 0;
					RT_geral.RT_820_200_BD.setpoint_horario[num].Baixo.Lmte_inf = 0;
					RT_geral.RT_820_200_BD.setpoint_horario[num].Baixo.Lmte_sup = 4000;
					RT_geral.RT_820_200_BD.setpoint_horario[num].Alto.nome = "Alto";
					RT_geral.RT_820_200_BD.setpoint_horario[num].Alto.Padrao = 4000;
					RT_geral.RT_820_200_BD.setpoint_horario[num].Alto.Lmte_inf = 0;
					RT_geral.RT_820_200_BD.setpoint_horario[num].Alto.Lmte_sup = 4000;
					num++;
				}
				while (num <= 7);
				this.sph_ativa10.Checked = false;
				this.sph_ativa11.Checked = false;
				this.sph_ativa20.Checked = false;
				this.sph_ativa21.Checked = false;
				this.sph_ativa30.Checked = false;
				this.sph_ativa31.Checked = false;
				this.sph_ativa40.Checked = false;
				this.sph_ativa41.Checked = false;
				RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.nome = "Modo de Operação";
				RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.Numero_itens = 5;
				RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.Indice_padrao = 0;
				RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.itens[0] = "Manual";
				RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.itens[1] = "Automático";
				RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.itens[2] = "Timer";
				RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.itens[3] = "Automático sem desligar por falha";
				RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.itens[4] = "Manual sem desligar por falha";
				RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.valores[0] = 21888;
				RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.valores[1] = 21889;
				RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.valores[2] = 21890;
				RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.valores[3] = 21891;
				RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.valores[4] = 21892;
				RT_geral.RT_820_200_BD.cfg_geral.quantidade_motores.nome = "Número de Motores";
				RT_geral.RT_820_200_BD.cfg_geral.quantidade_motores.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.quantidade_motores.Lmte_sup = 4;
				RT_geral.RT_820_200_BD.cfg_geral.quantidade_motores.Padrao = 0;
				RT_geral.RT_820_200_BD.cfg_geral.quantidade_valvulas.nome = "Número de Válvulas";
				RT_geral.RT_820_200_BD.cfg_geral.quantidade_valvulas.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.quantidade_valvulas.Lmte_sup = 4;
				RT_geral.RT_820_200_BD.cfg_geral.quantidade_valvulas.Padrao = 0;
				RT_geral.RT_820_200_BD.cfg_geral.bombas_simultaneas.nome = "Bombas simultâneas";
				RT_geral.RT_820_200_BD.cfg_geral.bombas_simultaneas.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.bombas_simultaneas.Lmte_sup = 4;
				RT_geral.RT_820_200_BD.cfg_geral.bombas_simultaneas.Padrao = 0;
				RT_geral.RT_820_200_BD.cfg_geral.tempo_acionamentos.nome = "Tempo entre acionamentos";
				RT_geral.RT_820_200_BD.cfg_geral.tempo_acionamentos.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.tempo_acionamentos.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.tempo_acionamentos.Padrao = 0;
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula1.nome = "Tempo abertura Válvula1";
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula1.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula1.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula1.Padrao = 180;
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula2.nome = "Tempo abertura Válvula2";
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula2.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula2.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula2.Padrao = 180;
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula3.nome = "Tempo abertura Válvula3";
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula3.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula3.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula3.Padrao = 180;
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula4.nome = "Tempo abertura Válvula4";
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula4.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula4.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula4.Padrao = 180;
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula1.nome = "Tempo fechamento Válvula1";
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula1.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula1.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula1.Padrao = 180;
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula2.nome = "Tempo fechamento Válvula2";
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula2.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula2.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula2.Padrao = 180;
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula3.nome = "Tempo fechamento Válvula3";
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula3.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula3.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula3.Padrao = 180;
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula4.nome = "Tempo fechamento Válvula4";
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula4.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula4.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula4.Padrao = 180;
				num = 0;
				do
				{
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].nome = "Modo de Partida Motor" + (num + 1).ToString();
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].Numero_itens = 25;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].Indice_padrao = 0;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[0] = "Desativo";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[1] = "SD 1";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[2] = "SD 2";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[3] = "SD 3";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[4] = "SD 4";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[5] = "SD 5";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[6] = "SD 6";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[7] = "SD 7";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[8] = "SD 8";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[9] = "SD 1 - Reverso";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[10] = "SD 2 - Reverso";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[11] = "SD 3 - Reverso";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[12] = "SD 4 - Reverso";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[13] = "SD 5 - Reverso";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[14] = "SD 6 - Reverso";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[15] = "SD 7 - Reverso";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[16] = "SD 8 - Reverso";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[17] = "Periférico 1";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[18] = "Periférico 2";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[19] = "Periférico 3";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[20] = "Periférico 4";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[21] = "Periférico 1 - Reverso";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[22] = "Periférico 2 - Reverso";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[23] = "Periférico 3 - Reverso";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].itens[24] = "Periférico 4 - Reverso";
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[0] = 21856;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[1] = 21857;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[2] = 21858;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[3] = 21859;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[4] = 21860;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[5] = 21861;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[6] = 21862;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[7] = 21863;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[8] = 21864;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[9] = 21865;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[10] = 21866;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[11] = 21867;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[12] = 21868;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[13] = 21869;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[14] = 21870;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[15] = 21871;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[16] = 21872;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[17] = 21873;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[18] = 21874;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[19] = 21875;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[20] = 21876;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[21] = 21877;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[22] = 21878;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[23] = 21879;
					RT_geral.RT_820_200_BD.cfg_geral.modo_partida[num].valores[24] = 21880;
					num++;
				}
				while (num <= 3);
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor1.nome = "Tempo partida Motor1";
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor1.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor1.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor1.Padrao = 180;
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor2.nome = "Tempo partida Motor2";
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor2.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor2.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor2.Padrao = 180;
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor3.nome = "Tempo partida Motor3";
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor3.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor3.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor3.Padrao = 180;
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor4.nome = "Tempo partida Motor4";
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor4.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor4.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor4.Padrao = 180;
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor1.nome = "Tempo parada Motor1";
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor1.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor1.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor1.Padrao = 180;
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor2.nome = "Tempo parada Motor2";
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor2.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor2.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor2.Padrao = 180;
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor3.nome = "Tempo parada Motor3";
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor3.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor3.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor3.Padrao = 180;
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor4.nome = "Tempo parada Motor4";
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor4.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor4.Lmte_sup = 32000;
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor4.Padrao = 180;
				num = 0;
				do
				{
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].End_Quant.nome = "End / Quantidade Periférico " + Conversion.Str(num + 1);
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].End_Quant.Lmte_inf = 0;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].End_Quant.Lmte_sup = 255;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].End_Quant.Valor = 0;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.nome = "Periférico " + Conversion.Str(num + 1);
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.Numero_itens = 19;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.Indice_padrao = 0;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[0] = "Periferico Desabilitado";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[1] = "Ictel GC420";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[2] = "Leitura de Vazão Interna";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[3] = "Equipamento de Leitura de Vazão";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[4] = "Multimedidor IMS - Smart Trans";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[5] = "Multimedidor KRON - Mult K";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[6] = "Inversor Danfoss - VLT";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[7] = "Multimedidor Siemens - PAC3200";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[8] = "Inversor WEG - CFW09";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[9] = "Sofstarter WEG - SSW07";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[10] = "Inversor ELO - 2148";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[11] = "Medidor Cloro - AquaChlor";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[12] = "Inversor WEG - CFW11";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[13] = "Inversor WEG - CFW11 - B";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[14] = "Controlador PEXTRON";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[15] = "Multimedidor SCHNEIDER - PM710";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[16] = "Inversor SCHNEIDER - Altivar71";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[17] = "Multimedidor SCHNEIDER - PM1200";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.itens[18] = "STEMAC - ST2160";
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[0] = 48;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[1] = 49;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[2] = 50;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[3] = 51;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[4] = 52;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[5] = 53;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[6] = 54;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[7] = 55;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[8] = 56;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[9] = 57;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[10] = 58;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[11] = 59;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[12] = 60;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[13] = 61;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[14] = 62;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[15] = 63;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[16] = 64;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[17] = 65;
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.valores[18] = 66;
					num++;
				}
				while (num <= 3);
				RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.nome = "Modo Repetição";
				RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.Numero_itens = 2;
				RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.Indice_padrao = 0;
				RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.valores[0] = 0;
				RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.valores[1] = 21856;
				RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.itens[0] = "Função Desabilitada";
				RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.itens[1] = "Repetidora Direta";
				RT_geral.RT_820_200_BD.repetidora.End_repetidora.nome = "Endereço Repetidora";
				RT_geral.RT_820_200_BD.repetidora.End_repetidora.Padrao = 1;
				RT_geral.RT_820_200_BD.repetidora.End_repetidora.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.repetidora.End_repetidora.Lmte_sup = 200;
				RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.nome = "Número de Repetidoras";
				RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.Padrao = 0;
				RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.Lmte_inf = 0;
				RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.Lmte_sup = 50;
				num = 0;
				do
				{
					RT_geral.RT_820_200_BD.repetidora.Repetidoras[num].nome = "Endereço da Repetidora " + Conversion.Str(num + 1);
					RT_geral.RT_820_200_BD.repetidora.Repetidoras[num].Padrao = 0;
					RT_geral.RT_820_200_BD.repetidora.Repetidoras[num].Lmte_inf = 0;
					RT_geral.RT_820_200_BD.repetidora.Repetidoras[num].Lmte_sup = 200;
					num++;
				}
				while (num <= 49);
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x002ADEE4 File Offset: 0x002AC2E4
		public void Inicializa_DadosEStruturaRT820_Default()
		{
			RT_geral.RT_820_200_BD.firmware.Equip.ValorPadrao();
			RT_geral.RT_820_200_BD.firmware.Build.ValorPadrao();
			RT_geral.RT_820_200_BD.firmware.Versao.ValorPadrao();
			RT_geral.RT_820_200_BD.firmware.Release.ValorPadrao();
			RT_geral.RT_820_200_BD.cfg_geral.End_estacao.ValorPadrao();
			RT_geral.RT_820_200_BD.cfg_geral.End_mestre.ValorPadrao();
			RT_geral.RT_820_200_BD.cfg_geral.Tempo_ptt.ValorPadrao();
			RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.IndicePadrao();
			this.TextBox_comentarios_RT820.Text = "";
			this.TextBox_endereco_RT820.Text = "";
			this.TextBox_nome_RT820.Text = "";
			RT_geral.RT_820_200_BD.cfg_geral.AD_Intervalo.ValorPadrao();
			RT_geral.RT_820_200_BD.cfg_geral.AD_Tamanho_filtro.ValorPadrao();
			RT_geral.RT_820_200_BD.cfg_geral.nivel_fonte.ValorPadrao();
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.IndicePadrao();
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.IndicePadrao();
			int num = 0;
			checked
			{
				do
				{
					RT_geral.RT_820_200_BD.cfg_geral.entradas[num].IndicePadrao();
					num++;
				}
				while (num <= 7);
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Alto.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Baixo.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Alto.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Baixo.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Alto.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Baixo.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Alto.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Baixo.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Desliga.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Liga.ValorPadrao();
				num = 0;
				do
				{
					RT_geral.RT_820_200_BD.setpoint_horario[num].Hora.ValorPadrao();
					RT_geral.RT_820_200_BD.setpoint_horario[num].Minuto.ValorPadrao();
					RT_geral.RT_820_200_BD.setpoint_horario[num].Alto.ValorPadrao();
					RT_geral.RT_820_200_BD.setpoint_horario[num].Baixo.ValorPadrao();
					num++;
				}
				while (num <= 7);
				RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.IndicePadrao();
				RT_geral.RT_820_200_BD.cfg_geral.quantidade_motores.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.quantidade_valvulas.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.bombas_simultaneas.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula1.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula2.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula3.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula4.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula1.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula2.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula3.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula4.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.modo_partida[0].IndicePadrao();
				RT_geral.RT_820_200_BD.cfg_geral.modo_partida[1].IndicePadrao();
				RT_geral.RT_820_200_BD.cfg_geral.modo_partida[2].IndicePadrao();
				RT_geral.RT_820_200_BD.cfg_geral.modo_partida[3].IndicePadrao();
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor1.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor2.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor3.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.partida.Motor4.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor1.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor2.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor3.ValorPadrao();
				RT_geral.RT_820_200_BD.cfg_geral.parada.Motor4.ValorPadrao();
				num = 0;
				do
				{
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].End_Quant.ValorPadrao();
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[num].Equipamento.IndicePadrao();
					num++;
				}
				while (num <= 3);
				RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.IndicePadrao();
				RT_geral.RT_820_200_BD.repetidora.End_repetidora.ValorPadrao();
				RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.ValorPadrao();
				num = 0;
				do
				{
					RT_geral.RT_820_200_BD.repetidora.Repetidoras[num].ValorPadrao();
					num++;
				}
				while (num <= 49);
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x002AE4A8 File Offset: 0x002AC8A8
		public void Atualiza_TelaRT820()
		{
			checked
			{
				int num;
				int num7;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					string text = "Geral";
					this.TextBox_versao_820.Text = Conversions.ToString(RT_geral.RT_820_200_BD.firmware.Versao.Valor);
					this.TextBox_build_820.Text = Conversions.ToString(RT_geral.RT_820_200_BD.firmware.Build.Valor);
					this.TextBox_release_820.Text = Conversions.ToString(RT_geral.RT_820_200_BD.firmware.Release.Valor);
					this.TextBox_equipamento_820.Text = Conversions.ToString(RT_geral.RT_820_200_BD.firmware.Equip.Valor);
					this.NumericUpDown_end_est_820.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.End_estacao.Valor);
					this.NumericUpDown_end_mestre_820.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.End_mestre.Valor);
					this.NumericUpDown_temp_ptt_820.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.Tempo_ptt.Valor);
					this.ComboBox_baudrate_COM2_820.SelectedIndex = RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.Indice;
					text = "EA";
					this.NumericUpDown_intervalo_filtro_820.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.AD_Intervalo.Valor);
					this.NumericUpDown_tamanho_filtro_820.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.AD_Tamanho_filtro.Valor);
					text = "Controle";
					if (RT_geral.RT_820_200_BD.cfg_geral.nivel_fonte.Valor == 0)
					{
						this.checkbox_habilita_controle.Checked = false;
					}
					else if (RT_geral.RT_820_200_BD.cfg_geral.nivel_fonte.Valor == 21921)
					{
						this.checkbox_habilita_controle.Checked = true;
					}
					this.cb_Protecao.Enabled = this.checkbox_habilita_controle.Checked;
					this.cb_Protecao.SelectedIndex = RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.Indice;
					this.cb_Controle.SelectedIndex = RT_geral.RT_820_200_BD.cfg_geral.origem_controle.Indice;
					text = "ED";
					int num2 = 0;
					do
					{
						string value = RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasMenu[RT_geral.RT_820_200_BD.cfg_geral.entradas[num2].Indice];
						this.DataGridView_RT820_ED.Rows[num2].Cells[0].Value = value;
						num2++;
					}
					while (num2 <= 7);
					text = "SetPoint";
					this.nud_motor1_alto.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Alto.Valor);
					this.nud_motor1_baixo.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Baixo.Valor);
					this.nud_motor2_alto.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Alto.Valor);
					this.nud_motor2_baixo.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Baixo.Valor);
					this.nud_motor3_alto.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Alto.Valor);
					this.nud_motor3_baixo.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Baixo.Valor);
					this.nud_motor4_alto.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Alto.Valor);
					this.nud_motor4_baixo.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Baixo.Valor);
					this.nud_protecao_desliga.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Desliga.Valor);
					this.nud_protecao_liga.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Liga.Valor);
					text = "SetPoint por horario";
					this.sph_ativa10.Checked = ((RT_geral.RT_820_200_BD.setpoint_horario[0].Hora.Valor & 128) > 0);
					int num3 = RT_geral.RT_820_200_BD.setpoint_horario[0].Hora.Valor & 127;
					int num4 = RT_geral.RT_820_200_BD.setpoint_horario[0].Minuto.Valor;
					int num5 = RT_geral.RT_820_200_BD.setpoint_horario[0].Alto.Valor;
					int num6 = RT_geral.RT_820_200_BD.setpoint_horario[0].Baixo.Valor;
					if (num3 > 23)
					{
						num3 = 23;
					}
					if (num4 > 59)
					{
						num4 = 59;
					}
					if (num5 > 4000)
					{
						num5 = 4000;
					}
					if (num6 > 4000)
					{
						num6 = 4000;
					}
					this.sph_hora10.Value = new decimal(num3);
					this.sph_minuto10.Value = new decimal(num4);
					this.sph_alto10.Value = new decimal(num5);
					this.sph_baixo10.Value = new decimal(num6);
					this.sph_ativa11.Checked = ((RT_geral.RT_820_200_BD.setpoint_horario[1].Hora.Valor & 128) > 0);
					num3 = (RT_geral.RT_820_200_BD.setpoint_horario[1].Hora.Valor & 127);
					num4 = RT_geral.RT_820_200_BD.setpoint_horario[1].Minuto.Valor;
					num5 = RT_geral.RT_820_200_BD.setpoint_horario[1].Alto.Valor;
					num6 = RT_geral.RT_820_200_BD.setpoint_horario[1].Baixo.Valor;
					if (num3 > 23)
					{
						num3 = 23;
					}
					if (num4 > 59)
					{
						num4 = 59;
					}
					if (num5 > 4000)
					{
						num5 = 4000;
					}
					if (num6 > 4000)
					{
						num6 = 4000;
					}
					this.sph_hora11.Value = new decimal(num3);
					this.sph_minuto11.Value = new decimal(num4);
					this.sph_alto11.Value = new decimal(num5);
					this.sph_baixo11.Value = new decimal(num6);
					this.sph_ativa20.Checked = ((RT_geral.RT_820_200_BD.setpoint_horario[2].Hora.Valor & 128) > 0);
					num3 = (RT_geral.RT_820_200_BD.setpoint_horario[2].Hora.Valor & 127);
					num4 = RT_geral.RT_820_200_BD.setpoint_horario[2].Minuto.Valor;
					num5 = RT_geral.RT_820_200_BD.setpoint_horario[2].Alto.Valor;
					num6 = RT_geral.RT_820_200_BD.setpoint_horario[2].Baixo.Valor;
					if (num3 > 23)
					{
						num3 = 23;
					}
					if (num4 > 59)
					{
						num4 = 59;
					}
					if (num5 > 4000)
					{
						num5 = 4000;
					}
					if (num6 > 4000)
					{
						num6 = 4000;
					}
					this.sph_hora20.Value = new decimal(num3);
					this.sph_minuto20.Value = new decimal(num4);
					this.sph_alto20.Value = new decimal(num5);
					this.sph_baixo20.Value = new decimal(num6);
					this.sph_ativa21.Checked = ((RT_geral.RT_820_200_BD.setpoint_horario[3].Hora.Valor & 128) > 0);
					num3 = (RT_geral.RT_820_200_BD.setpoint_horario[3].Hora.Valor & 127);
					num4 = RT_geral.RT_820_200_BD.setpoint_horario[3].Minuto.Valor;
					num5 = RT_geral.RT_820_200_BD.setpoint_horario[3].Alto.Valor;
					num6 = RT_geral.RT_820_200_BD.setpoint_horario[3].Baixo.Valor;
					if (num3 > 23)
					{
						num3 = 23;
					}
					if (num4 > 59)
					{
						num4 = 59;
					}
					if (num5 > 4000)
					{
						num5 = 4000;
					}
					if (num6 > 4000)
					{
						num6 = 4000;
					}
					this.sph_hora21.Value = new decimal(num3);
					this.sph_minuto21.Value = new decimal(num4);
					this.sph_alto21.Value = new decimal(num5);
					this.sph_baixo21.Value = new decimal(num6);
					this.sph_ativa30.Checked = ((RT_geral.RT_820_200_BD.setpoint_horario[4].Hora.Valor & 128) > 0);
					num3 = (RT_geral.RT_820_200_BD.setpoint_horario[4].Hora.Valor & 127);
					num4 = RT_geral.RT_820_200_BD.setpoint_horario[4].Minuto.Valor;
					num5 = RT_geral.RT_820_200_BD.setpoint_horario[4].Alto.Valor;
					num6 = RT_geral.RT_820_200_BD.setpoint_horario[4].Baixo.Valor;
					if (num3 > 23)
					{
						num3 = 23;
					}
					if (num4 > 59)
					{
						num4 = 59;
					}
					if (num5 > 4000)
					{
						num5 = 4000;
					}
					if (num6 > 4000)
					{
						num6 = 4000;
					}
					this.sph_hora30.Value = new decimal(num3);
					this.sph_minuto30.Value = new decimal(num4);
					this.sph_alto30.Value = new decimal(num5);
					this.sph_baixo30.Value = new decimal(num6);
					this.sph_ativa31.Checked = ((RT_geral.RT_820_200_BD.setpoint_horario[5].Hora.Valor & 128) > 0);
					num3 = (RT_geral.RT_820_200_BD.setpoint_horario[5].Hora.Valor & 127);
					num4 = RT_geral.RT_820_200_BD.setpoint_horario[5].Minuto.Valor;
					num5 = RT_geral.RT_820_200_BD.setpoint_horario[5].Alto.Valor;
					num6 = RT_geral.RT_820_200_BD.setpoint_horario[5].Baixo.Valor;
					if (num3 > 23)
					{
						num3 = 23;
					}
					if (num4 > 59)
					{
						num4 = 59;
					}
					if (num5 > 4000)
					{
						num5 = 4000;
					}
					if (num6 > 4000)
					{
						num6 = 4000;
					}
					this.sph_hora31.Value = new decimal(num3);
					this.sph_minuto31.Value = new decimal(num4);
					this.sph_alto31.Value = new decimal(num5);
					this.sph_baixo31.Value = new decimal(num6);
					this.sph_ativa40.Checked = ((RT_geral.RT_820_200_BD.setpoint_horario[6].Hora.Valor & 128) > 0);
					num3 = (RT_geral.RT_820_200_BD.setpoint_horario[6].Hora.Valor & 127);
					num4 = RT_geral.RT_820_200_BD.setpoint_horario[6].Minuto.Valor;
					num5 = RT_geral.RT_820_200_BD.setpoint_horario[6].Alto.Valor;
					num6 = RT_geral.RT_820_200_BD.setpoint_horario[6].Baixo.Valor;
					if (num3 > 23)
					{
						num3 = 23;
					}
					if (num4 > 59)
					{
						num4 = 59;
					}
					if (num5 > 4000)
					{
						num5 = 4000;
					}
					if (num6 > 4000)
					{
						num6 = 4000;
					}
					this.sph_hora40.Value = new decimal(num3);
					this.sph_minuto40.Value = new decimal(num4);
					this.sph_alto40.Value = new decimal(num5);
					this.sph_baixo40.Value = new decimal(num6);
					this.sph_ativa41.Checked = ((RT_geral.RT_820_200_BD.setpoint_horario[7].Hora.Valor & 128) > 0);
					num3 = (RT_geral.RT_820_200_BD.setpoint_horario[7].Hora.Valor & 127);
					num4 = RT_geral.RT_820_200_BD.setpoint_horario[7].Minuto.Valor;
					num5 = RT_geral.RT_820_200_BD.setpoint_horario[7].Alto.Valor;
					num6 = RT_geral.RT_820_200_BD.setpoint_horario[7].Baixo.Valor;
					if (num3 > 23)
					{
						num3 = 23;
					}
					if (num4 > 59)
					{
						num4 = 59;
					}
					if (num5 > 4000)
					{
						num5 = 4000;
					}
					if (num6 > 4000)
					{
						num6 = 4000;
					}
					this.sph_hora41.Value = new decimal(num3);
					this.sph_minuto41.Value = new decimal(num4);
					this.sph_alto41.Value = new decimal(num5);
					this.sph_baixo41.Value = new decimal(num6);
					text = "Motores e Válvulas";
					this.cb_modo_operacao.SelectedIndex = RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.Indice;
					this.nud_numero_motores.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.quantidade_motores.Valor);
					this.nud_numero_valvulas.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.quantidade_valvulas.Valor);
					this.nud_bombas_simultaneas.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.bombas_simultaneas.Valor);
					this.nud_tempo_operacoes.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.tempo_acionamentos.Valor);
					this.nud_valvula1_abertura.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula1.Valor);
					this.nud_valvula2_abertura.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula2.Valor);
					this.nud_valvula3_abertura.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula3.Valor);
					this.nud_valvula4_abertura.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula4.Valor);
					this.nud_valvula1_fechamento.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula1.Valor);
					this.nud_valvula2_fechamento.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula2.Valor);
					this.nud_valvula3_fechamento.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula3.Valor);
					this.nud_valvula4_fechamento.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula4.Valor);
					this.cb_modo_partida1.SelectedIndex = RT_geral.RT_820_200_BD.cfg_geral.modo_partida[0].Indice;
					this.cb_modo_partida2.SelectedIndex = RT_geral.RT_820_200_BD.cfg_geral.modo_partida[1].Indice;
					this.cb_modo_partida3.SelectedIndex = RT_geral.RT_820_200_BD.cfg_geral.modo_partida[2].Indice;
					this.cb_modo_partida4.SelectedIndex = RT_geral.RT_820_200_BD.cfg_geral.modo_partida[3].Indice;
					this.nud_partida1.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.partida.Motor1.Valor);
					this.nud_partida2.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.partida.Motor2.Valor);
					this.nud_partida3.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.partida.Motor3.Valor);
					this.nud_partida4.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.partida.Motor4.Valor);
					this.nud_parada1.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.parada.Motor1.Valor);
					this.nud_parada2.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.parada.Motor2.Valor);
					this.nud_parada3.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.parada.Motor3.Valor);
					this.nud_parada4.Value = new decimal(RT_geral.RT_820_200_BD.cfg_geral.parada.Motor4.Valor);
					text = "Periféricos";
					num2 = 0;
					do
					{
						string value = RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[RT_geral.RT_820_200_BD.cfg_geral.perifericos[num2].Equipamento.Indice];
						this.DataGridView_periferico_RT820.Rows[num2].Cells[0].Value = value;
						this.DataGridView_periferico_RT820.Rows[num2].Cells[1].Value = RT_geral.RT_820_200_BD.cfg_geral.perifericos[num2].End_Quant.Valor;
						num2++;
					}
					while (num2 <= 3);
					text = "Repetidora";
					this.cb_ModoRepetidora.SelectedIndex = RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.Indice;
					this.NumericUpDown_end_rep_820.Value = new decimal(RT_geral.RT_820_200_BD.repetidora.End_repetidora.Valor);
					this.NumericUpDown_num_est_rep_820.Value = new decimal(RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.Valor);
					num2 = 0;
					do
					{
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[1].Value = RT_geral.RT_820_200_BD.repetidora.Repetidoras[num2].Valor;
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[3].Value = RT_geral.RT_820_200_BD.repetidora.Repetidoras[num2 + 10].Valor;
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[5].Value = RT_geral.RT_820_200_BD.repetidora.Repetidoras[num2 + 20].Valor;
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[7].Value = RT_geral.RT_820_200_BD.repetidora.Repetidoras[num2 + 30].Valor;
						this.DataGridView_end_rep_RT820.Rows[num2].Cells[9].Value = RT_geral.RT_820_200_BD.repetidora.Repetidoras[num2 + 40].Valor;
						num2++;
					}
					while (num2 <= 9);
					goto IL_1382;
					IL_1324:
					MessageBox.Show("Erro nas variávies: " + text, "Função: Atualiza_TelaRT820");
					goto IL_1382;
					IL_133D:
					num7 = -1;
										IL_1353:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num7 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_133D;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_1382:
				if (num7 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x002AF85C File Offset: 0x002ADC5C
		public void Habilita_Funcoes_de_Tela_RT_820(int tipo)
		{
			this.GroupBox_comunicacao_820.Enabled = true;
			this.GroupBox_informacoes_820.Enabled = false;
			this.GroupBox_EA_820.Enabled = false;
			this.GroupBox_ED_820.Enabled = false;
			this.GroupBox_perifericos_820.Enabled = false;
			this.DataGridView_periferico_RT820.Visible = false;
			this.GroupBox_parametros_repetidora_820.Enabled = false;
			this.GroupBox_end_rep_820.Enabled = false;
			this.DataGridView_end_rep_RT820.Visible = false;
			switch (tipo)
			{
			case 0:
				this.GroupBox_informacoes_820.Enabled = true;
				this.GroupBox_EA_820.Enabled = true;
				this.GroupBox_ED_820.Enabled = true;
				this.GroupBox_perifericos_820.Enabled = true;
				this.DataGridView_periferico_RT820.Visible = true;
				this.GroupBox_parametros_repetidora_820.Enabled = true;
				this.GroupBox_end_rep_820.Enabled = true;
				this.DataGridView_end_rep_RT820.Visible = true;
				break;
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x002AF94C File Offset: 0x002ADD4C
		private void Habilita_objetos_rep(bool ativa)
		{
			if (ativa)
			{
				this.Label_end_rep_820.Enabled = true;
				this.Label_num_est_rep_820.Enabled = true;
				this.NumericUpDown_end_rep_820.Enabled = true;
				this.NumericUpDown_num_est_rep_820.Enabled = true;
				this.GroupBox_end_rep_820.Enabled = true;
				this.DataGridView_end_rep_RT820.Visible = true;
			}
			else
			{
				this.Label_end_rep_820.Enabled = false;
				this.Label_num_est_rep_820.Enabled = false;
				this.NumericUpDown_end_rep_820.Enabled = false;
				this.NumericUpDown_num_est_rep_820.Enabled = false;
				this.GroupBox_end_rep_820.Enabled = false;
				this.DataGridView_end_rep_RT820.Visible = false;
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x002AF9F0 File Offset: 0x002ADDF0
		public void AtualizaMsgTela_RT_820(string texto, int cor)
		{
			this.ToolStripTextBox_RT_820_Msg.Text = texto;
			if (cor == 0)
			{
				this.ToolStripTextBox_RT_820_Msg.ForeColor = Color.Blue;
			}
			else if (cor == 1)
			{
				this.ToolStripProgressBar_RT_820.Value = 0;
				this.ToolStripTextBox_RT_820_Msg.ForeColor = Color.Red;
			}
			else
			{
				this.ToolStripTextBox_RT_820_Msg.ForeColor = Color.Black;
			}
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x002AFA54 File Offset: 0x002ADE54
		public void InicializaBarraProgressoTela_RT_820(int num_passos)
		{
			this.ToolStripProgressBar_RT_820.Minimum = 0;
			this.ToolStripProgressBar_RT_820.Maximum = 100;
			this.ToolStripProgressBar_RT_820.Step = checked((int)Math.Round(unchecked(100.0 / (double)num_passos + 1.0)));
			this.ToolStripProgressBar_RT_820.Value = 0;
			this.ToolStripProgressBar_RT_820.BackColor = Color.LightGray;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x002AFAC0 File Offset: 0x002ADEC0
		private void Timer_limpa_MSG_820_Tick(object sender, EventArgs e)
		{
			this.Timer_limpa_MSG_820.Enabled = false;
			this.AtualizaMsgTela_RT_820("", 0);
			this.ToolStripProgressBar_RT_820.Value = 0;
			this.ToolStripButton_RT_820_Upload.Enabled = true;
			this.ToolStripButton_RT_820_Download.Enabled = true;
			this.ToolStripButton_RT_820_Abrir.Enabled = true;
			this.ToolStripButton_RT_820_novo.Enabled = true;
			this.ToolStripButton_RT_820_Salvar.Enabled = true;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x002AFB30 File Offset: 0x002ADF30
		private void NumericUpDown_end_rep_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.repetidora.End_repetidora.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.repetidora.End_repetidora, true);
			sender = numericUpDown;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x002AFB90 File Offset: 0x002ADF90
		private void NumericUpDown_num_est_rep_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.repetidora.Num_repetidoras, true);
			sender = numericUpDown;
			int num = 0;
			int num2 = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			checked
			{
				for (int i = num; i <= num2; i++)
				{
					switch (i)
					{
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
						this.DataGridView_end_rep_RT820.Rows[i].Cells[1].ReadOnly = false;
						break;
					case 10:
					case 11:
					case 12:
					case 13:
					case 14:
					case 15:
					case 16:
					case 17:
					case 18:
					case 19:
						this.DataGridView_end_rep_RT820.Rows[i - 10].Cells[3].ReadOnly = false;
						break;
					case 20:
					case 21:
					case 22:
					case 23:
					case 24:
					case 25:
					case 26:
					case 27:
					case 28:
					case 29:
						this.DataGridView_end_rep_RT820.Rows[i - 20].Cells[5].ReadOnly = false;
						break;
					case 30:
					case 31:
					case 32:
					case 33:
					case 34:
					case 35:
					case 36:
					case 37:
					case 38:
					case 39:
						this.DataGridView_end_rep_RT820.Rows[i - 30].Cells[7].ReadOnly = false;
						break;
					case 40:
					case 41:
					case 42:
					case 43:
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:
						this.DataGridView_end_rep_RT820.Rows[i - 40].Cells[9].ReadOnly = false;
						break;
					}
				}
				for (int i = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null)); i <= 49; i++)
				{
					switch (i)
					{
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
						this.DataGridView_end_rep_RT820.Rows[i].Cells[1].ReadOnly = true;
						this.DataGridView_end_rep_RT820.Rows[i].Cells[1].Value = 0;
						break;
					case 10:
					case 11:
					case 12:
					case 13:
					case 14:
					case 15:
					case 16:
					case 17:
					case 18:
					case 19:
						this.DataGridView_end_rep_RT820.Rows[i - 10].Cells[3].ReadOnly = true;
						this.DataGridView_end_rep_RT820.Rows[i - 10].Cells[3].Value = 0;
						break;
					case 20:
					case 21:
					case 22:
					case 23:
					case 24:
					case 25:
					case 26:
					case 27:
					case 28:
					case 29:
						this.DataGridView_end_rep_RT820.Rows[i - 20].Cells[5].ReadOnly = true;
						this.DataGridView_end_rep_RT820.Rows[i - 20].Cells[5].Value = 0;
						break;
					case 30:
					case 31:
					case 32:
					case 33:
					case 34:
					case 35:
					case 36:
					case 37:
					case 38:
					case 39:
						this.DataGridView_end_rep_RT820.Rows[i - 30].Cells[7].ReadOnly = true;
						this.DataGridView_end_rep_RT820.Rows[i - 30].Cells[7].Value = 0;
						break;
					case 40:
					case 41:
					case 42:
					case 43:
					case 44:
					case 45:
					case 46:
					case 47:
					case 48:
					case 49:
						this.DataGridView_end_rep_RT820.Rows[i - 40].Cells[9].ReadOnly = true;
						this.DataGridView_end_rep_RT820.Rows[i - 40].Cells[9].Value = 0;
						break;
					}
				}
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x002B0048 File Offset: 0x002AE448
		private void NumericUpDown_intervalo_filtro_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.AD_Intervalo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.cfg_geral.AD_Intervalo, true);
			sender = numericUpDown;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x002B00A8 File Offset: 0x002AE4A8
		private void NumericUpDown_tamanho_filtro_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.AD_Tamanho_filtro.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.cfg_geral.AD_Tamanho_filtro, true);
			sender = numericUpDown;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x002B0108 File Offset: 0x002AE508
		private void CarregaNumericUpDown(ref NumericUpDown nud, RT_geral.Integer_ictel @int)
		{
			nud.Maximum = new decimal(@int.Lmte_sup);
			nud.Minimum = new decimal(@int.Lmte_inf);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x002B0130 File Offset: 0x002AE530
		private void CarregaComboBoxBaudRate(ref ComboBox cb, ref RT_geral.Combo_ictel dado)
		{
			cb.Items.Clear();
			int num = 0;
			checked
			{
				int num2 = dado.Numero_itens - 1;
				for (int i = num; i <= num2; i++)
				{
					cb.Items.Add(dado.itens[i]);
				}
			}
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x002B0174 File Offset: 0x002AE574
		private void CarregaComboBoxVazao(ref ComboBox dado, int expIO)
		{
			dado.Items.Clear();
			dado.Items.Add("Leitura Desabilitada");
			int num = 1;
			checked
			{
				do
				{
					dado.Items.Add("Leitura Vazão EA " + Strings.Format(num, "0#"));
					num++;
				}
				while (num <= 16);
				num = 1;
				do
				{
					dado.Items.Add("Leitura Vazão ED " + Strings.Format(num, "0#"));
					dado.Items.Add("Leitura Vazão ED " + Strings.Format(num, "0#") + " reverso");
					num++;
				}
				while (num <= 8);
				if (expIO == 21857)
				{
					num = 9;
					do
					{
						dado.Items.Add("Leitura Vazão ED " + Strings.Format(num, "0#"));
						dado.Items.Add("Leitura Vazão ED " + Strings.Format(num, "0#") + " reverso");
						num++;
					}
					while (num <= 16);
				}
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x002B0298 File Offset: 0x002AE698
		private void ComboBox_modo_simulado_820_SelectedIndexChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x002B029C File Offset: 0x002AE69C
		private void NumericUpDown_end_mestre_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.End_mestre.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.cfg_geral.End_mestre, true);
			sender = numericUpDown;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x002B02FC File Offset: 0x002AE6FC
		private void NumericUpDown_end_est_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.End_estacao.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.cfg_geral.End_estacao, true);
			sender = numericUpDown;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x002B035C File Offset: 0x002AE75C
		private void NumericUpDown_temp_ptt_820_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.Tempo_ptt.Valor = Conversions.ToInteger(Operators.MultiplyObject(Operators.IntDivideObject(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null), 10), 10));
			NewLateBinding.LateSet(sender, null, "value", new object[]
			{
				RT_geral.RT_820_200_BD.cfg_geral.Tempo_ptt.Valor
			}, null, null);
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.cfg_geral.Tempo_ptt, true);
			sender = numericUpDown;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x002B0404 File Offset: 0x002AE804
		private void ComboBox_baudrate_COM2_820_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.Valor = RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.valores[RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.Indice];
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x002B047C File Offset: 0x002AE87C
		private void CheckBox_hab_expansao_IO_820_CheckedChanged(object sender, EventArgs e)
		{
			checked
			{
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null), true, false))
				{
					RT_geral.RT_820_BD.HabExpIO.Valor = 21857;
					this.DataGridView_RT820_ED.Height = 376;
					this.GroupBox_ED_820.Height = 417;
				}
				else
				{
					RT_geral.RT_820_BD.HabExpIO.Valor = 21856;
					this.DataGridView_RT820_ED.Height = 200;
					this.GroupBox_ED_820.Height = 241;
					int num = 8;
					do
					{
						RT_geral.RT_820_BD.config_ED[num].Valor = RT_geral.RT_820_DataGrigViewEDColunas[0].LinhasValor[0];
						RT_geral.RT_820_BD.config_ED[num].Indice = 0;
						num++;
					}
					while (num <= 15);
				}
				if (!this.bloqueio_IO)
				{
					int num = 0;
					do
					{
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_BD.ctrl_acionamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[0], "SD", RT_geral.RT_820_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_BD.ctrl_desligamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[2], "SD", RT_geral.RT_820_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_BD.ctrl_ret_acionamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[1], "ED", RT_geral.RT_820_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_BD.ctrl_ret_desligamento[num], RT_geral.RT_820_DataGrigViewProcessosColunas[3], "ED", RT_geral.RT_820_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_BD.ctrl_ED_selecao[num], RT_geral.RT_820_DataGrigViewProcessosColunas[4], "ED", RT_geral.RT_820_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_BD.ctrl_ED_liberacao[num], RT_geral.RT_820_DataGrigViewProcessosColunas[6], "ED", RT_geral.RT_820_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_BD.ctrl_ED_bloqueio[num], RT_geral.RT_820_DataGrigViewProcessosColunas[5], "ED", RT_geral.RT_820_BD.HabExpIO.Valor);
						RT_geral.AcertaIndexCombo_Ctrl(ref RT_geral.RT_820_BD.config_vazao[num], RT_geral.RT_820_DataGrigViewVazoesColunas[0], "VZ", RT_geral.RT_820_BD.HabExpIO.Valor);
						num++;
					}
					while (num <= 7);
				}
				this.InicializaEstrutura_DataGridView_Processos();
				this.GeraDataGridView_Processos();
				this.InicializaEstrutura_DataGridView_Vazoes();
				this.GeraDataGridView_Vazoes();
				this.InicializaEstrutura_DataGridView_ED();
				this.GeraDataGridView_ED();
				this.Atualiza_TelaRT820();
			}
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x002B0768 File Offset: 0x002AEB68
		private void DataGridView_processo_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x002B076C File Offset: 0x002AEB6C
		private void DataGridView_processo_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x002B0770 File Offset: 0x002AEB70
		private void DataGridView_processo_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x002B0774 File Offset: 0x002AEB74
		private void DataGridView_grupos_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x002B0778 File Offset: 0x002AEB78
		private void DataGridView_grupos_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x002B077C File Offset: 0x002AEB7C
		private void DataGridView_grupos_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x002B0780 File Offset: 0x002AEB80
		private void DataGridView_parametros_EA_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x002B0784 File Offset: 0x002AEB84
		private void DataGridView_parametros_EA_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x002B0788 File Offset: 0x002AEB88
		private void DataGridView_parametros_EA_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x002B078C File Offset: 0x002AEB8C
		private void DataGridView_setpoints_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x002B0790 File Offset: 0x002AEB90
		private void DataGridView_setpoints_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x002B0794 File Offset: 0x002AEB94
		private void DataGridView_setpoints_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x002B0798 File Offset: 0x002AEB98
		private void DataGridView_periferico_RT820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_periferico_RT820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_modelo", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_periferico_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = 0;
					int num2 = RT_geral.RT_820_DataGrigViewPerifericosColunas[e.ColumnIndex].NumeroLinhaMenu - 1;
					for (int i = num; i <= num2; i++)
					{
						if (Operators.CompareString(RT_geral.RT_820_DataGrigViewPerifericosColunas[e.ColumnIndex].LinhasMenu[i], text, false) == 0)
						{
							RT_geral.RT_820_200_BD.cfg_geral.perifericos[e.RowIndex].Equipamento.Valor = RT_geral.RT_820_DataGrigViewPerifericosColunas[e.ColumnIndex].LinhasValor[i];
							RT_geral.RT_820_200_BD.cfg_geral.perifericos[e.RowIndex].Equipamento.Indice = i;
							break;
						}
					}
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end", false) == 0)
				{
					this.DataGridView_periferico_RT820.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_periferico_RT820.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_200_BD.cfg_geral.perifericos[e.RowIndex].End_Quant.Valor = Conversions.ToInteger(this.DataGridView_periferico_RT820.Rows[e.RowIndex].Cells[1].Value);
				}
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x002B0984 File Offset: 0x002AED84
		private void DataGridView_periferico_RT820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_periferico_RT820.Columns[e.ColumnIndex].DataPropertyName;
			if (Operators.CompareString(dataPropertyName, "Col_end", false) == 0)
			{
				RT_geral.RT_820_200_BD.cfg_geral.perifericos[e.RowIndex].End_Quant.Valor = checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue))));
				DataGridView dataGridView = (DataGridView)sender;
				RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_200_BD.cfg_geral.perifericos[e.RowIndex].End_Quant, e, true);
				sender = dataGridView;
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x002B0A2C File Offset: 0x002AEE2C
		private void DataGridView_periferico_RT820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_periferico_RT820.IsCurrentCellDirty)
			{
				this.DataGridView_periferico_RT820.CommitEdit(512);
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x002B0A4C File Offset: 0x002AEE4C
		private void DataGridView_vazoes_RT820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x002B0A50 File Offset: 0x002AEE50
		private void DataGridView_vazoes_RT820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x002B0A54 File Offset: 0x002AEE54
		private void DataGridView_vazoes_RT820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x002B0A58 File Offset: 0x002AEE58
		private void DataGridView_RT820_ED_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
			{
				return;
			}
			string dataPropertyName = this.DataGridView_RT820_ED.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_Entrada", false) == 0)
				{
					string text = Conversions.ToString(this.DataGridView_RT820_ED.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					int num = RT_geral.RT_820_200_BD.cfg_geral.entradas[e.RowIndex].Numero_itens - 1;
					int num2 = 0;
					int num3 = num;
					int i;
					for (i = num2; i <= num3; i++)
					{
						string text2 = RT_geral.RT_820_200_BD.cfg_geral.entradas[e.RowIndex].itens[i];
						if (Operators.CompareString(text, text2, false) == 0)
						{
							RT_geral.RT_820_200_BD.cfg_geral.entradas[e.RowIndex].Valor = RT_geral.RT_820_200_BD.cfg_geral.entradas[e.RowIndex].valores[i];
							RT_geral.RT_820_200_BD.cfg_geral.entradas[e.RowIndex].Indice = i;
							break;
						}
					}
					i = 0;
					do
					{
						if (e.RowIndex != i && RT_geral.RT_820_200_BD.cfg_geral.entradas[e.RowIndex].Valor != RT_geral.RT_820_200_BD.cfg_geral.entradas[i].valores[0] && RT_geral.RT_820_200_BD.cfg_geral.entradas[e.RowIndex].Valor == RT_geral.RT_820_200_BD.cfg_geral.entradas[i].Valor)
						{
							MessageBox.Show(string.Format("Entrada Digital ED{0} com a mesmo valor da Entrada Digital ED{1}", i + 1, e.RowIndex + 1));
						}
						i++;
					}
					while (i <= 7);
				}
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x002B0C50 File Offset: 0x002AF050
		private void DataGridView_RT820_ED_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_RT820_ED.IsCurrentCellDirty)
			{
				this.DataGridView_RT820_ED.CommitEdit(512);
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x002B0C70 File Offset: 0x002AF070
		private void DataGridView_end_rep_820_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			string dataPropertyName = this.DataGridView_end_rep_RT820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_end_1", false) == 0)
				{
					RT_geral.RT_820_200_BD.repetidora.Repetidoras[0 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_200_BD.repetidora.Repetidoras[0 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_2", false) == 0)
				{
					RT_geral.RT_820_200_BD.repetidora.Repetidoras[10 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_200_BD.repetidora.Repetidoras[10 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_3", false) == 0)
				{
					RT_geral.RT_820_200_BD.repetidora.Repetidoras[20 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_200_BD.repetidora.Repetidoras[20 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_4", false) == 0)
				{
					RT_geral.RT_820_200_BD.repetidora.Repetidoras[30 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_200_BD.repetidora.Repetidoras[30 + e.RowIndex], e, true);
					sender = dataGridView;
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_5", false) == 0)
				{
					RT_geral.RT_820_200_BD.repetidora.Repetidoras[40 + e.RowIndex].Valor = (int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(e.FormattedValue)));
					DataGridView dataGridView = (DataGridView)sender;
					RT_geral.Limite_ok_celula(ref dataGridView, ref RT_geral.RT_820_200_BD.repetidora.Repetidoras[40 + e.RowIndex], e, true);
					sender = dataGridView;
				}
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x002B0F04 File Offset: 0x002AF304
		private void DataGridView_end_rep_820_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			string dataPropertyName = this.DataGridView_end_rep_RT820.Columns[e.ColumnIndex].DataPropertyName;
			checked
			{
				if (Operators.CompareString(dataPropertyName, "Col_end_1", false) == 0)
				{
					int num = 0;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[1].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[1].Value));
					RT_geral.RT_820_200_BD.repetidora.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[1].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_2", false) == 0)
				{
					int num = 10;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[3].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[3].Value));
					RT_geral.RT_820_200_BD.repetidora.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[3].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_3", false) == 0)
				{
					int num = 20;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[5].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[5].Value));
					RT_geral.RT_820_200_BD.repetidora.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[5].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_4", false) == 0)
				{
					int num = 30;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[7].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[7].Value));
					RT_geral.RT_820_200_BD.repetidora.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[7].Value);
				}
				else if (Operators.CompareString(dataPropertyName, "Col_end_5", false) == 0)
				{
					int num = 40;
					this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[9].Value = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[9].Value));
					RT_geral.RT_820_200_BD.repetidora.Repetidoras[e.RowIndex + num].Valor = Conversions.ToInteger(this.DataGridView_end_rep_RT820.Rows[e.RowIndex].Cells[9].Value);
				}
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x002B12F0 File Offset: 0x002AF6F0
		private void DataGridView_end_rep_820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.DataGridView_end_rep_RT820.IsCurrentCellDirty)
			{
				this.DataGridView_end_rep_RT820.CommitEdit(512);
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x002B1310 File Offset: 0x002AF710
		private void DataGridView_timer_RT820_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x002B1314 File Offset: 0x002AF714
		private void DataGridView_timer_RT820_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			checked
			{
				if (Operators.ConditionalCompareObjectNotEqual(e.Value, null, false))
				{
					string text = e.Value.ToString();
					int length = text.Length;
					int num = text.IndexOf(":");
					if (length > 5 | num < 1)
					{
						e.Value = "00:00";
					}
					else
					{
						int num2 = (int)Math.Round(Conversion.Val(text.Substring(0, num)));
						int num3;
						if (num2 < 24)
						{
							if (length - num > 1)
							{
								num3 = (int)Math.Round(Conversion.Val(text.Substring(num + 1)));
								if (num3 > 59)
								{
									num3 = 0;
								}
							}
							else
							{
								num3 = 0;
							}
							e.Value = Strings.Format(num2, "0#") + ":" + Strings.Format(num3, "0#");
						}
						else
						{
							e.Value = "00:00";
							num3 = 0;
						}
						num3 = num2 * 60 + num3;
					}
				}
			}
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x002B13FC File Offset: 0x002AF7FC
		private void DataGridView_timer_RT820_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x002B1400 File Offset: 0x002AF800
		private void ToolStripButton_RT_820_Abrir_Click(object sender, EventArgs e)
		{
			checked
			{
				int num;
				int num3;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					int[] array = new int[651];
					this.AtivaEfeitoOnChangeValue();
					this.ToolStripButton_RT_820_Abrir.Enabled = false;
					this.ToolStripButton_RT_820_novo.Enabled = false;
					this.ToolStripButton_RT_820_Salvar.Enabled = false;
					this.ToolStripButton_RT_820_Download.Enabled = false;
					this.ToolStripButton_RT_820_Upload.Enabled = false;
					this.OpenFileDialog_RT_820.Filter = "Arquivo de configuração de equipamento|*.Cfg820_200";
					this.OpenFileDialog_RT_820.InitialDirectory = Linha_RT.diretorio;
					if (this.OpenFileDialog_RT_820.ShowDialog() == 1)
					{
						if (Operators.CompareString(this.OpenFileDialog_RT_820.FileName, "", false) != 0)
						{
							Linha_RT.diretorio = Path.GetDirectoryName(this.OpenFileDialog_RT_820.FileName) + "\\";
							RT_geral.arquivo_extensao = Path.GetExtension(this.OpenFileDialog_RT_820.FileName);
							IniFile iniFile = new IniFile(this.OpenFileDialog_RT_820.FileName);
							RT_geral.RT_820_200_BD.filename = this.OpenFileDialog_RT_820.FileName;
							RT_geral.RT_820_200_BD.firmware.Equip.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "EQUIPAMENTO", RT_geral.RT_820_200_BD.firmware.Equip.Valor);
							RT_geral.RT_820_200_BD.firmware.Versao.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "VERSAO", RT_geral.RT_820_200_BD.firmware.Versao.Valor);
							RT_geral.RT_820_200_BD.firmware.Build.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "BUILD", RT_geral.RT_820_200_BD.firmware.Build.Valor);
							RT_geral.RT_820_200_BD.firmware.Release.Valor = iniFile.ReadInteger("GERAL_INFORMACAO", "RELEASE", RT_geral.RT_820_200_BD.firmware.Release.Valor);
							if (RT_geral.RT_820_200_BD.firmware.Build.Valor >= 30)
							{
								RT_geral.RT_820_200_flag_setpoint_horario = true;
							}
							else
							{
								RT_geral.RT_820_200_flag_setpoint_horario = false;
							}
							if (!Linha_RT.VerificaSeEquipamentoEValido(1, RT_geral.RT_820_200_BD.firmware.Equip.Valor, RT_geral.RT_820_200_BD.firmware.Versao.Valor, RT_geral.RT_820_200_BD.firmware.Build.Valor, RT_geral.RT_820_200_BD.firmware.Release.Valor, RT_geral.arquivo_extensao).Status)
							{
								RT_geral.Lmte_Init_ok = false;
								this.Inicializa_DadosEStruturaRT820_Padrao();
								this.Inicializa_DadosEStruturaRT820_Default();
								Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
								this.Atualiza_TelaRT820();
								RT_geral.Lmte_Init_ok = true;
								this.AtualizaMsgTela_RT_820("Valores Default carregados", 0);
								this.Timer_limpa_MSG_820.Enabled = true;
							}
							else
							{
								this.bloqueio_IO = true;
								RT_geral.RT_820_200_BD.cfg_geral.End_estacao.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "ESTACAO", 0);
								RT_geral.RT_820_200_BD.cfg_geral.End_mestre.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "MESTRE", 0);
								RT_geral.RT_820_200_BD.cfg_geral.Tempo_ptt.Valor = iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "TEMPO_PTT", 0);
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2, iniFile.ReadInteger("GERAL_PARAM_COMINICACAO", "BAUDRATE_COM2", 0));
								RT_geral.RT_820_200_BD.cfg_geral.nivel_fonte.Valor = iniFile.ReadInteger("CFG_CONTROLE", "HAB_NIVEL_FONTE", 0);
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.origem_protecao, iniFile.ReadInteger("CFG_CONTROLE", "ORIGEM_PROTECAO", 0));
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.origem_controle, iniFile.ReadInteger("CFG_CONTROLE", "ORIGEM_CONTROLE", 0));
								RT_geral.RT_820_200_BD.cfg_geral.AD_Intervalo.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "INTERVALO", 0);
								RT_geral.RT_820_200_BD.cfg_geral.AD_Tamanho_filtro.Valor = iniFile.ReadInteger("ENTRADA_ANALOGICA", "TAMANHO_FILTRO", 0);
								this.InicializaEStruturasVariaveis_RT820();
								int num2 = 0;
								do
								{
									string text = string.Format("ED{0}", num2 + 1);
									RT_geral.RT_820_200_BD.cfg_geral.entradas[num2].Valor = iniFile.ReadInteger("ENTRADA_DIGITAL", text, 0);
									Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.entradas[num2], RT_geral.RT_820_200_BD.cfg_geral.entradas[num2].Valor);
									num2++;
								}
								while (num2 <= 7);
								num2 = 0;
								do
								{
									string text = string.Format("PERIFERICO{0}", num2 + 1);
									RT_geral.RT_820_200_BD.cfg_geral.perifericos[num2].Equipamento.Valor = iniFile.ReadInteger(text, "MODELO", 0);
									Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.perifericos[num2].Equipamento, RT_geral.RT_820_200_BD.cfg_geral.perifericos[num2].Equipamento.Valor);
									RT_geral.RT_820_200_BD.cfg_geral.perifericos[num2].End_Quant.Valor = iniFile.ReadInteger(text, "ENDERECO", 0);
									num2++;
								}
								while (num2 <= 3);
								RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.Valor = iniFile.ReadInteger("REPETIDORA", "MODO_REPETIDORA", 0);
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora, RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.Valor);
								RT_geral.RT_820_200_BD.repetidora.End_repetidora.Valor = iniFile.ReadInteger("REPETIDORA", "ENDERECO", 0);
								RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.Valor = iniFile.ReadInteger("REPETIDORA", "NUMERO_REPETIDORAS", 0);
								num2 = 0;
								do
								{
									string text = string.Format("RPT{0}", num2 + 1);
									RT_geral.RT_820_200_BD.repetidora.Repetidoras[num2].Valor = iniFile.ReadInteger("REPETIDORA", text, 0);
									num2++;
								}
								while (num2 <= 49);
								RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Alto.Valor = iniFile.ReadInteger("SETPOINT", "M1_ALTO", 0);
								RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Baixo.Valor = iniFile.ReadInteger("SETPOINT", "M1_BAIXO", 0);
								RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Alto.Valor = iniFile.ReadInteger("SETPOINT", "M2_ALTO", 0);
								RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Baixo.Valor = iniFile.ReadInteger("SETPOINT", "M2_BAIXO", 0);
								RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Alto.Valor = iniFile.ReadInteger("SETPOINT", "M3_ALTO", 0);
								RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Baixo.Valor = iniFile.ReadInteger("SETPOINT", "M3_BAIXO", 0);
								RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Alto.Valor = iniFile.ReadInteger("SETPOINT", "M4_ALTO", 0);
								RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Baixo.Valor = iniFile.ReadInteger("SETPOINT", "M4_BAIXO", 0);
								RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Desliga.Valor = iniFile.ReadInteger("SETPOINT", "PROT_DESLIGA", 0);
								RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Liga.Valor = iniFile.ReadInteger("SETPOINT", "PROT_LIGA", 0);
								num2 = 0;
								do
								{
									string text = string.Format("SETPOINT_HORARIO_{0}", num2 + 1);
									RT_geral.RT_820_200_BD.setpoint_horario[num2].Hora.Valor = iniFile.ReadInteger(text, "HORA", 0);
									RT_geral.RT_820_200_BD.setpoint_horario[num2].Minuto.Valor = iniFile.ReadInteger(text, "MINUTO", 0);
									RT_geral.RT_820_200_BD.setpoint_horario[num2].Alto.Valor = iniFile.ReadInteger(text, "ALTO", 4000);
									RT_geral.RT_820_200_BD.setpoint_horario[num2].Baixo.Valor = iniFile.ReadInteger(text, "BAIXO", 0);
									num2++;
								}
								while (num2 <= 7);
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.modo_operacao, iniFile.ReadInteger("MOTORES_VALVULAS", "MODO_OPERACAO", 0));
								RT_geral.RT_820_200_BD.cfg_geral.quantidade_motores.Valor = iniFile.ReadInteger("MOTORES_VALVULAS", "NUMERO_MOTORES", 0);
								RT_geral.RT_820_200_BD.cfg_geral.quantidade_valvulas.Valor = iniFile.ReadInteger("MOTORES_VALVULAS", "NUMERO_VALVULAS", 0);
								RT_geral.RT_820_200_BD.cfg_geral.bombas_simultaneas.Valor = iniFile.ReadInteger("MOTORES_VALVULAS", "BOMBAS_SIMULTANEAS", 0);
								RT_geral.RT_820_200_BD.cfg_geral.tempo_acionamentos.Valor = iniFile.ReadInteger("MOTORES_VALVULAS", "TEMPO_ENTRE_OPERACOES", 0);
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.modo_partida[0], iniFile.ReadInteger("MOTOR1", "MODO_CONTROLE", 0));
								RT_geral.RT_820_200_BD.cfg_geral.partida.Motor1.Valor = iniFile.ReadInteger("MOTOR1", "TEMPO_PARTIDA", 0);
								RT_geral.RT_820_200_BD.cfg_geral.parada.Motor1.Valor = iniFile.ReadInteger("MOTOR1", "TEMPO_PARADA", 0);
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.modo_partida[1], iniFile.ReadInteger("MOTOR2", "MODO_CONTROLE", 0));
								RT_geral.RT_820_200_BD.cfg_geral.partida.Motor2.Valor = iniFile.ReadInteger("MOTOR2", "TEMPO_PARTIDA", 0);
								RT_geral.RT_820_200_BD.cfg_geral.parada.Motor2.Valor = iniFile.ReadInteger("MOTOR2", "TEMPO_PARADA", 0);
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.modo_partida[2], iniFile.ReadInteger("MOTOR3", "MODO_CONTROLE", 0));
								RT_geral.RT_820_200_BD.cfg_geral.partida.Motor3.Valor = iniFile.ReadInteger("MOTOR3", "TEMPO_PARTIDA", 0);
								RT_geral.RT_820_200_BD.cfg_geral.parada.Motor3.Valor = iniFile.ReadInteger("MOTOR3", "TEMPO_PARADA", 0);
								Linha_RT.Atualiza_estrutura_combo(ref RT_geral.RT_820_200_BD.cfg_geral.modo_partida[3], iniFile.ReadInteger("MOTOR4", "MODO_CONTROLE", 0));
								RT_geral.RT_820_200_BD.cfg_geral.partida.Motor4.Valor = iniFile.ReadInteger("MOTOR4", "TEMPO_PARTIDA", 0);
								RT_geral.RT_820_200_BD.cfg_geral.parada.Motor4.Valor = iniFile.ReadInteger("MOTOR4", "TEMPO_PARADA", 0);
								RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula1.Valor = iniFile.ReadInteger("VALVULA1", "TEMPO_ABERTURA", 0);
								RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula1.Valor = iniFile.ReadInteger("VALVULA1", "TEMPO_FECHAMENTO", 0);
								RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula2.Valor = iniFile.ReadInteger("VALVULA2", "TEMPO_ABERTURA", 0);
								RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula2.Valor = iniFile.ReadInteger("VALVULA2", "TEMPO_FECHAMENTO", 0);
								RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula3.Valor = iniFile.ReadInteger("VALVULA3", "TEMPO_ABERTURA", 0);
								RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula3.Valor = iniFile.ReadInteger("VALVULA3", "TEMPO_FECHAMENTO", 0);
								RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula4.Valor = iniFile.ReadInteger("VALVULA4", "TEMPO_ABERTURA", 0);
								RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula4.Valor = iniFile.ReadInteger("VALVULA4", "TEMPO_FECHAMENTO", 0);
								this.CB_TipoAntena.SelectedIndex = iniFile.ReadInteger("DADOS_INSTALACAO", "TIPO_ANTENA", -1);
								this.CB_PolarizacaoAntena.SelectedIndex = iniFile.ReadInteger("DADOS_INSTALACAO", "POLARIZACAO_ANTENA", -1);
								this.T_PotRadio.Text = iniFile.ReadText("DADOS_INSTALACAO", "POTENCIA_RADIO", "");
								this.CB_ModeloRadio.SelectedIndex = iniFile.ReadInteger("DADOS_INSTALACAO", "MODELO_RADIO", -1);
								this.T_DistCentral.Text = iniFile.ReadText("DADOS_INSTALACAO", "DISTANCIA_CENTRAL", "");
								this.T_FreqRadio.Text = iniFile.ReadText("DADOS_INSTALACAO", "FREQUENCIA_RADIO", "");
								this.T_Azimute.Text = iniFile.ReadText("DADOS_INSTALACAO", "AZIMUTE", "");
								this.T_Longitude.Text = iniFile.ReadText("DADOS_INSTALACAO", "LONGITUDE", "");
								this.T_Latitude.Text = iniFile.ReadText("DADOS_INSTALACAO", "LATITUDE", "");
								this.T_AlturaAntena.Text = iniFile.ReadText("DADOS_INSTALACAO", "ALTURA_ANTENA", "");
								this.T_ModeloFonte.Text = iniFile.ReadText("DADOS_INSTALACAO", "MODELO_FONTE", "");
								this.TextBox_nome_RT820.Text = iniFile.ReadText("GERAL_DESCRICAO", "NOME", "");
								this.TextBox_endereco_RT820.Text = iniFile.ReadText("GERAL_DESCRICAO", "ENDERECO", "");
								this.TextBox_comentarios_RT820.Text = iniFile.ReadText("GERAL_DESCRICAO", "COMENTARIO", "");
								this.Atualiza_TelaRT820();
								this.bloqueio_IO = false;
								this.AtualizaMsgTela_RT_820("Arquivo carregado com sucesso!", 0);
								this.Timer_limpa_MSG_820.Enabled = true;
							}
						}
					}
					else
					{
						this.AtualizaMsgTela_RT_820("Operação Cancelada", 0);
						this.Timer_limpa_MSG_820.Enabled = true;
					}
					goto IL_F2F;
					IL_ECA:
					Interaction.MsgBox("Não foi possível carregar os dados", (MsgBoxStyle)32, "Atenção - Erro I/0");
					this.Timer_limpa_MSG_820.Enabled = true;
					goto IL_F2F;
					IL_EEA:
					num3 = -1;
										IL_F00:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num3 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_EEA;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_F2F:
				if (num3 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x002B2364 File Offset: 0x002B0764
		private void ToolStripButton_RT_820_Salvar_Click(object sender, EventArgs e)
		{
			checked
			{
				int num;
				int num4;
				object obj;
				try
				{
					ProjectData.ClearProjectError();
					num = 2;
					int[] array = new int[651];
					this.AtivaEfeitoOnChangeValue();
					this.ToolStripButton_RT_820_Abrir.Enabled = false;
					this.ToolStripButton_RT_820_novo.Enabled = false;
					this.ToolStripButton_RT_820_Salvar.Enabled = false;
					this.ToolStripButton_RT_820_Download.Enabled = false;
					this.ToolStripButton_RT_820_Upload.Enabled = false;
					this.SaveFileDialog_RT_820.Filter = "Arquivo de configuração de equipamento|*.Cfg820_200";
					this.SaveFileDialog_RT_820.InitialDirectory = Linha_RT.diretorio;
					if (this.SaveFileDialog_RT_820.ShowDialog() == 1)
					{
						if (Operators.CompareString(this.SaveFileDialog_RT_820.FileName, "", false) != 0)
						{
							Linha_RT.diretorio = Path.GetDirectoryName(this.SaveFileDialog_RT_820.FileName) + "\\";
							if (File.Exists(this.SaveFileDialog_RT_820.FileName))
							{
								if (File.Exists(this.SaveFileDialog_RT_820.FileName + ".old"))
								{
									File.Delete(this.SaveFileDialog_RT_820.FileName + ".old");
								}
								File.Move(this.SaveFileDialog_RT_820.FileName, this.SaveFileDialog_RT_820.FileName + ".old");
							}
							RT_geral.RT_820_200_BD.filename = this.SaveFileDialog_RT_820.FileName;
							IniFileWriteFast iniFileWriteFast = new IniFileWriteFast(this.SaveFileDialog_RT_820.FileName);
							this.InicializaBarraProgressoTela_RT_820(14);
							iniFileWriteFast.WriteSection("GERAL_INFORMACAO");
							iniFileWriteFast.WriteKey("EQUIPAMENTO", RT_geral.RT_820_200_BD.firmware.Equip.Valor);
							iniFileWriteFast.WriteKey("VERSAO", RT_geral.RT_820_200_BD.firmware.Versao.Valor);
							iniFileWriteFast.WriteKey("BUILD", RT_geral.RT_820_200_BD.firmware.Build.Valor);
							iniFileWriteFast.WriteKey("RELEASE", RT_geral.RT_820_200_BD.firmware.Release.Valor);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("GERAL_PARAM_COMINICACAO");
							iniFileWriteFast.WriteKey("ESTACAO", RT_geral.RT_820_200_BD.cfg_geral.End_estacao.Valor);
							iniFileWriteFast.WriteKey("MESTRE", RT_geral.RT_820_200_BD.cfg_geral.End_mestre.Valor);
							iniFileWriteFast.WriteKey("TEMPO_PTT", RT_geral.RT_820_200_BD.cfg_geral.Tempo_ptt.Valor);
							iniFileWriteFast.WriteKey("BAUDRATE_COM2", RT_geral.RT_820_200_BD.cfg_geral.BaudRateCOM2.Valor);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("GERAL_DESCRICAO");
							iniFileWriteFast.WriteKey("NOME", this.TextBox_nome_RT820.Text);
							iniFileWriteFast.WriteKey("ENDERECO", this.TextBox_endereco_RT820.Text);
							iniFileWriteFast.WriteKey("COMENTARIO", this.TextBox_comentarios_RT820.Text);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("CFG_CONTROLE");
							iniFileWriteFast.WriteKey("HAB_NIVEL_FONTE", RT_geral.RT_820_200_BD.cfg_geral.nivel_fonte.Valor);
							iniFileWriteFast.WriteKey("ORIGEM_PROTECAO", RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.Valor);
							iniFileWriteFast.WriteKey("ORIGEM_CONTROLE", RT_geral.RT_820_200_BD.cfg_geral.origem_controle.Valor);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("ENTRADA_ANALOGICA");
							iniFileWriteFast.WriteKey("INTERVALO", RT_geral.RT_820_200_BD.cfg_geral.AD_Intervalo.Valor);
							iniFileWriteFast.WriteKey("TAMANHO_FILTRO", RT_geral.RT_820_200_BD.cfg_geral.AD_Tamanho_filtro.Valor);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("ENTRADA_DIGITAL");
							int i = 0;
							do
							{
								string text = string.Format("ED{0}", i + 1);
								iniFileWriteFast.WriteKey(text, RT_geral.RT_820_200_BD.cfg_geral.entradas[i].Valor);
								i++;
							}
							while (i <= 7);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							i = 0;
							do
							{
								string text = string.Format("PERIFERICO{0}", i + 1);
								iniFileWriteFast.WriteSection(text);
								iniFileWriteFast.WriteKey("MODELO", RT_geral.RT_820_200_BD.cfg_geral.perifericos[i].Equipamento.Valor);
								iniFileWriteFast.WriteKey("ENDERECO", RT_geral.RT_820_200_BD.cfg_geral.perifericos[i].End_Quant.Valor);
								iniFileWriteFast.LineSpace();
								i++;
							}
							while (i <= 3);
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("MOTORES_VALVULAS");
							iniFileWriteFast.WriteKey("MODO_OPERACAO", RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.Valor);
							iniFileWriteFast.WriteKey("NUMERO_MOTORES", RT_geral.RT_820_200_BD.cfg_geral.quantidade_motores.Valor);
							iniFileWriteFast.WriteKey("NUMERO_VALVULAS", RT_geral.RT_820_200_BD.cfg_geral.quantidade_valvulas.Valor);
							iniFileWriteFast.WriteKey("BOMBAS_SIMULTANEAS", RT_geral.RT_820_200_BD.cfg_geral.bombas_simultaneas.Valor);
							iniFileWriteFast.WriteKey("TEMPO_ENTRE_OPERACOES", RT_geral.RT_820_200_BD.cfg_geral.tempo_acionamentos.Valor);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("MOTOR1");
							iniFileWriteFast.WriteKey("MODO_CONTROLE", RT_geral.RT_820_200_BD.cfg_geral.modo_partida[0].Valor);
							iniFileWriteFast.WriteKey("TEMPO_PARTIDA", RT_geral.RT_820_200_BD.cfg_geral.partida.Motor1.Valor);
							iniFileWriteFast.WriteKey("TEMPO_PARADA", RT_geral.RT_820_200_BD.cfg_geral.parada.Motor1.Valor);
							iniFileWriteFast.LineSpace();
							iniFileWriteFast.WriteSection("MOTOR2");
							iniFileWriteFast.WriteKey("MODO_CONTROLE", RT_geral.RT_820_200_BD.cfg_geral.modo_partida[1].Valor);
							iniFileWriteFast.WriteKey("TEMPO_PARTIDA", RT_geral.RT_820_200_BD.cfg_geral.partida.Motor2.Valor);
							iniFileWriteFast.WriteKey("TEMPO_PARADA", RT_geral.RT_820_200_BD.cfg_geral.parada.Motor2.Valor);
							iniFileWriteFast.LineSpace();
							iniFileWriteFast.WriteSection("MOTOR3");
							iniFileWriteFast.WriteKey("MODO_CONTROLE", RT_geral.RT_820_200_BD.cfg_geral.modo_partida[2].Valor);
							iniFileWriteFast.WriteKey("TEMPO_PARTIDA", RT_geral.RT_820_200_BD.cfg_geral.partida.Motor3.Valor);
							iniFileWriteFast.WriteKey("TEMPO_PARADA", RT_geral.RT_820_200_BD.cfg_geral.parada.Motor3.Valor);
							iniFileWriteFast.LineSpace();
							iniFileWriteFast.WriteSection("MOTOR4");
							iniFileWriteFast.WriteKey("MODO_CONTROLE", RT_geral.RT_820_200_BD.cfg_geral.modo_partida[3].Valor);
							iniFileWriteFast.WriteKey("TEMPO_PARTIDA", RT_geral.RT_820_200_BD.cfg_geral.partida.Motor4.Valor);
							iniFileWriteFast.WriteKey("TEMPO_PARADA", RT_geral.RT_820_200_BD.cfg_geral.parada.Motor4.Valor);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("VALVULA1");
							iniFileWriteFast.WriteKey("TEMPO_ABERTURA", RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula1.Valor);
							iniFileWriteFast.WriteKey("TEMPO_FECHAMENTO", RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula1.Valor);
							iniFileWriteFast.LineSpace();
							iniFileWriteFast.WriteSection("VALVULA2");
							iniFileWriteFast.WriteKey("TEMPO_ABERTURA", RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula2.Valor);
							iniFileWriteFast.WriteKey("TEMPO_FECHAMENTO", RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula2.Valor);
							iniFileWriteFast.LineSpace();
							iniFileWriteFast.WriteSection("VALVULA3");
							iniFileWriteFast.WriteKey("TEMPO_ABERTURA", RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula3.Valor);
							iniFileWriteFast.WriteKey("TEMPO_FECHAMENTO", RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula3.Valor);
							iniFileWriteFast.LineSpace();
							iniFileWriteFast.WriteSection("VALVULA4");
							iniFileWriteFast.WriteKey("TEMPO_ABERTURA", RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula4.Valor);
							iniFileWriteFast.WriteKey("TEMPO_FECHAMENTO", RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula4.Valor);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("SETPOINT");
							iniFileWriteFast.WriteKey("M1_ALTO", RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Alto.Valor);
							iniFileWriteFast.WriteKey("M1_BAIXO", RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Baixo.Valor);
							iniFileWriteFast.WriteKey("M2_ALTO", RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Alto.Valor);
							iniFileWriteFast.WriteKey("M2_BAIXO", RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Baixo.Valor);
							iniFileWriteFast.WriteKey("M3_ALTO", RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Alto.Valor);
							iniFileWriteFast.WriteKey("M3_BAIXO", RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Baixo.Valor);
							iniFileWriteFast.WriteKey("M4_ALTO", RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Alto.Valor);
							iniFileWriteFast.WriteKey("M4_BAIXO", RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Baixo.Valor);
							iniFileWriteFast.WriteKey("PROT_DESLIGA", RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Desliga.Valor);
							iniFileWriteFast.WriteKey("PROT_LIGA", RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Liga.Valor);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							i = 0;
							do
							{
								string text = string.Format("SETPOINT_HORARIO_{0}", i + 1);
								iniFileWriteFast.WriteSection(text);
								iniFileWriteFast.WriteKey("HORA", RT_geral.RT_820_200_BD.setpoint_horario[i].Hora.Valor);
								iniFileWriteFast.WriteKey("MINUTO", RT_geral.RT_820_200_BD.setpoint_horario[i].Minuto.Valor);
								iniFileWriteFast.WriteKey("ALTO", RT_geral.RT_820_200_BD.setpoint_horario[i].Alto.Valor);
								iniFileWriteFast.WriteKey("BAIXO", RT_geral.RT_820_200_BD.setpoint_horario[i].Baixo.Valor);
								iniFileWriteFast.LineSpace();
								i++;
							}
							while (i <= 7);
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("REPETIDORA");
							iniFileWriteFast.WriteKey("MODO_REPETIDORA", RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.Valor);
							iniFileWriteFast.WriteKey("ENDERECO", RT_geral.RT_820_200_BD.repetidora.End_repetidora.Valor);
							iniFileWriteFast.WriteKey("NUMERO_REPETIDORAS", RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.Valor);
							int num2 = 0;
							int num3 = RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.Valor - 1;
							for (i = num2; i <= num3; i++)
							{
								string text = string.Format("RPT{0}", i + 1);
								iniFileWriteFast.WriteKey(text, RT_geral.RT_820_200_BD.repetidora.Repetidoras[i].Valor);
							}
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.WriteSection("DADOS_INSTALACAO");
							iniFileWriteFast.WriteKey("TIPO_ANTENA", this.CB_TipoAntena.SelectedIndex);
							iniFileWriteFast.WriteKey("POLARIZACAO_ANTENA", this.CB_PolarizacaoAntena.SelectedIndex);
							iniFileWriteFast.WriteKey("POTENCIA_RADIO", this.T_PotRadio.Text);
							iniFileWriteFast.WriteKey("MODELO_RADIO", this.CB_ModeloRadio.SelectedIndex);
							iniFileWriteFast.WriteKey("DISTANCIA_CENTRAL", this.T_DistCentral.Text);
							iniFileWriteFast.WriteKey("FREQUENCIA_RADIO", this.T_FreqRadio.Text);
							iniFileWriteFast.WriteKey("AZIMUTE", this.T_Azimute.Text);
							iniFileWriteFast.WriteKey("LONGITUDE", this.T_Longitude.Text);
							iniFileWriteFast.WriteKey("LATITUDE", this.T_Latitude.Text);
							iniFileWriteFast.WriteKey("ALTURA_ANTENA", this.T_AlturaAntena.Text);
							iniFileWriteFast.WriteKey("MODELO_FONTE", this.T_ModeloFonte.Text);
							iniFileWriteFast.LineSpace();
							this.ToolStripProgressBar_RT_820.PerformStep();
							Application.DoEvents();
							iniFileWriteFast.CloseIniFileWriteFast();
							this.AtualizaMsgTela_RT_820("Arquivo gerado com sucesso!", 0);
							this.Timer_limpa_MSG_820.Enabled = true;
						}
					}
					else
					{
						this.AtualizaMsgTela_RT_820("Operação Cancelada", 0);
						this.Timer_limpa_MSG_820.Enabled = true;
					}
					goto IL_E5C;
					IL_DF7:
					Interaction.MsgBox("Não foi possível gravar os dados", (MsgBoxStyle)32, "Atenção - Erro I/0");
					this.Timer_limpa_MSG_820.Enabled = true;
					goto IL_E5C;
					IL_E17:
					num4 = -1;
										IL_E2D:;
				}
				catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
				{
					Exception ex = (Exception)obj2;
					goto IL_E17;
				}
				throw ProjectData.CreateProjectError(-2146828237);
				IL_E5C:
				if (num4 != 0)
				{
					ProjectData.ClearProjectError();
				}
			}
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x002B31F4 File Offset: 0x002B15F4
		private void AtivaEfeitoOnChangeValue()
		{
			this.ToolStri_RT_820.Enabled = false;
			this.tb_lixo1.Focus();
			this.tb_lixo2.Focus();
			this.tb_lixo3.Focus();
			this.tb_lixo5.Focus();
			this.tb_lixo6.Focus();
			this.tb_lixo7.Focus();
			this.tb_lixo8.Focus();
			this.ToolStri_RT_820.Enabled = true;
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x002B3270 File Offset: 0x002B1670
		private void ToolStripButton_RT_820_Upload_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.Bloqueia_acoes_RT820();
				this.EncerraEdicaoDeCampos_RT820();
				this.Escrita_RT820_conf();
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
			}
			this.Libera_acoes_RT820();
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x002B32AC File Offset: 0x002B16AC
		private void ToolStripButton_RT_820_novo_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			this.Bloqueia_acoes_RT820();
			this.Inicializa_DadosEStruturaRT820_Default();
			Linha_RT.Atualiza_Tipo_equipamento(Geral.Ctrl_equipamento, Geral.Ctrl_versao);
			RT_geral.RT_820_200_BD.filename = "";
			this.Atualiza_TelaRT820();
			this.AtualizaMsgTela_RT_820("Arquivo gerado com sucesso!", 0);
			this.Timer_limpa_MSG_820.Enabled = true;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x002B3308 File Offset: 0x002B1708
		private void ToolStripButton_RT_820_Download_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			if (Comunicacao.VerificaPortaSerialExiste())
			{
				this.Bloqueia_acoes_RT820();
				this.EncerraEdicaoDeCampos_RT820();
				this.Leitura_RT_820_200_conf();
			}
			else
			{
				Interaction.MsgBox("Porta serial não encontrada!\r\nComando não executado!", (MsgBoxStyle)16, "Atenção");
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x002B3340 File Offset: 0x002B1740
		public void Leitura_RT_820_conf()
		{
			this.InicializaBarraProgressoTela_RT_820(8);
			this.AtualizaMsgTela_RT_820("Identificação de equipamento - Etapa 1", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(0, 255, 4).Status)
			{
				this.AtualizaMsgTela_RT_820("Equipamento não responde", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Linha_RT.VerificaSeEquipamentoEValido(2, 0, 0, 0, 0, "");
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(0);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 2", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(2048, 255, 113).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(2048);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 3", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(2161, 255, 94).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(2161);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 4", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(4096, RT_geral.RT_820_BD.End_estacao.Valor, 52).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(4096);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Passo 5", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(8192, RT_geral.RT_820_BD.End_estacao.Valor, 16).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(8192);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Passo 6", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(10240, RT_geral.RT_820_BD.End_estacao.Valor, 16).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(10240);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Passo 7", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(12288, RT_geral.RT_820_BD.End_estacao.Valor, 16).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(12288);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Passo 8", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(30720, RT_geral.RT_820_BD.End_estacao.Valor, 96).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820(30720);
			this.Atualiza_TelaRT820();
			this.AtualizaMsgTela_RT_820("Configuração lida com sucesso", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			this.Timer_limpa_MSG_820.Enabled = true;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x002B3688 File Offset: 0x002B1A88
		public void Leitura_RT_820_200_conf()
		{
			this.InicializaBarraProgressoTela_RT_820(3);
			this.AtualizaMsgTela_RT_820("Identificação de equipamento - Etapa 1", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(0, 255, 4).Status)
			{
				this.AtualizaMsgTela_RT_820("Equipamento não responde", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Linha_RT.VerificaSeEquipamentoEValido(2, 0, 0, 0, 0, "");
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820_200(0);
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 2", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(256, 255, 58).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820_200(256);
			if (RT_geral.RT_820_200_BD.firmware.Build.Valor >= 30)
			{
				RT_geral.RT_820_200_flag_setpoint_horario = true;
			}
			else
			{
				RT_geral.RT_820_200_flag_setpoint_horario = false;
			}
			if (RT_geral.RT_820_200_flag_setpoint_horario)
			{
				if (!Mod_MD.Leitura_pagina(2816, RT_geral.RT_820_200_BD.cfg_geral.End_estacao.Valor, 24).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				Linha_RT.Atualiza_dados_RT_820_200(2816);
			}
			this.AtualizaMsgTela_RT_820("Leitura de configuração - Etapa 3", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(512, RT_geral.RT_820_200_BD.cfg_geral.End_estacao.Valor, 52).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na leitura de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820_200(512);
			this.ToolStripProgressBar_RT_820.PerformStep();
			this.Atualiza_TelaRT820();
			this.AtualizaMsgTela_RT_820("Configuração lida com sucesso", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
			this.Timer_limpa_MSG_820.Enabled = true;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x002B388C File Offset: 0x002B1C8C
		public void Escrita_RT820_conf()
		{
			this.InicializaBarraProgressoTela_RT_820(5);
			this.AtualizaMsgTela_RT_820("Verificando equipamento - Passo 1", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Leitura_pagina(0, 255, 4).Status)
			{
				this.AtualizaMsgTela_RT_820("Equipamento não responde", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Mod_MD.CTRL_RESP_1 ctrl_RESP_ = Linha_RT.VerificaSeEquipamentoEValido(2, 0, 0, 0, 0, "");
			if (!ctrl_RESP_.Status)
			{
				this.AtualizaMsgTela_RT_820(ctrl_RESP_.Msg, ctrl_RESP_.Cor);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			Linha_RT.Atualiza_dados_RT_820_200(0);
			if (RT_geral.RT_820_200_BD.firmware.Build.Valor >= 30)
			{
				RT_geral.RT_820_200_flag_setpoint_horario = true;
			}
			else
			{
				RT_geral.RT_820_200_flag_setpoint_horario = false;
			}
			this.AtualizaMsgTela_RT_820("Habilitando gravação - Passo 2", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Controle_escrita(21845).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro ao habilitar gravação", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Gravando configuração - Passo 3", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (!Mod_MD.Escrita_pagina(256, 30).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			if (!Mod_MD.Controle_escrita(21930).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro durante a gravação", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Gravando configuração - Passo 4", 2);
			this.ToolStripProgressBar_RT_820.PerformStep();
			if (RT_geral.RT_820_200_flag_setpoint_horario)
			{
				if (!Mod_MD.Controle_escrita(21845).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro ao habilitar gravação", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				if (!Mod_MD.Escrita_pagina(2816, 30).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
				if (!Mod_MD.Controle_escrita(21930).Status)
				{
					this.AtualizaMsgTela_RT_820("Erro durante a gravação", 1);
					this.Timer_limpa_MSG_820.Enabled = true;
					return;
				}
			}
			if (!Mod_MD.Controle_escrita(21845).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro ao habilitar gravação", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			if (!Mod_MD.Escrita_pagina(512, 30).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro na escrita de parâmetros", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			if (!Mod_MD.Controle_escrita(21930).Status)
			{
				this.AtualizaMsgTela_RT_820("Erro durante a gravação", 1);
				this.Timer_limpa_MSG_820.Enabled = true;
				return;
			}
			this.AtualizaMsgTela_RT_820("Programação executada com sucesso", 0);
			this.ToolStripProgressBar_RT_820.PerformStep();
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x002B3B50 File Offset: 0x002B1F50
		public void Bloqueia_acoes_RT820()
		{
			this.ToolStripButton_RT_820_Abrir.Enabled = false;
			this.ToolStripButton_RT_820_Download.Enabled = false;
			this.ToolStripButton_RT_820_novo.Enabled = false;
			this.ToolStripButton_RT_820_Salvar.Enabled = false;
			this.ToolStripButton_RT_820_Upload.Enabled = false;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x002B3B90 File Offset: 0x002B1F90
		public void Libera_acoes_RT820()
		{
			this.ToolStripButton_RT_820_Abrir.Enabled = true;
			this.ToolStripButton_RT_820_Download.Enabled = true;
			this.ToolStripButton_RT_820_novo.Enabled = true;
			this.ToolStripButton_RT_820_Salvar.Enabled = true;
			this.ToolStripButton_RT_820_Upload.Enabled = true;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x002B3BD0 File Offset: 0x002B1FD0
		public void EncerraEdicaoDeCampos_RT820()
		{
			this.DataGridView_end_rep_RT820.EndEdit();
			this.DataGridView_periferico_RT820.EndEdit();
			this.DataGridView_RT820_ED.EndEdit();
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x002B3BF8 File Offset: 0x002B1FF8
		private void ToolStripButton_RT820_Imprimir_Click(object sender, EventArgs e)
		{
			this.AtivaEfeitoOnChangeValue();
			using (EnhancedPrintPreviewDialog enhancedPrintPreviewDialog = new EnhancedPrintPreviewDialog())
			{
				enhancedPrintPreviewDialog.Document = this.PrintDocument1;
				enhancedPrintPreviewDialog.ShowDialog();
			}
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x002B3C40 File Offset: 0x002B2040
		private void MyPrintItemClicked(object sender, EventArgs e)
		{
			MessageBox.Show("UIA");
			this.PrintDialog1.AllowSomePages = true;
			this.PrintDialog1.AllowSelection = true;
			this.PrintDialog1.Document = this.PrintDocument1;
			this.PrintPreviewDialog1.Document = this.PrintDocument1;
			this.PrintDialog1.PrinterSettings.Copies = 1;
			this.PrintDialog1.PrinterSettings.FromPage = 1;
			this.PrintDialog1.PrinterSettings.ToPage = 1;
			this.PrintDialog1.AllowCurrentPage = true;
			this.PrintDialog1.ShowNetwork = true;
			this.PrintDialog1.ShowDialog();
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x002B3CEC File Offset: 0x002B20EC
		[MethodImpl(72)]
		private void DesenhaRelatorioRT820Pagina1(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, 3);
			Font font2 = new Font("Calibri", 10f, 3, (FontStyle)3);
			Font font3 = new Font("Calibri", 10f, 0, (FontStyle)3);
			Font fonte = new Font("Calibri", 20f, 1, (FontStyle)3);
			Pen pen = new Pen(Color.Black, 2f);
			FontesTabela fonte2;
			fonte2.Titulo = font2;
			fonte2.Variavel = font3;
			fonte2.Valor = font3;
			CoresTabela cores;
			cores.Titulo = Brushes.Black;
			cores.Variavel = Brushes.Blue;
			cores.Valor = Brushes.DarkBlue;
			cores.Tabela = Color.Black;
			cores.TituloBG = Color.AliceBlue;
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_200_BD.firmware.Equip.Valor, RT_geral.RT_820_200_BD.firmware.Versao.Valor);
			TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, 5, 4, "Dados da Estação", true);
			tabelaLinhaInteria.EscreveTituloValorLinha(1, "Local de Instalação", this.TextBox_nome_RT820.Text, 0, 160);
			tabelaLinhaInteria.EscreveTituloValorLinha(2, "Endereço", this.TextBox_endereco_RT820.Text, 0, 90);
			string valor = "iS800 (" + MyProject.Application.Info.Version.ToString() + ")";
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Configurador", valor, 0, 160);
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Data", string.Concat(new string[]
			{
				DateTime.Today.Day.ToString(),
				"/",
				DateTime.Today.Month.ToString(),
				"/",
				DateTime.Today.Year.ToString()
			}), 450, 530);
			string valor2 = string.Concat(new string[]
			{
				"RT",
				RT_geral.RT_820_200_BD.firmware.Equip.Valor.ToString(),
				"_",
				RT_geral.RT_820_200_BD.firmware.Versao.Valor.ToString(),
				string.Format("{0:D2}", RT_geral.RT_820_200_BD.firmware.Build.Valor),
				"  R",
				RT_geral.RT_820_200_BD.firmware.Release.Valor.ToString()
			});
			tabelaLinhaInteria.EscreveTituloValorLinha(3, "Firmware", valor2, 780, 0);
			tabelaLinhaInteria.EscreveTituloValorLinha(4, "Arquivo", Path.GetFileName(RT_geral.RT_820_200_BD.filename), 0, 0);
			int nextLineAvailable = tabelaLinhaInteria.GetNextLineAvailable();
			TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 6, "Dados de Instalação", true);
			tabelaLinhaInteria2.EscreveTituloValorLinha(1, "Tipo de antena", this.CB_TipoAntena.Text, 0, 150);
			tabelaLinhaInteria2.EscreveTituloValorLinha(1, "Azimute", this.T_Azimute.Text + " °", 400, 500);
			tabelaLinhaInteria2.EscreveTituloValorLinha(2, "Polarização", this.CB_PolarizacaoAntena.Text, 0, 150);
			tabelaLinhaInteria2.EscreveTituloValorLinha(2, "Longitude", this.T_Longitude.Text, 400, 500);
			tabelaLinhaInteria2.EscreveTituloValorLinha(3, "Potência do Rádio", this.T_PotRadio.Text + " W", 0, 150);
			tabelaLinhaInteria2.EscreveTituloValorLinha(3, "Latidude", this.T_Latitude.Text, 400, 500);
			tabelaLinhaInteria2.EscreveTituloValorLinha(4, "Modelo do Rádio", this.CB_ModeloRadio.Text, 0, 150);
			tabelaLinhaInteria2.EscreveTituloValorLinha(4, "Altura", this.T_AlturaAntena.Text + " m", 400, 500);
			tabelaLinhaInteria2.EscreveTituloValorLinha(5, "Distância para Central", this.T_DistCentral.Text + " km", 0, 150);
			tabelaLinhaInteria2.EscreveTituloValorLinha(5, "Modelo da Fonte", this.T_ModeloFonte.Text, 400, 520);
			tabelaLinhaInteria2.EscreveTituloValorLinha(6, "Frequência do Rádio", this.T_FreqRadio.Text + " MHz", 0, 150);
			nextLineAvailable = tabelaLinhaInteria2.GetNextLineAvailable();
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 4, "Parâmetro de Comunicação", true);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(1, "Endereço do Mestre", this.NumericUpDown_end_mestre_820.Value.ToString(), 0, 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(2, "Endereço da Estação", this.NumericUpDown_end_est_820.Value.ToString(), 0, 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(3, "Tempo de PTT (ms)", this.NumericUpDown_temp_ptt_820.Value.ToString() + " ms", 0, 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloValorLinha(4, "BaudRate COM2", this.ComboBox_baudrate_COM2_820.Text, 0, 200);
			nextLineAvailable = tabelaMeiaLinhaEsquerda.GetNextLineAvailable();
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, nextLineAvailable, 2, "Filtro EA", true);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(1, "Intervalo (ms)", this.NumericUpDown_intervalo_filtro_820.Value.ToString() + "ms", 0, 300);
			tabelaMeiaLinhaEsquerda2.EscreveTituloValorLinha(2, "Amostras", this.NumericUpDown_tamanho_filtro_820.Value.ToString(), 0, 200);
			nextLineAvailable = tabelaMeiaLinhaEsquerda2.GetNextLineAvailable();
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda3 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaEsquerda2.GetNextLineAvailable(), 9, "Entrada Digital", true);
			tabelaMeiaLinhaEsquerda3.EscreveTituloLinha(1, "ED", 0);
			tabelaMeiaLinhaEsquerda3.EscreveTituloLinha(1, "Função", 90);
			int num = 0;
			checked
			{
				string valor3;
				do
				{
					valor3 = string.Format("ED 0{0}", num + 1);
					tabelaMeiaLinhaEsquerda3.EscreveValorLinha(num + 2, valor3, 0);
					valor3 = this.DataGridView_RT820_ED.Rows[num].Cells[0].Value.ToString();
					tabelaMeiaLinhaEsquerda3.EscreveValorLinha(num + 2, valor3, 90);
					num++;
				}
				while (num <= 7);
				TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria2.GetNextLineAvailable(), 3, "Variáveis de Controle", true);
				if (this.checkbox_habilita_controle.Checked)
				{
					valor3 = "Sim";
				}
				else
				{
					valor3 = "Não";
				}
				tabelaMeiaLinhaDireita.EscreveTituloValorLinha(1, "Habilita controle nível fonte", valor3, 0, 300);
				tabelaMeiaLinhaDireita.EscreveTituloValorLinha(2, "Proteção", this.cb_Protecao.Text, 0, 200);
				tabelaMeiaLinhaDireita.EscreveTituloValorLinha(3, "Controle", this.cb_Controle.Text, 0, 200);
				TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita2 = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaDireita.GetNextLineAvailable(), 10, "SetPoint", true);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(1, "Motor 1 - Alto", RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Alto.Valor.ToString(), 0, 200);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(2, "Motor 1 - Baixo", RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Baixo.Valor.ToString(), 0, 200);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(3, "Motor 2 - Alto", RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Alto.Valor.ToString(), 0, 200);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(4, "Motor 2 - Baixo", RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Baixo.Valor.ToString(), 0, 200);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(5, "Motor 3 - Alto", RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Alto.Valor.ToString(), 0, 200);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(6, "Motor 3 - Baixo", RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Baixo.Valor.ToString(), 0, 200);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(7, "Motor 4 - Alto", RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Alto.Valor.ToString(), 0, 200);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(8, "Motor 4 - Baixo", RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Baixo.Valor.ToString(), 0, 200);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(9, "Proteção Desliga", RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Desliga.Valor.ToString(), 0, 200);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(10, "Proteção Liga", RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Liga.Valor.ToString(), 0, 200);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x002B4650 File Offset: 0x002B2A50
		private void DesenhaRelatorioRT820Pagina2(PrintPageEventArgs z)
		{
			Font font = new Font("Calibri", 10f, 3);
			Font font2 = new Font("Calibri", 10f, 3, (FontStyle)3);
			Font font3 = new Font("Calibri", 10f, 0, (FontStyle)3);
			Font fonte = new Font("Calibri", 20f, 1, (FontStyle)3);
			Pen pen = new Pen(Color.Black, 2f);
			FontesTabela fonte2;
			fonte2.Titulo = font2;
			fonte2.Variavel = font3;
			fonte2.Valor = font3;
			CoresTabela cores;
			cores.Titulo = Brushes.Black;
			cores.Variavel = Brushes.Blue;
			cores.Valor = Brushes.DarkBlue;
			cores.Tabela = Color.Black;
			cores.TituloBG = Color.AliceBlue;
			Cabecalho cabecalho = new Cabecalho(z.MarginBounds, z.Graphics, fonte, Brushes.Black, RT_geral.RT_820_200_BD.firmware.Equip.Valor, RT_geral.RT_820_200_BD.firmware.Versao.Valor);
			TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, 5, 9, "SetPoint Horário", true);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Ctrl", 0);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Horário", 80);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Ativar", 140);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Hora", 200);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Minuto", 240);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Alto", 350);
			tabelaMeiaLinhaEsquerda.EscreveTituloLinha(1, "Baixo", 400);
			int i = 0;
			checked
			{
				do
				{
					if (i % 2 == 0)
					{
						tabelaMeiaLinhaEsquerda.EscreveTituloLinha(2 + i, string.Format("Controle {0}", unchecked((double)i / 2.0 + 1.0)), 0);
						tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + i, "1", 90);
					}
					else
					{
						tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + i, "2", 90);
					}
					if (RT_geral.RT_820_200_BD.setpoint_horario[i].Hora.Valor > 128)
					{
						tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + i, "Sim", 150);
					}
					else
					{
						tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + i, "Não", 150);
					}
					int j = RT_geral.RT_820_200_BD.setpoint_horario[i].Hora.Valor & 127;
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + i, string.Format("{0}", j), 210);
					j = RT_geral.RT_820_200_BD.setpoint_horario[i].Minuto.Valor;
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + i, string.Format("{0}", j), 250);
					j = RT_geral.RT_820_200_BD.setpoint_horario[i].Alto.Valor;
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + i, string.Format("{0}", j), 360);
					j = RT_geral.RT_820_200_BD.setpoint_horario[i].Baixo.Valor;
					tabelaMeiaLinhaEsquerda.EscreveValorLinha(2 + i, string.Format("{0}", j), 410);
					i++;
				}
				while (i <= 7);
				TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, 5, 5, "Periféricos", true);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Periférico", 0);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Modelo", 100);
				tabelaMeiaLinhaDireita.EscreveTituloLinha(1, "Endereço", 300);
				i = 0;
				do
				{
					string text = string.Format("{0:D2}", i + 1);
					tabelaMeiaLinhaDireita.EscreveTituloLinha(i + 2, text, 0);
					text = "???";
					int num = RT_geral.RT_820_200_BD.cfg_geral.perifericos[i].Equipamento.Valor - 48;
					if (num <= perifericos.perif_RT820_200.Count)
					{
						text = perifericos.perif_RT820_200[num].nome_impressao;
					}
					tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, text, 105);
					tabelaMeiaLinhaDireita.EscreveValorLinha(i + 2, RT_geral.RT_820_200_BD.cfg_geral.perifericos[i].End_Quant.Valor.ToString(), 320);
					i++;
				}
				while (i <= 3);
				TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita2 = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaDireita.GetNextLineAvailable(), 5, "Motores & Válvulas", true);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(1, "Modo de Operação", this.cb_modo_operacao.Text, 0, 200);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(2, "Número de motores", RT_geral.RT_820_200_BD.cfg_geral.quantidade_motores.Valor.ToString(), 0, 200);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(3, "Número de válvulas", RT_geral.RT_820_200_BD.cfg_geral.quantidade_valvulas.Valor.ToString(), 0, 200);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(4, "Número bombas simultâneas", RT_geral.RT_820_200_BD.cfg_geral.bombas_simultaneas.Valor.ToString(), 0, 200);
				tabelaMeiaLinhaDireita2.EscreveTituloValorLinha(5, "Tempo entre operações", RT_geral.RT_820_200_BD.cfg_geral.tempo_acionamentos.Valor.ToString(), 0, 200);
				TabelaMeiaLinhaEsquerda tabelaMeiaLinhaEsquerda2 = new TabelaMeiaLinhaEsquerda(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaDireita2.GetNextLineAvailable(), 5, "Motores", true);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "Motor", 0);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "Modo Controle", 80);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "Tempo Partida", 230);
				tabelaMeiaLinhaEsquerda2.EscreveTituloLinha(1, "Tempo Parada", 350);
				i = 0;
				do
				{
					tabelaMeiaLinhaEsquerda2.EscreveValorLinha(i + 2, "Motor" + Conversion.Str(i + 1), 5);
					tabelaMeiaLinhaEsquerda2.EscreveValorLinha(i + 2, RT_geral.RT_820_200_BD.cfg_geral.modo_partida[i].itens[RT_geral.RT_820_200_BD.cfg_geral.modo_partida[i].Indice], 90);
					i++;
				}
				while (i <= 3);
				tabelaMeiaLinhaEsquerda2.EscreveValorLinha(2, RT_geral.RT_820_200_BD.cfg_geral.partida.Motor1.Valor.ToString(), 240);
				tabelaMeiaLinhaEsquerda2.EscreveValorLinha(3, RT_geral.RT_820_200_BD.cfg_geral.partida.Motor2.Valor.ToString(), 240);
				tabelaMeiaLinhaEsquerda2.EscreveValorLinha(4, RT_geral.RT_820_200_BD.cfg_geral.partida.Motor3.Valor.ToString(), 240);
				tabelaMeiaLinhaEsquerda2.EscreveValorLinha(5, RT_geral.RT_820_200_BD.cfg_geral.partida.Motor4.Valor.ToString(), 240);
				tabelaMeiaLinhaEsquerda2.EscreveValorLinha(2, RT_geral.RT_820_200_BD.cfg_geral.parada.Motor1.Valor.ToString(), 360);
				tabelaMeiaLinhaEsquerda2.EscreveValorLinha(3, RT_geral.RT_820_200_BD.cfg_geral.parada.Motor2.Valor.ToString(), 360);
				tabelaMeiaLinhaEsquerda2.EscreveValorLinha(4, RT_geral.RT_820_200_BD.cfg_geral.parada.Motor3.Valor.ToString(), 360);
				tabelaMeiaLinhaEsquerda2.EscreveValorLinha(5, RT_geral.RT_820_200_BD.cfg_geral.parada.Motor4.Valor.ToString(), 360);
				TabelaMeiaLinhaDireita tabelaMeiaLinhaDireita3 = new TabelaMeiaLinhaDireita(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaDireita2.GetNextLineAvailable(), 5, "Válvulas", true);
				tabelaMeiaLinhaDireita3.EscreveTituloLinha(1, "Válvula", 0);
				tabelaMeiaLinhaDireita3.EscreveTituloLinha(1, "Tempo Abertura", 80);
				tabelaMeiaLinhaDireita3.EscreveTituloLinha(1, "Tempo Fechamento", 230);
				i = 0;
				do
				{
					tabelaMeiaLinhaDireita3.EscreveValorLinha(i + 2, "Válvula" + Conversion.Str(i + 1), 5);
					i++;
				}
				while (i <= 3);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(2, RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula1.Valor.ToString(), 90);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(3, RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula2.Valor.ToString(), 90);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(4, RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula3.Valor.ToString(), 90);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(5, RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula4.Valor.ToString(), 90);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(2, RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula1.Valor.ToString(), 240);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(3, RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula2.Valor.ToString(), 240);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(4, RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula3.Valor.ToString(), 240);
				tabelaMeiaLinhaDireita3.EscreveValorLinha(5, RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula4.Valor.ToString(), 240);
				TabelaLinhaInteria tabelaLinhaInteria = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaMeiaLinhaDireita3.GetNextLineAvailable(), 1, "Repetidora", true);
				string valor = "???";
				int valor2 = RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.Valor;
				if (valor2 == 0)
				{
					valor = "Desabilitado";
				}
				else if (valor2 == 21856)
				{
					valor = "Repetidora Direta";
				}
				tabelaLinhaInteria.EscreveTituloValorLinha(1, "Modo", valor, 0, 60);
				tabelaLinhaInteria.EscreveTituloValorLinha(1, "End. Mestre", RT_geral.RT_820_200_BD.repetidora.End_repetidora.Valor.ToString(), 240, 320);
				tabelaLinhaInteria.EscreveTituloValorLinha(1, "Quantidade End. Repetidos", RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.Valor.ToString(), 410, 600);
				int num2 = RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.Valor / 20;
				if (RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.Valor > 0)
				{
					if (RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.Valor % 20 != 0)
					{
						num2++;
					}
					int num3 = 1;
					int num4 = num2;
					for (i = num3; i <= num4; i++)
					{
						tabelaLinhaInteria.AdicionaLinha();
						string text2 = "";
						int num5 = (i - 1) * 20;
						int num6 = (i - 1) * 20 + 19;
						for (int j = num5; j <= num6; j++)
						{
							if (j + 1 < RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.Valor)
							{
								text2 = text2 + RT_geral.RT_820_200_BD.repetidora.Repetidoras[j].Valor.ToString() + ", ";
							}
							else if (j + 1 == RT_geral.RT_820_200_BD.repetidora.Num_repetidoras.Valor)
							{
								text2 += RT_geral.RT_820_200_BD.repetidora.Repetidoras[j].Valor.ToString();
								break;
							}
						}
						tabelaLinhaInteria.EscreveValorLinha(i + 1, text2, 50);
					}
				}
				TabelaLinhaInteria tabelaLinhaInteria2 = new TabelaLinhaInteria(z.MarginBounds, z.Graphics, fonte2, cores, tabelaLinhaInteria.GetNextLineAvailable(), 3, "Comentários", true);
				tabelaLinhaInteria2.EscreveValorLinha(1, this.TextBox_comentarios_RT820.Text, 0);
				RodapeICTEL rodapeICTEL = new RodapeICTEL(z.MarginBounds, z.Graphics, font2, Brushes.Black, this.pagina_impressao);
			}
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x002B5214 File Offset: 0x002B3614
		private bool DesenhaRelatorio(PrintPageEventArgs z)
		{
			checked
			{
				switch (this.pagina_impressao)
				{
				case 1:
					this.DesenhaRelatorioRT820Pagina1(z);
					this.pagina_impressao++;
					return true;
				case 2:
					this.DesenhaRelatorioRT820Pagina2(z);
					this.pagina_impressao++;
					return false;
				case 3:
					return false;
				default:
					return false;
				}
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x002B5270 File Offset: 0x002B3670
		private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.HasMorePages = this.DesenhaRelatorio(e);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x002B5280 File Offset: 0x002B3680
		private void PrintDocument1_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
		{
			switch (this.pagina_impressao)
			{
			case 1:
				e.PageSettings.Landscape = true;
				break;
			case 2:
				e.PageSettings.Landscape = true;
				break;
			case 3:
				e.PageSettings.Landscape = true;
				break;
			}
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x002B52D0 File Offset: 0x002B36D0
		private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
		{
			this.pagina_impressao = 1;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x002B52DC File Offset: 0x002B36DC
		private void cb_ModoRepetidora_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (this.cb_ModoRepetidora.SelectedIndex)
			{
			case 0:
				this.NumericUpDown_end_rep_820.Enabled = false;
				this.NumericUpDown_num_est_rep_820.Enabled = false;
				this.GroupBox_end_rep_820.Visible = false;
				break;
			case 1:
				this.NumericUpDown_end_rep_820.Enabled = true;
				this.NumericUpDown_num_est_rep_820.Enabled = true;
				this.GroupBox_end_rep_820.Visible = true;
				break;
			}
			RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.Valor = RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.valores[this.cb_ModoRepetidora.SelectedIndex];
			RT_geral.RT_820_200_BD.cfg_geral.modo_repetidora.Indice = this.cb_ModoRepetidora.SelectedIndex;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x002B53A0 File Offset: 0x002B37A0
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.checkbox_habilita_controle.Checked)
			{
				this.cb_Protecao.Enabled = false;
				RT_geral.RT_820_200_BD.cfg_geral.nivel_fonte.Valor = 0;
			}
			else
			{
				this.cb_Protecao.Enabled = true;
				RT_geral.RT_820_200_BD.cfg_geral.nivel_fonte.Valor = 21921;
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x002B5404 File Offset: 0x002B3804
		private void NumericUpDown22_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.parada.Motor2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x002B543C File Offset: 0x002B383C
		private void cb_modo_operacao_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_820_200_BD.cfg_geral.modo_operacao.AtualizaValorPeloIndice();
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x002B548C File Offset: 0x002B388C
		private void cb_Protecao_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_820_200_BD.cfg_geral.origem_protecao.AtualizaValorPeloIndice();
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x002B54DC File Offset: 0x002B38DC
		private void cb_Controle_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
			RT_geral.RT_820_200_BD.cfg_geral.origem_controle.AtualizaValorPeloIndice();
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x002B552C File Offset: 0x002B392C
		private void nud_motor1_alto_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Alto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x002B5564 File Offset: 0x002B3964
		private void nud_motor1_baixo_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.setpoints.M1_Baixo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x002B559C File Offset: 0x002B399C
		private void nud_motor2_alto_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Alto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x002B55D4 File Offset: 0x002B39D4
		private void nud_motor2_baixo_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.setpoints.M2_Baixo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x002B560C File Offset: 0x002B3A0C
		private void nud_motor3_alto_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Alto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x002B5644 File Offset: 0x002B3A44
		private void nud_motor3_baixo_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.setpoints.M3_Baixo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x002B567C File Offset: 0x002B3A7C
		private void nud_motor4_alto_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Alto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x002B56B4 File Offset: 0x002B3AB4
		private void nud_motor4_baixo_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.setpoints.M4_Baixo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x002B56EC File Offset: 0x002B3AEC
		private void nud_protecao_desliga_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Desliga.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x002B5724 File Offset: 0x002B3B24
		private void nud_protecao_liga_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.setpoints.Protecao_Liga.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x002B575C File Offset: 0x002B3B5C
		private void nud_numero_motores_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.quantidade_motores.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.cb_modo_partida1.Enabled = false;
			this.nud_partida1.Enabled = false;
			this.nud_parada1.Enabled = false;
			this.cb_modo_partida2.Enabled = false;
			this.nud_partida2.Enabled = false;
			this.nud_parada2.Enabled = false;
			this.cb_modo_partida3.Enabled = false;
			this.nud_partida3.Enabled = false;
			this.nud_parada3.Enabled = false;
			this.cb_modo_partida4.Enabled = false;
			this.nud_partida4.Enabled = false;
			this.nud_parada4.Enabled = false;
			object obj = NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(obj, 1, false))
			{
				this.cb_modo_partida1.Enabled = true;
				this.nud_partida1.Enabled = true;
				this.nud_parada1.Enabled = true;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 2, false))
			{
				this.cb_modo_partida1.Enabled = true;
				this.nud_partida1.Enabled = true;
				this.nud_parada1.Enabled = true;
				this.cb_modo_partida2.Enabled = true;
				this.nud_partida2.Enabled = true;
				this.nud_parada2.Enabled = true;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 3, false))
			{
				this.cb_modo_partida1.Enabled = true;
				this.nud_partida1.Enabled = true;
				this.nud_parada1.Enabled = true;
				this.cb_modo_partida2.Enabled = true;
				this.nud_partida2.Enabled = true;
				this.nud_parada2.Enabled = true;
				this.cb_modo_partida3.Enabled = true;
				this.nud_partida3.Enabled = true;
				this.nud_parada3.Enabled = true;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 4, false))
			{
				this.cb_modo_partida1.Enabled = true;
				this.nud_partida1.Enabled = true;
				this.nud_parada1.Enabled = true;
				this.cb_modo_partida2.Enabled = true;
				this.nud_partida2.Enabled = true;
				this.nud_parada2.Enabled = true;
				this.cb_modo_partida3.Enabled = true;
				this.nud_partida3.Enabled = true;
				this.nud_parada3.Enabled = true;
				this.cb_modo_partida4.Enabled = true;
				this.nud_partida4.Enabled = true;
				this.nud_parada4.Enabled = true;
			}
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x002B59F4 File Offset: 0x002B3DF4
		private void nud_numero_valvulas_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.quantidade_valvulas.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			this.nud_valvula1_abertura.Enabled = false;
			this.nud_valvula1_fechamento.Enabled = false;
			this.nud_valvula2_abertura.Enabled = false;
			this.nud_valvula2_fechamento.Enabled = false;
			this.nud_valvula3_abertura.Enabled = false;
			this.nud_valvula3_fechamento.Enabled = false;
			this.nud_valvula4_abertura.Enabled = false;
			this.nud_valvula4_fechamento.Enabled = false;
			object obj = NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null);
			if (Operators.ConditionalCompareObjectEqual(obj, 1, false))
			{
				this.nud_valvula1_abertura.Enabled = true;
				this.nud_valvula1_fechamento.Enabled = true;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 2, false))
			{
				this.nud_valvula1_abertura.Enabled = true;
				this.nud_valvula1_fechamento.Enabled = true;
				this.nud_valvula2_abertura.Enabled = true;
				this.nud_valvula2_fechamento.Enabled = true;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 3, false))
			{
				this.nud_valvula1_abertura.Enabled = true;
				this.nud_valvula1_fechamento.Enabled = true;
				this.nud_valvula2_abertura.Enabled = true;
				this.nud_valvula2_fechamento.Enabled = true;
				this.nud_valvula3_abertura.Enabled = true;
				this.nud_valvula3_fechamento.Enabled = true;
			}
			else if (Operators.ConditionalCompareObjectEqual(obj, 4, false))
			{
				this.nud_valvula1_abertura.Enabled = true;
				this.nud_valvula1_fechamento.Enabled = true;
				this.nud_valvula2_abertura.Enabled = true;
				this.nud_valvula2_fechamento.Enabled = true;
				this.nud_valvula3_abertura.Enabled = true;
				this.nud_valvula3_fechamento.Enabled = true;
				this.nud_valvula4_abertura.Enabled = true;
				this.nud_valvula4_fechamento.Enabled = true;
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x002B5BE0 File Offset: 0x002B3FE0
		private void nud_bombas_simultaneas_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.bombas_simultaneas.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x002B5C10 File Offset: 0x002B4010
		private void nud_tempo_operacoes_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.tempo_acionamentos.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x002B5C40 File Offset: 0x002B4040
		private void cb_modo_partida1_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida[0].Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null));
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida[0].AtualizaValorPeloIndice();
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x002B5C9C File Offset: 0x002B409C
		private void cb_modo_partida2_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida[1].Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null));
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida[1].AtualizaValorPeloIndice();
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x002B5CF8 File Offset: 0x002B40F8
		private void cb_modo_partida3_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida[2].Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null));
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida[2].AtualizaValorPeloIndice();
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x002B5D54 File Offset: 0x002B4154
		private void cb_modo_partida4_SelectedIndexChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida[3].Indice = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "selectedindex", new object[0], null, null, null));
			RT_geral.RT_820_200_BD.cfg_geral.modo_partida[3].AtualizaValorPeloIndice();
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x002B5DB0 File Offset: 0x002B41B0
		private void nud_partida1_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.partida.Motor1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x002B5DE8 File Offset: 0x002B41E8
		private void nud_partida2_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.partida.Motor2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x002B5E20 File Offset: 0x002B4220
		private void nud_partida3_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.partida.Motor3.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x002B5E58 File Offset: 0x002B4258
		private void nud_partida4_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.partida.Motor4.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x002B5E90 File Offset: 0x002B4290
		private void nud_parada1_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.parada.Motor1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x002B5EC8 File Offset: 0x002B42C8
		private void nud_parada3_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.parada.Motor3.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x002B5F00 File Offset: 0x002B4300
		private void nud_parada4_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.parada.Motor4.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x002B5F38 File Offset: 0x002B4338
		private void nud_valvula1_abertura_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x002B5F70 File Offset: 0x002B4370
		private void nud_valvula2_abertura_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x002B5FA8 File Offset: 0x002B43A8
		private void nud_valvula3_abertura_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula3.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x002B5FE0 File Offset: 0x002B43E0
		private void nud_valvula4_abertura_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.abertura.Valvula4.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x002B6018 File Offset: 0x002B4418
		private void nud_valvula1_fechamento_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula1.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x002B6050 File Offset: 0x002B4450
		private void nud_valvula2_fechamento_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula2.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x002B6088 File Offset: 0x002B4488
		private void nud_valvula3_fechamento_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula3.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x002B60C0 File Offset: 0x002B44C0
		private void nud_valvula4_fechamento_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.cfg_geral.fechamento.Valvula4.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x002B60F8 File Offset: 0x002B44F8
		private void sph_baixo10_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[0].Baixo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[0].Baixo, true);
			sender = numericUpDown;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x002B6164 File Offset: 0x002B4564
		private void sph_baixo11_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[1].Baixo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[1].Baixo, true);
			sender = numericUpDown;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x002B61D0 File Offset: 0x002B45D0
		private void sph_baixo20_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[2].Baixo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[2].Baixo, true);
			sender = numericUpDown;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x002B623C File Offset: 0x002B463C
		private void sph_baixo21_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[3].Baixo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[3].Baixo, true);
			sender = numericUpDown;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x002B62A8 File Offset: 0x002B46A8
		private void sph_baixo30_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[4].Baixo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[4].Baixo, true);
			sender = numericUpDown;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x002B6314 File Offset: 0x002B4714
		private void sph_baixo31_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[5].Baixo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[5].Baixo, true);
			sender = numericUpDown;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x002B6380 File Offset: 0x002B4780
		private void sph_baixo40_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[6].Baixo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[6].Baixo, true);
			sender = numericUpDown;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x002B63EC File Offset: 0x002B47EC
		private void sph_baixo41_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[7].Baixo.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[7].Baixo, true);
			sender = numericUpDown;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x002B6458 File Offset: 0x002B4858
		private void sph_alto10_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[0].Alto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[0].Alto, true);
			sender = numericUpDown;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x002B64C4 File Offset: 0x002B48C4
		private void sph_alto11_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[1].Alto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[1].Alto, true);
			sender = numericUpDown;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x002B6530 File Offset: 0x002B4930
		private void sph_alto20_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[2].Alto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[2].Alto, true);
			sender = numericUpDown;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x002B659C File Offset: 0x002B499C
		private void sph_alto21_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[3].Alto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[3].Alto, true);
			sender = numericUpDown;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x002B6608 File Offset: 0x002B4A08
		private void sph_alto30_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[4].Alto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[4].Alto, true);
			sender = numericUpDown;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x002B6674 File Offset: 0x002B4A74
		private void sph_alto31_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[5].Alto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[5].Alto, true);
			sender = numericUpDown;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x002B66E0 File Offset: 0x002B4AE0
		private void sph_alto40_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[6].Alto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[6].Alto, true);
			sender = numericUpDown;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x002B674C File Offset: 0x002B4B4C
		private void sph_alto41_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[7].Alto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[7].Alto, true);
			sender = numericUpDown;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x002B67B8 File Offset: 0x002B4BB8
		private void sph_minuto10_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[0].Minuto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[0].Minuto, true);
			sender = numericUpDown;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x002B6824 File Offset: 0x002B4C24
		private void sph_minuto11_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[1].Minuto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[1].Minuto, true);
			sender = numericUpDown;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x002B6890 File Offset: 0x002B4C90
		private void sph_minuto20_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[2].Minuto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[2].Minuto, true);
			sender = numericUpDown;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x002B68FC File Offset: 0x002B4CFC
		private void sph_minuto21_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[3].Minuto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[3].Minuto, true);
			sender = numericUpDown;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x002B6968 File Offset: 0x002B4D68
		private void sph_minuto30_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[4].Minuto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[4].Minuto, true);
			sender = numericUpDown;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x002B69D4 File Offset: 0x002B4DD4
		private void sph_minuto31_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[5].Minuto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[5].Minuto, true);
			sender = numericUpDown;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x002B6A40 File Offset: 0x002B4E40
		private void sph_minuto40_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[6].Minuto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[6].Minuto, true);
			sender = numericUpDown;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x002B6AAC File Offset: 0x002B4EAC
		private void sph_minuto41_ValueChanged(object sender, EventArgs e)
		{
			RT_geral.RT_820_200_BD.setpoint_horario[7].Minuto.Valor = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null));
			NumericUpDown numericUpDown = (NumericUpDown)sender;
			RT_geral.Limite_ok_NumericUpDown(ref numericUpDown, ref RT_geral.RT_820_200_BD.setpoint_horario[7].Minuto, true);
			sender = numericUpDown;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x002B6B18 File Offset: 0x002B4F18
		private void sph_ativa10_CheckedChanged(object sender, EventArgs e)
		{
			object obj = 0;
			int num = RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor;
			if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null)))
			{
				num |= 128;
			}
			else
			{
				num &= 127;
			}
			RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor = num;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x002B6B98 File Offset: 0x002B4F98
		private void sph_ativa11_CheckedChanged(object sender, EventArgs e)
		{
			object obj = 1;
			int num = RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor;
			if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null)))
			{
				num |= 128;
			}
			else
			{
				num &= 127;
			}
			RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor = num;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x002B6C18 File Offset: 0x002B5018
		private void sph_ativa20_CheckedChanged(object sender, EventArgs e)
		{
			object obj = 2;
			int num = RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor;
			if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null)))
			{
				num |= 128;
			}
			else
			{
				num &= 127;
			}
			RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor = num;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x002B6C98 File Offset: 0x002B5098
		private void sph_ativa21_CheckedChanged(object sender, EventArgs e)
		{
			object obj = 3;
			int num = RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor;
			if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null)))
			{
				num |= 128;
			}
			else
			{
				num &= 127;
			}
			RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor = num;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x002B6D18 File Offset: 0x002B5118
		private void sph_ativa30_CheckedChanged(object sender, EventArgs e)
		{
			object obj = 4;
			int num = RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor;
			if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null)))
			{
				num |= 128;
			}
			else
			{
				num &= 127;
			}
			RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor = num;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x002B6D98 File Offset: 0x002B5198
		private void sph_ativa31_CheckedChanged(object sender, EventArgs e)
		{
			object obj = 5;
			int num = RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor;
			if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null)))
			{
				num |= 128;
			}
			else
			{
				num &= 127;
			}
			RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor = num;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x002B6E18 File Offset: 0x002B5218
		private void sph_ativa40_CheckedChanged(object sender, EventArgs e)
		{
			object obj = 6;
			int num = RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor;
			if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null)))
			{
				num |= 128;
			}
			else
			{
				num &= 127;
			}
			RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor = num;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x002B6E98 File Offset: 0x002B5298
		private void sph_ativa41_CheckedChanged(object sender, EventArgs e)
		{
			object obj = 7;
			int num = RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor;
			if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null)))
			{
				num |= 128;
			}
			else
			{
				num &= 127;
			}
			RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor = num;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x002B6F18 File Offset: 0x002B5318
		private void sph_hora10_ValueChanged(object sender, EventArgs e)
		{
			object obj = 0;
			int num = RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor & 128;
			RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor = Conversions.ToInteger(Operators.AddObject(num, NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null)));
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x002B6F98 File Offset: 0x002B5398
		private void sph_hora11_ValueChanged(object sender, EventArgs e)
		{
			object obj = 1;
			int num = RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor & 128;
			RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor = Conversions.ToInteger(Operators.AddObject(num, NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null)));
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x002B7018 File Offset: 0x002B5418
		private void sph_hora20_ValueChanged(object sender, EventArgs e)
		{
			object obj = 2;
			int num = RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor & 128;
			RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor = Conversions.ToInteger(Operators.AddObject(num, NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null)));
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x002B7098 File Offset: 0x002B5498
		private void sph_hora21_ValueChanged(object sender, EventArgs e)
		{
			object obj = 3;
			int num = RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor & 128;
			RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor = Conversions.ToInteger(Operators.AddObject(num, NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null)));
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x002B7118 File Offset: 0x002B5518
		private void sph_hora30_ValueChanged(object sender, EventArgs e)
		{
			object obj = 4;
			int num = RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor & 128;
			RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor = Conversions.ToInteger(Operators.AddObject(num, NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null)));
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x002B7198 File Offset: 0x002B5598
		private void sph_hora31_ValueChanged(object sender, EventArgs e)
		{
			object obj = 5;
			int num = RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor & 128;
			RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor = Conversions.ToInteger(Operators.AddObject(num, NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null)));
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x002B7218 File Offset: 0x002B5618
		private void sph_hora40_ValueChanged(object sender, EventArgs e)
		{
			object obj = 6;
			int num = RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor & 128;
			RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor = Conversions.ToInteger(Operators.AddObject(num, NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null)));
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x002B7298 File Offset: 0x002B5698
		private void sph_hora41_ValueChanged(object sender, EventArgs e)
		{
			object obj = 7;
			int num = RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor & 128;
			RT_geral.RT_820_200_BD.setpoint_horario[Conversions.ToInteger(obj)].Hora.Valor = Conversions.ToInteger(Operators.AddObject(num, NewLateBinding.LateGet(sender, null, "value", new object[0], null, null, null)));
		}

		// Token: 0x0400050E RID: 1294
		[AccessedThroughProperty("GroupBox_sistema_leitura")]
		private GroupBox _GroupBox_sistema_leitura;

		// Token: 0x0400050F RID: 1295
		[AccessedThroughProperty("CheckBox_hab_eletrodos")]
		private CheckBox _CheckBox_hab_eletrodos;

		// Token: 0x04000510 RID: 1296
		[AccessedThroughProperty("GroupBox_operacao")]
		private GroupBox _GroupBox_operacao;

		// Token: 0x04000511 RID: 1297
		[AccessedThroughProperty("ComboBox_metodo_operacao")]
		private ComboBox _ComboBox_metodo_operacao;

		// Token: 0x04000512 RID: 1298
		[AccessedThroughProperty("NumericUpDown_intervalo_tx")]
		private NumericUpDown _NumericUpDown_intervalo_tx;

		// Token: 0x04000513 RID: 1299
		[AccessedThroughProperty("Label_metodo_operacao")]
		private Label _Label_metodo_operacao;

		// Token: 0x04000514 RID: 1300
		[AccessedThroughProperty("Label_intevalo_tx_pto_pto")]
		private Label _Label_intevalo_tx_pto_pto;

		// Token: 0x04000515 RID: 1301
		[AccessedThroughProperty("GroupBox_informacoes")]
		private GroupBox _GroupBox_informacoes;

		// Token: 0x04000516 RID: 1302
		[AccessedThroughProperty("TextBox_equipamento")]
		private TextBox _TextBox_equipamento;

		// Token: 0x04000517 RID: 1303
		[AccessedThroughProperty("Label_equipamento")]
		private Label _Label_equipamento;

		// Token: 0x04000518 RID: 1304
		[AccessedThroughProperty("TextBox_release")]
		private TextBox _TextBox_release;

		// Token: 0x04000519 RID: 1305
		[AccessedThroughProperty("Label_release")]
		private Label _Label_release;

		// Token: 0x0400051A RID: 1306
		[AccessedThroughProperty("TextBox_build")]
		private TextBox _TextBox_build;

		// Token: 0x0400051B RID: 1307
		[AccessedThroughProperty("Label_build")]
		private Label _Label_build;

		// Token: 0x0400051C RID: 1308
		[AccessedThroughProperty("TextBox_versao")]
		private TextBox _TextBox_versao;

		// Token: 0x0400051D RID: 1309
		[AccessedThroughProperty("Label_versao")]
		private Label _Label_versao;

		// Token: 0x0400051E RID: 1310
		[AccessedThroughProperty("GroupBox_modelo_simulado")]
		private GroupBox _GroupBox_modelo_simulado;

		// Token: 0x0400051F RID: 1311
		[AccessedThroughProperty("ComboBox_modo_simulado")]
		private ComboBox _ComboBox_modo_simulado;

		// Token: 0x04000520 RID: 1312
		[AccessedThroughProperty("GroupBox_comunicacao")]
		private GroupBox _GroupBox_comunicacao;

		// Token: 0x04000521 RID: 1313
		[AccessedThroughProperty("NumericUpDown_temp_ptt")]
		private NumericUpDown _NumericUpDown_temp_ptt;

		// Token: 0x04000522 RID: 1314
		[AccessedThroughProperty("NumericUpDown_end_mestre")]
		private NumericUpDown _NumericUpDown_end_mestre;

		// Token: 0x04000523 RID: 1315
		[AccessedThroughProperty("NumericUpDown_end_est")]
		private NumericUpDown _NumericUpDown_end_est;

		// Token: 0x04000524 RID: 1316
		[AccessedThroughProperty("Label_tempo_ptt")]
		private Label _Label_tempo_ptt;

		// Token: 0x04000525 RID: 1317
		[AccessedThroughProperty("Label_end_mestre")]
		private Label _Label_end_mestre;

		// Token: 0x04000526 RID: 1318
		[AccessedThroughProperty("Label_end_est")]
		private Label _Label_end_est;

		// Token: 0x04000527 RID: 1319
		[AccessedThroughProperty("OpenFileDialog_RT_820")]
		private OpenFileDialog _OpenFileDialog_RT_820;

		// Token: 0x04000528 RID: 1320
		[AccessedThroughProperty("SaveFileDialog_RT_820")]
		private SaveFileDialog _SaveFileDialog_RT_820;

		// Token: 0x04000529 RID: 1321
		[AccessedThroughProperty("TabControl_820")]
		private TabControl _TabControl_820;

		// Token: 0x0400052A RID: 1322
		[AccessedThroughProperty("TabPage_geral")]
		private TabPage _TabPage_geral;

		// Token: 0x0400052B RID: 1323
		[AccessedThroughProperty("GroupBox_informacoes_820")]
		private GroupBox _GroupBox_informacoes_820;

		// Token: 0x0400052C RID: 1324
		[AccessedThroughProperty("GroupBox_comunicacao_820")]
		private GroupBox _GroupBox_comunicacao_820;

		// Token: 0x0400052D RID: 1325
		[AccessedThroughProperty("NumericUpDown_temp_ptt_820")]
		private NumericUpDown _NumericUpDown_temp_ptt_820;

		// Token: 0x0400052E RID: 1326
		[AccessedThroughProperty("NumericUpDown_end_mestre_820")]
		private NumericUpDown _NumericUpDown_end_mestre_820;

		// Token: 0x0400052F RID: 1327
		[AccessedThroughProperty("NumericUpDown_end_est_820")]
		private NumericUpDown _NumericUpDown_end_est_820;

		// Token: 0x04000530 RID: 1328
		[AccessedThroughProperty("Label_tempo_ptt_820")]
		private Label _Label_tempo_ptt_820;

		// Token: 0x04000531 RID: 1329
		[AccessedThroughProperty("Label_end_mestre_820")]
		private Label _Label_end_mestre_820;

		// Token: 0x04000532 RID: 1330
		[AccessedThroughProperty("Label_end_est_820")]
		private Label _Label_end_est_820;

		// Token: 0x04000533 RID: 1331
		[AccessedThroughProperty("TabPage_EA")]
		private TabPage _TabPage_EA;

		// Token: 0x04000534 RID: 1332
		[AccessedThroughProperty("GroupBox_EA_820")]
		private GroupBox _GroupBox_EA_820;

		// Token: 0x04000535 RID: 1333
		[AccessedThroughProperty("NumericUpDown_intervalo_filtro_820")]
		private NumericUpDown _NumericUpDown_intervalo_filtro_820;

		// Token: 0x04000536 RID: 1334
		[AccessedThroughProperty("NumericUpDown_tamanho_filtro_820")]
		private NumericUpDown _NumericUpDown_tamanho_filtro_820;

		// Token: 0x04000537 RID: 1335
		[AccessedThroughProperty("Label_intervalo_filtro_820")]
		private Label _Label_intervalo_filtro_820;

		// Token: 0x04000538 RID: 1336
		[AccessedThroughProperty("Label_tamanho_filtro_820")]
		private Label _Label_tamanho_filtro_820;

		// Token: 0x04000539 RID: 1337
		[AccessedThroughProperty("TabPage_ED")]
		private TabPage _TabPage_ED;

		// Token: 0x0400053A RID: 1338
		[AccessedThroughProperty("TabPage_setpoints")]
		private TabPage _TabPage_setpoints;

		// Token: 0x0400053B RID: 1339
		[AccessedThroughProperty("TabPage_vazao_perifericos")]
		private TabPage _TabPage_vazao_perifericos;

		// Token: 0x0400053C RID: 1340
		[AccessedThroughProperty("TabPage_repetidora")]
		private TabPage _TabPage_repetidora;

		// Token: 0x0400053D RID: 1341
		[AccessedThroughProperty("GroupBox_end_rep_820")]
		private GroupBox _GroupBox_end_rep_820;

		// Token: 0x0400053E RID: 1342
		[AccessedThroughProperty("DataGridView_end_rep_RT820")]
		private DataGridView _DataGridView_end_rep_RT820;

		// Token: 0x0400053F RID: 1343
		[AccessedThroughProperty("GroupBox_parametros_repetidora_820")]
		private GroupBox _GroupBox_parametros_repetidora_820;

		// Token: 0x04000540 RID: 1344
		[AccessedThroughProperty("NumericUpDown_num_est_rep_820")]
		private NumericUpDown _NumericUpDown_num_est_rep_820;

		// Token: 0x04000541 RID: 1345
		[AccessedThroughProperty("NumericUpDown_end_rep_820")]
		private NumericUpDown _NumericUpDown_end_rep_820;

		// Token: 0x04000542 RID: 1346
		[AccessedThroughProperty("Label_num_est_rep_820")]
		private Label _Label_num_est_rep_820;

		// Token: 0x04000543 RID: 1347
		[AccessedThroughProperty("Label_end_rep_820")]
		private Label _Label_end_rep_820;

		// Token: 0x04000544 RID: 1348
		[AccessedThroughProperty("ToolStri_RT_820")]
		private ToolStrip _ToolStri_RT_820;

		// Token: 0x04000545 RID: 1349
		[AccessedThroughProperty("ToolStripButton_RT_820_novo")]
		private ToolStripButton _ToolStripButton_RT_820_novo;

		// Token: 0x04000546 RID: 1350
		[AccessedThroughProperty("ToolStripButton_RT_820_Abrir")]
		private ToolStripButton _ToolStripButton_RT_820_Abrir;

		// Token: 0x04000547 RID: 1351
		[AccessedThroughProperty("ToolStripButton_RT_820_Salvar")]
		private ToolStripButton _ToolStripButton_RT_820_Salvar;

		// Token: 0x04000548 RID: 1352
		[AccessedThroughProperty("ToolStripSeparator1")]
		private ToolStripSeparator _ToolStripSeparator1;

		// Token: 0x04000549 RID: 1353
		[AccessedThroughProperty("ToolStripButton_RT_820_Download")]
		private ToolStripButton _ToolStripButton_RT_820_Download;

		// Token: 0x0400054A RID: 1354
		[AccessedThroughProperty("ToolStripButton_RT_820_Upload")]
		private ToolStripButton _ToolStripButton_RT_820_Upload;

		// Token: 0x0400054B RID: 1355
		[AccessedThroughProperty("ToolStripSeparator2")]
		private ToolStripSeparator _ToolStripSeparator2;

		// Token: 0x0400054C RID: 1356
		[AccessedThroughProperty("ToolStripTextBox_RT_820_Msg")]
		private ToolStripTextBox _ToolStripTextBox_RT_820_Msg;

		// Token: 0x0400054D RID: 1357
		[AccessedThroughProperty("ToolStripProgressBar_RT_820")]
		private ToolStripProgressBar _ToolStripProgressBar_RT_820;

		// Token: 0x0400054E RID: 1358
		[AccessedThroughProperty("ComboBox_baudrate_COM2_820")]
		private ComboBox _ComboBox_baudrate_COM2_820;

		// Token: 0x0400054F RID: 1359
		[AccessedThroughProperty("Label_baudrate_COM2_820")]
		private Label _Label_baudrate_COM2_820;

		// Token: 0x04000550 RID: 1360
		[AccessedThroughProperty("TabPage_controle")]
		private TabPage _TabPage_controle;

		// Token: 0x04000551 RID: 1361
		[AccessedThroughProperty("GroupBox_perifericos_820")]
		private GroupBox _GroupBox_perifericos_820;

		// Token: 0x04000552 RID: 1362
		[AccessedThroughProperty("DataGridView_periferico_RT820")]
		private DataGridView _DataGridView_periferico_RT820;

		// Token: 0x04000553 RID: 1363
		[AccessedThroughProperty("Timer_limpa_MSG_820")]
		private Timer _Timer_limpa_MSG_820;

		// Token: 0x04000554 RID: 1364
		[AccessedThroughProperty("GroupBox_descricao_RT820")]
		private GroupBox _GroupBox_descricao_RT820;

		// Token: 0x04000555 RID: 1365
		[AccessedThroughProperty("TextBox_comentarios_RT820")]
		private TextBox _TextBox_comentarios_RT820;

		// Token: 0x04000556 RID: 1366
		[AccessedThroughProperty("TextBox_endereco_RT820")]
		private TextBox _TextBox_endereco_RT820;

		// Token: 0x04000557 RID: 1367
		[AccessedThroughProperty("TextBox_nome_RT820")]
		private TextBox _TextBox_nome_RT820;

		// Token: 0x04000558 RID: 1368
		[AccessedThroughProperty("Label_comentarios")]
		private Label _Label_comentarios;

		// Token: 0x04000559 RID: 1369
		[AccessedThroughProperty("Label_endereco")]
		private Label _Label_endereco;

		// Token: 0x0400055A RID: 1370
		[AccessedThroughProperty("Label_nome")]
		private Label _Label_nome;

		// Token: 0x0400055B RID: 1371
		[AccessedThroughProperty("GroupBox_ED_820")]
		private GroupBox _GroupBox_ED_820;

		// Token: 0x0400055C RID: 1372
		[AccessedThroughProperty("DataGridView_RT820_ED")]
		private DataGridView _DataGridView_RT820_ED;

		// Token: 0x0400055D RID: 1373
		[AccessedThroughProperty("ToolStripButton_RT820_Imprimir")]
		private ToolStripButton _ToolStripButton_RT820_Imprimir;

		// Token: 0x0400055E RID: 1374
		[AccessedThroughProperty("PrintDocument1")]
		private PrintDocument _PrintDocument1;

		// Token: 0x0400055F RID: 1375
		[AccessedThroughProperty("TabPage1")]
		private TabPage _TabPage1;

		// Token: 0x04000560 RID: 1376
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000561 RID: 1377
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x04000562 RID: 1378
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x04000563 RID: 1379
		[AccessedThroughProperty("T_ModeloFonte")]
		private TextBox _T_ModeloFonte;

		// Token: 0x04000564 RID: 1380
		[AccessedThroughProperty("T_AlturaAntena")]
		private TextBox _T_AlturaAntena;

		// Token: 0x04000565 RID: 1381
		[AccessedThroughProperty("T_Latitude")]
		private TextBox _T_Latitude;

		// Token: 0x04000566 RID: 1382
		[AccessedThroughProperty("T_Longitude")]
		private TextBox _T_Longitude;

		// Token: 0x04000567 RID: 1383
		[AccessedThroughProperty("T_Azimute")]
		private TextBox _T_Azimute;

		// Token: 0x04000568 RID: 1384
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x04000569 RID: 1385
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x0400056A RID: 1386
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x0400056B RID: 1387
		[AccessedThroughProperty("T_FreqRadio")]
		private TextBox _T_FreqRadio;

		// Token: 0x0400056C RID: 1388
		[AccessedThroughProperty("T_DistCentral")]
		private TextBox _T_DistCentral;

		// Token: 0x0400056D RID: 1389
		[AccessedThroughProperty("T_PotRadio")]
		private TextBox _T_PotRadio;

		// Token: 0x0400056E RID: 1390
		[AccessedThroughProperty("CB_ModeloRadio")]
		private ComboBox _CB_ModeloRadio;

		// Token: 0x0400056F RID: 1391
		[AccessedThroughProperty("CB_PolarizacaoAntena")]
		private ComboBox _CB_PolarizacaoAntena;

		// Token: 0x04000570 RID: 1392
		[AccessedThroughProperty("CB_TipoAntena")]
		private ComboBox _CB_TipoAntena;

		// Token: 0x04000571 RID: 1393
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000572 RID: 1394
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000573 RID: 1395
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000574 RID: 1396
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000575 RID: 1397
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000576 RID: 1398
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000577 RID: 1399
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000578 RID: 1400
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000579 RID: 1401
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400057A RID: 1402
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400057B RID: 1403
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x0400057C RID: 1404
		[AccessedThroughProperty("ToolStripSeparator3")]
		private ToolStripSeparator _ToolStripSeparator3;

		// Token: 0x0400057D RID: 1405
		[AccessedThroughProperty("PrintPreviewDialog1")]
		private PrintPreviewDialog _PrintPreviewDialog1;

		// Token: 0x0400057E RID: 1406
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x0400057F RID: 1407
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x04000580 RID: 1408
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000581 RID: 1409
		[AccessedThroughProperty("checkbox_habilita_controle")]
		private CheckBox _checkbox_habilita_controle;

		// Token: 0x04000582 RID: 1410
		[AccessedThroughProperty("cb_Controle")]
		private ComboBox _cb_Controle;

		// Token: 0x04000583 RID: 1411
		[AccessedThroughProperty("cb_Protecao")]
		private ComboBox _cb_Protecao;

		// Token: 0x04000584 RID: 1412
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x04000585 RID: 1413
		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		// Token: 0x04000586 RID: 1414
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		// Token: 0x04000587 RID: 1415
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		// Token: 0x04000588 RID: 1416
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x04000589 RID: 1417
		[AccessedThroughProperty("Label27")]
		private Label _Label27;

		// Token: 0x0400058A RID: 1418
		[AccessedThroughProperty("Label28")]
		private Label _Label28;

		// Token: 0x0400058B RID: 1419
		[AccessedThroughProperty("nud_motor1_baixo")]
		private NumericUpDown _nud_motor1_baixo;

		// Token: 0x0400058C RID: 1420
		[AccessedThroughProperty("nud_motor1_alto")]
		private NumericUpDown _nud_motor1_alto;

		// Token: 0x0400058D RID: 1421
		[AccessedThroughProperty("nud_motor4_baixo")]
		private NumericUpDown _nud_motor4_baixo;

		// Token: 0x0400058E RID: 1422
		[AccessedThroughProperty("nud_motor4_alto")]
		private NumericUpDown _nud_motor4_alto;

		// Token: 0x0400058F RID: 1423
		[AccessedThroughProperty("nud_motor3_baixo")]
		private NumericUpDown _nud_motor3_baixo;

		// Token: 0x04000590 RID: 1424
		[AccessedThroughProperty("nud_motor3_alto")]
		private NumericUpDown _nud_motor3_alto;

		// Token: 0x04000591 RID: 1425
		[AccessedThroughProperty("nud_motor2_baixo")]
		private NumericUpDown _nud_motor2_baixo;

		// Token: 0x04000592 RID: 1426
		[AccessedThroughProperty("nud_motor2_alto")]
		private NumericUpDown _nud_motor2_alto;

		// Token: 0x04000593 RID: 1427
		[AccessedThroughProperty("nud_protecao_liga")]
		private NumericUpDown _nud_protecao_liga;

		// Token: 0x04000594 RID: 1428
		[AccessedThroughProperty("nud_protecao_desliga")]
		private NumericUpDown _nud_protecao_desliga;

		// Token: 0x04000595 RID: 1429
		[AccessedThroughProperty("Label29")]
		private Label _Label29;

		// Token: 0x04000596 RID: 1430
		[AccessedThroughProperty("cb_ModoRepetidora")]
		private ComboBox _cb_ModoRepetidora;

		// Token: 0x04000597 RID: 1431
		[AccessedThroughProperty("TabPage_MotoresValvulas")]
		private TabPage _TabPage_MotoresValvulas;

		// Token: 0x04000598 RID: 1432
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		// Token: 0x04000599 RID: 1433
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x0400059A RID: 1434
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x0400059B RID: 1435
		[AccessedThroughProperty("Label47")]
		private Label _Label47;

		// Token: 0x0400059C RID: 1436
		[AccessedThroughProperty("Label46")]
		private Label _Label46;

		// Token: 0x0400059D RID: 1437
		[AccessedThroughProperty("Label45")]
		private Label _Label45;

		// Token: 0x0400059E RID: 1438
		[AccessedThroughProperty("Label44")]
		private Label _Label44;

		// Token: 0x0400059F RID: 1439
		[AccessedThroughProperty("Label43")]
		private Label _Label43;

		// Token: 0x040005A0 RID: 1440
		[AccessedThroughProperty("Label42")]
		private Label _Label42;

		// Token: 0x040005A1 RID: 1441
		[AccessedThroughProperty("Label41")]
		private Label _Label41;

		// Token: 0x040005A2 RID: 1442
		[AccessedThroughProperty("Label40")]
		private Label _Label40;

		// Token: 0x040005A3 RID: 1443
		[AccessedThroughProperty("Label39")]
		private Label _Label39;

		// Token: 0x040005A4 RID: 1444
		[AccessedThroughProperty("Label38")]
		private Label _Label38;

		// Token: 0x040005A5 RID: 1445
		[AccessedThroughProperty("Label37")]
		private Label _Label37;

		// Token: 0x040005A6 RID: 1446
		[AccessedThroughProperty("Label36")]
		private Label _Label36;

		// Token: 0x040005A7 RID: 1447
		[AccessedThroughProperty("Label35")]
		private Label _Label35;

		// Token: 0x040005A8 RID: 1448
		[AccessedThroughProperty("Label34")]
		private Label _Label34;

		// Token: 0x040005A9 RID: 1449
		[AccessedThroughProperty("Label33")]
		private Label _Label33;

		// Token: 0x040005AA RID: 1450
		[AccessedThroughProperty("Label32")]
		private Label _Label32;

		// Token: 0x040005AB RID: 1451
		[AccessedThroughProperty("Label31")]
		private Label _Label31;

		// Token: 0x040005AC RID: 1452
		[AccessedThroughProperty("Label30")]
		private Label _Label30;

		// Token: 0x040005AD RID: 1453
		[AccessedThroughProperty("nud_bombas_simultaneas")]
		private NumericUpDown _nud_bombas_simultaneas;

		// Token: 0x040005AE RID: 1454
		[AccessedThroughProperty("nud_numero_valvulas")]
		private NumericUpDown _nud_numero_valvulas;

		// Token: 0x040005AF RID: 1455
		[AccessedThroughProperty("nud_numero_motores")]
		private NumericUpDown _nud_numero_motores;

		// Token: 0x040005B0 RID: 1456
		[AccessedThroughProperty("cb_modo_operacao")]
		private ComboBox _cb_modo_operacao;

		// Token: 0x040005B1 RID: 1457
		[AccessedThroughProperty("nud_tempo_operacoes")]
		private NumericUpDown _nud_tempo_operacoes;

		// Token: 0x040005B2 RID: 1458
		[AccessedThroughProperty("nud_valvula3_abertura")]
		private NumericUpDown _nud_valvula3_abertura;

		// Token: 0x040005B3 RID: 1459
		[AccessedThroughProperty("nud_valvula2_fechamento")]
		private NumericUpDown _nud_valvula2_fechamento;

		// Token: 0x040005B4 RID: 1460
		[AccessedThroughProperty("nud_valvula2_abertura")]
		private NumericUpDown _nud_valvula2_abertura;

		// Token: 0x040005B5 RID: 1461
		[AccessedThroughProperty("nud_valvula1_fechamento")]
		private NumericUpDown _nud_valvula1_fechamento;

		// Token: 0x040005B6 RID: 1462
		[AccessedThroughProperty("nud_valvula1_abertura")]
		private NumericUpDown _nud_valvula1_abertura;

		// Token: 0x040005B7 RID: 1463
		[AccessedThroughProperty("nud_valvula4_fechamento")]
		private NumericUpDown _nud_valvula4_fechamento;

		// Token: 0x040005B8 RID: 1464
		[AccessedThroughProperty("nud_valvula4_abertura")]
		private NumericUpDown _nud_valvula4_abertura;

		// Token: 0x040005B9 RID: 1465
		[AccessedThroughProperty("nud_valvula3_fechamento")]
		private NumericUpDown _nud_valvula3_fechamento;

		// Token: 0x040005BA RID: 1466
		[AccessedThroughProperty("nud_parada4")]
		private NumericUpDown _nud_parada4;

		// Token: 0x040005BB RID: 1467
		[AccessedThroughProperty("nud_partida4")]
		private NumericUpDown _nud_partida4;

		// Token: 0x040005BC RID: 1468
		[AccessedThroughProperty("nud_parada3")]
		private NumericUpDown _nud_parada3;

		// Token: 0x040005BD RID: 1469
		[AccessedThroughProperty("nud_partida3")]
		private NumericUpDown _nud_partida3;

		// Token: 0x040005BE RID: 1470
		[AccessedThroughProperty("nud_parada2")]
		private NumericUpDown _nud_parada2;

		// Token: 0x040005BF RID: 1471
		[AccessedThroughProperty("nud_partida2")]
		private NumericUpDown _nud_partida2;

		// Token: 0x040005C0 RID: 1472
		[AccessedThroughProperty("nud_parada1")]
		private NumericUpDown _nud_parada1;

		// Token: 0x040005C1 RID: 1473
		[AccessedThroughProperty("nud_partida1")]
		private NumericUpDown _nud_partida1;

		// Token: 0x040005C2 RID: 1474
		[AccessedThroughProperty("cb_modo_partida2")]
		private ComboBox _cb_modo_partida2;

		// Token: 0x040005C3 RID: 1475
		[AccessedThroughProperty("cb_modo_partida1")]
		private ComboBox _cb_modo_partida1;

		// Token: 0x040005C4 RID: 1476
		[AccessedThroughProperty("cb_modo_partida3")]
		private ComboBox _cb_modo_partida3;

		// Token: 0x040005C5 RID: 1477
		[AccessedThroughProperty("cb_modo_partida4")]
		private ComboBox _cb_modo_partida4;

		// Token: 0x040005C6 RID: 1478
		[AccessedThroughProperty("PrintDialog1")]
		private PrintDialog _PrintDialog1;

		// Token: 0x040005C7 RID: 1479
		[AccessedThroughProperty("ToolStripLabel_ID")]
		private ToolStripLabel _ToolStripLabel_ID;

		// Token: 0x040005C8 RID: 1480
		[AccessedThroughProperty("ToolStripSeparator4")]
		private ToolStripSeparator _ToolStripSeparator4;

		// Token: 0x040005C9 RID: 1481
		[AccessedThroughProperty("Label48")]
		private Label _Label48;

		// Token: 0x040005CA RID: 1482
		[AccessedThroughProperty("TextBox_equipamento_820")]
		private TextBox _TextBox_equipamento_820;

		// Token: 0x040005CB RID: 1483
		[AccessedThroughProperty("Label49")]
		private Label _Label49;

		// Token: 0x040005CC RID: 1484
		[AccessedThroughProperty("TextBox_release_820")]
		private TextBox _TextBox_release_820;

		// Token: 0x040005CD RID: 1485
		[AccessedThroughProperty("Label50")]
		private Label _Label50;

		// Token: 0x040005CE RID: 1486
		[AccessedThroughProperty("TextBox_build_820")]
		private TextBox _TextBox_build_820;

		// Token: 0x040005CF RID: 1487
		[AccessedThroughProperty("Label51")]
		private Label _Label51;

		// Token: 0x040005D0 RID: 1488
		[AccessedThroughProperty("TextBox_versao_820")]
		private TextBox _TextBox_versao_820;

		// Token: 0x040005D1 RID: 1489
		[AccessedThroughProperty("Label52")]
		private Label _Label52;

		// Token: 0x040005D2 RID: 1490
		[AccessedThroughProperty("tb_lixo1")]
		private TextBox _tb_lixo1;

		// Token: 0x040005D3 RID: 1491
		[AccessedThroughProperty("tb_lixo2")]
		private TextBox _tb_lixo2;

		// Token: 0x040005D4 RID: 1492
		[AccessedThroughProperty("tb_lixo3")]
		private TextBox _tb_lixo3;

		// Token: 0x040005D5 RID: 1493
		[AccessedThroughProperty("tb_lixo5")]
		private TextBox _tb_lixo5;

		// Token: 0x040005D6 RID: 1494
		[AccessedThroughProperty("tb_lixo6")]
		private TextBox _tb_lixo6;

		// Token: 0x040005D7 RID: 1495
		[AccessedThroughProperty("tb_lixo7")]
		private TextBox _tb_lixo7;

		// Token: 0x040005D8 RID: 1496
		[AccessedThroughProperty("tb_lixo8")]
		private TextBox _tb_lixo8;

		// Token: 0x040005D9 RID: 1497
		[AccessedThroughProperty("GroupBox7")]
		private GroupBox _GroupBox7;

		// Token: 0x040005DA RID: 1498
		[AccessedThroughProperty("sph_ativa10")]
		private CheckBox _sph_ativa10;

		// Token: 0x040005DB RID: 1499
		[AccessedThroughProperty("Label55")]
		private Label _Label55;

		// Token: 0x040005DC RID: 1500
		[AccessedThroughProperty("Label54")]
		private Label _Label54;

		// Token: 0x040005DD RID: 1501
		[AccessedThroughProperty("sph_hora10")]
		private NumericUpDown _sph_hora10;

		// Token: 0x040005DE RID: 1502
		[AccessedThroughProperty("Label53")]
		private Label _Label53;

		// Token: 0x040005DF RID: 1503
		[AccessedThroughProperty("sph_baixo11")]
		private NumericUpDown _sph_baixo11;

		// Token: 0x040005E0 RID: 1504
		[AccessedThroughProperty("sph_alto11")]
		private NumericUpDown _sph_alto11;

		// Token: 0x040005E1 RID: 1505
		[AccessedThroughProperty("sph_minuto11")]
		private NumericUpDown _sph_minuto11;

		// Token: 0x040005E2 RID: 1506
		[AccessedThroughProperty("sph_ativa11")]
		private CheckBox _sph_ativa11;

		// Token: 0x040005E3 RID: 1507
		[AccessedThroughProperty("sph_hora11")]
		private NumericUpDown _sph_hora11;

		// Token: 0x040005E4 RID: 1508
		[AccessedThroughProperty("Label57")]
		private Label _Label57;

		// Token: 0x040005E5 RID: 1509
		[AccessedThroughProperty("Label56")]
		private Label _Label56;

		// Token: 0x040005E6 RID: 1510
		[AccessedThroughProperty("sph_baixo10")]
		private NumericUpDown _sph_baixo10;

		// Token: 0x040005E7 RID: 1511
		[AccessedThroughProperty("sph_alto10")]
		private NumericUpDown _sph_alto10;

		// Token: 0x040005E8 RID: 1512
		[AccessedThroughProperty("sph_minuto10")]
		private NumericUpDown _sph_minuto10;

		// Token: 0x040005E9 RID: 1513
		[AccessedThroughProperty("sph_baixo41")]
		private NumericUpDown _sph_baixo41;

		// Token: 0x040005EA RID: 1514
		[AccessedThroughProperty("sph_alto41")]
		private NumericUpDown _sph_alto41;

		// Token: 0x040005EB RID: 1515
		[AccessedThroughProperty("sph_minuto41")]
		private NumericUpDown _sph_minuto41;

		// Token: 0x040005EC RID: 1516
		[AccessedThroughProperty("sph_ativa41")]
		private CheckBox _sph_ativa41;

		// Token: 0x040005ED RID: 1517
		[AccessedThroughProperty("sph_hora41")]
		private NumericUpDown _sph_hora41;

		// Token: 0x040005EE RID: 1518
		[AccessedThroughProperty("sph_baixo40")]
		private NumericUpDown _sph_baixo40;

		// Token: 0x040005EF RID: 1519
		[AccessedThroughProperty("sph_alto40")]
		private NumericUpDown _sph_alto40;

		// Token: 0x040005F0 RID: 1520
		[AccessedThroughProperty("sph_minuto40")]
		private NumericUpDown _sph_minuto40;

		// Token: 0x040005F1 RID: 1521
		[AccessedThroughProperty("sph_ativa40")]
		private CheckBox _sph_ativa40;

		// Token: 0x040005F2 RID: 1522
		[AccessedThroughProperty("sph_hora40")]
		private NumericUpDown _sph_hora40;

		// Token: 0x040005F3 RID: 1523
		[AccessedThroughProperty("Label72")]
		private Label _Label72;

		// Token: 0x040005F4 RID: 1524
		[AccessedThroughProperty("sph_baixo31")]
		private NumericUpDown _sph_baixo31;

		// Token: 0x040005F5 RID: 1525
		[AccessedThroughProperty("sph_alto31")]
		private NumericUpDown _sph_alto31;

		// Token: 0x040005F6 RID: 1526
		[AccessedThroughProperty("sph_minuto31")]
		private NumericUpDown _sph_minuto31;

		// Token: 0x040005F7 RID: 1527
		[AccessedThroughProperty("sph_ativa31")]
		private CheckBox _sph_ativa31;

		// Token: 0x040005F8 RID: 1528
		[AccessedThroughProperty("sph_hora31")]
		private NumericUpDown _sph_hora31;

		// Token: 0x040005F9 RID: 1529
		[AccessedThroughProperty("sph_baixo30")]
		private NumericUpDown _sph_baixo30;

		// Token: 0x040005FA RID: 1530
		[AccessedThroughProperty("sph_alto30")]
		private NumericUpDown _sph_alto30;

		// Token: 0x040005FB RID: 1531
		[AccessedThroughProperty("sph_minuto30")]
		private NumericUpDown _sph_minuto30;

		// Token: 0x040005FC RID: 1532
		[AccessedThroughProperty("sph_ativa30")]
		private CheckBox _sph_ativa30;

		// Token: 0x040005FD RID: 1533
		[AccessedThroughProperty("sph_hora30")]
		private NumericUpDown _sph_hora30;

		// Token: 0x040005FE RID: 1534
		[AccessedThroughProperty("Label67")]
		private Label _Label67;

		// Token: 0x040005FF RID: 1535
		[AccessedThroughProperty("sph_baixo21")]
		private NumericUpDown _sph_baixo21;

		// Token: 0x04000600 RID: 1536
		[AccessedThroughProperty("sph_alto21")]
		private NumericUpDown _sph_alto21;

		// Token: 0x04000601 RID: 1537
		[AccessedThroughProperty("sph_minuto21")]
		private NumericUpDown _sph_minuto21;

		// Token: 0x04000602 RID: 1538
		[AccessedThroughProperty("sph_ativa21")]
		private CheckBox _sph_ativa21;

		// Token: 0x04000603 RID: 1539
		[AccessedThroughProperty("sph_hora21")]
		private NumericUpDown _sph_hora21;

		// Token: 0x04000604 RID: 1540
		[AccessedThroughProperty("sph_baixo20")]
		private NumericUpDown _sph_baixo20;

		// Token: 0x04000605 RID: 1541
		[AccessedThroughProperty("sph_alto20")]
		private NumericUpDown _sph_alto20;

		// Token: 0x04000606 RID: 1542
		[AccessedThroughProperty("sph_minuto20")]
		private NumericUpDown _sph_minuto20;

		// Token: 0x04000607 RID: 1543
		[AccessedThroughProperty("sph_ativa20")]
		private CheckBox _sph_ativa20;

		// Token: 0x04000608 RID: 1544
		[AccessedThroughProperty("sph_hora20")]
		private NumericUpDown _sph_hora20;

		// Token: 0x04000609 RID: 1545
		[AccessedThroughProperty("Label62")]
		private Label _Label62;

		// Token: 0x0400060A RID: 1546
		[AccessedThroughProperty("Label73")]
		private Label _Label73;

		// Token: 0x0400060B RID: 1547
		[AccessedThroughProperty("Label75")]
		private Label _Label75;

		// Token: 0x0400060C RID: 1548
		[AccessedThroughProperty("Label74")]
		private Label _Label74;

		// Token: 0x0400060D RID: 1549
		private bool bloqueio_IO;

		// Token: 0x0400060E RID: 1550
		private int pagina_impressao;
	}
}
