using Cine.Enums;

namespace Cine.Modelos
{
    public class Asiento
    {
        public char Letra {  get; private set; }
        public int Numero {  get; private set; }
        public TipoAsiento Tipo { get; private set; }
        public bool Ocupado { get; private set; }

        public double CostoAsiento
        {
            get
            {
                switch(Tipo)
                {
                    case TipoAsiento.Estandar: return 2;
                    case TipoAsiento.Superseat: return 4;
                    default: return 0;
                }
            }
        }

        public Asiento(char letra, int numero, TipoAsiento tipo, bool ocupado)
        {
            Letra = letra;
            Numero = numero;
            Tipo = tipo;
            Ocupado = ocupado;
        }

        public void CambiarOcupado(bool ocupado)
        {
            Ocupado = true;
        }
    }
}
