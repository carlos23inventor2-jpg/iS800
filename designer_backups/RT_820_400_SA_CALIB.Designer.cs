namespace iS800
{
	// Token: 0x02000053 RID: 83
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class RT_820_400_SA_CALIB : global::System.Windows.Forms.Form
	{
		// Token: 0x06001681 RID: 5761 RVA: 0x00373450 File Offset: 0x00371850
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

		// Token: 0x06001682 RID: 5762 RVA: 0x00373490 File Offset: 0x00371890
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.bt_busca = new global::System.Windows.Forms.Button();
			this.nud_estacao = new global::System.Windows.Forms.NumericUpDown();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.Button10 = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button9 = new global::System.Windows.Forms.Button();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.nud_contagens = new global::System.Windows.Forms.NumericUpDown();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.mensagens = new global::System.Windows.Forms.TextBox();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.rb_channel2 = new global::System.Windows.Forms.RadioButton();
			this.rb_channel1 = new global::System.Windows.Forms.RadioButton();
			this.GroupBox5 = new global::System.Windows.Forms.GroupBox();
			this.rb_20mA = new global::System.Windows.Forms.RadioButton();
			this.rb_4mA = new global::System.Windows.Forms.RadioButton();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.nud_estacao.BeginInit();
			this.GroupBox2.SuspendLayout();
			this.nud_contagens.BeginInit();
			this.GroupBox3.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			this.SuspendLayout();
			this.GroupBox1.Controls.Add(this.bt_busca);
			this.GroupBox1.Controls.Add(this.nud_estacao);
			this.GroupBox1.Controls.Add(this.Label1);
			global::System.Windows.Forms.Control groupBox = this.GroupBox1;
			global::System.Drawing.Point location;
			location = new global::System.Drawing.Point(12, 12);
			groupBox.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			global::System.Windows.Forms.Control groupBox2 = this.GroupBox1;
			global::System.Drawing.Size size;
			size = new global::System.Drawing.Size(601, 60);
			groupBox2.Size = size;
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Endereço do Equipamento";
			global::System.Windows.Forms.Control bt_busca = this.bt_busca;
			location = new location(512, 28);
			bt_busca.Location = location;
			this.bt_busca.Name = "bt_busca";
			global::System.Windows.Forms.Control bt_busca2 = this.bt_busca;
			size = new size(75, 23);
			bt_busca2.Size = size;
			this.bt_busca.TabIndex = 2;
			this.bt_busca.Text = "Busca";
			this.bt_busca.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control nud_estacao = this.nud_estacao;
			location = new location(77, 26);
			nud_estacao.Location = location;
			global::System.Windows.Forms.NumericUpDown nud_estacao2 = this.nud_estacao;
			decimal maximum;
			maximum = new decimal(new int[]
			{
				207,
				0,
				0,
				0
			});
			nud_estacao2.Maximum = maximum;
			this.nud_estacao.Name = "nud_estacao";
			global::System.Windows.Forms.Control nud_estacao3 = this.nud_estacao;
			size = new size(83, 20);
			nud_estacao3.Size = size;
			this.nud_estacao.TabIndex = 1;
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label = this.Label1;
			location = new location(15, 28);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new size(56, 13);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Endereço:";
			this.GroupBox2.Controls.Add(this.GroupBox5);
			this.GroupBox2.Controls.Add(this.GroupBox4);
			this.GroupBox2.Controls.Add(this.Button10);
			this.GroupBox2.Controls.Add(this.Label2);
			this.GroupBox2.Controls.Add(this.Button9);
			this.GroupBox2.Controls.Add(this.Button3);
			this.GroupBox2.Controls.Add(this.Button2);
			this.GroupBox2.Controls.Add(this.nud_contagens);
			this.GroupBox2.Controls.Add(this.Button1);
			global::System.Windows.Forms.Control groupBox3 = this.GroupBox2;
			location = new location(12, 93);
			groupBox3.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			global::System.Windows.Forms.Control groupBox4 = this.GroupBox2;
			size = new size(601, 284);
			groupBox4.Size = size;
			this.GroupBox2.TabIndex = 2;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Calibração:";
			global::System.Windows.Forms.Control button = this.Button10;
			location = new location(240, 250);
			button.Location = location;
			this.Button10.Name = "Button10";
			global::System.Windows.Forms.Control button2 = this.Button10;
			size = new size(114, 23);
			button2.Size = size;
			this.Button10.TabIndex = 11;
			this.Button10.Text = "Finaliza Calibração";
			this.Button10.UseVisualStyleBackColor = true;
			this.Label2.AutoSize = true;
			global::System.Windows.Forms.Control label3 = this.Label2;
			location = new location(15, 149);
			label3.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label4 = this.Label2;
			size = new size(61, 13);
			label4.Size = size;
			this.Label2.TabIndex = 10;
			this.Label2.Text = "Contagens:";
			global::System.Windows.Forms.Control button3 = this.Button9;
			location = new location(418, 173);
			button3.Location = location;
			this.Button9.Name = "Button9";
			global::System.Windows.Forms.Control button4 = this.Button9;
			size = new size(169, 23);
			button4.Size = size;
			this.Button9.TabIndex = 6;
			this.Button9.Text = "Confirma Calibração";
			this.Button9.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control button5 = this.Button3;
			location = new location(197, 173);
			button5.Location = location;
			this.Button3.Name = "Button3";
			global::System.Windows.Forms.Control button6 = this.Button3;
			size = new size(184, 23);
			button6.Size = size;
			this.Button3.TabIndex = 3;
			this.Button3.Text = "Escreve Contagens";
			this.Button3.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control button7 = this.Button2;
			location = new location(18, 199);
			button7.Location = location;
			this.Button2.Name = "Button2";
			global::System.Windows.Forms.Control button8 = this.Button2;
			size = new size(142, 23);
			button8.Size = size;
			this.Button2.TabIndex = 2;
			this.Button2.Text = "Busca Valor Contagens";
			this.Button2.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control nud_contagens = this.nud_contagens;
			location = new location(18, 173);
			nud_contagens.Location = location;
			global::System.Windows.Forms.NumericUpDown nud_contagens2 = this.nud_contagens;
			maximum = new decimal(new int[]
			{
				4095,
				0,
				0,
				0
			});
			nud_contagens2.Maximum = maximum;
			this.nud_contagens.Name = "nud_contagens";
			global::System.Windows.Forms.Control nud_contagens3 = this.nud_contagens;
			size = new size(142, 20);
			nud_contagens3.Size = size;
			this.nud_contagens.TabIndex = 1;
			global::System.Windows.Forms.Control button9 = this.Button1;
			location = new location(240, 19);
			button9.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button10 = this.Button1;
			size = new size(114, 23);
			button10.Size = size;
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Inicia Calibração";
			this.Button1.UseVisualStyleBackColor = true;
			this.GroupBox3.Controls.Add(this.mensagens);
			global::System.Windows.Forms.Control groupBox5 = this.GroupBox3;
			location = new location(11, 383);
			groupBox5.Location = location;
			this.GroupBox3.Name = "GroupBox3";
			global::System.Windows.Forms.Control groupBox6 = this.GroupBox3;
			size = new size(601, 74);
			groupBox6.Size = size;
			this.GroupBox3.TabIndex = 8;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Mensagens";
			this.mensagens.BackColor = global::System.Drawing.Color.Cornsilk;
			global::System.Windows.Forms.Control mensagens = this.mensagens;
			location = new location(8, 19);
			mensagens.Location = location;
			this.mensagens.Multiline = true;
			this.mensagens.Name = "mensagens";
			global::System.Windows.Forms.Control mensagens2 = this.mensagens;
			size = new size(579, 49);
			mensagens2.Size = size;
			this.mensagens.TabIndex = 0;
			this.GroupBox4.Controls.Add(this.rb_channel2);
			this.GroupBox4.Controls.Add(this.rb_channel1);
			global::System.Windows.Forms.Control groupBox7 = this.GroupBox4;
			location = new location(18, 63);
			groupBox7.Location = location;
			this.GroupBox4.Name = "GroupBox4";
			global::System.Windows.Forms.Control groupBox8 = this.GroupBox4;
			size = new size(184, 65);
			groupBox8.Size = size;
			this.GroupBox4.TabIndex = 15;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Seleção do canal:";
			this.rb_channel2.AutoSize = true;
			global::System.Windows.Forms.Control rb_channel = this.rb_channel2;
			location = new location(100, 28);
			rb_channel.Location = location;
			this.rb_channel2.Name = "rb_channel2";
			global::System.Windows.Forms.Control rb_channel2 = this.rb_channel2;
			size = new size(61, 17);
			rb_channel2.Size = size;
			this.rb_channel2.TabIndex = 15;
			this.rb_channel2.Text = "Canal 2";
			this.rb_channel2.UseVisualStyleBackColor = true;
			this.rb_channel1.AutoSize = true;
			this.rb_channel1.Checked = true;
			global::System.Windows.Forms.Control rb_channel3 = this.rb_channel1;
			location = new location(23, 30);
			rb_channel3.Location = location;
			this.rb_channel1.Name = "rb_channel1";
			global::System.Windows.Forms.Control rb_channel4 = this.rb_channel1;
			size = new size(61, 17);
			rb_channel4.Size = size;
			this.rb_channel1.TabIndex = 14;
			this.rb_channel1.TabStop = true;
			this.rb_channel1.Text = "Canal 1";
			this.rb_channel1.UseVisualStyleBackColor = true;
			this.GroupBox5.Controls.Add(this.rb_20mA);
			this.GroupBox5.Controls.Add(this.rb_4mA);
			global::System.Windows.Forms.Control groupBox9 = this.GroupBox5;
			location = new location(240, 63);
			groupBox9.Location = location;
			this.GroupBox5.Name = "GroupBox5";
			global::System.Windows.Forms.Control groupBox10 = this.GroupBox5;
			size = new size(184, 65);
			groupBox10.Size = size;
			this.GroupBox5.TabIndex = 16;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "Corrente:";
			this.rb_20mA.AutoSize = true;
			global::System.Windows.Forms.Control rb_20mA = this.rb_20mA;
			location = new location(100, 28);
			rb_20mA.Location = location;
			this.rb_20mA.Name = "rb_20mA";
			global::System.Windows.Forms.Control rb_20mA2 = this.rb_20mA;
			size = new size(52, 17);
			rb_20mA2.Size = size;
			this.rb_20mA.TabIndex = 15;
			this.rb_20mA.Text = "20mA";
			this.rb_20mA.UseVisualStyleBackColor = true;
			this.rb_4mA.AutoSize = true;
			this.rb_4mA.Checked = true;
			global::System.Windows.Forms.Control rb_4mA = this.rb_4mA;
			location = new location(23, 30);
			rb_4mA.Location = location;
			this.rb_4mA.Name = "rb_4mA";
			global::System.Windows.Forms.Control rb_4mA2 = this.rb_4mA;
			size = new size(46, 17);
			rb_4mA2.Size = size;
			this.rb_4mA.TabIndex = 14;
			this.rb_4mA.TabStop = true;
			this.rb_4mA.Text = "4mA";
			this.rb_4mA.UseVisualStyleBackColor = true;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = global::System.Drawing.Color.DarkRed;
			global::System.Windows.Forms.Control label5 = this.Label3;
			location = new location(9, 473);
			label5.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label6 = this.Label3;
			size = new size(237, 13);
			label6.Size = size;
			this.Label3.TabIndex = 9;
			this.Label3.Text = "Disponível a partir do Release 19 do RT820 400";
			global::System.Drawing.SizeF autoScaleDimensions;
			autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			size = new size(624, 489);
			this.ClientSize = size;
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Name = "RT_820_400_SA_CALIB";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Calibração Saídas Analógicas RT820 400";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.nud_estacao.EndInit();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.nud_contagens.EndInit();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000BE8 RID: 3048
		private global::System.ComponentModel.IContainer components;
	}
}
