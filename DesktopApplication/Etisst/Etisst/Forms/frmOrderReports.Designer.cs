﻿namespace Etisst
{
    partial class frmOrderReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.cbReports = new System.Windows.Forms.ComboBox();
            this.cbChartModel = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpUntil = new System.Windows.Forms.DateTimePicker();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.clbSeries = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGeneralPanel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnReportPanel = new System.Windows.Forms.Button();
            this.panelGeneral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // cbReports
            // 
            this.cbReports.FormattingEnabled = true;
            this.cbReports.Items.AddRange(new object[] {
            "Orders",
            "Others"});
            this.cbReports.Location = new System.Drawing.Point(124, 39);
            this.cbReports.Margin = new System.Windows.Forms.Padding(2);
            this.cbReports.Name = "cbReports";
            this.cbReports.Size = new System.Drawing.Size(199, 21);
            this.cbReports.TabIndex = 0;
            this.cbReports.SelectedIndexChanged += new System.EventHandler(this.cbReports_SelectedIndexChanged);
            // 
            // cbChartModel
            // 
            this.cbChartModel.FormattingEnabled = true;
            this.cbChartModel.Location = new System.Drawing.Point(124, 71);
            this.cbChartModel.Margin = new System.Windows.Forms.Padding(2);
            this.cbChartModel.Name = "cbChartModel";
            this.cbChartModel.Size = new System.Drawing.Size(199, 21);
            this.cbChartModel.TabIndex = 5;
            this.cbChartModel.SelectedIndexChanged += new System.EventHandler(this.cbChartModel_SelectedIndexChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(124, 104);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(199, 20);
            this.dtpFrom.TabIndex = 6;
            // 
            // dtpUntil
            // 
            this.dtpUntil.Location = new System.Drawing.Point(124, 138);
            this.dtpUntil.Margin = new System.Windows.Forms.Padding(2);
            this.dtpUntil.Name = "dtpUntil";
            this.dtpUntil.Size = new System.Drawing.Size(199, 20);
            this.dtpUntil.TabIndex = 7;
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Controls.Add(this.clbSeries);
            this.panelGeneral.Controls.Add(this.dtpUntil);
            this.panelGeneral.Controls.Add(this.label6);
            this.panelGeneral.Controls.Add(this.dtpFrom);
            this.panelGeneral.Controls.Add(this.label8);
            this.panelGeneral.Controls.Add(this.cbChartModel);
            this.panelGeneral.Controls.Add(this.label4);
            this.panelGeneral.Controls.Add(this.label5);
            this.panelGeneral.Controls.Add(this.btnGeneralPanel);
            this.panelGeneral.Controls.Add(this.cbReports);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGeneral.Location = new System.Drawing.Point(15, 60);
            this.panelGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1818, 315);
            this.panelGeneral.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Series:";
            // 
            // clbSeries
            // 
            this.clbSeries.FormattingEnabled = true;
            this.clbSeries.Location = new System.Drawing.Point(124, 175);
            this.clbSeries.Margin = new System.Windows.Forms.Padding(2);
            this.clbSeries.Name = "clbSeries";
            this.clbSeries.Size = new System.Drawing.Size(199, 109);
            this.clbSeries.TabIndex = 21;
            this.clbSeries.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbSeries_ItemCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Until:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chart type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Report:";
            // 
            // btnGeneralPanel
            // 
            this.btnGeneralPanel.BackColor = System.Drawing.Color.Navy;
            this.btnGeneralPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneralPanel.Enabled = false;
            this.btnGeneralPanel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGeneralPanel.FlatAppearance.BorderSize = 5;
            this.btnGeneralPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeneralPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneralPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGeneralPanel.Location = new System.Drawing.Point(0, 0);
            this.btnGeneralPanel.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeneralPanel.Name = "btnGeneralPanel";
            this.btnGeneralPanel.Size = new System.Drawing.Size(1818, 28);
            this.btnGeneralPanel.TabIndex = 3;
            this.btnGeneralPanel.Text = "General panel";
            this.btnGeneralPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneralPanel.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Chart);
            this.panel1.Controls.Add(this.btnReportPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 375);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1818, 315);
            this.panel1.TabIndex = 5;
            // 
            // Chart
            // 
            lineAnnotation1.Name = "LineAnnotation1";
            this.Chart.Annotations.Add(lineAnnotation1);
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(0, 28);
            this.Chart.Margin = new System.Windows.Forms.Padding(2);
            this.Chart.Name = "Chart";
            this.Chart.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.Chart.Size = new System.Drawing.Size(1818, 287);
            this.Chart.TabIndex = 4;
            this.Chart.Text = "Chart";
            // 
            // btnReportPanel
            // 
            this.btnReportPanel.BackColor = System.Drawing.Color.Navy;
            this.btnReportPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportPanel.Enabled = false;
            this.btnReportPanel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReportPanel.FlatAppearance.BorderSize = 5;
            this.btnReportPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportPanel.Location = new System.Drawing.Point(0, 0);
            this.btnReportPanel.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportPanel.Name = "btnReportPanel";
            this.btnReportPanel.Size = new System.Drawing.Size(1818, 28);
            this.btnReportPanel.TabIndex = 3;
            this.btnReportPanel.Text = "Report panel";
            this.btnReportPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportPanel.UseVisualStyleBackColor = false;
            // 
            // frmOrderReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 891);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGeneral);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmOrderReports";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Text = "Order reports";
            this.Load += new System.EventHandler(this.frmOrderReports_Load);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpUntil;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ComboBox cbChartModel;
        private System.Windows.Forms.ComboBox cbReports;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGeneralPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbSeries;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Button btnReportPanel;
    }
}