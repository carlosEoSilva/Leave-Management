using AutoMapper;
using LeaveManagementSystem.Models.LeaveTypes;

namespace LeaveManagementSystem.Data.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //note-6
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
            //.ForMember(dest => dest.Days, opt => opt.MapFrom(src => src.NumberOfDays));

            CreateMap<LeaveTypeCreateVM, LeaveType>();//note-7

            CreateMap<LeaveType, LeaveTypeEditVM>().ReverseMap();//note-10
        }
    }
}
