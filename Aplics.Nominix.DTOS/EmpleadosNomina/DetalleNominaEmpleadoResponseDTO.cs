using System;
using System.Collections.Generic;
using System.Text;

namespace Aplics.Nominix.DTOS.EmpleadosNomina
{
   public class DetalleNominaEmpleadoResponseDTO
    {
        public string Concepto { get; set; }
        public string Descripcion { get; set; }
        public decimal Unidades { get; set; }
        public decimal Percepciones { get; set; }
        public decimal Deducciones { get; set; }
        public decimal TotalPercepciones { get; set; }
        public decimal TotalDeducciones { get; set; }
        public decimal Neto { get; set; }
    }
}
