using System;

// Clase principal del programa
class Program
{
    // Método principal que se ejecuta al iniciar el programa
    static void Main()
    {
        Console.WriteLine("Torres de Hanoi con Pilas");

        // Solicita al usuario que ingrese el número de discos
        Console.Write("Ingrese el número de discos: ");
        int discos;

        // Valida que la entrada sea un número entero positivo
        while (!int.TryParse(Console.ReadLine(), out discos) || discos < 1)
        {
            Console.Write("Por favor, ingrese un número entero positivo: ");
        }

        // Crea una instancia del juego con el número de discos ingresado
        JuegoHanoi juego = new JuegoHanoi(discos);

        // Llama al método que resuelve el problema
        juego.Resolver();
    }
}
