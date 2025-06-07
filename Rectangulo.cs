// Clase Rectangulo representa un rectángulo con base y altura
//Tiene metodos para calcular su área y perimetro
public class Rectangulo
{
    private double baseRectangulo;
    private double altura;
    // Constructor que recibe la base y altura
    public Rectangulo(double baseRectangulo, double altura)
    {
        this.baseRectangulo = baseRectangulo;
        this.altura = altura;
    }
    // Calcula el área del rectángulo
    public double CalcularArea()
    {
        return baseRectangulo * altura;
    }
    // Calcula el perímetro del rectángulo
    public double CalcularPerimetro()
    {
        return 2 * (baseRectangulo + altura);
    }
} 