using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Declaration.ViewModel
{
    public class EmployeeViewModel
    {
        public string BadgeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }

        public string SuperiorName { get; set; }
        public string SuperiorMail { get; set; }

        public string ApproverName { get; set; }
        public string ApproverMail { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd MMMM yyyy}")]
        public DateTime SubmittedDate { get; set; }
    }
}