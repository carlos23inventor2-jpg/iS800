using System.Drawing;
using System.Windows.Forms;
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using iS800.My;
using iS800.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x02000011 RID: 17
	public partial class Configuracao : Form
	{
		// Token: 0x0600008D RID: 141 RVA: 0x0026374C File Offset: 0x00261B4C
		public Configuracao()
		{
			base.Load += new EventHandler(this.Configuracao_Load);
			base.Activated += new EventHandler(this.Configuracao_Activated);
			this.aguarda = false;
			this.InitializeComponent();
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00264548 File Offset: 0x00262948
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0026455C File Offset: 0x0026295C
		internal virtual GroupBox Grupo_com
		{
			get
			{
				return this._Grupo_com;
			}
			[MethodImpl(32)]
			set
			{
				this._Grupo_com = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00264568 File Offset: 0x00262968
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0026457C File Offset: 0x0026297C
		internal virtual ComboBox Combo_paridade
		{
			get
			{
				return this._Combo_paridade;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_paridade_SelectedIndexChanged);
				if (this._Combo_paridade != null)
				{
					this._Combo_paridade.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_paridade = value;
				if (this._Combo_paridade != null)
				{
					this._Combo_paridade.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000094 RID: 148 RVA: 0x002645C8 File Offset: 0x002629C8
		// (set) Token: 0x06000095 RID: 149 RVA: 0x002645DC File Offset: 0x002629DC
		internal virtual Label Label_paridade
		{
			get
			{
				return this._Label_paridade;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_paridade = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000096 RID: 150 RVA: 0x002645E8 File Offset: 0x002629E8
		// (set) Token: 0x06000097 RID: 151 RVA: 0x002645FC File Offset: 0x002629FC
		internal virtual ComboBox Combo_stop_bits
		{
			get
			{
				return this._Combo_stop_bits;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Combo_stop_bits_SelectedIndexChanged);
				if (this._Combo_stop_bits != null)
				{
					this._Combo_stop_bits.SelectedIndexChanged -= eventHandler;
				}
				this._Combo_stop_bits = value;
				if (this._Combo_stop_bits != null)
				{
					this._Combo_stop_bits.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00264648 File Offset: 0x00262A48
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0026465C File Offset: 0x00262A5C
		internal virtual Label Label_stop_bits
		{
			get
			{
				return this._Label_stop_bits;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_stop_bits = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00264668 File Offset: 0x00262A68
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0026467C File Offset: 0x00262A7C
		internal virtual ComboBox ComboNumeroBits
		{
			get
			{
				return this._ComboNumeroBits;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboNumeroBits_SelectedIndexChanged);
				if (this._ComboNumeroBits != null)
				{
					this._ComboNumeroBits.SelectedIndexChanged -= eventHandler;
				}
				this._ComboNumeroBits = value;
				if (this._ComboNumeroBits != null)
				{
					this._ComboNumeroBits.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600009C RID: 156 RVA: 0x002646C8 File Offset: 0x00262AC8
		// (set) Token: 0x0600009D RID: 157 RVA: 0x002646DC File Offset: 0x00262ADC
		internal virtual Label Label_bits
		{
			get
			{
				return this._Label_bits;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_bits = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600009E RID: 158 RVA: 0x002646E8 File Offset: 0x00262AE8
		// (set) Token: 0x0600009F RID: 159 RVA: 0x002646FC File Offset: 0x00262AFC
		internal virtual ComboBox ComboBaudrate
		{
			get
			{
				return this._ComboBaudrate;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBaudrate_SelectedIndexChanged);
				if (this._ComboBaudrate != null)
				{
					this._ComboBaudrate.SelectedIndexChanged -= eventHandler;
				}
				this._ComboBaudrate = value;
				if (this._ComboBaudrate != null)
				{
					this._ComboBaudrate.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00264748 File Offset: 0x00262B48
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0026475C File Offset: 0x00262B5C
		internal virtual Label Label_baudrate
		{
			get
			{
				return this._Label_baudrate;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_baudrate = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00264768 File Offset: 0x00262B68
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0026477C File Offset: 0x00262B7C
		internal virtual Label Label_porta
		{
			get
			{
				return this._Label_porta;
			}
			[MethodImpl(32)]
			set
			{
				this._Label_porta = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00264788 File Offset: 0x00262B88
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0026479C File Offset: 0x00262B9C
		internal virtual ComboBox ComboPortaSerial
		{
			get
			{
				return this._ComboPortaSerial;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboPortaSerial_SelectedIndexChanged);
				if (this._ComboPortaSerial != null)
				{
					this._ComboPortaSerial.SelectedIndexChanged -= eventHandler;
				}
				this._ComboPortaSerial = value;
				if (this._ComboPortaSerial != null)
				{
					this._ComboPortaSerial.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x002647E8 File Offset: 0x00262BE8
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x002647FC File Offset: 0x00262BFC
		internal virtual Button OK_Button
		{
			get
			{
				return this._OK_Button;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.OK_Button_Click);
				if (this._OK_Button != null)
				{
					this._OK_Button.Click -= eventHandler;
				}
				this._OK_Button = value;
				if (this._OK_Button != null)
				{
					this._OK_Button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00264848 File Offset: 0x00262C48
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0026485C File Offset: 0x00262C5C
		internal virtual GroupBox GroupBox_gerais
		{
			get
			{
				return this._GroupBox_gerais;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox_gerais = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00264868 File Offset: 0x00262C68
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0026487C File Offset: 0x00262C7C
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

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00264888 File Offset: 0x00262C88
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0026489C File Offset: 0x00262C9C
		internal virtual NumericUpDown NumericUpDown_retry
		{
			get
			{
				return this._NumericUpDown_retry;
			}
			[MethodImpl(32)]
			set
			{
				CancelEventHandler cancelEventHandler = new CancelEventHandler(this.NumericUpDown_retry_Validating);
				EventHandler eventHandler = new EventHandler(this.NumericUpDown_retry_ValueChanged);
				if (this._NumericUpDown_retry != null)
				{
					this._NumericUpDown_retry.Validating -= cancelEventHandler;
					this._NumericUpDown_retry.ValueChanged -= eventHandler;
				}
				this._NumericUpDown_retry = value;
				if (this._NumericUpDown_retry != null)
				{
					this._NumericUpDown_retry.Validating += cancelEventHandler;
					this._NumericUpDown_retry.ValueChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0026490C File Offset: 0x00262D0C
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00264920 File Offset: 0x00262D20
		internal virtual GroupBox GroupBox1
		{
			get
			{
				return this._GroupBox1;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0026492C File Offset: 0x00262D2C
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00264940 File Offset: 0x00262D40
		internal virtual TextBox tb_tcpip_Porta
		{
			get
			{
				return this._tb_tcpip_Porta;
			}
			[MethodImpl(32)]
			set
			{
				this._tb_tcpip_Porta = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0026494C File Offset: 0x00262D4C
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00264960 File Offset: 0x00262D60
		internal virtual TextBox tb_tcpip_IP
		{
			get
			{
				return this._tb_tcpip_IP;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.tb_tcpip_IP_TextChanged);
				if (this._tb_tcpip_IP != null)
				{
					this._tb_tcpip_IP.TextChanged -= eventHandler;
				}
				this._tb_tcpip_IP = value;
				if (this._tb_tcpip_IP != null)
				{
					this._tb_tcpip_IP.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x002649AC File Offset: 0x00262DAC
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x002649C0 File Offset: 0x00262DC0
		internal virtual Label Label3
		{
			get
			{
				return this._Label3;
			}
			[MethodImpl(32)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x002649CC File Offset: 0x00262DCC
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x002649E0 File Offset: 0x00262DE0
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

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x002649EC File Offset: 0x00262DEC
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00264A00 File Offset: 0x00262E00
		internal virtual GroupBox GroupBox2
		{
			get
			{
				return this._GroupBox2;
			}
			[MethodImpl(32)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00264A0C File Offset: 0x00262E0C
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00264A20 File Offset: 0x00262E20
		internal virtual ComboBox cb_tipo_interface
		{
			get
			{
				return this._cb_tipo_interface;
			}
			[MethodImpl(32)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cb_tipo_interface_SelectedIndexChanged);
				if (this._cb_tipo_interface != null)
				{
					this._cb_tipo_interface.SelectedIndexChanged -= eventHandler;
				}
				this._cb_tipo_interface = value;
				if (this._cb_tipo_interface != null)
				{
					this._cb_tipo_interface.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00264A6C File Offset: 0x00262E6C
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00264A80 File Offset: 0x00262E80
		internal virtual Label Label4
		{
			get
			{
				return this._Label4;
			}
			[MethodImpl(32)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00264A8C File Offset: 0x00262E8C
		private void OK_Button_Click(object sender, EventArgs e)
		{
			Comunicacao.Init_porta_serial();
			string text = FileSystem.CurDir();
			string text2 = text + "\\config.ini";
			if (File.Exists(text2))
			{
				if (File.Exists(text2 + ".old"))
				{
					File.Delete(text2 + ".old");
				}
				File.Move(text2, text2 + ".old");
			}
			IniFileWriteFast iniFileWriteFast = new IniFileWriteFast(text2);
			iniFileWriteFast.WriteSection("Interfaces");
			iniFileWriteFast.WriteKey("quantas", (int)OpenMode.Random);
			iniFileWriteFast.WriteKey("interface1", "Serial RS232");
			iniFileWriteFast.WriteKey("interface2", "Ethernet TCP/IP RS232");
			iniFileWriteFast.WriteKey("interface3", "ICTEL WIFI RS232");
			iniFileWriteFast.WriteKey("tipo_interface", Comunicacao.Config_sistema.tipo_interface);
			iniFileWriteFast.LineSpace();
			Application.DoEvents();
			iniFileWriteFast.WriteSection("Serial RS232");
			iniFileWriteFast.WriteKey("porta", Comunicacao.Config_sistema.Serial.Porta_serial);
			iniFileWriteFast.WriteKey("baudrate", Comunicacao.Config_sistema.Serial.Baudrate);
			iniFileWriteFast.WriteKey("data_bits", Comunicacao.Config_sistema.Serial.DataBits);
			iniFileWriteFast.WriteKey("stop_bits", Comunicacao.Config_sistema.Serial.StopBits);
			iniFileWriteFast.WriteKey("parity", Comunicacao.Config_sistema.Serial.Parity);
			iniFileWriteFast.LineSpace();
			Application.DoEvents();
			iniFileWriteFast.WriteSection("Ethernet TCP/IP RS232");
			iniFileWriteFast.WriteKey("ip", Comunicacao.Config_sistema.Tcpip.IP);
			iniFileWriteFast.WriteKey("porta", Comunicacao.Config_sistema.Tcpip.Porta);
			iniFileWriteFast.LineSpace();
			Application.DoEvents();
			iniFileWriteFast.WriteSection("Geral");
			iniFileWriteFast.WriteKey("retry", this.NumericUpDown_retry.Value.ToString());
			iniFileWriteFast.LineSpace();
			Application.DoEvents();
			iniFileWriteFast.CloseIniFileWriteFast();
			if (Comunicacao.Config_sistema.tipo_interface == 2)
			{
				MyProject.Forms.Plataforma.ToolStripButton_serial.Image = Resources.rj45_128x128;
			}
			else
			{
				MyProject.Forms.Plataforma.ToolStripButton_serial.Image = Resources.DB9_128;
			}
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00264CC4 File Offset: 0x002630C4
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00264CD4 File Offset: 0x002630D4
		private void Configuracao_Load(object sender, EventArgs e)
		{
			checked
			{
				Point point = new Point();
				point.X = MyProject.Forms.Plataforma.Location.X + 200;
				point.Y = MyProject.Forms.Plataforma.Location.Y + 50;
				this.cb_tipo_interface.Items.Clear();
				this.cb_tipo_interface.Items.Add("Serial RS232");
				this.cb_tipo_interface.Items.Add("Ethernet TCP/IP RS232");
				this.cb_tipo_interface.SelectedIndex = Comunicacao.Config_sistema.tipo_interface - 1;
				this.ComboPortaSerial.Items.Clear();
				try
				{
					foreach (string text in MyProject.Computer.Ports.SerialPortNames)
					{
						this.ComboPortaSerial.Items.Add(text);
					}
				}
				finally
				{
					IEnumerator<string> enumerator = null;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				this.ComboPortaSerial.Text = Comunicacao.Config_sistema.Serial.Porta_serial;
				this.ComboBaudrate.Items.Clear();
				this.ComboBaudrate.Items.Add("1200");
				this.ComboBaudrate.Items.Add("2400");
				this.ComboBaudrate.Items.Add("4800");
				this.ComboBaudrate.Items.Add("9600");
				this.ComboBaudrate.Items.Add("19200");
				this.ComboBaudrate.Items.Add("38400");
				switch (Comunicacao.Config_sistema.Serial.Baudrate)
				{
				case 0:
					this.ComboBaudrate.Text = "1200";
					break;
				case 1:
					this.ComboBaudrate.Text = "2400";
					break;
				case 2:
					this.ComboBaudrate.Text = "4800";
					break;
				case 3:
					this.ComboBaudrate.Text = "9600";
					break;
				case 4:
					this.ComboBaudrate.Text = "19200";
					break;
				case 5:
					this.ComboBaudrate.Text = "38400";
					break;
				}
				this.ComboNumeroBits.Items.Clear();
				this.ComboNumeroBits.Items.Add("4 bits");
				this.ComboNumeroBits.Items.Add("5 bits");
				this.ComboNumeroBits.Items.Add("6 bits");
				this.ComboNumeroBits.Items.Add("7 bits");
				this.ComboNumeroBits.Items.Add("8 bits");
				switch (Comunicacao.Config_sistema.Serial.DataBits)
				{
				case 0:
					this.ComboNumeroBits.Text = "4 bits";
					break;
				case 1:
					this.ComboNumeroBits.Text = "5 bits";
					break;
				case 2:
					this.ComboNumeroBits.Text = "6 bits";
					break;
				case 3:
					this.ComboNumeroBits.Text = "7 bits";
					break;
				case 4:
					this.ComboNumeroBits.Text = "8 bits";
					break;
				}
				this.Combo_stop_bits.Items.Clear();
				this.Combo_stop_bits.Items.Add("None");
				this.Combo_stop_bits.Items.Add("1 bit");
				this.Combo_stop_bits.Items.Add("2 bits ");
				this.Combo_stop_bits.Items.Add("1,5 bits");
				switch (Comunicacao.Config_sistema.Serial.StopBits)
				{
				case 0:
					this.Combo_stop_bits.Text = "None";
					break;
				case 1:
					this.Combo_stop_bits.Text = "1 bit";
					break;
				case 2:
					this.Combo_stop_bits.Text = "2 bits";
					break;
				case 3:
					this.Combo_stop_bits.Text = "1,5 bits";
					break;
				}
				this.Combo_paridade.Items.Clear();
				this.Combo_paridade.Items.Add("Sem paridade");
				this.Combo_paridade.Items.Add("Impar");
				this.Combo_paridade.Items.Add("Par");
				this.Combo_paridade.Items.Add("Mark");
				this.Combo_paridade.Items.Add("Space");
				switch (Comunicacao.Config_sistema.Serial.Parity)
				{
				case 0:
					this.Combo_paridade.Text = "Sem paridade";
					break;
				case 1:
					this.Combo_paridade.Text = "Impar";
					break;
				case 2:
					this.Combo_paridade.Text = "Par";
					break;
				case 3:
					this.Combo_paridade.Text = "Mark";
					break;
				case 4:
					this.Combo_paridade.Text = "Space";
					break;
				}
				this.NumericUpDown_retry.Value = Conversions.ToDecimal(Comunicacao.Config_sistema.Retry);
				this.tb_tcpip_IP.Text = Comunicacao.Config_sistema.Tcpip.IP;
				this.tb_tcpip_Porta.Text = Comunicacao.Config_sistema.Tcpip.Porta.ToString();
				this.aguarda = true;
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00265254 File Offset: 0x00263654
		private void ComboPortaSerial_SelectedIndexChanged(object sender, EventArgs e)
		{
			Comunicacao.Config_sistema.Serial.Porta_serial = Conversions.ToString(NewLateBinding.LateGet(sender, null, "SelectedItem", new object[0], null, null, null));
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00265280 File Offset: 0x00263680
		private void ComboBaudrate_SelectedIndexChanged(object sender, EventArgs e)
		{
			Comunicacao.Config_sistema.Serial.Baudrate = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x002652AC File Offset: 0x002636AC
		private void ComboNumeroBits_SelectedIndexChanged(object sender, EventArgs e)
		{
			Comunicacao.Config_sistema.Serial.DataBits = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x002652D8 File Offset: 0x002636D8
		private void Combo_stop_bits_SelectedIndexChanged(object sender, EventArgs e)
		{
			Comunicacao.Config_sistema.Serial.StopBits = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00265304 File Offset: 0x00263704
		private void Combo_paridade_SelectedIndexChanged(object sender, EventArgs e)
		{
			Comunicacao.Config_sistema.Serial.Parity = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null));
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00265330 File Offset: 0x00263730
		private void NumericUpDown_retry_ValueChanged(object sender, EventArgs e)
		{
			if (this.aguarda)
			{
				Comunicacao.Config_sistema.Retry = Conversions.ToInteger(NewLateBinding.LateGet(sender, null, "Value", new object[0], null, null, null)).ToString();
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00265374 File Offset: 0x00263774
		private void NumericUpDown_retry_Validating(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00265378 File Offset: 0x00263778
		private void Configuracao_Activated(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0026537C File Offset: 0x0026377C
		private void cb_tipo_interface_SelectedIndexChanged(object sender, EventArgs e)
		{
			Comunicacao.Config_sistema.tipo_interface = Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(sender, null, "SelectedIndex", new object[0], null, null, null), OpenMode.Input));
		}

		// Token: 0x060000CA RID: 202 RVA: 0x002653B0 File Offset: 0x002637B0
		private void tb_tcpip_IP_TextChanged(object sender, EventArgs e)
		{
			Comunicacao.Config_sistema.Tcpip.IP = Conversions.ToString(NewLateBinding.LateGet(sender, null, "Text", new object[0], null, null, null));
		}

		// Token: 0x040001B6 RID: 438
		[AccessedThroughProperty("Grupo_com")]
		private GroupBox _Grupo_com;

		// Token: 0x040001B7 RID: 439
		[AccessedThroughProperty("Combo_paridade")]
		private ComboBox _Combo_paridade;

		// Token: 0x040001B8 RID: 440
		[AccessedThroughProperty("Label_paridade")]
		private Label _Label_paridade;

		// Token: 0x040001B9 RID: 441
		[AccessedThroughProperty("Combo_stop_bits")]
		private ComboBox _Combo_stop_bits;

		// Token: 0x040001BA RID: 442
		[AccessedThroughProperty("Label_stop_bits")]
		private Label _Label_stop_bits;

		// Token: 0x040001BB RID: 443
		[AccessedThroughProperty("ComboNumeroBits")]
		private ComboBox _ComboNumeroBits;

		// Token: 0x040001BC RID: 444
		[AccessedThroughProperty("Label_bits")]
		private Label _Label_bits;

		// Token: 0x040001BD RID: 445
		[AccessedThroughProperty("ComboBaudrate")]
		private ComboBox _ComboBaudrate;

		// Token: 0x040001BE RID: 446
		[AccessedThroughProperty("Label_baudrate")]
		private Label _Label_baudrate;

		// Token: 0x040001BF RID: 447
		[AccessedThroughProperty("Label_porta")]
		private Label _Label_porta;

		// Token: 0x040001C0 RID: 448
		[AccessedThroughProperty("ComboPortaSerial")]
		private ComboBox _ComboPortaSerial;

		// Token: 0x040001C1 RID: 449
		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		// Token: 0x040001C2 RID: 450
		[AccessedThroughProperty("GroupBox_gerais")]
		private GroupBox _GroupBox_gerais;

		// Token: 0x040001C3 RID: 451
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040001C4 RID: 452
		[AccessedThroughProperty("NumericUpDown_retry")]
		private NumericUpDown _NumericUpDown_retry;

		// Token: 0x040001C5 RID: 453
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x040001C6 RID: 454
		[AccessedThroughProperty("tb_tcpip_Porta")]
		private TextBox _tb_tcpip_Porta;

		// Token: 0x040001C7 RID: 455
		[AccessedThroughProperty("tb_tcpip_IP")]
		private TextBox _tb_tcpip_IP;

		// Token: 0x040001C8 RID: 456
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040001C9 RID: 457
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040001CA RID: 458
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x040001CB RID: 459
		[AccessedThroughProperty("cb_tipo_interface")]
		private ComboBox _cb_tipo_interface;

		// Token: 0x040001CC RID: 460
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040001CD RID: 461
		private bool aguarda;
	}
}
