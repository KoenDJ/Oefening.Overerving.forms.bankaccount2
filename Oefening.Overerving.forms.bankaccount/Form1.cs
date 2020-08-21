using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening.Overerving.forms.bankaccount
{
    public partial class StartForm : Form
    {
        public List<Rekening> rekeningLijst = new List<Rekening>();
        public StartForm()
        {
            InitializeComponent();
           
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            DebitRekening debit = new DebitRekening();
            debit.EersteRekening();
            rekeningLijst.Add(debit);
            lbRekeningen.DataSource = rekeningLijst;
        }
    }
}
