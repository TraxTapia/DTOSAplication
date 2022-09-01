using System;
using System.Collections.Generic;
using System.Text;

namespace Aplics.Nominix.DTOS.Finiquito
{
    public class ConsultaFiniquitoResponseDTO
    {
        public string DocEntry { get; set; }
        public string Empleado { get; set; }
        public string Nombre { get; set; }
        public string FechaFiniquito { get; set; }
        public int NoSim { get; set; }
        public string TipoNomina { get; set; }
        public string DesTipoNomina { get; set; }
        public decimal NetoaPagar { get; set; }
        public string EstatusEmpleado { get; set; }
        public int Cia { get; set; }
        public string DescripcionCia { get; set; }
        public int Localidad { get; set; }
        public string DescLocalidad { get; set; }
        public string EstatusFiniquito { get; set; }
        public string Sim { get; set; }
    }
}
