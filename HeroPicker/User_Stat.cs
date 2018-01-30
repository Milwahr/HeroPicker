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
    public partial class User_Stat : Form
    {
        public User_Stat()
        {
            InitializeComponent();
        }

        private void User_Stat_Load(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(baze_put.datasource);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM User_Heroes WHERE Id = " + id_korisnik.id_kor, con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = rdr;
            dataGridView1.DataSource = source;

            SQLiteCommand cmd1 = new SQLiteCommand("SELECT Tank, Offense, Defense, Support FROM User_Role WHERE Id = " + id_korisnik.id_kor, con);
            SQLiteDataReader rdr1 = cmd1.ExecuteReader();
            BindingSource source1 = new BindingSource();
            source1.DataSource = rdr1;
            dataGridView2.DataSource = source1;
            con.Close();

            label1.Text = "(" + id_korisnik.id_kor.ToString() + ") " + id_korisnik.user_name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
