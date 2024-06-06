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
    public partial class UserControlContract : UserControl
    {
        public EventHandler<SelectedCompanyEventArgs> companieSelectata;
        public string CompanieSelectata
        {
            get { return cb_companii.SelectedItem?.ToString(); }
        }
        private void OnCompanySelected()
        {
            companieSelectata?.Invoke(this, new SelectedCompanyEventArgs(CompanieSelectata));
        }
        
        public class SelectedCompanyEventArgs : EventArgs
        {
            public string CompanieSelectata { get; }
            public  SelectedCompanyEventArgs(string CompanieSelectata)
            {
                this.CompanieSelectata = CompanieSelectata;
            }
        }
        public UserControlContract()
        {
            InitializeComponent();
        }

        private void cb_companii_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnCompanySelected();
        }
    }
}
