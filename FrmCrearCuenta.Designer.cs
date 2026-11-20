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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearCuenta));
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
            pnlLogo.Margin = new Padding(3, 4, 3, 4);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(405, 735);
            pnlLogo.TabIndex = 2;
            pnlLogo.Paint += pnlLogo_Paint;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(73, 77);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(271, 215);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblMunicipalidad
            // 
            lblMunicipalidad.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMunicipalidad.ForeColor = Color.White;
            lblMunicipalidad.Location = new Point(0, 279);
            lblMunicipalidad.Name = "lblMunicipalidad";
            lblMunicipalidad.Size = new Size(411, 120);
            lblMunicipalidad.TabIndex = 3;
            lblMunicipalidad.Text = "Municipalidad de\nLos Olivos";
            lblMunicipalidad.TextAlign = ContentAlignment.MiddleCenter;
            lblMunicipalidad.Click += lblMunicipalidad_Click;
            // 
            // lblGerencia
            // 
            lblGerencia.ForeColor = Color.White;
            lblGerencia.Location = new Point(-7, 399);
            lblGerencia.Name = "lblGerencia";
            lblGerencia.Size = new Size(411, 53);
            lblGerencia.TabIndex = 4;
            lblGerencia.Text = "Gerencia de Administración Tributaria y Rentas";
            lblGerencia.TextAlign = ContentAlignment.MiddleCenter;
            lblGerencia.Click += lblGerencia_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(24, 61, 114);
            lblTitulo.Location = new Point(457, 55);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(434, 51);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Crear Cuenta Nueva";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(457, 105);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(343, 20);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Completar los datos del nuevo usuario del sistema";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.Location = new Point(457, 155);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(256, 27);
            lblNombreUsuario.TabIndex = 8;
            lblNombreUsuario.Text = "Nombre de Usuario";
            lblNombreUsuario.Click += lblUsuario_Click;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(457, 185);
            txtNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(255, 27);
            txtNombreUsuario.TabIndex = 9;
            txtNombreUsuario.TextChanged += txtNombreUsuario_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(457, 235);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(256, 27);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombres";
            lblNombre.Click += lblNombre_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(457, 265);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(255, 27);
            txtNombre.TabIndex = 11;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblApellido
            // 
            lblApellido.Location = new Point(457, 325);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(256, 27);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "Apellidos";
            lblApellido.Click += lblApellido_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(457, 356);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(255, 27);
            txtApellido.TabIndex = 13;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // lblDni
            // 
            lblDni.Location = new Point(457, 416);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(256, 27);
            lblDni.TabIndex = 14;
            lblDni.Text = "DNI";
            lblDni.Click += lblDni_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(457, 447);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(255, 27);
            txtDni.TabIndex = 15;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // lblTelefono
            // 
            lblTelefono.Location = new Point(457, 500);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(256, 27);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Telefono";
            lblTelefono.Click += label5_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(457, 531);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(255, 27);
            txtTelefono.TabIndex = 17;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // lblContrasena
            // 
            lblContrasena.Location = new Point(769, 155);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(256, 27);
            lblContrasena.TabIndex = 18;
            lblContrasena.Text = "Contraseña";
            lblContrasena.Click += lblContrasena_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(769, 185);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(255, 27);
            txtContrasena.TabIndex = 19;
            txtContrasena.UseSystemPasswordChar = true;
            txtContrasena.TextChanged += txtContrasena_TextChanged;
            // 
            // lblConfirmarContrasena
            // 
            lblConfirmarContrasena.Location = new Point(769, 235);
            lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            lblConfirmarContrasena.Size = new Size(256, 27);
            lblConfirmarContrasena.TabIndex = 20;
            lblConfirmarContrasena.Text = "Confirmar Contraseña";
            lblConfirmarContrasena.Click += lblConfirmarContrasena_Click;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Location = new Point(769, 265);
            txtConfirmarContrasena.Margin = new Padding(3, 4, 3, 4);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Size = new Size(255, 27);
            txtConfirmarContrasena.TabIndex = 21;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            txtConfirmarContrasena.TextChanged += txtConfirmarContrasena_TextChanged;
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.Location = new Point(769, 325);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(256, 27);
            lblCorreoElectronico.TabIndex = 22;
            lblCorreoElectronico.Text = "Correo Electronico";
            lblCorreoElectronico.Click += lblCorreoElectronico_Click;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(769, 356);
            txtCorreoElectronico.Margin = new Padding(3, 4, 3, 4);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(255, 27);
            txtCorreoElectronico.TabIndex = 23;
            txtCorreoElectronico.TextChanged += txtCorreoElectronico_TextChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(24, 61, 114);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(769, 435);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(256, 51);
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
            btnCancelar.Location = new Point(769, 519);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(256, 51);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmCrearCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 735);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCrearCuenta";
            Text = "FrmCrearCuenta";
            Load += FrmCrearCuenta_Load;
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