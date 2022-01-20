

using Declaration.BusinessLogic.Enum;
using Declaration.BusinessLogic.Service.Interface;
using Declaration.EntityFramework.Entity;
using Declaration.Helper;
using Declaration.Security;
using Declaration.ViewModel.Form;
using Declaration.ViewModel.Report;
using PagedList;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Declaration.Controllers
{
    [AdminAuthorizeAttribute]
    public class ReportController : Controller
    {
        private IDeclarationService declarationService;
        private IEmployeeService employeeService;

        public ReportController(IDeclarationService declarationService, IEmployeeService employeeService)
        {
            this.declarationService = declarationService;
            this.employeeService = employeeService;
        }

        // GET: DeclarationForms
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "dateSubmit" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;


            var students = declarationService.GetAll()
                .Select(x => new ReportViewModel
                {
                    Id = x.DeclarationId,
                    BadgeId = x.BadgeId,
                    Name = x.Name,
                    Destination = x.Destination,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Status = ((FormStatusEnum)x.StatusId).ToString(),
                    Remark = x.Remark,
                    DateSubmit = x.DateSubmit,
                    DeclarationDetail = x.DeclarationDetail.Detail,
                    Attachment = x.Attachment,
                    Relationship = x.Relationships.Select(
                        z => new RelationShipTravelViewModel
                        {
                            Name = z.Name,
                            Relationship = z.RelationshipType
                        }).ToArray()
                });

            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.Name.Contains(searchString)
                                       || s.BadgeId.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "dateSubmit":
                    students = students.OrderBy(s => s.DateSubmit);
                    break;
                default:
                    students = students.OrderByDescending(s => s.DateSubmit);
                    break;
            }

            int pageSize = 8;
            int pageNumber = (page ?? 1);
            return View(students.ToPagedList(pageNumber, pageSize));
        }


        // GET: DeclarationForms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            DeclarationForm declarationForm = declarationService.FindById(id ?? 0);
            if (declarationForm == null)
            {
                return HttpNotFound();
            }
            return View(declarationForm);
        }

        // POST: DeclarationForms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DeclarationId,BadgeId,Name,Destination,StartDate,EndDate,Remark,Submitter,DateSubmit")] DeclarationForm declarationForm)
        {
            if (ModelState.IsValid)
            {
                declarationService.Edit(declarationForm);
                return RedirectToAction("Index");
            }
            return View(declarationForm);
        }

        // GET: DeclarationForms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeclarationForm declarationForm = declarationService.FindById(id ?? 0);
            if (declarationForm == null)
            {
                return HttpNotFound();
            }
            return View(declarationForm);
        }

        // POST: DeclarationForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            declarationService.Remove(id);
            return RedirectToAction("Index");
        }


        public ActionResult ViewAttachement(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            } else
            {
                DeclarationForm declarationForm = declarationService.FindById(id ?? 0);
                if (declarationForm == null)
                {
                    return HttpNotFound();
                }

                if (String.IsNullOrEmpty(declarationForm.Attachment) == false)
                {
                    byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath(declarationForm.Attachment));
                    string fileName = Path.GetFileName(declarationForm.Attachment);
                    return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
                } else
                {
                    return HttpNotFound();
                }

            }
        }

        public void Export()
        {
            var toexport = declarationService.GetAll()
                .Select(x => new ReportExportViewModel
                {
                    DeclarationType = x.DeclarationDetail.DeclarationType.Type,
                    BadgeId = x.BadgeId,
                    Name = x.Name,
                    Supervisor = employeeService.FindByBadgeId(x.BadgeId)?.SuperiorName,
                    Destination = x.Destination,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    Status = ((FormStatusEnum)x.StatusId).ToString(),
                    TravelReason = x.TravelReason,
                    Remark = x.Remark,
                    DateSubmit = x.DateSubmit,
                    DeclarationDetail = x.DeclarationDetail.Detail,
                    Relationship = x.Relationships.Select(
                        z => new RelationShipTravelViewModel
                        {
                            Name = z.Name,
                            Relationship = z.RelationshipType
                        }).ToArray()
                }).ToList();
            ExportHelper.ExportToExcel(toexport, "Report", new int[] { 12 });
        }
    }
}
