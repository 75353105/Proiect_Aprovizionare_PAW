using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Materiale
    {

        private int codMaterial;
        private string denumireMaterial;
        private string proprietar;
        private double stocDisponibil;
        private double pretMediu;

        public Materiale(int codMaterial, string denumireMaterial, double stocDisponibil, double pretMediu, string proprietar)
        {
            this.codMaterial = codMaterial;
            this.denumireMaterial = denumireMaterial;
            this.stocDisponibil = stocDisponibil;
            this.pretMediu = pretMediu;
            this.proprietar = proprietar;
        }
        public Materiale()
        {

        }

        public int CodMaterial { get { return codMaterial; } set { codMaterial = value; } }
        public string DenumireMaterial { get { return denumireMaterial; } set { denumireMaterial = value; } }
        public double StocDisponibil { get { return stocDisponibil; } set { stocDisponibil = value; } }

        public double PretMediu { get { return pretMediu; } set { pretMediu = value; } }

        public string Proprietar { get { return proprietar; } set { proprietar = value; } }
    }
}
