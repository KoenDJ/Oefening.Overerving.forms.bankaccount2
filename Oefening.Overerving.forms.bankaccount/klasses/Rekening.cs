using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening.Overerving.forms.bankaccount
{
    public class Rekening
    {
        public string RekeningNr = "BE## #### #### ####";
        public int Saldo { get; set; }

        public Rekening(string rekeningNr, int saldo)
        {
            RekeningNr = rekeningNr;
            Saldo = saldo;
        }
        public Rekening(string rekeningNr)
        {
            RekeningNr = rekeningNr;
            Saldo = 0;
        }
        public Rekening()
        {

        }

        public override string ToString()
        {
            return RekeningNr;
        }

        public void GenereerRekeningnummer()
        {
            Random rng = new Random();
            RekeningNr = "BE" + rng.Next(99).ToString().PadLeft(2, '0');
            for (int i = 1; i <= 3; i++)
            {
                int randomnr = rng.Next(9999);
                RekeningNr += " " + randomnr.ToString().PadLeft(4, '0');
            }
        }
        public void EersteRekening()
        {
           GenereerRekeningnummer();
            Saldo = 10000;
        }

    }
}
