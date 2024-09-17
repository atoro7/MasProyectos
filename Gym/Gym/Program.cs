using Gym.Modelos;
using Gym.Enums;

namespace Gym
{
    class Program
    {
        static void Main()
        {
            Miembro miembro = new Miembro("Nico", TipoMembresia.Premium);

            ClaseAdicional clase1 = new ClaseAdicional("Yoga", 15);
            ClaseAdicional clase2 = new ClaseAdicional("Capilates", 20);

            miembro.AgregarClase(clase1);
            miembro.AgregarClase(clase2);

            miembro.MostrarDetallesMembresia();
        }
    }
}