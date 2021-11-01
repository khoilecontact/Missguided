using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MissGuided.Services;

namespace MissGuided.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            string firstName = lbl_firstName.Text;
            string lastName = lbl_lastName.Text;
            string email = lbl_email.Text;
            string password = lbl_password.Text;

            bool result = await APICaller.shared.Register(firstName, lastName, email, password);

            if (result)
            {
                DisplayAlert("Registered In", "Vô rồi", "OK");
            }
            else
            {
                DisplayAlert("Sai cmnr", "Sai cmn rồi", "Bó tay");
            }
        }

    }
}