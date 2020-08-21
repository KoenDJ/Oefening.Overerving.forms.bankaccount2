using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening.Overerving.forms.bankaccount
{
    public class DebitRekening : Rekening
    {
        public DebitRekening(string rekeningNr):base(rekeningNr)
        {
            RekeningNr = rekeningNr;
        }
        public DebitRekening()
        {

        }
       
    }
}
