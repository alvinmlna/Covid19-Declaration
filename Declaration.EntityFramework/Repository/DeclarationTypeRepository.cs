using Declaration.EntityFramework.Entity;
using Declaration.EntityFramework.Repository.Interface;

namespace Declaration.EntityFramework.Repository
{
    public class DeclarationTypeRepository : Repository<DeclarationType>, IDeclarationTypeRepository
    {
        public DeclarationTypeRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
