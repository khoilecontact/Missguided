using System;
using System.Collections.Generic;
using System.Linq;
using MissGuided.Models.CheckoutInfo;
using MissGuided.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MissGuided.Views.CheckoutFormPages
{
    public partial class DeliveryOptions : ContentPage
    {
        public DeliveryOptions()
        {
            InitializeComponent();
            initView();
        }

        void initView()
        {
            Database db = new Database();
            List<DeliveryOption> deliveryOptions = db.getDeliveryOptions();

            if (deliveryOptions.Count() == 0)
            {
                createData();
            }

            deliveryOptions = db.getDeliveryOptions();

            lst_option.ItemsSource = deliveryOptions;
        }

        void createData()
        {
            Database db = new Database();
            DeliveryOption option1 = new DeliveryOption();
            option1.name = "USA Standard Delivery";
            option1.price = "8,00€";

            DeliveryOption option2 = new DeliveryOption();
            option2.name = "USA Express Delivery";
            option2.price = "12,00€";

            bool re1 = db.addNewDeliveryOptions(option1);
            bool re2 = db.addNewDeliveryOptions(option2);
        }

        void lst_option_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            DeliveryOption option = (DeliveryOption)lst_option.SelectedItem;
            Preferences.Set("DeliveryPrice", option.price);
            Navigation.PopAsync();
        }
    }
}
