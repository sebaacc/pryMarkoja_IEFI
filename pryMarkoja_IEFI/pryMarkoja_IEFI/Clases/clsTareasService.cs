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
    public class clsTareasService
    {
        string CadenaConexion = clsConexionBD.CadenaConexion;
        private DataTable historialTareasDataTable;

        public void CargarHistorialTareasUsuario(DataGridView dgvHistorial)
        {
            string query = clsUsuarioLogueado.EsAdministrador == true ?
                (
                @"
                SELECT 
                    T.Id,
                    T.FechaTarea,
                    TT.Nombre AS TipoTarea,
                    L.Nombre AS Lugar,
                    T.Detalle,
                    T.Comentario,
                    U.Nombre + ' ' + U.Apellido AS [Nombre de Usuario]
                FROM Tarea T
                INNER JOIN TipoTarea TT ON T.IdTipoTarea = TT.Id
                INNER JOIN Lugar L ON T.IdLugar = L.Id
                INNER JOIN Usuario U ON T.UsuarioId = U.Id
                ORDER BY T.FechaTarea DESC"
            ) : (
                @"
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
                ORDER BY T.FechaTarea DESC"
            );



            using (SqlConnection conn = new SqlConnection(CadenaConexion))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@UsuarioId", clsUsuarioLogueado.Id);
                historialTareasDataTable = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(historialTareasDataTable);
                    dgvHistorial.DataSource = historialTareasDataTable;

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
        public void CargarTiposTarea(ComboBox cmbTarea)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
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
        public void CargarLugares(ComboBox cmbLugar)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
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

        public void FiltrarPorNombreUsuario(string nombreUsuario, DataGridView dgvHistorial)
        {
            if (historialTareasDataTable == null)
            {
                MessageBox.Show("Primero debe cargar los datos.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                historialTareasDataTable.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                string filtro = $"[Nombre de Usuario] LIKE '%{nombreUsuario.Replace("'", "''")}%'";

                if (historialTareasDataTable.Columns.Contains("Nombre de Usuario"))
                {
                    historialTareasDataTable.DefaultView.RowFilter = filtro;
                }
                else
                {
                    MessageBox.Show("No se puede filtrar por nombre de usuario porque no se ha cargado esa columna (modo no administrador).");
                }
            }
            dgvHistorial.DataSource = historialTareasDataTable.DefaultView;
        }

        public void FiltrarPorTipoTarea(string tipoTarea, DataGridView dgvHistorial)
        {
            if (historialTareasDataTable == null) return;
            string filtro = $"TipoTarea LIKE '%{tipoTarea.Replace("'", "''")}%'";
            if (historialTareasDataTable.Columns.Contains("TipoTarea"))
            {
                historialTareasDataTable.DefaultView.RowFilter = filtro;
            }
            else
            {
                MessageBox.Show("No se puede filtrar por TipoTarea porque no se ha cargado esa columna (modo no administrador).");
            }

            dgvHistorial.DataSource = historialTareasDataTable.DefaultView;
        }
        public void FiltrarPorLugar(string lugar, DataGridView dgvHistorial)
        {
            if (historialTareasDataTable == null) return;
            string filtro = $"Lugar LIKE '%{lugar.Replace("'", "''")}%'";
            if (historialTareasDataTable.Columns.Contains("Lugar"))
            {
                historialTareasDataTable.DefaultView.RowFilter = filtro;
            }
            else
            {
                MessageBox.Show("No se puede filtrar por Lugar porque no se ha cargado esa columna (modo no administrador).");
            }

            dgvHistorial.DataSource = historialTareasDataTable.DefaultView;
        }
        public void FiltrarPorRangoFechas(DateTime fechaDesde, DateTime fechaHasta, DataGridView dgvHistorial)
        {
            if (historialTareasDataTable == null) return;

            if (!historialTareasDataTable.Columns.Contains("FechaTarea"))
            {
                MessageBox.Show("La columna FechaTarea no existe en los datos cargados.");
                return;
            }

            string fechaInicio = $"#{fechaDesde.Month}/{fechaDesde.Day}/{fechaDesde.Year}#";
            string fechaFin = $"#{fechaHasta.Month}/{fechaHasta.Day}/{fechaHasta.Year}#";

            string filtro = $"FechaTarea >= {fechaInicio} AND FechaTarea <= {fechaFin}";
            historialTareasDataTable.DefaultView.RowFilter = filtro;
            dgvHistorial.DataSource = historialTareasDataTable.DefaultView;
        }

    }
}
