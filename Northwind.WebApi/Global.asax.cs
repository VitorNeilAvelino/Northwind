using Northwind.WebApi.App_Start;
using System.Web;
using System.Web.Http;

namespace Northwind.WebApi
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.Configure();
        }
    }
}