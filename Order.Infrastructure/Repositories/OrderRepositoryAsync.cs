using Microsoft.EntityFrameworkCore;
using Order.ApplicationCore.Contracts.Repositories;
using Order.ApplicationCore.Entities;
using Order.ApplicationCore.Model.Response;
using Order.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Infrastructure.Repositories
{
    public class OrderRepositoryAsync : BaseRepositoryAsync<order>, IOrderRepositoryAsync
    {
        private OrderDbContext _context;
        public OrderRepositoryAsync(OrderDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<order>> GetOrderByCustomerId(int customerId)
        {
            return await _context.Orders.Where(x => x.CustomerId == customerId).ToListAsync();
        }
    }
}
