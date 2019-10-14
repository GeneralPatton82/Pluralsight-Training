using BethanysPieShopStockApp.Model;
using BethanysPieShopStockApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopStockApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PieOverviewPage : ContentPage
    {
        public PieOverviewPage()
        {
            InitializeComponent();
        }

        private async void PiesListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            PieDetailPage pieDetailPage = new PieDetailPage();
            PieDetailViewModel pieDetailViewModel = new PieDetailViewModel(e.Item as Pie);
            pieDetailPage.BindingContext = pieDetailViewModel;

            await this.Navigation.PushAsync(pieDetailPage);
        }
    }
}