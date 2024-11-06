using AutoMapper;
using MCQDAOnAbp.FacultyService.DTOs;
using MCQDAOnAbp.FacultyService.Entities;

namespace MCQDAOnAbp.FacultyService;

public class FacultyServiceApplicationAutoMapperProfile : Profile
{
    public FacultyServiceApplicationAutoMapperProfile()
    {
        CreateMap<Faculty, FacultyDto>();
    }
}
