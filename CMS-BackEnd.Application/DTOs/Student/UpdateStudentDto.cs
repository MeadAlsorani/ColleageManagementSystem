using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.DTOs.Student
{
    public class UpdateStudentDto : CreateStudentDto
    {
        public int Id { get; set; }
    }
}
