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
    public partial class frmAgregarLugar : Form
    {
        public frmAgregarLugar()
        {
            InitializeComponent();
            txtNombreLugarNuevo.MaxLength = 100;
        }

        private void btnAgregarLugar_Click(object sender, EventArgs e)
        {
            string lugar = txtNombreLugarNuevo.Text;
            if (lugar != "")
            {
                if (lugarNoExistente(lugar))
                {
                    try
                    {
                        using (SqlConnection conexion = new SqlConnection(clsConexionBD.CadenaConexion))
                        {
                            conexion.Open();
                            String query = @"INSERT INTO Lugar (Nombre) VALUES (@nombre)";
                            using (SqlCommand comando = new SqlCommand(query, conexion))
                            {
                                comando.Parameters.AddWithValue("@nombre", txtNombreLugarNuevo.Text);
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
            else
            {
                MessageBox.Show("Por favor complete el campo nombre correctamente.");
            }
        }
        private bool lugarNoExistente(string nombre)
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
    }
}
