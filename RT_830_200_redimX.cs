using System.Drawing;
using System.Windows.Forms;
﻿using System;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x0200001B RID: 27
	[StandardModule]
	internal sealed class RT_830_200_redimX
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x00226928 File Offset: 0x00224D28
		public static void RT_830_200_redim()
		{
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.valores = new int[3];
			RT_830_200_variaveis_X.RT_830_200_BD.cfg_geral.tipo_COM2.itens = new string[3];
			RT_830_200_variaveis_X.RT_830_200_BD.reservatorio = new RT_830_200_variaveis_X.Equipamento_Reservatorio[101];
			RT_830_200_variaveis_X.RT_830_200_BD.recalque = new RT_830_200_variaveis_X.Equipamento_Recalque[101];
			int num = 0;
			checked
			{
				do
				{
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Modelo.itens = new string[4];
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Modelo.valores = new int[4];
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Habilita.itens = new string[3];
					RT_830_200_variaveis_X.RT_830_200_BD.recalque[num].Habilita.valores = new int[3];
					num++;
				}
				while (num <= 27);
				RT_830_200_variaveis_X.RT_830_200_BD.vista = new RT_830_200_variaveis_X.Equipamento_vista[6];
				RT_830_200_variaveis_X.RT_830_200_BD.vista[0].Variaveis = new RT_geral.Integer_ictel[101];
				RT_830_200_variaveis_X.RT_830_200_BD.vista[1].Variaveis = new RT_geral.Integer_ictel[101];
				RT_830_200_variaveis_X.RT_830_200_BD.vista[2].Variaveis = new RT_geral.Integer_ictel[101];
				RT_830_200_variaveis_X.RT_830_200_BD.vista[3].Variaveis = new RT_geral.Integer_ictel[101];
				RT_830_200_variaveis_X.RT_830_200_BD.vista[4].Variaveis = new RT_geral.Integer_ictel[101];
				RT_830_200_variaveis_X.RT_830_200_BD.vista[0].RemotasControles = new RT_geral.Integer_ictel[101];
				RT_830_200_variaveis_X.RT_830_200_BD.vista[1].RemotasControles = new RT_geral.Integer_ictel[101];
				RT_830_200_variaveis_X.RT_830_200_BD.vista[2].RemotasControles = new RT_geral.Integer_ictel[101];
				RT_830_200_variaveis_X.RT_830_200_BD.vista[3].RemotasControles = new RT_geral.Integer_ictel[101];
				RT_830_200_variaveis_X.RT_830_200_BD.vista[4].RemotasControles = new RT_geral.Integer_ictel[101];
				RT_geral.RT_850_BD.Vista_selecionado.valores = new int[2];
				RT_geral.RT_850_BD.Vista_selecionado.itens = new string[2];
				RT_geral.RT_850_Modelo.valores = new int[6];
				RT_geral.RT_850_Modelo.itens = new string[6];
				num = 0;
				do
				{
					RT_geral.RT_850_Ctrl_1[num].Var = new RT_geral.Combo_ictel_ctrl[5];
					RT_geral.RT_850_Ctrl_1[num].Ref = new RT_geral.Combo_ictel_ctrl[5];
					RT_geral.RT_850_Ctrl_1[num].Crtl_nome = new RT_geral.Combo_ictel_ctrl[2];
					RT_geral.RT_850_Ctrl_1[num].Crtl_indice = new RT_geral.Integer_ictel[2];
					num++;
				}
				while (num <= 80);
				num = 0;
				do
				{
					RT_geral.RT_850_Ctrl_4[num].Var = new RT_geral.Combo_ictel_ctrl[5];
					RT_geral.RT_850_Ctrl_4[num].Ref = new RT_geral.Combo_ictel_ctrl[5];
					RT_geral.RT_850_Ctrl_4[num].Crtl_nome = new RT_geral.Combo_ictel_ctrl[5];
					RT_geral.RT_850_Ctrl_4[num].Crtl_indice = new RT_geral.Integer_ictel[5];
					RT_geral.RT_850_Ctrl_4[num].Periferico_Indice = new RT_geral.Combo_ictel_ctrl[6];
					RT_geral.RT_850_Ctrl_4[num].Periferico_Modelo = new RT_geral.Combo_ictel_ctrl[6];
					num++;
				}
				while (num <= 50);
				num = 0;
				do
				{
					RT_geral.RT_850_Ctrl_8[num].Var = new RT_geral.Combo_ictel_ctrl[17];
					RT_geral.RT_850_Ctrl_8[num].Ref = new RT_geral.Combo_ictel_ctrl[5];
					RT_geral.RT_850_Ctrl_8[num].Crtl_nome = new RT_geral.Combo_ictel_ctrl[9];
					RT_geral.RT_850_Ctrl_8[num].Crtl_indice = new RT_geral.Integer_ictel[9];
					RT_geral.RT_850_Ctrl_8[num].Periferico_Indice = new RT_geral.Combo_ictel_ctrl[6];
					RT_geral.RT_850_Ctrl_8[num].Periferico_Modelo = new RT_geral.Combo_ictel_ctrl[6];
					num++;
				}
				while (num <= 20);
				num = 0;
				do
				{
					RT_geral.RT_850_Vista[num].Variaveis = new RT_geral.Combo_ictel_ctrl[41];
					RT_geral.RT_850_Vista[num].Equipamentos = new RT_geral.Combo_ictel_ctrl[21];
					num++;
				}
				while (num <= 5);
			}
		}
	}
}
