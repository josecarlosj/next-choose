using System;
using System.ComponentModel;
using NextChoose.Modules;
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
