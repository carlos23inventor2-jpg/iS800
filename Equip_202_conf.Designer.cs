using System.Drawing;
using System.Windows.Forms;
﻿namespace iS800
{
	// Token: 0x02000084 RID: 132
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Equip_202_conf : global::System.Windows.Forms.Form
	{
		// Token: 0x06001ED7 RID: 7895 RVA: 0x003E0DB4 File Offset: 0x003DF1B4
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

		// Token: 0x06001ED8 RID: 7896 RVA: 0x003E0DF4 File Offset: 0x003DF1F4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Grupo_ctrl = new global::System.Windows.Forms.GroupBox();
			this.Esc_conf_md_202 = new global::System.Windows.Forms.Button();
			this.Box_Msg = new global::System.Windows.Forms.TextBox();
			this.Ler_conf_md_202 = new global::System.Windows.Forms.Button();
			this.Grupo_motores_valvulas = new global::System.Windows.Forms.GroupBox();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.Label10 = new global::System.Windows.Forms.Label();
			this.Label9 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.Tempo_abertura_v4 = new global::System.Windows.Forms.NumericUpDown();
			this.Tempo_abertura_v3 = new global::System.Windows.Forms.NumericUpDown();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.Tempo_fechamento_v4 = new global::System.Windows.Forms.NumericUpDown();
			this.Tempo_abertura_v2 = new global::System.Windows.Forms.NumericUpDown();
			this.Tempo_fechamento_v3 = new global::System.Windows.Forms.NumericUpDown();
			this.Tempo_fechamento_v2 = new global::System.Windows.Forms.NumericUpDown();
			this.Tempo_abertura_v1 = new global::System.Windows.Forms.NumericUpDown();
			this.Tempo_fechamento_v1 = new global::System.Windows.Forms.NumericUpDown();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label_tempo_parada = new global::System.Windows.Forms.Label();
			this.Label_tempo_partida = new global::System.Windows.Forms.Label();
			this.Label_modo_de_operacao_motor = new global::System.Windows.Forms.Label();
			this.Label_motor4 = new global::System.Windows.Forms.Label();
			this.Label_motor3 = new global::System.Windows.Forms.Label();
			this.Combo_modo_partida_m4 = new global::System.Windows.Forms.ComboBox();
			this.Combo_modo_partida_m3 = new global::System.Windows.Forms.ComboBox();
			this.Label_motor2 = new global::System.Windows.Forms.Label();
			this.Combo_modo_partida_m2 = new global::System.Windows.Forms.ComboBox();
			this.Tempo_partida_m4 = new global::System.Windows.Forms.NumericUpDown();
			this.Tempo_partida_m3 = new global::System.Windows.Forms.NumericUpDown();
			this.Label_motor1 = new global::System.Windows.Forms.Label();
			this.Tempo_parada_m4 = new global::System.Windows.Forms.NumericUpDown();
			this.Tempo_partida_m2 = new global::System.Windows.Forms.NumericUpDown();
			this.Tempo_parada_m3 = new global::System.Windows.Forms.NumericUpDown();
			this.Combo_modo_partida_m1 = new global::System.Windows.Forms.ComboBox();
			this.Tempo_parada_m2 = new global::System.Windows.Forms.NumericUpDown();
			this.Tempo_partida_m1 = new global::System.Windows.Forms.NumericUpDown();
			this.Tempo_parada_m1 = new global::System.Windows.Forms.NumericUpDown();
			this.Valor_num_bomba_simultaneas = new global::System.Windows.Forms.NumericUpDown();
			this.Label_num_bombas_simultaneas = new global::System.Windows.Forms.Label();
			this.Combo_modo_operacao = new global::System.Windows.Forms.ComboBox();
			this.Label_modo_operacao = new global::System.Windows.Forms.Label();
			this.Tempo_entre_acionamentos = new global::System.Windows.Forms.NumericUpDown();
			this.Numero_motores = new global::System.Windows.Forms.NumericUpDown();
			this.Numero_valvulas = new global::System.Windows.Forms.NumericUpDown();
			this.Label_tempo_entre_acionamentos = new global::System.Windows.Forms.Label();
			this.Label_num_motores = new global::System.Windows.Forms.Label();
			this.Label_num_valvulas = new global::System.Windows.Forms.Label();
			this.Valor_pressao_min_recalque = new global::System.Windows.Forms.NumericUpDown();
			this.Valor_pressao_min_succao = new global::System.Windows.Forms.NumericUpDown();
			this.Label_pressao_min_succao = new global::System.Windows.Forms.Label();
			this.Label_pressao_min_recalque = new global::System.Windows.Forms.Label();
			this.Valor_tempo_mais_bomba = new global::System.Windows.Forms.NumericUpDown();
			this.Valor_nivel_liga_b4 = new global::System.Windows.Forms.NumericUpDown();
			this.Label_nivel_liga_b4 = new global::System.Windows.Forms.Label();
			this.Label_tempo_mais_bomba = new global::System.Windows.Forms.Label();
			this.Valor_nivel_liga_b1 = new global::System.Windows.Forms.NumericUpDown();
			this.Valor_nivel_desejado = new global::System.Windows.Forms.NumericUpDown();
			this.Label_nivel_desejado = new global::System.Windows.Forms.Label();
			this.Label_nivel_liga_b1 = new global::System.Windows.Forms.Label();
			this.Grupo_repetidora = new global::System.Windows.Forms.GroupBox();
			this.Valor_num_est_rep = new global::System.Windows.Forms.NumericUpDown();
			this.Valor_end_rep = new global::System.Windows.Forms.NumericUpDown();
			this.Grupo_end_rep = new global::System.Windows.Forms.GroupBox();
			this.VScrollBar1 = new global::System.Windows.Forms.VScrollBar();
			this.Label_end_rep_12 = new global::System.Windows.Forms.Label();
			this.Valor_end_rep_12 = new global::System.Windows.Forms.TextBox();
			this.Label_end_rep_11 = new global::System.Windows.Forms.Label();
			this.Valor_end_rep_11 = new global::System.Windows.Forms.TextBox();
			this.Label_end_rep_6 = new global::System.Windows.Forms.Label();
			this.Valor_end_rep_6 = new global::System.Windows.Forms.TextBox();
			this.Label_end_rep_3 = new global::System.Windows.Forms.Label();
			this.Valor_end_rep_3 = new global::System.Windows.Forms.TextBox();
			this.Label_end_rep_9 = new global::System.Windows.Forms.Label();
			this.Valor_end_rep_9 = new global::System.Windows.Forms.TextBox();
			this.Label_end_rep_8 = new global::System.Windows.Forms.Label();
			this.Valor_end_rep_8 = new global::System.Windows.Forms.TextBox();
			this.Label_end_rep_5 = new global::System.Windows.Forms.Label();
			this.Valor_end_rep_5 = new global::System.Windows.Forms.TextBox();
			this.Label_end_rep_2 = new global::System.Windows.Forms.Label();
			this.Valor_end_rep_2 = new global::System.Windows.Forms.TextBox();
			this.Label_end_rep_10 = new global::System.Windows.Forms.Label();
			this.Valor_end_rep_10 = new global::System.Windows.Forms.TextBox();
			this.Label_end_rep_7 = new global::System.Windows.Forms.Label();
			this.Label_end_rep_4 = new global::System.Windows.Forms.Label();
			this.Valor_end_rep_7 = new global::System.Windows.Forms.TextBox();
			this.Valor_end_rep_4 = new global::System.Windows.Forms.TextBox();
			this.Label_end_rep_1 = new global::System.Windows.Forms.Label();
			this.Valor_end_rep_1 = new global::System.Windows.Forms.TextBox();
			this.CheckBox_hab_rep = new global::System.Windows.Forms.CheckBox();
			this.Label_num_est_rep = new global::System.Windows.Forms.Label();
			this.Label_end_rep = new global::System.Windows.Forms.Label();
			this.grupo_comunicacao = new global::System.Windows.Forms.GroupBox();
			this.Combo_baudrate = new global::System.Windows.Forms.ComboBox();
			this.Label_baudrate = new global::System.Windows.Forms.Label();
			this.Valor_temp_ptt = new global::System.Windows.Forms.NumericUpDown();
			this.Valor_end_mestre = new global::System.Windows.Forms.NumericUpDown();
			this.Valor_end_est = new global::System.Windows.Forms.NumericUpDown();
			this.Label_tempo_ptt = new global::System.Windows.Forms.Label();
			this.Label_end_mestre = new global::System.Windows.Forms.Label();
			this.Label_end_est = new global::System.Windows.Forms.Label();
			this.MenuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.ArquivoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.NovoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.AbrirToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SalvarToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Valor_nivel_liga_b3 = new global::System.Windows.Forms.NumericUpDown();
			this.Valor_nivel_liga_b2 = new global::System.Windows.Forms.NumericUpDown();
			this.Label_nivel_liga_b2 = new global::System.Windows.Forms.Label();
			this.Label_nivel_liga_b3 = new global::System.Windows.Forms.Label();
			this.Grupo_setpoints = new global::System.Windows.Forms.GroupBox();
			this.Valor_nivel_liberacao = new global::System.Windows.Forms.NumericUpDown();
			this.Valor_nivel_bloqueio = new global::System.Windows.Forms.NumericUpDown();
			this.Label_nivel_liberacao = new global::System.Windows.Forms.Label();
			this.Label_nivel_bloqueio = new global::System.Windows.Forms.Label();
			this.Grupo_analogicas = new global::System.Windows.Forms.GroupBox();
			this.CheckBox_ctrl_nivel_fonte = new global::System.Windows.Forms.CheckBox();
			this.Combo_num_totalizacoes = new global::System.Windows.Forms.ComboBox();
			this.Label_num_totalizacoes = new global::System.Windows.Forms.Label();
			this.Valor_tamanho_filtro_AD = new global::System.Windows.Forms.NumericUpDown();
			this.Valor_intervalo_filtro_AD = new global::System.Windows.Forms.NumericUpDown();
			this.Label_tamanho_filtro_AD = new global::System.Windows.Forms.Label();
			this.Label_intervalo_filtro_AD = new global::System.Windows.Forms.Label();
			this.Grupo_entradas_digitais = new global::System.Windows.Forms.GroupBox();
			this.ComboBox_E08 = new global::System.Windows.Forms.ComboBox();
			this.ComboBox_E07 = new global::System.Windows.Forms.ComboBox();
			this.ComboBox_E06 = new global::System.Windows.Forms.ComboBox();
			this.ComboBox_E05 = new global::System.Windows.Forms.ComboBox();
			this.ComboBox_E04 = new global::System.Windows.Forms.ComboBox();
			this.ComboBox_E03 = new global::System.Windows.Forms.ComboBox();
			this.ComboBox_E02 = new global::System.Windows.Forms.ComboBox();
			this.ComboBox_E01 = new global::System.Windows.Forms.ComboBox();
			this.Label_E08 = new global::System.Windows.Forms.Label();
			this.Label_E07 = new global::System.Windows.Forms.Label();
			this.Label_E06 = new global::System.Windows.Forms.Label();
			this.Label_E05 = new global::System.Windows.Forms.Label();
			this.Label_E04 = new global::System.Windows.Forms.Label();
			this.Label_E03 = new global::System.Windows.Forms.Label();
			this.Label_E02 = new global::System.Windows.Forms.Label();
			this.Label_E01 = new global::System.Windows.Forms.Label();
			this.OpenFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.Grupo_perifericos = new global::System.Windows.Forms.GroupBox();
			this.Label_periferico_4 = new global::System.Windows.Forms.Label();
			this.Label_periferico_3 = new global::System.Windows.Forms.Label();
			this.Label_nota_2 = new global::System.Windows.Forms.Label();
			this.Label_periferico_2 = new global::System.Windows.Forms.Label();
			this.Label_nota_1 = new global::System.Windows.Forms.Label();
			this.Label_periferico_1 = new global::System.Windows.Forms.Label();
			this.Endereco_p4 = new global::System.Windows.Forms.NumericUpDown();
			this.Endereco_p2 = new global::System.Windows.Forms.NumericUpDown();
			this.Endereco_p3 = new global::System.Windows.Forms.NumericUpDown();
			this.Endereco_p1 = new global::System.Windows.Forms.NumericUpDown();
			this.Combo_tipo_p4 = new global::System.Windows.Forms.ComboBox();
			this.Combo_tipo_p2 = new global::System.Windows.Forms.ComboBox();
			this.Combo_tipo_p3 = new global::System.Windows.Forms.ComboBox();
			this.Combo_tipo_p1 = new global::System.Windows.Forms.ComboBox();
			this.Grupo_ctrl.SuspendLayout();
			this.Grupo_motores_valvulas.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			
			
			
			
			
			
			
			
			this.GroupBox1.SuspendLayout();
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			this.Grupo_repetidora.SuspendLayout();
			
			
			this.Grupo_end_rep.SuspendLayout();
			this.grupo_comunicacao.SuspendLayout();
			
			
			
			this.MenuStrip1.SuspendLayout();
			
			
			this.Grupo_setpoints.SuspendLayout();
			
			
			this.Grupo_analogicas.SuspendLayout();
			
			
			this.Grupo_entradas_digitais.SuspendLayout();
			this.Grupo_perifericos.SuspendLayout();
			
			
			
			
			this.SuspendLayout();
			this.Grupo_ctrl.Controls.Add(this.Esc_conf_md_202);
			this.Grupo_ctrl.Controls.Add(this.Box_Msg);
			this.Grupo_ctrl.Controls.Add(this.Ler_conf_md_202);
			global::System.Windows.Forms.Control grupo_ctrl = this.Grupo_ctrl;
			grupo_ctrl.Location = new global::System.Drawing.Point(13, 609);
			this.Grupo_ctrl.Name = "Grupo_ctrl";
			global::System.Windows.Forms.Control grupo_ctrl2 = this.Grupo_ctrl;
			grupo_ctrl2.Size = new global::System.Drawing.Size(335, 87);
			this.Grupo_ctrl.TabIndex = 8;
			this.Grupo_ctrl.TabStop = false;
			this.Grupo_ctrl.Text = "Comandos e Status";
			global::System.Windows.Forms.Control esc_conf_md_ = this.Esc_conf_md_202;
esc_conf_md_.Location = new global::System.Drawing.Point(192, 45);
			this.Esc_conf_md_202.Name = "Esc_conf_md_202";
			global::System.Windows.Forms.Control esc_conf_md_2 = this.Esc_conf_md_202;
			Size = new System.Drawing.Size(109, 28);
			esc_conf_md_2.Size = this.Size;
			this.Esc_conf_md_202.TabIndex = 1;
			this.Esc_conf_md_202.Text = "Salvar config.";
			this.Esc_conf_md_202.UseVisualStyleBackColor = true;
			this.Box_Msg.BackColor = global::System.Drawing.Color.Beige;
			global::System.Windows.Forms.Control box_Msg = this.Box_Msg;
box_Msg.Location = new global::System.Drawing.Point(22, 19);
			this.Box_Msg.Name = "Box_Msg";
			this.Box_Msg.ReadOnly = true;
			global::System.Windows.Forms.Control box_Msg2 = this.Box_Msg;
			Size = new System.Drawing.Size(293, 20);
			box_Msg2.Size = this.Size;
			this.Box_Msg.TabIndex = 2;
			this.Box_Msg.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.Control ler_conf_md_ = this.Ler_conf_md_202;
ler_conf_md_.Location = new global::System.Drawing.Point(39, 45);
			this.Ler_conf_md_202.Name = "Ler_conf_md_202";
			global::System.Windows.Forms.Control ler_conf_md_2 = this.Ler_conf_md_202;
			Size = new System.Drawing.Size(109, 28);
			ler_conf_md_2.Size = this.Size;
			this.Ler_conf_md_202.TabIndex = 0;
			this.Ler_conf_md_202.Text = "Ler configuração";
			this.Ler_conf_md_202.UseVisualStyleBackColor = true;
			this.Grupo_motores_valvulas.Controls.Add(this.GroupBox2);
			this.Grupo_motores_valvulas.Controls.Add(this.GroupBox1);
			this.Grupo_motores_valvulas.Controls.Add(this.Valor_num_bomba_simultaneas);
			this.Grupo_motores_valvulas.Controls.Add(this.Label_num_bombas_simultaneas);
			this.Grupo_motores_valvulas.Controls.Add(this.Combo_modo_operacao);
			this.Grupo_motores_valvulas.Controls.Add(this.Label_modo_operacao);
			this.Grupo_motores_valvulas.Controls.Add(this.Tempo_entre_acionamentos);
			this.Grupo_motores_valvulas.Controls.Add(this.Numero_motores);
			this.Grupo_motores_valvulas.Controls.Add(this.Numero_valvulas);
			this.Grupo_motores_valvulas.Controls.Add(this.Label_tempo_entre_acionamentos);
			this.Grupo_motores_valvulas.Controls.Add(this.Label_num_motores);
			this.Grupo_motores_valvulas.Controls.Add(this.Label_num_valvulas);
			this.Grupo_motores_valvulas.FlatStyle = FlatStyle.System;
			global::System.Windows.Forms.Control grupo_motores_valvulas = this.Grupo_motores_valvulas;
grupo_motores_valvulas.Location = new global::System.Drawing.Point(365, 6);
			this.Grupo_motores_valvulas.Name = "Grupo_motores_valvulas";
			global::System.Windows.Forms.Control grupo_motores_valvulas2 = this.Grupo_motores_valvulas;
			Size = new System.Drawing.Size(536, 314);
			grupo_motores_valvulas2.Size = this.Size;
			this.Grupo_motores_valvulas.TabIndex = 7;
			this.Grupo_motores_valvulas.TabStop = false;
			this.Grupo_motores_valvulas.Text = "Motores e Válvulas";
			this.GroupBox2.Controls.Add(this.Label10);
			this.GroupBox2.Controls.Add(this.Label9);
			this.GroupBox2.Controls.Add(this.Label5);
			this.GroupBox2.Controls.Add(this.Label6);
			this.GroupBox2.Controls.Add(this.Label7);
			this.GroupBox2.Controls.Add(this.Tempo_abertura_v4);
			this.GroupBox2.Controls.Add(this.Tempo_abertura_v3);
			this.GroupBox2.Controls.Add(this.Label8);
			this.GroupBox2.Controls.Add(this.Tempo_fechamento_v4);
			this.GroupBox2.Controls.Add(this.Tempo_abertura_v2);
			this.GroupBox2.Controls.Add(this.Tempo_fechamento_v3);
			this.GroupBox2.Controls.Add(this.Tempo_fechamento_v2);
			this.GroupBox2.Controls.Add(this.Tempo_abertura_v1);
			this.GroupBox2.Controls.Add(this.Tempo_fechamento_v1);
			global::System.Windows.Forms.Control groupBox = this.GroupBox2;
groupBox.Location = new global::System.Drawing.Point(266, 17);
			this.GroupBox2.Name = "GroupBox2";
			global::System.Windows.Forms.Control groupBox2 = this.GroupBox2;
			Size = new System.Drawing.Size(250, 141);
			groupBox2.Size = this.Size;
			this.GroupBox2.TabIndex = 32;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Válvulas";
			this.Label10.AutoSize = true;
			global::System.Windows.Forms.Control label = this.Label10;
label.Location = new global::System.Drawing.Point(154, 16);
			this.Label10.Name = "Label10";
			global::System.Windows.Forms.Control label2 = this.Label10;
			Size = new System.Drawing.Size(90, 13);
			label2.Size = this.Size;
			this.Label10.TabIndex = 27;
			this.Label10.Text = "T. fechamento (s)";
			this.Label9.AutoSize = true;
			global::System.Windows.Forms.Control label3 = this.Label9;
label3.Location = new global::System.Drawing.Point(65, 16);
			this.Label9.Name = "Label9";
			global::System.Windows.Forms.Control label4 = this.Label9;
			Size = new System.Drawing.Size(73, 13);
			label4.Size = this.Size;
			this.Label9.TabIndex = 27;
			this.Label9.Text = "T. abertura (s)";
			this.Label5.AutoSize = true;
			global::System.Windows.Forms.Control label5 = this.Label5;
label5.Location = new global::System.Drawing.Point(17, 112);
			this.Label5.Name = "Label5";
			global::System.Windows.Forms.Control label6 = this.Label5;
			Size = new System.Drawing.Size(37, 13);
			label6.Size = this.Size;
			this.Label5.TabIndex = 26;
			this.Label5.Text = "Val 4 :";
			this.Label6.AutoSize = true;
			global::System.Windows.Forms.Control label7 = this.Label6;
label7.Location = new global::System.Drawing.Point(17, 88);
			this.Label6.Name = "Label6";
			global::System.Windows.Forms.Control label8 = this.Label6;
			Size = new System.Drawing.Size(37, 13);
			label8.Size = this.Size;
			this.Label6.TabIndex = 26;
			this.Label6.Text = "Val 3 :";
			this.Label7.AutoSize = true;
			global::System.Windows.Forms.Control label9 = this.Label7;
label9.Location = new global::System.Drawing.Point(17, 64);
			this.Label7.Name = "Label7";
			global::System.Windows.Forms.Control label10 = this.Label7;
			Size = new System.Drawing.Size(37, 13);
			label10.Size = this.Size;
			this.Label7.TabIndex = 26;
			this.Label7.Text = "Val 2 :";
			global::System.Windows.Forms.Control tempo_abertura_v = this.Tempo_abertura_v4;
tempo_abertura_v.Location = new global::System.Drawing.Point(67, 110);
			global::System.Windows.Forms.NumericUpDown tempo_abertura_v2 = this.Tempo_abertura_v4;
			decimal num;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_abertura_v2.Maximum = num;
			this.Tempo_abertura_v4.Name = "Tempo_abertura_v4";
			global::System.Windows.Forms.Control tempo_abertura_v3 = this.Tempo_abertura_v4;
			Size = new System.Drawing.Size(70, 20);
			tempo_abertura_v3.Size = this.Size;
			this.Tempo_abertura_v4.TabIndex = 24;
			this.Tempo_abertura_v4.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control tempo_abertura_v4 = this.Tempo_abertura_v3;
tempo_abertura_v4.Location = new global::System.Drawing.Point(67, 85);
			global::System.Windows.Forms.NumericUpDown tempo_abertura_v5 = this.Tempo_abertura_v3;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_abertura_v5.Maximum = num;
			this.Tempo_abertura_v3.Name = "Tempo_abertura_v3";
			global::System.Windows.Forms.Control tempo_abertura_v6 = this.Tempo_abertura_v3;
			Size = new System.Drawing.Size(70, 20);
			tempo_abertura_v6.Size = this.Size;
			this.Tempo_abertura_v3.TabIndex = 24;
			this.Tempo_abertura_v3.TextAlign = HorizontalAlignment.Center;
			this.Label8.AutoSize = true;
			global::System.Windows.Forms.Control label11 = this.Label8;
label11.Location = new global::System.Drawing.Point(17, 40);
			this.Label8.Name = "Label8";
			global::System.Windows.Forms.Control label12 = this.Label8;
			Size = new System.Drawing.Size(37, 13);
			label12.Size = this.Size;
			this.Label8.TabIndex = 26;
			this.Label8.Text = "Val 1 :";
			global::System.Windows.Forms.Control tempo_fechamento_v = this.Tempo_fechamento_v4;
tempo_fechamento_v.Location = new global::System.Drawing.Point(161, 110);
			global::System.Windows.Forms.NumericUpDown tempo_fechamento_v2 = this.Tempo_fechamento_v4;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_fechamento_v2.Maximum = num;
			this.Tempo_fechamento_v4.Name = "Tempo_fechamento_v4";
			global::System.Windows.Forms.Control tempo_fechamento_v3 = this.Tempo_fechamento_v4;
			Size = new System.Drawing.Size(70, 20);
			tempo_fechamento_v3.Size = this.Size;
			this.Tempo_fechamento_v4.TabIndex = 25;
			this.Tempo_fechamento_v4.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control tempo_abertura_v7 = this.Tempo_abertura_v2;
tempo_abertura_v7.Location = new global::System.Drawing.Point(67, 60);
			global::System.Windows.Forms.NumericUpDown tempo_abertura_v8 = this.Tempo_abertura_v2;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_abertura_v8.Maximum = num;
			this.Tempo_abertura_v2.Name = "Tempo_abertura_v2";
			global::System.Windows.Forms.Control tempo_abertura_v9 = this.Tempo_abertura_v2;
			Size = new System.Drawing.Size(70, 20);
			tempo_abertura_v9.Size = this.Size;
			this.Tempo_abertura_v2.TabIndex = 24;
			this.Tempo_abertura_v2.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control tempo_fechamento_v4 = this.Tempo_fechamento_v3;
tempo_fechamento_v4.Location = new global::System.Drawing.Point(160, 85);
			global::System.Windows.Forms.NumericUpDown tempo_fechamento_v5 = this.Tempo_fechamento_v3;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_fechamento_v5.Maximum = num;
			this.Tempo_fechamento_v3.Name = "Tempo_fechamento_v3";
			global::System.Windows.Forms.Control tempo_fechamento_v6 = this.Tempo_fechamento_v3;
			Size = new System.Drawing.Size(70, 20);
			tempo_fechamento_v6.Size = this.Size;
			this.Tempo_fechamento_v3.TabIndex = 25;
			this.Tempo_fechamento_v3.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control tempo_fechamento_v7 = this.Tempo_fechamento_v2;
tempo_fechamento_v7.Location = new global::System.Drawing.Point(161, 60);
			global::System.Windows.Forms.NumericUpDown tempo_fechamento_v8 = this.Tempo_fechamento_v2;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_fechamento_v8.Maximum = num;
			this.Tempo_fechamento_v2.Name = "Tempo_fechamento_v2";
			global::System.Windows.Forms.Control tempo_fechamento_v9 = this.Tempo_fechamento_v2;
			Size = new System.Drawing.Size(70, 20);
			tempo_fechamento_v9.Size = this.Size;
			this.Tempo_fechamento_v2.TabIndex = 25;
			this.Tempo_fechamento_v2.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control tempo_abertura_v10 = this.Tempo_abertura_v1;
tempo_abertura_v10.Location = new global::System.Drawing.Point(67, 33);
			global::System.Windows.Forms.NumericUpDown tempo_abertura_v11 = this.Tempo_abertura_v1;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_abertura_v11.Maximum = num;
			this.Tempo_abertura_v1.Name = "Tempo_abertura_v1";
			global::System.Windows.Forms.Control tempo_abertura_v12 = this.Tempo_abertura_v1;
			Size = new System.Drawing.Size(70, 20);
			tempo_abertura_v12.Size = this.Size;
			this.Tempo_abertura_v1.TabIndex = 24;
			this.Tempo_abertura_v1.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control tempo_fechamento_v10 = this.Tempo_fechamento_v1;
tempo_fechamento_v10.Location = new global::System.Drawing.Point(160, 33);
			global::System.Windows.Forms.NumericUpDown tempo_fechamento_v11 = this.Tempo_fechamento_v1;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_fechamento_v11.Maximum = num;
			this.Tempo_fechamento_v1.Name = "Tempo_fechamento_v1";
			global::System.Windows.Forms.Control tempo_fechamento_v12 = this.Tempo_fechamento_v1;
			Size = new System.Drawing.Size(70, 20);
			tempo_fechamento_v12.Size = this.Size;
			this.Tempo_fechamento_v1.TabIndex = 25;
			this.Tempo_fechamento_v1.TextAlign = HorizontalAlignment.Center;
			this.GroupBox1.Controls.Add(this.Label_tempo_parada);
			this.GroupBox1.Controls.Add(this.Label_tempo_partida);
			this.GroupBox1.Controls.Add(this.Label_modo_de_operacao_motor);
			this.GroupBox1.Controls.Add(this.Label_motor4);
			this.GroupBox1.Controls.Add(this.Label_motor3);
			this.GroupBox1.Controls.Add(this.Combo_modo_partida_m4);
			this.GroupBox1.Controls.Add(this.Combo_modo_partida_m3);
			this.GroupBox1.Controls.Add(this.Label_motor2);
			this.GroupBox1.Controls.Add(this.Combo_modo_partida_m2);
			this.GroupBox1.Controls.Add(this.Tempo_partida_m4);
			this.GroupBox1.Controls.Add(this.Tempo_partida_m3);
			this.GroupBox1.Controls.Add(this.Label_motor1);
			this.GroupBox1.Controls.Add(this.Tempo_parada_m4);
			this.GroupBox1.Controls.Add(this.Tempo_partida_m2);
			this.GroupBox1.Controls.Add(this.Tempo_parada_m3);
			this.GroupBox1.Controls.Add(this.Combo_modo_partida_m1);
			this.GroupBox1.Controls.Add(this.Tempo_parada_m2);
			this.GroupBox1.Controls.Add(this.Tempo_partida_m1);
			this.GroupBox1.Controls.Add(this.Tempo_parada_m1);
			global::System.Windows.Forms.Control groupBox3 = this.GroupBox1;
groupBox3.Location = new global::System.Drawing.Point(18, 161);
			this.GroupBox1.Name = "GroupBox1";
			global::System.Windows.Forms.Control groupBox4 = this.GroupBox1;
			Size = new System.Drawing.Size(498, 134);
			groupBox4.Size = this.Size;
			this.GroupBox1.TabIndex = 32;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Motores";
			this.Label_tempo_parada.AutoSize = true;
			global::System.Windows.Forms.Control label_tempo_parada = this.Label_tempo_parada;
label_tempo_parada.Location = new global::System.Drawing.Point(370, 13);
			this.Label_tempo_parada.Name = "Label_tempo_parada";
			global::System.Windows.Forms.Control label_tempo_parada2 = this.Label_tempo_parada;
			Size = new System.Drawing.Size(105, 13);
			label_tempo_parada2.Size = this.Size;
			this.Label_tempo_parada.TabIndex = 30;
			this.Label_tempo_parada.Text = "Tempo parada (seg.)";
			this.Label_tempo_partida.AutoSize = true;
			global::System.Windows.Forms.Control label_tempo_partida = this.Label_tempo_partida;
label_tempo_partida.Location = new global::System.Drawing.Point(240, 13);
			this.Label_tempo_partida.Name = "Label_tempo_partida";
			global::System.Windows.Forms.Control label_tempo_partida2 = this.Label_tempo_partida;
			Size = new System.Drawing.Size(104, 13);
			label_tempo_partida2.Size = this.Size;
			this.Label_tempo_partida.TabIndex = 29;
			this.Label_tempo_partida.Text = "Tempo partida (seg.)";
			this.Label_modo_de_operacao_motor.AutoSize = true;
			global::System.Windows.Forms.Control label_modo_de_operacao_motor = this.Label_modo_de_operacao_motor;
label_modo_de_operacao_motor.Location = new global::System.Drawing.Point(99, 13);
			this.Label_modo_de_operacao_motor.Name = "Label_modo_de_operacao_motor";
			global::System.Windows.Forms.Control label_modo_de_operacao_motor2 = this.Label_modo_de_operacao_motor;
			Size = new System.Drawing.Size(97, 13);
			label_modo_de_operacao_motor2.Size = this.Size;
			this.Label_modo_de_operacao_motor.TabIndex = 28;
			this.Label_modo_de_operacao_motor.Text = "Modo de operação";
			this.Label_motor4.AutoSize = true;
			global::System.Windows.Forms.Control label_motor = this.Label_motor4;
label_motor.Location = new global::System.Drawing.Point(24, 105);
			this.Label_motor4.Name = "Label_motor4";
			global::System.Windows.Forms.Control label_motor2 = this.Label_motor4;
			Size = new System.Drawing.Size(49, 13);
			label_motor2.Size = this.Size;
			this.Label_motor4.TabIndex = 26;
			this.Label_motor4.Text = "Motor 4 :";
			this.Label_motor3.AutoSize = true;
			global::System.Windows.Forms.Control label_motor3 = this.Label_motor3;
label_motor3.Location = new global::System.Drawing.Point(24, 82);
			this.Label_motor3.Name = "Label_motor3";
			global::System.Windows.Forms.Control label_motor4 = this.Label_motor3;
			Size = new System.Drawing.Size(49, 13);
			label_motor4.Size = this.Size;
			this.Label_motor3.TabIndex = 26;
			this.Label_motor3.Text = "Motor 3 :";
			this.Combo_modo_partida_m4.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_modo_partida_m = this.Combo_modo_partida_m4;
combo_modo_partida_m.Location = new global::System.Drawing.Point(86, 101);
			this.Combo_modo_partida_m4.Name = "Combo_modo_partida_m4";
			global::System.Windows.Forms.Control combo_modo_partida_m2 = this.Combo_modo_partida_m4;
			Size = new System.Drawing.Size(124, 21);
			combo_modo_partida_m2.Size = this.Size;
			this.Combo_modo_partida_m4.TabIndex = 20;
			this.Combo_modo_partida_m3.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_modo_partida_m3 = this.Combo_modo_partida_m3;
combo_modo_partida_m3.Location = new global::System.Drawing.Point(86, 78);
			this.Combo_modo_partida_m3.Name = "Combo_modo_partida_m3";
			global::System.Windows.Forms.Control combo_modo_partida_m4 = this.Combo_modo_partida_m3;
			Size = new System.Drawing.Size(124, 21);
			combo_modo_partida_m4.Size = this.Size;
			this.Combo_modo_partida_m3.TabIndex = 20;
			this.Label_motor2.AutoSize = true;
			global::System.Windows.Forms.Control label_motor5 = this.Label_motor2;
label_motor5.Location = new global::System.Drawing.Point(24, 58);
			this.Label_motor2.Name = "Label_motor2";
			global::System.Windows.Forms.Control label_motor6 = this.Label_motor2;
			Size = new System.Drawing.Size(49, 13);
			label_motor6.Size = this.Size;
			this.Label_motor2.TabIndex = 26;
			this.Label_motor2.Text = "Motor 2 :";
			this.Combo_modo_partida_m2.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_modo_partida_m5 = this.Combo_modo_partida_m2;
combo_modo_partida_m5.Location = new global::System.Drawing.Point(86, 54);
			this.Combo_modo_partida_m2.Name = "Combo_modo_partida_m2";
			global::System.Windows.Forms.Control combo_modo_partida_m6 = this.Combo_modo_partida_m2;
			Size = new System.Drawing.Size(124, 21);
			combo_modo_partida_m6.Size = this.Size;
			this.Combo_modo_partida_m2.TabIndex = 20;
			global::System.Windows.Forms.Control tempo_partida_m = this.Tempo_partida_m4;
tempo_partida_m.Location = new global::System.Drawing.Point(231, 101);
			global::System.Windows.Forms.NumericUpDown tempo_partida_m2 = this.Tempo_partida_m4;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_partida_m2.Maximum = num;
			this.Tempo_partida_m4.Name = "Tempo_partida_m4";
			global::System.Windows.Forms.Control tempo_partida_m3 = this.Tempo_partida_m4;
			Size = new System.Drawing.Size(115, 20);
			tempo_partida_m3.Size = this.Size;
			this.Tempo_partida_m4.TabIndex = 24;
			this.Tempo_partida_m4.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control tempo_partida_m4 = this.Tempo_partida_m3;
tempo_partida_m4.Location = new global::System.Drawing.Point(231, 78);
			global::System.Windows.Forms.NumericUpDown tempo_partida_m5 = this.Tempo_partida_m3;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_partida_m5.Maximum = num;
			this.Tempo_partida_m3.Name = "Tempo_partida_m3";
			global::System.Windows.Forms.Control tempo_partida_m6 = this.Tempo_partida_m3;
			Size = new System.Drawing.Size(115, 20);
			tempo_partida_m6.Size = this.Size;
			this.Tempo_partida_m3.TabIndex = 24;
			this.Tempo_partida_m3.TextAlign = HorizontalAlignment.Center;
			this.Label_motor1.AutoSize = true;
			global::System.Windows.Forms.Control label_motor7 = this.Label_motor1;
label_motor7.Location = new global::System.Drawing.Point(24, 34);
			this.Label_motor1.Name = "Label_motor1";
			global::System.Windows.Forms.Control label_motor8 = this.Label_motor1;
			Size = new System.Drawing.Size(49, 13);
			label_motor8.Size = this.Size;
			this.Label_motor1.TabIndex = 26;
			this.Label_motor1.Text = "Motor 1 :";
			global::System.Windows.Forms.Control tempo_parada_m = this.Tempo_parada_m4;
tempo_parada_m.Location = new global::System.Drawing.Point(363, 101);
			global::System.Windows.Forms.NumericUpDown tempo_parada_m2 = this.Tempo_parada_m4;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_parada_m2.Maximum = num;
			this.Tempo_parada_m4.Name = "Tempo_parada_m4";
			global::System.Windows.Forms.Control tempo_parada_m3 = this.Tempo_parada_m4;
			Size = new System.Drawing.Size(115, 20);
			tempo_parada_m3.Size = this.Size;
			this.Tempo_parada_m4.TabIndex = 25;
			this.Tempo_parada_m4.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control tempo_partida_m7 = this.Tempo_partida_m2;
tempo_partida_m7.Location = new global::System.Drawing.Point(231, 54);
			global::System.Windows.Forms.NumericUpDown tempo_partida_m8 = this.Tempo_partida_m2;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_partida_m8.Maximum = num;
			this.Tempo_partida_m2.Name = "Tempo_partida_m2";
			global::System.Windows.Forms.Control tempo_partida_m9 = this.Tempo_partida_m2;
			Size = new System.Drawing.Size(115, 20);
			tempo_partida_m9.Size = this.Size;
			this.Tempo_partida_m2.TabIndex = 24;
			this.Tempo_partida_m2.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control tempo_parada_m4 = this.Tempo_parada_m3;
tempo_parada_m4.Location = new global::System.Drawing.Point(363, 78);
			global::System.Windows.Forms.NumericUpDown tempo_parada_m5 = this.Tempo_parada_m3;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_parada_m5.Maximum = num;
			this.Tempo_parada_m3.Name = "Tempo_parada_m3";
			global::System.Windows.Forms.Control tempo_parada_m6 = this.Tempo_parada_m3;
			Size = new System.Drawing.Size(115, 20);
			tempo_parada_m6.Size = this.Size;
			this.Tempo_parada_m3.TabIndex = 25;
			this.Tempo_parada_m3.TextAlign = HorizontalAlignment.Center;
			this.Combo_modo_partida_m1.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_modo_partida_m7 = this.Combo_modo_partida_m1;
combo_modo_partida_m7.Location = new global::System.Drawing.Point(86, 30);
			this.Combo_modo_partida_m1.Name = "Combo_modo_partida_m1";
			global::System.Windows.Forms.Control combo_modo_partida_m8 = this.Combo_modo_partida_m1;
			Size = new System.Drawing.Size(124, 21);
			combo_modo_partida_m8.Size = this.Size;
			this.Combo_modo_partida_m1.TabIndex = 20;
			global::System.Windows.Forms.Control tempo_parada_m7 = this.Tempo_parada_m2;
tempo_parada_m7.Location = new global::System.Drawing.Point(363, 54);
			global::System.Windows.Forms.NumericUpDown tempo_parada_m8 = this.Tempo_parada_m2;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_parada_m8.Maximum = num;
			this.Tempo_parada_m2.Name = "Tempo_parada_m2";
			global::System.Windows.Forms.Control tempo_parada_m9 = this.Tempo_parada_m2;
			Size = new System.Drawing.Size(115, 20);
			tempo_parada_m9.Size = this.Size;
			this.Tempo_parada_m2.TabIndex = 25;
			this.Tempo_parada_m2.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control tempo_partida_m10 = this.Tempo_partida_m1;
tempo_partida_m10.Location = new global::System.Drawing.Point(231, 30);
			global::System.Windows.Forms.NumericUpDown tempo_partida_m11 = this.Tempo_partida_m1;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_partida_m11.Maximum = num;
			this.Tempo_partida_m1.Name = "Tempo_partida_m1";
			global::System.Windows.Forms.Control tempo_partida_m12 = this.Tempo_partida_m1;
			Size = new System.Drawing.Size(115, 20);
			tempo_partida_m12.Size = this.Size;
			this.Tempo_partida_m1.TabIndex = 24;
			this.Tempo_partida_m1.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control tempo_parada_m10 = this.Tempo_parada_m1;
tempo_parada_m10.Location = new global::System.Drawing.Point(363, 30);
			global::System.Windows.Forms.NumericUpDown tempo_parada_m11 = this.Tempo_parada_m1;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_parada_m11.Maximum = num;
			this.Tempo_parada_m1.Name = "Tempo_parada_m1";
			global::System.Windows.Forms.Control tempo_parada_m12 = this.Tempo_parada_m1;
			Size = new System.Drawing.Size(115, 20);
			tempo_parada_m12.Size = this.Size;
			this.Tempo_parada_m1.TabIndex = 25;
			this.Tempo_parada_m1.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control valor_num_bomba_simultaneas = this.Valor_num_bomba_simultaneas;
valor_num_bomba_simultaneas.Location = new global::System.Drawing.Point(179, 102);
			global::System.Windows.Forms.NumericUpDown valor_num_bomba_simultaneas2 = this.Valor_num_bomba_simultaneas;
			num = new decimal(new int[]
			{
				4,
				0,
				0,
				0
			});
			valor_num_bomba_simultaneas2.Maximum = num;
			this.Valor_num_bomba_simultaneas.Name = "Valor_num_bomba_simultaneas";
			global::System.Windows.Forms.Control valor_num_bomba_simultaneas3 = this.Valor_num_bomba_simultaneas;
			Size = new System.Drawing.Size(74, 20);
			valor_num_bomba_simultaneas3.Size = this.Size;
			this.Valor_num_bomba_simultaneas.TabIndex = 13;
			this.Valor_num_bomba_simultaneas.TextAlign = HorizontalAlignment.Center;
			this.Label_num_bombas_simultaneas.AutoSize = true;
			global::System.Windows.Forms.Control label_num_bombas_simultaneas = this.Label_num_bombas_simultaneas;
label_num_bombas_simultaneas.Location = new global::System.Drawing.Point(14, 105);
			this.Label_num_bombas_simultaneas.Name = "Label_num_bombas_simultaneas";
			global::System.Windows.Forms.Control label_num_bombas_simultaneas2 = this.Label_num_bombas_simultaneas;
			Size = new System.Drawing.Size(148, 13);
			label_num_bombas_simultaneas2.Size = this.Size;
			this.Label_num_bombas_simultaneas.TabIndex = 12;
			this.Label_num_bombas_simultaneas.Text = "Número bombas simultâneas :";
			this.Combo_modo_operacao.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_modo_operacao = this.Combo_modo_operacao;
combo_modo_operacao.Location = new global::System.Drawing.Point(120, 23);
			this.Combo_modo_operacao.Name = "Combo_modo_operacao";
			global::System.Windows.Forms.Control combo_modo_operacao2 = this.Combo_modo_operacao;
			Size = new System.Drawing.Size(133, 21);
			combo_modo_operacao2.Size = this.Size;
			this.Combo_modo_operacao.TabIndex = 10;
			this.Label_modo_operacao.AutoSize = true;
			global::System.Windows.Forms.Control label_modo_operacao = this.Label_modo_operacao;
label_modo_operacao.Location = new global::System.Drawing.Point(14, 27);
			this.Label_modo_operacao.Name = "Label_modo_operacao";
			global::System.Windows.Forms.Control label_modo_operacao2 = this.Label_modo_operacao;
			Size = new System.Drawing.Size(105, 13);
			label_modo_operacao2.Size = this.Size;
			this.Label_modo_operacao.TabIndex = 11;
			this.Label_modo_operacao.Text = "Modo de Operação :";
			global::System.Windows.Forms.Control tempo_entre_acionamentos = this.Tempo_entre_acionamentos;
tempo_entre_acionamentos.Location = new global::System.Drawing.Point(179, 127);
			global::System.Windows.Forms.NumericUpDown tempo_entre_acionamentos2 = this.Tempo_entre_acionamentos;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_entre_acionamentos2.Maximum = num;
			this.Tempo_entre_acionamentos.Name = "Tempo_entre_acionamentos";
			global::System.Windows.Forms.Control tempo_entre_acionamentos3 = this.Tempo_entre_acionamentos;
			Size = new System.Drawing.Size(74, 20);
			tempo_entre_acionamentos3.Size = this.Size;
			this.Tempo_entre_acionamentos.TabIndex = 9;
			this.Tempo_entre_acionamentos.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control numero_motores = this.Numero_motores;
numero_motores.Location = new global::System.Drawing.Point(179, 50);
			global::System.Windows.Forms.NumericUpDown numero_motores2 = this.Numero_motores;
			num = new decimal(new int[]
			{
				4,
				0,
				0,
				0
			});
			numero_motores2.Maximum = num;
			this.Numero_motores.Name = "Numero_motores";
			global::System.Windows.Forms.Control numero_motores3 = this.Numero_motores;
			Size = new System.Drawing.Size(74, 20);
			numero_motores3.Size = this.Size;
			this.Numero_motores.TabIndex = 8;
			this.Numero_motores.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control numero_valvulas = this.Numero_valvulas;
numero_valvulas.Location = new global::System.Drawing.Point(179, 76);
			global::System.Windows.Forms.NumericUpDown numero_valvulas2 = this.Numero_valvulas;
			num = new decimal(new int[]
			{
				4,
				0,
				0,
				0
			});
			numero_valvulas2.Maximum = num;
			this.Numero_valvulas.Name = "Numero_valvulas";
			global::System.Windows.Forms.Control numero_valvulas3 = this.Numero_valvulas;
			Size = new System.Drawing.Size(74, 20);
			numero_valvulas3.Size = this.Size;
			this.Numero_valvulas.TabIndex = 8;
			this.Numero_valvulas.TextAlign = HorizontalAlignment.Center;
			this.Label_tempo_entre_acionamentos.AutoSize = true;
			global::System.Windows.Forms.Control label_tempo_entre_acionamentos = this.Label_tempo_entre_acionamentos;
label_tempo_entre_acionamentos.Location = new global::System.Drawing.Point(14, 131);
			this.Label_tempo_entre_acionamentos.Name = "Label_tempo_entre_acionamentos";
			global::System.Windows.Forms.Control label_tempo_entre_acionamentos2 = this.Label_tempo_entre_acionamentos;
			Size = new System.Drawing.Size(154, 13);
			label_tempo_entre_acionamentos2.Size = this.Size;
			this.Label_tempo_entre_acionamentos.TabIndex = 5;
			this.Label_tempo_entre_acionamentos.Text = "Tempo entre operações (min.) :";
			this.Label_num_motores.AutoSize = true;
			global::System.Windows.Forms.Control label_num_motores = this.Label_num_motores;
label_num_motores.Location = new global::System.Drawing.Point(14, 53);
			this.Label_num_motores.Name = "Label_num_motores";
			global::System.Windows.Forms.Control label_num_motores2 = this.Label_num_motores;
			Size = new System.Drawing.Size(105, 13);
			label_num_motores2.Size = this.Size;
			this.Label_num_motores.TabIndex = 5;
			this.Label_num_motores.Text = "Número de motores :";
			this.Label_num_valvulas.AutoSize = true;
			global::System.Windows.Forms.Control label_num_valvulas = this.Label_num_valvulas;
label_num_valvulas.Location = new global::System.Drawing.Point(14, 79);
			this.Label_num_valvulas.Name = "Label_num_valvulas";
			global::System.Windows.Forms.Control label_num_valvulas2 = this.Label_num_valvulas;
			Size = new System.Drawing.Size(107, 13);
			label_num_valvulas2.Size = this.Size;
			this.Label_num_valvulas.TabIndex = 5;
			this.Label_num_valvulas.Text = "Número de válvulas :";
			global::System.Windows.Forms.Control valor_pressao_min_recalque = this.Valor_pressao_min_recalque;
valor_pressao_min_recalque.Location = new global::System.Drawing.Point(161, 184);
			this.Valor_pressao_min_recalque.Name = "Valor_pressao_min_recalque";
			global::System.Windows.Forms.Control valor_pressao_min_recalque2 = this.Valor_pressao_min_recalque;
			Size = new System.Drawing.Size(74, 20);
			valor_pressao_min_recalque2.Size = this.Size;
			this.Valor_pressao_min_recalque.TabIndex = 25;
			this.Valor_pressao_min_recalque.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control valor_pressao_min_succao = this.Valor_pressao_min_succao;
valor_pressao_min_succao.Location = new global::System.Drawing.Point(161, 161);
			this.Valor_pressao_min_succao.Name = "Valor_pressao_min_succao";
			global::System.Windows.Forms.Control valor_pressao_min_succao2 = this.Valor_pressao_min_succao;
			Size = new System.Drawing.Size(74, 20);
			valor_pressao_min_succao2.Size = this.Size;
			this.Valor_pressao_min_succao.TabIndex = 24;
			this.Valor_pressao_min_succao.TextAlign = HorizontalAlignment.Center;
			this.Label_pressao_min_succao.AutoSize = true;
			global::System.Windows.Forms.Control label_pressao_min_succao = this.Label_pressao_min_succao;
label_pressao_min_succao.Location = new global::System.Drawing.Point(18, 163);
			this.Label_pressao_min_succao.Name = "Label_pressao_min_succao";
			global::System.Windows.Forms.Control label_pressao_min_succao2 = this.Label_pressao_min_succao;
			Size = new System.Drawing.Size(130, 13);
			label_pressao_min_succao2.Size = this.Size;
			this.Label_pressao_min_succao.TabIndex = 12;
			this.Label_pressao_min_succao.Text = "Pressão mín. sucção (%) :";
			this.Label_pressao_min_recalque.AutoSize = true;
			global::System.Windows.Forms.Control label_pressao_min_recalque = this.Label_pressao_min_recalque;
label_pressao_min_recalque.Location = new global::System.Drawing.Point(18, 186);
			this.Label_pressao_min_recalque.Name = "Label_pressao_min_recalque";
			global::System.Windows.Forms.Control label_pressao_min_recalque2 = this.Label_pressao_min_recalque;
			Size = new System.Drawing.Size(136, 13);
			label_pressao_min_recalque2.Size = this.Size;
			this.Label_pressao_min_recalque.TabIndex = 10;
			this.Label_pressao_min_recalque.Text = "Pressão mín. recalque (%) :";
			global::System.Windows.Forms.Control valor_tempo_mais_bomba = this.Valor_tempo_mais_bomba;
valor_tempo_mais_bomba.Location = new global::System.Drawing.Point(161, 138);
			global::System.Windows.Forms.NumericUpDown valor_tempo_mais_bomba2 = this.Valor_tempo_mais_bomba;
			num = new decimal(new int[]
			{
				180,
				0,
				0,
				0
			});
			valor_tempo_mais_bomba2.Maximum = num;
			this.Valor_tempo_mais_bomba.Name = "Valor_tempo_mais_bomba";
			global::System.Windows.Forms.Control valor_tempo_mais_bomba3 = this.Valor_tempo_mais_bomba;
			Size = new System.Drawing.Size(74, 20);
			valor_tempo_mais_bomba3.Size = this.Size;
			this.Valor_tempo_mais_bomba.TabIndex = 21;
			this.Valor_tempo_mais_bomba.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control valor_nivel_liga_b = this.Valor_nivel_liga_b4;
valor_nivel_liga_b.Location = new global::System.Drawing.Point(161, 115);
			global::System.Windows.Forms.NumericUpDown valor_nivel_liga_b2 = this.Valor_nivel_liga_b4;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_nivel_liga_b2.Minimum = num;
			this.Valor_nivel_liga_b4.Name = "Valor_nivel_liga_b4";
			global::System.Windows.Forms.Control valor_nivel_liga_b3 = this.Valor_nivel_liga_b4;
			Size = new System.Drawing.Size(74, 20);
			valor_nivel_liga_b3.Size = this.Size;
			this.Valor_nivel_liga_b4.TabIndex = 20;
			this.Valor_nivel_liga_b4.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown valor_nivel_liga_b4 = this.Valor_nivel_liga_b4;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_nivel_liga_b4.Value = num;
			this.Label_nivel_liga_b4.AutoSize = true;
			global::System.Windows.Forms.Control label_nivel_liga_b = this.Label_nivel_liga_b4;
label_nivel_liga_b.Location = new global::System.Drawing.Point(18, 117);
			this.Label_nivel_liga_b4.Name = "Label_nivel_liga_b4";
			global::System.Windows.Forms.Control label_nivel_liga_b2 = this.Label_nivel_liga_b4;
			Size = new System.Drawing.Size(137, 13);
			label_nivel_liga_b2.Size = this.Size;
			this.Label_nivel_liga_b4.TabIndex = 12;
			this.Label_nivel_liga_b4.Text = "Nível p/ ligar Bomba 4 (%) :";
			this.Label_tempo_mais_bomba.AutoSize = true;
			global::System.Windows.Forms.Control label_tempo_mais_bomba = this.Label_tempo_mais_bomba;
label_tempo_mais_bomba.Location = new global::System.Drawing.Point(18, 140);
			this.Label_tempo_mais_bomba.Name = "Label_tempo_mais_bomba";
			global::System.Windows.Forms.Control label_tempo_mais_bomba2 = this.Label_tempo_mais_bomba;
			Size = new System.Drawing.Size(121, 13);
			label_tempo_mais_bomba2.Size = this.Size;
			this.Label_tempo_mais_bomba.TabIndex = 10;
			this.Label_tempo_mais_bomba.Text = "Tempo +1 bomba (min) :";
			global::System.Windows.Forms.Control valor_nivel_liga_b5 = this.Valor_nivel_liga_b1;
valor_nivel_liga_b5.Location = new global::System.Drawing.Point(161, 46);
			global::System.Windows.Forms.NumericUpDown valor_nivel_liga_b6 = this.Valor_nivel_liga_b1;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_nivel_liga_b6.Minimum = num;
			this.Valor_nivel_liga_b1.Name = "Valor_nivel_liga_b1";
			global::System.Windows.Forms.Control valor_nivel_liga_b7 = this.Valor_nivel_liga_b1;
			Size = new System.Drawing.Size(74, 20);
			valor_nivel_liga_b7.Size = this.Size;
			this.Valor_nivel_liga_b1.TabIndex = 17;
			this.Valor_nivel_liga_b1.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown valor_nivel_liga_b8 = this.Valor_nivel_liga_b1;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_nivel_liga_b8.Value = num;
			global::System.Windows.Forms.Control valor_nivel_desejado = this.Valor_nivel_desejado;
valor_nivel_desejado.Location = new global::System.Drawing.Point(161, 23);
			this.Valor_nivel_desejado.Name = "Valor_nivel_desejado";
			global::System.Windows.Forms.Control valor_nivel_desejado2 = this.Valor_nivel_desejado;
			Size = new System.Drawing.Size(74, 20);
			valor_nivel_desejado2.Size = this.Size;
			this.Valor_nivel_desejado.TabIndex = 10;
			this.Valor_nivel_desejado.TextAlign = HorizontalAlignment.Center;
			this.Label_nivel_desejado.AutoSize = true;
			global::System.Windows.Forms.Control label_nivel_desejado = this.Label_nivel_desejado;
label_nivel_desejado.Location = new global::System.Drawing.Point(20, 25);
			this.Label_nivel_desejado.Name = "Label_nivel_desejado";
			global::System.Windows.Forms.Control label_nivel_desejado2 = this.Label_nivel_desejado;
			Size = new System.Drawing.Size(102, 13);
			label_nivel_desejado2.Size = this.Size;
			this.Label_nivel_desejado.TabIndex = 12;
			this.Label_nivel_desejado.Text = "Nível desejado (%) :";
			this.Label_nivel_liga_b1.AutoSize = true;
			global::System.Windows.Forms.Control label_nivel_liga_b3 = this.Label_nivel_liga_b1;
label_nivel_liga_b3.Location = new global::System.Drawing.Point(20, 48);
			this.Label_nivel_liga_b1.Name = "Label_nivel_liga_b1";
			global::System.Windows.Forms.Control label_nivel_liga_b4 = this.Label_nivel_liga_b1;
			Size = new System.Drawing.Size(137, 13);
			label_nivel_liga_b4.Size = this.Size;
			this.Label_nivel_liga_b1.TabIndex = 10;
			this.Label_nivel_liga_b1.Text = "Nível p/ ligar Bomba 1 (%) :";
			this.Grupo_repetidora.Controls.Add(this.Valor_num_est_rep);
			this.Grupo_repetidora.Controls.Add(this.Valor_end_rep);
			this.Grupo_repetidora.Controls.Add(this.Grupo_end_rep);
			this.Grupo_repetidora.Controls.Add(this.CheckBox_hab_rep);
			this.Grupo_repetidora.Controls.Add(this.Label_num_est_rep);
			this.Grupo_repetidora.Controls.Add(this.Label_end_rep);
			global::System.Windows.Forms.Control grupo_repetidora = this.Grupo_repetidora;
grupo_repetidora.Location = new global::System.Drawing.Point(13, 153);
			this.Grupo_repetidora.Name = "Grupo_repetidora";
			global::System.Windows.Forms.Control grupo_repetidora2 = this.Grupo_repetidora;
			Size = new System.Drawing.Size(336, 284);
			grupo_repetidora2.Size = this.Size;
			this.Grupo_repetidora.TabIndex = 1;
			this.Grupo_repetidora.TabStop = false;
			this.Grupo_repetidora.Text = "Parâmetros da Repetidora";
			global::System.Windows.Forms.Control valor_num_est_rep = this.Valor_num_est_rep;
valor_num_est_rep.Location = new global::System.Drawing.Point(210, 87);
			global::System.Windows.Forms.NumericUpDown valor_num_est_rep2 = this.Valor_num_est_rep;
			num = new decimal(new int[]
			{
				50,
				0,
				0,
				0
			});
			valor_num_est_rep2.Maximum = num;
			this.Valor_num_est_rep.Name = "Valor_num_est_rep";
			global::System.Windows.Forms.Control valor_num_est_rep3 = this.Valor_num_est_rep;
			Size = new System.Drawing.Size(93, 20);
			valor_num_est_rep3.Size = this.Size;
			this.Valor_num_est_rep.TabIndex = 9;
			this.Valor_num_est_rep.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.Control valor_end_rep = this.Valor_end_rep;
valor_end_rep.Location = new global::System.Drawing.Point(210, 61);
			global::System.Windows.Forms.NumericUpDown valor_end_rep2 = this.Valor_end_rep;
			num = new decimal(new int[]
			{
				200,
				0,
				0,
				0
			});
			valor_end_rep2.Maximum = num;
			this.Valor_end_rep.Name = "Valor_end_rep";
			global::System.Windows.Forms.Control valor_end_rep3 = this.Valor_end_rep;
			Size = new System.Drawing.Size(93, 20);
			valor_end_rep3.Size = this.Size;
			this.Valor_end_rep.TabIndex = 8;
			this.Valor_end_rep.TextAlign = HorizontalAlignment.Right;
			this.Grupo_end_rep.Controls.Add(this.VScrollBar1);
			this.Grupo_end_rep.Controls.Add(this.Label_end_rep_12);
			this.Grupo_end_rep.Controls.Add(this.Valor_end_rep_12);
			this.Grupo_end_rep.Controls.Add(this.Label_end_rep_11);
			this.Grupo_end_rep.Controls.Add(this.Valor_end_rep_11);
			this.Grupo_end_rep.Controls.Add(this.Label_end_rep_6);
			this.Grupo_end_rep.Controls.Add(this.Valor_end_rep_6);
			this.Grupo_end_rep.Controls.Add(this.Label_end_rep_3);
			this.Grupo_end_rep.Controls.Add(this.Valor_end_rep_3);
			this.Grupo_end_rep.Controls.Add(this.Label_end_rep_9);
			this.Grupo_end_rep.Controls.Add(this.Valor_end_rep_9);
			this.Grupo_end_rep.Controls.Add(this.Label_end_rep_8);
			this.Grupo_end_rep.Controls.Add(this.Valor_end_rep_8);
			this.Grupo_end_rep.Controls.Add(this.Label_end_rep_5);
			this.Grupo_end_rep.Controls.Add(this.Valor_end_rep_5);
			this.Grupo_end_rep.Controls.Add(this.Label_end_rep_2);
			this.Grupo_end_rep.Controls.Add(this.Valor_end_rep_2);
			this.Grupo_end_rep.Controls.Add(this.Label_end_rep_10);
			this.Grupo_end_rep.Controls.Add(this.Valor_end_rep_10);
			this.Grupo_end_rep.Controls.Add(this.Label_end_rep_7);
			this.Grupo_end_rep.Controls.Add(this.Label_end_rep_4);
			this.Grupo_end_rep.Controls.Add(this.Valor_end_rep_7);
			this.Grupo_end_rep.Controls.Add(this.Valor_end_rep_4);
			this.Grupo_end_rep.Controls.Add(this.Label_end_rep_1);
			this.Grupo_end_rep.Controls.Add(this.Valor_end_rep_1);
			global::System.Windows.Forms.Control grupo_end_rep = this.Grupo_end_rep;
grupo_end_rep.Location = new global::System.Drawing.Point(24, 122);
			this.Grupo_end_rep.Name = "Grupo_end_rep";
			global::System.Windows.Forms.Control grupo_end_rep2 = this.Grupo_end_rep;
			Size = new System.Drawing.Size(296, 144);
			grupo_end_rep2.Size = this.Size;
			this.Grupo_end_rep.TabIndex = 3;
			this.Grupo_end_rep.TabStop = false;
			this.Grupo_end_rep.Text = "Endereço para repetição";
			this.VScrollBar1.LargeChange = 2;
			global::System.Windows.Forms.Control vscrollBar = this.VScrollBar1;
vscrollBar.Location = new global::System.Drawing.Point(264, 28);
			this.VScrollBar1.Maximum = 5;
			this.VScrollBar1.Name = "VScrollBar1";
			global::System.Windows.Forms.Control vscrollBar2 = this.VScrollBar1;
			Size = new System.Drawing.Size(25, 98);
			vscrollBar2.Size = this.Size;
			this.VScrollBar1.TabIndex = 24;
			this.Label_end_rep_12.AutoSize = true;
			global::System.Windows.Forms.Control label_end_rep_ = this.Label_end_rep_12;
label_end_rep_.Location = new global::System.Drawing.Point(176, 110);
			this.Label_end_rep_12.Name = "Label_end_rep_12";
			global::System.Windows.Forms.Control label_end_rep_2 = this.Label_end_rep_12;
			Size = new System.Drawing.Size(25, 13);
			label_end_rep_2.Size = this.Size;
			this.Label_end_rep_12.TabIndex = 11;
			this.Label_end_rep_12.Text = "12 :";
			this.Valor_end_rep_12.AcceptsReturn = true;
			global::System.Windows.Forms.Control valor_end_rep_ = this.Valor_end_rep_12;
valor_end_rep_.Location = new global::System.Drawing.Point(199, 106);
			this.Valor_end_rep_12.Name = "Valor_end_rep_12";
			global::System.Windows.Forms.Control valor_end_rep_2 = this.Valor_end_rep_12;
			Size = new System.Drawing.Size(43, 20);
			valor_end_rep_2.Size = this.Size;
			this.Valor_end_rep_12.TabIndex = 11;
			this.Valor_end_rep_12.TextAlign = HorizontalAlignment.Center;
			this.Label_end_rep_11.AutoSize = true;
			global::System.Windows.Forms.Control label_end_rep_3 = this.Label_end_rep_11;
label_end_rep_3.Location = new global::System.Drawing.Point(99, 110);
			this.Label_end_rep_11.Name = "Label_end_rep_11";
			global::System.Windows.Forms.Control label_end_rep_4 = this.Label_end_rep_11;
			Size = new System.Drawing.Size(25, 13);
			label_end_rep_4.Size = this.Size;
			this.Label_end_rep_11.TabIndex = 10;
			this.Label_end_rep_11.Text = "11 :";
			global::System.Windows.Forms.Control valor_end_rep_3 = this.Valor_end_rep_11;
valor_end_rep_3.Location = new global::System.Drawing.Point(122, 106);
			this.Valor_end_rep_11.Name = "Valor_end_rep_11";
			global::System.Windows.Forms.Control valor_end_rep_4 = this.Valor_end_rep_11;
			Size = new System.Drawing.Size(43, 20);
			valor_end_rep_4.Size = this.Size;
			this.Valor_end_rep_11.TabIndex = 7;
			this.Valor_end_rep_11.TextAlign = HorizontalAlignment.Center;
			this.Label_end_rep_6.AutoSize = true;
			global::System.Windows.Forms.Control label_end_rep_5 = this.Label_end_rep_6;
label_end_rep_5.Location = new global::System.Drawing.Point(176, 58);
			this.Label_end_rep_6.Name = "Label_end_rep_6";
			global::System.Windows.Forms.Control label_end_rep_6 = this.Label_end_rep_6;
			Size = new System.Drawing.Size(25, 13);
			label_end_rep_6.Size = this.Size;
			this.Label_end_rep_6.TabIndex = 5;
			this.Label_end_rep_6.Text = "06 :";
			global::System.Windows.Forms.Control valor_end_rep_5 = this.Valor_end_rep_6;
valor_end_rep_5.Location = new global::System.Drawing.Point(199, 54);
			this.Valor_end_rep_6.Name = "Valor_end_rep_6";
			global::System.Windows.Forms.Control valor_end_rep_6 = this.Valor_end_rep_6;
			Size = new System.Drawing.Size(43, 20);
			valor_end_rep_6.Size = this.Size;
			this.Valor_end_rep_6.TabIndex = 9;
			this.Valor_end_rep_6.TextAlign = HorizontalAlignment.Center;
			this.Label_end_rep_3.AutoSize = true;
			global::System.Windows.Forms.Control label_end_rep_7 = this.Label_end_rep_3;
label_end_rep_7.Location = new global::System.Drawing.Point(176, 32);
			this.Label_end_rep_3.Name = "Label_end_rep_3";
			global::System.Windows.Forms.Control label_end_rep_8 = this.Label_end_rep_3;
			Size = new System.Drawing.Size(25, 13);
			label_end_rep_8.Size = this.Size;
			this.Label_end_rep_3.TabIndex = 2;
			this.Label_end_rep_3.Text = "03 :";
			global::System.Windows.Forms.Control valor_end_rep_7 = this.Valor_end_rep_3;
valor_end_rep_7.Location = new global::System.Drawing.Point(199, 28);
			this.Valor_end_rep_3.Name = "Valor_end_rep_3";
			global::System.Windows.Forms.Control valor_end_rep_8 = this.Valor_end_rep_3;
			Size = new System.Drawing.Size(43, 20);
			valor_end_rep_8.Size = this.Size;
			this.Valor_end_rep_3.TabIndex = 8;
			this.Valor_end_rep_3.TextAlign = HorizontalAlignment.Center;
			this.Label_end_rep_9.AutoSize = true;
			global::System.Windows.Forms.Control label_end_rep_9 = this.Label_end_rep_9;
label_end_rep_9.Location = new global::System.Drawing.Point(176, 84);
			this.Label_end_rep_9.Name = "Label_end_rep_9";
			global::System.Windows.Forms.Control label_end_rep_10 = this.Label_end_rep_9;
			Size = new System.Drawing.Size(25, 13);
			label_end_rep_10.Size = this.Size;
			this.Label_end_rep_9.TabIndex = 8;
			this.Label_end_rep_9.Text = "09 :";
			global::System.Windows.Forms.Control valor_end_rep_9 = this.Valor_end_rep_9;
valor_end_rep_9.Location = new global::System.Drawing.Point(199, 80);
			this.Valor_end_rep_9.Name = "Valor_end_rep_9";
			global::System.Windows.Forms.Control valor_end_rep_10 = this.Valor_end_rep_9;
			Size = new System.Drawing.Size(43, 20);
			valor_end_rep_10.Size = this.Size;
			this.Valor_end_rep_9.TabIndex = 10;
			this.Valor_end_rep_9.TextAlign = HorizontalAlignment.Center;
			this.Label_end_rep_8.AutoSize = true;
			global::System.Windows.Forms.Control label_end_rep_11 = this.Label_end_rep_8;
label_end_rep_11.Location = new global::System.Drawing.Point(99, 84);
			this.Label_end_rep_8.Name = "Label_end_rep_8";
			global::System.Windows.Forms.Control label_end_rep_12 = this.Label_end_rep_8;
			Size = new System.Drawing.Size(25, 13);
			label_end_rep_12.Size = this.Size;
			this.Label_end_rep_8.TabIndex = 7;
			this.Label_end_rep_8.Text = "08 :";
			global::System.Windows.Forms.Control valor_end_rep_11 = this.Valor_end_rep_8;
valor_end_rep_11.Location = new global::System.Drawing.Point(122, 80);
			this.Valor_end_rep_8.Name = "Valor_end_rep_8";
			global::System.Windows.Forms.Control valor_end_rep_12 = this.Valor_end_rep_8;
			Size = new System.Drawing.Size(43, 20);
			valor_end_rep_12.Size = this.Size;
			this.Valor_end_rep_8.TabIndex = 6;
			this.Valor_end_rep_8.TextAlign = HorizontalAlignment.Center;
			this.Label_end_rep_5.AutoSize = true;
			global::System.Windows.Forms.Control label_end_rep_13 = this.Label_end_rep_5;
label_end_rep_13.Location = new global::System.Drawing.Point(99, 58);
			this.Label_end_rep_5.Name = "Label_end_rep_5";
			global::System.Windows.Forms.Control label_end_rep_14 = this.Label_end_rep_5;
			Size = new System.Drawing.Size(25, 13);
			label_end_rep_14.Size = this.Size;
			this.Label_end_rep_5.TabIndex = 4;
			this.Label_end_rep_5.Text = "05 :";
			global::System.Windows.Forms.Control valor_end_rep_13 = this.Valor_end_rep_5;
valor_end_rep_13.Location = new global::System.Drawing.Point(122, 54);
			this.Valor_end_rep_5.Name = "Valor_end_rep_5";
			global::System.Windows.Forms.Control valor_end_rep_14 = this.Valor_end_rep_5;
			Size = new System.Drawing.Size(43, 20);
			valor_end_rep_14.Size = this.Size;
			this.Valor_end_rep_5.TabIndex = 5;
			this.Valor_end_rep_5.TextAlign = HorizontalAlignment.Center;
			this.Label_end_rep_2.AutoSize = true;
			global::System.Windows.Forms.Control label_end_rep_15 = this.Label_end_rep_2;
label_end_rep_15.Location = new global::System.Drawing.Point(99, 32);
			this.Label_end_rep_2.Name = "Label_end_rep_2";
			global::System.Windows.Forms.Control label_end_rep_16 = this.Label_end_rep_2;
			Size = new System.Drawing.Size(25, 13);
			label_end_rep_16.Size = this.Size;
			this.Label_end_rep_2.TabIndex = 1;
			this.Label_end_rep_2.Text = "02 :";
			global::System.Windows.Forms.Control valor_end_rep_15 = this.Valor_end_rep_2;
valor_end_rep_15.Location = new global::System.Drawing.Point(122, 28);
			this.Valor_end_rep_2.Name = "Valor_end_rep_2";
			global::System.Windows.Forms.Control valor_end_rep_16 = this.Valor_end_rep_2;
			Size = new System.Drawing.Size(43, 20);
			valor_end_rep_16.Size = this.Size;
			this.Valor_end_rep_2.TabIndex = 4;
			this.Valor_end_rep_2.TextAlign = HorizontalAlignment.Center;
			this.Label_end_rep_10.AutoSize = true;
			global::System.Windows.Forms.Control label_end_rep_17 = this.Label_end_rep_10;
label_end_rep_17.Location = new global::System.Drawing.Point(23, 110);
			this.Label_end_rep_10.Name = "Label_end_rep_10";
			global::System.Windows.Forms.Control label_end_rep_18 = this.Label_end_rep_10;
			Size = new System.Drawing.Size(25, 13);
			label_end_rep_18.Size = this.Size;
			this.Label_end_rep_10.TabIndex = 9;
			this.Label_end_rep_10.Text = "10 :";
			global::System.Windows.Forms.Control valor_end_rep_17 = this.Valor_end_rep_10;
valor_end_rep_17.Location = new global::System.Drawing.Point(46, 106);
			this.Valor_end_rep_10.Name = "Valor_end_rep_10";
			global::System.Windows.Forms.Control valor_end_rep_18 = this.Valor_end_rep_10;
			Size = new System.Drawing.Size(43, 20);
			valor_end_rep_18.Size = this.Size;
			this.Valor_end_rep_10.TabIndex = 3;
			this.Valor_end_rep_10.TextAlign = HorizontalAlignment.Center;
			this.Label_end_rep_7.AutoSize = true;
			global::System.Windows.Forms.Control label_end_rep_19 = this.Label_end_rep_7;
label_end_rep_19.Location = new global::System.Drawing.Point(23, 84);
			this.Label_end_rep_7.Name = "Label_end_rep_7";
			global::System.Windows.Forms.Control label_end_rep_20 = this.Label_end_rep_7;
			Size = new System.Drawing.Size(25, 13);
			label_end_rep_20.Size = this.Size;
			this.Label_end_rep_7.TabIndex = 6;
			this.Label_end_rep_7.Text = "07 :";
			this.Label_end_rep_4.AutoSize = true;
			global::System.Windows.Forms.Control label_end_rep_21 = this.Label_end_rep_4;
label_end_rep_21.Location = new global::System.Drawing.Point(23, 58);
			this.Label_end_rep_4.Name = "Label_end_rep_4";
			global::System.Windows.Forms.Control label_end_rep_22 = this.Label_end_rep_4;
			Size = new System.Drawing.Size(25, 13);
			label_end_rep_22.Size = this.Size;
			this.Label_end_rep_4.TabIndex = 3;
			this.Label_end_rep_4.Text = "04 :";
			global::System.Windows.Forms.Control valor_end_rep_19 = this.Valor_end_rep_7;
valor_end_rep_19.Location = new global::System.Drawing.Point(46, 80);
			this.Valor_end_rep_7.Name = "Valor_end_rep_7";
			global::System.Windows.Forms.Control valor_end_rep_20 = this.Valor_end_rep_7;
			Size = new System.Drawing.Size(43, 20);
			valor_end_rep_20.Size = this.Size;
			this.Valor_end_rep_7.TabIndex = 2;
			this.Valor_end_rep_7.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control valor_end_rep_21 = this.Valor_end_rep_4;
valor_end_rep_21.Location = new global::System.Drawing.Point(46, 54);
			this.Valor_end_rep_4.Name = "Valor_end_rep_4";
			global::System.Windows.Forms.Control valor_end_rep_22 = this.Valor_end_rep_4;
			Size = new System.Drawing.Size(43, 20);
			valor_end_rep_22.Size = this.Size;
			this.Valor_end_rep_4.TabIndex = 1;
			this.Valor_end_rep_4.TextAlign = HorizontalAlignment.Center;
			this.Label_end_rep_1.AutoSize = true;
			global::System.Windows.Forms.Control label_end_rep_23 = this.Label_end_rep_1;
label_end_rep_23.Location = new global::System.Drawing.Point(23, 32);
			this.Label_end_rep_1.Name = "Label_end_rep_1";
			global::System.Windows.Forms.Control label_end_rep_24 = this.Label_end_rep_1;
			Size = new System.Drawing.Size(25, 13);
			label_end_rep_24.Size = this.Size;
			this.Label_end_rep_1.TabIndex = 0;
			this.Label_end_rep_1.Text = "01 :";
			global::System.Windows.Forms.Control valor_end_rep_23 = this.Valor_end_rep_1;
valor_end_rep_23.Location = new global::System.Drawing.Point(46, 28);
			this.Valor_end_rep_1.Name = "Valor_end_rep_1";
			global::System.Windows.Forms.Control valor_end_rep_24 = this.Valor_end_rep_1;
			Size = new System.Drawing.Size(43, 20);
			valor_end_rep_24.Size = this.Size;
			this.Valor_end_rep_1.TabIndex = 0;
			this.Valor_end_rep_1.TextAlign = HorizontalAlignment.Center;
			this.CheckBox_hab_rep.AutoSize = true;
			global::System.Windows.Forms.Control checkBox_hab_rep = this.CheckBox_hab_rep;
checkBox_hab_rep.Location = new global::System.Drawing.Point(28, 27);
			this.CheckBox_hab_rep.Name = "CheckBox_hab_rep";
			global::System.Windows.Forms.Control checkBox_hab_rep2 = this.CheckBox_hab_rep;
			Size = new System.Drawing.Size(155, 17);
			checkBox_hab_rep2.Size = this.Size;
			this.CheckBox_hab_rep.TabIndex = 0;
			this.CheckBox_hab_rep.Text = "Habilita Função Repetidora";
			this.CheckBox_hab_rep.UseVisualStyleBackColor = true;
			this.Label_num_est_rep.AutoSize = true;
			global::System.Windows.Forms.Control label_num_est_rep = this.Label_num_est_rep;
label_num_est_rep.Location = new global::System.Drawing.Point(24, 89);
			this.Label_num_est_rep.Name = "Label_num_est_rep";
			global::System.Windows.Forms.Control label_num_est_rep2 = this.Label_num_est_rep;
			Size = new System.Drawing.Size(112, 13);
			label_num_est_rep2.Size = this.Size;
			this.Label_num_est_rep.TabIndex = 2;
			this.Label_num_est_rep.Text = "Número de Estações :";
			this.Label_end_rep.AutoSize = true;
			global::System.Windows.Forms.Control label_end_rep = this.Label_end_rep;
label_end_rep.Location = new global::System.Drawing.Point(24, 63);
			this.Label_end_rep.Name = "Label_end_rep";
			global::System.Windows.Forms.Control label_end_rep2 = this.Label_end_rep;
			Size = new System.Drawing.Size(129, 13);
			label_end_rep2.Size = this.Size;
			this.Label_end_rep.TabIndex = 1;
			this.Label_end_rep.Text = "Endereço da Repetidora :";
			this.grupo_comunicacao.Controls.Add(this.Combo_baudrate);
			this.grupo_comunicacao.Controls.Add(this.Label_baudrate);
			this.grupo_comunicacao.Controls.Add(this.Valor_temp_ptt);
			this.grupo_comunicacao.Controls.Add(this.Valor_end_mestre);
			this.grupo_comunicacao.Controls.Add(this.Valor_end_est);
			this.grupo_comunicacao.Controls.Add(this.Label_tempo_ptt);
			this.grupo_comunicacao.Controls.Add(this.Label_end_mestre);
			this.grupo_comunicacao.Controls.Add(this.Label_end_est);
			global::System.Windows.Forms.Control grupo_comunicacao = this.grupo_comunicacao;
grupo_comunicacao.Location = new global::System.Drawing.Point(12, 6);
			this.grupo_comunicacao.Name = "grupo_comunicacao";
			global::System.Windows.Forms.Control grupo_comunicacao2 = this.grupo_comunicacao;
			Size = new System.Drawing.Size(335, 141);
			grupo_comunicacao2.Size = this.Size;
			this.grupo_comunicacao.TabIndex = 2;
			this.grupo_comunicacao.TabStop = false;
			this.grupo_comunicacao.Text = "Parâmetros de Comunicação";
			this.Combo_baudrate.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_baudrate = this.Combo_baudrate;
combo_baudrate.Location = new global::System.Drawing.Point(209, 103);
			this.Combo_baudrate.Name = "Combo_baudrate";
			global::System.Windows.Forms.Control combo_baudrate2 = this.Combo_baudrate;
			Size = new System.Drawing.Size(93, 21);
			combo_baudrate2.Size = this.Size;
			this.Combo_baudrate.TabIndex = 10;
			this.Label_baudrate.AutoSize = true;
			global::System.Windows.Forms.Control label_baudrate = this.Label_baudrate;
label_baudrate.Location = new global::System.Drawing.Point(24, 108);
			this.Label_baudrate.Name = "Label_baudrate";
			global::System.Windows.Forms.Control label_baudrate2 = this.Label_baudrate;
			Size = new System.Drawing.Size(95, 13);
			label_baudrate2.Size = this.Size;
			this.Label_baudrate.TabIndex = 11;
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
valor_temp_ptt2.Location = new global::System.Drawing.Point(209, 77);
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
			this.Valor_temp_ptt.TabIndex = 9;
			this.Valor_temp_ptt.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.Control valor_end_mestre = this.Valor_end_mestre;
valor_end_mestre.Location = new global::System.Drawing.Point(209, 24);
			global::System.Windows.Forms.NumericUpDown valor_end_mestre2 = this.Valor_end_mestre;
			num = new decimal(new int[]
			{
				200,
				0,
				0,
				0
			});
			valor_end_mestre2.Maximum = num;
			this.Valor_end_mestre.Name = "Valor_end_mestre";
			global::System.Windows.Forms.Control valor_end_mestre3 = this.Valor_end_mestre;
			Size = new System.Drawing.Size(93, 20);
			valor_end_mestre3.Size = this.Size;
			this.Valor_end_mestre.TabIndex = 8;
			this.Valor_end_mestre.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.Control valor_end_est = this.Valor_end_est;
valor_end_est.Location = new global::System.Drawing.Point(209, 51);
			global::System.Windows.Forms.NumericUpDown valor_end_est2 = this.Valor_end_est;
			num = new decimal(new int[]
			{
				200,
				0,
				0,
				0
			});
			valor_end_est2.Maximum = num;
			this.Valor_end_est.Name = "Valor_end_est";
			global::System.Windows.Forms.Control valor_end_est3 = this.Valor_end_est;
			Size = new System.Drawing.Size(93, 20);
			valor_end_est3.Size = this.Size;
			this.Valor_end_est.TabIndex = 7;
			this.Valor_end_est.TextAlign = HorizontalAlignment.Right;
			this.Label_tempo_ptt.AutoSize = true;
			global::System.Windows.Forms.Control label_tempo_ptt = this.Label_tempo_ptt;
label_tempo_ptt.Location = new global::System.Drawing.Point(24, 79);
			this.Label_tempo_ptt.Name = "Label_tempo_ptt";
			global::System.Windows.Forms.Control label_tempo_ptt2 = this.Label_tempo_ptt;
			Size = new System.Drawing.Size(140, 13);
			label_tempo_ptt2.Size = this.Size;
			this.Label_tempo_ptt.TabIndex = 4;
			this.Label_tempo_ptt.Text = "Tempo Espera de PTT (ms):";
			this.Label_end_mestre.AutoSize = true;
			global::System.Windows.Forms.Control label_end_mestre = this.Label_end_mestre;
label_end_mestre.Location = new global::System.Drawing.Point(24, 26);
			this.Label_end_mestre.Name = "Label_end_mestre";
			global::System.Windows.Forms.Control label_end_mestre2 = this.Label_end_mestre;
			Size = new System.Drawing.Size(109, 13);
			label_end_mestre2.Size = this.Size;
			this.Label_end_mestre.TabIndex = 1;
			this.Label_end_mestre.Text = "Endereço do Mestre :";
			this.Label_end_est.AutoSize = true;
			global::System.Windows.Forms.Control label_end_est = this.Label_end_est;
label_end_est.Location = new global::System.Drawing.Point(24, 53);
			this.Label_end_est.Name = "Label_end_est";
			global::System.Windows.Forms.Control label_end_est2 = this.Label_end_est;
			Size = new System.Drawing.Size(116, 13);
			label_end_est2.Size = this.Size;
			this.Label_end_est.TabIndex = 0;
			this.Label_end_est.Text = "Endereço da Estação :";
			this.MenuStrip1.Dock =(System.Windows.Forms.DockStyle)2;
			this.MenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ArquivoToolStripMenuItem
			});
			global::System.Windows.Forms.Control menuStrip = this.MenuStrip1;
menuStrip.Location = new global::System.Drawing.Point(0, 693);
			this.MenuStrip1.Name = "MenuStrip1";
			global::System.Windows.Forms.Control menuStrip2 = this.MenuStrip1;
			Size = new System.Drawing.Size(916, 24);
			menuStrip2.Size = this.Size;
			this.MenuStrip1.TabIndex = 9;
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
			global::System.Windows.Forms.Control valor_nivel_liga_b9 = this.Valor_nivel_liga_b3;
valor_nivel_liga_b9.Location = new global::System.Drawing.Point(161, 92);
			global::System.Windows.Forms.NumericUpDown valor_nivel_liga_b10 = this.Valor_nivel_liga_b3;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_nivel_liga_b10.Minimum = num;
			this.Valor_nivel_liga_b3.Name = "Valor_nivel_liga_b3";
			global::System.Windows.Forms.Control valor_nivel_liga_b11 = this.Valor_nivel_liga_b3;
			Size = new System.Drawing.Size(74, 20);
			valor_nivel_liga_b11.Size = this.Size;
			this.Valor_nivel_liga_b3.TabIndex = 25;
			this.Valor_nivel_liga_b3.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown valor_nivel_liga_b12 = this.Valor_nivel_liga_b3;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_nivel_liga_b12.Value = num;
			global::System.Windows.Forms.Control valor_nivel_liga_b13 = this.Valor_nivel_liga_b2;
valor_nivel_liga_b13.Location = new global::System.Drawing.Point(161, 69);
			global::System.Windows.Forms.NumericUpDown valor_nivel_liga_b14 = this.Valor_nivel_liga_b2;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_nivel_liga_b14.Minimum = num;
			this.Valor_nivel_liga_b2.Name = "Valor_nivel_liga_b2";
			global::System.Windows.Forms.Control valor_nivel_liga_b15 = this.Valor_nivel_liga_b2;
			Size = new System.Drawing.Size(74, 20);
			valor_nivel_liga_b15.Size = this.Size;
			this.Valor_nivel_liga_b2.TabIndex = 24;
			this.Valor_nivel_liga_b2.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown valor_nivel_liga_b16 = this.Valor_nivel_liga_b2;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_nivel_liga_b16.Value = num;
			this.Label_nivel_liga_b2.AutoSize = true;
			global::System.Windows.Forms.Control label_nivel_liga_b5 = this.Label_nivel_liga_b2;
label_nivel_liga_b5.Location = new global::System.Drawing.Point(20, 71);
			this.Label_nivel_liga_b2.Name = "Label_nivel_liga_b2";
			global::System.Windows.Forms.Control label_nivel_liga_b6 = this.Label_nivel_liga_b2;
			Size = new System.Drawing.Size(137, 13);
			label_nivel_liga_b6.Size = this.Size;
			this.Label_nivel_liga_b2.TabIndex = 12;
			this.Label_nivel_liga_b2.Text = "Nível p/ ligar Bomba 2 (%) :";
			this.Label_nivel_liga_b3.AutoSize = true;
			global::System.Windows.Forms.Control label_nivel_liga_b7 = this.Label_nivel_liga_b3;
label_nivel_liga_b7.Location = new global::System.Drawing.Point(20, 94);
			this.Label_nivel_liga_b3.Name = "Label_nivel_liga_b3";
			global::System.Windows.Forms.Control label_nivel_liga_b8 = this.Label_nivel_liga_b3;
			Size = new System.Drawing.Size(137, 13);
			label_nivel_liga_b8.Size = this.Size;
			this.Label_nivel_liga_b3.TabIndex = 10;
			this.Label_nivel_liga_b3.Text = "Nível p/ ligar Bomba 3 (%) :";
			this.Grupo_setpoints.Controls.Add(this.Label_nivel_desejado);
			this.Grupo_setpoints.Controls.Add(this.Valor_nivel_desejado);
			this.Grupo_setpoints.Controls.Add(this.Label_nivel_liga_b2);
			this.Grupo_setpoints.Controls.Add(this.Valor_nivel_liga_b2);
			this.Grupo_setpoints.Controls.Add(this.Valor_nivel_liberacao);
			this.Grupo_setpoints.Controls.Add(this.Valor_pressao_min_recalque);
			this.Grupo_setpoints.Controls.Add(this.Label_nivel_liga_b3);
			this.Grupo_setpoints.Controls.Add(this.Valor_nivel_liga_b1);
			this.Grupo_setpoints.Controls.Add(this.Valor_tempo_mais_bomba);
			this.Grupo_setpoints.Controls.Add(this.Label_nivel_liga_b1);
			this.Grupo_setpoints.Controls.Add(this.Valor_nivel_liga_b3);
			this.Grupo_setpoints.Controls.Add(this.Valor_nivel_bloqueio);
			this.Grupo_setpoints.Controls.Add(this.Valor_pressao_min_succao);
			this.Grupo_setpoints.Controls.Add(this.Label_nivel_liga_b4);
			this.Grupo_setpoints.Controls.Add(this.Label_nivel_liberacao);
			this.Grupo_setpoints.Controls.Add(this.Label_pressao_min_recalque);
			this.Grupo_setpoints.Controls.Add(this.Valor_nivel_liga_b4);
			this.Grupo_setpoints.Controls.Add(this.Label_nivel_bloqueio);
			this.Grupo_setpoints.Controls.Add(this.Label_pressao_min_succao);
			this.Grupo_setpoints.Controls.Add(this.Label_tempo_mais_bomba);
			global::System.Windows.Forms.Control grupo_setpoints = this.Grupo_setpoints;
grupo_setpoints.Location = new global::System.Drawing.Point(647, 432);
			this.Grupo_setpoints.Name = "Grupo_setpoints";
			global::System.Windows.Forms.Control grupo_setpoints2 = this.Grupo_setpoints;
			Size = new System.Drawing.Size(254, 264);
			grupo_setpoints2.Size = this.Size;
			this.Grupo_setpoints.TabIndex = 26;
			this.Grupo_setpoints.TabStop = false;
			this.Grupo_setpoints.Text = "Setpoints";
			global::System.Windows.Forms.Control valor_nivel_liberacao = this.Valor_nivel_liberacao;
valor_nivel_liberacao.Location = new global::System.Drawing.Point(161, 230);
			this.Valor_nivel_liberacao.Name = "Valor_nivel_liberacao";
			global::System.Windows.Forms.Control valor_nivel_liberacao2 = this.Valor_nivel_liberacao;
			Size = new System.Drawing.Size(74, 20);
			valor_nivel_liberacao2.Size = this.Size;
			this.Valor_nivel_liberacao.TabIndex = 25;
			this.Valor_nivel_liberacao.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown valor_nivel_liberacao3 = this.Valor_nivel_liberacao;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			valor_nivel_liberacao3.Value = num;
			global::System.Windows.Forms.Control valor_nivel_bloqueio = this.Valor_nivel_bloqueio;
valor_nivel_bloqueio.Location = new global::System.Drawing.Point(161, 207);
			this.Valor_nivel_bloqueio.Name = "Valor_nivel_bloqueio";
			global::System.Windows.Forms.Control valor_nivel_bloqueio2 = this.Valor_nivel_bloqueio;
			Size = new System.Drawing.Size(74, 20);
			valor_nivel_bloqueio2.Size = this.Size;
			this.Valor_nivel_bloqueio.TabIndex = 24;
			this.Valor_nivel_bloqueio.TextAlign = HorizontalAlignment.Center;
			this.Label_nivel_liberacao.AutoSize = true;
			global::System.Windows.Forms.Control label_nivel_liberacao = this.Label_nivel_liberacao;
label_nivel_liberacao.Location = new global::System.Drawing.Point(18, 232);
			this.Label_nivel_liberacao.Name = "Label_nivel_liberacao";
			global::System.Windows.Forms.Control label_nivel_liberacao2 = this.Label_nivel_liberacao;
			Size = new System.Drawing.Size(142, 13);
			label_nivel_liberacao2.Size = this.Size;
			this.Label_nivel_liberacao.TabIndex = 10;
			this.Label_nivel_liberacao.Text = "Nível liberação (origem) (%) :";
			this.Label_nivel_bloqueio.AutoSize = true;
			global::System.Windows.Forms.Control label_nivel_bloqueio = this.Label_nivel_bloqueio;
label_nivel_bloqueio.Location = new global::System.Drawing.Point(18, 209);
			this.Label_nivel_bloqueio.Name = "Label_nivel_bloqueio";
			global::System.Windows.Forms.Control label_nivel_bloqueio2 = this.Label_nivel_bloqueio;
			Size = new System.Drawing.Size(139, 13);
			label_nivel_bloqueio2.Size = this.Size;
			this.Label_nivel_bloqueio.TabIndex = 12;
			this.Label_nivel_bloqueio.Text = "Nível bloqueio (origem) (%) :";
			this.Grupo_analogicas.Controls.Add(this.CheckBox_ctrl_nivel_fonte);
			this.Grupo_analogicas.Controls.Add(this.Combo_num_totalizacoes);
			this.Grupo_analogicas.Controls.Add(this.Label_num_totalizacoes);
			this.Grupo_analogicas.Controls.Add(this.Valor_tamanho_filtro_AD);
			this.Grupo_analogicas.Controls.Add(this.Valor_intervalo_filtro_AD);
			this.Grupo_analogicas.Controls.Add(this.Label_tamanho_filtro_AD);
			this.Grupo_analogicas.Controls.Add(this.Label_intervalo_filtro_AD);
			global::System.Windows.Forms.Control grupo_analogicas = this.Grupo_analogicas;
grupo_analogicas.Location = new global::System.Drawing.Point(11, 452);
			this.Grupo_analogicas.Name = "Grupo_analogicas";
			global::System.Windows.Forms.Control grupo_analogicas2 = this.Grupo_analogicas;
			Size = new System.Drawing.Size(336, 145);
			grupo_analogicas2.Size = this.Size;
			this.Grupo_analogicas.TabIndex = 27;
			this.Grupo_analogicas.TabStop = false;
			this.Grupo_analogicas.Text = "Configuração de medidas analógicas";
			this.CheckBox_ctrl_nivel_fonte.AutoSize = true;
			global::System.Windows.Forms.Control checkBox_ctrl_nivel_fonte = this.CheckBox_ctrl_nivel_fonte;
checkBox_ctrl_nivel_fonte.Location = new global::System.Drawing.Point(29, 35);
			this.CheckBox_ctrl_nivel_fonte.Name = "CheckBox_ctrl_nivel_fonte";
			global::System.Windows.Forms.Control checkBox_ctrl_nivel_fonte2 = this.CheckBox_ctrl_nivel_fonte;
			Size = new System.Drawing.Size(156, 17);
			checkBox_ctrl_nivel_fonte2.Size = this.Size;
			this.CheckBox_ctrl_nivel_fonte.TabIndex = 34;
			this.CheckBox_ctrl_nivel_fonte.Text = "Habilita controle nível fonte";
			this.CheckBox_ctrl_nivel_fonte.UseVisualStyleBackColor = true;
			this.Combo_num_totalizacoes.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_num_totalizacoes = this.Combo_num_totalizacoes;
combo_num_totalizacoes.Location = new global::System.Drawing.Point(211, 113);
			this.Combo_num_totalizacoes.Name = "Combo_num_totalizacoes";
			global::System.Windows.Forms.Control combo_num_totalizacoes2 = this.Combo_num_totalizacoes;
			Size = new System.Drawing.Size(93, 21);
			combo_num_totalizacoes2.Size = this.Size;
			this.Combo_num_totalizacoes.TabIndex = 15;
			this.Label_num_totalizacoes.AutoSize = true;
			global::System.Windows.Forms.Control label_num_totalizacoes = this.Label_num_totalizacoes;
label_num_totalizacoes.Location = new global::System.Drawing.Point(29, 117);
			this.Label_num_totalizacoes.Name = "Label_num_totalizacoes";
			global::System.Windows.Forms.Control label_num_totalizacoes2 = this.Label_num_totalizacoes;
			Size = new System.Drawing.Size(113, 13);
			label_num_totalizacoes2.Size = this.Size;
			this.Label_num_totalizacoes.TabIndex = 14;
			this.Label_num_totalizacoes.Text = "Número Totalizações :";
			global::System.Windows.Forms.Control valor_tamanho_filtro_AD = this.Valor_tamanho_filtro_AD;
valor_tamanho_filtro_AD.Location = new global::System.Drawing.Point(211, 88);
			global::System.Windows.Forms.NumericUpDown valor_tamanho_filtro_AD2 = this.Valor_tamanho_filtro_AD;
			num = new decimal(new int[]
			{
				5,
				0,
				0,
				0
			});
			valor_tamanho_filtro_AD2.Maximum = num;
			this.Valor_tamanho_filtro_AD.Name = "Valor_tamanho_filtro_AD";
			global::System.Windows.Forms.Control valor_tamanho_filtro_AD3 = this.Valor_tamanho_filtro_AD;
			Size = new System.Drawing.Size(93, 20);
			valor_tamanho_filtro_AD3.Size = this.Size;
			this.Valor_tamanho_filtro_AD.TabIndex = 13;
			this.Valor_tamanho_filtro_AD.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.NumericUpDown valor_intervalo_filtro_AD = this.Valor_intervalo_filtro_AD;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			valor_intervalo_filtro_AD.Increment = num;
			global::System.Windows.Forms.Control valor_intervalo_filtro_AD2 = this.Valor_intervalo_filtro_AD;
valor_intervalo_filtro_AD2.Location = new global::System.Drawing.Point(211, 62);
			global::System.Windows.Forms.NumericUpDown valor_intervalo_filtro_AD3 = this.Valor_intervalo_filtro_AD;
			num = new decimal(new int[]
			{
				20000,
				0,
				0,
				0
			});
			valor_intervalo_filtro_AD3.Maximum = num;
			global::System.Windows.Forms.NumericUpDown valor_intervalo_filtro_AD4 = this.Valor_intervalo_filtro_AD;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			valor_intervalo_filtro_AD4.Minimum = num;
			this.Valor_intervalo_filtro_AD.Name = "Valor_intervalo_filtro_AD";
			global::System.Windows.Forms.Control valor_intervalo_filtro_AD5 = this.Valor_intervalo_filtro_AD;
			Size = new System.Drawing.Size(93, 20);
			valor_intervalo_filtro_AD5.Size = this.Size;
			this.Valor_intervalo_filtro_AD.TabIndex = 12;
			this.Valor_intervalo_filtro_AD.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.NumericUpDown valor_intervalo_filtro_AD6 = this.Valor_intervalo_filtro_AD;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			valor_intervalo_filtro_AD6.Value = num;
			this.Label_tamanho_filtro_AD.AutoSize = true;
			global::System.Windows.Forms.Control label_tamanho_filtro_AD = this.Label_tamanho_filtro_AD;
label_tamanho_filtro_AD.Location = new global::System.Drawing.Point(29, 91);
			this.Label_tamanho_filtro_AD.Name = "Label_tamanho_filtro_AD";
			global::System.Windows.Forms.Control label_tamanho_filtro_AD2 = this.Label_tamanho_filtro_AD;
			Size = new System.Drawing.Size(80, 13);
			label_tamanho_filtro_AD2.Size = this.Size;
			this.Label_tamanho_filtro_AD.TabIndex = 11;
			this.Label_tamanho_filtro_AD.Text = "Tamanho filtro :";
			this.Label_intervalo_filtro_AD.AutoSize = true;
			global::System.Windows.Forms.Control label_intervalo_filtro_AD = this.Label_intervalo_filtro_AD;
label_intervalo_filtro_AD.Location = new global::System.Drawing.Point(29, 65);
			this.Label_intervalo_filtro_AD.Name = "Label_intervalo_filtro_AD";
			global::System.Windows.Forms.Control label_intervalo_filtro_AD2 = this.Label_intervalo_filtro_AD;
			Size = new System.Drawing.Size(98, 13);
			label_intervalo_filtro_AD2.Size = this.Size;
			this.Label_intervalo_filtro_AD.TabIndex = 10;
			this.Label_intervalo_filtro_AD.Text = "Intervalo filtro (ms) :";
			this.Grupo_entradas_digitais.Controls.Add(this.ComboBox_E08);
			this.Grupo_entradas_digitais.Controls.Add(this.ComboBox_E07);
			this.Grupo_entradas_digitais.Controls.Add(this.ComboBox_E06);
			this.Grupo_entradas_digitais.Controls.Add(this.ComboBox_E05);
			this.Grupo_entradas_digitais.Controls.Add(this.ComboBox_E04);
			this.Grupo_entradas_digitais.Controls.Add(this.ComboBox_E03);
			this.Grupo_entradas_digitais.Controls.Add(this.ComboBox_E02);
			this.Grupo_entradas_digitais.Controls.Add(this.ComboBox_E01);
			this.Grupo_entradas_digitais.Controls.Add(this.Label_E08);
			this.Grupo_entradas_digitais.Controls.Add(this.Label_E07);
			this.Grupo_entradas_digitais.Controls.Add(this.Label_E06);
			this.Grupo_entradas_digitais.Controls.Add(this.Label_E05);
			this.Grupo_entradas_digitais.Controls.Add(this.Label_E04);
			this.Grupo_entradas_digitais.Controls.Add(this.Label_E03);
			this.Grupo_entradas_digitais.Controls.Add(this.Label_E02);
			this.Grupo_entradas_digitais.Controls.Add(this.Label_E01);
			global::System.Windows.Forms.Control grupo_entradas_digitais = this.Grupo_entradas_digitais;
grupo_entradas_digitais.Location = new global::System.Drawing.Point(365, 432);
			this.Grupo_entradas_digitais.Name = "Grupo_entradas_digitais";
			global::System.Windows.Forms.Control grupo_entradas_digitais2 = this.Grupo_entradas_digitais;
			Size = new System.Drawing.Size(263, 264);
			grupo_entradas_digitais2.Size = this.Size;
			this.Grupo_entradas_digitais.TabIndex = 28;
			this.Grupo_entradas_digitais.TabStop = false;
			this.Grupo_entradas_digitais.Text = "Entradas digitais";
			this.ComboBox_E08.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox_E = this.ComboBox_E08;
comboBox_E.Location = new global::System.Drawing.Point(71, 225);
			this.ComboBox_E08.Name = "ComboBox_E08";
			global::System.Windows.Forms.Control comboBox_E2 = this.ComboBox_E08;
			Size = new System.Drawing.Size(175, 21);
			comboBox_E2.Size = this.Size;
			this.ComboBox_E08.TabIndex = 38;
			this.ComboBox_E07.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox_E3 = this.ComboBox_E07;
comboBox_E3.Location = new global::System.Drawing.Point(71, 196);
			this.ComboBox_E07.Name = "ComboBox_E07";
			global::System.Windows.Forms.Control comboBox_E4 = this.ComboBox_E07;
			Size = new System.Drawing.Size(175, 21);
			comboBox_E4.Size = this.Size;
			this.ComboBox_E07.TabIndex = 37;
			this.ComboBox_E06.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox_E5 = this.ComboBox_E06;
comboBox_E5.Location = new global::System.Drawing.Point(71, 167);
			this.ComboBox_E06.Name = "ComboBox_E06";
			global::System.Windows.Forms.Control comboBox_E6 = this.ComboBox_E06;
			Size = new System.Drawing.Size(175, 21);
			comboBox_E6.Size = this.Size;
			this.ComboBox_E06.TabIndex = 36;
			this.ComboBox_E05.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox_E7 = this.ComboBox_E05;
comboBox_E7.Location = new global::System.Drawing.Point(71, 138);
			this.ComboBox_E05.Name = "ComboBox_E05";
			global::System.Windows.Forms.Control comboBox_E8 = this.ComboBox_E05;
			Size = new System.Drawing.Size(175, 21);
			comboBox_E8.Size = this.Size;
			this.ComboBox_E05.TabIndex = 35;
			this.ComboBox_E04.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox_E9 = this.ComboBox_E04;
comboBox_E9.Location = new global::System.Drawing.Point(71, 109);
			this.ComboBox_E04.Name = "ComboBox_E04";
			global::System.Windows.Forms.Control comboBox_E10 = this.ComboBox_E04;
			Size = new System.Drawing.Size(175, 21);
			comboBox_E10.Size = this.Size;
			this.ComboBox_E04.TabIndex = 34;
			this.ComboBox_E03.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox_E11 = this.ComboBox_E03;
comboBox_E11.Location = new global::System.Drawing.Point(71, 80);
			this.ComboBox_E03.Name = "ComboBox_E03";
			global::System.Windows.Forms.Control comboBox_E12 = this.ComboBox_E03;
			Size = new System.Drawing.Size(175, 21);
			comboBox_E12.Size = this.Size;
			this.ComboBox_E03.TabIndex = 33;
			this.ComboBox_E02.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox_E13 = this.ComboBox_E02;
comboBox_E13.Location = new global::System.Drawing.Point(71, 51);
			this.ComboBox_E02.Name = "ComboBox_E02";
			global::System.Windows.Forms.Control comboBox_E14 = this.ComboBox_E02;
			Size = new System.Drawing.Size(175, 21);
			comboBox_E14.Size = this.Size;
			this.ComboBox_E02.TabIndex = 32;
			this.ComboBox_E01.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox_E15 = this.ComboBox_E01;
comboBox_E15.Location = new global::System.Drawing.Point(71, 22);
			this.ComboBox_E01.Name = "ComboBox_E01";
			global::System.Windows.Forms.Control comboBox_E16 = this.ComboBox_E01;
			Size = new System.Drawing.Size(175, 21);
			comboBox_E16.Size = this.Size;
			this.ComboBox_E01.TabIndex = 31;
			this.Label_E08.AutoSize = true;
			global::System.Windows.Forms.Control label_E = this.Label_E08;
label_E.Location = new global::System.Drawing.Point(15, 228);
			this.Label_E08.Name = "Label_E08";
			global::System.Windows.Forms.Control label_E2 = this.Label_E08;
			Size = new System.Drawing.Size(50, 13);
			label_E2.Size = this.Size;
			this.Label_E08.TabIndex = 25;
			this.Label_E08.Text = "ENT 08 :";
			this.Label_E07.AutoSize = true;
			global::System.Windows.Forms.Control label_E3 = this.Label_E07;
label_E3.Location = new global::System.Drawing.Point(15, 199);
			this.Label_E07.Name = "Label_E07";
			global::System.Windows.Forms.Control label_E4 = this.Label_E07;
			Size = new System.Drawing.Size(50, 13);
			label_E4.Size = this.Size;
			this.Label_E07.TabIndex = 26;
			this.Label_E07.Text = "ENT 07 :";
			this.Label_E06.AutoSize = true;
			global::System.Windows.Forms.Control label_E5 = this.Label_E06;
label_E5.Location = new global::System.Drawing.Point(15, 170);
			this.Label_E06.Name = "Label_E06";
			global::System.Windows.Forms.Control label_E6 = this.Label_E06;
			Size = new System.Drawing.Size(50, 13);
			label_E6.Size = this.Size;
			this.Label_E06.TabIndex = 23;
			this.Label_E06.Text = "ENT 06 :";
			this.Label_E05.AutoSize = true;
			global::System.Windows.Forms.Control label_E7 = this.Label_E05;
label_E7.Location = new global::System.Drawing.Point(15, 141);
			this.Label_E05.Name = "Label_E05";
			global::System.Windows.Forms.Control label_E8 = this.Label_E05;
			Size = new System.Drawing.Size(50, 13);
			label_E8.Size = this.Size;
			this.Label_E05.TabIndex = 24;
			this.Label_E05.Text = "ENT 05 :";
			this.Label_E04.AutoSize = true;
			global::System.Windows.Forms.Control label_E9 = this.Label_E04;
label_E9.Location = new global::System.Drawing.Point(15, 112);
			this.Label_E04.Name = "Label_E04";
			global::System.Windows.Forms.Control label_E10 = this.Label_E04;
			Size = new System.Drawing.Size(50, 13);
			label_E10.Size = this.Size;
			this.Label_E04.TabIndex = 29;
			this.Label_E04.Text = "ENT 04 :";
			this.Label_E03.AutoSize = true;
			global::System.Windows.Forms.Control label_E11 = this.Label_E03;
label_E11.Location = new global::System.Drawing.Point(15, 83);
			this.Label_E03.Name = "Label_E03";
			global::System.Windows.Forms.Control label_E12 = this.Label_E03;
			Size = new System.Drawing.Size(50, 13);
			label_E12.Size = this.Size;
			this.Label_E03.TabIndex = 30;
			this.Label_E03.Text = "ENT 03 :";
			this.Label_E02.AutoSize = true;
			global::System.Windows.Forms.Control label_E13 = this.Label_E02;
label_E13.Location = new global::System.Drawing.Point(15, 54);
			this.Label_E02.Name = "Label_E02";
			global::System.Windows.Forms.Control label_E14 = this.Label_E02;
			Size = new System.Drawing.Size(50, 13);
			label_E14.Size = this.Size;
			this.Label_E02.TabIndex = 27;
			this.Label_E02.Text = "ENT 02 :";
			this.Label_E01.AutoSize = true;
			global::System.Windows.Forms.Control label_E15 = this.Label_E01;
label_E15.Location = new global::System.Drawing.Point(15, 25);
			this.Label_E01.Name = "Label_E01";
			global::System.Windows.Forms.Control label_E16 = this.Label_E01;
			Size = new System.Drawing.Size(50, 13);
			label_E16.Size = this.Size;
			this.Label_E01.TabIndex = 28;
			this.Label_E01.Text = "ENT 01 :";
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			this.Grupo_perifericos.Controls.Add(this.Label_periferico_4);
			this.Grupo_perifericos.Controls.Add(this.Label_periferico_3);
			this.Grupo_perifericos.Controls.Add(this.Label_nota_2);
			this.Grupo_perifericos.Controls.Add(this.Label_periferico_2);
			this.Grupo_perifericos.Controls.Add(this.Label_nota_1);
			this.Grupo_perifericos.Controls.Add(this.Label_periferico_1);
			this.Grupo_perifericos.Controls.Add(this.Endereco_p4);
			this.Grupo_perifericos.Controls.Add(this.Endereco_p2);
			this.Grupo_perifericos.Controls.Add(this.Endereco_p3);
			this.Grupo_perifericos.Controls.Add(this.Endereco_p1);
			this.Grupo_perifericos.Controls.Add(this.Combo_tipo_p4);
			this.Grupo_perifericos.Controls.Add(this.Combo_tipo_p2);
			this.Grupo_perifericos.Controls.Add(this.Combo_tipo_p3);
			this.Grupo_perifericos.Controls.Add(this.Combo_tipo_p1);
			this.Grupo_perifericos.Enabled = false;
			global::System.Windows.Forms.Control grupo_perifericos = this.Grupo_perifericos;
grupo_perifericos.Location = new global::System.Drawing.Point(365, 330);
			this.Grupo_perifericos.Name = "Grupo_perifericos";
			global::System.Windows.Forms.Control grupo_perifericos2 = this.Grupo_perifericos;
			Size = new System.Drawing.Size(536, 92);
			grupo_perifericos2.Size = this.Size;
			this.Grupo_perifericos.TabIndex = 29;
			this.Grupo_perifericos.TabStop = false;
			this.Grupo_perifericos.Text = "Periféricos";
			this.Label_periferico_4.AutoSize = true;
			global::System.Windows.Forms.Control label_periferico_ = this.Label_periferico_4;
label_periferico_.Location = new global::System.Drawing.Point(273, 62);
			this.Label_periferico_4.Name = "Label_periferico_4";
			global::System.Windows.Forms.Control label_periferico_2 = this.Label_periferico_4;
			Size = new System.Drawing.Size(29, 13);
			label_periferico_2.Size = this.Size;
			this.Label_periferico_4.TabIndex = 19;
			this.Label_periferico_4.Text = "P 4 :";
			this.Label_periferico_3.AutoSize = true;
			global::System.Windows.Forms.Control label_periferico_3 = this.Label_periferico_3;
label_periferico_3.Location = new global::System.Drawing.Point(273, 36);
			this.Label_periferico_3.Name = "Label_periferico_3";
			global::System.Windows.Forms.Control label_periferico_4 = this.Label_periferico_3;
			Size = new System.Drawing.Size(29, 13);
			label_periferico_4.Size = this.Size;
			this.Label_periferico_3.TabIndex = 18;
			this.Label_periferico_3.Text = "P 3 :";
			this.Label_nota_2.AutoSize = true;
			global::System.Windows.Forms.Control label_nota_ = this.Label_nota_2;
label_nota_.Location = new global::System.Drawing.Point(386, 17);
			this.Label_nota_2.Name = "Label_nota_2";
			global::System.Windows.Forms.Control label_nota_2 = this.Label_nota_2;
			Size = new System.Drawing.Size(116, 13);
			label_nota_2.Size = this.Size;
			this.Label_nota_2.TabIndex = 17;
			this.Label_nota_2.Text = "Tipo                       End";
			this.Label_periferico_2.AutoSize = true;
			global::System.Windows.Forms.Control label_periferico_5 = this.Label_periferico_2;
label_periferico_5.Location = new global::System.Drawing.Point(15, 62);
			this.Label_periferico_2.Name = "Label_periferico_2";
			global::System.Windows.Forms.Control label_periferico_6 = this.Label_periferico_2;
			Size = new System.Drawing.Size(29, 13);
			label_periferico_6.Size = this.Size;
			this.Label_periferico_2.TabIndex = 16;
			this.Label_periferico_2.Text = "P 2 :";
			this.Label_nota_1.AutoSize = true;
			global::System.Windows.Forms.Control label_nota_3 = this.Label_nota_1;
label_nota_3.Location = new global::System.Drawing.Point(116, 16);
			this.Label_nota_1.Name = "Label_nota_1";
			global::System.Windows.Forms.Control label_nota_4 = this.Label_nota_1;
			Size = new System.Drawing.Size(129, 13);
			label_nota_4.Size = this.Size;
			this.Label_nota_1.TabIndex = 15;
			this.Label_nota_1.Text = "Tipo                End/Quant";
			this.Label_periferico_1.AutoSize = true;
			global::System.Windows.Forms.Control label_periferico_7 = this.Label_periferico_1;
label_periferico_7.Location = new global::System.Drawing.Point(15, 36);
			this.Label_periferico_1.Name = "Label_periferico_1";
			global::System.Windows.Forms.Control label_periferico_8 = this.Label_periferico_1;
			Size = new System.Drawing.Size(29, 13);
			label_periferico_8.Size = this.Size;
			this.Label_periferico_1.TabIndex = 14;
			this.Label_periferico_1.Text = "P 1 :";
			global::System.Windows.Forms.Control endereco_p = this.Endereco_p4;
endereco_p.Location = new global::System.Drawing.Point(466, 60);
			global::System.Windows.Forms.NumericUpDown endereco_p2 = this.Endereco_p4;
			num = new decimal(new int[]
			{
				255,
				0,
				0,
				0
			});
			endereco_p2.Maximum = num;
			this.Endereco_p4.Name = "Endereco_p4";
			global::System.Windows.Forms.Control endereco_p3 = this.Endereco_p4;
			Size = new System.Drawing.Size(51, 20);
			endereco_p3.Size = this.Size;
			this.Endereco_p4.TabIndex = 13;
			this.Endereco_p4.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control endereco_p4 = this.Endereco_p2;
endereco_p4.Location = new global::System.Drawing.Point(208, 60);
			global::System.Windows.Forms.NumericUpDown endereco_p5 = this.Endereco_p2;
			num = new decimal(new int[]
			{
				255,
				0,
				0,
				0
			});
			endereco_p5.Maximum = num;
			this.Endereco_p2.Name = "Endereco_p2";
			global::System.Windows.Forms.Control endereco_p6 = this.Endereco_p2;
			Size = new System.Drawing.Size(51, 20);
			endereco_p6.Size = this.Size;
			this.Endereco_p2.TabIndex = 12;
			this.Endereco_p2.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control endereco_p7 = this.Endereco_p3;
endereco_p7.Location = new global::System.Drawing.Point(466, 35);
			global::System.Windows.Forms.NumericUpDown endereco_p8 = this.Endereco_p3;
			num = new decimal(new int[]
			{
				255,
				0,
				0,
				0
			});
			endereco_p8.Maximum = num;
			this.Endereco_p3.Name = "Endereco_p3";
			global::System.Windows.Forms.Control endereco_p9 = this.Endereco_p3;
			Size = new System.Drawing.Size(51, 20);
			endereco_p9.Size = this.Size;
			this.Endereco_p3.TabIndex = 11;
			this.Endereco_p3.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control endereco_p10 = this.Endereco_p1;
endereco_p10.Location = new global::System.Drawing.Point(208, 35);
			global::System.Windows.Forms.NumericUpDown endereco_p11 = this.Endereco_p1;
			num = new decimal(new int[]
			{
				255,
				0,
				0,
				0
			});
			endereco_p11.Maximum = num;
			this.Endereco_p1.Name = "Endereco_p1";
			global::System.Windows.Forms.Control endereco_p12 = this.Endereco_p1;
			Size = new System.Drawing.Size(51, 20);
			endereco_p12.Size = this.Size;
			this.Endereco_p1.TabIndex = 10;
			this.Endereco_p1.TextAlign = HorizontalAlignment.Center;
			this.Combo_tipo_p4.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_tipo_p = this.Combo_tipo_p4;
combo_tipo_p.Location = new global::System.Drawing.Point(306, 59);
			this.Combo_tipo_p4.Name = "Combo_tipo_p4";
			global::System.Windows.Forms.Control combo_tipo_p2 = this.Combo_tipo_p4;
			Size = new System.Drawing.Size(154, 21);
			combo_tipo_p2.Size = this.Size;
			this.Combo_tipo_p4.TabIndex = 3;
			this.Combo_tipo_p2.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_tipo_p3 = this.Combo_tipo_p2;
combo_tipo_p3.Location = new global::System.Drawing.Point(48, 59);
			this.Combo_tipo_p2.Name = "Combo_tipo_p2";
			global::System.Windows.Forms.Control combo_tipo_p4 = this.Combo_tipo_p2;
			Size = new System.Drawing.Size(154, 21);
			combo_tipo_p4.Size = this.Size;
			this.Combo_tipo_p2.TabIndex = 2;
			this.Combo_tipo_p3.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_tipo_p5 = this.Combo_tipo_p3;
combo_tipo_p5.Location = new global::System.Drawing.Point(306, 34);
			this.Combo_tipo_p3.Name = "Combo_tipo_p3";
			global::System.Windows.Forms.Control combo_tipo_p6 = this.Combo_tipo_p3;
			Size = new System.Drawing.Size(154, 21);
			combo_tipo_p6.Size = this.Size;
			this.Combo_tipo_p3.TabIndex = 1;
			this.Combo_tipo_p1.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_tipo_p7 = this.Combo_tipo_p1;
combo_tipo_p7.Location = new global::System.Drawing.Point(48, 34);
			this.Combo_tipo_p1.Name = "Combo_tipo_p1";
			global::System.Windows.Forms.Control combo_tipo_p8 = this.Combo_tipo_p1;
			Size = new System.Drawing.Size(154, 21);
			combo_tipo_p8.Size = this.Size;
			this.Combo_tipo_p1.TabIndex = 0;
			global::System.Drawing.SizeF autoScaleDimensions;
			autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			Size = new System.Drawing.Size(916, 717);
			this.ClientSize = Size;
			this.Controls.Add(this.Grupo_perifericos);
			this.Controls.Add(this.Grupo_entradas_digitais);
			this.Controls.Add(this.Grupo_analogicas);
			this.Controls.Add(this.Grupo_setpoints);
			this.Controls.Add(this.Grupo_ctrl);
			this.Controls.Add(this.Grupo_motores_valvulas);
			this.Controls.Add(this.Grupo_repetidora);
			this.Controls.Add(this.grupo_comunicacao);
			this.Controls.Add(this.MenuStrip1);
			this.FormBorderStyle = FormBorderStyle.None;
this.Location = new global::System.Drawing.Point(160, 2);
			this.Name = "Equip_202_conf";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Equipamento MD 202 - Configuração";
			this.Grupo_ctrl.ResumeLayout(false);
			this.Grupo_ctrl.PerformLayout();
			this.Grupo_motores_valvulas.ResumeLayout(false);
			this.Grupo_motores_valvulas.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			
			
			
			
			
			
			
			
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			this.Grupo_repetidora.ResumeLayout(false);
			this.Grupo_repetidora.PerformLayout();
			
			
			this.Grupo_end_rep.ResumeLayout(false);
			this.Grupo_end_rep.PerformLayout();
			this.grupo_comunicacao.ResumeLayout(false);
			this.grupo_comunicacao.PerformLayout();
			
			
			
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			
			
			this.Grupo_setpoints.ResumeLayout(false);
			this.Grupo_setpoints.PerformLayout();
			
			
			this.Grupo_analogicas.ResumeLayout(false);
			this.Grupo_analogicas.PerformLayout();
			
			
			this.Grupo_entradas_digitais.ResumeLayout(false);
			this.Grupo_entradas_digitais.PerformLayout();
			this.Grupo_perifericos.ResumeLayout(false);
			this.Grupo_perifericos.PerformLayout();
			
			
			
			
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04001671 RID: 5745
		private global::System.ComponentModel.IContainer components;
	}
}
