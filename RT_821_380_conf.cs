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
            this.Text = "RT 821 - Versão 3.8";
            this.Load += RT_821_380_conf_Load;
        }

        private void RT_821_380_conf_Load(object sender, EventArgs e)
        {
            AjustaAbas();
        }

        private static void PreencheComboVazao(ComboBox cb)
        {
            cb.Items.Clear();
            cb.Items.Add("Leitura Desabilitada");
            for (int i = 1; i <= 16; i++)
                cb.Items.Add("Leitura Vazão EA " + i.ToString("00"));
            for (int i = 1; i <= 16; i++)
            {
                cb.Items.Add("Leitura Vazão ED " + i.ToString("00"));
                cb.Items.Add("Leitura Vazão ED " + i.ToString("00") + " reverso");
            }
            cb.SelectedIndex = 0;
        }

        private TabPage CriaTabVasosCalhas()
        {
            var tab = new TabPage
            {
                Name = "TabPage_vazao_perifericos",
                Text = "Vazões e Periféricos",
                UseVisualStyleBackColor = true,
                BackColor = SystemColors.ControlLight
            };

            var grpVazoes = new GroupBox
            {
                Name = "GroupBox_vazoes_820",
                Text = "Vazões",
                Location = new Point(28, 16),
                Size = new Size(320, 239)
            };

            var gridHeader = new Label
            {
                Text = "Entrada",
                AutoSize = true,
                Location = new Point(110, 18)
            };
            grpVazoes.Controls.Add(gridHeader);

            var rows = new[]
            {
                "Vazão 1", "Vazão 2", "Vazão 3", "Vazão 4",
                "Vazão 5", "Vazão 6", "Vazão 7", "Vazão 8"
            };

            for (int i = 0; i < rows.Length; i++)
            {
                int y = 38 + (i * 21);

                var lbl = new Label
                {
                    Text = rows[i],
                    AutoSize = true,
                    Location = new Point(10, y + 2)
                };

                var cb = new ComboBox
                {
                    Name = "cb_vazao_" + (i + 1),
                    Location = new Point(90, y),
                    Size = new Size(180, 21),
                    DropDownStyle = ComboBoxStyle.DropDownList
                };
                PreencheComboVazao(cb);

                grpVazoes.Controls.Add(lbl);
                grpVazoes.Controls.Add(cb);
            }

            var grpCalhas = new GroupBox
            {
                Name = "GroupBox_calhas_820",
                Text = "Calhas",
                Location = new Point(360, 16),
                Size = new Size(860, 540)
            };

            var txtCalhas = new TextBox
            {
                Name = "tb_calhas",
                Location = new Point(20, 28),
                Size = new Size(76, 20)
            };
            grpCalhas.Controls.Add(txtCalhas);

            var lblDesc = new Label
            {
                Text = "Descritivo de parâmetros das calhas:",
                AutoSize = true,
                Location = new Point(20, 160)
            };
            grpCalhas.Controls.Add(lblDesc);

            var tabsCalha = new TabControl
            {
                Name = "TabControl_calhas",
                Location = new Point(20, 180),
                Size = new Size(780, 330)
            };

            tabsCalha.TabPages.Add(new TabPage("General Parshall Flume"));
            tabsCalha.TabPages.Add(new TabPage("Botton Step Weir"));
            tabsCalha.TabPages.Add(new TabPage("Supressed Rectangular"));

            tabsCalha.TabPages[0].Controls.Add(new Label
            {
                Text = "Visão Superior / Visão Lateral",
                AutoSize = true,
                Location = new Point(20, 20)
            });

            grpCalhas.Controls.Add(tabsCalha);

            tab.Controls.Add(grpVazoes);
            tab.Controls.Add(grpCalhas);
            return tab;
        }

        private TabPage CriaTabPerifericos()
        {
            var tab = new TabPage
            {
                Name = "TabPage_perifericos",
                Text = "Periféricos",
                UseVisualStyleBackColor = true,
                BackColor = SystemColors.ControlLight
            };

            var grp1 = new GroupBox
            {
                Text = "Periféricos do 1° Endereço da Estação",
                Location = new Point(18, 16),
                Size = new Size(465, 182)
            };

            var dgv1 = new DataGridView
            {
                Name = "DataGridView_periferico_RT820",
                Location = new Point(12, 22),
                Size = new Size(412, 133),
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeColumns = false,
                AllowUserToResizeRows = false,
                RowHeadersVisible = true,
                ScrollBars = ScrollBars.None
            };
            dgv1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "", Width = 110 });
            dgv1.Columns.Add(new DataGridViewComboBoxColumn { HeaderText = "Modelo", Width = 200 });
            dgv1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Endereço", Width = 90 });
            dgv1.RowCount = 5;
            for (int i = 0; i < dgv1.RowCount; i++)
                dgv1.Rows[i].HeaderCell.Value = "Periférico " + (i + 1);

            grp1.Controls.Add(dgv1);

            var grp2 = new GroupBox
            {
                Text = "Periféricos do 2° Endereço da Estação",
                Location = new Point(495, 16),
                Size = new Size(465, 182)
            };

            var dgv2 = new DataGridView
            {
                Name = "DataGridView_periferico_RT820_2",
                Location = new Point(12, 22),
                Size = new Size(412, 133),
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeColumns = false,
                AllowUserToResizeRows = false,
                RowHeadersVisible = true,
                ScrollBars = ScrollBars.None
            };
            dgv2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "", Width = 110 });
            dgv2.Columns.Add(new DataGridViewComboBoxColumn { HeaderText = "Modelo", Width = 200 });
            dgv2.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Endereço", Width = 90 });
            dgv2.RowCount = 5;
            for (int i = 0; i < dgv2.RowCount; i++)
                dgv2.Rows[i].HeaderCell.Value = "Periférico " + (i + 1);

            grp2.Controls.Add(dgv2);

            var grp3 = new GroupBox
            {
                Text = "Configuração Periférico Modbus Genérico",
                Location = new Point(18, 212),
                Size = new Size(900, 145)
            };

            var dgv3 = new DataGridView
            {
                Name = "dgv_modbus_generico",
                Location = new Point(12, 22),
                Size = new Size(790, 100),
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeColumns = false,
                AllowUserToResizeRows = false,
                RowHeadersVisible = true,
                ScrollBars = ScrollBars.None
            };
            dgv3.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Endereço", Width = 80 });
            dgv3.Columns.Add(new DataGridViewComboBoxColumn { HeaderText = "Função", Width = 90 });
            dgv3.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Memória1", Width = 70 });
            dgv3.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Variável1", Width = 75 });
            dgv3.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Memória2", Width = 70 });
            dgv3.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Variável2", Width = 75 });
            dgv3.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Memória3", Width = 70 });
            dgv3.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Variável3", Width = 75 });
            dgv3.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Memória4", Width = 70 });
            dgv3.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Variável4", Width = 75 });
            dgv3.RowCount = 5;
            for (int i = 0; i < dgv3.RowCount; i++)
                dgv3.Rows[i].HeaderCell.Value = "ModBUS Genérico " + (i + 1);

            grp3.Controls.Add(dgv3);

            var grp4 = new GroupBox
            {
                Text = "Referências para Periférico:",
                Location = new Point(18, 366),
                Size = new Size(900, 314)
            };

            var dgv4 = new DataGridView
            {
                Name = "datagridview_referenciaperifico",
                Location = new Point(12, 20),
                Size = new Size(693, 276),
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeColumns = false,
                AllowUserToResizeRows = false,
                RowHeadersVisible = true,
                ScrollBars = ScrollBars.None
            };
            dgv4.Columns.Add(new DataGridViewComboBoxColumn { HeaderText = "Periférico", Width = 95 });
            dgv4.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Memória", Width = 85 });
            dgv4.Columns.Add(new DataGridViewComboBoxColumn { HeaderText = "Variável1", Width = 110 });
            dgv4.Columns.Add(new DataGridViewComboBoxColumn { HeaderText = "Variável2", Width = 110 });
            dgv4.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Escala", Width = 70 });
            dgv4.Columns.Add(new DataGridViewComboBoxColumn { HeaderText = "Formato", Width = 90 });
            dgv4.Columns.Add(new DataGridViewComboBoxColumn { HeaderText = "Base 10", Width = 80 });
            dgv4.RowCount = 10;
            for (int i = 0; i < dgv4.RowCount; i++)
                dgv4.Rows[i].HeaderCell.Value = (i + 1).ToString();

            var lblObs = new Label
            {
                Text = "Observação: Opção disponível a partir da versão 3.50",
                AutoSize = true,
                Location = new Point(16, 294)
            };

            grp4.Controls.Add(dgv4);
            grp4.Controls.Add(lblObs);

            tab.Controls.Add(grp1);
            tab.Controls.Add(grp2);
            tab.Controls.Add(grp3);
            tab.Controls.Add(grp4);

            return tab;
        }

        private void AjustaAbas()
        {
            if (_tabsAdjusted) return;
            var tab = this.TabControl_821;
            if (tab == null) return;
            _tabsAdjusted = true;

            var pages = new TabPage[]
            {
                this.TabPage_geral,
                this.TabPage_controles,
                this.TabPage_EA,
                this.TabPage_ED,
                this.TabPage_setpoints,
                this.TabPage_repetidora,
                this.TabPage_Display,
                CriaTabVasosCalhas(),
                CriaTabPerifericos(),
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

