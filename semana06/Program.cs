using System;
using semana06;

namespace semana06
{
    class Program
    {
        static void Main()
        {
            int opcionPrincipal;

            do
            {
                Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
                Console.WriteLine("1. Ir al módulo de Estacionamiento");
                Console.WriteLine("2. Ir al módulo de Datos");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                opcionPrincipal = int.Parse(Console.ReadLine());

                switch (opcionPrincipal)
                {
                    case 1:
                        EjecutarEstacionamiento();
                        break;
                    case 2:
                        EjecutarDatos();
                        break;
                    case 3:
                        Console.WriteLine(" Gracias por usar el sistema.");
                        break;
                    default:
                        Console.WriteLine(" Opción inválida.");
                        break;
                }

            } while (opcionPrincipal != 3);
        }

        static void EjecutarEstacionamiento()
        {
            Estacionamiento estacionamiento = new Estacionamiento();
            int opcion;

            do
            {
                Console.WriteLine("\n--- MÓDULO ESTACIONAMIENTO ---");
                Console.WriteLine("1. Agregar vehículo");
                Console.WriteLine("2. Buscar vehículo por placa");
                Console.WriteLine("3. Ver vehículos por año");
                Console.WriteLine("4. Ver todos los vehículos");
                Console.WriteLine("5. Eliminar vehículo");
                Console.WriteLine("6. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Placa: ");
                        string placa = Console.ReadLine();
                        Console.Write("Marca: ");
                        string marca = Console.ReadLine();
                        Console.Write("Modelo: ");
                        string modelo = Console.ReadLine();
                        Console.Write("Año: ");
                        int anio = int.Parse(Console.ReadLine());
                        Console.Write("Precio: ");
                        double precio = double.Parse(Console.ReadLine());
                        estacionamiento.AgregarVehiculo(placa, marca, modelo, anio, precio);
                        break;

                    case 2:
                        Console.Write("Ingrese la placa: ");
                        estacionamiento.BuscarPorPlaca(Console.ReadLine());
                        break;

                    case 3:
                        Console.Write("Ingrese el año: ");
                        estacionamiento.VerPorAnio(int.Parse(Console.ReadLine()));
                        break;

                    case 4:
                        estacionamiento.VerTodos();
                        break;

                    case 5:
                        Console.Write("Ingrese la placa a eliminar: ");
                        estacionamiento.EliminarVehiculo(Console.ReadLine());
                        break;

                    case 6:
                        Console.WriteLine(" Volviendo al menú principal...");
                        break;

                    default:
                        Console.WriteLine(" Opción inválida.");
                        break;
                }

            } while (opcion != 6);
        }

        static void EjecutarDatos()
        {
            Datos datos = new Datos();
            int opcion;

            do
            {
                Console.WriteLine("\n--- MÓDULO DATOS ---");
                Console.WriteLine("1. Cargar datos reales");
                Console.WriteLine("2. Calcular promedio y separar");
                Console.WriteLine("3. Mostrar resultados");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        datos.CargarDatos();
                        break;

                    case 2:
                        datos.CalcularPromedioYSeparar();
                        break;

                    case 3:
                        datos.MostrarResultados();
                        break;

                    case 4:
                        Console.WriteLine(" Volviendo al menú principal...");
                        break;

                    default:
                        Console.WriteLine(" Opción inválida.");
                        break;
                }

            } while (opcion != 4);
        }
    }
}
