using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Services.Models
{
    public class Category
    {
        public Category()
        {
        }

        public string CategoryName { get; set; }
        public object Products { get; set; }
    }
}