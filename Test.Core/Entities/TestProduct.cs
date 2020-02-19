using Repository;
using System.Collections.Generic;

namespace EPA.Core.Entities
{
    public class TestProduct : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TestOrderProduct> TestOrderProducts { get; set; }
        public virtual ICollection<TestProductCategory> TestProductCategories { get; set; }

        public TestProduct()
        {
            TestOrderProducts = new List<TestOrderProduct>();
            TestProductCategories = new List<TestProductCategory>();
        }
    }

}

