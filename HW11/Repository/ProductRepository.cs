using Dapper;
using HW11.Confige;
using HW11.Container;
using HW11.Entity;
using HW11.Queries;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void Add(Product product)
        {
            using (var conetion = new SqlConnection(DatabaseConfige.ConnectionString))
            {
                conetion.Execute(ProductQueries.Add, new { product.Name, product.Price, product.CategoryId });
            }
        }

        public void Delete(int id)
        {
            using (var conetion = new SqlConnection(DatabaseConfige.ConnectionString))
            {
                conetion.Execute(ProductQueries.Delete, new {Id=id});
            }
        }

        public Product Get(int id)
        {
            using (var conetion = new SqlConnection(DatabaseConfige.ConnectionString))
            {
                return conetion.QueryFirstOrDefault<Product>(ProductQueries.Get, new { Id = id });
            }
        }

        public List<Product> GetAll()
        {
            using (var conetion = new SqlConnection(DatabaseConfige.ConnectionString))
            {
                return conetion.Query<Product>(ProductQueries.GetAll).ToList();
            }
        }

        public void Update(Product product)
        {
            using (var conetion = new SqlConnection(DatabaseConfige.ConnectionString))
            {
                conetion.Execute(ProductQueries.Update, new {product.Id, product.Name, product.Price, product.CategoryId });
            }
        }
    }
}
