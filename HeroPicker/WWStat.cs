using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SQLite.Linq;

namespace HeroPicker
{
    public partial class WWStat : Form
    {
        public WWStat()
        {
            InitializeComponent();
        }

        private void WWStat_Load(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(baze_put.datasource);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT HeroName, Age, Role, Health, Armour, Shield, Predlozen FROM Heroes ORDER BY Predlozen DESC", con);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = rdr;
            dataGridView1.DataSource = source;

            SQLiteCommand cmd1 = new SQLiteCommand("SELECT Role, Predlozen FROM Roles ORDER BY Predlozen DESC", con);
            SQLiteDataReader rdr1 = cmd1.ExecuteReader();
            BindingSource source1 = new BindingSource();
            source1.DataSource = rdr1;
            dataGridView2.DataSource = source1;
            con.Close();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatMenu sm = new StatMenu();
            sm.Show();
            this.Close();
        }
        
    }
}
