using AutoMapper;
using TravelTogether.Models;
using TravelTogether.ViewModels.Account;

namespace TravelTogether
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            this.CreateMap<RegisterInputModel, TtUser>();
            this.CreateMap<TtUser, MyProfileViewModel>()
                .ForMember(dest => dest.Images, opt => opt.Ignore());
        }
    }
}
