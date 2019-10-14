using BethanysPieShopStockApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace BethanysPieShopStockApp.ViewModel
{
    public class PieOverviewViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly PieRepository pieRepository;

        public ObservableCollection<Pie> Pies { get; set; }

        public PieOverviewViewModel()
        {
            pieRepository = new PieRepository();
            Pies = pieRepository.Pies;
        }

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
