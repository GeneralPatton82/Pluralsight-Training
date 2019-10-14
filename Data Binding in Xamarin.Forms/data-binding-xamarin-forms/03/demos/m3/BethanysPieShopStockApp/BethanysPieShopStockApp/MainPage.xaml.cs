using BethanysPieShopStockApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BethanysPieShopStockApp
{
    public partial class MainPage : ContentPage
    {
        public Pie CherryPie { get; set; }

        public MainPage()
        {
            InitializeComponent();

            //Binding in code
            Pie pie = new Pie
            {
                Id = 1,
                PieName = "Cherry Pie",
                Price = 20
            };

            //Binding pieNameBinding = new Binding();
            //pieNameBinding.Source = pie;
            //pieNameBinding.Path = "PieName";
            //NameEntry.SetBinding(Entry.TextProperty, pieNameBinding);

            //Binding priceBinding = new Binding();
            //priceBinding.Source = pie;
            //priceBinding.Path = "Price";
            //PriceEntry.SetBinding(Entry.TextProperty, priceBinding);


            //Pie pie = new Pie
            //{
            //    Id = 1,
            //    PieName = "Cherry Pie",
            //    Price = 20
            //};

            //MainGrid.BindingContext = pie;

            CherryPie = new Pie
            {
                Id = 1,
                PieName = "Cherry Pie",
                Price = 20
            };

            //MainGrid.BindingContext = CherryPie;

            this.BindingContext = CherryPie;

            //this.BindingContext = this;

        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            CherryPie.Price++;
        }
    }
}
