using System;
using System.Collections.Generic;

public class Numeros
{
    public static void MostrarInverso()
    {
        List<int> numeros = new List<int>();

        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        numeros.Reverse();
        Console.WriteLine("\nNúmeros en orden inverso:");
        Console.WriteLine(string.Join(", ", numeros));
    }
}
