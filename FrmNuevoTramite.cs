
using System;
using System.Windows.Forms;

namespace SistemaTramitesMunicipales
{
    public partial class FrmNuevoTramite : Form
    {
        // ==================== CONSTRUCTOR ====================
        public FrmNuevoTramite()
        {
            InitializeComponent();
        }

        // ==================== BOTONES Y EVENTOS ====================
        private void btnNoAdeudo_Click(object sender, EventArgs e)
        {
            AbrirConstanciaNoAdeudo();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            RegresarMenuPrincipal();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            AbrirInscripcion();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
        }

        private void lblDescInscripcion_Click(object sender, EventArgs e)
        {
        }

        private void grpInscripcion_Enter(object sender, EventArgs e)
        {
        }

        private void grpNoAdeudo_Enter(object sender, EventArgs e)
        {
        }

        private void lblDescNoAdeudo_Click(object sender, EventArgs e)
        {
        }

        // ==================== MÉTODOS VOID ====================
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
