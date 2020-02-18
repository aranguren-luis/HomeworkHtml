using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace CalcularTextoWebApp.API
{
    /// <summary>
    /// Descripción breve de Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string texto = context.Request.Params["texto"];
            context.Response.ContentType = "text/plain";
            string cadena = "";
            cadena = texto.Length.ToString();
            context.Response.Write(cadena);
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