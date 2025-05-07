namespace Clases;

public class Circulo : Figura
{
    public double Radio { get; set; }

    /// <summary>
    /// Constructor de la clase Circulo
    /// </summary>
    /// <param name="radio">El radio del circulo</param>
    public Circulo(double radio)
    {
        Radio = radio;
    }

    /// <summary>
    /// Calcula el área de un círculo utilizando la fórmula: π * radio^2
    /// </summary>
    /// <returns>El valor del area</returns>
    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }
}