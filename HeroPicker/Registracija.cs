using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HeroPicker
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(baze_put.datasource))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Korisnik (Username, Password, Ime, Prezime, Email) Values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "');", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Succesful registration!");
                
                this.Close();
            }
            catch (Exception g)
            {
                MessageBox.Show("Information invalid!");
            }
        }
    }
}
