namespace iS800
{
	// Token: 0x020000B0 RID: 176
	public partial class Sobre : global::System.Windows.Forms.Form
	{
		// Token: 0x06002923 RID: 10531 RVA: 0x0042CFC0 File Offset: 0x0042B3C0
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

		// Token: 0x06002924 RID: 10532 RVA: 0x0042D000 File Offset: 0x0042B400
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::iS800.Sobre));
			this.Label5 = new global::System.Windows.Forms.Label();
			this.SuspendLayout();
			this.Label5.AccessibleRole = 0;
			this.Label5.AutoSize = true;
			this.Label5.BackColor = global::System.Drawing.Color.Transparent;
			this.Label5.CausesValidation = false;
			this.Label5.Font = new global::System.Drawing.Font("Calibri", 12.75f, (System.Drawing.FontStyle)3, (System.Drawing.GraphicsUnit)3, 0);
			global::System.Windows.Forms.Control label = this.Label5;
			global::System.Drawing.Point location;
			location = new global::System.Drawing.Point(34, 92);
			label.Location = location;
			this.Label5.Name = "Label5";
			global::System.Windows.Forms.Control label2 = this.Label5;
			global::System.Drawing.Size size;
			size = new global::System.Drawing.Size(58, 21);
			label2.Size = size;
			this.Label5.TabIndex = 3;
			this.Label5.Text = "Versão";
			this.Label5.Visible = false;
			global::System.Drawing.SizeF autoScaleDimensions;
			autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = (System.Windows.Forms.AutoScaleMode)1;
			this.AutoValidate = (System.Windows.Forms.AutoValidate)1;
			this.BackColor = global::System.Drawing.Color.White;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			size = new global::System.Drawing.Size(729, 350);
			this.ClientSize = size;
			this.Controls.Add(this.Label5);
			this.FormBorderStyle = (System.Windows.Forms.FormBorderStyle)0;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Sobre";
			this.ShowInTaskbar = false;
			this.StartPosition = (System.Windows.Forms.FormStartPosition)4;
			this.Text = "Ictel  - Instrumentação, Controles e Telemetria Ltda";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04001C93 RID: 7315
		private global::System.ComponentModel.IContainer components;
	}
}
