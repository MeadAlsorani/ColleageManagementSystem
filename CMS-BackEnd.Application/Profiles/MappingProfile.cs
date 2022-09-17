
using AutoMapper;
using CMS_BackEnd.Application.DTOs.Announcement;
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

            #region Student
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Student, CreateStudentDto>().ReverseMap();
            #endregion

            #region Staff
            CreateMap<Staff, StaffListDto>().ReverseMap();

            #endregion

            #region Attendance
            CreateMap<Attendance, AttendanceDto>().ReverseMap();
            #endregion

            #region Announcement
            CreateMap<Announcement, AnnouncementListDto>().ReverseMap();
            CreateMap<Announcement,AnnouncementRecordDto>().ReverseMap();
            #endregion
        }
    }
}
