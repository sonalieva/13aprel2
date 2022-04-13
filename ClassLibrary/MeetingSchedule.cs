using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MeetingSchedule
    {
         public List<Meeting> Meetings = new List<Meeting>();

        public void SetMeeting(string fullname, DateTime from, DateTime to)
        {
            if (!Meetings.Exists(x => (x.ToDate > x.FromDate) && (x.FromDate < from || x.FromDate < to) ))
            {
                Meetings.Add(new Meeting());
            }
            else
            {
                throw new Exception("Bu vaxt uygun deyil");
            }
        }
        public int FindMeetingsCount(DateTime date)
        {
            return Meetings.FindAll(x => x.FromDate > date).Count;
        }
        public bool IsExistsMeetingByName(string name)
        {
            if( Meetings.Exists(x => x.Name == name)) 
            {
                return true;
            }
            return false;
        }
        public List<Meeting> GetExistMeetings(string name)
        {
            return Meetings.FindAll(x => x.Name.Contains(name));
        }
    }
}
