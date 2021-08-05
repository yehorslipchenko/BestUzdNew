using BestUzdNew.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BestUzdNew.Logic
{
    public interface IOrderService
    {
        Task CreateOrderAsync(Order order);
        Task<ICollection<Order>> GetOrdersAsync();
    }
}
