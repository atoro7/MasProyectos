using ListaDeTareas.Models;

namespace ListaDeTareas
{
    public class Program
    {
        static void Main()
        {
            int opcion;

            
            do 
            {
                Console.WriteLine("1. Agregar Usuario.");
                Console.WriteLine("2. Agregar tarea a usuario.");
                Console.WriteLine("3. Cambiar estado de tarea.");
                Console.WriteLine("4. Mostrar tareas de un usuario");
                Console.WriteLine("5. Guarda y salir");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion) {
                    case 1:
                        Sistema.AgregarUsuario();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Sistema.AgregarTareaAUsuario();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Sistema.CambiarEstadoTareaDeUsuario();
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        Sistema.MostrarTareasUsuario();
                        Console.WriteLine("\n");
                        break;
                }
                
            }
             while (opcion != 5) ;
             Sistema.GuardarDatos();          
        }
    }
}
