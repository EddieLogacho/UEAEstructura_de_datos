using System;
using System.Collections.Generic;

namespace CatalogoRevistas
{
    class Program
    {
        // Método principal de la aplicación
        static void Main(string[] args)
        {
            // Lista de revistas populares (reemplazadas)
            List<string> catalogo = new List<string>
            {
                "Chasqui",     // Reemplaza a "chasqui"
                "Tinta",                    // Reemplaza a "Tinta"
                "Forbes",     // Reemplaza a "Forbes"
                "Revista UTE",                  // Reemplaza a "Turkuge UTC"
                "la Granja",         // Reemplaza a "La Granja"
                "Revista Politecnica",           // Reemplaza a "Revista Politécnica"
                "Wired",                   // Reemplaza a "wired"
                "Estados & comunes",           // Reemplaza a "estado & comunes"
                "Reader's Digest",
                "Smithsonian"
            };

            int opcion;

            // Menú interactivo
            do
            {
                Console.WriteLine("=== Catálogo de Revistas ===");
                Console.WriteLine("1. Buscar título de revista");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el título de la revista a buscar: ");
                        string titulo = Console.ReadLine();

                        // Búsqueda iterativa
                        bool encontrado = false;
                        foreach (string revista in catalogo)
                        {
                            if (revista.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                            {
                                encontrado = true;
                                break;
                            }
                        }

                        // Mostrar resultado
                        if (encontrado)
                            Console.WriteLine("Resultado: Encontrado");
                        else
                            Console.WriteLine("Resultado: No encontrado");
                        break;

                    case 2:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine(); // Espacio entre iteraciones
            }
            while (opcion != 2);
        }
    }
}
