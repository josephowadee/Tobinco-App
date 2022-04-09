using System;
using System.Collections.Generic;
using Tobinco.DatabbaseServices;
using Tobinco.Model;
using Xamarin.Forms;

namespace Tobinco.ViewPages
{
    public partial class UserSignUpPage : ContentPage
    {
        public UserSignUpPage()
        {
            InitializeComponent();
        }
        private async void UserSignIn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserLoginPage());
        }
        private async void UserRegister(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(UserFirstName.Text))
            {
                await DisplayAlert("Empty Field", $"Empty First Name Box", "OK");
            }
            else if (string.IsNullOrEmpty(UserLastName.Text))
            {
                await DisplayAlert("Empty Field", $"Empty Last Name Box", "OK");
            }
            else if (string.IsNullOrEmpty(UserEmail.Text))
            {
                await DisplayAlert("Empty Field", $"Empty Email Address Box", "OK");
            }
            else if (string.IsNullOrEmpty(UserTele.Text))
            {
                await DisplayAlert("Empty Field", $"Empty Telephone Box", "OK");
            }
            else if (string.IsNullOrEmpty(UserAddress.Text))
            {
                await DisplayAlert("Empty Field", $"Empty Address Box", "OK");
            }
            else
            {
                try
                {
                    var timeDate = DateTime.Now;

                    await UserDatabbaseServices.AddUsersAccount(new ToincoUsers
                    {
                        FirstName = UserFirstName.Text,
                        LastName = UserLastName.Text,
                        Email = UserEmail.Text,
                        Address = UserAddress.Text,
                        PhoneNumber = UserTele.Text,
                        DateCreated = timeDate.ToString()
                    });
                    UserFirstName.Text = string.Empty;
                    UserLastName.Text = string.Empty;
                    UserEmail.Text = string.Empty;
                    UserAddress.Text = string.Empty;
                    UserTele.Text = string.Empty;

                    await Navigation.PushAsync(new MainShellPage());
                }
                catch(Exception ex)
                {
                    await DisplayAlert("Data Insertion", $"{ex}", "OK");
                }
            }

            
        }
    }
}
