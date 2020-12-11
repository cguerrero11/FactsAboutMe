using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactsAboutMe.Models;
using SQLite;

namespace FactsAboutMe.Data
{
    public class ChrisFactDatabase
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public ChrisFactDatabase()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(ChrisFact).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(ChrisFact)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public Task<List<ChrisFact>> GetItemsAsync()
        {
            return Database.Table<ChrisFact>().ToListAsync();
        }

        public Task<ChrisFact> GetItemAsync(int id)
        {
            return Database.Table<ChrisFact>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(ChrisFact item)
        {
            if (item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> InsertList(IEnumerable<ChrisFact> items)
        {
            return Database.InsertAllAsync(items);
        }

        public Task<int> DeleteItemAsync(ChrisFact item)
        {
            return Database.DeleteAsync(item);
        }
        public Task<int> ClearAllAsync()
        {
            return Database.DeleteAllAsync<ChrisFact>();
        }
    }
}