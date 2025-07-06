using System;

namespace semana06
{
    public class Vehiculo
    {
        public string Placa;
        public string Marca;
        public string Modelo;
        public int Anio;
        public double Precio;
        public Vehiculo Siguiente;

        public Vehiculo(string placa, string marca, string modelo, int anio, double precio)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Precio = precio;
            Siguiente = null;
        }
    }

    public class Estacionamiento
    {
        private Vehiculo cabeza = null;

        public void AgregarVehiculo(string placa, string marca, string modelo, int anio, double precio)
        {
            Vehiculo nuevo = new Vehiculo(placa, marca, modelo, anio, precio);
            if (cabeza == null)
                cabeza = nuevo;
            else
            {
                Vehiculo actual = cabeza;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
            Console.WriteLine(" Vehículo agregado correctamente.");
        }

        public void BuscarPorPlaca(string placa)
        {
            Vehiculo actual = cabeza;
            while (actual != null)
            {
                if (actual.Placa == placa)
                {
                    Console.WriteLine($"Vehículo encontrado: {actual.Placa} | {actual.Marca} | {actual.Modelo} | {actual.Anio} | ${actual.Precio}");
                    return;
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine(" Vehículo no encontrado.");
        }

        public void VerPorAnio(int anio)
        {
            Vehiculo actual = cabeza;
            bool encontrado = false;
            while (actual != null)
            {
                if (actual.Anio == anio)
                {
                    Console.WriteLine($"{actual.Placa} | {actual.Marca} | {actual.Modelo} | {actual.Anio} | ${actual.Precio}");
                    encontrado = true;
                }
                actual = actual.Siguiente;
            }
            if (!encontrado)
                Console.WriteLine($"No hay vehículos del año {anio}.");
        }

        public void VerTodos()
        {
            if (cabeza == null)
            {
                Console.WriteLine("No hay vehículos registrados.");
                return;
            }

            Vehiculo actual = cabeza;
            while (actual != null)
            {
                Console.WriteLine($"{actual.Placa} | {actual.Marca} | {actual.Modelo} | {actual.Anio} | ${actual.Precio}");
                actual = actual.Siguiente;
            }
        }

        public void EliminarVehiculo(string placa)
        {
            Vehiculo actual = cabeza, anterior = null;

            while (actual != null)
            {
                if (actual.Placa == placa)
                {
                    if (anterior == null)
                        cabeza = actual.Siguiente;
                    else
                        anterior.Siguiente = actual.Siguiente;

                    Console.WriteLine("Vehículo eliminado.");
                    return;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }
            Console.WriteLine("Vehículo no encontrado.");
        }
    }
}
