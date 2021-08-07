using System;
using NextChoose.Models;
using Xamarin.Forms;

namespace NextChoose.Modules
{
    public partial class AddOptionPage : ContentPage
    {
        #region Properties

        string itemTitle;
        public string ItemTitle
        {
            get
            {
                return itemTitle;
            }
            set
            {
                itemTitle = value;
                OnPropertyChanged(nameof(ItemTitle));
            }
        }

        #endregion

        public AddOptionPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        #region Events

        async void AddOption_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ItemTitle))
            {
                await DisplayAlert("Aviso!", "O campo Título não pode ser vazio.", "Ok");
                return;
            }

            OptionItem newOption = new OptionItem { Title = ItemTitle };

            await App.Database.SaveOptionAsync(newOption);

            await DisplayAlert("Adicionar Opção", $"{ItemTitle} foi adicionado(a) com sucesso.", "Ok");
            await Navigation.PopAsync();
        }

        #endregion
    }
}
