using System;
using System.Collections.Generic;
using System.Text;

namespace Aplics.Nominix.DTOS.EmpleadosNomina
{
   public class DataTableNominaEmpleadosDTO
    {
        public int Id { get; set; }
        public string CodEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Concepto { get; set; }
        public string DescConcepto { get; set; }
        public string Unidades { get; set; }
        public decimal Importe { get; set; }
        public decimal Calcular { get; set; }
    }
}
