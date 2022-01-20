using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaration.EntityFramework.Entity
{
    public class SendMailLog
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Recepient { get; set; }
        public string RecepientCC { get; set; }
        public string RecepientBCC { get; set; }
        public DateTime SentDate { get; set; }
        public string BodyContent { get; set; }
    }
}
