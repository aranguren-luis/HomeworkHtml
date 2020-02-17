using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB5.API
{
    /// <summary>
    /// Descripción breve de suma
    /// </summary>
    public class suma : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            int numero1 = Convert.ToInt32(context.Request.Params["n1"]);
            int numero2 = Convert.ToInt32(context.Request.Params["n2"]);
            int resultado = numero1 + numero2;
            context.Response.ContentType = "text/plain";
            context.Response.Write(resultado);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}