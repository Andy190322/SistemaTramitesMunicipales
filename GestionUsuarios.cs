
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
            try
            {
                string[] usuarios = File.Exists(rutaArchivo)
                    ? File.ReadAllLines(rutaArchivo)
                    : Array.Empty<string>();

                foreach (string linea in usuarios)
                {
                    string[] datos = linea.Split('|');

                    if (datos.Length >= 7)
                    {
                        if (datos[0].Equals(usuario,
                            StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show(
                                "El nombre de usuario ya existe.");
                            return false;
                        }

                        if (datos[4] == dni)
                        {
                            MessageBox.Show(
                                "Este DNI ya está registrado.");
                            return false;
                        }

                        if (datos[5].Equals(correo,
                            StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show(
                                "Este correo electrónico ya está registrado.");
                            return false;
                        }

                        if (datos[6] == telefono)
                        {
                            MessageBox.Show(
                                "Este teléfono ya está registrado.");
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

                File.AppendAllText(
                    rutaArchivo,
                    registro + Environment.NewLine);

                return true;
            }
            catch (IOException)
            {
                MessageBox.Show(
                    "Error al leer o guardar el archivo de usuarios.");
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "No tienes permiso para acceder al archivo de usuarios.");
                return false;
            }
        }

        public static bool ValidarUsuario(
            string usuario, string contrasena)
        {
            try
            {
                if (!File.Exists(rutaArchivo))
                    return false;

                string[] usuarios = File.ReadAllLines(rutaArchivo);

                foreach (string linea in usuarios)
                {
                    string[] datos = linea.Split('|');

                    if (datos.Length >= 7 &&
                        datos[0].Equals(usuario,
                            StringComparison.OrdinalIgnoreCase) &&
                        datos[1] == contrasena)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (IOException)
            {
                MessageBox.Show(
                    "Error al leer el archivo de usuarios.");
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "No tienes permiso para leer el archivo de usuarios.");
                return false;
            }
        }
    }
}
