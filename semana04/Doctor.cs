using System;

// Clase que representa a un doctor de la clínica
public class Doctor
{
    // Propiedades del doctor
    public int Id { get; set; }              // Identificador único
    public string Nombre { get; set; }       // Nombre del doctor
    public string Especialidad { get; set; } // Especialidad médica
    public string Telefono { get; set; }     // Teléfono de contacto

    // Constructor para crear un nuevo doctor
    public Doctor(int id, string nombre, string especialidad, string telefono)
    {
        Id = id;
        Nombre = nombre;
        Especialidad = especialidad;
        Telefono = telefono;
    }

    // Método para mostrar los datos del doctor como texto
    public override string ToString()
    {
        return $"Dr. {Nombre} - {Especialidad} (ID: {Id})";
    }
}
