namespace SistemaTramitesMunicipales
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // SOLO DISEÑO: para ver otra pantalla en ejecución, cambie FrmLogin por
            // FrmMenuPrincipal, FrmNuevoTramite, FrmInscripcionPropiedad,
            // FrmConstanciaNoAdeudo o FrmConsultarTramites.
            Application.Run(new FrmPrincipal());
        }
    }
}
