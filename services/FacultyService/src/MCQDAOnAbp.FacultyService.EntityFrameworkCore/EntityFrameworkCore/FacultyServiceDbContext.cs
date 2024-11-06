using MCQDAOnAbp.FacultyService.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace MCQDAOnAbp.FacultyService.EntityFrameworkCore;

[ConnectionStringName(FacultyServiceDbProperties.ConnectionStringName)]
public class FacultyServiceDbContext :
    AbpDbContext<FacultyServiceDbContext>
{
    #region Entities from the modules
    public DbSet<Faculty> Faculties { get; set; }
    #endregion

    public FacultyServiceDbContext(DbContextOptions<FacultyServiceDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
