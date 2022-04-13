using ClassLibrary;
using System;

namespace _13aprel
{
    class Program
    {
        static void Main(string[] args)
        {
            Meeting meeting1 = new Meeting();
            meeting1.Name = "smth1";
            meeting1.FromDate = new DateTime(2022, 3, 28, 8, 12, 0);
            meeting1.ToDate = new DateTime(2022, 4, 8, 11, 5, 0);

            Meeting meeting2 = new Meeting();
            meeting2.Name = "smth2";
            meeting2.FromDate = new DateTime(2022, 3, 28, 8, 12, 0);
            meeting2.ToDate = new DateTime(2022, 4, 8, 11, 5, 0);

            MeetingSchedule meetingSchedule = new MeetingSchedule();
            meetingSchedule.Meetings.Add(meeting1);
            meetingSchedule.Meetings.Add(meeting2);
            DateTime from = new DateTime(2022, 3, 28, 11, 28, 0);
            DateTime to = new DateTime(2022, 4, 13, 11, 10, 0);
            meetingSchedule.SetMeeting("smth3", from, to);

            
           
            foreach (var item in meetingSchedule.GetExistMeetings("smth"))
            {
                Console.WriteLine(item.Name);
            }


            Console.WriteLine(meetingSchedule.FindMeetingsCount(new DateTime(2022, 4, 12, 10, 28, 5)));
           
            Console.WriteLine(meetingSchedule.IsExistsMeetingByName("smth"));

          
        }
    }
}
