using AutoMapper;
using Order.ApplicationCore.Contracts.Repositories;
using Order.ApplicationCore.Contracts.Services;
using Order.ApplicationCore.Entities;
using Order.ApplicationCore.Model.Request;
using Order.ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Infrastructure.Services
{
    public class OrderServiceAsync : IOrderServiceAsync
    {
        private readonly IOrderRepositoryAsync orderRepositoryAsync;
        private readonly IMapper mapper;

        public OrderServiceAsync(IOrderRepositoryAsync orderRepositoryAsync, IMapper mapper)
        {
            this.orderRepositoryAsync = orderRepositoryAsync;
            this.mapper = mapper;
        }

        public async Task<int> DeleteOrder(int id)
        {
            return await orderRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<OrderResponseModel>> GetAllAsync()
        {
            return mapper.Map<IEnumerable<OrderResponseModel>>(await orderRepositoryAsync.GetAllAsync());
        }

        public async Task<OrderResponseModel> GetOrderById(int id)
        {
            return mapper.Map<OrderResponseModel>(await orderRepositoryAsync.GetByIdAsync(id));
        }

        public async Task<int> InsertOrder(OrderRequestModel model)
        {
            var result = mapper.Map<order>(model);
            return await orderRepositoryAsync.InsertAsync(result);
        }

        public async Task<int> UpdateOrder(OrderRequestModel model, int id)
        {
            if (id == model.Id)
            {
                var result = mapper.Map<order>(model);
                return await orderRepositoryAsync.UpdateAsync(result);
            }
            return 0;
        }

        public async Task<IEnumerable<OrderResponseModel>> GetOrderByCustomerId(int customerId)
        {
            return mapper.Map<IEnumerable<OrderResponseModel>>(await orderRepositoryAsync.GetOrderByCustomerId(customerId));
        }
    }
}
