using System;

public class ArbolPaciente
{
    //Propiedad que representa la raíz del árbol
    public NodoPaciente Raiz {  get; set; }

    //Constructor sin parámetros que inicializa la raíz
	public ArbolPaciente()
	{
        Raiz = new NodoPaciente("Paciente");
    }

    // Método para agregar un paciente al árbol
    public void AgregarPaciente(Paciente paciente)
    {
        // Ramas principales: Género, Sangre, Presión
        var nodoGenero = Raiz.ObtenerOHijoCrear("Género").ObtenerOHijoCrear(paciente.Genero);
        nodoGenero.ObtenerOHijoCrear(paciente.Nombre);

        var nodoSangre = Raiz.ObtenerOHijoCrear("Sangre").ObtenerOHijoCrear(paciente.TipoSangre);
        nodoSangre.ObtenerOHijoCrear(paciente.Nombre);

        var nodoPresion = Raiz.ObtenerOHijoCrear("Presión").ObtenerOHijoCrear(paciente.Presion);
        nodoPresion.ObtenerOHijoCrear(paciente.Nombre);
    }
}
