using Declaration.BusinessLogic.Class;
using Declaration.BusinessLogic.Helpers;
using Declaration.BusinessLogic.Manager;
using Declaration.BusinessLogic.Service.Interface;
using Declaration.EntityFramework.Entity;
using Declaration.ViewModel.Form;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace Declaration.Controllers
{
    public class FormController : Controller
    {
        private readonly IDeclarationTypeService declarationTypeService;
        private readonly IDeclarationService declarationService;

        public FormController(
            IDeclarationTypeService declarationTypeService,
            IDeclarationService declarationService)
        {
            this.declarationTypeService = declarationTypeService;
            this.declarationService = declarationService;
        }

        //public ActionResult Index()
        //{
        //    TravelDeclarationViewModel model = new TravelDeclarationViewModel
        //    {
        //        BadgeId = "30132514",
        //        Name = "Sample Name",
        //        AdditionalInformation = "Remark",
        //        TravelReason = "",
        //        Destination = "Sumatra",
        //        StartDate = DateTime.UtcNow,
        //        EndDate = DateTime.UtcNow,
        //        LabelModel = GetLabelById(1),
        //        DeclarationDetail = declarationTypeService.FindDetailById(2).Detail
        //    };

        //    model.TravelerName = new string[] { "Suhartono", "Anambas" };
        //    model.Relationship = new string[] { "Keluarga", "Adik" };

        //    model.RelationshipList = GetRelationShip(model.TravelerName, model.Relationship);

        //    return View("CompleteSubmit", model);
        //}

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult SelectDetail(int id, string maindestination = "")
        {
            var detail = GetDeclarationDetail(id);
            var formType = detail.DeclarationType.DeclarationTypeId;
            ViewBag.Header = detail.DeclarationType.DeclarationTitle;
            ViewBag.Detail = GetDeclarationDetail(detail);


            TravelDeclarationViewModel model = new TravelDeclarationViewModel();
            model.DeclarationDetailId = detail.DeclarationDetailId;
            model.DeclarationTypeId = formType;
            model.StartDate = DateTime.UtcNow;
            model.EndDate = DateTime.UtcNow;
            model.LabelModel = GetLabelById(formType);

            model.WithVaccineStatus = detail.WithVaccineStatus;
            model.Quarantine = GetQuarantine(detail);
            model.PCR = GetPCR(detail);

            //Configuration
            model.IsRelationshipRequired = detail.IsRelationshipRequired;
            model.MainDestination = maindestination;


            return View("TravelDeclaration", model);
        }

        [HttpPost]
        public ActionResult SubmitTravelDeclaration(TravelDeclarationViewModel model)
        {
            var detail = GetDeclarationDetail(model.DeclarationDetailId);

            if (ModelState.IsValid)
            {
                var emp = declarationService.GetEmployee(model.BadgeId);
                if (emp == null)
                {
                    model.Quarantine = GetQuarantine(detail);
                    model.PCR = GetPCR(detail);

                    //Configuration
                    model.IsRelationshipRequired = detail.IsRelationshipRequired;

                    model.LabelModel = GetLabelById(model.DeclarationTypeId);
                    ViewBag.Header = detail.DeclarationType.DeclarationTitle;
                    ViewBag.Detail = GetDeclarationDetail(detail);
                    ModelState.AddModelError("BadgeId", "Your badge id is not registered/Badge id anda belum terdaftar.");
                    return View("TravelDeclaration", model);
                }

                model.Name = emp.Name;
                string filename = "";

                if (model.Attachment != null)
                {
                    var _fileName = (string)Path.GetRandomFileName() + "-" + (string)Path.GetFileName(model.Attachment.FileName);


                    var nowDate = String.Format("{0:dd-MM-yyyy}", DateTime.Now);
                    var target = "~/Data/" + emp.Name  + "/" + nowDate + "/";

                    Directory.CreateDirectory(Server.MapPath(target));
                    model.Attachment.SaveAs(Server.MapPath(target + _fileName));

                    //save to list
                    filename = target + _fileName;
                }

                DeclarationForm form = new DeclarationForm
                {
                    DeclarationDetailId = model.DeclarationDetailId,
                    BadgeId = model.BadgeId,
                    Name = model.Name,
                    Destination = model.Destination,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    Remark = model.AdditionalInformation,
                    TravelReason = model.TravelReason, //hanya untuk travel
                    VaccinationStatus = model.VaccineStatus, //hanya untuk travel
                    MainDestination = model.MainDestination, //hanya untuk travel
                    Attachment = filename
                };

                model.RelationshipList = GetRelationShip(model.TravelerName, model.Relationship);

                //Add to server
                IEnumerable<Relationship> relationships = null;
                if (model.RelationshipList != null)
                {
                    relationships = model.RelationshipList.Select(x => new Relationship
                    {
                        Name = x.Name,
                        RelationshipType = x.Relationship
                    });
                }
                declarationService.Add(form, relationships);

                //Complete
                model.DeclarationDetail = GetDeclarationDetail(detail);
                model.LabelModel = GetLabelById(detail.DeclarationType.DeclarationTypeId);
                return View("CompleteSubmit", model);
            }


            model.Quarantine = GetQuarantine(detail);
            model.PCR = GetPCR(detail);

            //Configuration
            model.IsRelationshipRequired = detail.IsRelationshipRequired;

            model.LabelModel = GetLabelById(model.DeclarationTypeId);
            ViewBag.Header = detail.DeclarationType.DeclarationTitle;
            ViewBag.Detail = GetDeclarationDetail(detail);
            return View("TravelDeclaration", model);
        }

        private DeclarationDetail GetDeclarationDetail(int id)
        {
            return declarationTypeService.FindDetailById(id);
        }

        private List<RelationShipTravelViewModel> GetRelationShip(string[] name, string[] relationship)
        {
            if (name != null)
            {
                var Relationship = name.Where(x => String.IsNullOrEmpty(x) == false).Select(x => new RelationShipTravelViewModel
                {
                    Name = x
                }).ToArray();


                for (int i = 0; i < Relationship.Count(); i++)
                {
                    Relationship[i].Relationship = relationship[i];
                }


                if (Relationship != null)
                {
                    return Relationship.ToList();
                }
                else
                {
                    return null;
                }
            }

            return null;
        }

        private LabelModel GetLabelById(int id)
        {
            var currentType = (DeclarationTypeEnum)id;
            return DeclarationFormHelpers.GetLabel(currentType);
        }

        private string GetDeclarationDetail(DeclarationDetail detail)
        {
            var lang = new LanguageManager().GetCurrentLanguage();
            if (lang == "en")
            {
                return detail.Detail;
            } else
            {
                return detail.Detail_Id;
            }
        }

        [HttpPost]
        public JsonResult GetBadgeIdName(string badgeId)
        {
            var employee = declarationService.GetEmployee(badgeId);
            if (employee != null)
            {
                return Json(new { name = employee.Name, superior = employee.SuperiorName });
            }
            else
            {
                return Json(new { name = "Employee not found", superior = "Employee not found" });
            }
        }



        private string GetQuarantine(DeclarationDetail detail)
        {
           var currLanguage = new LanguageManager().GetCurrentLanguage();

            if (currLanguage == "en")
            {
                return detail.Quarantine;
            } else
            {
                return detail.Quarantine_Id;
            }
        }

        private string GetPCR(DeclarationDetail detail)
        {
            var currLanguage = new LanguageManager().GetCurrentLanguage();

            if (currLanguage == "en")
            {
                return detail.PCR;
            }
            else
            {
                return detail.PCR_Id;
            }
        }
    }
}