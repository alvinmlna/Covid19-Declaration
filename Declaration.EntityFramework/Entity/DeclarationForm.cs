using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Declaration.EntityFramework.Entity
{
    public class DeclarationForm
    {
        [Key]
        public int DeclarationId { get; set; }
        public string BadgeId { get; set; }
        public string Name { get; set; }
        public string Destination { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EndDate { get; set; }
        public string TravelReason { get; set; }
        public string Remark { get; set; }
        public string Submitter { get; set; }
        public DateTime DateSubmit { get; set; }

        public string MainDestination { get; set; }
        public string VaccinationStatus { get; set; }

        public string Attachment { get; set; }

        public int StatusId { get; set; }
        public DateTime? AcknowledgeDate { get; set; }

        [NotMapped]
        public int DeclarationDetailId { get; set; }

        public virtual DeclarationDetail DeclarationDetail { get; set; }

        public virtual ICollection<Relationship> Relationships { get; set; }
    }
}
