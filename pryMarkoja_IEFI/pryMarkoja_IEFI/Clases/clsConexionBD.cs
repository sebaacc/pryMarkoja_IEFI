using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryMarkoja_IEFI.Objetos;

namespace pryMarkoja_IEFI.Clases
{
    internal class clsConexionBD
    {
        public static readonly string CadenaConexion = "Server=localhost;Database=Auditoria;Trusted_Connection=True;";

        public void CargarHistorialTareasUsuario(DataGridView dgvHistorial)
        {
            string query = @"
                SELECT 
                    T.Id,
                    T.FechaTarea,
                    TT.Nombre AS TipoTarea,
                    L.Nombre AS Lugar,
                    T.Detalle,
                    T.Comentario
                FROM Tarea T
                INNER JOIN TipoTarea TT ON T.IdTipoTarea = TT.Id
                INNER JOIN Lugar L ON T.IdLugar = L.Id
                WHERE T.UsuarioId = @UsuarioId
                ORDER BY T.FechaTarea DESC";

            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@UsuarioId", clsUsuarioLogueado.Id);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dt);
                    dgvHistorial.DataSource = dt;

                    dgvHistorial.Columns["Id"].HeaderText = "ID";
                    dgvHistorial.Columns["FechaTarea"].HeaderText = "Fecha";
                    dgvHistorial.Columns["TipoTarea"].HeaderText = "Tipo de Tarea";
                    dgvHistorial.Columns["Lugar"].HeaderText = "Lugar";
                    dgvHistorial.Columns["Detalle"].HeaderText = "Detalle";
                    dgvHistorial.Columns["Comentario"].HeaderText = "Comentario";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar historial: " + ex.Message);
                }
            }
        }
    }
}
