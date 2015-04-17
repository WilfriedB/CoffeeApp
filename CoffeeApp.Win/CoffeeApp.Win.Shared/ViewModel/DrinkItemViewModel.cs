using CoffeeApp.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Windows.UI.Xaml;

namespace CoffeeApp.Win.ViewModel
{
    public class DrinkItemViewModel : INotifyPropertyChanged
    {
        private readonly DrinkItem drinkItem;
        public event PropertyChangedEventHandler PropertyChanged;

        public DrinkItemViewModel(DrinkItem drinkItem)
        {
            this.drinkItem = drinkItem;
        }

        public string Name
        {
            get { return drinkItem.Name; }
        }

        public int Count
        {
            get { return drinkItem.Count; }
        }

        public void Increase()
        {
            var count = drinkItem.Count;
            drinkItem.Increase();
            if (count != drinkItem.Count)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Count"));
                }
            }
        }

        public void Decrease()
        {
            var count = drinkItem.Count;
            drinkItem.Decrease();
            if (count != drinkItem.Count)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Count"));
                }
            }
        }

        public void Reset()
        {
            var count = drinkItem.Count;
            drinkItem.Reset();
            if (count != drinkItem.Count)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Count"));
                }
            }
        }

    }
}
