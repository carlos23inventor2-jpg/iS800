namespace iS800
{
	// Token: 0x02000011 RID: 17
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Configuracao : global::System.Windows.Forms.Form
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00263788 File Offset: 0x00261B88
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x002637A8 File Offset: 0x00261BA8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::iS800.Configuracao));
			this.Grupo_com = new global::System.Windows.Forms.GroupBox();
			this.Combo_paridade = new global::System.Windows.Forms.ComboBox();
			this.Label_paridade = new global::System.Windows.Forms.Label();
			this.Combo_stop_bits = new global::System.Windows.Forms.ComboBox();
			this.Label_stop_bits = new global::System.Windows.Forms.Label();
			this.ComboNumeroBits = new global::System.Windows.Forms.ComboBox();
			this.Label_bits = new global::System.Windows.Forms.Label();
			this.ComboBaudrate = new global::System.Windows.Forms.ComboBox();
			this.Label_baudrate = new global::System.Windows.Forms.Label();
			this.Label_porta = new global::System.Windows.Forms.Label();
			this.ComboPortaSerial = new global::System.Windows.Forms.ComboBox();
			this.OK_Button = new global::System.Windows.Forms.Button();
			this.GroupBox_gerais = new global::System.Windows.Forms.GroupBox();
			this.NumericUpDown_retry = new global::System.Windows.Forms.NumericUpDown();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.tb_tcpip_Porta = new global::System.Windows.Forms.TextBox();
			this.tb_tcpip_IP = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.cb_tipo_interface = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Grupo_com.SuspendLayout();
			this.GroupBox_gerais.SuspendLayout();
			this.NumericUpDown_retry.BeginInit();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.SuspendLayout();
			this.Grupo_com.Controls.Add(this.Combo_paridade);
			this.Grupo_com.Controls.Add(this.Label_paridade);
			this.Grupo_com.Controls.Add(this.Combo_stop_bits);
			this.Grupo_com.Controls.Add(this.Label_stop_bits);
			this.Grupo_com.Controls.Add(this.ComboNumeroBits);
			this.Grupo_com.Controls.Add(this.Label_bits);
			this.Grupo_com.Controls.Add(this.ComboBaudrate);
			this.Grupo_com.Controls.Add(this.Label_baudrate);
			this.Grupo_com.Controls.Add(this.Label_porta);
			this.Grupo_com.Controls.Add(this.ComboPortaSerial);
			global::System.Windows.Forms.Control grupo_com = this.Grupo_com;
			global::System.Drawing.Point location;
			location = new global::System.Drawing.Point(12, 74);
			grupo_com.Location = location;
			this.Grupo_com.Name = "Grupo_com";
			global::System.Windows.Forms.Control grupo_com2 = this.Grupo_com;
			global::System.Drawing.Size size;
			size = new global::System.Drawing.Size(223, 190);
			grupo_com2.Size = size;
			this.Grupo_com.TabIndex = 4;
			this.Grupo_com.TabStop = false;
			this.Grupo_com.Text = "Interface Serial - RS232:";
			this.Combo_paridade.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_paridade = this.Combo_paridade;
			location = new global::System.Drawing.Point(90, 147);
			combo_paridade.Location = location;
			this.Combo_paridade.Name = "Combo_paridade";
			global::System.Windows.Forms.Control combo_paridade2 = this.Combo_paridade;
			size = new global::System.Drawing.Size(112, 21);
			combo_paridade2.Size = size;
			this.Combo_paridade.TabIndex = 10;
			this.Label_paridade.AutoSize = true;
			global::System.Windows.Forms.Control label_paridade = this.Label_paridade;
			location = new global::System.Drawing.Point(18, 150);
			label_paridade.Location = location;
			this.Label_paridade.Name = "Label_paridade";
			global::System.Windows.Forms.Control label_paridade2 = this.Label_paridade;
			size = new global::System.Drawing.Size(55, 13);
			label_paridade2.Size = size;
			this.Label_paridade.TabIndex = 9;
			this.Label_paridade.Text = "Paridade :";
			this.Combo_stop_bits.FormattingEnabled = true;
			global::System.Windows.Forms.Control combo_stop_bits = this.Combo_stop_bits;
			location = new global::System.Drawing.Point(138, 115);
			combo_stop_bits.Location = location;
			this.Combo_stop_bits.Name = "Combo_stop_bits";
			global::System.Windows.Forms.Control combo_stop_bits2 = this.Combo_stop_bits;
			size = new global::System.Drawing.Size(64, 21);
			combo_stop_bits2.Size = size;
			this.Combo_stop_bits.TabIndex = 8;
			this.Label_stop_bits.AutoSize = true;
			global::System.Windows.Forms.Control label_stop_bits = this.Label_stop_bits;
			location = new global::System.Drawing.Point(18, 118);
			label_stop_bits.Location = location;
			this.Label_stop_bits.Name = "Label_stop_bits";
			global::System.Windows.Forms.Control label_stop_bits2 = this.Label_stop_bits;
			size = new global::System.Drawing.Size(54, 13);
			label_stop_bits2.Size = size;
			this.Label_stop_bits.TabIndex = 7;
			this.Label_stop_bits.Text = "Stop bits :";
			this.ComboNumeroBits.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboNumeroBits = this.ComboNumeroBits;
			location = new global::System.Drawing.Point(138, 83);
			comboNumeroBits.Location = location;
			this.ComboNumeroBits.Name = "ComboNumeroBits";
			global::System.Windows.Forms.Control comboNumeroBits2 = this.ComboNumeroBits;
			size = new global::System.Drawing.Size(64, 21);
			comboNumeroBits2.Size = size;
			this.ComboNumeroBits.TabIndex = 6;
			this.Label_bits.AutoSize = true;
			global::System.Windows.Forms.Control label_bits = this.Label_bits;
			location = new global::System.Drawing.Point(18, 86);
			label_bits.Location = location;
			this.Label_bits.Name = "Label_bits";
			global::System.Windows.Forms.Control label_bits2 = this.Label_bits;
			size = new global::System.Drawing.Size(69, 13);
			label_bits2.Size = size;
			this.Label_bits.TabIndex = 5;
			this.Label_bits.Text = "Número bits :";
			this.ComboBaudrate.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBaudrate = this.ComboBaudrate;
			location = new global::System.Drawing.Point(90, 51);
			comboBaudrate.Location = location;
			this.ComboBaudrate.Name = "ComboBaudrate";
			global::System.Windows.Forms.Control comboBaudrate2 = this.ComboBaudrate;
			size = new global::System.Drawing.Size(112, 21);
			comboBaudrate2.Size = size;
			this.ComboBaudrate.TabIndex = 4;
			this.Label_baudrate.AutoSize = true;
			global::System.Windows.Forms.Control label_baudrate = this.Label_baudrate;
			location = new global::System.Drawing.Point(18, 54);
			label_baudrate.Location = location;
			this.Label_baudrate.Name = "Label_baudrate";
			global::System.Windows.Forms.Control label_baudrate2 = this.Label_baudrate;
			size = new global::System.Drawing.Size(56, 13);
			label_baudrate2.Size = size;
			this.Label_baudrate.TabIndex = 3;
			this.Label_baudrate.Text = "Baudrate :";
			this.Label_porta.AutoSize = true;
			global::System.Windows.Forms.Control label_porta = this.Label_porta;
			location = new global::System.Drawing.Point(18, 22);
			label_porta.Location = location;
			this.Label_porta.Name = "Label_porta";
			global::System.Windows.Forms.Control label_porta2 = this.Label_porta;
			size = new global::System.Drawing.Size(38, 13);
			label_porta2.Size = size;
			this.Label_porta.TabIndex = 2;
			this.Label_porta.Text = "Porta :";
			this.ComboPortaSerial.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboPortaSerial = this.ComboPortaSerial;
			location = new global::System.Drawing.Point(90, 19);
			comboPortaSerial.Location = location;
			this.ComboPortaSerial.Name = "ComboPortaSerial";
			global::System.Windows.Forms.Control comboPortaSerial2 = this.ComboPortaSerial;
			size = new global::System.Drawing.Size(112, 21);
			comboPortaSerial2.Size = size;
			this.ComboPortaSerial.TabIndex = 1;
			this.OK_Button.Anchor = 0;
			global::System.Windows.Forms.Control ok_Button = this.OK_Button;
			location = new global::System.Drawing.Point(417, 304);
			ok_Button.Location = location;
			this.OK_Button.Name = "OK_Button";
			global::System.Windows.Forms.Control ok_Button2 = this.OK_Button;
			size = new global::System.Drawing.Size(67, 23);
			ok_Button2.Size = size;
			this.OK_Button.TabIndex = 0;
			this.OK_Button.Text = "OK";
			this.GroupBox_gerais.Controls.Add(this.NumericUpDown_retry);
			this.GroupBox_gerais.Controls.Add(this.Label1);
			global::System.Windows.Forms.Control groupBox_gerais = this.GroupBox_gerais;
			location = new global::System.Drawing.Point(14, 281);
			groupBox_gerais.Location = location;
			this.GroupBox_gerais.Name = "GroupBox_gerais";
			global::System.Windows.Forms.Control groupBox_gerais2 = this.GroupBox_gerais;
			size = new global::System.Drawing.Size(221, 73);
			groupBox_gerais2.Size = size;
			this.GroupBox_gerais.TabIndex = 6;
			this.GroupBox_gerais.TabStop = false;
			this.GroupBox_gerais.Text = "Parâmetros Gerais";
			global::System.Windows.Forms.Control numericUpDown_retry = this.NumericUpDown_retry;
			location = new global::System.Drawing.Point(99, 26);
			numericUpDown_retry.Location = location;
			global::System.Windows.Forms.NumericUpDown numericUpDown_retry2 = this.NumericUpDown_retry;
			decimal num;
			num = new decimal(new int[]
			{
				5,
				0,
				0,
				0
			});
			numericUpDown_retry2.Maximum = num;
			global::System.Windows.Forms.NumericUpDown numericUpDown_retry3 = this.NumericUpDown_retry;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			numericUpDown_retry3.Minimum = num;
			this.NumericUpDown_retry.Name = "NumericUpDown_retry";
			global::System.Windows.Forms.Control numericUpDown_retry4 = this.NumericUpDown_retry;
			size = new global::System.Drawing.Size(54, 20);
			numericUpDown_retry4.Size = size;
			this.NumericUpDown_retry.TabIndex = 1;
			this.NumericUpDown_retry.TextAlign = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown_retry5 = this.NumericUpDown_retry;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			numericUpDown_retry5.Value = num;
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label = this.Label1;
			location = new global::System.Drawing.Point(15, 28);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(78, 13);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "N° Tentativas :";
			this.GroupBox1.Controls.Add(this.tb_tcpip_Porta);
			this.GroupBox1.Controls.Add(this.tb_tcpip_IP);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			global::System.Windows.Forms.Control groupBox = this.GroupBox1;
			location = new global::System.Drawing.Point(250, 78);
			groupBox.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			global::System.Windows.Forms.Control groupBox2 = this.GroupBox1;
			size = new global::System.Drawing.Size(234, 186);
			groupBox2.Size = size;
			this.GroupBox1.TabIndex = 7;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Interface Ethernet  - TCP/IP:";
			global::System.Windows.Forms.Control tb_tcpip_Porta = this.tb_tcpip_Porta;
			location = new global::System.Drawing.Point(64, 101);
			tb_tcpip_Porta.Location = location;
			this.tb_tcpip_Porta.Name = "tb_tcpip_Porta";
			global::System.Windows.Forms.Control tb_tcpip_Porta2 = this.tb_tcpip_Porta;
			size = new global::System.Drawing.Size(50, 20);
			tb_tcpip_Porta2.Size = size;
			this.tb_tcpip_Porta.TabIndex = 13;
			global::System.Windows.Forms.Control tb_tcpip_IP = this.tb_tcpip_IP;
			location = new global::System.Drawing.Point(64, 75);
			tb_tcpip_IP.Location = location;
			this.tb_tcpip_IP.Name = "tb_tcpip_IP";
			global::System.Windows.Forms.Control tb_tcpip_IP2 = this.tb_tcpip_IP;
			size = new global::System.Drawing.Size(148, 20);
			tb_tcpip_IP2.Size = size;
			this.tb_tcpip_IP.TabIndex = 12;
			this.Label3.AutoSize = true;
			global::System.Windows.Forms.Control label3 = this.Label3;
			location = new global::System.Drawing.Point(15, 104);
			label3.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label4 = this.Label3;
			size = new global::System.Drawing.Size(38, 13);
			label4.Size = size;
			this.Label3.TabIndex = 11;
			this.Label3.Text = "Porta :";
			this.Label2.AutoSize = true;
			global::System.Windows.Forms.Control label5 = this.Label2;
			location = new global::System.Drawing.Point(15, 79);
			label5.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label6 = this.Label2;
			size = new global::System.Drawing.Size(20, 13);
			label6.Size = size;
			this.Label2.TabIndex = 0;
			this.Label2.Text = "IP:";
			this.GroupBox2.Controls.Add(this.cb_tipo_interface);
			this.GroupBox2.Controls.Add(this.Label4);
			global::System.Windows.Forms.Control groupBox3 = this.GroupBox2;
			location = new global::System.Drawing.Point(14, 12);
			groupBox3.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			global::System.Windows.Forms.Control groupBox4 = this.GroupBox2;
			size = new global::System.Drawing.Size(470, 56);
			groupBox4.Size = size;
			this.GroupBox2.TabIndex = 8;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Seleção de Interface:";
			this.cb_tipo_interface.FormattingEnabled = true;
			global::System.Windows.Forms.Control cb_tipo_interface = this.cb_tipo_interface;
			location = new global::System.Drawing.Point(106, 24);
			cb_tipo_interface.Location = location;
			this.cb_tipo_interface.Name = "cb_tipo_interface";
			global::System.Windows.Forms.Control cb_tipo_interface2 = this.cb_tipo_interface;
			size = new global::System.Drawing.Size(342, 21);
			cb_tipo_interface2.Size = size;
			this.cb_tipo_interface.TabIndex = 12;
			this.Label4.AutoSize = true;
			global::System.Windows.Forms.Control label7 = this.Label4;
			location = new global::System.Drawing.Point(15, 27);
			label7.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control label8 = this.Label4;
			size = new global::System.Drawing.Size(79, 13);
			label8.Size = size;
			this.Label4.TabIndex = 11;
			this.Label4.Text = "Tipo Interface :";
			global::System.Drawing.SizeF autoScaleDimensions;
			autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = 1;
			size = new global::System.Drawing.Size(497, 368);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.OK_Button);
			this.Controls.Add(this.GroupBox_gerais);
			this.Controls.Add(this.Grupo_com);
			this.FormBorderStyle = 3;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			location = new global::System.Drawing.Point(800, 200);
			this.Location = location;
			this.Name = "Configuracao";
			this.StartPosition = 1;
			this.Text = "Configuração de Interfaces de Comunicação";
			this.Grupo_com.ResumeLayout(false);
			this.Grupo_com.PerformLayout();
			this.GroupBox_gerais.ResumeLayout(false);
			this.GroupBox_gerais.PerformLayout();
			this.NumericUpDown_retry.EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x040001B5 RID: 437
		private global::System.ComponentModel.IContainer components;
	}
}
