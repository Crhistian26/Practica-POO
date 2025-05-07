namespace Clases;

public class Estudiante : Persona
{
    public string Carrera { get; set; }
    public int Matricula { get; set; }

    public Estudiante(string nombre, string ciudad, int edad, string carrera, int matricula) : base(nombre, ciudad, edad)
    {
        Carrera = carrera;
        Matricula = matricula;
    }

    public void MostrarInformacionEstudiante()
    {
        Console.WriteLine($"Nombre: {Nombre}, Ciudad: {Ciudad}, Edad: {Edad}, Carrera: {Carrera}, Matricula: {Matricula}");
    }
}