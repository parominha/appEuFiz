using appeufiz.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace appeufiz.ViewModels
{


    public class ConfigViewModel : BaseViewModel
    {
        public ConfigViewModel()
        {
        Title = "Config";
        //    OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}