using System.Drawing;
using System.Windows.Forms;
﻿namespace iS800
{
	// Token: 0x020000A6 RID: 166
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class LogComunicacao : global::System.Windows.Forms.Form
	{
		// Token: 0x06002778 RID: 10104 RVA: 0x004233EC File Offset: 0x004217EC
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

		// Token: 0x06002779 RID: 10105 RVA: 0x0042342C File Offset: 0x0042182C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::iS800.LogComunicacao));
			this.Label1 = new global::System.Windows.Forms.Label();
			this.cb_disco = new global::System.Windows.Forms.CheckBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.tb_diretorio = new global::System.Windows.Forms.TextBox();
			this.FolderBrowserDialog1 = new global::System.Windows.Forms.FolderBrowserDialog();
			this.bt_diretorio = new global::System.Windows.Forms.Button();
			this.bt_inicia = new global::System.Windows.Forms.Button();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.cb_corsan = new global::System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label = this.Label1;
			label.Location = new global::System.Drawing.Point(12, 21);
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			label2.Size = new global::System.Drawing.Size(305, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Visualização e captura de dados que trafegam pela canal serial";
			this.cb_disco.AutoSize = true;
			global::System.Windows.Forms.Control cb_disco = this.cb_disco;
cb_disco.Location = new global::System.Drawing.Point(15, 53);
			this.cb_disco.Name = "cb_disco";
			global::System.Windows.Forms.Control cb_disco2 = this.cb_disco;
			Size = new System.Drawing.Size(192, 17);
			cb_disco2.Size = this.Size;
			this.cb_disco.TabIndex = 1;
			this.cb_disco.Text = "Armazena em disco. Formato ASCII";
			this.cb_disco.UseVisualStyleBackColor = true;
			this.Label2.AutoSize = true;
			global::System.Windows.Forms.Control label3 = this.Label2;
label3.Location = new global::System.Drawing.Point(239, 57);
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label4 = this.Label2;
			Size = new System.Drawing.Size(49, 13);
			label4.Size = this.Size;
			this.Label2.TabIndex = 5;
			this.Label2.Text = "Diretório:";
			global::System.Windows.Forms.Control tb_diretorio = this.tb_diretorio;
tb_diretorio.Location = new global::System.Drawing.Point(294, 50);
			this.tb_diretorio.Name = "tb_diretorio";
			global::System.Windows.Forms.Control tb_diretorio2 = this.tb_diretorio;
			Size = new System.Drawing.Size(455, 20);
			tb_diretorio2.Size = this.Size;
			this.tb_diretorio.TabIndex = 6;
			global::System.Windows.Forms.Control bt_diretorio = this.bt_diretorio;
bt_diretorio.Location = new global::System.Drawing.Point(755, 47);
			this.bt_diretorio.Name = "bt_diretorio";
			global::System.Windows.Forms.Control bt_diretorio2 = this.bt_diretorio;
			Size = new System.Drawing.Size(34, 23);
			bt_diretorio2.Size = this.Size;
			this.bt_diretorio.TabIndex = 7;
			this.bt_diretorio.Text = "...";
			this.bt_diretorio.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control bt_inicia = this.bt_inicia;
bt_inicia.Location = new global::System.Drawing.Point(15, 139);
			this.bt_inicia.Name = "bt_inicia";
			global::System.Windows.Forms.Control bt_inicia2 = this.bt_inicia;
			Size = new System.Drawing.Size(175, 23);
			bt_inicia2.Size = this.Size;
			this.bt_inicia.TabIndex = 15;
			this.bt_inicia.Text = "Inicia Captura";
			this.bt_inicia.UseVisualStyleBackColor = true;
			global::System.Windows.Forms.Control textBox = this.TextBox1;
textBox.Location = new global::System.Drawing.Point(15, 168);
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ScrollBars =(System.Windows.Forms.ScrollBars)2;
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			Size = new System.Drawing.Size(774, 318);
			textBox2.Size = this.Size;
			this.TextBox1.TabIndex = 16;
			this.Label7.AutoSize = true;
			global::System.Windows.Forms.Control label5 = this.Label7;
label5.Location = new global::System.Drawing.Point(219, 149);
			this.Label7.Name = "Label7";
			global::System.Windows.Forms.Control label6 = this.Label7;
			Size = new System.Drawing.Size(39, 13);
			label6.Size = this.Size;
			this.Label7.TabIndex = 17;
			this.Label7.Text = "Label7";
			this.cb_corsan.AutoSize = true;
			global::System.Windows.Forms.Control cb_corsan = this.cb_corsan;
cb_corsan.Location = new global::System.Drawing.Point(15, 86);
			this.cb_corsan.Name = "cb_corsan";
			global::System.Windows.Forms.Control cb_corsan2 = this.cb_corsan;
			Size = new System.Drawing.Size(149, 17);
			cb_corsan2.Size = this.Size;
			this.cb_corsan.TabIndex = 18;
			this.cb_corsan.Text = "Parse Protocolo CORSAN";
			this.cb_corsan.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF autoScaleDimensions;
			autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			Size = new System.Drawing.Size(1144, 498);
			this.ClientSize = Size;
			this.Controls.Add(this.cb_corsan);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.bt_inicia);
			this.Controls.Add(this.bt_diretorio);
			this.Controls.Add(this.tb_diretorio);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.cb_disco);
			this.Controls.Add(this.Label1);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "LogComunicacao";
			this.Text = "iS800 Log de Comunicação";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04001BE2 RID: 7138
		private global::System.ComponentModel.IContainer components;
	}
}
