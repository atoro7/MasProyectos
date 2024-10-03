namespace Contactos.Models
{
    public static class Sistema
    {
        static public List<Contacto> contactos = new();
        static readonly string archivo = "contacto.txt";
        static readonly string sc = "-";

        static public void AgregarContacto()
        {
            Console.Write("Ingresar nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresar telefono: ");
            int telefono = int.Parse(Console.ReadLine());

            Console.Write("Ingresar correo electronico: ");
            string correo = Console.ReadLine();

            bool existe = false;
            foreach (Contacto c in contactos)
            {
                if(c.Nombre == nombre && c.Telefono == telefono)
                {
                    existe = true;
                }
            }
            if (!existe)
            {
                Contacto contacto = new Contacto(nombre, telefono, correo);
                contactos.Add(contacto);
                GuardarContacto(contacto);
            }
            else { Console.WriteLine("Contacto existente."); }            
        }

        static public void MostrarContactos()
        {
            if (contactos.Count > 0)
            {
                Console.WriteLine("\nContactos:");
                foreach (var contacto in contactos)
                {
                    Console.WriteLine(contacto);
                }
            }
            else { Console.WriteLine("No hay contactos que mostrar"); }
        }

        static public void GuardarDatos()
        {
            using StreamWriter writer = new StreamWriter(archivo);

            foreach (var contacto in contactos)
            {
                writer.WriteLine($"{contacto.Nombre}{sc}{contacto.Telefono}{sc}{contacto.CorreoElectronico}");
            }
            Console.WriteLine("Datos guardados correctamente!");
        }

        static public void CargarDatos()
        {
            if (File.Exists(archivo))
            {
                using StreamReader reader = new StreamReader(archivo);
                string linea;

                while ((linea = reader.ReadLine()) != null)
                {
                    string[] partes = linea.Split(sc);

                    string nombre = partes[0];
                    int teledono = int.Parse(partes[1]);
                    string correo = partes[2];

                    contactos.Add(new Contacto(nombre, teledono, correo));
                }
                Console.WriteLine("Contactos cargados correctamente.");
            }
        }

        public static void GuardarContacto(Contacto contacto)
        {
            using StreamWriter writer = new StreamWriter(archivo, true);
            writer.WriteLine($"{contacto.Nombre}{sc}{contacto.Telefono}{sc}{contacto.CorreoElectronico}");
        }
    }
}
