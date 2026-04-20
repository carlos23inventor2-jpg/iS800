using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace iS800
{
    public partial class RT_821_380_conf : RT_821_Conf
    {
        private bool _tabsAdjusted;
        private TabPage _tabVazoes;
        private TabPage _tabPerifericos;

        public RT_821_380_conf() : base()
        {
            this.Text = "RT 821 - Versão 3.8";
            this.Load += RT_821_380_conf_Load;
        }

        private void RT_821_380_conf_Load(object sender, EventArgs e)
        {
            AjustaAbas();
        }

        private void AjustaAbas()
        {
            if (_tabsAdjusted)
                return;

            var tab = this.TabControl_821;
            if (tab == null)
                return;

            _tabsAdjusted = true;

            if (_tabVazoes == null)
            {
                _tabVazoes = new TabPage();
                _tabVazoes.Name = "TabPage_Vazoes_380";
                _tabVazoes.Text = "Vazões";
                _tabVazoes.UseVisualStyleBackColor = true;
                var lbl = new Label();
                lbl.AutoSize = true;
                lbl.Location = new Point(16, 16);
                lbl.Text = "Tela de Vazões da versão 3.8";
                _tabVazoes.Controls.Add(lbl);
            }

            if (_tabPerifericos == null)
            {
                _tabPerifericos = new TabPage();
                _tabPerifericos.Name = "TabPage_Perifericos_380";
                _tabPerifericos.Text = "Periféricos";
                _tabPerifericos.UseVisualStyleBackColor = true;
                var lbl = new Label();
                lbl.AutoSize = true;
                lbl.Location = new Point(16, 16);
                lbl.Text = "Tela de Periféricos da versão 3.8";
                _tabPerifericos.Controls.Add(lbl);
            }

            var pages = new[]
            {
                this.TabPage_Display,
                _tabVazoes,
                _tabPerifericos,
                this.TabPage_DadosInstalacao,
                this.TabPage_geral,
                this.TabPage_controles,
                this.TabPage_EA,
                this.TabPage_ED,
                this.TabPage_setpoints,
                this.TabPage_repetidora
            }.Where(p => p != null).Distinct().ToArray();

            tab.SuspendLayout();
            tab.TabPages.Clear();
            foreach (var page in pages)
                tab.TabPages.Add(page);
            tab.ResumeLayout();

            if (tab.TabPages.Count > 0)
                tab.SelectedTab = this.TabPage_Display;
        }
    }
}
