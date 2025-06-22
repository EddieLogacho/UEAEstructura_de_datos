namespace EstudianteRegistro
{
    public class Dato
    {
        public string Tipo { get; set; }
        public string Numero { get; set; }

        public Dato(string tipo, string numero)
        {
            Tipo = tipo;
            Numero = numero;
        }
    }
}