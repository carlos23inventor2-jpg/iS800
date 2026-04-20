using System;
using System.Windows.Forms;
using iS800.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x02000019 RID: 25
	[StandardModule]
	internal sealed class RT_830_200_inicializa_variavies_X
	{
		// Token: 0x060002AD RID: 685 RVA: 0x002241C0 File Offset: 0x002225C0
		public static void RT_830_200_inicializa_variaveis()
		{
			RT_830_200_variaveis_X.RT_830_200_BD.firmware.Versao.nome = "Versão";
			RT_830_200_variaveis_X.RT_830_200_BD.firmware.Versao.Padrao = 0;
			RT_830_200_variaveis_X.RT_830_200_BD.firmware.Build.nome = "Build";
			RT_830_200_variaveis_X.RT_830_200_BD.firmware.Build.Padrao = 0;
			RT_830_200_variaveis_X.RT_830_200_BD.firmware.Release.nome = "Release";
			RT_830_200_variaveis_X.RT_830_200_BD.firmware.Release.Padrao = 0;
			RT_830_200_variaveis_X.RT_830_200_BD.firmware.Equip.nome = "Tipo equipamento";
			RT_830_200_variaveis_X.RT_830_200_BD.firmware.Equip.Padrao = 0;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.nome = "Endereço Mestre";
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Padrao = 200;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Lmte_inf = 1;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Lmte_sup = 200;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.nome = "Baudrate";
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.Indice_padrao = 0;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.Numero_itens = 2;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.valores[0] = 21849;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.valores[1] = 21850;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.itens[0] = "1200 bauds";
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.itens[1] = "9600 bauds";
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.intervalo_polling.nome = "Intervalo de Leitura Canal 1";
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.intervalo_polling.Padrao = 3;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.intervalo_polling.Lmte_inf = 1;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.intervalo_polling.Lmte_sup = 200;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.timeout.nome = "Tempo de Espera";
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.timeout.Padrao = 5;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.timeout.Lmte_inf = 1;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.timeout.Lmte_sup = 200;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.PTT.nome = "Tempo PTT";
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.PTT.Padrao = 200;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.PTT.Lmte_inf = 10;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.PTT.Lmte_sup = 2000;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.retrys.nome = "Número Tentativas";
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.retrys.Padrao = 3;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.retrys.Lmte_inf = 0;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.retrys.Lmte_sup = 20;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.erros_falha.nome = "Número Erros para Falha";
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.erros_falha.Padrao = 3;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.erros_falha.Lmte_inf = 1;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.erros_falha.Lmte_sup = 20;
			RT_830_200_inicializa_variavies_X.AtualizaNUD(MyProject.Forms.RT_830_200_configurador.NumericUpDown_num_erro_falha_1_RT850, RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.erros_falha);
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_reservatorios.nome = "Número de reservatórios";
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_reservatorios.Padrao = 0;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_reservatorios.Lmte_inf = 0;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_reservatorios.Lmte_sup = 60;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios.nome = "Número de equip. reservatórios";
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios.Padrao = 0;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios.Lmte_inf = 0;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios.Lmte_sup = 50;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques.nome = "Numero de equip. de recalque";
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques.Padrao = 0;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques.Lmte_inf = 0;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques.Lmte_sup = 28;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.nome = "Número de equip. de vista";
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Padrao = 0;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Lmte_inf = 0;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Lmte_sup = 5;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_reservatorio.nome = "Endereço inical de reservatório";
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_reservatorio.Padrao = 1;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_reservatorio.Lmte_inf = 1;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_reservatorio.Lmte_sup = 200;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_recalque.nome = "Endereço inical de recalque";
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_recalque.Padrao = 11;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_recalque.Lmte_inf = 1;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_recalque.Lmte_sup = 200;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista.nome = "Endereço inical de vista";
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista.Padrao = 21;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista.Lmte_inf = 1;
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista.Lmte_sup = 200;
			int num = 0;
			checked
			{
				do
				{
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Nome.nome = "Nome do Reservatório";
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Nome.Padrao = 1;
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Nome.Lmte_inf = 1;
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Nome.Lmte_sup = 399;
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Altura.nome = "Alturma (cm) do Reservatório";
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Altura.Padrao = 1000;
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Altura.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Altura.Lmte_sup = 20000;
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Prioridade.nome = "Prioridade do Reservatório";
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Prioridade.Padrao = 1;
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Prioridade.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].Prioridade.Lmte_sup = 7;
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].NumeroVariavel.nome = "Número do Reservatório";
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].NumeroVariavel.Padrao = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].NumeroVariavel.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[num].NumeroVariavel.Lmte_sup = 50;
					num++;
				}
				while (num <= 49);
				num = 0;
				do
				{
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome.nome = "Nome do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome.Padrao = 1;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome.Lmte_inf = 1;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome.Lmte_sup = 999;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].origem.nome = "Res. Origem do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].origem.Padrao = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].origem.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].origem.Lmte_sup = 99;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].destino.nome = "Res. Destino do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].destino.Padrao = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].destino.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].destino.Lmte_sup = 99;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Modelo.nome = "Modelo do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Modelo.Numero_itens = 3;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Modelo.Indice_padrao = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Modelo.valores[0] = 1;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Modelo.valores[1] = 2;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Modelo.valores[2] = 3;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Modelo.itens[0] = "RT 821";
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Modelo.itens[1] = "RT 820";
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Modelo.itens[2] = "VA 220-42";
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Prioridade.nome = "Prioridade do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Prioridade.Padrao = 1;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Prioridade.Lmte_inf = 1;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Prioridade.Lmte_sup = 7;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Var1.nome = "Res1 do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Var1.Padrao = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Var1.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Var1.Lmte_sup = 40;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Var2.nome = "Res2 do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Var2.Padrao = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Var2.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Var2.Lmte_sup = 40;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Var3.nome = "Res3 do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Var3.Padrao = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Var3.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Var3.Lmte_sup = 40;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Var4.nome = "Res4 do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Var4.Padrao = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Var4.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Var4.Lmte_sup = 40;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome_Var1.nome = "Nome Res";
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome_Var1.Padrao = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome_Var1.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome_Var1.Lmte_sup = 999;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome_Var2.nome = "Nome Res";
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome_Var2.Padrao = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome_Var2.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome_Var2.Lmte_sup = 999;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome_Var3.nome = "Nome Res";
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome_Var3.Padrao = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome_Var3.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome_Var3.Lmte_sup = 999;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome_Var4.nome = "Nome Res";
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome_Var4.Padrao = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome_Var4.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Nome_Var4.Lmte_sup = 999;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Habilita.nome = "Habilita CMD do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Habilita.Numero_itens = 2;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Habilita.Indice_padrao = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Habilita.valores[0] = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Habilita.valores[1] = 21882;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Habilita.itens[0] = "Desabilitado";
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Habilita.itens[1] = "Habilitado";
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala1.nome = "Escala1  do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala1.Padrao = 100;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala1.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala1.Lmte_sup = 20000;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala2.nome = "Escala2  do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala2.Padrao = 100;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala2.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala2.Lmte_sup = 20000;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala3.nome = "Escala3  do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala3.Padrao = 100;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala3.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala3.Lmte_sup = 20000;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala4.nome = "Escala4  do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala4.Padrao = 100;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala4.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala4.Lmte_sup = 20000;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala5.nome = "Escala5  do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala5.Padrao = 100;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala5.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala5.Lmte_sup = 20000;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala6.nome = "Escala6  do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala6.Padrao = 100;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala6.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala6.Lmte_sup = 20000;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala7.nome = "Escala7  do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala7.Padrao = 100;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala7.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala7.Lmte_sup = 20000;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala8.nome = "Escala8  do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala8.Padrao = 100;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala8.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala8.Lmte_sup = 20000;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala9.nome = "Escala9  do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala9.Padrao = 100;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala9.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala9.Lmte_sup = 20000;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala10.nome = "Escala10  do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala10.Padrao = 100;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala10.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala10.Lmte_sup = 20000;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala11.nome = "Escala11  do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala11.Padrao = 100;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala11.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala11.Lmte_sup = 20000;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala12.nome = "Escala12  do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala12.Padrao = 100;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala12.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala12.Lmte_sup = 20000;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala13.nome = "Escala13  do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala13.Padrao = 100;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala13.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala13.Lmte_sup = 20000;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala14.nome = "Escala14  do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala14.Padrao = 100;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala14.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala14.Lmte_sup = 20000;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala15.nome = "Escala15  do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala15.Padrao = 100;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala15.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala15.Lmte_sup = 20000;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala16.nome = "Escala16  do Recalque " + Conversion.Str(num + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala16.Padrao = 100;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala16.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Escala16.Lmte_sup = 20000;
					num++;
				}
				while (num <= 27);
				num = 0;
				do
				{
					RT_830_200_variaveis_X.RT_830_200_BD.vista[num].Numero_Variaveis.nome = "Vista" + Conversion.Str(num + 1) + "Nº de Variaveis";
					RT_830_200_variaveis_X.RT_830_200_BD.vista[num].Numero_Variaveis.Padrao = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.vista[num].Numero_Variaveis.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.vista[num].Numero_Variaveis.Lmte_sup = 50;
					RT_830_200_variaveis_X.RT_830_200_BD.vista[num].Numero_RemotasControles.nome = "Vista " + Conversion.Str(num + 1) + "Nº de Remotas de Controle";
					RT_830_200_variaveis_X.RT_830_200_BD.vista[num].Numero_RemotasControles.Padrao = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.vista[num].Numero_RemotasControles.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.vista[num].Numero_RemotasControles.Lmte_sup = 25;
					RT_830_200_variaveis_X.RT_830_200_BD.vista[num].Prioridade.nome = "Vista " + Conversion.Str(num + 1) + "Prioridade";
					RT_830_200_variaveis_X.RT_830_200_BD.vista[num].Prioridade.Padrao = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.vista[num].Prioridade.Lmte_inf = 0;
					RT_830_200_variaveis_X.RT_830_200_BD.vista[num].Prioridade.Lmte_sup = 7;
					int num2 = 0;
					do
					{
						RT_830_200_variaveis_X.RT_830_200_BD.vista[num].Variaveis[num2].nome = string.Format("Variáves[{0}][{1}]", num + 1, num2 + 1);
						RT_830_200_variaveis_X.RT_830_200_BD.vista[num].Variaveis[num2].Padrao = 0;
						RT_830_200_variaveis_X.RT_830_200_BD.vista[num].Variaveis[num2].Lmte_inf = 0;
						RT_830_200_variaveis_X.RT_830_200_BD.vista[num].Variaveis[num2].Lmte_sup = 99;
						RT_830_200_variaveis_X.RT_830_200_BD.vista[num].RemotasControles[num2].nome = string.Format("RemotasControles[{0}][{1}]", num + 1, num2 + 1);
						RT_830_200_variaveis_X.RT_830_200_BD.vista[num].RemotasControles[num2].Padrao = 0;
						RT_830_200_variaveis_X.RT_830_200_BD.vista[num].RemotasControles[num2].Lmte_inf = 0;
						RT_830_200_variaveis_X.RT_830_200_BD.vista[num].RemotasControles[num2].Lmte_sup = 99;
						num2++;
					}
					while (num2 <= 99);
					num++;
				}
				while (num <= 4);
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00225D34 File Offset: 0x00224134
		public static void AtualizaNUD(NumericUpDown nud, RT_geral.Integer_ictel var)
		{
			nud.Minimum = new decimal(var.Lmte_inf);
			nud.Maximum = new decimal(var.Lmte_sup);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00225D5C File Offset: 0x0022415C
		public static void AtualizaCOMBO(ComboBox combo, RT_geral.Combo_ictel var)
		{
			combo.Items.Clear();
			int num = 0;
			checked
			{
				int num2 = var.Numero_itens - 1;
				for (int i = num; i <= num2; i++)
				{
					string text = var.itens[i].ToString();
					combo.Items.Add(text);
				}
			}
		}
	}
}
