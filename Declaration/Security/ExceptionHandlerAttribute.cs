using Declaration.BusinessLogic.Helpers;
using Declaration.BusinessLogic.Service.Interface;
using Declaration.EntityFramework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Declaration.Security
{
    public class ExceptionHandlerAttribute : HandleErrorAttribute
    {
        private readonly IExceptionService exceptionService;

        public ExceptionHandlerAttribute()
        {
            exceptionService = DependencyResolver.Current.GetService<IExceptionService>();
        }

        public override void OnException(ExceptionContext exceptionContext)
        {
            var controllerName = (string)exceptionContext.RouteData.Values["controller"];
            var actionName = (string)exceptionContext.RouteData.Values["action"];
            var message = exceptionContext.Exception.Message;

            if (exceptionContext.ExceptionHandled || !exceptionContext.HttpContext.IsCustomErrorEnabled)
                return;

            if (new HttpException(null, exceptionContext.Exception).GetHttpCode() != 500)
                return;

            if (!ExceptionType.IsInstanceOfType(exceptionContext.Exception))
                return;

            // if the request is AJAX return JSON else view
            if (exceptionContext.HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                exceptionContext.Result = new JsonResult
                {
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                    Data = new
                    {
                        error = true,
                        message = message
                    }
                };
            }
            else
            {
                var model = new HandleErrorInfo(exceptionContext.Exception, controllerName, actionName);
                exceptionContext.Result = new ViewResult
                {
                    ViewName = View,
                    MasterName = Master,
                    ViewData = new ViewDataDictionary<HandleErrorInfo>(model),
                    TempData = exceptionContext.Controller.TempData
                };
            }

            var logger = new ExceptionLog
            {
                //UserId = ,
                ExceptionMessage = exceptionContext.Exception.Message,
                ExceptionStackTrace = exceptionContext.Exception.StackTrace,
                ControllerName = controllerName,
                ActionName = actionName,
                LogTime = DateTime.UtcNow.ToBatamTime()
            };

            exceptionService.AddLog(logger);

            exceptionContext.ExceptionHandled = true;
            exceptionContext.HttpContext.Response.Clear();
            exceptionContext.HttpContext.Response.StatusCode = 500;
            exceptionContext.HttpContext.Response.TrySkipIisCustomErrors = true;
        }
    }
}