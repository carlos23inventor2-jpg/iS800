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

        private static DataGridViewComboBoxColumn CriaComboColumn(string header, int width)
        {
            return new DataGridViewComboBoxColumn
            {
                HeaderText = header,
                Width = width,
                FlatStyle = FlatStyle.Flat,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox,
                DropDownWidth = Math.Max(width, 120)
            };
        }

        private static void CarregaComboVazao(DataGridViewComboBoxColumn col)
        {
            col.Items.Clear();
            col.Items.Add("Leitura desabilitada");

            for (int i = 1; i <= 16; i++)
                col.Items.Add("Leitura vazão - EA " + i.ToString("0#"));

            int habExp = -1;
            try
            {
                habExp = RT_geral.RT_820_BD.HabExpIO.Valor;
            }
            catch
            {
            }

            int qtdEd = (habExp == 21857) ? 16 : 8;

            for (int i = 1; i <= qtdEd; i++)
            {
                col.Items.Add("ED - " + i.ToString("0#"));
                col.Items.Add("ED - " + i.ToString("0#") + " reverso");
            }
        }

        private static void CarregaComboPerifericosModelos(DataGridViewComboBoxColumn col)
        {
            col.Items.Clear();

            try
            {
                perifericos.Cria_ListaPeriferico_RT820_300();
            }
            catch
            {
            }

            try
            {
                if (perifericos.perif_RT820_300 != null)
                {
                    foreach (var p in perifericos.perif_RT820_300)
                        col.Items.Add(p.nome);
                }
            }
            catch
            {
            }

            if (!col.Items.Contains("ModBUS Genérico"))
                col.Items.Add("ModBUS Genérico");
        }

        private static void CarregaComboReferenciaPerifericos(DataGridViewComboBoxColumn col)
        {
            col.Items.Clear();
            col.Items.Add("Desabilitado");
            col.Items.Add("Periférico 1");
            col.Items.Add("Periférico 2");
            col.Items.Add("Periférico 3");
            col.Items.Add("Periférico 4");
            col.Items.Add("Periférico 5");
            col.Items.Add("ModBUS Genérico");
        }

        private static void CarregaComboReferenciaVariavel1(DataGridViewComboBoxColumn col)
        {
            col.Items.Clear();

            for (int i = 1; i <= 16; i++)
                col.Items.Add("EA - " + i.ToString("0#"));

            for (int i = 1; i <= 4; i++)
                col.Items.Add("Referência " + i.ToString("#"));
        }

        private static void CarregaComboReferenciaVariavel2(DataGridViewComboBoxColumn col)
        {
            col.Items.Clear();

            for (int i = 1; i <= 16; i++)
                col.Items.Add("EA - " + i.ToString("0#"));
        }

        private static void CarregaComboReferenciaFormato(DataGridViewComboBoxColumn col)
        {
            col.Items.Clear();
            col.Items.Add("Integer");
            col.Items.Add("Integer SWAP");
            col.Items.Add("Long");
            col.Items.Add("Long Inverso");
            col.Items.Add("Long SWAP");
        }

        private static void CarregaComboReferenciaBase10(DataGridViewComboBoxColumn col)
        {
            col.Items.Clear();
            col.Items.Add("0");
            col.Items.Add(".0");
            col.Items.Add(".00");
            col.Items.Add(".000");
        }

        private void GeraDataGridView_Vazoes(DataGridView dgv)
        {
            dgv.SuspendLayout();
            dgv.Columns.Clear();
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.RowHeadersVisible = true;
            dgv.ScrollBars = ScrollBars.None;

            var colEntrada = CriaComboColumn("Entrada", 200);
            CarregaComboVazao(colEntrada);
            dgv.Columns.Add(colEntrada);

            dgv.RowCount = 8;
            dgv.RowHeadersWidth = 80;

            int num = 1;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.HeaderCell.Value = "Vazão " + num.ToString();
                    num++;
                }
            }

            dgv.Width = 200 + dgv.RowHeadersWidth + 20;
            dgv.Height = 239;
            dgv.ResumeLayout();
        }

        private void GeraDataGridView_Perifericos(DataGridView dgv)
        {
            dgv.SuspendLayout();
            dgv.Columns.Clear();
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.RowHeadersVisible = true;
            dgv.ScrollBars = ScrollBars.None;

            var colModelo = CriaComboColumn("Modelo", 250);
            CarregaComboPerifericosModelos(colModelo);
            dgv.Columns.Add(colModelo);

            var colEndereco = new DataGridViewTextBoxColumn
            {
                HeaderText = "Endereço",
                Width = 60,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            dgv.Columns.Add(colEndereco);

            dgv.RowCount = 5;
            dgv.RowHeadersWidth = 100;

            int num = 1;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.HeaderCell.Value = "Periférico " + num.ToString();
                    num++;
                }
            }

            dgv.Width = 250 + 60 + dgv.RowHeadersWidth + 20;
            dgv.Height = 133;
            dgv.ResumeLayout();
        }

        private void GeraDataGridView_Referencia_Periferico(DataGridView dgv)
        {
            dgv.SuspendLayout();
            dgv.Columns.Clear();
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.RowHeadersVisible = true;
            dgv.ScrollBars = ScrollBars.None;

            var colPerif = CriaComboColumn("Periférico", 100);
            CarregaComboReferenciaPerifericos(colPerif);
            dgv.Columns.Add(colPerif);

            var colVar1 = CriaComboColumn("Variável1", 100);
            CarregaComboReferenciaVariavel1(colVar1);
            dgv.Columns.Add(colVar1);

            var colVar2 = CriaComboColumn("Variável2", 100);
            CarregaComboReferenciaVariavel2(colVar2);
            dgv.Columns.Add(colVar2);

            var colEscala = new DataGridViewTextBoxColumn
            {
                HeaderText = "Escala",
                Width = 80,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
            dgv.Columns.Add(colEscala);

            var colFormato = CriaComboColumn("Formato", 100);
            CarregaComboReferenciaFormato(colFormato);
            dgv.Columns.Add(colFormato);

            var colBase10 = CriaComboColumn("Base 10", 100);
            CarregaComboReferenciaBase10(colBase10);
            dgv.Columns.Add(colBase10);

            dgv.RowCount = 10;
            dgv.RowHeadersWidth = 50;

            int num = 1;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.HeaderCell.Value = num.ToString();
                    num++;
                }
            }

            dgv.Width = 693 + dgv.RowHeadersWidth + 20;
            dgv.Height = 276;
            dgv.ResumeLayout();
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

            var dgvVazoes = new DataGridView
            {
                Name = "DataGridView_vazoes_RT820",
                Location = new Point(18, 22),
                Size = new Size(280, 200)
            };
            GeraDataGridView_Vazoes(dgvVazoes);
            grpVazoes.Controls.Add(dgvVazoes);

            var grpCalhas = new GroupBox
            {
                Name = "GroupBox_calhas_820",
                Text = "Calhas",
                Location = new Point(360, 16),
                Size = new Size(860, 540)
            };

            var tbCalhas = new TextBox
            {
                Name = "tb_lixo6",
                Location = new Point(19, 23),
                Size = new Size(100, 20)
            };
            grpCalhas.Controls.Add(tbCalhas);

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

            var tab1 = new TabPage("General Parshall Flume");
            tab1.Controls.Add(new Label
            {
                Text = "Visão Superior / Visão Lateral",
                AutoSize = true,
                Location = new Point(20, 20)
            });

            var tab2 = new TabPage("Botton Step Weir");
            tab2.Controls.Add(new Label
            {
                Text = "Configuração da calha",
                AutoSize = true,
                Location = new Point(20, 20)
            });

            var tab3 = new TabPage("Supressed Rectangular");
            tab3.Controls.Add(new Label
            {
                Text = "Configuração da calha",
                AutoSize = true,
                Location = new Point(20, 20)
            });

            tabsCalha.TabPages.Add(tab1);
            tabsCalha.TabPages.Add(tab2);
            tabsCalha.TabPages.Add(tab3);
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
                Size = new Size(412, 133)
            };
            GeraDataGridView_Perifericos(dgv1);
            grp1.Controls.Add(dgv1);

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
            dgv3.RowHeadersWidth = 80;
            int num3 = 1;
            foreach (DataGridViewRow row in dgv3.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.HeaderCell.Value = "ModBUS Genérico " + num3.ToString();
                    num3++;
                }
            }

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
                Location = new Point(19, 16),
                Size = new Size(693, 276)
            };
            GeraDataGridView_Referencia_Periferico(dgv4);
            grp4.Controls.Add(dgv4);

            var lblObs = new Label
            {
                Text = "Observação: Opção disponível a partir da versão 3.50",
                AutoSize = true,
                Location = new Point(16, 294)
            };
            grp4.Controls.Add(lblObs);

            tab.Controls.Add(grp1);
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

            if (tab.TabPages.Count > 0 && this.TabPage_geral != null)
                tab.SelectedTab = this.TabPage_geral;
        }
    }
}