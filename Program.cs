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


