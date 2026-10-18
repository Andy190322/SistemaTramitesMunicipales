using System.Linq;
using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace SistemaTramitesMunicipales
{
    public partial class FrmConstanciaNoAdeudo : Form
    {
        public FrmConstanciaNoAdeudo()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void txtNombreNoAdeudo_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnGuardarNoAdeudo_Click(object sender, EventArgs e)
        {
            GuardarSolicitudNoAdeudo();
        }


        private void ConfigurarFormulario()
        {
            dgvAdjuntosNoAdeudo.AllowUserToAddRows = false;
            dgvAdjuntosNoAdeudo.AllowUserToDeleteRows = false;
            dgvAdjuntosNoAdeudo.ReadOnly = true;
            dgvAdjuntosNoAdeudo.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvAdjuntosNoAdeudo.MultiSelect = false;
            dgvAdjuntosNoAdeudo.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            rbTitular.Checked = true;
            chkNoAdeudo.Checked = true;

            dtpFecha.MaxDate = DateTime.Today;
        }

        private void btnAdjuntarNoAdeudo_Click(object sender, EventArgs e)
        {
            AdjuntarArchivoNoAdeudo();
        }
        private void AdjuntarArchivoNoAdeudo()
        {
            using (OpenFileDialog dialogo = new OpenFileDialog())
            {
                dialogo.Title = "Seleccionar documento";
                dialogo.Filter = "Todos los archivos (*.*)|*.*";
                dialogo.Multiselect = false;

                if (dialogo.ShowDialog() != DialogResult.OK)
                    return;

                foreach (DataGridViewRow fila in dgvAdjuntosNoAdeudo.Rows)
                {
                    if (!fila.IsNewRow &&
                        Convert.ToString(fila.Cells["colRutaArchivo"].Value)
                            == dialogo.FileName)
                    {
                        MessageBox.Show("Este archivo ya está adjuntado.");
                        return;
                    }
                }

                dgvAdjuntosNoAdeudo.Rows.Add(
                    System.IO.Path.GetFileName(dialogo.FileName),
                    dialogo.FileName
                );
            }
        }

        private void btnQuitarAdjunto_Click(object sender, EventArgs e)
        {
            QuitarArchivoNoAdeudo();
        }
        private void QuitarArchivoNoAdeudo()
        {
            if (dgvAdjuntosNoAdeudo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un archivo para quitar.");
                return;
            }

            dgvAdjuntosNoAdeudo.Rows.Remove(
                dgvAdjuntosNoAdeudo.SelectedRows[0]
            );
        }



        private void GuardarSolicitudNoAdeudo()
        {
            if (string.IsNullOrWhiteSpace(txtCodigoContribuyente.Text) ||
                string.IsNullOrWhiteSpace(txtDniNoAdeudo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonoNoAdeudo.Text) ||
                string.IsNullOrWhiteSpace(txtNombreNoAdeudo.Text) ||
                string.IsNullOrWhiteSpace(txtDomicilioNoAdeudo.Text) ||
                string.IsNullOrWhiteSpace(txtCorreoNoAdeudo.Text))
            {
                MessageBox.Show("Complete todos los datos del contribuyente.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(
                txtDniNoAdeudo.Text.Trim(), @"^\d{8}$"))
            {
                MessageBox.Show("El DNI debe contener exactamente 8 dígitos.");
                txtDniNoAdeudo.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(
                txtTelefonoNoAdeudo.Text.Trim(), @"^\d{9}$"))
            {
                MessageBox.Show("El teléfono debe contener exactamente 9 dígitos.");
                txtTelefonoNoAdeudo.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(
                txtCorreoNoAdeudo.Text.Trim(),
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                txtCorreoNoAdeudo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPeriodos.Text) ||
                string.IsNullOrWhiteSpace(txtUbicacionPredio.Text) ||
                string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Complete los datos de la solicitud.");
                return;
            }

            if (!chkNoAdeudo.Checked)
            {
                MessageBox.Show("Marque la constancia que solicita.");
                return;
            }

            if (!rbTitular.Checked && !rbApoderado.Checked)
            {
                MessageBox.Show("Indique si presenta la solicitud como titular o apoderado.");
                return;
            }

            if (dgvAdjuntosNoAdeudo.Rows.Count == 0)
            {
                MessageBox.Show("Adjunte al menos un documento.");
                return;
            }

            try
            {
                string carpeta = System.IO.Path.Combine(
                    Application.StartupPath, "Datos");

                System.IO.Directory.CreateDirectory(carpeta);

                string ruta = System.IO.Path.Combine(
                    carpeta, "ConstanciasNoAdeudo.txt");

                string[] datos =
                {
            txtCodigoContribuyente.Text.Trim(),
            txtDniNoAdeudo.Text.Trim(),
            txtTelefonoNoAdeudo.Text.Trim(),
            dtpFecha.Value.ToString("yyyy-MM-dd"),
            txtNombreNoAdeudo.Text.Trim(),
            txtCorreoNoAdeudo.Text.Trim(),
            txtDomicilioNoAdeudo.Text.Trim(),
            txtPeriodos.Text.Trim(),
            txtUbicacionPredio.Text.Trim(),
            txtMotivo.Text.Trim(),
            rbTitular.Checked ? "Titular" : "Apoderado",
            string.Join(";",
                dgvAdjuntosNoAdeudo.Rows
                    .Cast<DataGridViewRow>()
                    .Where(f => !f.IsNewRow)
                    .Select(f => Convert.ToString(
                        f.Cells["colRutaArchivo"].Value)))
        };

                string registro = string.Join("|",
                    System.Array.ConvertAll(datos, dato =>
                        Convert.ToBase64String(
                            System.Text.Encoding.UTF8.GetBytes(dato ?? ""))));

                System.IO.File.AppendAllText(
                    ruta, registro + Environment.NewLine,
                    System.Text.Encoding.UTF8);

                MessageBox.Show(
                    "Solicitud de constancia guardada correctamente.",
                    "Guardado exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la solicitud: " + ex.Message);
            }
        }


        private void LimpiarFormularioNoAdeudo()
        {
            txtCodigoContribuyente.Clear();
            txtDniNoAdeudo.Clear();
            txtTelefonoNoAdeudo.Clear();
            txtNombreNoAdeudo.Clear();
            txtCorreoNoAdeudo.Clear();
            txtDomicilioNoAdeudo.Clear();

            txtPeriodos.Clear();
            txtUbicacionPredio.Clear();
            txtMotivo.Clear();

            dtpFecha.Value = DateTime.Today;

            chkNoAdeudo.Checked = true;
            rbTitular.Checked = true;
            rbApoderado.Checked = false;

            dgvAdjuntosNoAdeudo.Rows.Clear();

            txtCodigoContribuyente.Focus();
        }

        private void btnLimpiarNoAdeudo_Click(object sender, EventArgs e)
        {
            LimpiarFormularioNoAdeudo();
        }
    }
}

