using EPA.Core.Mappings;
using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace EPA.Core.Entities
{
    public class TestContext : Repository.Providers.EntityFramework.DataContext
    {
        public DbSet<TestCategory> TestCategories { get; set; }
        public DbSet<TestOrder> TestOrders { get; set; }
        public DbSet<TestOrderProduct> TestOrderProducts { get; set; }
        public DbSet<TestProduct> TestProducts { get; set; }

        static TestContext()
        {
            Database.SetInitializer<TestContext>(null);
        }

        public TestContext()
            : base("Name=TEST")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new TestCategoryConfiguration());
            modelBuilder.Configurations.Add(new TestOrderConfiguration());
            modelBuilder.Configurations.Add(new TestOrderProductConfiguration());
            modelBuilder.Configurations.Add(new TestProductConfiguration());
            modelBuilder.Configurations.Add(new TestProductCategoryConfiguration());
        }
    }
}