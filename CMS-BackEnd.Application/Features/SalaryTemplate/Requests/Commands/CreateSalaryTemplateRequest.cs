using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.SalaryTemplate.Requests.Commands
{
    public class CreateSalaryTemplateRequest:IRequest<Unit>
    {
        public Domain.SalaryTemplate SalaryTemplate { get; set; }
    }
}
