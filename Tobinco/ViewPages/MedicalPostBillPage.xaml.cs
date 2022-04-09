using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tobinco.ViewPages
{
    public partial class MedicalPostBillPage : ContentPage
    {
        public MedicalPostBillPage()
        {
            InitializeComponent();
        }
        private async void BackButton(object sender, EventArgs e)
        {

        }
        public async void PostMedicalBill(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MedicalPostHospitalPage());
        }
    }
}
