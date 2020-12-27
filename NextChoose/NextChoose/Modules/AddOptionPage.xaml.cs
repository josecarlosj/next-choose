using System;
using NextChoose.Models;
using NextChoose.Utils;
using Xamarin.Forms;

namespace NextChoose.Modules
{
    public partial class AddOptionPage : ContentPage
    {
        #region Properties

        string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        #endregion

        public AddOptionPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        async void AddOption_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Description))
            {
                await DisplayAlert("Aviso!", "O campo Descrição não pode ser vazio.", "Ok");
                return;
            }

            OptionItem newOption = new OptionItem { Title = Description };
            OptionItemMock.OptionItems.Add(newOption);

            await DisplayAlert("Adicionar Opção", $"{Description} foi adicionado(a) com sucesso.", "Ok");
            await Navigation.PopAsync();
        }
    }
}
