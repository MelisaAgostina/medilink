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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteMedico));
            this.chartCitas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNuevoUsuario = new System.Windows.Forms.Label();
            this.labeLDNI = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPInicio = new System.Windows.Forms.DateTimePicker();
            this.DTPFin = new System.Windows.Forms.DateTimePicker();
            this.PBAyuda = new System.Windows.Forms.PictureBox();
            this.BLimpiar = new System.Windows.Forms.Button();
            this.BGenerar = new System.Windows.Forms.Button();
            this.BExportar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartCitas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBAyuda)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCitas
            // 
            chartArea4.Name = "ChartArea1";
            this.chartCitas.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartCitas.Legends.Add(legend4);
            this.chartCitas.Location = new System.Drawing.Point(19, 17);
            this.chartCitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartCitas.Name = "chartCitas";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series";
            this.chartCitas.Series.Add(series4);
            this.chartCitas.Size = new System.Drawing.Size(700, 370);
            this.chartCitas.TabIndex = 0;
            this.chartCitas.Text = "chart1";
            this.chartCitas.Click += new System.EventHandler(this.chartCitas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(166)))), ((int)(((byte)(124)))));
            this.panel1.Controls.Add(this.chartCitas);
            this.panel1.Location = new System.Drawing.Point(203, 266);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 402);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelNuevoUsuario
            // 
            this.labelNuevoUsuario.AutoSize = true;
            this.labelNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            this.labelNuevoUsuario.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(166)))), ((int)(((byte)(124)))));
            this.labelNuevoUsuario.Location = new System.Drawing.Point(423, 28);
            this.labelNuevoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNuevoUsuario.Name = "labelNuevoUsuario";
            this.labelNuevoUsuario.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.labelNuevoUsuario.Size = new System.Drawing.Size(317, 51);
            this.labelNuevoUsuario.TabIndex = 2;
            this.labelNuevoUsuario.Text = "Analice sus citas";
            // 
            // labeLDNI
            // 
            this.labeLDNI.AutoSize = true;
            this.labeLDNI.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeLDNI.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labeLDNI.Location = new System.Drawing.Point(199, 123);
            this.labeLDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeLDNI.Name = "labeLDNI";
            this.labeLDNI.Size = new System.Drawing.Size(57, 17);
            this.labeLDNI.TabIndex = 3;
            this.labeLDNI.Text = "Estado";
            // 
            // CBEstado
            // 
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(203, 143);
            this.CBEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(160, 24);
            this.CBEstado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(199, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(512, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de fin";
            // 
            // DTPInicio
            // 
            this.DTPInicio.Location = new System.Drawing.Point(203, 210);
            this.DTPInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTPInicio.Name = "DTPInicio";
            this.DTPInicio.Size = new System.Drawing.Size(265, 22);
            this.DTPInicio.TabIndex = 7;
            // 
            // DTPFin
            // 
            this.DTPFin.Location = new System.Drawing.Point(516, 210);
            this.DTPFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTPFin.Name = "DTPFin";
            this.DTPFin.Size = new System.Drawing.Size(265, 22);
            this.DTPFin.TabIndex = 8;
            // 
            // PBAyuda
            // 
            this.PBAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBAyuda.BackgroundImage")));
            this.PBAyuda.Location = new System.Drawing.Point(1136, 15);
            this.PBAyuda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PBAyuda.Name = "PBAyuda";
            this.PBAyuda.Size = new System.Drawing.Size(88, 76);
            this.PBAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBAyuda.TabIndex = 9;
            this.PBAyuda.TabStop = false;
            // 
            // BLimpiar
            // 
            this.BLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BLimpiar.BackgroundImage")));
            this.BLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BLimpiar.Location = new System.Drawing.Point(963, 463);
            this.BLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BLimpiar.Name = "BLimpiar";
            this.BLimpiar.Size = new System.Drawing.Size(96, 91);
            this.BLimpiar.TabIndex = 10;
            this.BLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLimpiar.UseVisualStyleBackColor = false;
            this.BLimpiar.Click += new System.EventHandler(this.BLimpiar_Click);
            // 
            // BGenerar
            // 
            this.BGenerar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BGenerar.BackgroundImage")));
            this.BGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BGenerar.Location = new System.Drawing.Point(963, 266);
            this.BGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BGenerar.Name = "BGenerar";
            this.BGenerar.Size = new System.Drawing.Size(93, 91);
            this.BGenerar.TabIndex = 11;
            this.BGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGenerar.UseVisualStyleBackColor = false;
            this.BGenerar.Click += new System.EventHandler(this.BGenerar_Click);
            // 
            // BExportar
            // 
            this.BExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            this.BExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BExportar.BackgroundImage")));
            this.BExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BExportar.Location = new System.Drawing.Point(963, 364);
            this.BExportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BExportar.Name = "BExportar";
            this.BExportar.Size = new System.Drawing.Size(93, 91);
            this.BExportar.TabIndex = 12;
            this.BExportar.UseVisualStyleBackColor = false;
            this.BExportar.Click += new System.EventHandler(this.BExportar_Click);
            // 
            // toolTip4
            // 
            this.toolTip4.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip4_Popup);
            // 
            // ReporteMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1240, 752);
            this.ControlBox = false;
            this.Controls.Add(this.BExportar);
            this.Controls.Add(this.BGenerar);
            this.Controls.Add(this.BLimpiar);
            this.Controls.Add(this.PBAyuda);
            this.Controls.Add(this.DTPFin);
            this.Controls.Add(this.DTPInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.labeLDNI);
            this.Controls.Add(this.labelNuevoUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReporteMedico";
            this.Text = "ReporteMedico";
            this.Load += new System.EventHandler(this.ReporteMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCitas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBAyuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCitas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNuevoUsuario;
        private System.Windows.Forms.Label labeLDNI;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPInicio;
        private System.Windows.Forms.DateTimePicker DTPFin;
        private System.Windows.Forms.PictureBox PBAyuda;
        private System.Windows.Forms.Button BLimpiar;
        private System.Windows.Forms.Button BGenerar;
        private System.Windows.Forms.Button BExportar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}