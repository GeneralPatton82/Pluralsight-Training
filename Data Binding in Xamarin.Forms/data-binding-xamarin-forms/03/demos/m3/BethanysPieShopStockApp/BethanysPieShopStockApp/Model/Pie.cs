using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BethanysPieShopStockApp.Model
{
    //public class Pie
    //{
    //    public int Id { get; set; }

    //    public string PieName { get; set; }

    //    public double Price { get; set; }
    //}

    public class Pie: INotifyPropertyChanged
    {
        private int _id;
        private string _pieName;
        private double _price;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged(nameof(Id));
            }
        }

        public string PieName
        {
            get => _pieName;
            set
            {
                _pieName = value; 
                RaisePropertyChanged(nameof(PieName));
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                _price = value;
                RaisePropertyChanged(nameof(Price));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
