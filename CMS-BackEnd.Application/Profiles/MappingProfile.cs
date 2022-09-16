
using AutoMapper;
using CMS_BackEnd.Application.DTOs.Attendance;
using CMS_BackEnd.Application.DTOs.Staff;
using CMS_BackEnd.Application.DTOs.Student;
using CMS_BackEnd.Domain;

namespace CMS_BackEnd.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Staff, StaffListDto>().ReverseMap();
            CreateMap<Attendance, AttendanceDto>().ReverseMap();
        }
    }
}
