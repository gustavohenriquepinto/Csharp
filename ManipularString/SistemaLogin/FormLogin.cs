﻿using System;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (UsuarioCadastro.Login(nome, senha))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Acesso negado.");

                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();

                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
