using System;
using System.Collections.Generic;
using MissGuided.ViewModels;
using MissGuided.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MissGuided
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Preferences.Remove("DeliveryPrice");
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(ShopPage), typeof(ShopPage));
            Routing.RegisterRoute(nameof(SwipePage), typeof(SwipePage));
            Routing.RegisterRoute(nameof(WishlistPage), typeof(WishlistPage));
            Routing.RegisterRoute(nameof(MePage), typeof(MePage));
        }
    }
}
