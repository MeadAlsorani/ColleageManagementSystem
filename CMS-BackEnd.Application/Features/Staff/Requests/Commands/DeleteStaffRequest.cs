using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Staff.Requests.Commands
{
    public class DeleteStaffRequest:IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
