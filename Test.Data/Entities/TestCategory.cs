

using EPA.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace EPA.Core.Entities
{
    public class TestCategory : BaseEntity, ILocalizedEntity
    {
        public string Name { get; set; }

        // Reverse navigation
        public virtual ICollection<TestProductCategory> TestProductCategories { get; set; }

        public TestCategory()
        {
            TestProductCategories = new List<TestProductCategory>();
        }
    }

}

