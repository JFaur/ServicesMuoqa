﻿using Microsoft.EntityFrameworkCore;
using IdentidadesServicesMuoqa;

namespace DataBaseServicesMuoqa
{
    public class Connection : DbContext
    {
        public Connection(DbContextOptions<Connection> options)
            : base(options) 
        {
        }
        public DbSet<ServicesPrices> ServicesPrices { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ServicesPrices>((entity) =>
            {
                entity.HasKey(u => u.ServiceId);
            });
        }
    }
}