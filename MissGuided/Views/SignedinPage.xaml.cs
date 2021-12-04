using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MissGuided.Views;
using MissGuided.Models;

namespace MissGuided.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignedinPage : ContentPage
    {
        public SignedinPage(User user)
        {
            InitializeComponent();
            lblwelcome.Text = "welcome " + user.firstName;
            NavigationPage.SetHasBackButton(this, false);
        }
        private void Cart_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CartPage());
        }
        private void LOGOUT_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MePage());
        }

        private void MyAccountBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void AddressBookBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void OrderHistoryBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ShippingBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void SizeGuideBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ContactUsBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void FAQBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void TermsandConditionsBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void ChangeCountryBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}