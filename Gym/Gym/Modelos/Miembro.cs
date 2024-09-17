using Gym.Enums;

namespace Gym.Modelos
{
    public class Miembro
    {
        public string Nombre {  get; private set; }
        public TipoMembresia Membresia { get; private set; }
        public double CostoBaseMembresia
        {
            get
            {
                switch (Membresia)
                {
                    case TipoMembresia.Basica: return 30;
                    case TipoMembresia.Premium: return 50;
                    case TipoMembresia.Vip: return 80;
                    default: return 0;
                }
            }
        }

        public List<ClaseAdicional> ClaseAdicional { get; private set; } = new List<ClaseAdicional>();
        public bool AccesoPiscina
        {
            get
            {
                if (Membresia != TipoMembresia.Basica) return true;
                else return false;
            }
        }

        public bool AccesoClasesGrupales
        {
            get
            {
                if (Membresia != TipoMembresia.Basica) return true;
                else return false;
            }
        }

        public bool AccesoSpa
        {
            get
            {
                if (Membresia == TipoMembresia.Vip) return true;
                else return false;
            }
        }

        public double DescuentoEnClases
        {
            get
            {
                if (Membresia == TipoMembresia.Premium) return 0.1;
                else if (Membresia == TipoMembresia.Vip) return 0.2;
                else return 0;
            }
        }

        public double CostoTotalClase
        {
            get
            {
                double total = 0;
                foreach (var clase in ClaseAdicional)
                {
                    total += clase.Costo;
                }
                return total * (1 - DescuentoEnClases);
            }
        }

        public double CostoTotalMensual
        {
            get { return CostoBaseMembresia + CostoTotalClase; }
        }

        public Miembro(string nombre, TipoMembresia membresia)
        {
            Nombre = nombre;
            Membresia = membresia;
        }

        public void AgregarClase(ClaseAdicional clase)
        {
            ClaseAdicional.Add(clase);
        }

        public void MostrarDetallesMembresia()
        {
            Console.WriteLine("Detalles de la Membresia:");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Membresia: {Membresia}");
            Console.WriteLine($"Acceso a Piscina: {(AccesoPiscina ? "Si" : "No")}");
            Console.WriteLine($"Acceso a Spa: {(AccesoSpa ? "Si" : "No")}");
            Console.WriteLine($"Clases Grupales: {(AccesoClasesGrupales ? "Si" : "No")}");
            Console.WriteLine($"Costo Base Membresia: {CostoBaseMembresia:C}\n");

            Console.WriteLine("- Clases Adicionales:\n");
            foreach (var clase in ClaseAdicional)
            {
                Console.WriteLine($" ° Nombre Clase: {clase.Nombre}");
                Console.WriteLine($" ° Costo Clase: {clase.Costo:C}");
                Console.WriteLine($" ° Descuento aplicado: {DescuentoEnClases * 100}%\n");
            }
            Console.WriteLine($"Costo Total Clases adicionales: {CostoTotalClase:C}\n");

            Console.WriteLine($"Costo Total Membresia + Clases: {CostoTotalMensual:C}");
            Console.WriteLine("-------------------------------------------\n");
        }
    }
}
