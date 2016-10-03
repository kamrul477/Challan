using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Challan.Models
{
    public class ChallanContext : DbContext
    {
        public ChallanContext()
        {
            Database.SetInitializer<Challan.Models.ChallanContext>(new DropCreateDatabaseIfModelChanges<Challan.Models.ChallanContext>());
        }

        public DbSet<AcceptorDetails> AcceptorDetailses { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ApplicantDetails> ApplicantDetailses { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<ChallanPrinciple> Challans { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<HolderDetails> HolderDetailses { get; set; }

    }
}
