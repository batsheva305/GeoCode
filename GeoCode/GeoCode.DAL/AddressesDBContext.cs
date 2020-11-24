using System;
using System.Collections.Generic;
using System.Text;
using GeoCode.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GeoCode.DAL
{
    public class AddressesDBContext : DbContext
    {
        public DbSet<Address> Addreses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=C:\\Users\\kampinsk\\Desktop\\GeoCode_Project\\GeoCode\\GeoCode.DAL\\DB.db");


    }
}
