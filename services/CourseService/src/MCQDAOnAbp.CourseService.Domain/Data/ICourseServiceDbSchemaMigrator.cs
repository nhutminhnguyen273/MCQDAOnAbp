using System.Threading.Tasks;

namespace MCQDAOnAbp.CourseService.Data;

public interface ICourseServiceDbSchemaMigrator
{
    Task MigrateAsync();
}
