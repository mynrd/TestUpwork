

using EPA.Core.Entities;
using EPA.Core.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPA.Core.Entities
{
    public class TestOrderProductConfiguration : EntityTypeConfiguration<TestOrderProduct>
    {
        public TestOrderProductConfiguration()
            : this("dbo")
        {
        }

        public TestOrderProductConfiguration(string schema)
        {
            ToTable("TestOrderProducts", schema);
            HasKey(x => x.Id);

            Property(x => x.OrderId).HasColumnName(@"OrderId").HasColumnType("int").IsOptional();
            Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsOptional();
            Property(x => x.Quantity).HasColumnName(@"Quantity").HasColumnType("int").IsOptional();
            Property(x => x.Price).HasColumnName(@"Price").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.Total).HasColumnName(@"Total").HasColumnType("money").IsOptional().HasPrecision(19,4);

            // Foreign keys
            HasOptional(a => a.TestOrder).WithMany(b => b.TestOrderProducts).HasForeignKey(c => c.OrderId).WillCascadeOnDelete(false);
            HasOptional(a => a.TestProduct).WithMany(b => b.TestOrderProducts).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false);
        }
    }

}

