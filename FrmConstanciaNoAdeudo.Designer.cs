namespace SistemaTramitesMunicipales
{
    partial class FrmConstanciaNoAdeudo
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
            grpContribuyente = new GroupBox();
            lblCodigoContribuyente = new Label();
            txtCodigoContribuyente = new TextBox();
            lblDniNoAdeudo = new Label();
            txtDniNoAdeudo = new TextBox();
            lblTelefonoNoAdeudo = new Label();
            txtTelefonoNoAdeudo = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblNombreNoAdeudo = new Label();
            txtNombreNoAdeudo = new TextBox();
            lblCorreoNoAdeudo = new Label();
            txtCorreoNoAdeudo = new TextBox();
            lblDomicilioNoAdeudo = new Label();
            txtDomicilioNoAdeudo = new TextBox();
            grpSolicitud = new GroupBox();
            chkNoAdeudo = new CheckBox();
            lblPeriodos = new Label();
            txtPeriodos = new TextBox();
            lblUbicacionPredio = new Label();
            txtUbicacionPredio = new TextBox();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            lblPresentaComo = new Label();
            rbTitular = new RadioButton();
            rbApoderado = new RadioButton();
            grpAdjuntos = new GroupBox();
            btnAdjuntarNoAdeudo = new Button();
            btnQuitarAdjunto = new Button();
            dgvAdjuntosNoAdeudo = new DataGridView();
            colNombreArchivo = new DataGridViewTextBoxColumn();
            colRutaArchivo = new DataGridViewTextBoxColumn();
            btnLimpiarNoAdeudo = new Button();
            btnGuardarNoAdeudo = new Button();
            grpContribuyente.SuspendLayout();
            grpSolicitud.SuspendLayout();
            grpAdjuntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdjuntosNoAdeudo).BeginInit();
            SuspendLayout();
            // 
            // grpContribuyente
            // 
            grpContribuyente.Controls.Add(lblCodigoContribuyente);
            grpContribuyente.Controls.Add(txtCodigoContribuyente);
            grpContribuyente.Controls.Add(lblDniNoAdeudo);
            grpContribuyente.Controls.Add(txtDniNoAdeudo);
            grpContribuyente.Controls.Add(lblTelefonoNoAdeudo);
            grpContribuyente.Controls.Add(txtTelefonoNoAdeudo);
            grpContribuyente.Controls.Add(lblFecha);
            grpContribuyente.Controls.Add(dtpFecha);
            grpContribuyente.Controls.Add(lblNombreNoAdeudo);
            grpContribuyente.Controls.Add(txtNombreNoAdeudo);
            grpContribuyente.Controls.Add(lblCorreoNoAdeudo);
            grpContribuyente.Controls.Add(txtCorreoNoAdeudo);
            grpContribuyente.Controls.Add(lblDomicilioNoAdeudo);
            grpContribuyente.Controls.Add(txtDomicilioNoAdeudo);
            grpContribuyente.Location = new Point(15, 10);
            grpContribuyente.Name = "grpContribuyente";
            grpContribuyente.Size = new Size(900, 210);
            grpContribuyente.TabIndex = 0;
            grpContribuyente.TabStop = false;
            grpContribuyente.Text = "Datos del contribuyente";
            // 
            // lblCodigoContribuyente
            // 
            lblCodigoContribuyente.Location = new Point(15, 25);
            lblCodigoContribuyente.Name = "lblCodigoContribuyente";
            lblCodigoContribuyente.Size = new Size(200, 20);
            lblCodigoContribuyente.TabIndex = 3;
            lblCodigoContribuyente.Text = "Código";
            // 
            // txtCodigoContribuyente
            // 
            txtCodigoContribuyente.Location = new Point(15, 47);
            txtCodigoContribuyente.Name = "txtCodigoContribuyente";
            txtCodigoContribuyente.Size = new Size(200, 24);
            txtCodigoContribuyente.TabIndex = 4;
            // 
            // lblDniNoAdeudo
            // 
            lblDniNoAdeudo.Location = new Point(235, 25);
            lblDniNoAdeudo.Name = "lblDniNoAdeudo";
            lblDniNoAdeudo.Size = new Size(200, 20);
            lblDniNoAdeudo.TabIndex = 5;
            lblDniNoAdeudo.Text = "DNI N°";
            // 
            // txtDniNoAdeudo
            // 
            txtDniNoAdeudo.Location = new Point(235, 47);
            txtDniNoAdeudo.Name = "txtDniNoAdeudo";
            txtDniNoAdeudo.Size = new Size(200, 24);
            txtDniNoAdeudo.TabIndex = 6;
            // 
            // lblTelefonoNoAdeudo
            // 
            lblTelefonoNoAdeudo.Location = new Point(455, 25);
            lblTelefonoNoAdeudo.Name = "lblTelefonoNoAdeudo";
            lblTelefonoNoAdeudo.Size = new Size(200, 20);
            lblTelefonoNoAdeudo.TabIndex = 7;
            lblTelefonoNoAdeudo.Text = "Teléfonos";
            // 
            // txtTelefonoNoAdeudo
            // 
            txtTelefonoNoAdeudo.Location = new Point(455, 47);
            txtTelefonoNoAdeudo.Name = "txtTelefonoNoAdeudo";
            txtTelefonoNoAdeudo.Size = new Size(200, 24);
            txtTelefonoNoAdeudo.TabIndex = 8;
            // 
            // lblFecha
            // 
            lblFecha.Location = new Point(675, 25);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(200, 20);
            lblFecha.TabIndex = 9;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(675, 47);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 24);
            dtpFecha.TabIndex = 10;
            // 
            // lblNombreNoAdeudo
            // 
            lblNombreNoAdeudo.Location = new Point(15, 85);
            lblNombreNoAdeudo.Name = "lblNombreNoAdeudo";
            lblNombreNoAdeudo.Size = new Size(640, 20);
            lblNombreNoAdeudo.TabIndex = 11;
            lblNombreNoAdeudo.Text = "Apellidos y nombres del contribuyente";
            // 
            // txtNombreNoAdeudo
            // 
            txtNombreNoAdeudo.Location = new Point(15, 107);
            txtNombreNoAdeudo.Name = "txtNombreNoAdeudo";
            txtNombreNoAdeudo.Size = new Size(640, 24);
            txtNombreNoAdeudo.TabIndex = 12;
            txtNombreNoAdeudo.TextChanged += txtNombreNoAdeudo_TextChanged;
            // 
            // lblCorreoNoAdeudo
            // 
            lblCorreoNoAdeudo.Location = new Point(675, 85);
            lblCorreoNoAdeudo.Name = "lblCorreoNoAdeudo";
            lblCorreoNoAdeudo.Size = new Size(200, 20);
            lblCorreoNoAdeudo.TabIndex = 13;
            lblCorreoNoAdeudo.Text = "Correo electrónico";
            // 
            // txtCorreoNoAdeudo
            // 
            txtCorreoNoAdeudo.Location = new Point(675, 107);
            txtCorreoNoAdeudo.Name = "txtCorreoNoAdeudo";
            txtCorreoNoAdeudo.Size = new Size(200, 24);
            txtCorreoNoAdeudo.TabIndex = 14;
            // 
            // lblDomicilioNoAdeudo
            // 
            lblDomicilioNoAdeudo.Location = new Point(15, 145);
            lblDomicilioNoAdeudo.Name = "lblDomicilioNoAdeudo";
            lblDomicilioNoAdeudo.Size = new Size(860, 20);
            lblDomicilioNoAdeudo.TabIndex = 15;
            lblDomicilioNoAdeudo.Text = "Domicilio";
            // 
            // txtDomicilioNoAdeudo
            // 
            txtDomicilioNoAdeudo.Location = new Point(15, 167);
            txtDomicilioNoAdeudo.Name = "txtDomicilioNoAdeudo";
            txtDomicilioNoAdeudo.Size = new Size(860, 24);
            txtDomicilioNoAdeudo.TabIndex = 16;
            // 
            // grpSolicitud
            // 
            grpSolicitud.Controls.Add(chkNoAdeudo);
            grpSolicitud.Controls.Add(lblPeriodos);
            grpSolicitud.Controls.Add(txtPeriodos);
            grpSolicitud.Controls.Add(lblUbicacionPredio);
            grpSolicitud.Controls.Add(txtUbicacionPredio);
            grpSolicitud.Controls.Add(lblMotivo);
            grpSolicitud.Controls.Add(txtMotivo);
            grpSolicitud.Controls.Add(lblPresentaComo);
            grpSolicitud.Controls.Add(rbTitular);
            grpSolicitud.Controls.Add(rbApoderado);
            grpSolicitud.Location = new Point(15, 230);
            grpSolicitud.Name = "grpSolicitud";
            grpSolicitud.Size = new Size(900, 250);
            grpSolicitud.TabIndex = 1;
            grpSolicitud.TabStop = false;
            grpSolicitud.Text = "Datos de la solicitud";
            // 
            // chkNoAdeudo
            // 
            chkNoAdeudo.Checked = true;
            chkNoAdeudo.CheckState = CheckState.Checked;
            chkNoAdeudo.Location = new Point(15, 25);
            chkNoAdeudo.Name = "chkNoAdeudo";
            chkNoAdeudo.Size = new Size(500, 24);
            chkNoAdeudo.TabIndex = 17;
            chkNoAdeudo.Text = "Constancia de No Adeudo de Tributos Municipales";
            chkNoAdeudo.UseVisualStyleBackColor = true;
            // 
            // lblPeriodos
            // 
            lblPeriodos.Location = new Point(15, 55);
            lblPeriodos.Name = "lblPeriodos";
            lblPeriodos.Size = new Size(380, 20);
            lblPeriodos.TabIndex = 18;
            lblPeriodos.Text = "Períodos (ej.: 2024 - 2026)";
            // 
            // txtPeriodos
            // 
            txtPeriodos.Location = new Point(15, 77);
            txtPeriodos.Name = "txtPeriodos";
            txtPeriodos.Size = new Size(380, 24);
            txtPeriodos.TabIndex = 19;
            // 
            // lblUbicacionPredio
            // 
            lblUbicacionPredio.Location = new Point(415, 55);
            lblUbicacionPredio.Name = "lblUbicacionPredio";
            lblUbicacionPredio.Size = new Size(460, 20);
            lblUbicacionPredio.TabIndex = 20;
            lblUbicacionPredio.Text = "Predio ubicado en";
            // 
            // txtUbicacionPredio
            // 
            txtUbicacionPredio.Location = new Point(415, 77);
            txtUbicacionPredio.Name = "txtUbicacionPredio";
            txtUbicacionPredio.Size = new Size(460, 24);
            txtUbicacionPredio.TabIndex = 21;
            // 
            // lblMotivo
            // 
            lblMotivo.Location = new Point(15, 115);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(400, 20);
            lblMotivo.TabIndex = 22;
            lblMotivo.Text = "Sustento y/o motivo (obligatorio)";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(15, 137);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.ScrollBars = ScrollBars.Vertical;
            txtMotivo.Size = new Size(860, 60);
            txtMotivo.TabIndex = 23;
            // 
            // lblPresentaComo
            // 
            lblPresentaComo.Location = new Point(15, 212);
            lblPresentaComo.Name = "lblPresentaComo";
            lblPresentaComo.Size = new Size(200, 20);
            lblPresentaComo.TabIndex = 24;
            lblPresentaComo.Text = "Presenta la solicitud como:";
            // 
            // rbTitular
            // 
            rbTitular.Checked = true;
            rbTitular.Location = new Point(220, 210);
            rbTitular.Name = "rbTitular";
            rbTitular.Size = new Size(100, 24);
            rbTitular.TabIndex = 25;
            rbTitular.TabStop = true;
            rbTitular.Text = "Titular";
            rbTitular.UseVisualStyleBackColor = true;
            // 
            // rbApoderado
            // 
            rbApoderado.Location = new Point(330, 210);
            rbApoderado.Name = "rbApoderado";
            rbApoderado.Size = new Size(120, 24);
            rbApoderado.TabIndex = 26;
            rbApoderado.Text = "Apoderado";
            rbApoderado.UseVisualStyleBackColor = true;
            // 
            // grpAdjuntos
            // 
            grpAdjuntos.Controls.Add(btnAdjuntarNoAdeudo);
            grpAdjuntos.Controls.Add(btnQuitarAdjunto);
            grpAdjuntos.Controls.Add(dgvAdjuntosNoAdeudo);
            grpAdjuntos.Location = new Point(15, 490);
            grpAdjuntos.Name = "grpAdjuntos";
            grpAdjuntos.Size = new Size(900, 140);
            grpAdjuntos.TabIndex = 2;
            grpAdjuntos.TabStop = false;
            grpAdjuntos.Text = "Documentos adjuntos";
            // 
            // btnAdjuntarNoAdeudo
            // 
            btnAdjuntarNoAdeudo.BackColor = Color.FromArgb(24, 61, 114);
            btnAdjuntarNoAdeudo.FlatStyle = FlatStyle.Flat;
            btnAdjuntarNoAdeudo.ForeColor = Color.White;
            btnAdjuntarNoAdeudo.Location = new Point(15, 25);
            btnAdjuntarNoAdeudo.Name = "btnAdjuntarNoAdeudo";
            btnAdjuntarNoAdeudo.Size = new Size(150, 32);
            btnAdjuntarNoAdeudo.TabIndex = 27;
            btnAdjuntarNoAdeudo.Text = "Adjuntar archivo";
            btnAdjuntarNoAdeudo.UseVisualStyleBackColor = false;
            btnAdjuntarNoAdeudo.Click += btnAdjuntarNoAdeudo_Click;
            // 
            // btnQuitarAdjunto
            // 
            btnQuitarAdjunto.Location = new Point(15, 65);
            btnQuitarAdjunto.Name = "btnQuitarAdjunto";
            btnQuitarAdjunto.Size = new Size(150, 32);
            btnQuitarAdjunto.TabIndex = 28;
            btnQuitarAdjunto.Text = "Quitar";
            btnQuitarAdjunto.UseVisualStyleBackColor = true;
            btnQuitarAdjunto.Click += btnQuitarAdjunto_Click;
            // 
            // dgvAdjuntosNoAdeudo
            // 
            dgvAdjuntosNoAdeudo.AllowUserToAddRows = false;
            dgvAdjuntosNoAdeudo.AllowUserToDeleteRows = false;
            dgvAdjuntosNoAdeudo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdjuntosNoAdeudo.BackgroundColor = Color.White;
            dgvAdjuntosNoAdeudo.ColumnHeadersHeight = 29;
            dgvAdjuntosNoAdeudo.Columns.AddRange(new DataGridViewColumn[] { colNombreArchivo, colRutaArchivo });
            dgvAdjuntosNoAdeudo.Location = new Point(180, 22);
            dgvAdjuntosNoAdeudo.MultiSelect = false;
            dgvAdjuntosNoAdeudo.Name = "dgvAdjuntosNoAdeudo";
            dgvAdjuntosNoAdeudo.ReadOnly = true;
            dgvAdjuntosNoAdeudo.RowHeadersVisible = false;
            dgvAdjuntosNoAdeudo.RowHeadersWidth = 51;
            dgvAdjuntosNoAdeudo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdjuntosNoAdeudo.Size = new Size(700, 105);
            dgvAdjuntosNoAdeudo.TabIndex = 29;
            // 
            // colNombreArchivo
            // 
            colNombreArchivo.HeaderText = "Archivo";
            colNombreArchivo.MinimumWidth = 6;
            colNombreArchivo.Name = "colNombreArchivo";
            colNombreArchivo.ReadOnly = true;
            // 
            // colRutaArchivo
            // 
            colRutaArchivo.HeaderText = "Ruta";
            colRutaArchivo.MinimumWidth = 6;
            colRutaArchivo.Name = "colRutaArchivo";
            colRutaArchivo.ReadOnly = true;
            // 
            // btnLimpiarNoAdeudo
            // 
            btnLimpiarNoAdeudo.Location = new Point(640, 640);
            btnLimpiarNoAdeudo.Name = "btnLimpiarNoAdeudo";
            btnLimpiarNoAdeudo.Size = new Size(130, 36);
            btnLimpiarNoAdeudo.TabIndex = 30;
            btnLimpiarNoAdeudo.Text = "Limpiar";
            btnLimpiarNoAdeudo.UseVisualStyleBackColor = true;
            btnLimpiarNoAdeudo.Click += btnLimpiarNoAdeudo_Click;
            // 
            // btnGuardarNoAdeudo
            // 
            btnGuardarNoAdeudo.BackColor = Color.FromArgb(24, 61, 114);
            btnGuardarNoAdeudo.FlatStyle = FlatStyle.Flat;
            btnGuardarNoAdeudo.ForeColor = Color.White;
            btnGuardarNoAdeudo.Location = new Point(785, 640);
            btnGuardarNoAdeudo.Name = "btnGuardarNoAdeudo";
            btnGuardarNoAdeudo.Size = new Size(130, 36);
            btnGuardarNoAdeudo.TabIndex = 31;
            btnGuardarNoAdeudo.Text = "Guardar solicitud";
            btnGuardarNoAdeudo.UseVisualStyleBackColor = false;
            btnGuardarNoAdeudo.Click += btnGuardarNoAdeudo_Click;
            // 
            // FrmConstanciaNoAdeudo
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(950, 700);
            Controls.Add(grpContribuyente);
            Controls.Add(grpSolicitud);
            Controls.Add(grpAdjuntos);
            Controls.Add(btnLimpiarNoAdeudo);
            Controls.Add(btnGuardarNoAdeudo);
            Font = new Font("Segoe UI", 9.5F);
            Name = "FrmConstanciaNoAdeudo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Solicitud de Constancia de No Adeudo";
            grpContribuyente.ResumeLayout(false);
            grpContribuyente.PerformLayout();
            grpSolicitud.ResumeLayout(false);
            grpSolicitud.PerformLayout();
            grpAdjuntos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdjuntosNoAdeudo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpContribuyente;
        private System.Windows.Forms.GroupBox grpSolicitud;
        private System.Windows.Forms.GroupBox grpAdjuntos;
        private System.Windows.Forms.Label lblCodigoContribuyente;
        private System.Windows.Forms.TextBox txtCodigoContribuyente;
        private System.Windows.Forms.Label lblDniNoAdeudo;
        private System.Windows.Forms.TextBox txtDniNoAdeudo;
        private System.Windows.Forms.Label lblTelefonoNoAdeudo;
        private System.Windows.Forms.TextBox txtTelefonoNoAdeudo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblNombreNoAdeudo;
        private System.Windows.Forms.TextBox txtNombreNoAdeudo;
        private System.Windows.Forms.Label lblCorreoNoAdeudo;
        private System.Windows.Forms.TextBox txtCorreoNoAdeudo;
        private System.Windows.Forms.Label lblDomicilioNoAdeudo;
        private System.Windows.Forms.TextBox txtDomicilioNoAdeudo;
        private System.Windows.Forms.CheckBox chkNoAdeudo;
        private System.Windows.Forms.Label lblPeriodos;
        private System.Windows.Forms.TextBox txtPeriodos;
        private System.Windows.Forms.Label lblUbicacionPredio;
        private System.Windows.Forms.TextBox txtUbicacionPredio;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblPresentaComo;
        private System.Windows.Forms.RadioButton rbTitular;
        private System.Windows.Forms.RadioButton rbApoderado;
        private System.Windows.Forms.Button btnAdjuntarNoAdeudo;
        private System.Windows.Forms.Button btnQuitarAdjunto;
        private System.Windows.Forms.DataGridView dgvAdjuntosNoAdeudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRutaArchivo;
        private System.Windows.Forms.Button btnLimpiarNoAdeudo;
        private System.Windows.Forms.Button btnGuardarNoAdeudo;
    }
}
