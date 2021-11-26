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
    public partial class SignedinPage : ContentPage
    {
        public SignedinPage()
        {
            InitializeComponent();
        }

        private void Cart_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CartPage());
        }

        private void LOGOUT_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MePage());
        }
    }
}