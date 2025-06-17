using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using pryMarkoja_IEFI.Clases;


namespace pryMarkoja_IEFI
{
    public partial class frmUsuarios : Form
    {
        clsUsuarioService BD = new clsUsuarioService(); 
        string filtro = "";
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
            
            BD.CargarUsuarios(dgvUsuarios, filtro);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BD.CargarUsuarios(dgvUsuarios, txtBuscar.Text.Trim());
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);
                DialogResult resultado = MessageBox.Show("¿Seguro que deseas desactivar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    BD.DesactivarUsuario(idUsuario);
                    BD.CargarUsuarios(dgvUsuarios, filtro);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario primero.");
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
                BD.ActivarUsuario(idUsuario);
                MessageBox.Show("Usuario activado.");
                BD.CargarUsuarios(dgvUsuarios, filtro);
            }
            else
            {
                MessageBox.Show("Selecciona un usuario primero.");
            }
        }

        private void btnHacerAdmin_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);
                BD.HacerAdmin(idUsuario);
                MessageBox.Show("Usuario convertido en administrador.");
                BD.CargarUsuarios(dgvUsuarios, filtro);
            }
            else
            {
                MessageBox.Show("Selecciona un usuario primero.");
            }
        }

        private void btnQuitarAdmin_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);
                BD.QuitarAdmin(idUsuario);
                MessageBox.Show("Se le quitaron los permisos de administrador al usuario.");
                BD.CargarUsuarios(dgvUsuarios, filtro);
            }
            else
            {
                MessageBox.Show("Selecciona un usuario primero.");
            }
        }
    }
}
