using Declaration.BusinessLogic.Service;
using Declaration.BusinessLogic.Service.Interface;
using Declaration.EntityFramework.UOW;
using Unity;

namespace Declaration.DepedencyInjection
{
    public class UnityBootstrapper
    {
        public static IUnityContainer BuildUnityContainer()
        {
            IUnityContainer container = new UnityContainer();


            // register all your components with the container here
            // it is NOT necessary to register your controllers
            // e.g. container.RegisterType<ITestService, TestService>();

            //var a = typeof(DeclarationService).GetTypeInfo().Assembly.GetTypes()
            //    .Where(t => t.Name.EndsWith("Service") || t.Name.EndsWith("Validator"));

            //container.RegisterTypes(typeof(DeclarationService).GetTypeInfo().Assembly.GetTypes()
            //    .Where(t => t.Name.EndsWith("Service") || t.Name.EndsWith("Validator")),
            //                        WithMappings.FromMatchingInterface,
            //                        WithName.Default,
            //                        WithLifetime.Transient);

            container.RegisterType<IDeclarationService, DeclarationService>();
            container.RegisterType<IDeclarationTypeService, DeclarationTypeService>();
            container.RegisterType<ISendMailService, SendMailService>();
            container.RegisterType<IApplicationCoreService, ApplicationCoreService>();
            container.RegisterType<IEmployeeService, EmployeeService>();
            container.RegisterType<IExceptionService, ExceptionService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();

            return container;
        }
    }
}
