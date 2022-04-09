﻿using System;
using SQLite;

namespace Tobinco.Model
{
    public class ToincoUsers
    {
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string DateCreated { get; set; }

    }
}
