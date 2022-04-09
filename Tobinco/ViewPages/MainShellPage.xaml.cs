using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Tobinco.DatabbaseServices;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Tobinco.ViewPages
{
    public partial class MainShellPage : ContentPage
    {
        CancellationTokenSource cts;
        private double Lang { get; set; }
        private double Long { get; set; }


        public MainShellPage()
        {
            InitializeComponent();
            StartSession();
            UsersFirstName();
        }
        public async void UsersFirstName()
        {
            
            try
            {
                TobincoUserFirstname.ItemsSource = await UserDatabbaseServices.GetUsersAccount();

               
            }
            catch (Exception ex)
            {
                await DisplayAlert("SignIn Error", $"{ex}", "OK");
            }
        }
        public async void StartSession()
        {
            string Date = DateTime.Now.ToString();
            var cultureInfo = new CultureInfo("en-US");

     

            var schduleDate = DateTime.Parse(Date, cultureInfo);

            try
            {
                tobinconStartTime.ItemsSource = await SessionDatabaseService.StartSessionSelect(schduleDate);

                //var cultureInfo = new CultureInfo("de-DE");
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("SignIn Error", $"{ex}", "OK");
            }
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await GetCurrentLocation();
           // ClockInTime();
        }
        protected void MenuIconTapped(object sender, EventArgs e)
        {
            OpenMenu();
        }
        private void OpenMenu()
        {
            MenuGrid.IsVisible = true;

            Action<double> callback = input => MenuView.TranslationX = input;
            MenuView.Animate("anim", callback, -260, 0, 16, 300, Easing.CubicInOut);
        }

        private void CloseMenu()
        {
            Action<double> callback = input => MenuView.TranslationX = input;
            MenuView.Animate("anim", callback, 0, -260, 16, 300, Easing.CubicInOut);

            MenuGrid.IsVisible = false;
        }
        private void OverlayTapped(object sender, EventArgs e)
        {
            CloseMenu();
        }
        private async void SartSesion(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new StartSession());
        }
       // private void ClockInTime()
       // {
         //    Device.StartTimer(TimeSpan.FromSeconds(30), () =>
         //   {
                // Do something
            //    clocktime.Text = DateTime.Now.ToString();
           //     return true; // True = Repeat again, False = Stop the timer
          //  });
        //}
        private async void MedicalTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MedicalRequestPage());
        }
        private async void ScheduleTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewSchedulesPage());
        }
        private async void PlanItenary(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlanItenaryPage());
        }
        private async void CommentsTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CommentsPage());
        }

        async Task GetCurrentLocation()
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                cts = new CancellationTokenSource();
                var location = await Geolocation.GetLocationAsync(request, cts.Token);

                if (location != null)
                {
                    Lang = location.Latitude;
                    Long = location.Longitude;

                    var UserCurrentLoacationn =  ($" {location.Latitude}, {location.Longitude}");
                    ClockLocation.Text = UserCurrentLoacationn;
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
        }
        protected async void OpenNativeMap(object sender, EventArgs e)
        {
            await Map.OpenAsync(Lang, Long, new MapLaunchOptions
            {
                NavigationMode = NavigationMode.Default
            }) ;
        }
        protected override void OnDisappearing()
        {
            if (cts != null && !cts.IsCancellationRequested)
                cts.Cancel();
            base.OnDisappearing();
        }
    }
}