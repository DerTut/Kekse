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
    public partial class Eingabe : Form
    {
        public Eingabe()
        {
            InitializeComponent();
        }

        private void b_zurück_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_speichern_Click(object sender, EventArgs e)
        {
            string grund = tb_grund.Text;
            int art = Convert.ToInt32(Art_bestimmen());
            double wert = Convert.ToDouble(tb_wert.Text);
            string datum = dtp_datum.Value.ToString("yyyy-MM-dd");

            MySqlConnection conn = new MySqlConnection(Hauptfenster.Connector());
            MySqlCommand speichern = new MySqlCommand();
            speichern.CommandText = "INSERT INTO buchung (Grund, Art, Wert, Datum) VALUES('" + grund + "' ,'" + art + "' ,'" + wert + "' ,'" + datum + "')";
            speichern.Connection = conn;
            conn.Open();
            speichern.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Daten erfolgreich gespeichert.");

        }
        private bool Art_bestimmen()
        {
            bool art = new bool();

            if (rb_einnahmen.Checked == true)
            {
                art = true;
            }
            else if (rb_ausgaben.Checked == true)
            {
                art = false;
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie ob es eine Einnahme oder eine Ausgabe ist.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return art;
        }
    }
}
