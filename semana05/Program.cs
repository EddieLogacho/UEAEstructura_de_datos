using System; // Importa el espacio de nombres System, necesario para usar Console
using System.Collections.Generic; // Importa el espacio de nombres para trabajar con listas (List)

class Program // para define la clase principal del programa
{
    static void Main() // Método principal: el punto de entrada del programa
    {
        // Paso 1: Crear una lista de asignaturas (tipo string)
        List<string> asignaturas = new List<string> { "matemáticas", "física", "química", "historia", "lenguaje" };
       

        // Recorrer la lista usando un bucle foreach
        // Cada elemento de la lista se guarda en la variable 'asignatura' en cada iteración
        foreach (string asignatura in asignaturas)
        {
            // Paso 3: Mostrar el mensaje con la asignatura actual
            // Se utiliza interpolación de cadenas para insertar el valor de 'asignatura' en el mensaje
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}