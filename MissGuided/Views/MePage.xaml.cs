using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
//Sfbutton
using Syncfusion.XForms.Buttons;
using MissGuided.Models;
using System.Linq;
using MissGuided.Views.TextPages;

namespace MissGuided.Views
{
    public partial class MePage : ContentPage
    {
        public MePage()
        {
            if (Preferences.Get("user", "") != "")
            {
                Navigation.PushAsync(new SignedinPage());
            }
            else
            {
                InitializeComponent();
                Img.Source = "https://media.missguided.com/i/missguided/VX1788335_01?fmt=jpeg&fmt.jpeg.interlaced=true&$product-page__main--1x$";
            }
        }
     
        void cart_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CartPage());
        }

        private void Signin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SigninPage());
        }

        private void Register_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        private void faq_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FAQPage());
        }
        private void changecountry_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChangeCountryPage());
        }

        private void termandcondition_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TermOfUsePage());
        }

        private void privalcypolicy_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrivacyPolicyPage());
        }
    }
}
