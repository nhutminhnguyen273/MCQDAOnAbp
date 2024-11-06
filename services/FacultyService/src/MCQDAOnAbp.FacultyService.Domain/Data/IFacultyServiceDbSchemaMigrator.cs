using System.Threading.Tasks;

namespace MCQDAOnAbp.FacultyService.Data;

public interface IFacultyServiceDbSchemaMigrator
{
    Task MigrateAsync();
}
