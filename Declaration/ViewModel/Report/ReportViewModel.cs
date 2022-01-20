using Declaration.BusinessLogic.Enum;
using Declaration.ViewModel.Form;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Declaration.ViewModel.Report
{
    public class ReportViewModel
    {
        public int Id { get; set; }
        public string BadgeId { get; set; }

        public string Name { get; set; }

        public string Destination { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EndDate { get; set; }

        public string Remark { get; set; }

        public DateTime DateSubmit { get; set; }

        public string Status { get; set; }

        public string Attachment { get; set; }

        public string DeclarationDetail { get; set; }

        public RelationShipTravelViewModel[] Relationship { get; set; }
    }
}