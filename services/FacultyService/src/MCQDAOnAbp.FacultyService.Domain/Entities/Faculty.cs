using JetBrains.Annotations;
using MCQDAOnAbp.FacultyService.Consts;
using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities;

namespace MCQDAOnAbp.FacultyService.Entities
{
    public class Faculty : AggregateRoot<Guid>
    {
        [NotNull]
        public string Code { get; set; }
        [NotNull]
        public string Name { get; set; }

        public Faculty() { }

        public Faculty(Guid id, [NotNull] string code, [NotNull] string name)
        {
            Check.NotNullOrWhiteSpace(code, nameof(code));
            if (code.Length > FacultyConsts.MaxCodeLength)
            {
                throw new ArgumentException($"Faculty code can not be longer than {FacultyConsts.MaxCodeLength}");
            }
            Id = id;
            Code = code;
            SetName(name);
        }

        public Faculty SetName([NotNull] string name)
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));
            if (name.Length > FacultyConsts.MaxNameLength)
            {
                throw new ArgumentException($"Faculty name can not be longer than {FacultyConsts.MaxNameLength}");
            }
            Name = name;
            return this;
        }
    }
}
