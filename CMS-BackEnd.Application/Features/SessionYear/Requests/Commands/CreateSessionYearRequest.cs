using CMS_BackEnd.Application.DTOs.SessionYear;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.SessionYear.Requests.Commands
{
    public class CreateSessionYearRequest : IRequest<Unit>
    {
        public CreateSessionYearDto data { get; set; }
    }
}
