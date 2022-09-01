using System;
using System.Collections.Generic;
using System.Text;

namespace Aplics.Nominix.DTOS
{
    public class dto_DiasFestivos
    {
        public int Clave { get; set; }
        public DateTime? U_FFI { get; set; }

        public DateTime? U_FFF { get; set; }

        public short? U_DIA { get; set; }

        public short? U_MES { get; set; }

        public short? U_AF { get; set; }

        public bool? U_MEDDIA { get; set; }
    }
}
