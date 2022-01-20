using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaration.EntityFramework.Entity
{
    public class ExceptionLog
    {
        public int Id { get; set; }
        public string ExceptionMessage { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string ExceptionStackTrace { get; set; }
        public string UserId { get; set; }
        public DateTime LogTime { get; set; }
    }
}
