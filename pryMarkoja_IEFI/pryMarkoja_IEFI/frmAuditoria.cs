using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryMarkoja_IEFI.Clases;

namespace pryMarkoja_IEFI
{
    public partial class frmAuditoria : Form
    {
        clsAuditoriaService servicioAuditoria = new clsAuditoriaService();
        public frmAuditoria()
        {
            InitializeComponent();
            DateTime hoy = DateTime.Today;
            dtpDesde.MaxDate = hoy;
            dtpHasta.MaxDate = hoy;
            formateoInicial();
        }
        private void CargarSoloPorNombre()
        {
            try
            {
                string nombreBuscado = txtBuscar.Text.Trim();
                var tabla = servicioAuditoria.ObtenerTiemposPorNombre(nombreBuscado);
                
                    dgvAuditoria.DataSource = tabla;
                if (tabla != null && tabla.Rows.Count > 0)
                {
                    dgvAuditoria.Columns["TotalSegundosTrabajados"].Visible = false;

                }
                else
                {
                    MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void CargarSoloPorFechas()
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);
            var tabla = servicioAuditoria.ObtenerTiemposPorFechas(desde, hasta);
            dgvAuditoria.DataSource = tabla;
            dgvAuditoria.Columns["TotalSegundosTrabajados"].Visible = false;
        }

        private void CargarPorNombreYFechas()
        {
            string nombreBuscado = txtBuscar.ToString();
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);
            var tabla = servicioAuditoria.ObtenerTiemposPorNombreYFechas(nombreBuscado, desde, hasta);
            dgvAuditoria.DataSource = tabla;
            dgvAuditoria.Columns["TotalSegundosTrabajados"].Visible = false;
        }
        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                CargarSoloPorNombre();
            }
            else
            {
                MessageBox.Show("Por favor complete el campo del nombre de usuario.");
            }
        }

        private void btnFiltrarFecha_Click(object sender, EventArgs e)
        {

            CargarSoloPorFechas();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            formateoInicial();
        }

        private void formateoInicial()
        {
            servicioAuditoria.ObtenerTodosLosTiempos();
            dgvAuditoria.DataSource = servicioAuditoria.ObtenerTodosLosTiempos();
        }
        private void TiempoSistema_Tick(object sender, EventArgs e)
        {
            lblFechaHoraSistema.Text = DateTime.Now.ToString();
        }

        private void btnFiltrarFechaYNombre_Click(object sender, EventArgs e)
        {
            CargarPorNombreYFechas();
        }
    }
}
