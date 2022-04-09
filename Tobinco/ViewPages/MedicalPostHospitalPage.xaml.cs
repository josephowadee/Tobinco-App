using System;
using System.Collections.Generic;
using System.Linq;
using Tobinco.Model;
using Xamarin.Forms;

namespace Tobinco.ViewPages
{
    public partial class MedicalPostHospitalPage : ContentPage
    {
        public MedicalPostHospitalPage()
        {
            InitializeComponent();
        }
        private async void BackButton(object sender, EventArgs e)
        {

        }
       
        async void MedicalHospitalSelect(object sender, SelectionChangedEventArgs e)
        {
            var hospitalList = e.CurrentSelection.FirstOrDefault() as HospitalListModel;
            if (hospitalList == null)
                return;

            await Navigation.PushAsync(new MedicalPostDoctorsPage(hospitalList.HospitalName));

            ((CollectionView)sender).SelectedItem = null;
        }
    }
}
