using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Declaration.EntityFramework.Entity
{
    public class DeclarationType
    {

        [Key]
        public int DeclarationTypeId { get; set; }
        public string DeclarationTitle { get; set; }
        public string Type { get; set; }

        public virtual ICollection<DeclarationDetail> DeclarationDetails { get; set; }
    }
}
