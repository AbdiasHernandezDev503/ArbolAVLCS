using ArbolAVLMedico;

using System;
using System.Windows.Forms;

namespace ArbolAVLMedico
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar el formulario de login
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog(); // Modal: espera a que lo cierres

            // Si el login fue exitoso, lanza la app principal
            if (loginForm.Autenticado)
            {
                Application.Run(new Form1());
            }
            else
            {
                // Se cerró el login sin autenticar o con datos incorrectos
                MessageBox.Show("Acceso denegado. La aplicación se cerrará.");
                Application.Exit();
            }
        }
    }
}
