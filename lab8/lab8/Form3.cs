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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 openform = new Form2();
            openform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 openform = new Form2();
            openform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 openform = new Form2();
            openform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 openform = new Form2();
            openform.Show();
        }
    }
}
