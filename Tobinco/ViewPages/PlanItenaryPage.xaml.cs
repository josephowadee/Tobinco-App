using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Tobinco.DatabbaseServices;
using Tobinco.Model;
using Tobinco.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.PancakeView;

namespace Tobinco.ViewPages
{
    public partial class PlanItenaryPage : ContentPage
    {
        public string timerSelected { get; set; }
        public string timeHours { get; set; }
        public string timeminutes { get; set; }
        public string timeseconds { get; set; }
        public string HospitalName { get; set; }
        public string DoctorFirstname { get; set; }
        public string DocLastname { get; set; }
        public string DoctorTel { get; set; }
        public string DoctorTitle { get; set; }
        public string scheduleDate { get; set; }
        public string dateDayYear { get; set; }

        public PlanItenaryPage()
        {
            InitializeComponent();
            BindingContext = new ScheduleEventsViewModel();
        }

        void CollectTimeChange(object sender, SelectionChangedEventArgs e)
        {
            var timeSelected = e.CurrentSelection.FirstOrDefault() as ScheduleTimeModel;
            if (timeSelected == null)
                return;

            var cultureInfo = new CultureInfo("de-DE");
            string timeFormat = timeSelected.DateTimeItems;


            var TimeSchdule =  DateTime.Parse(timeFormat, cultureInfo);

            timeHours = TimeSchdule.Hour.ToString();
            timeminutes = TimeSchdule.Minute.ToString();
            timeseconds = TimeSchdule.Second.ToString();
            /////
        }
        
        void schduleHospitalClicked(object sender, SelectionChangedEventArgs e)
        {
            var hospitalList = e.CurrentSelection.FirstOrDefault() as HospitalListModel;
            if (hospitalList == null)
                return;
            HospitalName = hospitalList.HospitalName;


        }
        void DoctorListClicked(object sender, SelectionChangedEventArgs e)
        {
            var doctorsLists = e.CurrentSelection.FirstOrDefault() as DoctorListModel;
            if (doctorsLists == null)
                return;
            DoctorFirstname = doctorsLists.FirstName;
            DocLastname = doctorsLists.LastName;
            DoctorTitle = doctorsLists.DoctorTitle;
        }
        async void UserAddSchedule(object sender, EventArgs e)
        {
            dateDayYear = DayYear.Text;
            // await DisplayAlert("Select ", $"{timerSelected}", "OK");

            var cultureInfo = new CultureInfo("de-DE");

            string dateFormat = scheduleDate + dateDayYear;

            var schduleDate = DateTime.Parse(dateFormat, cultureInfo);

            //await DisplayAlert("Date Parse method", $"{timerSelected}", "OHK");

            try
            {
                await ScheduleDatabase.AddSchedule(new ScheduleModel
                {
                    HospitalName = HospitalName,
                    DoctorFirstName = DoctorFirstname,
                    DoctorLastName = DocLastname,
                    DocTitle = DoctorTitle,
                    TimeHours =timeHours,
                    TimeMinutes = timeminutes,
                    TimeSeconds = timeseconds,
                    Time = timerSelected,
                    ScheduleDate = schduleDate.ToShortDateString(),
                    dateTime = DateTime.Now.ToString()
                });
                await Navigation.PushAsync(new MainShellPage());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Schedule Insertion Error", $"{ex}", "OK");
            }
        }

        void DateSeleted(object sender, SelectionChangedEventArgs e)
        {
            var dateLits = e.CurrentSelection.FirstOrDefault() as TimerModel;
            if (dateLits == null)
                return;
            scheduleDate = dateLits.Date.ToString();
        }
    }
}
