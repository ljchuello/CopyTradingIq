using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace CopyTradingIq.Biblioteca
{
    public class Fichero
    {
        public static string Ruta = "C:\\IqOption";

        public static void DirectoryCheck()
        {
            try
            {
                if (!Directory.Exists(Ruta))
                {
                    Directory.CreateDirectory(Ruta);
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public static void Guardar(string ruta, string valor)
        {
            File.WriteAllText(ruta, valor, Encoding.Default);
        }

        public static string Leer(string ruta)
        {
            return File.ReadAllText(ruta);
        }

        public class Usuario
        {
            public string Correo { set; get; } = string.Empty;
            public string Contrasenia { set; get; } = string.Empty;

            public bool Guardar(Usuario usuario)
            {
                try
                {
                    // Validamos el directorio
                    DirectoryCheck();

                    // To Json
                    string json = JsonConvert.SerializeObject(usuario, Formatting.Indented);

                    // Guardamos
                    Fichero.Guardar($"{Ruta}\\usr.json", json);

                    // Libre de pecados
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public Usuario Leer()
            {
                try
                {
                    Usuario usuario = new Usuario();
                    string json = Fichero.Leer($"{Ruta}\\usr.json");
                    usuario = JsonConvert.DeserializeObject<Usuario>(json) ?? new Usuario();
                    return usuario;
                }
                catch (Exception)
                {
                    return new Usuario();
                }
            }
        }
    }
}
