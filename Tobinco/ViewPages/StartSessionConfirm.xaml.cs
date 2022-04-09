using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Tobinco.DatabbaseServices;
using Tobinco.Model;
using Xamarin.Forms;

namespace Tobinco.ViewPages
{
    public partial class StartSessionConfirm : ContentPage
    {
        private long DocTelephone { get; set; }
        public string HospitalName { get; set; }
   


        public StartSessionConfirm(string hospitalname,int DoctorId, string DocImageUrl, long DocTel, string DocTitle, string FirstName, string LastName)
        {
            InitializeComponent();
            DoctorIdNum.Text = DoctorId.ToString();
            DTitle.Text = DocTitle;
            DoctorLname.Text = LastName;
            DoctorFname.Text = FirstName;
            DocImage.Source = DocImageUrl;
            DocTelephone =  DocTel;
            HospitalName = hospitalname;
        }
        private async void BackButton(object sender, EventArgs e)
        {
           // await Navigation.PushAsync(new StartSessionDoctors());
        }
        private async void CallDoctor(object sender, EventArgs e)
        {
            try
            {

                Xamarin.Essentials.PhoneDialer.Open(DocTelephone.ToString());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error Dailing", $"Please Check the number " + ex, "OK");
            }

        }
        private void SartSessionTimer(object sender, EventArgs e)
        {
            clocktime.Text = DateTime.Now.ToShortDateString();
        }
        private async void StartSession(object sender, EventArgs e)
        {

            try
            {
                await SessionDatabaseService.AddSession(new StartSessionModel
                {
                    DoctorID = DoctorIdNum.Text,
                    DocTitle = DTitle.Text,
                    doctorLName = DoctorLname.Text,
                    doctorFName = DoctorFname.Text,
                    DoctorTel = DocTelephone.ToString(),
                    HospitalName = HospitalName,
                    StartTime = DateTime.Now,
                    DateStamp = DateTime.Now.ToShortDateString()
                });

                await Navigation.PushAsync(new MainShellPage());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Data Insertion", $"{ex}", "OK");
            }
            // DateTime = DateTime;
            await Navigation.PushAsync(new MainShellPage());

        }
    }
}
