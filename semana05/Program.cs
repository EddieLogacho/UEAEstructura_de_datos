using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n===== UNIVERSIDAD ESTATAL AMAZONICA =====");
            Console.WriteLine("1. Mostrar asignaturas");
            Console.WriteLine("2. Ingresar y mostrar notas");
            Console.WriteLine("3. Números ganadores de la lotería");
            Console.WriteLine("4. Números del 1 al 10 en orden inverso");
            Console.WriteLine("5. Producto escalar de vectores");
            Console.Write("Elige una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Entrada inválida.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Asignatura.MostrarAsignaturas();
                    break;
                case 2:
                    Notas.IngresarYMostrarNotas();
                    break;
                case 3:
                    Loteria.PedirYMostrarNumeros();
                    break;
                case 4:
                    Numeros.MostrarInverso();
                    break;
                case 5:
                    Vectores.CalcularProductoEscalar();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 0);
    }
}
