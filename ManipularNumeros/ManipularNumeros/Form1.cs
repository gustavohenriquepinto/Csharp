using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //int num;
            //bool res = int.TryParse("2004hjowrf", out num)

            if (int.TryParse("2004", out int num))
            {
                lblResultado.Text = num.ToString();
            }
            else
            {
                lblResultado.Text = "Erro na conversão";
            }
        }
    }
}
