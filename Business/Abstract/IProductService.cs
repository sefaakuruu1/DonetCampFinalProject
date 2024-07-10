using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategoryId(int CategoryId);
        List<Product> GetByUnitPrice(decimal min,decimal max);
        Product GetByProductId(int ProductId);
    }
}
