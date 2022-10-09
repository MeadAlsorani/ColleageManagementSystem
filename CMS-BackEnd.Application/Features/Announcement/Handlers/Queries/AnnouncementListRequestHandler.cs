using AutoMapper;
using CMS_BackEnd.Application.Contracts.Features;
using CMS_BackEnd.Application.DTOs.Announcement;
using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.Features.Announcement.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_BackEnd.Application.Features.Announcement.Handlers.Queries
{
    public class AnnouncementListRequestHandler : BaseRequestHandler, IRequestHandler<AnnouncementListRequest, PaginationResponse<AnnouncementListDto>>
    {

        public AnnouncementListRequestHandler(IAnnouncementRepository announcement, IMapper mapper) : base(announcement, mapper)
        {
        }
        public async Task<PaginationResponse<AnnouncementListDto>> Handle(AnnouncementListRequest request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Domain.Announcement> records;
            PaginationResponse<AnnouncementListDto> paginationResponse = new DTOs.Common.PaginationResponse<AnnouncementListDto>();
            if (request.request != null)
            {
                var paginationResult = await announcement.GetAllWithPagination(request.request);
                records = paginationResult.Records;
                var result = mapper.Map<IReadOnlyList<AnnouncementListDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = paginationResult.Count;
            }
            else
            {
                records = await announcement.GetAll();
                var result = mapper.Map<IReadOnlyList<AnnouncementListDto>>(records);
                paginationResponse.Records = result;
                paginationResponse.Count = result.Count;
            }
            return paginationResponse;
        }
    }
}
