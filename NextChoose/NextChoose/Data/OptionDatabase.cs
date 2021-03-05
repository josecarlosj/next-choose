using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NextChoose.Models;
using SQLite;

namespace NextChoose.Data
{
    public class OptionDatabase
    {
        readonly SQLiteAsyncConnection database;

        public OptionDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<OptionItem>().Wait();
        }

        public Task<List<OptionItem>> GetOptionsAsync()
        {
            //Get all options.
            return database.Table<OptionItem>().OrderBy(x => x.Title).ToListAsync();
        }

        public Task<OptionItem> GetOptionAsync(int id)
        {
            // Get a specific option.
            return database.Table<OptionItem>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveOptionAsync(OptionItem option)
        {
            if (option.Id != 0)
            {
                // Update an existing option.
                return database.UpdateAsync(option);
            }
            else
            {
                // Save a new option.
                return database.InsertAsync(option);
            }
        }

        public Task<int> DeleteOptionAsync(OptionItem option)
        {
            // Delete a option.
            return database.DeleteAsync(option);
        }
    }
}
