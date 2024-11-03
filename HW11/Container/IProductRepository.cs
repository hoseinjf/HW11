using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Container
{
    public interface IProductRepository
    {
        void Add();
        void Get(int id);
        void GetAll();
        void Update(int id);
        void Delete(int id);

    }
}
