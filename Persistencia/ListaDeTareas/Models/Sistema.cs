namespace ListaDeTareas.Models
{
    public static class Sistema
    {
        static Dictionary<string, Usuario> usuarios = new();
        static readonly string archivo = "usuario.txt";
        static readonly string usuarioSeparado = "-";

        public static void AgregarUsuario()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string nombreUsuario = Console.ReadLine();

            if (!usuarios.ContainsKey(nombreUsuario))
            {
                usuarios[nombreUsuario] = new Usuario(nombreUsuario);
                Console.WriteLine($"Usuario {nombreUsuario} agregado.");
            }
            else
            {
                Console.WriteLine("Usuario existente.");
            }
        }

        public static void AgregarTareaAUsuario()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string nombreUsuario = Console.ReadLine();

            if (usuarios.ContainsKey(nombreUsuario))
            {
                Console.Write("Ingrese la descripcion de la tarea: ");
                string descripcion = Console.ReadLine();

                Tarea tarea = new Tarea(descripcion);

                usuarios[nombreUsuario].AgregarTarea(tarea);
                Console.WriteLine($"Tarea agregada al usuario {nombreUsuario}");
            }
            else
            {
                Console.WriteLine("Usuario no existe.");
            }
        }

        public static void CambiarEstadoTareaDeUsuario()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string nombreUsuario = Console.ReadLine();

            if (usuarios.ContainsKey(nombreUsuario))
            {
                Console.WriteLine("Ingrese el número de la tarea a cambiar (empezando desde 0)");
                int indice = int.Parse(Console.ReadLine());

                usuarios[nombreUsuario].CambiarEstadoTarea(indice);
                Console.WriteLine("Estado de la tarea cambiado.");
            }
            else
            {
                Console.WriteLine("Usuario no existe.");
            }
        }

        public static void MostrarTareasUsuario()
        {
            Console.Write("Ingrese el nombre del usuario: ");
            string nombreUsuario = Console.ReadLine();

            if (usuarios.ContainsKey(nombreUsuario))
            {
                usuarios[nombreUsuario].MostrarTareas();
            }
            else
            {
                Console.WriteLine("Usuario no existe.");
            }
        }

        public static void GuardarDatos()
        {
            using StreamWriter writer = new StreamWriter(archivo);

            foreach (var usuario in usuarios)
            {
                writer.WriteLine(usuario.Key);

                foreach (var tarea in usuario.Value.Tareas)
                {
                    writer.WriteLine($"{tarea.Descripcion}|{tarea.Completada}");
                }
                writer.WriteLine(usuarioSeparado);
            }
            Console.WriteLine("Datos guardado correctamente!");           
        }
    }
}
