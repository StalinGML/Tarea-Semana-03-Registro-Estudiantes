// Programa principal que gestiona el registro de un estudiante
// Captura datos básicos y guarda los teléfonos en un array.
// Elaborado por: Mendieta Stalin

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Registro de Estudiante ===");

        // Solicitar datos al usuario
        Console.Write("Ingrese el ID del estudiante: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Ingrese los nombres: ");
        string nombres = Console.ReadLine();

        Console.Write("Ingrese los apellidos: ");
        string apellidos = Console.ReadLine();

        Console.Write("Ingrese la dirección: ");
        string direccion = Console.ReadLine();

        // Declaración del arreglo para teléfonos
        string[] telefonos = new string[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Ingrese el teléfono {i + 1}: ");
            telefonos[i] = Console.ReadLine();
        }

        // Creación del objeto estudiante
        Estudiante estudiante = new Estudiante(id, nombres, apellidos, direccion, telefonos);

        // Mostrar resultados
        estudiante.MostrarDatos();
        Console.WriteLine("\nPresiona una tecla para salir...");
        Console.ReadKey();
    }
}