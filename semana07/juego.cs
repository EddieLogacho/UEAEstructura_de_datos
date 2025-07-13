using System;
using System.Collections.Generic;

// Clase que contiene la lógica para resolver el problema de las Torres de Hanoi usando pilas
public class JuegoHanoi
{
    // Se crean tres pilas para representar las torres
    private Stack<int> origen = new Stack<int>();
    private Stack<int> auxiliar = new Stack<int>();
    private Stack<int> destino = new Stack<int>();

    // Constructor que inicializa la torre de origen con los discos (del más grande al más pequeño)
    public JuegoHanoi(int numeroDeDiscos)
    {
        for (int i = numeroDeDiscos; i >= 1; i--)
        {
            origen.Push(i); // Agrega los discos a la torre de origen
        }
    }

    // Método principal que inicia la resolución y muestra los pasos
    public void Resolver()
    {
        Console.WriteLine("Estado inicial:");
        MostrarTorres(); // Muestra cómo están las torres al inicio

        // Inicia el proceso recursivo de mover discos
        MoverDiscos(
            origen.Count,      // Número total de discos
            origen,            // Torre de origen
            destino,           // Torre destino
            auxiliar,          // Torre auxiliar
            "Origen",          // Nombre de la torre de origen (para mostrar)
            "Destino",         // Nombre de la torre destino (para mostrar)
            "Auxiliar"         // Nombre de la torre auxiliar (para mostrar)
        );
    }

    // Método recursivo que mueve los discos entre torres siguiendo las reglas del juego
    private void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            // Caso base: mover un solo disco
            int disco = origen.Pop();       // Saca el disco de la torre de origen
            destino.Push(disco);            // Lo coloca en la torre destino
            Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
            MostrarTorres();                // Muestra el estado actual de las torres
        }
        else
        {
            // Paso 1: mover n-1 discos a la torre auxiliar
            MoverDiscos(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);

            // Paso 2: mover el disco restante al destino
            MoverDiscos(1, origen, destino, auxiliar, nombreOrigen, nombreDestino, nombreAuxiliar);

            // Paso 3: mover los n-1 discos de la auxiliar al destino
            MoverDiscos(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
        }
    }

    // Muestra el contenido de todas las torres
    private void MostrarTorres()
    {
        MostrarTorre(origen, "Origen");
        MostrarTorre(auxiliar, "Auxiliar");
        MostrarTorre(destino, "Destino");
        Console.WriteLine("------------------------------");
    }

    // Muestra una sola torre con su nombre
    private void MostrarTorre(Stack<int> torre, string nombre)
    {
        Console.Write(nombre + ": ");
        foreach (int disco in torre)
        {
            Console.Write(disco + " "); // Imprime todos los discos de la pila
        }
        Console.WriteLine();
    }
}
