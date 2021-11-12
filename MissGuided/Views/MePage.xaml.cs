using System;
using System.Collections.Generic;

using Xamarin.Forms;
//Sfbutton
using Syncfusion.XForms.Buttons;
using MissGuided.Models;
using System.Linq;

namespace MissGuided.Views
{
    public partial class MePage : ContentPage
    {
        public MePage()
        {
            InitializeComponent();
            Img.Source = "https://media.missguided.com/i/missguided/VX1788335_01?fmt=jpeg&fmt.jpeg.interlaced=true&$product-page__main--1x$";
        }

        void cart_clicked(object sender, System.EventArgs e)
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
    }
}
