using System;
using System.IO;
using System.Windows.Forms;

namespace iS800
{
	// Token: 0x0200003E RID: 62
	internal class IniFileWriteFast
	{
		// Token: 0x06000ED5 RID: 3797 RVA: 0x0022B8CC File Offset: 0x00229CCC
		public IniFileWriteFast(string FileName)
		{
			this.IniFileName = FileName;
			this.sw = File.CreateText(this.IniFileName);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0022B8EC File Offset: 0x00229CEC
		public void WriteSection(string Section)
		{
			this.txt = string.Format("[{0}]", Section);
			this.sw.WriteLine(this.txt);
			this.sw.Flush();
			Application.DoEvents();
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0022B920 File Offset: 0x00229D20
		public void WriteKey(string Key, int Value)
		{
			this.txt = string.Format("{0} = {1}", Key, Value);
			this.sw.WriteLine(this.txt);
			this.sw.Flush();
			Application.DoEvents();
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0022B95C File Offset: 0x00229D5C
		public void WriteKey(string Key, string Value)
		{
			this.txt = string.Format("{0} = {1}", Key, Value);
			this.sw.WriteLine(this.txt);
			this.sw.Flush();
			Application.DoEvents();
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0022B994 File Offset: 0x00229D94
		public void LineSpace()
		{
			this.txt = " ";
			this.sw.WriteLine(this.txt);
			this.sw.Flush();
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0022B9C0 File Offset: 0x00229DC0
		public void CloseIniFileWriteFast()
		{
			this.sw.Close();
			Application.DoEvents();
		}

		// Token: 0x0400085D RID: 2141
		private string IniFileName;

		// Token: 0x0400085E RID: 2142
		private StreamWriter sw;

		// Token: 0x0400085F RID: 2143
		private string txt;
	}
}
