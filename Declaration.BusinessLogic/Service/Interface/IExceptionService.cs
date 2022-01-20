using Declaration.EntityFramework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaration.BusinessLogic.Service.Interface
{
    public interface IExceptionService
    {
        int AddLog(ExceptionLog log);
        ExceptionLog FindById(int id);
        IEnumerable<ExceptionLog> GetAll();
        int SentExceptionMail(int id);
    }
}
