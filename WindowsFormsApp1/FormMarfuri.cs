using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class FormMarfuri : Form
    {

        string conexiuneServer = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gucci\Desktop\PAW\WindowsFormsApp1\WindowsFormsApp1\Materiale_Companii.mdf;Integrated Security=True";
        string selectComand = "select * from Materiale_Companii";
        DataSet DS_Materiale = new DataSet();
        public Materiale[] materiale;

        public FormMarfuri()
        {
            InitializeComponent();
            IncarcareDate();
            dataGridView1.AllowDrop = true;
            lb_suplimentare.AllowDrop = true; ;
            this.KeyDown += FormMarfuri_KeyDown1;
        }

        private void FormMarfuri_KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                salveazaDatele();
            }
        }

        private void IncarcareDate()
        {
            SqlConnection sqlConnection = new SqlConnection(conexiuneServer);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectComand, sqlConnection);
            sqlDataAdapter.Fill(DS_Materiale, "Materiale_Companii");

            DS_Materiale.Tables["Materiale_Companii"].PrimaryKey = new DataColumn[1]
            {
                DS_Materiale.Tables["Materiale_Companii"].Columns["IdMaterial"]
            };
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DS_Materiale.Tables["Materiale_Companii"];
            dataGridView1.ContextMenuStrip = cms_DateMateriale;
            dataGridView1.AllowUserToAddRows = false;

            sqlConnection.Close();
        }
        private void salveazaDatele()
        {
            using (SqlConnection sc=new SqlConnection(conexiuneServer))
            {
                sc.Open();
                using(SqlBulkCopy sbc=new SqlBulkCopy(sc))
                {
                    sbc.DestinationTableName = "Materiale_Companii";
                    foreach(DataGridViewColumn coloana in dataGridView1.Columns)
                    {
                        sbc.ColumnMappings.Add(coloana.Name, coloana.Name);
                    }
                    sbc.WriteToServer(DS_Materiale.Tables["Materiale_Companii"]);
                }
            }
            MessageBox.Show("Datele au fost salvate cu succes!", "Salvat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int nrRanduri = dataGridView1.Rows.Count;
            materiale = new Materiale[nrRanduri];
            for (int i = 0; i < nrRanduri; i++)
            {
                DataGridViewRow rand = dataGridView1.Rows[i];
                Materiale material = new Materiale();
                material.CodMaterial = Convert.ToInt32(rand.Cells[0].Value);
                material.DenumireMaterial = rand.Cells[1].Value.ToString();
                material.StocDisponibil = Convert.ToDouble(rand.Cells[2].Value);
                material.PretMediu = Convert.ToDouble(rand.Cells[3].Value);
                material.Proprietar = rand.Cells[4].Value.ToString();
                materiale[i] = material;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tsmi_iesireDinAPlicatie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormMarfuri_Load(object sender, EventArgs e)
        {
           
            this.materiale_CompaniiTableAdapter.Fill(this.materiale_CompaniiDataSet.Materiale_Companii);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                double cantitati = Convert.ToDouble(row.Cells[2].Value);

                if (cantitati < 70)
                {
                    string Text = "Marfa " + row.Cells[1].Value + " pentru " +
                        row.Cells[4].Value + " are nevoie de suplimentare!";
                    lb_suplimentare.Items.Add(Text);



                }
                else
                {
                    string Text = "Marfa " + row.Cells[1].Value + " pentru " +
                         row.Cells[4].Value + " se afla in cantitati suficiente!";

                    lb_suplimentare.Items.Add(Text);
                }


            }

        }

        private void materialeCompaniiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void lb_suplimentare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salvareDateInFisierBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Fiecare material *.mat|*.mat";
            sfd.CheckPathExists = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                List<Materiale> listaMateriale = new List<Materiale>();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];

                    int ID = Convert.ToInt32(row.Cells[0].Value);
                    string denumireMaterial = row.Cells[1].Value.ToString();
                    double stoc = Convert.ToDouble(row.Cells[2].Value);
                    double pretMediu = Convert.ToDouble(row.Cells[3].Value);
                    string proprietar = row.Cells[4].Value.ToString();

                    Materiale material = new Materiale(ID, denumireMaterial, stoc, pretMediu, proprietar);

                    listaMateriale.Add(material);
                }


                BinaryFormatter bf = new BinaryFormatter();
                using (FileStream fileStream = new FileStream(sfd.FileName, FileMode.Create))
                {
                    bf.Serialize(fileStream, listaMateriale);
                }


            }
        }

        private void preluaraeDateDinFisierBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fiecare material *.mat|*.mat";
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<Materiale> listaMateriale = new List<Materiale>();
                DataTable dateTable = new DataTable();

                BinaryFormatter serializator = new BinaryFormatter();
                try
                {
                    //incep dronele sa atace;

                    Stream fisier = File.OpenRead(ofd.FileName);
                    listaMateriale.AddRange((List<Materiale>)serializator.Deserialize(fisier));
                    fisier.Close();

                    dateTable.Columns.Add("IdMaterial", typeof(int));
                    dateTable.Columns.Add("denumireMaterial", typeof(string));
                    dateTable.Columns.Add("stocDisponibil", typeof(double));
                    dateTable.Columns.Add("pretMediu", typeof(double));
                    dateTable.Columns.Add("Proprietar", typeof(string));

                    foreach (Materiale m in listaMateriale)
                    {
                        DataRow row = dateTable.NewRow();
                        row["IdMaterial"] = m.CodMaterial;
                        row["denumireMaterial"] = m.DenumireMaterial;
                        row["stocDisponibil"] = m.StocDisponibil;
                        row["pretMediu"] = m.PretMediu;
                        row["Proprietar"] = m.Proprietar;
                        dateTable.Rows.Add(row);
                    }
                    dataGridView1.DataSource = dateTable;


                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataGridViewRow row = dataGridView1.Rows[i];
                        double cantitati = Convert.ToDouble(row.Cells[2].Value);

                        if (cantitati < 70)
                        {
                            string Text = "Marfa " + row.Cells[1].Value + " pentru " +
                                row.Cells[4].Value + " are nevoie de suplimentare!";
                            lb_suplimentare.Items.Add(Text);



                        }
                        else
                        {
                            string Text = "Marfa " + row.Cells[1].Value + " pentru " +
                                 row.Cells[4].Value + " se afla in cantitati suficiente!";

                            lb_suplimentare.Items.Add(Text);
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare! Acest fisier nu poate fi prelucrat!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }



            }

        }

        private void salvareDateInFisierXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Fiecare material *.mae|*.mae";
            sfd.CheckPathExists = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                List<Materiale> listaMateriale = new List<Materiale>();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];

                    int ID = Convert.ToInt32(row.Cells[0].Value);
                    string denumireMaterial = row.Cells[1].Value.ToString();
                    double stoc = Convert.ToDouble(row.Cells[2].Value);
                    double pretMediu = Convert.ToDouble(row.Cells[3].Value);
                    string proprietar = row.Cells[4].Value.ToString();

                    Materiale material = new Materiale(ID, denumireMaterial, stoc, pretMediu, proprietar);

                    listaMateriale.Add(material);
                }



                using (FileStream fileStream = new FileStream(sfd.FileName, FileMode.Create))
                {
                    XmlSerializer xmlf = new XmlSerializer(typeof(List<Materiale>));
                    xmlf.Serialize(fileStream, listaMateriale);
                }


            }
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fiecare material *.mae|*.mae";
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<Materiale> listaMateriale = new List<Materiale>();
                DataTable dateTable = new DataTable();

               
                try
                {
                    //incep dronele sa atace;
                    XmlSerializer serializator = new XmlSerializer(typeof(List<Materiale>));
                    Stream fisier = File.OpenRead(ofd.FileName);
                    listaMateriale.AddRange((List<Materiale>)serializator.Deserialize(fisier));
                    fisier.Close();

                    dateTable.Columns.Add("IdMaterial", typeof(int));
                    dateTable.Columns.Add("denumireMaterial", typeof(string));
                    dateTable.Columns.Add("stocDisponibil", typeof(double));
                    dateTable.Columns.Add("pretMediu", typeof(double));
                    dateTable.Columns.Add("Proprietar", typeof(string));

                    foreach (Materiale m in listaMateriale)
                    {
                        DataRow row = dateTable.NewRow();
                        row["IdMaterial"] = m.CodMaterial;
                        row["denumireMaterial"] = m.DenumireMaterial;
                        row["stocDisponibil"] = m.StocDisponibil;
                        row["pretMediu"] = m.PretMediu;
                        row["Proprietar"] = m.Proprietar;
                        dateTable.Rows.Add(row);
                    }
                    dataGridView1.DataSource = dateTable;


                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataGridViewRow row = dataGridView1.Rows[i];
                        double cantitati = Convert.ToDouble(row.Cells[2].Value);

                        if (cantitati < 70)
                        {
                            string Text = "Marfa " + row.Cells[1].Value + " pentru " +
                                row.Cells[4].Value + " are nevoie de suplimentare!";
                            lb_suplimentare.Items.Add(Text);



                        }
                        else
                        {
                            string Text = "Marfa " + row.Cells[1].Value + " pentru " +
                                 row.Cells[4].Value + " se afla in cantitati suficiente!";

                            lb_suplimentare.Items.Add(Text);
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare! Acest fisier nu poate fi prelucrat!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void adaugareMaterialNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugareMaterial am = new AdaugareMaterial(null);
            if (am.ShowDialog() == DialogResult.OK)
            {
                DataRow newRow = DS_Materiale.Tables["Materiale_Companii"].NewRow();
                newRow["IdMaterial"] = am.model.CodMaterial;
                newRow["denumireMaterial"] = am.model.DenumireMaterial;
                newRow["stocDisponibil"] = am.model.StocDisponibil;
                newRow["pretMediu"] = am.model.PretMediu;
                newRow["Proprietar"] = am.model.Proprietar;

                DS_Materiale.Tables["Materiale_Companii"].Rows.Add(newRow);

                DataGridViewRow row = dataGridView1.Rows[dataGridView1.Rows.Count-1];
                double cantitati = Convert.ToDouble(row.Cells[2].Value);

                if (cantitati < 70)
                {
                    string Text = "Marfa " + row.Cells[1].Value + " pentru " +
                        row.Cells[4].Value + " are nevoie de suplimentare!";
                    lb_suplimentare.Items.Add(Text);



                }
                else
                {
                    string Text = "Marfa " + row.Cells[1].Value + " pentru " +
                         row.Cells[4].Value + " se afla in cantitati suficiente!";

                    lb_suplimentare.Items.Add(Text);
                }
            }

        }

        private void editeazaElementulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indexSelectat = dataGridView1.SelectedRows[0].Index;

                DataRow randSelectat = DS_Materiale.Tables["Materiale_Companii"].Rows[indexSelectat];

                Materiale materialSelectat = new Materiale(Convert.ToInt32(randSelectat["IdMaterial"]),
                    randSelectat["denumireMaterial"].ToString(), Convert.ToInt32(randSelectat["stocDisponibil"]),
                    Convert.ToDouble(randSelectat["pretMediu"]), randSelectat["Proprietar"].ToString());

                AdaugareMaterial am = new AdaugareMaterial(materialSelectat);
                if (am.ShowDialog() == DialogResult.OK)
                {
                    randSelectat["IdMaterial"] = am.model.CodMaterial;
                    randSelectat["denumireMaterial"] = am.model.DenumireMaterial;
                    randSelectat["stocDisponibil"] = am.model.StocDisponibil;
                    randSelectat["pretMediu"] = am.model.PretMediu;
                    randSelectat["Proprietar"] = am.model.Proprietar;

                    dataGridView1.Rows[indexSelectat].Cells[0].Value= am.model.CodMaterial;
                    dataGridView1.Rows[indexSelectat].Cells[1].Value = am.model.DenumireMaterial;
                    dataGridView1.Rows[indexSelectat].Cells[2].Value = am.model.StocDisponibil;
                    dataGridView1.Rows[indexSelectat].Cells[3].Value = am.model.PretMediu;
                    dataGridView1.Rows[indexSelectat].Cells[4].Value = am.model.Proprietar;

                    double cantitati = Convert.ToDouble(dataGridView1.Rows[indexSelectat].Cells[2].Value);
                    if (cantitati < 70)
                    {
                        string Text = "Marfa " + dataGridView1.Rows[indexSelectat].Cells[1].Value + " pentru " +
                            dataGridView1.Rows[indexSelectat].Cells[4].Value + " are nevoie de suplimentare!";
                        lb_suplimentare.Items.Add(Text);



                    }
                    else
                    {
                        string Text = "Marfa " + dataGridView1.Rows[indexSelectat].Cells[1].Value + " pentru " +
                             dataGridView1.Rows[indexSelectat].Cells[4].Value + " se afla in cantitati suficiente!";

                        lb_suplimentare.Items.Add(Text);
                    }
                }
            }
        }

        private void stergeElementulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int indexSelectat = dataGridView1.SelectedRows[0].Index;
                DataRow randSters = DS_Materiale.Tables["Materiale_Companii"].Rows[indexSelectat];

                if (randSters.RowState == DataRowState.Added)
                    DS_Materiale.Tables["Materiale_Companii"].RejectChanges();
                else
                {
                    int idSelectat = Convert.ToInt32(randSters["IdMaterial"]);
                  
                   
                    for (int i = 1; i <= lb_suplimentare.Items.Count; i++)
                    {
                        
                            int id = i;
                            if (id == idSelectat)
                            {
                            lb_suplimentare.Items.Remove(lb_suplimentare.Items[i]);
                            }
                       
                    }
                   
                    dataGridView1.Rows.RemoveAt(indexSelectat);
                    DS_Materiale.Tables["Materiale_Companii"].Rows.RemoveAt(indexSelectat);
                }
            }
        }

        private void stergeToataTabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DS_Materiale.Tables["Materiale_Companii"];

            for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
            {
                dataTable.Rows.RemoveAt(i);
            }
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            lb_suplimentare.Items.Clear();
        }

        private void cms_DateMateriale_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            

            Dictionary<string, double> cantitatiMarfuri = new Dictionary<string, double>();
            int nr = dataGridView1.RowCount - 1;
            for(int i=0; i<nr; i++)
            {
                DataGridViewRow dr = dataGridView1.Rows[i];
                string denumire = dr.Cells[1].Value.ToString();
                double cantitate =Convert.ToDouble(dr.Cells[2].Value);

                if (cantitatiMarfuri.ContainsKey(denumire))
                {
                    cantitatiMarfuri[denumire] += cantitate;
                }
                else
                {
                    cantitatiMarfuri.Add(denumire, cantitate);
                }
            }

            FormGrafic fg = new FormGrafic(cantitatiMarfuri);
            fg.Show();

        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void dataGridView1_DragOver(object sender, DragEventArgs e)
        {

        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void lb_suplimentare_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int index = lb_suplimentare.IndexFromPoint(e.X, e.Y);
                if (index >= 0 && index < lb_suplimentare.Items.Count)
                {
                    lb_suplimentare.DoDragDrop(lb_suplimentare.Items[index], DragDropEffects.Move);
                }
            }
        }

        private void lb_suplimentare_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void lb_suplimentare_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lb_suplimentare_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                string draggedItem = (string)e.Data.GetData(typeof(string));
                int targetIndex = lb_suplimentare.IndexFromPoint(lb_suplimentare.PointToClient(new Point(e.X, e.Y)));

                if (targetIndex >= 0 && targetIndex < lb_suplimentare.Items.Count)
                {
                    lb_suplimentare.Items.Remove(draggedItem);
                    lb_suplimentare.Items.Insert(targetIndex, draggedItem);
                }
            }
        }

        private void FormMarfuri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                salveazaDatele();
            }
        }
    }
}

 

