﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aplics.Nominix.DTOS.Services
{
    public class ServiceResponse<T>
    {

        public String Code { get; set; }
        public String Message { get; set; }
        public List<Exception> Errors { get; set; }
        public List<BussinesMessage> BussinesMessages { get; set; }
        public T ResponseData { get; set; }
        public ServiceResponse()
        {
            this.BussinesMessages = new List<BussinesMessage>();
            this.SetStatusCode(StatusCodesEnum.OK);
        }
        
        public void AddException(Exception ex)
        {
            if (this.Errors == null)
                this.Errors = new List<Exception>();
            this.Errors.Add(new Exception(ex.Message));
        }

        public void AddBussinesMessage(BussinesMessage message)
        {
            this.BussinesMessages.Add(message);
        }


        public bool IsOK()
        {
            return this.Code == ((int)StatusCodesEnum.OK).ToString();
        }
        public void SetStatusCode(StatusCodesEnum StatusCodesEnum)
        {
            this.Code = ((int)StatusCodesEnum).ToString();
            this.Message = StatusCodesEnum.ToString();
            if (StatusCodesEnum != StatusCodesEnum.OK)
                this.Errors = new List<Exception>();
        }
        public enum StatusCodesEnum
        {
            OK = 200,
            CREATED = 201,
            ACCEPTED = 202,
            NON_AUTHORITATIVE_INFORMATION = 203,
            NO_CONTENT = 204,
            RESET_CONTENT = 205,
            PARTIAL_CONTENT = 206,
            BAD_REQUEST = 400,
            UNAUTHORIZED = 401,
            PAYMENT_REQUIRED = 402,
            FORBIDDEN = 403,
            NOT_FOUND = 404,
            METHOD_NOT_ALLOWED = 405,
            NOT_ACCEPTABLE = 406,
            INPUT_ERROR = 410,
            PROXY_AUTHENTICATION_REQUIRED = 407,
            REQUEST_TIMEOUT = 408,
            CONFLICT = 409,
            GONE = 410,
            LENGTH_REQUIRED = 411,
            PRECONDITION_FAILED = 412,
            INTERNAL_SERVER_ERROR = 500,
            NOT_IMPLEMENTED = 501,
            BAD_GATEWAY = 502,
            SERVICE_UNAVAILABLE = 503,
            GATEWAY_TIMEOUT = 504
        }
    }
}
