using System.Collections.ObjectModel;
using NextChoose.Models;
using NextChoose.Utils;
using Xamarin.Forms;

namespace NextChoose.Modules
{
    public partial class AllOptionsPage : ContentPage
    {
        public ObservableCollection<OptionItem> OptionItems { get; set; }

        public AllOptionsPage()
        {
            InitializeComponent();

            OptionItems = OptionItemMock.GetOptionItems();

            BindingContext = this;
        }
    }
}
