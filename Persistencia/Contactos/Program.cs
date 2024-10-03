using Contactos.Models;

namespace Contactos
{
    public class Program
    {
        static void Main()
        {
            Sistema.CargarDatos();
            int opcion;


            do
            {
                Console.WriteLine("1. Agregar Contacto.");
                Console.WriteLine("2. Mostrar todos los contactos.");
                Console.WriteLine("0. Guarda y salir");

                Console.Write("Ingrese una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Sistema.AgregarContacto();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Sistema.MostrarContactos();
                        Console.WriteLine("\n");
                        break;
                }
            }
            while (opcion != 0);
            //Sistema.GuardarDatos();
        }
    }
}
