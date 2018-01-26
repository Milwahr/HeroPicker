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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(baze_put.datasource);
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select Count(*) From Korisnik where Username='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                

                MainMenu mm = new MainMenu();
                mm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login attempt failed! Check your login information.");
            }
        }
    }
}
