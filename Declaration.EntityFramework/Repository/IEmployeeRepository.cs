using Declaration.EntityFramework.Entity;
using Declaration.EntityFramework.Repository.Interface;

namespace Declaration.EntityFramework.Repository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
    }
}
