using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace HRManegment_Application.Enameration
{
    public enum ApiResultStatusCode
    {
        Success = HttpStatusCode.OK,
        ServerError=HttpStatusCode.InternalServerError,
        BadRequest = HttpStatusCode.BadRequest,
        NotFound = HttpStatusCode.NotFound,
    }
}
