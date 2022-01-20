using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Declaration.BusinessLogic.Service.Interface;
using Declaration.EntityFramework;
using Declaration.EntityFramework.Entity;
using Declaration.Helper;
using Declaration.Security;
using Declaration.ViewModel;
using PagedList;

namespace Declaration.Controllers
{
    [AdminAuthorizeAttribute]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }


        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name" : "";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;


            var students = employeeService.GetAll()
                .Select(x => new EmployeeViewModel
                {
                    BadgeId = x.BadgeId,
                    Name = x.Name,
                    Email = x.Email,
                    Department = x.Department,
                    SuperiorName = x.SuperiorName,
                    SuperiorMail = x.SuperiorMail,
                    ApproverName = x.ApproverName,
                    ApproverMail = x.ApproverMail,
                    SubmittedDate = x.SubmittedDate
                });

            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.Name.Contains(searchString)
                                       || s.BadgeId.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name":
                    students = students.OrderByDescending(s => s.Name);
                    break;
                default:
                    students = students.OrderBy(s => s.Name);
                    break;
            }

            int pageSize = 8;
            int pageNumber = (page ?? 1);
            return View(students.ToPagedList(pageNumber, pageSize));
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                Employee emp = new Employee()
                {
                    BadgeId = employee.BadgeId,
                    Name = employee.Name,
                    Email = employee.Email,
                    Department = employee.Department,
                    SuperiorName = employee.SuperiorName,
                    SuperiorMail = employee.SuperiorMail,
                    ApproverName = employee.ApproverName,
                    ApproverMail = employee.ApproverMail,
                };

                employeeService.Add(emp);
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }



            var emp = employeeService.FindByBadgeId(id);
            if (emp == null)
            {
                return HttpNotFound();
            }

            EmployeeViewModel employee = new EmployeeViewModel
            {
                BadgeId = emp.BadgeId,
                Name = emp.Name,
                Email = emp.Email,
                Department = emp.Department,
                SuperiorName = emp.SuperiorName,
                SuperiorMail = emp.SuperiorMail,
                ApproverName = emp.ApproverName,
                ApproverMail = emp.ApproverMail,
                SubmittedDate = emp.SubmittedDate
            };

            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                Employee emp = new Employee()
                {
                    BadgeId = employee.BadgeId,
                    Name = employee.Name,
                    Email = employee.Email,
                    Department = employee.Department,
                    SuperiorName = employee.SuperiorName,
                    SuperiorMail = employee.SuperiorMail,
                    ApproverName = employee.ApproverName,
                    ApproverMail = employee.ApproverMail,
                };

                employeeService.Edit(emp);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var emp = employeeService.FindByBadgeId(id);
            if (emp == null)
            {
                return HttpNotFound();
            }

            EmployeeViewModel employee = new EmployeeViewModel
            {
                BadgeId = emp.BadgeId,
                Name = emp.Name,
                Email = emp.Email,
                Department = emp.Department,
                SuperiorName = emp.SuperiorName,
                SuperiorMail = emp.SuperiorMail,
                ApproverName = emp.ApproverName,
                ApproverMail = emp.ApproverMail,
                SubmittedDate = emp.SubmittedDate
            };

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            employeeService.Remove(id);
            return RedirectToAction("Index");
        }


        public void Export()
        {
            var toExport = employeeService.GetAll()
                .Select(x => new EmployeeViewModel
                {
                    BadgeId = x.BadgeId,
                    Name = x.Name,
                    Email = x.Email,
                    Department = x.Department,
                    SuperiorName = x.SuperiorName,
                    SuperiorMail = x.SuperiorMail,
                    ApproverName = x.ApproverName,
                    ApproverMail = x.ApproverMail,
                }).ToList();
            ExportHelper.ExportToExcel(toExport, "Employees", new int[] { 9 });
        }
    }
}
