using System;
using System.Collections.Generic;

public class Loteria
{
    public static void PedirYMostrarNumeros()
    {
        List<int> numeros = new List<int>();
        Console.WriteLine("\nIngresa 6 números ganadores:");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Número {i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            numeros.Add(num);
        }

        numeros.Sort();
        Console.WriteLine("\nNúmeros ordenados:");
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }
    }
}
