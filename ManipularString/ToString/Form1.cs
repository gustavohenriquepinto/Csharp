using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string texto = "Este tipo de variável é alfanumérica";

            //if (texto.Contains("tipo"))
            //{
            //    txt1.Text = "Contém.";
            //}
            //else
            //{
            //    txt1.Text = "Não Contém.";
            //}

            int num = 5400;
            txt1.Text = num.ToString();
        }
    }
}
