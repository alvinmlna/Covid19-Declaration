using Declaration.EntityFramework.Repository;
using Declaration.EntityFramework.Repository.Interface;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Declaration.EntityFramework.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        IDeclarationFormRepository DeclarationFormRepository { get; }
        IDeclarationTypeRepository DeclarationTypeRepository { get; }
        IDeclarationDetailRepository DeclarationDetailRepository { get; }
        IRelationshipRepository RelationshipRepository { get; }
        IEmailTemplateRepository EmailTemplateRepository { get; }
        IEmployeeRepository EmployeeRepository{ get; }
        IUsersRepository UsersRepository { get; }
        ISendMailLogRepository SendMailLogRepository { get; }
        IExceptionLogRepository ExceptionLogRepository { get; } 

        #region Methods
        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        #endregion
    }
}
