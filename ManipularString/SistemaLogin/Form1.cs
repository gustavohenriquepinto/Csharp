using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();

            while (UsuarioCadastro.UsuarioLogado == null)
            {
                Visible = false;

                login.ShowDialog();

                if(FormLogin.Cancelar)
                {
                    Application.Exit();
                    return;
                }
            }

            labelBoasVindas.Text = $"Bem vindo, {UsuarioCadastro.UsuarioLogado.Nome}!";
            Visible = true;
        }
    }
}
