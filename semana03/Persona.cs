namespace EstudianteRegistro
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public Dato[] Telefonos { get; set; } // Array para 3 teléfonos

        public Persona(int id, string nombres, string apellidos, string direccion)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefonos = new Dato[3]; // Inicializa el array para 3 teléfonos
        }
    }
}