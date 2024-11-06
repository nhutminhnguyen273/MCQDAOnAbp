using Keycloak.Net.Models.Roles;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace MCQDAOnAbp.IdentityService.Keycloak.Service
{
    public static class KeycloakServiceExtensions
    {
        public static string GenerateCacheKeyBasedOnValues(this IEnumerable<Role> roles)
        {
            return GenerateUniqueCacheKeyBasedOnList(roles);
        }

        private static string GenerateUniqueCacheKeyBasedOnList<T>(IEnumerable<T> list)
        {
            string serializedList = JsonSerializer.Serialize(list);
            byte[] bytes = Encoding.UTF8.GetBytes(serializedList);
            byte[] hash = SHA256.Create().ComputeHash(bytes);
            string hashString = BitConverter.ToString(hash).Replace("-", "");
            return hashString;
        }
    }
}
