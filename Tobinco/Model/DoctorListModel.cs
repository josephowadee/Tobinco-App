using System;
namespace Tobinco.Model
{
    public class DoctorListModel
    {
        public int DoctorID { get; set; }
        public string DoctorImage { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long DoctorTel { get; set; }
        public string DoctorTitle { get; set; }


        public DoctorListModel()
        {
        }
    }
}
