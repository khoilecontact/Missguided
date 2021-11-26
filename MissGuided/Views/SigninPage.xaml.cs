using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using MissGuided.Services;

namespace MissGuided.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SigninPage : ContentPage
    {
        public SigninPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            string email = lbl_email.Text;
            string password = lbl_password.Text;

            bool result = await APICaller.shared.Login(email, password);

            if (result)
            {
                var userId = Preferences.Get("userEmail", string.Empty);
                await DisplayAlert("Logged In", userId, "OK");
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Sai cmnr", "Sai cmn rồi", "Bó tay");
            }
           
        }
    }
}