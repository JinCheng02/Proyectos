using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_Gasto.Modelo
{
    public class concepto
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EsVisible { get; set; }
        public DateTime FechaCreada { get; set; }
        public DateTime FechaModificada { get; set; }

    }
}
