namespace Clases;

public class Rectangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    /// <summary>
    /// Constructor de la clase Rectangulo
    /// </summary>
    /// <param name="base">La base del rectángulo</param>
    /// <param name="altura">La altura del rectángulo</param>
    public Rectangulo(double Base, double altura)
    {
        this.Base = Base;
        Altura = altura;
    }

    /// <summary>
    /// Calcula el área de un rectángulo utilizando la fórmula: base * altura
    /// </summary>
    /// <returns>El valor del area</returns>
    public override double CalcularArea()
    {
        return Base * Altura;
    }
}