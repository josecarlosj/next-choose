using System;
using SQLite;

namespace NextChoose.Models
{
    public class OptionItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateFinish { get; set; }
        public bool WasWatched { get; set; }
    }
}
