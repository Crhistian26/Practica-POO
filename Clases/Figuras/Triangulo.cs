namespace Clases;
public class Triangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    /// <summary>
    /// Constructor de la clase Triangulo
    /// </summary>
    /// <param name="baseTriangulo">La base del triangulo</param>
    /// <param name="alturaTriangulo">La altura del triangulo</param>
    public Triangulo(double baseTriangulo, double alturaTriangulo)
    {
        Base = baseTriangulo;
        Altura = alturaTriangulo;
    }

    /// <summary>
    /// Calcula el área de un triángulo utilizando la fórmula: (base * altura) / 2
    /// </summary>
    /// <returns>El valor del area</returns>
    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }
}