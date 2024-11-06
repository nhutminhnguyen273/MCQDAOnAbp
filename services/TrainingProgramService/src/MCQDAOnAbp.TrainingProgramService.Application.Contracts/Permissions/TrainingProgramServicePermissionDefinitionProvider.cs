using MCQDAOnAbp.TrainingProgramService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MCQDAOnAbp.TrainingProgramService.Permissions;

public class TrainingProgramServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TrainingProgramServicePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TrainingProgramServicePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TrainingProgramServiceResource>(name);
    }
}
