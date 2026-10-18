
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SistemaTramitesMunicipales
{
    public partial class FrmConsultarTramites : Form
    {
        // ==================== ATRIBUTOS Y RUTAS ====================
        private readonly string carpetaDatos =
            Path.Combine(Application.StartupPath, "Datos");

        private string RutaInscripciones =>
            Path.Combine(carpetaDatos, "Inscripciones.txt");

        private string RutaEstados =>
            Path.Combine(carpetaDatos, "EstadosTramites.txt");

        private List<Dictionary<string, string>> tramites =
            new List<Dictionary<string, string>>();

        // ==================== CONSTRUCTOR ====================
        public FrmConsultarTramites()
        {
            InitializeComponent();
            ConfigurarConsulta();
        }

        // ==================== BOTONES Y EVENTOS ====================
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            RegresarMenuPrincipal();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarTramites();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            VerDetalleTramite();
        }

        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            ActualizarEstadoTramite();
        }

        private void lblBuscarExpediente_Click(object sender, EventArgs e) { }
        private void lblBuscarDni_Click(object sender, EventArgs e) { }
        private void lblBuscarTipo_Click(object sender, EventArgs e) { }
        private void lblBuscarEstado_Click(object sender, EventArgs e) { }

        private void txtBuscarExpediente_TextChanged(object sender, EventArgs e) { }
        private void txtBuscarDni_TextChanged(object sender, EventArgs e) { }

        private void cboBuscarTipo_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cboBuscarEstado_SelectedIndexChanged(object sender, EventArgs e) { }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void lblCambiarEstado_Click(object sender, EventArgs e) { }
        private void cboNuevoEstado_SelectedIndexChanged(object sender, EventArgs e) { }

        // ==================== MÉTODOS VOID ====================
        private void RegresarMenuPrincipal()
        {
            FrmPrincipal principal = MdiParent as FrmPrincipal;

            if (principal != null)
                principal.AbrirFormulario(new FrmMenuPrincipal());
            else
                MessageBox.Show("No se encontró el formulario principal.");
        }

        private void BuscarTramites()
        {
            try
            {
                tramites = LeerInscripciones();
                tramites.AddRange(LeerConstancias());

                string expediente = txtBuscarExpediente.Text.Trim();
                string dni = txtBuscarDni.Text.Trim();
                string tipo = Convert.ToString(cboBuscarTipo.SelectedItem);
                string estado = Convert.ToString(cboBuscarEstado.SelectedItem);

                var filtrados = tramites.Where(r =>
                    (expediente == "" ||
                     ObtenerValor(r, "Expediente").Contains(
                         expediente, StringComparison.OrdinalIgnoreCase)) &&

                    (dni == "" ||
                     ObtenerValor(r, "DNI").Contains(
                         dni, StringComparison.OrdinalIgnoreCase)) &&

                    (tipo == "Todos" ||
                     ObtenerValor(r, "Tipo") == tipo) &&

                    (estado == "Todos" ||
                     ObtenerValor(r, "Estado") == estado)
                ).ToList();

                dgvResultados.Rows.Clear();

                foreach (var r in filtrados)
                {
                    string codigo = ObtenerValor(r, "Expediente");

                    dgvResultados.Rows.Add(
                        string.IsNullOrWhiteSpace(codigo)
                            ? "(Sin código)"
                            : codigo,
                        ObtenerValor(r, "Tipo"),
                        ObtenerValor(r, "DNI"),
                        ObtenerValor(r, "Nombres"),
                        ObtenerValor(r, "FechaRegistro"),
                        ObtenerValor(r, "Estado")
                    );
                }

                if (filtrados.Count == 0)
                    MessageBox.Show("No se encontraron trámites con esos filtros.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al consultar los trámites: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void VerDetalleTramite()
        {
            if (dgvResultados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un trámite.");
                return;
            }

            DataGridViewRow fila = dgvResultados.SelectedRows[0];

            string detalle =
                "Expediente: " + fila.Cells[0].Value +
                "\nTrámite: " + fila.Cells[1].Value +
                "\nDNI / RUC: " + fila.Cells[2].Value +
                "\nContribuyente: " + fila.Cells[3].Value +
                "\nFecha: " + fila.Cells[4].Value +
                "\nEstado: " + fila.Cells[5].Value;

            MessageBox.Show(detalle, "Detalle del trámite");
        }

        private void ActualizarEstadoTramite()
        {
            if (dgvResultados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un trámite.");
                return;
            }

            string nuevoEstado = cboNuevoEstado.Text.Trim();

            if (string.IsNullOrWhiteSpace(nuevoEstado))
            {
                MessageBox.Show("Seleccione un estado válido.");
                return;
            }

            DataGridViewRow fila = dgvResultados.SelectedRows[0];
            string expediente = Convert.ToString(fila.Cells[0].Value);

            var registro = tramites.FirstOrDefault(r =>
                (ObtenerValor(r, "Expediente") == expediente) ||
                (string.IsNullOrWhiteSpace(ObtenerValor(r, "Expediente")) &&
                 expediente == "(Sin código)" &&
                 ObtenerValor(r, "DNI") ==
                     Convert.ToString(fila.Cells[2].Value) &&
                 ObtenerValor(r, "FechaRegistro") ==
                     Convert.ToString(fila.Cells[4].Value)));

            if (registro == null)
            {
                MessageBox.Show("No se pudo identificar el trámite seleccionado.");
                return;
            }

            try
            {
                string clave = ObtenerClaveEstado(registro);
                GuardarEstado(clave, nuevoEstado);

                registro["Estado"] = nuevoEstado;
                fila.Cells[5].Value = nuevoEstado;

                MessageBox.Show(
                    "Estado actualizado y guardado correctamente.",
                    "Trámite actualizado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo guardar el estado: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigurarConsulta()
        {
            cboBuscarTipo.Items.Clear();
            cboBuscarTipo.Items.AddRange(new object[]
            {
                "Todos",
                "Inscripción de propiedad",
                "Constancia de no adeudo"
            });
            cboBuscarTipo.SelectedIndex = 0;

            cboBuscarEstado.Items.Clear();
            cboBuscarEstado.Items.AddRange(new object[]
            {
                "Todos",
                "Registrado",
                "En revisión",
                "Aprobado",
                "Observado",
                "Rechazado"
            });
            cboBuscarEstado.SelectedIndex = 0;

            cboNuevoEstado.Items.Clear();
            cboNuevoEstado.Items.AddRange(new object[]
            {
                "Registrado",
                "En revisión",
                "Aprobado",
                "Observado",
                "Rechazado"
            });

            dgvResultados.ReadOnly = true;
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvResultados.MultiSelect = false;
        }

        private void GuardarEstado(string clave, string estado)
        {
            Directory.CreateDirectory(carpetaDatos);

            var estados = LeerEstados();
            estados[clave] = estado;

            var lineas = estados.Select(par =>
                Convert.ToBase64String(
                    Encoding.UTF8.GetBytes(par.Key)) + "|" +
                Convert.ToBase64String(
                    Encoding.UTF8.GetBytes(par.Value)));

            File.WriteAllLines(RutaEstados, lineas, Encoding.UTF8);
        }

        // ==================== MÉTODOS CON RETORNO ====================
        private string ObtenerValor(
            Dictionary<string, string> registro, string clave)
        {
            return registro.TryGetValue(clave, out string valor)
                ? valor
                : "";
        }

        private string ObtenerClaveEstado(
            Dictionary<string, string> registro)
        {
            string expediente = ObtenerValor(registro, "Expediente");

            if (!string.IsNullOrWhiteSpace(expediente))
                return expediente;

            // Identificador para registros antiguos sin expediente.
            return "LEGACY:" +
                ObtenerValor(registro, "DNI") + ":" +
                ObtenerValor(registro, "FechaRegistro");
        }

        private Dictionary<string, string> LeerCampos(string contenido)
        {
            var registro = new Dictionary<string, string>(
                StringComparer.OrdinalIgnoreCase);

            foreach (string campo in contenido.Split('|'))
            {
                int separador = campo.IndexOf('=');

                if (separador <= 0)
                    continue;

                string clave = campo.Substring(0, separador);
                string valor = campo.Substring(separador + 1);
                registro[clave] = valor;
            }

            return registro;
        }

        private List<Dictionary<string, string>> LeerInscripciones()
        {
            var resultados = new List<Dictionary<string, string>>();

            if (!File.Exists(RutaInscripciones))
                return resultados;

            Dictionary<string, string> estados = LeerEstados();
            int numeroExpediente = 1;

            foreach (string linea in File.ReadAllLines(RutaInscripciones))
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                string contenido;

                try
                {
                    contenido = Encoding.UTF8.GetString(
                        Convert.FromBase64String(linea.Trim()));
                }
                catch (FormatException)
                {
                    contenido = linea;
                }

                var registro = LeerCampos(contenido);

                if (!registro.ContainsKey("DNI") &&
                    !registro.ContainsKey("Nombres"))
                    continue;

                // Asignar un código a los registros antiguos que no lo tengan.
                if (!registro.TryGetValue("Expediente", out string expediente) ||
                    string.IsNullOrWhiteSpace(expediente))
                {
                    expediente = numeroExpediente.ToString("D6");
                    registro["Expediente"] = expediente;
                }

                registro["Tipo"] = "Inscripción de propiedad";

                string clave = ObtenerClaveEstado(registro);

                registro["Estado"] = estados.TryGetValue(
                    clave, out string estado)
                    ? estado
                    : "Registrado";

                resultados.Add(registro);
                numeroExpediente++;
            }

            return resultados;
        }

        private Dictionary<string, string> LeerEstados()
        {
            var estados = new Dictionary<string, string>(
                StringComparer.OrdinalIgnoreCase);

            if (!File.Exists(RutaEstados))
                return estados;

            foreach (string linea in File.ReadAllLines(RutaEstados))
            {
                string[] partes = linea.Split('|');

                if (partes.Length != 2)
                    continue;

                try
                {
                    string clave = Encoding.UTF8.GetString(
                        Convert.FromBase64String(partes[0]));

                    string estado = Encoding.UTF8.GetString(
                        Convert.FromBase64String(partes[1]));

                    estados[clave] = estado;
                }
                catch (FormatException)
                {
                    // Ignora líneas dañadas del archivo de estados.
                }
            }

            return estados;
        }

        private List<Dictionary<string, string>> LeerConstancias()
        {
            var resultados = new List<Dictionary<string, string>>();

            string ruta = Path.Combine(
                carpetaDatos, "ConstanciasNoAdeudo.txt");

            if (!File.Exists(ruta))
                return resultados;

            int numero = 1;

            foreach (string linea in File.ReadAllLines(ruta))
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                string[] campos = linea.Split('|');

                string[] nombres =
                {
                    "CodigoContribuyente",
                    "DNI",
                    "Telefono",
                    "FechaRegistro",
                    "Nombres",
                    "Correo",
                    "Domicilio",
                    "Periodos",
                    "UbicacionPredio",
                    "Motivo",
                    "Representante",
                    "Adjuntos"
                };

                var registro = new Dictionary<string, string>(
                    StringComparer.OrdinalIgnoreCase);

                for (int i = 0; i < campos.Length; i++)
                {
                    string valor;

                    try
                    {
                        valor = Encoding.UTF8.GetString(
                            Convert.FromBase64String(campos[i]));
                    }
                    catch (FormatException)
                    {
                        valor = campos[i];
                    }

                    string clave = i < nombres.Length
                        ? nombres[i]
                        : "Campo" + (i + 1);

                    registro[clave] = valor;
                }

                registro["Expediente"] =
                    "CN" + numero.ToString("D4");

                registro["Tipo"] = "Constancia de no adeudo";
                registro["Estado"] = "Registrado";

                // Campos que utiliza la tabla de consulta.
                registro["Nombres"] =
                    registro.TryGetValue("Nombres", out string nombre)
                        ? nombre
                        : "";

                registro["FechaRegistro"] =
                    registro.TryGetValue("FechaRegistro", out string fecha)
                        ? fecha
                        : "";

                resultados.Add(registro);
                numero++;
            }

            return resultados;
        }
    }
}
