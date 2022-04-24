using NBP_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.PopulateDb
{
    public static partial class PopulateDb
    {
        public static void Populate(NbpContext context)
        {
            FlushDb(context);
            context.SaveChanges();

            #region main tables
            PopulateArtists(context);
            context.SaveChanges();
            PopulateArtWorks(context);
            context.SaveChanges();
            PopulateRentals(context);
            context.SaveChanges();
            #endregion
            #region side tables
            PopulatePlaces(context);
            context.SaveChanges();
            PopulateCustomers(context);
            context.SaveChanges();
            PopulateExhibitions(context);
            context.SaveChanges();
            PopulateArtExhibitions(context);
            context.SaveChanges();
            PopulateOrderToBuys(context);
            context.SaveChanges();
            PopulateNfts(context);
            context.SaveChanges();
            PopulateNftOwnerHistories(context);
            context.SaveChanges();
            #endregion
        }

        public static void FlushDb(NbpContext context)
        {
            context.Artists.RemoveRange(context.Artists);
            context.ArtWorks.RemoveRange(context.ArtWorks);
            context.Places.RemoveRange(context.Places);
            context.Customers.RemoveRange(context.Customers);
            context.Rentals.RemoveRange(context.Rentals);
            context.Exhibitions.RemoveRange(context.Exhibitions);
            context.ArtExhibitions.RemoveRange(context.ArtExhibitions);
            context.OrderToBuys.RemoveRange(context.OrderToBuys);
            context.Nfts.RemoveRange(context.Nfts);
            context.NftOwnerHistories.RemoveRange(context.NftOwnerHistories);
            context.SaveChanges();
        }
    }
}
