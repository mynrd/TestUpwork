

using EPA.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace EPA.Core.Entities
{
    // The table 'TestProductCategories' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class TestProductCategory : BaseEntity, ILocalizedEntity
    {
        public int? ProductId { get; set; }
        public int? CategoryId { get; set; }

        public virtual TestCategory TestCategory { get; set; }
        public virtual TestProduct TestProduct { get; set; }
    }

}

