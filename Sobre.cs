using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iS800.My;
using iS800.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x020000B0 RID: 176
	[DesignerGenerated]
	public partial class Sobre : Form
	{
		// Token: 0x06002922 RID: 10530 RVA: 0x0042CF58 File Offset: 0x0042B358
		public Sobre()
		{
			base.Shown += new EventHandler(this.Sobre_Shown);
			base.Load += new EventHandler(this.Sobre_Load);
			base.FormClosed += new FormClosedEventHandler(this.Sobre_FormClosed);
			base.MouseLeave += new EventHandler(this.Sobre_MouseLeave);
			this.InitializeComponent();
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06002925 RID: 10533 RVA: 0x0042D1A0 File Offset: 0x0042B5A0
		// (set) Token: 0x06002926 RID: 10534 RVA: 0x0042D1B4 File Offset: 0x0042B5B4
		internal virtual Label Label5
		{
			get
			{
				return this._Label5;
			}
			[MethodImpl(32)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x0042D1C0 File Offset: 0x0042B5C0
		private void OK_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = (DialogResult)1;
			this.Close();
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x0042D1D0 File Offset: 0x0042B5D0
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = (DialogResult)2;
			this.Close();
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x0042D1E0 File Offset: 0x0042B5E0
		private void Sobre_MouseLeave(object sender, EventArgs e)
		{
			int num = 5;
			Point location = this.Location;
			Point point = this.Location + this.Size;
			Point mousePosition = Control.MousePosition;
			checked
			{
				if (mousePosition.X > point.X - num | mousePosition.X < location.X + num)
				{
					this.Close();
				}
				if (mousePosition.Y < location.Y + num | mousePosition.Y > point.Y - num)
				{
					this.Close();
				}
			}
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x0042D268 File Offset: 0x0042B668
		[MethodImpl(72)]
		private void Sobre_Load(object sender, EventArgs e)
		{
			this.Label5.Text = "Versão do programa: " + MyProject.Application.Info.Version.ToString();
			this.BackgroundImage = Resources.Fundo_VORTICE;
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x0042D2A0 File Offset: 0x0042B6A0
		private void Sobre_Shown(object sender, EventArgs e)
		{
			this.Label5.Visible = true;
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x0042D2B0 File Offset: 0x0042B6B0
		private void Sobre_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Label5.Visible = false;
		}

		// Token: 0x04001C94 RID: 7316
		[AccessedThroughProperty("Label5")]
		private Label _Label5;
	}
}
