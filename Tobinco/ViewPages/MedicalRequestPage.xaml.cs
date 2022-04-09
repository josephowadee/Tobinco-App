using System;
using System.Collections.Generic;
using System.Linq;
using Tobinco.Model;
using Tobinco.ViewModel;
using Xamarin.Forms;

namespace Tobinco.ViewPages
{
    public partial class MedicalRequestPage : ContentPage
    {
        public string itemImage { get; set; }
        public string itemTitle { get; set; }
        public string itemDiscount { get; set; }
        public string itemDiscription { get; set; }
        public string itemPrice { get; set; }
        public string itemQuantity { get; set; }



        public MedicalRequestPage()
        {
            InitializeComponent();
            //BindingContext = new MedicalRequestViewModel();
         
        }
        private async void BackButton(object sender, EventArgs e)
        {

        }
       
        async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            itemImage = string.Empty;
            itemTitle = string.Empty;
            itemDiscount = string.Empty;
            itemDiscription = string.Empty;
            itemPrice = string.Empty;
            itemQuantity = string.Empty;

             var productList = e.CurrentSelection;
            for (int i = 0; i< productList.Count; i++)
            {
                var request = productList[i] as MedialSuppliesModel;
                itemImage = request.ItemImage;
                itemTitle = request.ItemTitle;
                itemDiscount = request.ItemDiscount.ToString();
                itemDiscription = request.ItemDiscription;
                itemPrice = request.ItemPrice.ToString();
                itemQuantity = request.ItemQuantity.ToString();
            }
           // await DisplayAlert("Selected Items", $"{itemImage + " " + itemTitle + " " + itemDiscount + " " + itemDiscription}", "OHK");
        }
        private async void PostBill(object sender, EventArgs e)
        {
           // await DisplayAlert("Selected Items", $"{itemImage + " " + itemTitle + " " + itemDiscount + " " + itemDiscription}", "OHK");
            await Navigation.PushAsync(new MedicalPostBillPage());
        }
    }
}

