

using EPA.Core.Entities;
using EPA.Core.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPA.Core.Entities
{
    public class TestProductConfiguration : EntityTypeConfiguration<TestProduct>
    {
        public TestProductConfiguration()
            : this("dbo")
        {
        }

        public TestProductConfiguration(string schema)
        {
            ToTable("TestProducts", schema);
            HasKey(x => x.Id);

            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Sku).HasColumnName(@"SKU").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
        }
    }

}

