﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolAVLMedico
{
    public partial class LoginForm : Form
    {
        private Usuario usuarioValido;
        public bool Autenticado { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            //Permite dar enter después de escribir las credenciales
            this.AcceptButton = btnLogin;

            //Usuario por defecto
            usuarioValido = new Usuario("admin", "1234");
            Autenticado = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {       
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (usuarioValido.ValidarCredenciales(usuario, contraseña))
            {
                Autenticado = true;
                this.Close(); // Cierra el login y continua
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }

        }
    }
}
