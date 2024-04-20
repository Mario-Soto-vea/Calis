using System.Runtime.CompilerServices;

namespace Metodos;

public class Persona
{
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public int Edad { get; set; }

    public string MostrarNombre()
    {
        return $"{Nombres} {Apellidos}";
    }
    public string MostrarNombre(bool PrimeroApellidos)
    {
        if (PrimeroApellidos){
            return $"{Apellidos} {Nombres}";
        }
        else
            return MostrarNombre();
    }
    
    public string MostrarNombre(bool PrimeroApellidos, bool Mayusculas)
    {
        if (PrimeroApellidos && Mayusculas)
            return MostrarNombre(true).ToUpper();
        else if (PrimeroApellidos && !Mayusculas)
            return MostrarNombre(true).ToLower();
        else if (!PrimeroApellidos && Mayusculas)
            return MostrarNombre().ToUpper();
        else
            return MostrarNombre().ToLower();
    }
    override public string ToString(){
        return $"Nombre: {Nombres} Apellidos: {Apellidos} Edad: {Edad}";
    }
}