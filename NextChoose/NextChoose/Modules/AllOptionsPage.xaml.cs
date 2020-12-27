using System.Collections.ObjectModel;
using System.Linq;
using NextChoose.Models;
using NextChoose.Utils;
using Xamarin.Forms;

namespace NextChoose.Modules
{
    public partial class AllOptionsPage : ContentPage
    {
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

        public AllOptionsPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        void AddOption_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new AddOptionPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            OptionItems = new ObservableCollection<OptionItem>(OptionItemMock.OptionItems.OrderBy(o => o.Title));
        }
    }
}
