using System.CodeDom.Compiler;

public class Paciente

{
    public string Nombre { get; set; }
    public string Genero { get; set; }
    public string TipoSangre { get; set; }
    public string Presion { get; set; }


    public Paciente(string nombre, string genero, string tipoSangre, string presion) 
    {
        Nombre = nombre;
        Genero = genero;
        TipoSangre = tipoSangre;
        Presion = presion;  

    }
}



