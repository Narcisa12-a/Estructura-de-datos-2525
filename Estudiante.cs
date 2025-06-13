using System;

public class Estudiante
{
    public int Id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Direccion { get; set; }
    public string[] Telefonos { get; set; }

    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        Id = id;
        Nombres = nombres;
        Apellidos = apellidos;
        Direccion = direccion;
        Telefonos = telefonos;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos:");
        foreach (string telefono in Telefonos)
        {
            Console.WriteLine($"- {telefono}");
        }
    }
}