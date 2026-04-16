namespace iS800
{
	// Token: 0x02000012 RID: 18
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Diretorios : global::System.Windows.Forms.Form
	{
		// Token: 0x060000CC RID: 204 RVA: 0x00265410 File Offset: 0x00263810
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

		// Token: 0x060000CD RID: 205 RVA: 0x00265450 File Offset: 0x00263850
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::iS800.Diretorios));
			this.FolderBrowserDialog1 = new global::System.Windows.Forms.FolderBrowserDialog();
			this.Button_diretorio_dados = new global::System.Windows.Forms.Button();
			this.Label_nome_diretorio_dados = new global::System.Windows.Forms.Label();
			this.Nome_diretorio_dados = new global::System.Windows.Forms.TextBox();
			this.SuspendLayout();
			global::System.Windows.Forms.Control button_diretorio_dados = this.Button_diretorio_dados;
			global::System.Drawing.Point location;
			location = new global::System.Drawing.Point(463, 39);
			button_diretorio_dados.Location = location;
			this.Button_diretorio_dados.Name = "Button_diretorio_dados";
			global::System.Windows.Forms.Control button_diretorio_dados2 = this.Button_diretorio_dados;
			global::System.Drawing.Size size;
			size = new global::System.Drawing.Size(33, 23);
			button_diretorio_dados2.Size = size;
			this.Button_diretorio_dados.TabIndex = 5;
			this.Button_diretorio_dados.UseVisualStyleBackColor = true;
			this.Label_nome_diretorio_dados.AutoSize = true;
			global::System.Windows.Forms.Control label_nome_diretorio_dados = this.Label_nome_diretorio_dados;
			location = new location(25, 23);
			label_nome_diretorio_dados.Location = location;
			this.Label_nome_diretorio_dados.Name = "Label_nome_diretorio_dados";
			global::System.Windows.Forms.Control label_nome_diretorio_dados2 = this.Label_nome_diretorio_dados;
			size = new size(93, 13);
			label_nome_diretorio_dados2.Size = size;
			this.Label_nome_diretorio_dados.TabIndex = 4;
			this.Label_nome_diretorio_dados.Text = "Diretório de dados";
			global::System.Windows.Forms.Control nome_diretorio_dados = this.Nome_diretorio_dados;
			location = new location(25, 41);
			nome_diretorio_dados.Location = location;
			this.Nome_diretorio_dados.Name = "Nome_diretorio_dados";
			this.Nome_diretorio_dados.ReadOnly = true;
			global::System.Windows.Forms.Control nome_diretorio_dados2 = this.Nome_diretorio_dados;
			size = new size(432, 20);
			nome_diretorio_dados2.Size = size;
			this.Nome_diretorio_dados.TabIndex = 3;
			global::System.Drawing.SizeF autoScaleDimensions;
			autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			size = new size(524, 97);
			this.ClientSize = size;
			this.Controls.Add(this.Button_diretorio_dados);
			this.Controls.Add(this.Label_nome_diretorio_dados);
			this.Controls.Add(this.Nome_diretorio_dados);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "Diretorios";
			this.Text = "Configuração de diretórios";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040001CE RID: 462
		private global::System.ComponentModel.IContainer components;
	}
}
