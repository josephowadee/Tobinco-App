using System;
using Tobinco.ViewPages;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Tobinco
{
    public class TobincoSplash : ContentPage
    {
        Image SplashImage;
        public TobincoSplash()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            //internet connectivity checker


            var sub = new AbsoluteLayout();
            SplashImage = new Image
            {
                Source = "ic_launcher_round.jpeg",
                WidthRequest = 100,
                HeightRequest = 100,
            };
            AbsoluteLayout.SetLayoutFlags(SplashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(SplashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(SplashImage);
            this.BackgroundColor = Color.FromHex("#FFFFFF");
            this.Content = sub;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await SplashImage.ScaleTo(1, 2500, Easing.Linear);
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                Application.Current.MainPage = new NavigationPage(new UserLoginPage());
            }
            else
            {
                await DisplayAlert("No Internet", "No Internet Connectivity", "OK");
            }
        }
    }
}
