namespace Gym.Modelos
{
    public class ClaseAdicional
    {
        public string Nombre {  get; set; }
        public double Costo { get; set; }

        public ClaseAdicional(string nombre, double costo)
        {
            Nombre = nombre;
            Costo = costo;
        }
    }
}
