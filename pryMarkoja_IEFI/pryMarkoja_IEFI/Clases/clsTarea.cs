using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMarkoja_IEFI.Clases
{
    public class clsTarea
    {
        public int TipoTarea { get; set; }
        public DateTime FechaTarea { get; set; }
        public string Comentario { get; set; }
        public string Detalle { get; set; }
        public int Lugar { get; set; }

        public clsTarea(){}
        public clsTarea(int tipo, int lugar, DateTime fecha, string comentario, string detalle)
        {
            TipoTarea = tipo;
            Lugar = lugar;
            FechaTarea = fecha;
            Comentario = comentario;
            Detalle = detalle;
        }
    }
}
