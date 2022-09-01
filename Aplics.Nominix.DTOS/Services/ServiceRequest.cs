using System;
using System.Collections.Generic;
using System.Text;

namespace Aplics.Nominix.DTOS.Services
{
    public class ServiceRequest<T>
    {
        public int userCode { get; set; }
        public String username { get; set; }
        public String userMail { get; set; }
        public T request { get; set; }
    }
}
