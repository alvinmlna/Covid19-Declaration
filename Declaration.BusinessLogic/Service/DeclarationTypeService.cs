using Declaration.BusinessLogic.Service.Interface;
using Declaration.EntityFramework.Entity;
using Declaration.EntityFramework.UOW;
using System.Collections.Generic;

namespace Declaration.BusinessLogic.Service
{
    public class DeclarationTypeService : IDeclarationTypeService
    {
        private readonly IUnitOfWork unitOfWork;

        public DeclarationTypeService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public DeclarationType FindById(int id)
        {
            return unitOfWork.DeclarationTypeRepository.FindById(id);
        }

        public DeclarationDetail FindDetailById(int id)
        {
            return unitOfWork.DeclarationDetailRepository.FindById(id);
        }

        public IEnumerable<DeclarationType> GetAll()
        {
            return unitOfWork.DeclarationTypeRepository.GetAll();
        }

        public IEnumerable<DeclarationDetail> GetAllDetail()
        {
            return unitOfWork.DeclarationDetailRepository.GetAll();
        }
    }
}
