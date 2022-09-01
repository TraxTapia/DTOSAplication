using System;
using System.Collections.Generic;
using System.Text;

namespace Aplics.Nominix.DTOS.EmpleadosNomina
{
   public class ConsultaNominaResponseDTO
    {
        public int Empleado { get; set; }
        public string Nombre { get; set; }
        public decimal Neto{ get; set; }
    }
}
