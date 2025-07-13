using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una expresión matemática:");
        string expresion = Console.ReadLine();

        if (Ejercicio1.EstaBalanceada(expresion))
        {
            Console.WriteLine("formula balanceada.");
        }
        else
        {
            Console.WriteLine("formula no balanceada.");
        }
    }
}
