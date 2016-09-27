using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebMatrix.Data;
using WebMatrix.WebData;

namespace Financas
{
    public class MvcApplication : System.Web.HttpApplication
    {
       

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            WebSecurity.InitializeDatabaseConnection("FinancasContext","Usuarios", "ID","Nome", true);

           
        }
    }
}
