using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace iS800
{
	public partial class RT_821_380_conf : RT_821_Conf
	{
		private System.ComponentModel.IContainer components = null;

		private global::System.Windows.Forms.TabPage TabPage_vazao;
		private global::System.Windows.Forms.GroupBox GroupBox12;
		private global::System.Windows.Forms.TabControl TabControl_Calhas;
		private global::System.Windows.Forms.TabPage TabPage2;
		private global::System.Windows.Forms.TabPage TabPage3;
		private global::System.Windows.Forms.TabPage TabPage4;
		private global::System.Windows.Forms.Label Label41;
		private global::System.Windows.Forms.DataGridView DataGridView_calhas_RT820;
		private global::System.Windows.Forms.GroupBox GroupBox_vazoes_820;
		private global::System.Windows.Forms.DataGridView DataGridView_vazoes_RT820;
		private global::System.Windows.Forms.TextBox tb_lixo6;
		private global::System.Windows.Forms.TabPage TabPage_vazao_perifericos;
		private global::System.Windows.Forms.GroupBox GroupBox11;
		private global::System.Windows.Forms.DataGridView DataGridView_perifericomodbusgenerico_RT820;
		private global::System.Windows.Forms.GroupBox GroupBox10;
		private global::System.Windows.Forms.DataGridView DataGridView_periferico2_RT820;
		private global::System.Windows.Forms.GroupBox GroupBox3;
		private global::System.Windows.Forms.Label Label22;
		private global::System.Windows.Forms.DataGridView datagridview_referenciaperifico;
		private global::System.Windows.Forms.GroupBox GroupBox_perifericos_820;
		private global::System.Windows.Forms.GroupBox GroupBox9;
		private global::System.Windows.Forms.DataGridView DataGridView2;
		private global::System.Windows.Forms.DataGridView DataGridView_periferico1_RT820;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.TabPage_vazao = new global::System.Windows.Forms.TabPage();
			this.GroupBox12 = new global::System.Windows.Forms.GroupBox();
			this.TabControl_Calhas = new global::System.Windows.Forms.TabControl();
			this.TabPage2 = new global::System.Windows.Forms.TabPage();
			this.TabPage3 = new global::System.Windows.Forms.TabPage();
			this.TabPage4 = new global::System.Windows.Forms.TabPage();
			this.Label41 = new global::System.Windows.Forms.Label();
			this.DataGridView_calhas_RT820 = new global::System.Windows.Forms.DataGridView();
			this.GroupBox_vazoes_820 = new global::System.Windows.Forms.GroupBox();
			this.DataGridView_vazoes_RT820 = new global::System.Windows.Forms.DataGridView();
			this.tb_lixo6 = new global::System.Windows.Forms.TextBox();
			this.TabPage_vazao_perifericos = new global::System.Windows.Forms.TabPage();
			this.GroupBox11 = new global::System.Windows.Forms.GroupBox();
			this.DataGridView_perifericomodbusgenerico_RT820 = new global::System.Windows.Forms.DataGridView();
			this.GroupBox10 = new global::System.Windows.Forms.GroupBox();
			this.DataGridView_periferico2_RT820 = new global::System.Windows.Forms.DataGridView();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.Label22 = new global::System.Windows.Forms.Label();
			this.datagridview_referenciaperifico = new global::System.Windows.Forms.DataGridView();
			this.GroupBox_perifericos_820 = new global::System.Windows.Forms.GroupBox();
			this.GroupBox9 = new global::System.Windows.Forms.GroupBox();
			this.DataGridView2 = new global::System.Windows.Forms.DataGridView();
			this.DataGridView_periferico1_RT820 = new global::System.Windows.Forms.DataGridView();
			this.GroupBox12.SuspendLayout();
			this.TabControl_Calhas.SuspendLayout();
			this.GroupBox_vazoes_820.SuspendLayout();
			this.GroupBox11.SuspendLayout();
			this.GroupBox10.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox_perifericos_820.SuspendLayout();
			this.GroupBox9.SuspendLayout();
			this.TabPage_vazao.SuspendLayout();
			this.TabPage_vazao_perifericos.SuspendLayout();
			this.TabControl_821.Controls.Add(this.TabPage_vazao);
			this.TabControl_821.Controls.Add(this.TabPage_vazao_perifericos);
			// 
			// TabPage_vazao
			// 
			this.TabPage_vazao.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.TabPage_vazao.Controls.Add(this.GroupBox12);
			this.TabPage_vazao.Controls.Add(this.GroupBox_vazoes_820);
			this.TabPage_vazao.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_vazao.Name = "TabPage_vazao";
			this.TabPage_vazao.Padding = new global::System.Windows.Forms.Padding(3);
			this.TabPage_vazao.Size = new global::System.Drawing.Size(1396, 652);
			this.TabPage_vazao.TabIndex = 9;
			this.TabPage_vazao.Text = "   Vazão & Calhas    ";
			this.TabPage_vazao.UseVisualStyleBackColor = true;
			// 
			// GroupBox12
			// 
			this.GroupBox12.Controls.Add(this.TabControl_Calhas);
			this.GroupBox12.Controls.Add(this.Label41);
			this.GroupBox12.Controls.Add(this.DataGridView_calhas_RT820);
			this.GroupBox12.Location = new global::System.Drawing.Point(371, 17);
			this.GroupBox12.Name = "GroupBox12";
			this.GroupBox12.Size = new global::System.Drawing.Size(850, 630);
			this.GroupBox12.TabIndex = 3;
			this.GroupBox12.TabStop = false;
			this.GroupBox12.Text = "Calhas";
			// 
			// TabControl_Calhas
			// 
			this.TabControl_Calhas.Controls.Add(this.TabPage2);
			this.TabControl_Calhas.Controls.Add(this.TabPage3);
			this.TabControl_Calhas.Controls.Add(this.TabPage4);
			this.TabControl_Calhas.Location = new global::System.Drawing.Point(19, 160);
			this.TabControl_Calhas.Name = "TabControl_Calhas";
			this.TabControl_Calhas.SelectedIndex = 0;
			this.TabControl_Calhas.Size = new global::System.Drawing.Size(780, 457);
			this.TabControl_Calhas.TabIndex = 20;
			// 
			// TabPage2
			// 
			this.TabPage2.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new global::System.Drawing.Size(772, 431);
			this.TabPage2.TabIndex = 0;
			this.TabPage2.Text = "General Parshall Flume";
			this.TabPage2.UseVisualStyleBackColor = true;
			// 
			// TabPage3
			// 
			this.TabPage3.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Padding = new global::System.Windows.Forms.Padding(3);
			this.TabPage3.Size = new global::System.Drawing.Size(772, 431);
			this.TabPage3.TabIndex = 1;
			this.TabPage3.Text = "Botton Step Weir";
			this.TabPage3.UseVisualStyleBackColor = true;
			// 
			// TabPage4
			// 
			this.TabPage4.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage4.Name = "TabPage4";
			this.TabPage4.Padding = new global::System.Windows.Forms.Padding(3);
			this.TabPage4.Size = new global::System.Drawing.Size(772, 431);
			this.TabPage4.TabIndex = 2;
			this.TabPage4.Text = "Rectangular Weir";
			this.TabPage4.UseVisualStyleBackColor = true;
			// 
			// Label41
			// 
			this.Label41.AutoSize = true;
			this.Label41.Location = new global::System.Drawing.Point(488, 381);
			this.Label41.Name = "Label41";
			this.Label41.Size = new global::System.Drawing.Size(68, 13);
			this.Label41.TabIndex = 6;
			this.Label41.Text = "Visão Lateral";
			// 
			// DataGridView_calhas_RT820
			// 
			this.DataGridView_calhas_RT820.AllowUserToAddRows = false;
			this.DataGridView_calhas_RT820.AllowUserToDeleteRows = false;
			this.DataGridView_calhas_RT820.AllowUserToResizeColumns = false;
			this.DataGridView_calhas_RT820.AllowUserToResizeRows = false;
			this.DataGridView_calhas_RT820.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			this.DataGridView_calhas_RT820.Location = new global::System.Drawing.Point(19, 19);
			this.DataGridView_calhas_RT820.Name = "DataGridView_calhas_RT820";
			this.DataGridView_calhas_RT820.RowHeadersWidth = 75;
			this.DataGridView_calhas_RT820.Size = new global::System.Drawing.Size(342, 135);
			this.DataGridView_calhas_RT820.TabIndex = 0;
			// 
			// GroupBox_vazoes_820
			// 
			this.GroupBox_vazoes_820.Controls.Add(this.DataGridView_vazoes_RT820);
			this.GroupBox_vazoes_820.Controls.Add(this.tb_lixo6);
			this.GroupBox_vazoes_820.Location = new global::System.Drawing.Point(17, 17);
			this.GroupBox_vazoes_820.Name = "GroupBox_vazoes_820";
			this.GroupBox_vazoes_820.Size = new global::System.Drawing.Size(348, 630);
			this.GroupBox_vazoes_820.TabIndex = 2;
			this.GroupBox_vazoes_820.TabStop = false;
			this.GroupBox_vazoes_820.Text = "Vazões";
			// 
			// DataGridView_vazoes_RT820
			// 
			this.DataGridView_vazoes_RT820.AllowUserToAddRows = false;
			this.DataGridView_vazoes_RT820.AllowUserToDeleteRows = false;
			this.DataGridView_vazoes_RT820.AllowUserToResizeColumns = false;
			this.DataGridView_vazoes_RT820.AllowUserToResizeRows = false;
			this.DataGridView_vazoes_RT820.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			this.DataGridView_vazoes_RT820.Location = new global::System.Drawing.Point(14, 19);
			this.DataGridView_vazoes_RT820.Name = "DataGridView_vazoes_RT820";
			this.DataGridView_vazoes_RT820.RowHeadersWidth = 75;
			this.DataGridView_vazoes_RT820.Size = new global::System.Drawing.Size(320, 575);
			this.DataGridView_vazoes_RT820.TabIndex = 0;
			// 
			// tb_lixo6
			// 
			this.tb_lixo6.Location = new global::System.Drawing.Point(197, 151);
			this.tb_lixo6.Name = "tb_lixo6";
			this.tb_lixo6.Size = new global::System.Drawing.Size(100, 20);
			this.tb_lixo6.TabIndex = 4;
			// 
			// TabPage_vazao_perifericos
			// 
			this.TabPage_vazao_perifericos.BackColor = global::System.Drawing.SystemColors.ControlLight;
			this.TabPage_vazao_perifericos.Controls.Add(this.GroupBox11);
			this.TabPage_vazao_perifericos.Controls.Add(this.GroupBox10);
			this.TabPage_vazao_perifericos.Controls.Add(this.GroupBox3);
			this.TabPage_vazao_perifericos.Controls.Add(this.GroupBox_perifericos_820);
			this.TabPage_vazao_perifericos.Location = new global::System.Drawing.Point(4, 22);
			this.TabPage_vazao_perifericos.Name = "TabPage_vazao_perifericos";
			this.TabPage_vazao_perifericos.Padding = new global::System.Windows.Forms.Padding(3);
			this.TabPage_vazao_perifericos.Size = new global::System.Drawing.Size(1396, 652);
			this.TabPage_vazao_perifericos.TabIndex = 10;
			this.TabPage_vazao_perifericos.Text = "   Periféricos   ";
			this.TabPage_vazao_perifericos.UseVisualStyleBackColor = true;
			// 
			// GroupBox11
			// 
			this.GroupBox11.Controls.Add(this.DataGridView_perifericomodbusgenerico_RT820);
			this.GroupBox11.Location = new global::System.Drawing.Point(18, 187);
			this.GroupBox11.Name = "GroupBox11";
			this.GroupBox11.Size = new global::System.Drawing.Size(847, 159);
			this.GroupBox11.TabIndex = 21;
			this.GroupBox11.TabStop = false;
			this.GroupBox11.Text = "Configuração Periférico Modbus Genérico";
			// 
			// DataGridView_perifericomodbusgenerico_RT820
			// 
			this.DataGridView_perifericomodbusgenerico_RT820.AllowUserToAddRows = false;
			this.DataGridView_perifericomodbusgenerico_RT820.AllowUserToDeleteRows = false;
			this.DataGridView_perifericomodbusgenerico_RT820.AllowUserToResizeColumns = false;
			this.DataGridView_perifericomodbusgenerico_RT820.AllowUserToResizeRows = false;
			this.DataGridView_perifericomodbusgenerico_RT820.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			this.DataGridView_perifericomodbusgenerico_RT820.Location = new global::System.Drawing.Point(12, 18);
			this.DataGridView_perifericomodbusgenerico_RT820.Name = "DataGridView_perifericomodbusgenerico_RT820";
			this.DataGridView_perifericomodbusgenerico_RT820.RowHeadersWidth = 75;
			this.DataGridView_perifericomodbusgenerico_RT820.ScrollBars = (System.Windows.Forms.ScrollBars)1;
			this.DataGridView_perifericomodbusgenerico_RT820.Size = new global::System.Drawing.Size(818, 125);
			this.DataGridView_perifericomodbusgenerico_RT820.TabIndex = 2;
			// 
			// GroupBox10
			// 
			this.GroupBox10.Controls.Add(this.DataGridView_periferico2_RT820);
			this.GroupBox10.Location = new global::System.Drawing.Point(463, 16);
			this.GroupBox10.Name = "GroupBox10";
			this.GroupBox10.Size = new global::System.Drawing.Size(430, 157);
			this.GroupBox10.TabIndex = 20;
			this.GroupBox10.TabStop = false;
			this.GroupBox10.Text = "Periféricos do  2° Endereço da  Estação";
			// 
			// DataGridView_periferico2_RT820
			// 
			this.DataGridView_periferico2_RT820.AllowUserToAddRows = false;
			this.DataGridView_periferico2_RT820.AllowUserToDeleteRows = false;
			this.DataGridView_periferico2_RT820.AllowUserToResizeColumns = false;
			this.DataGridView_periferico2_RT820.AllowUserToResizeRows = false;
			this.DataGridView_periferico2_RT820.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			this.DataGridView_periferico2_RT820.Location = new global::System.Drawing.Point(12, 18);
			this.DataGridView_periferico2_RT820.Name = "DataGridView_periferico2_RT820";
			this.DataGridView_periferico2_RT820.RowHeadersWidth = 75;
			this.DataGridView_periferico2_RT820.Size = new global::System.Drawing.Size(406, 125);
			this.DataGridView_periferico2_RT820.TabIndex = 0;
			// 
			// GroupBox3
			// 
			this.GroupBox3.Controls.Add(this.Label22);
			this.GroupBox3.Controls.Add(this.datagridview_referenciaperifico);
			this.GroupBox3.Location = new global::System.Drawing.Point(18, 352);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new global::System.Drawing.Size(430, 157);
			this.GroupBox3.TabIndex = 19;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Referência Periférico";
			// 
			// Label22
			// 
			this.Label22.AutoSize = true;
			this.Label22.Location = new global::System.Drawing.Point(15, 21);
			this.Label22.Name = "Label22";
			this.Label22.Size = new global::System.Drawing.Size(68, 13);
			this.Label22.TabIndex = 1;
			this.Label22.Text = "Referência :";
			// 
			// datagridview_referenciaperifico
			// 
			this.datagridview_referenciaperifico.AllowUserToAddRows = false;
			this.datagridview_referenciaperifico.AllowUserToDeleteRows = false;
			this.datagridview_referenciaperifico.AllowUserToResizeColumns = false;
			this.datagridview_referenciaperifico.AllowUserToResizeRows = false;
			this.datagridview_referenciaperifico.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			this.datagridview_referenciaperifico.Location = new global::System.Drawing.Point(12, 37);
			this.datagridview_referenciaperifico.Name = "datagridview_referenciaperifico";
			this.datagridview_referenciaperifico.RowHeadersWidth = 75;
			this.datagridview_referenciaperifico.Size = new global::System.Drawing.Size(406, 108);
			this.datagridview_referenciaperifico.TabIndex = 0;
			// 
			// GroupBox_perifericos_820
			// 
			this.GroupBox_perifericos_820.Controls.Add(this.GroupBox9);
			this.GroupBox_perifericos_820.Controls.Add(this.DataGridView_periferico1_RT820);
			this.GroupBox_perifericos_820.Location = new global::System.Drawing.Point(463, 352);
			this.GroupBox_perifericos_820.Name = "GroupBox_perifericos_820";
			this.GroupBox_perifericos_820.Size = new global::System.Drawing.Size(430, 157);
			this.GroupBox_perifericos_820.TabIndex = 18;
			this.GroupBox_perifericos_820.TabStop = false;
			this.GroupBox_perifericos_820.Text = "Periféricos";
			// 
			// GroupBox9
			// 
			this.GroupBox9.Controls.Add(this.DataGridView2);
			this.GroupBox9.Location = new global::System.Drawing.Point(6, 19);
			this.GroupBox9.Name = "GroupBox9";
			this.GroupBox9.Size = new global::System.Drawing.Size(418, 65);
			this.GroupBox9.TabIndex = 1;
			this.GroupBox9.TabStop = false;
			this.GroupBox9.Text = "Periférico 1";
			// 
			// DataGridView2
			// 
			this.DataGridView2.AllowUserToAddRows = false;
			this.DataGridView2.AllowUserToDeleteRows = false;
			this.DataGridView2.AllowUserToResizeColumns = false;
			this.DataGridView2.AllowUserToResizeRows = false;
			this.DataGridView2.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			this.DataGridView2.Location = new global::System.Drawing.Point(6, 19);
			this.DataGridView2.Name = "DataGridView2";
			this.DataGridView2.RowHeadersWidth = 75;
			this.DataGridView2.Size = new global::System.Drawing.Size(406, 33);
			this.DataGridView2.TabIndex = 0;
			// 
			// DataGridView_periferico1_RT820
			// 
			this.DataGridView_periferico1_RT820.AllowUserToAddRows = false;
			this.DataGridView_periferico1_RT820.AllowUserToDeleteRows = false;
			this.DataGridView_periferico1_RT820.AllowUserToResizeColumns = false;
			this.DataGridView_periferico1_RT820.AllowUserToResizeRows = false;
			this.DataGridView_periferico1_RT820.ColumnHeadersHeightSizeMode = (System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode)2;
			this.DataGridView_periferico1_RT820.Location = new global::System.Drawing.Point(6, 90);
			this.DataGridView_periferico1_RT820.Name = "DataGridView_periferico1_RT820";
			this.DataGridView_periferico1_RT820.RowHeadersWidth = 75;
			this.DataGridView_periferico1_RT820.Size = new global::System.Drawing.Size(418, 54);
			this.DataGridView_periferico1_RT820.TabIndex = 0;
			this.GroupBox12.ResumeLayout(false);
			this.GroupBox12.PerformLayout();
			this.TabControl_Calhas.ResumeLayout(false);
			this.GroupBox_vazoes_820.ResumeLayout(false);
			this.GroupBox_vazoes_820.PerformLayout();
			this.GroupBox11.ResumeLayout(false);
			this.GroupBox10.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox_perifericos_820.ResumeLayout(false);
			this.GroupBox9.ResumeLayout(false);
			this.TabPage_vazao.ResumeLayout(false);
			this.TabPage_vazao_perifericos.ResumeLayout(false);
			// Reorder TabPages robustly: ensure Vazão, Periféricos, Dados after Display
			var tabPageVazao = this.TabControl_821.TabPages["TabPage_vazao"];
			var tabPageVazaoPerifericos = this.TabControl_821.TabPages["TabPage_vazao_perifericos"];
			var tabPageDisplay = this.TabControl_821.TabPages["TabPage_Display"];
			var tabPageDadosInstalacao = this.TabControl_821.TabPages["TabPage_DadosInstalacao"];
			var pagesToMove = new System.Collections.Generic.List<System.Windows.Forms.TabPage>();
			if (tabPageVazao != null)
				pagesToMove.Add(tabPageVazao);
			if (tabPageVazaoPerifericos != null)
				pagesToMove.Add(tabPageVazaoPerifericos);
			if (tabPageDadosInstalacao != null)
				pagesToMove.Add(tabPageDadosInstalacao);
			foreach (var p in pagesToMove.ToArray())
			{
				if (this.TabControl_821.TabPages.Contains(p))
					this.TabControl_821.TabPages.Remove(p);
			}
			int insertIndex = (tabPageDisplay != null && this.TabControl_821.TabPages.Contains(tabPageDisplay)) ? this.TabControl_821.TabPages.IndexOf(tabPageDisplay) + 1 : this.TabControl_821.TabPages.Count;
			foreach (var p in pagesToMove)
			{
				int clampedIndex = Math.Max(0, Math.Min(insertIndex, this.TabControl_821.TabPages.Count));
				this.TabControl_821.TabPages.Insert(clampedIndex, p);
				insertIndex = clampedIndex + 1;
			}
			// Ensure TabPage.TabIndex values reflect the actual order to avoid code
			// that incorrectly uses TabIndex as a SelectedIndex source.
			for (int i = 0; i < this.TabControl_821.TabPages.Count; i++)
			{
				this.TabControl_821.TabPages[i].TabIndex = i;
			}
			// Clamp SelectedIndex to a valid value
			if (this.TabControl_821.SelectedIndex < 0 || this.TabControl_821.SelectedIndex >= this.TabControl_821.TabPages.Count)
			{
				this.TabControl_821.SelectedIndex = 0;
			}
			this.ResumeLayout(false);
		}
	}
}
