using Microsoft.EntityFrameworkCore;
using KLADobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;
using KLADobj.ApplicationServices.Synchronization;

namespace KLADobj.InfrastructureServices.Gateways.Database
{
    public class KLADobjContext : DbContext
    {
        public DbSet<kladobj> KLADobjs { get; set; }

        public KLADobjContext(DbContextOptions options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var v = new UseCaseKLADobj();

            modelBuilder.Entity<kladobj>().HasData(v.kladobjs);
        }
    }
}
