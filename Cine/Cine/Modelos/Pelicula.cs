using Cine.Enums;

namespace Cine.Modelos
{
    public class Pelicula
    {
        public string Nombre { get; private set; }
        public string Genero {  get; private set; }
        public int DuracionMin {  get; private set; }
        public Formato Formato { get; private set; }
        public double CostoPelicula
        {
            get
            {
                switch (Formato)
                {
                    case Formato._2D_Doblada: return 5;
                    case Formato._2D_Subtitulada: return 5;
                    case Formato._3D_Doblada: return 8;
                    case Formato._3D_Subtitulada: return 8;
                    case Formato.IMAX_Doblada: return 10;
                    case Formato.IMAX_Subtitulada: return 10;
                    default: return 0;
                }
            }
        }

        public Pelicula(string nombre, string genero, int duracionMin, Formato formato)
        {
            Nombre = nombre;
            Genero = genero;
            DuracionMin = duracionMin;
            Formato = formato;
        }
    }
}
