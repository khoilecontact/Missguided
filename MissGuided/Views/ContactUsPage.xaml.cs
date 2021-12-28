using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MissGuided.Views.Community;

namespace MissGuided.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContacUsPage : ContentPage
    {
        public ContacUsPage()
        {
            InitializeComponent();
        }

        private void facebook_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FacebookPage());
        }

        private void twitter_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TwitterPage());
        }
    }
}