
using System;
using System.Windows.Forms;

namespace iS800
{
    public partial class Plataforma
    {
        private ToolStripMenuItem _RT821_Versao380;
        private ToolStripMenuItem _RT821_Perifericos;
        private ToolStripMenuItem _RT821_Perifericos_Modbus;
        private ToolStripMenuItem _RT821_Perifericos_Expansoes;

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

            this._RT821_Perifericos = new ToolStripMenuItem();
            this._RT821_Perifericos.Name = "RT821_PerifericosToolStripMenuItem";
            this._RT821_Perifericos.Text = "Periféricos";

            this._RT821_Perifericos_Modbus = new ToolStripMenuItem();
            this._RT821_Perifericos_Modbus.Name = "RT821_Perifericos_ModbusToolStripMenuItem";
            this._RT821_Perifericos_Modbus.Text = "Modbus";
            this._RT821_Perifericos_Modbus.Click += new EventHandler(this.RT821_PerifericosModbus_Click);

            this._RT821_Perifericos_Expansoes = new ToolStripMenuItem();
            this._RT821_Perifericos_Expansoes.Name = "RT821_Perifericos_ExpansoesToolStripMenuItem";
            this._RT821_Perifericos_Expansoes.Text = "Expansões";
            this._RT821_Perifericos_Expansoes.Click += new EventHandler(this.RT821_PerifericosExpansoes_Click);

            this._RT821_Perifericos.DropDownItems.Add(this._RT821_Perifericos_Modbus);
            this._RT821_Perifericos.DropDownItems.Add(this._RT821_Perifericos_Expansoes);

            this.RT821ToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            this.RT821ToolStripMenuItem.DropDownItems.Add(this._RT821_Versao380);
            this.RT821ToolStripMenuItem.DropDownItems.Add(this._RT821_Perifericos);
        }

        private void RT821_Versao380_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void RT821_PerifericosModbus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu de periféricos RT821 3.80");
        }

        private void RT821_PerifericosExpansoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Expansões RT821 3.80");
        }
    }
}
