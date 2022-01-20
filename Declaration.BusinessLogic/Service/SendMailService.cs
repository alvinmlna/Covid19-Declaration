using Declaration.BusinessLogic._GLOBAL_CONFIGURATION;
using Declaration.BusinessLogic.Class;
using Declaration.BusinessLogic.Enum;
using Declaration.BusinessLogic.Helpers;
using Declaration.BusinessLogic.Service.Interface;
using Declaration.EntityFramework.Entity;
using Declaration.EntityFramework.UOW;
using System;
using System.Net.Mail;

namespace Declaration.BusinessLogic.Service
{
    public class SendMailService : ISendMailService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IExceptionService exception;

        string smtp = "your-smtp-here";
        string fromEmail = "CovidDeclaration@infineon.com";
        string alvinMail = "muhammadalvin.maulana@infineon.com";

        public SendMailService(
            IUnitOfWork unitOfWork,
            IExceptionService exception)
        {
            this.unitOfWork = unitOfWork;
            this.exception = exception;
        }

        public void SendMailToApprover(DeclarationForm declarationForm)
        {
            try
            {
                string mailTemplate = unitOfWork.EmailTemplateRepository.FindById(2).Content;

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(smtp);
                mail.From = new MailAddress(fromEmail);
                mail.Subject = "COVID-19 Declaration Survey";

                //get approver mail
                string approverMail = unitOfWork.EmployeeRepository.FindById(declarationForm.BadgeId)?.ApproverMail;

                if (CheckEmail(approverMail))
                {
                    mail.To.Add(approverMail);
                } else
                {
                    mail.Subject = "Failed to send - COVID-19 Declaration Survey";
                    mail.To.Add(alvinMail);
                }

                mail.Bcc.Add(alvinMail);

                #region Approve

                string href = "";
#if DEBUG
                href = "http://localhost:53401/Confirmation/Approve/{0}";
#else
            href = "http://covid19.bth.infineon.com/declaration/Confirmation/Approve/{0}";
#endif

                href = string.Format(href, declarationForm.DeclarationId);
                mailTemplate = mailTemplate.Replace("[%ApproveUrl%]", href);

                #endregion

                #region Reject

                string rejectUrl = "";
#if DEBUG
                rejectUrl = "http://localhost:53401/Confirmation/Reject/{0}";
#else
                rejectUrl = "http://covid19.bth.infineon.com/declaration/Confirmation/Reject/{0}";
#endif

                rejectUrl = string.Format(rejectUrl, declarationForm.DeclarationId);
                mailTemplate = mailTemplate.Replace("[%RejectUrl%]", rejectUrl);

                #endregion

                mailTemplate = GetMailContent(mailTemplate, declarationForm);
                mail.Body = mailTemplate;

                if (string.IsNullOrEmpty(declarationForm.Attachment) == false)
                {
                    var fileUrl = System.Web.HttpContext.Current.Server.MapPath(declarationForm.Attachment);
                    mail.Attachments.Add(new Attachment(fileUrl));
                }

                mail.IsBodyHtml = true;

                SmtpServer.Credentials = new System.Net.NetworkCredential("", "");

                if (GlobalVariables.ACCESS_SEND_MAIL == true)
                {
                    try
                    {
                        SmtpServer.Send(mail);
                        var sentMail = new SendMailLog()
                        {
                            Recepient = mail.To.ToString(),
                            RecepientCC = mail.CC.ToString(),
                            RecepientBCC = mail.Bcc.ToString(),
                            Subject = mail.Subject,
                            BodyContent = mail.Body,
                            SentDate = DateTime.UtcNow
                        };

                        // save each record of each mail sent
                        unitOfWork.SendMailLogRepository.Add(sentMail);
                        unitOfWork.SaveChanges();
                    }
                    catch (SmtpFailedRecipientsException ex)
                    {
                        for (int i = 0; i < ex.InnerExceptions.Length; i++)
                        {
                            SmtpStatusCode status = ex.StatusCode;
                            MailFailException(ex.InnerExceptions[i].FailedRecipient, ex.StatusCode.ToString(), ex.StackTrace);
                        }
                    }
                    catch (SmtpFailedRecipientException ex)
                    {
                        SmtpStatusCode status = ex.StatusCode;
                        MailFailException(ex.FailedRecipient, ex.StatusCode.ToString(), ex.StackTrace);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void SendMailToSuperior(DeclarationForm declarationForm)
        {
            try
            {
                string mailTemplate = unitOfWork.EmailTemplateRepository.FindById(3).Content;

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(smtp);
                mail.From = new MailAddress(fromEmail);
                mail.Subject = "COVID-19 Declaration Survey";

                //get approver mail
                string superiorMail = unitOfWork.EmployeeRepository.FindById(declarationForm.BadgeId)?.SuperiorMail;


                if (CheckEmail(superiorMail))
                {
                    mail.To.Add(superiorMail);
                } else
                {
                    mail.To.Add(alvinMail);
                    mail.Subject = "Failed to send - COVID-19 Declaration Survey";
                }

                mail.Bcc.Add(alvinMail);

                //Get mail template
                mailTemplate = GetMailContent(mailTemplate, declarationForm);
                mail.Body = mailTemplate;

                if (string.IsNullOrEmpty(declarationForm.Attachment) == false)
                {
                    var fileUrl = System.Web.HttpContext.Current.Server.MapPath(declarationForm.Attachment);
                    mail.Attachments.Add(new Attachment(fileUrl));
                }

                mail.IsBodyHtml = true;

                SmtpServer.Credentials = new System.Net.NetworkCredential("OJT TEAM", "1234");

                if (GlobalVariables.ACCESS_SEND_MAIL == true )
                {
                    try
                    {
                        SmtpServer.Send(mail);
                        var sentMail = new SendMailLog()
                        {
                            Recepient = mail.To.ToString(),
                            RecepientCC = mail.CC.ToString(),
                            RecepientBCC = mail.Bcc.ToString(),
                            Subject = mail.Subject,
                            BodyContent = mail.Body,
                            SentDate = DateTime.UtcNow
                        };

                        // save each record of each mail sent
                        unitOfWork.SendMailLogRepository.Add(sentMail);
                        unitOfWork.SaveChanges();
                    }
                    catch (SmtpFailedRecipientsException ex)
                    {
                        for (int i = 0; i < ex.InnerExceptions.Length; i++)
                        {
                            SmtpStatusCode status = ex.StatusCode;
                            MailFailException(ex.InnerExceptions[i].FailedRecipient, ex.StatusCode.ToString(), ex.StackTrace);
                        }
                    }
                    catch (SmtpFailedRecipientException ex)
                    {
                        SmtpStatusCode status = ex.StatusCode;
                        MailFailException(ex.FailedRecipient, ex.StatusCode.ToString(), ex.StackTrace);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void SendNotificationMail(DeclarationForm declarationForm)
        {
            try
            {
                string mailTemplate = unitOfWork.EmailTemplateRepository.FindById(1).Content;

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(smtp);
                mail.From = new MailAddress(fromEmail);
                mail.Subject = "COVID-19 Declaration Survey";

                //get approver mail
                var employee = unitOfWork.EmployeeRepository.FindById(declarationForm.BadgeId);
                if (employee != null)
                {
                    bool check = false;


                    if (CheckEmail(employee.Email))
                    {
                        mail.To.Add(employee.Email);
                        check = true;
                    }
                    if (CheckEmail(employee.SuperiorMail))
                    {
                        mail.To.Add(employee.SuperiorMail);
                        check = true;
                    }

                    if (check == false)
                    {
                        mail.To.Add(alvinMail);
                        mail.Subject = "Failed to send - COVID-19 Declaration Survey";
                    }
                } else
                {
                    mail.To.Add(alvinMail);
                    mail.Subject = "Failed to send - COVID-19 Declaration Survey";
                }

                mail.Bcc.Add("muhammadalvin.maulana@infineon.com");

                //menampilkan status
                if (declarationForm.StatusId == (int)FormStatusEnum.APPROVED)
                {
                    mailTemplate = mailTemplate.Replace("[%status%]", "approved");
                } else
                {
                    mailTemplate = mailTemplate.Replace("[%status%]", "rejected");
                }


                //Get mail template
                mailTemplate = GetMailContent(mailTemplate, declarationForm);
                mail.Body = mailTemplate;

                if (string.IsNullOrEmpty(declarationForm.Attachment) == false)
                {
                    var fileUrl = System.Web.HttpContext.Current.Server.MapPath(declarationForm.Attachment);
                    mail.Attachments.Add(new Attachment(fileUrl));
                }

                mail.IsBodyHtml = true;

                SmtpServer.Credentials = new System.Net.NetworkCredential("OJT TEAM", "1234");

                if (GlobalVariables.ACCESS_SEND_MAIL == true)
                {
                    try
                    {
                        SmtpServer.Send(mail);
                        var sentMail = new SendMailLog()
                        {
                            Recepient = mail.To.ToString(),
                            RecepientCC = mail.CC.ToString(),
                            RecepientBCC = mail.Bcc.ToString(),
                            Subject = mail.Subject,
                            BodyContent = mail.Body,
                            SentDate = DateTime.UtcNow
                        };

                        // save each record of each mail sent
                        unitOfWork.SendMailLogRepository.Add(sentMail);
                        unitOfWork.SaveChanges();
                    }
                    catch (SmtpFailedRecipientsException ex)
                    {
                        for (int i = 0; i < ex.InnerExceptions.Length; i++)
                        {
                            SmtpStatusCode status = ex.StatusCode;
                            MailFailException(ex.InnerExceptions[i].FailedRecipient, ex.StatusCode.ToString(), ex.StackTrace);
                        }
                    }
                    catch (SmtpFailedRecipientException ex)
                    {
                        SmtpStatusCode status = ex.StatusCode;
                        MailFailException(ex.FailedRecipient, ex.StatusCode.ToString(), ex.StackTrace);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }


        private bool CheckEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            } else
            {
                if (email.ToLower().Contains("@infineon.com"))
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }


        private string GetMailContent(string mailTemplate, DeclarationForm declarationForm)
        {
            var declarationType = (DeclarationTypeEnum)declarationForm.DeclarationDetail.DeclarationType.DeclarationTypeId;
            var LabelModel = DeclarationFormHelpers.GetLabel(declarationType, true);

            //Label
            mailTemplate = mailTemplate.Replace("[%lbl_badge%]", LabelModel.BadgeId);
            mailTemplate = mailTemplate.Replace("[%lbl_Name%]", LabelModel.Name);
            //Department hardcode from html
            mailTemplate = mailTemplate.Replace("[%lbl_Destination%]", LabelModel.Destination);
            mailTemplate = mailTemplate.Replace("[%lbl_StartDate%]", LabelModel.StartDate);
            mailTemplate = mailTemplate.Replace("[%lbl_EndDate%]", LabelModel.EndDate);
            mailTemplate = mailTemplate.Replace("[%lbl_Remark%]", LabelModel.Remark);

            //Relationship
            if (declarationForm.DeclarationDetail.IsRelationshipRequired)
            {
                mailTemplate = mailTemplate.Replace("[%Relationship%]", DeclarationFormHelpers.GetRelationshipTable(declarationForm.Relationships, LabelModel));
            }
            else
            {
                mailTemplate = mailTemplate.Replace("[%Relationship%]", "");
            }


            //Content
            var employee = unitOfWork.EmployeeRepository.FindById(declarationForm.BadgeId);

            mailTemplate = mailTemplate.Replace("[%PreHeader%]", declarationForm.DeclarationDetail.DeclarationType.Type);
            mailTemplate = mailTemplate.Replace("[%DeclarationType%]", declarationForm.DeclarationDetail.Detail);
            mailTemplate = mailTemplate.Replace("[%Badgeid%]", declarationForm.BadgeId);
            mailTemplate = mailTemplate.Replace("[%Name%]", declarationForm.Name);
            mailTemplate = mailTemplate.Replace("[%Dept%]", employee?.Department);
            mailTemplate = mailTemplate.Replace("[%Destination%]", declarationForm.Destination);
            mailTemplate = mailTemplate.Replace("[%StartDate%]", declarationForm.StartDate.ToShortDateString());


            //Jika declaration type == Travel
            if (declarationForm.DeclarationDetail.DeclarationType.DeclarationTypeId == 1)
            {
                mailTemplate = mailTemplate.Replace("[%TravelReason%]", DeclarationFormHelpers.GetTravelReasonTable(declarationForm.TravelReason, LabelModel));
            } else
            {
                mailTemplate = mailTemplate.Replace("[%TravelReason%]", "");
            }


            mailTemplate = mailTemplate.Replace("[%EndDate%]", declarationForm.EndDate.ToShortDateString());

            mailTemplate = mailTemplate.Replace("[%Remark%]", declarationForm.Remark);


            return mailTemplate;
        }

        private void MailFailException(string mail, string actionName, string stackTrace)
        {
            var logger = new ExceptionLog
            {
                //UserId = ,
                ExceptionMessage = "This mail (" + mail + ") Failed to send",
                ExceptionStackTrace = stackTrace,
                ControllerName = "MailSender",
                ActionName = actionName,
                LogTime = DateTime.UtcNow.ToBatamTime()
            };

            exception.AddLog(logger);
        }
    }

}
