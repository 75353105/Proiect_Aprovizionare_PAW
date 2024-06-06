using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FormCompanii : Form
    {
        public CompanieAprovizionata[] companii = new CompanieAprovizionata[2];
      
        public Contracte[] vectorContracte;

        public FormCompanii()
        {
            InitializeComponent();
            companii[0] = new CompanieAprovizionata();
            companii[1] = new CompanieAprovizionata();


            for (int i = 0; i < 2; i++)
            {
                companii[i] = new CompanieAprovizionata();
            }
            companii[0].DenumireCompanie = "Audi";
            companii[1].DenumireCompanie = "BMW";
            List<Furnizori> furnizoriAudi = new List<Furnizori>();
            List<Furnizori> furnizoriBMW = new List<Furnizori>();
            List<Furnizori> furnizoriList = new List<Furnizori>();
            Furnizori furnizor1 = new Furnizori(123, "Tagachi", new string[] { "Jante de plastic", "Vopsea" }, new double[] { 10, 20 }, new double[] { 5.5, 10.3 }, "Audi");
            furnizoriList.Add(furnizor1);

            Furnizori furnizor2 = new Furnizori(456, "Fuzumu", new string[] { "Cauciucuri", "rame de plastic" }, new double[] { 15, 30 }, new double[] { 8.2, 12.6 }, "Audi");
            furnizoriList.Add(furnizor2);

            Furnizori furnizor3 = new Furnizori(789, "Starcrfat", new string[] { "Oglinzi", "Sticla" }, new double[] { 12, 24 }, new double[] { 6.1, 11.8 }, "BMW");
            furnizoriList.Add(furnizor3);

            Furnizori furnizor4 = new Furnizori(134, "Rhein", new string[] { "lichid de parbriz", "Bare de metal" }, new double[] { 15, 20 }, new double[] { 6.6, 7.8 }, "BMW");
            furnizoriList.Add(furnizor4);
            Furnizori furnizor5 = new Furnizori(265, "Merz", new string[] { "Geamuri", "Freoane" }, new double[] { 17, 24 }, new double[] { 11.2, 16.7 }, "Audi");
            furnizoriList.Add(furnizor5);
            Furnizori furnizor6 = new Furnizori(269, "Automotif", new string[] { "Manete", "Stergatoare de parbriz" }, new double[] { 18, 21 }, new double[] { 10, 15 }, "BMW" );
            furnizoriList.Add(furnizor6);

            foreach(Furnizori furnizor in furnizoriList)
            {
                TreeNode tn = new TreeNode(furnizor.CODcaen.ToString() + " ---- " + furnizor.DenumireFurnizor);
                tv_Furnizori.Nodes.Add(tn);
                tn.Tag = furnizor.NumeRecipient;
                TreeNode produse = new TreeNode("Produsele pentru "+furnizor.NumeRecipient);
               

                for (int i = 0; i < furnizor.ProduseFurnizor.Length; i++)
                {
                    
                       TreeNode produs =new TreeNode( furnizor.ProduseFurnizor[i] + " - " + furnizor.CantitatiDinProduse[i].ToString() + " - " +
                            furnizor.PreturiFurnizorPtProduse[i].ToString());
                    produs.Tag = furnizor.ProduseFurnizor[i];
                    produse.Nodes.Add(produs);
                   

                }
               
                tn.Nodes.Add(produse);

                if (furnizor.NumeRecipient == "Audi")
                {
                    furnizoriAudi.Add(furnizor);
                }
                else
                if(furnizor.NumeRecipient=="BMW")
                {
                    furnizoriBMW.Add(furnizor);
                }

            }
            companii[0].Furnizori = furnizoriAudi.ToArray<Furnizori>();
            companii[1].Furnizori = furnizoriBMW.ToArray<Furnizori>();

        }
        public void setContracte(Contracte[] contracte)
        {
            vectorContracte = contracte;
        }

        private void FormCompanii_Load(object sender, EventArgs e)
        {
            
        }

       
        string prevSelectedCompany = "";
        List<Furnizori> furnizoriNepotriviti=new List<Furnizori>();

        private void cb_Companii_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image audi = Image.FromFile(@"C:\Users\Gucci\Desktop\PAW\H_logo_Audi_nou.jpg");
            Image BMW = Image.FromFile(@"C:\Users\Gucci\Desktop\PAW\bmw-bun.jpg");
            if (cb_Companii.SelectedItem.ToString() == "Audi")
            {
                pb_SigleCompanii.Image = audi;
            }
            else
                if (cb_Companii.SelectedItem.ToString() == "BMW")
            {
                pb_SigleCompanii.Image = BMW;
            }
            List<Furnizori> listaFurnizori = new List<Furnizori>();

            foreach (TreeNode nodFurnizor in tv_Furnizori.Nodes)
            {
                Furnizori furnizori = new Furnizori();
                furnizori.NumeRecipient = nodFurnizor.Nodes[0].Text.Split(' ')[2];
                furnizori.CODcaen = int.Parse(nodFurnizor.Text.Split(' ')[0]);
                furnizori.DenumireFurnizor = nodFurnizor.Text.Split(' ')[2];
                List<string> produse = new List<string>();
                List<double> cantitati = new List<double>();
                List<double> preturi = new List<double>();
                foreach (TreeNode nodProdus in nodFurnizor.Nodes[0].Nodes)
                {
                    string[] produsData = nodProdus.Text.Split('-');
                    produse.Add(produsData[0].Trim());
                    cantitati.Add(double.Parse(produsData[1].Trim()));
                    preturi.Add(double.Parse(produsData[2].Trim()));
                }

                furnizori.ProduseFurnizor = produse.ToArray();
                furnizori.CantitatiDinProduse = cantitati.ToArray();
                furnizori.PreturiFurnizorPtProduse = preturi.ToArray();

                listaFurnizori.Add(furnizori);
            }

            string SelectedCompany = cb_Companii.SelectedItem.ToString();

            if (prevSelectedCompany == "")
            {
                tv_Furnizori.Nodes.Clear();

                foreach (var furnizori in listaFurnizori)
                {
                    if (furnizori.NumeRecipient == cb_Companii.SelectedItem.ToString())
                    {
                        TreeNode tn = new TreeNode(furnizori.CODcaen.ToString() + " ---- " + furnizori.DenumireFurnizor);
                        tv_Furnizori.Nodes.Add(tn);
                        tn.Tag = furnizori.NumeRecipient;
                        TreeNode produse = new TreeNode("Produsele pentru " + furnizori.NumeRecipient);


                        for (int i = 0; i < furnizori.ProduseFurnizor.Length; i++)
                        {

                            TreeNode produs = new TreeNode(furnizori.ProduseFurnizor[i] + " - " + furnizori.CantitatiDinProduse[i].ToString() + " - " +
                                 furnizori.PreturiFurnizorPtProduse[i].ToString());
                            produs.Tag = furnizori.ProduseFurnizor[i];
                            produse.Nodes.Add(produs);


                        }

                        tn.Nodes.Add(produse);
                        furnizoriNepotriviti.Add(furnizori);
                    }
                    else
                    {
                        furnizoriNepotriviti.Add(furnizori);
                    }
                }
                prevSelectedCompany = SelectedCompany;
            }
            else
            if (SelectedCompany != prevSelectedCompany)
            {
                tv_Furnizori.Nodes.Clear();
                foreach (var furnizori in furnizoriNepotriviti)
                {
                    if (furnizori.NumeRecipient == cb_Companii.SelectedItem.ToString())
                    {
                        TreeNode tn = new TreeNode(furnizori.CODcaen.ToString() + " ---- " + furnizori.DenumireFurnizor);
                        tv_Furnizori.Nodes.Add(tn);
                        tn.Tag = furnizori.NumeRecipient;
                        TreeNode produse = new TreeNode("Produsele pentru " + furnizori.NumeRecipient);


                        for (int i = 0; i < furnizori.ProduseFurnizor.Length; i++)
                        {

                            TreeNode produs = new TreeNode(furnizori.ProduseFurnizor[i] + " - " + furnizori.CantitatiDinProduse[i].ToString() + " - " +
                                 furnizori.PreturiFurnizorPtProduse[i].ToString());
                            produs.Tag = furnizori.ProduseFurnizor[i];
                            produse.Nodes.Add(produs);


                        }

                        tn.Nodes.Add(produse);
                    }
                    
                    
                }
                prevSelectedCompany = SelectedCompany;
            }
        }

        private void salvareDateBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cb_Companii.SelectedItem.ToString() != "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Fiecare furnizor *.frm|*.frm";
                sfd.CheckPathExists = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    List<Furnizori> listaFurnizori = new List<Furnizori>();

                    foreach (TreeNode nodFurnizor in tv_Furnizori.Nodes)
                    {
                        Furnizori furnizori = new Furnizori();
                        furnizori.NumeRecipient = cb_Companii.SelectedItem.ToString();
                        furnizori.CODcaen = int.Parse(nodFurnizor.Text.Split(' ')[0]);
                        furnizori.DenumireFurnizor = nodFurnizor.Text.Split(' ')[2];
                        List<string> produse = new List<string>();
                        List<double> cantitati = new List<double>();
                        List<double> preturi = new List<double>();
                        foreach (TreeNode nodProdus in nodFurnizor.Nodes[0].Nodes)
                        {
                            string[] produsData = nodProdus.Text.Split('-');
                            produse.Add(produsData[0].Trim());
                            cantitati.Add(double.Parse(produsData[1].Trim()));
                            preturi.Add(double.Parse(produsData[2].Trim()));
                        }

                        furnizori.ProduseFurnizor = produse.ToArray();
                        furnizori.CantitatiDinProduse = cantitati.ToArray();
                        furnizori.PreturiFurnizorPtProduse = preturi.ToArray();

                        listaFurnizori.Add(furnizori);
                    }

                    BinaryFormatter bf = new BinaryFormatter();
                    using (FileStream fileStream = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        bf.Serialize(fileStream, listaFurnizori);
                    }


                }
            }
            else
            {
                MessageBox.Show("Alege o companie a caror date vrei sa le salvezi!");
            }

        }

        private void preluareDateBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fiecare furnizor *.frm|*.frm";
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<Furnizori> listaFurnizori = new List<Furnizori>();

                BinaryFormatter serializator = new BinaryFormatter();
                try
                {
                    Stream fisier = File.OpenRead(ofd.FileName);
                    listaFurnizori.AddRange((List<Furnizori>)serializator.Deserialize(fisier));
                    fisier.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Eroare! Acest fisier nu poate fi prelucrat!",MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                foreach (Furnizori furnizor in listaFurnizori)
                {
                    TreeNode tn = new TreeNode(furnizor.CODcaen.ToString() + " ---- " + furnizor.DenumireFurnizor);
                    tv_Furnizori.Nodes.Add(tn);
                    tn.Tag = furnizor.DenumireFurnizor;
                    TreeNode produse = new TreeNode("Produsele furnizorului:");


                    for (int i = 0; i < furnizor.ProduseFurnizor.Length; i++)
                    {

                        TreeNode produs = new TreeNode(furnizor.ProduseFurnizor[i] + " - " + furnizor.CantitatiDinProduse[i].ToString() + " - " +
                             furnizor.PreturiFurnizorPtProduse[i].ToString());
                        produs.Tag = furnizor.ProduseFurnizor[i];
                        produse.Nodes.Add(produs);


                    }

                    tn.Nodes.Add(produse);

                }
            }
        }

        private void salvareDateXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cb_Companii.SelectedItem.ToString() != "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Fiecare furnizor *.fir|*.fir";
                sfd.CheckPathExists = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    List<Furnizori> listaFurnizori = new List<Furnizori>();

                    foreach (TreeNode nodFurnizor in tv_Furnizori.Nodes)
                    {
                        Furnizori furnizori = new Furnizori();
                        furnizori.CODcaen = int.Parse(nodFurnizor.Text.Split(' ')[0]);
                        furnizori.DenumireFurnizor = nodFurnizor.Text.Split(' ')[2];
                        List<string> produse = new List<string>();
                        List<double> cantitati = new List<double>();
                        List<double> preturi = new List<double>();
                        foreach (TreeNode nodProdus in nodFurnizor.Nodes[0].Nodes)
                        {
                            string[] produsData = nodProdus.Text.Split('-');
                            produse.Add(produsData[0].Trim());
                            cantitati.Add(double.Parse(produsData[1].Trim()));
                            preturi.Add(double.Parse(produsData[2].Trim()));
                        }

                        furnizori.ProduseFurnizor = produse.ToArray();
                        furnizori.CantitatiDinProduse = cantitati.ToArray();
                        furnizori.PreturiFurnizorPtProduse = preturi.ToArray();

                        listaFurnizori.Add(furnizori);
                    }


                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Furnizori>));

                        xmlSerializer.Serialize(fs, listaFurnizori);
                    }


                }
            }
            else
            {
                MessageBox.Show("Alege o companie a caror date vrei sa le salvezi");
            }
        }

        private void preluareDateXmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fiecare furnizor *.fir|*.fir";
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<Furnizori> listaFurnizori = new List<Furnizori>();

               
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Furnizori>));

                    StreamReader streamReader = new StreamReader(ofd.FileName);
                    listaFurnizori.AddRange((List<Furnizori>)serializer.Deserialize(streamReader));
                    streamReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eroare! Acest fisier nu poate fi prelucrat!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                foreach (Furnizori furnizor in listaFurnizori)
                {
                    TreeNode tn = new TreeNode(furnizor.CODcaen.ToString() + " ---- " + furnizor.DenumireFurnizor);
                    tv_Furnizori.Nodes.Add(tn);
                    tn.Tag = furnizor.DenumireFurnizor;
                    TreeNode produse = new TreeNode("Produsele furnizorului:");


                    for (int i = 0; i < furnizor.ProduseFurnizor.Length; i++)
                    {

                        TreeNode produs = new TreeNode(furnizor.ProduseFurnizor[i] + " - " + furnizor.CantitatiDinProduse[i].ToString() + " - " +
                             furnizor.PreturiFurnizorPtProduse[i].ToString());
                        produs.Tag = furnizor.ProduseFurnizor[i];
                        produse.Nodes.Add(produs);


                    }

                    tn.Nodes.Add(produse);

                }
            }
        }

        private void veziMărfurileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void veziMarfurileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMarfuri fm = new FormMarfuri();

            
            if (fm.ShowDialog() == DialogResult.OK)
            {
                int a = 0;
                int b = 0;
                foreach (Materiale material in fm.materiale)
                {
                    
                    
                    if (material.Proprietar == "Audi")
                    {
                        int desiredSize = fm.materiale.Count();
                        companii[0].Materiale = new Materiale[desiredSize];
                        companii[0].Materiale[a] = material;
                        
                        a++;
                    }
                    else
                    if (material.Proprietar == "BMW")
                    {
                        int desiredSize = fm.materiale.Count();
                        companii[1].Materiale = new Materiale[desiredSize];
                        companii[1].Materiale[b] = material;
                        b++;
                    }
                }
            }

            
        }

        private void iesireDinAplicatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acceseazaContracteleUnuiFurnizorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string companieSelectata = userControlContract1.CompanieSelectata;
            if (companieSelectata == "Audi")
            {
                FormContracte fc = new FormContracte(companii[0]);
                fc.Show();
            }
            else
            if (companieSelectata == "BMW")
            {
                FormContracte fc = new FormContracte(companii[1]);
                fc.Show();
            }
            else
            if(companieSelectata=="")
            {
                MessageBox.Show("Trebbuie sa selectezi o comapnie mai intai!");
            }
        }
    }
}
