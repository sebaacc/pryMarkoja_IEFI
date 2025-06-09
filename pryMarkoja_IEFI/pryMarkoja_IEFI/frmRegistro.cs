using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryMarkoja_IEFI.Clases;

namespace pryMarkoja_IEFI
{
    public partial class frmRegistro : Form
    {
        clsFuncionesUtiles funciones = new clsFuncionesUtiles();

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void pControles_Paint(object sender, PaintEventArgs e)
        {

        }
        private string ObtenerSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string puestoTrabajo = txtPuesto.Text.Trim(); // Usamos el nombre correcto
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;

            int edad = CalcularEdad(fechaNacimiento);

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña) ||
                string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(puestoTrabajo))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (edad < 18)
            {
                MessageBox.Show("El usuario debe ser mayor de 18 años.", "Edad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string hash = ObtenerSHA256(contraseña);

            try
            {
                using (SqlConnection conexion = new SqlConnection(clsConexionBD.CadenaConexion))
                {
                    conexion.Open();
                    string query = @"INSERT INTO Usuario 
                            (NombreUsuario, ContraseñaHash, Nombre, Apellido, PuestoTrabajo, FechaNacimiento, Activo) 
                             VALUES (@usuario, @hash, @nombre, @apellido, @puestoTrabajo, @fechaNacimiento, @activo)";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@hash", hash);
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@apellido", apellido);
                        comando.Parameters.AddWithValue("@puestoTrabajo", puestoTrabajo);
                        comando.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                        comando.Parameters.AddWithValue("@activo", true); // o 1, para declarar activo el usuario.

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    MessageBox.Show("El nombre de usuario ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }
        private int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > hoy.AddYears(-edad)) edad--;
            return edad;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin v = new frmLogin();
            v.ShowDialog();
        }

        private void chkContraVisible_CheckedChanged(object sender, EventArgs e)
        {
            funciones.mostrarContraseña(chkContraVisible, txtContraseña);
        }
    }
}
