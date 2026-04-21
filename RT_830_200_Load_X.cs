using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x0200001A RID: 26
	[StandardModule]
	internal sealed class RT_830_200_Load_X
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x00225DA8 File Offset: 0x002241A8
		public static void RT_830_200_Carrega_Geral_Descricao(string filename, RT_830_200_configurador frm)
		{
			IniFile iniFile = new IniFile(filename);
			frm.TextBox_nome_RT850.Text = iniFile.ReadText("GERAL_DESCRICAO", "NOME", "");
			frm.TextBox_endereco_RT850.Text = iniFile.ReadText("GERAL_DESCRICAO", "ENDERECO", "");
			frm.TextBox_comentarios_RT850.Text = iniFile.ReadText("GERAL_DESCRICAO", "COMENTARIO", "");
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00225E1C File Offset: 0x0022421C
		public static void RT_830_200_Carrega_Canal_Radio(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.endereco.Valor = iniFile.ReadInteger("CANAL_RADIO", "MESTRE", 0);
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.intervalo_polling.Valor = iniFile.ReadInteger("CANAL_RADIO", "INTERVALO_LEITURA", 3);
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.Valor = iniFile.ReadInteger("CANAL_RADIO", "BAUDRATE", 0);
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.timeout.Valor = iniFile.ReadInteger("CANAL_RADIO", "TIMEOUT", 5);
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.PTT.Valor = iniFile.ReadInteger("CANAL_RADIO", "TEMPO_PTT", 200);
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.retrys.Valor = iniFile.ReadInteger("CANAL_RADIO", "NUMERO_TENTATIVAS", 3);
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.erros_falha.Valor = iniFile.ReadInteger("CANAL_RADIO", "NUMERO_ERROS_FALHA", 3);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00225F3C File Offset: 0x0022433C
		public static void RT_830_200_Carrega_Equipamentos(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_reservatorios.Valor = iniFile.ReadInteger("EQUIPAMENTOS", "NUMERO_RESERVATORIOS", 0);
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios.Valor = iniFile.ReadInteger("EQUIPAMENTOS", "NUMERO_EQUIP_RESERVATORIOS", 0);
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_reservatorio.Valor = iniFile.ReadInteger("EQUIPAMENTOS", "END_INICIAL_RESERVATORIO", 0);
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques.Valor = iniFile.ReadInteger("EQUIPAMENTOS", "NUMERO_EQUIP_RECALQUE", 0);
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_recalque.Valor = iniFile.ReadInteger("EQUIPAMENTOS", "END_INICIAL_RECALQUE", 0);
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor = iniFile.ReadInteger("EQUIPAMENTOS", "NUMERO_EQUIP_VISTA", 0);
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.inicio_endereco_vista.Valor = iniFile.ReadInteger("EQUIPAMENTOS", "END_INICIAL_VISTA", 0);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00226058 File Offset: 0x00224458
		public static void RT_830_200_Carrega_Variaveis(string filename, RT_830_200_configurador frm)
		{
			IniFile iniFile = new IniFile(filename);
			int num = 0;
			checked
			{
				int num2 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_equip_reservatorios.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string section = string.Format("VARIAVEIS_{0}", i + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i].Nome.Valor = iniFile.ReadInteger(section, "NOME", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i].Altura.Valor = iniFile.ReadInteger(section, "ALTURA", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i].Prioridade.Valor = iniFile.ReadInteger(section, "PRIORIDADE", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.reservatorio[i].NumeroVariavel.Valor = iniFile.ReadInteger(section, "NUMERO_VARIAVEL", 0);
					Application.DoEvents();
				}
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0022614C File Offset: 0x0022454C
		public static void RT_830_200_Carrega_RemotasControle(string filename, RT_830_200_configurador frm)
		{
			IniFile iniFile = new IniFile(filename);
			int num = 0;
			checked
			{
				int num2 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_recalques.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string section = string.Format("REMOTAS_CONTROLE_{0}", i + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome.Valor = iniFile.ReadInteger(section, "NOME", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Modelo.Valor = iniFile.ReadInteger(section, "MODELO", 0);
					int valor = iniFile.ReadInteger(section, "ORIGEM", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].origem.Valor = valor;
					valor = iniFile.ReadInteger(section, "DESTINO", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].destino.Valor = valor;
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Prioridade.Valor = iniFile.ReadInteger(section, "PRIORIDADE", 0);
					Application.DoEvents();
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Var1.Valor = iniFile.ReadInteger(section, "VAR1", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Var2.Valor = iniFile.ReadInteger(section, "VAR2", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Var3.Valor = iniFile.ReadInteger(section, "VAR3", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Var4.Valor = iniFile.ReadInteger(section, "VAR4", 0);
					Application.DoEvents();
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome_Var1.Valor = iniFile.ReadInteger(section, "NOME_VAR1", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome_Var2.Valor = iniFile.ReadInteger(section, "NOME_VAR2", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome_Var3.Valor = iniFile.ReadInteger(section, "NOME_VAR3", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Nome_Var4.Valor = iniFile.ReadInteger(section, "NOME_VAR4", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Habilita.Valor = iniFile.ReadInteger(section, "HAB_CMD", 0);
					Application.DoEvents();
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala1.Valor = iniFile.ReadInteger(section, "ESCALA1", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala2.Valor = iniFile.ReadInteger(section, "ESCALA2", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala3.Valor = iniFile.ReadInteger(section, "ESCALA3", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala4.Valor = iniFile.ReadInteger(section, "ESCALA4", 0);
					Application.DoEvents();
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala5.Valor = iniFile.ReadInteger(section, "ESCALA5", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala6.Valor = iniFile.ReadInteger(section, "ESCALA6", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala7.Valor = iniFile.ReadInteger(section, "ESCALA7", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala8.Valor = iniFile.ReadInteger(section, "ESCALA8", 0);
					Application.DoEvents();
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala9.Valor = iniFile.ReadInteger(section, "ESCALA9", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala10.Valor = iniFile.ReadInteger(section, "ESCALA10", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala11.Valor = iniFile.ReadInteger(section, "ESCALA11", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala12.Valor = iniFile.ReadInteger(section, "ESCALA12", 0);
					Application.DoEvents();
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala13.Valor = iniFile.ReadInteger(section, "ESCALA13", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala14.Valor = iniFile.ReadInteger(section, "ESCALA14", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala15.Valor = iniFile.ReadInteger(section, "ESCALA15", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[i].Escala16.Valor = iniFile.ReadInteger(section, "ESCALA16", 0);
					Application.DoEvents();
				}
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00226658 File Offset: 0x00224A58
		public static void RT_830_200_Carrega_Vista(string filename, RT_830_200_configurador frm)
		{
			IniFile iniFile = new IniFile(filename);
			int num = 0;
			checked
			{
				int num2 = RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.qtd_vistas.Valor - 1;
				for (int i = num; i <= num2; i++)
				{
					string section = string.Format("CONTROLE_TIPO_VISTA_{0}", i + 1);
					RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_Variaveis.Valor = iniFile.ReadInteger(section, "NUMERO_VARIAVEIS", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_RemotasControles.Valor = iniFile.ReadInteger(section, "NUMERO_REMOTASCONTROLE", 0);
					RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Prioridade.Valor = iniFile.ReadInteger(section, "PRIORIDADE", 0);
					Application.DoEvents();
					int num3 = 0;
					int num4 = RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_Variaveis.Valor - 1;
					for (int j = num3; j <= num4; j++)
					{
						string key = string.Format("VARIAVEIS{0}", j + 1);
						RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Variaveis[j].Valor = iniFile.ReadInteger(section, key, 0);
						Application.DoEvents();
					}
					int num5 = 0;
					int num6 = RT_830_200_variaveis_X.RT_830_200_BD.vista[i].Numero_RemotasControles.Valor - 1;
					for (int j = num5; j <= num6; j++)
					{
						string key = string.Format("REMOTASCONTROLE{0}", j + 1);
						RT_830_200_variaveis_X.RT_830_200_BD.vista[i].RemotasControles[j].Valor = iniFile.ReadInteger(section, key, 0);
						Application.DoEvents();
					}
				}
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00226800 File Offset: 0x00224C00
		public static void RT_830_200_Carrega_Instalacao(string filename, RT_830_200_configurador frm)
		{
			IniFile iniFile = new IniFile(filename);
			frm.CB_TipoAntena1.SelectedIndex = iniFile.ReadInteger("DADOS_INSTALACAO", "TIPO_ANTENA", -1);
			frm.CB_PolarizacaoAntena1.SelectedIndex = iniFile.ReadInteger("DADOS_INSTALACAO", "POLARIZACAO_ANTENA", -1);
			frm.T_PotRadio1.Text = iniFile.ReadText("DADOS_INSTALACAO", "POTENCIA_RADIO", "");
			frm.CB_ModeloRadio1.SelectedIndex = iniFile.ReadInteger("DADOS_INSTALACAO", "MODELO_RADIO", -1);
			frm.T_FreqRadio1.Text = iniFile.ReadText("DADOS_INSTALACAO", "FREQUENCIA_RADIO", "?");
			frm.T_Azimute1.Text = iniFile.ReadText("DADOS_INSTALACAO", "AZIMUTE", "?");
			frm.T_Longitude1.Text = iniFile.ReadText("DADOS_INSTALACAO", "LONGITUDE", "?");
			frm.T_Latitude1.Text = iniFile.ReadText("DADOS_INSTALACAO", "LATITUDE", "?");
			frm.T_AlturaAntena1.Text = iniFile.ReadText("DADOS_INSTALACAO", "ALTURA_ANTENA", "?");
		}
	}
}
