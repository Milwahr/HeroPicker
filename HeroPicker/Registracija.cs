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
                    SQLiteCommand cmd1 = new SQLiteCommand("INSERT INTO User_Heroes (Doomfist) Values (0)", con);
                    cmd1.ExecuteNonQuery();
                    SQLiteCommand cmd2 = new SQLiteCommand("INSERT INTO User_Role (Tank) Values (0);", con);
                    cmd2.ExecuteNonQuery();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
