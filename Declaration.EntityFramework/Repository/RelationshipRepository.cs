using Declaration.EntityFramework.Entity;
using Declaration.EntityFramework.Repository.Interface;

namespace Declaration.EntityFramework.Repository
{
    public class RelationshipRepository : Repository<Relationship>, IRelationshipRepository
    {
        public RelationshipRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
