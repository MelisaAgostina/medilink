﻿namespace medilink.Views.reportes
{
    partial class ReporteMedico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCitas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCitas
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCitas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCitas.Legends.Add(legend1);
            this.chartCitas.Location = new System.Drawing.Point(250, 67);
            this.chartCitas.Name = "chartCitas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series";
            this.chartCitas.Series.Add(series1);
            this.chartCitas.Size = new System.Drawing.Size(300, 300);
            this.chartCitas.TabIndex = 0;
            this.chartCitas.Text = "chart1";
            // 
            // ReporteMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartCitas);
            this.Name = "ReporteMedico";
            this.Text = "ReporteMedico";
            ((System.ComponentModel.ISupportInitialize)(this.chartCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCitas;
    }
}