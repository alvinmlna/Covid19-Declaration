using Declaration.BusinessLogic.Helpers;
using Declaration.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Declaration.ViewModel.Form
{
    public class TravelDeclarationViewModel
    {
        public int DeclarationDetailId { get; set; }
        public int DeclarationTypeId { get; set; }
        public string DeclarationDetail { get; set; }

        public string BadgeId { get; set; }

        public string Name { get; set; }

        public string[] TravelerName { get; set; }
        public string[] Relationship { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Destination { get; set; }
        public string MainDestination { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime EndDate { get; set; }

        [RequiredIf("DeclarationTypeId", 1, ErrorMessage = "This field is required")]
        public string TravelReason { get; set; }



        public string AdditionalInformation { get; set; }
        public bool IsRelationshipRequired { get; set; }
        public string VaccineStatus { get; set; }
        public bool WithVaccineStatus { get; set; }

        public LabelModel LabelModel { get; set; }

        public string Quarantine { get; set; }
        public string[] QuarantineList { get { return Quarantine.Split('~');}}

        public string PCR { get; set; }
        public string[] PCRList { get { return PCR.Split('~');}}

        public HttpPostedFileBase Attachment { get; set; }

        public List<RelationShipTravelViewModel> RelationshipList { get; set; }
    }

    public class RelationShipTravelViewModel
    {
        public string Name { get; set; }

        public string Relationship { get; set; }
    }
}