using HW11.Container;
using HW11.Entity;
using HW11.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Servise
{
    public class ProductService : IProductService
    {
        IProductRepository _repository;
        public ProductService() 
        {
            _repository=new ProductRepository();
        }


        public void Add(Product product)
        {
            if (product != null) 
            {
                _repository.Add(product);
            }
        }

        public void Delete(int id)
        {
            if (id > 0) 
            {
                _repository.Delete(id);
            }
        }

        public Product Get(int id)
        {
            if (id > 0) 
            {
               return _repository.Get(id);
            }
            return null;
        }

        public List<Product> GetAll()
        {
            if(_repository == null)
            {
                return new List<Product>();
            }
            return _repository.GetAll();
        }

        public void Update(Product product)
        {
            if (product != null)
            {
                _repository.Update(product);
            }
        }
    }
}
