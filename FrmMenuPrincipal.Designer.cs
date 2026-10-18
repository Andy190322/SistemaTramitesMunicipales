namespace SistemaTramitesMunicipales
{
    partial class FrmMenuPrincipal
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
            pnlContenido = new Panel();
            lblBienvenida = new Label();
            lblUsuarioActual = new Label();
            btnAccesoNuevo = new Button();
            btnAccesoConsulta = new Button();
            pnlMenu = new Panel();
            lblSistema = new Label();
            btnNuevoTramite = new Button();
            btnConsultar = new Button();
            btnCerrarSesion = new Button();
            pnlContenido.SuspendLayout();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.WhiteSmoke;
            pnlContenido.Controls.Add(lblBienvenida);
            pnlContenido.Controls.Add(lblUsuarioActual);
            pnlContenido.Controls.Add(btnAccesoNuevo);
            pnlContenido.Controls.Add(btnAccesoConsulta);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(230, 0);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Padding = new Padding(20);
            pnlContenido.Size = new Size(870, 680);
            pnlContenido.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(24, 61, 114);
            lblBienvenida.Location = new Point(20, 20);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(700, 40);
            lblBienvenida.TabIndex = 8;
            lblBienvenida.Text = "Bienvenido al sistema";
            // 
            // lblUsuarioActual
            // 
            lblUsuarioActual.Location = new Point(20, 65);
            lblUsuarioActual.Name = "lblUsuarioActual";
            lblUsuarioActual.Size = new Size(500, 24);
            lblUsuarioActual.TabIndex = 9;
            lblUsuarioActual.Text = "Usuario: (nombre del trabajador)";
            // 
            // btnAccesoNuevo
            // 
            btnAccesoNuevo.BackColor = Color.FromArgb(24, 61, 114);
            btnAccesoNuevo.FlatStyle = FlatStyle.Flat;
            btnAccesoNuevo.ForeColor = Color.White;
            btnAccesoNuevo.Location = new Point(20, 120);
            btnAccesoNuevo.Name = "btnAccesoNuevo";
            btnAccesoNuevo.Size = new Size(220, 70);
            btnAccesoNuevo.TabIndex = 10;
            btnAccesoNuevo.Text = "Nuevo trámite";
            btnAccesoNuevo.UseVisualStyleBackColor = false;
            btnAccesoNuevo.Click += btnAccesoNuevo_Click;
            // 
            // btnAccesoConsulta
            // 
            btnAccesoConsulta.Location = new Point(260, 120);
            btnAccesoConsulta.Name = "btnAccesoConsulta";
            btnAccesoConsulta.Size = new Size(220, 70);
            btnAccesoConsulta.TabIndex = 11;
            btnAccesoConsulta.Text = "Consultar trámites";
            btnAccesoConsulta.UseVisualStyleBackColor = true;
            btnAccesoConsulta.Click += btnAccesoConsulta_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(24, 61, 114);
            pnlMenu.Controls.Add(lblSistema);
            pnlMenu.Controls.Add(btnNuevoTramite);
            pnlMenu.Controls.Add(btnConsultar);
            pnlMenu.Controls.Add(btnCerrarSesion);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(230, 680);
            pnlMenu.TabIndex = 1;
            // 
            // lblSistema
            // 
            lblSistema.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSistema.ForeColor = Color.White;
            lblSistema.Location = new Point(0, 10);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(230, 80);
            lblSistema.TabIndex = 2;
            lblSistema.Text = "LOS OLIVOS\nTrámites municipales";
            lblSistema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNuevoTramite
            // 
            btnNuevoTramite.BackColor = Color.FromArgb(24, 61, 114);
            btnNuevoTramite.FlatStyle = FlatStyle.Flat;
            btnNuevoTramite.Font = new Font("Segoe UI", 11F);
            btnNuevoTramite.ForeColor = Color.White;
            btnNuevoTramite.Location = new Point(0, 150);
            btnNuevoTramite.Name = "btnNuevoTramite";
            btnNuevoTramite.Padding = new Padding(20, 0, 0, 0);
            btnNuevoTramite.Size = new Size(230, 46);
            btnNuevoTramite.TabIndex = 4;
            btnNuevoTramite.Text = "Nuevo trámite";
            btnNuevoTramite.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevoTramite.UseVisualStyleBackColor = false;
            btnNuevoTramite.Click += btnNuevoTramite_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.FromArgb(24, 61, 114);
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 11F);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(0, 200);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Padding = new Padding(20, 0, 0, 0);
            btnConsultar.Size = new Size(230, 46);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar trámites";
            btnConsultar.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(24, 61, 114);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 11F);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(0, 252);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(20, 0, 0, 0);
            btnCerrarSesion.Size = new Size(230, 46);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1100, 680);
            Controls.Add(pnlContenido);
            Controls.Add(pnlMenu);
            Font = new Font("Segoe UI", 9.5F);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Municipal - Menú principal";
            pnlContenido.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Button btnNuevoTramite;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblUsuarioActual;
        private System.Windows.Forms.Button btnAccesoNuevo;
        private System.Windows.Forms.Button btnAccesoConsulta;
    }
}
