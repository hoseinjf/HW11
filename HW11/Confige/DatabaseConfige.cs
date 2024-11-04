using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Confige
{
    public static class DatabaseConfige
    {
        public static string ConnectionString { get; set; }
        static DatabaseConfige()
        {
            ConnectionString = @"Server=DESKTOP-1MKPIBC;Database=ShopDb;Integrated Security=True;TrustServerCertificate=True;";
        }
    }
}
