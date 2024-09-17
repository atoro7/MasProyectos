namespace Cine.Modelos
{
    public class Sala
    {
        public int Numero {  get; private set; }
        public List<Asiento> Asiento {  get; private set; } = new List<Asiento>();
        public Pelicula Pelicula { get; private set; }
        public TimeSpan Horario { get; private set; }

        public Sala(int numero, Pelicula pelicula)
        {
            Numero = numero;
            Pelicula = pelicula;
        }

        public void AgregarAsiento(Asiento asiento)
        {
            Asiento.Add(asiento);
        }

        public void AgregarAsiento(List<Asiento> asiento)
        {
            Asiento.AddRange(asiento);
        }

        public void DefinirHorario(int hora, int minutos, int segundos = 0)
        {
            Horario = new TimeSpan(hora, minutos, segundos);
        }

        public void ReproducirPelicula(Pelicula pelicula)
        {
            Console.WriteLine($"Reproduciendo pelicula: {Pelicula}");
        }
    }
}
