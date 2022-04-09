using System;
using System.Collections.Generic;
using System.ComponentModel;
using Tobinco.DatabbaseServices;
using Xamarin.Forms;

namespace Tobinco.ViewPages
{
    [DesignTimeVisible(false)]
    public partial class ViewSchedulesPage : ContentPage
    {
        public ViewSchedulesPage()
        {
            InitializeComponent();
            Setup();
        }
        
    
        private List<Event> AllEvents { get; set; }

        private List<Event> GetEvents()
        {
            return new List<Event>()
            {
                new Event{ EventTitle = "Korle-bu Teahing Hospital", BgColor = "#EB9999", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(12, 23, 45, 59).Ticks)},
                new Event{ EventTitle = "37 Millitary Hospital", BgColor = "#96338F", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(20, 1, 22, 10).Ticks)},
                new Event{ EventTitle = "Ridge Hospital", BgColor = "#8251AE", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(48, 11, 15, 0).Ticks)},
                new Event{ EventTitle = "Tema General Hospital", BgColor = "#6787FF", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(2, 17, 29, 45).Ticks)},
            };
        }

        private async void Setup()
        {
            //AllEvents = await ScheduleDatabase.GetAlSchedule();
            eventList.ItemsSource = await ScheduleDatabase.GetAlSchedule();

          // Device.StartTimer(new TimeSpan(0, 0, 1), () =>
           //{
           //    foreach (var evt in AllEvents)
           //    {
             //       var timespan = evt.Date - DateTime.Now;
             //       evt.Timespan = timespan;
             //  }

             //   eventList.ItemsSource = null;
               // eventList.ItemsSource = await ScheduleDatabase.GetAlSchedule();

             //  return true;
          // });
        }
    }

        public class Event
        {
            public DateTime Date { get; set; }
            public string EventTitle { get; set; }
            public string HospitalName { get; set; }
            public string DocTitle { get; set; }
            public string DoctorFirstName { get; set; }
            public string DoctorLastName { get; set; }
            public TimeSpan Timespan { get; set; }
            public string Days => Timespan.Days.ToString("00");
            public string Hours => Timespan.Hours.ToString("00");
            public string Minutes => Timespan.Minutes.ToString("00");
            public string Seconds => Timespan.Seconds.ToString("00");
            public string BgColor { get; set; }
        }
}

