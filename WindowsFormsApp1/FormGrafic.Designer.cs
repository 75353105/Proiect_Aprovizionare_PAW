namespace WindowsFormsApp1
{
    partial class FormGrafic
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.grafic_stocuri = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grafic_stocuri)).BeginInit();
            this.SuspendLayout();
            // 
            // grafic_stocuri
            // 
            chartArea1.Name = "ChartArea1";
            this.grafic_stocuri.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafic_stocuri.Legends.Add(legend1);
            this.grafic_stocuri.Location = new System.Drawing.Point(12, 60);
            this.grafic_stocuri.Name = "grafic_stocuri";
            this.grafic_stocuri.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Cantitate";
            this.grafic_stocuri.Series.Add(series1);
            this.grafic_stocuri.Size = new System.Drawing.Size(608, 465);
            this.grafic_stocuri.TabIndex = 0;
            this.grafic_stocuri.Text = "Stocuri Materiale";
            title1.Name = "Stocuri Materiale";
            title1.Text = "Stocuri Materiale";
            this.grafic_stocuri.Titles.Add(title1);
            // 
            // FormGrafic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 576);
            this.Controls.Add(this.grafic_stocuri);
            this.Name = "FormGrafic";
            this.Text = "FormGrafic";
            this.Load += new System.EventHandler(this.FormGrafic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafic_stocuri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafic_stocuri;
    }
}