using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MissGuided.Services;
using MissGuided.Models;

namespace MissGuided.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        User user;
        public RegisterPage()
        {
            InitializeComponent();
            user = new User();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            user.firstName = lbl_firstName.Text;
            user.lastName = lbl_lastName.Text;
            user.email = lbl_email.Text;
            user.password = lbl_password.Text;
            bool result = await APICaller.shared.Register(user.firstName, user.lastName, user.email, user.password);

            if (result)
            {
                await DisplayAlert("Registered In", "Vô rồi", "OK");
                await Navigation.PushAsync(new SignedinPage(user));
            }
            else
            {
                await DisplayAlert("Sai cmnr", "Sai cmn rồi", "Bó tay");
            }
        }

    }
}