using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? CategoryId { get; set; }
        public int? Price { get; set; }

    }
}
