﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 openform = new Form3();
            openform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 openform = new Form4();
            openform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 openform = new Form5();
            openform.Show();
        }
    }
}
