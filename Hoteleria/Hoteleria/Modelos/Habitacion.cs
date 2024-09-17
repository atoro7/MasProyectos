using Hoteleria.Enums;

namespace Hoteleria.Modelos
{
    public class Habitacion
    {
        public int Numero {  get; set; }
        public string Tipo { get; set; }
        public List<Servicio> Servicios { get; set; } = new List<Servicio>();
        public double TarifaBase { get; set; }

        public Habitacion(int numero, string tipo, double tarifaBase) {
            Numero = numero;
            Tipo = tipo;
            TarifaBase = tarifaBase;
        }

        public void AgregarServicio(Servicio servicio) {
            Servicios.Add(servicio);
        }

        public double CalcularTarifa(Temporada temporada)
        {
            return temporada == Temporada.Alta ? TarifaBase * 1.5 : TarifaBase;

            //if (temporada == "Alta")
            //{
            //    return TarifaBase * 1.5;
            //}
            //return TarifaBase;
        }

        public string ObtenerDetalles()
        {
            return $"Habitación {Numero} ({Tipo})";
        }
    }
}
