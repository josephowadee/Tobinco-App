using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Input;
using Tobinco.Model;
using Xamarin.Forms;

namespace Tobinco.ViewModel
{
    public class ScheduleEventsViewModel : BindableObject
    {
        private ObservableCollection<ScheduleTimeModel> scheduleTimeModelContainer;
        private ObservableCollection<HospitalListModel> HospitalList;
        private ObservableCollection<DoctorListModel> DoctorList;

        public ObservableCollection<ScheduleTimeModel> ScheduleTimeModelContainer
        {
            get { return scheduleTimeModelContainer; }
            set
            {
                scheduleTimeModelContainer = value;
                OnPropertyChanged();
            }

        }

        public ScheduleEventsViewModel()
        {
            PreviousMonthCommand = new Command(NewPreviousMonthCommand);
            NextMonthCommand = new Command(NewNextMonthCommand);
            LoadTime();
            LoadHospital();
            LoadDoctors();
            HeaderDateTime = DateTime.UtcNow.ToLocalTime();
            GenerateCalanderTimes(HeaderDateTime);
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

        void LoadTime()
        {
            ScheduleTimeModelContainer = new ObservableCollection<ScheduleTimeModel>
            {
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(1).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(2).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(3).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(4).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(5).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(6).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(7).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(8).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(9).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(10).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(11).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(12).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(13).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(14).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(15).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(16).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(17).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(18).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(19).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(20).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(21).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(22).ToShortTimeString()
                    },
                    new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(23).ToShortTimeString()
                    }
                    ,new ScheduleTimeModel
                    {
                        DateTimeItems  = DateTime.UtcNow.AddHours(24).ToShortTimeString()
                    }
            };
        }

        private ObservableCollection<TimerModel> privateTimeContainer;

        public ObservableCollection<TimerModel> PrivateTimeContainer
        {
            get { return privateTimeContainer; }
            set
            {
                privateTimeContainer = value;
                OnPropertyChanged();
            }

        }



        private ObservableCollection<TimerModel> timeContainer;

        public ObservableCollection<TimerModel> TimeContainer
        {
            get { return timeContainer; }
            set
            {
                timeContainer = value;
                OnPropertyChanged();
            }

        }
       
        private DateTime headerDateTime;
        public DateTime HeaderDateTime
        {
            get { return headerDateTime; }
            set
            {
                headerDateTime = value;
                OnPropertyChanged();
            }
        }

        #region Command
        public ICommand PreviousMonthCommand { get; }
        public ICommand NextMonthCommand { get; }
        #endregion
       
        private void NewNextMonthCommand(object obj)
        {

            HeaderDateTime = HeaderDateTime.AddMonths(1);
            GenerateCalanderTimes(HeaderDateTime);

        }

        private void NewPreviousMonthCommand(object obj)
        {
            HeaderDateTime = HeaderDateTime.AddMonths(-1);
            GenerateCalanderTimes(HeaderDateTime);

        }

       
        internal void GenerateCalanderTimes(DateTime headerDateTime)
        {
            TimeContainer = new ObservableCollection<TimerModel>();

            //get todays date in int

            int gettodaydate = HeaderDateTime.Day;

            //Get total no of days in a month in int

            for (int i = 1; i <= DateTime.DaysInMonth(HeaderDateTime.Year, HeaderDateTime.Month); i++)
            {
                DateTime dt = new DateTime(HeaderDateTime.Year, HeaderDateTime.Month, i);

                TimerModel timerModel = new TimerModel
                {
                    Day = dt.ToString("ddd"),
                    Date = i,
                    Id = i,
                    Selected = false
                };
                if (gettodaydate == i)
                {
                    timerModel.Selected = true;
                }
                else
                {
                    timerModel.Selected = false;
                }
                TimeContainer.Add(timerModel);

                ///GetSelectedIndex = HeaderDateTime.Day;
            }
        }
    }
}