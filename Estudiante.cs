// Clase Estudiante: almacena los datos personales de un estudiante
public class Estudiante
{
    // Propiedades para almacenar la información básica del estudiante
    public int ID { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Direccion { get; set; }

    // Array para almacenar los tres números de teléfono
    public string[] Telefonos { get; set; }

    // Constructor de la clase
    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        ID = id;
        Nombres = nombres;
        Apellidos = apellidos;
        Direccion = direccion;
        Telefonos = telefonos;
    }

    // Método para mostrar los datos registrados
    public void MostrarDatos()
    {
        Console.WriteLine("\n--- Datos del Estudiante ---");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos registrados:");
        
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"Teléfono {i + 1}: {Telefonos[i]}");
        }
    }
}