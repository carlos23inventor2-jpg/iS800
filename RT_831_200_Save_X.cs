using System;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x0200002B RID: 43
	[StandardModule]
	internal sealed class RT_831_200_Save_X
	{
		// Token: 0x06000415 RID: 1045 RVA: 0x0022AA94 File Offset: 0x00228E94
		public static void RT_831_200_Salva_Geral_Informacao(IniFileWriteFast ini)
		{
			ini.WriteSection("GERAL_INFORMACAO");
			ini.WriteKey("EQUIPAMENTO", RT_831_200_variaveis_X.RT_831_200_BD.firmware.Equip.Valor);
			ini.WriteKey("VERSAO", RT_831_200_variaveis_X.RT_831_200_BD.firmware.Versao.Valor);
			ini.WriteKey("BUILD", RT_831_200_variaveis_X.RT_831_200_BD.firmware.Build.Valor);
			ini.WriteKey("RELEASE", RT_831_200_variaveis_X.RT_831_200_BD.firmware.Release.Valor);
			ini.LineSpace();
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0022AB30 File Offset: 0x00228F30
		public static void RT_831_200_Salva_Geral_Descricao(IniFileWriteFast ini, RT_831_200_configurador frm)
		{
			ini.WriteSection("GERAL_DESCRICAO");
			ini.WriteKey("NOME", frm.TextBox_nome_RT850.Text);
			ini.WriteKey("ENDERECO", frm.TextBox_endereco_RT850.Text);
			ini.WriteKey("COMENTARIO", frm.TextBox_comentarios_RT850.Text);
			ini.LineSpace();
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0022AB90 File Offset: 0x00228F90
		public static void RT_831_200_Salva_Senha(IniFileWriteFast ini)
		{
			ini.WriteSection("SENHA");
			ini.WriteKey("SENHA", RT_831_200_variaveis_X.RT_831_200_BD.senha.senha.Valor);
			ini.LineSpace();
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0022ABC4 File Offset: 0x00228FC4
		public static void RT_831_200_Salva_Canal_Radio(IniFileWriteFast ini)
		{
			ini.WriteSection("CANAL_RADIO");
			ini.WriteKey("MESTRE", RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre.Valor);
			ini.WriteKey("ESTACAO", RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor);
			ini.WriteKey("BAUDRATE", RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.Valor);
			ini.WriteKey("TEMPO_PTT", RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT.Valor);
			ini.LineSpace();
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0022AC60 File Offset: 0x00229060
		public static void RT_831_200_Salva_Equipamentos(IniFileWriteFast ini)
		{
			ini.WriteSection("EQUIPAMENTOS");
			ini.WriteKey("NUMERO_RESERVATORIOS", RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor);
			ini.WriteKey("NUMERO_RECALQUES", RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor);
			ini.LineSpace();
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0022ACBC File Offset: 0x002290BC
		public static void RT_831_200_Salva_Variaveis(IniFileWriteFast ini)
		{
			int num = 0;
			checked
			{
				int num2 = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string section = string.Format("VARIAVEIS_{0}", i + 1);
					ini.WriteSection(section);
					ini.WriteKey("NOME", RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[i].Nome.Valor);
					ini.LineSpace();
				}
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0022AD34 File Offset: 0x00229134
		public static void RT_831_200_Salva_RemotasControle(IniFileWriteFast ini)
		{
			int num = 0;
			checked
			{
				int num2 = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string section = string.Format("REMOTAS_CONTROLE_{0}", i + 1);
					ini.WriteSection(section);
					ini.WriteKey("NOME", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Nome.Valor);
					ini.WriteKey("MODELO", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Modelo.Valor);
					ini.WriteKey("HAB_CMD", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Habilita.Valor);
					ini.WriteKey("ESCALA1", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala1.Valor);
					ini.WriteKey("ESCALA2", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala2.Valor);
					ini.WriteKey("ESCALA3", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala3.Valor);
					ini.WriteKey("ESCALA4", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala4.Valor);
					ini.WriteKey("ESCALA5", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala5.Valor);
					ini.WriteKey("ESCALA6", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala6.Valor);
					ini.WriteKey("ESCALA7", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala7.Valor);
					ini.WriteKey("ESCALA8", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala8.Valor);
					ini.WriteKey("ESCALA9", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala9.Valor);
					ini.WriteKey("ESCALA10", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala10.Valor);
					ini.WriteKey("ESCALA11", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala11.Valor);
					ini.WriteKey("ESCALA12", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala12.Valor);
					ini.WriteKey("ESCALA13", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala13.Valor);
					ini.WriteKey("ESCALA14", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala14.Valor);
					ini.WriteKey("ESCALA15", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala15.Valor);
					ini.WriteKey("ESCALA16", RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala16.Valor);
					ini.LineSpace();
				}
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0022B04C File Offset: 0x0022944C
		public static void RT_831_200_Salva_Instalacao(IniFileWriteFast ini, RT_831_200_configurador frm)
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
