using Aplics.Nominix.DTOS.EmpleadosNomina;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplics.Nominix.DTOS.Finiquito
{
   public class FiltrosRequestDTO
    {
        public string Compania { get; set; }
        public string Localidad { get; set; }
        public string NoEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Estatus { get; set; }
        public DateTime FechaFiniquito { get; set; }
    }
}
