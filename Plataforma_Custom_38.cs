using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace iS800
{
    public partial class Plataforma
    {
        private bool _menu821_38_added;

        private void AdicionaMenuRT821_380()
        {
            if (_menu821_38_added)
                return;

            _menu821_38_added = true;

            if (this.ToolStripComboBox_versao != null && this.ToolStripComboBox_versao.Items != null)
            {
                bool exists = false;
                foreach (object item in this.ToolStripComboBox_versao.Items)
                {
                    if (string.Equals(Convert.ToString(item), "Versão 3.8", StringComparison.OrdinalIgnoreCase))
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                    this.ToolStripComboBox_versao.Items.Add("Versão 3.8");
            }

            if (this.RT821ToolStripMenuItem != null)
            {
                bool exists = false;
                foreach (ToolStripItem item in this.RT821ToolStripMenuItem.DropDownItems)
                {
                    if (item.Text == "Versão 3.8")
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    var item38 = new ToolStripMenuItem("Versão 3.8");
                    item38.Click += RT821_Versão38ToolStripMenuItem_Click;
                    this.RT821ToolStripMenuItem.DropDownItems.Add(item38);
                }
            }
        }

        private void RT821_Versão38ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Comunicacao.Config_sistema.tipo_interface != 1)
            {
                Interaction.MsgBox("Equipamento não suporta a interface selecionada", (MsgBoxStyle)0, null);
                return;
            }

            Geral.Ctrl_equipamento = (HorizontalAlignment)3000;
            Geral.Ctrl_versao = (HorizontalAlignment)38;
            Geral.Ctrl_operacao = (HorizontalAlignment)100000;
            if (this.ToolStripComboBox_versao != null && this.ToolStripComboBox_versao.Items.Count > 2)
                this.ToolStripComboBox_versao.SelectedIndex = (HorizontalAlignment)2;
            this.ToolStripComboBox_equipamento.SelectedIndex = (HorizontalAlignment)3;
            RT_geral.Lmte_Init_ok = false;
            this.Seleciona_tela(true);
        }
    }
}
