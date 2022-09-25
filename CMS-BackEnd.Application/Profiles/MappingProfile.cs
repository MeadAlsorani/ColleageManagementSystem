
using AutoMapper;
using CMS_BackEnd.Application.DTOs.Announcement;
using CMS_BackEnd.Application.DTOs.Attendance;
using CMS_BackEnd.Application.DTOs.Course;
using CMS_BackEnd.Application.DTOs.SessionYear;
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
            CreateMap<Student, CreateStudentDto>().ForMember(dest => dest.StudentCoursesIds, opt =>
            {
                opt.MapFrom((src, dest) =>
                {
                    return dest.StudentCoursesIds = src.StudentCourses.Select(x => x.CourseId).ToList();
                });
            })
                .ReverseMap().ForMember(dest => dest.StudentCourses, opt =>
            {
                opt.MapFrom((src, dest) =>
                {
                    foreach (int id in src.StudentCoursesIds)
                    {
                        dest.StudentCourses.Add(new StudentCourse
                        {
                            CourseId = id
                        });
                    }
                    return dest;
                });
            });
            CreateMap<Student, UpdateStudentDto>().ForMember(dest => dest.StudentCoursesIds, opt =>
            {
                opt.MapFrom(src => src.StudentCourses.Select(x => x.CourseId));
            })
                .ReverseMap()
                .ForMember(dest => dest.StudentCourses, opt =>
                {
                    opt.MapFrom((src, dest) =>
                    {
                        foreach (int id in src.StudentCoursesIds)
                        {
                            dest.StudentCourses.Add(new StudentCourse
                            {
                                CourseId = id,
                                StudentId = src.Id
                            });
                        }
                        return dest;
                    });
                });
            #endregion

            #region Staff
            CreateMap<Staff, StaffListDto>().ReverseMap();

            #endregion

            #region Attendance
            CreateMap<Attendance, StaffAttendanceDto>().ReverseMap();
            CreateMap<Attendance, StudentAttendanceDto>().ReverseMap();
            CreateMap<Attendance, AttendancesListDto>()
                .ForMember(dest => dest.Name, opt =>
                {
                    opt.MapFrom((src, dest) =>
                    {
                        if (src.Staff != null)
                        {
                            dest.Type = AttendanceType.Staff;
                            return $"{src.Staff?.FirstName} {src.Staff?.LastName}";
                        }
                        else if (src.Student != null)
                        {
                            dest.Type = AttendanceType.Student;
                            return $"{src.Student?.FirstName} {src.Student?.LastName}";
                        }
                        return "";
                    });
                });
            #endregion

            #region Announcement
            CreateMap<Announcement, AnnouncementListDto>().ReverseMap();
            CreateMap<Announcement, AnnouncementRecordDto>().ReverseMap();
            #endregion

            #region Course
            CreateMap<Course, CourseDetailsDto>().ReverseMap();
            CreateMap<Course, CourseListDto>().ReverseMap();
            CreateMap<Course, CreateCourseDto>()
                .ForMember(dest => dest.TeacherId, opt => opt.MapFrom(src => src.StaffId))
                .ReverseMap();
            #endregion

            #region SessionYear
            CreateMap<SessionYear, UpdateSessionYearDto>().ReverseMap();
            CreateMap<SessionYear, CreateSessionYearDto>().ReverseMap();
            CreateMap<SessionYear, SessionYearListDto>().ReverseMap();
            #endregion

            #region Staff
            CreateMap<CreateStaffDto, Staff>().ReverseMap();
            CreateMap<StaffDetailsDto, Staff>().ReverseMap();
            CreateMap<StaffListDto, Staff>().ReverseMap();
            CreateMap<UpdateStaffDto, Staff>().ReverseMap();
            #endregion

        }
    }
}
