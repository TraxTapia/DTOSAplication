using Aplics.Nominix.DTOS.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplics.Nominix.DTOS.EmpleadosNomina
{
    public class FiltroNominaRequestDTO
    {
        public string Compania { get; set; }
        public string TipoNomina { get; set; }
        public string Ano { get; set; }
        public string NumeroNomina { get; set; }
        public string Estatus { get; set; }
        public DateTime FInicio { get; set; }
        public DateTime FFin { get; set; }
        public string Nombre { get; set; }  
        public string EstatusEmpleado { get; set; }
        public EnumViewNomina TipoBusqueda { get; set; }
    }
}
