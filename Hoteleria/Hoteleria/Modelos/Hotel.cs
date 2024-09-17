using Hoteleria.Enums;

namespace Hoteleria.Modelos
{
    public class Hotel
    {
        public string Nombre { get; set; }
        public Temporada Temporada { get; set; }
        public List<Habitacion> Habitaciones { get; set; } = new List<Habitacion>();

        public Hotel(string nombre, Temporada temporada) {
            Nombre = nombre;
            Temporada = temporada;
        }

        public void AgregarHabitacion(Habitacion habitacion)
        {
            Habitaciones.Add(habitacion);
        }

        public string ObtenerDetalles()
        {
            return $"Hotel: {Nombre}";
        }
    }
}
