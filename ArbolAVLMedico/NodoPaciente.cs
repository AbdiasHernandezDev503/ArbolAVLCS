using System;

public class NodoPaciente
{
    public string Categoria { get; set; }   
    public List<NodoPaciente> Hijos { get; set; }

    public NodoPaciente(string categoria) {
        Categoria = categoria;
        Hijos = new List<NodoPaciente>();
    }   

    // Encontrar o agregar un nodo hijo
    public NodoPaciente ObtenerOHijoCrear(string categoria) {
        var hijo = Hijos.FirstOrDefault(n => n.Categoria == categoria);
        if (hijo == null)
        {
            hijo = new NodoPaciente(categoria);
            Hijos.Add(hijo);
        }
        return hijo;
    }
    
}
