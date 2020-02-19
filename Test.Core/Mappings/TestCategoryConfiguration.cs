using EPA.Core.Entities;
using System.Data.Entity.ModelConfiguration;

namespace EPA.Core.Mappings
{
    public class TestCategoryConfiguration : EntityTypeConfiguration<TestCategory>
    {
        public TestCategoryConfiguration()
            : this("dbo")
        {
        }

        public TestCategoryConfiguration(string schema)
        {
            ToTable("TestCategories", schema);
            HasKey(x => x.Id);

            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
        }
    }
}