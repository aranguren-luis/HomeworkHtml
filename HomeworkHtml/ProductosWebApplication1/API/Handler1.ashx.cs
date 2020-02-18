using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductosWebApplication1.models;//conectar con la carpeta models ADO dentro de nuestro proyecto
using Newtonsoft.Json;//traer libreria de Json

namespace ProductosWebApplication1.API
{
    /// <summary>
    /// Descripción breve de Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //Params id - Identificador del cliente
            //            Si el identificador es igual ALL devolvemos todos loc clientes

            //1
            string desc = context.Request.Params["desc"];
            //if (id != null) id = id.ToLower();

            //2
            var db = new Model1();//debe llevar el mismo nombre que el model ADO que ha sido agregado en carpeta model
            db.Configuration.LazyLoadingEnabled = false;    //Bloquea la carga de las propiedades virtuales, evita bucles, obligado

            //3
            var productos = db.Products.Where(r => r.ProductName.Contains(desc)).ToList();//Trae la tabla de 
            //los productos consultados, donde el nombre del producto contenga la variable. Y la convierte en lista.

            //4
            string productoJSON = JsonConvert.SerializeObject(productos); // serializar la variable productos
            context.Response.ContentType = "text/plain";

            //5
            context.Response.Write(productoJSON);

            //if (id == "all")
            //{
            //    List<Product> productos = db.Products
            //        .ToList();

            //    string productoJSON = JsonConvert.SerializeObject(productos);

            //    context.Response.ContentType = "text/plain";
            //    context.Response.Write(productoJSON);
            //}
            //else
            //{
            //    List<Product> producto = db.Products
            //        .Where(r => r.ProductID.Contains("desc"))
            //        .ToList();

            //    string productosJSON = JsonConvert.SerializeObject(producto);

            //    context.Response.ContentType = "text/plain";
            //    context.Response.Write(productosJSON);
            //}
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