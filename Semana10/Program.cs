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

        // Creacion conjunto ficticio de 75 vacunados con Pfizer
        HashSet<string> conjuntoPfizer = GenerarVacunados("Ciudadano ", 75, 500, random);

        // Crear conjunto ficticio de 75 vacunados con AstraZeneca
        HashSet<string> conjuntoAstra = GenerarVacunados("Ciudadano ", 75, 500, random);

        // ===============================
        // OPERACIONES DE TEORÍA DE CONJUNTOS
        // ===============================

        // UNIÓN: ciudadanos que han recibido al menos una dosis
        HashSet<string> vacunados = new HashSet<string>(conjuntoPfizer);
        vacunados.UnionWith(conjuntoAstra); // <-- UNIÓN

        // INTERSECCIÓN: ciudadanos que han recibido ambas dosis
        HashSet<string> ambasDosis = new HashSet<string>(conjuntoPfizer);
        ambasDosis.IntersectWith(conjuntoAstra); // aplicamos lo que vimos en clase el conjunto de Interseccion

        //  DIFERENCIA: ciudadanos que no han sido vacunados
        HashSet<string> noVacunados = new HashSet<string>(conjuntoU);
        noVacunados.ExceptWith(vacunados); // el conjunto de diferencia

        //  DIFERENCIA: ciudadanos que solo recibieron Pfizer
        HashSet<string> soloPfizer = new HashSet<string>(conjuntoPfizer);
        soloPfizer.ExceptWith(conjuntoAstra); 

        //  DIFERENCIA: ciudadanos que solo recibieron AstraZeneca
        HashSet<string> soloAstra = new HashSet<string>(conjuntoAstra);
        soloAstra.ExceptWith(conjuntoPfizer); 

        // ===============================
        // RESULTADOS EN CONSOLA
        // ===============================
        Console.WriteLine("==== Campaña de Vacunación COVID-19 ====");
        Console.WriteLine("Total ciudadanos: " + conjuntoU.Count);
        Console.WriteLine("Vacunados con Pfizer: " + conjuntoPfizer.Count);
        Console.WriteLine("Vacunados con AstraZeneca: " + conjuntoAstra.Count);
        Console.WriteLine("Vacunados (al menos una dosis): " + vacunados.Count); // Unión
        Console.WriteLine("No vacunados: " + noVacunados.Count); // Diferencia
        Console.WriteLine("Ambas dosis: " + ambasDosis.Count); // Intersección
        Console.WriteLine("Solo Pfizer: " + soloPfizer.Count); // Diferencia
        Console.WriteLine("Solo AstraZeneca: " + soloAstra.Count); // Diferencia

        // ===============================
        // LISTADOS INDIVIDUALES
        // ===============================
        Console.WriteLine("\n-- No vacunados --");
        foreach (var e in noVacunados) Console.WriteLine(e);

        Console.WriteLine("\n-- Ambas dosis --");
        foreach (var e in ambasDosis) Console.WriteLine(e);

        Console.WriteLine("\n-- Solo Pfizer --");
        foreach (var e in soloPfizer) Console.WriteLine(e);

        Console.WriteLine("\n-- Solo AstraZeneca --");
        foreach (var e in soloAstra) Console.WriteLine(e);
    }

    // Método para generar ciudadanos vacunados aleatoriamente
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
