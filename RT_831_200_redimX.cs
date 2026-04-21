using System;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x0200002A RID: 42
	[StandardModule]
	internal sealed class RT_831_200_redimX
	{
		// Token: 0x06000414 RID: 1044 RVA: 0x0022A9A0 File Offset: 0x00228DA0
		public static void RT_831_200_redim()
		{
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.valores = new int[3];
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.itens = new string[3];
			RT_831_200_variaveis_X.RT_831_200_BD.reservatorio = new RT_831_200_variaveis_X.Equipamento_Reservatorio[101];
			RT_831_200_variaveis_X.RT_831_200_BD.recalque = new RT_831_200_variaveis_X.Equipamento_Recalque[101];
			int num = (HorizontalAlignment)0;
			checked
			{
				do
				{
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.itens = new string[4];
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.valores = new int[4];
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.itens = new string[3];
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.valores = new int[3];
					num++;
				}
				while (num <= 27);
			}
		}
	}
}
