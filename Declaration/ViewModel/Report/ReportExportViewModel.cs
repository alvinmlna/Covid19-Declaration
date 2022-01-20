using Declaration.ViewModel.Form;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Declaration.ViewModel.Report
{
    public class ReportExportViewModel
    {
        public string DeclarationType { get; set; }
        public string BadgeId { get; set; }

        public string Name { get; set; }

        public string Destination { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EndDate { get; set; }
        public string TravelReason { get; set; }
        public string Supervisor { get; set; }

        public string Remark { get; set; }

        public DateTime DateSubmit { get; set; }

        public string Status { get; set; }

        public string DeclarationDetail { get; set; }


        public RelationShipTravelViewModel[] Relationship { get; set; }

        public string Relationship1
        {
            get
            {
                if (Relationship.Length >= 1)
                {
                    return Relationship[0].Name;
                }
                else
                {
                    return "";
                }
            }
        }
        public string Relationship1Type
        {
            get
            {
                if (Relationship.Length >= 1)
                {
                    return Relationship[0].Relationship;
                }
                else
                {
                    return "";
                }
            }
        }

        public string Relationship2
        {
            get
            {
                if (Relationship.Length >= 2)
                {
                    return Relationship[1].Name;
                }
                else
                {
                    return "";
                }
            }
        }
        public string Relationship2Type
        {
            get
            {
                if (Relationship.Length >= 2)
                {
                    return Relationship[1].Relationship;
                }
                else
                {
                    return "";
                }
            }
        }

        public string Relationship3
        {
            get
            {
                if (Relationship.Length >= 3)
                {
                    return Relationship[2].Name;
                }
                else
                {
                    return "";
                }
            }
        }
        public string Relationship3Type
        {
            get
            {
                if (Relationship.Length >= 3)
                {
                    return Relationship[2].Relationship;
                }
                else
                {
                    return "";
                }
            }
        }
    }
}