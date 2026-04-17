using System.Drawing;
using System.Windows.Forms;
﻿namespace iS800
{
	// Token: 0x02000013 RID: 19
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Discover : global::System.Windows.Forms.Form
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00265818 File Offset: 0x00263C18
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

		// Token: 0x060000DB RID: 219 RVA: 0x00265858 File Offset: 0x00263C58
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::iS800.Discover));
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
			this.bt_Configuracao = new global::System.Windows.Forms.Button();
			this.GroupBox_informacoes.SuspendLayout();
			this.SuspendLayout();
			this.GroupBox_informacoes.Controls.Add(this.Label26);
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
			groupBox_informacoes.Location = new global::System.Drawing.Point(12, 12);
			this.GroupBox_informacoes.Name = "GroupBox_informacoes";
			global::System.Windows.Forms.Control groupBox_informacoes2 = this.GroupBox_informacoes;
			groupBox_informacoes2.Size = new global::System.Drawing.Size(290, 84);
			this.GroupBox_informacoes.TabIndex = 3;
			this.GroupBox_informacoes.TabStop = false;
			this.GroupBox_informacoes.Text = "Informações";
			this.Label26.AutoSize = true;
			this.Label26.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control label = this.Label26;
label.Location = new global::System.Drawing.Point(12, 49);
			this.Label26.Name = "Label26";
			global::System.Windows.Forms.Control label2 = this.Label26;
			Size = new System.Drawing.Size(20, 15);
			label2.Size = this.Size;
			this.Label26.TabIndex = 8;
			this.Label26.Text = "RT";
			this.TextBox_equipamento.BackColor = global::System.Drawing.Color.LightCyan;
			this.TextBox_equipamento.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control textBox_equipamento = this.TextBox_equipamento;
textBox_equipamento.Location = new global::System.Drawing.Point(47, 46);
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
label_equipamento.Location = new global::System.Drawing.Point(12, 28);
			this.Label_equipamento.Name = "Label_equipamento";
			global::System.Windows.Forms.Control label_equipamento2 = this.Label_equipamento;
			Size = new System.Drawing.Size(69, 13);
			label_equipamento2.Size = this.Size;
			this.Label_equipamento.TabIndex = 6;
			this.Label_equipamento.Text = "Equipamento";
			this.TextBox_release.BackColor = global::System.Drawing.Color.LightCyan;
			this.TextBox_release.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control textBox_release = this.TextBox_release;
textBox_release.Location = new global::System.Drawing.Point(203, 46);
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
label_release.Location = new global::System.Drawing.Point(206, 28);
			this.Label_release.Name = "Label_release";
			global::System.Windows.Forms.Control label_release2 = this.Label_release;
			Size = new System.Drawing.Size(46, 13);
			label_release2.Size = this.Size;
			this.Label_release.TabIndex = 4;
			this.Label_release.Text = "Release";
			this.TextBox_build.BackColor = global::System.Drawing.Color.LightCyan;
			this.TextBox_build.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control textBox_build = this.TextBox_build;
textBox_build.Location = new global::System.Drawing.Point(151, 46);
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
label_build.Location = new global::System.Drawing.Point(160, 28);
			this.Label_build.Name = "Label_build";
			global::System.Windows.Forms.Control label_build2 = this.Label_build;
			Size = new System.Drawing.Size(30, 13);
			label_build2.Size = this.Size;
			this.Label_build.TabIndex = 2;
			this.Label_build.Text = "Build";
			this.TextBox_versao.BackColor = global::System.Drawing.Color.LightCyan;
			this.TextBox_versao.Font = new global::System.Drawing.Font("Arial Narrow", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			global::System.Windows.Forms.Control textBox_versao = this.TextBox_versao;
textBox_versao.Location = new global::System.Drawing.Point(99, 46);
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
label_versao.Location = new global::System.Drawing.Point(102, 28);
			this.Label_versao.Name = "Label_versao";
			global::System.Windows.Forms.Control label_versao2 = this.Label_versao;
			Size = new System.Drawing.Size(40, 13);
			label_versao2.Size = this.Size;
			this.Label_versao.TabIndex = 0;
			this.Label_versao.Text = "Versão";
			global::System.Windows.Forms.Control bt_Configuracao = this.bt_Configuracao;
bt_Configuracao.Location = new global::System.Drawing.Point(12, 150);
			this.bt_Configuracao.Name = "bt_Configuracao";
			global::System.Windows.Forms.Control bt_Configuracao2 = this.bt_Configuracao;
			Size = new System.Drawing.Size(102, 23);
			bt_Configuracao2.Size = this.Size;
			this.bt_Configuracao.TabIndex = 4;
			this.bt_Configuracao.Text = "Configuração";
			this.bt_Configuracao.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF autoScaleDimensions;
			autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			Size = new System.Drawing.Size(312, 261);
			this.ClientSize = Size;
			this.Controls.Add(this.bt_Configuracao);
			this.Controls.Add(this.GroupBox_informacoes);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Discover";
			this.Text = "Discover";
			this.GroupBox_informacoes.ResumeLayout(false);
			this.GroupBox_informacoes.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x040001D3 RID: 467
		private global::System.ComponentModel.IContainer components;
	}
}
