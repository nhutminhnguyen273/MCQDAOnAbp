using Grpc.Core;
using MCQDAOnAbp.FacultyService.Entities;
using MediatR;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace MCQDAOnAbp.FacultyService.Grpc;

public class FacultyGrpService : FacultyPublic.FacultyPublicBase
{
    private IRepository<Faculty, Guid> _facultyRepository;
    private readonly IObjectMapper _objectMapper;

    public FacultyGrpService(IRepository<Faculty, Guid> facultyRepository, IObjectMapper objectMapper)
    {
        _facultyRepository = facultyRepository;
        _objectMapper = objectMapper;
    }

    public override async Task<FacultyResponse> GetById(FacultyRequest request, ServerCallContext context)
    {
        var faculty = await _facultyRepository.GetAsync(Guid.Parse(request.Id));
        return _objectMapper.Map<Faculty, FacultyResponse>(faculty);
    }
}
