using System;

public class NodoPaciente
{
	public NodoPaciente Raiz{ get; set; }

    public NodoPaciente()
    {
        Raiz = new NodoPaciente();
    }
}
