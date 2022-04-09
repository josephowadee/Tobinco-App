using System;
using SQLite;

namespace Tobinco.Model
{
    public class StartSessionModel
    {
        [PrimaryKey, AutoIncrement]
        public int startID { get; set; }
        public string DoctorID { get; set; }
        public string DocTitle { get; set; }
        public string doctorLName { get; set; }
        public string doctorFName { get; set; }
        public string DoctorTel { get; set; }
        public string HospitalName { get; set; }
        public DateTime StartTime { get; set; }
        public string DateStamp { get; set; }

    }
}
