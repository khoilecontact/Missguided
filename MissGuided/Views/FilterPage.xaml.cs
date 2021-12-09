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
    public partial class FilterPage : TabbedPage
    {
        List<string> categories = new List<string>();
        List<string> sizes = new List<string>();

        public FilterPage()
        {
            InitializeComponent();
            initListViews();
        }

        void initListViews()
        {
            var template = new DataTemplate(typeof(TextCell));
            template.SetValue(TextCell.TextColorProperty, Color.Black);
            template.SetBinding(TextCell.TextProperty, ".");

            categories.Add("Tops");
            categories.Add("Clothing");
            categories.Add("Coats & Jackets");
            categories.Add("Brands");
            categories.Add("Petite");
            categories.Add("Dresses");
            categories.Add("Lingerie");
            categories.Add("Denim");
            categories.Add("Jeans");
            categories.Add("Sportswear");
            categories.Add("Tall");
            categories.Add("Shoes");
            categories.Add("Plus Size & Curve");
            categories.Add("Accessories");
            categories.Add("Trousers");
            categories.Add("Beauty");
            categories.Add("Knitwear");
            categories.Add("Jewellery");
            lst_category.ItemTemplate = template;
            lst_category.ItemsSource = categories;

            sizes.Add("32");
            sizes.Add("34");
            sizes.Add("36");
            sizes.Add("38");
            sizes.Add("40");
            sizes.Add("42");
            sizes.Add("44");
            sizes.Add("46");
            sizes.Add("48");
            sizes.Add("50");
            sizes.Add("52");
            sizes.Add("54");
            sizes.Add("S");
            sizes.Add("M");
            sizes.Add("L");
            sizes.Add("48R");
            sizes.Add("42S");
            sizes.Add("44S");
            sizes.Add("32R");
            sizes.Add("34R");
            sizes.Add("36R");
            sizes.Add("38R");
            sizes.Add("40R");
            sizes.Add("42R");
            sizes.Add("44R");
            sizes.Add("32L");
            sizes.Add("34L");
            sizes.Add("36L");
            sizes.Add("38L");
            sizes.Add("40L");
            sizes.Add("42L");
            sizes.Add("44L");
            sizes.Add("48S");
            sizes.Add("40S");
            sizes.Add("34S");
            sizes.Add("36S");
            sizes.Add("38S");
            sizes.Add("40S");
            sizes.Add("42S");
            sizes.Add("32L");
            sizes.Add("34L");
            sizes.Add("36L");
            sizes.Add("38L");
            sizes.Add("36/38");
            sizes.Add("40/42");
            sizes.Add("44/46");
            lst_size.ItemTemplate = template;
            lst_size.ItemsSource = sizes;
        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
        }

        async void btn_reset_Clicked(System.Object sender, System.EventArgs e)
        {
            string action = await DisplayActionSheet("Clear Selected Filters", "Cancel", null, "Clear Current View", "Clear All");
        }

        async void btn_reset_2_Clicked(System.Object sender, System.EventArgs e)
        {
            string action = await DisplayActionSheet("Clear Selected Filters", "Cancel", null, "Clear Current View", "Clear All");
        }
    }
}
