namespace Hoteleria.Modelos
{
    public class Cliente
    {
        public string Nombre {  get; set; }
        public int Documento { get; set; }

        public Cliente(string nombre, int documento)
        {
            Nombre = nombre;
            Documento = documento;
        }

        public void HacerReserva(Hotel hotel, Habitacion habitacion, string metodoPago)
        {

        }

        public void HacerReserva(Hotel hotel, List<Habitacion> habitacion, string metodoPago)
        {

        }
    }
}
