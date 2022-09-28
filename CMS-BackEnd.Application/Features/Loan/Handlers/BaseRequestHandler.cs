using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Loan.Handlers
{
    public class BaseRequestHandler
    {
        public readonly ILoanRepository repository;
        public readonly IMapper mapper;

        public BaseRequestHandler(ILoanRepository repo, IMapper mapper)
        {
            this.repository = repo;
            this.mapper = mapper;
        }
    }
}
