using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Demo1.ViewModels
{
    public class DemoViewModel : INotifyPropertyChanged
    {
        private string _account;

        public DemoViewModel()
        {
            
        }

       

        public event PropertyChangedEventHandler PropertyChanged;

        public string Account { get => _account; set { _account = value; OnPropertyChanged("Account"); } }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

