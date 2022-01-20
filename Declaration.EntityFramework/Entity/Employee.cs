using System;
using System.ComponentModel.DataAnnotations;

namespace Declaration.EntityFramework.Entity
{
    public class Employee
    {
        [Key]
        public string BadgeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }

        public string SuperiorName { get; set; }
        public string SuperiorMail { get; set; }

        public string ApproverName { get; set; }
        public string ApproverMail { get; set; }

        public DateTime SubmittedDate { get; set; }
    }
}
