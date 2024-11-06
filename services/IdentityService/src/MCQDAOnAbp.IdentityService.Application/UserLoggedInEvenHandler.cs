using MCQDAOnAbp.IdentityService.ETOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.Identity;
using Volo.Abp.Uow;
using Volo.Abp;
using System.Linq;
using Volo.Abp.Domain.Repositories;

namespace MCQDAOnAbp.IdentityService;

public class UserLoggedInEventHandler : IDistributedEventHandler<UserLoggedInEto>, ITransientDependency
{
    private readonly IdentityUserManager _userManager;
    private readonly ILogger<UserLoggedInEventHandler> _logger;
    private readonly IIdentityUserRepository _identityUserRepository;
    private readonly ILookupNormalizer _lookupNormalizer;

    public UserLoggedInEventHandler(IdentityUserManager userManager,
        ILogger<UserLoggedInEventHandler> logger,
        IIdentityUserRepository identityUserRepository,
        ILookupNormalizer lookupNormalizer)
    {
        _userManager = userManager;
        _logger = logger;
        _identityUserRepository = identityUserRepository;
        _lookupNormalizer = lookupNormalizer;
    }

    [UnitOfWork]
    public virtual async Task HandleEventAsync(UserLoggedInEto eventData)
    {
        if (eventData == null)
        {
            _logger.LogWarning($"Handling UserLoggedInEvent failed! No user information found!");
            return;
        }

        var user = await _userManager.FindByIdAsync(eventData.Id.ToString());

        if (user == null)
        {
            await CreateCurrentUserAsync(eventData);
        }
        else
        {
            await UpdateCurrentUserAsync(user, eventData);
        }
    }

    protected virtual async Task CreateCurrentUserAsync(UserLoggedInEto userInfo)
    {
        var user = new IdentityUser(
            userInfo.Id,
            userInfo.UserName,
            userInfo.Email);

        user.SetEmailConfirmed(userInfo.IsEmailVerified);

        if (!string.IsNullOrEmpty(userInfo.Phone))
        {
            user.SetPhoneNumber(userInfo.Phone, false);
        }

        if (userInfo.UserName == "admin")
        {
            var normalizedName = _lookupNormalizer.NormalizeName(userInfo.UserName);
            var adminUser = await _identityUserRepository.FindByNormalizedUserNameAsync(normalizedName);
            foreach (var role in adminUser.Roles.ToList())
            {
                user.AddRole(role.RoleId);
            }

            await _identityUserRepository.HardDeleteAsync(adminUser, true);
        }

        var result = await _userManager.CreateAsync(user);

        if (!result.Succeeded)
        {
            throw new AbpException(string.Join('\n', result.Errors));
        }

        _logger.LogInformation($"Handling UserLoggedInEvent... Created new user with Id:{userInfo.Id}");
    }

    protected virtual async Task UpdateCurrentUserAsync(IdentityUser user, UserLoggedInEto userInfo)
    {
        if (user.Email != userInfo.Email)
        {
            _logger.LogInformation($"Handling UserLoggedInEvent... Updating the user email with:{userInfo.Email}");
            await _userManager.SetEmailAsync(user, userInfo.Email);
        }

        if (user.PhoneNumber != userInfo.Phone)
        {
            _logger.LogInformation(
                $"Handling UserLoggedInEvent... Updating the user phone with:{userInfo.Phone}");
            await _userManager.SetPhoneNumberAsync(user, userInfo.Phone);
        }

        if (user.UserName != userInfo.UserName)
        {
            _logger.LogInformation(
                $"Handling UserLoggedInEvent... Updating the user name with:{userInfo.UserName}");
            await _userManager.SetUserNameAsync(user, userInfo.UserName);
        }
    }
}