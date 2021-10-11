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

    }
}
