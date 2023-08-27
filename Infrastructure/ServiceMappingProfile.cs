using AutoMapper;
using oldCapitalWeb.Data.Models;
using oldCapitalWeb.Models;

namespace oldCapitalWeb.Infrastructure
{
    public class ServiceMappingProfile : Profile
    {
        public ServiceMappingProfile()
        {
            this.CreateMap<FaQ, FaQViewModel>();
        }
    }
}
