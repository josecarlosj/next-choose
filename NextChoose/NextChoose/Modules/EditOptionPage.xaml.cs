using System;
using NextChoose.Models;
using Xamarin.Forms;

namespace NextChoose.Modules
{
    public partial class EditOptionPage : ContentPage
    {
        #region Properties

        OptionItem selectedOptionItem;
        public OptionItem SelectedOptionItem
        {
            get
            {
                return selectedOptionItem;
            }
            set
            {
                selectedOptionItem = value;
                OnPropertyChanged(nameof(SelectedOptionItem));
            }
        }

        #endregion

        public EditOptionPage(OptionItem optionItem)
        {
            InitializeComponent();

            BindingContext = this;

            SelectedOptionItem = optionItem;
        }

        #region Events

        async void SaveOption_Clicked(object sender, EventArgs e)
        {
            await App.Database.SaveOptionAsync(SelectedOptionItem);

            await DisplayAlert("Editar Opção", $"{SelectedOptionItem.Title} foi editado(a) com sucesso.", "Ok");
            await Navigation.PopAsync();
        }

        
        async void DeleteOption_Clicked(object sender, EventArgs e)
        {
            await App.Database.DeleteOptionAsync(SelectedOptionItem);

            await DisplayAlert("Deletar Opção", $"{SelectedOptionItem.Title} foi deletado(a) com sucesso.", "Ok");
            await Navigation.PopAsync();
        }

        #endregion
    }
}
