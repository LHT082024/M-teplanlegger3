using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Møteplanlegger3.classes
{
    public class MeetingClass
    {
        public string? MeetingTitle { get; set; }
        public int Date { get; set; }
        public string? Time { get; set; }
        public string? Place { get; set; }

        public string? PeopleAtMeeting { get; set; }
    }
}