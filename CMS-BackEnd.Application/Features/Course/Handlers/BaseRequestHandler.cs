using AutoMapper;
using CMS_BackEnd.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Course.Handlers
{
    public class BaseRequestHandler
    {
        public readonly ICourseRepository repository;
        public readonly IMapper mapper;

        public BaseRequestHandler(ICourseRepository repo, IMapper mapper)
        {
            this.repository = repo;
            this.mapper = mapper;
        }
    }
}
