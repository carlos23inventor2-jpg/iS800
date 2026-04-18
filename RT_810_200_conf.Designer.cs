using System.Drawing;
using System.Windows.Forms;
﻿namespace iS800
{
	// Token: 0x02000034 RID: 52
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class RT_810_200_conf : global::System.Windows.Forms.Form
	{
		// Token: 0x0600041F RID: 1055 RVA: 0x0028D6E4 File Offset: 0x0028BAE4
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

		// Token: 0x06000420 RID: 1056 RVA: 0x0028D724 File Offset: 0x0028BB24
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
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::iS800.RT_810_200_conf));
			this.TabControl_810 = new global::System.Windows.Forms.TabControl();
			this.TabPage_geral = new global::System.Windows.Forms.TabPage();
			this.GroupBox_descricao_RT810 = new global::System.Windows.Forms.GroupBox();
			this.TextBox_comentarios_RT810 = new global::System.Windows.Forms.TextBox();
			this.TextBox_endereco_RT810 = new global::System.Windows.Forms.TextBox();
			this.TextBox_nome_RT810 = new global::System.Windows.Forms.TextBox();
			this.Label_comentarios = new global::System.Windows.Forms.Label();
			this.Label_endereco = new global::System.Windows.Forms.Label();
			this.Label_nome = new global::System.Windows.Forms.Label();
			this.GroupBox_sistema_leitura = new global::System.Windows.Forms.GroupBox();
			this.cb_ModoLeituraNivel = new global::System.Windows.Forms.ComboBox();
			this.GroupBox_ModoOperacao = new global::System.Windows.Forms.GroupBox();
			this.ComboBox_Modo_Operacao = new global::System.Windows.Forms.ComboBox();
			this.NumericUpDown_intervalo_tx = new global::System.Windows.Forms.NumericUpDown();
			this.lb_ModoOperacao = new global::System.Windows.Forms.Label();
			this.lb_IntervaloTX = new global::System.Windows.Forms.Label();
			this.GroupBox_informacoes = new global::System.Windows.Forms.GroupBox();
			this.Label26 = new global::System.Windows.Forms.Label();
			this.TextBox_equipamento = new global::System.Windows.Forms.TextBox();
			this.Label_equipamento = new global::System.Windows.Forms.Label();
			this.TextBox_release = new global::System.Windows.Forms.TextBox();
			this.Label_release = new global::System.Windows.Forms.Label();
			this.TextBox_build = new global::System.Windows.Forms.TextBox();
			this.Label_build = new global::System.Windows.Forms.Label();
			this.TextBox_versao = new global::System.Windows.Forms.TextBox();
			this.Label_versao = new global::System.Windows.Forms.Label();
			this.tb_lixo1 = new global::System.Windows.Forms.TextBox();
			this.GroupBox_comunicacao = new global::System.Windows.Forms.GroupBox();
			this.lb_PTT = new global::System.Windows.Forms.Label();
			this.lb_EndMestre = new global::System.Windows.Forms.Label();
			this.lb_EndEst = new global::System.Windows.Forms.Label();
			this.NumericUpDown_temp_ptt = new global::System.Windows.Forms.NumericUpDown();
			this.NumericUpDown_end_mestre = new global::System.Windows.Forms.NumericUpDown();
			this.NumericUpDown_end_est = new global::System.Windows.Forms.NumericUpDown();
			this.TabPage_EA = new global::System.Windows.Forms.TabPage();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.lb_ErroOffsetSensor = new global::System.Windows.Forms.Label();
			this.NumericUpDown_errooffsetsensor = new global::System.Windows.Forms.NumericUpDown();
			this.lb_AlturaReservatorio = new global::System.Windows.Forms.Label();
			this.NumericUpDown_rangesensor = new global::System.Windows.Forms.NumericUpDown();
			this.lb_RangeSensor = new global::System.Windows.Forms.Label();
			this.NumericUpDown_alturareservatorio = new global::System.Windows.Forms.NumericUpDown();
			this.GroupBox_EA = new global::System.Windows.Forms.GroupBox();
			this.NumericUpDown_intervalo_filtro = new global::System.Windows.Forms.NumericUpDown();
			this.NumericUpDown_tamanho_filtro = new global::System.Windows.Forms.NumericUpDown();
			this.lb_Intervalo = new global::System.Windows.Forms.Label();
			this.lb_Amostras = new global::System.Windows.Forms.Label();
			this.tb_lixo2 = new global::System.Windows.Forms.TextBox();
			this.TabPage_ED = new global::System.Windows.Forms.TabPage();
			this.GroupBox_ED = new global::System.Windows.Forms.GroupBox();
			this.Label25 = new global::System.Windows.Forms.Label();
			this.Label24 = new global::System.Windows.Forms.Label();
			this.Label23 = new global::System.Windows.Forms.Label();
			this.Label22 = new global::System.Windows.Forms.Label();
			this.Label21 = new global::System.Windows.Forms.Label();
			this.Label20 = new global::System.Windows.Forms.Label();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.Label18 = new global::System.Windows.Forms.Label();
			this.Label17 = new global::System.Windows.Forms.Label();
			this.TabPage_repetidora = new global::System.Windows.Forms.TabPage();
			this.GroupBox_end_rep = new global::System.Windows.Forms.GroupBox();
			this.DataGridView_end_rep_RT_810 = new global::System.Windows.Forms.DataGridView();
			this.Posicao_1_10 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.End_01_10 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Posicao_11_20 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.End_11_20 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Posicao_21_30 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.End_21_30 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Posicao_31_40 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.End_31_40 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Posicao_41_50 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.End_41_50 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GroupBox_parametros_repetidora = new global::System.Windows.Forms.GroupBox();
			this.ComboBox_modo_repeticao_RT_810 = new global::System.Windows.Forms.ComboBox();
			this.Label_modo_rep_RT_810 = new global::System.Windows.Forms.Label();
			this.NumericUpDown_num_est_rep = new global::System.Windows.Forms.NumericUpDown();
			this.NumericUpDown_end_rep = new global::System.Windows.Forms.NumericUpDown();
			this.Label_num_est_rep = new global::System.Windows.Forms.Label();
			this.Label_end_rep = new global::System.Windows.Forms.Label();
			this.tb_lixo3 = new global::System.Windows.Forms.TextBox();
			this.TabPage_dadosinstalacao = new global::System.Windows.Forms.TabPage();
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
			this.Label1 = new global::System.Windows.Forms.Label();
			this.tb_lixo4 = new global::System.Windows.Forms.TextBox();
			this.ToolStri_RT_810 = new global::System.Windows.Forms.ToolStrip();
			this.ToolStripButton_RT_810_novo = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripButton_RT_810_Abrir = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripButton_RT_810_Salvar = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ToolStripButton_RT_810_Download = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripButton_RT_810_Upload = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ToolStripButton_RT_810_Imprimir = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ToolStripLabel_ID = new global::System.Windows.Forms.ToolStripLabel();
			this.ToolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ToolStripTextBox_RT_810_Msg = new global::System.Windows.Forms.ToolStripTextBox();
			this.ToolStripProgressBar_RT_810 = new global::System.Windows.Forms.ToolStripProgressBar();
			this.OpenFileDialog_RT_810 = new global::System.Windows.Forms.OpenFileDialog();
			this.SaveFileDialog_RT_810 = new global::System.Windows.Forms.SaveFileDialog();
			this.Timer_limpa_MSG = new global::System.Windows.Forms.Timer(this.components);
			this.PrintDocument1 = new global::System.Drawing.Printing.PrintDocument();
			this.PrintPreviewDialog1 = new global::System.Windows.Forms.PrintPreviewDialog();
			this.RepetidoraBindingSource1 = new global::System.Windows.Forms.BindingSource(this.components);
			this.TabControl_810.SuspendLayout();
			this.TabPage_geral.SuspendLayout();
			this.GroupBox_descricao_RT810.SuspendLayout();
			this.GroupBox_sistema_leitura.SuspendLayout();
			this.GroupBox_ModoOperacao.SuspendLayout();
			
			this.GroupBox_informacoes.SuspendLayout();
			this.GroupBox_comunicacao.SuspendLayout();
			
			
			
			this.TabPage_EA.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			
			
			
			this.GroupBox_EA.SuspendLayout();
			
			
			this.TabPage_ED.SuspendLayout();
			this.GroupBox_ED.SuspendLayout();
			this.TabPage_repetidora.SuspendLayout();
			this.GroupBox_end_rep.SuspendLayout();
			
			this.GroupBox_parametros_repetidora.SuspendLayout();
			
			
			this.TabPage_dadosinstalacao.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.ToolStri_RT_810.SuspendLayout();
			
			this.SuspendLayout();
			this.TabControl_810.Controls.Add(this.TabPage_geral);
			this.TabControl_810.Controls.Add(this.TabPage_EA);
			this.TabControl_810.Controls.Add(this.TabPage_ED);
			this.TabControl_810.Controls.Add(this.TabPage_repetidora);
			this.TabControl_810.Controls.Add(this.TabPage_dadosinstalacao);
			this.TabControl_810.HotTrack = true;
			global::System.Windows.Forms.Control tabControl_ = this.TabControl_810;
			tabControl_.Location = new global::System.Drawing.Point(10, 66);
			this.TabControl_810.Name = "TabControl_810";
			this.TabControl_810.SelectedIndex = 0;
			global::System.Windows.Forms.Control tabControl_2 = this.TabControl_810;
			tabControl_2.Size = new global::System.Drawing.Size(1043, 464);
			this.TabControl_810.TabIndex = 1;
			this.TabPage_geral.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.TabPage_geral.Controls.Add(this.GroupBox_descricao_RT810);
			this.TabPage_geral.Controls.Add(this.GroupBox_sistema_leitura);
			this.TabPage_geral.Controls.Add(this.GroupBox_ModoOperacao);
			this.TabPage_geral.Controls.Add(this.GroupBox_informacoes);
			this.TabPage_geral.Controls.Add(this.GroupBox_comunicacao);
			global::System.Windows.Forms.TabPage tabPage_geral = this.TabPage_geral;
tabPage_geral.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_geral.Name = "TabPage_geral";
			global::System.Windows.Forms.Control tabPage_geral2 = this.TabPage_geral;
			global::System.Windows.Forms.Padding Padding;
			Padding = new global::System.Windows.Forms.Padding(3);
			tabPage_geral2.Padding = Padding;
			global::System.Windows.Forms.Control tabPage_geral3 = this.TabPage_geral;
			Size = new System.Drawing.Size(1035, 438);
			tabPage_geral3.Size = this.Size;
			this.TabPage_geral.TabIndex = 0;
			this.TabPage_geral.Text = "Geral";
			this.TabPage_geral.UseVisualStyleBackColor = true;
			this.GroupBox_descricao_RT810.Controls.Add(this.TextBox_comentarios_RT810);
			this.GroupBox_descricao_RT810.Controls.Add(this.TextBox_endereco_RT810);
			this.GroupBox_descricao_RT810.Controls.Add(this.TextBox_nome_RT810);
			this.GroupBox_descricao_RT810.Controls.Add(this.Label_comentarios);
			this.GroupBox_descricao_RT810.Controls.Add(this.Label_endereco);
			this.GroupBox_descricao_RT810.Controls.Add(this.Label_nome);
			global::System.Windows.Forms.Control groupBox_descricao_RT = this.GroupBox_descricao_RT810;
groupBox_descricao_RT.Location = new global::System.Drawing.Point(336, 102);
			this.GroupBox_descricao_RT810.Name = "GroupBox_descricao_RT810";
			global::System.Windows.Forms.Control groupBox_descricao_RT2 = this.GroupBox_descricao_RT810;
			Size = new System.Drawing.Size(456, 241);
			groupBox_descricao_RT2.Size = this.Size;
			this.GroupBox_descricao_RT810.TabIndex = 10;
			this.GroupBox_descricao_RT810.TabStop = false;
			this.GroupBox_descricao_RT810.Text = "Descrição";
			global::System.Windows.Forms.Control textBox_comentarios_RT = this.TextBox_comentarios_RT810;
textBox_comentarios_RT.Location = new global::System.Drawing.Point(26, 98);
			this.TextBox_comentarios_RT810.MaxLength = 400;
			this.TextBox_comentarios_RT810.Multiline = true;
			this.TextBox_comentarios_RT810.Name = "TextBox_comentarios_RT810";
			global::System.Windows.Forms.Control textBox_comentarios_RT2 = this.TextBox_comentarios_RT810;
			Size = new System.Drawing.Size(398, 128);
			textBox_comentarios_RT2.Size = this.Size;
			this.TextBox_comentarios_RT810.TabIndex = 3;
			global::System.Windows.Forms.Control textBox_endereco_RT = this.TextBox_endereco_RT810;
textBox_endereco_RT.Location = new global::System.Drawing.Point(88, 53);
			this.TextBox_endereco_RT810.MaxLength = 60;
			this.TextBox_endereco_RT810.Name = "TextBox_endereco_RT810";
			global::System.Windows.Forms.Control textBox_endereco_RT2 = this.TextBox_endereco_RT810;
			Size = new System.Drawing.Size(336, 20);
			textBox_endereco_RT2.Size = this.Size;
			this.TextBox_endereco_RT810.TabIndex = 2;
			global::System.Windows.Forms.Control textBox_nome_RT = this.TextBox_nome_RT810;
textBox_nome_RT.Location = new global::System.Drawing.Point(88, 27);
			this.TextBox_nome_RT810.MaxLength = 60;
			this.TextBox_nome_RT810.Name = "TextBox_nome_RT810";
			global::System.Windows.Forms.Control textBox_nome_RT2 = this.TextBox_nome_RT810;
			Size = new System.Drawing.Size(336, 20);
			textBox_nome_RT2.Size = this.Size;
			this.TextBox_nome_RT810.TabIndex = 1;
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
			this.GroupBox_sistema_leitura.Controls.Add(this.cb_ModoLeituraNivel);
			this.GroupBox_sistema_leitura.Enabled = false;
			global::System.Windows.Forms.Control groupBox_sistema_leitura = this.GroupBox_sistema_leitura;
groupBox_sistema_leitura.Location = new global::System.Drawing.Point(20, 258);
			this.GroupBox_sistema_leitura.Name = "GroupBox_sistema_leitura";
			global::System.Windows.Forms.Control groupBox_sistema_leitura2 = this.GroupBox_sistema_leitura;
			Size = new System.Drawing.Size(291, 85);
			groupBox_sistema_leitura2.Size = this.Size;
			this.GroupBox_sistema_leitura.TabIndex = 9;
			this.GroupBox_sistema_leitura.TabStop = false;
			this.GroupBox_sistema_leitura.Text = "Modo de Leitura de Nível";
			this.cb_ModoLeituraNivel.FormattingEnabled = true;
			global::System.Windows.Forms.Control cb_ModoLeituraNivel = this.cb_ModoLeituraNivel;
cb_ModoLeituraNivel.Location = new global::System.Drawing.Point(24, 19);
			this.cb_ModoLeituraNivel.Name = "cb_ModoLeituraNivel";
			global::System.Windows.Forms.Control cb_ModoLeituraNivel2 = this.cb_ModoLeituraNivel;
			Size = new System.Drawing.Size(252, 21);
			cb_ModoLeituraNivel2.Size = this.Size;
			this.cb_ModoLeituraNivel.TabIndex = 1;
			this.GroupBox_ModoOperacao.Controls.Add(this.ComboBox_Modo_Operacao);
			this.GroupBox_ModoOperacao.Controls.Add(this.NumericUpDown_intervalo_tx);
			this.GroupBox_ModoOperacao.Controls.Add(this.lb_ModoOperacao);
			this.GroupBox_ModoOperacao.Controls.Add(this.lb_IntervaloTX);
			this.GroupBox_ModoOperacao.Enabled = false;
			global::System.Windows.Forms.Control groupBox_ModoOperacao = this.GroupBox_ModoOperacao;
groupBox_ModoOperacao.Location = new global::System.Drawing.Point(20, 147);
			this.GroupBox_ModoOperacao.Name = "GroupBox_ModoOperacao";
			global::System.Windows.Forms.Control groupBox_ModoOperacao2 = this.GroupBox_ModoOperacao;
			Size = new System.Drawing.Size(291, 94);
			groupBox_ModoOperacao2.Size = this.Size;
			this.GroupBox_ModoOperacao.TabIndex = 8;
			this.GroupBox_ModoOperacao.TabStop = false;
			this.GroupBox_ModoOperacao.Text = "Modo de Operação";
			this.ComboBox_Modo_Operacao.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox_Modo_Operacao = this.ComboBox_Modo_Operacao;
comboBox_Modo_Operacao.Location = new global::System.Drawing.Point(132, 28);
			this.ComboBox_Modo_Operacao.Name = "ComboBox_Modo_Operacao";
			global::System.Windows.Forms.Control comboBox_Modo_Operacao2 = this.ComboBox_Modo_Operacao;
			Size = new System.Drawing.Size(144, 21);
			comboBox_Modo_Operacao2.Size = this.Size;
			this.ComboBox_Modo_Operacao.TabIndex = 0;
			this.NumericUpDown_intervalo_tx.Enabled = false;
			global::System.Windows.Forms.Control numericUpDown_intervalo_tx = this.NumericUpDown_intervalo_tx;
numericUpDown_intervalo_tx.Location = new global::System.Drawing.Point(204, 56);
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
			this.lb_ModoOperacao.AutoSize = true;
			global::System.Windows.Forms.Control lb_ModoOperacao = this.lb_ModoOperacao;
lb_ModoOperacao.Location = new global::System.Drawing.Point(21, 31);
			this.lb_ModoOperacao.Name = "lb_ModoOperacao";
			global::System.Windows.Forms.Control lb_ModoOperacao2 = this.lb_ModoOperacao;
			Size = new System.Drawing.Size(102, 13);
			lb_ModoOperacao2.Size = this.Size;
			this.lb_ModoOperacao.TabIndex = 3;
			this.lb_ModoOperacao.Text = "Modo de Operação:";
			this.lb_IntervaloTX.AutoSize = true;
			this.lb_IntervaloTX.Enabled = false;
			global::System.Windows.Forms.Control lb_IntervaloTX = this.lb_IntervaloTX;
lb_IntervaloTX.Location = new global::System.Drawing.Point(21, 58);
			this.lb_IntervaloTX.Name = "lb_IntervaloTX";
			global::System.Windows.Forms.Control lb_IntervaloTX2 = this.lb_IntervaloTX;
			Size = new System.Drawing.Size(142, 13);
			lb_IntervaloTX2.Size = this.Size;
			this.lb_IntervaloTX.TabIndex = 4;
			this.lb_IntervaloTX.Text = "Intrevalo de Transmissão (s):";
			this.GroupBox_informacoes.Controls.Add(this.Label26);
			this.GroupBox_informacoes.Controls.Add(this.TextBox_equipamento);
			this.GroupBox_informacoes.Controls.Add(this.Label_equipamento);
			this.GroupBox_informacoes.Controls.Add(this.TextBox_release);
			this.GroupBox_informacoes.Controls.Add(this.Label_release);
			this.GroupBox_informacoes.Controls.Add(this.TextBox_build);
			this.GroupBox_informacoes.Controls.Add(this.Label_build);
			this.GroupBox_informacoes.Controls.Add(this.TextBox_versao);
			this.GroupBox_informacoes.Controls.Add(this.Label_versao);
			this.GroupBox_informacoes.Controls.Add(this.tb_lixo1);
			this.GroupBox_informacoes.Enabled = false;
			global::System.Windows.Forms.Control groupBox_informacoes = this.GroupBox_informacoes;
groupBox_informacoes.Location = new global::System.Drawing.Point(336, 10);
			this.GroupBox_informacoes.Name = "GroupBox_informacoes";
			global::System.Windows.Forms.Control groupBox_informacoes2 = this.GroupBox_informacoes;
			Size = new System.Drawing.Size(456, 84);
			groupBox_informacoes2.Size = this.Size;
			this.GroupBox_informacoes.TabIndex = 2;
			this.GroupBox_informacoes.TabStop = false;
			this.GroupBox_informacoes.Text = "Versão de Software";
			this.Label26.AutoSize = true;
			this.Label26.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control label = this.Label26;
label.Location = new global::System.Drawing.Point(92, 46);
			this.Label26.Name = "Label26";
			global::System.Windows.Forms.Control label2 = this.Label26;
			Size = new System.Drawing.Size(20, 15);
			label2.Size = this.Size;
			this.Label26.TabIndex = 8;
			this.Label26.Text = "RT";
			this.TextBox_equipamento.BackColor = global::System.Drawing.Color.LightCyan;
			this.TextBox_equipamento.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control textBox_equipamento = this.TextBox_equipamento;
textBox_equipamento.Location = new global::System.Drawing.Point(127, 43);
			this.TextBox_equipamento.Name = "TextBox_equipamento";
			this.TextBox_equipamento.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_equipamento2 = this.TextBox_equipamento;
			Size = new System.Drawing.Size(47, 20);
			textBox_equipamento2.Size = this.Size;
			this.TextBox_equipamento.TabIndex = 7;
			this.TextBox_equipamento.TabStop = false;
			this.TextBox_equipamento.TextAlign = HorizontalAlignment.Right;
			this.Label_equipamento.AutoSize = true;
			global::System.Windows.Forms.Control label_equipamento = this.Label_equipamento;
label_equipamento.Location = new global::System.Drawing.Point(92, 25);
			this.Label_equipamento.Name = "Label_equipamento";
			global::System.Windows.Forms.Control label_equipamento2 = this.Label_equipamento;
			Size = new System.Drawing.Size(69, 13);
			label_equipamento2.Size = this.Size;
			this.Label_equipamento.TabIndex = 6;
			this.Label_equipamento.Text = "Equipamento";
			this.TextBox_release.BackColor = global::System.Drawing.Color.LightCyan;
			this.TextBox_release.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control textBox_release = this.TextBox_release;
textBox_release.Location = new global::System.Drawing.Point(283, 43);
			this.TextBox_release.Name = "TextBox_release";
			this.TextBox_release.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_release2 = this.TextBox_release;
			Size = new System.Drawing.Size(47, 20);
			textBox_release2.Size = this.Size;
			this.TextBox_release.TabIndex = 5;
			this.TextBox_release.TabStop = false;
			this.TextBox_release.TextAlign = HorizontalAlignment.Right;
			this.Label_release.AutoSize = true;
			global::System.Windows.Forms.Control label_release = this.Label_release;
label_release.Location = new global::System.Drawing.Point(286, 25);
			this.Label_release.Name = "Label_release";
			global::System.Windows.Forms.Control label_release2 = this.Label_release;
			Size = new System.Drawing.Size(46, 13);
			label_release2.Size = this.Size;
			this.Label_release.TabIndex = 4;
			this.Label_release.Text = "Release";
			this.TextBox_build.BackColor = global::System.Drawing.Color.LightCyan;
			this.TextBox_build.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control textBox_build = this.TextBox_build;
textBox_build.Location = new global::System.Drawing.Point(231, 43);
			this.TextBox_build.Name = "TextBox_build";
			this.TextBox_build.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_build2 = this.TextBox_build;
			Size = new System.Drawing.Size(47, 20);
			textBox_build2.Size = this.Size;
			this.TextBox_build.TabIndex = 3;
			this.TextBox_build.TabStop = false;
			this.TextBox_build.TextAlign = HorizontalAlignment.Right;
			this.Label_build.AutoSize = true;
			global::System.Windows.Forms.Control label_build = this.Label_build;
label_build.Location = new global::System.Drawing.Point(240, 25);
			this.Label_build.Name = "Label_build";
			global::System.Windows.Forms.Control label_build2 = this.Label_build;
			Size = new System.Drawing.Size(30, 13);
			label_build2.Size = this.Size;
			this.Label_build.TabIndex = 2;
			this.Label_build.Text = "Build";
			this.TextBox_versao.BackColor = global::System.Drawing.Color.LightCyan;
			this.TextBox_versao.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control textBox_versao = this.TextBox_versao;
textBox_versao.Location = new global::System.Drawing.Point(179, 43);
			this.TextBox_versao.Name = "TextBox_versao";
			this.TextBox_versao.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_versao2 = this.TextBox_versao;
			Size = new System.Drawing.Size(47, 20);
			textBox_versao2.Size = this.Size;
			this.TextBox_versao.TabIndex = 1;
			this.TextBox_versao.TabStop = false;
			this.TextBox_versao.TextAlign = HorizontalAlignment.Right;
			this.Label_versao.AutoSize = true;
			global::System.Windows.Forms.Control label_versao = this.Label_versao;
label_versao.Location = new global::System.Drawing.Point(182, 25);
			this.Label_versao.Name = "Label_versao";
			global::System.Windows.Forms.Control label_versao2 = this.Label_versao;
			Size = new System.Drawing.Size(40, 13);
			label_versao2.Size = this.Size;
			this.Label_versao.TabIndex = 0;
			this.Label_versao.Text = "Versão";
			global::System.Windows.Forms.Control tb_lixo = this.tb_lixo1;
tb_lixo.Location = new global::System.Drawing.Point(285, 43);
			this.tb_lixo1.Name = "tb_lixo1";
			global::System.Windows.Forms.Control tb_lixo2 = this.tb_lixo1;
			Size = new System.Drawing.Size(47, 20);
			tb_lixo2.Size = this.Size;
			this.tb_lixo1.TabIndex = 9;
			this.GroupBox_comunicacao.Controls.Add(this.lb_PTT);
			this.GroupBox_comunicacao.Controls.Add(this.lb_EndMestre);
			this.GroupBox_comunicacao.Controls.Add(this.lb_EndEst);
			this.GroupBox_comunicacao.Controls.Add(this.NumericUpDown_temp_ptt);
			this.GroupBox_comunicacao.Controls.Add(this.NumericUpDown_end_mestre);
			this.GroupBox_comunicacao.Controls.Add(this.NumericUpDown_end_est);
			this.GroupBox_comunicacao.Enabled = false;
			global::System.Windows.Forms.Control groupBox_comunicacao = this.GroupBox_comunicacao;
groupBox_comunicacao.Location = new global::System.Drawing.Point(20, 10);
			this.GroupBox_comunicacao.Name = "GroupBox_comunicacao";
			global::System.Windows.Forms.Control groupBox_comunicacao2 = this.GroupBox_comunicacao;
			Size = new System.Drawing.Size(291, 125);
			groupBox_comunicacao2.Size = this.Size;
			this.GroupBox_comunicacao.TabIndex = 1;
			this.GroupBox_comunicacao.TabStop = false;
			this.GroupBox_comunicacao.Text = "Parâmetros de Comunicação";
			this.lb_PTT.AutoSize = true;
			global::System.Windows.Forms.Control lb_PTT = this.lb_PTT;
lb_PTT.Location = new global::System.Drawing.Point(21, 85);
			this.lb_PTT.Name = "lb_PTT";
			global::System.Windows.Forms.Control lb_PTT2 = this.lb_PTT;
			Size = new System.Drawing.Size(155, 13);
			lb_PTT2.Size = this.Size;
			this.lb_PTT.TabIndex = 8;
			this.lb_PTT.Text = "Tempo de Espera de PTT (ms):";
			this.lb_EndMestre.AutoSize = true;
			global::System.Windows.Forms.Control lb_EndMestre = this.lb_EndMestre;
lb_EndMestre.Location = new global::System.Drawing.Point(21, 33);
			this.lb_EndMestre.Name = "lb_EndMestre";
			global::System.Windows.Forms.Control lb_EndMestre2 = this.lb_EndMestre;
			Size = new System.Drawing.Size(106, 13);
			lb_EndMestre2.Size = this.Size;
			this.lb_EndMestre.TabIndex = 7;
			this.lb_EndMestre.Text = "Endereço do Mestre:";
			this.lb_EndEst.AutoSize = true;
			global::System.Windows.Forms.Control lb_EndEst = this.lb_EndEst;
lb_EndEst.Location = new global::System.Drawing.Point(21, 59);
			this.lb_EndEst.Name = "lb_EndEst";
			global::System.Windows.Forms.Control lb_EndEst2 = this.lb_EndEst;
			Size = new System.Drawing.Size(113, 13);
			lb_EndEst2.Size = this.Size;
			this.lb_EndEst.TabIndex = 6;
			this.lb_EndEst.Text = "Endereço da Estação:";
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
			this.NumericUpDown_end_mestre.TabIndex = 1;
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
			this.TabPage_EA.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.TabPage_EA.Controls.Add(this.GroupBox2);
			this.TabPage_EA.Controls.Add(this.GroupBox_EA);
			global::System.Windows.Forms.TabPage tabPage_EA = this.TabPage_EA;
tabPage_EA.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_EA.Name = "TabPage_EA";
			global::System.Windows.Forms.Control tabPage_EA2 = this.TabPage_EA;
			Size = new System.Drawing.Size(821, 438);
			tabPage_EA2.Size = this.Size;
			this.TabPage_EA.TabIndex = 6;
			this.TabPage_EA.Text = "Entradas Analógicas";
			this.TabPage_EA.UseVisualStyleBackColor = true;
			this.GroupBox2.Controls.Add(this.lb_ErroOffsetSensor);
			this.GroupBox2.Controls.Add(this.NumericUpDown_errooffsetsensor);
			this.GroupBox2.Controls.Add(this.lb_AlturaReservatorio);
			this.GroupBox2.Controls.Add(this.NumericUpDown_rangesensor);
			this.GroupBox2.Controls.Add(this.lb_RangeSensor);
			this.GroupBox2.Controls.Add(this.NumericUpDown_alturareservatorio);
			global::System.Windows.Forms.Control groupBox = this.GroupBox2;
groupBox.Location = new global::System.Drawing.Point(13, 13);
			this.GroupBox2.Name = "GroupBox2";
			global::System.Windows.Forms.Control groupBox2 = this.GroupBox2;
			Size = new System.Drawing.Size(265, 132);
			groupBox2.Size = this.Size;
			this.GroupBox2.TabIndex = 8;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Sensor";
			this.lb_ErroOffsetSensor.AutoSize = true;
			global::System.Windows.Forms.Control lb_ErroOffsetSensor = this.lb_ErroOffsetSensor;
lb_ErroOffsetSensor.Location = new global::System.Drawing.Point(11, 88);
			this.lb_ErroOffsetSensor.Name = "lb_ErroOffsetSensor";
			global::System.Windows.Forms.Control lb_ErroOffsetSensor2 = this.lb_ErroOffsetSensor;
			Size = new System.Drawing.Size(149, 13);
			lb_ErroOffsetSensor2.Size = this.Size;
			this.lb_ErroOffsetSensor.TabIndex = 23;
			this.lb_ErroOffsetSensor.Text = "Erro de Offset do Sensor (cm):";
			global::System.Windows.Forms.Control numericUpDown_errooffsetsensor = this.NumericUpDown_errooffsetsensor;
numericUpDown_errooffsetsensor.Location = new global::System.Drawing.Point(178, 86);
			global::System.Windows.Forms.NumericUpDown numericUpDown_errooffsetsensor2 = this.NumericUpDown_errooffsetsensor;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			numericUpDown_errooffsetsensor2.Maximum = num;
			global::System.Windows.Forms.NumericUpDown numericUpDown_errooffsetsensor3 = this.NumericUpDown_errooffsetsensor;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				int.MinValue
			});
			numericUpDown_errooffsetsensor3.Minimum = num;
			this.NumericUpDown_errooffsetsensor.Name = "NumericUpDown_errooffsetsensor";
			global::System.Windows.Forms.Control numericUpDown_errooffsetsensor4 = this.NumericUpDown_errooffsetsensor;
			Size = new System.Drawing.Size(70, 20);
			numericUpDown_errooffsetsensor4.Size = this.Size;
			this.NumericUpDown_errooffsetsensor.TabIndex = 26;
			this.lb_AlturaReservatorio.AutoSize = true;
			global::System.Windows.Forms.Control lb_AlturaReservatorio = this.lb_AlturaReservatorio;
lb_AlturaReservatorio.Location = new global::System.Drawing.Point(11, 62);
			this.lb_AlturaReservatorio.Name = "lb_AlturaReservatorio";
			global::System.Windows.Forms.Control lb_AlturaReservatorio2 = this.lb_AlturaReservatorio;
			Size = new System.Drawing.Size(138, 13);
			lb_AlturaReservatorio2.Size = this.Size;
			this.lb_AlturaReservatorio.TabIndex = 22;
			this.lb_AlturaReservatorio.Text = "Altura do Reservatorio (cm):";
			global::System.Windows.Forms.Control numericUpDown_rangesensor = this.NumericUpDown_rangesensor;
numericUpDown_rangesensor.Location = new global::System.Drawing.Point(178, 34);
			global::System.Windows.Forms.NumericUpDown numericUpDown_rangesensor2 = this.NumericUpDown_rangesensor;
			num = new decimal(new int[]
			{
				5000,
				0,
				0,
				0
			});
			numericUpDown_rangesensor2.Maximum = num;
			this.NumericUpDown_rangesensor.Name = "NumericUpDown_rangesensor";
			global::System.Windows.Forms.Control numericUpDown_rangesensor3 = this.NumericUpDown_rangesensor;
			Size = new System.Drawing.Size(70, 20);
			numericUpDown_rangesensor3.Size = this.Size;
			this.NumericUpDown_rangesensor.TabIndex = 24;
			this.lb_RangeSensor.AutoSize = true;
			global::System.Windows.Forms.Control lb_RangeSensor = this.lb_RangeSensor;
lb_RangeSensor.Location = new global::System.Drawing.Point(11, 36);
			this.lb_RangeSensor.Name = "lb_RangeSensor";
			global::System.Windows.Forms.Control lb_RangeSensor2 = this.lb_RangeSensor;
			Size = new System.Drawing.Size(116, 13);
			lb_RangeSensor2.Size = this.Size;
			this.lb_RangeSensor.TabIndex = 21;
			this.lb_RangeSensor.Text = "Range do Sensor (cm):";
			global::System.Windows.Forms.Control numericUpDown_alturareservatorio = this.NumericUpDown_alturareservatorio;
numericUpDown_alturareservatorio.Location = new global::System.Drawing.Point(178, 60);
			global::System.Windows.Forms.NumericUpDown numericUpDown_alturareservatorio2 = this.NumericUpDown_alturareservatorio;
			num = new decimal(new int[]
			{
				5000,
				0,
				0,
				0
			});
			numericUpDown_alturareservatorio2.Maximum = num;
			this.NumericUpDown_alturareservatorio.Name = "NumericUpDown_alturareservatorio";
			global::System.Windows.Forms.Control numericUpDown_alturareservatorio3 = this.NumericUpDown_alturareservatorio;
			Size = new System.Drawing.Size(70, 20);
			numericUpDown_alturareservatorio3.Size = this.Size;
			this.NumericUpDown_alturareservatorio.TabIndex = 25;
			this.GroupBox_EA.Controls.Add(this.NumericUpDown_intervalo_filtro);
			this.GroupBox_EA.Controls.Add(this.NumericUpDown_tamanho_filtro);
			this.GroupBox_EA.Controls.Add(this.lb_Intervalo);
			this.GroupBox_EA.Controls.Add(this.lb_Amostras);
			this.GroupBox_EA.Controls.Add(this.tb_lixo2);
			this.GroupBox_EA.Enabled = false;
			global::System.Windows.Forms.Control groupBox_EA = this.GroupBox_EA;
groupBox_EA.Location = new global::System.Drawing.Point(13, 170);
			this.GroupBox_EA.Name = "GroupBox_EA";
			global::System.Windows.Forms.Control groupBox_EA2 = this.GroupBox_EA;
			Size = new System.Drawing.Size(265, 109);
			groupBox_EA2.Size = this.Size;
			this.GroupBox_EA.TabIndex = 4;
			this.GroupBox_EA.TabStop = false;
			this.GroupBox_EA.Text = "Filtro";
			this.NumericUpDown_intervalo_filtro.AutoSize = true;
			global::System.Windows.Forms.NumericUpDown numericUpDown_intervalo_filtro = this.NumericUpDown_intervalo_filtro;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			numericUpDown_intervalo_filtro.Increment = num;
			global::System.Windows.Forms.Control numericUpDown_intervalo_filtro2 = this.NumericUpDown_intervalo_filtro;
numericUpDown_intervalo_filtro2.Location = new global::System.Drawing.Point(178, 20);
			global::System.Windows.Forms.NumericUpDown numericUpDown_intervalo_filtro3 = this.NumericUpDown_intervalo_filtro;
			num = new decimal(new int[]
			{
				100000,
				0,
				0,
				0
			});
			numericUpDown_intervalo_filtro3.Maximum = num;
			this.NumericUpDown_intervalo_filtro.Name = "NumericUpDown_intervalo_filtro";
			global::System.Windows.Forms.Control numericUpDown_intervalo_filtro4 = this.NumericUpDown_intervalo_filtro;
			Size = new System.Drawing.Size(59, 20);
			numericUpDown_intervalo_filtro4.Size = this.Size;
			this.NumericUpDown_intervalo_filtro.TabIndex = 18;
			this.NumericUpDown_intervalo_filtro.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control numericUpDown_tamanho_filtro = this.NumericUpDown_tamanho_filtro;
numericUpDown_tamanho_filtro.Location = new global::System.Drawing.Point(178, 55);
			global::System.Windows.Forms.NumericUpDown numericUpDown_tamanho_filtro2 = this.NumericUpDown_tamanho_filtro;
			num = new decimal(new int[]
			{
				70000,
				0,
				0,
				0
			});
			numericUpDown_tamanho_filtro2.Maximum = num;
			this.NumericUpDown_tamanho_filtro.Name = "NumericUpDown_tamanho_filtro";
			global::System.Windows.Forms.Control numericUpDown_tamanho_filtro3 = this.NumericUpDown_tamanho_filtro;
			Size = new System.Drawing.Size(59, 20);
			numericUpDown_tamanho_filtro3.Size = this.Size;
			this.NumericUpDown_tamanho_filtro.TabIndex = 1;
			this.NumericUpDown_tamanho_filtro.TextAlign = HorizontalAlignment.Center;
			this.lb_Intervalo.AutoSize = true;
			global::System.Windows.Forms.Control lb_Intervalo = this.lb_Intervalo;
lb_Intervalo.Location = new global::System.Drawing.Point(11, 27);
			this.lb_Intervalo.Name = "lb_Intervalo";
			global::System.Windows.Forms.Control lb_Intervalo2 = this.lb_Intervalo;
			Size = new System.Drawing.Size(131, 13);
			lb_Intervalo2.Size = this.Size;
			this.lb_Intervalo.TabIndex = 14;
			this.lb_Intervalo.Text = "Intervalo do Filtro AD (ms):";
			this.lb_Amostras.AutoSize = true;
			global::System.Windows.Forms.Control lb_Amostras = this.lb_Amostras;
lb_Amostras.Location = new global::System.Drawing.Point(11, 55);
			this.lb_Amostras.Name = "lb_Amostras";
			global::System.Windows.Forms.Control lb_Amostras2 = this.lb_Amostras;
			Size = new System.Drawing.Size(95, 13);
			lb_Amostras2.Size = this.Size;
			this.lb_Amostras.TabIndex = 16;
			this.lb_Amostras.Text = "Tamanho do Filtro:";
			global::System.Windows.Forms.Control tb_lixo3 = this.tb_lixo2;
tb_lixo3.Location = new global::System.Drawing.Point(178, 55);
			this.tb_lixo2.Name = "tb_lixo2";
			global::System.Windows.Forms.Control tb_lixo4 = this.tb_lixo2;
			Size = new System.Drawing.Size(42, 20);
			tb_lixo4.Size = this.Size;
			this.tb_lixo2.TabIndex = 10;
			this.TabPage_ED.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.TabPage_ED.Controls.Add(this.GroupBox_ED);
			global::System.Windows.Forms.TabPage tabPage_ED = this.TabPage_ED;
tabPage_ED.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_ED.Name = "TabPage_ED";
			global::System.Windows.Forms.Control tabPage_ED2 = this.TabPage_ED;
			Size = new System.Drawing.Size(821, 438);
			tabPage_ED2.Size = this.Size;
			this.TabPage_ED.TabIndex = 4;
			this.TabPage_ED.Text = "Entradas Digitais";
			this.TabPage_ED.UseVisualStyleBackColor = true;
			this.GroupBox_ED.Controls.Add(this.Label25);
			this.GroupBox_ED.Controls.Add(this.Label24);
			this.GroupBox_ED.Controls.Add(this.Label23);
			this.GroupBox_ED.Controls.Add(this.Label22);
			this.GroupBox_ED.Controls.Add(this.Label21);
			this.GroupBox_ED.Controls.Add(this.Label20);
			this.GroupBox_ED.Controls.Add(this.Label19);
			this.GroupBox_ED.Controls.Add(this.Label18);
			this.GroupBox_ED.Controls.Add(this.Label17);
			this.GroupBox_ED.Enabled = false;
			global::System.Windows.Forms.Control groupBox_ED = this.GroupBox_ED;
groupBox_ED.Location = new global::System.Drawing.Point(12, 17);
			this.GroupBox_ED.Name = "GroupBox_ED";
			global::System.Windows.Forms.Control groupBox_ED2 = this.GroupBox_ED;
			Size = new System.Drawing.Size(263, 334);
			groupBox_ED2.Size = this.Size;
			this.GroupBox_ED.TabIndex = 0;
			this.GroupBox_ED.TabStop = false;
			this.GroupBox_ED.Text = "Entradas Digitais";
			this.Label25.AutoSize = true;
			global::System.Windows.Forms.Control label3 = this.Label25;
label3.Location = new global::System.Drawing.Point(21, 32);
			this.Label25.Name = "Label25";
			global::System.Windows.Forms.Control label4 = this.Label25;
			Size = new System.Drawing.Size(196, 13);
			label4.Size = this.Size;
			this.Label25.TabIndex = 8;
			this.Label25.Text = "Descrição de cada Entrada Digital (ED):";
			this.Label24.AutoSize = true;
			global::System.Windows.Forms.Control label5 = this.Label24;
label5.Location = new global::System.Drawing.Point(21, 229);
			this.Label24.Name = "Label24";
			global::System.Windows.Forms.Control label6 = this.Label24;
			Size = new System.Drawing.Size(149, 13);
			label6.Size = this.Size;
			this.Label24.TabIndex = 7;
			this.Label24.Text = "ED 08 - Alarme Arrombamento";
			this.Label23.AutoSize = true;
			global::System.Windows.Forms.Control label7 = this.Label23;
label7.Location = new global::System.Drawing.Point(21, 205);
			this.Label23.Name = "Label23";
			global::System.Windows.Forms.Control label8 = this.Label23;
			Size = new System.Drawing.Size(146, 13);
			label8.Size = this.Size;
			this.Label23.TabIndex = 6;
			this.Label23.Text = "ED 07 - Operando em Bateria";
			this.Label22.AutoSize = true;
			global::System.Windows.Forms.Control label9 = this.Label22;
label9.Location = new global::System.Drawing.Point(21, 180);
			this.Label22.Name = "Label22";
			global::System.Windows.Forms.Control label10 = this.Label22;
			Size = new System.Drawing.Size(142, 13);
			label10.Size = this.Size;
			this.Label22.TabIndex = 5;
			this.Label22.Text = "ED 06 - Eletrodo Transbordo";
			this.Label21.AutoSize = true;
			global::System.Windows.Forms.Control label11 = this.Label21;
label11.Location = new global::System.Drawing.Point(21, 156);
			this.Label21.Name = "Label21";
			global::System.Windows.Forms.Control label12 = this.Label21;
			Size = new System.Drawing.Size(114, 13);
			label12.Size = this.Size;
			this.Label21.TabIndex = 4;
			this.Label21.Text = "ED 05 - Eletrodo 100%";
			this.Label20.AutoSize = true;
			global::System.Windows.Forms.Control label13 = this.Label20;
label13.Location = new global::System.Drawing.Point(21, 130);
			this.Label20.Name = "Label20";
			global::System.Windows.Forms.Control label14 = this.Label20;
			Size = new System.Drawing.Size(108, 13);
			label14.Size = this.Size;
			this.Label20.TabIndex = 3;
			this.Label20.Text = "ED 04 - Eletrodo 80%";
			this.Label19.AutoSize = true;
			global::System.Windows.Forms.Control label15 = this.Label19;
label15.Location = new global::System.Drawing.Point(21, 105);
			this.Label19.Name = "Label19";
			global::System.Windows.Forms.Control label16 = this.Label19;
			Size = new System.Drawing.Size(108, 13);
			label16.Size = this.Size;
			this.Label19.TabIndex = 2;
			this.Label19.Text = "ED 03 - Eletrodo 60%";
			this.Label18.AutoSize = true;
			global::System.Windows.Forms.Control label17 = this.Label18;
label17.Location = new global::System.Drawing.Point(21, 81);
			this.Label18.Name = "Label18";
			global::System.Windows.Forms.Control label18 = this.Label18;
			Size = new System.Drawing.Size(108, 13);
			label18.Size = this.Size;
			this.Label18.TabIndex = 1;
			this.Label18.Text = "ED 02 - Eletrodo 40%";
			this.Label17.AutoSize = true;
			global::System.Windows.Forms.Control label19 = this.Label17;
label19.Location = new global::System.Drawing.Point(21, 59);
			this.Label17.Name = "Label17";
			global::System.Windows.Forms.Control label20 = this.Label17;
			Size = new System.Drawing.Size(108, 13);
			label20.Size = this.Size;
			this.Label17.TabIndex = 0;
			this.Label17.Text = "ED 01 - Eletrodo 20%";
			this.TabPage_repetidora.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.TabPage_repetidora.Controls.Add(this.GroupBox_end_rep);
			this.TabPage_repetidora.Controls.Add(this.GroupBox_parametros_repetidora);
			global::System.Windows.Forms.TabPage tabPage_repetidora = this.TabPage_repetidora;
tabPage_repetidora.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_repetidora.Name = "TabPage_repetidora";
			global::System.Windows.Forms.Control tabPage_repetidora2 = this.TabPage_repetidora;
			Size = new System.Drawing.Size(821, 438);
			tabPage_repetidora2.Size = this.Size;
			this.TabPage_repetidora.TabIndex = 3;
			this.TabPage_repetidora.Text = "Repetidora";
			this.TabPage_repetidora.UseVisualStyleBackColor = true;
			this.GroupBox_end_rep.Controls.Add(this.DataGridView_end_rep_RT_810);
			this.GroupBox_end_rep.Enabled = false;
			global::System.Windows.Forms.Control groupBox_end_rep = this.GroupBox_end_rep;
groupBox_end_rep.Location = new global::System.Drawing.Point(20, 136);
			this.GroupBox_end_rep.Name = "GroupBox_end_rep";
			global::System.Windows.Forms.Control groupBox_end_rep2 = this.GroupBox_end_rep;
			Size = new System.Drawing.Size(614, 287);
			groupBox_end_rep2.Size = this.Size;
			this.GroupBox_end_rep.TabIndex = 4;
			this.GroupBox_end_rep.TabStop = false;
			this.GroupBox_end_rep.Text = "Endereço das estações a serem retransmitidas";
			this.DataGridView_end_rep_RT_810.AllowUserToAddRows = false;
			this.DataGridView_end_rep_RT_810.AllowUserToDeleteRows = false;
			this.DataGridView_end_rep_RT_810.AllowUserToOrderColumns = true;
			this.DataGridView_end_rep_RT_810.AllowUserToResizeColumns = false;
			this.DataGridView_end_rep_RT_810.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			this.DataGridView_end_rep_RT_810.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			dataGridViewCellStyle2.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView_end_rep_RT_810.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DataGridView_end_rep_RT_810.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			this.DataGridView_end_rep_RT_810.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Posicao_1_10,
				this.End_01_10,
				this.Posicao_11_20,
				this.End_11_20,
				this.Posicao_21_30,
				this.End_21_30,
				this.Posicao_31_40,
				this.End_31_40,
				this.Posicao_41_50,
				this.End_41_50
			});
			dataGridViewCellStyle3.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView_end_rep_RT_810.DefaultCellStyle = dataGridViewCellStyle3;
			global::System.Windows.Forms.Control dataGridView_end_rep_RT_ = this.DataGridView_end_rep_RT_810;
dataGridView_end_rep_RT_.Location = new global::System.Drawing.Point(18, 25);
			this.DataGridView_end_rep_RT_810.Name = "DataGridView_end_rep_RT_810";
			dataGridViewCellStyle4.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)16;
			dataGridViewCellStyle4.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode =(System.Windows.Forms.DataGridViewTriState) (System.Windows.Forms.DataGridViewTriState)System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView_end_rep_RT_810.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.DataGridView_end_rep_RT_810.RowHeadersVisible = false;
			this.DataGridView_end_rep_RT_810.ScrollBars =(System.Windows.Forms.ScrollBars)0;
			global::System.Windows.Forms.Control dataGridView_end_rep_RT_2 = this.DataGridView_end_rep_RT_810;
			Size = new System.Drawing.Size(578, 243);
			dataGridView_end_rep_RT_2.Size = this.Size;
			this.DataGridView_end_rep_RT_810.TabIndex = 0;
			this.DataGridView_end_rep_RT_810.Visible = false;
			dataGridViewCellStyle5.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)32;
			this.Posicao_1_10.DefaultCellStyle = dataGridViewCellStyle5;
			this.Posicao_1_10.HeaderText = "Posição";
			this.Posicao_1_10.Name = "Posicao_1_10";
			this.Posicao_1_10.ReadOnly = true;
			this.Posicao_1_10.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Posicao_1_10.SortMode = 0;
			this.Posicao_1_10.Width = 55;
			dataGridViewCellStyle6.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			this.End_01_10.DefaultCellStyle = dataGridViewCellStyle6;
			this.End_01_10.HeaderText = "  End.";
			this.End_01_10.Name = "End_01_10";
			this.End_01_10.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.End_01_10.SortMode = 0;
			this.End_01_10.Width = 60;
			dataGridViewCellStyle7.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)32;
			this.Posicao_11_20.DefaultCellStyle = dataGridViewCellStyle7;
			this.Posicao_11_20.HeaderText = "Posição";
			this.Posicao_11_20.Name = "Posicao_11_20";
			this.Posicao_11_20.ReadOnly = true;
			this.Posicao_11_20.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Posicao_11_20.SortMode = 0;
			this.Posicao_11_20.Width = 55;
			dataGridViewCellStyle8.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			this.End_11_20.DefaultCellStyle = dataGridViewCellStyle8;
			this.End_11_20.HeaderText = "  End.";
			this.End_11_20.Name = "End_11_20";
			this.End_11_20.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.End_11_20.SortMode = 0;
			this.End_11_20.Width = 60;
			dataGridViewCellStyle9.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)32;
			this.Posicao_21_30.DefaultCellStyle = dataGridViewCellStyle9;
			this.Posicao_21_30.HeaderText = "Posição";
			this.Posicao_21_30.Name = "Posicao_21_30";
			this.Posicao_21_30.ReadOnly = true;
			this.Posicao_21_30.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Posicao_21_30.SortMode = 0;
			this.Posicao_21_30.Width = 55;
			dataGridViewCellStyle10.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			this.End_21_30.DefaultCellStyle = dataGridViewCellStyle10;
			this.End_21_30.HeaderText = "  End.";
			this.End_21_30.Name = "End_21_30";
			this.End_21_30.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.End_21_30.SortMode = 0;
			this.End_21_30.Width = 60;
			dataGridViewCellStyle11.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)32;
			this.Posicao_31_40.DefaultCellStyle = dataGridViewCellStyle11;
			this.Posicao_31_40.HeaderText = "Posição";
			this.Posicao_31_40.Name = "Posicao_31_40";
			this.Posicao_31_40.ReadOnly = true;
			this.Posicao_31_40.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Posicao_31_40.SortMode = 0;
			this.Posicao_31_40.Width = 55;
			dataGridViewCellStyle12.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			this.End_31_40.DefaultCellStyle = dataGridViewCellStyle12;
			this.End_31_40.HeaderText = "  End.";
			this.End_31_40.Name = "End_31_40";
			this.End_31_40.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.End_31_40.SortMode = 0;
			this.End_31_40.Width = 60;
			dataGridViewCellStyle13.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)32;
			this.Posicao_41_50.DefaultCellStyle = dataGridViewCellStyle13;
			this.Posicao_41_50.HeaderText = "Posição";
			this.Posicao_41_50.Name = "Posicao_41_50";
			this.Posicao_41_50.ReadOnly = true;
			this.Posicao_41_50.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.Posicao_41_50.SortMode = 0;
			this.Posicao_41_50.Width = 55;
			dataGridViewCellStyle14.Alignment = (System.Windows.Forms.DataGridViewContentAlignment)64;
			this.End_41_50.DefaultCellStyle = dataGridViewCellStyle14;
			this.End_41_50.HeaderText = "  End.";
			this.End_41_50.Name = "End_41_50";
			this.End_41_50.Resizable = (System.Windows.Forms.DataGridViewTriState)2;
			this.End_41_50.SortMode = 0;
			this.End_41_50.Width = 60;
			this.GroupBox_parametros_repetidora.Controls.Add(this.ComboBox_modo_repeticao_RT_810);
			this.GroupBox_parametros_repetidora.Controls.Add(this.Label_modo_rep_RT_810);
			this.GroupBox_parametros_repetidora.Controls.Add(this.NumericUpDown_num_est_rep);
			this.GroupBox_parametros_repetidora.Controls.Add(this.NumericUpDown_end_rep);
			this.GroupBox_parametros_repetidora.Controls.Add(this.Label_num_est_rep);
			this.GroupBox_parametros_repetidora.Controls.Add(this.Label_end_rep);
			this.GroupBox_parametros_repetidora.Controls.Add(this.tb_lixo3);
			this.GroupBox_parametros_repetidora.Enabled = false;
			global::System.Windows.Forms.Control groupBox_parametros_repetidora = this.GroupBox_parametros_repetidora;
groupBox_parametros_repetidora.Location = new global::System.Drawing.Point(20, 20);
			this.GroupBox_parametros_repetidora.Name = "GroupBox_parametros_repetidora";
			global::System.Windows.Forms.Control groupBox_parametros_repetidora2 = this.GroupBox_parametros_repetidora;
			Size = new System.Drawing.Size(614, 110);
			groupBox_parametros_repetidora2.Size = this.Size;
			this.GroupBox_parametros_repetidora.TabIndex = 3;
			this.GroupBox_parametros_repetidora.TabStop = false;
			this.GroupBox_parametros_repetidora.Text = "Parâmetros da Repetidora";
			this.ComboBox_modo_repeticao_RT_810.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox_modo_repeticao_RT_ = this.ComboBox_modo_repeticao_RT_810;
comboBox_modo_repeticao_RT_.Location = new global::System.Drawing.Point(161, 24);
			this.ComboBox_modo_repeticao_RT_810.Name = "ComboBox_modo_repeticao_RT_810";
			global::System.Windows.Forms.Control comboBox_modo_repeticao_RT_2 = this.ComboBox_modo_repeticao_RT_810;
			Size = new System.Drawing.Size(133, 21);
			comboBox_modo_repeticao_RT_2.Size = this.Size;
			this.ComboBox_modo_repeticao_RT_810.TabIndex = 16;
			this.Label_modo_rep_RT_810.AutoSize = true;
			global::System.Windows.Forms.Control label_modo_rep_RT_ = this.Label_modo_rep_RT_810;
label_modo_rep_RT_.Location = new global::System.Drawing.Point(26, 27);
			this.Label_modo_rep_RT_810.Name = "Label_modo_rep_RT_810";
			global::System.Windows.Forms.Control label_modo_rep_RT_2 = this.Label_modo_rep_RT_810;
			Size = new System.Drawing.Size(102, 13);
			label_modo_rep_RT_2.Size = this.Size;
			this.Label_modo_rep_RT_810.TabIndex = 15;
			this.Label_modo_rep_RT_810.Text = "Modo de repetição :";
			global::System.Windows.Forms.Control numericUpDown_num_est_rep = this.NumericUpDown_num_est_rep;
numericUpDown_num_est_rep.Location = new global::System.Drawing.Point(222, 74);
			global::System.Windows.Forms.NumericUpDown numericUpDown_num_est_rep2 = this.NumericUpDown_num_est_rep;
			num = new decimal(new int[]
			{
				50,
				0,
				0,
				0
			});
			numericUpDown_num_est_rep2.Maximum = num;
			this.NumericUpDown_num_est_rep.Name = "NumericUpDown_num_est_rep";
			global::System.Windows.Forms.Control numericUpDown_num_est_rep3 = this.NumericUpDown_num_est_rep;
			Size = new System.Drawing.Size(72, 20);
			numericUpDown_num_est_rep3.Size = this.Size;
			this.NumericUpDown_num_est_rep.TabIndex = 2;
			this.NumericUpDown_num_est_rep.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.Control numericUpDown_end_rep = this.NumericUpDown_end_rep;
numericUpDown_end_rep.Location = new global::System.Drawing.Point(222, 50);
			global::System.Windows.Forms.NumericUpDown numericUpDown_end_rep2 = this.NumericUpDown_end_rep;
			num = new decimal(new int[]
			{
				200,
				0,
				0,
				0
			});
			numericUpDown_end_rep2.Maximum = num;
			this.NumericUpDown_end_rep.Name = "NumericUpDown_end_rep";
			global::System.Windows.Forms.Control numericUpDown_end_rep3 = this.NumericUpDown_end_rep;
			Size = new System.Drawing.Size(72, 20);
			numericUpDown_end_rep3.Size = this.Size;
			this.NumericUpDown_end_rep.TabIndex = 1;
			this.NumericUpDown_end_rep.TextAlign = HorizontalAlignment.Right;
			this.Label_num_est_rep.AutoSize = true;
			global::System.Windows.Forms.Control label_num_est_rep = this.Label_num_est_rep;
label_num_est_rep.Location = new global::System.Drawing.Point(26, 76);
			this.Label_num_est_rep.Name = "Label_num_est_rep";
			global::System.Windows.Forms.Control label_num_est_rep2 = this.Label_num_est_rep;
			Size = new System.Drawing.Size(112, 13);
			label_num_est_rep2.Size = this.Size;
			this.Label_num_est_rep.TabIndex = 2;
			this.Label_num_est_rep.Text = "Número de Estações :";
			this.Label_end_rep.AutoSize = true;
			global::System.Windows.Forms.Control label_end_rep = this.Label_end_rep;
label_end_rep.Location = new global::System.Drawing.Point(26, 52);
			this.Label_end_rep.Name = "Label_end_rep";
			global::System.Windows.Forms.Control label_end_rep2 = this.Label_end_rep;
			Size = new System.Drawing.Size(129, 13);
			label_end_rep2.Size = this.Size;
			this.Label_end_rep.TabIndex = 1;
			this.Label_end_rep.Text = "Endereço da Repetidora :";
			global::System.Windows.Forms.Control tb_lixo5 = this.tb_lixo3;
tb_lixo5.Location = new global::System.Drawing.Point(222, 73);
			this.tb_lixo3.Name = "tb_lixo3";
			global::System.Windows.Forms.Control tb_lixo6 = this.tb_lixo3;
			Size = new System.Drawing.Size(47, 20);
			tb_lixo6.Size = this.Size;
			this.tb_lixo3.TabIndex = 11;
			this.TabPage_dadosinstalacao.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.TabPage_dadosinstalacao.Controls.Add(this.GroupBox1);
			global::System.Windows.Forms.TabPage tabPage_dadosinstalacao = this.TabPage_dadosinstalacao;
tabPage_dadosinstalacao.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_dadosinstalacao.Name = "TabPage_dadosinstalacao";
			global::System.Windows.Forms.Control tabPage_dadosinstalacao2 = this.TabPage_dadosinstalacao;
			Padding = new Padding(3);
			tabPage_dadosinstalacao2.Padding = Padding;
			global::System.Windows.Forms.Control tabPage_dadosinstalacao3 = this.TabPage_dadosinstalacao;
			Size = new System.Drawing.Size(821, 438);
			tabPage_dadosinstalacao3.Size = this.Size;
			this.TabPage_dadosinstalacao.TabIndex = 7;
			this.TabPage_dadosinstalacao.Text = "Dados de Instalação";
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
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.tb_lixo4);
			global::System.Windows.Forms.Control groupBox3 = this.GroupBox1;
groupBox3.Location = new global::System.Drawing.Point(6, 15);
			this.GroupBox1.Name = "GroupBox1";
			global::System.Windows.Forms.Control groupBox4 = this.GroupBox1;
			Size = new System.Drawing.Size(788, 406);
			groupBox4.Size = this.Size;
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label16.AutoSize = true;
			this.Label16.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control label21 = this.Label16;
label21.Location = new global::System.Drawing.Point(587, 23);
			this.Label16.Name = "Label16";
			global::System.Windows.Forms.Control label22 = this.Label16;
			Size = new System.Drawing.Size(12, 16);
			label22.Size = this.Size;
			this.Label16.TabIndex = 26;
			this.Label16.Text = "°";
			this.Label15.AutoSize = true;
			global::System.Windows.Forms.Control label23 = this.Label15;
label23.Location = new global::System.Drawing.Point(587, 132);
			this.Label15.Name = "Label15";
			global::System.Windows.Forms.Control label24 = this.Label15;
			Size = new System.Drawing.Size(15, 13);
			label24.Size = this.Size;
			this.Label15.TabIndex = 25;
			this.Label15.Text = "m";
			global::System.Windows.Forms.Control t_ModeloFonte = this.T_ModeloFonte;
t_ModeloFonte.Location = new global::System.Drawing.Point(460, 157);
			this.T_ModeloFonte.Name = "T_ModeloFonte";
			global::System.Windows.Forms.Control t_ModeloFonte2 = this.T_ModeloFonte;
			Size = new System.Drawing.Size(121, 20);
			t_ModeloFonte2.Size = this.Size;
			this.T_ModeloFonte.TabIndex = 24;
			global::System.Windows.Forms.Control t_AlturaAntena = this.T_AlturaAntena;
t_AlturaAntena.Location = new global::System.Drawing.Point(460, 124);
			this.T_AlturaAntena.Name = "T_AlturaAntena";
			global::System.Windows.Forms.Control t_AlturaAntena2 = this.T_AlturaAntena;
			Size = new System.Drawing.Size(121, 20);
			t_AlturaAntena2.Size = this.Size;
			this.T_AlturaAntena.TabIndex = 23;
			global::System.Windows.Forms.Control t_Latitude = this.T_Latitude;
t_Latitude.Location = new global::System.Drawing.Point(460, 89);
			this.T_Latitude.Name = "T_Latitude";
			global::System.Windows.Forms.Control t_Latitude2 = this.T_Latitude;
			Size = new System.Drawing.Size(121, 20);
			t_Latitude2.Size = this.Size;
			this.T_Latitude.TabIndex = 22;
			global::System.Windows.Forms.Control t_Longitude = this.T_Longitude;
t_Longitude.Location = new global::System.Drawing.Point(460, 54);
			this.T_Longitude.Name = "T_Longitude";
			global::System.Windows.Forms.Control t_Longitude2 = this.T_Longitude;
			Size = new System.Drawing.Size(121, 20);
			t_Longitude2.Size = this.Size;
			this.T_Longitude.TabIndex = 21;
			global::System.Windows.Forms.Control t_Azimute = this.T_Azimute;
t_Azimute.Location = new global::System.Drawing.Point(460, 23);
			this.T_Azimute.Name = "T_Azimute";
			global::System.Windows.Forms.Control t_Azimute2 = this.T_Azimute;
			Size = new System.Drawing.Size(121, 20);
			t_Azimute2.Size = this.Size;
			this.T_Azimute.TabIndex = 20;
			this.Label14.AutoSize = true;
			global::System.Windows.Forms.Control label25 = this.Label14;
label25.Location = new global::System.Drawing.Point(285, 96);
			this.Label14.Name = "Label14";
			global::System.Windows.Forms.Control label26 = this.Label14;
			Size = new System.Drawing.Size(18, 13);
			label26.Size = this.Size;
			this.Label14.TabIndex = 19;
			this.Label14.Text = "W";
			this.Label13.AutoSize = true;
			global::System.Windows.Forms.Control label27 = this.Label13;
label27.Location = new global::System.Drawing.Point(285, 199);
			this.Label13.Name = "Label13";
			global::System.Windows.Forms.Control label28 = this.Label13;
			Size = new System.Drawing.Size(29, 13);
			label28.Size = this.Size;
			this.Label13.TabIndex = 18;
			this.Label13.Text = "MHz";
			this.Label12.AutoSize = true;
			global::System.Windows.Forms.Control label29 = this.Label12;
label29.Location = new global::System.Drawing.Point(285, 167);
			this.Label12.Name = "Label12";
			global::System.Windows.Forms.Control label30 = this.Label12;
			Size = new System.Drawing.Size(21, 13);
			label30.Size = this.Size;
			this.Label12.TabIndex = 17;
			this.Label12.Text = "km";
			global::System.Windows.Forms.Control t_FreqRadio = this.T_FreqRadio;
t_FreqRadio.Location = new global::System.Drawing.Point(158, 192);
			this.T_FreqRadio.Name = "T_FreqRadio";
			global::System.Windows.Forms.Control t_FreqRadio2 = this.T_FreqRadio;
			Size = new System.Drawing.Size(121, 20);
			t_FreqRadio2.Size = this.Size;
			this.T_FreqRadio.TabIndex = 16;
			global::System.Windows.Forms.Control t_DistCentral = this.T_DistCentral;
t_DistCentral.Location = new global::System.Drawing.Point(158, 160);
			this.T_DistCentral.Name = "T_DistCentral";
			global::System.Windows.Forms.Control t_DistCentral2 = this.T_DistCentral;
			Size = new System.Drawing.Size(121, 20);
			t_DistCentral2.Size = this.Size;
			this.T_DistCentral.TabIndex = 15;
			global::System.Windows.Forms.Control t_PotRadio = this.T_PotRadio;
t_PotRadio.Location = new global::System.Drawing.Point(158, 89);
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
cb_ModeloRadio.Location = new global::System.Drawing.Point(158, 124);
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
cb_PolarizacaoAntena.Location = new global::System.Drawing.Point(158, 54);
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
cb_TipoAntena.Location = new global::System.Drawing.Point(158, 27);
			this.CB_TipoAntena.Name = "CB_TipoAntena";
			global::System.Windows.Forms.Control cb_TipoAntena2 = this.CB_TipoAntena;
			Size = new System.Drawing.Size(121, 21);
			cb_TipoAntena2.Size = this.Size;
			this.CB_TipoAntena.TabIndex = 11;
			this.Label11.AutoSize = true;
			global::System.Windows.Forms.Control label31 = this.Label11;
label31.Location = new global::System.Drawing.Point(366, 160);
			this.Label11.Name = "Label11";
			global::System.Windows.Forms.Control label32 = this.Label11;
			Size = new System.Drawing.Size(87, 13);
			label32.Size = this.Size;
			this.Label11.TabIndex = 10;
			this.Label11.Text = "Modelo da fonte:";
			this.Label10.AutoSize = true;
			global::System.Windows.Forms.Control label33 = this.Label10;
label33.Location = new global::System.Drawing.Point(366, 127);
			this.Label10.Name = "Label10";
			global::System.Windows.Forms.Control label34 = this.Label10;
			Size = new System.Drawing.Size(37, 13);
			label34.Size = this.Size;
			this.Label10.TabIndex = 9;
			this.Label10.Text = "Altura:";
			this.Label9.AutoSize = true;
			global::System.Windows.Forms.Control label35 = this.Label9;
label35.Location = new global::System.Drawing.Point(366, 92);
			this.Label9.Name = "Label9";
			global::System.Windows.Forms.Control label36 = this.Label9;
			Size = new System.Drawing.Size(48, 13);
			label36.Size = this.Size;
			this.Label9.TabIndex = 8;
			this.Label9.Text = "Latitude:";
			this.Label8.AutoSize = true;
			global::System.Windows.Forms.Control label37 = this.Label8;
label37.Location = new global::System.Drawing.Point(366, 63);
			this.Label8.Name = "Label8";
			global::System.Windows.Forms.Control label38 = this.Label8;
			Size = new System.Drawing.Size(57, 13);
			label38.Size = this.Size;
			this.Label8.TabIndex = 7;
			this.Label8.Text = "Longitude:";
			this.Label7.AutoSize = true;
			global::System.Windows.Forms.Control label39 = this.Label7;
label39.Location = new global::System.Drawing.Point(366, 30);
			this.Label7.Name = "Label7";
			global::System.Windows.Forms.Control label40 = this.Label7;
			Size = new System.Drawing.Size(47, 13);
			label40.Size = this.Size;
			this.Label7.TabIndex = 6;
			this.Label7.Text = "Azimute:";
			this.Label6.AutoSize = true;
			global::System.Windows.Forms.Control label41 = this.Label6;
label41.Location = new global::System.Drawing.Point(16, 195);
			this.Label6.Name = "Label6";
			global::System.Windows.Forms.Control label42 = this.Label6;
			Size = new System.Drawing.Size(104, 13);
			label42.Size = this.Size;
			this.Label6.TabIndex = 5;
			this.Label6.Text = "Frequência do rádio:";
			this.Label5.AutoSize = true;
			global::System.Windows.Forms.Control label43 = this.Label5;
label43.Location = new global::System.Drawing.Point(16, 160);
			this.Label5.Name = "Label5";
			global::System.Windows.Forms.Control label44 = this.Label5;
			Size = new System.Drawing.Size(122, 13);
			label44.Size = this.Size;
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Distância para a central:";
			this.Label4.AutoSize = true;
			global::System.Windows.Forms.Control label45 = this.Label4;
label45.Location = new global::System.Drawing.Point(16, 127);
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control label46 = this.Label4;
			Size = new System.Drawing.Size(86, 13);
			label46.Size = this.Size;
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Modelo do rádio:";
			this.Label3.AutoSize = true;
			global::System.Windows.Forms.Control label47 = this.Label3;
label47.Location = new global::System.Drawing.Point(16, 96);
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label48 = this.Label3;
			Size = new System.Drawing.Size(93, 13);
			label48.Size = this.Size;
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Potência do rádio:";
			this.Label2.AutoSize = true;
			global::System.Windows.Forms.Control label49 = this.Label2;
label49.Location = new global::System.Drawing.Point(16, 63);
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label50 = this.Label2;
			Size = new System.Drawing.Size(65, 13);
			label50.Size = this.Size;
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Polarização:";
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label51 = this.Label1;
label51.Location = new global::System.Drawing.Point(16, 30);
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label52 = this.Label1;
			Size = new System.Drawing.Size(83, 13);
			label52.Size = this.Size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Tipo de Antena:";
			global::System.Windows.Forms.Control tb_lixo7 = this.tb_lixo4;
tb_lixo7.Location = new global::System.Drawing.Point(158, 192);
			this.tb_lixo4.Name = "tb_lixo4";
			global::System.Windows.Forms.Control tb_lixo8 = this.tb_lixo4;
			Size = new System.Drawing.Size(74, 20);
			tb_lixo8.Size = this.Size;
			this.tb_lixo4.TabIndex = 27;
			this.ToolStri_RT_810.BackColor = global::System.Drawing.Color.Transparent;
			this.ToolStri_RT_810.GripStyle = 0;
			global::System.Windows.Forms.ToolStrip toolStri_RT_ = this.ToolStri_RT_810;
			Size = new System.Drawing.Size(48, 48);
			toolStri_RT_.ImageScalingSize = Size;
			this.ToolStri_RT_810.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripButton_RT_810_novo,
				this.ToolStripButton_RT_810_Abrir,
				this.ToolStripButton_RT_810_Salvar,
				this.ToolStripSeparator1,
				this.ToolStripButton_RT_810_Download,
				this.ToolStripButton_RT_810_Upload,
				this.ToolStripSeparator2,
				this.ToolStripButton_RT_810_Imprimir,
				this.ToolStripSeparator3,
				this.ToolStripLabel_ID,
				this.ToolStripSeparator4,
				this.ToolStripTextBox_RT_810_Msg,
				this.ToolStripProgressBar_RT_810
			});
			this.ToolStri_RT_810.LayoutStyle =(System.Windows.Forms.ToolStripLayoutStyle)3;
			global::System.Windows.Forms.Control toolStri_RT_2 = this.ToolStri_RT_810;
toolStri_RT_2.Location = new global::System.Drawing.Point(0, 0);
			this.ToolStri_RT_810.Name = "ToolStri_RT_810";
			global::System.Windows.Forms.Control toolStri_RT_3 = this.ToolStri_RT_810;
			Size = new System.Drawing.Size(1065, 55);
			toolStri_RT_3.Size = this.Size;
			this.ToolStri_RT_810.Stretch = true;
			this.ToolStri_RT_810.TabIndex = 0;
			this.ToolStri_RT_810.Text = "ToolStrip1";
			this.ToolStripButton_RT_810_novo.AutoToolTip = false;
			this.ToolStripButton_RT_810_novo.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT_810_novo.Image = global::iS800.My.Resources.Resources.folder_add_icon1;
			this.ToolStripButton_RT_810_novo.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT_810_novo = this.ToolStripButton_RT_810_novo;
			Padding = new Padding(10, 1, 0, 2);
			toolStripButton_RT_810_novo.Margin = Padding;
			this.ToolStripButton_RT_810_novo.Name = "ToolStripButton_RT_810_novo";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT_810_novo2 = this.ToolStripButton_RT_810_novo;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT_810_novo2.Size = this.Size;
			this.ToolStripButton_RT_810_novo.Text = "Novo";
			this.ToolStripButton_RT_810_novo.ToolTipText = "Novo arquivo";
			this.ToolStripButton_RT_810_Abrir.AutoToolTip = false;
			this.ToolStripButton_RT_810_Abrir.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT_810_Abrir.Image = global::iS800.My.Resources.Resources.folder_up_icon;
			this.ToolStripButton_RT_810_Abrir.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton_RT_810_Abrir.Name = "ToolStripButton_RT_810_Abrir";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT_810_Abrir = this.ToolStripButton_RT_810_Abrir;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT_810_Abrir.Size = this.Size;
			this.ToolStripButton_RT_810_Abrir.Text = "Abrir Arquivo";
			this.ToolStripButton_RT_810_Abrir.ToolTipText = "Abrir arquivo";
			this.ToolStripButton_RT_810_Salvar.AutoToolTip = false;
			this.ToolStripButton_RT_810_Salvar.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT_810_Salvar.Image = global::iS800.My.Resources.Resources.folder_down_icon;
			this.ToolStripButton_RT_810_Salvar.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton_RT_810_Salvar.Name = "ToolStripButton_RT_810_Salvar";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT_810_Salvar = this.ToolStripButton_RT_810_Salvar;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT_810_Salvar.Size = this.Size;
			this.ToolStripButton_RT_810_Salvar.Text = "Salvar Arquivo";
			this.ToolStripButton_RT_810_Salvar.ToolTipText = "Salvar arquivo";
			this.ToolStripSeparator1.AutoSize = false;
			global::System.Windows.Forms.ToolStripItem toolStripSeparator = this.ToolStripSeparator1;
			Padding = new Padding(10, 0, 0, 0);
			toolStripSeparator.Margin = Padding;
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			global::System.Windows.Forms.ToolStripItem toolStripSeparator2 = this.ToolStripSeparator1;
			Size = new System.Drawing.Size(6, 52);
			toolStripSeparator2.Size = this.Size;
			this.ToolStripButton_RT_810_Download.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT_810_Download.Image = global::iS800.My.Resources.Resources.Upload_icon;
			this.ToolStripButton_RT_810_Download.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT_810_Download = this.ToolStripButton_RT_810_Download;
			Padding = new Padding(10, 1, 0, 2);
			toolStripButton_RT_810_Download.Margin = Padding;
			this.ToolStripButton_RT_810_Download.Name = "ToolStripButton_RT_810_Download";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT_810_Download2 = this.ToolStripButton_RT_810_Download;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT_810_Download2.Size = this.Size;
			this.ToolStripButton_RT_810_Download.Text = "Ler Equipamento";
			this.ToolStripButton_RT_810_Upload.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT_810_Upload.Image = global::iS800.My.Resources.Resources.Download_icon;
			this.ToolStripButton_RT_810_Upload.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton_RT_810_Upload.Name = "ToolStripButton_RT_810_Upload";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT_810_Upload = this.ToolStripButton_RT_810_Upload;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT_810_Upload.Size = this.Size;
			this.ToolStripButton_RT_810_Upload.Text = "Gravar no equipamento";
			this.ToolStripSeparator2.AutoSize = false;
			global::System.Windows.Forms.ToolStripItem toolStripSeparator3 = this.ToolStripSeparator2;
			Padding = new Padding(10, 0, 0, 0);
			toolStripSeparator3.Margin = Padding;
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			global::System.Windows.Forms.ToolStripItem toolStripSeparator4 = this.ToolStripSeparator2;
			Size = new System.Drawing.Size(6, 52);
			toolStripSeparator4.Size = this.Size;
			this.ToolStripButton_RT_810_Imprimir.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT_810_Imprimir.Image = global::iS800.My.Resources.Resources.Hardware_Printer_Text_Icon_128;
			this.ToolStripButton_RT_810_Imprimir.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton_RT_810_Imprimir.Name = "ToolStripButton_RT_810_Imprimir";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT_810_Imprimir = this.ToolStripButton_RT_810_Imprimir;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT_810_Imprimir.Size = this.Size;
			this.ToolStripButton_RT_810_Imprimir.Text = "Impressão da ficha de configuração";
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
			this.ToolStripLabel_ID.Text = "RT810/200";
			this.ToolStripSeparator4.AutoSize = false;
			this.ToolStripSeparator4.Name = "ToolStripSeparator4";
			global::System.Windows.Forms.ToolStripItem toolStripSeparator6 = this.ToolStripSeparator4;
			Size = new System.Drawing.Size(6, 52);
			toolStripSeparator6.Size = this.Size;
			this.ToolStripTextBox_RT_810_Msg.BackColor = global::System.Drawing.Color.LightCyan;
			this.ToolStripTextBox_RT_810_Msg.BorderStyle = BorderStyle.FixedSingle;
			global::System.Windows.Forms.ToolStripItem toolStripTextBox_RT_810_Msg = this.ToolStripTextBox_RT_810_Msg;
			Padding = new Padding(10, 15, 1, 0);
			toolStripTextBox_RT_810_Msg.Margin = Padding;
			this.ToolStripTextBox_RT_810_Msg.Name = "ToolStripTextBox_RT_810_Msg";
			this.ToolStripTextBox_RT_810_Msg.ReadOnly = true;
			global::System.Windows.Forms.ToolStripControlHost toolStripTextBox_RT_810_Msg2 = this.ToolStripTextBox_RT_810_Msg;
			Size = new System.Drawing.Size(250, 23);
			toolStripTextBox_RT_810_Msg2.Size = this.Size;
			this.ToolStripTextBox_RT_810_Msg.TextBoxTextAlign = (System.Windows.Forms.HorizontalAlignment)2;
			this.ToolStripProgressBar_RT_810.BackColor = global::System.Drawing.SystemColors.Control;
			global::System.Windows.Forms.ToolStripItem toolStripProgressBar_RT_ = this.ToolStripProgressBar_RT_810;
			Padding = new Padding(20, 15, 1, 1);
			toolStripProgressBar_RT_.Margin = Padding;
			this.ToolStripProgressBar_RT_810.Name = "ToolStripProgressBar_RT_810";
			global::System.Windows.Forms.ToolStripControlHost toolStripProgressBar_RT_2 = this.ToolStripProgressBar_RT_810;
			Size = new System.Drawing.Size(180, 20);
			toolStripProgressBar_RT_2.Size = this.Size;
			this.ToolStripProgressBar_RT_810.ToolTipText = "Progresso da operação";
			this.OpenFileDialog_RT_810.FileName = "OpenFileDialog1";
			this.SaveFileDialog_RT_810.Filter = "RT810_200| *.RT810_200";
			this.Timer_limpa_MSG.Interval = 2000;
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
			global::System.Drawing.SizeF autoScaleDimensions;
			autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ControlLight;
			Size = new System.Drawing.Size(1065, 537);
			this.ClientSize = Size;
			this.Controls.Add(this.ToolStri_RT_810);
			this.Controls.Add(this.TabControl_810);
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.Name = "RT_810_200_conf";
			this.RightToLeftLayout = true;
			this.ShowIcon = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Configuração";
			this.TabControl_810.ResumeLayout(false);
			this.TabPage_geral.ResumeLayout(false);
			this.GroupBox_descricao_RT810.ResumeLayout(false);
			this.GroupBox_descricao_RT810.PerformLayout();
			this.GroupBox_sistema_leitura.ResumeLayout(false);
			this.GroupBox_ModoOperacao.ResumeLayout(false);
			this.GroupBox_ModoOperacao.PerformLayout();
			
			this.GroupBox_informacoes.ResumeLayout(false);
			this.GroupBox_informacoes.PerformLayout();
			this.GroupBox_comunicacao.ResumeLayout(false);
			this.GroupBox_comunicacao.PerformLayout();
			
			
			
			this.TabPage_EA.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			
			
			
			this.GroupBox_EA.ResumeLayout(false);
			this.GroupBox_EA.PerformLayout();
			
			
			this.TabPage_ED.ResumeLayout(false);
			this.GroupBox_ED.ResumeLayout(false);
			this.GroupBox_ED.PerformLayout();
			this.TabPage_repetidora.ResumeLayout(false);
			this.GroupBox_end_rep.ResumeLayout(false);
			
			this.GroupBox_parametros_repetidora.ResumeLayout(false);
			this.GroupBox_parametros_repetidora.PerformLayout();
			
			
			this.TabPage_dadosinstalacao.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ToolStri_RT_810.ResumeLayout(false);
			this.ToolStri_RT_810.PerformLayout();
			
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000489 RID: 1161
		private global::System.ComponentModel.IContainer components;
	}
}
