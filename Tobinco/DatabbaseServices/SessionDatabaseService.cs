using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SQLite;
using Tobinco.Model;
using Xamarin.Essentials;

namespace Tobinco.DatabbaseServices
{
    public class SessionDatabaseService
    {
        static SQLiteAsyncConnection Databbase;

        static async Task init()
        {
            if (Databbase != null)
            {
                return;
            }
            else
            {
                var databbasePath = Path.Combine(FileSystem.AppDataDirectory, "TobincoInventory.db");

                Databbase = new SQLiteAsyncConnection(databbasePath);
                await Databbase.CreateTableAsync<StartSessionModel>();
            }
        }
        public static async Task AddSession(StartSessionModel startSession)
        {
            await init();
            await Databbase.InsertAsync(startSession);
        }
        public static async Task<List<StartSessionModel>> StartSessionSelect(DateTime startTime)
        {
            await init();
            var signInQuery = await Databbase.QueryAsync<StartSessionModel>("SELECT * FROM StartSessionModel WHERE DateStamp = '" + startTime.ToShortDateString() + "' ");

            return signInQuery;

        }
        public static async Task<IEnumerable<StartSessionModel>> GetAllSession()
        {
            await init();
            var tobincoSession = await Databbase.Table<StartSessionModel>().ToListAsync();
            return tobincoSession;
        }
        public static async Task DeleteUsersAccount(StartSessionModel delecteSession)
        {
            await init();
            await Databbase.DeleteAsync(delecteSession);
        }
        public static async Task UpdateUsersAccount(ToincoUsers tobincoUsers)
        {
            await init();
        }
    }
}
