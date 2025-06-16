using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryMarkoja_IEFI.Objetos;

namespace pryMarkoja_IEFI
{
    public partial class frmPrincipalAdmin : Form
    {
        public frmPrincipalAdmin()
        {
            InitializeComponent();
        }

        private void TiempoSistema_Tick(object sender, EventArgs e)
        {
            lblFechaHoraSistema.Text = DateTime.Now.ToString();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.ShowDialog();
        }

        private void auditoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria frm = new frmAuditoria();
            frm.ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            clsUsuarioLogueado.CerrarSesion();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void historialDeTareasDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial frm = new frmHistorial();
            frm.ShowDialog();
        }

        private void añadirTipoDeTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarTipoTarea frm = new frmAgregarTipoTarea();
            frm.ShowDialog();
        }

        private void añadirLugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarLugar frm = new frmAgregarLugar();
            frm.ShowDialog();
        }
    }
}
