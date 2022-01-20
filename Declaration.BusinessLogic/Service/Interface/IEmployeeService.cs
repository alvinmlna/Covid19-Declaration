using Declaration.EntityFramework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaration.BusinessLogic.Service.Interface
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        Employee FindByBadgeId(string badgeId);
        void Add(Employee employee);
        void Edit(Employee employee);
        void Remove(string badgeId);
    }
}
