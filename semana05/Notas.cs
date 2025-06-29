using System;
using System.Collections.Generic;

public class Notas
{
    public static void IngresarYMostrarNotas()
    {
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
        Dictionary<string, string> notas = new Dictionary<string, string>();

        foreach (string asignatura in asignaturas)
        {
            Console.Write($"¿Qué nota sacaste en {asignatura}? ");
            string nota = Console.ReadLine();
            notas[asignatura] = nota;
        }

        Console.WriteLine("\nResumen de notas:");
        foreach (var item in notas)
        {
            Console.WriteLine($"En {item.Key} has sacado {item.Value}");
        }
    }
}
