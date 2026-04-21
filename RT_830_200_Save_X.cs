using System;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x0200001C RID: 28
	[StandardModule]
	internal sealed class RT_830_200_Save_X
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x00226D50 File Offset: 0x00225150
		public static void RT_830_200_Salva_Geral_Informacao(IniFileWriteFast ini)
		{
			ini.WriteSection("GERAL_INFORMACAO");
			ini.WriteKey("EQUIPAMENTO", RT_830_200_variaveis_X.RT_830_200_BD.firmware.Equip.Valor);
			ini.WriteKey("VERSAO", RT_830_200_variaveis_X.RT_830_200_BD.firmware.Versao.Valor);
			ini.WriteKey("BUILD", RT_830_200_variaveis_X.RT_830_200_BD.firmware.Build.Valor);
			ini.WriteKey("RELEASE", RT_830_200_variaveis_X.RT_830_200_BD.firmware.Release.Valor);
			ini.LineSpace();
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00226DEC File Offset: 0x002251EC
		public static void RT_830_200_Salva_Geral_Descricao(IniFileWriteFast ini, RT_830_200_configurador frm)
		{
			ini.WriteSection("GERAL_DESCRICAO");
			ini.WriteKey("NOME", frm.TextBox_nome_RT850.Text);
			ini.WriteKey("ENDERECO", frm.TextBox_endereco_RT850.Text);
			ini.WriteKey("COMENTARIO", frm.TextBox_comentarios_RT850.Text);
			ini.LineSpace();
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00226E4C File Offset: 0x0022524C
		public static void RT_830_200_Salva_Canal_Radio(IniFileWriteFast ini)
		{
			ini.WriteSection("CANAL_RADIO");
			ini.WriteKey("MESTRE", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor);
			ini.WriteKey("INTERVALO_LEITURA", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.intervalo_polling.Valor);
			ini.WriteKey("BAUDRATE", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.Valor);
			ini.WriteKey("TIMEOUT", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.timeout.Valor);
			ini.WriteKey("TEMPO_PTT", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.PTT.Valor);
			ini.WriteKey("NUMERO_TENTATIVAS", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.retrys.Valor);
			ini.WriteKey("NUMERO_ERROS_FALHA", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.erros_falha.Valor);
			ini.LineSpace();
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00226F44 File Offset: 0x00225344
		public static void RT_830_200_Salva_Equipamentos(IniFileWriteFast ini)
		{
			ini.WriteSection("EQUIPAMENTOS");
			ini.WriteKey("NUMERO_RESERVATORIOS", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_reservatorios.Valor);
			ini.WriteKey("NUMERO_EQUIP_RESERVATORIOS", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios.Valor);
			ini.WriteKey("END_INICIAL_RESERVATORIO", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_reservatorio.Valor);
			ini.WriteKey("NUMERO_EQUIP_RECALQUE", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques.Valor);
			ini.WriteKey("END_INICIAL_RECALQUE", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_recalque.Valor);
			ini.WriteKey("NUMERO_EQUIP_VISTA", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor);
			ini.WriteKey("END_INICIAL_VISTA", RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista.Valor);
			ini.LineSpace();
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0022703C File Offset: 0x0022543C
		public static void RT_830_200_Salva_Variaveis(IniFileWriteFast ini)
		{
			int num = 0;
			checked
			{
				int num2 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string section = string.Format("VARIAVEIS_{0}", i + 1);
					ini.WriteSection(section);
					ini.WriteKey("NOME", RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i].Nome.Valor);
					ini.WriteKey("ALTURA", RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i].Altura.Valor);
					ini.WriteKey("PRIORIDADE", RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i].Prioridade.Valor);
					ini.WriteKey("NUMERO_VARIAVEL", RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i].NumeroVariavel.Valor);
					ini.LineSpace();
				}
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00227128 File Offset: 0x00225528
		public static void RT_830_200_Salva_RemotasControle(IniFileWriteFast ini)
		{
			int num = 0;
			checked
			{
				int num2 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string section = string.Format("REMOTAS_CONTROLE_{0}", i + 1);
					ini.WriteSection(section);
					ini.WriteKey("NOME", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome.Valor);
					ini.WriteKey("MODELO", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Modelo.Valor);
					ini.WriteKey("ORIGEM", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].origem.Valor);
					ini.WriteKey("DESTINO", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].destino.Valor);
					ini.WriteKey("PRIORIDADE", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Prioridade.Valor);
					ini.WriteKey("VAR1", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Var1.Valor);
					ini.WriteKey("VAR2", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Var2.Valor);
					ini.WriteKey("VAR3", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Var3.Valor);
					ini.WriteKey("VAR4", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Var4.Valor);
					ini.WriteKey("NOME_VAR1", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome_Var1.Valor);
					ini.WriteKey("NOME_VAR2", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome_Var2.Valor);
					ini.WriteKey("NOME_VAR3", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome_Var3.Valor);
					ini.WriteKey("NOME_VAR4", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome_Var4.Valor);
					ini.WriteKey("HAB_CMD", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Habilita.Valor);
					ini.WriteKey("ESCALA1", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala1.Valor);
					ini.WriteKey("ESCALA2", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala2.Valor);
					ini.WriteKey("ESCALA3", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala3.Valor);
					ini.WriteKey("ESCALA4", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala4.Valor);
					ini.WriteKey("ESCALA5", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala5.Valor);
					ini.WriteKey("ESCALA6", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala6.Valor);
					ini.WriteKey("ESCALA7", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala7.Valor);
					ini.WriteKey("ESCALA8", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala8.Valor);
					ini.WriteKey("ESCALA9", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala9.Valor);
					ini.WriteKey("ESCALA10", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala10.Valor);
					ini.WriteKey("ESCALA11", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala11.Valor);
					ini.WriteKey("ESCALA12", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala12.Valor);
					ini.WriteKey("ESCALA13", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala13.Valor);
					ini.WriteKey("ESCALA14", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala14.Valor);
					ini.WriteKey("ESCALA15", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala15.Valor);
					ini.WriteKey("ESCALA16", RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala16.Valor);
					ini.LineSpace();
				}
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x002275D4 File Offset: 0x002259D4
		public static void RT_830_200_Salva_Vista(IniFileWriteFast ini)
		{
			int num = 0;
			checked
			{
				int num2 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string section = string.Format("CONTROLE_TIPO_VISTA_{0}", i + 1);
					ini.WriteSection(section);
					ini.WriteKey("NUMERO_VARIAVEIS", RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_Variaveis.Valor);
					ini.WriteKey("NUMERO_REMOTASCONTROLE", RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_RemotasControles.Valor);
					ini.WriteKey("PRIORIDADE", RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Prioridade.Valor);
					int num3 = 0;
					int num4 = RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_Variaveis.Valor - 1;
					for (int j = num3; j <= num4; j++)
					{
						string key = string.Format("VARIAVEIS{0}", j + 1);
						ini.WriteKey(key, RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Variaveis[j].Valor);
					}
					int num5 = 0;
					int num6 = RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_RemotasControles.Valor - 1;
					for (int j = num5; j <= num6; j++)
					{
						string key = string.Format("REMOTASCONTROLE{0}", j + 1);
						ini.WriteKey(key, RT_830_200_variaveis_X.RT_830_200_BD.vista[i].RemotasControles[j].Valor);
					}
					ini.LineSpace();
				}
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00227768 File Offset: 0x00225B68
		public static void RT_830_200_Salva_Instalacao(IniFileWriteFast ini, RT_830_200_configurador frm)
		{
			ini.WriteSection("DADOS_INSTALACAO");
			ini.WriteKey("TIPO_ANTENA", frm.CB_TipoAntena1.SelectedIndex);
			ini.WriteKey("POLARIZACAO_ANTENA", frm.CB_PolarizacaoAntena1.SelectedIndex);
			ini.WriteKey("POTENCIA_RADIO", frm.T_PotRadio1.Text);
			ini.WriteKey("MODELO_RADIO", frm.CB_ModeloRadio1.SelectedIndex);
			ini.WriteKey("FREQUENCIA_RADIO", frm.T_FreqRadio1.Text);
			ini.WriteKey("AZIMUTE", frm.T_Azimute1.Text);
			ini.WriteKey("LONGITUDE", frm.T_Longitude1.Text);
			ini.WriteKey("LATITUDE", frm.T_Latitude1.Text);
			ini.WriteKey("ALTURA_ANTENA", frm.T_AlturaAntena1.Text);
			ini.LineSpace();
		}
	}
}
