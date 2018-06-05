using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_Validacion
{
    class Paciente
    {
        public string NombrePaciente { get; set; }
        public long costo { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public Rango rango { get; set; }
    }
}
