using System;
using System.Collections.Generic;
using Xamarin.Forms;

using Xamarin.Forms.Xaml;
using MissGuided.Models;
using MissGuided.Services;
using MissGuided.Views;
using System.Threading.Tasks;
using System.Linq;
using MissGuided.Views.CheckoutFormPages;
using Xamarin.Essentials;

namespace MissGuided.Views
{
    public partial class CheckouPage : ContentPage
    {
        public CheckouPage()
        {
            InitializeComponent();
            ItemsAddedAsync();
        }

        async void ItemsAddedAsync()
        {
            Products getProduct = await CartAPI.shared.FetchCart();
            List<Product> itemsList = getProduct.cart;

            int productCount = itemsList.Count();
            //lbl_ammount_items.Text = productCount.ToString();

            if (itemsList != null)
            {
                lst_products.ItemsSource = itemsList;
            }
            else
            {
                await Navigation.PushAsync(new CartPageBlank());
            }

            List<checkoutButton> buttons = new List<checkoutButton>();
            buttons.Add(new checkoutButton("1", "delivery", "add delivery address"));
            buttons.Add(new checkoutButton("2", "delivery options", "add delivery options"));
            buttons.Add(new checkoutButton("3", "payment & billing", "add payment &amp; billing"));

            lst_btn.ItemsSource = buttons;

            double total = 0;
            foreach (Product product in itemsList)
            {
                string strPrice = product.salePrice.Remove(product.salePrice.Length - 1);
                total += double.Parse(strPrice);
            }
            double totalEnd = total % 100;
            total = (int)(total / 100);

            string strTotalMoney = total.ToString() + "," + totalEnd.ToString() + "€";

            string deliveryPrice = Preferences.Get("DeliveryPrice", "0,00€");

            if (deliveryPrice != "0,00€")
            {
                strTotalMoney = total.ToString() + "," + totalEnd.ToString() + "0€";
                total = addTwoEuroMoney(strTotalMoney, deliveryPrice);

                totalEnd = total % 1;
                total = (int)(total / 1);

                strTotalMoney = total.ToString() + "," + totalEnd.ToString() + "€";
            }

            lbl_ammount_items.Text = productCount.ToString() + " Items";
            lbl_money.Text = total.ToString() + "," + totalEnd.ToString() + "€";
            lbl_total_money.Text = strTotalMoney;
        }

        // delivery options
        void lst_btn_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            checkoutButton selectedButton = (checkoutButton)lst_btn.SelectedItem;
            switch (selectedButton.no)
            {
                case "1":
                    Navigation.PushAsync(new Deliveryaddress());
                    break;

                case "2":
                    Navigation.PushAsync(new DeliveryOptions());
                    break;

                case "3":

                    break;
            }
        }

        // pay button clicked
        async void btn_pay_Clicked(System.Object sender, System.EventArgs e)
        {
            Products getProduct = await CartAPI.shared.FetchCart();
            List<Product> itemsList = getProduct.cart;
            bool result = true;
            
            foreach (Product product in itemsList)
            {
                // Add to ordered of user
                bool addResult = await APICaller.shared.AddToOrderd(product._id);

                if (addResult)
                {
                    // Remove from cart
                    bool removeResult = await CartAPI.shared.RemoveFromCart(product._id);
                    if (removeResult == false)
                    {
                        await DisplayAlert("Failed in remove", "Please try again later", "OK");
                        result = false;
                    } 
                } else
                {
                    await DisplayAlert("Failed in add", "Please try again later", "OK");
                    result = false;
                }

            }

            if (result)
            {
                await Navigation.PopToRootAsync();
            } else
            {
                await DisplayAlert("Failed", "Please try again later", "OK");
            }
        }

        double addTwoEuroMoney(string num1, string num2)
        {
            num1 = num1.Remove(num1.Length - 1);
            num2 = num2.Remove(num2.Length - 1);

            double dbNum1 = double.Parse(num1);
            double dbNum2 = double.Parse(num2);

            dbNum1 = dbNum1 / 100;
            dbNum2 = dbNum2 / 100;

            return dbNum1 + dbNum2;
        }
    }
}

public class checkoutButton {
    public string no { get; set; }
    public string title { get; set; }
    public string subtitle { get; set; }

    public checkoutButton(string no, string title, string subtitle)
    {
        this.no = no;
        this.title = title;
        this.subtitle = subtitle;
    }
}

