using Declaration.EntityFramework.Entity;
using Declaration.EntityFramework.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaration.EntityFramework.Repository
{
    public class UsersRepository : Repository<Users>, IUsersRepository
    {
        internal UsersRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
