using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            frmUsuarios v = new frmUsuarios();
            v.ShowDialog();
        }

        private void auditoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria v = new frmAuditoria();
            v.ShowDialog();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin v = new frmLogin();
            v.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void historialDeTareasDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //historial COMPLETO 
        }

        private void añadirTipoDeTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarTarea frm = new frmAgregarTarea();
            frm.ShowDialog();
        }

        private void añadirLugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarLugar frm = new frmAgregarLugar();
            frm.ShowDialog();
        }
    }
}
