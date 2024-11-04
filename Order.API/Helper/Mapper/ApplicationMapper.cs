using AutoMapper;
using Order.ApplicationCore.Entities;
using Order.ApplicationCore.Model.Request;
using Order.ApplicationCore.Model.Response;

namespace Order.API.Helper.Mapper
{
    public class ApplicationMapper: Profile
    {
        public ApplicationMapper() 
        {
            CreateMap<order, OrderRequestModel>().ReverseMap();
            CreateMap<order, OrderResponseModel>().ReverseMap();
        }
    }
}
