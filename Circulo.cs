// Clase Circulo representa un círculo con un radio
//Tiene metodos para calcular su área y perimetro
public class Circulo
{
    private double radio;
    // Constructor que recibe el radio
    public Circulo(double radio)
    {
        this.radio = radio;
    }
    // Calcula el área del círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }
    // Calcula el perímetro del círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}