using System.Drawing;
using System.Windows.Forms;
﻿using System.Drawing;
using System.Windows.Forms;
﻿
using System;

namespace iS800
{
    public partial class Plataforma
    {
        private ToolStripMenuItem _RT821_Versao380;

        private void ConfigurarMenusRT821Extras()
        {
            if (this.RT821ToolStripMenuItem == null)
            {
                return;
            }

            if (this._RT821_Versao380 != null)
            {
                return;
            }

            this._RT821_Versao380 = new ToolStripMenuItem();
            this._RT821_Versao380.Name = "RT821_Versao380ToolStripMenuItem";
            this._RT821_Versao380.Text = "Versão 3.80";
            this._RT821_Versao380.Click += new EventHandler(this.RT821_Versao380_Click);

            this.RT821ToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            this.RT821ToolStripMenuItem.DropDownItems.Add(this._RT821_Versao380);
        }

        private void RT821_Versao380_Click(object sender, EventArgs e)
        {
            try
            {
                Geral.Ctrl_equipamento = (HorizontalAlignment)3000;
                Geral.Ctrl_versao = (HorizontalAlignment)30;
                Geral.Ctrl_operacao = (HorizontalAlignment)100000;
                this.ToolStripComboBox_versao.SelectedIndex = (HorizontalAlignment)1;
                this.ToolStripComboBox_equipamento.SelectedIndex = (HorizontalAlignment)3;
                Geral.Equipamento_selecionado = (HorizontalAlignment)821;
                Geral.Equipamento_versao = (HorizontalAlignment)3;
                Geral.Equipamento_build = (HorizontalAlignment)0;
                RT_geral.Lmte_Init_ok = false;
                RT_geral.Telas_RT_821.Configuracao = true;
                new RT_821_380_conf
                {
                    MdiParent = this,
                    StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
                }.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
