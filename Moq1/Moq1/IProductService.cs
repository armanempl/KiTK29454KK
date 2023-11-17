using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moq1
{
    public interface IProductService
    {
        List<string> GetAvailableProducts();
        void AddNewProduct(string productName);
    }
}
