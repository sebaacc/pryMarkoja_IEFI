﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryMarkoja_IEFI.Objetos;

namespace pryMarkoja_IEFI.Clases
{
    public class clsRegistroService
    {
        string CadenaConexion = clsConexionBD.CadenaConexion;
        private DataTable historialTareasDataTable;
        private int usuarioId = clsUsuarioLogueado.Id;

        public void Registrar(string usuario, string hash, string nombre, string  apellido, string puestoTrabajo, DateTime fechaNacimiento)
        {
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
      
    }
}
