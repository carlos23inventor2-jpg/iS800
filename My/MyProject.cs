using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800.My
{
	// Token: 0x02000004 RID: 4
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[HideModuleName]
	[StandardModule]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00262574 File Offset: 0x00260974
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0026258C File Offset: 0x0026098C
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x002625A4 File Offset: 0x002609A4
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x002625BC File Offset: 0x002609BC
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x002625D4 File Offset: 0x002609D4
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000004 RID: 4
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000005 RID: 5
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x02000005 RID: 5
		[EditorBrowsable((System.ComponentModel.EditorBrowsableState)1)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600000B RID: 11 RVA: 0x002625EC File Offset: 0x002609EC
			// (set) Token: 0x06000036 RID: 54 RVA: 0x00262BF8 File Offset: 0x00260FF8
			public Abertura Abertura
			{
				get
				{
					this.m_Abertura = MyProject.MyForms.Create__Instance__<Abertura>(this.m_Abertura);
					return this.m_Abertura;
				}
				set
				{
					if (value == this.m_Abertura)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Abertura>(ref this.m_Abertura);
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600000C RID: 12 RVA: 0x00262610 File Offset: 0x00260A10
			// (set) Token: 0x06000037 RID: 55 RVA: 0x00262C20 File Offset: 0x00261020
			public Aguarde Aguarde
			{
				get
				{
					this.m_Aguarde = MyProject.MyForms.Create__Instance__<Aguarde>(this.m_Aguarde);
					return this.m_Aguarde;
				}
				set
				{
					if (value == this.m_Aguarde)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Aguarde>(ref this.m_Aguarde);
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600000D RID: 13 RVA: 0x00262634 File Offset: 0x00260A34
			// (set) Token: 0x06000038 RID: 56 RVA: 0x00262C48 File Offset: 0x00261048
			public Configuracao Configuracao
			{
				get
				{
					this.m_Configuracao = MyProject.MyForms.Create__Instance__<Configuracao>(this.m_Configuracao);
					return this.m_Configuracao;
				}
				set
				{
					if (value == this.m_Configuracao)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Configuracao>(ref this.m_Configuracao);
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600000E RID: 14 RVA: 0x00262658 File Offset: 0x00260A58
			// (set) Token: 0x06000039 RID: 57 RVA: 0x00262C70 File Offset: 0x00261070
			public Diretorios Diretorios
			{
				get
				{
					this.m_Diretorios = MyProject.MyForms.Create__Instance__<Diretorios>(this.m_Diretorios);
					return this.m_Diretorios;
				}
				set
				{
					if (value == this.m_Diretorios)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Diretorios>(ref this.m_Diretorios);
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x0600000F RID: 15 RVA: 0x0026267C File Offset: 0x00260A7C
			// (set) Token: 0x0600003A RID: 58 RVA: 0x00262C98 File Offset: 0x00261098
			public Discover Discover
			{
				get
				{
					this.m_Discover = MyProject.MyForms.Create__Instance__<Discover>(this.m_Discover);
					return this.m_Discover;
				}
				set
				{
					if (value == this.m_Discover)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Discover>(ref this.m_Discover);
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000010 RID: 16 RVA: 0x002626A0 File Offset: 0x00260AA0
			// (set) Token: 0x0600003B RID: 59 RVA: 0x00262CC0 File Offset: 0x002610C0
			public Equip_101_cal Equip_101_cal
			{
				get
				{
					this.m_Equip_101_cal = MyProject.MyForms.Create__Instance__<Equip_101_cal>(this.m_Equip_101_cal);
					return this.m_Equip_101_cal;
				}
				set
				{
					if (value == this.m_Equip_101_cal)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_101_cal>(ref this.m_Equip_101_cal);
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000011 RID: 17 RVA: 0x002626C4 File Offset: 0x00260AC4
			// (set) Token: 0x0600003C RID: 60 RVA: 0x00262CE8 File Offset: 0x002610E8
			public Equip_101_conf Equip_101_conf
			{
				get
				{
					this.m_Equip_101_conf = MyProject.MyForms.Create__Instance__<Equip_101_conf>(this.m_Equip_101_conf);
					return this.m_Equip_101_conf;
				}
				set
				{
					if (value == this.m_Equip_101_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_101_conf>(ref this.m_Equip_101_conf);
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000012 RID: 18 RVA: 0x002626E8 File Offset: 0x00260AE8
			// (set) Token: 0x0600003D RID: 61 RVA: 0x00262D10 File Offset: 0x00261110
			public Equip_101_mon Equip_101_mon
			{
				get
				{
					this.m_Equip_101_mon = MyProject.MyForms.Create__Instance__<Equip_101_mon>(this.m_Equip_101_mon);
					return this.m_Equip_101_mon;
				}
				set
				{
					if (value == this.m_Equip_101_mon)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_101_mon>(ref this.m_Equip_101_mon);
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000013 RID: 19 RVA: 0x0026270C File Offset: 0x00260B0C
			// (set) Token: 0x0600003E RID: 62 RVA: 0x00262D38 File Offset: 0x00261138
			public Equip_201_conf Equip_201_conf
			{
				get
				{
					this.m_Equip_201_conf = MyProject.MyForms.Create__Instance__<Equip_201_conf>(this.m_Equip_201_conf);
					return this.m_Equip_201_conf;
				}
				set
				{
					if (value == this.m_Equip_201_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_201_conf>(ref this.m_Equip_201_conf);
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000014 RID: 20 RVA: 0x00262730 File Offset: 0x00260B30
			// (set) Token: 0x0600003F RID: 63 RVA: 0x00262D60 File Offset: 0x00261160
			public Equip_201_mon Equip_201_mon
			{
				get
				{
					this.m_Equip_201_mon = MyProject.MyForms.Create__Instance__<Equip_201_mon>(this.m_Equip_201_mon);
					return this.m_Equip_201_mon;
				}
				set
				{
					if (value == this.m_Equip_201_mon)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_201_mon>(ref this.m_Equip_201_mon);
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000015 RID: 21 RVA: 0x00262754 File Offset: 0x00260B54
			// (set) Token: 0x06000040 RID: 64 RVA: 0x00262D88 File Offset: 0x00261188
			public Equip_202_cal Equip_202_cal
			{
				get
				{
					this.m_Equip_202_cal = MyProject.MyForms.Create__Instance__<Equip_202_cal>(this.m_Equip_202_cal);
					return this.m_Equip_202_cal;
				}
				set
				{
					if (value == this.m_Equip_202_cal)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_202_cal>(ref this.m_Equip_202_cal);
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000016 RID: 22 RVA: 0x00262778 File Offset: 0x00260B78
			// (set) Token: 0x06000041 RID: 65 RVA: 0x00262DB0 File Offset: 0x002611B0
			public Equip_202_conf Equip_202_conf
			{
				get
				{
					this.m_Equip_202_conf = MyProject.MyForms.Create__Instance__<Equip_202_conf>(this.m_Equip_202_conf);
					return this.m_Equip_202_conf;
				}
				set
				{
					if (value == this.m_Equip_202_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_202_conf>(ref this.m_Equip_202_conf);
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000017 RID: 23 RVA: 0x0026279C File Offset: 0x00260B9C
			// (set) Token: 0x06000042 RID: 66 RVA: 0x00262DD8 File Offset: 0x002611D8
			public Equip_202_mon Equip_202_mon
			{
				get
				{
					this.m_Equip_202_mon = MyProject.MyForms.Create__Instance__<Equip_202_mon>(this.m_Equip_202_mon);
					return this.m_Equip_202_mon;
				}
				set
				{
					if (value == this.m_Equip_202_mon)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_202_mon>(ref this.m_Equip_202_mon);
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000018 RID: 24 RVA: 0x002627C0 File Offset: 0x00260BC0
			// (set) Token: 0x06000043 RID: 67 RVA: 0x00262E00 File Offset: 0x00261200
			public Equip_302_conf Equip_302_conf
			{
				get
				{
					this.m_Equip_302_conf = MyProject.MyForms.Create__Instance__<Equip_302_conf>(this.m_Equip_302_conf);
					return this.m_Equip_302_conf;
				}
				set
				{
					if (value == this.m_Equip_302_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_302_conf>(ref this.m_Equip_302_conf);
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000019 RID: 25 RVA: 0x002627E4 File Offset: 0x00260BE4
			// (set) Token: 0x06000044 RID: 68 RVA: 0x00262E28 File Offset: 0x00261228
			public Equip_303_conf Equip_303_conf
			{
				get
				{
					this.m_Equip_303_conf = MyProject.MyForms.Create__Instance__<Equip_303_conf>(this.m_Equip_303_conf);
					return this.m_Equip_303_conf;
				}
				set
				{
					if (value == this.m_Equip_303_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_303_conf>(ref this.m_Equip_303_conf);
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x0600001A RID: 26 RVA: 0x00262808 File Offset: 0x00260C08
			// (set) Token: 0x06000045 RID: 69 RVA: 0x00262E50 File Offset: 0x00261250
			public Equip_590_conf Equip_590_conf
			{
				get
				{
					this.m_Equip_590_conf = MyProject.MyForms.Create__Instance__<Equip_590_conf>(this.m_Equip_590_conf);
					return this.m_Equip_590_conf;
				}
				set
				{
					if (value == this.m_Equip_590_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_590_conf>(ref this.m_Equip_590_conf);
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x0600001B RID: 27 RVA: 0x0026282C File Offset: 0x00260C2C
			// (set) Token: 0x06000046 RID: 70 RVA: 0x00262E78 File Offset: 0x00261278
			public Equip_810_mon Equip_810_mon
			{
				get
				{
					this.m_Equip_810_mon = MyProject.MyForms.Create__Instance__<Equip_810_mon>(this.m_Equip_810_mon);
					return this.m_Equip_810_mon;
				}
				set
				{
					if (value == this.m_Equip_810_mon)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_810_mon>(ref this.m_Equip_810_mon);
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600001C RID: 28 RVA: 0x00262850 File Offset: 0x00260C50
			// (set) Token: 0x06000047 RID: 71 RVA: 0x00262EA0 File Offset: 0x002612A0
			public Equip_820_mon Equip_820_mon
			{
				get
				{
					this.m_Equip_820_mon = MyProject.MyForms.Create__Instance__<Equip_820_mon>(this.m_Equip_820_mon);
					return this.m_Equip_820_mon;
				}
				set
				{
					if (value == this.m_Equip_820_mon)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_820_mon>(ref this.m_Equip_820_mon);
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600001D RID: 29 RVA: 0x00262874 File Offset: 0x00260C74
			// (set) Token: 0x06000048 RID: 72 RVA: 0x00262EC8 File Offset: 0x002612C8
			public Equip_821_mon Equip_821_mon
			{
				get
				{
					this.m_Equip_821_mon = MyProject.MyForms.Create__Instance__<Equip_821_mon>(this.m_Equip_821_mon);
					return this.m_Equip_821_mon;
				}
				set
				{
					if (value == this.m_Equip_821_mon)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_821_mon>(ref this.m_Equip_821_mon);
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x0600001E RID: 30 RVA: 0x00262898 File Offset: 0x00260C98
			// (set) Token: 0x06000049 RID: 73 RVA: 0x00262EF0 File Offset: 0x002612F0
			public Equip_VA210_conf Equip_VA210_conf
			{
				get
				{
					this.m_Equip_VA210_conf = MyProject.MyForms.Create__Instance__<Equip_VA210_conf>(this.m_Equip_VA210_conf);
					return this.m_Equip_VA210_conf;
				}
				set
				{
					if (value == this.m_Equip_VA210_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_VA210_conf>(ref this.m_Equip_VA210_conf);
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600001F RID: 31 RVA: 0x002628BC File Offset: 0x00260CBC
			// (set) Token: 0x0600004A RID: 74 RVA: 0x00262F18 File Offset: 0x00261318
			public Equip_VA220_conf Equip_VA220_conf
			{
				get
				{
					this.m_Equip_VA220_conf = MyProject.MyForms.Create__Instance__<Equip_VA220_conf>(this.m_Equip_VA220_conf);
					return this.m_Equip_VA220_conf;
				}
				set
				{
					if (value == this.m_Equip_VA220_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_VA220_conf>(ref this.m_Equip_VA220_conf);
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000020 RID: 32 RVA: 0x002628E0 File Offset: 0x00260CE0
			// (set) Token: 0x0600004B RID: 75 RVA: 0x00262F40 File Offset: 0x00261340
			public Equip_VA220_mon Equip_VA220_mon
			{
				get
				{
					this.m_Equip_VA220_mon = MyProject.MyForms.Create__Instance__<Equip_VA220_mon>(this.m_Equip_VA220_mon);
					return this.m_Equip_VA220_mon;
				}
				set
				{
					if (value == this.m_Equip_VA220_mon)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_VA220_mon>(ref this.m_Equip_VA220_mon);
				}
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000021 RID: 33 RVA: 0x00262904 File Offset: 0x00260D04
			// (set) Token: 0x0600004C RID: 76 RVA: 0x00262F68 File Offset: 0x00261368
			public Equip_VA220_ope Equip_VA220_ope
			{
				get
				{
					this.m_Equip_VA220_ope = MyProject.MyForms.Create__Instance__<Equip_VA220_ope>(this.m_Equip_VA220_ope);
					return this.m_Equip_VA220_ope;
				}
				set
				{
					if (value == this.m_Equip_VA220_ope)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_VA220_ope>(ref this.m_Equip_VA220_ope);
				}
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000022 RID: 34 RVA: 0x00262928 File Offset: 0x00260D28
			// (set) Token: 0x0600004D RID: 77 RVA: 0x00262F90 File Offset: 0x00261390
			public Equip_VA230_conf Equip_VA230_conf
			{
				get
				{
					this.m_Equip_VA230_conf = MyProject.MyForms.Create__Instance__<Equip_VA230_conf>(this.m_Equip_VA230_conf);
					return this.m_Equip_VA230_conf;
				}
				set
				{
					if (value == this.m_Equip_VA230_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Equip_VA230_conf>(ref this.m_Equip_VA230_conf);
				}
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000023 RID: 35 RVA: 0x0026294C File Offset: 0x00260D4C
			// (set) Token: 0x0600004E RID: 78 RVA: 0x00262FB8 File Offset: 0x002613B8
			public GC_82x_calib GC_82x_calib
			{
				get
				{
					this.m_GC_82x_calib = MyProject.MyForms.Create__Instance__<GC_82x_calib>(this.m_GC_82x_calib);
					return this.m_GC_82x_calib;
				}
				set
				{
					if (value == this.m_GC_82x_calib)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<GC_82x_calib>(ref this.m_GC_82x_calib);
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000024 RID: 36 RVA: 0x00262970 File Offset: 0x00260D70
			// (set) Token: 0x0600004F RID: 79 RVA: 0x00262FE0 File Offset: 0x002613E0
			public GC_82x_conf GC_82x_conf
			{
				get
				{
					this.m_GC_82x_conf = MyProject.MyForms.Create__Instance__<GC_82x_conf>(this.m_GC_82x_conf);
					return this.m_GC_82x_conf;
				}
				set
				{
					if (value == this.m_GC_82x_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<GC_82x_conf>(ref this.m_GC_82x_conf);
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000025 RID: 37 RVA: 0x00262994 File Offset: 0x00260D94
			// (set) Token: 0x06000050 RID: 80 RVA: 0x00263008 File Offset: 0x00261408
			public IEC_855_conf IEC_855_conf
			{
				get
				{
					this.m_IEC_855_conf = MyProject.MyForms.Create__Instance__<IEC_855_conf>(this.m_IEC_855_conf);
					return this.m_IEC_855_conf;
				}
				set
				{
					if (value == this.m_IEC_855_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<IEC_855_conf>(ref this.m_IEC_855_conf);
				}
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x06000026 RID: 38 RVA: 0x002629B8 File Offset: 0x00260DB8
			// (set) Token: 0x06000051 RID: 81 RVA: 0x00263030 File Offset: 0x00261430
			public IER_856_conf IER_856_conf
			{
				get
				{
					this.m_IER_856_conf = MyProject.MyForms.Create__Instance__<IER_856_conf>(this.m_IER_856_conf);
					return this.m_IER_856_conf;
				}
				set
				{
					if (value == this.m_IER_856_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<IER_856_conf>(ref this.m_IER_856_conf);
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x06000027 RID: 39 RVA: 0x002629DC File Offset: 0x00260DDC
			// (set) Token: 0x06000052 RID: 82 RVA: 0x00263058 File Offset: 0x00261458
			public LogComunicacao LogComunicacao
			{
				get
				{
					this.m_LogComunicacao = MyProject.MyForms.Create__Instance__<LogComunicacao>(this.m_LogComunicacao);
					return this.m_LogComunicacao;
				}
				set
				{
					if (value == this.m_LogComunicacao)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<LogComunicacao>(ref this.m_LogComunicacao);
				}
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x06000028 RID: 40 RVA: 0x00262A00 File Offset: 0x00260E00
			// (set) Token: 0x06000053 RID: 83 RVA: 0x00263080 File Offset: 0x00261480
			public Logo Logo
			{
				get
				{
					this.m_Logo = MyProject.MyForms.Create__Instance__<Logo>(this.m_Logo);
					return this.m_Logo;
				}
				set
				{
					if (value == this.m_Logo)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Logo>(ref this.m_Logo);
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000029 RID: 41 RVA: 0x00262A24 File Offset: 0x00260E24
			// (set) Token: 0x06000054 RID: 84 RVA: 0x002630A8 File Offset: 0x002614A8
			public Plataforma Plataforma
			{
				get
				{
					this.m_Plataforma = MyProject.MyForms.Create__Instance__<Plataforma>(this.m_Plataforma);
					return this.m_Plataforma;
				}
				set
				{
					if (value == this.m_Plataforma)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Plataforma>(ref this.m_Plataforma);
				}
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x0600002A RID: 42 RVA: 0x00262A48 File Offset: 0x00260E48
			// (set) Token: 0x06000055 RID: 85 RVA: 0x002630D0 File Offset: 0x002614D0
			public RT_810_200_conf RT_810_200_conf
			{
				get
				{
					this.m_RT_810_200_conf = MyProject.MyForms.Create__Instance__<RT_810_200_conf>(this.m_RT_810_200_conf);
					return this.m_RT_810_200_conf;
				}
				set
				{
					if (value == this.m_RT_810_200_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<RT_810_200_conf>(ref this.m_RT_810_200_conf);
				}
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x0600002B RID: 43 RVA: 0x00262A6C File Offset: 0x00260E6C
			// (set) Token: 0x06000056 RID: 86 RVA: 0x002630F8 File Offset: 0x002614F8
			public RT_810_conf RT_810_conf
			{
				get
				{
					this.m_RT_810_conf = MyProject.MyForms.Create__Instance__<RT_810_conf>(this.m_RT_810_conf);
					return this.m_RT_810_conf;
				}
				set
				{
					if (value == this.m_RT_810_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<RT_810_conf>(ref this.m_RT_810_conf);
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x0600002C RID: 44 RVA: 0x00262A90 File Offset: 0x00260E90
			// (set) Token: 0x06000057 RID: 87 RVA: 0x00263120 File Offset: 0x00261520
			public RT_820_200_conf RT_820_200_conf
			{
				get
				{
					this.m_RT_820_200_conf = MyProject.MyForms.Create__Instance__<RT_820_200_conf>(this.m_RT_820_200_conf);
					return this.m_RT_820_200_conf;
				}
				set
				{
					if (value == this.m_RT_820_200_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<RT_820_200_conf>(ref this.m_RT_820_200_conf);
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x0600002D RID: 45 RVA: 0x00262AB4 File Offset: 0x00260EB4
			// (set) Token: 0x06000058 RID: 88 RVA: 0x00263148 File Offset: 0x00261548
			public RT_820_360_conf RT_820_360_conf
			{
				get
				{
					this.m_RT_820_360_conf = MyProject.MyForms.Create__Instance__<RT_820_360_conf>(this.m_RT_820_360_conf);
					return this.m_RT_820_360_conf;
				}
				set
				{
					if (value == this.m_RT_820_360_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<RT_820_360_conf>(ref this.m_RT_820_360_conf);
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x0600002E RID: 46 RVA: 0x00262AD8 File Offset: 0x00260ED8
			// (set) Token: 0x06000059 RID: 89 RVA: 0x00263170 File Offset: 0x00261570
			public RT_820_400_SA_CALIB RT_820_400_SA_CALIB
			{
				get
				{
					this.m_RT_820_400_SA_CALIB = MyProject.MyForms.Create__Instance__<RT_820_400_SA_CALIB>(this.m_RT_820_400_SA_CALIB);
					return this.m_RT_820_400_SA_CALIB;
				}
				set
				{
					if (value == this.m_RT_820_400_SA_CALIB)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<RT_820_400_SA_CALIB>(ref this.m_RT_820_400_SA_CALIB);
				}
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600002F RID: 47 RVA: 0x00262AFC File Offset: 0x00260EFC
			// (set) Token: 0x0600005A RID: 90 RVA: 0x00263198 File Offset: 0x00261598
			public RT_820_conf RT_820_conf
			{
				get
				{
					this.m_RT_820_conf = MyProject.MyForms.Create__Instance__<RT_820_conf>(this.m_RT_820_conf);
					return this.m_RT_820_conf;
				}
				set
				{
					if (value == this.m_RT_820_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<RT_820_conf>(ref this.m_RT_820_conf);
				}
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x06000030 RID: 48 RVA: 0x00262B20 File Offset: 0x00260F20
			// (set) Token: 0x0600005B RID: 91 RVA: 0x002631C0 File Offset: 0x002615C0
			public RT_821_200_conf RT_821_200_conf
			{
				get
				{
					this.m_RT_821_200_conf = MyProject.MyForms.Create__Instance__<RT_821_200_conf>(this.m_RT_821_200_conf);
					return this.m_RT_821_200_conf;
				}
				set
				{
					if (value == this.m_RT_821_200_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<RT_821_200_conf>(ref this.m_RT_821_200_conf);
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000031 RID: 49 RVA: 0x00262B44 File Offset: 0x00260F44
			// (set) Token: 0x0600005C RID: 92 RVA: 0x002631E8 File Offset: 0x002615E8
			public RT_821_Conf RT_821_Conf
			{
				get
				{
					this.m_RT_821_Conf = MyProject.MyForms.Create__Instance__<RT_821_Conf>(this.m_RT_821_Conf);
					return this.m_RT_821_Conf;
				}
				set
				{
					if (value == this.m_RT_821_Conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<RT_821_Conf>(ref this.m_RT_821_Conf);
				}
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000032 RID: 50 RVA: 0x00262B68 File Offset: 0x00260F68
			// (set) Token: 0x0600005D RID: 93 RVA: 0x00263210 File Offset: 0x00261610
			public RT_830_200_configurador RT_830_200_configurador
			{
				get
				{
					this.m_RT_830_200_configurador = MyProject.MyForms.Create__Instance__<RT_830_200_configurador>(this.m_RT_830_200_configurador);
					return this.m_RT_830_200_configurador;
				}
				set
				{
					if (value == this.m_RT_830_200_configurador)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<RT_830_200_configurador>(ref this.m_RT_830_200_configurador);
				}
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000033 RID: 51 RVA: 0x00262B8C File Offset: 0x00260F8C
			// (set) Token: 0x0600005E RID: 94 RVA: 0x00263238 File Offset: 0x00261638
			public RT_831_200_configurador RT_831_200_configurador
			{
				get
				{
					this.m_RT_831_200_configurador = MyProject.MyForms.Create__Instance__<RT_831_200_configurador>(this.m_RT_831_200_configurador);
					return this.m_RT_831_200_configurador;
				}
				set
				{
					if (value == this.m_RT_831_200_configurador)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<RT_831_200_configurador>(ref this.m_RT_831_200_configurador);
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000034 RID: 52 RVA: 0x00262BB0 File Offset: 0x00260FB0
			// (set) Token: 0x0600005F RID: 95 RVA: 0x00263260 File Offset: 0x00261660
			public RT_850_conf RT_850_conf
			{
				get
				{
					this.m_RT_850_conf = MyProject.MyForms.Create__Instance__<RT_850_conf>(this.m_RT_850_conf);
					return this.m_RT_850_conf;
				}
				set
				{
					if (value == this.m_RT_850_conf)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<RT_850_conf>(ref this.m_RT_850_conf);
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x06000035 RID: 53 RVA: 0x00262BD4 File Offset: 0x00260FD4
			// (set) Token: 0x06000060 RID: 96 RVA: 0x00263288 File Offset: 0x00261688
			public Sobre Sobre
			{
				get
				{
					this.m_Sobre = MyProject.MyForms.Create__Instance__<Sobre>(this.m_Sobre);
					return this.m_Sobre;
				}
				set
				{
					if (value == this.m_Sobre)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<Sobre>(ref this.m_Sobre);
				}
			}

			// Token: 0x06000061 RID: 97 RVA: 0x002632B0 File Offset: 0x002616B0
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				if (Instance == null || Instance.IsDisposed)
				{
					if (MyProject.MyForms.m_FormBeingCreated != null)
					{
						if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						});
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
					return Instance;
				}
				return Instance;
			}

			// Token: 0x06000062 RID: 98 RVA: 0x002633BC File Offset: 0x002617BC
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x06000063 RID: 99 RVA: 0x002633E4 File Offset: 0x002617E4
			[EditorBrowsable((System.ComponentModel.EditorBrowsableState)1)]
			[DebuggerHidden]
			public MyForms()
			{
			}

			// Token: 0x06000064 RID: 100 RVA: 0x002633EC File Offset: 0x002617EC
			[EditorBrowsable((System.ComponentModel.EditorBrowsableState)1)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000065 RID: 101 RVA: 0x00263408 File Offset: 0x00261808
			[EditorBrowsable((System.ComponentModel.EditorBrowsableState)1)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000066 RID: 102 RVA: 0x0026341C File Offset: 0x0026181C
			[EditorBrowsable((System.ComponentModel.EditorBrowsableState)1)]
			internal Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x06000067 RID: 103 RVA: 0x00263434 File Offset: 0x00261834
			[EditorBrowsable((System.ComponentModel.EditorBrowsableState)1)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x04000006 RID: 6
			public Abertura m_Abertura;

			// Token: 0x04000007 RID: 7
			public Aguarde m_Aguarde;

			// Token: 0x04000008 RID: 8
			public Configuracao m_Configuracao;

			// Token: 0x04000009 RID: 9
			public Diretorios m_Diretorios;

			// Token: 0x0400000A RID: 10
			public Discover m_Discover;

			// Token: 0x0400000B RID: 11
			public Equip_101_cal m_Equip_101_cal;

			// Token: 0x0400000C RID: 12
			public Equip_101_conf m_Equip_101_conf;

			// Token: 0x0400000D RID: 13
			public Equip_101_mon m_Equip_101_mon;

			// Token: 0x0400000E RID: 14
			public Equip_201_conf m_Equip_201_conf;

			// Token: 0x0400000F RID: 15
			public Equip_201_mon m_Equip_201_mon;

			// Token: 0x04000010 RID: 16
			public Equip_202_cal m_Equip_202_cal;

			// Token: 0x04000011 RID: 17
			public Equip_202_conf m_Equip_202_conf;

			// Token: 0x04000012 RID: 18
			public Equip_202_mon m_Equip_202_mon;

			// Token: 0x04000013 RID: 19
			public Equip_302_conf m_Equip_302_conf;

			// Token: 0x04000014 RID: 20
			public Equip_303_conf m_Equip_303_conf;

			// Token: 0x04000015 RID: 21
			public Equip_590_conf m_Equip_590_conf;

			// Token: 0x04000016 RID: 22
			public Equip_810_mon m_Equip_810_mon;

			// Token: 0x04000017 RID: 23
			public Equip_820_mon m_Equip_820_mon;

			// Token: 0x04000018 RID: 24
			public Equip_821_mon m_Equip_821_mon;

			// Token: 0x04000019 RID: 25
			public Equip_VA210_conf m_Equip_VA210_conf;

			// Token: 0x0400001A RID: 26
			public Equip_VA220_conf m_Equip_VA220_conf;

			// Token: 0x0400001B RID: 27
			public Equip_VA220_mon m_Equip_VA220_mon;

			// Token: 0x0400001C RID: 28
			public Equip_VA220_ope m_Equip_VA220_ope;

			// Token: 0x0400001D RID: 29
			public Equip_VA230_conf m_Equip_VA230_conf;

			// Token: 0x0400001E RID: 30
			public GC_82x_calib m_GC_82x_calib;

			// Token: 0x0400001F RID: 31
			public GC_82x_conf m_GC_82x_conf;

			// Token: 0x04000020 RID: 32
			public IEC_855_conf m_IEC_855_conf;

			// Token: 0x04000021 RID: 33
			public IER_856_conf m_IER_856_conf;

			// Token: 0x04000022 RID: 34
			public LogComunicacao m_LogComunicacao;

			// Token: 0x04000023 RID: 35
			public Logo m_Logo;

			// Token: 0x04000024 RID: 36
			public Plataforma m_Plataforma;

			// Token: 0x04000025 RID: 37
			public RT_810_200_conf m_RT_810_200_conf;

			// Token: 0x04000026 RID: 38
			public RT_810_conf m_RT_810_conf;

			// Token: 0x04000027 RID: 39
			public RT_820_200_conf m_RT_820_200_conf;

			// Token: 0x04000028 RID: 40
			public RT_820_360_conf m_RT_820_360_conf;

			// Token: 0x04000029 RID: 41
			public RT_820_400_SA_CALIB m_RT_820_400_SA_CALIB;

			// Token: 0x0400002A RID: 42
			public RT_820_conf m_RT_820_conf;

			// Token: 0x0400002B RID: 43
			public RT_821_200_conf m_RT_821_200_conf;

			// Token: 0x0400002C RID: 44
			public RT_821_Conf m_RT_821_Conf;

			// Token: 0x0400002D RID: 45
			public RT_830_200_configurador m_RT_830_200_configurador;

			// Token: 0x0400002E RID: 46
			public RT_831_200_configurador m_RT_831_200_configurador;

			// Token: 0x0400002F RID: 47
			public RT_850_conf m_RT_850_conf;

			// Token: 0x04000030 RID: 48
			public Sobre m_Sobre;

			// Token: 0x04000031 RID: 49
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;
		}

		// Token: 0x02000006 RID: 6
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		[EditorBrowsable((System.ComponentModel.EditorBrowsableState)1)]
		internal sealed class MyWebServices
		{
			// Token: 0x06000068 RID: 104 RVA: 0x00263448 File Offset: 0x00261848
			[EditorBrowsable((System.ComponentModel.EditorBrowsableState)1)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000069 RID: 105 RVA: 0x00263464 File Offset: 0x00261864
			[DebuggerHidden]
			[EditorBrowsable((System.ComponentModel.EditorBrowsableState)1)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600006A RID: 106 RVA: 0x00263478 File Offset: 0x00261878
			[DebuggerHidden]
			[EditorBrowsable((System.ComponentModel.EditorBrowsableState)1)]
			internal Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x0600006B RID: 107 RVA: 0x00263490 File Offset: 0x00261890
			[DebuggerHidden]
			[EditorBrowsable((System.ComponentModel.EditorBrowsableState)1)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x0600006C RID: 108 RVA: 0x002634A4 File Offset: 0x002618A4
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				if (instance == null)
				{
					return Activator.CreateInstance<T>();
				}
				return instance;
			}

			// Token: 0x0600006D RID: 109 RVA: 0x002634C0 File Offset: 0x002618C0
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x0600006E RID: 110 RVA: 0x002634DC File Offset: 0x002618DC
			[DebuggerHidden]
			[EditorBrowsable((System.ComponentModel.EditorBrowsableState)1)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x02000007 RID: 7
		[EditorBrowsable((System.ComponentModel.EditorBrowsableState)1)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x17000031 RID: 49
			// (get) Token: 0x0600006F RID: 111 RVA: 0x002634E4 File Offset: 0x002618E4
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x06000070 RID: 112 RVA: 0x0026350C File Offset: 0x0026190C
			[EditorBrowsable((System.ComponentModel.EditorBrowsableState)1)]
			[DebuggerHidden]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x04000032 RID: 50
			[ThreadStatic]
			[CompilerGenerated]
			private static T m_ThreadStaticValue;
		}
	}
}
