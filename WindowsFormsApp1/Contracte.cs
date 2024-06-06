using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace WindowsFormsApp1
{

    [Serializable]
    public class Contracte
    {
        private string numeCompanie;
        private string numeFurnizor;
        private DateTime dataSemnarii;
        private DateTime dataLivrarii;
        private int codContract;
        private double valoareCotnract;
        private double procentPenalizare;

        public Contracte(string numeCompanie, string numeFurnizor, DateTime dataSemnarii, DateTime dataLivrarii, int codContract, double valoareCotnract, double procentPenalizare)
        {
            this.numeCompanie = numeCompanie;
            this.numeFurnizor = numeFurnizor;
            this.dataSemnarii = dataSemnarii;
            this.dataLivrarii = dataLivrarii;
            this.codContract = codContract;
            this.valoareCotnract = valoareCotnract;
            this.procentPenalizare = procentPenalizare;
        }

        public Contracte()
        {

        }

        public DateTime DataSemnarii { get { return dataSemnarii; } set { dataSemnarii = value; } }
        public DateTime DataLivrarii { get { return dataLivrarii; } set { dataLivrarii = value; } }
        public int CodContract { get { return codContract; } set { codContract = value; } }
        public double ValoareCotnract { get { return valoareCotnract; }set { valoareCotnract = value; } }
        public double ProcentPenalizare { get { return procentPenalizare; } set { procentPenalizare = value; } }

        public string NumeCompanie { get { return numeCompanie; } set { numeCompanie = value; } }
        public string NumeFurnizor { get { return numeFurnizor; } set { numeFurnizor = value; } }
    }
}
