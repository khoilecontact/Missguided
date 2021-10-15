using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MissGuided.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            //ToolbarItems.Add(new ToolbarItem("Cart","shopping_bag.png", () =>
            //{
            //    Navigation.PushAsync(new CartPage());
            //}));
        }

        void cart_clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CartPage());
        }

        string[] listBanner = new string[]
        {
            "https://media.missguided.com/i/missguided/Cold_Weather_UK_12_10_mobile.webp?w=767&qlt=70",
            "https://media.missguided.com/i/missguided/Party_UK_13_10_mobile.webp?w=767&qlt=70",
        };
    }
}
