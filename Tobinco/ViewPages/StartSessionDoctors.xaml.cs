using System;
using System.Collections.Generic;
using System.Linq;
using Tobinco.Model;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Tobinco.ViewPages
{
    public partial class StartSessionDoctors : ContentPage
    {
        private string phoneNumber { get; set; }
        private string hospitalname { get; set; }
        public StartSessionDoctors(string HospitalName)
        {
            InitializeComponent();
           // CallDoctorNumber.Text = phoneNumber;
            HospitalNamePass.Text = HospitalName;
            hospitalname = HospitalName;
        }

        private async void CallDoctor(object sender, EventArgs e)
        {
           
            try
            {
               // CallDoctorNumber.Text = phoneNumber;
                Xamarin.Essentials.PhoneDialer.Open(phoneNumber);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error Dailing",$"Please Check the number "+ ex, "OK");
            }

        }
        private async void BackButton(object sender,EventArgs e)
        {

        }

        async void DoctorListClicked(object sender, SelectionChangedEventArgs e)
        {
             var doctorList = e.CurrentSelection.FirstOrDefault() as DoctorListModel;
            if (doctorList == null)
            {
               return;
            }
            else
            {
                await Navigation.PushAsync(new StartSessionConfirm(hospitalname,doctorList.DoctorID, doctorList.DoctorImage, doctorList.DoctorTel, doctorList.DoctorTitle, doctorList.FirstName, doctorList.LastName));
            }
        }
    }
}
