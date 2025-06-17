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
using pryMarkoja_IEFI.Objetos;

namespace pryMarkoja_IEFI
{
    public partial class frmTarea : Form
    {
        clsFuncionesUtiles funciones = new clsFuncionesUtiles();
        List<clsTarea> listaTareasAñadidas = new List<clsTarea>();
        private readonly int usuarioId;
        clsTareaService BD = new clsTareaService();
        public frmTarea()
        {
            InitializeComponent();
            usuarioId = clsUsuarioLogueado.Id;

            BD.CargarTiposTarea(cmbTarea);
            BD.CargarLugares(cmbLugar);
            DateTime hoy = DateTime.Today;
            dtpFecha.MaxDate = hoy;
        }

        //graficos de flechas en detalle en paneles:
        private void pCanvas_Paint(object sender, PaintEventArgs e)
        {
            funciones.dibujarFlechaDerecha(sender, e);
        }

        private void pCanvas2_Paint(object sender, PaintEventArgs e)
        {
            funciones.dibujarFlechaDerecha(sender, e);
        }

        private void pCanvas3_Paint(object sender, PaintEventArgs e)
        {
            funciones.dibujarFlechaDerecha(sender, e);
        }

        private void pCanvas4_Paint(object sender, PaintEventArgs e)
        {
            funciones.dibujarFlechaDerecha(sender, e);
        }

        private void pCanvas5_Paint(object sender, PaintEventArgs e)
        {
            funciones.dibujarFlechaDerecha(sender, e);
        }

        private void volverAMenúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (cmbTarea.SelectedIndex == -1 || cmbLugar.SelectedIndex == -1 || dtpFecha.Value == null)
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.");
                return;
            }

            int tipoId = Convert.ToInt32(cmbTarea.SelectedValue);
            int lugarId = Convert.ToInt32(cmbLugar.SelectedValue);
            DateTime fecha = dtpFecha.Value;
            string comentario = txtComentario.Text;
            string detalle = generarDetalle();
            clsTarea nuevaTarea = new clsTarea(tipoId, lugarId, fecha, comentario, detalle);
            listaTareasAñadidas.Add(nuevaTarea);

            dgvTareas.Rows.Add(cmbTarea.Text, cmbLugar.Text, fecha.ToShortDateString(), detalle, comentario);
        }

        public string generarDetalle()
        {
            List<string> detalle = new List<string>();

            if (chkInsumo.Checked) detalle.Add("Insumo");
            if (chkEstudio.Checked) detalle.Add("Estudio");
            if (chkVacacion.Checked) detalle.Add("Vacación");
            if (chkSalario.Checked) detalle.Add("Salario");
            if (chkRecibo.Checked) detalle.Add("Recibo");

            return string.Join("; ", detalle);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            BD.GrabarTareas(listaTareasAñadidas, dgvTareas);
        }

        private void btnBorrarTareas_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar todas las tareas antes de grabarlas en la base de datos?", "Estás por borrar las tareas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                listaTareasAñadidas.Clear();

                dgvTareas.DataSource = null;
                dgvTareas.Rows.Clear();

                MessageBox.Show("Todas las tareas han sido eliminadas.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
