using Declaration.BusinessLogic.Enum;
using Declaration.BusinessLogic.Service.Interface;
using Declaration.EntityFramework.Entity;
using Declaration.EntityFramework.UOW;
using System;
using System.Collections.Generic;
using System.Web;

namespace Declaration.BusinessLogic.Service
{
    public class DeclarationService : IDeclarationService
    {
        private IUnitOfWork unitOfWork;
        private ISendMailService sendMailService;

        public DeclarationService(IUnitOfWork unitOfWork, ISendMailService sendMailService)
        {
            this.unitOfWork = unitOfWork;
            this.sendMailService = sendMailService;
        }
        public DeclarationForm FindById(int id)
        {
            return unitOfWork.DeclarationFormRepository.FindById(id);
        }
        public void Add(DeclarationForm declarationForm, IEnumerable<Relationship> relationships)
        {
            declarationForm.Submitter = HttpContext.Current.User.Identity.Name;
            declarationForm.DeclarationDetail = unitOfWork.DeclarationDetailRepository.FindById(declarationForm.DeclarationDetailId);
            declarationForm.DateSubmit = DateTime.UtcNow;
            unitOfWork.DeclarationFormRepository.Add(declarationForm);


            if (relationships != null)
            {
                //Tambahkan relationship
                foreach (var item in relationships)
                {
                    item.DeclarationForm = declarationForm;
                    unitOfWork.RelationshipRepository.Add(item);
                }
            }
            var isSaved = unitOfWork.SaveChanges();

            if (isSaved > 0)
            {
                sendMailService.SendMailToSuperior(declarationForm);
                sendMailService.SendMailToApprover(declarationForm);
            }
        }

        public IEnumerable<DeclarationForm> GetAll()
        {
            return unitOfWork.DeclarationFormRepository.GetAll();
        }

        public Employee GetEmployee(string badgeId)
        {
            return unitOfWork.EmployeeRepository.FindById(badgeId);
        }

        public void Edit(DeclarationForm declarationForm)
        {
            var toUpdate = unitOfWork.DeclarationFormRepository.FindById(declarationForm.DeclarationId);
            toUpdate.Destination = declarationForm.Destination;
            toUpdate.StartDate = declarationForm.StartDate;
            toUpdate.EndDate = declarationForm.EndDate;
            toUpdate.Remark = declarationForm.Remark;

            unitOfWork.DeclarationFormRepository.Update(toUpdate);
            unitOfWork.SaveChanges();
        }

        public void Remove(int id)
        {
            var toDelete = unitOfWork.DeclarationFormRepository.FindById(id);
            if (toDelete != null)
            {
                unitOfWork.DeclarationFormRepository.Remove(toDelete);
                unitOfWork.SaveChanges();
            }
        }

        public void Approve(int id)
        {
            var tobeUpdate = unitOfWork.DeclarationFormRepository.FindById(id);
            if (tobeUpdate != null)
            {
                tobeUpdate.AcknowledgeDate = DateTime.Now;
                tobeUpdate.StatusId = (int)FormStatusEnum.APPROVED;
                unitOfWork.DeclarationFormRepository.Update(tobeUpdate);
                var isSaved = unitOfWork.SaveChanges();
                if (isSaved > 0)
                {
                    sendMailService.SendNotificationMail(tobeUpdate);
                }
            }
        }

        public void Reject(int id)
        {
            var tobeUpdate = unitOfWork.DeclarationFormRepository.FindById(id);
            if (tobeUpdate != null)
            {
                tobeUpdate.AcknowledgeDate = DateTime.Now;
                tobeUpdate.StatusId = (int)FormStatusEnum.REJECTED;
                unitOfWork.DeclarationFormRepository.Update(tobeUpdate);
                var isSaved = unitOfWork.SaveChanges();
                if (isSaved > 0)
                {
                    sendMailService.SendNotificationMail(tobeUpdate);
                }
            }
        }

        public bool isAlreadyAcknowledge(int id)
        {
            var form = unitOfWork.DeclarationFormRepository.FindById(id);

            if (form !=null)
            {
                if (form.StatusId == (int)FormStatusEnum.OPEN)
                {
                    return false;
                }
            }

            return true;
            
        }
    }
}
