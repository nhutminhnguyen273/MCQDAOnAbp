using MCQDAOnAbp.FacultyService.DTOs;
using MediatR;
using System;

namespace MCQDAOnAbp.FacultyService.Faculties.Queries
{
    public class GetFacultyQuery : IRequest<FacultyDto>
    {
        public Guid Id { get; set; }
    }
}
