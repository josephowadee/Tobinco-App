using System;
using System.Collections.Generic;
using Tobinco.DatabbaseServices;
using Tobinco.Model;
using Xamarin.Forms;

namespace Tobinco.ViewPages
{
    public partial class UserLoginPage : ContentPage
    {
        public UserLoginPage()
        {
            InitializeComponent();
        }
        private async void LoginClick(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(UserSignMail.Text))
            {
                await DisplayAlert("Empty Field", $"Empty First Name Box", "OK");
            }
            else if (string.IsNullOrEmpty(UserSignPassword.Text))
            {
                await DisplayAlert("Empty Field", $"Empty Last Name Box", "OK");
            }
            else
            {
                try
                {
                    var UserSignIn = await UserDatabbaseServices.UsersSignAccount(UserSignMail.Text,  UserSignPassword.Text);
                    if(UserSignIn.Count == 1)
                    {
                        await Navigation.PushAsync(new MainShellPage());

                        UserSignMail.Text = string.Empty;
                        UserSignPassword.Text = string.Empty;
                    }
                    else
                    {
                        await DisplayAlert("SignIn Error", $"Wrong User Email or Password", "OK");
                    }

                }
                catch (Exception ex)
                {
                    await DisplayAlert("SignIn Error", $"{ex}", "OK");
                }
            }

        }
        private async void forgetPassword(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserForgetPassword());
        }
        private async void UserSignUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserSignUpPage());
        }
    }
}
