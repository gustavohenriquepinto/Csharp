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
            #region TryParse
            ////int num;
            ////bool res = int.TryParse("2004hjowrf", out num)

            //if (int.TryParse("2004", out int num))
            //{
            //    lblResultado.Text = num.ToString();
            //}
            //else
            //{
            //    lblResultado.Text = "Erro na conversão";

            #endregion

            #region ToString
            ////int num = 120;
            ////lblResultado.Text = num.ToString("00000.00");

            //int num = 14;
            //lblResultado.Text = num.ToString("X"); //Hexadecimal
            //lblResultado.Text = num.ToString("D"); //Decimal
            //lblResultado.Text = num.ToString("C"); //Monetário
            #endregion

            #region Classe Math

            double ctePi = Math.PI;
            double cteE = Math.E;
            double sen30 = Math.Sin(30);
            double cos30 = Math.Cos(30);
            double potencia = Math.Pow(2, 5);
            lblResultado.Text = ctePi.ToString("0.00");

            #endregion
        }
    }
}
