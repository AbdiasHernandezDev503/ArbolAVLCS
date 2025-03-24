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

    // Verificar si ya existe un paciente para evitar duplicados
    public bool ExistePaciente(string nombre)
    {
        if (Categoria.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            return true;

        foreach (var hijo in Hijos)
        {
            if (hijo.ExistePaciente(nombre))
                return true;
        }

        return false;
    }

    public NodoPaciente BuscarPaciente(string nombre)
    {
        if (this.Categoria.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            return this;

        foreach (var hijo in Hijos)
        {
            var encontrado = hijo.BuscarPaciente(nombre);
            if (encontrado != null)
                return encontrado;
        }

        return null;
    }


}
