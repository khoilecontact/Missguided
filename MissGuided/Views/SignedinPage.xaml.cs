using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MissGuided.Views;
using MissGuided.Models;
using MissGuided.Views.TextPages;

namespace MissGuided.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignedinPage : ContentPage
    {
        User user;
        public SignedinPage()
        {
            InitializeComponent();
            lblwelcome.Text = "welcome " + Preferences.Get("user", "");
        }
        public SignedinPage(User user)
        {
            InitializeComponent();
            lblwelcome.Text = "welcome " + Preferences.Get("user", "");
            this.user = user;
        }
        private void Cart_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CartPage());
        }
        private void LOGOUT_Clicked(object sender, EventArgs e)
        {
            Preferences.Remove("user");
            Navigation.PushAsync(new MePage());
        }

        private void MyAccountBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyAccountPage(user));
        }

        private void AddressBookBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddressBookPage());
        }

        private void OrderHistoryBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderHistoryPage());
        }

        private void ShippingBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ShippingTextPage());
        }

        private void SizeGuideBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WhatSizeShouldIOrderPage());
        }

        private void ContactUsBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContacUsPage());
        }

        private void FAQBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FAQPage());
        }

        private void TermsandConditionsBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TermOfUsePage());
        }

        private void ChangeCountryBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChangeCountryPage());
        }
    }
}