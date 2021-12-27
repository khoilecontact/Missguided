using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using MissGuided.Services;
using MissGuided.Models;

namespace MissGuided.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SigninPage : ContentPage
    {
        User user;
        public SigninPage()
        {
            InitializeComponent();
            user = new User();
        }

        async void signin_Clicked(System.Object sender, System.EventArgs e)
        {
            siginBtn.IsEnabled = false;

            user.email = lblEmail.Text;
            user.password = lblPassword.Text;

            bool result = await APICaller.shared.Login(user.email, user.password);

            if (result)
            {
                User userinfo = await APICaller.shared.GetUserInfo();
                Preferences.Set("user", userinfo.firstName);
                //await DisplayAlert("Thông báo", "Đăng nhập " + userinfo.firstName + " thành công", "OK");
                await Navigation.PushAsync(new SignedinPage(userinfo));
            }
            else
            {
                //await DisplayAlert("Thông báo", "Đăng nhập thất bại", "OK");
            }
        }
    }
}