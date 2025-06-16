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
        clsTarea tarea = new clsTarea(); 
        private readonly int usuarioId;
        public frmTarea()
        {
            InitializeComponent();
            usuarioId = clsUsuarioLogueado.Id;

            CargarTiposTarea();
            CargarLugares();
            
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
        public void CargarTiposTarea()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(clsConexionBD.CadenaConexion))
                {
                    conexion.Open();
                    string query = @"SELECT Id, Nombre FROM TipoTarea";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            DataTable tabla = new DataTable();
                            adaptador.Fill(tabla);

                            cmbTarea.DataSource = tabla;
                            cmbTarea.DisplayMember = "Nombre";
                            cmbTarea.ValueMember = "Id";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error. " + ex);   
            }
        }
        public void CargarLugares()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(clsConexionBD.CadenaConexion))
                {
                    conexion.Open();
                    string query = @"SELECT Id, Nombre FROM Lugar";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            DataTable tabla = new DataTable();
                            adaptador.Fill(tabla);

                            cmbLugar.DataSource = tabla;
                            cmbLugar.DisplayMember = "Nombre";
                            cmbLugar.ValueMember = "Id";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error. " + ex);
            }
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
            try
            {
                using (SqlConnection conexion = new SqlConnection(clsConexionBD.CadenaConexion))
                {
                    conexion.Open();

                    foreach (clsTarea tarea in listaTareasAñadidas)
                    {
                        string query = @"INSERT INTO Tarea (UsuarioId, FechaTarea, Detalle, Comentario, IdTipoTarea, IdLugar)
                                 VALUES (@UsuarioId, @FechaTarea, @Detalle, @Comentario, @IdTipoTarea, @IdLugar)";

                        using (SqlCommand comando = new SqlCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@UsuarioId", usuarioId);
                            comando.Parameters.AddWithValue("@FechaTarea", tarea.FechaTarea);
                            comando.Parameters.AddWithValue("@Detalle", tarea.Detalle ?? "");
                            comando.Parameters.AddWithValue("@Comentario", tarea.Comentario ?? "");
                            comando.Parameters.AddWithValue("@IdTipoTarea", tarea.TipoTarea);
                            comando.Parameters.AddWithValue("@IdLugar", tarea.Lugar);

                            comando.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Todas las tareas se grabaron correctamente.");

                    listaTareasAñadidas.Clear();
                    dgvTareas.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar tareas: " + ex.Message);
            }
        }
    }
}
