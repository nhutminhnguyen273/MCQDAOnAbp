﻿using MCQDAOnAbp.CourseService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MCQDAOnAbp.CourseService.Permissions;

public class CourseServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CourseServicePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CourseServicePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CourseServiceResource>(name);
    }
}
