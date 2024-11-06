using MCQDAOnAbp.FacultyService.DTOs;
using MediatR;
using Volo.Abp.Application.Dtos;

namespace MCQDAOnAbp.FacultyService.Faculties.Queries
{
    public class GetListPagedFacultyQuery : PagedAndSortedResultRequestDto, IRequest<PagedResultDto<FacultyDto>>
    {
    }
}
