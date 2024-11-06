using MCQDAOnAbp.FacultyService.DTOs;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MCQDAOnAbp.FacultyService.AppServices
{
    public class FacultyAppService : ApplicationService, IFacultyAppService
    {
        public Task<FacultyDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ListResultDto<FacultyDto>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<FacultyDto>> GetListPagedAsync(PagedAndSortedResultRequestDto input)
        {
            throw new NotImplementedException();
        }
    }
}
