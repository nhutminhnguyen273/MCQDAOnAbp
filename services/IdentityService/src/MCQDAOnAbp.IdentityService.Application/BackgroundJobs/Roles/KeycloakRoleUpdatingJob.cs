﻿using Keycloak.Net.Models.Roles;
using MCQDAOnAbp.IdentityService.Keycloak.Service;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.DependencyInjection;
using Volo.Abp.ObjectMapping;
using System.Linq;

namespace MCQDAOnAbp.IdentityService.BackgroundJobs.Roles;

public class KeycloakRoleUpdatingJob : AsyncBackgroundJob<IdentityRoleUpdatingArgs>, ITransientDependency
{
    private readonly IKeycloakService _keycloakService;
    private readonly ILogger<KeycloakRoleUpdatingJob> _logger;
    private readonly IObjectMapper _objectMapper;

    public KeycloakRoleUpdatingJob(IKeycloakService keycloakService, ILogger<KeycloakRoleUpdatingJob> logger,
        IObjectMapper objectMapper)
    {
        _keycloakService = keycloakService;
        _logger = logger;
        _objectMapper = objectMapper;
    }

    public override async Task ExecuteAsync(IdentityRoleUpdatingArgs args)
    {
        try
        {
            var existingRole = (await _keycloakService.GetRolesAsync()).FirstOrDefault(q => q.Name == args.OldName);
            if (existingRole == null)
            {
                _logger.LogWarning($"Role with the name:{args.OldName} couldn't be found to update!");
                return;
            }

            if (args.OldName != args.NewName)
            {
                existingRole.Name = args.NewName;

                await _keycloakService.UpdateRoleAsync(existingRole.Id,
                    _objectMapper.Map<CachedKeycloakRole, Role>(existingRole)
                );
            }
        }
        catch (Exception e)
        {
            _logger.LogWarning($"Could not update the role with the name:{args.OldName} from Keycloak server!");
            throw;
        }
    }
}

public record IdentityRoleUpdatingArgs(string OldName, string NewName);