using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Tobinco.Model;
using Xamarin.Forms;

namespace Tobinco.ViewModel
{
    public class StartSessionViewModel : BindableObject
    {
        private ObservableCollection<HospitalListModel> HospitalList;
        private ObservableCollection<DoctorListModel> DoctorList;

        public StartSessionViewModel()
        {
            LoadHospital();
            LoadDoctors();
        }
        public HospitalListModel HospitalSelectedItem { get; set; }
        
        public ObservableCollection<HospitalListModel> hospitalList
        {
            get { return HospitalList; }
            set
            {
                HospitalList = value;
                OnPropertyChanged();
            }
        }

        public DoctorListModel DoctorSelectedItem { get; set; }
        public ObservableCollection<DoctorListModel> doctorList
        {
            get { return DoctorList; }
            set
            {
                DoctorList = value;
                OnPropertyChanged();
            }
        }

        void LoadHospital()
        {
            hospitalList = new ObservableCollection<HospitalListModel>() {
                 new HospitalListModel
                 {
                     HospitalName = "abokobi health center ",
                     BackgroundColor = Color.FromHex("379683"),

                 },
                 new HospitalListModel
                 {
                     HospitalName = "aboraa hospital",
                     BackgroundColor= Color.FromHex("5CDB95"),
                 },
                 new HospitalListModel
                 {
                     HospitalName = "achimota hospital",
                     BackgroundColor = Color.FromHex("8EE4AF"),
                 },
                 new HospitalListModel
                 {
                     HospitalName = "ada health centre",
                     BackgroundColor = Color.FromHex("EDF5E1"),
                 },
                 new HospitalListModel
                 {
                     HospitalName = "adabraka clinic",
                     BackgroundColor = Color.FromHex("FC4445"),
                 },
                 new HospitalListModel
                 {
                     HospitalName = "adabraka polyclinic",
                     BackgroundColor = Color.FromHex("3FEEE6"),

                 },
                 new HospitalListModel
                 {
                     HospitalName = "adenta clinic",
                     BackgroundColor= Color.FromHex("55BCC9"),
                 },
                 new HospitalListModel
                 {
                     HospitalName = "adwoa boatemaa mem. clinick ",
                     BackgroundColor = Color.FromHex("97CAEF"),
                 },
                 new HospitalListModel
                 {
                     HospitalName = "agomeda chps zone",
                     BackgroundColor = Color.FromHex("CAFAFE"),
                 },
                 new HospitalListModel
                 {
                     HospitalName = "airport clinic",
                     BackgroundColor = Color.FromHex("8EE4AF"),
                 }
            };
        }
        void LoadDoctors()
        {
            doctorList = new ObservableCollection<DoctorListModel>() {
                 new DoctorListModel
                 {
                     DoctorID = 42442,
                     DoctorTitle = "Dr.",
                     FirstName = "Bona",
                     LastName = "Baiden",
                     DoctorImage = " ",
                     DoctorTel = 05546557876,

                 },
                 new DoctorListModel
                 {
                     DoctorID = 42442,
                     DoctorTitle = "Dr.",
                     FirstName = "Abigail",
                     LastName = "Nitamoah",
                     DoctorImage = " ",
                     DoctorTel = 02446557876,
                 },
                 new DoctorListModel
                 {
                     DoctorID = 426742,
                     DoctorTitle = "Dr.",
                     FirstName = "Isaac",
                     LastName = "Baodi",
                     DoctorImage = " ",
                     DoctorTel = 05642557876,
                 },
                 new DoctorListModel
                 {
                     DoctorID = 24442,
                     DoctorTitle = "Dr.",
                     FirstName = "Frank",
                     LastName = "Anokye",
                     DoctorImage = " ",
                     DoctorTel = 05046557876,
                 },
                 new DoctorListModel
                 {
                     DoctorID = 424762,
                     DoctorTitle = "Dr.",
                     FirstName = "Joseph",
                     LastName = "Dapaah",
                     DoctorImage = " ",
                     DoctorTel = 05546534876,
                 }
            };
        }
    }
}
