namespace SistemaTramitesMunicipales
{
    public partial class FrmNuevoTramite : Form
    {
        public FrmNuevoTramite()
        {
            InitializeComponent();
        }

        private void btnNoAdeudo_Click(object sender, EventArgs e)
        {
            AbrirConstanciaNoAdeudo();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            RegresarMenuPrincipal();
        }



        private void RegresarMenuPrincipal()
        {
            FrmPrincipal principal = this.MdiParent as FrmPrincipal;

            if (principal != null)
            {
                principal.AbrirFormulario(new FrmMenuPrincipal());
            }
            else
            {
                MessageBox.Show("No se encontró el formulario principal.");
            }
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            AbrirInscripcion();
        }
        private void AbrirInscripcion()
        {
            FrmInscripcionPropiedad formulario =
                new FrmInscripcionPropiedad();

            FrmPrincipal principal = this.MdiParent as FrmPrincipal;

            if (principal != null)
            {
                principal.AbrirFormulario(formulario);
            }
            else
            {
                MessageBox.Show("No se encontró el formulario principal.");
            }
        }

        private void AbrirConstanciaNoAdeudo()
        {
            FrmConstanciaNoAdeudo formulario =
                new FrmConstanciaNoAdeudo();

            FrmPrincipal principal = this.MdiParent as FrmPrincipal;

            if (principal != null)
            {
                principal.AbrirFormulario(formulario);
            }
            else
            {
                MessageBox.Show("No se encontró el formulario principal.");
            }
        }

    }
}
