

using EPA.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace EPA.Core.Entities
{
    public class TestProduct : BaseEntity, ILocalizedEntity
    {
        public string Name { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }

        // Reverse navigation
        public virtual ICollection<TestOrderProduct> TestOrderProducts { get; set; }
        public virtual ICollection<TestProductCategory> TestProductCategories { get; set; }

        public TestProduct()
        {
            TestOrderProducts = new List<TestOrderProduct>();
            TestProductCategories = new List<TestProductCategory>();
        }
    }

}

