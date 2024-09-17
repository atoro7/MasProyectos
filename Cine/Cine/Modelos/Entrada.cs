using Cine.Enums;

namespace Cine.Modelos
{
    public class Entrada
    {
        public Cinema Cine { get; private set; }
        public Pelicula Pelicula { get; private set; }
        public Asiento Asiento { get; private set; }
        public DateTime Fecha { get; private set; }

        public double Precio
        {
            get
            {
                return Pelicula.CostoPelicula + Asiento.CostoAsiento;
            }
        }

        public Entrada(Cinema cine, Pelicula pelicula, Asiento asiento)
        {
            Cine = cine;
            Pelicula = pelicula;
            Asiento = asiento;        
        }

        public void AgregarFecha(DateTime fecha)
        {
            Fecha = fecha;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Cine {Cine.Nombre} ");
            Console.WriteLine("----------------------");
            Console.WriteLine("Detalles de la entrada: \n");
            Console.WriteLine($"Pelicula: {Pelicula.Nombre}");
            Console.WriteLine($"Asiento: {Asiento.Letra}-{Asiento.Numero}");
            Console.WriteLine($"Fecha: {Fecha:dd/mm/yyyy}");
            Console.WriteLine($"Costo de la entrada: {Precio:C}");
        }
    }
}
