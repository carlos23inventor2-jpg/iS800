using System;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x0200001E RID: 30
	[StandardModule]
	internal sealed class RT_830_200_variaveis_X
	{
		// Token: 0x0400036D RID: 877
		public static RT_830_200_variaveis_X.DADOS_RT_830_200_CONFIG RT_830_200_BD;

		// Token: 0x0200001F RID: 31
		public struct FIRMWARE_RT_830_200
		{
			// Token: 0x0400036E RID: 878
			public RT_geral.Integer_ictel Equip;

			// Token: 0x0400036F RID: 879
			public RT_geral.Integer_ictel Versao;

			// Token: 0x04000370 RID: 880
			public RT_geral.Integer_ictel Build;

			// Token: 0x04000371 RID: 881
			public RT_geral.Integer_ictel Release;
		}

		// Token: 0x02000020 RID: 32
		public struct CFG_GERAL_RT_830_200
		{
			// Token: 0x04000372 RID: 882
			public RT_geral.Integer_ictel endereco;

			// Token: 0x04000373 RID: 883
			public RT_geral.Integer_ictel retrys;

			// Token: 0x04000374 RID: 884
			public RT_geral.Integer_ictel timeout;

			// Token: 0x04000375 RID: 885
			public RT_geral.Integer_ictel PTT;

			// Token: 0x04000376 RID: 886
			public RT_geral.Combo_ictel tipo_COM2;

			// Token: 0x04000377 RID: 887
			public RT_geral.Integer_ictel erros_falha;

			// Token: 0x04000378 RID: 888
			public RT_geral.Integer_ictel intervalo_polling;

			// Token: 0x04000379 RID: 889
			public RT_geral.Integer_ictel qtd_reservatorios;

			// Token: 0x0400037A RID: 890
			public RT_geral.Integer_ictel qtd_equip_reservatorios;

			// Token: 0x0400037B RID: 891
			public RT_geral.Integer_ictel qtd_recalques;

			// Token: 0x0400037C RID: 892
			public RT_geral.Integer_ictel qtd_vistas;

			// Token: 0x0400037D RID: 893
			public RT_geral.Integer_ictel inicio_endereco_reservatorio;

			// Token: 0x0400037E RID: 894
			public RT_geral.Integer_ictel inicio_endereco_recalque;

			// Token: 0x0400037F RID: 895
			public RT_geral.Integer_ictel inicio_endereco_vista;
		}

		// Token: 0x02000021 RID: 33
		public struct Equipamento_Reservatorio
		{
			// Token: 0x04000380 RID: 896
			public RT_geral.Integer_ictel NumeroVariavel;

			// Token: 0x04000381 RID: 897
			public RT_geral.Integer_ictel Prioridade;

			// Token: 0x04000382 RID: 898
			public RT_geral.Integer_ictel Altura;

			// Token: 0x04000383 RID: 899
			public RT_geral.Integer_ictel Nome;
		}

		// Token: 0x02000022 RID: 34
		public struct Equipamento_Recalque
		{
			// Token: 0x04000384 RID: 900
			public RT_geral.Integer_ictel origem;

			// Token: 0x04000385 RID: 901
			public RT_geral.Integer_ictel destino;

			// Token: 0x04000386 RID: 902
			public RT_geral.Integer_ictel Var1;

			// Token: 0x04000387 RID: 903
			public RT_geral.Integer_ictel Var2;

			// Token: 0x04000388 RID: 904
			public RT_geral.Integer_ictel Var3;

			// Token: 0x04000389 RID: 905
			public RT_geral.Integer_ictel Var4;

			// Token: 0x0400038A RID: 906
			public RT_geral.Integer_ictel Nome_Var1;

			// Token: 0x0400038B RID: 907
			public RT_geral.Integer_ictel Nome_Var2;

			// Token: 0x0400038C RID: 908
			public RT_geral.Integer_ictel Nome_Var3;

			// Token: 0x0400038D RID: 909
			public RT_geral.Integer_ictel Nome_Var4;

			// Token: 0x0400038E RID: 910
			public RT_geral.Combo_ictel Modelo;

			// Token: 0x0400038F RID: 911
			public RT_geral.Integer_ictel Prioridade;

			// Token: 0x04000390 RID: 912
			public RT_geral.Integer_ictel Nome;

			// Token: 0x04000391 RID: 913
			public RT_geral.Combo_ictel Habilita;

			// Token: 0x04000392 RID: 914
			public RT_geral.Integer_ictel Escala1;

			// Token: 0x04000393 RID: 915
			public RT_geral.Integer_ictel Escala2;

			// Token: 0x04000394 RID: 916
			public RT_geral.Integer_ictel Escala3;

			// Token: 0x04000395 RID: 917
			public RT_geral.Integer_ictel Escala4;

			// Token: 0x04000396 RID: 918
			public RT_geral.Integer_ictel Escala5;

			// Token: 0x04000397 RID: 919
			public RT_geral.Integer_ictel Escala6;

			// Token: 0x04000398 RID: 920
			public RT_geral.Integer_ictel Escala7;

			// Token: 0x04000399 RID: 921
			public RT_geral.Integer_ictel Escala8;

			// Token: 0x0400039A RID: 922
			public RT_geral.Integer_ictel Escala9;

			// Token: 0x0400039B RID: 923
			public RT_geral.Integer_ictel Escala10;

			// Token: 0x0400039C RID: 924
			public RT_geral.Integer_ictel Escala11;

			// Token: 0x0400039D RID: 925
			public RT_geral.Integer_ictel Escala12;

			// Token: 0x0400039E RID: 926
			public RT_geral.Integer_ictel Escala13;

			// Token: 0x0400039F RID: 927
			public RT_geral.Integer_ictel Escala14;

			// Token: 0x040003A0 RID: 928
			public RT_geral.Integer_ictel Escala15;

			// Token: 0x040003A1 RID: 929
			public RT_geral.Integer_ictel Escala16;
		}

		// Token: 0x02000023 RID: 35
		public struct Equipamento_vista
		{
			// Token: 0x040003A2 RID: 930
			public RT_geral.Integer_ictel Numero_Variaveis;

			// Token: 0x040003A3 RID: 931
			public RT_geral.Integer_ictel Numero_RemotasControles;

			// Token: 0x040003A4 RID: 932
			public RT_geral.Integer_ictel Prioridade;

			// Token: 0x040003A5 RID: 933
			public RT_geral.Integer_ictel[] Variaveis;

			// Token: 0x040003A6 RID: 934
			public RT_geral.Integer_ictel[] RemotasControles;
		}

		// Token: 0x02000024 RID: 36
		public struct DADOS_RT_830_200_CONFIG
		{
			// Token: 0x040003A7 RID: 935
			public RT_830_200_variaveis_X.FIRMWARE_RT_830_200 firmware;

			// Token: 0x040003A8 RID: 936
			public RT_830_200_variaveis_X.CFG_GERAL_RT_830_200 cfg_geral;

			// Token: 0x040003A9 RID: 937
			public RT_830_200_variaveis_X.Equipamento_Reservatorio[] reservatorio;

			// Token: 0x040003AA RID: 938
			public RT_830_200_variaveis_X.Equipamento_Recalque[] recalque;

			// Token: 0x040003AB RID: 939
			public RT_830_200_variaveis_X.Equipamento_vista[] vista;

			// Token: 0x040003AC RID: 940
			public string filename;
		}
	}
}
