using System;

// Clase que representa a un paciente de la clínica
public class Paciente
{
    // Propiedades del paciente
    public int Id { get; set; }                     // Identificador único
    public string Nombre { get; set; }              // Nombre del paciente
    public string Apellido { get; set; }            // Apellido del paciente
    public DateTime FechaNacimiento { get; set; }   // Fecha de nacimiento
    public string Telefono { get; set; }            // Número de teléfono

    // Constructor para inicializar un nuevo paciente
    public Paciente(int id, string nombre, string apellido, DateTime fechaNacimiento, string telefono)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        Telefono = telefono;
    }

    // Método para mostrar los datos del paciente como texto
    public override string ToString()
    {
        return $"{Nombre} {Apellido} (ID: {Id})";
    }
}
