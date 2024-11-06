using MCQDAOnAbp.ExamResultService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MCQDAOnAbp.ExamResultService.Permissions;

public class ExamResultServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ExamResultServicePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ExamResultServicePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ExamResultServiceResource>(name);
    }
}
