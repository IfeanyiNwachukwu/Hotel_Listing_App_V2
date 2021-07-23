﻿using Microsoft.EntityFrameworkCore;

namespace HotelListingAppVersion2.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Country>Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }


    }
}
