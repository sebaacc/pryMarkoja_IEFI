using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMarkoja_IEFI.Clases
{
    public class clsAuditoriaService
    {
        public DataTable ObtenerTiemposPorNombre(string filtroNombre)
        {
            return EjecutarConsulta(filtroNombre, false, null, null);
        }

        public DataTable ObtenerTiemposPorFechas(DateTime desde, DateTime hasta)
        {
            return EjecutarConsulta("", true, desde, hasta);
        }

        public DataTable ObtenerTiemposPorNombreYFechas(string filtroNombre, DateTime desde, DateTime hasta)
        {
            return EjecutarConsulta(filtroNombre, true, desde, hasta);
        }

        private DataTable EjecutarConsulta(string filtroNombre, bool usarFechas, DateTime? desde, DateTime? hasta)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(clsConexionBD.CadenaConexion))
                {
                    conexion.Open();

                    string query = @"
                        SELECT 
                            u.NombreUsuario AS [Nombre de Usuario],
                            u.Nombre,
                            u.Apellido,
                            u.PuestoTrabajo AS [Puesto de Trabajo],
                            COUNT(s.Id) AS [Cantidad de Sesiones],
                            SUM(DATEDIFF(SECOND, s.FechaInicio, s.FechaFin)) AS [Total de Segundos Trabajados]
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
                            adaptador.Fill(tabla);

                            tabla.Columns.Add("Tiempo Trabajado Formateado", typeof(string));
                            foreach (DataRow fila in tabla.Rows)
                            {
                                int totalSegundos = Convert.ToInt32(fila["Total de Segundos Trabajados"]);
                                TimeSpan tiempo = TimeSpan.FromSeconds(totalSegundos);
                                fila["Tiempo Trabajado Formateado"] = $"{(int)tiempo.TotalHours:D2}:{tiempo.Minutes:D2}:{tiempo.Seconds:D2}";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos de auditoría: " + ex.Message, ex);
            }

            return tabla;
        }
        public DataTable ObtenerTodosLosTiempos()
        {
            return EjecutarConsulta("", false, null, null);
        }
    }
}
