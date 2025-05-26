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

namespace pryMarkoja_IEFI
{
    public partial class frmAuditoria : Form
    {
        private const string cadenaConexion = "Server=localhost;Database=Auditoria;Trusted_Connection=True;";
        public frmAuditoria()
        {
            InitializeComponent();
            CargarTiemposDeUsuarios();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TiempoSistema_Tick(object sender, EventArgs e)
        {
            lblFechaHoraSistema.Text = DateTime.Now.ToString();
        }
        private void CargarTiemposDeUsuarios(string filtro = "")
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                string query = @"
            SELECT 
                u.NombreUsuario,
                u.Nombre,
                u.Apellido,
                u.PuestoTrabajo,
                COUNT(s.Id) AS CantidadSesiones,
                SUM(DATEDIFF(SECOND, s.FechaInicio, s.FechaFin)) AS TotalSegundosTrabajados
            FROM Usuario u
            INNER JOIN SesionTrabajo s ON u.Id = s.UsuarioId
            WHERE u.NombreUsuario LIKE @filtro
              AND s.FechaFin IS NOT NULL
            GROUP BY u.NombreUsuario, u.Nombre, u.Apellido, u.PuestoTrabajo
            ORDER BY u.NombreUsuario";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@filtro", $"%{filtro}%");

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        // Agregamos una columna para mostrar el tiempo formateado
                        tabla.Columns.Add("TiempoTrabajadoFormateado", typeof(string));
                        foreach (DataRow fila in tabla.Rows)
                        {
                            int totalSegundos = Convert.ToInt32(fila["TotalSegundosTrabajados"]);
                            TimeSpan tiempo = TimeSpan.FromSeconds(totalSegundos);
                            fila["TiempoTrabajadoFormateado"] = $"{(int)tiempo.TotalHours:D2}:{tiempo.Minutes:D2}:{tiempo.Seconds:D2}";
                        }

                        dgvAuditoria.DataSource = tabla;

                        // Opcionalmente ocultar la columna de segundos brutos
                        if (dgvAuditoria.Columns.Contains("TotalSegundosTrabajados"))
                        {
                            dgvAuditoria.Columns["TotalSegundosTrabajados"].Visible = false;
                        }
                    }
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarTiemposDeUsuarios(txtBuscar.Text.Trim());
        }
    }
}
