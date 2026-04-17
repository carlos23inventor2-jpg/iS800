using System.Drawing;
using System.Windows.Forms;
﻿namespace iS800
{
	// Token: 0x02000087 RID: 135
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Equip_302_conf : global::System.Windows.Forms.Form
	{
		// Token: 0x0600219D RID: 8605 RVA: 0x003F6BA4 File Offset: 0x003F4FA4
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x003F6BE4 File Offset: 0x003F4FE4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.Grupo_conf_comunicacao = new global::System.Windows.Forms.GroupBox();
			this.Valor_intervalo_polling = new global::System.Windows.Forms.NumericUpDown();
			this.Label_intervalo_polling = new global::System.Windows.Forms.Label();
			this.Valor_erro_falha = new global::System.Windows.Forms.NumericUpDown();
			this.Label_erros_falha = new global::System.Windows.Forms.Label();
			this.Valor_timeout = new global::System.Windows.Forms.NumericUpDown();
			this.Label_timeout = new global::System.Windows.Forms.Label();
			this.Combo_baudrate = new global::System.Windows.Forms.ComboBox();
			this.Label_baudrate = new global::System.Windows.Forms.Label();
			this.Valor_temp_ptt = new global::System.Windows.Forms.NumericUpDown();
			this.Valor_endereco = new global::System.Windows.Forms.NumericUpDown();
			this.Valor_num_tentativas = new global::System.Windows.Forms.NumericUpDown();
			this.Label_tempo_ptt = new global::System.Windows.Forms.Label();
			this.Label_endereco = new global::System.Windows.Forms.Label();
			this.Label_retry = new global::System.Windows.Forms.Label();
			this.Grupo_lapelas = new global::System.Windows.Forms.GroupBox();
			this.TabControl2 = new global::System.Windows.Forms.TabControl();
			this.Conf_res = new global::System.Windows.Forms.TabPage();
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.Conf_rq = new global::System.Windows.Forms.TabPage();
			this.DataGridView_RQ = new global::System.Windows.Forms.DataGridView();
			this.Conf_centrais = new global::System.Windows.Forms.TabPage();
			this.DataGridView_central_rq = new global::System.Windows.Forms.DataGridView();
			this.Col_ct_rq_end = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataGridView_central_res = new global::System.Windows.Forms.DataGridView();
			this.Col_ct_res_end = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Label_rq = new global::System.Windows.Forms.Label();
			this.Label_res = new global::System.Windows.Forms.Label();
			this.DataGridView_central_geral = new global::System.Windows.Forms.DataGridView();
			this.Col_vista_end = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_vista_res = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_vista_rq = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_vista_pri = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Grupo_conf_equipamentos = new global::System.Windows.Forms.GroupBox();
			this.Valor_vista_equipamentos = new global::System.Windows.Forms.NumericUpDown();
			this.Label_vista_equipamentos = new global::System.Windows.Forms.Label();
			this.Valor_end_ini_vista = new global::System.Windows.Forms.NumericUpDown();
			this.Label_end_ini_vista = new global::System.Windows.Forms.Label();
			this.Valor_end_ini_rq = new global::System.Windows.Forms.NumericUpDown();
			this.Label_end_ini_rq = new global::System.Windows.Forms.Label();
			this.Valor_end_ini_res = new global::System.Windows.Forms.NumericUpDown();
			this.Label_end_ini_res = new global::System.Windows.Forms.Label();
			this.Valor_rq_equipamentos = new global::System.Windows.Forms.NumericUpDown();
			this.Label_rq_equipamentos = new global::System.Windows.Forms.Label();
			this.Valor_res_equipamentos = new global::System.Windows.Forms.NumericUpDown();
			this.Label_res_equipamentos = new global::System.Windows.Forms.Label();
			this.Valor_res_sistema = new global::System.Windows.Forms.NumericUpDown();
			this.Label_res_sistema = new global::System.Windows.Forms.Label();
			this.Grupo_comandos = new global::System.Windows.Forms.GroupBox();
			this.Esc_conf_md_302 = new global::System.Windows.Forms.Button();
			this.Box_Msg = new global::System.Windows.Forms.TextBox();
			this.Ler_conf_md_302 = new global::System.Windows.Forms.Button();
			this.MenuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.ArquivoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.NovoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.AbrirToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SalvarToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.OpenFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.Col_end = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_nome = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_altura = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_pri = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_posicao = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_End_rq = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_nome_rq = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_ROrg_rq = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_RDest_rq = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_mod_rq = new global::System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Col_pri_rq = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Res1_rq = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Res2_rq = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Res3_rq = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Res4_rq = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_MsgR1_rq = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_MsgR2_rq = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_MsgR3_rq = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_MsgR4_rq = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_hab = new global::System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Col_Esc_1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Esc_2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Esc_3 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Esc_4 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Esc_5 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Esc_6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Esc_7 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Esc_8 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Esc_9 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Esc_10 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Esc_11 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Esc_12 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Esc_13 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Esc_14 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Esc_15 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Col_Esc_16 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Grupo_conf_comunicacao.SuspendLayout();
			
			
			
			
			
			
			this.Grupo_lapelas.SuspendLayout();
			this.TabControl2.SuspendLayout();
			this.Conf_res.SuspendLayout();
			
			this.Conf_rq.SuspendLayout();
			
			this.Conf_centrais.SuspendLayout();
			
			
			
			this.Grupo_conf_equipamentos.SuspendLayout();
			
			
			
			
			
			
			
			this.Grupo_comandos.SuspendLayout();
			this.MenuStrip1.SuspendLayout();
			this.SuspendLayout();
			this.Grupo_conf_comunicacao.Controls.Add(this.Valor_intervalo_polling);
			this.Grupo_conf_comunicacao.Controls.Add(this.Label_intervalo_polling);
			this.Grupo_conf_comunicacao.Controls.Add(this.Valor_erro_falha);
			this.Grupo_conf_comunicacao.Controls.Add(this.Label_erros_falha);
			this.Grupo_conf_comunicacao.Controls.Add(this.Valor_timeout);
			this.Grupo_conf_comunicacao.Controls.Add(this.Label_timeout);
			this.Grupo_conf_comunicacao.Controls.Add(this.Combo_baudrate);
			this.Grupo_conf_comunicacao.Controls.Add(this.Label_baudrate);
			this.Grupo_conf_comunicacao.Controls.Add(this.Valor_temp_ptt);
			this.Grupo_conf_comunicacao.Controls.Add(this.Valor_endereco);
			this.Grupo_conf_comunicacao.Controls.Add(this.Valor_num_tentativas);
			this.Grupo_conf_comunicacao.Controls.Add(this.Label_tempo_ptt);
			this.Grupo_conf_comunicacao.Controls.Add(this.Label_endereco);
			this.Grupo_conf_comunicacao.Controls.Add(this.Label_retry);
			global::System.Windows.Forms.Control grupo_conf_comunicacao = this.Grupo_conf_comunicacao;
			grupo_conf_comunicacao.Location = new global::System.Drawing.Point(12, 12);
			this.Grupo_conf_comunicacao.Name = "Grupo_conf_comunicacao";
			global::System.Windows.Forms.Control grupo_conf_comunicacao2 = this.Grupo_conf_comunicacao;
			grupo_conf_comunicacao2.Size = new global::System.Drawing.Size(305, 250);
			this.Grupo_conf_comunicacao.TabIndex = 1;
			this.Grupo_conf_comunicacao.TabStop = false;
			this.Grupo_conf_comunicacao.Text = "Configuração comunicação";
			global::System.Windows.Forms.Control valor_intervalo_polling = this.Valor_intervalo_polling;
valor_intervalo_polling.Location = new global::System.Drawing.Point(200, 92);
			global::System.Windows.Forms.NumericUpDown valor_intervalo_polling2 = this.Valor_intervalo_polling;
			decimal num;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			valor_intervalo_polling2.Maximum = num;
			global::System.Windows.Forms.NumericUpDown valor_intervalo_polling3 = this.Valor_intervalo_polling;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_intervalo_polling3.Minimum = num;
			this.Valor_intervalo_polling.Name = "Valor_intervalo_polling";
			global::System.Windows.Forms.Control valor_intervalo_polling4 = this.Valor_intervalo_polling;
			Size = new System.Drawing.Size(93, 20);
			valor_intervalo_polling4.Size = this.Size;
			this.Valor_intervalo_polling.TabIndex = 25;
			this.Valor_intervalo_polling.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.NumericUpDown valor_intervalo_polling5 = this.Valor_intervalo_polling;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_intervalo_polling5.Value = num;
			this.Label_intervalo_polling.AutoSize = true;
			global::System.Windows.Forms.Control label_intervalo_polling = this.Label_intervalo_polling;
label_intervalo_polling.Location = new global::System.Drawing.Point(15, 94);
			this.Label_intervalo_polling.Name = "Label_intervalo_polling";
			global::System.Windows.Forms.Control label_intervalo_polling2 = this.Label_intervalo_polling;
			Size = new System.Drawing.Size(182, 13);
			label_intervalo_polling2.Size = this.Size;
			this.Label_intervalo_polling.TabIndex = 24;
			this.Label_intervalo_polling.Text = "Intervalo entre comunicações (seg.) :";
			global::System.Windows.Forms.Control valor_erro_falha = this.Valor_erro_falha;
valor_erro_falha.Location = new global::System.Drawing.Point(200, 185);
			global::System.Windows.Forms.NumericUpDown valor_erro_falha2 = this.Valor_erro_falha;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			valor_erro_falha2.Maximum = num;
			global::System.Windows.Forms.NumericUpDown valor_erro_falha3 = this.Valor_erro_falha;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_erro_falha3.Minimum = num;
			this.Valor_erro_falha.Name = "Valor_erro_falha";
			global::System.Windows.Forms.Control valor_erro_falha4 = this.Valor_erro_falha;
			Size = new System.Drawing.Size(93, 20);
			valor_erro_falha4.Size = this.Size;
			this.Valor_erro_falha.TabIndex = 23;
			this.Valor_erro_falha.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.NumericUpDown valor_erro_falha5 = this.Valor_erro_falha;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_erro_falha5.Value = num;
			this.Label_erros_falha.AutoSize = true;
			global::System.Windows.Forms.Control label_erros_falha = this.Label_erros_falha;
label_erros_falha.Location = new global::System.Drawing.Point(15, 187);
			this.Label_erros_falha.Name = "Label_erros_falha";
			global::System.Windows.Forms.Control label_erros_falha2 = this.Label_erros_falha;
			Size = new System.Drawing.Size(153, 13);
			label_erros_falha2.Size = this.Size;
			this.Label_erros_falha.TabIndex = 22;
			this.Label_erros_falha.Text = "Número erros para gerar falha :";
			global::System.Windows.Forms.Control valor_timeout = this.Valor_timeout;
valor_timeout.Location = new global::System.Drawing.Point(200, 123);
			global::System.Windows.Forms.NumericUpDown valor_timeout2 = this.Valor_timeout;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			valor_timeout2.Maximum = num;
			this.Valor_timeout.Name = "Valor_timeout";
			global::System.Windows.Forms.Control valor_timeout3 = this.Valor_timeout;
			Size = new System.Drawing.Size(93, 20);
			valor_timeout3.Size = this.Size;
			this.Valor_timeout.TabIndex = 21;
			this.Valor_timeout.TextAlign = HorizontalAlignment.Right;
			this.Label_timeout.AutoSize = true;
			global::System.Windows.Forms.Control label_timeout = this.Label_timeout;
label_timeout.Location = new global::System.Drawing.Point(15, 125);
			this.Label_timeout.Name = "Label_timeout";
			global::System.Windows.Forms.Control label_timeout2 = this.Label_timeout;
			Size = new System.Drawing.Size(165, 13);
			label_timeout2.Size = this.Size;
			this.Label_timeout.TabIndex = 20;
			this.Label_timeout.Text = "Tempo espera de resposta (seg.):";
			this.Combo_baudrate.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_baudrate = this.Combo_baudrate;
combo_baudrate.Location = new global::System.Drawing.Point(200, 216);
			this.Combo_baudrate.Name = "Combo_baudrate";
			global::System.Windows.Forms.Control combo_baudrate2 = this.Combo_baudrate;
			Size = new System.Drawing.Size(93, 21);
			combo_baudrate2.Size = this.Size;
			this.Combo_baudrate.TabIndex = 18;
			this.Label_baudrate.AutoSize = true;
			global::System.Windows.Forms.Control label_baudrate = this.Label_baudrate;
label_baudrate.Location = new global::System.Drawing.Point(15, 218);
			this.Label_baudrate.Name = "Label_baudrate";
			global::System.Windows.Forms.Control label_baudrate2 = this.Label_baudrate;
			Size = new System.Drawing.Size(95, 13);
			label_baudrate2.Size = this.Size;
			this.Label_baudrate.TabIndex = 19;
			this.Label_baudrate.Text = "Baud rate COM 2 :";
			global::System.Windows.Forms.NumericUpDown valor_temp_ptt = this.Valor_temp_ptt;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			valor_temp_ptt.Increment = num;
			global::System.Windows.Forms.Control valor_temp_ptt2 = this.Valor_temp_ptt;
valor_temp_ptt2.Location = new global::System.Drawing.Point(200, 61);
			global::System.Windows.Forms.NumericUpDown valor_temp_ptt3 = this.Valor_temp_ptt;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			valor_temp_ptt3.Maximum = num;
			this.Valor_temp_ptt.Name = "Valor_temp_ptt";
			global::System.Windows.Forms.Control valor_temp_ptt4 = this.Valor_temp_ptt;
			Size = new System.Drawing.Size(93, 20);
			valor_temp_ptt4.Size = this.Size;
			this.Valor_temp_ptt.TabIndex = 17;
			this.Valor_temp_ptt.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.Control valor_endereco = this.Valor_endereco;
valor_endereco.Location = new global::System.Drawing.Point(200, 30);
			global::System.Windows.Forms.NumericUpDown valor_endereco2 = this.Valor_endereco;
			num = new decimal(new int[]
			{
				200,
				0,
				0,
				0
			});
			valor_endereco2.Maximum = num;
			this.Valor_endereco.Name = "Valor_endereco";
			global::System.Windows.Forms.Control valor_endereco3 = this.Valor_endereco;
			Size = new System.Drawing.Size(93, 20);
			valor_endereco3.Size = this.Size;
			this.Valor_endereco.TabIndex = 16;
			this.Valor_endereco.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.Control valor_num_tentativas = this.Valor_num_tentativas;
valor_num_tentativas.Location = new global::System.Drawing.Point(200, 154);
			global::System.Windows.Forms.NumericUpDown valor_num_tentativas2 = this.Valor_num_tentativas;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			valor_num_tentativas2.Maximum = num;
			global::System.Windows.Forms.NumericUpDown valor_num_tentativas3 = this.Valor_num_tentativas;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_num_tentativas3.Minimum = num;
			this.Valor_num_tentativas.Name = "Valor_num_tentativas";
			global::System.Windows.Forms.Control valor_num_tentativas4 = this.Valor_num_tentativas;
			Size = new System.Drawing.Size(93, 20);
			valor_num_tentativas4.Size = this.Size;
			this.Valor_num_tentativas.TabIndex = 15;
			this.Valor_num_tentativas.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.NumericUpDown valor_num_tentativas5 = this.Valor_num_tentativas;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_num_tentativas5.Value = num;
			this.Label_tempo_ptt.AutoSize = true;
			global::System.Windows.Forms.Control label_tempo_ptt = this.Label_tempo_ptt;
label_tempo_ptt.Location = new global::System.Drawing.Point(15, 63);
			this.Label_tempo_ptt.Name = "Label_tempo_ptt";
			global::System.Windows.Forms.Control label_tempo_ptt2 = this.Label_tempo_ptt;
			Size = new System.Drawing.Size(123, 13);
			label_tempo_ptt2.Size = this.Size;
			this.Label_tempo_ptt.TabIndex = 14;
			this.Label_tempo_ptt.Text = "Tempo PTT ligado (ms) :";
			this.Label_endereco.AutoSize = true;
			global::System.Windows.Forms.Control label_endereco = this.Label_endereco;
label_endereco.Location = new global::System.Drawing.Point(15, 32);
			this.Label_endereco.Name = "Label_endereco";
			global::System.Windows.Forms.Control label_endereco2 = this.Label_endereco;
			Size = new System.Drawing.Size(109, 13);
			label_endereco2.Size = this.Size;
			this.Label_endereco.TabIndex = 13;
			this.Label_endereco.Text = "Endereço da central :";
			this.Label_retry.AutoSize = true;
			global::System.Windows.Forms.Control label_retry = this.Label_retry;
label_retry.Location = new global::System.Drawing.Point(15, 156);
			this.Label_retry.Name = "Label_retry";
			global::System.Windows.Forms.Control label_retry2 = this.Label_retry;
			Size = new System.Drawing.Size(99, 13);
			label_retry2.Size = this.Size;
			this.Label_retry.TabIndex = 12;
			this.Label_retry.Text = "Número tentativas :";
			this.Grupo_lapelas.Controls.Add(this.TabControl2);
			global::System.Windows.Forms.Control grupo_lapelas = this.Grupo_lapelas;
grupo_lapelas.Location = new global::System.Drawing.Point(336, 12);
			this.Grupo_lapelas.Name = "Grupo_lapelas";
			global::System.Windows.Forms.Control grupo_lapelas2 = this.Grupo_lapelas;
			Size = new System.Drawing.Size(801, 636);
			grupo_lapelas2.Size = this.Size;
			this.Grupo_lapelas.TabIndex = 3;
			this.Grupo_lapelas.TabStop = false;
			this.Grupo_lapelas.Text = "Configuração de equipamentos de reservatórios";
			this.TabControl2.Appearance = (System.Windows.Forms.TabAppearance)1;
			this.TabControl2.Controls.Add(this.Conf_res);
			this.TabControl2.Controls.Add(this.Conf_rq);
			this.TabControl2.Controls.Add(this.Conf_centrais);
			global::System.Windows.Forms.Control tabControl = this.TabControl2;
tabControl.Location = new global::System.Drawing.Point(23, 30);
			this.TabControl2.Multiline = true;
			this.TabControl2.Name = "TabControl2";
			this.TabControl2.RightToLeftLayout = true;
			this.TabControl2.SelectedIndex = 0;
			global::System.Windows.Forms.Control tabControl2 = this.TabControl2;
			Size = new System.Drawing.Size(738, 589);
			tabControl2.Size = this.Size;
			this.TabControl2.SizeMode = (System.Windows.Forms.TabSizeMode)2;
			this.TabControl2.TabIndex = 4;
			this.Conf_res.Controls.Add(this.DataGridView1);
			global::System.Windows.Forms.TabPage conf_res = this.Conf_res;
conf_res.Location = new global::System.Drawing.Point(4, 25);
			this.Conf_res.Name = "Conf_res";
			global::System.Windows.Forms.Control conf_res2 = this.Conf_res;
			global::System.Windows.Forms.Padding Padding;
			Padding = new global::System.Windows.Forms.Padding(3);
			conf_res2.Padding = Padding;
			global::System.Windows.Forms.Control conf_res3 = this.Conf_res;
			Size = new System.Drawing.Size(730, 560);
			conf_res3.Size = this.Size;
			this.Conf_res.TabIndex = 0;
			this.Conf_res.Text = "Reservatórios";
			this.Conf_res.UseVisualStyleBackColor = true;
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.BackgroundColor = global::System.Drawing.SystemColors.Control;
			this.DataGridView1.BorderStyle = BorderStyle.None;
			this.DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
			this.DataGridView1.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			this.DataGridView1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Col_end,
				this.Col_nome,
				this.Col_altura,
				this.Col_pri,
				this.Col_posicao
			});
			dataGridViewCellStyle.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle;
			global::System.Windows.Forms.Control dataGridView = this.DataGridView1;
dataGridView.Location = new global::System.Drawing.Point(3, 0);
			this.DataGridView1.Name = "DataGridView1";
			dataGridViewCellStyle2.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)32;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			global::System.Windows.Forms.Control dataGridView2 = this.DataGridView1;
			Size = new System.Drawing.Size(375, 560);
			dataGridView2.Size = this.Size;
			this.DataGridView1.TabIndex = 3;
			this.Conf_rq.Controls.Add(this.DataGridView_RQ);
			global::System.Windows.Forms.TabPage conf_rq = this.Conf_rq;
conf_rq.Location = new global::System.Drawing.Point(4, 25);
			this.Conf_rq.Name = "Conf_rq";
			global::System.Windows.Forms.Control conf_rq2 = this.Conf_rq;
			Padding = new Padding(3);
			conf_rq2.Padding = Padding;
			global::System.Windows.Forms.Control conf_rq3 = this.Conf_rq;
			Size = new System.Drawing.Size(730, 560);
			conf_rq3.Size = this.Size;
			this.Conf_rq.TabIndex = 1;
			this.Conf_rq.Text = "Recalques";
			this.Conf_rq.UseVisualStyleBackColor = true;
			this.DataGridView_RQ.AllowUserToAddRows = false;
			this.DataGridView_RQ.BackgroundColor = global::System.Drawing.SystemColors.Control;
			this.DataGridView_RQ.BorderStyle = BorderStyle.None;
			this.DataGridView_RQ.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
			this.DataGridView_RQ.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			this.DataGridView_RQ.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Col_End_rq,
				this.Col_nome_rq,
				this.Col_ROrg_rq,
				this.Col_RDest_rq,
				this.Col_mod_rq,
				this.Col_pri_rq,
				this.Col_Res1_rq,
				this.Col_Res2_rq,
				this.Col_Res3_rq,
				this.Col_Res4_rq,
				this.Col_MsgR1_rq,
				this.Col_MsgR2_rq,
				this.Col_MsgR3_rq,
				this.Col_MsgR4_rq,
				this.Col_hab,
				this.Col_Esc_1,
				this.Col_Esc_2,
				this.Col_Esc_3,
				this.Col_Esc_4,
				this.Col_Esc_5,
				this.Col_Esc_6,
				this.Col_Esc_7,
				this.Col_Esc_8,
				this.Col_Esc_9,
				this.Col_Esc_10,
				this.Col_Esc_11,
				this.Col_Esc_12,
				this.Col_Esc_13,
				this.Col_Esc_14,
				this.Col_Esc_15,
				this.Col_Esc_16
			});
			dataGridViewCellStyle3.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView_RQ.DefaultCellStyle = dataGridViewCellStyle3;
			global::System.Windows.Forms.Control dataGridView_RQ = this.DataGridView_RQ;
dataGridView_RQ.Location = new global::System.Drawing.Point(3, 3);
			this.DataGridView_RQ.Name = "DataGridView_RQ";
			dataGridViewCellStyle4.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)32;
			dataGridViewCellStyle4.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView_RQ.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			global::System.Windows.Forms.Control dataGridView_RQ2 = this.DataGridView_RQ;
			Size = new System.Drawing.Size(721, 546);
			dataGridView_RQ2.Size = this.Size;
			this.DataGridView_RQ.TabIndex = 4;
			this.Conf_centrais.Controls.Add(this.DataGridView_central_rq);
			this.Conf_centrais.Controls.Add(this.DataGridView_central_res);
			this.Conf_centrais.Controls.Add(this.Label_rq);
			this.Conf_centrais.Controls.Add(this.Label_res);
			this.Conf_centrais.Controls.Add(this.DataGridView_central_geral);
			global::System.Windows.Forms.TabPage conf_centrais = this.Conf_centrais;
conf_centrais.Location = new global::System.Drawing.Point(4, 25);
			this.Conf_centrais.Name = "Conf_centrais";
			global::System.Windows.Forms.Control conf_centrais2 = this.Conf_centrais;
			Size = new System.Drawing.Size(730, 560);
			conf_centrais2.Size = this.Size;
			this.Conf_centrais.TabIndex = 2;
			this.Conf_centrais.Text = "Centrais";
			this.Conf_centrais.UseVisualStyleBackColor = true;
			this.DataGridView_central_rq.AllowUserToAddRows = false;
			this.DataGridView_central_rq.BackgroundColor = global::System.Drawing.SystemColors.Control;
			this.DataGridView_central_rq.BorderStyle = BorderStyle.None;
			this.DataGridView_central_rq.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
			this.DataGridView_central_rq.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			this.DataGridView_central_rq.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Col_ct_rq_end
			});
			global::System.Windows.Forms.Control dataGridView_central_rq = this.DataGridView_central_rq;
dataGridView_central_rq.Location = new global::System.Drawing.Point(0, 374);
			this.DataGridView_central_rq.Name = "DataGridView_central_rq";
			global::System.Windows.Forms.Control dataGridView_central_rq2 = this.DataGridView_central_rq;
			Size = new System.Drawing.Size(728, 183);
			dataGridView_central_rq2.Size = this.Size;
			this.DataGridView_central_rq.TabIndex = 20;
			dataGridViewCellStyle5.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.Col_ct_rq_end.DefaultCellStyle = dataGridViewCellStyle5;
			this.Col_ct_rq_end.Frozen = true;
			this.Col_ct_rq_end.HeaderText = "End";
			this.Col_ct_rq_end.MaxInputLength = 200;
			this.Col_ct_rq_end.Name = "Col_ct_rq_end";
			this.Col_ct_rq_end.ReadOnly = true;
			this.Col_ct_rq_end.SortMode = 0;
			this.Col_ct_rq_end.Width = 60;
			this.DataGridView_central_res.AllowUserToAddRows = false;
			this.DataGridView_central_res.BackgroundColor = global::System.Drawing.SystemColors.Control;
			this.DataGridView_central_res.BorderStyle = BorderStyle.None;
			this.DataGridView_central_res.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
			this.DataGridView_central_res.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			this.DataGridView_central_res.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Col_ct_res_end
			});
			global::System.Windows.Forms.Control dataGridView_central_res = this.DataGridView_central_res;
dataGridView_central_res.Location = new global::System.Drawing.Point(2, 186);
			this.DataGridView_central_res.Name = "DataGridView_central_res";
			global::System.Windows.Forms.Control dataGridView_central_res2 = this.DataGridView_central_res;
			Size = new System.Drawing.Size(732, 154);
			dataGridView_central_res2.Size = this.Size;
			this.DataGridView_central_res.TabIndex = 19;
			dataGridViewCellStyle6.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.Col_ct_res_end.DefaultCellStyle = dataGridViewCellStyle6;
			this.Col_ct_res_end.Frozen = true;
			this.Col_ct_res_end.HeaderText = "End";
			this.Col_ct_res_end.MaxInputLength = 200;
			this.Col_ct_res_end.Name = "Col_ct_res_end";
			this.Col_ct_res_end.ReadOnly = true;
			this.Col_ct_res_end.SortMode = 0;
			this.Col_ct_res_end.Width = 60;
			this.Label_rq.AutoSize = true;
			global::System.Windows.Forms.Control label_rq = this.Label_rq;
label_rq.Location = new global::System.Drawing.Point(0, 358);
			this.Label_rq.Name = "Label_rq";
			global::System.Windows.Forms.Control label_rq2 = this.Label_rq;
			Size = new System.Drawing.Size(64, 13);
			label_rq2.Size = this.Size;
			this.Label_rq.TabIndex = 17;
			this.Label_rq.Text = "Recalques :";
			this.Label_res.AutoSize = true;
			global::System.Windows.Forms.Control label_res = this.Label_res;
label_res.Location = new global::System.Drawing.Point(-3, 170);
			this.Label_res.Name = "Label_res";
			global::System.Windows.Forms.Control label_res2 = this.Label_res;
			Size = new System.Drawing.Size(78, 13);
			label_res2.Size = this.Size;
			this.Label_res.TabIndex = 17;
			this.Label_res.Text = "Reservatórios :";
			this.DataGridView_central_geral.AllowUserToAddRows = false;
			this.DataGridView_central_geral.BackgroundColor = global::System.Drawing.SystemColors.Control;
			this.DataGridView_central_geral.BorderStyle = BorderStyle.None;
			this.DataGridView_central_geral.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
			this.DataGridView_central_geral.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			this.DataGridView_central_geral.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Col_vista_end,
				this.Col_vista_res,
				this.Col_vista_rq,
				this.Col_vista_pri
			});
			global::System.Windows.Forms.Control dataGridView_central_geral = this.DataGridView_central_geral;
dataGridView_central_geral.Location = new global::System.Drawing.Point(3, 6);
			this.DataGridView_central_geral.Name = "DataGridView_central_geral";
			global::System.Windows.Forms.Control dataGridView_central_geral2 = this.DataGridView_central_geral;
			Size = new System.Drawing.Size(367, 177);
			dataGridView_central_geral2.Size = this.Size;
			this.DataGridView_central_geral.TabIndex = 0;
			this.Col_vista_end.HeaderText = "Endereço";
			this.Col_vista_end.MaxInputLength = 2;
			this.Col_vista_end.Name = "Col_vista_end";
			this.Col_vista_end.ReadOnly = true;
			this.Col_vista_end.SortMode = 0;
			this.Col_vista_end.Width = 60;
			this.Col_vista_res.HeaderText = "N° Reserv.";
			this.Col_vista_res.MaxInputLength = 2;
			this.Col_vista_res.Name = "Col_vista_res";
			this.Col_vista_res.SortMode = 0;
			this.Col_vista_res.Width = 95;
			this.Col_vista_rq.HeaderText = "N° Recalques";
			this.Col_vista_rq.MaxInputLength = 2;
			this.Col_vista_rq.Name = "Col_vista_rq";
			this.Col_vista_rq.SortMode = 0;
			this.Col_vista_rq.Width = 95;
			this.Col_vista_pri.HeaderText = "Prioridade";
			this.Col_vista_pri.MaxInputLength = 2;
			this.Col_vista_pri.Name = "Col_vista_pri";
			this.Col_vista_pri.SortMode = 0;
			this.Col_vista_pri.Width = 70;
			this.Grupo_conf_equipamentos.Controls.Add(this.Valor_vista_equipamentos);
			this.Grupo_conf_equipamentos.Controls.Add(this.Label_vista_equipamentos);
			this.Grupo_conf_equipamentos.Controls.Add(this.Valor_end_ini_vista);
			this.Grupo_conf_equipamentos.Controls.Add(this.Label_end_ini_vista);
			this.Grupo_conf_equipamentos.Controls.Add(this.Valor_end_ini_rq);
			this.Grupo_conf_equipamentos.Controls.Add(this.Label_end_ini_rq);
			this.Grupo_conf_equipamentos.Controls.Add(this.Valor_end_ini_res);
			this.Grupo_conf_equipamentos.Controls.Add(this.Label_end_ini_res);
			this.Grupo_conf_equipamentos.Controls.Add(this.Valor_rq_equipamentos);
			this.Grupo_conf_equipamentos.Controls.Add(this.Label_rq_equipamentos);
			this.Grupo_conf_equipamentos.Controls.Add(this.Valor_res_equipamentos);
			this.Grupo_conf_equipamentos.Controls.Add(this.Label_res_equipamentos);
			this.Grupo_conf_equipamentos.Controls.Add(this.Valor_res_sistema);
			this.Grupo_conf_equipamentos.Controls.Add(this.Label_res_sistema);
			global::System.Windows.Forms.Control grupo_conf_equipamentos = this.Grupo_conf_equipamentos;
grupo_conf_equipamentos.Location = new global::System.Drawing.Point(12, 268);
			this.Grupo_conf_equipamentos.Name = "Grupo_conf_equipamentos";
			global::System.Windows.Forms.Control grupo_conf_equipamentos2 = this.Grupo_conf_equipamentos;
			Size = new System.Drawing.Size(305, 252);
			grupo_conf_equipamentos2.Size = this.Size;
			this.Grupo_conf_equipamentos.TabIndex = 4;
			this.Grupo_conf_equipamentos.TabStop = false;
			this.Grupo_conf_equipamentos.Text = "Configuracao de equipamentos";
			global::System.Windows.Forms.Control valor_vista_equipamentos = this.Valor_vista_equipamentos;
valor_vista_equipamentos.Location = new global::System.Drawing.Point(200, 125);
			global::System.Windows.Forms.NumericUpDown valor_vista_equipamentos2 = this.Valor_vista_equipamentos;
			num = new decimal(new int[]
			{
				5,
				0,
				0,
				0
			});
			valor_vista_equipamentos2.Maximum = num;
			this.Valor_vista_equipamentos.Name = "Valor_vista_equipamentos";
			global::System.Windows.Forms.Control valor_vista_equipamentos3 = this.Valor_vista_equipamentos;
			Size = new System.Drawing.Size(93, 20);
			valor_vista_equipamentos3.Size = this.Size;
			this.Valor_vista_equipamentos.TabIndex = 29;
			this.Valor_vista_equipamentos.TextAlign = HorizontalAlignment.Right;
			this.Label_vista_equipamentos.AutoSize = true;
			global::System.Windows.Forms.Control label_vista_equipamentos = this.Label_vista_equipamentos;
label_vista_equipamentos.Location = new global::System.Drawing.Point(11, 127);
			this.Label_vista_equipamentos.Name = "Label_vista_equipamentos";
			global::System.Windows.Forms.Control label_vista_equipamentos2 = this.Label_vista_equipamentos;
			Size = new System.Drawing.Size(137, 13);
			label_vista_equipamentos2.Size = this.Size;
			this.Label_vista_equipamentos.TabIndex = 28;
			this.Label_vista_equipamentos.Text = "Número de equip. de vista :";
			global::System.Windows.Forms.Control valor_end_ini_vista = this.Valor_end_ini_vista;
valor_end_ini_vista.Location = new global::System.Drawing.Point(200, 215);
			global::System.Windows.Forms.NumericUpDown valor_end_ini_vista2 = this.Valor_end_ini_vista;
			num = new decimal(new int[]
			{
				200,
				0,
				0,
				0
			});
			valor_end_ini_vista2.Maximum = num;
			global::System.Windows.Forms.NumericUpDown valor_end_ini_vista3 = this.Valor_end_ini_vista;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_end_ini_vista3.Minimum = num;
			this.Valor_end_ini_vista.Name = "Valor_end_ini_vista";
			global::System.Windows.Forms.Control valor_end_ini_vista4 = this.Valor_end_ini_vista;
			Size = new System.Drawing.Size(93, 20);
			valor_end_ini_vista4.Size = this.Size;
			this.Valor_end_ini_vista.TabIndex = 27;
			this.Valor_end_ini_vista.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.NumericUpDown valor_end_ini_vista5 = this.Valor_end_ini_vista;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_end_ini_vista5.Value = num;
			this.Label_end_ini_vista.AutoSize = true;
			global::System.Windows.Forms.Control label_end_ini_vista = this.Label_end_ini_vista;
label_end_ini_vista.Location = new global::System.Drawing.Point(14, 217);
			this.Label_end_ini_vista.Name = "Label_end_ini_vista";
			global::System.Windows.Forms.Control label_end_ini_vista2 = this.Label_end_ini_vista;
			Size = new System.Drawing.Size(130, 13);
			label_end_ini_vista2.Size = this.Size;
			this.Label_end_ini_vista.TabIndex = 26;
			this.Label_end_ini_vista.Text = "End. com. inicial de vista :";
			global::System.Windows.Forms.Control valor_end_ini_rq = this.Valor_end_ini_rq;
valor_end_ini_rq.Location = new global::System.Drawing.Point(200, 185);
			global::System.Windows.Forms.NumericUpDown valor_end_ini_rq2 = this.Valor_end_ini_rq;
			num = new decimal(new int[]
			{
				200,
				0,
				0,
				0
			});
			valor_end_ini_rq2.Maximum = num;
			global::System.Windows.Forms.NumericUpDown valor_end_ini_rq3 = this.Valor_end_ini_rq;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_end_ini_rq3.Minimum = num;
			this.Valor_end_ini_rq.Name = "Valor_end_ini_rq";
			global::System.Windows.Forms.Control valor_end_ini_rq4 = this.Valor_end_ini_rq;
			Size = new System.Drawing.Size(93, 20);
			valor_end_ini_rq4.Size = this.Size;
			this.Valor_end_ini_rq.TabIndex = 25;
			this.Valor_end_ini_rq.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.NumericUpDown valor_end_ini_rq5 = this.Valor_end_ini_rq;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_end_ini_rq5.Value = num;
			this.Label_end_ini_rq.AutoSize = true;
			global::System.Windows.Forms.Control label_end_ini_rq = this.Label_end_ini_rq;
label_end_ini_rq.Location = new global::System.Drawing.Point(11, 187);
			this.Label_end_ini_rq.Name = "Label_end_ini_rq";
			global::System.Windows.Forms.Control label_end_ini_rq2 = this.Label_end_ini_rq;
			Size = new System.Drawing.Size(149, 13);
			label_end_ini_rq2.Size = this.Size;
			this.Label_end_ini_rq.TabIndex = 24;
			this.Label_end_ini_rq.Text = "End. com. inicial de recalque :";
			global::System.Windows.Forms.Control valor_end_ini_res = this.Valor_end_ini_res;
valor_end_ini_res.Location = new global::System.Drawing.Point(200, 155);
			global::System.Windows.Forms.NumericUpDown valor_end_ini_res2 = this.Valor_end_ini_res;
			num = new decimal(new int[]
			{
				200,
				0,
				0,
				0
			});
			valor_end_ini_res2.Maximum = num;
			global::System.Windows.Forms.NumericUpDown valor_end_ini_res3 = this.Valor_end_ini_res;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_end_ini_res3.Minimum = num;
			this.Valor_end_ini_res.Name = "Valor_end_ini_res";
			global::System.Windows.Forms.Control valor_end_ini_res4 = this.Valor_end_ini_res;
			Size = new System.Drawing.Size(93, 20);
			valor_end_ini_res4.Size = this.Size;
			this.Valor_end_ini_res.TabIndex = 23;
			this.Valor_end_ini_res.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.NumericUpDown valor_end_ini_res5 = this.Valor_end_ini_res;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_end_ini_res5.Value = num;
			this.Label_end_ini_res.AutoSize = true;
			global::System.Windows.Forms.Control label_end_ini_res = this.Label_end_ini_res;
label_end_ini_res.Location = new global::System.Drawing.Point(11, 157);
			this.Label_end_ini_res.Name = "Label_end_ini_res";
			global::System.Windows.Forms.Control label_end_ini_res2 = this.Label_end_ini_res;
			Size = new System.Drawing.Size(163, 13);
			label_end_ini_res2.Size = this.Size;
			this.Label_end_ini_res.TabIndex = 22;
			this.Label_end_ini_res.Text = "End. com. inicial de reservatório :";
			global::System.Windows.Forms.Control valor_rq_equipamentos = this.Valor_rq_equipamentos;
valor_rq_equipamentos.Location = new global::System.Drawing.Point(200, 95);
			global::System.Windows.Forms.NumericUpDown valor_rq_equipamentos2 = this.Valor_rq_equipamentos;
			num = new decimal(new int[]
			{
				28,
				0,
				0,
				0
			});
			valor_rq_equipamentos2.Maximum = num;
			this.Valor_rq_equipamentos.Name = "Valor_rq_equipamentos";
			global::System.Windows.Forms.Control valor_rq_equipamentos3 = this.Valor_rq_equipamentos;
			Size = new System.Drawing.Size(93, 20);
			valor_rq_equipamentos3.Size = this.Size;
			this.Valor_rq_equipamentos.TabIndex = 21;
			this.Valor_rq_equipamentos.TextAlign = HorizontalAlignment.Right;
			this.Label_rq_equipamentos.AutoSize = true;
			global::System.Windows.Forms.Control label_rq_equipamentos = this.Label_rq_equipamentos;
label_rq_equipamentos.Location = new global::System.Drawing.Point(11, 97);
			this.Label_rq_equipamentos.Name = "Label_rq_equipamentos";
			global::System.Windows.Forms.Control label_rq_equipamentos2 = this.Label_rq_equipamentos;
			Size = new System.Drawing.Size(156, 13);
			label_rq_equipamentos2.Size = this.Size;
			this.Label_rq_equipamentos.TabIndex = 20;
			this.Label_rq_equipamentos.Text = "Número de equip. de recalque :";
			global::System.Windows.Forms.Control valor_res_equipamentos = this.Valor_res_equipamentos;
valor_res_equipamentos.Location = new global::System.Drawing.Point(200, 65);
			global::System.Windows.Forms.NumericUpDown valor_res_equipamentos2 = this.Valor_res_equipamentos;
			num = new decimal(new int[]
			{
				40,
				0,
				0,
				0
			});
			valor_res_equipamentos2.Maximum = num;
			this.Valor_res_equipamentos.Name = "Valor_res_equipamentos";
			global::System.Windows.Forms.Control valor_res_equipamentos3 = this.Valor_res_equipamentos;
			Size = new System.Drawing.Size(93, 20);
			valor_res_equipamentos3.Size = this.Size;
			this.Valor_res_equipamentos.TabIndex = 19;
			this.Valor_res_equipamentos.TextAlign = HorizontalAlignment.Right;
			this.Label_res_equipamentos.AutoSize = true;
			global::System.Windows.Forms.Control label_res_equipamentos = this.Label_res_equipamentos;
label_res_equipamentos.Location = new global::System.Drawing.Point(11, 67);
			this.Label_res_equipamentos.Name = "Label_res_equipamentos";
			global::System.Windows.Forms.Control label_res_equipamentos2 = this.Label_res_equipamentos;
			Size = new System.Drawing.Size(170, 13);
			label_res_equipamentos2.Size = this.Size;
			this.Label_res_equipamentos.TabIndex = 18;
			this.Label_res_equipamentos.Text = "Número de equip. de reservatório :";
			global::System.Windows.Forms.Control valor_res_sistema = this.Valor_res_sistema;
valor_res_sistema.Location = new global::System.Drawing.Point(200, 35);
			global::System.Windows.Forms.NumericUpDown valor_res_sistema2 = this.Valor_res_sistema;
			num = new decimal(new int[]
			{
				60,
				0,
				0,
				0
			});
			valor_res_sistema2.Maximum = num;
			this.Valor_res_sistema.Name = "Valor_res_sistema";
			global::System.Windows.Forms.Control valor_res_sistema3 = this.Valor_res_sistema;
			Size = new System.Drawing.Size(93, 20);
			valor_res_sistema3.Size = this.Size;
			this.Valor_res_sistema.TabIndex = 17;
			this.Valor_res_sistema.TextAlign = HorizontalAlignment.Right;
			this.Label_res_sistema.AutoSize = true;
			global::System.Windows.Forms.Control label_res_sistema = this.Label_res_sistema;
label_res_sistema.Location = new global::System.Drawing.Point(11, 37);
			this.Label_res_sistema.Name = "Label_res_sistema";
			global::System.Windows.Forms.Control label_res_sistema2 = this.Label_res_sistema;
			Size = new System.Drawing.Size(166, 13);
			label_res_sistema2.Size = this.Size;
			this.Label_res_sistema.TabIndex = 16;
			this.Label_res_sistema.Text = "Número reservatórios do sistema :";
			this.Grupo_comandos.Controls.Add(this.Esc_conf_md_302);
			this.Grupo_comandos.Controls.Add(this.Box_Msg);
			this.Grupo_comandos.Controls.Add(this.Ler_conf_md_302);
			global::System.Windows.Forms.Control grupo_comandos = this.Grupo_comandos;
grupo_comandos.Location = new global::System.Drawing.Point(12, 543);
			this.Grupo_comandos.Name = "Grupo_comandos";
			global::System.Windows.Forms.Control grupo_comandos2 = this.Grupo_comandos;
			Size = new System.Drawing.Size(305, 105);
			grupo_comandos2.Size = this.Size;
			this.Grupo_comandos.TabIndex = 5;
			this.Grupo_comandos.TabStop = false;
			this.Grupo_comandos.Text = "Comandos  e status";
			global::System.Windows.Forms.Control esc_conf_md_ = this.Esc_conf_md_302;
esc_conf_md_.Location = new global::System.Drawing.Point(170, 60);
			this.Esc_conf_md_302.Name = "Esc_conf_md_302";
			global::System.Windows.Forms.Control esc_conf_md_2 = this.Esc_conf_md_302;
			Size = new System.Drawing.Size(109, 28);
			esc_conf_md_2.Size = this.Size;
			this.Esc_conf_md_302.TabIndex = 4;
			this.Esc_conf_md_302.Text = "Salvar config.";
			this.Esc_conf_md_302.UseVisualStyleBackColor = true;
			this.Box_Msg.BackColor = global::System.Drawing.Color.Beige;
			global::System.Windows.Forms.Control box_Msg = this.Box_Msg;
box_Msg.Location = new global::System.Drawing.Point(17, 28);
			this.Box_Msg.Name = "Box_Msg";
			this.Box_Msg.ReadOnly = true;
			global::System.Windows.Forms.Control box_Msg2 = this.Box_Msg;
			Size = new System.Drawing.Size(262, 20);
			box_Msg2.Size = this.Size;
			this.Box_Msg.TabIndex = 5;
			this.Box_Msg.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.Control ler_conf_md_ = this.Ler_conf_md_302;
ler_conf_md_.Location = new global::System.Drawing.Point(17, 60);
			this.Ler_conf_md_302.Name = "Ler_conf_md_302";
			global::System.Windows.Forms.Control ler_conf_md_2 = this.Ler_conf_md_302;
			Size = new System.Drawing.Size(109, 28);
			ler_conf_md_2.Size = this.Size;
			this.Ler_conf_md_302.TabIndex = 3;
			this.Ler_conf_md_302.Text = "Ler configuração";
			this.Ler_conf_md_302.UseVisualStyleBackColor = true;
			this.MenuStrip1.Dock =(System.Windows.Forms.DockStyle) (System.Windows.Forms.DockStyle)2;
			this.MenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ArquivoToolStripMenuItem
			});
			global::System.Windows.Forms.Control menuStrip = this.MenuStrip1;
menuStrip.Location = new global::System.Drawing.Point(0, 652);
			this.MenuStrip1.Name = "MenuStrip1";
			global::System.Windows.Forms.Control menuStrip2 = this.MenuStrip1;
			Size = new System.Drawing.Size(1131, 24);
			menuStrip2.Size = this.Size;
			this.MenuStrip1.TabIndex = 6;
			this.MenuStrip1.Text = "MenuStrip1";
			this.ArquivoToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.NovoToolStripMenuItem,
				this.AbrirToolStripMenuItem,
				this.SalvarToolStripMenuItem
			});
			this.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem arquivoToolStripMenuItem = this.ArquivoToolStripMenuItem;
			Size = new System.Drawing.Size(61, 20);
			arquivoToolStripMenuItem.Size = this.Size;
			this.ArquivoToolStripMenuItem.Text = "Arquivo";
			this.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem novoToolStripMenuItem = this.NovoToolStripMenuItem;
			Size = new System.Drawing.Size(105, 22);
			novoToolStripMenuItem.Size = this.Size;
			this.NovoToolStripMenuItem.Text = "Novo";
			this.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem abrirToolStripMenuItem = this.AbrirToolStripMenuItem;
			Size = new System.Drawing.Size(105, 22);
			abrirToolStripMenuItem.Size = this.Size;
			this.AbrirToolStripMenuItem.Text = "Abrir";
			this.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem salvarToolStripMenuItem = this.SalvarToolStripMenuItem;
			Size = new System.Drawing.Size(105, 22);
			salvarToolStripMenuItem.Size = this.Size;
			this.SalvarToolStripMenuItem.Text = "Salvar";
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			this.Col_end.AutoSizeMode =(System.Windows.Forms.DataGridViewAutoSizeColumnMode)(System.Windows.Forms.AutoSizeMode) (System.Windows.Forms.AutoSizeMode)1;
			this.Col_end.HeaderText = "Endereço";
			this.Col_end.Name = "Col_end";
			this.Col_end.ReadOnly = true;
			this.Col_end.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_end.SortMode = 0;
			this.Col_end.Width = 55;
			dataGridViewCellStyle7.Format = "N0";
			dataGridViewCellStyle7.NullValue = null;
			this.Col_nome.DefaultCellStyle = dataGridViewCellStyle7;
			this.Col_nome.HeaderText = "Nome ";
			this.Col_nome.MaxInputLength = 3;
			this.Col_nome.Name = "Col_nome";
			this.Col_nome.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_nome.SortMode = 0;
			this.Col_nome.Width = 64;
			dataGridViewCellStyle8.Format = "N0";
			dataGridViewCellStyle8.NullValue = null;
			this.Col_altura.DefaultCellStyle = dataGridViewCellStyle8;
			this.Col_altura.HeaderText = "Altura (cm)";
			this.Col_altura.MaxInputLength = 5;
			this.Col_altura.Name = "Col_altura";
			this.Col_altura.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_altura.SortMode = 0;
			this.Col_altura.Width = 64;
			dataGridViewCellStyle9.Format = "N0";
			dataGridViewCellStyle9.NullValue = null;
			this.Col_pri.DefaultCellStyle = dataGridViewCellStyle9;
			this.Col_pri.HeaderText = "Prioridade (0-13)";
			this.Col_pri.MaxInputLength = 2;
			this.Col_pri.Name = "Col_pri";
			this.Col_pri.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_pri.SortMode = 0;
			this.Col_pri.Width = 64;
			dataGridViewCellStyle10.Format = "N0";
			dataGridViewCellStyle10.NullValue = null;
			this.Col_posicao.DefaultCellStyle = dataGridViewCellStyle10;
			this.Col_posicao.HeaderText = "Posição relativa(1-40)";
			this.Col_posicao.MaxInputLength = 2;
			this.Col_posicao.Name = "Col_posicao";
			this.Col_posicao.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_posicao.SortMode = 0;
			this.Col_posicao.Width = 70;
			this.Col_End_rq.AutoSizeMode =(System.Windows.Forms.DataGridViewAutoSizeColumnMode)(System.Windows.Forms.AutoSizeMode) (System.Windows.Forms.AutoSizeMode)1;
			dataGridViewCellStyle11.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.Col_End_rq.DefaultCellStyle = dataGridViewCellStyle11;
			this.Col_End_rq.Frozen = true;
			this.Col_End_rq.HeaderText = "End";
			this.Col_End_rq.Name = "Col_End_rq";
			this.Col_End_rq.ReadOnly = true;
			this.Col_End_rq.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_End_rq.SortMode = 0;
			this.Col_End_rq.Width = 40;
			dataGridViewCellStyle12.Format = "N0";
			dataGridViewCellStyle12.NullValue = null;
			this.Col_nome_rq.DefaultCellStyle = dataGridViewCellStyle12;
			this.Col_nome_rq.HeaderText = "Nome ";
			this.Col_nome_rq.MaxInputLength = 3;
			this.Col_nome_rq.Name = "Col_nome_rq";
			this.Col_nome_rq.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_nome_rq.SortMode = 0;
			this.Col_nome_rq.Width = 50;
			dataGridViewCellStyle13.Format = "N0";
			dataGridViewCellStyle13.NullValue = null;
			this.Col_ROrg_rq.DefaultCellStyle = dataGridViewCellStyle13;
			this.Col_ROrg_rq.HeaderText = "Res Origem";
			this.Col_ROrg_rq.MaxInputLength = 2;
			this.Col_ROrg_rq.Name = "Col_ROrg_rq";
			this.Col_ROrg_rq.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_ROrg_rq.SortMode = 0;
			this.Col_ROrg_rq.Width = 50;
			dataGridViewCellStyle14.Format = "N0";
			dataGridViewCellStyle14.NullValue = null;
			this.Col_RDest_rq.DefaultCellStyle = dataGridViewCellStyle14;
			this.Col_RDest_rq.HeaderText = "Res Destino";
			this.Col_RDest_rq.MaxInputLength = 2;
			this.Col_RDest_rq.Name = "Col_RDest_rq";
			this.Col_RDest_rq.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_RDest_rq.SortMode = 0;
			this.Col_RDest_rq.Width = 50;
			dataGridViewCellStyle15.Format = "N0";
			this.Col_mod_rq.DefaultCellStyle = dataGridViewCellStyle15;
			this.Col_mod_rq.DisplayStyle = (System.Windows.Forms.DataGridViewComboBoxDisplayStyle)0;
			this.Col_mod_rq.DisplayStyleForCurrentCellOnly = true;
			this.Col_mod_rq.HeaderText = "Modelo";
			this.Col_mod_rq.Items.AddRange(new object[]
			{
				"MD 201",
				"MD 202",
				"MD 101 - ELO548",
				"MD 101 - BERMAD",
				"MD 101 - KOYO",
				"MD 202 - KRON",
				"MD 202 - KRON - PEXTRON",
				"MD 202 - SoftStarter ABB - 1",
				"--------"
			});
			this.Col_mod_rq.Name = "Col_mod_rq";
			this.Col_mod_rq.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_mod_rq.Width = 160;
			this.Col_pri_rq.HeaderText = "Prioridade";
			this.Col_pri_rq.MaxInputLength = 2;
			this.Col_pri_rq.Name = "Col_pri_rq";
			this.Col_pri_rq.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_pri_rq.SortMode = 0;
			this.Col_pri_rq.Width = 60;
			this.Col_Res1_rq.HeaderText = "Res 1";
			this.Col_Res1_rq.MaxInputLength = 2;
			this.Col_Res1_rq.Name = "Col_Res1_rq";
			this.Col_Res1_rq.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Res1_rq.SortMode = 0;
			this.Col_Res1_rq.Width = 50;
			this.Col_Res2_rq.HeaderText = "Res 2";
			this.Col_Res2_rq.MaxInputLength = 2;
			this.Col_Res2_rq.Name = "Col_Res2_rq";
			this.Col_Res2_rq.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Res2_rq.SortMode = 0;
			this.Col_Res2_rq.Width = 50;
			this.Col_Res3_rq.HeaderText = "Res 3";
			this.Col_Res3_rq.MaxInputLength = 2;
			this.Col_Res3_rq.Name = "Col_Res3_rq";
			this.Col_Res3_rq.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Res3_rq.SortMode = (System.Windows.Forms.DataGridViewColumnSortMode)2;
			this.Col_Res3_rq.Width = 50;
			this.Col_Res4_rq.HeaderText = "Res 4";
			this.Col_Res4_rq.MaxInputLength = 2;
			this.Col_Res4_rq.Name = "Col_Res4_rq";
			this.Col_Res4_rq.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Res4_rq.SortMode = (System.Windows.Forms.DataGridViewColumnSortMode)2;
			this.Col_Res4_rq.Width = 50;
			this.Col_MsgR1_rq.HeaderText = "Nome Res 1";
			this.Col_MsgR1_rq.MaxInputLength = 3;
			this.Col_MsgR1_rq.Name = "Col_MsgR1_rq";
			this.Col_MsgR1_rq.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_MsgR1_rq.SortMode = (System.Windows.Forms.DataGridViewColumnSortMode)2;
			this.Col_MsgR1_rq.Width = 50;
			this.Col_MsgR2_rq.HeaderText = "Nome Res 2";
			this.Col_MsgR2_rq.MaxInputLength = 3;
			this.Col_MsgR2_rq.Name = "Col_MsgR2_rq";
			this.Col_MsgR2_rq.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_MsgR2_rq.SortMode = (System.Windows.Forms.DataGridViewColumnSortMode)2;
			this.Col_MsgR2_rq.Width = 50;
			this.Col_MsgR3_rq.HeaderText = "Nome Res 3";
			this.Col_MsgR3_rq.MaxInputLength = 3;
			this.Col_MsgR3_rq.Name = "Col_MsgR3_rq";
			this.Col_MsgR3_rq.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_MsgR3_rq.SortMode = 0;
			this.Col_MsgR3_rq.Width = 50;
			this.Col_MsgR4_rq.HeaderText = "Nome Res 4";
			this.Col_MsgR4_rq.MaxInputLength = 3;
			this.Col_MsgR4_rq.Name = "Col_MsgR4_rq";
			this.Col_MsgR4_rq.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_MsgR4_rq.SortMode = 0;
			this.Col_MsgR4_rq.Width = 50;
			this.Col_hab.DisplayStyle = (System.Windows.Forms.DataGridViewComboBoxDisplayStyle)0;
			this.Col_hab.DisplayStyleForCurrentCellOnly = true;
			this.Col_hab.HeaderText = "Hab Cmd";
			this.Col_hab.Items.AddRange(new object[]
			{
				"Habilitado",
				"Bloqueado"
			});
			this.Col_hab.Name = "Col_hab";
			this.Col_hab.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_hab.Width = 80;
			this.Col_Esc_1.HeaderText = "Escala 1";
			this.Col_Esc_1.MaxInputLength = 5;
			this.Col_Esc_1.Name = "Col_Esc_1";
			this.Col_Esc_1.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Esc_1.SortMode = 0;
			this.Col_Esc_1.Width = 60;
			this.Col_Esc_2.HeaderText = "Escala 2";
			this.Col_Esc_2.MaxInputLength = 5;
			this.Col_Esc_2.Name = "Col_Esc_2";
			this.Col_Esc_2.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Esc_2.SortMode = 0;
			this.Col_Esc_2.Width = 60;
			this.Col_Esc_3.HeaderText = "Escala 3";
			this.Col_Esc_3.MaxInputLength = 5;
			this.Col_Esc_3.Name = "Col_Esc_3";
			this.Col_Esc_3.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Esc_3.SortMode = 0;
			this.Col_Esc_3.Width = 60;
			this.Col_Esc_4.HeaderText = "Escala 4";
			this.Col_Esc_4.MaxInputLength = 5;
			this.Col_Esc_4.Name = "Col_Esc_4";
			this.Col_Esc_4.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Esc_4.SortMode = 0;
			this.Col_Esc_4.Width = 60;
			this.Col_Esc_5.HeaderText = "Escala 5";
			this.Col_Esc_5.MaxInputLength = 5;
			this.Col_Esc_5.Name = "Col_Esc_5";
			this.Col_Esc_5.SortMode = 0;
			this.Col_Esc_5.Width = 60;
			this.Col_Esc_6.HeaderText = "Escala 6";
			this.Col_Esc_6.MaxInputLength = 5;
			this.Col_Esc_6.Name = "Col_Esc_6";
			this.Col_Esc_6.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Esc_6.SortMode = 0;
			this.Col_Esc_6.Width = 60;
			this.Col_Esc_7.HeaderText = "Escala 7";
			this.Col_Esc_7.MaxInputLength = 5;
			this.Col_Esc_7.Name = "Col_Esc_7";
			this.Col_Esc_7.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Esc_7.SortMode = 0;
			this.Col_Esc_7.Width = 60;
			this.Col_Esc_8.HeaderText = "Escala 8";
			this.Col_Esc_8.MaxInputLength = 5;
			this.Col_Esc_8.Name = "Col_Esc_8";
			this.Col_Esc_8.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Esc_8.SortMode = 0;
			this.Col_Esc_8.Width = 60;
			this.Col_Esc_9.HeaderText = "Escala 9";
			this.Col_Esc_9.MaxInputLength = 5;
			this.Col_Esc_9.Name = "Col_Esc_9";
			this.Col_Esc_9.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Esc_9.SortMode = 0;
			this.Col_Esc_9.Width = 60;
			this.Col_Esc_10.HeaderText = "Escala 10";
			this.Col_Esc_10.MaxInputLength = 5;
			this.Col_Esc_10.Name = "Col_Esc_10";
			this.Col_Esc_10.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Esc_10.SortMode = 0;
			this.Col_Esc_10.Width = 60;
			this.Col_Esc_11.HeaderText = "Escala 11";
			this.Col_Esc_11.MaxInputLength = 5;
			this.Col_Esc_11.Name = "Col_Esc_11";
			this.Col_Esc_11.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Esc_11.SortMode = 0;
			this.Col_Esc_11.Width = 60;
			this.Col_Esc_12.HeaderText = "Escala 12";
			this.Col_Esc_12.MaxInputLength = 5;
			this.Col_Esc_12.Name = "Col_Esc_12";
			this.Col_Esc_12.SortMode = 0;
			this.Col_Esc_12.Width = 60;
			this.Col_Esc_13.HeaderText = "Escala 13";
			this.Col_Esc_13.MaxInputLength = 5;
			this.Col_Esc_13.Name = "Col_Esc_13";
			this.Col_Esc_13.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Esc_13.SortMode = 0;
			this.Col_Esc_13.Width = 60;
			this.Col_Esc_14.HeaderText = "Escala 14";
			this.Col_Esc_14.MaxInputLength = 5;
			this.Col_Esc_14.Name = "Col_Esc_14";
			this.Col_Esc_14.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Esc_14.SortMode = 0;
			this.Col_Esc_14.Width = 60;
			this.Col_Esc_15.HeaderText = "Escala 15";
			this.Col_Esc_15.MaxInputLength = 5;
			this.Col_Esc_15.Name = "Col_Esc_15";
			this.Col_Esc_15.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Esc_15.SortMode = 0;
			this.Col_Esc_15.Width = 60;
			this.Col_Esc_16.HeaderText = "Escala 16";
			this.Col_Esc_16.MaxInputLength = 5;
			this.Col_Esc_16.Name = "Col_Esc_16";
			this.Col_Esc_16.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Col_Esc_16.SortMode = 0;
			this.Col_Esc_16.Width = 60;
			global::System.Drawing.SizeF autoScaleDimensions;
			autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			Size = new System.Drawing.Size(1131, 676);
			this.ClientSize = Size;
			this.Controls.Add(this.Grupo_comandos);
			this.Controls.Add(this.Grupo_conf_equipamentos);
			this.Controls.Add(this.Grupo_lapelas);
			this.Controls.Add(this.Grupo_conf_comunicacao);
			this.Controls.Add(this.MenuStrip1);
			this.FormBorderStyle = FormBorderStyle.None;
this.Location = new global::System.Drawing.Point(160, 2);
			this.MainMenuStrip = this.MenuStrip1;
			this.Name = "Equip_302_conf";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Equip_302_conf";
			this.Grupo_conf_comunicacao.ResumeLayout(false);
			this.Grupo_conf_comunicacao.PerformLayout();
			
			
			
			
			
			
			this.Grupo_lapelas.ResumeLayout(false);
			this.TabControl2.ResumeLayout(false);
			this.Conf_res.ResumeLayout(false);
			
			this.Conf_rq.ResumeLayout(false);
			
			this.Conf_centrais.ResumeLayout(false);
			this.Conf_centrais.PerformLayout();
			
			
			
			this.Grupo_conf_equipamentos.ResumeLayout(false);
			this.Grupo_conf_equipamentos.PerformLayout();
			
			
			
			
			
			
			
			this.Grupo_comandos.ResumeLayout(false);
			this.Grupo_comandos.PerformLayout();
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040017A7 RID: 6055
		private global::System.ComponentModel.IContainer components;
	}
}
