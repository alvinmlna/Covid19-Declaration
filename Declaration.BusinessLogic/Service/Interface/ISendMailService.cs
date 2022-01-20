using Declaration.EntityFramework.Entity;

namespace Declaration.BusinessLogic.Service.Interface
{
    public interface ISendMailService
    {
        void SendNotificationMail(DeclarationForm declarationForm);

        void SendMailToApprover(DeclarationForm declarationForm);
        void SendMailToSuperior(DeclarationForm declarationForm);
    }
}
