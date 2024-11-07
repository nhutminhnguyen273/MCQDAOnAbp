using MCQDAOnAbp.FacultyService.DTOs;
using MCQDAOnAbp.FacultyService.Faculties.Queries;
using MediatR;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MCQDAOnAbp.FacultyService.AppServices
{
    public class FacultyAppService : ApplicationService, IFacultyAppService
    {
        private readonly IMediator _mediator;

        public FacultyAppService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<FacultyDto> GetAsync(Guid id)
        {
            return await _mediator.Send(new GetFacultyQuery { Id = id });
        }

        public async Task<ListResultDto<FacultyDto>> GetListAsync()
        {
            return await _mediator.Send(new GetListFacultiesQuery { });
        }

        public async Task<PagedResultDto<FacultyDto>> GetListPagedAsync(PagedAndSortedResultRequestDto input)
        {
            return await _mediator.Send(ObjectMapper.Map < PagedAndSortedResultRequestDto, GetListPagedFacultyQuery>(input));
        }
    }
}
