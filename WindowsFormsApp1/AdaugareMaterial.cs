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
    public partial class AdaugareMaterial : Form
    {
        public Materiale model;

        public AdaugareMaterial(Materiale m)
        {
            InitializeComponent();
            if (m == null)
            {
                model = new Materiale();
            }
            else
            {
                model = m;
                tb_IdMarfa.Text = m.CodMaterial.ToString();
                tb_denumireMarfa.Text = m.DenumireMaterial;
                tb_stocDisponibil.Text = m.StocDisponibil.ToString();
                tb_pretMediu.Text = m.PretMediu.ToString();
                tb_Proprietar.Text = m.Proprietar.ToString();
            }
        }

        private void tb_IdMarfa_Validating(object sender, CancelEventArgs e)
        {
            if(tb_IdMarfa.Text == "")
            {
                erP_ID.SetError(tb_IdMarfa, "In acest camp trebuie neaparat introdusa o valoare!");
                e.Cancel = true;
            }
            else
            if (!System.Text.RegularExpressions.Regex.IsMatch(tb_IdMarfa.Text, "^[0-9]+$"))
            {
                erP_ID.SetError(tb_IdMarfa, "Introduceti valori numerice");
            }
            else
            {
                erP_ID.SetError(tb_IdMarfa, "");
            }
        }

        private void tb_Proprietar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Proprietar_Validating(object sender, CancelEventArgs e)
        {
            if (tb_Proprietar.Text == "")
            {
                erP_Proprietar.SetError(tb_Proprietar, "In acest camp trebuie neaparat introdusa o valoare!");
                e.Cancel = true;
            }
            
            else
            {
                erP_Proprietar.SetError(tb_Proprietar, "");
            }
        }

        private void tb_denumireMarfa_Validating(object sender, CancelEventArgs e)
        {
            if (tb_denumireMarfa.Text.Length < 3)
            {
                erP_Denumire.SetError(tb_denumireMarfa, "Nu ati introdus un produs corespunzator!");
            }
        }

        private void tb_stocDisponibil_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(tb_stocDisponibil.Text, "^[0-9]+$"))
            {
                erP_stoc.SetError(tb_stocDisponibil, "Nu ati introdus date numerice corecte");
            }
            else
            {
                erP_stoc.SetError(tb_stocDisponibil, "");
            }
        }

        private void tb_pretMediu_Validating(object sender, CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(tb_pretMediu.Text, "^[0-9]+$"))
            {
                erP_pret.SetError(tb_stocDisponibil, "Nu ati introdus date numerice corecte");
            }
            else
            {
                erP_pret.SetError(tb_stocDisponibil, "");
            }
        }

        private void btn_adaugaSauEditeaza_Click(object sender, EventArgs e)
        {
            model.CodMaterial =int.Parse( tb_IdMarfa.Text);
            model.DenumireMaterial = tb_denumireMarfa.Text;
            model.StocDisponibil = double.Parse(tb_stocDisponibil.Text);
            model.PretMediu = double.Parse(tb_pretMediu.Text);
            model.Proprietar = tb_Proprietar.Text;

            this.DialogResult = DialogResult.OK;
        }

        private void AdaugareMaterial_Load(object sender, EventArgs e)
        {

        }
    }
}
