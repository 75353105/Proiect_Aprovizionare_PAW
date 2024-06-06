using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CompanieAprovizionata
    {
        private string denumireCompanie;
        private Materiale[] materiale;
        private Contracte[] contracte;
        private Furnizori[] furnizori;

        public CompanieAprovizionata(string denumireCompanie, Materiale[] materiale, Contracte[] contracte, Furnizori[] furnizori)
        {
            this.denumireCompanie = denumireCompanie;
            this.materiale = materiale;
            this.contracte = contracte;
            this.furnizori = furnizori;
        }
        public CompanieAprovizionata()
        {

        }
        public string DenumireCompanie { get { return denumireCompanie; } set { denumireCompanie = value; } }
        public Materiale[] Materiale { get { return materiale; } set { materiale = value; } }
        public Contracte[] Contracte { get { return contracte; } set { contracte = value; } }
        public Furnizori[] Furnizori { get { return furnizori; } set { furnizori = value; } }

    }
}
