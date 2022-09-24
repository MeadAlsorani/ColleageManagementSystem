using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.SessionYear.Handlers
{
    public class BaseRequestHandler
    {
        public readonly ISessionYearRepository repository;
        public readonly IMapper mapper;

        public BaseRequestHandler(ISessionYearRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
    }
}
