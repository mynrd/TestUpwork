

using EPA.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace EPA.Core.Entities
{
    public class TestOrder : BaseEntity, ILocalizedEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        // Reverse navigation
        public virtual ICollection<TestOrderProduct> TestOrderProducts { get; set; }

        public TestOrder()
        {
            TestOrderProducts = new List<TestOrderProduct>();
        }
    }

}

