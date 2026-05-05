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
          AddTabsOnly();
          this.Load += RT_821_380_conf_Load;
     }

        private void RT_821_380_conf_Load(object sender, EventArgs e)
        {
            // Inicializa as estruturas de dados do RT_820 antes de gerar os grids
            InicializaEstrutura_DataGridView_Vazoes();
            InicializaEstrutura_DataGridView_Calhas();
            InicializaEstrutura_DataGridView_Periferico();
            InicializaEstrutura_DataGridView_Referencia_Periferico();
            ConfiguraAbasDesigner();

            AjustaAbas();
        }

        // ─────────────────────────────────────────────────────────────────────
        // InicializaEstrutura — idêntico ao RT_820_conf, popula os arrays do
        // RT_geral para que os métodos GeraDataGridView_* possam lê-los via
        // Linha_RT.CreateComboBoxColumn / CreateTextColumn.
        // ─────────────────────────────────────────────────────────────────────

        private void InicializaEstrutura_DataGridView_Vazoes()
        {
            int qtdEd;
            try { qtdEd = (RT_geral.RT_820_BD.HabExpIO.Valor == 21857) ? 16 : 8; }
            catch { qtdEd = 8; }

            // 1 (desab) + 16 (EA) + qtdEd*2 (ED+reverso) + 2 (calhas)
            int total = 1 + 16 + qtdEd * 2 + 2;
            RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu  = new string[total];
            RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor = new int[total];

            RT_geral.RT_820_DataGrigViewVazoesColunas[0].TagColuna     = "Entrada";
            RT_geral.RT_820_DataGrigViewVazoesColunas[0].NomeColuna    = "Entrada";
            RT_geral.RT_820_DataGrigViewVazoesColunas[0].LarguraColuna = 200;
            RT_geral.RT_820_DataGrigViewVazoesColunas[0].AlingColuna   =
                DataGridViewContentAlignment.MiddleLeft;
            RT_geral.RT_820_DataGrigViewVazoesColunas[0].NumeroLinhaMenu = total;

            RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[0] = 21856;
            RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[0]  = "Leitura desabilitada";

            for (int i = 1; i <= 16; i++)
            {
                RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[i] = 21856 + i;
                RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[i]  =
                    "Leitura vazao - EA " + i.ToString("0#");
            }

            // ED e ED reverso (base 21873 igual ao RT_820_360)
            int baseEdVal = 21873;
            for (int i = 1; i <= qtdEd; i++)
            {
                int baseIdx = 17 + (i - 1) * 2;
                RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[baseIdx]     = baseEdVal + (i - 1) * 2;
                RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[baseIdx]      =
                    "Leitura vazao - ED" + i.ToString();
                RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[baseIdx + 1] = baseEdVal + (i - 1) * 2 + 1;
                RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[baseIdx + 1]  =
                    "Leitura vazao - ED" + i.ToString() + " reverso";
            }

            // Calha 1 e Calha 2 nos dois ultimos slots
            int idxCalha = 1 + 16 + qtdEd * 2;
            RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[idxCalha]     = 21905;
            RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[idxCalha]      = "Leitura - Calha 1";
            RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasValor[idxCalha + 1] = 21906;
            RT_geral.RT_820_DataGrigViewVazoesColunas[0].LinhasMenu[idxCalha + 1]  = "Leitura - Calha 2";
        }

        private void InicializaEstrutura_DataGridView_Calhas()
        {
            string[] tagCols  = { "EA", "Tipo Calha", "Altura Max(20mA) cm", "P1 cm", "P2 cm", "P3 cm" };
            string[] nomeCols = { "ea", "calha", "fundo_cm", "p1", "p2", "p3" };
            int[]    larguras = { 80, 150, 150, 80, 80, 80 };

            RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu  = new string[17];
            RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor = new int[17];
            RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasMenu  = new string[5];
            RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasValor = new int[5];

            for (int i = 0; i <= 5; i++)
            {
                RT_geral.RT_820_DatagridViewCalhasColunas[i].TagColuna     = tagCols[i];
                RT_geral.RT_820_DatagridViewCalhasColunas[i].NomeColuna    = nomeCols[i];
                RT_geral.RT_820_DatagridViewCalhasColunas[i].LarguraColuna = larguras[i];
                RT_geral.RT_820_DatagridViewCalhasColunas[i].AlingColuna   =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            RT_geral.RT_820_DatagridViewCalhasColunas[0].NumeroLinhaMenu = 16;
            RT_geral.RT_820_DatagridViewCalhasColunas[1].NumeroLinhaMenu = 4;

            for (int i = 0; i <= 15; i++)
            {
                RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasValor[i] = 21857 + i;
                RT_geral.RT_820_DatagridViewCalhasColunas[0].LinhasMenu[i]  = "EA" + (i + 1).ToString();
            }

            RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasValor[0] = 0;
            RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasValor[1] = 1;
            RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasValor[2] = 2;
            RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasValor[3] = 3;
            RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasMenu[0]  = "Sem Calha";
            RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasMenu[1]  = "General Parshal Flume";
            RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasMenu[2]  = "Botton Step Weir";
            RT_geral.RT_820_DatagridViewCalhasColunas[1].LinhasMenu[3]  = "Supressed Retangular";
        }
        private void InicializaEstrutura_DataGridView_Periferico()
        {
            try { perifericos.Cria_ListaPeriferico_RT820_300(); } catch { }

            int count = 0;
            try { count = perifericos.perif_RT820_300?.Count ?? 0; } catch { }

            for (int i = 0; i <= 1; i++)
            {
                RT_geral.RT_820_DataGrigViewPerifericosColunas[i].LinhasMenu  = new string[count + 1];
                RT_geral.RT_820_DataGrigViewPerifericosColunas[i].LinhasValor = new int[count + 1];
            }

            RT_geral.RT_820_DataGrigViewPerifericosColunas[0].TagColuna    = "Modelo";
            RT_geral.RT_820_DataGrigViewPerifericosColunas[1].TagColuna    = "Endereço";
            RT_geral.RT_820_DataGrigViewPerifericosColunas[0].NomeColuna   = "modelo";
            RT_geral.RT_820_DataGrigViewPerifericosColunas[1].NomeColuna   = "end";
            RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LarguraColuna = 250;
            RT_geral.RT_820_DataGrigViewPerifericosColunas[1].LarguraColuna = 60;
            RT_geral.RT_820_DataGrigViewPerifericosColunas[0].AlingColuna  = DataGridViewContentAlignment.MiddleLeft;
            RT_geral.RT_820_DataGrigViewPerifericosColunas[1].AlingColuna  = DataGridViewContentAlignment.MiddleCenter;
            RT_geral.RT_820_DataGrigViewPerifericosColunas[0].NumeroLinhaMenu = count;
            RT_geral.RT_820_DataGrigViewPerifericosColunas[1].NumeroLinhaMenu = 0;

            int n = 0;
            int baseVal = 48;
            try
            {
                foreach (var p in perifericos.perif_RT820_300)
                {
                    RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[n]  = p.nome;
                    RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[n] = baseVal + n;
                    n++;
                }
            }
            catch { }

            // Adiciona "ModBUS Genérico" como último item, se não existir
            if (!RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu
                    .Take(count).Contains("ModBUS Genérico"))
            {
                RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasMenu[count]  = "ModBUS Genérico";
                RT_geral.RT_820_DataGrigViewPerifericosColunas[0].LinhasValor[count] = baseVal + count;
                RT_geral.RT_820_DataGrigViewPerifericosColunas[0].NumeroLinhaMenu    = count + 1;
            }
        }

        private void InicializaEstrutura_DataGridView_Referencia_Periferico()
        {
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu  = new string[7];
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor = new int[7];
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasMenu  = new string[21];
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasValor = new int[21];
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LinhasMenu  = new string[17];
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LinhasValor = new int[17];
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasMenu  = new string[6];
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor = new int[6];
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasMenu  = new string[5];
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasValor = new int[5];

            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].TagColuna = "Periférico";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[1].TagColuna = "Memória";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].TagColuna = "Variável1";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].TagColuna = "Variável2";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[4].TagColuna = "Escala";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].TagColuna = "Formato";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].TagColuna = "Base 10";

            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].NomeColuna = "perif";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[1].NomeColuna = "endmem";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].NomeColuna = "var1";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].NomeColuna = "var2";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[4].NomeColuna = "escala";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].NomeColuna = "formato";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].NomeColuna = "base10";

            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].NumeroLinhaMenu = 6;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[1].NumeroLinhaMenu = 0;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].NumeroLinhaMenu = 20;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].NumeroLinhaMenu = 16;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[4].NumeroLinhaMenu = 0;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].NumeroLinhaMenu = 5;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].NumeroLinhaMenu = 4;

            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LarguraColuna = 90;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[1].LarguraColuna = 60;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LarguraColuna = 90;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LarguraColuna = 65;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[4].LarguraColuna = 50;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LarguraColuna = 100;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LarguraColuna = 50;

            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].AlingColuna = DataGridViewContentAlignment.MiddleLeft;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[1].AlingColuna = DataGridViewContentAlignment.MiddleCenter;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].AlingColuna = DataGridViewContentAlignment.MiddleLeft;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].AlingColuna = DataGridViewContentAlignment.MiddleLeft;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[4].AlingColuna = DataGridViewContentAlignment.MiddleCenter;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].AlingColuna = DataGridViewContentAlignment.MiddleLeft;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].AlingColuna = DataGridViewContentAlignment.MiddleLeft;

            // Coluna 0 — Periférico
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor[0] = 0;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor[1] = 1;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor[2] = 2;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor[3] = 3;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor[4] = 4;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasValor[5] = 5;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu[0]  = "Desabilitado";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu[1]  = "Periférico 1";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu[2]  = "Periférico 2";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu[3]  = "Periférico 3";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu[4]  = "Periférico 4";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[0].LinhasMenu[5]  = "Periférico 5";

            // Coluna 2 — Variável1: EA 01-16 + Referência 1-4
            for (int i = 0; i <= 15; i++)
            {
                RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasValor[i] = 21857 + i;
                RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasMenu[i]  =
                    "EA - " + (i + 1).ToString("0#");
            }
            for (int i = 16; i <= 19; i++)
            {
                RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasValor[i] = 21868 + i;
                RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[2].LinhasMenu[i]  =
                    "Referência " + (i - 15).ToString("#");
            }

            // Coluna 3 — Variável2: EA 01-16
            for (int i = 0; i <= 15; i++)
            {
                RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LinhasValor[i] = 21857 + i;
                RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[3].LinhasMenu[i]  =
                    "EA - " + (i + 1).ToString("0#");
            }

            // Coluna 5 — Formato
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor[0] = 0;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor[1] = 1;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor[2] = 2;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor[3] = 3;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasValor[4] = 4;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasMenu[0]  = "Integer";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasMenu[1]  = "Integer SWAP";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasMenu[2]  = "Long";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasMenu[3]  = "Long Inverso";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[5].LinhasMenu[4]  = "Long SWAP";

            // Coluna 6 — Base 10
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasValor[0] = 0;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasValor[1] = 1;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasValor[2] = 2;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasValor[3] = 3;
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasMenu[0]  = "0";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasMenu[1]  = ".0";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasMenu[2]  = ".00";
            RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas[6].LinhasMenu[3]  = ".000";
        }

        // ─────────────────────────────────────────────────────────────────────
        // GeraDataGridView — usa RT_geral.RT_820_DataGrigViewXXXColunas +
        // Linha_RT.CreateComboBoxColumn / CreateTextColumn, igual ao RT_820_conf.
        // ─────────────────────────────────────────────────────────────────────

        private void GeraDataGridView_Vazoes(DataGridView dgv)
        {
            dgv.SuspendLayout();
            dgv.Columns.Clear();
            dgv.AllowUserToAddRows    = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows    = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.RowHeadersVisible = true;
            dgv.ScrollBars = ScrollBars.None;

            // Itera pelas colunas definidas na estrutura (coluna 0 = "Entrada")
            for (int num = 0; num <= 0; num++)
            {
                if (RT_geral.RT_820_DataGrigViewVazoesColunas[num].NumeroLinhaMenu > 0)
                    dgv.Columns.Insert(num,
                        Linha_RT.CreateComboBoxColumn(
                            num.ToString(),
                            ref RT_geral.RT_820_DataGrigViewVazoesColunas));
                else
                    dgv.Columns.Insert(num,
                        Linha_RT.CreateTextColumn(
                            num.ToString(),
                            ref RT_geral.RT_820_DataGrigViewVazoesColunas));
            }

            dgv.RowCount = 8;
            dgv.RowHeadersWidth = 80;

            int n = 1;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                    row.HeaderCell.Value = "Vazão " + n++;
            }

            dgv.Width  = 200 + dgv.RowHeadersWidth + 20;
            dgv.Height = 239;
            dgv.ResumeLayout();
        }

        private void GeraDataGridView_Perifericos(DataGridView dgv)
        {
            dgv.SuspendLayout();
            dgv.Columns.Clear();
            dgv.AllowUserToAddRows    = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows    = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.RowHeadersVisible = true;
            dgv.ScrollBars = ScrollBars.None;

            // Colunas 0 (Modelo — combo) e 1 (Endereço — texto)
            for (int num = 0; num <= 1; num++)
            {
                if (RT_geral.RT_820_DataGrigViewPerifericosColunas[num].NumeroLinhaMenu > 0)
                    dgv.Columns.Insert(num,
                        Linha_RT.CreateComboBoxColumn(
                            num.ToString(),
                            ref RT_geral.RT_820_DataGrigViewPerifericosColunas));
                else
                    dgv.Columns.Insert(num,
                        Linha_RT.CreateTextColumn(
                            num.ToString(),
                            ref RT_geral.RT_820_DataGrigViewPerifericosColunas));
            }

            dgv.RowCount = 5;
            dgv.RowHeadersWidth = 100;

            int n = 1;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                    row.HeaderCell.Value = "Periférico " + n++;
            }

            dgv.Width  = 250 + 60 + dgv.RowHeadersWidth + 20;
            dgv.Height = 133;
            dgv.ResumeLayout();
        }

        private void GeraDataGridView_Referencia_Periferico(DataGridView dgv)
        {
            var cols = RT_geral.RT_820_DataGrigViewReferenciaPerifericosColunas;

            dgv.SuspendLayout();
            dgv.Columns.Clear();
            dgv.AllowUserToAddRows    = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows    = false;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.RowHeadersVisible = true;
            dgv.ScrollBars = ScrollBars.None;

            int totalWidth = 0;
            // 7 colunas: Periférico, Memória, Variável1, Variável2, Escala, Formato, Base10
            for (int i = 0; i <= 6; i++)
            {
                if (cols[i].NumeroLinhaMenu > 0)
                    dgv.Columns.Insert(i,
                        Linha_RT.CreateComboBoxColumn(i.ToString(), ref cols));
                else
                    dgv.Columns.Insert(i,
                        Linha_RT.CreateTextColumn(i.ToString(), ref cols));

                totalWidth += cols[i].LarguraColuna;
            }

            dgv.RowCount = 10;
            dgv.RowHeadersWidth =20;
            dgv.RowHeadersVisible = true;

            int n = 1;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                    row.HeaderCell.Value = n++.ToString();
            }

            dgv.Width  = totalWidth + dgv.RowHeadersWidth + 2;
            dgv.Height = dgv.ColumnHeadersHeight +
                         dgv.Rows.Cast<DataGridViewRow>()
                             .Sum(r => r.Height) + 2;
            dgv.ResumeLayout();
        }

        // ─────────────────────────────────────────────────────────────────────
        // Criação das abas
        // ─────────────────────────────────────────────────────────────────────

        // ─────────────────────────────────────────────────────────────────────
        // AjustaAbas — monta a sequência de abas do TabControl_821
        // ─────────────────────────────────────────────────────────────────────

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
                this.TabPage_VasosCalhas,
                this.TabPage_Perifericos,
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
