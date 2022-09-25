using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Student.Handlers
{
    public class BaseRequestHandler
    {
        public readonly IStudentRepository repository;
        public readonly IMapper mapper;

        public BaseRequestHandler(IStudentRepository repo, IMapper mapper)
        {
            this.repository = repo;
            this.mapper = mapper;
        }
    }
}
