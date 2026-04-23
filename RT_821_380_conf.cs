using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace iS800
{
    public partial class RT_821_380_conf : RT_821_Conf
    {
        private bool _tabsAdjusted;

        public RT_821_380_conf() : base()
        {
            InitializeComponent();
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

            // Captura as abas do Designer ANTES de limpar
            var allTabs = tab.TabPages.Cast<TabPage>().ToList();
            var tabVazao = allTabs.FirstOrDefault(t => t.Name == "TabPage_vazao");
            var tabPerif = allTabs.FirstOrDefault(t => t.Name == "TabPage_vazao_perifericos");

            var pages = new TabPage[]
            {
                this.TabPage_geral,
                this.TabPage_controles,
                this.TabPage_EA,
                this.TabPage_ED,
                this.TabPage_setpoints,
                this.TabPage_repetidora,
                this.TabPage_Display,
                tabVazao,
                tabPerif,
                this.TabPage_DadosInstalacao
            }.Where(p => p != null).Distinct().ToArray();

            tab.SuspendLayout();
            tab.TabPages.Clear();
            foreach (var page in pages)
                tab.TabPages.Add(page);
            tab.ResumeLayout();

            if (tab.TabPages.Count > 0)
                tab.SelectedTab = this.TabPage_geral;
        }
    }
}
