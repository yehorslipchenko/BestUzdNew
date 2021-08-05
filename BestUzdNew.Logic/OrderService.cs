using BestUzdNew.DataAccess;
using BestUzdNew.Domain.Entities;
using BestUzdNew.Logic;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BestUzdNew.Logic
{
    class OrderService : IOrderService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public OrderService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task CreateOrderAsync(Order order)
        {
            using (var uow = _unitOfWorkFactory.UnitOfWork)
            {
                uow.GetRepository<Order>().Create(order);
                await uow.SaveChangesAsync();
            }
        }

        public async Task<ICollection<Order>> GetOrdersAsync()
        {
            using (var uow = _unitOfWorkFactory.UnitOfWork)
            {
                return await uow.GetRepository<Order>()
                             .Query
                             .ToListAsync();
            }
        }
    }
}
