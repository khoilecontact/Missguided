using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MissGuided.Models;
using MLToolkit.Forms.SwipeCardView.Core;
using Xamarin.Forms;

namespace MissGuided.Views
{
    public partial class SwipePage : ContentPage
    {
        public List<Product> _Products = new List<Product>();
        int noProduct = 1;

        public SwipePage()
        {
            InitializeComponent();
            CardBindingAsync();
        }

        async void CardBindingAsync()
        {
            _Products = await APICaller.shared.FetchProductsSwipe(1);

            SwipeView.ItemsSource = _Products;
            BindingContext = this;

            var item = (Product)SwipeView.TopItem;
            lbl_name.Text = item.name;
            lbl_price.Text = item.price;
            lbl_sale_price.Text = item.salePrice;
        }

        public List<Product> Product
        {
            get => _Products;
            set
            {
                _Products = value;
            }
        }

        async void OnSwiped(object sender, SwipedCardEventArgs e)
        {
            noProduct++;
            if (noProduct % 20 == 0)
            {
                int page = noProduct / 20 + 1;

                _Products = await APICaller.shared.FetchProductsSwipe(page);

                SwipeView.ItemsSource = _Products;
            }

            var item = (Product)SwipeView.TopItem;
            lbl_name.Text = item.name;
            lbl_price.Text = item.price;
            lbl_sale_price.Text = item.salePrice;


            switch (e.Direction)
            {
                case SwipeCardDirection.Right:
                    break;
                case SwipeCardDirection.Left:
                    break;
            }
        }


    }
}