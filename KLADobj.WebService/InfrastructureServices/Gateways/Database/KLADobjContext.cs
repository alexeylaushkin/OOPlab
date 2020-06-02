using Microsoft.EntityFrameworkCore;
using KLADobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

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
            FillTestData(modelBuilder);
        }
        private void FillTestData(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<kladobj>().HasData(
                new
                {
                    Id = 1L,
                    Name = "Стационарный общественный туалет № 123",
                    Address = "город Москва, Манежная улица, дом 2-10, сооружение 1",
                    ChillType = "бесплатный",
                    Free = "действует",
                    
                },
                new
                {
                    Id = 2L,
                    Name = "Стационарный общественный туалет № 45",
                    Address = "город Москва, Большая Садовая улица, дом 16, сооружение 1",
                    ChillType = "бесплатный",
                    Free = "действует",

                },
                new
                {
                    Id = 3L,
                    Name = "Стационарный общественный туалет № 13",
                    Address = "город Москва, улица Земляной Вал, дом 1/4, строение 1",
                    ChillType = "бесплатный",
                    Free = "действует",

                },
                new
                {
                    Id = 4L,
                    Name = "Стационарный общественный туалет № 85",
                    Address = "город Москва, Марксистская улица, дом 2, строение 2",
                    ChillType = "бесплатный",
                    Free = "действует",
                }
               
            );
        }
    }
}
