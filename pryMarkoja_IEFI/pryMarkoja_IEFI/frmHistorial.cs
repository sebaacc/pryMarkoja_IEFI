using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryMarkoja_IEFI.Clases;
using pryMarkoja_IEFI.Objetos;

namespace pryMarkoja_IEFI
{
    public partial class frmHistorial : Form
    {
        clsTareaService BD = new clsTareaService();
        public frmHistorial()
        {
            InitializeComponent();
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            BD.CargarTiposTarea(cmbTipoTarea);
            BD.CargarLugares(cmbLugar); 
            BD.CargarHistorialTareasUsuario(dgvHistorial);
            DateTime hoy = DateTime.Today;
            dtpDesde.MaxDate = hoy;
            dtpHasta.MaxDate = hoy;
            if (clsUsuarioLogueado.EsAdministrador == false)
            {
                lblBuscarUsuario.Visible = false;
                txtNombreUsuario.Visible = false;
                btnBuscar.Visible = false; 
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BD.FiltrarPorNombreUsuario(txtNombreUsuario.Text, dgvHistorial);
        }

        private void btnFiltrarFecha_Click(object sender, EventArgs e)
        {
            BD.FiltrarPorRangoFechas(dtpDesde.Value.Date,dtpHasta.Value.Date,dgvHistorial);
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            BD.CargarHistorialTareasUsuario(dgvHistorial);
            txtNombreUsuario.Text = "";
            cmbLugar.SelectedIndex = 0;
            cmbTipoTarea.SelectedIndex = 0;
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
        }

        private void cmbTipoTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoTarea = cmbTipoTarea.Text;
            BD.FiltrarPorTipoTarea(tipoTarea, dgvHistorial);
        }

        private void cmbLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lugar = cmbLugar.Text;
            BD.FiltrarPorLugar(lugar, dgvHistorial);
        }
    }
}
