using Declaration.BusinessLogic.Helpers;
using Declaration.BusinessLogic.Service.Interface;
using Declaration.DepedencyInjection;
using Declaration.EntityFramework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity.AspNet.Mvc;

namespace Declaration
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {            
            // set dependency resolver to unity dependecy resolver
            var container = UnityBootstrapper.BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error()
        {
            Exception exception = Server.GetLastError();
            Response.Clear();

            IExceptionService exceptionService = DependencyResolver.Current.GetService<IExceptionService>();
            var logger = new ExceptionLog
            {
                //UserId = ,
                ExceptionMessage = exception.Message,
                ExceptionStackTrace = exception.StackTrace,
                LogTime = DateTime.UtcNow.ToBatamTime()
            };

            exceptionService.AddLog(logger);

            Server.ClearError();
            Response.Redirect(String.Format("~/Error/Error?message={0}", exception.Message));
        }


        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies["Language"];
            if (cookie != null && cookie.Value != null)
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cookie.Value);
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cookie.Value);
            } else
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }
        }
    }
}
