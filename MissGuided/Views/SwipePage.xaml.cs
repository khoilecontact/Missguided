using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MissGuided.Models;
using MLToolkit.Forms.SwipeCardView.Core;
using Xamarin.Forms;

namespace MissGuided.Views
{
    public partial class SwipePage : ContentPage
    {
        public ObservableCollection<Product> _Products = new ObservableCollection<Product>();

        public SwipePage()
        {
            InitializeComponent();
            CardBinding();
            SwipeView.ItemsSource = _Products;
            BindingContext = this;

        }

        public void CardBinding()
        {
            _Products.Add(new Product()
            {
                name = "Phat",
                price = "$30",
                salePrice = "$10",
                categories = new String[2] { "pant", "lower body" },
                description = "Description",
                sizes = new String[2] { "15", "20" },
                images = new string[1] { "app_logo.jpg" }
            });

            _Products.Add(new Product()
            {
                name = "Ngu",
                price = "$20",
                salePrice = "$9",
                categories = new String[2] { "pant", "lower body" },
                description = "Description",
                sizes = new String[2] { "15", "20" },
                images = new string[1] { "app_logo.jpg" }
            });

            _Products.Add(new Product()
            {
                name = "Khoi Ng",
                price = "$10",
                salePrice = "$5",
                categories = new String[2] { "pant", "lower body" },
                description = "Description",
                sizes = new String[2] { "15", "20" },
                images = new string[1] { "app_logo.jpg" }
            });

            _Products.Add(new Product()
            {
                name = "Phat",
                price = "$30",
                salePrice = "$10",
                categories = new String[2] { "pant", "lower body" },
                description = "Description",
                sizes = new String[2] { "15", "20" },
                images = new string[1] { "app_logo.jpg" }
            });

            _Products.Add(new Product()
            {
                name = "Ngu",
                price = "$20",
                salePrice = "$9",
                categories = new String[2] { "pant", "lower body" },
                description = "Description",
                sizes = new String[2] { "15", "20" },
                images = new string[1] { "app_logo.jpg" }
            });

            _Products.Add(new Product()
            {
                name = "Khoi Ng",
                price = "$10",
                salePrice = "$5",
                categories = new String[2] { "pant", "lower body" },
                description = "Description",
                sizes = new String[2] { "15", "20" },
                images = new string[1] { "app_logo.jpg" }
            });
        }

        public ObservableCollection<Product> Product
        {
            get => _Products;
            set
            {
                _Products = value;
            }
        }

        void OnSwiped(object sender, SwipedCardEventArgs e)
        {
            switch (e.Direction)
            {
                case SwipeCardDirection.Right:
                    lbl_name.Text = "Right";
                    break;
                case SwipeCardDirection.Left:
                    lbl_name.Text = "Left";
                    break;
            }
        }


    }
}
