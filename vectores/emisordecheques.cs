﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vectores
{
    public partial class emisordecheques : Form
    {
        public emisordecheques()
        {
            InitializeComponent();
        }

        private void emisordecheques_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UTILS.numerosficheros.testUnidades();
            int num = Int32.Parse(this.txtpagueselaordende.Text);
            this.txtResultado.Text = UTILS.numerosficheros.getDecenas(num);
        }
    }
}
