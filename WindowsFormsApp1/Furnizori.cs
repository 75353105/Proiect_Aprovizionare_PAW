using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    [Serializable]
    public class Furnizori
    {

        private int codCAEN;
        private string denumireFurnizor;
        private string[] produseFurnizor;
        private double[] cantitatiDinProduse;
        private double[] preturiFurnizorPtProduse;
        private string numeRecipient;
       

        public Furnizori()
        {

        }
        public Furnizori(int codCAEN, string denumireFurnizor, string[] produseFurnizor, double[] cantitatiDinProduse,
            double[] preturiFurnizoriPtProduse)
        {
            this.codCAEN = codCAEN;
            this.denumireFurnizor = denumireFurnizor;
            this.produseFurnizor = produseFurnizor;
            this.cantitatiDinProduse = cantitatiDinProduse;
            this.preturiFurnizorPtProduse = preturiFurnizoriPtProduse;
            
        }
        public Furnizori(int codCAEN, string dF, string[] pF, double[] cDP, double[] pFPP, string numeRecipient)
        {
            this.codCAEN = codCAEN;
            this.denumireFurnizor = dF;
            this.produseFurnizor = pF;
            this.cantitatiDinProduse = cDP;
            this.preturiFurnizorPtProduse = pFPP;
            this.numeRecipient = numeRecipient;

        }
      
        

        public int CODcaen { get { return codCAEN; } set { codCAEN = value; } }
        public string DenumireFurnizor { get { return denumireFurnizor; } set { denumireFurnizor = value; } }
        public string[] ProduseFurnizor { get { return produseFurnizor; } set { produseFurnizor = value; } }
        public double[] CantitatiDinProduse
        {
            get { return cantitatiDinProduse; }
            set { cantitatiDinProduse = value; }
        }

        public double[] PreturiFurnizorPtProduse { get { return preturiFurnizorPtProduse; } set { preturiFurnizorPtProduse = value; } }

    

        public string NumeRecipient { get { return numeRecipient; } set { numeRecipient = value; } }
        
    }
}
