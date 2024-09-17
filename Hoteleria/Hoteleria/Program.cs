using Hoteleria.Modelos;
using Hoteleria.Enums;

namespace Hoteleria
{
    public class Program
    {
        static void Main()
        {
            Servicio servicio = new Servicio("Spa", 50);
            Habitacion habitacion = new Habitacion(7, "Estandar", 100);
            Habitacion habitacion2 = new Habitacion(8, "Estandar", 100);
            Hotel hotel = new Hotel("Gran Hotel", Temporada.Baja);            
            Cliente cliente = new Cliente("Nicolas", 12345);
            Reserva reserva = new Reserva(hotel, habitacion, DateTime.Now, "Tarjeta");

            habitacion.AgregarServicio(servicio);

            hotel.AgregarHabitacion(habitacion);
            hotel.AgregarHabitacion(habitacion2);

            cliente.HacerReserva(hotel, habitacion, "Tarjeta");

            reserva.CalcularCostoTotal(Temporada.Baja);

            reserva.MostrarDetalles();
        }
    }
}
