using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTramitesMunicipales
{
    public partial class FrmCrearCuenta : Form
    {
        public FrmCrearCuenta()
        {
            InitializeComponent();
            ConfigurarCamposNumericos();
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

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
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

            MessageBox.Show("Datos correctos. Próximamente se registrará en la base de datos.");


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
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
                MessageBox.Show("No se pudo registrar. Verifique si los datos ya existen.");
                return;
            }
        }



        private void ValidarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ConfigurarCamposNumericos()
        {
            txtDni.MaxLength = 8;
            txtTelefono.MaxLength = 9;

            txtDni.KeyPress += ValidarSoloNumeros;
            txtTelefono.KeyPress += ValidarSoloNumeros;
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
