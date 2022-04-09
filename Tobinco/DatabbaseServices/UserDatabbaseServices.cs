using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SQLite;
using Tobinco.Model;
using Xamarin.Essentials;

namespace Tobinco.DatabbaseServices
{
    public static class UserDatabbaseServices
    {
        static SQLiteAsyncConnection Databbase;

        static async Task init()
        {
            if(Databbase != null)
            {
                return;
            }
            else
            {
                var databbasePath = Path.Combine(FileSystem.AppDataDirectory, "TobincoInventory.db");

                Databbase = new SQLiteAsyncConnection(databbasePath);
                await Databbase.CreateTableAsync<ToincoUsers>();
            }
        }
        public static async Task AddUsersAccount(ToincoUsers tobincoUsers)
        {
            await init();
            await Databbase.InsertAsync(tobincoUsers);
        }
        public static async Task<List<ToincoUsers>> UsersSignAccount(string email, string password)
        {
            await init();
            var signInQuery = await Databbase.QueryAsync<ToincoUsers>("SELECT * FROM ToincoUsers WHERE Email = '"+email+"' AND PhoneNumber == '"+password+"' ");

            return signInQuery;

        }
        public static async Task<IEnumerable<ToincoUsers>> GetUsersAccount()
        {
            await init();
            var tobincousers = await Databbase.Table<ToincoUsers>().ToListAsync();
            return tobincousers;
        }
        public static async Task DeleteUsersAccount(ToincoUsers tobincoUsers)
        {
            await init();
            await Databbase.DeleteAsync(tobincoUsers);
        }
        public static async Task UpdateUsersAccount(ToincoUsers tobincoUsers)
        {
            await init();
        }
    }
}
