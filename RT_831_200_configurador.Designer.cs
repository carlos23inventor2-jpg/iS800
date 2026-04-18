using System.Drawing;
using System.Windows.Forms;
﻿namespace iS800
{
	// Token: 0x02000025 RID: 37
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class RT_831_200_configurador : global::System.Windows.Forms.Form
	{
		// Token: 0x060002C2 RID: 706 RVA: 0x0027C538 File Offset: 0x0027A938
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

		// Token: 0x060002C3 RID: 707 RVA: 0x0027C578 File Offset: 0x0027A978
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::iS800.RT_831_200_configurador));
			this.ToolStri_RT850 = new global::System.Windows.Forms.ToolStrip();
			this.ToolStripButton_RT850_novo = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripButton_RT850_Abrir = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripButton_RT850_Salvar = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ToolStripButton_RT850_Download = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripButton_RT850_Upload = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ToolStripButton_RT850_Imprimir = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ToolStripLabel1 = new global::System.Windows.Forms.ToolStripLabel();
			this.ToolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ToolStripTextBox_RT850_Msg = new global::System.Windows.Forms.ToolStripTextBox();
			this.ToolStripProgressBar_RT850 = new global::System.Windows.Forms.ToolStripProgressBar();
			this.TabControl_850 = new global::System.Windows.Forms.TabControl();
			this.TabPage_geral = new global::System.Windows.Forms.TabPage();
			this.GroupBox_descricao_RT850 = new global::System.Windows.Forms.GroupBox();
			this.TextBox_comentarios_RT850 = new global::System.Windows.Forms.TextBox();
			this.TextBox_endereco_RT850 = new global::System.Windows.Forms.TextBox();
			this.TextBox_nome_RT850 = new global::System.Windows.Forms.TextBox();
			this.Label_comentarios_RT850 = new global::System.Windows.Forms.Label();
			this.Label_endereco_RT850 = new global::System.Windows.Forms.Label();
			this.Label_nome_RT850 = new global::System.Windows.Forms.Label();
			this.tb_lixo1 = new global::System.Windows.Forms.TextBox();
			this.GroupBox_informacoes_RT850 = new global::System.Windows.Forms.GroupBox();
			this.Label11 = new global::System.Windows.Forms.Label();
			this.TextBox_equipamento_RT850 = new global::System.Windows.Forms.TextBox();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.TextBox_release_RT850 = new global::System.Windows.Forms.TextBox();
			this.Label29 = new global::System.Windows.Forms.Label();
			this.TextBox_build_RT850 = new global::System.Windows.Forms.TextBox();
			this.Label30 = new global::System.Windows.Forms.Label();
			this.TextBox_versao_RT850 = new global::System.Windows.Forms.TextBox();
			this.Label31 = new global::System.Windows.Forms.Label();
			this.TabPage_controles = new global::System.Windows.Forms.TabPage();
			this.GroupBox_canal_1_RT850 = new global::System.Windows.Forms.GroupBox();
			this.NumericUpDown_end_mestre = new global::System.Windows.Forms.NumericUpDown();
			this.NumericUpDown_end_estacao = new global::System.Windows.Forms.NumericUpDown();
			this.Label_num_tentativas_1_RT850 = new global::System.Windows.Forms.Label();
			this.NumericUpDown_temp_ptt_1_RT850 = new global::System.Windows.Forms.NumericUpDown();
			this.Label_tempo_ptt_1_RT850 = new global::System.Windows.Forms.Label();
			this.ComboBox_baudrate_RT850 = new global::System.Windows.Forms.ComboBox();
			this.Label_baudrate_1_RT850 = new global::System.Windows.Forms.Label();
			this.Label_end_canal_1_RT850 = new global::System.Windows.Forms.Label();
			this.tb_lixo2 = new global::System.Windows.Forms.TextBox();
			this.TabPage_Senha = new global::System.Windows.Forms.TabPage();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.NumericUpDown_senha = new global::System.Windows.Forms.NumericUpDown();
			this.tb_lixo3 = new global::System.Windows.Forms.TextBox();
			this.TabPage_Equipamentos = new global::System.Windows.Forms.TabPage();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.nud_numero_equipamentos_recalque = new global::System.Windows.Forms.NumericUpDown();
			this.nud_numero_equipamentos_reservatorios = new global::System.Windows.Forms.NumericUpDown();
			this.Label34 = new global::System.Windows.Forms.Label();
			this.Label33 = new global::System.Windows.Forms.Label();
			this.tb_lixo4 = new global::System.Windows.Forms.TextBox();
			this.TabPage_Reservatorio = new global::System.Windows.Forms.TabPage();
			this.GroupBox5 = new global::System.Windows.Forms.GroupBox();
			this.DataGridView_Reservatorios = new global::System.Windows.Forms.DataGridView();
			this.RES_Posicao = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RES_Nome = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tb_lixo5 = new global::System.Windows.Forms.TextBox();
			this.TabPage_Recalque = new global::System.Windows.Forms.TabPage();
			this.GroupBox6 = new global::System.Windows.Forms.GroupBox();
			this.DataGridView_Recalques = new global::System.Windows.Forms.DataGridView();
			this.REC_Posicao = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Nome = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Modelo = new global::System.Windows.Forms.DataGridViewComboBoxColumn();
			this.REC_HabCMD = new global::System.Windows.Forms.DataGridViewComboBoxColumn();
			this.REC_Escala1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Escala2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Escala3 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Escala4 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Escala5 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Escala6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Escala7 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Escala8 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Escala9 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Escala10 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Escala11 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Escala12 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Escala13 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Escala14 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Escala15 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REC_Escala16 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tb_lixo6 = new global::System.Windows.Forms.TextBox();
			this.TabPage1 = new global::System.Windows.Forms.TabPage();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.Label16 = new global::System.Windows.Forms.Label();
			this.Label15 = new global::System.Windows.Forms.Label();
			this.T_AlturaAntena1 = new global::System.Windows.Forms.TextBox();
			this.T_Latitude1 = new global::System.Windows.Forms.TextBox();
			this.T_Longitude1 = new global::System.Windows.Forms.TextBox();
			this.T_Azimute1 = new global::System.Windows.Forms.TextBox();
			this.Label14 = new global::System.Windows.Forms.Label();
			this.Label13 = new global::System.Windows.Forms.Label();
			this.T_FreqRadio1 = new global::System.Windows.Forms.TextBox();
			this.T_PotRadio1 = new global::System.Windows.Forms.TextBox();
			this.CB_ModeloRadio1 = new global::System.Windows.Forms.ComboBox();
			this.CB_PolarizacaoAntena1 = new global::System.Windows.Forms.ComboBox();
			this.CB_TipoAntena1 = new global::System.Windows.Forms.ComboBox();
			this.Label10 = new global::System.Windows.Forms.Label();
			this.Label9 = new global::System.Windows.Forms.Label();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label17 = new global::System.Windows.Forms.Label();
			this.tb_lixo7 = new global::System.Windows.Forms.TextBox();
			this.OpenFileDialog_RT850 = new global::System.Windows.Forms.OpenFileDialog();
			this.SaveFileDialog_RT850 = new global::System.Windows.Forms.SaveFileDialog();
			this.Timer_limpa_MSG_RT850 = new global::System.Windows.Forms.Timer(this.components);
			this.PrintDocument1 = new global::System.Drawing.Printing.PrintDocument();
			this.PrintPreviewDialog1 = new global::System.Windows.Forms.PrintPreviewDialog();
			this.ToolStri_RT850.SuspendLayout();
			this.TabControl_850.SuspendLayout();
			this.TabPage_geral.SuspendLayout();
			this.GroupBox_descricao_RT850.SuspendLayout();
			this.GroupBox_informacoes_RT850.SuspendLayout();
			this.TabPage_controles.SuspendLayout();
			this.GroupBox_canal_1_RT850.SuspendLayout();
			
			
			
			this.TabPage_Senha.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			
			this.TabPage_Equipamentos.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			
			
			this.TabPage_Reservatorio.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			
			this.TabPage_Recalque.SuspendLayout();
			this.GroupBox6.SuspendLayout();
			
			this.TabPage1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.SuspendLayout();
			this.ToolStri_RT850.BackColor = global::System.Drawing.Color.Transparent;
			this.ToolStri_RT850.GripStyle = 0;
			global::System.Windows.Forms.ToolStrip toolStri_RT = this.ToolStri_RT850;
			toolStri_RT.ImageScalingSize = new global::System.Drawing.Size(48, 48);
			toolStri_RT.ImageScalingSize = Size;
			this.ToolStri_RT850.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripButton_RT850_novo,
				this.ToolStripButton_RT850_Abrir,
				this.ToolStripButton_RT850_Salvar,
				this.ToolStripSeparator1,
				this.ToolStripButton_RT850_Download,
				this.ToolStripButton_RT850_Upload,
				this.ToolStripSeparator2,
				this.ToolStripButton_RT850_Imprimir,
				this.ToolStripSeparator3,
				this.ToolStripLabel1,
				this.ToolStripSeparator4,
				this.ToolStripTextBox_RT850_Msg,
				this.ToolStripProgressBar_RT850
			});
			this.ToolStri_RT850.LayoutStyle =(System.Windows.Forms.ToolStripLayoutStyle)3;
			global::System.Windows.Forms.Control toolStri_RT2 = this.ToolStri_RT850;
			toolStri_RT2.Location = new global::System.Drawing.Point(0, 0);
			this.ToolStri_RT850.Name = "ToolStri_RT850";
			global::System.Windows.Forms.Control toolStri_RT3 = this.ToolStri_RT850;
			Size = new System.Drawing.Size(1258, 55);
			toolStri_RT3.Size = this.Size;
			this.ToolStri_RT850.Stretch = true;
			this.ToolStri_RT850.TabIndex = 10;
			this.ToolStri_RT850.Text = "ToolStrip1";
			this.ToolStripButton_RT850_novo.AutoToolTip = false;
			this.ToolStripButton_RT850_novo.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT850_novo.Image = global::iS800.My.Resources.Resources.folder_add_icon1;
			this.ToolStripButton_RT850_novo.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT850_novo = this.ToolStripButton_RT850_novo;
			global::System.Windows.Forms.Padding Padding;
			Padding = new global::System.Windows.Forms.Padding(10, 1, 0, 2);
			toolStripButton_RT850_novo.Margin = Padding;
			this.ToolStripButton_RT850_novo.Name = "ToolStripButton_RT850_novo";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT850_novo2 = this.ToolStripButton_RT850_novo;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT850_novo2.Size = this.Size;
			this.ToolStripButton_RT850_novo.Text = "Novo";
			this.ToolStripButton_RT850_novo.ToolTipText = "Novo arquivo";
			this.ToolStripButton_RT850_Abrir.AutoToolTip = false;
			this.ToolStripButton_RT850_Abrir.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT850_Abrir.Image = global::iS800.My.Resources.Resources.folder_up_icon;
			this.ToolStripButton_RT850_Abrir.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton_RT850_Abrir.Name = "ToolStripButton_RT850_Abrir";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT850_Abrir = this.ToolStripButton_RT850_Abrir;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT850_Abrir.Size = this.Size;
			this.ToolStripButton_RT850_Abrir.Text = "Abrir Arquivo";
			this.ToolStripButton_RT850_Abrir.ToolTipText = "Abrir arquivo";
			this.ToolStripButton_RT850_Salvar.AutoToolTip = false;
			this.ToolStripButton_RT850_Salvar.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT850_Salvar.Image = global::iS800.My.Resources.Resources.folder_down_icon;
			this.ToolStripButton_RT850_Salvar.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton_RT850_Salvar.Name = "ToolStripButton_RT850_Salvar";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT850_Salvar = this.ToolStripButton_RT850_Salvar;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT850_Salvar.Size = this.Size;
			this.ToolStripButton_RT850_Salvar.Text = "Salvar Arquivo";
			this.ToolStripButton_RT850_Salvar.ToolTipText = "Salvar arquivo";
			this.ToolStripSeparator1.AutoSize = false;
			global::System.Windows.Forms.ToolStripItem toolStripSeparator = this.ToolStripSeparator1;
			Padding = new Padding(10, 0, 0, 0);
			toolStripSeparator.Margin = Padding;
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			global::System.Windows.Forms.ToolStripItem toolStripSeparator2 = this.ToolStripSeparator1;
			Size = new System.Drawing.Size(6, 52);
			toolStripSeparator2.Size = this.Size;
			this.ToolStripButton_RT850_Download.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT850_Download.Image = global::iS800.My.Resources.Resources.Upload_icon;
			this.ToolStripButton_RT850_Download.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT850_Download = this.ToolStripButton_RT850_Download;
			Padding = new Padding(10, 1, 0, 2);
			toolStripButton_RT850_Download.Margin = Padding;
			this.ToolStripButton_RT850_Download.Name = "ToolStripButton_RT850_Download";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT850_Download2 = this.ToolStripButton_RT850_Download;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT850_Download2.Size = this.Size;
			this.ToolStripButton_RT850_Download.Text = "Ler Equipamento";
			this.ToolStripButton_RT850_Upload.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT850_Upload.Image = global::iS800.My.Resources.Resources.Download_icon;
			this.ToolStripButton_RT850_Upload.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton_RT850_Upload.Name = "ToolStripButton_RT850_Upload";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT850_Upload = this.ToolStripButton_RT850_Upload;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT850_Upload.Size = this.Size;
			this.ToolStripButton_RT850_Upload.Text = "Gravar no equipamento";
			this.ToolStripSeparator2.AutoSize = false;
			global::System.Windows.Forms.ToolStripItem toolStripSeparator3 = this.ToolStripSeparator2;
			Padding = new Padding(10, 0, 0, 0);
			toolStripSeparator3.Margin = Padding;
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			global::System.Windows.Forms.ToolStripItem toolStripSeparator4 = this.ToolStripSeparator2;
			Size = new System.Drawing.Size(6, 52);
			toolStripSeparator4.Size = this.Size;
			this.ToolStripButton_RT850_Imprimir.DisplayStyle =(System.Windows.Forms.ToolStripItemDisplayStyle)2;
			this.ToolStripButton_RT850_Imprimir.Image = global::iS800.My.Resources.Resources.Hardware_Printer_Text_Icon_128;
			this.ToolStripButton_RT850_Imprimir.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton_RT850_Imprimir.Name = "ToolStripButton_RT850_Imprimir";
			global::System.Windows.Forms.ToolStripItem toolStripButton_RT850_Imprimir = this.ToolStripButton_RT850_Imprimir;
			Size = new System.Drawing.Size(52, 52);
			toolStripButton_RT850_Imprimir.Size = this.Size;
			this.ToolStripButton_RT850_Imprimir.Text = "Impressão da ficha de configuração";
			this.ToolStripSeparator3.AutoSize = false;
			this.ToolStripSeparator3.Name = "ToolStripSeparator3";
			global::System.Windows.Forms.ToolStripItem toolStripSeparator5 = this.ToolStripSeparator3;
			Size = new System.Drawing.Size(6, 52);
			toolStripSeparator5.Size = this.Size;
			this.ToolStripLabel1.Font = new global::System.Drawing.Font("Arial Narrow", 18f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ToolStripLabel1.ForeColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			global::System.Windows.Forms.ToolStripItem toolStripLabel = this.ToolStripLabel1;
			Padding = new Padding(5, 13, 0, 2);
			toolStripLabel.Margin = Padding;
			this.ToolStripLabel1.Name = "ToolStripLabel1";
			global::System.Windows.Forms.ToolStripItem toolStripLabel2 = this.ToolStripLabel1;
			Size = new System.Drawing.Size(110, 29);
			toolStripLabel2.Size = this.Size;
			this.ToolStripLabel1.Text = "CT831/200";
			this.ToolStripSeparator4.AutoSize = false;
			this.ToolStripSeparator4.Name = "ToolStripSeparator4";
			global::System.Windows.Forms.ToolStripItem toolStripSeparator6 = this.ToolStripSeparator4;
			Size = new System.Drawing.Size(6, 52);
			toolStripSeparator6.Size = this.Size;
			this.ToolStripTextBox_RT850_Msg.BackColor = global::System.Drawing.Color.LightCyan;
			this.ToolStripTextBox_RT850_Msg.BorderStyle = BorderStyle.FixedSingle;
			global::System.Windows.Forms.ToolStripItem toolStripTextBox_RT850_Msg = this.ToolStripTextBox_RT850_Msg;
			Padding = new Padding(10, 15, 1, 0);
			toolStripTextBox_RT850_Msg.Margin = Padding;
			this.ToolStripTextBox_RT850_Msg.Name = "ToolStripTextBox_RT850_Msg";
			this.ToolStripTextBox_RT850_Msg.ReadOnly = true;
			global::System.Windows.Forms.ToolStripControlHost toolStripTextBox_RT850_Msg2 = this.ToolStripTextBox_RT850_Msg;
			Size = new System.Drawing.Size(250, 23);
			toolStripTextBox_RT850_Msg2.Size = this.Size;
			this.ToolStripTextBox_RT850_Msg.TextBoxTextAlign = (System.Windows.Forms.HorizontalAlignment)2;
			this.ToolStripProgressBar_RT850.BackColor = global::System.Drawing.SystemColors.Control;
			global::System.Windows.Forms.ToolStripItem toolStripProgressBar_RT = this.ToolStripProgressBar_RT850;
			Padding = new Padding(20, 15, 1, 1);
			toolStripProgressBar_RT.Margin = Padding;
			this.ToolStripProgressBar_RT850.Name = "ToolStripProgressBar_RT850";
			global::System.Windows.Forms.ToolStripControlHost toolStripProgressBar_RT2 = this.ToolStripProgressBar_RT850;
			Size = new System.Drawing.Size(180, 20);
			toolStripProgressBar_RT2.Size = this.Size;
			this.ToolStripProgressBar_RT850.ToolTipText = "Progresso da operação";
			this.TabControl_850.Controls.Add(this.TabPage_geral);
			this.TabControl_850.Controls.Add(this.TabPage_controles);
			this.TabControl_850.Controls.Add(this.TabPage_Senha);
			this.TabControl_850.Controls.Add(this.TabPage_Equipamentos);
			this.TabControl_850.Controls.Add(this.TabPage_Reservatorio);
			this.TabControl_850.Controls.Add(this.TabPage_Recalque);
			this.TabControl_850.Controls.Add(this.TabPage1);
			this.TabControl_850.HotTrack = true;
			global::System.Windows.Forms.Control tabControl_ = this.TabControl_850;
tabControl_.Location = new global::System.Drawing.Point(0, 58);
			this.TabControl_850.Name = "TabControl_850";
			this.TabControl_850.SelectedIndex = 0;
			global::System.Windows.Forms.Control tabControl_2 = this.TabControl_850;
			Size = new System.Drawing.Size(1246, 575);
			tabControl_2.Size = this.Size;
			this.TabControl_850.TabIndex = 11;
			this.TabPage_geral.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.TabPage_geral.Controls.Add(this.GroupBox_descricao_RT850);
			this.TabPage_geral.Controls.Add(this.GroupBox_informacoes_RT850);
			global::System.Windows.Forms.TabPage tabPage_geral = this.TabPage_geral;
tabPage_geral.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_geral.Name = "TabPage_geral";
			global::System.Windows.Forms.Control tabPage_geral2 = this.TabPage_geral;
			Padding = new Padding(3);
			tabPage_geral2.Padding = Padding;
			global::System.Windows.Forms.Control tabPage_geral3 = this.TabPage_geral;
			Size = new System.Drawing.Size(1238, 549);
			tabPage_geral3.Size = this.Size;
			this.TabPage_geral.TabIndex = 0;
			this.TabPage_geral.Text = "Geral";
			this.TabPage_geral.UseVisualStyleBackColor = true;
			this.GroupBox_descricao_RT850.Controls.Add(this.TextBox_comentarios_RT850);
			this.GroupBox_descricao_RT850.Controls.Add(this.TextBox_endereco_RT850);
			this.GroupBox_descricao_RT850.Controls.Add(this.TextBox_nome_RT850);
			this.GroupBox_descricao_RT850.Controls.Add(this.Label_comentarios_RT850);
			this.GroupBox_descricao_RT850.Controls.Add(this.Label_endereco_RT850);
			this.GroupBox_descricao_RT850.Controls.Add(this.Label_nome_RT850);
			this.GroupBox_descricao_RT850.Controls.Add(this.tb_lixo1);
			global::System.Windows.Forms.Control groupBox_descricao_RT = this.GroupBox_descricao_RT850;
groupBox_descricao_RT.Location = new global::System.Drawing.Point(8, 6);
			this.GroupBox_descricao_RT850.Name = "GroupBox_descricao_RT850";
			global::System.Windows.Forms.Control groupBox_descricao_RT2 = this.GroupBox_descricao_RT850;
			Size = new System.Drawing.Size(580, 217);
			groupBox_descricao_RT2.Size = this.Size;
			this.GroupBox_descricao_RT850.TabIndex = 16;
			this.GroupBox_descricao_RT850.TabStop = false;
			this.GroupBox_descricao_RT850.Text = "Descrição:";
			global::System.Windows.Forms.Control textBox_comentarios_RT = this.TextBox_comentarios_RT850;
textBox_comentarios_RT.Location = new global::System.Drawing.Point(26, 100);
			this.TextBox_comentarios_RT850.MaxLength = 400;
			this.TextBox_comentarios_RT850.Multiline = true;
			this.TextBox_comentarios_RT850.Name = "TextBox_comentarios_RT850";
			this.TextBox_comentarios_RT850.ScrollBars =(System.Windows.Forms.ScrollBars)2;
			global::System.Windows.Forms.Control textBox_comentarios_RT2 = this.TextBox_comentarios_RT850;
			Size = new System.Drawing.Size(534, 99);
			textBox_comentarios_RT2.Size = this.Size;
			this.TextBox_comentarios_RT850.TabIndex = 3;
			global::System.Windows.Forms.Control textBox_endereco_RT = this.TextBox_endereco_RT850;
textBox_endereco_RT.Location = new global::System.Drawing.Point(70, 53);
			this.TextBox_endereco_RT850.MaxLength = 60;
			this.TextBox_endereco_RT850.Name = "TextBox_endereco_RT850";
			global::System.Windows.Forms.Control textBox_endereco_RT2 = this.TextBox_endereco_RT850;
			Size = new System.Drawing.Size(490, 20);
			textBox_endereco_RT2.Size = this.Size;
			this.TextBox_endereco_RT850.TabIndex = 2;
			global::System.Windows.Forms.Control textBox_nome_RT = this.TextBox_nome_RT850;
textBox_nome_RT.Location = new global::System.Drawing.Point(70, 27);
			this.TextBox_nome_RT850.MaxLength = 60;
			this.TextBox_nome_RT850.Name = "TextBox_nome_RT850";
			global::System.Windows.Forms.Control textBox_nome_RT2 = this.TextBox_nome_RT850;
			Size = new System.Drawing.Size(490, 20);
			textBox_nome_RT2.Size = this.Size;
			this.TextBox_nome_RT850.TabIndex = 1;
			this.Label_comentarios_RT850.AutoSize = true;
			global::System.Windows.Forms.Control label_comentarios_RT = this.Label_comentarios_RT850;
label_comentarios_RT.Location = new global::System.Drawing.Point(23, 84);
			this.Label_comentarios_RT850.Name = "Label_comentarios_RT850";
			global::System.Windows.Forms.Control label_comentarios_RT2 = this.Label_comentarios_RT850;
			Size = new System.Drawing.Size(71, 13);
			label_comentarios_RT2.Size = this.Size;
			this.Label_comentarios_RT850.TabIndex = 0;
			this.Label_comentarios_RT850.Text = "Comentários :";
			this.Label_endereco_RT850.AutoSize = true;
			global::System.Windows.Forms.Control label_endereco_RT = this.Label_endereco_RT850;
label_endereco_RT.Location = new global::System.Drawing.Point(23, 56);
			this.Label_endereco_RT850.Name = "Label_endereco_RT850";
			global::System.Windows.Forms.Control label_endereco_RT2 = this.Label_endereco_RT850;
			Size = new System.Drawing.Size(32, 13);
			label_endereco_RT2.Size = this.Size;
			this.Label_endereco_RT850.TabIndex = 0;
			this.Label_endereco_RT850.Text = "End :";
			this.Label_nome_RT850.AutoSize = true;
			global::System.Windows.Forms.Control label_nome_RT = this.Label_nome_RT850;
label_nome_RT.Location = new global::System.Drawing.Point(23, 33);
			this.Label_nome_RT850.Name = "Label_nome_RT850";
			global::System.Windows.Forms.Control label_nome_RT2 = this.Label_nome_RT850;
			Size = new System.Drawing.Size(41, 13);
			label_nome_RT2.Size = this.Size;
			this.Label_nome_RT850.TabIndex = 0;
			this.Label_nome_RT850.Text = "Nome :";
			global::System.Windows.Forms.Control tb_lixo = this.tb_lixo1;
tb_lixo.Location = new global::System.Drawing.Point(124, 155);
			this.tb_lixo1.Name = "tb_lixo1";
			global::System.Windows.Forms.Control tb_lixo2 = this.tb_lixo1;
			Size = new System.Drawing.Size(100, 20);
			tb_lixo2.Size = this.Size;
			this.tb_lixo1.TabIndex = 4;
			this.GroupBox_informacoes_RT850.Controls.Add(this.Label11);
			this.GroupBox_informacoes_RT850.Controls.Add(this.TextBox_equipamento_RT850);
			this.GroupBox_informacoes_RT850.Controls.Add(this.Label19);
			this.GroupBox_informacoes_RT850.Controls.Add(this.TextBox_release_RT850);
			this.GroupBox_informacoes_RT850.Controls.Add(this.Label29);
			this.GroupBox_informacoes_RT850.Controls.Add(this.TextBox_build_RT850);
			this.GroupBox_informacoes_RT850.Controls.Add(this.Label30);
			this.GroupBox_informacoes_RT850.Controls.Add(this.TextBox_versao_RT850);
			this.GroupBox_informacoes_RT850.Controls.Add(this.Label31);
			this.GroupBox_informacoes_RT850.Enabled = false;
			global::System.Windows.Forms.Control groupBox_informacoes_RT = this.GroupBox_informacoes_RT850;
groupBox_informacoes_RT.Location = new global::System.Drawing.Point(8, 242);
			this.GroupBox_informacoes_RT850.Name = "GroupBox_informacoes_RT850";
			global::System.Windows.Forms.Control groupBox_informacoes_RT2 = this.GroupBox_informacoes_RT850;
			Size = new System.Drawing.Size(580, 116);
			groupBox_informacoes_RT2.Size = this.Size;
			this.GroupBox_informacoes_RT850.TabIndex = 14;
			this.GroupBox_informacoes_RT850.TabStop = false;
			this.GroupBox_informacoes_RT850.Text = "Informações";
			this.Label11.AutoSize = true;
			this.Label11.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control label = this.Label11;
label.Location = new global::System.Drawing.Point(164, 61);
			this.Label11.Name = "Label11";
			global::System.Windows.Forms.Control label2 = this.Label11;
			Size = new System.Drawing.Size(19, 15);
			label2.Size = this.Size;
			this.Label11.TabIndex = 35;
			this.Label11.Text = "CT";
			this.TextBox_equipamento_RT850.BackColor = global::System.Drawing.Color.LightCyan;
			this.TextBox_equipamento_RT850.Font = new global::System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control textBox_equipamento_RT = this.TextBox_equipamento_RT850;
textBox_equipamento_RT.Location = new global::System.Drawing.Point(199, 58);
			this.TextBox_equipamento_RT850.Name = "TextBox_equipamento_RT850";
			this.TextBox_equipamento_RT850.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_equipamento_RT2 = this.TextBox_equipamento_RT850;
			Size = new System.Drawing.Size(47, 20);
			textBox_equipamento_RT2.Size = this.Size;
			this.TextBox_equipamento_RT850.TabIndex = 34;
			this.TextBox_equipamento_RT850.TabStop = false;
			this.TextBox_equipamento_RT850.TextAlign = HorizontalAlignment.Right;
			this.Label19.AutoSize = true;
			global::System.Windows.Forms.Control label3 = this.Label19;
label3.Location = new global::System.Drawing.Point(164, 40);
			this.Label19.Name = "Label19";
			global::System.Windows.Forms.Control label4 = this.Label19;
			Size = new System.Drawing.Size(69, 13);
			label4.Size = this.Size;
			this.Label19.TabIndex = 33;
			this.Label19.Text = "Equipamento";
			this.TextBox_release_RT850.BackColor = global::System.Drawing.Color.LightCyan;
			this.TextBox_release_RT850.Font = new global::System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control textBox_release_RT = this.TextBox_release_RT850;
textBox_release_RT.Location = new global::System.Drawing.Point(355, 58);
			this.TextBox_release_RT850.Name = "TextBox_release_RT850";
			this.TextBox_release_RT850.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_release_RT2 = this.TextBox_release_RT850;
			Size = new System.Drawing.Size(47, 20);
			textBox_release_RT2.Size = this.Size;
			this.TextBox_release_RT850.TabIndex = 32;
			this.TextBox_release_RT850.TabStop = false;
			this.TextBox_release_RT850.TextAlign = HorizontalAlignment.Right;
			this.Label29.AutoSize = true;
			global::System.Windows.Forms.Control label5 = this.Label29;
label5.Location = new global::System.Drawing.Point(358, 40);
			this.Label29.Name = "Label29";
			global::System.Windows.Forms.Control label6 = this.Label29;
			Size = new System.Drawing.Size(46, 13);
			label6.Size = this.Size;
			this.Label29.TabIndex = 31;
			this.Label29.Text = "Release";
			this.TextBox_build_RT850.BackColor = global::System.Drawing.Color.LightCyan;
			this.TextBox_build_RT850.Font = new global::System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control textBox_build_RT = this.TextBox_build_RT850;
textBox_build_RT.Location = new global::System.Drawing.Point(303, 58);
			this.TextBox_build_RT850.Name = "TextBox_build_RT850";
			this.TextBox_build_RT850.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_build_RT2 = this.TextBox_build_RT850;
			Size = new System.Drawing.Size(47, 20);
			textBox_build_RT2.Size = this.Size;
			this.TextBox_build_RT850.TabIndex = 30;
			this.TextBox_build_RT850.TabStop = false;
			this.TextBox_build_RT850.TextAlign = HorizontalAlignment.Right;
			this.Label30.AutoSize = true;
			global::System.Windows.Forms.Control label7 = this.Label30;
label7.Location = new global::System.Drawing.Point(312, 40);
			this.Label30.Name = "Label30";
			global::System.Windows.Forms.Control label8 = this.Label30;
			Size = new System.Drawing.Size(30, 13);
			label8.Size = this.Size;
			this.Label30.TabIndex = 29;
			this.Label30.Text = "Build";
			this.TextBox_versao_RT850.BackColor = global::System.Drawing.Color.LightCyan;
			this.TextBox_versao_RT850.Font = new global::System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control textBox_versao_RT = this.TextBox_versao_RT850;
textBox_versao_RT.Location = new global::System.Drawing.Point(251, 58);
			this.TextBox_versao_RT850.Name = "TextBox_versao_RT850";
			this.TextBox_versao_RT850.ReadOnly = true;
			global::System.Windows.Forms.Control textBox_versao_RT2 = this.TextBox_versao_RT850;
			Size = new System.Drawing.Size(47, 20);
			textBox_versao_RT2.Size = this.Size;
			this.TextBox_versao_RT850.TabIndex = 28;
			this.TextBox_versao_RT850.TabStop = false;
			this.TextBox_versao_RT850.TextAlign = HorizontalAlignment.Right;
			this.Label31.AutoSize = true;
			global::System.Windows.Forms.Control label9 = this.Label31;
label9.Location = new global::System.Drawing.Point(254, 40);
			this.Label31.Name = "Label31";
			global::System.Windows.Forms.Control label10 = this.Label31;
			Size = new System.Drawing.Size(40, 13);
			label10.Size = this.Size;
			this.Label31.TabIndex = 27;
			this.Label31.Text = "Versão";
			this.TabPage_controles.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.TabPage_controles.Controls.Add(this.GroupBox_canal_1_RT850);
			global::System.Windows.Forms.TabPage tabPage_controles = this.TabPage_controles;
tabPage_controles.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_controles.Name = "TabPage_controles";
			global::System.Windows.Forms.Control tabPage_controles2 = this.TabPage_controles;
			Padding = new Padding(3);
			tabPage_controles2.Padding = Padding;
			global::System.Windows.Forms.Control tabPage_controles3 = this.TabPage_controles;
			Size = new System.Drawing.Size(1238, 549);
			tabPage_controles3.Size = this.Size;
			this.TabPage_controles.TabIndex = 1;
			this.TabPage_controles.Text = "Comunicação";
			this.TabPage_controles.UseVisualStyleBackColor = true;
			this.GroupBox_canal_1_RT850.Controls.Add(this.NumericUpDown_end_mestre);
			this.GroupBox_canal_1_RT850.Controls.Add(this.NumericUpDown_end_estacao);
			this.GroupBox_canal_1_RT850.Controls.Add(this.Label_num_tentativas_1_RT850);
			this.GroupBox_canal_1_RT850.Controls.Add(this.NumericUpDown_temp_ptt_1_RT850);
			this.GroupBox_canal_1_RT850.Controls.Add(this.Label_tempo_ptt_1_RT850);
			this.GroupBox_canal_1_RT850.Controls.Add(this.ComboBox_baudrate_RT850);
			this.GroupBox_canal_1_RT850.Controls.Add(this.Label_baudrate_1_RT850);
			this.GroupBox_canal_1_RT850.Controls.Add(this.Label_end_canal_1_RT850);
			this.GroupBox_canal_1_RT850.Controls.Add(this.tb_lixo2);
			global::System.Windows.Forms.Control groupBox_canal_1_RT = this.GroupBox_canal_1_RT850;
groupBox_canal_1_RT.Location = new global::System.Drawing.Point(17, 23);
			this.GroupBox_canal_1_RT850.Name = "GroupBox_canal_1_RT850";
			global::System.Windows.Forms.Control groupBox_canal_1_RT2 = this.GroupBox_canal_1_RT850;
			Size = new System.Drawing.Size(293, 183);
			groupBox_canal_1_RT2.Size = this.Size;
			this.GroupBox_canal_1_RT850.TabIndex = 0;
			this.GroupBox_canal_1_RT850.TabStop = false;
			this.GroupBox_canal_1_RT850.Text = "Canal de Rádio";
			global::System.Windows.Forms.Control numericUpDown_end_mestre = this.NumericUpDown_end_mestre;
numericUpDown_end_mestre.Location = new global::System.Drawing.Point(189, 24);
			global::System.Windows.Forms.NumericUpDown numericUpDown_end_mestre2 = this.NumericUpDown_end_mestre;
			decimal num;
			num = new decimal(new int[]
			{
				70000,
				0,
				0,
				0
			});
			numericUpDown_end_mestre2.Maximum = num;
			global::System.Windows.Forms.NumericUpDown numericUpDown_end_mestre3 = this.NumericUpDown_end_mestre;
			num = new decimal(new int[]
			{
				2,
				0,
				0,
				0
			});
			numericUpDown_end_mestre3.Minimum = num;
			this.NumericUpDown_end_mestre.Name = "NumericUpDown_end_mestre";
			global::System.Windows.Forms.Control numericUpDown_end_mestre4 = this.NumericUpDown_end_mestre;
			Size = new System.Drawing.Size(72, 20);
			numericUpDown_end_mestre4.Size = this.Size;
			this.NumericUpDown_end_mestre.TabIndex = 17;
			this.NumericUpDown_end_mestre.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.NumericUpDown numericUpDown_end_mestre5 = this.NumericUpDown_end_mestre;
			num = new decimal(new int[]
			{
				3,
				0,
				0,
				0
			});
			numericUpDown_end_mestre5.Value = num;
			global::System.Windows.Forms.Control numericUpDown_end_estacao = this.NumericUpDown_end_estacao;
numericUpDown_end_estacao.Location = new global::System.Drawing.Point(189, 57);
			global::System.Windows.Forms.NumericUpDown numericUpDown_end_estacao2 = this.NumericUpDown_end_estacao;
			num = new decimal(new int[]
			{
				70000,
				0,
				0,
				0
			});
			numericUpDown_end_estacao2.Maximum = num;
			this.NumericUpDown_end_estacao.Name = "NumericUpDown_end_estacao";
			global::System.Windows.Forms.Control numericUpDown_end_estacao3 = this.NumericUpDown_end_estacao;
			Size = new System.Drawing.Size(72, 20);
			numericUpDown_end_estacao3.Size = this.Size;
			this.NumericUpDown_end_estacao.TabIndex = 13;
			this.NumericUpDown_end_estacao.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.NumericUpDown numericUpDown_end_estacao4 = this.NumericUpDown_end_estacao;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			numericUpDown_end_estacao4.Value = num;
			this.Label_num_tentativas_1_RT850.AutoSize = true;
			global::System.Windows.Forms.Control label_num_tentativas_1_RT = this.Label_num_tentativas_1_RT850;
label_num_tentativas_1_RT.Location = new global::System.Drawing.Point(22, 60);
			this.Label_num_tentativas_1_RT850.Name = "Label_num_tentativas_1_RT850";
			global::System.Windows.Forms.Control label_num_tentativas_1_RT2 = this.Label_num_tentativas_1_RT850;
			Size = new System.Drawing.Size(113, 13);
			label_num_tentativas_1_RT2.Size = this.Size;
			this.Label_num_tentativas_1_RT850.TabIndex = 14;
			this.Label_num_tentativas_1_RT850.Text = "Endereço da Estação:";
			global::System.Windows.Forms.NumericUpDown numericUpDown_temp_ptt_1_RT = this.NumericUpDown_temp_ptt_1_RT850;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			numericUpDown_temp_ptt_1_RT.Increment = num;
			global::System.Windows.Forms.Control numericUpDown_temp_ptt_1_RT2 = this.NumericUpDown_temp_ptt_1_RT850;
numericUpDown_temp_ptt_1_RT2.Location = new global::System.Drawing.Point(189, 94);
			global::System.Windows.Forms.NumericUpDown numericUpDown_temp_ptt_1_RT3 = this.NumericUpDown_temp_ptt_1_RT850;
			num = new decimal(new int[]
			{
				70000,
				0,
				0,
				0
			});
			numericUpDown_temp_ptt_1_RT3.Maximum = num;
			global::System.Windows.Forms.NumericUpDown numericUpDown_temp_ptt_1_RT4 = this.NumericUpDown_temp_ptt_1_RT850;
			num = new decimal(new int[]
			{
				100,
				0,
				0,
				0
			});
			numericUpDown_temp_ptt_1_RT4.Minimum = num;
			this.NumericUpDown_temp_ptt_1_RT850.Name = "NumericUpDown_temp_ptt_1_RT850";
			global::System.Windows.Forms.Control numericUpDown_temp_ptt_1_RT5 = this.NumericUpDown_temp_ptt_1_RT850;
			Size = new System.Drawing.Size(72, 20);
			numericUpDown_temp_ptt_1_RT5.Size = this.Size;
			this.NumericUpDown_temp_ptt_1_RT850.TabIndex = 11;
			this.NumericUpDown_temp_ptt_1_RT850.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.NumericUpDown numericUpDown_temp_ptt_1_RT6 = this.NumericUpDown_temp_ptt_1_RT850;
			num = new decimal(new int[]
			{
				100,
				0,
				0,
				0
			});
			numericUpDown_temp_ptt_1_RT6.Value = num;
			this.Label_tempo_ptt_1_RT850.AutoSize = true;
			global::System.Windows.Forms.Control label_tempo_ptt_1_RT = this.Label_tempo_ptt_1_RT850;
label_tempo_ptt_1_RT.Location = new global::System.Drawing.Point(22, 97);
			this.Label_tempo_ptt_1_RT850.Name = "Label_tempo_ptt_1_RT850";
			global::System.Windows.Forms.Control label_tempo_ptt_1_RT2 = this.Label_tempo_ptt_1_RT850;
			Size = new System.Drawing.Size(104, 13);
			label_tempo_ptt_1_RT2.Size = this.Size;
			this.Label_tempo_ptt_1_RT850.TabIndex = 12;
			this.Label_tempo_ptt_1_RT850.Text = "Tempo de PTT (ms):";
			this.ComboBox_baudrate_RT850.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox_baudrate_RT = this.ComboBox_baudrate_RT850;
comboBox_baudrate_RT.Location = new global::System.Drawing.Point(117, 131);
			this.ComboBox_baudrate_RT850.Name = "ComboBox_baudrate_RT850";
			global::System.Windows.Forms.Control comboBox_baudrate_RT2 = this.ComboBox_baudrate_RT850;
			Size = new System.Drawing.Size(144, 21);
			comboBox_baudrate_RT2.Size = this.Size;
			this.ComboBox_baudrate_RT850.TabIndex = 8;
			this.Label_baudrate_1_RT850.AutoSize = true;
			global::System.Windows.Forms.Control label_baudrate_1_RT = this.Label_baudrate_1_RT850;
label_baudrate_1_RT.Location = new global::System.Drawing.Point(22, 135);
			this.Label_baudrate_1_RT850.Name = "Label_baudrate_1_RT850";
			global::System.Windows.Forms.Control label_baudrate_1_RT2 = this.Label_baudrate_1_RT850;
			Size = new System.Drawing.Size(56, 13);
			label_baudrate_1_RT2.Size = this.Size;
			this.Label_baudrate_1_RT850.TabIndex = 7;
			this.Label_baudrate_1_RT850.Text = "Baudrate :";
			this.Label_end_canal_1_RT850.AutoSize = true;
			global::System.Windows.Forms.Control label_end_canal_1_RT = this.Label_end_canal_1_RT850;
label_end_canal_1_RT.Location = new global::System.Drawing.Point(22, 28);
			this.Label_end_canal_1_RT850.Name = "Label_end_canal_1_RT850";
			global::System.Windows.Forms.Control label_end_canal_1_RT2 = this.Label_end_canal_1_RT850;
			Size = new System.Drawing.Size(109, 13);
			label_end_canal_1_RT2.Size = this.Size;
			this.Label_end_canal_1_RT850.TabIndex = 0;
			this.Label_end_canal_1_RT850.Text = "Endereço do Mestre :";
			global::System.Windows.Forms.Control tb_lixo3 = this.tb_lixo2;
tb_lixo3.Location = new global::System.Drawing.Point(151, 131);
			this.tb_lixo2.Name = "tb_lixo2";
			global::System.Windows.Forms.Control tb_lixo4 = this.tb_lixo2;
			Size = new System.Drawing.Size(63, 20);
			tb_lixo4.Size = this.Size;
			this.tb_lixo2.TabIndex = 18;
			this.TabPage_Senha.Controls.Add(this.GroupBox3);
			global::System.Windows.Forms.TabPage tabPage_Senha = this.TabPage_Senha;
tabPage_Senha.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_Senha.Name = "TabPage_Senha";
			global::System.Windows.Forms.Control tabPage_Senha2 = this.TabPage_Senha;
			Padding = new Padding(3);
			tabPage_Senha2.Padding = Padding;
			global::System.Windows.Forms.Control tabPage_Senha3 = this.TabPage_Senha;
			Size = new System.Drawing.Size(1238, 549);
			tabPage_Senha3.Size = this.Size;
			this.TabPage_Senha.TabIndex = 12;
			this.TabPage_Senha.Text = "Senha";
			this.TabPage_Senha.UseVisualStyleBackColor = true;
			this.GroupBox3.Controls.Add(this.Label1);
			this.GroupBox3.Controls.Add(this.NumericUpDown_senha);
			this.GroupBox3.Controls.Add(this.tb_lixo3);
			global::System.Windows.Forms.Control groupBox = this.GroupBox3;
groupBox.Location = new global::System.Drawing.Point(17, 16);
			this.GroupBox3.Name = "GroupBox3";
			global::System.Windows.Forms.Control groupBox2 = this.GroupBox3;
			Size = new System.Drawing.Size(138, 75);
			groupBox2.Size = this.Size;
			this.GroupBox3.TabIndex = 0;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Senha:";
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label11 = this.Label1;
label11.Location = new global::System.Drawing.Point(7, 37);
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label12 = this.Label1;
			Size = new System.Drawing.Size(41, 13);
			label12.Size = this.Size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Senha:";
			global::System.Windows.Forms.Control numericUpDown_senha = this.NumericUpDown_senha;
numericUpDown_senha.Location = new global::System.Drawing.Point(54, 35);
			this.NumericUpDown_senha.Name = "NumericUpDown_senha";
			global::System.Windows.Forms.Control numericUpDown_senha2 = this.NumericUpDown_senha;
			Size = new System.Drawing.Size(73, 20);
			numericUpDown_senha2.Size = this.Size;
			this.NumericUpDown_senha.TabIndex = 0;
			global::System.Windows.Forms.Control tb_lixo5 = this.tb_lixo3;
tb_lixo5.Location = new global::System.Drawing.Point(72, 35);
			this.tb_lixo3.Name = "tb_lixo3";
			global::System.Windows.Forms.Control tb_lixo6 = this.tb_lixo3;
			Size = new System.Drawing.Size(29, 20);
			tb_lixo6.Size = this.Size;
			this.tb_lixo3.TabIndex = 2;
			this.TabPage_Equipamentos.Controls.Add(this.GroupBox1);
			global::System.Windows.Forms.TabPage tabPage_Equipamentos = this.TabPage_Equipamentos;
tabPage_Equipamentos.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_Equipamentos.Name = "TabPage_Equipamentos";
			global::System.Windows.Forms.Control tabPage_Equipamentos2 = this.TabPage_Equipamentos;
			Padding = new Padding(3);
			tabPage_Equipamentos2.Padding = Padding;
			global::System.Windows.Forms.Control tabPage_Equipamentos3 = this.TabPage_Equipamentos;
			Size = new System.Drawing.Size(1238, 549);
			tabPage_Equipamentos3.Size = this.Size;
			this.TabPage_Equipamentos.TabIndex = 8;
			this.TabPage_Equipamentos.Text = "Lista de Equipamentos";
			this.TabPage_Equipamentos.UseVisualStyleBackColor = true;
			this.GroupBox1.Controls.Add(this.nud_numero_equipamentos_recalque);
			this.GroupBox1.Controls.Add(this.nud_numero_equipamentos_reservatorios);
			this.GroupBox1.Controls.Add(this.Label34);
			this.GroupBox1.Controls.Add(this.Label33);
			this.GroupBox1.Controls.Add(this.tb_lixo4);
			global::System.Windows.Forms.Control groupBox3 = this.GroupBox1;
groupBox3.Location = new global::System.Drawing.Point(19, 15);
			this.GroupBox1.Name = "GroupBox1";
			global::System.Windows.Forms.Control groupBox4 = this.GroupBox1;
			Size = new System.Drawing.Size(314, 112);
			groupBox4.Size = this.Size;
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Quantidade de Equipamentos";
			global::System.Windows.Forms.Control nud_numero_equipamentos_recalque = this.nud_numero_equipamentos_recalque;
nud_numero_equipamentos_recalque.Location = new global::System.Drawing.Point(236, 60);
			this.nud_numero_equipamentos_recalque.Name = "nud_numero_equipamentos_recalque";
			global::System.Windows.Forms.Control nud_numero_equipamentos_recalque2 = this.nud_numero_equipamentos_recalque;
			Size = new System.Drawing.Size(61, 20);
			nud_numero_equipamentos_recalque2.Size = this.Size;
			this.nud_numero_equipamentos_recalque.TabIndex = 7;
			global::System.Windows.Forms.Control nud_numero_equipamentos_reservatorios = this.nud_numero_equipamentos_reservatorios;
nud_numero_equipamentos_reservatorios.Location = new global::System.Drawing.Point(236, 34);
			this.nud_numero_equipamentos_reservatorios.Name = "nud_numero_equipamentos_reservatorios";
			global::System.Windows.Forms.Control nud_numero_equipamentos_reservatorios2 = this.nud_numero_equipamentos_reservatorios;
			Size = new System.Drawing.Size(61, 20);
			nud_numero_equipamentos_reservatorios2.Size = this.Size;
			this.nud_numero_equipamentos_reservatorios.TabIndex = 6;
			this.Label34.AutoSize = true;
			global::System.Windows.Forms.Control label13 = this.Label34;
label13.Location = new global::System.Drawing.Point(16, 62);
			this.Label34.Name = "Label34";
			global::System.Windows.Forms.Control label14 = this.Label34;
			Size = new System.Drawing.Size(178, 13);
			label14.Size = this.Size;
			this.Label34.TabIndex = 3;
			this.Label34.Text = "Número de Equipamentos Recalque";
			this.Label33.AutoSize = true;
			global::System.Windows.Forms.Control label15 = this.Label33;
label15.Location = new global::System.Drawing.Point(16, 36);
			this.Label33.Name = "Label33";
			global::System.Windows.Forms.Control label16 = this.Label33;
			Size = new System.Drawing.Size(195, 13);
			label16.Size = this.Size;
			this.Label33.TabIndex = 2;
			this.Label33.Text = "Número de Equipamentos Reservatório:";
			global::System.Windows.Forms.Control tb_lixo7 = this.tb_lixo4;
tb_lixo7.Location = new global::System.Drawing.Point(254, 34);
			this.tb_lixo4.Name = "tb_lixo4";
			global::System.Windows.Forms.Control tb_lixo8 = this.tb_lixo4;
			Size = new System.Drawing.Size(23, 20);
			tb_lixo8.Size = this.Size;
			this.tb_lixo4.TabIndex = 8;
			this.TabPage_Reservatorio.Controls.Add(this.GroupBox5);
			global::System.Windows.Forms.TabPage tabPage_Reservatorio = this.TabPage_Reservatorio;
tabPage_Reservatorio.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_Reservatorio.Name = "TabPage_Reservatorio";
			global::System.Windows.Forms.Control tabPage_Reservatorio2 = this.TabPage_Reservatorio;
			Padding = new Padding(3);
			tabPage_Reservatorio2.Padding = Padding;
			global::System.Windows.Forms.Control tabPage_Reservatorio3 = this.TabPage_Reservatorio;
			Size = new System.Drawing.Size(1238, 549);
			tabPage_Reservatorio3.Size = this.Size;
			this.TabPage_Reservatorio.TabIndex = 10;
			this.TabPage_Reservatorio.Text = "Equipamentos de Reservatório";
			this.TabPage_Reservatorio.UseVisualStyleBackColor = true;
			this.GroupBox5.Controls.Add(this.DataGridView_Reservatorios);
			this.GroupBox5.Controls.Add(this.tb_lixo5);
			global::System.Windows.Forms.Control groupBox5 = this.GroupBox5;
groupBox5.Location = new global::System.Drawing.Point(8, 6);
			this.GroupBox5.Name = "GroupBox5";
			global::System.Windows.Forms.Control groupBox6 = this.GroupBox5;
			Size = new System.Drawing.Size(1224, 537);
			groupBox6.Size = this.Size;
			this.GroupBox5.TabIndex = 0;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "Equipamentos de Reservatório";
			this.DataGridView_Reservatorios.AllowUserToAddRows = false;
			this.DataGridView_Reservatorios.AllowUserToResizeColumns = false;
			this.DataGridView_Reservatorios.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			this.DataGridView_Reservatorios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.DataGridView_Reservatorios.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			this.DataGridView_Reservatorios.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.RES_Posicao,
				this.RES_Nome
			});
			global::System.Windows.Forms.Control dataGridView_Reservatorios = this.DataGridView_Reservatorios;
dataGridView_Reservatorios.Location = new global::System.Drawing.Point(18, 19);
			this.DataGridView_Reservatorios.Name = "DataGridView_Reservatorios";
			this.DataGridView_Reservatorios.RowHeadersVisible = false;
			global::System.Windows.Forms.Control dataGridView_Reservatorios2 = this.DataGridView_Reservatorios;
			Size = new System.Drawing.Size(186, 512);
			dataGridView_Reservatorios2.Size = this.Size;
			this.DataGridView_Reservatorios.TabIndex = 0;
			this.RES_Posicao.HeaderText = "Posição:";
			this.RES_Posicao.Name = "RES_Posicao";
			this.RES_Posicao.ReadOnly = true;
			this.RES_Posicao.Width = 80;
			this.RES_Nome.HeaderText = "Nome:";
			this.RES_Nome.MaxInputLength = 3;
			this.RES_Nome.Name = "RES_Nome";
			this.RES_Nome.Width = 60;
			global::System.Windows.Forms.Control tb_lixo9 = this.tb_lixo5;
tb_lixo9.Location = new global::System.Drawing.Point(18, 19);
			this.tb_lixo5.Name = "tb_lixo5";
			global::System.Windows.Forms.Control tb_lixo10 = this.tb_lixo5;
			Size = new System.Drawing.Size(100, 20);
			tb_lixo10.Size = this.Size;
			this.tb_lixo5.TabIndex = 1;
			this.TabPage_Recalque.Controls.Add(this.GroupBox6);
			global::System.Windows.Forms.TabPage tabPage_Recalque = this.TabPage_Recalque;
tabPage_Recalque.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_Recalque.Name = "TabPage_Recalque";
			global::System.Windows.Forms.Control tabPage_Recalque2 = this.TabPage_Recalque;
			Padding = new Padding(3);
			tabPage_Recalque2.Padding = Padding;
			global::System.Windows.Forms.Control tabPage_Recalque3 = this.TabPage_Recalque;
			Size = new System.Drawing.Size(1238, 549);
			tabPage_Recalque3.Size = this.Size;
			this.TabPage_Recalque.TabIndex = 11;
			this.TabPage_Recalque.Text = "Equipamentos de Recalque";
			this.TabPage_Recalque.UseVisualStyleBackColor = true;
			this.GroupBox6.Controls.Add(this.DataGridView_Recalques);
			this.GroupBox6.Controls.Add(this.tb_lixo6);
			global::System.Windows.Forms.Control groupBox7 = this.GroupBox6;
groupBox7.Location = new global::System.Drawing.Point(8, 6);
			this.GroupBox6.Name = "GroupBox6";
			global::System.Windows.Forms.Control groupBox8 = this.GroupBox6;
			Size = new System.Drawing.Size(1224, 537);
			groupBox8.Size = this.Size;
			this.GroupBox6.TabIndex = 1;
			this.GroupBox6.TabStop = false;
			this.GroupBox6.Text = "Equipamentos de Recalque:";
			this.DataGridView_Recalques.AllowUserToAddRows = false;
			this.DataGridView_Recalques.AllowUserToDeleteRows = false;
			this.DataGridView_Recalques.AllowUserToOrderColumns = true;
			this.DataGridView_Recalques.AllowUserToResizeColumns = false;
			this.DataGridView_Recalques.AllowUserToResizeRows = false;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			this.DataGridView_Recalques.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.DataGridView_Recalques.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			this.DataGridView_Recalques.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.REC_Posicao,
				this.REC_Nome,
				this.REC_Modelo,
				this.REC_HabCMD,
				this.REC_Escala1,
				this.REC_Escala2,
				this.REC_Escala3,
				this.REC_Escala4,
				this.REC_Escala5,
				this.REC_Escala6,
				this.REC_Escala7,
				this.REC_Escala8,
				this.REC_Escala9,
				this.REC_Escala10,
				this.REC_Escala11,
				this.REC_Escala12,
				this.REC_Escala13,
				this.REC_Escala14,
				this.REC_Escala15,
				this.REC_Escala16
			});
			global::System.Windows.Forms.Control dataGridView_Recalques = this.DataGridView_Recalques;
dataGridView_Recalques.Location = new global::System.Drawing.Point(6, 19);
			this.DataGridView_Recalques.Name = "DataGridView_Recalques";
			this.DataGridView_Recalques.RowHeadersVisible = false;
			global::System.Windows.Forms.Control dataGridView_Recalques2 = this.DataGridView_Recalques;
			Size = new System.Drawing.Size(1212, 512);
			dataGridView_Recalques2.Size = this.Size;
			this.DataGridView_Recalques.TabIndex = 0;
			this.REC_Posicao.Frozen = true;
			this.REC_Posicao.HeaderText = "Posição:";
			this.REC_Posicao.Name = "REC_Posicao";
			this.REC_Posicao.ReadOnly = true;
			this.REC_Posicao.Width = 80;
			this.REC_Nome.Frozen = true;
			this.REC_Nome.HeaderText = "Nome:";
			this.REC_Nome.MaxInputLength = 3;
			this.REC_Nome.Name = "REC_Nome";
			this.REC_Nome.Width = 50;
			this.REC_Modelo.HeaderText = "Modelo:";
			this.REC_Modelo.Name = "REC_Modelo";
			this.REC_HabCMD.HeaderText = "Habilita Comando:";
			this.REC_HabCMD.Name = "REC_HabCMD";
			this.REC_Escala1.HeaderText = "Escala 1:";
			this.REC_Escala1.Name = "REC_Escala1";
			this.REC_Escala1.Width = 80;
			this.REC_Escala2.HeaderText = "Escala 2:";
			this.REC_Escala2.Name = "REC_Escala2";
			this.REC_Escala2.Width = 80;
			this.REC_Escala3.HeaderText = "Escala 3:";
			this.REC_Escala3.Name = "REC_Escala3";
			this.REC_Escala3.Width = 80;
			this.REC_Escala4.HeaderText = "Escala 4:";
			this.REC_Escala4.Name = "REC_Escala4";
			this.REC_Escala4.Width = 80;
			this.REC_Escala5.HeaderText = "Escala 5:";
			this.REC_Escala5.Name = "REC_Escala5";
			this.REC_Escala5.Width = 80;
			this.REC_Escala6.HeaderText = "Escala 6:";
			this.REC_Escala6.Name = "REC_Escala6";
			this.REC_Escala6.Width = 80;
			this.REC_Escala7.HeaderText = "Escala 7:";
			this.REC_Escala7.Name = "REC_Escala7";
			this.REC_Escala7.Width = 80;
			this.REC_Escala8.HeaderText = "Escala 8:";
			this.REC_Escala8.Name = "REC_Escala8";
			this.REC_Escala8.Width = 80;
			this.REC_Escala9.HeaderText = "Escala 9:";
			this.REC_Escala9.Name = "REC_Escala9";
			this.REC_Escala9.Width = 80;
			this.REC_Escala10.HeaderText = "Escala 10:";
			this.REC_Escala10.Name = "REC_Escala10";
			this.REC_Escala10.Width = 80;
			this.REC_Escala11.HeaderText = "Escala 11:";
			this.REC_Escala11.Name = "REC_Escala11";
			this.REC_Escala11.Width = 80;
			this.REC_Escala12.HeaderText = "Escala 12:";
			this.REC_Escala12.Name = "REC_Escala12";
			this.REC_Escala12.Width = 80;
			this.REC_Escala13.HeaderText = "Escala 13:";
			this.REC_Escala13.Name = "REC_Escala13";
			this.REC_Escala13.Width = 80;
			this.REC_Escala14.HeaderText = "Escala 14:";
			this.REC_Escala14.Name = "REC_Escala14";
			this.REC_Escala14.Width = 80;
			this.REC_Escala15.HeaderText = "Escala 15:";
			this.REC_Escala15.Name = "REC_Escala15";
			this.REC_Escala15.Width = 80;
			this.REC_Escala16.HeaderText = "Escala 16:";
			this.REC_Escala16.Name = "REC_Escala16";
			this.REC_Escala16.Width = 80;
			global::System.Windows.Forms.Control tb_lixo11 = this.tb_lixo6;
tb_lixo11.Location = new global::System.Drawing.Point(15, 19);
			this.tb_lixo6.Name = "tb_lixo6";
			global::System.Windows.Forms.Control tb_lixo12 = this.tb_lixo6;
			Size = new System.Drawing.Size(100, 20);
			tb_lixo12.Size = this.Size;
			this.tb_lixo6.TabIndex = 1;
			this.TabPage1.Controls.Add(this.GroupBox2);
			global::System.Windows.Forms.TabPage tabPage = this.TabPage1;
tabPage.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			global::System.Windows.Forms.Control tabPage2 = this.TabPage1;
			Padding = new Padding(3);
			tabPage2.Padding = Padding;
			global::System.Windows.Forms.Control tabPage3 = this.TabPage1;
			Size = new System.Drawing.Size(1238, 549);
			tabPage3.Size = this.Size;
			this.TabPage1.TabIndex = 9;
			this.TabPage1.Text = "Dados de Instalação";
			this.TabPage1.UseVisualStyleBackColor = true;
			this.GroupBox2.Controls.Add(this.Label16);
			this.GroupBox2.Controls.Add(this.Label15);
			this.GroupBox2.Controls.Add(this.T_AlturaAntena1);
			this.GroupBox2.Controls.Add(this.T_Latitude1);
			this.GroupBox2.Controls.Add(this.T_Longitude1);
			this.GroupBox2.Controls.Add(this.T_Azimute1);
			this.GroupBox2.Controls.Add(this.Label14);
			this.GroupBox2.Controls.Add(this.Label13);
			this.GroupBox2.Controls.Add(this.T_FreqRadio1);
			this.GroupBox2.Controls.Add(this.T_PotRadio1);
			this.GroupBox2.Controls.Add(this.CB_ModeloRadio1);
			this.GroupBox2.Controls.Add(this.CB_PolarizacaoAntena1);
			this.GroupBox2.Controls.Add(this.CB_TipoAntena1);
			this.GroupBox2.Controls.Add(this.Label10);
			this.GroupBox2.Controls.Add(this.Label9);
			this.GroupBox2.Controls.Add(this.Label8);
			this.GroupBox2.Controls.Add(this.Label7);
			this.GroupBox2.Controls.Add(this.Label6);
			this.GroupBox2.Controls.Add(this.Label4);
			this.GroupBox2.Controls.Add(this.Label3);
			this.GroupBox2.Controls.Add(this.Label2);
			this.GroupBox2.Controls.Add(this.Label17);
			this.GroupBox2.Controls.Add(this.tb_lixo7);
			global::System.Windows.Forms.Control groupBox9 = this.GroupBox2;
groupBox9.Location = new global::System.Drawing.Point(25, 19);
			this.GroupBox2.Name = "GroupBox2";
			global::System.Windows.Forms.Control groupBox10 = this.GroupBox2;
			Size = new System.Drawing.Size(768, 200);
			groupBox10.Size = this.Size;
			this.GroupBox2.TabIndex = 0;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Antena 1";
			this.Label16.AutoSize = true;
			this.Label16.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control label17 = this.Label16;
label17.Location = new global::System.Drawing.Point(736, 25);
			this.Label16.Name = "Label16";
			global::System.Windows.Forms.Control label18 = this.Label16;
			Size = new System.Drawing.Size(12, 16);
			label18.Size = this.Size;
			this.Label16.TabIndex = 53;
			this.Label16.Text = "°";
			this.Label15.AutoSize = true;
			global::System.Windows.Forms.Control label19 = this.Label15;
label19.Location = new global::System.Drawing.Point(736, 134);
			this.Label15.Name = "Label15";
			global::System.Windows.Forms.Control label20 = this.Label15;
			Size = new System.Drawing.Size(15, 13);
			label20.Size = this.Size;
			this.Label15.TabIndex = 52;
			this.Label15.Text = "m";
			global::System.Windows.Forms.Control t_AlturaAntena = this.T_AlturaAntena1;
t_AlturaAntena.Location = new global::System.Drawing.Point(609, 126);
			this.T_AlturaAntena1.Name = "T_AlturaAntena1";
			global::System.Windows.Forms.Control t_AlturaAntena2 = this.T_AlturaAntena1;
			Size = new System.Drawing.Size(121, 20);
			t_AlturaAntena2.Size = this.Size;
			this.T_AlturaAntena1.TabIndex = 50;
			global::System.Windows.Forms.Control t_Latitude = this.T_Latitude1;
t_Latitude.Location = new global::System.Drawing.Point(609, 91);
			this.T_Latitude1.Name = "T_Latitude1";
			global::System.Windows.Forms.Control t_Latitude2 = this.T_Latitude1;
			Size = new System.Drawing.Size(121, 20);
			t_Latitude2.Size = this.Size;
			this.T_Latitude1.TabIndex = 49;
			global::System.Windows.Forms.Control t_Longitude = this.T_Longitude1;
t_Longitude.Location = new global::System.Drawing.Point(609, 56);
			this.T_Longitude1.Name = "T_Longitude1";
			global::System.Windows.Forms.Control t_Longitude2 = this.T_Longitude1;
			Size = new System.Drawing.Size(121, 20);
			t_Longitude2.Size = this.Size;
			this.T_Longitude1.TabIndex = 48;
			global::System.Windows.Forms.Control t_Azimute = this.T_Azimute1;
t_Azimute.Location = new global::System.Drawing.Point(609, 25);
			this.T_Azimute1.Name = "T_Azimute1";
			global::System.Windows.Forms.Control t_Azimute2 = this.T_Azimute1;
			Size = new System.Drawing.Size(121, 20);
			t_Azimute2.Size = this.Size;
			this.T_Azimute1.TabIndex = 47;
			this.Label14.AutoSize = true;
			global::System.Windows.Forms.Control label21 = this.Label14;
label21.Location = new global::System.Drawing.Point(337, 98);
			this.Label14.Name = "Label14";
			global::System.Windows.Forms.Control label22 = this.Label14;
			Size = new System.Drawing.Size(18, 13);
			label22.Size = this.Size;
			this.Label14.TabIndex = 46;
			this.Label14.Text = "W";
			this.Label13.AutoSize = true;
			global::System.Windows.Forms.Control label23 = this.Label13;
label23.Location = new global::System.Drawing.Point(337, 169);
			this.Label13.Name = "Label13";
			global::System.Windows.Forms.Control label24 = this.Label13;
			Size = new System.Drawing.Size(29, 13);
			label24.Size = this.Size;
			this.Label13.TabIndex = 45;
			this.Label13.Text = "MHz";
			global::System.Windows.Forms.Control t_FreqRadio = this.T_FreqRadio1;
t_FreqRadio.Location = new global::System.Drawing.Point(210, 162);
			this.T_FreqRadio1.Name = "T_FreqRadio1";
			global::System.Windows.Forms.Control t_FreqRadio2 = this.T_FreqRadio1;
			Size = new System.Drawing.Size(121, 20);
			t_FreqRadio2.Size = this.Size;
			this.T_FreqRadio1.TabIndex = 43;
			global::System.Windows.Forms.Control t_PotRadio = this.T_PotRadio1;
t_PotRadio.Location = new global::System.Drawing.Point(210, 91);
			this.T_PotRadio1.Name = "T_PotRadio1";
			global::System.Windows.Forms.Control t_PotRadio2 = this.T_PotRadio1;
			Size = new System.Drawing.Size(121, 20);
			t_PotRadio2.Size = this.Size;
			this.T_PotRadio1.TabIndex = 41;
			this.CB_ModeloRadio1.FormattingEnabled = true;
			this.CB_ModeloRadio1.Items.AddRange(new object[]
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
			global::System.Windows.Forms.Control cb_ModeloRadio = this.CB_ModeloRadio1;
cb_ModeloRadio.Location = new global::System.Drawing.Point(210, 126);
			this.CB_ModeloRadio1.Name = "CB_ModeloRadio1";
			global::System.Windows.Forms.Control cb_ModeloRadio2 = this.CB_ModeloRadio1;
			Size = new System.Drawing.Size(121, 21);
			cb_ModeloRadio2.Size = this.Size;
			this.CB_ModeloRadio1.TabIndex = 40;
			this.CB_PolarizacaoAntena1.FormattingEnabled = true;
			this.CB_PolarizacaoAntena1.Items.AddRange(new object[]
			{
				"Horizontal",
				"Vertical"
			});
			global::System.Windows.Forms.Control cb_PolarizacaoAntena = this.CB_PolarizacaoAntena1;
cb_PolarizacaoAntena.Location = new global::System.Drawing.Point(210, 56);
			this.CB_PolarizacaoAntena1.Name = "CB_PolarizacaoAntena1";
			global::System.Windows.Forms.Control cb_PolarizacaoAntena2 = this.CB_PolarizacaoAntena1;
			Size = new System.Drawing.Size(121, 21);
			cb_PolarizacaoAntena2.Size = this.Size;
			this.CB_PolarizacaoAntena1.TabIndex = 39;
			this.CB_TipoAntena1.FormattingEnabled = true;
			this.CB_TipoAntena1.Items.AddRange(new object[]
			{
				"Não Informado",
				"OMNI",
				"YAGI",
				"Plano Terra"
			});
			global::System.Windows.Forms.Control cb_TipoAntena = this.CB_TipoAntena1;
cb_TipoAntena.Location = new global::System.Drawing.Point(210, 29);
			this.CB_TipoAntena1.Name = "CB_TipoAntena1";
			global::System.Windows.Forms.Control cb_TipoAntena2 = this.CB_TipoAntena1;
			Size = new System.Drawing.Size(121, 21);
			cb_TipoAntena2.Size = this.Size;
			this.CB_TipoAntena1.TabIndex = 38;
			this.Label10.AutoSize = true;
			global::System.Windows.Forms.Control label25 = this.Label10;
label25.Location = new global::System.Drawing.Point(474, 129);
			this.Label10.Name = "Label10";
			global::System.Windows.Forms.Control label26 = this.Label10;
			Size = new System.Drawing.Size(37, 13);
			label26.Size = this.Size;
			this.Label10.TabIndex = 36;
			this.Label10.Text = "Altura:";
			this.Label9.AutoSize = true;
			global::System.Windows.Forms.Control label27 = this.Label9;
label27.Location = new global::System.Drawing.Point(474, 94);
			this.Label9.Name = "Label9";
			global::System.Windows.Forms.Control label28 = this.Label9;
			Size = new System.Drawing.Size(48, 13);
			label28.Size = this.Size;
			this.Label9.TabIndex = 35;
			this.Label9.Text = "Latitude:";
			this.Label8.AutoSize = true;
			global::System.Windows.Forms.Control label29 = this.Label8;
label29.Location = new global::System.Drawing.Point(474, 65);
			this.Label8.Name = "Label8";
			global::System.Windows.Forms.Control label30 = this.Label8;
			Size = new System.Drawing.Size(57, 13);
			label30.Size = this.Size;
			this.Label8.TabIndex = 34;
			this.Label8.Text = "Longitude:";
			this.Label7.AutoSize = true;
			global::System.Windows.Forms.Control label31 = this.Label7;
label31.Location = new global::System.Drawing.Point(474, 32);
			this.Label7.Name = "Label7";
			global::System.Windows.Forms.Control label32 = this.Label7;
			Size = new System.Drawing.Size(47, 13);
			label32.Size = this.Size;
			this.Label7.TabIndex = 33;
			this.Label7.Text = "Azimute:";
			this.Label6.AutoSize = true;
			global::System.Windows.Forms.Control label33 = this.Label6;
label33.Location = new global::System.Drawing.Point(18, 165);
			this.Label6.Name = "Label6";
			global::System.Windows.Forms.Control label34 = this.Label6;
			Size = new System.Drawing.Size(104, 13);
			label34.Size = this.Size;
			this.Label6.TabIndex = 32;
			this.Label6.Text = "Frequência do rádio:";
			this.Label4.AutoSize = true;
			global::System.Windows.Forms.Control label35 = this.Label4;
label35.Location = new global::System.Drawing.Point(18, 129);
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control label36 = this.Label4;
			Size = new System.Drawing.Size(86, 13);
			label36.Size = this.Size;
			this.Label4.TabIndex = 30;
			this.Label4.Text = "Modelo do rádio:";
			this.Label3.AutoSize = true;
			global::System.Windows.Forms.Control label37 = this.Label3;
label37.Location = new global::System.Drawing.Point(18, 98);
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label38 = this.Label3;
			Size = new System.Drawing.Size(93, 13);
			label38.Size = this.Size;
			this.Label3.TabIndex = 29;
			this.Label3.Text = "Potência do rádio:";
			this.Label2.AutoSize = true;
			global::System.Windows.Forms.Control label39 = this.Label2;
label39.Location = new global::System.Drawing.Point(18, 65);
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label40 = this.Label2;
			Size = new System.Drawing.Size(65, 13);
			label40.Size = this.Size;
			this.Label2.TabIndex = 28;
			this.Label2.Text = "Polarização:";
			this.Label17.AutoSize = true;
			global::System.Windows.Forms.Control label41 = this.Label17;
label41.Location = new global::System.Drawing.Point(18, 32);
			this.Label17.Name = "Label17";
			global::System.Windows.Forms.Control label42 = this.Label17;
			Size = new System.Drawing.Size(83, 13);
			label42.Size = this.Size;
			this.Label17.TabIndex = 27;
			this.Label17.Text = "Tipo de Antena:";
			global::System.Windows.Forms.Control tb_lixo13 = this.tb_lixo7;
tb_lixo13.Location = new global::System.Drawing.Point(238, 127);
			this.tb_lixo7.Name = "tb_lixo7";
			global::System.Windows.Forms.Control tb_lixo14 = this.tb_lixo7;
			Size = new System.Drawing.Size(62, 20);
			tb_lixo14.Size = this.Size;
			this.tb_lixo7.TabIndex = 54;
			this.OpenFileDialog_RT850.FileName = "OpenFileDialog1";
			this.Timer_limpa_MSG_RT850.Interval = 2000;
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
			Size = new System.Drawing.Size(1258, 636);
			this.ClientSize = Size;
			this.Controls.Add(this.TabControl_850);
			this.Controls.Add(this.ToolStri_RT850);
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.Name = "RT_831_200_configurador";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Configuração";
			this.TransparencyKey = global::System.Drawing.Color.Transparent;
			this.ToolStri_RT850.ResumeLayout(false);
			this.ToolStri_RT850.PerformLayout();
			this.TabControl_850.ResumeLayout(false);
			this.TabPage_geral.ResumeLayout(false);
			this.GroupBox_descricao_RT850.ResumeLayout(false);
			this.GroupBox_descricao_RT850.PerformLayout();
			this.GroupBox_informacoes_RT850.ResumeLayout(false);
			this.GroupBox_informacoes_RT850.PerformLayout();
			this.TabPage_controles.ResumeLayout(false);
			this.GroupBox_canal_1_RT850.ResumeLayout(false);
			this.GroupBox_canal_1_RT850.PerformLayout();
			
			
			
			this.TabPage_Senha.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			
			this.TabPage_Equipamentos.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			
			
			this.TabPage_Reservatorio.ResumeLayout(false);
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			
			this.TabPage_Recalque.ResumeLayout(false);
			this.GroupBox6.ResumeLayout(false);
			this.GroupBox6.PerformLayout();
			
			this.TabPage1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040003AD RID: 941
		private global::System.ComponentModel.IContainer components;
	}
}
