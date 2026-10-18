namespace SistemaTramitesMunicipales
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IniciarSesion();

        }
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
