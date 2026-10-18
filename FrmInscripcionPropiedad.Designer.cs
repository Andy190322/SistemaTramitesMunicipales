namespace SistemaTramitesMunicipales
{
    partial class FrmInscripcionPropiedad
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            tabInscripcion = new TabControl();
            tabHR = new TabPage();
            lblDniHR = new Label();
            txtDniHR = new TextBox();
            lblNombresHR = new Label();
            txtNombresHR = new TextBox();
            lblTelefonoHR = new Label();
            txtTelefonoHR = new TextBox();
            lblCorreoHR = new Label();
            txtCorreoHR = new TextBox();
            lblDomicilioHR = new Label();
            txtDomicilioHR = new TextBox();
            lblTipoDeclaracion = new Label();
            cboTipoDeclaracion = new ComboBox();
            lblMotivoDeclaracion = new Label();
            cboMotivoDeclaracion = new ComboBox();
            lblImpuestoAnual = new Label();
            txtImpuestoAnual = new TextBox();
            lblImpuestoTrimestral = new Label();
            txtImpuestoTrimestral = new TextBox();
            lblPrediosHR = new Label();
            dgvPrediosHR = new DataGridView();
            colAnexo = new DataGridViewTextBoxColumn();
            colCodigo = new DataGridViewTextBoxColumn();
            colCondominio = new DataGridViewTextBoxColumn();
            colAutovaluo = new DataGridViewTextBoxColumn();
            tabPU = new TabPage();
            btnRegistrarPredio = new Button();
            lblCodigoPredio = new Label();
            txtCodigoPredio = new TextBox();
            lblDireccionPredio = new Label();
            txtDireccionPredio = new TextBox();
            lblDistrito = new Label();
            cboDistrito = new ComboBox();
            lblEstadoPredio = new Label();
            cboEstadoPredio = new ComboBox();
            lblTipoPredio = new Label();
            cboTipoPredio = new ComboBox();
            lblUsoPredio = new Label();
            cboUsoPredio = new ComboBox();
            lblCondicion = new Label();
            cboCondicion = new ComboBox();
            lblAreaTerreno = new Label();
            numAreaTerreno = new NumericUpDown();
            lblAreaConstruida = new Label();
            numAreaConstruida = new NumericUpDown();
            lblNumeroPisos = new Label();
            numNumeroPisos = new NumericUpDown();
            tabConstruccion = new TabPage();
            lblInstruccion = new Label();
            dgvConstrucciones = new DataGridView();
            colPiso = new DataGridViewTextBoxColumn();
            colAntiguedad = new DataGridViewTextBoxColumn();
            colCategorias = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            lblArancel = new Label();
            numArancel = new NumericUpDown();
            lblAutovaluo = new Label();
            txtAutovaluo = new TextBox();
            btnCalcular = new Button();
            btnEliminarConstruccion = new Button();
            lblEscala = new Label();
            lblNotaValores = new Label();
            tabCopropietarios = new TabPage();
            lblDniCopropietario = new Label();
            txtDniCopropietario = new TextBox();
            lblNombreCopropietario = new Label();
            txtNombreCopropietario = new TextBox();
            lblPorcentaje = new Label();
            numPorcentaje = new NumericUpDown();
            btnAgregarCopropietario = new Button();
            btnQuitarCopropietario = new Button();
            dgvCopropietarios = new DataGridView();
            colDniCop = new DataGridViewTextBoxColumn();
            colNombreCop = new DataGridViewTextBoxColumn();
            colPorcentajeCop = new DataGridViewTextBoxColumn();
            lblTotalPorcentaje = new Label();
            tabDocumentos = new TabPage();
            lblRequisitos = new Label();
            clbRequisitos = new CheckedListBox();
            lblFechaCompra = new Label();
            dtpFechaCompra = new DateTimePicker();
            lblMulta = new Label();
            btnAdjuntarDocumento = new Button();
            btnQuitarDocumento = new Button();
            dgvDocumentos = new DataGridView();
            colNombreArchivo = new DataGridViewTextBoxColumn();
            colRutaArchivo = new DataGridViewTextBoxColumn();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            btnGuardarInscripcion = new Button();
            ofdDocumento = new OpenFileDialog();
            btnRegresar = new Button();
            tabInscripcion.SuspendLayout();
            tabHR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrediosHR).BeginInit();
            tabPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAreaTerreno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAreaConstruida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNumeroPisos).BeginInit();
            tabConstruccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConstrucciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numArancel).BeginInit();
            tabCopropietarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPorcentaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCopropietarios).BeginInit();
            tabDocumentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).BeginInit();
            SuspendLayout();
            // 
            // tabInscripcion
            // 
            tabInscripcion.Controls.Add(tabHR);
            tabInscripcion.Controls.Add(tabPU);
            tabInscripcion.Controls.Add(tabConstruccion);
            tabInscripcion.Controls.Add(tabCopropietarios);
            tabInscripcion.Controls.Add(tabDocumentos);
            tabInscripcion.Location = new Point(10, 10);
            tabInscripcion.Name = "tabInscripcion";
            tabInscripcion.SelectedIndex = 0;
            tabInscripcion.Size = new Size(1110, 600);
            tabInscripcion.TabIndex = 0;
            // 
            // tabHR
            // 
            tabHR.Controls.Add(lblDniHR);
            tabHR.Controls.Add(txtDniHR);
            tabHR.Controls.Add(lblNombresHR);
            tabHR.Controls.Add(txtNombresHR);
            tabHR.Controls.Add(lblTelefonoHR);
            tabHR.Controls.Add(txtTelefonoHR);
            tabHR.Controls.Add(lblCorreoHR);
            tabHR.Controls.Add(txtCorreoHR);
            tabHR.Controls.Add(lblDomicilioHR);
            tabHR.Controls.Add(txtDomicilioHR);
            tabHR.Controls.Add(lblTipoDeclaracion);
            tabHR.Controls.Add(cboTipoDeclaracion);
            tabHR.Controls.Add(lblMotivoDeclaracion);
            tabHR.Controls.Add(cboMotivoDeclaracion);
            tabHR.Controls.Add(lblImpuestoAnual);
            tabHR.Controls.Add(txtImpuestoAnual);
            tabHR.Controls.Add(lblImpuestoTrimestral);
            tabHR.Controls.Add(txtImpuestoTrimestral);
            tabHR.Controls.Add(lblPrediosHR);
            tabHR.Controls.Add(dgvPrediosHR);
            tabHR.Location = new Point(4, 26);
            tabHR.Name = "tabHR";
            tabHR.Padding = new Padding(3);
            tabHR.Size = new Size(1102, 570);
            tabHR.TabIndex = 1;
            tabHR.Text = "1. Contribuyente (H.R.)";
            tabHR.UseVisualStyleBackColor = true;
            // 
            // lblDniHR
            // 
            lblDniHR.Location = new Point(20, 20);
            lblDniHR.Name = "lblDniHR";
            lblDniHR.Size = new Size(300, 20);
            lblDniHR.TabIndex = 6;
            lblDniHR.Text = "DNI / RUC";
            lblDniHR.Click += lblDniHR_Click;
            // 
            // txtDniHR
            // 
            txtDniHR.Location = new Point(20, 42);
            txtDniHR.Name = "txtDniHR";
            txtDniHR.Size = new Size(300, 24);
            txtDniHR.TabIndex = 7;
            // 
            // lblNombresHR
            // 
            lblNombresHR.Location = new Point(350, 20);
            lblNombresHR.Name = "lblNombresHR";
            lblNombresHR.Size = new Size(400, 20);
            lblNombresHR.TabIndex = 8;
            lblNombresHR.Text = "Apellidos y nombres o razón social";
            // 
            // txtNombresHR
            // 
            txtNombresHR.Location = new Point(350, 42);
            txtNombresHR.Name = "txtNombresHR";
            txtNombresHR.Size = new Size(400, 24);
            txtNombresHR.TabIndex = 9;
            txtNombresHR.TextChanged += txtNombresHR_TextChanged;
            // 
            // lblTelefonoHR
            // 
            lblTelefonoHR.Location = new Point(20, 80);
            lblTelefonoHR.Name = "lblTelefonoHR";
            lblTelefonoHR.Size = new Size(300, 20);
            lblTelefonoHR.TabIndex = 10;
            lblTelefonoHR.Text = "Teléfono";
            // 
            // txtTelefonoHR
            // 
            txtTelefonoHR.Location = new Point(20, 102);
            txtTelefonoHR.Name = "txtTelefonoHR";
            txtTelefonoHR.Size = new Size(300, 24);
            txtTelefonoHR.TabIndex = 11;
            // 
            // lblCorreoHR
            // 
            lblCorreoHR.Location = new Point(350, 80);
            lblCorreoHR.Name = "lblCorreoHR";
            lblCorreoHR.Size = new Size(400, 20);
            lblCorreoHR.TabIndex = 12;
            lblCorreoHR.Text = "Correo electrónico";
            // 
            // txtCorreoHR
            // 
            txtCorreoHR.Location = new Point(350, 102);
            txtCorreoHR.Name = "txtCorreoHR";
            txtCorreoHR.Size = new Size(400, 24);
            txtCorreoHR.TabIndex = 13;
            // 
            // lblDomicilioHR
            // 
            lblDomicilioHR.Location = new Point(20, 140);
            lblDomicilioHR.Name = "lblDomicilioHR";
            lblDomicilioHR.Size = new Size(730, 20);
            lblDomicilioHR.TabIndex = 14;
            lblDomicilioHR.Text = "Domicilio fiscal";
            // 
            // txtDomicilioHR
            // 
            txtDomicilioHR.Location = new Point(20, 162);
            txtDomicilioHR.Name = "txtDomicilioHR";
            txtDomicilioHR.Size = new Size(730, 24);
            txtDomicilioHR.TabIndex = 15;
            // 
            // lblTipoDeclaracion
            // 
            lblTipoDeclaracion.Location = new Point(20, 200);
            lblTipoDeclaracion.Name = "lblTipoDeclaracion";
            lblTipoDeclaracion.Size = new Size(300, 20);
            lblTipoDeclaracion.TabIndex = 16;
            lblTipoDeclaracion.Text = "Tipo de declaración jurada";
            // 
            // cboTipoDeclaracion
            // 
            cboTipoDeclaracion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDeclaracion.FormattingEnabled = true;
            cboTipoDeclaracion.Items.AddRange(new object[] { "Determinativa - Sustitutoria", "Determinativa - Rectificatoria", "Informativa", "Masiva" });
            cboTipoDeclaracion.Location = new Point(20, 222);
            cboTipoDeclaracion.Name = "cboTipoDeclaracion";
            cboTipoDeclaracion.Size = new Size(300, 25);
            cboTipoDeclaracion.TabIndex = 17;
            // 
            // lblMotivoDeclaracion
            // 
            lblMotivoDeclaracion.Location = new Point(350, 200);
            lblMotivoDeclaracion.Name = "lblMotivoDeclaracion";
            lblMotivoDeclaracion.Size = new Size(400, 20);
            lblMotivoDeclaracion.TabIndex = 18;
            lblMotivoDeclaracion.Text = "Motivo de la declaración";
            // 
            // cboMotivoDeclaracion
            // 
            cboMotivoDeclaracion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMotivoDeclaracion.FormattingEnabled = true;
            cboMotivoDeclaracion.Items.AddRange(new object[] { "Inscripción", "Aumento de valor", "Disminución de valor", "Compra", "Venta", "Masiva", "Descargo", "Rectificación", "Otros" });
            cboMotivoDeclaracion.Location = new Point(350, 222);
            cboMotivoDeclaracion.Name = "cboMotivoDeclaracion";
            cboMotivoDeclaracion.Size = new Size(400, 25);
            cboMotivoDeclaracion.TabIndex = 19;
            // 
            // lblImpuestoAnual
            // 
            lblImpuestoAnual.Location = new Point(790, 20);
            lblImpuestoAnual.Name = "lblImpuestoAnual";
            lblImpuestoAnual.Size = new Size(250, 20);
            lblImpuestoAnual.TabIndex = 20;
            lblImpuestoAnual.Text = "Impuesto anual (calculado)";
            // 
            // txtImpuestoAnual
            // 
            txtImpuestoAnual.Location = new Point(790, 42);
            txtImpuestoAnual.Name = "txtImpuestoAnual";
            txtImpuestoAnual.ReadOnly = true;
            txtImpuestoAnual.Size = new Size(250, 24);
            txtImpuestoAnual.TabIndex = 21;
            // 
            // lblImpuestoTrimestral
            // 
            lblImpuestoTrimestral.Location = new Point(790, 80);
            lblImpuestoTrimestral.Name = "lblImpuestoTrimestral";
            lblImpuestoTrimestral.Size = new Size(250, 20);
            lblImpuestoTrimestral.TabIndex = 22;
            lblImpuestoTrimestral.Text = "Impuesto trimestral (anual / 4)";
            // 
            // txtImpuestoTrimestral
            // 
            txtImpuestoTrimestral.Location = new Point(790, 102);
            txtImpuestoTrimestral.Name = "txtImpuestoTrimestral";
            txtImpuestoTrimestral.ReadOnly = true;
            txtImpuestoTrimestral.Size = new Size(250, 24);
            txtImpuestoTrimestral.TabIndex = 23;
            // 
            // lblPrediosHR
            // 
            lblPrediosHR.Location = new Point(20, 265);
            lblPrediosHR.Name = "lblPrediosHR";
            lblPrediosHR.Size = new Size(500, 20);
            lblPrediosHR.TabIndex = 24;
            lblPrediosHR.Text = "Predios declarados";
            // 
            // dgvPrediosHR
            // 
            dgvPrediosHR.AllowUserToAddRows = false;
            dgvPrediosHR.AllowUserToDeleteRows = false;
            dgvPrediosHR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrediosHR.BackgroundColor = Color.White;
            dgvPrediosHR.Columns.AddRange(new DataGridViewColumn[] { colAnexo, colCodigo, colCondominio, colAutovaluo });
            dgvPrediosHR.Location = new Point(20, 288);
            dgvPrediosHR.MultiSelect = false;
            dgvPrediosHR.Name = "dgvPrediosHR";
            dgvPrediosHR.ReadOnly = true;
            dgvPrediosHR.RowHeadersVisible = false;
            dgvPrediosHR.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrediosHR.Size = new Size(1040, 220);
            dgvPrediosHR.TabIndex = 25;
            dgvPrediosHR.CellContentClick += dgvPrediosHR_CellContentClick;
            // 
            // colAnexo
            // 
            colAnexo.HeaderText = "Anexo N°";
            colAnexo.Name = "colAnexo";
            colAnexo.ReadOnly = true;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código del predio";
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colCondominio
            // 
            colCondominio.HeaderText = "% Condominio";
            colCondominio.Name = "colCondominio";
            colCondominio.ReadOnly = true;
            // 
            // colAutovaluo
            // 
            colAutovaluo.HeaderText = "Autovalúo";
            colAutovaluo.Name = "colAutovaluo";
            colAutovaluo.ReadOnly = true;
            // 
            // tabPU
            // 
            tabPU.Controls.Add(btnRegistrarPredio);
            tabPU.Controls.Add(lblCodigoPredio);
            tabPU.Controls.Add(txtCodigoPredio);
            tabPU.Controls.Add(lblDireccionPredio);
            tabPU.Controls.Add(txtDireccionPredio);
            tabPU.Controls.Add(lblDistrito);
            tabPU.Controls.Add(cboDistrito);
            tabPU.Controls.Add(lblEstadoPredio);
            tabPU.Controls.Add(cboEstadoPredio);
            tabPU.Controls.Add(lblTipoPredio);
            tabPU.Controls.Add(cboTipoPredio);
            tabPU.Controls.Add(lblUsoPredio);
            tabPU.Controls.Add(cboUsoPredio);
            tabPU.Controls.Add(lblCondicion);
            tabPU.Controls.Add(cboCondicion);
            tabPU.Controls.Add(lblAreaTerreno);
            tabPU.Controls.Add(numAreaTerreno);
            tabPU.Controls.Add(lblAreaConstruida);
            tabPU.Controls.Add(numAreaConstruida);
            tabPU.Controls.Add(lblNumeroPisos);
            tabPU.Controls.Add(numNumeroPisos);
            tabPU.Location = new Point(4, 24);
            tabPU.Name = "tabPU";
            tabPU.Padding = new Padding(3);
            tabPU.Size = new Size(1102, 572);
            tabPU.TabIndex = 2;
            tabPU.Text = "2. Predio (P.U.)";
            tabPU.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarPredio
            // 
            btnRegistrarPredio.BackColor = Color.FromArgb(24, 61, 114);
            btnRegistrarPredio.FlatStyle = FlatStyle.Flat;
            btnRegistrarPredio.ForeColor = Color.White;
            btnRegistrarPredio.Location = new Point(20, 326);
            btnRegistrarPredio.Name = "btnRegistrarPredio";
            btnRegistrarPredio.Size = new Size(160, 36);
            btnRegistrarPredio.TabIndex = 77;
            btnRegistrarPredio.Text = "Registrar Predio";
            btnRegistrarPredio.UseVisualStyleBackColor = false;
            btnRegistrarPredio.Click += btnRegistrarPredio_Click;
            // 
            // lblCodigoPredio
            // 
            lblCodigoPredio.Location = new Point(20, 20);
            lblCodigoPredio.Name = "lblCodigoPredio";
            lblCodigoPredio.Size = new Size(300, 20);
            lblCodigoPredio.TabIndex = 26;
            lblCodigoPredio.Text = "Código del predio";
            // 
            // txtCodigoPredio
            // 
            txtCodigoPredio.Location = new Point(20, 42);
            txtCodigoPredio.Name = "txtCodigoPredio";
            txtCodigoPredio.Size = new Size(300, 24);
            txtCodigoPredio.TabIndex = 27;
            // 
            // lblDireccionPredio
            // 
            lblDireccionPredio.Location = new Point(350, 20);
            lblDireccionPredio.Name = "lblDireccionPredio";
            lblDireccionPredio.Size = new Size(690, 20);
            lblDireccionPredio.TabIndex = 28;
            lblDireccionPredio.Text = "Avenida, jirón, calle o pasaje (dirección del predio)";
            // 
            // txtDireccionPredio
            // 
            txtDireccionPredio.Location = new Point(350, 42);
            txtDireccionPredio.Name = "txtDireccionPredio";
            txtDireccionPredio.Size = new Size(690, 24);
            txtDireccionPredio.TabIndex = 29;
            // 
            // lblDistrito
            // 
            lblDistrito.Location = new Point(20, 90);
            lblDistrito.Name = "lblDistrito";
            lblDistrito.Size = new Size(300, 20);
            lblDistrito.TabIndex = 30;
            lblDistrito.Text = "Distrito";
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Items.AddRange(new object[] { "Los Olivos (Lima 39)" });
            cboDistrito.Location = new Point(20, 112);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(300, 25);
            cboDistrito.TabIndex = 31;
            // 
            // lblEstadoPredio
            // 
            lblEstadoPredio.Location = new Point(350, 90);
            lblEstadoPredio.Name = "lblEstadoPredio";
            lblEstadoPredio.Size = new Size(300, 20);
            lblEstadoPredio.TabIndex = 32;
            lblEstadoPredio.Text = "Estado del predio";
            // 
            // cboEstadoPredio
            // 
            cboEstadoPredio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstadoPredio.FormattingEnabled = true;
            cboEstadoPredio.Items.AddRange(new object[] { "Terreno sin construir", "En construcción", "Terminado", "En ruinas" });
            cboEstadoPredio.Location = new Point(350, 112);
            cboEstadoPredio.Name = "cboEstadoPredio";
            cboEstadoPredio.Size = new Size(300, 25);
            cboEstadoPredio.TabIndex = 33;
            // 
            // lblTipoPredio
            // 
            lblTipoPredio.Location = new Point(680, 90);
            lblTipoPredio.Name = "lblTipoPredio";
            lblTipoPredio.Size = new Size(360, 20);
            lblTipoPredio.TabIndex = 34;
            lblTipoPredio.Text = "Tipo de predio";
            // 
            // cboTipoPredio
            // 
            cboTipoPredio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoPredio.FormattingEnabled = true;
            cboTipoPredio.Items.AddRange(new object[] { "Predio independiente", "Dpto. u oficina en edificio", "Predio en quinta", "Cuarto en casa de vecindad", "Tienda", "Otros" });
            cboTipoPredio.Location = new Point(680, 112);
            cboTipoPredio.Name = "cboTipoPredio";
            cboTipoPredio.Size = new Size(360, 25);
            cboTipoPredio.TabIndex = 35;
            // 
            // lblUsoPredio
            // 
            lblUsoPredio.Location = new Point(20, 160);
            lblUsoPredio.Name = "lblUsoPredio";
            lblUsoPredio.Size = new Size(440, 20);
            lblUsoPredio.TabIndex = 36;
            lblUsoPredio.Text = "Uso del predio";
            // 
            // cboUsoPredio
            // 
            cboUsoPredio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsoPredio.FormattingEnabled = true;
            cboUsoPredio.Items.AddRange(new object[] { "Casa habitación", "Comercio", "Industria", "Servicio en general", "Educacional", "Gobierno central / institución pública / gobierno local", "Gobierno extranjero", "Fundación o asociación", "Templo, convento, monasterio", "Museo", "Compañía de bomberos", "Organización sindical", "Comunidad campesina o nativa", "Cultural", "Partido político", "Asistencia gratuita", "Comunidad laboral o compensación", "Monumento histórico", "Otros" });
            cboUsoPredio.Location = new Point(20, 182);
            cboUsoPredio.Name = "cboUsoPredio";
            cboUsoPredio.Size = new Size(440, 25);
            cboUsoPredio.TabIndex = 37;
            // 
            // lblCondicion
            // 
            lblCondicion.Location = new Point(490, 160);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(300, 20);
            lblCondicion.TabIndex = 38;
            lblCondicion.Text = "Condición de propiedad";
            // 
            // cboCondicion
            // 
            cboCondicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCondicion.FormattingEnabled = true;
            cboCondicion.Items.AddRange(new object[] { "Propietario único", "Sucesión indivisa", "Poseedor o tenedor", "Sociedad conyugal", "Condominio", "Sucesión intestada", "Otro" });
            cboCondicion.Location = new Point(490, 182);
            cboCondicion.Name = "cboCondicion";
            cboCondicion.Size = new Size(300, 25);
            cboCondicion.TabIndex = 39;
            // 
            // lblAreaTerreno
            // 
            lblAreaTerreno.Location = new Point(20, 230);
            lblAreaTerreno.Name = "lblAreaTerreno";
            lblAreaTerreno.Size = new Size(200, 20);
            lblAreaTerreno.TabIndex = 40;
            lblAreaTerreno.Text = "Área del terreno (m²)";
            // 
            // numAreaTerreno
            // 
            numAreaTerreno.DecimalPlaces = 2;
            numAreaTerreno.Location = new Point(20, 252);
            numAreaTerreno.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numAreaTerreno.Name = "numAreaTerreno";
            numAreaTerreno.Size = new Size(200, 24);
            numAreaTerreno.TabIndex = 41;
            // 
            // lblAreaConstruida
            // 
            lblAreaConstruida.Location = new Point(250, 230);
            lblAreaConstruida.Name = "lblAreaConstruida";
            lblAreaConstruida.Size = new Size(200, 20);
            lblAreaConstruida.TabIndex = 42;
            lblAreaConstruida.Text = "Área construida (m²)";
            // 
            // numAreaConstruida
            // 
            numAreaConstruida.DecimalPlaces = 2;
            numAreaConstruida.Location = new Point(250, 252);
            numAreaConstruida.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numAreaConstruida.Name = "numAreaConstruida";
            numAreaConstruida.Size = new Size(200, 24);
            numAreaConstruida.TabIndex = 43;
            // 
            // lblNumeroPisos
            // 
            lblNumeroPisos.Location = new Point(480, 230);
            lblNumeroPisos.Name = "lblNumeroPisos";
            lblNumeroPisos.Size = new Size(150, 20);
            lblNumeroPisos.TabIndex = 44;
            lblNumeroPisos.Text = "Número de pisos";
            // 
            // numNumeroPisos
            // 
            numNumeroPisos.Location = new Point(480, 252);
            numNumeroPisos.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numNumeroPisos.Name = "numNumeroPisos";
            numNumeroPisos.Size = new Size(150, 24);
            numNumeroPisos.TabIndex = 45;
            // 
            // tabConstruccion
            // 
            tabConstruccion.Controls.Add(lblInstruccion);
            tabConstruccion.Controls.Add(dgvConstrucciones);
            tabConstruccion.Controls.Add(lblArancel);
            tabConstruccion.Controls.Add(numArancel);
            tabConstruccion.Controls.Add(lblAutovaluo);
            tabConstruccion.Controls.Add(txtAutovaluo);
            tabConstruccion.Controls.Add(btnCalcular);
            tabConstruccion.Controls.Add(btnEliminarConstruccion);
            tabConstruccion.Controls.Add(lblEscala);
            tabConstruccion.Controls.Add(lblNotaValores);
            tabConstruccion.Location = new Point(4, 24);
            tabConstruccion.Name = "tabConstruccion";
            tabConstruccion.Padding = new Padding(3);
            tabConstruccion.Size = new Size(1102, 572);
            tabConstruccion.TabIndex = 3;
            tabConstruccion.Text = "3. Construcción y autovalúo";
            tabConstruccion.UseVisualStyleBackColor = true;
            // 
            // lblInstruccion
            // 
            lblInstruccion.Location = new Point(20, 10);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(1040, 36);
            lblInstruccion.TabIndex = 46;
            lblInstruccion.Text = "Determinación del autovalúo: una fila por piso. Categorías: letras de los 7 componentes (muros, techos, pisos, puertas y ventanas, revestimientos, baños, instalaciones), ej. B,C,D,C,C,D,C";
            // 
            // dgvConstrucciones
            // 
            dgvConstrucciones.AllowUserToDeleteRows = false;
            dgvConstrucciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConstrucciones.BackgroundColor = Color.White;
            dgvConstrucciones.Columns.AddRange(new DataGridViewColumn[] { colPiso, colAntiguedad, colCategorias, colArea, colValor });
            dgvConstrucciones.Location = new Point(20, 55);
            dgvConstrucciones.MultiSelect = false;
            dgvConstrucciones.Name = "dgvConstrucciones";
            dgvConstrucciones.RowHeadersVisible = false;
            dgvConstrucciones.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvConstrucciones.Size = new Size(1040, 270);
            dgvConstrucciones.TabIndex = 47;
            // 
            // colPiso
            // 
            colPiso.HeaderText = "Piso N°";
            colPiso.Name = "colPiso";
            // 
            // colAntiguedad
            // 
            colAntiguedad.HeaderText = "Antigüedad (años)";
            colAntiguedad.Name = "colAntiguedad";
            // 
            // colCategorias
            // 
            colCategorias.HeaderText = "Categorías";
            colCategorias.Name = "colCategorias";
            // 
            // colArea
            // 
            colArea.HeaderText = "Área construida (m²)";
            colArea.Name = "colArea";
            // 
            // colValor
            // 
            colValor.HeaderText = "Valor de la construcción (S/)";
            colValor.Name = "colValor";
            // 
            // lblArancel
            // 
            lblArancel.Location = new Point(20, 350);
            lblArancel.Name = "lblArancel";
            lblArancel.Size = new Size(260, 20);
            lblArancel.TabIndex = 48;
            lblArancel.Text = "Valor arancelario por m² de terreno (S/)";
            // 
            // numArancel
            // 
            numArancel.DecimalPlaces = 2;
            numArancel.Location = new Point(20, 372);
            numArancel.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numArancel.Name = "numArancel";
            numArancel.Size = new Size(260, 24);
            numArancel.TabIndex = 49;
            // 
            // lblAutovaluo
            // 
            lblAutovaluo.Location = new Point(310, 350);
            lblAutovaluo.Name = "lblAutovaluo";
            lblAutovaluo.Size = new Size(220, 20);
            lblAutovaluo.TabIndex = 50;
            lblAutovaluo.Text = "Autovalúo total (S/)";
            // 
            // txtAutovaluo
            // 
            txtAutovaluo.Location = new Point(310, 372);
            txtAutovaluo.Name = "txtAutovaluo";
            txtAutovaluo.ReadOnly = true;
            txtAutovaluo.Size = new Size(220, 24);
            txtAutovaluo.TabIndex = 51;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(24, 61, 114);
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(560, 372);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(230, 34);
            btnCalcular.TabIndex = 52;
            btnCalcular.Text = "Calcular autovalúo e impuesto";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnEliminarConstruccion
            // 
            btnEliminarConstruccion.Location = new Point(810, 372);
            btnEliminarConstruccion.Name = "btnEliminarConstruccion";
            btnEliminarConstruccion.Size = new Size(140, 34);
            btnEliminarConstruccion.TabIndex = 53;
            btnEliminarConstruccion.Text = "Eliminar fila";
            btnEliminarConstruccion.UseVisualStyleBackColor = true;
            btnEliminarConstruccion.Click += btnEliminarConstruccion_Click;
            // 
            // lblEscala
            // 
            lblEscala.Location = new Point(20, 430);
            lblEscala.Name = "lblEscala";
            lblEscala.Size = new Size(1040, 20);
            lblEscala.TabIndex = 54;
            lblEscala.Text = "Escala del impuesto: hasta 15 UIT = 0.2 %, más de 15 hasta 60 UIT = 0.6 %, más de 60 UIT = 1 %.";
            // 
            // lblNotaValores
            // 
            lblNotaValores.Location = new Point(20, 455);
            lblNotaValores.Name = "lblNotaValores";
            lblNotaValores.Size = new Size(1040, 20);
            lblNotaValores.TabIndex = 55;
            lblNotaValores.Text = "Los valores unitarios y aranceles deben tomarse de las tablas oficiales vigentes de la municipalidad.";
            // 
            // tabCopropietarios
            // 
            tabCopropietarios.Controls.Add(lblDniCopropietario);
            tabCopropietarios.Controls.Add(txtDniCopropietario);
            tabCopropietarios.Controls.Add(lblNombreCopropietario);
            tabCopropietarios.Controls.Add(txtNombreCopropietario);
            tabCopropietarios.Controls.Add(lblPorcentaje);
            tabCopropietarios.Controls.Add(numPorcentaje);
            tabCopropietarios.Controls.Add(btnAgregarCopropietario);
            tabCopropietarios.Controls.Add(btnQuitarCopropietario);
            tabCopropietarios.Controls.Add(dgvCopropietarios);
            tabCopropietarios.Controls.Add(lblTotalPorcentaje);
            tabCopropietarios.Location = new Point(4, 24);
            tabCopropietarios.Name = "tabCopropietarios";
            tabCopropietarios.Padding = new Padding(3);
            tabCopropietarios.Size = new Size(1102, 572);
            tabCopropietarios.TabIndex = 4;
            tabCopropietarios.Text = "4. Copropietarios";
            tabCopropietarios.UseVisualStyleBackColor = true;
            // 
            // lblDniCopropietario
            // 
            lblDniCopropietario.Location = new Point(20, 20);
            lblDniCopropietario.Name = "lblDniCopropietario";
            lblDniCopropietario.Size = new Size(200, 20);
            lblDniCopropietario.TabIndex = 56;
            lblDniCopropietario.Text = "DNI / RUC";
            // 
            // txtDniCopropietario
            // 
            txtDniCopropietario.Location = new Point(20, 42);
            txtDniCopropietario.Name = "txtDniCopropietario";
            txtDniCopropietario.Size = new Size(200, 24);
            txtDniCopropietario.TabIndex = 57;
            // 
            // lblNombreCopropietario
            // 
            lblNombreCopropietario.Location = new Point(240, 20);
            lblNombreCopropietario.Name = "lblNombreCopropietario";
            lblNombreCopropietario.Size = new Size(380, 20);
            lblNombreCopropietario.TabIndex = 58;
            lblNombreCopropietario.Text = "Apellidos y nombres";
            // 
            // txtNombreCopropietario
            // 
            txtNombreCopropietario.Location = new Point(240, 42);
            txtNombreCopropietario.Name = "txtNombreCopropietario";
            txtNombreCopropietario.Size = new Size(380, 24);
            txtNombreCopropietario.TabIndex = 59;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.Location = new Point(640, 20);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(120, 20);
            lblPorcentaje.TabIndex = 60;
            lblPorcentaje.Text = "Porcentaje (%)";
            // 
            // numPorcentaje
            // 
            numPorcentaje.DecimalPlaces = 2;
            numPorcentaje.Location = new Point(640, 42);
            numPorcentaje.Name = "numPorcentaje";
            numPorcentaje.Size = new Size(120, 24);
            numPorcentaje.TabIndex = 61;
            // 
            // btnAgregarCopropietario
            // 
            btnAgregarCopropietario.BackColor = Color.FromArgb(24, 61, 114);
            btnAgregarCopropietario.FlatStyle = FlatStyle.Flat;
            btnAgregarCopropietario.ForeColor = Color.White;
            btnAgregarCopropietario.Location = new Point(780, 42);
            btnAgregarCopropietario.Name = "btnAgregarCopropietario";
            btnAgregarCopropietario.Size = new Size(110, 28);
            btnAgregarCopropietario.TabIndex = 62;
            btnAgregarCopropietario.Text = "Agregar";
            btnAgregarCopropietario.UseVisualStyleBackColor = false;
            btnAgregarCopropietario.Click += btnAgregarCopropietario_Click;
            // 
            // btnQuitarCopropietario
            // 
            btnQuitarCopropietario.Location = new Point(900, 42);
            btnQuitarCopropietario.Name = "btnQuitarCopropietario";
            btnQuitarCopropietario.Size = new Size(110, 28);
            btnQuitarCopropietario.TabIndex = 63;
            btnQuitarCopropietario.Text = "Quitar fila";
            btnQuitarCopropietario.UseVisualStyleBackColor = true;
            btnQuitarCopropietario.Click += btnQuitarCopropietario_Click;
            // 
            // dgvCopropietarios
            // 
            dgvCopropietarios.AllowUserToAddRows = false;
            dgvCopropietarios.AllowUserToDeleteRows = false;
            dgvCopropietarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCopropietarios.BackgroundColor = Color.White;
            dgvCopropietarios.Columns.AddRange(new DataGridViewColumn[] { colDniCop, colNombreCop, colPorcentajeCop });
            dgvCopropietarios.Location = new Point(20, 90);
            dgvCopropietarios.MultiSelect = false;
            dgvCopropietarios.Name = "dgvCopropietarios";
            dgvCopropietarios.ReadOnly = true;
            dgvCopropietarios.RowHeadersVisible = false;
            dgvCopropietarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCopropietarios.Size = new Size(1040, 300);
            dgvCopropietarios.TabIndex = 64;
            // 
            // colDniCop
            // 
            colDniCop.HeaderText = "DNI / RUC";
            colDniCop.Name = "colDniCop";
            colDniCop.ReadOnly = true;
            // 
            // colNombreCop
            // 
            colNombreCop.HeaderText = "Apellidos y nombres";
            colNombreCop.Name = "colNombreCop";
            colNombreCop.ReadOnly = true;
            // 
            // colPorcentajeCop
            // 
            colPorcentajeCop.HeaderText = "Porcentaje (%)";
            colPorcentajeCop.Name = "colPorcentajeCop";
            colPorcentajeCop.ReadOnly = true;
            // 
            // lblTotalPorcentaje
            // 
            lblTotalPorcentaje.Location = new Point(20, 405);
            lblTotalPorcentaje.Name = "lblTotalPorcentaje";
            lblTotalPorcentaje.Size = new Size(400, 20);
            lblTotalPorcentaje.TabIndex = 65;
            lblTotalPorcentaje.Text = "Total: 0 %";
            lblTotalPorcentaje.Click += lblTotalPorcentaje_Click;
            // 
            // tabDocumentos
            // 
            tabDocumentos.Controls.Add(lblRequisitos);
            tabDocumentos.Controls.Add(clbRequisitos);
            tabDocumentos.Controls.Add(lblFechaCompra);
            tabDocumentos.Controls.Add(dtpFechaCompra);
            tabDocumentos.Controls.Add(lblMulta);
            tabDocumentos.Controls.Add(btnAdjuntarDocumento);
            tabDocumentos.Controls.Add(btnQuitarDocumento);
            tabDocumentos.Controls.Add(dgvDocumentos);
            tabDocumentos.Location = new Point(4, 24);
            tabDocumentos.Name = "tabDocumentos";
            tabDocumentos.Padding = new Padding(3);
            tabDocumentos.Size = new Size(1102, 572);
            tabDocumentos.TabIndex = 5;
            tabDocumentos.Text = "5. Documentos";
            tabDocumentos.UseVisualStyleBackColor = true;
            // 
            // lblRequisitos
            // 
            lblRequisitos.Location = new Point(20, 15);
            lblRequisitos.Name = "lblRequisitos";
            lblRequisitos.Size = new Size(600, 20);
            lblRequisitos.TabIndex = 66;
            lblRequisitos.Text = "Requisitos presentados (primer paso: Fedatea)";
            // 
            // clbRequisitos
            // 
            clbRequisitos.CheckOnClick = true;
            clbRequisitos.FormattingEnabled = true;
            clbRequisitos.Items.AddRange(new object[] { "Documento de transferencia (copia literal no mayor a 3 meses, adjudicación, anticipo de legítima o donación, compra venta, resolución judicial o constancia de posesión)", "Copia del DNI", "Foto actual de la fachada", "Carta poder legalizada (si no es el titular o es persona jurídica)", "Licencia de funcionamiento (si el uso es comercial)", "Sucesión intestada con traslado de dominio emitido por Sunarp (si son herederos)" });
            clbRequisitos.Location = new Point(20, 40);
            clbRequisitos.Name = "clbRequisitos";
            clbRequisitos.Size = new Size(1040, 118);
            clbRequisitos.TabIndex = 67;
            // 
            // lblFechaCompra
            // 
            lblFechaCompra.Location = new Point(20, 190);
            lblFechaCompra.Name = "lblFechaCompra";
            lblFechaCompra.Size = new Size(300, 20);
            lblFechaCompra.TabIndex = 68;
            lblFechaCompra.Text = "Fecha de la compra o adquisición";
            // 
            // dtpFechaCompra
            // 
            dtpFechaCompra.Format = DateTimePickerFormat.Short;
            dtpFechaCompra.Location = new Point(20, 212);
            dtpFechaCompra.Name = "dtpFechaCompra";
            dtpFechaCompra.Size = new Size(200, 24);
            dtpFechaCompra.TabIndex = 69;
            // 
            // lblMulta
            // 
            lblMulta.Location = new Point(260, 214);
            lblMulta.Name = "lblMulta";
            lblMulta.Size = new Size(780, 20);
            lblMulta.TabIndex = 70;
            lblMulta.Text = "Aquí se mostrará si el plazo está vencido y la multa que corresponde.";
            // 
            // btnAdjuntarDocumento
            // 
            btnAdjuntarDocumento.BackColor = Color.FromArgb(24, 61, 114);
            btnAdjuntarDocumento.FlatStyle = FlatStyle.Flat;
            btnAdjuntarDocumento.ForeColor = Color.White;
            btnAdjuntarDocumento.Location = new Point(20, 260);
            btnAdjuntarDocumento.Name = "btnAdjuntarDocumento";
            btnAdjuntarDocumento.Size = new Size(170, 32);
            btnAdjuntarDocumento.TabIndex = 71;
            btnAdjuntarDocumento.Text = "Adjuntar documento";
            btnAdjuntarDocumento.UseVisualStyleBackColor = false;
            btnAdjuntarDocumento.Click += btnAdjuntarDocumento_Click;
            // 
            // btnQuitarDocumento
            // 
            btnQuitarDocumento.Location = new Point(200, 260);
            btnQuitarDocumento.Name = "btnQuitarDocumento";
            btnQuitarDocumento.Size = new Size(100, 32);
            btnQuitarDocumento.TabIndex = 72;
            btnQuitarDocumento.Text = "Quitar";
            btnQuitarDocumento.UseVisualStyleBackColor = true;
            btnQuitarDocumento.Click += btnQuitarDocumento_Click;
            // 
            // dgvDocumentos
            // 
            dgvDocumentos.AllowUserToAddRows = false;
            dgvDocumentos.AllowUserToDeleteRows = false;
            dgvDocumentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocumentos.BackgroundColor = Color.White;
            dgvDocumentos.Columns.AddRange(new DataGridViewColumn[] { colNombreArchivo, colRutaArchivo });
            dgvDocumentos.Location = new Point(20, 300);
            dgvDocumentos.MultiSelect = false;
            dgvDocumentos.Name = "dgvDocumentos";
            dgvDocumentos.ReadOnly = true;
            dgvDocumentos.RowHeadersVisible = false;
            dgvDocumentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocumentos.Size = new Size(1040, 200);
            dgvDocumentos.TabIndex = 73;
            // 
            // colNombreArchivo
            // 
            colNombreArchivo.HeaderText = "Archivo";
            colNombreArchivo.Name = "colNombreArchivo";
            colNombreArchivo.ReadOnly = true;
            // 
            // colRutaArchivo
            // 
            colRutaArchivo.HeaderText = "Ruta";
            colRutaArchivo.Name = "colRutaArchivo";
            colRutaArchivo.ReadOnly = true;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(10, 625);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(120, 32);
            btnAnterior.TabIndex = 74;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(140, 625);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(120, 32);
            btnSiguiente.TabIndex = 75;
            btnSiguiente.Text = "Siguiente >";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnGuardarInscripcion
            // 
            btnGuardarInscripcion.BackColor = Color.FromArgb(24, 61, 114);
            btnGuardarInscripcion.FlatStyle = FlatStyle.Flat;
            btnGuardarInscripcion.ForeColor = Color.White;
            btnGuardarInscripcion.Location = new Point(960, 625);
            btnGuardarInscripcion.Name = "btnGuardarInscripcion";
            btnGuardarInscripcion.Size = new Size(160, 36);
            btnGuardarInscripcion.TabIndex = 76;
            btnGuardarInscripcion.Text = "Guardar inscripción";
            btnGuardarInscripcion.UseVisualStyleBackColor = false;
            btnGuardarInscripcion.Click += btnGuardarInscripcion_Click;
            // 
            // ofdDocumento
            // 
            ofdDocumento.Filter = "PDF e imágenes|*.pdf;*.jpg;*.jpeg;*.png|Todos los archivos|*.*";
            ofdDocumento.Title = "Seleccionar documento";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(24, 61, 114);
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(725, 625);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(160, 36);
            btnRegresar.TabIndex = 77;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FrmInscripcionPropiedad
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1150, 720);
            Controls.Add(btnRegresar);
            Controls.Add(tabInscripcion);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(btnGuardarInscripcion);
            Font = new Font("Segoe UI", 9.5F);
            Name = "FrmInscripcionPropiedad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripción de Propiedad";
            tabInscripcion.ResumeLayout(false);
            tabHR.ResumeLayout(false);
            tabHR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrediosHR).EndInit();
            tabPU.ResumeLayout(false);
            tabPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAreaTerreno).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAreaConstruida).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNumeroPisos).EndInit();
            tabConstruccion.ResumeLayout(false);
            tabConstruccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConstrucciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)numArancel).EndInit();
            tabCopropietarios.ResumeLayout(false);
            tabCopropietarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPorcentaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCopropietarios).EndInit();
            tabDocumentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDocumentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabInscripcion;
        private System.Windows.Forms.TabPage tabHR;
        private System.Windows.Forms.TabPage tabPU;
        private System.Windows.Forms.TabPage tabConstruccion;
        private System.Windows.Forms.TabPage tabCopropietarios;
        private System.Windows.Forms.TabPage tabDocumentos;
        private System.Windows.Forms.Label lblDniHR;
        private System.Windows.Forms.TextBox txtDniHR;
        private System.Windows.Forms.Label lblNombresHR;
        private System.Windows.Forms.TextBox txtNombresHR;
        private System.Windows.Forms.Label lblTelefonoHR;
        private System.Windows.Forms.TextBox txtTelefonoHR;
        private System.Windows.Forms.Label lblCorreoHR;
        private System.Windows.Forms.TextBox txtCorreoHR;
        private System.Windows.Forms.Label lblDomicilioHR;
        private System.Windows.Forms.TextBox txtDomicilioHR;
        private System.Windows.Forms.Label lblTipoDeclaracion;
        private System.Windows.Forms.ComboBox cboTipoDeclaracion;
        private System.Windows.Forms.Label lblMotivoDeclaracion;
        private System.Windows.Forms.ComboBox cboMotivoDeclaracion;
        private System.Windows.Forms.Label lblImpuestoAnual;
        private System.Windows.Forms.TextBox txtImpuestoAnual;
        private System.Windows.Forms.Label lblImpuestoTrimestral;
        private System.Windows.Forms.TextBox txtImpuestoTrimestral;
        private System.Windows.Forms.Label lblPrediosHR;
        private System.Windows.Forms.DataGridView dgvPrediosHR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutovaluo;
        private System.Windows.Forms.Label lblCodigoPredio;
        private System.Windows.Forms.TextBox txtCodigoPredio;
        private System.Windows.Forms.Label lblDireccionPredio;
        private System.Windows.Forms.TextBox txtDireccionPredio;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.Label lblEstadoPredio;
        private System.Windows.Forms.ComboBox cboEstadoPredio;
        private System.Windows.Forms.Label lblTipoPredio;
        private System.Windows.Forms.ComboBox cboTipoPredio;
        private System.Windows.Forms.Label lblUsoPredio;
        private System.Windows.Forms.ComboBox cboUsoPredio;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.ComboBox cboCondicion;
        private System.Windows.Forms.Label lblAreaTerreno;
        private System.Windows.Forms.NumericUpDown numAreaTerreno;
        private System.Windows.Forms.Label lblAreaConstruida;
        private System.Windows.Forms.NumericUpDown numAreaConstruida;
        private System.Windows.Forms.Label lblNumeroPisos;
        private System.Windows.Forms.NumericUpDown numNumeroPisos;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.DataGridView dgvConstrucciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAntiguedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.Label lblArancel;
        private System.Windows.Forms.NumericUpDown numArancel;
        private System.Windows.Forms.Label lblAutovaluo;
        private System.Windows.Forms.TextBox txtAutovaluo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnEliminarConstruccion;
        private System.Windows.Forms.Label lblEscala;
        private System.Windows.Forms.Label lblNotaValores;
        private System.Windows.Forms.Label lblDniCopropietario;
        private System.Windows.Forms.TextBox txtDniCopropietario;
        private System.Windows.Forms.Label lblNombreCopropietario;
        private System.Windows.Forms.TextBox txtNombreCopropietario;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.NumericUpDown numPorcentaje;
        private System.Windows.Forms.Button btnAgregarCopropietario;
        private System.Windows.Forms.Button btnQuitarCopropietario;
        private System.Windows.Forms.DataGridView dgvCopropietarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDniCop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPorcentajeCop;
        private System.Windows.Forms.Label lblTotalPorcentaje;
        private System.Windows.Forms.Label lblRequisitos;
        private System.Windows.Forms.CheckedListBox clbRequisitos;
        private System.Windows.Forms.Label lblFechaCompra;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.Button btnAdjuntarDocumento;
        private System.Windows.Forms.Button btnQuitarDocumento;
        private System.Windows.Forms.DataGridView dgvDocumentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRutaArchivo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnGuardarInscripcion;
        private System.Windows.Forms.OpenFileDialog ofdDocumento;
        private Button btnRegistrarPredio;
        private Button btnRegresar;
    }
}
