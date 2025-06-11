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

namespace pryMarkoja_IEFI
{
    public partial class frmTarea : Form
    {
        clsFuncionesUtiles funciones = new clsFuncionesUtiles();
        public frmTarea()
        {
            InitializeComponent();
        }

        private void pCanvas_Paint(object sender, PaintEventArgs e)
        {
            funciones.dibujarFlechaDerecha(sender, e);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pCanvas2_Paint(object sender, PaintEventArgs e)
        {
            funciones.dibujarFlechaDerecha(sender, e);
        }

        private void pCanvas3_Paint(object sender, PaintEventArgs e)
        {
            funciones.dibujarFlechaDerecha(sender, e);
        }

        private void pCanvas4_Paint(object sender, PaintEventArgs e)
        {
            funciones.dibujarFlechaDerecha(sender, e);
        }

        private void pCanvas5_Paint(object sender, PaintEventArgs e)
        {
            funciones.dibujarFlechaDerecha(sender, e);
        }
    }
}
