using Declaration.EntityFramework.Entity;
using System.Data.Entity;

namespace Declaration.EntityFramework
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<DeclarationForm> Declarations { get; set; }
        public DbSet<Relationship> Relationships { get; set; }
        public DbSet<DeclarationType> DeclarationTypes { get; set; }
        public DbSet<DeclarationDetail> DeclarationDetails { get; set; }
        public DbSet<EmailTemplate> EmailTemplates { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<SendMailLog> SendMailLogs { get; set; }
        public DbSet<ExceptionLog> ExceptionLogs { get; set; }


        public ApplicationDBContext(): base("Covid19Declaration")
        {


        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Covid_Declaration");
        }
    }
}
