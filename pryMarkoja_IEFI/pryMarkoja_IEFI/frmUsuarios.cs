﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using pryMarkoja_IEFI.Clases;


namespace pryMarkoja_IEFI
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAdminPanel_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
        private void CargarUsuarios(string filtro = "")
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarUsuarios(txtBuscar.Text.Trim());
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);
                DialogResult resultado = MessageBox.Show("¿Seguro que deseas desactivar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    DesactivarUsuario(idUsuario);
                    CargarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario primero.");
            }
        }
        private void DesactivarUsuario(int id)
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
        private void ActivarUsuario(int id)
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
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TiempoSistema_Tick(object sender, EventArgs e)
        {
            lblFechaHoraSistema.Text = DateTime.Now.ToString();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);
                ActivarUsuario(idUsuario);
                MessageBox.Show("Usuario activado.");
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Selecciona un usuario primero.");
            }
        }
    }
}
