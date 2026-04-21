using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x0200003D RID: 61
	public class IniFile
	{
		// Token: 0x06000ECB RID: 3787
		[DllImport("kernel32.dll", CharSet = (System.Runtime.InteropServices.CharSet)2, EntryPoint = "GetPrivateProfileStringA", ExactSpelling = true, SetLastError = true)]
		private static extern int GetPrivateProfileString([MarshalAs(34)] ref string AppName, [MarshalAs(34)] ref string KeyName, [MarshalAs(34)] ref string DefVal, StringBuilder RetVal, int Size, [MarshalAs(34)] ref string FileName);

		// Token: 0x06000ECC RID: 3788
		[DllImport("kernel32.dll", CharSet = (System.Runtime.InteropServices.CharSet)2, EntryPoint = "WritePrivateProfileStringA", ExactSpelling = true, SetLastError = true)]
		private static extern int WritePrivateProfileString([MarshalAs(34)] ref string AppName, [MarshalAs(34)] ref string KeyName, [MarshalAs(34)] ref string Value, [MarshalAs(34)] ref string FileName);

		// Token: 0x06000ECD RID: 3789 RVA: 0x0022B444 File Offset: 0x00229844
		public IniFile(string FileName)
		{
			this.ArquivoLogEscrita = ".\\LogW";
			this.ArquivoLogLeitura = ".\\LogR";
			this.AtivaLogEscrita = false;
			this.AtivaLogLeitura = false;
			this.IniFileName = FileName;
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0022B478 File Offset: 0x00229878
		public string ReadText(string Section, string Key, string DefValue)
		{
			StringBuilder stringBuilder = new StringBuilder(255);
			object obj = IniFile.GetPrivateProfileString(ref Section, ref Key, ref DefValue, stringBuilder, 255, ref this.IniFileName);
			string text = stringBuilder.ToString();
			if (this.AtivaLogLeitura)
			{
				StreamWriter streamWriter;
				if (File.Exists(this.ArquivoLogLeitura))
				{
					streamWriter = File.AppendText(this.ArquivoLogLeitura);
				}
				else
				{
					streamWriter = File.CreateText(this.ArquivoLogLeitura);
				}
				object ex = string.Format("[{0}] {1} = {2}", Section, Key, text);
				streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(ex));
				streamWriter.Flush();
				streamWriter.Close();
			}
			return Strings.Trim(Conversions.ToString(this.DecodeUTF8(text)));
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x0022B524 File Offset: 0x00229924
		public object DecodeUTF8(object s)
		{
			s = Operators.ConcatenateObject(s, " ");
			object obj = 1;
			while (Operators.ConditionalCompareObjectLessEqual(obj, Strings.Len(RuntimeHelpers.GetObjectValue(s)), false))
			{
				object ex = Strings.Asc(Strings.Mid(Conversions.ToString(s), Conversions.ToInteger(obj), 1));
				if (Conversions.ToBoolean(Operators.AndObject(ex, 128)))
				{
					object obj3 = 1;
					while (Operators.ConditionalCompareObjectLess(Operators.AddObject(obj, obj3), Strings.Len(RuntimeHelpers.GetObjectValue(s)), false) && (Strings.Asc(Strings.Mid(Conversions.ToString(s), Conversions.ToInteger(Operators.AddObject(obj, obj3)), 1)) & 192) == 128)
					{
						obj3 = Operators.AddObject(obj3, 1);
					}
					if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(obj3, 2, false), Operators.CompareObjectEqual(Operators.AndObject(ex, 224), 192, false))))
					{
						ex = Operators.AddObject(Strings.Asc(Strings.Mid(Conversions.ToString(s), Conversions.ToInteger(Operators.AddObject(obj, 1)), 1)), Operators.MultiplyObject(64, Operators.AndObject(ex, 1)));
					}
					else
					{
						ex = 191;
					}
					s = Strings.Left(Conversions.ToString(s), Conversions.ToInteger(Operators.SubtractObject(obj, 1))) + Conversions.ToString(Strings.Chr(Conversions.ToInteger(ex))) + Strings.Mid(Conversions.ToString(s), Conversions.ToInteger(Operators.AddObject(obj, obj3)));
				}
				obj = Operators.AddObject(obj, 1);
			}
			return RuntimeHelpers.GetObjectValue(s);
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0022B6E8 File Offset: 0x00229AE8
		public int ReadInteger(string Section, string Key, int DefValue)
		{
			StringBuilder stringBuilder = new StringBuilder(255);
			string text = Conversions.ToString(DefValue);
			object obj = IniFile.GetPrivateProfileString(ref Section, ref Key, ref text, stringBuilder, 255, ref this.IniFileName);
			if (this.AtivaLogLeitura)
			{
				StreamWriter streamWriter;
				if (File.Exists(this.ArquivoLogLeitura))
				{
					streamWriter = File.AppendText(this.ArquivoLogLeitura);
				}
				else
				{
					streamWriter = File.CreateText(this.ArquivoLogLeitura);
				}
				object ex = string.Format("[{0}] {1} = {2}", Section, Key, stringBuilder.ToString());
				streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(ex));
				streamWriter.Flush();
				streamWriter.Close();
			}
			return Convert.ToInt32(stringBuilder.ToString());
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0022B78C File Offset: 0x00229B8C
		public void WriteText(string Section, string Key, string Value)
		{
			IniFile.WritePrivateProfileString(ref Section, ref Key, ref Value, ref this.IniFileName);
			if (this.AtivaLogEscrita)
			{
				StreamWriter streamWriter;
				if (File.Exists(this.ArquivoLogEscrita))
				{
					streamWriter = File.AppendText(this.ArquivoLogEscrita);
				}
				else
				{
					streamWriter = File.CreateText(this.ArquivoLogEscrita);
				}
				object obj = string.Format("[{0}] {1} = {2}", Section, Key, Value);
				streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(obj));
				streamWriter.Flush();
				streamWriter.Close();
			}
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x0022B800 File Offset: 0x00229C00
		public void WriteInteger(string Section, string Key, int Value)
		{
			string text = Value.ToString();
			IniFile.WritePrivateProfileString(ref Section, ref Key, ref text, ref this.IniFileName);
			if (this.AtivaLogEscrita)
			{
				StreamWriter streamWriter;
				if (File.Exists(this.ArquivoLogEscrita))
				{
					streamWriter = File.AppendText(this.ArquivoLogEscrita);
				}
				else
				{
					streamWriter = File.CreateText(this.ArquivoLogEscrita);
				}
				object obj = string.Format("[{0}] {1} = {2}", Section, Key, Value);
				streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(obj));
				streamWriter.Flush();
				streamWriter.Close();
			}
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0022B884 File Offset: 0x00229C84
		public void RemoveSection(string Section)
		{
			string text = null;
			string text2 = null;
			IniFile.WritePrivateProfileString(ref Section, ref text, ref text2, ref this.IniFileName);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0022B8A8 File Offset: 0x00229CA8
		public void RemoveKey(string Section, string Key)
		{
			string text = null;
			IniFile.WritePrivateProfileString(ref Section, ref Key, ref text, ref this.IniFileName);
		}

		// Token: 0x04000858 RID: 2136
		private string IniFileName;

		// Token: 0x04000859 RID: 2137
		private string ArquivoLogEscrita;

		// Token: 0x0400085A RID: 2138
		private string ArquivoLogLeitura;

		// Token: 0x0400085B RID: 2139
		private bool AtivaLogEscrita;

		// Token: 0x0400085C RID: 2140
		private bool AtivaLogLeitura;
	}
}
