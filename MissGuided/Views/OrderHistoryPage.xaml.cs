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
    public partial class OrderHistoryPage : ContentPage
    {
        public OrderHistoryPage()
        {
            InitializeComponent();
            InitListView();
        }
        async Task InitListView()
        {
            List<Product> itemLst = await APICaller.shared.GetOrdered();
            orderedLst.ItemsSource = itemLst;
        }
    }
}