using Declaration.BusinessLogic.Service.Interface;
using Declaration.EntityFramework.Entity;
using Declaration.EntityFramework.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaration.BusinessLogic.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        public void Add(Employee employee)
        {
            employee.SubmittedDate = DateTime.Now;
            unitOfWork.EmployeeRepository.Add(employee);
            unitOfWork.SaveChanges();
        }

        public void Edit(Employee employee)
        {
            var tobeUpdate = unitOfWork.EmployeeRepository.FindById(employee.BadgeId);


            tobeUpdate.Name = employee.Name;
            tobeUpdate.Department = employee.Department;
            tobeUpdate.Email = employee.Email;
            tobeUpdate.SuperiorName = employee.SuperiorName;
            tobeUpdate.SuperiorMail = employee.SuperiorMail;
            tobeUpdate.ApproverName = employee.ApproverName;
            tobeUpdate.ApproverMail = employee.ApproverMail;
            tobeUpdate.SubmittedDate = DateTime.Now;

            unitOfWork.EmployeeRepository.Update(tobeUpdate);
            unitOfWork.SaveChanges();
        }

        public Employee FindByBadgeId(string badgeId)
        {
            return unitOfWork.EmployeeRepository.FindById(badgeId);
        }

        public IEnumerable<Employee> GetAll()
        {
            return unitOfWork.EmployeeRepository.GetAll();
        }

        public void Remove(string badgeId)
        {
            var todelete = unitOfWork.EmployeeRepository.FindById(badgeId);
            if (todelete != null)
            {
                unitOfWork.EmployeeRepository.Remove(todelete);
                unitOfWork.SaveChanges();
            }
        }
    }
}
