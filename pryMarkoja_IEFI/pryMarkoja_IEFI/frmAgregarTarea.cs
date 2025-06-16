using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryMarkoja_IEFI.Clases;

namespace pryMarkoja_IEFI
{
    public partial class frmAgregarTarea : Form
    {
        public frmAgregarTarea()
        {
            InitializeComponent();
        }

        private void btnAgregarTipoTarea_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreTareaNuevo.Text;
            if (nombre != "")
            {
                if (nombreNoExistente(nombre))
                {
                    try
                    {
                        using (SqlConnection conexion = new SqlConnection(clsConexionBD.CadenaConexion))
                        {
                            conexion.Open();
                            String query = @"INSERT INTO TipoTarea (Nombre) VALUES (@nombre)";
                            using (SqlCommand comando = new SqlCommand(query, conexion))
                            {
                                comando.Parameters.AddWithValue("@nombre", txtNombreTareaNuevo.Text);
                                comando.ExecuteNonQuery();
                                MessageBox.Show("Nueva tarea agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error: " + ex.Message);
                    }
                } else
                {
                    MessageBox.Show("El nombre ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor complete el campo nombre correctamente.");
            }
        }
        private bool nombreNoExistente(string nombre)
        {
            using (SqlConnection conexion = new SqlConnection(clsConexionBD.CadenaConexion))
            {
                conexion.Open();
                string query = @"SELECT COUNT(*) FROM TipoTarea WHERE Nombre = @nombre";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    int count = (int)comando.ExecuteScalar();

                    return count == 0;
                }
            }
        }
    }
}
