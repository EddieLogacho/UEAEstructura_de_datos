using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random random = new Random();

        // Conjunto ficticio de 500 ciudadanos
        HashSet<string> conjuntoU = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            conjuntoU.Add("Ciudadano " + i);
        }

        // Crear conjunto ficticio de 75 vacunados con Pfizer
        HashSet<string> conjuntoA = GenerarVacunados("Ciudadano ", 75, 500, random);

        // Crear conjunto ficticio de 75 vacunados con AstraZeneca
        HashSet<string> conjuntoB = GenerarVacunados("Ciudadano ", 75, 500, random);

        // Operaciones de conjuntos

        // No vacunados
        HashSet<string> noVacunados = new HashSet<string>(conjuntoU);
        noVacunados.ExceptWith(conjuntoA);
        noVacunados.ExceptWith(conjuntoB);

        // Ambas dosis
        HashSet<string> ambasDosis = new HashSet<string>(conjuntoA);
        ambasDosis.IntersectWith(conjuntoB);

        // Solo Pfizer
        HashSet<string> soloPfizer = new HashSet<string>(conjuntoA);
        soloPfizer.ExceptWith(conjuntoB);

        // Solo AstraZeneca
        HashSet<string> soloAstra = new HashSet<string>(conjuntoB);
        soloAstra.ExceptWith(conjuntoA);

        //el Resultados
        Console.WriteLine("==== Campaña de Vacunación COVID-19 ====");
        Console.WriteLine("Total ciudadanos: " + conjuntoU.Count);
        Console.WriteLine("Vacunados con Pfizer: " + conjuntoA.Count);
        Console.WriteLine("Vacunados con AstraZeneca: " + conjuntoB.Count);
        Console.WriteLine("No vacunados: " + noVacunados.Count);
        Console.WriteLine("Ambas dosis: " + ambasDosis.Count);
        Console.WriteLine("Solo Pfizer: " + soloPfizer.Count);
        Console.WriteLine("Solo AstraZeneca: " + soloAstra.Count);

        // Mostrar listados
        Console.WriteLine("\n-- No vacunados --");
        foreach (var e in noVacunados) Console.WriteLine(e);

        Console.WriteLine("\n-- Ambas dosis --");
        foreach (var e in ambasDosis) Console.WriteLine(e);

        Console.WriteLine("\n-- Solo Pfizer --");
        foreach (var e in soloPfizer) Console.WriteLine(e);

        Console.WriteLine("\n-- Solo AstraZeneca --");
        foreach (var e in soloAstra) Console.WriteLine(e);
    }

    static HashSet<string> GenerarVacunados(string prefijo, int cantidad, int maxCiudadanos, Random random)
    {
        HashSet<string> vacunados = new HashSet<string>();
        while (vacunados.Count < cantidad)
        {
            int numero = random.Next(1, maxCiudadanos + 1);
            vacunados.Add(prefijo + numero);
        }
        return vacunados;
    }
}

