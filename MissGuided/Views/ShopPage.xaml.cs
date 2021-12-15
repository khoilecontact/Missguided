using System;
using System.Collections.Generic;
using Syncfusion.XForms.Buttons;
using MissGuided.Views;
using Xamarin.Forms;
using System.Windows.Input;

namespace MissGuided.Views
{
    public partial class ShopPage : ContentPage
    {
        public ShopPage()
        {
            InitializeComponent();
        }
        void cart_clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CartPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MePage());
        }
    }
}
