﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroducaoWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Size tamanho = new Size();
            //tamanho.Width = 400;
            //tamanho.Height = 700;

            InitializeComponent();
            this.Text = "Texto alterado pelo código Fonte!";
            this.Size = new Size(400, 700);
            this.ControlBox = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
