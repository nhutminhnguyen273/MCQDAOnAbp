using MCQDAOnAbp.FacultyService.DTOs;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MCQDAOnAbp.FacultyService.AppServices
{
    public interface IFacultyAppService : IApplicationService
    {
        Task<PagedResultDto<FacultyDto>> GetListPagedAsync(PagedAndSortedResultRequestDto input);
        Task<ListResultDto<FacultyDto>> GetListAsync();
        Task<FacultyDto> GetAsync(Guid id);
    }
}
