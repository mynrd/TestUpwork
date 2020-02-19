

using EPA.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace EPA.Core.Entities
{
    public class TestOrderProduct : BaseEntity, ILocalizedEntity
    {
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Total { get; set; }

        public virtual TestOrder TestOrder { get; set; }
        public virtual TestProduct TestProduct { get; set; }
    }

}

