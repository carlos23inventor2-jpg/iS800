using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800.My
{
	// Token: 0x020000A9 RID: 169
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
	[CompilerGenerated]
	[EditorBrowsable(2)]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x060027DB RID: 10203 RVA: 0x00424AAC File Offset: 0x00422EAC
		[EditorBrowsable(2)]
		[DebuggerNonUserCode]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x00424AC4 File Offset: 0x00422EC4
		public static MySettings Default
		{
			get
			{
				if (!MySettings.addedHandler)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.addedHandler)
						{
							MyProject.Application.Shutdown += new ShutdownEventHandler(MySettings.AutoSaveSettings);
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x04001BF7 RID: 7159
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x04001BF8 RID: 7160
		private static bool addedHandler;

		// Token: 0x04001BF9 RID: 7161
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
