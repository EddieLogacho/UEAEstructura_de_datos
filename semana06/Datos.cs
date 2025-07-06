using System;

namespace semana06
{
    public class NodoDato
    {
        public double Valor;
        public NodoDato Siguiente;

        public NodoDato(double valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

    public class Datos
    {
        private NodoDato cabezaPrincipal;
        private NodoDato cabezaMenoresIgual;
        private NodoDato cabezaMayores;
        private double promedio;

        public void CargarDatos()
        {
            Console.Write("¿Cuántos datos desea ingresar?: ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese el dato #{i + 1}: ");
                double valor = double.Parse(Console.ReadLine());
                AgregarDato(valor);
            }
        }

        private void AgregarDato(double valor)
        {
            NodoDato nuevo = new NodoDato(valor);
            if (cabezaPrincipal == null)
            {
                cabezaPrincipal = nuevo;
            }
            else
            {
                NodoDato actual = cabezaPrincipal;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }

        public void CalcularPromedioYSeparar()
        {
            double suma = 0;
            int contador = 0;

            NodoDato actual = cabezaPrincipal;
            while (actual != null)
            {
                suma += actual.Valor;
                contador++;
                actual = actual.Siguiente;
            }

            if (contador == 0)
            {
                Console.WriteLine("No hay datos para calcular el promedio.");
                return;
            }

            promedio = suma / contador;

            actual = cabezaPrincipal;
            while (actual != null)
            {
                if (actual.Valor <= promedio)
                    AgregarMenorIgual(actual.Valor);
                else
                    AgregarMayor(actual.Valor);
                actual = actual.Siguiente;
            }
        }

        private void AgregarMenorIgual(double valor)
        {
            NodoDato nuevo = new NodoDato(valor);
            if (cabezaMenoresIgual == null)
                cabezaMenoresIgual = nuevo;
            else
            {
                NodoDato actual = cabezaMenoresIgual;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }

        private void AgregarMayor(double valor)
        {
            NodoDato nuevo = new NodoDato(valor);
            if (cabezaMayores == null)
                cabezaMayores = nuevo;
            else
            {
                NodoDato actual = cabezaMayores;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }

        public void MostrarResultados()
        {
            Console.WriteLine("\n Lista principal:");
            MostrarLista(cabezaPrincipal);

            Console.WriteLine($"\n Promedio: {promedio:F2}");

            Console.WriteLine("Datos menores o iguales al promedio:");
            MostrarLista(cabezaMenoresIgual);

            Console.WriteLine(" Datos mayores al promedio:");
            MostrarLista(cabezaMayores);
        }

        private void MostrarLista(NodoDato cabeza)
        {
            if (cabeza == null)
            {
                Console.WriteLine("(vacía)");
                return;
            }

            NodoDato actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }
    }
}
