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
	// Token: 0x02000080 RID: 128
	[DesignerGenerated]
	public partial class Equip_101_mon : Form
	{
		// Token: 0x06001BAC RID: 7084 RVA: 0x003CAEDC File Offset: 0x003C92DC
		public Equip_101_mon()
		{
			base.Load += new EventHandler(this.Equip_101_mon_Load);
			base.Deactivate += new EventHandler(this.Equip_101_mon_Deactivate);
			this.InitializeComponent();
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x003CC018 File Offset: 0x003CA418
		// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x003CC02C File Offset: 0x003CA42C
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

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x003CC038 File Offset: 0x003CA438
		// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x003CC04C File Offset: 0x003CA44C
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

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x003CC098 File Offset: 0x003CA498
		// (set) Token: 0x06001BB4 RID: 7092 RVA: 0x003CC0AC File Offset: 0x003CA4AC
		internal virtual GroupBox Grupo_medidas_eng
		{
			get
			{
				return this._Grupo_medidas_eng;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_medidas_eng = value;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x003CC0B8 File Offset: 0x003CA4B8
		// (set) Token: 0x06001BB6 RID: 7094 RVA: 0x003CC0CC File Offset: 0x003CA4CC
		internal virtual Label Label_nivel_eng
		{
			get
			{
				return this._Label_nivel_eng;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nivel_eng = value;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x003CC0D8 File Offset: 0x003CA4D8
		// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x003CC0EC File Offset: 0x003CA4EC
		internal virtual TextBox Tela_nivel
		{
			get
			{
				return this._Tela_nivel;
			}
			[MethodImpl(32)]
			set
			{
				this._Tela_nivel = value;
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x003CC0F8 File Offset: 0x003CA4F8
		// (set) Token: 0x06001BBA RID: 7098 RVA: 0x003CC10C File Offset: 0x003CA50C
		internal virtual Label Label_em_bat
		{
			get
			{
				return this._Label_em_bat;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_em_bat = value;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x003CC118 File Offset: 0x003CA518
		// (set) Token: 0x06001BBC RID: 7100 RVA: 0x003CC12C File Offset: 0x003CA52C
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

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x003CC138 File Offset: 0x003CA538
		// (set) Token: 0x06001BBE RID: 7102 RVA: 0x003CC14C File Offset: 0x003CA54C
		internal virtual Label Label_defeito_sensor
		{
			get
			{
				return this._Label_defeito_sensor;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_defeito_sensor = value;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x003CC158 File Offset: 0x003CA558
		// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x003CC16C File Offset: 0x003CA56C
		internal virtual Label Label_arrombamento
		{
			get
			{
				return this._Label_arrombamento;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_arrombamento = value;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x003CC178 File Offset: 0x003CA578
		// (set) Token: 0x06001BC2 RID: 7106 RVA: 0x003CC18C File Offset: 0x003CA58C
		internal virtual Label Label_vazio
		{
			get
			{
				return this._Label_vazio;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_vazio = value;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x003CC198 File Offset: 0x003CA598
		// (set) Token: 0x06001BC4 RID: 7108 RVA: 0x003CC1AC File Offset: 0x003CA5AC
		internal virtual Label Label_transbordo
		{
			get
			{
				return this._Label_transbordo;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_transbordo = value;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x003CC1B8 File Offset: 0x003CA5B8
		// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x003CC1CC File Offset: 0x003CA5CC
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

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x003CC218 File Offset: 0x003CA618
		// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x003CC22C File Offset: 0x003CA62C
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

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x003CC238 File Offset: 0x003CA638
		// (set) Token: 0x06001BCA RID: 7114 RVA: 0x003CC24C File Offset: 0x003CA64C
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

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x003CC258 File Offset: 0x003CA658
		// (set) Token: 0x06001BCC RID: 7116 RVA: 0x003CC26C File Offset: 0x003CA66C
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

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x003CC278 File Offset: 0x003CA678
		// (set) Token: 0x06001BCE RID: 7118 RVA: 0x003CC28C File Offset: 0x003CA68C
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

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x003CC298 File Offset: 0x003CA698
		// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x003CC2AC File Offset: 0x003CA6AC
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

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x003CC2B8 File Offset: 0x003CA6B8
		// (set) Token: 0x06001BD2 RID: 7122 RVA: 0x003CC2CC File Offset: 0x003CA6CC
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

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x003CC318 File Offset: 0x003CA718
		// (set) Token: 0x06001BD4 RID: 7124 RVA: 0x003CC32C File Offset: 0x003CA72C
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

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x003CC338 File Offset: 0x003CA738
		// (set) Token: 0x06001BD6 RID: 7126 RVA: 0x003CC34C File Offset: 0x003CA74C
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

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x003CC358 File Offset: 0x003CA758
		// (set) Token: 0x06001BD8 RID: 7128 RVA: 0x003CC36C File Offset: 0x003CA76C
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

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x003CC378 File Offset: 0x003CA778
		// (set) Token: 0x06001BDA RID: 7130 RVA: 0x003CC38C File Offset: 0x003CA78C
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

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x003CC398 File Offset: 0x003CA798
		// (set) Token: 0x06001BDC RID: 7132 RVA: 0x003CC3AC File Offset: 0x003CA7AC
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

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x003CC3B8 File Offset: 0x003CA7B8
		// (set) Token: 0x06001BDE RID: 7134 RVA: 0x003CC3CC File Offset: 0x003CA7CC
		internal virtual NumericUpDown Tela_end_estacao
		{
			get
			{
				return this._Tela_end_estacao;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Tela_end_estacao_ValueChanged);
				if (this._Tela_end_estacao != null)
				{
					this._Tela_end_estacao.ValueChanged -= eventHandler;
				}
				this._Tela_end_estacao = value;
				if (this._Tela_end_estacao != null)
				{
					this._Tela_end_estacao.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x003CC418 File Offset: 0x003CA818
		// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x003CC42C File Offset: 0x003CA82C
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

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x003CC478 File Offset: 0x003CA878
		// (set) Token: 0x06001BE2 RID: 7138 RVA: 0x003CC48C File Offset: 0x003CA88C
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

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001BE3 RID: 7139 RVA: 0x003CC498 File Offset: 0x003CA898
		// (set) Token: 0x06001BE4 RID: 7140 RVA: 0x003CC4AC File Offset: 0x003CA8AC
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

		// Token: 0x06001BE5 RID: 7141 RVA: 0x003CC4B8 File Offset: 0x003CA8B8
		private void Equip_101_mon_Deactivate(object sender, EventArgs e)
		{
						this.Mensagem_MD101_mon("Monitoração desativada", 2);
			this.Timer_monitoracao.Enabled = false;
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x003CC4FC File Offset: 0x003CA8FC
		private void Equip_101_mon_Load(object sender, EventArgs e)
		{
			this.Mensagem_MD101_mon("Monitoração desativada", 2);
			Geral.Config_geral.Largura_tela_trabalho = this.Width;
			int num = 48;
			Interaction.MsgBox("Colocar o equipamento em modo de monitoração !\r\nAbrir o jumper de configuração.", (MsgBoxStyle)num, " Atenção - verifique a configuração");
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x003CC53C File Offset: 0x003CA93C
		private void Comando_hab_monitoracao_Click(object sender, EventArgs e)
		{
			if (!Geral.Config_geral.Porta_serial_Ok)
			{
				Interaction.MsgBox("Porta Serial não configurada!\r\nComando cancelado.", (MsgBoxStyle)0, null);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(null, "Iniciar", false))
			{
				if (Mod_MD.Monitoracao_MD_RE.Estacao > 0 & Mod_MD.Monitoracao_MD_RE.Estacao <= 200)
				{
										this.Mensagem_MD101_mon("Monitoração Ativada", 2);
					Mod_MD.Monitoracao_MD_RE.Controle_mon = 1;
					this.Grupo_medidas_eng.Enabled = true;
					this.Timer_monitoracao.Enabled = true;
				}
				else
				{
					this.Mensagem_MD101_mon("Selecione Estação", 1);
				}
			}
			else
			{
								this.Mensagem_MD101_mon("Monitoração desativada", 2);
				this.Grupo_medidas_eng.Enabled = false;
				this.Timer_monitoracao.Enabled = false;
			}
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x003CC64C File Offset: 0x003CAA4C
		private void Timer_monitoracao_Tick(object sender, EventArgs e)
		{
			int[] dados = new int[41];
			this.Timer_monitoracao.Enabled = false;
			int i = Conversions.ToInteger(Comunicacao.Config_sistema.Retry);
			checked
			{
				while (i > 0)
				{
					i--;
					Comunicacao.CMD_Tx_condax(Mod_MD.Monitoracao_MD_RE.Estacao, Mod_MD.Monitoracao_MD_RE.Mestre, 49, 0, dados);
					do
					{
						Application.DoEvents();
					}
					while (Comunicacao.Ctrl_Com.Frame == 255);
					switch (Comunicacao.Ctrl_Com.Frame)
					{
					case 0:
						this.Mensagem_MD101_mon("Leitura RE - Ok", 0);
						this.Calcula_Estatistica_101(1);
						this.Atualiza_monitoracao_101();
						goto IL_11A;
					case 2:
						if (i == 0)
						{
							this.Mensagem_MD101_mon("Erro Leitura RE - ChkSum", 1);
							this.Calcula_Estatistica_101(3);
							this.Limpa_monitoracao_101();
							continue;
						}
						this.Calcula_Estatistica_101(2);
						continue;
					case 3:
						if (i == 0)
						{
							this.Mensagem_MD101_mon("Erro Leitura RE - Timeout", 1);
							this.Calcula_Estatistica_101(3);
							this.Limpa_monitoracao_101();
							continue;
						}
						this.Calcula_Estatistica_101(2);
						continue;
					}
					if (i == 0)
					{
						this.Mensagem_MD101_mon("Erro Leitura RE - não determinado", 1);
						this.Calcula_Estatistica_101(3);
						this.Limpa_monitoracao_101();
					}
					else
					{
						this.Calcula_Estatistica_101(2);
					}
				}
				IL_11A:
				MyProject.Forms.Plataforma.Mostra_no_ouvidor(Comunicacao.Ctrl_Com.Frame);
				this.Timer_monitoracao.Enabled = true;
			}
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x003CC798 File Offset: 0x003CAB98
		public void Mensagem_MD101_mon(string msg, int cor)
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

		// Token: 0x06001BEA RID: 7146 RVA: 0x003CC7FC File Offset: 0x003CABFC
		public void Atualiza_monitoracao_101()
		{
			string versao = Geral.Config_geral.Versao;
			checked
			{
				int num = 0;
				if (Operators.CompareString(versao, "43", false) == 0)
				{
					this.Tela_nivel.Text = Strings.Format((double)(Comunicacao.Buffer_resp[4] - 48) / 2.0, "0.0");
					num = (int)(Comunicacao.Buffer_resp[5] - 48);
				}
				else if (Operators.CompareString(versao, "70", false) == 0)
				{
					this.Tela_nivel.Text = Strings.Format((double)((Comunicacao.Buffer_resp[4] - 48) * 200 + (Comunicacao.Buffer_resp[5] - 48)) / 40.0, "0.0");
					num = (int)(Comunicacao.Buffer_resp[6] - 48);
				}
				else if (Operators.CompareString(versao, "810_10", false) == 0)
				{
					this.Tela_nivel.Text = Strings.Format((double)((Comunicacao.Buffer_resp[4] - 48) * 200 + (Comunicacao.Buffer_resp[5] - 48)) / 40.0, "0.0");
					num = (int)(Comunicacao.Buffer_resp[6] - 48);
				}
				if ((num & 1) != 0)
				{
					this.Label_em_bat.BackColor = Color.Red;
				}
				else
				{
					this.Label_em_bat.BackColor = Color.Gainsboro;
				}
				if ((num & 4) != 0)
				{
					this.Label_transbordo.BackColor = Color.Red;
				}
				else
				{
					this.Label_transbordo.BackColor = Color.Gainsboro;
				}
				if ((num & 8) != 0)
				{
					this.Label_vazio.BackColor = Color.Red;
				}
				else
				{
					this.Label_vazio.BackColor = Color.Gainsboro;
				}
				if ((num & 16) != 0)
				{
					this.Label_defeito_sensor.BackColor = Color.Red;
				}
				else
				{
					this.Label_defeito_sensor.BackColor = Color.Gainsboro;
				}
				if ((num & 32) != 0)
				{
					this.Label_arrombamento.BackColor = Color.Red;
				}
				else
				{
					this.Label_arrombamento.BackColor = Color.Gainsboro;
				}
			}
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x003CC9EC File Offset: 0x003CADEC
		public void Limpa_monitoracao_101()
		{
			this.Tela_nivel.Text = Strings.Format(0, "0.0");
			this.Label_em_bat.BackColor = Color.Gainsboro;
			this.Label_transbordo.BackColor = Color.Gainsboro;
			this.Label_vazio.BackColor = Color.Gainsboro;
			this.Label_defeito_sensor.BackColor = Color.Gainsboro;
			this.Label_arrombamento.BackColor = Color.Gainsboro;
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x003CCA64 File Offset: 0x003CAE64
		public void Calcula_Estatistica_101(int opcao)
		{
			checked
			{
				switch (opcao)
				{
				case 1:
					Mod_MD.Monitoracao_MD_RE.Num_Rx = Mod_MD.Monitoracao_MD_RE.Num_Rx + 1L;
					Mod_MD.Monitoracao_MD_RE.Num_Tx = Mod_MD.Monitoracao_MD_RE.Num_Tx + 1L;
					break;
				case 2:
					Mod_MD.Monitoracao_MD_RE.Num_Retry = Mod_MD.Monitoracao_MD_RE.Num_Retry + 1L;
					break;
				case 3:
					Mod_MD.Monitoracao_MD_RE.Num_Tx = Mod_MD.Monitoracao_MD_RE.Num_Tx + 1L;
					break;
				}
				if (Mod_MD.Monitoracao_MD_RE.Num_Tx != 0L)
				{
					Mod_MD.Monitoracao_MD_RE.Eficiencia_com = (int)Math.Round(unchecked((double)Mod_MD.Monitoracao_MD_RE.Num_Rx / (double)Mod_MD.Monitoracao_MD_RE.Num_Tx * 100.0));
				}
				this.Est_TX.Text = Conversion.Str(Mod_MD.Monitoracao_MD_RE.Num_Tx);
				this.Est_Rx.Text = Conversion.Str(Mod_MD.Monitoracao_MD_RE.Num_Rx);
				this.Est_retry.Text = Conversion.Str(Mod_MD.Monitoracao_MD_RE.Num_Retry);
				this.Est_eficiencia.Text = Conversion.Str(Mod_MD.Monitoracao_MD_RE.Eficiencia_com);
			}
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x003CCBA4 File Offset: 0x003CAFA4
		private void Tela_end_estacao_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RE.Estacao = 0;
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x003CCBCC File Offset: 0x003CAFCC
		private void Tela_endereco_mestre_ValueChanged(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RE.Mestre = 0;
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x003CCBF4 File Offset: 0x003CAFF4
		private void Button_limpa_estatistica_Click(object sender, EventArgs e)
		{
			Mod_MD.Monitoracao_MD_RE.Num_Rx = 0L;
			Mod_MD.Monitoracao_MD_RE.Num_Tx = 0L;
			Mod_MD.Monitoracao_MD_RE.Eficiencia_com = 0;
			Mod_MD.Monitoracao_MD_RE.Num_Retry = 0L;
		}

		// Token: 0x04001511 RID: 5393
		[AccessedThroughProperty("Grupo_ctrl_com")]
		private GroupBox _Grupo_ctrl_com;

		// Token: 0x04001512 RID: 5394
		[AccessedThroughProperty("Comando_hab_monitoracao")]
		private Button _Comando_hab_monitoracao;

		// Token: 0x04001513 RID: 5395
		[AccessedThroughProperty("Grupo_medidas_eng")]
		private GroupBox _Grupo_medidas_eng;

		// Token: 0x04001514 RID: 5396
		[AccessedThroughProperty("Label_nivel_eng")]
		private Label _Label_nivel_eng;

		// Token: 0x04001515 RID: 5397
		[AccessedThroughProperty("Tela_nivel")]
		private TextBox _Tela_nivel;

		// Token: 0x04001516 RID: 5398
		[AccessedThroughProperty("Label_em_bat")]
		private Label _Label_em_bat;

		// Token: 0x04001517 RID: 5399
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04001518 RID: 5400
		[AccessedThroughProperty("Label_defeito_sensor")]
		private Label _Label_defeito_sensor;

		// Token: 0x04001519 RID: 5401
		[AccessedThroughProperty("Label_arrombamento")]
		private Label _Label_arrombamento;

		// Token: 0x0400151A RID: 5402
		[AccessedThroughProperty("Label_vazio")]
		private Label _Label_vazio;

		// Token: 0x0400151B RID: 5403
		[AccessedThroughProperty("Label_transbordo")]
		private Label _Label_transbordo;

		// Token: 0x0400151C RID: 5404
		[AccessedThroughProperty("Timer_monitoracao")]
		private Timer _Timer_monitoracao;

		// Token: 0x0400151D RID: 5405
		[AccessedThroughProperty("msg")]
		private TextBox _msg;

		// Token: 0x0400151E RID: 5406
		[AccessedThroughProperty("Grupo_estatistica")]
		private GroupBox _Grupo_estatistica;

		// Token: 0x0400151F RID: 5407
		[AccessedThroughProperty("Label_Est_retry")]
		private Label _Label_Est_retry;

		// Token: 0x04001520 RID: 5408
		[AccessedThroughProperty("Est_retry")]
		private TextBox _Est_retry;

		// Token: 0x04001521 RID: 5409
		[AccessedThroughProperty("Est_eficiencia")]
		private TextBox _Est_eficiencia;

		// Token: 0x04001522 RID: 5410
		[AccessedThroughProperty("Button_limpa_estatistica")]
		private Button _Button_limpa_estatistica;

		// Token: 0x04001523 RID: 5411
		[AccessedThroughProperty("Label_Est_RX")]
		private Label _Label_Est_RX;

		// Token: 0x04001524 RID: 5412
		[AccessedThroughProperty("Label_Est_Eficiencia")]
		private Label _Label_Est_Eficiencia;

		// Token: 0x04001525 RID: 5413
		[AccessedThroughProperty("Label_Est_TX")]
		private Label _Label_Est_TX;

		// Token: 0x04001526 RID: 5414
		[AccessedThroughProperty("Est_Rx")]
		private TextBox _Est_Rx;

		// Token: 0x04001527 RID: 5415
		[AccessedThroughProperty("Est_TX")]
		private TextBox _Est_TX;

		// Token: 0x04001528 RID: 5416
		[AccessedThroughProperty("Tela_end_estacao")]
		private NumericUpDown _Tela_end_estacao;

		// Token: 0x04001529 RID: 5417
		[AccessedThroughProperty("Tela_endereco_mestre")]
		private NumericUpDown _Tela_endereco_mestre;

		// Token: 0x0400152A RID: 5418
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400152B RID: 5419
		[AccessedThroughProperty("Label_end_estacao")]
		private Label _Label_end_estacao;
	}
}
