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
        public int? Price { get; set; }
        public int? CategoryId { get; set; }
        public Category category { get; set; }
        public override string ToString()
        {
            return $"id - {Id} - name {Name}- price {Price} - category id {CategoryId} - categiry name ";
        }

    }
}
