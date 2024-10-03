namespace Contactos.Models
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string CorreoElectronico { get; set; }

        public Contacto(string nombre, int telefono, string correoElectronico)
        {
            Nombre = nombre;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Telefono: {Telefono}, Correo electronico: {CorreoElectronico}";
        }
    }
}
