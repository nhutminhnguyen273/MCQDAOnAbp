using MCQDAOnAbp.FacultyService.DTOs;
using MCQDAOnAbp.FacultyService.Entities;
using MCQDAOnAbp.FacultyService.Faculties.Queries;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace MCQDAOnAbp.FacultyService.Faculties.Handlers
{
    public class GetFacultyQueryHandler : IRequestHandler<GetFacultyQuery, FacultyDto>
    {
        private readonly IRepository<Faculty, Guid> _facultyRepository;
        private readonly IObjectMapper _objectMapper;

        public GetFacultyQueryHandler(IRepository<Faculty, Guid> facultyRepository, IObjectMapper objectMapper)
        {
            _facultyRepository = facultyRepository;
            _objectMapper = objectMapper;
        }

        public async Task<FacultyDto> Handle(GetFacultyQuery request, CancellationToken cancellationToken)
        {
            var faculty = await _facultyRepository.GetAsync(request.Id);
            if (faculty == null)
            {
                throw new ArgumentException($"Not found");
            }
            return _objectMapper.Map<Faculty, FacultyDto>(faculty);
        }
    }
}
