using System.Drawing;
using System.Windows.Forms;
﻿using System;
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
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Versao.Padrao = 0;
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Build.nome = "Build";
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Build.Padrao = 0;
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Release.nome = "Release";
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Release.Padrao = 0;
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.nome = "Tipo equipamento";
			RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.Padrao = 0;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre.nome = "Endereço Mestre";
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre.Padrao = 200;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre.Lmte_inf = 1;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre.Lmte_sup = 200;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.nome = "Endereço Estação";
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Padrao = 100;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Lmte_inf = 1;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Lmte_sup = 200;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT.nome = "Tempo PTT";
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT.Padrao = 200;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT.Lmte_inf = 10;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT.Lmte_sup = 2000;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.nome = "Baudrate";
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.Indice_padrao = 0;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.Numero_itens = 2;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.valores[0] = 21849;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.valores[1] = 21850;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.itens[0] = "1200 bauds";
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.itens[1] = "9600 bauds";
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.nome = "Número de equip. reservatórios";
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Padrao = 0;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Lmte_inf = 0;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Lmte_sup = 40;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.nome = "Número de equip. recalques";
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Padrao = 0;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Lmte_inf = 0;
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Lmte_sup = 28;
			int num = 0;
			checked
			{
				do
				{
					RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[num].Nome.nome = "Nome do Reservatório";
					RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[num].Nome.Padrao = 1;
					RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[num].Nome.Lmte_inf = 1;
					RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[num].Nome.Lmte_sup = 399;
					num++;
				}
				while (num <= 39);
				num = 0;
				do
				{
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Nome.nome = "Nome do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Nome.Padrao = 1;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Nome.Lmte_inf = 1;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Nome.Lmte_sup = 999;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.nome = "Modelo do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.Numero_itens = 3;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.Indice_padrao = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.valores[0] = 1;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.valores[1] = 2;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.valores[2] = 3;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.itens[0] = "RT 821";
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.itens[1] = "RT 820";
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Modelo.itens[2] = "VA 220-42";
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.nome = "Habilita CMD do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.Numero_itens = 2;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.Indice_padrao = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.valores[0] = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.valores[1] = 21882;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.itens[0] = "Desabilitado";
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Habilita.itens[1] = "Habilitado";
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala1.nome = "Escala1  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala1.Padrao = 100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala1.Lmte_inf = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala1.Lmte_sup = 20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala2.nome = "Escala2  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala2.Padrao = 100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala2.Lmte_inf = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala2.Lmte_sup = 20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala3.nome = "Escala3  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala3.Padrao = 100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala3.Lmte_inf = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala3.Lmte_sup = 20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala4.nome = "Escala4  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala4.Padrao = 100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala4.Lmte_inf = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala4.Lmte_sup = 20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala5.nome = "Escala5  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala5.Padrao = 100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala5.Lmte_inf = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala5.Lmte_sup = 20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala6.nome = "Escala6  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala6.Padrao = 100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala6.Lmte_inf = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala6.Lmte_sup = 20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala7.nome = "Escala7  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala7.Padrao = 100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala7.Lmte_inf = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala7.Lmte_sup = 20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala8.nome = "Escala8  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala8.Padrao = 100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala8.Lmte_inf = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala8.Lmte_sup = 20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala9.nome = "Escala9  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala9.Padrao = 100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala9.Lmte_inf = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala9.Lmte_sup = 20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala10.nome = "Escala10  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala10.Padrao = 100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala10.Lmte_inf = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala10.Lmte_sup = 20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala11.nome = "Escala11  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala11.Padrao = 100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala11.Lmte_inf = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala11.Lmte_sup = 20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala12.nome = "Escala12  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala12.Padrao = 100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala12.Lmte_inf = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala12.Lmte_sup = 20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala13.nome = "Escala13  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala13.Padrao = 100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala13.Lmte_inf = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala13.Lmte_sup = 20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala14.nome = "Escala14  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala14.Padrao = 100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala14.Lmte_inf = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala14.Lmte_sup = 20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala15.nome = "Escala15  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala15.Padrao = 100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala15.Lmte_inf = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala15.Lmte_sup = 20000;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala16.nome = "Escala16  do Recalque " + Conversion.Str(num + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala16.Padrao = 100;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala16.Lmte_inf = 0;
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[num].Escala16.Lmte_sup = 20000;
					num++;
				}
				while (num <= 27);
				RT_831_200_variaveis_X.RT_831_200_BD.senha.senha.nome = "Senha";
				RT_831_200_variaveis_X.RT_831_200_BD.senha.senha.Padrao = 0;
				RT_831_200_variaveis_X.RT_831_200_BD.senha.senha.Lmte_inf = 0;
				RT_831_200_variaveis_X.RT_831_200_BD.senha.senha.Lmte_sup = 9999;
			}
		}
	}
}
