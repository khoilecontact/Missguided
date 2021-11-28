using System;
using System.Collections.Generic;
using MissGuided.Models;
using MissGuided.Services;
using Xamarin.Forms;

namespace MissGuided.Views.CheckoutFormPages
{
    public partial class AddDeliveryAddress : ContentPage
    {
        List<String> cites = new List<string>();
        List<String> countries = new List<string>();

        public AddDeliveryAddress()
        {
            InitializeComponent();
            initView();
        }

        void initView()
        {
            cites.Add("Hồ Chí Minh");
            cites.Add("Hà Nội");
            cites.Add("Bạc Liêu");
            cites.Add("Bảo Lộc");
            cites.Add("Bắc Giang");
            cites.Add("Bắc Kạn");
            cites.Add("Bắc Ninh");
            cites.Add("Bến Tre");
            cites.Add("Biên Hòa");

            pkr_province.ItemsSource = cites;

            countries.Add("Việt Nam");
            countries.Add("Lào");
            countries.Add("Thái Lan");
            countries.Add("Campuchia");
            countries.Add("Myanmar");
            countries.Add("Singapore");

            pkr_country.ItemsSource = countries;
        }

        void btn_save_Clicked(System.Object sender, System.EventArgs e)
        {
            Address address = new Address();
            address.firstName = en_first_name.Text;
            address.lastName = en_last_name.Text;
            address.phone = en_phone.Text;
            address.addressLine1 = en_addr_1.Text;
            address.addressLine2 = en_addr_2.Text;
            address.zipCode = en_zip.Text;
            address.city = en_city.Text;
            address.province = cites[pkr_province.SelectedIndex];
            address.country = cites[pkr_country.SelectedIndex];

            Database db = new Database();
            bool re = db.addNewAddress(address);

            Navigation.PopAsync();
        }
    }
}
