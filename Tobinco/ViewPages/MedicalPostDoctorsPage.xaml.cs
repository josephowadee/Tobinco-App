using System;
using System.Collections.Generic;
using System.Linq;
using Tobinco.Model;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace Tobinco.ViewPages
{
    public partial class MedicalPostDoctorsPage : ContentPage
    {
        public MedicalPostDoctorsPage(string hospitalName)
        {
            InitializeComponent();
        }
        private async void BackButton(object sender, EventArgs e)
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
                //await Navigation.ShowPopupAsync(new ConfrimMedicalRequest(doctorList.DoctorID, doctorList.DoctorImage, doctorList.DoctorTel, doctorList.DoctorTitle, doctorList.FirstName, doctorList.LastName));
            }
        }
    }
}
