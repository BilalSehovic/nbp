﻿using NBP_app.Models.Artists;
using NBP_app.Models.ArtWorks;
using NBP_app.Models.Rentals;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models
{
    public class NbpContext : DbContext
    {
        public NbpContext() : base("name=NbpContext") { }

        public DbSet<ArtExhibition> ArtExhibitions { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistAudit> ArtistAudits { get; set; }
        public DbSet<ArtWork> ArtWorks { get; set; }
        public DbSet<ArtWorkAudit> ArtWorkAudits { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<RentalAudit> RentalAudits { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<Nft> Nfts { get; set; }
        public DbSet<NftOwnerHistory> NftOwnerHistories { get; set; }
        public DbSet<OrderToBuy> OrderToBuys { get; set; }
        public DbSet<Place> Places { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
