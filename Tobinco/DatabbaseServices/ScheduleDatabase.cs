using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SQLite;
using Tobinco.Model;
using Xamarin.Essentials;

namespace Tobinco.DatabbaseServices
{
    public class ScheduleDatabase
    {
        static SQLiteAsyncConnection ScheduleDatabbase;

        static async Task init()
        {
            if (ScheduleDatabbase != null)
            {
                return;
            }
            else
            {
                var databbasePath = Path.Combine(FileSystem.AppDataDirectory, "TobincoInventory.db");

                ScheduleDatabbase = new SQLiteAsyncConnection(databbasePath);
                await ScheduleDatabbase.CreateTableAsync<ScheduleModel>();
            }
        }
        public static async Task AddSchedule(ScheduleModel schedule)
        {
            await init();
            await ScheduleDatabbase.InsertAsync(schedule);
        }
        public static async Task<IEnumerable<ScheduleModel>> GetAlSchedule()
        {
            await init();
            var Userschdules = await ScheduleDatabbase.Table<ScheduleModel>().ToListAsync();
            return Userschdules;
        }
        public static async Task DeleteShdule(ScheduleModel schduledelete)
        {
            await init();
            await ScheduleDatabbase.DeleteAsync(schduledelete);
        }
        public static async Task UpdateUsersAccount(ScheduleModel updateSchedule)
        {
            await init();
           // await ScheduleDatabase.U
        }
    }
}
