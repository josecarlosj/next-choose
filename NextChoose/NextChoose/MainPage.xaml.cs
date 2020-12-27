using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using NextChoose.Models;
using NextChoose.Modules;
using NextChoose.Utils;
using Xamarin.Forms;

namespace NextChoose
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            OptionItemMock.OptionItems = new ObservableCollection<OptionItem>()
            {
                new OptionItem ()
                {
                    Title = "Opção 01"
                },
                new OptionItem ()
                {
                    Title = "Opção 02"
                },
                new OptionItem ()
                {
                    Title = "Opção 03"
                },
                new OptionItem ()
                {
                    Title = "Opção 04"
                },
                new OptionItem ()
                {
                    Title = "Opção 05"
                }
            };
        }

        void OpenAllOption_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new AllOptionsPage());
        }

        void OpenChooseOptionn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new ChooseOptionPage());
        }
    }
}
