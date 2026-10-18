using System;
using System.IO;
using System.Windows.Forms;

namespace SistemaTramitesMunicipales
{
    internal class GestionUsuarios
    {
        private static string rutaArchivo = "Usuarios.txt";

        public static bool RegistrarUsuario(
            string usuario,
            string contrasena,
            string nombres,
            string apellidos,
            string dni,
            string correo,
            string telefono)
        {
            if (!File.Exists(rutaArchivo))
            {
                File.Create(rutaArchivo).Close();
            }

            string[] usuarios = File.ReadAllLines(rutaArchivo);

            foreach (string linea in usuarios)
            {
                string[] datos = linea.Split('|');

                if (datos.Length >= 7)
                {
                    if (datos[0].Equals(usuario,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("El nombre de usuario ya existe.");
                        return false;
                    }

                    if (datos[4] == dni)
                    {
                        MessageBox.Show("Este DNI ya está registrado.");
                        return false;
                    }

                    if (datos[5].Equals(correo,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Este correo electrónico ya está registrado.");
                        return false;
                    }

                    if (datos[6] == telefono)
                    {
                        MessageBox.Show("Este teléfono ya está registrado.");
                        return false;
                    }
                }
            }

            string registro = usuario + "|" +
                              contrasena + "|" +
                              nombres + "|" +
                              apellidos + "|" +
                              dni + "|" +
                              correo + "|" +
                              telefono;

            File.AppendAllText(rutaArchivo, registro +
                Environment.NewLine);

            return true;
        }

        public static bool ValidarUsuario(string usuario, string contrasena)
        {
            if (!File.Exists(rutaArchivo))
                return false;

            string[] usuarios = File.ReadAllLines(rutaArchivo);

            foreach (string linea in usuarios)
            {
                string[] datos = linea.Split('|');

                if (datos.Length >= 7 &&
                    datos[0].Equals(usuario, StringComparison.OrdinalIgnoreCase) &&
                    datos[1] == contrasena)
                {
                    return true;
                }
            }

            return false;
        }

    }
}