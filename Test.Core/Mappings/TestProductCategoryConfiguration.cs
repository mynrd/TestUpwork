using EPA.Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EPA.Core.Mappings
{
    public class TestProductCategoryConfiguration : EntityTypeConfiguration<TestProductCategory>
    {
        public TestProductCategoryConfiguration()
            : this("dbo")
        {
        }

        public TestProductCategoryConfiguration(string schema)
        {
            ToTable("TestProductCategories", schema);
            HasKey(x => new { x.ProductId, x.CategoryId });

            Property(x => x.ProductId).HasColumnName(@"ProductId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CategoryId).HasColumnName(@"CategoryId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            HasRequired(a => a.TestCategory).WithMany(b => b.TestProductCategories).HasForeignKey(c => c.CategoryId).WillCascadeOnDelete(false);
            HasRequired(a => a.TestProduct).WithMany(b => b.TestProductCategories).HasForeignKey(c => c.ProductId).WillCascadeOnDelete(false);
        }
    }

}

