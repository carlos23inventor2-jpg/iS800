using System;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x0200002D RID: 45
	[StandardModule]
	internal sealed class RT_831_200_variaveis_X
	{
		// Token: 0x04000464 RID: 1124
		public static RT_831_200_variaveis_X.DADOS_RT_831_200_CONFIG RT_831_200_BD;

		// Token: 0x0200002E RID: 46
		public struct FIRMWARE_RT_831_200
		{
			// Token: 0x04000465 RID: 1125
			public RT_geral.Integer_ictel Equip;

			// Token: 0x04000466 RID: 1126
			public RT_geral.Integer_ictel Versao;

			// Token: 0x04000467 RID: 1127
			public RT_geral.Integer_ictel Build;

			// Token: 0x04000468 RID: 1128
			public RT_geral.Integer_ictel Release;
		}

		// Token: 0x0200002F RID: 47
		public struct CFG_GERAL_RT_831_200
		{
			// Token: 0x04000469 RID: 1129
			public RT_geral.Integer_ictel endereco_mestre;

			// Token: 0x0400046A RID: 1130
			public RT_geral.Integer_ictel endereco_estacao;

			// Token: 0x0400046B RID: 1131
			public RT_geral.Integer_ictel PTT;

			// Token: 0x0400046C RID: 1132
			public RT_geral.Combo_ictel tipo_COM2;

			// Token: 0x0400046D RID: 1133
			public RT_geral.Integer_ictel qtd_reservatorios;

			// Token: 0x0400046E RID: 1134
			public RT_geral.Integer_ictel qtd_recalques;
		}

		// Token: 0x02000030 RID: 48
		public struct Equipamento_Reservatorio
		{
			// Token: 0x0400046F RID: 1135
			public RT_geral.Integer_ictel Nome;
		}

		// Token: 0x02000031 RID: 49
		public struct Equipamento_Recalque
		{
			// Token: 0x04000470 RID: 1136
			public RT_geral.Integer_ictel Nome;

			// Token: 0x04000471 RID: 1137
			public RT_geral.Combo_ictel Modelo;

			// Token: 0x04000472 RID: 1138
			public RT_geral.Combo_ictel Habilita;

			// Token: 0x04000473 RID: 1139
			public RT_geral.Integer_ictel Escala1;

			// Token: 0x04000474 RID: 1140
			public RT_geral.Integer_ictel Escala2;

			// Token: 0x04000475 RID: 1141
			public RT_geral.Integer_ictel Escala3;

			// Token: 0x04000476 RID: 1142
			public RT_geral.Integer_ictel Escala4;

			// Token: 0x04000477 RID: 1143
			public RT_geral.Integer_ictel Escala5;

			// Token: 0x04000478 RID: 1144
			public RT_geral.Integer_ictel Escala6;

			// Token: 0x04000479 RID: 1145
			public RT_geral.Integer_ictel Escala7;

			// Token: 0x0400047A RID: 1146
			public RT_geral.Integer_ictel Escala8;

			// Token: 0x0400047B RID: 1147
			public RT_geral.Integer_ictel Escala9;

			// Token: 0x0400047C RID: 1148
			public RT_geral.Integer_ictel Escala10;

			// Token: 0x0400047D RID: 1149
			public RT_geral.Integer_ictel Escala11;

			// Token: 0x0400047E RID: 1150
			public RT_geral.Integer_ictel Escala12;

			// Token: 0x0400047F RID: 1151
			public RT_geral.Integer_ictel Escala13;

			// Token: 0x04000480 RID: 1152
			public RT_geral.Integer_ictel Escala14;

			// Token: 0x04000481 RID: 1153
			public RT_geral.Integer_ictel Escala15;

			// Token: 0x04000482 RID: 1154
			public RT_geral.Integer_ictel Escala16;
		}

		// Token: 0x02000032 RID: 50
		public struct SENHA
		{
			// Token: 0x04000483 RID: 1155
			public RT_geral.Integer_ictel senha;
		}

		// Token: 0x02000033 RID: 51
		public struct DADOS_RT_831_200_CONFIG
		{
			// Token: 0x04000484 RID: 1156
			public RT_831_200_variaveis_X.FIRMWARE_RT_831_200 firmware;

			// Token: 0x04000485 RID: 1157
			public RT_831_200_variaveis_X.CFG_GERAL_RT_831_200 cfg_geral;

			// Token: 0x04000486 RID: 1158
			public RT_831_200_variaveis_X.Equipamento_Reservatorio[] reservatorio;

			// Token: 0x04000487 RID: 1159
			public RT_831_200_variaveis_X.Equipamento_Recalque[] recalque;

			// Token: 0x04000488 RID: 1160
			public RT_831_200_variaveis_X.SENHA senha;
		}
	}
}
