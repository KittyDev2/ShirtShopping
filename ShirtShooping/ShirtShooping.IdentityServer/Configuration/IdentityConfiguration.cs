using Duende.IdentityServer.Models;

namespace ShirtShooping.IdentityServer.Configuration;

public static class IdentityConfiguration
{
    public const string Admin = "Admin";
    public const string Customer = "Customer";

    public static IEnumerable<IdentityResource> IdentityResources =>
        new List<IdentityResource>()
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Email(),
            new IdentityResources.Profile()

        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new List<ApiScope>()
        {
            new ApiScope("shirt_shopping", "ShirtShopping Server"),
            new ApiScope("read", "Read Data."),
            new ApiScope("write", "Write Data."),
            new ApiScope("delete", "Delete Data."),
        };

    public static IEnumerable<Client> Clients =>
        new List<Client>()
        {
            new Client
            {
                ClientId = "client",
                ClientSecrets = {new Secret("my_super_secret".Sha256())},
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                AllowedScopes = {"read", "write", "profile"}
            }
        };
}