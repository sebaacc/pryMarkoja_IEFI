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
        clsTareaService BDTarea = new clsTareaService();
        clsLugaresService BDLugar = new clsLugaresService();
        string lugar;
        public frmAgregarLugar()
        {
            InitializeComponent();
            txtNombreLugarNuevo.MaxLength = 100;
            BDTarea.CargarLugares(cmbLugar);
        }

        private void btnAgregarLugar_Click(object sender, EventArgs e)
        {
            lugar = txtNombreLugarNuevo.Text;
            if (lugar != "")
            {
                BDLugar.AgregarLugar(lugar);
                BDTarea.CargarLugares(cmbLugar);
            }
            else
            {
                MessageBox.Show("Por favor complete el campo nombre correctamente.");
            }
        }

        private void btnEliminarLugar_Click(object sender, EventArgs e)
        {
            lugar = cmbLugar.Text;
            BDLugar.EliminarLugar(lugar);
        }
    }
}
