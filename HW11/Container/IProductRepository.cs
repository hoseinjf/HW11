using HW11.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Container
{
    public interface IProductRepository
    {
        void Add(Product product);
        Product Get(int id);
        List<Product> GetAll();
        void Update(Product product);
        void Delete(int id);

    }
}
