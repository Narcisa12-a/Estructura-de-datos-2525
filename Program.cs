using System;

class Program
{
    static void Main(string[] args)
    {
        // Creamos un array de 3 teléfonos
        string[] telefonos = new string[3] { "0939216573", "0993636420", "0935121635" };

        // Creamos un objeto Estudiante con sus datos
        Estudiante estudiante = new Estudiante(
            1,
            "Narcisa Lilibeth",
            "Arreaga Salazar",
            "Cantón Colimes, Provincia del Guayas",
            telefonos
        );

        // Mostramos la información del estudiante
        estudiante.MostrarInformacion();
    }
}
