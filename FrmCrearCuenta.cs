
using System;
using System.Windows.Forms;

namespace SistemaTramitesMunicipales
{
    public partial class FrmCrearCuenta : Form
    {
        // ==================== CONSTRUCTOR ====================
        public FrmCrearCuenta()
        {
            InitializeComponent();
            ConfigurarCamposNumericos();
        }

        // ==================== BOTONES Y EVENTOS ====================
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            ValidarDatosRegistro();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarCuenta();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        }

        private void FrmCrearCuenta_Load(object sender, EventArgs e)
        {
        }

        private void lblMunicipalidad_Click(object sender, EventArgs e)
        {
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void lblGerencia_Click(object sender, EventArgs e)
        {
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
        }

        private void lblApellido_Click(object sender, EventArgs e)
        {
        }

        private void lblDni_Click(object sender, EventArgs e)
        {
        }

        private void lblContrasena_Click(object sender, EventArgs e)
        {
        }

        private void lblConfirmarContrasena_Click(object sender, EventArgs e)
        {
        }

        private void lblCorreoElectronico_Click(object sender, EventArgs e)
        {
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtConfirmarContrasena_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCorreoElectronico_TextChanged(object sender, EventArgs e)
        {
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {
        }

        // ==================== MÉTODOS VOID ====================
        private void ValidarDatosRegistro()
        {
            if (txtNombreUsuario.Text == "" ||
                txtContrasena.Text == "" ||
                txtConfirmarContrasena.Text == "")
            {
                MessageBox.Show("Complete los campos obligatorios.");
                return;
            }

            if (txtContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            MessageBox.Show(
                "Datos correctos. Próximamente se registrará en la base de datos."
            );
        }

        private void RegistrarCuenta()
        {
            if (txtNombreUsuario.Text.Trim() == "" ||
                txtContrasena.Text == "" ||
                txtConfirmarContrasena.Text == "" ||
                txtNombre.Text.Trim() == "" ||
                txtApellido.Text.Trim() == "" ||
                txtDni.Text.Trim() == "" ||
                txtCorreoElectronico.Text.Trim() == "" ||
                txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (txtDni.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos.");
                return;
            }

            if (txtTelefono.Text.Length != 9)
            {
                MessageBox.Show("El teléfono debe tener exactamente 9 dígitos.");
                return;
            }

            if (txtContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            bool registrado = GestionUsuarios.RegistrarUsuario(
                txtNombreUsuario.Text,
                txtContrasena.Text,
                txtNombre.Text,
                txtApellido.Text,
                txtDni.Text,
                txtCorreoElectronico.Text,
                txtTelefono.Text
            );

            if (registrado)
            {
                MessageBox.Show("Usuario registrado correctamente.");

                FrmPrincipal principal =
                    Application.OpenForms["FrmPrincipal"] as FrmPrincipal;

                if (principal != null)
                {
                    principal.AbrirFormulario(new FrmLogin());
                }

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "No se pudo registrar. Verifique si los datos ya existen."
                );
            }
        }

        // ==================== OTROS MÉTODOS ====================
        private void ConfigurarCamposNumericos()
        {
            txtDni.MaxLength = 8;
            txtTelefono.MaxLength = 9;

            txtDni.KeyPress += ValidarSoloNumeros;
            txtTelefono.KeyPress += ValidarSoloNumeros;
        }

        private void ValidarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
