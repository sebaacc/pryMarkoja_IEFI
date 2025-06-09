using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using pryMarkoja_IEFI.Clases;
using pryMarkoja_IEFI.Objetos;

namespace pryMarkoja_IEFI
{
    public partial class frmLogin : Form
    {
        private int intentos = 3;
        clsFuncionesUtiles funciones = new clsFuncionesUtiles();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pControles_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;

            var usuarioLogueado = ValidarCredenciales(usuario, contraseña);

            if (usuarioLogueado != null)
            {
                if (usuarioLogueado.EsAdministrador)
                {
                    frmPrincipalAdmin admin = new frmPrincipalAdmin();
                    admin.Show();
                }
                else
                {
                    frmPrincipalUsuario menu = new frmPrincipalUsuario(usuarioLogueado.Id);
                    menu.Show();
                }
                this.Hide();
            }
            else
            {
                intentos--;
                if (intentos > 0)
                {
                    MessageBox.Show($"Credenciales incorrectas. Te quedan {intentos} intento(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Demasiados intentos fallidos. La aplicación se cerrará.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private clsUsuarioLogueado ValidarCredenciales(string usuario, string contraseña)
        {
            string hash = ObtenerSHA256(contraseña);

            try
            {
                using (SqlConnection conexion = new SqlConnection(clsConexionBD.CadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT Id, EsAdministrador FROM Usuario WHERE NombreUsuario = @usuario AND ContraseñaHash = @hash AND Activo = 1";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@hash", hash);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new clsUsuarioLogueado
                                {
                                    Id = reader.GetInt32(0),
                                    EsAdministrador = reader.GetBoolean(1)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar el usuario: " + ex.Message);
            }

            return null; // No válido
        }
        private string ObtenerSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                    builder.Append(b.ToString("x2")); // convierte a hexadecimal

                return builder.ToString();
            }
        }

        private void lblLinkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.ShowDialog();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void chkContraVisible_CheckedChanged(object sender, EventArgs e)
        {
            funciones.mostrarContraseña(chkContraVisible, txtContraseña);
        }
    }
}
