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
	// Token: 0x020000A7 RID: 167
	[DesignerGenerated]
	public partial class Logo : Form
	{
		// Token: 0x0600279C RID: 10140 RVA: 0x00424780 File Offset: 0x00422B80
		public Logo()
		{
			base.Load += new EventHandler(this.Logo_Load);
			base.Shown += new EventHandler(this.Logo_Shown);
			this.InitializeComponent();
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x0600279F RID: 10143 RVA: 0x00424988 File Offset: 0x00422D88
		// (set) Token: 0x060027A0 RID: 10144 RVA: 0x0042499C File Offset: 0x00422D9C
		internal virtual Timer Timer1
		{
			get
			{
				return this._Timer1;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
				if (this._Timer1 != null)
				{
					this._Timer1.Tick -= eventHandler;
				}
				this._Timer1 = value;
				if (this._Timer1 != null)
				{
					this._Timer1.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x060027A1 RID: 10145 RVA: 0x004249E8 File Offset: 0x00422DE8
		// (set) Token: 0x060027A2 RID: 10146 RVA: 0x004249FC File Offset: 0x00422DFC
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

		// Token: 0x060027A3 RID: 10147 RVA: 0x00424A08 File Offset: 0x00422E08
		[MethodImpl(72)]
		private void Logo_Load(object sender, EventArgs e)
		{
			this.Label5.Text = "Versão do programa: " + MyProject.Application.Info.Version.ToString();
			this.Timer1.Enabled = true;
			this.BackgroundImage = Resources.Fundo_VORTICE;
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00424A58 File Offset: 0x00422E58
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.Close();
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x00424A6C File Offset: 0x00422E6C
		private void Logo_Shown(object sender, EventArgs e)
		{
			this.Label5.Visible = true;
		}

		// Token: 0x04001BF3 RID: 7155
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04001BF4 RID: 7156
		[AccessedThroughProperty("Label5")]
		private Label _Label5;
	}
}
