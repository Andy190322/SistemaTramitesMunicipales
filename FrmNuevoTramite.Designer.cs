namespace SistemaTramitesMunicipales
{
    partial class FrmNuevoTramite
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
            lblTitulo = new Label();
            grpInscripcion = new GroupBox();
            lblDescInscripcion = new Label();
            btnInscripcion = new Button();
            grpNoAdeudo = new GroupBox();
            lblDescNoAdeudo = new Label();
            btnNoAdeudo = new Button();
            btnRegresar = new Button();
            grpInscripcion.SuspendLayout();
            grpNoAdeudo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(24, 61, 114);
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(780, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Seleccione el trámite que desea registrar";
            // 
            // grpInscripcion
            // 
            grpInscripcion.Controls.Add(lblDescInscripcion);
            grpInscripcion.Controls.Add(btnInscripcion);
            grpInscripcion.Location = new Point(30, 100);
            grpInscripcion.Name = "grpInscripcion";
            grpInscripcion.Size = new Size(370, 280);
            grpInscripcion.TabIndex = 1;
            grpInscripcion.TabStop = false;
            grpInscripcion.Text = "Inscripción de Propiedad";
            // 
            // lblDescInscripcion
            // 
            lblDescInscripcion.Location = new Point(15, 35);
            lblDescInscripcion.Name = "lblDescInscripcion";
            lblDescInscripcion.Size = new Size(340, 80);
            lblDescInscripcion.TabIndex = 3;
            lblDescInscripcion.Text = "Registro de la Hoja de Resumen (H.R.), el Predio Urbano (P.U.), la construcción, los copropietarios y los documentos.";
            // 
            // btnInscripcion
            // 
            btnInscripcion.BackColor = Color.FromArgb(24, 61, 114);
            btnInscripcion.FlatStyle = FlatStyle.Flat;
            btnInscripcion.ForeColor = Color.White;
            btnInscripcion.Location = new Point(15, 200);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(340, 45);
            btnInscripcion.TabIndex = 4;
            btnInscripcion.Text = "Registrar inscripción";
            btnInscripcion.UseVisualStyleBackColor = false;
            btnInscripcion.Click += btnInscripcion_Click;
            // 
            // grpNoAdeudo
            // 
            grpNoAdeudo.Controls.Add(lblDescNoAdeudo);
            grpNoAdeudo.Controls.Add(btnNoAdeudo);
            grpNoAdeudo.Location = new Point(420, 100);
            grpNoAdeudo.Name = "grpNoAdeudo";
            grpNoAdeudo.Size = new Size(370, 280);
            grpNoAdeudo.TabIndex = 2;
            grpNoAdeudo.TabStop = false;
            grpNoAdeudo.Text = "Constancia de No Adeudo";
            // 
            // lblDescNoAdeudo
            // 
            lblDescNoAdeudo.Location = new Point(15, 35);
            lblDescNoAdeudo.Name = "lblDescNoAdeudo";
            lblDescNoAdeudo.Size = new Size(340, 80);
            lblDescNoAdeudo.TabIndex = 5;
            lblDescNoAdeudo.Text = "Registro de la solicitud de Constancia de No Adeudo de Tributos Municipales según el Formato de Solicitud.";
            // 
            // btnNoAdeudo
            // 
            btnNoAdeudo.BackColor = Color.FromArgb(24, 61, 114);
            btnNoAdeudo.FlatStyle = FlatStyle.Flat;
            btnNoAdeudo.ForeColor = Color.White;
            btnNoAdeudo.Location = new Point(15, 200);
            btnNoAdeudo.Name = "btnNoAdeudo";
            btnNoAdeudo.Size = new Size(340, 45);
            btnNoAdeudo.TabIndex = 6;
            btnNoAdeudo.Text = "Solicitar constancia";
            btnNoAdeudo.UseVisualStyleBackColor = false;
            btnNoAdeudo.Click += btnNoAdeudo_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(24, 61, 114);
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(720, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(90, 45);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FrmNuevoTramite
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(850, 500);
            Controls.Add(btnRegresar);
            Controls.Add(lblTitulo);
            Controls.Add(grpInscripcion);
            Controls.Add(grpNoAdeudo);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNuevoTramite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleccionar trámite";
            grpInscripcion.ResumeLayout(false);
            grpNoAdeudo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpInscripcion;
        private System.Windows.Forms.GroupBox grpNoAdeudo;
        private System.Windows.Forms.Label lblDescInscripcion;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.Label lblDescNoAdeudo;
        private System.Windows.Forms.Button btnNoAdeudo;
        private Button btnRegresar;
    }
}
