using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x02000012 RID: 18
	[DesignerGenerated]
	public partial class Diretorios : Form
	{
		// Token: 0x060000CB RID: 203 RVA: 0x002653DC File Offset: 0x002637DC
		public Diretorios()
		{
			base.Load += new EventHandler(this.Diretorios_Load);
			base.FormClosed += new FormClosedEventHandler(this.Diretorios_FormClosed);
			this.InitializeComponent();
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0026565C File Offset: 0x00263A5C
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00265670 File Offset: 0x00263A70
		internal virtual FolderBrowserDialog FolderBrowserDialog1
		{
			get
			{
				return this._FolderBrowserDialog1;
			}
			[MethodImpl(32)]
			set
			{
				this._FolderBrowserDialog1 = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0026567C File Offset: 0x00263A7C
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00265690 File Offset: 0x00263A90
		internal virtual Button Button_diretorio_dados
		{
			get
			{
				return this._Button_diretorio_dados;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_diretorio_dados_Click);
				if (this._Button_diretorio_dados != null)
				{
					this._Button_diretorio_dados.Click -= eventHandler;
				}
				this._Button_diretorio_dados = value;
				if (this._Button_diretorio_dados != null)
				{
					this._Button_diretorio_dados.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x002656DC File Offset: 0x00263ADC
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x002656F0 File Offset: 0x00263AF0
		internal virtual Label Label_nome_diretorio_dados
		{
			get
			{
				return this._Label_nome_diretorio_dados;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_nome_diretorio_dados = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x002656FC File Offset: 0x00263AFC
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00265710 File Offset: 0x00263B10
		internal virtual TextBox Nome_diretorio_dados
		{
			get
			{
				return this._Nome_diretorio_dados;
			}
			[MethodImpl(32)]
			set
			{
				this._Nome_diretorio_dados = value;
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0026571C File Offset: 0x00263B1C
		private void Button_diretorio_dados_Click(object sender, EventArgs e)
		{
			if (this.FolderBrowserDialog1.ShowDialog() == 1)
			{
				this.Nome_diretorio_dados.Text = this.FolderBrowserDialog1.SelectedPath;
				Comunicacao.Config_sistema.Dir_dados = this.Nome_diretorio_dados.Text;
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00265758 File Offset: 0x00263B58
		private void Diretorios_Load(object sender, EventArgs e)
		{
			this.Nome_diretorio_dados.Text = Comunicacao.Config_sistema.Dir_dados;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00265770 File Offset: 0x00263B70
		[MethodImpl(72)]
		private void Diretorios_FormClosed(object sender, FormClosedEventArgs e)
		{
			string text = FileSystem.CurDir();
			try
			{
				FileSystem.FileOpen(1, text + "\\Sis_ictel_800.ini", 32, 3, -1, -1);
				FileSystem.Lock(1);
				FileSystem.FilePut(1, Comunicacao.Config_sistema, -1L);
				FileSystem.Unlock(1);
				FileSystem.FileClose(new int[]
				{
					1
				});
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Não foi possível salvar as configurações", 0, null);
			}
		}

		// Token: 0x040001CF RID: 463
		[AccessedThroughProperty("FolderBrowserDialog1")]
		private FolderBrowserDialog _FolderBrowserDialog1;

		// Token: 0x040001D0 RID: 464
		[AccessedThroughProperty("Button_diretorio_dados")]
		private Button _Button_diretorio_dados;

		// Token: 0x040001D1 RID: 465
		[AccessedThroughProperty("Label_nome_diretorio_dados")]
		private Label _Label_nome_diretorio_dados;

		// Token: 0x040001D2 RID: 466
		[AccessedThroughProperty("Nome_diretorio_dados")]
		private TextBox _Nome_diretorio_dados;
	}
}
