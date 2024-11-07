using MCQDAOnAbp.FacultyService.DTOs;
using MCQDAOnAbp.FacultyService.Entities;
using MCQDAOnAbp.FacultyService.Faculties.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace MCQDAOnAbp.FacultyService.Faculties.Handlers
{
    public class GetListPagedFacultyQueryHandler : IRequestHandler<GetListPagedFacultyQuery, PagedResultDto<FacultyDto>>
    {
        private readonly IRepository<Faculty, Guid> _facultyRepository;
        private readonly IObjectMapper _objectMapper;

        public GetListPagedFacultyQueryHandler(IRepository<Faculty, Guid> facultyRepository, IObjectMapper objectMapper)
        {
            _facultyRepository = facultyRepository;
            _objectMapper = objectMapper;
        }

        public async Task<PagedResultDto<FacultyDto>> Handle(GetListPagedFacultyQuery request, CancellationToken cancellationToken)
        {
            var queryable = await _facultyRepository.GetQueryableAsync();
            var faculties = await queryable
                .OrderBy(request.Sorting ?? "Name")
                .Skip(request.SkipCount)
                .Take(request.MaxResultCount)
                .ToListAsync(cancellationToken);
            var totalCount = await _facultyRepository.GetCountAsync();
            return new PagedResultDto<FacultyDto>(
                totalCount,
                _objectMapper.Map<List<Faculty>, List<FacultyDto>>(faculties)
            );
        }
    }
}
