using System;

public class ArbolPaciente
{
    //Propiedad que representa la raíz del árbol
    public NodoPaciente Raiz {  get; set; }

    //Constructor sin parámetros que inicializa la raíz
	public ArbolPaciente()
	{
        Raiz = new NodoPaciente("Paciente");

        // Primer nivel: criterios
        var genero = Raiz.ObtenerOHijoCrear("Género");
        var sangre = Raiz.ObtenerOHijoCrear("Sangre");
        var presion = Raiz.ObtenerOHijoCrear("Presión");

        // Segundo nivel: valores posibles
        genero.ObtenerOHijoCrear("Hombre").ObtenerOHijoCrear("paciente1");
        genero.ObtenerOHijoCrear("Mujer").ObtenerOHijoCrear("paciente2");

        sangre.ObtenerOHijoCrear("A").ObtenerOHijoCrear("paciente3");
        sangre.ObtenerOHijoCrear("B").ObtenerOHijoCrear("paciente4");
        sangre.ObtenerOHijoCrear("AB").ObtenerOHijoCrear("paciente5");
        sangre.ObtenerOHijoCrear("O").ObtenerOHijoCrear("paciente6");

        presion.ObtenerOHijoCrear("Alta").ObtenerOHijoCrear("paciente7");
        presion.ObtenerOHijoCrear("Media").ObtenerOHijoCrear("paciente8");
        presion.ObtenerOHijoCrear("Baja").ObtenerOHijoCrear("paciente9");
    }

    // Método para agregar un paciente al árbol
    public void AgregarPaciente(Paciente paciente)
    {
        var nodoGenero = Raiz.ObtenerOHijoCrear(paciente.Genero);
        var nodoSangre = nodoGenero.ObtenerOHijoCrear(paciente.TipoSangre);
        var nodoPresion = nodoSangre.ObtenerOHijoCrear(paciente.Presion);
        nodoPresion.Hijos.Add(new NodoPaciente(paciente.Nombre));  // Agrega el paciente al último nivel
    }
}
