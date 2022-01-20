using Declaration.BusinessLogic.Manager;
using Declaration.BusinessLogic.Service.Interface;
using Declaration.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Declaration.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDeclarationService declarationService;
        private readonly IDeclarationTypeService declarationTypeService;

        public HomeController(IDeclarationService declarationService, IDeclarationTypeService declarationTypeService)
        {
            this.declarationService = declarationService;
            this.declarationTypeService = declarationTypeService;
        }

        public ActionResult Index()
        {
            IEnumerable<DeclarationTypeViewModel> model = declarationTypeService.GetAll().Select(x => new DeclarationTypeViewModel
            {
                DeclarationTypeId = x.DeclarationTypeId,
                DeclarationType = x.Type
            });

            ViewBag.currLanguage = new LanguageManager().GetCurrentLanguage();
            return View(model);
        }

        public ActionResult SelectType(int id)
        {
            var lang = new LanguageManager().GetCurrentLanguage();
            IEnumerable<DeclarationDetailViewModel> model = declarationTypeService.FindById(id).DeclarationDetails
                .Where(x => x.ShowList)
                .Select(x => new DeclarationDetailViewModel
                {
                    DeclarationDetailId = x.DeclarationDetailId,
                    DeclarationDetail = (lang == "en") ? x.Detail : x.Detail_Id
                });

            return View("DeclarationDetail", model);
        }

        public ActionResult SelectDetail(int id)
        {
            //ada pilihan destinasinya
            if (id == 1 || id == 2)
            {
                return SelectDestination(id);
            } else
            {
                return RedirectToAction("SelectDetail", "Form", new { id = id });
            }
        }

        public ActionResult SelectDestination(int id)
        {
            var _db = declarationTypeService.FindDetailById(id);

            var allSame = declarationTypeService.GetAllDetail()
                .Where(x => x.Detail == _db.Detail)
                .Select(x => new DestinationViewModel
                {
                    Id = x.DeclarationDetailId,
                    Destination = x.Remark
                });

            return View("Destination", allSame);
        }

        public ActionResult ChangeLanguage(string lang)
        {
            new LanguageManager().SetLanguage(lang);
            return RedirectToAction("Index", "Home");
        }
    }
}