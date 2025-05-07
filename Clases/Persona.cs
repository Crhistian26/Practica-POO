namespace Clases;

public class Persona
{
    public string Nombre { get; set; }
    public string Ciudad { get; set; }
    public int Edad { get; set; }

    public Persona(string nombre, string ciudad, int edad)
    {
        Nombre = nombre;
        Ciudad = ciudad;
        Edad = edad;
    }

    public void MostrarInformacionPersona()
    {
        Console.WriteLine($"Nombre: {Nombre}, Ciudad: {Ciudad}, Edad: {Edad}");
    }

    public void MostrarEdad()
    {
        Console.WriteLine($"Edad: {Edad}");
    }
}
