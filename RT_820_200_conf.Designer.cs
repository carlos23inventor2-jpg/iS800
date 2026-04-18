using System.Drawing;
using System.Windows.Forms;
﻿namespace iS800
{
	// Token: 0x02000035 RID: 53
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class RT_820_200_conf : global::System.Windows.Forms.Form
	{
		// Token: 0x0600057A RID: 1402 RVA: 0x00299718 File Offset: 0x00297B18
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

		// Token: 0x0600057B RID: 1403 RVA: 0x00299758 File Offset: 0x00297B58
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
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
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::iS800.RT_820_200_conf));
			this.GroupBox_sistema_leitura = new global::System.Windows.Forms.GroupBox();
			this.CheckBox_hab_eletrodos = new global::System.Windows.Forms.CheckBox();
			this.GroupBox_operacao = new global::System.Windows.Forms.GroupBox();
			this.ComboBox_metodo_operacao = new global::System.Windows.Forms.ComboBox();
			this.NumericUpDown_intervalo_tx = new global::System.Windows.Forms.NumericUpDown();
			this.Label_metodo_operacao = new global::System.Windows.Forms.Label();
			this.Label_intevalo_tx_pto_pto = new global::System.Windows.Forms.Label();
			this.GroupBox_informacoes = new global::System.Windows.Forms.GroupBox();
			this.TextBox_equipamento = new global::System.Windows.Forms.TextBox();
			this.Label_equipamento = new global::System.Windows.Forms.Label();
			this.TextBox_release = new global::System.Windows.Forms.TextBox();
			this.Label_release = new global::System.Windows.Forms.Label();
			this.TextBox_build = new global::System.Windows.Forms.TextBox();
			this.Label_build = new global::System.Windows.Forms.Label();
			this.TextBox_versao = new global::System.Windows.Forms.TextBox();
			this.Label_versao = new global::System.Windows.Forms.Label();
			this.GroupBox_modelo_simulado = new global::System.Windows.Forms.GroupBox();
			this.ComboBox_modo_simulado = new global::System.Windows.Forms.ComboBox();
			this.GroupBox_comunicacao = new global::System.Windows.Forms.GroupBox();
			this.NumericUpDown_temp_ptt = new global::System.Windows.Forms.NumericUpDown();
			this.NumericUpDown_end_mestre = new global::System.Windows.Forms.NumericUpDown();
			this.NumericUpDown_end_est = new global::System.Windows.Forms.NumericUpDown();
			this.Label_tempo_ptt = new global::System.Windows.Forms.Label();
			this.Label_end_mestre = new global::System.Windows.Forms.Label();
			this.Label_end_est = new global::System.Windows.Forms.Label();
			this.OpenFileDialog_RT_820 = new global::System.Windows.Forms.OpenFileDialog();
			this.SaveFileDialog_RT_820 = new global::System.Windows.Forms.SaveFileDialog();
			this.TabControl_820 = new global::System.Windows.Forms.TabControl();
			this.TabPage_geral = new global::System.Windows.Forms.TabPage();
			this.GroupBox_descricao_RT820 = new global::System.Windows.Forms.GroupBox();
			this.TextBox_comentarios_RT820 = new global::System.Windows.Forms.TextBox();
			this.TextBox_endereco_RT820 = new global::System.Windows.Forms.TextBox();
			this.TextBox_nome_RT820 = new global::System.Windows.Forms.TextBox();
			this.Label_comentarios = new global::System.Windows.Forms.Label();
			this.Label_endereco = new global::System.Windows.Forms.Label();
			this.Label_nome = new global::System.Windows.Forms.Label();
			this.GroupBox_informacoes_820 = new global::System.Windows.Forms.GroupBox();
			this.Label48 = new global::System.Windows.Forms.Label();
			this.TextBox_equipamento_820 = new global::System.Windows.Forms.TextBox();
			this.Label49 = new global::System.Windows.Forms.Label();
			this.TextBox_release_820 = new global::System.Windows.Forms.TextBox();
			this.Label50 = new global::System.Windows.Forms.Label();
			this.TextBox_build_820 = new global::System.Windows.Forms.TextBox();
			this.Label51 = new global::System.Windows.Forms.Label();
			this.TextBox_versao_820 = new global::System.Windows.Forms.TextBox();
			this.Label52 = new global::System.Windows.Forms.Label();
			this.GroupBox_comunicacao_820 = new global::System.Windows.Forms.GroupBox();
			this.NumericUpDown_temp_ptt_820 = new global::System.Windows.Forms.NumericUpDown();
			this.Label_baudrate_COM2_820 = new global::System.Windows.Forms.Label();
			this.ComboBox_baudrate_COM2_820 = new global::System.Windows.Forms.ComboBox();
			this.NumericUpDown_end_mestre_820 = new global::System.Windows.Forms.NumericUpDown();
			this.NumericUpDown_end_est_820 = new global::System.Windows.Forms.NumericUpDown();
			this.Label_tempo_ptt_820 = new global::System.Windows.Forms.Label();
			this.Label_end_mestre_820 = new global::System.Windows.Forms.Label();
			this.Label_end_est_820 = new global::System.Windows.Forms.Label();
			this.tb_lixo1 = new global::System.Windows.Forms.TextBox();
			this.TabPage_EA = new global::System.Windows.Forms.TabPage();
			this.GroupBox_EA_820 = new global::System.Windows.Forms.GroupBox();
			this.NumericUpDown_intervalo_filtro_820 = new global::System.Windows.Forms.NumericUpDown();
			this.NumericUpDown_tamanho_filtro_820 = new global::System.Windows.Forms.NumericUpDown();
			this.Label_intervalo_filtro_820 = new global::System.Windows.Forms.Label();
			this.Label_tamanho_filtro_820 = new global::System.Windows.Forms.Label();
			this.tb_lixo2 = new global::System.Windows.Forms.TextBox();
			this.TabPage_controle = new global::System.Windows.Forms.TabPage();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.cb_Controle = new global::System.Windows.Forms.ComboBox();
			this.cb_Protecao = new global::System.Windows.Forms.ComboBox();
			this.Label18 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.checkbox_habilita_controle = new global::System.Windows.Forms.CheckBox();
			this.tb_lixo3 = new global::System.Windows.Forms.TextBox();
			this.TabPage_ED = new global::System.Windows.Forms.TabPage();
			this.GroupBox_ED_820 = new global::System.Windows.Forms.GroupBox();
			this.DataGridView_RT820_ED = new global::System.Windows.Forms.DataGridView();
			this.TabPage_setpoints = new global::System.Windows.Forms.TabPage();
			this.GroupBox7 = new global::System.Windows.Forms.GroupBox();
			this.Label73 = new global::System.Windows.Forms.Label();
			this.sph_baixo41 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_alto41 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_minuto41 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_ativa41 = new global::System.Windows.Forms.CheckBox();
			this.sph_hora41 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_baixo40 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_alto40 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_minuto40 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_ativa40 = new global::System.Windows.Forms.CheckBox();
			this.sph_hora40 = new global::System.Windows.Forms.NumericUpDown();
			this.Label72 = new global::System.Windows.Forms.Label();
			this.sph_baixo31 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_alto31 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_minuto31 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_ativa31 = new global::System.Windows.Forms.CheckBox();
			this.sph_hora31 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_baixo30 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_alto30 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_minuto30 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_ativa30 = new global::System.Windows.Forms.CheckBox();
			this.sph_hora30 = new global::System.Windows.Forms.NumericUpDown();
			this.Label67 = new global::System.Windows.Forms.Label();
			this.sph_baixo21 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_alto21 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_minuto21 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_ativa21 = new global::System.Windows.Forms.CheckBox();
			this.sph_hora21 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_baixo20 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_alto20 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_minuto20 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_ativa20 = new global::System.Windows.Forms.CheckBox();
			this.sph_hora20 = new global::System.Windows.Forms.NumericUpDown();
			this.Label62 = new global::System.Windows.Forms.Label();
			this.sph_baixo11 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_alto11 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_minuto11 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_ativa11 = new global::System.Windows.Forms.CheckBox();
			this.sph_hora11 = new global::System.Windows.Forms.NumericUpDown();
			this.Label57 = new global::System.Windows.Forms.Label();
			this.Label56 = new global::System.Windows.Forms.Label();
			this.sph_baixo10 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_alto10 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_minuto10 = new global::System.Windows.Forms.NumericUpDown();
			this.sph_ativa10 = new global::System.Windows.Forms.CheckBox();
			this.Label55 = new global::System.Windows.Forms.Label();
			this.Label54 = new global::System.Windows.Forms.Label();
			this.sph_hora10 = new global::System.Windows.Forms.NumericUpDown();
			this.Label53 = new global::System.Windows.Forms.Label();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.Label75 = new global::System.Windows.Forms.Label();
			this.Label74 = new global::System.Windows.Forms.Label();
			this.nud_protecao_liga = new global::System.Windows.Forms.NumericUpDown();
			this.nud_protecao_desliga = new global::System.Windows.Forms.NumericUpDown();
			this.nud_motor4_baixo = new global::System.Windows.Forms.NumericUpDown();
			this.nud_motor4_alto = new global::System.Windows.Forms.NumericUpDown();
			this.nud_motor3_baixo = new global::System.Windows.Forms.NumericUpDown();
			this.nud_motor3_alto = new global::System.Windows.Forms.NumericUpDown();
			this.nud_motor2_baixo = new global::System.Windows.Forms.NumericUpDown();
			this.nud_motor2_alto = new global::System.Windows.Forms.NumericUpDown();
			this.nud_motor1_baixo = new global::System.Windows.Forms.NumericUpDown();
			this.Label28 = new global::System.Windows.Forms.Label();
			this.Label27 = new global::System.Windows.Forms.Label();
			this.Label25 = new global::System.Windows.Forms.Label();
			this.Label22 = new global::System.Windows.Forms.Label();
			this.Label21 = new global::System.Windows.Forms.Label();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.nud_motor1_alto = new global::System.Windows.Forms.NumericUpDown();
			this.tb_lixo5 = new global::System.Windows.Forms.TextBox();
			this.TabPage_MotoresValvulas = new global::System.Windows.Forms.TabPage();
			this.GroupBox6 = new global::System.Windows.Forms.GroupBox();
			this.cb_modo_partida4 = new global::System.Windows.Forms.ComboBox();
			this.cb_modo_partida3 = new global::System.Windows.Forms.ComboBox();
			this.cb_modo_partida2 = new global::System.Windows.Forms.ComboBox();
			this.cb_modo_partida1 = new global::System.Windows.Forms.ComboBox();
			this.nud_parada4 = new global::System.Windows.Forms.NumericUpDown();
			this.nud_partida4 = new global::System.Windows.Forms.NumericUpDown();
			this.nud_parada3 = new global::System.Windows.Forms.NumericUpDown();
			this.nud_partida3 = new global::System.Windows.Forms.NumericUpDown();
			this.nud_parada2 = new global::System.Windows.Forms.NumericUpDown();
			this.nud_partida2 = new global::System.Windows.Forms.NumericUpDown();
			this.nud_parada1 = new global::System.Windows.Forms.NumericUpDown();
			this.nud_partida1 = new global::System.Windows.Forms.NumericUpDown();
			this.Label47 = new global::System.Windows.Forms.Label();
			this.Label46 = new global::System.Windows.Forms.Label();
			this.Label45 = new global::System.Windows.Forms.Label();
			this.Label44 = new global::System.Windows.Forms.Label();
			this.Label43 = new global::System.Windows.Forms.Label();
			this.Label42 = new global::System.Windows.Forms.Label();
			this.Label41 = new global::System.Windows.Forms.Label();
			this.GroupBox5 = new global::System.Windows.Forms.GroupBox();
			this.nud_valvula4_fechamento = new global::System.Windows.Forms.NumericUpDown();
			this.nud_valvula4_abertura = new global::System.Windows.Forms.NumericUpDown();
			this.nud_valvula3_fechamento = new global::System.Windows.Forms.NumericUpDown();
			this.nud_valvula3_abertura = new global::System.Windows.Forms.NumericUpDown();
			this.nud_valvula2_fechamento = new global::System.Windows.Forms.NumericUpDown();
			this.nud_valvula2_abertura = new global::System.Windows.Forms.NumericUpDown();
			this.nud_valvula1_fechamento = new global::System.Windows.Forms.NumericUpDown();
			this.nud_valvula1_abertura = new global::System.Windows.Forms.NumericUpDown();
			this.Label40 = new global::System.Windows.Forms.Label();
			this.Label39 = new global::System.Windows.Forms.Label();
			this.Label38 = new global::System.Windows.Forms.Label();
			this.Label37 = new global::System.Windows.Forms.Label();
			this.Label36 = new global::System.Windows.Forms.Label();
			this.Label35 = new global::System.Windows.Forms.Label();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.nud_tempo_operacoes = new global::System.Windows.Forms.NumericUpDown();
			this.nud_bombas_simultaneas = new global::System.Windows.Forms.NumericUpDown();
			this.nud_numero_valvulas = new global::System.Windows.Forms.NumericUpDown();
			this.nud_numero_motores = new global::System.Windows.Forms.NumericUpDown();
			this.cb_modo_operacao = new global::System.Windows.Forms.ComboBox();
			this.Label34 = new global::System.Windows.Forms.Label();
			this.Label33 = new global::System.Windows.Forms.Label();
			this.Label32 = new global::System.Windows.Forms.Label();
			this.Label31 = new global::System.Windows.Forms.Label();
			this.Label30 = new global::System.Windows.Forms.Label();
			this.tb_lixo6 = new global::System.Windows.Forms.TextBox();
			this.TabPage_vazao_perifericos = new global::System.Windows.Forms.TabPage();
			this.GroupBox_perifericos_820 = new global::System.Windows.Forms.GroupBox();
			this.DataGridView_periferico_RT820 = new global::System.Windows.Forms.DataGridView();
			this.TabPage_repetidora = new global::System.Windows.Forms.TabPage();
			this.GroupBox_end_rep_820 = new global::System.Windows.Forms.GroupBox();
			this.DataGridView_end_rep_RT820 = new global::System.Windows.Forms.DataGridView();
			this.GroupBox_parametros_repetidora_820 = new global::System.Windows.Forms.GroupBox();
			this.Label29 = new global::System.Windows.Forms.Label();
			this.cb_ModoRepetidora = new global::System.Windows.Forms.ComboBox();
			this.NumericUpDown_num_est_rep_820 = new global::System.Windows.Forms.NumericUpDown();
			this.NumericUpDown_end_rep_820 = new global::System.Windows.Forms.NumericUpDown();
			this.Label_num_est_rep_820 = new global::System.Windows.Forms.Label();
			this.Label_end_rep_820 = new global::System.Windows.Forms.Label();
			this.tb_lixo7 = new global::System.Windows.Forms.TextBox();
			this.TabPage1 = new global::System.Windows.Forms.TabPage();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label16 = new global::System.Windows.Forms.Label();
			this.Label15 = new global::System.Windows.Forms.Label();
			this.T_ModeloFonte = new global::System.Windows.Forms.TextBox();
			this.T_AlturaAntena = new global::System.Windows.Forms.TextBox();
			this.T_Latitude = new global::System.Windows.Forms.TextBox();
			this.T_Longitude = new global::System.Windows.Forms.TextBox();
			this.T_Azimute = new global::System.Windows.Forms.TextBox();
			this.Label14 = new global::System.Windows.Forms.Label();
			this.Label13 = new global::System.Windows.Forms.Label();
			this.Label12 = new global::System.Windows.Forms.Label();
			this.T_FreqRadio = new global::System.Windows.Forms.TextBox();
			this.T_DistCentral = new global::System.Windows.Forms.TextBox();
			this.T_PotRadio = new global::System.Windows.Forms.TextBox();
			this.CB_ModeloRadio = new global::System.Windows.Forms.ComboBox();
			this.CB_PolarizacaoAntena = new global::System.Windows.Forms.ComboBox();
			this.CB_TipoAntena = new global::System.Windows.Forms.ComboBox();
			this.Label11 = new global::System.Windows.Forms.Label();
			this.Label10 = new global::System.Windows.Forms.Label();
			this.Label9 = new global::System.Windows.Forms.Label();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label17 = new global::System.Windows.Forms.Label();
			this.tb_lixo8 = new global::System.Windows.Forms.TextBox();
			this.ToolStri_RT_820 = new global::System.Windows.Forms.ToolStrip();
			this.ToolStripButton_RT_820_novo = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripButton_RT_820_Abrir = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripButton_RT_820_Salvar = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ToolStripButton_RT_820_Download = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripButton_RT_820_Upload = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ToolStripButton_RT820_Imprimir = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ToolStripLabel_ID = new global::System.Windows.Forms.ToolStripLabel();
			this.ToolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ToolStripTextBox_RT_820_Msg = new global::System.Windows.Forms.ToolStripTextBox();
			this.ToolStripProgressBar_RT_820 = new global::System.Windows.Forms.ToolStripProgressBar();
			this.Timer_limpa_MSG_820 = new global::System.Windows.Forms.Timer(this.components);
			this.PrintDocument1 = new global::System.Drawing.Printing.PrintDocument();
			this.PrintPreviewDialog1 = new global::System.Windows.Forms.PrintPreviewDialog();
			this.PrintDialog1 = new global::System.Windows.Forms.PrintDialog();
			this.GroupBox_sistema_leitura.SuspendLayout();
			this.GroupBox_operacao.SuspendLayout();
			
			this.GroupBox_informacoes.SuspendLayout();
			this.GroupBox_modelo_simulado.SuspendLayout();
			this.GroupBox_comunicacao.SuspendLayout();
			
			
			
			this.TabControl_820.SuspendLayout();
			this.TabPage_geral.SuspendLayout();
			this.GroupBox_descricao_RT820.SuspendLayout();
			this.GroupBox_informacoes_820.SuspendLayout();
			this.GroupBox_comunicacao_820.SuspendLayout();
			
			
			
			this.TabPage_EA.SuspendLayout();
			this.GroupBox_EA_820.SuspendLayout();
			
			
			this.TabPage_controle.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.TabPage_ED.SuspendLayout();
			this.GroupBox_ED_820.SuspendLayout();
			
			this.TabPage_setpoints.SuspendLayout();
			this.GroupBox7.SuspendLayout();
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			this.GroupBox3.SuspendLayout();
			
			
			
			
			
			
			
			
			
			
			this.TabPage_MotoresValvulas.SuspendLayout();
			this.GroupBox6.SuspendLayout();
			
			
			
			
			
			
			
			
			this.GroupBox5.SuspendLayout();
			
			
			
			
			
			
			
			
			this.GroupBox4.SuspendLayout();
			
			
			
			
			this.TabPage_vazao_perifericos.SuspendLayout();
			this.GroupBox_perifericos_820.SuspendLayout();
			
			this.TabPage_repetidora.SuspendLayout();
			this.GroupBox_end_rep_820.SuspendLayout();
			
			this.GroupBox_parametros_repetidora_820.SuspendLayout();
			
			
			this.TabPage1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.ToolStri_RT_820.SuspendLayout();
			this.SuspendLayout();
			this.GroupBox_sistema_leitura.Controls.Add(this.CheckBox_hab_eletrodos);
			this.GroupBox_sistema_leitura.Enabled = false;
			global::System.Windows.Forms.Control groupBox_sistema_leitura = this.GroupBox_sistema_leitura;
			groupBox_sistema_leitura.Location = new global::System.Drawing.Point(20, 354);
			this.GroupBox_sistema_leitura.Name = "GroupBox_sistema_leitura";
			global::System.Windows.Forms.Control groupBox_sistema_leitura2 = this.GroupBox_sistema_leitura;
			groupBox_sistema_leitura2.Size = new global::System.Drawing.Size(291, 71);
			this.GroupBox_sistema_leitura.TabIndex = 7;
			this.GroupBox_sistema_leitura.TabStop = false;
			this.GroupBox_sistema_leitura.Text = "Sistema de Leitura de Eletrodos";
			this.CheckBox_hab_eletrodos.AutoSize = true;
			global::System.Windows.Forms.Control checkBox_hab_eletrodos = this.CheckBox_hab_eletrodos;
checkBox_hab_eletrodos.Location = new global::System.Drawing.Point(39, 33);
			this.CheckBox_hab_eletrodos.Name = "CheckBox_hab_eletrodos";
			global::System.Windows.Forms.Control checkBox_hab_eletrodos2 = this.CheckBox_hab_eletrodos;
			Size = new System.Drawing.Size(153, 17);
			checkBox_hab_eletrodos2.Size = this.Size;
			this.CheckBox_hab_eletrodos.TabIndex = 0;
			this.CheckBox_hab_eletrodos.Text = "Habilita leitura de eletrodos";
			this.CheckBox_hab_eletrodos.UseVisualStyleBackColor = true;
			this.GroupBox_operacao.Controls.Add(this.ComboBox_metodo_operacao);
			this.GroupBox_operacao.Controls.Add(this.NumericUpDown_intervalo_tx);
			this.GroupBox_operacao.Controls.Add(this.Label_metodo_operacao);
			this.GroupBox_operacao.Controls.Add(this.Label_intevalo_tx_pto_pto);
			this.GroupBox_operacao.Enabled = false;
			global::System.Windows.Forms.Control groupBox_operacao = this.GroupBox_operacao;
groupBox_operacao.Location = new global::System.Drawing.Point(20, 243);
			this.GroupBox_operacao.Name = "GroupBox_operacao";
			global::System.Windows.Forms.Control groupBox_operacao2 = this.GroupBox_operacao;
			Size = new System.Drawing.Size(291, 94);
			groupBox_operacao2.Size = this.Size;
			this.GroupBox_operacao.TabIndex = 6;
			this.GroupBox_operacao.TabStop = false;
			this.GroupBox_operacao.Text = "Modo de Operação";
			this.ComboBox_metodo_operacao.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox_metodo_operacao = this.ComboBox_metodo_operacao;
comboBox_metodo_operacao.Location = new global::System.Drawing.Point(132, 28);
			this.ComboBox_metodo_operacao.Name = "ComboBox_metodo_operacao";
			global::System.Windows.Forms.Control comboBox_metodo_operacao2 = this.ComboBox_metodo_operacao;
			Size = new System.Drawing.Size(144, 21);
			comboBox_metodo_operacao2.Size = this.Size;
			this.ComboBox_metodo_operacao.TabIndex = 6;
			this.NumericUpDown_intervalo_tx.Enabled = false;
			global::System.Windows.Forms.Control numericUpDown_intervalo_tx = this.NumericUpDown_intervalo_tx;
numericUpDown_intervalo_tx.Location = new global::System.Drawing.Point(204, 57);
			global::System.Windows.Forms.NumericUpDown numericUpDown_intervalo_tx2 = this.NumericUpDown_intervalo_tx;
			decimal num;
			num = new decimal(new int[]
			{
				200000,
				0,
				0,
				0
			});
			numericUpDown_intervalo_tx2.Maximum = num;
			this.NumericUpDown_intervalo_tx.Name = "NumericUpDown_intervalo_tx";
			global::System.Windows.Forms.Control numericUpDown_intervalo_tx3 = this.NumericUpDown_intervalo_tx;
			Size = new System.Drawing.Size(72, 20);
			numericUpDown_intervalo_tx3.Size = this.Size;
			this.NumericUpDown_intervalo_tx.TabIndex = 1;
			this.NumericUpDown_intervalo_tx.TextAlign = HorizontalAlignment.Right;
			this.Label_metodo_operacao.AutoSize = true;
			global::System.Windows.Forms.Control label_metodo_operacao = this.Label_metodo_operacao;
label_metodo_operacao.Location = new global::System.Drawing.Point(21, 31);
			this.Label_metodo_operacao.Name = "Label_metodo_operacao";
			global::System.Windows.Forms.Control label_metodo_operacao2 = this.Label_metodo_operacao;
			Size = new System.Drawing.Size(114, 13);
			label_metodo_operacao2.Size = this.Size;
			this.Label_metodo_operacao.TabIndex = 3;
			this.Label_metodo_operacao.Text = "Método de Operação :";
			this.Label_intevalo_tx_pto_pto.AutoSize = true;
			this.Label_intevalo_tx_pto_pto.Enabled = false;
			global::System.Windows.Forms.Control label_intevalo_tx_pto_pto = this.Label_intevalo_tx_pto_pto;
label_intevalo_tx_pto_pto.Location = new global::System.Drawing.Point(21, 58);
			this.Label_intevalo_tx_pto_pto.Name = "Label_intevalo_tx_pto_pto";
			global::System.Windows.Forms.Control label_intevalo_tx_pto_pto2 = this.Label_intevalo_tx_pto_pto;
			Size = new System.Drawing.Size(151, 13);
			label_intevalo_tx_pto_pto2.Size = this.Size;
			this.Label_intevalo_tx_pto_pto.TabIndex = 4;
			this.Label_intevalo_tx_pto_pto.Text = "Intervalo Tx Ponto à Ponto (s):";
			this.GroupBox_informacoes.Controls.Add(this.TextBox_equipamento);
			this.GroupBox_informacoes.Controls.Add(this.Label_equipamento);
			this.GroupBox_informacoes.Controls.Add(this.TextBox_release);
			this.GroupBox_informacoes.Controls.Add(this.Label_release);
			this.GroupBox_informacoes.Controls.Add(this.TextBox_build);
			this.GroupBox_informacoes.Controls.Add(this.Label_build);
			this.GroupBox_informacoes.Controls.Add(this.TextBox_versao);
			this.GroupBox_informacoes.Controls.Add(this.Label_versao);
			this.GroupBox_informacoes.Enabled = false;
			global::System.Windows.Forms.Control groupBox_informacoes = this.GroupBox_informacoes;
groupBox_informacoes.Location = new global::System.Drawing.Point(330, 10);
			this.GroupBox_informacoes.Name = "GroupBox_informacoes";
			global::System.Windows.Forms.Control groupBox_informacoes2 = this.GroupBox_informacoes;
			Size = new System.Drawing.Size(238, 149);
			groupBox_informacoes2.Size = this.Size;
			this.GroupBox_informacoes.TabIndex = 2;
			this.GroupBox_informacoes.TabStop = false;
			this.GroupBox_informacoes.Text = "Informações";
			this.TextBox_equipamento.BackColor = global::System.Drawing.Color.Beige;
			global::System.Windows.Forms.Control textBox_equipamento = this.TextBox_equipamento;
textBox_equipamento.Location = new global::System.Drawing.Point(109, 31);
			this.TextBox_equipamento.Name = "TextBox_equipamento";
			this.TextBox_equipamento.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_equipamento2 = this.TextBox_equipamento;
			Size = new System.Drawing.Size(103, 20);
			textBox_equipamento2.Size = this.Size;
			this.TextBox_equipamento.TabIndex = 7;
			this.Label_equipamento.AutoSize = true;
			global::System.Windows.Forms.Control label_equipamento = this.Label_equipamento;
label_equipamento.Location = new global::System.Drawing.Point(28, 34);
			this.Label_equipamento.Name = "Label_equipamento";
			global::System.Windows.Forms.Control label_equipamento2 = this.Label_equipamento;
			Size = new System.Drawing.Size(75, 13);
			label_equipamento2.Size = this.Size;
			this.Label_equipamento.TabIndex = 6;
			this.Label_equipamento.Text = "Equipamento :";
			this.TextBox_release.BackColor = global::System.Drawing.Color.Beige;
			global::System.Windows.Forms.Control textBox_release = this.TextBox_release;
textBox_release.Location = new global::System.Drawing.Point(109, 112);
			this.TextBox_release.Name = "TextBox_release";
			this.TextBox_release.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_release2 = this.TextBox_release;
			Size = new System.Drawing.Size(103, 20);
			textBox_release2.Size = this.Size;
			this.TextBox_release.TabIndex = 5;
			this.Label_release.AutoSize = true;
			global::System.Windows.Forms.Control label_release = this.Label_release;
label_release.Location = new global::System.Drawing.Point(28, 115);
			this.Label_release.Name = "Label_release";
			global::System.Windows.Forms.Control label_release2 = this.Label_release;
			Size = new System.Drawing.Size(52, 13);
			label_release2.Size = this.Size;
			this.Label_release.TabIndex = 4;
			this.Label_release.Text = "Release :";
			this.TextBox_build.BackColor = global::System.Drawing.Color.Beige;
			global::System.Windows.Forms.Control textBox_build = this.TextBox_build;
textBox_build.Location = new global::System.Drawing.Point(109, 85);
			this.TextBox_build.Name = "TextBox_build";
			this.TextBox_build.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_build2 = this.TextBox_build;
			Size = new System.Drawing.Size(103, 20);
			textBox_build2.Size = this.Size;
			this.TextBox_build.TabIndex = 3;
			this.Label_build.AutoSize = true;
			global::System.Windows.Forms.Control label_build = this.Label_build;
label_build.Location = new global::System.Drawing.Point(28, 88);
			this.Label_build.Name = "Label_build";
			global::System.Windows.Forms.Control label_build2 = this.Label_build;
			Size = new System.Drawing.Size(36, 13);
			label_build2.Size = this.Size;
			this.Label_build.TabIndex = 2;
			this.Label_build.Text = "Build :";
			this.TextBox_versao.BackColor = global::System.Drawing.Color.Beige;
			global::System.Windows.Forms.Control textBox_versao = this.TextBox_versao;
textBox_versao.Location = new global::System.Drawing.Point(109, 58);
			this.TextBox_versao.Name = "TextBox_versao";
			this.TextBox_versao.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_versao2 = this.TextBox_versao;
			Size = new System.Drawing.Size(103, 20);
			textBox_versao2.Size = this.Size;
			this.TextBox_versao.TabIndex = 1;
			this.Label_versao.AutoSize = true;
			global::System.Windows.Forms.Control label_versao = this.Label_versao;
label_versao.Location = new global::System.Drawing.Point(28, 61);
			this.Label_versao.Name = "Label_versao";
			global::System.Windows.Forms.Control label_versao2 = this.Label_versao;
			Size = new System.Drawing.Size(46, 13);
			label_versao2.Size = this.Size;
			this.Label_versao.TabIndex = 0;
			this.Label_versao.Text = "Versão :";
			this.GroupBox_modelo_simulado.Controls.Add(this.ComboBox_modo_simulado);
			global::System.Windows.Forms.Control groupBox_modelo_simulado = this.GroupBox_modelo_simulado;
groupBox_modelo_simulado.Location = new global::System.Drawing.Point(20, 10);
			this.GroupBox_modelo_simulado.Name = "GroupBox_modelo_simulado";
			global::System.Windows.Forms.Control groupBox_modelo_simulado2 = this.GroupBox_modelo_simulado;
			Size = new System.Drawing.Size(291, 84);
			groupBox_modelo_simulado2.Size = this.Size;
			this.GroupBox_modelo_simulado.TabIndex = 0;
			this.GroupBox_modelo_simulado.TabStop = false;
			this.GroupBox_modelo_simulado.Text = "Modelo Simulado";
			this.ComboBox_modo_simulado.Anchor = (System.Windows.Forms.AnchorStyles)0;
			this.ComboBox_modo_simulado.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox_modo_simulado = this.ComboBox_modo_simulado;
comboBox_modo_simulado.Location = new global::System.Drawing.Point(24, 34);
			this.ComboBox_modo_simulado.Name = "ComboBox_modo_simulado";
			global::System.Windows.Forms.Control comboBox_modo_simulado2 = this.ComboBox_modo_simulado;
			Size = new System.Drawing.Size(252, 21);
			comboBox_modo_simulado2.Size = this.Size;
			this.ComboBox_modo_simulado.TabIndex = 0;
			this.GroupBox_comunicacao.Controls.Add(this.NumericUpDown_temp_ptt);
			this.GroupBox_comunicacao.Controls.Add(this.NumericUpDown_end_mestre);
			this.GroupBox_comunicacao.Controls.Add(this.NumericUpDown_end_est);
			this.GroupBox_comunicacao.Controls.Add(this.Label_tempo_ptt);
			this.GroupBox_comunicacao.Controls.Add(this.Label_end_mestre);
			this.GroupBox_comunicacao.Controls.Add(this.Label_end_est);
			this.GroupBox_comunicacao.Enabled = false;
			global::System.Windows.Forms.Control groupBox_comunicacao = this.GroupBox_comunicacao;
groupBox_comunicacao.Location = new global::System.Drawing.Point(20, 100);
			this.GroupBox_comunicacao.Name = "GroupBox_comunicacao";
			global::System.Windows.Forms.Control groupBox_comunicacao2 = this.GroupBox_comunicacao;
			Size = new System.Drawing.Size(291, 125);
			groupBox_comunicacao2.Size = this.Size;
			this.GroupBox_comunicacao.TabIndex = 1;
			this.GroupBox_comunicacao.TabStop = false;
			this.GroupBox_comunicacao.Text = "Parâmetros de Comunicação";
			global::System.Windows.Forms.NumericUpDown numericUpDown_temp_ptt = this.NumericUpDown_temp_ptt;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			numericUpDown_temp_ptt.Increment = num;
			global::System.Windows.Forms.Control numericUpDown_temp_ptt2 = this.NumericUpDown_temp_ptt;
numericUpDown_temp_ptt2.Location = new global::System.Drawing.Point(204, 83);
			global::System.Windows.Forms.NumericUpDown numericUpDown_temp_ptt3 = this.NumericUpDown_temp_ptt;
			num = new decimal(new int[]
			{
				70000,
				0,
				0,
				0
			});
			numericUpDown_temp_ptt3.Maximum = num;
			this.NumericUpDown_temp_ptt.Name = "NumericUpDown_temp_ptt";
			global::System.Windows.Forms.Control numericUpDown_temp_ptt4 = this.NumericUpDown_temp_ptt;
			Size = new System.Drawing.Size(72, 20);
			numericUpDown_temp_ptt4.Size = this.Size;
			this.NumericUpDown_temp_ptt.TabIndex = 2;
			this.NumericUpDown_temp_ptt.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.NumericUpDown numericUpDown_temp_ptt5 = this.NumericUpDown_temp_ptt;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			numericUpDown_temp_ptt5.Value = num;
			global::System.Windows.Forms.Control numericUpDown_end_mestre = this.NumericUpDown_end_mestre;
numericUpDown_end_mestre.Location = new global::System.Drawing.Point(204, 31);
			global::System.Windows.Forms.NumericUpDown numericUpDown_end_mestre2 = this.NumericUpDown_end_mestre;
			num = new decimal(new int[]
			{
				70000,
				0,
				0,
				0
			});
			numericUpDown_end_mestre2.Maximum = num;
			this.NumericUpDown_end_mestre.Name = "NumericUpDown_end_mestre";
			global::System.Windows.Forms.Control numericUpDown_end_mestre3 = this.NumericUpDown_end_mestre;
			Size = new System.Drawing.Size(72, 20);
			numericUpDown_end_mestre3.Size = this.Size;
			this.NumericUpDown_end_mestre.TabIndex = 0;
			this.NumericUpDown_end_mestre.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.Control numericUpDown_end_est = this.NumericUpDown_end_est;
numericUpDown_end_est.Location = new global::System.Drawing.Point(204, 57);
			global::System.Windows.Forms.NumericUpDown numericUpDown_end_est2 = this.NumericUpDown_end_est;
			num = new decimal(new int[]
			{
				70000,
				0,
				0,
				0
			});
			numericUpDown_end_est2.Maximum = num;
			this.NumericUpDown_end_est.Name = "NumericUpDown_end_est";
			global::System.Windows.Forms.Control numericUpDown_end_est3 = this.NumericUpDown_end_est;
			Size = new System.Drawing.Size(72, 20);
			numericUpDown_end_est3.Size = this.Size;
			this.NumericUpDown_end_est.TabIndex = 1;
			this.NumericUpDown_end_est.TextAlign = HorizontalAlignment.Right;
			this.Label_tempo_ptt.AutoSize = true;
			global::System.Windows.Forms.Control label_tempo_ptt = this.Label_tempo_ptt;
label_tempo_ptt.Location = new global::System.Drawing.Point(21, 85);
			this.Label_tempo_ptt.Name = "Label_tempo_ptt";
			global::System.Windows.Forms.Control label_tempo_ptt2 = this.Label_tempo_ptt;
			Size = new System.Drawing.Size(140, 13);
			label_tempo_ptt2.Size = this.Size;
			this.Label_tempo_ptt.TabIndex = 5;
			this.Label_tempo_ptt.Text = "Tempo Espera de PTT (ms):";
			this.Label_end_mestre.AutoSize = true;
			global::System.Windows.Forms.Control label_end_mestre = this.Label_end_mestre;
label_end_mestre.Location = new global::System.Drawing.Point(21, 31);
			this.Label_end_mestre.Name = "Label_end_mestre";
			global::System.Windows.Forms.Control label_end_mestre2 = this.Label_end_mestre;
			Size = new System.Drawing.Size(109, 13);
			label_end_mestre2.Size = this.Size;
			this.Label_end_mestre.TabIndex = 3;
			this.Label_end_mestre.Text = "Endereço do Mestre :";
			this.Label_end_est.AutoSize = true;
			global::System.Windows.Forms.Control label_end_est = this.Label_end_est;
label_end_est.Location = new global::System.Drawing.Point(21, 58);
			this.Label_end_est.Name = "Label_end_est";
			global::System.Windows.Forms.Control label_end_est2 = this.Label_end_est;
			Size = new System.Drawing.Size(116, 13);
			label_end_est2.Size = this.Size;
			this.Label_end_est.TabIndex = 4;
			this.Label_end_est.Text = "Endereço da Estação :";
			this.OpenFileDialog_RT_820.FileName = "OpenFileDialog1";
			this.TabControl_820.Controls.Add(this.TabPage_geral);
			this.TabControl_820.Controls.Add(this.TabPage_EA);
			this.TabControl_820.Controls.Add(this.TabPage_controle);
			this.TabControl_820.Controls.Add(this.TabPage_ED);
			this.TabControl_820.Controls.Add(this.TabPage_setpoints);
			this.TabControl_820.Controls.Add(this.TabPage_MotoresValvulas);
			this.TabControl_820.Controls.Add(this.TabPage_vazao_perifericos);
			this.TabControl_820.Controls.Add(this.TabPage_repetidora);
			this.TabControl_820.Controls.Add(this.TabPage1);
			this.TabControl_820.HotTrack = true;
			global::System.Windows.Forms.Control tabControl_ = this.TabControl_820;
tabControl_.Location = new global::System.Drawing.Point(10, 66);
			this.TabControl_820.Name = "TabControl_820";
			this.TabControl_820.SelectedIndex = 0;
			global::System.Windows.Forms.Control tabControl_2 = this.TabControl_820;
			Size = new System.Drawing.Size(1302, 469);
			tabControl_2.Size = this.Size;
			this.TabControl_820.TabIndex = 10;
			this.TabPage_geral.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.TabPage_geral.Controls.Add(this.GroupBox_descricao_RT820);
			this.TabPage_geral.Controls.Add(this.GroupBox_informacoes_820);
			this.TabPage_geral.Controls.Add(this.GroupBox_comunicacao_820);
			global::System.Windows.Forms.TabPage tabPage_geral = this.TabPage_geral;
tabPage_geral.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_geral.Name = "TabPage_geral";
			global::System.Windows.Forms.Control tabPage_geral2 = this.TabPage_geral;
			global::System.Windows.Forms.Padding Padding;
			Padding = new global::System.Windows.Forms.Padding(3);
			tabPage_geral2.Padding = Padding;
			global::System.Windows.Forms.Control tabPage_geral3 = this.TabPage_geral;
			Size = new System.Drawing.Size(1294, 443);
			tabPage_geral3.Size = this.Size;
			this.TabPage_geral.TabIndex = 0;
			this.TabPage_geral.Text = "Geral";
			this.TabPage_geral.UseVisualStyleBackColor = true;
			this.GroupBox_descricao_RT820.Controls.Add(this.TextBox_comentarios_RT820);
			this.GroupBox_descricao_RT820.Controls.Add(this.TextBox_endereco_RT820);
			this.GroupBox_descricao_RT820.Controls.Add(this.TextBox_nome_RT820);
			this.GroupBox_descricao_RT820.Controls.Add(this.Label_comentarios);
			this.GroupBox_descricao_RT820.Controls.Add(this.Label_endereco);
			this.GroupBox_descricao_RT820.Controls.Add(this.Label_nome);
			global::System.Windows.Forms.Control groupBox_descricao_RT = this.GroupBox_descricao_RT820;
groupBox_descricao_RT.Location = new global::System.Drawing.Point(330, 179);
			this.GroupBox_descricao_RT820.Name = "GroupBox_descricao_RT820";
			global::System.Windows.Forms.Control groupBox_descricao_RT2 = this.GroupBox_descricao_RT820;
			Size = new System.Drawing.Size(507, 217);
			groupBox_descricao_RT2.Size = this.Size;
			this.GroupBox_descricao_RT820.TabIndex = 11;
			this.GroupBox_descricao_RT820.TabStop = false;
			this.GroupBox_descricao_RT820.Text = "Descrição";
			global::System.Windows.Forms.Control textBox_comentarios_RT = this.TextBox_comentarios_RT820;
textBox_comentarios_RT.Location = new global::System.Drawing.Point(26, 98);
			this.TextBox_comentarios_RT820.MaxLength = 400;
			this.TextBox_comentarios_RT820.Multiline = true;
			this.TextBox_comentarios_RT820.Name = "TextBox_comentarios_RT820";
			this.TextBox_comentarios_RT820.ScrollBars =(System.Windows.Forms.ScrollBars)2;
			global::System.Windows.Forms.Control textBox_comentarios_RT2 = this.TextBox_comentarios_RT820;
			Size = new System.Drawing.Size(454, 101);
			textBox_comentarios_RT2.Size = this.Size;
			this.TextBox_comentarios_RT820.TabIndex = 3;
			global::System.Windows.Forms.Control textBox_endereco_RT = this.TextBox_endereco_RT820;
textBox_endereco_RT.Location = new global::System.Drawing.Point(88, 53);
			this.TextBox_endereco_RT820.MaxLength = 60;
			this.TextBox_endereco_RT820.Name = "TextBox_endereco_RT820";
			global::System.Windows.Forms.Control textBox_endereco_RT2 = this.TextBox_endereco_RT820;
			Size = new System.Drawing.Size(392, 20);
			textBox_endereco_RT2.Size = this.Size;
			this.TextBox_endereco_RT820.TabIndex = 2;
			global::System.Windows.Forms.Control textBox_nome_RT = this.TextBox_nome_RT820;
textBox_nome_RT.Location = new global::System.Drawing.Point(88, 27);
			this.TextBox_nome_RT820.MaxLength = 60;
			this.TextBox_nome_RT820.Name = "TextBox_nome_RT820";
			global::System.Windows.Forms.Control textBox_nome_RT2 = this.TextBox_nome_RT820;
			Size = new System.Drawing.Size(392, 20);
			textBox_nome_RT2.Size = this.Size;
			this.TextBox_nome_RT820.TabIndex = 1;
			this.Label_comentarios.AutoSize = true;
			global::System.Windows.Forms.Control label_comentarios = this.Label_comentarios;
label_comentarios.Location = new global::System.Drawing.Point(23, 82);
			this.Label_comentarios.Name = "Label_comentarios";
			global::System.Windows.Forms.Control label_comentarios2 = this.Label_comentarios;
			Size = new System.Drawing.Size(71, 13);
			label_comentarios2.Size = this.Size;
			this.Label_comentarios.TabIndex = 0;
			this.Label_comentarios.Text = "Comentários :";
			this.Label_endereco.AutoSize = true;
			global::System.Windows.Forms.Control label_endereco = this.Label_endereco;
label_endereco.Location = new global::System.Drawing.Point(23, 58);
			this.Label_endereco.Name = "Label_endereco";
			global::System.Windows.Forms.Control label_endereco2 = this.Label_endereco;
			Size = new System.Drawing.Size(56, 13);
			label_endereco2.Size = this.Size;
			this.Label_endereco.TabIndex = 0;
			this.Label_endereco.Text = "Endereço:";
			this.Label_nome.AutoSize = true;
			global::System.Windows.Forms.Control label_nome = this.Label_nome;
label_nome.Location = new global::System.Drawing.Point(23, 33);
			this.Label_nome.Name = "Label_nome";
			global::System.Windows.Forms.Control label_nome2 = this.Label_nome;
			Size = new System.Drawing.Size(41, 13);
			label_nome2.Size = this.Size;
			this.Label_nome.TabIndex = 0;
			this.Label_nome.Text = "Nome :";
			this.GroupBox_informacoes_820.Controls.Add(this.Label48);
			this.GroupBox_informacoes_820.Controls.Add(this.TextBox_equipamento_820);
			this.GroupBox_informacoes_820.Controls.Add(this.Label49);
			this.GroupBox_informacoes_820.Controls.Add(this.TextBox_release_820);
			this.GroupBox_informacoes_820.Controls.Add(this.Label50);
			this.GroupBox_informacoes_820.Controls.Add(this.TextBox_build_820);
			this.GroupBox_informacoes_820.Controls.Add(this.Label51);
			this.GroupBox_informacoes_820.Controls.Add(this.TextBox_versao_820);
			this.GroupBox_informacoes_820.Controls.Add(this.Label52);
			this.GroupBox_informacoes_820.Enabled = false;
			global::System.Windows.Forms.Control groupBox_informacoes_ = this.GroupBox_informacoes_820;
groupBox_informacoes_.Location = new global::System.Drawing.Point(330, 10);
			this.GroupBox_informacoes_820.Name = "GroupBox_informacoes_820";
			global::System.Windows.Forms.Control groupBox_informacoes_2 = this.GroupBox_informacoes_820;
			Size = new System.Drawing.Size(507, 122);
			groupBox_informacoes_2.Size = this.Size;
			this.GroupBox_informacoes_820.TabIndex = 2;
			this.GroupBox_informacoes_820.TabStop = false;
			this.GroupBox_informacoes_820.Text = "Versão de Software";
			this.Label48.AutoSize = true;
			this.Label48.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control label = this.Label48;
label.Location = new global::System.Drawing.Point(133, 63);
			this.Label48.Name = "Label48";
			global::System.Windows.Forms.Control label2 = this.Label48;
			Size = new System.Drawing.Size(20, 15);
			label2.Size = this.Size;
			this.Label48.TabIndex = 26;
			this.Label48.Text = "RT";
			this.TextBox_equipamento_820.BackColor = global::System.Drawing.Color.LightCyan;
			this.TextBox_equipamento_820.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control textBox_equipamento_ = this.TextBox_equipamento_820;
textBox_equipamento_.Location = new global::System.Drawing.Point(168, 60);
			this.TextBox_equipamento_820.Name = "TextBox_equipamento_820";
			this.TextBox_equipamento_820.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_equipamento_2 = this.TextBox_equipamento_820;
			Size = new System.Drawing.Size(47, 20);
			textBox_equipamento_2.Size = this.Size;
			this.TextBox_equipamento_820.TabIndex = 25;
			this.TextBox_equipamento_820.TabStop = false;
			this.TextBox_equipamento_820.TextAlign = HorizontalAlignment.Right;
			this.Label49.AutoSize = true;
			global::System.Windows.Forms.Control label3 = this.Label49;
label3.Location = new global::System.Drawing.Point(133, 42);
			this.Label49.Name = "Label49";
			global::System.Windows.Forms.Control label4 = this.Label49;
			Size = new System.Drawing.Size(69, 13);
			label4.Size = this.Size;
			this.Label49.TabIndex = 24;
			this.Label49.Text = "Equipamento";
			this.TextBox_release_820.BackColor = global::System.Drawing.Color.LightCyan;
			this.TextBox_release_820.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control textBox_release_ = this.TextBox_release_820;
textBox_release_.Location = new global::System.Drawing.Point(324, 60);
			this.TextBox_release_820.Name = "TextBox_release_820";
			this.TextBox_release_820.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_release_2 = this.TextBox_release_820;
			Size = new System.Drawing.Size(47, 20);
			textBox_release_2.Size = this.Size;
			this.TextBox_release_820.TabIndex = 23;
			this.TextBox_release_820.TabStop = false;
			this.TextBox_release_820.TextAlign = HorizontalAlignment.Right;
			this.Label50.AutoSize = true;
			global::System.Windows.Forms.Control label5 = this.Label50;
label5.Location = new global::System.Drawing.Point(327, 42);
			this.Label50.Name = "Label50";
			global::System.Windows.Forms.Control label6 = this.Label50;
			Size = new System.Drawing.Size(46, 13);
			label6.Size = this.Size;
			this.Label50.TabIndex = 22;
			this.Label50.Text = "Release";
			this.TextBox_build_820.BackColor = global::System.Drawing.Color.LightCyan;
			this.TextBox_build_820.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control textBox_build_ = this.TextBox_build_820;
textBox_build_.Location = new global::System.Drawing.Point(272, 60);
			this.TextBox_build_820.Name = "TextBox_build_820";
			this.TextBox_build_820.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_build_2 = this.TextBox_build_820;
			Size = new System.Drawing.Size(47, 20);
			textBox_build_2.Size = this.Size;
			this.TextBox_build_820.TabIndex = 21;
			this.TextBox_build_820.TabStop = false;
			this.TextBox_build_820.TextAlign = HorizontalAlignment.Right;
			this.Label51.AutoSize = true;
			global::System.Windows.Forms.Control label7 = this.Label51;
label7.Location = new global::System.Drawing.Point(281, 42);
			this.Label51.Name = "Label51";
			global::System.Windows.Forms.Control label8 = this.Label51;
			Size = new System.Drawing.Size(30, 13);
			label8.Size = this.Size;
			this.Label51.TabIndex = 20;
			this.Label51.Text = "Build";
			this.TextBox_versao_820.BackColor = global::System.Drawing.Color.LightCyan;
			this.TextBox_versao_820.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control textBox_versao_ = this.TextBox_versao_820;
textBox_versao_.Location = new global::System.Drawing.Point(220, 60);
			this.TextBox_versao_820.Name = "TextBox_versao_820";
			this.TextBox_versao_820.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_versao_2 = this.TextBox_versao_820;
			Size = new System.Drawing.Size(47, 20);
			textBox_versao_2.Size = this.Size;
			this.TextBox_versao_820.TabIndex = 19;
			this.TextBox_versao_820.TabStop = false;
			this.TextBox_versao_820.TextAlign = HorizontalAlignment.Right;
			this.Label52.AutoSize = true;
			global::System.Windows.Forms.Control label9 = this.Label52;
label9.Location = new global::System.Drawing.Point(223, 42);
			this.Label52.Name = "Label52";
			global::System.Windows.Forms.Control label10 = this.Label52;
			Size = new System.Drawing.Size(40, 13);
			label10.Size = this.Size;
			this.Label52.TabIndex = 18;
			this.Label52.Text = "Versão";
			this.GroupBox_comunicacao_820.Controls.Add(this.NumericUpDown_temp_ptt_820);
			this.GroupBox_comunicacao_820.Controls.Add(this.Label_baudrate_COM2_820);
			this.GroupBox_comunicacao_820.Controls.Add(this.ComboBox_baudrate_COM2_820);
			this.GroupBox_comunicacao_820.Controls.Add(this.NumericUpDown_end_mestre_820);
			this.GroupBox_comunicacao_820.Controls.Add(this.NumericUpDown_end_est_820);
			this.GroupBox_comunicacao_820.Controls.Add(this.Label_tempo_ptt_820);
			this.GroupBox_comunicacao_820.Controls.Add(this.Label_end_mestre_820);
			this.GroupBox_comunicacao_820.Controls.Add(this.Label_end_est_820);
			this.GroupBox_comunicacao_820.Controls.Add(this.tb_lixo1);
			this.GroupBox_comunicacao_820.Enabled = false;
			global::System.Windows.Forms.Control groupBox_comunicacao_ = this.GroupBox_comunicacao_820;
groupBox_comunicacao_.Location = new global::System.Drawing.Point(20, 10);
			this.GroupBox_comunicacao_820.Name = "GroupBox_comunicacao_820";
			global::System.Windows.Forms.Control groupBox_comunicacao_2 = this.GroupBox_comunicacao_820;
			Size = new System.Drawing.Size(291, 149);
			groupBox_comunicacao_2.Size = this.Size;
			this.GroupBox_comunicacao_820.TabIndex = 1;
			this.GroupBox_comunicacao_820.TabStop = false;
			this.GroupBox_comunicacao_820.Text = "Parâmetros de Comunicação";
			global::System.Windows.Forms.NumericUpDown numericUpDown_temp_ptt_ = this.NumericUpDown_temp_ptt_820;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			numericUpDown_temp_ptt_.Increment = num;
			global::System.Windows.Forms.Control numericUpDown_temp_ptt_2 = this.NumericUpDown_temp_ptt_820;
numericUpDown_temp_ptt_2.Location = new global::System.Drawing.Point(204, 80);
			global::System.Windows.Forms.NumericUpDown numericUpDown_temp_ptt_3 = this.NumericUpDown_temp_ptt_820;
			num = new decimal(new int[]
			{
				70000,
				0,
				0,
				0
			});
			numericUpDown_temp_ptt_3.Maximum = num;
			global::System.Windows.Forms.NumericUpDown numericUpDown_temp_ptt_4 = this.NumericUpDown_temp_ptt_820;
			num = new decimal(new int[]
			{
				100,
				0,
				0,
				0
			});
			numericUpDown_temp_ptt_4.Minimum = num;
			this.NumericUpDown_temp_ptt_820.Name = "NumericUpDown_temp_ptt_820";
			global::System.Windows.Forms.Control numericUpDown_temp_ptt_5 = this.NumericUpDown_temp_ptt_820;
			Size = new System.Drawing.Size(72, 20);
			numericUpDown_temp_ptt_5.Size = this.Size;
			this.NumericUpDown_temp_ptt_820.TabIndex = 2;
			this.NumericUpDown_temp_ptt_820.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.NumericUpDown numericUpDown_temp_ptt_6 = this.NumericUpDown_temp_ptt_820;
			num = new decimal(new int[]
			{
				100,
				0,
				0,
				0
			});
			numericUpDown_temp_ptt_6.Value = num;
			this.Label_baudrate_COM2_820.AutoSize = true;
			global::System.Windows.Forms.Control label_baudrate_COM2_ = this.Label_baudrate_COM2_820;
label_baudrate_COM2_.Location = new global::System.Drawing.Point(21, 114);
			this.Label_baudrate_COM2_820.Name = "Label_baudrate_COM2_820";
			global::System.Windows.Forms.Control label_baudrate_COM2_2 = this.Label_baudrate_COM2_820;
			Size = new System.Drawing.Size(89, 13);
			label_baudrate_COM2_2.Size = this.Size;
			this.Label_baudrate_COM2_820.TabIndex = 3;
			this.Label_baudrate_COM2_820.Text = "Baudrate COM2 :";
			this.ComboBox_baudrate_COM2_820.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox_baudrate_COM2_ = this.ComboBox_baudrate_COM2_820;
comboBox_baudrate_COM2_.Location = new global::System.Drawing.Point(132, 111);
			this.ComboBox_baudrate_COM2_820.Name = "ComboBox_baudrate_COM2_820";
			global::System.Windows.Forms.Control comboBox_baudrate_COM2_2 = this.ComboBox_baudrate_COM2_820;
			Size = new System.Drawing.Size(144, 21);
			comboBox_baudrate_COM2_2.Size = this.Size;
			this.ComboBox_baudrate_COM2_820.TabIndex = 6;
			global::System.Windows.Forms.Control numericUpDown_end_mestre_ = this.NumericUpDown_end_mestre_820;
numericUpDown_end_mestre_.Location = new global::System.Drawing.Point(204, 28);
			global::System.Windows.Forms.NumericUpDown numericUpDown_end_mestre_2 = this.NumericUpDown_end_mestre_820;
			num = new decimal(new int[]
			{
				70000,
				0,
				0,
				0
			});
			numericUpDown_end_mestre_2.Maximum = num;
			this.NumericUpDown_end_mestre_820.Name = "NumericUpDown_end_mestre_820";
			global::System.Windows.Forms.Control numericUpDown_end_mestre_3 = this.NumericUpDown_end_mestre_820;
			Size = new System.Drawing.Size(72, 20);
			numericUpDown_end_mestre_3.Size = this.Size;
			this.NumericUpDown_end_mestre_820.TabIndex = 0;
			this.NumericUpDown_end_mestre_820.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.Control numericUpDown_end_est_ = this.NumericUpDown_end_est_820;
numericUpDown_end_est_.Location = new global::System.Drawing.Point(204, 54);
			global::System.Windows.Forms.NumericUpDown numericUpDown_end_est_2 = this.NumericUpDown_end_est_820;
			num = new decimal(new int[]
			{
				70000,
				0,
				0,
				0
			});
			numericUpDown_end_est_2.Maximum = num;
			this.NumericUpDown_end_est_820.Name = "NumericUpDown_end_est_820";
			global::System.Windows.Forms.Control numericUpDown_end_est_3 = this.NumericUpDown_end_est_820;
			Size = new System.Drawing.Size(72, 20);
			numericUpDown_end_est_3.Size = this.Size;
			this.NumericUpDown_end_est_820.TabIndex = 1;
			this.NumericUpDown_end_est_820.TextAlign = HorizontalAlignment.Right;
			this.Label_tempo_ptt_820.AutoSize = true;
			global::System.Windows.Forms.Control label_tempo_ptt_ = this.Label_tempo_ptt_820;
label_tempo_ptt_.Location = new global::System.Drawing.Point(21, 82);
			this.Label_tempo_ptt_820.Name = "Label_tempo_ptt_820";
			global::System.Windows.Forms.Control label_tempo_ptt_2 = this.Label_tempo_ptt_820;
			Size = new System.Drawing.Size(154, 13);
			label_tempo_ptt_2.Size = this.Size;
			this.Label_tempo_ptt_820.TabIndex = 5;
			this.Label_tempo_ptt_820.Text = "Tempo de espera de PTT (ms):";
			this.Label_end_mestre_820.AutoSize = true;
			global::System.Windows.Forms.Control label_end_mestre_ = this.Label_end_mestre_820;
label_end_mestre_.Location = new global::System.Drawing.Point(21, 28);
			this.Label_end_mestre_820.Name = "Label_end_mestre_820";
			global::System.Windows.Forms.Control label_end_mestre_2 = this.Label_end_mestre_820;
			Size = new System.Drawing.Size(109, 13);
			label_end_mestre_2.Size = this.Size;
			this.Label_end_mestre_820.TabIndex = 3;
			this.Label_end_mestre_820.Text = "Endereço do Mestre :";
			this.Label_end_est_820.AutoSize = true;
			global::System.Windows.Forms.Control label_end_est_ = this.Label_end_est_820;
label_end_est_.Location = new global::System.Drawing.Point(21, 55);
			this.Label_end_est_820.Name = "Label_end_est_820";
			global::System.Windows.Forms.Control label_end_est_2 = this.Label_end_est_820;
			Size = new System.Drawing.Size(116, 13);
			label_end_est_2.Size = this.Size;
			this.Label_end_est_820.TabIndex = 4;
			this.Label_end_est_820.Text = "Endereço da Estação :";
			global::System.Windows.Forms.Control tb_lixo = this.tb_lixo1;
tb_lixo.Location = new global::System.Drawing.Point(204, 28);
			this.tb_lixo1.Name = "tb_lixo1";
			global::System.Windows.Forms.Control tb_lixo2 = this.tb_lixo1;
			Size = new System.Drawing.Size(41, 20);
			tb_lixo2.Size = this.Size;
			this.tb_lixo1.TabIndex = 7;
			this.TabPage_EA.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.TabPage_EA.Controls.Add(this.GroupBox_EA_820);
			global::System.Windows.Forms.TabPage tabPage_EA = this.TabPage_EA;
tabPage_EA.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_EA.Name = "TabPage_EA";
			global::System.Windows.Forms.Control tabPage_EA2 = this.TabPage_EA;
			Size = new System.Drawing.Size(1294, 443);
			tabPage_EA2.Size = this.Size;
			this.TabPage_EA.TabIndex = 6;
			this.TabPage_EA.Text = "Entradas Analógicas";
			this.TabPage_EA.UseVisualStyleBackColor = true;
			this.GroupBox_EA_820.Controls.Add(this.NumericUpDown_intervalo_filtro_820);
			this.GroupBox_EA_820.Controls.Add(this.NumericUpDown_tamanho_filtro_820);
			this.GroupBox_EA_820.Controls.Add(this.Label_intervalo_filtro_820);
			this.GroupBox_EA_820.Controls.Add(this.Label_tamanho_filtro_820);
			this.GroupBox_EA_820.Controls.Add(this.tb_lixo2);
			this.GroupBox_EA_820.Enabled = false;
			global::System.Windows.Forms.Control groupBox_EA_ = this.GroupBox_EA_820;
groupBox_EA_.Location = new global::System.Drawing.Point(13, 12);
			this.GroupBox_EA_820.Name = "GroupBox_EA_820";
			global::System.Windows.Forms.Control groupBox_EA_2 = this.GroupBox_EA_820;
			Size = new System.Drawing.Size(216, 93);
			groupBox_EA_2.Size = this.Size;
			this.GroupBox_EA_820.TabIndex = 4;
			this.GroupBox_EA_820.TabStop = false;
			this.GroupBox_EA_820.Text = "Filtro";
			global::System.Windows.Forms.NumericUpDown numericUpDown_intervalo_filtro_ = this.NumericUpDown_intervalo_filtro_820;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			numericUpDown_intervalo_filtro_.Increment = num;
			global::System.Windows.Forms.Control numericUpDown_intervalo_filtro_2 = this.NumericUpDown_intervalo_filtro_820;
numericUpDown_intervalo_filtro_2.Location = new global::System.Drawing.Point(115, 29);
			global::System.Windows.Forms.NumericUpDown numericUpDown_intervalo_filtro_3 = this.NumericUpDown_intervalo_filtro_820;
			num = new decimal(new int[]
			{
				100000,
				0,
				0,
				0
			});
			numericUpDown_intervalo_filtro_3.Maximum = num;
			this.NumericUpDown_intervalo_filtro_820.Name = "NumericUpDown_intervalo_filtro_820";
			global::System.Windows.Forms.Control numericUpDown_intervalo_filtro_4 = this.NumericUpDown_intervalo_filtro_820;
			Size = new System.Drawing.Size(74, 20);
			numericUpDown_intervalo_filtro_4.Size = this.Size;
			this.NumericUpDown_intervalo_filtro_820.TabIndex = 18;
			this.NumericUpDown_intervalo_filtro_820.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control numericUpDown_tamanho_filtro_ = this.NumericUpDown_tamanho_filtro_820;
numericUpDown_tamanho_filtro_.Location = new global::System.Drawing.Point(115, 53);
			global::System.Windows.Forms.NumericUpDown numericUpDown_tamanho_filtro_2 = this.NumericUpDown_tamanho_filtro_820;
			num = new decimal(new int[]
			{
				70000,
				0,
				0,
				0
			});
			numericUpDown_tamanho_filtro_2.Maximum = num;
			this.NumericUpDown_tamanho_filtro_820.Name = "NumericUpDown_tamanho_filtro_820";
			global::System.Windows.Forms.Control numericUpDown_tamanho_filtro_3 = this.NumericUpDown_tamanho_filtro_820;
			Size = new System.Drawing.Size(74, 20);
			numericUpDown_tamanho_filtro_3.Size = this.Size;
			this.NumericUpDown_tamanho_filtro_820.TabIndex = 1;
			this.NumericUpDown_tamanho_filtro_820.TextAlign = HorizontalAlignment.Center;
			this.Label_intervalo_filtro_820.AutoSize = true;
			global::System.Windows.Forms.Control label_intervalo_filtro_ = this.Label_intervalo_filtro_820;
label_intervalo_filtro_.Location = new global::System.Drawing.Point(16, 29);
			this.Label_intervalo_filtro_820.Name = "Label_intervalo_filtro_820";
			global::System.Windows.Forms.Control label_intervalo_filtro_2 = this.Label_intervalo_filtro_820;
			Size = new System.Drawing.Size(76, 13);
			label_intervalo_filtro_2.Size = this.Size;
			this.Label_intervalo_filtro_820.TabIndex = 14;
			this.Label_intervalo_filtro_820.Text = "Intervalo (ms) :";
			this.Label_tamanho_filtro_820.AutoSize = true;
			global::System.Windows.Forms.Control label_tamanho_filtro_ = this.Label_tamanho_filtro_820;
label_tamanho_filtro_.Location = new global::System.Drawing.Point(16, 55);
			this.Label_tamanho_filtro_820.Name = "Label_tamanho_filtro_820";
			global::System.Windows.Forms.Control label_tamanho_filtro_2 = this.Label_tamanho_filtro_820;
			Size = new System.Drawing.Size(56, 13);
			label_tamanho_filtro_2.Size = this.Size;
			this.Label_tamanho_filtro_820.TabIndex = 16;
			this.Label_tamanho_filtro_820.Text = "Amostras :";
			global::System.Windows.Forms.Control tb_lixo3 = this.tb_lixo2;
tb_lixo3.Location = new global::System.Drawing.Point(115, 29);
			this.tb_lixo2.Name = "tb_lixo2";
			global::System.Windows.Forms.Control tb_lixo4 = this.tb_lixo2;
			Size = new System.Drawing.Size(41, 20);
			tb_lixo4.Size = this.Size;
			this.tb_lixo2.TabIndex = 19;
			this.TabPage_controle.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.TabPage_controle.Controls.Add(this.GroupBox2);
			global::System.Windows.Forms.TabPage tabPage_controle = this.TabPage_controle;
tabPage_controle.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_controle.Name = "TabPage_controle";
			global::System.Windows.Forms.Control tabPage_controle2 = this.TabPage_controle;
			Padding = new Padding(3);
			tabPage_controle2.Padding = Padding;
			global::System.Windows.Forms.Control tabPage_controle3 = this.TabPage_controle;
			Size = new System.Drawing.Size(1294, 443);
			tabPage_controle3.Size = this.Size;
			this.TabPage_controle.TabIndex = 7;
			this.TabPage_controle.Text = "Variávies de Controles";
			this.TabPage_controle.UseVisualStyleBackColor = true;
			this.GroupBox2.Controls.Add(this.cb_Controle);
			this.GroupBox2.Controls.Add(this.cb_Protecao);
			this.GroupBox2.Controls.Add(this.Label18);
			this.GroupBox2.Controls.Add(this.Label1);
			this.GroupBox2.Controls.Add(this.checkbox_habilita_controle);
			this.GroupBox2.Controls.Add(this.tb_lixo3);
			global::System.Windows.Forms.Control groupBox = this.GroupBox2;
groupBox.Location = new global::System.Drawing.Point(16, 16);
			this.GroupBox2.Name = "GroupBox2";
			global::System.Windows.Forms.Control groupBox2 = this.GroupBox2;
			Size = new System.Drawing.Size(286, 144);
			groupBox2.Size = this.Size;
			this.GroupBox2.TabIndex = 0;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Variáveis de Controle";
			this.cb_Controle.FormattingEnabled = true;
			global::System.Windows.Forms.Control cb_Controle = this.cb_Controle;
cb_Controle.Location = new global::System.Drawing.Point(86, 108);
			this.cb_Controle.Name = "cb_Controle";
			global::System.Windows.Forms.Control cb_Controle2 = this.cb_Controle;
			Size = new System.Drawing.Size(176, 21);
			cb_Controle2.Size = this.Size;
			this.cb_Controle.TabIndex = 4;
			this.cb_Protecao.FormattingEnabled = true;
			global::System.Windows.Forms.Control cb_Protecao = this.cb_Protecao;
cb_Protecao.Location = new global::System.Drawing.Point(86, 70);
			this.cb_Protecao.Name = "cb_Protecao";
			global::System.Windows.Forms.Control cb_Protecao2 = this.cb_Protecao;
			Size = new System.Drawing.Size(176, 21);
			cb_Protecao2.Size = this.Size;
			this.cb_Protecao.TabIndex = 3;
			this.Label18.AutoSize = true;
			global::System.Windows.Forms.Control label11 = this.Label18;
label11.Location = new global::System.Drawing.Point(14, 111);
			this.Label18.Name = "Label18";
			global::System.Windows.Forms.Control label12 = this.Label18;
			Size = new System.Drawing.Size(46, 13);
			label12.Size = this.Size;
			this.Label18.TabIndex = 2;
			this.Label18.Text = "Controle";
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label13 = this.Label1;
label13.Location = new global::System.Drawing.Point(14, 73);
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label14 = this.Label1;
			Size = new System.Drawing.Size(50, 13);
			label14.Size = this.Size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Proteção";
			this.checkbox_habilita_controle.AutoSize = true;
			global::System.Windows.Forms.Control checkbox_habilita_controle = this.checkbox_habilita_controle;
checkbox_habilita_controle.Location = new global::System.Drawing.Point(17, 30);
			this.checkbox_habilita_controle.Name = "checkbox_habilita_controle";
			global::System.Windows.Forms.Control checkbox_habilita_controle2 = this.checkbox_habilita_controle;
			Size = new System.Drawing.Size(156, 17);
			checkbox_habilita_controle2.Size = this.Size;
			this.checkbox_habilita_controle.TabIndex = 0;
			this.checkbox_habilita_controle.Text = "Habilita controle nível fonte";
			this.checkbox_habilita_controle.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control tb_lixo5 = this.tb_lixo3;
tb_lixo5.Location = new global::System.Drawing.Point(86, 70);
			this.tb_lixo3.Name = "tb_lixo3";
			global::System.Windows.Forms.Control tb_lixo6 = this.tb_lixo3;
			Size = new System.Drawing.Size(41, 20);
			tb_lixo6.Size = this.Size;
			this.tb_lixo3.TabIndex = 8;
			this.TabPage_ED.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.TabPage_ED.Controls.Add(this.GroupBox_ED_820);
			global::System.Windows.Forms.TabPage tabPage_ED = this.TabPage_ED;
tabPage_ED.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_ED.Name = "TabPage_ED";
			global::System.Windows.Forms.Control tabPage_ED2 = this.TabPage_ED;
			Size = new System.Drawing.Size(1294, 443);
			tabPage_ED2.Size = this.Size;
			this.TabPage_ED.TabIndex = 4;
			this.TabPage_ED.Text = "Entradas Digitais";
			this.TabPage_ED.UseVisualStyleBackColor = true;
			this.GroupBox_ED_820.Controls.Add(this.DataGridView_RT820_ED);
			global::System.Windows.Forms.Control groupBox_ED_ = this.GroupBox_ED_820;
groupBox_ED_.Location = new global::System.Drawing.Point(18, 15);
			this.GroupBox_ED_820.Name = "GroupBox_ED_820";
			global::System.Windows.Forms.Control groupBox_ED_2 = this.GroupBox_ED_820;
			Size = new System.Drawing.Size(364, 237);
			groupBox_ED_2.Size = this.Size;
			this.GroupBox_ED_820.TabIndex = 0;
			this.GroupBox_ED_820.TabStop = false;
			this.GroupBox_ED_820.Text = "Entradas Digitais";
			this.DataGridView_RT820_ED.AllowUserToAddRows = false;
			this.DataGridView_RT820_ED.AllowUserToDeleteRows = false;
			this.DataGridView_RT820_ED.AllowUserToOrderColumns = true;
			this.DataGridView_RT820_ED.AllowUserToResizeColumns = false;
			this.DataGridView_RT820_ED.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			this.DataGridView_RT820_ED.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			dataGridViewCellStyle2.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView_RT820_ED.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DataGridView_RT820_ED.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			dataGridViewCellStyle3.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView_RT820_ED.DefaultCellStyle = dataGridViewCellStyle3;
			global::System.Windows.Forms.Control dataGridView_RT820_ED = this.DataGridView_RT820_ED;
dataGridView_RT820_ED.Location = new global::System.Drawing.Point(15, 19);
			this.DataGridView_RT820_ED.Name = "DataGridView_RT820_ED";
			dataGridViewCellStyle4.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
			dataGridViewCellStyle4.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView_RT820_ED.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.DataGridView_RT820_ED.ScrollBars =(System.Windows.Forms.ScrollBars)0;
			global::System.Windows.Forms.Control dataGridView_RT820_ED2 = this.DataGridView_RT820_ED;
			Size = new System.Drawing.Size(332, 198);
			dataGridView_RT820_ED2.Size = this.Size;
			this.DataGridView_RT820_ED.TabIndex = 16;
			this.TabPage_setpoints.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.TabPage_setpoints.Controls.Add(this.GroupBox7);
			this.TabPage_setpoints.Controls.Add(this.GroupBox3);
			global::System.Windows.Forms.TabPage tabPage_setpoints = this.TabPage_setpoints;
tabPage_setpoints.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_setpoints.Name = "TabPage_setpoints";
			global::System.Windows.Forms.Control tabPage_setpoints2 = this.TabPage_setpoints;
			Size = new System.Drawing.Size(1294, 443);
			tabPage_setpoints2.Size = this.Size;
			this.TabPage_setpoints.TabIndex = 2;
			this.TabPage_setpoints.Text = "Setpoints";
			this.TabPage_setpoints.UseVisualStyleBackColor = true;
			this.GroupBox7.Controls.Add(this.Label73);
			this.GroupBox7.Controls.Add(this.sph_baixo41);
			this.GroupBox7.Controls.Add(this.sph_alto41);
			this.GroupBox7.Controls.Add(this.sph_minuto41);
			this.GroupBox7.Controls.Add(this.sph_ativa41);
			this.GroupBox7.Controls.Add(this.sph_hora41);
			this.GroupBox7.Controls.Add(this.sph_baixo40);
			this.GroupBox7.Controls.Add(this.sph_alto40);
			this.GroupBox7.Controls.Add(this.sph_minuto40);
			this.GroupBox7.Controls.Add(this.sph_ativa40);
			this.GroupBox7.Controls.Add(this.sph_hora40);
			this.GroupBox7.Controls.Add(this.Label72);
			this.GroupBox7.Controls.Add(this.sph_baixo31);
			this.GroupBox7.Controls.Add(this.sph_alto31);
			this.GroupBox7.Controls.Add(this.sph_minuto31);
			this.GroupBox7.Controls.Add(this.sph_ativa31);
			this.GroupBox7.Controls.Add(this.sph_hora31);
			this.GroupBox7.Controls.Add(this.sph_baixo30);
			this.GroupBox7.Controls.Add(this.sph_alto30);
			this.GroupBox7.Controls.Add(this.sph_minuto30);
			this.GroupBox7.Controls.Add(this.sph_ativa30);
			this.GroupBox7.Controls.Add(this.sph_hora30);
			this.GroupBox7.Controls.Add(this.Label67);
			this.GroupBox7.Controls.Add(this.sph_baixo21);
			this.GroupBox7.Controls.Add(this.sph_alto21);
			this.GroupBox7.Controls.Add(this.sph_minuto21);
			this.GroupBox7.Controls.Add(this.sph_ativa21);
			this.GroupBox7.Controls.Add(this.sph_hora21);
			this.GroupBox7.Controls.Add(this.sph_baixo20);
			this.GroupBox7.Controls.Add(this.sph_alto20);
			this.GroupBox7.Controls.Add(this.sph_minuto20);
			this.GroupBox7.Controls.Add(this.sph_ativa20);
			this.GroupBox7.Controls.Add(this.sph_hora20);
			this.GroupBox7.Controls.Add(this.Label62);
			this.GroupBox7.Controls.Add(this.sph_baixo11);
			this.GroupBox7.Controls.Add(this.sph_alto11);
			this.GroupBox7.Controls.Add(this.sph_minuto11);
			this.GroupBox7.Controls.Add(this.sph_ativa11);
			this.GroupBox7.Controls.Add(this.sph_hora11);
			this.GroupBox7.Controls.Add(this.Label57);
			this.GroupBox7.Controls.Add(this.Label56);
			this.GroupBox7.Controls.Add(this.sph_baixo10);
			this.GroupBox7.Controls.Add(this.sph_alto10);
			this.GroupBox7.Controls.Add(this.sph_minuto10);
			this.GroupBox7.Controls.Add(this.sph_ativa10);
			this.GroupBox7.Controls.Add(this.Label55);
			this.GroupBox7.Controls.Add(this.Label54);
			this.GroupBox7.Controls.Add(this.sph_hora10);
			this.GroupBox7.Controls.Add(this.Label53);
			global::System.Windows.Forms.Control groupBox3 = this.GroupBox7;
groupBox3.Location = new global::System.Drawing.Point(330, 15);
			this.GroupBox7.Name = "GroupBox7";
			global::System.Windows.Forms.Control groupBox4 = this.GroupBox7;
			Size = new System.Drawing.Size(453, 299);
			groupBox4.Size = this.Size;
			this.GroupBox7.TabIndex = 3;
			this.GroupBox7.TabStop = false;
			this.GroupBox7.Text = "Setpoint por faixa de horário";
			this.Label73.AutoSize = true;
			this.Label73.ForeColor = global::System.Drawing.Color.Red;
			global::System.Windows.Forms.Control label15 = this.Label73;
label15.Location = new global::System.Drawing.Point(29, 274);
			this.Label73.Name = "Label73";
			global::System.Windows.Forms.Control label16 = this.Label73;
			Size = new System.Drawing.Size(394, 13);
			label16.Size = this.Size;
			this.Label73.TabIndex = 62;
			this.Label73.Text = "Observação: Funcionalidade disponível somente a partir da versão RT 820 / 2.30";
			global::System.Windows.Forms.Control sph_baixo = this.sph_baixo41;
sph_baixo.Location = new global::System.Drawing.Point(369, 231);
			this.sph_baixo41.Name = "sph_baixo41";
			global::System.Windows.Forms.Control sph_baixo2 = this.sph_baixo41;
			Size = new System.Drawing.Size(67, 20);
			sph_baixo2.Size = this.Size;
			this.sph_baixo41.TabIndex = 61;
			this.sph_baixo41.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_alto = this.sph_alto41;
sph_alto.Location = new global::System.Drawing.Point(292, 231);
			this.sph_alto41.Name = "sph_alto41";
			global::System.Windows.Forms.Control sph_alto2 = this.sph_alto41;
			Size = new System.Drawing.Size(67, 20);
			sph_alto2.Size = this.Size;
			this.sph_alto41.TabIndex = 60;
			this.sph_alto41.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_minuto = this.sph_minuto41;
sph_minuto.Location = new global::System.Drawing.Point(229, 231);
			this.sph_minuto41.Name = "sph_minuto41";
			global::System.Windows.Forms.Control sph_minuto2 = this.sph_minuto41;
			Size = new System.Drawing.Size(57, 20);
			sph_minuto2.Size = this.Size;
			this.sph_minuto41.TabIndex = 59;
			this.sph_minuto41.TextAlign = HorizontalAlignment.Center;
			this.sph_ativa41.AutoSize = true;
			global::System.Windows.Forms.Control sph_ativa = this.sph_ativa41;
sph_ativa.Location = new global::System.Drawing.Point(110, 234);
			this.sph_ativa41.Name = "sph_ativa41";
			global::System.Windows.Forms.Control sph_ativa2 = this.sph_ativa41;
			Size = new System.Drawing.Size(50, 17);
			sph_ativa2.Size = this.Size;
			this.sph_ativa41.TabIndex = 58;
			this.sph_ativa41.Text = "Ativa";
			this.sph_ativa41.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control sph_hora = this.sph_hora41;
sph_hora.Location = new global::System.Drawing.Point(166, 231);
			this.sph_hora41.Name = "sph_hora41";
			global::System.Windows.Forms.Control sph_hora2 = this.sph_hora41;
			Size = new System.Drawing.Size(57, 20);
			sph_hora2.Size = this.Size;
			this.sph_hora41.TabIndex = 57;
			this.sph_hora41.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_baixo3 = this.sph_baixo40;
sph_baixo3.Location = new global::System.Drawing.Point(369, 205);
			this.sph_baixo40.Name = "sph_baixo40";
			global::System.Windows.Forms.Control sph_baixo4 = this.sph_baixo40;
			Size = new System.Drawing.Size(67, 20);
			sph_baixo4.Size = this.Size;
			this.sph_baixo40.TabIndex = 54;
			this.sph_baixo40.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_alto3 = this.sph_alto40;
sph_alto3.Location = new global::System.Drawing.Point(292, 205);
			this.sph_alto40.Name = "sph_alto40";
			global::System.Windows.Forms.Control sph_alto4 = this.sph_alto40;
			Size = new System.Drawing.Size(67, 20);
			sph_alto4.Size = this.Size;
			this.sph_alto40.TabIndex = 53;
			this.sph_alto40.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_minuto3 = this.sph_minuto40;
sph_minuto3.Location = new global::System.Drawing.Point(229, 205);
			this.sph_minuto40.Name = "sph_minuto40";
			global::System.Windows.Forms.Control sph_minuto4 = this.sph_minuto40;
			Size = new System.Drawing.Size(57, 20);
			sph_minuto4.Size = this.Size;
			this.sph_minuto40.TabIndex = 52;
			this.sph_minuto40.TextAlign = HorizontalAlignment.Center;
			this.sph_ativa40.AutoSize = true;
			global::System.Windows.Forms.Control sph_ativa3 = this.sph_ativa40;
sph_ativa3.Location = new global::System.Drawing.Point(110, 208);
			this.sph_ativa40.Name = "sph_ativa40";
			global::System.Windows.Forms.Control sph_ativa4 = this.sph_ativa40;
			Size = new System.Drawing.Size(50, 17);
			sph_ativa4.Size = this.Size;
			this.sph_ativa40.TabIndex = 51;
			this.sph_ativa40.Text = "Ativa";
			this.sph_ativa40.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control sph_hora3 = this.sph_hora40;
sph_hora3.Location = new global::System.Drawing.Point(166, 205);
			this.sph_hora40.Name = "sph_hora40";
			global::System.Windows.Forms.Control sph_hora4 = this.sph_hora40;
			Size = new System.Drawing.Size(57, 20);
			sph_hora4.Size = this.Size;
			this.sph_hora40.TabIndex = 48;
			this.sph_hora40.TextAlign = HorizontalAlignment.Center;
			this.Label72.AutoSize = true;
			global::System.Windows.Forms.Control label17 = this.Label72;
label17.Location = new global::System.Drawing.Point(29, 207);
			this.Label72.Name = "Label72";
			global::System.Windows.Forms.Control label18 = this.Label72;
			Size = new System.Drawing.Size(55, 13);
			label18.Size = this.Size;
			this.Label72.TabIndex = 47;
			this.Label72.Text = "Controle4:";
			global::System.Windows.Forms.Control sph_baixo5 = this.sph_baixo31;
sph_baixo5.Location = new global::System.Drawing.Point(369, 179);
			this.sph_baixo31.Name = "sph_baixo31";
			global::System.Windows.Forms.Control sph_baixo6 = this.sph_baixo31;
			Size = new System.Drawing.Size(67, 20);
			sph_baixo6.Size = this.Size;
			this.sph_baixo31.TabIndex = 46;
			this.sph_baixo31.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_alto5 = this.sph_alto31;
sph_alto5.Location = new global::System.Drawing.Point(292, 179);
			this.sph_alto31.Name = "sph_alto31";
			global::System.Windows.Forms.Control sph_alto6 = this.sph_alto31;
			Size = new System.Drawing.Size(67, 20);
			sph_alto6.Size = this.Size;
			this.sph_alto31.TabIndex = 45;
			this.sph_alto31.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_minuto5 = this.sph_minuto31;
sph_minuto5.Location = new global::System.Drawing.Point(229, 179);
			this.sph_minuto31.Name = "sph_minuto31";
			global::System.Windows.Forms.Control sph_minuto6 = this.sph_minuto31;
			Size = new System.Drawing.Size(57, 20);
			sph_minuto6.Size = this.Size;
			this.sph_minuto31.TabIndex = 44;
			this.sph_minuto31.TextAlign = HorizontalAlignment.Center;
			this.sph_ativa31.AutoSize = true;
			global::System.Windows.Forms.Control sph_ativa5 = this.sph_ativa31;
sph_ativa5.Location = new global::System.Drawing.Point(110, 182);
			this.sph_ativa31.Name = "sph_ativa31";
			global::System.Windows.Forms.Control sph_ativa6 = this.sph_ativa31;
			Size = new System.Drawing.Size(50, 17);
			sph_ativa6.Size = this.Size;
			this.sph_ativa31.TabIndex = 43;
			this.sph_ativa31.Text = "Ativa";
			this.sph_ativa31.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control sph_hora5 = this.sph_hora31;
sph_hora5.Location = new global::System.Drawing.Point(166, 179);
			this.sph_hora31.Name = "sph_hora31";
			global::System.Windows.Forms.Control sph_hora6 = this.sph_hora31;
			Size = new System.Drawing.Size(57, 20);
			sph_hora6.Size = this.Size;
			this.sph_hora31.TabIndex = 42;
			this.sph_hora31.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_baixo7 = this.sph_baixo30;
sph_baixo7.Location = new global::System.Drawing.Point(369, 153);
			this.sph_baixo30.Name = "sph_baixo30";
			global::System.Windows.Forms.Control sph_baixo8 = this.sph_baixo30;
			Size = new System.Drawing.Size(67, 20);
			sph_baixo8.Size = this.Size;
			this.sph_baixo30.TabIndex = 39;
			this.sph_baixo30.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_alto7 = this.sph_alto30;
sph_alto7.Location = new global::System.Drawing.Point(292, 153);
			this.sph_alto30.Name = "sph_alto30";
			global::System.Windows.Forms.Control sph_alto8 = this.sph_alto30;
			Size = new System.Drawing.Size(67, 20);
			sph_alto8.Size = this.Size;
			this.sph_alto30.TabIndex = 38;
			this.sph_alto30.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_minuto7 = this.sph_minuto30;
sph_minuto7.Location = new global::System.Drawing.Point(229, 153);
			this.sph_minuto30.Name = "sph_minuto30";
			global::System.Windows.Forms.Control sph_minuto8 = this.sph_minuto30;
			Size = new System.Drawing.Size(57, 20);
			sph_minuto8.Size = this.Size;
			this.sph_minuto30.TabIndex = 37;
			this.sph_minuto30.TextAlign = HorizontalAlignment.Center;
			this.sph_ativa30.AutoSize = true;
			global::System.Windows.Forms.Control sph_ativa7 = this.sph_ativa30;
sph_ativa7.Location = new global::System.Drawing.Point(110, 156);
			this.sph_ativa30.Name = "sph_ativa30";
			global::System.Windows.Forms.Control sph_ativa8 = this.sph_ativa30;
			Size = new System.Drawing.Size(50, 17);
			sph_ativa8.Size = this.Size;
			this.sph_ativa30.TabIndex = 36;
			this.sph_ativa30.Text = "Ativa";
			this.sph_ativa30.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control sph_hora7 = this.sph_hora30;
sph_hora7.Location = new global::System.Drawing.Point(166, 153);
			this.sph_hora30.Name = "sph_hora30";
			global::System.Windows.Forms.Control sph_hora8 = this.sph_hora30;
			Size = new System.Drawing.Size(57, 20);
			sph_hora8.Size = this.Size;
			this.sph_hora30.TabIndex = 33;
			this.sph_hora30.TextAlign = HorizontalAlignment.Center;
			this.Label67.AutoSize = true;
			global::System.Windows.Forms.Control label19 = this.Label67;
label19.Location = new global::System.Drawing.Point(29, 155);
			this.Label67.Name = "Label67";
			global::System.Windows.Forms.Control label20 = this.Label67;
			Size = new System.Drawing.Size(55, 13);
			label20.Size = this.Size;
			this.Label67.TabIndex = 32;
			this.Label67.Text = "Controle3:";
			global::System.Windows.Forms.Control sph_baixo9 = this.sph_baixo21;
sph_baixo9.Location = new global::System.Drawing.Point(369, 127);
			this.sph_baixo21.Name = "sph_baixo21";
			global::System.Windows.Forms.Control sph_baixo10 = this.sph_baixo21;
			Size = new System.Drawing.Size(67, 20);
			sph_baixo10.Size = this.Size;
			this.sph_baixo21.TabIndex = 31;
			this.sph_baixo21.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_alto9 = this.sph_alto21;
sph_alto9.Location = new global::System.Drawing.Point(292, 127);
			this.sph_alto21.Name = "sph_alto21";
			global::System.Windows.Forms.Control sph_alto10 = this.sph_alto21;
			Size = new System.Drawing.Size(67, 20);
			sph_alto10.Size = this.Size;
			this.sph_alto21.TabIndex = 30;
			this.sph_alto21.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_minuto9 = this.sph_minuto21;
sph_minuto9.Location = new global::System.Drawing.Point(229, 127);
			this.sph_minuto21.Name = "sph_minuto21";
			global::System.Windows.Forms.Control sph_minuto10 = this.sph_minuto21;
			Size = new System.Drawing.Size(57, 20);
			sph_minuto10.Size = this.Size;
			this.sph_minuto21.TabIndex = 29;
			this.sph_minuto21.TextAlign = HorizontalAlignment.Center;
			this.sph_ativa21.AutoSize = true;
			global::System.Windows.Forms.Control sph_ativa9 = this.sph_ativa21;
sph_ativa9.Location = new global::System.Drawing.Point(110, 130);
			this.sph_ativa21.Name = "sph_ativa21";
			global::System.Windows.Forms.Control sph_ativa10 = this.sph_ativa21;
			Size = new System.Drawing.Size(50, 17);
			sph_ativa10.Size = this.Size;
			this.sph_ativa21.TabIndex = 28;
			this.sph_ativa21.Text = "Ativa";
			this.sph_ativa21.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control sph_hora9 = this.sph_hora21;
sph_hora9.Location = new global::System.Drawing.Point(166, 127);
			this.sph_hora21.Name = "sph_hora21";
			global::System.Windows.Forms.Control sph_hora10 = this.sph_hora21;
			Size = new System.Drawing.Size(57, 20);
			sph_hora10.Size = this.Size;
			this.sph_hora21.TabIndex = 27;
			this.sph_hora21.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_baixo11 = this.sph_baixo20;
sph_baixo11.Location = new global::System.Drawing.Point(369, 101);
			this.sph_baixo20.Name = "sph_baixo20";
			global::System.Windows.Forms.Control sph_baixo12 = this.sph_baixo20;
			Size = new System.Drawing.Size(67, 20);
			sph_baixo12.Size = this.Size;
			this.sph_baixo20.TabIndex = 24;
			this.sph_baixo20.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_alto11 = this.sph_alto20;
sph_alto11.Location = new global::System.Drawing.Point(292, 101);
			this.sph_alto20.Name = "sph_alto20";
			global::System.Windows.Forms.Control sph_alto12 = this.sph_alto20;
			Size = new System.Drawing.Size(67, 20);
			sph_alto12.Size = this.Size;
			this.sph_alto20.TabIndex = 23;
			this.sph_alto20.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_minuto11 = this.sph_minuto20;
sph_minuto11.Location = new global::System.Drawing.Point(229, 101);
			this.sph_minuto20.Name = "sph_minuto20";
			global::System.Windows.Forms.Control sph_minuto12 = this.sph_minuto20;
			Size = new System.Drawing.Size(57, 20);
			sph_minuto12.Size = this.Size;
			this.sph_minuto20.TabIndex = 22;
			this.sph_minuto20.TextAlign = HorizontalAlignment.Center;
			this.sph_ativa20.AutoSize = true;
			global::System.Windows.Forms.Control sph_ativa11 = this.sph_ativa20;
sph_ativa11.Location = new global::System.Drawing.Point(110, 104);
			this.sph_ativa20.Name = "sph_ativa20";
			global::System.Windows.Forms.Control sph_ativa12 = this.sph_ativa20;
			Size = new System.Drawing.Size(50, 17);
			sph_ativa12.Size = this.Size;
			this.sph_ativa20.TabIndex = 21;
			this.sph_ativa20.Text = "Ativa";
			this.sph_ativa20.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control sph_hora11 = this.sph_hora20;
sph_hora11.Location = new global::System.Drawing.Point(166, 101);
			this.sph_hora20.Name = "sph_hora20";
			global::System.Windows.Forms.Control sph_hora12 = this.sph_hora20;
			Size = new System.Drawing.Size(57, 20);
			sph_hora12.Size = this.Size;
			this.sph_hora20.TabIndex = 18;
			this.sph_hora20.TextAlign = HorizontalAlignment.Center;
			this.Label62.AutoSize = true;
			global::System.Windows.Forms.Control label21 = this.Label62;
label21.Location = new global::System.Drawing.Point(29, 103);
			this.Label62.Name = "Label62";
			global::System.Windows.Forms.Control label22 = this.Label62;
			Size = new System.Drawing.Size(55, 13);
			label22.Size = this.Size;
			this.Label62.TabIndex = 17;
			this.Label62.Text = "Controle2:";
			global::System.Windows.Forms.Control sph_baixo13 = this.sph_baixo11;
sph_baixo13.Location = new global::System.Drawing.Point(369, 73);
			this.sph_baixo11.Name = "sph_baixo11";
			global::System.Windows.Forms.Control sph_baixo14 = this.sph_baixo11;
			Size = new System.Drawing.Size(67, 20);
			sph_baixo14.Size = this.Size;
			this.sph_baixo11.TabIndex = 16;
			this.sph_baixo11.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_alto13 = this.sph_alto11;
sph_alto13.Location = new global::System.Drawing.Point(292, 73);
			this.sph_alto11.Name = "sph_alto11";
			global::System.Windows.Forms.Control sph_alto14 = this.sph_alto11;
			Size = new System.Drawing.Size(67, 20);
			sph_alto14.Size = this.Size;
			this.sph_alto11.TabIndex = 15;
			this.sph_alto11.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_minuto13 = this.sph_minuto11;
sph_minuto13.Location = new global::System.Drawing.Point(229, 73);
			this.sph_minuto11.Name = "sph_minuto11";
			global::System.Windows.Forms.Control sph_minuto14 = this.sph_minuto11;
			Size = new System.Drawing.Size(57, 20);
			sph_minuto14.Size = this.Size;
			this.sph_minuto11.TabIndex = 14;
			this.sph_minuto11.TextAlign = HorizontalAlignment.Center;
			this.sph_ativa11.AutoSize = true;
			global::System.Windows.Forms.Control sph_ativa13 = this.sph_ativa11;
sph_ativa13.Location = new global::System.Drawing.Point(110, 76);
			this.sph_ativa11.Name = "sph_ativa11";
			global::System.Windows.Forms.Control sph_ativa14 = this.sph_ativa11;
			Size = new System.Drawing.Size(50, 17);
			sph_ativa14.Size = this.Size;
			this.sph_ativa11.TabIndex = 13;
			this.sph_ativa11.Text = "Ativa";
			this.sph_ativa11.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control sph_hora13 = this.sph_hora11;
sph_hora13.Location = new global::System.Drawing.Point(166, 73);
			this.sph_hora11.Name = "sph_hora11";
			global::System.Windows.Forms.Control sph_hora14 = this.sph_hora11;
			Size = new System.Drawing.Size(57, 20);
			sph_hora14.Size = this.Size;
			this.sph_hora11.TabIndex = 10;
			this.sph_hora11.TextAlign = HorizontalAlignment.Center;
			this.Label57.AutoSize = true;
			global::System.Windows.Forms.Control label23 = this.Label57;
label23.Location = new global::System.Drawing.Point(366, 28);
			this.Label57.Name = "Label57";
			global::System.Windows.Forms.Control label24 = this.Label57;
			Size = new System.Drawing.Size(36, 13);
			label24.Size = this.Size;
			this.Label57.TabIndex = 9;
			this.Label57.Text = "Baixo:";
			this.Label56.AutoSize = true;
			global::System.Windows.Forms.Control label25 = this.Label56;
label25.Location = new global::System.Drawing.Point(289, 29);
			this.Label56.Name = "Label56";
			global::System.Windows.Forms.Control label26 = this.Label56;
			Size = new System.Drawing.Size(28, 13);
			label26.Size = this.Size;
			this.Label56.TabIndex = 8;
			this.Label56.Text = "Alto:";
			global::System.Windows.Forms.Control sph_baixo15 = this.sph_baixo10;
sph_baixo15.Location = new global::System.Drawing.Point(369, 47);
			this.sph_baixo10.Name = "sph_baixo10";
			global::System.Windows.Forms.Control sph_baixo16 = this.sph_baixo10;
			Size = new System.Drawing.Size(67, 20);
			sph_baixo16.Size = this.Size;
			this.sph_baixo10.TabIndex = 7;
			this.sph_baixo10.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_alto15 = this.sph_alto10;
sph_alto15.Location = new global::System.Drawing.Point(292, 47);
			this.sph_alto10.Name = "sph_alto10";
			global::System.Windows.Forms.Control sph_alto16 = this.sph_alto10;
			Size = new System.Drawing.Size(67, 20);
			sph_alto16.Size = this.Size;
			this.sph_alto10.TabIndex = 6;
			this.sph_alto10.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control sph_minuto15 = this.sph_minuto10;
sph_minuto15.Location = new global::System.Drawing.Point(229, 47);
			this.sph_minuto10.Name = "sph_minuto10";
			global::System.Windows.Forms.Control sph_minuto16 = this.sph_minuto10;
			Size = new System.Drawing.Size(57, 20);
			sph_minuto16.Size = this.Size;
			this.sph_minuto10.TabIndex = 5;
			this.sph_minuto10.TextAlign = HorizontalAlignment.Center;
			this.sph_ativa10.AutoSize = true;
			global::System.Windows.Forms.Control sph_ativa15 = this.sph_ativa10;
sph_ativa15.Location = new global::System.Drawing.Point(110, 50);
			this.sph_ativa10.Name = "sph_ativa10";
			global::System.Windows.Forms.Control sph_ativa16 = this.sph_ativa10;
			Size = new System.Drawing.Size(50, 17);
			sph_ativa16.Size = this.Size;
			this.sph_ativa10.TabIndex = 4;
			this.sph_ativa10.Text = "Ativa";
			this.sph_ativa10.UseVisualStyleBackColor = true;
			this.Label55.AutoSize = true;
			global::System.Windows.Forms.Control label27 = this.Label55;
label27.Location = new global::System.Drawing.Point(226, 29);
			this.Label55.Name = "Label55";
			global::System.Windows.Forms.Control label28 = this.Label55;
			Size = new System.Drawing.Size(42, 13);
			label28.Size = this.Size;
			this.Label55.TabIndex = 3;
			this.Label55.Text = "Minuto:";
			this.Label54.AutoSize = true;
			global::System.Windows.Forms.Control label29 = this.Label54;
label29.Location = new global::System.Drawing.Point(163, 29);
			this.Label54.Name = "Label54";
			global::System.Windows.Forms.Control label30 = this.Label54;
			Size = new System.Drawing.Size(33, 13);
			label30.Size = this.Size;
			this.Label54.TabIndex = 2;
			this.Label54.Text = "Hora:";
			global::System.Windows.Forms.Control sph_hora15 = this.sph_hora10;
sph_hora15.Location = new global::System.Drawing.Point(166, 47);
			this.sph_hora10.Name = "sph_hora10";
			global::System.Windows.Forms.Control sph_hora16 = this.sph_hora10;
			Size = new System.Drawing.Size(57, 20);
			sph_hora16.Size = this.Size;
			this.sph_hora10.TabIndex = 1;
			this.sph_hora10.TextAlign = HorizontalAlignment.Center;
			this.Label53.AutoSize = true;
			global::System.Windows.Forms.Control label31 = this.Label53;
label31.Location = new global::System.Drawing.Point(29, 49);
			this.Label53.Name = "Label53";
			global::System.Windows.Forms.Control label32 = this.Label53;
			Size = new System.Drawing.Size(55, 13);
			label32.Size = this.Size;
			this.Label53.TabIndex = 0;
			this.Label53.Text = "Controle1:";
			this.GroupBox3.Controls.Add(this.Label75);
			this.GroupBox3.Controls.Add(this.Label74);
			this.GroupBox3.Controls.Add(this.nud_protecao_liga);
			this.GroupBox3.Controls.Add(this.nud_protecao_desliga);
			this.GroupBox3.Controls.Add(this.nud_motor4_baixo);
			this.GroupBox3.Controls.Add(this.nud_motor4_alto);
			this.GroupBox3.Controls.Add(this.nud_motor3_baixo);
			this.GroupBox3.Controls.Add(this.nud_motor3_alto);
			this.GroupBox3.Controls.Add(this.nud_motor2_baixo);
			this.GroupBox3.Controls.Add(this.nud_motor2_alto);
			this.GroupBox3.Controls.Add(this.nud_motor1_baixo);
			this.GroupBox3.Controls.Add(this.Label28);
			this.GroupBox3.Controls.Add(this.Label27);
			this.GroupBox3.Controls.Add(this.Label25);
			this.GroupBox3.Controls.Add(this.Label22);
			this.GroupBox3.Controls.Add(this.Label21);
			this.GroupBox3.Controls.Add(this.Label19);
			this.GroupBox3.Controls.Add(this.nud_motor1_alto);
			this.GroupBox3.Controls.Add(this.tb_lixo5);
			global::System.Windows.Forms.Control groupBox5 = this.GroupBox3;
groupBox5.Location = new global::System.Drawing.Point(17, 15);
			this.GroupBox3.Name = "GroupBox3";
			global::System.Windows.Forms.Control groupBox6 = this.GroupBox3;
			Size = new System.Drawing.Size(280, 299);
			groupBox6.Size = this.Size;
			this.GroupBox3.TabIndex = 2;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Setpoint (0 -4000)";
			this.Label75.AutoSize = true;
			global::System.Windows.Forms.Control label33 = this.Label75;
label33.Location = new global::System.Drawing.Point(195, 29);
			this.Label75.Name = "Label75";
			global::System.Windows.Forms.Control label34 = this.Label75;
			Size = new System.Drawing.Size(36, 13);
			label34.Size = this.Size;
			this.Label75.TabIndex = 22;
			this.Label75.Text = "Baixo:";
			this.Label74.AutoSize = true;
			global::System.Windows.Forms.Control label35 = this.Label74;
label35.Location = new global::System.Drawing.Point(105, 29);
			this.Label74.Name = "Label74";
			global::System.Windows.Forms.Control label36 = this.Label74;
			Size = new System.Drawing.Size(28, 13);
			label36.Size = this.Size;
			this.Label74.TabIndex = 21;
			this.Label74.Text = "Alto:";
			global::System.Windows.Forms.Control nud_protecao_liga = this.nud_protecao_liga;
nud_protecao_liga.Location = new global::System.Drawing.Point(108, 241);
			global::System.Windows.Forms.NumericUpDown nud_protecao_liga2 = this.nud_protecao_liga;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			nud_protecao_liga2.Maximum = num;
			this.nud_protecao_liga.Name = "nud_protecao_liga";
			global::System.Windows.Forms.Control nud_protecao_liga3 = this.nud_protecao_liga;
			Size = new System.Drawing.Size(73, 20);
			nud_protecao_liga3.Size = this.Size;
			this.nud_protecao_liga.TabIndex = 19;
			this.nud_protecao_liga.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_protecao_desliga = this.nud_protecao_desliga;
nud_protecao_desliga.Location = new global::System.Drawing.Point(108, 215);
			global::System.Windows.Forms.NumericUpDown nud_protecao_desliga2 = this.nud_protecao_desliga;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			nud_protecao_desliga2.Maximum = num;
			this.nud_protecao_desliga.Name = "nud_protecao_desliga";
			global::System.Windows.Forms.Control nud_protecao_desliga3 = this.nud_protecao_desliga;
			Size = new System.Drawing.Size(73, 20);
			nud_protecao_desliga3.Size = this.Size;
			this.nud_protecao_desliga.TabIndex = 18;
			this.nud_protecao_desliga.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_motor4_baixo = this.nud_motor4_baixo;
nud_motor4_baixo.Location = new global::System.Drawing.Point(195, 161);
			global::System.Windows.Forms.NumericUpDown nud_motor4_baixo2 = this.nud_motor4_baixo;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			nud_motor4_baixo2.Maximum = num;
			this.nud_motor4_baixo.Name = "nud_motor4_baixo";
			global::System.Windows.Forms.Control nud_motor4_baixo3 = this.nud_motor4_baixo;
			Size = new System.Drawing.Size(73, 20);
			nud_motor4_baixo3.Size = this.Size;
			this.nud_motor4_baixo.TabIndex = 17;
			this.nud_motor4_baixo.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_motor4_alto = this.nud_motor4_alto;
nud_motor4_alto.Location = new global::System.Drawing.Point(108, 161);
			global::System.Windows.Forms.NumericUpDown nud_motor4_alto2 = this.nud_motor4_alto;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			nud_motor4_alto2.Maximum = num;
			this.nud_motor4_alto.Name = "nud_motor4_alto";
			global::System.Windows.Forms.Control nud_motor4_alto3 = this.nud_motor4_alto;
			Size = new System.Drawing.Size(73, 20);
			nud_motor4_alto3.Size = this.Size;
			this.nud_motor4_alto.TabIndex = 16;
			this.nud_motor4_alto.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_motor3_baixo = this.nud_motor3_baixo;
nud_motor3_baixo.Location = new global::System.Drawing.Point(195, 123);
			global::System.Windows.Forms.NumericUpDown nud_motor3_baixo2 = this.nud_motor3_baixo;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			nud_motor3_baixo2.Maximum = num;
			this.nud_motor3_baixo.Name = "nud_motor3_baixo";
			global::System.Windows.Forms.Control nud_motor3_baixo3 = this.nud_motor3_baixo;
			Size = new System.Drawing.Size(73, 20);
			nud_motor3_baixo3.Size = this.Size;
			this.nud_motor3_baixo.TabIndex = 15;
			this.nud_motor3_baixo.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_motor3_alto = this.nud_motor3_alto;
nud_motor3_alto.Location = new global::System.Drawing.Point(108, 121);
			global::System.Windows.Forms.NumericUpDown nud_motor3_alto2 = this.nud_motor3_alto;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			nud_motor3_alto2.Maximum = num;
			this.nud_motor3_alto.Name = "nud_motor3_alto";
			global::System.Windows.Forms.Control nud_motor3_alto3 = this.nud_motor3_alto;
			Size = new System.Drawing.Size(73, 20);
			nud_motor3_alto3.Size = this.Size;
			this.nud_motor3_alto.TabIndex = 14;
			this.nud_motor3_alto.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_motor2_baixo = this.nud_motor2_baixo;
nud_motor2_baixo.Location = new global::System.Drawing.Point(195, 84);
			global::System.Windows.Forms.NumericUpDown nud_motor2_baixo2 = this.nud_motor2_baixo;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			nud_motor2_baixo2.Maximum = num;
			this.nud_motor2_baixo.Name = "nud_motor2_baixo";
			global::System.Windows.Forms.Control nud_motor2_baixo3 = this.nud_motor2_baixo;
			Size = new System.Drawing.Size(73, 20);
			nud_motor2_baixo3.Size = this.Size;
			this.nud_motor2_baixo.TabIndex = 13;
			this.nud_motor2_baixo.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_motor2_alto = this.nud_motor2_alto;
nud_motor2_alto.Location = new global::System.Drawing.Point(108, 84);
			global::System.Windows.Forms.NumericUpDown nud_motor2_alto2 = this.nud_motor2_alto;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			nud_motor2_alto2.Maximum = num;
			this.nud_motor2_alto.Name = "nud_motor2_alto";
			global::System.Windows.Forms.Control nud_motor2_alto3 = this.nud_motor2_alto;
			Size = new System.Drawing.Size(73, 20);
			nud_motor2_alto3.Size = this.Size;
			this.nud_motor2_alto.TabIndex = 12;
			this.nud_motor2_alto.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_motor1_baixo = this.nud_motor1_baixo;
nud_motor1_baixo.Location = new global::System.Drawing.Point(195, 48);
			global::System.Windows.Forms.NumericUpDown nud_motor1_baixo2 = this.nud_motor1_baixo;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			nud_motor1_baixo2.Maximum = num;
			this.nud_motor1_baixo.Name = "nud_motor1_baixo";
			global::System.Windows.Forms.Control nud_motor1_baixo3 = this.nud_motor1_baixo;
			Size = new System.Drawing.Size(73, 20);
			nud_motor1_baixo3.Size = this.Size;
			this.nud_motor1_baixo.TabIndex = 11;
			this.nud_motor1_baixo.TextAlign = HorizontalAlignment.Center;
			this.Label28.AutoSize = true;
			global::System.Windows.Forms.Control label37 = this.Label28;
label37.Location = new global::System.Drawing.Point(14, 243);
			this.Label28.Name = "Label28";
			global::System.Windows.Forms.Control label38 = this.Label28;
			Size = new System.Drawing.Size(76, 13);
			label38.Size = this.Size;
			this.Label28.TabIndex = 9;
			this.Label28.Text = "Proteção Liga:";
			this.Label27.AutoSize = true;
			global::System.Windows.Forms.Control label39 = this.Label27;
label39.Location = new global::System.Drawing.Point(14, 217);
			this.Label27.Name = "Label27";
			global::System.Windows.Forms.Control label40 = this.Label27;
			Size = new System.Drawing.Size(91, 13);
			label40.Size = this.Size;
			this.Label27.TabIndex = 8;
			this.Label27.Text = "Proteção Desliga:";
			this.Label25.AutoSize = true;
			global::System.Windows.Forms.Control label41 = this.Label25;
label41.Location = new global::System.Drawing.Point(14, 163);
			this.Label25.Name = "Label25";
			global::System.Windows.Forms.Control label42 = this.Label25;
			Size = new System.Drawing.Size(55, 13);
			label42.Size = this.Size;
			this.Label25.TabIndex = 6;
			this.Label25.Text = "Controle4:";
			this.Label22.AutoSize = true;
			global::System.Windows.Forms.Control label43 = this.Label22;
label43.Location = new global::System.Drawing.Point(14, 123);
			this.Label22.Name = "Label22";
			global::System.Windows.Forms.Control label44 = this.Label22;
			Size = new System.Drawing.Size(55, 13);
			label44.Size = this.Size;
			this.Label22.TabIndex = 3;
			this.Label22.Text = "Controle3:";
			this.Label21.AutoSize = true;
			global::System.Windows.Forms.Control label45 = this.Label21;
label45.Location = new global::System.Drawing.Point(14, 86);
			this.Label21.Name = "Label21";
			global::System.Windows.Forms.Control label46 = this.Label21;
			Size = new System.Drawing.Size(55, 13);
			label46.Size = this.Size;
			this.Label21.TabIndex = 2;
			this.Label21.Text = "Controle2:";
			this.Label19.AutoSize = true;
			global::System.Windows.Forms.Control label47 = this.Label19;
label47.Location = new global::System.Drawing.Point(14, 50);
			this.Label19.Name = "Label19";
			global::System.Windows.Forms.Control label48 = this.Label19;
			Size = new System.Drawing.Size(55, 13);
			label48.Size = this.Size;
			this.Label19.TabIndex = 0;
			this.Label19.Text = "Controle1:";
			global::System.Windows.Forms.Control nud_motor1_alto = this.nud_motor1_alto;
nud_motor1_alto.Location = new global::System.Drawing.Point(108, 48);
			global::System.Windows.Forms.NumericUpDown nud_motor1_alto2 = this.nud_motor1_alto;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			nud_motor1_alto2.Maximum = num;
			this.nud_motor1_alto.Name = "nud_motor1_alto";
			global::System.Windows.Forms.Control nud_motor1_alto3 = this.nud_motor1_alto;
			Size = new System.Drawing.Size(73, 20);
			nud_motor1_alto3.Size = this.Size;
			this.nud_motor1_alto.TabIndex = 10;
			this.nud_motor1_alto.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control tb_lixo7 = this.tb_lixo5;
tb_lixo7.Location = new global::System.Drawing.Point(108, 48);
			this.tb_lixo5.Name = "tb_lixo5";
			global::System.Windows.Forms.Control tb_lixo8 = this.tb_lixo5;
			Size = new System.Drawing.Size(32, 20);
			tb_lixo8.Size = this.Size;
			this.tb_lixo5.TabIndex = 20;
			this.TabPage_MotoresValvulas.Controls.Add(this.GroupBox6);
			this.TabPage_MotoresValvulas.Controls.Add(this.GroupBox5);
			this.TabPage_MotoresValvulas.Controls.Add(this.GroupBox4);
			global::System.Windows.Forms.TabPage tabPage_MotoresValvulas = this.TabPage_MotoresValvulas;
tabPage_MotoresValvulas.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_MotoresValvulas.Name = "TabPage_MotoresValvulas";
			global::System.Windows.Forms.Control tabPage_MotoresValvulas2 = this.TabPage_MotoresValvulas;
			Padding = new Padding(3);
			tabPage_MotoresValvulas2.Padding = Padding;
			global::System.Windows.Forms.Control tabPage_MotoresValvulas3 = this.TabPage_MotoresValvulas;
			Size = new System.Drawing.Size(1294, 443);
			tabPage_MotoresValvulas3.Size = this.Size;
			this.TabPage_MotoresValvulas.TabIndex = 11;
			this.TabPage_MotoresValvulas.Text = "Controles";
			this.TabPage_MotoresValvulas.UseVisualStyleBackColor = true;
			this.GroupBox6.Controls.Add(this.cb_modo_partida4);
			this.GroupBox6.Controls.Add(this.cb_modo_partida3);
			this.GroupBox6.Controls.Add(this.cb_modo_partida2);
			this.GroupBox6.Controls.Add(this.cb_modo_partida1);
			this.GroupBox6.Controls.Add(this.nud_parada4);
			this.GroupBox6.Controls.Add(this.nud_partida4);
			this.GroupBox6.Controls.Add(this.nud_parada3);
			this.GroupBox6.Controls.Add(this.nud_partida3);
			this.GroupBox6.Controls.Add(this.nud_parada2);
			this.GroupBox6.Controls.Add(this.nud_partida2);
			this.GroupBox6.Controls.Add(this.nud_parada1);
			this.GroupBox6.Controls.Add(this.nud_partida1);
			this.GroupBox6.Controls.Add(this.Label47);
			this.GroupBox6.Controls.Add(this.Label46);
			this.GroupBox6.Controls.Add(this.Label45);
			this.GroupBox6.Controls.Add(this.Label44);
			this.GroupBox6.Controls.Add(this.Label43);
			this.GroupBox6.Controls.Add(this.Label42);
			this.GroupBox6.Controls.Add(this.Label41);
			global::System.Windows.Forms.Control groupBox7 = this.GroupBox6;
groupBox7.Location = new global::System.Drawing.Point(17, 207);
			this.GroupBox6.Name = "GroupBox6";
			global::System.Windows.Forms.Control groupBox8 = this.GroupBox6;
			Size = new System.Drawing.Size(448, 189);
			groupBox8.Size = this.Size;
			this.GroupBox6.TabIndex = 2;
			this.GroupBox6.TabStop = false;
			this.GroupBox6.Text = "Motores";
			this.cb_modo_partida4.FormattingEnabled = true;
			global::System.Windows.Forms.Control cb_modo_partida = this.cb_modo_partida4;
cb_modo_partida.Location = new global::System.Drawing.Point(62, 153);
			this.cb_modo_partida4.Name = "cb_modo_partida4";
			global::System.Windows.Forms.Control cb_modo_partida2 = this.cb_modo_partida4;
			Size = new System.Drawing.Size(163, 21);
			cb_modo_partida2.Size = this.Size;
			this.cb_modo_partida4.TabIndex = 18;
			this.cb_modo_partida3.FormattingEnabled = true;
			global::System.Windows.Forms.Control cb_modo_partida3 = this.cb_modo_partida3;
cb_modo_partida3.Location = new global::System.Drawing.Point(62, 122);
			this.cb_modo_partida3.Name = "cb_modo_partida3";
			global::System.Windows.Forms.Control cb_modo_partida4 = this.cb_modo_partida3;
			Size = new System.Drawing.Size(163, 21);
			cb_modo_partida4.Size = this.Size;
			this.cb_modo_partida3.TabIndex = 17;
			this.cb_modo_partida2.FormattingEnabled = true;
			global::System.Windows.Forms.Control cb_modo_partida5 = this.cb_modo_partida2;
cb_modo_partida5.Location = new global::System.Drawing.Point(62, 91);
			this.cb_modo_partida2.Name = "cb_modo_partida2";
			global::System.Windows.Forms.Control cb_modo_partida6 = this.cb_modo_partida2;
			Size = new System.Drawing.Size(163, 21);
			cb_modo_partida6.Size = this.Size;
			this.cb_modo_partida2.TabIndex = 16;
			this.cb_modo_partida1.FormattingEnabled = true;
			global::System.Windows.Forms.Control cb_modo_partida7 = this.cb_modo_partida1;
cb_modo_partida7.Location = new global::System.Drawing.Point(62, 60);
			this.cb_modo_partida1.Name = "cb_modo_partida1";
			global::System.Windows.Forms.Control cb_modo_partida8 = this.cb_modo_partida1;
			Size = new System.Drawing.Size(163, 21);
			cb_modo_partida8.Size = this.Size;
			this.cb_modo_partida1.TabIndex = 15;
			global::System.Windows.Forms.Control nud_parada = this.nud_parada4;
nud_parada.Location = new global::System.Drawing.Point(350, 154);
			this.nud_parada4.Name = "nud_parada4";
			global::System.Windows.Forms.Control nud_parada2 = this.nud_parada4;
			Size = new System.Drawing.Size(63, 20);
			nud_parada2.Size = this.Size;
			this.nud_parada4.TabIndex = 14;
			this.nud_parada4.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_partida = this.nud_partida4;
nud_partida.Location = new global::System.Drawing.Point(246, 154);
			this.nud_partida4.Name = "nud_partida4";
			global::System.Windows.Forms.Control nud_partida2 = this.nud_partida4;
			Size = new System.Drawing.Size(63, 20);
			nud_partida2.Size = this.Size;
			this.nud_partida4.TabIndex = 13;
			this.nud_partida4.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_parada3 = this.nud_parada3;
nud_parada3.Location = new global::System.Drawing.Point(350, 123);
			this.nud_parada3.Name = "nud_parada3";
			global::System.Windows.Forms.Control nud_parada4 = this.nud_parada3;
			Size = new System.Drawing.Size(63, 20);
			nud_parada4.Size = this.Size;
			this.nud_parada3.TabIndex = 12;
			this.nud_parada3.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_partida3 = this.nud_partida3;
nud_partida3.Location = new global::System.Drawing.Point(246, 123);
			this.nud_partida3.Name = "nud_partida3";
			global::System.Windows.Forms.Control nud_partida4 = this.nud_partida3;
			Size = new System.Drawing.Size(63, 20);
			nud_partida4.Size = this.Size;
			this.nud_partida3.TabIndex = 11;
			this.nud_partida3.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_parada5 = this.nud_parada2;
nud_parada5.Location = new global::System.Drawing.Point(350, 92);
			this.nud_parada2.Name = "nud_parada2";
			global::System.Windows.Forms.Control nud_parada6 = this.nud_parada2;
			Size = new System.Drawing.Size(63, 20);
			nud_parada6.Size = this.Size;
			this.nud_parada2.TabIndex = 10;
			this.nud_parada2.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_partida5 = this.nud_partida2;
nud_partida5.Location = new global::System.Drawing.Point(246, 92);
			this.nud_partida2.Name = "nud_partida2";
			global::System.Windows.Forms.Control nud_partida6 = this.nud_partida2;
			Size = new System.Drawing.Size(63, 20);
			nud_partida6.Size = this.Size;
			this.nud_partida2.TabIndex = 9;
			this.nud_partida2.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_parada7 = this.nud_parada1;
nud_parada7.Location = new global::System.Drawing.Point(350, 61);
			this.nud_parada1.Name = "nud_parada1";
			global::System.Windows.Forms.Control nud_parada8 = this.nud_parada1;
			Size = new System.Drawing.Size(63, 20);
			nud_parada8.Size = this.Size;
			this.nud_parada1.TabIndex = 8;
			this.nud_parada1.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_partida7 = this.nud_partida1;
nud_partida7.Location = new global::System.Drawing.Point(246, 61);
			this.nud_partida1.Name = "nud_partida1";
			global::System.Windows.Forms.Control nud_partida8 = this.nud_partida1;
			Size = new System.Drawing.Size(63, 20);
			nud_partida8.Size = this.Size;
			this.nud_partida1.TabIndex = 7;
			this.nud_partida1.TextAlign = HorizontalAlignment.Center;
			this.Label47.AutoSize = true;
			global::System.Windows.Forms.Control label49 = this.Label47;
label49.Location = new global::System.Drawing.Point(347, 33);
			this.Label47.Name = "Label47";
			global::System.Windows.Forms.Control label50 = this.Label47;
			Size = new System.Drawing.Size(94, 13);
			label50.Size = this.Size;
			this.Label47.TabIndex = 6;
			this.Label47.Text = "Tempo Parada (s):";
			this.Label46.AutoSize = true;
			global::System.Windows.Forms.Control label51 = this.Label46;
label51.Location = new global::System.Drawing.Point(243, 33);
			this.Label46.Name = "Label46";
			global::System.Windows.Forms.Control label52 = this.Label46;
			Size = new System.Drawing.Size(93, 13);
			label52.Size = this.Size;
			this.Label46.TabIndex = 5;
			this.Label46.Text = "Tempo Partida (s):";
			this.Label45.AutoSize = true;
			global::System.Windows.Forms.Control label53 = this.Label45;
label53.Location = new global::System.Drawing.Point(66, 33);
			this.Label45.Name = "Label45";
			global::System.Windows.Forms.Control label54 = this.Label45;
			Size = new System.Drawing.Size(91, 13);
			label54.Size = this.Size;
			this.Label45.TabIndex = 4;
			this.Label45.Text = "Modo de Controle";
			this.Label44.AutoSize = true;
			global::System.Windows.Forms.Control label55 = this.Label44;
label55.Location = new global::System.Drawing.Point(6, 156);
			this.Label44.Name = "Label44";
			global::System.Windows.Forms.Control label56 = this.Label44;
			Size = new System.Drawing.Size(43, 13);
			label56.Size = this.Size;
			this.Label44.TabIndex = 3;
			this.Label44.Text = "Motor 4";
			this.Label43.AutoSize = true;
			global::System.Windows.Forms.Control label57 = this.Label43;
label57.Location = new global::System.Drawing.Point(6, 125);
			this.Label43.Name = "Label43";
			global::System.Windows.Forms.Control label58 = this.Label43;
			Size = new System.Drawing.Size(43, 13);
			label58.Size = this.Size;
			this.Label43.TabIndex = 2;
			this.Label43.Text = "Motor 3";
			this.Label42.AutoSize = true;
			global::System.Windows.Forms.Control label59 = this.Label42;
label59.Location = new global::System.Drawing.Point(6, 94);
			this.Label42.Name = "Label42";
			global::System.Windows.Forms.Control label60 = this.Label42;
			Size = new System.Drawing.Size(43, 13);
			label60.Size = this.Size;
			this.Label42.TabIndex = 1;
			this.Label42.Text = "Motor 2";
			this.Label41.AutoSize = true;
			global::System.Windows.Forms.Control label61 = this.Label41;
label61.Location = new global::System.Drawing.Point(6, 63);
			this.Label41.Name = "Label41";
			global::System.Windows.Forms.Control label62 = this.Label41;
			Size = new System.Drawing.Size(43, 13);
			label62.Size = this.Size;
			this.Label41.TabIndex = 0;
			this.Label41.Text = "Motor 1";
			this.GroupBox5.Controls.Add(this.nud_valvula4_fechamento);
			this.GroupBox5.Controls.Add(this.nud_valvula4_abertura);
			this.GroupBox5.Controls.Add(this.nud_valvula3_fechamento);
			this.GroupBox5.Controls.Add(this.nud_valvula3_abertura);
			this.GroupBox5.Controls.Add(this.nud_valvula2_fechamento);
			this.GroupBox5.Controls.Add(this.nud_valvula2_abertura);
			this.GroupBox5.Controls.Add(this.nud_valvula1_fechamento);
			this.GroupBox5.Controls.Add(this.nud_valvula1_abertura);
			this.GroupBox5.Controls.Add(this.Label40);
			this.GroupBox5.Controls.Add(this.Label39);
			this.GroupBox5.Controls.Add(this.Label38);
			this.GroupBox5.Controls.Add(this.Label37);
			this.GroupBox5.Controls.Add(this.Label36);
			this.GroupBox5.Controls.Add(this.Label35);
			global::System.Windows.Forms.Control groupBox9 = this.GroupBox5;
groupBox9.Location = new global::System.Drawing.Point(499, 207);
			this.GroupBox5.Name = "GroupBox5";
			global::System.Windows.Forms.Control groupBox10 = this.GroupBox5;
			Size = new System.Drawing.Size(340, 189);
			groupBox10.Size = this.Size;
			this.GroupBox5.TabIndex = 1;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "Válvulas";
			global::System.Windows.Forms.Control nud_valvula4_fechamento = this.nud_valvula4_fechamento;
nud_valvula4_fechamento.Location = new global::System.Drawing.Point(209, 153);
			this.nud_valvula4_fechamento.Name = "nud_valvula4_fechamento";
			global::System.Windows.Forms.Control nud_valvula4_fechamento2 = this.nud_valvula4_fechamento;
			Size = new System.Drawing.Size(63, 20);
			nud_valvula4_fechamento2.Size = this.Size;
			this.nud_valvula4_fechamento.TabIndex = 13;
			this.nud_valvula4_fechamento.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_valvula4_abertura = this.nud_valvula4_abertura;
nud_valvula4_abertura.Location = new global::System.Drawing.Point(85, 154);
			this.nud_valvula4_abertura.Name = "nud_valvula4_abertura";
			global::System.Windows.Forms.Control nud_valvula4_abertura2 = this.nud_valvula4_abertura;
			Size = new System.Drawing.Size(63, 20);
			nud_valvula4_abertura2.Size = this.Size;
			this.nud_valvula4_abertura.TabIndex = 12;
			this.nud_valvula4_abertura.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_valvula3_fechamento = this.nud_valvula3_fechamento;
nud_valvula3_fechamento.Location = new global::System.Drawing.Point(209, 125);
			this.nud_valvula3_fechamento.Name = "nud_valvula3_fechamento";
			global::System.Windows.Forms.Control nud_valvula3_fechamento2 = this.nud_valvula3_fechamento;
			Size = new System.Drawing.Size(63, 20);
			nud_valvula3_fechamento2.Size = this.Size;
			this.nud_valvula3_fechamento.TabIndex = 11;
			this.nud_valvula3_fechamento.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_valvula3_abertura = this.nud_valvula3_abertura;
nud_valvula3_abertura.Location = new global::System.Drawing.Point(85, 123);
			this.nud_valvula3_abertura.Name = "nud_valvula3_abertura";
			global::System.Windows.Forms.Control nud_valvula3_abertura2 = this.nud_valvula3_abertura;
			Size = new System.Drawing.Size(63, 20);
			nud_valvula3_abertura2.Size = this.Size;
			this.nud_valvula3_abertura.TabIndex = 10;
			this.nud_valvula3_abertura.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_valvula2_fechamento = this.nud_valvula2_fechamento;
nud_valvula2_fechamento.Location = new global::System.Drawing.Point(209, 91);
			this.nud_valvula2_fechamento.Name = "nud_valvula2_fechamento";
			global::System.Windows.Forms.Control nud_valvula2_fechamento2 = this.nud_valvula2_fechamento;
			Size = new System.Drawing.Size(63, 20);
			nud_valvula2_fechamento2.Size = this.Size;
			this.nud_valvula2_fechamento.TabIndex = 9;
			this.nud_valvula2_fechamento.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_valvula2_abertura = this.nud_valvula2_abertura;
nud_valvula2_abertura.Location = new global::System.Drawing.Point(85, 91);
			this.nud_valvula2_abertura.Name = "nud_valvula2_abertura";
			global::System.Windows.Forms.Control nud_valvula2_abertura2 = this.nud_valvula2_abertura;
			Size = new System.Drawing.Size(63, 20);
			nud_valvula2_abertura2.Size = this.Size;
			this.nud_valvula2_abertura.TabIndex = 8;
			this.nud_valvula2_abertura.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_valvula1_fechamento = this.nud_valvula1_fechamento;
nud_valvula1_fechamento.Location = new global::System.Drawing.Point(209, 60);
			this.nud_valvula1_fechamento.Name = "nud_valvula1_fechamento";
			global::System.Windows.Forms.Control nud_valvula1_fechamento2 = this.nud_valvula1_fechamento;
			Size = new System.Drawing.Size(63, 20);
			nud_valvula1_fechamento2.Size = this.Size;
			this.nud_valvula1_fechamento.TabIndex = 7;
			this.nud_valvula1_fechamento.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_valvula1_abertura = this.nud_valvula1_abertura;
nud_valvula1_abertura.Location = new global::System.Drawing.Point(85, 60);
			this.nud_valvula1_abertura.Name = "nud_valvula1_abertura";
			global::System.Windows.Forms.Control nud_valvula1_abertura2 = this.nud_valvula1_abertura;
			Size = new System.Drawing.Size(63, 20);
			nud_valvula1_abertura2.Size = this.Size;
			this.nud_valvula1_abertura.TabIndex = 6;
			this.nud_valvula1_abertura.TextAlign = HorizontalAlignment.Center;
			this.Label40.AutoSize = true;
			global::System.Windows.Forms.Control label63 = this.Label40;
label63.Location = new global::System.Drawing.Point(206, 33);
			this.Label40.Name = "Label40";
			global::System.Windows.Forms.Control label64 = this.Label40;
			Size = new System.Drawing.Size(119, 13);
			label64.Size = this.Size;
			this.Label40.TabIndex = 5;
			this.Label40.Text = "Tempo Fechamento (s):";
			this.Label39.AutoSize = true;
			global::System.Windows.Forms.Control label65 = this.Label39;
label65.Location = new global::System.Drawing.Point(82, 33);
			this.Label39.Name = "Label39";
			global::System.Windows.Forms.Control label66 = this.Label39;
			Size = new System.Drawing.Size(100, 13);
			label66.Size = this.Size;
			this.Label39.TabIndex = 4;
			this.Label39.Text = "Tempo Abertura (s):";
			this.Label38.AutoSize = true;
			global::System.Windows.Forms.Control label67 = this.Label38;
label67.Location = new global::System.Drawing.Point(6, 156);
			this.Label38.Name = "Label38";
			global::System.Windows.Forms.Control label68 = this.Label38;
			Size = new System.Drawing.Size(51, 13);
			label68.Size = this.Size;
			this.Label38.TabIndex = 3;
			this.Label38.Text = "Válvula 4";
			this.Label37.AutoSize = true;
			global::System.Windows.Forms.Control label69 = this.Label37;
label69.Location = new global::System.Drawing.Point(6, 125);
			this.Label37.Name = "Label37";
			global::System.Windows.Forms.Control label70 = this.Label37;
			Size = new System.Drawing.Size(51, 13);
			label70.Size = this.Size;
			this.Label37.TabIndex = 2;
			this.Label37.Text = "Válvula 3";
			this.Label36.AutoSize = true;
			global::System.Windows.Forms.Control label71 = this.Label36;
label71.Location = new global::System.Drawing.Point(6, 94);
			this.Label36.Name = "Label36";
			global::System.Windows.Forms.Control label72 = this.Label36;
			Size = new System.Drawing.Size(51, 13);
			label72.Size = this.Size;
			this.Label36.TabIndex = 1;
			this.Label36.Text = "Válvula 2";
			this.Label35.AutoSize = true;
			global::System.Windows.Forms.Control label73 = this.Label35;
label73.Location = new global::System.Drawing.Point(6, 63);
			this.Label35.Name = "Label35";
			global::System.Windows.Forms.Control label74 = this.Label35;
			Size = new System.Drawing.Size(51, 13);
			label74.Size = this.Size;
			this.Label35.TabIndex = 0;
			this.Label35.Text = "Válvula 1";
			this.GroupBox4.Controls.Add(this.nud_tempo_operacoes);
			this.GroupBox4.Controls.Add(this.nud_bombas_simultaneas);
			this.GroupBox4.Controls.Add(this.nud_numero_valvulas);
			this.GroupBox4.Controls.Add(this.nud_numero_motores);
			this.GroupBox4.Controls.Add(this.cb_modo_operacao);
			this.GroupBox4.Controls.Add(this.Label34);
			this.GroupBox4.Controls.Add(this.Label33);
			this.GroupBox4.Controls.Add(this.Label32);
			this.GroupBox4.Controls.Add(this.Label31);
			this.GroupBox4.Controls.Add(this.Label30);
			this.GroupBox4.Controls.Add(this.tb_lixo6);
			global::System.Windows.Forms.Control groupBox11 = this.GroupBox4;
groupBox11.Location = new global::System.Drawing.Point(17, 16);
			this.GroupBox4.Name = "GroupBox4";
			global::System.Windows.Forms.Control groupBox12 = this.GroupBox4;
			Size = new System.Drawing.Size(309, 163);
			groupBox12.Size = this.Size;
			this.GroupBox4.TabIndex = 0;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Controles";
			global::System.Windows.Forms.Control nud_tempo_operacoes = this.nud_tempo_operacoes;
nud_tempo_operacoes.Location = new global::System.Drawing.Point(222, 133);
			this.nud_tempo_operacoes.Name = "nud_tempo_operacoes";
			global::System.Windows.Forms.Control nud_tempo_operacoes2 = this.nud_tempo_operacoes;
			Size = new System.Drawing.Size(69, 20);
			nud_tempo_operacoes2.Size = this.Size;
			this.nud_tempo_operacoes.TabIndex = 9;
			this.nud_tempo_operacoes.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_bombas_simultaneas = this.nud_bombas_simultaneas;
nud_bombas_simultaneas.Location = new global::System.Drawing.Point(222, 108);
			global::System.Windows.Forms.NumericUpDown nud_bombas_simultaneas2 = this.nud_bombas_simultaneas;
			num = new decimal(new int[]
			{
				4,
				0,
				0,
				0
			});
			nud_bombas_simultaneas2.Maximum = num;
			this.nud_bombas_simultaneas.Name = "nud_bombas_simultaneas";
			global::System.Windows.Forms.Control nud_bombas_simultaneas3 = this.nud_bombas_simultaneas;
			Size = new System.Drawing.Size(69, 20);
			nud_bombas_simultaneas3.Size = this.Size;
			this.nud_bombas_simultaneas.TabIndex = 8;
			this.nud_bombas_simultaneas.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_numero_valvulas = this.nud_numero_valvulas;
nud_numero_valvulas.Location = new global::System.Drawing.Point(222, 82);
			global::System.Windows.Forms.NumericUpDown nud_numero_valvulas2 = this.nud_numero_valvulas;
			num = new decimal(new int[]
			{
				4,
				0,
				0,
				0
			});
			nud_numero_valvulas2.Maximum = num;
			this.nud_numero_valvulas.Name = "nud_numero_valvulas";
			global::System.Windows.Forms.Control nud_numero_valvulas3 = this.nud_numero_valvulas;
			Size = new System.Drawing.Size(69, 20);
			nud_numero_valvulas3.Size = this.Size;
			this.nud_numero_valvulas.TabIndex = 7;
			this.nud_numero_valvulas.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nud_numero_motores = this.nud_numero_motores;
nud_numero_motores.Location = new global::System.Drawing.Point(222, 53);
			global::System.Windows.Forms.NumericUpDown nud_numero_motores2 = this.nud_numero_motores;
			num = new decimal(new int[]
			{
				4,
				0,
				0,
				0
			});
			nud_numero_motores2.Maximum = num;
			this.nud_numero_motores.Name = "nud_numero_motores";
			global::System.Windows.Forms.Control nud_numero_motores3 = this.nud_numero_motores;
			Size = new System.Drawing.Size(69, 20);
			nud_numero_motores3.Size = this.Size;
			this.nud_numero_motores.TabIndex = 6;
			this.nud_numero_motores.TextAlign = HorizontalAlignment.Center;
			this.cb_modo_operacao.FormattingEnabled = true;
			global::System.Windows.Forms.Control cb_modo_operacao = this.cb_modo_operacao;
cb_modo_operacao.Location = new global::System.Drawing.Point(114, 26);
			this.cb_modo_operacao.Name = "cb_modo_operacao";
			global::System.Windows.Forms.Control cb_modo_operacao2 = this.cb_modo_operacao;
			Size = new System.Drawing.Size(177, 21);
			cb_modo_operacao2.Size = this.Size;
			this.cb_modo_operacao.TabIndex = 5;
			this.Label34.AutoSize = true;
			global::System.Windows.Forms.Control label75 = this.Label34;
label75.Location = new global::System.Drawing.Point(6, 135);
			this.Label34.Name = "Label34";
			global::System.Windows.Forms.Control label76 = this.Label34;
			Size = new System.Drawing.Size(151, 13);
			label76.Size = this.Size;
			this.Label34.TabIndex = 4;
			this.Label34.Text = "Tempor entre operações (min):";
			this.Label33.AutoSize = true;
			global::System.Windows.Forms.Control label77 = this.Label33;
label77.Location = new global::System.Drawing.Point(6, 110);
			this.Label33.Name = "Label33";
			global::System.Windows.Forms.Control label78 = this.Label33;
			Size = new System.Drawing.Size(145, 13);
			label78.Size = this.Size;
			this.Label33.TabIndex = 3;
			this.Label33.Text = "Número bombas simultâneas:";
			this.Label32.AutoSize = true;
			global::System.Windows.Forms.Control label79 = this.Label32;
label79.Location = new global::System.Drawing.Point(6, 82);
			this.Label32.Name = "Label32";
			global::System.Windows.Forms.Control label80 = this.Label32;
			Size = new System.Drawing.Size(105, 13);
			label80.Size = this.Size;
			this.Label32.TabIndex = 2;
			this.Label32.Text = "Número de Válvulas:";
			this.Label31.AutoSize = true;
			global::System.Windows.Forms.Control label81 = this.Label31;
label81.Location = new global::System.Drawing.Point(6, 53);
			this.Label31.Name = "Label31";
			global::System.Windows.Forms.Control label82 = this.Label31;
			Size = new System.Drawing.Size(102, 13);
			label82.Size = this.Size;
			this.Label31.TabIndex = 1;
			this.Label31.Text = "Número de motores:";
			this.Label30.AutoSize = true;
			global::System.Windows.Forms.Control label83 = this.Label30;
label83.Location = new global::System.Drawing.Point(6, 29);
			this.Label30.Name = "Label30";
			global::System.Windows.Forms.Control label84 = this.Label30;
			Size = new System.Drawing.Size(102, 13);
			label84.Size = this.Size;
			this.Label30.TabIndex = 0;
			this.Label30.Text = "Modo de Operação:";
			global::System.Windows.Forms.Control tb_lixo9 = this.tb_lixo6;
tb_lixo9.Location = new global::System.Drawing.Point(222, 53);
			this.tb_lixo6.Name = "tb_lixo6";
			global::System.Windows.Forms.Control tb_lixo10 = this.tb_lixo6;
			Size = new System.Drawing.Size(41, 20);
			tb_lixo10.Size = this.Size;
			this.tb_lixo6.TabIndex = 10;
			this.TabPage_vazao_perifericos.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.TabPage_vazao_perifericos.Controls.Add(this.GroupBox_perifericos_820);
			global::System.Windows.Forms.TabPage tabPage_vazao_perifericos = this.TabPage_vazao_perifericos;
tabPage_vazao_perifericos.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_vazao_perifericos.Name = "TabPage_vazao_perifericos";
			global::System.Windows.Forms.Control tabPage_vazao_perifericos2 = this.TabPage_vazao_perifericos;
			Padding = new Padding(3);
			tabPage_vazao_perifericos2.Padding = Padding;
			global::System.Windows.Forms.Control tabPage_vazao_perifericos3 = this.TabPage_vazao_perifericos;
			Size = new System.Drawing.Size(1294, 443);
			tabPage_vazao_perifericos3.Size = this.Size;
			this.TabPage_vazao_perifericos.TabIndex = 1;
			this.TabPage_vazao_perifericos.Text = "Periféricos";
			this.TabPage_vazao_perifericos.UseVisualStyleBackColor = true;
			this.GroupBox_perifericos_820.Controls.Add(this.DataGridView_periferico_RT820);
			global::System.Windows.Forms.Control groupBox_perifericos_ = this.GroupBox_perifericos_820;
groupBox_perifericos_.Location = new global::System.Drawing.Point(16, 15);
			this.GroupBox_perifericos_820.Name = "GroupBox_perifericos_820";
			global::System.Windows.Forms.Control groupBox_perifericos_2 = this.GroupBox_perifericos_820;
			Size = new System.Drawing.Size(450, 150);
			groupBox_perifericos_2.Size = this.Size;
			this.GroupBox_perifericos_820.TabIndex = 16;
			this.GroupBox_perifericos_820.TabStop = false;
			this.GroupBox_perifericos_820.Text = "Periféricos";
			this.DataGridView_periferico_RT820.AllowUserToAddRows = false;
			this.DataGridView_periferico_RT820.AllowUserToDeleteRows = false;
			this.DataGridView_periferico_RT820.AllowUserToResizeColumns = false;
			this.DataGridView_periferico_RT820.AllowUserToResizeRows = false;
			dataGridViewCellStyle5.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			this.DataGridView_periferico_RT820.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			dataGridViewCellStyle6.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
			dataGridViewCellStyle6.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView_periferico_RT820.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.DataGridView_periferico_RT820.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			dataGridViewCellStyle7.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
			dataGridViewCellStyle7.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle7.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView_periferico_RT820.DefaultCellStyle = dataGridViewCellStyle7;
			global::System.Windows.Forms.Control dataGridView_periferico_RT = this.DataGridView_periferico_RT820;
dataGridView_periferico_RT.Location = new global::System.Drawing.Point(19, 23);
			this.DataGridView_periferico_RT820.Name = "DataGridView_periferico_RT820";
			dataGridViewCellStyle8.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
			dataGridViewCellStyle8.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView_periferico_RT820.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.DataGridView_periferico_RT820.ScrollBars =(System.Windows.Forms.ScrollBars)0;
			global::System.Windows.Forms.Control dataGridView_periferico_RT2 = this.DataGridView_periferico_RT820;
			Size = new System.Drawing.Size(412, 111);
			dataGridView_periferico_RT2.Size = this.Size;
			this.DataGridView_periferico_RT820.TabIndex = 0;
			this.TabPage_repetidora.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.TabPage_repetidora.Controls.Add(this.GroupBox_end_rep_820);
			this.TabPage_repetidora.Controls.Add(this.GroupBox_parametros_repetidora_820);
			global::System.Windows.Forms.TabPage tabPage_repetidora = this.TabPage_repetidora;
tabPage_repetidora.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_repetidora.Name = "TabPage_repetidora";
			global::System.Windows.Forms.Control tabPage_repetidora2 = this.TabPage_repetidora;
			Size = new System.Drawing.Size(1294, 443);
			tabPage_repetidora2.Size = this.Size;
			this.TabPage_repetidora.TabIndex = 3;
			this.TabPage_repetidora.Text = "Repetidora";
			this.TabPage_repetidora.UseVisualStyleBackColor = true;
			this.GroupBox_end_rep_820.Controls.Add(this.DataGridView_end_rep_RT820);
			global::System.Windows.Forms.Control groupBox_end_rep_ = this.GroupBox_end_rep_820;
groupBox_end_rep_.Location = new global::System.Drawing.Point(20, 157);
			this.GroupBox_end_rep_820.Name = "GroupBox_end_rep_820";
			global::System.Windows.Forms.Control groupBox_end_rep_2 = this.GroupBox_end_rep_820;
			Size = new System.Drawing.Size(613, 282);
			groupBox_end_rep_2.Size = this.Size;
			this.GroupBox_end_rep_820.TabIndex = 4;
			this.GroupBox_end_rep_820.TabStop = false;
			this.GroupBox_end_rep_820.Text = "Endereço das estações a serem retransmitidas";
			this.DataGridView_end_rep_RT820.AllowUserToAddRows = false;
			this.DataGridView_end_rep_RT820.AllowUserToDeleteRows = false;
			this.DataGridView_end_rep_RT820.AllowUserToResizeColumns = false;
			this.DataGridView_end_rep_RT820.AllowUserToResizeRows = false;
			dataGridViewCellStyle9.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			this.DataGridView_end_rep_RT820.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
			dataGridViewCellStyle10.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
			dataGridViewCellStyle10.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView_end_rep_RT820.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.DataGridView_end_rep_RT820.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			dataGridViewCellStyle11.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
			dataGridViewCellStyle11.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle11.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView_end_rep_RT820.DefaultCellStyle = dataGridViewCellStyle11;
			global::System.Windows.Forms.Control dataGridView_end_rep_RT = this.DataGridView_end_rep_RT820;
dataGridView_end_rep_RT.Location = new global::System.Drawing.Point(17, 23);
			this.DataGridView_end_rep_RT820.Name = "DataGridView_end_rep_RT820";
			dataGridViewCellStyle12.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
			dataGridViewCellStyle12.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView_end_rep_RT820.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.DataGridView_end_rep_RT820.RowHeadersVisible = false;
			this.DataGridView_end_rep_RT820.ScrollBars =(System.Windows.Forms.ScrollBars)0;
			global::System.Windows.Forms.Control dataGridView_end_rep_RT2 = this.DataGridView_end_rep_RT820;
			Size = new System.Drawing.Size(578, 243);
			dataGridView_end_rep_RT2.Size = this.Size;
			this.DataGridView_end_rep_RT820.TabIndex = 0;
			this.GroupBox_parametros_repetidora_820.Controls.Add(this.Label29);
			this.GroupBox_parametros_repetidora_820.Controls.Add(this.cb_ModoRepetidora);
			this.GroupBox_parametros_repetidora_820.Controls.Add(this.NumericUpDown_num_est_rep_820);
			this.GroupBox_parametros_repetidora_820.Controls.Add(this.NumericUpDown_end_rep_820);
			this.GroupBox_parametros_repetidora_820.Controls.Add(this.Label_num_est_rep_820);
			this.GroupBox_parametros_repetidora_820.Controls.Add(this.Label_end_rep_820);
			this.GroupBox_parametros_repetidora_820.Controls.Add(this.tb_lixo7);
			this.GroupBox_parametros_repetidora_820.Enabled = false;
			global::System.Windows.Forms.Control groupBox_parametros_repetidora_ = this.GroupBox_parametros_repetidora_820;
groupBox_parametros_repetidora_.Location = new global::System.Drawing.Point(20, 20);
			this.GroupBox_parametros_repetidora_820.Name = "GroupBox_parametros_repetidora_820";
			global::System.Windows.Forms.Control groupBox_parametros_repetidora_2 = this.GroupBox_parametros_repetidora_820;
			Size = new System.Drawing.Size(253, 131);
			groupBox_parametros_repetidora_2.Size = this.Size;
			this.GroupBox_parametros_repetidora_820.TabIndex = 3;
			this.GroupBox_parametros_repetidora_820.TabStop = false;
			this.GroupBox_parametros_repetidora_820.Text = "Parâmetros da Repetidora";
			this.Label29.AutoSize = true;
			global::System.Windows.Forms.Control label85 = this.Label29;
label85.Location = new global::System.Drawing.Point(14, 31);
			this.Label29.Name = "Label29";
			global::System.Windows.Forms.Control label86 = this.Label29;
			Size = new System.Drawing.Size(92, 13);
			label86.Size = this.Size;
			this.Label29.TabIndex = 4;
			this.Label29.Text = "Modo Repetidora:";
			this.cb_ModoRepetidora.FormattingEnabled = true;
			global::System.Windows.Forms.Control cb_ModoRepetidora = this.cb_ModoRepetidora;
cb_ModoRepetidora.Location = new global::System.Drawing.Point(112, 29);
			this.cb_ModoRepetidora.Name = "cb_ModoRepetidora";
			global::System.Windows.Forms.Control cb_ModoRepetidora2 = this.cb_ModoRepetidora;
			Size = new System.Drawing.Size(121, 21);
			cb_ModoRepetidora2.Size = this.Size;
			this.cb_ModoRepetidora.TabIndex = 3;
			global::System.Windows.Forms.Control numericUpDown_num_est_rep_ = this.NumericUpDown_num_est_rep_820;
numericUpDown_num_est_rep_.Location = new global::System.Drawing.Point(161, 90);
			global::System.Windows.Forms.NumericUpDown numericUpDown_num_est_rep_2 = this.NumericUpDown_num_est_rep_820;
			num = new decimal(new int[]
			{
				50,
				0,
				0,
				0
			});
			numericUpDown_num_est_rep_2.Maximum = num;
			this.NumericUpDown_num_est_rep_820.Name = "NumericUpDown_num_est_rep_820";
			global::System.Windows.Forms.Control numericUpDown_num_est_rep_3 = this.NumericUpDown_num_est_rep_820;
			Size = new System.Drawing.Size(72, 20);
			numericUpDown_num_est_rep_3.Size = this.Size;
			this.NumericUpDown_num_est_rep_820.TabIndex = 2;
			this.NumericUpDown_num_est_rep_820.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.Control numericUpDown_end_rep_ = this.NumericUpDown_end_rep_820;
numericUpDown_end_rep_.Location = new global::System.Drawing.Point(161, 65);
			global::System.Windows.Forms.NumericUpDown numericUpDown_end_rep_2 = this.NumericUpDown_end_rep_820;
			num = new decimal(new int[]
			{
				200,
				0,
				0,
				0
			});
			numericUpDown_end_rep_2.Maximum = num;
			this.NumericUpDown_end_rep_820.Name = "NumericUpDown_end_rep_820";
			global::System.Windows.Forms.Control numericUpDown_end_rep_3 = this.NumericUpDown_end_rep_820;
			Size = new System.Drawing.Size(72, 20);
			numericUpDown_end_rep_3.Size = this.Size;
			this.NumericUpDown_end_rep_820.TabIndex = 1;
			this.NumericUpDown_end_rep_820.TextAlign = HorizontalAlignment.Right;
			this.Label_num_est_rep_820.AutoSize = true;
			global::System.Windows.Forms.Control label_num_est_rep_ = this.Label_num_est_rep_820;
label_num_est_rep_.Location = new global::System.Drawing.Point(14, 92);
			this.Label_num_est_rep_820.Name = "Label_num_est_rep_820";
			global::System.Windows.Forms.Control label_num_est_rep_2 = this.Label_num_est_rep_820;
			Size = new System.Drawing.Size(112, 13);
			label_num_est_rep_2.Size = this.Size;
			this.Label_num_est_rep_820.TabIndex = 2;
			this.Label_num_est_rep_820.Text = "Número de Estações :";
			this.Label_end_rep_820.AutoSize = true;
			global::System.Windows.Forms.Control label_end_rep_ = this.Label_end_rep_820;
label_end_rep_.Location = new global::System.Drawing.Point(14, 67);
			this.Label_end_rep_820.Name = "Label_end_rep_820";
			global::System.Windows.Forms.Control label_end_rep_2 = this.Label_end_rep_820;
			Size = new System.Drawing.Size(129, 13);
			label_end_rep_2.Size = this.Size;
			this.Label_end_rep_820.TabIndex = 1;
			this.Label_end_rep_820.Text = "Endereço da Repetidora :";
			global::System.Windows.Forms.Control tb_lixo11 = this.tb_lixo7;
tb_lixo11.Location = new global::System.Drawing.Point(161, 65);
			this.tb_lixo7.Name = "tb_lixo7";
			global::System.Windows.Forms.Control tb_lixo12 = this.tb_lixo7;
			Size = new System.Drawing.Size(41, 20);
			tb_lixo12.Size = this.Size;
			this.tb_lixo7.TabIndex = 8;
			this.TabPage1.Controls.Add(this.GroupBox1);
			global::System.Windows.Forms.TabPage tabPage = this.TabPage1;
tabPage.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			global::System.Windows.Forms.Control tabPage2 = this.TabPage1;
			Padding = new Padding(3);
			tabPage2.Padding = Padding;
			global::System.Windows.Forms.Control tabPage3 = this.TabPage1;
			Size = new System.Drawing.Size(1294, 443);
			tabPage3.Size = this.Size;
			this.TabPage1.TabIndex = 10;
			this.TabPage1.Text = "Dados de Instalação";
			this.TabPage1.UseVisualStyleBackColor = true;
			this.GroupBox1.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.GroupBox1.Controls.Add(this.Label16);
			this.GroupBox1.Controls.Add(this.Label15);
			this.GroupBox1.Controls.Add(this.T_ModeloFonte);
			this.GroupBox1.Controls.Add(this.T_AlturaAntena);
			this.GroupBox1.Controls.Add(this.T_Latitude);
			this.GroupBox1.Controls.Add(this.T_Longitude);
			this.GroupBox1.Controls.Add(this.T_Azimute);
			this.GroupBox1.Controls.Add(this.Label14);
			this.GroupBox1.Controls.Add(this.Label13);
			this.GroupBox1.Controls.Add(this.Label12);
			this.GroupBox1.Controls.Add(this.T_FreqRadio);
			this.GroupBox1.Controls.Add(this.T_DistCentral);
			this.GroupBox1.Controls.Add(this.T_PotRadio);
			this.GroupBox1.Controls.Add(this.CB_ModeloRadio);
			this.GroupBox1.Controls.Add(this.CB_PolarizacaoAntena);
			this.GroupBox1.Controls.Add(this.CB_TipoAntena);
			this.GroupBox1.Controls.Add(this.Label11);
			this.GroupBox1.Controls.Add(this.Label10);
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label17);
			this.GroupBox1.Controls.Add(this.tb_lixo8);
			global::System.Windows.Forms.Control groupBox13 = this.GroupBox1;
groupBox13.Location = new global::System.Drawing.Point(6, 6);
			this.GroupBox1.Name = "GroupBox1";
			global::System.Windows.Forms.Control groupBox14 = this.GroupBox1;
			Size = new System.Drawing.Size(788, 406);
			groupBox14.Size = this.Size;
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.Label16.AutoSize = true;
			this.Label16.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control label87 = this.Label16;
label87.Location = new global::System.Drawing.Point(580, 23);
			this.Label16.Name = "Label16";
			global::System.Windows.Forms.Control label88 = this.Label16;
			Size = new System.Drawing.Size(12, 16);
			label88.Size = this.Size;
			this.Label16.TabIndex = 26;
			this.Label16.Text = "°";
			this.Label15.AutoSize = true;
			global::System.Windows.Forms.Control label89 = this.Label15;
label89.Location = new global::System.Drawing.Point(580, 132);
			this.Label15.Name = "Label15";
			global::System.Windows.Forms.Control label90 = this.Label15;
			Size = new System.Drawing.Size(15, 13);
			label90.Size = this.Size;
			this.Label15.TabIndex = 25;
			this.Label15.Text = "m";
			global::System.Windows.Forms.Control t_ModeloFonte = this.T_ModeloFonte;
t_ModeloFonte.Location = new global::System.Drawing.Point(453, 157);
			this.T_ModeloFonte.Name = "T_ModeloFonte";
			global::System.Windows.Forms.Control t_ModeloFonte2 = this.T_ModeloFonte;
			Size = new System.Drawing.Size(121, 20);
			t_ModeloFonte2.Size = this.Size;
			this.T_ModeloFonte.TabIndex = 24;
			global::System.Windows.Forms.Control t_AlturaAntena = this.T_AlturaAntena;
t_AlturaAntena.Location = new global::System.Drawing.Point(453, 124);
			this.T_AlturaAntena.Name = "T_AlturaAntena";
			global::System.Windows.Forms.Control t_AlturaAntena2 = this.T_AlturaAntena;
			Size = new System.Drawing.Size(121, 20);
			t_AlturaAntena2.Size = this.Size;
			this.T_AlturaAntena.TabIndex = 23;
			global::System.Windows.Forms.Control t_Latitude = this.T_Latitude;
t_Latitude.Location = new global::System.Drawing.Point(453, 89);
			this.T_Latitude.Name = "T_Latitude";
			global::System.Windows.Forms.Control t_Latitude2 = this.T_Latitude;
			Size = new System.Drawing.Size(121, 20);
			t_Latitude2.Size = this.Size;
			this.T_Latitude.TabIndex = 22;
			global::System.Windows.Forms.Control t_Longitude = this.T_Longitude;
t_Longitude.Location = new global::System.Drawing.Point(453, 54);
			this.T_Longitude.Name = "T_Longitude";
			global::System.Windows.Forms.Control t_Longitude2 = this.T_Longitude;
			Size = new System.Drawing.Size(121, 20);
			t_Longitude2.Size = this.Size;
			this.T_Longitude.TabIndex = 21;
			global::System.Windows.Forms.Control t_Azimute = this.T_Azimute;
t_Azimute.Location = new global::System.Drawing.Point(453, 23);
			this.T_Azimute.Name = "T_Azimute";
			global::System.Windows.Forms.Control t_Azimute2 = this.T_Azimute;
			Size = new System.Drawing.Size(121, 20);
			t_Azimute2.Size = this.Size;
			this.T_Azimute.TabIndex = 20;
			this.Label14.AutoSize = true;
			global::System.Windows.Forms.Control label91 = this.Label14;
label91.Location = new global::System.Drawing.Point(275, 96);
			this.Label14.Name = "Label14";
			global::System.Windows.Forms.Control label92 = this.Label14;
			Size = new System.Drawing.Size(18, 13);
			label92.Size = this.Size;
			this.Label14.TabIndex = 19;
			this.Label14.Text = "W";
			this.Label13.AutoSize = true;
			global::System.Windows.Forms.Control label93 = this.Label13;
label93.Location = new global::System.Drawing.Point(275, 199);
			this.Label13.Name = "Label13";
			global::System.Windows.Forms.Control label94 = this.Label13;
			Size = new System.Drawing.Size(29, 13);
			label94.Size = this.Size;
			this.Label13.TabIndex = 18;
			this.Label13.Text = "MHz";
			this.Label12.AutoSize = true;
			global::System.Windows.Forms.Control label95 = this.Label12;
label95.Location = new global::System.Drawing.Point(275, 167);
			this.Label12.Name = "Label12";
			global::System.Windows.Forms.Control label96 = this.Label12;
			Size = new System.Drawing.Size(21, 13);
			label96.Size = this.Size;
			this.Label12.TabIndex = 17;
			this.Label12.Text = "km";
			global::System.Windows.Forms.Control t_FreqRadio = this.T_FreqRadio;
t_FreqRadio.Location = new global::System.Drawing.Point(148, 192);
			this.T_FreqRadio.Name = "T_FreqRadio";
			global::System.Windows.Forms.Control t_FreqRadio2 = this.T_FreqRadio;
			Size = new System.Drawing.Size(121, 20);
			t_FreqRadio2.Size = this.Size;
			this.T_FreqRadio.TabIndex = 16;
			global::System.Windows.Forms.Control t_DistCentral = this.T_DistCentral;
t_DistCentral.Location = new global::System.Drawing.Point(148, 160);
			this.T_DistCentral.Name = "T_DistCentral";
			global::System.Windows.Forms.Control t_DistCentral2 = this.T_DistCentral;
			Size = new System.Drawing.Size(121, 20);
			t_DistCentral2.Size = this.Size;
			this.T_DistCentral.TabIndex = 15;
			global::System.Windows.Forms.Control t_PotRadio = this.T_PotRadio;
t_PotRadio.Location = new global::System.Drawing.Point(148, 89);
			this.T_PotRadio.Name = "T_PotRadio";
			global::System.Windows.Forms.Control t_PotRadio2 = this.T_PotRadio;
			Size = new System.Drawing.Size(121, 20);
			t_PotRadio2.Size = this.Size;
			this.T_PotRadio.TabIndex = 14;
			this.CB_ModeloRadio.FormattingEnabled = true;
			this.CB_ModeloRadio.Items.AddRange(new object[]
			{
				"Não informado",
				"SD164 sem Modem",
				"SD164 com Modem",
				"SD174 sem Modem",
				"SD174 com Modem",
				"SD174E sem Modem",
				"SD174E com Modem",
				"SD125U1 - UHF ",
				"SD125",
				"SD125E1",
				"RNET450 - UHF",
				"DM0515 - VHF",
				"DM0530 - UHF"
			});
			global::System.Windows.Forms.Control cb_ModeloRadio = this.CB_ModeloRadio;
cb_ModeloRadio.Location = new global::System.Drawing.Point(148, 124);
			this.CB_ModeloRadio.Name = "CB_ModeloRadio";
			global::System.Windows.Forms.Control cb_ModeloRadio2 = this.CB_ModeloRadio;
			Size = new System.Drawing.Size(121, 21);
			cb_ModeloRadio2.Size = this.Size;
			this.CB_ModeloRadio.TabIndex = 13;
			this.CB_PolarizacaoAntena.FormattingEnabled = true;
			this.CB_PolarizacaoAntena.Items.AddRange(new object[]
			{
				"Horizontal",
				"Vertical"
			});
			global::System.Windows.Forms.Control cb_PolarizacaoAntena = this.CB_PolarizacaoAntena;
cb_PolarizacaoAntena.Location = new global::System.Drawing.Point(148, 54);
			this.CB_PolarizacaoAntena.Name = "CB_PolarizacaoAntena";
			global::System.Windows.Forms.Control cb_PolarizacaoAntena2 = this.CB_PolarizacaoAntena;
			Size = new System.Drawing.Size(121, 21);
			cb_PolarizacaoAntena2.Size = this.Size;
			this.CB_PolarizacaoAntena.TabIndex = 12;
			this.CB_TipoAntena.FormattingEnabled = true;
			this.CB_TipoAntena.Items.AddRange(new object[]
			{
				"Não Informado",
				"Omni",
				"Yagi",
				"Plano Terra"
			});
			global::System.Windows.Forms.Control cb_TipoAntena = this.CB_TipoAntena;
cb_TipoAntena.Location = new global::System.Drawing.Point(148, 27);
			this.CB_TipoAntena.Name = "CB_TipoAntena";
			global::System.Windows.Forms.Control cb_TipoAntena2 = this.CB_TipoAntena;
			Size = new System.Drawing.Size(121, 21);
			cb_TipoAntena2.Size = this.Size;
			this.CB_TipoAntena.TabIndex = 11;
			this.Label11.AutoSize = true;
			global::System.Windows.Forms.Control label97 = this.Label11;
label97.Location = new global::System.Drawing.Point(358, 160);
			this.Label11.Name = "Label11";
			global::System.Windows.Forms.Control label98 = this.Label11;
			Size = new System.Drawing.Size(87, 13);
			label98.Size = this.Size;
			this.Label11.TabIndex = 10;
			this.Label11.Text = "Modelo da fonte:";
			this.Label10.AutoSize = true;
			global::System.Windows.Forms.Control label99 = this.Label10;
label99.Location = new global::System.Drawing.Point(358, 127);
			this.Label10.Name = "Label10";
			global::System.Windows.Forms.Control label100 = this.Label10;
			Size = new System.Drawing.Size(37, 13);
			label100.Size = this.Size;
			this.Label10.TabIndex = 9;
			this.Label10.Text = "Altura:";
			this.Label9.AutoSize = true;
			global::System.Windows.Forms.Control label101 = this.Label9;
label101.Location = new global::System.Drawing.Point(358, 92);
			this.Label9.Name = "Label9";
			global::System.Windows.Forms.Control label102 = this.Label9;
			Size = new System.Drawing.Size(48, 13);
			label102.Size = this.Size;
			this.Label9.TabIndex = 8;
			this.Label9.Text = "Latitude:";
			this.Label8.AutoSize = true;
			global::System.Windows.Forms.Control label103 = this.Label8;
label103.Location = new global::System.Drawing.Point(358, 63);
			this.Label8.Name = "Label8";
			global::System.Windows.Forms.Control label104 = this.Label8;
			Size = new System.Drawing.Size(57, 13);
			label104.Size = this.Size;
			this.Label8.TabIndex = 7;
			this.Label8.Text = "Longitude:";
			this.Label7.AutoSize = true;
			global::System.Windows.Forms.Control label105 = this.Label7;
label105.Location = new global::System.Drawing.Point(358, 30);
			this.Label7.Name = "Label7";
			global::System.Windows.Forms.Control label106 = this.Label7;
			Size = new System.Drawing.Size(47, 13);
			label106.Size = this.Size;
			this.Label7.TabIndex = 6;
			this.Label7.Text = "Azimute:";
			this.Label6.AutoSize = true;
			global::System.Windows.Forms.Control label107 = this.Label6;
label107.Location = new global::System.Drawing.Point(16, 195);
			this.Label6.Name = "Label6";
			global::System.Windows.Forms.Control label108 = this.Label6;
			Size = new System.Drawing.Size(104, 13);
			label108.Size = this.Size;
			this.Label6.TabIndex = 5;
			this.Label6.Text = "Frequência do rádio:";
			this.Label5.AutoSize = true;
			global::System.Windows.Forms.Control label109 = this.Label5;
label109.Location = new global::System.Drawing.Point(16, 160);
			this.Label5.Name = "Label5";
			global::System.Windows.Forms.Control label110 = this.Label5;
			Size = new System.Drawing.Size(122, 13);
			label110.Size = this.Size;
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Distância para a central:";
			this.Label4.AutoSize = true;
			global::System.Windows.Forms.Control label111 = this.Label4;
label111.Location = new global::System.Drawing.Point(16, 127);
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control label112 = this.Label4;
			Size = new System.Drawing.Size(86, 13);
			label112.Size = this.Size;
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Modelo do rádio:";
			this.Label3.AutoSize = true;
			global::System.Windows.Forms.Control label113 = this.Label3;
label113.Location = new global::System.Drawing.Point(16, 96);
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label114 = this.Label3;
			Size = new System.Drawing.Size(93, 13);
			label114.Size = this.Size;
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Potência do rádio:";
			this.Label2.AutoSize = true;
			global::System.Windows.Forms.Control label115 = this.Label2;
label115.Location = new global::System.Drawing.Point(16, 63);
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label116 = this.Label2;
			Size = new System.Drawing.Size(65, 13);
			label116.Size = this.Size;
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Polarização:";
			this.Label17.AutoSize = true;
			global::System.Windows.Forms.Control label117 = this.Label17;
label117.Location = new global::System.Drawing.Point(16, 30);
			this.Label17.Name = "Label17";
			global::System.Windows.Forms.Control label118 = this.Label17;
			Size = new System.Drawing.Size(83, 13);
			label118.Size = this.Size;
			this.Label17.TabIndex = 0;
			this.Label17.Text = "Tipo de Antena:";
			global::System.Windows.Forms.Control tb_lixo13 = this.tb_lixo8;
tb_lixo13.Location = new global::System.Drawing.Point(148, 160);
			this.tb_lixo8.Name = "tb_lixo8";
			global::System.Windows.Forms.Control tb_lixo14 = this.tb_lixo8;
			Size = new System.Drawing.Size(41, 20);
			tb_lixo14.Size = this.Size;
			this.tb_lixo8.TabIndex = 27;
			this.ToolStri_RT_820.AutoSize = false;
			this.ToolStri_RT_820.BackColor = global::System.Drawing.Color.Transparent;
			this.ToolStri_RT_820.GripStyle = 0;
			global::System.Windows.Forms.ToolStrip toolStri_RT_ = this.ToolStri_RT_820;
			Size = new System.Drawing.Size(48, 48);
			toolStri_RT_.ImageScalingSize = Size;
			this.ToolStri_RT_820.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripButton_RT_820_novo,
				this.ToolStripButton_RT_820_Abrir,
				this.ToolStripButton_RT_820_Salvar,
				this.ToolStripSeparator1,
				this.ToolStripButton_RT_820_Download,
				this.ToolStripButton_RT_820_Upload,
				this.ToolStripSeparator2,
				this.ToolStripButton_RT820_Imprimir,
				this.ToolStripSeparator3,
				this.ToolStripLabel_ID,
				this.ToolStripSeparator4,
				this.ToolStripTextBox_RT_820_Msg,
				this.ToolStripProgressBar_RT_820
			});
			this.ToolStri_RT_820.LayoutStyle =(System.Windows.Forms.ToolStripLayoutStyle)3;
			global::System.Windows.Forms.Control toolStri_RT_2 = this.ToolStri_RT_820;
toolStri_RT_2.Location = new global::System.Drawing.Point(0, 0);
			this.ToolStri_RT_820.Name = "ToolStri_RT_820";
			global::System.Windows.Forms.Control toolStri_RT_3 = this.ToolStri_RT_820;
			Size = new System.Drawing.Size(1324, 55);
			toolStri_RT_3.Size = this.Size;
			this.ToolStri_RT_820.Stretch = true;
			this.ToolStri_RT_820.TabIndex = 13;
			this.ToolStri_RT_820.Text = "ToolStrip1";
			this.ToolStripButton_RT_820_novo.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT_820_novo.Image = global::iS800.My.Resources.Resources.folder_add_icon1;
			this.ToolStripButton_RT_820_novo.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT_820_novo = this.ToolStripButton_RT_820_novo;
			Padding = new Padding(10, 1, 0, 2);
			toolStripButton_RT_820_novo.Margin = Padding;
			this.ToolStripButton_RT_820_novo.Name = "ToolStripButton_RT_820_novo";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT_820_novo2 = this.ToolStripButton_RT_820_novo;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT_820_novo2.Size = this.Size;
			this.ToolStripButton_RT_820_novo.Text = "Novo";
			this.ToolStripButton_RT_820_Abrir.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT_820_Abrir.Image = global::iS800.My.Resources.Resources.folder_up_icon;
			this.ToolStripButton_RT_820_Abrir.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton_RT_820_Abrir.Name = "ToolStripButton_RT_820_Abrir";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT_820_Abrir = this.ToolStripButton_RT_820_Abrir;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT_820_Abrir.Size = this.Size;
			this.ToolStripButton_RT_820_Abrir.Text = "Abrir Arquivo";
			this.ToolStripButton_RT_820_Abrir.ToolTipText = "Abrir arquivo";
			this.ToolStripButton_RT_820_Salvar.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT_820_Salvar.Image = global::iS800.My.Resources.Resources.folder_down_icon;
			this.ToolStripButton_RT_820_Salvar.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton_RT_820_Salvar.Name = "ToolStripButton_RT_820_Salvar";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT_820_Salvar = this.ToolStripButton_RT_820_Salvar;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT_820_Salvar.Size = this.Size;
			this.ToolStripButton_RT_820_Salvar.Text = "Salvar Arquivo";
			this.ToolStripSeparator1.AutoSize = false;
			global::System.Windows.Forms.ToolStripItem toolStripSeparator = this.ToolStripSeparator1;
			Padding = new Padding(10, 0, 0, 0);
			toolStripSeparator.Margin = Padding;
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			global::System.Windows.Forms.ToolStripItem toolStripSeparator2 = this.ToolStripSeparator1;
			Size = new System.Drawing.Size(6, 52);
			toolStripSeparator2.Size = this.Size;
			this.ToolStripButton_RT_820_Download.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT_820_Download.Image = global::iS800.My.Resources.Resources.Upload_icon;
			this.ToolStripButton_RT_820_Download.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT_820_Download = this.ToolStripButton_RT_820_Download;
			Padding = new Padding(10, 1, 0, 2);
			toolStripButton_RT_820_Download.Margin = Padding;
			this.ToolStripButton_RT_820_Download.Name = "ToolStripButton_RT_820_Download";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT_820_Download2 = this.ToolStripButton_RT_820_Download;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT_820_Download2.Size = this.Size;
			this.ToolStripButton_RT_820_Download.Text = "Ler do equipamento";
			this.ToolStripButton_RT_820_Upload.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT_820_Upload.Image = global::iS800.My.Resources.Resources.Download_icon;
			this.ToolStripButton_RT_820_Upload.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton_RT_820_Upload.Name = "ToolStripButton_RT_820_Upload";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT_820_Upload = this.ToolStripButton_RT_820_Upload;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT_820_Upload.Size = this.Size;
			this.ToolStripButton_RT_820_Upload.Text = "Gravar no equipamento";
			this.ToolStripSeparator2.AutoSize = false;
			global::System.Windows.Forms.ToolStripItem toolStripSeparator3 = this.ToolStripSeparator2;
			Padding = new Padding(10, 0, 0, 0);
			toolStripSeparator3.Margin = Padding;
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			global::System.Windows.Forms.ToolStripItem toolStripSeparator4 = this.ToolStripSeparator2;
			Size = new System.Drawing.Size(6, 52);
			toolStripSeparator4.Size = this.Size;
			this.ToolStripButton_RT820_Imprimir.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT820_Imprimir.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton_RT820_Imprimir.Image");
			this.ToolStripButton_RT820_Imprimir.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton_RT820_Imprimir.Name = "ToolStripButton_RT820_Imprimir";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT820_Imprimir = this.ToolStripButton_RT820_Imprimir;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT820_Imprimir.Size = this.Size;
			this.ToolStripButton_RT820_Imprimir.Text = "Impressão da ficha de configuração";
			this.ToolStripSeparator3.AutoSize = false;
			this.ToolStripSeparator3.Name = "ToolStripSeparator3";
			global::System.Windows.Forms.ToolStripItem toolStripSeparator5 = this.ToolStripSeparator3;
			Size = new System.Drawing.Size(6, 52);
			toolStripSeparator5.Size = this.Size;
			this.ToolStripLabel_ID.Font = new global::System.Drawing.Font("Arial Narrow", 18f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ToolStripLabel_ID.ForeColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			global::System.Windows.Forms.ToolStripItem toolStripLabel_ID = this.ToolStripLabel_ID;
			Padding = new Padding(5, 13, 0, 2);
			toolStripLabel_ID.Margin = Padding;
			this.ToolStripLabel_ID.Name = "ToolStripLabel_ID";
			global::System.Windows.Forms.ToolStripItem toolStripLabel_ID2 = this.ToolStripLabel_ID;
			Size = new System.Drawing.Size(110, 29);
			toolStripLabel_ID2.Size = this.Size;
			this.ToolStripLabel_ID.Text = "RT820/200";
			this.ToolStripSeparator4.AutoSize = false;
			this.ToolStripSeparator4.Name = "ToolStripSeparator4";
			global::System.Windows.Forms.ToolStripItem toolStripSeparator6 = this.ToolStripSeparator4;
			Size = new System.Drawing.Size(6, 52);
			toolStripSeparator6.Size = this.Size;
			this.ToolStripTextBox_RT_820_Msg.BackColor = global::System.Drawing.Color.LightCyan;
			this.ToolStripTextBox_RT_820_Msg.BorderStyle = BorderStyle.FixedSingle;
			this.ToolStripTextBox_RT_820_Msg.Font = new global::System.Drawing.Font("Cambria", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.ToolStripItem toolStripTextBox_RT_820_Msg = this.ToolStripTextBox_RT_820_Msg;
			Padding = new Padding(10, 15, 1, 0);
			toolStripTextBox_RT_820_Msg.Margin = Padding;
			this.ToolStripTextBox_RT_820_Msg.Name = "ToolStripTextBox_RT_820_Msg";
			this.ToolStripTextBox_RT_820_Msg.ReadOnly = true;
			global::System.Windows.Forms.ToolStripControlHost toolStripTextBox_RT_820_Msg2 = this.ToolStripTextBox_RT_820_Msg;
			Size = new System.Drawing.Size(250, 23);
			toolStripTextBox_RT_820_Msg2.Size = this.Size;
			this.ToolStripTextBox_RT_820_Msg.TextBoxTextAlign = (System.Windows.Forms.HorizontalAlignment)2;
			this.ToolStripProgressBar_RT_820.BackColor = global::System.Drawing.SystemColors.Control;
			global::System.Windows.Forms.ToolStripItem toolStripProgressBar_RT_ = this.ToolStripProgressBar_RT_820;
			Padding = new Padding(20, 15, 1, 1);
			toolStripProgressBar_RT_.Margin = Padding;
			this.ToolStripProgressBar_RT_820.Name = "ToolStripProgressBar_RT_820";
			this.ToolStripProgressBar_RT_820.Overflow = 0;
			global::System.Windows.Forms.ToolStripControlHost toolStripProgressBar_RT_2 = this.ToolStripProgressBar_RT_820;
			Size = new System.Drawing.Size(180, 20);
			toolStripProgressBar_RT_2.Size = this.Size;
			this.ToolStripProgressBar_RT_820.ToolTipText = "Progresso da operação";
			this.Timer_limpa_MSG_820.Interval = 2000;
			global::System.Windows.Forms.PrintPreviewDialog printPreviewDialog = this.PrintPreviewDialog1;
			Size = new System.Drawing.Size(0, 0);
			printPreviewDialog.AutoScrollMargin = Size;
			global::System.Windows.Forms.PrintPreviewDialog printPreviewDialog2 = this.PrintPreviewDialog1;
			Size = new System.Drawing.Size(0, 0);
			printPreviewDialog2.AutoScrollMinSize = Size;
			global::System.Windows.Forms.Form printPreviewDialog3 = this.PrintPreviewDialog1;
			Size = new System.Drawing.Size(400, 300);
			printPreviewDialog3.ClientSize = Size;
			this.PrintPreviewDialog1.Document = this.PrintDocument1;
			this.PrintPreviewDialog1.Enabled = true;
			this.PrintPreviewDialog1.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("PrintPreviewDialog1.Icon");
			this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
			this.PrintPreviewDialog1.Visible = false;
			this.PrintDialog1.UseEXDialog = true;
			global::System.Drawing.SizeF autoScaleDimensions;
			autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ControlLight;
			Size = new System.Drawing.Size(1324, 556);
			this.ClientSize = Size;
			this.Controls.Add(this.ToolStri_RT_820);
			this.Controls.Add(this.TabControl_820);
			this.Name = "RT_820_200_conf";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Configuração";
			this.GroupBox_sistema_leitura.ResumeLayout(false);
			this.GroupBox_sistema_leitura.PerformLayout();
			this.GroupBox_operacao.ResumeLayout(false);
			this.GroupBox_operacao.PerformLayout();
			
			this.GroupBox_informacoes.ResumeLayout(false);
			this.GroupBox_informacoes.PerformLayout();
			this.GroupBox_modelo_simulado.ResumeLayout(false);
			this.GroupBox_comunicacao.ResumeLayout(false);
			this.GroupBox_comunicacao.PerformLayout();
			
			
			
			this.TabControl_820.ResumeLayout(false);
			this.TabPage_geral.ResumeLayout(false);
			this.GroupBox_descricao_RT820.ResumeLayout(false);
			this.GroupBox_descricao_RT820.PerformLayout();
			this.GroupBox_informacoes_820.ResumeLayout(false);
			this.GroupBox_informacoes_820.PerformLayout();
			this.GroupBox_comunicacao_820.ResumeLayout(false);
			this.GroupBox_comunicacao_820.PerformLayout();
			
			
			
			this.TabPage_EA.ResumeLayout(false);
			this.GroupBox_EA_820.ResumeLayout(false);
			this.GroupBox_EA_820.PerformLayout();
			
			
			this.TabPage_controle.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.TabPage_ED.ResumeLayout(false);
			this.GroupBox_ED_820.ResumeLayout(false);
			
			this.TabPage_setpoints.ResumeLayout(false);
			this.GroupBox7.ResumeLayout(false);
			this.GroupBox7.PerformLayout();
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			
			
			
			
			
			
			
			
			
			
			this.TabPage_MotoresValvulas.ResumeLayout(false);
			this.GroupBox6.ResumeLayout(false);
			this.GroupBox6.PerformLayout();
			
			
			
			
			
			
			
			
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			
			
			
			
			
			
			
			
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			
			
			
			
			this.TabPage_vazao_perifericos.ResumeLayout(false);
			this.GroupBox_perifericos_820.ResumeLayout(false);
			
			this.TabPage_repetidora.ResumeLayout(false);
			this.GroupBox_end_rep_820.ResumeLayout(false);
			
			this.GroupBox_parametros_repetidora_820.ResumeLayout(false);
			this.GroupBox_parametros_repetidora_820.PerformLayout();
			
			
			this.TabPage1.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ToolStri_RT_820.ResumeLayout(false);
			this.ToolStri_RT_820.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x0400050D RID: 1293
		private global::System.ComponentModel.IContainer components;
	}
}
