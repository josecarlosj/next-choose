using System.Collections.ObjectModel;
using NextChoose.Models;
using Xamarin.Forms;

namespace NextChoose.Modules
{
    public partial class AllOptionsPage : ContentPage
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

                Application.Current.MainPage.Navigation.PushAsync(new EditOptionPage(SelectedOptionItem));
            }
        }

        ObservableCollection<OptionItem> optionItems;
        public ObservableCollection<OptionItem> OptionItems
        {
            get
            {
                return optionItems;
            }
            set
            {
                optionItems = value;
                OnPropertyChanged(nameof(OptionItems));
            }
        }

        #endregion

        public AllOptionsPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        #region Events

        void AddOption_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new AddOptionPage());
        }

        #endregion

        #region PageEvents

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            OptionItems = new ObservableCollection<OptionItem>(await App.Database.GetOptionsAsync());
        }

        #endregion
    }
}
