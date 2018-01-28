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
                //SQLiteCommand cmd = new SQLiteCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "SELECT id FROM Korisnik WHERE Username = ' " + textBox1.Text + "' and Password ='" + textBox2.Text + "'";
                //cmd.Connection = con;
                //con.Open();
                ////SQLiteDataReader dr;
                ////dr = cmd.ExecuteReader();
                //using (SQLiteDataReader rdr = cmd.ExecuteReader())
                //{
                //    while (rdr.Read())
                //    {
                //        rdr.Read();
                //        int d = rdr.GetInt32(0);
                //        id_korisnik.login(d);
                //    }
                //}

                //con.Close();

                //int firstVariable;
                //try
                //{

                //    using (SQLiteConnection connection = new SQLiteConnection(baze_put.datasource))
                //    {
                //        using (SQLiteCommand command = new SQLiteCommand("SELECT id FROM Korisnik WHERE Username = ' " + textBox1.Text + "' and Password ='" + textBox2.Text + "'", connection))
                //        {
                //            connection.Open();
                //            using (SQLiteDataReader reader = command.ExecuteReader())
                //            {
                //                while (reader.Read())
                //                {
                //                    firstVariable = Convert.ToInt32(reader);
                //                    id_korisnik.login(firstVariable);
                //                }
                //            }
                //        }
                //    }
                //}

                //catch (Exception ex)
                //{
                //    MessageBox.Show("Error in reading id");
                //}
                
                string query = "SELECT id FROM Korisnik WHERE Username = ' " + textBox1.Text + "' and Password ='" + textBox2.Text + "'";

                using (SQLiteConnection conn = new SQLiteConnection(baze_put.datasource))
                {
                     SQLiteCommand cmd = new SQLiteCommand(query, conn);
                     conn.Open();
                     SQLiteDataReader reader = cmd.ExecuteReader();
                     int d;
                     while (reader.Read())
                     {
                         d = Convert.ToInt32(reader);
                         id_korisnik.login(d);
                         MessageBox.Show(d.ToString());
                     }
                     reader.Close();
                }
                
                MainMenu mm = new MainMenu();
                mm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login attempt failed! Check your login information.");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registracija r = new Registracija();
            r.Show();
            r.Shown += R_Shown;
            r.FormClosed += R_FormClosed;
        }

        private void R_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }

        private void R_Shown(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }
    }
}
