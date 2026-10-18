using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTramitesMunicipales
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        void Salir()
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Estas seguro de salir",
                                        "Mensaje de confirmacion",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void AbrirNuevoTramite()
        {
            FrmNuevoTramite formulario = new FrmNuevoTramite();
            FrmPrincipal principal = this.MdiParent as FrmPrincipal;

            if (principal != null)
            {
                principal.AbrirFormulario(formulario);
            }
        }

    }
}
