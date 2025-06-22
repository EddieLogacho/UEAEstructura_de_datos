using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear algunos pacientes
        Paciente paciente1 = new Paciente(1, "Edison", "Logacho", new DateTime(1980, 5, 20), "09927252487");
        Paciente paciente2 = new Paciente(2, "Cristina", "Agurre", new DateTime(1990, 7, 10), "0998787116");
        Paciente paciente3 = new Paciente(3, "Jayko", "Logacho", new DateTime(1980, 5, 20), "09924865437");
        Paciente paciente4 = new Paciente(4, "Michell", "Gualoto", new DateTime(1990, 7, 10), "0998788753");
        // Crear algunos doctores
        Doctor doctor1 = new Doctor(1, "Santiago", "Cardiología", "0987654321");
        Doctor doctor2 = new Doctor(2, "María", "Pediatría", "091234567");

        // Crear algunos turnos
        Turno turno1 = new Turno(1, paciente1, doctor1, new DateTime(2025, 6, 25, 9, 0, 0));
        Turno turno2 = new Turno(2, paciente2, doctor2, new DateTime(2025, 6, 25, 10, 30, 0));
        Turno turno3 = new Turno(3, paciente1, doctor1, new DateTime(2025, 6, 25, 11, 0, 0));
        Turno turno4 = new Turno(4, paciente2, doctor2, new DateTime(2025, 6, 25, 12, 30, 0));

        // Mostrar los turnos en consola
        Console.WriteLine(turno1);
        Console.WriteLine(turno2);
        Console.WriteLine(turno3);
        Console.WriteLine(turno4);
        
        


        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
