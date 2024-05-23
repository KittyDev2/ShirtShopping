using Microsoft.AspNetCore.Identity;

namespace ShirtShooping.IdentityServer.Model;

public class ApplicationUser : IdentityUser
{
    private string FirstName { get; set; }
    private string LastName { get; set; }
}