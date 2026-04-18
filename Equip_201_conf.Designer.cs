using System.Drawing;
using System.Windows.Forms;
﻿namespace iS800
{
	// Token: 0x02000081 RID: 129
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Equip_201_conf : global::System.Windows.Forms.Form
	{
		// Token: 0x06001BF1 RID: 7153 RVA: 0x003CCC4C File Offset: 0x003CB04C
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x003CCC6C File Offset: 0x003CB06C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.grupo_comunicacao = new global::System.Windows.Forms.GroupBox();
			this.Valor_temp_ptt = new global::System.Windows.Forms.NumericUpDown();
			this.Valor_end_mestre = new global::System.Windows.Forms.NumericUpDown();
			this.Valor_end_est = new global::System.Windows.Forms.NumericUpDown();
			this.Label_tempo_ptt = new global::System.Windows.Forms.Label();
			this.Label_end_mestre = new global::System.Windows.Forms.Label();
			this.Label_end_est = new global::System.Windows.Forms.Label();
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
			this.Grupo_motores = new global::System.Windows.Forms.GroupBox();
			this.Tempo_entre_acionamentos = new global::System.Windows.Forms.NumericUpDown();
			this.Numero_motores = new global::System.Windows.Forms.NumericUpDown();
			this.Grupo_M3 = new global::System.Windows.Forms.GroupBox();
			this.Tempo_parada_m3 = new global::System.Windows.Forms.NumericUpDown();
			this.Tempo_partida_m3 = new global::System.Windows.Forms.NumericUpDown();
			this.Nivel_partida_m3 = new global::System.Windows.Forms.NumericUpDown();
			this.Nivel_parada_m3 = new global::System.Windows.Forms.NumericUpDown();
			this.Label_tempo_parada_m3 = new global::System.Windows.Forms.Label();
			this.Label_tempo_partida_m3 = new global::System.Windows.Forms.Label();
			this.Label_nivel_parada_m3 = new global::System.Windows.Forms.Label();
			this.Label_nivel_acionamento_m3 = new global::System.Windows.Forms.Label();
			this.Combo_modo_partida_m3 = new global::System.Windows.Forms.ComboBox();
			this.Label_modo_partida_m3 = new global::System.Windows.Forms.Label();
			this.Grupo_M2 = new global::System.Windows.Forms.GroupBox();
			this.Tempo_parada_m2 = new global::System.Windows.Forms.NumericUpDown();
			this.Tempo_partida_m2 = new global::System.Windows.Forms.NumericUpDown();
			this.Nivel_partida_m2 = new global::System.Windows.Forms.NumericUpDown();
			this.Nivel_parada_m2 = new global::System.Windows.Forms.NumericUpDown();
			this.Label_tempo_parada_m2 = new global::System.Windows.Forms.Label();
			this.Label_tempo_partida_m2 = new global::System.Windows.Forms.Label();
			this.Label_nivel_parada_m2 = new global::System.Windows.Forms.Label();
			this.Label_nivel_acionamento_m2 = new global::System.Windows.Forms.Label();
			this.Combo_modo_partida_m2 = new global::System.Windows.Forms.ComboBox();
			this.Label_modo_partida_m2 = new global::System.Windows.Forms.Label();
			this.Grupo_M1 = new global::System.Windows.Forms.GroupBox();
			this.Tempo_parada_m1 = new global::System.Windows.Forms.NumericUpDown();
			this.Tempo_partida_m1 = new global::System.Windows.Forms.NumericUpDown();
			this.Nivel_partida_m1 = new global::System.Windows.Forms.NumericUpDown();
			this.Nivel_parada_m1 = new global::System.Windows.Forms.NumericUpDown();
			this.Label_tempo_parada_m1 = new global::System.Windows.Forms.Label();
			this.Label_tempo_partida_m1 = new global::System.Windows.Forms.Label();
			this.Label_nivel_parada_m1 = new global::System.Windows.Forms.Label();
			this.Label_nivel_acionamento_m1 = new global::System.Windows.Forms.Label();
			this.Combo_modo_partida_m1 = new global::System.Windows.Forms.ComboBox();
			this.Label_modo_partida_m1 = new global::System.Windows.Forms.Label();
			this.Label_tempo_entre_acionamentos = new global::System.Windows.Forms.Label();
			this.Label_num_motores = new global::System.Windows.Forms.Label();
			this.Grupo_ctrl = new global::System.Windows.Forms.GroupBox();
			this.Esc_conf_md_201 = new global::System.Windows.Forms.Button();
			this.Box_Msg = new global::System.Windows.Forms.TextBox();
			this.Ler_conf_md_201 = new global::System.Windows.Forms.Button();
			this.MenuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.ArquivoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SalvarToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.AbrirToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.NovoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.OpenFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.TabControl1 = new global::System.Windows.Forms.TabControl();
			this.TabPage_vazao_calhas = new global::System.Windows.Forms.TabPage();
			this.TabPage_perifericos = new global::System.Windows.Forms.TabPage();
			this.GroupBox_vazoes_820 = new global::System.Windows.Forms.GroupBox();
			this.DataGridView_vazoes_RT820 = new global::System.Windows.Forms.DataGridView();
			this.GroupBox_calhas = new global::System.Windows.Forms.GroupBox();
			this.DataGridView_calhas_RT820 = new global::System.Windows.Forms.DataGridView();
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
			this.grupo_comunicacao.SuspendLayout();
			
			
			
			this.Grupo_repetidora.SuspendLayout();
			
			
			this.Grupo_end_rep.SuspendLayout();
			this.Grupo_motores.SuspendLayout();
			
			
			this.Grupo_M3.SuspendLayout();
			
			
			
			
			this.Grupo_M2.SuspendLayout();
			
			
			
			
			this.Grupo_M1.SuspendLayout();
			
			
			
			
			this.Grupo_ctrl.SuspendLayout();
			this.MenuStrip1.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.TabPage_vazao_calhas.SuspendLayout();
			this.TabPage_perifericos.SuspendLayout();
			this.GroupBox_vazoes_820.SuspendLayout();
			this.GroupBox_calhas.SuspendLayout();
			this.Grupo_perifericos.SuspendLayout();
			this.SuspendLayout();
			this.grupo_comunicacao.Controls.Add(this.Valor_temp_ptt);
			this.grupo_comunicacao.Controls.Add(this.Valor_end_mestre);
			this.grupo_comunicacao.Controls.Add(this.Valor_end_est);
			this.grupo_comunicacao.Controls.Add(this.Label_tempo_ptt);
			this.grupo_comunicacao.Controls.Add(this.Label_end_mestre);
			this.grupo_comunicacao.Controls.Add(this.Label_end_est);
			global::System.Windows.Forms.Control grupo_comunicacao = this.grupo_comunicacao;
			grupo_comunicacao.Location = new global::System.Drawing.Point(12, 12);
			this.grupo_comunicacao.Name = "grupo_comunicacao";
			global::System.Windows.Forms.Control grupo_comunicacao2 = this.grupo_comunicacao;
			grupo_comunicacao2.Size = new global::System.Drawing.Size(335, 128);
			this.grupo_comunicacao.TabIndex = 0;
			this.grupo_comunicacao.TabStop = false;
			this.grupo_comunicacao.Text = "Parâmetros de Comunicação";
			global::System.Windows.Forms.NumericUpDown valor_temp_ptt = this.Valor_temp_ptt;
			decimal num;
			num = new decimal(new int[]
			{
				10,
				0,
				0,
				0
			});
			valor_temp_ptt.Increment = num;
			global::System.Windows.Forms.Control valor_temp_ptt2 = this.Valor_temp_ptt;
valor_temp_ptt2.Location = new global::System.Drawing.Point(210, 87);
			global::System.Windows.Forms.NumericUpDown valor_temp_ptt3 = this.Valor_temp_ptt;
			num = new decimal(new int[]
			{
				200,
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
valor_end_mestre.Location = new global::System.Drawing.Point(210, 24);
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
valor_end_est.Location = new global::System.Drawing.Point(210, 54);
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
label_tempo_ptt.Location = new global::System.Drawing.Point(21, 89);
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
label_end_est.Location = new global::System.Drawing.Point(21, 56);
			this.Label_end_est.Name = "Label_end_est";
			global::System.Windows.Forms.Control label_end_est2 = this.Label_end_est;
			Size = new System.Drawing.Size(116, 13);
			label_end_est2.Size = this.Size;
			this.Label_end_est.TabIndex = 0;
			this.Label_end_est.Text = "Endereço da Estação :";
			this.Grupo_repetidora.Controls.Add(this.Valor_num_est_rep);
			this.Grupo_repetidora.Controls.Add(this.Valor_end_rep);
			this.Grupo_repetidora.Controls.Add(this.Grupo_end_rep);
			this.Grupo_repetidora.Controls.Add(this.CheckBox_hab_rep);
			this.Grupo_repetidora.Controls.Add(this.Label_num_est_rep);
			this.Grupo_repetidora.Controls.Add(this.Label_end_rep);
			global::System.Windows.Forms.Control grupo_repetidora = this.Grupo_repetidora;
grupo_repetidora.Location = new global::System.Drawing.Point(11, 159);
			this.Grupo_repetidora.Name = "Grupo_repetidora";
			global::System.Windows.Forms.Control grupo_repetidora2 = this.Grupo_repetidora;
			Size = new System.Drawing.Size(336, 312);
			grupo_repetidora2.Size = this.Size;
			this.Grupo_repetidora.TabIndex = 1;
			this.Grupo_repetidora.TabStop = false;
			this.Grupo_repetidora.Text = "Parâmetros da Repetidora";
			global::System.Windows.Forms.Control valor_num_est_rep = this.Valor_num_est_rep;
valor_num_est_rep.Location = new global::System.Drawing.Point(211, 114);
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
valor_end_rep.Location = new global::System.Drawing.Point(211, 88);
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
grupo_end_rep.Location = new global::System.Drawing.Point(16, 152);
			this.Grupo_end_rep.Name = "Grupo_end_rep";
			global::System.Windows.Forms.Control grupo_end_rep2 = this.Grupo_end_rep;
			Size = new System.Drawing.Size(309, 144);
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
checkBox_hab_rep.Location = new global::System.Drawing.Point(25, 46);
			this.CheckBox_hab_rep.Name = "CheckBox_hab_rep";
			global::System.Windows.Forms.Control checkBox_hab_rep2 = this.CheckBox_hab_rep;
			Size = new System.Drawing.Size(155, 17);
			checkBox_hab_rep2.Size = this.Size;
			this.CheckBox_hab_rep.TabIndex = 0;
			this.CheckBox_hab_rep.Text = "Habilita Função Repetidora";
			this.CheckBox_hab_rep.UseVisualStyleBackColor = true;
			this.Label_num_est_rep.AutoSize = true;
			global::System.Windows.Forms.Control label_num_est_rep = this.Label_num_est_rep;
label_num_est_rep.Location = new global::System.Drawing.Point(25, 116);
			this.Label_num_est_rep.Name = "Label_num_est_rep";
			global::System.Windows.Forms.Control label_num_est_rep2 = this.Label_num_est_rep;
			Size = new System.Drawing.Size(112, 13);
			label_num_est_rep2.Size = this.Size;
			this.Label_num_est_rep.TabIndex = 2;
			this.Label_num_est_rep.Text = "Número de Estações :";
			this.Label_end_rep.AutoSize = true;
			global::System.Windows.Forms.Control label_end_rep = this.Label_end_rep;
label_end_rep.Location = new global::System.Drawing.Point(25, 90);
			this.Label_end_rep.Name = "Label_end_rep";
			global::System.Windows.Forms.Control label_end_rep2 = this.Label_end_rep;
			Size = new System.Drawing.Size(129, 13);
			label_end_rep2.Size = this.Size;
			this.Label_end_rep.TabIndex = 1;
			this.Label_end_rep.Text = "Endereço da Repetidora :";
			this.Grupo_motores.Controls.Add(this.Tempo_entre_acionamentos);
			this.Grupo_motores.Controls.Add(this.Numero_motores);
			this.Grupo_motores.Controls.Add(this.Grupo_M3);
			this.Grupo_motores.Controls.Add(this.Grupo_M2);
			this.Grupo_motores.Controls.Add(this.Grupo_M1);
			this.Grupo_motores.Controls.Add(this.Label_tempo_entre_acionamentos);
			this.Grupo_motores.Controls.Add(this.Label_num_motores);
			global::System.Windows.Forms.Control grupo_motores = this.Grupo_motores;
grupo_motores.Location = new global::System.Drawing.Point(365, 12);
			this.Grupo_motores.Name = "Grupo_motores";
			global::System.Windows.Forms.Control grupo_motores2 = this.Grupo_motores;
			Size = new System.Drawing.Size(283, 592);
			grupo_motores2.Size = this.Size;
			this.Grupo_motores.TabIndex = 2;
			this.Grupo_motores.TabStop = false;
			this.Grupo_motores.Text = "Motores";
			global::System.Windows.Forms.Control tempo_entre_acionamentos = this.Tempo_entre_acionamentos;
tempo_entre_acionamentos.Location = new global::System.Drawing.Point(203, 54);
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
			Size = new System.Drawing.Size(60, 20);
			tempo_entre_acionamentos3.Size = this.Size;
			this.Tempo_entre_acionamentos.TabIndex = 9;
			this.Tempo_entre_acionamentos.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.Control numero_motores = this.Numero_motores;
numero_motores.Location = new global::System.Drawing.Point(217, 24);
			global::System.Windows.Forms.NumericUpDown numero_motores2 = this.Numero_motores;
			num = new decimal(new int[]
			{
				3,
				0,
				0,
				0
			});
			numero_motores2.Maximum = num;
			this.Numero_motores.Name = "Numero_motores";
			global::System.Windows.Forms.Control numero_motores3 = this.Numero_motores;
			Size = new System.Drawing.Size(46, 20);
			numero_motores3.Size = this.Size;
			this.Numero_motores.TabIndex = 8;
			this.Numero_motores.TextAlign = HorizontalAlignment.Right;
			this.Grupo_M3.Controls.Add(this.Tempo_parada_m3);
			this.Grupo_M3.Controls.Add(this.Tempo_partida_m3);
			this.Grupo_M3.Controls.Add(this.Nivel_partida_m3);
			this.Grupo_M3.Controls.Add(this.Nivel_parada_m3);
			this.Grupo_M3.Controls.Add(this.Label_tempo_parada_m3);
			this.Grupo_M3.Controls.Add(this.Label_tempo_partida_m3);
			this.Grupo_M3.Controls.Add(this.Label_nivel_parada_m3);
			this.Grupo_M3.Controls.Add(this.Label_nivel_acionamento_m3);
			this.Grupo_M3.Controls.Add(this.Combo_modo_partida_m3);
			this.Grupo_M3.Controls.Add(this.Label_modo_partida_m3);
			global::System.Windows.Forms.Control grupo_M = this.Grupo_M3;
grupo_M.Location = new global::System.Drawing.Point(24, 426);
			this.Grupo_M3.Name = "Grupo_M3";
			global::System.Windows.Forms.Control grupo_M2 = this.Grupo_M3;
			Size = new System.Drawing.Size(239, 154);
			grupo_M2.Size = this.Size;
			this.Grupo_M3.TabIndex = 5;
			this.Grupo_M3.TabStop = false;
			this.Grupo_M3.Text = "Motor 3";
			global::System.Windows.Forms.Control tempo_parada_m = this.Tempo_parada_m3;
tempo_parada_m.Location = new global::System.Drawing.Point(140, 124);
			global::System.Windows.Forms.NumericUpDown tempo_parada_m2 = this.Tempo_parada_m3;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_parada_m2.Maximum = num;
			this.Tempo_parada_m3.Name = "Tempo_parada_m3";
			global::System.Windows.Forms.Control tempo_parada_m3 = this.Tempo_parada_m3;
			Size = new System.Drawing.Size(74, 20);
			tempo_parada_m3.Size = this.Size;
			this.Tempo_parada_m3.TabIndex = 27;
			this.Tempo_parada_m3.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control tempo_partida_m = this.Tempo_partida_m3;
tempo_partida_m.Location = new global::System.Drawing.Point(140, 98);
			global::System.Windows.Forms.NumericUpDown tempo_partida_m2 = this.Tempo_partida_m3;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_partida_m2.Maximum = num;
			this.Tempo_partida_m3.Name = "Tempo_partida_m3";
			global::System.Windows.Forms.Control tempo_partida_m3 = this.Tempo_partida_m3;
			Size = new System.Drawing.Size(74, 20);
			tempo_partida_m3.Size = this.Size;
			this.Tempo_partida_m3.TabIndex = 26;
			this.Tempo_partida_m3.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nivel_partida_m = this.Nivel_partida_m3;
nivel_partida_m.Location = new global::System.Drawing.Point(140, 72);
			global::System.Windows.Forms.NumericUpDown nivel_partida_m2 = this.Nivel_partida_m3;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			nivel_partida_m2.Maximum = num;
			this.Nivel_partida_m3.Name = "Nivel_partida_m3";
			global::System.Windows.Forms.Control nivel_partida_m3 = this.Nivel_partida_m3;
			Size = new System.Drawing.Size(74, 20);
			nivel_partida_m3.Size = this.Size;
			this.Nivel_partida_m3.TabIndex = 25;
			this.Nivel_partida_m3.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nivel_parada_m = this.Nivel_parada_m3;
nivel_parada_m.Location = new global::System.Drawing.Point(140, 46);
			global::System.Windows.Forms.NumericUpDown nivel_parada_m2 = this.Nivel_parada_m3;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			nivel_parada_m2.Maximum = num;
			this.Nivel_parada_m3.Name = "Nivel_parada_m3";
			global::System.Windows.Forms.Control nivel_parada_m3 = this.Nivel_parada_m3;
			Size = new System.Drawing.Size(74, 20);
			nivel_parada_m3.Size = this.Size;
			this.Nivel_parada_m3.TabIndex = 24;
			this.Nivel_parada_m3.TextAlign = HorizontalAlignment.Center;
			this.Label_tempo_parada_m3.AutoSize = true;
			global::System.Windows.Forms.Control label_tempo_parada_m = this.Label_tempo_parada_m3;
label_tempo_parada_m.Location = new global::System.Drawing.Point(17, 126);
			this.Label_tempo_parada_m3.Name = "Label_tempo_parada_m3";
			global::System.Windows.Forms.Control label_tempo_parada_m2 = this.Label_tempo_parada_m3;
			Size = new System.Drawing.Size(111, 13);
			label_tempo_parada_m2.Size = this.Size;
			this.Label_tempo_parada_m3.TabIndex = 16;
			this.Label_tempo_parada_m3.Text = "Tempo parada (seg.) :";
			this.Label_tempo_partida_m3.AutoSize = true;
			global::System.Windows.Forms.Control label_tempo_partida_m = this.Label_tempo_partida_m3;
label_tempo_partida_m.Location = new global::System.Drawing.Point(17, 100);
			this.Label_tempo_partida_m3.Name = "Label_tempo_partida_m3";
			global::System.Windows.Forms.Control label_tempo_partida_m2 = this.Label_tempo_partida_m3;
			Size = new System.Drawing.Size(110, 13);
			label_tempo_partida_m2.Size = this.Size;
			this.Label_tempo_partida_m3.TabIndex = 14;
			this.Label_tempo_partida_m3.Text = "Tempo partida (seg.) :";
			this.Label_nivel_parada_m3.AutoSize = true;
			global::System.Windows.Forms.Control label_nivel_parada_m = this.Label_nivel_parada_m3;
label_nivel_parada_m.Location = new global::System.Drawing.Point(17, 48);
			this.Label_nivel_parada_m3.Name = "Label_nivel_parada_m3";
			global::System.Windows.Forms.Control label_nivel_parada_m2 = this.Label_nivel_parada_m3;
			Size = new System.Drawing.Size(92, 13);
			label_nivel_parada_m2.Size = this.Size;
			this.Label_nivel_parada_m3.TabIndex = 12;
			this.Label_nivel_parada_m3.Text = "Nível parada (%) :";
			this.Label_nivel_acionamento_m3.AutoSize = true;
			global::System.Windows.Forms.Control label_nivel_acionamento_m = this.Label_nivel_acionamento_m3;
label_nivel_acionamento_m.Location = new global::System.Drawing.Point(17, 74);
			this.Label_nivel_acionamento_m3.Name = "Label_nivel_acionamento_m3";
			global::System.Windows.Forms.Control label_nivel_acionamento_m2 = this.Label_nivel_acionamento_m3;
			Size = new System.Drawing.Size(120, 13);
			label_nivel_acionamento_m2.Size = this.Size;
			this.Label_nivel_acionamento_m3.TabIndex = 10;
			this.Label_nivel_acionamento_m3.Text = "Nível acionamento (%) :";
			this.Combo_modo_partida_m3.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_modo_partida_m = this.Combo_modo_partida_m3;
combo_modo_partida_m.Location = new global::System.Drawing.Point(127, 19);
			this.Combo_modo_partida_m3.Name = "Combo_modo_partida_m3";
			global::System.Windows.Forms.Control combo_modo_partida_m2 = this.Combo_modo_partida_m3;
			Size = new System.Drawing.Size(87, 21);
			combo_modo_partida_m2.Size = this.Size;
			this.Combo_modo_partida_m3.TabIndex = 0;
			this.Label_modo_partida_m3.AutoSize = true;
			global::System.Windows.Forms.Control label_modo_partida_m = this.Label_modo_partida_m3;
label_modo_partida_m.Location = new global::System.Drawing.Point(17, 22);
			this.Label_modo_partida_m3.Name = "Label_modo_partida_m3";
			global::System.Windows.Forms.Control label_modo_partida_m2 = this.Label_modo_partida_m3;
			Size = new System.Drawing.Size(90, 13);
			label_modo_partida_m2.Size = this.Size;
			this.Label_modo_partida_m3.TabIndex = 8;
			this.Label_modo_partida_m3.Text = "Modo de partida :";
			this.Grupo_M2.Controls.Add(this.Tempo_parada_m2);
			this.Grupo_M2.Controls.Add(this.Tempo_partida_m2);
			this.Grupo_M2.Controls.Add(this.Nivel_partida_m2);
			this.Grupo_M2.Controls.Add(this.Nivel_parada_m2);
			this.Grupo_M2.Controls.Add(this.Label_tempo_parada_m2);
			this.Grupo_M2.Controls.Add(this.Label_tempo_partida_m2);
			this.Grupo_M2.Controls.Add(this.Label_nivel_parada_m2);
			this.Grupo_M2.Controls.Add(this.Label_nivel_acionamento_m2);
			this.Grupo_M2.Controls.Add(this.Combo_modo_partida_m2);
			this.Grupo_M2.Controls.Add(this.Label_modo_partida_m2);
			global::System.Windows.Forms.Control grupo_M3 = this.Grupo_M2;
grupo_M3.Location = new global::System.Drawing.Point(24, 257);
			this.Grupo_M2.Name = "Grupo_M2";
			global::System.Windows.Forms.Control grupo_M4 = this.Grupo_M2;
			Size = new System.Drawing.Size(239, 154);
			grupo_M4.Size = this.Size;
			this.Grupo_M2.TabIndex = 4;
			this.Grupo_M2.TabStop = false;
			this.Grupo_M2.Text = "Motor 2";
			global::System.Windows.Forms.Control tempo_parada_m4 = this.Tempo_parada_m2;
tempo_parada_m4.Location = new global::System.Drawing.Point(140, 124);
			global::System.Windows.Forms.NumericUpDown tempo_parada_m5 = this.Tempo_parada_m2;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_parada_m5.Maximum = num;
			this.Tempo_parada_m2.Name = "Tempo_parada_m2";
			global::System.Windows.Forms.Control tempo_parada_m6 = this.Tempo_parada_m2;
			Size = new System.Drawing.Size(74, 20);
			tempo_parada_m6.Size = this.Size;
			this.Tempo_parada_m2.TabIndex = 23;
			this.Tempo_parada_m2.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control tempo_partida_m4 = this.Tempo_partida_m2;
tempo_partida_m4.Location = new global::System.Drawing.Point(140, 98);
			global::System.Windows.Forms.NumericUpDown tempo_partida_m5 = this.Tempo_partida_m2;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_partida_m5.Maximum = num;
			this.Tempo_partida_m2.Name = "Tempo_partida_m2";
			global::System.Windows.Forms.Control tempo_partida_m6 = this.Tempo_partida_m2;
			Size = new System.Drawing.Size(74, 20);
			tempo_partida_m6.Size = this.Size;
			this.Tempo_partida_m2.TabIndex = 22;
			this.Tempo_partida_m2.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nivel_partida_m4 = this.Nivel_partida_m2;
nivel_partida_m4.Location = new global::System.Drawing.Point(140, 72);
			global::System.Windows.Forms.NumericUpDown nivel_partida_m5 = this.Nivel_partida_m2;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			nivel_partida_m5.Maximum = num;
			this.Nivel_partida_m2.Name = "Nivel_partida_m2";
			global::System.Windows.Forms.Control nivel_partida_m6 = this.Nivel_partida_m2;
			Size = new System.Drawing.Size(74, 20);
			nivel_partida_m6.Size = this.Size;
			this.Nivel_partida_m2.TabIndex = 21;
			this.Nivel_partida_m2.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nivel_parada_m4 = this.Nivel_parada_m2;
nivel_parada_m4.Location = new global::System.Drawing.Point(140, 46);
			global::System.Windows.Forms.NumericUpDown nivel_parada_m5 = this.Nivel_parada_m2;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			nivel_parada_m5.Maximum = num;
			this.Nivel_parada_m2.Name = "Nivel_parada_m2";
			global::System.Windows.Forms.Control nivel_parada_m6 = this.Nivel_parada_m2;
			Size = new System.Drawing.Size(74, 20);
			nivel_parada_m6.Size = this.Size;
			this.Nivel_parada_m2.TabIndex = 20;
			this.Nivel_parada_m2.TextAlign = HorizontalAlignment.Center;
			this.Label_tempo_parada_m2.AutoSize = true;
			global::System.Windows.Forms.Control label_tempo_parada_m3 = this.Label_tempo_parada_m2;
label_tempo_parada_m3.Location = new global::System.Drawing.Point(17, 126);
			this.Label_tempo_parada_m2.Name = "Label_tempo_parada_m2";
			global::System.Windows.Forms.Control label_tempo_parada_m4 = this.Label_tempo_parada_m2;
			Size = new System.Drawing.Size(111, 13);
			label_tempo_parada_m4.Size = this.Size;
			this.Label_tempo_parada_m2.TabIndex = 16;
			this.Label_tempo_parada_m2.Text = "Tempo parada (seg.) :";
			this.Label_tempo_partida_m2.AutoSize = true;
			global::System.Windows.Forms.Control label_tempo_partida_m3 = this.Label_tempo_partida_m2;
label_tempo_partida_m3.Location = new global::System.Drawing.Point(17, 100);
			this.Label_tempo_partida_m2.Name = "Label_tempo_partida_m2";
			global::System.Windows.Forms.Control label_tempo_partida_m4 = this.Label_tempo_partida_m2;
			Size = new System.Drawing.Size(110, 13);
			label_tempo_partida_m4.Size = this.Size;
			this.Label_tempo_partida_m2.TabIndex = 14;
			this.Label_tempo_partida_m2.Text = "Tempo partida (seg.) :";
			this.Label_nivel_parada_m2.AutoSize = true;
			global::System.Windows.Forms.Control label_nivel_parada_m3 = this.Label_nivel_parada_m2;
label_nivel_parada_m3.Location = new global::System.Drawing.Point(17, 48);
			this.Label_nivel_parada_m2.Name = "Label_nivel_parada_m2";
			global::System.Windows.Forms.Control label_nivel_parada_m4 = this.Label_nivel_parada_m2;
			Size = new System.Drawing.Size(92, 13);
			label_nivel_parada_m4.Size = this.Size;
			this.Label_nivel_parada_m2.TabIndex = 12;
			this.Label_nivel_parada_m2.Text = "Nível parada (%) :";
			this.Label_nivel_acionamento_m2.AutoSize = true;
			global::System.Windows.Forms.Control label_nivel_acionamento_m3 = this.Label_nivel_acionamento_m2;
label_nivel_acionamento_m3.Location = new global::System.Drawing.Point(17, 74);
			this.Label_nivel_acionamento_m2.Name = "Label_nivel_acionamento_m2";
			global::System.Windows.Forms.Control label_nivel_acionamento_m4 = this.Label_nivel_acionamento_m2;
			Size = new System.Drawing.Size(120, 13);
			label_nivel_acionamento_m4.Size = this.Size;
			this.Label_nivel_acionamento_m2.TabIndex = 10;
			this.Label_nivel_acionamento_m2.Text = "Nível acionamento (%) :";
			this.Combo_modo_partida_m2.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_modo_partida_m3 = this.Combo_modo_partida_m2;
combo_modo_partida_m3.Location = new global::System.Drawing.Point(127, 22);
			this.Combo_modo_partida_m2.Name = "Combo_modo_partida_m2";
			global::System.Windows.Forms.Control combo_modo_partida_m4 = this.Combo_modo_partida_m2;
			Size = new System.Drawing.Size(87, 21);
			combo_modo_partida_m4.Size = this.Size;
			this.Combo_modo_partida_m2.TabIndex = 0;
			this.Label_modo_partida_m2.AutoSize = true;
			global::System.Windows.Forms.Control label_modo_partida_m3 = this.Label_modo_partida_m2;
label_modo_partida_m3.Location = new global::System.Drawing.Point(17, 22);
			this.Label_modo_partida_m2.Name = "Label_modo_partida_m2";
			global::System.Windows.Forms.Control label_modo_partida_m4 = this.Label_modo_partida_m2;
			Size = new System.Drawing.Size(90, 13);
			label_modo_partida_m4.Size = this.Size;
			this.Label_modo_partida_m2.TabIndex = 8;
			this.Label_modo_partida_m2.Text = "Modo de partida :";
			this.Grupo_M1.Controls.Add(this.Tempo_parada_m1);
			this.Grupo_M1.Controls.Add(this.Tempo_partida_m1);
			this.Grupo_M1.Controls.Add(this.Nivel_partida_m1);
			this.Grupo_M1.Controls.Add(this.Nivel_parada_m1);
			this.Grupo_M1.Controls.Add(this.Label_tempo_parada_m1);
			this.Grupo_M1.Controls.Add(this.Label_tempo_partida_m1);
			this.Grupo_M1.Controls.Add(this.Label_nivel_parada_m1);
			this.Grupo_M1.Controls.Add(this.Label_nivel_acionamento_m1);
			this.Grupo_M1.Controls.Add(this.Combo_modo_partida_m1);
			this.Grupo_M1.Controls.Add(this.Label_modo_partida_m1);
			global::System.Windows.Forms.Control grupo_M5 = this.Grupo_M1;
grupo_M5.Location = new global::System.Drawing.Point(24, 86);
			this.Grupo_M1.Name = "Grupo_M1";
			global::System.Windows.Forms.Control grupo_M6 = this.Grupo_M1;
			Size = new System.Drawing.Size(239, 154);
			grupo_M6.Size = this.Size;
			this.Grupo_M1.TabIndex = 3;
			this.Grupo_M1.TabStop = false;
			this.Grupo_M1.Text = "Motor 1";
			global::System.Windows.Forms.Control tempo_parada_m7 = this.Tempo_parada_m1;
tempo_parada_m7.Location = new global::System.Drawing.Point(140, 124);
			global::System.Windows.Forms.NumericUpDown tempo_parada_m8 = this.Tempo_parada_m1;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_parada_m8.Maximum = num;
			this.Tempo_parada_m1.Name = "Tempo_parada_m1";
			global::System.Windows.Forms.Control tempo_parada_m9 = this.Tempo_parada_m1;
			Size = new System.Drawing.Size(74, 20);
			tempo_parada_m9.Size = this.Size;
			this.Tempo_parada_m1.TabIndex = 19;
			this.Tempo_parada_m1.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control tempo_partida_m7 = this.Tempo_partida_m1;
tempo_partida_m7.Location = new global::System.Drawing.Point(140, 98);
			global::System.Windows.Forms.NumericUpDown tempo_partida_m8 = this.Tempo_partida_m1;
			num = new decimal(new int[]
			{
				32000,
				0,
				0,
				0
			});
			tempo_partida_m8.Maximum = num;
			this.Tempo_partida_m1.Name = "Tempo_partida_m1";
			global::System.Windows.Forms.Control tempo_partida_m9 = this.Tempo_partida_m1;
			Size = new System.Drawing.Size(74, 20);
			tempo_partida_m9.Size = this.Size;
			this.Tempo_partida_m1.TabIndex = 18;
			this.Tempo_partida_m1.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nivel_partida_m7 = this.Nivel_partida_m1;
nivel_partida_m7.Location = new global::System.Drawing.Point(140, 72);
			global::System.Windows.Forms.NumericUpDown nivel_partida_m8 = this.Nivel_partida_m1;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			nivel_partida_m8.Maximum = num;
			this.Nivel_partida_m1.Name = "Nivel_partida_m1";
			global::System.Windows.Forms.Control nivel_partida_m9 = this.Nivel_partida_m1;
			Size = new System.Drawing.Size(74, 20);
			nivel_partida_m9.Size = this.Size;
			this.Nivel_partida_m1.TabIndex = 17;
			this.Nivel_partida_m1.TextAlign = HorizontalAlignment.Center;
			global::System.Windows.Forms.Control nivel_parada_m7 = this.Nivel_parada_m1;
nivel_parada_m7.Location = new global::System.Drawing.Point(140, 46);
			global::System.Windows.Forms.NumericUpDown nivel_parada_m8 = this.Nivel_parada_m1;
			num = new decimal(new int[]
			{
				4000,
				0,
				0,
				0
			});
			nivel_parada_m8.Maximum = num;
			this.Nivel_parada_m1.Name = "Nivel_parada_m1";
			global::System.Windows.Forms.Control nivel_parada_m9 = this.Nivel_parada_m1;
			Size = new System.Drawing.Size(74, 20);
			nivel_parada_m9.Size = this.Size;
			this.Nivel_parada_m1.TabIndex = 10;
			this.Nivel_parada_m1.TextAlign = HorizontalAlignment.Center;
			this.Label_tempo_parada_m1.AutoSize = true;
			global::System.Windows.Forms.Control label_tempo_parada_m5 = this.Label_tempo_parada_m1;
label_tempo_parada_m5.Location = new global::System.Drawing.Point(17, 126);
			this.Label_tempo_parada_m1.Name = "Label_tempo_parada_m1";
			global::System.Windows.Forms.Control label_tempo_parada_m6 = this.Label_tempo_parada_m1;
			Size = new System.Drawing.Size(111, 13);
			label_tempo_parada_m6.Size = this.Size;
			this.Label_tempo_parada_m1.TabIndex = 16;
			this.Label_tempo_parada_m1.Text = "Tempo parada (seg.) :";
			this.Label_tempo_partida_m1.AutoSize = true;
			global::System.Windows.Forms.Control label_tempo_partida_m5 = this.Label_tempo_partida_m1;
label_tempo_partida_m5.Location = new global::System.Drawing.Point(17, 100);
			this.Label_tempo_partida_m1.Name = "Label_tempo_partida_m1";
			global::System.Windows.Forms.Control label_tempo_partida_m6 = this.Label_tempo_partida_m1;
			Size = new System.Drawing.Size(110, 13);
			label_tempo_partida_m6.Size = this.Size;
			this.Label_tempo_partida_m1.TabIndex = 14;
			this.Label_tempo_partida_m1.Text = "Tempo partida (seg.) :";
			this.Label_nivel_parada_m1.AutoSize = true;
			global::System.Windows.Forms.Control label_nivel_parada_m5 = this.Label_nivel_parada_m1;
label_nivel_parada_m5.Location = new global::System.Drawing.Point(17, 48);
			this.Label_nivel_parada_m1.Name = "Label_nivel_parada_m1";
			global::System.Windows.Forms.Control label_nivel_parada_m6 = this.Label_nivel_parada_m1;
			Size = new System.Drawing.Size(92, 13);
			label_nivel_parada_m6.Size = this.Size;
			this.Label_nivel_parada_m1.TabIndex = 12;
			this.Label_nivel_parada_m1.Text = "Nível parada (%) :";
			this.Label_nivel_acionamento_m1.AutoSize = true;
			global::System.Windows.Forms.Control label_nivel_acionamento_m5 = this.Label_nivel_acionamento_m1;
label_nivel_acionamento_m5.Location = new global::System.Drawing.Point(17, 74);
			this.Label_nivel_acionamento_m1.Name = "Label_nivel_acionamento_m1";
			global::System.Windows.Forms.Control label_nivel_acionamento_m6 = this.Label_nivel_acionamento_m1;
			Size = new System.Drawing.Size(120, 13);
			label_nivel_acionamento_m6.Size = this.Size;
			this.Label_nivel_acionamento_m1.TabIndex = 10;
			this.Label_nivel_acionamento_m1.Text = "Nível acionamento (%) :";
			this.Combo_modo_partida_m1.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_modo_partida_m5 = this.Combo_modo_partida_m1;
combo_modo_partida_m5.Location = new global::System.Drawing.Point(127, 19);
			this.Combo_modo_partida_m1.Name = "Combo_modo_partida_m1";
			global::System.Windows.Forms.Control combo_modo_partida_m6 = this.Combo_modo_partida_m1;
			Size = new System.Drawing.Size(87, 21);
			combo_modo_partida_m6.Size = this.Size;
			this.Combo_modo_partida_m1.TabIndex = 0;
			this.Label_modo_partida_m1.AutoSize = true;
			global::System.Windows.Forms.Control label_modo_partida_m5 = this.Label_modo_partida_m1;
label_modo_partida_m5.Location = new global::System.Drawing.Point(17, 22);
			this.Label_modo_partida_m1.Name = "Label_modo_partida_m1";
			global::System.Windows.Forms.Control label_modo_partida_m6 = this.Label_modo_partida_m1;
			Size = new System.Drawing.Size(90, 13);
			label_modo_partida_m6.Size = this.Size;
			this.Label_modo_partida_m1.TabIndex = 8;
			this.Label_modo_partida_m1.Text = "Modo de partida :";
			this.Label_tempo_entre_acionamentos.AutoSize = true;
			global::System.Windows.Forms.Control label_tempo_entre_acionamentos = this.Label_tempo_entre_acionamentos;
label_tempo_entre_acionamentos.Location = new global::System.Drawing.Point(41, 56);
			this.Label_tempo_entre_acionamentos.Name = "Label_tempo_entre_acionamentos";
			global::System.Windows.Forms.Control label_tempo_entre_acionamentos2 = this.Label_tempo_entre_acionamentos;
			Size = new System.Drawing.Size(154, 13);
			label_tempo_entre_acionamentos2.Size = this.Size;
			this.Label_tempo_entre_acionamentos.TabIndex = 5;
			this.Label_tempo_entre_acionamentos.Text = "Tempo entre operações (min.) :";
			this.Label_num_motores.AutoSize = true;
			global::System.Windows.Forms.Control label_num_motores = this.Label_num_motores;
label_num_motores.Location = new global::System.Drawing.Point(41, 26);
			this.Label_num_motores.Name = "Label_num_motores";
			global::System.Windows.Forms.Control label_num_motores2 = this.Label_num_motores;
			Size = new System.Drawing.Size(105, 13);
			label_num_motores2.Size = this.Size;
			this.Label_num_motores.TabIndex = 5;
			this.Label_num_motores.Text = "Número de motores :";
			this.Grupo_ctrl.Controls.Add(this.Esc_conf_md_201);
			this.Grupo_ctrl.Controls.Add(this.Box_Msg);
			this.Grupo_ctrl.Controls.Add(this.Ler_conf_md_201);
			global::System.Windows.Forms.Control grupo_ctrl = this.Grupo_ctrl;
grupo_ctrl.Location = new global::System.Drawing.Point(12, 493);
			this.Grupo_ctrl.Name = "Grupo_ctrl";
			global::System.Windows.Forms.Control grupo_ctrl2 = this.Grupo_ctrl;
			Size = new System.Drawing.Size(335, 105);
			grupo_ctrl2.Size = this.Size;
			this.Grupo_ctrl.TabIndex = 3;
			this.Grupo_ctrl.TabStop = false;
			this.Grupo_ctrl.Text = "Comandos e Status";
			global::System.Windows.Forms.Control esc_conf_md_ = this.Esc_conf_md_201;
esc_conf_md_.Location = new global::System.Drawing.Point(194, 61);
			this.Esc_conf_md_201.Name = "Esc_conf_md_201";
			global::System.Windows.Forms.Control esc_conf_md_2 = this.Esc_conf_md_201;
			Size = new System.Drawing.Size(109, 28);
			esc_conf_md_2.Size = this.Size;
			this.Esc_conf_md_201.TabIndex = 1;
			this.Esc_conf_md_201.Text = "Salvar config.";
			this.Esc_conf_md_201.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control box_Msg = this.Box_Msg;
box_Msg.Location = new global::System.Drawing.Point(24, 29);
			this.Box_Msg.Name = "Box_Msg";
			global::System.Windows.Forms.Control box_Msg2 = this.Box_Msg;
			Size = new System.Drawing.Size(293, 20);
			box_Msg2.Size = this.Size;
			this.Box_Msg.TabIndex = 2;
			this.Box_Msg.TextAlign = HorizontalAlignment.Right;
			global::System.Windows.Forms.Control ler_conf_md_ = this.Ler_conf_md_201;
ler_conf_md_.Location = new global::System.Drawing.Point(41, 61);
			this.Ler_conf_md_201.Name = "Ler_conf_md_201";
			global::System.Windows.Forms.Control ler_conf_md_2 = this.Ler_conf_md_201;
			Size = new System.Drawing.Size(109, 28);
			ler_conf_md_2.Size = this.Size;
			this.Ler_conf_md_201.TabIndex = 0;
			this.Ler_conf_md_201.Text = "Ler configuração";
			this.Ler_conf_md_201.UseVisualStyleBackColor = true;
			this.MenuStrip1.Dock =(System.Windows.Forms.DockStyle)2;
			this.MenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ArquivoToolStripMenuItem
			});
			global::System.Windows.Forms.Control menuStrip = this.MenuStrip1;
menuStrip.Location = new global::System.Drawing.Point(0, 598);
			this.MenuStrip1.Name = "MenuStrip1";
			global::System.Windows.Forms.Control menuStrip2 = this.MenuStrip1;
			Size = new System.Drawing.Size(663, 24);
			menuStrip2.Size = this.Size;
			this.MenuStrip1.TabIndex = 4;
			this.MenuStrip1.Text = "MenuStrip1";
			this.ArquivoToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.SalvarToolStripMenuItem,
				this.AbrirToolStripMenuItem,
				this.NovoToolStripMenuItem
			});
			this.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem arquivoToolStripMenuItem = this.ArquivoToolStripMenuItem;
			Size = new System.Drawing.Size(61, 20);
			arquivoToolStripMenuItem.Size = this.Size;
			this.ArquivoToolStripMenuItem.Text = "Arquivo";
			this.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem salvarToolStripMenuItem = this.SalvarToolStripMenuItem;
			Size = new System.Drawing.Size(105, 22);
			salvarToolStripMenuItem.Size = this.Size;
			this.SalvarToolStripMenuItem.Text = "Novo";
			this.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem abrirToolStripMenuItem = this.AbrirToolStripMenuItem;
			Size = new System.Drawing.Size(105, 22);
			abrirToolStripMenuItem.Size = this.Size;
			this.AbrirToolStripMenuItem.Text = "Abrir";
			this.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem novoToolStripMenuItem = this.NovoToolStripMenuItem;
			Size = new System.Drawing.Size(105, 22);
			novoToolStripMenuItem.Size = this.Size;
			this.NovoToolStripMenuItem.Text = "Salvar";
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			global::System.Drawing.SizeF autoScaleDimensions;
			autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			Size = new System.Drawing.Size(916, 717);
			this.ClientSize = Size;
			this.Controls.Add(this.Grupo_ctrl);
			this.Controls.Add(this.Grupo_motores);
			this.Controls.Add(this.Grupo_repetidora);
			this.Controls.Add(this.grupo_comunicacao);
			this.Controls.Add(this.MenuStrip1);
			this.Controls.Add(this.TabControl1);
			this.TabControl1.Controls.Add(this.TabPage_vazao_calhas);
			this.TabControl1.Controls.Add(this.TabPage_perifericos);
			global::System.Windows.Forms.Control tabControl1 = this.TabControl1;
			tabControl1.Location = new global::System.Drawing.Point(12, 400);
			this.TabControl1.Name = "TabControl1";
			global::System.Windows.Forms.Control tabControl12 = this.TabControl1;
			Size = new System.Drawing.Size(892, 300);
			tabControl12.Size = this.Size;
			this.TabControl1.TabIndex = 30;
			this.TabPage_vazao_calhas.Controls.Add(this.GroupBox_vazoes_820);
			this.TabPage_vazao_calhas.Controls.Add(this.GroupBox_calhas);
			global::System.Windows.Forms.TabPage tabPage_vazao_calhas = this.TabPage_vazao_calhas;
			tabPage_vazao_calhas.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_vazao_calhas.Name = "TabPage_vazao_calhas";
			global::System.Windows.Forms.Control tabPage_vazao_calhas2 = this.TabPage_vazao_calhas;
			Padding = new Padding(3);
			tabPage_vazao_calhas2.Padding = Padding;
			global::System.Windows.Forms.Control tabPage_vazao_calhas3 = this.TabPage_vazao_calhas;
			Size = new System.Drawing.Size(884, 274);
			tabPage_vazao_calhas3.Size = this.Size;
			this.TabPage_vazao_calhas.TabIndex = 0;
			this.TabPage_vazao_calhas.Text = "Vazão & Calhas";
			this.TabPage_vazao_calhas.UseVisualStyleBackColor = true;
			this.TabPage_perifericos.Controls.Add(this.Grupo_perifericos);
			global::System.Windows.Forms.TabPage tabPage_perifericos = this.TabPage_perifericos;
			tabPage_perifericos.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_perifericos.Name = "TabPage_perifericos";
			global::System.Windows.Forms.Control tabPage_perifericos2 = this.TabPage_perifericos;
			Padding = new Padding(3);
			tabPage_perifericos2.Padding = Padding;
			global::System.Windows.Forms.Control tabPage_perifericos3 = this.TabPage_perifericos;
			Size = new System.Drawing.Size(884, 274);
			tabPage_perifericos3.Size = this.Size;
			this.TabPage_perifericos.TabIndex = 1;
			this.TabPage_perifericos.Text = "Periféricos";
			this.TabPage_perifericos.UseVisualStyleBackColor = true;
			this.GroupBox_vazoes_820.Controls.Add(this.DataGridView_vazoes_RT820);
			global::System.Windows.Forms.Control groupBox_vazoes_820 = this.GroupBox_vazoes_820;
			groupBox_vazoes_820.Location = new global::System.Drawing.Point(6, 6);
			this.GroupBox_vazoes_820.Name = "GroupBox_vazoes_820";
			global::System.Windows.Forms.Control groupBox_vazoes_8202 = this.GroupBox_vazoes_820;
			Size = new System.Drawing.Size(400, 260);
			groupBox_vazoes_8202.Size = this.Size;
			this.GroupBox_vazoes_820.TabIndex = 0;
			this.GroupBox_vazoes_820.TabStop = false;
			this.GroupBox_vazoes_820.Text = "Vazões";
			global::System.Windows.Forms.Control dataGridView_vazoes_RT820 = this.DataGridView_vazoes_RT820;
			dataGridView_vazoes_RT820.Location = new global::System.Drawing.Point(6, 19);
			this.DataGridView_vazoes_RT820.Name = "DataGridView_vazoes_RT820";
			global::System.Windows.Forms.Control dataGridView_vazoes_RT8202 = this.DataGridView_vazoes_RT820;
			Size = new System.Drawing.Size(388, 235);
			dataGridView_vazoes_RT8202.Size = this.Size;
			this.DataGridView_vazoes_RT820.TabIndex = 0;
			this.GroupBox_calhas.Controls.Add(this.DataGridView_calhas_RT820);
			global::System.Windows.Forms.Control groupBox_calhas = this.GroupBox_calhas;
			groupBox_calhas.Location = new global::System.Drawing.Point(412, 6);
			this.GroupBox_calhas.Name = "GroupBox_calhas";
			global::System.Windows.Forms.Control groupBox_calhas2 = this.GroupBox_calhas;
			Size = new System.Drawing.Size(466, 260);
			groupBox_calhas2.Size = this.Size;
			this.GroupBox_calhas.TabIndex = 1;
			this.GroupBox_calhas.TabStop = false;
			this.GroupBox_calhas.Text = "Calhas";
			global::System.Windows.Forms.Control dataGridView_calhas_RT820 = this.DataGridView_calhas_RT820;
			dataGridView_calhas_RT820.Location = new global::System.Drawing.Point(6, 19);
			this.DataGridView_calhas_RT820.Name = "DataGridView_calhas_RT820";
			global::System.Windows.Forms.Control dataGridView_calhas_RT8202 = this.DataGridView_calhas_RT820;
			Size = new System.Drawing.Size(454, 235);
			dataGridView_calhas_RT8202.Size = this.Size;
			this.DataGridView_calhas_RT820.TabIndex = 0;
			this.FormBorderStyle = FormBorderStyle.None;
this.Location = new global::System.Drawing.Point(160, 2);
			this.Name = "Equip_201_conf";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Equipamento MD 201 - Configuração";
			this.grupo_comunicacao.ResumeLayout(false);
			this.grupo_comunicacao.PerformLayout();
			
			
			
			this.Grupo_repetidora.ResumeLayout(false);
			this.Grupo_repetidora.PerformLayout();
			
			
			this.Grupo_end_rep.ResumeLayout(false);
			this.Grupo_end_rep.PerformLayout();
			this.Grupo_motores.ResumeLayout(false);
			this.Grupo_motores.PerformLayout();
			
			
			this.Grupo_M3.ResumeLayout(false);
			this.Grupo_M3.PerformLayout();
			
			
			
			
			this.Grupo_M2.ResumeLayout(false);
			this.Grupo_M2.PerformLayout();
			
			
			
			
			this.Grupo_M1.ResumeLayout(false);
			this.Grupo_M1.PerformLayout();
			
			
			
			
			this.Grupo_ctrl.ResumeLayout(false);
			this.Grupo_ctrl.PerformLayout();
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400152C RID: 5420
		private global::System.Windows.Forms.TabControl TabControl1;
		private global::System.Windows.Forms.TabPage TabPage_vazao_calhas;
		private global::System.Windows.Forms.TabPage TabPage_perifericos;
		private global::System.Windows.Forms.GroupBox GroupBox_vazoes_820;
		private global::System.Windows.Forms.DataGridView DataGridView_vazoes_RT820;
		private global::System.Windows.Forms.GroupBox GroupBox_calhas;
		private global::System.Windows.Forms.DataGridView DataGridView_calhas_RT820;
		private global::System.Windows.Forms.GroupBox Grupo_perifericos;
		private global::System.Windows.Forms.Label Label_periferico_4;
		private global::System.Windows.Forms.Label Label_periferico_3;
		private global::System.Windows.Forms.Label Label_nota_2;
		private global::System.Windows.Forms.Label Label_periferico_2;
		private global::System.Windows.Forms.Label Label_nota_1;
		private global::System.Windows.Forms.Label Label_periferico_1;
		private global::System.Windows.Forms.NumericUpDown Endereco_p4;
		private global::System.Windows.Forms.NumericUpDown Endereco_p2;
		private global::System.Windows.Forms.NumericUpDown Endereco_p3;
		private global::System.Windows.Forms.NumericUpDown Endereco_p1;
		private global::System.Windows.Forms.ComboBox Combo_tipo_p4;
		private global::System.Windows.Forms.ComboBox Combo_tipo_p2;
		private global::System.Windows.Forms.ComboBox Combo_tipo_p3;
		private global::System.Windows.Forms.ComboBox Combo_tipo_p1;

		private global::System.ComponentModel.IContainer components;
	}
}
