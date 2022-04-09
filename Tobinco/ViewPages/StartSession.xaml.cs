using System;
using System.Collections.Generic;
using System.Linq;
using Tobinco.Model;
using Xamarin.Forms;

namespace Tobinco.ViewPages
{
    public partial class StartSession : ContentPage
    {
        public StartSession()
        {
            InitializeComponent();
        }
        private void BackButton(object sender, EventArgs e)
        {

        }

        async void hospitalSelected(object sender, SelectionChangedEventArgs e)
        {
            var hospitalList = e.CurrentSelection.FirstOrDefault() as HospitalListModel;
            if (hospitalList == null)
               return;
            
               await Navigation.PushAsync(new StartSessionDoctors(hospitalList.HospitalName));

            ((CollectionView)sender).SelectedItem = null;
        
        }
    }
}
