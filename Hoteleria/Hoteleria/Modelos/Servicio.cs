
namespace Hoteleria.Modelos
{
    public class Servicio
    {
        public string Descripcion { get; set; }
        public double Costo { get; set; }

        public Servicio(string descripcion, double costo) {
            Descripcion = descripcion;
            Costo = costo;
        }
    }
}
