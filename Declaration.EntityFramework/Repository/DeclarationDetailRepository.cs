using Declaration.EntityFramework.Entity;
using Declaration.EntityFramework.Repository.Interface;

namespace Declaration.EntityFramework.Repository
{
    public class DeclarationDetailRepository : Repository<DeclarationDetail>, IDeclarationDetailRepository
    {
        public DeclarationDetailRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
