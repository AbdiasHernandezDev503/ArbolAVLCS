using System;

public class ArbolPaciente
{
    //Propiedad que representa la raíz del árbol
    public NodoPaciente Raiz {  get; set; }

    //Constructor sin parámetros que inicializa la raíz
	public ArbolPaciente()
	{
        Raiz = new NodoPaciente();
	}
}
