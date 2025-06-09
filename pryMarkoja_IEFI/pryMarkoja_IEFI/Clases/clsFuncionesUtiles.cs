using System;
using System.Collections.Generic;
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
    }
}
