﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroPicker
{
    public partial class Tank_2_1 : Form
    {
        public Tank_2_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rezultat r1 = new Rezultat(15);
            r1.Show();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Rezultat r1 = new Rezultat(19);
            r1.Show();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Rezultat r1 = new Rezultat(18);
            r1.Show();
            this.Close();
        }
    }
}
