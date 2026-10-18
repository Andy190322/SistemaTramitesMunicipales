
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SistemaTramitesMunicipales
{
    internal class GestionInscripciones
    {
        private static readonly string carpetaDatos =
            Path.Combine(Application.StartupPath, "Datos");

        private static readonly string rutaInscripciones =
            Path.Combine(carpetaDatos, "Inscripciones.txt");

        public static bool GuardarInscripcion(string datos)
        {
            try
            {
                Directory.CreateDirectory(carpetaDatos);

                File.AppendAllText(
                    rutaInscripciones,
                    datos + Environment.NewLine,
                    Encoding.UTF8
                );

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo guardar la inscripción: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }
        public static string GenerarNumeroExpediente()
        {
            string carpetaDatos = Path.Combine(
                Application.StartupPath, "Datos");

            string rutaInscripciones = Path.Combine(
                carpetaDatos, "Inscripciones.txt");

            Directory.CreateDirectory(carpetaDatos);

            int numero = 1;

            if (File.Exists(rutaInscripciones))
            {
                foreach (string linea in File.ReadAllLines(rutaInscripciones))
                {
                    if (string.IsNullOrWhiteSpace(linea))
                        continue;

                    numero++;
                }
            }

            return numero.ToString("D6");
        }
    }
}
