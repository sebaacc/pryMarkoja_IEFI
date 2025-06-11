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
    public partial class frmPrincipalUsuario : Form
    {
        private DateTime sesionStartTime;
        private int sesionId;
        private int usuarioId;

        public frmPrincipalUsuario(int idUsuario)
        {
            InitializeComponent();
            usuarioId = idUsuario;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            sesionStartTime = DateTime.Now;

            // Insertar en la base de datos el inicio de sesión
            using (SqlConnection conn = new SqlConnection(clsConexionBD.CadenaConexion))
            {
                conn.Open();
                string query = "INSERT INTO SesionTrabajo (UsuarioId, FechaInicio) OUTPUT INSERTED.Id VALUES (@usuarioId, @fechaInicio)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuarioId", usuarioId);
                    cmd.Parameters.AddWithValue("@fechaInicio", sesionStartTime);
                    sesionId = (int)cmd.ExecuteScalar();
                }
            }

            // Iniciar Timer
            tSessionTimer.Interval = 1000; // 1 segundo
            tSessionTimer.Tick += tSessionTimer_Tick;
            tSessionTimer.Start();
        }

        private void tSessionTimer_Tick(object sender, EventArgs e)
        {
            lblTiempoStatus.Text = (DateTime.Now - sesionStartTime).ToString(@"hh\:mm\:ss");
        }
        private void RegistrarFechaFin()
        {
            DateTime sessionEndTime = DateTime.Now;

            using (SqlConnection conn = new SqlConnection(clsConexionBD.CadenaConexion))
            {
                conn.Open();
                string query = "UPDATE SesionTrabajo SET FechaFin = @fechaFin WHERE Id = @sesionId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fechaFin", sessionEndTime);
                    cmd.Parameters.AddWithValue("@sesionId", sesionId);
                    cmd.ExecuteNonQuery();
                }
            }

            tSessionTimer.Stop();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarFechaFin();
            this.Close();
            frmLogin v = new frmLogin();
            v.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarFechaFin();
            Application.Exit();
        }

        private void crearTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTarea tareas = new frmTarea();
            tareas.ShowDialog();
        }

        private void verHistorialDeTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial historial = new frmHistorial();
            historial.ShowDialog();
        }
    }
}
