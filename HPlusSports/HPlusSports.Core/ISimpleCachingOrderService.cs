using System.Collections.Generic;
using System.Threading.Tasks;
using HPlusSports.Models;

namespace HPlusSports.Core
{
    public interface ISimpleCachingOrderService
    {
        Task<IList<Order>> GetCustomerOrders(int CustomerId);
        Task<IList<Order>> GetOrdersWithCustomers();
        Task<Order> CreateOrder(int CustomerId, int SalesPersonId, IEnumerable<string> ProductCodes);        
    }
}