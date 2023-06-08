using HW5._5_ShayanMadahi_mk97.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._5_ShayanMadahi_mk97.Interface
{
    public interface IStockRepository
    {
        string SaleProduct(int productId, int cnt);
        string BuyProduct(Stock productInStock);
     //   List<SockProductViewModel> GetSalesProductList();
    }
}
