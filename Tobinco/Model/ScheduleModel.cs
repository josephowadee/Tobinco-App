using System;
using SQLite;

namespace Tobinco.Model
{
    public class ScheduleModel
    {
        [PrimaryKey, AutoIncrement]
        public int SchedueId { get; set; }
        public string ScheduleDate { get; set; }
        public int Date { get; set; }
        public string HospitalName { get; set; }
        public string DocTitle { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
        public string Time { get; set; }
        public string TimeHours { get; set; }
        public string TimeMinutes { get; set; }
        public string TimeSeconds { get; set; }
        public bool Selected { get; set; }
        public string dateTime { get; set; }
    }
}
