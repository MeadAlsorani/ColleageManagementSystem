using CMS_BackEnd.Application.DTOs.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Dashboard.Requests
{
    public class CountsRequest : IRequest<CountsResponse>
    {
    }
}
