using System;

namespace EstudianteRegistro
{
    class Program
    {
        static Persona[] estudiantes = new Persona[100];
        static int contador = 0;

        static void Main(string[] args)
        {
            bool salir = false;
            
            while (!salir)
            {
                Console.WriteLine("\nREGISTRO DE ESTUDIANTES");
                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Mostrar todos los estudiantes");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione: ");
                
                switch (Console.ReadLine())
                {
                    case "1":
                        AgregarEstudiante();
                        break;
                    case "2":
                        MostrarEstudiantes();
                        break;
                    case "3":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
        }

        static void AgregarEstudiante()
        {
            Console.Write("\nID: ");
            int id = int.Parse(Console.ReadLine() ?? "0");
            
            Console.Write("Nombres: ");
            string nombres = Console.ReadLine() ?? "";
            
            Console.Write("Apellidos: ");
            string apellidos = Console.ReadLine() ?? "";
            
            Console.Write("Dirección: ");
            string direccion = Console.ReadLine() ?? "";

            Persona nuevo = new Persona(id, nombres, apellidos, direccion);
            
            // Registrar 3 teléfonos
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Tipo teléfono {i+1} (Ej: Móvil, Casa): ");
                string tipo = Console.ReadLine() ?? "";
                
                Console.Write($"Número {i+1}: ");
                string numero = Console.ReadLine() ?? "";
                
                nuevo.Telefonos[i] = new Dato(tipo, numero);
            }

            estudiantes[contador] = nuevo;
            contador++;
            Console.WriteLine("\n¡Estudiante registrado!");
        }

        static void MostrarEstudiantes()
        {
            Console.WriteLine("\nLISTA DE ESTUDIANTES");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"\nID: {estudiantes[i].Id}");
                Console.WriteLine($"Nombre: {estudiantes[i].Nombres} {estudiantes[i].Apellidos}");
                Console.WriteLine($"Dirección: {estudiantes[i].Direccion}");
                
                Console.WriteLine("Teléfonos:");
                foreach (var tel in estudiantes[i].Telefonos)
                {
                    Console.WriteLine($"- {tel.Tipo}: {tel.Numero}");
                }
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}