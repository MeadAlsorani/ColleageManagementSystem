using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.OutcomeTransaction.Handlers
{
    public class BaseRequestHandler
    {
        public readonly IOutcomeTransactionRepository repository;
        public readonly IMapper mapper;

        public BaseRequestHandler(IOutcomeTransactionRepository repo, IMapper mapper)
        {
            this.repository = repo;
            this.mapper = mapper;
        }
    }
}
