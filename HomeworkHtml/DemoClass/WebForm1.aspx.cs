using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoClass
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string Nombre = "";
        public string Apellido1 = "";
        public string Apellido2 = "";
        public string Email = "";
        public DateTime Nacimiento;
        public string Mensaje = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            ////Peticiones de tipo GET (QueryString)
            //Nombre = HttpContext.Current.Request.QueryString["nombre"];
            //Apellido1 = HttpContext.Current.Request.QueryString["apellido1"];

            ////Peticiones de tipo POST (Form)
            //Nombre = HttpContext.Current.Request.Form["nombre"];
            //Apellido1 = HttpContext.Current.Request.Form["apellido1"];

            //Peticiones de tipo POST y GET (param)
            

            try
            {
                Nombre     = HttpContext.Current.Request.Params["nombre"];
                Apellido1  = HttpContext.Current.Request.Params["apellido1"];
                Apellido2  = HttpContext.Current.Request.Params["apellido2"];
                Email      = HttpContext.Current.Request.Params["email"];
                Nacimiento = Convert.ToDateTime(HttpContext.Current.Request.Params["nacimiento"]);
                Mensaje    = "Ficha REgistrada Correctamente";
            }
            catch (Exception ex)
            {
                Mensaje = "Error: " + ex.Message;
              
            }
        }
    }
}