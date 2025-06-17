using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMarkoja_IEFI.Clases
{
    public class clsUsuarioService
    {
        public void CargarUsuarios(DataGridView dgvUsuarios, string filtro)
        {
            using (SqlConnection conexion = new SqlConnection(clsConexionBD.CadenaConexion))
            {
                conexion.Open();
                string query = @"
                    SELECT Id, NombreUsuario, Nombre, Apellido, PuestoTrabajo, FechaNacimiento, Activo, EsAdministrador 
                    FROM Usuario
                    WHERE NombreUsuario LIKE @filtro";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@filtro", $"%{filtro}%");
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        dgvUsuarios.DataSource = tabla;
                    }
                }
            }
        }
        public void DesactivarUsuario(int id)
        {
            using (SqlConnection conexion = new SqlConnection(clsConexionBD.CadenaConexion))
            {
                conexion.Open();
                string query = "UPDATE Usuario SET Activo = 0 WHERE Id = @id";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }
            }
        }
        public void ActivarUsuario(int id)
        {
            using (SqlConnection conexion = new SqlConnection(clsConexionBD.CadenaConexion))
            {
                conexion.Open();
                string query = "UPDATE Usuario SET Activo = 1 WHERE Id = @id";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }
            }
        }
        public void HacerAdmin(int id)
        {
            using (SqlConnection conexion = new SqlConnection(clsConexionBD.CadenaConexion))
            {
                conexion.Open();
                string query = "UPDATE Usuario SET EsAdministrador = 1 WHERE Id = @id";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }
            }

        }
        public void QuitarAdmin(int id)
        {
            using (SqlConnection conexion = new SqlConnection(clsConexionBD.CadenaConexion))
            {
                conexion.Open();
                string query = "UPDATE Usuario SET EsAdministrador = 0 WHERE Id = @id";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }
            }

        }
    }
}
