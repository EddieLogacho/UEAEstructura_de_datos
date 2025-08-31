using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    // Diccionario que almacena las traducciones de español a inglés
    static Dictionary<string, string> diccionario = new Dictionary<string, string>();

    static void Main()
    {
        // Cargar palabras iniciales en el diccionario
        CargarBase();

        // Ciclo principal del menú interactivo
        while (true)
        {
            // Mostrar opciones del menú
            Console.WriteLine("\n-------------------- MENÚ --------------------");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            // Ejecutar la opción seleccionada
            if (opcion == "1")
                TraducirFrase();
            else if (opcion == "2")
                AgregarPalabra();
            else if (opcion == "0")
                break;
            else
                Console.WriteLine("Opción inválida.");
        }
    }

    // Método para cargar palabras base al diccionario
    static void CargarBase()
    {
        diccionario.Add("tiempo", "time");
        diccionario.Add("persona", "person");
        diccionario.Add("año", "year");
        diccionario.Add("camino", "way");
        diccionario.Add("forma", "way");
        diccionario.Add("día", "day");
        diccionario.Add("cosa", "thing");
        diccionario.Add("hombre", "man");
        diccionario.Add("mundo", "world");
        diccionario.Add("vida", "life");
        diccionario.Add("mano", "hand");
        diccionario.Add("parte", "part");
        diccionario.Add("niño", "child");
        diccionario.Add("ojo", "eye");
        diccionario.Add("mujer", "woman");
        diccionario.Add("lugar", "place");
        diccionario.Add("trabajo", "work");
        diccionario.Add("semana", "week");
        diccionario.Add("caso", "case");
        diccionario.Add("punto", "point");
        diccionario.Add("tema", "point");
        diccionario.Add("gobierno", "government");
        diccionario.Add("empresa", "company");
        diccionario.Add("compañía", "company");
    }

    // Método para traducir una frase ingresada por el usuario
    static void TraducirFrase()
    {
        Console.Write("\nIngrese frase en español: ");
        string frase = Console.ReadLine();

        // Separar palabras y signos de puntuación usando expresiones regulares
        var expresion = Regex.Split(frase, @"(\W+)");

        // Recorrer cada palabra para traducirla si está en el diccionario
        for (int i = 0; i < expresion.Length; i++)
        {
            string palabra = expresion[i].ToLower().Trim();
            if (diccionario.ContainsKey(palabra))
            {
                expresion[i] = diccionario[palabra];
            }
        }

        // Mostrar la frase traducida
        Console.WriteLine("Traducción: " + string.Join("", expresion));
    }

    // Método para agregar una nueva palabra al diccionario
    static void AgregarPalabra()
    {
        Console.Write("\nPalabra en español: ");
        string es = (Console.ReadLine() ?? "").Trim().ToLower();

        Console.Write("Traducción en inglés: ");
        string en = (Console.ReadLine() ?? "").Trim();

        // Validar que ambas entradas no estén vacías
        if (!string.IsNullOrWhiteSpace(es) && !string.IsNullOrWhiteSpace(en))
        {
            diccionario[es] = en;
            Console.WriteLine("Agregada con éxito.");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}
