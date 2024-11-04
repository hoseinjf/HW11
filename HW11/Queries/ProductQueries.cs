using HW11.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Queries
{
    public static class ProductQueries
    {
        public static string Add = "insert into Products(Name,Price,CategoryId)values(@Name,@Price,@CategoryId)";
        //public static string Get = "select* from Products p join Categories on Categories.Id=CategoryId where Id=@id";
        public static string Get = "select* from Products where Id=@id";
        //public static string GetAll = "select Products.Id,Products.Name,Products.Price,Categories.Name from Products  join Categories on Categories.Id=Products.CategoryId";
        public static string GetAll = "select * from Products ";
        public static string Delete = "delete Products WHERE Id = @id";
        public static string Update = "UPDATE Products SET Name=@Name , Price=@Price , CategoryId=@CategoryId WHERE Id = @Id";


    }
}
