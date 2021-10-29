using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MissGuided.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPageBlank : ContentPage
    {
        public CartPageBlank()
        {
            InitializeComponent();
        }


        private void fillmeup_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ShopPage());
        }
    }
}