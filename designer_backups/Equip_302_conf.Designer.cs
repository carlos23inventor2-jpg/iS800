namespace iS800
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
			this.Valor_intervalo_polling.BeginInit();
			this.Valor_erro_falha.BeginInit();
			this.Valor_timeout.BeginInit();
			this.Valor_temp_ptt.BeginInit();
			this.Valor_endereco.BeginInit();
			this.Valor_num_tentativas.BeginInit();
			this.Grupo_lapelas.SuspendLayout();
			this.TabControl2.SuspendLayout();
			this.Conf_res.SuspendLayout();
			this.DataGridView1.BeginInit();
			this.Conf_rq.SuspendLayout();
			this.DataGridView_RQ.BeginInit();
			this.Conf_centrais.SuspendLayout();
			this.DataGridView_central_rq.BeginInit();
			this.DataGridView_central_res.BeginInit();
			this.DataGridView_central_geral.BeginInit();
			this.Grupo_conf_equipamentos.SuspendLayout();
			this.Valor_vista_equipamentos.BeginInit();
			this.Valor_end_ini_vista.BeginInit();
			this.Valor_end_ini_rq.BeginInit();
			this.Valor_end_ini_res.BeginInit();
			this.Valor_rq_equipamentos.BeginInit();
			this.Valor_res_equipamentos.BeginInit();
			this.Valor_res_sistema.BeginInit();
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
			global::System.Drawing.Point location;
			location = new global::System.Drawing.Point(12, 12);
			grupo_conf_comunicacao.Location = location;
			this.Grupo_conf_comunicacao.Name = "Grupo_conf_comunicacao";
			global::System.Windows.Forms.Control grupo_conf_comunicacao2 = this.Grupo_conf_comunicacao;
			global::System.Drawing.Size size;
			size = new global::System.Drawing.Size(305, 250);
			grupo_conf_comunicacao2.Size = size;
			this.Grupo_conf_comunicacao.TabIndex = (HorizontalAlignment)1;
			this.Grupo_conf_comunicacao.TabStop = false;
			this.Grupo_conf_comunicacao.Text = "Configuração comunicação";
			global::System.Windows.Forms.Control valor_intervalo_polling = this.Valor_intervalo_polling;
			location = new location(200, 92);
			valor_intervalo_polling.Location = location;
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
			size = new size(93, 20);
			valor_intervalo_polling4.Size = size;
			this.Valor_intervalo_polling.TabIndex = (HorizontalAlignment)25;
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
			location = new location(15, 94);
			label_intervalo_polling.Location = location;
			this.Label_intervalo_polling.Name = "Label_intervalo_polling";
			global::System.Windows.Forms.Control label_intervalo_polling2 = this.Label_intervalo_polling;
			size = new size(182, 13);
			label_intervalo_polling2.Size = size;
			this.Label_intervalo_polling.TabIndex = (HorizontalAlignment)24;
			this.Label_intervalo_polling.Text = "Intervalo entre comunicações (seg.) :";
			global::System.Windows.Forms.Control valor_erro_falha = this.Valor_erro_falha;
			location = new location(200, 185);
			valor_erro_falha.Location = location;
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
			size = new size(93, 20);
			valor_erro_falha4.Size = size;
			this.Valor_erro_falha.TabIndex = (HorizontalAlignment)23;
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
			location = new location(15, 187);
			label_erros_falha.Location = location;
			this.Label_erros_falha.Name = "Label_erros_falha";
			global::System.Windows.Forms.Control label_erros_falha2 = this.Label_erros_falha;
			size = new size(153, 13);
			label_erros_falha2.Size = size;
			this.Label_erros_falha.TabIndex = (HorizontalAlignment)22;
			this.Label_erros_falha.Text = "Número erros para gerar falha :";
			global::System.Windows.Forms.Control valor_timeout = this.Valor_timeout;
			location = new location(200, 123);
			valor_timeout.Location = location;
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
			size = new size(93, 20);
			valor_timeout3.Size = size;
			this.Valor_timeout.TabIndex = (HorizontalAlignment)21;
			this.Valor_timeout.TextAlign = HorizontalAlignment.Right;
			this.Label_timeout.AutoSize = true;
			global::System.Windows.Forms.Control label_timeout = this.Label_timeout;
			location = new location(15, 125);
			label_timeout.Location = location;
			this.Label_timeout.Name = "Label_timeout";
			global::System.Windows.Forms.Control label_timeout2 = this.Label_timeout;
			size = new size(165, 13);
			label_timeout2.Size = size;
			this.Label_timeout.TabIndex = (HorizontalAlignment)20;
			this.Label_timeout.Text = "Tempo espera de resposta (seg.):";
			this.Combo_baudrate.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_baudrate = this.Combo_baudrate;
			location = new location(200, 216);
			combo_baudrate.Location = location;
			this.Combo_baudrate.Name = "Combo_baudrate";
			global::System.Windows.Forms.Control combo_baudrate2 = this.Combo_baudrate;
			size = new size(93, 21);
			combo_baudrate2.Size = size;
			this.Combo_baudrate.TabIndex = (HorizontalAlignment)18;
			this.Label_baudrate.AutoSize = true;
			global::System.Windows.Forms.Control label_baudrate = this.Label_baudrate;
			location = new location(15, 218);
			label_baudrate.Location = location;
			this.Label_baudrate.Name = "Label_baudrate";
			global::System.Windows.Forms.Control label_baudrate2 = this.Label_baudrate;
			size = new size(95, 13);
			label_baudrate2.Size = size;
			this.Label_baudrate.TabIndex = (HorizontalAlignment)19;
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
			location = new location(200, 61);
			valor_temp_ptt2.Location = location;
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
			size = new size(93, 20);
			valor_temp_ptt4.Size = size;
			this.Valor_temp_ptt.TabIndex = (HorizontalAlignment)17;
			this.Valor_temp_ptt.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.Control valor_endereco = this.Valor_endereco;
			location = new location(200, 30);
			valor_endereco.Location = location;
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
			size = new size(93, 20);
			valor_endereco3.Size = size;
			this.Valor_endereco.TabIndex = (HorizontalAlignment)16;
			this.Valor_endereco.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.Control valor_num_tentativas = this.Valor_num_tentativas;
			location = new location(200, 154);
			valor_num_tentativas.Location = location;
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
			size = new size(93, 20);
			valor_num_tentativas4.Size = size;
			this.Valor_num_tentativas.TabIndex = (HorizontalAlignment)15;
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
			location = new location(15, 63);
			label_tempo_ptt.Location = location;
			this.Label_tempo_ptt.Name = "Label_tempo_ptt";
			global::System.Windows.Forms.Control label_tempo_ptt2 = this.Label_tempo_ptt;
			size = new size(123, 13);
			label_tempo_ptt2.Size = size;
			this.Label_tempo_ptt.TabIndex = (HorizontalAlignment)14;
			this.Label_tempo_ptt.Text = "Tempo PTT ligado (ms) :";
			this.Label_endereco.AutoSize = true;
			global::System.Windows.Forms.Control label_endereco = this.Label_endereco;
			location = new location(15, 32);
			label_endereco.Location = location;
			this.Label_endereco.Name = "Label_endereco";
			global::System.Windows.Forms.Control label_endereco2 = this.Label_endereco;
			size = new size(109, 13);
			label_endereco2.Size = size;
			this.Label_endereco.TabIndex = (HorizontalAlignment)13;
			this.Label_endereco.Text = "Endereço da central :";
			this.Label_retry.AutoSize = true;
			global::System.Windows.Forms.Control label_retry = this.Label_retry;
			location = new location(15, 156);
			label_retry.Location = location;
			this.Label_retry.Name = "Label_retry";
			global::System.Windows.Forms.Control label_retry2 = this.Label_retry;
			size = new size(99, 13);
			label_retry2.Size = size;
			this.Label_retry.TabIndex = (HorizontalAlignment)12;
			this.Label_retry.Text = "Número tentativas :";
			this.Grupo_lapelas.Controls.Add(this.TabControl2);
			global::System.Windows.Forms.Control grupo_lapelas = this.Grupo_lapelas;
			location = new location(336, 12);
			grupo_lapelas.Location = location;
			this.Grupo_lapelas.Name = "Grupo_lapelas";
			global::System.Windows.Forms.Control grupo_lapelas2 = this.Grupo_lapelas;
			size = new size(801, 636);
			grupo_lapelas2.Size = size;
			this.Grupo_lapelas.TabIndex = (HorizontalAlignment)3;
			this.Grupo_lapelas.TabStop = false;
			this.Grupo_lapelas.Text = "Configuração de equipamentos de reservatórios";
			this.TabControl2.Appearance = (HorizontalAlignment)1;
			this.TabControl2.Controls.Add(this.Conf_res);
			this.TabControl2.Controls.Add(this.Conf_rq);
			this.TabControl2.Controls.Add(this.Conf_centrais);
			global::System.Windows.Forms.Control tabControl = this.TabControl2;
			location = new location(23, 30);
			tabControl.Location = location;
			this.TabControl2.Multiline = true;
			this.TabControl2.Name = "TabControl2";
			this.TabControl2.RightToLeftLayout = true;
			this.TabControl2.SelectedIndex = (HorizontalAlignment)0;
			global::System.Windows.Forms.Control tabControl2 = this.TabControl2;
			size = new size(738, 589);
			tabControl2.Size = size;
			this.TabControl2.SizeMode =(System.Windows.Forms.PictureBoxSizeMode)2;
			this.TabControl2.TabIndex = (HorizontalAlignment)4;
			this.Conf_res.Controls.Add(this.DataGridView1);
			global::System.Windows.Forms.TabPage conf_res = this.Conf_res;
			location = new location(4, 25);
			conf_res.Location = location;
			this.Conf_res.Name = "Conf_res";
			global::System.Windows.Forms.Control conf_res2 = this.Conf_res;
			global::System.Windows.Forms.Padding padding;
			padding = new global::System.Windows.Forms.Padding(3);
			conf_res2.Padding = padding;
			global::System.Windows.Forms.Control conf_res3 = this.Conf_res;
			size = new size(730, 560);
			conf_res3.Size = size;
			this.Conf_res.TabIndex = (HorizontalAlignment)0;
			this.Conf_res.Text = "Reservatórios";
			this.Conf_res.UseVisualStyleBackColor = true;
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.BackgroundColor = global::System.Drawing.SystemColors.Control;
			this.DataGridView1.BorderStyle = (HorizontalAlignment)0;
			this.DataGridView1.CellBorderStyle = (HorizontalAlignment)3;
			this.DataGridView1.ColumnHeadersHeightSizeMode = (HorizontalAlignment)2;
			this.DataGridView1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Col_end,
				this.Col_nome,
				this.Col_altura,
				this.Col_pri,
				this.Col_posicao
			});
			dataGridViewCellStyle.Alignment =(System.Windows.Forms.HorizontalAlignment)64;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, 0, (FontStyle)3, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle;
			global::System.Windows.Forms.Control dataGridView = this.DataGridView1;
			location = new location(3, 0);
			dataGridView.Location = location;
			this.DataGridView1.Name = "DataGridView1";
			dataGridViewCellStyle2.Alignment =(System.Windows.Forms.HorizontalAlignment)32;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, 0, (FontStyle)3, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			global::System.Windows.Forms.Control dataGridView2 = this.DataGridView1;
			size = new size(375, 560);
			dataGridView2.Size = size;
			this.DataGridView1.TabIndex = (HorizontalAlignment)3;
			this.Conf_rq.Controls.Add(this.DataGridView_RQ);
			global::System.Windows.Forms.TabPage conf_rq = this.Conf_rq;
			location = new location(4, 25);
			conf_rq.Location = location;
			this.Conf_rq.Name = "Conf_rq";
			global::System.Windows.Forms.Control conf_rq2 = this.Conf_rq;
			padding = new padding(3);
			conf_rq2.Padding = padding;
			global::System.Windows.Forms.Control conf_rq3 = this.Conf_rq;
			size = new size(730, 560);
			conf_rq3.Size = size;
			this.Conf_rq.TabIndex = (HorizontalAlignment)1;
			this.Conf_rq.Text = "Recalques";
			this.Conf_rq.UseVisualStyleBackColor = true;
			this.DataGridView_RQ.AllowUserToAddRows = false;
			this.DataGridView_RQ.BackgroundColor = global::System.Drawing.SystemColors.Control;
			this.DataGridView_RQ.BorderStyle = (HorizontalAlignment)0;
			this.DataGridView_RQ.CellBorderStyle = (HorizontalAlignment)3;
			this.DataGridView_RQ.ColumnHeadersHeightSizeMode = (HorizontalAlignment)2;
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
			dataGridViewCellStyle3.Alignment =(System.Windows.Forms.HorizontalAlignment)64;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, 0, (FontStyle)3, 0);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView_RQ.DefaultCellStyle = dataGridViewCellStyle3;
			global::System.Windows.Forms.Control dataGridView_RQ = this.DataGridView_RQ;
			location = new location(3, 3);
			dataGridView_RQ.Location = location;
			this.DataGridView_RQ.Name = "DataGridView_RQ";
			dataGridViewCellStyle4.Alignment =(System.Windows.Forms.HorizontalAlignment)32;
			dataGridViewCellStyle4.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, 0, (FontStyle)3, 0);
			dataGridViewCellStyle4.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView_RQ.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			global::System.Windows.Forms.Control dataGridView_RQ2 = this.DataGridView_RQ;
			size = new size(721, 546);
			dataGridView_RQ2.Size = size;
			this.DataGridView_RQ.TabIndex = (HorizontalAlignment)4;
			this.Conf_centrais.Controls.Add(this.DataGridView_central_rq);
			this.Conf_centrais.Controls.Add(this.DataGridView_central_res);
			this.Conf_centrais.Controls.Add(this.Label_rq);
			this.Conf_centrais.Controls.Add(this.Label_res);
			this.Conf_centrais.Controls.Add(this.DataGridView_central_geral);
			global::System.Windows.Forms.TabPage conf_centrais = this.Conf_centrais;
			location = new location(4, 25);
			conf_centrais.Location = location;
			this.Conf_centrais.Name = "Conf_centrais";
			global::System.Windows.Forms.Control conf_centrais2 = this.Conf_centrais;
			size = new size(730, 560);
			conf_centrais2.Size = size;
			this.Conf_centrais.TabIndex = (HorizontalAlignment)2;
			this.Conf_centrais.Text = "Centrais";
			this.Conf_centrais.UseVisualStyleBackColor = true;
			this.DataGridView_central_rq.AllowUserToAddRows = false;
			this.DataGridView_central_rq.BackgroundColor = global::System.Drawing.SystemColors.Control;
			this.DataGridView_central_rq.BorderStyle = (HorizontalAlignment)0;
			this.DataGridView_central_rq.CellBorderStyle = (HorizontalAlignment)3;
			this.DataGridView_central_rq.ColumnHeadersHeightSizeMode = (HorizontalAlignment)2;
			this.DataGridView_central_rq.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Col_ct_rq_end
			});
			global::System.Windows.Forms.Control dataGridView_central_rq = this.DataGridView_central_rq;
			location = new location(0, 374);
			dataGridView_central_rq.Location = location;
			this.DataGridView_central_rq.Name = "DataGridView_central_rq";
			global::System.Windows.Forms.Control dataGridView_central_rq2 = this.DataGridView_central_rq;
			size = new size(728, 183);
			dataGridView_central_rq2.Size = size;
			this.DataGridView_central_rq.TabIndex = (HorizontalAlignment)20;
			dataGridViewCellStyle5.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.Col_ct_rq_end.DefaultCellStyle = dataGridViewCellStyle5;
			this.Col_ct_rq_end.Frozen = true;
			this.Col_ct_rq_end.HeaderText = "End";
			this.Col_ct_rq_end.MaxInputLength = (HorizontalAlignment)200;
			this.Col_ct_rq_end.Name = "Col_ct_rq_end";
			this.Col_ct_rq_end.ReadOnly = true;
			this.Col_ct_rq_end.SortMode = (HorizontalAlignment)0;
			this.Col_ct_rq_end.Width = (HorizontalAlignment)60;
			this.DataGridView_central_res.AllowUserToAddRows = false;
			this.DataGridView_central_res.BackgroundColor = global::System.Drawing.SystemColors.Control;
			this.DataGridView_central_res.BorderStyle = (HorizontalAlignment)0;
			this.DataGridView_central_res.CellBorderStyle = (HorizontalAlignment)3;
			this.DataGridView_central_res.ColumnHeadersHeightSizeMode = (HorizontalAlignment)2;
			this.DataGridView_central_res.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Col_ct_res_end
			});
			global::System.Windows.Forms.Control dataGridView_central_res = this.DataGridView_central_res;
			location = new location(2, 186);
			dataGridView_central_res.Location = location;
			this.DataGridView_central_res.Name = "DataGridView_central_res";
			global::System.Windows.Forms.Control dataGridView_central_res2 = this.DataGridView_central_res;
			size = new size(732, 154);
			dataGridView_central_res2.Size = size;
			this.DataGridView_central_res.TabIndex = (HorizontalAlignment)19;
			dataGridViewCellStyle6.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.Col_ct_res_end.DefaultCellStyle = dataGridViewCellStyle6;
			this.Col_ct_res_end.Frozen = true;
			this.Col_ct_res_end.HeaderText = "End";
			this.Col_ct_res_end.MaxInputLength = (HorizontalAlignment)200;
			this.Col_ct_res_end.Name = "Col_ct_res_end";
			this.Col_ct_res_end.ReadOnly = true;
			this.Col_ct_res_end.SortMode = (HorizontalAlignment)0;
			this.Col_ct_res_end.Width = (HorizontalAlignment)60;
			this.Label_rq.AutoSize = true;
			global::System.Windows.Forms.Control label_rq = this.Label_rq;
			location = new location(0, 358);
			label_rq.Location = location;
			this.Label_rq.Name = "Label_rq";
			global::System.Windows.Forms.Control label_rq2 = this.Label_rq;
			size = new size(64, 13);
			label_rq2.Size = size;
			this.Label_rq.TabIndex = (HorizontalAlignment)17;
			this.Label_rq.Text = "Recalques :";
			this.Label_res.AutoSize = true;
			global::System.Windows.Forms.Control label_res = this.Label_res;
			location = new location(-3, 170);
			label_res.Location = location;
			this.Label_res.Name = "Label_res";
			global::System.Windows.Forms.Control label_res2 = this.Label_res;
			size = new size(78, 13);
			label_res2.Size = size;
			this.Label_res.TabIndex = (HorizontalAlignment)17;
			this.Label_res.Text = "Reservatórios :";
			this.DataGridView_central_geral.AllowUserToAddRows = false;
			this.DataGridView_central_geral.BackgroundColor = global::System.Drawing.SystemColors.Control;
			this.DataGridView_central_geral.BorderStyle = (HorizontalAlignment)0;
			this.DataGridView_central_geral.CellBorderStyle = (HorizontalAlignment)3;
			this.DataGridView_central_geral.ColumnHeadersHeightSizeMode = (HorizontalAlignment)2;
			this.DataGridView_central_geral.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Col_vista_end,
				this.Col_vista_res,
				this.Col_vista_rq,
				this.Col_vista_pri
			});
			global::System.Windows.Forms.Control dataGridView_central_geral = this.DataGridView_central_geral;
			location = new location(3, 6);
			dataGridView_central_geral.Location = location;
			this.DataGridView_central_geral.Name = "DataGridView_central_geral";
			global::System.Windows.Forms.Control dataGridView_central_geral2 = this.DataGridView_central_geral;
			size = new size(367, 177);
			dataGridView_central_geral2.Size = size;
			this.DataGridView_central_geral.TabIndex = (HorizontalAlignment)0;
			this.Col_vista_end.HeaderText = "Endereço";
			this.Col_vista_end.MaxInputLength = (HorizontalAlignment)2;
			this.Col_vista_end.Name = "Col_vista_end";
			this.Col_vista_end.ReadOnly = true;
			this.Col_vista_end.SortMode = (HorizontalAlignment)0;
			this.Col_vista_end.Width = (HorizontalAlignment)60;
			this.Col_vista_res.HeaderText = "N° Reserv.";
			this.Col_vista_res.MaxInputLength = (HorizontalAlignment)2;
			this.Col_vista_res.Name = "Col_vista_res";
			this.Col_vista_res.SortMode = (HorizontalAlignment)0;
			this.Col_vista_res.Width = (HorizontalAlignment)95;
			this.Col_vista_rq.HeaderText = "N° Recalques";
			this.Col_vista_rq.MaxInputLength = (HorizontalAlignment)2;
			this.Col_vista_rq.Name = "Col_vista_rq";
			this.Col_vista_rq.SortMode = (HorizontalAlignment)0;
			this.Col_vista_rq.Width = (HorizontalAlignment)95;
			this.Col_vista_pri.HeaderText = "Prioridade";
			this.Col_vista_pri.MaxInputLength = (HorizontalAlignment)2;
			this.Col_vista_pri.Name = "Col_vista_pri";
			this.Col_vista_pri.SortMode = (HorizontalAlignment)0;
			this.Col_vista_pri.Width = (HorizontalAlignment)70;
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
			location = new location(12, 268);
			grupo_conf_equipamentos.Location = location;
			this.Grupo_conf_equipamentos.Name = "Grupo_conf_equipamentos";
			global::System.Windows.Forms.Control grupo_conf_equipamentos2 = this.Grupo_conf_equipamentos;
			size = new size(305, 252);
			grupo_conf_equipamentos2.Size = size;
			this.Grupo_conf_equipamentos.TabIndex = (HorizontalAlignment)4;
			this.Grupo_conf_equipamentos.TabStop = false;
			this.Grupo_conf_equipamentos.Text = "Configuracao de equipamentos";
			global::System.Windows.Forms.Control valor_vista_equipamentos = this.Valor_vista_equipamentos;
			location = new location(200, 125);
			valor_vista_equipamentos.Location = location;
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
			size = new size(93, 20);
			valor_vista_equipamentos3.Size = size;
			this.Valor_vista_equipamentos.TabIndex = (HorizontalAlignment)29;
			this.Valor_vista_equipamentos.TextAlign = HorizontalAlignment.Right;
			this.Label_vista_equipamentos.AutoSize = true;
			global::System.Windows.Forms.Control label_vista_equipamentos = this.Label_vista_equipamentos;
			location = new location(11, 127);
			label_vista_equipamentos.Location = location;
			this.Label_vista_equipamentos.Name = "Label_vista_equipamentos";
			global::System.Windows.Forms.Control label_vista_equipamentos2 = this.Label_vista_equipamentos;
			size = new size(137, 13);
			label_vista_equipamentos2.Size = size;
			this.Label_vista_equipamentos.TabIndex = (HorizontalAlignment)28;
			this.Label_vista_equipamentos.Text = "Número de equip. de vista :";
			global::System.Windows.Forms.Control valor_end_ini_vista = this.Valor_end_ini_vista;
			location = new location(200, 215);
			valor_end_ini_vista.Location = location;
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
			size = new size(93, 20);
			valor_end_ini_vista4.Size = size;
			this.Valor_end_ini_vista.TabIndex = (HorizontalAlignment)27;
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
			location = new location(14, 217);
			label_end_ini_vista.Location = location;
			this.Label_end_ini_vista.Name = "Label_end_ini_vista";
			global::System.Windows.Forms.Control label_end_ini_vista2 = this.Label_end_ini_vista;
			size = new size(130, 13);
			label_end_ini_vista2.Size = size;
			this.Label_end_ini_vista.TabIndex = (HorizontalAlignment)26;
			this.Label_end_ini_vista.Text = "End. com. inicial de vista :";
			global::System.Windows.Forms.Control valor_end_ini_rq = this.Valor_end_ini_rq;
			location = new location(200, 185);
			valor_end_ini_rq.Location = location;
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
			size = new size(93, 20);
			valor_end_ini_rq4.Size = size;
			this.Valor_end_ini_rq.TabIndex = (HorizontalAlignment)25;
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
			location = new location(11, 187);
			label_end_ini_rq.Location = location;
			this.Label_end_ini_rq.Name = "Label_end_ini_rq";
			global::System.Windows.Forms.Control label_end_ini_rq2 = this.Label_end_ini_rq;
			size = new size(149, 13);
			label_end_ini_rq2.Size = size;
			this.Label_end_ini_rq.TabIndex = (HorizontalAlignment)24;
			this.Label_end_ini_rq.Text = "End. com. inicial de recalque :";
			global::System.Windows.Forms.Control valor_end_ini_res = this.Valor_end_ini_res;
			location = new location(200, 155);
			valor_end_ini_res.Location = location;
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
			size = new size(93, 20);
			valor_end_ini_res4.Size = size;
			this.Valor_end_ini_res.TabIndex = (HorizontalAlignment)23;
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
			location = new location(11, 157);
			label_end_ini_res.Location = location;
			this.Label_end_ini_res.Name = "Label_end_ini_res";
			global::System.Windows.Forms.Control label_end_ini_res2 = this.Label_end_ini_res;
			size = new size(163, 13);
			label_end_ini_res2.Size = size;
			this.Label_end_ini_res.TabIndex = (HorizontalAlignment)22;
			this.Label_end_ini_res.Text = "End. com. inicial de reservatório :";
			global::System.Windows.Forms.Control valor_rq_equipamentos = this.Valor_rq_equipamentos;
			location = new location(200, 95);
			valor_rq_equipamentos.Location = location;
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
			size = new size(93, 20);
			valor_rq_equipamentos3.Size = size;
			this.Valor_rq_equipamentos.TabIndex = (HorizontalAlignment)21;
			this.Valor_rq_equipamentos.TextAlign = HorizontalAlignment.Right;
			this.Label_rq_equipamentos.AutoSize = true;
			global::System.Windows.Forms.Control label_rq_equipamentos = this.Label_rq_equipamentos;
			location = new location(11, 97);
			label_rq_equipamentos.Location = location;
			this.Label_rq_equipamentos.Name = "Label_rq_equipamentos";
			global::System.Windows.Forms.Control label_rq_equipamentos2 = this.Label_rq_equipamentos;
			size = new size(156, 13);
			label_rq_equipamentos2.Size = size;
			this.Label_rq_equipamentos.TabIndex = (HorizontalAlignment)20;
			this.Label_rq_equipamentos.Text = "Número de equip. de recalque :";
			global::System.Windows.Forms.Control valor_res_equipamentos = this.Valor_res_equipamentos;
			location = new location(200, 65);
			valor_res_equipamentos.Location = location;
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
			size = new size(93, 20);
			valor_res_equipamentos3.Size = size;
			this.Valor_res_equipamentos.TabIndex = (HorizontalAlignment)19;
			this.Valor_res_equipamentos.TextAlign = HorizontalAlignment.Right;
			this.Label_res_equipamentos.AutoSize = true;
			global::System.Windows.Forms.Control label_res_equipamentos = this.Label_res_equipamentos;
			location = new location(11, 67);
			label_res_equipamentos.Location = location;
			this.Label_res_equipamentos.Name = "Label_res_equipamentos";
			global::System.Windows.Forms.Control label_res_equipamentos2 = this.Label_res_equipamentos;
			size = new size(170, 13);
			label_res_equipamentos2.Size = size;
			this.Label_res_equipamentos.TabIndex = (HorizontalAlignment)18;
			this.Label_res_equipamentos.Text = "Número de equip. de reservatório :";
			global::System.Windows.Forms.Control valor_res_sistema = this.Valor_res_sistema;
			location = new location(200, 35);
			valor_res_sistema.Location = location;
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
			size = new size(93, 20);
			valor_res_sistema3.Size = size;
			this.Valor_res_sistema.TabIndex = (HorizontalAlignment)17;
			this.Valor_res_sistema.TextAlign = HorizontalAlignment.Right;
			this.Label_res_sistema.AutoSize = true;
			global::System.Windows.Forms.Control label_res_sistema = this.Label_res_sistema;
			location = new location(11, 37);
			label_res_sistema.Location = location;
			this.Label_res_sistema.Name = "Label_res_sistema";
			global::System.Windows.Forms.Control label_res_sistema2 = this.Label_res_sistema;
			size = new size(166, 13);
			label_res_sistema2.Size = size;
			this.Label_res_sistema.TabIndex = (HorizontalAlignment)16;
			this.Label_res_sistema.Text = "Número reservatórios do sistema :";
			this.Grupo_comandos.Controls.Add(this.Esc_conf_md_302);
			this.Grupo_comandos.Controls.Add(this.Box_Msg);
			this.Grupo_comandos.Controls.Add(this.Ler_conf_md_302);
			global::System.Windows.Forms.Control grupo_comandos = this.Grupo_comandos;
			location = new location(12, 543);
			grupo_comandos.Location = location;
			this.Grupo_comandos.Name = "Grupo_comandos";
			global::System.Windows.Forms.Control grupo_comandos2 = this.Grupo_comandos;
			size = new size(305, 105);
			grupo_comandos2.Size = size;
			this.Grupo_comandos.TabIndex = (HorizontalAlignment)5;
			this.Grupo_comandos.TabStop = false;
			this.Grupo_comandos.Text = "Comandos  e status";
			global::System.Windows.Forms.Control esc_conf_md_ = this.Esc_conf_md_302;
			location = new location(170, 60);
			esc_conf_md_.Location = location;
			this.Esc_conf_md_302.Name = "Esc_conf_md_302";
			global::System.Windows.Forms.Control esc_conf_md_2 = this.Esc_conf_md_302;
			size = new size(109, 28);
			esc_conf_md_2.Size = size;
			this.Esc_conf_md_302.TabIndex = (HorizontalAlignment)4;
			this.Esc_conf_md_302.Text = "Salvar config.";
			this.Esc_conf_md_302.UseVisualStyleBackColor = true;
			this.Box_Msg.BackColor = global::System.Drawing.Color.Beige;
			global::System.Windows.Forms.Control box_Msg = this.Box_Msg;
			location = new location(17, 28);
			box_Msg.Location = location;
			this.Box_Msg.Name = "Box_Msg";
			this.Box_Msg.ReadOnly = true;
			global::System.Windows.Forms.Control box_Msg2 = this.Box_Msg;
			size = new size(262, 20);
			box_Msg2.Size = size;
			this.Box_Msg.TabIndex = (HorizontalAlignment)5;
			this.Box_Msg.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.Control ler_conf_md_ = this.Ler_conf_md_302;
			location = new location(17, 60);
			ler_conf_md_.Location = location;
			this.Ler_conf_md_302.Name = "Ler_conf_md_302";
			global::System.Windows.Forms.Control ler_conf_md_2 = this.Ler_conf_md_302;
			size = new size(109, 28);
			ler_conf_md_2.Size = size;
			this.Ler_conf_md_302.TabIndex = (HorizontalAlignment)3;
			this.Ler_conf_md_302.Text = "Ler configuração";
			this.Ler_conf_md_302.UseVisualStyleBackColor = true;
			this.MenuStrip1.Dock =(System.Windows.Forms.DockStyle)2;
			this.MenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ArquivoToolStripMenuItem
			});
			global::System.Windows.Forms.Control menuStrip = this.MenuStrip1;
			location = new location(0, 652);
			menuStrip.Location = location;
			this.MenuStrip1.Name = "MenuStrip1";
			global::System.Windows.Forms.Control menuStrip2 = this.MenuStrip1;
			size = new size(1131, 24);
			menuStrip2.Size = size;
			this.MenuStrip1.TabIndex = (HorizontalAlignment)6;
			this.MenuStrip1.Text = "MenuStrip1";
			this.ArquivoToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.NovoToolStripMenuItem,
				this.AbrirToolStripMenuItem,
				this.SalvarToolStripMenuItem
			});
			this.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem arquivoToolStripMenuItem = this.ArquivoToolStripMenuItem;
			size = new size(61, 20);
			arquivoToolStripMenuItem.Size = size;
			this.ArquivoToolStripMenuItem.Text = "Arquivo";
			this.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem novoToolStripMenuItem = this.NovoToolStripMenuItem;
			size = new size(105, 22);
			novoToolStripMenuItem.Size = size;
			this.NovoToolStripMenuItem.Text = "Novo";
			this.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem abrirToolStripMenuItem = this.AbrirToolStripMenuItem;
			size = new size(105, 22);
			abrirToolStripMenuItem.Size = size;
			this.AbrirToolStripMenuItem.Text = "Abrir";
			this.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem salvarToolStripMenuItem = this.SalvarToolStripMenuItem;
			size = new size(105, 22);
			salvarToolStripMenuItem.Size = size;
			this.SalvarToolStripMenuItem.Text = "Salvar";
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			this.Col_end.AutoSizeMode =(System.Windows.Forms.DataGridViewAutoSizeColumnMode)(System.Windows.Forms.AutoSizeMode)1;
			this.Col_end.HeaderText = "Endereço";
			this.Col_end.Name = "Col_end";
			this.Col_end.ReadOnly = true;
			this.Col_end.Resizable = (HorizontalAlignment)2;
			this.Col_end.SortMode = (HorizontalAlignment)0;
			this.Col_end.Width = (HorizontalAlignment)55;
			dataGridViewCellStyle7.Format = "N0";
			dataGridViewCellStyle7.NullValue = null;
			this.Col_nome.DefaultCellStyle = dataGridViewCellStyle7;
			this.Col_nome.HeaderText = "Nome ";
			this.Col_nome.MaxInputLength = (HorizontalAlignment)3;
			this.Col_nome.Name = "Col_nome";
			this.Col_nome.Resizable = (HorizontalAlignment)2;
			this.Col_nome.SortMode = (HorizontalAlignment)0;
			this.Col_nome.Width = (HorizontalAlignment)64;
			dataGridViewCellStyle8.Format = "N0";
			dataGridViewCellStyle8.NullValue = null;
			this.Col_altura.DefaultCellStyle = dataGridViewCellStyle8;
			this.Col_altura.HeaderText = "Altura (cm)";
			this.Col_altura.MaxInputLength = (HorizontalAlignment)5;
			this.Col_altura.Name = "Col_altura";
			this.Col_altura.Resizable = (HorizontalAlignment)2;
			this.Col_altura.SortMode = (HorizontalAlignment)0;
			this.Col_altura.Width = (HorizontalAlignment)64;
			dataGridViewCellStyle9.Format = "N0";
			dataGridViewCellStyle9.NullValue = null;
			this.Col_pri.DefaultCellStyle = dataGridViewCellStyle9;
			this.Col_pri.HeaderText = "Prioridade (0-13)";
			this.Col_pri.MaxInputLength = (HorizontalAlignment)2;
			this.Col_pri.Name = "Col_pri";
			this.Col_pri.Resizable = (HorizontalAlignment)2;
			this.Col_pri.SortMode = (HorizontalAlignment)0;
			this.Col_pri.Width = (HorizontalAlignment)64;
			dataGridViewCellStyle10.Format = "N0";
			dataGridViewCellStyle10.NullValue = null;
			this.Col_posicao.DefaultCellStyle = dataGridViewCellStyle10;
			this.Col_posicao.HeaderText = "Posição relativa(1-40)";
			this.Col_posicao.MaxInputLength = (HorizontalAlignment)2;
			this.Col_posicao.Name = "Col_posicao";
			this.Col_posicao.Resizable = (HorizontalAlignment)2;
			this.Col_posicao.SortMode = (HorizontalAlignment)0;
			this.Col_posicao.Width = (HorizontalAlignment)70;
			this.Col_End_rq.AutoSizeMode =(System.Windows.Forms.DataGridViewAutoSizeColumnMode)(System.Windows.Forms.AutoSizeMode)1;
			dataGridViewCellStyle11.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.Col_End_rq.DefaultCellStyle = dataGridViewCellStyle11;
			this.Col_End_rq.Frozen = true;
			this.Col_End_rq.HeaderText = "End";
			this.Col_End_rq.Name = "Col_End_rq";
			this.Col_End_rq.ReadOnly = true;
			this.Col_End_rq.Resizable = (HorizontalAlignment)2;
			this.Col_End_rq.SortMode = (HorizontalAlignment)0;
			this.Col_End_rq.Width = (HorizontalAlignment)40;
			dataGridViewCellStyle12.Format = "N0";
			dataGridViewCellStyle12.NullValue = null;
			this.Col_nome_rq.DefaultCellStyle = dataGridViewCellStyle12;
			this.Col_nome_rq.HeaderText = "Nome ";
			this.Col_nome_rq.MaxInputLength = (HorizontalAlignment)3;
			this.Col_nome_rq.Name = "Col_nome_rq";
			this.Col_nome_rq.Resizable = (HorizontalAlignment)2;
			this.Col_nome_rq.SortMode = (HorizontalAlignment)0;
			this.Col_nome_rq.Width = (HorizontalAlignment)50;
			dataGridViewCellStyle13.Format = "N0";
			dataGridViewCellStyle13.NullValue = null;
			this.Col_ROrg_rq.DefaultCellStyle = dataGridViewCellStyle13;
			this.Col_ROrg_rq.HeaderText = "Res Origem";
			this.Col_ROrg_rq.MaxInputLength = (HorizontalAlignment)2;
			this.Col_ROrg_rq.Name = "Col_ROrg_rq";
			this.Col_ROrg_rq.Resizable = (HorizontalAlignment)2;
			this.Col_ROrg_rq.SortMode = (HorizontalAlignment)0;
			this.Col_ROrg_rq.Width = (HorizontalAlignment)50;
			dataGridViewCellStyle14.Format = "N0";
			dataGridViewCellStyle14.NullValue = null;
			this.Col_RDest_rq.DefaultCellStyle = dataGridViewCellStyle14;
			this.Col_RDest_rq.HeaderText = "Res Destino";
			this.Col_RDest_rq.MaxInputLength = (HorizontalAlignment)2;
			this.Col_RDest_rq.Name = "Col_RDest_rq";
			this.Col_RDest_rq.Resizable = (HorizontalAlignment)2;
			this.Col_RDest_rq.SortMode = (HorizontalAlignment)0;
			this.Col_RDest_rq.Width = (HorizontalAlignment)50;
			dataGridViewCellStyle15.Format = "N0";
			this.Col_mod_rq.DefaultCellStyle = dataGridViewCellStyle15;
			this.Col_mod_rq.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)0;
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
			this.Col_mod_rq.Resizable = (HorizontalAlignment)2;
			this.Col_mod_rq.Width = (HorizontalAlignment)160;
			this.Col_pri_rq.HeaderText = "Prioridade";
			this.Col_pri_rq.MaxInputLength = (HorizontalAlignment)2;
			this.Col_pri_rq.Name = "Col_pri_rq";
			this.Col_pri_rq.Resizable = (HorizontalAlignment)2;
			this.Col_pri_rq.SortMode = (HorizontalAlignment)0;
			this.Col_pri_rq.Width = (HorizontalAlignment)60;
			this.Col_Res1_rq.HeaderText = "Res 1";
			this.Col_Res1_rq.MaxInputLength = (HorizontalAlignment)2;
			this.Col_Res1_rq.Name = "Col_Res1_rq";
			this.Col_Res1_rq.Resizable = (HorizontalAlignment)2;
			this.Col_Res1_rq.SortMode = (HorizontalAlignment)0;
			this.Col_Res1_rq.Width = (HorizontalAlignment)50;
			this.Col_Res2_rq.HeaderText = "Res 2";
			this.Col_Res2_rq.MaxInputLength = (HorizontalAlignment)2;
			this.Col_Res2_rq.Name = "Col_Res2_rq";
			this.Col_Res2_rq.Resizable = (HorizontalAlignment)2;
			this.Col_Res2_rq.SortMode = (HorizontalAlignment)0;
			this.Col_Res2_rq.Width = (HorizontalAlignment)50;
			this.Col_Res3_rq.HeaderText = "Res 3";
			this.Col_Res3_rq.MaxInputLength = (HorizontalAlignment)2;
			this.Col_Res3_rq.Name = "Col_Res3_rq";
			this.Col_Res3_rq.Resizable = (HorizontalAlignment)2;
			this.Col_Res3_rq.SortMode = (HorizontalAlignment)2;
			this.Col_Res3_rq.Width = (HorizontalAlignment)50;
			this.Col_Res4_rq.HeaderText = "Res 4";
			this.Col_Res4_rq.MaxInputLength = (HorizontalAlignment)2;
			this.Col_Res4_rq.Name = "Col_Res4_rq";
			this.Col_Res4_rq.Resizable = (HorizontalAlignment)2;
			this.Col_Res4_rq.SortMode = (HorizontalAlignment)2;
			this.Col_Res4_rq.Width = (HorizontalAlignment)50;
			this.Col_MsgR1_rq.HeaderText = "Nome Res 1";
			this.Col_MsgR1_rq.MaxInputLength = (HorizontalAlignment)3;
			this.Col_MsgR1_rq.Name = "Col_MsgR1_rq";
			this.Col_MsgR1_rq.Resizable = (HorizontalAlignment)2;
			this.Col_MsgR1_rq.SortMode = (HorizontalAlignment)2;
			this.Col_MsgR1_rq.Width = (HorizontalAlignment)50;
			this.Col_MsgR2_rq.HeaderText = "Nome Res 2";
			this.Col_MsgR2_rq.MaxInputLength = (HorizontalAlignment)3;
			this.Col_MsgR2_rq.Name = "Col_MsgR2_rq";
			this.Col_MsgR2_rq.Resizable = (HorizontalAlignment)2;
			this.Col_MsgR2_rq.SortMode = (HorizontalAlignment)2;
			this.Col_MsgR2_rq.Width = (HorizontalAlignment)50;
			this.Col_MsgR3_rq.HeaderText = "Nome Res 3";
			this.Col_MsgR3_rq.MaxInputLength = (HorizontalAlignment)3;
			this.Col_MsgR3_rq.Name = "Col_MsgR3_rq";
			this.Col_MsgR3_rq.Resizable = (HorizontalAlignment)2;
			this.Col_MsgR3_rq.SortMode = (HorizontalAlignment)0;
			this.Col_MsgR3_rq.Width = (HorizontalAlignment)50;
			this.Col_MsgR4_rq.HeaderText = "Nome Res 4";
			this.Col_MsgR4_rq.MaxInputLength = (HorizontalAlignment)3;
			this.Col_MsgR4_rq.Name = "Col_MsgR4_rq";
			this.Col_MsgR4_rq.Resizable = (HorizontalAlignment)2;
			this.Col_MsgR4_rq.SortMode = (HorizontalAlignment)0;
			this.Col_MsgR4_rq.Width = (HorizontalAlignment)50;
			this.Col_hab.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)0;
			this.Col_hab.DisplayStyleForCurrentCellOnly = true;
			this.Col_hab.HeaderText = "Hab Cmd";
			this.Col_hab.Items.AddRange(new object[]
			{
				"Habilitado",
				"Bloqueado"
			});
			this.Col_hab.Name = "Col_hab";
			this.Col_hab.Resizable = (HorizontalAlignment)2;
			this.Col_hab.Width = (HorizontalAlignment)80;
			this.Col_Esc_1.HeaderText = "Escala 1";
			this.Col_Esc_1.MaxInputLength = (HorizontalAlignment)5;
			this.Col_Esc_1.Name = "Col_Esc_1";
			this.Col_Esc_1.Resizable = (HorizontalAlignment)2;
			this.Col_Esc_1.SortMode = (HorizontalAlignment)0;
			this.Col_Esc_1.Width = (HorizontalAlignment)60;
			this.Col_Esc_2.HeaderText = "Escala 2";
			this.Col_Esc_2.MaxInputLength = (HorizontalAlignment)5;
			this.Col_Esc_2.Name = "Col_Esc_2";
			this.Col_Esc_2.Resizable = (HorizontalAlignment)2;
			this.Col_Esc_2.SortMode = (HorizontalAlignment)0;
			this.Col_Esc_2.Width = (HorizontalAlignment)60;
			this.Col_Esc_3.HeaderText = "Escala 3";
			this.Col_Esc_3.MaxInputLength = (HorizontalAlignment)5;
			this.Col_Esc_3.Name = "Col_Esc_3";
			this.Col_Esc_3.Resizable = (HorizontalAlignment)2;
			this.Col_Esc_3.SortMode = (HorizontalAlignment)0;
			this.Col_Esc_3.Width = (HorizontalAlignment)60;
			this.Col_Esc_4.HeaderText = "Escala 4";
			this.Col_Esc_4.MaxInputLength = (HorizontalAlignment)5;
			this.Col_Esc_4.Name = "Col_Esc_4";
			this.Col_Esc_4.Resizable = (HorizontalAlignment)2;
			this.Col_Esc_4.SortMode = (HorizontalAlignment)0;
			this.Col_Esc_4.Width = (HorizontalAlignment)60;
			this.Col_Esc_5.HeaderText = "Escala 5";
			this.Col_Esc_5.MaxInputLength = (HorizontalAlignment)5;
			this.Col_Esc_5.Name = "Col_Esc_5";
			this.Col_Esc_5.SortMode = (HorizontalAlignment)0;
			this.Col_Esc_5.Width = (HorizontalAlignment)60;
			this.Col_Esc_6.HeaderText = "Escala 6";
			this.Col_Esc_6.MaxInputLength = (HorizontalAlignment)5;
			this.Col_Esc_6.Name = "Col_Esc_6";
			this.Col_Esc_6.Resizable = (HorizontalAlignment)2;
			this.Col_Esc_6.SortMode = (HorizontalAlignment)0;
			this.Col_Esc_6.Width = (HorizontalAlignment)60;
			this.Col_Esc_7.HeaderText = "Escala 7";
			this.Col_Esc_7.MaxInputLength = (HorizontalAlignment)5;
			this.Col_Esc_7.Name = "Col_Esc_7";
			this.Col_Esc_7.Resizable = (HorizontalAlignment)2;
			this.Col_Esc_7.SortMode = (HorizontalAlignment)0;
			this.Col_Esc_7.Width = (HorizontalAlignment)60;
			this.Col_Esc_8.HeaderText = "Escala 8";
			this.Col_Esc_8.MaxInputLength = (HorizontalAlignment)5;
			this.Col_Esc_8.Name = "Col_Esc_8";
			this.Col_Esc_8.Resizable = (HorizontalAlignment)2;
			this.Col_Esc_8.SortMode = (HorizontalAlignment)0;
			this.Col_Esc_8.Width = (HorizontalAlignment)60;
			this.Col_Esc_9.HeaderText = "Escala 9";
			this.Col_Esc_9.MaxInputLength = (HorizontalAlignment)5;
			this.Col_Esc_9.Name = "Col_Esc_9";
			this.Col_Esc_9.Resizable = (HorizontalAlignment)2;
			this.Col_Esc_9.SortMode = (HorizontalAlignment)0;
			this.Col_Esc_9.Width = (HorizontalAlignment)60;
			this.Col_Esc_10.HeaderText = "Escala 10";
			this.Col_Esc_10.MaxInputLength = (HorizontalAlignment)5;
			this.Col_Esc_10.Name = "Col_Esc_10";
			this.Col_Esc_10.Resizable = (HorizontalAlignment)2;
			this.Col_Esc_10.SortMode = (HorizontalAlignment)0;
			this.Col_Esc_10.Width = (HorizontalAlignment)60;
			this.Col_Esc_11.HeaderText = "Escala 11";
			this.Col_Esc_11.MaxInputLength = (HorizontalAlignment)5;
			this.Col_Esc_11.Name = "Col_Esc_11";
			this.Col_Esc_11.Resizable = (HorizontalAlignment)2;
			this.Col_Esc_11.SortMode = (HorizontalAlignment)0;
			this.Col_Esc_11.Width = (HorizontalAlignment)60;
			this.Col_Esc_12.HeaderText = "Escala 12";
			this.Col_Esc_12.MaxInputLength = (HorizontalAlignment)5;
			this.Col_Esc_12.Name = "Col_Esc_12";
			this.Col_Esc_12.SortMode = (HorizontalAlignment)0;
			this.Col_Esc_12.Width = (HorizontalAlignment)60;
			this.Col_Esc_13.HeaderText = "Escala 13";
			this.Col_Esc_13.MaxInputLength = (HorizontalAlignment)5;
			this.Col_Esc_13.Name = "Col_Esc_13";
			this.Col_Esc_13.Resizable = (HorizontalAlignment)2;
			this.Col_Esc_13.SortMode = (HorizontalAlignment)0;
			this.Col_Esc_13.Width = (HorizontalAlignment)60;
			this.Col_Esc_14.HeaderText = "Escala 14";
			this.Col_Esc_14.MaxInputLength = (HorizontalAlignment)5;
			this.Col_Esc_14.Name = "Col_Esc_14";
			this.Col_Esc_14.Resizable = (HorizontalAlignment)2;
			this.Col_Esc_14.SortMode = (HorizontalAlignment)0;
			this.Col_Esc_14.Width = (HorizontalAlignment)60;
			this.Col_Esc_15.HeaderText = "Escala 15";
			this.Col_Esc_15.MaxInputLength = (HorizontalAlignment)5;
			this.Col_Esc_15.Name = "Col_Esc_15";
			this.Col_Esc_15.Resizable = (HorizontalAlignment)2;
			this.Col_Esc_15.SortMode = (HorizontalAlignment)0;
			this.Col_Esc_15.Width = (HorizontalAlignment)60;
			this.Col_Esc_16.HeaderText = "Escala 16";
			this.Col_Esc_16.MaxInputLength = (HorizontalAlignment)5;
			this.Col_Esc_16.Name = "Col_Esc_16";
			this.Col_Esc_16.Resizable = (HorizontalAlignment)2;
			this.Col_Esc_16.SortMode = (HorizontalAlignment)0;
			this.Col_Esc_16.Width = (HorizontalAlignment)60;
			global::System.Drawing.SizeF autoScaleDimensions;
			autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			size = new size(1131, 676);
			this.ClientSize = size;
			this.Controls.Add(this.Grupo_comandos);
			this.Controls.Add(this.Grupo_conf_equipamentos);
			this.Controls.Add(this.Grupo_lapelas);
			this.Controls.Add(this.Grupo_conf_comunicacao);
			this.Controls.Add(this.MenuStrip1);
			this.FormBorderStyle = FormBorderStyle.None;
			location = new location(160, 2);
			this.Location = location;
			this.MainMenuStrip = this.MenuStrip1;
			this.Name = "Equip_302_conf";
			this.StartPosition = FormStartPosition.Manual;
			this.Text = "Equip_302_conf";
			this.Grupo_conf_comunicacao.ResumeLayout(false);
			this.Grupo_conf_comunicacao.PerformLayout();
			this.Valor_intervalo_polling.EndInit();
			this.Valor_erro_falha.EndInit();
			this.Valor_timeout.EndInit();
			this.Valor_temp_ptt.EndInit();
			this.Valor_endereco.EndInit();
			this.Valor_num_tentativas.EndInit();
			this.Grupo_lapelas.ResumeLayout(false);
			this.TabControl2.ResumeLayout(false);
			this.Conf_res.ResumeLayout(false);
			this.DataGridView1.EndInit();
			this.Conf_rq.ResumeLayout(false);
			this.DataGridView_RQ.EndInit();
			this.Conf_centrais.ResumeLayout(false);
			this.Conf_centrais.PerformLayout();
			this.DataGridView_central_rq.EndInit();
			this.DataGridView_central_res.EndInit();
			this.DataGridView_central_geral.EndInit();
			this.Grupo_conf_equipamentos.ResumeLayout(false);
			this.Grupo_conf_equipamentos.PerformLayout();
			this.Valor_vista_equipamentos.EndInit();
			this.Valor_end_ini_vista.EndInit();
			this.Valor_end_ini_rq.EndInit();
			this.Valor_end_ini_res.EndInit();
			this.Valor_rq_equipamentos.EndInit();
			this.Valor_res_equipamentos.EndInit();
			this.Valor_res_sistema.EndInit();
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
