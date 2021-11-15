using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MissGuided.Models;
using MissGuided.Views;
using Xamarin.Forms;

namespace MissGuided.ViewModels
{
    public class ShelveItemsModel : BindableObject
    {

        ShelveItems shelvePage;
        List<Product> listTemp;
        public ShelveItemsModel(ShelveItems shelveItems, List<Product> list)
        {
            this.shelvePage = shelveItems;
            this.listTemp = list;
            AddItems();
        }

        private void AddItems()
        {
            foreach(Product pr in listTemp)
            {
                Products.Add(pr);
            }
        }

        private ObservableCollection<Product> _products = new ObservableCollection<Product>();

        public ObservableCollection<Product> Products
        {
            get
            {
                return _products;
            }
            set
            {
                if (_products != value)
                {
                    _products = value;
                    OnPropertyChanged(nameof(Products));
                }
            }
        }

        public Command ItemTappedCommand
        {
            get
            {
                return new Command((data) =>
                             {
                                 Product dataSelected = (Product)data;
                                 shelvePage.DisplayAlert("FlowListView", dataSelected.name + "", "Ok");
                                 //shelvePage.Navigation.PushAsync(new ItemDetailPage(dataSelected));
                             });
            }
        }

        void FlowListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            shelvePage.DisplayAlert("Haha", "haha", "ok");
        }
    }
}

