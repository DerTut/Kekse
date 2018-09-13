using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buchung
{
    public partial class Ausgabe : Form
    {
        public Ausgabe()
        {
            InitializeComponent();
        }

        private void b_zurück_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_abfragen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abfrage läuft...\nBitte warten.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
