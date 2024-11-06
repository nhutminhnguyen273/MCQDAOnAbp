﻿using AutoMapper;
using Keycloak.Net.Models.Roles;
using Keycloak.Net.Models.Users;
using MCQDAOnAbp.IdentityService.Keycloak.Service;

namespace MCQDAOnAbp.IdentityService;

public class IdentityServiceApplicationAutoMapperProfile : Profile
{
    public IdentityServiceApplicationAutoMapperProfile()
    {
        CreateMap<User, CachedKeycloakUser>().ReverseMap();
        CreateMap<UserAccess, CachedUserAccess>().ReverseMap();
        CreateMap<UserConsent, CachedUserConsent>().ReverseMap();
        CreateMap<Credentials, CachedCredentials>().ReverseMap();
        CreateMap<FederatedIdentity, CachedFederatedIdentity>();

        CreateMap<Role, CachedKeycloakRole>().ReverseMap();
        CreateMap<RoleComposite, CachedRoleComposite>().ReverseMap();
    }
}
