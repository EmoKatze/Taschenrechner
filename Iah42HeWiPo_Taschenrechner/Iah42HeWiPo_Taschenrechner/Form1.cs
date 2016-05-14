using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iah42HeWiPo_Taschenrechner
{
    public partial class RechnerForm : Form
    {
        public RechnerForm()
        {
            InitializeComponent();
        }

        private void ErgebnisButtonClick_Click(object sender, EventArgs e)
        {
            AusgabeTextBox.Text = "ErgebnisAusgabeTest";
        }
    }
}
