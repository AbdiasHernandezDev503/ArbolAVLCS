using System;

public class Usuario
{
    public string NombreUsuario { get; set; }
    public string Contraseña { get; set; }

	public Usuario(string nombreUsuario, string contraseña)
	{
        NombreUsuario = nombreUsuario;
        Contraseña = contraseña;
	}

    public bool ValidarCredenciales(string usuario, string contraseña)
    {
        return NombreUsuario == usuario && Contraseña == contraseña;
    }
}
