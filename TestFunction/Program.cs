using Declaration.BusinessLogic.Service;
using Declaration.BusinessLogic.Service.Interface;
using Declaration.DepedencyInjection;
using Declaration.EntityFramework.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity;


namespace TestFunction
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var injectionContainer = UnityBootstrapper.BuildUnityContainer();
            //IDeclarationService declarationService = injectionContainer.Resolve<IDeclarationService>();

            string email = "bambang@INfineon";
            if (string.IsNullOrEmpty(email))
            {
                Console.WriteLine("False");
            }
            else
            {
                if (email.ToLower().Contains("@infineon.com"))
                {
                    Console.WriteLine("true");
                } else
                {
                    Console.WriteLine("False");
                }
            }


            Console.Read();

            //TestSubmit();
        }


        private static void TestSubmit()
        {
            var injectionContainer = UnityBootstrapper.BuildUnityContainer();
            IDeclarationService declarationService = injectionContainer.Resolve<IDeclarationService>();

            DeclarationForm declarationForm = new DeclarationForm();

            declarationForm.DeclarationDetailId = 1;

            declarationForm.BadgeId = "30132514";
            declarationForm.Destination = "Bandar udara";
            declarationForm.StartDate = DateTime.Now.AddDays(-1);
            declarationForm.EndDate = DateTime.Now.AddDays(3);
            declarationForm.Remark = "Remark";

            List<Relationship> relationships = new List<Relationship>();
            relationships.Add(new Relationship() { Name = "Bambang", RelationshipType = "Ayah" });
            relationships.Add(new Relationship() { Name = "Maimunah", RelationshipType = "Ibu" });
            relationships.Add(new Relationship() { Name = "Dadang", RelationshipType = "Kakek" });

            declarationService.Add(declarationForm, relationships);
            var a = ViewAllForm();
            foreach (var item in a)
            {
                if (item.Relationships.Count > 0)
                {
                    foreach (var i in item.Relationships)
                    {
                        Console.WriteLine(i.Name);
                    }
                }
            }

        }

        private static IEnumerable<DeclarationForm> ViewAllForm()
        {
            var injectionContainer = UnityBootstrapper.BuildUnityContainer();
            IDeclarationService declarationService = injectionContainer.Resolve<IDeclarationService>();
           return declarationService.GetAll();
        }
    }
}
