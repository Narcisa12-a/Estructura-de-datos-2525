using System;
// Este programa define dos clases: Circulo y Rectangulo
// Ambas encapsulan sus datos y tienen métodos para calcular área y perímetro
class Program
{
    static void Main(string[] args)
    {
        // Creamos un círculo con radio 5
        Circulo miCirculo = new Circulo(5);
        // Creamos un rectángulo con base 4 y altura 6
        Rectangulo miRectangulo = new Rectangulo(4, 6);
        Console.WriteLine("Círculo:");
        Console.WriteLine("Área: " + miCirculo.CalcularArea());
        Console.WriteLine("Perímetro: " + miCirculo.CalcularPerimetro());

        Console.WriteLine("\nRectángulo:");
        Console.WriteLine("Área: " + miRectangulo.CalcularArea());
        Console.WriteLine("Perímetro: " + miRectangulo.CalcularPerimetro());
    }
}
// Clase Circulo representa un círculo con un radio
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
// Clase Rectangulo representa un rectángulo con base y altura
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