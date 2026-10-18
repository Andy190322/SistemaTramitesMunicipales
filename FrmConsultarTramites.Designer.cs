namespace SistemaTramitesMunicipales
{
    partial class FrmConsultarTramites
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
            lblBuscarExpediente = new Label();
            txtBuscarExpediente = new TextBox();
            lblBuscarDni = new Label();
            txtBuscarDni = new TextBox();
            lblBuscarTipo = new Label();
            cboBuscarTipo = new ComboBox();
            lblBuscarEstado = new Label();
            cboBuscarEstado = new ComboBox();
            btnBuscar = new Button();
            dgvResultados = new DataGridView();
            colExpediente = new DataGridViewTextBoxColumn();
            colTramite = new DataGridViewTextBoxColumn();
            colDniRuc = new DataGridViewTextBoxColumn();
            colContribuyente = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            btnVerDetalle = new Button();
            lblCambiarEstado = new Label();
            cboNuevoEstado = new ComboBox();
            btnActualizarEstado = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // lblBuscarExpediente
            // 
            lblBuscarExpediente.Location = new Point(20, 15);
            lblBuscarExpediente.Name = "lblBuscarExpediente";
            lblBuscarExpediente.Size = new Size(200, 20);
            lblBuscarExpediente.TabIndex = 0;
            lblBuscarExpediente.Text = "N.º de expediente (ej.: 000012)";
            lblBuscarExpediente.Click += lblBuscarExpediente_Click;
            // 
            // txtBuscarExpediente
            // 
            txtBuscarExpediente.Location = new Point(20, 37);
            txtBuscarExpediente.Name = "txtBuscarExpediente";
            txtBuscarExpediente.Size = new Size(200, 24);
            txtBuscarExpediente.TabIndex = 1;
            txtBuscarExpediente.TextChanged += txtBuscarExpediente_TextChanged;
            // 
            // lblBuscarDni
            // 
            lblBuscarDni.Location = new Point(240, 15);
            lblBuscarDni.Name = "lblBuscarDni";
            lblBuscarDni.Size = new Size(160, 20);
            lblBuscarDni.TabIndex = 2;
            lblBuscarDni.Text = "DNI / RUC";
            lblBuscarDni.Click += lblBuscarDni_Click;
            // 
            // txtBuscarDni
            // 
            txtBuscarDni.Location = new Point(240, 37);
            txtBuscarDni.Name = "txtBuscarDni";
            txtBuscarDni.Size = new Size(160, 24);
            txtBuscarDni.TabIndex = 3;
            txtBuscarDni.TextChanged += txtBuscarDni_TextChanged;
            // 
            // lblBuscarTipo
            // 
            lblBuscarTipo.Location = new Point(420, 15);
            lblBuscarTipo.Name = "lblBuscarTipo";
            lblBuscarTipo.Size = new Size(190, 20);
            lblBuscarTipo.TabIndex = 4;
            lblBuscarTipo.Text = "Trámite";
            lblBuscarTipo.Click += lblBuscarTipo_Click;
            // 
            // cboBuscarTipo
            // 
            cboBuscarTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBuscarTipo.FormattingEnabled = true;
            cboBuscarTipo.Items.AddRange(new object[] { "Todos", "INSCRIPCION", "NO_ADEUDO" });
            cboBuscarTipo.Location = new Point(420, 37);
            cboBuscarTipo.Name = "cboBuscarTipo";
            cboBuscarTipo.Size = new Size(190, 25);
            cboBuscarTipo.TabIndex = 5;
            cboBuscarTipo.SelectedIndexChanged += cboBuscarTipo_SelectedIndexChanged;
            // 
            // lblBuscarEstado
            // 
            lblBuscarEstado.Location = new Point(630, 15);
            lblBuscarEstado.Name = "lblBuscarEstado";
            lblBuscarEstado.Size = new Size(170, 20);
            lblBuscarEstado.TabIndex = 6;
            lblBuscarEstado.Text = "Estado";
            lblBuscarEstado.Click += lblBuscarEstado_Click;
            // 
            // cboBuscarEstado
            // 
            cboBuscarEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBuscarEstado.FormattingEnabled = true;
            cboBuscarEstado.Items.AddRange(new object[] { "Todos", "Registrado", "En revisión", "Observado", "Aprobado", "Rechazado" });
            cboBuscarEstado.Location = new Point(630, 37);
            cboBuscarEstado.Name = "cboBuscarEstado";
            cboBuscarEstado.Size = new Size(170, 25);
            cboBuscarEstado.TabIndex = 7;
            cboBuscarEstado.SelectedIndexChanged += cboBuscarEstado_SelectedIndexChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(24, 61, 114);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(820, 36);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 28);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.BackgroundColor = Color.White;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colExpediente, colTramite, colDniRuc, colContribuyente, colFecha, colEstado });
            dgvResultados.Location = new Point(20, 85);
            dgvResultados.MultiSelect = false;
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersVisible = false;
            dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultados.Size = new Size(1040, 400);
            dgvResultados.TabIndex = 9;
            dgvResultados.CellContentClick += dgvResultados_CellContentClick;
            // 
            // colExpediente
            // 
            colExpediente.HeaderText = "Expediente";
            colExpediente.Name = "colExpediente";
            colExpediente.ReadOnly = true;
            // 
            // colTramite
            // 
            colTramite.HeaderText = "Trámite";
            colTramite.Name = "colTramite";
            colTramite.ReadOnly = true;
            // 
            // colDniRuc
            // 
            colDniRuc.HeaderText = "DNI / RUC";
            colDniRuc.Name = "colDniRuc";
            colDniRuc.ReadOnly = true;
            // 
            // colContribuyente
            // 
            colContribuyente.HeaderText = "Contribuyente";
            colContribuyente.Name = "colContribuyente";
            colContribuyente.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.BackColor = Color.FromArgb(24, 61, 114);
            btnVerDetalle.FlatStyle = FlatStyle.Flat;
            btnVerDetalle.ForeColor = Color.White;
            btnVerDetalle.Location = new Point(20, 505);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(140, 34);
            btnVerDetalle.TabIndex = 10;
            btnVerDetalle.Text = "Ver detalle";
            btnVerDetalle.UseVisualStyleBackColor = false;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // lblCambiarEstado
            // 
            lblCambiarEstado.Location = new Point(600, 513);
            lblCambiarEstado.Name = "lblCambiarEstado";
            lblCambiarEstado.Size = new Size(120, 20);
            lblCambiarEstado.TabIndex = 11;
            lblCambiarEstado.Text = "Cambiar estado a:";
            lblCambiarEstado.Click += lblCambiarEstado_Click;
            // 
            // cboNuevoEstado
            // 
            cboNuevoEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNuevoEstado.FormattingEnabled = true;
            cboNuevoEstado.Items.AddRange(new object[] { "Registrado", "En revisión", "Observado", "Aprobado", "Rechazado" });
            cboNuevoEstado.Location = new Point(725, 510);
            cboNuevoEstado.Name = "cboNuevoEstado";
            cboNuevoEstado.Size = new Size(150, 25);
            cboNuevoEstado.TabIndex = 12;
            cboNuevoEstado.SelectedIndexChanged += cboNuevoEstado_SelectedIndexChanged;
            // 
            // btnActualizarEstado
            // 
            btnActualizarEstado.Location = new Point(890, 505);
            btnActualizarEstado.Name = "btnActualizarEstado";
            btnActualizarEstado.Size = new Size(120, 34);
            btnActualizarEstado.TabIndex = 13;
            btnActualizarEstado.Text = "Actualizar";
            btnActualizarEstado.UseVisualStyleBackColor = true;
            btnActualizarEstado.Click += btnActualizarEstado_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(24, 61, 114);
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(960, 37);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(100, 28);
            btnRegresar.TabIndex = 14;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FrmConsultarTramites
            // 
            AcceptButton = btnBuscar;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1100, 600);
            Controls.Add(btnRegresar);
            Controls.Add(lblBuscarExpediente);
            Controls.Add(txtBuscarExpediente);
            Controls.Add(lblBuscarDni);
            Controls.Add(txtBuscarDni);
            Controls.Add(lblBuscarTipo);
            Controls.Add(cboBuscarTipo);
            Controls.Add(lblBuscarEstado);
            Controls.Add(cboBuscarEstado);
            Controls.Add(btnBuscar);
            Controls.Add(dgvResultados);
            Controls.Add(btnVerDetalle);
            Controls.Add(lblCambiarEstado);
            Controls.Add(cboNuevoEstado);
            Controls.Add(btnActualizarEstado);
            Font = new Font("Segoe UI", 9.5F);
            Name = "FrmConsultarTramites";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar trámites";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBuscarExpediente;
        private System.Windows.Forms.TextBox txtBuscarExpediente;
        private System.Windows.Forms.Label lblBuscarDni;
        private System.Windows.Forms.TextBox txtBuscarDni;
        private System.Windows.Forms.Label lblBuscarTipo;
        private System.Windows.Forms.ComboBox cboBuscarTipo;
        private System.Windows.Forms.Label lblBuscarEstado;
        private System.Windows.Forms.ComboBox cboBuscarEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTramite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDniRuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContribuyente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Label lblCambiarEstado;
        private System.Windows.Forms.ComboBox cboNuevoEstado;
        private System.Windows.Forms.Button btnActualizarEstado;
        private Button btnRegresar;
    }
}
