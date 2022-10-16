using CMS_BackEnd.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.SalaryTemplate.Requests.Queries
{
    public class GetSalaryTemplateRequest : IRequest<Domain.SalaryTemplate>
    {
        public int Id { get; set; }
    }
}
