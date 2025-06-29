using System;
using System.Collections.Generic;

public class Vectores
{
    public static void CalcularProductoEscalar()
    {
        List<int> v1 = new List<int> { 1, 2, 3 };
        List<int> v2 = new List<int> { -1, 0, 2 };
        int producto = 0;

        for (int i = 0; i < v1.Count; i++)
        {
            producto += v1[i] * v2[i];
        }

        Console.WriteLine($"\nEl producto escalar de los vectores es: {producto}");
    }
}
