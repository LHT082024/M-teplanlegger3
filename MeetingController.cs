using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Møteplanlegger3.classes;

namespace Møteplanlegger3
{
    public class MeetingController
    {
        MeetingClass meetingClass = new MeetingClass();

        public void plannignMeeting()
        {
            Console.WriteLine("what do you wanna call this meeting?");
            string meetingTitle = Console.ReadLine();
            meetingClass.MeetingTitle = meetingTitle;

            Console.WriteLine("What date is the meeting?");
            int.TryParse(Console.ReadLine(), out int date);

            meetingClass.Date = date;

            //time
            Console.WriteLine("What time is the meeting?");
            string time = Console.ReadLine();

            meetingClass.Time = time;

            //take place
            Console.WriteLine("where does the meeting take place?");
            string place = Console.ReadLine();
            meetingClass.Place = place;

            Console.WriteLine("who are going to the meeting");
            string PeopleAtMeeting = Console.ReadLine();
            meetingClass.PeopleAtMeeting = PeopleAtMeeting;
        }

        public void MadeMeeting()
        {
            string finishedMeeting = ($"the date of the meeting is {meetingClass.Date}\nwhat time is the meeting{meetingClass.Time}\nWhere does the meeting take place{meetingClass.Place}\nHow many people at the meeting{meetingClass.PeopleAtMeeting}");
            string filePath = $"Meeting{meetingClass.MeetingTitle}.txt";
            File.WriteAllText(filePath, finishedMeeting);
        }


    }
}