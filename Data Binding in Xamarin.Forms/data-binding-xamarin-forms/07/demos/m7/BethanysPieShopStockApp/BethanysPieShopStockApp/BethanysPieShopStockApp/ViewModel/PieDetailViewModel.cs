using BethanysPieShopStockApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BethanysPieShopStockApp.ViewModel
{
    public class PieDetailViewModel : INotifyPropertyChanged
    {
        public Pie Pie { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public PieDetailViewModel(Pie pie)
        {
            Pie = pie;
        }

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
