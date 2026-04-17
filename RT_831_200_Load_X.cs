using System.Drawing;
using System.Windows.Forms;
﻿using System;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x02000029 RID: 41
	[StandardModule]
	internal sealed class RT_831_200_Load_X
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x0022A27C File Offset: 0x0022867C
		public static void RT_831_200_Carrega_Geral_Descricao(string filename, RT_831_200_configurador frm)
		{
			IniFile iniFile = new IniFile(filename);
			frm.TextBox_nome_RT850.Text = iniFile.ReadText("GERAL_DESCRICAO", "NOME", "");
			frm.TextBox_endereco_RT850.Text = iniFile.ReadText("GERAL_DESCRICAO", "ENDERECO", "");
			frm.TextBox_comentarios_RT850.Text = iniFile.ReadText("GERAL_DESCRICAO", "COMENTARIO", "");
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0022A2F0 File Offset: 0x002286F0
		public static void RT_831_200_Carrega_Canal_Radio(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_mestre.Valor = iniFile.ReadInteger("CANAL_RADIO", "MESTRE", 0);
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.endereco_estacao.Valor = iniFile.ReadInteger("CANAL_RADIO", "ESTACAO", 0);
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.tipo_COM2.Valor = iniFile.ReadInteger("CANAL_RADIO", "BAUDRATE", 0);
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.PTT.Valor = iniFile.ReadInteger("CANAL_RADIO", "TEMPO_PTT", 200);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0022A3A4 File Offset: 0x002287A4
		public static void RT_831_200_Carrega_Senha(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			RT_831_200_variaveis_X.RT_831_200_BD.senha.senha.Valor = iniFile.ReadInteger("SENHA", "SENHA", 0);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0022A3E4 File Offset: 0x002287E4
		public static void RT_831_200_Carrega_Equipamentos(object filename)
		{
			IniFile iniFile = new IniFile(Conversions.ToString(filename));
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor = iniFile.ReadInteger("EQUIPAMENTOS", "NUMERO_RESERVATORIOS", 0);
			RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor = iniFile.ReadInteger("EQUIPAMENTOS", "NUMERO_RECALQUES", 0);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0022A448 File Offset: 0x00228848
		public static void RT_831_200_Carrega_Variaveis(string filename, RT_831_200_configurador frm)
		{
			IniFile iniFile = new IniFile(filename);
			int num = 0;
			checked
			{
				int num2 = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor - 1;
				for (int i = Convert.ToInt32(num); i <= num2; i++)
				{
					string section = string.Format("VARIAVEIS_{0}", i + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.reservatorio[i].Nome.Valor = iniFile.ReadInteger(section, "NOME", 0);
					Application.DoEvents();
					frm.ToolStripProgressBar_RT850.Value = (int)Math.Round(unchecked((double)i / (double)(checked(RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_reservatorios.Valor - 1)) * 100.0));
				}
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0022A4F4 File Offset: 0x002288F4
		public static void RT_831_200_Carrega_RemotasControle(string filename, RT_831_200_configurador frm)
		{
			IniFile iniFile = new IniFile(filename);
			int num = 0;
			checked
			{
				int num2 = RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor - 1;
				for (int i = Convert.ToInt32(num); i <= num2; i++)
				{
					string section = string.Format("REMOTAS_CONTROLE_{0}", i + 1);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Nome.Valor = iniFile.ReadInteger(section, "NOME", 0);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Modelo.Valor = iniFile.ReadInteger(section, "MODELO", 0);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Habilita.Valor = iniFile.ReadInteger(section, "HAB_CMD", 0);
					Application.DoEvents();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala1.Valor = iniFile.ReadInteger(section, "ESCALA1", 0);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala2.Valor = iniFile.ReadInteger(section, "ESCALA2", 0);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala3.Valor = iniFile.ReadInteger(section, "ESCALA3", 0);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala4.Valor = iniFile.ReadInteger(section, "ESCALA4", 0);
					Application.DoEvents();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala5.Valor = iniFile.ReadInteger(section, "ESCALA5", 0);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala6.Valor = iniFile.ReadInteger(section, "ESCALA6", 0);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala7.Valor = iniFile.ReadInteger(section, "ESCALA7", 0);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala8.Valor = iniFile.ReadInteger(section, "ESCALA8", 0);
					Application.DoEvents();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala9.Valor = iniFile.ReadInteger(section, "ESCALA9", 0);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala10.Valor = iniFile.ReadInteger(section, "ESCALA10", 0);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala11.Valor = iniFile.ReadInteger(section, "ESCALA11", 0);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala12.Valor = iniFile.ReadInteger(section, "ESCALA12", 0);
					Application.DoEvents();
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala13.Valor = iniFile.ReadInteger(section, "ESCALA13", 0);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala14.Valor = iniFile.ReadInteger(section, "ESCALA14", 0);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala15.Valor = iniFile.ReadInteger(section, "ESCALA15", 0);
					RT_831_200_variaveis_X.RT_831_200_BD.recalque[i].Escala16.Valor = iniFile.ReadInteger(section, "ESCALA16", 0);
					Application.DoEvents();
					frm.ToolStripProgressBar_RT850.Value = (int)Math.Round(unchecked((double)i / (double)(checked(RT_831_200_variaveis_X.RT_831_200_BD.cfg_geral.qtd_recalques.Valor - 1)) * 100.0));
				}
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0022A878 File Offset: 0x00228C78
		public static void RT_831_200_Carrega_Instalacao(string filename, RT_831_200_configurador frm)
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
