
using System;
using System.Windows.Forms;

namespace SistemaTramitesMunicipales
{
    public partial class FrmLogin : Form
    {
        // ==================== CONSTRUCTOR ====================

        public FrmLogin()
        {
            InitializeComponent();
        }


        // ==================== BOTONES Y EVENTOS ====================

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
        }

        private void lblMunicipalidad_Click(object sender, EventArgs e)
        {
        }

        private void lblGerencia_Click(object sender, EventArgs e)
        {
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
        }

        private void lblContrasena_Click(object sender, EventArgs e)
        {
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlAcceso_Paint(object sender, PaintEventArgs e)
        {
        }


        // ==================== MÉTODOS VOID ====================

        private void IniciarSesion()
        {
            if (txtUsuario.Text.Trim() == "" ||
                txtContrasena.Text == "")
            {
                MessageBox.Show("Ingrese su usuario y contraseña.");
                return;
            }

            bool valido = GestionUsuarios.ValidarUsuario(
                txtUsuario.Text.Trim(),
                txtContrasena.Text
            );

            if (!valido)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
                return;
            }

            FrmPrincipal principal = this.MdiParent as FrmPrincipal;

            if (principal != null)
            {
                FrmMenuPrincipal menu = new FrmMenuPrincipal();
                principal.AbrirFormulario(menu);
            }
            else
            {
                MessageBox.Show("No se encontró el formulario principal.");
            }
        }
    }
}
