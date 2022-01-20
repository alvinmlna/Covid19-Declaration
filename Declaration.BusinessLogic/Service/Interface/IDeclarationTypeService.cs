using Declaration.EntityFramework.Entity;
using System.Collections.Generic;

namespace Declaration.BusinessLogic.Service.Interface
{
    public interface IDeclarationTypeService
    {
        IEnumerable<DeclarationType> GetAll();

        DeclarationType FindById(int id);
        DeclarationDetail FindDetailById(int id);
        IEnumerable<DeclarationDetail> GetAllDetail();
    }
}
