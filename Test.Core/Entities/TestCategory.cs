using Repository;
using System.Collections.Generic;

namespace EPA.Core.Entities
{
    public class TestCategory : EntityBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<TestProductCategory> TestProductCategories { get; set; }

        public TestCategory()
        {
            TestProductCategories = new List<TestProductCategory>();
        }
    }
}