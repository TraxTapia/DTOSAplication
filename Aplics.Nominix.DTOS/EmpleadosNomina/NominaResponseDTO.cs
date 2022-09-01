
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplics.Nominix.DTOS.EmpleadosNomina
{
    public class NominaResponseDTO
    {
        public int Id { get; set; }
        public string Empleado  { get; set; }
        public string Nombre  { get; set; }
        public string Concepto { get; set; }
        public string DescConcepto { get; set; }
        public  decimal Unidades { get; set; }
        public decimal Importe { get; set; }
    }
}
