using Declaration.EntityFramework.Entity;
using Declaration.EntityFramework.Repository.Interface;

namespace Declaration.EntityFramework.Repository
{

    public class DeclarationFormRepository : Repository<DeclarationForm>, IDeclarationFormRepository
    {
        public DeclarationFormRepository(ApplicationDBContext context)
            : base(context)
        {
        }
    }
}
