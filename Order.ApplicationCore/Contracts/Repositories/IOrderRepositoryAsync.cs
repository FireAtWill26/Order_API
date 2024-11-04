using Order.ApplicationCore.Entities;
using Order.ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.ApplicationCore.Contracts.Repositories
{
    public interface IOrderRepositoryAsync: IRepositoryAsync<order>
    {
        Task<IEnumerable<order>> GetOrderByCustomerId(int customerId);
    }
}
