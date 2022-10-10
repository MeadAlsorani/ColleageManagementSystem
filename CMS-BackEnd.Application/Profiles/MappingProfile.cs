
using AutoMapper;
using CMS_BackEnd.Application.DTOs.Announcement;
using CMS_BackEnd.Application.DTOs.Attendance;
using CMS_BackEnd.Application.DTOs.Course;
using CMS_BackEnd.Application.DTOs.IncomingTransaction;
using CMS_BackEnd.Application.DTOs.Loan;
using CMS_BackEnd.Application.DTOs.OutcomeTransaction;
using CMS_BackEnd.Application.DTOs.SessionYear;
using CMS_BackEnd.Application.DTOs.Staff;
using CMS_BackEnd.Application.DTOs.Student;
using CMS_BackEnd.Domain;
using CMS_BackEnd.Resources;
using Microsoft.Extensions.Localization;

namespace CMS_BackEnd.Application.Profiles
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {

            #region Student
            CreateMap<Student, StudentDto>()
                .ForMember(dest => dest.FullName, opt =>
                {
                    opt.MapFrom(src => $"{src.FirstName} {src.LastName}");
                })
                .ReverseMap();
            CreateMap<Student, CreateStudentDto>().ForMember(dest => dest.StudentCoursesIds, opt =>
            {
                opt.MapFrom((src, dest) =>
                {
                    return dest.StudentCoursesIds = src.StudentCourses.Select(x => x.CourseId).ToList();
                });
            });
            CreateMap<CreateStudentDto, Student>().ForMember(dest => dest.StudentCourses, opt =>
             {
                 opt.MapFrom((src, dest) =>
                 {
                     if (src.StudentCoursesIds != null)
                     {
                         foreach (int id in src.StudentCoursesIds)
                         {
                             dest.StudentCourses.Add(new StudentCourse
                             {
                                 CourseId = id
                             });
                         }
                     }
                     return dest.StudentCourses;
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
                           dest.Type = AttendanceType.Staff.ToString();
                           return $"{src.Staff?.FirstName} {src.Staff?.LastName}";
                       }
                       else if (src.Student != null)
                       {
                           dest.Type = AttendanceType.Student.ToString();
                           return $"{src.Student?.FirstName} {src.Student?.LastName}";
                       }
                       return "";
                   });
               })
               .ForMember(dest => dest.Type, opt =>
               {
                   opt.MapFrom<TranslationResolver, string>(src => src.Staff != null ? "Staff" : "Student");

               });
            CreateMap<CreateAttendanceDto, Attendance>()
                .ForAllMembers(opt =>
                {
                    opt.MapFrom((src, dest) =>
                    {
                        if (src.Type == AttendanceType.Staff)
                        {
                            dest.StaffId = src.StaffStudentId;
                        }
                        else
                        {
                            dest.StudentId = src.StaffStudentId;
                        }
                        return dest;
                    });
                });
            CreateMap<Attendance, CreateAttendanceDto>().ForMember(dest => dest.Type, opt =>
            {
                opt.MapFrom((src, dest) =>
                {
                    AttendanceType value;
                    if (src.StudentId != null)
                    {
                        value = AttendanceType.Student;
                        dest.StaffStudentId = (int)src.StudentId;
                    }
                    else
                    {
                        value = AttendanceType.Staff;
                        dest.StaffStudentId = (int)src.StaffId!;
                    }
                    return value;
                });
            });
            #endregion

            #region Announcement
            CreateMap<Announcement, AnnouncementListDto>().ForMember(dest => dest.Type, opt =>
            {
                opt.MapFrom<TranslationResolver, string>(src => src.Type.ToString());
            });
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
            CreateMap<StaffListDto, Staff>()
                .ReverseMap()
                .ForMember(dest => dest.FullName, opt =>
                {
                    opt.MapFrom((src, dest) =>
                    {
                        dest.FullName = $"{src.FirstName} {src.LastName}";
                        return $"{src.FirstName} {src.LastName}";
                    });
                });
            CreateMap<UpdateStaffDto, Staff>().ReverseMap();
            #endregion

            #region Outcome
            CreateMap<OutcomeTransaction, CreateOutcomeTransactionDto>().ReverseMap();
            CreateMap<OutcomeTransaction, UpdateOutcomeTransactionDto>().ReverseMap();
            CreateMap<OutcomeTransaction, OutcomeDetailsDto>();
            CreateMap<OutcomeTransaction, OutcomeListDto>().ForMember(dest => dest.Type, opt =>
             {
                 opt.MapFrom(src => Enum.GetName(typeof(OutcomeType), src.Type));
             }).ForMember(dest => dest.Description, opt =>
             {
                 opt.MapFrom((src, dest) =>
                 {
                     string Desc = "";
                     if (src.Type == OutcomeType.Salary)
                     {
                         Desc = dest.Description = $"{src.Staff?.FirstName} {src.Staff?.LastName} - {src.Description}";
                     }
                     else
                     {
                         Desc = dest.Description = src.Description;
                     }
                     return Desc;
                 });
             });
            #endregion

            #region Loan
            CreateMap<Loan, CreateLoanDto>().ReverseMap();
            CreateMap<Loan, LoanRecordDto>().ReverseMap();
            CreateMap<Loan, LoanListDto>().ReverseMap();
            CreateMap<Loan, UpdateLoanDto>().ReverseMap();
            #endregion

            #region IncomeTransaction
            CreateMap<IncomeTransaction, CreateIncomingTransactionDto>().ReverseMap();
            CreateMap<IncomeTransaction, UpdateIncomingTransactionDto>().ReverseMap();
            CreateMap<IncomeTransaction, IncomingTransactionDetailsDto>().ReverseMap();
            CreateMap<IncomeTransaction, IncomingTransactionsListDto>()
                .ForMember(dest => dest.CourseName, opt =>
                {
                    opt.MapFrom((src, dest) =>
                    {
                        return src.Course?.Name;
                    });
                })
                .ForMember(dest => dest.StudentName, opt =>
                {
                    opt.MapFrom((src, dest) =>
                    {
                        return $"{src.Student?.FirstName} {src.Student?.LastName}";
                    });
                })
                .ReverseMap();
            CreateMap<IncomeTransaction, StudentIncomingTransactionsDto>()
                .ForMember(dest => dest.CourseName, opt =>
                {
                    opt.MapFrom((src, dest) =>
                    {
                        return src.Course?.Name;
                    });
                });
            #endregion

        }
    }
    public class TranslationResolver : IMemberValueResolver<object, object, string, string>
    {
        private readonly IStringLocalizer<Resource> localizer;

        public TranslationResolver(IStringLocalizer<Resource> localizer)
        {
            this.localizer = localizer;
        }
        public string Resolve(object source, object destination, string sourceMember, string destMember, ResolutionContext context)
        {
            return localizer[sourceMember];
        }
    }
}
