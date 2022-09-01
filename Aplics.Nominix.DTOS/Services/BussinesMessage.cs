using System;
using System.Collections.Generic;
using System.Text;

namespace Aplics.Nominix.DTOS.Services
{
    public class BussinesMessage
    {

        public int Code { get; set; }
        public String  Message { get; set; }
        public TypeMessageEnum type { get; set; }

        public  void setMessage(int code, String message, TypeMessageEnum type)
        {
            this.Code = Code;
            this.Message = message;
            this.type = type;
        }
        public enum TypeMessageEnum
        {
            ERROR = 1,
            WARNING = 2
        }
    }
}
