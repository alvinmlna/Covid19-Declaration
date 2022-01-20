using Declaration.BusinessLogic.Service.Interface;
using Declaration.EntityFramework.Entity;
using Declaration.EntityFramework.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaration.BusinessLogic.Service
{
    public class ExceptionService : IExceptionService
    {
        private IUnitOfWork unitOfWork;

        public ExceptionService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public int AddLog(ExceptionLog log)
        {
            unitOfWork.ExceptionLogRepository.Add(log);

            return unitOfWork.SaveChanges();
        }

        public ExceptionLog FindById(int id)
        {
            return unitOfWork.ExceptionLogRepository.FindById(id);
        }

        public IEnumerable<ExceptionLog> GetAll()
        {
            return unitOfWork.ExceptionLogRepository.GetAll();
        }

        // TODO: Implement sent mail
        public int SentExceptionMail(int id)
        {
            throw new NotImplementedException();
        }
    }
}
