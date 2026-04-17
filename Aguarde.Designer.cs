using System.Drawing;
using System.Windows.Forms;
﻿namespace iS800
{
	// Token: 0x02000009 RID: 9
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Aguarde : global::System.Windows.Forms.Form
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00263524 File Offset: 0x00261924
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

		// Token: 0x06000076 RID: 118 RVA: 0x00263564 File Offset: 0x00261964
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::iS800.Aguarde));
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
			this.SuspendLayout();
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new global::System.Drawing.Point(12, 12);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(34, 34);
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(71, 23);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(162, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Aguarde o término da operação !";
			this.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new global::System.Drawing.Size(284, 66);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.PictureBox1);
			this.Name = "Aguarde";
			this.Text = "Aguarde";
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000034 RID: 52
		private global::System.ComponentModel.IContainer components;
	}
}
