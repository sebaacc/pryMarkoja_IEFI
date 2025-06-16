using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMarkoja_IEFI.Objetos
{
    public static class clsUsuarioLogueado
    {
        public static int Id { get; set; }
        public static bool EsAdministrador { get; set; }
        public static void CerrarSesion()
        {
            Id = 0;
            EsAdministrador = false;
        }
    }
}
