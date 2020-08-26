using System;
using System.Collections.Generic;
using NextChoose.Models;
using NextChoose.Utils;
using Xamarin.Forms;

namespace NextChoose.Modules
{
    public partial class ChooseOptionPage : ContentPage
    {
        public string SelectedOption { get; set; }
        public List<OptionItem> Options { get; private set; }
        int optionIndex = 0;

        public ChooseOptionPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        private void ChooseOption_Clicked(object sender, EventArgs e)
        {
            optionIndex = 0;
            Options = new List<OptionItem>(OptionItemMock.GetOptionItems());

            Device.StartTimer(TimeSpan.FromSeconds(0.2), () => OnTimerTick());
        }

        bool OnTimerTick()
        {

            Device.BeginInvokeOnMainThread(() =>
            {
                lblSelectedOption.Text = Options[optionIndex].Title;
                if (++optionIndex >= Options.Count)
                    optionIndex = 0;
            });
            return true;
        }
    }
}
