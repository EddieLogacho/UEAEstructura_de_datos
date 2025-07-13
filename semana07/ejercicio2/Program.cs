using System;

// Clase principal del programa
class Program
{
    // Método Main: punto de entrada
    static void Main()
    {
        Console.WriteLine("Torres de Hanoi con Pilas");
        Console.Write("Ingrese el número de discos: ");

        int discos;

        // Validación de entrada
        while (!int.TryParse(Console.ReadLine(), out discos) || discos < 1)
        {
            Console.Write("Por favor, ingrese un número entero positivo: ");
        }

        // Crear una instancia del juego
        JuegoHanoi juego = new JuegoHanoi(discos);

        // Resolver el problema y mostrar los pasos
        juego.Resolver();
    }
}
