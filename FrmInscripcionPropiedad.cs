namespace SistemaTramitesMunicipales
{
    public partial class FrmInscripcionPropiedad : Form
    {
        private bool inscripcionGuardada = false;
        public FrmInscripcionPropiedad()
        {
            InitializeComponent();
            ConfigurarCombosHR();
            ConfigurarTablaPrediosHR();
            ConfigurarRequisitos();

            dgvDocumentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocumentos.MultiSelect = false;
            dgvDocumentos.AllowUserToAddRows = false;
            dgvDocumentos.ReadOnly = true;
        }

        private void lblDniHR_Click(object sender, EventArgs e)
        {

        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            AvanzarPestana();
        }


        private void AvanzarPestana()
        {
            if (tabInscripcion.SelectedTab == tabHR)
            {
                if (!ValidarDatosHR())
                {
                    return;
                }
            }

            if (tabInscripcion.SelectedIndex <
                tabInscripcion.TabPages.Count - 1)
            {
                tabInscripcion.SelectedIndex++;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            RetrocederPestana();
        }

        private void RetrocederPestana()
        {
            if (tabInscripcion.SelectedIndex > 0)
            {
                tabInscripcion.SelectedIndex--;
            }
        }


        private bool ValidarDatosHR()
        {
            if (txtDniHR.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el DNI o RUC del contribuyente.");
                txtDniHR.Focus();
                return false;
            }

            if (!ValidarDniRucHR())
            {
                return false;
            }

            if (txtNombresHR.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese los apellidos y nombres del contribuyente.");
                txtNombresHR.Focus();
                return false;
            }

            if (txtTelefonoHR.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el teléfono del contribuyente.");
                txtTelefonoHR.Focus();
                return false;
            }

            if (!ValidarTelefonoHR())
            {
                return false;
            }

            if (txtCorreoHR.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el correo electrónico del contribuyente.");
                txtCorreoHR.Focus();
                return false;
            }

            if (!ValidarCorreoHR())
            {
                return false;
            }

            if (txtDomicilioHR.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el domicilio del contribuyente.");
                txtDomicilioHR.Focus();
                return false;
            }

            if (cboTipoDeclaracion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el tipo de declaración.");
                cboTipoDeclaracion.Focus();
                return false;
            }

            if (cboMotivoDeclaracion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el motivo de la declaración.");
                cboMotivoDeclaracion.Focus();
                return false;
            }

            return true;
        }


        private void ConfigurarCombosHR()
        {
            cboTipoDeclaracion.Items.Clear();
            cboTipoDeclaracion.Items.Add("Inscripción");
            cboTipoDeclaracion.Items.Add("Modificación");
            cboTipoDeclaracion.Items.Add("Descargo");

            cboMotivoDeclaracion.Items.Clear();
            cboMotivoDeclaracion.Items.Add("Adquisición de predio");
            cboMotivoDeclaracion.Items.Add("Transferencia de propiedad");
            cboMotivoDeclaracion.Items.Add("Modificación de características");
            cboMotivoDeclaracion.Items.Add("Regularización de datos");
        }


        private bool ValidarDniRucHR()
        {
            string documento = txtDniHR.Text.Trim();

            if (documento.Length != 8 && documento.Length != 11)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos o el RUC 11 dígitos.");
                txtDniHR.Focus();
                return false;
            }

            foreach (char caracter in documento)
            {
                if (!char.IsDigit(caracter))
                {
                    MessageBox.Show("El DNI o RUC solo debe contener números.");
                    txtDniHR.Focus();
                    return false;
                }
            }

            return true;
        }


        private bool ValidarTelefonoHR()
        {
            string telefono = txtTelefonoHR.Text.Trim();

            if (telefono.Length != 9)
            {
                MessageBox.Show("El teléfono debe tener 9 dígitos.");
                txtTelefonoHR.Focus();
                return false;
            }

            foreach (char caracter in telefono)
            {
                if (!char.IsDigit(caracter))
                {
                    MessageBox.Show("El teléfono solo debe contener números.");
                    txtTelefonoHR.Focus();
                    return false;
                }
            }

            return true;
        }


        private bool ValidarCorreoHR()
        {
            string correo = txtCorreoHR.Text.Trim();

            if (correo == "" ||
                !System.Text.RegularExpressions.Regex.IsMatch(
                    correo,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                txtCorreoHR.Focus();
                return false;
            }

            return true;
        }


        private void ConfigurarTablaPrediosHR()
        {
            dgvPrediosHR.AllowUserToAddRows = false;
            dgvPrediosHR.AllowUserToDeleteRows = false;
            dgvPrediosHR.ReadOnly = true;
            dgvPrediosHR.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvPrediosHR.MultiSelect = false;
            dgvPrediosHR.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvPrediosHR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RegistrarPredioDeclarado()
        {
            if (!ValidarDatosHR())
            {
                tabInscripcion.SelectedTab = tabHR;
                return;
            }

            if (txtCodigoPredio.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el código del predio.");
                tabInscripcion.SelectedTab = tabPU;
                txtCodigoPredio.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAutovaluo.Text))
            {
                MessageBox.Show("Primero debe calcular el autovalúo en la pestaña de construcción.");
                tabInscripcion.SelectedTab = tabConstruccion;
                return;
            }

            foreach (DataGridViewRow fila in dgvPrediosHR.Rows)
            {
                if (!fila.IsNewRow &&
                    Convert.ToString(fila.Cells["colCodigo"].Value) == txtCodigoPredio.Text.Trim())
                {
                    MessageBox.Show("Este predio ya está registrado.");
                    return;
                }
            }

            int anexo = dgvPrediosHR.Rows.Count + 1;

            dgvPrediosHR.Rows.Add(
                anexo,
                txtCodigoPredio.Text.Trim(),
                cboCondicion.Text == "Propietario único" ? "100" : "",
                txtAutovaluo.Text
            );

            MessageBox.Show("Predio agregado correctamente.");
        }

        private void btnRegistrarPredio_Click(object sender, EventArgs e)
        {
            RegistrarPredioDeclarado();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularAutovaluoEImpuesto();
        }

        private void CalcularAutovaluoEImpuesto()
        {
            decimal valorConstrucciones = CalcularValorConstrucciones();

            if (numArancel.Value <= 0 && valorConstrucciones <= 0)
            {
                MessageBox.Show(
                    "Ingrese el arancel o registre los valores de las construcciones."
                );
                return;
            }

            decimal areaTerreno = numAreaTerreno.Value;
            decimal autovaluoTerreno = areaTerreno * numArancel.Value;
            decimal autovaluoTotal = autovaluoTerreno + valorConstrucciones;

            txtAutovaluo.Text = autovaluoTotal.ToString("N2");

            MessageBox.Show(
                "Autovalúo calculado correctamente: S/ " +
                autovaluoTotal.ToString("N2")
            );
            ActualizarImpuestos();
        }

        private void btnAgregarCopropietario_Click(object sender, EventArgs e)
        {
            AgregarCopropietario();
        }


        private void AgregarCopropietario()
        {
            string dni = txtDniCopropietario.Text.Trim();
            string nombre = txtNombreCopropietario.Text.Trim();
            decimal porcentaje = numPorcentaje.Value;

            // Validar DNI o RUC
            if (dni.Length != 8 && dni.Length != 11)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos o el RUC 11 dígitos.");
                txtDniCopropietario.Focus();
                return;
            }

            if (!dni.All(char.IsDigit))
            {
                MessageBox.Show("El DNI o RUC solo debe contener números.");
                txtDniCopropietario.Focus();
                return;
            }

            // Validar nombre
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese el nombre del copropietario.");
                txtNombreCopropietario.Focus();
                return;
            }

            if (!nombre.Any(char.IsLetter))
            {
                MessageBox.Show("El nombre debe contener letras.");
                txtNombreCopropietario.Focus();
                return;
            }

            if (porcentaje <= 0 || porcentaje > 100)
            {
                MessageBox.Show("El porcentaje debe ser mayor que 0 y no superar el 100 %.");
                numPorcentaje.Focus();
                return;
            }

            foreach (DataGridViewRow fila in dgvCopropietarios.Rows)
            {
                if (!fila.IsNewRow &&
                    string.Equals(
                        Convert.ToString(fila.Cells["colDniCop"].Value),
                        dni,
                        StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Este copropietario ya está registrado.");
                    return;
                }
            }

            decimal total = porcentaje;

            foreach (DataGridViewRow fila in dgvCopropietarios.Rows)
            {
                if (!fila.IsNewRow &&
                    decimal.TryParse(
                        Convert.ToString(fila.Cells["colPorcentajeCop"].Value),
                        out decimal valor))
                {
                    total += valor;
                }
            }

            if (total > 100)
            {
                MessageBox.Show("La suma de los porcentajes no puede superar el 100 %.");
                return;
            }

            dgvCopropietarios.Rows.Add(dni, nombre, porcentaje);

            ActualizarTotalCopropietarios();

            txtDniCopropietario.Clear();
            txtNombreCopropietario.Clear();
            numPorcentaje.Value = numPorcentaje.Minimum;

            MessageBox.Show("Copropietario agregado correctamente.");
        }


        private void btnQuitarCopropietario_Click(object sender, EventArgs e)
        {
            QuitarCopropietario();
        }

        private void QuitarCopropietario()
        {
            if (dgvCopropietarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el copropietario que desea quitar.");
                return;
            }

            foreach (DataGridViewRow fila in dgvCopropietarios.SelectedRows)
            {
                if (!fila.IsNewRow)
                {
                    dgvCopropietarios.Rows.Remove(fila);
                }
            }

            MessageBox.Show("Copropietario quitado correctamente.");
        }

        private void btnAdjuntarDocumento_Click(object sender, EventArgs e)
        {
            AdjuntarDocumento();
        }

        private void AdjuntarDocumento()
        {
            ofdDocumento.Title = "Seleccionar documento";
            ofdDocumento.Filter =
                "Todos los archivos (*.*)|*.*";

            if (ofdDocumento.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string ruta = ofdDocumento.FileName;
            string nombre = System.IO.Path.GetFileName(ruta);

            foreach (DataGridViewRow fila in dgvDocumentos.Rows)
            {
                if (!fila.IsNewRow &&
                    Convert.ToString(fila.Cells["colRutaArchivo"].Value) == ruta)
                {
                    MessageBox.Show("Este documento ya fue adjuntado.");
                    return;
                }
            }

            dgvDocumentos.Rows.Add(nombre, ruta);

            MessageBox.Show("Documento adjuntado correctamente.");
        }

        private void btnQuitarDocumento_Click(object sender, EventArgs e)
        {
            QuitarDocumento();
        }

        private void QuitarDocumento()
        {
            if (dgvDocumentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el documento que desea quitar.");
                return;
            }

            foreach (DataGridViewRow fila in dgvDocumentos.SelectedRows)
            {
                if (!fila.IsNewRow)
                {
                    dgvDocumentos.Rows.Remove(fila);
                }
            }

            MessageBox.Show("Documento quitado correctamente.");
        }

        private void ConfigurarRequisitos()
        {
            clbRequisitos.Items.Clear();

            clbRequisitos.Items.Add("Documento de identidad del contribuyente");
            clbRequisitos.Items.Add("Documento que acredita la propiedad");
            clbRequisitos.Items.Add("HR - Hoja Resumen");
            clbRequisitos.Items.Add("PU - Predio Urbano");
            clbRequisitos.Items.Add("Comprobante de pago, si corresponde");
        }


        private bool ValidarDatosPredio()
        {
            if (string.IsNullOrWhiteSpace(txtCodigoPredio.Text) ||
                string.IsNullOrWhiteSpace(txtDireccionPredio.Text))
            {
                MessageBox.Show("Ingrese el código y la dirección del predio.");
                tabInscripcion.SelectedTab = tabPU;
                return false;
            }

            if (cboDistrito.SelectedIndex < 0 ||
                cboEstadoPredio.SelectedIndex < 0 ||
                cboTipoPredio.SelectedIndex < 0 ||
                cboUsoPredio.SelectedIndex < 0 ||
                cboCondicion.SelectedIndex < 0)
            {
                MessageBox.Show("Complete todos los campos de selección del predio.");
                tabInscripcion.SelectedTab = tabPU;
                return false;
            }

            if (numAreaTerreno.Value <= 0)
            {
                MessageBox.Show("El área del terreno debe ser mayor que cero.");
                tabInscripcion.SelectedTab = tabPU;
                numAreaTerreno.Focus();
                return false;
            }

            if (numAreaConstruida.Value < 0 || numNumeroPisos.Value < 0)
            {
                MessageBox.Show("Revise el área construida y el número de pisos.");
                tabInscripcion.SelectedTab = tabPU;
                return false;
            }

            return true;
        }


        private void GuardarInscripcion()
        {
            if (inscripcionGuardada)
            {
                MessageBox.Show("Esta inscripción ya fue guardada.");
                return;
            }
            if (!ValidarDatosHR())
            {
                tabInscripcion.SelectedTab = tabHR;
                return;
            }

            if (!ValidarDatosPredio())
            {
                return;
            }

            if (dgvPrediosHR.Rows.Count == 0)
            {
                MessageBox.Show("Debe registrar al menos un predio.");
                tabInscripcion.SelectedTab = tabPU;
                return;
            }

            if (!ValidarCopropietarios())
            {
                tabInscripcion.SelectedTab = tabCopropietarios;
                return;
            }

            if (!ValidarDocumentos())
            {
                tabInscripcion.SelectedTab = tabDocumentos;
                return;
            }

            if (dtpFechaCompra.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de compra no puede ser futura.");
                tabInscripcion.SelectedTab = tabDocumentos;
                dtpFechaCompra.Focus();
                return;
            }

            if (!CopiarDocumentosAdjuntos())
            {
                return;
            }

            string datos = PrepararDatosInscripcion();

            datos = Convert.ToBase64String(
                System.Text.Encoding.UTF8.GetBytes(datos)
            );

            if (GestionInscripciones.GuardarInscripcion(datos))
            {
                inscripcionGuardada = true;

                MessageBox.Show(
                    "Inscripción guardada correctamente.",
                    "Registro completado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }


        private void btnGuardarInscripcion_Click(object sender, EventArgs e)
        {
            GuardarInscripcion();
        }
        private decimal CalcularValorConstrucciones()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dgvConstrucciones.Rows)
            {
                if (fila.IsNewRow)
                {
                    continue;
                }

                if (decimal.TryParse(
                    Convert.ToString(fila.Cells["colValor"].Value),
                    out decimal valor))
                {
                    total += valor;
                }
            }

            return total;
        }
        private void EliminarConstruccion()
        {
            if (dgvConstrucciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione la construcción que desea eliminar.");
                return;
            }

            DataGridViewRow fila = dgvConstrucciones.SelectedRows[0];

            if (!fila.IsNewRow)
            {
                dgvConstrucciones.Rows.Remove(fila);

                CalcularAutovaluoEImpuesto();

                MessageBox.Show("Construcción eliminada correctamente.");
            }
        }

        private void btnEliminarConstruccion_Click(object sender, EventArgs e)
        {
            EliminarConstruccion();
        }
        private decimal CalcularImpuestoPredial(decimal autovaluo)
        {
            decimal uit = 5500m;
            decimal limite15UIT = 15 * uit;
            decimal limite60UIT = 60 * uit;
            decimal impuesto = 0;

            if (autovaluo <= 0)
            {
                return 0;
            }

            impuesto += Math.Min(autovaluo, limite15UIT) * 0.002m;

            if (autovaluo > limite15UIT)
            {
                impuesto +=
                    (Math.Min(autovaluo, limite60UIT) - limite15UIT)
                    * 0.006m;
            }

            if (autovaluo > limite60UIT)
            {
                impuesto += (autovaluo - limite60UIT) * 0.01m;
            }

            return impuesto;
        }

        private void ActualizarImpuestos()
        {
            if (!decimal.TryParse(txtAutovaluo.Text, out decimal autovaluo))
            {
                MessageBox.Show("Primero debe calcular el autovalúo.");
                return;
            }

            decimal impuestoAnual = CalcularImpuestoPredial(autovaluo);
            decimal impuestoTrimestral = impuestoAnual / 4;

            txtImpuestoAnual.Text = impuestoAnual.ToString("N2");
            txtImpuestoTrimestral.Text = impuestoTrimestral.ToString("N2");
        }

        private bool ValidarCopropietarios()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dgvCopropietarios.Rows)
            {
                if (fila.IsNewRow)
                {
                    continue;
                }

                if (!decimal.TryParse(
                    Convert.ToString(fila.Cells["colPorcentajeCop"].Value),
                    out decimal porcentaje))
                {
                    MessageBox.Show("Hay un porcentaje de copropiedad inválido.");
                    return false;
                }

                total += porcentaje;
            }

            if (dgvCopropietarios.Rows.Count > 0 && total != 100)
            {
                MessageBox.Show(
                    "La suma de los porcentajes de copropiedad debe ser exactamente 100 %."
                );
                tabInscripcion.SelectedTab = tabCopropietarios;
                return false;
            }

            return true;
        }
        private bool ValidarDocumentos()
        {
            if (dgvDocumentos.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Debe adjuntar los documentos requeridos.",
                    "Documentos pendientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                tabInscripcion.SelectedTab = tabDocumentos;
                return false;
            }

            if (clbRequisitos.CheckedItems.Count == 0)
            {
                MessageBox.Show(
                    "Marque los requisitos documentarios que ha verificado.",
                    "Requisitos pendientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                tabInscripcion.SelectedTab = tabDocumentos;
                return false;
            }

            return true;
        }



        private string PrepararDatosInscripcion()
        {
            string numeroExpediente =
                GestionInscripciones.GenerarNumeroExpediente();

            string datos = "Expediente=" + numeroExpediente;

            datos += "|FechaRegistro=" +
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // DATOS DEL CONTRIBUYENTE - HR
            datos += "|DNI=" + txtDniHR.Text.Trim();
            datos += "|Nombres=" + txtNombresHR.Text.Trim();
            datos += "|Telefono=" + txtTelefonoHR.Text.Trim();
            datos += "|Correo=" + txtCorreoHR.Text.Trim();
            datos += "|Domicilio=" + txtDomicilioHR.Text.Trim();
            datos += "|TipoDeclaracion=" + cboTipoDeclaracion.Text;
            datos += "|Motivo=" + cboMotivoDeclaracion.Text;

            // DATOS DEL PREDIO - PU
            datos += "|CodigoPredio=" + txtCodigoPredio.Text.Trim();
            datos += "|DireccionPredio=" + txtDireccionPredio.Text.Trim();
            datos += "|Distrito=" + cboDistrito.Text;
            datos += "|EstadoPredio=" + cboEstadoPredio.Text;
            datos += "|TipoPredio=" + cboTipoPredio.Text;
            datos += "|UsoPredio=" + cboUsoPredio.Text;
            datos += "|Condicion=" + cboCondicion.Text;
            datos += "|AreaTerreno=" + numAreaTerreno.Value;
            datos += "|AreaConstruida=" + numAreaConstruida.Value;
            datos += "|NumeroPisos=" + numNumeroPisos.Value;

            // FECHA DE COMPRA Y VALORES
            datos += "|FechaCompra=" +
                dtpFechaCompra.Value.ToString("yyyy-MM-dd");
            datos += "|Autovaluo=" + txtAutovaluo.Text;
            datos += "|ImpuestoAnual=" + txtImpuestoAnual.Text;
            datos += "|ImpuestoTrimestral=" + txtImpuestoTrimestral.Text;

            // PREDIOS DECLARADOS
            string predios = "";

            foreach (DataGridViewRow fila in dgvPrediosHR.Rows)
            {
                if (fila.IsNewRow) continue;

                if (predios != "") predios += ";";

                predios += Convert.ToString(fila.Cells["colAnexo"].Value)
                    + "," + Convert.ToString(fila.Cells["colCodigo"].Value)
                    + "," + Convert.ToString(fila.Cells["colCondominio"].Value)
                    + "," + Convert.ToString(fila.Cells["colAutovaluo"].Value);
            }

            datos += "|Predios=" + predios;

            // CONSTRUCCIONES
            string construcciones = "";

            foreach (DataGridViewRow fila in dgvConstrucciones.Rows)
            {
                if (fila.IsNewRow) continue;

                if (construcciones != "") construcciones += ";";

                construcciones += Convert.ToString(fila.Cells["colPiso"].Value)
                    + "," + Convert.ToString(fila.Cells["colAntiguedad"].Value)
                    + "," + Convert.ToString(fila.Cells["colCategorias"].Value)
                    + "," + Convert.ToString(fila.Cells["colArea"].Value)
                    + "," + Convert.ToString(fila.Cells["colValor"].Value);
            }

            datos += "|Construcciones=" + construcciones;

            // COPROPIETARIOS
            string copropietarios = "";

            foreach (DataGridViewRow fila in dgvCopropietarios.Rows)
            {
                if (fila.IsNewRow) continue;

                if (copropietarios != "") copropietarios += ";";

                copropietarios += Convert.ToString(fila.Cells["colDniCop"].Value)
                    + "," + Convert.ToString(fila.Cells["colNombreCop"].Value)
                    + "," + Convert.ToString(fila.Cells["colPorcentajeCop"].Value);
            }

            datos += "|Copropietarios=" + copropietarios;

            // DOCUMENTOS ADJUNTOS
            string documentos = "";

            foreach (DataGridViewRow fila in dgvDocumentos.Rows)
            {
                if (fila.IsNewRow) continue;

                if (documentos != "") documentos += ";";

                documentos += Convert.ToString(
                    fila.Cells["colNombreArchivo"].Value)
                    + "," + Convert.ToString(
                    fila.Cells["colRutaArchivo"].Value);
            }

            datos += "|Documentos=" + documentos;
            // REQUISITOS DOCUMENTARIOS VERIFICADOS
            string requisitos = "";

            foreach (object requisito in clbRequisitos.CheckedItems)
            {
                if (requisitos != "")
                    requisitos += ";";

                requisitos += requisito.ToString();
            }

            datos += "|RequisitosVerificados=" + requisitos;

            return datos;
        }



        private bool CopiarDocumentosAdjuntos()
        {
            try
            {
                string carpetaDocumentos = System.IO.Path.Combine(
                    Application.StartupPath,
                    "Datos",
                    "Documentos"
                );

                System.IO.Directory.CreateDirectory(carpetaDocumentos);

                foreach (DataGridViewRow fila in dgvDocumentos.Rows)
                {
                    if (fila.IsNewRow)
                        continue;

                    string rutaOriginal = Convert.ToString(
                        fila.Cells["colRutaArchivo"].Value
                    );

                    if (string.IsNullOrWhiteSpace(rutaOriginal) ||
                        !System.IO.File.Exists(rutaOriginal))
                    {
                        MessageBox.Show(
                            "No se encuentra uno de los documentos adjuntos:\n" +
                            rutaOriginal
                        );
                        return false;
                    }

                    // Si el archivo ya está en la carpeta permanente,
                    // no se vuelve a copiar.
                    string rutaActual = System.IO.Path.GetFullPath(rutaOriginal);
                    string rutaCarpeta = System.IO.Path.GetFullPath(carpetaDocumentos);

                    if (rutaActual.StartsWith(
                        rutaCarpeta + System.IO.Path.DirectorySeparatorChar,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    string nombre = System.IO.Path.GetFileName(rutaOriginal);

                    string destino = System.IO.Path.Combine(
                        carpetaDocumentos,
                        Guid.NewGuid().ToString("N") + "_" + nombre
                    );

                    System.IO.File.Copy(rutaOriginal, destino);

                    fila.Cells["colRutaArchivo"].Value = destino;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al copiar los documentos: " + ex.Message
                );
                return false;
            }
        }

        private string CodificarDato(string dato)
        {
            return Convert.ToBase64String(
                System.Text.Encoding.UTF8.GetBytes(dato ?? "")
            );
        }

        private void lblTotalPorcentaje_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarTotalCopropietarios()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dgvCopropietarios.Rows)
            {
                if (!fila.IsNewRow &&
                    decimal.TryParse(
                        Convert.ToString(fila.Cells["colPorcentajeCop"].Value),
                        out decimal porcentaje))
                {
                    total += porcentaje;
                }
            }

            lblTotalPorcentaje.Text = "Total: " + total.ToString("0.##") + " %";
        }

        private void txtNombresHR_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (ConfirmarRegreso())
            {
                RegresarMenuSeleccion();
            }
        }


        private bool ConfirmarRegreso()
        {
            DialogResult respuesta = MessageBox.Show(
                "Si tienes cambios sin guardar o una inscripción sin registrar, estos se perderán al regresar al menú de selección. ¿Deseas continuar?",
                "Confirmar regreso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            return respuesta == DialogResult.Yes;
        }


        private void RegresarMenuSeleccion()
        {
            FrmPrincipal principal = this.MdiParent as FrmPrincipal;

            if (principal != null)
            {
                principal.AbrirFormulario(new FrmNuevoTramite());
            }
            else
            {
                MessageBox.Show("No se encontró el formulario principal.");
            }
        }


    }
}
