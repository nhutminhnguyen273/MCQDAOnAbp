﻿using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace MCQDAOnAbp.IdentityService;

[DependsOn(
    typeof(IdentityServiceDomainSharedModule),
    typeof(AbpIdentityDomainModule)
)]
public class IdentityServiceDomainModule : AbpModule
{
}
