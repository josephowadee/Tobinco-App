using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Tobinco.ViewPages
{
    public partial class UserForgetPassword : ContentPage
    {
        public UserForgetPassword()
        {
            InitializeComponent();
        }
        private async void PasswordReset(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainShellPage());
        }
    }
}
