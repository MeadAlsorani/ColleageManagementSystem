using CMS_BackEnd.Application.DTOs.Staff;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Staff.Requests.Commands
{
    public class UpdateStaffRequest:IRequest<Unit>
    {
        public UpdateStaffDto Staff { get; set; }
    }
}
