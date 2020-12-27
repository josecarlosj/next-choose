using System.Collections.ObjectModel;
using NextChoose.Models;

namespace NextChoose.Utils
{
    public static class OptionItemMock
    {
        static ObservableCollection<OptionItem> optionItems;
        public static ObservableCollection<OptionItem> OptionItems
        {
            get
            {
                return optionItems;
            }
            set
            {
                optionItems = value;
            }
        }

        public static ObservableCollection<OptionItem> GetFinishedItems()
        {
            return new ObservableCollection<OptionItem>()
            {
                new OptionItem ()
                {
                    Title = "Opção 06"
                }
            };
        }
    }
}
