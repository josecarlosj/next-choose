using System;
using System.Collections.Generic;
using System.Linq;
using NextChoose.Models;
using NextChoose.Utils;
using Xamarin.Forms;

namespace NextChoose.Modules
{
    public partial class ChooseOptionPage : ContentPage
    {
        public string SelectedOption { get; set; }
        public List<OptionItem> Options { get; private set; }
        int optionIndex;

        int randomEndObj;
        int count;

        public ChooseOptionPage()
        {
            InitializeComponent();

            //Desordanação simples da lista
            var randomObj = new Random();
            Options = OptionItemMock.GetOptionItems().OrderBy(x => randomObj.Next()).ToList();

            lblSelectedOption.Text = "Toque no botão abaixo.";

            BindingContext = this;
        }

        private void ChooseOption_Clicked(object sender, EventArgs e)
        {
            count = 0;
            randomEndObj = new Random().Next(40, 60);

            optionIndex = 0;

            Device.StartTimer(TimeSpan.FromSeconds(0.05), () => OnTimerTickAsync());

            (sender as Button).IsEnabled = false;
        }

        bool OnTimerTickAsync()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                lblSelectedOption.Text = Options[optionIndex].Title;
                if (++optionIndex >= Options.Count)
                    optionIndex = 0;
            });

            count++;
            if (count == randomEndObj)
            {

                lblSelectedOption.ScaleTo(2, 200).ContinueWith((retorno) =>
                {
                    lblSelectedOption.ScaleTo(1, 200).Wait();
                });

                btnChooseOption.IsEnabled = true;
                return false;
            }

            return true;
        }
    }
}
