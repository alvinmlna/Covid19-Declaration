using System;
using System.Data.Entity.Validation;
using System.Threading;
using System.Threading.Tasks;
using Declaration.EntityFramework.Repository;
using Declaration.EntityFramework.Repository.Interface;

namespace Declaration.EntityFramework.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields
        private readonly ApplicationDBContext context;
        private IDeclarationFormRepository declarationFormRepository;
        private IDeclarationTypeRepository declarationTypeRepository;
        private IDeclarationDetailRepository declarationDetailRepository;
        private IRelationshipRepository relationshipRepository;
        private IEmailTemplateRepository emailTemplateRepository;
        private IEmployeeRepository employeeRepository;
        private IUsersRepository usersRepository;
        private ISendMailLogRepository sendMailLogRepository;
        private IExceptionLogRepository exceptionLogRepository;

        #endregion

        public UnitOfWork()
        {
            context = new ApplicationDBContext();
        }

        #region IUnitOfWork Methods
        public IDeclarationFormRepository DeclarationFormRepository
        {
            get { return declarationFormRepository ?? (declarationFormRepository = new DeclarationFormRepository(context)); }
        }

        public IDeclarationTypeRepository DeclarationTypeRepository
        {
            get { return declarationTypeRepository ?? (declarationTypeRepository = new DeclarationTypeRepository(context)); }
        }
        public IDeclarationDetailRepository DeclarationDetailRepository
        {
            get { return declarationDetailRepository ?? (declarationDetailRepository = new DeclarationDetailRepository(context)); }
        }

        public IRelationshipRepository RelationshipRepository
        {
            get { return relationshipRepository ?? (relationshipRepository = new RelationshipRepository(context)); }
        }
        public IEmailTemplateRepository EmailTemplateRepository
        {
            get { return emailTemplateRepository ?? (emailTemplateRepository= new EmailTemplateRepository(context)); }
        }
        public IEmployeeRepository EmployeeRepository
        {
            get { return employeeRepository ?? (employeeRepository = new EmployeeRepository(context)); }
        }
        public IUsersRepository UsersRepository
        {
            get { return usersRepository ?? (usersRepository= new UsersRepository(context)); }
        }
        public ISendMailLogRepository SendMailLogRepository
        {
            get { return sendMailLogRepository ?? (sendMailLogRepository = new SendMailLogRepository(context)); }
        }

        public IExceptionLogRepository ExceptionLogRepository
        {
            get { return exceptionLogRepository ?? (exceptionLogRepository = new ExceptionLogRepository(context)); }
        }

        #endregion

        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
                context.Dispose();

            _disposed = true;
        }

        public void Dispose()
        {
            //_menuRepository = null;
            //_userRepository = null;
            //_roleRepository = null;
            //_appearanceRepository = null;
            //_adRepository = null;
            //_capacityRepository = null;
            //_context.Dispose();
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int SaveChanges()
        {
            try
            {
                return context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public Task<int> SaveChangesAsync()
        {
            return context.SaveChangesAsync();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return context.SaveChangesAsync(cancellationToken);
        }
    }
}
