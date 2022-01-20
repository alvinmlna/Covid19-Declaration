using Declaration.BusinessLogic.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Declaration.Controllers
{
    public class LayoutController : Controller
    {
        private readonly IApplicationCoreService applicationCoreService;

        public LayoutController(IApplicationCoreService applicationCoreService)
        {
            this.applicationCoreService = applicationCoreService;
        }

        // GET: Layout
        public ActionResult Navbar()
        {
            ViewBag.isAdmin = applicationCoreService.IsAdmin();
            return PartialView();
        }
    }
}