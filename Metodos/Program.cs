using Metodos;

var persona1 = new Persona{
    Nombres = "Mario",
    Apellidos = "Soto Vea",
    Edad = 19
};

var persona2 = new Persona{
    Nombres = "Carlos",
    Apellidos = "Perez Barraza",
    Edad = 67
};


// imprimir el nombre completo del alumno iniciando con el nombre
Console.WriteLine(persona1.MostrarNombre());
// imprimir el nombre completo del alumno iniciando por apellidos
Console.WriteLine(persona1.MostrarNombre(true));
// imprimir el nombre completo del alumno iniciando con apellidos y en minusculas
Console.WriteLine(persona1.MostrarNombre(true,false));
// imprimir el nombre completo del alumno iniciando con apellidos y en mayusculas
Console.WriteLine(persona1.MostrarNombre(true,true));
// imprimir el nombre completo del alumno iniciando con nombre y en mayusculas
Console.WriteLine(persona1.MostrarNombre(false,true));
// imprimir el nombre completo del alumno iniciando con nombre y en minusculas
Console.WriteLine(persona1.MostrarNombre(false,false));
// imprimir lo que salga del método ToString() del alumno
Console.WriteLine(persona1.ToString());
Console.WriteLine(persona2.ToString());