

using EPA.Core.Entities;
using EPA.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Spatial;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EPA.Core.Entities
{
    public class EPAContext : Repository.Providers.EntityFramework.DataContext
    {
        public DbSet<TestCategory> TestCategories { get; set; }
        public DbSet<TestOrder> TestOrders { get; set; }
        public DbSet<TestOrderProduct> TestOrderProducts { get; set; }
        public DbSet<TestProduct> TestProducts { get; set; }

        static EPAContext()
        {
            System.Data.Entity.Database.SetInitializer<EPAContext>(null);
        }

        /// <inheritdoc />
        public EPAContext()
            : base("Name=EPAContext")
        {
        }

        /// <inheritdoc />
        public EPAContext(string connectionString)
            : base(connectionString)
        {
        }

        /// <inheritdoc />
        public EPAContext(string connectionString, DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        /// <inheritdoc />
        public EPAContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        /// <inheritdoc />
        public EPAContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        /// <inheritdoc />
        public EPAContext(ObjectContext objectContext, bool dbContextOwnsObjectContext)
            : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == DBNull.Value);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new TestCategoryConfiguration());
            modelBuilder.Configurations.Add(new TestOrderConfiguration());
            modelBuilder.Configurations.Add(new TestOrderProductConfiguration());
            modelBuilder.Configurations.Add(new TestProductConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new TestCategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new TestOrderConfiguration(schema));
            modelBuilder.Configurations.Add(new TestOrderProductConfiguration(schema));
            modelBuilder.Configurations.Add(new TestProductConfiguration(schema));

            return modelBuilder;
        }
    }
}

