using System.Drawing;
using System.Windows.Forms;
﻿using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace iS800
{
	// Token: 0x020000AB RID: 171
	[StandardModule]
	internal sealed class perifericos
	{
		// Token: 0x060027DF RID: 10207 RVA: 0x0026182C File Offset: 0x0025FC2C
		public static void Cria_ListaPeriferico_CT850_300()
		{
			perifericos.perif_CT850_300.Clear();
			perifericos.perif_CT850_300.Add(perifericos.periferico_desabilitado__);
			perifericos.perif_CT850_300.Add(perifericos.periferico_vazao1________);
			perifericos.perif_CT850_300.Add(perifericos.periferico_vazao2________);
			perifericos.perif_CT850_300.Add(perifericos.periferico_vazao3________);
			perifericos.perif_CT850_300.Add(perifericos.periferico_vazao4________);
			perifericos.perif_CT850_300.Add(perifericos.periferico_vazao5________);
			perifericos.perif_CT850_300.Add(perifericos.periferico_vazao6________);
			perifericos.perif_CT850_300.Add(perifericos.periferico_vazao7________);
			perifericos.perif_CT850_300.Add(perifericos.periferico_vazao8________);
			perifericos.perif_CT850_300.Add(perifericos.periferico_GC420__________);
			perifericos.perif_CT850_300.Add(perifericos.periferico_IMS_ST_________);
			perifericos.perif_CT850_300.Add(perifericos.periferico_KRON___________);
			perifericos.perif_CT850_300.Add(perifericos.periferico_INV_Danfoss_VLT);
			perifericos.perif_CT850_300.Add(perifericos.periferico_MUL_SIE_PAC3200);
			perifericos.perif_CT850_300.Add(perifericos.periferico_INV_WEG_CFW09__);
			perifericos.perif_CT850_300.Add(perifericos.periferico_SOFT_WEG_SSW07_);
			perifericos.perif_CT850_300.Add(perifericos.periferico_INT_ELO_2148___);
			perifericos.perif_CT850_300.Add(perifericos.periferico_ANL_AQUACLOR___);
			perifericos.perif_CT850_300.Add(perifericos.periferico_INV_WEG_CFW11__);
			perifericos.perif_CT850_300.Add(perifericos.periferico_INV_WEG_CFW11_B);
			perifericos.perif_CT850_300.Add(perifericos.periferico_CONT_PEXTRON___);
			perifericos.perif_CT850_300.Add(perifericos.periferico_MUL_SCH_PM710__);
			perifericos.perif_CT850_300.Add(perifericos.periferico_INV_SCH_ALT71__);
			perifericos.perif_CT850_300.Add(perifericos.periferico_MUL_SCH_PM1200_);
			perifericos.perif_CT850_300.Add(perifericos.periferico_STEMAC_ST2160__);
			perifericos.perif_CT850_300.Add(perifericos.periferico_SANTERNO_SINUSP);
			perifericos.perif_CT850_300.Add(perifericos.periferico_SIEMENS_PAC3100);
			perifericos.perif_CT850_300.Add(perifericos.periferico_CHEMITEC_50XX__);
			perifericos.perif_CT850_300.Add(perifericos.periferico_ANL_AQUAPRO____);
			perifericos.perif_CT850_300.Add(perifericos.periferico_INV_FRONUIS_ECO);
			perifericos.perif_CT850_300.Add(perifericos.periferico_MODBUD_GENERICO);
			perifericos.perif_CT850_300.Add(perifericos.periferico_ECOMAG_________);
			perifericos.perif_CT850_300.Add(perifericos.periferico_WEG_MMW02______);
			perifericos.perif_CT850_300.Add(perifericos.perfierico_COESTER_ATU_SCR);
			perifericos.perif_CT850_300.Add(perifericos.periferico_WEG_MMW03______);
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x00261A50 File Offset: 0x0025FE50
		public static void Cria_ListaPeriferico_RT820_200()
		{
			perifericos.perif_RT820_200.Clear();
			perifericos.perif_RT820_200.Add(perifericos.periferico_desabilitado__);
			perifericos.perif_RT820_200.Add(perifericos.periferico_GC420__________);
			perifericos.perif_RT820_200.Add(perifericos.periferico_READ_VAZAO_INT_);
			perifericos.perif_RT820_200.Add(perifericos.periferico_READ_VAZAO_EQP_);
			perifericos.perif_RT820_200.Add(perifericos.periferico_IMS_ST_________);
			perifericos.perif_RT820_200.Add(perifericos.periferico_KRON___________);
			perifericos.perif_RT820_200.Add(perifericos.periferico_INV_Danfoss_VLT);
			perifericos.perif_RT820_200.Add(perifericos.periferico_MUL_SIE_PAC3200);
			perifericos.perif_RT820_200.Add(perifericos.periferico_INV_WEG_CFW09__);
			perifericos.perif_RT820_200.Add(perifericos.periferico_SOFT_WEG_SSW07_);
			perifericos.perif_RT820_200.Add(perifericos.periferico_INT_ELO_2148___);
			perifericos.perif_RT820_200.Add(perifericos.periferico_ANL_AQUACLOR___);
			perifericos.perif_RT820_200.Add(perifericos.periferico_INV_WEG_CFW11__);
			perifericos.perif_RT820_200.Add(perifericos.periferico_INV_WEG_CFW11_B);
			perifericos.perif_RT820_200.Add(perifericos.periferico_CONT_PEXTRON___);
			perifericos.perif_RT820_200.Add(perifericos.periferico_MUL_SCH_PM710__);
			perifericos.perif_RT820_200.Add(perifericos.periferico_INV_SCH_ALT71__);
			perifericos.perif_RT820_200.Add(perifericos.periferico_MUL_SCH_PM1200_);
			perifericos.perif_RT820_200.Add(perifericos.periferico_STEMAC_ST2160__);
			perifericos.perif_RT820_200.Add(perifericos.periferico_SANTERNO_SINUSP);
			perifericos.perif_RT820_200.Add(perifericos.periferico_SIEMENS_PAC3100);
			perifericos.perif_RT820_200.Add(perifericos.periferico_CHEMITEC_50XX__);
			perifericos.perif_RT820_200.Add(perifericos.periferico_ANL_AQUAPRO____);
			perifericos.perif_RT820_200.Add(perifericos.periferico_INV_FRONUIS_ECO);
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x00261BD0 File Offset: 0x0025FFD0
		public static void Cria_ListaPeriferico_RT820_300()
		{
			perifericos.perif_RT820_300.Clear();
			perifericos.perif_RT820_300.Add(perifericos.periferico_desabilitado__);
			perifericos.perif_RT820_300.Add(perifericos.periferico_GC420__________);
			perifericos.perif_RT820_300.Add(perifericos.periferico_READ_VAZAO_INT_);
			perifericos.perif_RT820_300.Add(perifericos.periferico_READ_VAZAO_EQP_);
			perifericos.perif_RT820_300.Add(perifericos.periferico_IMS_ST_________);
			perifericos.perif_RT820_300.Add(perifericos.periferico_KRON___________);
			perifericos.perif_RT820_300.Add(perifericos.periferico_INV_Danfoss_VLT);
			perifericos.perif_RT820_300.Add(perifericos.periferico_MUL_SIE_PAC3200);
			perifericos.perif_RT820_300.Add(perifericos.periferico_INV_WEG_CFW09__);
			perifericos.perif_RT820_300.Add(perifericos.periferico_SOFT_WEG_SSW07_);
			perifericos.perif_RT820_300.Add(perifericos.periferico_INT_ELO_2148___);
			perifericos.perif_RT820_300.Add(perifericos.periferico_ANL_AQUACLOR___);
			perifericos.perif_RT820_300.Add(perifericos.periferico_INV_WEG_CFW11__);
			perifericos.perif_RT820_300.Add(perifericos.periferico_INV_WEG_CFW11_B);
			perifericos.perif_RT820_300.Add(perifericos.periferico_CONT_PEXTRON___);
			perifericos.perif_RT820_300.Add(perifericos.periferico_MUL_SCH_PM710__);
			perifericos.perif_RT820_300.Add(perifericos.periferico_INV_SCH_ALT71__);
			perifericos.perif_RT820_300.Add(perifericos.periferico_MUL_SCH_PM1200_);
			perifericos.perif_RT820_300.Add(perifericos.periferico_STEMAC_ST2160__);
			perifericos.perif_RT820_300.Add(perifericos.periferico_SANTERNO_SINUSP);
			perifericos.perif_RT820_300.Add(perifericos.periferico_SIEMENS_PAC3100);
			perifericos.perif_RT820_300.Add(perifericos.periferico_CHEMITEC_50XX__);
			perifericos.perif_RT820_300.Add(perifericos.periferico_ANL_AQUAPRO____);
			perifericos.perif_RT820_300.Add(perifericos.periferico_INV_FRONUIS_ECO);
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x00261D50 File Offset: 0x00260150
		public static void Cria_ListaPeriferico_RT820_360()
		{
			perifericos.perif_RT820_360.Clear();
			perifericos.perif_RT820_360.Add(perifericos.periferico_desabilitado__);
			perifericos.perif_RT820_360.Add(perifericos.periferico_GC420__________);
			perifericos.perif_RT820_360.Add(perifericos.periferico_READ_VAZAO_INT_);
			perifericos.perif_RT820_360.Add(perifericos.periferico_READ_VAZAO_EQP_);
			perifericos.perif_RT820_360.Add(perifericos.periferico_IMS_ST_________);
			perifericos.perif_RT820_360.Add(perifericos.periferico_KRON___________);
			perifericos.perif_RT820_360.Add(perifericos.periferico_INV_Danfoss_VLT);
			perifericos.perif_RT820_360.Add(perifericos.periferico_MUL_SIE_PAC3200);
			perifericos.perif_RT820_360.Add(perifericos.periferico_INV_WEG_CFW09__);
			perifericos.perif_RT820_360.Add(perifericos.periferico_SOFT_WEG_SSW07_);
			perifericos.perif_RT820_360.Add(perifericos.periferico_INT_ELO_2148___);
			perifericos.perif_RT820_360.Add(perifericos.periferico_ANL_AQUACLOR___);
			perifericos.perif_RT820_360.Add(perifericos.periferico_INV_WEG_CFW11__);
			perifericos.perif_RT820_360.Add(perifericos.periferico_INV_WEG_CFW11_B);
			perifericos.perif_RT820_360.Add(perifericos.periferico_CONT_PEXTRON___);
			perifericos.perif_RT820_360.Add(perifericos.periferico_MUL_SCH_PM710__);
			perifericos.perif_RT820_360.Add(perifericos.periferico_INV_SCH_ALT71__);
			perifericos.perif_RT820_360.Add(perifericos.periferico_MUL_SCH_PM1200_);
			perifericos.perif_RT820_360.Add(perifericos.periferico_STEMAC_ST2160__);
			perifericos.perif_RT820_360.Add(perifericos.periferico_SANTERNO_SINUSP);
			perifericos.perif_RT820_360.Add(perifericos.periferico_SIEMENS_PAC3100);
			perifericos.perif_RT820_360.Add(perifericos.periferico_CHEMITEC_50XX__);
			perifericos.perif_RT820_360.Add(perifericos.periferico_ANL_AQUAPRO____);
			perifericos.perif_RT820_360.Add(perifericos.periferico_INV_FRONUIS_ECO);
			perifericos.perif_RT820_360.Add(perifericos.periferico_MODBUD_GENERICO);
			perifericos.perif_RT820_360.Add(perifericos.periferico_ECOMAG_________);
			perifericos.perif_RT820_360.Add(perifericos.periferico_WEG_MMW02______);
			perifericos.perif_RT820_360.Add(perifericos.perfierico_COESTER_ATU_SCR);
			perifericos.perif_RT820_360.Add(perifericos.periferico_WEG_MMW03______);
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x00261F1C File Offset: 0x0026031C
		public static void Cria_Lista_SA_Origem_RT820_400()
		{
			perifericos.Lista_SA_Origem_RT820_400.Clear();
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("Desabilitado", "Desab", 21856, true));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("EA 01", "EA 01", 21857, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("EA 02", "EA 02", 21858, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("EA 03", "EA 03", 21859, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("EA 04", "EA 04", 21860, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("EA 05", "EA 05", 21861, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("EA 06", "EA 06", 21862, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("EA 07", "EA 07", 21863, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("EA 08", "EA 08", 21864, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("EA 09", "EA 09", 21865, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("EA 10", "EA 10", 21866, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("EA 11", "EA 11", 21867, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("EA 12", "EA 12", 21868, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("EA 13", "EA 13", 21869, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("EA 14", "EA 14", 21870, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("EA 15", "EA 15", 21871, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("EA 16", "EA 16", 21872, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("Referência 01", "REF 01", 21873, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("Referência 02", "REF 02", 21874, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("Referência 03", "REF 03", 21875, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("Referência 04", "REF 04", 21876, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("Comunicação 01", "COM 01", 21877, false));
			perifericos.Lista_SA_Origem_RT820_400.Add(new perifericos.Valores_ComboBox("Comunicação 02", "COM 02", 21878, false));
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x002621FC File Offset: 0x002605FC
		public static void Cria_ListaBaudRate_IEC855()
		{
			perifericos.ListaBaudRate_IEC855.Clear();
			perifericos.ListaBaudRate_IEC855.Add(new perifericos.Valores_ComboBox("1200", "1200", 1200, false));
			perifericos.ListaBaudRate_IEC855.Add(new perifericos.Valores_ComboBox("9600", "9600", 9600, true));
			perifericos.ListaBaudRate_IEC855.Add(new perifericos.Valores_ComboBox("19200", "19200", 19200, false));
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x00262270 File Offset: 0x00260670
		public static void Cria_ListaBaudRate()
		{
			perifericos.ListaBaudRate.Clear();
			perifericos.ListaBaudRate.Add(new perifericos.Valores_ComboBox("1200", "1200", 21856, false));
			perifericos.ListaBaudRate.Add(new perifericos.Valores_ComboBox("9600", "9600", 21857, true));
			perifericos.ListaBaudRate.Add(new perifericos.Valores_ComboBox("19200", "19200", 21858, false));
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x002622E4 File Offset: 0x002606E4
		public static int Lista_GetIndicePadrao(List<perifericos.Valores_ComboBox> lista)
		{
			int result = -1;
			int num = 0;
			checked
			{
				int num2 = lista.Count - 1;
				for (int i = Convert.ToInt32(num); i <= num2; i++)
				{
					if (lista[i].is_default)
					{
						result = i;
					}
				}
				return result;
			}
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x0026231C File Offset: 0x0026071C
		public static object Lista_GetValorPadrao(List<perifericos.Valores_ComboBox> lista)
		{
			return lista[perifericos.Lista_GetIndicePadrao(lista)].valor;
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x00262344 File Offset: 0x00260744
		public static bool Lista_ValorPermitido(int valor, List<perifericos.Valores_ComboBox> lista)
		{
			bool result = false;
			int num = 0;
			checked
			{
				int num2 = lista.Count - 1;
				for (int i = Convert.ToInt32(num); i <= num2; i++)
				{
					if (lista[i].valor == valor)
					{
						result = true;
					}
				}
				return result;
			}
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x0026237C File Offset: 0x0026077C
		public static int Get_Indice_Pelo_Valor(int valor, List<perifericos.Valores_ComboBox> lista)
		{
			bool flag = false;
			int num = 0;
			checked
			{
				int num2 = lista.Count - 1;
				int num3 = 0;
				for (int i = Convert.ToInt32(num); i <= num2; i++)
				{
					if (lista[i].valor == valor)
					{
						flag = true;
						num3 = i;
					}
				}
				int result = 0;
				if (flag)
				{
					result = num3;
				}
				else
				{
					result = perifericos.Lista_GetIndicePadrao(lista);
				}
				return result;
			}
		}

		// Token: 0x04001BFA RID: 7162
		private static perifericos.Periferico periferico_desabilitado__ = new perifericos.Periferico("Periférico Desabilitado", "Desab.");

		// Token: 0x04001BFB RID: 7163
		private static perifericos.Periferico periferico_vazao1________ = new perifericos.Periferico("Medição Vazão - 1 canal", "Vazão 1");

		// Token: 0x04001BFC RID: 7164
		private static perifericos.Periferico periferico_vazao2________ = new perifericos.Periferico("Medição Vazão - 2 canais", "Vazão 2");

		// Token: 0x04001BFD RID: 7165
		private static perifericos.Periferico periferico_vazao3________ = new perifericos.Periferico("Medição Vazão - 3 canais", "Vazão 3");

		// Token: 0x04001BFE RID: 7166
		private static perifericos.Periferico periferico_vazao4________ = new perifericos.Periferico("Medição Vazão - 4 canais", "Vazão 4");

		// Token: 0x04001BFF RID: 7167
		private static perifericos.Periferico periferico_vazao5________ = new perifericos.Periferico("Medição Vazão - 5 canais", "Vazão 5");

		// Token: 0x04001C00 RID: 7168
		private static perifericos.Periferico periferico_vazao6________ = new perifericos.Periferico("Medição Vazão - 6 canais", "Vazão 6");

		// Token: 0x04001C01 RID: 7169
		private static perifericos.Periferico periferico_vazao7________ = new perifericos.Periferico("Medição Vazão - 7 canais", "Vazão 7");

		// Token: 0x04001C02 RID: 7170
		private static perifericos.Periferico periferico_vazao8________ = new perifericos.Periferico("Medição Vazão - 8 canais", "Vazão 8");

		// Token: 0x04001C03 RID: 7171
		private static perifericos.Periferico periferico_GC420__________ = new perifericos.Periferico("ICTEL - GC420", "GC420");

		// Token: 0x04001C04 RID: 7172
		private static perifericos.Periferico periferico_IMS_ST_________ = new perifericos.Periferico("Multimedidor IMS mod: Smart Trans", "IMS ST");

		// Token: 0x04001C05 RID: 7173
		private static perifericos.Periferico periferico_KRON___________ = new perifericos.Periferico("Multimedidor KRON mod: Mult K-05", "KRON K-05");

		// Token: 0x04001C06 RID: 7174
		private static perifericos.Periferico periferico_INV_Danfoss_VLT = new perifericos.Periferico("Inversor Danfoss VLT", "DANFOSS VLT");

		// Token: 0x04001C07 RID: 7175
		private static perifericos.Periferico periferico_MUL_SIE_PAC3200 = new perifericos.Periferico("Multimedidor SIEMENS PAC 3200", "PAC3200");

		// Token: 0x04001C08 RID: 7176
		private static perifericos.Periferico periferico_INV_WEG_CFW09__ = new perifericos.Periferico("Inversor WEG CFW09", "WEG CFW09");

		// Token: 0x04001C09 RID: 7177
		private static perifericos.Periferico periferico_SOFT_WEG_SSW07_ = new perifericos.Periferico("Softstarter WEG SSW07", "WEG SSW07");

		// Token: 0x04001C0A RID: 7178
		private static perifericos.Periferico periferico_INT_ELO_2148___ = new perifericos.Periferico("Interface ELO 2148", "ELO 2148");

		// Token: 0x04001C0B RID: 7179
		private static perifericos.Periferico periferico_ANL_AQUACLOR___ = new perifericos.Periferico("Analizador Cloro Thermo AquaChlor", "AquaChlor");

		// Token: 0x04001C0C RID: 7180
		private static perifericos.Periferico periferico_INV_WEG_CFW11__ = new perifericos.Periferico("Inversor WEG CFW11", "WEG CFW11");

		// Token: 0x04001C0D RID: 7181
		private static perifericos.Periferico periferico_INV_WEG_CFW11_B = new perifericos.Periferico("Inversor WEG CFW11 - B", "WEG CFW11-B");

		// Token: 0x04001C0E RID: 7182
		private static perifericos.Periferico periferico_CONT_PEXTRON___ = new perifericos.Periferico("Controlador PEXTRON", "PEXTRON");

		// Token: 0x04001C0F RID: 7183
		private static perifericos.Periferico periferico_MUL_SCH_PM710__ = new perifericos.Periferico("Multimedidor SCHNEIDER - PM710", "PM710");

		// Token: 0x04001C10 RID: 7184
		private static perifericos.Periferico periferico_INV_SCH_ALT71__ = new perifericos.Periferico("Inversor SCHNEIDER - Altivar71", "Altivar71");

		// Token: 0x04001C11 RID: 7185
		private static perifericos.Periferico periferico_MUL_SCH_PM1200_ = new perifericos.Periferico("Multimedidor SCHNEIDER - PM1200", "PM1200");

		// Token: 0x04001C12 RID: 7186
		private static perifericos.Periferico periferico_STEMAC_ST2160__ = new perifericos.Periferico("STEMAC - ST2160", "ST2160");

		// Token: 0x04001C13 RID: 7187
		private static perifericos.Periferico periferico_SANTERNO_SINUSP = new perifericos.Periferico("Multimedidor SIEMENS PAC 3100", "PAC3100");

		// Token: 0x04001C14 RID: 7188
		private static perifericos.Periferico periferico_SIEMENS_PAC3100 = new perifericos.Periferico("SANTERNO Sinus Penta", "SANTERNO");

		// Token: 0x04001C15 RID: 7189
		private static perifericos.Periferico periferico_CHEMITEC_50XX__ = new perifericos.Periferico("Chemitec 50XX", "Chemitec");

		// Token: 0x04001C16 RID: 7190
		private static perifericos.Periferico periferico_ANL_AQUAPRO____ = new perifericos.Periferico("Analizador Thermo Aqua Pro", "AquaPro");

		// Token: 0x04001C17 RID: 7191
		private static perifericos.Periferico periferico_INV_FRONUIS_ECO = new perifericos.Periferico("Inversor Fronius ECO", "Fronius");

		// Token: 0x04001C18 RID: 7192
		private static perifericos.Periferico periferico_MODBUD_GENERICO = new perifericos.Periferico("ModBus Genérico", "ModBus Gen");

		// Token: 0x04001C19 RID: 7193
		private static perifericos.Periferico periferico_ECOMAG_________ = new perifericos.Periferico("ECOMAG", "ECOMAG");

		// Token: 0x04001C1A RID: 7194
		private static perifericos.Periferico periferico_WEG_MMW02______ = new perifericos.Periferico("WEG MMW02", "MMW02");

		// Token: 0x04001C1B RID: 7195
		private static perifericos.Periferico perfierico_COESTER_ATU_SCR = new perifericos.Periferico("COESTER ATUADOR CSR", "COESTER CSR");

		// Token: 0x04001C1C RID: 7196
		private static perifericos.Periferico periferico_WEG_MMW03______ = new perifericos.Periferico("WEG MMW03", "MMW03");

		// Token: 0x04001C1D RID: 7197
		private static perifericos.Periferico periferico_READ_VAZAO_INT_ = new perifericos.Periferico("Leitura de Vazão Interna", "VZ Int");

		// Token: 0x04001C1E RID: 7198
		private static perifericos.Periferico periferico_READ_VAZAO_EQP_ = new perifericos.Periferico("Equipamento Leitura de Vazão", "EQ VZ");

		// Token: 0x04001C1F RID: 7199
		public static List<perifericos.Periferico> perif_CT850_300 = new List<perifericos.Periferico>();

		// Token: 0x04001C20 RID: 7200
		public static List<perifericos.Periferico> perif_RT820_200 = new List<perifericos.Periferico>();

		// Token: 0x04001C21 RID: 7201
		public static List<perifericos.Periferico> perif_RT820_300 = new List<perifericos.Periferico>();

		// Token: 0x04001C22 RID: 7202
		public static List<perifericos.Periferico> perif_RT820_360 = new List<perifericos.Periferico>();

		// Token: 0x04001C23 RID: 7203
		public static List<perifericos.Valores_ComboBox> Lista_SA_Origem_RT820_400 = new List<perifericos.Valores_ComboBox>();

		// Token: 0x04001C24 RID: 7204
		public static List<perifericos.Valores_ComboBox> ListaBaudRate_IEC855 = new List<perifericos.Valores_ComboBox>();

		// Token: 0x04001C25 RID: 7205
		public static List<perifericos.Valores_ComboBox> ListaBaudRate = new List<perifericos.Valores_ComboBox>();

		// Token: 0x020000AC RID: 172
		public class Periferico
		{
			// Token: 0x17000E86 RID: 3718
			// (get) Token: 0x060027EA RID: 10218 RVA: 0x002623C4 File Offset: 0x002607C4
			// (set) Token: 0x060027EB RID: 10219 RVA: 0x002623D8 File Offset: 0x002607D8
			public string nome
			{
				get
				{
					return this._nome;
				}
				set
				{
					this._nome = value;
				}
			}

			// Token: 0x17000E87 RID: 3719
			// (get) Token: 0x060027EC RID: 10220 RVA: 0x002623E4 File Offset: 0x002607E4
			// (set) Token: 0x060027ED RID: 10221 RVA: 0x002623F8 File Offset: 0x002607F8
			public string nome_impressao
			{
				get
				{
					return this._nome_impressao;
				}
				set
				{
					this._nome_impressao = value;
				}
			}

			// Token: 0x060027EE RID: 10222 RVA: 0x00262404 File Offset: 0x00260804
			public Periferico(string nome, string nome_impressao)
			{
				this.nome = nome;
				this.nome_impressao = nome_impressao;
			}
		}

		// Token: 0x020000AD RID: 173
		public class Valores_ComboBox
		{
			// Token: 0x17000E88 RID: 3720
			// (get) Token: 0x060027EF RID: 10223 RVA: 0x0026241C File Offset: 0x0026081C
			// (set) Token: 0x060027F0 RID: 10224 RVA: 0x00262430 File Offset: 0x00260830
			public string nome
			{
				get
				{
					return this._nome;
				}
				set
				{
					this._nome = value;
				}
			}

			// Token: 0x17000E89 RID: 3721
			// (get) Token: 0x060027F1 RID: 10225 RVA: 0x0026243C File Offset: 0x0026083C
			// (set) Token: 0x060027F2 RID: 10226 RVA: 0x00262450 File Offset: 0x00260850
			public string nome_impressao
			{
				get
				{
					return this._nome_impressao;
				}
				set
				{
					this._nome_impressao = value;
				}
			}

			// Token: 0x17000E8A RID: 3722
			// (get) Token: 0x060027F3 RID: 10227 RVA: 0x0026245C File Offset: 0x0026085C
			// (set) Token: 0x060027F4 RID: 10228 RVA: 0x00262470 File Offset: 0x00260870
			public int valor
			{
				get
				{
					return this._valor;
				}
				set
				{
					this._valor = value;
				}
			}

			// Token: 0x17000E8B RID: 3723
			// (get) Token: 0x060027F5 RID: 10229 RVA: 0x0026247C File Offset: 0x0026087C
			// (set) Token: 0x060027F6 RID: 10230 RVA: 0x00262490 File Offset: 0x00260890
			public bool is_default
			{
				get
				{
					return this._is_default;
				}
				set
				{
					this._is_default = value;
				}
			}

			// Token: 0x060027F7 RID: 10231 RVA: 0x0026249C File Offset: 0x0026089C
			public Valores_ComboBox(string nome, string nome_impressao, int valor, bool is_default)
			{
				this.nome = nome;
				this.nome_impressao = nome_impressao;
				this.valor = valor;
				this.is_default = is_default;
			}
		}
	}
}
