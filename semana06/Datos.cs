using System;
using System.Collections.Generic;

namespace semana06
{
    public class Datos
    {
        private List<double> listaPrincipal = new List<double>();
        private List<double> menoresIgual = new List<double>();
        private List<double> mayores = new List<double>();
        private double promedio;

        public void CargarDatos()
        {
            Console.Write("¿Cuántos datos desea ingresar?: ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese el dato #{i + 1}: ");
                double valor = double.Parse(Console.ReadLine());
                listaPrincipal.Add(valor);
            }
        }

        public void CalcularPromedioYSeparar()
        {
            double suma = 0;
            foreach (double d in listaPrincipal)
                suma += d;

            promedio = suma / listaPrincipal.Count;

            foreach (double d in listaPrincipal)
            {
                if (d <= promedio)
                    menoresIgual.Add(d);
                else
                    mayores.Add(d);
            }
        }

        public void MostrarResultados()
        {
            Console.WriteLine("\n Lista de datos ingresados:");
            foreach (var d in listaPrincipal)
                Console.Write(d + " ");

            Console.WriteLine($"\n Promedio: {promedio:F2}");

            Console.WriteLine(" Datos menores o iguales al promedio:");
            foreach (var d in menoresIgual)
                Console.Write(d + " ");

            Console.WriteLine("\nDatos mayores al promedio:");
            foreach (var d in mayores)
                Console.Write(d + " ");
        }
    }
}

