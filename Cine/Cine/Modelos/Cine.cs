namespace Cine.Modelos
{
    public class Cinema
    {
        public string Nombre {  get; private set; }
        public List<Sala> Sala { get; private set; } = new List<Sala>();

        public Cinema(string nombre)
        {
            Nombre = nombre;
        }

        public void AgregsarSala(Sala sala)
        {
            Sala.Add(sala);
        }
    }
}
