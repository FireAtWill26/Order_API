using Microsoft.EntityFrameworkCore;
using Order.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Infrastructure.Data
{
    public class OrderDbContext: DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> context): base(context)
        {

        }
        public DbSet<order> Orders { get; set; }
        public DbSet<Order_Detail> Order_Details { get; set; }
    }
}
