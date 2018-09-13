using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Buchung
{
    public partial class Hauptfenster : Form
    {
        public Hauptfenster()
        {
            InitializeComponent();
        }

        private void b_eingabe_Click(object sender, EventArgs e)
        {
            Eingabe eingabe = new Eingabe();
            eingabe.ShowDialog();
        }

        private void b_ausgabe_Click(object sender, EventArgs e)
        {
            Ausgabe ausgabe = new Ausgabe();
            ausgabe.ShowDialog();
        }
        public static string Connector()
        {
            string connection = "Server=127.0.0.1; Database=buchungen; User Id = root; Password=''";
            return connection;
        }
    }
}
