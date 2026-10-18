namespace SistemaTramitesMunicipales
{
    partial class FrmCrearCuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLogo = new Panel();
            picLogo = new PictureBox();
            lblMunicipalidad = new Label();
            lblGerencia = new Label();
            lblTitulo = new Label();
            lblDescripcion = new Label();
            lblNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            lblConfirmarContrasena = new Label();
            txtConfirmarContrasena = new TextBox();
            lblCorreoElectronico = new Label();
            txtCorreoElectronico = new TextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(24, 61, 114);
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Controls.Add(lblMunicipalidad);
            pnlLogo.Controls.Add(lblGerencia);
            pnlLogo.Dock = DockStyle.Left;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(354, 551);
            pnlLogo.TabIndex = 2;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(137, 116);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(80, 80);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblMunicipalidad
            // 
            lblMunicipalidad.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMunicipalidad.ForeColor = Color.White;
            lblMunicipalidad.Location = new Point(0, 209);
            lblMunicipalidad.Name = "lblMunicipalidad";
            lblMunicipalidad.Size = new Size(360, 90);
            lblMunicipalidad.TabIndex = 3;
            lblMunicipalidad.Text = "Municipalidad de\nLos Olivos";
            lblMunicipalidad.TextAlign = ContentAlignment.MiddleCenter;
            lblMunicipalidad.Click += lblMunicipalidad_Click;
            // 
            // lblGerencia
            // 
            lblGerencia.ForeColor = Color.White;
            lblGerencia.Location = new Point(-6, 299);
            lblGerencia.Name = "lblGerencia";
            lblGerencia.Size = new Size(360, 40);
            lblGerencia.TabIndex = 4;
            lblGerencia.Text = "Gerencia de Administración Tributaria y Rentas";
            lblGerencia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(24, 61, 114);
            lblTitulo.Location = new Point(400, 41);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(380, 38);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Crear Cuenta Nueva";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(400, 79);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(272, 15);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Completar los datos del nuevo usuario del sistema";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.Location = new Point(400, 116);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(224, 20);
            lblNombreUsuario.TabIndex = 8;
            lblNombreUsuario.Text = "Nombre de Usuario";
            lblNombreUsuario.Click += lblUsuario_Click;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(400, 139);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(224, 23);
            txtNombreUsuario.TabIndex = 9;
            txtNombreUsuario.TextChanged += txtNombreUsuario_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(400, 176);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(224, 20);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombres";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(400, 199);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 23);
            txtNombre.TabIndex = 11;
            // 
            // lblApellido
            // 
            lblApellido.Location = new Point(400, 244);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(224, 20);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Apellidos";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(400, 267);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(224, 23);
            txtApellido.TabIndex = 13;
            // 
            // lblDni
            // 
            lblDni.Location = new Point(400, 312);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(224, 20);
            lblDni.TabIndex = 14;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(400, 335);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(224, 23);
            txtDni.TabIndex = 15;
            // 
            // lblTelefono
            // 
            lblTelefono.Location = new Point(400, 375);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(224, 20);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Telefono";
            lblTelefono.Click += label5_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(400, 398);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(224, 23);
            txtTelefono.TabIndex = 17;
            // 
            // lblContrasena
            // 
            lblContrasena.Location = new Point(673, 116);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(224, 20);
            lblContrasena.TabIndex = 18;
            lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(673, 139);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(224, 23);
            txtContrasena.TabIndex = 19;
            txtContrasena.UseSystemPasswordChar = true;
            txtContrasena.TextChanged += txtContrasena_TextChanged;
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.Location = new Point(673, 176);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(224, 20);
            lblConfirmarContrasena.TabIndex = 20;
            lblConfirmarContrasena.Text = "Confirmar Contraseña";
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Location = new Point(673, 199);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Size = new Size(224, 23);
            txtConfirmarContrasena.TabIndex = 21;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.Location = new Point(673, 244);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(224, 20);
            lblCorreoElectronico.TabIndex = 22;
            lblCorreoElectronico.Text = "Correo Electronico";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(673, 267);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(224, 23);
            txtCorreoElectronico.TabIndex = 23;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(24, 61, 114);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(673, 326);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(224, 38);
            btnRegistrar.TabIndex = 24;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(673, 389);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(224, 38);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmCrearCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 551);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(lblCorreoElectronico);
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(lblConfirmarContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(lblContrasena);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTitulo);
            Controls.Add(pnlLogo);
            Name = "FrmCrearCuenta";
            Text = "FrmCrearCuenta";
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLogo;
        private PictureBox picLogo;
        private Label lblMunicipalidad;
        private Label lblGerencia;
        private Label lblTitulo;
        private Label lblDescripcion;
        private Label lblNombreUsuario;
        private TextBox txtNombreUsuario;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private Label lblConfirmarContrasena;
        private TextBox txtConfirmarContrasena;
        private Label lblCorreoElectronico;
        private TextBox txtCorreoElectronico;
        private Button btnRegistrar;
        private Button btnCancelar;
    }
}