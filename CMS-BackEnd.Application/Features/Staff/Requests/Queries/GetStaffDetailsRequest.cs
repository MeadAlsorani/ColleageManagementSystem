using CMS_BackEnd.Application.DTOs.Staff;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Staff.Requests.Queries
{
    public class GetStaffDetailsRequest:IRequest<StaffDetailsDto>
    {
        public int Id { get; set; }
    }
}
