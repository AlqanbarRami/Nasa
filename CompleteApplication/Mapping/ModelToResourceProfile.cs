using AutoMapper;
using CompleteApplication.Domain.Models;
using CompleteApplication.Resources;

namespace CompleteApplication.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            this.CreateMap<Drone, DroneResource>();
        }
    }
}
