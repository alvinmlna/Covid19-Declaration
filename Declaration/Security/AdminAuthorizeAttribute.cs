using Declaration.BusinessLogic.Constant;
using Declaration.BusinessLogic.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Declaration.Security
{
    public class AdminAuthorizeAttribute : AuthorizeAttribute
    {
        private readonly IApplicationCoreService applicationCoreService;

        public AdminAuthorizeAttribute()
        {
            applicationCoreService = DependencyResolver.Current.GetService<IApplicationCoreService>();
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return applicationCoreService.IsAdmin();
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(
                              new RouteValueDictionary
                              {
                                   { "action", "Index" },
                                   { "controller", "Home" }
                              });
        }
    }
}