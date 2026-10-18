
using System;
using System.Windows.Forms;

namespace SistemaTramitesMunicipales
{
    public partial class FrmPrincipal : Form
    {
        // ==================== CONSTRUCTOR ====================

        public FrmPrincipal()
        {
            InitializeComponent();
        }


        // ==================== BOTONES Y EVENTOS ====================

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosAbiertos();

            FrmLogin frmLogin = new FrmLogin();
            AbrirFormulario(frmLogin);
        }

        private void crearCuToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarFormulariosAbiertos();

            FrmCrearCuenta frmCrearCuenta = new FrmCrearCuenta();
            AbrirFormulario(frmCrearCuenta);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
        }


        // ==================== MÉTODOS VOID ====================

        private void Salir()
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de salir?",
                "Mensaje de confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CerrarFormulariosAbiertos()
        {
            foreach (Form formulario in this.MdiChildren)
            {
                formulario.Close();
            }
        }

        public void AbrirFormulario(Form formulario)
        {
            foreach (Form hijo in this.MdiChildren)
            {
                hijo.Close();
            }

            this.IsMdiContainer = true;

            formulario.MdiParent = this;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }
    }
}
