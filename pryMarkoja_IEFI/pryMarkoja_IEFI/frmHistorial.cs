using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryMarkoja_IEFI.Clases;
using pryMarkoja_IEFI.Objetos;

namespace pryMarkoja_IEFI
{
    public partial class frmHistorial : Form
    {
        clsTareasService BD = new clsTareasService();
        public frmHistorial()
        {
            InitializeComponent();
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            BD.CargarHistorialTareasUsuario(dgvHistorial);
            BD.CargarTiposTarea(cmbTipoTarea);
            BD.CargarLugares(cmbLugar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
