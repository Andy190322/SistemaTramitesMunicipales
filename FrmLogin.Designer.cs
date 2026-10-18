namespace SistemaTramitesMunicipales
{
    partial class FrmLogin
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
            pnlAcceso = new Panel();
            lblTitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            btnIngresar = new Button();
            pnlLogo = new Panel();
            picLogo = new PictureBox();
            lblMunicipalidad = new Label();
            lblGerencia = new Label();
            pnlAcceso.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlAcceso
            // 
            pnlAcceso.Controls.Add(lblTitulo);
            pnlAcceso.Controls.Add(lblUsuario);
            pnlAcceso.Controls.Add(txtUsuario);
            pnlAcceso.Controls.Add(lblContrasena);
            pnlAcceso.Controls.Add(txtContrasena);
            pnlAcceso.Controls.Add(btnIngresar);
            pnlAcceso.Dock = DockStyle.Fill;
            pnlAcceso.Location = new Point(400, 0);
            pnlAcceso.Name = "pnlAcceso";
            pnlAcceso.Size = new Size(450, 500);
            pnlAcceso.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(24, 61, 114);
            lblTitulo.Location = new Point(30, 90);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(380, 60);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Sistema de Trámites Municipales";
            // 
            // lblUsuario
            // 
            lblUsuario.Location = new Point(30, 170);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(300, 20);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(30, 194);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(340, 24);
            txtUsuario.TabIndex = 7;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // lblContrasena
            // 
            lblContrasena.Location = new Point(30, 235);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(300, 20);
            lblContrasena.TabIndex = 8;
            lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(30, 259);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(340, 24);
            txtContrasena.TabIndex = 9;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(24, 61, 114);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(30, 310);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(340, 38);
            btnIngresar.TabIndex = 10;
            btnIngresar.Text = "Ingresar al sistema";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
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
            pnlLogo.Size = new Size(400, 500);
            pnlLogo.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(160, 110);
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
            lblMunicipalidad.Location = new Point(20, 210);
            lblMunicipalidad.Name = "lblMunicipalidad";
            lblMunicipalidad.Size = new Size(360, 90);
            lblMunicipalidad.TabIndex = 3;
            lblMunicipalidad.Text = "Municipalidad de\nLos Olivos";
            lblMunicipalidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGerencia
            // 
            lblGerencia.ForeColor = Color.White;
            lblGerencia.Location = new Point(20, 310);
            lblGerencia.Name = "lblGerencia";
            lblGerencia.Size = new Size(360, 40);
            lblGerencia.TabIndex = 4;
            lblGerencia.Text = "Gerencia de Administración Tributaria y Rentas";
            lblGerencia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AcceptButton = btnIngresar;
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(850, 500);
            Controls.Add(pnlAcceso);
            Controls.Add(pnlLogo);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesión";
            pnlAcceso.ResumeLayout(false);
            pnlAcceso.PerformLayout();
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlAcceso;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblMunicipalidad;
        private System.Windows.Forms.Label lblGerencia;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnIngresar;
    }
}
