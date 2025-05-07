using Clases;

namespace Practica_POO;

class Program
{
    static void Main(string[] args)
    {
        Persona Pedro = new Persona("Pedro", "Madrid", 20);
        Estudiante Juan = new Estudiante("Juan", "Barcelona", 22, "Ingeniería", 12345);

        Pedro.MostrarInformacionPersona();
        Pedro.MostrarEdad();
            Console.WriteLine("");

        Juan.MostrarInformacionEstudiante();
        Juan.MostrarInformacionPersona();
        Juan.MostrarEdad();

            Console.WriteLine("");
        Console.WriteLine("Parte de figuras");

        Triangulo triangulo = new Triangulo(5, 10);
        Console.WriteLine($"El área del triángulo es: {triangulo.CalcularArea()}");

        Rectangulo rectangulo = new Rectangulo(5, 10);
        Console.WriteLine($"El área del rectángulo es: {rectangulo.CalcularArea()}");

        Circulo circulo = new Circulo(5);
        Console.WriteLine($"El área del círculo es: {circulo.CalcularArea()}");

        Console.ReadKey();

    }
}
