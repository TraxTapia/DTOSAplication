using System;
using System.Collections.Generic;
using System.Text;

namespace Aplics.Nominix.DTOS
{
    public class dto_Plazas
    {
        //DATOS GENERALES
        public string DescripcionPlaza { get; set; }
        public string CodigoPlazaSeleccionada { get; set; }

        //DATOS DE PLAZA NUEVA Y TAMBIEN DATOS PARA CUANDO SE BORRA O SE EDITA
        public string Codigo { get; set; }
        public string PlazaSuperior { get; set; }
        public string Compañia { get; set; }
        public string Localidad { get; set; }
        public string Direccion { get; set; }
        public string Departamento { get; set; }
        public string Puesto { get; set; }
        public string TipoPlaza { get; set; }

        //CONFIGURACION DE LA PLAZA Y TAMBIEN PARA CUANDO SE BORRA O SE MODIFICA
        public int Autorizadas { get; set; }
        public int Ocupadas { get; set; }
        public int EventualesAutorizadas { get; set; }
        public int EventualesOcupadas { get; set; }
        public string Empleado { get; set; } //solo si es plaza individual
        public string Externo { get; set; }

        //DATOS DE LA PLAZA SUPERIOR
        public string CodigoSup { get; set; }
        public string CompañiaSup { get; set; }
        public string LocalidadSup { get; set; }
        public string DireccionSup { get; set; }
        public string DepartamentoSup { get; set; }
        public string PuestoSup { get; set; }
        public string ExternoSup { get; set; }

        //DATOS EMPLEADOS
        public List<dto_PlazasEmpleados> Empleados { get; set; }


    }
}
