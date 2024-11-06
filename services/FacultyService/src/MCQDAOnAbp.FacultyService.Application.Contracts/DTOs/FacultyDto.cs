using System;
using Volo.Abp.Application.Dtos;

namespace MCQDAOnAbp.FacultyService.DTOs
{
    public class FacultyDto : AuditedEntityDto<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
