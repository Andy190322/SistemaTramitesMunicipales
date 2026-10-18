namespace SistemaTramitesMunicipales
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnAccesoNuevo_Click(object sender, EventArgs e)
        {
            AbrirNuevoTramite();
        }

        private void btnAccesoConsulta_Click(object sender, EventArgs e)
        {
            AbrirConsultaTramites();
        }
        private void AbrirNuevoTramite()
        {
            FrmNuevoTramite formulario = new FrmNuevoTramite();
            FrmPrincipal principal = this.MdiParent as FrmPrincipal;

            if (principal != null)
            {
                principal.AbrirFormulario(formulario);
            }
        }

        private void AbrirConsultaTramites()
        {
            FrmConsultarTramites formulario = new FrmConsultarTramites();
            FrmPrincipal principal = this.MdiParent as FrmPrincipal;

            if (principal != null)
            {
                principal.AbrirFormulario(formulario);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoTramite_Click(object sender, EventArgs e)
        {
            AbrirNuevoTramite();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AbrirConsultaTramites();
        }

        private void btnContribuyentes_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }
        private void CerrarSesion()
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea cerrar sesión?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                FrmPrincipal principal = this.MdiParent as FrmPrincipal;

                if (principal != null)
                {
                    FrmLogin login = new FrmLogin();
                    principal.AbrirFormulario(login);
                }
            }
        }
    }
}
