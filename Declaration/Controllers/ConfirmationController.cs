using Declaration.BusinessLogic.Service.Interface;
using System.Web.Mvc;

namespace Declaration.Controllers
{
    public class ConfirmationController : Controller
    {
        private readonly IDeclarationService declarationService;

        public ConfirmationController(IDeclarationService declarationService)
        {
            this.declarationService = declarationService;
        }


        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Approve(int id)
        {
            var isAlreadyAcknowledge = declarationService.isAlreadyAcknowledge(id);
            if (isAlreadyAcknowledge)
            {
                return View("Failed");
            }

            //Approve
            declarationService.Approve(id);
            return View("Approved");
        }

        [HttpGet]
        public ActionResult Reject(int id)
        {
            var isAlreadyAcknowledge = declarationService.isAlreadyAcknowledge(id);
            if (isAlreadyAcknowledge)
            {
                return View("Failed");
            }

            //Approve
            declarationService.Reject(id);
            return View("Rejected");
        }
    }
}