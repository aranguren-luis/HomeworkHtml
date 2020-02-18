using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductosWebApplication1.API
{
    /// <summary>
    /// Descripción breve de Handler2
    /// </summary>
    public class Handler2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string texto   = context.Request.Params["texto"];//1
            string comando = context.Request.Params["comando"];//1
            string fecha   = context.Request.Params["fecha"];//1
            string vocal   = context.Request.Params["vocal"];//1
            string resultado = "";//1
            //Como vamos a solicitar muchos comandos es mejor crear un switch que un if
            switch (comando)
            {
                case "cuenta":
                    resultado = texto.Length.ToString();//esto lo convertimos en string
                    break;

                case "fecha":
                    resultado = DateTime.Now.ToString();
                    break;

                case "vocales":
                    var array = texto.ToLower().ToArray<char>();

                    break;

                default:
                    resultado = "Comando no valido";
                    break;
            }
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