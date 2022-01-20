using Declaration.BusinessLogic.Class;
using Declaration.BusinessLogic.Manager;
using Declaration.EntityFramework.Entity;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Declaration.BusinessLogic.Helpers
{
    public static class DeclarationFormHelpers
    {
        public static DateTime ToBatamTime(this DateTime date)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(date, TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"));
        }


        public static LabelModel GetLabel(DeclarationTypeEnum declarationType, bool useDefault = false)
        {
            string lang = "en";
            if (useDefault == false)
            {
                lang = new LanguageManager().GetCurrentLanguage();
            }

            switch (declarationType)
            {
                case DeclarationTypeEnum.TravelDeclaration:
                    return new LabelModel()
                    {
                        BadgeId = GetByLanguage("Badge ID", "Nomor karyawan", lang),
                        Name = GetByLanguage("Name", "Nama", lang),
                        Relationship = GetByLanguage("Relationship", "Hubungan", lang),
                        Destination = GetByLanguage("Destination", "Tujuan", lang),
                        StartDate = GetByLanguage("Start date", "Tanggal berangkat", lang),
                        EndDate = GetByLanguage("End date", "Tanggal kembali", lang),
                        Remark = GetByLanguage("Additional information", "Informasi tambahan", lang),
                        TravelerName = GetByLanguage("Traveler Name", "Nama", lang),
                        TravelReason = GetByLanguage("Travel Reason", "Alasan perjalanan", lang)
                    };
                case DeclarationTypeEnum.Event:
                    return new LabelModel()
                    {
                        BadgeId = GetByLanguage("Badge ID", "Nomor Karyawan", lang),
                        Name = GetByLanguage("Name", "Nama", lang),
                        Relationship = GetByLanguage("Relationship", "Hubungan", lang),
                        Destination = GetByLanguage("Purpose", "Tujuan", lang),
                        StartDate = GetByLanguage("Event date (Start)", "Tanggal acara dimulai", lang),
                        EndDate = GetByLanguage("Event date (Finish)", "Tanggal acara selesai", lang),
                        Remark = GetByLanguage("Additional information", "Informasi tambahan", lang),
                        TravelerName = GetByLanguage("Visitor/House member name", "Nama Saudara/Tamu", lang)
                    };
                case DeclarationTypeEnum.MassInvolvement:
                    return new LabelModel()
                    {
                        BadgeId = GetByLanguage("Badge ID", "Nomor karyawan", lang),
                        Name = GetByLanguage("Name", "Nama", lang),
                        Relationship = GetByLanguage("Relationship", "Hubungan", lang),
                        Destination = GetByLanguage("Event name", "Nama acara", lang),
                        StartDate = GetByLanguage("Event date (Start)", "Tanggal acara dimulai", lang),
                        EndDate = GetByLanguage("Event date (Finish)", "Tanggal acara selesai", lang),
                        Remark = GetByLanguage("Additional information", "Informasi tambahan", lang),
                        TravelerName = GetByLanguage("Event organizer name", "Nama penyelenggara acara", lang)
                    };
                default:
                    return null;
            }
        }


        private static string GetByLanguage(string english, string indo, string lang)
        {
            if (lang == "en")
            {
                return english;
            }
            else
            {
                return indo;
            }
        }


        public static string GetRelationshipTable(IEnumerable<Relationship> relationships , LabelModel labelModel)
        {
            string body = "<tr>";

            foreach (var item in relationships)
            {
                body += "<tr>";
                body += "<td style='width: 151.646px;padding:5px 10px;'>" + labelModel.TravelerName + "</td>";
                body += "<td style='width: 360.354px;padding:5px 10px;'>" + item.Name + " - " + item.RelationshipType + "</td>";
                body += "</tr>";
            }

            body += "</tr>";

            return body;
        }

        public static string GetTravelReasonTable(string TravelReason, LabelModel labelModel)
        {
            string body = "<tr>";

            body += "<tr>";
            body += "<td style='width: 151.646px;padding:5px 10px;'>" + labelModel.TravelReason + "</td>";
            body += "<td style='width: 360.354px;padding:5px 10px;'>" + TravelReason + "</td>";
            body += "</tr>";

            body += "</tr>";

            return body;
        }
    }

    public class LabelModel
    {
        public string BadgeId { get; set; }
        public string Name { get; set; }
        public string Relationship { get; set; }
        public string TravelerName { get; set; }
        public string Destination { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string TravelReason { get; set; }
        public string Remark { get; set; }

    }
}
