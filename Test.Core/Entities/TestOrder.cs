using Repository;
using System.Collections.Generic;

namespace EPA.Core.Entities
{
    public class TestOrder : EntityBase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public virtual ICollection<TestOrderProduct> TestOrderProducts { get; set; }

        public TestOrder()
        {
            TestOrderProducts = new List<TestOrderProduct>();
        }
    }
}