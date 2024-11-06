using MCQDAOnAbp.FacultyService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MCQDAOnAbp.FacultyService.Permissions;

public class FacultyServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FacultyServicePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(FacultyServicePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FacultyServiceResource>(name);
    }
}
