using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class FormContracte : Form
    {

        public CompanieAprovizionata model;
       

        string conexiuneServer = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gucci\Desktop\PAW\WindowsFormsApp1\WindowsFormsApp1\Materiale_Companii.mdf;Integrated Security=True";
        string selectComand = "select * from Contracte_Companii";
        DataSet DS_Materiale = new DataSet();
        public FormContracte(CompanieAprovizionata ca)
        {
            InitializeComponent();
            model = ca;
            incarcaDate();
        }
        private void incarcaDate()
        {
            
            SqlConnection conexiune = new SqlConnection(conexiuneServer);
            conexiune.Open();
            SqlDataAdapter sqldataadapter=new SqlDataAdapter(selectComand,conexiune);
            sqldataadapter.Fill(DS_Materiale, "Contracte_Companii");
            DS_Materiale.Tables["Contracte_Companii"].PrimaryKey = new DataColumn[1]
            {
                DS_Materiale.Tables["Contracte_Companii"].Columns["Id"]

            };
            List<Contracte> buffer = new List<Contracte>();
            lv_Contracte.Items.Clear();
            foreach (DataRow rand in DS_Materiale.Tables["Contracte_Companii"].Rows)
            {
                if (rand["numeCompanie"].ToString() == model.DenumireCompanie) { 
                    int cod = Convert.ToInt32(rand["Id"]);
                string numeCompanie = rand["numeCompanie"].ToString();
                string numeFurnizor = rand["numeFurnizor"].ToString();
                DateTime dataSemnare = Convert.ToDateTime(rand["dataSemnare"]);
                DateTime dataLivrare = Convert.ToDateTime(rand["dataLivrare"]);
                double valoareContract = Convert.ToDouble(rand["valoareContract"]);
                double procentPenalizare = Convert.ToDouble(rand["procentPealizare"]);
                ListViewItem obiect = new ListViewItem(cod.ToString());
                obiect.SubItems.Add(numeCompanie);
                obiect.SubItems.Add(dataSemnare.ToString());
                obiect.SubItems.Add(dataLivrare.ToString());
                obiect.SubItems.Add(numeFurnizor);
                obiect.SubItems.Add(valoareContract.ToString());
                obiect.SubItems.Add(procentPenalizare.ToString());

                lv_Contracte.Items.Add(obiect);

                Contracte nou = new Contracte(numeCompanie, numeFurnizor, dataSemnare, dataLivrare, cod,
                    valoareContract, procentPenalizare);
                buffer.Add(nou);
                }
               
            }
            model.Contracte = buffer.ToArray<Contracte>();
            conexiune.Close();

        }

        private void FormContracte_Load(object sender, EventArgs e)
        {

        }

        private void inapoiLaPaginaPrincipalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void iesireTotalaDinAplicatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fisierBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Fisiere contract *.con|*.con";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Contracte> lista = new List<Contracte>();
                foreach (ListViewItem item in lv_Contracte.Items)
                    lista.Add((Contracte)item.Tag);

                BinaryFormatter serializator = new BinaryFormatter();
                Stream fisier = File.Create(fd.FileName);
                serializator.Serialize(fisier, lista);
                fisier.Close();
            }
        }

        private void fisierXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Fisiere contract *.xml|*.xml";
            sfd.CheckPathExists = true;
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                List<Contracte> lista = new List<Contracte>();

                foreach(ListViewItem lvi in lv_Contracte.Items)
                {
                    lista.Add((Contracte)lvi.Tag);
                }
                XmlSerializer serializator = new XmlSerializer(typeof(Contracte));
                TextWriter writer=new StreamWriter(sfd.FileName);
                serializator.Serialize(writer, lista);
            }
        }

        private void adaugaContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAdauga = new AdaugaContracte(null);
            if(formAdauga.ShowDialog() == DialogResult.OK)
            {
                string cod = formAdauga.intermediar.CodContract.ToString();
                string numeComapnie = formAdauga.intermediar.NumeCompanie;
                string numeFurnizor = formAdauga.intermediar.NumeFurnizor;
                string dataSemnare = formAdauga.intermediar.DataSemnarii.ToString();
                string dataLivrare = formAdauga.intermediar.DataLivrarii.ToString();
                string valoareContract = formAdauga.intermediar.ValoareCotnract.ToString();
                string penalizare = formAdauga.intermediar.ProcentPenalizare.ToString();

                DataRow rand = DS_Materiale.Tables["Contracte_Companii"].NewRow();
                rand["Id"]=cod;
                rand["numeCompanie"] = numeComapnie;
                rand["numeFurnizor"]=numeFurnizor;
                rand["dataSemnare"]=dataSemnare;
                rand["dataLivrare"]=dataLivrare;
                rand["valoareContract"]=valoareContract;
                rand["procentPealizare"]=penalizare;
                DS_Materiale.Tables["Contracte_Companii"].Rows.Add(rand);
                incarcaDate();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void stergeContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lv_Contracte.SelectedItems.Count > 0)
            {
                ListViewItem selectat = lv_Contracte.SelectedItems[0];
                int idSelectat = Convert.ToInt32(selectat.SubItems[0].Text);
                DialogResult rezultat = MessageBox.Show("Esti sigur ca vrei sa stergi acest contract?", "Confirma mai intai!",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rezultat == DialogResult.Yes)
                {
                    DataRow randuri = DS_Materiale.Tables["Contracte_Companii"].Rows.Find(idSelectat);

                    if (randuri != null) { 

                    randuri.Delete();
                        lv_Contracte.Items.Remove(selectat);
                        //incarcaDate();

                    List<Contracte> contracteNou = new List<Contracte>(model.Contracte);
                    Contracte contractSters = contracteNou.FirstOrDefault(c => c.CodContract == idSelectat);
                    if (contractSters != null)
                    {
                        contracteNou.Remove(contractSters);
                        model.Contracte = contracteNou.ToArray();
                    }
                    }
                    
                }
            }
        }
    }
}
