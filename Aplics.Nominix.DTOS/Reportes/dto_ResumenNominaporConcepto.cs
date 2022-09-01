using System;
using System.Collections.Generic;
using System.Text;

namespace Aplics.Nominix.DTOS.Reportes
{
    public class dto_ResumenNominaporConcepto
    {
        private String _formatDate = "dd/MM/yyyy";
        public dto_ResumenNominaporConcepto()
        {
            this.nomina = new calendarioNomina(_formatDate);
            this.conceptos = new List<dto_concepto>();
        }
        public dto_ResumenNominaporConcepto(String formatDate)
        {
            this.nomina = new calendarioNomina(_formatDate);
            this.conceptos = new List<dto_concepto>();
            _formatDate = formatDate;
        }
        public calendarioNomina nomina { get; set; }
        public List<dto_concepto> conceptos { get; set; }

        public class dto_concepto
        {
            private String _formatDate = "dd/MM/yyyy";
            public calendarioNomina nomina { get; set; }
            public String clave { get; set; }
            public String Descripcion { get; set; }
            public List<dto_EmpleadoNomina> empleados { get; set; }
            public decimal totalUnidades { get; set; }
            public decimal totalImporte { get; set; }

            public dto_concepto()
            {
                this.nomina = new calendarioNomina(_formatDate);
                this.empleados = new List<dto_EmpleadoNomina>();
            }
            public class dto_EmpleadoNomina{
                public String clave { get; set; }
                public String Nombre { get; set; }
                public Decimal unidades { get; set; }
                public Decimal  importe { get; set; }
            }
        }
    }
    public class calendarioNomina
    {
        private String _formatDate = "dd/MM/yyyy";
        public calendarioNomina(String formatDate)
        {
            _formatDate = formatDate;
        }

        public calendarioNomina()
        {

        }
        public int anio { get; set; }
        public int numero { get; set; }
        public DateTime fechaInicial { get; set; }
        public DateTime fechaFinal { get; set; }
        public String formatfechaInicial { get => this.fechaFinal.ToString(_formatDate);  }
        public String claveCompania { get; set; }
        public String compania { get; set; }
        public String claveTipoNomina { get; set; }
        public String tipoNomina { get; set; }
    }
}
