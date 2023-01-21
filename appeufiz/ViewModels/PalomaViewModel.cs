using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace appeufiz.ViewModels
{
    public class PalomaViewModel : BaseViewModel
    {
        public PalomaViewModel()
        {
            Title = "Paloma";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}