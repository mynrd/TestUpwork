using Repository;

namespace EPA.Core.Entities
{
    public class TestProductCategory : EntityBase
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        public virtual TestCategory TestCategory { get; set; }
        public virtual TestProduct TestProduct { get; set; }
    }

}

