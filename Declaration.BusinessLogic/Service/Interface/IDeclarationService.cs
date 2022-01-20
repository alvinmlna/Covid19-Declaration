using Declaration.EntityFramework.Entity;
using System.Collections.Generic;

namespace Declaration.BusinessLogic.Service.Interface
{
    public interface IDeclarationService
    {
        IEnumerable<DeclarationForm> GetAll();

        DeclarationForm FindById(int id);

        void Add(DeclarationForm declarationForm, IEnumerable<Relationship> relationships);
        void Edit(DeclarationForm declarationForm);

        void Remove(int id);

        Employee GetEmployee(string badgeId);


        bool isAlreadyAcknowledge(int id);
        void Approve(int id);
        void Reject(int id);
    }
}
