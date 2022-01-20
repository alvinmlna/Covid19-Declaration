using Declaration.BusinessLogic.Constant;
using Declaration.BusinessLogic.Service.Interface;
using Declaration.EntityFramework.UOW;
using System.Linq;
using System.Web;

namespace Declaration.BusinessLogic.Service
{
    public class ApplicationCoreService : IApplicationCoreService
    {
        private readonly IUnitOfWork unitOfwork;

        public ApplicationCoreService(IUnitOfWork unitOfWork)
        {
            this.unitOfwork = unitOfWork;
        }

        public bool IsAdmin()
        {
            if (HttpContext.Current.Session[Session_Constant.IS_ADMIN] == null)
            {
                var adminList = unitOfwork.UsersRepository.GetAll().Select(x => x.UserName.ToLower());
                var isAdmin = adminList.Contains(HttpContext.Current.User.Identity.Name.ToLower());

                HttpContext.Current.Session[Session_Constant.IS_ADMIN] = isAdmin;
            }

            return (bool)HttpContext.Current.Session[Session_Constant.IS_ADMIN];
        }
    }
}
