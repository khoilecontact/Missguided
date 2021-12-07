using MissGuided.Models;
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
    public partial class ChangeCountryPage : ContentPage
    {
        public ChangeCountryPage()
        {
            InitializeComponent();
        }
        List<Country> Countries = new List<Country>();
        public void InitCountriesLst()
        {
            Countries.Add(new Country
            {
                Img = "us_flag.png",
                countryName = "United State"
            });
            Countries.Add(new Country
            {
                Img = "uk_flag.png",
                countryName = "UK & International"
            });
        }
    }
}