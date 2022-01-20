namespace Declaration.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Covid_Declaration.DeclarationDetails",
                c => new
                    {
                        DeclarationDetailId = c.Int(nullable: false, identity: true),
                        Detail = c.String(),
                        Detail_Id = c.String(),
                        IsRelationshipRequired = c.Boolean(nullable: false),
                        Quarantine = c.String(),
                        PCR = c.String(),
                        Quarantine_Id = c.String(),
                        PCR_Id = c.String(),
                        ShowList = c.Boolean(nullable: false),
                        Remark = c.String(),
                        WithVaccineStatus = c.Boolean(nullable: false),
                        DeclarationType_DeclarationTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.DeclarationDetailId)
                .ForeignKey("Covid_Declaration.DeclarationTypes", t => t.DeclarationType_DeclarationTypeId)
                .Index(t => t.DeclarationType_DeclarationTypeId);
            
            CreateTable(
                "Covid_Declaration.DeclarationForms",
                c => new
                    {
                        DeclarationId = c.Int(nullable: false, identity: true),
                        BadgeId = c.String(),
                        Name = c.String(),
                        Destination = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        TravelReason = c.String(),
                        Remark = c.String(),
                        Submitter = c.String(),
                        DateSubmit = c.DateTime(nullable: false),
                        MainDestination = c.String(),
                        VaccinationStatus = c.String(),
                        Attachment = c.String(),
                        StatusId = c.Int(nullable: false),
                        AcknowledgeDate = c.DateTime(),
                        DeclarationDetail_DeclarationDetailId = c.Int(),
                    })
                .PrimaryKey(t => t.DeclarationId)
                .ForeignKey("Covid_Declaration.DeclarationDetails", t => t.DeclarationDetail_DeclarationDetailId)
                .Index(t => t.DeclarationDetail_DeclarationDetailId);
            
            CreateTable(
                "Covid_Declaration.Relationships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeclarationId = c.Int(nullable: false),
                        Name = c.String(),
                        RelationshipType = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Covid_Declaration.DeclarationForms", t => t.DeclarationId, cascadeDelete: true)
                .Index(t => t.DeclarationId);
            
            CreateTable(
                "Covid_Declaration.DeclarationTypes",
                c => new
                    {
                        DeclarationTypeId = c.Int(nullable: false, identity: true),
                        DeclarationTitle = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.DeclarationTypeId);
            
            CreateTable(
                "Covid_Declaration.EmailTemplates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Subject = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Covid_Declaration.Employees",
                c => new
                    {
                        BadgeId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Email = c.String(),
                        Department = c.String(),
                        SuperiorName = c.String(),
                        SuperiorMail = c.String(),
                        ApproverName = c.String(),
                        ApproverMail = c.String(),
                        SubmittedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BadgeId);
            
            CreateTable(
                "Covid_Declaration.ExceptionLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExceptionMessage = c.String(),
                        ControllerName = c.String(),
                        ActionName = c.String(),
                        ExceptionStackTrace = c.String(),
                        UserId = c.String(),
                        LogTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Covid_Declaration.SendMailLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        Recepient = c.String(),
                        RecepientCC = c.String(),
                        RecepientBCC = c.String(),
                        SentDate = c.DateTime(nullable: false),
                        BodyContent = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Covid_Declaration.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Covid_Declaration.DeclarationDetails", "DeclarationType_DeclarationTypeId", "Covid_Declaration.DeclarationTypes");
            DropForeignKey("Covid_Declaration.Relationships", "DeclarationId", "Covid_Declaration.DeclarationForms");
            DropForeignKey("Covid_Declaration.DeclarationForms", "DeclarationDetail_DeclarationDetailId", "Covid_Declaration.DeclarationDetails");
            DropIndex("Covid_Declaration.Relationships", new[] { "DeclarationId" });
            DropIndex("Covid_Declaration.DeclarationForms", new[] { "DeclarationDetail_DeclarationDetailId" });
            DropIndex("Covid_Declaration.DeclarationDetails", new[] { "DeclarationType_DeclarationTypeId" });
            DropTable("Covid_Declaration.Users");
            DropTable("Covid_Declaration.SendMailLogs");
            DropTable("Covid_Declaration.ExceptionLogs");
            DropTable("Covid_Declaration.Employees");
            DropTable("Covid_Declaration.EmailTemplates");
            DropTable("Covid_Declaration.DeclarationTypes");
            DropTable("Covid_Declaration.Relationships");
            DropTable("Covid_Declaration.DeclarationForms");
            DropTable("Covid_Declaration.DeclarationDetails");
        }
    }
}
