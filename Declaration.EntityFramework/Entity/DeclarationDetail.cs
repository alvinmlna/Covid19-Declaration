using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Declaration.EntityFramework.Entity
{
    public class DeclarationDetail
    {
        [Key]
        public int DeclarationDetailId { get; set; }
        public string Detail { get; set; }
        public string Detail_Id { get; set; }

        public bool  IsRelationshipRequired { get; set; }

        public string Quarantine { get; set; }
        public string PCR { get; set; }
        public string Quarantine_Id { get; set; }
        public string PCR_Id { get; set; }
        public bool ShowList { get; set; }

        public string Remark { get; set; }

        public bool WithVaccineStatus { get; set; }

        public virtual DeclarationType DeclarationType { get; set; }

        public ICollection<DeclarationForm> DeclarationForms { get; set; }
    }
}
