using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x02000028 RID: 40
	[StandardModule]
	internal sealed class RT_831_200_inicializa_variavies_X
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x00229350 File Offset: 0x00227750
		public static void RT_831_200_inicializa_variaveis()
		{
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Versao.nome = "Versão";
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Versao.Padrao = (HorizontalAlignment)0;
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Build.nome = "Build";
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Build.Padrao = (HorizontalAlignment)0;
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Release.nome = "Release";
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Release.Padrao = (HorizontalAlignment)0;
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.nome = "Tipo equipamento";
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.Padrao = (HorizontalAlignment)0;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre.nome = "Endereço Mestre";
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre.Padrao = (HorizontalAlignment)200;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre.Lmte_inf = (HorizontalAlignment)1;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre.Lmte_sup = (HorizontalAlignment)200;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.nome = "Endereço Estação";
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Padrao = (HorizontalAlignment)100;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Lmte_inf = (HorizontalAlignment)1;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Lmte_sup = (HorizontalAlignment)200;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT.nome = "Tempo PTT";
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT.Padrao = (HorizontalAlignment)200;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT.Lmte_inf = (HorizontalAlignment)10;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT.Lmte_sup = (HorizontalAlignment)2000;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.nome = "Baudrate";
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.Indice_padrao = (HorizontalAlignment)0;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.Numero_itens = (HorizontalAlignment)2;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.valores[0] = (HorizontalAlignment)21849;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.valores[1] = (HorizontalAlignment)21850;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.itens[0] = "1200 bauds";
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.itens[1] = "9600 bauds";
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.nome = "Número de equip. reservatórios";
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Padrao = (HorizontalAlignment)0;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Lmte_inf = (HorizontalAlignment)0;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Lmte_sup = (HorizontalAlignment)40;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.nome = "Número de equip. recalques";
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Padrao = (HorizontalAlignment)0;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Lmte_inf = (HorizontalAlignment)0;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Lmte_sup = (HorizontalAlignment)28;
			int num = (HorizontalAlignment)0;
			checked
			{
				do
				{
					RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[num].Nome.nome = "Nome do Reservatório";
					RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[num].Nome.Padrao = (HorizontalAlignment)1;
					RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[num].Nome.Lmte_inf = (HorizontalAlignment)1;
					RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[num].Nome.Lmte_sup = (HorizontalAlignment)399;
					num++;
				}
				while (num <= 39);
				num = (HorizontalAlignment)0;
				do
				{
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Nome.nome = "Nome do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Nome.Padrao = (HorizontalAlignment)1;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Nome.Lmte_inf = (HorizontalAlignment)1;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Nome.Lmte_sup = (HorizontalAlignment)999;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.nome = "Modelo do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.Numero_itens = (HorizontalAlignment)3;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.Indice_padrao = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.valores[0] = (HorizontalAlignment)1;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.valores[1] = (HorizontalAlignment)2;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.valores[2] = (HorizontalAlignment)3;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.itens[0] = "RT 821";
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.itens[1] = "RT 820";
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.itens[2] = "VA 220-42";
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.nome = "Habilita CMD do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.Numero_itens = (HorizontalAlignment)2;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.Indice_padrao = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.valores[0] = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.valores[1] = (HorizontalAlignment)21882;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.itens[0] = "Desabilitado";
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.itens[1] = "Habilitado";
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala1.nome = "Escala1  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala1.Padrao = (HorizontalAlignment)100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala1.Lmte_inf = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala1.Lmte_sup = (HorizontalAlignment)20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala2.nome = "Escala2  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala2.Padrao = (HorizontalAlignment)100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala2.Lmte_inf = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala2.Lmte_sup = (HorizontalAlignment)20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala3.nome = "Escala3  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala3.Padrao = (HorizontalAlignment)100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala3.Lmte_inf = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala3.Lmte_sup = (HorizontalAlignment)20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala4.nome = "Escala4  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala4.Padrao = (HorizontalAlignment)100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala4.Lmte_inf = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala4.Lmte_sup = (HorizontalAlignment)20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala5.nome = "Escala5  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala5.Padrao = (HorizontalAlignment)100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala5.Lmte_inf = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala5.Lmte_sup = (HorizontalAlignment)20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala6.nome = "Escala6  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala6.Padrao = (HorizontalAlignment)100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala6.Lmte_inf = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala6.Lmte_sup = (HorizontalAlignment)20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala7.nome = "Escala7  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala7.Padrao = (HorizontalAlignment)100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala7.Lmte_inf = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala7.Lmte_sup = (HorizontalAlignment)20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala8.nome = "Escala8  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala8.Padrao = (HorizontalAlignment)100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala8.Lmte_inf = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala8.Lmte_sup = (HorizontalAlignment)20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala9.nome = "Escala9  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala9.Padrao = (HorizontalAlignment)100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala9.Lmte_inf = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala9.Lmte_sup = (HorizontalAlignment)20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala10.nome = "Escala10  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala10.Padrao = (HorizontalAlignment)100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala10.Lmte_inf = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala10.Lmte_sup = (HorizontalAlignment)20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala11.nome = "Escala11  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala11.Padrao = (HorizontalAlignment)100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala11.Lmte_inf = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala11.Lmte_sup = (HorizontalAlignment)20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala12.nome = "Escala12  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala12.Padrao = (HorizontalAlignment)100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala12.Lmte_inf = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala12.Lmte_sup = (HorizontalAlignment)20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala13.nome = "Escala13  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala13.Padrao = (HorizontalAlignment)100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala13.Lmte_inf = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala13.Lmte_sup = (HorizontalAlignment)20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala14.nome = "Escala14  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala14.Padrao = (HorizontalAlignment)100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala14.Lmte_inf = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala14.Lmte_sup = (HorizontalAlignment)20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala15.nome = "Escala15  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala15.Padrao = (HorizontalAlignment)100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala15.Lmte_inf = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala15.Lmte_sup = (HorizontalAlignment)20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala16.nome = "Escala16  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala16.Padrao = (HorizontalAlignment)100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala16.Lmte_inf = (HorizontalAlignment)0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala16.Lmte_sup = (HorizontalAlignment)20000;
					num++;
				}
				while (num <= 27);
				RT_831_200_variaveis_X.RT_831_200_BD.senha.senha.nome = "Senha";
				RT_831_200_variaveis_X.RT_831_200_BD.senha.senha.Padrao = (HorizontalAlignment)0;
				RT_831_200_variaveis_X.RT_831_200_BD.senha.senha.Lmte_inf = (HorizontalAlignment)0;
				RT_831_200_variaveis_X.RT_831_200_BD.senha.senha.Lmte_sup = (HorizontalAlignment)9999;
			}
		}
	}
}
