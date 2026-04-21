using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using iS800.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x020000A6 RID: 166
	[DesignerGenerated]
	public partial class LogComunicacao : Form
	{
		// Token: 0x06002777 RID: 10103 RVA: 0x004233C8 File Offset: 0x004217C8
		public LogComunicacao()
		{
			base.Load += new EventHandler(this.LogComunicacao_Load);
			this.InitializeComponent();
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x004239AC File Offset: 0x00421DAC
		// (set) Token: 0x0600277B RID: 10107 RVA: 0x004239C0 File Offset: 0x00421DC0
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

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x0600277C RID: 10108 RVA: 0x004239CC File Offset: 0x00421DCC
		// (set) Token: 0x0600277D RID: 10109 RVA: 0x004239E0 File Offset: 0x00421DE0
		internal virtual CheckBox cb_disco
		{
			get
			{
				return this._cb_disco;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_disco_CheckStateChanged);
				if (this._cb_disco != null)
				{
					this._cb_disco.CheckStateChanged -= eventHandler;
				}
				this._cb_disco = value;
				if (this._cb_disco != null)
				{
					this._cb_disco.CheckStateChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x0600277E RID: 10110 RVA: 0x00423A2C File Offset: 0x00421E2C
		// (set) Token: 0x0600277F RID: 10111 RVA: 0x00423A40 File Offset: 0x00421E40
		internal virtual Label Label2
		{
			get
			{
				return this._Label2;
			}
			[MethodImpl(32)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06002780 RID: 10112 RVA: 0x00423A4C File Offset: 0x00421E4C
		// (set) Token: 0x06002781 RID: 10113 RVA: 0x00423A60 File Offset: 0x00421E60
		internal virtual TextBox tb_diretorio
		{
			get
			{
				return this._tb_diretorio;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_diretorio = value;
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06002782 RID: 10114 RVA: 0x00423A6C File Offset: 0x00421E6C
		// (set) Token: 0x06002783 RID: 10115 RVA: 0x00423A80 File Offset: 0x00421E80
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

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x00423A8C File Offset: 0x00421E8C
		// (set) Token: 0x06002785 RID: 10117 RVA: 0x00423AA0 File Offset: 0x00421EA0
		internal virtual Button bt_diretorio
		{
			get
			{
				return this._bt_diretorio;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bt_diretorio_Click);
				if (this._bt_diretorio != null)
				{
					this._bt_diretorio.Click -= eventHandler;
				}
				this._bt_diretorio = value;
				if (this._bt_diretorio != null)
				{
					this._bt_diretorio.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x00423AEC File Offset: 0x00421EEC
		// (set) Token: 0x06002787 RID: 10119 RVA: 0x00423B00 File Offset: 0x00421F00
		internal virtual Button bt_inicia
		{
			get
			{
				return this._bt_inicia;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.bt_inicia_Click);
				if (this._bt_inicia != null)
				{
					this._bt_inicia.Click -= eventHandler;
				}
				this._bt_inicia = value;
				if (this._bt_inicia != null)
				{
					this._bt_inicia.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06002788 RID: 10120 RVA: 0x00423B4C File Offset: 0x00421F4C
		// (set) Token: 0x06002789 RID: 10121 RVA: 0x00423B60 File Offset: 0x00421F60
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

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x0600278A RID: 10122 RVA: 0x00423BAC File Offset: 0x00421FAC
		// (set) Token: 0x0600278B RID: 10123 RVA: 0x00423BC0 File Offset: 0x00421FC0
		internal virtual TextBox TextBox1
		{
			get
			{
				return this._TextBox1;
			}
			[MethodImpl(32)]
			set
			{
				this._TextBox1 = value;
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x0600278C RID: 10124 RVA: 0x00423BCC File Offset: 0x00421FCC
		// (set) Token: 0x0600278D RID: 10125 RVA: 0x00423BE0 File Offset: 0x00421FE0
		internal virtual Label Label7
		{
			get
			{
				return this._Label7;
			}
			[MethodImpl(32)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x0600278E RID: 10126 RVA: 0x00423BEC File Offset: 0x00421FEC
		// (set) Token: 0x0600278F RID: 10127 RVA: 0x00423C00 File Offset: 0x00422000
		internal virtual CheckBox cb_corsan
		{
			get
			{
				return this._cb_corsan;
			}
			[MethodImpl(32)]
			set
			{
				this._cb_corsan = value;
			}
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x00423C0C File Offset: 0x0042200C
		private void Inicializacao()
		{
			this.cb_disco.Checked = false;
			this.Label2.Enabled = this.cb_disco.Checked;
			this.tb_diretorio.Enabled = this.cb_disco.Checked;
			this.bt_diretorio.Enabled = this.cb_disco.Checked;
			this.tb_diretorio.Text = "";
			this.FolderBrowserDialog1.SelectedPath = "";
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x00423C88 File Offset: 0x00422088
		private void LogComunicacao_Load(object sender, EventArgs e)
		{
			this.Inicializacao();
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x00423C90 File Offset: 0x00422090
		private void cb_disco_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x00423C94 File Offset: 0x00422094
		private void cb_disco_CheckStateChanged(object sender, EventArgs e)
		{
			this.Label2.Enabled = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null));
			this.tb_diretorio.Enabled = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null));
			this.bt_diretorio.Enabled = Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "checked", new object[0], null, null, null));
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x00423D10 File Offset: 0x00422110
		private void cb_marcadores_CheckStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x00423D14 File Offset: 0x00422114
		private void cb_filtroendereco_CheckStateChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x00423D18 File Offset: 0x00422118
		private void bt_diretorio_Click(object sender, EventArgs e)
		{
			if (this.FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				this.tb_diretorio.Text = this.FolderBrowserDialog1.SelectedPath;
				Comunicacao.Ctrl_Log.diretorio = this.FolderBrowserDialog1.SelectedPath;
			}
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x00423D54 File Offset: 0x00422154
		private void bt_inicia_Click(object sender, EventArgs e)
		{
			Comunicacao.Ctrl_Com.Tipo_protocolo = 4;
			Comunicacao.Ctrl_Log.flag = false;
			Comunicacao.Ctrl_Log.bytes_recv = 0;
			Comunicacao.Ctrl_Log.timeouts = 0;
			this.Timer1.Enabled = true;
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x00423D90 File Offset: 0x00422190
		private void Timer1_Tick(object sender, EventArgs e)
		{
			checked
			{
				if (Comunicacao.Ctrl_Log.flag)
				{
					int bytesToRead = MyProject.Forms.Plataforma.SerialPort1.BytesToRead;
					if (bytesToRead > 0)
					{
						int num = 0;
						int num2 = bytesToRead - 1;
						for (int i = num; i <= num2; i++)
						{
							byte b = (byte)MyProject.Forms.Plataforma.SerialPort1.ReadByte();
							Comunicacao.Buffer_Log[Comunicacao.Ctrl_Log.bytes_recv] = b;
							Comunicacao.Ctrl_Log.bytes_recv = Comunicacao.Ctrl_Log.bytes_recv + 1;
						}
						Comunicacao.Ctrl_Log.timeouts = 0;
					}
					else
					{
						Comunicacao.Ctrl_Log.timeouts = Comunicacao.Ctrl_Log.timeouts + 1;
						if (Comunicacao.Ctrl_Log.timeouts > 6)
						{
							this.MontaLog();
							if (this.cb_corsan.Checked)
							{
								string text = this.MostraFrameCorsan();
								this.TextBox1.AppendText(text);
							}
							Comunicacao.Ctrl_Log.flag = false;
							Comunicacao.Ctrl_Log.bytes_recv = 0;
							Comunicacao.Ctrl_Log.timeouts = 0;
						}
					}
					Application.DoEvents();
				}
			}
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x00423E90 File Offset: 0x00422290
		private string MostraFrameCorsan()
		{
			int num = 0;
			string text = "";
			int num2 = 0;
			checked
			{
				int ini = 0;
				int num3 = Comunicacao.Ctrl_Log.bytes_recv - 1;
				for (int i = num2; i <= num3; i++)
				{
					switch (num)
					{
					case 0:
						switch (Comunicacao.Buffer_Log[i])
						{
						case 1:
						{
							text += "SOH ";
							int num4 = (int)Comunicacao.Buffer_Log[i];
							num = 1;
							ini = i;
							break;
						}
						case 2:
						{
							text += "STX ";
							int num4 = (int)Comunicacao.Buffer_Log[i];
							num = 1;
							ini = i;
							break;
						}
						default:
							text = text + Conversion.Hex(Comunicacao.Buffer_Log[i]) + " ";
							num = 0;
							break;
						}
						break;
					case 1:
						if (Comunicacao.Buffer_Log[i] >= 49 & Comunicacao.Buffer_Log[i] <= 248)
						{
							text = text + "Dest=" + (Comunicacao.Buffer_Log[i] - 48).ToString() + " ";
							num = 2;
						}
						else
						{
							text = text + Conversion.Hex(Comunicacao.Buffer_Log[i]) + " ";
							num = 0;
						}
						break;
					case 2:
						if (Comunicacao.Buffer_Log[i] >= 49 & Comunicacao.Buffer_Log[i] <= 248)
						{
							text = text + "Orig=" + (Comunicacao.Buffer_Log[i] - 48).ToString() + " ";
							num = 3;
						}
						else
						{
							text = text + Conversion.Hex(Comunicacao.Buffer_Log[i]) + " ";
							num = 0;
						}
						break;
					case 3:
					{
						int num4 = 0;
						if (num4 == 1)
						{
							byte b = Comunicacao.Buffer_Log[i];
							if (b == 6)
							{
								text += "ACK [";
								num = 4;
							}
							else if (b == 15)
							{
								text += "NAC [";
								num = 4;
							}
							else
							{
								text = text + Conversion.Hex(Comunicacao.Buffer_Log[i]) + " ";
								num = 0;
							}
						}
						else if (num4 == 2)
						{
							int num5 = (int)Comunicacao.Buffer_Log[i];
							text = text + "CMD=" + Conversion.Hex(num5) + " [";
							num = 4;
						}
						break;
					}
					case 4:
						if (Comunicacao.Buffer_Log[i] == 3)
						{
							text += "[Sem Dados] ETX ";
							num = 6;
						}
						else
						{
							text += Conversion.Hex(Comunicacao.Buffer_Log[i]);
							if (Comunicacao.Buffer_Log[i + 1] == 3)
							{
								text += "] ";
								num = 5;
							}
							else
							{
								num = 4;
								text += " ";
							}
						}
						break;
					case 5:
						text += "ETX ";
						num = 6;
						break;
					case 6:
					{
						int num6 = (int)Comunicacao.Buffer_Log[i];
						text = text + "CRC F=" + Conversion.Hex(num6) + " ";
						byte b2 = this.Calcula_Chksum(ini, i);
						text = string.Concat(new string[]
						{
							text,
							"CRC C=",
							Conversion.Hex(b2),
							" ",
							Environment.NewLine,
							Environment.NewLine
						});
						num = 0;
						break;
					}
					}
				}
				string text2 = DateAndTime.Now.Year.ToString() + DateAndTime.Now.Month.ToString("D2") + DateAndTime.Now.Day.ToString("D2");
				if (this.cb_disco.Checked)
				{
					if (Operators.CompareString(text2, DateAndTime.Now.Year.ToString() + DateAndTime.Now.Month.ToString("D2") + DateAndTime.Now.Day.ToString("D2"), false) != 0)
					{
						text2 = DateAndTime.Now.Year.ToString() + DateAndTime.Now.Month.ToString("D2") + DateAndTime.Now.Day.ToString("D2");
					}
					Comunicacao.Ctrl_Log.arquivo = text2 + ".log";
					if (Operators.CompareString(Comunicacao.Ctrl_Log.diretorio, "", false) == 0)
					{
						Comunicacao.Ctrl_Log.diretorio = AppDomain.CurrentDomain.BaseDirectory;
						this.tb_diretorio.Text = Comunicacao.Ctrl_Log.diretorio;
						this.FolderBrowserDialog1.SelectedPath = Comunicacao.Ctrl_Log.diretorio;
						Application.DoEvents();
					}
					if (!File.Exists(Comunicacao.Ctrl_Log.diretorio + Comunicacao.Ctrl_Log.arquivo))
					{
						using (StreamWriter streamWriter = File.CreateText(Comunicacao.Ctrl_Log.diretorio + "\\" + Comunicacao.Ctrl_Log.arquivo))
						{
							streamWriter.WriteLine(text);
							streamWriter.Flush();
							streamWriter.Close();
													}
					}
					using (StreamWriter streamWriter2 = File.AppendText(Comunicacao.Ctrl_Log.diretorio + "\\" + Comunicacao.Ctrl_Log.arquivo))
					{
						streamWriter2.WriteLine(text);
						streamWriter2.Flush();
						streamWriter2.Close();
					}
				}
				IL_586:
				return text + Environment.NewLine;
			}
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x00424450 File Offset: 0x00422850
		public byte Calcula_Chksum(int ini, int fim)
		{
			int num = 0;
			checked
			{
				int num2 = fim - 1;
				for (int i = ini; i <= num2; i++)
				{
					num += (int)Comunicacao.Buffer_Log[i];
				}
				num %= 256;
				return (byte)num;
			}
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x00424488 File Offset: 0x00422888
		private void MontaLog()
		{
			string text = DateAndTime.Now.Year.ToString() + DateAndTime.Now.Month.ToString("D2") + DateAndTime.Now.Day.ToString("D2");
			string text2 = "*" + Comunicacao.Ctrl_Log.inicio.ToString() + Environment.NewLine;
			text2 = text2 + "&" + Comunicacao.Ctrl_Log.bytes_recv.ToString() + Environment.NewLine;
			text2 += "@";
			int num = 0;
			checked
			{
				int num2 = Comunicacao.Ctrl_Log.bytes_recv - 1;
				for (int i = num; i <= num2; i++)
				{
					text2 = text2 + Conversion.Hex(Comunicacao.Buffer_Log[i]) + " ";
				}
				text2 += Environment.NewLine;
				this.TextBox1.AppendText(text2);
				if (this.cb_disco.Checked)
				{
					if (Operators.CompareString(text, DateAndTime.Now.Year.ToString() + DateAndTime.Now.Month.ToString("D2") + DateAndTime.Now.Day.ToString("D2"), false) != 0)
					{
						text = DateAndTime.Now.Year.ToString() + DateAndTime.Now.Month.ToString("D2") + DateAndTime.Now.Day.ToString("D2");
					}
					Comunicacao.Ctrl_Log.arquivo = text + ".log";
					if (Operators.CompareString(Comunicacao.Ctrl_Log.diretorio, "", false) == 0)
					{
						Comunicacao.Ctrl_Log.diretorio = AppDomain.CurrentDomain.BaseDirectory;
						this.tb_diretorio.Text = Comunicacao.Ctrl_Log.diretorio;
						this.FolderBrowserDialog1.SelectedPath = Comunicacao.Ctrl_Log.diretorio;
						Application.DoEvents();
					}
					if (!File.Exists(Comunicacao.Ctrl_Log.diretorio + Comunicacao.Ctrl_Log.arquivo))
					{
						using (StreamWriter streamWriter = File.CreateText(Comunicacao.Ctrl_Log.diretorio + "\\" + Comunicacao.Ctrl_Log.arquivo))
						{
							streamWriter.WriteLine(text2);
							streamWriter.Flush();
							streamWriter.Close();
							return;
						}
					}
					using (StreamWriter streamWriter2 = File.AppendText(Comunicacao.Ctrl_Log.diretorio + "\\" + Comunicacao.Ctrl_Log.arquivo))
					{
						streamWriter2.WriteLine(text2);
						streamWriter2.Flush();
						streamWriter2.Close();
					}
				}
			}
		}

		// Token: 0x04001BE3 RID: 7139
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04001BE4 RID: 7140
		[AccessedThroughProperty("cb_disco")]
		private CheckBox _cb_disco;

		// Token: 0x04001BE5 RID: 7141
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001BE6 RID: 7142
		[AccessedThroughProperty("tb_diretorio")]
		private TextBox _tb_diretorio;

		// Token: 0x04001BE7 RID: 7143
		[AccessedThroughProperty("FolderBrowserDialog1")]
		private FolderBrowserDialog _FolderBrowserDialog1;

		// Token: 0x04001BE8 RID: 7144
		[AccessedThroughProperty("bt_diretorio")]
		private Button _bt_diretorio;

		// Token: 0x04001BE9 RID: 7145
		[AccessedThroughProperty("bt_inicia")]
		private Button _bt_inicia;

		// Token: 0x04001BEA RID: 7146
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04001BEB RID: 7147
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04001BEC RID: 7148
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04001BED RID: 7149
		[AccessedThroughProperty("cb_corsan")]
		private CheckBox _cb_corsan;

		// Token: 0x04001BEE RID: 7150
		private const int BLACK = 0;

		// Token: 0x04001BEF RID: 7151
		private const int RED = 1;

		// Token: 0x04001BF0 RID: 7152
		private const int BLUE = 2;

		// Token: 0x04001BF1 RID: 7153
		private const int GREEN = 3;
	}
}
