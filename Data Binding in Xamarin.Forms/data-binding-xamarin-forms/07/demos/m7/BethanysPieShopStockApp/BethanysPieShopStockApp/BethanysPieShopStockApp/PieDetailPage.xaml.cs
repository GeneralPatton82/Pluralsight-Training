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
    public partial class PieDetailPage : ContentPage
    {
        public PieDetailPage()
        {
            InitializeComponent();
        }

        private async void SavePieButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Success", "Pie saved", "Done");
        }
    }
}