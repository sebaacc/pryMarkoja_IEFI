using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMarkoja_IEFI.Clases
{
    public class clsFuncionesUtiles
    {
        public void mostrarContraseña(CheckBox checkBox, TextBox contraseña)
        {
            if (checkBox.Checked)
            {
                contraseña.PasswordChar = '\0';
            }
            else
            {
                contraseña.PasswordChar = '*';
            }
        }

        public void dibujarFlechaDerecha(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen arrowPen = new Pen(Color.Black, 3)
            {
                EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
            };
            Pen blackPen = new Pen(Color.Black, 3);

            // Coordenadas:
            Point start = new Point(30, 0);
            Point middle = new Point(30, 10);
            Point end = new Point(50, 10);

            g.DrawLine(blackPen, start, middle);
            g.DrawLine(arrowPen, middle, end);
        }
    }
}
