﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projekat_PPJ
{
    public partial class Ucitavanje : Form
    {
        public Ucitavanje()
        {
            InitializeComponent();
        }
        int pocetak = 0;

        private void Ucitavanje_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pocetak += 2;
            labelProcenat.Text = progressBar1.Value.ToString() +" %";
            progressBar1.Value = pocetak;

            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();

                Form1 fr1 = new Form1();
                fr1.Show();
                this.Hide();

            }

        }
    }
}