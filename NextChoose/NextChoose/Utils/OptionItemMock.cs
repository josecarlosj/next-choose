using System.Collections.ObjectModel;
using NextChoose.Models;

namespace NextChoose.Utils
{
    public static class OptionItemMock
    {
        public static ObservableCollection<OptionItem> GetOptionItems()
        {
            return new ObservableCollection<OptionItem>()
            {
                new OptionItem ()
                {
                    Title = "Opção 01"
                },
                new OptionItem ()
                {
                    Title = "Opção 02"
                },
                new OptionItem ()
                {
                    Title = "Opção 03"
                },
                new OptionItem ()
                {
                    Title = "Opção 04"
                },
                new OptionItem ()
                {
                    Title = "Opção 05"
                },
                new OptionItem ()
                {
                    Title = "Opção 06"
                }
            };
        }
    }
}
