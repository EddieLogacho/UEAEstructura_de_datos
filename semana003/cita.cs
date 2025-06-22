using System;

// Clase que representa un turno o cita médica
public class Turno
{
    // Propiedades del turno
    public int Id { get; set; }                 // ID único del turno
    public Paciente Paciente { get; set; }      // Paciente que toma el turno
    public Doctor Doctor { get; set; }          // Doctor asignado al turno
    public DateTime FechaHora { get; set; }     // Fecha y hora del turno

    // Constructor para crear un nuevo turno
    public Turno(int id, Paciente paciente, Doctor doctor, DateTime fechaHora)
    {
        Id = id;
        Paciente = paciente;
        Doctor = doctor;
        FechaHora = fechaHora;
    }

    // Método para mostrar los datos del turno como texto
    public override string ToString()
    {
        return $"Turno #{Id} - {Paciente} con {Doctor} el {FechaHora}";
    }
}
