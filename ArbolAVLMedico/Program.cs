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

            //Application.Run(new Form1());

            // Mostrar el formulario de login
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            // Si el login fue exitoso, lanza la app principal
            if (loginForm.Autenticado)
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Acceso denegado. La aplicación se cerrará.");
               Application.Exit();
            }
        }
    }
}
