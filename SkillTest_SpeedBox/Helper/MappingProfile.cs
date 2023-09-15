using SkillTest_SpeedBox.Dto;
using SkillTest_SpeedBox.Models;
using MapProfile = AutoMapper.Profile;

namespace SkillTest_SpeedBox.Helper
{
    public class MappingProfile : MapProfile
    {
        public MappingProfile()
        {
            CreateMap<OrderDTO, Order>().ReverseMap();
        }
    }
}
