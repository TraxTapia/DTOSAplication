using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplics.Nominix.DTOS.EmpleadosNomina
{
public  class ExcepcionesExcelRequestDTO
    {
        public string Compania { get; set; }
        public string TipoNomina { get; set; }
        public string Ano { get; set; }
        public string NumeroNomina{ get; set; }
        public List<IFormFile> File { get; set; }
        public string FileBase64 { get; set; }
    }
}
