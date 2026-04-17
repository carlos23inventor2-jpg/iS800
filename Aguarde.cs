using System.Drawing;
using System.Windows.Forms;
﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x02000009 RID: 9
	public partial class Aguarde : Form
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00263514 File Offset: 0x00261914
		public Aguarde()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0026370C File Offset: 0x00261B0C
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00263720 File Offset: 0x00261B20
		internal virtual PictureBox PictureBox1
		{
			get
			{
				return this._PictureBox1;
			}
			[MethodImpl(32)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0026372C File Offset: 0x00261B2C
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00263740 File Offset: 0x00261B40
		internal virtual Label Label1
		{
			get
			{
				return this._Label1;
			}
			[MethodImpl(32)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x04000035 RID: 53
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000036 RID: 54
		[AccessedThroughProperty("Label1")]
		private Label _Label1;
	}
}
