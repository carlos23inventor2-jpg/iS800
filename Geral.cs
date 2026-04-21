using System.Windows.Forms;
using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x02000014 RID: 20
	[StandardModule]
	internal sealed class Geral
	{
		// Token: 0x060000F5 RID: 245
		[DllImport("Kernel32", CharSet = (System.Runtime.InteropServices.CharSet)4, SetLastError = true)]
		public static extern int GetPrivateProfileString([MarshalAs(34)] ref string lpAppName, [MarshalAs(34)] ref string lpKeyName, [MarshalAs(34)] ref string lpDefault, StringBuilder lpReturnedString, int nSize, [MarshalAs(34)] ref string lpFileName);

		// Token: 0x060000F6 RID: 246
		[DllImport("Kernel32", CharSet = (System.Runtime.InteropServices.CharSet)4, SetLastError = true)]
		public static extern int WritePrivateProfileString([MarshalAs(34)] ref string lpAppName, [MarshalAs(34)] ref string lpKeyName, [MarshalAs(34)] ref string lpString, [MarshalAs(34)] ref string lpFileName);

		// Token: 0x060000F7 RID: 247 RVA: 0x002221CC File Offset: 0x002205CC
		private static string LeArquivoINI(string file_name, string section_name, string key_name, string default_value)
		{
			StringBuilder stringBuilder = new StringBuilder(500);
			Geral.GetPrivateProfileString(ref section_name, ref key_name, ref default_value, stringBuilder, 500, ref file_name);
			return stringBuilder.ToString();
		}

		// Token: 0x040001E3 RID: 483
		public const int K_TIPO_EQUIPAMENTO_SEM_EQUIPAMENTO = 0;

		// Token: 0x040001E4 RID: 484
		public const int K_VERSAO_SEM = 0;

		// Token: 0x040001E5 RID: 485
		public const int K_VERSAO_300 = 30;

		// Token: 0x040001E6 RID: 486
		public const int K_VERSAO_360 = 36;

		// Token: 0x040001E7 RID: 487
		public const int K_VERSAO_200 = 20;

		// Token: 0x040001E8 RID: 488
		public const int K_VERSAO_400 = 40;

		// Token: 0x040001E9 RID: 489
		public const int K_TIPO_EQUIPAMENTO_RT_810 = 1000;

		// Token: 0x040001EA RID: 490
		public const int K_TIPO_EQUIPAMENTO_RT_820 = 2000;

		// Token: 0x040001EB RID: 491
		public const int K_TIPO_EQUIPAMENTO_RT_821 = 3000;

		// Token: 0x040001EC RID: 492
		public const int K_TIPO_EQUIPAMENTO_RT_850 = 4000;

		// Token: 0x040001ED RID: 493
		public const int K_TIPO_EQUIPAMENTO_RT_830 = 5000;

		// Token: 0x040001EE RID: 494
		public const int K_TIPO_EQUIPAMENTO_RT_831 = 6000;

		// Token: 0x040001EF RID: 495
		public const int K_TIPO_EQUIPAMENTO_GC_82x = 7000;

		// Token: 0x040001F0 RID: 496
		public const int K_TIPO_EQUIPAMENTO_IEC_855 = 8000;

		// Token: 0x040001F1 RID: 497
		public const int K_TIPO_EQUIPAMENTO_IER_856 = 9000;

		// Token: 0x040001F2 RID: 498
		public const int K_TIPO_OPERACAO_CONFIGURACAO = 100000;

		// Token: 0x040001F3 RID: 499
		public const int K_TIPO_OPERACAO_CALIBRACAO = 200000;

		// Token: 0x040001F4 RID: 500
		public const int K_TIPO_OPERACAO_MONITORACAO = 300000;

		// Token: 0x040001F5 RID: 501
		public const int K_RT_810_CONFIGURACAO = 101030;

		// Token: 0x040001F6 RID: 502
		public const int K_RT_820_CONFIGURACAO = 102030;

		// Token: 0x040001F7 RID: 503
		public const int K_GC_82x_CONFIGURACAO = 107030;

		// Token: 0x040001F8 RID: 504
		public const int K_RT_820_360_CONFIGURACAO = 102036;

		// Token: 0x040001F9 RID: 505
		public const int K_RT_820_400_CONFIGURACAO = 102040;

		// Token: 0x040001FA RID: 506
		public const int K_RT_821_CONFIGURACAO = 103030;

		// Token: 0x040001FB RID: 507
		public const int K_RT_850_CONFIGURACAO = 104030;

		// Token: 0x040001FC RID: 508
		public const int K_RT_810_200_CONFIGURACAO = 101020;

		// Token: 0x040001FD RID: 509
		public const int K_RT_820_200_CONFIGURACAO = 102020;

		// Token: 0x040001FE RID: 510
		public const int K_RT_821_200_CONFIGURACAO = 103020;

		// Token: 0x040001FF RID: 511
		public const int K_RT_830_CONFIGURACAO = 105020;

		// Token: 0x04000200 RID: 512
		public const int K_RT_831_CONFIGURACAO = 106020;

		// Token: 0x04000201 RID: 513
		public const int K_RT_810_CALIBRACAO = 201030;

		// Token: 0x04000202 RID: 514
		public const int K_RT_820_CALIBRACAO = 202030;

		// Token: 0x04000203 RID: 515
		public const int K_RT_821_CALIBRACAO = 203030;

		// Token: 0x04000204 RID: 516
		public const int K_GC_82x_CALIBRACAO = 207030;

		// Token: 0x04000205 RID: 517
		public const int K_IEC_855_CONFIGURACAO = 108030;

		// Token: 0x04000206 RID: 518
		public const int K_IER_856_CONFIGURACAO = 109030;

		// Token: 0x04000207 RID: 519
		public const int K_RT_810_MONITORACAO = 301030;

		// Token: 0x04000208 RID: 520
		public const int K_RT_820_MONITORACAO = 302030;

		// Token: 0x04000209 RID: 521
		public const int K_RT_820_400_MONITORACAO = 302040;

		// Token: 0x0400020A RID: 522
		public const int K_RT_821_MONITORACAO = 303030;

		// Token: 0x0400020B RID: 523
		public const int EQUIP_RT_810 = 810;

		// Token: 0x0400020C RID: 524
		public const int EQUIP_RT_820 = 820;

		// Token: 0x0400020D RID: 525
		public const int EQUIP_RT_821 = 821;

		// Token: 0x0400020E RID: 526
		public const int EQUIP_GC_82x = 824;

		// Token: 0x0400020F RID: 527
		public const int EQUIP_CT_830 = 830;

		// Token: 0x04000210 RID: 528
		public const int EQUIP_CT_831 = 831;

		// Token: 0x04000211 RID: 529
		public const int EQUIP_CT_850 = 850;

		// Token: 0x04000212 RID: 530
		public const int EQUIP_IEC_855 = 855;

		// Token: 0x04000213 RID: 531
		public const int EQUIP_IER_856 = 856;

		// Token: 0x04000214 RID: 532
		public const int EQUIP_VERSAO_4 = 4;

		// Token: 0x04000215 RID: 533
		public const int EQUIP_VERSAO_3 = 3;

		// Token: 0x04000216 RID: 534
		public const int EQUIP_VERSAO_2 = 2;

		// Token: 0x04000217 RID: 535
		public const int EQUIP_BUILD_0 = 0;

		// Token: 0x04000218 RID: 536
		public const int EQUIP_BUILD_10 = 10;

		// Token: 0x04000219 RID: 537
		public const int EQUIP_BUILD_20 = 20;

		// Token: 0x0400021A RID: 538
		public const int EQUIP_BUILD_60 = 60;

		// Token: 0x0400021B RID: 539
		public const int ORIGEM_DADO_DISCO = 1;

		// Token: 0x0400021C RID: 540
		public const int ORIGEM_DADO_SERIAL = 2;

		// Token: 0x0400021D RID: 541
		public static int Ctrl_equipamento;

		// Token: 0x0400021E RID: 542
		public static int Ctrl_versao;

		// Token: 0x0400021F RID: 543
		public static int Ctrl_operacao;

		// Token: 0x04000220 RID: 544
		public static int Ctrl_adicional;

		// Token: 0x04000221 RID: 545
		public static int Equipamento_selecionado;

		// Token: 0x04000222 RID: 546
		public static int Equipamento_versao;

		// Token: 0x04000223 RID: 547
		public static int Equipamento_build;

		// Token: 0x04000224 RID: 548
		public static string[] Buffer_ouvidor = new string[151];

		// Token: 0x04000225 RID: 549
		public static Geral.CONF_GERAL Config_geral;

		// Token: 0x04000226 RID: 550
		public const int MD101 = 1;

		// Token: 0x04000227 RID: 551
		public const int MD201 = 2;

		// Token: 0x04000228 RID: 552
		public const int MD202 = 3;

		// Token: 0x04000229 RID: 553
		public const int MD302 = 4;

		// Token: 0x0400022A RID: 554
		public const int MD303 = 5;

		// Token: 0x0400022B RID: 555
		public const int RT_810_200 = 30;

		// Token: 0x0400022C RID: 556
		public const string VERSAO_20 = "20";

		// Token: 0x0400022D RID: 557
		public const string VERSAO_21 = "21";

		// Token: 0x0400022E RID: 558
		public const string VERSAO_22 = "22";

		// Token: 0x0400022F RID: 559
		public const string VERSAO_23 = "23";

		// Token: 0x04000230 RID: 560
		public const string VERSAO_43 = "43";

		// Token: 0x04000231 RID: 561
		public const string VERSAO_50 = "50";

		// Token: 0x04000232 RID: 562
		public const string VERSAO_70 = "70";

		// Token: 0x04000233 RID: 563
		public const string VERSAO_810_10 = "810_10";

		// Token: 0x04000234 RID: 564
		public const string VERSAO_820_10 = "820_10";

		// Token: 0x04000235 RID: 565
		public const string VERSAO_821_10 = "821_10";

		// Token: 0x04000236 RID: 566
		public const int MOSTRA_RX = 1;

		// Token: 0x04000237 RID: 567
		public const int MOSTRA_TX = 2;

		// Token: 0x04000238 RID: 568
		public const int MOSTRA_LIMPA = 3;

		// Token: 0x04000239 RID: 569
		public const int MOSTRA_MSG = 4;

		// Token: 0x0400023A RID: 570
		public const int MOSTRA_RX_TIMEOUT = 5;

		// Token: 0x0400023B RID: 571
		public const int MOSTRA_RX_ERRO_CHK = 6;

		// Token: 0x0400023C RID: 572
		public const int MODO_INICIA = 1;

		// Token: 0x0400023D RID: 573
		public const int MODO_ACRESCENTA = 2;

		// Token: 0x0400023E RID: 574
		public const int MODO_LIMPA = 3;

		// Token: 0x0400023F RID: 575
		public const int TAMANHO_LINHAS_OUVIDOR = 150;

		// Token: 0x04000240 RID: 576
		public const int COM_OK = 1;

		// Token: 0x04000241 RID: 577
		public const int COM_TENTATIVA = 2;

		// Token: 0x04000242 RID: 578
		public const int COM_FALHA = 3;

		// Token: 0x02000015 RID: 21
		public struct CONF_GERAL
		{
			// Token: 0x04000243 RID: 579
			public int Largura_tela_trabalho;

			// Token: 0x04000244 RID: 580
			public int Largura_plataforma;

			// Token: 0x04000245 RID: 581
			public int Altura_plataforma;

			// Token: 0x04000246 RID: 582
			public int Largura_visualizador;

			// Token: 0x04000247 RID: 583
			public int Indice_buffer;

			// Token: 0x04000248 RID: 584
			public string texto_ouvidor;

			// Token: 0x04000249 RID: 585
			public int Modo;

			// Token: 0x0400024A RID: 586
			public bool Tarefa_em_andamento;

			// Token: 0x0400024B RID: 587
			public string Versao;

			// Token: 0x0400024C RID: 588
			public int Protocolo;

			// Token: 0x0400024D RID: 589
			public bool Porta_serial_Ok;
		}
	}
}
