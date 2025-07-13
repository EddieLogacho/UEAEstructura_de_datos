using System;
using System.Collections.Generic;

// Clase que contiene la lógica para resolver el problema de las Torres de Hanoi usando pilas
public class JuegoHanoi
{
    private Stack<int> origen = new Stack<int>();
    private Stack<int> auxiliar = new Stack<int>();
    private Stack<int> destino = new Stack<int>();

    // Constructor: inicializa la torre de origen con los discos
    public JuegoHanoi(int numeroDeDiscos)
    {
        for (int i = numeroDeDiscos; i >= 1; i--)
        {
            origen.Push(i);
        }
    }

    // Método principal que inicia la resolución del problema
    public void Resolver()
    {
        Console.WriteLine("Estado inicial:");
        MostrarTorres();
        MoverDiscos(origen.Count, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
    }

    // Método recursivo que realiza los movimientos entre torres
    private void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
            MostrarTorres();
        }
        else
        {
            MoverDiscos(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);
            MoverDiscos(1, origen, destino, auxiliar, nombreOrigen, nombreDestino, nombreAuxiliar);
            MoverDiscos(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
        }
    }

    // Muestra las tres torres
    private void MostrarTorres()
    {
        MostrarTorre(origen, "Origen");
        MostrarTorre(auxiliar, "Auxiliar");
        MostrarTorre(destino, "Destino");
        Console.WriteLine("************************");
    }

    // Muestra el contenido de una torre específica
    private void MostrarTorre(Stack<int> torre, string nombre)
    {
        Console.Write(nombre + ": ");
        foreach (int disco in torre)
        {
            Console.Write(disco + " ");
        }
        Console.WriteLine();
    }
}
