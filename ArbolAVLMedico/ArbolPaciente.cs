using System;

public class ArbolPaciente
{
    //Propiedad que representa la raíz del árbol
    public NodoPaciente Raiz {  get; set; }

    //Constructor sin parámetros que inicializa la raíz
	public ArbolPaciente()
	{
        Raiz = new NodoPaciente("Paciente");

        Raiz.ObtenerOHijoCrear("Género");
        Raiz.ObtenerOHijoCrear("Sangre");
        Raiz.ObtenerOHijoCrear("Presión");
    }

    // Método para agregar un paciente al árbol
    public void AgregarPaciente(Paciente paciente)
    {
        // Verificar si ya existe un paciente, en caso que exista deja de ejecutarse el metodo
        if (Raiz.ExistePaciente(paciente.Nombre))
            return;

        // Si no existe, se agrega al árbol
        var nodoGenero = Raiz.ObtenerOHijoCrear("Género").ObtenerOHijoCrear(paciente.Genero);
        nodoGenero.ObtenerOHijoCrear(paciente.Nombre);

        var nodoSangre = Raiz.ObtenerOHijoCrear("Sangre").ObtenerOHijoCrear(paciente.TipoSangre);
        nodoSangre.ObtenerOHijoCrear(paciente.Nombre);

        var nodoPresion = Raiz.ObtenerOHijoCrear("Presión").ObtenerOHijoCrear(paciente.Presion);
        nodoPresion.ObtenerOHijoCrear(paciente.Nombre);
    }
}
