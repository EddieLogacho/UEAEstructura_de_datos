using System;
using System.Collections.Generic;

public class Asignatura
{
    public static void MostrarAsignaturas()
    {
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        Console.WriteLine("\nAsignaturas del curso:");
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }
}
