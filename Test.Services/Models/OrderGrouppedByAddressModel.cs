using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Services.Models
{
    public class OrderGrouppedByAddressModel
    {
        public OrderGrouppedByAddressModel()
        {
            this.Categories = new List<Category>();
        }

        public string Address { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}