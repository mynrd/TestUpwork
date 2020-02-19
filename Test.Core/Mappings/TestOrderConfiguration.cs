using EPA.Core.Entities;
using System.Data.Entity.ModelConfiguration;

namespace EPA.Core.Mappings
{
    public class TestOrderConfiguration : EntityTypeConfiguration<TestOrder>
    {
        public TestOrderConfiguration()
            : this("dbo")
        {
        }

        public TestOrderConfiguration(string schema)
        {
            ToTable("TestOrders", schema);
            HasKey(x => x.Id);

            Property(x => x.FirstName).HasColumnName(@"FirstName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.LastName).HasColumnName(@"LastName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Address).HasColumnName(@"Address").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.City).HasColumnName(@"City").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.State).HasColumnName(@"State").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Country).HasColumnName(@"Country").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
        }
    }

}

