using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BethanysPieShopStockApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopStockApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PieDetailPageCompiled : ContentPage
	{
        public Pie Pie { get; set; }
        public PieDetailPageCompiled (Pie pie)
		{
			InitializeComponent ();
            Pie = pie;

            this.BindingContext = Pie;
        }

        private void SavePieButton_OnClicked(object sender, EventArgs e)
        {
            

        }
    }
}