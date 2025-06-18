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
    public class clsLugaresService
    {
        string CadenaConexion = clsConexionBD.CadenaConexion;
        private int usuarioId = clsUsuarioLogueado.Id;

        public void AgregarLugar(string lugar)
        {
            if (lugarNoExistente(lugar))
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                    {
                        conexion.Open();
                        String query = @"INSERT INTO Lugar (Nombre) VALUES (@nombre)";
                        using (SqlCommand comando = new SqlCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@nombre", lugar);
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Nuevo lugar agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("El lugar ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public bool lugarNoExistente(string nombre)
        {
            using (SqlConnection conexion = new SqlConnection(clsConexionBD.CadenaConexion))
            {
                conexion.Open();
                string query = @"SELECT COUNT(*) FROM Lugar WHERE Nombre = @nombre";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    int count = (int)comando.ExecuteScalar();

                    return count == 0;
                }
            }
        }
        public void EliminarLugar(string lugar)
        {
            if (!lugarNoExistente(lugar))
            {
                try
                {
                    using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                    {
                        conexion.Open();
                        string query = @"DELETE FROM Lugar WHERE Nombre = @nombre";
                        using (SqlCommand comando = new SqlCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@nombre", lugar);
                            int rowsAffected = comando.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Lugar eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el lugar para eliminar o no se realizaron cambios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al intentar eliminar el lugar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El lugar no existe en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
