namespace iS800
{
	// Token: 0x020000A7 RID: 167
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Logo : global::System.Windows.Forms.Form
	{
		// Token: 0x0600279D RID: 10141 RVA: 0x004247B4 File Offset: 0x00422BB4
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

		// Token: 0x0600279E RID: 10142 RVA: 0x004247F4 File Offset: 0x00422BF4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Label5 = new global::System.Windows.Forms.Label();
			this.SuspendLayout();
			this.Timer1.Interval = (HorizontalAlignment)3000;
			this.Label5.AccessibleRole = (HorizontalAlignment)0;
			this.Label5.AutoSize = true;
			this.Label5.BackColor = global::System.Drawing.Color.Transparent;
			this.Label5.CausesValidation = false;
			this.Label5.Font = new global::System.Drawing.Font("Calibri", 12.75f, 3, (FontStyle)3, 0);
			global::System.Windows.Forms.Control label = this.Label5;
			global::System.Drawing.Point location;
			location = new global::System.Drawing.Point(35, 95);
			label.Location = location;
			this.Label5.Name = "Label5";
			global::System.Windows.Forms.Control label2 = this.Label5;
			global::System.Drawing.Size size;
			size = new global::System.Drawing.Size(58, 21);
			label2.Size = size;
			this.Label5.TabIndex = (HorizontalAlignment)2;
			this.Label5.Text = "Versão";
			this.Label5.Visible = false;
			global::System.Drawing.SizeF autoScaleDimensions;
			autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			this.BackgroundImage = global::iS800.My.Resources.Resources.Fundo_ICTEL;
			size = new size(729, 350);
			this.ClientSize = size;
			this.Controls.Add(this.Label5);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Name = "Logo";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Logo";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04001BF2 RID: 7154
		private global::System.ComponentModel.IContainer components;
	}
}
