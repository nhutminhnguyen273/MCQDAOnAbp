using MCQDAOnAbp.FacultyService.EntityFrameworkCore;
using MCQDAOnAbp.Shared.Hosting.Microservices.DbMigrations.EfCore;
using System;
using Volo.Abp.DistributedLocking;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Uow;

namespace MCQDAOnAbp.FacultyService.DbMigrations;

public class FacultyServiceDatabaseMigrationChecker : PendingEfCoreMigrationsChecker<FacultyServiceDbContext>
{
    public FacultyServiceDatabaseMigrationChecker(
       IUnitOfWorkManager unitOfWorkManager,
       IServiceProvider serviceProvider,
       ICurrentTenant currentTenant,
       IDistributedEventBus distributedEventBus,
       IAbpDistributedLock distributedLockProvider)
    : base(
        unitOfWorkManager,
        serviceProvider,
        currentTenant,
        distributedEventBus,
        distributedLockProvider,
        FacultyServiceDbProperties.ConnectionStringName)
    {
    }
}