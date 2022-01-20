
using Declaration.EntityFramework.Entity;
using Declaration.EntityFramework.Repository.Interface;

namespace Declaration.EntityFramework.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        internal EmployeeRepository(ApplicationDBContext context) : base(context)
        {
        }

    }
}
