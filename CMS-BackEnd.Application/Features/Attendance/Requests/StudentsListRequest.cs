using CMS_BackEnd.Application.DTOs.Student;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Attendance.Requests
{
    public class StudentsListRequest:IRequest<List<StudentDto>>
    {
    }
}
