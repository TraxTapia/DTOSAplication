using Aplics.Nominix.DTOS.EmpleadosNomina;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplics.Nominix.DTOS.Finiquito
{
    public class FiniquitoRequestDTO
    {

        public string Empleado { get; set; }
        public DateTime FechaFiniquito { get; set; }
        public string Compania { get; set; }
        public string TipoNomina { get; set; }
        public string Simulacion { get; set; }
        public string Localidadd { get; set; }
        public string PorcentajeSimulacion { get; set; }
        public string Estatus { get; set; }
        public string TipoContrato { get; set; }
        public decimal SueInteIndem { get; set; }
        public decimal ImporteReservado { get; set; }
        public decimal NetoLlegar { get; set; }
        public DateTime FechaAntiguedad { get; set; }
        public decimal SueldoM { get; set; }
        public decimal SueldoD { get; set; }
    }
}
