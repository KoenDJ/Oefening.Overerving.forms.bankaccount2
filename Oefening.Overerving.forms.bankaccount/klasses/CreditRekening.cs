using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening.Overerving.forms.bankaccount
{
    public class CreditRekening : Rekening
    {
        public CreditRekening(string rekeningNr) : base(rekeningNr)
        {
            RekeningNr = rekeningNr;
        }
    }
}
