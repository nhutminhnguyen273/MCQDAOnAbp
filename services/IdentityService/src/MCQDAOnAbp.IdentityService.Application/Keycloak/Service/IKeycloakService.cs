using Keycloak.Net.Models.Roles;
using Keycloak.Net.Models.Users;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MCQDAOnAbp.IdentityService.Keycloak.Service;

public interface IKeycloakService : ITransientDependency
{
    Task<List<CachedKeycloakUser>> GetUsersAsync(string search = null, string username = null, string email = null, CancellationToken cancellationToken = default);

    Task<bool> CreateUserAsync(User user, CancellationToken cancellationToken = default);

    Task<bool> UpdateUserAsync(string userId, User user, CancellationToken cancellationToken = default);

    Task<bool> DeleteUserAsync(string userId, CancellationToken cancellationToken = default);

    Task<List<CachedKeycloakRole>> GetRolesAsync(CancellationToken cancellationToken = default);

    Task<bool> AddRealmRolesToUserAsync(string userId, IEnumerable<Role> roles, CancellationToken cancellationToken = default);

    Task<bool> RemoveRealmRolesFromUserAsync(string userId, IEnumerable<Role> roles, CancellationToken cancellationToken = default);

    Task<bool> CreateRoleAsync(string name, CancellationToken cancellationToken = default);

    Task<bool> DeleteRoleByIdAsync(string id, CancellationToken cancellationToken = default);

    Task<bool> UpdateRoleAsync(string id, Role role, CancellationToken cancellationToken = default);

    Task<bool> SetNewPassword(string username, string newPassword, CancellationToken cancellationToken = default);
}
