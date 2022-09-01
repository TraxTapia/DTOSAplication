using System;
using System.Collections.Generic;
using System.Text;


namespace Aplics.Nominix.DTOS.Services
{
     public class CallService
    {
        private string UrlEndPoint;
        public CallService()
        {
            this.UrlEndPoint = string.Empty;
        }

        public bool ExisteEndPoint()
        {
            return !String.IsNullOrEmpty(this.UrlEndPoint);
        }
        public void SetEndPoint(string UrlEndPoint)
        {
            this.UrlEndPoint = UrlEndPoint;
        }
        public ServiceResponse<List<dto_Empleados>> GetEmpleados()
        {
            ServiceResponse<List<dto_Empleados>> _Response = new ServiceResponse<List<dto_Empleados>>()
            {
                ResponseData = new List<dto_Empleados>(),
                Code = "200",
                Message = "Ok"
            };
            List<dto_Empleados> _List = new List<dto_Empleados>();
            _List.Add(new dto_Empleados()
            {
                Code = "001",
                Name = "Empleado Goku"
            });
            _List.Add(new dto_Empleados()
            {
                Code = "0012",
                Name = "Empleado Vegueta"
            });
            _List.Add(new dto_Empleados()
            {
                Code = "003",
                Name = "Empleado Krilin"
            });
            _List.Add(new dto_Empleados()
            {
                Code = "004",
                Name = "Empleado Trunks"
            });
            _List.Add(new dto_Empleados()
            {
                Code = "005",
                Name = "Empleado Picolo"
            });
            _Response.ResponseData = _List;
            return _Response;
        }
        public ServiceResponse<List<dto_ComboGral>> GetSelectGral(string _RouteApi)
        {
                       //if (!this.HasToken())
            //{
            //    Response.Result.SetStatusCode(OperationResult.StatusCodesEnum.UNAUTHORIZED);
            //    Response.Result.AddException(new Exception("No se encontro el Token de Autorización."));
            //    return Response;
            //}
            //else 
            //if (!this.ExisteEndPoint())
            //{
            //    Response.SetStatusCode(ServiceResponse<List<dto_ComboGral>>.StatusCodesEnum.NOT_FOUND);
            //    Response.AddException(new Exception("Es necesario asignar una UrlEndPoint."));
            //    return Response;
            //}
            ServiceResponse<List<dto_ComboGral>> _Response =
                new ServiceResponse<List<dto_ComboGral>>()
                {
                    ResponseData = new List<dto_ComboGral>(),
                    Code = "200",
                    Message = "Ok"
                };
            List<dto_ComboGral> _List = new List<dto_ComboGral>();
            _List.Add(new dto_ComboGral()
            {
                Valor = "1",
                Descripcion = "datos dummy 1"
            });
            _List.Add(new dto_ComboGral()
            {
                Valor = "2",
                Descripcion = "datos dummy 2"
            });
            _List.Add(new dto_ComboGral()
            {
                Valor = "3",
                Descripcion = "datos dummy 3"
            });
            _List.Add(new dto_ComboGral()
            {
                Valor = "4",
                Descripcion = "datos dummy 4"
            });
            _List.Add(new dto_ComboGral()
            {
                Valor = "5",
                Descripcion = "datos dummy 5"
            });
            _Response.ResponseData = _List;
            //Message _MessageFactory = new Message();
            //Response = _MessageFactory.SendRequest<SelctGeneralResponseDTO>(this.UrlEndPoint, _RouteApi, string.Empty, HttpMethod.Post);
            return _Response;
        }

        public ServiceResponse<string> DeleteEmployerById(int id)
        {
            ServiceResponse<string> _Response = new ServiceResponse<string>()
            {
                Message = "ISOK",
                Errors = null,
                Code = "200"
            };
            return _Response;
        }  
        public ServiceResponse<string> AgregarEmpleado(string Name)
        {
            ServiceResponse<string> _Response = new ServiceResponse<string>()
            {
                Message = "ISOK",
                Errors = null,
                Code = "200"
            };
            if (string.IsNullOrEmpty(Name))
            {
                _Response.Message = string.Empty;
                _Response.Code = "500";
                _Response.Errors = new List<Exception>() { new Exception("Ocurrio un error") };
            }
            return _Response;
        }public ServiceResponse<string> FiltroBusquedaEmpleados(int IdCompania, int IdLocalidad)
        {
            ServiceResponse<string> _Response = new ServiceResponse<string>()
            {
                Message = "ISOK",
                Errors = null,
                Code = "200"
            };
            return _Response;
        }
    }
}
