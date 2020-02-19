using Repository;

namespace EPA.Core.Entities
{
    public class TestOrderProduct : EntityBase
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }

        public virtual TestOrder TestOrder { get; set; }
        public virtual TestProduct TestProduct { get; set; }
    }

}

