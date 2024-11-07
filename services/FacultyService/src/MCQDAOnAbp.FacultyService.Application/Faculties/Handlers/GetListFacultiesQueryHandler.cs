using MCQDAOnAbp.FacultyService.DTOs;
using MCQDAOnAbp.FacultyService.Entities;
using MCQDAOnAbp.FacultyService.Faculties.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace MCQDAOnAbp.FacultyService.Faculties.Handlers
{
    public class GetListFacultiesQueryHandler : IRequestHandler<GetListFacultiesQuery, ListResultDto<FacultyDto>>
    {
        private readonly IRepository<Faculty, Guid> _facultyRepository;
        private readonly IObjectMapper _objectMapper;

        public GetListFacultiesQueryHandler(IRepository<Faculty, Guid> facultyRepository, IObjectMapper objectMapper)
        {
            _facultyRepository = facultyRepository;
            _objectMapper = objectMapper;
        }

        public async Task<ListResultDto<FacultyDto>> Handle(GetListFacultiesQuery request, CancellationToken cancellationToken)
        {
            var faculties = await _facultyRepository.GetListAsync();
            return new ListResultDto<FacultyDto>(_objectMapper.Map<List<Faculty>, List<FacultyDto>>(faculties));
        }
    }
}
