using AutoMapper;
using MCQDAOnAbp.FacultyService.Entities;
using MCQDAOnAbp.FacultyService.ETOs;

namespace MCQDAOnAbp.FacultyService
{
    public class FacultyServiceDomainAutoMapperProfile : Profile
    {
        public FacultyServiceDomainAutoMapperProfile() 
        {
            CreateMap<Faculty, FacultyEto>();
        }
    }
}
