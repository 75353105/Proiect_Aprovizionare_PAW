using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdaugaContracte : Form
    {
        public Contracte intermediar;
        public AdaugaContracte(Contracte intermediar)
        {
            InitializeComponent();
            if(intermediar == null)
            {
                this.intermediar = new Contracte();
            }
           
        }

        private void btn_adauga_Click(object sender, EventArgs e)
        {
            intermediar.CodContract = int.Parse(tb_ID.Text);
            intermediar.NumeCompanie = tb_numeCompanie.Text;
            intermediar.DataLivrarii = dtp_Livrare.Value;
            intermediar.DataSemnarii=dtp_Semnare.Value;
            intermediar.NumeFurnizor = tb_numeFurnizor.Text;
            intermediar.ValoareCotnract = double.Parse(tb_ValoareContract.Text);
            intermediar.ProcentPenalizare = double.Parse(tb_ProcentPenalizare.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void tb_ID_Validating(object sender, CancelEventArgs e)
        {
            if (tb_ID.Text == "")
            {
                erP_ID.SetError(tb_ID, "In acest camp trebuie neaparat introdusa o valoare!");
                e.Cancel = true;
            }
            else
            if (!System.Text.RegularExpressions.Regex.IsMatch(tb_ID.Text, "^[0-9]+$"))
            {
                erP_ID.SetError(tb_ID, "Introduceti valori numerice");
            }
            else
            {
                erP_ID.SetError(tb_ID, "");
            }
        }
    }
}
