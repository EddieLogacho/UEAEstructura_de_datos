using System;
using System.Collections.Generic;

public class Ejercicio1
{
    public static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                pila.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (pila.Count == 0)
                    return false;

                char apertura = pila.Pop();

                if (!EsParBalanceado(apertura, c))
                    return false;
            }
        }

        return pila.Count == 0;
    }

    private static bool EsParBalanceado(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '[' && cierre == ']') ||
               (apertura == '{' && cierre == '}');
    }
}
