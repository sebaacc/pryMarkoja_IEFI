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
        public frmAuditoria()
        {
            InitializeComponent();
            formateoInicial();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TiempoSistema_Tick(object sender, EventArgs e)
        {
            lblFechaHoraSistema.Text = DateTime.Now.ToString();
        }
        private void CargarTiemposDeUsuarios(string filtroNombre = "", bool usarFechas = false, DateTime? desde = null, DateTime? hasta = null)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(clsConexionBD.CadenaConexion))
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
                    WHERE u.NombreUsuario LIKE @filtroNombre
                    AND s.FechaFin IS NOT NULL";

                    if (usarFechas)
                    {
                        query += " AND s.FechaInicio >= @desde AND s.FechaInicio <= @hasta";
                    }

                    query += @"
                    GROUP BY u.NombreUsuario, u.Nombre, u.Apellido, u.PuestoTrabajo
                    ORDER BY u.NombreUsuario";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@filtroNombre", $"%{filtroNombre}%");

                        if (usarFechas)
                        {
                            comando.Parameters.AddWithValue("@desde", desde ?? DateTime.MinValue);
                            comando.Parameters.AddWithValue("@hasta", hasta ?? DateTime.MaxValue);
                        }

                        using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                        {
                            DataTable tabla = new DataTable();
                            adaptador.Fill(tabla);

                            tabla.Columns.Add("TiempoTrabajadoFormateado", typeof(string));
                            foreach (DataRow fila in tabla.Rows)
                            {
                                int totalSegundos = Convert.ToInt32(fila["TotalSegundosTrabajados"]);
                                TimeSpan tiempo = TimeSpan.FromSeconds(totalSegundos);
                                fila["TiempoTrabajadoFormateado"] = $"{(int)tiempo.TotalHours:D2}:{tiempo.Minutes:D2}:{tiempo.Seconds:D2}";
                            }

                            dgvAuditoria.DataSource = tabla;
                            if (dgvAuditoria.Columns.Contains("TotalSegundosTrabajados"))
                            {
                                dgvAuditoria.Columns["TotalSegundosTrabajados"].Visible = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error. " + ex);
            }
        }



        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                string filtro = txtBuscar.Text.Trim();
                CargarTiemposDeUsuarios(filtro, false);
            }
            else
            {
                MessageBox.Show("Por favor complete el campo del nombre de usuario.");
            }
        }

        private void btnFiltrarFecha_Click(object sender, EventArgs e)
        {

            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1); // incluye todo el día
            CargarTiemposDeUsuarios("", true, desde, hasta);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            formateoInicial();
        }

        private void formateoInicial()
        {
            dtpDesde.Value = DateTime.Today.AddDays(-7); // Últimos 7 días
            dtpHasta.Value = DateTime.Today;
            CargarTiemposDeUsuarios("", false, dtpDesde.Value, dtpHasta.Value);
        }
    }
}
