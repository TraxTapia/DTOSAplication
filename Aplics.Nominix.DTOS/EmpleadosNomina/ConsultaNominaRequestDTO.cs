using System;
using System.Collections.Generic;
using System.Text;

namespace Aplics.Nominix.DTOS.EmpleadosNomina
{
  public  class ConsultaNominaRequestDTO
    {
        public string Compania{ get; set; }
        public string TipoNomina { get; set; }
        public string Ano { get; set; }
        public string NoNomina { get; set; }
        public DateTime FecInicial { get; set; }
        public DateTime FecFinal { get; set; }
        public DateTime FecPago { get; set; }
        public string Estatus { get; set; }
    }
}
