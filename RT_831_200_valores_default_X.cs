using System;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x0200002C RID: 44
	[StandardModule]
	internal sealed class RT_831_200_valores_default_X
	{
		// Token: 0x0600041D RID: 1053 RVA: 0x0022B130 File Offset: 0x00229530
		public static void RT_831_200_valores_default()
		{
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Versao.ValorPadrao();
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Build.ValorPadrao();
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Release.ValorPadrao();
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.ValorPadrao();
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre.ValorPadrao();
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.ValorPadrao();
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT.ValorPadrao();
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.IndicePadrao();
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.ValorPadrao();
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.ValorPadrao();
			int num = (HorizontalAlignment)0;
			checked
			{
				do
				{
					RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[num].Nome.ValorPadrao();
					num++;
				}
				while (num <= 39);
				num = (HorizontalAlignment)0;
				do
				{
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Nome.ValorPadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.IndicePadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.IndicePadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala1.ValorPadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala2.ValorPadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala3.ValorPadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala4.ValorPadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala5.ValorPadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala6.ValorPadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala7.ValorPadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala8.ValorPadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala9.ValorPadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala10.ValorPadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala11.ValorPadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala12.ValorPadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala13.ValorPadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala14.ValorPadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala15.ValorPadrao();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala16.ValorPadrao();
					num++;
				}
				while (num <= 27);
				RT_831_200_variaveis_X.RT_831_200_BD.senha.senha.ValorPadrao();
			}
		}
	}
}
