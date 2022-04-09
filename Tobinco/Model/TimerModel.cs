using System;
using SQLite;

namespace Tobinco.Model
{
    public class TimerModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Day { get; set; }
        public int Date { get; set; }
        public bool Selected { get; set; }
    }
}
