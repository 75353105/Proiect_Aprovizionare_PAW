using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace WindowsFormsApp1
{
    public partial class FormGrafic : Form
    {
        Dictionary<string, double> cantitatiProdus;
        
        public FormGrafic(Dictionary<string, double> cantitatiProdus)
        {
            InitializeComponent();
            this.cantitatiProdus = cantitatiProdus;
            setData();
        }

        private void setData()
        {
           
            Series serie = grafic_stocuri.Series["Cantitate"];
            serie.Points.Clear();
            foreach( var produs in cantitatiProdus)
            {
                string nume = produs.Key;
                double cantitate = produs.Value;
                serie.Points.AddXY(nume, cantitate);
            }
            grafic_stocuri.ChartAreas[0].AxisX.Interval = 1;
            grafic_stocuri.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            if (keyData == (Keys.Control | Keys.P))
            {
                
                PrinteazaGraficul();
                return true; 
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void PrinteazaGraficul()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = " Adobe PDF files|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        Bitmap grafic = new Bitmap(grafic_stocuri.Width,grafic_stocuri.Height);
                        grafic_stocuri.DrawToBitmap(grafic, new System.Drawing.Rectangle(0, 0, grafic.Width, grafic.Height));
                        iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(grafic, System.Drawing.Imaging.ImageFormat.Png);
                        pdfImage.ScaleToFit(doc.PageSize.Width - 80, doc.PageSize.Height - 80);
                        pdfImage.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                        doc.Add(pdfImage);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "A aparut o eroare! Incearca din nou!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }

                }
            }
        }

        private void FormGrafic_Load(object sender, EventArgs e)
        {

        }
    }
}
